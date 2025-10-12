using System;
using zLearnHub.Data;
using System.Data.SqlClient;
using System.Configuration;
using Newtonsoft.Json;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Web.UI.WebControls;

namespace zLearnHub.Rules
{
    public partial class SharedBusinessRules : zLearnHub.Data.BusinessRules
    {
        public SharedBusinessRules()
        {
        }

        // access restrictions to Gradebook Entry
        [AccessControl("UserId", Sql =
            @"SELECT DISTINCT UserId FROM GradeBookEntry WHERE UserId = @Userid")]
        public void RestrictGradeBookEntry()
        {
            if (!UserIsInRole("Administrators", "HeadTeacher", "ContentEditors"))
                RestrictAccess("@UserId", UserId);
        }

        // access restrictions to LearningObjective
        [AccessControl("UserId", Sql =
            @"SELECT DISTINCT UserId from LearningObjective where UserId = @Userid")]
        public void RestrictStudentLearningObjectiveforSubjectTeachers()
        {
            if (!UserIsInRole("Administrators", "HeadTeacher", "ContentEditors"))
                RestrictAccess("@UserId", UserId);
        }


        protected override void VirtualizeController(string controllerName)
        {
            base.VirtualizeController(controllerName);
            NodeSet().SelectCategory("c1").SetHeaderText(string.Empty).SetDescription(string.Empty);

            // UI customisation for all controllers
            // Customize views based on the user's device type (mobile or laptop)
            string userAgent = System.Web.HttpContext.Current.Request.UserAgent.ToLower();
            bool isMobile = userAgent.Contains("iphone") || userAgent.Contains("android") || userAgent.Contains("blackberry") || userAgent.Contains("windows ce") || userAgent.Contains("opera mini") || userAgent.Contains("mobile") || userAgent.Contains("palm") || userAgent.Contains("portable");
            if (isMobile && controllerName != "PhotoAlbum")
            {
                NodeSet()
                    .SelectView("grid1")
                    .SetTag("view-style-grid-disabled view-style-list view-style-cards view-style-charts")
                    .SelectDataField("Fullname").Show();

                NodeSet().SelectView("grid1_mobi")
                    .SetTag("view-style-grid-disabled view-style-list view-style-cards view-style-charts");
            }

            if (controllerName == "StudentSchoolAssociation")
            {
                NodeSet()
                    .SelectView("grid1")
                    .SelectDataField("FoodServices").Hide()
                    .SelectDataField("CSY").Hide()
                    .SelectDataField("MFD").Hide()
                    .SelectDataField("Fullname").Delete()
                    .SelectDataField("SEID").Hide()
                    //.SelectDataField("Lastname").Hide()
                    .SelectDataField("Lastname").Hide();
            }



            //hide Fullname field in the StudentGradeBookEntry controller nodeset
            if (!isMobile && controllerName == "StudentGradeEntryBook")
            {
                NodeSet().SelectView("grid1").SelectDataField("Fullname").Hide()
                                             .SelectDataField("Lastname").Show()
                                             .SelectDataField("Firstname").Show();

                NodeSet().SelectView("grid1_mobi").SelectDataField("Fullname").Show()
                                                  .SelectDataField("Lastname").Hide()
                                                  .SelectDataField("Firstname").Hide();
                NodeSet().SelectView("grid1_expanded_view").SetShowInSelector("true");

            }




            if (controllerName == "OrganizationPersonRoleStudent")
            {
                NodeSet()
                    .SelectView("editForm1")
                    .SetLabel("Photo").SetHeaderText(string.Empty).SetDescription(string.Empty);
            }

            if (controllerName == "StudentGradeBookEntry")
            {
                NodeSet()
                    .SelectField("SCID").Hide();

            }

            //detail access controll formulation
            if ((controllerName == "fee_collection_transaction" || controllerName == "fee_collection_transaction_itemised" || controllerName == "znfee_collection_transaction_itemised_detail") && !UserIsInRole("Administrators"))
            {
                // make the controller read-only by removing editing actions
                NodeSet("view[@id='grid1']").SelectActions("Delete").Delete();
                NodeSet("view[@id='editForm1']").SelectActions("Delete").Delete();

            }

            if (controllerName == "Contact" && !UserIsInRole("Administrators, ContentEditors"))
            {
                NodeSet("view[@id='grid1']").SelectView("grid1").SelectActions("New, Edit, Delete")
                    .Delete();

            }

            if ((controllerName == "WorkBenchTheStock" || controllerName == "MovementMode" && !UserIsInRole("Administrators")))
            {
                // make the controller read-only by removing editing actions

                NodeSet().SelectCategory("c5").Hide();
                NodeSet().SelectCategory("c5").Delete();
            }

            if (controllerName == "account_general_ledger" || controllerName == "ManualAccountJournalEntries" && !UserIsInRole("Administrators"))
            {
                NodeSet("view[@id='grid1']").SelectView("grid1").SelectActions("Delete").Delete();
                NodeSet().SelectAction("Delete").Delete();
            }


        }



        protected override void BeforeSqlAction(ActionArgs args, ActionResult result)
        {
            base.BeforeSqlAction(args, result);
            // Check if the request is trying to delete a payment in FeeCollections
            if (args.Controller == "fee_collection_transaction" && args.CommandName == "Delete")
            {
                if (!UserIsInRole("Administrators, HeadTeachers"))
                {
                    // Add a custom error message
                    //result.Errors.Add("You do not have permission to delete payment records. Please contact an administrator.");
                    result.ShowAlert("You do not have permission to delete payment records. Escalate to a higher authority");

                }
            }

            if (args.Controller == "account_general_ledger" && args.CommandName == "Delete")
            {
                if (!UserIsInRole("Administrators, HeadTeachers"))
                {
                    //result.Errors.Add("You do not have permission to delete account general ledger records. Please contact an administrator.");
                    result.ShowAlert("Sorry, You do have permission to delete financial records. Please discuss with administrative head.");
                }
            }

            if (args.Controller == "ManualAccountJournalEntries" && args.CommandName == "Delete")
            {
                if (!UserIsInRole("Administrators, HeadTeachers"))
                {
                    result.ShowAlert("You do not have permission to delete financial records. Please discuss with administrative head.");
                }
            }

            // this is to prevent editing of purchase orders that have been received

            if (args.Controller == "PurchaseOrder" && args.CommandName == "Update")
            {
                if (UserIsInRole("Administrators, HeadTeachers"))
                {

                    var status = Convert.ToString(SelectFieldValue("Status"));
                    if (status == "Received")
                    {
                        //throw new Exception("Received purchase orders cannot be edited.");
                        result.ShowAlert("You do not have permission to edit financial records. Please discuss with administrative head.");
                    }
                }
            }

        }


        protected override void AfterSqlAction(ActionArgs args, ActionResult result)
        {
            if (args.CommandName == "Insert" || args.CommandName == "Update" || args.CommandName == "Delete")
            {
                // Fix: Ensure proper type conversion from FieldValue to int  
                var courseSectionIdField = args.SelectFieldValueObject("CourseSectionID");
                var streamIdField = args.SelectFieldValueObject("RefSchoolStreamID");

                if (courseSectionIdField != null && streamIdField != null)
                {
                    int courseSectionId = Convert.ToInt32(courseSectionIdField.Value);
                    int streamId = Convert.ToInt32(streamIdField.Value);

                    SqlText.ExecuteNonQuery(
                        "EXEC dbo.usp_merge_master_update_gradebookentry_weight_threshold_check @CourseSectionID, @RefSchoolStreamID",
                        new { CourseSectionID = courseSectionId, RefSchoolStreamID = streamId }
                    );
                }
            }
        }


        [ControllerAction("StockTransactions", "Insert, Update, Calculate", ActionPhase.After)]
        public void AddOrUpdateStockTransaction()
        {

            object transactionsIDValue = SelectFieldValue("TransactionsID");

            if (transactionsIDValue == null)
                throw new Exception("Transactions ID is required.");

            int transactionsID;
            try
            {
                transactionsID = Convert.ToInt32(transactionsIDValue);

            }
            catch (InvalidCastException)
            {
                throw new Exception("Product ID is not a valid integer.");
            }

            // Get connection string from configuration
            string connectionString = ConfigurationManager.ConnectionStrings["zLearnHub"].ConnectionString;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand("zusp_stock_AddStockTransaction", connection))
                {
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@TransactionsID", transactionsID);
                    command.CommandTimeout = 0; // Set timeout to 0 for no limit
                    command.ExecuteNonQuery();
                }
            }

            Result.ShowAlert("Stock transaction added successfully.");

        }



        [ControllerAction("BorrowTransactions", "Insert, Update, Calculate", ActionPhase.After)]
        public void BeforeInsertBorrowTransaction()
        {

            object bookIDValue = SelectFieldValue("BookID");

            if (bookIDValue == null)
                throw new Exception("Book ID is required.");

            int bookID;
            try
            {
                bookID = Convert.ToInt32(bookIDValue);

            }
            catch (InvalidCastException)
            {
                throw new Exception("Book ID is not a valid integer.");
            }


            // Get connection string from configuration
            string connectionString = ConfigurationManager.ConnectionStrings["zLearnHub"].ConnectionString;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand("zusp_ops_book_BorrowBook", connection))
                {
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@BookID", bookID);
                    command.CommandTimeout = 0; // Set timeout to 0 for no limit
                    command.ExecuteNonQuery();
                }

            }

            Result.ShowAlert("Lending transaction added successfully.");

        }


        [ControllerAction("UpdateCompensation", "Insert, Update, Calculate", ActionPhase.After)]
        public void RefreshCompensation()
        {

            object salaryIDValue = SelectFieldValue("SalaryID");

            if (salaryIDValue == null)
                throw new Exception("Salary ID is required.");

            int salaryID;
            try
            {
                salaryID = Convert.ToInt32(salaryIDValue);

            }
            catch (InvalidCastException)
            {
                throw new Exception("Salary ID is not a valid integer.");
            }


            // Get connection string from configuration
            string connectionString = ConfigurationManager.ConnectionStrings["zLearnHub"].ConnectionString;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand("zusp_ops_salary_p1_prepare_information_specific", connection))
                {
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@SalaryID", salaryID);
                    command.CommandTimeout = 0; // Set timeout to 0 for no limit
                    command.ExecuteNonQuery();
                }

            }

            Result.Refresh();
            Result.RefreshChildren();
            Result.ShowAlert("Salary information updated successfully.");

        }


        
        [ControllerAction("usp_process_fee_collection_transaction", "Insert, Update, Calculate", ActionPhase.After)]
        public void process_fee_collection_transaction()
        {

            object transactionIDValue = SelectFieldValue("TransactionID");

            if (transactionIDValue == null)
                throw new Exception("TransactionID is required.");

            int transactionID;
            try
            {
                transactionID = Convert.ToInt32(transactionIDValue);

            }
            catch (InvalidCastException)
            {
                throw new Exception("Transaction ID is not a valid integer.");
            }


            // Get connection string from configuration
            string connectionString = ConfigurationManager.ConnectionStrings["zLearnHub"].ConnectionString;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand("usp_process_fee_collection_transaction", connection))
                {
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@TransactionID", transactionID);
                    command.CommandTimeout = 0; // Set timeout to 0 for no limit
                    command.ExecuteNonQuery();
                }
            }

            Result.Refresh();
            Result.RefreshChildren();
            Result.ShowAlert("Fee collection process updated successfully.");

        }

        [ControllerAction("fee_collection_transaction", "Custom, ProcessRefund", ActionPhase.After)]
        public void ProcessFeeRefund(int OriginalTransactionID, decimal RefundAmountToProcess)
        {
            // Get connection string from configuration
            string connectionString = ConfigurationManager.ConnectionStrings["zLearnHub"].ConnectionString;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand("usp_ops_p9_create_fee_refund_transaction_revised_2", connection))
                {
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@TransactionID", OriginalTransactionID);
                    command.Parameters.AddWithValue("@RefundAmountToProcess", RefundAmountToProcess);
                    command.ExecuteNonQuery();
                }
            }

            // Optional: Add a user notification
            Result.Refresh();
            Result.RefreshChildren();
            Result.ShowAlert("Refund processed successfully.");
        }


        [ControllerAction("ProcessPurchaseOrder", "Insert, Update, Calculate", ActionPhase.After)]
        public void process_purchase_order_from_order_details(int purchaseOrderID)
        {

            // Get connection string from configuration
            string connectionString = ConfigurationManager.ConnectionStrings["zLearnHub"].ConnectionString;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand("zusp_ops_process_purchase_order", connection))
                {
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@PurchaseOrderID", purchaseOrderID);
                    command.ExecuteNonQuery();
                }
            }
            Result.Refresh();
            Result.RefreshChildren();
            Result.ShowAlert("Stock Levels updated from purchase order detail successfully.");

        }

        

        public class StudentEntry
        {
            public string FirstName { get; set; }
            public string SubjectName { get; set; }
            public string NumericGrade { get; set; }
            public string OverallScore { get; set; }
            public int EntryID { get; set; }
        }

        public class OpenAiChoice
        {
            public OpenAiMessage message { get; set; }
        }

        public class OpenAiMessage
        {
            public string content { get; set; }
        }

        public class OpenAiResponse
        {
            public List<OpenAiChoice> choices { get; set; }
        }

        [ControllerAction("StudentGradeBookEntry", "Custom", "generate_summarised_remarks")]
        public void write_ai_supported_remarks()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["zLearnHub"].ConnectionString;
            string apiKey = ConfigurationManager.AppSettings["OpenAIApiKey"];

            string sql = @"
                        SELECT  
                            s.extFirstName AS FirstName,
                            s.extLastName AS LastName,
                            g.extCourseTitle as Course,
                            g.NumericGradeEarned,
                            g.extOWS AS OverallScore,
                            g.StudentGradeBookEntryID,
                            s.RemarkID,
                            s.Note
                        FROM 
                            StudentRemarks s
                            LEFT JOIN StudentGradeBookEntry g ON g.extStudentEnrollmentID = s.StudentEnrollmentID and s.PersonID = g.extPersonID
                        WHERE 
                            s.Note IS NULL OR s.Note = ''
                            AND g.extIsActiveSession = 1 ";

            var entries = new List<StudentEntry>();

            using (var con = new SqlConnection(connectionString))
            {
                con.Open();
                using (var cmd = new SqlCommand(sql, con))
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var entry = new StudentEntry
                        {
                            FirstName = reader["FirstName"].ToString(),
                            SubjectName = reader["Course"].ToString(),
                            NumericGrade = reader["NumericGradeEarned"].ToString(),
                            OverallScore = reader["OverallScore"].ToString(),
                            EntryID = Convert.ToInt32(reader["StudentGradeBookEntryID"])
                        };
                        entries.Add(entry);
                    }
                }
            }

            if (entries.Count == 0)
            {
                Result.ShowMessage("No matching records found.");
                return;
            }

            using (var client = new HttpClient())
            {
                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", apiKey);

                foreach (var entry in entries)
                {
                    string prompt = string.Format(
                        "Write a personalized remark for a student named {0} based on the following performance:\n" +
                        "Subject: {1}, Grade: {2}, Overall Score: {3}.\n" +
                        "Mention strengths, one area for improvement, and include motivation.",
                        entry.FirstName, entry.SubjectName, entry.NumericGrade, entry.OverallScore
                    );

                    var requestBody = new
                    {
                        model = "gpt-3.5-turbo",
                        messages = new[] { new { role = "user", content = prompt } }
                    };

                    var jsonContent = new StringContent(
                        JsonConvert.SerializeObject(requestBody),
                        Encoding.UTF8,
                        "application/json"
                    );

                    var response = client.PostAsync("https://api.openai.com/v1/chat/completions", jsonContent).Result;

                    if (response.IsSuccessStatusCode)
                    {
                        var responseContent = response.Content.ReadAsStringAsync().Result;
                        var parsed = JsonConvert.DeserializeObject<OpenAiResponse>(responseContent);
                        string generatedRemark = parsed.choices[0].message.content;

                        SqlText sqlUpdate = new SqlText("UPDATE StudentRemarks SET Note = @Note WHERE PersonID = @ID");
                        sqlUpdate.AddParameter("@Note", generatedRemark);
                        sqlUpdate.AddParameter("@ID", entry.EntryID);
                        sqlUpdate.ExecuteNonQuery();
                    }
                    else
                    {
                        Result.ShowMessage("Error from ChatGPT: " + response.StatusCode);
                    }
                }
            }

            Result.ShowMessage(string.Format("{0} remark(s) successfully generated and saved.", entries.Count));
        }



      
        private void CallChatGptAndSave(string prompt, int entryId)
        {
            string apiKey = "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";

            var requestBody = new
            {
                model = "gpt-3.5-turbo",
                messages = new[] {
                        new { role = "user", content = prompt }
                    }
            };

            var jsonContent = new StringContent(JsonConvert.SerializeObject(requestBody), System.Text.Encoding.UTF8, "application/json");

            ////using (HttpClient client = new HttpClient())
            using (var client = new HttpClient())
            {
                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", apiKey);
                var response = client.PostAsync("https://api.openai.com/v1/chat/completions", jsonContent).Result;

                if (response.IsSuccessStatusCode)
                {
                    var responseContent = response.Content.ReadAsStringAsync().Result;
                    dynamic parsed = JsonConvert.DeserializeObject(responseContent);
                    string generatedRemark = parsed.choices[0].message.content;

                    //SqlText sql = new SqlText("UPDATE StudentGradeBookEntry SET Statement = @Statement WHERE StudentGradeBookEntryID = @ID");


                    SqlText sql = new SqlText(@" UPDATE s
                                                    SET Note = @Note
                                                 FROM StudentRemarks s
                                                 LEFT JOIN StudentGradeBookEntry g ON g.extStudentEnrollmentID = s.StudentEnrollmentID and s.PersonID = g.extPersonID
                                                 WHERE s.StudentEnrollmentID = StudentEnrollmentID  AND s.PersonID = @PersonID"
                                                );


                    sql.AddParameter("@Note", generatedRemark);
                    sql.AddParameter("@PersonID", entryId);
                    sql.ExecuteNonQuery();

                    Result.ShowMessage("Remark successfully generated and saved.");
                }
                else
                {
                    Result.ShowMessage("Error from ChatGPT: " + response.StatusCode);
                    //AiLogger aiLogger = new AiLogger();

                }
            }
        }

      



        public class AiLogger
        {
            public void LogAiFailure(int entryId, string prompt, string error)
            {
                try
                {
                    SqlText log = new SqlText("INSERT INTO AIInteractionLog (EntryID, Prompt, ErrorMessage, CreatedOn) VALUES (@ID, @Prompt, @Error, @CreatedOn)");
                    log.AddParameter("@ID", entryId);
                    log.AddParameter("@Prompt", prompt);
                    log.AddParameter("@Error", error);
                    log.AddParameter("@CreatedOn", DateTime.UtcNow);
                    log.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error logging AI failure: " + ex.Message);
                }
            }
        }


        [ControllerAction("GradeBookEntry", "Custom", "GenerateScoresheet")]
        public void GenerateScoreSheetFromGBAPlan(int gradeBookEntryID)
        {

            // Get connection string from configuration
            string connectionString = ConfigurationManager.ConnectionStrings["zLearnHub"].ConnectionString;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand("usp_merge_master_student_grades_gradebooks_p1", connection))
                {
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@GradeBookEntryID", gradeBookEntryID);
                    command.ExecuteNonQuery();
                }
            }

            Result.RefreshChildren();
            Result.ShowAlert("Student scoresheets have been successfully prepared.");

        }

        //// implemented to circumvent the issue of not being able to update the large no. of records table directly from the UI
        [ControllerAction("StudentGradeBookEntry", "Custom", "PostCurrentGBAScoreRecords")]

        public void PostCurrentGBAScores()
        {

            // Get connection string from configuration
            string connectionString = ConfigurationManager.ConnectionStrings["zLearnHub"].ConnectionString;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand("usp_merge_master_student_grades_gradebooks_p4", connection))
                {
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    command.CommandTimeout = 0; // Set timeout to 0 for no limit
                    command.ExecuteNonQuery();

                }
            }

            Result.Refresh();
            Result.ShowAlert("GBA Scores have been updated successfully for the selected class and streams.");

        }

        // implemented to circumvent the issue of not being able to update the large no. of records table directly from the UI
        [ControllerAction("StudentGradeBookEntry", "Custom", "PostScoresWithOptimisedProc")]

        public void PostLargeDatasetWithOptimisedProc()
        {

            // Get connection string from configuration
            string connectionString = ConfigurationManager.ConnectionStrings["zLearnHub"].ConnectionString;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand("usp_merge_master_student_grades_gradebooks_p4_powerpost", connection))
                {
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    command.CommandTimeout = 0; // Set timeout to 0 for no limit
                    command.ExecuteNonQuery();
                }
            }

            Result.Refresh();
            Result.ShowAlert("GBA Scores have been updated successfully via Power Post.");

        }

        // still in development and testing
        [ControllerAction("StudentGradeBookEntry", "Custom", "ProcessFilteredRecords")]

        public void ProcessFilteredScoreRecords(ActionArgs args)
        {

            if (args == null)
                args = new ActionArgs();
            args.Filter = args.Filter ?? new string[] { }; // Ensure Filter is not null

            int? RefGradeLevelID = null;
            int? RefSchoolStreamID = null;


            if (args.Filter != null)
            {
                foreach (var filter in args.Filter) // each filter is like "FieldName:=Value"
                {
                    if (filter.Equals("GradeLevelID", StringComparison.OrdinalIgnoreCase))
                    {
                        var parts = filter.Split(new[] { ":=" }, StringSplitOptions.None);
                        if (parts.Length > 1)
                        {
                            int gradeLevel;
                            if (int.TryParse(parts[1], out gradeLevel))
                                RefGradeLevelID = gradeLevel;
                        }
                    }
                    else if (filter.Equals("StreamID", StringComparison.OrdinalIgnoreCase))
                    {
                        var parts = filter.Split(new[] { ":=" }, StringSplitOptions.None);
                        if (parts.Length > 1)
                        {
                            int stream;
                            if (int.TryParse(parts[1], out stream))
                                RefSchoolStreamID = stream;
                        }
                    }
                }
            }

            // Get connection string from configuration
            string connectionString = ConfigurationManager.ConnectionStrings["zLearnHub"].ConnectionString;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand("usp_merge_master_student_grades_gradebooks_p4_gradelevel_based_ds", connection))
                {
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@RefGradeLevelID", RefGradeLevelID ?? (object)DBNull.Value);
                    command.Parameters.AddWithValue("@RefSchoolStreamID", RefSchoolStreamID ?? (object)DBNull.Value);
                    command.CommandTimeout = 0; // Set timeout to 0 for no limit
                    command.ExecuteNonQuery();
                }
            }
            if (args.Filter != null)
            {
                Result.Refresh();
                Result.ShowAlert("GBA Scores have been updated successfully for the selected class and streams.");

            }


        }

        // implemented to circumvent the issue of not being able to update the large no. of records table directly from the UI
        [ControllerAction("ChronicAbsenteeReport", "Custom", "UpdateAttendanceRepo")]

        public void RefreshAttendancesBaseHist()
        {

            // Get connection string from configuration
            string connectionString = ConfigurationManager.ConnectionStrings["zLearnHub"].ConnectionString;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand("zusp_etl_zvw_metric_attendances_base_hist", connection))
                {
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    command.CommandTimeout = 0; // Set timeout to 0 for no limit
                    command.ExecuteNonQuery();
                }
            }

            Result.Refresh();
            Result.ShowAlert("The student attendance update has completed successfully");

        }


        [ControllerAction("StudentGradeBookEntry", "Custom", "reset_and_update_logos")]
        public void usp_ops_reset_and_update_logos()
        {

            // Get connection string from configuration
            string connectionString = ConfigurationManager.ConnectionStrings["zLearnHub"].ConnectionString;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand("usp_ops_reset_and_update_logos", connection))
                {
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    command.CommandTimeout = 0;
                    command.ExecuteNonQuery();
                }
            }
            Result.Refresh();
            Result.ShowAlert("Logos have been successfully updated for reports.");

        }

        [ControllerAction("StudentGradeBookEntry", "Custom", "reset_and_update_photos")]
        public void usp_ops_reset_and_update_photos()
        {

            // Get connection string from configuration
            string connectionString = ConfigurationManager.ConnectionStrings["zLearnHub"].ConnectionString;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand("usp_ops_reset_and_update_photos ", connection))
                {
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    command.CommandTimeout = 0; // Set timeout to 0 for no limit
                    command.ExecuteNonQuery();
                    
                }
            }

            Result.Refresh();
            Result.ShowAlert("Student photos have been successfully updated for reports.");

        }

    }
}



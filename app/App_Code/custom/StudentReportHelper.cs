
using Microsoft.Reporting.WebForms;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.IO;
using System.Data.SqlClient;

public class StudentReportHelper
{
    public static Dictionary<int, byte[]> GetAllStudentsReportData()
    {
        // Fetch all student records  
        DataTable dt = GetAllStudentsDataInternal();

        LocalReport report = new LocalReport();
        report.ReportPath = HttpContext.Current.Server.MapPath("~/Reports/HistoricalGrades_grid1_attainment_with_photos.rdlc");

        report.DataSources.Clear();
        report.DataSources.Add(new ReportDataSource("StudentDataSet", dt));

        // Additional logic to generate and return report data as a dictionary  
        Dictionary<int, byte[]> reportData = new Dictionary<int, byte[]>();
        // Example: Populate the dictionary with dummy data  
        foreach (DataRow row in dt.Rows)
        {
            int studentId = Convert.ToInt32(row["PersonID"]);
            byte[] dummyReportBytes = new byte[0]; // Replace with actual report generation logic  
            reportData[studentId] = dummyReportBytes;
        }

        return reportData;
    }

    private static DataTable GetAllStudentsDataInternal()
    {
        DataTable dt = new DataTable();
        using (SqlConnection conn = new SqlConnection("zLearnHub"))
        {
            string sql = @"  
                SELECT *  
                FROM master_student_grades_gradebooks_p4  
                ORDER BY PersonID"; // ensure consistent ordering  
            using (SqlDataAdapter da = new SqlDataAdapter(sql, conn))
            {
                da.Fill(dt);
            }
        }
        return dt;
    }
}

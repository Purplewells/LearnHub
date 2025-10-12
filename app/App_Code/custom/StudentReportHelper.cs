
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

        string deviceInfo = "<DeviceInfo>" +
                             "<OutputFormat>PDF</OutputFormat>" +
                             "<PageWidth>8.5in</PageWidth>" +
                             "<PageHeight>11in</PageHeight>" +
                             "<MarginTop>0.25in</MarginTop>" +
                             "<MarginLeft>0.25in</MarginLeft>" +
                             "<MarginRight>0.25in</MarginRight>" +
                             "<MarginBottom>0.25in</MarginBottom>" +
                             "</DeviceInfo>";

        Warning[] warnings;
        string[] streamIds;
        string mimeType;
        string encoding;
        string extension;

        // Render the report as a byte array  
        byte[] reportBytes = report.Render("PDF", deviceInfo, out mimeType, out encoding, out extension, out streamIds, out warnings);

        // Create a dictionary to map student IDs to the report bytes  
        Dictionary<int, byte[]> reportData = new Dictionary<int, byte[]>();

        foreach (DataRow row in dt.Rows)
        {
            int studentId = Convert.ToInt32(row["PersonID"]);
            reportData[studentId] = reportBytes; // Assign the same report bytes to each student ID  
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

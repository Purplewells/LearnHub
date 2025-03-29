using System;
using System.Data.Common;
using System.Data.SqlClient;
using System.Web.Configuration;

/// <summary>
/// Summary description for IncreaseTimeOut
/// </summary>
namespace zLearnHub.Data
{
  //public class CustomSqlText : SqlText
  //  {
  //      private int _commandTimeout = 0;
        //    static CustomSqlText()
        //    {
        //        // Retrieve the connection string and extract our custom CommandTimeout parameter.
        //        string connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
        //        _commandTimeout = ExtractCommandTimeout(connectionString, 300);
        //    }

        //    public CustomSqlText(string text) : base(text) { }

        //    protected override SqlCommand CreateCommand(SqlConnection connection)
        //    {
        //        SqlCommand cmd = base.CreateCommand(connection);
        //        cmd.CommandTimeout = _commandTimeout;  // Apply the global timeout.
        //        return cmd;
        //    }

        //    private static int ExtractCommandTimeout(string connectionString, int defaultTimeout)
        //    {
        //        if (!string.IsNullOrEmpty(connectionString))
        //        {
        //            // Split the connection string into key-value pairs.
        //            string[] parts = connectionString.Split(';');
        //            foreach (string part in parts)
        //            {
        //                string[] pair = part.Split('=');
        //                if (pair.Length == 2 && pair[0].Trim().Equals("CommandTimeout", StringComparison.OrdinalIgnoreCase))
        //                {
        //                    if (int.TryParse(pair[1].Trim(), out int timeout))
        //                        return timeout;
        //                }
        //            }
        //        }
        //        return defaultTimeout;
        //    }
    //}
}
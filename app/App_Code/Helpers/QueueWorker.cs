using System;
using System.Data.SqlClient;
using System.Threading;
using System.Configuration;
using System.Web.Hosting;

public static class QueueWorker
{
    private static Timer _timer;
    private static bool _isRunning;
    private static bool _initialized;
    private static readonly object _lock = new object();

    // How often to poll the queue
    private static readonly TimeSpan _interval = TimeSpan.FromSeconds(30);

    public static void Start()
    {
        // Prevent duplicate initialization
        if (_initialized)
            return;

        lock (_lock)
        {
            if (_initialized)
                return;

            _initialized = true;

            // Use HostingEnvironment.QueueBackgroundWorkItem to survive short recycles
            HostingEnvironment.QueueBackgroundWorkItem(ct =>
            {
                _timer = new Timer(ProcessQueue, null, TimeSpan.Zero, _interval);
            });

            Log("QueueWorker started at " + DateTime.Now);
        }
    }

    private static void ProcessQueue(object state)
    {
        if (_isRunning) return;
        _isRunning = true;

        try
        {
            string connStr = ConfigurationManager.ConnectionStrings["zLearnHub"].ConnectionString;
            using (var conn = new SqlConnection(connStr))
            using (var cmd = new SqlCommand("EXEC usp_ProcessSyncQueue", conn))
            {
                conn.Open();
                cmd.ExecuteNonQuery();
            }

            Log("Processed SyncQueue at " + DateTime.Now);
        }
        catch (Exception ex)
        {
            Log("Error in QueueWorker: " + ex.Message);
        }
        finally
        {
            _isRunning = false;
        }
    }

    private static void Log(string message)
    {
        try
        {
            string path = HostingEnvironment.MapPath("~/App_Data/queueworker.log");
            System.IO.File.AppendAllText(path, message + Environment.NewLine);
        }
        catch
        {
            // ignore logging errors
        }
    }
}

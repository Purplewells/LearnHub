using System;
using System.Web;

namespace LearnHub
{
    public class Global : HttpApplication
    {
        protected void Application_Start(object sender, EventArgs e)
        {
            QueueWorker.Start();  // initialize your background queue worker
        }
    }
}

﻿<%@ Application Language="C#" %>

<script runat="server">
void Application_Start(object sender, EventArgs e)
{
    // *********************************************************************************************
    // You may get a compilation error message if you change the namespace of the project.
    // This file will not be re-generated. Namespace "zLearnHub" must be changed manually.
    // *********************************************************************************************
    // Fires on application startup
    zLearnHub.Services.ApplicationServices.Start();
}

void Application_End(object sender, EventArgs e)
{
    // Fires on application shutdown
    zLearnHub.Services.ApplicationServices.Stop();
}

void Application_Error(object sender, EventArgs e)
{
    
    // Fires when an unhandled error occurs (default from CodeOnTime)
    zLearnHub.Services.ApplicationServices.Error();
}

void Session_Start(object sender, EventArgs e)
{
    // Fires when a new session is started
    zLearnHub.Services.ApplicationServices.SessionStart();
}

void Session_End(object sender, EventArgs e)
{
    // Fires when a session ends.
    // Note: The Session_End event is raised only when the sessionstate mode
    // is set to InProc in the Web.config file. If session mode is set to StateServer
    // or SQLServer, the event is not raised.
    zLearnHub.Services.ApplicationServices.SessionStop();
}


</script>
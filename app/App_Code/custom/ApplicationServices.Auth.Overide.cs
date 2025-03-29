using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using Newtonsoft.Json.Linq;
using zLearnHub.Data;

/// <summary>
/// Summary description for ApplicationServices
/// </summary>
namespace zLearnHub.Services
{
    public partial class ApplicationServices
    {
        protected override JObject CreateUserLoginResponse(string username, bool success)
        {
            
            var loginReponse = base.CreateUserLoginResponse(username, success);
            if (loginReponse == null)
            {
                if (!success)
                {
                    loginReponse = new JObject();
                    var user = Membership.GetUser(username);
                    if (user != null && user.IsLockedOut)
                        loginReponse["alert"] = "This user account has been locked";
                    else
                        loginReponse["notify"] = "Login has failed";
                }
            }
            return loginReponse;
        }

       
    }
}
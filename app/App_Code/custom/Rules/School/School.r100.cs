using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.Security;
using zLearnHub.Data;
using zLearnHub.Models;

namespace zLearnHub.Rules
{
    public partial class SchoolBusinessRules : zLearnHub.Rules.SharedBusinessRules
    {

        /// <summary>Rule "UpdateOrganisationAddress" implementation:
        /// This method will execute in any view after an action
        /// with a command name that matches "Insert|update".
        /// </summary>
        [Rule("r100")]
        public void r100Implementation(SchoolModel instance)
        {
            // This is the placeholder for method implementation.
            instance.OrganisationAddress = instance.SchoolAddress; 
         }
    }
}

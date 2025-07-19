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
    public partial class SchoolInstituitionBusinessRules : zLearnHub.Rules.SharedBusinessRules
    {

        /// <summary>Rule "UpdateOrganisationDetails" implementation:
        /// This method will execute in any view after an action
        /// with a command name that matches "Insert|update|Calculate".
        /// </summary>
        [Rule("r100")]
        public void r100Implementation(SchoolInstituitionModel instance)
        {
            // This is the placeholder for method implementation.
            instance.SchoolName = instance.OrganisationName.Trim();
            //instance.Address = instance.OrganisationAddress;
            instance.OrganisationAddress = instance.Address;
            
        }
    }
}

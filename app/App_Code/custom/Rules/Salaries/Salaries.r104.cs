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
    public partial class SalariesBusinessRules : zLearnHub.Rules.SharedBusinessRules
    {

        /// <summary>Rule "UpdateCompensation" implementation:
        /// This method will execute in any view after an action
        /// with a command name that matches "Insert|Update|Calculate".
        /// </summary>
        [Rule("r104")]
        public void r104Implementation(SalariesModel instance)
        {
            // This is the placeholder for method implementation.
        }
    }
}

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

        /// <summary>Rule "setBaseSalaryAmount" implementation:
        /// This method will execute in any view before an action
        /// with a command name that matches "New|Calculate|Update".
        /// </summary>
        [Rule("r101")]
        public void r101Implementation(SalariesModel instance)
        {
            // This is the placeholder for method implementation Ben.
            instance.BaseSalaryAmount = instance.TheSalaryBasisBaseAmount;
        }
    }
}

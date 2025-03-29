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
    public partial class SalaryComponentElementBusinessRules : zLearnHub.Rules.SharedBusinessRules
    {

        /// <summary>Rule "setAmount" implementation:
        /// This method will execute in any view before an action
        /// with a command name that matches "Insert|Update|Calculate".
        /// </summary>
        [Rule("r101")]
        public void r101Implementation(SalaryComponentElementModel instance)
        {
            // This is the placeholder for method implementation.

            //if (instance.TheBasisBaseAmount.HasValue)
            //{
            //    //instance.Amount = instance.BasisBaseAmount.Value;
                
            //}
        }
    }
}

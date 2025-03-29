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

        /// <summary>Rule "calculateAmountValue" implementation:
        /// This method will execute in any view after an action
        /// with a command name that matches "Calculate|Insert|Update".
        /// </summary>
        [Rule("r100")]
        public void r100Implementation(SalaryComponentElementModel instance)
        {

            // This is the placeholder for method implementation.
            // improve the code by adding comments and proper indentation




            if (instance.IsPercentBased == true && instance.AdjustmentFactor != null)
            {
                instance.AmountValue = instance.AdjustmentFactor * instance.Amount;
            }
            else 
            {
                instance.AmountValue = instance.Amount;
            }


            // This is the placeholder for method implementation.
            // improve the code by adding comments and proper indentation
            

         
           
        }
    }
}

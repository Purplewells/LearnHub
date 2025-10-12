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
    public partial class fee_collection_transaction_extraBusinessRules : zLearnHub.Rules.SharedBusinessRules
    {

        /// <summary>Rule "setFeeDescription" implementation:
        /// This method will execute in any view after an action
        /// with a command name that matches "GetFeeDetails".
        /// </summary>
        [Rule("r104")]
        public void r104Implementation(fee_collection_transaction_extraModel instance)
        {
            // This is the placeholder for method implementation.
            instance.Description = instance.FeeDescription + '-' + "test";
        }
    }
}

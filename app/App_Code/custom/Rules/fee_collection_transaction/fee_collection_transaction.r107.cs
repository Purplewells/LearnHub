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
    public partial class fee_collection_transactionBusinessRules : zLearnHub.Rules.SharedBusinessRules
    {

        /// <summary>Rule "refund_transaction" implementation:
        /// This method will execute in any view after an action
        /// with a command name that matches "Insert|Update".
        /// </summary>
        [Rule("r107")]
        public void r107Implementation(fee_collection_transactionModel instance)
        {
            // This is the placeholder for method implementation.
        }
    }
}

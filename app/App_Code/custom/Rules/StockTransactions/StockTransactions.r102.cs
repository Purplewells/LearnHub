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
    public partial class StockTransactionsBusinessRules : zLearnHub.Rules.SharedBusinessRules
    {

        /// <summary>Rule "StockTransactions" implementation:
        /// This method will execute in any view before an action
        /// with a command name that matches "Insert".
        /// </summary>
        [Rule("r102")]
        public void r102Implementation(StockTransactionsModel instance)
        {
            // This is the placeholder for method implementation.
            // write functionality using instance variable and update it.
            instance.Status = "Pending";
            instance.TransDescription = "Decsribe transaction here...";
        }
    }
}

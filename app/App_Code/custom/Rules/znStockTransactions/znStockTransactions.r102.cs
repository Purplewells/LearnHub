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
    public partial class znStockTransactionsBusinessRules : zLearnHub.Rules.SharedBusinessRules
    {

        /// <summary>Rule "StockTransactions" implementation:
        /// This method will execute in any view after an action
        /// with a command name that matches "Insert|Calculate|Update".
        /// </summary>
        [Rule("r102")]
        public void r102Implementation(znStockTransactionsModel instance)
        {
            // This is the placeholder for method implementation.
        }
    }
}

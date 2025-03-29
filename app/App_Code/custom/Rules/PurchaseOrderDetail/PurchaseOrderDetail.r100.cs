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
    public partial class PurchaseOrderDetailBusinessRules : zLearnHub.Rules.SharedBusinessRules
    {

        /// <summary>Rule "calculateExtendedCost" implementation:
        /// This method will execute in any view after an action
        /// with a command name that matches "Calculate".
        /// </summary>
        [Rule("r100")]
        public void r100Implementation(PurchaseOrderDetailModel instance)
        {
            // This is the placeholder for method implementation.

            instance.ExtendedCost = instance.UnitPrice * instance.Quantity;
        }
    }
}

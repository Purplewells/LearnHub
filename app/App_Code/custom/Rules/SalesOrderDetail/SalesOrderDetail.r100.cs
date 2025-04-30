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
    public partial class SalesOrderDetailBusinessRules : zLearnHub.Rules.SharedBusinessRules
    {

        /// <summary>Rule "SetExtendedPrice" implementation:
        /// This method will execute in any view for an action
        /// with a command name that matches "New|Update|Calculate".
        /// </summary>
        [Rule("r100")]
        public void r100Implementation(SalesOrderDetailModel instance)
        {
            // This is the placeholder for method implementation.
            // The actual method code is in the Rule file (r100.cs).
            // factor in nullability
            if (instance.UnitPrice != null && instance.Quantity != null)
            {
                if (instance.Quantity > 0)
                {
                    instance.ExtendedPrice = instance.UnitPrice * instance.Quantity;
                }
            }
            
        }
    }
}

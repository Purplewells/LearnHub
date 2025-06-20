﻿using System;
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
    public partial class StockVarianceOvertimeBusinessRules : zLearnHub.Rules.SharedBusinessRules
    {

        /// <summary>Rule "detectApprovalDate" implementation:
        /// This method will execute in any view after an action
        /// with a command name that matches "Calculate|Update".
        /// </summary>
        [Rule("r101")]
        public void r101Implementation(StockVarianceOvertimeModel instance)
        {
            // This is the placeholder for method implementation.
        }
    }
}

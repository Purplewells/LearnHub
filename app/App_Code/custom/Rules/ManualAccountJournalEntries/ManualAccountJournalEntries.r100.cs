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
    public partial class ManualAccountJournalEntriesBusinessRules : zLearnHub.Rules.SharedBusinessRules
    {

        /// <summary>Rule "setDefaultNote" implementation:
        /// This method will execute in any view for an action
        /// with a command name that matches "New".
        /// </summary>
        [Rule("r100")]
        public void r100Implementation(ManualAccountJournalEntriesModel instance)
        {
            // This is the placeholder for method implementation.
        }
    }
}

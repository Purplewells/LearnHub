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
    public partial class znStudentGradeBookEntryBusinessRules : zLearnHub.Rules.SharedBusinessRules
    {

        /// <summary>Rule "setOWSValue" implementation:
        /// This method will execute in any view for an action
        /// with a command name that matches "Insert|Update|Calculate".
        /// </summary>
        [Rule("r103")]
        public void r103Implementation(znStudentGradeBookEntryModel instance)
        {
            // This is the placeholder for method implementation.
        }
    }
}

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
    public partial class StudentGradeBookEntryBusinessRules : zLearnHub.Rules.SharedBusinessRules
    {

        /// <summary>Rule "setextSGID" implementation:
        /// This method will execute in any view for an action
        /// with a command name that matches "New|Calculate".
        /// </summary>
        [Rule("r104")]
        public void r104Implementation(StudentGradeBookEntryModel instance)
        {
            // This is the placeholder for method implementation.
            instance.extSGID = instance.SGID;
            instance.extSCID = instance.SCID;
        }
    }
}

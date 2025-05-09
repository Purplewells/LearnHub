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

        /// <summary>Rule "generate_summarised_notes" implementation:
        /// This method will execute in any view for an action
        /// with a command name that matches "Insert|Update|Calculate" and argument that matches "summarise_report".
        /// </summary>
        [Rule("r102")]
        public void r102Implementation(StudentGradeBookEntryModel instance)
        {

        }

     

    }
}

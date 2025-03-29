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

        /// <summary>Rule "setPBSGValue" implementation:
        /// This method will execute in any view for an action
        /// with a command name that matches "Insert|Update|Calculate".
        /// </summary>
        [Rule("r101")]
        public void r101Implementation(StudentGradeBookEntryModel instance)
        {
            // Calculate the % Partial Based Grading for awarding grading scale value    
            instance.ExtPBSG = (instance.NumericGradeEarned / instance.extMaxScore) *100;

            //Calculate the partial contribution of current score relative to the overall score
            instance.ExtPWS = (instance.NumericGradeEarned / instance.extMaxScore) * instance.Weight;

        }
    }
}

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

        /// <summary>Rule "validateNumericGradeEarned" implementation:
        /// This method will execute in any view before an action
        /// with a command name that matches "Insert|Update".
        /// </summary>
        [Rule("r106")]
        public void r106Implementation(StudentGradeBookEntryModel instance)
        {
            // This is the placeholder for method implementation.
            // check if NumericGradeEarned is greater than MaxScore then prevent the insert/update otherwise allow the insert/update
            // to happen
            if (instance.NumericGradeEarned > instance.MaxScore)
            {
                //throw new InValidGradeException("NumericGradeEarned cannot be greater than MaxScore");
                PreventDefault();
                Result.ShowMessage("NumericGradeEarned cannot be greater than MaxScore ");
                Result.Focus("NumericGradeEarned");
            }
            else
            {
                // allow the natural event flow

                

            }
            
        }
    }
}

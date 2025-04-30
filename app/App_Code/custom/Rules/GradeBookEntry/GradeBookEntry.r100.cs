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
    public partial class GradeBookEntryBusinessRules : zLearnHub.Rules.SharedBusinessRules
    {

        /// <summary>Rule "setGBAPlaceHolder" implementation:
        /// This method will execute in any view for an action
        /// with a command name that matches "New".
        /// </summary>
        [Rule("r100")]
        public void r100Implementation(GradeBookEntryModel instance)
        {
            // This is the placeholder for method implementation.

            instance.GradeBook = "New GBA Title";
            instance.SubmittedDate = DateTime.Today;
            instance.UserID = (Guid)UserId;
            instance.DueDate = DateTime.Today.AddDays(14);

            // check if the total of the weights for CourseSection does not exceed 100 %. If it 
            // does prevent the default action
            // and display an error message
            // if the total of the weights for CourseSection does not exceed 100 %, then set the
            //save the record

            // i need to implement the above brief


        }
    }
}

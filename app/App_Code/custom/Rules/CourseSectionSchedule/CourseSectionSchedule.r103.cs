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
    public partial class CourseSectionScheduleBusinessRules : zLearnHub.Rules.SharedBusinessRules
    {

        /// <summary>Rule "setOnUpdateAction" implementation:
        /// This method will execute in any view before an action
        /// with a command name that matches "Update".
        /// </summary>
        [Rule("r103")]
        public void r103Implementation(CourseSectionScheduleModel instance)
        {
            // This is the placeholder for method implementation.
            if (instance.ScheduleID.HasValue)
            {
                PreventDefault();
                Result.Continue();
                SqlText.ExecuteNonQuery(
                     "DELETE FROM CourseSectionSchedule WHERE ScheduleID = @p0 and StartDate >= @p1",
                     instance.ScheduleID.Value, instance["StartDate"].OldValue);

                Schedules schedule = new Schedules
                {
                    DaysOfWeek = instance.ScheduleDaysOfWeek,
                    Weeks  = instance.ScheduleWeeks,
                };
                schedule.Insert();

                CreateScheduleMeetings(schedule, instance);
            }
        }
    }
}

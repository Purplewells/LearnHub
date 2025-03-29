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

        /// <summary>Rule "setRecursion" implementation:
        /// This method will execute in any view before an action
        /// with a command name that matches "Insert".
        /// </summary>
        [Rule("r101")]
        public void r101Implementation(CourseSectionScheduleModel instance)
        {
            // This is the placeholder for method implementation.
            if(!string.IsNullOrEmpty(instance.ScheduleDaysOfWeek) && instance.ScheduleWeeks.HasValue && instance.ScheduleWeeks > 0)
            {
                PreventDefault();

                Schedules schedule = new Schedules
                {
                    DaysOfWeek = instance.ScheduleDaysOfWeek,
                    Weeks = instance.ScheduleWeeks
                };
                schedule.Insert();
                CreateScheduleMeetings(schedule, instance);
            }
        }

        void CreateScheduleMeetings(Schedules schedule, CourseSectionScheduleModel template)
        {
            // This is the placeholder for method implementation.
            string[] daysOfWeek = schedule.DaysOfWeek.Split(',');
            DateTime startOfWeek = template.StartDate.Value;
            startOfWeek = startOfWeek.AddDays(-(int)startOfWeek.DayOfWeek);
            TimeSpan duration = template.EndDate.Value - template.StartDate.Value;
            
            for (int i = 0; i < schedule.Weeks.Value; i++)
            {
                foreach (string dayOfWeek in daysOfWeek)
                {
                    DayOfWeek dow = (DayOfWeek)Enum.Parse(typeof(DayOfWeek), dayOfWeek);
                    DateTime date = startOfWeek.AddDays((int)dow);

                    if(date >= template.StartDate)
                    {
                        CourseSectionSchedule meeting = new CourseSectionSchedule
                        {
                            Title = template.Title,
                            StartDate = date,
                            EndDate = date.Add(duration),
                            RoomID = template.RoomID,
                            ScheduleID = schedule.ScheduleID,
                            ClassPeriodID = template.ClassPeriodID,
                            CourseSectionID = template.CourseSectionID,
                            Description = template.Title + ' '+  template.CourseSectionName
                            
                        };
                        meeting.Insert();
                    }
                }
                startOfWeek = startOfWeek.AddDays(7);
            }
        }
    }
}

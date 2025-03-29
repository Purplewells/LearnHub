using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using zLearnHub.Data;

namespace zLearnHub.Models
{
    public enum ScheduleDataField
    {

        ScheduleID,

        Weeks,

        DaysOfWeek,
    }

    public partial class ScheduleModel : BusinessRulesObjectModel
    {

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _scheduleID;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _weeks;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _daysOfWeek;

        public ScheduleModel()
        {
        }

        public ScheduleModel(BusinessRules r) :
                base(r)
        {
        }

        public int? ScheduleID
        {
            get
            {
                return _scheduleID;
            }
            set
            {
                _scheduleID = value;
                UpdateFieldValue("ScheduleID", value);
            }
        }

        public int? Weeks
        {
            get
            {
                return _weeks;
            }
            set
            {
                _weeks = value;
                UpdateFieldValue("Weeks", value);
            }
        }

        public string DaysOfWeek
        {
            get
            {
                return _daysOfWeek;
            }
            set
            {
                _daysOfWeek = value;
                UpdateFieldValue("DaysOfWeek", value);
            }
        }

        public FieldValue this[ScheduleDataField field]
        {
            get
            {
                return this[field.ToString()];
            }
        }
    }

    public partial class Schedule : ScheduleModel
    {

        public static List<zLearnHub.Models.Schedule> Select(string filter, string sort, string dataView, params System.Object[] parameters)
        {
            return new ScheduleFactory().Select(filter, sort, dataView, new BusinessObjectParameters(parameters));
        }

        public static List<zLearnHub.Models.Schedule> Select(string filter, string sort, params System.Object[] parameters)
        {
            return new ScheduleFactory().Select(filter, sort, ScheduleFactory.SelectView, new BusinessObjectParameters(parameters));
        }

        public static List<zLearnHub.Models.Schedule> Select(string filter, params System.Object[] parameters)
        {
            return new ScheduleFactory().Select(filter, null, ScheduleFactory.SelectView, new BusinessObjectParameters(parameters));
        }

        public static zLearnHub.Models.Schedule SelectSingle(string filter, params System.Object[] parameters)
        {
            return new ScheduleFactory().SelectSingle(filter, new BusinessObjectParameters(parameters));
        }

        public static zLearnHub.Models.Schedule SelectSingle(int? scheduleID)
        {
            return new ScheduleFactory().SelectSingle(scheduleID);
        }

        public int Insert()
        {
            return new ScheduleFactory().Insert(this);
        }

        public int Update()
        {
            return new ScheduleFactory().Update(this);
        }

        public int Delete()
        {
            return new ScheduleFactory().Delete(this);
        }

        public override string ToString()
        {
            return string.Format("ScheduleID: {0}", this.ScheduleID);
        }

        public static zLearnHub.Models.Schedule SelectSingle(object filter)
        {
            var paramList = new BusinessObjectParameters(filter);
            return SelectSingle(paramList.ToWhere(), paramList);
        }

        public static List<zLearnHub.Models.Schedule> Select(object filter, string sort, string view)
        {
            var paramList = new BusinessObjectParameters(filter);
            return Select(paramList.ToWhere(), sort, view, paramList);
        }

        public static List<zLearnHub.Models.Schedule> Select(object filter, string sort)
        {
            return Select(filter, sort, null);
        }

        public static List<zLearnHub.Models.Schedule> Select(object filter)
        {
            return Select(filter, null);
        }

        public static zLearnHub.Models.Schedule Insert(object initializer)
        {
            var instance = CreateInstance<zLearnHub.Models.Schedule>(initializer);
            if (instance.Insert() == 0)
                return null;
            return instance;
        }

        public static List<zLearnHub.Models.Schedule> SelectAll()
        {
            return SelectAll(null);
        }

        public static List<zLearnHub.Models.Schedule> SelectAll(string sort)
        {
            return new zLearnHub.Models.ScheduleFactory().Select(null, sort, zLearnHub.Models.ScheduleFactory.SelectView, new BusinessObjectParameters());
        }
    }

    public partial class ScheduleFactory
    {

        public ScheduleFactory()
        {
        }

        public static string SelectView
        {
            get
            {
                return Controller.GetSelectView("Schedule");
            }
        }

        public static string InsertView
        {
            get
            {
                return Controller.GetInsertView("Schedule");
            }
        }

        public static string UpdateView
        {
            get
            {
                return Controller.GetUpdateView("Schedule");
            }
        }

        public static string DeleteView
        {
            get
            {
                return Controller.GetDeleteView("Schedule");
            }
        }

        public static ScheduleFactory Create()
        {
            return new ScheduleFactory();
        }

        public List<zLearnHub.Models.Schedule> Select(string filter, BusinessObjectParameters parameters)
        {
            return Select(filter, null, SelectView, parameters);
        }

        public List<zLearnHub.Models.Schedule> SelectSingle(string filter, string sort, BusinessObjectParameters parameters)
        {
            return Select(filter, sort, SelectView, parameters);
        }

        public List<zLearnHub.Models.Schedule> Select(string filter, string sort, string dataView, BusinessObjectParameters parameters)
        {
            var request = new PageRequest(0, Int32.MaxValue, sort, new string[0])
            {
                RequiresMetaData = true,
                MetadataFilter = new string[] {
                    "fields"}
            };
            var c = ControllerFactory.CreateDataController();
            var bo = ((IBusinessObject)(c));
            bo.AssignFilter(filter, parameters);
            var page = c.GetPage("Schedule", dataView, request);
            return page.ToList<zLearnHub.Models.Schedule>();
        }

        public zLearnHub.Models.Schedule SelectSingle(int? scheduleID)
        {
            var parameterMarker = SqlStatement.GetParameterMarker(string.Empty);
            var paramValues = new BusinessObjectParameters();
            paramValues[(parameterMarker + "objpk0")] = scheduleID;
            return SelectSingle(string.Format("ScheduleID={0}objpk0", parameterMarker), paramValues);
        }

        public zLearnHub.Models.Schedule SelectSingle(string filter, BusinessObjectParameters parameters)
        {
            var list = Select(filter, parameters);
            if (list.Count > 0)
                return list[0];
            return null;
        }

        protected virtual FieldValue[] CreateFieldValues(zLearnHub.Models.Schedule theSchedule, zLearnHub.Models.Schedule original_Schedule)
        {
            var values = new List<FieldValue>();
            values.Add(new FieldValue("ScheduleID", original_Schedule.ScheduleID, theSchedule.ScheduleID, true));
            values.Add(new FieldValue("Weeks", original_Schedule.Weeks, theSchedule.Weeks));
            values.Add(new FieldValue("DaysOfWeek", original_Schedule.DaysOfWeek, theSchedule.DaysOfWeek));
            return values.ToArray();
        }

        protected virtual int ExecuteAction(zLearnHub.Models.Schedule theSchedule, zLearnHub.Models.Schedule original_Schedule, string lastCommandName, string commandName, string dataView)
        {
            var args = new ActionArgs()
            {
                Controller = "Schedule",
                View = dataView,
                Values = CreateFieldValues(theSchedule, original_Schedule),
                LastCommandName = lastCommandName,
                CommandName = commandName
            };
            var result = ControllerFactory.CreateDataController().Execute("Schedule", dataView, args);
            result.RaiseExceptionIfErrors();
            result.AssignTo(theSchedule);
            return result.RowsAffected;
        }

        public virtual int Update(zLearnHub.Models.Schedule theSchedule, zLearnHub.Models.Schedule original_Schedule)
        {
            return ExecuteAction(theSchedule, original_Schedule, "Edit", "Update", UpdateView);
        }

        public virtual int Update(zLearnHub.Models.Schedule theSchedule)
        {
            return Update(theSchedule, SelectSingle(theSchedule.ScheduleID));
        }

        public virtual int Insert(zLearnHub.Models.Schedule theSchedule)
        {
            return ExecuteAction(theSchedule, new Schedule(), "New", "Insert", InsertView);
        }

        public virtual int Delete(zLearnHub.Models.Schedule theSchedule)
        {
            return ExecuteAction(theSchedule, theSchedule, "Select", "Delete", DeleteView);
        }
    }
}

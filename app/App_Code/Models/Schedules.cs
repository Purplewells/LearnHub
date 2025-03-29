using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using zLearnHub.Data;

namespace zLearnHub.Models
{
    public enum SchedulesDataField
    {

        ScheduleID,

        Weeks,

        DaysOfWeek,
    }

    public partial class SchedulesModel : BusinessRulesObjectModel
    {

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _scheduleID;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _weeks;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _daysOfWeek;

        public SchedulesModel()
        {
        }

        public SchedulesModel(BusinessRules r) :
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

        public FieldValue this[SchedulesDataField field]
        {
            get
            {
                return this[field.ToString()];
            }
        }
    }

    public partial class Schedules : SchedulesModel
    {

        public static List<zLearnHub.Models.Schedules> Select(string filter, string sort, string dataView, params System.Object[] parameters)
        {
            return new SchedulesFactory().Select(filter, sort, dataView, new BusinessObjectParameters(parameters));
        }

        public static List<zLearnHub.Models.Schedules> Select(string filter, string sort, params System.Object[] parameters)
        {
            return new SchedulesFactory().Select(filter, sort, SchedulesFactory.SelectView, new BusinessObjectParameters(parameters));
        }

        public static List<zLearnHub.Models.Schedules> Select(string filter, params System.Object[] parameters)
        {
            return new SchedulesFactory().Select(filter, null, SchedulesFactory.SelectView, new BusinessObjectParameters(parameters));
        }

        public static zLearnHub.Models.Schedules SelectSingle(string filter, params System.Object[] parameters)
        {
            return new SchedulesFactory().SelectSingle(filter, new BusinessObjectParameters(parameters));
        }

        public static zLearnHub.Models.Schedules SelectSingle(int? scheduleID)
        {
            return new SchedulesFactory().SelectSingle(scheduleID);
        }

        public int Insert()
        {
            return new SchedulesFactory().Insert(this);
        }

        public int Update()
        {
            return new SchedulesFactory().Update(this);
        }

        public int Delete()
        {
            return new SchedulesFactory().Delete(this);
        }

        public override string ToString()
        {
            return string.Format("ScheduleID: {0}", this.ScheduleID);
        }

        public static zLearnHub.Models.Schedules SelectSingle(object filter)
        {
            var paramList = new BusinessObjectParameters(filter);
            return SelectSingle(paramList.ToWhere(), paramList);
        }

        public static List<zLearnHub.Models.Schedules> Select(object filter, string sort, string view)
        {
            var paramList = new BusinessObjectParameters(filter);
            return Select(paramList.ToWhere(), sort, view, paramList);
        }

        public static List<zLearnHub.Models.Schedules> Select(object filter, string sort)
        {
            return Select(filter, sort, null);
        }

        public static List<zLearnHub.Models.Schedules> Select(object filter)
        {
            return Select(filter, null);
        }

        public static zLearnHub.Models.Schedules Insert(object initializer)
        {
            var instance = CreateInstance<zLearnHub.Models.Schedules>(initializer);
            if (instance.Insert() == 0)
                return null;
            return instance;
        }

        public static List<zLearnHub.Models.Schedules> SelectAll()
        {
            return SelectAll(null);
        }

        public static List<zLearnHub.Models.Schedules> SelectAll(string sort)
        {
            return new zLearnHub.Models.SchedulesFactory().Select(null, sort, zLearnHub.Models.SchedulesFactory.SelectView, new BusinessObjectParameters());
        }
    }

    public partial class SchedulesFactory
    {

        public SchedulesFactory()
        {
        }

        public static string SelectView
        {
            get
            {
                return Controller.GetSelectView("Schedules");
            }
        }

        public static string InsertView
        {
            get
            {
                return Controller.GetInsertView("Schedules");
            }
        }

        public static string UpdateView
        {
            get
            {
                return Controller.GetUpdateView("Schedules");
            }
        }

        public static string DeleteView
        {
            get
            {
                return Controller.GetDeleteView("Schedules");
            }
        }

        public static SchedulesFactory Create()
        {
            return new SchedulesFactory();
        }

        public List<zLearnHub.Models.Schedules> Select(string filter, BusinessObjectParameters parameters)
        {
            return Select(filter, null, SelectView, parameters);
        }

        public List<zLearnHub.Models.Schedules> SelectSingle(string filter, string sort, BusinessObjectParameters parameters)
        {
            return Select(filter, sort, SelectView, parameters);
        }

        public List<zLearnHub.Models.Schedules> Select(string filter, string sort, string dataView, BusinessObjectParameters parameters)
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
            var page = c.GetPage("Schedules", dataView, request);
            return page.ToList<zLearnHub.Models.Schedules>();
        }

        public zLearnHub.Models.Schedules SelectSingle(int? scheduleID)
        {
            var parameterMarker = SqlStatement.GetParameterMarker(string.Empty);
            var paramValues = new BusinessObjectParameters();
            paramValues[(parameterMarker + "objpk0")] = scheduleID;
            return SelectSingle(string.Format("ScheduleID={0}objpk0", parameterMarker), paramValues);
        }

        public zLearnHub.Models.Schedules SelectSingle(string filter, BusinessObjectParameters parameters)
        {
            var list = Select(filter, parameters);
            if (list.Count > 0)
                return list[0];
            return null;
        }

        protected virtual FieldValue[] CreateFieldValues(zLearnHub.Models.Schedules theSchedules, zLearnHub.Models.Schedules original_Schedules)
        {
            var values = new List<FieldValue>();
            values.Add(new FieldValue("ScheduleID", original_Schedules.ScheduleID, theSchedules.ScheduleID, true));
            values.Add(new FieldValue("Weeks", original_Schedules.Weeks, theSchedules.Weeks));
            values.Add(new FieldValue("DaysOfWeek", original_Schedules.DaysOfWeek, theSchedules.DaysOfWeek));
            return values.ToArray();
        }

        protected virtual int ExecuteAction(zLearnHub.Models.Schedules theSchedules, zLearnHub.Models.Schedules original_Schedules, string lastCommandName, string commandName, string dataView)
        {
            var args = new ActionArgs()
            {
                Controller = "Schedules",
                View = dataView,
                Values = CreateFieldValues(theSchedules, original_Schedules),
                LastCommandName = lastCommandName,
                CommandName = commandName
            };
            var result = ControllerFactory.CreateDataController().Execute("Schedules", dataView, args);
            result.RaiseExceptionIfErrors();
            result.AssignTo(theSchedules);
            return result.RowsAffected;
        }

        public virtual int Update(zLearnHub.Models.Schedules theSchedules, zLearnHub.Models.Schedules original_Schedules)
        {
            return ExecuteAction(theSchedules, original_Schedules, "Edit", "Update", UpdateView);
        }

        public virtual int Update(zLearnHub.Models.Schedules theSchedules)
        {
            return Update(theSchedules, SelectSingle(theSchedules.ScheduleID));
        }

        public virtual int Insert(zLearnHub.Models.Schedules theSchedules)
        {
            return ExecuteAction(theSchedules, new Schedules(), "New", "Insert", InsertView);
        }

        public virtual int Delete(zLearnHub.Models.Schedules theSchedules)
        {
            return ExecuteAction(theSchedules, theSchedules, "Select", "Delete", DeleteView);
        }
    }
}

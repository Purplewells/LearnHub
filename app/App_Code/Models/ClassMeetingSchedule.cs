using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using zLearnHub.Data;

namespace zLearnHub.Models
{
    public enum ClassMeetingScheduleDataField
    {

        ScheduleID,

        Weeks,

        DaysOfWeek,
    }

    public partial class ClassMeetingScheduleModel : BusinessRulesObjectModel
    {

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _scheduleID;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _weeks;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _daysOfWeek;

        public ClassMeetingScheduleModel()
        {
        }

        public ClassMeetingScheduleModel(BusinessRules r) :
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

        public FieldValue this[ClassMeetingScheduleDataField field]
        {
            get
            {
                return this[field.ToString()];
            }
        }
    }

    public partial class ClassMeetingSchedule : ClassMeetingScheduleModel
    {

        public static List<zLearnHub.Models.ClassMeetingSchedule> Select(string filter, string sort, string dataView, params System.Object[] parameters)
        {
            return new ClassMeetingScheduleFactory().Select(filter, sort, dataView, new BusinessObjectParameters(parameters));
        }

        public static List<zLearnHub.Models.ClassMeetingSchedule> Select(string filter, string sort, params System.Object[] parameters)
        {
            return new ClassMeetingScheduleFactory().Select(filter, sort, ClassMeetingScheduleFactory.SelectView, new BusinessObjectParameters(parameters));
        }

        public static List<zLearnHub.Models.ClassMeetingSchedule> Select(string filter, params System.Object[] parameters)
        {
            return new ClassMeetingScheduleFactory().Select(filter, null, ClassMeetingScheduleFactory.SelectView, new BusinessObjectParameters(parameters));
        }

        public static zLearnHub.Models.ClassMeetingSchedule SelectSingle(string filter, params System.Object[] parameters)
        {
            return new ClassMeetingScheduleFactory().SelectSingle(filter, new BusinessObjectParameters(parameters));
        }

        public static zLearnHub.Models.ClassMeetingSchedule SelectSingle(int? scheduleID)
        {
            return new ClassMeetingScheduleFactory().SelectSingle(scheduleID);
        }

        public int Insert()
        {
            return new ClassMeetingScheduleFactory().Insert(this);
        }

        public int Update()
        {
            return new ClassMeetingScheduleFactory().Update(this);
        }

        public int Delete()
        {
            return new ClassMeetingScheduleFactory().Delete(this);
        }

        public override string ToString()
        {
            return string.Format("ScheduleID: {0}", this.ScheduleID);
        }

        public static zLearnHub.Models.ClassMeetingSchedule SelectSingle(object filter)
        {
            var paramList = new BusinessObjectParameters(filter);
            return SelectSingle(paramList.ToWhere(), paramList);
        }

        public static List<zLearnHub.Models.ClassMeetingSchedule> Select(object filter, string sort, string view)
        {
            var paramList = new BusinessObjectParameters(filter);
            return Select(paramList.ToWhere(), sort, view, paramList);
        }

        public static List<zLearnHub.Models.ClassMeetingSchedule> Select(object filter, string sort)
        {
            return Select(filter, sort, null);
        }

        public static List<zLearnHub.Models.ClassMeetingSchedule> Select(object filter)
        {
            return Select(filter, null);
        }

        public static zLearnHub.Models.ClassMeetingSchedule Insert(object initializer)
        {
            var instance = CreateInstance<zLearnHub.Models.ClassMeetingSchedule>(initializer);
            if (instance.Insert() == 0)
                return null;
            return instance;
        }

        public static List<zLearnHub.Models.ClassMeetingSchedule> SelectAll()
        {
            return SelectAll(null);
        }

        public static List<zLearnHub.Models.ClassMeetingSchedule> SelectAll(string sort)
        {
            return new zLearnHub.Models.ClassMeetingScheduleFactory().Select(null, sort, zLearnHub.Models.ClassMeetingScheduleFactory.SelectView, new BusinessObjectParameters());
        }
    }

    public partial class ClassMeetingScheduleFactory
    {

        public ClassMeetingScheduleFactory()
        {
        }

        public static string SelectView
        {
            get
            {
                return Controller.GetSelectView("ClassMeetingSchedule");
            }
        }

        public static string InsertView
        {
            get
            {
                return Controller.GetInsertView("ClassMeetingSchedule");
            }
        }

        public static string UpdateView
        {
            get
            {
                return Controller.GetUpdateView("ClassMeetingSchedule");
            }
        }

        public static string DeleteView
        {
            get
            {
                return Controller.GetDeleteView("ClassMeetingSchedule");
            }
        }

        public static ClassMeetingScheduleFactory Create()
        {
            return new ClassMeetingScheduleFactory();
        }

        public List<zLearnHub.Models.ClassMeetingSchedule> Select(string filter, BusinessObjectParameters parameters)
        {
            return Select(filter, null, SelectView, parameters);
        }

        public List<zLearnHub.Models.ClassMeetingSchedule> SelectSingle(string filter, string sort, BusinessObjectParameters parameters)
        {
            return Select(filter, sort, SelectView, parameters);
        }

        public List<zLearnHub.Models.ClassMeetingSchedule> Select(string filter, string sort, string dataView, BusinessObjectParameters parameters)
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
            var page = c.GetPage("ClassMeetingSchedule", dataView, request);
            return page.ToList<zLearnHub.Models.ClassMeetingSchedule>();
        }

        public zLearnHub.Models.ClassMeetingSchedule SelectSingle(int? scheduleID)
        {
            var parameterMarker = SqlStatement.GetParameterMarker(string.Empty);
            var paramValues = new BusinessObjectParameters();
            paramValues[(parameterMarker + "objpk0")] = scheduleID;
            return SelectSingle(string.Format("ScheduleID={0}objpk0", parameterMarker), paramValues);
        }

        public zLearnHub.Models.ClassMeetingSchedule SelectSingle(string filter, BusinessObjectParameters parameters)
        {
            var list = Select(filter, parameters);
            if (list.Count > 0)
                return list[0];
            return null;
        }

        protected virtual FieldValue[] CreateFieldValues(zLearnHub.Models.ClassMeetingSchedule theClassMeetingSchedule, zLearnHub.Models.ClassMeetingSchedule original_ClassMeetingSchedule)
        {
            var values = new List<FieldValue>();
            values.Add(new FieldValue("ScheduleID", original_ClassMeetingSchedule.ScheduleID, theClassMeetingSchedule.ScheduleID, true));
            values.Add(new FieldValue("Weeks", original_ClassMeetingSchedule.Weeks, theClassMeetingSchedule.Weeks));
            values.Add(new FieldValue("DaysOfWeek", original_ClassMeetingSchedule.DaysOfWeek, theClassMeetingSchedule.DaysOfWeek));
            return values.ToArray();
        }

        protected virtual int ExecuteAction(zLearnHub.Models.ClassMeetingSchedule theClassMeetingSchedule, zLearnHub.Models.ClassMeetingSchedule original_ClassMeetingSchedule, string lastCommandName, string commandName, string dataView)
        {
            var args = new ActionArgs()
            {
                Controller = "ClassMeetingSchedule",
                View = dataView,
                Values = CreateFieldValues(theClassMeetingSchedule, original_ClassMeetingSchedule),
                LastCommandName = lastCommandName,
                CommandName = commandName
            };
            var result = ControllerFactory.CreateDataController().Execute("ClassMeetingSchedule", dataView, args);
            result.RaiseExceptionIfErrors();
            result.AssignTo(theClassMeetingSchedule);
            return result.RowsAffected;
        }

        public virtual int Update(zLearnHub.Models.ClassMeetingSchedule theClassMeetingSchedule, zLearnHub.Models.ClassMeetingSchedule original_ClassMeetingSchedule)
        {
            return ExecuteAction(theClassMeetingSchedule, original_ClassMeetingSchedule, "Edit", "Update", UpdateView);
        }

        public virtual int Update(zLearnHub.Models.ClassMeetingSchedule theClassMeetingSchedule)
        {
            return Update(theClassMeetingSchedule, SelectSingle(theClassMeetingSchedule.ScheduleID));
        }

        public virtual int Insert(zLearnHub.Models.ClassMeetingSchedule theClassMeetingSchedule)
        {
            return ExecuteAction(theClassMeetingSchedule, new ClassMeetingSchedule(), "New", "Insert", InsertView);
        }

        public virtual int Delete(zLearnHub.Models.ClassMeetingSchedule theClassMeetingSchedule)
        {
            return ExecuteAction(theClassMeetingSchedule, theClassMeetingSchedule, "Select", "Delete", DeleteView);
        }
    }
}

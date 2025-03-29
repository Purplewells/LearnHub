using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using zLearnHub.Data;

namespace zLearnHub.Models
{
    public enum CourseSectionScheduleDataField
    {

        MeetingPatternID,

        CourseSectionID,

        CourseSectionNo,

        CourseSectionName,

        Title,

        StartDate,

        EndDate,

        ClassPeriodID,

        ClassPeriodName,

        ClassPeriodStartTime,

        ScheduleID,

        ScheduleDaysOfWeek,

        ScheduleWeeks,

        ClassPeriodEndTime,

        CreatedBy,

        CreatedDate,

        ModifiedDate,

        ModifiedBy,

        RoomID,

        RoomName,

        Description,
    }

    public partial class CourseSectionScheduleModel : BusinessRulesObjectModel
    {

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _meetingPatternID;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _courseSectionID;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _courseSectionNo;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _courseSectionName;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _title;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private DateTime? _startDate;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private DateTime? _endDate;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _classPeriodID;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _classPeriodName;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private System.TimeSpan? _classPeriodStartTime;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _scheduleID;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _scheduleDaysOfWeek;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _scheduleWeeks;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private System.TimeSpan? _classPeriodEndTime;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _createdBy;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private DateTime? _createdDate;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private DateTime? _modifiedDate;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _modifiedBy;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _roomID;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _roomName;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _description;

        public CourseSectionScheduleModel()
        {
        }

        public CourseSectionScheduleModel(BusinessRules r) :
                base(r)
        {
        }

        public int? MeetingPatternID
        {
            get
            {
                return _meetingPatternID;
            }
            set
            {
                _meetingPatternID = value;
                UpdateFieldValue("MeetingPatternID", value);
            }
        }

        public int? CourseSectionID
        {
            get
            {
                return _courseSectionID;
            }
            set
            {
                _courseSectionID = value;
                UpdateFieldValue("CourseSectionID", value);
            }
        }

        public string CourseSectionNo
        {
            get
            {
                return _courseSectionNo;
            }
            set
            {
                _courseSectionNo = value;
                UpdateFieldValue("CourseSectionNo", value);
            }
        }

        public string CourseSectionName
        {
            get
            {
                return _courseSectionName;
            }
            set
            {
                _courseSectionName = value;
                UpdateFieldValue("CourseSectionName", value);
            }
        }

        public string Title
        {
            get
            {
                return _title;
            }
            set
            {
                _title = value;
                UpdateFieldValue("Title", value);
            }
        }

        public DateTime? StartDate
        {
            get
            {
                return _startDate;
            }
            set
            {
                _startDate = value;
                UpdateFieldValue("StartDate", value);
            }
        }

        public DateTime? EndDate
        {
            get
            {
                return _endDate;
            }
            set
            {
                _endDate = value;
                UpdateFieldValue("EndDate", value);
            }
        }

        public int? ClassPeriodID
        {
            get
            {
                return _classPeriodID;
            }
            set
            {
                _classPeriodID = value;
                UpdateFieldValue("ClassPeriodID", value);
            }
        }

        public string ClassPeriodName
        {
            get
            {
                return _classPeriodName;
            }
            set
            {
                _classPeriodName = value;
                UpdateFieldValue("ClassPeriodName", value);
            }
        }

        public System.TimeSpan? ClassPeriodStartTime
        {
            get
            {
                return _classPeriodStartTime;
            }
            set
            {
                _classPeriodStartTime = value;
                UpdateFieldValue("ClassPeriodStartTime", value);
            }
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

        public string ScheduleDaysOfWeek
        {
            get
            {
                return _scheduleDaysOfWeek;
            }
            set
            {
                _scheduleDaysOfWeek = value;
                UpdateFieldValue("ScheduleDaysOfWeek", value);
            }
        }

        public int? ScheduleWeeks
        {
            get
            {
                return _scheduleWeeks;
            }
            set
            {
                _scheduleWeeks = value;
                UpdateFieldValue("ScheduleWeeks", value);
            }
        }

        public System.TimeSpan? ClassPeriodEndTime
        {
            get
            {
                return _classPeriodEndTime;
            }
            set
            {
                _classPeriodEndTime = value;
                UpdateFieldValue("ClassPeriodEndTime", value);
            }
        }

        public string CreatedBy
        {
            get
            {
                return _createdBy;
            }
            set
            {
                _createdBy = value;
                UpdateFieldValue("CreatedBy", value);
            }
        }

        public DateTime? CreatedDate
        {
            get
            {
                return _createdDate;
            }
            set
            {
                _createdDate = value;
                UpdateFieldValue("CreatedDate", value);
            }
        }

        public DateTime? ModifiedDate
        {
            get
            {
                return _modifiedDate;
            }
            set
            {
                _modifiedDate = value;
                UpdateFieldValue("ModifiedDate", value);
            }
        }

        public string ModifiedBy
        {
            get
            {
                return _modifiedBy;
            }
            set
            {
                _modifiedBy = value;
                UpdateFieldValue("ModifiedBy", value);
            }
        }

        public int? RoomID
        {
            get
            {
                return _roomID;
            }
            set
            {
                _roomID = value;
                UpdateFieldValue("RoomID", value);
            }
        }

        public string RoomName
        {
            get
            {
                return _roomName;
            }
            set
            {
                _roomName = value;
                UpdateFieldValue("RoomName", value);
            }
        }

        public string Description
        {
            get
            {
                return _description;
            }
            set
            {
                _description = value;
                UpdateFieldValue("Description", value);
            }
        }

        public FieldValue this[CourseSectionScheduleDataField field]
        {
            get
            {
                return this[field.ToString()];
            }
        }
    }

    public partial class CourseSectionSchedule : CourseSectionScheduleModel
    {

        public static List<zLearnHub.Models.CourseSectionSchedule> Select(string filter, string sort, string dataView, params System.Object[] parameters)
        {
            return new CourseSectionScheduleFactory().Select(filter, sort, dataView, new BusinessObjectParameters(parameters));
        }

        public static List<zLearnHub.Models.CourseSectionSchedule> Select(string filter, string sort, params System.Object[] parameters)
        {
            return new CourseSectionScheduleFactory().Select(filter, sort, CourseSectionScheduleFactory.SelectView, new BusinessObjectParameters(parameters));
        }

        public static List<zLearnHub.Models.CourseSectionSchedule> Select(string filter, params System.Object[] parameters)
        {
            return new CourseSectionScheduleFactory().Select(filter, null, CourseSectionScheduleFactory.SelectView, new BusinessObjectParameters(parameters));
        }

        public static zLearnHub.Models.CourseSectionSchedule SelectSingle(string filter, params System.Object[] parameters)
        {
            return new CourseSectionScheduleFactory().SelectSingle(filter, new BusinessObjectParameters(parameters));
        }

        public static zLearnHub.Models.CourseSectionSchedule SelectSingle(int? meetingPatternID)
        {
            return new CourseSectionScheduleFactory().SelectSingle(meetingPatternID);
        }

        public int Insert()
        {
            return new CourseSectionScheduleFactory().Insert(this);
        }

        public int Update()
        {
            return new CourseSectionScheduleFactory().Update(this);
        }

        public int Delete()
        {
            return new CourseSectionScheduleFactory().Delete(this);
        }

        public override string ToString()
        {
            return string.Format("MeetingPatternID: {0}", this.MeetingPatternID);
        }

        public static zLearnHub.Models.CourseSectionSchedule SelectSingle(object filter)
        {
            var paramList = new BusinessObjectParameters(filter);
            return SelectSingle(paramList.ToWhere(), paramList);
        }

        public static List<zLearnHub.Models.CourseSectionSchedule> Select(object filter, string sort, string view)
        {
            var paramList = new BusinessObjectParameters(filter);
            return Select(paramList.ToWhere(), sort, view, paramList);
        }

        public static List<zLearnHub.Models.CourseSectionSchedule> Select(object filter, string sort)
        {
            return Select(filter, sort, null);
        }

        public static List<zLearnHub.Models.CourseSectionSchedule> Select(object filter)
        {
            return Select(filter, null);
        }

        public static zLearnHub.Models.CourseSectionSchedule Insert(object initializer)
        {
            var instance = CreateInstance<zLearnHub.Models.CourseSectionSchedule>(initializer);
            if (instance.Insert() == 0)
                return null;
            return instance;
        }

        public static List<zLearnHub.Models.CourseSectionSchedule> SelectAll()
        {
            return SelectAll(null);
        }

        public static List<zLearnHub.Models.CourseSectionSchedule> SelectAll(string sort)
        {
            return new zLearnHub.Models.CourseSectionScheduleFactory().Select(null, sort, zLearnHub.Models.CourseSectionScheduleFactory.SelectView, new BusinessObjectParameters());
        }
    }

    public partial class CourseSectionScheduleFactory
    {

        public CourseSectionScheduleFactory()
        {
        }

        public static string SelectView
        {
            get
            {
                return Controller.GetSelectView("CourseSectionSchedule");
            }
        }

        public static string InsertView
        {
            get
            {
                return Controller.GetInsertView("CourseSectionSchedule");
            }
        }

        public static string UpdateView
        {
            get
            {
                return Controller.GetUpdateView("CourseSectionSchedule");
            }
        }

        public static string DeleteView
        {
            get
            {
                return Controller.GetDeleteView("CourseSectionSchedule");
            }
        }

        public static CourseSectionScheduleFactory Create()
        {
            return new CourseSectionScheduleFactory();
        }

        public List<zLearnHub.Models.CourseSectionSchedule> Select(string filter, BusinessObjectParameters parameters)
        {
            return Select(filter, null, SelectView, parameters);
        }

        public List<zLearnHub.Models.CourseSectionSchedule> SelectSingle(string filter, string sort, BusinessObjectParameters parameters)
        {
            return Select(filter, sort, SelectView, parameters);
        }

        public List<zLearnHub.Models.CourseSectionSchedule> Select(string filter, string sort, string dataView, BusinessObjectParameters parameters)
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
            var page = c.GetPage("CourseSectionSchedule", dataView, request);
            return page.ToList<zLearnHub.Models.CourseSectionSchedule>();
        }

        public zLearnHub.Models.CourseSectionSchedule SelectSingle(int? meetingPatternID)
        {
            var parameterMarker = SqlStatement.GetParameterMarker(string.Empty);
            var paramValues = new BusinessObjectParameters();
            paramValues[(parameterMarker + "objpk0")] = meetingPatternID;
            return SelectSingle(string.Format("MeetingPatternID={0}objpk0", parameterMarker), paramValues);
        }

        public zLearnHub.Models.CourseSectionSchedule SelectSingle(string filter, BusinessObjectParameters parameters)
        {
            var list = Select(filter, parameters);
            if (list.Count > 0)
                return list[0];
            return null;
        }

        protected virtual FieldValue[] CreateFieldValues(zLearnHub.Models.CourseSectionSchedule theCourseSectionSchedule, zLearnHub.Models.CourseSectionSchedule original_CourseSectionSchedule)
        {
            var values = new List<FieldValue>();
            values.Add(new FieldValue("MeetingPatternID", original_CourseSectionSchedule.MeetingPatternID, theCourseSectionSchedule.MeetingPatternID, true));
            values.Add(new FieldValue("CourseSectionID", original_CourseSectionSchedule.CourseSectionID, theCourseSectionSchedule.CourseSectionID));
            values.Add(new FieldValue("CourseSectionNo", original_CourseSectionSchedule.CourseSectionNo, theCourseSectionSchedule.CourseSectionNo, true));
            values.Add(new FieldValue("CourseSectionName", original_CourseSectionSchedule.CourseSectionName, theCourseSectionSchedule.CourseSectionName, true));
            values.Add(new FieldValue("Title", original_CourseSectionSchedule.Title, theCourseSectionSchedule.Title));
            values.Add(new FieldValue("StartDate", original_CourseSectionSchedule.StartDate, theCourseSectionSchedule.StartDate));
            values.Add(new FieldValue("EndDate", original_CourseSectionSchedule.EndDate, theCourseSectionSchedule.EndDate));
            values.Add(new FieldValue("ClassPeriodID", original_CourseSectionSchedule.ClassPeriodID, theCourseSectionSchedule.ClassPeriodID));
            values.Add(new FieldValue("ClassPeriodName", original_CourseSectionSchedule.ClassPeriodName, theCourseSectionSchedule.ClassPeriodName, true));
            values.Add(new FieldValue("ClassPeriodStartTime", original_CourseSectionSchedule.ClassPeriodStartTime, theCourseSectionSchedule.ClassPeriodStartTime, true));
            values.Add(new FieldValue("ScheduleID", original_CourseSectionSchedule.ScheduleID, theCourseSectionSchedule.ScheduleID));
            values.Add(new FieldValue("ScheduleDaysOfWeek", original_CourseSectionSchedule.ScheduleDaysOfWeek, theCourseSectionSchedule.ScheduleDaysOfWeek));
            values.Add(new FieldValue("ScheduleWeeks", original_CourseSectionSchedule.ScheduleWeeks, theCourseSectionSchedule.ScheduleWeeks));
            values.Add(new FieldValue("ClassPeriodEndTime", original_CourseSectionSchedule.ClassPeriodEndTime, theCourseSectionSchedule.ClassPeriodEndTime, true));
            values.Add(new FieldValue("CreatedBy", original_CourseSectionSchedule.CreatedBy, theCourseSectionSchedule.CreatedBy));
            values.Add(new FieldValue("CreatedDate", original_CourseSectionSchedule.CreatedDate, theCourseSectionSchedule.CreatedDate));
            values.Add(new FieldValue("ModifiedDate", original_CourseSectionSchedule.ModifiedDate, theCourseSectionSchedule.ModifiedDate));
            values.Add(new FieldValue("ModifiedBy", original_CourseSectionSchedule.ModifiedBy, theCourseSectionSchedule.ModifiedBy));
            values.Add(new FieldValue("RoomID", original_CourseSectionSchedule.RoomID, theCourseSectionSchedule.RoomID));
            values.Add(new FieldValue("RoomName", original_CourseSectionSchedule.RoomName, theCourseSectionSchedule.RoomName, true));
            values.Add(new FieldValue("Description", original_CourseSectionSchedule.Description, theCourseSectionSchedule.Description));
            return values.ToArray();
        }

        protected virtual int ExecuteAction(zLearnHub.Models.CourseSectionSchedule theCourseSectionSchedule, zLearnHub.Models.CourseSectionSchedule original_CourseSectionSchedule, string lastCommandName, string commandName, string dataView)
        {
            var args = new ActionArgs()
            {
                Controller = "CourseSectionSchedule",
                View = dataView,
                Values = CreateFieldValues(theCourseSectionSchedule, original_CourseSectionSchedule),
                LastCommandName = lastCommandName,
                CommandName = commandName
            };
            var result = ControllerFactory.CreateDataController().Execute("CourseSectionSchedule", dataView, args);
            result.RaiseExceptionIfErrors();
            result.AssignTo(theCourseSectionSchedule);
            return result.RowsAffected;
        }

        public virtual int Update(zLearnHub.Models.CourseSectionSchedule theCourseSectionSchedule, zLearnHub.Models.CourseSectionSchedule original_CourseSectionSchedule)
        {
            return ExecuteAction(theCourseSectionSchedule, original_CourseSectionSchedule, "Edit", "Update", UpdateView);
        }

        public virtual int Update(zLearnHub.Models.CourseSectionSchedule theCourseSectionSchedule)
        {
            return Update(theCourseSectionSchedule, SelectSingle(theCourseSectionSchedule.MeetingPatternID));
        }

        public virtual int Insert(zLearnHub.Models.CourseSectionSchedule theCourseSectionSchedule)
        {
            return ExecuteAction(theCourseSectionSchedule, new CourseSectionSchedule(), "New", "Insert", InsertView);
        }

        public virtual int Delete(zLearnHub.Models.CourseSectionSchedule theCourseSectionSchedule)
        {
            return ExecuteAction(theCourseSectionSchedule, theCourseSectionSchedule, "Select", "Delete", DeleteView);
        }
    }
}

using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using zLearnHub.Data;

namespace zLearnHub.Models
{
    public enum AttendanceEventDataField
    {

        AttendanceEventID,

        AttendanceEventCategoryID,

        EventCategory,

        RefGradeLevelID,

        GradeLevel,

        EventDate,

        AttendanceEventReasonID,

        EventReason,

        RefSchoolStreamID,

        Stream,

        CourseSectionID,

        SectionName,

        SectionNo,

        CreatedDate,

        ModifiedDate,

        CreatedBy,

        ModifiedBy,
    }

    public partial class AttendanceEventModel : BusinessRulesObjectModel
    {

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _attendanceEventID;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _attendanceEventCategoryID;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _eventCategory;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _refGradeLevelID;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _gradeLevel;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private DateTime? _eventDate;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _attendanceEventReasonID;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _eventReason;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _refSchoolStreamID;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _stream;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _courseSectionID;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _sectionName;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _sectionNo;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private DateTime? _createdDate;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private DateTime? _modifiedDate;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _createdBy;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _modifiedBy;

        public AttendanceEventModel()
        {
        }

        public AttendanceEventModel(BusinessRules r) :
                base(r)
        {
        }

        public int? AttendanceEventID
        {
            get
            {
                return _attendanceEventID;
            }
            set
            {
                _attendanceEventID = value;
                UpdateFieldValue("AttendanceEventID", value);
            }
        }

        public int? AttendanceEventCategoryID
        {
            get
            {
                return _attendanceEventCategoryID;
            }
            set
            {
                _attendanceEventCategoryID = value;
                UpdateFieldValue("AttendanceEventCategoryID", value);
            }
        }

        public string EventCategory
        {
            get
            {
                return _eventCategory;
            }
            set
            {
                _eventCategory = value;
                UpdateFieldValue("EventCategory", value);
            }
        }

        public int? RefGradeLevelID
        {
            get
            {
                return _refGradeLevelID;
            }
            set
            {
                _refGradeLevelID = value;
                UpdateFieldValue("RefGradeLevelID", value);
            }
        }

        public string GradeLevel
        {
            get
            {
                return _gradeLevel;
            }
            set
            {
                _gradeLevel = value;
                UpdateFieldValue("GradeLevel", value);
            }
        }

        public DateTime? EventDate
        {
            get
            {
                return _eventDate;
            }
            set
            {
                _eventDate = value;
                UpdateFieldValue("EventDate", value);
            }
        }

        public int? AttendanceEventReasonID
        {
            get
            {
                return _attendanceEventReasonID;
            }
            set
            {
                _attendanceEventReasonID = value;
                UpdateFieldValue("AttendanceEventReasonID", value);
            }
        }

        public string EventReason
        {
            get
            {
                return _eventReason;
            }
            set
            {
                _eventReason = value;
                UpdateFieldValue("EventReason", value);
            }
        }

        public int? RefSchoolStreamID
        {
            get
            {
                return _refSchoolStreamID;
            }
            set
            {
                _refSchoolStreamID = value;
                UpdateFieldValue("RefSchoolStreamID", value);
            }
        }

        public string Stream
        {
            get
            {
                return _stream;
            }
            set
            {
                _stream = value;
                UpdateFieldValue("Stream", value);
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

        public string SectionName
        {
            get
            {
                return _sectionName;
            }
            set
            {
                _sectionName = value;
                UpdateFieldValue("SectionName", value);
            }
        }

        public string SectionNo
        {
            get
            {
                return _sectionNo;
            }
            set
            {
                _sectionNo = value;
                UpdateFieldValue("SectionNo", value);
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

        public FieldValue this[AttendanceEventDataField field]
        {
            get
            {
                return this[field.ToString()];
            }
        }
    }
}

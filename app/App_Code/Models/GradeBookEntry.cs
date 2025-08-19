using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using zLearnHub.Data;

namespace zLearnHub.Models
{
    public enum GradeBookEntryDataField
    {

        GradeBookEntryID,

        GradeBookEntryTypeID,

        EntryType,

        GradeBook,

        SubmittedDate,

        DueDate,

        CourseSectionID,

        CourseSectionNo,

        GradingPeriodID,

        GradingPeriod,

        MPP,

        Weight,

        PTFA,

        PTSA,

        PUIT,

        PURE,

        Adaptive,

        AssessmentCategoryID,

        AssessmentCategory,

        RefSchoolStreamID,

        SchoolStream,

        AssessmentFamilyID,

        AssessmentFamily,

        CreatedDate,

        ModifiedDate,

        CreatedBy,

        ModifiedBy,

        UserID,

        Owner,

        Session,

        CSIA,

        SSIA,

        ACS,

        CSY,

        IsActive,

        SchoolName,

        Course,

        GL,

        GLSO,

        GBID,

        WMC,
    }

    public partial class GradeBookEntryModel : BusinessRulesObjectModel
    {

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _gradeBookEntryID;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _gradeBookEntryTypeID;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _entryType;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _gradeBook;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private DateTime? _submittedDate;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private DateTime? _dueDate;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _courseSectionID;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _courseSectionNo;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _gradingPeriodID;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _gradingPeriod;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private decimal? _mPP;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private decimal? _weight;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private bool? _pTFA;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private bool? _pTSA;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private bool? _pUIT;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private bool? _pURE;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private bool? _adaptive;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _assessmentCategoryID;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _assessmentCategory;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _refSchoolStreamID;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _schoolStream;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _assessmentFamilyID;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _assessmentFamily;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private DateTime? _createdDate;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private DateTime? _modifiedDate;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _createdBy;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _modifiedBy;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private System.Guid? _userID;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _owner;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _session;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private bool? _cSIA;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private bool? _sSIA;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private bool? _aCS;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private bool? _cSY;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private bool? _isActive;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _schoolName;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _course;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _gL;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private decimal? _gLSO;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _gBID;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private decimal? _wMC;

        public GradeBookEntryModel()
        {
        }

        public GradeBookEntryModel(BusinessRules r) :
                base(r)
        {
        }

        public int? GradeBookEntryID
        {
            get
            {
                return _gradeBookEntryID;
            }
            set
            {
                _gradeBookEntryID = value;
                UpdateFieldValue("GradeBookEntryID", value);
            }
        }

        public int? GradeBookEntryTypeID
        {
            get
            {
                return _gradeBookEntryTypeID;
            }
            set
            {
                _gradeBookEntryTypeID = value;
                UpdateFieldValue("GradeBookEntryTypeID", value);
            }
        }

        public string EntryType
        {
            get
            {
                return _entryType;
            }
            set
            {
                _entryType = value;
                UpdateFieldValue("EntryType", value);
            }
        }

        public string GradeBook
        {
            get
            {
                return _gradeBook;
            }
            set
            {
                _gradeBook = value;
                UpdateFieldValue("GradeBook", value);
            }
        }

        public DateTime? SubmittedDate
        {
            get
            {
                return _submittedDate;
            }
            set
            {
                _submittedDate = value;
                UpdateFieldValue("SubmittedDate", value);
            }
        }

        public DateTime? DueDate
        {
            get
            {
                return _dueDate;
            }
            set
            {
                _dueDate = value;
                UpdateFieldValue("DueDate", value);
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

        public int? GradingPeriodID
        {
            get
            {
                return _gradingPeriodID;
            }
            set
            {
                _gradingPeriodID = value;
                UpdateFieldValue("GradingPeriodID", value);
            }
        }

        public string GradingPeriod
        {
            get
            {
                return _gradingPeriod;
            }
            set
            {
                _gradingPeriod = value;
                UpdateFieldValue("GradingPeriod", value);
            }
        }

        public decimal? MPP
        {
            get
            {
                return _mPP;
            }
            set
            {
                _mPP = value;
                UpdateFieldValue("MPP", value);
            }
        }

        public decimal? Weight
        {
            get
            {
                return _weight;
            }
            set
            {
                _weight = value;
                UpdateFieldValue("Weight", value);
            }
        }

        public bool? PTFA
        {
            get
            {
                return _pTFA;
            }
            set
            {
                _pTFA = value;
                UpdateFieldValue("PTFA", value);
            }
        }

        public bool? PTSA
        {
            get
            {
                return _pTSA;
            }
            set
            {
                _pTSA = value;
                UpdateFieldValue("PTSA", value);
            }
        }

        public bool? PUIT
        {
            get
            {
                return _pUIT;
            }
            set
            {
                _pUIT = value;
                UpdateFieldValue("PUIT", value);
            }
        }

        public bool? PURE
        {
            get
            {
                return _pURE;
            }
            set
            {
                _pURE = value;
                UpdateFieldValue("PURE", value);
            }
        }

        public bool? Adaptive
        {
            get
            {
                return _adaptive;
            }
            set
            {
                _adaptive = value;
                UpdateFieldValue("Adaptive", value);
            }
        }

        public int? AssessmentCategoryID
        {
            get
            {
                return _assessmentCategoryID;
            }
            set
            {
                _assessmentCategoryID = value;
                UpdateFieldValue("AssessmentCategoryID", value);
            }
        }

        public string AssessmentCategory
        {
            get
            {
                return _assessmentCategory;
            }
            set
            {
                _assessmentCategory = value;
                UpdateFieldValue("AssessmentCategory", value);
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

        public string SchoolStream
        {
            get
            {
                return _schoolStream;
            }
            set
            {
                _schoolStream = value;
                UpdateFieldValue("SchoolStream", value);
            }
        }

        public int? AssessmentFamilyID
        {
            get
            {
                return _assessmentFamilyID;
            }
            set
            {
                _assessmentFamilyID = value;
                UpdateFieldValue("AssessmentFamilyID", value);
            }
        }

        public string AssessmentFamily
        {
            get
            {
                return _assessmentFamily;
            }
            set
            {
                _assessmentFamily = value;
                UpdateFieldValue("AssessmentFamily", value);
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

        public System.Guid? UserID
        {
            get
            {
                return _userID;
            }
            set
            {
                _userID = value;
                UpdateFieldValue("UserID", value);
            }
        }

        public string Owner
        {
            get
            {
                return _owner;
            }
            set
            {
                _owner = value;
                UpdateFieldValue("Owner", value);
            }
        }

        public string Session
        {
            get
            {
                return _session;
            }
            set
            {
                _session = value;
                UpdateFieldValue("Session", value);
            }
        }

        public bool? CSIA
        {
            get
            {
                return _cSIA;
            }
            set
            {
                _cSIA = value;
                UpdateFieldValue("CSIA", value);
            }
        }

        public bool? SSIA
        {
            get
            {
                return _sSIA;
            }
            set
            {
                _sSIA = value;
                UpdateFieldValue("SSIA", value);
            }
        }

        public bool? ACS
        {
            get
            {
                return _aCS;
            }
            set
            {
                _aCS = value;
                UpdateFieldValue("ACS", value);
            }
        }

        public bool? CSY
        {
            get
            {
                return _cSY;
            }
            set
            {
                _cSY = value;
                UpdateFieldValue("CSY", value);
            }
        }

        public bool? IsActive
        {
            get
            {
                return _isActive;
            }
            set
            {
                _isActive = value;
                UpdateFieldValue("IsActive", value);
            }
        }

        public string SchoolName
        {
            get
            {
                return _schoolName;
            }
            set
            {
                _schoolName = value;
                UpdateFieldValue("SchoolName", value);
            }
        }

        public string Course
        {
            get
            {
                return _course;
            }
            set
            {
                _course = value;
                UpdateFieldValue("Course", value);
            }
        }

        public string GL
        {
            get
            {
                return _gL;
            }
            set
            {
                _gL = value;
                UpdateFieldValue("GL", value);
            }
        }

        public decimal? GLSO
        {
            get
            {
                return _gLSO;
            }
            set
            {
                _gLSO = value;
                UpdateFieldValue("GLSO", value);
            }
        }

        public int? GBID
        {
            get
            {
                return _gBID;
            }
            set
            {
                _gBID = value;
                UpdateFieldValue("GBID", value);
            }
        }

        public decimal? WMC
        {
            get
            {
                return _wMC;
            }
            set
            {
                _wMC = value;
                UpdateFieldValue("WMC", value);
            }
        }

        public FieldValue this[GradeBookEntryDataField field]
        {
            get
            {
                return this[field.ToString()];
            }
        }
    }
}

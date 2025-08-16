using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using zLearnHub.Data;

namespace zLearnHub.Models
{
    public enum znStudentGradeBookEntryDataField
    {

        StudentGradeBookEntryID,

        LetterGrade,

        NumericGradeEarned,

        Weight,

        StudentCourseSectionID,

        StudentCourseSectionCreatedBy,

        GradeBookEntryID,

        GradeBookTitle,

        GradeBookEntryTypeID,

        GBEntryType,

        ASTY,

        GradingPeriodID,

        GradingPeriod,

        CompetencyLevelDescriptorID,

        SubmittedDate,

        PerformanceBaseConversionID,

        PerformanceBaseConversion,

        MinScore,

        MaxScore,

        NG,

        LG,

        Passing,

        PerformanceBaseConversionDescription,

        GradeRank,

        CreatedDate,

        ModifiedDate,

        CreatedBy,

        ModifiedBy,

        UserID,

        extMaxScore,

        extIsActiveSession,

        ExtIsCsy,

        ExtActiveCourseSection,

        ExtPBSG,

        ExtCalendarSessionID,

        RefSchoolStreamID,

        Stream,

        ExtIsPassing,

        ExtPWS,

        ExtOWS,

        CWS,

        GradeLevel,

        GLSO,

        Session,

        SessionIsActive,

        calYear,

        CSY,

        UPN,

        Firstname,

        Lastname,

        Course,

        SGID,

        SCID,

        extSGID,

        extSCID,

        Fullname,

        RefGradeLevelID,
    }

    public partial class znStudentGradeBookEntryModel : BusinessRulesObjectModel
    {

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _studentGradeBookEntryID;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _letterGrade;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private decimal? _numericGradeEarned;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private decimal? _weight;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _studentCourseSectionID;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _studentCourseSectionCreatedBy;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _gradeBookEntryID;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _gradeBookTitle;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _gradeBookEntryTypeID;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _gBEntryType;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _aSTY;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _gradingPeriodID;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _gradingPeriod;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _competencyLevelDescriptorID;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private DateTime? _submittedDate;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _performanceBaseConversionID;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _performanceBaseConversion;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private decimal? _minScore;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private decimal? _maxScore;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _nG;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _lG;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private bool? _passing;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _performanceBaseConversionDescription;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _gradeRank;

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
        private decimal? _extMaxScore;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _extIsActiveSession;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _extIsCsy;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private bool? _extActiveCourseSection;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private decimal? _extPBSG;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _extCalendarSessionID;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _refSchoolStreamID;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _stream;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private bool? _extIsPassing;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private decimal? _extPWS;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private decimal? _extOWS;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private decimal? _cWS;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _gradeLevel;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private decimal? _gLSO;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _session;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private bool? _sessionIsActive;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _calYear;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private bool? _cSY;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _uPN;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _firstname;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _lastname;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _course;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _sGID;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _sCID;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _extSGID;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _extSCID;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _fullname;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _refGradeLevelID;

        public znStudentGradeBookEntryModel()
        {
        }

        public znStudentGradeBookEntryModel(BusinessRules r) :
                base(r)
        {
        }

        public int? StudentGradeBookEntryID
        {
            get
            {
                return _studentGradeBookEntryID;
            }
            set
            {
                _studentGradeBookEntryID = value;
                UpdateFieldValue("StudentGradeBookEntryID", value);
            }
        }

        public string LetterGrade
        {
            get
            {
                return _letterGrade;
            }
            set
            {
                _letterGrade = value;
                UpdateFieldValue("LetterGrade", value);
            }
        }

        public decimal? NumericGradeEarned
        {
            get
            {
                return _numericGradeEarned;
            }
            set
            {
                _numericGradeEarned = value;
                UpdateFieldValue("NumericGradeEarned", value);
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

        public int? StudentCourseSectionID
        {
            get
            {
                return _studentCourseSectionID;
            }
            set
            {
                _studentCourseSectionID = value;
                UpdateFieldValue("StudentCourseSectionID", value);
            }
        }

        public string StudentCourseSectionCreatedBy
        {
            get
            {
                return _studentCourseSectionCreatedBy;
            }
            set
            {
                _studentCourseSectionCreatedBy = value;
                UpdateFieldValue("StudentCourseSectionCreatedBy", value);
            }
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

        public string GradeBookTitle
        {
            get
            {
                return _gradeBookTitle;
            }
            set
            {
                _gradeBookTitle = value;
                UpdateFieldValue("GradeBookTitle", value);
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

        public string GBEntryType
        {
            get
            {
                return _gBEntryType;
            }
            set
            {
                _gBEntryType = value;
                UpdateFieldValue("GBEntryType", value);
            }
        }

        public string ASTY
        {
            get
            {
                return _aSTY;
            }
            set
            {
                _aSTY = value;
                UpdateFieldValue("ASTY", value);
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

        public int? CompetencyLevelDescriptorID
        {
            get
            {
                return _competencyLevelDescriptorID;
            }
            set
            {
                _competencyLevelDescriptorID = value;
                UpdateFieldValue("CompetencyLevelDescriptorID", value);
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

        public int? PerformanceBaseConversionID
        {
            get
            {
                return _performanceBaseConversionID;
            }
            set
            {
                _performanceBaseConversionID = value;
                UpdateFieldValue("PerformanceBaseConversionID", value);
            }
        }

        public string PerformanceBaseConversion
        {
            get
            {
                return _performanceBaseConversion;
            }
            set
            {
                _performanceBaseConversion = value;
                UpdateFieldValue("PerformanceBaseConversion", value);
            }
        }

        public decimal? MinScore
        {
            get
            {
                return _minScore;
            }
            set
            {
                _minScore = value;
                UpdateFieldValue("MinScore", value);
            }
        }

        public decimal? MaxScore
        {
            get
            {
                return _maxScore;
            }
            set
            {
                _maxScore = value;
                UpdateFieldValue("MaxScore", value);
            }
        }

        public string NG
        {
            get
            {
                return _nG;
            }
            set
            {
                _nG = value;
                UpdateFieldValue("NG", value);
            }
        }

        public string LG
        {
            get
            {
                return _lG;
            }
            set
            {
                _lG = value;
                UpdateFieldValue("LG", value);
            }
        }

        public bool? Passing
        {
            get
            {
                return _passing;
            }
            set
            {
                _passing = value;
                UpdateFieldValue("Passing", value);
            }
        }

        public string PerformanceBaseConversionDescription
        {
            get
            {
                return _performanceBaseConversionDescription;
            }
            set
            {
                _performanceBaseConversionDescription = value;
                UpdateFieldValue("PerformanceBaseConversionDescription", value);
            }
        }

        public int? GradeRank
        {
            get
            {
                return _gradeRank;
            }
            set
            {
                _gradeRank = value;
                UpdateFieldValue("GradeRank", value);
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

        public decimal? extMaxScore
        {
            get
            {
                return _extMaxScore;
            }
            set
            {
                _extMaxScore = value;
                UpdateFieldValue("extMaxScore", value);
            }
        }

        public int? extIsActiveSession
        {
            get
            {
                return _extIsActiveSession;
            }
            set
            {
                _extIsActiveSession = value;
                UpdateFieldValue("extIsActiveSession", value);
            }
        }

        public int? ExtIsCsy
        {
            get
            {
                return _extIsCsy;
            }
            set
            {
                _extIsCsy = value;
                UpdateFieldValue("ExtIsCsy", value);
            }
        }

        public bool? ExtActiveCourseSection
        {
            get
            {
                return _extActiveCourseSection;
            }
            set
            {
                _extActiveCourseSection = value;
                UpdateFieldValue("ExtActiveCourseSection", value);
            }
        }

        public decimal? ExtPBSG
        {
            get
            {
                return _extPBSG;
            }
            set
            {
                _extPBSG = value;
                UpdateFieldValue("ExtPBSG", value);
            }
        }

        public int? ExtCalendarSessionID
        {
            get
            {
                return _extCalendarSessionID;
            }
            set
            {
                _extCalendarSessionID = value;
                UpdateFieldValue("ExtCalendarSessionID", value);
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

        public bool? ExtIsPassing
        {
            get
            {
                return _extIsPassing;
            }
            set
            {
                _extIsPassing = value;
                UpdateFieldValue("ExtIsPassing", value);
            }
        }

        public decimal? ExtPWS
        {
            get
            {
                return _extPWS;
            }
            set
            {
                _extPWS = value;
                UpdateFieldValue("ExtPWS", value);
            }
        }

        public decimal? ExtOWS
        {
            get
            {
                return _extOWS;
            }
            set
            {
                _extOWS = value;
                UpdateFieldValue("ExtOWS", value);
            }
        }

        public decimal? CWS
        {
            get
            {
                return _cWS;
            }
            set
            {
                _cWS = value;
                UpdateFieldValue("CWS", value);
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

        public bool? SessionIsActive
        {
            get
            {
                return _sessionIsActive;
            }
            set
            {
                _sessionIsActive = value;
                UpdateFieldValue("SessionIsActive", value);
            }
        }

        public int? calYear
        {
            get
            {
                return _calYear;
            }
            set
            {
                _calYear = value;
                UpdateFieldValue("calYear", value);
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

        public string UPN
        {
            get
            {
                return _uPN;
            }
            set
            {
                _uPN = value;
                UpdateFieldValue("UPN", value);
            }
        }

        public string Firstname
        {
            get
            {
                return _firstname;
            }
            set
            {
                _firstname = value;
                UpdateFieldValue("Firstname", value);
            }
        }

        public string Lastname
        {
            get
            {
                return _lastname;
            }
            set
            {
                _lastname = value;
                UpdateFieldValue("Lastname", value);
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

        public int? SGID
        {
            get
            {
                return _sGID;
            }
            set
            {
                _sGID = value;
                UpdateFieldValue("SGID", value);
            }
        }

        public int? SCID
        {
            get
            {
                return _sCID;
            }
            set
            {
                _sCID = value;
                UpdateFieldValue("SCID", value);
            }
        }

        public int? extSGID
        {
            get
            {
                return _extSGID;
            }
            set
            {
                _extSGID = value;
                UpdateFieldValue("extSGID", value);
            }
        }

        public int? extSCID
        {
            get
            {
                return _extSCID;
            }
            set
            {
                _extSCID = value;
                UpdateFieldValue("extSCID", value);
            }
        }

        public string Fullname
        {
            get
            {
                return _fullname;
            }
            set
            {
                _fullname = value;
                UpdateFieldValue("Fullname", value);
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

        public FieldValue this[znStudentGradeBookEntryDataField field]
        {
            get
            {
                return this[field.ToString()];
            }
        }
    }
}

using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using zLearnHub.Data;

namespace zLearnHub.Models
{
    public enum SBLScoresheetDataField
    {

        StudentLearningObjectiveID,

        PerformanceBaseConversionID,

        PerformanceBaseConversionGradeName,

        PerformanceBaseConversionDescription,

        GradingPeriodID,

        GradingPeriod,

        StudentCourseSectionID,

        StudentCourseSectionCreatedBy,

        GradeTypeID,

        GradeType,

        EarnedScore,

        LetterGrade,

        AssessedDate,

        Weight,

        LearningObjectiveID,

        LearningObjectiveItemCode,

        MaxScore,

        ExtMaxScore,

        CreatedDate,

        ModifiedDate,

        CreatedBy,

        ModifiedBy,

        UserID,

        IsActive,

        ExtStatement,

        IdentificationCode,

        ExtIsActiveSession,

        ExtIsCsy,

        ExtIsPassing,

        ExtPWS,

        ExtPBSG,

        ExtOWS,

        ExtContentStandardNo,

        SuccessCriteria,

        IsActiveGradingPeriod,

        ExtItemCode,

        ExtStrandCode,

        ExtStrandDesc,

        ExtStandard,

        ExtCourseTitle,

        ExtSectionName,

        ExtPerformanceDescription,

        ExtContentDescription,

        FirstName,

        LastName,

        UPN,

        STM,
    }

    public partial class SBLScoresheetModel : BusinessRulesObjectModel
    {

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _studentLearningObjectiveID;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _performanceBaseConversionID;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _performanceBaseConversionGradeName;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _performanceBaseConversionDescription;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _gradingPeriodID;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _gradingPeriod;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _studentCourseSectionID;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _studentCourseSectionCreatedBy;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _gradeTypeID;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _gradeType;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private decimal? _earnedScore;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _letterGrade;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private DateTime? _assessedDate;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private decimal? _weight;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _learningObjectiveID;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _learningObjectiveItemCode;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private decimal? _maxScore;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private decimal? _extMaxScore;

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
        private bool? _isActive;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _extStatement;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _identificationCode;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private bool? _extIsActiveSession;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private bool? _extIsCsy;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private bool? _extIsPassing;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private decimal? _extPWS;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private decimal? _extPBSG;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private decimal? _extOWS;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _extContentStandardNo;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _successCriteria;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private bool? _isActiveGradingPeriod;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _extItemCode;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _extStrandCode;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _extStrandDesc;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _extStandard;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _extCourseTitle;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _extSectionName;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _extPerformanceDescription;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _extContentDescription;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _firstName;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _lastName;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _uPN;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _sTM;

        public SBLScoresheetModel()
        {
        }

        public SBLScoresheetModel(BusinessRules r) :
                base(r)
        {
        }

        public int? StudentLearningObjectiveID
        {
            get
            {
                return _studentLearningObjectiveID;
            }
            set
            {
                _studentLearningObjectiveID = value;
                UpdateFieldValue("StudentLearningObjectiveID", value);
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

        public string PerformanceBaseConversionGradeName
        {
            get
            {
                return _performanceBaseConversionGradeName;
            }
            set
            {
                _performanceBaseConversionGradeName = value;
                UpdateFieldValue("PerformanceBaseConversionGradeName", value);
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

        public int? GradeTypeID
        {
            get
            {
                return _gradeTypeID;
            }
            set
            {
                _gradeTypeID = value;
                UpdateFieldValue("GradeTypeID", value);
            }
        }

        public string GradeType
        {
            get
            {
                return _gradeType;
            }
            set
            {
                _gradeType = value;
                UpdateFieldValue("GradeType", value);
            }
        }

        public decimal? EarnedScore
        {
            get
            {
                return _earnedScore;
            }
            set
            {
                _earnedScore = value;
                UpdateFieldValue("EarnedScore", value);
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

        public DateTime? AssessedDate
        {
            get
            {
                return _assessedDate;
            }
            set
            {
                _assessedDate = value;
                UpdateFieldValue("AssessedDate", value);
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

        public int? LearningObjectiveID
        {
            get
            {
                return _learningObjectiveID;
            }
            set
            {
                _learningObjectiveID = value;
                UpdateFieldValue("LearningObjectiveID", value);
            }
        }

        public string LearningObjectiveItemCode
        {
            get
            {
                return _learningObjectiveItemCode;
            }
            set
            {
                _learningObjectiveItemCode = value;
                UpdateFieldValue("LearningObjectiveItemCode", value);
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

        public decimal? ExtMaxScore
        {
            get
            {
                return _extMaxScore;
            }
            set
            {
                _extMaxScore = value;
                UpdateFieldValue("ExtMaxScore", value);
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

        public string ExtStatement
        {
            get
            {
                return _extStatement;
            }
            set
            {
                _extStatement = value;
                UpdateFieldValue("ExtStatement", value);
            }
        }

        public string IdentificationCode
        {
            get
            {
                return _identificationCode;
            }
            set
            {
                _identificationCode = value;
                UpdateFieldValue("IdentificationCode", value);
            }
        }

        public bool? ExtIsActiveSession
        {
            get
            {
                return _extIsActiveSession;
            }
            set
            {
                _extIsActiveSession = value;
                UpdateFieldValue("ExtIsActiveSession", value);
            }
        }

        public bool? ExtIsCsy
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

        public string ExtContentStandardNo
        {
            get
            {
                return _extContentStandardNo;
            }
            set
            {
                _extContentStandardNo = value;
                UpdateFieldValue("ExtContentStandardNo", value);
            }
        }

        public string SuccessCriteria
        {
            get
            {
                return _successCriteria;
            }
            set
            {
                _successCriteria = value;
                UpdateFieldValue("SuccessCriteria", value);
            }
        }

        public bool? IsActiveGradingPeriod
        {
            get
            {
                return _isActiveGradingPeriod;
            }
            set
            {
                _isActiveGradingPeriod = value;
                UpdateFieldValue("IsActiveGradingPeriod", value);
            }
        }

        public string ExtItemCode
        {
            get
            {
                return _extItemCode;
            }
            set
            {
                _extItemCode = value;
                UpdateFieldValue("ExtItemCode", value);
            }
        }

        public string ExtStrandCode
        {
            get
            {
                return _extStrandCode;
            }
            set
            {
                _extStrandCode = value;
                UpdateFieldValue("ExtStrandCode", value);
            }
        }

        public string ExtStrandDesc
        {
            get
            {
                return _extStrandDesc;
            }
            set
            {
                _extStrandDesc = value;
                UpdateFieldValue("ExtStrandDesc", value);
            }
        }

        public string ExtStandard
        {
            get
            {
                return _extStandard;
            }
            set
            {
                _extStandard = value;
                UpdateFieldValue("ExtStandard", value);
            }
        }

        public string ExtCourseTitle
        {
            get
            {
                return _extCourseTitle;
            }
            set
            {
                _extCourseTitle = value;
                UpdateFieldValue("ExtCourseTitle", value);
            }
        }

        public string ExtSectionName
        {
            get
            {
                return _extSectionName;
            }
            set
            {
                _extSectionName = value;
                UpdateFieldValue("ExtSectionName", value);
            }
        }

        public string ExtPerformanceDescription
        {
            get
            {
                return _extPerformanceDescription;
            }
            set
            {
                _extPerformanceDescription = value;
                UpdateFieldValue("ExtPerformanceDescription", value);
            }
        }

        public string ExtContentDescription
        {
            get
            {
                return _extContentDescription;
            }
            set
            {
                _extContentDescription = value;
                UpdateFieldValue("ExtContentDescription", value);
            }
        }

        public string FirstName
        {
            get
            {
                return _firstName;
            }
            set
            {
                _firstName = value;
                UpdateFieldValue("FirstName", value);
            }
        }

        public string LastName
        {
            get
            {
                return _lastName;
            }
            set
            {
                _lastName = value;
                UpdateFieldValue("LastName", value);
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

        public string STM
        {
            get
            {
                return _sTM;
            }
            set
            {
                _sTM = value;
                UpdateFieldValue("STM", value);
            }
        }

        public FieldValue this[SBLScoresheetDataField field]
        {
            get
            {
                return this[field.ToString()];
            }
        }
    }
}

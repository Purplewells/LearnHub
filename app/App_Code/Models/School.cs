using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using zLearnHub.Data;

namespace zLearnHub.Models
{
    public enum SchoolDataField
    {

        SchoolName,

        RefSchoolTypeID,

        RefSchoolTypeDescription,

        RefSchoolLevelID,

        RefSchoolLevelDescription,

        CharterSchoolIndicator,

        RefCharterSchoolTypeID,

        RefCharterSchoolTypeDescription,

        ApprovalYear,

        ContractApprovalDate,

        ContractNumber,

        OrganizationID,

        OrganisationName,

        OrganisationShortName,

        OrganisationWebsite,

        OrganisationEmail,

        OrganisationIsActive,

        OrganisationAddress,

        SchoolAddress,
    }

    public partial class SchoolModel : BusinessRulesObjectModel
    {

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _schoolName;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _refSchoolTypeID;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _refSchoolTypeDescription;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _refSchoolLevelID;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _refSchoolLevelDescription;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private bool? _charterSchoolIndicator;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _refCharterSchoolTypeID;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _refCharterSchoolTypeDescription;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _approvalYear;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private DateTime? _contractApprovalDate;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _contractNumber;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _organizationID;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _organisationName;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _organisationShortName;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _organisationWebsite;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _organisationEmail;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private bool? _organisationIsActive;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _organisationAddress;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _schoolAddress;

        public SchoolModel()
        {
        }

        public SchoolModel(BusinessRules r) :
                base(r)
        {
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

        public int? RefSchoolTypeID
        {
            get
            {
                return _refSchoolTypeID;
            }
            set
            {
                _refSchoolTypeID = value;
                UpdateFieldValue("RefSchoolTypeID", value);
            }
        }

        public string RefSchoolTypeDescription
        {
            get
            {
                return _refSchoolTypeDescription;
            }
            set
            {
                _refSchoolTypeDescription = value;
                UpdateFieldValue("RefSchoolTypeDescription", value);
            }
        }

        public int? RefSchoolLevelID
        {
            get
            {
                return _refSchoolLevelID;
            }
            set
            {
                _refSchoolLevelID = value;
                UpdateFieldValue("RefSchoolLevelID", value);
            }
        }

        public string RefSchoolLevelDescription
        {
            get
            {
                return _refSchoolLevelDescription;
            }
            set
            {
                _refSchoolLevelDescription = value;
                UpdateFieldValue("RefSchoolLevelDescription", value);
            }
        }

        public bool? CharterSchoolIndicator
        {
            get
            {
                return _charterSchoolIndicator;
            }
            set
            {
                _charterSchoolIndicator = value;
                UpdateFieldValue("CharterSchoolIndicator", value);
            }
        }

        public int? RefCharterSchoolTypeID
        {
            get
            {
                return _refCharterSchoolTypeID;
            }
            set
            {
                _refCharterSchoolTypeID = value;
                UpdateFieldValue("RefCharterSchoolTypeID", value);
            }
        }

        public string RefCharterSchoolTypeDescription
        {
            get
            {
                return _refCharterSchoolTypeDescription;
            }
            set
            {
                _refCharterSchoolTypeDescription = value;
                UpdateFieldValue("RefCharterSchoolTypeDescription", value);
            }
        }

        public string ApprovalYear
        {
            get
            {
                return _approvalYear;
            }
            set
            {
                _approvalYear = value;
                UpdateFieldValue("ApprovalYear", value);
            }
        }

        public DateTime? ContractApprovalDate
        {
            get
            {
                return _contractApprovalDate;
            }
            set
            {
                _contractApprovalDate = value;
                UpdateFieldValue("ContractApprovalDate", value);
            }
        }

        public string ContractNumber
        {
            get
            {
                return _contractNumber;
            }
            set
            {
                _contractNumber = value;
                UpdateFieldValue("ContractNumber", value);
            }
        }

        public int? OrganizationID
        {
            get
            {
                return _organizationID;
            }
            set
            {
                _organizationID = value;
                UpdateFieldValue("OrganizationID", value);
            }
        }

        public string OrganisationName
        {
            get
            {
                return _organisationName;
            }
            set
            {
                _organisationName = value;
                UpdateFieldValue("OrganisationName", value);
            }
        }

        public string OrganisationShortName
        {
            get
            {
                return _organisationShortName;
            }
            set
            {
                _organisationShortName = value;
                UpdateFieldValue("OrganisationShortName", value);
            }
        }

        public string OrganisationWebsite
        {
            get
            {
                return _organisationWebsite;
            }
            set
            {
                _organisationWebsite = value;
                UpdateFieldValue("OrganisationWebsite", value);
            }
        }

        public string OrganisationEmail
        {
            get
            {
                return _organisationEmail;
            }
            set
            {
                _organisationEmail = value;
                UpdateFieldValue("OrganisationEmail", value);
            }
        }

        public bool? OrganisationIsActive
        {
            get
            {
                return _organisationIsActive;
            }
            set
            {
                _organisationIsActive = value;
                UpdateFieldValue("OrganisationIsActive", value);
            }
        }

        public string OrganisationAddress
        {
            get
            {
                return _organisationAddress;
            }
            set
            {
                _organisationAddress = value;
                UpdateFieldValue("OrganisationAddress", value);
            }
        }

        public string SchoolAddress
        {
            get
            {
                return _schoolAddress;
            }
            set
            {
                _schoolAddress = value;
                UpdateFieldValue("SchoolAddress", value);
            }
        }

        public FieldValue this[SchoolDataField field]
        {
            get
            {
                return this[field.ToString()];
            }
        }
    }
}

using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using zLearnHub.Data;

namespace zLearnHub.Models
{
    public enum SchoolInstituitionDataField
    {

        SchoolName,

        RefSchoolTypeID,

        RefSchoolTypeDescription,

        RefSchoolLevelID,

        RefSchoolLevelDescription,

        RefAdministrativeFundingControlID,

        RefAdministrativeFundingControlDescription,

        CharterSchoolIndicator,

        RefCharterSchoolTypeID,

        RefCharterSchoolTypeDescription,

        ApprovalYear,

        RefCharterSchoolApprovalAgencyTypeID,

        RefCharterSchoolApprovalAgencyTypeDescription,

        ContractApprovalDate,

        ContractNumber,

        ContractRenewalDate,

        RefCharterSchoolManagementOrganizationTypeID,

        RefCharterSchoolManagementOrganizationTypeDescription,

        OrganizationID,

        OrganisationTypeDescription,

        OrganisationTypeElementTypeDescription,

        OrganisationName,

        OrganisationTypeID,

        OrganisationShortName,

        OrganisationWebsite,

        OrganisationEmail,

        OrganisationIsActive,

        OrganisationAddress,

        Address,

        CreatedDate,

        ModifiedDate,

        ModifiedBy,

        CreatedBy,
    }

    public partial class SchoolInstituitionModel : BusinessRulesObjectModel
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
        private int? _refAdministrativeFundingControlID;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _refAdministrativeFundingControlDescription;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private bool? _charterSchoolIndicator;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _refCharterSchoolTypeID;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _refCharterSchoolTypeDescription;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _approvalYear;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _refCharterSchoolApprovalAgencyTypeID;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _refCharterSchoolApprovalAgencyTypeDescription;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private DateTime? _contractApprovalDate;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _contractNumber;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private DateTime? _contractRenewalDate;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _refCharterSchoolManagementOrganizationTypeID;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _refCharterSchoolManagementOrganizationTypeDescription;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _organizationID;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _organisationTypeDescription;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _organisationTypeElementTypeDescription;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _organisationName;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _organisationTypeID;

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
        private string _address;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private DateTime? _createdDate;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private DateTime? _modifiedDate;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _modifiedBy;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _createdBy;

        public SchoolInstituitionModel()
        {
        }

        public SchoolInstituitionModel(BusinessRules r) :
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

        public int? RefAdministrativeFundingControlID
        {
            get
            {
                return _refAdministrativeFundingControlID;
            }
            set
            {
                _refAdministrativeFundingControlID = value;
                UpdateFieldValue("RefAdministrativeFundingControlID", value);
            }
        }

        public string RefAdministrativeFundingControlDescription
        {
            get
            {
                return _refAdministrativeFundingControlDescription;
            }
            set
            {
                _refAdministrativeFundingControlDescription = value;
                UpdateFieldValue("RefAdministrativeFundingControlDescription", value);
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

        public int? RefCharterSchoolApprovalAgencyTypeID
        {
            get
            {
                return _refCharterSchoolApprovalAgencyTypeID;
            }
            set
            {
                _refCharterSchoolApprovalAgencyTypeID = value;
                UpdateFieldValue("RefCharterSchoolApprovalAgencyTypeID", value);
            }
        }

        public string RefCharterSchoolApprovalAgencyTypeDescription
        {
            get
            {
                return _refCharterSchoolApprovalAgencyTypeDescription;
            }
            set
            {
                _refCharterSchoolApprovalAgencyTypeDescription = value;
                UpdateFieldValue("RefCharterSchoolApprovalAgencyTypeDescription", value);
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

        public DateTime? ContractRenewalDate
        {
            get
            {
                return _contractRenewalDate;
            }
            set
            {
                _contractRenewalDate = value;
                UpdateFieldValue("ContractRenewalDate", value);
            }
        }

        public int? RefCharterSchoolManagementOrganizationTypeID
        {
            get
            {
                return _refCharterSchoolManagementOrganizationTypeID;
            }
            set
            {
                _refCharterSchoolManagementOrganizationTypeID = value;
                UpdateFieldValue("RefCharterSchoolManagementOrganizationTypeID", value);
            }
        }

        public string RefCharterSchoolManagementOrganizationTypeDescription
        {
            get
            {
                return _refCharterSchoolManagementOrganizationTypeDescription;
            }
            set
            {
                _refCharterSchoolManagementOrganizationTypeDescription = value;
                UpdateFieldValue("RefCharterSchoolManagementOrganizationTypeDescription", value);
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

        public string OrganisationTypeDescription
        {
            get
            {
                return _organisationTypeDescription;
            }
            set
            {
                _organisationTypeDescription = value;
                UpdateFieldValue("OrganisationTypeDescription", value);
            }
        }

        public string OrganisationTypeElementTypeDescription
        {
            get
            {
                return _organisationTypeElementTypeDescription;
            }
            set
            {
                _organisationTypeElementTypeDescription = value;
                UpdateFieldValue("OrganisationTypeElementTypeDescription", value);
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

        public int? OrganisationTypeID
        {
            get
            {
                return _organisationTypeID;
            }
            set
            {
                _organisationTypeID = value;
                UpdateFieldValue("OrganisationTypeID", value);
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

        public string Address
        {
            get
            {
                return _address;
            }
            set
            {
                _address = value;
                UpdateFieldValue("Address", value);
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

        public FieldValue this[SchoolInstituitionDataField field]
        {
            get
            {
                return this[field.ToString()];
            }
        }
    }
}

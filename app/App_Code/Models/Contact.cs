using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using zLearnHub.Data;

namespace zLearnHub.Models
{
    public enum ContactDataField
    {

        PersonID,

        UPN,

        FirstName,

        MiddleName,

        LastName,

        BirthDate,

        RefSexID,

        Sex,

        RefCitizenshipStatusID,

        Ethnicity,

        RefProofOfResidencyTypeID,

        ProofOfResidency,

        CreatedBy,

        CreatedDate,

        ModifiedDate,

        ModifiedBy,

        Email,

        PhoneNo,

        CYS,

        CYG,

        ExtendedRole,

        ExtendedLiveStatusStartDate,

        ExtendedLiveStatusEndDate,

        TitleID,

        Title,

        LanguageID,

        Language,

        ReligionID,

        Religion,

        OrganizationID,

        OrganizationName,

        Address,

        TownID,

        Town,

        PostalCode,

        CountryID,

        Country,

        LocationTypeID,

        LocationType,

        CreatedByID,

        ExtSetGradeLevel,

        ImportGL,

        RefOccupationID,

        HeaderFullname,

        Occupation,

        AGE,

        Fullname,

        SSNo,

        AccountNo,

        Bank,

        MarkedForDeletion,
    }

    public partial class ContactModel : BusinessRulesObjectModel
    {

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _personID;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _uPN;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _firstName;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _middleName;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _lastName;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private DateTime? _birthDate;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _refSexID;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _sex;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _refCitizenshipStatusID;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _ethnicity;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _refProofOfResidencyTypeID;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _proofOfResidency;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _createdBy;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private DateTime? _createdDate;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private DateTime? _modifiedDate;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _modifiedBy;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _email;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _phoneNo;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _cYS;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _cYG;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _extendedRole;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private DateTime? _extendedLiveStatusStartDate;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private DateTime? _extendedLiveStatusEndDate;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _titleID;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _title;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _languageID;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _language;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _religionID;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _religion;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _organizationID;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _organizationName;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _address;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _townID;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _town;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _postalCode;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _countryID;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _country;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _locationTypeID;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _locationType;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _createdByID;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _extSetGradeLevel;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _importGL;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _refOccupationID;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _headerFullname;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _occupation;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _aGE;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _fullname;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _sSNo;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _accountNo;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _bank;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private bool? _markedForDeletion;

        public ContactModel()
        {
        }

        public ContactModel(BusinessRules r) :
                base(r)
        {
        }

        public int? PersonID
        {
            get
            {
                return _personID;
            }
            set
            {
                _personID = value;
                UpdateFieldValue("PersonID", value);
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

        public string MiddleName
        {
            get
            {
                return _middleName;
            }
            set
            {
                _middleName = value;
                UpdateFieldValue("MiddleName", value);
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

        public DateTime? BirthDate
        {
            get
            {
                return _birthDate;
            }
            set
            {
                _birthDate = value;
                UpdateFieldValue("BirthDate", value);
            }
        }

        public int? RefSexID
        {
            get
            {
                return _refSexID;
            }
            set
            {
                _refSexID = value;
                UpdateFieldValue("RefSexID", value);
            }
        }

        public string Sex
        {
            get
            {
                return _sex;
            }
            set
            {
                _sex = value;
                UpdateFieldValue("Sex", value);
            }
        }

        public int? RefCitizenshipStatusID
        {
            get
            {
                return _refCitizenshipStatusID;
            }
            set
            {
                _refCitizenshipStatusID = value;
                UpdateFieldValue("RefCitizenshipStatusID", value);
            }
        }

        public string Ethnicity
        {
            get
            {
                return _ethnicity;
            }
            set
            {
                _ethnicity = value;
                UpdateFieldValue("Ethnicity", value);
            }
        }

        public int? RefProofOfResidencyTypeID
        {
            get
            {
                return _refProofOfResidencyTypeID;
            }
            set
            {
                _refProofOfResidencyTypeID = value;
                UpdateFieldValue("RefProofOfResidencyTypeID", value);
            }
        }

        public string ProofOfResidency
        {
            get
            {
                return _proofOfResidency;
            }
            set
            {
                _proofOfResidency = value;
                UpdateFieldValue("ProofOfResidency", value);
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

        public string Email
        {
            get
            {
                return _email;
            }
            set
            {
                _email = value;
                UpdateFieldValue("Email", value);
            }
        }

        public string PhoneNo
        {
            get
            {
                return _phoneNo;
            }
            set
            {
                _phoneNo = value;
                UpdateFieldValue("PhoneNo", value);
            }
        }

        public string CYS
        {
            get
            {
                return _cYS;
            }
            set
            {
                _cYS = value;
                UpdateFieldValue("CYS", value);
            }
        }

        public string CYG
        {
            get
            {
                return _cYG;
            }
            set
            {
                _cYG = value;
                UpdateFieldValue("CYG", value);
            }
        }

        public string ExtendedRole
        {
            get
            {
                return _extendedRole;
            }
            set
            {
                _extendedRole = value;
                UpdateFieldValue("ExtendedRole", value);
            }
        }

        public DateTime? ExtendedLiveStatusStartDate
        {
            get
            {
                return _extendedLiveStatusStartDate;
            }
            set
            {
                _extendedLiveStatusStartDate = value;
                UpdateFieldValue("ExtendedLiveStatusStartDate", value);
            }
        }

        public DateTime? ExtendedLiveStatusEndDate
        {
            get
            {
                return _extendedLiveStatusEndDate;
            }
            set
            {
                _extendedLiveStatusEndDate = value;
                UpdateFieldValue("ExtendedLiveStatusEndDate", value);
            }
        }

        public int? TitleID
        {
            get
            {
                return _titleID;
            }
            set
            {
                _titleID = value;
                UpdateFieldValue("TitleID", value);
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

        public int? LanguageID
        {
            get
            {
                return _languageID;
            }
            set
            {
                _languageID = value;
                UpdateFieldValue("LanguageID", value);
            }
        }

        public string Language
        {
            get
            {
                return _language;
            }
            set
            {
                _language = value;
                UpdateFieldValue("Language", value);
            }
        }

        public int? ReligionID
        {
            get
            {
                return _religionID;
            }
            set
            {
                _religionID = value;
                UpdateFieldValue("ReligionID", value);
            }
        }

        public string Religion
        {
            get
            {
                return _religion;
            }
            set
            {
                _religion = value;
                UpdateFieldValue("Religion", value);
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

        public string OrganizationName
        {
            get
            {
                return _organizationName;
            }
            set
            {
                _organizationName = value;
                UpdateFieldValue("OrganizationName", value);
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

        public int? TownID
        {
            get
            {
                return _townID;
            }
            set
            {
                _townID = value;
                UpdateFieldValue("TownID", value);
            }
        }

        public string Town
        {
            get
            {
                return _town;
            }
            set
            {
                _town = value;
                UpdateFieldValue("Town", value);
            }
        }

        public string PostalCode
        {
            get
            {
                return _postalCode;
            }
            set
            {
                _postalCode = value;
                UpdateFieldValue("PostalCode", value);
            }
        }

        public int? CountryID
        {
            get
            {
                return _countryID;
            }
            set
            {
                _countryID = value;
                UpdateFieldValue("CountryID", value);
            }
        }

        public string Country
        {
            get
            {
                return _country;
            }
            set
            {
                _country = value;
                UpdateFieldValue("Country", value);
            }
        }

        public int? LocationTypeID
        {
            get
            {
                return _locationTypeID;
            }
            set
            {
                _locationTypeID = value;
                UpdateFieldValue("LocationTypeID", value);
            }
        }

        public string LocationType
        {
            get
            {
                return _locationType;
            }
            set
            {
                _locationType = value;
                UpdateFieldValue("LocationType", value);
            }
        }

        public string CreatedByID
        {
            get
            {
                return _createdByID;
            }
            set
            {
                _createdByID = value;
                UpdateFieldValue("CreatedByID", value);
            }
        }

        public string ExtSetGradeLevel
        {
            get
            {
                return _extSetGradeLevel;
            }
            set
            {
                _extSetGradeLevel = value;
                UpdateFieldValue("ExtSetGradeLevel", value);
            }
        }

        public string ImportGL
        {
            get
            {
                return _importGL;
            }
            set
            {
                _importGL = value;
                UpdateFieldValue("ImportGL", value);
            }
        }

        public int? RefOccupationID
        {
            get
            {
                return _refOccupationID;
            }
            set
            {
                _refOccupationID = value;
                UpdateFieldValue("RefOccupationID", value);
            }
        }

        public string HeaderFullname
        {
            get
            {
                return _headerFullname;
            }
            set
            {
                _headerFullname = value;
                UpdateFieldValue("HeaderFullname", value);
            }
        }

        public string Occupation
        {
            get
            {
                return _occupation;
            }
            set
            {
                _occupation = value;
                UpdateFieldValue("Occupation", value);
            }
        }

        public string AGE
        {
            get
            {
                return _aGE;
            }
            set
            {
                _aGE = value;
                UpdateFieldValue("AGE", value);
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

        public string SSNo
        {
            get
            {
                return _sSNo;
            }
            set
            {
                _sSNo = value;
                UpdateFieldValue("SSNo", value);
            }
        }

        public string AccountNo
        {
            get
            {
                return _accountNo;
            }
            set
            {
                _accountNo = value;
                UpdateFieldValue("AccountNo", value);
            }
        }

        public string Bank
        {
            get
            {
                return _bank;
            }
            set
            {
                _bank = value;
                UpdateFieldValue("Bank", value);
            }
        }

        public bool? MarkedForDeletion
        {
            get
            {
                return _markedForDeletion;
            }
            set
            {
                _markedForDeletion = value;
                UpdateFieldValue("MarkedForDeletion", value);
            }
        }

        public FieldValue this[ContactDataField field]
        {
            get
            {
                return this[field.ToString()];
            }
        }
    }
}

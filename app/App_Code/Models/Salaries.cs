using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using zLearnHub.Data;

namespace zLearnHub.Models
{
    public enum SalariesDataField
    {

        SalaryID,

        SalaryName,

        SalaryBasisID,

        SalaryBasisName,

        TheSalaryBasisBaseAmount,

        BaseSalaryAmount,

        GrossAmount,

        NetAmount,

        Deductions,

        ActionID,

        Action,

        IsApproved,

        AssignmentID,

        AssignmentStaffClassificationID,

        ProposedDate,

        NextReviewDate,

        StartDate,

        EndDate,

        CreatedDate,

        ModifiedDate,

        CreatedBy,

        ModifiedBy,

        PreTaxDeductions,

        TaxableBenefits,

        NonTaxableBenefits,

        EmployerTaxes,

        TaxablePay,

        TaxAmount,

        UPN,

        FirstName,

        LastName,
    }

    public partial class SalariesModel : BusinessRulesObjectModel
    {

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _salaryID;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _salaryName;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _salaryBasisID;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _salaryBasisName;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private decimal? _theSalaryBasisBaseAmount;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private decimal? _baseSalaryAmount;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private decimal? _grossAmount;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private decimal? _netAmount;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private decimal? _deductions;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _actionID;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _action;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private bool? _isApproved;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _assignmentID;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _assignmentStaffClassificationID;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private DateTime? _proposedDate;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private DateTime? _nextReviewDate;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private DateTime? _startDate;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private DateTime? _endDate;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private DateTime? _createdDate;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private DateTime? _modifiedDate;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _createdBy;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _modifiedBy;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private decimal? _preTaxDeductions;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private decimal? _taxableBenefits;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private decimal? _nonTaxableBenefits;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private decimal? _employerTaxes;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private decimal? _taxablePay;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private decimal? _taxAmount;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _uPN;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _firstName;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _lastName;

        public SalariesModel()
        {
        }

        public SalariesModel(BusinessRules r) :
                base(r)
        {
        }

        public int? SalaryID
        {
            get
            {
                return _salaryID;
            }
            set
            {
                _salaryID = value;
                UpdateFieldValue("SalaryID", value);
            }
        }

        public string SalaryName
        {
            get
            {
                return _salaryName;
            }
            set
            {
                _salaryName = value;
                UpdateFieldValue("SalaryName", value);
            }
        }

        public int? SalaryBasisID
        {
            get
            {
                return _salaryBasisID;
            }
            set
            {
                _salaryBasisID = value;
                UpdateFieldValue("SalaryBasisID", value);
            }
        }

        public string SalaryBasisName
        {
            get
            {
                return _salaryBasisName;
            }
            set
            {
                _salaryBasisName = value;
                UpdateFieldValue("SalaryBasisName", value);
            }
        }

        public decimal? TheSalaryBasisBaseAmount
        {
            get
            {
                return _theSalaryBasisBaseAmount;
            }
            set
            {
                _theSalaryBasisBaseAmount = value;
                UpdateFieldValue("TheSalaryBasisBaseAmount", value);
            }
        }

        public decimal? BaseSalaryAmount
        {
            get
            {
                return _baseSalaryAmount;
            }
            set
            {
                _baseSalaryAmount = value;
                UpdateFieldValue("BaseSalaryAmount", value);
            }
        }

        public decimal? GrossAmount
        {
            get
            {
                return _grossAmount;
            }
            set
            {
                _grossAmount = value;
                UpdateFieldValue("GrossAmount", value);
            }
        }

        public decimal? NetAmount
        {
            get
            {
                return _netAmount;
            }
            set
            {
                _netAmount = value;
                UpdateFieldValue("NetAmount", value);
            }
        }

        public decimal? Deductions
        {
            get
            {
                return _deductions;
            }
            set
            {
                _deductions = value;
                UpdateFieldValue("Deductions", value);
            }
        }

        public int? ActionID
        {
            get
            {
                return _actionID;
            }
            set
            {
                _actionID = value;
                UpdateFieldValue("ActionID", value);
            }
        }

        public string Action
        {
            get
            {
                return _action;
            }
            set
            {
                _action = value;
                UpdateFieldValue("Action", value);
            }
        }

        public bool? IsApproved
        {
            get
            {
                return _isApproved;
            }
            set
            {
                _isApproved = value;
                UpdateFieldValue("IsApproved", value);
            }
        }

        public int? AssignmentID
        {
            get
            {
                return _assignmentID;
            }
            set
            {
                _assignmentID = value;
                UpdateFieldValue("AssignmentID", value);
            }
        }

        public int? AssignmentStaffClassificationID
        {
            get
            {
                return _assignmentStaffClassificationID;
            }
            set
            {
                _assignmentStaffClassificationID = value;
                UpdateFieldValue("AssignmentStaffClassificationID", value);
            }
        }

        public DateTime? ProposedDate
        {
            get
            {
                return _proposedDate;
            }
            set
            {
                _proposedDate = value;
                UpdateFieldValue("ProposedDate", value);
            }
        }

        public DateTime? NextReviewDate
        {
            get
            {
                return _nextReviewDate;
            }
            set
            {
                _nextReviewDate = value;
                UpdateFieldValue("NextReviewDate", value);
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

        public decimal? PreTaxDeductions
        {
            get
            {
                return _preTaxDeductions;
            }
            set
            {
                _preTaxDeductions = value;
                UpdateFieldValue("PreTaxDeductions", value);
            }
        }

        public decimal? TaxableBenefits
        {
            get
            {
                return _taxableBenefits;
            }
            set
            {
                _taxableBenefits = value;
                UpdateFieldValue("TaxableBenefits", value);
            }
        }

        public decimal? NonTaxableBenefits
        {
            get
            {
                return _nonTaxableBenefits;
            }
            set
            {
                _nonTaxableBenefits = value;
                UpdateFieldValue("NonTaxableBenefits", value);
            }
        }

        public decimal? EmployerTaxes
        {
            get
            {
                return _employerTaxes;
            }
            set
            {
                _employerTaxes = value;
                UpdateFieldValue("EmployerTaxes", value);
            }
        }

        public decimal? TaxablePay
        {
            get
            {
                return _taxablePay;
            }
            set
            {
                _taxablePay = value;
                UpdateFieldValue("TaxablePay", value);
            }
        }

        public decimal? TaxAmount
        {
            get
            {
                return _taxAmount;
            }
            set
            {
                _taxAmount = value;
                UpdateFieldValue("TaxAmount", value);
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

        public FieldValue this[SalariesDataField field]
        {
            get
            {
                return this[field.ToString()];
            }
        }
    }
}

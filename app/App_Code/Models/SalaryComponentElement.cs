using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using zLearnHub.Data;

namespace zLearnHub.Models
{
    public enum SalaryComponentElementDataField
    {

        SalaryComponentElementID,

        SalaryID,

        SalaryName,

        Amount,

        IsPercentBased,

        AdjustmentFactor,

        AmountValue,

        IsActive,

        IsApproved,

        IsTaxable,

        IsEarnings,

        TaxRate,

        StartDate,

        EndDate,

        IsShowOnPayslip,

        CurrencyID,

        CurrencyName,

        ElementID,

        ElementName,

        ElementSortOrder,

        ComponentType,

        CreatedDate,

        ModifiedDate,

        CreatedBy,

        ModifiedBy,
    }

    public partial class SalaryComponentElementModel : BusinessRulesObjectModel
    {

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _salaryComponentElementID;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _salaryID;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _salaryName;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private decimal? _amount;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private bool? _isPercentBased;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private decimal? _adjustmentFactor;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private decimal? _amountValue;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private bool? _isActive;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private bool? _isApproved;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private bool? _isTaxable;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private bool? _isEarnings;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private decimal? _taxRate;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private DateTime? _startDate;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private DateTime? _endDate;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private bool? _isShowOnPayslip;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _currencyID;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _currencyName;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _elementID;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _elementName;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _elementSortOrder;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _componentType;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private DateTime? _createdDate;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private DateTime? _modifiedDate;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _createdBy;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _modifiedBy;

        public SalaryComponentElementModel()
        {
        }

        public SalaryComponentElementModel(BusinessRules r) :
                base(r)
        {
        }

        public int? SalaryComponentElementID
        {
            get
            {
                return _salaryComponentElementID;
            }
            set
            {
                _salaryComponentElementID = value;
                UpdateFieldValue("SalaryComponentElementID", value);
            }
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

        public decimal? Amount
        {
            get
            {
                return _amount;
            }
            set
            {
                _amount = value;
                UpdateFieldValue("Amount", value);
            }
        }

        public bool? IsPercentBased
        {
            get
            {
                return _isPercentBased;
            }
            set
            {
                _isPercentBased = value;
                UpdateFieldValue("IsPercentBased", value);
            }
        }

        public decimal? AdjustmentFactor
        {
            get
            {
                return _adjustmentFactor;
            }
            set
            {
                _adjustmentFactor = value;
                UpdateFieldValue("AdjustmentFactor", value);
            }
        }

        public decimal? AmountValue
        {
            get
            {
                return _amountValue;
            }
            set
            {
                _amountValue = value;
                UpdateFieldValue("AmountValue", value);
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

        public bool? IsTaxable
        {
            get
            {
                return _isTaxable;
            }
            set
            {
                _isTaxable = value;
                UpdateFieldValue("IsTaxable", value);
            }
        }

        public bool? IsEarnings
        {
            get
            {
                return _isEarnings;
            }
            set
            {
                _isEarnings = value;
                UpdateFieldValue("IsEarnings", value);
            }
        }

        public decimal? TaxRate
        {
            get
            {
                return _taxRate;
            }
            set
            {
                _taxRate = value;
                UpdateFieldValue("TaxRate", value);
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

        public bool? IsShowOnPayslip
        {
            get
            {
                return _isShowOnPayslip;
            }
            set
            {
                _isShowOnPayslip = value;
                UpdateFieldValue("IsShowOnPayslip", value);
            }
        }

        public int? CurrencyID
        {
            get
            {
                return _currencyID;
            }
            set
            {
                _currencyID = value;
                UpdateFieldValue("CurrencyID", value);
            }
        }

        public string CurrencyName
        {
            get
            {
                return _currencyName;
            }
            set
            {
                _currencyName = value;
                UpdateFieldValue("CurrencyName", value);
            }
        }

        public int? ElementID
        {
            get
            {
                return _elementID;
            }
            set
            {
                _elementID = value;
                UpdateFieldValue("ElementID", value);
            }
        }

        public string ElementName
        {
            get
            {
                return _elementName;
            }
            set
            {
                _elementName = value;
                UpdateFieldValue("ElementName", value);
            }
        }

        public int? ElementSortOrder
        {
            get
            {
                return _elementSortOrder;
            }
            set
            {
                _elementSortOrder = value;
                UpdateFieldValue("ElementSortOrder", value);
            }
        }

        public string ComponentType
        {
            get
            {
                return _componentType;
            }
            set
            {
                _componentType = value;
                UpdateFieldValue("ComponentType", value);
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

        public FieldValue this[SalaryComponentElementDataField field]
        {
            get
            {
                return this[field.ToString()];
            }
        }
    }
}

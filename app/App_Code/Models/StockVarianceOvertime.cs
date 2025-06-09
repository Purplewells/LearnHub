using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using zLearnHub.Data;

namespace zLearnHub.Models
{
    public enum StockVarianceOvertimeDataField
    {

        VarianceID,

        ProductID,

        ProductName,

        SKU,

        ProductQuantity,

        SystemQuantity,

        QuantityCounted,

        StockTakeDate,

        Variance,

        VariancePercentage,

        IsVarianceApproved,

        ApprovalDate,

        CreatedDate,

        CreatedBy,

        ModifiedBy,
    }

    public partial class StockVarianceOvertimeModel : BusinessRulesObjectModel
    {

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _varianceID;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _productID;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _productName;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _sKU;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _productQuantity;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _systemQuantity;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _quantityCounted;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private DateTime? _stockTakeDate;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _variance;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private decimal? _variancePercentage;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private bool? _isVarianceApproved;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private DateTime? _approvalDate;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private DateTime? _createdDate;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _createdBy;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _modifiedBy;

        public StockVarianceOvertimeModel()
        {
        }

        public StockVarianceOvertimeModel(BusinessRules r) :
                base(r)
        {
        }

        public int? VarianceID
        {
            get
            {
                return _varianceID;
            }
            set
            {
                _varianceID = value;
                UpdateFieldValue("VarianceID", value);
            }
        }

        public int? ProductID
        {
            get
            {
                return _productID;
            }
            set
            {
                _productID = value;
                UpdateFieldValue("ProductID", value);
            }
        }

        public string ProductName
        {
            get
            {
                return _productName;
            }
            set
            {
                _productName = value;
                UpdateFieldValue("ProductName", value);
            }
        }

        public string SKU
        {
            get
            {
                return _sKU;
            }
            set
            {
                _sKU = value;
                UpdateFieldValue("SKU", value);
            }
        }

        public int? ProductQuantity
        {
            get
            {
                return _productQuantity;
            }
            set
            {
                _productQuantity = value;
                UpdateFieldValue("ProductQuantity", value);
            }
        }

        public int? SystemQuantity
        {
            get
            {
                return _systemQuantity;
            }
            set
            {
                _systemQuantity = value;
                UpdateFieldValue("SystemQuantity", value);
            }
        }

        public int? QuantityCounted
        {
            get
            {
                return _quantityCounted;
            }
            set
            {
                _quantityCounted = value;
                UpdateFieldValue("QuantityCounted", value);
            }
        }

        public DateTime? StockTakeDate
        {
            get
            {
                return _stockTakeDate;
            }
            set
            {
                _stockTakeDate = value;
                UpdateFieldValue("StockTakeDate", value);
            }
        }

        public int? Variance
        {
            get
            {
                return _variance;
            }
            set
            {
                _variance = value;
                UpdateFieldValue("Variance", value);
            }
        }

        public decimal? VariancePercentage
        {
            get
            {
                return _variancePercentage;
            }
            set
            {
                _variancePercentage = value;
                UpdateFieldValue("VariancePercentage", value);
            }
        }

        public bool? IsVarianceApproved
        {
            get
            {
                return _isVarianceApproved;
            }
            set
            {
                _isVarianceApproved = value;
                UpdateFieldValue("IsVarianceApproved", value);
            }
        }

        public DateTime? ApprovalDate
        {
            get
            {
                return _approvalDate;
            }
            set
            {
                _approvalDate = value;
                UpdateFieldValue("ApprovalDate", value);
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

        public FieldValue this[StockVarianceOvertimeDataField field]
        {
            get
            {
                return this[field.ToString()];
            }
        }
    }
}

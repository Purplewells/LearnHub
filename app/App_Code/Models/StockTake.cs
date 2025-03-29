using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using zLearnHub.Data;

namespace zLearnHub.Models
{
    public enum StockTakeDataField
    {

        StockTakeID,

        STH,

        ProductID,

        sProductName,

        StockTakeNo,

        StockTakeNumber,

        LocationName,

        SKU,

        StockTakeHeaderID,

        refProductQuantity,

        ProductName,

        SystemQuantity,

        ScannedQuantity,

        StockTakeDate,

        StockDifference,

        PercentVariance,

        IsVarianceAccepted,

        Barcode,

        LocationID,

        Notes,

        CreatedDate,

        CreatedBy,

        ModifiedDate,

        ModifiedBy,
    }

    public partial class StockTakeModel : BusinessRulesObjectModel
    {

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _stockTakeID;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _sTH;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _productID;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _sProductName;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _stockTakeNo;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _stockTakeNumber;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _locationName;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _sKU;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _stockTakeHeaderID;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _refProductQuantity;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _productName;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private decimal? _systemQuantity;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private decimal? _scannedQuantity;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private DateTime? _stockTakeDate;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private decimal? _stockDifference;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private decimal? _percentVariance;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private bool? _isVarianceAccepted;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _barcode;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _locationID;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _notes;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private DateTime? _createdDate;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _createdBy;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private DateTime? _modifiedDate;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _modifiedBy;

        public StockTakeModel()
        {
        }

        public StockTakeModel(BusinessRules r) :
                base(r)
        {
        }

        public int? StockTakeID
        {
            get
            {
                return _stockTakeID;
            }
            set
            {
                _stockTakeID = value;
                UpdateFieldValue("StockTakeID", value);
            }
        }

        public string STH
        {
            get
            {
                return _sTH;
            }
            set
            {
                _sTH = value;
                UpdateFieldValue("STH", value);
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

        public string sProductName
        {
            get
            {
                return _sProductName;
            }
            set
            {
                _sProductName = value;
                UpdateFieldValue("sProductName", value);
            }
        }

        public int? StockTakeNo
        {
            get
            {
                return _stockTakeNo;
            }
            set
            {
                _stockTakeNo = value;
                UpdateFieldValue("StockTakeNo", value);
            }
        }

        public string StockTakeNumber
        {
            get
            {
                return _stockTakeNumber;
            }
            set
            {
                _stockTakeNumber = value;
                UpdateFieldValue("StockTakeNumber", value);
            }
        }

        public string LocationName
        {
            get
            {
                return _locationName;
            }
            set
            {
                _locationName = value;
                UpdateFieldValue("LocationName", value);
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

        public int? StockTakeHeaderID
        {
            get
            {
                return _stockTakeHeaderID;
            }
            set
            {
                _stockTakeHeaderID = value;
                UpdateFieldValue("StockTakeHeaderID", value);
            }
        }

        public int? refProductQuantity
        {
            get
            {
                return _refProductQuantity;
            }
            set
            {
                _refProductQuantity = value;
                UpdateFieldValue("refProductQuantity", value);
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

        public decimal? SystemQuantity
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

        public decimal? ScannedQuantity
        {
            get
            {
                return _scannedQuantity;
            }
            set
            {
                _scannedQuantity = value;
                UpdateFieldValue("ScannedQuantity", value);
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

        public decimal? StockDifference
        {
            get
            {
                return _stockDifference;
            }
            set
            {
                _stockDifference = value;
                UpdateFieldValue("StockDifference", value);
            }
        }

        public decimal? PercentVariance
        {
            get
            {
                return _percentVariance;
            }
            set
            {
                _percentVariance = value;
                UpdateFieldValue("PercentVariance", value);
            }
        }

        public bool? IsVarianceAccepted
        {
            get
            {
                return _isVarianceAccepted;
            }
            set
            {
                _isVarianceAccepted = value;
                UpdateFieldValue("IsVarianceAccepted", value);
            }
        }

        public string Barcode
        {
            get
            {
                return _barcode;
            }
            set
            {
                _barcode = value;
                UpdateFieldValue("Barcode", value);
            }
        }

        public int? LocationID
        {
            get
            {
                return _locationID;
            }
            set
            {
                _locationID = value;
                UpdateFieldValue("LocationID", value);
            }
        }

        public string Notes
        {
            get
            {
                return _notes;
            }
            set
            {
                _notes = value;
                UpdateFieldValue("Notes", value);
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

        public FieldValue this[StockTakeDataField field]
        {
            get
            {
                return this[field.ToString()];
            }
        }
    }
}

using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using zLearnHub.Data;

namespace zLearnHub.Models
{
    public enum PurchaseOrderDetailDataField
    {

        ProductID,

        ProductName,

        ProductCategory,

        Quantity,

        UnitPrice,

        ExtendedCost,

        IsArrived,

        ArrivalDate,

        Note,

        CreatedDate,

        CreatedBy,

        ModifiedDate,

        ModifiedBy,

        PurchaseOrderID,

        TrackingNumber,

        SupplierName,
    }

    public partial class PurchaseOrderDetailModel : BusinessRulesObjectModel
    {

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _productID;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _productName;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _productCategory;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _quantity;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private decimal? _unitPrice;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private decimal? _extendedCost;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private bool? _isArrived;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private DateTime? _arrivalDate;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _note;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private DateTime? _createdDate;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _createdBy;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private DateTime? _modifiedDate;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _modifiedBy;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _purchaseOrderID;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _trackingNumber;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _supplierName;

        public PurchaseOrderDetailModel()
        {
        }

        public PurchaseOrderDetailModel(BusinessRules r) :
                base(r)
        {
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

        public string ProductCategory
        {
            get
            {
                return _productCategory;
            }
            set
            {
                _productCategory = value;
                UpdateFieldValue("ProductCategory", value);
            }
        }

        public int? Quantity
        {
            get
            {
                return _quantity;
            }
            set
            {
                _quantity = value;
                UpdateFieldValue("Quantity", value);
            }
        }

        public decimal? UnitPrice
        {
            get
            {
                return _unitPrice;
            }
            set
            {
                _unitPrice = value;
                UpdateFieldValue("UnitPrice", value);
            }
        }

        public decimal? ExtendedCost
        {
            get
            {
                return _extendedCost;
            }
            set
            {
                _extendedCost = value;
                UpdateFieldValue("ExtendedCost", value);
            }
        }

        public bool? IsArrived
        {
            get
            {
                return _isArrived;
            }
            set
            {
                _isArrived = value;
                UpdateFieldValue("IsArrived", value);
            }
        }

        public DateTime? ArrivalDate
        {
            get
            {
                return _arrivalDate;
            }
            set
            {
                _arrivalDate = value;
                UpdateFieldValue("ArrivalDate", value);
            }
        }

        public string Note
        {
            get
            {
                return _note;
            }
            set
            {
                _note = value;
                UpdateFieldValue("Note", value);
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

        public int? PurchaseOrderID
        {
            get
            {
                return _purchaseOrderID;
            }
            set
            {
                _purchaseOrderID = value;
                UpdateFieldValue("PurchaseOrderID", value);
            }
        }

        public string TrackingNumber
        {
            get
            {
                return _trackingNumber;
            }
            set
            {
                _trackingNumber = value;
                UpdateFieldValue("TrackingNumber", value);
            }
        }

        public string SupplierName
        {
            get
            {
                return _supplierName;
            }
            set
            {
                _supplierName = value;
                UpdateFieldValue("SupplierName", value);
            }
        }

        public FieldValue this[PurchaseOrderDetailDataField field]
        {
            get
            {
                return this[field.ToString()];
            }
        }
    }
}

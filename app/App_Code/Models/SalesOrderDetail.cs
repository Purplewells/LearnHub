using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using zLearnHub.Data;

namespace zLearnHub.Models
{
    public enum SalesOrderDetailDataField
    {

        OrderLineID,

        OrderID,

        OrderDate,

        OrderIssuedTo,

        OrderLineNo,

        ProductID,

        ProductName,

        SKU,

        Barcode,

        Sellable,

        Quantity,

        Discount,

        UnitPrice,

        extUnitPrice,

        ExtendedPrice,

        Note,

        CreatedDate,

        CreatedBy,

        ModifiedDate,

        ModifiedBy,
    }

    public partial class SalesOrderDetailModel : BusinessRulesObjectModel
    {

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _orderLineID;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _orderID;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private DateTime? _orderDate;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _orderIssuedTo;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _orderLineNo;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _productID;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _productName;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _sKU;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _barcode;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private bool? _sellable;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _quantity;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private decimal? _discount;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private decimal? _unitPrice;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private decimal? _extUnitPrice;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private decimal? _extendedPrice;

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

        public SalesOrderDetailModel()
        {
        }

        public SalesOrderDetailModel(BusinessRules r) :
                base(r)
        {
        }

        public int? OrderLineID
        {
            get
            {
                return _orderLineID;
            }
            set
            {
                _orderLineID = value;
                UpdateFieldValue("OrderLineID", value);
            }
        }

        public int? OrderID
        {
            get
            {
                return _orderID;
            }
            set
            {
                _orderID = value;
                UpdateFieldValue("OrderID", value);
            }
        }

        public DateTime? OrderDate
        {
            get
            {
                return _orderDate;
            }
            set
            {
                _orderDate = value;
                UpdateFieldValue("OrderDate", value);
            }
        }

        public string OrderIssuedTo
        {
            get
            {
                return _orderIssuedTo;
            }
            set
            {
                _orderIssuedTo = value;
                UpdateFieldValue("OrderIssuedTo", value);
            }
        }

        public int? OrderLineNo
        {
            get
            {
                return _orderLineNo;
            }
            set
            {
                _orderLineNo = value;
                UpdateFieldValue("OrderLineNo", value);
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

        public bool? Sellable
        {
            get
            {
                return _sellable;
            }
            set
            {
                _sellable = value;
                UpdateFieldValue("Sellable", value);
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

        public decimal? Discount
        {
            get
            {
                return _discount;
            }
            set
            {
                _discount = value;
                UpdateFieldValue("Discount", value);
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

        public decimal? extUnitPrice
        {
            get
            {
                return _extUnitPrice;
            }
            set
            {
                _extUnitPrice = value;
                UpdateFieldValue("extUnitPrice", value);
            }
        }

        public decimal? ExtendedPrice
        {
            get
            {
                return _extendedPrice;
            }
            set
            {
                _extendedPrice = value;
                UpdateFieldValue("ExtendedPrice", value);
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

        public FieldValue this[SalesOrderDetailDataField field]
        {
            get
            {
                return this[field.ToString()];
            }
        }
    }
}

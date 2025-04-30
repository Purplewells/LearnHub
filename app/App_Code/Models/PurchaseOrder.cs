using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using zLearnHub.Data;

namespace zLearnHub.Models
{
    public enum PurchaseOrderDataField
    {

        PurchaseOrderID,

        PONumber,

        SupplierID,

        SupplierName,

        OrderDate,

        ExpectedDeliveryDate,

        ActualDeliveryDate,

        FreightCharge,

        TotalAmount,

        PurchaseOrderStatusID,

        Status,

        PaymentStatusID,

        PaymentStatus,

        TrackingNumber,

        Comment,

        POHeader,

        CreatedDate,

        ModifiedDate,

        CreatedBy,

        ModifiedBy,
    }

    public partial class PurchaseOrderModel : BusinessRulesObjectModel
    {

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _purchaseOrderID;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _pONumber;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _supplierID;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _supplierName;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private DateTime? _orderDate;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private DateTime? _expectedDeliveryDate;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private DateTime? _actualDeliveryDate;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private decimal? _freightCharge;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private decimal? _totalAmount;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _purchaseOrderStatusID;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _status;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _paymentStatusID;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _paymentStatus;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _trackingNumber;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _comment;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _pOHeader;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private DateTime? _createdDate;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private DateTime? _modifiedDate;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _createdBy;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _modifiedBy;

        public PurchaseOrderModel()
        {
        }

        public PurchaseOrderModel(BusinessRules r) :
                base(r)
        {
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

        public string PONumber
        {
            get
            {
                return _pONumber;
            }
            set
            {
                _pONumber = value;
                UpdateFieldValue("PONumber", value);
            }
        }

        public int? SupplierID
        {
            get
            {
                return _supplierID;
            }
            set
            {
                _supplierID = value;
                UpdateFieldValue("SupplierID", value);
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

        public DateTime? ExpectedDeliveryDate
        {
            get
            {
                return _expectedDeliveryDate;
            }
            set
            {
                _expectedDeliveryDate = value;
                UpdateFieldValue("ExpectedDeliveryDate", value);
            }
        }

        public DateTime? ActualDeliveryDate
        {
            get
            {
                return _actualDeliveryDate;
            }
            set
            {
                _actualDeliveryDate = value;
                UpdateFieldValue("ActualDeliveryDate", value);
            }
        }

        public decimal? FreightCharge
        {
            get
            {
                return _freightCharge;
            }
            set
            {
                _freightCharge = value;
                UpdateFieldValue("FreightCharge", value);
            }
        }

        public decimal? TotalAmount
        {
            get
            {
                return _totalAmount;
            }
            set
            {
                _totalAmount = value;
                UpdateFieldValue("TotalAmount", value);
            }
        }

        public int? PurchaseOrderStatusID
        {
            get
            {
                return _purchaseOrderStatusID;
            }
            set
            {
                _purchaseOrderStatusID = value;
                UpdateFieldValue("PurchaseOrderStatusID", value);
            }
        }

        public string Status
        {
            get
            {
                return _status;
            }
            set
            {
                _status = value;
                UpdateFieldValue("Status", value);
            }
        }

        public int? PaymentStatusID
        {
            get
            {
                return _paymentStatusID;
            }
            set
            {
                _paymentStatusID = value;
                UpdateFieldValue("PaymentStatusID", value);
            }
        }

        public string PaymentStatus
        {
            get
            {
                return _paymentStatus;
            }
            set
            {
                _paymentStatus = value;
                UpdateFieldValue("PaymentStatus", value);
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

        public string Comment
        {
            get
            {
                return _comment;
            }
            set
            {
                _comment = value;
                UpdateFieldValue("Comment", value);
            }
        }

        public string POHeader
        {
            get
            {
                return _pOHeader;
            }
            set
            {
                _pOHeader = value;
                UpdateFieldValue("POHeader", value);
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

        public FieldValue this[PurchaseOrderDataField field]
        {
            get
            {
                return this[field.ToString()];
            }
        }
    }
}

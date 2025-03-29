using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using zLearnHub.Data;

namespace zLearnHub.Models
{
    public enum znStockTransactionsDataField
    {

        TransactionsID,

        TransDescription,

        ProductID,

        ProductName,

        SKUCode,

        ProductCategoryName,

        ProductSupplierName,

        TransactionDate,

        TransactionTypeID,

        TransactionType,

        TransactionTypeCode,

        SourceLocationID,

        SourceLocationName,

        ReceivingLocationID,

        ReceivingLocationName,

        TransactionStatusID,

        Status,

        Quantity,

        CreatedDate,

        ModifiedDate,

        CreatedBy,

        ModifiedBy,

        MovementModeID,

        MovementMode,
    }

    public partial class znStockTransactionsModel : BusinessRulesObjectModel
    {

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _transactionsID;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _transDescription;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _productID;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _productName;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _sKUCode;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _productCategoryName;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _productSupplierName;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private DateTime? _transactionDate;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _transactionTypeID;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _transactionType;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _transactionTypeCode;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _sourceLocationID;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _sourceLocationName;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _receivingLocationID;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _receivingLocationName;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _transactionStatusID;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _status;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _quantity;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private DateTime? _createdDate;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private DateTime? _modifiedDate;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _createdBy;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _modifiedBy;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _movementModeID;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _movementMode;

        public znStockTransactionsModel()
        {
        }

        public znStockTransactionsModel(BusinessRules r) :
                base(r)
        {
        }

        public int? TransactionsID
        {
            get
            {
                return _transactionsID;
            }
            set
            {
                _transactionsID = value;
                UpdateFieldValue("TransactionsID", value);
            }
        }

        public string TransDescription
        {
            get
            {
                return _transDescription;
            }
            set
            {
                _transDescription = value;
                UpdateFieldValue("TransDescription", value);
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

        public string SKUCode
        {
            get
            {
                return _sKUCode;
            }
            set
            {
                _sKUCode = value;
                UpdateFieldValue("SKUCode", value);
            }
        }

        public string ProductCategoryName
        {
            get
            {
                return _productCategoryName;
            }
            set
            {
                _productCategoryName = value;
                UpdateFieldValue("ProductCategoryName", value);
            }
        }

        public string ProductSupplierName
        {
            get
            {
                return _productSupplierName;
            }
            set
            {
                _productSupplierName = value;
                UpdateFieldValue("ProductSupplierName", value);
            }
        }

        public DateTime? TransactionDate
        {
            get
            {
                return _transactionDate;
            }
            set
            {
                _transactionDate = value;
                UpdateFieldValue("TransactionDate", value);
            }
        }

        public int? TransactionTypeID
        {
            get
            {
                return _transactionTypeID;
            }
            set
            {
                _transactionTypeID = value;
                UpdateFieldValue("TransactionTypeID", value);
            }
        }

        public string TransactionType
        {
            get
            {
                return _transactionType;
            }
            set
            {
                _transactionType = value;
                UpdateFieldValue("TransactionType", value);
            }
        }

        public string TransactionTypeCode
        {
            get
            {
                return _transactionTypeCode;
            }
            set
            {
                _transactionTypeCode = value;
                UpdateFieldValue("TransactionTypeCode", value);
            }
        }

        public int? SourceLocationID
        {
            get
            {
                return _sourceLocationID;
            }
            set
            {
                _sourceLocationID = value;
                UpdateFieldValue("SourceLocationID", value);
            }
        }

        public string SourceLocationName
        {
            get
            {
                return _sourceLocationName;
            }
            set
            {
                _sourceLocationName = value;
                UpdateFieldValue("SourceLocationName", value);
            }
        }

        public int? ReceivingLocationID
        {
            get
            {
                return _receivingLocationID;
            }
            set
            {
                _receivingLocationID = value;
                UpdateFieldValue("ReceivingLocationID", value);
            }
        }

        public string ReceivingLocationName
        {
            get
            {
                return _receivingLocationName;
            }
            set
            {
                _receivingLocationName = value;
                UpdateFieldValue("ReceivingLocationName", value);
            }
        }

        public int? TransactionStatusID
        {
            get
            {
                return _transactionStatusID;
            }
            set
            {
                _transactionStatusID = value;
                UpdateFieldValue("TransactionStatusID", value);
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

        public int? MovementModeID
        {
            get
            {
                return _movementModeID;
            }
            set
            {
                _movementModeID = value;
                UpdateFieldValue("MovementModeID", value);
            }
        }

        public string MovementMode
        {
            get
            {
                return _movementMode;
            }
            set
            {
                _movementMode = value;
                UpdateFieldValue("MovementMode", value);
            }
        }

        public FieldValue this[znStockTransactionsDataField field]
        {
            get
            {
                return this[field.ToString()];
            }
        }
    }
}

using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using zLearnHub.Data;

namespace zLearnHub.Models
{
    public enum fee_collection_transaction_extraDataField
    {

        TransactionID,

        TransDate,

        FeeID,

        Status,

        BillAmount,

        FeeDescription,

        AmountPaid,

        CurrentBalance,

        Description,

        FeeType,

        PersonID,

        PaymentMethodID,

        PaymentMethod,

        TransactionStatusCode,

        PaymentByID,

        PaymentRelation,

        NameOfPayee,

        CreatedDate,

        ModifiedDate,

        CreatedBy,

        ModifiedBy,

        ReceiptNo,

        Note,

        UPN,

        GL,

        Firstname,

        Lastname,

        SchoolName,

        Address,

        Fullname,

        HeaderLabel,

        TransactionTypeID,

        TransactionType,

        TransactionTypeCode,

        TransactionStatusID,

        TransactionStatus,

        DebitAccountID,

        DebitAccountName,

        CreditAccountID,

        CreditAccountName,

        HeaderInfo,

        RefundedAmount,

        RefundReason,
    }

    public partial class fee_collection_transaction_extraModel : BusinessRulesObjectModel
    {

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _transactionID;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private DateTime? _transDate;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _feeID;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _status;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private decimal? _billAmount;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _feeDescription;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private decimal? _amountPaid;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private decimal? _currentBalance;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _description;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _feeType;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _personID;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _paymentMethodID;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _paymentMethod;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _transactionStatusCode;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _paymentByID;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _paymentRelation;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _nameOfPayee;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private DateTime? _createdDate;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private DateTime? _modifiedDate;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _createdBy;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _modifiedBy;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _receiptNo;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _note;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _uPN;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _gL;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _firstname;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _lastname;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _schoolName;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _address;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _fullname;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _headerLabel;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _transactionTypeID;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _transactionType;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _transactionTypeCode;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _transactionStatusID;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _transactionStatus;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _debitAccountID;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _debitAccountName;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _creditAccountID;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _creditAccountName;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _headerInfo;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private decimal? _refundedAmount;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _refundReason;

        public fee_collection_transaction_extraModel()
        {
        }

        public fee_collection_transaction_extraModel(BusinessRules r) :
                base(r)
        {
        }

        public int? TransactionID
        {
            get
            {
                return _transactionID;
            }
            set
            {
                _transactionID = value;
                UpdateFieldValue("TransactionID", value);
            }
        }

        public DateTime? TransDate
        {
            get
            {
                return _transDate;
            }
            set
            {
                _transDate = value;
                UpdateFieldValue("TransDate", value);
            }
        }

        public int? FeeID
        {
            get
            {
                return _feeID;
            }
            set
            {
                _feeID = value;
                UpdateFieldValue("FeeID", value);
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

        public decimal? BillAmount
        {
            get
            {
                return _billAmount;
            }
            set
            {
                _billAmount = value;
                UpdateFieldValue("BillAmount", value);
            }
        }

        public string FeeDescription
        {
            get
            {
                return _feeDescription;
            }
            set
            {
                _feeDescription = value;
                UpdateFieldValue("FeeDescription", value);
            }
        }

        public decimal? AmountPaid
        {
            get
            {
                return _amountPaid;
            }
            set
            {
                _amountPaid = value;
                UpdateFieldValue("AmountPaid", value);
            }
        }

        public decimal? CurrentBalance
        {
            get
            {
                return _currentBalance;
            }
            set
            {
                _currentBalance = value;
                UpdateFieldValue("CurrentBalance", value);
            }
        }

        public string Description
        {
            get
            {
                return _description;
            }
            set
            {
                _description = value;
                UpdateFieldValue("Description", value);
            }
        }

        public string FeeType
        {
            get
            {
                return _feeType;
            }
            set
            {
                _feeType = value;
                UpdateFieldValue("FeeType", value);
            }
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

        public int? PaymentMethodID
        {
            get
            {
                return _paymentMethodID;
            }
            set
            {
                _paymentMethodID = value;
                UpdateFieldValue("PaymentMethodID", value);
            }
        }

        public string PaymentMethod
        {
            get
            {
                return _paymentMethod;
            }
            set
            {
                _paymentMethod = value;
                UpdateFieldValue("PaymentMethod", value);
            }
        }

        public string TransactionStatusCode
        {
            get
            {
                return _transactionStatusCode;
            }
            set
            {
                _transactionStatusCode = value;
                UpdateFieldValue("TransactionStatusCode", value);
            }
        }

        public int? PaymentByID
        {
            get
            {
                return _paymentByID;
            }
            set
            {
                _paymentByID = value;
                UpdateFieldValue("PaymentByID", value);
            }
        }

        public string PaymentRelation
        {
            get
            {
                return _paymentRelation;
            }
            set
            {
                _paymentRelation = value;
                UpdateFieldValue("PaymentRelation", value);
            }
        }

        public string NameOfPayee
        {
            get
            {
                return _nameOfPayee;
            }
            set
            {
                _nameOfPayee = value;
                UpdateFieldValue("NameOfPayee", value);
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

        public string ReceiptNo
        {
            get
            {
                return _receiptNo;
            }
            set
            {
                _receiptNo = value;
                UpdateFieldValue("ReceiptNo", value);
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

        public string GL
        {
            get
            {
                return _gL;
            }
            set
            {
                _gL = value;
                UpdateFieldValue("GL", value);
            }
        }

        public string Firstname
        {
            get
            {
                return _firstname;
            }
            set
            {
                _firstname = value;
                UpdateFieldValue("Firstname", value);
            }
        }

        public string Lastname
        {
            get
            {
                return _lastname;
            }
            set
            {
                _lastname = value;
                UpdateFieldValue("Lastname", value);
            }
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

        public string HeaderLabel
        {
            get
            {
                return _headerLabel;
            }
            set
            {
                _headerLabel = value;
                UpdateFieldValue("HeaderLabel", value);
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

        public string TransactionStatus
        {
            get
            {
                return _transactionStatus;
            }
            set
            {
                _transactionStatus = value;
                UpdateFieldValue("TransactionStatus", value);
            }
        }

        public int? DebitAccountID
        {
            get
            {
                return _debitAccountID;
            }
            set
            {
                _debitAccountID = value;
                UpdateFieldValue("DebitAccountID", value);
            }
        }

        public string DebitAccountName
        {
            get
            {
                return _debitAccountName;
            }
            set
            {
                _debitAccountName = value;
                UpdateFieldValue("DebitAccountName", value);
            }
        }

        public int? CreditAccountID
        {
            get
            {
                return _creditAccountID;
            }
            set
            {
                _creditAccountID = value;
                UpdateFieldValue("CreditAccountID", value);
            }
        }

        public string CreditAccountName
        {
            get
            {
                return _creditAccountName;
            }
            set
            {
                _creditAccountName = value;
                UpdateFieldValue("CreditAccountName", value);
            }
        }

        public string HeaderInfo
        {
            get
            {
                return _headerInfo;
            }
            set
            {
                _headerInfo = value;
                UpdateFieldValue("HeaderInfo", value);
            }
        }

        public decimal? RefundedAmount
        {
            get
            {
                return _refundedAmount;
            }
            set
            {
                _refundedAmount = value;
                UpdateFieldValue("RefundedAmount", value);
            }
        }

        public string RefundReason
        {
            get
            {
                return _refundReason;
            }
            set
            {
                _refundReason = value;
                UpdateFieldValue("RefundReason", value);
            }
        }

        public FieldValue this[fee_collection_transaction_extraDataField field]
        {
            get
            {
                return this[field.ToString()];
            }
        }
    }
}

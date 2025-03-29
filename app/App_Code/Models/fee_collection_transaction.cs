using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using zLearnHub.Data;

namespace zLearnHub.Models
{
    public enum fee_collection_transactionDataField
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

        RefundAmount,
    }

    public partial class fee_collection_transactionModel : BusinessRulesObjectModel
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

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private double? _refundAmount;

        public fee_collection_transactionModel()
        {
        }

        public fee_collection_transactionModel(BusinessRules r) :
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

        public double? RefundAmount
        {
            get
            {
                return _refundAmount;
            }
            set
            {
                _refundAmount = value;
                UpdateFieldValue("RefundAmount", value);
            }
        }

        public FieldValue this[fee_collection_transactionDataField field]
        {
            get
            {
                return this[field.ToString()];
            }
        }
    }

    public partial class fee_collection_transaction : fee_collection_transactionModel
    {

        public static List<zLearnHub.Models.fee_collection_transaction> Select(string filter, string sort, string dataView, params System.Object[] parameters)
        {
            return new fee_collection_transactionFactory().Select(filter, sort, dataView, new BusinessObjectParameters(parameters));
        }

        public static List<zLearnHub.Models.fee_collection_transaction> Select(string filter, string sort, params System.Object[] parameters)
        {
            return new fee_collection_transactionFactory().Select(filter, sort, fee_collection_transactionFactory.SelectView, new BusinessObjectParameters(parameters));
        }

        public static List<zLearnHub.Models.fee_collection_transaction> Select(string filter, params System.Object[] parameters)
        {
            return new fee_collection_transactionFactory().Select(filter, null, fee_collection_transactionFactory.SelectView, new BusinessObjectParameters(parameters));
        }

        public static zLearnHub.Models.fee_collection_transaction SelectSingle(string filter, params System.Object[] parameters)
        {
            return new fee_collection_transactionFactory().SelectSingle(filter, new BusinessObjectParameters(parameters));
        }

        public static zLearnHub.Models.fee_collection_transaction SelectSingle(int? transactionID)
        {
            return new fee_collection_transactionFactory().SelectSingle(transactionID);
        }

        public int Insert()
        {
            return new fee_collection_transactionFactory().Insert(this);
        }

        public int Update()
        {
            return new fee_collection_transactionFactory().Update(this);
        }

        public int Delete()
        {
            return new fee_collection_transactionFactory().Delete(this);
        }

        public override string ToString()
        {
            return string.Format("TransactionID: {0}", this.TransactionID);
        }

        public static zLearnHub.Models.fee_collection_transaction SelectSingle(object filter)
        {
            var paramList = new BusinessObjectParameters(filter);
            return SelectSingle(paramList.ToWhere(), paramList);
        }

        public static List<zLearnHub.Models.fee_collection_transaction> Select(object filter, string sort, string view)
        {
            var paramList = new BusinessObjectParameters(filter);
            return Select(paramList.ToWhere(), sort, view, paramList);
        }

        public static List<zLearnHub.Models.fee_collection_transaction> Select(object filter, string sort)
        {
            return Select(filter, sort, null);
        }

        public static List<zLearnHub.Models.fee_collection_transaction> Select(object filter)
        {
            return Select(filter, null);
        }

        public static zLearnHub.Models.fee_collection_transaction Insert(object initializer)
        {
            var instance = CreateInstance<zLearnHub.Models.fee_collection_transaction>(initializer);
            if (instance.Insert() == 0)
                return null;
            return instance;
        }

        public static List<zLearnHub.Models.fee_collection_transaction> SelectAll()
        {
            return SelectAll(null);
        }

        public static List<zLearnHub.Models.fee_collection_transaction> SelectAll(string sort)
        {
            return new zLearnHub.Models.fee_collection_transactionFactory().Select(null, sort, zLearnHub.Models.fee_collection_transactionFactory.SelectView, new BusinessObjectParameters());
        }
    }

    public partial class fee_collection_transactionFactory
    {

        public fee_collection_transactionFactory()
        {
        }

        public static string SelectView
        {
            get
            {
                return Controller.GetSelectView("fee_collection_transaction");
            }
        }

        public static string InsertView
        {
            get
            {
                return Controller.GetInsertView("fee_collection_transaction");
            }
        }

        public static string UpdateView
        {
            get
            {
                return Controller.GetUpdateView("fee_collection_transaction");
            }
        }

        public static string DeleteView
        {
            get
            {
                return Controller.GetDeleteView("fee_collection_transaction");
            }
        }

        public static fee_collection_transactionFactory Create()
        {
            return new fee_collection_transactionFactory();
        }

        public List<zLearnHub.Models.fee_collection_transaction> Select(string filter, BusinessObjectParameters parameters)
        {
            return Select(filter, null, SelectView, parameters);
        }

        public List<zLearnHub.Models.fee_collection_transaction> SelectSingle(string filter, string sort, BusinessObjectParameters parameters)
        {
            return Select(filter, sort, SelectView, parameters);
        }

        public List<zLearnHub.Models.fee_collection_transaction> Select(string filter, string sort, string dataView, BusinessObjectParameters parameters)
        {
            var request = new PageRequest(0, Int32.MaxValue, sort, new string[0])
            {
                RequiresMetaData = true,
                MetadataFilter = new string[] {
                    "fields"}
            };
            var c = ControllerFactory.CreateDataController();
            var bo = ((IBusinessObject)(c));
            bo.AssignFilter(filter, parameters);
            var page = c.GetPage("fee_collection_transaction", dataView, request);
            return page.ToList<zLearnHub.Models.fee_collection_transaction>();
        }

        public zLearnHub.Models.fee_collection_transaction SelectSingle(int? transactionID)
        {
            var parameterMarker = SqlStatement.GetParameterMarker(string.Empty);
            var paramValues = new BusinessObjectParameters();
            paramValues[(parameterMarker + "objpk0")] = transactionID;
            return SelectSingle(string.Format("TransactionID={0}objpk0", parameterMarker), paramValues);
        }

        public zLearnHub.Models.fee_collection_transaction SelectSingle(string filter, BusinessObjectParameters parameters)
        {
            var list = Select(filter, parameters);
            if (list.Count > 0)
                return list[0];
            return null;
        }

        protected virtual FieldValue[] CreateFieldValues(zLearnHub.Models.fee_collection_transaction thefee_collection_transaction, zLearnHub.Models.fee_collection_transaction original_fee_collection_transaction)
        {
            var values = new List<FieldValue>();
            values.Add(new FieldValue("TransactionID", original_fee_collection_transaction.TransactionID, thefee_collection_transaction.TransactionID, true));
            values.Add(new FieldValue("TransDate", original_fee_collection_transaction.TransDate, thefee_collection_transaction.TransDate));
            values.Add(new FieldValue("FeeID", original_fee_collection_transaction.FeeID, thefee_collection_transaction.FeeID));
            values.Add(new FieldValue("Status", original_fee_collection_transaction.Status, thefee_collection_transaction.Status, true));
            values.Add(new FieldValue("BillAmount", original_fee_collection_transaction.BillAmount, thefee_collection_transaction.BillAmount, true));
            values.Add(new FieldValue("FeeDescription", original_fee_collection_transaction.FeeDescription, thefee_collection_transaction.FeeDescription, true));
            values.Add(new FieldValue("AmountPaid", original_fee_collection_transaction.AmountPaid, thefee_collection_transaction.AmountPaid));
            values.Add(new FieldValue("CurrentBalance", original_fee_collection_transaction.CurrentBalance, thefee_collection_transaction.CurrentBalance));
            values.Add(new FieldValue("Description", original_fee_collection_transaction.Description, thefee_collection_transaction.Description));
            values.Add(new FieldValue("FeeType", original_fee_collection_transaction.FeeType, thefee_collection_transaction.FeeType));
            values.Add(new FieldValue("PersonID", original_fee_collection_transaction.PersonID, thefee_collection_transaction.PersonID));
            values.Add(new FieldValue("PaymentMethodID", original_fee_collection_transaction.PaymentMethodID, thefee_collection_transaction.PaymentMethodID));
            values.Add(new FieldValue("PaymentMethod", original_fee_collection_transaction.PaymentMethod, thefee_collection_transaction.PaymentMethod, true));
            values.Add(new FieldValue("TransactionStatusCode", original_fee_collection_transaction.TransactionStatusCode, thefee_collection_transaction.TransactionStatusCode));
            values.Add(new FieldValue("PaymentByID", original_fee_collection_transaction.PaymentByID, thefee_collection_transaction.PaymentByID));
            values.Add(new FieldValue("PaymentRelation", original_fee_collection_transaction.PaymentRelation, thefee_collection_transaction.PaymentRelation, true));
            values.Add(new FieldValue("NameOfPayee", original_fee_collection_transaction.NameOfPayee, thefee_collection_transaction.NameOfPayee));
            values.Add(new FieldValue("CreatedDate", original_fee_collection_transaction.CreatedDate, thefee_collection_transaction.CreatedDate));
            values.Add(new FieldValue("ModifiedDate", original_fee_collection_transaction.ModifiedDate, thefee_collection_transaction.ModifiedDate));
            values.Add(new FieldValue("CreatedBy", original_fee_collection_transaction.CreatedBy, thefee_collection_transaction.CreatedBy));
            values.Add(new FieldValue("ModifiedBy", original_fee_collection_transaction.ModifiedBy, thefee_collection_transaction.ModifiedBy));
            values.Add(new FieldValue("ReceiptNo", original_fee_collection_transaction.ReceiptNo, thefee_collection_transaction.ReceiptNo));
            values.Add(new FieldValue("Note", original_fee_collection_transaction.Note, thefee_collection_transaction.Note));
            values.Add(new FieldValue("UPN", original_fee_collection_transaction.UPN, thefee_collection_transaction.UPN, true));
            values.Add(new FieldValue("GL", original_fee_collection_transaction.GL, thefee_collection_transaction.GL, true));
            values.Add(new FieldValue("Firstname", original_fee_collection_transaction.Firstname, thefee_collection_transaction.Firstname, true));
            values.Add(new FieldValue("Lastname", original_fee_collection_transaction.Lastname, thefee_collection_transaction.Lastname, true));
            values.Add(new FieldValue("SchoolName", original_fee_collection_transaction.SchoolName, thefee_collection_transaction.SchoolName, true));
            values.Add(new FieldValue("Address", original_fee_collection_transaction.Address, thefee_collection_transaction.Address, true));
            values.Add(new FieldValue("Fullname", original_fee_collection_transaction.Fullname, thefee_collection_transaction.Fullname, true));
            values.Add(new FieldValue("HeaderLabel", original_fee_collection_transaction.HeaderLabel, thefee_collection_transaction.HeaderLabel, true));
            values.Add(new FieldValue("TransactionTypeID", original_fee_collection_transaction.TransactionTypeID, thefee_collection_transaction.TransactionTypeID));
            values.Add(new FieldValue("TransactionType", original_fee_collection_transaction.TransactionType, thefee_collection_transaction.TransactionType, true));
            values.Add(new FieldValue("TransactionTypeCode", original_fee_collection_transaction.TransactionTypeCode, thefee_collection_transaction.TransactionTypeCode, true));
            values.Add(new FieldValue("TransactionStatusID", original_fee_collection_transaction.TransactionStatusID, thefee_collection_transaction.TransactionStatusID));
            values.Add(new FieldValue("TransactionStatus", original_fee_collection_transaction.TransactionStatus, thefee_collection_transaction.TransactionStatus, true));
            values.Add(new FieldValue("DebitAccountID", original_fee_collection_transaction.DebitAccountID, thefee_collection_transaction.DebitAccountID));
            values.Add(new FieldValue("DebitAccountName", original_fee_collection_transaction.DebitAccountName, thefee_collection_transaction.DebitAccountName, true));
            values.Add(new FieldValue("CreditAccountID", original_fee_collection_transaction.CreditAccountID, thefee_collection_transaction.CreditAccountID));
            values.Add(new FieldValue("CreditAccountName", original_fee_collection_transaction.CreditAccountName, thefee_collection_transaction.CreditAccountName, true));
            values.Add(new FieldValue("HeaderInfo", original_fee_collection_transaction.HeaderInfo, thefee_collection_transaction.HeaderInfo, true));
            values.Add(new FieldValue("RefundedAmount", original_fee_collection_transaction.RefundedAmount, thefee_collection_transaction.RefundedAmount));
            values.Add(new FieldValue("RefundReason", original_fee_collection_transaction.RefundReason, thefee_collection_transaction.RefundReason));
            values.Add(new FieldValue("RefundAmount", original_fee_collection_transaction.RefundAmount, thefee_collection_transaction.RefundAmount));
            return values.ToArray();
        }

        protected virtual int ExecuteAction(zLearnHub.Models.fee_collection_transaction thefee_collection_transaction, zLearnHub.Models.fee_collection_transaction original_fee_collection_transaction, string lastCommandName, string commandName, string dataView)
        {
            var args = new ActionArgs()
            {
                Controller = "fee_collection_transaction",
                View = dataView,
                Values = CreateFieldValues(thefee_collection_transaction, original_fee_collection_transaction),
                LastCommandName = lastCommandName,
                CommandName = commandName
            };
            var result = ControllerFactory.CreateDataController().Execute("fee_collection_transaction", dataView, args);
            result.RaiseExceptionIfErrors();
            result.AssignTo(thefee_collection_transaction);
            return result.RowsAffected;
        }

        public virtual int Update(zLearnHub.Models.fee_collection_transaction thefee_collection_transaction, zLearnHub.Models.fee_collection_transaction original_fee_collection_transaction)
        {
            return ExecuteAction(thefee_collection_transaction, original_fee_collection_transaction, "Edit", "Update", UpdateView);
        }

        public virtual int Update(zLearnHub.Models.fee_collection_transaction thefee_collection_transaction)
        {
            return Update(thefee_collection_transaction, SelectSingle(thefee_collection_transaction.TransactionID));
        }

        public virtual int Insert(zLearnHub.Models.fee_collection_transaction thefee_collection_transaction)
        {
            return ExecuteAction(thefee_collection_transaction, new fee_collection_transaction(), "New", "Insert", InsertView);
        }

        public virtual int Delete(zLearnHub.Models.fee_collection_transaction thefee_collection_transaction)
        {
            return ExecuteAction(thefee_collection_transaction, thefee_collection_transaction, "Select", "Delete", DeleteView);
        }
    }
}

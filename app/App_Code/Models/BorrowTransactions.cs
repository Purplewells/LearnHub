using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using zLearnHub.Data;

namespace zLearnHub.Models
{
    public enum BorrowTransactionsDataField
    {

        TransactionID,

        BookID,

        BookTitle,

        BookAuthor,

        MemberID,

        MemberName,

        BorrowDate,

        DueDate,

        ReturnDate,

        CreatedDate,

        ModifiedDate,

        CreatedBy,

        ModifiedBy,
    }

    public partial class BorrowTransactionsModel : BusinessRulesObjectModel
    {

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _transactionID;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _bookID;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _bookTitle;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _bookAuthor;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _memberID;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _memberName;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private DateTime? _borrowDate;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private DateTime? _dueDate;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private DateTime? _returnDate;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private DateTime? _createdDate;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private DateTime? _modifiedDate;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _createdBy;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _modifiedBy;

        public BorrowTransactionsModel()
        {
        }

        public BorrowTransactionsModel(BusinessRules r) :
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

        public int? BookID
        {
            get
            {
                return _bookID;
            }
            set
            {
                _bookID = value;
                UpdateFieldValue("BookID", value);
            }
        }

        public string BookTitle
        {
            get
            {
                return _bookTitle;
            }
            set
            {
                _bookTitle = value;
                UpdateFieldValue("BookTitle", value);
            }
        }

        public string BookAuthor
        {
            get
            {
                return _bookAuthor;
            }
            set
            {
                _bookAuthor = value;
                UpdateFieldValue("BookAuthor", value);
            }
        }

        public int? MemberID
        {
            get
            {
                return _memberID;
            }
            set
            {
                _memberID = value;
                UpdateFieldValue("MemberID", value);
            }
        }

        public string MemberName
        {
            get
            {
                return _memberName;
            }
            set
            {
                _memberName = value;
                UpdateFieldValue("MemberName", value);
            }
        }

        public DateTime? BorrowDate
        {
            get
            {
                return _borrowDate;
            }
            set
            {
                _borrowDate = value;
                UpdateFieldValue("BorrowDate", value);
            }
        }

        public DateTime? DueDate
        {
            get
            {
                return _dueDate;
            }
            set
            {
                _dueDate = value;
                UpdateFieldValue("DueDate", value);
            }
        }

        public DateTime? ReturnDate
        {
            get
            {
                return _returnDate;
            }
            set
            {
                _returnDate = value;
                UpdateFieldValue("ReturnDate", value);
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

        public FieldValue this[BorrowTransactionsDataField field]
        {
            get
            {
                return this[field.ToString()];
            }
        }
    }
}

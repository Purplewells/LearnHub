using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using zLearnHub.Data;

namespace zLearnHub.Models
{
    public enum ManualAccountJournalEntriesDataField
    {

        JournalEntryID,

        TransactionDate,

        DebitAccountID,

        DebitAccountName,

        DebitAccountType,

        CreditAccountID,

        CreditAccountName,

        CreditAccountType,

        Amount,

        Description,

        Note,

        EnteredBy,

        CreatedDate,

        ModifiedDate,

        CreatedBy,

        ModifiedBy,
    }

    public partial class ManualAccountJournalEntriesModel : BusinessRulesObjectModel
    {

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _journalEntryID;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private DateTime? _transactionDate;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _debitAccountID;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _debitAccountName;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _debitAccountType;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _creditAccountID;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _creditAccountName;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _creditAccountType;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private decimal? _amount;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _description;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _note;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _enteredBy;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private DateTime? _createdDate;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private DateTime? _modifiedDate;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _createdBy;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _modifiedBy;

        public ManualAccountJournalEntriesModel()
        {
        }

        public ManualAccountJournalEntriesModel(BusinessRules r) :
                base(r)
        {
        }

        public int? JournalEntryID
        {
            get
            {
                return _journalEntryID;
            }
            set
            {
                _journalEntryID = value;
                UpdateFieldValue("JournalEntryID", value);
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

        public string DebitAccountType
        {
            get
            {
                return _debitAccountType;
            }
            set
            {
                _debitAccountType = value;
                UpdateFieldValue("DebitAccountType", value);
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

        public string CreditAccountType
        {
            get
            {
                return _creditAccountType;
            }
            set
            {
                _creditAccountType = value;
                UpdateFieldValue("CreditAccountType", value);
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

        public string EnteredBy
        {
            get
            {
                return _enteredBy;
            }
            set
            {
                _enteredBy = value;
                UpdateFieldValue("EnteredBy", value);
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

        public FieldValue this[ManualAccountJournalEntriesDataField field]
        {
            get
            {
                return this[field.ToString()];
            }
        }
    }
}

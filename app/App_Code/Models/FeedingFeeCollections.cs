using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using zLearnHub.Data;

namespace zLearnHub.Models
{
    public enum FeedingFeeCollectionsDataField
    {

        PaymentID,

        Personid,

        Firstname,

        Lastname,

        UPN,

        GL,

        MealPlanID,

        MealPlanName,

        MealPlanCode,

        MealPrice,

        NumberOfDays,

        AmountPaid,

        Curr,

        PaidDate,

        ServiceStartDate,

        ServiceEndDate,

        CreatedDate,

        ModifiedDate,

        CreatedBy,

        ModifiedBy,

        Status,

        ServiceStatus,
    }

    public partial class FeedingFeeCollectionsModel : BusinessRulesObjectModel
    {

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _paymentID;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _personid;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _firstname;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _lastname;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _uPN;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _gL;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _mealPlanID;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _mealPlanName;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _mealPlanCode;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private decimal? _mealPrice;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _numberOfDays;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private decimal? _amountPaid;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _curr;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private DateTime? _paidDate;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private DateTime? _serviceStartDate;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private DateTime? _serviceEndDate;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private DateTime? _createdDate;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private DateTime? _modifiedDate;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _createdBy;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _modifiedBy;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _status;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private bool? _serviceStatus;

        public FeedingFeeCollectionsModel()
        {
        }

        public FeedingFeeCollectionsModel(BusinessRules r) :
                base(r)
        {
        }

        public int? PaymentID
        {
            get
            {
                return _paymentID;
            }
            set
            {
                _paymentID = value;
                UpdateFieldValue("PaymentID", value);
            }
        }

        public int? Personid
        {
            get
            {
                return _personid;
            }
            set
            {
                _personid = value;
                UpdateFieldValue("Personid", value);
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

        public int? MealPlanID
        {
            get
            {
                return _mealPlanID;
            }
            set
            {
                _mealPlanID = value;
                UpdateFieldValue("MealPlanID", value);
            }
        }

        public string MealPlanName
        {
            get
            {
                return _mealPlanName;
            }
            set
            {
                _mealPlanName = value;
                UpdateFieldValue("MealPlanName", value);
            }
        }

        public string MealPlanCode
        {
            get
            {
                return _mealPlanCode;
            }
            set
            {
                _mealPlanCode = value;
                UpdateFieldValue("MealPlanCode", value);
            }
        }

        public decimal? MealPrice
        {
            get
            {
                return _mealPrice;
            }
            set
            {
                _mealPrice = value;
                UpdateFieldValue("MealPrice", value);
            }
        }

        public int? NumberOfDays
        {
            get
            {
                return _numberOfDays;
            }
            set
            {
                _numberOfDays = value;
                UpdateFieldValue("NumberOfDays", value);
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

        public string Curr
        {
            get
            {
                return _curr;
            }
            set
            {
                _curr = value;
                UpdateFieldValue("Curr", value);
            }
        }

        public DateTime? PaidDate
        {
            get
            {
                return _paidDate;
            }
            set
            {
                _paidDate = value;
                UpdateFieldValue("PaidDate", value);
            }
        }

        public DateTime? ServiceStartDate
        {
            get
            {
                return _serviceStartDate;
            }
            set
            {
                _serviceStartDate = value;
                UpdateFieldValue("ServiceStartDate", value);
            }
        }

        public DateTime? ServiceEndDate
        {
            get
            {
                return _serviceEndDate;
            }
            set
            {
                _serviceEndDate = value;
                UpdateFieldValue("ServiceEndDate", value);
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

        public bool? ServiceStatus
        {
            get
            {
                return _serviceStatus;
            }
            set
            {
                _serviceStatus = value;
                UpdateFieldValue("ServiceStatus", value);
            }
        }

        public FieldValue this[FeedingFeeCollectionsDataField field]
        {
            get
            {
                return this[field.ToString()];
            }
        }
    }
}

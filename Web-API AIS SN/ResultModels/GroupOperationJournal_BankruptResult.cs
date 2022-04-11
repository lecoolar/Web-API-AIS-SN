using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Web_API_AIS_SN.ResultModels
{
    public class GroupOperationJournal_BankruptResult
    {
        public long Id { get; set; }

        public long UserId { get; set; }

        public int TypeId { get; set; }

        public System.Nullable<int> SubTypeId { get; set; }

        public System.Nullable<long>DocId { get; set; }

        public string Comment { get; set; }

        public string FromDate { get; set; }

        public string ToDate { get; set; }

        public string Created { get; set; }

        public System.Nullable<long> OldId { get; set; }

        public System.Nullable<long> CalcId { get; set; }

        public System.Nullable<long> AccountId { get; set; }

        public System.Nullable<long> PaymentAgentId { get; set; }

        public System.Nullable<long> TransactionNumber { get; set; }

        public string TransactionDate { get; set; }

        public string ReesterNumber { get; set; }

        public string ReesterDate { get; set; }

        public string Terminal { get; set; }

        public string IncomingTransferDate { get; set; }

        public string IncomingTransferNumber { get; set; }

        public string IncomingTransferPack { get; set; }

        public string OperatorName { get; set; }

        public string Login_name { get; set; }

        public string UserName { get; set; }

        public string TypeName { get; set; }

        public string PaymentAgentName { get; set; }

        public string SubTypeName { get; set; }

        public string DocName { get; set; }

        public string DocNumber { get; set; }

        public string DocDate { get; set; }

        public string TypeDocName { get; set; }

        public string OrgName { get; set; }

        public System.Nullable<int> OrgCode { get; set; }

        public System.Nullable<decimal> Summ { get; set; }

        public System.Nullable<int> AccountsCount { get; set; }

        public System.Nullable<decimal> PaymentSumm { get; set; }

        public System.Nullable<bool> UsePaymentDate { get; set; }

        public System.Nullable<bool> IsUseRecalc { get; set; }

        public System.Nullable<int> RequestSubService { get; set; }

        public string RequestSubServiceName { get; set; }

        public string RequestServiceCode { get; set; }

        public System.Nullable<bool> IsProcessedByHand { get; set; }

        public System.Nullable<decimal> ArrivalBankAccount { get; set; }

        public System.Nullable<long> ArrivalBankAccountId { get; set; }

        public string ReesterRecordDate { get; set; }

        public string PenaltyDate { get; set; }

        public System.Nullable<long> PaymentOrderId { get; set; }

        public System.Nullable<long> BankPaymentOrderId { get; set; }

        public string BankPaymentOrderDate { get; set; }
    }
}

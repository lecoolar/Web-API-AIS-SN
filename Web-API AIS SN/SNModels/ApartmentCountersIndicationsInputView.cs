using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class ApartmentCountersIndicationsInputView
    {
        public long Id { get; set; }
        public long ApartmentId { get; set; }
        public long CounterId { get; set; }
        public string CounterName { get; set; }
        public string CounterTypeName { get; set; }
        public string CounterNumber { get; set; }
        public string TypeScaleCounterName { get; set; }
        public string PointAccounting { get; set; }
        public decimal Val { get; set; }
        public DateTime ValDate { get; set; }
        public string ValTypeName { get; set; }
        public string CounterServiceTypeName { get; set; }
        public long? SessionId { get; set; }
        public long? UserId { get; set; }
        public string UserName { get; set; }
        public DateTime CounterFromDate { get; set; }
        public DateTime? CounterToDate { get; set; }
        public DateTime Created { get; set; }
        public string Comment { get; set; }
        public int? NewValTypeId { get; set; }
        public string NewValType { get; set; }
        public DateTime NewValDate { get; set; }
        public long? CounterServiceTypeId { get; set; }
        public string ServiceTypeAlias { get; set; }
        public string City { get; set; }
        public string Street { get; set; }
        public string House { get; set; }
        public string Flat { get; set; }
        public string AccountNumber { get; set; }
        public int CounterSize { get; set; }
        public long? InvoiceNumber { get; set; }
        public decimal? Consumption { get; set; }
        public bool? IsSaveDuplicateIndication { get; set; }
        public long? Pack { get; set; }
        public int? MethodValInsert { get; set; }
        public string MethodValInsertName { get; set; }
        public string CounterNumberAismeter { get; set; }
    }
}

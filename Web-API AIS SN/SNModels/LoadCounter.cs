using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class LoadCounter
    {
        public long Id { get; set; }
        public long? ProcessingId { get; set; }
        public int? StatusId { get; set; }
        public long? BillId { get; set; }
        public DateTime? CalcPeriod { get; set; }
        public DateTime? UnloadDate { get; set; }
        public string Number { get; set; }
        public string ServiceCode { get; set; }
        public string OrgCode { get; set; }
        public string CounterNumb { get; set; }
        public string PrevVal { get; set; }
        public string Val { get; set; }
        public string EdIzm { get; set; }
        public string Volime { get; set; }
        public string NormOne { get; set; }
        public string Razr { get; set; }
        public string ConsKtu { get; set; }
        public string Valdate { get; set; }
        public string Datee { get; set; }
        public string TypeTu { get; set; }
        public string AreaRecOdn { get; set; }
        public string ConsOdnktu { get; set; }
        public long? IdCounterInBill { get; set; }
        public string IsNewCounter { get; set; }
        public string StatusCounter { get; set; }
        public string SourceVal { get; set; }
        public string Dateb { get; set; }
        public string CounterMark { get; set; }
        public string DateInstallCounter { get; set; }
        public string CountTarif { get; set; }
        public string ZoneTarif { get; set; }
        public string CounterType { get; set; }
        public string DateLastVerify { get; set; }
        public string IsRemoteControl { get; set; }
        public string NameSystemRemote { get; set; }
        public string HaveSensHate { get; set; }
        public string HaveSensPresure { get; set; }
        public long? CounterId { get; set; }
        public string Comment { get; set; }
        public string Error { get; set; }
        public long? ExtRecordId { get; set; }
        public string PrevIndicationValDate { get; set; }
        public string TransformationCoeff { get; set; }
        public string CounterName { get; set; }
        public string ValFromDay { get; set; }
        public string ValFromNight { get; set; }
        public string ValFromPik { get; set; }
        public string ValFromHalfPik { get; set; }
        public string ValToDay { get; set; }
        public string ValToNight { get; set; }
        public string ValToPik { get; set; }
        public string ValToHalfPik { get; set; }
    }
}

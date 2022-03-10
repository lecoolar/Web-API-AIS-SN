using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class LoadCharge
    {
        public long Id { get; set; }
        public long? ProcessingId { get; set; }
        public int? StatysId { get; set; }
        public long? BillId { get; set; }
        public DateTime? CalcPeriod { get; set; }
        public DateTime? UnloadDate { get; set; }
        public string Number { get; set; }
        public string ProvNumber { get; set; }
        public string ServiceCode { get; set; }
        public string OrgCode { get; set; }
        public string MeasUnit { get; set; }
        public string TarifRate { get; set; }
        public string NormRate { get; set; }
        public string ConsService { get; set; }
        public string ConsServiceOdn { get; set; }
        public string SizePayServiceCons { get; set; }
        public string SizePayServiceConsOdn { get; set; }
        public string Recalc { get; set; }
        public string Benefit { get; set; }
        public string ChargeItogPeriod { get; set; }
        public string ChargeItogPeriodOdn { get; set; }
        public string SaldoBegin { get; set; }
        public string PenyCurrPeriod { get; set; }
        public string StampDuty { get; set; }
        public string PayCurrPeriod { get; set; }
        public string SaldoEnd { get; set; }
        public string RecalcReason { get; set; }
        public string ChargeType { get; set; }
        public string LastDateIncludePay { get; set; }
        public string DebtPenyBegin { get; set; }
        public string SummChargeDeffPeriod { get; set; }
        public string SummChargeDeffOldPeriod { get; set; }
        public string SummDeffPercent { get; set; }
        public string PercentDeff { get; set; }
        public string SummChargeInclDeffPerc { get; set; }
        public string SaldoEndNoPeny { get; set; }
        public string SignRecalc { get; set; }
        public string SingServActivity { get; set; }
        public string ChargeItogProvPeriod { get; set; }
        public string ChargeItogProvPeriodOdn { get; set; }
        public string IdAbBalance { get; set; }
        public string SignControlMkd { get; set; }
        public string DateLastPay { get; set; }
        public string SummLastPay { get; set; }
        public string RecalcProvider { get; set; }
        public string SaldoBegProvider { get; set; }
        public string CurrPeriodPenyProvider { get; set; }
        public string CurrPeriodPayProvider { get; set; }
        public string SaldoEndProvider { get; set; }
        public string ValueUpCoeff { get; set; }
        public string SummUpCoeff { get; set; }
        public string CodeSrvPrime { get; set; }
        public long? Accountid { get; set; }
        public long? Serviceid { get; set; }
        public long? Accountserviceid { get; set; }
        public string Comment { get; set; }
        public string Error { get; set; }
        public long? ExtRecordId { get; set; }
        public string ElectroBuyTariff { get; set; }
        public string ElectroSellTariff { get; set; }
        public string OtherServiceTariff { get; set; }
        public string Charge { get; set; }
        public string ElectroTarrifDay { get; set; }
        public string ElectroTarrifNight { get; set; }
        public string ElectroTarrifPik { get; set; }
        public string ElectroTarrifHalfPik { get; set; }
        public string ElectroTarrifDayOdn { get; set; }
        public string ElectroTarrifNightOdn { get; set; }
        public string SaldoPeny { get; set; }
        public string SaldoEndPeny { get; set; }
        public string PenyRecalc { get; set; }
        public string PenyPay { get; set; }
        public string SumCalcAll { get; set; }
        public string SumCalcDay { get; set; }
        public string SumCalcNight { get; set; }
        public string SumCalcHalfPik { get; set; }
        public string SumCalcPik { get; set; }
        public string SumCalcKeep { get; set; }
        public string SumCalcKeepOdn { get; set; }
        public string ConsDay { get; set; }
        public string ConsNight { get; set; }
        public string ConsHalfPik { get; set; }
        public string ConsPik { get; set; }
        public string ConsKeep { get; set; }
        public string RecalcDateBegin { get; set; }
        public string RecalcDateEnd { get; set; }
        public string RecalcOdndateBegin { get; set; }
        public string RecalcOdndateEnd { get; set; }
        public string RecalcOdn { get; set; }
        public string RecalcReasonOdn { get; set; }
    }
}

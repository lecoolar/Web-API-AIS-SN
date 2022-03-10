using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class NoticeHeader
    {
        public long Id { get; set; }
        public long AccountId { get; set; }
        public DateTime FromDate { get; set; }
        public long NoticeTemplateSettingId { get; set; }
        public long NoticeId { get; set; }
        public string Period { get; set; }
        public string HouseHolderName { get; set; }
        public string RicName { get; set; }
        public string AccountNumber { get; set; }
        public string OwnerName { get; set; }
        public string AddressNameCityDistrict { get; set; }
        public string ApartmentType { get; set; }
        public string ApartmentSquare { get; set; }
        public string ResidentsCount { get; set; }
        public decimal? HouseAreaTotal { get; set; }
        public decimal? HouseAreaLiving { get; set; }
        public decimal? HouseAreaFloor { get; set; }
        public string DateLastPaymentNotice { get; set; }
        public DateTime? PaymentTo { get; set; }
        public decimal? DebtSumm { get; set; }
        public decimal? NegativeSumm { get; set; }
        public decimal? SaldoPeny { get; set; }
        public decimal? FinalChargeSumm { get; set; }
        public decimal? PaymentSumm { get; set; }
        public decimal? ToPaySumm { get; set; }
        public string AddressName { get; set; }
    }
}

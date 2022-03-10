using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class AccountServiceSuspensionView
    {
        public long Id { get; set; }
        public long AccountServiceId { get; set; }
        public long? GroupOperId { get; set; }
        public DateTime FromDate { get; set; }
        public DateTime? ToDate { get; set; }
        public int? TypeSuspension { get; set; }
        public string TypeSuspensionName { get; set; }
        public decimal? SquareAffected { get; set; }
        public string Notice { get; set; }
        public decimal PercentAffected { get; set; }
        public DateTime Created { get; set; }
        public long AccountId { get; set; }
        public long ServiceId { get; set; }
    }
}

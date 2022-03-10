using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class AccountServiceSubQuality
    {
        public long Id { get; set; }
        public long AccountServiceId { get; set; }
        public long StsqpId { get; set; }
        public long? StsqadId { get; set; }
        public decimal? SquareRooms { get; set; }
        public decimal? NightTemperature { get; set; }
        public decimal? DayTemperature { get; set; }
        public decimal? PressureDeviation { get; set; }
        public int? ReasonId { get; set; }
        public bool? ExceptAcceptableDuration { get; set; }
        public DateTime? FromDate { get; set; }
        public DateTime? ToDate { get; set; }
        public DateTime? Created { get; set; }
        public long GroupOperId { get; set; }
        public int? CalcTypeId { get; set; }

        public virtual AccountService4 AccountService { get; set; }
        public virtual FasetItem CalcType { get; set; }
        public virtual GroupOperation GroupOper { get; set; }
        public virtual ServiceTypeSubQualityAcceptableDuration Stsqad { get; set; }
        public virtual ServiceTypeSubQualityPercent Stsqp { get; set; }
    }
}

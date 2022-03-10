using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class HouseTreatyCommitmentsWithPeriodsView
    {
        public long? Id { get; set; }
        public DateTime Period { get; set; }
        public DateTime Created { get; set; }
        public long HouseId { get; set; }
        public long? ServiceId { get; set; }
        public decimal? CostsExecutor { get; set; }
        public int ServiceCode { get; set; }
        public string ServiceName { get; set; }
        public string ServiceTypeName { get; set; }
        public decimal? ServiceNormRate { get; set; }
        public decimal? HouseTotalArea { get; set; }
        public long HouseAdrId { get; set; }
        public DateTime? PeriodMonth { get; set; }
    }
}

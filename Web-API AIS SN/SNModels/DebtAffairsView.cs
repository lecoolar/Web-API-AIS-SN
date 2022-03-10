using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class DebtAffairsView
    {
        public long Id { get; set; }
        public string Comment { get; set; }
        public DateTime FromDate { get; set; }
        public DateTime? ToDate { get; set; }
        public DateTime Created { get; set; }
        public int? CategoryId { get; set; }
        public string CategoryName { get; set; }
        public string OwnerName { get; set; }
        public string AddressName { get; set; }
        public string HouseHolderName { get; set; }
        public string OrgDocumentName { get; set; }
        public int? CountActions { get; set; }
        public decimal? DebtSumm { get; set; }
        public int MonthCount { get; set; }
        public string ScanPath { get; set; }
        public string DebtAffairNumber { get; set; }
        public long? AccountId { get; set; }
    }
}

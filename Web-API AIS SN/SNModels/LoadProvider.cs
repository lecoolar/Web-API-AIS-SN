using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class LoadProvider
    {
        public long Id { get; set; }
        public long? ProcessingId { get; set; }
        public int? StatusId { get; set; }
        public long? BillId { get; set; }
        public DateTime? CalcPeriod { get; set; }
        public DateTime? UnloadDate { get; set; }
        public string OrgCode { get; set; }
        public string OrgName { get; set; }
        public string AddrInfo { get; set; }
        public string Telephone { get; set; }
        public string AddrWeb { get; set; }
        public string Ogrn { get; set; }
        public string Inn { get; set; }
        public string Kpp { get; set; }
        public string RAccount { get; set; }
        public string KAccount { get; set; }
        public string Bik { get; set; }
        public string OrgLegalFormUl { get; set; }
        public string AddrReal { get; set; }
        public string RegDate { get; set; }
        public string OrgType { get; set; }
        public long? OrgId { get; set; }
        public string Comment { get; set; }
        public string Error { get; set; }
        public long? ExtRecordId { get; set; }
    }
}

using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class ServiceCommissionsView
    {
        public long Id { get; set; }
        public long ServiceId { get; set; }
        public decimal Commission { get; set; }
        public long? DocId { get; set; }
        public string OrgDocumentName { get; set; }
        public DateTime Datec { get; set; }
        public DateTime Dateb { get; set; }
        public DateTime? Datee { get; set; }
        public int ServiceCode { get; set; }
        public string ServiceName { get; set; }
    }
}

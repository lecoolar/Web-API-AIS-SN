using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class JnInfosView
    {
        public long Id { get; set; }
        public string AccountNumber { get; set; }
        public string ServiceName { get; set; }
        public string ServiceTypeName { get; set; }
        public string OperName { get; set; }
        public decimal Summ { get; set; }
        public DateTime Created { get; set; }
        public DateTime Period { get; set; }
        public long? GroupOperId { get; set; }
        public string GroType { get; set; }
        public string GroSubType { get; set; }
        public DateTime? GroCreated { get; set; }
        public string GroComment { get; set; }
        public long AccountServiceId { get; set; }
        public byte CalcOperId { get; set; }
    }
}

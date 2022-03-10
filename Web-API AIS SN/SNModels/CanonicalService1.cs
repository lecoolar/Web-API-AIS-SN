using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class CanonicalService1
    {
        public CanonicalService1()
        {
            CanonicalServiceProperties = new HashSet<CanonicalServiceProperty>();
            Service1s = new HashSet<Service1>();
        }

        public long Id { get; set; }
        public int Code { get; set; }
        public string ShortName { get; set; }
        public string LongName { get; set; }
        public long SrvTypeId { get; set; }
        public string P1 { get; set; }
        public string P2 { get; set; }
        public string P3 { get; set; }
        public string P4 { get; set; }
        public string P5 { get; set; }
        public string P6 { get; set; }
        public string P7 { get; set; }
        public string P8 { get; set; }
        public string P9 { get; set; }
        public string P10 { get; set; }
        public string P11 { get; set; }
        public string P12 { get; set; }
        public string P13 { get; set; }
        public string P14 { get; set; }

        public virtual ServiceType SrvType { get; set; }
        public virtual ICollection<CanonicalServiceProperty> CanonicalServiceProperties { get; set; }
        public virtual ICollection<Service1> Service1s { get; set; }
    }
}

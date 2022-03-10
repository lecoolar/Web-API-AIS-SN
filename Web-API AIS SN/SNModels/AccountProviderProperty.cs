using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class AccountProviderProperty
    {
        public long Id { get; set; }
        public string ProviderNumber { get; set; }
        public string ProviderAccountNumber { get; set; }
        public string LName { get; set; }
        public string FName { get; set; }
        public string MName { get; set; }
        public string Raion { get; set; }
        public string City { get; set; }
        public string Street { get; set; }
        public string House { get; set; }
        public string Korpus { get; set; }
        public string Structure { get; set; }
        public string Flat { get; set; }
        public int? ResidentCount { get; set; }
        public decimal? Heating { get; set; }
        public string AccountNumberEirc { get; set; }
        public int? ResidentCountEirc { get; set; }
        public decimal? HeatingEirc { get; set; }
    }
}

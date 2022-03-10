using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class RegistrationsFromP
    {
        public string Adr { get; set; }
        public long? PsAddressId { get; set; }
        public long? SnAddressId { get; set; }
        public string AccountNumber { get; set; }
        public string Lname { get; set; }
        public string Fname { get; set; }
        public string Mname { get; set; }
        public DateTime? Birthdate { get; set; }
        public string Fio { get; set; }
        public long? PsPersonId { get; set; }
        public DateTime? RegDate { get; set; }
        public DateTime? UnregDate { get; set; }
        public string OldLastName { get; set; }
        public DateTime? DateChangeFio { get; set; }
    }
}

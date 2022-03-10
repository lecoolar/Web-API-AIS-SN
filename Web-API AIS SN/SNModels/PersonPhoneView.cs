using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class PersonPhoneView
    {
        public long Id { get; set; }
        public string Phone { get; set; }
        public string Fio { get; set; }
        public long AccountId { get; set; }
        public string Number { get; set; }
        public string Email { get; set; }
        public DateTime? Created { get; set; }
        public Guid? GenerateToken { get; set; }
    }
}

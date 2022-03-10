using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class AccountPaymentSystemView
    {
        public long Id { get; set; }
        public string Number { get; set; }
        public string LName { get; set; }
        public string FName { get; set; }
        public string MName { get; set; }
        public string City { get; set; }
        public string Street { get; set; }
        public string House { get; set; }
        public string Flat { get; set; }
        public DateTime? Created { get; set; }
        public bool? IsClose { get; set; }
        public string Action { get; set; }
    }
}

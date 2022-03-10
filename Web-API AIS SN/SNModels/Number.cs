using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class Number
    {
        public Number()
        {
            AccountNumbers = new HashSet<AccountNumber>();
        }

        public long Id { get; set; }
        public string Number1 { get; set; }
        public string PrintName { get; set; }
        public string Pass { get; set; }

        public virtual ICollection<AccountNumber> AccountNumbers { get; set; }
    }
}

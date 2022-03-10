using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class OpCode
    {
        public OpCode()
        {
            Payments = new HashSet<Payment>();
        }

        public byte Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Payment> Payments { get; set; }
    }
}

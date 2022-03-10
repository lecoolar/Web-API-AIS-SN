using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class PersonDeclaration
    {
        public long PersonPhoneId { get; set; }
        public long AccountId { get; set; }
        public DateTime Created { get; set; }

        public virtual Account Account { get; set; }
        public virtual PersonPhone PersonPhone { get; set; }
    }
}

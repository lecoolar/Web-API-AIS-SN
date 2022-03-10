using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SMSR
{
    public partial class Person
    {
        public Person()
        {
            AccountPeople = new HashSet<AccountPerson>();
        }

        public long Id { get; set; }
        public long? PersonSnId { get; set; }
        public string PersonInn { get; set; }
        public string PersonSnils { get; set; }

        public virtual ICollection<AccountPerson> AccountPeople { get; set; }
    }
}

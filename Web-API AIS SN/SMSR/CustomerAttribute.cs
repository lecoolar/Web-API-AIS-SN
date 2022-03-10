using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SMSR
{
    public partial class CustomerAttribute
    {
        public CustomerAttribute()
        {
            CustomerAttributeValues = new HashSet<CustomerAttributeValue>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public bool IsRequired { get; set; }
        public int AttributeControlTypeId { get; set; }
        public int DisplayOrder { get; set; }

        public virtual ICollection<CustomerAttributeValue> CustomerAttributeValues { get; set; }
    }
}

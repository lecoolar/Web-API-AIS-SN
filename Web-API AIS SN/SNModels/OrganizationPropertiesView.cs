using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class OrganizationPropertiesView
    {
        public long Id { get; set; }
        public DateTime Created { get; set; }
        public long OrganizationId { get; set; }
        public int PropertyId { get; set; }
        public string PropertyName { get; set; }
        public string PropertyValue { get; set; }
    }
}

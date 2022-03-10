using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class ApartmentPropertiesFullView
    {
        public long? Id { get; set; }
        public long? ApartmentId { get; set; }
        public int PropertyId { get; set; }
        public string PropertyName { get; set; }
        public int? PropertyValue { get; set; }
        public DateTime? FromDate { get; set; }
        public DateTime? Created { get; set; }
    }
}

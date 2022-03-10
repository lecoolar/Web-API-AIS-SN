using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SMSR
{
    public partial class SpecificationAttributeOption
    {
        public SpecificationAttributeOption()
        {
            ProductSpecificationAttributeMappings = new HashSet<ProductSpecificationAttributeMapping>();
        }

        public int Id { get; set; }
        public int SpecificationAttributeId { get; set; }
        public string Name { get; set; }
        public string ColorSquaresRgb { get; set; }
        public int DisplayOrder { get; set; }

        public virtual SpecificationAttribute SpecificationAttribute { get; set; }
        public virtual ICollection<ProductSpecificationAttributeMapping> ProductSpecificationAttributeMappings { get; set; }
    }
}

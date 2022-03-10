using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class KbkserviceType
    {
        public long Id { get; set; }
        public DateTime? Created { get; set; }
        public int? FasetItem161Id { get; set; }
        public int? FasetItem162Id { get; set; }
        public int? FasetItem163Id { get; set; }
        public string Name { get; set; }

        public virtual FasetItem FasetItem161 { get; set; }
        public virtual FasetItem FasetItem162 { get; set; }
        public virtual FasetItem FasetItem163 { get; set; }
    }
}

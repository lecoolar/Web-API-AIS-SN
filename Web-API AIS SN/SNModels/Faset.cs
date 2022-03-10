using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class Faset
    {
        public Faset()
        {
            ApartmentTypes = new HashSet<ApartmentType>();
            CalcAlgorithmChargeFormulas = new HashSet<CalcAlgorithmChargeFormula>();
            CanonicalServiceSettings = new HashSet<CanonicalServiceSetting>();
            FasetItems = new HashSet<FasetItem>();
            ReportTemplates = new HashSet<ReportTemplate>();
        }

        public short Id { get; set; }
        public string Name { get; set; }
        public bool IsSystem { get; set; }
        public string Type { get; set; }

        public virtual ICollection<ApartmentType> ApartmentTypes { get; set; }
        public virtual ICollection<CalcAlgorithmChargeFormula> CalcAlgorithmChargeFormulas { get; set; }
        public virtual ICollection<CanonicalServiceSetting> CanonicalServiceSettings { get; set; }
        public virtual ICollection<FasetItem> FasetItems { get; set; }
        public virtual ICollection<ReportTemplate> ReportTemplates { get; set; }
    }
}

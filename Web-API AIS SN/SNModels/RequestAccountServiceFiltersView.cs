using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class RequestAccountServiceFiltersView
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public int Sort { get; set; }
        public string ProcName { get; set; }
        public DateTime? Created { get; set; }
        public DateTime? Updated { get; set; }
        public bool IsActive { get; set; }
        public string Comment { get; set; }
        public bool? IsAfterJn { get; set; }
        public DateTime? DateLastUse { get; set; }
    }
}

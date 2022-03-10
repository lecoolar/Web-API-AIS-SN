using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SMSR
{
    public partial class UrlRecord
    {
        public int Id { get; set; }
        public int EntityId { get; set; }
        public string EntityName { get; set; }
        public string Slug { get; set; }
        public bool IsActive { get; set; }
        public int LanguageId { get; set; }
    }
}

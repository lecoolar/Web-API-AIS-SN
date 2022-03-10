using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SMSR
{
    public partial class SearchTerm
    {
        public int Id { get; set; }
        public string Keyword { get; set; }
        public int StoreId { get; set; }
        public int Count { get; set; }
    }
}

using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SMSR
{
    public partial class QueryType
    {
        public QueryType()
        {
            Log2s = new HashSet<Log2>();
        }

        public long Id { get; set; }
        public int? Code { get; set; }
        public string ShortName { get; set; }
        public string LongName { get; set; }

        public virtual ICollection<Log2> Log2s { get; set; }
    }
}

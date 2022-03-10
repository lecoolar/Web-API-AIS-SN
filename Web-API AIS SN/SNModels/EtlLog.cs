using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class EtlLog
    {
        public string SchemaName { get; set; }
        public string TableName { get; set; }
        public long? Updates { get; set; }
        public long? Inserts { get; set; }
        public DateTime? Tstamp { get; set; }
        public string Err { get; set; }
    }
}

using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class TableTestConstraint
    {
        public long Id { get; set; }
        public string SchemaName { get; set; }
        public string TableName { get; set; }
        public string KeyFieldsNameWithoutData { get; set; }
        public string FromDataFieldName { get; set; }
        public string ToDataFieldName { get; set; }
        public string DataFieldName { get; set; }
        public string FasetItemFieldName { get; set; }
        public short? FasetId { get; set; }

        public virtual Faset Faset { get; set; }
    }
}

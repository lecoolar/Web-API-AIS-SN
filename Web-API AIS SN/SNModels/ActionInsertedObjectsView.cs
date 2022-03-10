using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class ActionInsertedObjectsView
    {
        public long Id { get; set; }
        public long ActionId { get; set; }
        public int TableId { get; set; }
        public long ObjectId { get; set; }
        public string ActionObjectTypeFasetName { get; set; }
        public long? ActionObjectId { get; set; }
        public string ActionGroupFasetName { get; set; }
        public string SchemaName { get; set; }
        public string TableName { get; set; }
    }
}

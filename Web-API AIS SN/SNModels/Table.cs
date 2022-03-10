using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class Table
    {
        public Table()
        {
            ActionInsertedObjects = new HashSet<ActionInsertedObject>();
        }

        public int Id { get; set; }
        public string SchemaName { get; set; }
        public string TableName { get; set; }
        public bool AuditEnabled { get; set; }
        public string AuditFor { get; set; }
        public string TablePk { get; set; }
        public int? AuditMaxRowsCount { get; set; }
        public int? CountMonth { get; set; }

        public virtual ICollection<ActionInsertedObject> ActionInsertedObjects { get; set; }
    }
}

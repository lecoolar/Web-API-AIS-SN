using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class TemporaryTablesView
    {
        public int Id { get; set; }
        public string SchemaName { get; set; }
        public string TableName { get; set; }
        public DateTime? Created { get; set; }
        public long? RowCounts { get; set; }
        public long? TotalSpaceKb { get; set; }
        public long? UsedSpaceKb { get; set; }
        public decimal? TotalSpaceMb { get; set; }
        public decimal? UsedSpaceMb { get; set; }
    }
}

using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class ExportInfo
    {
        public long Id { get; set; }
        public long ActionId { get; set; }
        public int NumberFile { get; set; }
        public DateTime Created { get; set; }
        public string FileName { get; set; }
        public string FolderName { get; set; }
        public long IndexPart { get; set; }
        public int FromNumberInAction { get; set; }
        public int ToNumberInAction { get; set; }
        public string GeneralParams { get; set; }
    }
}

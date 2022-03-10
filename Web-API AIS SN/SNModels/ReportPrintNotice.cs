using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class ReportPrintNotice
    {
        public string PrintTypeName { get; set; }
        public string NoticeTemplateSettingName { get; set; }
        public string City { get; set; }
        public string Street { get; set; }
        public string House { get; set; }
        public long? AccountsCount { get; set; }
        public long? PagesCount { get; set; }
        public long? SheetsCount { get; set; }
        public long? ApartmentsCount { get; set; }
        public string BaseName { get; set; }
        public string HouseHolderName { get; set; }
    }
}

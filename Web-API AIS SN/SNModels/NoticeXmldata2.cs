using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class NoticeXmldata2
    {
        public long Id { get; set; }
        public long NoticeXmlid { get; set; }
        public int RowNumber { get; set; }
        public string DataXml { get; set; }

        public virtual NoticeXmlnotice NoticeXml { get; set; }
    }
}

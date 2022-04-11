using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Web_API_AIS_SN.ResultModels
{
    public class GetPrintedNoticeByAccount_ForLKResult
    {
		public long Id { get; set; }

		public DateTime Period { get; set; }

		public long NoticeTemplateId { get; set; }

		public string NoticeTemplateName { get; set; }

		public long NoticeTemplateSettingsId { get; set; }

		public string NoticeTemplateSettingsName { get; set; }

		public bool IsLkActive { get; set; }
	}
}

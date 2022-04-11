using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Web_API_AIS_SN.GKH;
using Web_API_AIS_SN.LibClass;
using Web_API_AIS_SN.Model;
using Web_API_AIS_SN.SMSR;

namespace Web_API_AIS_SN.NoticeAndReport
{
    public class FindTypeReport
    {
        public string Account { get; set; }
        public string Uid { get; set; }
        public int? BaseId { get; set; }
        public DateTime Period { get; set; }
        public string SystemName { get; set; }
        public bool OnlyRenderNotice { get; set; }

        public FindTypeReport(List<Param> @params, string globalUid = "")
        {
            Uid = globalUid;
            Account = @params.FirstOrDefault(q => q.Name == "account").Value;
            var bId = @params.FirstOrDefault(q => q.Name == "baseId")?.Value;
            BaseId = bId == null ? (int?)null : Convert.ToInt32(bId);
            var byfPeriod = @params.FirstOrDefault(q => q.Name == "period")?.Value;
            Period = byfPeriod == null ? DateTime.MinValue : DateTime.Parse(byfPeriod);
            SystemName = @params.FirstOrDefault(q => q.Name == "systemName")?.Value ?? "SN";
            OnlyRenderNotice = bool.Parse(@params.FirstOrDefault(q => q.Name == "onlyRenderNotice")?.Value ?? "false");
        }

        public async Task<ResponseData> GetFindTypeReport()
        {
            var constring = "";

            var webservice = new WebService();
            var res = new ResponseData();
            try
            {
                if (BaseId == null || BaseId == 0)
                {
                    res.Result.Code = 1;
                    res.Result.Message = String.Format("Не указан обязательный параметр № базы, требуется уточнение параметра");
                    return res;
                }
                else
                {
                    constring = new Helpers().GetConnectionString(BaseId.Value);
                }
                if (String.IsNullOrEmpty(constring))
                {
                    res.Result.Code = 11;
                    res.Result.Message = $"{Uid}  Ошибка, не удалось собрать строку подключения к базе!";
                    return res;
                }

                List<Dictionary<string, object>> rows = new List<Dictionary<string, object>>();
                var qwe = this.ToString();
                var accountInfo = new AccountSN(constring).GetByNumber(Account);
                var notice = new NoticeNoticeTemplateSettingSN(constring);
                var result = new List<ReportsAndSetting>();
                if (SystemName == "LK" || SystemName == "CRM")
                {
                    var acId = accountInfo?.Id ?? 0;
                    var repOrg = notice.GetNoticeTemplatesByAccountIdAndWithOrganization(acId);
                    result = repOrg.Select(a => new ReportsAndSetting(a)).ToList();
                    if (!result.Any())
                    {
#warning add appsettings
                        if (OnlyRenderNotice || "no" == "yes")
                        {
                            var repList = await notice.GetPrintedNoticeByAccountAndPeriod(acId, Period);
                            var rep = repList.Where(n => n.IsLkActive).ToList();
                            result = rep.Select(a => new ReportsAndSetting(a)).ToList();
                        }
                        else
                        if (SystemName == "CRM")
                        {
                            var rep = await notice.GetReportsAndSetting();
                            result = rep.Select(a => new ReportsAndSetting(a)).ToList();
                        }
                        else
                        {
                            var rep = notice.GetActiveNoticeTemplateSettings().ToList();
                            result = rep.Select(a => new ReportsAndSetting(a)).ToList();
                        }
                    }
                }
                else
                {
                    var rep = await notice.GetReportsAndSetting();
                    result = rep.Select(a => new ReportsAndSetting(a)).ToList();
                }
                result = result.GroupBy(w => new { w.ReportId, w.SettingId }).Select(t => t.First()).ToList();
                PropertyInfo[] Props = typeof(ReportsAndSetting).GetProperties(BindingFlags.Public | BindingFlags.Instance);
                foreach (var item in result)
                {
                    var row = new Dictionary<string, object>();
                    for (int i = 0; i < Props.Length; i++)
                    {
                        //inserting property values to datatable rows
                        row.Add(Props[i].Name, Props[i].GetValue(item, null));
                    }
                    rows.Add(row);
                }

                if (rows.Any())
                {
                    res.Result.Code = 0;
                    res.ResponseObject = rows;
                }
                else
                {
                    res.Result.Code = 4;
                    res.Result.Message = "Нет доступных шаблонов для формирования";
                    res.ResponseObject = new List<Dictionary<string, object>>();
                }
            }
            catch (Exception ex)
            {
                res.Result.Code = -1;
                res.Result.Message = "Критическая ошибка при обработке запроса.";
            }
            return res;
        }
    }
}

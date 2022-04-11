using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using Web_API_AIS_SN.Context;
using Web_API_AIS_SN.ResultModels;
using Web_API_AIS_SN.SNModels;

namespace Web_API_AIS_SN.LibClass
{
    public class NoticeNoticeTemplateSettingSN
    {

        public NoticeNoticeTemplateSettingSN()
        {
        }
        internal string conString;
        public NoticeNoticeTemplateSettingSN(string conStrings)
        {
            conString = conStrings;
        }
        public NoticeTemplateSetting GetById(long repstr)
        {
            var noticeTemplates = new NoticeTemplateSetting();
            try
            {
                using (var sn = new SNContext(conString))
                {
                    noticeTemplates = sn.NoticeTemplateSettings.Where(q => q.Id == repstr).SingleOrDefault();
                }
            }
            catch (Exception ex)
            {

            }
            return noticeTemplates;
        }
        public async Task<List<GetPrintedNoticeByAccount_ForLKResult>> GetPrintedNoticeByAccountAndPeriod(long accountId, DateTime period)
        {
            var noticeAll = new List<GetPrintedNoticeByAccount_ForLKResult>();
            try
            {
                using (var sn = new SNContext(conString))
                {
                    string query = @$"SELECT * FROM lk.""GetPrintedNoticeByAccount_ForLK""({accountId})";
                    noticeAll = await sn.Set<GetPrintedNoticeByAccount_ForLKResult>().FromSqlRaw(query).ToListAsync();
                    //noticeAll = sn.GetPrintedNoticeByAccount_ForLK(accountId).ToList();
                    noticeAll = noticeAll.Where(pn => (pn.Period == period || period == DateTime.MinValue)).ToList();
                    var falc = noticeAll.Where(n => n.NoticeTemplateName.Contains("(Фальцевание)")).Select(n => n.NoticeTemplateName).Distinct().ToList();
                    var falcevanieActive = sn.SettingsViews.Where(z => z.Name == "Выводить шаблоны (Фальцевание)").SingleOrDefault()?.Value;
                    if (falcevanieActive != "Да")
                    {
                        foreach (var item in falc)
                        {
                            var notfalc = item.Replace("(Фальцевание)", "").Trim();
                            if (noticeAll.Any(n => n.NoticeTemplateName == item) && noticeAll.Any(n => n.NoticeTemplateName == notfalc))
                            {
                                noticeAll.RemoveAll(n => n.NoticeTemplateName == item);
                            }
                            else
                            {
                                foreach (var notice in noticeAll.Where(n => n.NoticeTemplateName == item))
                                {
                                    notice.NoticeTemplateName = notfalc;
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {

            }
            return noticeAll;
        }

        public async Task<List<SeletReportsAndSettingResult>> GetReportsAndSetting()
        {
            var noticeAll = new List<SeletReportsAndSettingResult>();
            try
            {
                using (var sn = new SNContext(conString))
                {
                    string query = @$"SELECT * FROM CRM.""SeletReportsAndSetting""()";
                    noticeAll = await sn.Set<SeletReportsAndSettingResult>().FromSqlRaw(query).ToListAsync();
                    //noticeAll = sn.SeletReportsAndSetting().ToList();
                }
            }
            catch (Exception ex)
            {

            }
            return noticeAll;
        }

        public NoticeTemplateSettingsView GetTemplateSettingByRepIdAndSettingName(long repId,string templateSettingIdentityName)
        {
            var noticeAll = new NoticeTemplateSettingsView();
            try
            {
                using (var sn = new SNContext(conString))
                {
                    noticeAll = sn.NoticeTemplateSettingsViews.Where(z => z.NoticeTemplateId == repId && z.Name == templateSettingIdentityName).SingleOrDefault();
                }
            }
            catch (Exception ex)
            {

            }
            return noticeAll;
        }

        public List<NoticeTemplateSetting> GetAllNoticeTemplateSettings()
        {
            var noticeTemplates = new List<NoticeTemplateSetting>();
            try
            {
                using (var sn = new SNContext(conString))
                {
                    noticeTemplates = sn.NoticeTemplateSettings.ToList();
                }
            }
            catch(Exception ex)
            {

            }
            return noticeTemplates;
        }

        public List<NoticeTemplateSettingsView> GetActiveNoticeTemplateSettings()
        {
            var noticeTemplates = new List<NoticeTemplateSettingsView>();
            try
            {
                using (var sn = new SNContext(conString))
                {
                    noticeTemplates = sn.NoticeTemplateSettingsViews
                        .Join(sn.NoticeTemplates.Where(nt => nt.IsActive.HasValue && Convert.ToBoolean(nt.IsLkActive) ), q => q.NoticeTemplateId, z => z.Id, (q, z) => q)
                        .Where(n => n.IsLkActive && n.IsActive).ToList();
                }
            }
            catch (Exception ex)
            {

            }
            return noticeTemplates;
        }

        public async Task<bool>  AnyRenredReport(DateTime period , long accountId ,  long templateSettingId)
        {
            var any = false;
            var noticeTemplates = new List<NoticeTemplateSetting>();
            try
            {
                using (var sn = new SNContext(conString))
                {
                    string query = @$"SELECT * FROM lk.""GetPrintedNoticeByAccount_ForLK""({accountId})";
                    any = await sn.Set<GetPrintedNoticeByAccount_ForLKResult>().FromSqlRaw(query).Where(z => z.Period == period).AnyAsync();
                    //any = sn.GetPrintedNoticeByAccount_ForLK(accountId).Where(z => z.period == period).Any();
                    //any =  sn.RenderedNotices.Where(z=>z.period==period && z.accountId == accountId && z.noticeTemplateSettingId == templateSettingId && z.hasResult).Any();
                }
            }
            catch (Exception ex)
            {

            }
            return any;
        }

        public List<NoticeTemplateSetting> FindByNoticeTemplateId(long templateId, long accountId)
        {
            var noticeTemplates = new List<NoticeTemplateSetting>();
            try
            {
                using (var sn = new SNContext(conString))
                {
                    string query = @$"SELECT * FROM notice.""NoticeTemplateSettings_GetWithRight""({templateId},{accountId})";
                    noticeTemplates = sn.NoticeTemplateSettings
                                        .Join(sn.Set<NoticeTemplateSettings_GetWithRightResult>().FromSqlRaw(query), q => q.Id, z => z.Id, (q, z) => q)
                                        .Where(nts => nts.IsLkActive)
                                        .OrderBy(a => a.Sort).ToList();
                }
            }
            catch
            {

            }
            return noticeTemplates;
        }

        public List<NoticeTemplateSetting> FindByLk(long accountId)
        {
            var noticeTemplates = new List<NoticeTemplateSetting>();
            try
            {
                using (var sn = new SNContext(conString))
                {
                    string query = @$"SELECT * FROM notice.""NoticeTemplates_GetWithRight""({accountId})";
                    noticeTemplates = sn.NoticeTemplateSettings
                        .Join(sn.Set<NoticeTemplates_GetWithRightResult>().FromSqlRaw(query), q => q.NoticeTemplateId, z => z.Id, (q, z) => q)
                        .Where(n => n.IsLkActive)
                        .OrderBy(a => a.Sort).ToList();
                }
            }
            catch (Exception ex)
            {

            }
            return noticeTemplates;
        }

        public List<NoticeTemplateSettingsView> GetNoticeTemplatesByAccountIdAndWithOrganization(long accountId)
        {
            var noticeTemplates = new List<NoticeTemplateSettingsView>();
            try
            {
                using (var sn = new SNContext(conString))
                {
                    string query = @$"SELECT * FROM CRM.""NoticeTemplateSettings_GetByOrganizationsForLk""({accountId})";
                    noticeTemplates = sn.NoticeTemplateSettingsViews
                        .Join(sn.Set<NoticeTemplateSettings_GetByOrganizationsForLkResult>().FromSqlRaw(query), q => q.Id, z => z.Id, (q, z) => q)
                        .Where(n=>n.IsLkActive)
                        .OrderBy(a => a.Sort).ToList();
                }
            }
            catch (Exception ex)
            {

            }
            return noticeTemplates;
        }

        
        public NoticeTemplateSettingsView GetDefaultNoticeNoticeTemplateSettingView(long noticeTemplateId)
        {
            var noticeTemplates = new NoticeTemplateSettingsView();
            try
            {
                using (var sn = new SNContext(conString))
                {
                    noticeTemplates = sn.NoticeTemplateSettingsViews
                        .Where(n => n.NoticeTemplateId == noticeTemplateId && n.IsDefault).SingleOrDefault();
                }
            }
            catch (Exception ex)
            {

            }
            return noticeTemplates;
        }

        public NoticeTemplateSetting GetDefaultNoticeNoticeTemplateSetting(long noticeTemplateId)
        {
            var noticeTemplates = new NoticeTemplateSetting();
            try
            {
                using (var sn = new SNContext(conString))
                {
                    noticeTemplates = sn.NoticeTemplateSettings
                        .Where(n => n.NoticeTemplateId == noticeTemplateId && n.IsDefault).SingleOrDefault();
                }
            }
            catch (Exception ex)
            {

            }
            return noticeTemplates;
        }

        public NoticeTemplateSettingsView GetNoticeNoticeTemplateSettingByIdAndTemplateName(long noticeTemplateSettingId, string templateName)
        {
            var noticeTemplates = new NoticeTemplateSettingsView();
            try
            {
                using (var sn = new SNContext(conString))
                {
                    noticeTemplates = sn.NoticeTemplateSettingsViews
                        .Where(n => n.Id == noticeTemplateSettingId && n.TemplateName==templateName).SingleOrDefault();
                }
            }
            catch (Exception ex)
            {

            }
            return noticeTemplates;
        }
        public NoticeTemplateSetting FindFirstByNoticeTemplateId(long templateId)
        {
            NoticeTemplateSetting templateSettings = null;

            try
            {
                using (var sn = new SNContext(conString))
                {
                    templateSettings = sn.NoticeTemplateSettings.FirstOrDefault(p => p.NoticeTemplateId == templateId && p.IsLkActive == true && p.IsDefault);
                }
            }
            catch (Exception ex)
            {

            }

            return templateSettings;
        }
    }
}
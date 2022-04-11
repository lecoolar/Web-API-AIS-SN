using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Web_API_AIS_SN.Context;
using Web_API_AIS_SN.Model;
using Web_API_AIS_SN.ResultModels;
using Web_API_AIS_SN.SMSR;

namespace Web_API_AIS_SN.GKH
{
    public class AcocuntByLocalAddress
    {
        private long? LocalAddressId { get; set; }
        private int? BaseId { get; set; }
        public string Uid { get; set; }
        public bool GetCloseAccount { get; set; }

        public bool FindWithFIO { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }

        public AcocuntByLocalAddress(List<Param> @params, string globalUid = "")
        {
            Uid = globalUid;

            var buflocalAddresId = @params.FirstOrDefault(q => q.Name == "localAddressId")?.Value;
            LocalAddressId = string.IsNullOrEmpty(buflocalAddresId) ? (long?)null : Convert.ToInt64(buflocalAddresId);

            var bId = @params.FirstOrDefault(q => q.Name == "baseId")?.Value;
            BaseId = string.IsNullOrEmpty(bId) ? (int?)null : Convert.ToInt32(bId);
            var buffcloseAccount = @params.FirstOrDefault(q => q.Name == "getCloseAccount")?.Value;
            GetCloseAccount = buffcloseAccount == null ? true : buffcloseAccount == "1" ? true : buffcloseAccount == "0" ? false : Convert.ToBoolean(buffcloseAccount);


            var findWithFIObuf = @params.FirstOrDefault(q => q.Name == "findWithFIO")?.Value;
            FindWithFIO = findWithFIObuf == null ? false : findWithFIObuf == "1" ? true : findWithFIObuf == "0" ? false : Convert.ToBoolean(findWithFIObuf);

            FirstName = @params.FirstOrDefault(q => q.Name == "firstName")?.Value;
            MiddleName = @params.FirstOrDefault(q => q.Name == "middleName")?.Value;
            LastName = @params.FirstOrDefault(q => q.Name == "lastName")?.Value;
        }

        public async Task<ResponseData> GetAcocuntByLocalAddress()
        {
            var webservice = new WebService();
            var res = new ResponseData();
            bool needFindAVGIndication = false;
#warning AppSettings
            //var sr = ConfigurationManager.AppSettings["FromFindAVGIndication"];
            var sr = "25";
            int FromFindAVGIndication = 0;
            //var countLS = string.IsNullOrEmpty(ConfigurationManager.AppSettings["CountLS"]) ? 20 : Convert.ToInt32(ConfigurationManager.AppSettings["CountLS"]);
            var countLS = 100;
            var countLA = 0;
            int.TryParse(sr, out FromFindAVGIndication);
            if (FromFindAVGIndication != 0)
                needFindAVGIndication = DateTime.Today > new DateTime(DateTime.Today.Year, DateTime.Today.Month, FromFindAVGIndication);

            if (BaseId == null)
            {
                res.Result.Code = 1;
                res.Result.Message = String.Format("Не указан обязательный параметр №базы, требуется уточнение параметра");
                return res;
            }


            var rows = new List<Dictionary<string, object>>();

            using (var smsr = new SMSRContext())
            {
                webservice = smsr.WebServices.FirstOrDefault(w => w.Id == BaseId);
            }
            var constring = new Helpers().GetConnectionString(webservice?.Id ?? 0);
            if (String.IsNullOrEmpty(constring))
            {
                res.Result.Code = 11;
                res.Result.Message = $"{Uid}  Ошибка, не удалось собрать строку подключения к базе!";
                return res;
            }
            using (var sn = new SNContext(constring))
            {
                try
                {
                    var acc = new List<AccountSearchByLocalAddressResult>();
                    if (FindWithFIO)
                    {
                        if (LocalAddressId == null)
                        {
                            countLA = sn.Persons.Where(p =>
                                            (p.LName == LastName || string.IsNullOrEmpty(LastName))
                                            && (p.FName == FirstName || string.IsNullOrEmpty(FirstName))
                                            && (p.MName == MiddleName || string.IsNullOrEmpty(MiddleName)))
                                            .Count();
                        }
                        else
                        {
                            string query1 = @$"SELECT * FROM CRM.""GetLocalAddressByFIO""({LocalAddressId},{LastName},{FirstName},{MiddleName})";
                            var accountSearchByLocalAddressResult = await sn.Set<GetLocalAddressByFIOResult>().FromSqlRaw(query1).ToListAsync();
                            countLA = accountSearchByLocalAddressResult.Distinct().Count();
                        }
                        if (countLA > countLS)
                        {
                            res.Result.Code = -73;
                            res.Result.Message = $"Слишком много найденых записей, уточните запрос.";
                            return res;
                        }
                        string query = @$"SELECT * FROM CRM.""GetLocalAddressByFIO""({LocalAddressId},{LastName},{FirstName},{MiddleName})";
                        var getLocalAddressByFIOResult = await sn.Set<GetLocalAddressByFIOResult>().FromSqlRaw(query).Select(l => l.AdrId).ToListAsync();
                        var listLA = getLocalAddressByFIOResult.Distinct().ToList();
                        foreach (var item in listLA)
                        {
                            string query1 = @$"SELECT * FROM CRM.""AccountSearchByLocalAddress""({item},{(needFindAVGIndication ? 1 : 0)},{(GetCloseAccount ? 1 : 0)})";
                            var accountSearchByLocalAddressResult = await sn.Set<AccountSearchByLocalAddressResult>().FromSqlRaw(query1).ToListAsync();
                            acc.AddRange(accountSearchByLocalAddressResult);
                        }
                        acc = acc.OrderByDescending(a => a.IsClose).ToList();
                    }
                    else
                    {
                        var level = sn.LocalAddresses.FirstOrDefault(l => l.Id == LocalAddressId).Level;
                        switch (level)
                        {
                            case 40:
                                countLA = 1;
                                break;
                            case 30:
                                countLA = sn.LocalAddresses
                                    .Where(l => l.ParentId == LocalAddressId)
                                    .Join(sn.Apartments, l => l.Id, ap => ap.AddrId, (ap, l) => ap)
                                    .Count();
                                break;
                            case 20:
                                countLA = sn.LocalAddresses
                                    .Where(l => l.ParentId == LocalAddressId)
                                    .Join(sn.LocalAddresses, l => l.Id, r => r.ParentId, (r, l) => r)
                                    .Join(sn.Apartments, l => l.Id, ap => ap.AddrId, (ap, l) => ap)
                                    .Count();
                                break;
                            case 10:
                                countLA = sn.LocalAddresses
                                    .Where(l => l.ParentId == LocalAddressId)
                                    .Join(sn.LocalAddresses, l => l.Id, r => r.ParentId, (r, l) => r)
                                    .Join(sn.LocalAddresses, l => l.Id, r => r.ParentId, (r, l) => r)
                                    .Count();
                                break;
                            default:
                                countLA = 0;
                                break;
                        }
                        if (countLA > countLS)
                        {
                            res.Result.Code = 3;
                            res.Result.Message = $"Слишком много найденых записей, уточните запрос.";
                            return res;
                        }
                        string query2 = @$"SELECT * FROM CRM.""AccountSearchByLocalAddress""({LocalAddressId},{(needFindAVGIndication ? 1 : 0)},{(GetCloseAccount ? 1 : 0)})";
                        acc = await sn.Set<AccountSearchByLocalAddressResult>().FromSqlRaw(query2).OrderByDescending(a => a.IsClose).ToListAsync();
                        //acc = sn.AccountSearchByLocalAddress(LocalAddressId, needFindAVGIndication, GetCloseAccount).OrderByDescending(a => a.isClose).ToList();
                    }

                    PropertyInfo[] Props = typeof(AccountSearchByLocalAddressResult).GetProperties(BindingFlags.Public | BindingFlags.Instance);
                    foreach (var item in acc)
                    {
                        var row = new Dictionary<string, object>();
                        for (int i = 0; i < Props.Length; i++)
                        {
                            //inserting property values to datatable rows
                            row.Add(Props[i].Name, Props[i].GetValue(item, null));
                        }
                        if (row.Any())
                        {
                            row.Add("numberBase", (object)webservice.Id);
                            row.Add("baseName", (object)webservice.BaseName);
                            row.Add("orgName", (object)webservice.Area);
                            row.Add("nameSystem", (object)webservice.SystemType);

                        }
                        rows.Add(row);
                    }
                }
                catch (Exception ex)
                {
                    res.Result.Code = -1;
                    res.Result.Message = "Критическая ошибка при обработке запроса.";
                    res.ResponseObject = new List<Dictionary<string, object>>();
                }
            }
            if (rows.Any())
            {
                res.Result.Code = 0;
                res.ResponseObject = rows;
            }
            else
            {
                res.Result.Code = 2;
                res.Result.Message = "По указанным данным информация не найдена";
            }

            res.ResponseObject = rows;

            return res;
        }
    }
}

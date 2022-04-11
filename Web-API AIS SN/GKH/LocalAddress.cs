using AIS.SN.CRMService.LibClass;
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
    public class LocalAddress
    {
        public int? BaseId { get; set; }
        public long? ParentId { get; set; }
        public int? Lvl { get; set; }
        public string Uid { get; set; }
        public string SystemName { get; set; }

        public LocalAddress(List<Param> @params, string globalUid = "")
        {
            Uid = globalUid;
            var bId = @params.Where(q => q.Name == "baseId").FirstOrDefault()?.Value;
            BaseId = string.IsNullOrEmpty(bId) ? (int?)null : Convert.ToInt32(bId);

            var pId = @params.Where(q => q.Name == "parentId").FirstOrDefault()?.Value;
            ParentId = string.IsNullOrEmpty(pId) ? (long?)null : Convert.ToInt64(pId);

            var lvl_ = @params.Where(q => q.Name == "lvl").FirstOrDefault()?.Value;
            Lvl = string.IsNullOrEmpty(lvl_) ? (int?)null : Convert.ToInt32(lvl_);
            SystemName = @params.FirstOrDefault(q => q.Name == "systemName")?.Value ?? "";
        }

        public async Task<ResponseData> GetLocalAddress()
        {
            var webservice = new WebService();
            var res = new ResponseData();
            var rows = new List<Dictionary<string, object>>();
            var localaddress = new List<GetLocalAddressResult>();

            if ((BaseId != null && ParentId == null && Lvl == null))
            {
                res.Result.Code = 9;
                res.Result.Message = String.Format("Недостаточно параметров для поиска, укажите родительский элемент \"parentId\", или уровень адресного плана \"lvl\"");
                return res;
            }
            else
            if ((BaseId == null && ParentId == null) || Lvl == 0)
            {
                using (var smsr = new SMSRContext())
                {
                    if (SystemName.ToUpper() == "LK")
                    {
                        localaddress = smsr.WebServices
                            .Where(c => c.Area != null && c.BaseName != "sn_len_obl_tosno" && (c.IsLkactive ?? false))
                            //.GroupBy(l => new { l.baseName, l.baseIp })
                            //.Select(l => l.First())
                            .Select(z => new GetLocalAddressResult
                            {
                                Id = z.Id,
                                Name = z.Area
                            })
                            .ToList();
                    }
                    else
                    {
                        localaddress = smsr.WebServices.Where(z => z.BaseName != "sn_pes_test5")
                            .Select(z => new GetLocalAddressResult
                            {
                                Id = z.Id,
                                Name = z.Area
                            })
                            .ToList();
                    }
                }
            }
            else
            {
                var constring = new Helpers().GetConnectionString(BaseId ?? 0);
                if (String.IsNullOrEmpty(constring))
                {
                    res.Result.Code = -10;
                    res.Result.Message = $"{Uid}  Ошибка, не удалось собрать строку подключения к базе!";
                    return res;
                }
                using (var sn = new SNContext(constring))
                {
                    try
                    {
                        if (Lvl == 5)
                        {
                            if (ParentId == null)
                            {
                                localaddress = new LocalDistrictsSN(constring)
                                    .GetLocalDistricts()
                                    .Select(z => new GetLocalAddressResult
                                    {
                                        Id = z.Id,
                                        Name = z.Name
                                    }).ToList();
                            }
                            else
                            {
                                 localaddress = new LocalDistrictsSN(constring)
                                   .GetLocalAddressesByLocalDistrict(ParentId.Value)
                                   .Select(z => new GetLocalAddressResult
                                   {
                                       Id = z.Id.Value,
                                       Name = z.Name,
                                       FiasCode = z.FiasCode,
                                       Socr = z.Socr
                                   }).ToList();
                            }
                        }
                        else
                        {
                            sn.CommandTimeout = 200;
                            string query = @$"SELECT * FROM CRM.""GetLocalAddress""({ParentId},{Lvl})";
                            localaddress = await sn.Set<GetLocalAddressResult>().FromSqlRaw(query).ToListAsync();
                            //localaddress = sn.GetLocalAddress(ParentId, Lvl).ToList();
                        }
                    }
                    catch (Exception ex)
                    {
                        res.Result.Code = -1;
                        res.Result.Message = "Критическая ошибка при обработке запроса.";
                        res.ResponseObject = new List<Dictionary<string, object>>();

                    }
                }
            }

            PropertyInfo[] Props = typeof(GetLocalAddressResult).GetProperties(BindingFlags.Public | BindingFlags.Instance);
            foreach (var item in localaddress)
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
                res.Result.Code = 2;
                res.Result.Message = "По указанным данным информация не найдена";
            }

            res.ResponseObject = rows;
            return res;
        }
    }
}

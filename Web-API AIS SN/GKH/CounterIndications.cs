using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Web_API_AIS_SN.Context;
using Web_API_AIS_SN.Model;
using Web_API_AIS_SN.ResultModels;

namespace Web_API_AIS_SN.GKH
{
    public class CounterIndications
    {
        public int? BaseId { get; set; }
        public DateTime FromDate { get; set; }
        public DateTime ToDate { get; set; }
        public long? CounterId { get; set; }
        public string Uid { get; set; }

        public CounterIndications(List<Param> @params, string globalUid = "")
        {
            Uid = globalUid;

            var bId =@params.Where(q => q.Name == "baseId").FirstOrDefault();
            BaseId = bId == null ? (int?)null : Convert.ToInt32(bId.Value);
            var date = new DateTime();
            var bifdate = @params.Where(q => q.Name == "fromDate").FirstOrDefault();
            DateTime.TryParse(bifdate.Value == null ? null : bifdate.Value, out date);
            FromDate = date;
            if (FromDate == DateTime.MinValue)
                FromDate = DateTime.Now.AddYears(-1);
            bifdate = @params.Where(q => q.Name == "toDate").FirstOrDefault();
            DateTime.TryParse(bifdate.Value == null ? DateTime.Now.ToString() : bifdate.Value, out date);
            ToDate = date;
            if (ToDate == DateTime.MinValue)
                ToDate = DateTime.Now;

            var bufCounterId = @params.Where(q => q.Name == "counterId").FirstOrDefault();
            CounterId = bufCounterId == null ? (long?)null : Convert.ToInt64(bufCounterId.Value);
        }

        public async Task<ResponseDataAndSettings> GetCounterIndications()
        {
            var res = new ResponseDataAndSettings();
            try
            {
                string constring;
                var rows = new List<Dictionary<string, object>>();
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

                var counterIndications = new DataTable();
                var settingsInput = new DataTable();
                //constring = "Data Source=Dev1-Srv.aisgorod.ru,1434;Initial Catalog=sn_moskov_KR_test;User ID=lk;Password=lk2011";
                using (var sn = new SNContext(constring))
                {
                    string query = @$"SELECT * FROM CRM.""CounterIndicationsByPeriod""({CounterId},'{FromDate}','{ToDate}')";
                    var resu = await sn.Set<CounterIndicationsByPeriodResult>().FromSqlRaw(query).ToListAsync();
                    //var resu = sn.CounterIndicationsByPeriod(CounterId.ToString(), FromDate, ToDate).ToList();
                    DataTable dt = new DataTable();
                    PropertyInfo[] Props = typeof(CounterIndicationsByPeriodResult).GetProperties(BindingFlags.Public | BindingFlags.Instance);
                    foreach (var prop in Props)
                    {
                        //Setting column names as Property names
                        dt.Columns.Add(prop.Name);
                    }
                    foreach (var account in resu)
                    {
                        var values = new object[Props.Length];
                        for (int i = 0; i < Props.Length; i++)
                        {
                            //inserting property values to datatable rows
                            values[i] = Props[i].GetValue(account, null);
                        }
                        dt.Rows.Add(values);
                    }
                    counterIndications = dt;
                    query = @$"SELECT * FROM CRM.""GetSettingsInput""()";
                    var settingsInputBuf =await sn.Set<GetSettingsInputResult>().FromSqlRaw(query).ToListAsync();
                    dt = new DataTable();
                    Props = typeof(GetSettingsInputResult).GetProperties(BindingFlags.Public | BindingFlags.Instance);
                    foreach (PropertyInfo prop in Props)
                    {
                        //Setting column names as Property names
                        dt.Columns.Add(prop.Name);
                    }
                    foreach (var account in settingsInputBuf)
                    {
                        var values = new object[Props.Length];
                        for (int i = 0; i < Props.Length; i++)
                        {
                            //inserting property values to datatable rows
                            values[i] = Props[i].GetValue(account, null);
                        }
                        dt.Rows.Add(values);
                    }
                    settingsInput = dt;

                    Dictionary<string, object> row;
                    foreach (DataRow dr in counterIndications.Rows)
                    {
                        row = new Dictionary<string, object>();
                        foreach (DataColumn col in counterIndications.Columns)
                        {
                            row.Add(col.ColumnName, dr[col]);
                        }
                        rows.Add(row);
                    }
                }
                if (rows.Any())
                {
                    res.Result.Code = 0;
                    res.ResponseObject = rows;
                    rows = new List<Dictionary<string, object>>();
                    foreach (DataRow dr in settingsInput.Rows)
                    {
                        var row = new Dictionary<string, object>();
                        foreach (DataColumn col in settingsInput.Columns)
                        {
                            var val = dr[col].ToString().ToUpper() == "ДА" ? "true" : dr[col].ToString().ToUpper() == "НЕТ" ? "false" : dr[col].ToString();
                            row.Add(col.ColumnName, val);
                        }
                        rows.Add(row);
                    }
                    res.ResponseSettings = rows;
                }
                else
                {
                    res.Result.Code = 2;
                    res.Result.Message = "По указанному прибору учета информация не найдена";
                    res.ResponseObject = new List<Dictionary<string, object>>();
                }
            }
            catch (Exception ex)
            {
                res.Result.Code = -1;
                res.Result.Message = "Ошибка при поиске показаний по прибору учета";
            }
            return res;
        }
    }
}

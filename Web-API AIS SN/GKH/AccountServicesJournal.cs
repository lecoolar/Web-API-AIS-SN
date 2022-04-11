using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using Web_API_AIS_SN.Context;
using Web_API_AIS_SN.LibClass;
using Web_API_AIS_SN.Model;

namespace Web_API_AIS_SN.GKH
{
    public class AccountServicesJournal
    {
        public string Account { get; set; }
        public string Uid { get; set; }
        public int? BaseId { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        public AccountServicesJournal(List<Param> @params, string globalUid = "")
        {
            Uid = globalUid;
            Account = @params.FirstOrDefault(q => q.Name == "account")?.Value;
            var bId = @params.FirstOrDefault(q => q.Name == "baseId")?.Value;
            BaseId = bId == null ? (int?)null : Convert.ToInt32(bId);
            var date = new DateTime();
            var bifdate = @params.FirstOrDefault(q => q.Name == "startDate")?.Value;
            DateTime.TryParse(bifdate == null ? null : bifdate, out date);
            StartDate = date;
            bifdate = @params.FirstOrDefault(q => q.Name == "endDate")?.Value;
            DateTime.TryParse(bifdate == null ? null : bifdate, out date);
            EndDate = date;
        }

        //public async Task<ResponseData> GetAccountServicesJournal()
        //{
        //    var res = new ResponseData();
        //    var GeneralRows = new List<Dictionary<string, object>>();
        //    if (BaseId == null)
        //    {
        //        res.Result.Code = 1;
        //        res.Result.Message = String.Format("Не указан обязательный параметр № базы, требуется уточнение параметра");
        //        return res;
        //    }
        //    try
        //    {
        //        bool useOnlyAvailableHouseId = false;
        //        using (var smsr = new SMSRContext())
        //        {
        //            useOnlyAvailableHouseId = smsr.Settings.SingleOrDefault(s => s.Name == "useOnlyAvailableHouseId")?.Value == "yes" ? true : false;
        //        }

        //        var rows = new List<Dictionary<string, object>>();



        //        var constring = new Helpers().GetConnectionString(BaseId ?? 0);
        //        if (String.IsNullOrEmpty(constring))
        //        {
        //            res.Result.Code = 11;
        //            res.Result.Message = $"{Uid}  Ошибка, не удалось собрать строку подключения к базе!";
        //            return res;
        //        }
        //        var acc = new AccountSN(constring).GetByNumber(Account);
        //        if (acc == null || acc.Id == 0)
        //        {

        //        }
        //        else
        //        {

        //            if (useOnlyAvailableHouseId)
        //            {
        //                using (var sn = new SNContext(constring))
        //                {
        //                    var houseId = new AccountSN(constring).GetHouseIdByAccount(Account);
        //                    var group = sn.Groups.FirstOrDefault(g => g.Name == "AvailableHouseId");
        //                    if (group != null)
        //                    {
        //                        List<string> availableHouseList = sn.Elements.Where(e => e.IdGroup == group.Id)
        //                            .Select(i => i.IdObject.ToString()).ToList();

        //                        if (!availableHouseList.Contains(houseId))
        //                        {
        //                            res.Result.Code = 1;
        //                            res.Result.Message = "Дом не входит в список разрешенных";
        //                            return res;
        //                        }
        //                    }
        //                }
        //            }


        //            var periodSetting = new SettingSN(constring).GetValueByGroupNameAndName("Интерфейсы", "Выдача информации по открытому периоду")?.Value ?? "да";
        //            var calPeriod = new CalcPeriodSN(constring).GetCurrent();
        //            if (periodSetting.ToLower() == "нет")
        //            {
        //                EndDate = EndDate >= calPeriod.ToDate ? EndDate.AddMonths(-1) : EndDate;
        //                if (StartDate >= calPeriod.FromDate)
        //                {
        //                    res.Result.Code = -3;
        //                    res.Result.Message = String.Format("Ошибка, по данному периоду производится расчёт!");
        //                    return res;
        //                }
        //                calPeriod.ToDate = calPeriod.ToDate.AddMonths(-1);
        //                calPeriod.FromDate = calPeriod.FromDate.AddMonths(-1);
        //            }

        //            if (StartDate == null || StartDate == DateTime.MinValue)
        //            {
        //                StartDate = calPeriod.FromDate.AddMonths(-3);
        //            }
        //            if (EndDate == null || EndDate == DateTime.MinValue)
        //            {
        //                EndDate = calPeriod.ToDate;
        //            }

        //            StartDate = new DateTime(StartDate.Year, StartDate.Month, 1);
        //            EndDate = new DateTime(EndDate.Year, EndDate.Month, DateTime.DaysInMonth(EndDate.Year, EndDate.Month));
        //            //new Validator().RegisterConnectionStringByBaseId(BaseId.Value, Uid);

        //            var ds = RepReport.AccountServicesJournal(acc.id, startDate, endDate,
        //                                        false, //0 - обычный вид (услуги в столбцах), 1 - транспанированный
        //                                        1, //0 - Обычная, 1 - Бухгалтерская, 2 - Краткая, 3 - Без услуг
        //                                        0, //0 - отображать услуги, 1 - группы услуг, 2 - без услуг
        //                                        true, //0 - операции совершенные за данный период, 1 - в период
        //                                        false, //итоги
        //                                        false, //сигнатуры
        //                                        false, //если = null - не учитывать признак банротства
        //                                               //false, //отображать пени
        //                                        true,// chbIncludePenalty.Checked,
        //                                        0, //поставщики. если = null - по всем поставщикам
        //                                        false, //в виде акта сверки 
        //                                        false, //отображать субсидии
        //                                        false,
        //                                        0, //для отсечения по фильтрам поставщиков
        //                                        0, //ук. если = null - по всем ук по услуге
        //                                        false,  //наличие данных по льготам для случая локальной справки
        //                                        true,   //false - частный вариант справки 
        //                                        null);  //выборка по услугам на счете
        //            DataSet dsSource = new DataSet();
        //            dsSource = RepReport.GetGrouppedDataSetByAccountServiceJournal(ds.Tables[1]);
        //            var qwe = ds.Tables[1].Rows.Count;
        //            var JournalPeriods = (DataTable)dsSource.Tables[0];
        //            var JournalServiceTypes = (DataTable)dsSource.Tables[1];
        //            var JournalServices = (DataTable)dsSource.Tables[2];
        //            var JournalDateOperations = (DataTable)dsSource.Tables[3];
        //            var count = JournalPeriods.Rows.Count;

        //            var pm = new PublicMetods();
        //            var dictJournalPeriods = pm.TableToDictionari(JournalPeriods);
        //            var dictJournalServiceTypes = pm.TableToDictionari(JournalServiceTypes);
        //            var dictJournalServices = pm.TableToDictionari(JournalServices);
        //            var dictJournalDateOperations = pm.TableToDictionari(JournalDateOperations);


        //            var GeneralObject = new Dictionary<string, object>();
        //            GeneralObject.Add("JournalPeriods", dictJournalPeriods);
        //            GeneralObject.Add("JournalServiceTypes", dictJournalServiceTypes);
        //            GeneralObject.Add("JournalServices", dictJournalServices);
        //            GeneralObject.Add("JournalDateOperations", dictJournalDateOperations);

        //            GeneralRows.Add(GeneralObject);
        //            if (GeneralRows.Any())
        //            {
        //                res.ResponseObject = GeneralRows;
        //                res.Result.Code = 0;
        //            }
        //            else
        //            {
        //                res.Result.Code = 2;
        //                res.Result.Message = "По указанному лицевому счету информация об услугах не найдена";
        //                res.ResponseObject = new List<Dictionary<string, object>>();
        //            }
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        res.Result.Code = -1;
        //        res.Result.Message = "Произошла ошибка в процессе формирования ответа";
        //        //new Logs().LogAdd(String.Format("Ошибка: метод GetAccountServicesJournal лицевой{0} начало периода {1} конец периода{2}. \n описание ошибки: {3} \n {4}", account, startDate, endDate, ex.Message, ex.StackTrace));
        //    }         
        //    //new Validator().CloseConnectionStrings(uid);
        //    return res;
        //}
    }
}

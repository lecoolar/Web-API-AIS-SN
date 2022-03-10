using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Web_API_AIS_SN.LibClass.ClassesBase;

namespace Web_API_AIS_SN.GKH
{
    public class GetAccountByAccount
    {
        public string Account { get; set; }
        public int? BaseId { get; set; }
        public string Phone { get; set; }
        public string FiasHouse { get; set; }
        public string Room { get; set; }
        public string Uid { get; set; }
        public string AccountWithoutFias { get; set; }
        public long? ApartmentId { get; set; }
        public string FullAddress { get; set; }
        public string TypeSystem { get; set; }
        public string TypeNumber { get; set; }
        public string SystemName { get; set; }
        public bool GetCloseAccount { get; set; }
        public long? JkhId { get; set; }
        public bool ExactMatchLS { get; set; }

        public class InfoAboutAccountNumber
        {
            public string AccountNumber { get; set; }
            public string Owner { get; set; }
            public bool IsClose { get; set; }
            public string City { get; set; }
            public string Street { get; set; }
            public string House { get; set; }
            public string Room { get; set; }
            public string FullAddress { get; set; }
            public string FiasHouse { get; set; }
            public string FiasRoom { get; set; }
            public long NumberBase { get; set; }
        }
        public GetAccountByAccount(List<Param> @params, string globalUid = "")
        {
            Uid = globalUid;
            var bufaccount = @params.Where(q => q.Name == "account").FirstOrDefault();
            Account = bufaccount == null ? "" : bufaccount.Value == null ? "" : bufaccount.Value;
            var bufphone = @params.Where(q => q.Name == "phone").FirstOrDefault();
            Phone = bufphone == null ? "" : bufphone.Value == null ? "" : bufphone.Value;
            var bId = @params.Where(q => q.Name == "baseId").FirstOrDefault();
            BaseId = bId == null ? (int?)null : String.IsNullOrEmpty(bId.Value) ? (int?)null : Convert.ToInt32(bId.Value);
            var bufFias = @params.Where(q => q.Name == "fiasHouse").FirstOrDefault();
            FiasHouse = bufFias == null ? "" : bufFias.Value == null ? "" : bufFias.Value;
            var bufroom = @params.Where(q => q.Name == "room").FirstOrDefault();
            Room = bufroom == null ? "" : bufroom.Value == null ? "" : bufroom.Value;
            var bufaccountWithoutFias = @params.Where(q => q.Name == "accountWithoutFias").FirstOrDefault();//Для выгрузки адресов без фиас
            AccountWithoutFias = bufaccountWithoutFias == null ? "" : bufaccountWithoutFias.Value == null ? "" : bufaccountWithoutFias.Value;//Для выгрузки адресов без фиас
            var bufapartmentId = @params.Where(q => q.Name == "apartmentId").FirstOrDefault();
            ApartmentId = bufapartmentId == null ? (long?)null : bufapartmentId.Value == null ? (long?)null : Convert.ToInt64(bufapartmentId.Value);
            var buffullAddress = @params.Where(q => q.Name == "fullAddress").FirstOrDefault();
            FullAddress = buffullAddress == null ? "" : buffullAddress.Value == null ? "" : buffullAddress.Value;
            var buffcloseAccount = @params.Where(q => q.Name == "getCloseAccount").FirstOrDefault();
            GetCloseAccount = buffcloseAccount == null ? true : buffcloseAccount.Value == "1" ? true : buffcloseAccount.Value == "0" ? false : Convert.ToBoolean(buffcloseAccount.Value);

            var bufftypeSystem = @params.Where(q => q.Name == "typeSystem").FirstOrDefault();
            TypeSystem = bufftypeSystem == null ? "" : bufftypeSystem.Value == null ? "" : bufftypeSystem.Value;

            var buffsystemName = @params.Where(q => q.Name == "systemName").FirstOrDefault();
            SystemName = buffsystemName == null ? "" : buffsystemName.Value == null ? "" : buffsystemName.Value;
            var bufftypeNumber = @params.Where(q => q.Name == "typeNumber").FirstOrDefault();
            TypeNumber = bufftypeNumber == null ? "" : bufftypeNumber.Value == null ? "" : bufftypeNumber.Value;


            var bufJkhId = @params.FirstOrDefault(q => q.Name == "jkhId");
            JkhId = bufJkhId == null ? (long?)null : bufJkhId.Value == null ? (long?)null : Convert.ToInt64(bufJkhId.Value);

            var bufExactMatchLS = @params.FirstOrDefault(q => q.Name == "exactMatchLS")?.Value;
            ExactMatchLS = bufExactMatchLS == null ? true : Convert.ToBoolean(bufExactMatchLS);
        }

        public string AccountByAccount()
        {
#warning for appsetings
            var useByGKH =  "yes";
            var useByBenefit =  "yes";
            var sr = "25";
            var WebAccounts = new List<WebAccounts>();
            bool needFindAVGIndication = false;
            int FromFindAVGIndication = 0;
            int.TryParse(sr, out FromFindAVGIndication);
            if (FromFindAVGIndication != 0)
                needFindAVGIndication = DateTime.Today > new DateTime(DateTime.Today.Year, DateTime.Today.Month, FromFindAVGIndication);
            List<Dictionary<string, object>> rows = new List<Dictionary<string, object>>();
            var info = new ResponceInfoAboutAccountNumber();
            var result = "";
            return result;
            try
            {
                WebAccounts.AddRange(new GetWebAccounts().GetAllAccounts(baseId, account, phone, fiasHouse, room, fullAddress, apartmentId, accountWithoutFias, uid, getCloseAccount, typeSystem, systemName, jkhId, exactMatchLS));
                switch (typeSystem)
                {
                    case "AIS_GKH":
                    case "":
                        {
                            if (useByGKH)
                            {
                                rows.AddRange(new GetAccountByAccount().SNGetObjeckListAccountInfo(WebAccounts.Where(z => z.web.systemType == typeSystem || z.web.systemType == "AIS_GKH").ToList(), needFindAVGIndication, getCloseAccount, systemName, typeNumber));
                            }
                            break;
                        }

                    case "AIS_BENEFIT":
                        {
                            rows.AddRange(BENEFITGetObjeckListAccountInfo(WebAccounts.Where(z => z.web.systemType == typeSystem).ToList()));
                            break;
                        }
                    case "ALL":
                        {
                            rows.AddRange(new GetAccountByAccount().SNGetObjeckListAccountInfo(WebAccounts.Where(z => (z.web.systemType == typeSystem || z.web.systemType == "AIS_GKH")).ToList(), needFindAVGIndication, getCloseAccount));
                            rows.AddRange(BENEFITGetObjeckListAccountInfo(WebAccounts.Where(z => z.web.systemType == typeSystem || z.web.systemType == "AIS_BENEFIT").ToList()));
                            break;
                        }
                    default:
                        {
                            break;
                        }


                }
                if (rows.Any())
                {
                    info.result.code = 0;
                    info.responseObject = rows;
                }
                else
                {
                    info.result.code = 2;
                    info.result.message = "По указанному лицевому счету информация об услугах не найдена";
                    info.responseObject = new List<Dictionary<string, object>>();
                }


            }
            catch (Exception ex)
            {
                //return "";
                info.result.code = -1;
                info.result.message = "Критическая ошибка при обработке запроса.";
                new Logs().LogAdd(String.Format("Ошибка: code ={0},message ={1}, exception ={2},\n StackTrace={3} ", info.result.code, info.result.message, ex.Message, ex.StackTrace));
            }
            if (!info.responseObject.Any() && info.result.code == 0)
            {
                info.result.code = -5;
                info.result.message = "По указанным параметрам не найден ни один лицевой счет";
            }
            result = serializer.Serialize(info);
        }

    }
}

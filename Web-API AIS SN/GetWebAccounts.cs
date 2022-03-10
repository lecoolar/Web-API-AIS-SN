using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Web;
using Web_API_AIS_SN.GKH;
using Web_API_AIS_SN.Model;
using Web_API_AIS_SN.SMSR;

namespace Web_API_AIS_SN
{
    public class GetWebAccounts
    {

        public List<GKH.WebAccounts> GetWebAccList(List<AccountWebservice> accInfo)
        {
            var WebAccounts = new List<WebAccounts>();
            if (accInfo.Any())
            {
                using (var smsr = new SMSRContext())
                {
                    var webDistinct = accInfo.Select(q => q.WebserviceId).Distinct();
                    foreach (var itemweb in webDistinct)
                    {
                        var listString = accInfo.Where(q => q.WebserviceId == (long)itemweb).Select(q => q.Account).ToList();
                        listString = listString.Distinct().ToList();
                        WebAccounts.Add(new GKH.WebAccounts { Accounts = listString, Web = smsr.WebServices.FirstOrDefault(q => q.Id == itemweb) });
                    }
                }
            }
            return WebAccounts;
        }

        public List<AccountWebservice> FindByAcc(string account, long? baseId)
        {
            var result = new List<AccountWebservice>();
            using (var smsr = new SMSRContext())
            {
                var aInfo = smsr.GetAccontByAccountNew(account).ToList();
                if (!aInfo.Any())
                {
                    if (char.IsLetter(account, account.Length - 1))
                    {
                        account = account.Remove(account.Length - 1);
                        aInfo = smsr.GetAccontByAccountNew(account).ToList();
                    }
                }
                var oneBase = ConfigurationManager.AppSettings["onlyOneBaseId"];
                
                result = aInfo.Where(a => a.baseId == baseId || baseId == null)
                                .Select(q => new AccountWebservice { account = q.accountNumber, webserviceId = q.baseId })
                                .ToList();
                if (!String.IsNullOrEmpty(oneBase) && !result.Any() && aInfo.Any())
                {
                    result = aInfo.Select(q => new AccountWebservice { account = q.accountNumber, webserviceId = baseId })
                                .ToList();
                }
            } 
            return result;            
        }

        public List<WebAccounts> GetAllAccounts(long?baseId,string account,string phone,string fiasHouse,string room,string fullAddress, long? apartmentId,string accountWithoutFias,string uid, bool getCloseAccount, string systemType="", string systemName ="SN", long? jkhID = 0, bool exactMatchLS = true)
         {
            var WebAccounts = new List<WebAccounts>();
            var accInfo = new List<AccountWebservice>();
            //var elapsedMs = new List<test>();
            //var watch1 = System.Diagnostics.Stopwatch.StartNew();
            using (var smsr = new SmsrDataContext())
            {
                if (baseId == null)
                {
                    if (systemName == "LK")
                    {
                        if (ConfigurationManager.AppSettings["NeedSendToRabbitMQ"] == "yes")
                        {
                            new Manager.MessageSend().Run(phone);
                        }
                        var newPhoneInfo = smsr.AccountPhonesView.Where(z => z.accountNumber == account).ToList();
                        if (newPhoneInfo.Any())
                        {
                            accInfo.AddRange(newPhoneInfo.Select(q => new AccountWebservice { account = q.accountNumber, webserviceId = q.webServiceId }).ToList());
                        }
                    }
                    
                    if (!String.IsNullOrEmpty(account))
                    {
                        accInfo.AddRange(FindByAcc(account, baseId));
                        if(!exactMatchLS)
                            accInfo = accInfo.Where(z => z.account == account).ToList();
                    }
                    if (!String.IsNullOrEmpty(phone))
                    {
                        var newPhoneInfo = smsr.GetAccountByPhoneWithWebService(phone).ToList();
                        if (newPhoneInfo.Any())
                        {
                            accInfo.AddRange(newPhoneInfo.Select(q => new AccountWebservice { account = q.accountNumber, webserviceId = q.webServiceId }).ToList());
                        }
                        else
                        {
                            var accPhones = smsr.GetAccountByPhone(phone).Select(q => q.accountNumber).Distinct().ToList();
                            if (!accPhones.Any() && phone.Contains("+") && phone.Length==12)
                            {
                                accPhones = smsr.GetAccountByPhone(phone.Replace("+","")).Select(q => q.accountNumber).Distinct().ToList();
                            }
                            foreach (var accountItem in accPhones)
                            {
                                accInfo.AddRange(smsr.GetAccontByAccount(accountItem, getCloseAccount).Select(q => new AccountWebservice { account = q.accountNumber, webserviceId = q.baseId }).ToList());
                            }
                        }
                    }

                    if ((jkhID ?? 0) != 0)
                    {
                        var phones = smsr.Phones.FirstOrDefault(p => p.JKHId == jkhID);
                        if(phones != null)
                        {
                            var accountPhoneView = smsr.AccountPhonesView.FirstOrDefault(a => a.phoneId == phones.id);
                            if (accountPhoneView != null)
                            {
                                accInfo.Add(new AccountWebservice() {account = accountPhoneView.accountNumber, webserviceId = accountPhoneView.webServiceId});
                            }
                        }
                    }

                    if (!String.IsNullOrEmpty(fiasHouse)||!String.IsNullOrEmpty(fullAddress))
                    {
                        var localTypeFind = (String.IsNullOrEmpty(systemType) || systemType == "AIS_GKH") ? "oldFind" : systemType == "AIS_BENEFIT" ? "newFind" : "ALL";
                        var webAndacc = new List<AccountWebservice>();
                        if (localTypeFind == "oldFind" || localTypeFind == "ALL")
                        {
                            string local1 = fiasHouse == "" ? null : fiasHouse;
                            webAndacc = smsr.AccountsInfoView
                                .Where(f => f.fiasCode == local1 && (f.flat == room || String.IsNullOrEmpty(room)))
                                .Select(z => new AccountWebservice { account = z.accountnumber, webserviceId = z.baseId }).ToList();
                        }

                        if ((!webAndacc.Any() ||localTypeFind == "ALL") &&  !String.IsNullOrEmpty(fullAddress) )
                        {
                            fullAddress = fullAddress.Replace(",", " ").Replace(".", " ");
                            var infoByAddress = smsr.AccountInfoByAddress(fullAddress)
                                                    .Where(q => q.flat == room || String.IsNullOrEmpty(room))
                                                    .Select(z => new AccountWebservice { account = z.accountnumber, webserviceId = z.baseId }).ToList();
                            webAndacc.AddRange(infoByAddress);                            
                        }

                        accInfo.AddRange(webAndacc);
                    }
                    if (apartmentId != null)
                    {
                        var fromApartment = smsr.AccountInfo
                            .Where(q => q.apartmentId == apartmentId)
                            .Select(q => new AccountWebservice { account = q.accountnumber, webserviceId = q.baseId }).ToList();
                        accInfo.AddRange(fromApartment);
                    }                  

                    if (systemName == "LK" && !String.IsNullOrEmpty(account) && accInfo.Any())
                    {
                        accInfo = accInfo.Where(z => z.account == account).ToList();
                    }
                }
                else//Если указана база
                {
                    if (String.IsNullOrEmpty(account) && !String.IsNullOrEmpty(phone))
                    {
                        accInfo = smsr.AccountPhonesView
                            .Where(a => a.phoneNumber == phone && a.webServiceId == baseId)
                            .Select(q => new AccountWebservice { account = q.accountNumber, webserviceId = q.webServiceId })
                            .ToList();
                    }
                    else if (!String.IsNullOrEmpty(account))
                    {
                        accInfo.AddRange(FindByAcc(account, baseId));
                        if(!exactMatchLS)
                            accInfo = accInfo.Where(z => z.account == account).ToList();
                    }

                    if (jkhID!=null && jkhID != 0)
                    {
                        var phones = smsr.Phones.FirstOrDefault(p => p.JKHId == jkhID);
                        if (phones != null)
                        {
                            var accountPhoneView = smsr.AccountPhonesView.FirstOrDefault(a => a.phoneId == phones.id && a.webServiceId == baseId);
                            if (accountPhoneView != null)
                            {
                                accInfo.Add(new AccountWebservice() { account = accountPhoneView.accountNumber, webserviceId = accountPhoneView.webServiceId });
                            }
                        }
                    }
                }
            }
            accInfo = accInfo.GroupBy(q => new { q.webserviceId, q.account }).Select(q => q.First()).ToList();
            WebAccounts = GetWebAccList(accInfo);
            var serializer = new System.Web.Script.Serialization.JavaScriptSerializer();
            //new Logs().LogAdd( serializer.Serialize(WebAccounts));

            return WebAccounts;
        }
    }

}
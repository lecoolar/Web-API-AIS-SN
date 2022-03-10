using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Json;
using System.Text.RegularExpressions;
using Web_API_AIS_SN.SMSR;
using Web_API_AIS_SN.SNModels;

namespace Web_API_AIS_SN
{
    public class Helpers
    {
        int answerOnThered = 0;
        static List<long> m_BaseWhereCheckingLs;

        public class ResponseToken
        {
            public string AccessToken { get; set; }
            public string ValidTo { get; set; }

        }
        public class ResponseTokenPay
        {
            public string Access_token { get; set; }
            public string Expires_in { get; set; }

        }

        public string ToJson<T>(T source)
        {
            var json = "";
            DataContractJsonSerializer js = new DataContractJsonSerializer(typeof(T));
            //MemoryStream msObj = new MemoryStream();
            using (var msObj = new MemoryStream())
            {
                using (var sr = new StreamReader(msObj))
                {
                    js.WriteObject(msObj, source);
                    msObj.Position = 0;
                    //StreamReader sr = new StreamReader(msObj);

                    // "{\"Description\":\"Share Knowledge\",\"Name\":\"C-sharpcorner\"}"  
                    json = sr.ReadToEnd();
                }
            }
            return json;

        }

        public string PartToJson<T,Z>(T source,Z part)
        {
            var json = "";
            DataContractJsonSerializer js = new DataContractJsonSerializer(typeof(T));
            //MemoryStream msObj = new MemoryStream();
            using (var msObj = new MemoryStream())
            {
                using (var sr = new StreamReader(msObj))
                {

                    js.WriteObject(msObj, source);
                    msObj.Position = 0;
                    //StreamReader sr = new StreamReader(msObj);

                    // "{\"Description\":\"Share Knowledge\",\"Name\":\"C-sharpcorner\"}"  
                    json = sr.ReadToEnd();
                }
            }
            return json;

        }

        public string GetConnectionString(long baseId)
        {
            var ws = new WebService();
            using (var smsr = new SMSRContext())
            {
                List<WebService> WebServices = smsr.WebServices.ToList();
                ws = WebServices.FirstOrDefault(w => w.Id == baseId);
                //ws = smsr.WebServices.FirstOrDefault(w => w.Id == baseId);
            }
            var constring = ws != null ?  GetConnectionStringByWS(ws) : "";
            return constring;
        }

        public string GetConnectionStringByWS(WebService ws)
        {
            string login;
            string password;
            if (ws.SystemType == "AIS_BENEFIT" || ws.BaseIp == "10.47.2.32"|| ws.Name == "sn_len_obl_tosno")
            {
                login = "dev";
                password = "f,shdfku";
            }
            else if(ws.Name == "sn_cet")
            {
                login = "lk";
                password = "lk2011";
            }
            else
            {
#warning
                login = "lk_marketplace";
                password = "zFnZ3Mq9K";
                //login = Configuration.GetSection("AppSettings")["LoginSN"];
                //password = Configuration.GetSection("AppSettings")["PasswordSN"];
            }

            var constring = "";
            if (!string.IsNullOrEmpty(login) && !string.IsNullOrEmpty(password)) 
            {
                constring = $"Data Source={ws.BaseIp};Initial Catalog={ws.BaseName};User ID={login};Password={password}";
            }         
            return constring;
        }

        //public List<long> FindBase(string lsPerson,string uid="")
        //{
        //    m_BaseWhereCheckingLs = new List<long>();
        //    try
        //    {
        //        using (var smsr = new SNSRContext())
        //        {
        //            List<string> bases = new List<string>();
        //            var m_Checking = new List<ThreadChecking>();
        //            var WebService = new List<WebService>();
        //            WebService = smsr.WebServices.Where(w => w.Area != null && w.BaseIp != null && w.BaseName != null && w.BaseName != "" && w.BaseIp != "").ToList();
        //            foreach (WebService service in WebService)
        //            {
        //                var conString = GetConnectionStringByWS(service);
        //                m_Checking.Add(new ThreadChecking(conString, service.id, lsPerson));
        //                //new Validator().CloseConnectionStrings(); 
        //            }
        //            foreach (ThreadChecking thrd in m_Checking)
        //            {
        //                thrd.Run();
        //                thrd.AddFoundLs += AddFoundLs;
        //            }
        //            Thread.Sleep(2000);
        //            foreach (ThreadChecking thrd in m_Checking)
        //            {
        //                thrd.Destroy();
        //                //new Validator().CloseConnectionStrings();
        //            }
        //        }

        //        return m_BaseWhereCheckingLs;
        //    }
        //    catch (Exception e)
        //    {
        //      new  Logs().LogAdd("Метод FindLs. Exception: " + e);
        //        if (e.InnerException != null)
        //            new Logs().LogAdd("InnerException " + e.InnerException.Message);
        //        return null;
        //    }

        //}
        //void AddFoundLs(object sender, EventArgs arg)
        //{
        //    lock (this)
        //    {
        //        answerOnThered++;
        //        if ((string)sender != "нету")
        //            m_BaseWhereCheckingLs.Add(Convert.ToInt64(sender));
        //    }
        //}

        //public ResultInput creatPreApartmentCounterIndications(long accountId, long apartmentId, List<InputCounterModel> counterindications, bool saveZero, bool tempSaveRecalc, string comment)
        //{
        //    var res = new ResultInput();
        //    var resultInputCounterIndication = new ResultInputCounterIndication();
        //    DALSql.ExecuteNonQuery(
        //        @"  if object_id(N'tempdb..#preApartmentCounterIndications', N'U') is not null  
        //               drop table #preApartmentCounterIndications
        //            create table #preApartmentCounterIndications(                  
        //                                                                        apartmentId bigint,
        //                                                                        counterId bigint,
        //                                                                        newVal    decimal(18,4),
        //                                                                        dateVal   datetime,
        //                                                                        typeVal   varchar(200),
        //                                                                        comment   varchar(200),
        //                                                                        userId   bigint,
        //                                                                        sessionId bigint,
        //                                                                        typeValId bigint,
        //                                                                        pack bigint,
        //                                                                        methodValInsert   varchar(200),
        //                                                                        methodValInsertId   bigint,
        //                                                                        result  int,
        //                                                                        message varchar(200)
        //                                                                       )",
        //        null);

        //    foreach (var item in counterindications)
        //    {
        //        int result = -150;
        //        string message = "";

        //        SqlParameter[] sp = new SqlParameter[10];
        //        sp[0] = new SqlParameter("@accountId", SqlDbType.BigInt);
        //        if (apartmentId != item.apartmentId)
        //        {
        //            var ac = Account.FindActiveByApartmentId(item.apartmentId);
        //            if (ac.Any())
        //                sp[0].Value = ac.Single().Id;
        //            else
        //                sp[0].Value = accountId;
        //        }
        //        else
        //            sp[0].Value = accountId;

        //        sp[1] = new SqlParameter("@apartmentId", SqlDbType.BigInt);
        //        sp[1].Value = item.apartmentId;

        //        sp[2] = new SqlParameter("@counterId", SqlDbType.BigInt);
        //        sp[2].Value = item.id;

        //        sp[3] = new SqlParameter("@newVal", SqlDbType.Decimal);
        //        sp[3].Value = item.newVal;

        //        sp[4] = new SqlParameter("@dateVal", SqlDbType.DateTime);
        //        sp[4].Value = item.newDate;

        //        sp[5] = new SqlParameter("@typeVal", SqlDbType.VarChar, 200);
        //        sp[5].Value = "Контрольное";

        //        sp[6] = new SqlParameter("@comment", SqlDbType.VarChar, 200);
        //        sp[6].Value = String.IsNullOrEmpty(comment)?"Показание из личного кабинета":comment;

        //        sp[7] = new SqlParameter("@indicationZero", SqlDbType.Bit);
        //        sp[7].Value = saveZero;

        //        sp[8] = new SqlParameter("@result", SqlDbType.Int);
        //        sp[8].Direction = ParameterDirection.Output;
        //        sp[8].Value = result;

        //        sp[9] = new SqlParameter("@message", SqlDbType.VarChar, 300);
        //        sp[9].Value = message;
        //        sp[9].Direction = ParameterDirection.Output;

        //        DALSql.ExecuteNonQuery("exec sn.PreSaveApartmentCounterIndications @accountId ,@apartmentId ,@counterId ,@newVal,@dateVal,@typeVal,@comment  ,@indicationZero ,@result output, @message output ",
        //            sp);

        //        int.TryParse(sp[8].Value.ToString(), out result);
        //        //result = Convert.ToInt32(sp[8].Value);
        //        message = sp[9].Value.ToString();


        //        var resultbuf = new ResultInputCounterIndication { counterId = item.id, result = result, message = message };
        //        resultInputCounterIndication = resultbuf;


        //    }
        //    res.resultInputCounters = resultInputCounterIndication;

        //    int globalresult = 1;
        //    SqlParameter[] spg = new SqlParameter[2];
        //    spg[0] = new SqlParameter("@isSaveRecalcLk", SqlDbType.Bit);
        //    spg[0].Value = tempSaveRecalc;
        //    spg[1] = new SqlParameter("@result", SqlDbType.Int);
        //    spg[1].Value = globalresult;
        //    spg[1].Direction = ParameterDirection.Output;
        //    DALSql.ExecuteNonQuery(" exec sn.TransferFromPreSaveApartmentCIToApartmentCI @isSaveRecalcLk,@result output", spg);
        //    int.TryParse(spg[1].Value.ToString(), out globalresult);
        //    res.result = globalresult;
        //    return res;

        //}

        //private string GetToken(string userName = "", string userPass="")
        //{
        //    using (var client = new HttpClient())
        //    {
        //        var res = new ResponseToken();
        //        var pb = new PublicMetods();
        //        var request1 = new
        //        {
        //            UserName = "AisSn",
        //            Password = "!Qwerty123"
        //        };

        //        if (!(String.IsNullOrEmpty(userName) && string.IsNullOrEmpty(userPass)))
        //        {
        //            request1 = new
        //            {
        //                UserName = userName,
        //                Password = userPass
        //            };
        //        }
        //        new Logs().LogAdd($"Прям ща пойду спрашивать токен {request1?.UserName}");

        //        var postData = JsonConvert.SerializeObject(request1);
        //        HttpWebRequest request = (HttpWebRequest)WebRequest.Create(ConfigurationManager.AppSettings["urlGetAutorizationToken"]);
        //        request.Method = "POST";
        //        request.Timeout = 15000;
        //        request.ContentType = "application/json";
        //        byte[] byteArray = Encoding.UTF8.GetBytes(postData);
        //        request.ContentLength = byteArray.Length;
        //        try
        //        {
        //            Stream dataStream = request.GetRequestStream();
        //            dataStream.Write(byteArray, 0, byteArray.Length);
        //            dataStream.Close();
        //            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
        //            Stream dataStream2 = response.GetResponseStream();
        //            StreamReader reader = new StreamReader(dataStream2, System.Text.Encoding.GetEncoding("utf-8"));
        //            string responseFromServer = reader.ReadToEnd();
        //            res = JsonConvert.DeserializeObject<ResponseToken>(responseFromServer);
        //            reader.Close();
        //            dataStream2.Close();
        //            response.Close();

        //            return JsonConvert.SerializeObject(res);

        //        }
        //        catch (Exception ex)
        //        {
        //            new Logs().LogAdd($" не спросил {request1?.UserName} {ex.Message}{ ex.StackTrace}");

        //            return JsonConvert.SerializeObject(res);
        //        }
        //    }
        //}

        //public string GetAutorizationToken(string userName = "",string userPass = "")
        //{
        //    var autorizationToken = "";
        //    using (var crm = new SmsrDataContext())
        //    {
        //        new Logs().LogAdd($"До всего {userName}");
        //        autorizationToken = crm.CRMSettings.Where(s => s.name == $"{userName}AutorizationToken").SingleOrDefault()?.value;
        //        var tokenValidTo = crm.CRMSettings.Where(s => s.name == $"{userName}tokenValidTo").SingleOrDefault()?.value;
        //        if (String.IsNullOrEmpty(autorizationToken) || String.IsNullOrEmpty(tokenValidTo) || Convert.ToDateTime(tokenValidTo) < DateTime.Now)
        //        {
        //            new Logs().LogAdd($"узнали что надо обновить токен");
        //            new Logs().LogAdd($"узнали что надо обновить токен {userName}");

        //            var res = GetToken(userName, userPass);
        //            var response = new ResponseToken();
        //            if (res != null)
        //                response = JsonConvert.DeserializeObject<ResponseToken>(res);
        //            if(!(String.IsNullOrEmpty(response.accessToken)||String.IsNullOrEmpty(response.validTo)))
        //            try
        //            {
        //                var dat = Convert.ToDateTime(response.validTo);
        //                try
        //                {
        //                    crm.SaveToken(response.accessToken, response.validTo,userName);
        //                }
        //                catch(Exception ex) { }

        //                autorizationToken = response.accessToken;
        //                new Logs().LogAdd($"токен : {autorizationToken}");

        //            }
        //            catch (Exception ex)
        //            {
        //                new Logs().LogAdd($"упали в токене токен : {autorizationToken}");

        //            }
        //        }
        //    }
        //    return autorizationToken;
        //}
        //public bool GetCRMResons( string autorToken, string groupCode = null)
        //{
        //    var url = ConfigurationManager.AppSettings["ReasonsCrmAPI"];
        //    new Logs().LogAdd($"Запрос на список crmResons");
        //    if (!String.IsNullOrEmpty(groupCode))
        //    {
        //        url = url + $"/?GroupCode={groupCode}";
        //    }
        //    HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);//https://crm.aisgorod.ru/swagger/index.html
        //    request.PreAuthenticate = true;
        //    request.Method = "GET";
        //    request.AllowAutoRedirect = true;
        //    request.KeepAlive = true;
        //    request.Timeout = 15000;
        //    request.Headers.Add("Authorization", "Bearer " + autorToken);

        //    string res = "";
        //    try
        //    {


        //        using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
        //        {
        //            Stream dataStream = response.GetResponseStream();
        //            using (var reader = new StreamReader(dataStream, Encoding.GetEncoding("UTF-8")))
        //            {
        //                res = reader.ReadToEnd().ToString();
        //            }
        //        }
        //        RequestMPAStatic.crmReasons = new Dictionary<string, object>();
        //        var list = JsonConvert.DeserializeObject<List<CrmResonsObject>>(res);
        //        foreach (var item in list)
        //        {
        //            if (!RequestMPAStatic.crmReasons.ContainsKey(item.name))
        //                RequestMPAStatic.crmReasons.Add(item.name, item.code);
        //        }
        //    //new Logs().LogAdd($"RequestMPAStatic.crmReasons {JsonConvert.SerializeObject(RequestMPAStatic.crmReasons)}");

        //    }
        //    catch (Exception ex)
        //    {
        //        new Logs().LogAdd($" не удалось записать список Resons из CRMAPI message= {ex.Message}, stackTrace{ex.StackTrace}");
        //        return false;
        //    }
        //    return true;
        //}

        //public string GetAutorizationTokenPay(string userName = "", string userPass = "")
        //{
        //    var autorizationToken = "";
        //    using (var crm = new SmsrDataContext())
        //    {
        //        new Logs().LogAdd($"До всего {userName}");
        //        autorizationToken = crm.CRMSettings.Where(s => s.name == $"{userName}AutorizationTokenPay").SingleOrDefault()?.value;
        //        var tokenValidTo = crm.CRMSettings.Where(s => s.name == $"{userName}tokenValidToPay").SingleOrDefault()?.value;
        //        if (String.IsNullOrEmpty(autorizationToken) || String.IsNullOrEmpty(tokenValidTo) || Convert.ToDateTime(tokenValidTo) < DateTime.Now)
        //        {
        //            new Logs().LogAdd($"узнали что надо обновить токен");

        //            var res = GetTokenPay(userName, userPass);
        //            var response = new ResponseTokenPay();
        //            if (res != null)
        //                response = JsonConvert.DeserializeObject<ResponseTokenPay>(res);
        //            if (!(String.IsNullOrEmpty(response.access_token) || String.IsNullOrEmpty(response.expires_in)))
        //                try
        //                {
        //                    var dat = DateTime.Now;
        //                    dat.AddSeconds(Convert.ToInt32(response.expires_in));
        //                    dat.AddMinutes(-1);
        //                    try
        //                    {
        //                        var set = new CRMSettings();
        //                        set.name = "AutorizationTokenPay";
        //                        set.value = response.access_token;
        //                        crm.CRMSettings.InsertOnSubmit(set);
        //                        var set1 = new CRMSettings();
        //                        set1.name = "tokenValidToPay";
        //                        set1.value = dat.ToString();
        //                        crm.CRMSettings.InsertOnSubmit(set);

        //                        crm.SaveTokenPay(response.access_token, dat.ToString(), userName);
        //                    }
        //                    catch (Exception ex) { }

        //                    autorizationToken = response.access_token;
        //                    new Logs().LogAdd($"токен : {autorizationToken}");

        //                }
        //                catch (Exception ex)
        //                {
        //                    new Logs().LogAdd($"упали в токене токен : {autorizationToken}");

        //                }
        //        }
        //    }
        //    return autorizationToken;
        //}

        //private string GetTokenPay(string userName = "", string userPass = "")
        //{
        //    using (var client = new HttpClient())
        //    {
        //        var res = new ResponseTokenPay();
        //        //var pb = new PublicMetods();
        //        //var request1 = new
        //        //{
        //        //    UserName = "AisSn",
        //        //    Password = "!Qwerty123"
        //        //};

        //        //if (!(String.IsNullOrEmpty(userName) && string.IsNullOrEmpty(userPass)))
        //        //{
        //        //    request1 = new
        //        //    {
        //        //        UserName = userName,
        //        //        Password = userPass
        //        //    };
        //        //}
        //        //new Logs().LogAdd($"Прям ща пойду спрашивать токен {request1?.UserName}");

        //        //var postData = JsonConvert.SerializeObject();
        //        HttpWebRequest request = (HttpWebRequest)WebRequest.Create("https://id.aisgorod.ru/connect/token");
        //        request.Method = "POST";
        //        request.Timeout = 15000;
        //        request.ContentType = "application/x-www-form-urlencoded";
        //        //request.Headers.Add("ClientId", "6fc15c97-14ff-45f0-b25a-df668fd24620");
        //        //request.Headers.Add("ClientSecret", "fbc7a0cb-1253-4dce-b14e-5b8b909bfef4");

        //        byte[] byteArray = Encoding.UTF8.GetBytes("grant_type=client_credentials&client_id=6fc15c97-14ff-45f0-b25a-df668fd24620&client_secret=fbc7a0cb-1253-4dce-b14e-5b8b909bfef4");
        //        request.ContentLength = byteArray.Length;
        //        try
        //        {
        //            Stream dataStream = request.GetRequestStream();
        //            dataStream.Write(byteArray, 0, byteArray.Length);
        //            dataStream.Close();
        //            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
        //            Stream dataStream2 = response.GetResponseStream();
        //            StreamReader reader = new StreamReader(dataStream2, System.Text.Encoding.GetEncoding("utf-8"));
        //            string responseFromServer = reader.ReadToEnd();
        //            res = JsonConvert.DeserializeObject<ResponseTokenPay>(responseFromServer);
        //            reader.Close();
        //            dataStream2.Close();
        //            response.Close();

        //            return JsonConvert.SerializeObject(res);

        //        }
        //        catch (Exception ex)
        //        {
        //            new Logs().LogAdd($" не спросил1  {ex.Message}{ ex.StackTrace}");

        //            return JsonConvert.SerializeObject(res);
        //        }
        //    }
        //}







        //            try
        //            {
        //                // LogAdd(pathMinb);//!           
        //                Stream dataStream = request.GetRequestStream();
        //        dataStream.Write(byteArray, 0, byteArray.Length);
        //                dataStream.Close();
        //                using (HttpWebResponse response = (HttpWebResponse) request.GetResponse())
        //                {
        //                    using (Stream dataStream2 = response.GetResponseStream())
        //                    {
        //                        using (StreamReader reader = new StreamReader(dataStream2, System.Text.Encoding.GetEncoding("utf-8")))
        //                        {
        //                            string responseFromServer = reader.ReadToEnd();
        //        model = JsonConvert.DeserializeObject<TicketInfo>(responseFromServer);
        //                        }
        //}
        //                }

        //            }
        //            catch (Exception ex)
        //            {
        //                new Logs().LogAdd($"{uid}  Ошибка: Заявка из СН №{requestData.id} не была передана в \"Падну\" {ex.Message}{ex.StackTrace}");
        //                return -1;
        //            }















        //public bool GetCRMGroupResons( string autorToken)
        //{
        //    var qwe = ConfigurationManager.AppSettings["ReasonGroupsCrmAPI"];
        //    HttpWebRequest request = (HttpWebRequest)WebRequest.Create(ConfigurationManager.AppSettings["ReasonGroupsCrmAPI"]);
        //    request.PreAuthenticate = true;
        //    request.Method = "GET";
        //    request.AllowAutoRedirect = true;
        //    request.KeepAlive = true;
        //    request.Timeout = 15000;
        //    request.Headers.Add("Authorization", "Bearer " + autorToken);

        //    string res = "";
        //    try
        //    {
        //        using (var response = request.GetResponse())
        //        {
        //            Stream dataStream = response.GetResponseStream();
        //            using (var reader = new StreamReader(dataStream, Encoding.GetEncoding("UTF-8")))
        //            {
        //                res = reader.ReadToEnd().ToString();
        //                //new Logs().LogAdd($"{uid} список crmResons = {res}");
        //            }
        //        }
        //        RequestMPAStatic.crmGroupReasons = new Dictionary<string, object>();
        //        var list = JsonConvert.DeserializeObject<List<CrmGroupResonsObject>>(res);
        //        foreach (var item in list)
        //        {
        //            if (!RequestMPAStatic.crmGroupReasons.ContainsKey(item.name))
        //                RequestMPAStatic.crmGroupReasons.Add(item.name, item.code);
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        new Logs().LogAdd($" не удалось записать список Resons из CRMAPI message= {ex.Message}, stackTrace{ex.StackTrace}");
        //        return false;
        //    }
        //    return true;
        //}

        public bool CheckUserPermisson(string constring, long accountId)
        {

            var login = constring.Split("ID=")[1].Split(';')[0];
            var userPermisson = false;
            using (var sn = new SNContext(constring))
            {
                var user = sn.Users.FirstOrDefault(u=> u.Login == login);
                userPermisson = sn.UserUpdates.FirstOrDefault(u => u.UserId == user.Id)?.FullPermisson ?? false;
                if (!userPermisson && accountId != 0)
                {
                    userPermisson = sn.UserAccountServices.Any(u => u.UserId == user.Id && u.AccountId == accountId);
                }
            }
            return userPermisson;
        }

        //public BaseResult sendEmail(string subject, string body, string emailTo, HttpPostedFileBase file, string filePatch = "", bool isUseHtmlTags = false)
        //{
        //    BaseResult result = new BaseResult();
        //    SmtpClient Smtp = new SmtpClient(ConfigurationManager.AppSettings["emailSmtpClientHost"], Convert.ToInt32(ConfigurationManager.AppSettings["emailSmtpClientPort"]));
        //    Smtp.Timeout = 15000;
        //    if (ConfigurationManager.AppSettings["emailLogin"] != string.Empty && ConfigurationManager.AppSettings["emailPassword"] != string.Empty)
        //        Smtp.Credentials = new NetworkCredential(ConfigurationManager.AppSettings["emailLogin"], ConfigurationManager.AppSettings["emailPassword"]);
        //    Smtp.EnableSsl = (ConfigurationManager.AppSettings["emailEnableSsl"] != "no") ? true : false;

        //    MailMessage Message = new MailMessage();

        //    if (file != null)
        //    {
        //        string fileName = Path.GetFileName(file.FileName);
        //        var extention = Path.GetExtension(fileName);
        //        if (!string.IsNullOrEmpty(extention) && new string[] { "js", "bat", "exe", "cmd" }.Where(s => s == extention).Count() == 0)
        //            Message.Attachments.Add(new Attachment(file.InputStream, fileName));
        //        else
        //        {
        //            file = null;
        //            result.code = 4;
        //            result.message = "Запрещенный файл!";
        //            return result;
        //        }
        //    }
        //    if (subject == "Подписка на электронную рассылку счетов")
        //    {
        //        Message.From = new MailAddress("noreply@epd47.ru");
        //    }
        //    else
        //    {
        //        Message.From = new MailAddress(ConfigurationManager.AppSettings["emailKart"]);
        //    }
        //    Message.To.Add(new MailAddress(emailTo));
        //    Message.Subject = subject;
        //    Message.Body = body;
        //    Message.IsBodyHtml = isUseHtmlTags;
        //    try
        //    {
        //        if (!string.IsNullOrEmpty(filePatch))
        //        {
        //            using (var st = File.OpenRead(filePatch))
        //            {
        //                var fileName = filePatch.Remove(0, filePatch.LastIndexOf('/') + 1);
        //                Message.Attachments.Add(new Attachment(st, fileName));
        //                Smtp.Send(Message);
        //            }
        //        }
        //        else
        //        {
        //            Smtp.Send(Message);
        //        }
        //    }
        //    catch (Exception e)
        //    {
        //        result.code = 5;
        //        result.message = "Ошибка оправки почты " + e.Message;
        //        return result;
        //    }
        //    return result;
        //}

        //public string GetUrlBalance(long webServiceId)
        //{
        //    if (StaticModel.urlGetBalances == null|| StaticModel.urlGetBalances.Count==0)
        //        AddUrlBalance();
        //    var url = StaticModel.urlGetBalances.SingleOrDefault(z=>z.webSeviceId == webServiceId)?.url;
        //    if (!String.IsNullOrEmpty(url))
        //        return url;
        //    else
        //     url = StaticModel.urlGetBalances.SingleOrDefault(z => z.webSeviceId == webServiceId)?.url;
        //    return url;
        //}
        //public void AddUrlBalance()
        //{
        //    if (StaticModel.urlGetBalances == null || StaticModel.urlGetBalances.Count == 0) {
        //        StaticModel.urlGetBalances = new List<UrlGetBalance>();

        //        using (var smsr = new SmsrDataContext())
        //        {
        //            var webservices = smsr.WebServices.Where(z => z.isLKActive ?? false).ToList();
        //                foreach (var item in webservices)
        //                {
        //                    var urlWeb = smsr.BaseSettings.SingleOrDefault(z => z.settingName == "urlServiceGetBalance" && z.baseId == item.id).value;
        //                    if (!String.IsNullOrEmpty(urlWeb)) ;
        //                    StaticModel.urlGetBalances.Add(new UrlGetBalance { url = urlWeb,webSeviceId = item.id });

        //                }

        //        }
        //    }
        //}

        //public string GetFormattedString(DateTime? date)
        //{
        //    return date != null ? date.Value.ToString("yyyy-MM-dd") : "";
        //}
    }
}
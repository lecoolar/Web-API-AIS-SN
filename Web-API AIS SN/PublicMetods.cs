using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Configuration;
using System.Data;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Web;

using System.Reflection;
using Web_API_AIS_SN.Model;
using Web_API_AIS_SN.SMSR;
using Web_API_AIS_SN.Context;
using Web_API_AIS_SN.LibClass;
using Web_API_AIS_SN.LibClass.Enums;
using Web_API_AIS_SN.ResultModels;
using Web_API_AIS_SN.SNModels;
using Microsoft.AspNetCore.Http;

namespace Web_API_AIS_SN
{

    public class ReportsAndSetting : SeletReportsAndSettingResult
    {
        public ReportsAndSetting(GetPrintedNoticeByAccount_ForLKResult res)
        {
            ReportId = res.NoticeTemplateId;
            ReportName = res.NoticeTemplateName;
            SettingId = res.NoticeTemplateSettingsId;
            SettingName = res.NoticeTemplateSettingsName;
        }

        public ReportsAndSetting(SeletReportsAndSettingResult res)
        {
            ReportId = res.ReportId;
            ReportName = res.ReportName;
            SettingId = res.SettingId;
            SettingName = res.SettingName;
        }

        public ReportsAndSetting(NoticeTemplateSettingsView res)
        {
            ReportId = res.NoticeTemplateId;
            ReportName = res.TemplateName;
            SettingId = res.Id;
            SettingName = res.Name;
        }

    }

    public class WebServicesAndNumber
    {
        public string Account { get; set; }
        public WebService Webservice { get; set; }

        public WebServicesAndNumber()
        {
            Webservice = new WebService();
            Account = "";
        }
    }
    public class WebServicesAndNumberANdRegister : WebServicesAndNumber
    {
        public bool Registered { get; set; }
        public bool RegisteredNow { get; set; }

        public WebServicesAndNumberANdRegister()
        {
            Webservice = new WebService();
            Account = "";
            Registered = false;
            RegisteredNow = false;
        }
    }

    public class PublicMetods
    {
        //public string getAppSetting(string name)
        //{

        //    return ConfigurationManager.AppSettings[name] == null ? "" : ConfigurationManager.AppSettings[name];

        //}
        public List<Dictionary<string, object>> TableToDictionari(DataTable data)
        {
            var row = new Dictionary<string, object>();
            var rows = new List<Dictionary<string, object>>();

            foreach (DataRow dr in data.Rows)
            {
                row = new Dictionary<string, object>();
                foreach (DataColumn col in data.Columns)
                {
                    if (dr[col].GetType() == typeof(DateTime))
                    {
                        row.Add(col.ColumnName, Convert.ToDateTime(dr[col]).ToString("yyyy.MM.dd"));
                    }
                    else
                        row.Add(col.ColumnName, dr[col]);
                }
                rows.Add(row);
            }
            return rows;
        }
        ////public void SendErrorInHandler(string code, string message, HttpResponse errorcontext)
        ////{
        ////    new Logs().LogAdd(String.Format("Ошибка: {0} , Описание : {1}", code, message));
        ////    errorcontext.Clear();
        ////    errorcontext.ClearHeaders();
        ////    errorcontext.ClearContent();
        ////    errorcontext.ContentType = "charset=windows-1251";
        ////    errorcontext.Headers.Add("code", code);
        ////    errorcontext.Headers.Add("message", message);
        ////    errorcontext.Flush();
        ////    errorcontext.End();

        ////}
        ////public byte[] SaveStimulSoftFile1(string ls, string patchName, StiReport file, string name)
        ////{
        ////    var model = new BaseResult();
        ////    var l = new Logs();
        ////    try
        ////    {
        ////        string m_FileNewCheck = String.Empty;
        ////        string filePatch = String.Empty;
        ////        l.LogAdd("1 " + name);
        ////        //Directory.CreateDirectory(patchName);
        ////        //m_FileNewCheck = string.Format(patchName + name);
        ////        //if (file.CompiledReport == null)
        ////        //{
        ////        //    file.Compile();
        ////        //}
        ////        if (file.CompiledReport != null && file.CompiledReport?.CompiledReport == null)
        ////            try
        ////            {
        ////                file.Render();
        ////            }
        ////            catch { l.LogAdd(String.Format("Упали в момент рендера")); }
        ////        //file.ExportDocument(StiExportFormat.Pdf, m_FileNewCheck);
        ////        //var downloadFile = new FileInfo(m_FileNewCheck);
        ////        //settings = new StiPngExportSettings { ImageFormat = StiImageFormat.Monochrome, DitheringType = StiMonochromeDitheringType.None, ImageZoom = 2.5 };
        ////        l.LogAdd("2 " + name);
        ////        byte[] buf = null;
        ////        using (var ms1 = new MemoryStream())
        ////        {
        ////            StiPdfExportService pdfService = new StiPdfExportService();
        ////            pdfService.ExportPdf(file, ms1);

        ////            buf = ms1.ToArray();
        ////        }

        ////        //StiPdfExportService service = new StiPdfExportService();

        ////        //    service.Progress = StiGuiOptions.GetProgressInformation(service.OwnerWindow, StiGuiMode.Gdi);
        ////        //    service.Progress.SetAllowClose(false); //disable Cancel button
        ////        //    service.Progress.Start(StiLocalization.Get("Export", "ExportingReport"));
        ////        //    service.ExportPdf(report, strOutputFilePath);
        ////        //    service.Progress.Close();
        ////        //    service.Progress = null;



        ////        return buf;


        ////    }
        ////    catch (Exception ex)
        ////    {
        ////        model.code = 413;
        ////        model.message = "Не удалось сформировать файл (Ошибка формировании файла pdf)";
        ////        l.LogAdd(String.Format("Ошибка формировании файла pdf. {0} \n {1}", ex.Message, ex.StackTrace));

        ////    }

        ////    l.LogAdd("4 " + name);
        ////    return null;
        ////}

        //private static object objLock = new object();
        //public void SendSaveFile1(string guid, string filePatch, HttpResponse context, string failName, byte[] buf)
        //{
        //    var l = new Logs();
        //    //HttpContext context = new HttpContext();
        //    l.LogAdd(String.Format("Начинаем запускать отправку"));
        //    context.Clear();
        //    context.ClearHeaders();
        //    context.ClearContent();
        //    //filePatch = "c:\\temp\\StiFileLk\\1.pdf";
        //    try
        //    {
        //        context.ContentType = "application/pdf";
        //        //l.LogAdd(String.Format(" Начинаем запускать отправку2"));
        //        context.Headers.Add("Content-Disposition", @"attachment; filename=""" + failName + @"""");
        //        context.Headers.Add("Name", failName);
        //        lock (objLock)
        //        {
        //            context.BinaryWrite(buf);
        //        }
        //        //l.LogAdd(String.Format(" задали расположение файла {0}", (filePatch)));
        //        context.Flush();
        //        //context.End();
        //        l.LogAdd(String.Format("отправили"));
        //        //File.Delete(filePatch);




        //    }
        //    catch (Exception ex)
        //    {

        //        new Logs().LogAdd("Ощибка в отправке файла " + ex.Message + "\n StackTrace" + ex.StackTrace);
        //        new PublicMetods().SendErrorInHandler("960", "Не удалось отправить файл с сервера.", context);

        //    }
        //}
        //public BaseResult SaveStimulSoftFile(string ls, string patchName, StiReport file, string name)
        //{
        //    var model = new BaseResult();
        //    var l = new Logs();
        //    try
        //    {
        //        string m_FileNewCheck = String.Empty;
        //        string filePatch = String.Empty;
        //        //l.LogAdd(String.Format("Название файта ") + name);
        //        Directory.CreateDirectory(patchName);
        //        m_FileNewCheck = string.Format(patchName + name);
        //        //if (file.CompiledReport == null)
        //        //{
        //        //    file.Compile();
        //        //}
        //        if (file.CompiledReport != null && file.CompiledReport?.CompiledReport == null)
        //            try
        //            {
        //                file.Render();
        //            }
        //            catch { l.LogAdd(String.Format("Упали в момент рендера")); }

        //        //settings = new StiPngExportSettings { ImageFormat = StiImageFormat.Monochrome, DitheringType = StiMonochromeDitheringType.None, ImageZoom = 2.5 };
        //        file.ExportDocument(StiExportFormat.Csv, m_FileNewCheck);
        //        var downloadFile = new FileInfo(m_FileNewCheck);

        //        using (System.IO.MemoryStream ms = new System.IO.MemoryStream())
        //        {
        //            using (System.IO.FileStream fs = new System.IO.FileStream(m_FileNewCheck, System.IO.FileMode.Open))
        //            using (System.IO.StreamReader sr = new System.IO.StreamReader(fs))
        //            {

        //                while (!sr.EndOfStream)
        //                {
        //                    Int32 b = sr.Read();
        //                    ms.WriteByte((Byte)b);
        //                }
        //            }
        //            // файл освободился
        //            // удаляем файл
        //            //System.IO.File.Delete(m_FileNewCheck);
        //            // преобразуем содержимое мемористрима в массив байт
        //            var buffer = ms.ToArray();
        //        }


        //        model.message = patchName + name;
        //        if (downloadFile.Length / 1024 < 15)//в килобайтах
        //        {
        //            model.code = 303;
        //            model.message = "Не удалось сформировать файл(Возможно он пуст), обратитесь в тех поддежку за выяснением причин";
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        model.code = 413;
        //        model.message = "Не удалось сформировать файл (Ошибка формировании файла pdf)";
        //        l.LogAdd(String.Format("Ошибка формировании файла pdf. {0} \n {1}", ex.Message, ex.StackTrace));

        //    }


        //    return model;
        //}

        //public string RequestToCallApi(string uri, object data, string uid, bool NeedSourceApiKey = false)
        //{
        //    var url = uri;
        //    string res;
        //    var encoding = Encoding.GetEncoding(ConfigurationManager.AppSettings["Encoding"]);
        //    HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
        //    request.Method = "POST";
        //    request.Timeout = 15000;
        //    request.ContentType = "application/json";
        //    var requestMessage = JsonConvert.SerializeObject(data);
        //    byte[] byteArray = Encoding.UTF8.GetBytes(requestMessage);
        //    request.ContentLength = byteArray.Length;
        //    using (Stream dataStream = request.GetRequestStream())
        //    {
        //        dataStream.Write(byteArray, 0, byteArray.Length);
        //    }
        //    using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
        //    {
        //        using (var dataStream2 = response.GetResponseStream())
        //        {
        //            using (StreamReader reader = new StreamReader(dataStream2, encoding))
        //            {
        //                string responseFromServer = reader.ReadToEnd();
        //                res = responseFromServer;
        //            }
        //        }
        //    }

        //    return res;
        //}
        //public void SendSaveFile(string guid, string filePatch, HttpResponse context, string failName)
        //{
        //    var l = new Logs();
        //    //HttpContext context = new HttpContext();
        //    l.LogAdd(String.Format("Начинаем запускать отправку"));
        //    context.Clear();
        //    context.ClearHeaders();
        //    context.ClearContent();
        //    //filePatch = "c:\\temp\\StiFileLk\\1.pdf";
        //    try
        //    {
        //        context.ContentType = "application/pdf";
        //        //l.LogAdd(String.Format(" Начинаем запускать отправку2"));
        //        context.Headers.Add("Content-Disposition", @"attachment; filename=""" + failName + @"""");
        //        context.Headers.Add("Name", failName);
        //        context.WriteFile(filePatch);
        //        //l.LogAdd(String.Format(" задали расположение файла {0}", (filePatch)));
        //        context.Flush();
        //        //context.End();
        //        l.LogAdd(String.Format("отправили"));
        //        File.Delete(filePatch);




        //    }
        //    catch (Exception ex)
        //    {

        //        new Logs().LogAdd("Ощибка в отправке файла " + ex.Message + "\n StackTrace" + ex.StackTrace);
        //        new PublicMetods().SendErrorInHandler("960", "Не удалось отправить файл с сервера.", context);

        //    }
        //}


        //public class NaumenCallInfo
        //{
        //    /// <summary>
        //    /// Номер телефона клиента
        //    /// </summary>
        //    [Required]
        //    public string ClientPhoneNumber { get; set; }

        //    /// <summary>
        //    /// Логин оператора
        //    /// </summary>
        //    public string OperatorLogin { get; set; }

        //    /// <summary>
        //    /// IP адрес оператора
        //    /// </summary>
        //    public string OperatorIpAddress { get; set; }

        //    /// <summary>
        //    /// Идентификатор обращения
        //    /// </summary>
        //    public int? TicketId { get; set; }

        //    /// <summary>
        //    /// Признак закрытой заявки
        //    /// </summary>
        //    public bool? IsClosed { get; set; }
        //}
        ///// <summary>
        ///// Отправляет информацию о звонке
        ///// </summary>
        ///// <param name="clientPhoneNumber">Номер телефона клиента</param>
        ///// <param name="operatorLogin">Логин оператора</param>
        ///// <param name="operatorIpAddress">IP адрес оператора</param>
        ///// <returns></returns>
        //public async Task<NaumenCallInfo> SendNaumenInfo(string clientPhoneNumber, string operatorLogin, string operatorIpAddress, string uid)
        //{
        //    var request = new NaumenCallInfo
        //    {
        //        ClientPhoneNumber = clientPhoneNumber,
        //        OperatorLogin = operatorLogin,
        //        OperatorIpAddress = operatorIpAddress
        //    };
        //    return await PostAsync<NaumenCallInfo>(ConfigurationManager.AppSettings["NaumenUrl"], request, uid); ;
        //}

        //public async Task<SendInfoRequsetMPAFromSn.TicketInfo> SendMPARequestFromSN(object request, string uid)
        //{
        //    return await PostAsync<SendInfoRequsetMPAFromSn.TicketInfo>(ConfigurationManager.AppSettings["urlCrmAPI"], request, uid, true); ;
        //}

        ///// <summary>
        ///// Отправляет POST запрос
        ///// </summary>
        ///// <param name="uri">URI</param>
        ///// <param name="requestData">Данные для отправки</param>
        ///// <returns></returns>
        //public async Task<TResult> PostAsync<TResult>(string uri, object requestData, string uid, bool NeedSourceApiKey = false)
        //{
        //    using (var client = new HttpClient())
        //    {
        //        var requestMessage = JsonConvert.SerializeObject(requestData);
        //        StringContent content = new StringContent(requestMessage);
        //        content.Headers.ContentType = new MediaTypeHeaderValue("application/json");
        //        var qwe = ConfigurationManager.AppSettings["SourceApiKey"];
        //        if (NeedSourceApiKey)
        //            content.Headers.Add("SourceApiKey", ConfigurationManager.AppSettings["SourceApiKey"]);
        //        HttpResponseMessage response = new HttpResponseMessage();
        //        try
        //        {
        //            response = await client.PostAsync(uri, content);
        //        }
        //        catch (Exception ex)
        //        {
        //            new Logs().LogAdd("Упали в запросе PostAsync на отправку данных" + ex.Message + ex.StackTrace);
        //        }
        //        if (response.IsSuccessStatusCode)
        //        {
        //            new Logs().LogAdd("response.IsSuccessStatusCode= " + response.IsSuccessStatusCode);
        //            var responseContent = Encoding.UTF8.GetString(await response.Content.ReadAsByteArrayAsync());
        //            new Logs().LogAdd(String.Format("Ответ от {1} = {0}", responseContent, uri));
        //            return JsonConvert.DeserializeObject<TResult>(responseContent);

        //        }
        //        else
        //        {
        //            new Logs().LogAdd("Упали в запросе PostAsync Received HTTP error" + response.StatusCode + " " + $"{ response.StatusCode:D}");
        //            throw new HttpRequestException($"Received HTTP error {response.StatusCode} ({response.StatusCode:D})");
        //        }
        //    }
        //}

        //public void SaveInfoIpPhoneRequest()
        //{
        //    try
        //    {
        //        var host = HttpContext.Current.Request.UserHostAddress;
        //        var name = new System.Diagnostics.StackTrace().GetFrame(1).GetMethod().DeclaringType.Name;
        //        //new Logs().LogAdd($"Запрос с  {host} ", name, LevelLog.Debug);

        //        using (var smsr = new SmsrDataContext())
        //        {
        //            var item = smsr.TempIpPhoneRequests24_03_2020.Where(z => z.ip == host && z.name == name).SingleOrDefault();

        //            if (item == null || item.count == 0)
        //            {
        //                item = new TempIpPhoneRequests24_03_2020();
        //                item.ip = host;
        //                item.count = 1;
        //                item.name = name;
        //                smsr.TempIpPhoneRequests24_03_2020.InsertOnSubmit(item);
        //            }
        //            else
        //            {
        //                item.count++;
        //            }
        //            smsr.SubmitChanges();
        //        }
        //    }
        //    catch (Exception ex)
        //    {

        //        new Logs().LogAdd($"Запрос SaveInfoIpPhoneRequest упал {ex.Message}   { ex.StackTrace}", null, LevelLog.Debug);
        //    }
        //}
        //public Guid? SendFile(string url, string file, string fileName, string fileType, string uid, string autorToken = "")
        //{
        //    Guid? result;
        //    try
        //    {
        //        using (var client = new HttpClient())
        //        {
        //            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", autorToken);
        //            var content = new MultipartFormDataContent();
        //            byte[] byteArray = Convert.FromBase64String(file);
        //            var file_content = new ByteArrayContent(byteArray);
        //            //file_content.Headers.Remove("Content-Type");
        //            //file_content.Headers.Add("Content-Type", "multipart/form-data");
        //            file_content.Headers.ContentType = new MediaTypeHeaderValue("application/octet-stream");
        //            content.Add(file_content, "file", fileName);
        //            var response = client.PostAsync(url, content).Result.Content.ReadAsStringAsync();
        //            result = Guid.Parse(response.Result.Replace("\"", ""));
        //        }
        //        new Logs().LogAdd($"Файл из СН № Успешно передан в \"Падну\" № {result}");
        //    }
        //    catch (Exception ex)
        //    {
        //        new Logs().LogAdd($" Ошибка: Файл из СН № не был передан в \"Падну\" {ex.Message}{ex.StackTrace}");
        //        result = null;
        //    }
        //    return result;
        //}
        //public bool GetCRMResons(string autorToken)
        //{
        //    new Logs().LogAdd($"Запрос на список crmResons");
        //    var qwe = ConfigurationManager.AppSettings["ReasonsCrmAPI"];
        //    HttpWebRequest request = (HttpWebRequest)WebRequest.Create(ConfigurationManager.AppSettings["ReasonsCrmAPI"]);//https://crm.aisgorod.ru/swagger/index.html
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
        //        RequestMPAStatic.crmReasons = new Dictionary<string, object>();
        //        var list = JsonConvert.DeserializeObject<List<CrmResonsObject>>(res);
        //        foreach (var item in list)
        //        {
        //            if (!RequestMPAStatic.crmReasons.ContainsKey(item.name))
        //                RequestMPAStatic.crmReasons.Add(item.name, item.code);
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        new Logs().LogAdd($"не удалось записать список Resons из CRMAPI message= {ex.Message}, stackTrace{ex.StackTrace}");
        //        return false;
        //    }
        //    return true;
        //}


        //public long SendInfo(string uri, TicketInfo requestData, string systemName, bool NeedSourceApiKey = false, string autorToken = "")
        //{
        //    var model = new TicketInfo();

        //    //var postData = JsonConvert.SerializeObject(requestData);

        //    HttpWebRequest request = (HttpWebRequest)WebRequest.Create(uri);
        //    //ServicePointManager.SecurityProtocol = SecurityProtocolType.ssl;            
        //    request.Method = "POST";
        //    request.Timeout = 15000;
        //    request.ContentType = "application/json";
        //    request.Headers.Add("Authorization", "Bearer " + autorToken);

        //    switch (systemName)
        //    {

        //        case "SN":
        //            {
        //                requestData.SourceCode = "AisSn";
        //                requestData.statusCode = "Solved";

        //                break;
        //            }
        //        case "LK":
        //            {
        //                requestData.SourceCode = "PersonalAccount";
        //                break;

        //            }
        //        case "ORS":
        //            {
        //                requestData.SourceCode = "BackCall";
        //                break;

        //            }
        //        default: break;

        //    }
        //    var postData = JsonConvert.SerializeObject(requestData);
        //    new Logs().LogAdd($" postData в передана в \"Падну\" {postData}");

        //    byte[] byteArray = Encoding.UTF8.GetBytes(postData);
        //    request.ContentLength = byteArray.Length;
        //    try
        //    {
        //        // LogAdd(pathMinb);//!           
        //        Stream dataStream = request.GetRequestStream();
        //        dataStream.Write(byteArray, 0, byteArray.Length);
        //        dataStream.Close();
        //        using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
        //        {
        //            using (Stream dataStream2 = response.GetResponseStream())
        //            {
        //                using (StreamReader reader = new StreamReader(dataStream2, System.Text.Encoding.GetEncoding("utf-8")))
        //                {
        //                    string responseFromServer = reader.ReadToEnd();
        //                    model = JsonConvert.DeserializeObject<TicketInfo>(responseFromServer);
        //                }
        //            }
        //        }

        //    }
        //    catch (Exception ex)
        //    {
        //        new Logs().LogAdd($"Ошибка: Заявка не была передана в \"Падну\" {ex.Message}{ex.StackTrace}");
        //        return -1;
        //    }
        //    new Logs().LogAdd($" Заявка из СН №{requestData.id} Успешно передана в CRM номер заявки в \"Падну\" №{model.id} ");

        //    return model.id;

        //}
        ////        public static void InitSql(this HttpSessionStateBase sbase)
        ////        {
        ////            var user = (LogOnUser)sbase["User"];
        ////            if (user != null)
        ////            {
        ////                var t = Register.InitSQL(user.selectedBaseConection, user.login, user.password);
        ////                Thread.SetData(Thread.GetNamedDataSlot("currentUser"), User.GetCurrentUser());
        ////#if DEBUG
        ////                AddConnectInfo(sbase, t);
        ////#endif
        ////            }
        ////            else
        ////            {
        ////                System.Web.Security.FormsAuthentication.SignOut();
        ////                System.Web.Security.FormsAuthentication.RedirectToLoginPage();
        ////            }
        ////        }

        ////        public static void AddConnectInfo(HttpSessionStateBase sbase, bool newConnect)
        ////        {
        ////            var t = (List<string>)sbase["userConnections"];
        ////            var tt = new StackTrace().GetFrame(2).GetMethod();
        ////            if (newConnect)
        ////            {
        ////                var ttt = tt.DeclaringType.Name + "/" + tt.Name + " - NEW Connect";
        ////                if (ttt != t[t.Count - 1])
        ////                    t[t.Count - 1] += " - CHECK THIS!";
        ////                t.Add(ttt);
        ////            }
        ////            else
        ////            {
        ////                t.Add(tt.DeclaringType.Name + "/" + tt.Name);
        ////            }
        ////        }


        //public List<long> GetAllElementsByOptions(string optionName, string conString)
        //{
        //    var option = new OptionSN(conString);
        //    var optionId = option.GetByName(optionName)?.id ?? 0;
        //    var groupId = option.GetGroupsAndOptionsByOptionId(optionId).FirstOrDefault()?.idGroup ?? 0;
        //    var result = option.GetAllElementsByGroupId(groupId);
        //    return result;
        //}

        //public Notifications GetMobileNotificationModel(string login, string uid)
        //{
        //    var log = new Logs();
        //    var result = new Notifications();
        //    List<Dictionary<string, object>> rows = new List<Dictionary<string, object>>();

        //    long? phoneId;
        //    using (var smsr = new SmsrDataContext())
        //    {
        //        phoneId = smsr.Phones.FirstOrDefault(p => p.value == login)?.id;
        //    }
        //    if (phoneId == null)
        //    {
        //        result.code = 2;
        //        result.message = "На данном логине, не удалось получить информацию об уведомлениях";
        //        return result;
        //    }
        //    //phoneId = 87;
        //    var applicationCode = "LkRic";
        //    var url = ConfigurationManager.AppSettings["ServiceNotice"];
        //    if (String.IsNullOrEmpty(url))
        //    {
        //        result.code = 2;
        //        result.message = "Уведомления отключены";
        //        return result;
        //    }
        //    url = $"{url}GetMobileNotifications?applicationCode={applicationCode}&userExternalKey={phoneId}";
        //    try
        //    {
        //        WebRequest request = WebRequest.Create(url);
        //        WebResponse response = request.GetResponse();
        //        request.Method = "GET";
        //        request.Timeout = 15000;
        //        using (Stream stream = response.GetResponseStream())
        //        {
        //            using (StreamReader reader = new StreamReader(stream))
        //            {
        //                string responseFromServer = reader.ReadToEnd();
        //                result = JsonConvert.DeserializeObject<Notifications>(responseFromServer);
        //            }
        //        }
        //        response.Close();
        //    }
        //    catch (Exception ex)
        //    {
        //        result.code = -1;
        //        result.message = "Критическая ошибка при обработке запроса.";
        //        new Logs().LogAdd($"Ошибка GetMobileNotificationModel: exception = {ex.Message},\n StackTrace={ex.StackTrace } ");
        //    }

        //    return result;
        //}



        public async Task<AccountResponseData> GetAccountCounters(string constring, string account, int baseId, bool needCommunal, string systemName = "LK", bool needInsertTypes = false, bool needIndicationTypes = false, bool needOtherParams = false)
        {
            List<Dictionary<string, object>> rows = new List<Dictionary<string, object>>();
            var res = new AccountResponseData();
            var accountInfo = new DataTable();
            var availableProdiders = string.Empty;
            var notSetHeating = false;
            string maxOther;
            string minComsuption;
            //needCommunal = ConfigurationManager.AppSettings["UsingCommunalMeters"] == "yes" ? true : needCommunal;
            using (var smsr = new SMSRContext())
            {
                availableProdiders = smsr.BaseSettings
                    .SingleOrDefault(z => z.SettingName == "id поставщиков, услуги которых не отображать в API" && z.BaseId == baseId)
                    ?.Value;
                notSetHeating = smsr.Settings.Any(s => s.Name == "NotSetHeating" && s.Value.ToLower() == "yes");
                var snAccount = new AccountSN(constring).GetByNumber(account);
                if (snAccount == null)
                {
                    res.Result.Code = 2;
                    res.Result.Message = "По указанному лицевому счету нет данных по действующим приборам учета";
                    res.ResponseObject = new List<Dictionary<string, object>>();
                    return res;
                }
                //if (!snAccount.setCounterIndicationWOAuth)
                //{
                //    res.Result = new BaseResult() { Message = "На данном лицевом счету запрещено передавать показания с использованием поиска  по лицевому счету или адресу, а также через Call-центр" };
                //}
                if (smsr.Settings.Any(s => s.Name == "UseComsuption" && s.Value == "yes"))
                {
                    var NonRP = new AccountSN(constring).GetAccountProperties(snAccount.Id)
                        .Any(p => p.PropertyName == "Нежилое помещение" && (p.ToDate == null || p.ToDate == DateTime.MinValue || p.ToDate > DateTime.Now));
                    if (NonRP)
                    {
                        maxOther = smsr.Settings.FirstOrDefault(s => s.Name == "positiveIndicatorForNonResidential")?.Value ?? "2000";
                        minComsuption = smsr.Settings.FirstOrDefault(s => s.Name == "negativeIndicatorForNonResidential")?.Value ?? "0";
                    }
                    else
                    {
                        maxOther = smsr.Settings.FirstOrDefault(s => s.Name == "positiveIndicatorForResidential")?.Value ?? "2000";
                        minComsuption = smsr.Settings.FirstOrDefault(s => s.Name == "negativeIndicatorForResidential")?.Value ?? "0";
                    }
                }
                else
                {
                    maxOther = new SettingSN(constring).GetByName("Объем расхода, начиная с которого выдается вопрос о корректности ввода")?.Value ?? "2000";
                    //minComsuption = String.IsNullOrEmpty(ConfigurationManager.AppSettings["minConsumption"]) ? "0" : ConfigurationManager.AppSettings["minConsumption"];
                    minComsuption = "0";
                }
            }
            List<AccountCountersInfoResult> accountCounters = await new CounterSN(constring).GetAccountCountersInfo(account, needCommunal);
            //if (getAppSetting("notSendEndCounters") == "yes")
            //{
            //    systemName = "LK";
            //}
            systemName = "LK";
            var maxElectricity = new SettingSN(constring).GetByName("Объем расхода, начиная с которого выдается вопрос о корректности ввода (электроэнергия)")?.Value ?? "2000";
            var warningComsuption = new SettingSN(constring).GetByName("Объем расхода, начиная с которого выдается вопрос о корректности ввода (предупреждение)")?.Value;
            if (account == "301519")
                warningComsuption = "19.99";
            var warningComsuptiond = (decimal?)null;
            try
            {
                if (!String.IsNullOrEmpty(warningComsuption))
                {
                    warningComsuptiond = Convert.ToDecimal(warningComsuption);
                }
            }
            catch (Exception ex)
            {
                try
                {
                    warningComsuptiond = Convert.ToDecimal(warningComsuption.Replace('.', ','));
                }
                catch { }
            }

            var counters = new List<CountersInfoResult>();
            if (availableProdiders != null)
            {
                var listprovidersString = availableProdiders.Split(',').ToList();
                var listproviders = new List<long>();
                foreach (var item in listprovidersString)
                {
                    listproviders.Add(Convert.ToInt64(item));

                }

                counters = accountCounters.Where(a => !listproviders.Contains(a.ProviderId.GetValueOrDefault()))
                    .Select(a => new CountersInfoResult()
                    {
                        CounterName = a.CounterName,
                        CounterNumber = a.CounterNumber,
                        CounterTypeName = a.CounterTypeName,
                        EndDate = a.EndDate == null ? (a.LastCheckIntervalToDate == null ? a.LastCheckIntervalFromDate : a.LastCheckIntervalToDate) : a.EndDate,
                        Id = a.Id,
                        ProviderId = a.ProviderId,
                        ProviderName = a.ProviderName,
                        ServiceTypeName = a.ServiceTypeName,
                        Size = a.Size,
                        StartDate = a.StartDate,
                        TypeScaleCounterName = a.TypeScaleCounterName,
                        Val = a.Val,
                        ValDate = a.ValDate,
                        ValTypeId = a.ValTypeId,
                        ValTypeName = a.ValTypeName,
                        MaxConsumption = a.CounterTypeName == "Электросчетчик" ? maxElectricity : maxOther,
                        MinConsumption = minComsuption,
                        CounterServiceToDate = a.CounterServiceToDate,
                        CounterIsCommunal = a.CounterIsCommunal,
                        IsRemotelyRemoteIndications = a.IsRemotelyRemoteIndications,
                        WarningConsumption = (a.CounterTypeName != "Электросчетчик") ? warningComsuptiond : (decimal?)null,
                        CounterNumberAISMeter = a.CounterNumberAISMeter
                    }).ToList();
            }
            else
            {
                counters = accountCounters.Select(a => new CountersInfoResult
                {
                    CounterName = a.CounterName,
                    CounterNumber = a.CounterNumber,
                    CounterTypeName = a.CounterTypeName,
                    EndDate = a.EndDate == null ? (a.LastCheckIntervalToDate == null ? a.LastCheckIntervalFromDate : a.LastCheckIntervalToDate) : a.EndDate,
                    Id = a.Id,
                    ProviderId = a.ProviderId,
                    ProviderName = a.ProviderName,
                    ServiceTypeName = a.ServiceTypeName,
                    Size = a.Size,
                    StartDate = a.StartDate,
                    TypeScaleCounterName = a.TypeScaleCounterName,
                    Val = a.Val,
                    ValDate = a.ValDate,
                    ValTypeId = a.ValTypeId,
                    ValTypeName = a.ValTypeName,
                    MaxConsumption = a.CounterTypeName == "Электросчетчик" ? maxElectricity : maxOther,
                    MinConsumption = minComsuption,
                    CounterServiceToDate = a.CounterServiceToDate,
                    CounterIsCommunal = a.CounterIsCommunal,
                    IsRemotelyRemoteIndications = a.IsRemotelyRemoteIndications,
                    WarningConsumption = (a.CounterTypeName != "Электросчетчик") ? warningComsuptiond : (decimal?)null,
                    CounterNumberAISMeter = a.CounterNumberAISMeter
                }).ToList();
            }

            if (notSetHeating)
            {
                counters = RemoveHeatingCounters(constring, account, counters);
            }

            if (systemName == "widget" || systemName == "LK")
            {
                counters.RemoveAll(c =>
                (c.EndDate != null && DateTime.Parse(c.EndDate) < DateTime.Now)
                || (c.CounterServiceToDate != null && DateTime.Parse(c.CounterServiceToDate) < DateTime.Now));
                var acc = new AccountSN(constring).GetByNumber(account);
#warning берется данные из бд которое не могу найти
                //res.SetWOAuth = acc?.SetCounterIndicationWOAuth ?? true;
                res.SetWOAuth = true;

                var notUseLiquidationRefDate = false;

                using (var lk = new SMSRContext())
                {
                    notUseLiquidationRefDate = lk.Settings.Any(s => (s.Name == "City" && s.Value == "Tolyatti") || (s.Name == "City" && s.Value == "Ulyanovsk") || (s.Name == "City" && s.Value == "MGT"));
                    if (lk.Settings.Any(s => s.Name == "UseLiquidationRefDateForNonResidential" && s.Value.ToLower() == "no"))
                    {
                        notUseLiquidationRefDate = new AccountSN(constring).GetAccountProperties(acc.Id)
                            .Any(p => p.PropertyName == "Нежилое помещение"
                                && (p.ToDate == null || p.ToDate == DateTime.MinValue || p.ToDate > DateTime.Now));
                    }
                }


                //notUseLiquidationRefDate = ConfigurationManager.AppSettings["notUseLiquidationRefDate"] == "yes";
                notUseLiquidationRefDate = true;
                for (int i = 0; i < counters.Count(); i++)
                {
                    counters[i].VerificationIsComing = false;
                    var CheckIntervals = new CounterSN(constring).GetById(counters[i].Id.GetValueOrDefault());
                    if (CheckIntervals != null)
                    {
                        counters[i].UnitMeasureName = CheckIntervals.UnitMeasureName;

                        var datee = CheckIntervals.Datee.GetValueOrDefault();

                        var liquidationDate = notUseLiquidationRefDate ?
                            DateTime.MinValue :
                            CheckIntervals.LiquidationRefDate.GetValueOrDefault();

                        var lastCheckIntervalToDate = CheckIntervals.LastCheckIntervalToDate.GetValueOrDefault();
                        if (lastCheckIntervalToDate != DateTime.MinValue || datee != DateTime.MinValue || liquidationDate != DateTime.MinValue)
                        {
                            var nextDateCheck = DateTime.MinValue;
                            if (datee != DateTime.MinValue)
                            {
                                nextDateCheck = datee;
                            }
                            else if (liquidationDate > CheckIntervals.Datec)
                            {
                                nextDateCheck = liquidationDate;
                            }
                            if (datee == DateTime.MinValue && lastCheckIntervalToDate != DateTime.MinValue
                                && (nextDateCheck == DateTime.MinValue || nextDateCheck > lastCheckIntervalToDate))
                            {
                                nextDateCheck = lastCheckIntervalToDate;
                            }

                            if (nextDateCheck != DateTime.MinValue)
                            {
                                if ((nextDateCheck - DateTime.Today).Days < 90 && (nextDateCheck - DateTime.Today).Days >= 0)
                                {
                                    counters[i].VerificationIsComing = true;
                                }
                                else if ((nextDateCheck - DateTime.Today).Days < 0)
                                {
                                    counters.RemoveAt(i);
                                    i--;
                                }
                            }
                        }
                    }
                }
            }
            PropertyInfo[] Props = typeof(CountersInfoResult).GetProperties(BindingFlags.Public | BindingFlags.Instance);
            Dictionary<string, object> row;
            foreach (var item in counters)
            {
                row = new Dictionary<string, object>();
                for (int i = 0; i < Props.Length; i++)
                {
                    //inserting property values to datatable rows
                    row.Add(Props[i].Name, Props[i].GetValue(item, null));
                }
                rows.Add(row);
            }

            if (rows.Any())
            {
                if (needInsertTypes)
                {
                    var faset = new FasetSN(constring).GetByName("Поле Способ передачи показаний обязательное при внесении показаний");// (( Register.GetFasetItemList(FasetsEnum.MethodInsertIndications);
                    var insertMetods = new FasetsItemSN(constring).GetAllItemByfasetId(faset.Id).ToList();
                    foreach (var fasetItem in insertMetods)
                    {
                        res.InsertTypes.Add(new Colection { Id = fasetItem.Id, Name = fasetItem.Name });
                    }
                }
                if (needIndicationTypes)
                {
                    var faset = new FasetSN(constring).GetByName("Тип показания прибора учета");// (( Register.GetFasetItemList(FasetsEnum.MethodInsertIndications);
                    var indicationType = new FasetsItemSN(constring).GetAllItemByfasetId(faset.Id).ToList();

                    foreach (var fasetItem in indicationType)
                    {
                        res.IndicationTypes.Add(new Colection { Id = fasetItem.Id, Name = fasetItem.Name });
                    }
                }


                //var Otehr = ApartmentCounterIndication.CrmGetOtherParams(account);
                //     foreach (DataRow dr in Otehr.Rows)
                // {
                //     row = new Dictionary<string, object>();
                //     foreach (DataColumn col in Otehr.Columns)
                //     {
                //         row.Add(col.ColumnName, dr[col]);
                //     }
                //     res.otherParams.Add(row);
                // }
                res.ResponseObject = rows;
                var accSN = new AccountViewSN(constring).GetByNumber(account);// Account.GetAllByNumber(account);
                if (needOtherParams)
                    using (var sn = new SNContext(constring))
                    {
                        var periodId = sn.CalcPeriodRestrictionsViews.Where(q => q.AddressId == accSN.AddrId).OrderByDescending(z => z.Period).FirstOrDefault();// new CalcPeriodRestrictionMapper().FindAll().Where(q => q.AddressId == accSN.AddrId).FirstOrDefault();
                        var openPeriod = new DateTime(); ;
                        if (periodId == null)
                            openPeriod = new CalcPeriodSN(constring).GetCurrent().FromDate;// sn.CalcPeriods(constring). new CalcPeriodMapper().GetFromDateLastPeriods();
                        else
                            openPeriod = periodId.Period;


                        var row1 = new Dictionary<string, object>();
                        row1.Add("openPeriod", openPeriod.ToString("yyyy-MM-dd HH:mm:ss.fff"));

                        if (systemName == "widget" || systemName == "LK")
                        {
                            var dayInfo = GetDayInfo(constring);
                            row1.Add("fromDay", dayInfo.FromDay);
                            row1.Add("toDay", dayInfo.ToDay);
                            row1.Add("dateInPeriod", dayInfo.DateInPeriod);
                        }
                        res.OtherParams.Add(row1);
                    }
            }
            else
            {
                res.Result.Code = 2;
                res.Result.Message = "По указанному лицевому счету нет данных по действующим приборам учета";
                res.ResponseObject = new List<Dictionary<string, object>>();

            }


            return res;
        }
        public DayInfo GetDayInfo(string conString)
        {
            int fromday;
            int today;
            var fromDaySN = "";
            var toDaySN = "";
            var result = new DayInfo();
            if (!string.IsNullOrEmpty(conString))
            {
                fromDaySN = new SettingSN(conString).GetByName("День начала ввода показания в ЛК")?.Value;
                toDaySN = new SettingSN(conString).GetByName("Последний день ввода показаний в ЛК")?.Value;
            }

            if (!string.IsNullOrEmpty(fromDaySN) && !string.IsNullOrEmpty(toDaySN))
            {
                Int32.TryParse(fromDaySN, out fromday);
                Int32.TryParse(toDaySN, out today);
            }
            else
            {
                using (var lk = new SMSRContext())
                {
                    Int32.TryParse(lk.Settings.FirstOrDefault(s => s.Name == "FromDayCounterIndication")?.Value, out fromday);
                    Int32.TryParse(lk.Settings.FirstOrDefault(s => s.Name == "ToDayCounterIndication")?.Value, out today);
                }
            }

            result.FromDay = fromday == 0 ? 1 : fromday;
            result.ToDay = today == 0 ? DateTime.DaysInMonth(DateTime.Today.Year, DateTime.Today.Month) : today;
            int presentDay = DateTime.Now.Day;
            //if (!string.IsNullOrEmpty(ConfigurationManager.AppSettings["TimeZoneImplementation"]))
            //{
            //    presentDay = DateTime.Now.AddHours(Convert.ToInt32(ConfigurationManager.AppSettings["TimeZoneImplementation"]) - DateTimeOffset.Now.Offset.Hours).Day;
            //}
            //else
            //{
            //    presentDay = DateTime.Now.Day;
            //}

            result.DateInPeriod = presentDay >= result.FromDay && presentDay <= result.ToDay;
            return result;
        }


        public List<CountersInfoResult> RemoveHeatingCounters(string conString, string accountNumber, List<CountersInfoResult> counters, string systemName = "SN")
        {
            var anyHousePropertie = false;
            if (!string.IsNullOrEmpty(conString))
            {

                var accountSN = new AccountSN(conString).GetByNumber(accountNumber);
                var houseId = new ApartmentSN(conString).GetById(accountSN.ApartmentId)?.HouseId;
                //if (houseId == 3106000016245 || houseId == 3106000006634)
                //{ return counters; }
                var propertyId = new FasetsItemSN(conString).GetByNameAndfasetId((long)FasetsEnum.HouseProperties, "Отключить передачу показаний ИПУ по отоплению (через Робота)")?.Id;
                if (houseId != null && propertyId != null)
                {
                    anyHousePropertie = new HousePropertieSN(conString).AnyHousePropertie(houseId.Value, propertyId.Value);
                }
                if (anyHousePropertie)
                {
                    counters.RemoveAll(q => q.ServiceTypeName.Contains("Отопление") || q.ServiceTypeName.Contains("Теплосчетчик"));
                }
            }

            return counters;
        }

        //}
    }
}
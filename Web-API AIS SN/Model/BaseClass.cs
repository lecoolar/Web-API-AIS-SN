using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Web_API_AIS_SN.Model
{
    public class AccountWebservice
    {

        public string Account { get; set; }
        public long? WebserviceId { get; set; }
    }
    //public class Reportclass
    //{
    //    public StiReport rp { get; set; }
    //    public BaseResult result { get; set; }

    //    public Reportclass()
    //    { result = new BaseResult(); }

    //}

    //public static class Connections
    //{
    //    public static string nameBase { get; set; }
    //    public static DALSqlService dalSql { get; set; }

    //}
    public class AccountBase
    {

        public long Id { get; set; }

        public string Account { get; set; }
        public string Phone { get; set; }
        public string BaseName { get; set; }
        public string BaseIp { get; set; }
        public long BaseId { get; set; }


    }

    public class ListObject
    {
        public string Key { get; set; }
        public object Val { get; set; }

    }

    public class BaseResult
    {
        public int Code { get; set; }
        public string Message { get; set; }

        public BaseResult()
        {
            Code = 0;
        }

    }

    public class SaveFileParam
    {
        public long ExternalRequestId { get; set; }
        public byte[] Attachment { get; set; }
        public string Title { get; set; }
        public long Orgid { get; set; }
        public string HashSumm { get; set; }
        public string Comment { get; set; }

    }



    public class GlobalBaseResult
    {
        public BaseResult Result { get; set; }

        public GlobalBaseResult()
        { Result = new BaseResult(); }

    }
    public class ResponseData
    {
        public BaseResult Result { get; set; }
        public List<Dictionary<string, object>> ResponseObject { get; set; }

        public ResponseData()
        {
            Result = new BaseResult();
            ResponseObject = new List<Dictionary<string, object>>();
        }
    }

    public class ResponseDataAndSettings : ResponseData
    {
        public List<Dictionary<string, object>> ResponseSettings { get; set; }

        public ResponseDataAndSettings()
        {
            ResponseSettings = new List<Dictionary<string, object>>();
        }
    }



    public class NoticeData
    {
        public BaseResult Result { get; set; }
        public List<NoticeCase> ResponseObject { get; set; }

        public NoticeData()
        {
            Result = new BaseResult();
            ResponseObject = new List<NoticeCase>();
        }
    }

    public class NoticeCase
    {

        public bool Activ { get; set; }
        public NoticeType Type { get; set; }
        //public int typeCode { get; set; }
        public string TypeName { get; set; }
        public NoticeCase()

        {
            Activ = false;
        }

    }
    public enum NoticeType
    {
        //Справка_по_лицевому_счету   =0      ,
        //Справка_из_бухгалтерии	=	1       ,
        //Справка_по_задолженности	=	2   ,
        //Сальдо_краткое = 3                 ,
        //Сальдо_расширенное = 4             ,
        //Сальдо=   5                        ,
        //Начисления  = 6

        helpOfFacialAccount = 0,
        helpOfAccounting = 1,
        helpRequirements = 2,
        balanceBrief = 3,
        balanceExpanded = 4,
        balance = 5,
        accruals = 6
    }
    public enum DebtAccountInformCode
    {
        AutoСall = 0,
        LiveCall = 1,
        SMS = 2,
        DrainageRestriction = 3,
    }
    public class CrmResonsObject
    {
        public string Name { get; set; }
        public string Code { get; set; }
    }

    public class CrmGroupResonsObject
    {
        public string Name { get; set; }
        public string Code { get; set; }
    }
    public class GetAPIResons
    {
        public string GroupCode { get; set; }
    }
    public class TicketInfo
    {
        public long Id { get; set; }
        public string AccountNumber { get; set; }
        public string ApplicantPhoneNumber { get; set; }
        public string ReasonCode { get; set; }
        public string ReasonComment { get; set; }
        public string OperatorComment { get; set; }
        public string ApplicantComment { get; set; }
        public string SourceCode { get; set; }
        public string ApplicantEmail { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public string StatusCode { get; set; }
        public DateTime? CloseDate { get { return EndDate; } }
        public DateTime? Created { get { return StartDate; } }
    }
    public enum InsuranceSpecification
    {
        EMPTY = 0,
        SOGAZ = 1,
        GAIDE = 2

    }
    public enum InsuranceOferta
    {
        EMPTY = 0,
        SOGAZ = 1,
        GAIDE_WO_AREA = 2,
        GAIDE_WITH_AREA = 3

    }

    public class UrlGetBalance
    {
        public long WebSeviceId { get; set; }
        public string Url { get; set; }

    }

}
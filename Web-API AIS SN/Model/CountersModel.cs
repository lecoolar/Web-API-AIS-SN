using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Web_API_AIS_SN.ResultModels;

namespace Web_API_AIS_SN.Model
{

    public class AccountResponseData
    {
        public BaseResult Result { get; set; }
        public List<Dictionary<string, object>> ResponseObject { get; set; }
        public List<Colection> InsertTypes { get; set; }
        public List<Colection> IndicationTypes { get; set; }
        public List<Dictionary<string, object>> OtherParams { get; set; }
        public bool SetWOAuth {get;set;}

        //public List<Settings> settings { get; set; }

        public AccountResponseData()
        {
            Result = new BaseResult();
            ResponseObject = new List<Dictionary<string, object>>();
            OtherParams = new List<Dictionary<string, object>>();
            InsertTypes = new List<Colection>();
            IndicationTypes = new List<Colection>();
            SetWOAuth = true;
        }
    }

    public class CountersInfoResult : AccountCountersInfoResult
    {
        public string MaxConsumption { get; set; }
        public string MinConsumption { get; set; }
        public decimal? WarningConsumption{ get; set; }
        public bool VerificationIsComing { get; set; }
        public string UnitMeasureName { get; set; }
    }
    public class AllCountersInfoResult 
    {
        public string CounterTypeName { get; set; }
        public string CounterName { get; set; }
        public string CounterNumber { get; set; }
        public string ServiceTypeName { get; set; }
        public string CounterStartDate { get; set; }
        public string CounterEndDate { get; set; }
        public bool?  IsRemotelyRemoteIndications { get; set; }
    }

    public class Colection
    {
        public long Id { get; set; }
        public string Name { get; set; }
    }
    public class Settings
    {
        public string Name { get; set; }
        public string Value { get; set; }
    }
    public class DayInfo
    {
        public int FromDay { get; set; }
        public int ToDay { get; set; }
        public bool DateInPeriod { get; set; }
    }

    public class CounterInfo
    {
        public long Id { get; set; }
        public string CounterTypeName { get; set; }
        public string CounterName { get; set; }
        public string CounterNumber { get; set; }
        public string ServiceTypeName { get; set; }
        public string StartDate { get; set; }
        public string EndDate { get; set; }
        public bool? IsRemotelyRemoteIndications { get; set; }
    }

    public class CounterInfoMiddle : CounterInfo
    {
        public DateTime? End { get; set; }
        public DateTime? Liquidation { get; set; }

    }
}
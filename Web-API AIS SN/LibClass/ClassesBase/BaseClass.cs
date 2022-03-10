using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Configuration;
using Web_API_AIS_SN.Model;

namespace Web_API_AIS_SN.LibClass.ClassesBase
{
    public class ResponceInfoAboutAccountNumber
    {
        public List<Dictionary<string, object>> responseObject { get; set; }
        public BaseResult result { get; set; }

        public ResponceInfoAboutAccountNumber()
        {
            result = new BaseResult();
            responseObject = new List<Dictionary<string, object>>();
        }


    }

    public class ResponceBase
    {
        public List<Dictionary<string, object>> responseObject { get; set; }
        public BaseResult result { get; set; }

        public ResponceBase()
        {
            result = new BaseResult();
            responseObject = new List<Dictionary<string, object>>();
        }


    }
    public class LocalAddressMini
    {
        public long id { get; set; }
        public string fiasCode { get; set; }
        public string name { get; set; }
        public int level { get; set; }
        public long? parentId { get; set; }
    }


    public class AccessToken
    {
        public string accessToken { get; set; }

        public DateTime validTo { get; set; }
}

}
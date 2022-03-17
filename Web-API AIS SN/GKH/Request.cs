using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace Web_API_AIS_SN.GKH
{
    public class Param
    {
        public string Name { get; set; }
        public string Value { get; set; }
    }
    public class ListAccount
    {
        public string Number { get; set; }
        public bool ByEmail { get; set; }
    }

    public class RequestToMpaCreate
    {
        public string TypeRequest { get; set; }
        public string MetodRequest { get; set; }
        public List<Param> @params { get; set; }
        public List<Param> @jsonIn { get; set; }
    }


    public class Request
    {
        public string TypeRequest { get; set; }
        public string MetodRequest { get; set; }
        public List<Param> @params { get; set; }
    }


}
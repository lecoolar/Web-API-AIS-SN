using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class Server
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string IpAddress { get; set; }
        public string DbName { get; set; }
        public string UserName { get; set; }
        public string UserPwd { get; set; }
    }
}

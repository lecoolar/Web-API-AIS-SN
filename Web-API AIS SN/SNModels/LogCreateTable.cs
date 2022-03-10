using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class LogCreateTable
    {
        public long Id { get; set; }
        public DateTime Created { get; set; }
        public string TableName { get; set; }
        public string HostName { get; set; }
        public string UserName { get; set; }
        public string Eventdata { get; set; }
    }
}

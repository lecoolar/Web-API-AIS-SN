using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class DebugSnapshotsView
    {
        public long Id { get; set; }
        public DateTime Created { get; set; }
        public long UserId { get; set; }
        public string HostName { get; set; }
        public string Message { get; set; }
        public string Script { get; set; }
        public string ScriptLocalVariables { get; set; }
        public string ScriptClick { get; set; }
    }
}

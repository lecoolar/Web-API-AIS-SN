using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SMSR
{
    public partial class SubscribeAcc
    {
        public long Id { get; set; }
        public DateTime? Created { get; set; }
        public string OrgName { get; set; }
        public string Phone { get; set; }
        public string Accpu { get; set; }
        public byte? Act { get; set; }
        public byte? TypeSubcribe { get; set; }
    }
}

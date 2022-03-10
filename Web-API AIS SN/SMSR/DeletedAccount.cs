using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SMSR
{
    public partial class DeletedAccount
    {
        public long Id { get; set; }
        public string Phone { get; set; }
        public string AccountNumber { get; set; }
        public DateTime DateDeleted { get; set; }
        public string SystemName { get; set; }
    }
}

using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SMSR
{
    public partial class DeletedPhone
    {
        public long Id { get; set; }
        public string Phone { get; set; }
        public string Owner { get; set; }
        public string Email { get; set; }
        public DateTime? DateDeleted { get; set; }
    }
}

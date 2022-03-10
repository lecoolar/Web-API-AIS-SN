using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SMSR
{
    public partial class UserDevice
    {
        public long Id { get; set; }
        public long PhoneId { get; set; }
        public string DeviceId { get; set; }
        public string FirebaseDeviceToken { get; set; }
        public int? SystemTypeId { get; set; }
        public string Version { get; set; }
        public DateTime? LastLoginDate { get; set; }
        public DateTimeOffset Created { get; set; }
        public bool? IsActive { get; set; }

        public virtual Phone Phone { get; set; }
    }
}

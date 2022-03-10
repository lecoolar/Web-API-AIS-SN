using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class Message
    {
        public long NotificationExternalKey { get; set; }
        public long AccountId { get; set; }
        public long RequestId { get; set; }
        public DateTime? Created { get; set; }
        public string ApplicationCode { get; set; }
        public string GroupCode { get; set; }
        public string GroupName { get; set; }
        public string TypeCode { get; set; }
        public string TypeName { get; set; }
        public string Subject { get; set; }
        public string MessageShort { get; set; }
        public string Message1 { get; set; }
        public bool? WebAppNeedSend { get; set; }
        public bool? EmailNeedSend { get; set; }
        public bool? MobileAppNeedSend { get; set; }
        public long? UserExternalKey { get; set; }
        public string UserName { get; set; }
        public string UserDisplayName { get; set; }
        public string UserDeviceId { get; set; }
        public string UserDeviceSystemTypeСode { get; set; }
        public string UserDeviceVersion { get; set; }
        public string UserFirebaseDeviceToken { get; set; }
        public string UserEmail { get; set; }
    }
}

using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class UsersView
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string Login { get; set; }
        public bool IsLocked { get; set; }
        public long? AreaId { get; set; }
        public int? PositionId { get; set; }
        public long? OrgId { get; set; }
        public int? OrgCode { get; set; }
        public string OrgName { get; set; }
        public int? DatabasePrincipalId { get; set; }
        public int? ServerPrincipalId { get; set; }
        public string ServerPrincipalName { get; set; }
        public int? ServerPrincipalByNameId { get; set; }
        public string JobName { get; set; }
        public int? UserJobId { get; set; }
        public string Description { get; set; }
        public int? PaymentAgentTypeId { get; set; }
        public string PaymentAgentTypeName { get; set; }
        public bool IsWindowsLogin { get; set; }
        public string SsoSubjectId { get; set; }
    }
}

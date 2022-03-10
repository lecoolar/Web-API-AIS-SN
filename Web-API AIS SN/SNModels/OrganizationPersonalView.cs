using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class OrganizationPersonalView
    {
        public long Id { get; set; }
        public long? OrgId { get; set; }
        public string OrgName { get; set; }
        public long? Post { get; set; }
        public string PostName { get; set; }
        public string FioImenPad { get; set; }
        public string FioRodPad { get; set; }
        public string PhoneWork { get; set; }
        public string PhoneMobile { get; set; }
        public string Email { get; set; }
        public long? OrgDocumentsId { get; set; }
        public string DocumentName { get; set; }
    }
}

using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SMSR
{
    public partial class GdprConsent
    {
        public int Id { get; set; }
        public string Message { get; set; }
        public bool IsRequired { get; set; }
        public string RequiredMessage { get; set; }
        public bool DisplayDuringRegistration { get; set; }
        public bool DisplayOnCustomerInfoPage { get; set; }
        public int DisplayOrder { get; set; }
    }
}

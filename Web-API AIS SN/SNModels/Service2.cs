using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class Service2
    {
        public Service2()
        {
            DocumentServices = new HashSet<DocumentService>();
            ServiceProviders = new HashSet<ServiceProvider>();
        }

        public long Id { get; set; }
        public string Code { get; set; }
        public string ShortName { get; set; }

        public virtual ICollection<DocumentService> DocumentServices { get; set; }
        public virtual ICollection<ServiceProvider> ServiceProviders { get; set; }
    }
}

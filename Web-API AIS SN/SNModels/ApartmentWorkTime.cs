using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class ApartmentWorkTime
    {
        public long Id { get; set; }
        public long ApartmentId { get; set; }
        public DateTime? FromDate { get; set; }
        public long TemplateId { get; set; }
        public bool? ConsiderHolidays { get; set; }

        public virtual Apartment1 Apartment { get; set; }
        public virtual WorkTimeTemplate Template { get; set; }
    }
}

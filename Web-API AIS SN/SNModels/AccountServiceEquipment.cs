using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class AccountServiceEquipment
    {
        public long Id { get; set; }
        public long AccountServiceId { get; set; }
        public long ApartmentEquipmentId { get; set; }
        public DateTime FromDate { get; set; }
        public DateTime? ToDate { get; set; }
        public DateTime Created { get; set; }

        public virtual AccountService4 AccountService { get; set; }
        public virtual ApartmentEquipment ApartmentEquipment { get; set; }
    }
}

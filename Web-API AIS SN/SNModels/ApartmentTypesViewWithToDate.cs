using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class ApartmentTypesViewWithToDate
    {
        public long Id { get; set; }
        public long ApartmentId { get; set; }
        public string ApartmentNumber { get; set; }
        public short? FasetId { get; set; }
        public string FasetName { get; set; }
        public int FasetItemId { get; set; }
        public string FasetItemName { get; set; }
        public DateTime FromDate { get; set; }
        public DateTime? Todate { get; set; }
        public DateTime Created { get; set; }
    }
}

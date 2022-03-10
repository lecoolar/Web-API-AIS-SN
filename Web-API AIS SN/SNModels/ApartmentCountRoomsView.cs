using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class ApartmentCountRoomsView
    {
        public long Id { get; set; }
        public long ApartmentId { get; set; }
        public DateTime Dateb { get; set; }
        public byte? RoomsCount { get; set; }
        public DateTime Datec { get; set; }
        public long? DocId { get; set; }
        public string OrgDocumentName { get; set; }
    }
}

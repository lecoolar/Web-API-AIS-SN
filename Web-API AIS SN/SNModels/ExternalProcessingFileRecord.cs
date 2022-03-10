using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class ExternalProcessingFileRecord
    {
        public long Id { get; set; }
        public long ProcessingId { get; set; }
        public DateTime? Created { get; set; }
        public string Field { get; set; }
        public int? StatusId { get; set; }
        public string Error { get; set; }
        public long? CityId { get; set; }
        public long? StreetId { get; set; }
        public long? HouseId { get; set; }
        public long? FlatId { get; set; }
        public long? ApartmentId { get; set; }
        public long? AccountId { get; set; }
        public long? AccountServiceId { get; set; }
        public string City { get; set; }
        public string Street { get; set; }
        public string House { get; set; }
        public string Flat { get; set; }
        public string Account { get; set; }
        public DateTime? LastUpdate { get; set; }
        public bool? IsApartmentNew { get; set; }
        public string Comment { get; set; }
        public long? SubFileId { get; set; }

        public virtual ExternalProcessing Processing { get; set; }
        public virtual FasetItem Status { get; set; }
    }
}

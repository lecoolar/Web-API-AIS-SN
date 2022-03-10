using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class ApartmentOwnersView
    {
        public long Id { get; set; }
        public long ApartmentId { get; set; }
        public string PrintName { get; set; }
        public int? Num { get; set; }
        public int? Denom { get; set; }
        public string Share { get; set; }
        public DateTime? DateDoc { get; set; }
        public string Doc { get; set; }
        public long? DocId { get; set; }
        public string OrgDocumentName { get; set; }
        public DateTime Dateb { get; set; }
        public DateTime? Datee { get; set; }
        public DateTime Datec { get; set; }
        public long? OwnerId { get; set; }
        public long? PersonId { get; set; }
        public long? OrgId { get; set; }
        public int? TypeOwner { get; set; }
        public int? TypeOwnerId { get; set; }
        public string TypeOwnerFasetName { get; set; }
        public DateTime? BirthDate { get; set; }
        public int? Age { get; set; }
        public string SaleContract { get; set; }
        public DateTime? SaleContractDate { get; set; }
        public long? HouseId { get; set; }
        public string ApartmentNo { get; set; }
        public bool? NotUseOwnerNumDenom { get; set; }
    }
}

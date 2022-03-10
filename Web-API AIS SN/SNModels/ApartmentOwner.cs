using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class ApartmentOwner
    {
        public ApartmentOwner()
        {
            ApartmentOwnershipLegalizations = new HashSet<ApartmentOwnershipLegalization>();
            DebtExecutoryProcessStages = new HashSet<DebtExecutoryProcessStage>();
        }

        public long Id { get; set; }
        public long ApartmentId { get; set; }
        public string PrintName { get; set; }
        public long? OwnerId { get; set; }
        public int? Num { get; set; }
        public int? Denom { get; set; }
        public DateTime? DateDoc { get; set; }
        public string Doc { get; set; }
        public DateTime Dateb { get; set; }
        public DateTime? Datee { get; set; }
        public DateTime Datec { get; set; }
        public int? TypeOwnerId { get; set; }
        public string SaleContract { get; set; }
        public DateTime? SaleContractDate { get; set; }
        public long? DocId { get; set; }
        public long? OldId { get; set; }
        public bool? NotUseOwnerNumDenom { get; set; }

        public virtual Apartment1 Apartment { get; set; }
        public virtual OrgDocument DocNavigation { get; set; }
        public virtual Owner Owner { get; set; }
        public virtual FasetItem TypeOwner { get; set; }
        public virtual ICollection<ApartmentOwnershipLegalization> ApartmentOwnershipLegalizations { get; set; }
        public virtual ICollection<DebtExecutoryProcessStage> DebtExecutoryProcessStages { get; set; }
    }
}

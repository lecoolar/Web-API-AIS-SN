using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class Area
    {
        public Area()
        {
            ActionDistributeds = new HashSet<ActionDistributed>();
            AreaAccounts = new HashSet<AreaAccount>();
            AreaAddresses = new HashSet<AreaAddress>();
            AreaApartments = new HashSet<AreaApartment>();
            AreaOrganizations = new HashSet<AreaOrganization>();
            AreaProperties = new HashSet<AreaProperty>();
            ExportDocuments = new HashSet<ExportDocument>();
            ExportOperations = new HashSet<ExportOperation>();
            TemperatureAverages = new HashSet<TemperatureAverage>();
            TemperatureDesignLoads = new HashSet<TemperatureDesignLoad>();
        }

        public long Id { get; set; }
        public string Name { get; set; }
        public int StatusTemporary { get; set; }
        public long? AreaGroupId { get; set; }
        public DateTime? Created { get; set; }
        public string UserId { get; set; }
        public bool IsSystem { get; set; }

        public virtual AreaGroup AreaGroup { get; set; }
        public virtual ICollection<ActionDistributed> ActionDistributeds { get; set; }
        public virtual ICollection<AreaAccount> AreaAccounts { get; set; }
        public virtual ICollection<AreaAddress> AreaAddresses { get; set; }
        public virtual ICollection<AreaApartment> AreaApartments { get; set; }
        public virtual ICollection<AreaOrganization> AreaOrganizations { get; set; }
        public virtual ICollection<AreaProperty> AreaProperties { get; set; }
        public virtual ICollection<ExportDocument> ExportDocuments { get; set; }
        public virtual ICollection<ExportOperation> ExportOperations { get; set; }
        public virtual ICollection<TemperatureAverage> TemperatureAverages { get; set; }
        public virtual ICollection<TemperatureDesignLoad> TemperatureDesignLoads { get; set; }
    }
}

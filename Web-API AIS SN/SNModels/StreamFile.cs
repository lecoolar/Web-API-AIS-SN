using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class StreamFile
    {
        public StreamFile()
        {
            ApartmentIndicationsFiles = new HashSet<ApartmentIndicationsFile>();
            CounterIndicationsFiles = new HashSet<CounterIndicationsFile>();
            HouseIndicationsFiles = new HashSet<HouseIndicationsFile>();
        }

        public long Id { get; set; }
        public long? Guid { get; set; }
        public byte[] FileByte { get; set; }
        public DateTime? Created { get; set; }
        public string ObjectTitle { get; set; }
        public byte[] ObjectData { get; set; }
        public string Comment { get; set; }
        public string ObjectName { get; set; }
        public string HashSumm { get; set; }
        public long OrgDocId { get; set; }

        public virtual OrgDocument OrgDoc { get; set; }
        public virtual ICollection<ApartmentIndicationsFile> ApartmentIndicationsFiles { get; set; }
        public virtual ICollection<CounterIndicationsFile> CounterIndicationsFiles { get; set; }
        public virtual ICollection<HouseIndicationsFile> HouseIndicationsFiles { get; set; }
    }
}

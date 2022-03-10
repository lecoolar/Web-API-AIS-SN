using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class ApartmentNote
    {
        public long Id { get; set; }
        public long ApartmentId { get; set; }
        public DateTime Created { get; set; }
        public string Caption { get; set; }
        public string Note { get; set; }
        public string UserName { get; set; }
        public DateTime? DateEffective { get; set; }
        public long? OrgDocumentId { get; set; }
        public int? NoteType { get; set; }

        public virtual Apartment1 Apartment { get; set; }
        public virtual FasetItem NoteTypeNavigation { get; set; }
        public virtual OrgDocument OrgDocument { get; set; }
    }
}

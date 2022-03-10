using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class TblDpersons79011
    {
        public long Id { get; set; }
        public string LName { get; set; }
        public string FName { get; set; }
        public string MName { get; set; }
        public DateTime? BirthDate { get; set; }
        public int? TypeDoc { get; set; }
        public string SerDoc { get; set; }
        public string NumDoc { get; set; }
        public DateTime? DateDoc { get; set; }
        public string OrgDoc { get; set; }
        public long? KodCl { get; set; }
        public long? KodObj { get; set; }
        public byte IsDelete { get; set; }
        public string FullName { get; set; }
        public string InsuranceCertificate { get; set; }
        public string AccountBenefit { get; set; }
        public DateTime? DateBenefit { get; set; }
        public long? OrgBenefitId { get; set; }
        public bool IsUnknown { get; set; }
        public bool AllowPersonalDataUsage { get; set; }
        public string BirthPlace { get; set; }
        public DateTime? Created { get; set; }
        public DateTime? DateChange { get; set; }
        public string Inn { get; set; }
        public string SubdivisionCodeDoc { get; set; }
        public string Telephone { get; set; }
        public string Email { get; set; }
        public string Comment { get; set; }
        public int? Sex { get; set; }
    }
}

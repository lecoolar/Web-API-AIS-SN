using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class PersonPhone
    {
        public PersonPhone()
        {
            PersonDeclarations = new HashSet<PersonDeclaration>();
            PersonPhoneEventTypes = new HashSet<PersonPhoneEventType>();
        }

        public long Id { get; set; }
        public string Phone { get; set; }
        public string Fio { get; set; }
        public string Email { get; set; }
        public DateTime? Created { get; set; }
        public Guid? GenerateToken { get; set; }

        public virtual ICollection<PersonDeclaration> PersonDeclarations { get; set; }
        public virtual ICollection<PersonPhoneEventType> PersonPhoneEventTypes { get; set; }
    }
}

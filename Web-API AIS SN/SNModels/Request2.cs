using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class Request2
    {
        public Request2()
        {
            SendQueries = new HashSet<SendQuery>();
        }

        public long Id { get; set; }
        public string Phone { get; set; }
        public long? AccountId { get; set; }
        public long? TypeRequest { get; set; }
        public string Request { get; set; }
        public string Respond { get; set; }
        public int? Result { get; set; }
        public DateTime? Created { get; set; }

        public virtual ICollection<SendQuery> SendQueries { get; set; }
    }
}

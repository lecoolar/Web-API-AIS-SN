using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class AccountServiceNormTypesWithLastNormView
    {
        public long? Id { get; set; }
        public long AccountServiceId { get; set; }
        public long? AccountServiceNormId { get; set; }
        public long? AccountServiceNormTypeId { get; set; }
        public long ServiceTypeId { get; set; }
        public decimal? NormRate { get; set; }
        public decimal? NormtypeRate { get; set; }
        public int NormTypeId { get; set; }
        public string NormTypeName { get; set; }
    }
}

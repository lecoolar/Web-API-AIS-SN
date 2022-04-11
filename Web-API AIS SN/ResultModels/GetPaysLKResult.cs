using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Web_API_AIS_SN.ResultModels
{
    public class GetPaysLKResult
    {
        public string Period { get; set; }

        public decimal? Summ { get; set; }

        public decimal? Comm { get; set; }

        public long? OrderId { get; set; }

        public byte? Status { get; set; }

        public string Name { get; set; }

        public string TransactionNumber { get; set; }

        public string Accpu { get; set; }

        public string Phone { get; set; }

        public string Service { get; set; }

    }
}

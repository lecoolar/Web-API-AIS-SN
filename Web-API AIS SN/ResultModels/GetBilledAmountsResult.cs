using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Web_API_AIS_SN.ResultModels
{
    public class GetBilledAmountsResult
    {
        public string Period { get; set; }

        public decimal? Summ { get; set; }

        public decimal? MaxSummAndPeni { get; set; }

        public decimal? MinSummAndPeni { get; set; }
    }
}

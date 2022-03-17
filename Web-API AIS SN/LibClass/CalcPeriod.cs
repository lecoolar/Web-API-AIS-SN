using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Web_API_AIS_SN.Context;
using Web_API_AIS_SN.SNModels;

namespace Web_API_AIS_SN.LibClass
{
    public class CalcPeriodSN
    {


        public CalcPeriodSN()
        {
        }
        internal string conString;
        public CalcPeriodSN(string conStrings)
        {
            conString = conStrings;
        }


        public CalcPeriod GetCurrent()
        {
            var calcPeriod = new CalcPeriod();
            try
            {
                using (var sn = new SNContext(conString))
                {
                     calcPeriod = sn.CalcPeriods.OrderByDescending(q => q.FromDate).First();
                }
            }
            catch(Exception ex)
            {

            }

            return calcPeriod;
        }

    }
}
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using Web_API_AIS_SN.Context;
using Web_API_AIS_SN.ResultModels;
using Web_API_AIS_SN.SNModels;

namespace Web_API_AIS_SN.LibClass
{
    public class CounterSN
    {
        public CounterSN()
        {
        }
        internal string conString;
        public CounterSN(string conStrings)
        {
            conString = conStrings;
        }
        public ApartmentCountersView GetById(long id)
        {
            var countersIndications = new List<ApartmentCountersView>();
            ApartmentCountersView countersIndication = null;
            try
            {
                using (var sn = new SNContext(conString))
                {
                    countersIndications = sn.ApartmentCountersViews.Where(q => q.CounterId == id).ToList();
                    if (countersIndications.Any())

                    {
                        if (countersIndications.Count() == 1)
                        {
                            countersIndication = countersIndications.Single();
                        }
                        else
                        {
                        }
                    }
                    else
                    {
                        return null;

                    }

                }
            }
            catch
            {

            }

            return countersIndication;
        }

        public List<ApartmentCountersView> FindByApartmentId (long apartmentId)
        {
            var CountersIndications = new List<ApartmentCountersView>();
            try
            {
                using (var sn = new SNContext(conString))
                {
                    CountersIndications = sn.ApartmentCountersViews.Where(q => q.ApartmentId  == apartmentId).ToList();
                }
            }
            catch
            {

            }
            return CountersIndications;
        }
        public List<ApartmentCountersView> FindActiveCountersByApartmentId(long apartmentId)
        {
            var CountersIndications = new List<ApartmentCountersView>();
            try
            {
                using (var sn = new SNContext(conString))
                {
                    CountersIndications = sn.ApartmentCountersViews.Where(q => q.ApartmentId == apartmentId && (q.Datee ==null || q.Datee >DateTime.Today)).ToList();
                }
            }
            catch
            {

            }
            return CountersIndications;
        }

        public async Task<List<AccountCountersInfoResult>> GetAccountCountersInfo(string account, bool needCommunal)
        {           
            var accountCounters = new List<AccountCountersInfoResult>();
            try
            {
                using (var sn = new SNContext(conString))
                {
                    string query = @$"SELECT * FROM CRM.""AccountCountersInfo""({account},{(needCommunal ? 1 : 0)})";
                    accountCounters = await sn.Set<AccountCountersInfoResult>().FromSqlRaw(query).ToListAsync();
                }
            }
            catch (Exception ex)
            {

            }
            return accountCounters;
        }

        //public List<ResultSaveApartmentCounterIndications> newSaveApartmentCounterIndications(long accountId, long apartmentId, string listCounterAndVal, string typeVal, string comment, bool indicationZero, bool tempSaveRecalc)
        //{
        //    var result = new List<ResultSaveApartmentCounterIndications>();
        //    using (var sn = new SNContext(conString))
        //    {
        //        result = sn.SaveApartmentCounterIndications(accountId, apartmentId, listCounterAndVal, DateTime.Now, typeVal, comment, indicationZero, tempSaveRecalc).ToList();
        //    }

        //    return result;
        //}

    }
}
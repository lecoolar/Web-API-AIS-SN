using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Web_API_AIS_SN.Context;
using Web_API_AIS_SN.SNModels;

namespace Web_API_AIS_SN.LibClass
{
    public class ApartmentResidentVacationSN
    {
        public ApartmentResidentVacationSN()
        {
        }
        internal string conString;
        public ApartmentResidentVacationSN(string conStrings)
        {
            conString = conStrings;
        }
        public ApartmentResidentVacationsView GetById(long id)
        {
            var residentVacations = new ApartmentResidentVacationsView();
            try
            {
                using (var sn = new SNContext(conString))
                {
                    residentVacations = sn.ApartmentResidentVacationsViews.Where(q => q.Id == id).FirstOrDefault();
                }
            }
            catch
            {

            }

            return residentVacations;
        }

        public List<ApartmentResidentVacationsView> FindByResidentId(long residentId)
        {
            var residentVacations = new List<ApartmentResidentVacationsView>();
            try
            {
                using (var sn = new SNContext(conString))
                {
                    residentVacations = sn.ApartmentResidentVacationsViews.Where(q => q.ResidentId == residentId).ToList();
                }
            }
            catch
            {

            }

            return residentVacations;
        }

        public List<ApartmentResidentVacationsView> FindByApartmentId(long apartmentId)
        {
            var residentVacations = new List<ApartmentResidentVacationsView>();
            try
            {
                using (var sn = new SNContext(conString))
                {
                    residentVacations = sn.ApartmentResidentVacationsViews
                        .Where(q => q.ApartmentId == apartmentId).ToList()
                        .Where(q => q.ToDate >= DateTime.Today || q.ToDate == null)
                        .ToList();
                }
            }
            catch
            {

            }

            return residentVacations;
        }


    }
}
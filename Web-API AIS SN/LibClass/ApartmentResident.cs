using System;
using System.Collections.Generic;
using System.Linq;
using Web_API_AIS_SN.Context;
using Web_API_AIS_SN.SNModels;

namespace Web_API_AIS_SN.LibClass
{
    public class ApartmentResidentSN
    {
        public ApartmentResidentSN()
        {
        }
        internal string conString;
        public ApartmentResidentSN(string conStrings)
        {
            conString = conStrings;
        }
        public ApartmentResidentsView GetById(long id)
        {
            var ApartmentResident = new ApartmentResidentsView();
            try
            {
                using (var sn = new SNContext(conString))
                {
                    ApartmentResident = sn.ApartmentResidentsViews.Where(q => q.Id == id).FirstOrDefault();
                }
            }
            catch
            {

            }

            return ApartmentResident;
        }

        public List<ApartmentResidentsView> FindByApartment(long apartmentId)
        {
            var ApartmentResident = new List<ApartmentResidentsView>();
            try
            {
                using (var sn = new SNContext(conString))
                {
                    ApartmentResident = sn.ApartmentResidentsViews
                        .Where(q => q.ApartmentId == apartmentId).ToList()
                        .Where(q => q.ToDate == null || q.ToDate >= DateTime.Today || q.ToDate == DateTime.MinValue).ToList();
                }
            }
            catch(Exception ex)
            {

            }

            return ApartmentResident;
        }

        public List<ApartmentResidentsView> FindByPersonId(long personId)
        {
            var ApartmentResident = new List<ApartmentResidentsView>();
            try
            {
                using (var sn = new SNContext(conString))
                {
                    ApartmentResident = sn.ApartmentResidentsViews.Where(q => q.PersonId == personId).ToList();
                }
            }
            catch
            {

            }

            return ApartmentResident;
        }


    }
}
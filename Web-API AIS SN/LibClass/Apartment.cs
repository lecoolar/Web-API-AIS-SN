using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Web_API_AIS_SN.Context;
using Web_API_AIS_SN.LibClass.Enums;
using Web_API_AIS_SN.SNModels;

namespace Web_API_AIS_SN.LibClass
{
    public class ApartmentSN
    {
        public ApartmentSN()
        {
        }
        internal string conString;
        public ApartmentSN(string conStrings)
        {
            conString = conStrings;
        }
        public Apartment1 GetById(long id)
        {
            var apartments = new List<Apartment1>();
            Apartment1 apartment = null;
            try
            {
                using (var sn = new SNContext(conString))
                {
                    apartments = sn.Apartments1.Where(q => q.Id == id).ToList();
                    if (apartments.Any())

                    {
                        if (apartments.Count() == 1)
                        {
                            apartment = apartments.Single();
                        }
                        else
                        {
                        }
                    }
                    else
                    {

                    }

                }
            }
            catch(Exception ex)
            {

            }

            return apartment;
        }

        public ApartmentsView GetApartmentsViewById(long apartmentId)
        {
            ApartmentsView apartmentsView = null;
            try
            {
                using (var sn = new SNContext(conString))
                {
                    apartmentsView = sn.ApartmentsViews.FirstOrDefault(q => q.Id == apartmentId);
                }
            }
            catch (Exception ex)
            {
                
            }

            return apartmentsView;
        }


        public ApartmentHouseHolder GetApartmentHouseHolderByApartmentId(long apartmentId)
        {
            var houseHolder = new ApartmentHouseHolder();
            try
            {
                using (var sn = new SNContext(conString))
                {
                    houseHolder = sn.ApartmentHouseHolders.Where(q => q.Id == apartmentId).SingleOrDefault();

                }
            }
            catch
            {

            }

            return houseHolder;
        }
        public ApartmentHouseHoldersView GetApartmentHouseHolderViewByApartmentId(long apartmentId)
        {
            var houseHolder = new ApartmentHouseHoldersView();
            try
            {
                using (var sn = new SNContext(conString))
                {
                    houseHolder = sn.ApartmentHouseHoldersViews.Where(q => q.ApartmentId == apartmentId).SingleOrDefault();

                }
            }
            catch
            {

            }

            return houseHolder;
        }

        public int GetCountResidentByApartmentId(long apartmentId)
        {
            var count = 0;
            try
            {
                using (var sn = new SNContext(conString))
                {
                    count = sn.ApartmentResidents.Where(q => q.ApartmentId == apartmentId && (q.Datee == null || q.Datee >= DateTime.Today)).Count();

                }
            }
            catch
            {

            }

            return count;
        }


        public int GetCountResidentBenefitsByApartmentId(long apartmentId)
        {
            var count = 0;
            try
            {
                using (var sn = new SNContext(conString))
                {
                    count = sn.ApartmentResidentBenefits.Where(q => q.ApartmentId == apartmentId && (q.ToDate ==null||q.ToDate>=DateTime.Today)).Count();

                }
            }
            catch
            {

            }

            return count;
        }


        public List<ApartmentResidentsView> GetApartmentResidentsByApartmentId(long apartmentId)
        {
            var ApartmentResident = new List<ApartmentResidentsView>();
            try
            {
                using (var sn = new SNContext(conString))
                {
                    ApartmentResident = sn.ApartmentResidentsViews.Where(q => q.ApartmentId == apartmentId).ToList();
                }
            }
            catch
            {

            }

            return ApartmentResident;
        }


        public int GetCountResidentVacationsByApartmentId(long apartmentId)
        {
            var count = 0;
            try
            {
                using (var sn = new SNContext(conString))
                {
                    count = sn.ApartmentResidentVacations.Where(q => q.ApartmentId == apartmentId && (q.Datee == null || q.Datee >= DateTime.Today)).Count();

                }
            }
            catch
            {

            }

            return count;
        }
        public ApartmentArea GetApartmentAreaByApartmentId(long apartmentId)
        {
            var apartmentAreas = new ApartmentArea();
            try
            {
                using (var sn = new SNContext(conString))
                {
                    apartmentAreas = sn.ApartmentAreas.Where(q => q.ApartmentId == apartmentId).FirstOrDefault();
                }
            }
            catch
            {

            }

            return apartmentAreas;
        }
        public ApartmentTypesView GetApartmentTypeViewByApartmentIdAndFasets(long apartmentId)
        {
            var apartmentTypes = new ApartmentTypesView();
            try
            {
                using (var sn = new SNContext(conString))
                {
                    apartmentTypes = sn.ApartmentTypesViews
                        .Where(q => q.ApartmentId == apartmentId && q.FasetId == (int)FasetsEnum.ApartmentTypes)
                        .OrderByDescending(q=>q.FromDate).FirstOrDefault();
                    if (apartmentTypes == null)
                    {
                        apartmentTypes = sn.ApartmentTypesViews
                            .Where(q => q.ApartmentId == apartmentId && q.FasetId == (int)FasetsEnum.HouseApartmentType)
                            .OrderByDescending(q => q.FromDate).FirstOrDefault();
                    }                        
                }
            }
            catch
            {

            }
            return apartmentTypes;
        }

    }
}
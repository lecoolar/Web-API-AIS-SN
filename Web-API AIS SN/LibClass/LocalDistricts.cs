using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Web_API_AIS_SN.Context;
using Web_API_AIS_SN.ResultModels;
using Web_API_AIS_SN.SNModels;

namespace AIS.SN.CRMService.LibClass
{
    public class LocalDistrictsSN
    {

        public LocalDistrictsSN()
        { }

        public string conString;

        public LocalDistrictsSN(string conStrings)
        {
            conString = conStrings;
        }


        public List<LocalDistrict> GetLocalDistricts()
        {
            var localAddresses = new List<LocalDistrict>();
            try
            {
                using (var sn = new SNContext(conString))
                {

                    localAddresses = sn.LocalDistricts
                        .Where(l => l.Level == 10)
                        .GroupBy(p => p.Id)
                        .Select(t => t.First())
                        .ToList();
                }
            }
            catch(Exception ex)
            {

            }
            return localAddresses;
        }

        public List<GetLocalAddressesByLocalDistrictResult> GetLocalAddressesByLocalDistrict (long localDistrictId)
        {
            List<GetLocalAddressesByLocalDistrictResult> localAddresses = null;
            try
            {
                using (var sn = new SNContext(conString))
                {
                    string query = @$"SELECT * FROM lk.""GetLocalAddressesByLocalDistrict""({localDistrictId})";
                    localAddresses = sn.Set<GetLocalAddressesByLocalDistrictResult>().FromSqlRaw(query).ToList();
                }
            }
            catch (Exception ex)
            {

            }
            return localAddresses;
        }



    }
}
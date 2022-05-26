using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Web_API_AIS_SN.Context;
using Web_API_AIS_SN.SNModels;

namespace Web_API_AIS_SN.LibClass
{
    public class OrganizationSN
    {

        public OrganizationSN()
        {
        }
        internal string conString;
        public OrganizationSN(string conStrings)
        {
            conString = conStrings;
        }
        public Organization1 GetById(long id)
        {
            var organization = new Organization1();
            try
            {
                using (var sn = new SNContext(conString))
                {
                    organization = sn.Organizations1.SingleOrDefault(q => q.Id == id);
                }
            }
            catch
            {
                return null;
            }

            return organization;
        }
        public Organization1 GetByName(string name)
        {
            var organization = new Organization1();
            try
            {
                using (var sn = new SNContext(conString))
                {
                    organization = sn.Organizations1.SingleOrDefault(q => q.ShortName == name);
                }
            }
            catch
            {
                return null;
            }
            return organization;
        }
        public Organization1 GetByShortNameOrLongName(string name)
        {
            var organization = new Organization1();
            try
            {
                using (var sn = new SNContext(conString))
                {
                    var qwe = sn.Organizations1.ToList();
                    organization = sn.Organizations1.SingleOrDefault(q => q.ShortName.Trim() == name || q.LongName.Trim() == name);
                }
            }
            catch
            {
                return null;
            }
            return organization;
        }

        public List<Organization1> GetEmailOrganizationByIdList(List<long> idList)
        {
            var organization = new List<Organization1>();
            try
            {
                if (idList.Any())
                {
                    using (var sn = new SNContext(conString))
                    {
                        organization = sn.Organizations1
                            .Join(idList, o => o.Id, i => i, (o, i) => o)
                            .Where(z => z.IsServiceProvider && z.AddrInternetInfo != null && z.AddrInternetInfo != "").ToList();
                    }
                }
            }
            catch (Exception ex)
            {

            }

            return organization;
        }

        public List<Organization1> GetAllHouseHolders()
        {
            var organizations = new List<Organization1>();
            try
            {
                using (var sn = new SNContext(conString))
                {
                    organizations = sn.Organizations1.Where(q => q.IsHouseHolder && (q.Datee == null || q.Datee >= DateTime.Today)).ToList();
                }
            }
            catch
            {
                return null;
            }
            return organizations;
        }
    }
}

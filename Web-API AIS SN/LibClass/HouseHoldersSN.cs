using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Web_API_AIS_SN.Context;
using Web_API_AIS_SN.SNModels;

namespace Web_API_AIS_SN.LibClass
{
    public class HouseHoldersSN
    {
        public HouseHoldersSN()
        {
        }
        internal string conString;
        public HouseHoldersSN(string conStrings)
        {
            conString = conStrings;
        }

        public HouseHouseHoldersView GetByFias(string fias)
        {
            var houseHolder = new HouseHouseHoldersView();
            try
            {
                using (var sn = new SNContext(conString))
                {
                    houseHolder = sn.HouseHouseHoldersViews
                        .Where(q => q.FiasCode == fias && (q.ToDate == null || q.ToDate > DateTime.Today) && q.IsServiceProvider)
                        .OrderByDescending(q => q.Created)
                        .FirstOrDefault();
                }
            }
            catch (Exception ex)
            {
                houseHolder = null;
            }
            return houseHolder;
        }


        public List<HouseHouseHoldersView> GetAllAddressByHouseHolderId(long houseHolderId)
        {
            var houseHolder = new List<HouseHouseHoldersView>();
            try
            {
                using (var sn = new SNContext(conString))
                {
                    houseHolder = sn.HouseHouseHoldersViews.Where(q => q.HouseHolderId == houseHolderId).ToList();
                }
            }
            catch
            {
                houseHolder = null;
            }
            return houseHolder;
        }

        public AccountHouseHoldersView GetAccountHouseHolderByAccountId(long accountId)
        {
            var houseHolder = new AccountHouseHoldersView();
            try
            {
                using (var sn = new SNContext(conString))
                {
                    houseHolder = sn.AccountHouseHoldersViews.Where(q => q.AccountId == accountId).OrderByDescending(q => q.FromDate).FirstOrDefault();
                }
            }
            catch
            {
                houseHolder = null;
            }
            return houseHolder;
        }
    }
}

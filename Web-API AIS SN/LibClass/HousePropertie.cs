using System.Linq;
using Web_API_AIS_SN.Context;

namespace Web_API_AIS_SN.LibClass
{
    public class HousePropertieSN
    {
        public HousePropertieSN()
        {
        }
        internal string conString;
        public HousePropertieSN(string conStrings)
        {
            conString = conStrings;
        }

        public bool AnyHousePropertie(long houseId, long propertyId)
        {
            var any = false;
            try
            {
                using (var sn = new SNContext(conString))
                {
                    any = sn.HouseProperties.Any(q => q.HouseId == houseId && q.PropertyId == propertyId);
                }
            }
            catch
            {

            }
            return any;
        }

    }
}
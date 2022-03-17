using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Web_API_AIS_SN.Context;
using Web_API_AIS_SN.SNModels;

namespace Web_API_AIS_SN.LibClass
{
    public class FasetSN
    {
        public FasetSN()
        {
        }
        internal string conString;
        public FasetSN(string conStrings)
        {
            conString = conStrings;
        }


        public Faset GetByName( string name)
        {
            var fasets = new Faset();
            try
            {
                using (var sn = new SNContext(conString))
                {
                    fasets = sn.Fasets.SingleOrDefault(q => q.Name == name);
                }
            }
            catch(Exception ex)
            {

            }
            return fasets;
        }
        public Faset GetById(long id)
        {
            var fasets = new Faset();
            try
            {
                using (var sn = new SNContext(conString))
                {
                    fasets = sn.Fasets.SingleOrDefault(q => q.Id == id);
                }
            }
            catch (Exception ex)
            {

            }
            return fasets;
        }

        public List<Faset> GetAll()
        {
            var fasets = new List<Faset>();
            try
            {
                using (var sn = new SNContext(conString))
                {
                    fasets = sn.Fasets.ToList();
                }
            }
            catch (Exception ex)
            {

            }
            return fasets;
        }

    }




}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Web_API_AIS_SN.Context;
using Web_API_AIS_SN.SNModels;

namespace Web_API_AIS_SN.LibClass
{
    public class FasetsItemSN
    {



        public FasetsItemSN()
        {
        }
        internal string conString;
        public FasetsItemSN(string conStrings)
        {
            conString = conStrings;
        }

        public FasetItem GetById(long id)
        {
            var fasets = new FasetItem();
            try
            {
                using (var sn = new SNContext(conString))
                {
                    fasets = sn.FasetItems.Where(q => q.Id == id).SingleOrDefault();
                }
            }
            catch
            {

            }
            return fasets;
        }

        public FasetItem GetByName(string name)
        {
            var fasets = new FasetItem();
            try
            {
                using (var sn = new SNContext(conString))
                {
                    fasets = sn.FasetItems.Where(q => q.Name == name).SingleOrDefault();
                }
            }
            catch
            {

            }
            return fasets;
        }

        public FasetItem GetByNameAndfasetId(long id,string fasetName)
        {
            var fasets = new FasetItem();
            try
            {
                using (var sn = new SNContext(conString))
                {
                    fasets = sn.FasetItems.Where(q => q.FasetId == id && q.Name == fasetName).SingleOrDefault();
                }
            }
            catch
            {

            }
            return fasets;
        }
        public List<FasetItem> GetAllItemByfasetId(long id)
        {
            var fasets = new List<FasetItem>();
            try
            {
                using (var sn = new SNContext(conString))
                {
                    fasets = sn.FasetItems.Where(q => q.FasetId == id ).ToList();
                }
            }
            catch
            {

            }
            return fasets;
        }
        public FasetItemsView GetFasetItemByFasetNameAndFasetItemName(string fasetName,string fasetItemName)
        {
            var faset = new FasetItemsView();
            try
            {
                using (var sn = new SNContext(conString))
                {
                    faset = sn.FasetItemsViews.Where(q => q.FasetName == fasetName && q.Name== fasetItemName).SingleOrDefault();
                }
            }
            catch
            {

            }
            return faset;
        }

    }



}



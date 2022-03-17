using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Web_API_AIS_SN.Context;
using Web_API_AIS_SN.Model;
using Web_API_AIS_SN.SNModels;

namespace Web_API_AIS_SN.LibClass
{
    public class SettingSN
    {

        public SettingSN()
        {
        }
        internal string conString;
        public SettingSN(string conStrings)
        {
            conString = conStrings;
        }
        public Setting GetByName(string name)
        {
            var setting = new Setting();
            try
            {
                using (var sn = new SNContext(conString))
                {
                    setting = sn.Settings.Where(q => q.Name == name).SingleOrDefault();
                }
            }
            catch
            {

            }

            return setting;
        }

        public SettingsView GetValueByGroupNameAndName(string groupName, string name)
        {
            var setting = new SettingsView();
            try
            {
                using (var sn = new SNContext(conString))
                {
                    setting = sn.SettingsViews.Where(q => q.GroupName == groupName && q.Name == name).SingleOrDefault();
                }
            }
            catch (Exception ex)
            {

            }
            return setting;
        }
        

    }
}
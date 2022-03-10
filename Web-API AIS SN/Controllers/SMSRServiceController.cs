using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Web_API_AIS_SN.GKH;
using Web_API_AIS_SN.Model;
using Web_API_AIS_SN.SMSR;

namespace Web_API_AIS_SN.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SMSRServiceController : Controller
    {
        private readonly SNSRContext _context;
        private readonly string json = @"{
                                          'typeRequest':'Request',
                                          'metodRequest':'AccountInfo', 
                                          'params' : [
                                          {'name':'account', 'value':'3000000142533'},
                                          {'name':'baseId', 'value':'1'}
                                          ]
                                         }";

        public SMSRServiceController(SNSRContext context)
        {
            _context = context;
        }
        [HttpGet]
        public async Task<ActionResult<ResponseData>> SartMethod(string startMethod)
        {
            var resultJson = "";
            GKH.Request tmp = JsonConvert.DeserializeObject<GKH.Request>(startMethod);
            switch (tmp.MetodRequest)
            {
                case "AccountInfo":
                    GKH.AccountInfo accountInfo = new GKH.AccountInfo(tmp.@params);
                    resultJson = accountInfo.GetAccountInfo();
                    break;

            }
            ResponseData result = await Task.Run(() => JsonConvert.DeserializeObject<ResponseData>(resultJson));
            return result;
        }

        //[HttpGet]
        //public async Task<ActionResult<AccountInfoView>> Index()
        //{
        //    await SartMethod(json);
        //    AccountInfoView result = await _context.AccountInfoViews.FirstAsync();
        //    return result;
        //}
    }
}

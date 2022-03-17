using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
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

        //public SMSRServiceController(SMSRContext context)
        //{
        //    _context = context;
        //}
        [HttpPost]
        public async Task<ActionResult<ResponseData>> SartMethod(GKH.Request request)
        {
            ResponseData result = new ResponseData();
            switch (request.MetodRequest)
            {
                case "AccountInfo":
                    GKH.AccountInfo accountInfo = new GKH.AccountInfo(request.@params);
                    result = await accountInfo.GetAccountInfo();
                    break;
                case "GetAccountsByFiasHouseAndRoom":
                    AccountsByFiasHouseAndRoom accountsByFiasHouseAndRoom = new AccountsByFiasHouseAndRoom(request.@params);
                    result = await accountsByFiasHouseAndRoom.GetAccountsByFiasHouseAndRoom();
                    break;
                case "AccountServiceInfo":
                    AccountServiceInfo accountServiceInfo = new AccountServiceInfo(request.@params);
                    result = await accountServiceInfo.GetAccountServiceInfo();
                    break;
            }
            return result;
        }

    }
}

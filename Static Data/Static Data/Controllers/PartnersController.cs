using Static_Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;

namespace Static_Data.Controllers
{
    public class PartnersController : ApiController
    {
        [HttpGet]
        public IEnumerable<PartnerMapping> GetAccounts()
        {
            //var tc = new TelemetryClient();
            //tc.TrackEvent("GetAccounts Called");
            return new PartnerMapping[]{
                new PartnerMapping { Id = 1, TE = "Matt", PartnerName = "PayPal"},
                new PartnerMapping { Id = 2, TE = "Richard", PartnerName = "Netflix"},
                new PartnerMapping { Id = 3, TE = "Nathalie", PartnerName = "Twitch"},

            };
        }
    }
}




//        [HttpPost]
//        public HttpResponseMessage Post([FromBody] Contact contact)
//        {
//            // todo: save the contact somewhere
//            return Request.CreateResponse(HttpStatusCode.Created);
//        }
//    }
//}

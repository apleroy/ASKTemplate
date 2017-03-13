using ASK.Domain;
using ASK.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ASK.WebApp.Controllers
{
    public class AlexaController : ApiController
    {
        private readonly IAlexaRequestService _alexaRequestService;

        public AlexaController(IAlexaRequestService alexaRequestService)
        {
            _alexaRequestService = alexaRequestService;
        }

        [HttpPost, Route("api/v1/alexa/test")]
        public dynamic Test(AlexaRequestPayload alexaRequestInput)
        {
            return new AlexaResponse("Non db call working");
        }


        [HttpPost, Route("api/v1/alexa/meetandgreet")]
        public dynamic MeetAndGreet(AlexaRequestPayload alexaRequestInput)
        {
            return _alexaRequestService.ProcessAlexaRequest(alexaRequestInput);
        }
    }
}

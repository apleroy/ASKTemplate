using System;
using ASK.Domain;

namespace ASK.Services
{
    public class SessionEndedRequestHandlerStrategy : IAlexaRequestHandlerStrategy
    {
        public string SupportedRequestIntentName
        {
            get
            {
                return "SessionEndedIntent";
            }
        }

        public string SupportedRequestType
        {
            get
            {
                return StrategyHandlerTypes.SessionEndedRequest.ToString();
            }
        }

        public AlexaResponse HandleAlexaRequest(AlexaRequestPayload alexaRequest)
        {
            return null;
        }
    }
}

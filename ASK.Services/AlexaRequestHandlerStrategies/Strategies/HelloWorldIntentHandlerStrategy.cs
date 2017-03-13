using System;
using ASK.Domain;
using ASK.Core;

namespace ASK.Services
{
    public class HelloWorldIntentHandlerStrategy : IAlexaRequestHandlerStrategy
    {
        public string SupportedRequestIntentName
        {
            get
            {
                return "HelloWorldIntent";
            }
        }

        public string SupportedRequestType
        {
            get
            {
                return StrategyHandlerTypes.IntentRequest.ToString();
            }
        }

        public AlexaResponse HandleAlexaRequest(AlexaRequestPayload alexaRequest)
        {
            return new AlexaResponse("Hello World");
        }
    }
}
using ASK.Domain;

namespace ASK.Services
{
    public interface IAlexaRequestHandlerStrategyFactory
    {
        IAlexaRequestHandlerStrategy CreateAlexaRequestHandlerStrategy(AlexaRequestPayload alexaRequest);
    }
}

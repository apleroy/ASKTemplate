using ASK.Domain;

namespace ASK.Services
{
    public interface IAlexaRequestService
    {
        AlexaResponse ProcessAlexaRequest(AlexaRequestPayload alexaRequestInput);
    }
}

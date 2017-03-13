using ASK.Domain;

namespace ASK.Services
{
    public interface IAlexaRequestMapper
    {
        AlexaRequest MapAlexaRequest(AlexaRequestPayload alexaRequest);
    }
}

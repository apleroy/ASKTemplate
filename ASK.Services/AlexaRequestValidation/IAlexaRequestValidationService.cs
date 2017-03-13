using ASK.Domain;

namespace ASK.Services
{
    public interface IAlexaRequestValidationService
    {
        SpeechletRequestValidationResult ValidateAlexaRequest(AlexaRequestPayload alexaRequest);
        
    }
}

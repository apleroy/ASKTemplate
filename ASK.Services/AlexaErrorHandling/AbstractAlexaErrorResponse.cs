using ASK.Domain;

namespace ASK.Services
{
    public abstract class AbstractAlexaErrorResponse
    {
        public virtual AlexaResponse GenerateCustomError()
        {
            AlexaResponse alexaResponse = new AlexaResponse("Sorry there was an error");
            return alexaResponse;
        }
    }
}

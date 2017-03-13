using ASK.Domain;

namespace ASK.Services
{
    public class AlexaWordErrorResponse : AbstractAlexaErrorResponse
    {
        public override AlexaResponse GenerateCustomError()
        {
            AlexaResponse alexaResponse = new AlexaResponse("I'm Sorry, I couldn't understand your request.  Please ask again?");
            alexaResponse.Response.Reprompt.OutputSpeech.Text = "Please ask again?";
            alexaResponse.Response.ShouldEndSession = false;

            return alexaResponse;
        }

    }
}

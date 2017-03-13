using ASK.Domain;

namespace ASK.Services
{
    public interface IAlexaRequestPersistenceService
    {
        void PersistAlexaRequestAndMember(AlexaRequest alexaRequest);
    }
}

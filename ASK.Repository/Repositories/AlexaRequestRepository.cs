using System;
using ASK.Domain;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASK.Repository
{
    public class AlexaRequestRepository : AbstractGenericRepository<AlexaRequest>, IAlexaRequestRepository
    {
        public AlexaRequestRepository(ASKDataContext context) : base(context)
        {
        }

        public ASKDataContext ASKDataContext
        {
            get { return Context as ASKDataContext; }
        }
    }
}

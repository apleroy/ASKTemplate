using ASK.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASK.Repository
{
    public class AlexaMemberRepository : AbstractGenericRepository<AlexaMember>, IAlexaMemberRepository
    {
        public AlexaMemberRepository(ASKDataContext context) : base(context)
        {
        }

        public ASKDataContext ASKDataContext
        {
            get { return Context as ASKDataContext; }
        }
    }
}

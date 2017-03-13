using ASK.Domain;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASK.Repository
{
    public class ASKDataContext : DbContext
    {
        public ASKDataContext() :
            base("ASKDataContext")
        {
        }

        public DbSet<AlexaRequest> AlexaRequests { get; set; }
        public DbSet<AlexaMember> AlexaMembers { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASK.Repository
{
    /// <summary>
    /// Defines the UnitOfWork interface to implement IDisposable
    /// </summary>
    public interface IUnitOfWork : IDisposable
    {

        IAlexaMemberRepository AlexaMembers { get; }
        IAlexaRequestRepository AlexaRequests { get; }

        int Complete();
    }
}

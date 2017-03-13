using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASK.Repository
{
    /// <summary>
    /// Implementation of IUnitOfWork
    /// Responsible for maintaining handle on all repositories
    /// Implements the Dispose method to ensure contexts are deallocated between requests
    /// </summary>
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ASKDataContext _context;

        public UnitOfWork(ASKDataContext context)
        {
            _context = context;
            AlexaMembers = new AlexaMemberRepository(_context);
            AlexaRequests = new AlexaRequestRepository(_context);
        }

        public IAlexaMemberRepository AlexaMembers { get; private set; }
        public IAlexaRequestRepository AlexaRequests { get; private set; }

        public int Complete()
        {
            return _context.SaveChanges();
        }

        private bool disposed = false;

        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    this._context.Dispose();
                }
            }
            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}

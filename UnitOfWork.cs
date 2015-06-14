using Raven.Client;

namespace GestorDeArchivos
{
    public class UnitOfWork : IUnitOfWork
    {
        private DocStore DocStore { get; set; }
        public IDocumentSession Session { get; set; }

        public UnitOfWork()
            : this("GestorDeArchivos")
        {
        }

        public UnitOfWork(string defaultDb)
        {
            DocStore = Program.DocStore;

            Session = DocStore.OpenSession(defaultDb);
            Session.Advanced.UseOptimisticConcurrency = true;   // throws whenever the etag of the DB object is newer than the one being written!
        }

        public void Dispose()
        {
            Session.Dispose();
        }
    }
}
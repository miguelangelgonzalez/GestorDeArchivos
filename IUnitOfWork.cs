using System;
using Raven.Client;

namespace GestorDeArchivos
{
    public interface IUnitOfWork : IDisposable
    {
        IDocumentSession Session { get; set; }
    }
}
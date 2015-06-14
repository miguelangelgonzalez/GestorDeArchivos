using System.ComponentModel.Composition.Hosting;
using System.Configuration;
using System.Linq;
using Raven.Client.Document;
using Raven.Client.Extensions;
using Raven.Client.Indexes;

namespace GestorDeArchivos
{
    public sealed class DocStore : DocumentStore
    {
        public static readonly string DefaultDB = "GestorDeArchivos";

        public DocStore()
        {
            Url = ConfigurationManager.AppSettings["RavenDB"];
            Conventions = new DocumentConvention
            {
                DisableProfiling = true,
                ShouldCacheRequest = x => false,
                SaveEnumsAsIntegers = true,
                MaxNumberOfRequestsPerSession = 9999,
                IdentityPartsSeparator = "_",
                DefaultQueryingConsistency = ConsistencyOptions.AlwaysWaitForNonStaleResultsAsOfLastWrite,
            };

            Initialize();
            DatabaseCommands.EnsureDatabaseExists(DefaultDB);

            var lfCmds = DatabaseCommands.ForDatabase(DefaultDB);

            IndexCreation.CreateIndexes(
                new CompositionContainer(
                    new AssemblyCatalog(typeof(Indexes).Assembly)), lfCmds, Conventions);


        }
    }

    class Indexes
    {
    }

//    public class Archivo_ByAny : AbstractIndexCreationTask<Archivo>
//    {
//        public Archivo_ByAny()
//        {
//            Map = archivos => from arch in archivos
//                              where arch.Nombre
//                          select arch;
//        }
//    }
}
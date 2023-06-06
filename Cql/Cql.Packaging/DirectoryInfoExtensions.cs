using Hl7.Cql.Firely;
using Hl7.Cql.Runtime;
using Hl7.Fhir.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Loader;
using System.Text;
using System.Threading.Tasks;

namespace Hl7.Cql.Packaging
{
    public static  class DirectoryInfoExtensions
    {
        public static IDictionary<string, object?> Run(this DirectoryInfo dir, string lib, string version, CqlContext cqlContext)
        {
            var libFile = new FileInfo(Path.Combine(dir.FullName, $"{lib}-{version}.json"));
            using var fs = libFile.OpenRead();
            var library = fs.ParseFhir<Library>();
            var dependencies = library.GetDependencies(dir);
            var allLibs = dependencies.AllLibraries();
            var asmContext = new AssemblyLoadContext($"{lib}-{version}");
            allLibs.LoadAssemblies(asmContext);

            var tupleTypes = new FileInfo(Path.Combine(dir.FullName, "TupleTypes-Binary.json"));
            using var tupleFs = tupleTypes.OpenRead();
            var binaries = new[]
                        {
                tupleFs.ParseFhir<Binary>()
            };
            binaries.LoadAssembles(asmContext);


            var results = asmContext.Run(lib, version, cqlContext);
            return results;
        }

    }
}

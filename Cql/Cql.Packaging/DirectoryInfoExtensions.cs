/* 
 * Copyright (c) 2023, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 * 
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/cql-sdk/main/LICENSE
 */

using Hl7.Cql.CodeGeneration.NET;
using Hl7.Cql.Compiler;
using Hl7.Cql.Elm;
using Hl7.Cql.Firely;
using Hl7.Fhir.Model;
using Microsoft.Extensions.Logging;
using System.Runtime.Loader;
using Library = Hl7.Fhir.Model.Library;

namespace Hl7.Cql.Packaging
{
    public static class DirectoryInfoExtensions
    {
        public static AssemblyLoadContext LoadResources(this DirectoryInfo dir, string lib, string version)
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
            return asmContext;
        }

        public static AssemblyLoadContext LoadElm(this DirectoryInfo elmDirectory,
            string lib,
            string version,
            ILogger<ExpressionBuilder>? builderLogger = null,
            ILogger<CSharpSourceCodeWriter>? codeWriterLogger = null,
            LogLevel logLevel = LogLevel.Information)
        {
            var elmFile = new FileInfo(Path.Combine(elmDirectory.FullName, $"{lib}-{version}.json"));
            if (!elmFile.Exists)
                elmFile = new FileInfo(Path.Combine(elmDirectory.FullName, $"{lib}.json"));
            if (!elmFile.Exists)
                throw new ArgumentException($"Cannot find a matching ELM file for {lib} version {version} in {elmDirectory.FullName}", nameof(lib));
            var library = Elm.Library.LoadFromJson(elmFile)
                ?? throw new InvalidOperationException($"File {elmFile.FullName} is not a valid ELM package.");
            var dependencies = Elm.Library
                .GetIncludedLibraries(library, elmDirectory)
                .Packages()
                .ToArray();

            var typeResolver = new FirelyTypeResolver(ModelInfo.ModelInspector);
            var typeConverter = FirelyTypeConverter.Create(ModelInfo.ModelInspector);
            var typeManager = new TypeManager(typeResolver);
            var operatorBinding = new CqlOperatorsBinding(typeResolver, typeConverter);
            var compiler = new AssemblyCompiler(typeResolver, typeManager, operatorBinding);

            var assemblyData = compiler.Compile(dependencies,
                builderLogger,
                codeWriterLogger,
                logLevel);

            var asmContext = new AssemblyLoadContext($"{lib}-{version}");
            foreach (var kvp in assemblyData)
            {
                var assemblyBytes = kvp.Value.Binary;
                using var ms = new MemoryStream(assemblyBytes);
                asmContext.LoadFromStream(ms);
            }
            return asmContext;
        }

    }
}

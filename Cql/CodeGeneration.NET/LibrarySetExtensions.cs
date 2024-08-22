using Hl7.Cql.Compiler;
using Hl7.Cql.Runtime;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Hl7.Cql.CodeGeneration.NET
{
    /// <summary>
    /// Extension methods for <see cref="LibrarySet"/>
    /// </summary>
    public static class LibrarySetExtensions
    {
        /// <summary>
        /// Translates this library set to C# code.
        /// </summary>
        /// <param name="librarySet">The library set to translate.</param>
        /// <returns>A dictionary of library identifiers to source code.</returns>
        public static IDictionary<string,string> ToCSharp(this LibrarySet librarySet)
        {
            var services = new ServiceCollection()
                .AddLogging(builder => builder.AddDebug())
                .AddSingleton(typeof(CqlCompilerFactory))
                .AddSingleton(typeof(CSharpLibrarySetToStreamsWriter))
                .AddSingleton(typeof(TypeToCSharpConverter))
                .AddSingleton(isp => isp.GetRequiredService<CqlCompilerFactory>().TypeResolver)
                .BuildServiceProvider();
            return ToCSharp(librarySet, services);
        }

        /// <summary>
        /// Translates this library set to C# code.
        /// </summary>
        /// <param name="librarySet">The library set to translate.</param>
        /// <param name="services">The services to use.</param>
        /// <returns>A dictionary of library identifiers to source code.</returns>
        public static IDictionary<string, string> ToCSharp(this LibrarySet librarySet, IServiceProvider services)
        {
            var writer = services.GetRequiredService<CSharpLibrarySetToStreamsWriter>();
            var csByNav = new Dictionary<string, string>();
            var callbacks = new CSharpSourceCodeWriterCallbacks(onAfterStep: afterWrite);
            void afterWrite(CSharpSourceCodeStep step)
            {
                switch (step)
                {
                    case CSharpSourceCodeStep.OnStream onStream:
                        onStream.Stream.Seek(0, SeekOrigin.Begin);
                        using (var reader = new StreamReader(onStream.Stream))
                        {
                            var code = reader.ReadToEnd();
                            csByNav.Add(onStream.Name, code);
                        }
                        break;
                    default:
                        break;
                }
            }
            var factory = services.GetRequiredService<CqlCompilerFactory>();
            var builder = factory.LibrarySetExpressionBuilder;
            var definitions = builder.ProcessLibrarySet(librarySet);
            writer.ProcessDefinitions(definitions, librarySet, callbacks);
            return csByNav;
        }

        /// <summary>
        /// Compiles this library set to .NET assemblies.
        /// </summary>
        /// <param name="librarySet">The library set to compile.</param>
        /// <returns>A dictionary of library identifiers to assemblies.</returns>
        public static IDictionary<string, byte[]> Compile(this LibrarySet librarySet)
        {
            var services = new ServiceCollection()
                .AddLogging(builder => builder.AddDebug())
                .AddSingleton(typeof(TypeManager))
                .AddSingleton(typeof(CqlCompilerFactory))
                .AddSingleton(typeof(CSharpLibrarySetToStreamsWriter))
                .AddSingleton(typeof(AssemblyCompiler))
                .AddSingleton(typeof(TypeToCSharpConverter))
                .AddSingleton(isp => isp.GetRequiredService<CqlCompilerFactory>().TypeResolver)
                .BuildServiceProvider();
            var factory = services.GetRequiredService<CqlCompilerFactory>();
            var builder = factory.LibrarySetExpressionBuilder;
            var definitions = builder.ProcessLibrarySet(librarySet);
            var asm = services.GetRequiredService<AssemblyCompiler>();

            return asm.Compile(librarySet, definitions)
                .ToDictionary(kvp => kvp.Key, kvp => kvp.Value.Binary);
        }
    }
}

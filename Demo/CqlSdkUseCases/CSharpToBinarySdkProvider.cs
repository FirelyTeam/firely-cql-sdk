using Hl7.Cql.CodeGeneration.NET;
using Hl7.Cql.Compiler;

namespace CqlSdkUseCases;

internal class CSharpToBinarySdkProvider(
    AssemblyCompiler assemblyCompiler)
{
    public CSharpToBinarySdk ForLibrarySet(LibrarySet librarySet) =>
        new CSharpToBinarySdk(assemblyCompiler, librarySet);
}
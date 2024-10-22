using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.Loader;
using Hl7.Cql.CodeGeneration.NET;
using Hl7.Cql.Compiler;
using Hl7.Cql.Elm;
using Hl7.Cql.Fhir;
using Hl7.Cql.Packaging;
using Hl7.Cql.Runtime;

namespace Hl7.Cql.CqlToElm.Test;
internal static class Extensions
{
    private static readonly CqlContext DefaultCqlContext = FhirCqlContext.CreateContext();
    private static readonly Library DummyLib = new Library { identifier = new() { id = "temp", version = "1.0.0" } };

    public static object? RunLambda(
        this AssemblyCompiler assemblyCompiler,
        LambdaExpression expression,
        Library? library,
        CqlContext? ctx = null)
    {
        var expressionName = expression.Name ?? "Expression";
        library ??= DummyLib;
        LibrarySet librarySet = new (expressionName, library);
        DefinitionDictionary<LambdaExpression> definitions = new();
        switch (((IGetVersionedIdentifier)library).VersionedIdentifier)
        {
            case (null, {} error):
                throw new InvalidOperationException("Library does not have valid VersionedIdentifier.", error);
            case ({ } versionedIdentifier, null):
            {
                string versionedIdentifierString = versionedIdentifier.GetVersionedIdentifier()!;
                definitions.Add(versionedIdentifierString, expressionName, expression);
                IReadOnlyDictionary<string, AssemblyData> assemblyDatas = assemblyCompiler.Compile(librarySet, definitions);
                (byte[] assemblyBinary, var assemblySources) = assemblyDatas.SingleOrDefault().Value;
                var source = assemblySources[versionedIdentifierString];
                AssemblyLoadContext assemblyLoadContext = new(expressionName);
                assemblyLoadContext.LoadFromStream(new MemoryStream(assemblyBinary));
                var result = assemblyLoadContext.Run(versionedIdentifier.id, versionedIdentifier.version, ctx ?? DefaultCqlContext);
                return result[expressionName];
            }
            default:
                throw new InvalidOperationException("VersionedIdentifier is null");
        }
    }
}

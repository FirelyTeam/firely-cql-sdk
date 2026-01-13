/*
 * Copyright (c) 2023, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using Hl7.Cql.Abstractions;
using Hl7.Cql.Compiler;
using Hl7.Cql.Operators;
using Hl7.Cql.Primitives;
using Hl7.Cql.Runtime;
using Hl7.Cql.ValueSets;

namespace Hl7.Cql.CodeGeneration.NET;

/// <summary>
/// Processes a definition dictionary of <see cref="LambdaExpression"/> into a .NET classes per library.
/// </summary>
internal partial class LibrarySetCSharpCodeGenerator
{
    /// <summary>
    /// Processes a definition dictionary of <see cref="LambdaExpression"/> into a .NET classes per library.
    /// </summary>
    public LibrarySetCSharpCodeGenerator(
        TypeResolver typeResolver,
        TypeToCSharpConverter typeToCSharpConverter)
    {
        _typeToCSharpConverter = typeToCSharpConverter;
        _usings = BuildUsings(typeResolver);
        _aliasedUsings = typeResolver.Aliases.ToList();
    }

    /// <summary>
    /// Gets the product of this <see cref="LibrarySetCSharpCodeGenerator"/> as will appear
    /// in the <see cref="System.CodeDom.Compiler.GeneratedCodeAttribute.Tool"/>.
    /// </summary>
    private static string GeneratorToolName { get; } = GetGeneratorToolNameFromAssemblyProductName();

    private readonly TypeToCSharpConverter _typeToCSharpConverter;

    /// <summary>
    /// Gets the <see langword="using"/> statements to be included in the generated code.
    /// </summary>
    private readonly HashSet<string> _usings;

    /// <summary>
    /// Gets the aliased <see langword="using"/> statements to be included in the generated code.
    /// For example,
    /// <code>
    /// using Item1 = Item2;
    /// </code>
    /// </summary>
    private readonly IReadOnlyList<(string alias, string type)> _aliasedUsings;

    private static string GetGeneratorToolNameFromAssemblyProductName() =>
        typeof(LibrarySetCSharpCodeGenerator)
            .Assembly
            .GetCustomAttributes(false)
            .OfType<AssemblyProductAttribute>()
            .SingleOrDefault()?
            .Product ?? "ELM-to-CSharp";

    private static HashSet<string> BuildUsings(TypeResolver typeResolver)
    {
        var hashSet = new HashSet<string>
        {
            nameof(System),
            typeof(Enumerable).Namespace!,    // System.Linq
            typeof(ICollection<>).Namespace!, // System.Collections.Generic
            typeof(CqlContext).Namespace!,
            typeof(CqlPrimitiveType).Namespace!,
            typeof(CqlDefinitionAttribute).Namespace!,
            typeof(IValueSetFacade).Namespace!,
            typeof(Iso8601.DateIso8601).Namespace!,
            typeof(PropertyInfo).Namespace!,
            typeof(RetrieveParameters).Namespace!,
        };

        foreach (var @using in typeResolver.ModelNamespaces)
            hashSet.Add(@using);

        return hashSet;
    }

    public IEnumerable<(ElmLibrary library, string cSharp)> GenerateEachLibraryToCSharp(
        LibrarySet librarySet,
        CqlDefinitionDictionary definitions,
        string? @namespace = null,
        BatchProcessExceptionHandlingStrategyBuilder<ElmLibrary>? buildExceptionHandlingStrategy = null,
        Action<ElmLibrary>? onBeforeProcessLibrary = null)
    {
        var cacheKeyGenerator = new DeterministicIdGenerator(librarySet.Name);
        var librarySetWriter = new LibrarySetWriter(this, librarySet, definitions, cacheKeyGenerator, @namespace);
        return librarySetWriter.GenerateEachLibraryToCSharp(buildExceptionHandlingStrategy, onBeforeProcessLibrary);
    }

    private static (string quotedName, string methodName, string fieldName) GetMemberNames(CqlDefinition cqlDefinition)
    {
        var name = cqlDefinition.Name;
        string quotedName = name.QuoteString();
        string methodName = IdentifierNormalizer.Normalize(name);
        string fieldName = IdentifierNormalizer.Normalize($"_{name}");
        return (quotedName, methodName, fieldName);
    }
}
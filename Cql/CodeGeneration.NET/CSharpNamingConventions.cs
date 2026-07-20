/*
 * Copyright (c) 2026, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using Hl7.Cql.Compiler;
using Hl7.Cql.Compiler.Ir;

namespace Hl7.Cql.CodeGeneration.NET;

/// <summary>
/// The production <see cref="ICSharpNamingConventions"/> implementation, backed by the same
/// building blocks the library scaffolding writer uses — <see cref="IdentifierNormalizer"/>
/// for member/class names and <see cref="TupleMetadataBuilder"/> for the tuple-metadata field
/// names — so the expression bodies printed by <see cref="CSharpIrEmitter"/> reference exactly
/// the members the scaffolding declares.
///
/// <para>One instance exists per library being written: <paramref name="libraryVersionedIdentifier"/>
/// is the "Name-Version" identifier of that library (e.g. <c>"FHIRHelpers-4.0.1"</c>), which
/// keys the tuple-metadata registrations and matches how the old
/// <c>LambdaDefinitionWriter.GetTargetedMemberName</c>/<c>BuildMemberInitTupleExpression</c>
/// resolved these names.</para>
/// </summary>
internal sealed class CSharpNamingConventions(
    TypeToCSharpConverter typeToCSharpConverter,
    TupleMetadataBuilder tupleMetadataBuilder,
    string libraryVersionedIdentifier) : ICSharpNamingConventions
{
    /// <inheritdoc/>
    /// <remarks>Registers the tuple type's signature with the shared
    /// <see cref="TupleMetadataBuilder"/> as a side effect, exactly like the old pipeline's
    /// <c>BuildMemberInitTupleExpression</c> did — the scaffolding writer later emits one
    /// static field per registered signature (see <c>AppendCqlTupleMetadataProperties</c>).</remarks>
    public string TupleMetadataFieldName(Type tupleType)
    {
        var tupleProperties = typeToCSharpConverter
                              .GetTupleProperties(tupleType)
                              .ToList();
        return tupleMetadataBuilder.GetTupleMetadataPropertyName(tupleProperties, libraryVersionedIdentifier);
    }

    /// <inheritdoc/>
    /// <remarks>Mirrors the old <c>LambdaDefinitionWriter.GetTargetedMemberName</c>:
    /// <c>this.{member}</c> for the library being generated, and
    /// <c>{normalizedLibraryClassName}.Instance.{member}</c> for an included library, where
    /// the class name is the normalized "Name-Version" identifier — the same mangling
    /// <c>LibraryWriter.AppendLibraryFile</c> applies when naming the generated classes.</remarks>
    public string DefinitionTarget(IrDefinitionCall definitionCall)
    {
        var member = IdentifierNormalizer.Normalize(definitionCall.DefinitionName);

        if (definitionCall.IsLocalLibrary)
            return $"this.{member}";

        var versionedIdentifier = definitionCall.LibraryVersion is { Length: > 0 } version
            ? $"{definitionCall.LibraryName}-{version}"
            : definitionCall.LibraryName;
        return $"{IdentifierNormalizer.Normalize(versionedIdentifier)}.Instance.{member}";
    }
}

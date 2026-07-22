/*
 * Copyright (c) 2026, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using Hl7.Cql.Compiler.CodeModel;

namespace Hl7.Cql.CodeGeneration.NET;

/// <summary>
/// The naming conventions of the generated library classes that <see cref="CSharpEmitter"/>
/// must agree with when printing expression bodies. Implemented by the library scaffolding
/// writer, which owns identifier normalization, class naming and the class-level members the
/// bodies refer to; faked in unit tests.
///
/// <para>A mismatch between an implementation and the actual scaffolding output produces
/// generated C# that references a nonexistent member — caught by compilation and the
/// golden-file tests, never as silently wrong results.</para>
/// </summary>
internal interface ICSharpNamingConventions
{
    /// <summary>
    /// The name of the class-level <c>CqlTupleMetadata_…</c> static field emitted for the
    /// given tuple type, referenced by tuple literals in expression bodies.
    /// </summary>
    string TupleMetadataFieldName(Type tupleType);

    /// <summary>
    /// The invocation target for a call to another CQL definition, e.g. <c>this.Foo</c> for
    /// the library being generated or <c>FHIRHelpers_4_0_001.Instance.ToCode</c> for an
    /// included library (without the argument list).
    /// </summary>
    string DefinitionTarget(CodeDefinitionCall definitionCall);
}

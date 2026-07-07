/*
 * Copyright (c) 2026, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

namespace Hl7.Cql.Compiler.Ir;

/// <summary>
/// A call to another CQL definition or function, printed as <c>this.Name(context, ...)</c>
/// for the library being generated and <c>LibraryClass.Instance.Name(context, ...)</c> for an
/// included library — as opposed to <see cref="IrInvoke"/>, which invokes pre-existing .NET
/// methods. Replaces the old <c>DefinitionCallExpression</c>/<c>FunctionCallExpression</c>
/// custom nodes (whose <c>Reduce()</c> bodies only served the removed in-memory execution path).
/// </summary>
internal sealed class IrDefinitionCall : IrExpression
{
    public IrDefinitionCall(
        string libraryName,
        string libraryVersion,
        string definitionName,
        bool isLocalLibrary,
        IReadOnlyList<IrExpression> arguments,
        Type returnType)
    {
        if (arguments.Count == 0 || arguments[0] is not IrContextParameter)
            throw new ArgumentException($"A definition call to {definitionName} must pass the CqlContext as its first argument.");

        LibraryName = libraryName;
        LibraryVersion = libraryVersion;
        DefinitionName = definitionName;
        IsLocalLibrary = isLocalLibrary;
        Arguments = arguments;
        Type = returnType;
    }

    public string LibraryName { get; }

    public string LibraryVersion { get; }

    /// <summary>The CQL definition name; the emitter applies the same identifier
    /// normalization the class scaffolding uses for the method name.</summary>
    public string DefinitionName { get; }

    /// <summary>True when the definition lives in the library being generated
    /// (printed as <c>this.…</c>), false for an included library
    /// (printed via the library class singleton).</summary>
    public bool IsLocalLibrary { get; }

    /// <summary>The arguments, starting with the <see cref="IrContextParameter"/>.</summary>
    public IReadOnlyList<IrExpression> Arguments { get; }

    public override Type Type { get; }
}

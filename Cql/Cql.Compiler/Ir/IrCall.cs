/*
 * Copyright (c) 2026, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

namespace Hl7.Cql.Compiler.Ir;

/// <summary>
/// A method call: instance calls (<see cref="Receiver"/> set) and static calls
/// (<see cref="Receiver"/> null). This covers calls to <c>ICqlOperators</c> methods
/// (receiver is a property access on the context), <c>CqlContext</c> members, and any other
/// .NET method the builder binds to.
///
/// <para>The constructor performs the validation <c>Expression.Call</c> used to do silently:
/// the method must be resolved (no open generic definitions), the argument count must match,
/// and each argument must be assignable to its parameter. Overload <i>resolution</i> stays in
/// the binder; the IR only checks that the chosen method is callable with these arguments.</para>
/// </summary>
internal sealed class IrCall : IrExpression
{
    public IrCall(IrExpression? receiver, MethodInfo method, params IrExpression[] arguments)
    {
        if (method.IsGenericMethodDefinition)
            throw new ArgumentException($"Method {method.Name} is an open generic method definition; construct the closed method before building a call.");
        if (method.IsStatic != receiver is null)
            throw new ArgumentException(method.IsStatic
                ? $"Static method {method.Name} cannot have a receiver."
                : $"Instance method {method.Name} requires a receiver.");
        if (receiver is not null && !IrTypeRules.CanBeAssigned(receiver.Type, method.DeclaringType!))
            throw new ArgumentException($"Receiver of type {receiver.Type} does not declare method {method.Name} (expected {method.DeclaringType}).");

        var parameters = method.GetParameters();
        if (parameters.Length != arguments.Length)
            throw new ArgumentException($"Method {method.Name} takes {parameters.Length} argument(s), got {arguments.Length}.");
        for (int i = 0; i < arguments.Length; i++)
            IrTypeRules.ValidateAssignment(arguments[i], parameters[i].ParameterType, $"Argument {i} of {method.DeclaringType?.Name}.{method.Name}");

        Receiver = receiver;
        Method = method;
        Arguments = arguments;
    }

    /// <summary>The instance the method is invoked on, or null for static methods.</summary>
    public IrExpression? Receiver { get; }

    public MethodInfo Method { get; }

    public IReadOnlyList<IrExpression> Arguments { get; }

    public override Type Type => Method.ReturnType;
}

/// <summary>
/// A call to another CQL definition or function, printed as <c>this.Name(context, ...)</c>
/// for the library being generated and <c>LibraryClass.Instance.Name(context, ...)</c> for an
/// included library. Replaces the old <c>DefinitionCallExpression</c>/<c>FunctionCallExpression</c>
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

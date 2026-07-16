/*
 * Copyright (c) 2026, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

namespace Hl7.Cql.Compiler.Ir;

/// <summary>
/// A .NET method invocation: instance calls (<see cref="Receiver"/> set) and static calls
/// (<see cref="Receiver"/> null), optionally null-conditional (<c>x?.Method(…)</c>).
/// This covers calls to <c>ICqlOperators</c> methods (receiver is a property access on the
/// context), <c>CqlContext</c> members, and any other .NET method the builder binds to —
/// as opposed to <see cref="IrDefinitionCall"/>, which invokes the C# methods this compiler
/// itself generates from CQL definitions.
///
/// <para>The constructor performs the validation <c>Expression.Call</c> used to do silently:
/// the method must be resolved (no open generic definitions), the argument count must match,
/// and each argument must be assignable to its parameter. Overload <i>resolution</i> stays in
/// the binder; the IR only checks that the chosen method is callable with these arguments.</para>
/// </summary>
internal sealed class IrInvoke : IrExpression
{
    public IrInvoke(IrExpression? receiver, MethodInfo method, params IrExpression[] arguments)
        : this(receiver, method, nullConditional: false, arguments)
    {
    }

    public IrInvoke(IrExpression? receiver, MethodInfo method, bool nullConditional, params IrExpression[] arguments)
    {
        if (method.IsGenericMethodDefinition)
            throw new ArgumentException($"Method {method.Name} is an open generic method definition; construct the closed method before building a call.");
        if (method.IsStatic != receiver is null)
            throw new ArgumentException(method.IsStatic
                ? $"Static method {method.Name} cannot have a receiver."
                : $"Instance method {method.Name} requires a receiver.");
        if (receiver is not null && !IrTypeRules.CanBeAssigned(receiver.Type, method.DeclaringType!))
            throw new ArgumentException($"Receiver of type {receiver.Type} does not declare method {method.Name} (expected {method.DeclaringType}).");
        if (nullConditional && receiver is null)
            throw new ArgumentException($"A null-conditional call to {method.Name} requires a receiver.");

        var parameters = method.GetParameters();
        if (parameters.Length != arguments.Length)
            throw new ArgumentException($"Method {method.Name} takes {parameters.Length} argument(s), got {arguments.Length}.");
        for (int i = 0; i < arguments.Length; i++)
            IrTypeRules.ValidateAssignment(arguments[i], parameters[i].ParameterType, $"Argument {i} of {method.DeclaringType?.Name}.{method.Name}");

        Receiver = receiver;
        Method = method;
        NullConditional = nullConditional;
        Arguments = arguments;

        // x?.Method(…) yields null when x is null, so the result type must admit null.
        Type = nullConditional && method.ReturnType.IsValueType && Nullable.GetUnderlyingType(method.ReturnType) is null
            ? typeof(Nullable<>).MakeGenericType(method.ReturnType)
            : method.ReturnType;
    }

    /// <summary>The instance the method is invoked on, or null for static methods.</summary>
    public IrExpression? Receiver { get; }

    public MethodInfo Method { get; }

    /// <summary>True to print <c>?.</c> instead of <c>.</c>.</summary>
    public bool NullConditional { get; }

    public IReadOnlyList<IrExpression> Arguments { get; }

    public override Type Type { get; }
}

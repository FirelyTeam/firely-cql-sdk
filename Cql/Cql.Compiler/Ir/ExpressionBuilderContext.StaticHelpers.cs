/*
 * Copyright (c) 2026, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using Hl7.Cql.Abstractions.Infrastructure;
using Hl7.Cql.Compiler.Infrastructure;
using Hl7.Cql.Model;

namespace Hl7.Cql.Compiler.Ir;

using F = Hl7.Fhir.Model;

/// <summary>
/// IR counterpart of <c>ExpressionBuilderContext.StaticHelpers.cs</c>: the QiCore binding
/// workaround, nullable handling, null propagation and identifier helpers. This is a
/// mechanical port; see the remarks on <see cref="ExpressionBuilderContext"/>.
/// </summary>
partial class ExpressionBuilderContext
{
    // Yeah, hardwired to FHIR 4.0.1 for now.
    private static readonly IDictionary<string, ClassInfo> ModelMapping = Models.ClassesById(Models.Fhir401);


    private static readonly Dictionary<(Type, Type), Type> KnownErrors = new()
    {
        [(typeof(F.ObservationStatus?), typeof(F.Code<F.VerificationResult.StatusCode>))] = typeof(F.ObservationStatus?)
    };

    // At this moment (20240308) the QICore translation by the current tooling (3.8.0.0) of the CQl-to-ELM
    // translator is incorrect. This method is a temporary workaround to correct the incorrectly mapped binding
    // names. This method should be removed once the QICore translation is fixed.
    // See https://github.com/cqframework/cqf-tooling/issues/518.
    private static bool TryCorrectQiCoreBindingError(Type source, Type to, out Type? correctedTo)
    {
        return KnownErrors.TryGetValue((source, to), out correctedTo);
    }

    private IrLambda NotImplemented(
        string nav,
        (string name, Type type)[] signature,
        Type returnType)
    {
        var parameters = signature.SelectToArray(type => new IrLocal(type.type, type.name));
        var ctor = ConstructorInfos.NotImplementedException;
        var @new = new IrNew(ctor, new IrConstant($"External function {nav} is not implemented.", typeof(string)));
        var @throw = new IrThrow(@new, returnType);
        var lambda = new IrLambda(parameters, @throw);
        return lambda;
    }

    private static IrExpression HandleNullable(IrExpression expression, Type targetType) =>
        (
                exprNullTypeArg: Nullable.GetUnderlyingType(expression.Type),
                targetNullTypeArg: Nullable.GetUnderlyingType(targetType)) switch
            {
                // Only targetType is nullable
                (exprNullTypeArg: null, targetNullTypeArg: not null) => expression.NewAssignToTypeExpression(targetType),

                // Both are nullable or not nullable
                ({ } exprNullTypeArg, targetNullTypeArg: null) => new IrBinary(IrBinaryOp.Coalesce, expression, new IrDefault(exprNullTypeArg)),

                _ => expression,
            };

    /// <summary>
    /// Implements the null propagation operator (x?.y) into (x == null ? null : x.y);
    /// </summary>
    private static IrExpression PropagateNull(IrExpression before, MemberInfo member)
    {
        if (before.Type.IsValueType)
            return before;
        return new IrProperty(before, member, nullConditional: true);
    }

    private static string TypeNameToIdentifier(Type type, ExpressionBuilderContext? ctx = null)
    {
        var typeName = type.Name.ToLowerInvariant();
        if (type.IsGenericType)
        {
            var typeNames = type.GetGenericArguments()
                .Select(t => TypeNameToIdentifier(t, ctx)
                .TrimStart('@'));
            var genericTypeNames = string.Join("_", typeNames);
            var tick = typeName.IndexOf('`');
            if (tick > -1)
                typeName = typeName[..tick];
            var fullName = $"{typeName}_{genericTypeNames}";
            typeName = fullName;
        }

        if (ctx != null)
        {
            int i = 1;
            var uniqueTypeName = typeName;
            while (ctx.HasScope(uniqueTypeName))
            {
                uniqueTypeName = $"{typeName}{i}";
                i++;
            }
            typeName = uniqueTypeName;
        }

        return IdentifierNormalizer.Normalize(typeName!)!;
    }

    protected interface IPopToken : IDisposable
    {
        void Pop();
    }

    private readonly record struct EmptyDisposable : IPopToken
    {
        public static readonly EmptyDisposable Instance = new();

        void IDisposable.Dispose()
        {
        }

        void IPopToken.Pop()
        {
        }
    }
}

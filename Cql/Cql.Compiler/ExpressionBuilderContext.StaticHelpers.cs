/*
 * Copyright (c) 2024, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using Hl7.Cql.Abstractions.Infrastructure;
using Hl7.Cql.Compiler.Expressions;
using Hl7.Cql.Compiler.Infrastructure;
using Hl7.Cql.Model;
using Microsoft.CodeAnalysis.CSharp;
using Expression = System.Linq.Expressions.Expression;
using F = Hl7.Fhir.Model;


namespace Hl7.Cql.Compiler;

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

    private LambdaExpression NotImplemented(
        string nav,
        Type[] signature,
        Type returnType)
    {
        var parameters = signature.SelectToArray((type, index) => Expression.Parameter(type, TypeNameToIdentifier(type, this) + index));
        var ctor = ConstructorInfos.NotImplementedException;
        var @new = Expression.New(ctor, Expression.Constant($"External function {nav} is not implemented."));
        var @throw = Expression.Throw(@new, returnType);
        var lambda = Expression.Lambda(@throw, parameters);
        return lambda;
    }

    internal static string NormalizeIdentifier(string identifier)
    {
        identifier = identifier.Replace(" ", "_");
        identifier = identifier.Replace("-", "_");
        identifier = identifier.Replace(".", "_");
        identifier = identifier.Replace(",", "_");
        identifier = identifier.Replace("[", "_");
        identifier = identifier.Replace("]", "_");
        identifier = identifier.Replace("(", "_");
        identifier = identifier.Replace(")", "_");
        identifier = identifier.Replace(":", "_");
        identifier = identifier.Replace("/", "_");
        identifier = identifier.Replace("+", "plus");
        identifier = identifier.Replace("-", "minus");
        identifier = identifier.Replace("\"", "");
        identifier = identifier.Replace("'", "");
        identifier = identifier.Replace(";", "_");
        identifier = identifier.Replace("&", "and");


        if (identifier.StartsWith("$"))
            identifier = identifier.Substring(1);
        var keyword = SyntaxFacts.GetKeywordKind(identifier);
        if (keyword != SyntaxKind.None)
        {
            identifier = $"@{identifier}";
        }
        if (char.IsDigit(identifier[0]))
            identifier = "_" + identifier;
        return identifier;
    }

    private static Expression HandleNullable(Expression expression, Type targetType) =>
        (
                exprNullTypeArg: Nullable.GetUnderlyingType(expression.Type),
                targetNullTypeArg: Nullable.GetUnderlyingType(targetType)) switch
            {
                // Only targetType is nullable
                (exprNullTypeArg: null, targetNullTypeArg: not null) => expression.NewAssignToTypeExpression(targetType),

                // Both are nullable or not nullable
                ({ } exprNullTypeArg, targetNullTypeArg: null) => Expression.Coalesce(expression, Expression.Default(exprNullTypeArg)),

                _ => expression,
            };

    /// <summary>
    /// Implements the null propagation operator (x?.y) into (x == null ? null : x.y);
    /// </summary>
    private static Expression PropagateNull(Expression before, MemberInfo member)
    {
        if (before.Type.IsValueType)
            return before;
        return new NullConditionalMemberExpression(before, member);
    }

    private static string TypeNameToIdentifier(Type type, ExpressionBuilderContext? ctx = null)
    {
        var typeName = type.Name.ToLowerInvariant();
        if (type.IsGenericType)
        {
            var genericTypeNames = string.Join("_", type.GetGenericArguments().Select(t => TypeNameToIdentifier(t, ctx)));
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

        return NormalizeIdentifier(typeName!)!;
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
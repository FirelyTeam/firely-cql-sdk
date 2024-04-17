using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using Hl7.Cql.Abstractions;
using Hl7.Cql.Abstractions.Infrastructure;
using Hl7.Cql.Elm;
using Hl7.Cql.Model;
using Microsoft.CodeAnalysis.CSharp;
using Expression = System.Linq.Expressions.Expression;
using F = Hl7.Fhir.Model;


namespace Hl7.Cql.Compiler;

partial class ExpressionBuilder
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

    private static LambdaExpression NotImplemented(
        ExpressionBuilder ctx,
        string nav,
        Type[] signature,
        Type returnType)
    {
        var parameters = signature.SelectToArray((type, index) => Expression.Parameter(type, TypeNameToIdentifier(type, ctx) + index));
        var ctor = ConstructorInfos.NotImplementedException;
        var @new = Expression.New(ctor, Expression.Constant($"External function {nav} is not implemented."));
        var @throw = Expression.Throw(@new, returnType);
        var lambda = Expression.Lambda(@throw, parameters);
        //var funcTypes = new Type[functionParameterTypes.Length + 1];
        //Array.Copy(functionParameterTypes, funcTypes, functionParameterTypes.Length);
        //funcTypes[funcTypes.Length - 1] = returnType;
        //var funcType = GetFuncType(funcTypes);
        //var makeLambda = MakeGenericLambda.Value.MakeGenericMethod(funcType);
        //var lambda = (LambdaExpression)makeLambda.Invoke(null, new object[] { @throw, parameters });
        return lambda;
    }

    protected internal static PropertyInfo? GetProperty(Type type, string name, TypeResolver typeResolver)
    {
        if (type.IsGenericType)
        {
            var gtd = type.GetGenericTypeDefinition();
            if (gtd == typeof(Nullable<>))
            {
                if (string.Equals(name, "value", StringComparison.OrdinalIgnoreCase))
                {
                    var valueMember = type.GetProperty("Value");
                    return valueMember;
                }
            }
        }

        var member = typeResolver.GetProperty(type, name);
        return member;
    }

    protected static Type GetFuncType(Type[] funcTypeParameters) =>
        funcTypeParameters.Length switch
        {
            0 => throw new NotSupportedException(),
            1 => typeof(Func<>).MakeGenericType(funcTypeParameters),
            2 => typeof(Func<,>).MakeGenericType(funcTypeParameters),
            3 => typeof(Func<,,>).MakeGenericType(funcTypeParameters),
            4 => typeof(Func<,,,>).MakeGenericType(funcTypeParameters),
            5 => typeof(Func<,,,,>).MakeGenericType(funcTypeParameters),
            6 => typeof(Func<,,,,,>).MakeGenericType(funcTypeParameters),
            7 => typeof(Func<,,,,,,>).MakeGenericType(funcTypeParameters),
            8 => typeof(Func<,,,,,,,>).MakeGenericType(funcTypeParameters),
            9 => typeof(Func<,,,,,,,,>).MakeGenericType(funcTypeParameters),
            10 => typeof(Func<,,,,,,,,,>).MakeGenericType(funcTypeParameters),
            11 => typeof(Func<,,,,,,,,,,>).MakeGenericType(funcTypeParameters),
            12 => typeof(Func<,,,,,,,,,,,>).MakeGenericType(funcTypeParameters),
            13 => typeof(Func<,,,,,,,,,,,,>).MakeGenericType(funcTypeParameters),
            14 => typeof(Func<,,,,,,,,,,,,,>).MakeGenericType(funcTypeParameters),
            15 => typeof(Func<,,,,,,,,,,,,,,>).MakeGenericType(funcTypeParameters),
            _ => throw new NotSupportedException("Functions with more than 15 parameters are not supported.")
        };

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
                (exprNullTypeArg: null, targetNullTypeArg: not null) => expression.ExprConvert(targetType),

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

    internal static string TypeNameToIdentifier(Type type, ExpressionBuilder? ctx)
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
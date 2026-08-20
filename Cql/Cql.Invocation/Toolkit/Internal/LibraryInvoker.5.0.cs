/*
 * Copyright (c) 2025, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using Hl7.Cql.Abstractions;
using Hl7.Cql.Abstractions.Infrastructure;
using Hl7.Cql.CodeGeneration.NET;
using Hl7.Cql.Runtime;
using Hl7.Cql.Toolkit;

namespace Hl7.Cql.Invocation.Toolkit.Internal;

internal sealed class LibraryInstanceInvoker_5_0 : LibraryInstanceInvoker
{
    private LibraryInstanceInvoker_5_0(
        LibrarySetInvoker librarySetInvoker,
        ILibrary library) : base(librarySetInvoker, library)
    {
        Definitions = library
                      .GetType()
                      .GetMethods(BindingFlags.Public | BindingFlags.Instance)
                      .SelectWhere(methodInfo => DefinitionInvoker_5_0.TryCreate(Library, this, methodInfo))
                      .ToFrozenDictionary(o => o.DefinitionSignature, o => o)
                      .AsReadOnly();
    }

    /// <summary>
    /// The minimum (inclusive) CQL code generator tool version this invoker supports.
    /// </summary>
    public static readonly Version MinSupportedGeneratorToolVersion = new(5,1,0,0);

    /// <summary>
    /// The first (exclusive) CQL code generator tool version this invoker does not support.
    /// </summary>
    /// <remarks>
    /// Widened from 5.2.0.0 to 5.3.0.0 for generator version 5.2.0.0 (operator fusion, #1484).
    /// Widened again from 5.3.0.0 to 5.4.0.0 for generator version 5.3.0.0 (nullable annotations).
    /// Both were minor bumps because the generated C# call shape this invoker binds to did not
    /// change.
    /// In 5.2.0.0 the generated C# began calling four new
    /// <c>ICqlOperators</c> members, but nothing this invoker binds to changed - the library
    /// shape (the <c>Instance</c> property, <c>ILibrary</c>, <c>CqlDefinitionAttribute</c>, the
    /// definition method signatures) is exactly as before - so the existing invoker keeps
    /// working and no new one is needed.
    /// </remarks>
    public static readonly Version FirstUnsupportedGeneratorToolVersion = new(5,4,0,0);

    public override IReadOnlyDictionary<DefinitionSignature, DefinitionInvoker> Definitions { get; }

    private static object GetLibraryFromStaticInstanceProperty(Type libraryType) =>
        libraryType.GetProperty("Instance", BindingFlags.Public | BindingFlags.Static)?.GetValue(null)
        ?? throw new InvalidOperationException($"Unable to create an instance of {libraryType.FullName}");

    public static bool TryCreate(
        LibrarySetInvoker librarySetInvoker,
        Type libraryType,
        [NotNullWhen(true)] out LibraryInvoker? libraryInvoker)
    {
        libraryInvoker = null;
        var logger = librarySetInvoker.CreateLogger<LibraryInstanceInvoker_5_0>();

        if (GetLibraryFromStaticInstanceProperty(libraryType) is not ILibrary asILibrary)
        {
            logger?.LogDebug("Skipping type {type} because it does not implement ILibrary.", libraryType.FullName);
            return false;
        }

        libraryInvoker = new LibraryInstanceInvoker_5_0(librarySetInvoker, asILibrary);
        return true;
    }

    /// <summary>
    /// Determines whether the specified CQL tool version is supported.
    /// The current CQL tool version can be referenced by <c>LibrarySetCSharpCodeGenerator.GeneratorToolVersion</c>.
    /// </summary>
    public static bool SupportsVersion(Version cqlToolVersion) =>
        cqlToolVersion >= MinSupportedGeneratorToolVersion
        && cqlToolVersion < FirstUnsupportedGeneratorToolVersion;
}

file sealed class DefinitionInvoker_5_0(
    ILibrary library,
    LibraryInvoker libraryInvoker,
    MethodInfo methodInfo,
    CqlDefinitionAttribute cqlDefinitionAttribute) : DefinitionInvoker(
    libraryInvoker,
    methodInfo.ReturnType,
    methodInfo.GetParameters()
              .Skip(1) // Skip CqlContext
              .Select(p => new CqlParameterInfo(
                  p.GetCustomAttribute<CqlFunctionParameterAttribute>()?.CqlParameterName ?? p.Name!,
                  p.ParameterType))
              .ToArray(),
    cqlDefinitionAttribute,
    methodInfo.GetCustomAttributes<CqlTagAttribute>()
              .ToArray())
{
    private readonly Func<CqlContext, object?[], object?> _compiledInvoker = CreateInvoker(library, methodInfo);

    public static (bool success, DefinitionInvoker definitionInvoker) TryCreate(
        ILibrary library,
        LibraryInvoker libraryInvoker,
        MethodInfo methodInfo)
    {
        var cqlDefinitionAttributes = methodInfo.GetCustomAttributes<CqlDefinitionAttribute>().ToArray();
        if (cqlDefinitionAttributes is not [{ } cqlDefinitionAttribute])
            return default;

        var definitionInvoker = new DefinitionInvoker_5_0(library, libraryInvoker, methodInfo, cqlDefinitionAttribute);
        return (true, definitionInvoker);
    }

    public override object? Invoke(CqlContext cqlContext, params object?[] args) =>
        _compiledInvoker(cqlContext, args);

    /// <summary>
    /// Creates a delegate that directly calls the definition method on the library instance,
    /// avoiding the per-invocation overhead of <see cref="MethodBase.Invoke(object?, object?[])"/>.
    /// For common arities a strongly-typed delegate is bound via <see cref="MethodInfo.CreateDelegate{T}(object?)"/>
    /// (a direct call, no IL generation); other shapes fall back to a compiled expression tree.
    /// The delegate is created once per definition when the invoker is constructed.
    /// Exceptions thrown by the definition propagate unwrapped, matching the previous
    /// <see cref="BindingFlags.DoNotWrapExceptions"/> behavior.
    /// </summary>
    private static Func<CqlContext, object?[], object?> CreateInvoker(ILibrary library, MethodInfo methodInfo)
    {
        var parameters = methodInfo.GetParameters();
        if (methodInfo.ReturnType != typeof(void)
            && parameters.Length is >= 1 and <= 5
            && parameters[0].ParameterType == typeof(CqlContext))
        {
            var wrapperName = parameters.Length switch
            {
                1 => nameof(WrapArity0),
                2 => nameof(WrapArity1),
                3 => nameof(WrapArity2),
                4 => nameof(WrapArity3),
                _ => nameof(WrapArity4),
            };
            Type[] typeArguments = [.. parameters.Skip(1).Select(p => p.ParameterType), methodInfo.ReturnType];
            var wrapper = typeof(DefinitionInvoker_5_0)
                          .GetMethod(wrapperName, BindingFlags.NonPublic | BindingFlags.Static)!
                          .MakeGenericMethod(typeArguments);
            return (Func<CqlContext, object?[], object?>)wrapper.Invoke(
                null,
                BindingFlags.DoNotWrapExceptions,
                binder: null,
                parameters: [library, methodInfo],
                culture: null)!;
        }

        return CompileInvoker(library, methodInfo);
    }

    private static Func<CqlContext, object?[], object?> WrapArity0<TResult>(ILibrary library, MethodInfo methodInfo)
    {
        var invoke = methodInfo.CreateDelegate<Func<CqlContext, TResult>>(library);
        return (cqlContext, _) => invoke(cqlContext);
    }

    private static Func<CqlContext, object?[], object?> WrapArity1<T1, TResult>(ILibrary library, MethodInfo methodInfo)
    {
        var invoke = methodInfo.CreateDelegate<Func<CqlContext, T1, TResult>>(library);
        return (cqlContext, args) => invoke(cqlContext, (T1)args[0]!);
    }

    private static Func<CqlContext, object?[], object?> WrapArity2<T1, T2, TResult>(ILibrary library, MethodInfo methodInfo)
    {
        var invoke = methodInfo.CreateDelegate<Func<CqlContext, T1, T2, TResult>>(library);
        return (cqlContext, args) => invoke(cqlContext, (T1)args[0]!, (T2)args[1]!);
    }

    private static Func<CqlContext, object?[], object?> WrapArity3<T1, T2, T3, TResult>(ILibrary library, MethodInfo methodInfo)
    {
        var invoke = methodInfo.CreateDelegate<Func<CqlContext, T1, T2, T3, TResult>>(library);
        return (cqlContext, args) => invoke(cqlContext, (T1)args[0]!, (T2)args[1]!, (T3)args[2]!);
    }

    private static Func<CqlContext, object?[], object?> WrapArity4<T1, T2, T3, T4, TResult>(ILibrary library, MethodInfo methodInfo)
    {
        var invoke = methodInfo.CreateDelegate<Func<CqlContext, T1, T2, T3, T4, TResult>>(library);
        return (cqlContext, args) => invoke(cqlContext, (T1)args[0]!, (T2)args[1]!, (T3)args[2]!, (T4)args[3]!);
    }

    /// <summary>
    /// Fallback for definition shapes not covered by the typed <c>WrapArityN</c> adapters:
    /// compiles an expression tree that calls the definition directly.
    /// </summary>
    private static Func<CqlContext, object?[], object?> CompileInvoker(ILibrary library, MethodInfo methodInfo)
    {
        var parameters = methodInfo.GetParameters();
        var cqlContextParameter = Expression.Parameter(typeof(CqlContext), "cqlContext");
        var argsParameter = Expression.Parameter(typeof(object?[]), "args");

        var callArguments = new Expression[parameters.Length];
        callArguments[0] = parameters[0].ParameterType == typeof(CqlContext)
            ? cqlContextParameter
            : Expression.Convert(cqlContextParameter, parameters[0].ParameterType);
        for (var i = 1; i < parameters.Length; i++)
        {
            callArguments[i] = Expression.Convert(
                Expression.ArrayIndex(argsParameter, Expression.Constant(i - 1)),
                parameters[i].ParameterType);
        }

        var call = Expression.Call(Expression.Constant(library), methodInfo, callArguments);
        var body = methodInfo.ReturnType == typeof(void)
            ? (Expression)Expression.Block(call, Expression.Constant(null, typeof(object)))
            : Expression.Convert(call, typeof(object));

        return Expression
               .Lambda<Func<CqlContext, object?[], object?>>(body, cqlContextParameter, argsParameter)
               .Compile();
    }
}
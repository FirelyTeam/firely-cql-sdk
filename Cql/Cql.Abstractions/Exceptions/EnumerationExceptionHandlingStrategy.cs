using System.Runtime.ExceptionServices;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

namespace Hl7.Cql.Abstractions.Exceptions;

public static class EnumerationExceptionHandlingStrategy
{
    public static EnumerationExceptionHandlingStrategy<TInput> Delegated<TInput>(Func<TInput, ExceptionDispatchInfo, bool> handle)
    {
        return new DelegatedEnumerationExceptionHandlingStrategy<TInput>(handle);
    }

    public static EnumerationExceptionHandlingStrategy<TInput> Throw<TInput>()
    {
        return EnumerationExceptionHandlingStrategy<TInput>.Throw;
    }
}

public abstract class EnumerationExceptionHandlingStrategy<TInput>
{
    public static EnumerationExceptionHandlingStrategy<TInput> Throw { get; } = new ThrowEnumerationExceptionHandlingStrategy<TInput>();

    /// <summary>
    /// Handles the exception that occurred while processing the input.
    /// </summary>
    /// <param name="input">The input argument</param>
    /// <param name="exceptionDispatchInfo">The exception dispatch info</param>
    /// <returns>Continues the enumeration when <c>true</c>, otherwise breaks the enumeration when <c>false</c>.</returns>
    public abstract bool HandleException(TInput input, ExceptionDispatchInfo exceptionDispatchInfo);

    internal Choice<TNext, bool> TryGetNext<TNext>(TInput input, Func<TInput, TNext> tryGetNext)
    {
        try
        {
            return tryGetNext(input);
        }
        catch (Exception e)
        {
            return HandleException(input, ExceptionDispatchInfo.Capture(e));
        }
    }
}

internal readonly record struct Choice<T1, T2>(int Index, T1 Value1, T2 Value2)
{
    private readonly int _index = Index;
    private readonly T1 _value1 = Value1;
    private readonly T2 _value2 = Value2;

    public int Index => _index;

    public T1 Value1 => _index switch
    {
        1 => _value1,
        _ => throw new InvalidOperationException("Value1 cannot be retrieved for this Choice type.")
    };

    public T2 Value2 => _index switch
    {
        1 => _value2,
        _ => throw new InvalidOperationException("Value2 cannot be retrieved for this Choice type.")
    };

    public static implicit operator Choice<T1, T2>(T1 value) => new Choice<T1, T2>(1, value, default!);
    public static implicit operator Choice<T1, T2>(T2 value) => new Choice<T1, T2>(2, default!, value);
}

internal class DelegatedEnumerationExceptionHandlingStrategy<TInput>
    (Func<TInput, ExceptionDispatchInfo, bool> handle) : EnumerationExceptionHandlingStrategy<TInput>
{
    public override bool HandleException(TInput input, ExceptionDispatchInfo exceptionDispatchInfo)
    {
        return handle(input, exceptionDispatchInfo);
    }
}

internal class ThrowEnumerationExceptionHandlingStrategy<TInput>()
    : DelegatedEnumerationExceptionHandlingStrategy<TInput>((_, e) =>
    {
        e.Throw();
        throw new UnreachableException();
    });
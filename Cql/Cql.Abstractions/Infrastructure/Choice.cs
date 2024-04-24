using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace Hl7.Cql.Abstractions.Infrastructure;

internal interface IChoice
{
    object? Value { get; }
    int Index { get; }
}

file static class Helpers
{
    public static InvalidOperationException CannotReturnTn(int desiredIndex, int actualIndex) =>
        new($"Cannot return the T{desiredIndex} value from this T{actualIndex} tuple.");
}

/// <summary>
/// A value type that is a choice between 1 value.
/// </summary>
internal readonly record struct ValueChoice<T0>
    : IChoice
{
    private readonly T0 v0;

    private ValueChoice(T0 v0)
    {
        this.v0 = v0;
    }

    public object? Value => v0;
    public int Index => 0;

    public T0? AsT0(bool throwError = false) =>
        (Index, throwError) switch
        {
            (0, _)          => v0,
            (_, true)  => throw Helpers.CannotReturnTn(0, Index),
            (_, false) => default,
        };

    public void Switch(
        Action<T0> f0)
    {
        switch (Index)
        {
            case 0:  f0(v0); break;
            default: throw new UnreachableException();
        }
    }

    public TR Match<TR>(
        Func<T0, TR> f0) =>
        Index switch
        {
            0 => f0(v0),
            _ => throw new UnreachableException(),
        };

    public static ValueChoice<T0> FromT0(T0 v0) => new(v0!);
    public static implicit operator ValueChoice<T0>(T0 v0) => FromT0(v0);
}
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace Hl7.Cql.Abstractions.Infrastructure;

internal interface IChoice
{
    object? Value { get; }
    int Index { get; }
}

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

internal readonly record struct ValueChoice<T0, T1>
    : IChoice
{
    private readonly (T0 v0, T1 v1) _values;

    private ValueChoice(int index, (T0, T1) values)
    {
        Index = index;
        _values = values;
    }

    public object? Value => ((ITuple)_values)[Index];
    public int Index { get; }

    public T0? AsT0(bool throwError = false) =>
        (Index, throwError) switch
        {
            (0, _)     => _values.v0,
            (_, true)  => throw Helpers.CannotReturnTn(0, Index),
            (_, false) => default,
        };

    public T1? AsT1(bool throwError = false) =>
        (Index, throwError) switch
        {
            (1, _)     => _values.v1,
            (_, true)  => throw Helpers.CannotReturnTn(1, Index),
            (_, false) => default,
        };

    public void Switch(
        Action<T0> f0,
        Action<T1> f1)
    {
        switch (Index)
        {
            case 0:  f0(_values.v0); break;
            case 1:  f1(_values.v1); break;
            default: throw new UnreachableException();
        }
    }

    public TR Match<TR>(
        Func<T0, TR> f0,
        Func<T1, TR> f1) =>
        Index switch
        {
            0 => f0(_values.v0),
            1 => f1(_values.v1),
            _ => throw new UnreachableException(),
        };

    public static ValueChoice<T0, T1> FromT0(T0 v0) => new(0, (v0, default)!);
    public static implicit operator ValueChoice<T0, T1>(T0 v0) => FromT0(v0);

    public static ValueChoice<T0, T1> FromT1(T1 v1) => new(1, (default, v1)!);
    public static implicit operator ValueChoice<T0, T1>(T1 v1) => FromT1(v1);
}

file static class Helpers
{
    public static InvalidOperationException CannotReturnTn(int desiredIndex, int actualIndex) =>
        new($"Cannot return the T{desiredIndex} value from this T{actualIndex} tuple.");
}
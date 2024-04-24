#nullable enable

using System;
using System.Linq;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace Hl7.Cql.Abstractions.Infrastructure;

file static class Helpers
{
    public static InvalidOperationException CannotReturnTn(int desiredIndex, int actualIndex) =>
        new($"Cannot return the T{desiredIndex} value from this T{actualIndex} tuple.");
}


/// <summary>
/// A value type that is a choice between 2 values.
/// </summary>
internal readonly record struct ValueChoice<T0, T1>
    : IChoice
{
    private readonly (T0 v0, T1 v1) _values;

    private ValueChoice(int index, (T0 v0, T1 v1) values)
    {
        Index = index;
        _values = values;
    }

    public object? Value => ((ITuple)_values)[Index];
    public int Index { get; }

    public void Switch(
        Action<T0> f0,
        Action<T1> f1)
    {
        switch (Index)
        {
            case 0: f0(_values.v0); break;
            case 1: f1(_values.v1); break;
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

    public T0? AsT0(bool throwError = false) =>
        (Index, throwError) switch
        {
            (0, _)     => _values.v0,
            (_, true)  => throw Helpers.CannotReturnTn(0, Index),
            (_, false) => default,
        };

    public static ValueChoice<T0, T1> FromT0(T0 v0) => new(0, (v0, default)!);
    public static implicit operator ValueChoice<T0, T1>(T0 v0) => FromT0(v0);

    public T1? AsT1(bool throwError = false) =>
        (Index, throwError) switch
        {
            (1, _)     => _values.v1,
            (_, true)  => throw Helpers.CannotReturnTn(1, Index),
            (_, false) => default,
        };

    public static ValueChoice<T0, T1> FromT1(T1 v1) => new(1, (default, v1)!);
    public static implicit operator ValueChoice<T0, T1>(T1 v1) => FromT1(v1);

}


/// <summary>
/// A value type that is a choice between 3 values.
/// </summary>
internal readonly record struct ValueChoice<T0, T1, T2>
    : IChoice
{
    private readonly (T0 v0, T1 v1, T2 v2) _values;

    private ValueChoice(int index, (T0 v0, T1 v1, T2 v2) values)
    {
        Index = index;
        _values = values;
    }

    public object? Value => ((ITuple)_values)[Index];
    public int Index { get; }

    public void Switch(
        Action<T0> f0,
        Action<T1> f1,
        Action<T2> f2)
    {
        switch (Index)
        {
            case 0: f0(_values.v0); break;
            case 1: f1(_values.v1); break;
            case 2: f2(_values.v2); break;
            default: throw new UnreachableException();
        }
    }

    public TR Match<TR>(
        Func<T0, TR> f0,
        Func<T1, TR> f1,
        Func<T2, TR> f2) =>
        Index switch
        {
            0 => f0(_values.v0),
            1 => f1(_values.v1),
            2 => f2(_values.v2),
            _ => throw new UnreachableException(),
        };

    public T0? AsT0(bool throwError = false) =>
        (Index, throwError) switch
        {
            (0, _)     => _values.v0,
            (_, true)  => throw Helpers.CannotReturnTn(0, Index),
            (_, false) => default,
        };

    public static ValueChoice<T0, T1, T2> FromT0(T0 v0) => new(0, (v0, default, default)!);
    public static implicit operator ValueChoice<T0, T1, T2>(T0 v0) => FromT0(v0);

    public T1? AsT1(bool throwError = false) =>
        (Index, throwError) switch
        {
            (1, _)     => _values.v1,
            (_, true)  => throw Helpers.CannotReturnTn(1, Index),
            (_, false) => default,
        };

    public static ValueChoice<T0, T1, T2> FromT1(T1 v1) => new(1, (default, v1, default)!);
    public static implicit operator ValueChoice<T0, T1, T2>(T1 v1) => FromT1(v1);

    public T2? AsT2(bool throwError = false) =>
        (Index, throwError) switch
        {
            (2, _)     => _values.v2,
            (_, true)  => throw Helpers.CannotReturnTn(2, Index),
            (_, false) => default,
        };

    public static ValueChoice<T0, T1, T2> FromT2(T2 v2) => new(2, (default, default, v2)!);
    public static implicit operator ValueChoice<T0, T1, T2>(T2 v2) => FromT2(v2);

}


/// <summary>
/// A value type that is a choice between 4 values.
/// </summary>
internal readonly record struct ValueChoice<T0, T1, T2, T3>
    : IChoice
{
    private readonly (T0 v0, T1 v1, T2 v2, T3 v3) _values;

    private ValueChoice(int index, (T0 v0, T1 v1, T2 v2, T3 v3) values)
    {
        Index = index;
        _values = values;
    }

    public object? Value => ((ITuple)_values)[Index];
    public int Index { get; }

    public void Switch(
        Action<T0> f0,
        Action<T1> f1,
        Action<T2> f2,
        Action<T3> f3)
    {
        switch (Index)
        {
            case 0: f0(_values.v0); break;
            case 1: f1(_values.v1); break;
            case 2: f2(_values.v2); break;
            case 3: f3(_values.v3); break;
            default: throw new UnreachableException();
        }
    }

    public TR Match<TR>(
        Func<T0, TR> f0,
        Func<T1, TR> f1,
        Func<T2, TR> f2,
        Func<T3, TR> f3) =>
        Index switch
        {
            0 => f0(_values.v0),
            1 => f1(_values.v1),
            2 => f2(_values.v2),
            3 => f3(_values.v3),
            _ => throw new UnreachableException(),
        };

    public T0? AsT0(bool throwError = false) =>
        (Index, throwError) switch
        {
            (0, _)     => _values.v0,
            (_, true)  => throw Helpers.CannotReturnTn(0, Index),
            (_, false) => default,
        };

    public static ValueChoice<T0, T1, T2, T3> FromT0(T0 v0) => new(0, (v0, default, default, default)!);
    public static implicit operator ValueChoice<T0, T1, T2, T3>(T0 v0) => FromT0(v0);

    public T1? AsT1(bool throwError = false) =>
        (Index, throwError) switch
        {
            (1, _)     => _values.v1,
            (_, true)  => throw Helpers.CannotReturnTn(1, Index),
            (_, false) => default,
        };

    public static ValueChoice<T0, T1, T2, T3> FromT1(T1 v1) => new(1, (default, v1, default, default)!);
    public static implicit operator ValueChoice<T0, T1, T2, T3>(T1 v1) => FromT1(v1);

    public T2? AsT2(bool throwError = false) =>
        (Index, throwError) switch
        {
            (2, _)     => _values.v2,
            (_, true)  => throw Helpers.CannotReturnTn(2, Index),
            (_, false) => default,
        };

    public static ValueChoice<T0, T1, T2, T3> FromT2(T2 v2) => new(2, (default, default, v2, default)!);
    public static implicit operator ValueChoice<T0, T1, T2, T3>(T2 v2) => FromT2(v2);

    public T3? AsT3(bool throwError = false) =>
        (Index, throwError) switch
        {
            (3, _)     => _values.v3,
            (_, true)  => throw Helpers.CannotReturnTn(3, Index),
            (_, false) => default,
        };

    public static ValueChoice<T0, T1, T2, T3> FromT3(T3 v3) => new(3, (default, default, default, v3)!);
    public static implicit operator ValueChoice<T0, T1, T2, T3>(T3 v3) => FromT3(v3);

}


/// <summary>
/// A value type that is a choice between 5 values.
/// </summary>
internal readonly record struct ValueChoice<T0, T1, T2, T3, T4>
    : IChoice
{
    private readonly (T0 v0, T1 v1, T2 v2, T3 v3, T4 v4) _values;

    private ValueChoice(int index, (T0 v0, T1 v1, T2 v2, T3 v3, T4 v4) values)
    {
        Index = index;
        _values = values;
    }

    public object? Value => ((ITuple)_values)[Index];
    public int Index { get; }

    public void Switch(
        Action<T0> f0,
        Action<T1> f1,
        Action<T2> f2,
        Action<T3> f3,
        Action<T4> f4)
    {
        switch (Index)
        {
            case 0: f0(_values.v0); break;
            case 1: f1(_values.v1); break;
            case 2: f2(_values.v2); break;
            case 3: f3(_values.v3); break;
            case 4: f4(_values.v4); break;
            default: throw new UnreachableException();
        }
    }

    public TR Match<TR>(
        Func<T0, TR> f0,
        Func<T1, TR> f1,
        Func<T2, TR> f2,
        Func<T3, TR> f3,
        Func<T4, TR> f4) =>
        Index switch
        {
            0 => f0(_values.v0),
            1 => f1(_values.v1),
            2 => f2(_values.v2),
            3 => f3(_values.v3),
            4 => f4(_values.v4),
            _ => throw new UnreachableException(),
        };

    public T0? AsT0(bool throwError = false) =>
        (Index, throwError) switch
        {
            (0, _)     => _values.v0,
            (_, true)  => throw Helpers.CannotReturnTn(0, Index),
            (_, false) => default,
        };

    public static ValueChoice<T0, T1, T2, T3, T4> FromT0(T0 v0) => new(0, (v0, default, default, default, default)!);
    public static implicit operator ValueChoice<T0, T1, T2, T3, T4>(T0 v0) => FromT0(v0);

    public T1? AsT1(bool throwError = false) =>
        (Index, throwError) switch
        {
            (1, _)     => _values.v1,
            (_, true)  => throw Helpers.CannotReturnTn(1, Index),
            (_, false) => default,
        };

    public static ValueChoice<T0, T1, T2, T3, T4> FromT1(T1 v1) => new(1, (default, v1, default, default, default)!);
    public static implicit operator ValueChoice<T0, T1, T2, T3, T4>(T1 v1) => FromT1(v1);

    public T2? AsT2(bool throwError = false) =>
        (Index, throwError) switch
        {
            (2, _)     => _values.v2,
            (_, true)  => throw Helpers.CannotReturnTn(2, Index),
            (_, false) => default,
        };

    public static ValueChoice<T0, T1, T2, T3, T4> FromT2(T2 v2) => new(2, (default, default, v2, default, default)!);
    public static implicit operator ValueChoice<T0, T1, T2, T3, T4>(T2 v2) => FromT2(v2);

    public T3? AsT3(bool throwError = false) =>
        (Index, throwError) switch
        {
            (3, _)     => _values.v3,
            (_, true)  => throw Helpers.CannotReturnTn(3, Index),
            (_, false) => default,
        };

    public static ValueChoice<T0, T1, T2, T3, T4> FromT3(T3 v3) => new(3, (default, default, default, v3, default)!);
    public static implicit operator ValueChoice<T0, T1, T2, T3, T4>(T3 v3) => FromT3(v3);

    public T4? AsT4(bool throwError = false) =>
        (Index, throwError) switch
        {
            (4, _)     => _values.v4,
            (_, true)  => throw Helpers.CannotReturnTn(4, Index),
            (_, false) => default,
        };

    public static ValueChoice<T0, T1, T2, T3, T4> FromT4(T4 v4) => new(4, (default, default, default, default, v4)!);
    public static implicit operator ValueChoice<T0, T1, T2, T3, T4>(T4 v4) => FromT4(v4);

}


/// <summary>
/// A value type that is a choice between 6 values.
/// </summary>
internal readonly record struct ValueChoice<T0, T1, T2, T3, T4, T5>
    : IChoice
{
    private readonly (T0 v0, T1 v1, T2 v2, T3 v3, T4 v4, T5 v5) _values;

    private ValueChoice(int index, (T0 v0, T1 v1, T2 v2, T3 v3, T4 v4, T5 v5) values)
    {
        Index = index;
        _values = values;
    }

    public object? Value => ((ITuple)_values)[Index];
    public int Index { get; }

    public void Switch(
        Action<T0> f0,
        Action<T1> f1,
        Action<T2> f2,
        Action<T3> f3,
        Action<T4> f4,
        Action<T5> f5)
    {
        switch (Index)
        {
            case 0: f0(_values.v0); break;
            case 1: f1(_values.v1); break;
            case 2: f2(_values.v2); break;
            case 3: f3(_values.v3); break;
            case 4: f4(_values.v4); break;
            case 5: f5(_values.v5); break;
            default: throw new UnreachableException();
        }
    }

    public TR Match<TR>(
        Func<T0, TR> f0,
        Func<T1, TR> f1,
        Func<T2, TR> f2,
        Func<T3, TR> f3,
        Func<T4, TR> f4,
        Func<T5, TR> f5) =>
        Index switch
        {
            0 => f0(_values.v0),
            1 => f1(_values.v1),
            2 => f2(_values.v2),
            3 => f3(_values.v3),
            4 => f4(_values.v4),
            5 => f5(_values.v5),
            _ => throw new UnreachableException(),
        };

    public T0? AsT0(bool throwError = false) =>
        (Index, throwError) switch
        {
            (0, _)     => _values.v0,
            (_, true)  => throw Helpers.CannotReturnTn(0, Index),
            (_, false) => default,
        };

    public static ValueChoice<T0, T1, T2, T3, T4, T5> FromT0(T0 v0) => new(0, (v0, default, default, default, default, default)!);
    public static implicit operator ValueChoice<T0, T1, T2, T3, T4, T5>(T0 v0) => FromT0(v0);

    public T1? AsT1(bool throwError = false) =>
        (Index, throwError) switch
        {
            (1, _)     => _values.v1,
            (_, true)  => throw Helpers.CannotReturnTn(1, Index),
            (_, false) => default,
        };

    public static ValueChoice<T0, T1, T2, T3, T4, T5> FromT1(T1 v1) => new(1, (default, v1, default, default, default, default)!);
    public static implicit operator ValueChoice<T0, T1, T2, T3, T4, T5>(T1 v1) => FromT1(v1);

    public T2? AsT2(bool throwError = false) =>
        (Index, throwError) switch
        {
            (2, _)     => _values.v2,
            (_, true)  => throw Helpers.CannotReturnTn(2, Index),
            (_, false) => default,
        };

    public static ValueChoice<T0, T1, T2, T3, T4, T5> FromT2(T2 v2) => new(2, (default, default, v2, default, default, default)!);
    public static implicit operator ValueChoice<T0, T1, T2, T3, T4, T5>(T2 v2) => FromT2(v2);

    public T3? AsT3(bool throwError = false) =>
        (Index, throwError) switch
        {
            (3, _)     => _values.v3,
            (_, true)  => throw Helpers.CannotReturnTn(3, Index),
            (_, false) => default,
        };

    public static ValueChoice<T0, T1, T2, T3, T4, T5> FromT3(T3 v3) => new(3, (default, default, default, v3, default, default)!);
    public static implicit operator ValueChoice<T0, T1, T2, T3, T4, T5>(T3 v3) => FromT3(v3);

    public T4? AsT4(bool throwError = false) =>
        (Index, throwError) switch
        {
            (4, _)     => _values.v4,
            (_, true)  => throw Helpers.CannotReturnTn(4, Index),
            (_, false) => default,
        };

    public static ValueChoice<T0, T1, T2, T3, T4, T5> FromT4(T4 v4) => new(4, (default, default, default, default, v4, default)!);
    public static implicit operator ValueChoice<T0, T1, T2, T3, T4, T5>(T4 v4) => FromT4(v4);

    public T5? AsT5(bool throwError = false) =>
        (Index, throwError) switch
        {
            (5, _)     => _values.v5,
            (_, true)  => throw Helpers.CannotReturnTn(5, Index),
            (_, false) => default,
        };

    public static ValueChoice<T0, T1, T2, T3, T4, T5> FromT5(T5 v5) => new(5, (default, default, default, default, default, v5)!);
    public static implicit operator ValueChoice<T0, T1, T2, T3, T4, T5>(T5 v5) => FromT5(v5);

}


/// <summary>
/// A value type that is a choice between 7 values.
/// </summary>
internal readonly record struct ValueChoice<T0, T1, T2, T3, T4, T5, T6>
    : IChoice
{
    private readonly (T0 v0, T1 v1, T2 v2, T3 v3, T4 v4, T5 v5, T6 v6) _values;

    private ValueChoice(int index, (T0 v0, T1 v1, T2 v2, T3 v3, T4 v4, T5 v5, T6 v6) values)
    {
        Index = index;
        _values = values;
    }

    public object? Value => ((ITuple)_values)[Index];
    public int Index { get; }

    public void Switch(
        Action<T0> f0,
        Action<T1> f1,
        Action<T2> f2,
        Action<T3> f3,
        Action<T4> f4,
        Action<T5> f5,
        Action<T6> f6)
    {
        switch (Index)
        {
            case 0: f0(_values.v0); break;
            case 1: f1(_values.v1); break;
            case 2: f2(_values.v2); break;
            case 3: f3(_values.v3); break;
            case 4: f4(_values.v4); break;
            case 5: f5(_values.v5); break;
            case 6: f6(_values.v6); break;
            default: throw new UnreachableException();
        }
    }

    public TR Match<TR>(
        Func<T0, TR> f0,
        Func<T1, TR> f1,
        Func<T2, TR> f2,
        Func<T3, TR> f3,
        Func<T4, TR> f4,
        Func<T5, TR> f5,
        Func<T6, TR> f6) =>
        Index switch
        {
            0 => f0(_values.v0),
            1 => f1(_values.v1),
            2 => f2(_values.v2),
            3 => f3(_values.v3),
            4 => f4(_values.v4),
            5 => f5(_values.v5),
            6 => f6(_values.v6),
            _ => throw new UnreachableException(),
        };

    public T0? AsT0(bool throwError = false) =>
        (Index, throwError) switch
        {
            (0, _)     => _values.v0,
            (_, true)  => throw Helpers.CannotReturnTn(0, Index),
            (_, false) => default,
        };

    public static ValueChoice<T0, T1, T2, T3, T4, T5, T6> FromT0(T0 v0) => new(0, (v0, default, default, default, default, default, default)!);
    public static implicit operator ValueChoice<T0, T1, T2, T3, T4, T5, T6>(T0 v0) => FromT0(v0);

    public T1? AsT1(bool throwError = false) =>
        (Index, throwError) switch
        {
            (1, _)     => _values.v1,
            (_, true)  => throw Helpers.CannotReturnTn(1, Index),
            (_, false) => default,
        };

    public static ValueChoice<T0, T1, T2, T3, T4, T5, T6> FromT1(T1 v1) => new(1, (default, v1, default, default, default, default, default)!);
    public static implicit operator ValueChoice<T0, T1, T2, T3, T4, T5, T6>(T1 v1) => FromT1(v1);

    public T2? AsT2(bool throwError = false) =>
        (Index, throwError) switch
        {
            (2, _)     => _values.v2,
            (_, true)  => throw Helpers.CannotReturnTn(2, Index),
            (_, false) => default,
        };

    public static ValueChoice<T0, T1, T2, T3, T4, T5, T6> FromT2(T2 v2) => new(2, (default, default, v2, default, default, default, default)!);
    public static implicit operator ValueChoice<T0, T1, T2, T3, T4, T5, T6>(T2 v2) => FromT2(v2);

    public T3? AsT3(bool throwError = false) =>
        (Index, throwError) switch
        {
            (3, _)     => _values.v3,
            (_, true)  => throw Helpers.CannotReturnTn(3, Index),
            (_, false) => default,
        };

    public static ValueChoice<T0, T1, T2, T3, T4, T5, T6> FromT3(T3 v3) => new(3, (default, default, default, v3, default, default, default)!);
    public static implicit operator ValueChoice<T0, T1, T2, T3, T4, T5, T6>(T3 v3) => FromT3(v3);

    public T4? AsT4(bool throwError = false) =>
        (Index, throwError) switch
        {
            (4, _)     => _values.v4,
            (_, true)  => throw Helpers.CannotReturnTn(4, Index),
            (_, false) => default,
        };

    public static ValueChoice<T0, T1, T2, T3, T4, T5, T6> FromT4(T4 v4) => new(4, (default, default, default, default, v4, default, default)!);
    public static implicit operator ValueChoice<T0, T1, T2, T3, T4, T5, T6>(T4 v4) => FromT4(v4);

    public T5? AsT5(bool throwError = false) =>
        (Index, throwError) switch
        {
            (5, _)     => _values.v5,
            (_, true)  => throw Helpers.CannotReturnTn(5, Index),
            (_, false) => default,
        };

    public static ValueChoice<T0, T1, T2, T3, T4, T5, T6> FromT5(T5 v5) => new(5, (default, default, default, default, default, v5, default)!);
    public static implicit operator ValueChoice<T0, T1, T2, T3, T4, T5, T6>(T5 v5) => FromT5(v5);

    public T6? AsT6(bool throwError = false) =>
        (Index, throwError) switch
        {
            (6, _)     => _values.v6,
            (_, true)  => throw Helpers.CannotReturnTn(6, Index),
            (_, false) => default,
        };

    public static ValueChoice<T0, T1, T2, T3, T4, T5, T6> FromT6(T6 v6) => new(6, (default, default, default, default, default, default, v6)!);
    public static implicit operator ValueChoice<T0, T1, T2, T3, T4, T5, T6>(T6 v6) => FromT6(v6);

}


/// <summary>
/// A value type that is a choice between 8 values.
/// </summary>
internal readonly record struct ValueChoice<T0, T1, T2, T3, T4, T5, T6, T7>
    : IChoice
{
    private readonly (T0 v0, T1 v1, T2 v2, T3 v3, T4 v4, T5 v5, T6 v6, T7 v7) _values;

    private ValueChoice(int index, (T0 v0, T1 v1, T2 v2, T3 v3, T4 v4, T5 v5, T6 v6, T7 v7) values)
    {
        Index = index;
        _values = values;
    }

    public object? Value => ((ITuple)_values)[Index];
    public int Index { get; }

    public void Switch(
        Action<T0> f0,
        Action<T1> f1,
        Action<T2> f2,
        Action<T3> f3,
        Action<T4> f4,
        Action<T5> f5,
        Action<T6> f6,
        Action<T7> f7)
    {
        switch (Index)
        {
            case 0: f0(_values.v0); break;
            case 1: f1(_values.v1); break;
            case 2: f2(_values.v2); break;
            case 3: f3(_values.v3); break;
            case 4: f4(_values.v4); break;
            case 5: f5(_values.v5); break;
            case 6: f6(_values.v6); break;
            case 7: f7(_values.v7); break;
            default: throw new UnreachableException();
        }
    }

    public TR Match<TR>(
        Func<T0, TR> f0,
        Func<T1, TR> f1,
        Func<T2, TR> f2,
        Func<T3, TR> f3,
        Func<T4, TR> f4,
        Func<T5, TR> f5,
        Func<T6, TR> f6,
        Func<T7, TR> f7) =>
        Index switch
        {
            0 => f0(_values.v0),
            1 => f1(_values.v1),
            2 => f2(_values.v2),
            3 => f3(_values.v3),
            4 => f4(_values.v4),
            5 => f5(_values.v5),
            6 => f6(_values.v6),
            7 => f7(_values.v7),
            _ => throw new UnreachableException(),
        };

    public T0? AsT0(bool throwError = false) =>
        (Index, throwError) switch
        {
            (0, _)     => _values.v0,
            (_, true)  => throw Helpers.CannotReturnTn(0, Index),
            (_, false) => default,
        };

    public static ValueChoice<T0, T1, T2, T3, T4, T5, T6, T7> FromT0(T0 v0) => new(0, (v0, default, default, default, default, default, default, default)!);
    public static implicit operator ValueChoice<T0, T1, T2, T3, T4, T5, T6, T7>(T0 v0) => FromT0(v0);

    public T1? AsT1(bool throwError = false) =>
        (Index, throwError) switch
        {
            (1, _)     => _values.v1,
            (_, true)  => throw Helpers.CannotReturnTn(1, Index),
            (_, false) => default,
        };

    public static ValueChoice<T0, T1, T2, T3, T4, T5, T6, T7> FromT1(T1 v1) => new(1, (default, v1, default, default, default, default, default, default)!);
    public static implicit operator ValueChoice<T0, T1, T2, T3, T4, T5, T6, T7>(T1 v1) => FromT1(v1);

    public T2? AsT2(bool throwError = false) =>
        (Index, throwError) switch
        {
            (2, _)     => _values.v2,
            (_, true)  => throw Helpers.CannotReturnTn(2, Index),
            (_, false) => default,
        };

    public static ValueChoice<T0, T1, T2, T3, T4, T5, T6, T7> FromT2(T2 v2) => new(2, (default, default, v2, default, default, default, default, default)!);
    public static implicit operator ValueChoice<T0, T1, T2, T3, T4, T5, T6, T7>(T2 v2) => FromT2(v2);

    public T3? AsT3(bool throwError = false) =>
        (Index, throwError) switch
        {
            (3, _)     => _values.v3,
            (_, true)  => throw Helpers.CannotReturnTn(3, Index),
            (_, false) => default,
        };

    public static ValueChoice<T0, T1, T2, T3, T4, T5, T6, T7> FromT3(T3 v3) => new(3, (default, default, default, v3, default, default, default, default)!);
    public static implicit operator ValueChoice<T0, T1, T2, T3, T4, T5, T6, T7>(T3 v3) => FromT3(v3);

    public T4? AsT4(bool throwError = false) =>
        (Index, throwError) switch
        {
            (4, _)     => _values.v4,
            (_, true)  => throw Helpers.CannotReturnTn(4, Index),
            (_, false) => default,
        };

    public static ValueChoice<T0, T1, T2, T3, T4, T5, T6, T7> FromT4(T4 v4) => new(4, (default, default, default, default, v4, default, default, default)!);
    public static implicit operator ValueChoice<T0, T1, T2, T3, T4, T5, T6, T7>(T4 v4) => FromT4(v4);

    public T5? AsT5(bool throwError = false) =>
        (Index, throwError) switch
        {
            (5, _)     => _values.v5,
            (_, true)  => throw Helpers.CannotReturnTn(5, Index),
            (_, false) => default,
        };

    public static ValueChoice<T0, T1, T2, T3, T4, T5, T6, T7> FromT5(T5 v5) => new(5, (default, default, default, default, default, v5, default, default)!);
    public static implicit operator ValueChoice<T0, T1, T2, T3, T4, T5, T6, T7>(T5 v5) => FromT5(v5);

    public T6? AsT6(bool throwError = false) =>
        (Index, throwError) switch
        {
            (6, _)     => _values.v6,
            (_, true)  => throw Helpers.CannotReturnTn(6, Index),
            (_, false) => default,
        };

    public static ValueChoice<T0, T1, T2, T3, T4, T5, T6, T7> FromT6(T6 v6) => new(6, (default, default, default, default, default, default, v6, default)!);
    public static implicit operator ValueChoice<T0, T1, T2, T3, T4, T5, T6, T7>(T6 v6) => FromT6(v6);

    public T7? AsT7(bool throwError = false) =>
        (Index, throwError) switch
        {
            (7, _)     => _values.v7,
            (_, true)  => throw Helpers.CannotReturnTn(7, Index),
            (_, false) => default,
        };

    public static ValueChoice<T0, T1, T2, T3, T4, T5, T6, T7> FromT7(T7 v7) => new(7, (default, default, default, default, default, default, default, v7)!);
    public static implicit operator ValueChoice<T0, T1, T2, T3, T4, T5, T6, T7>(T7 v7) => FromT7(v7);

}


/// <summary>
/// A value type that is a choice between 9 values.
/// </summary>
internal readonly record struct ValueChoice<T0, T1, T2, T3, T4, T5, T6, T7, T8>
    : IChoice
{
    private readonly (T0 v0, T1 v1, T2 v2, T3 v3, T4 v4, T5 v5, T6 v6, T7 v7, T8 v8) _values;

    private ValueChoice(int index, (T0 v0, T1 v1, T2 v2, T3 v3, T4 v4, T5 v5, T6 v6, T7 v7, T8 v8) values)
    {
        Index = index;
        _values = values;
    }

    public object? Value => ((ITuple)_values)[Index];
    public int Index { get; }

    public void Switch(
        Action<T0> f0,
        Action<T1> f1,
        Action<T2> f2,
        Action<T3> f3,
        Action<T4> f4,
        Action<T5> f5,
        Action<T6> f6,
        Action<T7> f7,
        Action<T8> f8)
    {
        switch (Index)
        {
            case 0: f0(_values.v0); break;
            case 1: f1(_values.v1); break;
            case 2: f2(_values.v2); break;
            case 3: f3(_values.v3); break;
            case 4: f4(_values.v4); break;
            case 5: f5(_values.v5); break;
            case 6: f6(_values.v6); break;
            case 7: f7(_values.v7); break;
            case 8: f8(_values.v8); break;
            default: throw new UnreachableException();
        }
    }

    public TR Match<TR>(
        Func<T0, TR> f0,
        Func<T1, TR> f1,
        Func<T2, TR> f2,
        Func<T3, TR> f3,
        Func<T4, TR> f4,
        Func<T5, TR> f5,
        Func<T6, TR> f6,
        Func<T7, TR> f7,
        Func<T8, TR> f8) =>
        Index switch
        {
            0 => f0(_values.v0),
            1 => f1(_values.v1),
            2 => f2(_values.v2),
            3 => f3(_values.v3),
            4 => f4(_values.v4),
            5 => f5(_values.v5),
            6 => f6(_values.v6),
            7 => f7(_values.v7),
            8 => f8(_values.v8),
            _ => throw new UnreachableException(),
        };

    public T0? AsT0(bool throwError = false) =>
        (Index, throwError) switch
        {
            (0, _)     => _values.v0,
            (_, true)  => throw Helpers.CannotReturnTn(0, Index),
            (_, false) => default,
        };

    public static ValueChoice<T0, T1, T2, T3, T4, T5, T6, T7, T8> FromT0(T0 v0) => new(0, (v0, default, default, default, default, default, default, default, default)!);
    public static implicit operator ValueChoice<T0, T1, T2, T3, T4, T5, T6, T7, T8>(T0 v0) => FromT0(v0);

    public T1? AsT1(bool throwError = false) =>
        (Index, throwError) switch
        {
            (1, _)     => _values.v1,
            (_, true)  => throw Helpers.CannotReturnTn(1, Index),
            (_, false) => default,
        };

    public static ValueChoice<T0, T1, T2, T3, T4, T5, T6, T7, T8> FromT1(T1 v1) => new(1, (default, v1, default, default, default, default, default, default, default)!);
    public static implicit operator ValueChoice<T0, T1, T2, T3, T4, T5, T6, T7, T8>(T1 v1) => FromT1(v1);

    public T2? AsT2(bool throwError = false) =>
        (Index, throwError) switch
        {
            (2, _)     => _values.v2,
            (_, true)  => throw Helpers.CannotReturnTn(2, Index),
            (_, false) => default,
        };

    public static ValueChoice<T0, T1, T2, T3, T4, T5, T6, T7, T8> FromT2(T2 v2) => new(2, (default, default, v2, default, default, default, default, default, default)!);
    public static implicit operator ValueChoice<T0, T1, T2, T3, T4, T5, T6, T7, T8>(T2 v2) => FromT2(v2);

    public T3? AsT3(bool throwError = false) =>
        (Index, throwError) switch
        {
            (3, _)     => _values.v3,
            (_, true)  => throw Helpers.CannotReturnTn(3, Index),
            (_, false) => default,
        };

    public static ValueChoice<T0, T1, T2, T3, T4, T5, T6, T7, T8> FromT3(T3 v3) => new(3, (default, default, default, v3, default, default, default, default, default)!);
    public static implicit operator ValueChoice<T0, T1, T2, T3, T4, T5, T6, T7, T8>(T3 v3) => FromT3(v3);

    public T4? AsT4(bool throwError = false) =>
        (Index, throwError) switch
        {
            (4, _)     => _values.v4,
            (_, true)  => throw Helpers.CannotReturnTn(4, Index),
            (_, false) => default,
        };

    public static ValueChoice<T0, T1, T2, T3, T4, T5, T6, T7, T8> FromT4(T4 v4) => new(4, (default, default, default, default, v4, default, default, default, default)!);
    public static implicit operator ValueChoice<T0, T1, T2, T3, T4, T5, T6, T7, T8>(T4 v4) => FromT4(v4);

    public T5? AsT5(bool throwError = false) =>
        (Index, throwError) switch
        {
            (5, _)     => _values.v5,
            (_, true)  => throw Helpers.CannotReturnTn(5, Index),
            (_, false) => default,
        };

    public static ValueChoice<T0, T1, T2, T3, T4, T5, T6, T7, T8> FromT5(T5 v5) => new(5, (default, default, default, default, default, v5, default, default, default)!);
    public static implicit operator ValueChoice<T0, T1, T2, T3, T4, T5, T6, T7, T8>(T5 v5) => FromT5(v5);

    public T6? AsT6(bool throwError = false) =>
        (Index, throwError) switch
        {
            (6, _)     => _values.v6,
            (_, true)  => throw Helpers.CannotReturnTn(6, Index),
            (_, false) => default,
        };

    public static ValueChoice<T0, T1, T2, T3, T4, T5, T6, T7, T8> FromT6(T6 v6) => new(6, (default, default, default, default, default, default, v6, default, default)!);
    public static implicit operator ValueChoice<T0, T1, T2, T3, T4, T5, T6, T7, T8>(T6 v6) => FromT6(v6);

    public T7? AsT7(bool throwError = false) =>
        (Index, throwError) switch
        {
            (7, _)     => _values.v7,
            (_, true)  => throw Helpers.CannotReturnTn(7, Index),
            (_, false) => default,
        };

    public static ValueChoice<T0, T1, T2, T3, T4, T5, T6, T7, T8> FromT7(T7 v7) => new(7, (default, default, default, default, default, default, default, v7, default)!);
    public static implicit operator ValueChoice<T0, T1, T2, T3, T4, T5, T6, T7, T8>(T7 v7) => FromT7(v7);

    public T8? AsT8(bool throwError = false) =>
        (Index, throwError) switch
        {
            (8, _)     => _values.v8,
            (_, true)  => throw Helpers.CannotReturnTn(8, Index),
            (_, false) => default,
        };

    public static ValueChoice<T0, T1, T2, T3, T4, T5, T6, T7, T8> FromT8(T8 v8) => new(8, (default, default, default, default, default, default, default, default, v8)!);
    public static implicit operator ValueChoice<T0, T1, T2, T3, T4, T5, T6, T7, T8>(T8 v8) => FromT8(v8);

}


/// <summary>
/// A value type that is a choice between 10 values.
/// </summary>
internal readonly record struct ValueChoice<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>
    : IChoice
{
    private readonly (T0 v0, T1 v1, T2 v2, T3 v3, T4 v4, T5 v5, T6 v6, T7 v7, T8 v8, T9 v9) _values;

    private ValueChoice(int index, (T0 v0, T1 v1, T2 v2, T3 v3, T4 v4, T5 v5, T6 v6, T7 v7, T8 v8, T9 v9) values)
    {
        Index = index;
        _values = values;
    }

    public object? Value => ((ITuple)_values)[Index];
    public int Index { get; }

    public void Switch(
        Action<T0> f0,
        Action<T1> f1,
        Action<T2> f2,
        Action<T3> f3,
        Action<T4> f4,
        Action<T5> f5,
        Action<T6> f6,
        Action<T7> f7,
        Action<T8> f8,
        Action<T9> f9)
    {
        switch (Index)
        {
            case 0: f0(_values.v0); break;
            case 1: f1(_values.v1); break;
            case 2: f2(_values.v2); break;
            case 3: f3(_values.v3); break;
            case 4: f4(_values.v4); break;
            case 5: f5(_values.v5); break;
            case 6: f6(_values.v6); break;
            case 7: f7(_values.v7); break;
            case 8: f8(_values.v8); break;
            case 9: f9(_values.v9); break;
            default: throw new UnreachableException();
        }
    }

    public TR Match<TR>(
        Func<T0, TR> f0,
        Func<T1, TR> f1,
        Func<T2, TR> f2,
        Func<T3, TR> f3,
        Func<T4, TR> f4,
        Func<T5, TR> f5,
        Func<T6, TR> f6,
        Func<T7, TR> f7,
        Func<T8, TR> f8,
        Func<T9, TR> f9) =>
        Index switch
        {
            0 => f0(_values.v0),
            1 => f1(_values.v1),
            2 => f2(_values.v2),
            3 => f3(_values.v3),
            4 => f4(_values.v4),
            5 => f5(_values.v5),
            6 => f6(_values.v6),
            7 => f7(_values.v7),
            8 => f8(_values.v8),
            9 => f9(_values.v9),
            _ => throw new UnreachableException(),
        };

    public T0? AsT0(bool throwError = false) =>
        (Index, throwError) switch
        {
            (0, _)     => _values.v0,
            (_, true)  => throw Helpers.CannotReturnTn(0, Index),
            (_, false) => default,
        };

    public static ValueChoice<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9> FromT0(T0 v0) => new(0, (v0, default, default, default, default, default, default, default, default, default)!);
    public static implicit operator ValueChoice<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(T0 v0) => FromT0(v0);

    public T1? AsT1(bool throwError = false) =>
        (Index, throwError) switch
        {
            (1, _)     => _values.v1,
            (_, true)  => throw Helpers.CannotReturnTn(1, Index),
            (_, false) => default,
        };

    public static ValueChoice<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9> FromT1(T1 v1) => new(1, (default, v1, default, default, default, default, default, default, default, default)!);
    public static implicit operator ValueChoice<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(T1 v1) => FromT1(v1);

    public T2? AsT2(bool throwError = false) =>
        (Index, throwError) switch
        {
            (2, _)     => _values.v2,
            (_, true)  => throw Helpers.CannotReturnTn(2, Index),
            (_, false) => default,
        };

    public static ValueChoice<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9> FromT2(T2 v2) => new(2, (default, default, v2, default, default, default, default, default, default, default)!);
    public static implicit operator ValueChoice<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(T2 v2) => FromT2(v2);

    public T3? AsT3(bool throwError = false) =>
        (Index, throwError) switch
        {
            (3, _)     => _values.v3,
            (_, true)  => throw Helpers.CannotReturnTn(3, Index),
            (_, false) => default,
        };

    public static ValueChoice<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9> FromT3(T3 v3) => new(3, (default, default, default, v3, default, default, default, default, default, default)!);
    public static implicit operator ValueChoice<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(T3 v3) => FromT3(v3);

    public T4? AsT4(bool throwError = false) =>
        (Index, throwError) switch
        {
            (4, _)     => _values.v4,
            (_, true)  => throw Helpers.CannotReturnTn(4, Index),
            (_, false) => default,
        };

    public static ValueChoice<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9> FromT4(T4 v4) => new(4, (default, default, default, default, v4, default, default, default, default, default)!);
    public static implicit operator ValueChoice<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(T4 v4) => FromT4(v4);

    public T5? AsT5(bool throwError = false) =>
        (Index, throwError) switch
        {
            (5, _)     => _values.v5,
            (_, true)  => throw Helpers.CannotReturnTn(5, Index),
            (_, false) => default,
        };

    public static ValueChoice<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9> FromT5(T5 v5) => new(5, (default, default, default, default, default, v5, default, default, default, default)!);
    public static implicit operator ValueChoice<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(T5 v5) => FromT5(v5);

    public T6? AsT6(bool throwError = false) =>
        (Index, throwError) switch
        {
            (6, _)     => _values.v6,
            (_, true)  => throw Helpers.CannotReturnTn(6, Index),
            (_, false) => default,
        };

    public static ValueChoice<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9> FromT6(T6 v6) => new(6, (default, default, default, default, default, default, v6, default, default, default)!);
    public static implicit operator ValueChoice<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(T6 v6) => FromT6(v6);

    public T7? AsT7(bool throwError = false) =>
        (Index, throwError) switch
        {
            (7, _)     => _values.v7,
            (_, true)  => throw Helpers.CannotReturnTn(7, Index),
            (_, false) => default,
        };

    public static ValueChoice<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9> FromT7(T7 v7) => new(7, (default, default, default, default, default, default, default, v7, default, default)!);
    public static implicit operator ValueChoice<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(T7 v7) => FromT7(v7);

    public T8? AsT8(bool throwError = false) =>
        (Index, throwError) switch
        {
            (8, _)     => _values.v8,
            (_, true)  => throw Helpers.CannotReturnTn(8, Index),
            (_, false) => default,
        };

    public static ValueChoice<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9> FromT8(T8 v8) => new(8, (default, default, default, default, default, default, default, default, v8, default)!);
    public static implicit operator ValueChoice<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(T8 v8) => FromT8(v8);

    public T9? AsT9(bool throwError = false) =>
        (Index, throwError) switch
        {
            (9, _)     => _values.v9,
            (_, true)  => throw Helpers.CannotReturnTn(9, Index),
            (_, false) => default,
        };

    public static ValueChoice<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9> FromT9(T9 v9) => new(9, (default, default, default, default, default, default, default, default, default, v9)!);
    public static implicit operator ValueChoice<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(T9 v9) => FromT9(v9);

}


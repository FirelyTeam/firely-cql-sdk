using System;
using System.Diagnostics;

namespace Hl7.Cql.Abstractions.Infrastructure;

internal interface IChoice
{
    object? Value { get; }
    int Index { get; }
}

file static class Errors
{
    public static InvalidOperationException CannotReturnTn(int desiredIndex, int actualIndex) =>
        new($"Cannot return the T{desiredIndex} value from this T{actualIndex} tuple.");

    public static InvalidOperationException? CannotHaveTypesDeriveFromEachOther(params Type[] types)
    {
        for (int i = 0; i < types.Length; i++)
        {
            for (int j = 0; j < types.Length; j++)
            {
                if (i == j) continue;
                if (types[i].IsAssignableFrom(types[j]))
                {
                    return new InvalidOperationException(
                        $"Choice type cannot have combinations of types that derive from each other. T{i} of type {types[i]} derives from T{j} of type {types[j]}.");
                }
            }
        }

        return null;
    }

    public static InvalidOperationException UninitializedChoiceType() =>
        new("The Choice type was not initialized.");
}

/// <summary>
/// A value type that is a choice between 1 value.
/// </summary>
internal readonly partial record struct ValueChoice<T0>
    : IChoice
{
    private readonly T0 _v0;
    private readonly int _index; // 1-based, 0 means uninitialized

    private ValueChoice(T0 v0)
    {
        _v0 = v0;
        _index = 1;
    }

    public object? Value => _v0;
    public int Index => _index - 1; // -1 means uninitialized

    public T0? AsT0(bool throwError = false) =>
        (Index, throwError) switch
        {
            (-1, _) => throw Errors.UninitializedChoiceType(),
            (0, _)     => _v0,
            (_, true)  => throw Errors.CannotReturnTn(0, Index),
            (_, false) => default,
        };

    public void Switch(
        Action<T0> f0)
    {
        switch (Index)
        {
            case -1: throw Errors.UninitializedChoiceType();
            case 0:  f0(_v0); break;
            default: throw new UnreachableException();
        }
    }

    public TR Match<TR>(
        Func<T0, TR> f0) =>
        Index switch
        {
            -1 => throw Errors.UninitializedChoiceType(),
            0  => f0(_v0),
            _  => throw new UnreachableException(),
        };

    public static ValueChoice<T0> FromT0(T0 v0) => new(v0!);
    public static ValueChoice<T0>[] FromT0Array(params T0[] v0Arr) => v0Arr.SelectToArray(FromT0);
    public static implicit operator ValueChoice<T0>(T0 v0) => FromT0(v0);
}
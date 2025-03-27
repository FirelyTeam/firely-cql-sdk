/*
 * Copyright (c) 2025, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

#pragma warning disable CS0414 // Field is assigned but its value is never used
namespace Hl7.Cql.Abstractions;

internal readonly struct Maybe
{
    public static readonly Maybe NoValue = default;
    public static Maybe<T> NoValueOf<T>() => default;

    public static Maybe<T> Value<T>(T value) => new(value);
}

internal readonly struct Maybe<T>(T value) : IEquatable<Maybe<T>>
{
    public static bool operator ==(Maybe<T> first, Maybe<T> second) => first.Equals(second);
    public static bool operator !=(Maybe<T> first, Maybe<T> second) => !first.Equals(second);

    public static implicit operator Maybe<T>(T value) => new(value);

    public static implicit operator Maybe<T>(Maybe _) => default;

    /// <summary>
    /// This will always be true, when the Maybe is created with the <see cref="Maybe.Value{T}(T)"/> method or via the <see cref="Maybe{T}(T)"/> constructor.
    /// Default constructed Maybe will always have HasValue as false.
    /// </summary>
    public bool HasValue { get; } = true; // NOTE: Do NOT change this to `public bool HasValue => true;`

    public T Value { get; } = value;

    public bool Equals(Maybe<T> other) => HasValue == other.HasValue && EqualityComparer<T>.Default.Equals(Value, other.Value);

    public override bool Equals(object? other) => other is Maybe<T> m && Equals(m);

    public override int GetHashCode() => HasValue ? EqualityComparer<T>.Default.GetHashCode(Value!) : 0;

    public TResult Match<TResult>(Func<T, TResult>? some, Func<TResult>? none, TResult defaultResult = default)
    {
        TResult result = defaultResult;
        Switch(some is null ? null : v => result = some(v), none is null ? null : () => none());
        return result;
    }

    public void Switch(Action<T>? some, Action? none)
    {
        if (HasValue) some?.Invoke(Value);
        else none?.Invoke();
    }

    public T GetValueOr(Func<T> fn)
    {
        if (HasValue) return Value;
        else return fn();
    }

    public T GetValueOr(T value)
    {
        return HasValue ? Value : value;
    }

    public T GetValueOrDefault()
    {
        return GetValueOr(default(T)!);
    }

    public override string? ToString() => Match(v => v?.ToString(), () => "(n/a)");
}
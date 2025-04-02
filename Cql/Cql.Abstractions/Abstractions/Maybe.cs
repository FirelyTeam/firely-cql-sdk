/*
 * Copyright (c) 2025, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using JetBrains.Annotations;

namespace Hl7.Cql.Abstractions;

internal readonly struct Maybe
{
    [UsedImplicitly]
    public static readonly Maybe NoValue = default;

    public static Maybe<T> NoValueOf<T>() => default;

    public static Maybe<T> ValueOf<T>(T value) => new(value);
}

internal readonly struct Maybe<T>(T value) : IEquatable<Maybe<T>>
{
    public static bool operator ==(Maybe<T> first, Maybe<T> second) => first.Equals(second);
    public static bool operator !=(Maybe<T> first, Maybe<T> second) => !first.Equals(second);

    public static implicit operator Maybe<T>(T value) => new(value);

    public static implicit operator Maybe<T>(Maybe _) => default;

    /// <summary>
    /// This will always be true, when the Maybe is created with the <see cref="Maybe.ValueOf{T}"/> method or via the <see cref="Maybe{T}(T)"/> constructor.
    /// Default constructed Maybe will always have HasValue as false.
    /// </summary>
    public bool HasValue { get; } = true; // NOTE: Do NOT change this to `public bool HasValue => true;`

    public T Value { get; } = value;

    public bool Equals(Maybe<T> other) =>
        HasValue == other.HasValue && EqualityComparer<T>.Default.Equals(Value, other.Value);

    public override bool Equals(object? other) =>
        other is Maybe<T> m && Equals(m);

    public override int GetHashCode() =>
        HasValue ? EqualityComparer<T>.Default.GetHashCode(Value!) : 0;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public TResult Match<TResult>(Func<T, TResult>? some, Func<TResult>? none, TResult defaultResult = default) =>
        (HasValue, some, none) switch
        {
            (true, not null, _) => some(Value),
            (true, _, not null) => none(),
            _                   => defaultResult
        };

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void Switch(Action<T>? some, Action? none)
    {
        if (HasValue) some?.Invoke(Value);
        else none?.Invoke();
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public T OrValue(Func<T> getValue) =>
        HasValue ? Value : getValue();

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public T OrValue(T value) =>
        HasValue ? Value : value;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public T OrDefault() =>
        OrValue(default(T)!);

    public override string? ToString() =>
        Match(v => v?.ToString(), () => "(n/a)");
}

internal static class MaybeExtensions
{
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static T? OrNullableValue<T>(this Maybe<T> maybe, Func<T?> getNullableValue)
        where T:struct =>
        maybe.HasValue ? maybe.Value : getNullableValue();
}
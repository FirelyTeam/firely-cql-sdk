namespace CqlApiExamples;

internal readonly record struct Maybe
{
    public static Maybe NoValue => default;
    public static Maybe<T> Of<T>(T value) => new(value);
}

internal readonly record struct Maybe<T>(T Value)
{
    public static Maybe<T> NoValue => default;
    public static implicit operator Maybe<T>(T? value) => value is null ? NoValue : new(value);
    public static implicit operator Maybe<T>(Maybe value) => NoValue;

    private readonly T _value = Value;
    public T Value => HasValue ? _value : throw new InvalidOperationException("No value");

    public bool HasValue { get; } = true; // Do NOT change this code to: HasValue => true

    public bool TryGetValue(out T value)
    {
        value = _value;
        return HasValue;
    }

    public void Switch(
        Action<T>? withValue = null,
        Action? withoutValue = null)
    {
        if (TryGetValue(out var value))
            withValue?.Invoke(value);
        else
            withoutValue?.Invoke();
    }

    public TR Return<TR>(
        Func<T, TR>? withValue = null,
        Func<TR>? withoutValue = null,
        TR defaultValue = default!)
    {
        var result = TryGetValue(out var value) switch
        {
            true when withValue is not null     => withValue!(value),
            false when withoutValue is not null => withoutValue!(),
            _                                   => defaultValue
        };
        return result;
    }

    public Maybe<TR> TryReturn<TR>(
        Func<T, TR>? withValue = null,
        Func<TR>? withoutValue = null,
        Maybe<TR> defaultValue = default!)
    {
        var result = TryGetValue(out var value) switch
        {
            true when withValue is not null     => withValue!(value),
            false when withoutValue is not null => withoutValue!(),
            _                                   => defaultValue
        };
        return result;
    }

    public Maybe<TR> TryReturn<TR>(
        Func<T, Maybe<TR>>? withValue = null,
        Func<Maybe<TR>>? withoutValue = null,
        Maybe<TR> defaultValue = default!)
    {
        var result = TryGetValue(out var value) switch
        {
            true when withValue is not null     => withValue!(value),
            false when withoutValue is not null => withoutValue!(),
            _                                   => defaultValue
        };
        return result;
    }
}
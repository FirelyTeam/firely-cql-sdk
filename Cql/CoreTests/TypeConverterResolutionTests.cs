/*
 * Copyright (c) 2026, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

#nullable enable

using Hl7.Cql.Conversion;

namespace CoreTests;

using TypeConverter = Hl7.Cql.Conversion.TypeConverter;

/// <summary>
/// <c>TypeConverter</c> remembers which conversion applies to a (from, to) pair instead of resolving it on every
/// call. These tests pin down what that memo may not change: which converter wins, when a pair is rejected, and
/// that a conversion registered after a pair was first asked about is still picked up.
/// </summary>
[TestClass]
[TestCategory("UnitTest")]
public class TypeConverterResolutionTests
{
    private sealed record Source(string Value);

    private sealed record Target(string Value);

    private sealed record Other(string Value);

    /// <summary>
    /// A converter that claims a fixed pair and records how often it was asked, so a test can tell resolution
    /// apart from conversion.
    /// </summary>
    private sealed class CountingConverter(Type from, Type to, Func<object?, object?> convert) : ITypeConverterEntry
    {
        public int HandlesCalls { get; private set; }

        public int ConvertCalls { get; private set; }

        public bool Handles(Type f, Type t)
        {
            HandlesCalls++;
            return f == from && t == to;
        }

        public object? Convert(object? instance, Type t)
        {
            ConvertCalls++;
            return convert(instance);
        }
    }

    private static TypeConverter NewConverter() => TypeConverter.Create();

    #region What the memo may not change

    [TestMethod]
    public void RegisteredConversion_IsApplied()
    {
        var converter = NewConverter();
        converter.AddConversion<Source, Target>(s => new Target(s.Value));

        Assert.AreEqual(new Target("x"), converter.Convert<Target>(new Source("x")));
        Assert.IsTrue(converter.CanConvert(typeof(Source), typeof(Target)));
    }

    /// <summary>
    /// A custom converter is consulted ahead of the registered delegates, the order <c>Convert</c> has always used.
    /// </summary>
    [TestMethod]
    public void CustomConverter_WinsOverARegisteredDelegate()
    {
        var converter = NewConverter();
        converter.AddConversion<Source, Target>(_ => new Target("from delegate"));
        converter.AddConverter(new CountingConverter(typeof(Source), typeof(Target), _ => new Target("from custom")));

        Assert.AreEqual(new Target("from custom"), converter.Convert<Target>(new Source("x")));
    }

    /// <summary>
    /// Two custom converters claiming the same pair is ambiguous, and stays rejected rather than resolving to
    /// whichever happens to come first.
    /// </summary>
    [TestMethod]
    public void PairClaimedByTwoCustomConverters_IsRejected()
    {
        var converter = NewConverter();
        converter.AddConverter(new CountingConverter(typeof(Source), typeof(Target), _ => new Target("a")));
        converter.AddConverter(new CountingConverter(typeof(Source), typeof(Target), _ => new Target("b")));

        Assert.ThrowsException<InvalidOperationException>(() => converter.Convert<Target>(new Source("x")));
    }

    [TestMethod]
    public void UnresolvablePair_ThrowsFromConvertAndIsFalseFromCanConvert()
    {
        var converter = NewConverter();

        Assert.IsFalse(converter.CanConvert(typeof(Source), typeof(Target)));
        Assert.ThrowsException<InvalidOperationException>(() => converter.Convert<Target>(new Source("x")));

        // Asking twice must give the same answer — a remembered "no conversion" is still a "no conversion".
        Assert.IsFalse(converter.CanConvert(typeof(Source), typeof(Target)));
        Assert.ThrowsException<InvalidOperationException>(() => converter.Convert<Target>(new Source("x")));
    }

    /// <summary>
    /// An instance already assignable to the target type is handed back untouched, without consulting a converter.
    /// </summary>
    [TestMethod]
    public void AssignableInstance_IsReturnedAsIs()
    {
        var converter = NewConverter();
        var target = new Target("x");

        Assert.AreSame(target, converter.Convert<Target>(target));
    }

    [TestMethod]
    public void ConvertingNull_IsNull()
    {
        Assert.IsNull(NewConverter().Convert<Target>(null));
    }

    #endregion

    #region The memo is invalidated by registration

    /// <summary>
    /// A pair asked about before any conversion for it existed must not stay unresolvable once one is registered.
    /// </summary>
    [TestMethod]
    public void ConversionRegisteredAfterAFailedProbe_IsPickedUp()
    {
        var converter = NewConverter();

        Assert.IsFalse(converter.CanConvert(typeof(Source), typeof(Target)));

        converter.AddConversion<Source, Target>(s => new Target(s.Value));

        Assert.IsTrue(converter.CanConvert(typeof(Source), typeof(Target)));
        Assert.AreEqual(new Target("x"), converter.Convert<Target>(new Source("x")));
    }

    [TestMethod]
    public void CustomConverterRegisteredAfterAFailedProbe_IsPickedUp()
    {
        var converter = NewConverter();

        Assert.IsFalse(converter.CanConvert(typeof(Source), typeof(Target)));

        converter.AddConverter(new CountingConverter(typeof(Source), typeof(Target), _ => new Target("late")));

        Assert.AreEqual(new Target("late"), converter.Convert<Target>(new Source("x")));
    }

    /// <summary>
    /// A custom converter registered after a pair already resolved to a delegate takes precedence from then on,
    /// the same as if it had been registered first.
    /// </summary>
    [TestMethod]
    public void CustomConverterRegisteredAfterAResolvedPair_TakesOver()
    {
        var converter = NewConverter();
        converter.AddConversion<Source, Target>(_ => new Target("from delegate"));

        Assert.AreEqual(new Target("from delegate"), converter.Convert<Target>(new Source("x")));

        converter.AddConverter(new CountingConverter(typeof(Source), typeof(Target), _ => new Target("from custom")));

        Assert.AreEqual(new Target("from custom"), converter.Convert<Target>(new Source("x")));
    }

    #endregion

    #region The resolution is not repeated

    /// <summary>
    /// The point of the memo: converting the same pair over and over asks the custom converters once, not once per
    /// conversion. <see cref="ITypeConverterEntry.Convert"/> still runs every time — only the resolution is reused.
    /// </summary>
    [TestMethod]
    public void RepeatedConversionsOfTheSamePair_ResolveOnce()
    {
        var converter = NewConverter();
        var custom = new CountingConverter(typeof(Source), typeof(Target), s => new Target(((Source)s!).Value));
        converter.AddConverter(custom);

        for (var i = 0; i < 10; i++)
            Assert.AreEqual(new Target($"{i}"), converter.Convert<Target>(new Source($"{i}")));

        Assert.AreEqual(10, custom.ConvertCalls);
        Assert.AreEqual(1, custom.HandlesCalls, "the applicable converter should be resolved once, then reused");
    }

    /// <summary>
    /// Distinct pairs are remembered separately, so one pair's answer never serves another's.
    /// </summary>
    [TestMethod]
    public void DistinctPairs_AreRememberedSeparately()
    {
        var converter = NewConverter();
        converter.AddConversion<Source, Target>(s => new Target(s.Value));
        converter.AddConversion<Source, Other>(s => new Other(s.Value + "!"));

        Assert.AreEqual(new Target("x"), converter.Convert<Target>(new Source("x")));
        Assert.AreEqual(new Other("x!"), converter.Convert<Other>(new Source("x")));
        Assert.AreEqual(new Target("x"), converter.Convert<Target>(new Source("x")));
        Assert.IsFalse(converter.CanConvert(typeof(Target), typeof(Source)));
    }

    #endregion
}

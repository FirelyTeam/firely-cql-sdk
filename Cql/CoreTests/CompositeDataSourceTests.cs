/*
 * Copyright (c) 2026, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using Hl7.Cql.Operators;

namespace CoreTests;

[TestClass]
public class CompositeDataSourceTests
{
    [TestMethod]
    public void Retrieve_OfSeveralSources_ReturnsTheirResultsInOrderAfterReadingEachOnce()
    {
        var first = new CountingDataSource("a1", "a2");
        var second = new CountingDataSource("b1");
        var composite = new CompositeDataSource(first, second);

        var result = composite.Retrieve<string>(null);
        result.Should().Equal("a1", "a2", "b1");
        result.Should().Equal("a1", "a2", "b1");

        first.Retrieves.Should().Be(1);
        first.Reads.Should().Be(1, "the result is read in full once, not again each time it is walked");
        second.Retrieves.Should().Be(1);
        second.Reads.Should().Be(1, "the result is read in full once, not again each time it is walked");
    }

    [TestMethod]
    public void Retrieve_OfASourceThatFailsWhenRead_ThrowsFromTheRetrieve()
    {
        var composite = new CompositeDataSource(new FailsWhenReadDataSource());

        var retrieve = () => composite.Retrieve<string>(null);

        retrieve.Should().Throw<InvalidOperationException>().WithMessage(FailsWhenReadDataSource.Failure);
    }

    [TestMethod]
    public void Retrieve_WithoutSources_ReturnsAnEmptyList() =>
        new CompositeDataSource().Retrieve<string>(null).Should().BeEmpty();

    /// <summary>
    /// A data source that returns its items lazily and counts how often it is retrieved from and read.
    /// </summary>
    private sealed class CountingDataSource(params string[] items) : IDataSource
    {
        public int Retrieves { get; private set; }

        public int Reads { get; private set; }

        public IEnumerable<T> Retrieve<T>(RetrieveParameters? parameters) where T : class
        {
            Retrieves++;
            return Read<T>();
        }

        private IEnumerable<T> Read<T>() where T : class
        {
            Reads++;
            foreach (var item in items)
                yield return (T)(object)item;
        }
    }

    /// <summary>
    /// A data source whose retrieve returns at once and throws only when it is read.
    /// </summary>
    private sealed class FailsWhenReadDataSource : IDataSource
    {
        public const string Failure = "The data source failed while it was read.";

        public IEnumerable<T> Retrieve<T>(RetrieveParameters? parameters) where T : class =>
            Enumerable.Range(0, 1).Select<int, T>(_ => throw new InvalidOperationException(Failure));
    }
}

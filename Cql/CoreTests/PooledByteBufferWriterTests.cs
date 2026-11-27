/*
 * Copyright (c) 2026, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using Hl7.Cql.Elm.Serialization;

namespace CoreTests;

[TestClass]
public class PooledByteBufferWriterTests
{
    [TestMethod]
    public void Advance_WithinTheBuffer_MovesTheWrittenLength()
    {
        using var writer = new PooledByteBufferWriter(16);
        writer.GetSpan(3)[..3].Fill(7);

        writer.Advance(3);

        writer.WrittenSpan.ToArray().Should().Equal(7, 7, 7);
    }

    [TestMethod]
    [DataRow(-1)]
    [DataRow(int.MinValue)]
    public void Advance_ByANegativeCount_Throws(int count)
    {
        using var writer = new PooledByteBufferWriter(16);

        Assert.Throws<ArgumentOutOfRangeException>(() => writer.Advance(count));
        writer.WrittenSpan.Length.Should().Be(0);
    }

    [TestMethod]
    public void Advance_PastTheEndOfTheBuffer_Throws()
    {
        using var writer = new PooledByteBufferWriter(16);
        var available = writer.GetSpan().Length;
        writer.Advance(available);

        Assert.Throws<ArgumentOutOfRangeException>(() => writer.Advance(1));
        writer.WrittenSpan.Length.Should().Be(available);
    }

    [TestMethod]
    public void GetSpan_PastTheMaximumArrayLength_ThrowsOutOfMemoryException()
    {
        using var writer = new PooledByteBufferWriter(16);
        writer.Advance(1);

        Assert.Throws<OutOfMemoryException>(() => writer.GetSpan(Array.MaxLength));
    }
}

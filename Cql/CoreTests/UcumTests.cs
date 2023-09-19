using FluentAssertions;
using Hl7.Cql.Conversion;
using Hl7.Cql.Primitives;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CoreTests
{
    [TestClass]
    public class UcumTests
    {
        [TestMethod]
        public void NormalizesPrefixes()
        {
            var q = new CqlQuantity(3.14M, "kg");
            var success = q.TryCanonicalize(out var canonical);
            success.Should().BeTrue();
            canonical.unit.Should().Be("g");
            canonical.value.Should().Be(3.14M * 1000.0M);

            q = new CqlQuantity(2.5M, "h");
            success = q.TryCanonicalize(out canonical);
            success.Should().BeTrue();
            canonical.unit.Should().Be("s");
            canonical.value.Should().Be(2.5M * 60.0M * 60.0M);
        }

        [TestMethod, Ignore]
        public void ConvertsUnits()
        {
            var q = new CqlQuantity(3.14M, "kg");
            var success = q.TryConvert("g", out var converted);
            success.Should().BeTrue();
            converted.unit.Should().Be("g");
            converted.value.Should().Be(3.14M * 1000.0M * 1000.0M);
        }
    }
}

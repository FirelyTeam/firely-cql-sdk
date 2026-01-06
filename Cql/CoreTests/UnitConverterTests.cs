/*
 * Copyright (c) 2025, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using Hl7.Cql.Abstractions;
using Hl7.Cql.Fhir;
using Hl7.Cql.Operators;
using Hl7.Cql.Primitives;

namespace CoreTests
{
    [TestClass]
    public class UnitConverterTests
    {
        private CqlOperators GetOperators() => FhirCqlContext.WithDataSource().Operators;

        [TestMethod]
        public void ConvertQuantity_Day_To_D()
        {
            var ops = GetOperators();
            var quantity = new CqlQuantity(5m, "day");
            var result = ops.ConvertQuantity(quantity, "d");
            
            result.Should().NotBeNull();
            result!.value.Should().Be(5m);
            result.unit.Should().Be("d");
        }

        [TestMethod]
        public void ConvertQuantity_D_To_Day()
        {
            var ops = GetOperators();
            var quantity = new CqlQuantity(5m, "d");
            var result = ops.ConvertQuantity(quantity, "day");
            
            result.Should().NotBeNull();
            result!.value.Should().Be(5m);
            result.unit.Should().Be("day");
        }

        [TestMethod]
        public void ConvertQuantity_Month_To_Mo()
        {
            var ops = GetOperators();
            var quantity = new CqlQuantity(3m, "month");
            var result = ops.ConvertQuantity(quantity, "mo");
            
            result.Should().NotBeNull();
            result!.value.Should().Be(3m);
            result.unit.Should().Be("mo");
        }

        [TestMethod]
        public void ConvertQuantity_Year_To_A()
        {
            var ops = GetOperators();
            var quantity = new CqlQuantity(2m, "year");
            var result = ops.ConvertQuantity(quantity, "a");
            
            result.Should().NotBeNull();
            result!.value.Should().Be(2m);
            result.unit.Should().Be("a");
        }

        [TestMethod]
        public void ConvertQuantity_Week_To_Wk()
        {
            var ops = GetOperators();
            var quantity = new CqlQuantity(4m, "week");
            var result = ops.ConvertQuantity(quantity, "wk");
            
            result.Should().NotBeNull();
            result!.value.Should().Be(4m);
            result.unit.Should().Be("wk");
        }

        [TestMethod]
        public void ConvertQuantity_Hour_To_H()
        {
            var ops = GetOperators();
            var quantity = new CqlQuantity(24m, "hour");
            var result = ops.ConvertQuantity(quantity, "h");
            
            result.Should().NotBeNull();
            result!.value.Should().Be(24m);
            result.unit.Should().Be("h");
        }

        [TestMethod]
        public void ConvertQuantity_Minute_To_Min()
        {
            var ops = GetOperators();
            var quantity = new CqlQuantity(60m, "minute");
            var result = ops.ConvertQuantity(quantity, "min");
            
            result.Should().NotBeNull();
            result!.value.Should().Be(60m);
            result.unit.Should().Be("min");
        }

        [TestMethod]
        public void ConvertQuantity_Second_To_S()
        {
            var ops = GetOperators();
            var quantity = new CqlQuantity(30m, "second");
            var result = ops.ConvertQuantity(quantity, "s");
            
            result.Should().NotBeNull();
            result!.value.Should().Be(30m);
            result.unit.Should().Be("s");
        }

        [TestMethod]
        public void ConvertQuantity_Millisecond_To_Ms()
        {
            var ops = GetOperators();
            var quantity = new CqlQuantity(1000m, "millisecond");
            var result = ops.ConvertQuantity(quantity, "ms");
            
            result.Should().NotBeNull();
            result!.value.Should().Be(1000m);
            result.unit.Should().Be("ms");
        }

        [TestMethod]
        public void ConvertQuantity_Day_To_Month_UsesExistingConversion()
        {
            var ops = GetOperators();
            var quantity = new CqlQuantity(30.4375m, "day");
            var result = ops.ConvertQuantity(quantity, "month");
            
            result.Should().NotBeNull();
            result!.value.Should().BeApproximately(1m, 0.0001m);
            result.unit.Should().Be("month");
        }
    }
}

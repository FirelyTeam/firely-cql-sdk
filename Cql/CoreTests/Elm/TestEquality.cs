using FluentAssertions;
using Hl7.Cql.Elm;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CoreTests.Elm
{
    [TestClass]
    public class TestEquality
    {
        internal static readonly TypeSpecifier FullTT = new TupleTypeSpecifier
        {
            element = new[]
          {
                    new TupleElementDefinition { name = "typeParam", elementType = new ParameterTypeSpecifier { parameterName = "A" } },
                    new TupleElementDefinition { name = "typeParam2", elementType = SystemTypes.T },
                    new TupleElementDefinition { name = "list", elementType = new ListTypeSpecifier { elementType = new ParameterTypeSpecifier { parameterName = "B" } } },
                    new TupleElementDefinition { name = "interval", elementType = new IntervalTypeSpecifier { pointType = new ParameterTypeSpecifier { parameterName = "C" } } },
                    new TupleElementDefinition { name = "interval2", elementType = new IntervalTypeSpecifier { pointType = new ParameterTypeSpecifier { parameterName = "C" } } },
                    new TupleElementDefinition { name = "choice", elementType = new ChoiceTypeSpecifier { choice = new TypeSpecifier[] { SystemTypes.IntegerType, new ParameterTypeSpecifier { parameterName = "D" }, new ParameterTypeSpecifier { parameterName = "E" } } } },
                    new TupleElementDefinition { name = "named", elementType = SystemTypes.StringType },
            }
        };

        internal static readonly TypeSpecifier EmptyTT = new TupleTypeSpecifier
        {
            element = new[]
            {
                    new TupleElementDefinition { name = "typeParam", elementType = new ParameterTypeSpecifier() },
                    new TupleElementDefinition { name = "list", elementType = new ListTypeSpecifier()},
                    new TupleElementDefinition { name = "interval", elementType = new IntervalTypeSpecifier()},
                    new TupleElementDefinition { name = "interval2", elementType = new IntervalTypeSpecifier()},
                    new TupleElementDefinition { name = "choice", elementType = new ChoiceTypeSpecifier() },
                    new TupleElementDefinition { name = "named", elementType = new NamedTypeSpecifier() },
                    new TupleElementDefinition { name = "emptytt", elementType = new TupleTypeSpecifier()},
                    new TupleElementDefinition { name = "justname" },
                    new TupleElementDefinition(),
            }
        };

        [TestMethod]
        public void TestNamedTypeSpecifierEquals()
        {
            var ns1 = new NamedTypeSpecifier() { name = new System.Xml.XmlQualifiedName("Foo") };
            var ns2 = new NamedTypeSpecifier() { name = new System.Xml.XmlQualifiedName("Foo") };
            var ns3 = new NamedTypeSpecifier() { name = new System.Xml.XmlQualifiedName("NotFoo") };
            var ns4 = new NamedTypeSpecifier();

            ns1.Should().Be(ns2);
            ns1.Should().NotBe(ns3);
            ns1.Should().NotBe(ns4);
        }

        [TestMethod]
        public void TestIntervalTypeSpecifierEquals()
        {
            var its1 = new IntervalTypeSpecifier() { pointType = SystemTypes.LongType };
            var its2 = new IntervalTypeSpecifier() { pointType = SystemTypes.LongType };
            var its3 = new IntervalTypeSpecifier() { pointType = SystemTypes.StringType };
            var its4 = new IntervalTypeSpecifier() { };

            its1.Should().Be(its2);
            its1.Should().NotBe(its3);
            its1.Should().NotBe(its4);
        }

        [TestMethod]
        public void TestListTypeSpecifierEquals()
        {
            var lts1 = new ListTypeSpecifier() { elementType = SystemTypes.LongType };
            var lts2 = new ListTypeSpecifier() { elementType = SystemTypes.LongType };
            var lts3 = new ListTypeSpecifier() { elementType = SystemTypes.StringType };
            var lts4 = new ListTypeSpecifier() { };

            lts1.Should().Be(lts2);
            lts1.Should().NotBe(lts3);
            lts1.Should().NotBe(lts4);
        }

        [TestMethod]
        public void TestTupleTypeSpecifierEquals()
        {
            var tts1 = new TupleTypeSpecifier() { element = new[] { new TupleElementDefinition() { name = "Foo", elementType = SystemTypes.LongType } } };
            var tts2 = new TupleTypeSpecifier() { element = new[] { new TupleElementDefinition() { name = "Foo", elementType = SystemTypes.LongType } } };
            var tts3 = new TupleTypeSpecifier() { element = new[] { new TupleElementDefinition() { name = "Bar", elementType = SystemTypes.LongType } } };
            var tts4 = new TupleTypeSpecifier();

            tts1.Should().Be(tts2);
            tts1.Should().NotBe(tts3);
            tts1.Should().NotBe(tts4);

            FullTT.Should().Be(FullTT);
            EmptyTT.Should().Be(EmptyTT);
        }

        [TestMethod]
        public void TestChoiceTypeSpecifierEquals()
        {
            var cts1 = new ChoiceTypeSpecifier() { choice = new[] { SystemTypes.LongType, SystemTypes.StringType } };
            var cts2 = new ChoiceTypeSpecifier() { choice = new[] { SystemTypes.LongType, SystemTypes.StringType } };
            var cts3 = new ChoiceTypeSpecifier() { choice = new[] { SystemTypes.LongType, SystemTypes.BooleanType } };
            var cts4 = new ChoiceTypeSpecifier();

            cts1.Should().Be(cts2);
            cts1.Should().NotBe(cts3);
            cts1.Should().NotBe(cts4);
        }

        [TestMethod]
        public void TestParameterTypeSpecifierEquals()
        {
            var pts1 = new ParameterTypeSpecifier() { parameterName = "Foo" };
            var pts2 = new ParameterTypeSpecifier() { parameterName = "Foo" };
            var pts3 = new ParameterTypeSpecifier() { parameterName = "Bar" };
            var pts4 = new ParameterTypeSpecifier();

            pts1.Should().Be(pts2);
            pts1.Should().NotBe(pts3);
            pts1.Should().NotBe(pts4);
        }
    }
}

using System.Linq;
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
            element =
            [
                new TupleElementDefinition { name = "list", elementType = new ListTypeSpecifier { elementType = new ParameterTypeSpecifier { parameterName = "B" } } },
                new TupleElementDefinition { name = "interval", elementType = new IntervalTypeSpecifier { pointType = new ParameterTypeSpecifier { parameterName = "C" } } },
                new TupleElementDefinition { name = "interval2", elementType = new IntervalTypeSpecifier { pointType = new ParameterTypeSpecifier { parameterName = "C" } } },
                new TupleElementDefinition { name = "choice", elementType = new ChoiceTypeSpecifier { choice = [SystemTypes.IntegerType, new ParameterTypeSpecifier { parameterName = "D" }, new ParameterTypeSpecifier { parameterName = "E" }] } },
                new TupleElementDefinition { name = "named", elementType = SystemTypes.StringType }
            ]
        };

        internal static readonly TypeSpecifier EmptyTT = new TupleTypeSpecifier
        {
            element =
            [
                new TupleElementDefinition { name = "list", elementType = new ListTypeSpecifier()},
                new TupleElementDefinition { name = "interval", elementType = new IntervalTypeSpecifier()},
                new TupleElementDefinition { name = "interval2", elementType = new IntervalTypeSpecifier()},
                new TupleElementDefinition { name = "choice", elementType = new ChoiceTypeSpecifier() },
                new TupleElementDefinition { name = "named", elementType = new NamedTypeSpecifier() },
                new TupleElementDefinition { name = "emptytt", elementType = new TupleTypeSpecifier()},
                new TupleElementDefinition { name = "justname" },
                new TupleElementDefinition()
            ]
        };

        private static void eq<T>(T a, T b) where T : TypeSpecifier
        {
            a.Should().Be(b);
            (a == b).Should().BeTrue();
            (a != b).Should().BeFalse();
            a.GetHashCode().Should().Be(b.GetHashCode());

            TypeSpecifier at = a;
            TypeSpecifier bt = b;
            at.Should().Be(bt);
            (at == bt).Should().BeTrue();
            (at != bt).Should().BeFalse();
            at.GetHashCode().Should().Be(bt.GetHashCode());
        }

        private static void neq<T>(T a, T b) where T : TypeSpecifier
        {
            a.Should().NotBe(b);
            (a == b).Should().BeFalse();
            (a != b).Should().BeTrue();

            TypeSpecifier at = a;
            TypeSpecifier bt = b;
            at.Should().NotBe(bt);
            (at == bt).Should().BeFalse();
            (at != bt).Should().BeTrue();
        }

        [TestMethod]
        public void TestNamedTypeSpecifierEquals()
        {
            var ns1 = new NamedTypeSpecifier() { name = new System.Xml.XmlQualifiedName("Foo") };
            var ns2 = new NamedTypeSpecifier() { name = new System.Xml.XmlQualifiedName("Foo") };
            var ns3 = new NamedTypeSpecifier() { name = new System.Xml.XmlQualifiedName("NotFoo") };
            var ns4 = new NamedTypeSpecifier();

            eq(ns1, ns2);
            neq(ns1, ns3);
            neq(ns1, ns4);
        }

        [TestMethod]
        public void TestIntervalTypeSpecifierEquals()
        {
            var its1 = new IntervalTypeSpecifier() { pointType = SystemTypes.LongType };
            var its2 = new IntervalTypeSpecifier() { pointType = SystemTypes.LongType };
            var its3 = new IntervalTypeSpecifier() { pointType = SystemTypes.StringType };
            var its4 = new IntervalTypeSpecifier() { };

            eq(its1, its2);
            neq(its1, its3);
            neq(its1, its4);
        }

        [TestMethod]
        public void TestListTypeSpecifierEquals()
        {
            var lts1 = new ListTypeSpecifier() { elementType = SystemTypes.LongType };
            var lts2 = new ListTypeSpecifier() { elementType = SystemTypes.LongType };
            var lts3 = new ListTypeSpecifier() { elementType = SystemTypes.StringType };
            var lts4 = new ListTypeSpecifier() { };

            eq(lts1, lts2);
            neq(lts1, lts3);
            neq(lts1, lts4);
        }

        [TestMethod]
        public void TestTupleTypeSpecifierEquals()
        {
            var tts1 = new TupleTypeSpecifier() { element = [new TupleElementDefinition() { name = "Foo", elementType = SystemTypes.LongType }] };
            var tts2 = new TupleTypeSpecifier() { element = [new TupleElementDefinition() { name = "Foo", elementType = SystemTypes.LongType }] };
            var tts3 = new TupleTypeSpecifier() { element = [new TupleElementDefinition() { name = "Bar", elementType = SystemTypes.LongType }] };
            var tts4 = new TupleTypeSpecifier() { element = [new TupleElementDefinition() { name = "Foo", elementType = SystemTypes.BooleanType }] };
            var tts5 = new TupleTypeSpecifier();

            eq(tts1, tts2);
            neq(tts1, tts3);
            neq(tts1, tts4);
            neq(tts1, tts5);
            eq(FullTT, FullTT);
            eq(EmptyTT, EmptyTT);
            neq(FullTT, EmptyTT);
            neq(EmptyTT, FullTT);
        }

        [TestMethod]
        public void TestChoiceTypeSpecifierEquals()
        {
            var cts1 = new ChoiceTypeSpecifier() { choice = [SystemTypes.LongType, SystemTypes.StringType] };
            var cts2 = new ChoiceTypeSpecifier() { choice = [SystemTypes.LongType, SystemTypes.StringType] };
            var cts3 = new ChoiceTypeSpecifier() { choice = [SystemTypes.LongType, SystemTypes.BooleanType] };
            var cts4 = new ChoiceTypeSpecifier();
            cts1.Equals(cts4);
            eq(cts1, cts2);
            neq(cts1, cts3);
            TypeSpecifier.SetEquals(cts1.choice, cts4.choice).Should().BeFalse();
            TypeSpecifier.SetEquals(cts4.choice, cts1.choice).Should().BeFalse();
            neq(cts1, cts4);
        }

        [TestMethod]
        public void TestParameterTypeSpecifierEquals()
        {
            var pts1 = new ParameterTypeSpecifier() { parameterName = "Foo" };
            var pts2 = new ParameterTypeSpecifier() { parameterName = "Foo" };
            var pts3 = new ParameterTypeSpecifier() { parameterName = "Bar" };
            var pts4 = new ParameterTypeSpecifier();

            eq(pts1, pts2);
            neq(pts1, pts3);
            neq(pts1, pts4);
        }

        [TestMethod]
        public void TestDistinctTypeSpecifiers()
        {
            TypeSpecifier[] input = [
                new ParameterTypeSpecifier(),
                new ParameterTypeSpecifier(),
                new ParameterTypeSpecifier() { parameterName = "Foo" },
                new ParameterTypeSpecifier() { parameterName = "Foo" },
                new ParameterTypeSpecifier() { parameterName = "Bar" },

                new ChoiceTypeSpecifier(),
                new ChoiceTypeSpecifier(),
                new ChoiceTypeSpecifier() { choice = [SystemTypes.LongType, SystemTypes.StringType] },
                new ChoiceTypeSpecifier() { choice = [SystemTypes.LongType, SystemTypes.StringType] },
                new ChoiceTypeSpecifier() { choice = [SystemTypes.LongType, SystemTypes.BooleanType] },

                new ChoiceTypeSpecifier(),
                new ChoiceTypeSpecifier(),
                new ChoiceTypeSpecifier() { choice = [SystemTypes.LongType, SystemTypes.StringType] },
                new ChoiceTypeSpecifier() { choice = [SystemTypes.LongType, SystemTypes.StringType] },
                new ChoiceTypeSpecifier() { choice = [SystemTypes.LongType, SystemTypes.BooleanType] },

                new TupleTypeSpecifier(),
                new TupleTypeSpecifier(),
                new TupleTypeSpecifier() { element = [new TupleElementDefinition() { name = "Foo", elementType = SystemTypes.LongType }] },
                new TupleTypeSpecifier() { element = [new TupleElementDefinition() { name = "Foo", elementType = SystemTypes.LongType }] },
                new TupleTypeSpecifier() { element = [new TupleElementDefinition() { name = "Bar", elementType = SystemTypes.LongType }] },

                new TupleTypeSpecifier()
                {
                    element = [
                        new TupleElementDefinition { name = "list", elementType = new ListTypeSpecifier { elementType = new ParameterTypeSpecifier { parameterName = "B" } } },
                        new TupleElementDefinition { name = "interval", elementType = new IntervalTypeSpecifier { pointType = new ParameterTypeSpecifier { parameterName = "C" } } },
                        new TupleElementDefinition { name = "interval2", elementType = new IntervalTypeSpecifier { pointType = new ParameterTypeSpecifier { parameterName = "C" } } },
                        new TupleElementDefinition { name = "choice", elementType = new ChoiceTypeSpecifier { choice = [SystemTypes.IntegerType, new ParameterTypeSpecifier { parameterName = "D" }, new ParameterTypeSpecifier { parameterName = "E" }] } },
                        new TupleElementDefinition { name = "named", elementType = SystemTypes.StringType }
                    ]
                },
                new TupleTypeSpecifier()
                {
                    element = [
                        new TupleElementDefinition { name = "list", elementType = new ListTypeSpecifier { elementType = new ParameterTypeSpecifier { parameterName = "B" } } },
                        new TupleElementDefinition { name = "interval", elementType = new IntervalTypeSpecifier { pointType = new ParameterTypeSpecifier { parameterName = "C" } } },
                        new TupleElementDefinition { name = "interval2", elementType = new IntervalTypeSpecifier { pointType = new ParameterTypeSpecifier { parameterName = "C" } } },
                        new TupleElementDefinition { name = "choice", elementType = new ChoiceTypeSpecifier { choice = [SystemTypes.IntegerType, new ParameterTypeSpecifier { parameterName = "D" }, new ParameterTypeSpecifier { parameterName = "E" }] } },
                        new TupleElementDefinition { name = "named", elementType = SystemTypes.StringType }
                    ]
                },
            ];

            // Act
            var distinct = input.Distinct();
            distinct.Count().Should().Be(10);
        }
    }
}

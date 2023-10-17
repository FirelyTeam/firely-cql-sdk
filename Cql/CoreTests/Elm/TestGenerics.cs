using FluentAssertions;
using Hl7.Cql.Elm;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CoreTests.Elm
{
    [TestClass]
    public class TestGenerics
    {
        [TestMethod]
        public void ListGenerics()
        {
            TestEquality.FullTT.GetGenericParameters().Should().BeEquivalentTo(new[] {
                new ParameterTypeSpecifier { parameterName = "A" },
                new ParameterTypeSpecifier { parameterName = "T" },
                new ParameterTypeSpecifier { parameterName = "B" },
                new ParameterTypeSpecifier { parameterName = "C" },
                new ParameterTypeSpecifier { parameterName = "D" },
                new ParameterTypeSpecifier { parameterName = "E" } });

            // The empty test value contains 1 anonymous ParameterTypeSpecifier.
            TestEquality.EmptyTT.GetGenericParameters().Should().BeEquivalentTo(new[] { new ParameterTypeSpecifier() });
        }

        private readonly GenericParameterAssignments testMap = new()
        {
            { "A", SystemTypes.IntegerType },
            { "B", SystemTypes.StringType },
            { "C", SystemTypes.BooleanType },
            { "D", SystemTypes.IntegerType },
            { "E", SystemTypes.StringType },
        };

        [
            TestMethod]
        public void ReplaceNamedTypeGenerics()
        {
            var ns1 = new NamedTypeSpecifier() { name = new System.Xml.XmlQualifiedName("Foo") };
            var ns2 = new NamedTypeSpecifier();

            ns1.ReplaceGenericParameters(testMap).Should().BeEquivalentTo(ns1);
            ns2.ReplaceGenericParameters(testMap).Should().BeEquivalentTo(ns2);
        }

        [TestMethod]
        public void ReplaceParameterTypeGenerics()
        {
            var pt1 = new ParameterTypeSpecifier() { parameterName = "B" };
            var pt2 = SystemTypes.T;
            var pt3 = new ParameterTypeSpecifier();

            pt1.ReplaceGenericParameters(testMap).Should().BeEquivalentTo(SystemTypes.StringType);
            pt2.ReplaceGenericParameters(testMap).Should().BeEquivalentTo(pt2, "no replacement, no change");
            pt3.ReplaceGenericParameters(testMap).Should().BeEquivalentTo(pt3);
        }

        [TestMethod]
        public void ReplaceIntervalTypeGenerics()
        {
            var iv1 = new IntervalTypeSpecifier() { pointType = new ParameterTypeSpecifier { parameterName = "A" } };
            var iv2 = new IntervalTypeSpecifier() { pointType = SystemTypes.T };
            var iv3 = new IntervalTypeSpecifier() { pointType = SystemTypes.StringType };
            var iv4 = new IntervalTypeSpecifier() { };

            iv1.ReplaceGenericParameters(testMap).Should()
                .BeEquivalentTo(new IntervalTypeSpecifier() { pointType = SystemTypes.IntegerType })
                .And.NotBeSameAs(iv1);

            iv2.ReplaceGenericParameters(testMap).Should().BeEquivalentTo(iv2, "no replacement, no change");
            iv3.ReplaceGenericParameters(testMap).Should().BeEquivalentTo(iv3, "no replacement, no change");
            iv4.Should().BeEquivalentTo(iv4);
        }

        [TestMethod]
        public void ReplaceListTypeGenerics()
        {
            var li1 = new ListTypeSpecifier() { elementType = new ParameterTypeSpecifier { parameterName = "A" } };
            var li2 = new ListTypeSpecifier() { elementType = SystemTypes.T };
            var li3 = new ListTypeSpecifier() { elementType = SystemTypes.StringType };
            var li4 = new ListTypeSpecifier() { };

            li1.ReplaceGenericParameters(testMap).Should()
                .BeEquivalentTo(new ListTypeSpecifier() { elementType = SystemTypes.IntegerType })
                .And.NotBeSameAs(li1);

            li2.ReplaceGenericParameters(testMap).Should().BeEquivalentTo(li2, "no replacement, no change");
            li3.ReplaceGenericParameters(testMap).Should().BeEquivalentTo(li3, "no replacement, no change");
            li4.Should().BeEquivalentTo(li4);
        }

        [TestMethod]
        public void ReplaceChoiceTypeGenerics()
        {
            var ct1 = new ChoiceTypeSpecifier()
            {
                choice = new TypeSpecifier[]
                {
                    new ParameterTypeSpecifier { parameterName = "A" },
                    SystemTypes.T,
                    SystemTypes.LongType
                }
            };
            var ct2 = new ChoiceTypeSpecifier();
            var ct3 = new ChoiceTypeSpecifier()
            {
                choice = new TypeSpecifier[]
                {
                    SystemTypes.Generic("A"),
                    SystemTypes.IntegerType
                }
            };

            ct1.ReplaceGenericParameters(testMap).Should()
                .BeEquivalentTo(new ChoiceTypeSpecifier()
                {
                    choice = new TypeSpecifier[]
                    {
                        SystemTypes.IntegerType,
                        SystemTypes.T,
                        SystemTypes.LongType
                    }
                })
                .And.NotBeSameAs(ct1);

            ct2.ReplaceGenericParameters(testMap).Should().BeEquivalentTo(ct2, "no replacement, no change");

            ct3.ReplaceGenericParameters(testMap).Should().Be(SystemTypes.IntegerType);
        }

        [TestMethod]
        public void ReplaceTupleTypeGenerics()
        {
            TestEquality.FullTT.ReplaceGenericParameters(testMap).Should()
                .BeEquivalentTo(new TupleTypeSpecifier()
                {
                    element = new[]
                    {
                        new TupleElementDefinition { name = "typeParam", elementType = SystemTypes.IntegerType },
                        new TupleElementDefinition { name = "typeParam2", elementType = SystemTypes.T },
                        new TupleElementDefinition { name = "list", elementType = new ListTypeSpecifier { elementType = SystemTypes.StringType } },
                        new TupleElementDefinition { name = "interval", elementType = new IntervalTypeSpecifier { pointType = SystemTypes.BooleanType } },
                        new TupleElementDefinition { name = "interval2", elementType = new IntervalTypeSpecifier { pointType = SystemTypes.BooleanType } },
                        new TupleElementDefinition { name = "choice", elementType = new ChoiceTypeSpecifier { choice = new TypeSpecifier[] { SystemTypes.IntegerType, SystemTypes.StringType } } },
                        new TupleElementDefinition { name = "named", elementType = SystemTypes.StringType },
                    }
                })
                .And.NotBeSameAs(TestEquality.FullTT, "replacing should create a shallow copy");

            TestEquality.EmptyTT.ReplaceGenericParameters(testMap).Should().BeEquivalentTo(TestEquality.EmptyTT, "no replacement, no change");
        }
    }
}

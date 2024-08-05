using System;
using System.Collections.Generic;
using FluentAssertions;
using Hl7.Cql.Elm;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CoreTests.Elm
{
    [TestClass]
    public class TestWalker
    {
        private static readonly TupleTypeSpecifier Tt = new()
        {
            element =
            [
                new TupleElementDefinition { name = "typeParam", elementType = new ParameterTypeSpecifier { parameterName = "A" } }
            ]
        };

        private static readonly Library Lib = new()
        {
            statements =
            [
                new ExpressionDef { expression = new Literal { value = "hi", resultTypeSpecifier = Tt }, name = "Foo" }
            ]
        };

        class ResultBuilder
        {
            public List<string> Strings = new();

            public bool Visitor(object e)
            {
                if (e is string s)
                    Strings.Add(s);
                else if(e is Literal l)
                    Strings.Add($"Literal {l.value}");

                return false;
            }
        }

        [TestMethod]
        public void WalkLibraryExcludingStrings()
        {
            var result = new ResultBuilder();

            var walker = new ElmTreeWalker(result.Visitor);
            walker.Start(Lib);

            result.Strings.Should().BeEquivalentTo("Literal hi");
        }

        [TestMethod]
        public void DetectsCycles()
        {
            var add = new Add();
            var sub = new Subtract { operand = [add] };
            add.operand = [sub];

            var walker = new ElmTreeWalker(_ => false);
            Assert.ThrowsException<InvalidOperationException>(() => walker.Start(add)).Message.Should()
                  .Contain("Cycle in ELM");
        }
    }
}
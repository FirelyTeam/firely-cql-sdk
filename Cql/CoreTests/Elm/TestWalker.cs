/*
 * Copyright (c) 2025, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using Hl7.Cql.Elm;

namespace CoreTests.Elm
{
    [TestClass]
    public class TestWalker
    {
        static TupleTypeSpecifier tt = new()
        {
            element = new[]
              {
                    new TupleElementDefinition { name = "typeParam", elementType = new ParameterTypeSpecifier { parameterName = "A" } },
              }
        };

        static Library lib = new()
        {
            statements = new[]
            {
                    new ExpressionDef { expression = new Literal { value = "hi", resultTypeSpecifier = tt }, name = "Foo" }
            }
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

            public bool VisitorThatHandlesTupleElementDefinition(object e)
            {
                if (e is TupleElementDefinition)
                    return true;
                else if (e is string s)
                    Strings.Add(s);
                else if(e is Literal l)
                    Strings.Add($"Literal {l.value}");

                return false;
            }
        }

        //[TestMethod]
        //public void WalkLibraryIncludingStrings()
        //{
        //    var result = new ResultBuilder();

        //    var walker = new ElmTreeWalker(result.Visitor, null, typeof(string));
        //    walker.Walk(lib);

        //    result.Strings.Should().BeEquivalentTo("Literal hi", "hi", "A", "typeParam", "Foo");
        //}

        //[TestMethod]
        //public void WalkLibraryButDontEnterTupleElementDefinition()
        //{
        //    var result = new ResultBuilder();

        //    var walker = new ElmTreeWalker(result.VisitorThatHandlesTupleElementDefinition, null, typeof(string));
        //    walker.Walk(lib);

        //    result.Strings.Should().BeEquivalentTo("Literal hi", "hi", "Foo");
        //}

        [TestMethod]
        public void WalkLibraryExcludingStrings()
        {
            var result = new ResultBuilder();

            var walker = new ElmTreeWalker(result.Visitor);
            walker.Start(lib);

            result.Strings.Should().BeEquivalentTo("Literal hi");
        }

    }
}

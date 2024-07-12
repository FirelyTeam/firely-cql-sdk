using FluentAssertions;
using Hl7.Cql.Elm;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hl7.Cql.CqlToElm.Test
{
    [TestClass]
    public class QueryTest : Base
    {
        [ClassInitialize]
#pragma warning disable IDE0060 // Remove unused parameter
        public static void Initialize(TestContext context) => ClassInitialize();
#pragma warning restore IDE0060 // Remove unused parameter

        public void String_lengths()
        {
            var lib = CreateLibraryForExpression("from ({'hello', 'world'}) str return Length(str)");
            var query = lib.Should().BeACorrectlyInitializedLibraryWithStatementOfType<Query>();
            query.Should().HaveType(SystemTypes.IntegerType.ToListType());
        }


        [TestMethod]
        public void Sort_asc()
        {
            var lib = CreateLibraryForExpression("({4, 5, 1, 6, 2, 1}) sL sort asc");
            var query = lib.Should().BeACorrectlyInitializedLibraryWithStatementOfType<Query>();
            query.Should().HaveType(SystemTypes.IntegerType.ToListType());

        }

        [TestMethod]
        public void Scalar_source()
        {
            var lib = CreateLibraryForExpression("from (true) t return t and false");
            var query = lib.Should().BeACorrectlyInitializedLibraryWithStatementOfType<Query>();
            query.Should().HaveType(SystemTypes.BooleanType);
            query.@return.Should().HaveType(SystemTypes.BooleanType);
        }
        [TestMethod]
        public void Vector_source()
        {
            var lib = CreateLibraryForExpression("from ({ true, false }) t return t and false");
            var query = lib.Should().BeACorrectlyInitializedLibraryWithStatementOfType<Query>();
            query.Should().HaveType(SystemTypes.BooleanType.ToListType());
            query.@return.Should().HaveType(SystemTypes.BooleanType.ToListType());
        }
        [TestMethod]
        public void Relationship_with_scalar_sources()
        {
            var lib = CreateLibraryForExpression(@"
                from(true) t
                with(false) f
                such that t != f
                where t 
                return t");
            var query = lib.Should().BeACorrectlyInitializedLibraryWithStatementOfType<Query>();
        }
        [TestMethod]
        public void Relationship_with_bad_identifier()
        {
            MakeLibrary($@"
                library Test version '1.0.0'

                define f: from (true) t
                    with(false) fl
                    such that t != x
                    where t is true 
                    return t"
                , "Could not resolve identifier x in the current library.");
        }

        [TestMethod]
        public void Multi_scalar_source()
        {
            var lib = CreateLibraryForExpression(@"
                from
                    (1) Num1,
                    (2) Num2
                    return Num1 + Num2
            ");
            var query = lib.Should().BeACorrectlyInitializedLibraryWithStatementOfType<Query>();
            query.Should().HaveType(SystemTypes.IntegerType);
            query.source.Should().HaveCount(2);
            query.source[0].Should().HaveType(SystemTypes.IntegerType);
            query.source[1].Should().HaveType(SystemTypes.IntegerType);
            query.@return.Should().HaveType(SystemTypes.IntegerType);
        }

        [TestMethod]
        public void Multi_vector_source()
        {
            var lib = CreateLibraryForExpression(@"
                from
                    ( { 1, 2 } ) Num1,
                    ( { 3, 4 } ) Num2
                    return Num1 + Num2
            ");
            var query = lib.Should().BeACorrectlyInitializedLibraryWithStatementOfType<Query>();
            query.Should().HaveType(SystemTypes.IntegerType.ToListType());
            query.source.Should().HaveCount(2);
            query.source[0].Should().HaveType(SystemTypes.IntegerType.ToListType());
            query.source[1].Should().HaveType(SystemTypes.IntegerType.ToListType());
            query.@return.Should().HaveType(SystemTypes.IntegerType.ToListType());
        }

        [TestMethod]
        public void Sort_Calls_Function()
        {
            var lib = MakeLibrary(@"
                library Sort_Calls_Fluent version '1.0.0'

                define function foo(): 1

                define q: ({4, 5, 1, 6, 2, 1}) sL sort by foo() asc
            ");

            lib.GetErrors().Should().BeEmpty();
            lib.statements.Should().HaveCount(2);
            var expressions = lib.statements
                .Where(s => s.name == "q")
                .ToArray();
            expressions.Should().HaveCount(1);
            var query = expressions[0].expression.Should().BeOfType<Query>().Subject;
            query.sort.Should().NotBeNull();
            var byExpression = query.sort.by.Should().BeOfType<ByExpression[]>().Subject;
            byExpression.Should().HaveCount(1);
            var funcRef = byExpression[0].expression.Should().BeOfType<FunctionRef>().Subject;
            funcRef.name.Should().Be("foo");
            funcRef.signature.Should().NotBeNull().And.HaveCount(0);
            query.Should().HaveType(SystemTypes.IntegerType.ToListType());
        }


        [TestMethod]
        public void Sort_Calls_Fluent()
        {
            var lib = MakeLibrary(@"
                library Sort_Calls_Fluent version '1.0.0'

                define fluent function foo(i Integer): i

                define q: ({4, 5, 1, 6, 2, 1}) sL sort by foo() asc
            ");

            lib.GetErrors().Should().BeEmpty();
            lib.statements.Should().HaveCount(2);
            var expressions = lib.statements
                .Where(s => s.name == "q")
                .ToArray();
            expressions.Should().HaveCount(1);
            var query = expressions[0].expression.Should().BeOfType<Query>().Subject;
            query.sort.Should().NotBeNull();
            var byExpression = query.sort.by.Should().BeOfType<ByExpression[]>().Subject;
            byExpression.Should().HaveCount(1);
            var funcRef = byExpression[0].expression.Should().BeOfType<FunctionRef>().Subject;
            funcRef.name.Should().Be("foo");
            funcRef.signature.Should().NotBeNull().And.HaveCount(1);
            funcRef.signature[0].Should().Be(SystemTypes.IntegerType);
            query.Should().HaveType(SystemTypes.IntegerType.ToListType());

        }


        [TestMethod]
        public void Sort_Prefers_Fluent()
        {
            var lib = MakeLibrary(@"
                library Sort_Calls_Fluent version '1.0.0'

                define fluent function foo(i Integer): i
                define function foo(): 1

                define q: ({4, 5, 1, 6, 2, 1}) sL sort by foo() asc
            ");

            lib.GetErrors().Should().BeEmpty();
            lib.statements.Should().HaveCount(3);
            var expressions = lib.statements
                .Where(s => s.name == "q")
                .ToArray();
            expressions.Should().HaveCount(1);
            var query = expressions[0].expression.Should().BeOfType<Query>().Subject;
            query.sort.Should().NotBeNull();
            var byExpression = query.sort.by.Should().BeOfType<ByExpression[]>().Subject;
            byExpression.Should().HaveCount(1);
            var funcRef = byExpression[0].expression.Should().BeOfType<FunctionRef>().Subject;
            funcRef.name.Should().Be("foo");
            funcRef.signature.Should().NotBeNull().And.HaveCount(1);
            funcRef.signature[0].Should().Be(SystemTypes.IntegerType);
            query.Should().HaveType(SystemTypes.IntegerType.ToListType());

        }

        [TestMethod]
        public void Let()
        {
            var lib = MakeLibrary(@"
                library Let version '1.0.0'
                define q:
                  from
                    ( { 1, 2, 3 } ) i
                    let x: i + 1
                    where x > 0
                    return x
            ");
            var query = lib.Should().BeACorrectlyInitializedLibraryWithStatementOfType<Query>();
            query.let.Should().NotBeNull();
            query.let.Should().HaveCount(1);
            query.@return.Should().NotBeNull();
            query.@return.expression.Should().BeOfType<QueryLetRef>();
        }
        [TestMethod]
        public void Let_Redefinition()
        {
            // TODO: make this optionally fail w/ config options
            var lib = MakeLibrary(@"
                library Let version '1.0.0'
                define q:
                  from
                    ( { 1, 2, 3 } ) i
                    let x: i + 1, x: i + 2
                    where x > 0
                    return x
            ");
            //", "Identifier x is already in use in this scope.");
        }
        [TestMethod]
        public void Let_Redefine_Operand()
        {
            // TODO: make this optionally fail w/ config options

            var lib = MakeLibrary(@"
                library Let version '1.0.0'
                define function q(x Integer):
                  from
                    ( { 1, 2, 3 } ) i
                    let x: i + 1
                    where x > 0
                    return x
                ");
            //", "Identifier x is already in use in this scope.");
        }
    }
}

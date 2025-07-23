using Hl7.Cql.Elm;

namespace Hl7.Cql.CqlToElm.Test
{
    [TestClass]
    public class FlattenTest : Base
    {
        [TestMethod]
        public void FlattenEmpty()
        {
            var library = CreateCqlToolkit().MakeLibrary("""
                library ListTest version '1.0.0'

                define private FlattenEmpty: Flatten({{},{}})
                """).ShouldSucceed();
            Assert.IsNotNull(library.statements);
            Assert.AreEqual(1, library.statements.Length);
            Assert.IsNotNull(library.statements[0].expression.localId);
            Assert.IsNotNull(library.statements[0].expression.locator);
            Assert.IsInstanceOfType(library.statements[0].expression, typeof(Flatten));
            {
                var flatten = (Flatten)library.statements[0].expression;
            }
        }

        [TestMethod]
        public void FlattenCapitalF()
        {
            var library = CreateCqlToolkit().MakeLibrary("""
                library ListTest version '1.0.0'

                define private FlattenEmpty: Flatten({{},{}})
                """);
        }

        [TestMethod]
        public void FlattenListNullAndNull()
        {
            var lib = CreateCqlToolkit().MakeLibraryFromExpression("Flatten({{null}, {null}})");
            var flatten = lib.Should().BeACorrectlyInitializedLibraryWithStatementOfType<Flatten>();
            var result = Run<List<object>>(flatten, lib); // {null, null}
            result!.Count.Should().Be(2);
            var equal = CreateCqlToolkit().MakeLibraryFromExpression("Flatten({{null}, {null}}) = {null, null}")
                                      .Should().BeACorrectlyInitializedLibraryWithStatementOfType<Equal>();
            var eqr = Run<bool?>(equal, lib); // {null, null}
            eqr.Should().BeTrue();
        }
        [TestMethod]
        public void FlattenListOfValueSet()
        {
            var library = CreateCqlToolkit().MakeLibrary("""
                library FlattenValueSets version '1.0.0'

                valueset "One": 'https://hl7.org/one'
                valueset "Two": 'https://hl7.org/two'

                define f: Flatten({"One", "Two"})
                """);
            var flatten = library.Should()
                .BeACorrectlyInitializedLibraryWithStatementOfType<Flatten>();
            flatten.Should().HaveType(SystemTypes.CodeType.ToListType());
        }

        [TestMethod]
        public void FlattenChoiceType()
        {
            var library = CreateCqlToolkit().MakeLibrary("""
                library ListTest version '1.0.0'

                define choice:
                  if ( day from Today() mod 2 = 0 ) then 'hello' 
                    else 1

                define private f:
                  flatten ( { { choice }, { choice } } )
                """);
            var choiceType = library.statements[0].expression.resultTypeSpecifier;
            choiceType.Should().BeOfType<ChoiceTypeSpecifier>();
            var flatten = library.statements[1].expression.Should().BeOfType<Flatten>().Subject;
            flatten.Should().HaveType(choiceType.ToListType());
        }

        [TestMethod]
        public void FlattenMixedChoiceType()
        {
            // requires list promotion
            var cqlToolkit = CreateCqlToolkit();
            var library = cqlToolkit.MakeLibrary( """
                library Test version '1.0.0'

                using FHIR version '4.0.1'

                define g:
                  flatten ( null as List<Choice<System.Boolean, List<FHIR.Claim>>>)
                """, "Could not resolve call to operator Flatten with signature (List<Choice<Boolean, List<{http://hl7.org/fhir}Claim>>>).");

            // no errors
            cqlToolkit = CreateCqlToolkit(DisableListPromotion:false);
            library = cqlToolkit.MakeLibrary("""
                library Test version '1.0.0'

                using FHIR version '4.0.1'

                define g:
                  flatten ( null as List<Choice<System.Boolean, List<FHIR.Claim>>>)
                """);
        }

    }
}

/*
 * Copyright (c) 2025, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using System.Xml;
using Hl7.Cql.Elm;

namespace Hl7.Cql.CqlToElm.Test
{
    [TestClass]
    public class CrossLibraryTest : Base
    {
        [TestMethod]
        public void ExpressionRef_Across_Library()
        {
            var cqlToolkit = CreateCqlToolkit();

            var foo = cqlToolkit.MakeLibrary("""
                                         library Foo version '1.0.0'

                                         define F: 'foo'
                                         """);
            foo.Should().BeACorrectlyInitializedLibraryWithStatementOfType<Literal>();

            var bar = cqlToolkit.MakeLibrary("""
                                         library Bar version '1.0.0'

                                         include Foo version '1.0.0' called foo

                                         define G: foo.F
                                         """);
            bar.Should().BeACorrectlyInitializedLibraryWithStatementOfType<ExpressionRef>();
        }

        [TestMethod]
        public void ExpressionRef_Across_Library_NotFound()
        {
            var cqlToolkit = CreateCqlToolkit();
            var foo = cqlToolkit.MakeLibrary("""
                                         library Foo version '1.0.0'

                                         define F: 'foo'
                                         """);
            foo.Should().BeACorrectlyInitializedLibraryWithStatementOfType<Literal>();

            cqlToolkit.MakeLibrary("""
                               library Bar version '1.0.0'

                               include Foo version '1.0.0' called foo

                               define G: foo.DoesNotExist
                               """,
                               "Could not resolve identifier DoesNotExist in library Foo.");
        }

        [TestMethod]
        public void FunctionRef_Across_Library()
        {
            var cqlToolkit = CreateCqlToolkit();
            var foo = cqlToolkit.MakeLibrary("""
                                         library Foo version '1.0.0'

                                         define function Foo(): 'foo'
                                         """);
            foo.Should().BeACorrectlyInitializedLibraryWithStatementOfType<Literal>();

            var bar = cqlToolkit.MakeLibrary("""
                                         library Bar version '1.0.0'

                                         include Foo version '1.0.0' called foo

                                         define G: foo.Foo()
                                         """);
            bar.Should().BeACorrectlyInitializedLibraryWithStatementOfType<FunctionRef>();
        }


        [TestMethod]
        public void FunctionRef_Across_Library_NotFound()
        {
            var cqlToolkit = CreateCqlToolkit();
            var foo = cqlToolkit.MakeLibrary("""
                                         library Foo version '1.0.0'

                                         define function Foo(): 'foo'
                                         """);
            foo.Should().BeACorrectlyInitializedLibraryWithStatementOfType<Literal>();

            cqlToolkit.MakeLibrary("""
                               library Bar version '1.0.0'

                               include Foo version '1.0.0' called foo

                               define G: foo.DoesNotExist()
                               """,
                               "Could not resolve call to operator DoesNotExist with signature ().");
        }

        [TestMethod]
        public void FunctionRef_Across_Library_HasLibraryName()
        {
            var cqlToolkit = CreateCqlToolkit();
            var foo = cqlToolkit.MakeLibrary("""
                                         library Foo version '1.0.0'

                                         define function Foo(): 'foo'
                                         """);
            foo.Should().BeACorrectlyInitializedLibraryWithStatementOfType<Literal>();

            var bar = cqlToolkit.MakeLibrary("""
                                         library Bar version '1.0.0'

                                         include Foo version '1.0.0' called foo

                                         define G: foo.Foo()
                                         """);
            var funcRef = bar.Should().BeACorrectlyInitializedLibraryWithStatementOfType<FunctionRef>();
            funcRef.libraryName.Should().Be("foo");
        }

        [TestMethod]
        public void FunctionRef_Across_Library_Overloaded_HasLibraryName()
        {
            var cqlToolkit = CreateCqlToolkit();
            var foo = cqlToolkit.MakeLibrary("""
                                         library Foo version '1.0.0'

                                         define function MyFunc(a Integer): a * 2
                                         define function MyFunc(a String): a + a
                                         """);
            foo.GetErrors().Should().BeEmpty();

            var bar = cqlToolkit.MakeLibrary("""
                                         library Bar version '1.0.0'

                                         include Foo version '1.0.0' called foo

                                         define G: foo.MyFunc(3)
                                         """);
            var funcRef = bar.Should().BeACorrectlyInitializedLibraryWithStatementOfType<FunctionRef>();
            funcRef.libraryName.Should().Be("foo");
        }

        private const string IncludedFhirLibrary = """
                                                   library A version '1.0.0'
                                                   using FHIR version '4.0.1'
                                                   valueset "VS": 'http://example.org/vs'
                                                   define "Encs": [Encounter]
                                                   define "First Enc": First([Encounter])
                                                   """;

        private static Library MakeLibraryIncludingA(string definitions, params string[] expectedErrors)
        {
            var cqlToolkit = CreateCqlToolkit();
            cqlToolkit.MakeLibrary(IncludedFhirLibrary);
            return cqlToolkit.MakeLibrary($"""
                                           library B version '1.0.0'
                                           using FHIR version '4.0.1'
                                           include A version '1.0.0' called A
                                           {definitions}
                                           """,
                                           expectedErrors);
        }

        private static NamedTypeSpecifier Fhir(string name) => new XmlQualifiedName($"{{http://hl7.org/fhir}}{name}").ToNamedType();

        [TestMethod]
        public void ExpressionRef_Across_Library_AsQuerySource()
        {
            var b = MakeLibraryIncludingA("""define "FromQualifiedSource": A."Encs" E return E.id""");

            var query = b.Should().BeACorrectlyInitializedLibraryWithStatementOfType<Query>();
            var source = query.source.Should().ContainSingle().Subject;
            var expressionRef = source.expression.Should().BeOfType<ExpressionRef>().Subject;
            expressionRef.name.Should().Be("Encs");
            expressionRef.libraryName.Should().Be("A");
            expressionRef.resultTypeSpecifier.Should().Be(Fhir("Encounter").ToListType());
            query.resultTypeSpecifier.Should().Be(Fhir("id").ToListType());
        }

        [TestMethod]
        public void ValueSetRef_Across_Library_AsRetrieveTerminology()
        {
            var b = MakeLibraryIncludingA("""define "FromQualifiedTerminology": [Condition: A."VS"]""");

            var retrieve = b.Should().BeACorrectlyInitializedLibraryWithStatementOfType<Retrieve>();
            var valueSetRef = retrieve.codes.Should().BeOfType<ValueSetRef>().Subject;
            valueSetRef.name.Should().Be("VS");
            valueSetRef.libraryName.Should().Be("A");
            valueSetRef.resultTypeSpecifier.Should().Be(SystemTypes.ValueSetType);
            retrieve.codeProperty.Should().Be("code");
            retrieve.codeComparator.Should().Be("in");
        }

        [TestMethod]
        public void ExpressionRef_Across_Library_AsExpression()
        {
            var b = MakeLibraryIncludingA("""define "FromExpression": A."Encs" """);

            var expressionRef = b.Should().BeACorrectlyInitializedLibraryWithStatementOfType<ExpressionRef>();
            expressionRef.name.Should().Be("Encs");
            expressionRef.libraryName.Should().Be("A");
            expressionRef.resultTypeSpecifier.Should().Be(Fhir("Encounter").ToListType());
        }

        [TestMethod]
        public void ExpressionRef_Across_Library_AsRetrieveContext()
        {
            var cqlToolkit = CreateCqlToolkit();
            cqlToolkit.MakeLibrary("""
                                   library A version '1.0.0'
                                   using FHIR version '4.0.1'
                                   context Patient
                                   define "Mother": singleton from ([RelatedPerson])
                                   """);

            var b = cqlToolkit.MakeLibrary("""
                                           library B version '1.0.0'
                                           using FHIR version '4.0.1'
                                           include A version '1.0.0' called A
                                           context Patient
                                           define "Mother Observations": [A."Mother" -> Observation]
                                           """);

            var retrieve = (Retrieve)b.statements.Single(statement => statement.name == "Mother Observations").expression;
            var contextRef = retrieve.context.Should().BeOfType<ExpressionRef>().Subject;
            contextRef.name.Should().Be("Mother");
            contextRef.libraryName.Should().Be("A");
            contextRef.resultTypeSpecifier.Should().Be(Fhir("RelatedPerson"));
        }

        [TestMethod]
        public void Property_Of_ExpressionRef_Across_Library_AsQuerySource()
        {
            var b = MakeLibraryIncludingA("""define "FromQualifiedMember": A."First Enc".type T return T""");

            var query = b.Should().BeACorrectlyInitializedLibraryWithStatementOfType<Query>();
            var property = query.source.Should().ContainSingle().Which.expression.Should().BeOfType<Property>().Subject;
            property.path.Should().Be("type");
            property.resultTypeSpecifier.Should().Be(Fhir("CodeableConcept").ToListType());
            var expressionRef = property.source.Should().BeOfType<ExpressionRef>().Subject;
            expressionRef.name.Should().Be("First Enc");
            expressionRef.libraryName.Should().Be("A");
        }

        [TestMethod]
        public void ExpressionRef_Across_Library_AsQuerySource_NotFound()
        {
            MakeLibraryIncludingA("""define "Missing": A."DoesNotExist" E return E""",
                                  "Could not resolve identifier DoesNotExist in library A.");
        }

        [TestMethod]
        public void IncludedLibrary_AsQuerySource_IsReportedAsALibrary()
        {
            MakeLibraryIncludingA("""define "LibraryAsSource": A E return E""",
                                  "Identifier A is a library and cannot be used as an expression.");
        }

        [TestMethod]
        public void IncludedLibrary_AsRetrieveTerminology_IsReportedAsALibrary()
        {
            MakeLibraryIncludingA("""define "LibraryAsTerminology": [Condition: A]""",
                                  "Identifier A is a library and cannot be used as an expression.");
        }
    }
}

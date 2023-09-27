using FluentAssertions;
using FluentAssertions.Primitives;
using Hl7.Cql.Elm;

namespace Hl7.Cql.CqlToElm.Test
{
    public static class FluentTestExtensions
    {
        public static T BeACorrectlyInitializedLibraryWithStatementOfType<T>(this ObjectAssertions l)
        {
            var library = l.Subject.Should().BeOfType<Library>().Subject;
            library.statements.Should().HaveCount(1);
            library.statements[0].expression.localId.Should().NotBeNull();
            library.statements[0].expression.locator.Should().NotBeNull();

            return library.statements[0].expression.Should().BeOfType<T>().Subject;
        }


        public static void BeLiteralString(this ObjectAssertions l, string value)
        {
            var literal = l.Subject.Should().BeOfType<Literal>().Subject;
            literal.value.Should().Be(value);
            literal.resultTypeName.Should().BeEquivalentTo(new System.Xml.XmlQualifiedName("{urn:hl7-org:elm-types:r1}String"));
        }

        public static void BeLiteralBool(this ObjectAssertions l, bool b)
        {
            var literal = l.Subject.Should().BeOfType<Literal>().Subject;
            literal.value.Should().Be(b.ToString().ToLower());
            literal.resultTypeName.Should().BeEquivalentTo(new System.Xml.XmlQualifiedName("{urn:hl7-org:elm-types:r1}Boolean"));
        }

        public static void BeLiteralInteger(this ObjectAssertions l, int i)
        {
            var literal = l.Subject.Should().BeOfType<Literal>().Subject;
            literal.value.Should().Be(i.ToString());
            literal.resultTypeName.Should().BeEquivalentTo(new System.Xml.XmlQualifiedName("{urn:hl7-org:elm-types:r1}Integer"));
        }

        public static void BeNullLiteral(this ObjectAssertions l)
        {
            var literal = l.Subject.Should().BeOfType<Null>().Subject;
            literal.resultTypeName.Should().BeEquivalentTo(new System.Xml.XmlQualifiedName("{urn:hl7-org:elm-types:r1}Any"));
        }
    }
}

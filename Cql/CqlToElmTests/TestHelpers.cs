using FluentAssertions;
using FluentAssertions.Primitives;
using Hl7.Cql.Elm;
using System.Globalization;
using System.Linq;

namespace Hl7.Cql.CqlToElm.Test
{
    public static class TestHelpers
    {
        public static T ShouldDefine<T>(this Library l, string name) where T : IDefinitionElement
        {
            var f = l.statements.Should().Contain(s => s.name == name).Which.Should().BeOfType<T>().Subject;
            f.Name.Should().Be(name);

            return f;
        }


        public static T BeACorrectlyInitializedLibraryWithStatementOfType<T>(this ObjectAssertions l,
            bool requireLocalId = true)
        {
            var library = l.Subject.Should().BeOfType<Library>().Subject;
            library.statements.Should().HaveCount(1);
            if (requireLocalId)
                library.statements[0].expression.localId.Should().NotBeNull();
            library.statements[0].expression.locator.Should().NotBeNull();

            return library.statements[0].expression.Should().BeOfType<T>().Subject;
        }


        public static void BeLiteralString(this ObjectAssertions l, string value)
        {
            var literal = l.Subject.Should().BeOfType<Literal>().Subject;
            literal.value.Should().Be(value);
            literal.resultTypeSpecifier.Should().Be(SystemTypes.StringType);
        }

        public static void BeLiteralBool(this ObjectAssertions l, bool b)
        {
            var literal = l.Subject.Should().BeOfType<Literal>().Subject;
            literal.value.Should().Be(b.ToString().ToLower());
            literal.resultTypeSpecifier.Should().Be(SystemTypes.BooleanType);
        }

        public static void BeNullAs(this ObjectAssertions l, TypeSpecifier type)
        {
            var @as = l.Subject.Should().BeOfType<As>().Subject;
            @as.asTypeSpecifier.Should().Be(type);
            @as.resultTypeSpecifier.Should().Be(type);
            if (type is NamedTypeSpecifier nts)
            {
                @as.asType.Should().Be(nts.name);
                @as.resultTypeName.Should().Be(nts.name);
            }

        }

        public static void BeLiteralInteger(this ObjectAssertions l, int i)
        {
            var literal = l.Subject.Should().BeOfType<Literal>().Subject;
            literal.value.Should().Be(i.ToString());
            literal.resultTypeSpecifier.Should().Be(SystemTypes.IntegerType);
        }

        public static void BeLiteralDecimal(this ObjectAssertions l, decimal d)
        {
            var literal = l.Subject.Should().BeOfType<Literal>().Subject;
            literal.value.Should().Be(d.ToString(CultureInfo.InvariantCulture));
            literal.resultTypeSpecifier.Should().Be(SystemTypes.DecimalType);
        }

        public static void BeNullLiteral(this ObjectAssertions l)
        {
            var literal = l.Subject.Should().BeOfType<Null>().Subject;
            literal.resultTypeSpecifier.Should().Be(SystemTypes.AnyType);
        }

        public static void HaveType(this ObjectAssertions l, TypeSpecifier type)
        {
            if (l.Subject is Expression subject)
            {
                subject.resultTypeSpecifier.Should().Be(type);
                if (type is NamedTypeSpecifier nts)
                {
                    subject.resultTypeName.Should().Be(nts.name);
                }
            }
            else Microsoft.VisualStudio.TestTools.UnitTesting.Assert.Fail("Subject is not an Expression");
        }

        public static T ShouldReportError<T>(this T e, params string[] errorTexts) where T : Element
        {
            var errors = e.GetErrors();

            errors.Should().NotBeEmpty();
            errors.Should().HaveCount(errorTexts.Length);

            for (var ix = 0; ix < errors.Length; ix++)
                errors[ix].message.Should().Match(errorTexts[ix]);

            return e;
        }

        public static T ShouldSucceed<T>(this T e) where T : Element
        {
            e.GetErrors().Where(e => e.errorSeverity == ErrorSeverity.error).Should().BeEmpty();
            return e;
        }

        public static void BeNamedType(this ObjectAssertions l, string typeName)
        {
            l.Subject.Should().NotBeNull();
            l.Subject.Should().BeOfType<NamedTypeSpecifier>();
            var nts = (NamedTypeSpecifier)l.Subject;
            nts.name.Should().NotBeNull();
            nts.name.Should().Be(typeName);
        }
    }
}

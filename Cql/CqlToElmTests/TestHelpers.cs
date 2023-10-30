using FluentAssertions;
using Hl7.Cql.Elm;
using System.Linq;

namespace Hl7.Cql.CqlToElm.Test
{
    public static class TestHelpers
    {
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
    }
}

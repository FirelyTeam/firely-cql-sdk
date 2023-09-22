using Antlr4.Runtime;
using Antlr4.Runtime.Tree;
using Hl7.Cql.Elm;
using System.Globalization;
using System.Runtime.Serialization;
using System.Xml;

namespace Hl7.Cql.CqlToElm
{
    internal static class Extensions
    {
        private static readonly ObjectIDGenerator _idGenerator = new ObjectIDGenerator();

        public static string NextId(object context) => _idGenerator.GetId(context, out _)
                .ToString(CultureInfo.InvariantCulture);

        public static string Locator(this ParserRuleContext ctx) =>
            $"{ctx.Start.Line}:{ctx.Start.Column}-{ctx.Stop.Line}:{ctx.Stop.Column}";

        public static string? Locator(this IParseTree pt)
        {
            if (pt is ParserRuleContext ctx)
                return $"{ctx.Start.Line}:{ctx.Start.Column}-{ctx.Stop.Line}:{ctx.Stop.Column}";
            return null;
        }

        public static T WithLocator<T>(this T t, ParserRuleContext context) where T : Element
        {
            return t.WithLocator<T>(context.Locator());
        }

        public static T WithLocator<T>(this T t, string locator) where T : Element
        {
            t.localId = NextId(t);
            t.locator = locator;

            return t;
        }

        public static T WithNamedType<T>(this T t, string type) where T : Element
        {
            var qualifiedName = new XmlQualifiedName(type);
            t.resultTypeName = qualifiedName;
            t.resultTypeSpecifier = new NamedTypeSpecifier
            {
                name = qualifiedName
            };

            return t;
        }

        public static Expression CastNull(this Expression t, string typename)
        {
            if (t is not Null) return t;

            var xmlTypeName = new XmlQualifiedName(typename);
            return new As
            {
                operand = t,
                asType = xmlTypeName,
                asTypeSpecifier = new NamedTypeSpecifier() { name = xmlTypeName },
            }.WithLocator(t.locator).WithNamedType(typename);
        }
    }

}

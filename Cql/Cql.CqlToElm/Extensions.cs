using Antlr4.Runtime;
using Antlr4.Runtime.Tree;
using Hl7.Cql.Elm;
using System;
using System.Globalization;
using System.Runtime.Serialization;
using System.Xml;

namespace Hl7.Cql.CqlToElm
{
    internal static class Extensions
    {
        private static readonly ObjectIDGenerator _idGenerator = new();

        public static string NextId(object context) => _idGenerator.GetId(context, out _)
                .ToString(CultureInfo.InvariantCulture);

        public static string NextId() => NextId(Random.Shared.Next());

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

        public static T WithResultType<T>(this T t, XmlQualifiedName qualifiedName) where T : Element
        {
            t.resultTypeName = qualifiedName;
            t.resultTypeSpecifier = qualifiedName.ToNamedType();
            return t;
        }

        public static T WithResultType<T>(this T t, TypeSpecifier type) where T : Element
        {
            t.resultTypeSpecifier = type;
            return t;
        }

        public static Expression CastNull(this Expression t, XmlQualifiedName qualifiedName)
        {
            if (t is not Null) return t;

            return new As
            {
                operand = t,
                asType = qualifiedName,
                asTypeSpecifier = qualifiedName.ToNamedType(),
            }.WithLocator(t.locator).WithResultType(qualifiedName);
        }

        public static Expression CastNull(this Expression t, TypeSpecifier type)
        {
            if (t is not Null) return t;

            return new As
            {
                operand = t,
                asTypeSpecifier = type,
            }.WithLocator(t.locator).WithResultType(type);
        }

        public static NamedTypeSpecifier ToNamedType(this XmlQualifiedName qname) =>
            new() { name = qname };

        public static ListTypeSpecifier ToListType(this TypeSpecifier name) =>
            new() { elementType = name };

    }

}

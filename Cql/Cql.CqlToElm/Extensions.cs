using Antlr4.Runtime;
using Antlr4.Runtime.Tree;
using Hl7.Cql.Elm;
using System;
using System.Globalization;
using System.Runtime.Serialization;

namespace Hl7.Cql.CqlToElm
{
    internal static class Extensions
    {
        private static readonly ObjectIDGenerator _idGenerator = new();

        public static string NextId(object context) => _idGenerator.GetId(context, out _)
                .ToString(CultureInfo.InvariantCulture);

        private static readonly Random Random = new Random();

        public static string NextId()
        {
            lock (Random) 
            {
                var next = Random.Next();
                var id = NextId(next);
                return id;
            }
        }

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

        public static T WithResultType<T>(this T t, TypeSpecifier type) where T : Element
        {
            t.resultTypeSpecifier = type;

            if (type is NamedTypeSpecifier nts)
                t.resultTypeName = nts.name;

            return t;
        }
    }
}

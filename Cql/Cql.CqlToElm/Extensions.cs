using Antlr4.Runtime;
using Antlr4.Runtime.Tree;
using Hl7.Cql.Elm;
using System;
using System.Globalization;
using System.Runtime.Serialization;
using System.Xml;

namespace Hl7.Cql.CqlToElm
{
    /// <summary>
    /// This class is a bit of a hack, but most of the time that I need to pass in a ParserRuleContext,
    /// it's just for getting the locator. In some cases, however, I already have a locator, but not the
    /// original ParserRuleContext. This class allows me to pass in an existing locator without having to create
    /// several overloads taking either a ParserRuleContext or a string.
    /// </summary>
    internal class StringLocatorRuleContext : ParserRuleContext
    {
        public StringLocatorRuleContext(string locator) => Locator = locator;

        public string Locator { get; }
    }

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

        public static string Locator(this ParserRuleContext context)
        {
            return context switch
            {
                StringLocatorRuleContext jlr => jlr.Locator,
                _ => $"{context.Start.Line}:{context.Start.Column}-{context.Stop.Line}:{context.Stop.Column}"
            };
        }

        public static string? Locator(this IParseTree pt) => pt is ParserRuleContext ctx ? ctx.Locator() : null;

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

        public static XmlQualifiedName? TryToQualifiedName(this TypeSpecifier type)
        {
            if (type is NamedTypeSpecifier nts)
                return nts.name;
            else
                return null;
        }
    }
}

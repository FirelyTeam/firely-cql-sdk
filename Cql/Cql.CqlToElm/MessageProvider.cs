using Hl7.Cql.Elm;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hl7.Cql.CqlToElm
{
    /// <summary>
    /// Provides localized error messages.
    /// </summary>
    internal class MessageProvider
    {
        internal MessageProvider(CultureInfo culture)
        {
            Culture = culture;
        }

        public CultureInfo Culture { get; }

        public string TypeCannotBeCast(TypeSpecifier from, TypeSpecifier to) =>
            string.Format(Culture, Messages.TypeCannotBeCast, from, to);
        public string TypeFoundIsNotExpected(TypeSpecifier from, TypeSpecifier to) =>
            string.Format(Culture, Messages.TypeFoundIsNotExpected, from, to);
    
    }
}

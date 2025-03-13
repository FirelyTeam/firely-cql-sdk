using Hl7.Cql.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hl7.Cql.CqlToElm2.Symbols;
/// <summary>
/// Defines the type of untyped null expressions.
/// </summary>
internal class NullTypeSymbol : TypeSymbol
{
    private readonly static TypeDefinition NullTypeDefinition = new SimpleTypeDefinition("Null",
        new ModelDefinition(string.Empty, string.Empty, string.Empty), AccessModifier.Public);

    public static readonly NullTypeSymbol Default = new();

    private NullTypeSymbol() : base(NullTypeDefinition)
    {
    }
}

using Hl7.Cql.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Hl7.Cql.CqlToElm2.Symbols;
internal class TypeSymbol : Symbol
{
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private static string FormatName(TypeDefinition typeDefinition) => typeDefinition.Name;        

    public TypeSymbol(TypeDefinition typeDefinition) : base(FormatName(typeDefinition))
    {
        TypeDefinition = typeDefinition;
    }

    public override AccessModifier AccessModifier => AccessModifier.Public;

    public TypeDefinition TypeDefinition { get; }

    public override SymbolType SymbolType => SymbolType.Type;

    public override TypeSymbol Type => this;
}

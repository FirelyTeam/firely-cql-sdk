using Hl7.Cql.Model;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Hl7.Cql.CqlToElm2.Symbols;
[DebuggerDisplay("{TypeDefinition.ToString()}")]
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

    public override bool Equals(object? obj) =>
        obj switch
        {
            TypeSymbol symbol => TypeDefinition == symbol.TypeDefinition,
            _ => false
        };

    public override int GetHashCode() => HashCode.Combine(typeof(TypeSymbol), TypeDefinition);

    public override string ToString() => TypeDefinition?.ToString() ?? string.Empty;

}


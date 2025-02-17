using Hl7.Cql.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hl7.Cql.CqlToElm2.Symbols;
internal class ModelSymbol : Symbol, IHasSymbols
{
    public ModelSymbol(Model.ModelDefinition model, string name) : base(name)
    {
        Model = model;
        Type = new TypeSymbol(new ModelTypeDefinition(model));
        Symbols = new SymbolTable(model.Uri);
        foreach(var kvp in model.TypeDefinitions)
            Symbols.AddSymbol(new TypeSymbol(kvp.Value));
    }

    public override AccessModifier AccessModifier => AccessModifier.Public;

    public override SymbolType SymbolType => SymbolType.Model;

    public Model.ModelDefinition Model { get; }

    public SymbolTable Symbols { get; }

    public override TypeSymbol Type { get; }
}

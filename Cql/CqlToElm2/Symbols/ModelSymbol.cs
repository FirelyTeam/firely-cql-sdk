using Hl7.Cql.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hl7.Cql.CqlToElm2.Symbols;
internal class ModelSymbol : SymbolContainer
{
    public ModelSymbol(Model.ModelDefinition model, string name, SymbolTable symbols) : base(name,symbols)
    {
        Model = model;
        Type = new TypeSymbol(new ModelTypeDefinition(model));
    }

    public ModelSymbol Alias(string name) => new ModelSymbol(Model, name, Symbols);

    public override AccessModifier AccessModifier => AccessModifier.Public;

    public override SymbolType SymbolType => SymbolType.Model;

    public Model.ModelDefinition Model { get; }

    public override TypeSymbol Type { get; }
}

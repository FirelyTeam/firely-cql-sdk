using Hl7.Cql.Elm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hl7.Cql.CqlToElm;
internal class ContextDefinitionSymbol : IDefinitionElement
{
    public ContextDefinitionSymbol(Model.ContextDefinition context)
    {
        Context = context;
    }

    public AccessModifier Access => AccessModifier.Public;

    public string Name => Context.Name;

    public Model.ContextDefinition Context { get; }

    public IDefinitionElement AddError(CqlToElmError error) => throw new NotSupportedException();

    public Expression ToRef(string? libraryName) => throw new NotSupportedException();
}

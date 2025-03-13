using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hl7.Cql.Model;
[DebuggerDisplay("{Name}")]
internal class GenericArgumentType : TypeDefinition
{
    public GenericArgumentType(string name): base(name, null, AccessModifier.Public)
    {
    }

    public GenericArgumentSpecifier Specify() => new GenericArgumentSpecifier(Name);

    public override TypeSpecifier ToTypeSpecifier() => Specify();
}

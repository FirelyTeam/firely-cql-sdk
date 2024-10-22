using Hl7.Cql.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hl7.Cql.CqlToElm
{
    internal static class TypeBridge
    {
        public static Model.TypeSpecifier ToModelSpecifier(this Elm.TypeSpecifier elmSpecifier, IModelProvider provider)
        {
            throw new NotImplementedException();
        }

        public static Elm.TypeSpecifier ToElmSpecifier(this Model.TypeSpecifier modelSpecifier)
        {
            throw new NotImplementedException();
        }
    }
}

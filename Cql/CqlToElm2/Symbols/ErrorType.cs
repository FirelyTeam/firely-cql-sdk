using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hl7.Cql.CqlToElm2.Symbols;
internal enum ErrorType
{
    None,
    ModelNotFound,
    LibraryNotFound,
    SymbolRedefinition,
    CodeSystemNotFound,
    CodeNotFound,
    LiteralTypeNotFound,
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hl7.Cql.CqlToElm2.Visitors;

internal enum ErrorType
{
    None,
    ModelNotFound,
    LibraryNotFound,
    SymbolRedefinition,
    CodeSystemNotFound,
    CodeNotFound,
    LiteralTypeNotFound,
    InvalidTypeSpecifier,
    NoSuitableConditionalReturnType,
    DecimalTooLarge,
    MantissaTooLarge,
    UnparseableInteger,
    UnparseableDecimal,
    FunctionNotFound,
    NoSuitableFunctionSignature,
    AmbiguousFunctionSignature,
    UnresolvedIdentifier,
    InvalidCodeComparator,
    AmbiguousTypeSpecifier,
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hl7.Cql.CqlToElm2.Coercion;
internal enum CoercionCost : int
{
    /// <summary>
    /// Exact match – If the invocation type is an exact match to the declared type of the argument
    /// </summary>
    ExactMatch,
    /// <summary>
    /// Subtype – If the invocation type is a subtype of the declared type of the argument
    /// </summary>
    Subtype,
    /// <summary>
    /// Compatible – If the invocation type is compatible with the declared type of the argument (e.g., the invocation type is Any)
    /// </summary>
    /// <remarks>
    /// Converting to a non-generic type is considered less costly.
    /// </remarks>
    FromNull,
    /// <summary>
    /// Compatible – If the invocation type is compatible with the declared type of the argument (e.g., the invocation type is Any)
    /// </summary>
    FromNullToGeneric,
    /// <summary>
    /// Cast - If the invocation type can be cast to the declare type (e.g., the invocation type is a choice that includes the declared type)
    /// </summary>
    Cast,
    /// <summary>
    /// Implicit Conversion To Simple Type – An implicit conversion is defined from the invocation type of the argument to the declared type of the argument, and the declared type is a simple type
    /// </summary>
    /// <remarks>
    /// We call simple types "literal types" in this SDK
    /// </remarks>
    ImplicitToLiteralType,
    /// <summary>
    /// An implicit conversion is defined from the invocation type of the argument to the declared type of the argument, and the declared type is a class type
    /// </summary>
    ImplicitToClassType,


    /// <summary>
    /// The declared type is an interval and the invocation type can be promoted to an interval of that type
    /// </summary>
    IntervalPromotion,
    /// <summary>
    /// The invocation type of the argument is a list and can be demoted to the declared type
    /// </summary>
    ListDemotion,
    /// <summary>
    /// The invocation type of the argument is an interval and can be demoted to the declared type
    /// </summary>
    IntervalDemotion,
    /// <summary>
    /// The declared type is a list and the invocation type can be promoted to a list of that type
    /// </summary>
    ListPromotion,


    /// <summary>
    /// It is not possible to coerce the invocation type to the declared type
    /// </summary>
    Incompatible = 1000,
}
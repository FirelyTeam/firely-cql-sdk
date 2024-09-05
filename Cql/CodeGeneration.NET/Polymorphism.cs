using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hl7.Cql.CodeGeneration.NET;
/// <summary>
/// The polymorphism type of a top-level function.
/// </summary>
public enum Polymorphism
{
    /// <summary>
    /// A regular function that is neither virtual nor abstract.
    /// </summary>
    None,
    /// <summary>
    /// An abstract function.
    /// </summary>
    Abstract,
    /// <summary>
    /// A virtual function.
    /// </summary>
    Virtual
};
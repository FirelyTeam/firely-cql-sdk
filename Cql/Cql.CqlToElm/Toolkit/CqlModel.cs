using Hl7.Cql.Model;

namespace Hl7.Cql.CqlToElm.Toolkit;

/// <summary>
/// Represents the model of CQL to use.
/// </summary>
public enum CqlModel
{
    /// <summary>
    /// Represents the ELM R1 model which maps to <seealso cref="Models.ElmR1"/>
    /// </summary>
    ElmR1 = 1,

    /// <summary>
    /// Represents the FHIR 4.0.1 model which maps to <seealso cref="Models.Fhir401"/>
    /// </summary>
    Fhir401 = 2,
}
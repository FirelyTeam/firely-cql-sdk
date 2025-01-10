using Hl7.Cql.Model;

namespace CqlSdkPrototype.Cql;

// Options for configuring the Cql services.
// CONSIDERATION: This should be moved to CqlApiOptions
public class CqlServicesOptions
{
    public ModelInfo[] Models { get; set; } = [];
}
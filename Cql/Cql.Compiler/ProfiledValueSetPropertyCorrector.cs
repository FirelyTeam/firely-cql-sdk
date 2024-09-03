using Hl7.Cql.Elm;

namespace Hl7.Cql.Compiler;

/// <summary>
/// When the Java stack turns access to a bound element in profiled QICore into ELM, it doesn't set the resultType
/// for the `value` property correctly. This property should be of type `string`, but it is set to to the type that
/// represents the bound valueset instead. This walker puts the right types in place, as if the ELM had been generated
/// from unprofiled FHIR in the first place.
/// </summary>
internal class ProfiledValueSetPropertyCorrector : BaseElmTreeWalker
{
    protected override bool Process(object node)
    {
        // Correct this for the valueset UnitsOfTime, the only place where this causes problems in the current
        // set of CMS measures. We cannot fix this in general though, and will need to report this to Bryn Rhodes
        // so he can correct the Java stack to handle this better.
        // Issue https://github.com/FirelyTeam/firely-cql-sdk/issues/502 should be resolved before we can remove this.
        if (node is Property { path: "value", source: Property { path: "periodUnit" } puProp  } valueProp )
        {
            valueProp.WithResultType(SystemTypes.StringType);
            puProp.WithResultType(new NamedTypeSpecifier("http://hl7.org/fhir", "UnitsOfTime"));
        }

        return false;
    }
}
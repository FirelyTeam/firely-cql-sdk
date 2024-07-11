/*
 * Copyright (c) 2024, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using Hl7.Cql.Elm;
using Hl7.Fhir.Model;
using Expression = Hl7.Cql.Elm.Expression;
using Library = Hl7.Cql.Elm.Library;

namespace Hl7.Cql.Packaging;

/// <summary>
/// Analyzes the ELM to extract a FHIR DataRequirements instance representing the
/// data requirements of the ELM as expressed in the Retrieve statements.
/// </summary>
/// <remarks>
/// We're just focusing on getting the basics for now, which is just the list of
/// Resources used by the retrieves. There's much more to it, as can be glanced
/// from the public Java version here: https://github.com/cqframework/clinical_quality_language/blob/master/Src/java/elm-fhir/src/main/java/org/cqframework/cql/elm/requirements/fhir/DataRequirementsProcessor.java
/// </remarks>
public class DataRequirementsAnalyzer
{
    private readonly Library _library;

    /// <summary>
    /// Initializes the analyzer to use a single Library as input.
    /// </summary>
    public DataRequirementsAnalyzer(Library library)
    {
        _library = library;
    }

    /// <summary>
    /// Visits the ELM in the LibrarySet and extracts the DataRequirements from it.
    /// </summary>
    public ICollection<DataRequirement> Analyze()
    {
        var state = new RetrieveAnalyzer();

        var walker = new ElmTreeWalker(state.Visit);
        walker.Walk(_library);

        return state.DataRequirements;
    }
}

file class RetrieveAnalyzer
{
    public ICollection<DataRequirement> DataRequirements { get; } = [];

    public bool Visit(object node)
    {
        if (node is not Retrieve retrieve) return false;

        var dr = new DataRequirement();

        // Get the resource type the requirement is for.
        var (_, resourceType) = retrieve.dataType.ToNamedType();
        var knownType = ModelInfo.FhirTypeNameToFhirType(resourceType);
        if (knownType is null) return true;  // Not a known FHIR type, so we can't do anything with it.

        dr.Type = knownType;

        // Set code path if specified
        if (retrieve.codeProperty is not null)
        {
            dr.CodeFilter.Add(ToCodeFilterComponent(retrieve.codeProperty, retrieve.codes));
        }

        // Only add the requirement if we don't already have it.
        if(DataRequirements.All(r => !isSame(r, dr)))
            DataRequirements.Add(dr);

        return true;

        bool isSame(DataRequirement l, DataRequirement r) =>
            l.Type == r.Type && r.CodeFilter.IsExactly(dr.CodeFilter);
    }

    private static DataRequirement.CodeFilterComponent ToCodeFilterComponent(string property, Expression value)
    {
        DataRequirement.CodeFilterComponent cfc = new()
        {
            Path = property
        };

        // // TODO: Support retrieval when the target is a CodeSystemRef
        //
        // if (value instanceof ValueSetRef) {
        //     ValueSetRef vsr = (ValueSetRef) value;
        //     VersionedIdentifier declaredLibraryIdentifier = getDeclaredLibraryIdentifier(vsr, libraryIdentifier);
        //     cfc.setValueSet(toReference(context.resolveValueSetRef(declaredLibraryIdentifier, vsr)));
        // }
        //
        // if (value instanceof org.hl7.elm.r1.ToList) {
        //     org.hl7.elm.r1.ToList toList = (org.hl7.elm.r1.ToList) value;
        //     resolveCodeFilterCodes(context, libraryIdentifier, cfc, toList.getOperand());
        // }
        //
        // if (value instanceof org.hl7.elm.r1.List) {
        //     org.hl7.elm.r1.List codeList = (org.hl7.elm.r1.List) value;
        //     for (Expression e : codeList.getElement()) {
        //         resolveCodeFilterCodes(context, libraryIdentifier, cfc, e);
        //     }
        // }

        // TODO: no system???
        if (value is Literal l)
            cfc.Code.Add(new Coding {  Code = l.value });

        return cfc;
    }

}
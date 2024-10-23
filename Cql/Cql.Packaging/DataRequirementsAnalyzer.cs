/*
 * Copyright (c) 2024, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using Hl7.Cql.Abstractions.Exceptions;
using Hl7.Cql.Compiler;
using Elm = Hl7.Cql.Elm;
using Hl7.Cql.Model;
using Hl7.Fhir.Model;

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
internal class DataRequirementsAnalyzer(LibrarySet librarySet, Elm.Library focusLibrary)
{
    /// <summary>
    /// Visits the ELM in the LibrarySet and extracts the DataRequirements from it.
    /// </summary>
    public IReadOnlyCollection<DataRequirement> Analyze()
    {
        var result = new List<DataRequirement>();
        Visit(focusLibrary, result);

        return result;
    }

    private void Visit(Elm.Library library, List<DataRequirement> allRequirements)
    {
        var walker = new Elm.ElmTreeWalker(n => Visit(library, allRequirements, n));
        walker.Start(library);

        var dependencies = librarySet.GetLibraryDependencies(library);
        foreach (var dependency in dependencies)
        {
            Visit(dependency, allRequirements);
        }
    }

    private bool Visit(
        Elm.Library library,
        List<DataRequirement> result,
        object node)
    {
        // Function toDataRequirement in the above Java file
        if (node is not Elm.Retrieve retrieve)
            return false;

        var dr = new DataRequirement();

        // Get the resource type the requirement is for.
        var (_, resourceType) = retrieve.dataType;
        var knownType = Hl7.Fhir.Model.ModelInfo.FhirTypeNameToFhirType(resourceType);
        if (knownType is null)
            return true; // Not a known FHIR type, so we can't do anything with it.

        dr.Type = knownType;

        // Set the id attribute of the data requirement if it will be referenced from an included retrieve
        if (retrieve.localId is not null && retrieve.include is { Length: > 0 } includes)
            dr.ElementId = includes.Any(i => i.includeFrom is not null) ? retrieve.localId : null;

        // Set profile if specified
        if (retrieve.templateId is not null)
            dr.ProfileElement = [new Canonical(retrieve.templateId)];

        // Collect must supports
        HashSet<string> ps = [];

        var codeFilterBuilder = new CodeFilterComponentBuilder(librarySet, library);

        // Set code path if specified
        if (retrieve.codeProperty is { } codeProperty)
        {
            dr.CodeFilter.Add(
                codeFilterBuilder.ToCodeFilterComponent(codeProperty, retrieve.codes));

            ps.Add(codeProperty);
        }

        // Add any additional code filters
        if (retrieve.codeFilter is not null)
        {
            foreach (var cfe in retrieve.codeFilter)
            {
                dr.CodeFilter.Add(
                    codeFilterBuilder.ToCodeFilterComponent(cfe.property, cfe.value));
            }
        }

        // Add any properties as mustSupport items
        dr.MustSupportElement = [..ps.Select(s => new FhirString(s))];

        // Only add the requirement if we don't already have it.
        if (!result.Any(r => r.IsExactly(dr)))
            result.Add(dr);

        return true;
    }

    private static string ToReference(Elm.ValueSetDef def) => def.id + (def.version is { } v ? $"|{v}" : null);
    //   private static string ToReference(Elm.CodeSystemDef def) => def.id + (def.version is { } v ? $"|{v}" : null);


    private class CodeFilterComponentBuilder(LibrarySet librarySet, Elm.Library contextLibrary)
    {
        public DataRequirement.CodeFilterComponent ToCodeFilterComponent(
            string property,
            Elm.Expression value)
        {
            DataRequirement.CodeFilterComponent cfc = new()
            {
                Path = property
            };

            // TODO: Support retrieval when the target is a CodeSystemRef
            switch (value)
            {
                case Elm.ValueSetRef vsr:
                    if (librarySet.TryResolveDefinition<Elm.ValueSetDef>(contextLibrary, vsr, out var vsd))
                        cfc.ValueSet = ToReference(vsd);
                    else
                        throw new UnresolvedReferenceError(contextLibrary, vsr).ToException();
                    break;
                case Elm.ToList toList:
                    cfc.Code.AddRange(ResolveCodeFilterCodes(toList.operand));
                    break;
                case Elm.List codeList:
                    cfc.Code.AddRange(codeList.element.SelectMany(ResolveCodeFilterCodes));
                    break;
                case Elm.Literal l:
                    // TODO: no system???
                    cfc.Code.Add(new Coding { Code = l.value });
                    break;
                default:
                    throw new NotSupportedException(
                        $"Unexpected Elm expression of type {value.GetType()} in code filter.");
            }

            return cfc;
        }

        private List<Coding> ResolveCodeFilterCodes(Elm.Expression toListOperand)
        {
            return toListOperand switch
            {
                Elm.CodeRef codeRef       => [BuildCoding(codeRef)],
                Elm.Code code             => [BuildCoding(code)],
                Elm.ConceptRef conceptRef => BuildCodeableConcept(conceptRef).Coding,
                Elm.Concept concept       => BuildCodeableConcept(concept).Coding,
                Elm.Literal literal =>
                    // TODO: no system???
                    [
                        new Coding { Code = literal.value }
                    ],
                _ => throw new NotSupportedException(
                         $"Unexpected Elm expression of type {toListOperand.GetType()} in code filter codes.")
            };
        }

        private CodeableConcept BuildCodeableConcept(Elm.ConceptRef conceptRef)
        {
            if (librarySet.TryResolveDefinition<Elm.ConceptDef>(contextLibrary, conceptRef, out var cd))
                return BuildCodeableConcept(cd.display, cd.code);

            throw new UnresolvedReferenceError(contextLibrary, conceptRef).ToException();
        }

        private CodeableConcept BuildCodeableConcept(Elm.Concept concept)
            => BuildCodeableConcept(concept.display, concept.code);

        private CodeableConcept BuildCodeableConcept(string display, Elm.CodeRef[] codes)
        {
            var codings = codes.Select(BuildCoding).ToList();

            return new CodeableConcept
            {
                Coding = codings,
                Text = display
            };
        }

        private CodeableConcept BuildCodeableConcept(string display, Elm.Code[] codes)
        {
            var codings = codes.Select(BuildCoding).ToList();

            return new CodeableConcept
            {
                Coding = codings,
                Text = display
            };
        }

        private Coding BuildCoding(Elm.CodeRef codeRef)
        {
            if (librarySet.TryResolveDefinition<Elm.CodeDef>(contextLibrary, codeRef, out var cd))
                return BuildCoding(cd.id, cd.codeSystem, cd.display);
            else
                throw new UnresolvedReferenceError(contextLibrary, codeRef).ToException();
        }

        private Coding BuildCoding(Elm.Code code) => BuildCoding(code.code, code.system, code.display);

        private Coding BuildCoding(
            string code,
            Elm.CodeSystemRef codeSystemRef,
            string display)
        {
            if (librarySet.TryResolveDefinition<Elm.CodeSystemDef>(contextLibrary, codeSystemRef, out var csd))
            {
                return new Coding
                {
                    Code = code,
                    System = csd.id,
                    Display = display
                };
            }

            throw new UnresolvedReferenceError(contextLibrary, codeSystemRef).ToException();
        }
    }
}
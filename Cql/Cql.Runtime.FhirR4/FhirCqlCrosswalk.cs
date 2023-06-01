using Hl7.Cql.Primitives;
using Hl7.Cql.Elm.Expressions;
using Hl7.Cql.Poco.Fhir;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace Hl7.Cql.Runtime.FhirR4
{
    public class FhirCqlCrosswalk
    {
        public TypeResolver TypeResolver { get; private set; }

        public FhirCqlCrosswalk(TypeResolver typeResolver)
        {
            TypeResolver = typeResolver;
        }

        public TypeEntry? TypeEntryFor(FhirAllTypes fhirType)
        {
            switch (fhirType)
            {
                case FhirAllTypes.Account:
                case FhirAllTypes.ActivityDefinition:
                case FhirAllTypes.Address:
                case FhirAllTypes.AdverseEvent:
                case FhirAllTypes.AllergyIntolerance:
                case FhirAllTypes.Appointment:
                case FhirAllTypes.AppointmentResponse:
                case FhirAllTypes.Attachment:
                case FhirAllTypes.AuditEvent:
                case FhirAllTypes.BackboneElement:
                case FhirAllTypes.Basic:
                case FhirAllTypes.BodySite:
                case FhirAllTypes.Bundle:
                case FhirAllTypes.CapabilityStatement:
                case FhirAllTypes.CarePlan:
                case FhirAllTypes.CareTeam:
                case FhirAllTypes.ChargeItem:
                case FhirAllTypes.Claim:
                case FhirAllTypes.ClaimResponse:
                case FhirAllTypes.ClinicalImpression:
                case FhirAllTypes.Communication:
                case FhirAllTypes.CommunicationRequest:
                case FhirAllTypes.CompartmentDefinition:
                case FhirAllTypes.Composition:
                case FhirAllTypes.Consent:
                case FhirAllTypes.Condition:
                case FhirAllTypes.ContactDetail:
                case FhirAllTypes.ContactPoint:
                case FhirAllTypes.Contract:
                case FhirAllTypes.Contributor:
                case FhirAllTypes.Coverage:
                case FhirAllTypes.DataElement:
                case FhirAllTypes.DataRequirement:
                case FhirAllTypes.DetectedIssue:
                case FhirAllTypes.Binary:
                case FhirAllTypes.ConceptMap:
                case FhirAllTypes.Device:
                case FhirAllTypes.DeviceComponent:
                case FhirAllTypes.DeviceMetric:
                case FhirAllTypes.DeviceRequest:
                case FhirAllTypes.DeviceUseStatement:
                case FhirAllTypes.DiagnosticReport:
                case FhirAllTypes.DocumentManifest:
                case FhirAllTypes.DocumentReference:
                case FhirAllTypes.DomainResource:
                case FhirAllTypes.Dosage:
                case FhirAllTypes.Element:
                case FhirAllTypes.ElementDefinition:
                case FhirAllTypes.EligibilityRequest:
                case FhirAllTypes.EligibilityResponse:
                case FhirAllTypes.Encounter:
                case FhirAllTypes.Endpoint:
                case FhirAllTypes.EnrollmentRequest:
                case FhirAllTypes.EnrollmentResponse:
                case FhirAllTypes.EpisodeOfCare:
                case FhirAllTypes.ExpansionProfile:
                case FhirAllTypes.ExplanationOfBenefit:
                case FhirAllTypes.Extension:
                case FhirAllTypes.FamilyMemberHistory:
                case FhirAllTypes.Flag:
                case FhirAllTypes.Goal:
                case FhirAllTypes.GraphDefinition:
                case FhirAllTypes.Group:
                case FhirAllTypes.GuidanceResponse:
                case FhirAllTypes.HealthcareService:
                case FhirAllTypes.HumanName:
                case FhirAllTypes.Identifier:
                case FhirAllTypes.ImagingManifest:
                case FhirAllTypes.ImagingStudy:
                case FhirAllTypes.Immunization:
                case FhirAllTypes.ImmunizationRecommendation:
                case FhirAllTypes.ImplementationGuide:
                case FhirAllTypes.Library:
                case FhirAllTypes.Linkage:
                case FhirAllTypes.Location:
                case FhirAllTypes.Measure:
                case FhirAllTypes.MeasureReport:
                case FhirAllTypes.Media:
                case FhirAllTypes.Medication:
                case FhirAllTypes.MedicationAdministration:
                case FhirAllTypes.MedicationDispense:
                case FhirAllTypes.MedicationRequest:
                case FhirAllTypes.MedicationStatement:
                case FhirAllTypes.MessageDefinition:
                case FhirAllTypes.MessageHeader:
                case FhirAllTypes.Meta:
                case FhirAllTypes.NamingSystem:
                case FhirAllTypes.Narrative:
                case FhirAllTypes.NutritionOrder:
                case FhirAllTypes.Observation:
                case FhirAllTypes.OperationDefinition:
                case FhirAllTypes.OperationOutcome:
                case FhirAllTypes.Organization:
                case FhirAllTypes.ParameterDefinition:
                case FhirAllTypes.Parameters:
                case FhirAllTypes.Patient:
                case FhirAllTypes.PaymentNotice:
                case FhirAllTypes.PaymentReconciliation:
                case FhirAllTypes.Person:
                case FhirAllTypes.PlanDefinition:
                case FhirAllTypes.Practitioner:
                case FhirAllTypes.PractitionerRole:
                case FhirAllTypes.Procedure:
                case FhirAllTypes.ProcedureRequest:
                case FhirAllTypes.ProcessRequest:
                case FhirAllTypes.ProcessResponse:
                case FhirAllTypes.Provenance:
                case FhirAllTypes.Questionnaire:
                case FhirAllTypes.QuestionnaireResponse:
                case FhirAllTypes.Reference:
                case FhirAllTypes.ReferralRequest:
                case FhirAllTypes.RelatedArtifact:
                case FhirAllTypes.RelatedPerson:
                case FhirAllTypes.RequestGroup:
                case FhirAllTypes.ResearchStudy:
                case FhirAllTypes.ResearchSubject:
                case FhirAllTypes.Resource:
                case FhirAllTypes.RiskAssessment:
                case FhirAllTypes.SampledData:
                case FhirAllTypes.Schedule:
                case FhirAllTypes.SearchParameter:
                case FhirAllTypes.Sequence:
                case FhirAllTypes.ServiceDefinition:
                case FhirAllTypes.Signature:
                case FhirAllTypes.Slot:
                case FhirAllTypes.Specimen:
                case FhirAllTypes.StructureDefinition:
                case FhirAllTypes.StructureMap:
                case FhirAllTypes.Subscription:
                case FhirAllTypes.Substance:
                case FhirAllTypes.SupplyDelivery:
                case FhirAllTypes.SupplyRequest:
                case FhirAllTypes.Task:
                case FhirAllTypes.TestReport:
                case FhirAllTypes.TestScript:
                case FhirAllTypes.Timing:
                case FhirAllTypes.TriggerDefinition:
                case FhirAllTypes.Type:
                case FhirAllTypes.UsageContext:
                case FhirAllTypes.ValueSet:
                case FhirAllTypes.VisionPrescription:
                    return new TypeEntry(fhirType, CqlPrimitiveType.Fhir);
                case FhirAllTypes.Age:
                case FhirAllTypes.Count:
                case FhirAllTypes.Distance:
                case FhirAllTypes.Duration:
                case FhirAllTypes.Money:
                case FhirAllTypes.Quantity:
                case FhirAllTypes.SimpleQuantity:
                    return new TypeEntry(fhirType, CqlPrimitiveType.Quantity);
                case FhirAllTypes.Any:
                    return new TypeEntry(fhirType, CqlPrimitiveType.Any);
                case FhirAllTypes.String:
                case FhirAllTypes.Base64Binary:
                case FhirAllTypes.Id:
                case FhirAllTypes.Markdown:
                case FhirAllTypes.Oid:
                case FhirAllTypes.Uri:
                case FhirAllTypes.Uuid:
                case FhirAllTypes.Xhtml:
                    return new TypeEntry(fhirType, CqlPrimitiveType.String);
                case FhirAllTypes.Boolean:
                    return new TypeEntry(fhirType, CqlPrimitiveType.Boolean);
                case FhirAllTypes.Code:
                case FhirAllTypes.Coding:
                    return new TypeEntry(fhirType, CqlPrimitiveType.Code);
                case FhirAllTypes.CodeableConcept:
                    return new TypeEntry(fhirType, CqlPrimitiveType.Concept);
                case FhirAllTypes.CodeSystem:
                    return new TypeEntry(fhirType, CqlPrimitiveType.CodeSystem);
                case FhirAllTypes.Date:
                    return new TypeEntry(fhirType, CqlPrimitiveType.Date);
                case FhirAllTypes.DateTime:
                case FhirAllTypes.Instant:
                    return new TypeEntry(fhirType, CqlPrimitiveType.DateTime);
                case FhirAllTypes.Time:
                    return new TypeEntry(fhirType, CqlPrimitiveType.Time);
                case FhirAllTypes.Decimal:
                    return new TypeEntry(fhirType, CqlPrimitiveType.Decimal);
                case FhirAllTypes.Integer:
                case FhirAllTypes.UnsignedInt:
                case FhirAllTypes.PositiveInt:
                    return new TypeEntry(fhirType, CqlPrimitiveType.Integer);
                case FhirAllTypes.Integer64:
                    return new TypeEntry(fhirType, CqlPrimitiveType.Long);
                case FhirAllTypes.Range:
                    return new TypeEntry(fhirType, CqlPrimitiveType.Interval, new TypeEntry(FhirAllTypes.Quantity, CqlPrimitiveType.Quantity));
                case FhirAllTypes.Ratio:
                    return new TypeEntry(fhirType, CqlPrimitiveType.Interval, new TypeEntry(FhirAllTypes.Quantity, CqlPrimitiveType.Quantity));
                case FhirAllTypes.RatioRange:
                    return new TypeEntry(fhirType, CqlPrimitiveType.Interval, new TypeEntry(FhirAllTypes.Ratio, CqlPrimitiveType.Ratio));
                case FhirAllTypes.List:
                    return new TypeEntry(fhirType, CqlPrimitiveType.List, new TypeEntry(FhirAllTypes.Any, CqlPrimitiveType.Any));
                case FhirAllTypes.Period:
                    return new TypeEntry(fhirType, CqlPrimitiveType.Interval, new TypeEntry(FhirAllTypes.DateTime, CqlPrimitiveType.DateTime));
                default:
                    break;
            }
            return null;
        }

        public TypeEntry? TypeEntryFor(CqlPrimitiveType cqlType, TypeEntry? elementType = null)
        {
            switch (cqlType)
            {
                case CqlPrimitiveType.Any:
                    return new TypeEntry(FhirAllTypes.Any, cqlType);
                case CqlPrimitiveType.Boolean:
                    return new TypeEntry(FhirAllTypes.Boolean, cqlType);
                case CqlPrimitiveType.Code:
                    return new TypeEntry(FhirAllTypes.Code, cqlType);
                case CqlPrimitiveType.CodeSystem:
                    return new TypeEntry(FhirAllTypes.CodeSystem, cqlType);
                case CqlPrimitiveType.Concept:
                    return new TypeEntry(FhirAllTypes.CodeableConcept, cqlType);
                case CqlPrimitiveType.Date:
                    return new TypeEntry(FhirAllTypes.Date, cqlType);
                case CqlPrimitiveType.DateTime:
                    return new TypeEntry(FhirAllTypes.DateTime, cqlType);
                case CqlPrimitiveType.Decimal:
                    return new TypeEntry(FhirAllTypes.Decimal, cqlType);
                case CqlPrimitiveType.List:
                    if (elementType is null || elementType.CqlType is null)
                        throw new ArgumentNullException($"List types must specify an element type.", nameof(elementType));
                    return new TypeEntry(FhirAllTypes.List, cqlType, elementType);
                case CqlPrimitiveType.Long:
                    return new TypeEntry(FhirAllTypes.Integer64, cqlType);
                case CqlPrimitiveType.Integer:
                    return new TypeEntry(FhirAllTypes.Integer, cqlType);
                case CqlPrimitiveType.Interval:
                    if (elementType is null || elementType.CqlType is null)
                        throw new ArgumentNullException($"Interval types must specify an element (point) type.", nameof(elementType));
                    switch (elementType.CqlType)
                    {
                        case CqlPrimitiveType.Date:
                            return new TypeEntry(FhirAllTypes.Period, cqlType, TypeEntryFor(FhirAllTypes.Date));
                        case CqlPrimitiveType.DateTime:
                            return new TypeEntry(FhirAllTypes.Period, cqlType, TypeEntryFor(FhirAllTypes.DateTime));
                        case CqlPrimitiveType.Decimal:
                            return new TypeEntry(FhirAllTypes.Range, cqlType, TypeEntryFor(FhirAllTypes.Decimal));
                        case CqlPrimitiveType.Long:
                            return new TypeEntry(FhirAllTypes.Range, cqlType, TypeEntryFor(FhirAllTypes.Integer64));
                        case CqlPrimitiveType.Integer:
                            return new TypeEntry(FhirAllTypes.Range, cqlType, TypeEntryFor(FhirAllTypes.Decimal));
                        case CqlPrimitiveType.Quantity:
                            return new TypeEntry(FhirAllTypes.Range, cqlType, TypeEntryFor(FhirAllTypes.Quantity));
                        case CqlPrimitiveType.Ratio:
                            return new TypeEntry(FhirAllTypes.RatioRange, cqlType);
                        case CqlPrimitiveType.Time:
                            return new TypeEntry(FhirAllTypes.Range, cqlType, TypeEntryFor(FhirAllTypes.Duration));
                        case CqlPrimitiveType.Any:
                        case CqlPrimitiveType.Boolean:
                        case CqlPrimitiveType.Code:
                        case CqlPrimitiveType.CodeSystem:
                        case CqlPrimitiveType.Concept:
                        case CqlPrimitiveType.List:
                        case CqlPrimitiveType.Interval:
                        case CqlPrimitiveType.String:
                        case CqlPrimitiveType.ValueSet:
                        case CqlPrimitiveType.Vocabulary:
                        default:
                            return null;
                    }
                case CqlPrimitiveType.Quantity:
                    return new TypeEntry(FhirAllTypes.Quantity, cqlType);
                case CqlPrimitiveType.Ratio:
                    return new TypeEntry(FhirAllTypes.Ratio, cqlType);
                case CqlPrimitiveType.String:
                    return new TypeEntry(FhirAllTypes.String, cqlType);
                case CqlPrimitiveType.Time:
                    return new TypeEntry(FhirAllTypes.Time, cqlType);
                case CqlPrimitiveType.ValueSet:
                    return new TypeEntry(FhirAllTypes.ValueSet, cqlType);
                case CqlPrimitiveType.Tuple:
                    return new TypeEntry(FhirAllTypes.Basic, cqlType);
                case CqlPrimitiveType.Fhir:
                    return new TypeEntry(FhirAllTypes.Resource, cqlType);
                case CqlPrimitiveType.Vocabulary:
                default:
                    return null;
            }
        }

        public TypeEntry? TypeEntryFor(TypeSpecifierExpression? resultTypeSpecifier)
        {
            if (resultTypeSpecifier is null || resultTypeSpecifier.type is null)
                return null;
            switch (resultTypeSpecifier.type)
            {
                case "IntervalTypeSpecifier":
                    {
                        if (resultTypeSpecifier.pointType is null)
                            return null;
                        var pointType = TypeEntryFor(resultTypeSpecifier.pointType);
                        return TypeEntryFor(CqlPrimitiveType.Interval, pointType);
                    }
                case "ListTypeSpecifier":
                    if (resultTypeSpecifier.elementType is null)
                        return null;
                    var elementType = TypeEntryFor(resultTypeSpecifier.elementType);
                    if (elementType is null)
                        return null;
                    if (elementType.CqlType == CqlPrimitiveType.Interval && elementType.ElementType is null)
                    {
                        //What's the purpose of this?
                    }
                    return TypeEntryFor(CqlPrimitiveType.List, elementType);
                case "NamedTypeSpecifier":
                    return TypeEntryFor(resultTypeSpecifier.name);
                case "ChoiceTypeSpecifier":
                case "TupleTypeSpecifier":
                    return new TypeEntry(FhirAllTypes.Basic, CqlPrimitiveType.Tuple);
                default:
                    break;
            }
            return null;
        }

        public TypeEntry? TypeEntryFor(string? name)
        {
            if (!string.IsNullOrWhiteSpace(name))
            {
                var runtimeType = TypeResolver.ResolveType(name);
                if (string.IsNullOrWhiteSpace(name))
                    return null;
                if (name.StartsWith("{urn:hl7-org:elm-types:r1}"))
                {
                    int prefixLength = "{urn:hl7-org:elm-types:r1}".Length;
                    var remainder = name.Substring(prefixLength);
                    if (Enum.TryParse<CqlPrimitiveType>(remainder, out var primitiveType))
                        return TypeEntryFor(primitiveType);
                    else
                        return null;
                }
                else if (name.StartsWith("{http://hl7.org/fhir}"))
                {
                    int prefixLength = "{http://hl7.org/fhir}".Length;
                    var remainder = name.Substring(prefixLength);
                    var split = remainder.Split('.');
                    if (Enum.TryParse<FhirAllTypes>(split[0], out var fhirType))
                        return TypeEntryFor(fhirType);
                    else
                        return null;
                }
                else
                    return null;
            }
            else return null;
        }

        public TypeEntry? TypeEntryFor(Expression expression)
        {

            if (!string.IsNullOrWhiteSpace(expression.resultTypeName))
                return TypeEntryFor(expression.resultTypeName);
            else if (expression.resultTypeSpecifier != null)
                return TypeEntryFor(expression.resultTypeSpecifier);
            else return null;
        }

        public TypeEntry? TypeEntryFor(Type type)
        {
            var fhirUriAttribute = type.GetCustomAttribute<FhirUriAttribute>(true);
            if (fhirUriAttribute is not null)
            {
                var uri = fhirUriAttribute.Uri;
                if (uri.StartsWith("http://hl7.org/fhir/StructureDefinition/"))
                {
                    var prefixLength = "http://hl7.org/fhir/StructureDefinition/".Length;
                    var typeString = uri.Substring(prefixLength);
                    if (Enum.TryParse<FhirAllTypes>(typeString, true, out var fhirAllTypes))
                    {
                        return TypeEntryFor(fhirAllTypes);
                    }
                }
            }
            var cqlPrimitiveAttribute = type.GetCustomAttribute<CqlPrimitiveTypeAttribute>(true);
            if (cqlPrimitiveAttribute is not null)
            {
                if (cqlPrimitiveAttribute.Type == CqlPrimitiveType.Interval)
                {
                    if (type.IsGenericType)
                    {
                        var gtd = type.GetGenericTypeDefinition();
                        if (gtd == typeof(CqlInterval<>))
                        {
                            var genericArg = type.GetGenericArguments().Single();
                            var pointType = TypeEntryFor(genericArg);
                            if (pointType is not null)
                            {
                                return TypeEntryFor(cqlPrimitiveAttribute.Type, pointType!);
                            }
                        }
                    }
                    return null;
                }
                return TypeEntryFor(cqlPrimitiveAttribute.Type);
            }
            if (IsOrImplementsIEnumerableOfT(type))
            {
                var elementType = TypeResolver.GetListElementType(type);
                var elementEntry = TypeEntryFor(elementType!);
                if (elementEntry is null)
                    return null;
                return TypeEntryFor(CqlPrimitiveType.List, elementEntry);
            }
            if (type.IsPrimitive || type.IsValueType || type == typeof(string))
            {
                var fhirType = PrimitiveToFhir(type);
                if (fhirType == null) return null;

                return TypeEntryFor(fhirType.Value);
            }

            return null;
        }

        private bool IsOrImplementsIEnumerableOfT(Type type) => TypeResolver.ImplementsGenericInterface(type, typeof(IEnumerable<>));
                
        private FhirAllTypes? PrimitiveToFhir(Type type)
        {
            if (Nullable.GetUnderlyingType(type) != null)
            {
                return PrimitiveToFhir(Nullable.GetUnderlyingType(type)!);
            }

            switch (Type.GetTypeCode(type))
            {
                case TypeCode.Int32:
                    return FhirAllTypes.Integer;
                case TypeCode.Int64:
                    return FhirAllTypes.Integer64;
                case TypeCode.Decimal:
                    return FhirAllTypes.Decimal;
                case TypeCode.String:
                    return FhirAllTypes.String;
                case TypeCode.Boolean:
                    return FhirAllTypes.Boolean;
                default:
                    return null;
            }
        }
    }

    public class TypeEntry
    {
        public TypeEntry(FhirAllTypes fhirType, CqlPrimitiveType cqlType, TypeEntry? elementType = null)
        {
            FhirType = fhirType;
            CqlType = cqlType;
            ElementType = elementType;
        }

        public FhirAllTypes? FhirType { get; set; }
        public CqlPrimitiveType? CqlType { get; set; }
        public TypeEntry? ElementType { get; set; } = null;
    }
}

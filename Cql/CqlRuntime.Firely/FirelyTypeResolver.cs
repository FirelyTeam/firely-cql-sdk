using Hl7.Fhir.Model;
using Ncqa.Cql.Runtime;
using Hl7.Fhir.Introspection;
using System.Reflection;
using Ncqa.Cql.Runtime.Primitives;
using System.Globalization;
using Ncqa.Cql.Runtime.Model;
using Ncqa.Cql.Model;
namespace Ncqa.Cql.Runtime.Firely
{
    public class FirelyTypeResolver : ModelTypeResolver
    {
        public static readonly FirelyTypeResolver Default = new FirelyTypeResolver()
            .MapFhirHelperTypes()
            .MapFirelyModelTypes(typeof(Patient), typeof(Resource))
            .MapFirelyDataTypes(typeof(DataType))
            .MapTypes(typeof(Element))
            .MapTypes(typeof(Address))
            .Adjust();

        protected internal readonly IList<Type> DataTypeDerivedTypes = typeof(DataType).Assembly.GetTypes()
            .Where(type => type.BaseType == typeof(DataType))
            .ToList();

        protected internal readonly Assembly[] FhirAssemblies = new[]
        {
            typeof(DataType).Assembly,
            typeof(Patient).Assembly
        };

        protected internal readonly IList<Type> NonListTypes = new List<Type>
        {
            typeof(string),
            typeof(Claim),
            typeof(PositiveInt),
            typeof(Id),
            typeof(FhirString),
            typeof(FhirDecimal),
            typeof(Encounter.DiagnosisComponent)
        };

        public FirelyTypeResolver(): this(Models.Fhir401)
        {
        }

        public FirelyTypeResolver(Ncqa.Cql.Model.ModelInfo model) : base(model)
        {
        }

        protected FirelyTypeResolver MapFhirHelperTypes()
        {
            Types.Add("{http://hl7.org/fhir}AccountStatus", typeof(Code));
            Types.Add("{http://hl7.org/fhir}ActionCardinalityBehavior", typeof(Code));
            Types.Add("{http://hl7.org/fhir}ActionConditionKind", typeof(Code));
            Types.Add("{http://hl7.org/fhir}ActionGroupingBehavior", typeof(Code));
            Types.Add("{http://hl7.org/fhir}ActionParticipantType", typeof(Code));
            Types.Add("{http://hl7.org/fhir}ActionPrecheckBehavior", typeof(Code));
            Types.Add("{http://hl7.org/fhir}ActionRelationshipType", typeof(Code));
            Types.Add("{http://hl7.org/fhir}ActionRequiredBehavior", typeof(Code));
            Types.Add("{http://hl7.org/fhir}ActionSelectionBehavior", typeof(Code));
            Types.Add("{http://hl7.org/fhir}ActivityDefinitionKind", typeof(Code));
            Types.Add("{http://hl7.org/fhir}ActivityParticipantType", typeof(Code));
            Types.Add("{http://hl7.org/fhir}AddressType", typeof(Code));
            Types.Add("{http://hl7.org/fhir}AddressUse", typeof(Code));
            Types.Add("{http://hl7.org/fhir}AdministrativeGender", typeof(Code));
            Types.Add("{http://hl7.org/fhir}AdverseEventActuality", typeof(Code));
            Types.Add("{http://hl7.org/fhir}AggregationMode", typeof(Code));
            Types.Add("{http://hl7.org/fhir}AllergyIntoleranceCategory", typeof(Code));
            Types.Add("{http://hl7.org/fhir}AllergyIntoleranceCriticality", typeof(Code));
            Types.Add("{http://hl7.org/fhir}AllergyIntoleranceSeverity", typeof(Code));
            Types.Add("{http://hl7.org/fhir}AllergyIntoleranceType", typeof(Code));
            Types.Add("{http://hl7.org/fhir}AppointmentStatus", typeof(Code));
            Types.Add("{http://hl7.org/fhir}AssertionDirectionType", typeof(Code));
            Types.Add("{http://hl7.org/fhir}AssertionOperatorType", typeof(Code));
            Types.Add("{http://hl7.org/fhir}AssertionResponseTypes", typeof(Code));
            Types.Add("{http://hl7.org/fhir}AuditEventAction", typeof(Code));
            Types.Add("{http://hl7.org/fhir}AuditEventAgentNetworkType", typeof(Code));
            Types.Add("{http://hl7.org/fhir}AuditEventOutcome", typeof(Code));
            Types.Add("{http://hl7.org/fhir}BindingStrength", typeof(Code));
            Types.Add("{http://hl7.org/fhir}BiologicallyDerivedProductCategory", typeof(Code));
            Types.Add("{http://hl7.org/fhir}BiologicallyDerivedProductStatus", typeof(Code));
            Types.Add("{http://hl7.org/fhir}BiologicallyDerivedProductStorageScale", typeof(Code));
            Types.Add("{http://hl7.org/fhir}BundleType", typeof(Code));
            Types.Add("{http://hl7.org/fhir}CapabilityStatementKind", typeof(Code));
            Types.Add("{http://hl7.org/fhir}CarePlanActivityKind", typeof(Code));
            Types.Add("{http://hl7.org/fhir}CarePlanActivityStatus", typeof(Code));
            Types.Add("{http://hl7.org/fhir}CarePlanIntent", typeof(Code));
            Types.Add("{http://hl7.org/fhir}CarePlanStatus", typeof(Code));
            Types.Add("{http://hl7.org/fhir}CareTeamStatus", typeof(Code));
            Types.Add("{http://hl7.org/fhir}CatalogEntryRelationType", typeof(Code));
            Types.Add("{http://hl7.org/fhir}ChargeItemDefinitionPriceComponentType", typeof(Code));
            Types.Add("{http://hl7.org/fhir}ChargeItemStatus", typeof(Code));
            Types.Add("{http://hl7.org/fhir}ClaimResponseStatus", typeof(Code));
            Types.Add("{http://hl7.org/fhir}ClaimStatus", typeof(Code));
            Types.Add("{http://hl7.org/fhir}ClinicalImpressionStatus", typeof(Code));
            Types.Add("{http://hl7.org/fhir}CodeSearchSupport", typeof(Code));
            Types.Add("{http://hl7.org/fhir}CodeSystemContentMode", typeof(Code));
            Types.Add("{http://hl7.org/fhir}CodeSystemHierarchyMeaning", typeof(Code));
            Types.Add("{http://hl7.org/fhir}CommunicationPriority", typeof(Code));
            Types.Add("{http://hl7.org/fhir}CommunicationRequestStatus", typeof(Code));
            Types.Add("{http://hl7.org/fhir}CommunicationStatus", typeof(Code));
            Types.Add("{http://hl7.org/fhir}CompartmentCode", typeof(Code));
            Types.Add("{http://hl7.org/fhir}CompartmentType", typeof(Code));
            Types.Add("{http://hl7.org/fhir}CompositionAttestationMode", typeof(Code));
            Types.Add("{http://hl7.org/fhir}CompositionStatus", typeof(Code));
            Types.Add("{http://hl7.org/fhir}ConceptMapEquivalence", typeof(Code));
            Types.Add("{http://hl7.org/fhir}ConceptMapGroupUnmappedMode", typeof(Code));
            Types.Add("{http://hl7.org/fhir}ConditionalDeleteStatus", typeof(Code));
            Types.Add("{http://hl7.org/fhir}ConditionalReadStatus", typeof(Code));
            Types.Add("{http://hl7.org/fhir}ConsentDataMeaning", typeof(Code));
            Types.Add("{http://hl7.org/fhir}ConsentProvisionType", typeof(Code));
            Types.Add("{http://hl7.org/fhir}ConsentState", typeof(Code));
            Types.Add("{http://hl7.org/fhir}ConstraintSeverity", typeof(Code));
            Types.Add("{http://hl7.org/fhir}ContactPointSystem", typeof(Code));
            Types.Add("{http://hl7.org/fhir}ContactPointUse", typeof(Code));
            Types.Add("{http://hl7.org/fhir}ContractPublicationStatus", typeof(Code));
            Types.Add("{http://hl7.org/fhir}ContractStatus", typeof(Code));
            Types.Add("{http://hl7.org/fhir}ContributorType", typeof(Code));
            Types.Add("{http://hl7.org/fhir}CoverageStatus", typeof(Code));
            Types.Add("{http://hl7.org/fhir}CurrencyCode", typeof(Code));
            Types.Add("{http://hl7.org/fhir}DayOfWeek", typeof(Code));
            Types.Add("{http://hl7.org/fhir}DaysOfWeek", typeof(Code));
            Types.Add("{http://hl7.org/fhir}DetectedIssueSeverity", typeof(Code));
            Types.Add("{http://hl7.org/fhir}DetectedIssueStatus", typeof(Code));
            Types.Add("{http://hl7.org/fhir}DeviceMetricCalibrationState", typeof(Code));
            Types.Add("{http://hl7.org/fhir}DeviceMetricCalibrationType", typeof(Code));
            Types.Add("{http://hl7.org/fhir}DeviceMetricCategory", typeof(Code));
            Types.Add("{http://hl7.org/fhir}DeviceMetricColor", typeof(Code));
            Types.Add("{http://hl7.org/fhir}DeviceMetricOperationalStatus", typeof(Code));
            Types.Add("{http://hl7.org/fhir}DeviceNameType", typeof(Code));
            Types.Add("{http://hl7.org/fhir}DeviceRequestStatus", typeof(Code));
            Types.Add("{http://hl7.org/fhir}DeviceUseStatementStatus", typeof(Code));
            Types.Add("{http://hl7.org/fhir}DiagnosticReportStatus", typeof(Code));
            Types.Add("{http://hl7.org/fhir}DiscriminatorType", typeof(Code));
            Types.Add("{http://hl7.org/fhir}DocumentConfidentiality", typeof(Code));
            Types.Add("{http://hl7.org/fhir}DocumentMode", typeof(Code));
            Types.Add("{http://hl7.org/fhir}DocumentReferenceStatus", typeof(Code));
            Types.Add("{http://hl7.org/fhir}DocumentRelationshipType", typeof(Code));
            Types.Add("{http://hl7.org/fhir}EligibilityRequestPurpose", typeof(Code));
            Types.Add("{http://hl7.org/fhir}EligibilityRequestStatus", typeof(Code));
            Types.Add("{http://hl7.org/fhir}EligibilityResponsePurpose", typeof(Code));
            Types.Add("{http://hl7.org/fhir}EligibilityResponseStatus", typeof(Code));
            Types.Add("{http://hl7.org/fhir}EnableWhenBehavior", typeof(Code));
            Types.Add("{http://hl7.org/fhir}EncounterLocationStatus", typeof(Code));
            Types.Add("{http://hl7.org/fhir}EncounterStatus", typeof(Code));
            Types.Add("{http://hl7.org/fhir}EndpointStatus", typeof(Code));
            Types.Add("{http://hl7.org/fhir}EnrollmentRequestStatus", typeof(Code));
            Types.Add("{http://hl7.org/fhir}EnrollmentResponseStatus", typeof(Code));
            Types.Add("{http://hl7.org/fhir}EpisodeOfCareStatus", typeof(Code));
            Types.Add("{http://hl7.org/fhir}EventCapabilityMode", typeof(Code));
            Types.Add("{http://hl7.org/fhir}EventTiming", typeof(Code));
            Types.Add("{http://hl7.org/fhir}EvidenceVariableType", typeof(Code));
            Types.Add("{http://hl7.org/fhir}ExampleScenarioActorType", typeof(Code));
            Types.Add("{http://hl7.org/fhir}ExplanationOfBenefitStatus", typeof(Code));
            Types.Add("{http://hl7.org/fhir}ExposureState", typeof(Code));
            Types.Add("{http://hl7.org/fhir}ExtensionContextType", typeof(Code));
            Types.Add("{http://hl7.org/fhir}FHIRAllTypes", typeof(Code));
            Types.Add("{http://hl7.org/fhir}FHIRDefinedType", typeof(Code));
            Types.Add("{http://hl7.org/fhir}FHIRDeviceStatus", typeof(Code));
            Types.Add("{http://hl7.org/fhir}FHIRResourceType", typeof(Code));
            Types.Add("{http://hl7.org/fhir}FHIRSubstanceStatus", typeof(Code));
            Types.Add("{http://hl7.org/fhir}FHIRVersion", typeof(Code));
            Types.Add("{http://hl7.org/fhir}FamilyHistoryStatus", typeof(Code));
            Types.Add("{http://hl7.org/fhir}FilterOperator", typeof(Code));
            Types.Add("{http://hl7.org/fhir}FlagStatus", typeof(Code));
            Types.Add("{http://hl7.org/fhir}GoalLifecycleStatus", typeof(Code));
            Types.Add("{http://hl7.org/fhir}GraphCompartmentRule", typeof(Code));
            Types.Add("{http://hl7.org/fhir}GraphCompartmentUse", typeof(Code));
            Types.Add("{http://hl7.org/fhir}GroupMeasure", typeof(Code));
            Types.Add("{http://hl7.org/fhir}GroupType", typeof(Code));
            Types.Add("{http://hl7.org/fhir}GuidanceResponseStatus", typeof(Code));
            Types.Add("{http://hl7.org/fhir}GuidePageGeneration", typeof(Code));
            Types.Add("{http://hl7.org/fhir}GuideParameterCode", typeof(Code));
            Types.Add("{http://hl7.org/fhir}HTTPVerb", typeof(Code));
            Types.Add("{http://hl7.org/fhir}IdentifierUse", typeof(Code));
            Types.Add("{http://hl7.org/fhir}IdentityAssuranceLevel", typeof(Code));
            Types.Add("{http://hl7.org/fhir}ImagingStudyStatus", typeof(Code));
            Types.Add("{http://hl7.org/fhir}ImmunizationEvaluationStatus", typeof(Code));
            Types.Add("{http://hl7.org/fhir}ImmunizationStatus", typeof(Code));
            Types.Add("{http://hl7.org/fhir}InvoicePriceComponentType", typeof(Code));
            Types.Add("{http://hl7.org/fhir}InvoiceStatus", typeof(Code));
            Types.Add("{http://hl7.org/fhir}IssueSeverity", typeof(Code));
            Types.Add("{http://hl7.org/fhir}IssueType", typeof(Code));
            Types.Add("{http://hl7.org/fhir}LinkType", typeof(Code));
            Types.Add("{http://hl7.org/fhir}LinkageType", typeof(Code));
            Types.Add("{http://hl7.org/fhir}ListMode", typeof(Code));
            Types.Add("{http://hl7.org/fhir}ListStatus", typeof(Code));
            Types.Add("{http://hl7.org/fhir}LocationMode", typeof(Code));
            Types.Add("{http://hl7.org/fhir}LocationStatus", typeof(Code));
            Types.Add("{http://hl7.org/fhir}MeasureReportStatus", typeof(Code));
            Types.Add("{http://hl7.org/fhir}MeasureReportType", typeof(Code));
            Types.Add("{http://hl7.org/fhir}MediaStatus", typeof(Code));
            Types.Add("{http://hl7.org/fhir}MedicationAdministrationStatus", typeof(Code));
            Types.Add("{http://hl7.org/fhir}MedicationDispenseStatus", typeof(Code));
            Types.Add("{http://hl7.org/fhir}MedicationKnowledgeStatus", typeof(Code));
            Types.Add("{http://hl7.org/fhir}MedicationRequestIntent", typeof(Code));
            Types.Add("{http://hl7.org/fhir}MedicationRequestPriority", typeof(Code));
            Types.Add("{http://hl7.org/fhir}MedicationRequestStatus", typeof(Code));
            Types.Add("{http://hl7.org/fhir}MedicationStatementStatus", typeof(Code));
            Types.Add("{http://hl7.org/fhir}MedicationStatus", typeof(Code));
            Types.Add("{http://hl7.org/fhir}MessageSignificanceCategory", typeof(Code));
            Types.Add("{http://hl7.org/fhir}Messageheader_Response_Request", typeof(Code));
            Types.Add("{http://hl7.org/fhir}MimeType", typeof(Code));
            Types.Add("{http://hl7.org/fhir}NameUse", typeof(Code));
            Types.Add("{http://hl7.org/fhir}NamingSystemIdentifierType", typeof(Code));
            Types.Add("{http://hl7.org/fhir}NamingSystemType", typeof(Code));
            Types.Add("{http://hl7.org/fhir}NarrativeStatus", typeof(Code));
            Types.Add("{http://hl7.org/fhir}NoteType", typeof(Code));
            Types.Add("{http://hl7.org/fhir}NutritiionOrderIntent", typeof(Code));
            Types.Add("{http://hl7.org/fhir}NutritionOrderStatus", typeof(Code));
            Types.Add("{http://hl7.org/fhir}ObservationDataType", typeof(Code));
            Types.Add("{http://hl7.org/fhir}ObservationRangeCategory", typeof(Code));
            Types.Add("{http://hl7.org/fhir}ObservationStatus", typeof(Code));
            Types.Add("{http://hl7.org/fhir}OperationKind", typeof(Code));
            Types.Add("{http://hl7.org/fhir}OperationParameterUse", typeof(Code));
            Types.Add("{http://hl7.org/fhir}OrientationType", typeof(Code));
            Types.Add("{http://hl7.org/fhir}ParameterUse", typeof(Code));
            Types.Add("{http://hl7.org/fhir}ParticipantRequired", typeof(Code));
            Types.Add("{http://hl7.org/fhir}ParticipantStatus", typeof(Code));
            Types.Add("{http://hl7.org/fhir}ParticipationStatus", typeof(Code));
            Types.Add("{http://hl7.org/fhir}PaymentNoticeStatus", typeof(Code));
            Types.Add("{http://hl7.org/fhir}PaymentReconciliationStatus", typeof(Code));
            Types.Add("{http://hl7.org/fhir}ProcedureStatus", typeof(Code));
            Types.Add("{http://hl7.org/fhir}PropertyRepresentation", typeof(Code));
            Types.Add("{http://hl7.org/fhir}PropertyType", typeof(Code));
            Types.Add("{http://hl7.org/fhir}ProvenanceEntityRole", typeof(Code));
            Types.Add("{http://hl7.org/fhir}PublicationStatus", typeof(Code));
            Types.Add("{http://hl7.org/fhir}QualityType", typeof(Code));
            Types.Add("{http://hl7.org/fhir}QuantityComparator", typeof(Code));
            Types.Add("{http://hl7.org/fhir}QuestionnaireItemOperator", typeof(Code));
            Types.Add("{http://hl7.org/fhir}QuestionnaireItemType", typeof(Code));
            Types.Add("{http://hl7.org/fhir}QuestionnaireResponseStatus", typeof(Code));
            Types.Add("{http://hl7.org/fhir}ReferenceHandlingPolicy", typeof(Code));
            Types.Add("{http://hl7.org/fhir}ReferenceVersionRules", typeof(Code));
            Types.Add("{http://hl7.org/fhir}ReferredDocumentStatus", typeof(Code));
            Types.Add("{http://hl7.org/fhir}RelatedArtifactType", typeof(Code));
            Types.Add("{http://hl7.org/fhir}RemittanceOutcome", typeof(Code));
            Types.Add("{http://hl7.org/fhir}RepositoryType", typeof(Code));
            Types.Add("{http://hl7.org/fhir}RequestIntent", typeof(Code));
            Types.Add("{http://hl7.org/fhir}RequestPriority", typeof(Code));
            Types.Add("{http://hl7.org/fhir}RequestStatus", typeof(Code));
            Types.Add("{http://hl7.org/fhir}ResearchElementType", typeof(Code));
            Types.Add("{http://hl7.org/fhir}ResearchStudyStatus", typeof(Code));
            Types.Add("{http://hl7.org/fhir}ResearchSubjectStatus", typeof(Code));
            Types.Add("{http://hl7.org/fhir}ResourceType", typeof(Code));
            Types.Add("{http://hl7.org/fhir}ResourceVersionPolicy", typeof(Code));
            Types.Add("{http://hl7.org/fhir}ResponseType", typeof(Code));
            Types.Add("{http://hl7.org/fhir}RestfulCapabilityMode", typeof(Code));
            Types.Add("{http://hl7.org/fhir}RiskAssessmentStatus", typeof(Code));
            Types.Add("{http://hl7.org/fhir}SPDXLicense", typeof(Code));
            Types.Add("{http://hl7.org/fhir}SearchComparator", typeof(Code));
            Types.Add("{http://hl7.org/fhir}SearchEntryMode", typeof(Code));
            Types.Add("{http://hl7.org/fhir}SearchModifierCode", typeof(Code));
            Types.Add("{http://hl7.org/fhir}SearchParamType", typeof(Code));
            Types.Add("{http://hl7.org/fhir}SectionMode", typeof(Code));
            Types.Add("{http://hl7.org/fhir}SequenceType", typeof(Code));
            Types.Add("{http://hl7.org/fhir}ServiceRequestIntent", typeof(Code));
            Types.Add("{http://hl7.org/fhir}ServiceRequestPriority", typeof(Code));
            Types.Add("{http://hl7.org/fhir}ServiceRequestStatus", typeof(Code));
            Types.Add("{http://hl7.org/fhir}SlicingRules", typeof(Code));
            Types.Add("{http://hl7.org/fhir}SlotStatus", typeof(Code));
            Types.Add("{http://hl7.org/fhir}SortDirection", typeof(Code));
            Types.Add("{http://hl7.org/fhir}SpecimenContainedPreference", typeof(Code));
            Types.Add("{http://hl7.org/fhir}SpecimenStatus", typeof(Code));
            Types.Add("{http://hl7.org/fhir}Status", typeof(Code));
            Types.Add("{http://hl7.org/fhir}StrandType", typeof(Code));
            Types.Add("{http://hl7.org/fhir}StructureDefinitionKind", typeof(Code));
            Types.Add("{http://hl7.org/fhir}StructureMapContextType", typeof(Code));
            Types.Add("{http://hl7.org/fhir}StructureMapGroupTypeMode", typeof(Code));
            Types.Add("{http://hl7.org/fhir}StructureMapInputMode", typeof(Code));
            Types.Add("{http://hl7.org/fhir}StructureMapModelMode", typeof(Code));
            Types.Add("{http://hl7.org/fhir}StructureMapSourceListMode", typeof(Code));
            Types.Add("{http://hl7.org/fhir}StructureMapTargetListMode", typeof(Code));
            Types.Add("{http://hl7.org/fhir}StructureMapTransform", typeof(Code));
            Types.Add("{http://hl7.org/fhir}SubscriptionChannelType", typeof(Code));
            Types.Add("{http://hl7.org/fhir}SubscriptionStatus", typeof(Code));
            Types.Add("{http://hl7.org/fhir}SupplyDeliveryStatus", typeof(Code));
            Types.Add("{http://hl7.org/fhir}SupplyRequestStatus", typeof(Code));
            Types.Add("{http://hl7.org/fhir}SystemRestfulInteraction", typeof(Code));
            Types.Add("{http://hl7.org/fhir}TaskIntent", typeof(Code));
            Types.Add("{http://hl7.org/fhir}TaskPriority", typeof(Code));
            Types.Add("{http://hl7.org/fhir}TaskStatus", typeof(Code));
            Types.Add("{http://hl7.org/fhir}TestReportActionResult", typeof(Code));
            Types.Add("{http://hl7.org/fhir}TestReportParticipantType", typeof(Code));
            Types.Add("{http://hl7.org/fhir}TestReportResult", typeof(Code));
            Types.Add("{http://hl7.org/fhir}TestReportStatus", typeof(Code));
            Types.Add("{http://hl7.org/fhir}TestScriptRequestMethodCode", typeof(Code));
            Types.Add("{http://hl7.org/fhir}TriggerType", typeof(Code));
            Types.Add("{http://hl7.org/fhir}TypeDerivationRule", typeof(Code));
            Types.Add("{http://hl7.org/fhir}TypeRestfulInteraction", typeof(Code));
            Types.Add("{http://hl7.org/fhir}UDIEntryType", typeof(Code));
            Types.Add("{http://hl7.org/fhir}UnitsOfTime", typeof(Code));
            Types.Add("{http://hl7.org/fhir}Use", typeof(Code));
            Types.Add("{http://hl7.org/fhir}VariableType", typeof(Code));
            Types.Add("{http://hl7.org/fhir}VisionBase", typeof(Code));
            Types.Add("{http://hl7.org/fhir}VisionEyes", typeof(Code));
            Types.Add("{http://hl7.org/fhir}VisionStatus", typeof(Code));
            Types.Add("{http://hl7.org/fhir}XPathUsageType", typeof(Code));

            return this;
        }

        protected FirelyTypeResolver MapTypes(Type baseType)
        {
            var derivedTypes = baseType.Assembly
                .GetTypes()
                .Where(t => baseType.IsAssignableFrom(t));

            MapTypes(derivedTypes);
            return this;
        }

        protected FirelyTypeResolver MapFirelyModelTypes(Type assemblyType, Type baseType)
        {
            var derivedTypes = assemblyType.Assembly.GetTypes()
                .Where(t => t.IsSubclassOf(baseType));

            MapTypes(derivedTypes);
            
            return this;
        }

        protected FirelyTypeResolver MapFirelyDataTypes(Type assemblyType)
        {
            var dataTypes = assemblyType.Assembly.GetTypes()
                .Where(type => type.BaseType == typeof(DataType) || type.IsSubclassOf(assemblyType));

            MapTypes(dataTypes);

            return this;
        }

        public override PropertyInfo? GetProperty(Type type, string propertyName)
        {
            if (typeof(TupleBaseType).IsAssignableFrom(type))
            {
                var properties = type.GetProperties();
                foreach (var prop in properties)
                {
                    var cqlDeclaration = prop.GetCustomAttribute<CqlDeclarationAttribute>();
                    if (cqlDeclaration != null && cqlDeclaration.Name == propertyName)
                        return prop;
                }
            }

            var property = type
                .GetProperties()
                .SingleOrDefault(property =>
                {
                    var fhirElementAttribute = property.GetCustomAttribute<FhirElementAttribute>();
                    if (fhirElementAttribute != null && string.Equals(propertyName, fhirElementAttribute.Name, StringComparison.Ordinal))
                        return true;
                    else return false;
                });
            if (property != null)
            {
                var declareingTypeAttribute = property
                    .GetCustomAttribute(typeof(DeclaredTypeAttribute)) as DeclaredTypeAttribute;

                if (declareingTypeAttribute?.Type == typeof(Code)
                    || declareingTypeAttribute?.Type == typeof(ICollection<Code>))
                {
                    var firelyType = type.GetProperty(propertyName, BindingFlags.IgnoreCase | BindingFlags.Public | BindingFlags.Instance);
                    return firelyType;
                }
                
                return property;
            }
                
            if (type.IsGenericType && type.GetGenericTypeDefinition() == typeof(Nullable<>) && string.Equals(propertyName, "value", StringComparison.OrdinalIgnoreCase))
            {
                property = type.GetProperty("Value");
                return property;
            }
            property = type.GetProperty(propertyName);
            if (property == null)
            {
                if (type == typeof(Hl7.Fhir.Model.DataType))
                {
                    var derivedTypeProperties = DataTypeDerivedTypes
                        .Select(t => GetProperty(t, propertyName))
                        .Where(p => p != null)
                        .ToList();
                    if (derivedTypeProperties.Count == 1)
                        return derivedTypeProperties[0];
                    else if (derivedTypeProperties.Count > 1)
                        return null; // we'll have to determine this at runtime
                }
            }
            return property;
        }

        public override Type? ResolveType(string typeSpecifier)
        {
            if (Types.TryGetValue(typeSpecifier, out var type))
                return type;
            else
            {
                var baseType = typeSpecifier.Replace("{http://hl7.org/fhir}", "");
                Type? fhirType = null;
                foreach (var assembly in FhirAssemblies)
                {
                    fhirType = Type.GetType($"Hl7.Fhir.Model.{baseType}, {assembly.FullName}");
                    if (fhirType != null)
                        break;
                }
                if (baseType.IndexOf('.') > -1)
                {
                    var dotDelimited = baseType.Split('.');
                    fhirType = ResolveType(dotDelimited[0]);
                    if (fhirType == null)
                        return null;
                    var index = 1;
                    do
                    {
                        var nestedTypeName = string.Join("#", dotDelimited.Take(index + 1));
                        foreach (var nested in fhirType.GetNestedTypes())
                        {
                            //[FhirType("Claim#Item", IsNestedType = true)]
                            var fhirTypeAttribute = nested.GetCustomAttribute<FhirTypeAttribute>();
                            if (fhirTypeAttribute != null)
                            {
                                if (fhirTypeAttribute.IsNestedType && fhirTypeAttribute.Name == nestedTypeName)
                                    fhirType = nested;
                            }
                        }

                        index++;
                    }
                    while (index < dotDelimited.Length);
                }

                if (fhirType != null)
                    return fhirType;

                var systemType = Type.GetType($"System.{CultureInfo.InvariantCulture.TextInfo.ToTitleCase(typeSpecifier)}");
                if (systemType != null)
                    return systemType;
            }

            throw new ArgumentException($"Type {typeSpecifier} is not bound", nameof(typeSpecifier));
        }

        public override bool IsListType(Type type, Type genericInterfaceTypeDefinition)
        {
            if (NonListTypes.Contains(type))
                return false;

            return (type.IsGenericType && type.GetGenericTypeDefinition() == genericInterfaceTypeDefinition)
                || type.GetInterfaces()
                    .Where(ifc => ifc.IsGenericType)
                    .Select(ifc => ifc.GetGenericTypeDefinition())
                    .Any(ifc => ifc == genericInterfaceTypeDefinition);
        }

        internal IDictionary<Type, string> ResourceTypeSpecifiers { get; } = new Dictionary<Type, string>();

        private void MapTypes(IEnumerable<Type> derivedTypes)
        {
            foreach (var type in derivedTypes)
            {
                MapType(type);
                MapTypes(type.GetNestedTypes());
            }
        }

        private FirelyTypeResolver Adjust()
        {
            Types["{http://hl7.org/fhir}SimpleQuantity"] = typeof(Quantity);
            Types["{http://hl7.org/fhir}MoneyQuantity"] = typeof(Quantity);
            return this;
        }


        private void MapType(Type type)
        {
            var fhirUriAttributes = type.GetCustomAttributes(typeof(FhirTypeAttribute), false)
                .Cast<FhirTypeAttribute>();
            foreach (var fhirUriAttribute in fhirUriAttributes)
            {
                // http://hl7.org/fhir/StructureDefinition/ is 40 characters long
                var resourceName = fhirUriAttribute.Name;
                var key = $"{{http://hl7.org/fhir}}{resourceName}";
                if (!Types.ContainsKey(key))
                    Types.Add(key, type);
                ResourceTypeSpecifiers.Add(type, key);
            }
            MapBoundProperties(type);
        }

        private void MapBoundProperties(Type type)
        {
            var textInfo = new CultureInfo("en-US", false).TextInfo;
            var typename = type.Name;
            // Value set bindings to CodeElement properties are used in the generated elm as 1st class types.
            foreach (var property in type.GetProperties())
            {
                var declareingTypeAttribute = property
                    .GetCustomAttribute(typeof(DeclaredTypeAttribute)) as DeclaredTypeAttribute;

                var fhirElementAttributes = property
                    .GetCustomAttributes(typeof(FhirElementAttribute), false)
                    .Cast<FhirElementAttribute>();

                if (declareingTypeAttribute?.Type == typeof(Code)
                    || declareingTypeAttribute?.Type == typeof(ICollection<Code>))
                {
                    foreach (var attribute in fhirElementAttributes) 
                    {
                        var attributeName = textInfo.ToTitleCase(attribute.Name.Replace('-', '_'));
                        var normalizedName = $"{type.Name}{attributeName}";
                        var modelUrl = $"{{http://hl7.org/fhir}}{normalizedName}";
                        if (!Types.TryGetValue(modelUrl, out var existing))
                        {
                            Types.Add(modelUrl, typeof(Code));
                        }
                    }

                    foreach (var generic in property.PropertyType.GetGenericArguments())
                    {
                        if (generic.IsEnum)
                        {
                            var genericName = generic.Name.Replace('-', '_');
                            var genericUrl = $"{{http://hl7.org/fhir}}{genericName}";
                            if (!Types.TryGetValue(genericUrl, out var existingGeneric))
                            {
                                Types.Add(genericUrl, typeof(Code));
                            }
                        }
                    }
                }
            }
        }
    }
}
using System;
using System.Linq;
using System.Collections.Generic;
using Hl7.Cql.Runtime;
using Hl7.Cql.Primitives;
using Hl7.Cql;
using Hl7.Cql.ValueSets;
using Hl7.Cql.Iso8601;
using Hl7.Fhir.Model;
using Range = Hl7.Fhir.Model.Range;
using Task = Hl7.Fhir.Model.Task;
[System.CodeDom.Compiler.GeneratedCode(".NET Code Generation", "0.9.0.0")]
[CqlLibrary("FHIRHelpers", "4.0.001")]
public class FHIRHelpers_4_0_001
{


    internal CqlContext context;

    #region Cached values

    internal Lazy<Patient> __Patient;

    #endregion
    public FHIRHelpers_4_0_001(CqlContext context)
    {
        this.context = context ?? throw new ArgumentNullException("context");


        __Patient = new Lazy<Patient>(this.Patient_Value);
    }
    #region Dependencies


    #endregion

    private Patient Patient_Value()
    {
        var a_ = context?.Operators.RetrieveByValueSet<Patient>(null, 
			null);
        return context?.Operators.SingleOrNull<Patient>(a_);
    }
    [CqlDeclaration("Patient")]
    public Patient Patient() => __Patient.Value;

    [CqlDeclaration("ToInterval")]
    public CqlInterval<CqlDateTime> ToInterval(Period period)
    {
        if ((period == null))
            return (null as CqlInterval<CqlDateTime>);

        else 
            {
                var a__ = period?.StartElement?.Value;
                var b__ = context?.Operators.ConvertStringToDateTime(a__);
                var c__ = period?.EndElement?.Value;
                var d__ = context?.Operators.ConvertStringToDateTime(c__);
                return context?.Operators.Interval(b__, 
					d__, 
					true, 
					true);
            }
    }


    [CqlDeclaration("ToInterval")]
    public CqlInterval<CqlQuantity> ToInterval(Range range)
    {
        if ((range == null))
            return (null as CqlInterval<CqlQuantity>);

        else 
            {
                var a__ = range?.Low;
                var b__ = this.ToQuantity(a__);
                var c__ = range?.High;
                var d__ = this.ToQuantity(c__);
                return context?.Operators.Interval(b__, 
					d__, 
					true, 
					true);
            }
    }


    [CqlDeclaration("ToQuantity")]
    public CqlQuantity ToQuantity(Quantity quantity)
    {
        if ((quantity == null))
            return null;

        else 
            return new CqlQuantity(quantity?.ValueElement?.Value, 
quantity?.UnitElement?.Value);

    }


    [CqlDeclaration("ToRatio")]
    public CqlRatio ToRatio(Ratio ratio)
    {
        if ((ratio == null))
            return null;

        else 
            return new CqlRatio(this.ToQuantity(ratio?.Numerator), 
				this.ToQuantity(ratio?.Denominator));

    }


    [CqlDeclaration("ToCode")]
    public CqlCode ToCode(Coding coding)
    {
        if ((coding == null))
            return null;

        else 
            return new CqlCode(coding?.CodeElement?.Value, 
coding?.SystemElement?.Value, 
coding?.VersionElement?.Value, 
coding?.DisplayElement?.Value);

    }


    [CqlDeclaration("ToConcept")]
    public CqlConcept ToConcept(CodeableConcept concept)
    {
        if ((concept == null))
            return null;

        else 
            return new CqlConcept(context?.Operators.SelectOrNull<Coding, CqlCode>((concept?.Coding as IEnumerable<Coding>), 
					(C) => this.ToCode(C)), 
concept?.TextElement?.Value);

    }


    [CqlDeclaration("ToString")]
    public Account.AccountStatus? ToString(Code<Account.AccountStatus> value)
    {
        return value?.Value;
    }

    [CqlDeclaration("ToString")]
    public ActionCardinalityBehavior? ToString(Code<ActionCardinalityBehavior> value)
    {
        return value?.Value;
    }

    [CqlDeclaration("ToString")]
    public ActionConditionKind? ToString(Code<ActionConditionKind> value)
    {
        return value?.Value;
    }

    [CqlDeclaration("ToString")]
    public ActionGroupingBehavior? ToString(Code<ActionGroupingBehavior> value)
    {
        return value?.Value;
    }

    [CqlDeclaration("ToString")]
    public ActionParticipantType? ToString(Code<ActionParticipantType> value)
    {
        return value?.Value;
    }

    [CqlDeclaration("ToString")]
    public ActionPrecheckBehavior? ToString(Code<ActionPrecheckBehavior> value)
    {
        return value?.Value;
    }

    [CqlDeclaration("ToString")]
    public ActionRelationshipType? ToString(Code<ActionRelationshipType> value)
    {
        return value?.Value;
    }

    [CqlDeclaration("ToString")]
    public ActionRequiredBehavior? ToString(Code<ActionRequiredBehavior> value)
    {
        return value?.Value;
    }

    [CqlDeclaration("ToString")]
    public ActionSelectionBehavior? ToString(Code<ActionSelectionBehavior> value)
    {
        return value?.Value;
    }

    [CqlDeclaration("ToString")]
    public ActivityDefinition.RequestResourceType? ToString(Code<ActivityDefinition.RequestResourceType> value)
    {
        return value?.Value;
    }

    [CqlDeclaration("ToString")]
    public Address.AddressType? ToString(Code<Address.AddressType> value)
    {
        return value?.Value;
    }

    [CqlDeclaration("ToString")]
    public Address.AddressUse? ToString(Code<Address.AddressUse> value)
    {
        return value?.Value;
    }

    [CqlDeclaration("ToString")]
    public AdministrativeGender? ToString(Code<AdministrativeGender> value)
    {
        return value?.Value;
    }

    [CqlDeclaration("ToString")]
    public AdverseEvent.AdverseEventActuality? ToString(Code<AdverseEvent.AdverseEventActuality> value)
    {
        return value?.Value;
    }

    [CqlDeclaration("ToString")]
    public ElementDefinition.AggregationMode? ToString(Code<ElementDefinition.AggregationMode> value)
    {
        return value?.Value;
    }

    [CqlDeclaration("ToString")]
    public AllergyIntolerance.AllergyIntoleranceCategory? ToString(Code<AllergyIntolerance.AllergyIntoleranceCategory> value)
    {
        return value?.Value;
    }

    [CqlDeclaration("ToString")]
    public AllergyIntolerance.AllergyIntoleranceCriticality? ToString(Code<AllergyIntolerance.AllergyIntoleranceCriticality> value)
    {
        return value?.Value;
    }

    [CqlDeclaration("ToString")]
    public AllergyIntolerance.AllergyIntoleranceSeverity? ToString(Code<AllergyIntolerance.AllergyIntoleranceSeverity> value)
    {
        return value?.Value;
    }

    [CqlDeclaration("ToString")]
    public AllergyIntolerance.AllergyIntoleranceType? ToString(Code<AllergyIntolerance.AllergyIntoleranceType> value)
    {
        return value?.Value;
    }

    [CqlDeclaration("ToString")]
    public Appointment.AppointmentStatus? ToString(Code<Appointment.AppointmentStatus> value)
    {
        return value?.Value;
    }

    [CqlDeclaration("ToString")]
    public TestScript.AssertionDirectionType? ToString(Code<TestScript.AssertionDirectionType> value)
    {
        return value?.Value;
    }

    [CqlDeclaration("ToString")]
    public TestScript.AssertionOperatorType? ToString(Code<TestScript.AssertionOperatorType> value)
    {
        return value?.Value;
    }

    [CqlDeclaration("ToString")]
    public TestScript.AssertionResponseTypes? ToString(Code<TestScript.AssertionResponseTypes> value)
    {
        return value?.Value;
    }

    [CqlDeclaration("ToString")]
    public AuditEvent.AuditEventAction? ToString(Code<AuditEvent.AuditEventAction> value)
    {
        return value?.Value;
    }

    [CqlDeclaration("ToString")]
    public AuditEvent.AuditEventAgentNetworkType? ToString(Code<AuditEvent.AuditEventAgentNetworkType> value)
    {
        return value?.Value;
    }

    [CqlDeclaration("ToString")]
    public AuditEvent.AuditEventOutcome? ToString(Code<AuditEvent.AuditEventOutcome> value)
    {
        return value?.Value;
    }

    [CqlDeclaration("ToString")]
    public BindingStrength? ToString(Code<BindingStrength> value)
    {
        return value?.Value;
    }

    [CqlDeclaration("ToString")]
    public BiologicallyDerivedProduct.BiologicallyDerivedProductCategory? ToString(Code<BiologicallyDerivedProduct.BiologicallyDerivedProductCategory> value)
    {
        return value?.Value;
    }

    [CqlDeclaration("ToString")]
    public BiologicallyDerivedProduct.BiologicallyDerivedProductStatus? ToString(Code<BiologicallyDerivedProduct.BiologicallyDerivedProductStatus> value)
    {
        return value?.Value;
    }

    [CqlDeclaration("ToString")]
    public BiologicallyDerivedProduct.BiologicallyDerivedProductStorageScale? ToString(Code<BiologicallyDerivedProduct.BiologicallyDerivedProductStorageScale> value)
    {
        return value?.Value;
    }

    [CqlDeclaration("ToString")]
    public Bundle.BundleType? ToString(Code<Bundle.BundleType> value)
    {
        return value?.Value;
    }

    [CqlDeclaration("ToString")]
    public CapabilityStatementKind? ToString(Code<CapabilityStatementKind> value)
    {
        return value?.Value;
    }

    [CqlDeclaration("ToString")]
    public CarePlan.CarePlanActivityKind? ToString(Code<CarePlan.CarePlanActivityKind> value)
    {
        return value?.Value;
    }

    [CqlDeclaration("ToString")]
    public CarePlan.CarePlanActivityStatus? ToString(Code<CarePlan.CarePlanActivityStatus> value)
    {
        return value?.Value;
    }

    [CqlDeclaration("ToString")]
    public CarePlan.CarePlanIntent? ToString(Code<CarePlan.CarePlanIntent> value)
    {
        return value?.Value;
    }

    [CqlDeclaration("ToString")]
    public RequestStatus? ToString(Code<RequestStatus> value)
    {
        return value?.Value;
    }

    [CqlDeclaration("ToString")]
    public CareTeam.CareTeamStatus? ToString(Code<CareTeam.CareTeamStatus> value)
    {
        return value?.Value;
    }

    [CqlDeclaration("ToString")]
    public CatalogEntry.CatalogEntryRelationType? ToString(Code<CatalogEntry.CatalogEntryRelationType> value)
    {
        return value?.Value;
    }

    [CqlDeclaration("ToString")]
    public InvoicePriceComponentType? ToString(Code<InvoicePriceComponentType> value)
    {
        return value?.Value;
    }

    [CqlDeclaration("ToString")]
    public ChargeItem.ChargeItemStatus? ToString(Code<ChargeItem.ChargeItemStatus> value)
    {
        return value?.Value;
    }

    [CqlDeclaration("ToString")]
    public FinancialResourceStatusCodes? ToString(Code<FinancialResourceStatusCodes> value)
    {
        return value?.Value;
    }

    [CqlDeclaration("ToString")]
    public ClinicalImpression.ClinicalImpressionStatus? ToString(Code<ClinicalImpression.ClinicalImpressionStatus> value)
    {
        return value?.Value;
    }

    [CqlDeclaration("ToString")]
    public TerminologyCapabilities.CodeSearchSupport? ToString(Code<TerminologyCapabilities.CodeSearchSupport> value)
    {
        return value?.Value;
    }

    [CqlDeclaration("ToString")]
    public CodeSystemContentMode? ToString(Code<CodeSystemContentMode> value)
    {
        return value?.Value;
    }

    [CqlDeclaration("ToString")]
    public CodeSystem.CodeSystemHierarchyMeaning? ToString(Code<CodeSystem.CodeSystemHierarchyMeaning> value)
    {
        return value?.Value;
    }

    [CqlDeclaration("ToString")]
    public RequestPriority? ToString(Code<RequestPriority> value)
    {
        return value?.Value;
    }

    [CqlDeclaration("ToString")]
    public EventStatus? ToString(Code<EventStatus> value)
    {
        return value?.Value;
    }

    [CqlDeclaration("ToString")]
    public CompartmentType? ToString(Code<CompartmentType> value)
    {
        return value?.Value;
    }

    [CqlDeclaration("ToString")]
    public Composition.CompositionAttestationMode? ToString(Code<Composition.CompositionAttestationMode> value)
    {
        return value?.Value;
    }

    [CqlDeclaration("ToString")]
    public CompositionStatus? ToString(Code<CompositionStatus> value)
    {
        return value?.Value;
    }

    [CqlDeclaration("ToString")]
    public ConceptMapEquivalence? ToString(Code<ConceptMapEquivalence> value)
    {
        return value?.Value;
    }

    [CqlDeclaration("ToString")]
    public ConceptMap.ConceptMapGroupUnmappedMode? ToString(Code<ConceptMap.ConceptMapGroupUnmappedMode> value)
    {
        return value?.Value;
    }

    [CqlDeclaration("ToString")]
    public CapabilityStatement.ConditionalDeleteStatus? ToString(Code<CapabilityStatement.ConditionalDeleteStatus> value)
    {
        return value?.Value;
    }

    [CqlDeclaration("ToString")]
    public CapabilityStatement.ConditionalReadStatus? ToString(Code<CapabilityStatement.ConditionalReadStatus> value)
    {
        return value?.Value;
    }

    [CqlDeclaration("ToString")]
    public Consent.ConsentDataMeaning? ToString(Code<Consent.ConsentDataMeaning> value)
    {
        return value?.Value;
    }

    [CqlDeclaration("ToString")]
    public Consent.ConsentProvisionType? ToString(Code<Consent.ConsentProvisionType> value)
    {
        return value?.Value;
    }

    [CqlDeclaration("ToString")]
    public Consent.ConsentState? ToString(Code<Consent.ConsentState> value)
    {
        return value?.Value;
    }

    [CqlDeclaration("ToString")]
    public ConstraintSeverity? ToString(Code<ConstraintSeverity> value)
    {
        return value?.Value;
    }

    [CqlDeclaration("ToString")]
    public ContactPoint.ContactPointSystem? ToString(Code<ContactPoint.ContactPointSystem> value)
    {
        return value?.Value;
    }

    [CqlDeclaration("ToString")]
    public ContactPoint.ContactPointUse? ToString(Code<ContactPoint.ContactPointUse> value)
    {
        return value?.Value;
    }

    [CqlDeclaration("ToString")]
    public Contract.ContractResourcePublicationStatusCodes? ToString(Code<Contract.ContractResourcePublicationStatusCodes> value)
    {
        return value?.Value;
    }

    [CqlDeclaration("ToString")]
    public Contract.ContractResourceStatusCodes? ToString(Code<Contract.ContractResourceStatusCodes> value)
    {
        return value?.Value;
    }

    [CqlDeclaration("ToString")]
    public Contributor.ContributorType? ToString(Code<Contributor.ContributorType> value)
    {
        return value?.Value;
    }

    [CqlDeclaration("ToString")]
    public Money.Currencies? ToString(Code<Money.Currencies> value)
    {
        return value?.Value;
    }

    [CqlDeclaration("ToString")]
    public DaysOfWeek? ToString(Code<DaysOfWeek> value)
    {
        return value?.Value;
    }

    [CqlDeclaration("ToString")]
    public DetectedIssue.DetectedIssueSeverity? ToString(Code<DetectedIssue.DetectedIssueSeverity> value)
    {
        return value?.Value;
    }

    [CqlDeclaration("ToString")]
    public ObservationStatus? ToString(Code<ObservationStatus> value)
    {
        return value?.Value;
    }

    [CqlDeclaration("ToString")]
    public DeviceMetric.DeviceMetricCalibrationState? ToString(Code<DeviceMetric.DeviceMetricCalibrationState> value)
    {
        return value?.Value;
    }

    [CqlDeclaration("ToString")]
    public DeviceMetric.DeviceMetricCalibrationType? ToString(Code<DeviceMetric.DeviceMetricCalibrationType> value)
    {
        return value?.Value;
    }

    [CqlDeclaration("ToString")]
    public DeviceMetric.DeviceMetricCategory? ToString(Code<DeviceMetric.DeviceMetricCategory> value)
    {
        return value?.Value;
    }

    [CqlDeclaration("ToString")]
    public DeviceMetric.DeviceMetricColor? ToString(Code<DeviceMetric.DeviceMetricColor> value)
    {
        return value?.Value;
    }

    [CqlDeclaration("ToString")]
    public DeviceMetric.DeviceMetricOperationalStatus? ToString(Code<DeviceMetric.DeviceMetricOperationalStatus> value)
    {
        return value?.Value;
    }

    [CqlDeclaration("ToString")]
    public DeviceNameType? ToString(Code<DeviceNameType> value)
    {
        return value?.Value;
    }

    [CqlDeclaration("ToString")]
    public DeviceUseStatement.DeviceUseStatementStatus? ToString(Code<DeviceUseStatement.DeviceUseStatementStatus> value)
    {
        return value?.Value;
    }

    [CqlDeclaration("ToString")]
    public DiagnosticReport.DiagnosticReportStatus? ToString(Code<DiagnosticReport.DiagnosticReportStatus> value)
    {
        return value?.Value;
    }

    [CqlDeclaration("ToString")]
    public ElementDefinition.DiscriminatorType? ToString(Code<ElementDefinition.DiscriminatorType> value)
    {
        return value?.Value;
    }

    [CqlDeclaration("ToString")]
    public Composition.V3ConfidentialityClassification? ToString(Code<Composition.V3ConfidentialityClassification> value)
    {
        return value?.Value;
    }

    [CqlDeclaration("ToString")]
    public CapabilityStatement.DocumentMode? ToString(Code<CapabilityStatement.DocumentMode> value)
    {
        return value?.Value;
    }

    [CqlDeclaration("ToString")]
    public DocumentReferenceStatus? ToString(Code<DocumentReferenceStatus> value)
    {
        return value?.Value;
    }

    [CqlDeclaration("ToString")]
    public DocumentRelationshipType? ToString(Code<DocumentRelationshipType> value)
    {
        return value?.Value;
    }

    [CqlDeclaration("ToString")]
    public CoverageEligibilityRequest.EligibilityRequestPurpose? ToString(Code<CoverageEligibilityRequest.EligibilityRequestPurpose> value)
    {
        return value?.Value;
    }

    [CqlDeclaration("ToString")]
    public CoverageEligibilityResponse.EligibilityResponsePurpose? ToString(Code<CoverageEligibilityResponse.EligibilityResponsePurpose> value)
    {
        return value?.Value;
    }

    [CqlDeclaration("ToString")]
    public Questionnaire.EnableWhenBehavior? ToString(Code<Questionnaire.EnableWhenBehavior> value)
    {
        return value?.Value;
    }

    [CqlDeclaration("ToString")]
    public Encounter.EncounterLocationStatus? ToString(Code<Encounter.EncounterLocationStatus> value)
    {
        return value?.Value;
    }

    [CqlDeclaration("ToString")]
    public Encounter.EncounterStatus? ToString(Code<Encounter.EncounterStatus> value)
    {
        return value?.Value;
    }

    [CqlDeclaration("ToString")]
    public Endpoint.EndpointStatus? ToString(Code<Endpoint.EndpointStatus> value)
    {
        return value?.Value;
    }

    [CqlDeclaration("ToString")]
    public EpisodeOfCare.EpisodeOfCareStatus? ToString(Code<EpisodeOfCare.EpisodeOfCareStatus> value)
    {
        return value?.Value;
    }

    [CqlDeclaration("ToString")]
    public CapabilityStatement.EventCapabilityMode? ToString(Code<CapabilityStatement.EventCapabilityMode> value)
    {
        return value?.Value;
    }

    [CqlDeclaration("ToString")]
    public Timing.EventTiming? ToString(Code<Timing.EventTiming> value)
    {
        return value?.Value;
    }

    [CqlDeclaration("ToString")]
    public VariableTypeCode? ToString(Code<VariableTypeCode> value)
    {
        return value?.Value;
    }

    [CqlDeclaration("ToString")]
    public ExampleScenario.ExampleScenarioActorType? ToString(Code<ExampleScenario.ExampleScenarioActorType> value)
    {
        return value?.Value;
    }

    [CqlDeclaration("ToString")]
    public ExplanationOfBenefit.ExplanationOfBenefitStatus? ToString(Code<ExplanationOfBenefit.ExplanationOfBenefitStatus> value)
    {
        return value?.Value;
    }

    [CqlDeclaration("ToString")]
    public EffectEvidenceSynthesis.ExposureStateCode? ToString(Code<EffectEvidenceSynthesis.ExposureStateCode> value)
    {
        return value?.Value;
    }

    [CqlDeclaration("ToString")]
    public StructureDefinition.ExtensionContextType? ToString(Code<StructureDefinition.ExtensionContextType> value)
    {
        return value?.Value;
    }

    [CqlDeclaration("ToString")]
    public FHIRAllTypes? ToString(Code<FHIRAllTypes> value)
    {
        return value?.Value;
    }

    [CqlDeclaration("ToString")]
    public FHIRDefinedType? ToString(Code<FHIRDefinedType> value)
    {
        return value?.Value;
    }

    [CqlDeclaration("ToString")]
    public Device.FHIRDeviceStatus? ToString(Code<Device.FHIRDeviceStatus> value)
    {
        return value?.Value;
    }

    [CqlDeclaration("ToString")]
    public ResourceType? ToString(Code<ResourceType> value)
    {
        return value?.Value;
    }

    [CqlDeclaration("ToString")]
    public Substance.FHIRSubstanceStatus? ToString(Code<Substance.FHIRSubstanceStatus> value)
    {
        return value?.Value;
    }

    [CqlDeclaration("ToString")]
    public FHIRVersion? ToString(Code<FHIRVersion> value)
    {
        return value?.Value;
    }

    [CqlDeclaration("ToString")]
    public FamilyMemberHistory.FamilyHistoryStatus? ToString(Code<FamilyMemberHistory.FamilyHistoryStatus> value)
    {
        return value?.Value;
    }

    [CqlDeclaration("ToString")]
    public FilterOperator? ToString(Code<FilterOperator> value)
    {
        return value?.Value;
    }

    [CqlDeclaration("ToString")]
    public Flag.FlagStatus? ToString(Code<Flag.FlagStatus> value)
    {
        return value?.Value;
    }

    [CqlDeclaration("ToString")]
    public Goal.GoalLifecycleStatus? ToString(Code<Goal.GoalLifecycleStatus> value)
    {
        return value?.Value;
    }

    [CqlDeclaration("ToString")]
    public GraphDefinition.GraphCompartmentRule? ToString(Code<GraphDefinition.GraphCompartmentRule> value)
    {
        return value?.Value;
    }

    [CqlDeclaration("ToString")]
    public GraphDefinition.GraphCompartmentUse? ToString(Code<GraphDefinition.GraphCompartmentUse> value)
    {
        return value?.Value;
    }

    [CqlDeclaration("ToString")]
    public GroupMeasureCode? ToString(Code<GroupMeasureCode> value)
    {
        return value?.Value;
    }

    [CqlDeclaration("ToString")]
    public Group.GroupType? ToString(Code<Group.GroupType> value)
    {
        return value?.Value;
    }

    [CqlDeclaration("ToString")]
    public GuidanceResponse.GuidanceResponseStatus? ToString(Code<GuidanceResponse.GuidanceResponseStatus> value)
    {
        return value?.Value;
    }

    [CqlDeclaration("ToString")]
    public ImplementationGuide.GuidePageGeneration? ToString(Code<ImplementationGuide.GuidePageGeneration> value)
    {
        return value?.Value;
    }

    [CqlDeclaration("ToString")]
    public ImplementationGuide.GuideParameterCode? ToString(Code<ImplementationGuide.GuideParameterCode> value)
    {
        return value?.Value;
    }

    [CqlDeclaration("ToString")]
    public Bundle.HTTPVerb? ToString(Code<Bundle.HTTPVerb> value)
    {
        return value?.Value;
    }

    [CqlDeclaration("ToString")]
    public Identifier.IdentifierUse? ToString(Code<Identifier.IdentifierUse> value)
    {
        return value?.Value;
    }

    [CqlDeclaration("ToString")]
    public Person.IdentityAssuranceLevel? ToString(Code<Person.IdentityAssuranceLevel> value)
    {
        return value?.Value;
    }

    [CqlDeclaration("ToString")]
    public ImagingStudy.ImagingStudyStatus? ToString(Code<ImagingStudy.ImagingStudyStatus> value)
    {
        return value?.Value;
    }

    [CqlDeclaration("ToString")]
    public ImmunizationEvaluation.ImmunizationEvaluationStatusCodes? ToString(Code<ImmunizationEvaluation.ImmunizationEvaluationStatusCodes> value)
    {
        return value?.Value;
    }

    [CqlDeclaration("ToString")]
    public Immunization.ImmunizationStatusCodes? ToString(Code<Immunization.ImmunizationStatusCodes> value)
    {
        return value?.Value;
    }

    [CqlDeclaration("ToString")]
    public Invoice.InvoiceStatus? ToString(Code<Invoice.InvoiceStatus> value)
    {
        return value?.Value;
    }

    [CqlDeclaration("ToString")]
    public OperationOutcome.IssueSeverity? ToString(Code<OperationOutcome.IssueSeverity> value)
    {
        return value?.Value;
    }

    [CqlDeclaration("ToString")]
    public OperationOutcome.IssueType? ToString(Code<OperationOutcome.IssueType> value)
    {
        return value?.Value;
    }

    [CqlDeclaration("ToString")]
    public Patient.LinkType? ToString(Code<Patient.LinkType> value)
    {
        return value?.Value;
    }

    [CqlDeclaration("ToString")]
    public Linkage.LinkageType? ToString(Code<Linkage.LinkageType> value)
    {
        return value?.Value;
    }

    [CqlDeclaration("ToString")]
    public ListMode? ToString(Code<ListMode> value)
    {
        return value?.Value;
    }

    [CqlDeclaration("ToString")]
    public List.ListStatus? ToString(Code<List.ListStatus> value)
    {
        return value?.Value;
    }

    [CqlDeclaration("ToString")]
    public Location.LocationMode? ToString(Code<Location.LocationMode> value)
    {
        return value?.Value;
    }

    [CqlDeclaration("ToString")]
    public Location.LocationStatus? ToString(Code<Location.LocationStatus> value)
    {
        return value?.Value;
    }

    [CqlDeclaration("ToString")]
    public MeasureReport.MeasureReportStatus? ToString(Code<MeasureReport.MeasureReportStatus> value)
    {
        return value?.Value;
    }

    [CqlDeclaration("ToString")]
    public MeasureReport.MeasureReportType? ToString(Code<MeasureReport.MeasureReportType> value)
    {
        return value?.Value;
    }

    [CqlDeclaration("ToString")]
    public MedicationAdministration.MedicationAdministrationStatusCodes? ToString(Code<MedicationAdministration.MedicationAdministrationStatusCodes> value)
    {
        return value?.Value;
    }

    [CqlDeclaration("ToString")]
    public MedicationDispense.MedicationDispenseStatusCodes? ToString(Code<MedicationDispense.MedicationDispenseStatusCodes> value)
    {
        return value?.Value;
    }

    [CqlDeclaration("ToString")]
    public MedicationKnowledge.MedicationKnowledgeStatusCodes? ToString(Code<MedicationKnowledge.MedicationKnowledgeStatusCodes> value)
    {
        return value?.Value;
    }

    [CqlDeclaration("ToString")]
    public MedicationRequest.MedicationRequestIntent? ToString(Code<MedicationRequest.MedicationRequestIntent> value)
    {
        return value?.Value;
    }

    [CqlDeclaration("ToString")]
    public MedicationRequest.MedicationrequestStatus? ToString(Code<MedicationRequest.MedicationrequestStatus> value)
    {
        return value?.Value;
    }

    [CqlDeclaration("ToString")]
    public MedicationStatement.MedicationStatusCodes? ToString(Code<MedicationStatement.MedicationStatusCodes> value)
    {
        return value?.Value;
    }

    [CqlDeclaration("ToString")]
    public Medication.MedicationStatusCodes? ToString(Code<Medication.MedicationStatusCodes> value)
    {
        return value?.Value;
    }

    [CqlDeclaration("ToString")]
    public MessageDefinition.MessageSignificanceCategory? ToString(Code<MessageDefinition.MessageSignificanceCategory> value)
    {
        return value?.Value;
    }

    [CqlDeclaration("ToString")]
    public MessageheaderResponseRequest? ToString(Code<MessageheaderResponseRequest> value)
    {
        return value?.Value;
    }

    [CqlDeclaration("ToString")]
    public string ToString(Code value)
    {
        return value?.Value;
    }

    [CqlDeclaration("ToString")]
    public HumanName.NameUse? ToString(Code<HumanName.NameUse> value)
    {
        return value?.Value;
    }

    [CqlDeclaration("ToString")]
    public NamingSystem.NamingSystemIdentifierType? ToString(Code<NamingSystem.NamingSystemIdentifierType> value)
    {
        return value?.Value;
    }

    [CqlDeclaration("ToString")]
    public NamingSystem.NamingSystemType? ToString(Code<NamingSystem.NamingSystemType> value)
    {
        return value?.Value;
    }

    [CqlDeclaration("ToString")]
    public Narrative.NarrativeStatus? ToString(Code<Narrative.NarrativeStatus> value)
    {
        return value?.Value;
    }

    [CqlDeclaration("ToString")]
    public NoteType? ToString(Code<NoteType> value)
    {
        return value?.Value;
    }

    [CqlDeclaration("ToString")]
    public RequestIntent? ToString(Code<RequestIntent> value)
    {
        return value?.Value;
    }

    [CqlDeclaration("ToString")]
    public ObservationDefinition.ObservationDataType? ToString(Code<ObservationDefinition.ObservationDataType> value)
    {
        return value?.Value;
    }

    [CqlDeclaration("ToString")]
    public ObservationDefinition.ObservationRangeCategory? ToString(Code<ObservationDefinition.ObservationRangeCategory> value)
    {
        return value?.Value;
    }

    [CqlDeclaration("ToString")]
    public OperationDefinition.OperationKind? ToString(Code<OperationDefinition.OperationKind> value)
    {
        return value?.Value;
    }

    [CqlDeclaration("ToString")]
    public OperationParameterUse? ToString(Code<OperationParameterUse> value)
    {
        return value?.Value;
    }

    [CqlDeclaration("ToString")]
    public MolecularSequence.OrientationType? ToString(Code<MolecularSequence.OrientationType> value)
    {
        return value?.Value;
    }

    [CqlDeclaration("ToString")]
    public Appointment.ParticipantRequired? ToString(Code<Appointment.ParticipantRequired> value)
    {
        return value?.Value;
    }

    [CqlDeclaration("ToString")]
    public ParticipationStatus? ToString(Code<ParticipationStatus> value)
    {
        return value?.Value;
    }

    [CqlDeclaration("ToString")]
    public ElementDefinition.PropertyRepresentation? ToString(Code<ElementDefinition.PropertyRepresentation> value)
    {
        return value?.Value;
    }

    [CqlDeclaration("ToString")]
    public CodeSystem.PropertyType? ToString(Code<CodeSystem.PropertyType> value)
    {
        return value?.Value;
    }

    [CqlDeclaration("ToString")]
    public Provenance.ProvenanceEntityRole? ToString(Code<Provenance.ProvenanceEntityRole> value)
    {
        return value?.Value;
    }

    [CqlDeclaration("ToString")]
    public PublicationStatus? ToString(Code<PublicationStatus> value)
    {
        return value?.Value;
    }

    [CqlDeclaration("ToString")]
    public MolecularSequence.QualityType? ToString(Code<MolecularSequence.QualityType> value)
    {
        return value?.Value;
    }

    [CqlDeclaration("ToString")]
    public Quantity.QuantityComparator? ToString(Code<Quantity.QuantityComparator> value)
    {
        return value?.Value;
    }

    [CqlDeclaration("ToString")]
    public Questionnaire.QuestionnaireItemOperator? ToString(Code<Questionnaire.QuestionnaireItemOperator> value)
    {
        return value?.Value;
    }

    [CqlDeclaration("ToString")]
    public Questionnaire.QuestionnaireItemType? ToString(Code<Questionnaire.QuestionnaireItemType> value)
    {
        return value?.Value;
    }

    [CqlDeclaration("ToString")]
    public QuestionnaireResponse.QuestionnaireResponseStatus? ToString(Code<QuestionnaireResponse.QuestionnaireResponseStatus> value)
    {
        return value?.Value;
    }

    [CqlDeclaration("ToString")]
    public CapabilityStatement.ReferenceHandlingPolicy? ToString(Code<CapabilityStatement.ReferenceHandlingPolicy> value)
    {
        return value?.Value;
    }

    [CqlDeclaration("ToString")]
    public ElementDefinition.ReferenceVersionRules? ToString(Code<ElementDefinition.ReferenceVersionRules> value)
    {
        return value?.Value;
    }

    [CqlDeclaration("ToString")]
    public RelatedArtifact.RelatedArtifactType? ToString(Code<RelatedArtifact.RelatedArtifactType> value)
    {
        return value?.Value;
    }

    [CqlDeclaration("ToString")]
    public ClaimProcessingCodes? ToString(Code<ClaimProcessingCodes> value)
    {
        return value?.Value;
    }

    [CqlDeclaration("ToString")]
    public MolecularSequence.RepositoryType? ToString(Code<MolecularSequence.RepositoryType> value)
    {
        return value?.Value;
    }

    [CqlDeclaration("ToString")]
    public ResearchElementDefinition.ResearchElementType? ToString(Code<ResearchElementDefinition.ResearchElementType> value)
    {
        return value?.Value;
    }

    [CqlDeclaration("ToString")]
    public ResearchStudy.ResearchStudyStatus? ToString(Code<ResearchStudy.ResearchStudyStatus> value)
    {
        return value?.Value;
    }

    [CqlDeclaration("ToString")]
    public ResearchSubject.ResearchSubjectStatus? ToString(Code<ResearchSubject.ResearchSubjectStatus> value)
    {
        return value?.Value;
    }

    [CqlDeclaration("ToString")]
    public CapabilityStatement.ResourceVersionPolicy? ToString(Code<CapabilityStatement.ResourceVersionPolicy> value)
    {
        return value?.Value;
    }

    [CqlDeclaration("ToString")]
    public MessageHeader.ResponseType? ToString(Code<MessageHeader.ResponseType> value)
    {
        return value?.Value;
    }

    [CqlDeclaration("ToString")]
    public CapabilityStatement.RestfulCapabilityMode? ToString(Code<CapabilityStatement.RestfulCapabilityMode> value)
    {
        return value?.Value;
    }

    [CqlDeclaration("ToString")]
    public ImplementationGuide.SPDXLicense? ToString(Code<ImplementationGuide.SPDXLicense> value)
    {
        return value?.Value;
    }

    [CqlDeclaration("ToString")]
    public SearchParameter.SearchComparator? ToString(Code<SearchParameter.SearchComparator> value)
    {
        return value?.Value;
    }

    [CqlDeclaration("ToString")]
    public Bundle.SearchEntryMode? ToString(Code<Bundle.SearchEntryMode> value)
    {
        return value?.Value;
    }

    [CqlDeclaration("ToString")]
    public SearchParameter.SearchModifierCode? ToString(Code<SearchParameter.SearchModifierCode> value)
    {
        return value?.Value;
    }

    [CqlDeclaration("ToString")]
    public SearchParamType? ToString(Code<SearchParamType> value)
    {
        return value?.Value;
    }

    [CqlDeclaration("ToString")]
    public MolecularSequence.SequenceType? ToString(Code<MolecularSequence.SequenceType> value)
    {
        return value?.Value;
    }

    [CqlDeclaration("ToString")]
    public ElementDefinition.SlicingRules? ToString(Code<ElementDefinition.SlicingRules> value)
    {
        return value?.Value;
    }

    [CqlDeclaration("ToString")]
    public Slot.SlotStatus? ToString(Code<Slot.SlotStatus> value)
    {
        return value?.Value;
    }

    [CqlDeclaration("ToString")]
    public DataRequirement.SortDirection? ToString(Code<DataRequirement.SortDirection> value)
    {
        return value?.Value;
    }

    [CqlDeclaration("ToString")]
    public SpecimenDefinition.SpecimenContainedPreference? ToString(Code<SpecimenDefinition.SpecimenContainedPreference> value)
    {
        return value?.Value;
    }

    [CqlDeclaration("ToString")]
    public Specimen.SpecimenStatus? ToString(Code<Specimen.SpecimenStatus> value)
    {
        return value?.Value;
    }

    [CqlDeclaration("ToString")]
    public VerificationResult.StatusCode? ToString(Code<VerificationResult.StatusCode> value)
    {
        return value?.Value;
    }

    [CqlDeclaration("ToString")]
    public MolecularSequence.StrandType? ToString(Code<MolecularSequence.StrandType> value)
    {
        return value?.Value;
    }

    [CqlDeclaration("ToString")]
    public StructureDefinition.StructureDefinitionKind? ToString(Code<StructureDefinition.StructureDefinitionKind> value)
    {
        return value?.Value;
    }

    [CqlDeclaration("ToString")]
    public StructureMap.StructureMapContextType? ToString(Code<StructureMap.StructureMapContextType> value)
    {
        return value?.Value;
    }

    [CqlDeclaration("ToString")]
    public StructureMap.StructureMapGroupTypeMode? ToString(Code<StructureMap.StructureMapGroupTypeMode> value)
    {
        return value?.Value;
    }

    [CqlDeclaration("ToString")]
    public StructureMap.StructureMapInputMode? ToString(Code<StructureMap.StructureMapInputMode> value)
    {
        return value?.Value;
    }

    [CqlDeclaration("ToString")]
    public StructureMap.StructureMapModelMode? ToString(Code<StructureMap.StructureMapModelMode> value)
    {
        return value?.Value;
    }

    [CqlDeclaration("ToString")]
    public StructureMap.StructureMapSourceListMode? ToString(Code<StructureMap.StructureMapSourceListMode> value)
    {
        return value?.Value;
    }

    [CqlDeclaration("ToString")]
    public StructureMap.StructureMapTargetListMode? ToString(Code<StructureMap.StructureMapTargetListMode> value)
    {
        return value?.Value;
    }

    [CqlDeclaration("ToString")]
    public StructureMap.StructureMapTransform? ToString(Code<StructureMap.StructureMapTransform> value)
    {
        return value?.Value;
    }

    [CqlDeclaration("ToString")]
    public Subscription.SubscriptionChannelType? ToString(Code<Subscription.SubscriptionChannelType> value)
    {
        return value?.Value;
    }

    [CqlDeclaration("ToString")]
    public Subscription.SubscriptionStatus? ToString(Code<Subscription.SubscriptionStatus> value)
    {
        return value?.Value;
    }

    [CqlDeclaration("ToString")]
    public SupplyDelivery.SupplyDeliveryStatus? ToString(Code<SupplyDelivery.SupplyDeliveryStatus> value)
    {
        return value?.Value;
    }

    [CqlDeclaration("ToString")]
    public SupplyRequest.SupplyRequestStatus? ToString(Code<SupplyRequest.SupplyRequestStatus> value)
    {
        return value?.Value;
    }

    [CqlDeclaration("ToString")]
    public CapabilityStatement.SystemRestfulInteraction? ToString(Code<CapabilityStatement.SystemRestfulInteraction> value)
    {
        return value?.Value;
    }

    [CqlDeclaration("ToString")]
    public Task.TaskIntent? ToString(Code<Task.TaskIntent> value)
    {
        return value?.Value;
    }

    [CqlDeclaration("ToString")]
    public Task.TaskStatus? ToString(Code<Task.TaskStatus> value)
    {
        return value?.Value;
    }

    [CqlDeclaration("ToString")]
    public TestReport.TestReportActionResult? ToString(Code<TestReport.TestReportActionResult> value)
    {
        return value?.Value;
    }

    [CqlDeclaration("ToString")]
    public TestReport.TestReportParticipantType? ToString(Code<TestReport.TestReportParticipantType> value)
    {
        return value?.Value;
    }

    [CqlDeclaration("ToString")]
    public TestReport.TestReportResult? ToString(Code<TestReport.TestReportResult> value)
    {
        return value?.Value;
    }

    [CqlDeclaration("ToString")]
    public TestReport.TestReportStatus? ToString(Code<TestReport.TestReportStatus> value)
    {
        return value?.Value;
    }

    [CqlDeclaration("ToString")]
    public TestScript.TestScriptRequestMethodCode? ToString(Code<TestScript.TestScriptRequestMethodCode> value)
    {
        return value?.Value;
    }

    [CqlDeclaration("ToString")]
    public TriggerDefinition.TriggerType? ToString(Code<TriggerDefinition.TriggerType> value)
    {
        return value?.Value;
    }

    [CqlDeclaration("ToString")]
    public StructureDefinition.TypeDerivationRule? ToString(Code<StructureDefinition.TypeDerivationRule> value)
    {
        return value?.Value;
    }

    [CqlDeclaration("ToString")]
    public CapabilityStatement.TypeRestfulInteraction? ToString(Code<CapabilityStatement.TypeRestfulInteraction> value)
    {
        return value?.Value;
    }

    [CqlDeclaration("ToString")]
    public Device.UDIEntryType? ToString(Code<Device.UDIEntryType> value)
    {
        return value?.Value;
    }

    [CqlDeclaration("ToString")]
    public Timing.UnitsOfTime? ToString(Code<Timing.UnitsOfTime> value)
    {
        return value?.Value;
    }

    [CqlDeclaration("ToString")]
    public ClaimUseCode? ToString(Code<ClaimUseCode> value)
    {
        return value?.Value;
    }

    [CqlDeclaration("ToString")]
    public VisionPrescription.VisionBase? ToString(Code<VisionPrescription.VisionBase> value)
    {
        return value?.Value;
    }

    [CqlDeclaration("ToString")]
    public VisionPrescription.VisionEyes? ToString(Code<VisionPrescription.VisionEyes> value)
    {
        return value?.Value;
    }

    [CqlDeclaration("ToString")]
    public SearchParameter.XPathUsageType? ToString(Code<SearchParameter.XPathUsageType> value)
    {
        return value?.Value;
    }

    [CqlDeclaration("ToString")]
    public string ToString(Base64Binary value)
    {
        var a_ = (value?.Value as object);
        return context?.Operators.Convert<string>(a_);
    }

    [CqlDeclaration("ToString")]
    public string ToString(Id value)
    {
        return value?.Value;
    }

    [CqlDeclaration("ToString")]
    public string ToString(FhirString value)
    {
        return value?.Value;
    }

    [CqlDeclaration("ToString")]
    public string ToString(FhirUri value)
    {
        return value?.Value;
    }

    [CqlDeclaration("ToString")]
    public string ToString(XHtml value)
    {
        return value?.Value;
    }

    [CqlDeclaration("ToBoolean")]
    public bool? ToBoolean(FhirBoolean value)
    {
        return value?.Value;
    }

    [CqlDeclaration("ToDate")]
    public CqlDate ToDate(Date value)
    {
        var a_ = value?.Value;
        return context?.Operators.ConvertStringToDate(a_);
    }

    [CqlDeclaration("ToDateTime")]
    public CqlDateTime ToDateTime(FhirDateTime value)
    {
        var a_ = value?.Value;
        return context?.Operators.ConvertStringToDateTime(a_);
    }

    [CqlDeclaration("ToDateTime")]
    public CqlDateTime ToDateTime(Instant value)
    {
        var a_ = (value?.Value as object);
        return context?.Operators.Convert<CqlDateTime>(a_);
    }

    [CqlDeclaration("ToDecimal")]
    public decimal? ToDecimal(FhirDecimal value)
    {
        return value?.Value;
    }

    [CqlDeclaration("ToInteger")]
    public int? ToInteger(Integer value)
    {
        return value?.Value;
    }

    [CqlDeclaration("ToTime")]
    public CqlTime ToTime(Time value)
    {
        var a_ = value?.Value;
        return context?.Operators.ConvertStringToTime(a_);
    }

}
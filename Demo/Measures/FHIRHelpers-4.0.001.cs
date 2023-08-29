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
[System.CodeDom.Compiler.GeneratedCode(".NET Code Generation", "0.0.1.0")]
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
		var a_ = context.DataRetriever;
		var b_ = a_.RetrieveByValueSet<Patient>(null, null);
		var c_ = context.Operators;
		var d_ = c_.SingleOrNull<Patient>(b_);

		return d_;
	}

    [CqlDeclaration("Patient")]
    public Patient Patient() => __Patient.Value;

    [CqlDeclaration("ToInterval")]
    public CqlInterval<CqlDateTime> ToInterval(Period period) =>
(((period is null))
			? ((null as CqlInterval<CqlDateTime>))
			: (context.Operators.Interval(context.Operators.ConvertStringToDateTime(period?.StartElement?.Value), context.Operators.ConvertStringToDateTime(period?.EndElement?.Value), true, true)));


    [CqlDeclaration("ToInterval")]
    public CqlInterval<CqlQuantity> ToInterval(Range range) =>
(((range is null))
			? ((null as CqlInterval<CqlQuantity>))
			: (context.Operators.Interval(this.ToQuantity(range?.Low), this.ToQuantity(range?.High), true, true)));


    [CqlDeclaration("ToQuantity")]
    public CqlQuantity ToQuantity(Quantity quantity) =>
(((quantity is null))
			? (null)
			: (new CqlQuantity
				{
					value = quantity?.ValueElement?.Value,
					unit = quantity?.UnitElement?.Value,
				}));


    [CqlDeclaration("ToRatio")]
    public CqlRatio ToRatio(Ratio ratio) =>
(((ratio is null))
			? (null)
			: (new CqlRatio(this.ToQuantity(ratio?.Numerator), this.ToQuantity(ratio?.Denominator))));


    [CqlDeclaration("ToCode")]
    public CqlCode ToCode(Coding coding) =>
(((coding is null))
			? (null)
			: (new CqlCode(coding?.CodeElement?.Value, coding?.SystemElement?.Value, coding?.VersionElement?.Value, coding?.DisplayElement?.Value)));


    [CqlDeclaration("ToConcept")]
    public CqlConcept ToConcept(CodeableConcept concept) =>
(((concept is null))
			? (null)
			: (new CqlConcept(context.Operators.SelectOrNull<Coding, CqlCode>((concept?.Coding as IEnumerable<Coding>), (Coding C) => this.ToCode(C)), concept?.TextElement?.Value)));


    [CqlDeclaration("ToString")]
    public Account.AccountStatus? ToString(Code<Account.AccountStatus> value)
	{
		var a_ = value?.Value;

		return a_;
	}


    [CqlDeclaration("ToString")]
    public ActionCardinalityBehavior? ToString(Code<ActionCardinalityBehavior> value)
	{
		var a_ = value?.Value;

		return a_;
	}


    [CqlDeclaration("ToString")]
    public ActionConditionKind? ToString(Code<ActionConditionKind> value)
	{
		var a_ = value?.Value;

		return a_;
	}


    [CqlDeclaration("ToString")]
    public ActionGroupingBehavior? ToString(Code<ActionGroupingBehavior> value)
	{
		var a_ = value?.Value;

		return a_;
	}


    [CqlDeclaration("ToString")]
    public ActionParticipantType? ToString(Code<ActionParticipantType> value)
	{
		var a_ = value?.Value;

		return a_;
	}


    [CqlDeclaration("ToString")]
    public ActionPrecheckBehavior? ToString(Code<ActionPrecheckBehavior> value)
	{
		var a_ = value?.Value;

		return a_;
	}


    [CqlDeclaration("ToString")]
    public ActionRelationshipType? ToString(Code<ActionRelationshipType> value)
	{
		var a_ = value?.Value;

		return a_;
	}


    [CqlDeclaration("ToString")]
    public ActionRequiredBehavior? ToString(Code<ActionRequiredBehavior> value)
	{
		var a_ = value?.Value;

		return a_;
	}


    [CqlDeclaration("ToString")]
    public ActionSelectionBehavior? ToString(Code<ActionSelectionBehavior> value)
	{
		var a_ = value?.Value;

		return a_;
	}


    [CqlDeclaration("ToString")]
    public ActivityDefinition.RequestResourceType? ToString(Code<ActivityDefinition.RequestResourceType> value)
	{
		var a_ = value?.Value;

		return a_;
	}


    [CqlDeclaration("ToString")]
    public Address.AddressType? ToString(Code<Address.AddressType> value)
	{
		var a_ = value?.Value;

		return a_;
	}


    [CqlDeclaration("ToString")]
    public Address.AddressUse? ToString(Code<Address.AddressUse> value)
	{
		var a_ = value?.Value;

		return a_;
	}


    [CqlDeclaration("ToString")]
    public AdministrativeGender? ToString(Code<AdministrativeGender> value)
	{
		var a_ = value?.Value;

		return a_;
	}


    [CqlDeclaration("ToString")]
    public AdverseEvent.AdverseEventActuality? ToString(Code<AdverseEvent.AdverseEventActuality> value)
	{
		var a_ = value?.Value;

		return a_;
	}


    [CqlDeclaration("ToString")]
    public ElementDefinition.AggregationMode? ToString(Code<ElementDefinition.AggregationMode> value)
	{
		var a_ = value?.Value;

		return a_;
	}


    [CqlDeclaration("ToString")]
    public AllergyIntolerance.AllergyIntoleranceCategory? ToString(Code<AllergyIntolerance.AllergyIntoleranceCategory> value)
	{
		var a_ = value?.Value;

		return a_;
	}


    [CqlDeclaration("ToString")]
    public AllergyIntolerance.AllergyIntoleranceCriticality? ToString(Code<AllergyIntolerance.AllergyIntoleranceCriticality> value)
	{
		var a_ = value?.Value;

		return a_;
	}


    [CqlDeclaration("ToString")]
    public AllergyIntolerance.AllergyIntoleranceSeverity? ToString(Code<AllergyIntolerance.AllergyIntoleranceSeverity> value)
	{
		var a_ = value?.Value;

		return a_;
	}


    [CqlDeclaration("ToString")]
    public AllergyIntolerance.AllergyIntoleranceType? ToString(Code<AllergyIntolerance.AllergyIntoleranceType> value)
	{
		var a_ = value?.Value;

		return a_;
	}


    [CqlDeclaration("ToString")]
    public Appointment.AppointmentStatus? ToString(Code<Appointment.AppointmentStatus> value)
	{
		var a_ = value?.Value;

		return a_;
	}


    [CqlDeclaration("ToString")]
    public TestScript.AssertionDirectionType? ToString(Code<TestScript.AssertionDirectionType> value)
	{
		var a_ = value?.Value;

		return a_;
	}


    [CqlDeclaration("ToString")]
    public TestScript.AssertionOperatorType? ToString(Code<TestScript.AssertionOperatorType> value)
	{
		var a_ = value?.Value;

		return a_;
	}


    [CqlDeclaration("ToString")]
    public TestScript.AssertionResponseTypes? ToString(Code<TestScript.AssertionResponseTypes> value)
	{
		var a_ = value?.Value;

		return a_;
	}


    [CqlDeclaration("ToString")]
    public AuditEvent.AuditEventAction? ToString(Code<AuditEvent.AuditEventAction> value)
	{
		var a_ = value?.Value;

		return a_;
	}


    [CqlDeclaration("ToString")]
    public AuditEvent.AuditEventAgentNetworkType? ToString(Code<AuditEvent.AuditEventAgentNetworkType> value)
	{
		var a_ = value?.Value;

		return a_;
	}


    [CqlDeclaration("ToString")]
    public AuditEvent.AuditEventOutcome? ToString(Code<AuditEvent.AuditEventOutcome> value)
	{
		var a_ = value?.Value;

		return a_;
	}


    [CqlDeclaration("ToString")]
    public BindingStrength? ToString(Code<BindingStrength> value)
	{
		var a_ = value?.Value;

		return a_;
	}


    [CqlDeclaration("ToString")]
    public BiologicallyDerivedProduct.BiologicallyDerivedProductCategory? ToString(Code<BiologicallyDerivedProduct.BiologicallyDerivedProductCategory> value)
	{
		var a_ = value?.Value;

		return a_;
	}


    [CqlDeclaration("ToString")]
    public BiologicallyDerivedProduct.BiologicallyDerivedProductStatus? ToString(Code<BiologicallyDerivedProduct.BiologicallyDerivedProductStatus> value)
	{
		var a_ = value?.Value;

		return a_;
	}


    [CqlDeclaration("ToString")]
    public BiologicallyDerivedProduct.BiologicallyDerivedProductStorageScale? ToString(Code<BiologicallyDerivedProduct.BiologicallyDerivedProductStorageScale> value)
	{
		var a_ = value?.Value;

		return a_;
	}


    [CqlDeclaration("ToString")]
    public Bundle.BundleType? ToString(Code<Bundle.BundleType> value)
	{
		var a_ = value?.Value;

		return a_;
	}


    [CqlDeclaration("ToString")]
    public CapabilityStatementKind? ToString(Code<CapabilityStatementKind> value)
	{
		var a_ = value?.Value;

		return a_;
	}


    [CqlDeclaration("ToString")]
    public CarePlan.CarePlanActivityKind? ToString(Code<CarePlan.CarePlanActivityKind> value)
	{
		var a_ = value?.Value;

		return a_;
	}


    [CqlDeclaration("ToString")]
    public CarePlan.CarePlanActivityStatus? ToString(Code<CarePlan.CarePlanActivityStatus> value)
	{
		var a_ = value?.Value;

		return a_;
	}


    [CqlDeclaration("ToString")]
    public CarePlan.CarePlanIntent? ToString(Code<CarePlan.CarePlanIntent> value)
	{
		var a_ = value?.Value;

		return a_;
	}


    [CqlDeclaration("ToString")]
    public RequestStatus? ToString(Code<RequestStatus> value)
	{
		var a_ = value?.Value;

		return a_;
	}


    [CqlDeclaration("ToString")]
    public CareTeam.CareTeamStatus? ToString(Code<CareTeam.CareTeamStatus> value)
	{
		var a_ = value?.Value;

		return a_;
	}


    [CqlDeclaration("ToString")]
    public CatalogEntry.CatalogEntryRelationType? ToString(Code<CatalogEntry.CatalogEntryRelationType> value)
	{
		var a_ = value?.Value;

		return a_;
	}


    [CqlDeclaration("ToString")]
    public InvoicePriceComponentType? ToString(Code<InvoicePriceComponentType> value)
	{
		var a_ = value?.Value;

		return a_;
	}


    [CqlDeclaration("ToString")]
    public ChargeItem.ChargeItemStatus? ToString(Code<ChargeItem.ChargeItemStatus> value)
	{
		var a_ = value?.Value;

		return a_;
	}


    [CqlDeclaration("ToString")]
    public FinancialResourceStatusCodes? ToString(Code<FinancialResourceStatusCodes> value)
	{
		var a_ = value?.Value;

		return a_;
	}


    [CqlDeclaration("ToString")]
    public ClinicalImpression.ClinicalImpressionStatus? ToString(Code<ClinicalImpression.ClinicalImpressionStatus> value)
	{
		var a_ = value?.Value;

		return a_;
	}


    [CqlDeclaration("ToString")]
    public TerminologyCapabilities.CodeSearchSupport? ToString(Code<TerminologyCapabilities.CodeSearchSupport> value)
	{
		var a_ = value?.Value;

		return a_;
	}


    [CqlDeclaration("ToString")]
    public CodeSystemContentMode? ToString(Code<CodeSystemContentMode> value)
	{
		var a_ = value?.Value;

		return a_;
	}


    [CqlDeclaration("ToString")]
    public CodeSystem.CodeSystemHierarchyMeaning? ToString(Code<CodeSystem.CodeSystemHierarchyMeaning> value)
	{
		var a_ = value?.Value;

		return a_;
	}


    [CqlDeclaration("ToString")]
    public RequestPriority? ToString(Code<RequestPriority> value)
	{
		var a_ = value?.Value;

		return a_;
	}


    [CqlDeclaration("ToString")]
    public EventStatus? ToString(Code<EventStatus> value)
	{
		var a_ = value?.Value;

		return a_;
	}


    [CqlDeclaration("ToString")]
    public CompartmentType? ToString(Code<CompartmentType> value)
	{
		var a_ = value?.Value;

		return a_;
	}


    [CqlDeclaration("ToString")]
    public Composition.CompositionAttestationMode? ToString(Code<Composition.CompositionAttestationMode> value)
	{
		var a_ = value?.Value;

		return a_;
	}


    [CqlDeclaration("ToString")]
    public CompositionStatus? ToString(Code<CompositionStatus> value)
	{
		var a_ = value?.Value;

		return a_;
	}


    [CqlDeclaration("ToString")]
    public ConceptMapEquivalence? ToString(Code<ConceptMapEquivalence> value)
	{
		var a_ = value?.Value;

		return a_;
	}


    [CqlDeclaration("ToString")]
    public ConceptMap.ConceptMapGroupUnmappedMode? ToString(Code<ConceptMap.ConceptMapGroupUnmappedMode> value)
	{
		var a_ = value?.Value;

		return a_;
	}


    [CqlDeclaration("ToString")]
    public CapabilityStatement.ConditionalDeleteStatus? ToString(Code<CapabilityStatement.ConditionalDeleteStatus> value)
	{
		var a_ = value?.Value;

		return a_;
	}


    [CqlDeclaration("ToString")]
    public CapabilityStatement.ConditionalReadStatus? ToString(Code<CapabilityStatement.ConditionalReadStatus> value)
	{
		var a_ = value?.Value;

		return a_;
	}


    [CqlDeclaration("ToString")]
    public Consent.ConsentDataMeaning? ToString(Code<Consent.ConsentDataMeaning> value)
	{
		var a_ = value?.Value;

		return a_;
	}


    [CqlDeclaration("ToString")]
    public Consent.ConsentProvisionType? ToString(Code<Consent.ConsentProvisionType> value)
	{
		var a_ = value?.Value;

		return a_;
	}


    [CqlDeclaration("ToString")]
    public Consent.ConsentState? ToString(Code<Consent.ConsentState> value)
	{
		var a_ = value?.Value;

		return a_;
	}


    [CqlDeclaration("ToString")]
    public ConstraintSeverity? ToString(Code<ConstraintSeverity> value)
	{
		var a_ = value?.Value;

		return a_;
	}


    [CqlDeclaration("ToString")]
    public ContactPoint.ContactPointSystem? ToString(Code<ContactPoint.ContactPointSystem> value)
	{
		var a_ = value?.Value;

		return a_;
	}


    [CqlDeclaration("ToString")]
    public ContactPoint.ContactPointUse? ToString(Code<ContactPoint.ContactPointUse> value)
	{
		var a_ = value?.Value;

		return a_;
	}


    [CqlDeclaration("ToString")]
    public Contract.ContractResourcePublicationStatusCodes? ToString(Code<Contract.ContractResourcePublicationStatusCodes> value)
	{
		var a_ = value?.Value;

		return a_;
	}


    [CqlDeclaration("ToString")]
    public Contract.ContractResourceStatusCodes? ToString(Code<Contract.ContractResourceStatusCodes> value)
	{
		var a_ = value?.Value;

		return a_;
	}


    [CqlDeclaration("ToString")]
    public Contributor.ContributorType? ToString(Code<Contributor.ContributorType> value)
	{
		var a_ = value?.Value;

		return a_;
	}


    [CqlDeclaration("ToString")]
    public Money.Currencies? ToString(Code<Money.Currencies> value)
	{
		var a_ = value?.Value;

		return a_;
	}


    [CqlDeclaration("ToString")]
    public DaysOfWeek? ToString(Code<DaysOfWeek> value)
	{
		var a_ = value?.Value;

		return a_;
	}


    [CqlDeclaration("ToString")]
    public DetectedIssue.DetectedIssueSeverity? ToString(Code<DetectedIssue.DetectedIssueSeverity> value)
	{
		var a_ = value?.Value;

		return a_;
	}


    [CqlDeclaration("ToString")]
    public ObservationStatus? ToString(Code<ObservationStatus> value)
	{
		var a_ = value?.Value;

		return a_;
	}


    [CqlDeclaration("ToString")]
    public DeviceMetric.DeviceMetricCalibrationState? ToString(Code<DeviceMetric.DeviceMetricCalibrationState> value)
	{
		var a_ = value?.Value;

		return a_;
	}


    [CqlDeclaration("ToString")]
    public DeviceMetric.DeviceMetricCalibrationType? ToString(Code<DeviceMetric.DeviceMetricCalibrationType> value)
	{
		var a_ = value?.Value;

		return a_;
	}


    [CqlDeclaration("ToString")]
    public DeviceMetric.DeviceMetricCategory? ToString(Code<DeviceMetric.DeviceMetricCategory> value)
	{
		var a_ = value?.Value;

		return a_;
	}


    [CqlDeclaration("ToString")]
    public DeviceMetric.DeviceMetricColor? ToString(Code<DeviceMetric.DeviceMetricColor> value)
	{
		var a_ = value?.Value;

		return a_;
	}


    [CqlDeclaration("ToString")]
    public DeviceMetric.DeviceMetricOperationalStatus? ToString(Code<DeviceMetric.DeviceMetricOperationalStatus> value)
	{
		var a_ = value?.Value;

		return a_;
	}


    [CqlDeclaration("ToString")]
    public DeviceNameType? ToString(Code<DeviceNameType> value)
	{
		var a_ = value?.Value;

		return a_;
	}


    [CqlDeclaration("ToString")]
    public DeviceUseStatement.DeviceUseStatementStatus? ToString(Code<DeviceUseStatement.DeviceUseStatementStatus> value)
	{
		var a_ = value?.Value;

		return a_;
	}


    [CqlDeclaration("ToString")]
    public DiagnosticReport.DiagnosticReportStatus? ToString(Code<DiagnosticReport.DiagnosticReportStatus> value)
	{
		var a_ = value?.Value;

		return a_;
	}


    [CqlDeclaration("ToString")]
    public ElementDefinition.DiscriminatorType? ToString(Code<ElementDefinition.DiscriminatorType> value)
	{
		var a_ = value?.Value;

		return a_;
	}


    [CqlDeclaration("ToString")]
    public Composition.V3ConfidentialityClassification? ToString(Code<Composition.V3ConfidentialityClassification> value)
	{
		var a_ = value?.Value;

		return a_;
	}


    [CqlDeclaration("ToString")]
    public CapabilityStatement.DocumentMode? ToString(Code<CapabilityStatement.DocumentMode> value)
	{
		var a_ = value?.Value;

		return a_;
	}


    [CqlDeclaration("ToString")]
    public DocumentReferenceStatus? ToString(Code<DocumentReferenceStatus> value)
	{
		var a_ = value?.Value;

		return a_;
	}


    [CqlDeclaration("ToString")]
    public DocumentRelationshipType? ToString(Code<DocumentRelationshipType> value)
	{
		var a_ = value?.Value;

		return a_;
	}


    [CqlDeclaration("ToString")]
    public CoverageEligibilityRequest.EligibilityRequestPurpose? ToString(Code<CoverageEligibilityRequest.EligibilityRequestPurpose> value)
	{
		var a_ = value?.Value;

		return a_;
	}


    [CqlDeclaration("ToString")]
    public CoverageEligibilityResponse.EligibilityResponsePurpose? ToString(Code<CoverageEligibilityResponse.EligibilityResponsePurpose> value)
	{
		var a_ = value?.Value;

		return a_;
	}


    [CqlDeclaration("ToString")]
    public Questionnaire.EnableWhenBehavior? ToString(Code<Questionnaire.EnableWhenBehavior> value)
	{
		var a_ = value?.Value;

		return a_;
	}


    [CqlDeclaration("ToString")]
    public Encounter.EncounterLocationStatus? ToString(Code<Encounter.EncounterLocationStatus> value)
	{
		var a_ = value?.Value;

		return a_;
	}


    [CqlDeclaration("ToString")]
    public Encounter.EncounterStatus? ToString(Code<Encounter.EncounterStatus> value)
	{
		var a_ = value?.Value;

		return a_;
	}


    [CqlDeclaration("ToString")]
    public Endpoint.EndpointStatus? ToString(Code<Endpoint.EndpointStatus> value)
	{
		var a_ = value?.Value;

		return a_;
	}


    [CqlDeclaration("ToString")]
    public EpisodeOfCare.EpisodeOfCareStatus? ToString(Code<EpisodeOfCare.EpisodeOfCareStatus> value)
	{
		var a_ = value?.Value;

		return a_;
	}


    [CqlDeclaration("ToString")]
    public CapabilityStatement.EventCapabilityMode? ToString(Code<CapabilityStatement.EventCapabilityMode> value)
	{
		var a_ = value?.Value;

		return a_;
	}


    [CqlDeclaration("ToString")]
    public Timing.EventTiming? ToString(Code<Timing.EventTiming> value)
	{
		var a_ = value?.Value;

		return a_;
	}


    [CqlDeclaration("ToString")]
    public VariableTypeCode? ToString(Code<VariableTypeCode> value)
	{
		var a_ = value?.Value;

		return a_;
	}


    [CqlDeclaration("ToString")]
    public ExampleScenario.ExampleScenarioActorType? ToString(Code<ExampleScenario.ExampleScenarioActorType> value)
	{
		var a_ = value?.Value;

		return a_;
	}


    [CqlDeclaration("ToString")]
    public ExplanationOfBenefit.ExplanationOfBenefitStatus? ToString(Code<ExplanationOfBenefit.ExplanationOfBenefitStatus> value)
	{
		var a_ = value?.Value;

		return a_;
	}


    [CqlDeclaration("ToString")]
    public EffectEvidenceSynthesis.ExposureStateCode? ToString(Code<EffectEvidenceSynthesis.ExposureStateCode> value)
	{
		var a_ = value?.Value;

		return a_;
	}


    [CqlDeclaration("ToString")]
    public StructureDefinition.ExtensionContextType? ToString(Code<StructureDefinition.ExtensionContextType> value)
	{
		var a_ = value?.Value;

		return a_;
	}


    [CqlDeclaration("ToString")]
    public FHIRAllTypes? ToString(Code<FHIRAllTypes> value)
	{
		var a_ = value?.Value;

		return a_;
	}


    [CqlDeclaration("ToString")]
    public FHIRDefinedType? ToString(Code<FHIRDefinedType> value)
	{
		var a_ = value?.Value;

		return a_;
	}


    [CqlDeclaration("ToString")]
    public Device.FHIRDeviceStatus? ToString(Code<Device.FHIRDeviceStatus> value)
	{
		var a_ = value?.Value;

		return a_;
	}


    [CqlDeclaration("ToString")]
    public ResourceType? ToString(Code<ResourceType> value)
	{
		var a_ = value?.Value;

		return a_;
	}


    [CqlDeclaration("ToString")]
    public Substance.FHIRSubstanceStatus? ToString(Code<Substance.FHIRSubstanceStatus> value)
	{
		var a_ = value?.Value;

		return a_;
	}


    [CqlDeclaration("ToString")]
    public FHIRVersion? ToString(Code<FHIRVersion> value)
	{
		var a_ = value?.Value;

		return a_;
	}


    [CqlDeclaration("ToString")]
    public FamilyMemberHistory.FamilyHistoryStatus? ToString(Code<FamilyMemberHistory.FamilyHistoryStatus> value)
	{
		var a_ = value?.Value;

		return a_;
	}


    [CqlDeclaration("ToString")]
    public FilterOperator? ToString(Code<FilterOperator> value)
	{
		var a_ = value?.Value;

		return a_;
	}


    [CqlDeclaration("ToString")]
    public Flag.FlagStatus? ToString(Code<Flag.FlagStatus> value)
	{
		var a_ = value?.Value;

		return a_;
	}


    [CqlDeclaration("ToString")]
    public Goal.GoalLifecycleStatus? ToString(Code<Goal.GoalLifecycleStatus> value)
	{
		var a_ = value?.Value;

		return a_;
	}


    [CqlDeclaration("ToString")]
    public GraphDefinition.GraphCompartmentRule? ToString(Code<GraphDefinition.GraphCompartmentRule> value)
	{
		var a_ = value?.Value;

		return a_;
	}


    [CqlDeclaration("ToString")]
    public GraphDefinition.GraphCompartmentUse? ToString(Code<GraphDefinition.GraphCompartmentUse> value)
	{
		var a_ = value?.Value;

		return a_;
	}


    [CqlDeclaration("ToString")]
    public GroupMeasureCode? ToString(Code<GroupMeasureCode> value)
	{
		var a_ = value?.Value;

		return a_;
	}


    [CqlDeclaration("ToString")]
    public Group.GroupType? ToString(Code<Group.GroupType> value)
	{
		var a_ = value?.Value;

		return a_;
	}


    [CqlDeclaration("ToString")]
    public GuidanceResponse.GuidanceResponseStatus? ToString(Code<GuidanceResponse.GuidanceResponseStatus> value)
	{
		var a_ = value?.Value;

		return a_;
	}


    [CqlDeclaration("ToString")]
    public ImplementationGuide.GuidePageGeneration? ToString(Code<ImplementationGuide.GuidePageGeneration> value)
	{
		var a_ = value?.Value;

		return a_;
	}


    [CqlDeclaration("ToString")]
    public ImplementationGuide.GuideParameterCode? ToString(Code<ImplementationGuide.GuideParameterCode> value)
	{
		var a_ = value?.Value;

		return a_;
	}


    [CqlDeclaration("ToString")]
    public Bundle.HTTPVerb? ToString(Code<Bundle.HTTPVerb> value)
	{
		var a_ = value?.Value;

		return a_;
	}


    [CqlDeclaration("ToString")]
    public Identifier.IdentifierUse? ToString(Code<Identifier.IdentifierUse> value)
	{
		var a_ = value?.Value;

		return a_;
	}


    [CqlDeclaration("ToString")]
    public Person.IdentityAssuranceLevel? ToString(Code<Person.IdentityAssuranceLevel> value)
	{
		var a_ = value?.Value;

		return a_;
	}


    [CqlDeclaration("ToString")]
    public ImagingStudy.ImagingStudyStatus? ToString(Code<ImagingStudy.ImagingStudyStatus> value)
	{
		var a_ = value?.Value;

		return a_;
	}


    [CqlDeclaration("ToString")]
    public ImmunizationEvaluation.ImmunizationEvaluationStatusCodes? ToString(Code<ImmunizationEvaluation.ImmunizationEvaluationStatusCodes> value)
	{
		var a_ = value?.Value;

		return a_;
	}


    [CqlDeclaration("ToString")]
    public Immunization.ImmunizationStatusCodes? ToString(Code<Immunization.ImmunizationStatusCodes> value)
	{
		var a_ = value?.Value;

		return a_;
	}


    [CqlDeclaration("ToString")]
    public Invoice.InvoiceStatus? ToString(Code<Invoice.InvoiceStatus> value)
	{
		var a_ = value?.Value;

		return a_;
	}


    [CqlDeclaration("ToString")]
    public OperationOutcome.IssueSeverity? ToString(Code<OperationOutcome.IssueSeverity> value)
	{
		var a_ = value?.Value;

		return a_;
	}


    [CqlDeclaration("ToString")]
    public OperationOutcome.IssueType? ToString(Code<OperationOutcome.IssueType> value)
	{
		var a_ = value?.Value;

		return a_;
	}


    [CqlDeclaration("ToString")]
    public Patient.LinkType? ToString(Code<Patient.LinkType> value)
	{
		var a_ = value?.Value;

		return a_;
	}


    [CqlDeclaration("ToString")]
    public Linkage.LinkageType? ToString(Code<Linkage.LinkageType> value)
	{
		var a_ = value?.Value;

		return a_;
	}


    [CqlDeclaration("ToString")]
    public ListMode? ToString(Code<ListMode> value)
	{
		var a_ = value?.Value;

		return a_;
	}


    [CqlDeclaration("ToString")]
    public List.ListStatus? ToString(Code<List.ListStatus> value)
	{
		var a_ = value?.Value;

		return a_;
	}


    [CqlDeclaration("ToString")]
    public Location.LocationMode? ToString(Code<Location.LocationMode> value)
	{
		var a_ = value?.Value;

		return a_;
	}


    [CqlDeclaration("ToString")]
    public Location.LocationStatus? ToString(Code<Location.LocationStatus> value)
	{
		var a_ = value?.Value;

		return a_;
	}


    [CqlDeclaration("ToString")]
    public MeasureReport.MeasureReportStatus? ToString(Code<MeasureReport.MeasureReportStatus> value)
	{
		var a_ = value?.Value;

		return a_;
	}


    [CqlDeclaration("ToString")]
    public MeasureReport.MeasureReportType? ToString(Code<MeasureReport.MeasureReportType> value)
	{
		var a_ = value?.Value;

		return a_;
	}


    [CqlDeclaration("ToString")]
    public MedicationAdministration.MedicationAdministrationStatusCodes? ToString(Code<MedicationAdministration.MedicationAdministrationStatusCodes> value)
	{
		var a_ = value?.Value;

		return a_;
	}


    [CqlDeclaration("ToString")]
    public MedicationDispense.MedicationDispenseStatusCodes? ToString(Code<MedicationDispense.MedicationDispenseStatusCodes> value)
	{
		var a_ = value?.Value;

		return a_;
	}


    [CqlDeclaration("ToString")]
    public MedicationKnowledge.MedicationKnowledgeStatusCodes? ToString(Code<MedicationKnowledge.MedicationKnowledgeStatusCodes> value)
	{
		var a_ = value?.Value;

		return a_;
	}


    [CqlDeclaration("ToString")]
    public MedicationRequest.MedicationRequestIntent? ToString(Code<MedicationRequest.MedicationRequestIntent> value)
	{
		var a_ = value?.Value;

		return a_;
	}


    [CqlDeclaration("ToString")]
    public MedicationRequest.MedicationrequestStatus? ToString(Code<MedicationRequest.MedicationrequestStatus> value)
	{
		var a_ = value?.Value;

		return a_;
	}


    [CqlDeclaration("ToString")]
    public MedicationStatement.MedicationStatusCodes? ToString(Code<MedicationStatement.MedicationStatusCodes> value)
	{
		var a_ = value?.Value;

		return a_;
	}


    [CqlDeclaration("ToString")]
    public Medication.MedicationStatusCodes? ToString(Code<Medication.MedicationStatusCodes> value)
	{
		var a_ = value?.Value;

		return a_;
	}


    [CqlDeclaration("ToString")]
    public MessageDefinition.MessageSignificanceCategory? ToString(Code<MessageDefinition.MessageSignificanceCategory> value)
	{
		var a_ = value?.Value;

		return a_;
	}


    [CqlDeclaration("ToString")]
    public MessageheaderResponseRequest? ToString(Code<MessageheaderResponseRequest> value)
	{
		var a_ = value?.Value;

		return a_;
	}


    [CqlDeclaration("ToString")]
    public string ToString(Code value)
	{
		var a_ = value?.Value;

		return a_;
	}


    [CqlDeclaration("ToString")]
    public HumanName.NameUse? ToString(Code<HumanName.NameUse> value)
	{
		var a_ = value?.Value;

		return a_;
	}


    [CqlDeclaration("ToString")]
    public NamingSystem.NamingSystemIdentifierType? ToString(Code<NamingSystem.NamingSystemIdentifierType> value)
	{
		var a_ = value?.Value;

		return a_;
	}


    [CqlDeclaration("ToString")]
    public NamingSystem.NamingSystemType? ToString(Code<NamingSystem.NamingSystemType> value)
	{
		var a_ = value?.Value;

		return a_;
	}


    [CqlDeclaration("ToString")]
    public Narrative.NarrativeStatus? ToString(Code<Narrative.NarrativeStatus> value)
	{
		var a_ = value?.Value;

		return a_;
	}


    [CqlDeclaration("ToString")]
    public NoteType? ToString(Code<NoteType> value)
	{
		var a_ = value?.Value;

		return a_;
	}


    [CqlDeclaration("ToString")]
    public RequestIntent? ToString(Code<RequestIntent> value)
	{
		var a_ = value?.Value;

		return a_;
	}


    [CqlDeclaration("ToString")]
    public ObservationDefinition.ObservationDataType? ToString(Code<ObservationDefinition.ObservationDataType> value)
	{
		var a_ = value?.Value;

		return a_;
	}


    [CqlDeclaration("ToString")]
    public ObservationDefinition.ObservationRangeCategory? ToString(Code<ObservationDefinition.ObservationRangeCategory> value)
	{
		var a_ = value?.Value;

		return a_;
	}


    [CqlDeclaration("ToString")]
    public OperationDefinition.OperationKind? ToString(Code<OperationDefinition.OperationKind> value)
	{
		var a_ = value?.Value;

		return a_;
	}


    [CqlDeclaration("ToString")]
    public OperationParameterUse? ToString(Code<OperationParameterUse> value)
	{
		var a_ = value?.Value;

		return a_;
	}


    [CqlDeclaration("ToString")]
    public MolecularSequence.OrientationType? ToString(Code<MolecularSequence.OrientationType> value)
	{
		var a_ = value?.Value;

		return a_;
	}


    [CqlDeclaration("ToString")]
    public Appointment.ParticipantRequired? ToString(Code<Appointment.ParticipantRequired> value)
	{
		var a_ = value?.Value;

		return a_;
	}


    [CqlDeclaration("ToString")]
    public ParticipationStatus? ToString(Code<ParticipationStatus> value)
	{
		var a_ = value?.Value;

		return a_;
	}


    [CqlDeclaration("ToString")]
    public ElementDefinition.PropertyRepresentation? ToString(Code<ElementDefinition.PropertyRepresentation> value)
	{
		var a_ = value?.Value;

		return a_;
	}


    [CqlDeclaration("ToString")]
    public CodeSystem.PropertyType? ToString(Code<CodeSystem.PropertyType> value)
	{
		var a_ = value?.Value;

		return a_;
	}


    [CqlDeclaration("ToString")]
    public Provenance.ProvenanceEntityRole? ToString(Code<Provenance.ProvenanceEntityRole> value)
	{
		var a_ = value?.Value;

		return a_;
	}


    [CqlDeclaration("ToString")]
    public PublicationStatus? ToString(Code<PublicationStatus> value)
	{
		var a_ = value?.Value;

		return a_;
	}


    [CqlDeclaration("ToString")]
    public MolecularSequence.QualityType? ToString(Code<MolecularSequence.QualityType> value)
	{
		var a_ = value?.Value;

		return a_;
	}


    [CqlDeclaration("ToString")]
    public Quantity.QuantityComparator? ToString(Code<Quantity.QuantityComparator> value)
	{
		var a_ = value?.Value;

		return a_;
	}


    [CqlDeclaration("ToString")]
    public Questionnaire.QuestionnaireItemOperator? ToString(Code<Questionnaire.QuestionnaireItemOperator> value)
	{
		var a_ = value?.Value;

		return a_;
	}


    [CqlDeclaration("ToString")]
    public Questionnaire.QuestionnaireItemType? ToString(Code<Questionnaire.QuestionnaireItemType> value)
	{
		var a_ = value?.Value;

		return a_;
	}


    [CqlDeclaration("ToString")]
    public QuestionnaireResponse.QuestionnaireResponseStatus? ToString(Code<QuestionnaireResponse.QuestionnaireResponseStatus> value)
	{
		var a_ = value?.Value;

		return a_;
	}


    [CqlDeclaration("ToString")]
    public CapabilityStatement.ReferenceHandlingPolicy? ToString(Code<CapabilityStatement.ReferenceHandlingPolicy> value)
	{
		var a_ = value?.Value;

		return a_;
	}


    [CqlDeclaration("ToString")]
    public ElementDefinition.ReferenceVersionRules? ToString(Code<ElementDefinition.ReferenceVersionRules> value)
	{
		var a_ = value?.Value;

		return a_;
	}


    [CqlDeclaration("ToString")]
    public RelatedArtifact.RelatedArtifactType? ToString(Code<RelatedArtifact.RelatedArtifactType> value)
	{
		var a_ = value?.Value;

		return a_;
	}


    [CqlDeclaration("ToString")]
    public ClaimProcessingCodes? ToString(Code<ClaimProcessingCodes> value)
	{
		var a_ = value?.Value;

		return a_;
	}


    [CqlDeclaration("ToString")]
    public MolecularSequence.RepositoryType? ToString(Code<MolecularSequence.RepositoryType> value)
	{
		var a_ = value?.Value;

		return a_;
	}


    [CqlDeclaration("ToString")]
    public ResearchElementDefinition.ResearchElementType? ToString(Code<ResearchElementDefinition.ResearchElementType> value)
	{
		var a_ = value?.Value;

		return a_;
	}


    [CqlDeclaration("ToString")]
    public ResearchStudy.ResearchStudyStatus? ToString(Code<ResearchStudy.ResearchStudyStatus> value)
	{
		var a_ = value?.Value;

		return a_;
	}


    [CqlDeclaration("ToString")]
    public ResearchSubject.ResearchSubjectStatus? ToString(Code<ResearchSubject.ResearchSubjectStatus> value)
	{
		var a_ = value?.Value;

		return a_;
	}


    [CqlDeclaration("ToString")]
    public CapabilityStatement.ResourceVersionPolicy? ToString(Code<CapabilityStatement.ResourceVersionPolicy> value)
	{
		var a_ = value?.Value;

		return a_;
	}


    [CqlDeclaration("ToString")]
    public MessageHeader.ResponseType? ToString(Code<MessageHeader.ResponseType> value)
	{
		var a_ = value?.Value;

		return a_;
	}


    [CqlDeclaration("ToString")]
    public CapabilityStatement.RestfulCapabilityMode? ToString(Code<CapabilityStatement.RestfulCapabilityMode> value)
	{
		var a_ = value?.Value;

		return a_;
	}


    [CqlDeclaration("ToString")]
    public ImplementationGuide.SPDXLicense? ToString(Code<ImplementationGuide.SPDXLicense> value)
	{
		var a_ = value?.Value;

		return a_;
	}


    [CqlDeclaration("ToString")]
    public SearchParameter.SearchComparator? ToString(Code<SearchParameter.SearchComparator> value)
	{
		var a_ = value?.Value;

		return a_;
	}


    [CqlDeclaration("ToString")]
    public Bundle.SearchEntryMode? ToString(Code<Bundle.SearchEntryMode> value)
	{
		var a_ = value?.Value;

		return a_;
	}


    [CqlDeclaration("ToString")]
    public SearchParameter.SearchModifierCode? ToString(Code<SearchParameter.SearchModifierCode> value)
	{
		var a_ = value?.Value;

		return a_;
	}


    [CqlDeclaration("ToString")]
    public SearchParamType? ToString(Code<SearchParamType> value)
	{
		var a_ = value?.Value;

		return a_;
	}


    [CqlDeclaration("ToString")]
    public MolecularSequence.SequenceType? ToString(Code<MolecularSequence.SequenceType> value)
	{
		var a_ = value?.Value;

		return a_;
	}


    [CqlDeclaration("ToString")]
    public ElementDefinition.SlicingRules? ToString(Code<ElementDefinition.SlicingRules> value)
	{
		var a_ = value?.Value;

		return a_;
	}


    [CqlDeclaration("ToString")]
    public Slot.SlotStatus? ToString(Code<Slot.SlotStatus> value)
	{
		var a_ = value?.Value;

		return a_;
	}


    [CqlDeclaration("ToString")]
    public DataRequirement.SortDirection? ToString(Code<DataRequirement.SortDirection> value)
	{
		var a_ = value?.Value;

		return a_;
	}


    [CqlDeclaration("ToString")]
    public SpecimenDefinition.SpecimenContainedPreference? ToString(Code<SpecimenDefinition.SpecimenContainedPreference> value)
	{
		var a_ = value?.Value;

		return a_;
	}


    [CqlDeclaration("ToString")]
    public Specimen.SpecimenStatus? ToString(Code<Specimen.SpecimenStatus> value)
	{
		var a_ = value?.Value;

		return a_;
	}


    [CqlDeclaration("ToString")]
    public VerificationResult.StatusCode? ToString(Code<VerificationResult.StatusCode> value)
	{
		var a_ = value?.Value;

		return a_;
	}


    [CqlDeclaration("ToString")]
    public MolecularSequence.StrandType? ToString(Code<MolecularSequence.StrandType> value)
	{
		var a_ = value?.Value;

		return a_;
	}


    [CqlDeclaration("ToString")]
    public StructureDefinition.StructureDefinitionKind? ToString(Code<StructureDefinition.StructureDefinitionKind> value)
	{
		var a_ = value?.Value;

		return a_;
	}


    [CqlDeclaration("ToString")]
    public StructureMap.StructureMapContextType? ToString(Code<StructureMap.StructureMapContextType> value)
	{
		var a_ = value?.Value;

		return a_;
	}


    [CqlDeclaration("ToString")]
    public StructureMap.StructureMapGroupTypeMode? ToString(Code<StructureMap.StructureMapGroupTypeMode> value)
	{
		var a_ = value?.Value;

		return a_;
	}


    [CqlDeclaration("ToString")]
    public StructureMap.StructureMapInputMode? ToString(Code<StructureMap.StructureMapInputMode> value)
	{
		var a_ = value?.Value;

		return a_;
	}


    [CqlDeclaration("ToString")]
    public StructureMap.StructureMapModelMode? ToString(Code<StructureMap.StructureMapModelMode> value)
	{
		var a_ = value?.Value;

		return a_;
	}


    [CqlDeclaration("ToString")]
    public StructureMap.StructureMapSourceListMode? ToString(Code<StructureMap.StructureMapSourceListMode> value)
	{
		var a_ = value?.Value;

		return a_;
	}


    [CqlDeclaration("ToString")]
    public StructureMap.StructureMapTargetListMode? ToString(Code<StructureMap.StructureMapTargetListMode> value)
	{
		var a_ = value?.Value;

		return a_;
	}


    [CqlDeclaration("ToString")]
    public StructureMap.StructureMapTransform? ToString(Code<StructureMap.StructureMapTransform> value)
	{
		var a_ = value?.Value;

		return a_;
	}


    [CqlDeclaration("ToString")]
    public Subscription.SubscriptionChannelType? ToString(Code<Subscription.SubscriptionChannelType> value)
	{
		var a_ = value?.Value;

		return a_;
	}


    [CqlDeclaration("ToString")]
    public Subscription.SubscriptionStatus? ToString(Code<Subscription.SubscriptionStatus> value)
	{
		var a_ = value?.Value;

		return a_;
	}


    [CqlDeclaration("ToString")]
    public SupplyDelivery.SupplyDeliveryStatus? ToString(Code<SupplyDelivery.SupplyDeliveryStatus> value)
	{
		var a_ = value?.Value;

		return a_;
	}


    [CqlDeclaration("ToString")]
    public SupplyRequest.SupplyRequestStatus? ToString(Code<SupplyRequest.SupplyRequestStatus> value)
	{
		var a_ = value?.Value;

		return a_;
	}


    [CqlDeclaration("ToString")]
    public CapabilityStatement.SystemRestfulInteraction? ToString(Code<CapabilityStatement.SystemRestfulInteraction> value)
	{
		var a_ = value?.Value;

		return a_;
	}


    [CqlDeclaration("ToString")]
    public Task.TaskIntent? ToString(Code<Task.TaskIntent> value)
	{
		var a_ = value?.Value;

		return a_;
	}


    [CqlDeclaration("ToString")]
    public Task.TaskStatus? ToString(Code<Task.TaskStatus> value)
	{
		var a_ = value?.Value;

		return a_;
	}


    [CqlDeclaration("ToString")]
    public TestReport.TestReportActionResult? ToString(Code<TestReport.TestReportActionResult> value)
	{
		var a_ = value?.Value;

		return a_;
	}


    [CqlDeclaration("ToString")]
    public TestReport.TestReportParticipantType? ToString(Code<TestReport.TestReportParticipantType> value)
	{
		var a_ = value?.Value;

		return a_;
	}


    [CqlDeclaration("ToString")]
    public TestReport.TestReportResult? ToString(Code<TestReport.TestReportResult> value)
	{
		var a_ = value?.Value;

		return a_;
	}


    [CqlDeclaration("ToString")]
    public TestReport.TestReportStatus? ToString(Code<TestReport.TestReportStatus> value)
	{
		var a_ = value?.Value;

		return a_;
	}


    [CqlDeclaration("ToString")]
    public TestScript.TestScriptRequestMethodCode? ToString(Code<TestScript.TestScriptRequestMethodCode> value)
	{
		var a_ = value?.Value;

		return a_;
	}


    [CqlDeclaration("ToString")]
    public TriggerDefinition.TriggerType? ToString(Code<TriggerDefinition.TriggerType> value)
	{
		var a_ = value?.Value;

		return a_;
	}


    [CqlDeclaration("ToString")]
    public StructureDefinition.TypeDerivationRule? ToString(Code<StructureDefinition.TypeDerivationRule> value)
	{
		var a_ = value?.Value;

		return a_;
	}


    [CqlDeclaration("ToString")]
    public CapabilityStatement.TypeRestfulInteraction? ToString(Code<CapabilityStatement.TypeRestfulInteraction> value)
	{
		var a_ = value?.Value;

		return a_;
	}


    [CqlDeclaration("ToString")]
    public Device.UDIEntryType? ToString(Code<Device.UDIEntryType> value)
	{
		var a_ = value?.Value;

		return a_;
	}


    [CqlDeclaration("ToString")]
    public Timing.UnitsOfTime? ToString(Code<Timing.UnitsOfTime> value)
	{
		var a_ = value?.Value;

		return a_;
	}


    [CqlDeclaration("ToString")]
    public ClaimUseCode? ToString(Code<ClaimUseCode> value)
	{
		var a_ = value?.Value;

		return a_;
	}


    [CqlDeclaration("ToString")]
    public VisionPrescription.VisionBase? ToString(Code<VisionPrescription.VisionBase> value)
	{
		var a_ = value?.Value;

		return a_;
	}


    [CqlDeclaration("ToString")]
    public VisionPrescription.VisionEyes? ToString(Code<VisionPrescription.VisionEyes> value)
	{
		var a_ = value?.Value;

		return a_;
	}


    [CqlDeclaration("ToString")]
    public SearchParameter.XPathUsageType? ToString(Code<SearchParameter.XPathUsageType> value)
	{
		var a_ = value?.Value;

		return a_;
	}


    [CqlDeclaration("ToString")]
    public string ToString(Base64Binary value)
	{
		var a_ = value?.Value;
		var b_ = context.Operators;
		var c_ = b_.TypeConverter;
		var d_ = c_.Convert<string>(a_);

		return d_;
	}


    [CqlDeclaration("ToString")]
    public string ToString(Id value)
	{
		var a_ = value?.Value;

		return a_;
	}


    [CqlDeclaration("ToString")]
    public string ToString(FhirString value)
	{
		var a_ = value?.Value;

		return a_;
	}


    [CqlDeclaration("ToString")]
    public string ToString(FhirUri value)
	{
		var a_ = value?.Value;

		return a_;
	}


    [CqlDeclaration("ToString")]
    public string ToString(XHtml value)
	{
		var a_ = value?.Value;

		return a_;
	}


    [CqlDeclaration("ToBoolean")]
    public bool? ToBoolean(FhirBoolean value)
	{
		var a_ = value?.Value;

		return a_;
	}


    [CqlDeclaration("ToDate")]
    public CqlDate ToDate(Date value)
	{
		var a_ = value?.Value;
		var b_ = context.Operators;
		var c_ = b_.ConvertStringToDate(a_);

		return c_;
	}


    [CqlDeclaration("ToDateTime")]
    public CqlDateTime ToDateTime(FhirDateTime value)
	{
		var a_ = value?.Value;
		var b_ = context.Operators;
		var c_ = b_.ConvertStringToDateTime(a_);

		return c_;
	}


    [CqlDeclaration("ToDateTime")]
    public CqlDateTime ToDateTime(Instant value)
	{
		var a_ = value?.Value;
		var b_ = context.Operators;
		var c_ = b_.TypeConverter;
		var d_ = c_.Convert<CqlDateTime>(a_);

		return d_;
	}


    [CqlDeclaration("ToDecimal")]
    public decimal? ToDecimal(FhirDecimal value)
	{
		var a_ = value?.Value;

		return a_;
	}


    [CqlDeclaration("ToInteger")]
    public int? ToInteger(Integer value)
	{
		var a_ = value?.Value;

		return a_;
	}


    [CqlDeclaration("ToTime")]
    public CqlTime ToTime(Time value)
	{
		var a_ = value?.Value;
		var b_ = context.Operators;
		var c_ = b_.ConvertStringToTime(a_);

		return c_;
	}


}
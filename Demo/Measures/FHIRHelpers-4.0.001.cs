using System;
using System.Linq;
using System.Collections.Generic;
using Hl7.Cql.Runtime;
using Hl7.Cql.Primitives;
using Hl7.Cql.Abstractions;
using Hl7.Cql.ValueSets;
using Hl7.Cql.Iso8601;
using Hl7.Fhir.Model;
using Range = Hl7.Fhir.Model.Range;
using Task = Hl7.Fhir.Model.Task;
[System.CodeDom.Compiler.GeneratedCode(".NET Code Generation", "1.0.0.0")]
[CqlLibrary("FHIRHelpers", "4.0.001")]
public class FHIRHelpers_4_0_001
{

    public static FHIRHelpers_4_0_001 Instance { get; }  = new();

    [CqlDeclaration("Patient")]
	public Patient Patient(CqlContext context)
	{
		var a_ = context.Operators.RetrieveByValueSet<Patient>(null, null);
		var b_ = context.Operators.SingleOrNull<Patient>(a_);

		return b_;
	}

    [CqlDeclaration("ToInterval")]
	public CqlInterval<CqlDateTime> ToInterval(CqlContext context, Period period)
	{
		CqlInterval<CqlDateTime> a_()
		{
			if ((period is null))
			{
				CqlInterval<CqlDateTime> b_ = null;

				return (b_ as CqlInterval<CqlDateTime>);
			}
			else
			{
				var c_ = context.Operators.Convert<CqlDateTime>(period?.StartElement);
				var d_ = context.Operators.Convert<CqlDateTime>(period?.EndElement);
				var e_ = context.Operators.Interval(c_, d_, true, true);

				return e_;
			};
		};

		return a_();
	}

    [CqlDeclaration("ToInterval")]
	public CqlInterval<CqlQuantity> ToInterval(CqlContext context, Range range)
	{
		CqlInterval<CqlQuantity> a_()
		{
			if ((range is null))
			{
				CqlInterval<CqlQuantity> b_ = null;

				return (b_ as CqlInterval<CqlQuantity>);
			}
			else
			{
				var c_ = this.ToQuantity(context, range?.Low);
				var d_ = this.ToQuantity(context, range?.High);
				var e_ = context.Operators.Interval(c_, d_, true, true);

				return e_;
			};
		};

		return a_();
	}

    [CqlDeclaration("ToQuantity")]
	public CqlQuantity ToQuantity(CqlContext context, Quantity quantity) => 
		((quantity is null)
			? null
			: (new CqlQuantity(quantity?.ValueElement?.Value, quantity?.UnitElement?.Value)));

    [CqlDeclaration("ToRatio")]
	public CqlRatio ToRatio(CqlContext context, Ratio ratio)
	{
		CqlRatio a_()
		{
			if ((ratio is null))
			{
				return null;
			}
			else
			{
				var b_ = this.ToQuantity(context, ratio?.Numerator);
				var c_ = this.ToQuantity(context, ratio?.Denominator);

				return new CqlRatio(b_, c_);
			};
		};

		return a_();
	}

    [CqlDeclaration("ToCode")]
	public CqlCode ToCode(CqlContext context, Coding coding) => 
		((coding is null)
			? null
			: (new CqlCode(coding?.CodeElement?.Value, coding?.SystemElement?.Value, coding?.VersionElement?.Value, coding?.DisplayElement?.Value)));

    [CqlDeclaration("ToConcept")]
	public CqlConcept ToConcept(CqlContext context, CodeableConcept concept)
	{
		CqlConcept a_()
		{
			if ((concept is null))
			{
				return null;
			}
			else
			{
				CqlCode b_(Coding C)
				{
					var d_ = this.ToCode(context, C);

					return d_;
				};
				var c_ = context.Operators.SelectOrNull<Coding, CqlCode>((concept?.Coding as IEnumerable<Coding>), b_);

				return new CqlConcept(c_, concept?.TextElement?.Value);
			};
		};

		return a_();
	}

    [CqlDeclaration("ToString")]
	public Account.AccountStatus? ToString(CqlContext context, Code<Account.AccountStatus> value) => 
		value?.Value;

    [CqlDeclaration("ToString")]
	public ActionCardinalityBehavior? ToString(CqlContext context, Code<ActionCardinalityBehavior> value) => 
		value?.Value;

    [CqlDeclaration("ToString")]
	public ActionConditionKind? ToString(CqlContext context, Code<ActionConditionKind> value) => 
		value?.Value;

    [CqlDeclaration("ToString")]
	public ActionGroupingBehavior? ToString(CqlContext context, Code<ActionGroupingBehavior> value) => 
		value?.Value;

    [CqlDeclaration("ToString")]
	public ActionParticipantType? ToString(CqlContext context, Code<ActionParticipantType> value) => 
		value?.Value;

    [CqlDeclaration("ToString")]
	public ActionPrecheckBehavior? ToString(CqlContext context, Code<ActionPrecheckBehavior> value) => 
		value?.Value;

    [CqlDeclaration("ToString")]
	public ActionRelationshipType? ToString(CqlContext context, Code<ActionRelationshipType> value) => 
		value?.Value;

    [CqlDeclaration("ToString")]
	public ActionRequiredBehavior? ToString(CqlContext context, Code<ActionRequiredBehavior> value) => 
		value?.Value;

    [CqlDeclaration("ToString")]
	public ActionSelectionBehavior? ToString(CqlContext context, Code<ActionSelectionBehavior> value) => 
		value?.Value;

    [CqlDeclaration("ToString")]
	public ActivityDefinition.RequestResourceType? ToString(CqlContext context, Code<ActivityDefinition.RequestResourceType> value) => 
		value?.Value;

    [CqlDeclaration("ToString")]
	public Address.AddressType? ToString(CqlContext context, Code<Address.AddressType> value) => 
		value?.Value;

    [CqlDeclaration("ToString")]
	public Address.AddressUse? ToString(CqlContext context, Code<Address.AddressUse> value) => 
		value?.Value;

    [CqlDeclaration("ToString")]
	public AdministrativeGender? ToString(CqlContext context, Code<AdministrativeGender> value) => 
		value?.Value;

    [CqlDeclaration("ToString")]
	public AdverseEvent.AdverseEventActuality? ToString(CqlContext context, Code<AdverseEvent.AdverseEventActuality> value) => 
		value?.Value;

    [CqlDeclaration("ToString")]
	public ElementDefinition.AggregationMode? ToString(CqlContext context, Code<ElementDefinition.AggregationMode> value) => 
		value?.Value;

    [CqlDeclaration("ToString")]
	public AllergyIntolerance.AllergyIntoleranceCategory? ToString(CqlContext context, Code<AllergyIntolerance.AllergyIntoleranceCategory> value) => 
		value?.Value;

    [CqlDeclaration("ToString")]
	public AllergyIntolerance.AllergyIntoleranceCriticality? ToString(CqlContext context, Code<AllergyIntolerance.AllergyIntoleranceCriticality> value) => 
		value?.Value;

    [CqlDeclaration("ToString")]
	public AllergyIntolerance.AllergyIntoleranceSeverity? ToString(CqlContext context, Code<AllergyIntolerance.AllergyIntoleranceSeverity> value) => 
		value?.Value;

    [CqlDeclaration("ToString")]
	public AllergyIntolerance.AllergyIntoleranceType? ToString(CqlContext context, Code<AllergyIntolerance.AllergyIntoleranceType> value) => 
		value?.Value;

    [CqlDeclaration("ToString")]
	public Appointment.AppointmentStatus? ToString(CqlContext context, Code<Appointment.AppointmentStatus> value) => 
		value?.Value;

    [CqlDeclaration("ToString")]
	public TestScript.AssertionDirectionType? ToString(CqlContext context, Code<TestScript.AssertionDirectionType> value) => 
		value?.Value;

    [CqlDeclaration("ToString")]
	public TestScript.AssertionOperatorType? ToString(CqlContext context, Code<TestScript.AssertionOperatorType> value) => 
		value?.Value;

    [CqlDeclaration("ToString")]
	public TestScript.AssertionResponseTypes? ToString(CqlContext context, Code<TestScript.AssertionResponseTypes> value) => 
		value?.Value;

    [CqlDeclaration("ToString")]
	public AuditEvent.AuditEventAction? ToString(CqlContext context, Code<AuditEvent.AuditEventAction> value) => 
		value?.Value;

    [CqlDeclaration("ToString")]
	public AuditEvent.AuditEventAgentNetworkType? ToString(CqlContext context, Code<AuditEvent.AuditEventAgentNetworkType> value) => 
		value?.Value;

    [CqlDeclaration("ToString")]
	public AuditEvent.AuditEventOutcome? ToString(CqlContext context, Code<AuditEvent.AuditEventOutcome> value) => 
		value?.Value;

    [CqlDeclaration("ToString")]
	public BindingStrength? ToString(CqlContext context, Code<BindingStrength> value) => 
		value?.Value;

    [CqlDeclaration("ToString")]
	public BiologicallyDerivedProduct.BiologicallyDerivedProductCategory? ToString(CqlContext context, Code<BiologicallyDerivedProduct.BiologicallyDerivedProductCategory> value) => 
		value?.Value;

    [CqlDeclaration("ToString")]
	public BiologicallyDerivedProduct.BiologicallyDerivedProductStatus? ToString(CqlContext context, Code<BiologicallyDerivedProduct.BiologicallyDerivedProductStatus> value) => 
		value?.Value;

    [CqlDeclaration("ToString")]
	public BiologicallyDerivedProduct.BiologicallyDerivedProductStorageScale? ToString(CqlContext context, Code<BiologicallyDerivedProduct.BiologicallyDerivedProductStorageScale> value) => 
		value?.Value;

    [CqlDeclaration("ToString")]
	public Bundle.BundleType? ToString(CqlContext context, Code<Bundle.BundleType> value) => 
		value?.Value;

    [CqlDeclaration("ToString")]
	public CapabilityStatementKind? ToString(CqlContext context, Code<CapabilityStatementKind> value) => 
		value?.Value;

    [CqlDeclaration("ToString")]
	public CarePlan.CarePlanActivityKind? ToString(CqlContext context, Code<CarePlan.CarePlanActivityKind> value) => 
		value?.Value;

    [CqlDeclaration("ToString")]
	public CarePlan.CarePlanActivityStatus? ToString(CqlContext context, Code<CarePlan.CarePlanActivityStatus> value) => 
		value?.Value;

    [CqlDeclaration("ToString")]
	public CarePlan.CarePlanIntent? ToString(CqlContext context, Code<CarePlan.CarePlanIntent> value) => 
		value?.Value;

    [CqlDeclaration("ToString")]
	public RequestStatus? ToString(CqlContext context, Code<RequestStatus> value) => 
		value?.Value;

    [CqlDeclaration("ToString")]
	public CareTeam.CareTeamStatus? ToString(CqlContext context, Code<CareTeam.CareTeamStatus> value) => 
		value?.Value;

    [CqlDeclaration("ToString")]
	public CatalogEntry.CatalogEntryRelationType? ToString(CqlContext context, Code<CatalogEntry.CatalogEntryRelationType> value) => 
		value?.Value;

    [CqlDeclaration("ToString")]
	public InvoicePriceComponentType? ToString(CqlContext context, Code<InvoicePriceComponentType> value) => 
		value?.Value;

    [CqlDeclaration("ToString")]
	public ChargeItem.ChargeItemStatus? ToString(CqlContext context, Code<ChargeItem.ChargeItemStatus> value) => 
		value?.Value;

    [CqlDeclaration("ToString")]
	public FinancialResourceStatusCodes? ToString(CqlContext context, Code<FinancialResourceStatusCodes> value) => 
		value?.Value;

    [CqlDeclaration("ToString")]
	public ClinicalImpression.ClinicalImpressionStatus? ToString(CqlContext context, Code<ClinicalImpression.ClinicalImpressionStatus> value) => 
		value?.Value;

    [CqlDeclaration("ToString")]
	public TerminologyCapabilities.CodeSearchSupport? ToString(CqlContext context, Code<TerminologyCapabilities.CodeSearchSupport> value) => 
		value?.Value;

    [CqlDeclaration("ToString")]
	public CodeSystemContentMode? ToString(CqlContext context, Code<CodeSystemContentMode> value) => 
		value?.Value;

    [CqlDeclaration("ToString")]
	public CodeSystem.CodeSystemHierarchyMeaning? ToString(CqlContext context, Code<CodeSystem.CodeSystemHierarchyMeaning> value) => 
		value?.Value;

    [CqlDeclaration("ToString")]
	public RequestPriority? ToString(CqlContext context, Code<RequestPriority> value) => 
		value?.Value;

    [CqlDeclaration("ToString")]
	public EventStatus? ToString(CqlContext context, Code<EventStatus> value) => 
		value?.Value;

    [CqlDeclaration("ToString")]
	public CompartmentType? ToString(CqlContext context, Code<CompartmentType> value) => 
		value?.Value;

    [CqlDeclaration("ToString")]
	public Composition.CompositionAttestationMode? ToString(CqlContext context, Code<Composition.CompositionAttestationMode> value) => 
		value?.Value;

    [CqlDeclaration("ToString")]
	public CompositionStatus? ToString(CqlContext context, Code<CompositionStatus> value) => 
		value?.Value;

    [CqlDeclaration("ToString")]
	public ConceptMapEquivalence? ToString(CqlContext context, Code<ConceptMapEquivalence> value) => 
		value?.Value;

    [CqlDeclaration("ToString")]
	public ConceptMap.ConceptMapGroupUnmappedMode? ToString(CqlContext context, Code<ConceptMap.ConceptMapGroupUnmappedMode> value) => 
		value?.Value;

    [CqlDeclaration("ToString")]
	public CapabilityStatement.ConditionalDeleteStatus? ToString(CqlContext context, Code<CapabilityStatement.ConditionalDeleteStatus> value) => 
		value?.Value;

    [CqlDeclaration("ToString")]
	public CapabilityStatement.ConditionalReadStatus? ToString(CqlContext context, Code<CapabilityStatement.ConditionalReadStatus> value) => 
		value?.Value;

    [CqlDeclaration("ToString")]
	public Consent.ConsentDataMeaning? ToString(CqlContext context, Code<Consent.ConsentDataMeaning> value) => 
		value?.Value;

    [CqlDeclaration("ToString")]
	public Consent.ConsentProvisionType? ToString(CqlContext context, Code<Consent.ConsentProvisionType> value) => 
		value?.Value;

    [CqlDeclaration("ToString")]
	public Consent.ConsentState? ToString(CqlContext context, Code<Consent.ConsentState> value) => 
		value?.Value;

    [CqlDeclaration("ToString")]
	public ConstraintSeverity? ToString(CqlContext context, Code<ConstraintSeverity> value) => 
		value?.Value;

    [CqlDeclaration("ToString")]
	public ContactPoint.ContactPointSystem? ToString(CqlContext context, Code<ContactPoint.ContactPointSystem> value) => 
		value?.Value;

    [CqlDeclaration("ToString")]
	public ContactPoint.ContactPointUse? ToString(CqlContext context, Code<ContactPoint.ContactPointUse> value) => 
		value?.Value;

    [CqlDeclaration("ToString")]
	public Contract.ContractResourcePublicationStatusCodes? ToString(CqlContext context, Code<Contract.ContractResourcePublicationStatusCodes> value) => 
		value?.Value;

    [CqlDeclaration("ToString")]
	public Contract.ContractResourceStatusCodes? ToString(CqlContext context, Code<Contract.ContractResourceStatusCodes> value) => 
		value?.Value;

    [CqlDeclaration("ToString")]
	public Contributor.ContributorType? ToString(CqlContext context, Code<Contributor.ContributorType> value) => 
		value?.Value;

    [CqlDeclaration("ToString")]
	public Money.Currencies? ToString(CqlContext context, Code<Money.Currencies> value) => 
		value?.Value;

    [CqlDeclaration("ToString")]
	public DaysOfWeek? ToString(CqlContext context, Code<DaysOfWeek> value) => 
		value?.Value;

    [CqlDeclaration("ToString")]
	public DetectedIssue.DetectedIssueSeverity? ToString(CqlContext context, Code<DetectedIssue.DetectedIssueSeverity> value) => 
		value?.Value;

    [CqlDeclaration("ToString")]
	public ObservationStatus? ToString(CqlContext context, Code<ObservationStatus> value) => 
		value?.Value;

    [CqlDeclaration("ToString")]
	public DeviceMetric.DeviceMetricCalibrationState? ToString(CqlContext context, Code<DeviceMetric.DeviceMetricCalibrationState> value) => 
		value?.Value;

    [CqlDeclaration("ToString")]
	public DeviceMetric.DeviceMetricCalibrationType? ToString(CqlContext context, Code<DeviceMetric.DeviceMetricCalibrationType> value) => 
		value?.Value;

    [CqlDeclaration("ToString")]
	public DeviceMetric.DeviceMetricCategory? ToString(CqlContext context, Code<DeviceMetric.DeviceMetricCategory> value) => 
		value?.Value;

    [CqlDeclaration("ToString")]
	public DeviceMetric.DeviceMetricColor? ToString(CqlContext context, Code<DeviceMetric.DeviceMetricColor> value) => 
		value?.Value;

    [CqlDeclaration("ToString")]
	public DeviceMetric.DeviceMetricOperationalStatus? ToString(CqlContext context, Code<DeviceMetric.DeviceMetricOperationalStatus> value) => 
		value?.Value;

    [CqlDeclaration("ToString")]
	public DeviceNameType? ToString(CqlContext context, Code<DeviceNameType> value) => 
		value?.Value;

    [CqlDeclaration("ToString")]
	public DeviceUseStatement.DeviceUseStatementStatus? ToString(CqlContext context, Code<DeviceUseStatement.DeviceUseStatementStatus> value) => 
		value?.Value;

    [CqlDeclaration("ToString")]
	public DiagnosticReport.DiagnosticReportStatus? ToString(CqlContext context, Code<DiagnosticReport.DiagnosticReportStatus> value) => 
		value?.Value;

    [CqlDeclaration("ToString")]
	public ElementDefinition.DiscriminatorType? ToString(CqlContext context, Code<ElementDefinition.DiscriminatorType> value) => 
		value?.Value;

    [CqlDeclaration("ToString")]
	public Composition.V3ConfidentialityClassification? ToString(CqlContext context, Code<Composition.V3ConfidentialityClassification> value) => 
		value?.Value;

    [CqlDeclaration("ToString")]
	public CapabilityStatement.DocumentMode? ToString(CqlContext context, Code<CapabilityStatement.DocumentMode> value) => 
		value?.Value;

    [CqlDeclaration("ToString")]
	public DocumentReferenceStatus? ToString(CqlContext context, Code<DocumentReferenceStatus> value) => 
		value?.Value;

    [CqlDeclaration("ToString")]
	public DocumentRelationshipType? ToString(CqlContext context, Code<DocumentRelationshipType> value) => 
		value?.Value;

    [CqlDeclaration("ToString")]
	public CoverageEligibilityRequest.EligibilityRequestPurpose? ToString(CqlContext context, Code<CoverageEligibilityRequest.EligibilityRequestPurpose> value) => 
		value?.Value;

    [CqlDeclaration("ToString")]
	public CoverageEligibilityResponse.EligibilityResponsePurpose? ToString(CqlContext context, Code<CoverageEligibilityResponse.EligibilityResponsePurpose> value) => 
		value?.Value;

    [CqlDeclaration("ToString")]
	public Questionnaire.EnableWhenBehavior? ToString(CqlContext context, Code<Questionnaire.EnableWhenBehavior> value) => 
		value?.Value;

    [CqlDeclaration("ToString")]
	public Encounter.EncounterLocationStatus? ToString(CqlContext context, Code<Encounter.EncounterLocationStatus> value) => 
		value?.Value;

    [CqlDeclaration("ToString")]
	public Encounter.EncounterStatus? ToString(CqlContext context, Code<Encounter.EncounterStatus> value) => 
		value?.Value;

    [CqlDeclaration("ToString")]
	public Endpoint.EndpointStatus? ToString(CqlContext context, Code<Endpoint.EndpointStatus> value) => 
		value?.Value;

    [CqlDeclaration("ToString")]
	public EpisodeOfCare.EpisodeOfCareStatus? ToString(CqlContext context, Code<EpisodeOfCare.EpisodeOfCareStatus> value) => 
		value?.Value;

    [CqlDeclaration("ToString")]
	public CapabilityStatement.EventCapabilityMode? ToString(CqlContext context, Code<CapabilityStatement.EventCapabilityMode> value) => 
		value?.Value;

    [CqlDeclaration("ToString")]
	public Timing.EventTiming? ToString(CqlContext context, Code<Timing.EventTiming> value) => 
		value?.Value;

    [CqlDeclaration("ToString")]
	public VariableTypeCode? ToString(CqlContext context, Code<VariableTypeCode> value) => 
		value?.Value;

    [CqlDeclaration("ToString")]
	public ExampleScenario.ExampleScenarioActorType? ToString(CqlContext context, Code<ExampleScenario.ExampleScenarioActorType> value) => 
		value?.Value;

    [CqlDeclaration("ToString")]
	public ExplanationOfBenefit.ExplanationOfBenefitStatus? ToString(CqlContext context, Code<ExplanationOfBenefit.ExplanationOfBenefitStatus> value) => 
		value?.Value;

    [CqlDeclaration("ToString")]
	public EffectEvidenceSynthesis.ExposureStateCode? ToString(CqlContext context, Code<EffectEvidenceSynthesis.ExposureStateCode> value) => 
		value?.Value;

    [CqlDeclaration("ToString")]
	public StructureDefinition.ExtensionContextType? ToString(CqlContext context, Code<StructureDefinition.ExtensionContextType> value) => 
		value?.Value;

    [CqlDeclaration("ToString")]
	public FHIRAllTypes? ToString(CqlContext context, Code<FHIRAllTypes> value) => 
		value?.Value;

    [CqlDeclaration("ToString")]
	public FHIRDefinedType? ToString(CqlContext context, Code<FHIRDefinedType> value) => 
		value?.Value;

    [CqlDeclaration("ToString")]
	public Device.FHIRDeviceStatus? ToString(CqlContext context, Code<Device.FHIRDeviceStatus> value) => 
		value?.Value;

    [CqlDeclaration("ToString")]
	public ResourceType? ToString(CqlContext context, Code<ResourceType> value) => 
		value?.Value;

    [CqlDeclaration("ToString")]
	public Substance.FHIRSubstanceStatus? ToString(CqlContext context, Code<Substance.FHIRSubstanceStatus> value) => 
		value?.Value;

    [CqlDeclaration("ToString")]
	public FHIRVersion? ToString(CqlContext context, Code<FHIRVersion> value) => 
		value?.Value;

    [CqlDeclaration("ToString")]
	public FamilyMemberHistory.FamilyHistoryStatus? ToString(CqlContext context, Code<FamilyMemberHistory.FamilyHistoryStatus> value) => 
		value?.Value;

    [CqlDeclaration("ToString")]
	public FilterOperator? ToString(CqlContext context, Code<FilterOperator> value) => 
		value?.Value;

    [CqlDeclaration("ToString")]
	public Flag.FlagStatus? ToString(CqlContext context, Code<Flag.FlagStatus> value) => 
		value?.Value;

    [CqlDeclaration("ToString")]
	public Goal.GoalLifecycleStatus? ToString(CqlContext context, Code<Goal.GoalLifecycleStatus> value) => 
		value?.Value;

    [CqlDeclaration("ToString")]
	public GraphDefinition.GraphCompartmentRule? ToString(CqlContext context, Code<GraphDefinition.GraphCompartmentRule> value) => 
		value?.Value;

    [CqlDeclaration("ToString")]
	public GraphDefinition.GraphCompartmentUse? ToString(CqlContext context, Code<GraphDefinition.GraphCompartmentUse> value) => 
		value?.Value;

    [CqlDeclaration("ToString")]
	public GroupMeasureCode? ToString(CqlContext context, Code<GroupMeasureCode> value) => 
		value?.Value;

    [CqlDeclaration("ToString")]
	public Group.GroupType? ToString(CqlContext context, Code<Group.GroupType> value) => 
		value?.Value;

    [CqlDeclaration("ToString")]
	public GuidanceResponse.GuidanceResponseStatus? ToString(CqlContext context, Code<GuidanceResponse.GuidanceResponseStatus> value) => 
		value?.Value;

    [CqlDeclaration("ToString")]
	public ImplementationGuide.GuidePageGeneration? ToString(CqlContext context, Code<ImplementationGuide.GuidePageGeneration> value) => 
		value?.Value;

    [CqlDeclaration("ToString")]
	public ImplementationGuide.GuideParameterCode? ToString(CqlContext context, Code<ImplementationGuide.GuideParameterCode> value) => 
		value?.Value;

    [CqlDeclaration("ToString")]
	public Bundle.HTTPVerb? ToString(CqlContext context, Code<Bundle.HTTPVerb> value) => 
		value?.Value;

    [CqlDeclaration("ToString")]
	public Identifier.IdentifierUse? ToString(CqlContext context, Code<Identifier.IdentifierUse> value) => 
		value?.Value;

    [CqlDeclaration("ToString")]
	public Person.IdentityAssuranceLevel? ToString(CqlContext context, Code<Person.IdentityAssuranceLevel> value) => 
		value?.Value;

    [CqlDeclaration("ToString")]
	public ImagingStudy.ImagingStudyStatus? ToString(CqlContext context, Code<ImagingStudy.ImagingStudyStatus> value) => 
		value?.Value;

    [CqlDeclaration("ToString")]
	public ImmunizationEvaluation.ImmunizationEvaluationStatusCodes? ToString(CqlContext context, Code<ImmunizationEvaluation.ImmunizationEvaluationStatusCodes> value) => 
		value?.Value;

    [CqlDeclaration("ToString")]
	public Immunization.ImmunizationStatusCodes? ToString(CqlContext context, Code<Immunization.ImmunizationStatusCodes> value) => 
		value?.Value;

    [CqlDeclaration("ToString")]
	public Invoice.InvoiceStatus? ToString(CqlContext context, Code<Invoice.InvoiceStatus> value) => 
		value?.Value;

    [CqlDeclaration("ToString")]
	public OperationOutcome.IssueSeverity? ToString(CqlContext context, Code<OperationOutcome.IssueSeverity> value) => 
		value?.Value;

    [CqlDeclaration("ToString")]
	public OperationOutcome.IssueType? ToString(CqlContext context, Code<OperationOutcome.IssueType> value) => 
		value?.Value;

    [CqlDeclaration("ToString")]
	public Patient.LinkType? ToString(CqlContext context, Code<Patient.LinkType> value) => 
		value?.Value;

    [CqlDeclaration("ToString")]
	public Linkage.LinkageType? ToString(CqlContext context, Code<Linkage.LinkageType> value) => 
		value?.Value;

    [CqlDeclaration("ToString")]
	public ListMode? ToString(CqlContext context, Code<ListMode> value) => 
		value?.Value;

    [CqlDeclaration("ToString")]
	public List.ListStatus? ToString(CqlContext context, Code<List.ListStatus> value) => 
		value?.Value;

    [CqlDeclaration("ToString")]
	public Location.LocationMode? ToString(CqlContext context, Code<Location.LocationMode> value) => 
		value?.Value;

    [CqlDeclaration("ToString")]
	public Location.LocationStatus? ToString(CqlContext context, Code<Location.LocationStatus> value) => 
		value?.Value;

    [CqlDeclaration("ToString")]
	public MeasureReport.MeasureReportStatus? ToString(CqlContext context, Code<MeasureReport.MeasureReportStatus> value) => 
		value?.Value;

    [CqlDeclaration("ToString")]
	public MeasureReport.MeasureReportType? ToString(CqlContext context, Code<MeasureReport.MeasureReportType> value) => 
		value?.Value;

    [CqlDeclaration("ToString")]
	public MedicationAdministration.MedicationAdministrationStatusCodes? ToString(CqlContext context, Code<MedicationAdministration.MedicationAdministrationStatusCodes> value) => 
		value?.Value;

    [CqlDeclaration("ToString")]
	public MedicationDispense.MedicationDispenseStatusCodes? ToString(CqlContext context, Code<MedicationDispense.MedicationDispenseStatusCodes> value) => 
		value?.Value;

    [CqlDeclaration("ToString")]
	public MedicationKnowledge.MedicationKnowledgeStatusCodes? ToString(CqlContext context, Code<MedicationKnowledge.MedicationKnowledgeStatusCodes> value) => 
		value?.Value;

    [CqlDeclaration("ToString")]
	public MedicationRequest.MedicationRequestIntent? ToString(CqlContext context, Code<MedicationRequest.MedicationRequestIntent> value) => 
		value?.Value;

    [CqlDeclaration("ToString")]
	public MedicationRequest.MedicationrequestStatus? ToString(CqlContext context, Code<MedicationRequest.MedicationrequestStatus> value) => 
		value?.Value;

    [CqlDeclaration("ToString")]
	public MedicationStatement.MedicationStatusCodes? ToString(CqlContext context, Code<MedicationStatement.MedicationStatusCodes> value) => 
		value?.Value;

    [CqlDeclaration("ToString")]
	public Medication.MedicationStatusCodes? ToString(CqlContext context, Code<Medication.MedicationStatusCodes> value) => 
		value?.Value;

    [CqlDeclaration("ToString")]
	public MessageDefinition.MessageSignificanceCategory? ToString(CqlContext context, Code<MessageDefinition.MessageSignificanceCategory> value) => 
		value?.Value;

    [CqlDeclaration("ToString")]
	public MessageheaderResponseRequest? ToString(CqlContext context, Code<MessageheaderResponseRequest> value) => 
		value?.Value;

    [CqlDeclaration("ToString")]
	public string ToString(CqlContext context, Code value) => 
		value?.Value;

    [CqlDeclaration("ToString")]
	public HumanName.NameUse? ToString(CqlContext context, Code<HumanName.NameUse> value) => 
		value?.Value;

    [CqlDeclaration("ToString")]
	public NamingSystem.NamingSystemIdentifierType? ToString(CqlContext context, Code<NamingSystem.NamingSystemIdentifierType> value) => 
		value?.Value;

    [CqlDeclaration("ToString")]
	public NamingSystem.NamingSystemType? ToString(CqlContext context, Code<NamingSystem.NamingSystemType> value) => 
		value?.Value;

    [CqlDeclaration("ToString")]
	public Narrative.NarrativeStatus? ToString(CqlContext context, Code<Narrative.NarrativeStatus> value) => 
		value?.Value;

    [CqlDeclaration("ToString")]
	public NoteType? ToString(CqlContext context, Code<NoteType> value) => 
		value?.Value;

    [CqlDeclaration("ToString")]
	public RequestIntent? ToString(CqlContext context, Code<RequestIntent> value) => 
		value?.Value;

    [CqlDeclaration("ToString")]
	public ObservationDefinition.ObservationDataType? ToString(CqlContext context, Code<ObservationDefinition.ObservationDataType> value) => 
		value?.Value;

    [CqlDeclaration("ToString")]
	public ObservationDefinition.ObservationRangeCategory? ToString(CqlContext context, Code<ObservationDefinition.ObservationRangeCategory> value) => 
		value?.Value;

    [CqlDeclaration("ToString")]
	public OperationDefinition.OperationKind? ToString(CqlContext context, Code<OperationDefinition.OperationKind> value) => 
		value?.Value;

    [CqlDeclaration("ToString")]
	public OperationParameterUse? ToString(CqlContext context, Code<OperationParameterUse> value) => 
		value?.Value;

    [CqlDeclaration("ToString")]
	public MolecularSequence.OrientationType? ToString(CqlContext context, Code<MolecularSequence.OrientationType> value) => 
		value?.Value;

    [CqlDeclaration("ToString")]
	public Appointment.ParticipantRequired? ToString(CqlContext context, Code<Appointment.ParticipantRequired> value) => 
		value?.Value;

    [CqlDeclaration("ToString")]
	public ParticipationStatus? ToString(CqlContext context, Code<ParticipationStatus> value) => 
		value?.Value;

    [CqlDeclaration("ToString")]
	public ElementDefinition.PropertyRepresentation? ToString(CqlContext context, Code<ElementDefinition.PropertyRepresentation> value) => 
		value?.Value;

    [CqlDeclaration("ToString")]
	public CodeSystem.PropertyType? ToString(CqlContext context, Code<CodeSystem.PropertyType> value) => 
		value?.Value;

    [CqlDeclaration("ToString")]
	public Provenance.ProvenanceEntityRole? ToString(CqlContext context, Code<Provenance.ProvenanceEntityRole> value) => 
		value?.Value;

    [CqlDeclaration("ToString")]
	public PublicationStatus? ToString(CqlContext context, Code<PublicationStatus> value) => 
		value?.Value;

    [CqlDeclaration("ToString")]
	public MolecularSequence.QualityType? ToString(CqlContext context, Code<MolecularSequence.QualityType> value) => 
		value?.Value;

    [CqlDeclaration("ToString")]
	public Quantity.QuantityComparator? ToString(CqlContext context, Code<Quantity.QuantityComparator> value) => 
		value?.Value;

    [CqlDeclaration("ToString")]
	public Questionnaire.QuestionnaireItemOperator? ToString(CqlContext context, Code<Questionnaire.QuestionnaireItemOperator> value) => 
		value?.Value;

    [CqlDeclaration("ToString")]
	public Questionnaire.QuestionnaireItemType? ToString(CqlContext context, Code<Questionnaire.QuestionnaireItemType> value) => 
		value?.Value;

    [CqlDeclaration("ToString")]
	public QuestionnaireResponse.QuestionnaireResponseStatus? ToString(CqlContext context, Code<QuestionnaireResponse.QuestionnaireResponseStatus> value) => 
		value?.Value;

    [CqlDeclaration("ToString")]
	public CapabilityStatement.ReferenceHandlingPolicy? ToString(CqlContext context, Code<CapabilityStatement.ReferenceHandlingPolicy> value) => 
		value?.Value;

    [CqlDeclaration("ToString")]
	public ElementDefinition.ReferenceVersionRules? ToString(CqlContext context, Code<ElementDefinition.ReferenceVersionRules> value) => 
		value?.Value;

    [CqlDeclaration("ToString")]
	public RelatedArtifact.RelatedArtifactType? ToString(CqlContext context, Code<RelatedArtifact.RelatedArtifactType> value) => 
		value?.Value;

    [CqlDeclaration("ToString")]
	public ClaimProcessingCodes? ToString(CqlContext context, Code<ClaimProcessingCodes> value) => 
		value?.Value;

    [CqlDeclaration("ToString")]
	public MolecularSequence.RepositoryType? ToString(CqlContext context, Code<MolecularSequence.RepositoryType> value) => 
		value?.Value;

    [CqlDeclaration("ToString")]
	public ResearchElementDefinition.ResearchElementType? ToString(CqlContext context, Code<ResearchElementDefinition.ResearchElementType> value) => 
		value?.Value;

    [CqlDeclaration("ToString")]
	public ResearchStudy.ResearchStudyStatus? ToString(CqlContext context, Code<ResearchStudy.ResearchStudyStatus> value) => 
		value?.Value;

    [CqlDeclaration("ToString")]
	public ResearchSubject.ResearchSubjectStatus? ToString(CqlContext context, Code<ResearchSubject.ResearchSubjectStatus> value) => 
		value?.Value;

    [CqlDeclaration("ToString")]
	public CapabilityStatement.ResourceVersionPolicy? ToString(CqlContext context, Code<CapabilityStatement.ResourceVersionPolicy> value) => 
		value?.Value;

    [CqlDeclaration("ToString")]
	public MessageHeader.ResponseType? ToString(CqlContext context, Code<MessageHeader.ResponseType> value) => 
		value?.Value;

    [CqlDeclaration("ToString")]
	public CapabilityStatement.RestfulCapabilityMode? ToString(CqlContext context, Code<CapabilityStatement.RestfulCapabilityMode> value) => 
		value?.Value;

    [CqlDeclaration("ToString")]
	public ImplementationGuide.SPDXLicense? ToString(CqlContext context, Code<ImplementationGuide.SPDXLicense> value) => 
		value?.Value;

    [CqlDeclaration("ToString")]
	public SearchParameter.SearchComparator? ToString(CqlContext context, Code<SearchParameter.SearchComparator> value) => 
		value?.Value;

    [CqlDeclaration("ToString")]
	public Bundle.SearchEntryMode? ToString(CqlContext context, Code<Bundle.SearchEntryMode> value) => 
		value?.Value;

    [CqlDeclaration("ToString")]
	public SearchParameter.SearchModifierCode? ToString(CqlContext context, Code<SearchParameter.SearchModifierCode> value) => 
		value?.Value;

    [CqlDeclaration("ToString")]
	public SearchParamType? ToString(CqlContext context, Code<SearchParamType> value) => 
		value?.Value;

    [CqlDeclaration("ToString")]
	public MolecularSequence.SequenceType? ToString(CqlContext context, Code<MolecularSequence.SequenceType> value) => 
		value?.Value;

    [CqlDeclaration("ToString")]
	public ElementDefinition.SlicingRules? ToString(CqlContext context, Code<ElementDefinition.SlicingRules> value) => 
		value?.Value;

    [CqlDeclaration("ToString")]
	public Slot.SlotStatus? ToString(CqlContext context, Code<Slot.SlotStatus> value) => 
		value?.Value;

    [CqlDeclaration("ToString")]
	public DataRequirement.SortDirection? ToString(CqlContext context, Code<DataRequirement.SortDirection> value) => 
		value?.Value;

    [CqlDeclaration("ToString")]
	public SpecimenDefinition.SpecimenContainedPreference? ToString(CqlContext context, Code<SpecimenDefinition.SpecimenContainedPreference> value) => 
		value?.Value;

    [CqlDeclaration("ToString")]
	public Specimen.SpecimenStatus? ToString(CqlContext context, Code<Specimen.SpecimenStatus> value) => 
		value?.Value;

    [CqlDeclaration("ToString")]
	public VerificationResult.StatusCode? ToString(CqlContext context, Code<VerificationResult.StatusCode> value) => 
		value?.Value;

    [CqlDeclaration("ToString")]
	public MolecularSequence.StrandType? ToString(CqlContext context, Code<MolecularSequence.StrandType> value) => 
		value?.Value;

    [CqlDeclaration("ToString")]
	public StructureDefinition.StructureDefinitionKind? ToString(CqlContext context, Code<StructureDefinition.StructureDefinitionKind> value) => 
		value?.Value;

    [CqlDeclaration("ToString")]
	public StructureMap.StructureMapContextType? ToString(CqlContext context, Code<StructureMap.StructureMapContextType> value) => 
		value?.Value;

    [CqlDeclaration("ToString")]
	public StructureMap.StructureMapGroupTypeMode? ToString(CqlContext context, Code<StructureMap.StructureMapGroupTypeMode> value) => 
		value?.Value;

    [CqlDeclaration("ToString")]
	public StructureMap.StructureMapInputMode? ToString(CqlContext context, Code<StructureMap.StructureMapInputMode> value) => 
		value?.Value;

    [CqlDeclaration("ToString")]
	public StructureMap.StructureMapModelMode? ToString(CqlContext context, Code<StructureMap.StructureMapModelMode> value) => 
		value?.Value;

    [CqlDeclaration("ToString")]
	public StructureMap.StructureMapSourceListMode? ToString(CqlContext context, Code<StructureMap.StructureMapSourceListMode> value) => 
		value?.Value;

    [CqlDeclaration("ToString")]
	public StructureMap.StructureMapTargetListMode? ToString(CqlContext context, Code<StructureMap.StructureMapTargetListMode> value) => 
		value?.Value;

    [CqlDeclaration("ToString")]
	public StructureMap.StructureMapTransform? ToString(CqlContext context, Code<StructureMap.StructureMapTransform> value) => 
		value?.Value;

    [CqlDeclaration("ToString")]
	public Subscription.SubscriptionChannelType? ToString(CqlContext context, Code<Subscription.SubscriptionChannelType> value) => 
		value?.Value;

    [CqlDeclaration("ToString")]
	public Subscription.SubscriptionStatus? ToString(CqlContext context, Code<Subscription.SubscriptionStatus> value) => 
		value?.Value;

    [CqlDeclaration("ToString")]
	public SupplyDelivery.SupplyDeliveryStatus? ToString(CqlContext context, Code<SupplyDelivery.SupplyDeliveryStatus> value) => 
		value?.Value;

    [CqlDeclaration("ToString")]
	public SupplyRequest.SupplyRequestStatus? ToString(CqlContext context, Code<SupplyRequest.SupplyRequestStatus> value) => 
		value?.Value;

    [CqlDeclaration("ToString")]
	public CapabilityStatement.SystemRestfulInteraction? ToString(CqlContext context, Code<CapabilityStatement.SystemRestfulInteraction> value) => 
		value?.Value;

    [CqlDeclaration("ToString")]
	public Task.TaskIntent? ToString(CqlContext context, Code<Task.TaskIntent> value) => 
		value?.Value;

    [CqlDeclaration("ToString")]
	public Task.TaskStatus? ToString(CqlContext context, Code<Task.TaskStatus> value) => 
		value?.Value;

    [CqlDeclaration("ToString")]
	public TestReport.TestReportActionResult? ToString(CqlContext context, Code<TestReport.TestReportActionResult> value) => 
		value?.Value;

    [CqlDeclaration("ToString")]
	public TestReport.TestReportParticipantType? ToString(CqlContext context, Code<TestReport.TestReportParticipantType> value) => 
		value?.Value;

    [CqlDeclaration("ToString")]
	public TestReport.TestReportResult? ToString(CqlContext context, Code<TestReport.TestReportResult> value) => 
		value?.Value;

    [CqlDeclaration("ToString")]
	public TestReport.TestReportStatus? ToString(CqlContext context, Code<TestReport.TestReportStatus> value) => 
		value?.Value;

    [CqlDeclaration("ToString")]
	public TestScript.TestScriptRequestMethodCode? ToString(CqlContext context, Code<TestScript.TestScriptRequestMethodCode> value) => 
		value?.Value;

    [CqlDeclaration("ToString")]
	public TriggerDefinition.TriggerType? ToString(CqlContext context, Code<TriggerDefinition.TriggerType> value) => 
		value?.Value;

    [CqlDeclaration("ToString")]
	public StructureDefinition.TypeDerivationRule? ToString(CqlContext context, Code<StructureDefinition.TypeDerivationRule> value) => 
		value?.Value;

    [CqlDeclaration("ToString")]
	public CapabilityStatement.TypeRestfulInteraction? ToString(CqlContext context, Code<CapabilityStatement.TypeRestfulInteraction> value) => 
		value?.Value;

    [CqlDeclaration("ToString")]
	public Device.UDIEntryType? ToString(CqlContext context, Code<Device.UDIEntryType> value) => 
		value?.Value;

    [CqlDeclaration("ToString")]
	public Timing.UnitsOfTime? ToString(CqlContext context, Code<Timing.UnitsOfTime> value) => 
		value?.Value;

    [CqlDeclaration("ToString")]
	public ClaimUseCode? ToString(CqlContext context, Code<ClaimUseCode> value) => 
		value?.Value;

    [CqlDeclaration("ToString")]
	public VisionPrescription.VisionBase? ToString(CqlContext context, Code<VisionPrescription.VisionBase> value) => 
		value?.Value;

    [CqlDeclaration("ToString")]
	public VisionPrescription.VisionEyes? ToString(CqlContext context, Code<VisionPrescription.VisionEyes> value) => 
		value?.Value;

    [CqlDeclaration("ToString")]
	public SearchParameter.XPathUsageType? ToString(CqlContext context, Code<SearchParameter.XPathUsageType> value) => 
		value?.Value;

    [CqlDeclaration("ToString")]
	public string ToString(CqlContext context, Base64Binary value)
	{
		var a_ = context.Operators.Convert<string>(value?.Value);

		return a_;
	}

    [CqlDeclaration("ToString")]
	public string ToString(CqlContext context, Id value) => 
		value?.Value;

    [CqlDeclaration("ToString")]
	public string ToString(CqlContext context, FhirString value) => 
		value?.Value;

    [CqlDeclaration("ToString")]
	public string ToString(CqlContext context, FhirUri value) => 
		value?.Value;

    [CqlDeclaration("ToString")]
	public string ToString(CqlContext context, XHtml value) => 
		value?.Value;

    [CqlDeclaration("ToBoolean")]
	public bool? ToBoolean(CqlContext context, FhirBoolean value) => 
		value?.Value;

    [CqlDeclaration("ToDate")]
	public CqlDate ToDate(CqlContext context, Date value)
	{
		var a_ = context.Operators.ConvertStringToDate(value?.Value);

		return a_;
	}

    [CqlDeclaration("ToDateTime")]
	public CqlDateTime ToDateTime(CqlContext context, FhirDateTime value)
	{
		var a_ = context.Operators.Convert<CqlDateTime>(value);

		return a_;
	}

    [CqlDeclaration("ToDateTime")]
	public CqlDateTime ToDateTime(CqlContext context, Instant value)
	{
		var a_ = context.Operators.Convert<CqlDateTime>(value?.Value);

		return a_;
	}

    [CqlDeclaration("ToDecimal")]
	public decimal? ToDecimal(CqlContext context, FhirDecimal value) => 
		value?.Value;

    [CqlDeclaration("ToInteger")]
	public int? ToInteger(CqlContext context, Integer value) => 
		value?.Value;

    [CqlDeclaration("ToTime")]
	public CqlTime ToTime(CqlContext context, Time value)
	{
		var a_ = context.Operators.ConvertStringToTime(value?.Value);

		return a_;
	}

}
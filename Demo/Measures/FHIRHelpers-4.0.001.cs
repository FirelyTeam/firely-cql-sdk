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


    internal CqlContext context;

    #region Cached values

    internal Lazy<Patient> __Patient;

    #endregion
    public FHIRHelpers_4_0_001(CqlContext context)
    {
        this.context = context ?? throw new ArgumentNullException("context");


        __Patient = new Lazy<Patient>(this.Patient_Value);
    }
	private Patient Patient_Value()
	{
		var a_ = context.Operators.RetrieveByValueSet<Patient>(null, null);
		var b_ = context.Operators.SingleOrNull<Patient>(a_);

		return b_;
	}

    [CqlDeclaration("Patient")]
	public Patient Patient() => 
		__Patient.Value;

    [CqlDeclaration("ToInterval")]
	public CqlInterval<CqlDateTime> ToInterval(Period period)
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
	public CqlInterval<CqlQuantity> ToInterval(Range range)
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
				var c_ = this.ToQuantity(range?.Low);
				var d_ = this.ToQuantity(range?.High);
				var e_ = context.Operators.Interval(c_, d_, true, true);

				return e_;
			};
		};

		return a_();
	}

    [CqlDeclaration("ToQuantity")]
	public CqlQuantity ToQuantity(Quantity quantity) => 
		((quantity is null)
			? null
			: (new CqlQuantity(quantity?.ValueElement?.Value, quantity?.UnitElement?.Value)));

    [CqlDeclaration("ToRatio")]
	public CqlRatio ToRatio(Ratio ratio)
	{
		CqlRatio a_()
		{
			if ((ratio is null))
			{
				return null;
			}
			else
			{
				var b_ = this.ToQuantity(ratio?.Numerator);
				var c_ = this.ToQuantity(ratio?.Denominator);

				return new CqlRatio(b_, c_);
			};
		};

		return a_();
	}

    [CqlDeclaration("ToCode")]
	public CqlCode ToCode(Coding coding) => 
		((coding is null)
			? null
			: (new CqlCode(coding?.CodeElement?.Value, coding?.SystemElement?.Value, coding?.VersionElement?.Value, coding?.DisplayElement?.Value)));

    [CqlDeclaration("ToConcept")]
	public CqlConcept ToConcept(CodeableConcept concept)
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
					var d_ = this.ToCode(C);

					return d_;
				};
				var c_ = context.Operators.SelectOrNull<Coding, CqlCode>((concept?.Coding as IEnumerable<Coding>), b_);

				return new CqlConcept(c_, concept?.TextElement?.Value);
			};
		};

		return a_();
	}

    [CqlDeclaration("ToString")]
	public Account.AccountStatus? ToString(Code<Account.AccountStatus> value) => 
		value?.Value;

    [CqlDeclaration("ToString")]
	public ActionCardinalityBehavior? ToString(Code<ActionCardinalityBehavior> value) => 
		value?.Value;

    [CqlDeclaration("ToString")]
	public ActionConditionKind? ToString(Code<ActionConditionKind> value) => 
		value?.Value;

    [CqlDeclaration("ToString")]
	public ActionGroupingBehavior? ToString(Code<ActionGroupingBehavior> value) => 
		value?.Value;

    [CqlDeclaration("ToString")]
	public ActionParticipantType? ToString(Code<ActionParticipantType> value) => 
		value?.Value;

    [CqlDeclaration("ToString")]
	public ActionPrecheckBehavior? ToString(Code<ActionPrecheckBehavior> value) => 
		value?.Value;

    [CqlDeclaration("ToString")]
	public ActionRelationshipType? ToString(Code<ActionRelationshipType> value) => 
		value?.Value;

    [CqlDeclaration("ToString")]
	public ActionRequiredBehavior? ToString(Code<ActionRequiredBehavior> value) => 
		value?.Value;

    [CqlDeclaration("ToString")]
	public ActionSelectionBehavior? ToString(Code<ActionSelectionBehavior> value) => 
		value?.Value;

    [CqlDeclaration("ToString")]
	public ActivityDefinition.RequestResourceType? ToString(Code<ActivityDefinition.RequestResourceType> value) => 
		value?.Value;

    [CqlDeclaration("ToString")]
	public Address.AddressType? ToString(Code<Address.AddressType> value) => 
		value?.Value;

    [CqlDeclaration("ToString")]
	public Address.AddressUse? ToString(Code<Address.AddressUse> value) => 
		value?.Value;

    [CqlDeclaration("ToString")]
	public AdministrativeGender? ToString(Code<AdministrativeGender> value) => 
		value?.Value;

    [CqlDeclaration("ToString")]
	public AdverseEvent.AdverseEventActuality? ToString(Code<AdverseEvent.AdverseEventActuality> value) => 
		value?.Value;

    [CqlDeclaration("ToString")]
	public ElementDefinition.AggregationMode? ToString(Code<ElementDefinition.AggregationMode> value) => 
		value?.Value;

    [CqlDeclaration("ToString")]
	public AllergyIntolerance.AllergyIntoleranceCategory? ToString(Code<AllergyIntolerance.AllergyIntoleranceCategory> value) => 
		value?.Value;

    [CqlDeclaration("ToString")]
	public AllergyIntolerance.AllergyIntoleranceCriticality? ToString(Code<AllergyIntolerance.AllergyIntoleranceCriticality> value) => 
		value?.Value;

    [CqlDeclaration("ToString")]
	public AllergyIntolerance.AllergyIntoleranceSeverity? ToString(Code<AllergyIntolerance.AllergyIntoleranceSeverity> value) => 
		value?.Value;

    [CqlDeclaration("ToString")]
	public AllergyIntolerance.AllergyIntoleranceType? ToString(Code<AllergyIntolerance.AllergyIntoleranceType> value) => 
		value?.Value;

    [CqlDeclaration("ToString")]
	public Appointment.AppointmentStatus? ToString(Code<Appointment.AppointmentStatus> value) => 
		value?.Value;

    [CqlDeclaration("ToString")]
	public TestScript.AssertionDirectionType? ToString(Code<TestScript.AssertionDirectionType> value) => 
		value?.Value;

    [CqlDeclaration("ToString")]
	public TestScript.AssertionOperatorType? ToString(Code<TestScript.AssertionOperatorType> value) => 
		value?.Value;

    [CqlDeclaration("ToString")]
	public TestScript.AssertionResponseTypes? ToString(Code<TestScript.AssertionResponseTypes> value) => 
		value?.Value;

    [CqlDeclaration("ToString")]
	public AuditEvent.AuditEventAction? ToString(Code<AuditEvent.AuditEventAction> value) => 
		value?.Value;

    [CqlDeclaration("ToString")]
	public AuditEvent.AuditEventAgentNetworkType? ToString(Code<AuditEvent.AuditEventAgentNetworkType> value) => 
		value?.Value;

    [CqlDeclaration("ToString")]
	public AuditEvent.AuditEventOutcome? ToString(Code<AuditEvent.AuditEventOutcome> value) => 
		value?.Value;

    [CqlDeclaration("ToString")]
	public BindingStrength? ToString(Code<BindingStrength> value) => 
		value?.Value;

    [CqlDeclaration("ToString")]
	public BiologicallyDerivedProduct.BiologicallyDerivedProductCategory? ToString(Code<BiologicallyDerivedProduct.BiologicallyDerivedProductCategory> value) => 
		value?.Value;

    [CqlDeclaration("ToString")]
	public BiologicallyDerivedProduct.BiologicallyDerivedProductStatus? ToString(Code<BiologicallyDerivedProduct.BiologicallyDerivedProductStatus> value) => 
		value?.Value;

    [CqlDeclaration("ToString")]
	public BiologicallyDerivedProduct.BiologicallyDerivedProductStorageScale? ToString(Code<BiologicallyDerivedProduct.BiologicallyDerivedProductStorageScale> value) => 
		value?.Value;

    [CqlDeclaration("ToString")]
	public Bundle.BundleType? ToString(Code<Bundle.BundleType> value) => 
		value?.Value;

    [CqlDeclaration("ToString")]
	public CapabilityStatementKind? ToString(Code<CapabilityStatementKind> value) => 
		value?.Value;

    [CqlDeclaration("ToString")]
	public CarePlan.CarePlanActivityKind? ToString(Code<CarePlan.CarePlanActivityKind> value) => 
		value?.Value;

    [CqlDeclaration("ToString")]
	public CarePlan.CarePlanActivityStatus? ToString(Code<CarePlan.CarePlanActivityStatus> value) => 
		value?.Value;

    [CqlDeclaration("ToString")]
	public CarePlan.CarePlanIntent? ToString(Code<CarePlan.CarePlanIntent> value) => 
		value?.Value;

    [CqlDeclaration("ToString")]
	public RequestStatus? ToString(Code<RequestStatus> value) => 
		value?.Value;

    [CqlDeclaration("ToString")]
	public CareTeam.CareTeamStatus? ToString(Code<CareTeam.CareTeamStatus> value) => 
		value?.Value;

    [CqlDeclaration("ToString")]
	public CatalogEntry.CatalogEntryRelationType? ToString(Code<CatalogEntry.CatalogEntryRelationType> value) => 
		value?.Value;

    [CqlDeclaration("ToString")]
	public InvoicePriceComponentType? ToString(Code<InvoicePriceComponentType> value) => 
		value?.Value;

    [CqlDeclaration("ToString")]
	public ChargeItem.ChargeItemStatus? ToString(Code<ChargeItem.ChargeItemStatus> value) => 
		value?.Value;

    [CqlDeclaration("ToString")]
	public FinancialResourceStatusCodes? ToString(Code<FinancialResourceStatusCodes> value) => 
		value?.Value;

    [CqlDeclaration("ToString")]
	public ClinicalImpression.ClinicalImpressionStatus? ToString(Code<ClinicalImpression.ClinicalImpressionStatus> value) => 
		value?.Value;

    [CqlDeclaration("ToString")]
	public TerminologyCapabilities.CodeSearchSupport? ToString(Code<TerminologyCapabilities.CodeSearchSupport> value) => 
		value?.Value;

    [CqlDeclaration("ToString")]
	public CodeSystemContentMode? ToString(Code<CodeSystemContentMode> value) => 
		value?.Value;

    [CqlDeclaration("ToString")]
	public CodeSystem.CodeSystemHierarchyMeaning? ToString(Code<CodeSystem.CodeSystemHierarchyMeaning> value) => 
		value?.Value;

    [CqlDeclaration("ToString")]
	public RequestPriority? ToString(Code<RequestPriority> value) => 
		value?.Value;

    [CqlDeclaration("ToString")]
	public EventStatus? ToString(Code<EventStatus> value) => 
		value?.Value;

    [CqlDeclaration("ToString")]
	public CompartmentType? ToString(Code<CompartmentType> value) => 
		value?.Value;

    [CqlDeclaration("ToString")]
	public Composition.CompositionAttestationMode? ToString(Code<Composition.CompositionAttestationMode> value) => 
		value?.Value;

    [CqlDeclaration("ToString")]
	public CompositionStatus? ToString(Code<CompositionStatus> value) => 
		value?.Value;

    [CqlDeclaration("ToString")]
	public ConceptMapEquivalence? ToString(Code<ConceptMapEquivalence> value) => 
		value?.Value;

    [CqlDeclaration("ToString")]
	public ConceptMap.ConceptMapGroupUnmappedMode? ToString(Code<ConceptMap.ConceptMapGroupUnmappedMode> value) => 
		value?.Value;

    [CqlDeclaration("ToString")]
	public CapabilityStatement.ConditionalDeleteStatus? ToString(Code<CapabilityStatement.ConditionalDeleteStatus> value) => 
		value?.Value;

    [CqlDeclaration("ToString")]
	public CapabilityStatement.ConditionalReadStatus? ToString(Code<CapabilityStatement.ConditionalReadStatus> value) => 
		value?.Value;

    [CqlDeclaration("ToString")]
	public Consent.ConsentDataMeaning? ToString(Code<Consent.ConsentDataMeaning> value) => 
		value?.Value;

    [CqlDeclaration("ToString")]
	public Consent.ConsentProvisionType? ToString(Code<Consent.ConsentProvisionType> value) => 
		value?.Value;

    [CqlDeclaration("ToString")]
	public Consent.ConsentState? ToString(Code<Consent.ConsentState> value) => 
		value?.Value;

    [CqlDeclaration("ToString")]
	public ConstraintSeverity? ToString(Code<ConstraintSeverity> value) => 
		value?.Value;

    [CqlDeclaration("ToString")]
	public ContactPoint.ContactPointSystem? ToString(Code<ContactPoint.ContactPointSystem> value) => 
		value?.Value;

    [CqlDeclaration("ToString")]
	public ContactPoint.ContactPointUse? ToString(Code<ContactPoint.ContactPointUse> value) => 
		value?.Value;

    [CqlDeclaration("ToString")]
	public Contract.ContractResourcePublicationStatusCodes? ToString(Code<Contract.ContractResourcePublicationStatusCodes> value) => 
		value?.Value;

    [CqlDeclaration("ToString")]
	public Contract.ContractResourceStatusCodes? ToString(Code<Contract.ContractResourceStatusCodes> value) => 
		value?.Value;

    [CqlDeclaration("ToString")]
	public Contributor.ContributorType? ToString(Code<Contributor.ContributorType> value) => 
		value?.Value;

    [CqlDeclaration("ToString")]
	public Money.Currencies? ToString(Code<Money.Currencies> value) => 
		value?.Value;

    [CqlDeclaration("ToString")]
	public DaysOfWeek? ToString(Code<DaysOfWeek> value) => 
		value?.Value;

    [CqlDeclaration("ToString")]
	public DetectedIssue.DetectedIssueSeverity? ToString(Code<DetectedIssue.DetectedIssueSeverity> value) => 
		value?.Value;

    [CqlDeclaration("ToString")]
	public ObservationStatus? ToString(Code<ObservationStatus> value) => 
		value?.Value;

    [CqlDeclaration("ToString")]
	public DeviceMetric.DeviceMetricCalibrationState? ToString(Code<DeviceMetric.DeviceMetricCalibrationState> value) => 
		value?.Value;

    [CqlDeclaration("ToString")]
	public DeviceMetric.DeviceMetricCalibrationType? ToString(Code<DeviceMetric.DeviceMetricCalibrationType> value) => 
		value?.Value;

    [CqlDeclaration("ToString")]
	public DeviceMetric.DeviceMetricCategory? ToString(Code<DeviceMetric.DeviceMetricCategory> value) => 
		value?.Value;

    [CqlDeclaration("ToString")]
	public DeviceMetric.DeviceMetricColor? ToString(Code<DeviceMetric.DeviceMetricColor> value) => 
		value?.Value;

    [CqlDeclaration("ToString")]
	public DeviceMetric.DeviceMetricOperationalStatus? ToString(Code<DeviceMetric.DeviceMetricOperationalStatus> value) => 
		value?.Value;

    [CqlDeclaration("ToString")]
	public DeviceNameType? ToString(Code<DeviceNameType> value) => 
		value?.Value;

    [CqlDeclaration("ToString")]
	public DeviceUseStatement.DeviceUseStatementStatus? ToString(Code<DeviceUseStatement.DeviceUseStatementStatus> value) => 
		value?.Value;

    [CqlDeclaration("ToString")]
	public DiagnosticReport.DiagnosticReportStatus? ToString(Code<DiagnosticReport.DiagnosticReportStatus> value) => 
		value?.Value;

    [CqlDeclaration("ToString")]
	public ElementDefinition.DiscriminatorType? ToString(Code<ElementDefinition.DiscriminatorType> value) => 
		value?.Value;

    [CqlDeclaration("ToString")]
	public Composition.V3ConfidentialityClassification? ToString(Code<Composition.V3ConfidentialityClassification> value) => 
		value?.Value;

    [CqlDeclaration("ToString")]
	public CapabilityStatement.DocumentMode? ToString(Code<CapabilityStatement.DocumentMode> value) => 
		value?.Value;

    [CqlDeclaration("ToString")]
	public DocumentReferenceStatus? ToString(Code<DocumentReferenceStatus> value) => 
		value?.Value;

    [CqlDeclaration("ToString")]
	public DocumentRelationshipType? ToString(Code<DocumentRelationshipType> value) => 
		value?.Value;

    [CqlDeclaration("ToString")]
	public CoverageEligibilityRequest.EligibilityRequestPurpose? ToString(Code<CoverageEligibilityRequest.EligibilityRequestPurpose> value) => 
		value?.Value;

    [CqlDeclaration("ToString")]
	public CoverageEligibilityResponse.EligibilityResponsePurpose? ToString(Code<CoverageEligibilityResponse.EligibilityResponsePurpose> value) => 
		value?.Value;

    [CqlDeclaration("ToString")]
	public Questionnaire.EnableWhenBehavior? ToString(Code<Questionnaire.EnableWhenBehavior> value) => 
		value?.Value;

    [CqlDeclaration("ToString")]
	public Encounter.EncounterLocationStatus? ToString(Code<Encounter.EncounterLocationStatus> value) => 
		value?.Value;

    [CqlDeclaration("ToString")]
	public Encounter.EncounterStatus? ToString(Code<Encounter.EncounterStatus> value) => 
		value?.Value;

    [CqlDeclaration("ToString")]
	public Endpoint.EndpointStatus? ToString(Code<Endpoint.EndpointStatus> value) => 
		value?.Value;

    [CqlDeclaration("ToString")]
	public EpisodeOfCare.EpisodeOfCareStatus? ToString(Code<EpisodeOfCare.EpisodeOfCareStatus> value) => 
		value?.Value;

    [CqlDeclaration("ToString")]
	public CapabilityStatement.EventCapabilityMode? ToString(Code<CapabilityStatement.EventCapabilityMode> value) => 
		value?.Value;

    [CqlDeclaration("ToString")]
	public Timing.EventTiming? ToString(Code<Timing.EventTiming> value) => 
		value?.Value;

    [CqlDeclaration("ToString")]
	public VariableTypeCode? ToString(Code<VariableTypeCode> value) => 
		value?.Value;

    [CqlDeclaration("ToString")]
	public ExampleScenario.ExampleScenarioActorType? ToString(Code<ExampleScenario.ExampleScenarioActorType> value) => 
		value?.Value;

    [CqlDeclaration("ToString")]
	public ExplanationOfBenefit.ExplanationOfBenefitStatus? ToString(Code<ExplanationOfBenefit.ExplanationOfBenefitStatus> value) => 
		value?.Value;

    [CqlDeclaration("ToString")]
	public EffectEvidenceSynthesis.ExposureStateCode? ToString(Code<EffectEvidenceSynthesis.ExposureStateCode> value) => 
		value?.Value;

    [CqlDeclaration("ToString")]
	public StructureDefinition.ExtensionContextType? ToString(Code<StructureDefinition.ExtensionContextType> value) => 
		value?.Value;

    [CqlDeclaration("ToString")]
	public FHIRAllTypes? ToString(Code<FHIRAllTypes> value) => 
		value?.Value;

    [CqlDeclaration("ToString")]
	public FHIRDefinedType? ToString(Code<FHIRDefinedType> value) => 
		value?.Value;

    [CqlDeclaration("ToString")]
	public Device.FHIRDeviceStatus? ToString(Code<Device.FHIRDeviceStatus> value) => 
		value?.Value;

    [CqlDeclaration("ToString")]
	public ResourceType? ToString(Code<ResourceType> value) => 
		value?.Value;

    [CqlDeclaration("ToString")]
	public Substance.FHIRSubstanceStatus? ToString(Code<Substance.FHIRSubstanceStatus> value) => 
		value?.Value;

    [CqlDeclaration("ToString")]
	public FHIRVersion? ToString(Code<FHIRVersion> value) => 
		value?.Value;

    [CqlDeclaration("ToString")]
	public FamilyMemberHistory.FamilyHistoryStatus? ToString(Code<FamilyMemberHistory.FamilyHistoryStatus> value) => 
		value?.Value;

    [CqlDeclaration("ToString")]
	public FilterOperator? ToString(Code<FilterOperator> value) => 
		value?.Value;

    [CqlDeclaration("ToString")]
	public Flag.FlagStatus? ToString(Code<Flag.FlagStatus> value) => 
		value?.Value;

    [CqlDeclaration("ToString")]
	public Goal.GoalLifecycleStatus? ToString(Code<Goal.GoalLifecycleStatus> value) => 
		value?.Value;

    [CqlDeclaration("ToString")]
	public GraphDefinition.GraphCompartmentRule? ToString(Code<GraphDefinition.GraphCompartmentRule> value) => 
		value?.Value;

    [CqlDeclaration("ToString")]
	public GraphDefinition.GraphCompartmentUse? ToString(Code<GraphDefinition.GraphCompartmentUse> value) => 
		value?.Value;

    [CqlDeclaration("ToString")]
	public GroupMeasureCode? ToString(Code<GroupMeasureCode> value) => 
		value?.Value;

    [CqlDeclaration("ToString")]
	public Group.GroupType? ToString(Code<Group.GroupType> value) => 
		value?.Value;

    [CqlDeclaration("ToString")]
	public GuidanceResponse.GuidanceResponseStatus? ToString(Code<GuidanceResponse.GuidanceResponseStatus> value) => 
		value?.Value;

    [CqlDeclaration("ToString")]
	public ImplementationGuide.GuidePageGeneration? ToString(Code<ImplementationGuide.GuidePageGeneration> value) => 
		value?.Value;

    [CqlDeclaration("ToString")]
	public ImplementationGuide.GuideParameterCode? ToString(Code<ImplementationGuide.GuideParameterCode> value) => 
		value?.Value;

    [CqlDeclaration("ToString")]
	public Bundle.HTTPVerb? ToString(Code<Bundle.HTTPVerb> value) => 
		value?.Value;

    [CqlDeclaration("ToString")]
	public Identifier.IdentifierUse? ToString(Code<Identifier.IdentifierUse> value) => 
		value?.Value;

    [CqlDeclaration("ToString")]
	public Person.IdentityAssuranceLevel? ToString(Code<Person.IdentityAssuranceLevel> value) => 
		value?.Value;

    [CqlDeclaration("ToString")]
	public ImagingStudy.ImagingStudyStatus? ToString(Code<ImagingStudy.ImagingStudyStatus> value) => 
		value?.Value;

    [CqlDeclaration("ToString")]
	public ImmunizationEvaluation.ImmunizationEvaluationStatusCodes? ToString(Code<ImmunizationEvaluation.ImmunizationEvaluationStatusCodes> value) => 
		value?.Value;

    [CqlDeclaration("ToString")]
	public Immunization.ImmunizationStatusCodes? ToString(Code<Immunization.ImmunizationStatusCodes> value) => 
		value?.Value;

    [CqlDeclaration("ToString")]
	public Invoice.InvoiceStatus? ToString(Code<Invoice.InvoiceStatus> value) => 
		value?.Value;

    [CqlDeclaration("ToString")]
	public OperationOutcome.IssueSeverity? ToString(Code<OperationOutcome.IssueSeverity> value) => 
		value?.Value;

    [CqlDeclaration("ToString")]
	public OperationOutcome.IssueType? ToString(Code<OperationOutcome.IssueType> value) => 
		value?.Value;

    [CqlDeclaration("ToString")]
	public Patient.LinkType? ToString(Code<Patient.LinkType> value) => 
		value?.Value;

    [CqlDeclaration("ToString")]
	public Linkage.LinkageType? ToString(Code<Linkage.LinkageType> value) => 
		value?.Value;

    [CqlDeclaration("ToString")]
	public ListMode? ToString(Code<ListMode> value) => 
		value?.Value;

    [CqlDeclaration("ToString")]
	public List.ListStatus? ToString(Code<List.ListStatus> value) => 
		value?.Value;

    [CqlDeclaration("ToString")]
	public Location.LocationMode? ToString(Code<Location.LocationMode> value) => 
		value?.Value;

    [CqlDeclaration("ToString")]
	public Location.LocationStatus? ToString(Code<Location.LocationStatus> value) => 
		value?.Value;

    [CqlDeclaration("ToString")]
	public MeasureReport.MeasureReportStatus? ToString(Code<MeasureReport.MeasureReportStatus> value) => 
		value?.Value;

    [CqlDeclaration("ToString")]
	public MeasureReport.MeasureReportType? ToString(Code<MeasureReport.MeasureReportType> value) => 
		value?.Value;

    [CqlDeclaration("ToString")]
	public MedicationAdministration.MedicationAdministrationStatusCodes? ToString(Code<MedicationAdministration.MedicationAdministrationStatusCodes> value) => 
		value?.Value;

    [CqlDeclaration("ToString")]
	public MedicationDispense.MedicationDispenseStatusCodes? ToString(Code<MedicationDispense.MedicationDispenseStatusCodes> value) => 
		value?.Value;

    [CqlDeclaration("ToString")]
	public MedicationKnowledge.MedicationKnowledgeStatusCodes? ToString(Code<MedicationKnowledge.MedicationKnowledgeStatusCodes> value) => 
		value?.Value;

    [CqlDeclaration("ToString")]
	public MedicationRequest.MedicationRequestIntent? ToString(Code<MedicationRequest.MedicationRequestIntent> value) => 
		value?.Value;

    [CqlDeclaration("ToString")]
	public MedicationRequest.MedicationrequestStatus? ToString(Code<MedicationRequest.MedicationrequestStatus> value) => 
		value?.Value;

    [CqlDeclaration("ToString")]
	public MedicationStatement.MedicationStatusCodes? ToString(Code<MedicationStatement.MedicationStatusCodes> value) => 
		value?.Value;

    [CqlDeclaration("ToString")]
	public Medication.MedicationStatusCodes? ToString(Code<Medication.MedicationStatusCodes> value) => 
		value?.Value;

    [CqlDeclaration("ToString")]
	public MessageDefinition.MessageSignificanceCategory? ToString(Code<MessageDefinition.MessageSignificanceCategory> value) => 
		value?.Value;

    [CqlDeclaration("ToString")]
	public MessageheaderResponseRequest? ToString(Code<MessageheaderResponseRequest> value) => 
		value?.Value;

    [CqlDeclaration("ToString")]
	public string ToString(Code value) => 
		value?.Value;

    [CqlDeclaration("ToString")]
	public HumanName.NameUse? ToString(Code<HumanName.NameUse> value) => 
		value?.Value;

    [CqlDeclaration("ToString")]
	public NamingSystem.NamingSystemIdentifierType? ToString(Code<NamingSystem.NamingSystemIdentifierType> value) => 
		value?.Value;

    [CqlDeclaration("ToString")]
	public NamingSystem.NamingSystemType? ToString(Code<NamingSystem.NamingSystemType> value) => 
		value?.Value;

    [CqlDeclaration("ToString")]
	public Narrative.NarrativeStatus? ToString(Code<Narrative.NarrativeStatus> value) => 
		value?.Value;

    [CqlDeclaration("ToString")]
	public NoteType? ToString(Code<NoteType> value) => 
		value?.Value;

    [CqlDeclaration("ToString")]
	public RequestIntent? ToString(Code<RequestIntent> value) => 
		value?.Value;

    [CqlDeclaration("ToString")]
	public ObservationDefinition.ObservationDataType? ToString(Code<ObservationDefinition.ObservationDataType> value) => 
		value?.Value;

    [CqlDeclaration("ToString")]
	public ObservationDefinition.ObservationRangeCategory? ToString(Code<ObservationDefinition.ObservationRangeCategory> value) => 
		value?.Value;

    [CqlDeclaration("ToString")]
	public OperationDefinition.OperationKind? ToString(Code<OperationDefinition.OperationKind> value) => 
		value?.Value;

    [CqlDeclaration("ToString")]
	public OperationParameterUse? ToString(Code<OperationParameterUse> value) => 
		value?.Value;

    [CqlDeclaration("ToString")]
	public MolecularSequence.OrientationType? ToString(Code<MolecularSequence.OrientationType> value) => 
		value?.Value;

    [CqlDeclaration("ToString")]
	public Appointment.ParticipantRequired? ToString(Code<Appointment.ParticipantRequired> value) => 
		value?.Value;

    [CqlDeclaration("ToString")]
	public ParticipationStatus? ToString(Code<ParticipationStatus> value) => 
		value?.Value;

    [CqlDeclaration("ToString")]
	public ElementDefinition.PropertyRepresentation? ToString(Code<ElementDefinition.PropertyRepresentation> value) => 
		value?.Value;

    [CqlDeclaration("ToString")]
	public CodeSystem.PropertyType? ToString(Code<CodeSystem.PropertyType> value) => 
		value?.Value;

    [CqlDeclaration("ToString")]
	public Provenance.ProvenanceEntityRole? ToString(Code<Provenance.ProvenanceEntityRole> value) => 
		value?.Value;

    [CqlDeclaration("ToString")]
	public PublicationStatus? ToString(Code<PublicationStatus> value) => 
		value?.Value;

    [CqlDeclaration("ToString")]
	public MolecularSequence.QualityType? ToString(Code<MolecularSequence.QualityType> value) => 
		value?.Value;

    [CqlDeclaration("ToString")]
	public Quantity.QuantityComparator? ToString(Code<Quantity.QuantityComparator> value) => 
		value?.Value;

    [CqlDeclaration("ToString")]
	public Questionnaire.QuestionnaireItemOperator? ToString(Code<Questionnaire.QuestionnaireItemOperator> value) => 
		value?.Value;

    [CqlDeclaration("ToString")]
	public Questionnaire.QuestionnaireItemType? ToString(Code<Questionnaire.QuestionnaireItemType> value) => 
		value?.Value;

    [CqlDeclaration("ToString")]
	public QuestionnaireResponse.QuestionnaireResponseStatus? ToString(Code<QuestionnaireResponse.QuestionnaireResponseStatus> value) => 
		value?.Value;

    [CqlDeclaration("ToString")]
	public CapabilityStatement.ReferenceHandlingPolicy? ToString(Code<CapabilityStatement.ReferenceHandlingPolicy> value) => 
		value?.Value;

    [CqlDeclaration("ToString")]
	public ElementDefinition.ReferenceVersionRules? ToString(Code<ElementDefinition.ReferenceVersionRules> value) => 
		value?.Value;

    [CqlDeclaration("ToString")]
	public RelatedArtifact.RelatedArtifactType? ToString(Code<RelatedArtifact.RelatedArtifactType> value) => 
		value?.Value;

    [CqlDeclaration("ToString")]
	public ClaimProcessingCodes? ToString(Code<ClaimProcessingCodes> value) => 
		value?.Value;

    [CqlDeclaration("ToString")]
	public MolecularSequence.RepositoryType? ToString(Code<MolecularSequence.RepositoryType> value) => 
		value?.Value;

    [CqlDeclaration("ToString")]
	public ResearchElementDefinition.ResearchElementType? ToString(Code<ResearchElementDefinition.ResearchElementType> value) => 
		value?.Value;

    [CqlDeclaration("ToString")]
	public ResearchStudy.ResearchStudyStatus? ToString(Code<ResearchStudy.ResearchStudyStatus> value) => 
		value?.Value;

    [CqlDeclaration("ToString")]
	public ResearchSubject.ResearchSubjectStatus? ToString(Code<ResearchSubject.ResearchSubjectStatus> value) => 
		value?.Value;

    [CqlDeclaration("ToString")]
	public CapabilityStatement.ResourceVersionPolicy? ToString(Code<CapabilityStatement.ResourceVersionPolicy> value) => 
		value?.Value;

    [CqlDeclaration("ToString")]
	public MessageHeader.ResponseType? ToString(Code<MessageHeader.ResponseType> value) => 
		value?.Value;

    [CqlDeclaration("ToString")]
	public CapabilityStatement.RestfulCapabilityMode? ToString(Code<CapabilityStatement.RestfulCapabilityMode> value) => 
		value?.Value;

    [CqlDeclaration("ToString")]
	public ImplementationGuide.SPDXLicense? ToString(Code<ImplementationGuide.SPDXLicense> value) => 
		value?.Value;

    [CqlDeclaration("ToString")]
	public SearchParameter.SearchComparator? ToString(Code<SearchParameter.SearchComparator> value) => 
		value?.Value;

    [CqlDeclaration("ToString")]
	public Bundle.SearchEntryMode? ToString(Code<Bundle.SearchEntryMode> value) => 
		value?.Value;

    [CqlDeclaration("ToString")]
	public SearchParameter.SearchModifierCode? ToString(Code<SearchParameter.SearchModifierCode> value) => 
		value?.Value;

    [CqlDeclaration("ToString")]
	public SearchParamType? ToString(Code<SearchParamType> value) => 
		value?.Value;

    [CqlDeclaration("ToString")]
	public MolecularSequence.SequenceType? ToString(Code<MolecularSequence.SequenceType> value) => 
		value?.Value;

    [CqlDeclaration("ToString")]
	public ElementDefinition.SlicingRules? ToString(Code<ElementDefinition.SlicingRules> value) => 
		value?.Value;

    [CqlDeclaration("ToString")]
	public Slot.SlotStatus? ToString(Code<Slot.SlotStatus> value) => 
		value?.Value;

    [CqlDeclaration("ToString")]
	public DataRequirement.SortDirection? ToString(Code<DataRequirement.SortDirection> value) => 
		value?.Value;

    [CqlDeclaration("ToString")]
	public SpecimenDefinition.SpecimenContainedPreference? ToString(Code<SpecimenDefinition.SpecimenContainedPreference> value) => 
		value?.Value;

    [CqlDeclaration("ToString")]
	public Specimen.SpecimenStatus? ToString(Code<Specimen.SpecimenStatus> value) => 
		value?.Value;

    [CqlDeclaration("ToString")]
	public VerificationResult.StatusCode? ToString(Code<VerificationResult.StatusCode> value) => 
		value?.Value;

    [CqlDeclaration("ToString")]
	public MolecularSequence.StrandType? ToString(Code<MolecularSequence.StrandType> value) => 
		value?.Value;

    [CqlDeclaration("ToString")]
	public StructureDefinition.StructureDefinitionKind? ToString(Code<StructureDefinition.StructureDefinitionKind> value) => 
		value?.Value;

    [CqlDeclaration("ToString")]
	public StructureMap.StructureMapContextType? ToString(Code<StructureMap.StructureMapContextType> value) => 
		value?.Value;

    [CqlDeclaration("ToString")]
	public StructureMap.StructureMapGroupTypeMode? ToString(Code<StructureMap.StructureMapGroupTypeMode> value) => 
		value?.Value;

    [CqlDeclaration("ToString")]
	public StructureMap.StructureMapInputMode? ToString(Code<StructureMap.StructureMapInputMode> value) => 
		value?.Value;

    [CqlDeclaration("ToString")]
	public StructureMap.StructureMapModelMode? ToString(Code<StructureMap.StructureMapModelMode> value) => 
		value?.Value;

    [CqlDeclaration("ToString")]
	public StructureMap.StructureMapSourceListMode? ToString(Code<StructureMap.StructureMapSourceListMode> value) => 
		value?.Value;

    [CqlDeclaration("ToString")]
	public StructureMap.StructureMapTargetListMode? ToString(Code<StructureMap.StructureMapTargetListMode> value) => 
		value?.Value;

    [CqlDeclaration("ToString")]
	public StructureMap.StructureMapTransform? ToString(Code<StructureMap.StructureMapTransform> value) => 
		value?.Value;

    [CqlDeclaration("ToString")]
	public Subscription.SubscriptionChannelType? ToString(Code<Subscription.SubscriptionChannelType> value) => 
		value?.Value;

    [CqlDeclaration("ToString")]
	public Subscription.SubscriptionStatus? ToString(Code<Subscription.SubscriptionStatus> value) => 
		value?.Value;

    [CqlDeclaration("ToString")]
	public SupplyDelivery.SupplyDeliveryStatus? ToString(Code<SupplyDelivery.SupplyDeliveryStatus> value) => 
		value?.Value;

    [CqlDeclaration("ToString")]
	public SupplyRequest.SupplyRequestStatus? ToString(Code<SupplyRequest.SupplyRequestStatus> value) => 
		value?.Value;

    [CqlDeclaration("ToString")]
	public CapabilityStatement.SystemRestfulInteraction? ToString(Code<CapabilityStatement.SystemRestfulInteraction> value) => 
		value?.Value;

    [CqlDeclaration("ToString")]
	public Task.TaskIntent? ToString(Code<Task.TaskIntent> value) => 
		value?.Value;

    [CqlDeclaration("ToString")]
	public Task.TaskStatus? ToString(Code<Task.TaskStatus> value) => 
		value?.Value;

    [CqlDeclaration("ToString")]
	public TestReport.TestReportActionResult? ToString(Code<TestReport.TestReportActionResult> value) => 
		value?.Value;

    [CqlDeclaration("ToString")]
	public TestReport.TestReportParticipantType? ToString(Code<TestReport.TestReportParticipantType> value) => 
		value?.Value;

    [CqlDeclaration("ToString")]
	public TestReport.TestReportResult? ToString(Code<TestReport.TestReportResult> value) => 
		value?.Value;

    [CqlDeclaration("ToString")]
	public TestReport.TestReportStatus? ToString(Code<TestReport.TestReportStatus> value) => 
		value?.Value;

    [CqlDeclaration("ToString")]
	public TestScript.TestScriptRequestMethodCode? ToString(Code<TestScript.TestScriptRequestMethodCode> value) => 
		value?.Value;

    [CqlDeclaration("ToString")]
	public TriggerDefinition.TriggerType? ToString(Code<TriggerDefinition.TriggerType> value) => 
		value?.Value;

    [CqlDeclaration("ToString")]
	public StructureDefinition.TypeDerivationRule? ToString(Code<StructureDefinition.TypeDerivationRule> value) => 
		value?.Value;

    [CqlDeclaration("ToString")]
	public CapabilityStatement.TypeRestfulInteraction? ToString(Code<CapabilityStatement.TypeRestfulInteraction> value) => 
		value?.Value;

    [CqlDeclaration("ToString")]
	public Device.UDIEntryType? ToString(Code<Device.UDIEntryType> value) => 
		value?.Value;

    [CqlDeclaration("ToString")]
	public Timing.UnitsOfTime? ToString(Code<Timing.UnitsOfTime> value) => 
		value?.Value;

    [CqlDeclaration("ToString")]
	public ClaimUseCode? ToString(Code<ClaimUseCode> value) => 
		value?.Value;

    [CqlDeclaration("ToString")]
	public VisionPrescription.VisionBase? ToString(Code<VisionPrescription.VisionBase> value) => 
		value?.Value;

    [CqlDeclaration("ToString")]
	public VisionPrescription.VisionEyes? ToString(Code<VisionPrescription.VisionEyes> value) => 
		value?.Value;

    [CqlDeclaration("ToString")]
	public SearchParameter.XPathUsageType? ToString(Code<SearchParameter.XPathUsageType> value) => 
		value?.Value;

    [CqlDeclaration("ToString")]
	public string ToString(Base64Binary value)
	{
		var a_ = context.Operators.Convert<string>(value?.Value);

		return a_;
	}

    [CqlDeclaration("ToString")]
	public string ToString(Id value) => 
		value?.Value;

    [CqlDeclaration("ToString")]
	public string ToString(FhirString value) => 
		value?.Value;

    [CqlDeclaration("ToString")]
	public string ToString(FhirUri value) => 
		value?.Value;

    [CqlDeclaration("ToString")]
	public string ToString(XHtml value) => 
		value?.Value;

    [CqlDeclaration("ToBoolean")]
	public bool? ToBoolean(FhirBoolean value) => 
		value?.Value;

    [CqlDeclaration("ToDate")]
	public CqlDate ToDate(Date value)
	{
		var a_ = context.Operators.ConvertStringToDate(value?.Value);

		return a_;
	}

    [CqlDeclaration("ToDateTime")]
	public CqlDateTime ToDateTime(FhirDateTime value)
	{
		var a_ = context.Operators.Convert<CqlDateTime>(value);

		return a_;
	}

    [CqlDeclaration("ToDateTime")]
	public CqlDateTime ToDateTime(Instant value)
	{
		var a_ = context.Operators.Convert<CqlDateTime>(value?.Value);

		return a_;
	}

    [CqlDeclaration("ToDecimal")]
	public decimal? ToDecimal(FhirDecimal value) => 
		value?.Value;

    [CqlDeclaration("ToInteger")]
	public int? ToInteger(Integer value) => 
		value?.Value;

    [CqlDeclaration("ToTime")]
	public CqlTime ToTime(Time value)
	{
		var a_ = context.Operators.ConvertStringToTime(value?.Value);

		return a_;
	}

}
using System;
using System.Linq;
using System.Collections.Generic;
using Hl7.Cql.Runtime;
using Hl7.Cql.Primitives;
using Hl7.Cql.Abstractions;
using Hl7.Cql.ValueSets;
using Hl7.Cql.Iso8601;
using System.Reflection;
using Hl7.Fhir.Model;
using Range = Hl7.Fhir.Model.Range;
using Task = Hl7.Fhir.Model.Task;
[System.CodeDom.Compiler.GeneratedCode(".NET Code Generation", "2.0.0.0")]
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
		var a_ = context?.Operators.RetrieveByValueSet<Patient>(null, null);
		var b_ = context?.Operators.SingletonFrom<Patient>(a_);

		return b_;
	}

    [CqlDeclaration("Patient")]
	public Patient Patient() => 
		__Patient?.Value;

    [CqlDeclaration("ToInterval")]
	public CqlInterval<CqlDateTime> ToInterval(Period period)
	{
		CqlInterval<CqlDateTime> a_()
		{
			if ((period is null))
			{
				return (null as CqlInterval<CqlDateTime>);
			}
			else
			{
				var b_ = context?.Operators.Convert<CqlDateTime>(period.StartElement);
				var c_ = context?.Operators.Convert<CqlDateTime>(period.EndElement);
				var d_ = context?.Operators.Interval(b_, c_, true, true);

				return d_;
			}
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
				return (null as CqlInterval<CqlQuantity>);
			}
			else
			{
				var b_ = this.ToQuantity(range.Low);
				var c_ = this.ToQuantity(range.High);
				var d_ = context?.Operators.Interval(b_, c_, true, true);

				return d_;
			}
		};

		return a_();
	}

    [CqlDeclaration("ToQuantity")]
	public CqlQuantity ToQuantity(Quantity quantity)
	{
		CqlQuantity a_()
		{
			if ((quantity is null))
			{
				return null;
			}
			else
			{
				return new CqlQuantity(quantity.ValueElement.Value, quantity.UnitElement.Value);
			}
		};

		return a_();
	}

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
				var b_ = this.ToQuantity(ratio.Numerator);
				var c_ = this.ToQuantity(ratio.Denominator);

				return new CqlRatio(b_, c_);
			}
		};

		return a_();
	}

    [CqlDeclaration("ToCode")]
	public CqlCode ToCode(Coding coding)
	{
		CqlCode a_()
		{
			if ((coding is null))
			{
				return null;
			}
			else
			{
				return new CqlCode(coding.CodeElement.Value, coding.SystemElement.Value, coding.VersionElement.Value, coding.DisplayElement.Value);
			}
		};

		return a_();
	}

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
				var c_ = context?.Operators.Select<Coding, CqlCode>((IEnumerable<Coding>)concept.Coding, b_);

				return new CqlConcept(c_, concept.TextElement.Value);
			}
		};

		return a_();
	}

    [CqlDeclaration("ToString")]
	public string ToString(Code<Account.AccountStatus> value)
	{
		var a_ = context?.Operators.Convert<string>(value.Value);

		return a_;
	}

    [CqlDeclaration("ToString")]
	public string ToString(Code<ActionCardinalityBehavior> value)
	{
		var a_ = context?.Operators.Convert<string>(value.Value);

		return a_;
	}

    [CqlDeclaration("ToString")]
	public string ToString(Code<ActionConditionKind> value)
	{
		var a_ = context?.Operators.Convert<string>(value.Value);

		return a_;
	}

    [CqlDeclaration("ToString")]
	public string ToString(Code<ActionGroupingBehavior> value)
	{
		var a_ = context?.Operators.Convert<string>(value.Value);

		return a_;
	}

    [CqlDeclaration("ToString")]
	public string ToString(Code<ActionParticipantType> value)
	{
		var a_ = context?.Operators.Convert<string>(value.Value);

		return a_;
	}

    [CqlDeclaration("ToString")]
	public string ToString(Code<ActionPrecheckBehavior> value)
	{
		var a_ = context?.Operators.Convert<string>(value.Value);

		return a_;
	}

    [CqlDeclaration("ToString")]
	public string ToString(Code<ActionRelationshipType> value)
	{
		var a_ = context?.Operators.Convert<string>(value.Value);

		return a_;
	}

    [CqlDeclaration("ToString")]
	public string ToString(Code<ActionRequiredBehavior> value)
	{
		var a_ = context?.Operators.Convert<string>(value.Value);

		return a_;
	}

    [CqlDeclaration("ToString")]
	public string ToString(Code<ActionSelectionBehavior> value)
	{
		var a_ = context?.Operators.Convert<string>(value.Value);

		return a_;
	}

    [CqlDeclaration("ToString")]
	public string ToString(Code<ActivityDefinition.RequestResourceType> value)
	{
		var a_ = context?.Operators.Convert<string>(value.Value);

		return a_;
	}

    [CqlDeclaration("ToString")]
	public string ToString(Code<Address.AddressType> value)
	{
		var a_ = context?.Operators.Convert<string>(value.Value);

		return a_;
	}

    [CqlDeclaration("ToString")]
	public string ToString(Code<Address.AddressUse> value)
	{
		var a_ = context?.Operators.Convert<string>(value.Value);

		return a_;
	}

    [CqlDeclaration("ToString")]
	public string ToString(Code<AdministrativeGender> value)
	{
		var a_ = context?.Operators.Convert<string>(value.Value);

		return a_;
	}

    [CqlDeclaration("ToString")]
	public string ToString(Code<AdverseEvent.AdverseEventActuality> value)
	{
		var a_ = context?.Operators.Convert<string>(value.Value);

		return a_;
	}

    [CqlDeclaration("ToString")]
	public string ToString(Code<ElementDefinition.AggregationMode> value)
	{
		var a_ = context?.Operators.Convert<string>(value.Value);

		return a_;
	}

    [CqlDeclaration("ToString")]
	public string ToString(Code<AllergyIntolerance.AllergyIntoleranceCategory> value)
	{
		var a_ = context?.Operators.Convert<string>(value.Value);

		return a_;
	}

    [CqlDeclaration("ToString")]
	public string ToString(Code<AllergyIntolerance.AllergyIntoleranceCriticality> value)
	{
		var a_ = context?.Operators.Convert<string>(value.Value);

		return a_;
	}

    [CqlDeclaration("ToString")]
	public string ToString(Code<AllergyIntolerance.AllergyIntoleranceSeverity> value)
	{
		var a_ = context?.Operators.Convert<string>(value.Value);

		return a_;
	}

    [CqlDeclaration("ToString")]
	public string ToString(Code<AllergyIntolerance.AllergyIntoleranceType> value)
	{
		var a_ = context?.Operators.Convert<string>(value.Value);

		return a_;
	}

    [CqlDeclaration("ToString")]
	public string ToString(Code<Appointment.AppointmentStatus> value)
	{
		var a_ = context?.Operators.Convert<string>(value.Value);

		return a_;
	}

    [CqlDeclaration("ToString")]
	public string ToString(Code<TestScript.AssertionDirectionType> value)
	{
		var a_ = context?.Operators.Convert<string>(value.Value);

		return a_;
	}

    [CqlDeclaration("ToString")]
	public string ToString(Code<TestScript.AssertionOperatorType> value)
	{
		var a_ = context?.Operators.Convert<string>(value.Value);

		return a_;
	}

    [CqlDeclaration("ToString")]
	public string ToString(Code<TestScript.AssertionResponseTypes> value)
	{
		var a_ = context?.Operators.Convert<string>(value.Value);

		return a_;
	}

    [CqlDeclaration("ToString")]
	public string ToString(Code<AuditEvent.AuditEventAction> value)
	{
		var a_ = context?.Operators.Convert<string>(value.Value);

		return a_;
	}

    [CqlDeclaration("ToString")]
	public string ToString(Code<AuditEvent.AuditEventAgentNetworkType> value)
	{
		var a_ = context?.Operators.Convert<string>(value.Value);

		return a_;
	}

    [CqlDeclaration("ToString")]
	public string ToString(Code<AuditEvent.AuditEventOutcome> value)
	{
		var a_ = context?.Operators.Convert<string>(value.Value);

		return a_;
	}

    [CqlDeclaration("ToString")]
	public string ToString(Code<BindingStrength> value)
	{
		var a_ = context?.Operators.Convert<string>(value.Value);

		return a_;
	}

    [CqlDeclaration("ToString")]
	public string ToString(Code<BiologicallyDerivedProduct.BiologicallyDerivedProductCategory> value)
	{
		var a_ = context?.Operators.Convert<string>(value.Value);

		return a_;
	}

    [CqlDeclaration("ToString")]
	public string ToString(Code<BiologicallyDerivedProduct.BiologicallyDerivedProductStatus> value)
	{
		var a_ = context?.Operators.Convert<string>(value.Value);

		return a_;
	}

    [CqlDeclaration("ToString")]
	public string ToString(Code<BiologicallyDerivedProduct.BiologicallyDerivedProductStorageScale> value)
	{
		var a_ = context?.Operators.Convert<string>(value.Value);

		return a_;
	}

    [CqlDeclaration("ToString")]
	public string ToString(Code<Bundle.BundleType> value)
	{
		var a_ = context?.Operators.Convert<string>(value.Value);

		return a_;
	}

    [CqlDeclaration("ToString")]
	public string ToString(Code<CapabilityStatementKind> value)
	{
		var a_ = context?.Operators.Convert<string>(value.Value);

		return a_;
	}

    [CqlDeclaration("ToString")]
	public string ToString(Code<CarePlan.CarePlanActivityKind> value)
	{
		var a_ = context?.Operators.Convert<string>(value.Value);

		return a_;
	}

    [CqlDeclaration("ToString")]
	public string ToString(Code<CarePlan.CarePlanActivityStatus> value)
	{
		var a_ = context?.Operators.Convert<string>(value.Value);

		return a_;
	}

    [CqlDeclaration("ToString")]
	public string ToString(Code<CarePlan.CarePlanIntent> value)
	{
		var a_ = context?.Operators.Convert<string>(value.Value);

		return a_;
	}

    [CqlDeclaration("ToString")]
	public string ToString(Code<RequestStatus> value)
	{
		var a_ = context?.Operators.Convert<string>(value.Value);

		return a_;
	}

    [CqlDeclaration("ToString")]
	public string ToString(Code<CareTeam.CareTeamStatus> value)
	{
		var a_ = context?.Operators.Convert<string>(value.Value);

		return a_;
	}

    [CqlDeclaration("ToString")]
	public string ToString(Code<CatalogEntry.CatalogEntryRelationType> value)
	{
		var a_ = context?.Operators.Convert<string>(value.Value);

		return a_;
	}

    [CqlDeclaration("ToString")]
	public string ToString(Code<InvoicePriceComponentType> value)
	{
		var a_ = context?.Operators.Convert<string>(value.Value);

		return a_;
	}

    [CqlDeclaration("ToString")]
	public string ToString(Code<ChargeItem.ChargeItemStatus> value)
	{
		var a_ = context?.Operators.Convert<string>(value.Value);

		return a_;
	}

    [CqlDeclaration("ToString")]
	public string ToString(Code<FinancialResourceStatusCodes> value)
	{
		var a_ = context?.Operators.Convert<string>(value.Value);

		return a_;
	}

    [CqlDeclaration("ToString")]
	public string ToString(Code<ClinicalImpression.ClinicalImpressionStatus> value)
	{
		var a_ = context?.Operators.Convert<string>(value.Value);

		return a_;
	}

    [CqlDeclaration("ToString")]
	public string ToString(Code<TerminologyCapabilities.CodeSearchSupport> value)
	{
		var a_ = context?.Operators.Convert<string>(value.Value);

		return a_;
	}

    [CqlDeclaration("ToString")]
	public string ToString(Code<CodeSystemContentMode> value)
	{
		var a_ = context?.Operators.Convert<string>(value.Value);

		return a_;
	}

    [CqlDeclaration("ToString")]
	public string ToString(Code<CodeSystem.CodeSystemHierarchyMeaning> value)
	{
		var a_ = context?.Operators.Convert<string>(value.Value);

		return a_;
	}

    [CqlDeclaration("ToString")]
	public string ToString(Code<RequestPriority> value)
	{
		var a_ = context?.Operators.Convert<string>(value.Value);

		return a_;
	}

    [CqlDeclaration("ToString")]
	public string ToString(Code<EventStatus> value)
	{
		var a_ = context?.Operators.Convert<string>(value.Value);

		return a_;
	}

    [CqlDeclaration("ToString")]
	public string ToString(Code<CompartmentType> value)
	{
		var a_ = context?.Operators.Convert<string>(value.Value);

		return a_;
	}

    [CqlDeclaration("ToString")]
	public string ToString(Code<Composition.CompositionAttestationMode> value)
	{
		var a_ = context?.Operators.Convert<string>(value.Value);

		return a_;
	}

    [CqlDeclaration("ToString")]
	public string ToString(Code<CompositionStatus> value)
	{
		var a_ = context?.Operators.Convert<string>(value.Value);

		return a_;
	}

    [CqlDeclaration("ToString")]
	public string ToString(Code<ConceptMapEquivalence> value)
	{
		var a_ = context?.Operators.Convert<string>(value.Value);

		return a_;
	}

    [CqlDeclaration("ToString")]
	public string ToString(Code<ConceptMap.ConceptMapGroupUnmappedMode> value)
	{
		var a_ = context?.Operators.Convert<string>(value.Value);

		return a_;
	}

    [CqlDeclaration("ToString")]
	public string ToString(Code<CapabilityStatement.ConditionalDeleteStatus> value)
	{
		var a_ = context?.Operators.Convert<string>(value.Value);

		return a_;
	}

    [CqlDeclaration("ToString")]
	public string ToString(Code<CapabilityStatement.ConditionalReadStatus> value)
	{
		var a_ = context?.Operators.Convert<string>(value.Value);

		return a_;
	}

    [CqlDeclaration("ToString")]
	public string ToString(Code<Consent.ConsentDataMeaning> value)
	{
		var a_ = context?.Operators.Convert<string>(value.Value);

		return a_;
	}

    [CqlDeclaration("ToString")]
	public string ToString(Code<Consent.ConsentProvisionType> value)
	{
		var a_ = context?.Operators.Convert<string>(value.Value);

		return a_;
	}

    [CqlDeclaration("ToString")]
	public string ToString(Code<Consent.ConsentState> value)
	{
		var a_ = context?.Operators.Convert<string>(value.Value);

		return a_;
	}

    [CqlDeclaration("ToString")]
	public string ToString(Code<ConstraintSeverity> value)
	{
		var a_ = context?.Operators.Convert<string>(value.Value);

		return a_;
	}

    [CqlDeclaration("ToString")]
	public string ToString(Code<ContactPoint.ContactPointSystem> value)
	{
		var a_ = context?.Operators.Convert<string>(value.Value);

		return a_;
	}

    [CqlDeclaration("ToString")]
	public string ToString(Code<ContactPoint.ContactPointUse> value)
	{
		var a_ = context?.Operators.Convert<string>(value.Value);

		return a_;
	}

    [CqlDeclaration("ToString")]
	public string ToString(Code<Contract.ContractResourcePublicationStatusCodes> value)
	{
		var a_ = context?.Operators.Convert<string>(value.Value);

		return a_;
	}

    [CqlDeclaration("ToString")]
	public string ToString(Code<Contract.ContractResourceStatusCodes> value)
	{
		var a_ = context?.Operators.Convert<string>(value.Value);

		return a_;
	}

    [CqlDeclaration("ToString")]
	public string ToString(Code<Contributor.ContributorType> value)
	{
		var a_ = context?.Operators.Convert<string>(value.Value);

		return a_;
	}

    [CqlDeclaration("ToString")]
	public string ToString(Code<Money.Currencies> value)
	{
		var a_ = context?.Operators.Convert<string>(value.Value);

		return a_;
	}

    [CqlDeclaration("ToString")]
	public string ToString(Code<DaysOfWeek> value)
	{
		var a_ = context?.Operators.Convert<string>(value.Value);

		return a_;
	}

    [CqlDeclaration("ToString")]
	public string ToString(Code<DetectedIssue.DetectedIssueSeverity> value)
	{
		var a_ = context?.Operators.Convert<string>(value.Value);

		return a_;
	}

    [CqlDeclaration("ToString")]
	public string ToString(Code<ObservationStatus> value)
	{
		var a_ = context?.Operators.Convert<string>(value.Value);

		return a_;
	}

    [CqlDeclaration("ToString")]
	public string ToString(Code<DeviceMetric.DeviceMetricCalibrationState> value)
	{
		var a_ = context?.Operators.Convert<string>(value.Value);

		return a_;
	}

    [CqlDeclaration("ToString")]
	public string ToString(Code<DeviceMetric.DeviceMetricCalibrationType> value)
	{
		var a_ = context?.Operators.Convert<string>(value.Value);

		return a_;
	}

    [CqlDeclaration("ToString")]
	public string ToString(Code<DeviceMetric.DeviceMetricCategory> value)
	{
		var a_ = context?.Operators.Convert<string>(value.Value);

		return a_;
	}

    [CqlDeclaration("ToString")]
	public string ToString(Code<DeviceMetric.DeviceMetricColor> value)
	{
		var a_ = context?.Operators.Convert<string>(value.Value);

		return a_;
	}

    [CqlDeclaration("ToString")]
	public string ToString(Code<DeviceMetric.DeviceMetricOperationalStatus> value)
	{
		var a_ = context?.Operators.Convert<string>(value.Value);

		return a_;
	}

    [CqlDeclaration("ToString")]
	public string ToString(Code<DeviceNameType> value)
	{
		var a_ = context?.Operators.Convert<string>(value.Value);

		return a_;
	}

    [CqlDeclaration("ToString")]
	public string ToString(Code<DeviceUseStatement.DeviceUseStatementStatus> value)
	{
		var a_ = context?.Operators.Convert<string>(value.Value);

		return a_;
	}

    [CqlDeclaration("ToString")]
	public string ToString(Code<DiagnosticReport.DiagnosticReportStatus> value)
	{
		var a_ = context?.Operators.Convert<string>(value.Value);

		return a_;
	}

    [CqlDeclaration("ToString")]
	public string ToString(Code<ElementDefinition.DiscriminatorType> value)
	{
		var a_ = context?.Operators.Convert<string>(value.Value);

		return a_;
	}

    [CqlDeclaration("ToString")]
	public string ToString(Code<Composition.V3ConfidentialityClassification> value)
	{
		var a_ = context?.Operators.Convert<string>(value.Value);

		return a_;
	}

    [CqlDeclaration("ToString")]
	public string ToString(Code<CapabilityStatement.DocumentMode> value)
	{
		var a_ = context?.Operators.Convert<string>(value.Value);

		return a_;
	}

    [CqlDeclaration("ToString")]
	public string ToString(Code<DocumentReferenceStatus> value)
	{
		var a_ = context?.Operators.Convert<string>(value.Value);

		return a_;
	}

    [CqlDeclaration("ToString")]
	public string ToString(Code<DocumentRelationshipType> value)
	{
		var a_ = context?.Operators.Convert<string>(value.Value);

		return a_;
	}

    [CqlDeclaration("ToString")]
	public string ToString(Code<CoverageEligibilityRequest.EligibilityRequestPurpose> value)
	{
		var a_ = context?.Operators.Convert<string>(value.Value);

		return a_;
	}

    [CqlDeclaration("ToString")]
	public string ToString(Code<CoverageEligibilityResponse.EligibilityResponsePurpose> value)
	{
		var a_ = context?.Operators.Convert<string>(value.Value);

		return a_;
	}

    [CqlDeclaration("ToString")]
	public string ToString(Code<Questionnaire.EnableWhenBehavior> value)
	{
		var a_ = context?.Operators.Convert<string>(value.Value);

		return a_;
	}

    [CqlDeclaration("ToString")]
	public string ToString(Code<Encounter.EncounterLocationStatus> value)
	{
		var a_ = context?.Operators.Convert<string>(value.Value);

		return a_;
	}

    [CqlDeclaration("ToString")]
	public string ToString(Code<Encounter.EncounterStatus> value)
	{
		var a_ = context?.Operators.Convert<string>(value.Value);

		return a_;
	}

    [CqlDeclaration("ToString")]
	public string ToString(Code<Endpoint.EndpointStatus> value)
	{
		var a_ = context?.Operators.Convert<string>(value.Value);

		return a_;
	}

    [CqlDeclaration("ToString")]
	public string ToString(Code<EpisodeOfCare.EpisodeOfCareStatus> value)
	{
		var a_ = context?.Operators.Convert<string>(value.Value);

		return a_;
	}

    [CqlDeclaration("ToString")]
	public string ToString(Code<CapabilityStatement.EventCapabilityMode> value)
	{
		var a_ = context?.Operators.Convert<string>(value.Value);

		return a_;
	}

    [CqlDeclaration("ToString")]
	public string ToString(Code<Timing.EventTiming> value)
	{
		var a_ = context?.Operators.Convert<string>(value.Value);

		return a_;
	}

    [CqlDeclaration("ToString")]
	public string ToString(Code<VariableTypeCode> value)
	{
		var a_ = context?.Operators.Convert<string>(value.Value);

		return a_;
	}

    [CqlDeclaration("ToString")]
	public string ToString(Code<ExampleScenario.ExampleScenarioActorType> value)
	{
		var a_ = context?.Operators.Convert<string>(value.Value);

		return a_;
	}

    [CqlDeclaration("ToString")]
	public string ToString(Code<ExplanationOfBenefit.ExplanationOfBenefitStatus> value)
	{
		var a_ = context?.Operators.Convert<string>(value.Value);

		return a_;
	}

    [CqlDeclaration("ToString")]
	public string ToString(Code<EffectEvidenceSynthesis.ExposureStateCode> value)
	{
		var a_ = context?.Operators.Convert<string>(value.Value);

		return a_;
	}

    [CqlDeclaration("ToString")]
	public string ToString(Code<StructureDefinition.ExtensionContextType> value)
	{
		var a_ = context?.Operators.Convert<string>(value.Value);

		return a_;
	}

    [CqlDeclaration("ToString")]
	public string ToString(Code<FHIRAllTypes> value)
	{
		var a_ = context?.Operators.Convert<string>(value.Value);

		return a_;
	}

    [CqlDeclaration("ToString")]
	public string ToString(Code<FHIRDefinedType> value)
	{
		var a_ = context?.Operators.Convert<string>(value.Value);

		return a_;
	}

    [CqlDeclaration("ToString")]
	public string ToString(Code<Device.FHIRDeviceStatus> value)
	{
		var a_ = context?.Operators.Convert<string>(value.Value);

		return a_;
	}

    [CqlDeclaration("ToString")]
	public string ToString(Code<ResourceType> value)
	{
		var a_ = context?.Operators.Convert<string>(value.Value);

		return a_;
	}

    [CqlDeclaration("ToString")]
	public string ToString(Code<Substance.FHIRSubstanceStatus> value)
	{
		var a_ = context?.Operators.Convert<string>(value.Value);

		return a_;
	}

    [CqlDeclaration("ToString")]
	public string ToString(Code<FHIRVersion> value)
	{
		var a_ = context?.Operators.Convert<string>(value.Value);

		return a_;
	}

    [CqlDeclaration("ToString")]
	public string ToString(Code<FamilyMemberHistory.FamilyHistoryStatus> value)
	{
		var a_ = context?.Operators.Convert<string>(value.Value);

		return a_;
	}

    [CqlDeclaration("ToString")]
	public string ToString(Code<FilterOperator> value)
	{
		var a_ = context?.Operators.Convert<string>(value.Value);

		return a_;
	}

    [CqlDeclaration("ToString")]
	public string ToString(Code<Flag.FlagStatus> value)
	{
		var a_ = context?.Operators.Convert<string>(value.Value);

		return a_;
	}

    [CqlDeclaration("ToString")]
	public string ToString(Code<Goal.GoalLifecycleStatus> value)
	{
		var a_ = context?.Operators.Convert<string>(value.Value);

		return a_;
	}

    [CqlDeclaration("ToString")]
	public string ToString(Code<GraphDefinition.GraphCompartmentRule> value)
	{
		var a_ = context?.Operators.Convert<string>(value.Value);

		return a_;
	}

    [CqlDeclaration("ToString")]
	public string ToString(Code<GraphDefinition.GraphCompartmentUse> value)
	{
		var a_ = context?.Operators.Convert<string>(value.Value);

		return a_;
	}

    [CqlDeclaration("ToString")]
	public string ToString(Code<GroupMeasureCode> value)
	{
		var a_ = context?.Operators.Convert<string>(value.Value);

		return a_;
	}

    [CqlDeclaration("ToString")]
	public string ToString(Code<Group.GroupType> value)
	{
		var a_ = context?.Operators.Convert<string>(value.Value);

		return a_;
	}

    [CqlDeclaration("ToString")]
	public string ToString(Code<GuidanceResponse.GuidanceResponseStatus> value)
	{
		var a_ = context?.Operators.Convert<string>(value.Value);

		return a_;
	}

    [CqlDeclaration("ToString")]
	public string ToString(Code<ImplementationGuide.GuidePageGeneration> value)
	{
		var a_ = context?.Operators.Convert<string>(value.Value);

		return a_;
	}

    [CqlDeclaration("ToString")]
	public string ToString(Code<ImplementationGuide.GuideParameterCode> value)
	{
		var a_ = context?.Operators.Convert<string>(value.Value);

		return a_;
	}

    [CqlDeclaration("ToString")]
	public string ToString(Code<Bundle.HTTPVerb> value)
	{
		var a_ = context?.Operators.Convert<string>(value.Value);

		return a_;
	}

    [CqlDeclaration("ToString")]
	public string ToString(Code<Identifier.IdentifierUse> value)
	{
		var a_ = context?.Operators.Convert<string>(value.Value);

		return a_;
	}

    [CqlDeclaration("ToString")]
	public string ToString(Code<Person.IdentityAssuranceLevel> value)
	{
		var a_ = context?.Operators.Convert<string>(value.Value);

		return a_;
	}

    [CqlDeclaration("ToString")]
	public string ToString(Code<ImagingStudy.ImagingStudyStatus> value)
	{
		var a_ = context?.Operators.Convert<string>(value.Value);

		return a_;
	}

    [CqlDeclaration("ToString")]
	public string ToString(Code<ImmunizationEvaluation.ImmunizationEvaluationStatusCodes> value)
	{
		var a_ = context?.Operators.Convert<string>(value.Value);

		return a_;
	}

    [CqlDeclaration("ToString")]
	public string ToString(Code<Immunization.ImmunizationStatusCodes> value)
	{
		var a_ = context?.Operators.Convert<string>(value.Value);

		return a_;
	}

    [CqlDeclaration("ToString")]
	public string ToString(Code<Invoice.InvoiceStatus> value)
	{
		var a_ = context?.Operators.Convert<string>(value.Value);

		return a_;
	}

    [CqlDeclaration("ToString")]
	public string ToString(Code<OperationOutcome.IssueSeverity> value)
	{
		var a_ = context?.Operators.Convert<string>(value.Value);

		return a_;
	}

    [CqlDeclaration("ToString")]
	public string ToString(Code<OperationOutcome.IssueType> value)
	{
		var a_ = context?.Operators.Convert<string>(value.Value);

		return a_;
	}

    [CqlDeclaration("ToString")]
	public string ToString(Code<Patient.LinkType> value)
	{
		var a_ = context?.Operators.Convert<string>(value.Value);

		return a_;
	}

    [CqlDeclaration("ToString")]
	public string ToString(Code<Linkage.LinkageType> value)
	{
		var a_ = context?.Operators.Convert<string>(value.Value);

		return a_;
	}

    [CqlDeclaration("ToString")]
	public string ToString(Code<ListMode> value)
	{
		var a_ = context?.Operators.Convert<string>(value.Value);

		return a_;
	}

    [CqlDeclaration("ToString")]
	public string ToString(Code<List.ListStatus> value)
	{
		var a_ = context?.Operators.Convert<string>(value.Value);

		return a_;
	}

    [CqlDeclaration("ToString")]
	public string ToString(Code<Location.LocationMode> value)
	{
		var a_ = context?.Operators.Convert<string>(value.Value);

		return a_;
	}

    [CqlDeclaration("ToString")]
	public string ToString(Code<Location.LocationStatus> value)
	{
		var a_ = context?.Operators.Convert<string>(value.Value);

		return a_;
	}

    [CqlDeclaration("ToString")]
	public string ToString(Code<MeasureReport.MeasureReportStatus> value)
	{
		var a_ = context?.Operators.Convert<string>(value.Value);

		return a_;
	}

    [CqlDeclaration("ToString")]
	public string ToString(Code<MeasureReport.MeasureReportType> value)
	{
		var a_ = context?.Operators.Convert<string>(value.Value);

		return a_;
	}

    [CqlDeclaration("ToString")]
	public string ToString(Code<MedicationAdministration.MedicationAdministrationStatusCodes> value)
	{
		var a_ = context?.Operators.Convert<string>(value.Value);

		return a_;
	}

    [CqlDeclaration("ToString")]
	public string ToString(Code<MedicationDispense.MedicationDispenseStatusCodes> value)
	{
		var a_ = context?.Operators.Convert<string>(value.Value);

		return a_;
	}

    [CqlDeclaration("ToString")]
	public string ToString(Code<MedicationKnowledge.MedicationKnowledgeStatusCodes> value)
	{
		var a_ = context?.Operators.Convert<string>(value.Value);

		return a_;
	}

    [CqlDeclaration("ToString")]
	public string ToString(Code<MedicationRequest.MedicationRequestIntent> value)
	{
		var a_ = context?.Operators.Convert<string>(value.Value);

		return a_;
	}

    [CqlDeclaration("ToString")]
	public string ToString(Code<MedicationRequest.MedicationrequestStatus> value)
	{
		var a_ = context?.Operators.Convert<string>(value.Value);

		return a_;
	}

    [CqlDeclaration("ToString")]
	public string ToString(Code<MedicationStatement.MedicationStatusCodes> value)
	{
		var a_ = context?.Operators.Convert<string>(value.Value);

		return a_;
	}

    [CqlDeclaration("ToString")]
	public string ToString(Code<Medication.MedicationStatusCodes> value)
	{
		var a_ = context?.Operators.Convert<string>(value.Value);

		return a_;
	}

    [CqlDeclaration("ToString")]
	public string ToString(Code<MessageDefinition.MessageSignificanceCategory> value)
	{
		var a_ = context?.Operators.Convert<string>(value.Value);

		return a_;
	}

    [CqlDeclaration("ToString")]
	public string ToString(Code<MessageheaderResponseRequest> value)
	{
		var a_ = context?.Operators.Convert<string>(value.Value);

		return a_;
	}

    [CqlDeclaration("ToString")]
	public string ToString(Code value) => 
		value.Value;

    [CqlDeclaration("ToString")]
	public string ToString(Code<HumanName.NameUse> value)
	{
		var a_ = context?.Operators.Convert<string>(value.Value);

		return a_;
	}

    [CqlDeclaration("ToString")]
	public string ToString(Code<NamingSystem.NamingSystemIdentifierType> value)
	{
		var a_ = context?.Operators.Convert<string>(value.Value);

		return a_;
	}

    [CqlDeclaration("ToString")]
	public string ToString(Code<NamingSystem.NamingSystemType> value)
	{
		var a_ = context?.Operators.Convert<string>(value.Value);

		return a_;
	}

    [CqlDeclaration("ToString")]
	public string ToString(Code<Narrative.NarrativeStatus> value)
	{
		var a_ = context?.Operators.Convert<string>(value.Value);

		return a_;
	}

    [CqlDeclaration("ToString")]
	public string ToString(Code<NoteType> value)
	{
		var a_ = context?.Operators.Convert<string>(value.Value);

		return a_;
	}

    [CqlDeclaration("ToString")]
	public string ToString(Code<RequestIntent> value)
	{
		var a_ = context?.Operators.Convert<string>(value.Value);

		return a_;
	}

    [CqlDeclaration("ToString")]
	public string ToString(Code<ObservationDefinition.ObservationDataType> value)
	{
		var a_ = context?.Operators.Convert<string>(value.Value);

		return a_;
	}

    [CqlDeclaration("ToString")]
	public string ToString(Code<ObservationDefinition.ObservationRangeCategory> value)
	{
		var a_ = context?.Operators.Convert<string>(value.Value);

		return a_;
	}

    [CqlDeclaration("ToString")]
	public string ToString(Code<OperationDefinition.OperationKind> value)
	{
		var a_ = context?.Operators.Convert<string>(value.Value);

		return a_;
	}

    [CqlDeclaration("ToString")]
	public string ToString(Code<OperationParameterUse> value)
	{
		var a_ = context?.Operators.Convert<string>(value.Value);

		return a_;
	}

    [CqlDeclaration("ToString")]
	public string ToString(Code<MolecularSequence.OrientationType> value)
	{
		var a_ = context?.Operators.Convert<string>(value.Value);

		return a_;
	}

    [CqlDeclaration("ToString")]
	public string ToString(Code<Appointment.ParticipantRequired> value)
	{
		var a_ = context?.Operators.Convert<string>(value.Value);

		return a_;
	}

    [CqlDeclaration("ToString")]
	public string ToString(Code<ParticipationStatus> value)
	{
		var a_ = context?.Operators.Convert<string>(value.Value);

		return a_;
	}

    [CqlDeclaration("ToString")]
	public string ToString(Code<ElementDefinition.PropertyRepresentation> value)
	{
		var a_ = context?.Operators.Convert<string>(value.Value);

		return a_;
	}

    [CqlDeclaration("ToString")]
	public string ToString(Code<CodeSystem.PropertyType> value)
	{
		var a_ = context?.Operators.Convert<string>(value.Value);

		return a_;
	}

    [CqlDeclaration("ToString")]
	public string ToString(Code<Provenance.ProvenanceEntityRole> value)
	{
		var a_ = context?.Operators.Convert<string>(value.Value);

		return a_;
	}

    [CqlDeclaration("ToString")]
	public string ToString(Code<PublicationStatus> value)
	{
		var a_ = context?.Operators.Convert<string>(value.Value);

		return a_;
	}

    [CqlDeclaration("ToString")]
	public string ToString(Code<MolecularSequence.QualityType> value)
	{
		var a_ = context?.Operators.Convert<string>(value.Value);

		return a_;
	}

    [CqlDeclaration("ToString")]
	public string ToString(Code<Quantity.QuantityComparator> value)
	{
		var a_ = context?.Operators.Convert<string>(value.Value);

		return a_;
	}

    [CqlDeclaration("ToString")]
	public string ToString(Code<Questionnaire.QuestionnaireItemOperator> value)
	{
		var a_ = context?.Operators.Convert<string>(value.Value);

		return a_;
	}

    [CqlDeclaration("ToString")]
	public string ToString(Code<Questionnaire.QuestionnaireItemType> value)
	{
		var a_ = context?.Operators.Convert<string>(value.Value);

		return a_;
	}

    [CqlDeclaration("ToString")]
	public string ToString(Code<QuestionnaireResponse.QuestionnaireResponseStatus> value)
	{
		var a_ = context?.Operators.Convert<string>(value.Value);

		return a_;
	}

    [CqlDeclaration("ToString")]
	public string ToString(Code<CapabilityStatement.ReferenceHandlingPolicy> value)
	{
		var a_ = context?.Operators.Convert<string>(value.Value);

		return a_;
	}

    [CqlDeclaration("ToString")]
	public string ToString(Code<ElementDefinition.ReferenceVersionRules> value)
	{
		var a_ = context?.Operators.Convert<string>(value.Value);

		return a_;
	}

    [CqlDeclaration("ToString")]
	public string ToString(Code<RelatedArtifact.RelatedArtifactType> value)
	{
		var a_ = context?.Operators.Convert<string>(value.Value);

		return a_;
	}

    [CqlDeclaration("ToString")]
	public string ToString(Code<ClaimProcessingCodes> value)
	{
		var a_ = context?.Operators.Convert<string>(value.Value);

		return a_;
	}

    [CqlDeclaration("ToString")]
	public string ToString(Code<MolecularSequence.RepositoryType> value)
	{
		var a_ = context?.Operators.Convert<string>(value.Value);

		return a_;
	}

    [CqlDeclaration("ToString")]
	public string ToString(Code<ResearchElementDefinition.ResearchElementType> value)
	{
		var a_ = context?.Operators.Convert<string>(value.Value);

		return a_;
	}

    [CqlDeclaration("ToString")]
	public string ToString(Code<ResearchStudy.ResearchStudyStatus> value)
	{
		var a_ = context?.Operators.Convert<string>(value.Value);

		return a_;
	}

    [CqlDeclaration("ToString")]
	public string ToString(Code<ResearchSubject.ResearchSubjectStatus> value)
	{
		var a_ = context?.Operators.Convert<string>(value.Value);

		return a_;
	}

    [CqlDeclaration("ToString")]
	public string ToString(Code<CapabilityStatement.ResourceVersionPolicy> value)
	{
		var a_ = context?.Operators.Convert<string>(value.Value);

		return a_;
	}

    [CqlDeclaration("ToString")]
	public string ToString(Code<MessageHeader.ResponseType> value)
	{
		var a_ = context?.Operators.Convert<string>(value.Value);

		return a_;
	}

    [CqlDeclaration("ToString")]
	public string ToString(Code<CapabilityStatement.RestfulCapabilityMode> value)
	{
		var a_ = context?.Operators.Convert<string>(value.Value);

		return a_;
	}

    [CqlDeclaration("ToString")]
	public string ToString(Code<ImplementationGuide.SPDXLicense> value)
	{
		var a_ = context?.Operators.Convert<string>(value.Value);

		return a_;
	}

    [CqlDeclaration("ToString")]
	public string ToString(Code<SearchParameter.SearchComparator> value)
	{
		var a_ = context?.Operators.Convert<string>(value.Value);

		return a_;
	}

    [CqlDeclaration("ToString")]
	public string ToString(Code<Bundle.SearchEntryMode> value)
	{
		var a_ = context?.Operators.Convert<string>(value.Value);

		return a_;
	}

    [CqlDeclaration("ToString")]
	public string ToString(Code<SearchParameter.SearchModifierCode> value)
	{
		var a_ = context?.Operators.Convert<string>(value.Value);

		return a_;
	}

    [CqlDeclaration("ToString")]
	public string ToString(Code<SearchParamType> value)
	{
		var a_ = context?.Operators.Convert<string>(value.Value);

		return a_;
	}

    [CqlDeclaration("ToString")]
	public string ToString(Code<MolecularSequence.SequenceType> value)
	{
		var a_ = context?.Operators.Convert<string>(value.Value);

		return a_;
	}

    [CqlDeclaration("ToString")]
	public string ToString(Code<ElementDefinition.SlicingRules> value)
	{
		var a_ = context?.Operators.Convert<string>(value.Value);

		return a_;
	}

    [CqlDeclaration("ToString")]
	public string ToString(Code<Slot.SlotStatus> value)
	{
		var a_ = context?.Operators.Convert<string>(value.Value);

		return a_;
	}

    [CqlDeclaration("ToString")]
	public string ToString(Code<DataRequirement.SortDirection> value)
	{
		var a_ = context?.Operators.Convert<string>(value.Value);

		return a_;
	}

    [CqlDeclaration("ToString")]
	public string ToString(Code<SpecimenDefinition.SpecimenContainedPreference> value)
	{
		var a_ = context?.Operators.Convert<string>(value.Value);

		return a_;
	}

    [CqlDeclaration("ToString")]
	public string ToString(Code<Specimen.SpecimenStatus> value)
	{
		var a_ = context?.Operators.Convert<string>(value.Value);

		return a_;
	}

    [CqlDeclaration("ToString")]
	public string ToString(Code<VerificationResult.StatusCode> value)
	{
		var a_ = context?.Operators.Convert<string>(value.Value);

		return a_;
	}

    [CqlDeclaration("ToString")]
	public string ToString(Code<MolecularSequence.StrandType> value)
	{
		var a_ = context?.Operators.Convert<string>(value.Value);

		return a_;
	}

    [CqlDeclaration("ToString")]
	public string ToString(Code<StructureDefinition.StructureDefinitionKind> value)
	{
		var a_ = context?.Operators.Convert<string>(value.Value);

		return a_;
	}

    [CqlDeclaration("ToString")]
	public string ToString(Code<StructureMap.StructureMapContextType> value)
	{
		var a_ = context?.Operators.Convert<string>(value.Value);

		return a_;
	}

    [CqlDeclaration("ToString")]
	public string ToString(Code<StructureMap.StructureMapGroupTypeMode> value)
	{
		var a_ = context?.Operators.Convert<string>(value.Value);

		return a_;
	}

    [CqlDeclaration("ToString")]
	public string ToString(Code<StructureMap.StructureMapInputMode> value)
	{
		var a_ = context?.Operators.Convert<string>(value.Value);

		return a_;
	}

    [CqlDeclaration("ToString")]
	public string ToString(Code<StructureMap.StructureMapModelMode> value)
	{
		var a_ = context?.Operators.Convert<string>(value.Value);

		return a_;
	}

    [CqlDeclaration("ToString")]
	public string ToString(Code<StructureMap.StructureMapSourceListMode> value)
	{
		var a_ = context?.Operators.Convert<string>(value.Value);

		return a_;
	}

    [CqlDeclaration("ToString")]
	public string ToString(Code<StructureMap.StructureMapTargetListMode> value)
	{
		var a_ = context?.Operators.Convert<string>(value.Value);

		return a_;
	}

    [CqlDeclaration("ToString")]
	public string ToString(Code<StructureMap.StructureMapTransform> value)
	{
		var a_ = context?.Operators.Convert<string>(value.Value);

		return a_;
	}

    [CqlDeclaration("ToString")]
	public string ToString(Code<Subscription.SubscriptionChannelType> value)
	{
		var a_ = context?.Operators.Convert<string>(value.Value);

		return a_;
	}

    [CqlDeclaration("ToString")]
	public string ToString(Code<Subscription.SubscriptionStatus> value)
	{
		var a_ = context?.Operators.Convert<string>(value.Value);

		return a_;
	}

    [CqlDeclaration("ToString")]
	public string ToString(Code<SupplyDelivery.SupplyDeliveryStatus> value)
	{
		var a_ = context?.Operators.Convert<string>(value.Value);

		return a_;
	}

    [CqlDeclaration("ToString")]
	public string ToString(Code<SupplyRequest.SupplyRequestStatus> value)
	{
		var a_ = context?.Operators.Convert<string>(value.Value);

		return a_;
	}

    [CqlDeclaration("ToString")]
	public string ToString(Code<CapabilityStatement.SystemRestfulInteraction> value)
	{
		var a_ = context?.Operators.Convert<string>(value.Value);

		return a_;
	}

    [CqlDeclaration("ToString")]
	public string ToString(Code<Task.TaskIntent> value)
	{
		var a_ = context?.Operators.Convert<string>(value.Value);

		return a_;
	}

    [CqlDeclaration("ToString")]
	public string ToString(Code<Task.TaskStatus> value)
	{
		var a_ = context?.Operators.Convert<string>(value.Value);

		return a_;
	}

    [CqlDeclaration("ToString")]
	public string ToString(Code<TestReport.TestReportActionResult> value)
	{
		var a_ = context?.Operators.Convert<string>(value.Value);

		return a_;
	}

    [CqlDeclaration("ToString")]
	public string ToString(Code<TestReport.TestReportParticipantType> value)
	{
		var a_ = context?.Operators.Convert<string>(value.Value);

		return a_;
	}

    [CqlDeclaration("ToString")]
	public string ToString(Code<TestReport.TestReportResult> value)
	{
		var a_ = context?.Operators.Convert<string>(value.Value);

		return a_;
	}

    [CqlDeclaration("ToString")]
	public string ToString(Code<TestReport.TestReportStatus> value)
	{
		var a_ = context?.Operators.Convert<string>(value.Value);

		return a_;
	}

    [CqlDeclaration("ToString")]
	public string ToString(Code<TestScript.TestScriptRequestMethodCode> value)
	{
		var a_ = context?.Operators.Convert<string>(value.Value);

		return a_;
	}

    [CqlDeclaration("ToString")]
	public string ToString(Code<TriggerDefinition.TriggerType> value)
	{
		var a_ = context?.Operators.Convert<string>(value.Value);

		return a_;
	}

    [CqlDeclaration("ToString")]
	public string ToString(Code<StructureDefinition.TypeDerivationRule> value)
	{
		var a_ = context?.Operators.Convert<string>(value.Value);

		return a_;
	}

    [CqlDeclaration("ToString")]
	public string ToString(Code<CapabilityStatement.TypeRestfulInteraction> value)
	{
		var a_ = context?.Operators.Convert<string>(value.Value);

		return a_;
	}

    [CqlDeclaration("ToString")]
	public string ToString(Code<Device.UDIEntryType> value)
	{
		var a_ = context?.Operators.Convert<string>(value.Value);

		return a_;
	}

    [CqlDeclaration("ToString")]
	public string ToString(Code<Timing.UnitsOfTime> value)
	{
		var a_ = context?.Operators.Convert<string>(value.Value);

		return a_;
	}

    [CqlDeclaration("ToString")]
	public string ToString(Code<ClaimUseCode> value)
	{
		var a_ = context?.Operators.Convert<string>(value.Value);

		return a_;
	}

    [CqlDeclaration("ToString")]
	public string ToString(Code<VisionPrescription.VisionBase> value)
	{
		var a_ = context?.Operators.Convert<string>(value.Value);

		return a_;
	}

    [CqlDeclaration("ToString")]
	public string ToString(Code<VisionPrescription.VisionEyes> value)
	{
		var a_ = context?.Operators.Convert<string>(value.Value);

		return a_;
	}

    [CqlDeclaration("ToString")]
	public string ToString(Code<SearchParameter.XPathUsageType> value)
	{
		var a_ = context?.Operators.Convert<string>(value.Value);

		return a_;
	}

    [CqlDeclaration("ToString")]
	public string ToString(Base64Binary value)
	{
		var a_ = context?.Operators.Convert<string>(value.Value);

		return a_;
	}

    [CqlDeclaration("ToString")]
	public string ToString(Id value) => 
		value.Value;

    [CqlDeclaration("ToString")]
	public string ToString(FhirString value) => 
		value.Value;

    [CqlDeclaration("ToString")]
	public string ToString(FhirUri value) => 
		value.Value;

    [CqlDeclaration("ToString")]
	public string ToString(XHtml value) => 
		value.Value;

    [CqlDeclaration("ToBoolean")]
	public bool? ToBoolean(FhirBoolean value) => 
		value.Value;

    [CqlDeclaration("ToDate")]
	public CqlDate ToDate(Date value)
	{
		var a_ = context?.Operators.ConvertStringToDate(value.Value);

		return a_;
	}

    [CqlDeclaration("ToDateTime")]
	public CqlDateTime ToDateTime(FhirDateTime value)
	{
		var a_ = context?.Operators.Convert<CqlDateTime>(value);

		return a_;
	}

    [CqlDeclaration("ToDateTime")]
	public CqlDateTime ToDateTime(Instant value)
	{
		var a_ = context?.Operators.Convert<CqlDateTime>(value.Value);

		return a_;
	}

    [CqlDeclaration("ToDecimal")]
	public decimal? ToDecimal(FhirDecimal value) => 
		value.Value;

    [CqlDeclaration("ToInteger")]
	public int? ToInteger(Integer value) => 
		value.Value;

    [CqlDeclaration("ToTime")]
	public CqlTime ToTime(Time value)
	{
		var a_ = context?.Operators.ConvertStringToTime(value.Value);

		return a_;
	}

}

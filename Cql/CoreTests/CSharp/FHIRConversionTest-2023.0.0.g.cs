using System;
using System.Linq;
using System.Collections.Generic;
using Hl7.Cql.Runtime;
using Hl7.Cql.Primitives;
using Hl7.Cql.Abstractions;
using Hl7.Cql.ValueSets;
using Hl7.Cql.Iso8601;
using System.Reflection;
using Hl7.Cql.Operators;
using Hl7.Fhir.Model;
using Range = Hl7.Fhir.Model.Range;
using Task = Hl7.Fhir.Model.Task;
[System.CodeDom.Compiler.GeneratedCode(".NET Code Generation", "2.0.4.0")]
[CqlLibrary("FHIRConversionTest", "2023.0.0")]
public class FHIRConversionTest_2023_0_0
{


    internal CqlContext context;

    #region Cached values


    #endregion
    public FHIRConversionTest_2023_0_0(CqlContext context)
    {
        this.context = context ?? throw new ArgumentNullException("context");

        FHIRHelpers_4_0_1 = new FHIRHelpers_4_0_1(context);

    }
    #region Dependencies

    public FHIRHelpers_4_0_1 FHIRHelpers_4_0_1 { get; }

    #endregion

    [CqlDeclaration("AccountResource")]
	public Account AccountResource(Account arg)
	{
		Account[] a_ = [
			arg,
		];
		Account b_(Account a)
		{
			List<Identifier> e_ = a?.Identifier;
			Code<Account.AccountStatus> f_ = a?.StatusElement;
			CodeableConcept g_ = a?.Type;
			FhirString h_ = a?.NameElement;
			List<ResourceReference> i_ = a?.Subject;
			Period j_ = a?.ServicePeriod;
			List<Account.CoverageComponent> k_ = a?.Coverage;
			ResourceReference l_ = a?.Owner;
			FhirString m_ = a?.DescriptionElement;
			List<Account.GuarantorComponent> n_ = a?.Guarantor;
			ResourceReference o_ = a?.PartOf;
			Account p_ = new Account
			{
				Identifier = new List<Identifier>((IEnumerable<Identifier>)e_),
				StatusElement = f_,
				Type = g_,
				NameElement = h_,
				Subject = new List<ResourceReference>((IEnumerable<ResourceReference>)i_),
				ServicePeriod = j_,
				Coverage = new List<Account.CoverageComponent>((IEnumerable<Account.CoverageComponent>)k_),
				Owner = l_,
				DescriptionElement = m_,
				Guarantor = new List<Account.GuarantorComponent>((IEnumerable<Account.GuarantorComponent>)n_),
				PartOf = o_,
			};

			return p_;
		};
		IEnumerable<Account> c_ = context.Operators.Select<Account, Account>((IEnumerable<Account>)a_, b_);
		Account d_ = context.Operators.SingletonFrom<Account>(c_);

		return d_;
	}

    [CqlDeclaration("ActivityDefinitionResource")]
	public ActivityDefinition ActivityDefinitionResource(ActivityDefinition arg)
	{
		ActivityDefinition[] a_ = [
			arg,
		];
		ActivityDefinition b_(ActivityDefinition a)
		{
			FhirUri e_ = a?.UrlElement;
			List<Identifier> f_ = a?.Identifier;
			FhirString g_ = a?.VersionElement;
			FhirString h_ = a?.NameElement;
			FhirString i_ = a?.TitleElement;
			FhirString j_ = a?.SubtitleElement;
			Code<PublicationStatus> k_ = a?.StatusElement;
			FhirBoolean l_ = a?.ExperimentalElement;
			DataType m_ = a?.Subject;
			FhirDateTime n_ = a?.DateElement;
			FhirString o_ = a?.PublisherElement;
			List<ContactDetail> p_ = a?.Contact;
			Markdown q_ = a?.DescriptionElement;
			List<UsageContext> r_ = a?.UseContext;
			List<CodeableConcept> s_ = a?.Jurisdiction;
			Markdown t_ = a?.PurposeElement;
			FhirString u_ = a?.UsageElement;
			Markdown v_ = a?.CopyrightElement;
			Date w_ = a?.ApprovalDateElement;
			Date x_ = a?.LastReviewDateElement;
			Period y_ = a?.EffectivePeriod;
			List<CodeableConcept> z_ = a?.Topic;
			List<ContactDetail> aa_ = a?.Author;
			List<ContactDetail> ab_ = a?.Editor;
			List<ContactDetail> ac_ = a?.Reviewer;
			List<ContactDetail> ad_ = a?.Endorser;
			List<RelatedArtifact> ae_ = a?.RelatedArtifact;
			List<Canonical> af_ = a?.LibraryElement;
			Code<ActivityDefinition.RequestResourceType> ag_ = a?.KindElement;
			Canonical ah_ = a?.ProfileElement;
			CodeableConcept ai_ = a?.Code;
			Code<RequestIntent> aj_ = a?.IntentElement;
			Code<RequestPriority> ak_ = a?.PriorityElement;
			FhirBoolean al_ = a?.DoNotPerformElement;
			DataType am_ = a?.Timing;
			ResourceReference an_ = a?.Location;
			List<ActivityDefinition.ParticipantComponent> ao_ = a?.Participant;
			DataType ap_ = a?.Product;
			Quantity aq_ = a?.Quantity;
			List<Dosage> ar_ = a?.Dosage;
			List<CodeableConcept> as_ = a?.BodySite;
			List<ResourceReference> at_ = a?.SpecimenRequirement;
			List<ResourceReference> au_ = a?.ObservationRequirement;
			List<ResourceReference> av_ = a?.ObservationResultRequirement;
			Canonical aw_ = a?.TransformElement;
			List<ActivityDefinition.DynamicValueComponent> ax_ = a?.DynamicValue;
			ActivityDefinition ay_ = new ActivityDefinition
			{
				UrlElement = e_,
				Identifier = new List<Identifier>((IEnumerable<Identifier>)f_),
				VersionElement = g_,
				NameElement = h_,
				TitleElement = i_,
				SubtitleElement = j_,
				StatusElement = k_,
				ExperimentalElement = l_,
				Subject = (DataType)m_,
				DateElement = n_,
				PublisherElement = o_,
				Contact = new List<ContactDetail>((IEnumerable<ContactDetail>)p_),
				DescriptionElement = q_,
				UseContext = new List<UsageContext>((IEnumerable<UsageContext>)r_),
				Jurisdiction = new List<CodeableConcept>((IEnumerable<CodeableConcept>)s_),
				PurposeElement = t_,
				UsageElement = u_,
				CopyrightElement = v_,
				ApprovalDateElement = w_,
				LastReviewDateElement = x_,
				EffectivePeriod = y_,
				Topic = new List<CodeableConcept>((IEnumerable<CodeableConcept>)z_),
				Author = new List<ContactDetail>((IEnumerable<ContactDetail>)aa_),
				Editor = new List<ContactDetail>((IEnumerable<ContactDetail>)ab_),
				Reviewer = new List<ContactDetail>((IEnumerable<ContactDetail>)ac_),
				Endorser = new List<ContactDetail>((IEnumerable<ContactDetail>)ad_),
				RelatedArtifact = new List<RelatedArtifact>((IEnumerable<RelatedArtifact>)ae_),
				LibraryElement = new List<Canonical>((IEnumerable<Canonical>)af_),
				KindElement = ag_,
				ProfileElement = ah_,
				Code = ai_,
				IntentElement = aj_,
				PriorityElement = ak_,
				DoNotPerformElement = al_,
				Timing = (DataType)am_,
				Location = an_,
				Participant = new List<ActivityDefinition.ParticipantComponent>((IEnumerable<ActivityDefinition.ParticipantComponent>)ao_),
				Product = (DataType)ap_,
				Quantity = aq_,
				Dosage = new List<Dosage>((IEnumerable<Dosage>)ar_),
				BodySite = new List<CodeableConcept>((IEnumerable<CodeableConcept>)as_),
				SpecimenRequirement = new List<ResourceReference>((IEnumerable<ResourceReference>)at_),
				ObservationRequirement = new List<ResourceReference>((IEnumerable<ResourceReference>)au_),
				ObservationResultRequirement = new List<ResourceReference>((IEnumerable<ResourceReference>)av_),
				TransformElement = aw_,
				DynamicValue = new List<ActivityDefinition.DynamicValueComponent>((IEnumerable<ActivityDefinition.DynamicValueComponent>)ax_),
			};

			return ay_;
		};
		IEnumerable<ActivityDefinition> c_ = context.Operators.Select<ActivityDefinition, ActivityDefinition>((IEnumerable<ActivityDefinition>)a_, b_);
		ActivityDefinition d_ = context.Operators.SingletonFrom<ActivityDefinition>(c_);

		return d_;
	}

    [CqlDeclaration("AdverseEventResource")]
	public AdverseEvent AdverseEventResource(AdverseEvent arg)
	{
		AdverseEvent[] a_ = [
			arg,
		];
		AdverseEvent b_(AdverseEvent a)
		{
			Identifier e_ = a?.Identifier;
			Code<AdverseEvent.AdverseEventActuality> f_ = a?.ActualityElement;
			List<CodeableConcept> g_ = a?.Category;
			CodeableConcept h_ = a?.Event;
			ResourceReference i_ = a?.Subject;
			ResourceReference j_ = a?.Encounter;
			FhirDateTime k_ = a?.DateElement;
			FhirDateTime l_ = a?.DetectedElement;
			FhirDateTime m_ = a?.RecordedDateElement;
			List<ResourceReference> n_ = a?.ResultingCondition;
			ResourceReference o_ = a?.Location;
			CodeableConcept p_ = a?.Seriousness;
			CodeableConcept q_ = a?.Severity;
			CodeableConcept r_ = a?.Outcome;
			ResourceReference s_ = a?.Recorder;
			List<ResourceReference> t_ = a?.Contributor;
			List<AdverseEvent.SuspectEntityComponent> u_ = a?.SuspectEntity;
			List<ResourceReference> v_ = a?.SubjectMedicalHistory;
			List<ResourceReference> w_ = a?.ReferenceDocument;
			List<ResourceReference> x_ = a?.Study;
			AdverseEvent y_ = new AdverseEvent
			{
				Identifier = e_,
				ActualityElement = f_,
				Category = new List<CodeableConcept>((IEnumerable<CodeableConcept>)g_),
				Event = h_,
				Subject = i_,
				Encounter = j_,
				DateElement = k_,
				DetectedElement = l_,
				RecordedDateElement = m_,
				ResultingCondition = new List<ResourceReference>((IEnumerable<ResourceReference>)n_),
				Location = o_,
				Seriousness = p_,
				Severity = q_,
				Outcome = r_,
				Recorder = s_,
				Contributor = new List<ResourceReference>((IEnumerable<ResourceReference>)t_),
				SuspectEntity = new List<AdverseEvent.SuspectEntityComponent>((IEnumerable<AdverseEvent.SuspectEntityComponent>)u_),
				SubjectMedicalHistory = new List<ResourceReference>((IEnumerable<ResourceReference>)v_),
				ReferenceDocument = new List<ResourceReference>((IEnumerable<ResourceReference>)w_),
				Study = new List<ResourceReference>((IEnumerable<ResourceReference>)x_),
			};

			return y_;
		};
		IEnumerable<AdverseEvent> c_ = context.Operators.Select<AdverseEvent, AdverseEvent>((IEnumerable<AdverseEvent>)a_, b_);
		AdverseEvent d_ = context.Operators.SingletonFrom<AdverseEvent>(c_);

		return d_;
	}

    [CqlDeclaration("AllergyIntoleranceResource")]
	public AllergyIntolerance AllergyIntoleranceResource(AllergyIntolerance arg)
	{
		AllergyIntolerance[] a_ = [
			arg,
		];
		AllergyIntolerance b_(AllergyIntolerance a)
		{
			List<Identifier> e_ = a?.Identifier;
			CodeableConcept f_ = a?.ClinicalStatus;
			CodeableConcept g_ = a?.VerificationStatus;
			Code<AllergyIntolerance.AllergyIntoleranceType> h_ = a?.TypeElement;
			List<Code<AllergyIntolerance.AllergyIntoleranceCategory>> i_ = a?.CategoryElement;
			Code<AllergyIntolerance.AllergyIntoleranceCriticality> j_ = a?.CriticalityElement;
			CodeableConcept k_ = a?.Code;
			ResourceReference l_ = a?.Patient;
			ResourceReference m_ = a?.Encounter;
			DataType n_ = a?.Onset;
			FhirDateTime o_ = a?.RecordedDateElement;
			ResourceReference p_ = a?.Recorder;
			ResourceReference q_ = a?.Asserter;
			FhirDateTime r_ = a?.LastOccurrenceElement;
			List<Annotation> s_ = a?.Note;
			List<AllergyIntolerance.ReactionComponent> t_ = a?.Reaction;
			AllergyIntolerance u_ = new AllergyIntolerance
			{
				Identifier = new List<Identifier>((IEnumerable<Identifier>)e_),
				ClinicalStatus = f_,
				VerificationStatus = g_,
				TypeElement = h_,
				CategoryElement = new List<Code<AllergyIntolerance.AllergyIntoleranceCategory>>((IEnumerable<Code<AllergyIntolerance.AllergyIntoleranceCategory>>)i_),
				CriticalityElement = j_,
				Code = k_,
				Patient = l_,
				Encounter = m_,
				Onset = (DataType)n_,
				RecordedDateElement = o_,
				Recorder = p_,
				Asserter = q_,
				LastOccurrenceElement = r_,
				Note = new List<Annotation>((IEnumerable<Annotation>)s_),
				Reaction = new List<AllergyIntolerance.ReactionComponent>((IEnumerable<AllergyIntolerance.ReactionComponent>)t_),
			};

			return u_;
		};
		IEnumerable<AllergyIntolerance> c_ = context.Operators.Select<AllergyIntolerance, AllergyIntolerance>((IEnumerable<AllergyIntolerance>)a_, b_);
		AllergyIntolerance d_ = context.Operators.SingletonFrom<AllergyIntolerance>(c_);

		return d_;
	}

    [CqlDeclaration("AppointmentResource")]
	public Appointment AppointmentResource(Appointment arg)
	{
		Appointment[] a_ = [
			arg,
		];
		Appointment b_(Appointment a)
		{
			List<Identifier> e_ = a?.Identifier;
			Code<Appointment.AppointmentStatus> f_ = a?.StatusElement;
			CodeableConcept g_ = a?.CancelationReason;
			List<CodeableConcept> h_ = a?.ServiceCategory;
			List<CodeableConcept> i_ = a?.ServiceType;
			List<CodeableConcept> j_ = a?.Specialty;
			CodeableConcept k_ = a?.AppointmentType;
			List<CodeableConcept> l_ = a?.ReasonCode;
			List<ResourceReference> m_ = a?.ReasonReference;
			UnsignedInt n_ = a?.PriorityElement;
			Integer o_ = context.Operators.Convert<Integer>(n_);
			UnsignedInt p_ = context.Operators.Convert<UnsignedInt>(o_);
			FhirString q_ = a?.DescriptionElement;
			List<ResourceReference> r_ = a?.SupportingInformation;
			Instant s_ = a?.StartElement;
			Instant t_ = a?.EndElement;
			PositiveInt u_ = a?.MinutesDurationElement;
			Integer v_ = context.Operators.Convert<Integer>(u_);
			PositiveInt w_ = context.Operators.Convert<PositiveInt>(v_);
			List<ResourceReference> x_ = a?.Slot;
			FhirDateTime y_ = a?.CreatedElement;
			FhirString z_ = a?.CommentElement;
			FhirString aa_ = a?.PatientInstructionElement;
			List<ResourceReference> ab_ = a?.BasedOn;
			List<Appointment.ParticipantComponent> ac_ = a?.Participant;
			List<Period> ad_ = a?.RequestedPeriod;
			Appointment ae_ = new Appointment
			{
				Identifier = new List<Identifier>((IEnumerable<Identifier>)e_),
				StatusElement = f_,
				CancelationReason = g_,
				ServiceCategory = new List<CodeableConcept>((IEnumerable<CodeableConcept>)h_),
				ServiceType = new List<CodeableConcept>((IEnumerable<CodeableConcept>)i_),
				Specialty = new List<CodeableConcept>((IEnumerable<CodeableConcept>)j_),
				AppointmentType = k_,
				ReasonCode = new List<CodeableConcept>((IEnumerable<CodeableConcept>)l_),
				ReasonReference = new List<ResourceReference>((IEnumerable<ResourceReference>)m_),
				PriorityElement = p_,
				DescriptionElement = q_,
				SupportingInformation = new List<ResourceReference>((IEnumerable<ResourceReference>)r_),
				StartElement = s_,
				EndElement = t_,
				MinutesDurationElement = w_,
				Slot = new List<ResourceReference>((IEnumerable<ResourceReference>)x_),
				CreatedElement = y_,
				CommentElement = z_,
				PatientInstructionElement = aa_,
				BasedOn = new List<ResourceReference>((IEnumerable<ResourceReference>)ab_),
				Participant = new List<Appointment.ParticipantComponent>((IEnumerable<Appointment.ParticipantComponent>)ac_),
				RequestedPeriod = new List<Period>((IEnumerable<Period>)ad_),
			};

			return ae_;
		};
		IEnumerable<Appointment> c_ = context.Operators.Select<Appointment, Appointment>((IEnumerable<Appointment>)a_, b_);
		Appointment d_ = context.Operators.SingletonFrom<Appointment>(c_);

		return d_;
	}

    [CqlDeclaration("AppointmentResponseResource")]
	public AppointmentResponse AppointmentResponseResource(AppointmentResponse arg)
	{
		AppointmentResponse[] a_ = [
			arg,
		];
		AppointmentResponse b_(AppointmentResponse a)
		{
			List<Identifier> e_ = a?.Identifier;
			ResourceReference f_ = a?.Appointment;
			Instant g_ = a?.StartElement;
			Instant h_ = a?.EndElement;
			List<CodeableConcept> i_ = a?.ParticipantType;
			ResourceReference j_ = a?.Actor;
			Code<ParticipationStatus> k_ = a?.ParticipantStatusElement;
			FhirString l_ = a?.CommentElement;
			AppointmentResponse m_ = new AppointmentResponse
			{
				Identifier = new List<Identifier>((IEnumerable<Identifier>)e_),
				Appointment = f_,
				StartElement = g_,
				EndElement = h_,
				ParticipantType = new List<CodeableConcept>((IEnumerable<CodeableConcept>)i_),
				Actor = j_,
				ParticipantStatusElement = k_,
				CommentElement = l_,
			};

			return m_;
		};
		IEnumerable<AppointmentResponse> c_ = context.Operators.Select<AppointmentResponse, AppointmentResponse>((IEnumerable<AppointmentResponse>)a_, b_);
		AppointmentResponse d_ = context.Operators.SingletonFrom<AppointmentResponse>(c_);

		return d_;
	}

    [CqlDeclaration("AuditEventResource")]
	public AuditEvent AuditEventResource(AuditEvent arg)
	{
		AuditEvent[] a_ = [
			arg,
		];
		AuditEvent b_(AuditEvent a)
		{
			Coding e_ = a?.Type;
			List<Coding> f_ = a?.Subtype;
			Code<AuditEvent.AuditEventAction> g_ = a?.ActionElement;
			Period h_ = a?.Period;
			Instant i_ = a?.RecordedElement;
			Code<AuditEvent.AuditEventOutcome> j_ = a?.OutcomeElement;
			FhirString k_ = a?.OutcomeDescElement;
			List<CodeableConcept> l_ = a?.PurposeOfEvent;
			List<AuditEvent.AgentComponent> m_ = a?.Agent;
			AuditEvent.SourceComponent n_ = a?.Source;
			List<AuditEvent.EntityComponent> o_ = a?.Entity;
			AuditEvent p_ = new AuditEvent
			{
				Type = e_,
				Subtype = new List<Coding>((IEnumerable<Coding>)f_),
				ActionElement = g_,
				Period = h_,
				RecordedElement = i_,
				OutcomeElement = j_,
				OutcomeDescElement = k_,
				PurposeOfEvent = new List<CodeableConcept>((IEnumerable<CodeableConcept>)l_),
				Agent = new List<AuditEvent.AgentComponent>((IEnumerable<AuditEvent.AgentComponent>)m_),
				Source = n_,
				Entity = new List<AuditEvent.EntityComponent>((IEnumerable<AuditEvent.EntityComponent>)o_),
			};

			return p_;
		};
		IEnumerable<AuditEvent> c_ = context.Operators.Select<AuditEvent, AuditEvent>((IEnumerable<AuditEvent>)a_, b_);
		AuditEvent d_ = context.Operators.SingletonFrom<AuditEvent>(c_);

		return d_;
	}

    [CqlDeclaration("BasicResource")]
	public Basic BasicResource(Basic arg)
	{
		Basic[] a_ = [
			arg,
		];
		Basic b_(Basic a)
		{
			List<Identifier> e_ = a?.Identifier;
			CodeableConcept f_ = a?.Code;
			ResourceReference g_ = a?.Subject;
			Date h_ = a?.CreatedElement;
			ResourceReference i_ = a?.Author;
			Basic j_ = new Basic
			{
				Identifier = new List<Identifier>((IEnumerable<Identifier>)e_),
				Code = f_,
				Subject = g_,
				CreatedElement = h_,
				Author = i_,
			};

			return j_;
		};
		IEnumerable<Basic> c_ = context.Operators.Select<Basic, Basic>((IEnumerable<Basic>)a_, b_);
		Basic d_ = context.Operators.SingletonFrom<Basic>(c_);

		return d_;
	}

    [CqlDeclaration("BiologicallyDerivedProductResource")]
	public BiologicallyDerivedProduct BiologicallyDerivedProductResource(BiologicallyDerivedProduct arg)
	{
		BiologicallyDerivedProduct[] a_ = [
			arg,
		];
		BiologicallyDerivedProduct b_(BiologicallyDerivedProduct a)
		{
			List<Identifier> e_ = a?.Identifier;
			Code<BiologicallyDerivedProduct.BiologicallyDerivedProductCategory> f_ = a?.ProductCategoryElement;
			CodeableConcept g_ = a?.ProductCode;
			Code<BiologicallyDerivedProduct.BiologicallyDerivedProductStatus> h_ = a?.StatusElement;
			List<ResourceReference> i_ = a?.Request;
			Integer j_ = a?.QuantityElement;
			List<ResourceReference> k_ = a?.Parent;
			BiologicallyDerivedProduct.CollectionComponent l_ = a?.Collection;
			List<BiologicallyDerivedProduct.ProcessingComponent> m_ = a?.Processing;
			BiologicallyDerivedProduct.ManipulationComponent n_ = a?.Manipulation;
			List<BiologicallyDerivedProduct.StorageComponent> o_ = a?.Storage;
			BiologicallyDerivedProduct p_ = new BiologicallyDerivedProduct
			{
				Identifier = new List<Identifier>((IEnumerable<Identifier>)e_),
				ProductCategoryElement = f_,
				ProductCode = g_,
				StatusElement = h_,
				Request = new List<ResourceReference>((IEnumerable<ResourceReference>)i_),
				QuantityElement = j_,
				Parent = new List<ResourceReference>((IEnumerable<ResourceReference>)k_),
				Collection = l_,
				Processing = new List<BiologicallyDerivedProduct.ProcessingComponent>((IEnumerable<BiologicallyDerivedProduct.ProcessingComponent>)m_),
				Manipulation = n_,
				Storage = new List<BiologicallyDerivedProduct.StorageComponent>((IEnumerable<BiologicallyDerivedProduct.StorageComponent>)o_),
			};

			return p_;
		};
		IEnumerable<BiologicallyDerivedProduct> c_ = context.Operators.Select<BiologicallyDerivedProduct, BiologicallyDerivedProduct>((IEnumerable<BiologicallyDerivedProduct>)a_, b_);
		BiologicallyDerivedProduct d_ = context.Operators.SingletonFrom<BiologicallyDerivedProduct>(c_);

		return d_;
	}

    [CqlDeclaration("BodyStructureResource")]
	public BodyStructure BodyStructureResource(BodyStructure arg)
	{
		BodyStructure[] a_ = [
			arg,
		];
		BodyStructure b_(BodyStructure a)
		{
			List<Identifier> e_ = a?.Identifier;
			FhirBoolean f_ = a?.ActiveElement;
			CodeableConcept g_ = a?.Morphology;
			CodeableConcept h_ = a?.Location;
			List<CodeableConcept> i_ = a?.LocationQualifier;
			FhirString j_ = a?.DescriptionElement;
			List<Attachment> k_ = a?.Image;
			ResourceReference l_ = a?.Patient;
			BodyStructure m_ = new BodyStructure
			{
				Identifier = new List<Identifier>((IEnumerable<Identifier>)e_),
				ActiveElement = f_,
				Morphology = g_,
				Location = h_,
				LocationQualifier = new List<CodeableConcept>((IEnumerable<CodeableConcept>)i_),
				DescriptionElement = j_,
				Image = new List<Attachment>((IEnumerable<Attachment>)k_),
				Patient = l_,
			};

			return m_;
		};
		IEnumerable<BodyStructure> c_ = context.Operators.Select<BodyStructure, BodyStructure>((IEnumerable<BodyStructure>)a_, b_);
		BodyStructure d_ = context.Operators.SingletonFrom<BodyStructure>(c_);

		return d_;
	}

    [CqlDeclaration("CarePlanResource")]
	public CarePlan CarePlanResource(CarePlan arg)
	{
		CarePlan[] a_ = [
			arg,
		];
		CarePlan b_(CarePlan a)
		{
			List<Identifier> e_ = a?.Identifier;
			List<Canonical> f_ = a?.InstantiatesCanonicalElement;
			List<FhirUri> g_ = a?.InstantiatesUriElement;
			List<ResourceReference> h_ = a?.BasedOn;
			List<ResourceReference> i_ = a?.Replaces;
			List<ResourceReference> j_ = a?.PartOf;
			Code<RequestStatus> k_ = a?.StatusElement;
			Code<CarePlan.CarePlanIntent> l_ = a?.IntentElement;
			List<CodeableConcept> m_ = a?.Category;
			FhirString n_ = a?.TitleElement;
			FhirString o_ = a?.DescriptionElement;
			ResourceReference p_ = a?.Subject;
			ResourceReference q_ = a?.Encounter;
			Period r_ = a?.Period;
			FhirDateTime s_ = a?.CreatedElement;
			ResourceReference t_ = a?.Author;
			List<ResourceReference> u_ = a?.Contributor;
			List<ResourceReference> v_ = a?.CareTeam;
			List<ResourceReference> w_ = a?.Addresses;
			List<ResourceReference> x_ = a?.SupportingInfo;
			List<ResourceReference> y_ = a?.Goal;
			List<CarePlan.ActivityComponent> z_ = a?.Activity;
			List<Annotation> aa_ = a?.Note;
			CarePlan ab_ = new CarePlan
			{
				Identifier = new List<Identifier>((IEnumerable<Identifier>)e_),
				InstantiatesCanonicalElement = new List<Canonical>((IEnumerable<Canonical>)f_),
				InstantiatesUriElement = new List<FhirUri>((IEnumerable<FhirUri>)g_),
				BasedOn = new List<ResourceReference>((IEnumerable<ResourceReference>)h_),
				Replaces = new List<ResourceReference>((IEnumerable<ResourceReference>)i_),
				PartOf = new List<ResourceReference>((IEnumerable<ResourceReference>)j_),
				StatusElement = k_,
				IntentElement = l_,
				Category = new List<CodeableConcept>((IEnumerable<CodeableConcept>)m_),
				TitleElement = n_,
				DescriptionElement = o_,
				Subject = p_,
				Encounter = q_,
				Period = r_,
				CreatedElement = s_,
				Author = t_,
				Contributor = new List<ResourceReference>((IEnumerable<ResourceReference>)u_),
				CareTeam = new List<ResourceReference>((IEnumerable<ResourceReference>)v_),
				Addresses = new List<ResourceReference>((IEnumerable<ResourceReference>)w_),
				SupportingInfo = new List<ResourceReference>((IEnumerable<ResourceReference>)x_),
				Goal = new List<ResourceReference>((IEnumerable<ResourceReference>)y_),
				Activity = new List<CarePlan.ActivityComponent>((IEnumerable<CarePlan.ActivityComponent>)z_),
				Note = new List<Annotation>((IEnumerable<Annotation>)aa_),
			};

			return ab_;
		};
		IEnumerable<CarePlan> c_ = context.Operators.Select<CarePlan, CarePlan>((IEnumerable<CarePlan>)a_, b_);
		CarePlan d_ = context.Operators.SingletonFrom<CarePlan>(c_);

		return d_;
	}

    [CqlDeclaration("CareTeamResource")]
	public CareTeam CareTeamResource(CareTeam arg)
	{
		CareTeam[] a_ = [
			arg,
		];
		CareTeam b_(CareTeam a)
		{
			List<Identifier> e_ = a?.Identifier;
			Code<CareTeam.CareTeamStatus> f_ = a?.StatusElement;
			List<CodeableConcept> g_ = a?.Category;
			FhirString h_ = a?.NameElement;
			ResourceReference i_ = a?.Subject;
			ResourceReference j_ = a?.Encounter;
			Period k_ = a?.Period;
			List<CareTeam.ParticipantComponent> l_ = a?.Participant;
			List<CodeableConcept> m_ = a?.ReasonCode;
			List<ResourceReference> n_ = a?.ReasonReference;
			List<ResourceReference> o_ = a?.ManagingOrganization;
			List<ContactPoint> p_ = a?.Telecom;
			List<Annotation> q_ = a?.Note;
			CareTeam r_ = new CareTeam
			{
				Identifier = new List<Identifier>((IEnumerable<Identifier>)e_),
				StatusElement = f_,
				Category = new List<CodeableConcept>((IEnumerable<CodeableConcept>)g_),
				NameElement = h_,
				Subject = i_,
				Encounter = j_,
				Period = k_,
				Participant = new List<CareTeam.ParticipantComponent>((IEnumerable<CareTeam.ParticipantComponent>)l_),
				ReasonCode = new List<CodeableConcept>((IEnumerable<CodeableConcept>)m_),
				ReasonReference = new List<ResourceReference>((IEnumerable<ResourceReference>)n_),
				ManagingOrganization = new List<ResourceReference>((IEnumerable<ResourceReference>)o_),
				Telecom = new List<ContactPoint>((IEnumerable<ContactPoint>)p_),
				Note = new List<Annotation>((IEnumerable<Annotation>)q_),
			};

			return r_;
		};
		IEnumerable<CareTeam> c_ = context.Operators.Select<CareTeam, CareTeam>((IEnumerable<CareTeam>)a_, b_);
		CareTeam d_ = context.Operators.SingletonFrom<CareTeam>(c_);

		return d_;
	}

    [CqlDeclaration("CatalogEntryResource")]
	public CatalogEntry CatalogEntryResource(CatalogEntry arg)
	{
		CatalogEntry[] a_ = [
			arg,
		];
		CatalogEntry b_(CatalogEntry a)
		{
			List<Identifier> e_ = a?.Identifier;
			CodeableConcept f_ = a?.Type;
			FhirBoolean g_ = a?.OrderableElement;
			ResourceReference h_ = a?.ReferencedItem;
			List<Identifier> i_ = a?.AdditionalIdentifier;
			List<CodeableConcept> j_ = a?.Classification;
			Code<PublicationStatus> k_ = a?.StatusElement;
			Period l_ = a?.ValidityPeriod;
			FhirDateTime m_ = a?.ValidToElement;
			FhirDateTime n_ = a?.LastUpdatedElement;
			List<CodeableConcept> o_ = a?.AdditionalCharacteristic;
			List<CodeableConcept> p_ = a?.AdditionalClassification;
			List<CatalogEntry.RelatedEntryComponent> q_ = a?.RelatedEntry;
			CatalogEntry r_ = new CatalogEntry
			{
				Identifier = new List<Identifier>((IEnumerable<Identifier>)e_),
				Type = f_,
				OrderableElement = g_,
				ReferencedItem = h_,
				AdditionalIdentifier = new List<Identifier>((IEnumerable<Identifier>)i_),
				Classification = new List<CodeableConcept>((IEnumerable<CodeableConcept>)j_),
				StatusElement = k_,
				ValidityPeriod = l_,
				ValidToElement = m_,
				LastUpdatedElement = n_,
				AdditionalCharacteristic = new List<CodeableConcept>((IEnumerable<CodeableConcept>)o_),
				AdditionalClassification = new List<CodeableConcept>((IEnumerable<CodeableConcept>)p_),
				RelatedEntry = new List<CatalogEntry.RelatedEntryComponent>((IEnumerable<CatalogEntry.RelatedEntryComponent>)q_),
			};

			return r_;
		};
		IEnumerable<CatalogEntry> c_ = context.Operators.Select<CatalogEntry, CatalogEntry>((IEnumerable<CatalogEntry>)a_, b_);
		CatalogEntry d_ = context.Operators.SingletonFrom<CatalogEntry>(c_);

		return d_;
	}

    [CqlDeclaration("ChargeItemResource")]
	public ChargeItem ChargeItemResource(ChargeItem arg)
	{
		ChargeItem[] a_ = [
			arg,
		];
		ChargeItem b_(ChargeItem a)
		{
			List<Identifier> e_ = a?.Identifier;
			List<FhirUri> f_ = a?.DefinitionUriElement;
			List<Canonical> g_ = a?.DefinitionCanonicalElement;
			Code<ChargeItem.ChargeItemStatus> h_ = a?.StatusElement;
			List<ResourceReference> i_ = a?.PartOf;
			CodeableConcept j_ = a?.Code;
			ResourceReference k_ = a?.Subject;
			ResourceReference l_ = a?.Context;
			DataType m_ = a?.Occurrence;
			List<ChargeItem.PerformerComponent> n_ = a?.Performer;
			ResourceReference o_ = a?.PerformingOrganization;
			ResourceReference p_ = a?.RequestingOrganization;
			ResourceReference q_ = a?.CostCenter;
			Quantity r_ = a?.Quantity;
			List<CodeableConcept> s_ = a?.Bodysite;
			FhirDecimal t_ = a?.FactorOverrideElement;
			Money u_ = a?.PriceOverride;
			FhirString v_ = a?.OverrideReasonElement;
			ResourceReference w_ = a?.Enterer;
			FhirDateTime x_ = a?.EnteredDateElement;
			List<CodeableConcept> y_ = a?.Reason;
			List<ResourceReference> z_ = a?.Service;
			DataType aa_ = a?.Product;
			List<ResourceReference> ab_ = a?.Account;
			List<Annotation> ac_ = a?.Note;
			List<ResourceReference> ad_ = a?.SupportingInformation;
			ChargeItem ae_ = new ChargeItem
			{
				Identifier = new List<Identifier>((IEnumerable<Identifier>)e_),
				DefinitionUriElement = new List<FhirUri>((IEnumerable<FhirUri>)f_),
				DefinitionCanonicalElement = new List<Canonical>((IEnumerable<Canonical>)g_),
				StatusElement = h_,
				PartOf = new List<ResourceReference>((IEnumerable<ResourceReference>)i_),
				Code = j_,
				Subject = k_,
				Context = l_,
				Occurrence = (DataType)m_,
				Performer = new List<ChargeItem.PerformerComponent>((IEnumerable<ChargeItem.PerformerComponent>)n_),
				PerformingOrganization = o_,
				RequestingOrganization = p_,
				CostCenter = q_,
				Quantity = r_,
				Bodysite = new List<CodeableConcept>((IEnumerable<CodeableConcept>)s_),
				FactorOverrideElement = t_,
				PriceOverride = u_,
				OverrideReasonElement = v_,
				Enterer = w_,
				EnteredDateElement = x_,
				Reason = new List<CodeableConcept>((IEnumerable<CodeableConcept>)y_),
				Service = new List<ResourceReference>((IEnumerable<ResourceReference>)z_),
				Product = (DataType)aa_,
				Account = new List<ResourceReference>((IEnumerable<ResourceReference>)ab_),
				Note = new List<Annotation>((IEnumerable<Annotation>)ac_),
				SupportingInformation = new List<ResourceReference>((IEnumerable<ResourceReference>)ad_),
			};

			return ae_;
		};
		IEnumerable<ChargeItem> c_ = context.Operators.Select<ChargeItem, ChargeItem>((IEnumerable<ChargeItem>)a_, b_);
		ChargeItem d_ = context.Operators.SingletonFrom<ChargeItem>(c_);

		return d_;
	}

    [CqlDeclaration("ChargeItemDefinitionResource")]
	public ChargeItemDefinition ChargeItemDefinitionResource(ChargeItemDefinition arg)
	{
		ChargeItemDefinition[] a_ = [
			arg,
		];
		ChargeItemDefinition b_(ChargeItemDefinition a)
		{
			FhirUri e_ = a?.UrlElement;
			List<Identifier> f_ = a?.Identifier;
			FhirString g_ = a?.VersionElement;
			FhirString h_ = a?.TitleElement;
			List<FhirUri> i_ = a?.DerivedFromUriElement;
			List<Canonical> j_ = a?.PartOfElement;
			List<Canonical> k_ = a?.ReplacesElement;
			Code<PublicationStatus> l_ = a?.StatusElement;
			FhirBoolean m_ = a?.ExperimentalElement;
			FhirDateTime n_ = a?.DateElement;
			FhirString o_ = a?.PublisherElement;
			List<ContactDetail> p_ = a?.Contact;
			Markdown q_ = a?.DescriptionElement;
			List<UsageContext> r_ = a?.UseContext;
			List<CodeableConcept> s_ = a?.Jurisdiction;
			Markdown t_ = a?.CopyrightElement;
			Date u_ = a?.ApprovalDateElement;
			Date v_ = a?.LastReviewDateElement;
			Period w_ = a?.EffectivePeriod;
			CodeableConcept x_ = a?.Code;
			List<ResourceReference> y_ = a?.Instance;
			List<ChargeItemDefinition.ApplicabilityComponent> z_ = a?.Applicability;
			List<ChargeItemDefinition.PropertyGroupComponent> aa_ = a?.PropertyGroup;
			ChargeItemDefinition ab_ = new ChargeItemDefinition
			{
				UrlElement = e_,
				Identifier = new List<Identifier>((IEnumerable<Identifier>)f_),
				VersionElement = g_,
				TitleElement = h_,
				DerivedFromUriElement = new List<FhirUri>((IEnumerable<FhirUri>)i_),
				PartOfElement = new List<Canonical>((IEnumerable<Canonical>)j_),
				ReplacesElement = new List<Canonical>((IEnumerable<Canonical>)k_),
				StatusElement = l_,
				ExperimentalElement = m_,
				DateElement = n_,
				PublisherElement = o_,
				Contact = new List<ContactDetail>((IEnumerable<ContactDetail>)p_),
				DescriptionElement = q_,
				UseContext = new List<UsageContext>((IEnumerable<UsageContext>)r_),
				Jurisdiction = new List<CodeableConcept>((IEnumerable<CodeableConcept>)s_),
				CopyrightElement = t_,
				ApprovalDateElement = u_,
				LastReviewDateElement = v_,
				EffectivePeriod = w_,
				Code = x_,
				Instance = new List<ResourceReference>((IEnumerable<ResourceReference>)y_),
				Applicability = new List<ChargeItemDefinition.ApplicabilityComponent>((IEnumerable<ChargeItemDefinition.ApplicabilityComponent>)z_),
				PropertyGroup = new List<ChargeItemDefinition.PropertyGroupComponent>((IEnumerable<ChargeItemDefinition.PropertyGroupComponent>)aa_),
			};

			return ab_;
		};
		IEnumerable<ChargeItemDefinition> c_ = context.Operators.Select<ChargeItemDefinition, ChargeItemDefinition>((IEnumerable<ChargeItemDefinition>)a_, b_);
		ChargeItemDefinition d_ = context.Operators.SingletonFrom<ChargeItemDefinition>(c_);

		return d_;
	}

    [CqlDeclaration("ClaimResource")]
	public Claim ClaimResource(Claim arg)
	{
		Claim[] a_ = [
			arg,
		];
		Claim b_(Claim a)
		{
			List<Identifier> e_ = a?.Identifier;
			Code<FinancialResourceStatusCodes> f_ = a?.StatusElement;
			CodeableConcept g_ = a?.Type;
			CodeableConcept h_ = a?.SubType;
			Code<ClaimUseCode> i_ = a?.UseElement;
			ResourceReference j_ = a?.Patient;
			Period k_ = a?.BillablePeriod;
			FhirDateTime l_ = a?.CreatedElement;
			ResourceReference m_ = a?.Enterer;
			ResourceReference n_ = a?.Insurer;
			ResourceReference o_ = a?.Provider;
			CodeableConcept p_ = a?.Priority;
			CodeableConcept q_ = a?.FundsReserve;
			List<Claim.RelatedClaimComponent> r_ = a?.Related;
			ResourceReference s_ = a?.Prescription;
			ResourceReference t_ = a?.OriginalPrescription;
			Claim.PayeeComponent u_ = a?.Payee;
			ResourceReference v_ = a?.Referral;
			ResourceReference w_ = a?.Facility;
			List<Claim.CareTeamComponent> x_ = a?.CareTeam;
			List<Claim.SupportingInformationComponent> y_ = a?.SupportingInfo;
			List<Claim.DiagnosisComponent> z_ = a?.Diagnosis;
			List<Claim.ProcedureComponent> aa_ = a?.Procedure;
			List<Claim.InsuranceComponent> ab_ = a?.Insurance;
			Claim.AccidentComponent ac_ = a?.Accident;
			List<Claim.ItemComponent> ad_ = a?.Item;
			Money ae_ = a?.Total;
			Claim af_ = new Claim
			{
				Identifier = new List<Identifier>((IEnumerable<Identifier>)e_),
				StatusElement = f_,
				Type = g_,
				SubType = h_,
				UseElement = i_,
				Patient = j_,
				BillablePeriod = k_,
				CreatedElement = l_,
				Enterer = m_,
				Insurer = n_,
				Provider = o_,
				Priority = p_,
				FundsReserve = q_,
				Related = new List<Claim.RelatedClaimComponent>((IEnumerable<Claim.RelatedClaimComponent>)r_),
				Prescription = s_,
				OriginalPrescription = t_,
				Payee = u_,
				Referral = v_,
				Facility = w_,
				CareTeam = new List<Claim.CareTeamComponent>((IEnumerable<Claim.CareTeamComponent>)x_),
				SupportingInfo = new List<Claim.SupportingInformationComponent>((IEnumerable<Claim.SupportingInformationComponent>)y_),
				Diagnosis = new List<Claim.DiagnosisComponent>((IEnumerable<Claim.DiagnosisComponent>)z_),
				Procedure = new List<Claim.ProcedureComponent>((IEnumerable<Claim.ProcedureComponent>)aa_),
				Insurance = new List<Claim.InsuranceComponent>((IEnumerable<Claim.InsuranceComponent>)ab_),
				Accident = ac_,
				Item = new List<Claim.ItemComponent>((IEnumerable<Claim.ItemComponent>)ad_),
				Total = ae_,
			};

			return af_;
		};
		IEnumerable<Claim> c_ = context.Operators.Select<Claim, Claim>((IEnumerable<Claim>)a_, b_);
		Claim d_ = context.Operators.SingletonFrom<Claim>(c_);

		return d_;
	}

    [CqlDeclaration("ClaimResponseResource")]
	public ClaimResponse ClaimResponseResource(ClaimResponse arg)
	{
		ClaimResponse[] a_ = [
			arg,
		];
		ClaimResponse b_(ClaimResponse a)
		{
			List<Identifier> e_ = a?.Identifier;
			Code<FinancialResourceStatusCodes> f_ = a?.StatusElement;
			CodeableConcept g_ = a?.Type;
			CodeableConcept h_ = a?.SubType;
			Code<ClaimUseCode> i_ = a?.UseElement;
			ResourceReference j_ = a?.Patient;
			FhirDateTime k_ = a?.CreatedElement;
			ResourceReference l_ = a?.Insurer;
			ResourceReference m_ = a?.Requestor;
			ResourceReference n_ = a?.Request;
			Code<ClaimProcessingCodes> o_ = a?.OutcomeElement;
			FhirString p_ = a?.DispositionElement;
			FhirString q_ = a?.PreAuthRefElement;
			Period r_ = a?.PreAuthPeriod;
			CodeableConcept s_ = a?.PayeeType;
			List<ClaimResponse.ItemComponent> t_ = a?.Item;
			List<ClaimResponse.AddedItemComponent> u_ = a?.AddItem;
			List<ClaimResponse.AdjudicationComponent> v_ = a?.Adjudication;
			List<ClaimResponse.TotalComponent> w_ = a?.Total;
			ClaimResponse.PaymentComponent x_ = a?.Payment;
			CodeableConcept y_ = a?.FundsReserve;
			CodeableConcept z_ = a?.FormCode;
			Attachment aa_ = a?.Form;
			List<ClaimResponse.NoteComponent> ab_ = a?.ProcessNote;
			List<ResourceReference> ac_ = a?.CommunicationRequest;
			List<ClaimResponse.InsuranceComponent> ad_ = a?.Insurance;
			List<ClaimResponse.ErrorComponent> ae_ = a?.Error;
			ClaimResponse af_ = new ClaimResponse
			{
				Identifier = new List<Identifier>((IEnumerable<Identifier>)e_),
				StatusElement = f_,
				Type = g_,
				SubType = h_,
				UseElement = i_,
				Patient = j_,
				CreatedElement = k_,
				Insurer = l_,
				Requestor = m_,
				Request = n_,
				OutcomeElement = o_,
				DispositionElement = p_,
				PreAuthRefElement = q_,
				PreAuthPeriod = r_,
				PayeeType = s_,
				Item = new List<ClaimResponse.ItemComponent>((IEnumerable<ClaimResponse.ItemComponent>)t_),
				AddItem = new List<ClaimResponse.AddedItemComponent>((IEnumerable<ClaimResponse.AddedItemComponent>)u_),
				Adjudication = new List<ClaimResponse.AdjudicationComponent>((IEnumerable<ClaimResponse.AdjudicationComponent>)v_),
				Total = new List<ClaimResponse.TotalComponent>((IEnumerable<ClaimResponse.TotalComponent>)w_),
				Payment = x_,
				FundsReserve = y_,
				FormCode = z_,
				Form = aa_,
				ProcessNote = new List<ClaimResponse.NoteComponent>((IEnumerable<ClaimResponse.NoteComponent>)ab_),
				CommunicationRequest = new List<ResourceReference>((IEnumerable<ResourceReference>)ac_),
				Insurance = new List<ClaimResponse.InsuranceComponent>((IEnumerable<ClaimResponse.InsuranceComponent>)ad_),
				Error = new List<ClaimResponse.ErrorComponent>((IEnumerable<ClaimResponse.ErrorComponent>)ae_),
			};

			return af_;
		};
		IEnumerable<ClaimResponse> c_ = context.Operators.Select<ClaimResponse, ClaimResponse>((IEnumerable<ClaimResponse>)a_, b_);
		ClaimResponse d_ = context.Operators.SingletonFrom<ClaimResponse>(c_);

		return d_;
	}

    [CqlDeclaration("ClinicalImpressionResource")]
	public ClinicalImpression ClinicalImpressionResource(ClinicalImpression arg)
	{
		ClinicalImpression[] a_ = [
			arg,
		];
		ClinicalImpression b_(ClinicalImpression a)
		{
			List<Identifier> e_ = a?.Identifier;
			Code<ClinicalImpression.ClinicalImpressionStatus> f_ = a?.StatusElement;
			CodeableConcept g_ = a?.StatusReason;
			CodeableConcept h_ = a?.Code;
			FhirString i_ = a?.DescriptionElement;
			ResourceReference j_ = a?.Subject;
			ResourceReference k_ = a?.Encounter;
			DataType l_ = a?.Effective;
			FhirDateTime m_ = a?.DateElement;
			ResourceReference n_ = a?.Assessor;
			ResourceReference o_ = a?.Previous;
			List<ResourceReference> p_ = a?.Problem;
			List<ClinicalImpression.InvestigationComponent> q_ = a?.Investigation;
			List<FhirUri> r_ = a?.ProtocolElement;
			FhirString s_ = a?.SummaryElement;
			List<ClinicalImpression.FindingComponent> t_ = a?.Finding;
			List<CodeableConcept> u_ = a?.PrognosisCodeableConcept;
			List<ResourceReference> v_ = a?.PrognosisReference;
			List<ResourceReference> w_ = a?.SupportingInfo;
			List<Annotation> x_ = a?.Note;
			ClinicalImpression y_ = new ClinicalImpression
			{
				Identifier = new List<Identifier>((IEnumerable<Identifier>)e_),
				StatusElement = f_,
				StatusReason = g_,
				Code = h_,
				DescriptionElement = i_,
				Subject = j_,
				Encounter = k_,
				Effective = (DataType)l_,
				DateElement = m_,
				Assessor = n_,
				Previous = o_,
				Problem = new List<ResourceReference>((IEnumerable<ResourceReference>)p_),
				Investigation = new List<ClinicalImpression.InvestigationComponent>((IEnumerable<ClinicalImpression.InvestigationComponent>)q_),
				ProtocolElement = new List<FhirUri>((IEnumerable<FhirUri>)r_),
				SummaryElement = s_,
				Finding = new List<ClinicalImpression.FindingComponent>((IEnumerable<ClinicalImpression.FindingComponent>)t_),
				PrognosisCodeableConcept = new List<CodeableConcept>((IEnumerable<CodeableConcept>)u_),
				PrognosisReference = new List<ResourceReference>((IEnumerable<ResourceReference>)v_),
				SupportingInfo = new List<ResourceReference>((IEnumerable<ResourceReference>)w_),
				Note = new List<Annotation>((IEnumerable<Annotation>)x_),
			};

			return y_;
		};
		IEnumerable<ClinicalImpression> c_ = context.Operators.Select<ClinicalImpression, ClinicalImpression>((IEnumerable<ClinicalImpression>)a_, b_);
		ClinicalImpression d_ = context.Operators.SingletonFrom<ClinicalImpression>(c_);

		return d_;
	}

    [CqlDeclaration("CodeSystemResource")]
	public CodeSystem CodeSystemResource(CodeSystem arg)
	{
		CodeSystem[] a_ = [
			arg,
		];
		CodeSystem b_(CodeSystem a)
		{
			FhirUri e_ = a?.UrlElement;
			List<Identifier> f_ = a?.Identifier;
			FhirString g_ = a?.VersionElement;
			FhirString h_ = a?.NameElement;
			FhirString i_ = a?.TitleElement;
			Code<PublicationStatus> j_ = a?.StatusElement;
			FhirBoolean k_ = a?.ExperimentalElement;
			FhirDateTime l_ = a?.DateElement;
			FhirString m_ = a?.PublisherElement;
			List<ContactDetail> n_ = a?.Contact;
			Markdown o_ = a?.DescriptionElement;
			List<UsageContext> p_ = a?.UseContext;
			List<CodeableConcept> q_ = a?.Jurisdiction;
			Markdown r_ = a?.PurposeElement;
			Markdown s_ = a?.CopyrightElement;
			FhirBoolean t_ = a?.CaseSensitiveElement;
			Canonical u_ = a?.ValueSetElement;
			Code<CodeSystem.CodeSystemHierarchyMeaning> v_ = a?.HierarchyMeaningElement;
			FhirBoolean w_ = a?.CompositionalElement;
			FhirBoolean x_ = a?.VersionNeededElement;
			Code<CodeSystemContentMode> y_ = a?.ContentElement;
			Canonical z_ = a?.SupplementsElement;
			UnsignedInt aa_ = a?.CountElement;
			Integer ab_ = context.Operators.Convert<Integer>(aa_);
			UnsignedInt ac_ = context.Operators.Convert<UnsignedInt>(ab_);
			List<CodeSystem.FilterComponent> ad_ = a?.Filter;
			List<CodeSystem.PropertyComponent> ae_ = a?.Property;
			List<CodeSystem.ConceptDefinitionComponent> af_ = a?.Concept;
			CodeSystem ag_ = new CodeSystem
			{
				UrlElement = e_,
				Identifier = new List<Identifier>((IEnumerable<Identifier>)f_),
				VersionElement = g_,
				NameElement = h_,
				TitleElement = i_,
				StatusElement = j_,
				ExperimentalElement = k_,
				DateElement = l_,
				PublisherElement = m_,
				Contact = new List<ContactDetail>((IEnumerable<ContactDetail>)n_),
				DescriptionElement = o_,
				UseContext = new List<UsageContext>((IEnumerable<UsageContext>)p_),
				Jurisdiction = new List<CodeableConcept>((IEnumerable<CodeableConcept>)q_),
				PurposeElement = r_,
				CopyrightElement = s_,
				CaseSensitiveElement = t_,
				ValueSetElement = u_,
				HierarchyMeaningElement = v_,
				CompositionalElement = w_,
				VersionNeededElement = x_,
				ContentElement = y_,
				SupplementsElement = z_,
				CountElement = ac_,
				Filter = new List<CodeSystem.FilterComponent>((IEnumerable<CodeSystem.FilterComponent>)ad_),
				Property = new List<CodeSystem.PropertyComponent>((IEnumerable<CodeSystem.PropertyComponent>)ae_),
				Concept = new List<CodeSystem.ConceptDefinitionComponent>((IEnumerable<CodeSystem.ConceptDefinitionComponent>)af_),
			};

			return ag_;
		};
		IEnumerable<CodeSystem> c_ = context.Operators.Select<CodeSystem, CodeSystem>((IEnumerable<CodeSystem>)a_, b_);
		CodeSystem d_ = context.Operators.SingletonFrom<CodeSystem>(c_);

		return d_;
	}

    [CqlDeclaration("CommunicationResource")]
	public Communication CommunicationResource(Communication arg)
	{
		Communication[] a_ = [
			arg,
		];
		Communication b_(Communication a)
		{
			List<Identifier> e_ = a?.Identifier;
			List<Canonical> f_ = a?.InstantiatesCanonicalElement;
			List<FhirUri> g_ = a?.InstantiatesUriElement;
			List<ResourceReference> h_ = a?.BasedOn;
			List<ResourceReference> i_ = a?.PartOf;
			List<ResourceReference> j_ = a?.InResponseTo;
			Code<EventStatus> k_ = a?.StatusElement;
			CodeableConcept l_ = a?.StatusReason;
			List<CodeableConcept> m_ = a?.Category;
			Code<RequestPriority> n_ = a?.PriorityElement;
			List<CodeableConcept> o_ = a?.Medium;
			ResourceReference p_ = a?.Subject;
			CodeableConcept q_ = a?.Topic;
			List<ResourceReference> r_ = a?.About;
			ResourceReference s_ = a?.Encounter;
			FhirDateTime t_ = a?.SentElement;
			FhirDateTime u_ = a?.ReceivedElement;
			List<ResourceReference> v_ = a?.Recipient;
			ResourceReference w_ = a?.Sender;
			List<CodeableConcept> x_ = a?.ReasonCode;
			List<ResourceReference> y_ = a?.ReasonReference;
			List<Communication.PayloadComponent> z_ = a?.Payload;
			List<Annotation> aa_ = a?.Note;
			Communication ab_ = new Communication
			{
				Identifier = new List<Identifier>((IEnumerable<Identifier>)e_),
				InstantiatesCanonicalElement = new List<Canonical>((IEnumerable<Canonical>)f_),
				InstantiatesUriElement = new List<FhirUri>((IEnumerable<FhirUri>)g_),
				BasedOn = new List<ResourceReference>((IEnumerable<ResourceReference>)h_),
				PartOf = new List<ResourceReference>((IEnumerable<ResourceReference>)i_),
				InResponseTo = new List<ResourceReference>((IEnumerable<ResourceReference>)j_),
				StatusElement = k_,
				StatusReason = l_,
				Category = new List<CodeableConcept>((IEnumerable<CodeableConcept>)m_),
				PriorityElement = n_,
				Medium = new List<CodeableConcept>((IEnumerable<CodeableConcept>)o_),
				Subject = p_,
				Topic = q_,
				About = new List<ResourceReference>((IEnumerable<ResourceReference>)r_),
				Encounter = s_,
				SentElement = t_,
				ReceivedElement = u_,
				Recipient = new List<ResourceReference>((IEnumerable<ResourceReference>)v_),
				Sender = w_,
				ReasonCode = new List<CodeableConcept>((IEnumerable<CodeableConcept>)x_),
				ReasonReference = new List<ResourceReference>((IEnumerable<ResourceReference>)y_),
				Payload = new List<Communication.PayloadComponent>((IEnumerable<Communication.PayloadComponent>)z_),
				Note = new List<Annotation>((IEnumerable<Annotation>)aa_),
			};

			return ab_;
		};
		IEnumerable<Communication> c_ = context.Operators.Select<Communication, Communication>((IEnumerable<Communication>)a_, b_);
		Communication d_ = context.Operators.SingletonFrom<Communication>(c_);

		return d_;
	}

    [CqlDeclaration("CommunicationRequestResource")]
	public CommunicationRequest CommunicationRequestResource(CommunicationRequest arg)
	{
		CommunicationRequest[] a_ = [
			arg,
		];
		CommunicationRequest b_(CommunicationRequest a)
		{
			List<Identifier> e_ = a?.Identifier;
			List<ResourceReference> f_ = a?.BasedOn;
			List<ResourceReference> g_ = a?.Replaces;
			Identifier h_ = a?.GroupIdentifier;
			Code<RequestStatus> i_ = a?.StatusElement;
			CodeableConcept j_ = a?.StatusReason;
			List<CodeableConcept> k_ = a?.Category;
			Code<RequestPriority> l_ = a?.PriorityElement;
			FhirBoolean m_ = a?.DoNotPerformElement;
			List<CodeableConcept> n_ = a?.Medium;
			ResourceReference o_ = a?.Subject;
			List<ResourceReference> p_ = a?.About;
			ResourceReference q_ = a?.Encounter;
			List<CommunicationRequest.PayloadComponent> r_ = a?.Payload;
			DataType s_ = a?.Occurrence;
			FhirDateTime t_ = a?.AuthoredOnElement;
			ResourceReference u_ = a?.Requester;
			List<ResourceReference> v_ = a?.Recipient;
			ResourceReference w_ = a?.Sender;
			List<CodeableConcept> x_ = a?.ReasonCode;
			List<ResourceReference> y_ = a?.ReasonReference;
			List<Annotation> z_ = a?.Note;
			CommunicationRequest aa_ = new CommunicationRequest
			{
				Identifier = new List<Identifier>((IEnumerable<Identifier>)e_),
				BasedOn = new List<ResourceReference>((IEnumerable<ResourceReference>)f_),
				Replaces = new List<ResourceReference>((IEnumerable<ResourceReference>)g_),
				GroupIdentifier = h_,
				StatusElement = i_,
				StatusReason = j_,
				Category = new List<CodeableConcept>((IEnumerable<CodeableConcept>)k_),
				PriorityElement = l_,
				DoNotPerformElement = m_,
				Medium = new List<CodeableConcept>((IEnumerable<CodeableConcept>)n_),
				Subject = o_,
				About = new List<ResourceReference>((IEnumerable<ResourceReference>)p_),
				Encounter = q_,
				Payload = new List<CommunicationRequest.PayloadComponent>((IEnumerable<CommunicationRequest.PayloadComponent>)r_),
				Occurrence = (DataType)s_,
				AuthoredOnElement = t_,
				Requester = u_,
				Recipient = new List<ResourceReference>((IEnumerable<ResourceReference>)v_),
				Sender = w_,
				ReasonCode = new List<CodeableConcept>((IEnumerable<CodeableConcept>)x_),
				ReasonReference = new List<ResourceReference>((IEnumerable<ResourceReference>)y_),
				Note = new List<Annotation>((IEnumerable<Annotation>)z_),
			};

			return aa_;
		};
		IEnumerable<CommunicationRequest> c_ = context.Operators.Select<CommunicationRequest, CommunicationRequest>((IEnumerable<CommunicationRequest>)a_, b_);
		CommunicationRequest d_ = context.Operators.SingletonFrom<CommunicationRequest>(c_);

		return d_;
	}

    [CqlDeclaration("CompositionResource")]
	public Composition CompositionResource(Composition arg)
	{
		Composition[] a_ = [
			arg,
		];
		Composition b_(Composition a)
		{
			Identifier e_ = a?.Identifier;
			Code<CompositionStatus> f_ = a?.StatusElement;
			CodeableConcept g_ = a?.Type;
			List<CodeableConcept> h_ = a?.Category;
			ResourceReference i_ = a?.Subject;
			ResourceReference j_ = a?.Encounter;
			FhirDateTime k_ = a?.DateElement;
			List<ResourceReference> l_ = a?.Author;
			FhirString m_ = a?.TitleElement;
			Code<Composition.V3ConfidentialityClassification> n_ = a?.ConfidentialityElement;
			List<Composition.AttesterComponent> o_ = a?.Attester;
			ResourceReference p_ = a?.Custodian;
			List<Composition.RelatesToComponent> q_ = a?.RelatesTo;
			List<Composition.EventComponent> r_ = a?.Event;
			List<Composition.SectionComponent> s_ = a?.Section;
			Composition t_ = new Composition
			{
				Identifier = e_,
				StatusElement = f_,
				Type = g_,
				Category = new List<CodeableConcept>((IEnumerable<CodeableConcept>)h_),
				Subject = i_,
				Encounter = j_,
				DateElement = k_,
				Author = new List<ResourceReference>((IEnumerable<ResourceReference>)l_),
				TitleElement = m_,
				ConfidentialityElement = n_,
				Attester = new List<Composition.AttesterComponent>((IEnumerable<Composition.AttesterComponent>)o_),
				Custodian = p_,
				RelatesTo = new List<Composition.RelatesToComponent>((IEnumerable<Composition.RelatesToComponent>)q_),
				Event = new List<Composition.EventComponent>((IEnumerable<Composition.EventComponent>)r_),
				Section = new List<Composition.SectionComponent>((IEnumerable<Composition.SectionComponent>)s_),
			};

			return t_;
		};
		IEnumerable<Composition> c_ = context.Operators.Select<Composition, Composition>((IEnumerable<Composition>)a_, b_);
		Composition d_ = context.Operators.SingletonFrom<Composition>(c_);

		return d_;
	}

    [CqlDeclaration("ConceptMapResource")]
	public ConceptMap ConceptMapResource(ConceptMap arg)
	{
		ConceptMap[] a_ = [
			arg,
		];
		ConceptMap b_(ConceptMap a)
		{
			FhirUri e_ = a?.UrlElement;
			Identifier f_ = a?.Identifier;
			FhirString g_ = a?.VersionElement;
			FhirString h_ = a?.NameElement;
			FhirString i_ = a?.TitleElement;
			Code<PublicationStatus> j_ = a?.StatusElement;
			FhirBoolean k_ = a?.ExperimentalElement;
			FhirDateTime l_ = a?.DateElement;
			FhirString m_ = a?.PublisherElement;
			List<ContactDetail> n_ = a?.Contact;
			Markdown o_ = a?.DescriptionElement;
			List<UsageContext> p_ = a?.UseContext;
			List<CodeableConcept> q_ = a?.Jurisdiction;
			Markdown r_ = a?.PurposeElement;
			Markdown s_ = a?.CopyrightElement;
			DataType t_ = a?.Source;
			DataType u_ = a?.Target;
			List<ConceptMap.GroupComponent> v_ = a?.Group;
			ConceptMap w_ = new ConceptMap
			{
				UrlElement = e_,
				Identifier = f_,
				VersionElement = g_,
				NameElement = h_,
				TitleElement = i_,
				StatusElement = j_,
				ExperimentalElement = k_,
				DateElement = l_,
				PublisherElement = m_,
				Contact = new List<ContactDetail>((IEnumerable<ContactDetail>)n_),
				DescriptionElement = o_,
				UseContext = new List<UsageContext>((IEnumerable<UsageContext>)p_),
				Jurisdiction = new List<CodeableConcept>((IEnumerable<CodeableConcept>)q_),
				PurposeElement = r_,
				CopyrightElement = s_,
				Source = (DataType)t_,
				Target = (DataType)u_,
				Group = new List<ConceptMap.GroupComponent>((IEnumerable<ConceptMap.GroupComponent>)v_),
			};

			return w_;
		};
		IEnumerable<ConceptMap> c_ = context.Operators.Select<ConceptMap, ConceptMap>((IEnumerable<ConceptMap>)a_, b_);
		ConceptMap d_ = context.Operators.SingletonFrom<ConceptMap>(c_);

		return d_;
	}

    [CqlDeclaration("ConditionResource")]
	public Condition ConditionResource(Condition arg)
	{
		Condition[] a_ = [
			arg,
		];
		Condition b_(Condition a)
		{
			List<Identifier> e_ = a?.Identifier;
			CodeableConcept f_ = a?.ClinicalStatus;
			CodeableConcept g_ = a?.VerificationStatus;
			List<CodeableConcept> h_ = a?.Category;
			CodeableConcept i_ = a?.Severity;
			CodeableConcept j_ = a?.Code;
			List<CodeableConcept> k_ = a?.BodySite;
			ResourceReference l_ = a?.Subject;
			ResourceReference m_ = a?.Encounter;
			DataType n_ = a?.Onset;
			DataType o_ = a?.Abatement;
			FhirDateTime p_ = a?.RecordedDateElement;
			ResourceReference q_ = a?.Recorder;
			ResourceReference r_ = a?.Asserter;
			List<Condition.StageComponent> s_ = a?.Stage;
			List<Condition.EvidenceComponent> t_ = a?.Evidence;
			List<Annotation> u_ = a?.Note;
			Condition v_ = new Condition
			{
				Identifier = new List<Identifier>((IEnumerable<Identifier>)e_),
				ClinicalStatus = f_,
				VerificationStatus = g_,
				Category = new List<CodeableConcept>((IEnumerable<CodeableConcept>)h_),
				Severity = i_,
				Code = j_,
				BodySite = new List<CodeableConcept>((IEnumerable<CodeableConcept>)k_),
				Subject = l_,
				Encounter = m_,
				Onset = (DataType)n_,
				Abatement = (DataType)o_,
				RecordedDateElement = p_,
				Recorder = q_,
				Asserter = r_,
				Stage = new List<Condition.StageComponent>((IEnumerable<Condition.StageComponent>)s_),
				Evidence = new List<Condition.EvidenceComponent>((IEnumerable<Condition.EvidenceComponent>)t_),
				Note = new List<Annotation>((IEnumerable<Annotation>)u_),
			};

			return v_;
		};
		IEnumerable<Condition> c_ = context.Operators.Select<Condition, Condition>((IEnumerable<Condition>)a_, b_);
		Condition d_ = context.Operators.SingletonFrom<Condition>(c_);

		return d_;
	}

    [CqlDeclaration("ConsentResource")]
	public Consent ConsentResource(Consent arg)
	{
		Consent[] a_ = [
			arg,
		];
		Consent b_(Consent a)
		{
			List<Identifier> e_ = a?.Identifier;
			Code<Consent.ConsentState> f_ = a?.StatusElement;
			CodeableConcept g_ = a?.Scope;
			List<CodeableConcept> h_ = a?.Category;
			ResourceReference i_ = a?.Patient;
			FhirDateTime j_ = a?.DateTimeElement;
			List<ResourceReference> k_ = a?.Performer;
			List<ResourceReference> l_ = a?.Organization;
			DataType m_ = a?.Source;
			List<Consent.PolicyComponent> n_ = a?.Policy;
			CodeableConcept o_ = a?.PolicyRule;
			List<Consent.VerificationComponent> p_ = a?.Verification;
			Consent.provisionComponent q_ = a?.Provision;
			Consent r_ = new Consent
			{
				Identifier = new List<Identifier>((IEnumerable<Identifier>)e_),
				StatusElement = f_,
				Scope = g_,
				Category = new List<CodeableConcept>((IEnumerable<CodeableConcept>)h_),
				Patient = i_,
				DateTimeElement = j_,
				Performer = new List<ResourceReference>((IEnumerable<ResourceReference>)k_),
				Organization = new List<ResourceReference>((IEnumerable<ResourceReference>)l_),
				Source = (DataType)m_,
				Policy = new List<Consent.PolicyComponent>((IEnumerable<Consent.PolicyComponent>)n_),
				PolicyRule = o_,
				Verification = new List<Consent.VerificationComponent>((IEnumerable<Consent.VerificationComponent>)p_),
				Provision = q_,
			};

			return r_;
		};
		IEnumerable<Consent> c_ = context.Operators.Select<Consent, Consent>((IEnumerable<Consent>)a_, b_);
		Consent d_ = context.Operators.SingletonFrom<Consent>(c_);

		return d_;
	}

    [CqlDeclaration("ContractResource")]
	public Contract ContractResource(Contract arg)
	{
		Contract[] a_ = [
			arg,
		];
		Contract b_(Contract a)
		{
			List<Identifier> e_ = a?.Identifier;
			FhirUri f_ = a?.UrlElement;
			FhirString g_ = a?.VersionElement;
			Code<Contract.ContractResourceStatusCodes> h_ = a?.StatusElement;
			CodeableConcept i_ = a?.LegalState;
			ResourceReference j_ = a?.InstantiatesCanonical;
			FhirUri k_ = a?.InstantiatesUriElement;
			CodeableConcept l_ = a?.ContentDerivative;
			FhirDateTime m_ = a?.IssuedElement;
			Period n_ = a?.Applies;
			CodeableConcept o_ = a?.ExpirationType;
			List<ResourceReference> p_ = a?.Subject;
			List<ResourceReference> q_ = a?.Authority;
			List<ResourceReference> r_ = a?.Domain;
			List<ResourceReference> s_ = a?.Site;
			FhirString t_ = a?.NameElement;
			FhirString u_ = a?.TitleElement;
			FhirString v_ = a?.SubtitleElement;
			List<FhirString> w_ = a?.AliasElement;
			ResourceReference x_ = a?.Author;
			CodeableConcept y_ = a?.Scope;
			DataType z_ = a?.Topic;
			CodeableConcept aa_ = a?.Type;
			List<CodeableConcept> ab_ = a?.SubType;
			Contract.ContentDefinitionComponent ac_ = a?.ContentDefinition;
			List<Contract.TermComponent> ad_ = a?.Term;
			List<ResourceReference> ae_ = a?.SupportingInfo;
			List<ResourceReference> af_ = a?.RelevantHistory;
			List<Contract.SignatoryComponent> ag_ = a?.Signer;
			List<Contract.FriendlyLanguageComponent> ah_ = a?.Friendly;
			List<Contract.LegalLanguageComponent> ai_ = a?.Legal;
			List<Contract.ComputableLanguageComponent> aj_ = a?.Rule;
			DataType ak_ = a?.LegallyBinding;
			Contract al_ = new Contract
			{
				Identifier = new List<Identifier>((IEnumerable<Identifier>)e_),
				UrlElement = f_,
				VersionElement = g_,
				StatusElement = h_,
				LegalState = i_,
				InstantiatesCanonical = j_,
				InstantiatesUriElement = k_,
				ContentDerivative = l_,
				IssuedElement = m_,
				Applies = n_,
				ExpirationType = o_,
				Subject = new List<ResourceReference>((IEnumerable<ResourceReference>)p_),
				Authority = new List<ResourceReference>((IEnumerable<ResourceReference>)q_),
				Domain = new List<ResourceReference>((IEnumerable<ResourceReference>)r_),
				Site = new List<ResourceReference>((IEnumerable<ResourceReference>)s_),
				NameElement = t_,
				TitleElement = u_,
				SubtitleElement = v_,
				AliasElement = new List<FhirString>((IEnumerable<FhirString>)w_),
				Author = x_,
				Scope = y_,
				Topic = (DataType)z_,
				Type = aa_,
				SubType = new List<CodeableConcept>((IEnumerable<CodeableConcept>)ab_),
				ContentDefinition = ac_,
				Term = new List<Contract.TermComponent>((IEnumerable<Contract.TermComponent>)ad_),
				SupportingInfo = new List<ResourceReference>((IEnumerable<ResourceReference>)ae_),
				RelevantHistory = new List<ResourceReference>((IEnumerable<ResourceReference>)af_),
				Signer = new List<Contract.SignatoryComponent>((IEnumerable<Contract.SignatoryComponent>)ag_),
				Friendly = new List<Contract.FriendlyLanguageComponent>((IEnumerable<Contract.FriendlyLanguageComponent>)ah_),
				Legal = new List<Contract.LegalLanguageComponent>((IEnumerable<Contract.LegalLanguageComponent>)ai_),
				Rule = new List<Contract.ComputableLanguageComponent>((IEnumerable<Contract.ComputableLanguageComponent>)aj_),
				LegallyBinding = (DataType)ak_,
			};

			return al_;
		};
		IEnumerable<Contract> c_ = context.Operators.Select<Contract, Contract>((IEnumerable<Contract>)a_, b_);
		Contract d_ = context.Operators.SingletonFrom<Contract>(c_);

		return d_;
	}

    [CqlDeclaration("CoverageResource")]
	public Coverage CoverageResource(Coverage arg)
	{
		Coverage[] a_ = [
			arg,
		];
		Coverage b_(Coverage a)
		{
			List<Identifier> e_ = a?.Identifier;
			Code<FinancialResourceStatusCodes> f_ = a?.StatusElement;
			CodeableConcept g_ = a?.Type;
			ResourceReference h_ = a?.PolicyHolder;
			ResourceReference i_ = a?.Subscriber;
			FhirString j_ = a?.SubscriberIdElement;
			ResourceReference k_ = a?.Beneficiary;
			FhirString l_ = a?.DependentElement;
			CodeableConcept m_ = a?.Relationship;
			Period n_ = a?.Period;
			List<ResourceReference> o_ = a?.Payor;
			List<Coverage.ClassComponent> p_ = a?.Class;
			PositiveInt q_ = a?.OrderElement;
			Integer r_ = context.Operators.Convert<Integer>(q_);
			PositiveInt s_ = context.Operators.Convert<PositiveInt>(r_);
			FhirString t_ = a?.NetworkElement;
			List<Coverage.CostToBeneficiaryComponent> u_ = a?.CostToBeneficiary;
			FhirBoolean v_ = a?.SubrogationElement;
			List<ResourceReference> w_ = a?.Contract;
			Coverage x_ = new Coverage
			{
				Identifier = new List<Identifier>((IEnumerable<Identifier>)e_),
				StatusElement = f_,
				Type = g_,
				PolicyHolder = h_,
				Subscriber = i_,
				SubscriberIdElement = j_,
				Beneficiary = k_,
				DependentElement = l_,
				Relationship = m_,
				Period = n_,
				Payor = new List<ResourceReference>((IEnumerable<ResourceReference>)o_),
				Class = new List<Coverage.ClassComponent>((IEnumerable<Coverage.ClassComponent>)p_),
				OrderElement = s_,
				NetworkElement = t_,
				CostToBeneficiary = new List<Coverage.CostToBeneficiaryComponent>((IEnumerable<Coverage.CostToBeneficiaryComponent>)u_),
				SubrogationElement = v_,
				Contract = new List<ResourceReference>((IEnumerable<ResourceReference>)w_),
			};

			return x_;
		};
		IEnumerable<Coverage> c_ = context.Operators.Select<Coverage, Coverage>((IEnumerable<Coverage>)a_, b_);
		Coverage d_ = context.Operators.SingletonFrom<Coverage>(c_);

		return d_;
	}

    [CqlDeclaration("CoverageEligibilityRequestResource")]
	public CoverageEligibilityRequest CoverageEligibilityRequestResource(CoverageEligibilityRequest arg)
	{
		CoverageEligibilityRequest[] a_ = [
			arg,
		];
		CoverageEligibilityRequest b_(CoverageEligibilityRequest a)
		{
			List<Identifier> e_ = a?.Identifier;
			Code<FinancialResourceStatusCodes> f_ = a?.StatusElement;
			CodeableConcept g_ = a?.Priority;
			List<Code<CoverageEligibilityRequest.EligibilityRequestPurpose>> h_ = a?.PurposeElement;
			ResourceReference i_ = a?.Patient;
			DataType j_ = a?.Serviced;
			FhirDateTime k_ = a?.CreatedElement;
			ResourceReference l_ = a?.Enterer;
			ResourceReference m_ = a?.Provider;
			ResourceReference n_ = a?.Insurer;
			ResourceReference o_ = a?.Facility;
			List<CoverageEligibilityRequest.SupportingInformationComponent> p_ = a?.SupportingInfo;
			List<CoverageEligibilityRequest.InsuranceComponent> q_ = a?.Insurance;
			List<CoverageEligibilityRequest.DetailsComponent> r_ = a?.Item;
			CoverageEligibilityRequest s_ = new CoverageEligibilityRequest
			{
				Identifier = new List<Identifier>((IEnumerable<Identifier>)e_),
				StatusElement = f_,
				Priority = g_,
				PurposeElement = new List<Code<CoverageEligibilityRequest.EligibilityRequestPurpose>>((IEnumerable<Code<CoverageEligibilityRequest.EligibilityRequestPurpose>>)h_),
				Patient = i_,
				Serviced = (DataType)j_,
				CreatedElement = k_,
				Enterer = l_,
				Provider = m_,
				Insurer = n_,
				Facility = o_,
				SupportingInfo = new List<CoverageEligibilityRequest.SupportingInformationComponent>((IEnumerable<CoverageEligibilityRequest.SupportingInformationComponent>)p_),
				Insurance = new List<CoverageEligibilityRequest.InsuranceComponent>((IEnumerable<CoverageEligibilityRequest.InsuranceComponent>)q_),
				Item = new List<CoverageEligibilityRequest.DetailsComponent>((IEnumerable<CoverageEligibilityRequest.DetailsComponent>)r_),
			};

			return s_;
		};
		IEnumerable<CoverageEligibilityRequest> c_ = context.Operators.Select<CoverageEligibilityRequest, CoverageEligibilityRequest>((IEnumerable<CoverageEligibilityRequest>)a_, b_);
		CoverageEligibilityRequest d_ = context.Operators.SingletonFrom<CoverageEligibilityRequest>(c_);

		return d_;
	}

    [CqlDeclaration("CoverageEligibilityResponseResource")]
	public CoverageEligibilityResponse CoverageEligibilityResponseResource(CoverageEligibilityResponse arg)
	{
		CoverageEligibilityResponse[] a_ = [
			arg,
		];
		CoverageEligibilityResponse b_(CoverageEligibilityResponse a)
		{
			List<Identifier> e_ = a?.Identifier;
			Code<FinancialResourceStatusCodes> f_ = a?.StatusElement;
			List<Code<CoverageEligibilityResponse.EligibilityResponsePurpose>> g_ = a?.PurposeElement;
			ResourceReference h_ = a?.Patient;
			DataType i_ = a?.Serviced;
			FhirDateTime j_ = a?.CreatedElement;
			ResourceReference k_ = a?.Requestor;
			ResourceReference l_ = a?.Request;
			Code<ClaimProcessingCodes> m_ = a?.OutcomeElement;
			FhirString n_ = a?.DispositionElement;
			ResourceReference o_ = a?.Insurer;
			List<CoverageEligibilityResponse.InsuranceComponent> p_ = a?.Insurance;
			FhirString q_ = a?.PreAuthRefElement;
			CodeableConcept r_ = a?.Form;
			List<CoverageEligibilityResponse.ErrorsComponent> s_ = a?.Error;
			CoverageEligibilityResponse t_ = new CoverageEligibilityResponse
			{
				Identifier = new List<Identifier>((IEnumerable<Identifier>)e_),
				StatusElement = f_,
				PurposeElement = new List<Code<CoverageEligibilityResponse.EligibilityResponsePurpose>>((IEnumerable<Code<CoverageEligibilityResponse.EligibilityResponsePurpose>>)g_),
				Patient = h_,
				Serviced = (DataType)i_,
				CreatedElement = j_,
				Requestor = k_,
				Request = l_,
				OutcomeElement = m_,
				DispositionElement = n_,
				Insurer = o_,
				Insurance = new List<CoverageEligibilityResponse.InsuranceComponent>((IEnumerable<CoverageEligibilityResponse.InsuranceComponent>)p_),
				PreAuthRefElement = q_,
				Form = r_,
				Error = new List<CoverageEligibilityResponse.ErrorsComponent>((IEnumerable<CoverageEligibilityResponse.ErrorsComponent>)s_),
			};

			return t_;
		};
		IEnumerable<CoverageEligibilityResponse> c_ = context.Operators.Select<CoverageEligibilityResponse, CoverageEligibilityResponse>((IEnumerable<CoverageEligibilityResponse>)a_, b_);
		CoverageEligibilityResponse d_ = context.Operators.SingletonFrom<CoverageEligibilityResponse>(c_);

		return d_;
	}

    [CqlDeclaration("DetectedIssueResource")]
	public DetectedIssue DetectedIssueResource(DetectedIssue arg)
	{
		DetectedIssue[] a_ = [
			arg,
		];
		DetectedIssue b_(DetectedIssue a)
		{
			List<Identifier> e_ = a?.Identifier;
			Code<ObservationStatus> f_ = a?.StatusElement;
			CodeableConcept g_ = a?.Code;
			Code<DetectedIssue.DetectedIssueSeverity> h_ = a?.SeverityElement;
			ResourceReference i_ = a?.Patient;
			DataType j_ = a?.Identified;
			ResourceReference k_ = a?.Author;
			List<ResourceReference> l_ = a?.Implicated;
			List<DetectedIssue.EvidenceComponent> m_ = a?.Evidence;
			FhirString n_ = a?.DetailElement;
			FhirUri o_ = a?.ReferenceElement;
			List<DetectedIssue.MitigationComponent> p_ = a?.Mitigation;
			DetectedIssue q_ = new DetectedIssue
			{
				Identifier = new List<Identifier>((IEnumerable<Identifier>)e_),
				StatusElement = f_,
				Code = g_,
				SeverityElement = h_,
				Patient = i_,
				Identified = (DataType)j_,
				Author = k_,
				Implicated = new List<ResourceReference>((IEnumerable<ResourceReference>)l_),
				Evidence = new List<DetectedIssue.EvidenceComponent>((IEnumerable<DetectedIssue.EvidenceComponent>)m_),
				DetailElement = n_,
				ReferenceElement = o_,
				Mitigation = new List<DetectedIssue.MitigationComponent>((IEnumerable<DetectedIssue.MitigationComponent>)p_),
			};

			return q_;
		};
		IEnumerable<DetectedIssue> c_ = context.Operators.Select<DetectedIssue, DetectedIssue>((IEnumerable<DetectedIssue>)a_, b_);
		DetectedIssue d_ = context.Operators.SingletonFrom<DetectedIssue>(c_);

		return d_;
	}

    [CqlDeclaration("DeviceResource")]
	public Device DeviceResource(Device arg)
	{
		Device[] a_ = [
			arg,
		];
		Device b_(Device a)
		{
			List<Identifier> e_ = a?.Identifier;
			ResourceReference f_ = a?.Definition;
			List<Device.UdiCarrierComponent> g_ = a?.UdiCarrier;
			Code<Device.FHIRDeviceStatus> h_ = a?.StatusElement;
			List<CodeableConcept> i_ = a?.StatusReason;
			FhirString j_ = a?.DistinctIdentifierElement;
			FhirString k_ = a?.ManufacturerElement;
			FhirDateTime l_ = a?.ManufactureDateElement;
			FhirDateTime m_ = a?.ExpirationDateElement;
			FhirString n_ = a?.LotNumberElement;
			FhirString o_ = a?.SerialNumberElement;
			List<Device.DeviceNameComponent> p_ = a?.DeviceName;
			FhirString q_ = a?.ModelNumberElement;
			FhirString r_ = a?.PartNumberElement;
			CodeableConcept s_ = a?.Type;
			List<Device.SpecializationComponent> t_ = a?.Specialization;
			List<Device.VersionComponent> u_ = a?.Version;
			List<Device.PropertyComponent> v_ = a?.Property;
			ResourceReference w_ = a?.Patient;
			ResourceReference x_ = a?.Owner;
			List<ContactPoint> y_ = a?.Contact;
			ResourceReference z_ = a?.Location;
			FhirUri aa_ = a?.UrlElement;
			List<Annotation> ab_ = a?.Note;
			List<CodeableConcept> ac_ = a?.Safety;
			ResourceReference ad_ = a?.Parent;
			Device ae_ = new Device
			{
				Identifier = new List<Identifier>((IEnumerable<Identifier>)e_),
				Definition = f_,
				UdiCarrier = new List<Device.UdiCarrierComponent>((IEnumerable<Device.UdiCarrierComponent>)g_),
				StatusElement = h_,
				StatusReason = new List<CodeableConcept>((IEnumerable<CodeableConcept>)i_),
				DistinctIdentifierElement = j_,
				ManufacturerElement = k_,
				ManufactureDateElement = l_,
				ExpirationDateElement = m_,
				LotNumberElement = n_,
				SerialNumberElement = o_,
				DeviceName = new List<Device.DeviceNameComponent>((IEnumerable<Device.DeviceNameComponent>)p_),
				ModelNumberElement = q_,
				PartNumberElement = r_,
				Type = s_,
				Specialization = new List<Device.SpecializationComponent>((IEnumerable<Device.SpecializationComponent>)t_),
				Version = new List<Device.VersionComponent>((IEnumerable<Device.VersionComponent>)u_),
				Property = new List<Device.PropertyComponent>((IEnumerable<Device.PropertyComponent>)v_),
				Patient = w_,
				Owner = x_,
				Contact = new List<ContactPoint>((IEnumerable<ContactPoint>)y_),
				Location = z_,
				UrlElement = aa_,
				Note = new List<Annotation>((IEnumerable<Annotation>)ab_),
				Safety = new List<CodeableConcept>((IEnumerable<CodeableConcept>)ac_),
				Parent = ad_,
			};

			return ae_;
		};
		IEnumerable<Device> c_ = context.Operators.Select<Device, Device>((IEnumerable<Device>)a_, b_);
		Device d_ = context.Operators.SingletonFrom<Device>(c_);

		return d_;
	}

    [CqlDeclaration("DeviceDefinitionResource")]
	public DeviceDefinition DeviceDefinitionResource(DeviceDefinition arg)
	{
		DeviceDefinition[] a_ = [
			arg,
		];
		DeviceDefinition b_(DeviceDefinition a)
		{
			List<Identifier> e_ = a?.Identifier;
			List<DeviceDefinition.UdiDeviceIdentifierComponent> f_ = a?.UdiDeviceIdentifier;
			DataType g_ = a?.Manufacturer;
			List<DeviceDefinition.DeviceNameComponent> h_ = a?.DeviceName;
			FhirString i_ = a?.ModelNumberElement;
			CodeableConcept j_ = a?.Type;
			List<DeviceDefinition.SpecializationComponent> k_ = a?.Specialization;
			List<FhirString> l_ = a?.VersionElement;
			List<CodeableConcept> m_ = a?.Safety;
			List<ProductShelfLife> n_ = a?.ShelfLifeStorage;
			ProdCharacteristic o_ = a?.PhysicalCharacteristics;
			List<CodeableConcept> p_ = a?.LanguageCode;
			List<DeviceDefinition.CapabilityComponent> q_ = a?.Capability;
			List<DeviceDefinition.PropertyComponent> r_ = a?.Property;
			ResourceReference s_ = a?.Owner;
			List<ContactPoint> t_ = a?.Contact;
			FhirUri u_ = a?.UrlElement;
			FhirUri v_ = a?.OnlineInformationElement;
			List<Annotation> w_ = a?.Note;
			Quantity x_ = a?.Quantity;
			ResourceReference y_ = a?.ParentDevice;
			List<DeviceDefinition.MaterialComponent> z_ = a?.Material;
			DeviceDefinition aa_ = new DeviceDefinition
			{
				Identifier = new List<Identifier>((IEnumerable<Identifier>)e_),
				UdiDeviceIdentifier = new List<DeviceDefinition.UdiDeviceIdentifierComponent>((IEnumerable<DeviceDefinition.UdiDeviceIdentifierComponent>)f_),
				Manufacturer = (DataType)g_,
				DeviceName = new List<DeviceDefinition.DeviceNameComponent>((IEnumerable<DeviceDefinition.DeviceNameComponent>)h_),
				ModelNumberElement = i_,
				Type = j_,
				Specialization = new List<DeviceDefinition.SpecializationComponent>((IEnumerable<DeviceDefinition.SpecializationComponent>)k_),
				VersionElement = new List<FhirString>((IEnumerable<FhirString>)l_),
				Safety = new List<CodeableConcept>((IEnumerable<CodeableConcept>)m_),
				ShelfLifeStorage = new List<ProductShelfLife>((IEnumerable<ProductShelfLife>)n_),
				PhysicalCharacteristics = o_,
				LanguageCode = new List<CodeableConcept>((IEnumerable<CodeableConcept>)p_),
				Capability = new List<DeviceDefinition.CapabilityComponent>((IEnumerable<DeviceDefinition.CapabilityComponent>)q_),
				Property = new List<DeviceDefinition.PropertyComponent>((IEnumerable<DeviceDefinition.PropertyComponent>)r_),
				Owner = s_,
				Contact = new List<ContactPoint>((IEnumerable<ContactPoint>)t_),
				UrlElement = u_,
				OnlineInformationElement = v_,
				Note = new List<Annotation>((IEnumerable<Annotation>)w_),
				Quantity = x_,
				ParentDevice = y_,
				Material = new List<DeviceDefinition.MaterialComponent>((IEnumerable<DeviceDefinition.MaterialComponent>)z_),
			};

			return aa_;
		};
		IEnumerable<DeviceDefinition> c_ = context.Operators.Select<DeviceDefinition, DeviceDefinition>((IEnumerable<DeviceDefinition>)a_, b_);
		DeviceDefinition d_ = context.Operators.SingletonFrom<DeviceDefinition>(c_);

		return d_;
	}

    [CqlDeclaration("DeviceMetricResource")]
	public DeviceMetric DeviceMetricResource(DeviceMetric arg)
	{
		DeviceMetric[] a_ = [
			arg,
		];
		DeviceMetric b_(DeviceMetric a)
		{
			List<Identifier> e_ = a?.Identifier;
			CodeableConcept f_ = a?.Type;
			CodeableConcept g_ = a?.Unit;
			ResourceReference h_ = a?.Source;
			ResourceReference i_ = a?.Parent;
			Code<DeviceMetric.DeviceMetricOperationalStatus> j_ = a?.OperationalStatusElement;
			Code<DeviceMetric.DeviceMetricColor> k_ = a?.ColorElement;
			Code<DeviceMetric.DeviceMetricCategory> l_ = a?.CategoryElement;
			Timing m_ = a?.MeasurementPeriod;
			List<DeviceMetric.CalibrationComponent> n_ = a?.Calibration;
			DeviceMetric o_ = new DeviceMetric
			{
				Identifier = new List<Identifier>((IEnumerable<Identifier>)e_),
				Type = f_,
				Unit = g_,
				Source = h_,
				Parent = i_,
				OperationalStatusElement = j_,
				ColorElement = k_,
				CategoryElement = l_,
				MeasurementPeriod = m_,
				Calibration = new List<DeviceMetric.CalibrationComponent>((IEnumerable<DeviceMetric.CalibrationComponent>)n_),
			};

			return o_;
		};
		IEnumerable<DeviceMetric> c_ = context.Operators.Select<DeviceMetric, DeviceMetric>((IEnumerable<DeviceMetric>)a_, b_);
		DeviceMetric d_ = context.Operators.SingletonFrom<DeviceMetric>(c_);

		return d_;
	}

    [CqlDeclaration("DeviceRequestResource")]
	public DeviceRequest DeviceRequestResource(DeviceRequest arg)
	{
		DeviceRequest[] a_ = [
			arg,
		];
		DeviceRequest b_(DeviceRequest a)
		{
			List<Identifier> e_ = a?.Identifier;
			List<Canonical> f_ = a?.InstantiatesCanonicalElement;
			List<FhirUri> g_ = a?.InstantiatesUriElement;
			List<ResourceReference> h_ = a?.BasedOn;
			List<ResourceReference> i_ = a?.PriorRequest;
			Identifier j_ = a?.GroupIdentifier;
			Code<RequestStatus> k_ = a?.StatusElement;
			Code<RequestIntent> l_ = a?.IntentElement;
			Code<RequestPriority> m_ = a?.PriorityElement;
			DataType n_ = a?.Code;
			List<DeviceRequest.ParameterComponent> o_ = a?.Parameter;
			ResourceReference p_ = a?.Subject;
			ResourceReference q_ = a?.Encounter;
			DataType r_ = a?.Occurrence;
			FhirDateTime s_ = a?.AuthoredOnElement;
			ResourceReference t_ = a?.Requester;
			CodeableConcept u_ = a?.PerformerType;
			ResourceReference v_ = a?.Performer;
			List<CodeableConcept> w_ = a?.ReasonCode;
			List<ResourceReference> x_ = a?.ReasonReference;
			List<ResourceReference> y_ = a?.Insurance;
			List<ResourceReference> z_ = a?.SupportingInfo;
			List<Annotation> aa_ = a?.Note;
			List<ResourceReference> ab_ = a?.RelevantHistory;
			DeviceRequest ac_ = new DeviceRequest
			{
				Identifier = new List<Identifier>((IEnumerable<Identifier>)e_),
				InstantiatesCanonicalElement = new List<Canonical>((IEnumerable<Canonical>)f_),
				InstantiatesUriElement = new List<FhirUri>((IEnumerable<FhirUri>)g_),
				BasedOn = new List<ResourceReference>((IEnumerable<ResourceReference>)h_),
				PriorRequest = new List<ResourceReference>((IEnumerable<ResourceReference>)i_),
				GroupIdentifier = j_,
				StatusElement = k_,
				IntentElement = l_,
				PriorityElement = m_,
				Code = (DataType)n_,
				Parameter = new List<DeviceRequest.ParameterComponent>((IEnumerable<DeviceRequest.ParameterComponent>)o_),
				Subject = p_,
				Encounter = q_,
				Occurrence = (DataType)r_,
				AuthoredOnElement = s_,
				Requester = t_,
				PerformerType = u_,
				Performer = v_,
				ReasonCode = new List<CodeableConcept>((IEnumerable<CodeableConcept>)w_),
				ReasonReference = new List<ResourceReference>((IEnumerable<ResourceReference>)x_),
				Insurance = new List<ResourceReference>((IEnumerable<ResourceReference>)y_),
				SupportingInfo = new List<ResourceReference>((IEnumerable<ResourceReference>)z_),
				Note = new List<Annotation>((IEnumerable<Annotation>)aa_),
				RelevantHistory = new List<ResourceReference>((IEnumerable<ResourceReference>)ab_),
			};

			return ac_;
		};
		IEnumerable<DeviceRequest> c_ = context.Operators.Select<DeviceRequest, DeviceRequest>((IEnumerable<DeviceRequest>)a_, b_);
		DeviceRequest d_ = context.Operators.SingletonFrom<DeviceRequest>(c_);

		return d_;
	}

    [CqlDeclaration("DeviceUseStatementResource")]
	public DeviceUseStatement DeviceUseStatementResource(DeviceUseStatement arg)
	{
		DeviceUseStatement[] a_ = [
			arg,
		];
		DeviceUseStatement b_(DeviceUseStatement a)
		{
			List<Identifier> e_ = a?.Identifier;
			List<ResourceReference> f_ = a?.BasedOn;
			Code<DeviceUseStatement.DeviceUseStatementStatus> g_ = a?.StatusElement;
			ResourceReference h_ = a?.Subject;
			List<ResourceReference> i_ = a?.DerivedFrom;
			DataType j_ = a?.Timing;
			FhirDateTime k_ = a?.RecordedOnElement;
			ResourceReference l_ = a?.Source;
			ResourceReference m_ = a?.Device;
			List<CodeableConcept> n_ = a?.ReasonCode;
			List<ResourceReference> o_ = a?.ReasonReference;
			CodeableConcept p_ = a?.BodySite;
			List<Annotation> q_ = a?.Note;
			DeviceUseStatement r_ = new DeviceUseStatement
			{
				Identifier = new List<Identifier>((IEnumerable<Identifier>)e_),
				BasedOn = new List<ResourceReference>((IEnumerable<ResourceReference>)f_),
				StatusElement = g_,
				Subject = h_,
				DerivedFrom = new List<ResourceReference>((IEnumerable<ResourceReference>)i_),
				Timing = (DataType)j_,
				RecordedOnElement = k_,
				Source = l_,
				Device = m_,
				ReasonCode = new List<CodeableConcept>((IEnumerable<CodeableConcept>)n_),
				ReasonReference = new List<ResourceReference>((IEnumerable<ResourceReference>)o_),
				BodySite = p_,
				Note = new List<Annotation>((IEnumerable<Annotation>)q_),
			};

			return r_;
		};
		IEnumerable<DeviceUseStatement> c_ = context.Operators.Select<DeviceUseStatement, DeviceUseStatement>((IEnumerable<DeviceUseStatement>)a_, b_);
		DeviceUseStatement d_ = context.Operators.SingletonFrom<DeviceUseStatement>(c_);

		return d_;
	}

    [CqlDeclaration("DiagnosticReportResource")]
	public DiagnosticReport DiagnosticReportResource(DiagnosticReport arg)
	{
		DiagnosticReport[] a_ = [
			arg,
		];
		DiagnosticReport b_(DiagnosticReport a)
		{
			List<Identifier> e_ = a?.Identifier;
			List<ResourceReference> f_ = a?.BasedOn;
			Code<DiagnosticReport.DiagnosticReportStatus> g_ = a?.StatusElement;
			List<CodeableConcept> h_ = a?.Category;
			CodeableConcept i_ = a?.Code;
			ResourceReference j_ = a?.Subject;
			ResourceReference k_ = a?.Encounter;
			DataType l_ = a?.Effective;
			Instant m_ = a?.IssuedElement;
			List<ResourceReference> n_ = a?.Performer;
			List<ResourceReference> o_ = a?.ResultsInterpreter;
			List<ResourceReference> p_ = a?.Specimen;
			List<ResourceReference> q_ = a?.Result;
			List<ResourceReference> r_ = a?.ImagingStudy;
			List<DiagnosticReport.MediaComponent> s_ = a?.Media;
			FhirString t_ = a?.ConclusionElement;
			List<CodeableConcept> u_ = a?.ConclusionCode;
			List<Attachment> v_ = a?.PresentedForm;
			DiagnosticReport w_ = new DiagnosticReport
			{
				Identifier = new List<Identifier>((IEnumerable<Identifier>)e_),
				BasedOn = new List<ResourceReference>((IEnumerable<ResourceReference>)f_),
				StatusElement = g_,
				Category = new List<CodeableConcept>((IEnumerable<CodeableConcept>)h_),
				Code = i_,
				Subject = j_,
				Encounter = k_,
				Effective = (DataType)l_,
				IssuedElement = m_,
				Performer = new List<ResourceReference>((IEnumerable<ResourceReference>)n_),
				ResultsInterpreter = new List<ResourceReference>((IEnumerable<ResourceReference>)o_),
				Specimen = new List<ResourceReference>((IEnumerable<ResourceReference>)p_),
				Result = new List<ResourceReference>((IEnumerable<ResourceReference>)q_),
				ImagingStudy = new List<ResourceReference>((IEnumerable<ResourceReference>)r_),
				Media = new List<DiagnosticReport.MediaComponent>((IEnumerable<DiagnosticReport.MediaComponent>)s_),
				ConclusionElement = t_,
				ConclusionCode = new List<CodeableConcept>((IEnumerable<CodeableConcept>)u_),
				PresentedForm = new List<Attachment>((IEnumerable<Attachment>)v_),
			};

			return w_;
		};
		IEnumerable<DiagnosticReport> c_ = context.Operators.Select<DiagnosticReport, DiagnosticReport>((IEnumerable<DiagnosticReport>)a_, b_);
		DiagnosticReport d_ = context.Operators.SingletonFrom<DiagnosticReport>(c_);

		return d_;
	}

    [CqlDeclaration("DocumentManifestResource")]
	public DocumentManifest DocumentManifestResource(DocumentManifest arg)
	{
		DocumentManifest[] a_ = [
			arg,
		];
		DocumentManifest b_(DocumentManifest a)
		{
			Identifier e_ = a?.MasterIdentifier;
			List<Identifier> f_ = a?.Identifier;
			Code<DocumentReferenceStatus> g_ = a?.StatusElement;
			CodeableConcept h_ = a?.Type;
			ResourceReference i_ = a?.Subject;
			FhirDateTime j_ = a?.CreatedElement;
			List<ResourceReference> k_ = a?.Author;
			List<ResourceReference> l_ = a?.Recipient;
			FhirUri m_ = a?.SourceElement;
			FhirString n_ = a?.DescriptionElement;
			List<ResourceReference> o_ = a?.Content;
			List<DocumentManifest.RelatedComponent> p_ = a?.Related;
			DocumentManifest q_ = new DocumentManifest
			{
				MasterIdentifier = e_,
				Identifier = new List<Identifier>((IEnumerable<Identifier>)f_),
				StatusElement = g_,
				Type = h_,
				Subject = i_,
				CreatedElement = j_,
				Author = new List<ResourceReference>((IEnumerable<ResourceReference>)k_),
				Recipient = new List<ResourceReference>((IEnumerable<ResourceReference>)l_),
				SourceElement = m_,
				DescriptionElement = n_,
				Content = new List<ResourceReference>((IEnumerable<ResourceReference>)o_),
				Related = new List<DocumentManifest.RelatedComponent>((IEnumerable<DocumentManifest.RelatedComponent>)p_),
			};

			return q_;
		};
		IEnumerable<DocumentManifest> c_ = context.Operators.Select<DocumentManifest, DocumentManifest>((IEnumerable<DocumentManifest>)a_, b_);
		DocumentManifest d_ = context.Operators.SingletonFrom<DocumentManifest>(c_);

		return d_;
	}

    [CqlDeclaration("DocumentReferenceResource")]
	public DocumentReference DocumentReferenceResource(DocumentReference arg)
	{
		DocumentReference[] a_ = [
			arg,
		];
		DocumentReference b_(DocumentReference a)
		{
			Identifier e_ = a?.MasterIdentifier;
			List<Identifier> f_ = a?.Identifier;
			Code<DocumentReferenceStatus> g_ = a?.StatusElement;
			Code<CompositionStatus> h_ = a?.DocStatusElement;
			CodeableConcept i_ = a?.Type;
			List<CodeableConcept> j_ = a?.Category;
			ResourceReference k_ = a?.Subject;
			Instant l_ = a?.DateElement;
			List<ResourceReference> m_ = a?.Author;
			ResourceReference n_ = a?.Authenticator;
			ResourceReference o_ = a?.Custodian;
			List<DocumentReference.RelatesToComponent> p_ = a?.RelatesTo;
			FhirString q_ = a?.DescriptionElement;
			List<CodeableConcept> r_ = a?.SecurityLabel;
			List<DocumentReference.ContentComponent> s_ = a?.Content;
			DocumentReference.ContextComponent t_ = a?.Context;
			DocumentReference u_ = new DocumentReference
			{
				MasterIdentifier = e_,
				Identifier = new List<Identifier>((IEnumerable<Identifier>)f_),
				StatusElement = g_,
				DocStatusElement = h_,
				Type = i_,
				Category = new List<CodeableConcept>((IEnumerable<CodeableConcept>)j_),
				Subject = k_,
				DateElement = l_,
				Author = new List<ResourceReference>((IEnumerable<ResourceReference>)m_),
				Authenticator = n_,
				Custodian = o_,
				RelatesTo = new List<DocumentReference.RelatesToComponent>((IEnumerable<DocumentReference.RelatesToComponent>)p_),
				DescriptionElement = q_,
				SecurityLabel = new List<CodeableConcept>((IEnumerable<CodeableConcept>)r_),
				Content = new List<DocumentReference.ContentComponent>((IEnumerable<DocumentReference.ContentComponent>)s_),
				Context = t_,
			};

			return u_;
		};
		IEnumerable<DocumentReference> c_ = context.Operators.Select<DocumentReference, DocumentReference>((IEnumerable<DocumentReference>)a_, b_);
		DocumentReference d_ = context.Operators.SingletonFrom<DocumentReference>(c_);

		return d_;
	}

    [CqlDeclaration("EffectEvidenceSynthesisResource")]
	public EffectEvidenceSynthesis EffectEvidenceSynthesisResource(EffectEvidenceSynthesis arg)
	{
		EffectEvidenceSynthesis[] a_ = [
			arg,
		];
		EffectEvidenceSynthesis b_(EffectEvidenceSynthesis a)
		{
			FhirUri e_ = a?.UrlElement;
			List<Identifier> f_ = a?.Identifier;
			FhirString g_ = a?.VersionElement;
			FhirString h_ = a?.NameElement;
			FhirString i_ = a?.TitleElement;
			Code<PublicationStatus> j_ = a?.StatusElement;
			FhirDateTime k_ = a?.DateElement;
			FhirString l_ = a?.PublisherElement;
			List<ContactDetail> m_ = a?.Contact;
			Markdown n_ = a?.DescriptionElement;
			List<Annotation> o_ = a?.Note;
			List<UsageContext> p_ = a?.UseContext;
			List<CodeableConcept> q_ = a?.Jurisdiction;
			Markdown r_ = a?.CopyrightElement;
			Date s_ = a?.ApprovalDateElement;
			Date t_ = a?.LastReviewDateElement;
			Period u_ = a?.EffectivePeriod;
			List<CodeableConcept> v_ = a?.Topic;
			List<ContactDetail> w_ = a?.Author;
			List<ContactDetail> x_ = a?.Editor;
			List<ContactDetail> y_ = a?.Reviewer;
			List<ContactDetail> z_ = a?.Endorser;
			List<RelatedArtifact> aa_ = a?.RelatedArtifact;
			CodeableConcept ab_ = a?.SynthesisType;
			CodeableConcept ac_ = a?.StudyType;
			ResourceReference ad_ = a?.Population;
			ResourceReference ae_ = a?.Exposure;
			ResourceReference af_ = a?.ExposureAlternative;
			ResourceReference ag_ = a?.Outcome;
			EffectEvidenceSynthesis.SampleSizeComponent ah_ = a?.SampleSize;
			List<EffectEvidenceSynthesis.ResultsByExposureComponent> ai_ = a?.ResultsByExposure;
			List<EffectEvidenceSynthesis.EffectEstimateComponent> aj_ = a?.EffectEstimate;
			List<EffectEvidenceSynthesis.CertaintyComponent> ak_ = a?.Certainty;
			EffectEvidenceSynthesis al_ = new EffectEvidenceSynthesis
			{
				UrlElement = e_,
				Identifier = new List<Identifier>((IEnumerable<Identifier>)f_),
				VersionElement = g_,
				NameElement = h_,
				TitleElement = i_,
				StatusElement = j_,
				DateElement = k_,
				PublisherElement = l_,
				Contact = new List<ContactDetail>((IEnumerable<ContactDetail>)m_),
				DescriptionElement = n_,
				Note = new List<Annotation>((IEnumerable<Annotation>)o_),
				UseContext = new List<UsageContext>((IEnumerable<UsageContext>)p_),
				Jurisdiction = new List<CodeableConcept>((IEnumerable<CodeableConcept>)q_),
				CopyrightElement = r_,
				ApprovalDateElement = s_,
				LastReviewDateElement = t_,
				EffectivePeriod = u_,
				Topic = new List<CodeableConcept>((IEnumerable<CodeableConcept>)v_),
				Author = new List<ContactDetail>((IEnumerable<ContactDetail>)w_),
				Editor = new List<ContactDetail>((IEnumerable<ContactDetail>)x_),
				Reviewer = new List<ContactDetail>((IEnumerable<ContactDetail>)y_),
				Endorser = new List<ContactDetail>((IEnumerable<ContactDetail>)z_),
				RelatedArtifact = new List<RelatedArtifact>((IEnumerable<RelatedArtifact>)aa_),
				SynthesisType = ab_,
				StudyType = ac_,
				Population = ad_,
				Exposure = ae_,
				ExposureAlternative = af_,
				Outcome = ag_,
				SampleSize = ah_,
				ResultsByExposure = new List<EffectEvidenceSynthesis.ResultsByExposureComponent>((IEnumerable<EffectEvidenceSynthesis.ResultsByExposureComponent>)ai_),
				EffectEstimate = new List<EffectEvidenceSynthesis.EffectEstimateComponent>((IEnumerable<EffectEvidenceSynthesis.EffectEstimateComponent>)aj_),
				Certainty = new List<EffectEvidenceSynthesis.CertaintyComponent>((IEnumerable<EffectEvidenceSynthesis.CertaintyComponent>)ak_),
			};

			return al_;
		};
		IEnumerable<EffectEvidenceSynthesis> c_ = context.Operators.Select<EffectEvidenceSynthesis, EffectEvidenceSynthesis>((IEnumerable<EffectEvidenceSynthesis>)a_, b_);
		EffectEvidenceSynthesis d_ = context.Operators.SingletonFrom<EffectEvidenceSynthesis>(c_);

		return d_;
	}

    [CqlDeclaration("EncounterResource")]
	public Encounter EncounterResource(Encounter arg)
	{
		Encounter[] a_ = [
			arg,
		];
		Encounter b_(Encounter a)
		{
			List<Identifier> e_ = a?.Identifier;
			Code<Encounter.EncounterStatus> f_ = a?.StatusElement;
			List<Encounter.StatusHistoryComponent> g_ = a?.StatusHistory;
			Coding h_ = a?.Class;
			List<Encounter.ClassHistoryComponent> i_ = a?.ClassHistory;
			List<CodeableConcept> j_ = a?.Type;
			CodeableConcept k_ = a?.ServiceType;
			CodeableConcept l_ = a?.Priority;
			ResourceReference m_ = a?.Subject;
			List<ResourceReference> n_ = a?.EpisodeOfCare;
			List<ResourceReference> o_ = a?.BasedOn;
			List<Encounter.ParticipantComponent> p_ = a?.Participant;
			List<ResourceReference> q_ = a?.Appointment;
			Period r_ = a?.Period;
			Duration s_ = a?.Length;
			List<CodeableConcept> t_ = a?.ReasonCode;
			List<ResourceReference> u_ = a?.ReasonReference;
			List<Encounter.DiagnosisComponent> v_ = a?.Diagnosis;
			List<ResourceReference> w_ = a?.Account;
			Encounter.HospitalizationComponent x_ = a?.Hospitalization;
			List<Encounter.LocationComponent> y_ = a?.Location;
			ResourceReference z_ = a?.ServiceProvider;
			ResourceReference aa_ = a?.PartOf;
			Encounter ab_ = new Encounter
			{
				Identifier = new List<Identifier>((IEnumerable<Identifier>)e_),
				StatusElement = f_,
				StatusHistory = new List<Encounter.StatusHistoryComponent>((IEnumerable<Encounter.StatusHistoryComponent>)g_),
				Class = h_,
				ClassHistory = new List<Encounter.ClassHistoryComponent>((IEnumerable<Encounter.ClassHistoryComponent>)i_),
				Type = new List<CodeableConcept>((IEnumerable<CodeableConcept>)j_),
				ServiceType = k_,
				Priority = l_,
				Subject = m_,
				EpisodeOfCare = new List<ResourceReference>((IEnumerable<ResourceReference>)n_),
				BasedOn = new List<ResourceReference>((IEnumerable<ResourceReference>)o_),
				Participant = new List<Encounter.ParticipantComponent>((IEnumerable<Encounter.ParticipantComponent>)p_),
				Appointment = new List<ResourceReference>((IEnumerable<ResourceReference>)q_),
				Period = r_,
				Length = s_,
				ReasonCode = new List<CodeableConcept>((IEnumerable<CodeableConcept>)t_),
				ReasonReference = new List<ResourceReference>((IEnumerable<ResourceReference>)u_),
				Diagnosis = new List<Encounter.DiagnosisComponent>((IEnumerable<Encounter.DiagnosisComponent>)v_),
				Account = new List<ResourceReference>((IEnumerable<ResourceReference>)w_),
				Hospitalization = x_,
				Location = new List<Encounter.LocationComponent>((IEnumerable<Encounter.LocationComponent>)y_),
				ServiceProvider = z_,
				PartOf = aa_,
			};

			return ab_;
		};
		IEnumerable<Encounter> c_ = context.Operators.Select<Encounter, Encounter>((IEnumerable<Encounter>)a_, b_);
		Encounter d_ = context.Operators.SingletonFrom<Encounter>(c_);

		return d_;
	}

    [CqlDeclaration("EndpointResource")]
	public Endpoint EndpointResource(Endpoint arg)
	{
		Endpoint[] a_ = [
			arg,
		];
		Endpoint b_(Endpoint a)
		{
			List<Identifier> e_ = a?.Identifier;
			Code<Endpoint.EndpointStatus> f_ = a?.StatusElement;
			Coding g_ = a?.ConnectionType;
			FhirString h_ = a?.NameElement;
			ResourceReference i_ = a?.ManagingOrganization;
			List<ContactPoint> j_ = a?.Contact;
			Period k_ = a?.Period;
			List<CodeableConcept> l_ = a?.PayloadType;
			List<Code> m_ = a?.PayloadMimeTypeElement;
			FhirUrl n_ = a?.AddressElement;
			List<FhirString> o_ = a?.HeaderElement;
			Endpoint p_ = new Endpoint
			{
				Identifier = new List<Identifier>((IEnumerable<Identifier>)e_),
				StatusElement = f_,
				ConnectionType = g_,
				NameElement = h_,
				ManagingOrganization = i_,
				Contact = new List<ContactPoint>((IEnumerable<ContactPoint>)j_),
				Period = k_,
				PayloadType = new List<CodeableConcept>((IEnumerable<CodeableConcept>)l_),
				PayloadMimeTypeElement = new List<Code>((IEnumerable<Code>)m_),
				AddressElement = n_,
				HeaderElement = new List<FhirString>((IEnumerable<FhirString>)o_),
			};

			return p_;
		};
		IEnumerable<Endpoint> c_ = context.Operators.Select<Endpoint, Endpoint>((IEnumerable<Endpoint>)a_, b_);
		Endpoint d_ = context.Operators.SingletonFrom<Endpoint>(c_);

		return d_;
	}

    [CqlDeclaration("EnrollmentRequestResource")]
	public EnrollmentRequest EnrollmentRequestResource(EnrollmentRequest arg)
	{
		EnrollmentRequest[] a_ = [
			arg,
		];
		EnrollmentRequest b_(EnrollmentRequest a)
		{
			List<Identifier> e_ = a?.Identifier;
			Code<FinancialResourceStatusCodes> f_ = a?.StatusElement;
			FhirDateTime g_ = a?.CreatedElement;
			ResourceReference h_ = a?.Insurer;
			ResourceReference i_ = a?.Provider;
			ResourceReference j_ = a?.Candidate;
			ResourceReference k_ = a?.Coverage;
			EnrollmentRequest l_ = new EnrollmentRequest
			{
				Identifier = new List<Identifier>((IEnumerable<Identifier>)e_),
				StatusElement = f_,
				CreatedElement = g_,
				Insurer = h_,
				Provider = i_,
				Candidate = j_,
				Coverage = k_,
			};

			return l_;
		};
		IEnumerable<EnrollmentRequest> c_ = context.Operators.Select<EnrollmentRequest, EnrollmentRequest>((IEnumerable<EnrollmentRequest>)a_, b_);
		EnrollmentRequest d_ = context.Operators.SingletonFrom<EnrollmentRequest>(c_);

		return d_;
	}

    [CqlDeclaration("EnrollmentResponseResource")]
	public EnrollmentResponse EnrollmentResponseResource(EnrollmentResponse arg)
	{
		EnrollmentResponse[] a_ = [
			arg,
		];
		EnrollmentResponse b_(EnrollmentResponse a)
		{
			List<Identifier> e_ = a?.Identifier;
			Code<FinancialResourceStatusCodes> f_ = a?.StatusElement;
			ResourceReference g_ = a?.Request;
			Code<ClaimProcessingCodes> h_ = a?.OutcomeElement;
			FhirString i_ = a?.DispositionElement;
			FhirDateTime j_ = a?.CreatedElement;
			ResourceReference k_ = a?.Organization;
			ResourceReference l_ = a?.RequestProvider;
			EnrollmentResponse m_ = new EnrollmentResponse
			{
				Identifier = new List<Identifier>((IEnumerable<Identifier>)e_),
				StatusElement = f_,
				Request = g_,
				OutcomeElement = h_,
				DispositionElement = i_,
				CreatedElement = j_,
				Organization = k_,
				RequestProvider = l_,
			};

			return m_;
		};
		IEnumerable<EnrollmentResponse> c_ = context.Operators.Select<EnrollmentResponse, EnrollmentResponse>((IEnumerable<EnrollmentResponse>)a_, b_);
		EnrollmentResponse d_ = context.Operators.SingletonFrom<EnrollmentResponse>(c_);

		return d_;
	}

    [CqlDeclaration("EpisodeOfCareResource")]
	public EpisodeOfCare EpisodeOfCareResource(EpisodeOfCare arg)
	{
		EpisodeOfCare[] a_ = [
			arg,
		];
		EpisodeOfCare b_(EpisodeOfCare a)
		{
			List<Identifier> e_ = a?.Identifier;
			Code<EpisodeOfCare.EpisodeOfCareStatus> f_ = a?.StatusElement;
			List<EpisodeOfCare.StatusHistoryComponent> g_ = a?.StatusHistory;
			List<CodeableConcept> h_ = a?.Type;
			List<EpisodeOfCare.DiagnosisComponent> i_ = a?.Diagnosis;
			ResourceReference j_ = a?.Patient;
			ResourceReference k_ = a?.ManagingOrganization;
			Period l_ = a?.Period;
			List<ResourceReference> m_ = a?.ReferralRequest;
			ResourceReference n_ = a?.CareManager;
			List<ResourceReference> o_ = a?.Team;
			List<ResourceReference> p_ = a?.Account;
			EpisodeOfCare q_ = new EpisodeOfCare
			{
				Identifier = new List<Identifier>((IEnumerable<Identifier>)e_),
				StatusElement = f_,
				StatusHistory = new List<EpisodeOfCare.StatusHistoryComponent>((IEnumerable<EpisodeOfCare.StatusHistoryComponent>)g_),
				Type = new List<CodeableConcept>((IEnumerable<CodeableConcept>)h_),
				Diagnosis = new List<EpisodeOfCare.DiagnosisComponent>((IEnumerable<EpisodeOfCare.DiagnosisComponent>)i_),
				Patient = j_,
				ManagingOrganization = k_,
				Period = l_,
				ReferralRequest = new List<ResourceReference>((IEnumerable<ResourceReference>)m_),
				CareManager = n_,
				Team = new List<ResourceReference>((IEnumerable<ResourceReference>)o_),
				Account = new List<ResourceReference>((IEnumerable<ResourceReference>)p_),
			};

			return q_;
		};
		IEnumerable<EpisodeOfCare> c_ = context.Operators.Select<EpisodeOfCare, EpisodeOfCare>((IEnumerable<EpisodeOfCare>)a_, b_);
		EpisodeOfCare d_ = context.Operators.SingletonFrom<EpisodeOfCare>(c_);

		return d_;
	}

    [CqlDeclaration("EventDefinitionResource")]
	public EventDefinition EventDefinitionResource(EventDefinition arg)
	{
		EventDefinition[] a_ = [
			arg,
		];
		EventDefinition b_(EventDefinition a)
		{
			FhirUri e_ = a?.UrlElement;
			List<Identifier> f_ = a?.Identifier;
			FhirString g_ = a?.VersionElement;
			FhirString h_ = a?.NameElement;
			FhirString i_ = a?.TitleElement;
			FhirString j_ = a?.SubtitleElement;
			Code<PublicationStatus> k_ = a?.StatusElement;
			FhirBoolean l_ = a?.ExperimentalElement;
			DataType m_ = a?.Subject;
			FhirDateTime n_ = a?.DateElement;
			FhirString o_ = a?.PublisherElement;
			List<ContactDetail> p_ = a?.Contact;
			Markdown q_ = a?.DescriptionElement;
			List<UsageContext> r_ = a?.UseContext;
			List<CodeableConcept> s_ = a?.Jurisdiction;
			Markdown t_ = a?.PurposeElement;
			FhirString u_ = a?.UsageElement;
			Markdown v_ = a?.CopyrightElement;
			Date w_ = a?.ApprovalDateElement;
			Date x_ = a?.LastReviewDateElement;
			Period y_ = a?.EffectivePeriod;
			List<CodeableConcept> z_ = a?.Topic;
			List<ContactDetail> aa_ = a?.Author;
			List<ContactDetail> ab_ = a?.Editor;
			List<ContactDetail> ac_ = a?.Reviewer;
			List<ContactDetail> ad_ = a?.Endorser;
			List<RelatedArtifact> ae_ = a?.RelatedArtifact;
			List<TriggerDefinition> af_ = a?.Trigger;
			EventDefinition ag_ = new EventDefinition
			{
				UrlElement = e_,
				Identifier = new List<Identifier>((IEnumerable<Identifier>)f_),
				VersionElement = g_,
				NameElement = h_,
				TitleElement = i_,
				SubtitleElement = j_,
				StatusElement = k_,
				ExperimentalElement = l_,
				Subject = (DataType)m_,
				DateElement = n_,
				PublisherElement = o_,
				Contact = new List<ContactDetail>((IEnumerable<ContactDetail>)p_),
				DescriptionElement = q_,
				UseContext = new List<UsageContext>((IEnumerable<UsageContext>)r_),
				Jurisdiction = new List<CodeableConcept>((IEnumerable<CodeableConcept>)s_),
				PurposeElement = t_,
				UsageElement = u_,
				CopyrightElement = v_,
				ApprovalDateElement = w_,
				LastReviewDateElement = x_,
				EffectivePeriod = y_,
				Topic = new List<CodeableConcept>((IEnumerable<CodeableConcept>)z_),
				Author = new List<ContactDetail>((IEnumerable<ContactDetail>)aa_),
				Editor = new List<ContactDetail>((IEnumerable<ContactDetail>)ab_),
				Reviewer = new List<ContactDetail>((IEnumerable<ContactDetail>)ac_),
				Endorser = new List<ContactDetail>((IEnumerable<ContactDetail>)ad_),
				RelatedArtifact = new List<RelatedArtifact>((IEnumerable<RelatedArtifact>)ae_),
				Trigger = new List<TriggerDefinition>((IEnumerable<TriggerDefinition>)af_),
			};

			return ag_;
		};
		IEnumerable<EventDefinition> c_ = context.Operators.Select<EventDefinition, EventDefinition>((IEnumerable<EventDefinition>)a_, b_);
		EventDefinition d_ = context.Operators.SingletonFrom<EventDefinition>(c_);

		return d_;
	}

    [CqlDeclaration("EvidenceResource")]
	public Evidence EvidenceResource(Evidence arg)
	{
		Evidence[] a_ = [
			arg,
		];
		Evidence b_(Evidence a)
		{
			FhirUri e_ = a?.UrlElement;
			List<Identifier> f_ = a?.Identifier;
			FhirString g_ = a?.VersionElement;
			FhirString h_ = a?.NameElement;
			FhirString i_ = a?.TitleElement;
			FhirString j_ = a?.ShortTitleElement;
			FhirString k_ = a?.SubtitleElement;
			Code<PublicationStatus> l_ = a?.StatusElement;
			FhirDateTime m_ = a?.DateElement;
			FhirString n_ = a?.PublisherElement;
			List<ContactDetail> o_ = a?.Contact;
			Markdown p_ = a?.DescriptionElement;
			List<Annotation> q_ = a?.Note;
			List<UsageContext> r_ = a?.UseContext;
			List<CodeableConcept> s_ = a?.Jurisdiction;
			Markdown t_ = a?.CopyrightElement;
			Date u_ = a?.ApprovalDateElement;
			Date v_ = a?.LastReviewDateElement;
			Period w_ = a?.EffectivePeriod;
			List<CodeableConcept> x_ = a?.Topic;
			List<ContactDetail> y_ = a?.Author;
			List<ContactDetail> z_ = a?.Editor;
			List<ContactDetail> aa_ = a?.Reviewer;
			List<ContactDetail> ab_ = a?.Endorser;
			List<RelatedArtifact> ac_ = a?.RelatedArtifact;
			ResourceReference ad_ = a?.ExposureBackground;
			List<ResourceReference> ae_ = a?.ExposureVariant;
			List<ResourceReference> af_ = a?.Outcome;
			Evidence ag_ = new Evidence
			{
				UrlElement = e_,
				Identifier = new List<Identifier>((IEnumerable<Identifier>)f_),
				VersionElement = g_,
				NameElement = h_,
				TitleElement = i_,
				ShortTitleElement = j_,
				SubtitleElement = k_,
				StatusElement = l_,
				DateElement = m_,
				PublisherElement = n_,
				Contact = new List<ContactDetail>((IEnumerable<ContactDetail>)o_),
				DescriptionElement = p_,
				Note = new List<Annotation>((IEnumerable<Annotation>)q_),
				UseContext = new List<UsageContext>((IEnumerable<UsageContext>)r_),
				Jurisdiction = new List<CodeableConcept>((IEnumerable<CodeableConcept>)s_),
				CopyrightElement = t_,
				ApprovalDateElement = u_,
				LastReviewDateElement = v_,
				EffectivePeriod = w_,
				Topic = new List<CodeableConcept>((IEnumerable<CodeableConcept>)x_),
				Author = new List<ContactDetail>((IEnumerable<ContactDetail>)y_),
				Editor = new List<ContactDetail>((IEnumerable<ContactDetail>)z_),
				Reviewer = new List<ContactDetail>((IEnumerable<ContactDetail>)aa_),
				Endorser = new List<ContactDetail>((IEnumerable<ContactDetail>)ab_),
				RelatedArtifact = new List<RelatedArtifact>((IEnumerable<RelatedArtifact>)ac_),
				ExposureBackground = ad_,
				ExposureVariant = new List<ResourceReference>((IEnumerable<ResourceReference>)ae_),
				Outcome = new List<ResourceReference>((IEnumerable<ResourceReference>)af_),
			};

			return ag_;
		};
		IEnumerable<Evidence> c_ = context.Operators.Select<Evidence, Evidence>((IEnumerable<Evidence>)a_, b_);
		Evidence d_ = context.Operators.SingletonFrom<Evidence>(c_);

		return d_;
	}

    [CqlDeclaration("EvidenceVariableResource")]
	public EvidenceVariable EvidenceVariableResource(EvidenceVariable arg)
	{
		EvidenceVariable[] a_ = [
			arg,
		];
		EvidenceVariable b_(EvidenceVariable a)
		{
			FhirUri e_ = a?.UrlElement;
			List<Identifier> f_ = a?.Identifier;
			FhirString g_ = a?.VersionElement;
			FhirString h_ = a?.NameElement;
			FhirString i_ = a?.TitleElement;
			FhirString j_ = a?.ShortTitleElement;
			FhirString k_ = a?.SubtitleElement;
			Code<PublicationStatus> l_ = a?.StatusElement;
			FhirDateTime m_ = a?.DateElement;
			FhirString n_ = a?.PublisherElement;
			List<ContactDetail> o_ = a?.Contact;
			Markdown p_ = a?.DescriptionElement;
			List<Annotation> q_ = a?.Note;
			List<UsageContext> r_ = a?.UseContext;
			List<CodeableConcept> s_ = a?.Jurisdiction;
			Markdown t_ = a?.CopyrightElement;
			Date u_ = a?.ApprovalDateElement;
			Date v_ = a?.LastReviewDateElement;
			Period w_ = a?.EffectivePeriod;
			List<CodeableConcept> x_ = a?.Topic;
			List<ContactDetail> y_ = a?.Author;
			List<ContactDetail> z_ = a?.Editor;
			List<ContactDetail> aa_ = a?.Reviewer;
			List<ContactDetail> ab_ = a?.Endorser;
			List<RelatedArtifact> ac_ = a?.RelatedArtifact;
			Code<VariableTypeCode> ad_ = a?.TypeElement;
			List<EvidenceVariable.CharacteristicComponent> ae_ = a?.Characteristic;
			EvidenceVariable af_ = new EvidenceVariable
			{
				UrlElement = e_,
				Identifier = new List<Identifier>((IEnumerable<Identifier>)f_),
				VersionElement = g_,
				NameElement = h_,
				TitleElement = i_,
				ShortTitleElement = j_,
				SubtitleElement = k_,
				StatusElement = l_,
				DateElement = m_,
				PublisherElement = n_,
				Contact = new List<ContactDetail>((IEnumerable<ContactDetail>)o_),
				DescriptionElement = p_,
				Note = new List<Annotation>((IEnumerable<Annotation>)q_),
				UseContext = new List<UsageContext>((IEnumerable<UsageContext>)r_),
				Jurisdiction = new List<CodeableConcept>((IEnumerable<CodeableConcept>)s_),
				CopyrightElement = t_,
				ApprovalDateElement = u_,
				LastReviewDateElement = v_,
				EffectivePeriod = w_,
				Topic = new List<CodeableConcept>((IEnumerable<CodeableConcept>)x_),
				Author = new List<ContactDetail>((IEnumerable<ContactDetail>)y_),
				Editor = new List<ContactDetail>((IEnumerable<ContactDetail>)z_),
				Reviewer = new List<ContactDetail>((IEnumerable<ContactDetail>)aa_),
				Endorser = new List<ContactDetail>((IEnumerable<ContactDetail>)ab_),
				RelatedArtifact = new List<RelatedArtifact>((IEnumerable<RelatedArtifact>)ac_),
				TypeElement = ad_,
				Characteristic = new List<EvidenceVariable.CharacteristicComponent>((IEnumerable<EvidenceVariable.CharacteristicComponent>)ae_),
			};

			return af_;
		};
		IEnumerable<EvidenceVariable> c_ = context.Operators.Select<EvidenceVariable, EvidenceVariable>((IEnumerable<EvidenceVariable>)a_, b_);
		EvidenceVariable d_ = context.Operators.SingletonFrom<EvidenceVariable>(c_);

		return d_;
	}

    [CqlDeclaration("ExplanationOfBenefitResource")]
	public ExplanationOfBenefit ExplanationOfBenefitResource(ExplanationOfBenefit arg)
	{
		ExplanationOfBenefit[] a_ = [
			arg,
		];
		ExplanationOfBenefit b_(ExplanationOfBenefit a)
		{
			List<Identifier> e_ = a?.Identifier;
			Code<ExplanationOfBenefit.ExplanationOfBenefitStatus> f_ = a?.StatusElement;
			CodeableConcept g_ = a?.Type;
			CodeableConcept h_ = a?.SubType;
			Code<ClaimUseCode> i_ = a?.UseElement;
			ResourceReference j_ = a?.Patient;
			Period k_ = a?.BillablePeriod;
			FhirDateTime l_ = a?.CreatedElement;
			ResourceReference m_ = a?.Enterer;
			ResourceReference n_ = a?.Insurer;
			ResourceReference o_ = a?.Provider;
			CodeableConcept p_ = a?.Priority;
			CodeableConcept q_ = a?.FundsReserveRequested;
			CodeableConcept r_ = a?.FundsReserve;
			List<ExplanationOfBenefit.RelatedClaimComponent> s_ = a?.Related;
			ResourceReference t_ = a?.Prescription;
			ResourceReference u_ = a?.OriginalPrescription;
			ExplanationOfBenefit.PayeeComponent v_ = a?.Payee;
			ResourceReference w_ = a?.Referral;
			ResourceReference x_ = a?.Facility;
			ResourceReference y_ = a?.Claim;
			ResourceReference z_ = a?.ClaimResponse;
			Code<ClaimProcessingCodes> aa_ = a?.OutcomeElement;
			FhirString ab_ = a?.DispositionElement;
			List<FhirString> ac_ = a?.PreAuthRefElement;
			List<Period> ad_ = a?.PreAuthRefPeriod;
			List<ExplanationOfBenefit.CareTeamComponent> ae_ = a?.CareTeam;
			List<ExplanationOfBenefit.SupportingInformationComponent> af_ = a?.SupportingInfo;
			List<ExplanationOfBenefit.DiagnosisComponent> ag_ = a?.Diagnosis;
			List<ExplanationOfBenefit.ProcedureComponent> ah_ = a?.Procedure;
			PositiveInt ai_ = a?.PrecedenceElement;
			Integer aj_ = context.Operators.Convert<Integer>(ai_);
			PositiveInt ak_ = context.Operators.Convert<PositiveInt>(aj_);
			List<ExplanationOfBenefit.InsuranceComponent> al_ = a?.Insurance;
			ExplanationOfBenefit.AccidentComponent am_ = a?.Accident;
			List<ExplanationOfBenefit.ItemComponent> an_ = a?.Item;
			List<ExplanationOfBenefit.AddedItemComponent> ao_ = a?.AddItem;
			List<ExplanationOfBenefit.AdjudicationComponent> ap_ = a?.Adjudication;
			List<ExplanationOfBenefit.TotalComponent> aq_ = a?.Total;
			ExplanationOfBenefit.PaymentComponent ar_ = a?.Payment;
			CodeableConcept as_ = a?.FormCode;
			Attachment at_ = a?.Form;
			List<ExplanationOfBenefit.NoteComponent> au_ = a?.ProcessNote;
			Period av_ = a?.BenefitPeriod;
			List<ExplanationOfBenefit.BenefitBalanceComponent> aw_ = a?.BenefitBalance;
			ExplanationOfBenefit ax_ = new ExplanationOfBenefit
			{
				Identifier = new List<Identifier>((IEnumerable<Identifier>)e_),
				StatusElement = f_,
				Type = g_,
				SubType = h_,
				UseElement = i_,
				Patient = j_,
				BillablePeriod = k_,
				CreatedElement = l_,
				Enterer = m_,
				Insurer = n_,
				Provider = o_,
				Priority = p_,
				FundsReserveRequested = q_,
				FundsReserve = r_,
				Related = new List<ExplanationOfBenefit.RelatedClaimComponent>((IEnumerable<ExplanationOfBenefit.RelatedClaimComponent>)s_),
				Prescription = t_,
				OriginalPrescription = u_,
				Payee = v_,
				Referral = w_,
				Facility = x_,
				Claim = y_,
				ClaimResponse = z_,
				OutcomeElement = aa_,
				DispositionElement = ab_,
				PreAuthRefElement = new List<FhirString>((IEnumerable<FhirString>)ac_),
				PreAuthRefPeriod = new List<Period>((IEnumerable<Period>)ad_),
				CareTeam = new List<ExplanationOfBenefit.CareTeamComponent>((IEnumerable<ExplanationOfBenefit.CareTeamComponent>)ae_),
				SupportingInfo = new List<ExplanationOfBenefit.SupportingInformationComponent>((IEnumerable<ExplanationOfBenefit.SupportingInformationComponent>)af_),
				Diagnosis = new List<ExplanationOfBenefit.DiagnosisComponent>((IEnumerable<ExplanationOfBenefit.DiagnosisComponent>)ag_),
				Procedure = new List<ExplanationOfBenefit.ProcedureComponent>((IEnumerable<ExplanationOfBenefit.ProcedureComponent>)ah_),
				PrecedenceElement = ak_,
				Insurance = new List<ExplanationOfBenefit.InsuranceComponent>((IEnumerable<ExplanationOfBenefit.InsuranceComponent>)al_),
				Accident = am_,
				Item = new List<ExplanationOfBenefit.ItemComponent>((IEnumerable<ExplanationOfBenefit.ItemComponent>)an_),
				AddItem = new List<ExplanationOfBenefit.AddedItemComponent>((IEnumerable<ExplanationOfBenefit.AddedItemComponent>)ao_),
				Adjudication = new List<ExplanationOfBenefit.AdjudicationComponent>((IEnumerable<ExplanationOfBenefit.AdjudicationComponent>)ap_),
				Total = new List<ExplanationOfBenefit.TotalComponent>((IEnumerable<ExplanationOfBenefit.TotalComponent>)aq_),
				Payment = ar_,
				FormCode = as_,
				Form = at_,
				ProcessNote = new List<ExplanationOfBenefit.NoteComponent>((IEnumerable<ExplanationOfBenefit.NoteComponent>)au_),
				BenefitPeriod = av_,
				BenefitBalance = new List<ExplanationOfBenefit.BenefitBalanceComponent>((IEnumerable<ExplanationOfBenefit.BenefitBalanceComponent>)aw_),
			};

			return ax_;
		};
		IEnumerable<ExplanationOfBenefit> c_ = context.Operators.Select<ExplanationOfBenefit, ExplanationOfBenefit>((IEnumerable<ExplanationOfBenefit>)a_, b_);
		ExplanationOfBenefit d_ = context.Operators.SingletonFrom<ExplanationOfBenefit>(c_);

		return d_;
	}

    [CqlDeclaration("FamilyMemberHistoryResource")]
	public FamilyMemberHistory FamilyMemberHistoryResource(FamilyMemberHistory arg)
	{
		FamilyMemberHistory[] a_ = [
			arg,
		];
		FamilyMemberHistory b_(FamilyMemberHistory a)
		{
			List<Identifier> e_ = a?.Identifier;
			List<Canonical> f_ = a?.InstantiatesCanonicalElement;
			List<FhirUri> g_ = a?.InstantiatesUriElement;
			Code<FamilyMemberHistory.FamilyHistoryStatus> h_ = a?.StatusElement;
			CodeableConcept i_ = a?.DataAbsentReason;
			ResourceReference j_ = a?.Patient;
			FhirDateTime k_ = a?.DateElement;
			FhirString l_ = a?.NameElement;
			CodeableConcept m_ = a?.Relationship;
			CodeableConcept n_ = a?.Sex;
			DataType o_ = a?.Born;
			DataType p_ = a?.Age;
			FhirBoolean q_ = a?.EstimatedAgeElement;
			DataType r_ = a?.Deceased;
			List<CodeableConcept> s_ = a?.ReasonCode;
			List<ResourceReference> t_ = a?.ReasonReference;
			List<Annotation> u_ = a?.Note;
			List<FamilyMemberHistory.ConditionComponent> v_ = a?.Condition;
			FamilyMemberHistory w_ = new FamilyMemberHistory
			{
				Identifier = new List<Identifier>((IEnumerable<Identifier>)e_),
				InstantiatesCanonicalElement = new List<Canonical>((IEnumerable<Canonical>)f_),
				InstantiatesUriElement = new List<FhirUri>((IEnumerable<FhirUri>)g_),
				StatusElement = h_,
				DataAbsentReason = i_,
				Patient = j_,
				DateElement = k_,
				NameElement = l_,
				Relationship = m_,
				Sex = n_,
				Born = (DataType)o_,
				Age = (DataType)p_,
				EstimatedAgeElement = q_,
				Deceased = (DataType)r_,
				ReasonCode = new List<CodeableConcept>((IEnumerable<CodeableConcept>)s_),
				ReasonReference = new List<ResourceReference>((IEnumerable<ResourceReference>)t_),
				Note = new List<Annotation>((IEnumerable<Annotation>)u_),
				Condition = new List<FamilyMemberHistory.ConditionComponent>((IEnumerable<FamilyMemberHistory.ConditionComponent>)v_),
			};

			return w_;
		};
		IEnumerable<FamilyMemberHistory> c_ = context.Operators.Select<FamilyMemberHistory, FamilyMemberHistory>((IEnumerable<FamilyMemberHistory>)a_, b_);
		FamilyMemberHistory d_ = context.Operators.SingletonFrom<FamilyMemberHistory>(c_);

		return d_;
	}

    [CqlDeclaration("FlagResource")]
	public Flag FlagResource(Flag arg)
	{
		Flag[] a_ = [
			arg,
		];
		Flag b_(Flag a)
		{
			List<Identifier> e_ = a?.Identifier;
			Code<Flag.FlagStatus> f_ = a?.StatusElement;
			List<CodeableConcept> g_ = a?.Category;
			CodeableConcept h_ = a?.Code;
			ResourceReference i_ = a?.Subject;
			Period j_ = a?.Period;
			ResourceReference k_ = a?.Encounter;
			ResourceReference l_ = a?.Author;
			Flag m_ = new Flag
			{
				Identifier = new List<Identifier>((IEnumerable<Identifier>)e_),
				StatusElement = f_,
				Category = new List<CodeableConcept>((IEnumerable<CodeableConcept>)g_),
				Code = h_,
				Subject = i_,
				Period = j_,
				Encounter = k_,
				Author = l_,
			};

			return m_;
		};
		IEnumerable<Flag> c_ = context.Operators.Select<Flag, Flag>((IEnumerable<Flag>)a_, b_);
		Flag d_ = context.Operators.SingletonFrom<Flag>(c_);

		return d_;
	}

    [CqlDeclaration("GoalResource")]
	public Goal GoalResource(Goal arg)
	{
		Goal[] a_ = [
			arg,
		];
		Goal b_(Goal a)
		{
			List<Identifier> e_ = a?.Identifier;
			Code<Goal.GoalLifecycleStatus> f_ = a?.LifecycleStatusElement;
			CodeableConcept g_ = a?.AchievementStatus;
			List<CodeableConcept> h_ = a?.Category;
			CodeableConcept i_ = a?.Priority;
			CodeableConcept j_ = a?.Description;
			ResourceReference k_ = a?.Subject;
			DataType l_ = a?.Start;
			List<Goal.TargetComponent> m_ = a?.Target;
			Date n_ = a?.StatusDateElement;
			FhirString o_ = a?.StatusReasonElement;
			ResourceReference p_ = a?.ExpressedBy;
			List<ResourceReference> q_ = a?.Addresses;
			List<Annotation> r_ = a?.Note;
			List<CodeableConcept> s_ = a?.OutcomeCode;
			List<ResourceReference> t_ = a?.OutcomeReference;
			Goal u_ = new Goal
			{
				Identifier = new List<Identifier>((IEnumerable<Identifier>)e_),
				LifecycleStatusElement = f_,
				AchievementStatus = g_,
				Category = new List<CodeableConcept>((IEnumerable<CodeableConcept>)h_),
				Priority = i_,
				Description = j_,
				Subject = k_,
				Start = (DataType)l_,
				Target = new List<Goal.TargetComponent>((IEnumerable<Goal.TargetComponent>)m_),
				StatusDateElement = n_,
				StatusReasonElement = o_,
				ExpressedBy = p_,
				Addresses = new List<ResourceReference>((IEnumerable<ResourceReference>)q_),
				Note = new List<Annotation>((IEnumerable<Annotation>)r_),
				OutcomeCode = new List<CodeableConcept>((IEnumerable<CodeableConcept>)s_),
				OutcomeReference = new List<ResourceReference>((IEnumerable<ResourceReference>)t_),
			};

			return u_;
		};
		IEnumerable<Goal> c_ = context.Operators.Select<Goal, Goal>((IEnumerable<Goal>)a_, b_);
		Goal d_ = context.Operators.SingletonFrom<Goal>(c_);

		return d_;
	}

    [CqlDeclaration("GroupResource")]
	public Group GroupResource(Group arg)
	{
		Group[] a_ = [
			arg,
		];
		Group b_(Group a)
		{
			List<Identifier> e_ = a?.Identifier;
			FhirBoolean f_ = a?.ActiveElement;
			Code<Group.GroupType> g_ = a?.TypeElement;
			FhirBoolean h_ = a?.ActualElement;
			CodeableConcept i_ = a?.Code;
			FhirString j_ = a?.NameElement;
			UnsignedInt k_ = a?.QuantityElement;
			Integer l_ = context.Operators.Convert<Integer>(k_);
			UnsignedInt m_ = context.Operators.Convert<UnsignedInt>(l_);
			ResourceReference n_ = a?.ManagingEntity;
			List<Group.CharacteristicComponent> o_ = a?.Characteristic;
			List<Group.MemberComponent> p_ = a?.Member;
			Group q_ = new Group
			{
				Identifier = new List<Identifier>((IEnumerable<Identifier>)e_),
				ActiveElement = f_,
				TypeElement = g_,
				ActualElement = h_,
				Code = i_,
				NameElement = j_,
				QuantityElement = m_,
				ManagingEntity = n_,
				Characteristic = new List<Group.CharacteristicComponent>((IEnumerable<Group.CharacteristicComponent>)o_),
				Member = new List<Group.MemberComponent>((IEnumerable<Group.MemberComponent>)p_),
			};

			return q_;
		};
		IEnumerable<Group> c_ = context.Operators.Select<Group, Group>((IEnumerable<Group>)a_, b_);
		Group d_ = context.Operators.SingletonFrom<Group>(c_);

		return d_;
	}

    [CqlDeclaration("GuidanceResponseResource")]
	public GuidanceResponse GuidanceResponseResource(GuidanceResponse arg)
	{
		GuidanceResponse[] a_ = [
			arg,
		];
		GuidanceResponse b_(GuidanceResponse a)
		{
			Identifier e_ = a?.RequestIdentifier;
			List<Identifier> f_ = a?.Identifier;
			DataType g_ = a?.Module;
			Code<GuidanceResponse.GuidanceResponseStatus> h_ = a?.StatusElement;
			ResourceReference i_ = a?.Subject;
			ResourceReference j_ = a?.Encounter;
			FhirDateTime k_ = a?.OccurrenceDateTimeElement;
			ResourceReference l_ = a?.Performer;
			List<CodeableConcept> m_ = a?.ReasonCode;
			List<ResourceReference> n_ = a?.ReasonReference;
			List<Annotation> o_ = a?.Note;
			List<ResourceReference> p_ = a?.EvaluationMessage;
			ResourceReference q_ = a?.OutputParameters;
			ResourceReference r_ = a?.Result;
			List<DataRequirement> s_ = a?.DataRequirement;
			GuidanceResponse t_ = new GuidanceResponse
			{
				RequestIdentifier = e_,
				Identifier = new List<Identifier>((IEnumerable<Identifier>)f_),
				Module = (DataType)g_,
				StatusElement = h_,
				Subject = i_,
				Encounter = j_,
				OccurrenceDateTimeElement = k_,
				Performer = l_,
				ReasonCode = new List<CodeableConcept>((IEnumerable<CodeableConcept>)m_),
				ReasonReference = new List<ResourceReference>((IEnumerable<ResourceReference>)n_),
				Note = new List<Annotation>((IEnumerable<Annotation>)o_),
				EvaluationMessage = new List<ResourceReference>((IEnumerable<ResourceReference>)p_),
				OutputParameters = q_,
				Result = r_,
				DataRequirement = new List<DataRequirement>((IEnumerable<DataRequirement>)s_),
			};

			return t_;
		};
		IEnumerable<GuidanceResponse> c_ = context.Operators.Select<GuidanceResponse, GuidanceResponse>((IEnumerable<GuidanceResponse>)a_, b_);
		GuidanceResponse d_ = context.Operators.SingletonFrom<GuidanceResponse>(c_);

		return d_;
	}

    [CqlDeclaration("HealthcareServiceResource")]
	public HealthcareService HealthcareServiceResource(HealthcareService arg)
	{
		HealthcareService[] a_ = [
			arg,
		];
		HealthcareService b_(HealthcareService a)
		{
			List<Identifier> e_ = a?.Identifier;
			FhirBoolean f_ = a?.ActiveElement;
			ResourceReference g_ = a?.ProvidedBy;
			List<CodeableConcept> h_ = a?.Category;
			List<CodeableConcept> i_ = a?.Type;
			List<CodeableConcept> j_ = a?.Specialty;
			List<ResourceReference> k_ = a?.Location;
			FhirString l_ = a?.NameElement;
			FhirString m_ = a?.CommentElement;
			Markdown n_ = a?.ExtraDetailsElement;
			Attachment o_ = a?.Photo;
			List<ContactPoint> p_ = a?.Telecom;
			List<ResourceReference> q_ = a?.CoverageArea;
			List<CodeableConcept> r_ = a?.ServiceProvisionCode;
			List<HealthcareService.EligibilityComponent> s_ = a?.Eligibility;
			List<CodeableConcept> t_ = a?.Program;
			List<CodeableConcept> u_ = a?.Characteristic;
			List<CodeableConcept> v_ = a?.Communication;
			List<CodeableConcept> w_ = a?.ReferralMethod;
			FhirBoolean x_ = a?.AppointmentRequiredElement;
			List<HealthcareService.AvailableTimeComponent> y_ = a?.AvailableTime;
			List<HealthcareService.NotAvailableComponent> z_ = a?.NotAvailable;
			FhirString aa_ = a?.AvailabilityExceptionsElement;
			List<ResourceReference> ab_ = a?.Endpoint;
			HealthcareService ac_ = new HealthcareService
			{
				Identifier = new List<Identifier>((IEnumerable<Identifier>)e_),
				ActiveElement = f_,
				ProvidedBy = g_,
				Category = new List<CodeableConcept>((IEnumerable<CodeableConcept>)h_),
				Type = new List<CodeableConcept>((IEnumerable<CodeableConcept>)i_),
				Specialty = new List<CodeableConcept>((IEnumerable<CodeableConcept>)j_),
				Location = new List<ResourceReference>((IEnumerable<ResourceReference>)k_),
				NameElement = l_,
				CommentElement = m_,
				ExtraDetailsElement = n_,
				Photo = o_,
				Telecom = new List<ContactPoint>((IEnumerable<ContactPoint>)p_),
				CoverageArea = new List<ResourceReference>((IEnumerable<ResourceReference>)q_),
				ServiceProvisionCode = new List<CodeableConcept>((IEnumerable<CodeableConcept>)r_),
				Eligibility = new List<HealthcareService.EligibilityComponent>((IEnumerable<HealthcareService.EligibilityComponent>)s_),
				Program = new List<CodeableConcept>((IEnumerable<CodeableConcept>)t_),
				Characteristic = new List<CodeableConcept>((IEnumerable<CodeableConcept>)u_),
				Communication = new List<CodeableConcept>((IEnumerable<CodeableConcept>)v_),
				ReferralMethod = new List<CodeableConcept>((IEnumerable<CodeableConcept>)w_),
				AppointmentRequiredElement = x_,
				AvailableTime = new List<HealthcareService.AvailableTimeComponent>((IEnumerable<HealthcareService.AvailableTimeComponent>)y_),
				NotAvailable = new List<HealthcareService.NotAvailableComponent>((IEnumerable<HealthcareService.NotAvailableComponent>)z_),
				AvailabilityExceptionsElement = aa_,
				Endpoint = new List<ResourceReference>((IEnumerable<ResourceReference>)ab_),
			};

			return ac_;
		};
		IEnumerable<HealthcareService> c_ = context.Operators.Select<HealthcareService, HealthcareService>((IEnumerable<HealthcareService>)a_, b_);
		HealthcareService d_ = context.Operators.SingletonFrom<HealthcareService>(c_);

		return d_;
	}

    [CqlDeclaration("ImagingStudyResource")]
	public ImagingStudy ImagingStudyResource(ImagingStudy arg)
	{
		ImagingStudy[] a_ = [
			arg,
		];
		ImagingStudy b_(ImagingStudy a)
		{
			List<Identifier> e_ = a?.Identifier;
			Code<ImagingStudy.ImagingStudyStatus> f_ = a?.StatusElement;
			List<Coding> g_ = a?.Modality;
			ResourceReference h_ = a?.Subject;
			ResourceReference i_ = a?.Encounter;
			FhirDateTime j_ = a?.StartedElement;
			List<ResourceReference> k_ = a?.BasedOn;
			ResourceReference l_ = a?.Referrer;
			List<ResourceReference> m_ = a?.Interpreter;
			List<ResourceReference> n_ = a?.Endpoint;
			UnsignedInt o_ = a?.NumberOfSeriesElement;
			Integer p_ = context.Operators.Convert<Integer>(o_);
			UnsignedInt q_ = context.Operators.Convert<UnsignedInt>(p_);
			UnsignedInt r_ = a?.NumberOfInstancesElement;
			Integer s_ = context.Operators.Convert<Integer>(r_);
			UnsignedInt t_ = context.Operators.Convert<UnsignedInt>(s_);
			ResourceReference u_ = a?.ProcedureReference;
			List<CodeableConcept> v_ = a?.ProcedureCode;
			ResourceReference w_ = a?.Location;
			List<CodeableConcept> x_ = a?.ReasonCode;
			List<ResourceReference> y_ = a?.ReasonReference;
			List<Annotation> z_ = a?.Note;
			FhirString aa_ = a?.DescriptionElement;
			List<ImagingStudy.SeriesComponent> ab_ = a?.Series;
			ImagingStudy ac_ = new ImagingStudy
			{
				Identifier = new List<Identifier>((IEnumerable<Identifier>)e_),
				StatusElement = f_,
				Modality = new List<Coding>((IEnumerable<Coding>)g_),
				Subject = h_,
				Encounter = i_,
				StartedElement = j_,
				BasedOn = new List<ResourceReference>((IEnumerable<ResourceReference>)k_),
				Referrer = l_,
				Interpreter = new List<ResourceReference>((IEnumerable<ResourceReference>)m_),
				Endpoint = new List<ResourceReference>((IEnumerable<ResourceReference>)n_),
				NumberOfSeriesElement = q_,
				NumberOfInstancesElement = t_,
				ProcedureReference = u_,
				ProcedureCode = new List<CodeableConcept>((IEnumerable<CodeableConcept>)v_),
				Location = w_,
				ReasonCode = new List<CodeableConcept>((IEnumerable<CodeableConcept>)x_),
				ReasonReference = new List<ResourceReference>((IEnumerable<ResourceReference>)y_),
				Note = new List<Annotation>((IEnumerable<Annotation>)z_),
				DescriptionElement = aa_,
				Series = new List<ImagingStudy.SeriesComponent>((IEnumerable<ImagingStudy.SeriesComponent>)ab_),
			};

			return ac_;
		};
		IEnumerable<ImagingStudy> c_ = context.Operators.Select<ImagingStudy, ImagingStudy>((IEnumerable<ImagingStudy>)a_, b_);
		ImagingStudy d_ = context.Operators.SingletonFrom<ImagingStudy>(c_);

		return d_;
	}

    [CqlDeclaration("ImmunizationResource")]
	public Immunization ImmunizationResource(Immunization arg)
	{
		Immunization[] a_ = [
			arg,
		];
		Immunization b_(Immunization a)
		{
			List<Identifier> e_ = a?.Identifier;
			Code<Immunization.ImmunizationStatusCodes> f_ = a?.StatusElement;
			CodeableConcept g_ = a?.StatusReason;
			CodeableConcept h_ = a?.VaccineCode;
			ResourceReference i_ = a?.Patient;
			ResourceReference j_ = a?.Encounter;
			DataType k_ = a?.Occurrence;
			FhirDateTime l_ = a?.RecordedElement;
			FhirBoolean m_ = a?.PrimarySourceElement;
			CodeableConcept n_ = a?.ReportOrigin;
			ResourceReference o_ = a?.Location;
			ResourceReference p_ = a?.Manufacturer;
			FhirString q_ = a?.LotNumberElement;
			Date r_ = a?.ExpirationDateElement;
			CodeableConcept s_ = a?.Site;
			CodeableConcept t_ = a?.Route;
			Quantity u_ = a?.DoseQuantity;
			List<Immunization.PerformerComponent> v_ = a?.Performer;
			List<Annotation> w_ = a?.Note;
			List<CodeableConcept> x_ = a?.ReasonCode;
			List<ResourceReference> y_ = a?.ReasonReference;
			FhirBoolean z_ = a?.IsSubpotentElement;
			List<CodeableConcept> aa_ = a?.SubpotentReason;
			List<Immunization.EducationComponent> ab_ = a?.Education;
			List<CodeableConcept> ac_ = a?.ProgramEligibility;
			CodeableConcept ad_ = a?.FundingSource;
			List<Immunization.ReactionComponent> ae_ = a?.Reaction;
			List<Immunization.ProtocolAppliedComponent> af_ = a?.ProtocolApplied;
			Immunization ag_ = new Immunization
			{
				Identifier = new List<Identifier>((IEnumerable<Identifier>)e_),
				StatusElement = f_,
				StatusReason = g_,
				VaccineCode = h_,
				Patient = i_,
				Encounter = j_,
				Occurrence = (DataType)k_,
				RecordedElement = l_,
				PrimarySourceElement = m_,
				ReportOrigin = n_,
				Location = o_,
				Manufacturer = p_,
				LotNumberElement = q_,
				ExpirationDateElement = r_,
				Site = s_,
				Route = t_,
				DoseQuantity = u_,
				Performer = new List<Immunization.PerformerComponent>((IEnumerable<Immunization.PerformerComponent>)v_),
				Note = new List<Annotation>((IEnumerable<Annotation>)w_),
				ReasonCode = new List<CodeableConcept>((IEnumerable<CodeableConcept>)x_),
				ReasonReference = new List<ResourceReference>((IEnumerable<ResourceReference>)y_),
				IsSubpotentElement = z_,
				SubpotentReason = new List<CodeableConcept>((IEnumerable<CodeableConcept>)aa_),
				Education = new List<Immunization.EducationComponent>((IEnumerable<Immunization.EducationComponent>)ab_),
				ProgramEligibility = new List<CodeableConcept>((IEnumerable<CodeableConcept>)ac_),
				FundingSource = ad_,
				Reaction = new List<Immunization.ReactionComponent>((IEnumerable<Immunization.ReactionComponent>)ae_),
				ProtocolApplied = new List<Immunization.ProtocolAppliedComponent>((IEnumerable<Immunization.ProtocolAppliedComponent>)af_),
			};

			return ag_;
		};
		IEnumerable<Immunization> c_ = context.Operators.Select<Immunization, Immunization>((IEnumerable<Immunization>)a_, b_);
		Immunization d_ = context.Operators.SingletonFrom<Immunization>(c_);

		return d_;
	}

    [CqlDeclaration("ImmunizationEvaluationResource")]
	public ImmunizationEvaluation ImmunizationEvaluationResource(ImmunizationEvaluation arg)
	{
		ImmunizationEvaluation[] a_ = [
			arg,
		];
		ImmunizationEvaluation b_(ImmunizationEvaluation a)
		{
			List<Identifier> e_ = a?.Identifier;
			Code<ImmunizationEvaluation.ImmunizationEvaluationStatusCodes> f_ = a?.StatusElement;
			ResourceReference g_ = a?.Patient;
			FhirDateTime h_ = a?.DateElement;
			ResourceReference i_ = a?.Authority;
			CodeableConcept j_ = a?.TargetDisease;
			ResourceReference k_ = a?.ImmunizationEvent;
			CodeableConcept l_ = a?.DoseStatus;
			List<CodeableConcept> m_ = a?.DoseStatusReason;
			FhirString n_ = a?.DescriptionElement;
			FhirString o_ = a?.SeriesElement;
			DataType p_ = a?.DoseNumber;
			DataType q_ = a?.SeriesDoses;
			ImmunizationEvaluation r_ = new ImmunizationEvaluation
			{
				Identifier = new List<Identifier>((IEnumerable<Identifier>)e_),
				StatusElement = f_,
				Patient = g_,
				DateElement = h_,
				Authority = i_,
				TargetDisease = j_,
				ImmunizationEvent = k_,
				DoseStatus = l_,
				DoseStatusReason = new List<CodeableConcept>((IEnumerable<CodeableConcept>)m_),
				DescriptionElement = n_,
				SeriesElement = o_,
				DoseNumber = (DataType)p_,
				SeriesDoses = (DataType)q_,
			};

			return r_;
		};
		IEnumerable<ImmunizationEvaluation> c_ = context.Operators.Select<ImmunizationEvaluation, ImmunizationEvaluation>((IEnumerable<ImmunizationEvaluation>)a_, b_);
		ImmunizationEvaluation d_ = context.Operators.SingletonFrom<ImmunizationEvaluation>(c_);

		return d_;
	}

    [CqlDeclaration("ImmunizationRecommendationResource")]
	public ImmunizationRecommendation ImmunizationRecommendationResource(ImmunizationRecommendation arg)
	{
		ImmunizationRecommendation[] a_ = [
			arg,
		];
		ImmunizationRecommendation b_(ImmunizationRecommendation a)
		{
			List<Identifier> e_ = a?.Identifier;
			ResourceReference f_ = a?.Patient;
			FhirDateTime g_ = a?.DateElement;
			ResourceReference h_ = a?.Authority;
			List<ImmunizationRecommendation.RecommendationComponent> i_ = a?.Recommendation;
			ImmunizationRecommendation j_ = new ImmunizationRecommendation
			{
				Identifier = new List<Identifier>((IEnumerable<Identifier>)e_),
				Patient = f_,
				DateElement = g_,
				Authority = h_,
				Recommendation = new List<ImmunizationRecommendation.RecommendationComponent>((IEnumerable<ImmunizationRecommendation.RecommendationComponent>)i_),
			};

			return j_;
		};
		IEnumerable<ImmunizationRecommendation> c_ = context.Operators.Select<ImmunizationRecommendation, ImmunizationRecommendation>((IEnumerable<ImmunizationRecommendation>)a_, b_);
		ImmunizationRecommendation d_ = context.Operators.SingletonFrom<ImmunizationRecommendation>(c_);

		return d_;
	}

    [CqlDeclaration("InsurancePlanResource")]
	public InsurancePlan InsurancePlanResource(InsurancePlan arg)
	{
		InsurancePlan[] a_ = [
			arg,
		];
		InsurancePlan b_(InsurancePlan a)
		{
			List<Identifier> e_ = a?.Identifier;
			Code<PublicationStatus> f_ = a?.StatusElement;
			List<CodeableConcept> g_ = a?.Type;
			FhirString h_ = a?.NameElement;
			List<FhirString> i_ = a?.AliasElement;
			Period j_ = a?.Period;
			ResourceReference k_ = a?.OwnedBy;
			ResourceReference l_ = a?.AdministeredBy;
			List<ResourceReference> m_ = a?.CoverageArea;
			List<InsurancePlan.ContactComponent> n_ = a?.Contact;
			List<ResourceReference> o_ = a?.Endpoint;
			List<ResourceReference> p_ = a?.Network;
			List<InsurancePlan.CoverageComponent> q_ = a?.Coverage;
			List<InsurancePlan.PlanComponent> r_ = a?.Plan;
			InsurancePlan s_ = new InsurancePlan
			{
				Identifier = new List<Identifier>((IEnumerable<Identifier>)e_),
				StatusElement = f_,
				Type = new List<CodeableConcept>((IEnumerable<CodeableConcept>)g_),
				NameElement = h_,
				AliasElement = new List<FhirString>((IEnumerable<FhirString>)i_),
				Period = j_,
				OwnedBy = k_,
				AdministeredBy = l_,
				CoverageArea = new List<ResourceReference>((IEnumerable<ResourceReference>)m_),
				Contact = new List<InsurancePlan.ContactComponent>((IEnumerable<InsurancePlan.ContactComponent>)n_),
				Endpoint = new List<ResourceReference>((IEnumerable<ResourceReference>)o_),
				Network = new List<ResourceReference>((IEnumerable<ResourceReference>)p_),
				Coverage = new List<InsurancePlan.CoverageComponent>((IEnumerable<InsurancePlan.CoverageComponent>)q_),
				Plan = new List<InsurancePlan.PlanComponent>((IEnumerable<InsurancePlan.PlanComponent>)r_),
			};

			return s_;
		};
		IEnumerable<InsurancePlan> c_ = context.Operators.Select<InsurancePlan, InsurancePlan>((IEnumerable<InsurancePlan>)a_, b_);
		InsurancePlan d_ = context.Operators.SingletonFrom<InsurancePlan>(c_);

		return d_;
	}

    [CqlDeclaration("InvoiceResource")]
	public Invoice InvoiceResource(Invoice arg)
	{
		Invoice[] a_ = [
			arg,
		];
		Invoice b_(Invoice a)
		{
			List<Identifier> e_ = a?.Identifier;
			Code<Invoice.InvoiceStatus> f_ = a?.StatusElement;
			FhirString g_ = a?.CancelledReasonElement;
			CodeableConcept h_ = a?.Type;
			ResourceReference i_ = a?.Subject;
			ResourceReference j_ = a?.Recipient;
			FhirDateTime k_ = a?.DateElement;
			List<Invoice.ParticipantComponent> l_ = a?.Participant;
			ResourceReference m_ = a?.Issuer;
			ResourceReference n_ = a?.Account;
			List<Invoice.LineItemComponent> o_ = a?.LineItem;
			List<Invoice.PriceComponentComponent> p_ = a?.TotalPriceComponent;
			Money q_ = a?.TotalNet;
			Money r_ = a?.TotalGross;
			Markdown s_ = a?.PaymentTermsElement;
			List<Annotation> t_ = a?.Note;
			Invoice u_ = new Invoice
			{
				Identifier = new List<Identifier>((IEnumerable<Identifier>)e_),
				StatusElement = f_,
				CancelledReasonElement = g_,
				Type = h_,
				Subject = i_,
				Recipient = j_,
				DateElement = k_,
				Participant = new List<Invoice.ParticipantComponent>((IEnumerable<Invoice.ParticipantComponent>)l_),
				Issuer = m_,
				Account = n_,
				LineItem = new List<Invoice.LineItemComponent>((IEnumerable<Invoice.LineItemComponent>)o_),
				TotalPriceComponent = new List<Invoice.PriceComponentComponent>((IEnumerable<Invoice.PriceComponentComponent>)p_),
				TotalNet = q_,
				TotalGross = r_,
				PaymentTermsElement = s_,
				Note = new List<Annotation>((IEnumerable<Annotation>)t_),
			};

			return u_;
		};
		IEnumerable<Invoice> c_ = context.Operators.Select<Invoice, Invoice>((IEnumerable<Invoice>)a_, b_);
		Invoice d_ = context.Operators.SingletonFrom<Invoice>(c_);

		return d_;
	}

    [CqlDeclaration("LibraryResource")]
	public Library LibraryResource(Library arg)
	{
		Library[] a_ = [
			arg,
		];
		Library b_(Library a)
		{
			FhirUri e_ = a?.UrlElement;
			List<Identifier> f_ = a?.Identifier;
			FhirString g_ = a?.VersionElement;
			FhirString h_ = a?.NameElement;
			FhirString i_ = a?.TitleElement;
			FhirString j_ = a?.SubtitleElement;
			Code<PublicationStatus> k_ = a?.StatusElement;
			FhirBoolean l_ = a?.ExperimentalElement;
			CodeableConcept m_ = a?.Type;
			DataType n_ = a?.Subject;
			FhirDateTime o_ = a?.DateElement;
			FhirString p_ = a?.PublisherElement;
			List<ContactDetail> q_ = a?.Contact;
			Markdown r_ = a?.DescriptionElement;
			List<UsageContext> s_ = a?.UseContext;
			List<CodeableConcept> t_ = a?.Jurisdiction;
			Markdown u_ = a?.PurposeElement;
			FhirString v_ = a?.UsageElement;
			Markdown w_ = a?.CopyrightElement;
			Date x_ = a?.ApprovalDateElement;
			Date y_ = a?.LastReviewDateElement;
			Period z_ = a?.EffectivePeriod;
			List<CodeableConcept> aa_ = a?.Topic;
			List<ContactDetail> ab_ = a?.Author;
			List<ContactDetail> ac_ = a?.Editor;
			List<ContactDetail> ad_ = a?.Reviewer;
			List<ContactDetail> ae_ = a?.Endorser;
			List<RelatedArtifact> af_ = a?.RelatedArtifact;
			List<ParameterDefinition> ag_ = a?.Parameter;
			List<DataRequirement> ah_ = a?.DataRequirement;
			List<Attachment> ai_ = a?.Content;
			Library aj_ = new Library
			{
				UrlElement = e_,
				Identifier = new List<Identifier>((IEnumerable<Identifier>)f_),
				VersionElement = g_,
				NameElement = h_,
				TitleElement = i_,
				SubtitleElement = j_,
				StatusElement = k_,
				ExperimentalElement = l_,
				Type = m_,
				Subject = (DataType)n_,
				DateElement = o_,
				PublisherElement = p_,
				Contact = new List<ContactDetail>((IEnumerable<ContactDetail>)q_),
				DescriptionElement = r_,
				UseContext = new List<UsageContext>((IEnumerable<UsageContext>)s_),
				Jurisdiction = new List<CodeableConcept>((IEnumerable<CodeableConcept>)t_),
				PurposeElement = u_,
				UsageElement = v_,
				CopyrightElement = w_,
				ApprovalDateElement = x_,
				LastReviewDateElement = y_,
				EffectivePeriod = z_,
				Topic = new List<CodeableConcept>((IEnumerable<CodeableConcept>)aa_),
				Author = new List<ContactDetail>((IEnumerable<ContactDetail>)ab_),
				Editor = new List<ContactDetail>((IEnumerable<ContactDetail>)ac_),
				Reviewer = new List<ContactDetail>((IEnumerable<ContactDetail>)ad_),
				Endorser = new List<ContactDetail>((IEnumerable<ContactDetail>)ae_),
				RelatedArtifact = new List<RelatedArtifact>((IEnumerable<RelatedArtifact>)af_),
				Parameter = new List<ParameterDefinition>((IEnumerable<ParameterDefinition>)ag_),
				DataRequirement = new List<DataRequirement>((IEnumerable<DataRequirement>)ah_),
				Content = new List<Attachment>((IEnumerable<Attachment>)ai_),
			};

			return aj_;
		};
		IEnumerable<Library> c_ = context.Operators.Select<Library, Library>((IEnumerable<Library>)a_, b_);
		Library d_ = context.Operators.SingletonFrom<Library>(c_);

		return d_;
	}

    [CqlDeclaration("LinkageResource")]
	public Linkage LinkageResource(Linkage arg)
	{
		Linkage[] a_ = [
			arg,
		];
		Linkage b_(Linkage a)
		{
			FhirBoolean e_ = a?.ActiveElement;
			ResourceReference f_ = a?.Author;
			List<Linkage.ItemComponent> g_ = a?.Item;
			Linkage h_ = new Linkage
			{
				ActiveElement = e_,
				Author = f_,
				Item = new List<Linkage.ItemComponent>((IEnumerable<Linkage.ItemComponent>)g_),
			};

			return h_;
		};
		IEnumerable<Linkage> c_ = context.Operators.Select<Linkage, Linkage>((IEnumerable<Linkage>)a_, b_);
		Linkage d_ = context.Operators.SingletonFrom<Linkage>(c_);

		return d_;
	}

    [CqlDeclaration("LocationResource")]
	public Location LocationResource(Location arg)
	{
		Location[] a_ = [
			arg,
		];
		Location b_(Location a)
		{
			List<Identifier> e_ = a?.Identifier;
			Code<Location.LocationStatus> f_ = a?.StatusElement;
			Coding g_ = a?.OperationalStatus;
			FhirString h_ = a?.NameElement;
			List<FhirString> i_ = a?.AliasElement;
			FhirString j_ = a?.DescriptionElement;
			Code<Location.LocationMode> k_ = a?.ModeElement;
			List<CodeableConcept> l_ = a?.Type;
			List<ContactPoint> m_ = a?.Telecom;
			Address n_ = a?.Address;
			CodeableConcept o_ = a?.PhysicalType;
			Location.PositionComponent p_ = a?.Position;
			ResourceReference q_ = a?.ManagingOrganization;
			ResourceReference r_ = a?.PartOf;
			List<Location.HoursOfOperationComponent> s_ = a?.HoursOfOperation;
			FhirString t_ = a?.AvailabilityExceptionsElement;
			List<ResourceReference> u_ = a?.Endpoint;
			Location v_ = new Location
			{
				Identifier = new List<Identifier>((IEnumerable<Identifier>)e_),
				StatusElement = f_,
				OperationalStatus = g_,
				NameElement = h_,
				AliasElement = new List<FhirString>((IEnumerable<FhirString>)i_),
				DescriptionElement = j_,
				ModeElement = k_,
				Type = new List<CodeableConcept>((IEnumerable<CodeableConcept>)l_),
				Telecom = new List<ContactPoint>((IEnumerable<ContactPoint>)m_),
				Address = n_,
				PhysicalType = o_,
				Position = p_,
				ManagingOrganization = q_,
				PartOf = r_,
				HoursOfOperation = new List<Location.HoursOfOperationComponent>((IEnumerable<Location.HoursOfOperationComponent>)s_),
				AvailabilityExceptionsElement = t_,
				Endpoint = new List<ResourceReference>((IEnumerable<ResourceReference>)u_),
			};

			return v_;
		};
		IEnumerable<Location> c_ = context.Operators.Select<Location, Location>((IEnumerable<Location>)a_, b_);
		Location d_ = context.Operators.SingletonFrom<Location>(c_);

		return d_;
	}

    [CqlDeclaration("MeasureResource")]
	public Measure MeasureResource(Measure arg)
	{
		Measure[] a_ = [
			arg,
		];
		Measure b_(Measure a)
		{
			FhirUri e_ = a?.UrlElement;
			List<Identifier> f_ = a?.Identifier;
			FhirString g_ = a?.VersionElement;
			FhirString h_ = a?.NameElement;
			FhirString i_ = a?.TitleElement;
			FhirString j_ = a?.SubtitleElement;
			Code<PublicationStatus> k_ = a?.StatusElement;
			FhirBoolean l_ = a?.ExperimentalElement;
			DataType m_ = a?.Subject;
			FhirDateTime n_ = a?.DateElement;
			FhirString o_ = a?.PublisherElement;
			List<ContactDetail> p_ = a?.Contact;
			Markdown q_ = a?.DescriptionElement;
			List<UsageContext> r_ = a?.UseContext;
			List<CodeableConcept> s_ = a?.Jurisdiction;
			Markdown t_ = a?.PurposeElement;
			FhirString u_ = a?.UsageElement;
			Markdown v_ = a?.CopyrightElement;
			Date w_ = a?.ApprovalDateElement;
			Date x_ = a?.LastReviewDateElement;
			Period y_ = a?.EffectivePeriod;
			List<CodeableConcept> z_ = a?.Topic;
			List<ContactDetail> aa_ = a?.Author;
			List<ContactDetail> ab_ = a?.Editor;
			List<ContactDetail> ac_ = a?.Reviewer;
			List<ContactDetail> ad_ = a?.Endorser;
			List<RelatedArtifact> ae_ = a?.RelatedArtifact;
			List<Canonical> af_ = a?.LibraryElement;
			Markdown ag_ = a?.DisclaimerElement;
			CodeableConcept ah_ = a?.Scoring;
			CodeableConcept ai_ = a?.CompositeScoring;
			List<CodeableConcept> aj_ = a?.Type;
			FhirString ak_ = a?.RiskAdjustmentElement;
			FhirString al_ = a?.RateAggregationElement;
			Markdown am_ = a?.RationaleElement;
			Markdown an_ = a?.ClinicalRecommendationStatementElement;
			CodeableConcept ao_ = a?.ImprovementNotation;
			List<Markdown> ap_ = a?.DefinitionElement;
			Markdown aq_ = a?.GuidanceElement;
			List<Measure.GroupComponent> ar_ = a?.Group;
			List<Measure.SupplementalDataComponent> as_ = a?.SupplementalData;
			Measure at_ = new Measure
			{
				UrlElement = e_,
				Identifier = new List<Identifier>((IEnumerable<Identifier>)f_),
				VersionElement = g_,
				NameElement = h_,
				TitleElement = i_,
				SubtitleElement = j_,
				StatusElement = k_,
				ExperimentalElement = l_,
				Subject = (DataType)m_,
				DateElement = n_,
				PublisherElement = o_,
				Contact = new List<ContactDetail>((IEnumerable<ContactDetail>)p_),
				DescriptionElement = q_,
				UseContext = new List<UsageContext>((IEnumerable<UsageContext>)r_),
				Jurisdiction = new List<CodeableConcept>((IEnumerable<CodeableConcept>)s_),
				PurposeElement = t_,
				UsageElement = u_,
				CopyrightElement = v_,
				ApprovalDateElement = w_,
				LastReviewDateElement = x_,
				EffectivePeriod = y_,
				Topic = new List<CodeableConcept>((IEnumerable<CodeableConcept>)z_),
				Author = new List<ContactDetail>((IEnumerable<ContactDetail>)aa_),
				Editor = new List<ContactDetail>((IEnumerable<ContactDetail>)ab_),
				Reviewer = new List<ContactDetail>((IEnumerable<ContactDetail>)ac_),
				Endorser = new List<ContactDetail>((IEnumerable<ContactDetail>)ad_),
				RelatedArtifact = new List<RelatedArtifact>((IEnumerable<RelatedArtifact>)ae_),
				LibraryElement = new List<Canonical>((IEnumerable<Canonical>)af_),
				DisclaimerElement = ag_,
				Scoring = ah_,
				CompositeScoring = ai_,
				Type = new List<CodeableConcept>((IEnumerable<CodeableConcept>)aj_),
				RiskAdjustmentElement = ak_,
				RateAggregationElement = al_,
				RationaleElement = am_,
				ClinicalRecommendationStatementElement = an_,
				ImprovementNotation = ao_,
				DefinitionElement = new List<Markdown>((IEnumerable<Markdown>)ap_),
				GuidanceElement = aq_,
				Group = new List<Measure.GroupComponent>((IEnumerable<Measure.GroupComponent>)ar_),
				SupplementalData = new List<Measure.SupplementalDataComponent>((IEnumerable<Measure.SupplementalDataComponent>)as_),
			};

			return at_;
		};
		IEnumerable<Measure> c_ = context.Operators.Select<Measure, Measure>((IEnumerable<Measure>)a_, b_);
		Measure d_ = context.Operators.SingletonFrom<Measure>(c_);

		return d_;
	}

    [CqlDeclaration("MeasureReportResource")]
	public MeasureReport MeasureReportResource(MeasureReport arg)
	{
		MeasureReport[] a_ = [
			arg,
		];
		MeasureReport b_(MeasureReport a)
		{
			List<Identifier> e_ = a?.Identifier;
			Code<MeasureReport.MeasureReportStatus> f_ = a?.StatusElement;
			Code<MeasureReport.MeasureReportType> g_ = a?.TypeElement;
			Canonical h_ = a?.MeasureElement;
			ResourceReference i_ = a?.Subject;
			FhirDateTime j_ = a?.DateElement;
			ResourceReference k_ = a?.Reporter;
			Period l_ = a?.Period;
			CodeableConcept m_ = a?.ImprovementNotation;
			List<MeasureReport.GroupComponent> n_ = a?.Group;
			List<ResourceReference> o_ = a?.EvaluatedResource;
			MeasureReport p_ = new MeasureReport
			{
				Identifier = new List<Identifier>((IEnumerable<Identifier>)e_),
				StatusElement = f_,
				TypeElement = g_,
				MeasureElement = h_,
				Subject = i_,
				DateElement = j_,
				Reporter = k_,
				Period = l_,
				ImprovementNotation = m_,
				Group = new List<MeasureReport.GroupComponent>((IEnumerable<MeasureReport.GroupComponent>)n_),
				EvaluatedResource = new List<ResourceReference>((IEnumerable<ResourceReference>)o_),
			};

			return p_;
		};
		IEnumerable<MeasureReport> c_ = context.Operators.Select<MeasureReport, MeasureReport>((IEnumerable<MeasureReport>)a_, b_);
		MeasureReport d_ = context.Operators.SingletonFrom<MeasureReport>(c_);

		return d_;
	}

    [CqlDeclaration("MedicationResource")]
	public Medication MedicationResource(Medication arg)
	{
		Medication[] a_ = [
			arg,
		];
		Medication b_(Medication a)
		{
			List<Identifier> e_ = a?.Identifier;
			CodeableConcept f_ = a?.Code;
			Code<Medication.MedicationStatusCodes> g_ = a?.StatusElement;
			ResourceReference h_ = a?.Manufacturer;
			CodeableConcept i_ = a?.Form;
			Ratio j_ = a?.Amount;
			List<Medication.IngredientComponent> k_ = a?.Ingredient;
			Medication.BatchComponent l_ = a?.Batch;
			Medication m_ = new Medication
			{
				Identifier = new List<Identifier>((IEnumerable<Identifier>)e_),
				Code = f_,
				StatusElement = g_,
				Manufacturer = h_,
				Form = i_,
				Amount = j_,
				Ingredient = new List<Medication.IngredientComponent>((IEnumerable<Medication.IngredientComponent>)k_),
				Batch = l_,
			};

			return m_;
		};
		IEnumerable<Medication> c_ = context.Operators.Select<Medication, Medication>((IEnumerable<Medication>)a_, b_);
		Medication d_ = context.Operators.SingletonFrom<Medication>(c_);

		return d_;
	}

    [CqlDeclaration("MedicationAdministrationResource")]
	public MedicationAdministration MedicationAdministrationResource(MedicationAdministration arg)
	{
		MedicationAdministration[] a_ = [
			arg,
		];
		MedicationAdministration b_(MedicationAdministration a)
		{
			List<Identifier> e_ = a?.Identifier;
			List<FhirUri> f_ = a?.InstantiatesElement;
			List<ResourceReference> g_ = a?.PartOf;
			Code<MedicationAdministration.MedicationAdministrationStatusCodes> h_ = a?.StatusElement;
			List<CodeableConcept> i_ = a?.StatusReason;
			CodeableConcept j_ = a?.Category;
			DataType k_ = a?.Medication;
			ResourceReference l_ = a?.Subject;
			ResourceReference m_ = a?.Context;
			List<ResourceReference> n_ = a?.SupportingInformation;
			DataType o_ = a?.Effective;
			List<MedicationAdministration.PerformerComponent> p_ = a?.Performer;
			List<CodeableConcept> q_ = a?.ReasonCode;
			List<ResourceReference> r_ = a?.ReasonReference;
			ResourceReference s_ = a?.Request;
			List<ResourceReference> t_ = a?.Device;
			List<Annotation> u_ = a?.Note;
			MedicationAdministration.DosageComponent v_ = a?.Dosage;
			List<ResourceReference> w_ = a?.EventHistory;
			MedicationAdministration x_ = new MedicationAdministration
			{
				Identifier = new List<Identifier>((IEnumerable<Identifier>)e_),
				InstantiatesElement = new List<FhirUri>((IEnumerable<FhirUri>)f_),
				PartOf = new List<ResourceReference>((IEnumerable<ResourceReference>)g_),
				StatusElement = h_,
				StatusReason = new List<CodeableConcept>((IEnumerable<CodeableConcept>)i_),
				Category = j_,
				Medication = (DataType)k_,
				Subject = l_,
				Context = m_,
				SupportingInformation = new List<ResourceReference>((IEnumerable<ResourceReference>)n_),
				Effective = (DataType)o_,
				Performer = new List<MedicationAdministration.PerformerComponent>((IEnumerable<MedicationAdministration.PerformerComponent>)p_),
				ReasonCode = new List<CodeableConcept>((IEnumerable<CodeableConcept>)q_),
				ReasonReference = new List<ResourceReference>((IEnumerable<ResourceReference>)r_),
				Request = s_,
				Device = new List<ResourceReference>((IEnumerable<ResourceReference>)t_),
				Note = new List<Annotation>((IEnumerable<Annotation>)u_),
				Dosage = v_,
				EventHistory = new List<ResourceReference>((IEnumerable<ResourceReference>)w_),
			};

			return x_;
		};
		IEnumerable<MedicationAdministration> c_ = context.Operators.Select<MedicationAdministration, MedicationAdministration>((IEnumerable<MedicationAdministration>)a_, b_);
		MedicationAdministration d_ = context.Operators.SingletonFrom<MedicationAdministration>(c_);

		return d_;
	}

    [CqlDeclaration("MedicationDispenseResource")]
	public MedicationDispense MedicationDispenseResource(MedicationDispense arg)
	{
		MedicationDispense[] a_ = [
			arg,
		];
		MedicationDispense b_(MedicationDispense a)
		{
			List<Identifier> e_ = a?.Identifier;
			List<ResourceReference> f_ = a?.PartOf;
			Code<MedicationDispense.MedicationDispenseStatusCodes> g_ = a?.StatusElement;
			DataType h_ = a?.StatusReason;
			CodeableConcept i_ = a?.Category;
			DataType j_ = a?.Medication;
			ResourceReference k_ = a?.Subject;
			ResourceReference l_ = a?.Context;
			List<ResourceReference> m_ = a?.SupportingInformation;
			List<MedicationDispense.PerformerComponent> n_ = a?.Performer;
			ResourceReference o_ = a?.Location;
			List<ResourceReference> p_ = a?.AuthorizingPrescription;
			CodeableConcept q_ = a?.Type;
			Quantity r_ = a?.Quantity;
			Quantity s_ = a?.DaysSupply;
			FhirDateTime t_ = a?.WhenPreparedElement;
			FhirDateTime u_ = a?.WhenHandedOverElement;
			ResourceReference v_ = a?.Destination;
			List<ResourceReference> w_ = a?.Receiver;
			List<Annotation> x_ = a?.Note;
			List<Dosage> y_ = a?.DosageInstruction;
			MedicationDispense.SubstitutionComponent z_ = a?.Substitution;
			List<ResourceReference> aa_ = a?.DetectedIssue;
			List<ResourceReference> ab_ = a?.EventHistory;
			MedicationDispense ac_ = new MedicationDispense
			{
				Identifier = new List<Identifier>((IEnumerable<Identifier>)e_),
				PartOf = new List<ResourceReference>((IEnumerable<ResourceReference>)f_),
				StatusElement = g_,
				StatusReason = (DataType)h_,
				Category = i_,
				Medication = (DataType)j_,
				Subject = k_,
				Context = l_,
				SupportingInformation = new List<ResourceReference>((IEnumerable<ResourceReference>)m_),
				Performer = new List<MedicationDispense.PerformerComponent>((IEnumerable<MedicationDispense.PerformerComponent>)n_),
				Location = o_,
				AuthorizingPrescription = new List<ResourceReference>((IEnumerable<ResourceReference>)p_),
				Type = q_,
				Quantity = r_,
				DaysSupply = s_,
				WhenPreparedElement = t_,
				WhenHandedOverElement = u_,
				Destination = v_,
				Receiver = new List<ResourceReference>((IEnumerable<ResourceReference>)w_),
				Note = new List<Annotation>((IEnumerable<Annotation>)x_),
				DosageInstruction = new List<Dosage>((IEnumerable<Dosage>)y_),
				Substitution = z_,
				DetectedIssue = new List<ResourceReference>((IEnumerable<ResourceReference>)aa_),
				EventHistory = new List<ResourceReference>((IEnumerable<ResourceReference>)ab_),
			};

			return ac_;
		};
		IEnumerable<MedicationDispense> c_ = context.Operators.Select<MedicationDispense, MedicationDispense>((IEnumerable<MedicationDispense>)a_, b_);
		MedicationDispense d_ = context.Operators.SingletonFrom<MedicationDispense>(c_);

		return d_;
	}

    [CqlDeclaration("MedicationKnowledgeResource")]
	public MedicationKnowledge MedicationKnowledgeResource(MedicationKnowledge arg)
	{
		MedicationKnowledge[] a_ = [
			arg,
		];
		MedicationKnowledge b_(MedicationKnowledge a)
		{
			CodeableConcept e_ = a?.Code;
			Code<MedicationKnowledge.MedicationKnowledgeStatusCodes> f_ = a?.StatusElement;
			ResourceReference g_ = a?.Manufacturer;
			CodeableConcept h_ = a?.DoseForm;
			Quantity i_ = a?.Amount;
			List<FhirString> j_ = a?.SynonymElement;
			List<MedicationKnowledge.RelatedMedicationKnowledgeComponent> k_ = a?.RelatedMedicationKnowledge;
			List<ResourceReference> l_ = a?.AssociatedMedication;
			List<CodeableConcept> m_ = a?.ProductType;
			List<MedicationKnowledge.MonographComponent> n_ = a?.Monograph;
			List<MedicationKnowledge.IngredientComponent> o_ = a?.Ingredient;
			Markdown p_ = a?.PreparationInstructionElement;
			List<CodeableConcept> q_ = a?.IntendedRoute;
			List<MedicationKnowledge.CostComponent> r_ = a?.Cost;
			List<MedicationKnowledge.MonitoringProgramComponent> s_ = a?.MonitoringProgram;
			List<MedicationKnowledge.AdministrationGuidelinesComponent> t_ = a?.AdministrationGuidelines;
			List<MedicationKnowledge.MedicineClassificationComponent> u_ = a?.MedicineClassification;
			MedicationKnowledge.PackagingComponent v_ = a?.Packaging;
			List<MedicationKnowledge.DrugCharacteristicComponent> w_ = a?.DrugCharacteristic;
			List<ResourceReference> x_ = a?.Contraindication;
			List<MedicationKnowledge.RegulatoryComponent> y_ = a?.Regulatory;
			List<MedicationKnowledge.KineticsComponent> z_ = a?.Kinetics;
			MedicationKnowledge aa_ = new MedicationKnowledge
			{
				Code = e_,
				StatusElement = f_,
				Manufacturer = g_,
				DoseForm = h_,
				Amount = i_,
				SynonymElement = new List<FhirString>((IEnumerable<FhirString>)j_),
				RelatedMedicationKnowledge = new List<MedicationKnowledge.RelatedMedicationKnowledgeComponent>((IEnumerable<MedicationKnowledge.RelatedMedicationKnowledgeComponent>)k_),
				AssociatedMedication = new List<ResourceReference>((IEnumerable<ResourceReference>)l_),
				ProductType = new List<CodeableConcept>((IEnumerable<CodeableConcept>)m_),
				Monograph = new List<MedicationKnowledge.MonographComponent>((IEnumerable<MedicationKnowledge.MonographComponent>)n_),
				Ingredient = new List<MedicationKnowledge.IngredientComponent>((IEnumerable<MedicationKnowledge.IngredientComponent>)o_),
				PreparationInstructionElement = p_,
				IntendedRoute = new List<CodeableConcept>((IEnumerable<CodeableConcept>)q_),
				Cost = new List<MedicationKnowledge.CostComponent>((IEnumerable<MedicationKnowledge.CostComponent>)r_),
				MonitoringProgram = new List<MedicationKnowledge.MonitoringProgramComponent>((IEnumerable<MedicationKnowledge.MonitoringProgramComponent>)s_),
				AdministrationGuidelines = new List<MedicationKnowledge.AdministrationGuidelinesComponent>((IEnumerable<MedicationKnowledge.AdministrationGuidelinesComponent>)t_),
				MedicineClassification = new List<MedicationKnowledge.MedicineClassificationComponent>((IEnumerable<MedicationKnowledge.MedicineClassificationComponent>)u_),
				Packaging = v_,
				DrugCharacteristic = new List<MedicationKnowledge.DrugCharacteristicComponent>((IEnumerable<MedicationKnowledge.DrugCharacteristicComponent>)w_),
				Contraindication = new List<ResourceReference>((IEnumerable<ResourceReference>)x_),
				Regulatory = new List<MedicationKnowledge.RegulatoryComponent>((IEnumerable<MedicationKnowledge.RegulatoryComponent>)y_),
				Kinetics = new List<MedicationKnowledge.KineticsComponent>((IEnumerable<MedicationKnowledge.KineticsComponent>)z_),
			};

			return aa_;
		};
		IEnumerable<MedicationKnowledge> c_ = context.Operators.Select<MedicationKnowledge, MedicationKnowledge>((IEnumerable<MedicationKnowledge>)a_, b_);
		MedicationKnowledge d_ = context.Operators.SingletonFrom<MedicationKnowledge>(c_);

		return d_;
	}

    [CqlDeclaration("MedicationRequestResource")]
	public MedicationRequest MedicationRequestResource(MedicationRequest arg)
	{
		MedicationRequest[] a_ = [
			arg,
		];
		MedicationRequest b_(MedicationRequest a)
		{
			List<Identifier> e_ = a?.Identifier;
			Code<MedicationRequest.MedicationrequestStatus> f_ = a?.StatusElement;
			CodeableConcept g_ = a?.StatusReason;
			Code<MedicationRequest.MedicationRequestIntent> h_ = a?.IntentElement;
			List<CodeableConcept> i_ = a?.Category;
			Code<RequestPriority> j_ = a?.PriorityElement;
			FhirBoolean k_ = a?.DoNotPerformElement;
			DataType l_ = a?.Reported;
			DataType m_ = a?.Medication;
			ResourceReference n_ = a?.Subject;
			ResourceReference o_ = a?.Encounter;
			List<ResourceReference> p_ = a?.SupportingInformation;
			FhirDateTime q_ = a?.AuthoredOnElement;
			ResourceReference r_ = a?.Requester;
			ResourceReference s_ = a?.Performer;
			CodeableConcept t_ = a?.PerformerType;
			ResourceReference u_ = a?.Recorder;
			List<CodeableConcept> v_ = a?.ReasonCode;
			List<ResourceReference> w_ = a?.ReasonReference;
			List<Canonical> x_ = a?.InstantiatesCanonicalElement;
			List<FhirUri> y_ = a?.InstantiatesUriElement;
			List<ResourceReference> z_ = a?.BasedOn;
			Identifier aa_ = a?.GroupIdentifier;
			CodeableConcept ab_ = a?.CourseOfTherapyType;
			List<ResourceReference> ac_ = a?.Insurance;
			List<Annotation> ad_ = a?.Note;
			List<Dosage> ae_ = a?.DosageInstruction;
			MedicationRequest.DispenseRequestComponent af_ = a?.DispenseRequest;
			MedicationRequest.SubstitutionComponent ag_ = a?.Substitution;
			ResourceReference ah_ = a?.PriorPrescription;
			List<ResourceReference> ai_ = a?.DetectedIssue;
			List<ResourceReference> aj_ = a?.EventHistory;
			MedicationRequest ak_ = new MedicationRequest
			{
				Identifier = new List<Identifier>((IEnumerable<Identifier>)e_),
				StatusElement = f_,
				StatusReason = g_,
				IntentElement = h_,
				Category = new List<CodeableConcept>((IEnumerable<CodeableConcept>)i_),
				PriorityElement = j_,
				DoNotPerformElement = k_,
				Reported = (DataType)l_,
				Medication = (DataType)m_,
				Subject = n_,
				Encounter = o_,
				SupportingInformation = new List<ResourceReference>((IEnumerable<ResourceReference>)p_),
				AuthoredOnElement = q_,
				Requester = r_,
				Performer = s_,
				PerformerType = t_,
				Recorder = u_,
				ReasonCode = new List<CodeableConcept>((IEnumerable<CodeableConcept>)v_),
				ReasonReference = new List<ResourceReference>((IEnumerable<ResourceReference>)w_),
				InstantiatesCanonicalElement = new List<Canonical>((IEnumerable<Canonical>)x_),
				InstantiatesUriElement = new List<FhirUri>((IEnumerable<FhirUri>)y_),
				BasedOn = new List<ResourceReference>((IEnumerable<ResourceReference>)z_),
				GroupIdentifier = aa_,
				CourseOfTherapyType = ab_,
				Insurance = new List<ResourceReference>((IEnumerable<ResourceReference>)ac_),
				Note = new List<Annotation>((IEnumerable<Annotation>)ad_),
				DosageInstruction = new List<Dosage>((IEnumerable<Dosage>)ae_),
				DispenseRequest = af_,
				Substitution = ag_,
				PriorPrescription = ah_,
				DetectedIssue = new List<ResourceReference>((IEnumerable<ResourceReference>)ai_),
				EventHistory = new List<ResourceReference>((IEnumerable<ResourceReference>)aj_),
			};

			return ak_;
		};
		IEnumerable<MedicationRequest> c_ = context.Operators.Select<MedicationRequest, MedicationRequest>((IEnumerable<MedicationRequest>)a_, b_);
		MedicationRequest d_ = context.Operators.SingletonFrom<MedicationRequest>(c_);

		return d_;
	}

    [CqlDeclaration("MedicationStatementResource")]
	public MedicationStatement MedicationStatementResource(MedicationStatement arg)
	{
		MedicationStatement[] a_ = [
			arg,
		];
		MedicationStatement b_(MedicationStatement a)
		{
			List<Identifier> e_ = a?.Identifier;
			List<ResourceReference> f_ = a?.BasedOn;
			List<ResourceReference> g_ = a?.PartOf;
			Code<MedicationStatement.MedicationStatusCodes> h_ = a?.StatusElement;
			List<CodeableConcept> i_ = a?.StatusReason;
			CodeableConcept j_ = a?.Category;
			DataType k_ = a?.Medication;
			ResourceReference l_ = a?.Subject;
			ResourceReference m_ = a?.Context;
			DataType n_ = a?.Effective;
			FhirDateTime o_ = a?.DateAssertedElement;
			ResourceReference p_ = a?.InformationSource;
			List<ResourceReference> q_ = a?.DerivedFrom;
			List<CodeableConcept> r_ = a?.ReasonCode;
			List<ResourceReference> s_ = a?.ReasonReference;
			List<Annotation> t_ = a?.Note;
			List<Dosage> u_ = a?.Dosage;
			MedicationStatement v_ = new MedicationStatement
			{
				Identifier = new List<Identifier>((IEnumerable<Identifier>)e_),
				BasedOn = new List<ResourceReference>((IEnumerable<ResourceReference>)f_),
				PartOf = new List<ResourceReference>((IEnumerable<ResourceReference>)g_),
				StatusElement = h_,
				StatusReason = new List<CodeableConcept>((IEnumerable<CodeableConcept>)i_),
				Category = j_,
				Medication = (DataType)k_,
				Subject = l_,
				Context = m_,
				Effective = (DataType)n_,
				DateAssertedElement = o_,
				InformationSource = p_,
				DerivedFrom = new List<ResourceReference>((IEnumerable<ResourceReference>)q_),
				ReasonCode = new List<CodeableConcept>((IEnumerable<CodeableConcept>)r_),
				ReasonReference = new List<ResourceReference>((IEnumerable<ResourceReference>)s_),
				Note = new List<Annotation>((IEnumerable<Annotation>)t_),
				Dosage = new List<Dosage>((IEnumerable<Dosage>)u_),
			};

			return v_;
		};
		IEnumerable<MedicationStatement> c_ = context.Operators.Select<MedicationStatement, MedicationStatement>((IEnumerable<MedicationStatement>)a_, b_);
		MedicationStatement d_ = context.Operators.SingletonFrom<MedicationStatement>(c_);

		return d_;
	}

    [CqlDeclaration("MedicinalProductResource")]
	public MedicinalProduct MedicinalProductResource(MedicinalProduct arg)
	{
		MedicinalProduct[] a_ = [
			arg,
		];
		MedicinalProduct b_(MedicinalProduct a)
		{
			List<Identifier> e_ = a?.Identifier;
			CodeableConcept f_ = a?.Type;
			Coding g_ = a?.Domain;
			CodeableConcept h_ = a?.CombinedPharmaceuticalDoseForm;
			CodeableConcept i_ = a?.LegalStatusOfSupply;
			CodeableConcept j_ = a?.AdditionalMonitoringIndicator;
			List<FhirString> k_ = a?.SpecialMeasuresElement;
			CodeableConcept l_ = a?.PaediatricUseIndicator;
			List<CodeableConcept> m_ = a?.ProductClassification;
			List<MarketingStatus> n_ = a?.MarketingStatus;
			List<ResourceReference> o_ = a?.PharmaceuticalProduct;
			List<ResourceReference> p_ = a?.PackagedMedicinalProduct;
			List<ResourceReference> q_ = a?.AttachedDocument;
			List<ResourceReference> r_ = a?.MasterFile;
			List<ResourceReference> s_ = a?.Contact;
			List<ResourceReference> t_ = a?.ClinicalTrial;
			List<MedicinalProduct.NameComponent> u_ = a?.Name;
			List<Identifier> v_ = a?.CrossReference;
			List<MedicinalProduct.ManufacturingBusinessOperationComponent> w_ = a?.ManufacturingBusinessOperation;
			List<MedicinalProduct.SpecialDesignationComponent> x_ = a?.SpecialDesignation;
			MedicinalProduct y_ = new MedicinalProduct
			{
				Identifier = new List<Identifier>((IEnumerable<Identifier>)e_),
				Type = f_,
				Domain = g_,
				CombinedPharmaceuticalDoseForm = h_,
				LegalStatusOfSupply = i_,
				AdditionalMonitoringIndicator = j_,
				SpecialMeasuresElement = new List<FhirString>((IEnumerable<FhirString>)k_),
				PaediatricUseIndicator = l_,
				ProductClassification = new List<CodeableConcept>((IEnumerable<CodeableConcept>)m_),
				MarketingStatus = new List<MarketingStatus>((IEnumerable<MarketingStatus>)n_),
				PharmaceuticalProduct = new List<ResourceReference>((IEnumerable<ResourceReference>)o_),
				PackagedMedicinalProduct = new List<ResourceReference>((IEnumerable<ResourceReference>)p_),
				AttachedDocument = new List<ResourceReference>((IEnumerable<ResourceReference>)q_),
				MasterFile = new List<ResourceReference>((IEnumerable<ResourceReference>)r_),
				Contact = new List<ResourceReference>((IEnumerable<ResourceReference>)s_),
				ClinicalTrial = new List<ResourceReference>((IEnumerable<ResourceReference>)t_),
				Name = new List<MedicinalProduct.NameComponent>((IEnumerable<MedicinalProduct.NameComponent>)u_),
				CrossReference = new List<Identifier>((IEnumerable<Identifier>)v_),
				ManufacturingBusinessOperation = new List<MedicinalProduct.ManufacturingBusinessOperationComponent>((IEnumerable<MedicinalProduct.ManufacturingBusinessOperationComponent>)w_),
				SpecialDesignation = new List<MedicinalProduct.SpecialDesignationComponent>((IEnumerable<MedicinalProduct.SpecialDesignationComponent>)x_),
			};

			return y_;
		};
		IEnumerable<MedicinalProduct> c_ = context.Operators.Select<MedicinalProduct, MedicinalProduct>((IEnumerable<MedicinalProduct>)a_, b_);
		MedicinalProduct d_ = context.Operators.SingletonFrom<MedicinalProduct>(c_);

		return d_;
	}

    [CqlDeclaration("MedicinalProductAuthorizationResource")]
	public MedicinalProductAuthorization MedicinalProductAuthorizationResource(MedicinalProductAuthorization arg)
	{
		MedicinalProductAuthorization[] a_ = [
			arg,
		];
		MedicinalProductAuthorization b_(MedicinalProductAuthorization a)
		{
			List<Identifier> e_ = a?.Identifier;
			ResourceReference f_ = a?.Subject;
			List<CodeableConcept> g_ = a?.Country;
			List<CodeableConcept> h_ = a?.Jurisdiction;
			CodeableConcept i_ = a?.Status;
			FhirDateTime j_ = a?.StatusDateElement;
			FhirDateTime k_ = a?.RestoreDateElement;
			Period l_ = a?.ValidityPeriod;
			Period m_ = a?.DataExclusivityPeriod;
			FhirDateTime n_ = a?.DateOfFirstAuthorizationElement;
			FhirDateTime o_ = a?.InternationalBirthDateElement;
			CodeableConcept p_ = a?.LegalBasis;
			List<MedicinalProductAuthorization.JurisdictionalAuthorizationComponent> q_ = a?.JurisdictionalAuthorization;
			ResourceReference r_ = a?.Holder;
			ResourceReference s_ = a?.Regulator;
			MedicinalProductAuthorization.ProcedureComponent t_ = a?.Procedure;
			MedicinalProductAuthorization u_ = new MedicinalProductAuthorization
			{
				Identifier = new List<Identifier>((IEnumerable<Identifier>)e_),
				Subject = f_,
				Country = new List<CodeableConcept>((IEnumerable<CodeableConcept>)g_),
				Jurisdiction = new List<CodeableConcept>((IEnumerable<CodeableConcept>)h_),
				Status = i_,
				StatusDateElement = j_,
				RestoreDateElement = k_,
				ValidityPeriod = l_,
				DataExclusivityPeriod = m_,
				DateOfFirstAuthorizationElement = n_,
				InternationalBirthDateElement = o_,
				LegalBasis = p_,
				JurisdictionalAuthorization = new List<MedicinalProductAuthorization.JurisdictionalAuthorizationComponent>((IEnumerable<MedicinalProductAuthorization.JurisdictionalAuthorizationComponent>)q_),
				Holder = r_,
				Regulator = s_,
				Procedure = t_,
			};

			return u_;
		};
		IEnumerable<MedicinalProductAuthorization> c_ = context.Operators.Select<MedicinalProductAuthorization, MedicinalProductAuthorization>((IEnumerable<MedicinalProductAuthorization>)a_, b_);
		MedicinalProductAuthorization d_ = context.Operators.SingletonFrom<MedicinalProductAuthorization>(c_);

		return d_;
	}

    [CqlDeclaration("MedicinalProductContraindicationResource")]
	public MedicinalProductContraindication MedicinalProductContraindicationResource(MedicinalProductContraindication arg)
	{
		MedicinalProductContraindication[] a_ = [
			arg,
		];
		MedicinalProductContraindication b_(MedicinalProductContraindication a)
		{
			List<ResourceReference> e_ = a?.Subject;
			CodeableConcept f_ = a?.Disease;
			CodeableConcept g_ = a?.DiseaseStatus;
			List<CodeableConcept> h_ = a?.Comorbidity;
			List<ResourceReference> i_ = a?.TherapeuticIndication;
			List<MedicinalProductContraindication.OtherTherapyComponent> j_ = a?.OtherTherapy;
			List<Population> k_ = a?.Population;
			MedicinalProductContraindication l_ = new MedicinalProductContraindication
			{
				Subject = new List<ResourceReference>((IEnumerable<ResourceReference>)e_),
				Disease = f_,
				DiseaseStatus = g_,
				Comorbidity = new List<CodeableConcept>((IEnumerable<CodeableConcept>)h_),
				TherapeuticIndication = new List<ResourceReference>((IEnumerable<ResourceReference>)i_),
				OtherTherapy = new List<MedicinalProductContraindication.OtherTherapyComponent>((IEnumerable<MedicinalProductContraindication.OtherTherapyComponent>)j_),
				Population = new List<Population>((IEnumerable<Population>)k_),
			};

			return l_;
		};
		IEnumerable<MedicinalProductContraindication> c_ = context.Operators.Select<MedicinalProductContraindication, MedicinalProductContraindication>((IEnumerable<MedicinalProductContraindication>)a_, b_);
		MedicinalProductContraindication d_ = context.Operators.SingletonFrom<MedicinalProductContraindication>(c_);

		return d_;
	}

    [CqlDeclaration("MedicinalProductIngredientResource")]
	public MedicinalProductIngredient MedicinalProductIngredientResource(MedicinalProductIngredient arg)
	{
		MedicinalProductIngredient[] a_ = [
			arg,
		];
		MedicinalProductIngredient b_(MedicinalProductIngredient a)
		{
			Identifier e_ = a?.Identifier;
			CodeableConcept f_ = a?.Role;
			FhirBoolean g_ = a?.AllergenicIndicatorElement;
			List<ResourceReference> h_ = a?.Manufacturer;
			List<MedicinalProductIngredient.SpecifiedSubstanceComponent> i_ = a?.SpecifiedSubstance;
			MedicinalProductIngredient.SubstanceComponent j_ = a?.Substance;
			MedicinalProductIngredient k_ = new MedicinalProductIngredient
			{
				Identifier = e_,
				Role = f_,
				AllergenicIndicatorElement = g_,
				Manufacturer = new List<ResourceReference>((IEnumerable<ResourceReference>)h_),
				SpecifiedSubstance = new List<MedicinalProductIngredient.SpecifiedSubstanceComponent>((IEnumerable<MedicinalProductIngredient.SpecifiedSubstanceComponent>)i_),
				Substance = j_,
			};

			return k_;
		};
		IEnumerable<MedicinalProductIngredient> c_ = context.Operators.Select<MedicinalProductIngredient, MedicinalProductIngredient>((IEnumerable<MedicinalProductIngredient>)a_, b_);
		MedicinalProductIngredient d_ = context.Operators.SingletonFrom<MedicinalProductIngredient>(c_);

		return d_;
	}

    [CqlDeclaration("MedicinalProductInteractionResource")]
	public MedicinalProductInteraction MedicinalProductInteractionResource(MedicinalProductInteraction arg)
	{
		MedicinalProductInteraction[] a_ = [
			arg,
		];
		MedicinalProductInteraction b_(MedicinalProductInteraction a)
		{
			List<ResourceReference> e_ = a?.Subject;
			FhirString f_ = a?.DescriptionElement;
			List<MedicinalProductInteraction.InteractantComponent> g_ = a?.Interactant;
			CodeableConcept h_ = a?.Type;
			CodeableConcept i_ = a?.Effect;
			CodeableConcept j_ = a?.Incidence;
			CodeableConcept k_ = a?.Management;
			MedicinalProductInteraction l_ = new MedicinalProductInteraction
			{
				Subject = new List<ResourceReference>((IEnumerable<ResourceReference>)e_),
				DescriptionElement = f_,
				Interactant = new List<MedicinalProductInteraction.InteractantComponent>((IEnumerable<MedicinalProductInteraction.InteractantComponent>)g_),
				Type = h_,
				Effect = i_,
				Incidence = j_,
				Management = k_,
			};

			return l_;
		};
		IEnumerable<MedicinalProductInteraction> c_ = context.Operators.Select<MedicinalProductInteraction, MedicinalProductInteraction>((IEnumerable<MedicinalProductInteraction>)a_, b_);
		MedicinalProductInteraction d_ = context.Operators.SingletonFrom<MedicinalProductInteraction>(c_);

		return d_;
	}

    [CqlDeclaration("MedicinalProductManufacturedResource")]
	public MedicinalProductManufactured MedicinalProductManufacturedResource(MedicinalProductManufactured arg)
	{
		MedicinalProductManufactured[] a_ = [
			arg,
		];
		MedicinalProductManufactured b_(MedicinalProductManufactured a)
		{
			CodeableConcept e_ = a?.ManufacturedDoseForm;
			CodeableConcept f_ = a?.UnitOfPresentation;
			Quantity g_ = a?.Quantity;
			List<ResourceReference> h_ = a?.Manufacturer;
			List<ResourceReference> i_ = a?.Ingredient;
			ProdCharacteristic j_ = a?.PhysicalCharacteristics;
			List<CodeableConcept> k_ = a?.OtherCharacteristics;
			MedicinalProductManufactured l_ = new MedicinalProductManufactured
			{
				ManufacturedDoseForm = e_,
				UnitOfPresentation = f_,
				Quantity = g_,
				Manufacturer = new List<ResourceReference>((IEnumerable<ResourceReference>)h_),
				Ingredient = new List<ResourceReference>((IEnumerable<ResourceReference>)i_),
				PhysicalCharacteristics = j_,
				OtherCharacteristics = new List<CodeableConcept>((IEnumerable<CodeableConcept>)k_),
			};

			return l_;
		};
		IEnumerable<MedicinalProductManufactured> c_ = context.Operators.Select<MedicinalProductManufactured, MedicinalProductManufactured>((IEnumerable<MedicinalProductManufactured>)a_, b_);
		MedicinalProductManufactured d_ = context.Operators.SingletonFrom<MedicinalProductManufactured>(c_);

		return d_;
	}

    [CqlDeclaration("MedicinalProductPackagedResource")]
	public MedicinalProductPackaged MedicinalProductPackagedResource(MedicinalProductPackaged arg)
	{
		MedicinalProductPackaged[] a_ = [
			arg,
		];
		MedicinalProductPackaged b_(MedicinalProductPackaged a)
		{
			List<Identifier> e_ = a?.Identifier;
			List<ResourceReference> f_ = a?.Subject;
			FhirString g_ = a?.DescriptionElement;
			CodeableConcept h_ = a?.LegalStatusOfSupply;
			List<MarketingStatus> i_ = a?.MarketingStatus;
			ResourceReference j_ = a?.MarketingAuthorization;
			List<ResourceReference> k_ = a?.Manufacturer;
			List<MedicinalProductPackaged.BatchIdentifierComponent> l_ = a?.BatchIdentifier;
			List<MedicinalProductPackaged.PackageItemComponent> m_ = a?.PackageItem;
			MedicinalProductPackaged n_ = new MedicinalProductPackaged
			{
				Identifier = new List<Identifier>((IEnumerable<Identifier>)e_),
				Subject = new List<ResourceReference>((IEnumerable<ResourceReference>)f_),
				DescriptionElement = g_,
				LegalStatusOfSupply = h_,
				MarketingStatus = new List<MarketingStatus>((IEnumerable<MarketingStatus>)i_),
				MarketingAuthorization = j_,
				Manufacturer = new List<ResourceReference>((IEnumerable<ResourceReference>)k_),
				BatchIdentifier = new List<MedicinalProductPackaged.BatchIdentifierComponent>((IEnumerable<MedicinalProductPackaged.BatchIdentifierComponent>)l_),
				PackageItem = new List<MedicinalProductPackaged.PackageItemComponent>((IEnumerable<MedicinalProductPackaged.PackageItemComponent>)m_),
			};

			return n_;
		};
		IEnumerable<MedicinalProductPackaged> c_ = context.Operators.Select<MedicinalProductPackaged, MedicinalProductPackaged>((IEnumerable<MedicinalProductPackaged>)a_, b_);
		MedicinalProductPackaged d_ = context.Operators.SingletonFrom<MedicinalProductPackaged>(c_);

		return d_;
	}

    [CqlDeclaration("MedicinalProductPharmaceuticalResource")]
	public MedicinalProductPharmaceutical MedicinalProductPharmaceuticalResource(MedicinalProductPharmaceutical arg)
	{
		MedicinalProductPharmaceutical[] a_ = [
			arg,
		];
		MedicinalProductPharmaceutical b_(MedicinalProductPharmaceutical a)
		{
			List<Identifier> e_ = a?.Identifier;
			CodeableConcept f_ = a?.AdministrableDoseForm;
			CodeableConcept g_ = a?.UnitOfPresentation;
			List<ResourceReference> h_ = a?.Ingredient;
			List<ResourceReference> i_ = a?.Device;
			List<MedicinalProductPharmaceutical.CharacteristicsComponent> j_ = a?.Characteristics;
			List<MedicinalProductPharmaceutical.RouteOfAdministrationComponent> k_ = a?.RouteOfAdministration;
			MedicinalProductPharmaceutical l_ = new MedicinalProductPharmaceutical
			{
				Identifier = new List<Identifier>((IEnumerable<Identifier>)e_),
				AdministrableDoseForm = f_,
				UnitOfPresentation = g_,
				Ingredient = new List<ResourceReference>((IEnumerable<ResourceReference>)h_),
				Device = new List<ResourceReference>((IEnumerable<ResourceReference>)i_),
				Characteristics = new List<MedicinalProductPharmaceutical.CharacteristicsComponent>((IEnumerable<MedicinalProductPharmaceutical.CharacteristicsComponent>)j_),
				RouteOfAdministration = new List<MedicinalProductPharmaceutical.RouteOfAdministrationComponent>((IEnumerable<MedicinalProductPharmaceutical.RouteOfAdministrationComponent>)k_),
			};

			return l_;
		};
		IEnumerable<MedicinalProductPharmaceutical> c_ = context.Operators.Select<MedicinalProductPharmaceutical, MedicinalProductPharmaceutical>((IEnumerable<MedicinalProductPharmaceutical>)a_, b_);
		MedicinalProductPharmaceutical d_ = context.Operators.SingletonFrom<MedicinalProductPharmaceutical>(c_);

		return d_;
	}

    [CqlDeclaration("MedicinalProductUndesirableEffectResource")]
	public MedicinalProductUndesirableEffect MedicinalProductUndesirableEffectResource(MedicinalProductUndesirableEffect arg)
	{
		MedicinalProductUndesirableEffect[] a_ = [
			arg,
		];
		MedicinalProductUndesirableEffect b_(MedicinalProductUndesirableEffect a)
		{
			List<ResourceReference> e_ = a?.Subject;
			CodeableConcept f_ = a?.SymptomConditionEffect;
			CodeableConcept g_ = a?.Classification;
			CodeableConcept h_ = a?.FrequencyOfOccurrence;
			List<Population> i_ = a?.Population;
			MedicinalProductUndesirableEffect j_ = new MedicinalProductUndesirableEffect
			{
				Subject = new List<ResourceReference>((IEnumerable<ResourceReference>)e_),
				SymptomConditionEffect = f_,
				Classification = g_,
				FrequencyOfOccurrence = h_,
				Population = new List<Population>((IEnumerable<Population>)i_),
			};

			return j_;
		};
		IEnumerable<MedicinalProductUndesirableEffect> c_ = context.Operators.Select<MedicinalProductUndesirableEffect, MedicinalProductUndesirableEffect>((IEnumerable<MedicinalProductUndesirableEffect>)a_, b_);
		MedicinalProductUndesirableEffect d_ = context.Operators.SingletonFrom<MedicinalProductUndesirableEffect>(c_);

		return d_;
	}

    [CqlDeclaration("MessageHeaderResource")]
	public MessageHeader MessageHeaderResource(MessageHeader arg)
	{
		MessageHeader[] a_ = [
			arg,
		];
		MessageHeader b_(MessageHeader a)
		{
			DataType e_ = a?.Event;
			List<MessageHeader.MessageDestinationComponent> f_ = a?.Destination;
			ResourceReference g_ = a?.Sender;
			ResourceReference h_ = a?.Enterer;
			ResourceReference i_ = a?.Author;
			MessageHeader.MessageSourceComponent j_ = a?.Source;
			ResourceReference k_ = a?.Responsible;
			CodeableConcept l_ = a?.Reason;
			MessageHeader.ResponseComponent m_ = a?.Response;
			List<ResourceReference> n_ = a?.Focus;
			Canonical o_ = a?.DefinitionElement;
			MessageHeader p_ = new MessageHeader
			{
				Event = (DataType)e_,
				Destination = new List<MessageHeader.MessageDestinationComponent>((IEnumerable<MessageHeader.MessageDestinationComponent>)f_),
				Sender = g_,
				Enterer = h_,
				Author = i_,
				Source = j_,
				Responsible = k_,
				Reason = l_,
				Response = m_,
				Focus = new List<ResourceReference>((IEnumerable<ResourceReference>)n_),
				DefinitionElement = o_,
			};

			return p_;
		};
		IEnumerable<MessageHeader> c_ = context.Operators.Select<MessageHeader, MessageHeader>((IEnumerable<MessageHeader>)a_, b_);
		MessageHeader d_ = context.Operators.SingletonFrom<MessageHeader>(c_);

		return d_;
	}

    [CqlDeclaration("MolecularSequenceResource")]
	public MolecularSequence MolecularSequenceResource(MolecularSequence arg)
	{
		MolecularSequence[] a_ = [
			arg,
		];
		MolecularSequence b_(MolecularSequence a)
		{
			List<Identifier> e_ = a?.Identifier;
			Code<MolecularSequence.SequenceType> f_ = a?.TypeElement;
			Integer g_ = a?.CoordinateSystemElement;
			ResourceReference h_ = a?.Patient;
			ResourceReference i_ = a?.Specimen;
			ResourceReference j_ = a?.Device;
			ResourceReference k_ = a?.Performer;
			Quantity l_ = a?.Quantity;
			MolecularSequence.ReferenceSeqComponent m_ = a?.ReferenceSeq;
			List<MolecularSequence.VariantComponent> n_ = a?.Variant;
			FhirString o_ = a?.ObservedSeqElement;
			List<MolecularSequence.QualityComponent> p_ = a?.Quality;
			Integer q_ = a?.ReadCoverageElement;
			List<MolecularSequence.RepositoryComponent> r_ = a?.Repository;
			List<ResourceReference> s_ = a?.Pointer;
			List<MolecularSequence.StructureVariantComponent> t_ = a?.StructureVariant;
			MolecularSequence u_ = new MolecularSequence
			{
				Identifier = new List<Identifier>((IEnumerable<Identifier>)e_),
				TypeElement = f_,
				CoordinateSystemElement = g_,
				Patient = h_,
				Specimen = i_,
				Device = j_,
				Performer = k_,
				Quantity = l_,
				ReferenceSeq = m_,
				Variant = new List<MolecularSequence.VariantComponent>((IEnumerable<MolecularSequence.VariantComponent>)n_),
				ObservedSeqElement = o_,
				Quality = new List<MolecularSequence.QualityComponent>((IEnumerable<MolecularSequence.QualityComponent>)p_),
				ReadCoverageElement = q_,
				Repository = new List<MolecularSequence.RepositoryComponent>((IEnumerable<MolecularSequence.RepositoryComponent>)r_),
				Pointer = new List<ResourceReference>((IEnumerable<ResourceReference>)s_),
				StructureVariant = new List<MolecularSequence.StructureVariantComponent>((IEnumerable<MolecularSequence.StructureVariantComponent>)t_),
			};

			return u_;
		};
		IEnumerable<MolecularSequence> c_ = context.Operators.Select<MolecularSequence, MolecularSequence>((IEnumerable<MolecularSequence>)a_, b_);
		MolecularSequence d_ = context.Operators.SingletonFrom<MolecularSequence>(c_);

		return d_;
	}

    [CqlDeclaration("NamingSystemResource")]
	public NamingSystem NamingSystemResource(NamingSystem arg)
	{
		NamingSystem[] a_ = [
			arg,
		];
		NamingSystem b_(NamingSystem a)
		{
			FhirString e_ = a?.NameElement;
			Code<PublicationStatus> f_ = a?.StatusElement;
			Code<NamingSystem.NamingSystemType> g_ = a?.KindElement;
			FhirDateTime h_ = a?.DateElement;
			FhirString i_ = a?.PublisherElement;
			List<ContactDetail> j_ = a?.Contact;
			FhirString k_ = a?.ResponsibleElement;
			CodeableConcept l_ = a?.Type;
			Markdown m_ = a?.DescriptionElement;
			List<UsageContext> n_ = a?.UseContext;
			List<CodeableConcept> o_ = a?.Jurisdiction;
			FhirString p_ = a?.UsageElement;
			List<NamingSystem.UniqueIdComponent> q_ = a?.UniqueId;
			NamingSystem r_ = new NamingSystem
			{
				NameElement = e_,
				StatusElement = f_,
				KindElement = g_,
				DateElement = h_,
				PublisherElement = i_,
				Contact = new List<ContactDetail>((IEnumerable<ContactDetail>)j_),
				ResponsibleElement = k_,
				Type = l_,
				DescriptionElement = m_,
				UseContext = new List<UsageContext>((IEnumerable<UsageContext>)n_),
				Jurisdiction = new List<CodeableConcept>((IEnumerable<CodeableConcept>)o_),
				UsageElement = p_,
				UniqueId = new List<NamingSystem.UniqueIdComponent>((IEnumerable<NamingSystem.UniqueIdComponent>)q_),
			};

			return r_;
		};
		IEnumerable<NamingSystem> c_ = context.Operators.Select<NamingSystem, NamingSystem>((IEnumerable<NamingSystem>)a_, b_);
		NamingSystem d_ = context.Operators.SingletonFrom<NamingSystem>(c_);

		return d_;
	}

    [CqlDeclaration("NutritionOrderResource")]
	public NutritionOrder NutritionOrderResource(NutritionOrder arg)
	{
		NutritionOrder[] a_ = [
			arg,
		];
		NutritionOrder b_(NutritionOrder a)
		{
			List<Identifier> e_ = a?.Identifier;
			List<Canonical> f_ = a?.InstantiatesCanonicalElement;
			List<FhirUri> g_ = a?.InstantiatesUriElement;
			List<FhirUri> h_ = a?.InstantiatesElement;
			Code<RequestStatus> i_ = a?.StatusElement;
			Code<RequestIntent> j_ = a?.IntentElement;
			ResourceReference k_ = a?.Patient;
			ResourceReference l_ = a?.Encounter;
			FhirDateTime m_ = a?.DateTimeElement;
			ResourceReference n_ = a?.Orderer;
			List<ResourceReference> o_ = a?.AllergyIntolerance;
			List<CodeableConcept> p_ = a?.FoodPreferenceModifier;
			List<CodeableConcept> q_ = a?.ExcludeFoodModifier;
			NutritionOrder.OralDietComponent r_ = a?.OralDiet;
			List<NutritionOrder.SupplementComponent> s_ = a?.Supplement;
			NutritionOrder.EnteralFormulaComponent t_ = a?.EnteralFormula;
			List<Annotation> u_ = a?.Note;
			NutritionOrder v_ = new NutritionOrder
			{
				Identifier = new List<Identifier>((IEnumerable<Identifier>)e_),
				InstantiatesCanonicalElement = new List<Canonical>((IEnumerable<Canonical>)f_),
				InstantiatesUriElement = new List<FhirUri>((IEnumerable<FhirUri>)g_),
				InstantiatesElement = new List<FhirUri>((IEnumerable<FhirUri>)h_),
				StatusElement = i_,
				IntentElement = j_,
				Patient = k_,
				Encounter = l_,
				DateTimeElement = m_,
				Orderer = n_,
				AllergyIntolerance = new List<ResourceReference>((IEnumerable<ResourceReference>)o_),
				FoodPreferenceModifier = new List<CodeableConcept>((IEnumerable<CodeableConcept>)p_),
				ExcludeFoodModifier = new List<CodeableConcept>((IEnumerable<CodeableConcept>)q_),
				OralDiet = r_,
				Supplement = new List<NutritionOrder.SupplementComponent>((IEnumerable<NutritionOrder.SupplementComponent>)s_),
				EnteralFormula = t_,
				Note = new List<Annotation>((IEnumerable<Annotation>)u_),
			};

			return v_;
		};
		IEnumerable<NutritionOrder> c_ = context.Operators.Select<NutritionOrder, NutritionOrder>((IEnumerable<NutritionOrder>)a_, b_);
		NutritionOrder d_ = context.Operators.SingletonFrom<NutritionOrder>(c_);

		return d_;
	}

    [CqlDeclaration("ObservationResource")]
	public Observation ObservationResource(Observation arg)
	{
		Observation[] a_ = [
			arg,
		];
		Observation b_(Observation a)
		{
			List<Identifier> e_ = a?.Identifier;
			List<ResourceReference> f_ = a?.BasedOn;
			List<ResourceReference> g_ = a?.PartOf;
			Code<ObservationStatus> h_ = a?.StatusElement;
			List<CodeableConcept> i_ = a?.Category;
			CodeableConcept j_ = a?.Code;
			ResourceReference k_ = a?.Subject;
			List<ResourceReference> l_ = a?.Focus;
			ResourceReference m_ = a?.Encounter;
			DataType n_ = a?.Effective;
			Instant o_ = a?.IssuedElement;
			List<ResourceReference> p_ = a?.Performer;
			DataType q_ = a?.Value;
			CodeableConcept r_ = a?.DataAbsentReason;
			List<CodeableConcept> s_ = a?.Interpretation;
			List<Annotation> t_ = a?.Note;
			CodeableConcept u_ = a?.BodySite;
			CodeableConcept v_ = a?.Method;
			ResourceReference w_ = a?.Specimen;
			ResourceReference x_ = a?.Device;
			List<Observation.ReferenceRangeComponent> y_ = a?.ReferenceRange;
			List<ResourceReference> z_ = a?.HasMember;
			List<ResourceReference> aa_ = a?.DerivedFrom;
			List<Observation.ComponentComponent> ab_ = a?.Component;
			Observation ac_ = new Observation
			{
				Identifier = new List<Identifier>((IEnumerable<Identifier>)e_),
				BasedOn = new List<ResourceReference>((IEnumerable<ResourceReference>)f_),
				PartOf = new List<ResourceReference>((IEnumerable<ResourceReference>)g_),
				StatusElement = h_,
				Category = new List<CodeableConcept>((IEnumerable<CodeableConcept>)i_),
				Code = j_,
				Subject = k_,
				Focus = new List<ResourceReference>((IEnumerable<ResourceReference>)l_),
				Encounter = m_,
				Effective = (DataType)n_,
				IssuedElement = o_,
				Performer = new List<ResourceReference>((IEnumerable<ResourceReference>)p_),
				Value = (DataType)q_,
				DataAbsentReason = r_,
				Interpretation = new List<CodeableConcept>((IEnumerable<CodeableConcept>)s_),
				Note = new List<Annotation>((IEnumerable<Annotation>)t_),
				BodySite = u_,
				Method = v_,
				Specimen = w_,
				Device = x_,
				ReferenceRange = new List<Observation.ReferenceRangeComponent>((IEnumerable<Observation.ReferenceRangeComponent>)y_),
				HasMember = new List<ResourceReference>((IEnumerable<ResourceReference>)z_),
				DerivedFrom = new List<ResourceReference>((IEnumerable<ResourceReference>)aa_),
				Component = new List<Observation.ComponentComponent>((IEnumerable<Observation.ComponentComponent>)ab_),
			};

			return ac_;
		};
		IEnumerable<Observation> c_ = context.Operators.Select<Observation, Observation>((IEnumerable<Observation>)a_, b_);
		Observation d_ = context.Operators.SingletonFrom<Observation>(c_);

		return d_;
	}

    [CqlDeclaration("ObservationDefinitionResource")]
	public ObservationDefinition ObservationDefinitionResource(ObservationDefinition arg)
	{
		ObservationDefinition[] a_ = [
			arg,
		];
		ObservationDefinition b_(ObservationDefinition a)
		{
			List<CodeableConcept> e_ = a?.Category;
			CodeableConcept f_ = a?.Code;
			List<Identifier> g_ = a?.Identifier;
			List<Code<ObservationDefinition.ObservationDataType>> h_ = a?.PermittedDataTypeElement;
			FhirBoolean i_ = a?.MultipleResultsAllowedElement;
			CodeableConcept j_ = a?.Method;
			FhirString k_ = a?.PreferredReportNameElement;
			ObservationDefinition.QuantitativeDetailsComponent l_ = a?.QuantitativeDetails;
			List<ObservationDefinition.QualifiedIntervalComponent> m_ = a?.QualifiedInterval;
			ResourceReference n_ = a?.ValidCodedValueSet;
			ResourceReference o_ = a?.NormalCodedValueSet;
			ResourceReference p_ = a?.AbnormalCodedValueSet;
			ResourceReference q_ = a?.CriticalCodedValueSet;
			ObservationDefinition r_ = new ObservationDefinition
			{
				Category = new List<CodeableConcept>((IEnumerable<CodeableConcept>)e_),
				Code = f_,
				Identifier = new List<Identifier>((IEnumerable<Identifier>)g_),
				PermittedDataTypeElement = new List<Code<ObservationDefinition.ObservationDataType>>((IEnumerable<Code<ObservationDefinition.ObservationDataType>>)h_),
				MultipleResultsAllowedElement = i_,
				Method = j_,
				PreferredReportNameElement = k_,
				QuantitativeDetails = l_,
				QualifiedInterval = new List<ObservationDefinition.QualifiedIntervalComponent>((IEnumerable<ObservationDefinition.QualifiedIntervalComponent>)m_),
				ValidCodedValueSet = n_,
				NormalCodedValueSet = o_,
				AbnormalCodedValueSet = p_,
				CriticalCodedValueSet = q_,
			};

			return r_;
		};
		IEnumerable<ObservationDefinition> c_ = context.Operators.Select<ObservationDefinition, ObservationDefinition>((IEnumerable<ObservationDefinition>)a_, b_);
		ObservationDefinition d_ = context.Operators.SingletonFrom<ObservationDefinition>(c_);

		return d_;
	}

    [CqlDeclaration("OperationOutcomeResource")]
	public OperationOutcome OperationOutcomeResource(OperationOutcome arg)
	{
		OperationOutcome[] a_ = [
			arg,
		];
		OperationOutcome b_(OperationOutcome a)
		{
			List<OperationOutcome.IssueComponent> e_ = a?.Issue;
			OperationOutcome f_ = new OperationOutcome
			{
				Issue = new List<OperationOutcome.IssueComponent>((IEnumerable<OperationOutcome.IssueComponent>)e_),
			};

			return f_;
		};
		IEnumerable<OperationOutcome> c_ = context.Operators.Select<OperationOutcome, OperationOutcome>((IEnumerable<OperationOutcome>)a_, b_);
		OperationOutcome d_ = context.Operators.SingletonFrom<OperationOutcome>(c_);

		return d_;
	}

    [CqlDeclaration("OrganizationResource")]
	public Organization OrganizationResource(Organization arg)
	{
		Organization[] a_ = [
			arg,
		];
		Organization b_(Organization a)
		{
			List<Identifier> e_ = a?.Identifier;
			FhirBoolean f_ = a?.ActiveElement;
			List<CodeableConcept> g_ = a?.Type;
			FhirString h_ = a?.NameElement;
			List<FhirString> i_ = a?.AliasElement;
			List<ContactPoint> j_ = a?.Telecom;
			List<Address> k_ = a?.Address;
			ResourceReference l_ = a?.PartOf;
			List<Organization.ContactComponent> m_ = a?.Contact;
			List<ResourceReference> n_ = a?.Endpoint;
			Organization o_ = new Organization
			{
				Identifier = new List<Identifier>((IEnumerable<Identifier>)e_),
				ActiveElement = f_,
				Type = new List<CodeableConcept>((IEnumerable<CodeableConcept>)g_),
				NameElement = h_,
				AliasElement = new List<FhirString>((IEnumerable<FhirString>)i_),
				Telecom = new List<ContactPoint>((IEnumerable<ContactPoint>)j_),
				Address = new List<Address>((IEnumerable<Address>)k_),
				PartOf = l_,
				Contact = new List<Organization.ContactComponent>((IEnumerable<Organization.ContactComponent>)m_),
				Endpoint = new List<ResourceReference>((IEnumerable<ResourceReference>)n_),
			};

			return o_;
		};
		IEnumerable<Organization> c_ = context.Operators.Select<Organization, Organization>((IEnumerable<Organization>)a_, b_);
		Organization d_ = context.Operators.SingletonFrom<Organization>(c_);

		return d_;
	}

    [CqlDeclaration("OrganizationAffiliationResource")]
	public OrganizationAffiliation OrganizationAffiliationResource(OrganizationAffiliation arg)
	{
		OrganizationAffiliation[] a_ = [
			arg,
		];
		OrganizationAffiliation b_(OrganizationAffiliation a)
		{
			List<Identifier> e_ = a?.Identifier;
			FhirBoolean f_ = a?.ActiveElement;
			Period g_ = a?.Period;
			ResourceReference h_ = a?.Organization;
			ResourceReference i_ = a?.ParticipatingOrganization;
			List<ResourceReference> j_ = a?.Network;
			List<CodeableConcept> k_ = a?.Code;
			List<CodeableConcept> l_ = a?.Specialty;
			List<ResourceReference> m_ = a?.Location;
			List<ResourceReference> n_ = a?.HealthcareService;
			List<ContactPoint> o_ = a?.Telecom;
			List<ResourceReference> p_ = a?.Endpoint;
			OrganizationAffiliation q_ = new OrganizationAffiliation
			{
				Identifier = new List<Identifier>((IEnumerable<Identifier>)e_),
				ActiveElement = f_,
				Period = g_,
				Organization = h_,
				ParticipatingOrganization = i_,
				Network = new List<ResourceReference>((IEnumerable<ResourceReference>)j_),
				Code = new List<CodeableConcept>((IEnumerable<CodeableConcept>)k_),
				Specialty = new List<CodeableConcept>((IEnumerable<CodeableConcept>)l_),
				Location = new List<ResourceReference>((IEnumerable<ResourceReference>)m_),
				HealthcareService = new List<ResourceReference>((IEnumerable<ResourceReference>)n_),
				Telecom = new List<ContactPoint>((IEnumerable<ContactPoint>)o_),
				Endpoint = new List<ResourceReference>((IEnumerable<ResourceReference>)p_),
			};

			return q_;
		};
		IEnumerable<OrganizationAffiliation> c_ = context.Operators.Select<OrganizationAffiliation, OrganizationAffiliation>((IEnumerable<OrganizationAffiliation>)a_, b_);
		OrganizationAffiliation d_ = context.Operators.SingletonFrom<OrganizationAffiliation>(c_);

		return d_;
	}

    [CqlDeclaration("PatientResource")]
	public Patient PatientResource(Patient arg)
	{
		Patient[] a_ = [
			arg,
		];
		Patient b_(Patient a)
		{
			List<Identifier> e_ = a?.Identifier;
			FhirBoolean f_ = a?.ActiveElement;
			List<HumanName> g_ = a?.Name;
			List<ContactPoint> h_ = a?.Telecom;
			Code<AdministrativeGender> i_ = a?.GenderElement;
			Date j_ = a?.BirthDateElement;
			DataType k_ = a?.Deceased;
			List<Address> l_ = a?.Address;
			CodeableConcept m_ = a?.MaritalStatus;
			DataType n_ = a?.MultipleBirth;
			List<Attachment> o_ = a?.Photo;
			List<Patient.ContactComponent> p_ = a?.Contact;
			List<Patient.CommunicationComponent> q_ = a?.Communication;
			List<ResourceReference> r_ = a?.GeneralPractitioner;
			ResourceReference s_ = a?.ManagingOrganization;
			List<Patient.LinkComponent> t_ = a?.Link;
			Patient u_ = new Patient
			{
				Identifier = new List<Identifier>((IEnumerable<Identifier>)e_),
				ActiveElement = f_,
				Name = new List<HumanName>((IEnumerable<HumanName>)g_),
				Telecom = new List<ContactPoint>((IEnumerable<ContactPoint>)h_),
				GenderElement = i_,
				BirthDateElement = j_,
				Deceased = (DataType)k_,
				Address = new List<Address>((IEnumerable<Address>)l_),
				MaritalStatus = m_,
				MultipleBirth = (DataType)n_,
				Photo = new List<Attachment>((IEnumerable<Attachment>)o_),
				Contact = new List<Patient.ContactComponent>((IEnumerable<Patient.ContactComponent>)p_),
				Communication = new List<Patient.CommunicationComponent>((IEnumerable<Patient.CommunicationComponent>)q_),
				GeneralPractitioner = new List<ResourceReference>((IEnumerable<ResourceReference>)r_),
				ManagingOrganization = s_,
				Link = new List<Patient.LinkComponent>((IEnumerable<Patient.LinkComponent>)t_),
			};

			return u_;
		};
		IEnumerable<Patient> c_ = context.Operators.Select<Patient, Patient>((IEnumerable<Patient>)a_, b_);
		Patient d_ = context.Operators.SingletonFrom<Patient>(c_);

		return d_;
	}

    [CqlDeclaration("PaymentNoticeResource")]
	public PaymentNotice PaymentNoticeResource(PaymentNotice arg)
	{
		PaymentNotice[] a_ = [
			arg,
		];
		PaymentNotice b_(PaymentNotice a)
		{
			List<Identifier> e_ = a?.Identifier;
			Code<FinancialResourceStatusCodes> f_ = a?.StatusElement;
			ResourceReference g_ = a?.Request;
			ResourceReference h_ = a?.Response;
			FhirDateTime i_ = a?.CreatedElement;
			ResourceReference j_ = a?.Provider;
			ResourceReference k_ = a?.Payment;
			Date l_ = a?.PaymentDateElement;
			ResourceReference m_ = a?.Payee;
			ResourceReference n_ = a?.Recipient;
			Money o_ = a?.Amount;
			CodeableConcept p_ = a?.PaymentStatus;
			PaymentNotice q_ = new PaymentNotice
			{
				Identifier = new List<Identifier>((IEnumerable<Identifier>)e_),
				StatusElement = f_,
				Request = g_,
				Response = h_,
				CreatedElement = i_,
				Provider = j_,
				Payment = k_,
				PaymentDateElement = l_,
				Payee = m_,
				Recipient = n_,
				Amount = o_,
				PaymentStatus = p_,
			};

			return q_;
		};
		IEnumerable<PaymentNotice> c_ = context.Operators.Select<PaymentNotice, PaymentNotice>((IEnumerable<PaymentNotice>)a_, b_);
		PaymentNotice d_ = context.Operators.SingletonFrom<PaymentNotice>(c_);

		return d_;
	}

    [CqlDeclaration("PaymentReconciliationResource")]
	public PaymentReconciliation PaymentReconciliationResource(PaymentReconciliation arg)
	{
		PaymentReconciliation[] a_ = [
			arg,
		];
		PaymentReconciliation b_(PaymentReconciliation a)
		{
			List<Identifier> e_ = a?.Identifier;
			Code<FinancialResourceStatusCodes> f_ = a?.StatusElement;
			Period g_ = a?.Period;
			FhirDateTime h_ = a?.CreatedElement;
			ResourceReference i_ = a?.PaymentIssuer;
			ResourceReference j_ = a?.Request;
			ResourceReference k_ = a?.Requestor;
			Code<ClaimProcessingCodes> l_ = a?.OutcomeElement;
			FhirString m_ = a?.DispositionElement;
			Date n_ = a?.PaymentDateElement;
			Money o_ = a?.PaymentAmount;
			Identifier p_ = a?.PaymentIdentifier;
			List<PaymentReconciliation.DetailsComponent> q_ = a?.Detail;
			CodeableConcept r_ = a?.FormCode;
			List<PaymentReconciliation.NotesComponent> s_ = a?.ProcessNote;
			PaymentReconciliation t_ = new PaymentReconciliation
			{
				Identifier = new List<Identifier>((IEnumerable<Identifier>)e_),
				StatusElement = f_,
				Period = g_,
				CreatedElement = h_,
				PaymentIssuer = i_,
				Request = j_,
				Requestor = k_,
				OutcomeElement = l_,
				DispositionElement = m_,
				PaymentDateElement = n_,
				PaymentAmount = o_,
				PaymentIdentifier = p_,
				Detail = new List<PaymentReconciliation.DetailsComponent>((IEnumerable<PaymentReconciliation.DetailsComponent>)q_),
				FormCode = r_,
				ProcessNote = new List<PaymentReconciliation.NotesComponent>((IEnumerable<PaymentReconciliation.NotesComponent>)s_),
			};

			return t_;
		};
		IEnumerable<PaymentReconciliation> c_ = context.Operators.Select<PaymentReconciliation, PaymentReconciliation>((IEnumerable<PaymentReconciliation>)a_, b_);
		PaymentReconciliation d_ = context.Operators.SingletonFrom<PaymentReconciliation>(c_);

		return d_;
	}

    [CqlDeclaration("PersonResource")]
	public Person PersonResource(Person arg)
	{
		Person[] a_ = [
			arg,
		];
		Person b_(Person a)
		{
			List<Identifier> e_ = a?.Identifier;
			List<HumanName> f_ = a?.Name;
			List<ContactPoint> g_ = a?.Telecom;
			Code<AdministrativeGender> h_ = a?.GenderElement;
			Date i_ = a?.BirthDateElement;
			List<Address> j_ = a?.Address;
			Attachment k_ = a?.Photo;
			ResourceReference l_ = a?.ManagingOrganization;
			FhirBoolean m_ = a?.ActiveElement;
			List<Person.LinkComponent> n_ = a?.Link;
			Person o_ = new Person
			{
				Identifier = new List<Identifier>((IEnumerable<Identifier>)e_),
				Name = new List<HumanName>((IEnumerable<HumanName>)f_),
				Telecom = new List<ContactPoint>((IEnumerable<ContactPoint>)g_),
				GenderElement = h_,
				BirthDateElement = i_,
				Address = new List<Address>((IEnumerable<Address>)j_),
				Photo = k_,
				ManagingOrganization = l_,
				ActiveElement = m_,
				Link = new List<Person.LinkComponent>((IEnumerable<Person.LinkComponent>)n_),
			};

			return o_;
		};
		IEnumerable<Person> c_ = context.Operators.Select<Person, Person>((IEnumerable<Person>)a_, b_);
		Person d_ = context.Operators.SingletonFrom<Person>(c_);

		return d_;
	}

    [CqlDeclaration("PlanDefinitionResource")]
	public PlanDefinition PlanDefinitionResource(PlanDefinition arg)
	{
		PlanDefinition[] a_ = [
			arg,
		];
		PlanDefinition b_(PlanDefinition a)
		{
			FhirUri e_ = a?.UrlElement;
			List<Identifier> f_ = a?.Identifier;
			FhirString g_ = a?.VersionElement;
			FhirString h_ = a?.NameElement;
			FhirString i_ = a?.TitleElement;
			FhirString j_ = a?.SubtitleElement;
			CodeableConcept k_ = a?.Type;
			Code<PublicationStatus> l_ = a?.StatusElement;
			FhirBoolean m_ = a?.ExperimentalElement;
			DataType n_ = a?.Subject;
			FhirDateTime o_ = a?.DateElement;
			FhirString p_ = a?.PublisherElement;
			List<ContactDetail> q_ = a?.Contact;
			Markdown r_ = a?.DescriptionElement;
			List<UsageContext> s_ = a?.UseContext;
			List<CodeableConcept> t_ = a?.Jurisdiction;
			Markdown u_ = a?.PurposeElement;
			FhirString v_ = a?.UsageElement;
			Markdown w_ = a?.CopyrightElement;
			Date x_ = a?.ApprovalDateElement;
			Date y_ = a?.LastReviewDateElement;
			Period z_ = a?.EffectivePeriod;
			List<CodeableConcept> aa_ = a?.Topic;
			List<ContactDetail> ab_ = a?.Author;
			List<ContactDetail> ac_ = a?.Editor;
			List<ContactDetail> ad_ = a?.Reviewer;
			List<ContactDetail> ae_ = a?.Endorser;
			List<RelatedArtifact> af_ = a?.RelatedArtifact;
			List<Canonical> ag_ = a?.LibraryElement;
			List<PlanDefinition.GoalComponent> ah_ = a?.Goal;
			List<PlanDefinition.ActionComponent> ai_ = a?.Action;
			PlanDefinition aj_ = new PlanDefinition
			{
				UrlElement = e_,
				Identifier = new List<Identifier>((IEnumerable<Identifier>)f_),
				VersionElement = g_,
				NameElement = h_,
				TitleElement = i_,
				SubtitleElement = j_,
				Type = k_,
				StatusElement = l_,
				ExperimentalElement = m_,
				Subject = (DataType)n_,
				DateElement = o_,
				PublisherElement = p_,
				Contact = new List<ContactDetail>((IEnumerable<ContactDetail>)q_),
				DescriptionElement = r_,
				UseContext = new List<UsageContext>((IEnumerable<UsageContext>)s_),
				Jurisdiction = new List<CodeableConcept>((IEnumerable<CodeableConcept>)t_),
				PurposeElement = u_,
				UsageElement = v_,
				CopyrightElement = w_,
				ApprovalDateElement = x_,
				LastReviewDateElement = y_,
				EffectivePeriod = z_,
				Topic = new List<CodeableConcept>((IEnumerable<CodeableConcept>)aa_),
				Author = new List<ContactDetail>((IEnumerable<ContactDetail>)ab_),
				Editor = new List<ContactDetail>((IEnumerable<ContactDetail>)ac_),
				Reviewer = new List<ContactDetail>((IEnumerable<ContactDetail>)ad_),
				Endorser = new List<ContactDetail>((IEnumerable<ContactDetail>)ae_),
				RelatedArtifact = new List<RelatedArtifact>((IEnumerable<RelatedArtifact>)af_),
				LibraryElement = new List<Canonical>((IEnumerable<Canonical>)ag_),
				Goal = new List<PlanDefinition.GoalComponent>((IEnumerable<PlanDefinition.GoalComponent>)ah_),
				Action = new List<PlanDefinition.ActionComponent>((IEnumerable<PlanDefinition.ActionComponent>)ai_),
			};

			return aj_;
		};
		IEnumerable<PlanDefinition> c_ = context.Operators.Select<PlanDefinition, PlanDefinition>((IEnumerable<PlanDefinition>)a_, b_);
		PlanDefinition d_ = context.Operators.SingletonFrom<PlanDefinition>(c_);

		return d_;
	}

    [CqlDeclaration("PractitionerResource")]
	public Practitioner PractitionerResource(Practitioner arg)
	{
		Practitioner[] a_ = [
			arg,
		];
		Practitioner b_(Practitioner a)
		{
			List<Identifier> e_ = a?.Identifier;
			FhirBoolean f_ = a?.ActiveElement;
			List<HumanName> g_ = a?.Name;
			List<ContactPoint> h_ = a?.Telecom;
			List<Address> i_ = a?.Address;
			Code<AdministrativeGender> j_ = a?.GenderElement;
			Date k_ = a?.BirthDateElement;
			List<Attachment> l_ = a?.Photo;
			List<Practitioner.QualificationComponent> m_ = a?.Qualification;
			List<CodeableConcept> n_ = a?.Communication;
			Practitioner o_ = new Practitioner
			{
				Identifier = new List<Identifier>((IEnumerable<Identifier>)e_),
				ActiveElement = f_,
				Name = new List<HumanName>((IEnumerable<HumanName>)g_),
				Telecom = new List<ContactPoint>((IEnumerable<ContactPoint>)h_),
				Address = new List<Address>((IEnumerable<Address>)i_),
				GenderElement = j_,
				BirthDateElement = k_,
				Photo = new List<Attachment>((IEnumerable<Attachment>)l_),
				Qualification = new List<Practitioner.QualificationComponent>((IEnumerable<Practitioner.QualificationComponent>)m_),
				Communication = new List<CodeableConcept>((IEnumerable<CodeableConcept>)n_),
			};

			return o_;
		};
		IEnumerable<Practitioner> c_ = context.Operators.Select<Practitioner, Practitioner>((IEnumerable<Practitioner>)a_, b_);
		Practitioner d_ = context.Operators.SingletonFrom<Practitioner>(c_);

		return d_;
	}

    [CqlDeclaration("PractitionerRoleResource")]
	public PractitionerRole PractitionerRoleResource(PractitionerRole arg)
	{
		PractitionerRole[] a_ = [
			arg,
		];
		PractitionerRole b_(PractitionerRole a)
		{
			List<Identifier> e_ = a?.Identifier;
			FhirBoolean f_ = a?.ActiveElement;
			Period g_ = a?.Period;
			ResourceReference h_ = a?.Practitioner;
			ResourceReference i_ = a?.Organization;
			List<CodeableConcept> j_ = a?.Code;
			List<CodeableConcept> k_ = a?.Specialty;
			List<ResourceReference> l_ = a?.Location;
			List<ResourceReference> m_ = a?.HealthcareService;
			List<ContactPoint> n_ = a?.Telecom;
			List<PractitionerRole.AvailableTimeComponent> o_ = a?.AvailableTime;
			List<PractitionerRole.NotAvailableComponent> p_ = a?.NotAvailable;
			FhirString q_ = a?.AvailabilityExceptionsElement;
			List<ResourceReference> r_ = a?.Endpoint;
			PractitionerRole s_ = new PractitionerRole
			{
				Identifier = new List<Identifier>((IEnumerable<Identifier>)e_),
				ActiveElement = f_,
				Period = g_,
				Practitioner = h_,
				Organization = i_,
				Code = new List<CodeableConcept>((IEnumerable<CodeableConcept>)j_),
				Specialty = new List<CodeableConcept>((IEnumerable<CodeableConcept>)k_),
				Location = new List<ResourceReference>((IEnumerable<ResourceReference>)l_),
				HealthcareService = new List<ResourceReference>((IEnumerable<ResourceReference>)m_),
				Telecom = new List<ContactPoint>((IEnumerable<ContactPoint>)n_),
				AvailableTime = new List<PractitionerRole.AvailableTimeComponent>((IEnumerable<PractitionerRole.AvailableTimeComponent>)o_),
				NotAvailable = new List<PractitionerRole.NotAvailableComponent>((IEnumerable<PractitionerRole.NotAvailableComponent>)p_),
				AvailabilityExceptionsElement = q_,
				Endpoint = new List<ResourceReference>((IEnumerable<ResourceReference>)r_),
			};

			return s_;
		};
		IEnumerable<PractitionerRole> c_ = context.Operators.Select<PractitionerRole, PractitionerRole>((IEnumerable<PractitionerRole>)a_, b_);
		PractitionerRole d_ = context.Operators.SingletonFrom<PractitionerRole>(c_);

		return d_;
	}

    [CqlDeclaration("ProcedureResource")]
	public Procedure ProcedureResource(Procedure arg)
	{
		Procedure[] a_ = [
			arg,
		];
		Procedure b_(Procedure a)
		{
			List<Identifier> e_ = a?.Identifier;
			List<Canonical> f_ = a?.InstantiatesCanonicalElement;
			List<FhirUri> g_ = a?.InstantiatesUriElement;
			List<ResourceReference> h_ = a?.BasedOn;
			List<ResourceReference> i_ = a?.PartOf;
			Code<EventStatus> j_ = a?.StatusElement;
			CodeableConcept k_ = a?.StatusReason;
			CodeableConcept l_ = a?.Category;
			CodeableConcept m_ = a?.Code;
			ResourceReference n_ = a?.Subject;
			ResourceReference o_ = a?.Encounter;
			DataType p_ = a?.Performed;
			ResourceReference q_ = a?.Recorder;
			ResourceReference r_ = a?.Asserter;
			List<Procedure.PerformerComponent> s_ = a?.Performer;
			ResourceReference t_ = a?.Location;
			List<CodeableConcept> u_ = a?.ReasonCode;
			List<ResourceReference> v_ = a?.ReasonReference;
			List<CodeableConcept> w_ = a?.BodySite;
			CodeableConcept x_ = a?.Outcome;
			List<ResourceReference> y_ = a?.Report;
			List<CodeableConcept> z_ = a?.Complication;
			List<ResourceReference> aa_ = a?.ComplicationDetail;
			List<CodeableConcept> ab_ = a?.FollowUp;
			List<Annotation> ac_ = a?.Note;
			List<Procedure.FocalDeviceComponent> ad_ = a?.FocalDevice;
			List<ResourceReference> ae_ = a?.UsedReference;
			List<CodeableConcept> af_ = a?.UsedCode;
			Procedure ag_ = new Procedure
			{
				Identifier = new List<Identifier>((IEnumerable<Identifier>)e_),
				InstantiatesCanonicalElement = new List<Canonical>((IEnumerable<Canonical>)f_),
				InstantiatesUriElement = new List<FhirUri>((IEnumerable<FhirUri>)g_),
				BasedOn = new List<ResourceReference>((IEnumerable<ResourceReference>)h_),
				PartOf = new List<ResourceReference>((IEnumerable<ResourceReference>)i_),
				StatusElement = j_,
				StatusReason = k_,
				Category = l_,
				Code = m_,
				Subject = n_,
				Encounter = o_,
				Performed = (DataType)p_,
				Recorder = q_,
				Asserter = r_,
				Performer = new List<Procedure.PerformerComponent>((IEnumerable<Procedure.PerformerComponent>)s_),
				Location = t_,
				ReasonCode = new List<CodeableConcept>((IEnumerable<CodeableConcept>)u_),
				ReasonReference = new List<ResourceReference>((IEnumerable<ResourceReference>)v_),
				BodySite = new List<CodeableConcept>((IEnumerable<CodeableConcept>)w_),
				Outcome = x_,
				Report = new List<ResourceReference>((IEnumerable<ResourceReference>)y_),
				Complication = new List<CodeableConcept>((IEnumerable<CodeableConcept>)z_),
				ComplicationDetail = new List<ResourceReference>((IEnumerable<ResourceReference>)aa_),
				FollowUp = new List<CodeableConcept>((IEnumerable<CodeableConcept>)ab_),
				Note = new List<Annotation>((IEnumerable<Annotation>)ac_),
				FocalDevice = new List<Procedure.FocalDeviceComponent>((IEnumerable<Procedure.FocalDeviceComponent>)ad_),
				UsedReference = new List<ResourceReference>((IEnumerable<ResourceReference>)ae_),
				UsedCode = new List<CodeableConcept>((IEnumerable<CodeableConcept>)af_),
			};

			return ag_;
		};
		IEnumerable<Procedure> c_ = context.Operators.Select<Procedure, Procedure>((IEnumerable<Procedure>)a_, b_);
		Procedure d_ = context.Operators.SingletonFrom<Procedure>(c_);

		return d_;
	}

    [CqlDeclaration("ProvenanceResource")]
	public Provenance ProvenanceResource(Provenance arg)
	{
		Provenance[] a_ = [
			arg,
		];
		Provenance b_(Provenance a)
		{
			List<ResourceReference> e_ = a?.Target;
			DataType f_ = a?.Occurred;
			Instant g_ = a?.RecordedElement;
			List<FhirUri> h_ = a?.PolicyElement;
			ResourceReference i_ = a?.Location;
			List<CodeableConcept> j_ = a?.Reason;
			CodeableConcept k_ = a?.Activity;
			List<Provenance.AgentComponent> l_ = a?.Agent;
			List<Provenance.EntityComponent> m_ = a?.Entity;
			List<Signature> n_ = a?.Signature;
			Provenance o_ = new Provenance
			{
				Target = new List<ResourceReference>((IEnumerable<ResourceReference>)e_),
				Occurred = (DataType)f_,
				RecordedElement = g_,
				PolicyElement = new List<FhirUri>((IEnumerable<FhirUri>)h_),
				Location = i_,
				Reason = new List<CodeableConcept>((IEnumerable<CodeableConcept>)j_),
				Activity = k_,
				Agent = new List<Provenance.AgentComponent>((IEnumerable<Provenance.AgentComponent>)l_),
				Entity = new List<Provenance.EntityComponent>((IEnumerable<Provenance.EntityComponent>)m_),
				Signature = new List<Signature>((IEnumerable<Signature>)n_),
			};

			return o_;
		};
		IEnumerable<Provenance> c_ = context.Operators.Select<Provenance, Provenance>((IEnumerable<Provenance>)a_, b_);
		Provenance d_ = context.Operators.SingletonFrom<Provenance>(c_);

		return d_;
	}

    [CqlDeclaration("QuestionnaireResponseResource")]
	public QuestionnaireResponse QuestionnaireResponseResource(QuestionnaireResponse arg)
	{
		QuestionnaireResponse[] a_ = [
			arg,
		];
		QuestionnaireResponse b_(QuestionnaireResponse a)
		{
			Identifier e_ = a?.Identifier;
			List<ResourceReference> f_ = a?.BasedOn;
			List<ResourceReference> g_ = a?.PartOf;
			Canonical h_ = a?.QuestionnaireElement;
			Code<QuestionnaireResponse.QuestionnaireResponseStatus> i_ = a?.StatusElement;
			ResourceReference j_ = a?.Subject;
			ResourceReference k_ = a?.Encounter;
			FhirDateTime l_ = a?.AuthoredElement;
			ResourceReference m_ = a?.Author;
			ResourceReference n_ = a?.Source;
			List<QuestionnaireResponse.ItemComponent> o_ = a?.Item;
			QuestionnaireResponse p_ = new QuestionnaireResponse
			{
				Identifier = e_,
				BasedOn = new List<ResourceReference>((IEnumerable<ResourceReference>)f_),
				PartOf = new List<ResourceReference>((IEnumerable<ResourceReference>)g_),
				QuestionnaireElement = h_,
				StatusElement = i_,
				Subject = j_,
				Encounter = k_,
				AuthoredElement = l_,
				Author = m_,
				Source = n_,
				Item = new List<QuestionnaireResponse.ItemComponent>((IEnumerable<QuestionnaireResponse.ItemComponent>)o_),
			};

			return p_;
		};
		IEnumerable<QuestionnaireResponse> c_ = context.Operators.Select<QuestionnaireResponse, QuestionnaireResponse>((IEnumerable<QuestionnaireResponse>)a_, b_);
		QuestionnaireResponse d_ = context.Operators.SingletonFrom<QuestionnaireResponse>(c_);

		return d_;
	}

    [CqlDeclaration("RelatedPersonResource")]
	public RelatedPerson RelatedPersonResource(RelatedPerson arg)
	{
		RelatedPerson[] a_ = [
			arg,
		];
		RelatedPerson b_(RelatedPerson a)
		{
			List<Identifier> e_ = a?.Identifier;
			FhirBoolean f_ = a?.ActiveElement;
			ResourceReference g_ = a?.Patient;
			List<CodeableConcept> h_ = a?.Relationship;
			List<HumanName> i_ = a?.Name;
			List<ContactPoint> j_ = a?.Telecom;
			Code<AdministrativeGender> k_ = a?.GenderElement;
			Date l_ = a?.BirthDateElement;
			List<Address> m_ = a?.Address;
			List<Attachment> n_ = a?.Photo;
			Period o_ = a?.Period;
			List<RelatedPerson.CommunicationComponent> p_ = a?.Communication;
			RelatedPerson q_ = new RelatedPerson
			{
				Identifier = new List<Identifier>((IEnumerable<Identifier>)e_),
				ActiveElement = f_,
				Patient = g_,
				Relationship = new List<CodeableConcept>((IEnumerable<CodeableConcept>)h_),
				Name = new List<HumanName>((IEnumerable<HumanName>)i_),
				Telecom = new List<ContactPoint>((IEnumerable<ContactPoint>)j_),
				GenderElement = k_,
				BirthDateElement = l_,
				Address = new List<Address>((IEnumerable<Address>)m_),
				Photo = new List<Attachment>((IEnumerable<Attachment>)n_),
				Period = o_,
				Communication = new List<RelatedPerson.CommunicationComponent>((IEnumerable<RelatedPerson.CommunicationComponent>)p_),
			};

			return q_;
		};
		IEnumerable<RelatedPerson> c_ = context.Operators.Select<RelatedPerson, RelatedPerson>((IEnumerable<RelatedPerson>)a_, b_);
		RelatedPerson d_ = context.Operators.SingletonFrom<RelatedPerson>(c_);

		return d_;
	}

    [CqlDeclaration("RequestGroupResource")]
	public RequestGroup RequestGroupResource(RequestGroup arg)
	{
		RequestGroup[] a_ = [
			arg,
		];
		RequestGroup b_(RequestGroup a)
		{
			List<Identifier> e_ = a?.Identifier;
			List<Canonical> f_ = a?.InstantiatesCanonicalElement;
			List<FhirUri> g_ = a?.InstantiatesUriElement;
			List<ResourceReference> h_ = a?.BasedOn;
			List<ResourceReference> i_ = a?.Replaces;
			Identifier j_ = a?.GroupIdentifier;
			Code<RequestStatus> k_ = a?.StatusElement;
			Code<RequestIntent> l_ = a?.IntentElement;
			Code<RequestPriority> m_ = a?.PriorityElement;
			CodeableConcept n_ = a?.Code;
			ResourceReference o_ = a?.Subject;
			ResourceReference p_ = a?.Encounter;
			FhirDateTime q_ = a?.AuthoredOnElement;
			ResourceReference r_ = a?.Author;
			List<CodeableConcept> s_ = a?.ReasonCode;
			List<ResourceReference> t_ = a?.ReasonReference;
			List<Annotation> u_ = a?.Note;
			List<RequestGroup.ActionComponent> v_ = a?.Action;
			RequestGroup w_ = new RequestGroup
			{
				Identifier = new List<Identifier>((IEnumerable<Identifier>)e_),
				InstantiatesCanonicalElement = new List<Canonical>((IEnumerable<Canonical>)f_),
				InstantiatesUriElement = new List<FhirUri>((IEnumerable<FhirUri>)g_),
				BasedOn = new List<ResourceReference>((IEnumerable<ResourceReference>)h_),
				Replaces = new List<ResourceReference>((IEnumerable<ResourceReference>)i_),
				GroupIdentifier = j_,
				StatusElement = k_,
				IntentElement = l_,
				PriorityElement = m_,
				Code = n_,
				Subject = o_,
				Encounter = p_,
				AuthoredOnElement = q_,
				Author = r_,
				ReasonCode = new List<CodeableConcept>((IEnumerable<CodeableConcept>)s_),
				ReasonReference = new List<ResourceReference>((IEnumerable<ResourceReference>)t_),
				Note = new List<Annotation>((IEnumerable<Annotation>)u_),
				Action = new List<RequestGroup.ActionComponent>((IEnumerable<RequestGroup.ActionComponent>)v_),
			};

			return w_;
		};
		IEnumerable<RequestGroup> c_ = context.Operators.Select<RequestGroup, RequestGroup>((IEnumerable<RequestGroup>)a_, b_);
		RequestGroup d_ = context.Operators.SingletonFrom<RequestGroup>(c_);

		return d_;
	}

    [CqlDeclaration("ResearchDefinitionResource")]
	public ResearchDefinition ResearchDefinitionResource(ResearchDefinition arg)
	{
		ResearchDefinition[] a_ = [
			arg,
		];
		ResearchDefinition b_(ResearchDefinition a)
		{
			FhirUri e_ = a?.UrlElement;
			List<Identifier> f_ = a?.Identifier;
			FhirString g_ = a?.VersionElement;
			FhirString h_ = a?.NameElement;
			FhirString i_ = a?.TitleElement;
			FhirString j_ = a?.ShortTitleElement;
			FhirString k_ = a?.SubtitleElement;
			Code<PublicationStatus> l_ = a?.StatusElement;
			FhirBoolean m_ = a?.ExperimentalElement;
			DataType n_ = a?.Subject;
			FhirDateTime o_ = a?.DateElement;
			FhirString p_ = a?.PublisherElement;
			List<ContactDetail> q_ = a?.Contact;
			Markdown r_ = a?.DescriptionElement;
			List<FhirString> s_ = a?.CommentElement;
			List<UsageContext> t_ = a?.UseContext;
			List<CodeableConcept> u_ = a?.Jurisdiction;
			Markdown v_ = a?.PurposeElement;
			FhirString w_ = a?.UsageElement;
			Markdown x_ = a?.CopyrightElement;
			Date y_ = a?.ApprovalDateElement;
			Date z_ = a?.LastReviewDateElement;
			Period aa_ = a?.EffectivePeriod;
			List<CodeableConcept> ab_ = a?.Topic;
			List<ContactDetail> ac_ = a?.Author;
			List<ContactDetail> ad_ = a?.Editor;
			List<ContactDetail> ae_ = a?.Reviewer;
			List<ContactDetail> af_ = a?.Endorser;
			List<RelatedArtifact> ag_ = a?.RelatedArtifact;
			List<Canonical> ah_ = a?.LibraryElement;
			ResourceReference ai_ = a?.Population;
			ResourceReference aj_ = a?.Exposure;
			ResourceReference ak_ = a?.ExposureAlternative;
			ResourceReference al_ = a?.Outcome;
			ResearchDefinition am_ = new ResearchDefinition
			{
				UrlElement = e_,
				Identifier = new List<Identifier>((IEnumerable<Identifier>)f_),
				VersionElement = g_,
				NameElement = h_,
				TitleElement = i_,
				ShortTitleElement = j_,
				SubtitleElement = k_,
				StatusElement = l_,
				ExperimentalElement = m_,
				Subject = (DataType)n_,
				DateElement = o_,
				PublisherElement = p_,
				Contact = new List<ContactDetail>((IEnumerable<ContactDetail>)q_),
				DescriptionElement = r_,
				CommentElement = new List<FhirString>((IEnumerable<FhirString>)s_),
				UseContext = new List<UsageContext>((IEnumerable<UsageContext>)t_),
				Jurisdiction = new List<CodeableConcept>((IEnumerable<CodeableConcept>)u_),
				PurposeElement = v_,
				UsageElement = w_,
				CopyrightElement = x_,
				ApprovalDateElement = y_,
				LastReviewDateElement = z_,
				EffectivePeriod = aa_,
				Topic = new List<CodeableConcept>((IEnumerable<CodeableConcept>)ab_),
				Author = new List<ContactDetail>((IEnumerable<ContactDetail>)ac_),
				Editor = new List<ContactDetail>((IEnumerable<ContactDetail>)ad_),
				Reviewer = new List<ContactDetail>((IEnumerable<ContactDetail>)ae_),
				Endorser = new List<ContactDetail>((IEnumerable<ContactDetail>)af_),
				RelatedArtifact = new List<RelatedArtifact>((IEnumerable<RelatedArtifact>)ag_),
				LibraryElement = new List<Canonical>((IEnumerable<Canonical>)ah_),
				Population = ai_,
				Exposure = aj_,
				ExposureAlternative = ak_,
				Outcome = al_,
			};

			return am_;
		};
		IEnumerable<ResearchDefinition> c_ = context.Operators.Select<ResearchDefinition, ResearchDefinition>((IEnumerable<ResearchDefinition>)a_, b_);
		ResearchDefinition d_ = context.Operators.SingletonFrom<ResearchDefinition>(c_);

		return d_;
	}

    [CqlDeclaration("ResearchElementDefinitionResource")]
	public ResearchElementDefinition ResearchElementDefinitionResource(ResearchElementDefinition arg)
	{
		ResearchElementDefinition[] a_ = [
			arg,
		];
		ResearchElementDefinition b_(ResearchElementDefinition a)
		{
			FhirUri e_ = a?.UrlElement;
			List<Identifier> f_ = a?.Identifier;
			FhirString g_ = a?.VersionElement;
			FhirString h_ = a?.NameElement;
			FhirString i_ = a?.TitleElement;
			FhirString j_ = a?.ShortTitleElement;
			FhirString k_ = a?.SubtitleElement;
			Code<PublicationStatus> l_ = a?.StatusElement;
			FhirBoolean m_ = a?.ExperimentalElement;
			DataType n_ = a?.Subject;
			FhirDateTime o_ = a?.DateElement;
			FhirString p_ = a?.PublisherElement;
			List<ContactDetail> q_ = a?.Contact;
			Markdown r_ = a?.DescriptionElement;
			List<FhirString> s_ = a?.CommentElement;
			List<UsageContext> t_ = a?.UseContext;
			List<CodeableConcept> u_ = a?.Jurisdiction;
			Markdown v_ = a?.PurposeElement;
			FhirString w_ = a?.UsageElement;
			Markdown x_ = a?.CopyrightElement;
			Date y_ = a?.ApprovalDateElement;
			Date z_ = a?.LastReviewDateElement;
			Period aa_ = a?.EffectivePeriod;
			List<CodeableConcept> ab_ = a?.Topic;
			List<ContactDetail> ac_ = a?.Author;
			List<ContactDetail> ad_ = a?.Editor;
			List<ContactDetail> ae_ = a?.Reviewer;
			List<ContactDetail> af_ = a?.Endorser;
			List<RelatedArtifact> ag_ = a?.RelatedArtifact;
			List<Canonical> ah_ = a?.LibraryElement;
			Code<ResearchElementDefinition.ResearchElementType> ai_ = a?.TypeElement;
			Code<VariableTypeCode> aj_ = a?.VariableTypeElement;
			List<ResearchElementDefinition.CharacteristicComponent> ak_ = a?.Characteristic;
			ResearchElementDefinition al_ = new ResearchElementDefinition
			{
				UrlElement = e_,
				Identifier = new List<Identifier>((IEnumerable<Identifier>)f_),
				VersionElement = g_,
				NameElement = h_,
				TitleElement = i_,
				ShortTitleElement = j_,
				SubtitleElement = k_,
				StatusElement = l_,
				ExperimentalElement = m_,
				Subject = (DataType)n_,
				DateElement = o_,
				PublisherElement = p_,
				Contact = new List<ContactDetail>((IEnumerable<ContactDetail>)q_),
				DescriptionElement = r_,
				CommentElement = new List<FhirString>((IEnumerable<FhirString>)s_),
				UseContext = new List<UsageContext>((IEnumerable<UsageContext>)t_),
				Jurisdiction = new List<CodeableConcept>((IEnumerable<CodeableConcept>)u_),
				PurposeElement = v_,
				UsageElement = w_,
				CopyrightElement = x_,
				ApprovalDateElement = y_,
				LastReviewDateElement = z_,
				EffectivePeriod = aa_,
				Topic = new List<CodeableConcept>((IEnumerable<CodeableConcept>)ab_),
				Author = new List<ContactDetail>((IEnumerable<ContactDetail>)ac_),
				Editor = new List<ContactDetail>((IEnumerable<ContactDetail>)ad_),
				Reviewer = new List<ContactDetail>((IEnumerable<ContactDetail>)ae_),
				Endorser = new List<ContactDetail>((IEnumerable<ContactDetail>)af_),
				RelatedArtifact = new List<RelatedArtifact>((IEnumerable<RelatedArtifact>)ag_),
				LibraryElement = new List<Canonical>((IEnumerable<Canonical>)ah_),
				TypeElement = ai_,
				VariableTypeElement = aj_,
				Characteristic = new List<ResearchElementDefinition.CharacteristicComponent>((IEnumerable<ResearchElementDefinition.CharacteristicComponent>)ak_),
			};

			return al_;
		};
		IEnumerable<ResearchElementDefinition> c_ = context.Operators.Select<ResearchElementDefinition, ResearchElementDefinition>((IEnumerable<ResearchElementDefinition>)a_, b_);
		ResearchElementDefinition d_ = context.Operators.SingletonFrom<ResearchElementDefinition>(c_);

		return d_;
	}

    [CqlDeclaration("ResearchStudyResource")]
	public ResearchStudy ResearchStudyResource(ResearchStudy arg)
	{
		ResearchStudy[] a_ = [
			arg,
		];
		ResearchStudy b_(ResearchStudy a)
		{
			List<Identifier> e_ = a?.Identifier;
			FhirString f_ = a?.TitleElement;
			List<ResourceReference> g_ = a?.Protocol;
			List<ResourceReference> h_ = a?.PartOf;
			Code<ResearchStudy.ResearchStudyStatus> i_ = a?.StatusElement;
			CodeableConcept j_ = a?.PrimaryPurposeType;
			CodeableConcept k_ = a?.Phase;
			List<CodeableConcept> l_ = a?.Category;
			List<CodeableConcept> m_ = a?.Focus;
			List<CodeableConcept> n_ = a?.Condition;
			List<ContactDetail> o_ = a?.Contact;
			List<RelatedArtifact> p_ = a?.RelatedArtifact;
			List<CodeableConcept> q_ = a?.Keyword;
			List<CodeableConcept> r_ = a?.Location;
			Markdown s_ = a?.DescriptionElement;
			List<ResourceReference> t_ = a?.Enrollment;
			Period u_ = a?.Period;
			ResourceReference v_ = a?.Sponsor;
			ResourceReference w_ = a?.PrincipalInvestigator;
			List<ResourceReference> x_ = a?.Site;
			CodeableConcept y_ = a?.ReasonStopped;
			List<Annotation> z_ = a?.Note;
			List<ResearchStudy.ArmComponent> aa_ = a?.Arm;
			List<ResearchStudy.ObjectiveComponent> ab_ = a?.Objective;
			ResearchStudy ac_ = new ResearchStudy
			{
				Identifier = new List<Identifier>((IEnumerable<Identifier>)e_),
				TitleElement = f_,
				Protocol = new List<ResourceReference>((IEnumerable<ResourceReference>)g_),
				PartOf = new List<ResourceReference>((IEnumerable<ResourceReference>)h_),
				StatusElement = i_,
				PrimaryPurposeType = j_,
				Phase = k_,
				Category = new List<CodeableConcept>((IEnumerable<CodeableConcept>)l_),
				Focus = new List<CodeableConcept>((IEnumerable<CodeableConcept>)m_),
				Condition = new List<CodeableConcept>((IEnumerable<CodeableConcept>)n_),
				Contact = new List<ContactDetail>((IEnumerable<ContactDetail>)o_),
				RelatedArtifact = new List<RelatedArtifact>((IEnumerable<RelatedArtifact>)p_),
				Keyword = new List<CodeableConcept>((IEnumerable<CodeableConcept>)q_),
				Location = new List<CodeableConcept>((IEnumerable<CodeableConcept>)r_),
				DescriptionElement = s_,
				Enrollment = new List<ResourceReference>((IEnumerable<ResourceReference>)t_),
				Period = u_,
				Sponsor = v_,
				PrincipalInvestigator = w_,
				Site = new List<ResourceReference>((IEnumerable<ResourceReference>)x_),
				ReasonStopped = y_,
				Note = new List<Annotation>((IEnumerable<Annotation>)z_),
				Arm = new List<ResearchStudy.ArmComponent>((IEnumerable<ResearchStudy.ArmComponent>)aa_),
				Objective = new List<ResearchStudy.ObjectiveComponent>((IEnumerable<ResearchStudy.ObjectiveComponent>)ab_),
			};

			return ac_;
		};
		IEnumerable<ResearchStudy> c_ = context.Operators.Select<ResearchStudy, ResearchStudy>((IEnumerable<ResearchStudy>)a_, b_);
		ResearchStudy d_ = context.Operators.SingletonFrom<ResearchStudy>(c_);

		return d_;
	}

    [CqlDeclaration("ResearchSubjectResource")]
	public ResearchSubject ResearchSubjectResource(ResearchSubject arg)
	{
		ResearchSubject[] a_ = [
			arg,
		];
		ResearchSubject b_(ResearchSubject a)
		{
			List<Identifier> e_ = a?.Identifier;
			Code<ResearchSubject.ResearchSubjectStatus> f_ = a?.StatusElement;
			Period g_ = a?.Period;
			ResourceReference h_ = a?.Study;
			ResourceReference i_ = a?.Individual;
			FhirString j_ = a?.AssignedArmElement;
			FhirString k_ = a?.ActualArmElement;
			ResourceReference l_ = a?.Consent;
			ResearchSubject m_ = new ResearchSubject
			{
				Identifier = new List<Identifier>((IEnumerable<Identifier>)e_),
				StatusElement = f_,
				Period = g_,
				Study = h_,
				Individual = i_,
				AssignedArmElement = j_,
				ActualArmElement = k_,
				Consent = l_,
			};

			return m_;
		};
		IEnumerable<ResearchSubject> c_ = context.Operators.Select<ResearchSubject, ResearchSubject>((IEnumerable<ResearchSubject>)a_, b_);
		ResearchSubject d_ = context.Operators.SingletonFrom<ResearchSubject>(c_);

		return d_;
	}

    [CqlDeclaration("RiskAssessmentResource")]
	public RiskAssessment RiskAssessmentResource(RiskAssessment arg)
	{
		RiskAssessment[] a_ = [
			arg,
		];
		RiskAssessment b_(RiskAssessment a)
		{
			List<Identifier> e_ = a?.Identifier;
			ResourceReference f_ = a?.BasedOn;
			ResourceReference g_ = a?.Parent;
			Code<ObservationStatus> h_ = a?.StatusElement;
			CodeableConcept i_ = a?.Method;
			CodeableConcept j_ = a?.Code;
			ResourceReference k_ = a?.Subject;
			ResourceReference l_ = a?.Encounter;
			DataType m_ = a?.Occurrence;
			ResourceReference n_ = a?.Condition;
			ResourceReference o_ = a?.Performer;
			List<CodeableConcept> p_ = a?.ReasonCode;
			List<ResourceReference> q_ = a?.ReasonReference;
			List<ResourceReference> r_ = a?.Basis;
			List<RiskAssessment.PredictionComponent> s_ = a?.Prediction;
			FhirString t_ = a?.MitigationElement;
			List<Annotation> u_ = a?.Note;
			RiskAssessment v_ = new RiskAssessment
			{
				Identifier = new List<Identifier>((IEnumerable<Identifier>)e_),
				BasedOn = f_,
				Parent = g_,
				StatusElement = h_,
				Method = i_,
				Code = j_,
				Subject = k_,
				Encounter = l_,
				Occurrence = (DataType)m_,
				Condition = n_,
				Performer = o_,
				ReasonCode = new List<CodeableConcept>((IEnumerable<CodeableConcept>)p_),
				ReasonReference = new List<ResourceReference>((IEnumerable<ResourceReference>)q_),
				Basis = new List<ResourceReference>((IEnumerable<ResourceReference>)r_),
				Prediction = new List<RiskAssessment.PredictionComponent>((IEnumerable<RiskAssessment.PredictionComponent>)s_),
				MitigationElement = t_,
				Note = new List<Annotation>((IEnumerable<Annotation>)u_),
			};

			return v_;
		};
		IEnumerable<RiskAssessment> c_ = context.Operators.Select<RiskAssessment, RiskAssessment>((IEnumerable<RiskAssessment>)a_, b_);
		RiskAssessment d_ = context.Operators.SingletonFrom<RiskAssessment>(c_);

		return d_;
	}

    [CqlDeclaration("RiskEvidenceSynthesisResource")]
	public RiskEvidenceSynthesis RiskEvidenceSynthesisResource(RiskEvidenceSynthesis arg)
	{
		RiskEvidenceSynthesis[] a_ = [
			arg,
		];
		RiskEvidenceSynthesis b_(RiskEvidenceSynthesis a)
		{
			FhirUri e_ = a?.UrlElement;
			List<Identifier> f_ = a?.Identifier;
			FhirString g_ = a?.VersionElement;
			FhirString h_ = a?.NameElement;
			FhirString i_ = a?.TitleElement;
			Code<PublicationStatus> j_ = a?.StatusElement;
			FhirDateTime k_ = a?.DateElement;
			FhirString l_ = a?.PublisherElement;
			List<ContactDetail> m_ = a?.Contact;
			Markdown n_ = a?.DescriptionElement;
			List<Annotation> o_ = a?.Note;
			List<UsageContext> p_ = a?.UseContext;
			List<CodeableConcept> q_ = a?.Jurisdiction;
			Markdown r_ = a?.CopyrightElement;
			Date s_ = a?.ApprovalDateElement;
			Date t_ = a?.LastReviewDateElement;
			Period u_ = a?.EffectivePeriod;
			List<CodeableConcept> v_ = a?.Topic;
			List<ContactDetail> w_ = a?.Author;
			List<ContactDetail> x_ = a?.Editor;
			List<ContactDetail> y_ = a?.Reviewer;
			List<ContactDetail> z_ = a?.Endorser;
			List<RelatedArtifact> aa_ = a?.RelatedArtifact;
			CodeableConcept ab_ = a?.SynthesisType;
			CodeableConcept ac_ = a?.StudyType;
			ResourceReference ad_ = a?.Population;
			ResourceReference ae_ = a?.Exposure;
			ResourceReference af_ = a?.Outcome;
			RiskEvidenceSynthesis.SampleSizeComponent ag_ = a?.SampleSize;
			RiskEvidenceSynthesis.RiskEstimateComponent ah_ = a?.RiskEstimate;
			List<RiskEvidenceSynthesis.CertaintyComponent> ai_ = a?.Certainty;
			RiskEvidenceSynthesis aj_ = new RiskEvidenceSynthesis
			{
				UrlElement = e_,
				Identifier = new List<Identifier>((IEnumerable<Identifier>)f_),
				VersionElement = g_,
				NameElement = h_,
				TitleElement = i_,
				StatusElement = j_,
				DateElement = k_,
				PublisherElement = l_,
				Contact = new List<ContactDetail>((IEnumerable<ContactDetail>)m_),
				DescriptionElement = n_,
				Note = new List<Annotation>((IEnumerable<Annotation>)o_),
				UseContext = new List<UsageContext>((IEnumerable<UsageContext>)p_),
				Jurisdiction = new List<CodeableConcept>((IEnumerable<CodeableConcept>)q_),
				CopyrightElement = r_,
				ApprovalDateElement = s_,
				LastReviewDateElement = t_,
				EffectivePeriod = u_,
				Topic = new List<CodeableConcept>((IEnumerable<CodeableConcept>)v_),
				Author = new List<ContactDetail>((IEnumerable<ContactDetail>)w_),
				Editor = new List<ContactDetail>((IEnumerable<ContactDetail>)x_),
				Reviewer = new List<ContactDetail>((IEnumerable<ContactDetail>)y_),
				Endorser = new List<ContactDetail>((IEnumerable<ContactDetail>)z_),
				RelatedArtifact = new List<RelatedArtifact>((IEnumerable<RelatedArtifact>)aa_),
				SynthesisType = ab_,
				StudyType = ac_,
				Population = ad_,
				Exposure = ae_,
				Outcome = af_,
				SampleSize = ag_,
				RiskEstimate = ah_,
				Certainty = new List<RiskEvidenceSynthesis.CertaintyComponent>((IEnumerable<RiskEvidenceSynthesis.CertaintyComponent>)ai_),
			};

			return aj_;
		};
		IEnumerable<RiskEvidenceSynthesis> c_ = context.Operators.Select<RiskEvidenceSynthesis, RiskEvidenceSynthesis>((IEnumerable<RiskEvidenceSynthesis>)a_, b_);
		RiskEvidenceSynthesis d_ = context.Operators.SingletonFrom<RiskEvidenceSynthesis>(c_);

		return d_;
	}

    [CqlDeclaration("ScheduleResource")]
	public Schedule ScheduleResource(Schedule arg)
	{
		Schedule[] a_ = [
			arg,
		];
		Schedule b_(Schedule a)
		{
			List<Identifier> e_ = a?.Identifier;
			FhirBoolean f_ = a?.ActiveElement;
			List<CodeableConcept> g_ = a?.ServiceCategory;
			List<CodeableConcept> h_ = a?.ServiceType;
			List<CodeableConcept> i_ = a?.Specialty;
			List<ResourceReference> j_ = a?.Actor;
			Period k_ = a?.PlanningHorizon;
			FhirString l_ = a?.CommentElement;
			Schedule m_ = new Schedule
			{
				Identifier = new List<Identifier>((IEnumerable<Identifier>)e_),
				ActiveElement = f_,
				ServiceCategory = new List<CodeableConcept>((IEnumerable<CodeableConcept>)g_),
				ServiceType = new List<CodeableConcept>((IEnumerable<CodeableConcept>)h_),
				Specialty = new List<CodeableConcept>((IEnumerable<CodeableConcept>)i_),
				Actor = new List<ResourceReference>((IEnumerable<ResourceReference>)j_),
				PlanningHorizon = k_,
				CommentElement = l_,
			};

			return m_;
		};
		IEnumerable<Schedule> c_ = context.Operators.Select<Schedule, Schedule>((IEnumerable<Schedule>)a_, b_);
		Schedule d_ = context.Operators.SingletonFrom<Schedule>(c_);

		return d_;
	}

    [CqlDeclaration("ServiceRequestResource")]
	public ServiceRequest ServiceRequestResource(ServiceRequest arg)
	{
		ServiceRequest[] a_ = [
			arg,
		];
		ServiceRequest b_(ServiceRequest a)
		{
			List<Identifier> e_ = a?.Identifier;
			List<Canonical> f_ = a?.InstantiatesCanonicalElement;
			List<FhirUri> g_ = a?.InstantiatesUriElement;
			List<ResourceReference> h_ = a?.BasedOn;
			List<ResourceReference> i_ = a?.Replaces;
			Identifier j_ = a?.Requisition;
			Code<RequestStatus> k_ = a?.StatusElement;
			Code<RequestIntent> l_ = a?.IntentElement;
			List<CodeableConcept> m_ = a?.Category;
			Code<RequestPriority> n_ = a?.PriorityElement;
			FhirBoolean o_ = a?.DoNotPerformElement;
			CodeableConcept p_ = a?.Code;
			List<CodeableConcept> q_ = a?.OrderDetail;
			DataType r_ = a?.Quantity;
			ResourceReference s_ = a?.Subject;
			ResourceReference t_ = a?.Encounter;
			DataType u_ = a?.Occurrence;
			DataType v_ = a?.AsNeeded;
			FhirDateTime w_ = a?.AuthoredOnElement;
			ResourceReference x_ = a?.Requester;
			CodeableConcept y_ = a?.PerformerType;
			List<ResourceReference> z_ = a?.Performer;
			List<CodeableConcept> aa_ = a?.LocationCode;
			List<ResourceReference> ab_ = a?.LocationReference;
			List<CodeableConcept> ac_ = a?.ReasonCode;
			List<ResourceReference> ad_ = a?.ReasonReference;
			List<ResourceReference> ae_ = a?.Insurance;
			List<ResourceReference> af_ = a?.SupportingInfo;
			List<ResourceReference> ag_ = a?.Specimen;
			List<CodeableConcept> ah_ = a?.BodySite;
			List<Annotation> ai_ = a?.Note;
			FhirString aj_ = a?.PatientInstructionElement;
			List<ResourceReference> ak_ = a?.RelevantHistory;
			ServiceRequest al_ = new ServiceRequest
			{
				Identifier = new List<Identifier>((IEnumerable<Identifier>)e_),
				InstantiatesCanonicalElement = new List<Canonical>((IEnumerable<Canonical>)f_),
				InstantiatesUriElement = new List<FhirUri>((IEnumerable<FhirUri>)g_),
				BasedOn = new List<ResourceReference>((IEnumerable<ResourceReference>)h_),
				Replaces = new List<ResourceReference>((IEnumerable<ResourceReference>)i_),
				Requisition = j_,
				StatusElement = k_,
				IntentElement = l_,
				Category = new List<CodeableConcept>((IEnumerable<CodeableConcept>)m_),
				PriorityElement = n_,
				DoNotPerformElement = o_,
				Code = p_,
				OrderDetail = new List<CodeableConcept>((IEnumerable<CodeableConcept>)q_),
				Quantity = (DataType)r_,
				Subject = s_,
				Encounter = t_,
				Occurrence = (DataType)u_,
				AsNeeded = (DataType)v_,
				AuthoredOnElement = w_,
				Requester = x_,
				PerformerType = y_,
				Performer = new List<ResourceReference>((IEnumerable<ResourceReference>)z_),
				LocationCode = new List<CodeableConcept>((IEnumerable<CodeableConcept>)aa_),
				LocationReference = new List<ResourceReference>((IEnumerable<ResourceReference>)ab_),
				ReasonCode = new List<CodeableConcept>((IEnumerable<CodeableConcept>)ac_),
				ReasonReference = new List<ResourceReference>((IEnumerable<ResourceReference>)ad_),
				Insurance = new List<ResourceReference>((IEnumerable<ResourceReference>)ae_),
				SupportingInfo = new List<ResourceReference>((IEnumerable<ResourceReference>)af_),
				Specimen = new List<ResourceReference>((IEnumerable<ResourceReference>)ag_),
				BodySite = new List<CodeableConcept>((IEnumerable<CodeableConcept>)ah_),
				Note = new List<Annotation>((IEnumerable<Annotation>)ai_),
				PatientInstructionElement = aj_,
				RelevantHistory = new List<ResourceReference>((IEnumerable<ResourceReference>)ak_),
			};

			return al_;
		};
		IEnumerable<ServiceRequest> c_ = context.Operators.Select<ServiceRequest, ServiceRequest>((IEnumerable<ServiceRequest>)a_, b_);
		ServiceRequest d_ = context.Operators.SingletonFrom<ServiceRequest>(c_);

		return d_;
	}

    [CqlDeclaration("SlotResource")]
	public Slot SlotResource(Slot arg)
	{
		Slot[] a_ = [
			arg,
		];
		Slot b_(Slot a)
		{
			List<Identifier> e_ = a?.Identifier;
			List<CodeableConcept> f_ = a?.ServiceCategory;
			List<CodeableConcept> g_ = a?.ServiceType;
			List<CodeableConcept> h_ = a?.Specialty;
			CodeableConcept i_ = a?.AppointmentType;
			ResourceReference j_ = a?.Schedule;
			Code<Slot.SlotStatus> k_ = a?.StatusElement;
			Instant l_ = a?.StartElement;
			Instant m_ = a?.EndElement;
			FhirBoolean n_ = a?.OverbookedElement;
			FhirString o_ = a?.CommentElement;
			Slot p_ = new Slot
			{
				Identifier = new List<Identifier>((IEnumerable<Identifier>)e_),
				ServiceCategory = new List<CodeableConcept>((IEnumerable<CodeableConcept>)f_),
				ServiceType = new List<CodeableConcept>((IEnumerable<CodeableConcept>)g_),
				Specialty = new List<CodeableConcept>((IEnumerable<CodeableConcept>)h_),
				AppointmentType = i_,
				Schedule = j_,
				StatusElement = k_,
				StartElement = l_,
				EndElement = m_,
				OverbookedElement = n_,
				CommentElement = o_,
			};

			return p_;
		};
		IEnumerable<Slot> c_ = context.Operators.Select<Slot, Slot>((IEnumerable<Slot>)a_, b_);
		Slot d_ = context.Operators.SingletonFrom<Slot>(c_);

		return d_;
	}

    [CqlDeclaration("SpecimenResource")]
	public Specimen SpecimenResource(Specimen arg)
	{
		Specimen[] a_ = [
			arg,
		];
		Specimen b_(Specimen a)
		{
			List<Identifier> e_ = a?.Identifier;
			Identifier f_ = a?.AccessionIdentifier;
			Code<Specimen.SpecimenStatus> g_ = a?.StatusElement;
			CodeableConcept h_ = a?.Type;
			ResourceReference i_ = a?.Subject;
			FhirDateTime j_ = a?.ReceivedTimeElement;
			List<ResourceReference> k_ = a?.Parent;
			List<ResourceReference> l_ = a?.Request;
			Specimen.CollectionComponent m_ = a?.Collection;
			List<Specimen.ProcessingComponent> n_ = a?.Processing;
			List<Specimen.ContainerComponent> o_ = a?.Container;
			List<CodeableConcept> p_ = a?.Condition;
			List<Annotation> q_ = a?.Note;
			Specimen r_ = new Specimen
			{
				Identifier = new List<Identifier>((IEnumerable<Identifier>)e_),
				AccessionIdentifier = f_,
				StatusElement = g_,
				Type = h_,
				Subject = i_,
				ReceivedTimeElement = j_,
				Parent = new List<ResourceReference>((IEnumerable<ResourceReference>)k_),
				Request = new List<ResourceReference>((IEnumerable<ResourceReference>)l_),
				Collection = m_,
				Processing = new List<Specimen.ProcessingComponent>((IEnumerable<Specimen.ProcessingComponent>)n_),
				Container = new List<Specimen.ContainerComponent>((IEnumerable<Specimen.ContainerComponent>)o_),
				Condition = new List<CodeableConcept>((IEnumerable<CodeableConcept>)p_),
				Note = new List<Annotation>((IEnumerable<Annotation>)q_),
			};

			return r_;
		};
		IEnumerable<Specimen> c_ = context.Operators.Select<Specimen, Specimen>((IEnumerable<Specimen>)a_, b_);
		Specimen d_ = context.Operators.SingletonFrom<Specimen>(c_);

		return d_;
	}

    [CqlDeclaration("SpecimenDefinitionResource")]
	public SpecimenDefinition SpecimenDefinitionResource(SpecimenDefinition arg)
	{
		SpecimenDefinition[] a_ = [
			arg,
		];
		SpecimenDefinition b_(SpecimenDefinition a)
		{
			Identifier e_ = a?.Identifier;
			CodeableConcept f_ = a?.TypeCollected;
			List<CodeableConcept> g_ = a?.PatientPreparation;
			FhirString h_ = a?.TimeAspectElement;
			List<CodeableConcept> i_ = a?.Collection;
			List<SpecimenDefinition.TypeTestedComponent> j_ = a?.TypeTested;
			SpecimenDefinition k_ = new SpecimenDefinition
			{
				Identifier = e_,
				TypeCollected = f_,
				PatientPreparation = new List<CodeableConcept>((IEnumerable<CodeableConcept>)g_),
				TimeAspectElement = h_,
				Collection = new List<CodeableConcept>((IEnumerable<CodeableConcept>)i_),
				TypeTested = new List<SpecimenDefinition.TypeTestedComponent>((IEnumerable<SpecimenDefinition.TypeTestedComponent>)j_),
			};

			return k_;
		};
		IEnumerable<SpecimenDefinition> c_ = context.Operators.Select<SpecimenDefinition, SpecimenDefinition>((IEnumerable<SpecimenDefinition>)a_, b_);
		SpecimenDefinition d_ = context.Operators.SingletonFrom<SpecimenDefinition>(c_);

		return d_;
	}

    [CqlDeclaration("StructureDefinitionResource")]
	public StructureDefinition StructureDefinitionResource(StructureDefinition arg)
	{
		StructureDefinition[] a_ = [
			arg,
		];
		StructureDefinition b_(StructureDefinition a)
		{
			FhirUri e_ = a?.UrlElement;
			List<Identifier> f_ = a?.Identifier;
			FhirString g_ = a?.VersionElement;
			FhirString h_ = a?.NameElement;
			FhirString i_ = a?.TitleElement;
			Code<PublicationStatus> j_ = a?.StatusElement;
			FhirBoolean k_ = a?.ExperimentalElement;
			FhirDateTime l_ = a?.DateElement;
			FhirString m_ = a?.PublisherElement;
			List<ContactDetail> n_ = a?.Contact;
			Markdown o_ = a?.DescriptionElement;
			List<UsageContext> p_ = a?.UseContext;
			List<CodeableConcept> q_ = a?.Jurisdiction;
			Markdown r_ = a?.PurposeElement;
			Markdown s_ = a?.CopyrightElement;
			List<Coding> t_ = a?.Keyword;
			Code<FHIRVersion> u_ = a?.FhirVersionElement;
			List<StructureDefinition.MappingComponent> v_ = a?.Mapping;
			Code<StructureDefinition.StructureDefinitionKind> w_ = a?.KindElement;
			FhirBoolean x_ = a?.AbstractElement;
			List<StructureDefinition.ContextComponent> y_ = a?.Context;
			List<FhirString> z_ = a?.ContextInvariantElement;
			FhirUri aa_ = a?.TypeElement;
			Canonical ab_ = a?.BaseDefinitionElement;
			Code<StructureDefinition.TypeDerivationRule> ac_ = a?.DerivationElement;
			StructureDefinition.SnapshotComponent ad_ = a?.Snapshot;
			StructureDefinition.DifferentialComponent ae_ = a?.Differential;
			StructureDefinition af_ = new StructureDefinition
			{
				UrlElement = e_,
				Identifier = new List<Identifier>((IEnumerable<Identifier>)f_),
				VersionElement = g_,
				NameElement = h_,
				TitleElement = i_,
				StatusElement = j_,
				ExperimentalElement = k_,
				DateElement = l_,
				PublisherElement = m_,
				Contact = new List<ContactDetail>((IEnumerable<ContactDetail>)n_),
				DescriptionElement = o_,
				UseContext = new List<UsageContext>((IEnumerable<UsageContext>)p_),
				Jurisdiction = new List<CodeableConcept>((IEnumerable<CodeableConcept>)q_),
				PurposeElement = r_,
				CopyrightElement = s_,
				Keyword = new List<Coding>((IEnumerable<Coding>)t_),
				FhirVersionElement = u_,
				Mapping = new List<StructureDefinition.MappingComponent>((IEnumerable<StructureDefinition.MappingComponent>)v_),
				KindElement = w_,
				AbstractElement = x_,
				Context = new List<StructureDefinition.ContextComponent>((IEnumerable<StructureDefinition.ContextComponent>)y_),
				ContextInvariantElement = new List<FhirString>((IEnumerable<FhirString>)z_),
				TypeElement = aa_,
				BaseDefinitionElement = ab_,
				DerivationElement = ac_,
				Snapshot = ad_,
				Differential = ae_,
			};

			return af_;
		};
		IEnumerable<StructureDefinition> c_ = context.Operators.Select<StructureDefinition, StructureDefinition>((IEnumerable<StructureDefinition>)a_, b_);
		StructureDefinition d_ = context.Operators.SingletonFrom<StructureDefinition>(c_);

		return d_;
	}

    [CqlDeclaration("StructureMapResource")]
	public StructureMap StructureMapResource(StructureMap arg)
	{
		StructureMap[] a_ = [
			arg,
		];
		StructureMap b_(StructureMap a)
		{
			FhirUri e_ = a?.UrlElement;
			List<Identifier> f_ = a?.Identifier;
			FhirString g_ = a?.VersionElement;
			FhirString h_ = a?.NameElement;
			FhirString i_ = a?.TitleElement;
			Code<PublicationStatus> j_ = a?.StatusElement;
			FhirBoolean k_ = a?.ExperimentalElement;
			FhirDateTime l_ = a?.DateElement;
			FhirString m_ = a?.PublisherElement;
			List<ContactDetail> n_ = a?.Contact;
			Markdown o_ = a?.DescriptionElement;
			List<UsageContext> p_ = a?.UseContext;
			List<CodeableConcept> q_ = a?.Jurisdiction;
			Markdown r_ = a?.PurposeElement;
			Markdown s_ = a?.CopyrightElement;
			List<StructureMap.StructureComponent> t_ = a?.Structure;
			List<Canonical> u_ = a?.ImportElement;
			List<StructureMap.GroupComponent> v_ = a?.Group;
			StructureMap w_ = new StructureMap
			{
				UrlElement = e_,
				Identifier = new List<Identifier>((IEnumerable<Identifier>)f_),
				VersionElement = g_,
				NameElement = h_,
				TitleElement = i_,
				StatusElement = j_,
				ExperimentalElement = k_,
				DateElement = l_,
				PublisherElement = m_,
				Contact = new List<ContactDetail>((IEnumerable<ContactDetail>)n_),
				DescriptionElement = o_,
				UseContext = new List<UsageContext>((IEnumerable<UsageContext>)p_),
				Jurisdiction = new List<CodeableConcept>((IEnumerable<CodeableConcept>)q_),
				PurposeElement = r_,
				CopyrightElement = s_,
				Structure = new List<StructureMap.StructureComponent>((IEnumerable<StructureMap.StructureComponent>)t_),
				ImportElement = new List<Canonical>((IEnumerable<Canonical>)u_),
				Group = new List<StructureMap.GroupComponent>((IEnumerable<StructureMap.GroupComponent>)v_),
			};

			return w_;
		};
		IEnumerable<StructureMap> c_ = context.Operators.Select<StructureMap, StructureMap>((IEnumerable<StructureMap>)a_, b_);
		StructureMap d_ = context.Operators.SingletonFrom<StructureMap>(c_);

		return d_;
	}

    [CqlDeclaration("SubscriptionResource")]
	public Subscription SubscriptionResource(Subscription arg)
	{
		Subscription[] a_ = [
			arg,
		];
		Subscription b_(Subscription a)
		{
			Code<Subscription.SubscriptionStatus> e_ = a?.StatusElement;
			List<ContactPoint> f_ = a?.Contact;
			Instant g_ = a?.EndElement;
			FhirString h_ = a?.ReasonElement;
			FhirString i_ = a?.CriteriaElement;
			FhirString j_ = a?.ErrorElement;
			Subscription.ChannelComponent k_ = a?.Channel;
			Subscription l_ = new Subscription
			{
				StatusElement = e_,
				Contact = new List<ContactPoint>((IEnumerable<ContactPoint>)f_),
				EndElement = g_,
				ReasonElement = h_,
				CriteriaElement = i_,
				ErrorElement = j_,
				Channel = k_,
			};

			return l_;
		};
		IEnumerable<Subscription> c_ = context.Operators.Select<Subscription, Subscription>((IEnumerable<Subscription>)a_, b_);
		Subscription d_ = context.Operators.SingletonFrom<Subscription>(c_);

		return d_;
	}

    [CqlDeclaration("SubstanceResource")]
	public Substance SubstanceResource(Substance arg)
	{
		Substance[] a_ = [
			arg,
		];
		Substance b_(Substance a)
		{
			List<Identifier> e_ = a?.Identifier;
			Code<Substance.FHIRSubstanceStatus> f_ = a?.StatusElement;
			List<CodeableConcept> g_ = a?.Category;
			CodeableConcept h_ = a?.Code;
			FhirString i_ = a?.DescriptionElement;
			List<Substance.InstanceComponent> j_ = a?.Instance;
			List<Substance.IngredientComponent> k_ = a?.Ingredient;
			Substance l_ = new Substance
			{
				Identifier = new List<Identifier>((IEnumerable<Identifier>)e_),
				StatusElement = f_,
				Category = new List<CodeableConcept>((IEnumerable<CodeableConcept>)g_),
				Code = h_,
				DescriptionElement = i_,
				Instance = new List<Substance.InstanceComponent>((IEnumerable<Substance.InstanceComponent>)j_),
				Ingredient = new List<Substance.IngredientComponent>((IEnumerable<Substance.IngredientComponent>)k_),
			};

			return l_;
		};
		IEnumerable<Substance> c_ = context.Operators.Select<Substance, Substance>((IEnumerable<Substance>)a_, b_);
		Substance d_ = context.Operators.SingletonFrom<Substance>(c_);

		return d_;
	}

    [CqlDeclaration("SubstanceNucleicAcidResource")]
	public SubstanceNucleicAcid SubstanceNucleicAcidResource(SubstanceNucleicAcid arg)
	{
		SubstanceNucleicAcid[] a_ = [
			arg,
		];
		SubstanceNucleicAcid b_(SubstanceNucleicAcid a)
		{
			CodeableConcept e_ = a?.SequenceType;
			Integer f_ = a?.NumberOfSubunitsElement;
			FhirString g_ = a?.AreaOfHybridisationElement;
			CodeableConcept h_ = a?.OligoNucleotideType;
			List<SubstanceNucleicAcid.SubunitComponent> i_ = a?.Subunit;
			SubstanceNucleicAcid j_ = new SubstanceNucleicAcid
			{
				SequenceType = e_,
				NumberOfSubunitsElement = f_,
				AreaOfHybridisationElement = g_,
				OligoNucleotideType = h_,
				Subunit = new List<SubstanceNucleicAcid.SubunitComponent>((IEnumerable<SubstanceNucleicAcid.SubunitComponent>)i_),
			};

			return j_;
		};
		IEnumerable<SubstanceNucleicAcid> c_ = context.Operators.Select<SubstanceNucleicAcid, SubstanceNucleicAcid>((IEnumerable<SubstanceNucleicAcid>)a_, b_);
		SubstanceNucleicAcid d_ = context.Operators.SingletonFrom<SubstanceNucleicAcid>(c_);

		return d_;
	}

    [CqlDeclaration("SubstancePolymerResource")]
	public SubstancePolymer SubstancePolymerResource(SubstancePolymer arg)
	{
		SubstancePolymer[] a_ = [
			arg,
		];
		SubstancePolymer b_(SubstancePolymer a)
		{
			CodeableConcept e_ = a?.Class;
			CodeableConcept f_ = a?.Geometry;
			List<CodeableConcept> g_ = a?.CopolymerConnectivity;
			List<FhirString> h_ = a?.ModificationElement;
			List<SubstancePolymer.MonomerSetComponent> i_ = a?.MonomerSet;
			List<SubstancePolymer.RepeatComponent> j_ = a?.Repeat;
			SubstancePolymer k_ = new SubstancePolymer
			{
				Class = e_,
				Geometry = f_,
				CopolymerConnectivity = new List<CodeableConcept>((IEnumerable<CodeableConcept>)g_),
				ModificationElement = new List<FhirString>((IEnumerable<FhirString>)h_),
				MonomerSet = new List<SubstancePolymer.MonomerSetComponent>((IEnumerable<SubstancePolymer.MonomerSetComponent>)i_),
				Repeat = new List<SubstancePolymer.RepeatComponent>((IEnumerable<SubstancePolymer.RepeatComponent>)j_),
			};

			return k_;
		};
		IEnumerable<SubstancePolymer> c_ = context.Operators.Select<SubstancePolymer, SubstancePolymer>((IEnumerable<SubstancePolymer>)a_, b_);
		SubstancePolymer d_ = context.Operators.SingletonFrom<SubstancePolymer>(c_);

		return d_;
	}

    [CqlDeclaration("SubstanceProteinResource")]
	public SubstanceProtein SubstanceProteinResource(SubstanceProtein arg)
	{
		SubstanceProtein[] a_ = [
			arg,
		];
		SubstanceProtein b_(SubstanceProtein a)
		{
			CodeableConcept e_ = a?.SequenceType;
			Integer f_ = a?.NumberOfSubunitsElement;
			List<FhirString> g_ = a?.DisulfideLinkageElement;
			List<SubstanceProtein.SubunitComponent> h_ = a?.Subunit;
			SubstanceProtein i_ = new SubstanceProtein
			{
				SequenceType = e_,
				NumberOfSubunitsElement = f_,
				DisulfideLinkageElement = new List<FhirString>((IEnumerable<FhirString>)g_),
				Subunit = new List<SubstanceProtein.SubunitComponent>((IEnumerable<SubstanceProtein.SubunitComponent>)h_),
			};

			return i_;
		};
		IEnumerable<SubstanceProtein> c_ = context.Operators.Select<SubstanceProtein, SubstanceProtein>((IEnumerable<SubstanceProtein>)a_, b_);
		SubstanceProtein d_ = context.Operators.SingletonFrom<SubstanceProtein>(c_);

		return d_;
	}

    [CqlDeclaration("SubstanceReferenceInformationResource")]
	public SubstanceReferenceInformation SubstanceReferenceInformationResource(SubstanceReferenceInformation arg)
	{
		SubstanceReferenceInformation[] a_ = [
			arg,
		];
		SubstanceReferenceInformation b_(SubstanceReferenceInformation a)
		{
			FhirString e_ = a?.CommentElement;
			List<SubstanceReferenceInformation.GeneComponent> f_ = a?.Gene;
			List<SubstanceReferenceInformation.GeneElementComponent> g_ = a?.GeneElement;
			List<SubstanceReferenceInformation.ClassificationComponent> h_ = a?.Classification;
			List<SubstanceReferenceInformation.TargetComponent> i_ = a?.Target;
			SubstanceReferenceInformation j_ = new SubstanceReferenceInformation
			{
				CommentElement = e_,
				Gene = new List<SubstanceReferenceInformation.GeneComponent>((IEnumerable<SubstanceReferenceInformation.GeneComponent>)f_),
				GeneElement = new List<SubstanceReferenceInformation.GeneElementComponent>((IEnumerable<SubstanceReferenceInformation.GeneElementComponent>)g_),
				Classification = new List<SubstanceReferenceInformation.ClassificationComponent>((IEnumerable<SubstanceReferenceInformation.ClassificationComponent>)h_),
				Target = new List<SubstanceReferenceInformation.TargetComponent>((IEnumerable<SubstanceReferenceInformation.TargetComponent>)i_),
			};

			return j_;
		};
		IEnumerable<SubstanceReferenceInformation> c_ = context.Operators.Select<SubstanceReferenceInformation, SubstanceReferenceInformation>((IEnumerable<SubstanceReferenceInformation>)a_, b_);
		SubstanceReferenceInformation d_ = context.Operators.SingletonFrom<SubstanceReferenceInformation>(c_);

		return d_;
	}

    [CqlDeclaration("SubstanceSourceMaterialResource")]
	public SubstanceSourceMaterial SubstanceSourceMaterialResource(SubstanceSourceMaterial arg)
	{
		SubstanceSourceMaterial[] a_ = [
			arg,
		];
		SubstanceSourceMaterial b_(SubstanceSourceMaterial a)
		{
			CodeableConcept e_ = a?.SourceMaterialClass;
			CodeableConcept f_ = a?.SourceMaterialType;
			CodeableConcept g_ = a?.SourceMaterialState;
			Identifier h_ = a?.OrganismId;
			FhirString i_ = a?.OrganismNameElement;
			List<Identifier> j_ = a?.ParentSubstanceId;
			List<FhirString> k_ = a?.ParentSubstanceNameElement;
			List<CodeableConcept> l_ = a?.CountryOfOrigin;
			List<FhirString> m_ = a?.GeographicalLocationElement;
			CodeableConcept n_ = a?.DevelopmentStage;
			List<SubstanceSourceMaterial.FractionDescriptionComponent> o_ = a?.FractionDescription;
			SubstanceSourceMaterial.OrganismComponent p_ = a?.Organism;
			List<SubstanceSourceMaterial.PartDescriptionComponent> q_ = a?.PartDescription;
			SubstanceSourceMaterial r_ = new SubstanceSourceMaterial
			{
				SourceMaterialClass = e_,
				SourceMaterialType = f_,
				SourceMaterialState = g_,
				OrganismId = h_,
				OrganismNameElement = i_,
				ParentSubstanceId = new List<Identifier>((IEnumerable<Identifier>)j_),
				ParentSubstanceNameElement = new List<FhirString>((IEnumerable<FhirString>)k_),
				CountryOfOrigin = new List<CodeableConcept>((IEnumerable<CodeableConcept>)l_),
				GeographicalLocationElement = new List<FhirString>((IEnumerable<FhirString>)m_),
				DevelopmentStage = n_,
				FractionDescription = new List<SubstanceSourceMaterial.FractionDescriptionComponent>((IEnumerable<SubstanceSourceMaterial.FractionDescriptionComponent>)o_),
				Organism = p_,
				PartDescription = new List<SubstanceSourceMaterial.PartDescriptionComponent>((IEnumerable<SubstanceSourceMaterial.PartDescriptionComponent>)q_),
			};

			return r_;
		};
		IEnumerable<SubstanceSourceMaterial> c_ = context.Operators.Select<SubstanceSourceMaterial, SubstanceSourceMaterial>((IEnumerable<SubstanceSourceMaterial>)a_, b_);
		SubstanceSourceMaterial d_ = context.Operators.SingletonFrom<SubstanceSourceMaterial>(c_);

		return d_;
	}

    [CqlDeclaration("SubstanceSpecificationResource")]
	public SubstanceSpecification SubstanceSpecificationResource(SubstanceSpecification arg)
	{
		SubstanceSpecification[] a_ = [
			arg,
		];
		SubstanceSpecification b_(SubstanceSpecification a)
		{
			Identifier e_ = a?.Identifier;
			CodeableConcept f_ = a?.Type;
			CodeableConcept g_ = a?.Status;
			CodeableConcept h_ = a?.Domain;
			FhirString i_ = a?.DescriptionElement;
			List<ResourceReference> j_ = a?.Source;
			FhirString k_ = a?.CommentElement;
			List<SubstanceSpecification.MoietyComponent> l_ = a?.Moiety;
			List<SubstanceSpecification.PropertyComponent> m_ = a?.Property;
			ResourceReference n_ = a?.ReferenceInformation;
			SubstanceSpecification.StructureComponent o_ = a?.Structure;
			List<SubstanceSpecification.CodeComponent> p_ = a?.Code;
			List<SubstanceSpecification.NameComponent> q_ = a?.Name;
			List<SubstanceSpecification.MolecularWeightComponent> r_ = a?.MolecularWeight;
			List<SubstanceSpecification.RelationshipComponent> s_ = a?.Relationship;
			ResourceReference t_ = a?.NucleicAcid;
			ResourceReference u_ = a?.Polymer;
			ResourceReference v_ = a?.Protein;
			ResourceReference w_ = a?.SourceMaterial;
			SubstanceSpecification x_ = new SubstanceSpecification
			{
				Identifier = e_,
				Type = f_,
				Status = g_,
				Domain = h_,
				DescriptionElement = i_,
				Source = new List<ResourceReference>((IEnumerable<ResourceReference>)j_),
				CommentElement = k_,
				Moiety = new List<SubstanceSpecification.MoietyComponent>((IEnumerable<SubstanceSpecification.MoietyComponent>)l_),
				Property = new List<SubstanceSpecification.PropertyComponent>((IEnumerable<SubstanceSpecification.PropertyComponent>)m_),
				ReferenceInformation = n_,
				Structure = o_,
				Code = new List<SubstanceSpecification.CodeComponent>((IEnumerable<SubstanceSpecification.CodeComponent>)p_),
				Name = new List<SubstanceSpecification.NameComponent>((IEnumerable<SubstanceSpecification.NameComponent>)q_),
				MolecularWeight = new List<SubstanceSpecification.MolecularWeightComponent>((IEnumerable<SubstanceSpecification.MolecularWeightComponent>)r_),
				Relationship = new List<SubstanceSpecification.RelationshipComponent>((IEnumerable<SubstanceSpecification.RelationshipComponent>)s_),
				NucleicAcid = t_,
				Polymer = u_,
				Protein = v_,
				SourceMaterial = w_,
			};

			return x_;
		};
		IEnumerable<SubstanceSpecification> c_ = context.Operators.Select<SubstanceSpecification, SubstanceSpecification>((IEnumerable<SubstanceSpecification>)a_, b_);
		SubstanceSpecification d_ = context.Operators.SingletonFrom<SubstanceSpecification>(c_);

		return d_;
	}

    [CqlDeclaration("SupplyDeliveryResource")]
	public SupplyDelivery SupplyDeliveryResource(SupplyDelivery arg)
	{
		SupplyDelivery[] a_ = [
			arg,
		];
		SupplyDelivery b_(SupplyDelivery a)
		{
			List<Identifier> e_ = a?.Identifier;
			List<ResourceReference> f_ = a?.BasedOn;
			List<ResourceReference> g_ = a?.PartOf;
			Code<SupplyDelivery.SupplyDeliveryStatus> h_ = a?.StatusElement;
			ResourceReference i_ = a?.Patient;
			CodeableConcept j_ = a?.Type;
			SupplyDelivery.SuppliedItemComponent k_ = a?.SuppliedItem;
			DataType l_ = a?.Occurrence;
			ResourceReference m_ = a?.Supplier;
			ResourceReference n_ = a?.Destination;
			List<ResourceReference> o_ = a?.Receiver;
			SupplyDelivery p_ = new SupplyDelivery
			{
				Identifier = new List<Identifier>((IEnumerable<Identifier>)e_),
				BasedOn = new List<ResourceReference>((IEnumerable<ResourceReference>)f_),
				PartOf = new List<ResourceReference>((IEnumerable<ResourceReference>)g_),
				StatusElement = h_,
				Patient = i_,
				Type = j_,
				SuppliedItem = k_,
				Occurrence = (DataType)l_,
				Supplier = m_,
				Destination = n_,
				Receiver = new List<ResourceReference>((IEnumerable<ResourceReference>)o_),
			};

			return p_;
		};
		IEnumerable<SupplyDelivery> c_ = context.Operators.Select<SupplyDelivery, SupplyDelivery>((IEnumerable<SupplyDelivery>)a_, b_);
		SupplyDelivery d_ = context.Operators.SingletonFrom<SupplyDelivery>(c_);

		return d_;
	}

    [CqlDeclaration("SupplyRequestResource")]
	public SupplyRequest SupplyRequestResource(SupplyRequest arg)
	{
		SupplyRequest[] a_ = [
			arg,
		];
		SupplyRequest b_(SupplyRequest a)
		{
			List<Identifier> e_ = a?.Identifier;
			Code<SupplyRequest.SupplyRequestStatus> f_ = a?.StatusElement;
			CodeableConcept g_ = a?.Category;
			Code<RequestPriority> h_ = a?.PriorityElement;
			DataType i_ = a?.Item;
			Quantity j_ = a?.Quantity;
			List<SupplyRequest.ParameterComponent> k_ = a?.Parameter;
			DataType l_ = a?.Occurrence;
			FhirDateTime m_ = a?.AuthoredOnElement;
			ResourceReference n_ = a?.Requester;
			List<ResourceReference> o_ = a?.Supplier;
			List<CodeableConcept> p_ = a?.ReasonCode;
			List<ResourceReference> q_ = a?.ReasonReference;
			ResourceReference r_ = a?.DeliverFrom;
			ResourceReference s_ = a?.DeliverTo;
			SupplyRequest t_ = new SupplyRequest
			{
				Identifier = new List<Identifier>((IEnumerable<Identifier>)e_),
				StatusElement = f_,
				Category = g_,
				PriorityElement = h_,
				Item = (DataType)i_,
				Quantity = j_,
				Parameter = new List<SupplyRequest.ParameterComponent>((IEnumerable<SupplyRequest.ParameterComponent>)k_),
				Occurrence = (DataType)l_,
				AuthoredOnElement = m_,
				Requester = n_,
				Supplier = new List<ResourceReference>((IEnumerable<ResourceReference>)o_),
				ReasonCode = new List<CodeableConcept>((IEnumerable<CodeableConcept>)p_),
				ReasonReference = new List<ResourceReference>((IEnumerable<ResourceReference>)q_),
				DeliverFrom = r_,
				DeliverTo = s_,
			};

			return t_;
		};
		IEnumerable<SupplyRequest> c_ = context.Operators.Select<SupplyRequest, SupplyRequest>((IEnumerable<SupplyRequest>)a_, b_);
		SupplyRequest d_ = context.Operators.SingletonFrom<SupplyRequest>(c_);

		return d_;
	}

    [CqlDeclaration("TaskResource")]
	public Task TaskResource(Task arg)
	{
		Task[] a_ = [
			arg,
		];
		Task b_(Task a)
		{
			List<Identifier> e_ = a?.Identifier;
			Canonical f_ = a?.InstantiatesCanonicalElement;
			FhirUri g_ = a?.InstantiatesUriElement;
			List<ResourceReference> h_ = a?.BasedOn;
			Identifier i_ = a?.GroupIdentifier;
			List<ResourceReference> j_ = a?.PartOf;
			Code<Task.TaskStatus> k_ = a?.StatusElement;
			CodeableConcept l_ = a?.StatusReason;
			CodeableConcept m_ = a?.BusinessStatus;
			Code<Task.TaskIntent> n_ = a?.IntentElement;
			Code<RequestPriority> o_ = a?.PriorityElement;
			CodeableConcept p_ = a?.Code;
			FhirString q_ = a?.DescriptionElement;
			ResourceReference r_ = a?.Focus;
			ResourceReference s_ = a?.For;
			ResourceReference t_ = a?.Encounter;
			Period u_ = a?.ExecutionPeriod;
			FhirDateTime v_ = a?.AuthoredOnElement;
			FhirDateTime w_ = a?.LastModifiedElement;
			ResourceReference x_ = a?.Requester;
			List<CodeableConcept> y_ = a?.PerformerType;
			ResourceReference z_ = a?.Owner;
			ResourceReference aa_ = a?.Location;
			CodeableConcept ab_ = a?.ReasonCode;
			ResourceReference ac_ = a?.ReasonReference;
			List<ResourceReference> ad_ = a?.Insurance;
			List<Annotation> ae_ = a?.Note;
			List<ResourceReference> af_ = a?.RelevantHistory;
			Task.RestrictionComponent ag_ = a?.Restriction;
			List<Task.ParameterComponent> ah_ = a?.Input;
			List<Task.OutputComponent> ai_ = a?.Output;
			Task aj_ = new Task
			{
				Identifier = new List<Identifier>((IEnumerable<Identifier>)e_),
				InstantiatesCanonicalElement = f_,
				InstantiatesUriElement = g_,
				BasedOn = new List<ResourceReference>((IEnumerable<ResourceReference>)h_),
				GroupIdentifier = i_,
				PartOf = new List<ResourceReference>((IEnumerable<ResourceReference>)j_),
				StatusElement = k_,
				StatusReason = l_,
				BusinessStatus = m_,
				IntentElement = n_,
				PriorityElement = o_,
				Code = p_,
				DescriptionElement = q_,
				Focus = r_,
				For = s_,
				Encounter = t_,
				ExecutionPeriod = u_,
				AuthoredOnElement = v_,
				LastModifiedElement = w_,
				Requester = x_,
				PerformerType = new List<CodeableConcept>((IEnumerable<CodeableConcept>)y_),
				Owner = z_,
				Location = aa_,
				ReasonCode = ab_,
				ReasonReference = ac_,
				Insurance = new List<ResourceReference>((IEnumerable<ResourceReference>)ad_),
				Note = new List<Annotation>((IEnumerable<Annotation>)ae_),
				RelevantHistory = new List<ResourceReference>((IEnumerable<ResourceReference>)af_),
				Restriction = ag_,
				Input = new List<Task.ParameterComponent>((IEnumerable<Task.ParameterComponent>)ah_),
				Output = new List<Task.OutputComponent>((IEnumerable<Task.OutputComponent>)ai_),
			};

			return aj_;
		};
		IEnumerable<Task> c_ = context.Operators.Select<Task, Task>((IEnumerable<Task>)a_, b_);
		Task d_ = context.Operators.SingletonFrom<Task>(c_);

		return d_;
	}

    [CqlDeclaration("TerminologyCapabilitiesResource")]
	public TerminologyCapabilities TerminologyCapabilitiesResource(TerminologyCapabilities arg)
	{
		TerminologyCapabilities[] a_ = [
			arg,
		];
		TerminologyCapabilities b_(TerminologyCapabilities a)
		{
			FhirUri e_ = a?.UrlElement;
			FhirString f_ = a?.VersionElement;
			FhirString g_ = a?.NameElement;
			FhirString h_ = a?.TitleElement;
			Code<PublicationStatus> i_ = a?.StatusElement;
			FhirBoolean j_ = a?.ExperimentalElement;
			FhirDateTime k_ = a?.DateElement;
			FhirString l_ = a?.PublisherElement;
			List<ContactDetail> m_ = a?.Contact;
			Markdown n_ = a?.DescriptionElement;
			List<UsageContext> o_ = a?.UseContext;
			List<CodeableConcept> p_ = a?.Jurisdiction;
			Markdown q_ = a?.PurposeElement;
			Markdown r_ = a?.CopyrightElement;
			Code<CapabilityStatementKind> s_ = a?.KindElement;
			TerminologyCapabilities.SoftwareComponent t_ = a?.Software;
			TerminologyCapabilities.ImplementationComponent u_ = a?.Implementation;
			FhirBoolean v_ = a?.LockedDateElement;
			List<TerminologyCapabilities.CodeSystemComponent> w_ = a?.CodeSystem;
			TerminologyCapabilities.ExpansionComponent x_ = a?.Expansion;
			Code<TerminologyCapabilities.CodeSearchSupport> y_ = a?.CodeSearchElement;
			TerminologyCapabilities.ValidateCodeComponent z_ = a?.ValidateCode;
			TerminologyCapabilities.TranslationComponent aa_ = a?.Translation;
			TerminologyCapabilities.ClosureComponent ab_ = a?.Closure;
			TerminologyCapabilities ac_ = new TerminologyCapabilities
			{
				UrlElement = e_,
				VersionElement = f_,
				NameElement = g_,
				TitleElement = h_,
				StatusElement = i_,
				ExperimentalElement = j_,
				DateElement = k_,
				PublisherElement = l_,
				Contact = new List<ContactDetail>((IEnumerable<ContactDetail>)m_),
				DescriptionElement = n_,
				UseContext = new List<UsageContext>((IEnumerable<UsageContext>)o_),
				Jurisdiction = new List<CodeableConcept>((IEnumerable<CodeableConcept>)p_),
				PurposeElement = q_,
				CopyrightElement = r_,
				KindElement = s_,
				Software = t_,
				Implementation = u_,
				LockedDateElement = v_,
				CodeSystem = new List<TerminologyCapabilities.CodeSystemComponent>((IEnumerable<TerminologyCapabilities.CodeSystemComponent>)w_),
				Expansion = x_,
				CodeSearchElement = y_,
				ValidateCode = z_,
				Translation = aa_,
				Closure = ab_,
			};

			return ac_;
		};
		IEnumerable<TerminologyCapabilities> c_ = context.Operators.Select<TerminologyCapabilities, TerminologyCapabilities>((IEnumerable<TerminologyCapabilities>)a_, b_);
		TerminologyCapabilities d_ = context.Operators.SingletonFrom<TerminologyCapabilities>(c_);

		return d_;
	}

    [CqlDeclaration("TestReportResource")]
	public TestReport TestReportResource(TestReport arg)
	{
		TestReport[] a_ = [
			arg,
		];
		TestReport b_(TestReport a)
		{
			Identifier e_ = a?.Identifier;
			FhirString f_ = a?.NameElement;
			Code<TestReport.TestReportStatus> g_ = a?.StatusElement;
			ResourceReference h_ = a?.TestScript;
			Code<TestReport.TestReportResult> i_ = a?.ResultElement;
			FhirDecimal j_ = a?.ScoreElement;
			FhirString k_ = a?.TesterElement;
			FhirDateTime l_ = a?.IssuedElement;
			List<TestReport.ParticipantComponent> m_ = a?.Participant;
			TestReport.SetupComponent n_ = a?.Setup;
			List<TestReport.TestComponent> o_ = a?.Test;
			TestReport.TeardownComponent p_ = a?.Teardown;
			TestReport q_ = new TestReport
			{
				Identifier = e_,
				NameElement = f_,
				StatusElement = g_,
				TestScript = h_,
				ResultElement = i_,
				ScoreElement = j_,
				TesterElement = k_,
				IssuedElement = l_,
				Participant = new List<TestReport.ParticipantComponent>((IEnumerable<TestReport.ParticipantComponent>)m_),
				Setup = n_,
				Test = new List<TestReport.TestComponent>((IEnumerable<TestReport.TestComponent>)o_),
				Teardown = p_,
			};

			return q_;
		};
		IEnumerable<TestReport> c_ = context.Operators.Select<TestReport, TestReport>((IEnumerable<TestReport>)a_, b_);
		TestReport d_ = context.Operators.SingletonFrom<TestReport>(c_);

		return d_;
	}

    [CqlDeclaration("TestScriptResource")]
	public TestScript TestScriptResource(TestScript arg)
	{
		TestScript[] a_ = [
			arg,
		];
		TestScript b_(TestScript a)
		{
			FhirUri e_ = a?.UrlElement;
			Identifier f_ = a?.Identifier;
			FhirString g_ = a?.VersionElement;
			FhirString h_ = a?.NameElement;
			FhirString i_ = a?.TitleElement;
			Code<PublicationStatus> j_ = a?.StatusElement;
			FhirBoolean k_ = a?.ExperimentalElement;
			FhirDateTime l_ = a?.DateElement;
			FhirString m_ = a?.PublisherElement;
			List<ContactDetail> n_ = a?.Contact;
			Markdown o_ = a?.DescriptionElement;
			List<UsageContext> p_ = a?.UseContext;
			List<CodeableConcept> q_ = a?.Jurisdiction;
			Markdown r_ = a?.PurposeElement;
			Markdown s_ = a?.CopyrightElement;
			List<TestScript.OriginComponent> t_ = a?.Origin;
			List<TestScript.DestinationComponent> u_ = a?.Destination;
			TestScript.MetadataComponent v_ = a?.Metadata;
			List<TestScript.FixtureComponent> w_ = a?.Fixture;
			List<ResourceReference> x_ = a?.Profile;
			List<TestScript.VariableComponent> y_ = a?.Variable;
			TestScript.SetupComponent z_ = a?.Setup;
			List<TestScript.TestComponent> aa_ = a?.Test;
			TestScript.TeardownComponent ab_ = a?.Teardown;
			TestScript ac_ = new TestScript
			{
				UrlElement = e_,
				Identifier = f_,
				VersionElement = g_,
				NameElement = h_,
				TitleElement = i_,
				StatusElement = j_,
				ExperimentalElement = k_,
				DateElement = l_,
				PublisherElement = m_,
				Contact = new List<ContactDetail>((IEnumerable<ContactDetail>)n_),
				DescriptionElement = o_,
				UseContext = new List<UsageContext>((IEnumerable<UsageContext>)p_),
				Jurisdiction = new List<CodeableConcept>((IEnumerable<CodeableConcept>)q_),
				PurposeElement = r_,
				CopyrightElement = s_,
				Origin = new List<TestScript.OriginComponent>((IEnumerable<TestScript.OriginComponent>)t_),
				Destination = new List<TestScript.DestinationComponent>((IEnumerable<TestScript.DestinationComponent>)u_),
				Metadata = v_,
				Fixture = new List<TestScript.FixtureComponent>((IEnumerable<TestScript.FixtureComponent>)w_),
				Profile = new List<ResourceReference>((IEnumerable<ResourceReference>)x_),
				Variable = new List<TestScript.VariableComponent>((IEnumerable<TestScript.VariableComponent>)y_),
				Setup = z_,
				Test = new List<TestScript.TestComponent>((IEnumerable<TestScript.TestComponent>)aa_),
				Teardown = ab_,
			};

			return ac_;
		};
		IEnumerable<TestScript> c_ = context.Operators.Select<TestScript, TestScript>((IEnumerable<TestScript>)a_, b_);
		TestScript d_ = context.Operators.SingletonFrom<TestScript>(c_);

		return d_;
	}

    [CqlDeclaration("ValueSetResource")]
	public ValueSet ValueSetResource(ValueSet arg)
	{
		ValueSet[] a_ = [
			arg,
		];
		ValueSet b_(ValueSet a)
		{
			FhirUri e_ = a?.UrlElement;
			List<Identifier> f_ = a?.Identifier;
			FhirString g_ = a?.VersionElement;
			FhirString h_ = a?.NameElement;
			FhirString i_ = a?.TitleElement;
			Code<PublicationStatus> j_ = a?.StatusElement;
			FhirBoolean k_ = a?.ExperimentalElement;
			FhirDateTime l_ = a?.DateElement;
			FhirString m_ = a?.PublisherElement;
			List<ContactDetail> n_ = a?.Contact;
			Markdown o_ = a?.DescriptionElement;
			List<UsageContext> p_ = a?.UseContext;
			List<CodeableConcept> q_ = a?.Jurisdiction;
			FhirBoolean r_ = a?.ImmutableElement;
			Markdown s_ = a?.PurposeElement;
			Markdown t_ = a?.CopyrightElement;
			ValueSet.ComposeComponent u_ = a?.Compose;
			ValueSet.ExpansionComponent v_ = a?.Expansion;
			ValueSet w_ = new ValueSet
			{
				UrlElement = e_,
				Identifier = new List<Identifier>((IEnumerable<Identifier>)f_),
				VersionElement = g_,
				NameElement = h_,
				TitleElement = i_,
				StatusElement = j_,
				ExperimentalElement = k_,
				DateElement = l_,
				PublisherElement = m_,
				Contact = new List<ContactDetail>((IEnumerable<ContactDetail>)n_),
				DescriptionElement = o_,
				UseContext = new List<UsageContext>((IEnumerable<UsageContext>)p_),
				Jurisdiction = new List<CodeableConcept>((IEnumerable<CodeableConcept>)q_),
				ImmutableElement = r_,
				PurposeElement = s_,
				CopyrightElement = t_,
				Compose = u_,
				Expansion = v_,
			};

			return w_;
		};
		IEnumerable<ValueSet> c_ = context.Operators.Select<ValueSet, ValueSet>((IEnumerable<ValueSet>)a_, b_);
		ValueSet d_ = context.Operators.SingletonFrom<ValueSet>(c_);

		return d_;
	}

    [CqlDeclaration("VerificationResultResource")]
	public VerificationResult VerificationResultResource(VerificationResult arg)
	{
		VerificationResult[] a_ = [
			arg,
		];
		VerificationResult b_(VerificationResult a)
		{
			List<ResourceReference> e_ = a?.Target;
			List<FhirString> f_ = a?.TargetLocationElement;
			CodeableConcept g_ = a?.Need;
			Code<VerificationResult.StatusCode> h_ = a?.StatusElement;
			FhirDateTime i_ = a?.StatusDateElement;
			CodeableConcept j_ = a?.ValidationType;
			List<CodeableConcept> k_ = a?.ValidationProcess;
			Timing l_ = a?.Frequency;
			FhirDateTime m_ = a?.LastPerformedElement;
			Date n_ = a?.NextScheduledElement;
			CodeableConcept o_ = a?.FailureAction;
			List<VerificationResult.PrimarySourceComponent> p_ = a?.PrimarySource;
			VerificationResult.AttestationComponent q_ = a?.Attestation;
			List<VerificationResult.ValidatorComponent> r_ = a?.Validator;
			VerificationResult s_ = new VerificationResult
			{
				Target = new List<ResourceReference>((IEnumerable<ResourceReference>)e_),
				TargetLocationElement = new List<FhirString>((IEnumerable<FhirString>)f_),
				Need = g_,
				StatusElement = h_,
				StatusDateElement = i_,
				ValidationType = j_,
				ValidationProcess = new List<CodeableConcept>((IEnumerable<CodeableConcept>)k_),
				Frequency = l_,
				LastPerformedElement = m_,
				NextScheduledElement = n_,
				FailureAction = o_,
				PrimarySource = new List<VerificationResult.PrimarySourceComponent>((IEnumerable<VerificationResult.PrimarySourceComponent>)p_),
				Attestation = q_,
				Validator = new List<VerificationResult.ValidatorComponent>((IEnumerable<VerificationResult.ValidatorComponent>)r_),
			};

			return s_;
		};
		IEnumerable<VerificationResult> c_ = context.Operators.Select<VerificationResult, VerificationResult>((IEnumerable<VerificationResult>)a_, b_);
		VerificationResult d_ = context.Operators.SingletonFrom<VerificationResult>(c_);

		return d_;
	}

    [CqlDeclaration("VisionPrescriptionResource")]
	public VisionPrescription VisionPrescriptionResource(VisionPrescription arg)
	{
		VisionPrescription[] a_ = [
			arg,
		];
		VisionPrescription b_(VisionPrescription a)
		{
			List<Identifier> e_ = a?.Identifier;
			Code<FinancialResourceStatusCodes> f_ = a?.StatusElement;
			FhirDateTime g_ = a?.CreatedElement;
			ResourceReference h_ = a?.Patient;
			ResourceReference i_ = a?.Encounter;
			FhirDateTime j_ = a?.DateWrittenElement;
			ResourceReference k_ = a?.Prescriber;
			List<VisionPrescription.LensSpecificationComponent> l_ = a?.LensSpecification;
			VisionPrescription m_ = new VisionPrescription
			{
				Identifier = new List<Identifier>((IEnumerable<Identifier>)e_),
				StatusElement = f_,
				CreatedElement = g_,
				Patient = h_,
				Encounter = i_,
				DateWrittenElement = j_,
				Prescriber = k_,
				LensSpecification = new List<VisionPrescription.LensSpecificationComponent>((IEnumerable<VisionPrescription.LensSpecificationComponent>)l_),
			};

			return m_;
		};
		IEnumerable<VisionPrescription> c_ = context.Operators.Select<VisionPrescription, VisionPrescription>((IEnumerable<VisionPrescription>)a_, b_);
		VisionPrescription d_ = context.Operators.SingletonFrom<VisionPrescription>(c_);

		return d_;
	}

}

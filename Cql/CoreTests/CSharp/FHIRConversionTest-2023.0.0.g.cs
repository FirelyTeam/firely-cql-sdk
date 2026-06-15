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

[System.CodeDom.Compiler.GeneratedCode(".NET Code Generation", "5.1.2.0")]
[CqlLibrary("FHIRConversionTest", "2023.0.0")]
public partial class FHIRConversionTest_2023_0_0 : ILibrary, ISingleton<FHIRConversionTest_2023_0_0>
{
    #region Functions and Expressions (131)

    [CqlFunctionDefinition("AccountResource")]
    public Account AccountResource(CqlContext context, Account arg)
    {
        Account[] a_ = [
            arg,
        ];

        Account b_(Account a) {
            List<Identifier> f_ = a?.Identifier;
            Code<Account.AccountStatus> g_ = a?.StatusElement;
            CodeableConcept h_ = a?.Type;
            FhirString i_ = a?.NameElement;
            List<ResourceReference> j_ = a?.Subject;
            Period k_ = a?.ServicePeriod;
            List<Account.CoverageComponent> l_ = a?.Coverage;
            ResourceReference m_ = a?.Owner;
            FhirString n_ = a?.DescriptionElement;
            List<Account.GuarantorComponent> o_ = a?.Guarantor;
            ResourceReference p_ = a?.PartOf;
            Account q_ = new Account
            {
                Identifier = new List<Identifier>((IEnumerable<Identifier>)f_),
                StatusElement = g_,
                Type = h_,
                NameElement = i_,
                Subject = new List<ResourceReference>((IEnumerable<ResourceReference>)j_),
                ServicePeriod = k_,
                Coverage = new List<Account.CoverageComponent>((IEnumerable<Account.CoverageComponent>)l_),
                Owner = m_,
                DescriptionElement = n_,
                Guarantor = new List<Account.GuarantorComponent>((IEnumerable<Account.GuarantorComponent>)o_),
                PartOf = p_,
            };
            return q_;
        }

        IEnumerable<Account> c_ = context.Operators.Select<Account, Account>((IEnumerable<Account>)a_, b_);
        IEnumerable<Account> d_ = context.Operators.Distinct<Account>(c_);
        Account e_ = context.Operators.SingletonFrom<Account>(d_);
        return e_;
    }


    [CqlFunctionDefinition("ActivityDefinitionResource")]
    public ActivityDefinition ActivityDefinitionResource(CqlContext context, ActivityDefinition arg)
    {
        ActivityDefinition[] a_ = [
            arg,
        ];

        ActivityDefinition b_(ActivityDefinition a) {
            FhirUri f_ = a?.UrlElement;
            List<Identifier> g_ = a?.Identifier;
            FhirString h_ = a?.VersionElement;
            FhirString i_ = a?.NameElement;
            FhirString j_ = a?.TitleElement;
            FhirString k_ = a?.SubtitleElement;
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
            Code<ActivityDefinition.RequestResourceType> ah_ = a?.KindElement;
            Canonical ai_ = a?.ProfileElement;
            CodeableConcept aj_ = a?.Code;
            Code<RequestIntent> ak_ = a?.IntentElement;
            Code<RequestPriority> al_ = a?.PriorityElement;
            FhirBoolean am_ = a?.DoNotPerformElement;
            DataType an_ = a?.Timing;
            ResourceReference ao_ = a?.Location;
            List<ActivityDefinition.ParticipantComponent> ap_ = a?.Participant;
            DataType aq_ = a?.Product;
            Quantity ar_ = a?.Quantity;
            List<Dosage> as_ = a?.Dosage;
            List<CodeableConcept> at_ = a?.BodySite;
            List<ResourceReference> au_ = a?.SpecimenRequirement;
            List<ResourceReference> av_ = a?.ObservationRequirement;
            List<ResourceReference> aw_ = a?.ObservationResultRequirement;
            Canonical ax_ = a?.TransformElement;
            List<ActivityDefinition.DynamicValueComponent> ay_ = a?.DynamicValue;
            ActivityDefinition az_ = new ActivityDefinition
            {
                UrlElement = f_,
                Identifier = new List<Identifier>((IEnumerable<Identifier>)g_),
                VersionElement = h_,
                NameElement = i_,
                TitleElement = j_,
                SubtitleElement = k_,
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
                KindElement = ah_,
                ProfileElement = ai_,
                Code = aj_,
                IntentElement = ak_,
                PriorityElement = al_,
                DoNotPerformElement = am_,
                Timing = (DataType)an_,
                Location = ao_,
                Participant = new List<ActivityDefinition.ParticipantComponent>((IEnumerable<ActivityDefinition.ParticipantComponent>)ap_),
                Product = (DataType)aq_,
                Quantity = ar_,
                Dosage = new List<Dosage>((IEnumerable<Dosage>)as_),
                BodySite = new List<CodeableConcept>((IEnumerable<CodeableConcept>)at_),
                SpecimenRequirement = new List<ResourceReference>((IEnumerable<ResourceReference>)au_),
                ObservationRequirement = new List<ResourceReference>((IEnumerable<ResourceReference>)av_),
                ObservationResultRequirement = new List<ResourceReference>((IEnumerable<ResourceReference>)aw_),
                TransformElement = ax_,
                DynamicValue = new List<ActivityDefinition.DynamicValueComponent>((IEnumerable<ActivityDefinition.DynamicValueComponent>)ay_),
            };
            return az_;
        }

        IEnumerable<ActivityDefinition> c_ = context.Operators.Select<ActivityDefinition, ActivityDefinition>((IEnumerable<ActivityDefinition>)a_, b_);
        IEnumerable<ActivityDefinition> d_ = context.Operators.Distinct<ActivityDefinition>(c_);
        ActivityDefinition e_ = context.Operators.SingletonFrom<ActivityDefinition>(d_);
        return e_;
    }


    [CqlFunctionDefinition("AdverseEventResource")]
    public AdverseEvent AdverseEventResource(CqlContext context, AdverseEvent arg)
    {
        AdverseEvent[] a_ = [
            arg,
        ];

        AdverseEvent b_(AdverseEvent a) {
            Identifier f_ = a?.Identifier;
            Code<AdverseEvent.AdverseEventActuality> g_ = a?.ActualityElement;
            List<CodeableConcept> h_ = a?.Category;
            CodeableConcept i_ = a?.Event;
            ResourceReference j_ = a?.Subject;
            ResourceReference k_ = a?.Encounter;
            FhirDateTime l_ = a?.DateElement;
            FhirDateTime m_ = a?.DetectedElement;
            FhirDateTime n_ = a?.RecordedDateElement;
            List<ResourceReference> o_ = a?.ResultingCondition;
            ResourceReference p_ = a?.Location;
            CodeableConcept q_ = a?.Seriousness;
            CodeableConcept r_ = a?.Severity;
            CodeableConcept s_ = a?.Outcome;
            ResourceReference t_ = a?.Recorder;
            List<ResourceReference> u_ = a?.Contributor;
            List<AdverseEvent.SuspectEntityComponent> v_ = a?.SuspectEntity;
            List<ResourceReference> w_ = a?.SubjectMedicalHistory;
            List<ResourceReference> x_ = a?.ReferenceDocument;
            List<ResourceReference> y_ = a?.Study;
            AdverseEvent z_ = new AdverseEvent
            {
                Identifier = f_,
                ActualityElement = g_,
                Category = new List<CodeableConcept>((IEnumerable<CodeableConcept>)h_),
                Event = i_,
                Subject = j_,
                Encounter = k_,
                DateElement = l_,
                DetectedElement = m_,
                RecordedDateElement = n_,
                ResultingCondition = new List<ResourceReference>((IEnumerable<ResourceReference>)o_),
                Location = p_,
                Seriousness = q_,
                Severity = r_,
                Outcome = s_,
                Recorder = t_,
                Contributor = new List<ResourceReference>((IEnumerable<ResourceReference>)u_),
                SuspectEntity = new List<AdverseEvent.SuspectEntityComponent>((IEnumerable<AdverseEvent.SuspectEntityComponent>)v_),
                SubjectMedicalHistory = new List<ResourceReference>((IEnumerable<ResourceReference>)w_),
                ReferenceDocument = new List<ResourceReference>((IEnumerable<ResourceReference>)x_),
                Study = new List<ResourceReference>((IEnumerable<ResourceReference>)y_),
            };
            return z_;
        }

        IEnumerable<AdverseEvent> c_ = context.Operators.Select<AdverseEvent, AdverseEvent>((IEnumerable<AdverseEvent>)a_, b_);
        IEnumerable<AdverseEvent> d_ = context.Operators.Distinct<AdverseEvent>(c_);
        AdverseEvent e_ = context.Operators.SingletonFrom<AdverseEvent>(d_);
        return e_;
    }


    [CqlFunctionDefinition("AllergyIntoleranceResource")]
    public AllergyIntolerance AllergyIntoleranceResource(CqlContext context, AllergyIntolerance arg)
    {
        AllergyIntolerance[] a_ = [
            arg,
        ];

        AllergyIntolerance b_(AllergyIntolerance a) {
            List<Identifier> f_ = a?.Identifier;
            CodeableConcept g_ = a?.ClinicalStatus;
            CodeableConcept h_ = a?.VerificationStatus;
            Code<AllergyIntolerance.AllergyIntoleranceType> i_ = a?.TypeElement;
            List<Code<AllergyIntolerance.AllergyIntoleranceCategory>> j_ = a?.CategoryElement;
            Code<AllergyIntolerance.AllergyIntoleranceCriticality> k_ = a?.CriticalityElement;
            CodeableConcept l_ = a?.Code;
            ResourceReference m_ = a?.Patient;
            ResourceReference n_ = a?.Encounter;
            DataType o_ = a?.Onset;
            FhirDateTime p_ = a?.RecordedDateElement;
            ResourceReference q_ = a?.Recorder;
            ResourceReference r_ = a?.Asserter;
            FhirDateTime s_ = a?.LastOccurrenceElement;
            List<Annotation> t_ = a?.Note;
            List<AllergyIntolerance.ReactionComponent> u_ = a?.Reaction;
            AllergyIntolerance v_ = new AllergyIntolerance
            {
                Identifier = new List<Identifier>((IEnumerable<Identifier>)f_),
                ClinicalStatus = g_,
                VerificationStatus = h_,
                TypeElement = i_,
                CategoryElement = new List<Code<AllergyIntolerance.AllergyIntoleranceCategory>>((IEnumerable<Code<AllergyIntolerance.AllergyIntoleranceCategory>>)j_),
                CriticalityElement = k_,
                Code = l_,
                Patient = m_,
                Encounter = n_,
                Onset = (DataType)o_,
                RecordedDateElement = p_,
                Recorder = q_,
                Asserter = r_,
                LastOccurrenceElement = s_,
                Note = new List<Annotation>((IEnumerable<Annotation>)t_),
                Reaction = new List<AllergyIntolerance.ReactionComponent>((IEnumerable<AllergyIntolerance.ReactionComponent>)u_),
            };
            return v_;
        }

        IEnumerable<AllergyIntolerance> c_ = context.Operators.Select<AllergyIntolerance, AllergyIntolerance>((IEnumerable<AllergyIntolerance>)a_, b_);
        IEnumerable<AllergyIntolerance> d_ = context.Operators.Distinct<AllergyIntolerance>(c_);
        AllergyIntolerance e_ = context.Operators.SingletonFrom<AllergyIntolerance>(d_);
        return e_;
    }


    [CqlFunctionDefinition("AppointmentResource")]
    public Appointment AppointmentResource(CqlContext context, Appointment arg)
    {
        Appointment[] a_ = [
            arg,
        ];

        Appointment b_(Appointment a) {
            List<Identifier> f_ = a?.Identifier;
            Code<Appointment.AppointmentStatus> g_ = a?.StatusElement;
            CodeableConcept h_ = a?.CancelationReason;
            List<CodeableConcept> i_ = a?.ServiceCategory;
            List<CodeableConcept> j_ = a?.ServiceType;
            List<CodeableConcept> k_ = a?.Specialty;
            CodeableConcept l_ = a?.AppointmentType;
            List<CodeableConcept> m_ = a?.ReasonCode;
            List<ResourceReference> n_ = a?.ReasonReference;
            UnsignedInt o_ = a?.PriorityElement;
            Integer p_ = context.Operators.Convert<Integer>(o_);
            UnsignedInt q_ = context.Operators.Convert<UnsignedInt>(p_);
            FhirString r_ = a?.DescriptionElement;
            List<ResourceReference> s_ = a?.SupportingInformation;
            Instant t_ = a?.StartElement;
            Instant u_ = a?.EndElement;
            PositiveInt v_ = a?.MinutesDurationElement;
            Integer w_ = context.Operators.Convert<Integer>(v_);
            PositiveInt x_ = context.Operators.Convert<PositiveInt>(w_);
            List<ResourceReference> y_ = a?.Slot;
            FhirDateTime z_ = a?.CreatedElement;
            FhirString aa_ = a?.CommentElement;
            FhirString ab_ = a?.PatientInstructionElement;
            List<ResourceReference> ac_ = a?.BasedOn;
            List<Appointment.ParticipantComponent> ad_ = a?.Participant;
            List<Period> ae_ = a?.RequestedPeriod;
            Appointment af_ = new Appointment
            {
                Identifier = new List<Identifier>((IEnumerable<Identifier>)f_),
                StatusElement = g_,
                CancelationReason = h_,
                ServiceCategory = new List<CodeableConcept>((IEnumerable<CodeableConcept>)i_),
                ServiceType = new List<CodeableConcept>((IEnumerable<CodeableConcept>)j_),
                Specialty = new List<CodeableConcept>((IEnumerable<CodeableConcept>)k_),
                AppointmentType = l_,
                ReasonCode = new List<CodeableConcept>((IEnumerable<CodeableConcept>)m_),
                ReasonReference = new List<ResourceReference>((IEnumerable<ResourceReference>)n_),
                PriorityElement = q_,
                DescriptionElement = r_,
                SupportingInformation = new List<ResourceReference>((IEnumerable<ResourceReference>)s_),
                StartElement = t_,
                EndElement = u_,
                MinutesDurationElement = x_,
                Slot = new List<ResourceReference>((IEnumerable<ResourceReference>)y_),
                CreatedElement = z_,
                CommentElement = aa_,
                PatientInstructionElement = ab_,
                BasedOn = new List<ResourceReference>((IEnumerable<ResourceReference>)ac_),
                Participant = new List<Appointment.ParticipantComponent>((IEnumerable<Appointment.ParticipantComponent>)ad_),
                RequestedPeriod = new List<Period>((IEnumerable<Period>)ae_),
            };
            return af_;
        }

        IEnumerable<Appointment> c_ = context.Operators.Select<Appointment, Appointment>((IEnumerable<Appointment>)a_, b_);
        IEnumerable<Appointment> d_ = context.Operators.Distinct<Appointment>(c_);
        Appointment e_ = context.Operators.SingletonFrom<Appointment>(d_);
        return e_;
    }


    [CqlFunctionDefinition("AppointmentResponseResource")]
    public AppointmentResponse AppointmentResponseResource(CqlContext context, AppointmentResponse arg)
    {
        AppointmentResponse[] a_ = [
            arg,
        ];

        AppointmentResponse b_(AppointmentResponse a) {
            List<Identifier> f_ = a?.Identifier;
            ResourceReference g_ = a?.Appointment;
            Instant h_ = a?.StartElement;
            Instant i_ = a?.EndElement;
            List<CodeableConcept> j_ = a?.ParticipantType;
            ResourceReference k_ = a?.Actor;
            Code<ParticipationStatus> l_ = a?.ParticipantStatusElement;
            FhirString m_ = a?.CommentElement;
            AppointmentResponse n_ = new AppointmentResponse
            {
                Identifier = new List<Identifier>((IEnumerable<Identifier>)f_),
                Appointment = g_,
                StartElement = h_,
                EndElement = i_,
                ParticipantType = new List<CodeableConcept>((IEnumerable<CodeableConcept>)j_),
                Actor = k_,
                ParticipantStatusElement = l_,
                CommentElement = m_,
            };
            return n_;
        }

        IEnumerable<AppointmentResponse> c_ = context.Operators.Select<AppointmentResponse, AppointmentResponse>((IEnumerable<AppointmentResponse>)a_, b_);
        IEnumerable<AppointmentResponse> d_ = context.Operators.Distinct<AppointmentResponse>(c_);
        AppointmentResponse e_ = context.Operators.SingletonFrom<AppointmentResponse>(d_);
        return e_;
    }


    [CqlFunctionDefinition("AuditEventResource")]
    public AuditEvent AuditEventResource(CqlContext context, AuditEvent arg)
    {
        AuditEvent[] a_ = [
            arg,
        ];

        AuditEvent b_(AuditEvent a) {
            Coding f_ = a?.Type;
            List<Coding> g_ = a?.Subtype;
            Code<AuditEvent.AuditEventAction> h_ = a?.ActionElement;
            Period i_ = a?.Period;
            Instant j_ = a?.RecordedElement;
            Code<AuditEvent.AuditEventOutcome> k_ = a?.OutcomeElement;
            FhirString l_ = a?.OutcomeDescElement;
            List<CodeableConcept> m_ = a?.PurposeOfEvent;
            List<AuditEvent.AgentComponent> n_ = a?.Agent;
            AuditEvent.SourceComponent o_ = a?.Source;
            List<AuditEvent.EntityComponent> p_ = a?.Entity;
            AuditEvent q_ = new AuditEvent
            {
                Type = f_,
                Subtype = new List<Coding>((IEnumerable<Coding>)g_),
                ActionElement = h_,
                Period = i_,
                RecordedElement = j_,
                OutcomeElement = k_,
                OutcomeDescElement = l_,
                PurposeOfEvent = new List<CodeableConcept>((IEnumerable<CodeableConcept>)m_),
                Agent = new List<AuditEvent.AgentComponent>((IEnumerable<AuditEvent.AgentComponent>)n_),
                Source = o_,
                Entity = new List<AuditEvent.EntityComponent>((IEnumerable<AuditEvent.EntityComponent>)p_),
            };
            return q_;
        }

        IEnumerable<AuditEvent> c_ = context.Operators.Select<AuditEvent, AuditEvent>((IEnumerable<AuditEvent>)a_, b_);
        IEnumerable<AuditEvent> d_ = context.Operators.Distinct<AuditEvent>(c_);
        AuditEvent e_ = context.Operators.SingletonFrom<AuditEvent>(d_);
        return e_;
    }


    [CqlFunctionDefinition("BasicResource")]
    public Basic BasicResource(CqlContext context, Basic arg)
    {
        Basic[] a_ = [
            arg,
        ];

        Basic b_(Basic a) {
            List<Identifier> f_ = a?.Identifier;
            CodeableConcept g_ = a?.Code;
            ResourceReference h_ = a?.Subject;
            Date i_ = a?.CreatedElement;
            ResourceReference j_ = a?.Author;
            Basic k_ = new Basic
            {
                Identifier = new List<Identifier>((IEnumerable<Identifier>)f_),
                Code = g_,
                Subject = h_,
                CreatedElement = i_,
                Author = j_,
            };
            return k_;
        }

        IEnumerable<Basic> c_ = context.Operators.Select<Basic, Basic>((IEnumerable<Basic>)a_, b_);
        IEnumerable<Basic> d_ = context.Operators.Distinct<Basic>(c_);
        Basic e_ = context.Operators.SingletonFrom<Basic>(d_);
        return e_;
    }


    [CqlFunctionDefinition("BiologicallyDerivedProductResource")]
    public BiologicallyDerivedProduct BiologicallyDerivedProductResource(CqlContext context, BiologicallyDerivedProduct arg)
    {
        BiologicallyDerivedProduct[] a_ = [
            arg,
        ];

        BiologicallyDerivedProduct b_(BiologicallyDerivedProduct a) {
            List<Identifier> f_ = a?.Identifier;
            Code<BiologicallyDerivedProduct.BiologicallyDerivedProductCategory> g_ = a?.ProductCategoryElement;
            CodeableConcept h_ = a?.ProductCode;
            Code<BiologicallyDerivedProduct.BiologicallyDerivedProductStatus> i_ = a?.StatusElement;
            List<ResourceReference> j_ = a?.Request;
            Integer k_ = a?.QuantityElement;
            List<ResourceReference> l_ = a?.Parent;
            BiologicallyDerivedProduct.CollectionComponent m_ = a?.Collection;
            List<BiologicallyDerivedProduct.ProcessingComponent> n_ = a?.Processing;
            BiologicallyDerivedProduct.ManipulationComponent o_ = a?.Manipulation;
            List<BiologicallyDerivedProduct.StorageComponent> p_ = a?.Storage;
            BiologicallyDerivedProduct q_ = new BiologicallyDerivedProduct
            {
                Identifier = new List<Identifier>((IEnumerable<Identifier>)f_),
                ProductCategoryElement = g_,
                ProductCode = h_,
                StatusElement = i_,
                Request = new List<ResourceReference>((IEnumerable<ResourceReference>)j_),
                QuantityElement = k_,
                Parent = new List<ResourceReference>((IEnumerable<ResourceReference>)l_),
                Collection = m_,
                Processing = new List<BiologicallyDerivedProduct.ProcessingComponent>((IEnumerable<BiologicallyDerivedProduct.ProcessingComponent>)n_),
                Manipulation = o_,
                Storage = new List<BiologicallyDerivedProduct.StorageComponent>((IEnumerable<BiologicallyDerivedProduct.StorageComponent>)p_),
            };
            return q_;
        }

        IEnumerable<BiologicallyDerivedProduct> c_ = context.Operators.Select<BiologicallyDerivedProduct, BiologicallyDerivedProduct>((IEnumerable<BiologicallyDerivedProduct>)a_, b_);
        IEnumerable<BiologicallyDerivedProduct> d_ = context.Operators.Distinct<BiologicallyDerivedProduct>(c_);
        BiologicallyDerivedProduct e_ = context.Operators.SingletonFrom<BiologicallyDerivedProduct>(d_);
        return e_;
    }


    [CqlFunctionDefinition("BodyStructureResource")]
    public BodyStructure BodyStructureResource(CqlContext context, BodyStructure arg)
    {
        BodyStructure[] a_ = [
            arg,
        ];

        BodyStructure b_(BodyStructure a) {
            List<Identifier> f_ = a?.Identifier;
            FhirBoolean g_ = a?.ActiveElement;
            CodeableConcept h_ = a?.Morphology;
            CodeableConcept i_ = a?.Location;
            List<CodeableConcept> j_ = a?.LocationQualifier;
            FhirString k_ = a?.DescriptionElement;
            List<Attachment> l_ = a?.Image;
            ResourceReference m_ = a?.Patient;
            BodyStructure n_ = new BodyStructure
            {
                Identifier = new List<Identifier>((IEnumerable<Identifier>)f_),
                ActiveElement = g_,
                Morphology = h_,
                Location = i_,
                LocationQualifier = new List<CodeableConcept>((IEnumerable<CodeableConcept>)j_),
                DescriptionElement = k_,
                Image = new List<Attachment>((IEnumerable<Attachment>)l_),
                Patient = m_,
            };
            return n_;
        }

        IEnumerable<BodyStructure> c_ = context.Operators.Select<BodyStructure, BodyStructure>((IEnumerable<BodyStructure>)a_, b_);
        IEnumerable<BodyStructure> d_ = context.Operators.Distinct<BodyStructure>(c_);
        BodyStructure e_ = context.Operators.SingletonFrom<BodyStructure>(d_);
        return e_;
    }


    [CqlFunctionDefinition("CarePlanResource")]
    public CarePlan CarePlanResource(CqlContext context, CarePlan arg)
    {
        CarePlan[] a_ = [
            arg,
        ];

        CarePlan b_(CarePlan a) {
            List<Identifier> f_ = a?.Identifier;
            List<Canonical> g_ = a?.InstantiatesCanonicalElement;
            List<FhirUri> h_ = a?.InstantiatesUriElement;
            List<ResourceReference> i_ = a?.BasedOn;
            List<ResourceReference> j_ = a?.Replaces;
            List<ResourceReference> k_ = a?.PartOf;
            Code<RequestStatus> l_ = a?.StatusElement;
            Code<CarePlan.CarePlanIntent> m_ = a?.IntentElement;
            List<CodeableConcept> n_ = a?.Category;
            FhirString o_ = a?.TitleElement;
            FhirString p_ = a?.DescriptionElement;
            ResourceReference q_ = a?.Subject;
            ResourceReference r_ = a?.Encounter;
            Period s_ = a?.Period;
            FhirDateTime t_ = a?.CreatedElement;
            ResourceReference u_ = a?.Author;
            List<ResourceReference> v_ = a?.Contributor;
            List<ResourceReference> w_ = a?.CareTeam;
            List<ResourceReference> x_ = a?.Addresses;
            List<ResourceReference> y_ = a?.SupportingInfo;
            List<ResourceReference> z_ = a?.Goal;
            List<CarePlan.ActivityComponent> aa_ = a?.Activity;
            List<Annotation> ab_ = a?.Note;
            CarePlan ac_ = new CarePlan
            {
                Identifier = new List<Identifier>((IEnumerable<Identifier>)f_),
                InstantiatesCanonicalElement = new List<Canonical>((IEnumerable<Canonical>)g_),
                InstantiatesUriElement = new List<FhirUri>((IEnumerable<FhirUri>)h_),
                BasedOn = new List<ResourceReference>((IEnumerable<ResourceReference>)i_),
                Replaces = new List<ResourceReference>((IEnumerable<ResourceReference>)j_),
                PartOf = new List<ResourceReference>((IEnumerable<ResourceReference>)k_),
                StatusElement = l_,
                IntentElement = m_,
                Category = new List<CodeableConcept>((IEnumerable<CodeableConcept>)n_),
                TitleElement = o_,
                DescriptionElement = p_,
                Subject = q_,
                Encounter = r_,
                Period = s_,
                CreatedElement = t_,
                Author = u_,
                Contributor = new List<ResourceReference>((IEnumerable<ResourceReference>)v_),
                CareTeam = new List<ResourceReference>((IEnumerable<ResourceReference>)w_),
                Addresses = new List<ResourceReference>((IEnumerable<ResourceReference>)x_),
                SupportingInfo = new List<ResourceReference>((IEnumerable<ResourceReference>)y_),
                Goal = new List<ResourceReference>((IEnumerable<ResourceReference>)z_),
                Activity = new List<CarePlan.ActivityComponent>((IEnumerable<CarePlan.ActivityComponent>)aa_),
                Note = new List<Annotation>((IEnumerable<Annotation>)ab_),
            };
            return ac_;
        }

        IEnumerable<CarePlan> c_ = context.Operators.Select<CarePlan, CarePlan>((IEnumerable<CarePlan>)a_, b_);
        IEnumerable<CarePlan> d_ = context.Operators.Distinct<CarePlan>(c_);
        CarePlan e_ = context.Operators.SingletonFrom<CarePlan>(d_);
        return e_;
    }


    [CqlFunctionDefinition("CareTeamResource")]
    public CareTeam CareTeamResource(CqlContext context, CareTeam arg)
    {
        CareTeam[] a_ = [
            arg,
        ];

        CareTeam b_(CareTeam a) {
            List<Identifier> f_ = a?.Identifier;
            Code<CareTeam.CareTeamStatus> g_ = a?.StatusElement;
            List<CodeableConcept> h_ = a?.Category;
            FhirString i_ = a?.NameElement;
            ResourceReference j_ = a?.Subject;
            ResourceReference k_ = a?.Encounter;
            Period l_ = a?.Period;
            List<CareTeam.ParticipantComponent> m_ = a?.Participant;
            List<CodeableConcept> n_ = a?.ReasonCode;
            List<ResourceReference> o_ = a?.ReasonReference;
            List<ResourceReference> p_ = a?.ManagingOrganization;
            List<ContactPoint> q_ = a?.Telecom;
            List<Annotation> r_ = a?.Note;
            CareTeam s_ = new CareTeam
            {
                Identifier = new List<Identifier>((IEnumerable<Identifier>)f_),
                StatusElement = g_,
                Category = new List<CodeableConcept>((IEnumerable<CodeableConcept>)h_),
                NameElement = i_,
                Subject = j_,
                Encounter = k_,
                Period = l_,
                Participant = new List<CareTeam.ParticipantComponent>((IEnumerable<CareTeam.ParticipantComponent>)m_),
                ReasonCode = new List<CodeableConcept>((IEnumerable<CodeableConcept>)n_),
                ReasonReference = new List<ResourceReference>((IEnumerable<ResourceReference>)o_),
                ManagingOrganization = new List<ResourceReference>((IEnumerable<ResourceReference>)p_),
                Telecom = new List<ContactPoint>((IEnumerable<ContactPoint>)q_),
                Note = new List<Annotation>((IEnumerable<Annotation>)r_),
            };
            return s_;
        }

        IEnumerable<CareTeam> c_ = context.Operators.Select<CareTeam, CareTeam>((IEnumerable<CareTeam>)a_, b_);
        IEnumerable<CareTeam> d_ = context.Operators.Distinct<CareTeam>(c_);
        CareTeam e_ = context.Operators.SingletonFrom<CareTeam>(d_);
        return e_;
    }


    [CqlFunctionDefinition("CatalogEntryResource")]
    public CatalogEntry CatalogEntryResource(CqlContext context, CatalogEntry arg)
    {
        CatalogEntry[] a_ = [
            arg,
        ];

        CatalogEntry b_(CatalogEntry a) {
            List<Identifier> f_ = a?.Identifier;
            CodeableConcept g_ = a?.Type;
            FhirBoolean h_ = a?.OrderableElement;
            ResourceReference i_ = a?.ReferencedItem;
            List<Identifier> j_ = a?.AdditionalIdentifier;
            List<CodeableConcept> k_ = a?.Classification;
            Code<PublicationStatus> l_ = a?.StatusElement;
            Period m_ = a?.ValidityPeriod;
            FhirDateTime n_ = a?.ValidToElement;
            FhirDateTime o_ = a?.LastUpdatedElement;
            List<CodeableConcept> p_ = a?.AdditionalCharacteristic;
            List<CodeableConcept> q_ = a?.AdditionalClassification;
            List<CatalogEntry.RelatedEntryComponent> r_ = a?.RelatedEntry;
            CatalogEntry s_ = new CatalogEntry
            {
                Identifier = new List<Identifier>((IEnumerable<Identifier>)f_),
                Type = g_,
                OrderableElement = h_,
                ReferencedItem = i_,
                AdditionalIdentifier = new List<Identifier>((IEnumerable<Identifier>)j_),
                Classification = new List<CodeableConcept>((IEnumerable<CodeableConcept>)k_),
                StatusElement = l_,
                ValidityPeriod = m_,
                ValidToElement = n_,
                LastUpdatedElement = o_,
                AdditionalCharacteristic = new List<CodeableConcept>((IEnumerable<CodeableConcept>)p_),
                AdditionalClassification = new List<CodeableConcept>((IEnumerable<CodeableConcept>)q_),
                RelatedEntry = new List<CatalogEntry.RelatedEntryComponent>((IEnumerable<CatalogEntry.RelatedEntryComponent>)r_),
            };
            return s_;
        }

        IEnumerable<CatalogEntry> c_ = context.Operators.Select<CatalogEntry, CatalogEntry>((IEnumerable<CatalogEntry>)a_, b_);
        IEnumerable<CatalogEntry> d_ = context.Operators.Distinct<CatalogEntry>(c_);
        CatalogEntry e_ = context.Operators.SingletonFrom<CatalogEntry>(d_);
        return e_;
    }


    [CqlFunctionDefinition("ChargeItemResource")]
    public ChargeItem ChargeItemResource(CqlContext context, ChargeItem arg)
    {
        ChargeItem[] a_ = [
            arg,
        ];

        ChargeItem b_(ChargeItem a) {
            List<Identifier> f_ = a?.Identifier;
            List<FhirUri> g_ = a?.DefinitionUriElement;
            List<Canonical> h_ = a?.DefinitionCanonicalElement;
            Code<ChargeItem.ChargeItemStatus> i_ = a?.StatusElement;
            List<ResourceReference> j_ = a?.PartOf;
            CodeableConcept k_ = a?.Code;
            ResourceReference l_ = a?.Subject;
            ResourceReference m_ = a?.Context;
            DataType n_ = a?.Occurrence;
            List<ChargeItem.PerformerComponent> o_ = a?.Performer;
            ResourceReference p_ = a?.PerformingOrganization;
            ResourceReference q_ = a?.RequestingOrganization;
            ResourceReference r_ = a?.CostCenter;
            Quantity s_ = a?.Quantity;
            List<CodeableConcept> t_ = a?.Bodysite;
            FhirDecimal u_ = a?.FactorOverrideElement;
            Money v_ = a?.PriceOverride;
            FhirString w_ = a?.OverrideReasonElement;
            ResourceReference x_ = a?.Enterer;
            FhirDateTime y_ = a?.EnteredDateElement;
            List<CodeableConcept> z_ = a?.Reason;
            List<ResourceReference> aa_ = a?.Service;
            DataType ab_ = a?.Product;
            List<ResourceReference> ac_ = a?.Account;
            List<Annotation> ad_ = a?.Note;
            List<ResourceReference> ae_ = a?.SupportingInformation;
            ChargeItem af_ = new ChargeItem
            {
                Identifier = new List<Identifier>((IEnumerable<Identifier>)f_),
                DefinitionUriElement = new List<FhirUri>((IEnumerable<FhirUri>)g_),
                DefinitionCanonicalElement = new List<Canonical>((IEnumerable<Canonical>)h_),
                StatusElement = i_,
                PartOf = new List<ResourceReference>((IEnumerable<ResourceReference>)j_),
                Code = k_,
                Subject = l_,
                Context = m_,
                Occurrence = (DataType)n_,
                Performer = new List<ChargeItem.PerformerComponent>((IEnumerable<ChargeItem.PerformerComponent>)o_),
                PerformingOrganization = p_,
                RequestingOrganization = q_,
                CostCenter = r_,
                Quantity = s_,
                Bodysite = new List<CodeableConcept>((IEnumerable<CodeableConcept>)t_),
                FactorOverrideElement = u_,
                PriceOverride = v_,
                OverrideReasonElement = w_,
                Enterer = x_,
                EnteredDateElement = y_,
                Reason = new List<CodeableConcept>((IEnumerable<CodeableConcept>)z_),
                Service = new List<ResourceReference>((IEnumerable<ResourceReference>)aa_),
                Product = (DataType)ab_,
                Account = new List<ResourceReference>((IEnumerable<ResourceReference>)ac_),
                Note = new List<Annotation>((IEnumerable<Annotation>)ad_),
                SupportingInformation = new List<ResourceReference>((IEnumerable<ResourceReference>)ae_),
            };
            return af_;
        }

        IEnumerable<ChargeItem> c_ = context.Operators.Select<ChargeItem, ChargeItem>((IEnumerable<ChargeItem>)a_, b_);
        IEnumerable<ChargeItem> d_ = context.Operators.Distinct<ChargeItem>(c_);
        ChargeItem e_ = context.Operators.SingletonFrom<ChargeItem>(d_);
        return e_;
    }


    [CqlFunctionDefinition("ChargeItemDefinitionResource")]
    public ChargeItemDefinition ChargeItemDefinitionResource(CqlContext context, ChargeItemDefinition arg)
    {
        ChargeItemDefinition[] a_ = [
            arg,
        ];

        ChargeItemDefinition b_(ChargeItemDefinition a) {
            FhirUri f_ = a?.UrlElement;
            List<Identifier> g_ = a?.Identifier;
            FhirString h_ = a?.VersionElement;
            FhirString i_ = a?.TitleElement;
            List<FhirUri> j_ = a?.DerivedFromUriElement;
            List<Canonical> k_ = a?.PartOfElement;
            List<Canonical> l_ = a?.ReplacesElement;
            Code<PublicationStatus> m_ = a?.StatusElement;
            FhirBoolean n_ = a?.ExperimentalElement;
            FhirDateTime o_ = a?.DateElement;
            FhirString p_ = a?.PublisherElement;
            List<ContactDetail> q_ = a?.Contact;
            Markdown r_ = a?.DescriptionElement;
            List<UsageContext> s_ = a?.UseContext;
            List<CodeableConcept> t_ = a?.Jurisdiction;
            Markdown u_ = a?.CopyrightElement;
            Date v_ = a?.ApprovalDateElement;
            Date w_ = a?.LastReviewDateElement;
            Period x_ = a?.EffectivePeriod;
            CodeableConcept y_ = a?.Code;
            List<ResourceReference> z_ = a?.Instance;
            List<ChargeItemDefinition.ApplicabilityComponent> aa_ = a?.Applicability;
            List<ChargeItemDefinition.PropertyGroupComponent> ab_ = a?.PropertyGroup;
            ChargeItemDefinition ac_ = new ChargeItemDefinition
            {
                UrlElement = f_,
                Identifier = new List<Identifier>((IEnumerable<Identifier>)g_),
                VersionElement = h_,
                TitleElement = i_,
                DerivedFromUriElement = new List<FhirUri>((IEnumerable<FhirUri>)j_),
                PartOfElement = new List<Canonical>((IEnumerable<Canonical>)k_),
                ReplacesElement = new List<Canonical>((IEnumerable<Canonical>)l_),
                StatusElement = m_,
                ExperimentalElement = n_,
                DateElement = o_,
                PublisherElement = p_,
                Contact = new List<ContactDetail>((IEnumerable<ContactDetail>)q_),
                DescriptionElement = r_,
                UseContext = new List<UsageContext>((IEnumerable<UsageContext>)s_),
                Jurisdiction = new List<CodeableConcept>((IEnumerable<CodeableConcept>)t_),
                CopyrightElement = u_,
                ApprovalDateElement = v_,
                LastReviewDateElement = w_,
                EffectivePeriod = x_,
                Code = y_,
                Instance = new List<ResourceReference>((IEnumerable<ResourceReference>)z_),
                Applicability = new List<ChargeItemDefinition.ApplicabilityComponent>((IEnumerable<ChargeItemDefinition.ApplicabilityComponent>)aa_),
                PropertyGroup = new List<ChargeItemDefinition.PropertyGroupComponent>((IEnumerable<ChargeItemDefinition.PropertyGroupComponent>)ab_),
            };
            return ac_;
        }

        IEnumerable<ChargeItemDefinition> c_ = context.Operators.Select<ChargeItemDefinition, ChargeItemDefinition>((IEnumerable<ChargeItemDefinition>)a_, b_);
        IEnumerable<ChargeItemDefinition> d_ = context.Operators.Distinct<ChargeItemDefinition>(c_);
        ChargeItemDefinition e_ = context.Operators.SingletonFrom<ChargeItemDefinition>(d_);
        return e_;
    }


    [CqlFunctionDefinition("ClaimResource")]
    public Claim ClaimResource(CqlContext context, Claim arg)
    {
        Claim[] a_ = [
            arg,
        ];

        Claim b_(Claim a) {
            List<Identifier> f_ = a?.Identifier;
            Code<FinancialResourceStatusCodes> g_ = a?.StatusElement;
            CodeableConcept h_ = a?.Type;
            CodeableConcept i_ = a?.SubType;
            Code<ClaimUseCode> j_ = a?.UseElement;
            ResourceReference k_ = a?.Patient;
            Period l_ = a?.BillablePeriod;
            FhirDateTime m_ = a?.CreatedElement;
            ResourceReference n_ = a?.Enterer;
            ResourceReference o_ = a?.Insurer;
            ResourceReference p_ = a?.Provider;
            CodeableConcept q_ = a?.Priority;
            CodeableConcept r_ = a?.FundsReserve;
            List<Claim.RelatedClaimComponent> s_ = a?.Related;
            ResourceReference t_ = a?.Prescription;
            ResourceReference u_ = a?.OriginalPrescription;
            Claim.PayeeComponent v_ = a?.Payee;
            ResourceReference w_ = a?.Referral;
            ResourceReference x_ = a?.Facility;
            List<Claim.CareTeamComponent> y_ = a?.CareTeam;
            List<Claim.SupportingInformationComponent> z_ = a?.SupportingInfo;
            List<Claim.DiagnosisComponent> aa_ = a?.Diagnosis;
            List<Claim.ProcedureComponent> ab_ = a?.Procedure;
            List<Claim.InsuranceComponent> ac_ = a?.Insurance;
            Claim.AccidentComponent ad_ = a?.Accident;
            List<Claim.ItemComponent> ae_ = a?.Item;
            Money af_ = a?.Total;
            Claim ag_ = new Claim
            {
                Identifier = new List<Identifier>((IEnumerable<Identifier>)f_),
                StatusElement = g_,
                Type = h_,
                SubType = i_,
                UseElement = j_,
                Patient = k_,
                BillablePeriod = l_,
                CreatedElement = m_,
                Enterer = n_,
                Insurer = o_,
                Provider = p_,
                Priority = q_,
                FundsReserve = r_,
                Related = new List<Claim.RelatedClaimComponent>((IEnumerable<Claim.RelatedClaimComponent>)s_),
                Prescription = t_,
                OriginalPrescription = u_,
                Payee = v_,
                Referral = w_,
                Facility = x_,
                CareTeam = new List<Claim.CareTeamComponent>((IEnumerable<Claim.CareTeamComponent>)y_),
                SupportingInfo = new List<Claim.SupportingInformationComponent>((IEnumerable<Claim.SupportingInformationComponent>)z_),
                Diagnosis = new List<Claim.DiagnosisComponent>((IEnumerable<Claim.DiagnosisComponent>)aa_),
                Procedure = new List<Claim.ProcedureComponent>((IEnumerable<Claim.ProcedureComponent>)ab_),
                Insurance = new List<Claim.InsuranceComponent>((IEnumerable<Claim.InsuranceComponent>)ac_),
                Accident = ad_,
                Item = new List<Claim.ItemComponent>((IEnumerable<Claim.ItemComponent>)ae_),
                Total = af_,
            };
            return ag_;
        }

        IEnumerable<Claim> c_ = context.Operators.Select<Claim, Claim>((IEnumerable<Claim>)a_, b_);
        IEnumerable<Claim> d_ = context.Operators.Distinct<Claim>(c_);
        Claim e_ = context.Operators.SingletonFrom<Claim>(d_);
        return e_;
    }


    [CqlFunctionDefinition("ClaimResponseResource")]
    public ClaimResponse ClaimResponseResource(CqlContext context, ClaimResponse arg)
    {
        ClaimResponse[] a_ = [
            arg,
        ];

        ClaimResponse b_(ClaimResponse a) {
            List<Identifier> f_ = a?.Identifier;
            Code<FinancialResourceStatusCodes> g_ = a?.StatusElement;
            CodeableConcept h_ = a?.Type;
            CodeableConcept i_ = a?.SubType;
            Code<ClaimUseCode> j_ = a?.UseElement;
            ResourceReference k_ = a?.Patient;
            FhirDateTime l_ = a?.CreatedElement;
            ResourceReference m_ = a?.Insurer;
            ResourceReference n_ = a?.Requestor;
            ResourceReference o_ = a?.Request;
            Code<ClaimProcessingCodes> p_ = a?.OutcomeElement;
            FhirString q_ = a?.DispositionElement;
            FhirString r_ = a?.PreAuthRefElement;
            Period s_ = a?.PreAuthPeriod;
            CodeableConcept t_ = a?.PayeeType;
            List<ClaimResponse.ItemComponent> u_ = a?.Item;
            List<ClaimResponse.AddedItemComponent> v_ = a?.AddItem;
            List<ClaimResponse.AdjudicationComponent> w_ = a?.Adjudication;
            List<ClaimResponse.TotalComponent> x_ = a?.Total;
            ClaimResponse.PaymentComponent y_ = a?.Payment;
            CodeableConcept z_ = a?.FundsReserve;
            CodeableConcept aa_ = a?.FormCode;
            Attachment ab_ = a?.Form;
            List<ClaimResponse.NoteComponent> ac_ = a?.ProcessNote;
            List<ResourceReference> ad_ = a?.CommunicationRequest;
            List<ClaimResponse.InsuranceComponent> ae_ = a?.Insurance;
            List<ClaimResponse.ErrorComponent> af_ = a?.Error;
            ClaimResponse ag_ = new ClaimResponse
            {
                Identifier = new List<Identifier>((IEnumerable<Identifier>)f_),
                StatusElement = g_,
                Type = h_,
                SubType = i_,
                UseElement = j_,
                Patient = k_,
                CreatedElement = l_,
                Insurer = m_,
                Requestor = n_,
                Request = o_,
                OutcomeElement = p_,
                DispositionElement = q_,
                PreAuthRefElement = r_,
                PreAuthPeriod = s_,
                PayeeType = t_,
                Item = new List<ClaimResponse.ItemComponent>((IEnumerable<ClaimResponse.ItemComponent>)u_),
                AddItem = new List<ClaimResponse.AddedItemComponent>((IEnumerable<ClaimResponse.AddedItemComponent>)v_),
                Adjudication = new List<ClaimResponse.AdjudicationComponent>((IEnumerable<ClaimResponse.AdjudicationComponent>)w_),
                Total = new List<ClaimResponse.TotalComponent>((IEnumerable<ClaimResponse.TotalComponent>)x_),
                Payment = y_,
                FundsReserve = z_,
                FormCode = aa_,
                Form = ab_,
                ProcessNote = new List<ClaimResponse.NoteComponent>((IEnumerable<ClaimResponse.NoteComponent>)ac_),
                CommunicationRequest = new List<ResourceReference>((IEnumerable<ResourceReference>)ad_),
                Insurance = new List<ClaimResponse.InsuranceComponent>((IEnumerable<ClaimResponse.InsuranceComponent>)ae_),
                Error = new List<ClaimResponse.ErrorComponent>((IEnumerable<ClaimResponse.ErrorComponent>)af_),
            };
            return ag_;
        }

        IEnumerable<ClaimResponse> c_ = context.Operators.Select<ClaimResponse, ClaimResponse>((IEnumerable<ClaimResponse>)a_, b_);
        IEnumerable<ClaimResponse> d_ = context.Operators.Distinct<ClaimResponse>(c_);
        ClaimResponse e_ = context.Operators.SingletonFrom<ClaimResponse>(d_);
        return e_;
    }


    [CqlFunctionDefinition("ClinicalImpressionResource")]
    public ClinicalImpression ClinicalImpressionResource(CqlContext context, ClinicalImpression arg)
    {
        ClinicalImpression[] a_ = [
            arg,
        ];

        ClinicalImpression b_(ClinicalImpression a) {
            List<Identifier> f_ = a?.Identifier;
            Code<ClinicalImpression.ClinicalImpressionStatus> g_ = a?.StatusElement;
            CodeableConcept h_ = a?.StatusReason;
            CodeableConcept i_ = a?.Code;
            FhirString j_ = a?.DescriptionElement;
            ResourceReference k_ = a?.Subject;
            ResourceReference l_ = a?.Encounter;
            DataType m_ = a?.Effective;
            FhirDateTime n_ = a?.DateElement;
            ResourceReference o_ = a?.Assessor;
            ResourceReference p_ = a?.Previous;
            List<ResourceReference> q_ = a?.Problem;
            List<ClinicalImpression.InvestigationComponent> r_ = a?.Investigation;
            List<FhirUri> s_ = a?.ProtocolElement;
            FhirString t_ = a?.SummaryElement;
            List<ClinicalImpression.FindingComponent> u_ = a?.Finding;
            List<CodeableConcept> v_ = a?.PrognosisCodeableConcept;
            List<ResourceReference> w_ = a?.PrognosisReference;
            List<ResourceReference> x_ = a?.SupportingInfo;
            List<Annotation> y_ = a?.Note;
            ClinicalImpression z_ = new ClinicalImpression
            {
                Identifier = new List<Identifier>((IEnumerable<Identifier>)f_),
                StatusElement = g_,
                StatusReason = h_,
                Code = i_,
                DescriptionElement = j_,
                Subject = k_,
                Encounter = l_,
                Effective = (DataType)m_,
                DateElement = n_,
                Assessor = o_,
                Previous = p_,
                Problem = new List<ResourceReference>((IEnumerable<ResourceReference>)q_),
                Investigation = new List<ClinicalImpression.InvestigationComponent>((IEnumerable<ClinicalImpression.InvestigationComponent>)r_),
                ProtocolElement = new List<FhirUri>((IEnumerable<FhirUri>)s_),
                SummaryElement = t_,
                Finding = new List<ClinicalImpression.FindingComponent>((IEnumerable<ClinicalImpression.FindingComponent>)u_),
                PrognosisCodeableConcept = new List<CodeableConcept>((IEnumerable<CodeableConcept>)v_),
                PrognosisReference = new List<ResourceReference>((IEnumerable<ResourceReference>)w_),
                SupportingInfo = new List<ResourceReference>((IEnumerable<ResourceReference>)x_),
                Note = new List<Annotation>((IEnumerable<Annotation>)y_),
            };
            return z_;
        }

        IEnumerable<ClinicalImpression> c_ = context.Operators.Select<ClinicalImpression, ClinicalImpression>((IEnumerable<ClinicalImpression>)a_, b_);
        IEnumerable<ClinicalImpression> d_ = context.Operators.Distinct<ClinicalImpression>(c_);
        ClinicalImpression e_ = context.Operators.SingletonFrom<ClinicalImpression>(d_);
        return e_;
    }


    [CqlFunctionDefinition("CodeSystemResource")]
    public CodeSystem CodeSystemResource(CqlContext context, CodeSystem arg)
    {
        CodeSystem[] a_ = [
            arg,
        ];

        CodeSystem b_(CodeSystem a) {
            FhirUri f_ = a?.UrlElement;
            List<Identifier> g_ = a?.Identifier;
            FhirString h_ = a?.VersionElement;
            FhirString i_ = a?.NameElement;
            FhirString j_ = a?.TitleElement;
            Code<PublicationStatus> k_ = a?.StatusElement;
            FhirBoolean l_ = a?.ExperimentalElement;
            FhirDateTime m_ = a?.DateElement;
            FhirString n_ = a?.PublisherElement;
            List<ContactDetail> o_ = a?.Contact;
            Markdown p_ = a?.DescriptionElement;
            List<UsageContext> q_ = a?.UseContext;
            List<CodeableConcept> r_ = a?.Jurisdiction;
            Markdown s_ = a?.PurposeElement;
            Markdown t_ = a?.CopyrightElement;
            FhirBoolean u_ = a?.CaseSensitiveElement;
            Canonical v_ = a?.ValueSetElement;
            Code<CodeSystem.CodeSystemHierarchyMeaning> w_ = a?.HierarchyMeaningElement;
            FhirBoolean x_ = a?.CompositionalElement;
            FhirBoolean y_ = a?.VersionNeededElement;
            Code<CodeSystemContentMode> z_ = a?.ContentElement;
            Canonical aa_ = a?.SupplementsElement;
            UnsignedInt ab_ = a?.CountElement;
            Integer ac_ = context.Operators.Convert<Integer>(ab_);
            UnsignedInt ad_ = context.Operators.Convert<UnsignedInt>(ac_);
            List<CodeSystem.FilterComponent> ae_ = a?.Filter;
            List<CodeSystem.PropertyComponent> af_ = a?.Property;
            List<CodeSystem.ConceptDefinitionComponent> ag_ = a?.Concept;
            CodeSystem ah_ = new CodeSystem
            {
                UrlElement = f_,
                Identifier = new List<Identifier>((IEnumerable<Identifier>)g_),
                VersionElement = h_,
                NameElement = i_,
                TitleElement = j_,
                StatusElement = k_,
                ExperimentalElement = l_,
                DateElement = m_,
                PublisherElement = n_,
                Contact = new List<ContactDetail>((IEnumerable<ContactDetail>)o_),
                DescriptionElement = p_,
                UseContext = new List<UsageContext>((IEnumerable<UsageContext>)q_),
                Jurisdiction = new List<CodeableConcept>((IEnumerable<CodeableConcept>)r_),
                PurposeElement = s_,
                CopyrightElement = t_,
                CaseSensitiveElement = u_,
                ValueSetElement = v_,
                HierarchyMeaningElement = w_,
                CompositionalElement = x_,
                VersionNeededElement = y_,
                ContentElement = z_,
                SupplementsElement = aa_,
                CountElement = ad_,
                Filter = new List<CodeSystem.FilterComponent>((IEnumerable<CodeSystem.FilterComponent>)ae_),
                Property = new List<CodeSystem.PropertyComponent>((IEnumerable<CodeSystem.PropertyComponent>)af_),
                Concept = new List<CodeSystem.ConceptDefinitionComponent>((IEnumerable<CodeSystem.ConceptDefinitionComponent>)ag_),
            };
            return ah_;
        }

        IEnumerable<CodeSystem> c_ = context.Operators.Select<CodeSystem, CodeSystem>((IEnumerable<CodeSystem>)a_, b_);
        IEnumerable<CodeSystem> d_ = context.Operators.Distinct<CodeSystem>(c_);
        CodeSystem e_ = context.Operators.SingletonFrom<CodeSystem>(d_);
        return e_;
    }


    [CqlFunctionDefinition("CommunicationResource")]
    public Communication CommunicationResource(CqlContext context, Communication arg)
    {
        Communication[] a_ = [
            arg,
        ];

        Communication b_(Communication a) {
            List<Identifier> f_ = a?.Identifier;
            List<Canonical> g_ = a?.InstantiatesCanonicalElement;
            List<FhirUri> h_ = a?.InstantiatesUriElement;
            List<ResourceReference> i_ = a?.BasedOn;
            List<ResourceReference> j_ = a?.PartOf;
            List<ResourceReference> k_ = a?.InResponseTo;
            Code<EventStatus> l_ = a?.StatusElement;
            CodeableConcept m_ = a?.StatusReason;
            List<CodeableConcept> n_ = a?.Category;
            Code<RequestPriority> o_ = a?.PriorityElement;
            List<CodeableConcept> p_ = a?.Medium;
            ResourceReference q_ = a?.Subject;
            CodeableConcept r_ = a?.Topic;
            List<ResourceReference> s_ = a?.About;
            ResourceReference t_ = a?.Encounter;
            FhirDateTime u_ = a?.SentElement;
            FhirDateTime v_ = a?.ReceivedElement;
            List<ResourceReference> w_ = a?.Recipient;
            ResourceReference x_ = a?.Sender;
            List<CodeableConcept> y_ = a?.ReasonCode;
            List<ResourceReference> z_ = a?.ReasonReference;
            List<Communication.PayloadComponent> aa_ = a?.Payload;
            List<Annotation> ab_ = a?.Note;
            Communication ac_ = new Communication
            {
                Identifier = new List<Identifier>((IEnumerable<Identifier>)f_),
                InstantiatesCanonicalElement = new List<Canonical>((IEnumerable<Canonical>)g_),
                InstantiatesUriElement = new List<FhirUri>((IEnumerable<FhirUri>)h_),
                BasedOn = new List<ResourceReference>((IEnumerable<ResourceReference>)i_),
                PartOf = new List<ResourceReference>((IEnumerable<ResourceReference>)j_),
                InResponseTo = new List<ResourceReference>((IEnumerable<ResourceReference>)k_),
                StatusElement = l_,
                StatusReason = m_,
                Category = new List<CodeableConcept>((IEnumerable<CodeableConcept>)n_),
                PriorityElement = o_,
                Medium = new List<CodeableConcept>((IEnumerable<CodeableConcept>)p_),
                Subject = q_,
                Topic = r_,
                About = new List<ResourceReference>((IEnumerable<ResourceReference>)s_),
                Encounter = t_,
                SentElement = u_,
                ReceivedElement = v_,
                Recipient = new List<ResourceReference>((IEnumerable<ResourceReference>)w_),
                Sender = x_,
                ReasonCode = new List<CodeableConcept>((IEnumerable<CodeableConcept>)y_),
                ReasonReference = new List<ResourceReference>((IEnumerable<ResourceReference>)z_),
                Payload = new List<Communication.PayloadComponent>((IEnumerable<Communication.PayloadComponent>)aa_),
                Note = new List<Annotation>((IEnumerable<Annotation>)ab_),
            };
            return ac_;
        }

        IEnumerable<Communication> c_ = context.Operators.Select<Communication, Communication>((IEnumerable<Communication>)a_, b_);
        IEnumerable<Communication> d_ = context.Operators.Distinct<Communication>(c_);
        Communication e_ = context.Operators.SingletonFrom<Communication>(d_);
        return e_;
    }


    [CqlFunctionDefinition("CommunicationRequestResource")]
    public CommunicationRequest CommunicationRequestResource(CqlContext context, CommunicationRequest arg)
    {
        CommunicationRequest[] a_ = [
            arg,
        ];

        CommunicationRequest b_(CommunicationRequest a) {
            List<Identifier> f_ = a?.Identifier;
            List<ResourceReference> g_ = a?.BasedOn;
            List<ResourceReference> h_ = a?.Replaces;
            Identifier i_ = a?.GroupIdentifier;
            Code<RequestStatus> j_ = a?.StatusElement;
            CodeableConcept k_ = a?.StatusReason;
            List<CodeableConcept> l_ = a?.Category;
            Code<RequestPriority> m_ = a?.PriorityElement;
            FhirBoolean n_ = a?.DoNotPerformElement;
            List<CodeableConcept> o_ = a?.Medium;
            ResourceReference p_ = a?.Subject;
            List<ResourceReference> q_ = a?.About;
            ResourceReference r_ = a?.Encounter;
            List<CommunicationRequest.PayloadComponent> s_ = a?.Payload;
            DataType t_ = a?.Occurrence;
            FhirDateTime u_ = a?.AuthoredOnElement;
            ResourceReference v_ = a?.Requester;
            List<ResourceReference> w_ = a?.Recipient;
            ResourceReference x_ = a?.Sender;
            List<CodeableConcept> y_ = a?.ReasonCode;
            List<ResourceReference> z_ = a?.ReasonReference;
            List<Annotation> aa_ = a?.Note;
            CommunicationRequest ab_ = new CommunicationRequest
            {
                Identifier = new List<Identifier>((IEnumerable<Identifier>)f_),
                BasedOn = new List<ResourceReference>((IEnumerable<ResourceReference>)g_),
                Replaces = new List<ResourceReference>((IEnumerable<ResourceReference>)h_),
                GroupIdentifier = i_,
                StatusElement = j_,
                StatusReason = k_,
                Category = new List<CodeableConcept>((IEnumerable<CodeableConcept>)l_),
                PriorityElement = m_,
                DoNotPerformElement = n_,
                Medium = new List<CodeableConcept>((IEnumerable<CodeableConcept>)o_),
                Subject = p_,
                About = new List<ResourceReference>((IEnumerable<ResourceReference>)q_),
                Encounter = r_,
                Payload = new List<CommunicationRequest.PayloadComponent>((IEnumerable<CommunicationRequest.PayloadComponent>)s_),
                Occurrence = (DataType)t_,
                AuthoredOnElement = u_,
                Requester = v_,
                Recipient = new List<ResourceReference>((IEnumerable<ResourceReference>)w_),
                Sender = x_,
                ReasonCode = new List<CodeableConcept>((IEnumerable<CodeableConcept>)y_),
                ReasonReference = new List<ResourceReference>((IEnumerable<ResourceReference>)z_),
                Note = new List<Annotation>((IEnumerable<Annotation>)aa_),
            };
            return ab_;
        }

        IEnumerable<CommunicationRequest> c_ = context.Operators.Select<CommunicationRequest, CommunicationRequest>((IEnumerable<CommunicationRequest>)a_, b_);
        IEnumerable<CommunicationRequest> d_ = context.Operators.Distinct<CommunicationRequest>(c_);
        CommunicationRequest e_ = context.Operators.SingletonFrom<CommunicationRequest>(d_);
        return e_;
    }


    [CqlFunctionDefinition("CompositionResource")]
    public Composition CompositionResource(CqlContext context, Composition arg)
    {
        Composition[] a_ = [
            arg,
        ];

        Composition b_(Composition a) {
            Identifier f_ = a?.Identifier;
            Code<CompositionStatus> g_ = a?.StatusElement;
            CodeableConcept h_ = a?.Type;
            List<CodeableConcept> i_ = a?.Category;
            ResourceReference j_ = a?.Subject;
            ResourceReference k_ = a?.Encounter;
            FhirDateTime l_ = a?.DateElement;
            List<ResourceReference> m_ = a?.Author;
            FhirString n_ = a?.TitleElement;
            Code<Composition.V3ConfidentialityClassification> o_ = a?.ConfidentialityElement;
            List<Composition.AttesterComponent> p_ = a?.Attester;
            ResourceReference q_ = a?.Custodian;
            List<Composition.RelatesToComponent> r_ = a?.RelatesTo;
            List<Composition.EventComponent> s_ = a?.Event;
            List<Composition.SectionComponent> t_ = a?.Section;
            Composition u_ = new Composition
            {
                Identifier = f_,
                StatusElement = g_,
                Type = h_,
                Category = new List<CodeableConcept>((IEnumerable<CodeableConcept>)i_),
                Subject = j_,
                Encounter = k_,
                DateElement = l_,
                Author = new List<ResourceReference>((IEnumerable<ResourceReference>)m_),
                TitleElement = n_,
                ConfidentialityElement = o_,
                Attester = new List<Composition.AttesterComponent>((IEnumerable<Composition.AttesterComponent>)p_),
                Custodian = q_,
                RelatesTo = new List<Composition.RelatesToComponent>((IEnumerable<Composition.RelatesToComponent>)r_),
                Event = new List<Composition.EventComponent>((IEnumerable<Composition.EventComponent>)s_),
                Section = new List<Composition.SectionComponent>((IEnumerable<Composition.SectionComponent>)t_),
            };
            return u_;
        }

        IEnumerable<Composition> c_ = context.Operators.Select<Composition, Composition>((IEnumerable<Composition>)a_, b_);
        IEnumerable<Composition> d_ = context.Operators.Distinct<Composition>(c_);
        Composition e_ = context.Operators.SingletonFrom<Composition>(d_);
        return e_;
    }


    [CqlFunctionDefinition("ConceptMapResource")]
    public ConceptMap ConceptMapResource(CqlContext context, ConceptMap arg)
    {
        ConceptMap[] a_ = [
            arg,
        ];

        ConceptMap b_(ConceptMap a) {
            FhirUri f_ = a?.UrlElement;
            Identifier g_ = a?.Identifier;
            FhirString h_ = a?.VersionElement;
            FhirString i_ = a?.NameElement;
            FhirString j_ = a?.TitleElement;
            Code<PublicationStatus> k_ = a?.StatusElement;
            FhirBoolean l_ = a?.ExperimentalElement;
            FhirDateTime m_ = a?.DateElement;
            FhirString n_ = a?.PublisherElement;
            List<ContactDetail> o_ = a?.Contact;
            Markdown p_ = a?.DescriptionElement;
            List<UsageContext> q_ = a?.UseContext;
            List<CodeableConcept> r_ = a?.Jurisdiction;
            Markdown s_ = a?.PurposeElement;
            Markdown t_ = a?.CopyrightElement;
            DataType u_ = a?.Source;
            DataType v_ = a?.Target;
            List<ConceptMap.GroupComponent> w_ = a?.Group;
            ConceptMap x_ = new ConceptMap
            {
                UrlElement = f_,
                Identifier = g_,
                VersionElement = h_,
                NameElement = i_,
                TitleElement = j_,
                StatusElement = k_,
                ExperimentalElement = l_,
                DateElement = m_,
                PublisherElement = n_,
                Contact = new List<ContactDetail>((IEnumerable<ContactDetail>)o_),
                DescriptionElement = p_,
                UseContext = new List<UsageContext>((IEnumerable<UsageContext>)q_),
                Jurisdiction = new List<CodeableConcept>((IEnumerable<CodeableConcept>)r_),
                PurposeElement = s_,
                CopyrightElement = t_,
                Source = (DataType)u_,
                Target = (DataType)v_,
                Group = new List<ConceptMap.GroupComponent>((IEnumerable<ConceptMap.GroupComponent>)w_),
            };
            return x_;
        }

        IEnumerable<ConceptMap> c_ = context.Operators.Select<ConceptMap, ConceptMap>((IEnumerable<ConceptMap>)a_, b_);
        IEnumerable<ConceptMap> d_ = context.Operators.Distinct<ConceptMap>(c_);
        ConceptMap e_ = context.Operators.SingletonFrom<ConceptMap>(d_);
        return e_;
    }


    [CqlFunctionDefinition("ConditionResource")]
    public Condition ConditionResource(CqlContext context, Condition arg)
    {
        Condition[] a_ = [
            arg,
        ];

        Condition b_(Condition a) {
            List<Identifier> f_ = a?.Identifier;
            CodeableConcept g_ = a?.ClinicalStatus;
            CodeableConcept h_ = a?.VerificationStatus;
            List<CodeableConcept> i_ = a?.Category;
            CodeableConcept j_ = a?.Severity;
            CodeableConcept k_ = a?.Code;
            List<CodeableConcept> l_ = a?.BodySite;
            ResourceReference m_ = a?.Subject;
            ResourceReference n_ = a?.Encounter;
            DataType o_ = a?.Onset;
            DataType p_ = a?.Abatement;
            FhirDateTime q_ = a?.RecordedDateElement;
            ResourceReference r_ = a?.Recorder;
            ResourceReference s_ = a?.Asserter;
            List<Condition.StageComponent> t_ = a?.Stage;
            List<Condition.EvidenceComponent> u_ = a?.Evidence;
            List<Annotation> v_ = a?.Note;
            Condition w_ = new Condition
            {
                Identifier = new List<Identifier>((IEnumerable<Identifier>)f_),
                ClinicalStatus = g_,
                VerificationStatus = h_,
                Category = new List<CodeableConcept>((IEnumerable<CodeableConcept>)i_),
                Severity = j_,
                Code = k_,
                BodySite = new List<CodeableConcept>((IEnumerable<CodeableConcept>)l_),
                Subject = m_,
                Encounter = n_,
                Onset = (DataType)o_,
                Abatement = (DataType)p_,
                RecordedDateElement = q_,
                Recorder = r_,
                Asserter = s_,
                Stage = new List<Condition.StageComponent>((IEnumerable<Condition.StageComponent>)t_),
                Evidence = new List<Condition.EvidenceComponent>((IEnumerable<Condition.EvidenceComponent>)u_),
                Note = new List<Annotation>((IEnumerable<Annotation>)v_),
            };
            return w_;
        }

        IEnumerable<Condition> c_ = context.Operators.Select<Condition, Condition>((IEnumerable<Condition>)a_, b_);
        IEnumerable<Condition> d_ = context.Operators.Distinct<Condition>(c_);
        Condition e_ = context.Operators.SingletonFrom<Condition>(d_);
        return e_;
    }


    [CqlFunctionDefinition("ConsentResource")]
    public Consent ConsentResource(CqlContext context, Consent arg)
    {
        Consent[] a_ = [
            arg,
        ];

        Consent b_(Consent a) {
            List<Identifier> f_ = a?.Identifier;
            Code<Consent.ConsentState> g_ = a?.StatusElement;
            CodeableConcept h_ = a?.Scope;
            List<CodeableConcept> i_ = a?.Category;
            ResourceReference j_ = a?.Patient;
            FhirDateTime k_ = a?.DateTimeElement;
            List<ResourceReference> l_ = a?.Performer;
            List<ResourceReference> m_ = a?.Organization;
            DataType n_ = a?.Source;
            List<Consent.PolicyComponent> o_ = a?.Policy;
            CodeableConcept p_ = a?.PolicyRule;
            List<Consent.VerificationComponent> q_ = a?.Verification;
            Consent.provisionComponent r_ = a?.Provision;
            Consent s_ = new Consent
            {
                Identifier = new List<Identifier>((IEnumerable<Identifier>)f_),
                StatusElement = g_,
                Scope = h_,
                Category = new List<CodeableConcept>((IEnumerable<CodeableConcept>)i_),
                Patient = j_,
                DateTimeElement = k_,
                Performer = new List<ResourceReference>((IEnumerable<ResourceReference>)l_),
                Organization = new List<ResourceReference>((IEnumerable<ResourceReference>)m_),
                Source = (DataType)n_,
                Policy = new List<Consent.PolicyComponent>((IEnumerable<Consent.PolicyComponent>)o_),
                PolicyRule = p_,
                Verification = new List<Consent.VerificationComponent>((IEnumerable<Consent.VerificationComponent>)q_),
                Provision = r_,
            };
            return s_;
        }

        IEnumerable<Consent> c_ = context.Operators.Select<Consent, Consent>((IEnumerable<Consent>)a_, b_);
        IEnumerable<Consent> d_ = context.Operators.Distinct<Consent>(c_);
        Consent e_ = context.Operators.SingletonFrom<Consent>(d_);
        return e_;
    }


    [CqlFunctionDefinition("ContractResource")]
    public Contract ContractResource(CqlContext context, Contract arg)
    {
        Contract[] a_ = [
            arg,
        ];

        Contract b_(Contract a) {
            List<Identifier> f_ = a?.Identifier;
            FhirUri g_ = a?.UrlElement;
            FhirString h_ = a?.VersionElement;
            Code<Contract.ContractResourceStatusCodes> i_ = a?.StatusElement;
            CodeableConcept j_ = a?.LegalState;
            ResourceReference k_ = a?.InstantiatesCanonical;
            FhirUri l_ = a?.InstantiatesUriElement;
            CodeableConcept m_ = a?.ContentDerivative;
            FhirDateTime n_ = a?.IssuedElement;
            Period o_ = a?.Applies;
            CodeableConcept p_ = a?.ExpirationType;
            List<ResourceReference> q_ = a?.Subject;
            List<ResourceReference> r_ = a?.Authority;
            List<ResourceReference> s_ = a?.Domain;
            List<ResourceReference> t_ = a?.Site;
            FhirString u_ = a?.NameElement;
            FhirString v_ = a?.TitleElement;
            FhirString w_ = a?.SubtitleElement;
            List<FhirString> x_ = a?.AliasElement;
            ResourceReference y_ = a?.Author;
            CodeableConcept z_ = a?.Scope;
            DataType aa_ = a?.Topic;
            CodeableConcept ab_ = a?.Type;
            List<CodeableConcept> ac_ = a?.SubType;
            Contract.ContentDefinitionComponent ad_ = a?.ContentDefinition;
            List<Contract.TermComponent> ae_ = a?.Term;
            List<ResourceReference> af_ = a?.SupportingInfo;
            List<ResourceReference> ag_ = a?.RelevantHistory;
            List<Contract.SignatoryComponent> ah_ = a?.Signer;
            List<Contract.FriendlyLanguageComponent> ai_ = a?.Friendly;
            List<Contract.LegalLanguageComponent> aj_ = a?.Legal;
            List<Contract.ComputableLanguageComponent> ak_ = a?.Rule;
            DataType al_ = a?.LegallyBinding;
            Contract am_ = new Contract
            {
                Identifier = new List<Identifier>((IEnumerable<Identifier>)f_),
                UrlElement = g_,
                VersionElement = h_,
                StatusElement = i_,
                LegalState = j_,
                InstantiatesCanonical = k_,
                InstantiatesUriElement = l_,
                ContentDerivative = m_,
                IssuedElement = n_,
                Applies = o_,
                ExpirationType = p_,
                Subject = new List<ResourceReference>((IEnumerable<ResourceReference>)q_),
                Authority = new List<ResourceReference>((IEnumerable<ResourceReference>)r_),
                Domain = new List<ResourceReference>((IEnumerable<ResourceReference>)s_),
                Site = new List<ResourceReference>((IEnumerable<ResourceReference>)t_),
                NameElement = u_,
                TitleElement = v_,
                SubtitleElement = w_,
                AliasElement = new List<FhirString>((IEnumerable<FhirString>)x_),
                Author = y_,
                Scope = z_,
                Topic = (DataType)aa_,
                Type = ab_,
                SubType = new List<CodeableConcept>((IEnumerable<CodeableConcept>)ac_),
                ContentDefinition = ad_,
                Term = new List<Contract.TermComponent>((IEnumerable<Contract.TermComponent>)ae_),
                SupportingInfo = new List<ResourceReference>((IEnumerable<ResourceReference>)af_),
                RelevantHistory = new List<ResourceReference>((IEnumerable<ResourceReference>)ag_),
                Signer = new List<Contract.SignatoryComponent>((IEnumerable<Contract.SignatoryComponent>)ah_),
                Friendly = new List<Contract.FriendlyLanguageComponent>((IEnumerable<Contract.FriendlyLanguageComponent>)ai_),
                Legal = new List<Contract.LegalLanguageComponent>((IEnumerable<Contract.LegalLanguageComponent>)aj_),
                Rule = new List<Contract.ComputableLanguageComponent>((IEnumerable<Contract.ComputableLanguageComponent>)ak_),
                LegallyBinding = (DataType)al_,
            };
            return am_;
        }

        IEnumerable<Contract> c_ = context.Operators.Select<Contract, Contract>((IEnumerable<Contract>)a_, b_);
        IEnumerable<Contract> d_ = context.Operators.Distinct<Contract>(c_);
        Contract e_ = context.Operators.SingletonFrom<Contract>(d_);
        return e_;
    }


    [CqlFunctionDefinition("CoverageResource")]
    public Coverage CoverageResource(CqlContext context, Coverage arg)
    {
        Coverage[] a_ = [
            arg,
        ];

        Coverage b_(Coverage a) {
            List<Identifier> f_ = a?.Identifier;
            Code<FinancialResourceStatusCodes> g_ = a?.StatusElement;
            CodeableConcept h_ = a?.Type;
            ResourceReference i_ = a?.PolicyHolder;
            ResourceReference j_ = a?.Subscriber;
            FhirString k_ = a?.SubscriberIdElement;
            ResourceReference l_ = a?.Beneficiary;
            FhirString m_ = a?.DependentElement;
            CodeableConcept n_ = a?.Relationship;
            Period o_ = a?.Period;
            List<ResourceReference> p_ = a?.Payor;
            List<Coverage.ClassComponent> q_ = a?.Class;
            PositiveInt r_ = a?.OrderElement;
            Integer s_ = context.Operators.Convert<Integer>(r_);
            PositiveInt t_ = context.Operators.Convert<PositiveInt>(s_);
            FhirString u_ = a?.NetworkElement;
            List<Coverage.CostToBeneficiaryComponent> v_ = a?.CostToBeneficiary;
            FhirBoolean w_ = a?.SubrogationElement;
            List<ResourceReference> x_ = a?.Contract;
            Coverage y_ = new Coverage
            {
                Identifier = new List<Identifier>((IEnumerable<Identifier>)f_),
                StatusElement = g_,
                Type = h_,
                PolicyHolder = i_,
                Subscriber = j_,
                SubscriberIdElement = k_,
                Beneficiary = l_,
                DependentElement = m_,
                Relationship = n_,
                Period = o_,
                Payor = new List<ResourceReference>((IEnumerable<ResourceReference>)p_),
                Class = new List<Coverage.ClassComponent>((IEnumerable<Coverage.ClassComponent>)q_),
                OrderElement = t_,
                NetworkElement = u_,
                CostToBeneficiary = new List<Coverage.CostToBeneficiaryComponent>((IEnumerable<Coverage.CostToBeneficiaryComponent>)v_),
                SubrogationElement = w_,
                Contract = new List<ResourceReference>((IEnumerable<ResourceReference>)x_),
            };
            return y_;
        }

        IEnumerable<Coverage> c_ = context.Operators.Select<Coverage, Coverage>((IEnumerable<Coverage>)a_, b_);
        IEnumerable<Coverage> d_ = context.Operators.Distinct<Coverage>(c_);
        Coverage e_ = context.Operators.SingletonFrom<Coverage>(d_);
        return e_;
    }


    [CqlFunctionDefinition("CoverageEligibilityRequestResource")]
    public CoverageEligibilityRequest CoverageEligibilityRequestResource(CqlContext context, CoverageEligibilityRequest arg)
    {
        CoverageEligibilityRequest[] a_ = [
            arg,
        ];

        CoverageEligibilityRequest b_(CoverageEligibilityRequest a) {
            List<Identifier> f_ = a?.Identifier;
            Code<FinancialResourceStatusCodes> g_ = a?.StatusElement;
            CodeableConcept h_ = a?.Priority;
            List<Code<CoverageEligibilityRequest.EligibilityRequestPurpose>> i_ = a?.PurposeElement;
            ResourceReference j_ = a?.Patient;
            DataType k_ = a?.Serviced;
            FhirDateTime l_ = a?.CreatedElement;
            ResourceReference m_ = a?.Enterer;
            ResourceReference n_ = a?.Provider;
            ResourceReference o_ = a?.Insurer;
            ResourceReference p_ = a?.Facility;
            List<CoverageEligibilityRequest.SupportingInformationComponent> q_ = a?.SupportingInfo;
            List<CoverageEligibilityRequest.InsuranceComponent> r_ = a?.Insurance;
            List<CoverageEligibilityRequest.DetailsComponent> s_ = a?.Item;
            CoverageEligibilityRequest t_ = new CoverageEligibilityRequest
            {
                Identifier = new List<Identifier>((IEnumerable<Identifier>)f_),
                StatusElement = g_,
                Priority = h_,
                PurposeElement = new List<Code<CoverageEligibilityRequest.EligibilityRequestPurpose>>((IEnumerable<Code<CoverageEligibilityRequest.EligibilityRequestPurpose>>)i_),
                Patient = j_,
                Serviced = (DataType)k_,
                CreatedElement = l_,
                Enterer = m_,
                Provider = n_,
                Insurer = o_,
                Facility = p_,
                SupportingInfo = new List<CoverageEligibilityRequest.SupportingInformationComponent>((IEnumerable<CoverageEligibilityRequest.SupportingInformationComponent>)q_),
                Insurance = new List<CoverageEligibilityRequest.InsuranceComponent>((IEnumerable<CoverageEligibilityRequest.InsuranceComponent>)r_),
                Item = new List<CoverageEligibilityRequest.DetailsComponent>((IEnumerable<CoverageEligibilityRequest.DetailsComponent>)s_),
            };
            return t_;
        }

        IEnumerable<CoverageEligibilityRequest> c_ = context.Operators.Select<CoverageEligibilityRequest, CoverageEligibilityRequest>((IEnumerable<CoverageEligibilityRequest>)a_, b_);
        IEnumerable<CoverageEligibilityRequest> d_ = context.Operators.Distinct<CoverageEligibilityRequest>(c_);
        CoverageEligibilityRequest e_ = context.Operators.SingletonFrom<CoverageEligibilityRequest>(d_);
        return e_;
    }


    [CqlFunctionDefinition("CoverageEligibilityResponseResource")]
    public CoverageEligibilityResponse CoverageEligibilityResponseResource(CqlContext context, CoverageEligibilityResponse arg)
    {
        CoverageEligibilityResponse[] a_ = [
            arg,
        ];

        CoverageEligibilityResponse b_(CoverageEligibilityResponse a) {
            List<Identifier> f_ = a?.Identifier;
            Code<FinancialResourceStatusCodes> g_ = a?.StatusElement;
            List<Code<CoverageEligibilityResponse.EligibilityResponsePurpose>> h_ = a?.PurposeElement;
            ResourceReference i_ = a?.Patient;
            DataType j_ = a?.Serviced;
            FhirDateTime k_ = a?.CreatedElement;
            ResourceReference l_ = a?.Requestor;
            ResourceReference m_ = a?.Request;
            Code<ClaimProcessingCodes> n_ = a?.OutcomeElement;
            FhirString o_ = a?.DispositionElement;
            ResourceReference p_ = a?.Insurer;
            List<CoverageEligibilityResponse.InsuranceComponent> q_ = a?.Insurance;
            FhirString r_ = a?.PreAuthRefElement;
            CodeableConcept s_ = a?.Form;
            List<CoverageEligibilityResponse.ErrorsComponent> t_ = a?.Error;
            CoverageEligibilityResponse u_ = new CoverageEligibilityResponse
            {
                Identifier = new List<Identifier>((IEnumerable<Identifier>)f_),
                StatusElement = g_,
                PurposeElement = new List<Code<CoverageEligibilityResponse.EligibilityResponsePurpose>>((IEnumerable<Code<CoverageEligibilityResponse.EligibilityResponsePurpose>>)h_),
                Patient = i_,
                Serviced = (DataType)j_,
                CreatedElement = k_,
                Requestor = l_,
                Request = m_,
                OutcomeElement = n_,
                DispositionElement = o_,
                Insurer = p_,
                Insurance = new List<CoverageEligibilityResponse.InsuranceComponent>((IEnumerable<CoverageEligibilityResponse.InsuranceComponent>)q_),
                PreAuthRefElement = r_,
                Form = s_,
                Error = new List<CoverageEligibilityResponse.ErrorsComponent>((IEnumerable<CoverageEligibilityResponse.ErrorsComponent>)t_),
            };
            return u_;
        }

        IEnumerable<CoverageEligibilityResponse> c_ = context.Operators.Select<CoverageEligibilityResponse, CoverageEligibilityResponse>((IEnumerable<CoverageEligibilityResponse>)a_, b_);
        IEnumerable<CoverageEligibilityResponse> d_ = context.Operators.Distinct<CoverageEligibilityResponse>(c_);
        CoverageEligibilityResponse e_ = context.Operators.SingletonFrom<CoverageEligibilityResponse>(d_);
        return e_;
    }


    [CqlFunctionDefinition("DetectedIssueResource")]
    public DetectedIssue DetectedIssueResource(CqlContext context, DetectedIssue arg)
    {
        DetectedIssue[] a_ = [
            arg,
        ];

        DetectedIssue b_(DetectedIssue a) {
            List<Identifier> f_ = a?.Identifier;
            Code<ObservationStatus> g_ = a?.StatusElement;
            CodeableConcept h_ = a?.Code;
            Code<DetectedIssue.DetectedIssueSeverity> i_ = a?.SeverityElement;
            ResourceReference j_ = a?.Patient;
            DataType k_ = a?.Identified;
            ResourceReference l_ = a?.Author;
            List<ResourceReference> m_ = a?.Implicated;
            List<DetectedIssue.EvidenceComponent> n_ = a?.Evidence;
            FhirString o_ = a?.DetailElement;
            FhirUri p_ = a?.ReferenceElement;
            List<DetectedIssue.MitigationComponent> q_ = a?.Mitigation;
            DetectedIssue r_ = new DetectedIssue
            {
                Identifier = new List<Identifier>((IEnumerable<Identifier>)f_),
                StatusElement = g_,
                Code = h_,
                SeverityElement = i_,
                Patient = j_,
                Identified = (DataType)k_,
                Author = l_,
                Implicated = new List<ResourceReference>((IEnumerable<ResourceReference>)m_),
                Evidence = new List<DetectedIssue.EvidenceComponent>((IEnumerable<DetectedIssue.EvidenceComponent>)n_),
                DetailElement = o_,
                ReferenceElement = p_,
                Mitigation = new List<DetectedIssue.MitigationComponent>((IEnumerable<DetectedIssue.MitigationComponent>)q_),
            };
            return r_;
        }

        IEnumerable<DetectedIssue> c_ = context.Operators.Select<DetectedIssue, DetectedIssue>((IEnumerable<DetectedIssue>)a_, b_);
        IEnumerable<DetectedIssue> d_ = context.Operators.Distinct<DetectedIssue>(c_);
        DetectedIssue e_ = context.Operators.SingletonFrom<DetectedIssue>(d_);
        return e_;
    }


    [CqlFunctionDefinition("DeviceResource")]
    public Device DeviceResource(CqlContext context, Device arg)
    {
        Device[] a_ = [
            arg,
        ];

        Device b_(Device a) {
            List<Identifier> f_ = a?.Identifier;
            ResourceReference g_ = a?.Definition;
            List<Device.UdiCarrierComponent> h_ = a?.UdiCarrier;
            Code<Device.FHIRDeviceStatus> i_ = a?.StatusElement;
            List<CodeableConcept> j_ = a?.StatusReason;
            FhirString k_ = a?.DistinctIdentifierElement;
            FhirString l_ = a?.ManufacturerElement;
            FhirDateTime m_ = a?.ManufactureDateElement;
            FhirDateTime n_ = a?.ExpirationDateElement;
            FhirString o_ = a?.LotNumberElement;
            FhirString p_ = a?.SerialNumberElement;
            List<Device.DeviceNameComponent> q_ = a?.DeviceName;
            FhirString r_ = a?.ModelNumberElement;
            FhirString s_ = a?.PartNumberElement;
            CodeableConcept t_ = a?.Type;
            List<Device.SpecializationComponent> u_ = a?.Specialization;
            List<Device.VersionComponent> v_ = a?.Version;
            List<Device.PropertyComponent> w_ = a?.Property;
            ResourceReference x_ = a?.Patient;
            ResourceReference y_ = a?.Owner;
            List<ContactPoint> z_ = a?.Contact;
            ResourceReference aa_ = a?.Location;
            FhirUri ab_ = a?.UrlElement;
            List<Annotation> ac_ = a?.Note;
            List<CodeableConcept> ad_ = a?.Safety;
            ResourceReference ae_ = a?.Parent;
            Device af_ = new Device
            {
                Identifier = new List<Identifier>((IEnumerable<Identifier>)f_),
                Definition = g_,
                UdiCarrier = new List<Device.UdiCarrierComponent>((IEnumerable<Device.UdiCarrierComponent>)h_),
                StatusElement = i_,
                StatusReason = new List<CodeableConcept>((IEnumerable<CodeableConcept>)j_),
                DistinctIdentifierElement = k_,
                ManufacturerElement = l_,
                ManufactureDateElement = m_,
                ExpirationDateElement = n_,
                LotNumberElement = o_,
                SerialNumberElement = p_,
                DeviceName = new List<Device.DeviceNameComponent>((IEnumerable<Device.DeviceNameComponent>)q_),
                ModelNumberElement = r_,
                PartNumberElement = s_,
                Type = t_,
                Specialization = new List<Device.SpecializationComponent>((IEnumerable<Device.SpecializationComponent>)u_),
                Version = new List<Device.VersionComponent>((IEnumerable<Device.VersionComponent>)v_),
                Property = new List<Device.PropertyComponent>((IEnumerable<Device.PropertyComponent>)w_),
                Patient = x_,
                Owner = y_,
                Contact = new List<ContactPoint>((IEnumerable<ContactPoint>)z_),
                Location = aa_,
                UrlElement = ab_,
                Note = new List<Annotation>((IEnumerable<Annotation>)ac_),
                Safety = new List<CodeableConcept>((IEnumerable<CodeableConcept>)ad_),
                Parent = ae_,
            };
            return af_;
        }

        IEnumerable<Device> c_ = context.Operators.Select<Device, Device>((IEnumerable<Device>)a_, b_);
        IEnumerable<Device> d_ = context.Operators.Distinct<Device>(c_);
        Device e_ = context.Operators.SingletonFrom<Device>(d_);
        return e_;
    }


    [CqlFunctionDefinition("DeviceDefinitionResource")]
    public DeviceDefinition DeviceDefinitionResource(CqlContext context, DeviceDefinition arg)
    {
        DeviceDefinition[] a_ = [
            arg,
        ];

        DeviceDefinition b_(DeviceDefinition a) {
            List<Identifier> f_ = a?.Identifier;
            List<DeviceDefinition.UdiDeviceIdentifierComponent> g_ = a?.UdiDeviceIdentifier;
            DataType h_ = a?.Manufacturer;
            List<DeviceDefinition.DeviceNameComponent> i_ = a?.DeviceName;
            FhirString j_ = a?.ModelNumberElement;
            CodeableConcept k_ = a?.Type;
            List<DeviceDefinition.SpecializationComponent> l_ = a?.Specialization;
            List<FhirString> m_ = a?.VersionElement;
            List<CodeableConcept> n_ = a?.Safety;
            List<ProductShelfLife> o_ = a?.ShelfLifeStorage;
            ProdCharacteristic p_ = a?.PhysicalCharacteristics;
            List<CodeableConcept> q_ = a?.LanguageCode;
            List<DeviceDefinition.CapabilityComponent> r_ = a?.Capability;
            List<DeviceDefinition.PropertyComponent> s_ = a?.Property;
            ResourceReference t_ = a?.Owner;
            List<ContactPoint> u_ = a?.Contact;
            FhirUri v_ = a?.UrlElement;
            FhirUri w_ = a?.OnlineInformationElement;
            List<Annotation> x_ = a?.Note;
            Quantity y_ = a?.Quantity;
            ResourceReference z_ = a?.ParentDevice;
            List<DeviceDefinition.MaterialComponent> aa_ = a?.Material;
            DeviceDefinition ab_ = new DeviceDefinition
            {
                Identifier = new List<Identifier>((IEnumerable<Identifier>)f_),
                UdiDeviceIdentifier = new List<DeviceDefinition.UdiDeviceIdentifierComponent>((IEnumerable<DeviceDefinition.UdiDeviceIdentifierComponent>)g_),
                Manufacturer = (DataType)h_,
                DeviceName = new List<DeviceDefinition.DeviceNameComponent>((IEnumerable<DeviceDefinition.DeviceNameComponent>)i_),
                ModelNumberElement = j_,
                Type = k_,
                Specialization = new List<DeviceDefinition.SpecializationComponent>((IEnumerable<DeviceDefinition.SpecializationComponent>)l_),
                VersionElement = new List<FhirString>((IEnumerable<FhirString>)m_),
                Safety = new List<CodeableConcept>((IEnumerable<CodeableConcept>)n_),
                ShelfLifeStorage = new List<ProductShelfLife>((IEnumerable<ProductShelfLife>)o_),
                PhysicalCharacteristics = p_,
                LanguageCode = new List<CodeableConcept>((IEnumerable<CodeableConcept>)q_),
                Capability = new List<DeviceDefinition.CapabilityComponent>((IEnumerable<DeviceDefinition.CapabilityComponent>)r_),
                Property = new List<DeviceDefinition.PropertyComponent>((IEnumerable<DeviceDefinition.PropertyComponent>)s_),
                Owner = t_,
                Contact = new List<ContactPoint>((IEnumerable<ContactPoint>)u_),
                UrlElement = v_,
                OnlineInformationElement = w_,
                Note = new List<Annotation>((IEnumerable<Annotation>)x_),
                Quantity = y_,
                ParentDevice = z_,
                Material = new List<DeviceDefinition.MaterialComponent>((IEnumerable<DeviceDefinition.MaterialComponent>)aa_),
            };
            return ab_;
        }

        IEnumerable<DeviceDefinition> c_ = context.Operators.Select<DeviceDefinition, DeviceDefinition>((IEnumerable<DeviceDefinition>)a_, b_);
        IEnumerable<DeviceDefinition> d_ = context.Operators.Distinct<DeviceDefinition>(c_);
        DeviceDefinition e_ = context.Operators.SingletonFrom<DeviceDefinition>(d_);
        return e_;
    }


    [CqlFunctionDefinition("DeviceMetricResource")]
    public DeviceMetric DeviceMetricResource(CqlContext context, DeviceMetric arg)
    {
        DeviceMetric[] a_ = [
            arg,
        ];

        DeviceMetric b_(DeviceMetric a) {
            List<Identifier> f_ = a?.Identifier;
            CodeableConcept g_ = a?.Type;
            CodeableConcept h_ = a?.Unit;
            ResourceReference i_ = a?.Source;
            ResourceReference j_ = a?.Parent;
            Code<DeviceMetric.DeviceMetricOperationalStatus> k_ = a?.OperationalStatusElement;
            Code<DeviceMetric.DeviceMetricColor> l_ = a?.ColorElement;
            Code<DeviceMetric.DeviceMetricCategory> m_ = a?.CategoryElement;
            Timing n_ = a?.MeasurementPeriod;
            List<DeviceMetric.CalibrationComponent> o_ = a?.Calibration;
            DeviceMetric p_ = new DeviceMetric
            {
                Identifier = new List<Identifier>((IEnumerable<Identifier>)f_),
                Type = g_,
                Unit = h_,
                Source = i_,
                Parent = j_,
                OperationalStatusElement = k_,
                ColorElement = l_,
                CategoryElement = m_,
                MeasurementPeriod = n_,
                Calibration = new List<DeviceMetric.CalibrationComponent>((IEnumerable<DeviceMetric.CalibrationComponent>)o_),
            };
            return p_;
        }

        IEnumerable<DeviceMetric> c_ = context.Operators.Select<DeviceMetric, DeviceMetric>((IEnumerable<DeviceMetric>)a_, b_);
        IEnumerable<DeviceMetric> d_ = context.Operators.Distinct<DeviceMetric>(c_);
        DeviceMetric e_ = context.Operators.SingletonFrom<DeviceMetric>(d_);
        return e_;
    }


    [CqlFunctionDefinition("DeviceRequestResource")]
    public DeviceRequest DeviceRequestResource(CqlContext context, DeviceRequest arg)
    {
        DeviceRequest[] a_ = [
            arg,
        ];

        DeviceRequest b_(DeviceRequest a) {
            List<Identifier> f_ = a?.Identifier;
            List<Canonical> g_ = a?.InstantiatesCanonicalElement;
            List<FhirUri> h_ = a?.InstantiatesUriElement;
            List<ResourceReference> i_ = a?.BasedOn;
            List<ResourceReference> j_ = a?.PriorRequest;
            Identifier k_ = a?.GroupIdentifier;
            Code<RequestStatus> l_ = a?.StatusElement;
            Code<RequestIntent> m_ = a?.IntentElement;
            Code<RequestPriority> n_ = a?.PriorityElement;
            DataType o_ = a?.Code;
            List<DeviceRequest.ParameterComponent> p_ = a?.Parameter;
            ResourceReference q_ = a?.Subject;
            ResourceReference r_ = a?.Encounter;
            DataType s_ = a?.Occurrence;
            FhirDateTime t_ = a?.AuthoredOnElement;
            ResourceReference u_ = a?.Requester;
            CodeableConcept v_ = a?.PerformerType;
            ResourceReference w_ = a?.Performer;
            List<CodeableConcept> x_ = a?.ReasonCode;
            List<ResourceReference> y_ = a?.ReasonReference;
            List<ResourceReference> z_ = a?.Insurance;
            List<ResourceReference> aa_ = a?.SupportingInfo;
            List<Annotation> ab_ = a?.Note;
            List<ResourceReference> ac_ = a?.RelevantHistory;
            DeviceRequest ad_ = new DeviceRequest
            {
                Identifier = new List<Identifier>((IEnumerable<Identifier>)f_),
                InstantiatesCanonicalElement = new List<Canonical>((IEnumerable<Canonical>)g_),
                InstantiatesUriElement = new List<FhirUri>((IEnumerable<FhirUri>)h_),
                BasedOn = new List<ResourceReference>((IEnumerable<ResourceReference>)i_),
                PriorRequest = new List<ResourceReference>((IEnumerable<ResourceReference>)j_),
                GroupIdentifier = k_,
                StatusElement = l_,
                IntentElement = m_,
                PriorityElement = n_,
                Code = (DataType)o_,
                Parameter = new List<DeviceRequest.ParameterComponent>((IEnumerable<DeviceRequest.ParameterComponent>)p_),
                Subject = q_,
                Encounter = r_,
                Occurrence = (DataType)s_,
                AuthoredOnElement = t_,
                Requester = u_,
                PerformerType = v_,
                Performer = w_,
                ReasonCode = new List<CodeableConcept>((IEnumerable<CodeableConcept>)x_),
                ReasonReference = new List<ResourceReference>((IEnumerable<ResourceReference>)y_),
                Insurance = new List<ResourceReference>((IEnumerable<ResourceReference>)z_),
                SupportingInfo = new List<ResourceReference>((IEnumerable<ResourceReference>)aa_),
                Note = new List<Annotation>((IEnumerable<Annotation>)ab_),
                RelevantHistory = new List<ResourceReference>((IEnumerable<ResourceReference>)ac_),
            };
            return ad_;
        }

        IEnumerable<DeviceRequest> c_ = context.Operators.Select<DeviceRequest, DeviceRequest>((IEnumerable<DeviceRequest>)a_, b_);
        IEnumerable<DeviceRequest> d_ = context.Operators.Distinct<DeviceRequest>(c_);
        DeviceRequest e_ = context.Operators.SingletonFrom<DeviceRequest>(d_);
        return e_;
    }


    [CqlFunctionDefinition("DeviceUseStatementResource")]
    public DeviceUseStatement DeviceUseStatementResource(CqlContext context, DeviceUseStatement arg)
    {
        DeviceUseStatement[] a_ = [
            arg,
        ];

        DeviceUseStatement b_(DeviceUseStatement a) {
            List<Identifier> f_ = a?.Identifier;
            List<ResourceReference> g_ = a?.BasedOn;
            Code<DeviceUseStatement.DeviceUseStatementStatus> h_ = a?.StatusElement;
            ResourceReference i_ = a?.Subject;
            List<ResourceReference> j_ = a?.DerivedFrom;
            DataType k_ = a?.Timing;
            FhirDateTime l_ = a?.RecordedOnElement;
            ResourceReference m_ = a?.Source;
            ResourceReference n_ = a?.Device;
            List<CodeableConcept> o_ = a?.ReasonCode;
            List<ResourceReference> p_ = a?.ReasonReference;
            CodeableConcept q_ = a?.BodySite;
            List<Annotation> r_ = a?.Note;
            DeviceUseStatement s_ = new DeviceUseStatement
            {
                Identifier = new List<Identifier>((IEnumerable<Identifier>)f_),
                BasedOn = new List<ResourceReference>((IEnumerable<ResourceReference>)g_),
                StatusElement = h_,
                Subject = i_,
                DerivedFrom = new List<ResourceReference>((IEnumerable<ResourceReference>)j_),
                Timing = (DataType)k_,
                RecordedOnElement = l_,
                Source = m_,
                Device = n_,
                ReasonCode = new List<CodeableConcept>((IEnumerable<CodeableConcept>)o_),
                ReasonReference = new List<ResourceReference>((IEnumerable<ResourceReference>)p_),
                BodySite = q_,
                Note = new List<Annotation>((IEnumerable<Annotation>)r_),
            };
            return s_;
        }

        IEnumerable<DeviceUseStatement> c_ = context.Operators.Select<DeviceUseStatement, DeviceUseStatement>((IEnumerable<DeviceUseStatement>)a_, b_);
        IEnumerable<DeviceUseStatement> d_ = context.Operators.Distinct<DeviceUseStatement>(c_);
        DeviceUseStatement e_ = context.Operators.SingletonFrom<DeviceUseStatement>(d_);
        return e_;
    }


    [CqlFunctionDefinition("DiagnosticReportResource")]
    public DiagnosticReport DiagnosticReportResource(CqlContext context, DiagnosticReport arg)
    {
        DiagnosticReport[] a_ = [
            arg,
        ];

        DiagnosticReport b_(DiagnosticReport a) {
            List<Identifier> f_ = a?.Identifier;
            List<ResourceReference> g_ = a?.BasedOn;
            Code<DiagnosticReport.DiagnosticReportStatus> h_ = a?.StatusElement;
            List<CodeableConcept> i_ = a?.Category;
            CodeableConcept j_ = a?.Code;
            ResourceReference k_ = a?.Subject;
            ResourceReference l_ = a?.Encounter;
            DataType m_ = a?.Effective;
            Instant n_ = a?.IssuedElement;
            List<ResourceReference> o_ = a?.Performer;
            List<ResourceReference> p_ = a?.ResultsInterpreter;
            List<ResourceReference> q_ = a?.Specimen;
            List<ResourceReference> r_ = a?.Result;
            List<ResourceReference> s_ = a?.ImagingStudy;
            List<DiagnosticReport.MediaComponent> t_ = a?.Media;
            FhirString u_ = a?.ConclusionElement;
            List<CodeableConcept> v_ = a?.ConclusionCode;
            List<Attachment> w_ = a?.PresentedForm;
            DiagnosticReport x_ = new DiagnosticReport
            {
                Identifier = new List<Identifier>((IEnumerable<Identifier>)f_),
                BasedOn = new List<ResourceReference>((IEnumerable<ResourceReference>)g_),
                StatusElement = h_,
                Category = new List<CodeableConcept>((IEnumerable<CodeableConcept>)i_),
                Code = j_,
                Subject = k_,
                Encounter = l_,
                Effective = (DataType)m_,
                IssuedElement = n_,
                Performer = new List<ResourceReference>((IEnumerable<ResourceReference>)o_),
                ResultsInterpreter = new List<ResourceReference>((IEnumerable<ResourceReference>)p_),
                Specimen = new List<ResourceReference>((IEnumerable<ResourceReference>)q_),
                Result = new List<ResourceReference>((IEnumerable<ResourceReference>)r_),
                ImagingStudy = new List<ResourceReference>((IEnumerable<ResourceReference>)s_),
                Media = new List<DiagnosticReport.MediaComponent>((IEnumerable<DiagnosticReport.MediaComponent>)t_),
                ConclusionElement = u_,
                ConclusionCode = new List<CodeableConcept>((IEnumerable<CodeableConcept>)v_),
                PresentedForm = new List<Attachment>((IEnumerable<Attachment>)w_),
            };
            return x_;
        }

        IEnumerable<DiagnosticReport> c_ = context.Operators.Select<DiagnosticReport, DiagnosticReport>((IEnumerable<DiagnosticReport>)a_, b_);
        IEnumerable<DiagnosticReport> d_ = context.Operators.Distinct<DiagnosticReport>(c_);
        DiagnosticReport e_ = context.Operators.SingletonFrom<DiagnosticReport>(d_);
        return e_;
    }


    [CqlFunctionDefinition("DocumentManifestResource")]
    public DocumentManifest DocumentManifestResource(CqlContext context, DocumentManifest arg)
    {
        DocumentManifest[] a_ = [
            arg,
        ];

        DocumentManifest b_(DocumentManifest a) {
            Identifier f_ = a?.MasterIdentifier;
            List<Identifier> g_ = a?.Identifier;
            Code<DocumentReferenceStatus> h_ = a?.StatusElement;
            CodeableConcept i_ = a?.Type;
            ResourceReference j_ = a?.Subject;
            FhirDateTime k_ = a?.CreatedElement;
            List<ResourceReference> l_ = a?.Author;
            List<ResourceReference> m_ = a?.Recipient;
            FhirUri n_ = a?.SourceElement;
            FhirString o_ = a?.DescriptionElement;
            List<ResourceReference> p_ = a?.Content;
            List<DocumentManifest.RelatedComponent> q_ = a?.Related;
            DocumentManifest r_ = new DocumentManifest
            {
                MasterIdentifier = f_,
                Identifier = new List<Identifier>((IEnumerable<Identifier>)g_),
                StatusElement = h_,
                Type = i_,
                Subject = j_,
                CreatedElement = k_,
                Author = new List<ResourceReference>((IEnumerable<ResourceReference>)l_),
                Recipient = new List<ResourceReference>((IEnumerable<ResourceReference>)m_),
                SourceElement = n_,
                DescriptionElement = o_,
                Content = new List<ResourceReference>((IEnumerable<ResourceReference>)p_),
                Related = new List<DocumentManifest.RelatedComponent>((IEnumerable<DocumentManifest.RelatedComponent>)q_),
            };
            return r_;
        }

        IEnumerable<DocumentManifest> c_ = context.Operators.Select<DocumentManifest, DocumentManifest>((IEnumerable<DocumentManifest>)a_, b_);
        IEnumerable<DocumentManifest> d_ = context.Operators.Distinct<DocumentManifest>(c_);
        DocumentManifest e_ = context.Operators.SingletonFrom<DocumentManifest>(d_);
        return e_;
    }


    [CqlFunctionDefinition("DocumentReferenceResource")]
    public DocumentReference DocumentReferenceResource(CqlContext context, DocumentReference arg)
    {
        DocumentReference[] a_ = [
            arg,
        ];

        DocumentReference b_(DocumentReference a) {
            Identifier f_ = a?.MasterIdentifier;
            List<Identifier> g_ = a?.Identifier;
            Code<DocumentReferenceStatus> h_ = a?.StatusElement;
            Code<CompositionStatus> i_ = a?.DocStatusElement;
            CodeableConcept j_ = a?.Type;
            List<CodeableConcept> k_ = a?.Category;
            ResourceReference l_ = a?.Subject;
            Instant m_ = a?.DateElement;
            List<ResourceReference> n_ = a?.Author;
            ResourceReference o_ = a?.Authenticator;
            ResourceReference p_ = a?.Custodian;
            List<DocumentReference.RelatesToComponent> q_ = a?.RelatesTo;
            FhirString r_ = a?.DescriptionElement;
            List<CodeableConcept> s_ = a?.SecurityLabel;
            List<DocumentReference.ContentComponent> t_ = a?.Content;
            DocumentReference.ContextComponent u_ = a?.Context;
            DocumentReference v_ = new DocumentReference
            {
                MasterIdentifier = f_,
                Identifier = new List<Identifier>((IEnumerable<Identifier>)g_),
                StatusElement = h_,
                DocStatusElement = i_,
                Type = j_,
                Category = new List<CodeableConcept>((IEnumerable<CodeableConcept>)k_),
                Subject = l_,
                DateElement = m_,
                Author = new List<ResourceReference>((IEnumerable<ResourceReference>)n_),
                Authenticator = o_,
                Custodian = p_,
                RelatesTo = new List<DocumentReference.RelatesToComponent>((IEnumerable<DocumentReference.RelatesToComponent>)q_),
                DescriptionElement = r_,
                SecurityLabel = new List<CodeableConcept>((IEnumerable<CodeableConcept>)s_),
                Content = new List<DocumentReference.ContentComponent>((IEnumerable<DocumentReference.ContentComponent>)t_),
                Context = u_,
            };
            return v_;
        }

        IEnumerable<DocumentReference> c_ = context.Operators.Select<DocumentReference, DocumentReference>((IEnumerable<DocumentReference>)a_, b_);
        IEnumerable<DocumentReference> d_ = context.Operators.Distinct<DocumentReference>(c_);
        DocumentReference e_ = context.Operators.SingletonFrom<DocumentReference>(d_);
        return e_;
    }


    [CqlFunctionDefinition("EffectEvidenceSynthesisResource")]
    public EffectEvidenceSynthesis EffectEvidenceSynthesisResource(CqlContext context, EffectEvidenceSynthesis arg)
    {
        EffectEvidenceSynthesis[] a_ = [
            arg,
        ];

        EffectEvidenceSynthesis b_(EffectEvidenceSynthesis a) {
            FhirUri f_ = a?.UrlElement;
            List<Identifier> g_ = a?.Identifier;
            FhirString h_ = a?.VersionElement;
            FhirString i_ = a?.NameElement;
            FhirString j_ = a?.TitleElement;
            Code<PublicationStatus> k_ = a?.StatusElement;
            FhirDateTime l_ = a?.DateElement;
            FhirString m_ = a?.PublisherElement;
            List<ContactDetail> n_ = a?.Contact;
            Markdown o_ = a?.DescriptionElement;
            List<Annotation> p_ = a?.Note;
            List<UsageContext> q_ = a?.UseContext;
            List<CodeableConcept> r_ = a?.Jurisdiction;
            Markdown s_ = a?.CopyrightElement;
            Date t_ = a?.ApprovalDateElement;
            Date u_ = a?.LastReviewDateElement;
            Period v_ = a?.EffectivePeriod;
            List<CodeableConcept> w_ = a?.Topic;
            List<ContactDetail> x_ = a?.Author;
            List<ContactDetail> y_ = a?.Editor;
            List<ContactDetail> z_ = a?.Reviewer;
            List<ContactDetail> aa_ = a?.Endorser;
            List<RelatedArtifact> ab_ = a?.RelatedArtifact;
            CodeableConcept ac_ = a?.SynthesisType;
            CodeableConcept ad_ = a?.StudyType;
            ResourceReference ae_ = a?.Population;
            ResourceReference af_ = a?.Exposure;
            ResourceReference ag_ = a?.ExposureAlternative;
            ResourceReference ah_ = a?.Outcome;
            EffectEvidenceSynthesis.SampleSizeComponent ai_ = a?.SampleSize;
            List<EffectEvidenceSynthesis.ResultsByExposureComponent> aj_ = a?.ResultsByExposure;
            List<EffectEvidenceSynthesis.EffectEstimateComponent> ak_ = a?.EffectEstimate;
            List<EffectEvidenceSynthesis.CertaintyComponent> al_ = a?.Certainty;
            EffectEvidenceSynthesis am_ = new EffectEvidenceSynthesis
            {
                UrlElement = f_,
                Identifier = new List<Identifier>((IEnumerable<Identifier>)g_),
                VersionElement = h_,
                NameElement = i_,
                TitleElement = j_,
                StatusElement = k_,
                DateElement = l_,
                PublisherElement = m_,
                Contact = new List<ContactDetail>((IEnumerable<ContactDetail>)n_),
                DescriptionElement = o_,
                Note = new List<Annotation>((IEnumerable<Annotation>)p_),
                UseContext = new List<UsageContext>((IEnumerable<UsageContext>)q_),
                Jurisdiction = new List<CodeableConcept>((IEnumerable<CodeableConcept>)r_),
                CopyrightElement = s_,
                ApprovalDateElement = t_,
                LastReviewDateElement = u_,
                EffectivePeriod = v_,
                Topic = new List<CodeableConcept>((IEnumerable<CodeableConcept>)w_),
                Author = new List<ContactDetail>((IEnumerable<ContactDetail>)x_),
                Editor = new List<ContactDetail>((IEnumerable<ContactDetail>)y_),
                Reviewer = new List<ContactDetail>((IEnumerable<ContactDetail>)z_),
                Endorser = new List<ContactDetail>((IEnumerable<ContactDetail>)aa_),
                RelatedArtifact = new List<RelatedArtifact>((IEnumerable<RelatedArtifact>)ab_),
                SynthesisType = ac_,
                StudyType = ad_,
                Population = ae_,
                Exposure = af_,
                ExposureAlternative = ag_,
                Outcome = ah_,
                SampleSize = ai_,
                ResultsByExposure = new List<EffectEvidenceSynthesis.ResultsByExposureComponent>((IEnumerable<EffectEvidenceSynthesis.ResultsByExposureComponent>)aj_),
                EffectEstimate = new List<EffectEvidenceSynthesis.EffectEstimateComponent>((IEnumerable<EffectEvidenceSynthesis.EffectEstimateComponent>)ak_),
                Certainty = new List<EffectEvidenceSynthesis.CertaintyComponent>((IEnumerable<EffectEvidenceSynthesis.CertaintyComponent>)al_),
            };
            return am_;
        }

        IEnumerable<EffectEvidenceSynthesis> c_ = context.Operators.Select<EffectEvidenceSynthesis, EffectEvidenceSynthesis>((IEnumerable<EffectEvidenceSynthesis>)a_, b_);
        IEnumerable<EffectEvidenceSynthesis> d_ = context.Operators.Distinct<EffectEvidenceSynthesis>(c_);
        EffectEvidenceSynthesis e_ = context.Operators.SingletonFrom<EffectEvidenceSynthesis>(d_);
        return e_;
    }


    [CqlFunctionDefinition("EncounterResource")]
    public Encounter EncounterResource(CqlContext context, Encounter arg)
    {
        Encounter[] a_ = [
            arg,
        ];

        Encounter b_(Encounter a) {
            List<Identifier> f_ = a?.Identifier;
            Code<Encounter.EncounterStatus> g_ = a?.StatusElement;
            List<Encounter.StatusHistoryComponent> h_ = a?.StatusHistory;
            Coding i_ = a?.Class;
            List<Encounter.ClassHistoryComponent> j_ = a?.ClassHistory;
            List<CodeableConcept> k_ = a?.Type;
            CodeableConcept l_ = a?.ServiceType;
            CodeableConcept m_ = a?.Priority;
            ResourceReference n_ = a?.Subject;
            List<ResourceReference> o_ = a?.EpisodeOfCare;
            List<ResourceReference> p_ = a?.BasedOn;
            List<Encounter.ParticipantComponent> q_ = a?.Participant;
            List<ResourceReference> r_ = a?.Appointment;
            Period s_ = a?.Period;
            Duration t_ = a?.Length;
            List<CodeableConcept> u_ = a?.ReasonCode;
            List<ResourceReference> v_ = a?.ReasonReference;
            List<Encounter.DiagnosisComponent> w_ = a?.Diagnosis;
            List<ResourceReference> x_ = a?.Account;
            Encounter.HospitalizationComponent y_ = a?.Hospitalization;
            List<Encounter.LocationComponent> z_ = a?.Location;
            ResourceReference aa_ = a?.ServiceProvider;
            ResourceReference ab_ = a?.PartOf;
            Encounter ac_ = new Encounter
            {
                Identifier = new List<Identifier>((IEnumerable<Identifier>)f_),
                StatusElement = g_,
                StatusHistory = new List<Encounter.StatusHistoryComponent>((IEnumerable<Encounter.StatusHistoryComponent>)h_),
                Class = i_,
                ClassHistory = new List<Encounter.ClassHistoryComponent>((IEnumerable<Encounter.ClassHistoryComponent>)j_),
                Type = new List<CodeableConcept>((IEnumerable<CodeableConcept>)k_),
                ServiceType = l_,
                Priority = m_,
                Subject = n_,
                EpisodeOfCare = new List<ResourceReference>((IEnumerable<ResourceReference>)o_),
                BasedOn = new List<ResourceReference>((IEnumerable<ResourceReference>)p_),
                Participant = new List<Encounter.ParticipantComponent>((IEnumerable<Encounter.ParticipantComponent>)q_),
                Appointment = new List<ResourceReference>((IEnumerable<ResourceReference>)r_),
                Period = s_,
                Length = t_,
                ReasonCode = new List<CodeableConcept>((IEnumerable<CodeableConcept>)u_),
                ReasonReference = new List<ResourceReference>((IEnumerable<ResourceReference>)v_),
                Diagnosis = new List<Encounter.DiagnosisComponent>((IEnumerable<Encounter.DiagnosisComponent>)w_),
                Account = new List<ResourceReference>((IEnumerable<ResourceReference>)x_),
                Hospitalization = y_,
                Location = new List<Encounter.LocationComponent>((IEnumerable<Encounter.LocationComponent>)z_),
                ServiceProvider = aa_,
                PartOf = ab_,
            };
            return ac_;
        }

        IEnumerable<Encounter> c_ = context.Operators.Select<Encounter, Encounter>((IEnumerable<Encounter>)a_, b_);
        IEnumerable<Encounter> d_ = context.Operators.Distinct<Encounter>(c_);
        Encounter e_ = context.Operators.SingletonFrom<Encounter>(d_);
        return e_;
    }


    [CqlFunctionDefinition("EndpointResource")]
    public Endpoint EndpointResource(CqlContext context, Endpoint arg)
    {
        Endpoint[] a_ = [
            arg,
        ];

        Endpoint b_(Endpoint a) {
            List<Identifier> f_ = a?.Identifier;
            Code<Endpoint.EndpointStatus> g_ = a?.StatusElement;
            Coding h_ = a?.ConnectionType;
            FhirString i_ = a?.NameElement;
            ResourceReference j_ = a?.ManagingOrganization;
            List<ContactPoint> k_ = a?.Contact;
            Period l_ = a?.Period;
            List<CodeableConcept> m_ = a?.PayloadType;
            List<Code> n_ = a?.PayloadMimeTypeElement;
            FhirUrl o_ = a?.AddressElement;
            List<FhirString> p_ = a?.HeaderElement;
            Endpoint q_ = new Endpoint
            {
                Identifier = new List<Identifier>((IEnumerable<Identifier>)f_),
                StatusElement = g_,
                ConnectionType = h_,
                NameElement = i_,
                ManagingOrganization = j_,
                Contact = new List<ContactPoint>((IEnumerable<ContactPoint>)k_),
                Period = l_,
                PayloadType = new List<CodeableConcept>((IEnumerable<CodeableConcept>)m_),
                PayloadMimeTypeElement = new List<Code>((IEnumerable<Code>)n_),
                AddressElement = o_,
                HeaderElement = new List<FhirString>((IEnumerable<FhirString>)p_),
            };
            return q_;
        }

        IEnumerable<Endpoint> c_ = context.Operators.Select<Endpoint, Endpoint>((IEnumerable<Endpoint>)a_, b_);
        IEnumerable<Endpoint> d_ = context.Operators.Distinct<Endpoint>(c_);
        Endpoint e_ = context.Operators.SingletonFrom<Endpoint>(d_);
        return e_;
    }


    [CqlFunctionDefinition("EnrollmentRequestResource")]
    public EnrollmentRequest EnrollmentRequestResource(CqlContext context, EnrollmentRequest arg)
    {
        EnrollmentRequest[] a_ = [
            arg,
        ];

        EnrollmentRequest b_(EnrollmentRequest a) {
            List<Identifier> f_ = a?.Identifier;
            Code<FinancialResourceStatusCodes> g_ = a?.StatusElement;
            FhirDateTime h_ = a?.CreatedElement;
            ResourceReference i_ = a?.Insurer;
            ResourceReference j_ = a?.Provider;
            ResourceReference k_ = a?.Candidate;
            ResourceReference l_ = a?.Coverage;
            EnrollmentRequest m_ = new EnrollmentRequest
            {
                Identifier = new List<Identifier>((IEnumerable<Identifier>)f_),
                StatusElement = g_,
                CreatedElement = h_,
                Insurer = i_,
                Provider = j_,
                Candidate = k_,
                Coverage = l_,
            };
            return m_;
        }

        IEnumerable<EnrollmentRequest> c_ = context.Operators.Select<EnrollmentRequest, EnrollmentRequest>((IEnumerable<EnrollmentRequest>)a_, b_);
        IEnumerable<EnrollmentRequest> d_ = context.Operators.Distinct<EnrollmentRequest>(c_);
        EnrollmentRequest e_ = context.Operators.SingletonFrom<EnrollmentRequest>(d_);
        return e_;
    }


    [CqlFunctionDefinition("EnrollmentResponseResource")]
    public EnrollmentResponse EnrollmentResponseResource(CqlContext context, EnrollmentResponse arg)
    {
        EnrollmentResponse[] a_ = [
            arg,
        ];

        EnrollmentResponse b_(EnrollmentResponse a) {
            List<Identifier> f_ = a?.Identifier;
            Code<FinancialResourceStatusCodes> g_ = a?.StatusElement;
            ResourceReference h_ = a?.Request;
            Code<ClaimProcessingCodes> i_ = a?.OutcomeElement;
            FhirString j_ = a?.DispositionElement;
            FhirDateTime k_ = a?.CreatedElement;
            ResourceReference l_ = a?.Organization;
            ResourceReference m_ = a?.RequestProvider;
            EnrollmentResponse n_ = new EnrollmentResponse
            {
                Identifier = new List<Identifier>((IEnumerable<Identifier>)f_),
                StatusElement = g_,
                Request = h_,
                OutcomeElement = i_,
                DispositionElement = j_,
                CreatedElement = k_,
                Organization = l_,
                RequestProvider = m_,
            };
            return n_;
        }

        IEnumerable<EnrollmentResponse> c_ = context.Operators.Select<EnrollmentResponse, EnrollmentResponse>((IEnumerable<EnrollmentResponse>)a_, b_);
        IEnumerable<EnrollmentResponse> d_ = context.Operators.Distinct<EnrollmentResponse>(c_);
        EnrollmentResponse e_ = context.Operators.SingletonFrom<EnrollmentResponse>(d_);
        return e_;
    }


    [CqlFunctionDefinition("EpisodeOfCareResource")]
    public EpisodeOfCare EpisodeOfCareResource(CqlContext context, EpisodeOfCare arg)
    {
        EpisodeOfCare[] a_ = [
            arg,
        ];

        EpisodeOfCare b_(EpisodeOfCare a) {
            List<Identifier> f_ = a?.Identifier;
            Code<EpisodeOfCare.EpisodeOfCareStatus> g_ = a?.StatusElement;
            List<EpisodeOfCare.StatusHistoryComponent> h_ = a?.StatusHistory;
            List<CodeableConcept> i_ = a?.Type;
            List<EpisodeOfCare.DiagnosisComponent> j_ = a?.Diagnosis;
            ResourceReference k_ = a?.Patient;
            ResourceReference l_ = a?.ManagingOrganization;
            Period m_ = a?.Period;
            List<ResourceReference> n_ = a?.ReferralRequest;
            ResourceReference o_ = a?.CareManager;
            List<ResourceReference> p_ = a?.Team;
            List<ResourceReference> q_ = a?.Account;
            EpisodeOfCare r_ = new EpisodeOfCare
            {
                Identifier = new List<Identifier>((IEnumerable<Identifier>)f_),
                StatusElement = g_,
                StatusHistory = new List<EpisodeOfCare.StatusHistoryComponent>((IEnumerable<EpisodeOfCare.StatusHistoryComponent>)h_),
                Type = new List<CodeableConcept>((IEnumerable<CodeableConcept>)i_),
                Diagnosis = new List<EpisodeOfCare.DiagnosisComponent>((IEnumerable<EpisodeOfCare.DiagnosisComponent>)j_),
                Patient = k_,
                ManagingOrganization = l_,
                Period = m_,
                ReferralRequest = new List<ResourceReference>((IEnumerable<ResourceReference>)n_),
                CareManager = o_,
                Team = new List<ResourceReference>((IEnumerable<ResourceReference>)p_),
                Account = new List<ResourceReference>((IEnumerable<ResourceReference>)q_),
            };
            return r_;
        }

        IEnumerable<EpisodeOfCare> c_ = context.Operators.Select<EpisodeOfCare, EpisodeOfCare>((IEnumerable<EpisodeOfCare>)a_, b_);
        IEnumerable<EpisodeOfCare> d_ = context.Operators.Distinct<EpisodeOfCare>(c_);
        EpisodeOfCare e_ = context.Operators.SingletonFrom<EpisodeOfCare>(d_);
        return e_;
    }


    [CqlFunctionDefinition("EventDefinitionResource")]
    public EventDefinition EventDefinitionResource(CqlContext context, EventDefinition arg)
    {
        EventDefinition[] a_ = [
            arg,
        ];

        EventDefinition b_(EventDefinition a) {
            FhirUri f_ = a?.UrlElement;
            List<Identifier> g_ = a?.Identifier;
            FhirString h_ = a?.VersionElement;
            FhirString i_ = a?.NameElement;
            FhirString j_ = a?.TitleElement;
            FhirString k_ = a?.SubtitleElement;
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
            List<TriggerDefinition> ag_ = a?.Trigger;
            EventDefinition ah_ = new EventDefinition
            {
                UrlElement = f_,
                Identifier = new List<Identifier>((IEnumerable<Identifier>)g_),
                VersionElement = h_,
                NameElement = i_,
                TitleElement = j_,
                SubtitleElement = k_,
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
                Trigger = new List<TriggerDefinition>((IEnumerable<TriggerDefinition>)ag_),
            };
            return ah_;
        }

        IEnumerable<EventDefinition> c_ = context.Operators.Select<EventDefinition, EventDefinition>((IEnumerable<EventDefinition>)a_, b_);
        IEnumerable<EventDefinition> d_ = context.Operators.Distinct<EventDefinition>(c_);
        EventDefinition e_ = context.Operators.SingletonFrom<EventDefinition>(d_);
        return e_;
    }


    [CqlFunctionDefinition("EvidenceResource")]
    public Evidence EvidenceResource(CqlContext context, Evidence arg)
    {
        Evidence[] a_ = [
            arg,
        ];

        Evidence b_(Evidence a) {
            FhirUri f_ = a?.UrlElement;
            List<Identifier> g_ = a?.Identifier;
            FhirString h_ = a?.VersionElement;
            FhirString i_ = a?.NameElement;
            FhirString j_ = a?.TitleElement;
            FhirString k_ = a?.ShortTitleElement;
            FhirString l_ = a?.SubtitleElement;
            Code<PublicationStatus> m_ = a?.StatusElement;
            FhirDateTime n_ = a?.DateElement;
            FhirString o_ = a?.PublisherElement;
            List<ContactDetail> p_ = a?.Contact;
            Markdown q_ = a?.DescriptionElement;
            List<Annotation> r_ = a?.Note;
            List<UsageContext> s_ = a?.UseContext;
            List<CodeableConcept> t_ = a?.Jurisdiction;
            Markdown u_ = a?.CopyrightElement;
            Date v_ = a?.ApprovalDateElement;
            Date w_ = a?.LastReviewDateElement;
            Period x_ = a?.EffectivePeriod;
            List<CodeableConcept> y_ = a?.Topic;
            List<ContactDetail> z_ = a?.Author;
            List<ContactDetail> aa_ = a?.Editor;
            List<ContactDetail> ab_ = a?.Reviewer;
            List<ContactDetail> ac_ = a?.Endorser;
            List<RelatedArtifact> ad_ = a?.RelatedArtifact;
            ResourceReference ae_ = a?.ExposureBackground;
            List<ResourceReference> af_ = a?.ExposureVariant;
            List<ResourceReference> ag_ = a?.Outcome;
            Evidence ah_ = new Evidence
            {
                UrlElement = f_,
                Identifier = new List<Identifier>((IEnumerable<Identifier>)g_),
                VersionElement = h_,
                NameElement = i_,
                TitleElement = j_,
                ShortTitleElement = k_,
                SubtitleElement = l_,
                StatusElement = m_,
                DateElement = n_,
                PublisherElement = o_,
                Contact = new List<ContactDetail>((IEnumerable<ContactDetail>)p_),
                DescriptionElement = q_,
                Note = new List<Annotation>((IEnumerable<Annotation>)r_),
                UseContext = new List<UsageContext>((IEnumerable<UsageContext>)s_),
                Jurisdiction = new List<CodeableConcept>((IEnumerable<CodeableConcept>)t_),
                CopyrightElement = u_,
                ApprovalDateElement = v_,
                LastReviewDateElement = w_,
                EffectivePeriod = x_,
                Topic = new List<CodeableConcept>((IEnumerable<CodeableConcept>)y_),
                Author = new List<ContactDetail>((IEnumerable<ContactDetail>)z_),
                Editor = new List<ContactDetail>((IEnumerable<ContactDetail>)aa_),
                Reviewer = new List<ContactDetail>((IEnumerable<ContactDetail>)ab_),
                Endorser = new List<ContactDetail>((IEnumerable<ContactDetail>)ac_),
                RelatedArtifact = new List<RelatedArtifact>((IEnumerable<RelatedArtifact>)ad_),
                ExposureBackground = ae_,
                ExposureVariant = new List<ResourceReference>((IEnumerable<ResourceReference>)af_),
                Outcome = new List<ResourceReference>((IEnumerable<ResourceReference>)ag_),
            };
            return ah_;
        }

        IEnumerable<Evidence> c_ = context.Operators.Select<Evidence, Evidence>((IEnumerable<Evidence>)a_, b_);
        IEnumerable<Evidence> d_ = context.Operators.Distinct<Evidence>(c_);
        Evidence e_ = context.Operators.SingletonFrom<Evidence>(d_);
        return e_;
    }


    [CqlFunctionDefinition("EvidenceVariableResource")]
    public EvidenceVariable EvidenceVariableResource(CqlContext context, EvidenceVariable arg)
    {
        EvidenceVariable[] a_ = [
            arg,
        ];

        EvidenceVariable b_(EvidenceVariable a) {
            FhirUri f_ = a?.UrlElement;
            List<Identifier> g_ = a?.Identifier;
            FhirString h_ = a?.VersionElement;
            FhirString i_ = a?.NameElement;
            FhirString j_ = a?.TitleElement;
            FhirString k_ = a?.ShortTitleElement;
            FhirString l_ = a?.SubtitleElement;
            Code<PublicationStatus> m_ = a?.StatusElement;
            FhirDateTime n_ = a?.DateElement;
            FhirString o_ = a?.PublisherElement;
            List<ContactDetail> p_ = a?.Contact;
            Markdown q_ = a?.DescriptionElement;
            List<Annotation> r_ = a?.Note;
            List<UsageContext> s_ = a?.UseContext;
            List<CodeableConcept> t_ = a?.Jurisdiction;
            Markdown u_ = a?.CopyrightElement;
            Date v_ = a?.ApprovalDateElement;
            Date w_ = a?.LastReviewDateElement;
            Period x_ = a?.EffectivePeriod;
            List<CodeableConcept> y_ = a?.Topic;
            List<ContactDetail> z_ = a?.Author;
            List<ContactDetail> aa_ = a?.Editor;
            List<ContactDetail> ab_ = a?.Reviewer;
            List<ContactDetail> ac_ = a?.Endorser;
            List<RelatedArtifact> ad_ = a?.RelatedArtifact;
            Code<VariableTypeCode> ae_ = a?.TypeElement;
            List<EvidenceVariable.CharacteristicComponent> af_ = a?.Characteristic;
            EvidenceVariable ag_ = new EvidenceVariable
            {
                UrlElement = f_,
                Identifier = new List<Identifier>((IEnumerable<Identifier>)g_),
                VersionElement = h_,
                NameElement = i_,
                TitleElement = j_,
                ShortTitleElement = k_,
                SubtitleElement = l_,
                StatusElement = m_,
                DateElement = n_,
                PublisherElement = o_,
                Contact = new List<ContactDetail>((IEnumerable<ContactDetail>)p_),
                DescriptionElement = q_,
                Note = new List<Annotation>((IEnumerable<Annotation>)r_),
                UseContext = new List<UsageContext>((IEnumerable<UsageContext>)s_),
                Jurisdiction = new List<CodeableConcept>((IEnumerable<CodeableConcept>)t_),
                CopyrightElement = u_,
                ApprovalDateElement = v_,
                LastReviewDateElement = w_,
                EffectivePeriod = x_,
                Topic = new List<CodeableConcept>((IEnumerable<CodeableConcept>)y_),
                Author = new List<ContactDetail>((IEnumerable<ContactDetail>)z_),
                Editor = new List<ContactDetail>((IEnumerable<ContactDetail>)aa_),
                Reviewer = new List<ContactDetail>((IEnumerable<ContactDetail>)ab_),
                Endorser = new List<ContactDetail>((IEnumerable<ContactDetail>)ac_),
                RelatedArtifact = new List<RelatedArtifact>((IEnumerable<RelatedArtifact>)ad_),
                TypeElement = ae_,
                Characteristic = new List<EvidenceVariable.CharacteristicComponent>((IEnumerable<EvidenceVariable.CharacteristicComponent>)af_),
            };
            return ag_;
        }

        IEnumerable<EvidenceVariable> c_ = context.Operators.Select<EvidenceVariable, EvidenceVariable>((IEnumerable<EvidenceVariable>)a_, b_);
        IEnumerable<EvidenceVariable> d_ = context.Operators.Distinct<EvidenceVariable>(c_);
        EvidenceVariable e_ = context.Operators.SingletonFrom<EvidenceVariable>(d_);
        return e_;
    }


    [CqlFunctionDefinition("ExplanationOfBenefitResource")]
    public ExplanationOfBenefit ExplanationOfBenefitResource(CqlContext context, ExplanationOfBenefit arg)
    {
        ExplanationOfBenefit[] a_ = [
            arg,
        ];

        ExplanationOfBenefit b_(ExplanationOfBenefit a) {
            List<Identifier> f_ = a?.Identifier;
            Code<ExplanationOfBenefit.ExplanationOfBenefitStatus> g_ = a?.StatusElement;
            CodeableConcept h_ = a?.Type;
            CodeableConcept i_ = a?.SubType;
            Code<ClaimUseCode> j_ = a?.UseElement;
            ResourceReference k_ = a?.Patient;
            Period l_ = a?.BillablePeriod;
            FhirDateTime m_ = a?.CreatedElement;
            ResourceReference n_ = a?.Enterer;
            ResourceReference o_ = a?.Insurer;
            ResourceReference p_ = a?.Provider;
            CodeableConcept q_ = a?.Priority;
            CodeableConcept r_ = a?.FundsReserveRequested;
            CodeableConcept s_ = a?.FundsReserve;
            List<ExplanationOfBenefit.RelatedClaimComponent> t_ = a?.Related;
            ResourceReference u_ = a?.Prescription;
            ResourceReference v_ = a?.OriginalPrescription;
            ExplanationOfBenefit.PayeeComponent w_ = a?.Payee;
            ResourceReference x_ = a?.Referral;
            ResourceReference y_ = a?.Facility;
            ResourceReference z_ = a?.Claim;
            ResourceReference aa_ = a?.ClaimResponse;
            Code<ClaimProcessingCodes> ab_ = a?.OutcomeElement;
            FhirString ac_ = a?.DispositionElement;
            List<FhirString> ad_ = a?.PreAuthRefElement;
            List<Period> ae_ = a?.PreAuthRefPeriod;
            List<ExplanationOfBenefit.CareTeamComponent> af_ = a?.CareTeam;
            List<ExplanationOfBenefit.SupportingInformationComponent> ag_ = a?.SupportingInfo;
            List<ExplanationOfBenefit.DiagnosisComponent> ah_ = a?.Diagnosis;
            List<ExplanationOfBenefit.ProcedureComponent> ai_ = a?.Procedure;
            PositiveInt aj_ = a?.PrecedenceElement;
            Integer ak_ = context.Operators.Convert<Integer>(aj_);
            PositiveInt al_ = context.Operators.Convert<PositiveInt>(ak_);
            List<ExplanationOfBenefit.InsuranceComponent> am_ = a?.Insurance;
            ExplanationOfBenefit.AccidentComponent an_ = a?.Accident;
            List<ExplanationOfBenefit.ItemComponent> ao_ = a?.Item;
            List<ExplanationOfBenefit.AddedItemComponent> ap_ = a?.AddItem;
            List<ExplanationOfBenefit.AdjudicationComponent> aq_ = a?.Adjudication;
            List<ExplanationOfBenefit.TotalComponent> ar_ = a?.Total;
            ExplanationOfBenefit.PaymentComponent as_ = a?.Payment;
            CodeableConcept at_ = a?.FormCode;
            Attachment au_ = a?.Form;
            List<ExplanationOfBenefit.NoteComponent> av_ = a?.ProcessNote;
            Period aw_ = a?.BenefitPeriod;
            List<ExplanationOfBenefit.BenefitBalanceComponent> ax_ = a?.BenefitBalance;
            ExplanationOfBenefit ay_ = new ExplanationOfBenefit
            {
                Identifier = new List<Identifier>((IEnumerable<Identifier>)f_),
                StatusElement = g_,
                Type = h_,
                SubType = i_,
                UseElement = j_,
                Patient = k_,
                BillablePeriod = l_,
                CreatedElement = m_,
                Enterer = n_,
                Insurer = o_,
                Provider = p_,
                Priority = q_,
                FundsReserveRequested = r_,
                FundsReserve = s_,
                Related = new List<ExplanationOfBenefit.RelatedClaimComponent>((IEnumerable<ExplanationOfBenefit.RelatedClaimComponent>)t_),
                Prescription = u_,
                OriginalPrescription = v_,
                Payee = w_,
                Referral = x_,
                Facility = y_,
                Claim = z_,
                ClaimResponse = aa_,
                OutcomeElement = ab_,
                DispositionElement = ac_,
                PreAuthRefElement = new List<FhirString>((IEnumerable<FhirString>)ad_),
                PreAuthRefPeriod = new List<Period>((IEnumerable<Period>)ae_),
                CareTeam = new List<ExplanationOfBenefit.CareTeamComponent>((IEnumerable<ExplanationOfBenefit.CareTeamComponent>)af_),
                SupportingInfo = new List<ExplanationOfBenefit.SupportingInformationComponent>((IEnumerable<ExplanationOfBenefit.SupportingInformationComponent>)ag_),
                Diagnosis = new List<ExplanationOfBenefit.DiagnosisComponent>((IEnumerable<ExplanationOfBenefit.DiagnosisComponent>)ah_),
                Procedure = new List<ExplanationOfBenefit.ProcedureComponent>((IEnumerable<ExplanationOfBenefit.ProcedureComponent>)ai_),
                PrecedenceElement = al_,
                Insurance = new List<ExplanationOfBenefit.InsuranceComponent>((IEnumerable<ExplanationOfBenefit.InsuranceComponent>)am_),
                Accident = an_,
                Item = new List<ExplanationOfBenefit.ItemComponent>((IEnumerable<ExplanationOfBenefit.ItemComponent>)ao_),
                AddItem = new List<ExplanationOfBenefit.AddedItemComponent>((IEnumerable<ExplanationOfBenefit.AddedItemComponent>)ap_),
                Adjudication = new List<ExplanationOfBenefit.AdjudicationComponent>((IEnumerable<ExplanationOfBenefit.AdjudicationComponent>)aq_),
                Total = new List<ExplanationOfBenefit.TotalComponent>((IEnumerable<ExplanationOfBenefit.TotalComponent>)ar_),
                Payment = as_,
                FormCode = at_,
                Form = au_,
                ProcessNote = new List<ExplanationOfBenefit.NoteComponent>((IEnumerable<ExplanationOfBenefit.NoteComponent>)av_),
                BenefitPeriod = aw_,
                BenefitBalance = new List<ExplanationOfBenefit.BenefitBalanceComponent>((IEnumerable<ExplanationOfBenefit.BenefitBalanceComponent>)ax_),
            };
            return ay_;
        }

        IEnumerable<ExplanationOfBenefit> c_ = context.Operators.Select<ExplanationOfBenefit, ExplanationOfBenefit>((IEnumerable<ExplanationOfBenefit>)a_, b_);
        IEnumerable<ExplanationOfBenefit> d_ = context.Operators.Distinct<ExplanationOfBenefit>(c_);
        ExplanationOfBenefit e_ = context.Operators.SingletonFrom<ExplanationOfBenefit>(d_);
        return e_;
    }


    [CqlFunctionDefinition("FamilyMemberHistoryResource")]
    public FamilyMemberHistory FamilyMemberHistoryResource(CqlContext context, FamilyMemberHistory arg)
    {
        FamilyMemberHistory[] a_ = [
            arg,
        ];

        FamilyMemberHistory b_(FamilyMemberHistory a) {
            List<Identifier> f_ = a?.Identifier;
            List<Canonical> g_ = a?.InstantiatesCanonicalElement;
            List<FhirUri> h_ = a?.InstantiatesUriElement;
            Code<FamilyMemberHistory.FamilyHistoryStatus> i_ = a?.StatusElement;
            CodeableConcept j_ = a?.DataAbsentReason;
            ResourceReference k_ = a?.Patient;
            FhirDateTime l_ = a?.DateElement;
            FhirString m_ = a?.NameElement;
            CodeableConcept n_ = a?.Relationship;
            CodeableConcept o_ = a?.Sex;
            DataType p_ = a?.Born;
            DataType q_ = a?.Age;
            FhirBoolean r_ = a?.EstimatedAgeElement;
            DataType s_ = a?.Deceased;
            List<CodeableConcept> t_ = a?.ReasonCode;
            List<ResourceReference> u_ = a?.ReasonReference;
            List<Annotation> v_ = a?.Note;
            List<FamilyMemberHistory.ConditionComponent> w_ = a?.Condition;
            FamilyMemberHistory x_ = new FamilyMemberHistory
            {
                Identifier = new List<Identifier>((IEnumerable<Identifier>)f_),
                InstantiatesCanonicalElement = new List<Canonical>((IEnumerable<Canonical>)g_),
                InstantiatesUriElement = new List<FhirUri>((IEnumerable<FhirUri>)h_),
                StatusElement = i_,
                DataAbsentReason = j_,
                Patient = k_,
                DateElement = l_,
                NameElement = m_,
                Relationship = n_,
                Sex = o_,
                Born = (DataType)p_,
                Age = (DataType)q_,
                EstimatedAgeElement = r_,
                Deceased = (DataType)s_,
                ReasonCode = new List<CodeableConcept>((IEnumerable<CodeableConcept>)t_),
                ReasonReference = new List<ResourceReference>((IEnumerable<ResourceReference>)u_),
                Note = new List<Annotation>((IEnumerable<Annotation>)v_),
                Condition = new List<FamilyMemberHistory.ConditionComponent>((IEnumerable<FamilyMemberHistory.ConditionComponent>)w_),
            };
            return x_;
        }

        IEnumerable<FamilyMemberHistory> c_ = context.Operators.Select<FamilyMemberHistory, FamilyMemberHistory>((IEnumerable<FamilyMemberHistory>)a_, b_);
        IEnumerable<FamilyMemberHistory> d_ = context.Operators.Distinct<FamilyMemberHistory>(c_);
        FamilyMemberHistory e_ = context.Operators.SingletonFrom<FamilyMemberHistory>(d_);
        return e_;
    }


    [CqlFunctionDefinition("FlagResource")]
    public Flag FlagResource(CqlContext context, Flag arg)
    {
        Flag[] a_ = [
            arg,
        ];

        Flag b_(Flag a) {
            List<Identifier> f_ = a?.Identifier;
            Code<Flag.FlagStatus> g_ = a?.StatusElement;
            List<CodeableConcept> h_ = a?.Category;
            CodeableConcept i_ = a?.Code;
            ResourceReference j_ = a?.Subject;
            Period k_ = a?.Period;
            ResourceReference l_ = a?.Encounter;
            ResourceReference m_ = a?.Author;
            Flag n_ = new Flag
            {
                Identifier = new List<Identifier>((IEnumerable<Identifier>)f_),
                StatusElement = g_,
                Category = new List<CodeableConcept>((IEnumerable<CodeableConcept>)h_),
                Code = i_,
                Subject = j_,
                Period = k_,
                Encounter = l_,
                Author = m_,
            };
            return n_;
        }

        IEnumerable<Flag> c_ = context.Operators.Select<Flag, Flag>((IEnumerable<Flag>)a_, b_);
        IEnumerable<Flag> d_ = context.Operators.Distinct<Flag>(c_);
        Flag e_ = context.Operators.SingletonFrom<Flag>(d_);
        return e_;
    }


    [CqlFunctionDefinition("GoalResource")]
    public Goal GoalResource(CqlContext context, Goal arg)
    {
        Goal[] a_ = [
            arg,
        ];

        Goal b_(Goal a) {
            List<Identifier> f_ = a?.Identifier;
            Code<Goal.GoalLifecycleStatus> g_ = a?.LifecycleStatusElement;
            CodeableConcept h_ = a?.AchievementStatus;
            List<CodeableConcept> i_ = a?.Category;
            CodeableConcept j_ = a?.Priority;
            CodeableConcept k_ = a?.Description;
            ResourceReference l_ = a?.Subject;
            DataType m_ = a?.Start;
            List<Goal.TargetComponent> n_ = a?.Target;
            Date o_ = a?.StatusDateElement;
            FhirString p_ = a?.StatusReasonElement;
            ResourceReference q_ = a?.ExpressedBy;
            List<ResourceReference> r_ = a?.Addresses;
            List<Annotation> s_ = a?.Note;
            List<CodeableConcept> t_ = a?.OutcomeCode;
            List<ResourceReference> u_ = a?.OutcomeReference;
            Goal v_ = new Goal
            {
                Identifier = new List<Identifier>((IEnumerable<Identifier>)f_),
                LifecycleStatusElement = g_,
                AchievementStatus = h_,
                Category = new List<CodeableConcept>((IEnumerable<CodeableConcept>)i_),
                Priority = j_,
                Description = k_,
                Subject = l_,
                Start = (DataType)m_,
                Target = new List<Goal.TargetComponent>((IEnumerable<Goal.TargetComponent>)n_),
                StatusDateElement = o_,
                StatusReasonElement = p_,
                ExpressedBy = q_,
                Addresses = new List<ResourceReference>((IEnumerable<ResourceReference>)r_),
                Note = new List<Annotation>((IEnumerable<Annotation>)s_),
                OutcomeCode = new List<CodeableConcept>((IEnumerable<CodeableConcept>)t_),
                OutcomeReference = new List<ResourceReference>((IEnumerable<ResourceReference>)u_),
            };
            return v_;
        }

        IEnumerable<Goal> c_ = context.Operators.Select<Goal, Goal>((IEnumerable<Goal>)a_, b_);
        IEnumerable<Goal> d_ = context.Operators.Distinct<Goal>(c_);
        Goal e_ = context.Operators.SingletonFrom<Goal>(d_);
        return e_;
    }


    [CqlFunctionDefinition("GroupResource")]
    public Group GroupResource(CqlContext context, Group arg)
    {
        Group[] a_ = [
            arg,
        ];

        Group b_(Group a) {
            List<Identifier> f_ = a?.Identifier;
            FhirBoolean g_ = a?.ActiveElement;
            Code<Group.GroupType> h_ = a?.TypeElement;
            FhirBoolean i_ = a?.ActualElement;
            CodeableConcept j_ = a?.Code;
            FhirString k_ = a?.NameElement;
            UnsignedInt l_ = a?.QuantityElement;
            Integer m_ = context.Operators.Convert<Integer>(l_);
            UnsignedInt n_ = context.Operators.Convert<UnsignedInt>(m_);
            ResourceReference o_ = a?.ManagingEntity;
            List<Group.CharacteristicComponent> p_ = a?.Characteristic;
            List<Group.MemberComponent> q_ = a?.Member;
            Group r_ = new Group
            {
                Identifier = new List<Identifier>((IEnumerable<Identifier>)f_),
                ActiveElement = g_,
                TypeElement = h_,
                ActualElement = i_,
                Code = j_,
                NameElement = k_,
                QuantityElement = n_,
                ManagingEntity = o_,
                Characteristic = new List<Group.CharacteristicComponent>((IEnumerable<Group.CharacteristicComponent>)p_),
                Member = new List<Group.MemberComponent>((IEnumerable<Group.MemberComponent>)q_),
            };
            return r_;
        }

        IEnumerable<Group> c_ = context.Operators.Select<Group, Group>((IEnumerable<Group>)a_, b_);
        IEnumerable<Group> d_ = context.Operators.Distinct<Group>(c_);
        Group e_ = context.Operators.SingletonFrom<Group>(d_);
        return e_;
    }


    [CqlFunctionDefinition("GuidanceResponseResource")]
    public GuidanceResponse GuidanceResponseResource(CqlContext context, GuidanceResponse arg)
    {
        GuidanceResponse[] a_ = [
            arg,
        ];

        GuidanceResponse b_(GuidanceResponse a) {
            Identifier f_ = a?.RequestIdentifier;
            List<Identifier> g_ = a?.Identifier;
            DataType h_ = a?.Module;
            Code<GuidanceResponse.GuidanceResponseStatus> i_ = a?.StatusElement;
            ResourceReference j_ = a?.Subject;
            ResourceReference k_ = a?.Encounter;
            FhirDateTime l_ = a?.OccurrenceDateTimeElement;
            ResourceReference m_ = a?.Performer;
            List<CodeableConcept> n_ = a?.ReasonCode;
            List<ResourceReference> o_ = a?.ReasonReference;
            List<Annotation> p_ = a?.Note;
            List<ResourceReference> q_ = a?.EvaluationMessage;
            ResourceReference r_ = a?.OutputParameters;
            ResourceReference s_ = a?.Result;
            List<DataRequirement> t_ = a?.DataRequirement;
            GuidanceResponse u_ = new GuidanceResponse
            {
                RequestIdentifier = f_,
                Identifier = new List<Identifier>((IEnumerable<Identifier>)g_),
                Module = (DataType)h_,
                StatusElement = i_,
                Subject = j_,
                Encounter = k_,
                OccurrenceDateTimeElement = l_,
                Performer = m_,
                ReasonCode = new List<CodeableConcept>((IEnumerable<CodeableConcept>)n_),
                ReasonReference = new List<ResourceReference>((IEnumerable<ResourceReference>)o_),
                Note = new List<Annotation>((IEnumerable<Annotation>)p_),
                EvaluationMessage = new List<ResourceReference>((IEnumerable<ResourceReference>)q_),
                OutputParameters = r_,
                Result = s_,
                DataRequirement = new List<DataRequirement>((IEnumerable<DataRequirement>)t_),
            };
            return u_;
        }

        IEnumerable<GuidanceResponse> c_ = context.Operators.Select<GuidanceResponse, GuidanceResponse>((IEnumerable<GuidanceResponse>)a_, b_);
        IEnumerable<GuidanceResponse> d_ = context.Operators.Distinct<GuidanceResponse>(c_);
        GuidanceResponse e_ = context.Operators.SingletonFrom<GuidanceResponse>(d_);
        return e_;
    }


    [CqlFunctionDefinition("HealthcareServiceResource")]
    public HealthcareService HealthcareServiceResource(CqlContext context, HealthcareService arg)
    {
        HealthcareService[] a_ = [
            arg,
        ];

        HealthcareService b_(HealthcareService a) {
            List<Identifier> f_ = a?.Identifier;
            FhirBoolean g_ = a?.ActiveElement;
            ResourceReference h_ = a?.ProvidedBy;
            List<CodeableConcept> i_ = a?.Category;
            List<CodeableConcept> j_ = a?.Type;
            List<CodeableConcept> k_ = a?.Specialty;
            List<ResourceReference> l_ = a?.Location;
            FhirString m_ = a?.NameElement;
            FhirString n_ = a?.CommentElement;
            Markdown o_ = a?.ExtraDetailsElement;
            Attachment p_ = a?.Photo;
            List<ContactPoint> q_ = a?.Telecom;
            List<ResourceReference> r_ = a?.CoverageArea;
            List<CodeableConcept> s_ = a?.ServiceProvisionCode;
            List<HealthcareService.EligibilityComponent> t_ = a?.Eligibility;
            List<CodeableConcept> u_ = a?.Program;
            List<CodeableConcept> v_ = a?.Characteristic;
            List<CodeableConcept> w_ = a?.Communication;
            List<CodeableConcept> x_ = a?.ReferralMethod;
            FhirBoolean y_ = a?.AppointmentRequiredElement;
            List<HealthcareService.AvailableTimeComponent> z_ = a?.AvailableTime;
            List<HealthcareService.NotAvailableComponent> aa_ = a?.NotAvailable;
            FhirString ab_ = a?.AvailabilityExceptionsElement;
            List<ResourceReference> ac_ = a?.Endpoint;
            HealthcareService ad_ = new HealthcareService
            {
                Identifier = new List<Identifier>((IEnumerable<Identifier>)f_),
                ActiveElement = g_,
                ProvidedBy = h_,
                Category = new List<CodeableConcept>((IEnumerable<CodeableConcept>)i_),
                Type = new List<CodeableConcept>((IEnumerable<CodeableConcept>)j_),
                Specialty = new List<CodeableConcept>((IEnumerable<CodeableConcept>)k_),
                Location = new List<ResourceReference>((IEnumerable<ResourceReference>)l_),
                NameElement = m_,
                CommentElement = n_,
                ExtraDetailsElement = o_,
                Photo = p_,
                Telecom = new List<ContactPoint>((IEnumerable<ContactPoint>)q_),
                CoverageArea = new List<ResourceReference>((IEnumerable<ResourceReference>)r_),
                ServiceProvisionCode = new List<CodeableConcept>((IEnumerable<CodeableConcept>)s_),
                Eligibility = new List<HealthcareService.EligibilityComponent>((IEnumerable<HealthcareService.EligibilityComponent>)t_),
                Program = new List<CodeableConcept>((IEnumerable<CodeableConcept>)u_),
                Characteristic = new List<CodeableConcept>((IEnumerable<CodeableConcept>)v_),
                Communication = new List<CodeableConcept>((IEnumerable<CodeableConcept>)w_),
                ReferralMethod = new List<CodeableConcept>((IEnumerable<CodeableConcept>)x_),
                AppointmentRequiredElement = y_,
                AvailableTime = new List<HealthcareService.AvailableTimeComponent>((IEnumerable<HealthcareService.AvailableTimeComponent>)z_),
                NotAvailable = new List<HealthcareService.NotAvailableComponent>((IEnumerable<HealthcareService.NotAvailableComponent>)aa_),
                AvailabilityExceptionsElement = ab_,
                Endpoint = new List<ResourceReference>((IEnumerable<ResourceReference>)ac_),
            };
            return ad_;
        }

        IEnumerable<HealthcareService> c_ = context.Operators.Select<HealthcareService, HealthcareService>((IEnumerable<HealthcareService>)a_, b_);
        IEnumerable<HealthcareService> d_ = context.Operators.Distinct<HealthcareService>(c_);
        HealthcareService e_ = context.Operators.SingletonFrom<HealthcareService>(d_);
        return e_;
    }


    [CqlFunctionDefinition("ImagingStudyResource")]
    public ImagingStudy ImagingStudyResource(CqlContext context, ImagingStudy arg)
    {
        ImagingStudy[] a_ = [
            arg,
        ];

        ImagingStudy b_(ImagingStudy a) {
            List<Identifier> f_ = a?.Identifier;
            Code<ImagingStudy.ImagingStudyStatus> g_ = a?.StatusElement;
            List<Coding> h_ = a?.Modality;
            ResourceReference i_ = a?.Subject;
            ResourceReference j_ = a?.Encounter;
            FhirDateTime k_ = a?.StartedElement;
            List<ResourceReference> l_ = a?.BasedOn;
            ResourceReference m_ = a?.Referrer;
            List<ResourceReference> n_ = a?.Interpreter;
            List<ResourceReference> o_ = a?.Endpoint;
            UnsignedInt p_ = a?.NumberOfSeriesElement;
            Integer q_ = context.Operators.Convert<Integer>(p_);
            UnsignedInt r_ = context.Operators.Convert<UnsignedInt>(q_);
            UnsignedInt s_ = a?.NumberOfInstancesElement;
            Integer t_ = context.Operators.Convert<Integer>(s_);
            UnsignedInt u_ = context.Operators.Convert<UnsignedInt>(t_);
            ResourceReference v_ = a?.ProcedureReference;
            List<CodeableConcept> w_ = a?.ProcedureCode;
            ResourceReference x_ = a?.Location;
            List<CodeableConcept> y_ = a?.ReasonCode;
            List<ResourceReference> z_ = a?.ReasonReference;
            List<Annotation> aa_ = a?.Note;
            FhirString ab_ = a?.DescriptionElement;
            List<ImagingStudy.SeriesComponent> ac_ = a?.Series;
            ImagingStudy ad_ = new ImagingStudy
            {
                Identifier = new List<Identifier>((IEnumerable<Identifier>)f_),
                StatusElement = g_,
                Modality = new List<Coding>((IEnumerable<Coding>)h_),
                Subject = i_,
                Encounter = j_,
                StartedElement = k_,
                BasedOn = new List<ResourceReference>((IEnumerable<ResourceReference>)l_),
                Referrer = m_,
                Interpreter = new List<ResourceReference>((IEnumerable<ResourceReference>)n_),
                Endpoint = new List<ResourceReference>((IEnumerable<ResourceReference>)o_),
                NumberOfSeriesElement = r_,
                NumberOfInstancesElement = u_,
                ProcedureReference = v_,
                ProcedureCode = new List<CodeableConcept>((IEnumerable<CodeableConcept>)w_),
                Location = x_,
                ReasonCode = new List<CodeableConcept>((IEnumerable<CodeableConcept>)y_),
                ReasonReference = new List<ResourceReference>((IEnumerable<ResourceReference>)z_),
                Note = new List<Annotation>((IEnumerable<Annotation>)aa_),
                DescriptionElement = ab_,
                Series = new List<ImagingStudy.SeriesComponent>((IEnumerable<ImagingStudy.SeriesComponent>)ac_),
            };
            return ad_;
        }

        IEnumerable<ImagingStudy> c_ = context.Operators.Select<ImagingStudy, ImagingStudy>((IEnumerable<ImagingStudy>)a_, b_);
        IEnumerable<ImagingStudy> d_ = context.Operators.Distinct<ImagingStudy>(c_);
        ImagingStudy e_ = context.Operators.SingletonFrom<ImagingStudy>(d_);
        return e_;
    }


    [CqlFunctionDefinition("ImmunizationResource")]
    public Immunization ImmunizationResource(CqlContext context, Immunization arg)
    {
        Immunization[] a_ = [
            arg,
        ];

        Immunization b_(Immunization a) {
            List<Identifier> f_ = a?.Identifier;
            Code<Immunization.ImmunizationStatusCodes> g_ = a?.StatusElement;
            CodeableConcept h_ = a?.StatusReason;
            CodeableConcept i_ = a?.VaccineCode;
            ResourceReference j_ = a?.Patient;
            ResourceReference k_ = a?.Encounter;
            DataType l_ = a?.Occurrence;
            FhirDateTime m_ = a?.RecordedElement;
            FhirBoolean n_ = a?.PrimarySourceElement;
            CodeableConcept o_ = a?.ReportOrigin;
            ResourceReference p_ = a?.Location;
            ResourceReference q_ = a?.Manufacturer;
            FhirString r_ = a?.LotNumberElement;
            Date s_ = a?.ExpirationDateElement;
            CodeableConcept t_ = a?.Site;
            CodeableConcept u_ = a?.Route;
            Quantity v_ = a?.DoseQuantity;
            List<Immunization.PerformerComponent> w_ = a?.Performer;
            List<Annotation> x_ = a?.Note;
            List<CodeableConcept> y_ = a?.ReasonCode;
            List<ResourceReference> z_ = a?.ReasonReference;
            FhirBoolean aa_ = a?.IsSubpotentElement;
            List<CodeableConcept> ab_ = a?.SubpotentReason;
            List<Immunization.EducationComponent> ac_ = a?.Education;
            List<CodeableConcept> ad_ = a?.ProgramEligibility;
            CodeableConcept ae_ = a?.FundingSource;
            List<Immunization.ReactionComponent> af_ = a?.Reaction;
            List<Immunization.ProtocolAppliedComponent> ag_ = a?.ProtocolApplied;
            Immunization ah_ = new Immunization
            {
                Identifier = new List<Identifier>((IEnumerable<Identifier>)f_),
                StatusElement = g_,
                StatusReason = h_,
                VaccineCode = i_,
                Patient = j_,
                Encounter = k_,
                Occurrence = (DataType)l_,
                RecordedElement = m_,
                PrimarySourceElement = n_,
                ReportOrigin = o_,
                Location = p_,
                Manufacturer = q_,
                LotNumberElement = r_,
                ExpirationDateElement = s_,
                Site = t_,
                Route = u_,
                DoseQuantity = v_,
                Performer = new List<Immunization.PerformerComponent>((IEnumerable<Immunization.PerformerComponent>)w_),
                Note = new List<Annotation>((IEnumerable<Annotation>)x_),
                ReasonCode = new List<CodeableConcept>((IEnumerable<CodeableConcept>)y_),
                ReasonReference = new List<ResourceReference>((IEnumerable<ResourceReference>)z_),
                IsSubpotentElement = aa_,
                SubpotentReason = new List<CodeableConcept>((IEnumerable<CodeableConcept>)ab_),
                Education = new List<Immunization.EducationComponent>((IEnumerable<Immunization.EducationComponent>)ac_),
                ProgramEligibility = new List<CodeableConcept>((IEnumerable<CodeableConcept>)ad_),
                FundingSource = ae_,
                Reaction = new List<Immunization.ReactionComponent>((IEnumerable<Immunization.ReactionComponent>)af_),
                ProtocolApplied = new List<Immunization.ProtocolAppliedComponent>((IEnumerable<Immunization.ProtocolAppliedComponent>)ag_),
            };
            return ah_;
        }

        IEnumerable<Immunization> c_ = context.Operators.Select<Immunization, Immunization>((IEnumerable<Immunization>)a_, b_);
        IEnumerable<Immunization> d_ = context.Operators.Distinct<Immunization>(c_);
        Immunization e_ = context.Operators.SingletonFrom<Immunization>(d_);
        return e_;
    }


    [CqlFunctionDefinition("ImmunizationEvaluationResource")]
    public ImmunizationEvaluation ImmunizationEvaluationResource(CqlContext context, ImmunizationEvaluation arg)
    {
        ImmunizationEvaluation[] a_ = [
            arg,
        ];

        ImmunizationEvaluation b_(ImmunizationEvaluation a) {
            List<Identifier> f_ = a?.Identifier;
            Code<ImmunizationEvaluation.ImmunizationEvaluationStatusCodes> g_ = a?.StatusElement;
            ResourceReference h_ = a?.Patient;
            FhirDateTime i_ = a?.DateElement;
            ResourceReference j_ = a?.Authority;
            CodeableConcept k_ = a?.TargetDisease;
            ResourceReference l_ = a?.ImmunizationEvent;
            CodeableConcept m_ = a?.DoseStatus;
            List<CodeableConcept> n_ = a?.DoseStatusReason;
            FhirString o_ = a?.DescriptionElement;
            FhirString p_ = a?.SeriesElement;
            DataType q_ = a?.DoseNumber;
            DataType r_ = a?.SeriesDoses;
            ImmunizationEvaluation s_ = new ImmunizationEvaluation
            {
                Identifier = new List<Identifier>((IEnumerable<Identifier>)f_),
                StatusElement = g_,
                Patient = h_,
                DateElement = i_,
                Authority = j_,
                TargetDisease = k_,
                ImmunizationEvent = l_,
                DoseStatus = m_,
                DoseStatusReason = new List<CodeableConcept>((IEnumerable<CodeableConcept>)n_),
                DescriptionElement = o_,
                SeriesElement = p_,
                DoseNumber = (DataType)q_,
                SeriesDoses = (DataType)r_,
            };
            return s_;
        }

        IEnumerable<ImmunizationEvaluation> c_ = context.Operators.Select<ImmunizationEvaluation, ImmunizationEvaluation>((IEnumerable<ImmunizationEvaluation>)a_, b_);
        IEnumerable<ImmunizationEvaluation> d_ = context.Operators.Distinct<ImmunizationEvaluation>(c_);
        ImmunizationEvaluation e_ = context.Operators.SingletonFrom<ImmunizationEvaluation>(d_);
        return e_;
    }


    [CqlFunctionDefinition("ImmunizationRecommendationResource")]
    public ImmunizationRecommendation ImmunizationRecommendationResource(CqlContext context, ImmunizationRecommendation arg)
    {
        ImmunizationRecommendation[] a_ = [
            arg,
        ];

        ImmunizationRecommendation b_(ImmunizationRecommendation a) {
            List<Identifier> f_ = a?.Identifier;
            ResourceReference g_ = a?.Patient;
            FhirDateTime h_ = a?.DateElement;
            ResourceReference i_ = a?.Authority;
            List<ImmunizationRecommendation.RecommendationComponent> j_ = a?.Recommendation;
            ImmunizationRecommendation k_ = new ImmunizationRecommendation
            {
                Identifier = new List<Identifier>((IEnumerable<Identifier>)f_),
                Patient = g_,
                DateElement = h_,
                Authority = i_,
                Recommendation = new List<ImmunizationRecommendation.RecommendationComponent>((IEnumerable<ImmunizationRecommendation.RecommendationComponent>)j_),
            };
            return k_;
        }

        IEnumerable<ImmunizationRecommendation> c_ = context.Operators.Select<ImmunizationRecommendation, ImmunizationRecommendation>((IEnumerable<ImmunizationRecommendation>)a_, b_);
        IEnumerable<ImmunizationRecommendation> d_ = context.Operators.Distinct<ImmunizationRecommendation>(c_);
        ImmunizationRecommendation e_ = context.Operators.SingletonFrom<ImmunizationRecommendation>(d_);
        return e_;
    }


    [CqlFunctionDefinition("InsurancePlanResource")]
    public InsurancePlan InsurancePlanResource(CqlContext context, InsurancePlan arg)
    {
        InsurancePlan[] a_ = [
            arg,
        ];

        InsurancePlan b_(InsurancePlan a) {
            List<Identifier> f_ = a?.Identifier;
            Code<PublicationStatus> g_ = a?.StatusElement;
            List<CodeableConcept> h_ = a?.Type;
            FhirString i_ = a?.NameElement;
            List<FhirString> j_ = a?.AliasElement;
            Period k_ = a?.Period;
            ResourceReference l_ = a?.OwnedBy;
            ResourceReference m_ = a?.AdministeredBy;
            List<ResourceReference> n_ = a?.CoverageArea;
            List<InsurancePlan.ContactComponent> o_ = a?.Contact;
            List<ResourceReference> p_ = a?.Endpoint;
            List<ResourceReference> q_ = a?.Network;
            List<InsurancePlan.CoverageComponent> r_ = a?.Coverage;
            List<InsurancePlan.PlanComponent> s_ = a?.Plan;
            InsurancePlan t_ = new InsurancePlan
            {
                Identifier = new List<Identifier>((IEnumerable<Identifier>)f_),
                StatusElement = g_,
                Type = new List<CodeableConcept>((IEnumerable<CodeableConcept>)h_),
                NameElement = i_,
                AliasElement = new List<FhirString>((IEnumerable<FhirString>)j_),
                Period = k_,
                OwnedBy = l_,
                AdministeredBy = m_,
                CoverageArea = new List<ResourceReference>((IEnumerable<ResourceReference>)n_),
                Contact = new List<InsurancePlan.ContactComponent>((IEnumerable<InsurancePlan.ContactComponent>)o_),
                Endpoint = new List<ResourceReference>((IEnumerable<ResourceReference>)p_),
                Network = new List<ResourceReference>((IEnumerable<ResourceReference>)q_),
                Coverage = new List<InsurancePlan.CoverageComponent>((IEnumerable<InsurancePlan.CoverageComponent>)r_),
                Plan = new List<InsurancePlan.PlanComponent>((IEnumerable<InsurancePlan.PlanComponent>)s_),
            };
            return t_;
        }

        IEnumerable<InsurancePlan> c_ = context.Operators.Select<InsurancePlan, InsurancePlan>((IEnumerable<InsurancePlan>)a_, b_);
        IEnumerable<InsurancePlan> d_ = context.Operators.Distinct<InsurancePlan>(c_);
        InsurancePlan e_ = context.Operators.SingletonFrom<InsurancePlan>(d_);
        return e_;
    }


    [CqlFunctionDefinition("InvoiceResource")]
    public Invoice InvoiceResource(CqlContext context, Invoice arg)
    {
        Invoice[] a_ = [
            arg,
        ];

        Invoice b_(Invoice a) {
            List<Identifier> f_ = a?.Identifier;
            Code<Invoice.InvoiceStatus> g_ = a?.StatusElement;
            FhirString h_ = a?.CancelledReasonElement;
            CodeableConcept i_ = a?.Type;
            ResourceReference j_ = a?.Subject;
            ResourceReference k_ = a?.Recipient;
            FhirDateTime l_ = a?.DateElement;
            List<Invoice.ParticipantComponent> m_ = a?.Participant;
            ResourceReference n_ = a?.Issuer;
            ResourceReference o_ = a?.Account;
            List<Invoice.LineItemComponent> p_ = a?.LineItem;
            List<Invoice.PriceComponentComponent> q_ = a?.TotalPriceComponent;
            Money r_ = a?.TotalNet;
            Money s_ = a?.TotalGross;
            Markdown t_ = a?.PaymentTermsElement;
            List<Annotation> u_ = a?.Note;
            Invoice v_ = new Invoice
            {
                Identifier = new List<Identifier>((IEnumerable<Identifier>)f_),
                StatusElement = g_,
                CancelledReasonElement = h_,
                Type = i_,
                Subject = j_,
                Recipient = k_,
                DateElement = l_,
                Participant = new List<Invoice.ParticipantComponent>((IEnumerable<Invoice.ParticipantComponent>)m_),
                Issuer = n_,
                Account = o_,
                LineItem = new List<Invoice.LineItemComponent>((IEnumerable<Invoice.LineItemComponent>)p_),
                TotalPriceComponent = new List<Invoice.PriceComponentComponent>((IEnumerable<Invoice.PriceComponentComponent>)q_),
                TotalNet = r_,
                TotalGross = s_,
                PaymentTermsElement = t_,
                Note = new List<Annotation>((IEnumerable<Annotation>)u_),
            };
            return v_;
        }

        IEnumerable<Invoice> c_ = context.Operators.Select<Invoice, Invoice>((IEnumerable<Invoice>)a_, b_);
        IEnumerable<Invoice> d_ = context.Operators.Distinct<Invoice>(c_);
        Invoice e_ = context.Operators.SingletonFrom<Invoice>(d_);
        return e_;
    }


    [CqlFunctionDefinition("LibraryResource")]
    public Library LibraryResource(CqlContext context, Library arg)
    {
        Library[] a_ = [
            arg,
        ];

        Library b_(Library a) {
            FhirUri f_ = a?.UrlElement;
            List<Identifier> g_ = a?.Identifier;
            FhirString h_ = a?.VersionElement;
            FhirString i_ = a?.NameElement;
            FhirString j_ = a?.TitleElement;
            FhirString k_ = a?.SubtitleElement;
            Code<PublicationStatus> l_ = a?.StatusElement;
            FhirBoolean m_ = a?.ExperimentalElement;
            CodeableConcept n_ = a?.Type;
            DataType o_ = a?.Subject;
            FhirDateTime p_ = a?.DateElement;
            FhirString q_ = a?.PublisherElement;
            List<ContactDetail> r_ = a?.Contact;
            Markdown s_ = a?.DescriptionElement;
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
            List<ParameterDefinition> ah_ = a?.Parameter;
            List<DataRequirement> ai_ = a?.DataRequirement;
            List<Attachment> aj_ = a?.Content;
            Library ak_ = new Library
            {
                UrlElement = f_,
                Identifier = new List<Identifier>((IEnumerable<Identifier>)g_),
                VersionElement = h_,
                NameElement = i_,
                TitleElement = j_,
                SubtitleElement = k_,
                StatusElement = l_,
                ExperimentalElement = m_,
                Type = n_,
                Subject = (DataType)o_,
                DateElement = p_,
                PublisherElement = q_,
                Contact = new List<ContactDetail>((IEnumerable<ContactDetail>)r_),
                DescriptionElement = s_,
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
                Parameter = new List<ParameterDefinition>((IEnumerable<ParameterDefinition>)ah_),
                DataRequirement = new List<DataRequirement>((IEnumerable<DataRequirement>)ai_),
                Content = new List<Attachment>((IEnumerable<Attachment>)aj_),
            };
            return ak_;
        }

        IEnumerable<Library> c_ = context.Operators.Select<Library, Library>((IEnumerable<Library>)a_, b_);
        IEnumerable<Library> d_ = context.Operators.Distinct<Library>(c_);
        Library e_ = context.Operators.SingletonFrom<Library>(d_);
        return e_;
    }


    [CqlFunctionDefinition("LinkageResource")]
    public Linkage LinkageResource(CqlContext context, Linkage arg)
    {
        Linkage[] a_ = [
            arg,
        ];

        Linkage b_(Linkage a) {
            FhirBoolean f_ = a?.ActiveElement;
            ResourceReference g_ = a?.Author;
            List<Linkage.ItemComponent> h_ = a?.Item;
            Linkage i_ = new Linkage
            {
                ActiveElement = f_,
                Author = g_,
                Item = new List<Linkage.ItemComponent>((IEnumerable<Linkage.ItemComponent>)h_),
            };
            return i_;
        }

        IEnumerable<Linkage> c_ = context.Operators.Select<Linkage, Linkage>((IEnumerable<Linkage>)a_, b_);
        IEnumerable<Linkage> d_ = context.Operators.Distinct<Linkage>(c_);
        Linkage e_ = context.Operators.SingletonFrom<Linkage>(d_);
        return e_;
    }


    [CqlFunctionDefinition("LocationResource")]
    public Location LocationResource(CqlContext context, Location arg)
    {
        Location[] a_ = [
            arg,
        ];

        Location b_(Location a) {
            List<Identifier> f_ = a?.Identifier;
            Code<Location.LocationStatus> g_ = a?.StatusElement;
            Coding h_ = a?.OperationalStatus;
            FhirString i_ = a?.NameElement;
            List<FhirString> j_ = a?.AliasElement;
            FhirString k_ = a?.DescriptionElement;
            Code<Location.LocationMode> l_ = a?.ModeElement;
            List<CodeableConcept> m_ = a?.Type;
            List<ContactPoint> n_ = a?.Telecom;
            Address o_ = a?.Address;
            CodeableConcept p_ = a?.PhysicalType;
            Location.PositionComponent q_ = a?.Position;
            ResourceReference r_ = a?.ManagingOrganization;
            ResourceReference s_ = a?.PartOf;
            List<Location.HoursOfOperationComponent> t_ = a?.HoursOfOperation;
            FhirString u_ = a?.AvailabilityExceptionsElement;
            List<ResourceReference> v_ = a?.Endpoint;
            Location w_ = new Location
            {
                Identifier = new List<Identifier>((IEnumerable<Identifier>)f_),
                StatusElement = g_,
                OperationalStatus = h_,
                NameElement = i_,
                AliasElement = new List<FhirString>((IEnumerable<FhirString>)j_),
                DescriptionElement = k_,
                ModeElement = l_,
                Type = new List<CodeableConcept>((IEnumerable<CodeableConcept>)m_),
                Telecom = new List<ContactPoint>((IEnumerable<ContactPoint>)n_),
                Address = o_,
                PhysicalType = p_,
                Position = q_,
                ManagingOrganization = r_,
                PartOf = s_,
                HoursOfOperation = new List<Location.HoursOfOperationComponent>((IEnumerable<Location.HoursOfOperationComponent>)t_),
                AvailabilityExceptionsElement = u_,
                Endpoint = new List<ResourceReference>((IEnumerable<ResourceReference>)v_),
            };
            return w_;
        }

        IEnumerable<Location> c_ = context.Operators.Select<Location, Location>((IEnumerable<Location>)a_, b_);
        IEnumerable<Location> d_ = context.Operators.Distinct<Location>(c_);
        Location e_ = context.Operators.SingletonFrom<Location>(d_);
        return e_;
    }


    [CqlFunctionDefinition("MeasureResource")]
    public Measure MeasureResource(CqlContext context, Measure arg)
    {
        Measure[] a_ = [
            arg,
        ];

        Measure b_(Measure a) {
            FhirUri f_ = a?.UrlElement;
            List<Identifier> g_ = a?.Identifier;
            FhirString h_ = a?.VersionElement;
            FhirString i_ = a?.NameElement;
            FhirString j_ = a?.TitleElement;
            FhirString k_ = a?.SubtitleElement;
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
            Markdown ah_ = a?.DisclaimerElement;
            CodeableConcept ai_ = a?.Scoring;
            CodeableConcept aj_ = a?.CompositeScoring;
            List<CodeableConcept> ak_ = a?.Type;
            FhirString al_ = a?.RiskAdjustmentElement;
            FhirString am_ = a?.RateAggregationElement;
            Markdown an_ = a?.RationaleElement;
            Markdown ao_ = a?.ClinicalRecommendationStatementElement;
            CodeableConcept ap_ = a?.ImprovementNotation;
            List<Markdown> aq_ = a?.DefinitionElement;
            Markdown ar_ = a?.GuidanceElement;
            List<Measure.GroupComponent> as_ = a?.Group;
            List<Measure.SupplementalDataComponent> at_ = a?.SupplementalData;
            Measure au_ = new Measure
            {
                UrlElement = f_,
                Identifier = new List<Identifier>((IEnumerable<Identifier>)g_),
                VersionElement = h_,
                NameElement = i_,
                TitleElement = j_,
                SubtitleElement = k_,
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
                DisclaimerElement = ah_,
                Scoring = ai_,
                CompositeScoring = aj_,
                Type = new List<CodeableConcept>((IEnumerable<CodeableConcept>)ak_),
                RiskAdjustmentElement = al_,
                RateAggregationElement = am_,
                RationaleElement = an_,
                ClinicalRecommendationStatementElement = ao_,
                ImprovementNotation = ap_,
                DefinitionElement = new List<Markdown>((IEnumerable<Markdown>)aq_),
                GuidanceElement = ar_,
                Group = new List<Measure.GroupComponent>((IEnumerable<Measure.GroupComponent>)as_),
                SupplementalData = new List<Measure.SupplementalDataComponent>((IEnumerable<Measure.SupplementalDataComponent>)at_),
            };
            return au_;
        }

        IEnumerable<Measure> c_ = context.Operators.Select<Measure, Measure>((IEnumerable<Measure>)a_, b_);
        IEnumerable<Measure> d_ = context.Operators.Distinct<Measure>(c_);
        Measure e_ = context.Operators.SingletonFrom<Measure>(d_);
        return e_;
    }


    [CqlFunctionDefinition("MeasureReportResource")]
    public MeasureReport MeasureReportResource(CqlContext context, MeasureReport arg)
    {
        MeasureReport[] a_ = [
            arg,
        ];

        MeasureReport b_(MeasureReport a) {
            List<Identifier> f_ = a?.Identifier;
            Code<MeasureReport.MeasureReportStatus> g_ = a?.StatusElement;
            Code<MeasureReport.MeasureReportType> h_ = a?.TypeElement;
            Canonical i_ = a?.MeasureElement;
            ResourceReference j_ = a?.Subject;
            FhirDateTime k_ = a?.DateElement;
            ResourceReference l_ = a?.Reporter;
            Period m_ = a?.Period;
            CodeableConcept n_ = a?.ImprovementNotation;
            List<MeasureReport.GroupComponent> o_ = a?.Group;
            List<ResourceReference> p_ = a?.EvaluatedResource;
            MeasureReport q_ = new MeasureReport
            {
                Identifier = new List<Identifier>((IEnumerable<Identifier>)f_),
                StatusElement = g_,
                TypeElement = h_,
                MeasureElement = i_,
                Subject = j_,
                DateElement = k_,
                Reporter = l_,
                Period = m_,
                ImprovementNotation = n_,
                Group = new List<MeasureReport.GroupComponent>((IEnumerable<MeasureReport.GroupComponent>)o_),
                EvaluatedResource = new List<ResourceReference>((IEnumerable<ResourceReference>)p_),
            };
            return q_;
        }

        IEnumerable<MeasureReport> c_ = context.Operators.Select<MeasureReport, MeasureReport>((IEnumerable<MeasureReport>)a_, b_);
        IEnumerable<MeasureReport> d_ = context.Operators.Distinct<MeasureReport>(c_);
        MeasureReport e_ = context.Operators.SingletonFrom<MeasureReport>(d_);
        return e_;
    }


    [CqlFunctionDefinition("MedicationResource")]
    public Medication MedicationResource(CqlContext context, Medication arg)
    {
        Medication[] a_ = [
            arg,
        ];

        Medication b_(Medication a) {
            List<Identifier> f_ = a?.Identifier;
            CodeableConcept g_ = a?.Code;
            Code<Medication.MedicationStatusCodes> h_ = a?.StatusElement;
            ResourceReference i_ = a?.Manufacturer;
            CodeableConcept j_ = a?.Form;
            Ratio k_ = a?.Amount;
            List<Medication.IngredientComponent> l_ = a?.Ingredient;
            Medication.BatchComponent m_ = a?.Batch;
            Medication n_ = new Medication
            {
                Identifier = new List<Identifier>((IEnumerable<Identifier>)f_),
                Code = g_,
                StatusElement = h_,
                Manufacturer = i_,
                Form = j_,
                Amount = k_,
                Ingredient = new List<Medication.IngredientComponent>((IEnumerable<Medication.IngredientComponent>)l_),
                Batch = m_,
            };
            return n_;
        }

        IEnumerable<Medication> c_ = context.Operators.Select<Medication, Medication>((IEnumerable<Medication>)a_, b_);
        IEnumerable<Medication> d_ = context.Operators.Distinct<Medication>(c_);
        Medication e_ = context.Operators.SingletonFrom<Medication>(d_);
        return e_;
    }


    [CqlFunctionDefinition("MedicationAdministrationResource")]
    public MedicationAdministration MedicationAdministrationResource(CqlContext context, MedicationAdministration arg)
    {
        MedicationAdministration[] a_ = [
            arg,
        ];

        MedicationAdministration b_(MedicationAdministration a) {
            List<Identifier> f_ = a?.Identifier;
            List<FhirUri> g_ = a?.InstantiatesElement;
            List<ResourceReference> h_ = a?.PartOf;
            Code<MedicationAdministration.MedicationAdministrationStatusCodes> i_ = a?.StatusElement;
            List<CodeableConcept> j_ = a?.StatusReason;
            CodeableConcept k_ = a?.Category;
            DataType l_ = a?.Medication;
            ResourceReference m_ = a?.Subject;
            ResourceReference n_ = a?.Context;
            List<ResourceReference> o_ = a?.SupportingInformation;
            DataType p_ = a?.Effective;
            List<MedicationAdministration.PerformerComponent> q_ = a?.Performer;
            List<CodeableConcept> r_ = a?.ReasonCode;
            List<ResourceReference> s_ = a?.ReasonReference;
            ResourceReference t_ = a?.Request;
            List<ResourceReference> u_ = a?.Device;
            List<Annotation> v_ = a?.Note;
            MedicationAdministration.DosageComponent w_ = a?.Dosage;
            List<ResourceReference> x_ = a?.EventHistory;
            MedicationAdministration y_ = new MedicationAdministration
            {
                Identifier = new List<Identifier>((IEnumerable<Identifier>)f_),
                InstantiatesElement = new List<FhirUri>((IEnumerable<FhirUri>)g_),
                PartOf = new List<ResourceReference>((IEnumerable<ResourceReference>)h_),
                StatusElement = i_,
                StatusReason = new List<CodeableConcept>((IEnumerable<CodeableConcept>)j_),
                Category = k_,
                Medication = (DataType)l_,
                Subject = m_,
                Context = n_,
                SupportingInformation = new List<ResourceReference>((IEnumerable<ResourceReference>)o_),
                Effective = (DataType)p_,
                Performer = new List<MedicationAdministration.PerformerComponent>((IEnumerable<MedicationAdministration.PerformerComponent>)q_),
                ReasonCode = new List<CodeableConcept>((IEnumerable<CodeableConcept>)r_),
                ReasonReference = new List<ResourceReference>((IEnumerable<ResourceReference>)s_),
                Request = t_,
                Device = new List<ResourceReference>((IEnumerable<ResourceReference>)u_),
                Note = new List<Annotation>((IEnumerable<Annotation>)v_),
                Dosage = w_,
                EventHistory = new List<ResourceReference>((IEnumerable<ResourceReference>)x_),
            };
            return y_;
        }

        IEnumerable<MedicationAdministration> c_ = context.Operators.Select<MedicationAdministration, MedicationAdministration>((IEnumerable<MedicationAdministration>)a_, b_);
        IEnumerable<MedicationAdministration> d_ = context.Operators.Distinct<MedicationAdministration>(c_);
        MedicationAdministration e_ = context.Operators.SingletonFrom<MedicationAdministration>(d_);
        return e_;
    }


    [CqlFunctionDefinition("MedicationDispenseResource")]
    public MedicationDispense MedicationDispenseResource(CqlContext context, MedicationDispense arg)
    {
        MedicationDispense[] a_ = [
            arg,
        ];

        MedicationDispense b_(MedicationDispense a) {
            List<Identifier> f_ = a?.Identifier;
            List<ResourceReference> g_ = a?.PartOf;
            Code<MedicationDispense.MedicationDispenseStatusCodes> h_ = a?.StatusElement;
            DataType i_ = a?.StatusReason;
            CodeableConcept j_ = a?.Category;
            DataType k_ = a?.Medication;
            ResourceReference l_ = a?.Subject;
            ResourceReference m_ = a?.Context;
            List<ResourceReference> n_ = a?.SupportingInformation;
            List<MedicationDispense.PerformerComponent> o_ = a?.Performer;
            ResourceReference p_ = a?.Location;
            List<ResourceReference> q_ = a?.AuthorizingPrescription;
            CodeableConcept r_ = a?.Type;
            Quantity s_ = a?.Quantity;
            Quantity t_ = a?.DaysSupply;
            FhirDateTime u_ = a?.WhenPreparedElement;
            FhirDateTime v_ = a?.WhenHandedOverElement;
            ResourceReference w_ = a?.Destination;
            List<ResourceReference> x_ = a?.Receiver;
            List<Annotation> y_ = a?.Note;
            List<Dosage> z_ = a?.DosageInstruction;
            MedicationDispense.SubstitutionComponent aa_ = a?.Substitution;
            List<ResourceReference> ab_ = a?.DetectedIssue;
            List<ResourceReference> ac_ = a?.EventHistory;
            MedicationDispense ad_ = new MedicationDispense
            {
                Identifier = new List<Identifier>((IEnumerable<Identifier>)f_),
                PartOf = new List<ResourceReference>((IEnumerable<ResourceReference>)g_),
                StatusElement = h_,
                StatusReason = (DataType)i_,
                Category = j_,
                Medication = (DataType)k_,
                Subject = l_,
                Context = m_,
                SupportingInformation = new List<ResourceReference>((IEnumerable<ResourceReference>)n_),
                Performer = new List<MedicationDispense.PerformerComponent>((IEnumerable<MedicationDispense.PerformerComponent>)o_),
                Location = p_,
                AuthorizingPrescription = new List<ResourceReference>((IEnumerable<ResourceReference>)q_),
                Type = r_,
                Quantity = s_,
                DaysSupply = t_,
                WhenPreparedElement = u_,
                WhenHandedOverElement = v_,
                Destination = w_,
                Receiver = new List<ResourceReference>((IEnumerable<ResourceReference>)x_),
                Note = new List<Annotation>((IEnumerable<Annotation>)y_),
                DosageInstruction = new List<Dosage>((IEnumerable<Dosage>)z_),
                Substitution = aa_,
                DetectedIssue = new List<ResourceReference>((IEnumerable<ResourceReference>)ab_),
                EventHistory = new List<ResourceReference>((IEnumerable<ResourceReference>)ac_),
            };
            return ad_;
        }

        IEnumerable<MedicationDispense> c_ = context.Operators.Select<MedicationDispense, MedicationDispense>((IEnumerable<MedicationDispense>)a_, b_);
        IEnumerable<MedicationDispense> d_ = context.Operators.Distinct<MedicationDispense>(c_);
        MedicationDispense e_ = context.Operators.SingletonFrom<MedicationDispense>(d_);
        return e_;
    }


    [CqlFunctionDefinition("MedicationKnowledgeResource")]
    public MedicationKnowledge MedicationKnowledgeResource(CqlContext context, MedicationKnowledge arg)
    {
        MedicationKnowledge[] a_ = [
            arg,
        ];

        MedicationKnowledge b_(MedicationKnowledge a) {
            CodeableConcept f_ = a?.Code;
            Code<MedicationKnowledge.MedicationKnowledgeStatusCodes> g_ = a?.StatusElement;
            ResourceReference h_ = a?.Manufacturer;
            CodeableConcept i_ = a?.DoseForm;
            Quantity j_ = a?.Amount;
            List<FhirString> k_ = a?.SynonymElement;
            List<MedicationKnowledge.RelatedMedicationKnowledgeComponent> l_ = a?.RelatedMedicationKnowledge;
            List<ResourceReference> m_ = a?.AssociatedMedication;
            List<CodeableConcept> n_ = a?.ProductType;
            List<MedicationKnowledge.MonographComponent> o_ = a?.Monograph;
            List<MedicationKnowledge.IngredientComponent> p_ = a?.Ingredient;
            Markdown q_ = a?.PreparationInstructionElement;
            List<CodeableConcept> r_ = a?.IntendedRoute;
            List<MedicationKnowledge.CostComponent> s_ = a?.Cost;
            List<MedicationKnowledge.MonitoringProgramComponent> t_ = a?.MonitoringProgram;
            List<MedicationKnowledge.AdministrationGuidelinesComponent> u_ = a?.AdministrationGuidelines;
            List<MedicationKnowledge.MedicineClassificationComponent> v_ = a?.MedicineClassification;
            MedicationKnowledge.PackagingComponent w_ = a?.Packaging;
            List<MedicationKnowledge.DrugCharacteristicComponent> x_ = a?.DrugCharacteristic;
            List<ResourceReference> y_ = a?.Contraindication;
            List<MedicationKnowledge.RegulatoryComponent> z_ = a?.Regulatory;
            List<MedicationKnowledge.KineticsComponent> aa_ = a?.Kinetics;
            MedicationKnowledge ab_ = new MedicationKnowledge
            {
                Code = f_,
                StatusElement = g_,
                Manufacturer = h_,
                DoseForm = i_,
                Amount = j_,
                SynonymElement = new List<FhirString>((IEnumerable<FhirString>)k_),
                RelatedMedicationKnowledge = new List<MedicationKnowledge.RelatedMedicationKnowledgeComponent>((IEnumerable<MedicationKnowledge.RelatedMedicationKnowledgeComponent>)l_),
                AssociatedMedication = new List<ResourceReference>((IEnumerable<ResourceReference>)m_),
                ProductType = new List<CodeableConcept>((IEnumerable<CodeableConcept>)n_),
                Monograph = new List<MedicationKnowledge.MonographComponent>((IEnumerable<MedicationKnowledge.MonographComponent>)o_),
                Ingredient = new List<MedicationKnowledge.IngredientComponent>((IEnumerable<MedicationKnowledge.IngredientComponent>)p_),
                PreparationInstructionElement = q_,
                IntendedRoute = new List<CodeableConcept>((IEnumerable<CodeableConcept>)r_),
                Cost = new List<MedicationKnowledge.CostComponent>((IEnumerable<MedicationKnowledge.CostComponent>)s_),
                MonitoringProgram = new List<MedicationKnowledge.MonitoringProgramComponent>((IEnumerable<MedicationKnowledge.MonitoringProgramComponent>)t_),
                AdministrationGuidelines = new List<MedicationKnowledge.AdministrationGuidelinesComponent>((IEnumerable<MedicationKnowledge.AdministrationGuidelinesComponent>)u_),
                MedicineClassification = new List<MedicationKnowledge.MedicineClassificationComponent>((IEnumerable<MedicationKnowledge.MedicineClassificationComponent>)v_),
                Packaging = w_,
                DrugCharacteristic = new List<MedicationKnowledge.DrugCharacteristicComponent>((IEnumerable<MedicationKnowledge.DrugCharacteristicComponent>)x_),
                Contraindication = new List<ResourceReference>((IEnumerable<ResourceReference>)y_),
                Regulatory = new List<MedicationKnowledge.RegulatoryComponent>((IEnumerable<MedicationKnowledge.RegulatoryComponent>)z_),
                Kinetics = new List<MedicationKnowledge.KineticsComponent>((IEnumerable<MedicationKnowledge.KineticsComponent>)aa_),
            };
            return ab_;
        }

        IEnumerable<MedicationKnowledge> c_ = context.Operators.Select<MedicationKnowledge, MedicationKnowledge>((IEnumerable<MedicationKnowledge>)a_, b_);
        IEnumerable<MedicationKnowledge> d_ = context.Operators.Distinct<MedicationKnowledge>(c_);
        MedicationKnowledge e_ = context.Operators.SingletonFrom<MedicationKnowledge>(d_);
        return e_;
    }


    [CqlFunctionDefinition("MedicationRequestResource")]
    public MedicationRequest MedicationRequestResource(CqlContext context, MedicationRequest arg)
    {
        MedicationRequest[] a_ = [
            arg,
        ];

        MedicationRequest b_(MedicationRequest a) {
            List<Identifier> f_ = a?.Identifier;
            Code<MedicationRequest.MedicationrequestStatus> g_ = a?.StatusElement;
            CodeableConcept h_ = a?.StatusReason;
            Code<MedicationRequest.MedicationRequestIntent> i_ = a?.IntentElement;
            List<CodeableConcept> j_ = a?.Category;
            Code<RequestPriority> k_ = a?.PriorityElement;
            FhirBoolean l_ = a?.DoNotPerformElement;
            DataType m_ = a?.Reported;
            DataType n_ = a?.Medication;
            ResourceReference o_ = a?.Subject;
            ResourceReference p_ = a?.Encounter;
            List<ResourceReference> q_ = a?.SupportingInformation;
            FhirDateTime r_ = a?.AuthoredOnElement;
            ResourceReference s_ = a?.Requester;
            ResourceReference t_ = a?.Performer;
            CodeableConcept u_ = a?.PerformerType;
            ResourceReference v_ = a?.Recorder;
            List<CodeableConcept> w_ = a?.ReasonCode;
            List<ResourceReference> x_ = a?.ReasonReference;
            List<Canonical> y_ = a?.InstantiatesCanonicalElement;
            List<FhirUri> z_ = a?.InstantiatesUriElement;
            List<ResourceReference> aa_ = a?.BasedOn;
            Identifier ab_ = a?.GroupIdentifier;
            CodeableConcept ac_ = a?.CourseOfTherapyType;
            List<ResourceReference> ad_ = a?.Insurance;
            List<Annotation> ae_ = a?.Note;
            List<Dosage> af_ = a?.DosageInstruction;
            MedicationRequest.DispenseRequestComponent ag_ = a?.DispenseRequest;
            MedicationRequest.SubstitutionComponent ah_ = a?.Substitution;
            ResourceReference ai_ = a?.PriorPrescription;
            List<ResourceReference> aj_ = a?.DetectedIssue;
            List<ResourceReference> ak_ = a?.EventHistory;
            MedicationRequest al_ = new MedicationRequest
            {
                Identifier = new List<Identifier>((IEnumerable<Identifier>)f_),
                StatusElement = g_,
                StatusReason = h_,
                IntentElement = i_,
                Category = new List<CodeableConcept>((IEnumerable<CodeableConcept>)j_),
                PriorityElement = k_,
                DoNotPerformElement = l_,
                Reported = (DataType)m_,
                Medication = (DataType)n_,
                Subject = o_,
                Encounter = p_,
                SupportingInformation = new List<ResourceReference>((IEnumerable<ResourceReference>)q_),
                AuthoredOnElement = r_,
                Requester = s_,
                Performer = t_,
                PerformerType = u_,
                Recorder = v_,
                ReasonCode = new List<CodeableConcept>((IEnumerable<CodeableConcept>)w_),
                ReasonReference = new List<ResourceReference>((IEnumerable<ResourceReference>)x_),
                InstantiatesCanonicalElement = new List<Canonical>((IEnumerable<Canonical>)y_),
                InstantiatesUriElement = new List<FhirUri>((IEnumerable<FhirUri>)z_),
                BasedOn = new List<ResourceReference>((IEnumerable<ResourceReference>)aa_),
                GroupIdentifier = ab_,
                CourseOfTherapyType = ac_,
                Insurance = new List<ResourceReference>((IEnumerable<ResourceReference>)ad_),
                Note = new List<Annotation>((IEnumerable<Annotation>)ae_),
                DosageInstruction = new List<Dosage>((IEnumerable<Dosage>)af_),
                DispenseRequest = ag_,
                Substitution = ah_,
                PriorPrescription = ai_,
                DetectedIssue = new List<ResourceReference>((IEnumerable<ResourceReference>)aj_),
                EventHistory = new List<ResourceReference>((IEnumerable<ResourceReference>)ak_),
            };
            return al_;
        }

        IEnumerable<MedicationRequest> c_ = context.Operators.Select<MedicationRequest, MedicationRequest>((IEnumerable<MedicationRequest>)a_, b_);
        IEnumerable<MedicationRequest> d_ = context.Operators.Distinct<MedicationRequest>(c_);
        MedicationRequest e_ = context.Operators.SingletonFrom<MedicationRequest>(d_);
        return e_;
    }


    [CqlFunctionDefinition("MedicationStatementResource")]
    public MedicationStatement MedicationStatementResource(CqlContext context, MedicationStatement arg)
    {
        MedicationStatement[] a_ = [
            arg,
        ];

        MedicationStatement b_(MedicationStatement a) {
            List<Identifier> f_ = a?.Identifier;
            List<ResourceReference> g_ = a?.BasedOn;
            List<ResourceReference> h_ = a?.PartOf;
            Code<MedicationStatement.MedicationStatusCodes> i_ = a?.StatusElement;
            List<CodeableConcept> j_ = a?.StatusReason;
            CodeableConcept k_ = a?.Category;
            DataType l_ = a?.Medication;
            ResourceReference m_ = a?.Subject;
            ResourceReference n_ = a?.Context;
            DataType o_ = a?.Effective;
            FhirDateTime p_ = a?.DateAssertedElement;
            ResourceReference q_ = a?.InformationSource;
            List<ResourceReference> r_ = a?.DerivedFrom;
            List<CodeableConcept> s_ = a?.ReasonCode;
            List<ResourceReference> t_ = a?.ReasonReference;
            List<Annotation> u_ = a?.Note;
            List<Dosage> v_ = a?.Dosage;
            MedicationStatement w_ = new MedicationStatement
            {
                Identifier = new List<Identifier>((IEnumerable<Identifier>)f_),
                BasedOn = new List<ResourceReference>((IEnumerable<ResourceReference>)g_),
                PartOf = new List<ResourceReference>((IEnumerable<ResourceReference>)h_),
                StatusElement = i_,
                StatusReason = new List<CodeableConcept>((IEnumerable<CodeableConcept>)j_),
                Category = k_,
                Medication = (DataType)l_,
                Subject = m_,
                Context = n_,
                Effective = (DataType)o_,
                DateAssertedElement = p_,
                InformationSource = q_,
                DerivedFrom = new List<ResourceReference>((IEnumerable<ResourceReference>)r_),
                ReasonCode = new List<CodeableConcept>((IEnumerable<CodeableConcept>)s_),
                ReasonReference = new List<ResourceReference>((IEnumerable<ResourceReference>)t_),
                Note = new List<Annotation>((IEnumerable<Annotation>)u_),
                Dosage = new List<Dosage>((IEnumerable<Dosage>)v_),
            };
            return w_;
        }

        IEnumerable<MedicationStatement> c_ = context.Operators.Select<MedicationStatement, MedicationStatement>((IEnumerable<MedicationStatement>)a_, b_);
        IEnumerable<MedicationStatement> d_ = context.Operators.Distinct<MedicationStatement>(c_);
        MedicationStatement e_ = context.Operators.SingletonFrom<MedicationStatement>(d_);
        return e_;
    }


    [CqlFunctionDefinition("MedicinalProductResource")]
    public MedicinalProduct MedicinalProductResource(CqlContext context, MedicinalProduct arg)
    {
        MedicinalProduct[] a_ = [
            arg,
        ];

        MedicinalProduct b_(MedicinalProduct a) {
            List<Identifier> f_ = a?.Identifier;
            CodeableConcept g_ = a?.Type;
            Coding h_ = a?.Domain;
            CodeableConcept i_ = a?.CombinedPharmaceuticalDoseForm;
            CodeableConcept j_ = a?.LegalStatusOfSupply;
            CodeableConcept k_ = a?.AdditionalMonitoringIndicator;
            List<FhirString> l_ = a?.SpecialMeasuresElement;
            CodeableConcept m_ = a?.PaediatricUseIndicator;
            List<CodeableConcept> n_ = a?.ProductClassification;
            List<MarketingStatus> o_ = a?.MarketingStatus;
            List<ResourceReference> p_ = a?.PharmaceuticalProduct;
            List<ResourceReference> q_ = a?.PackagedMedicinalProduct;
            List<ResourceReference> r_ = a?.AttachedDocument;
            List<ResourceReference> s_ = a?.MasterFile;
            List<ResourceReference> t_ = a?.Contact;
            List<ResourceReference> u_ = a?.ClinicalTrial;
            List<MedicinalProduct.NameComponent> v_ = a?.Name;
            List<Identifier> w_ = a?.CrossReference;
            List<MedicinalProduct.ManufacturingBusinessOperationComponent> x_ = a?.ManufacturingBusinessOperation;
            List<MedicinalProduct.SpecialDesignationComponent> y_ = a?.SpecialDesignation;
            MedicinalProduct z_ = new MedicinalProduct
            {
                Identifier = new List<Identifier>((IEnumerable<Identifier>)f_),
                Type = g_,
                Domain = h_,
                CombinedPharmaceuticalDoseForm = i_,
                LegalStatusOfSupply = j_,
                AdditionalMonitoringIndicator = k_,
                SpecialMeasuresElement = new List<FhirString>((IEnumerable<FhirString>)l_),
                PaediatricUseIndicator = m_,
                ProductClassification = new List<CodeableConcept>((IEnumerable<CodeableConcept>)n_),
                MarketingStatus = new List<MarketingStatus>((IEnumerable<MarketingStatus>)o_),
                PharmaceuticalProduct = new List<ResourceReference>((IEnumerable<ResourceReference>)p_),
                PackagedMedicinalProduct = new List<ResourceReference>((IEnumerable<ResourceReference>)q_),
                AttachedDocument = new List<ResourceReference>((IEnumerable<ResourceReference>)r_),
                MasterFile = new List<ResourceReference>((IEnumerable<ResourceReference>)s_),
                Contact = new List<ResourceReference>((IEnumerable<ResourceReference>)t_),
                ClinicalTrial = new List<ResourceReference>((IEnumerable<ResourceReference>)u_),
                Name = new List<MedicinalProduct.NameComponent>((IEnumerable<MedicinalProduct.NameComponent>)v_),
                CrossReference = new List<Identifier>((IEnumerable<Identifier>)w_),
                ManufacturingBusinessOperation = new List<MedicinalProduct.ManufacturingBusinessOperationComponent>((IEnumerable<MedicinalProduct.ManufacturingBusinessOperationComponent>)x_),
                SpecialDesignation = new List<MedicinalProduct.SpecialDesignationComponent>((IEnumerable<MedicinalProduct.SpecialDesignationComponent>)y_),
            };
            return z_;
        }

        IEnumerable<MedicinalProduct> c_ = context.Operators.Select<MedicinalProduct, MedicinalProduct>((IEnumerable<MedicinalProduct>)a_, b_);
        IEnumerable<MedicinalProduct> d_ = context.Operators.Distinct<MedicinalProduct>(c_);
        MedicinalProduct e_ = context.Operators.SingletonFrom<MedicinalProduct>(d_);
        return e_;
    }


    [CqlFunctionDefinition("MedicinalProductAuthorizationResource")]
    public MedicinalProductAuthorization MedicinalProductAuthorizationResource(CqlContext context, MedicinalProductAuthorization arg)
    {
        MedicinalProductAuthorization[] a_ = [
            arg,
        ];

        MedicinalProductAuthorization b_(MedicinalProductAuthorization a) {
            List<Identifier> f_ = a?.Identifier;
            ResourceReference g_ = a?.Subject;
            List<CodeableConcept> h_ = a?.Country;
            List<CodeableConcept> i_ = a?.Jurisdiction;
            CodeableConcept j_ = a?.Status;
            FhirDateTime k_ = a?.StatusDateElement;
            FhirDateTime l_ = a?.RestoreDateElement;
            Period m_ = a?.ValidityPeriod;
            Period n_ = a?.DataExclusivityPeriod;
            FhirDateTime o_ = a?.DateOfFirstAuthorizationElement;
            FhirDateTime p_ = a?.InternationalBirthDateElement;
            CodeableConcept q_ = a?.LegalBasis;
            List<MedicinalProductAuthorization.JurisdictionalAuthorizationComponent> r_ = a?.JurisdictionalAuthorization;
            ResourceReference s_ = a?.Holder;
            ResourceReference t_ = a?.Regulator;
            MedicinalProductAuthorization.ProcedureComponent u_ = a?.Procedure;
            MedicinalProductAuthorization v_ = new MedicinalProductAuthorization
            {
                Identifier = new List<Identifier>((IEnumerable<Identifier>)f_),
                Subject = g_,
                Country = new List<CodeableConcept>((IEnumerable<CodeableConcept>)h_),
                Jurisdiction = new List<CodeableConcept>((IEnumerable<CodeableConcept>)i_),
                Status = j_,
                StatusDateElement = k_,
                RestoreDateElement = l_,
                ValidityPeriod = m_,
                DataExclusivityPeriod = n_,
                DateOfFirstAuthorizationElement = o_,
                InternationalBirthDateElement = p_,
                LegalBasis = q_,
                JurisdictionalAuthorization = new List<MedicinalProductAuthorization.JurisdictionalAuthorizationComponent>((IEnumerable<MedicinalProductAuthorization.JurisdictionalAuthorizationComponent>)r_),
                Holder = s_,
                Regulator = t_,
                Procedure = u_,
            };
            return v_;
        }

        IEnumerable<MedicinalProductAuthorization> c_ = context.Operators.Select<MedicinalProductAuthorization, MedicinalProductAuthorization>((IEnumerable<MedicinalProductAuthorization>)a_, b_);
        IEnumerable<MedicinalProductAuthorization> d_ = context.Operators.Distinct<MedicinalProductAuthorization>(c_);
        MedicinalProductAuthorization e_ = context.Operators.SingletonFrom<MedicinalProductAuthorization>(d_);
        return e_;
    }


    [CqlFunctionDefinition("MedicinalProductContraindicationResource")]
    public MedicinalProductContraindication MedicinalProductContraindicationResource(CqlContext context, MedicinalProductContraindication arg)
    {
        MedicinalProductContraindication[] a_ = [
            arg,
        ];

        MedicinalProductContraindication b_(MedicinalProductContraindication a) {
            List<ResourceReference> f_ = a?.Subject;
            CodeableConcept g_ = a?.Disease;
            CodeableConcept h_ = a?.DiseaseStatus;
            List<CodeableConcept> i_ = a?.Comorbidity;
            List<ResourceReference> j_ = a?.TherapeuticIndication;
            List<MedicinalProductContraindication.OtherTherapyComponent> k_ = a?.OtherTherapy;
            List<Population> l_ = a?.Population;
            MedicinalProductContraindication m_ = new MedicinalProductContraindication
            {
                Subject = new List<ResourceReference>((IEnumerable<ResourceReference>)f_),
                Disease = g_,
                DiseaseStatus = h_,
                Comorbidity = new List<CodeableConcept>((IEnumerable<CodeableConcept>)i_),
                TherapeuticIndication = new List<ResourceReference>((IEnumerable<ResourceReference>)j_),
                OtherTherapy = new List<MedicinalProductContraindication.OtherTherapyComponent>((IEnumerable<MedicinalProductContraindication.OtherTherapyComponent>)k_),
                Population = new List<Population>((IEnumerable<Population>)l_),
            };
            return m_;
        }

        IEnumerable<MedicinalProductContraindication> c_ = context.Operators.Select<MedicinalProductContraindication, MedicinalProductContraindication>((IEnumerable<MedicinalProductContraindication>)a_, b_);
        IEnumerable<MedicinalProductContraindication> d_ = context.Operators.Distinct<MedicinalProductContraindication>(c_);
        MedicinalProductContraindication e_ = context.Operators.SingletonFrom<MedicinalProductContraindication>(d_);
        return e_;
    }


    [CqlFunctionDefinition("MedicinalProductIngredientResource")]
    public MedicinalProductIngredient MedicinalProductIngredientResource(CqlContext context, MedicinalProductIngredient arg)
    {
        MedicinalProductIngredient[] a_ = [
            arg,
        ];

        MedicinalProductIngredient b_(MedicinalProductIngredient a) {
            Identifier f_ = a?.Identifier;
            CodeableConcept g_ = a?.Role;
            FhirBoolean h_ = a?.AllergenicIndicatorElement;
            List<ResourceReference> i_ = a?.Manufacturer;
            List<MedicinalProductIngredient.SpecifiedSubstanceComponent> j_ = a?.SpecifiedSubstance;
            MedicinalProductIngredient.SubstanceComponent k_ = a?.Substance;
            MedicinalProductIngredient l_ = new MedicinalProductIngredient
            {
                Identifier = f_,
                Role = g_,
                AllergenicIndicatorElement = h_,
                Manufacturer = new List<ResourceReference>((IEnumerable<ResourceReference>)i_),
                SpecifiedSubstance = new List<MedicinalProductIngredient.SpecifiedSubstanceComponent>((IEnumerable<MedicinalProductIngredient.SpecifiedSubstanceComponent>)j_),
                Substance = k_,
            };
            return l_;
        }

        IEnumerable<MedicinalProductIngredient> c_ = context.Operators.Select<MedicinalProductIngredient, MedicinalProductIngredient>((IEnumerable<MedicinalProductIngredient>)a_, b_);
        IEnumerable<MedicinalProductIngredient> d_ = context.Operators.Distinct<MedicinalProductIngredient>(c_);
        MedicinalProductIngredient e_ = context.Operators.SingletonFrom<MedicinalProductIngredient>(d_);
        return e_;
    }


    [CqlFunctionDefinition("MedicinalProductInteractionResource")]
    public MedicinalProductInteraction MedicinalProductInteractionResource(CqlContext context, MedicinalProductInteraction arg)
    {
        MedicinalProductInteraction[] a_ = [
            arg,
        ];

        MedicinalProductInteraction b_(MedicinalProductInteraction a) {
            List<ResourceReference> f_ = a?.Subject;
            FhirString g_ = a?.DescriptionElement;
            List<MedicinalProductInteraction.InteractantComponent> h_ = a?.Interactant;
            CodeableConcept i_ = a?.Type;
            CodeableConcept j_ = a?.Effect;
            CodeableConcept k_ = a?.Incidence;
            CodeableConcept l_ = a?.Management;
            MedicinalProductInteraction m_ = new MedicinalProductInteraction
            {
                Subject = new List<ResourceReference>((IEnumerable<ResourceReference>)f_),
                DescriptionElement = g_,
                Interactant = new List<MedicinalProductInteraction.InteractantComponent>((IEnumerable<MedicinalProductInteraction.InteractantComponent>)h_),
                Type = i_,
                Effect = j_,
                Incidence = k_,
                Management = l_,
            };
            return m_;
        }

        IEnumerable<MedicinalProductInteraction> c_ = context.Operators.Select<MedicinalProductInteraction, MedicinalProductInteraction>((IEnumerable<MedicinalProductInteraction>)a_, b_);
        IEnumerable<MedicinalProductInteraction> d_ = context.Operators.Distinct<MedicinalProductInteraction>(c_);
        MedicinalProductInteraction e_ = context.Operators.SingletonFrom<MedicinalProductInteraction>(d_);
        return e_;
    }


    [CqlFunctionDefinition("MedicinalProductManufacturedResource")]
    public MedicinalProductManufactured MedicinalProductManufacturedResource(CqlContext context, MedicinalProductManufactured arg)
    {
        MedicinalProductManufactured[] a_ = [
            arg,
        ];

        MedicinalProductManufactured b_(MedicinalProductManufactured a) {
            CodeableConcept f_ = a?.ManufacturedDoseForm;
            CodeableConcept g_ = a?.UnitOfPresentation;
            Quantity h_ = a?.Quantity;
            List<ResourceReference> i_ = a?.Manufacturer;
            List<ResourceReference> j_ = a?.Ingredient;
            ProdCharacteristic k_ = a?.PhysicalCharacteristics;
            List<CodeableConcept> l_ = a?.OtherCharacteristics;
            MedicinalProductManufactured m_ = new MedicinalProductManufactured
            {
                ManufacturedDoseForm = f_,
                UnitOfPresentation = g_,
                Quantity = h_,
                Manufacturer = new List<ResourceReference>((IEnumerable<ResourceReference>)i_),
                Ingredient = new List<ResourceReference>((IEnumerable<ResourceReference>)j_),
                PhysicalCharacteristics = k_,
                OtherCharacteristics = new List<CodeableConcept>((IEnumerable<CodeableConcept>)l_),
            };
            return m_;
        }

        IEnumerable<MedicinalProductManufactured> c_ = context.Operators.Select<MedicinalProductManufactured, MedicinalProductManufactured>((IEnumerable<MedicinalProductManufactured>)a_, b_);
        IEnumerable<MedicinalProductManufactured> d_ = context.Operators.Distinct<MedicinalProductManufactured>(c_);
        MedicinalProductManufactured e_ = context.Operators.SingletonFrom<MedicinalProductManufactured>(d_);
        return e_;
    }


    [CqlFunctionDefinition("MedicinalProductPackagedResource")]
    public MedicinalProductPackaged MedicinalProductPackagedResource(CqlContext context, MedicinalProductPackaged arg)
    {
        MedicinalProductPackaged[] a_ = [
            arg,
        ];

        MedicinalProductPackaged b_(MedicinalProductPackaged a) {
            List<Identifier> f_ = a?.Identifier;
            List<ResourceReference> g_ = a?.Subject;
            FhirString h_ = a?.DescriptionElement;
            CodeableConcept i_ = a?.LegalStatusOfSupply;
            List<MarketingStatus> j_ = a?.MarketingStatus;
            ResourceReference k_ = a?.MarketingAuthorization;
            List<ResourceReference> l_ = a?.Manufacturer;
            List<MedicinalProductPackaged.BatchIdentifierComponent> m_ = a?.BatchIdentifier;
            List<MedicinalProductPackaged.PackageItemComponent> n_ = a?.PackageItem;
            MedicinalProductPackaged o_ = new MedicinalProductPackaged
            {
                Identifier = new List<Identifier>((IEnumerable<Identifier>)f_),
                Subject = new List<ResourceReference>((IEnumerable<ResourceReference>)g_),
                DescriptionElement = h_,
                LegalStatusOfSupply = i_,
                MarketingStatus = new List<MarketingStatus>((IEnumerable<MarketingStatus>)j_),
                MarketingAuthorization = k_,
                Manufacturer = new List<ResourceReference>((IEnumerable<ResourceReference>)l_),
                BatchIdentifier = new List<MedicinalProductPackaged.BatchIdentifierComponent>((IEnumerable<MedicinalProductPackaged.BatchIdentifierComponent>)m_),
                PackageItem = new List<MedicinalProductPackaged.PackageItemComponent>((IEnumerable<MedicinalProductPackaged.PackageItemComponent>)n_),
            };
            return o_;
        }

        IEnumerable<MedicinalProductPackaged> c_ = context.Operators.Select<MedicinalProductPackaged, MedicinalProductPackaged>((IEnumerable<MedicinalProductPackaged>)a_, b_);
        IEnumerable<MedicinalProductPackaged> d_ = context.Operators.Distinct<MedicinalProductPackaged>(c_);
        MedicinalProductPackaged e_ = context.Operators.SingletonFrom<MedicinalProductPackaged>(d_);
        return e_;
    }


    [CqlFunctionDefinition("MedicinalProductPharmaceuticalResource")]
    public MedicinalProductPharmaceutical MedicinalProductPharmaceuticalResource(CqlContext context, MedicinalProductPharmaceutical arg)
    {
        MedicinalProductPharmaceutical[] a_ = [
            arg,
        ];

        MedicinalProductPharmaceutical b_(MedicinalProductPharmaceutical a) {
            List<Identifier> f_ = a?.Identifier;
            CodeableConcept g_ = a?.AdministrableDoseForm;
            CodeableConcept h_ = a?.UnitOfPresentation;
            List<ResourceReference> i_ = a?.Ingredient;
            List<ResourceReference> j_ = a?.Device;
            List<MedicinalProductPharmaceutical.CharacteristicsComponent> k_ = a?.Characteristics;
            List<MedicinalProductPharmaceutical.RouteOfAdministrationComponent> l_ = a?.RouteOfAdministration;
            MedicinalProductPharmaceutical m_ = new MedicinalProductPharmaceutical
            {
                Identifier = new List<Identifier>((IEnumerable<Identifier>)f_),
                AdministrableDoseForm = g_,
                UnitOfPresentation = h_,
                Ingredient = new List<ResourceReference>((IEnumerable<ResourceReference>)i_),
                Device = new List<ResourceReference>((IEnumerable<ResourceReference>)j_),
                Characteristics = new List<MedicinalProductPharmaceutical.CharacteristicsComponent>((IEnumerable<MedicinalProductPharmaceutical.CharacteristicsComponent>)k_),
                RouteOfAdministration = new List<MedicinalProductPharmaceutical.RouteOfAdministrationComponent>((IEnumerable<MedicinalProductPharmaceutical.RouteOfAdministrationComponent>)l_),
            };
            return m_;
        }

        IEnumerable<MedicinalProductPharmaceutical> c_ = context.Operators.Select<MedicinalProductPharmaceutical, MedicinalProductPharmaceutical>((IEnumerable<MedicinalProductPharmaceutical>)a_, b_);
        IEnumerable<MedicinalProductPharmaceutical> d_ = context.Operators.Distinct<MedicinalProductPharmaceutical>(c_);
        MedicinalProductPharmaceutical e_ = context.Operators.SingletonFrom<MedicinalProductPharmaceutical>(d_);
        return e_;
    }


    [CqlFunctionDefinition("MedicinalProductUndesirableEffectResource")]
    public MedicinalProductUndesirableEffect MedicinalProductUndesirableEffectResource(CqlContext context, MedicinalProductUndesirableEffect arg)
    {
        MedicinalProductUndesirableEffect[] a_ = [
            arg,
        ];

        MedicinalProductUndesirableEffect b_(MedicinalProductUndesirableEffect a) {
            List<ResourceReference> f_ = a?.Subject;
            CodeableConcept g_ = a?.SymptomConditionEffect;
            CodeableConcept h_ = a?.Classification;
            CodeableConcept i_ = a?.FrequencyOfOccurrence;
            List<Population> j_ = a?.Population;
            MedicinalProductUndesirableEffect k_ = new MedicinalProductUndesirableEffect
            {
                Subject = new List<ResourceReference>((IEnumerable<ResourceReference>)f_),
                SymptomConditionEffect = g_,
                Classification = h_,
                FrequencyOfOccurrence = i_,
                Population = new List<Population>((IEnumerable<Population>)j_),
            };
            return k_;
        }

        IEnumerable<MedicinalProductUndesirableEffect> c_ = context.Operators.Select<MedicinalProductUndesirableEffect, MedicinalProductUndesirableEffect>((IEnumerable<MedicinalProductUndesirableEffect>)a_, b_);
        IEnumerable<MedicinalProductUndesirableEffect> d_ = context.Operators.Distinct<MedicinalProductUndesirableEffect>(c_);
        MedicinalProductUndesirableEffect e_ = context.Operators.SingletonFrom<MedicinalProductUndesirableEffect>(d_);
        return e_;
    }


    [CqlFunctionDefinition("MessageHeaderResource")]
    public MessageHeader MessageHeaderResource(CqlContext context, MessageHeader arg)
    {
        MessageHeader[] a_ = [
            arg,
        ];

        MessageHeader b_(MessageHeader a) {
            DataType f_ = a?.Event;
            List<MessageHeader.MessageDestinationComponent> g_ = a?.Destination;
            ResourceReference h_ = a?.Sender;
            ResourceReference i_ = a?.Enterer;
            ResourceReference j_ = a?.Author;
            MessageHeader.MessageSourceComponent k_ = a?.Source;
            ResourceReference l_ = a?.Responsible;
            CodeableConcept m_ = a?.Reason;
            MessageHeader.ResponseComponent n_ = a?.Response;
            List<ResourceReference> o_ = a?.Focus;
            Canonical p_ = a?.DefinitionElement;
            MessageHeader q_ = new MessageHeader
            {
                Event = (DataType)f_,
                Destination = new List<MessageHeader.MessageDestinationComponent>((IEnumerable<MessageHeader.MessageDestinationComponent>)g_),
                Sender = h_,
                Enterer = i_,
                Author = j_,
                Source = k_,
                Responsible = l_,
                Reason = m_,
                Response = n_,
                Focus = new List<ResourceReference>((IEnumerable<ResourceReference>)o_),
                DefinitionElement = p_,
            };
            return q_;
        }

        IEnumerable<MessageHeader> c_ = context.Operators.Select<MessageHeader, MessageHeader>((IEnumerable<MessageHeader>)a_, b_);
        IEnumerable<MessageHeader> d_ = context.Operators.Distinct<MessageHeader>(c_);
        MessageHeader e_ = context.Operators.SingletonFrom<MessageHeader>(d_);
        return e_;
    }


    [CqlFunctionDefinition("MolecularSequenceResource")]
    public MolecularSequence MolecularSequenceResource(CqlContext context, MolecularSequence arg)
    {
        MolecularSequence[] a_ = [
            arg,
        ];

        MolecularSequence b_(MolecularSequence a) {
            List<Identifier> f_ = a?.Identifier;
            Code<MolecularSequence.SequenceType> g_ = a?.TypeElement;
            Integer h_ = a?.CoordinateSystemElement;
            ResourceReference i_ = a?.Patient;
            ResourceReference j_ = a?.Specimen;
            ResourceReference k_ = a?.Device;
            ResourceReference l_ = a?.Performer;
            Quantity m_ = a?.Quantity;
            MolecularSequence.ReferenceSeqComponent n_ = a?.ReferenceSeq;
            List<MolecularSequence.VariantComponent> o_ = a?.Variant;
            FhirString p_ = a?.ObservedSeqElement;
            List<MolecularSequence.QualityComponent> q_ = a?.Quality;
            Integer r_ = a?.ReadCoverageElement;
            List<MolecularSequence.RepositoryComponent> s_ = a?.Repository;
            List<ResourceReference> t_ = a?.Pointer;
            List<MolecularSequence.StructureVariantComponent> u_ = a?.StructureVariant;
            MolecularSequence v_ = new MolecularSequence
            {
                Identifier = new List<Identifier>((IEnumerable<Identifier>)f_),
                TypeElement = g_,
                CoordinateSystemElement = h_,
                Patient = i_,
                Specimen = j_,
                Device = k_,
                Performer = l_,
                Quantity = m_,
                ReferenceSeq = n_,
                Variant = new List<MolecularSequence.VariantComponent>((IEnumerable<MolecularSequence.VariantComponent>)o_),
                ObservedSeqElement = p_,
                Quality = new List<MolecularSequence.QualityComponent>((IEnumerable<MolecularSequence.QualityComponent>)q_),
                ReadCoverageElement = r_,
                Repository = new List<MolecularSequence.RepositoryComponent>((IEnumerable<MolecularSequence.RepositoryComponent>)s_),
                Pointer = new List<ResourceReference>((IEnumerable<ResourceReference>)t_),
                StructureVariant = new List<MolecularSequence.StructureVariantComponent>((IEnumerable<MolecularSequence.StructureVariantComponent>)u_),
            };
            return v_;
        }

        IEnumerable<MolecularSequence> c_ = context.Operators.Select<MolecularSequence, MolecularSequence>((IEnumerable<MolecularSequence>)a_, b_);
        IEnumerable<MolecularSequence> d_ = context.Operators.Distinct<MolecularSequence>(c_);
        MolecularSequence e_ = context.Operators.SingletonFrom<MolecularSequence>(d_);
        return e_;
    }


    [CqlFunctionDefinition("NamingSystemResource")]
    public NamingSystem NamingSystemResource(CqlContext context, NamingSystem arg)
    {
        NamingSystem[] a_ = [
            arg,
        ];

        NamingSystem b_(NamingSystem a) {
            FhirString f_ = a?.NameElement;
            Code<PublicationStatus> g_ = a?.StatusElement;
            Code<NamingSystem.NamingSystemType> h_ = a?.KindElement;
            FhirDateTime i_ = a?.DateElement;
            FhirString j_ = a?.PublisherElement;
            List<ContactDetail> k_ = a?.Contact;
            FhirString l_ = a?.ResponsibleElement;
            CodeableConcept m_ = a?.Type;
            Markdown n_ = a?.DescriptionElement;
            List<UsageContext> o_ = a?.UseContext;
            List<CodeableConcept> p_ = a?.Jurisdiction;
            FhirString q_ = a?.UsageElement;
            List<NamingSystem.UniqueIdComponent> r_ = a?.UniqueId;
            NamingSystem s_ = new NamingSystem
            {
                NameElement = f_,
                StatusElement = g_,
                KindElement = h_,
                DateElement = i_,
                PublisherElement = j_,
                Contact = new List<ContactDetail>((IEnumerable<ContactDetail>)k_),
                ResponsibleElement = l_,
                Type = m_,
                DescriptionElement = n_,
                UseContext = new List<UsageContext>((IEnumerable<UsageContext>)o_),
                Jurisdiction = new List<CodeableConcept>((IEnumerable<CodeableConcept>)p_),
                UsageElement = q_,
                UniqueId = new List<NamingSystem.UniqueIdComponent>((IEnumerable<NamingSystem.UniqueIdComponent>)r_),
            };
            return s_;
        }

        IEnumerable<NamingSystem> c_ = context.Operators.Select<NamingSystem, NamingSystem>((IEnumerable<NamingSystem>)a_, b_);
        IEnumerable<NamingSystem> d_ = context.Operators.Distinct<NamingSystem>(c_);
        NamingSystem e_ = context.Operators.SingletonFrom<NamingSystem>(d_);
        return e_;
    }


    [CqlFunctionDefinition("NutritionOrderResource")]
    public NutritionOrder NutritionOrderResource(CqlContext context, NutritionOrder arg)
    {
        NutritionOrder[] a_ = [
            arg,
        ];

        NutritionOrder b_(NutritionOrder a) {
            List<Identifier> f_ = a?.Identifier;
            List<Canonical> g_ = a?.InstantiatesCanonicalElement;
            List<FhirUri> h_ = a?.InstantiatesUriElement;
            List<FhirUri> i_ = a?.InstantiatesElement;
            Code<RequestStatus> j_ = a?.StatusElement;
            Code<RequestIntent> k_ = a?.IntentElement;
            ResourceReference l_ = a?.Patient;
            ResourceReference m_ = a?.Encounter;
            FhirDateTime n_ = a?.DateTimeElement;
            ResourceReference o_ = a?.Orderer;
            List<ResourceReference> p_ = a?.AllergyIntolerance;
            List<CodeableConcept> q_ = a?.FoodPreferenceModifier;
            List<CodeableConcept> r_ = a?.ExcludeFoodModifier;
            NutritionOrder.OralDietComponent s_ = a?.OralDiet;
            List<NutritionOrder.SupplementComponent> t_ = a?.Supplement;
            NutritionOrder.EnteralFormulaComponent u_ = a?.EnteralFormula;
            List<Annotation> v_ = a?.Note;
            NutritionOrder w_ = new NutritionOrder
            {
                Identifier = new List<Identifier>((IEnumerable<Identifier>)f_),
                InstantiatesCanonicalElement = new List<Canonical>((IEnumerable<Canonical>)g_),
                InstantiatesUriElement = new List<FhirUri>((IEnumerable<FhirUri>)h_),
                InstantiatesElement = new List<FhirUri>((IEnumerable<FhirUri>)i_),
                StatusElement = j_,
                IntentElement = k_,
                Patient = l_,
                Encounter = m_,
                DateTimeElement = n_,
                Orderer = o_,
                AllergyIntolerance = new List<ResourceReference>((IEnumerable<ResourceReference>)p_),
                FoodPreferenceModifier = new List<CodeableConcept>((IEnumerable<CodeableConcept>)q_),
                ExcludeFoodModifier = new List<CodeableConcept>((IEnumerable<CodeableConcept>)r_),
                OralDiet = s_,
                Supplement = new List<NutritionOrder.SupplementComponent>((IEnumerable<NutritionOrder.SupplementComponent>)t_),
                EnteralFormula = u_,
                Note = new List<Annotation>((IEnumerable<Annotation>)v_),
            };
            return w_;
        }

        IEnumerable<NutritionOrder> c_ = context.Operators.Select<NutritionOrder, NutritionOrder>((IEnumerable<NutritionOrder>)a_, b_);
        IEnumerable<NutritionOrder> d_ = context.Operators.Distinct<NutritionOrder>(c_);
        NutritionOrder e_ = context.Operators.SingletonFrom<NutritionOrder>(d_);
        return e_;
    }


    [CqlFunctionDefinition("ObservationResource")]
    public Observation ObservationResource(CqlContext context, Observation arg)
    {
        Observation[] a_ = [
            arg,
        ];

        Observation b_(Observation a) {
            List<Identifier> f_ = a?.Identifier;
            List<ResourceReference> g_ = a?.BasedOn;
            List<ResourceReference> h_ = a?.PartOf;
            Code<ObservationStatus> i_ = a?.StatusElement;
            List<CodeableConcept> j_ = a?.Category;
            CodeableConcept k_ = a?.Code;
            ResourceReference l_ = a?.Subject;
            List<ResourceReference> m_ = a?.Focus;
            ResourceReference n_ = a?.Encounter;
            DataType o_ = a?.Effective;
            Instant p_ = a?.IssuedElement;
            List<ResourceReference> q_ = a?.Performer;
            DataType r_ = a?.Value;
            CodeableConcept s_ = a?.DataAbsentReason;
            List<CodeableConcept> t_ = a?.Interpretation;
            List<Annotation> u_ = a?.Note;
            CodeableConcept v_ = a?.BodySite;
            CodeableConcept w_ = a?.Method;
            ResourceReference x_ = a?.Specimen;
            ResourceReference y_ = a?.Device;
            List<Observation.ReferenceRangeComponent> z_ = a?.ReferenceRange;
            List<ResourceReference> aa_ = a?.HasMember;
            List<ResourceReference> ab_ = a?.DerivedFrom;
            List<Observation.ComponentComponent> ac_ = a?.Component;
            Observation ad_ = new Observation
            {
                Identifier = new List<Identifier>((IEnumerable<Identifier>)f_),
                BasedOn = new List<ResourceReference>((IEnumerable<ResourceReference>)g_),
                PartOf = new List<ResourceReference>((IEnumerable<ResourceReference>)h_),
                StatusElement = i_,
                Category = new List<CodeableConcept>((IEnumerable<CodeableConcept>)j_),
                Code = k_,
                Subject = l_,
                Focus = new List<ResourceReference>((IEnumerable<ResourceReference>)m_),
                Encounter = n_,
                Effective = (DataType)o_,
                IssuedElement = p_,
                Performer = new List<ResourceReference>((IEnumerable<ResourceReference>)q_),
                Value = (DataType)r_,
                DataAbsentReason = s_,
                Interpretation = new List<CodeableConcept>((IEnumerable<CodeableConcept>)t_),
                Note = new List<Annotation>((IEnumerable<Annotation>)u_),
                BodySite = v_,
                Method = w_,
                Specimen = x_,
                Device = y_,
                ReferenceRange = new List<Observation.ReferenceRangeComponent>((IEnumerable<Observation.ReferenceRangeComponent>)z_),
                HasMember = new List<ResourceReference>((IEnumerable<ResourceReference>)aa_),
                DerivedFrom = new List<ResourceReference>((IEnumerable<ResourceReference>)ab_),
                Component = new List<Observation.ComponentComponent>((IEnumerable<Observation.ComponentComponent>)ac_),
            };
            return ad_;
        }

        IEnumerable<Observation> c_ = context.Operators.Select<Observation, Observation>((IEnumerable<Observation>)a_, b_);
        IEnumerable<Observation> d_ = context.Operators.Distinct<Observation>(c_);
        Observation e_ = context.Operators.SingletonFrom<Observation>(d_);
        return e_;
    }


    [CqlFunctionDefinition("ObservationDefinitionResource")]
    public ObservationDefinition ObservationDefinitionResource(CqlContext context, ObservationDefinition arg)
    {
        ObservationDefinition[] a_ = [
            arg,
        ];

        ObservationDefinition b_(ObservationDefinition a) {
            List<CodeableConcept> f_ = a?.Category;
            CodeableConcept g_ = a?.Code;
            List<Identifier> h_ = a?.Identifier;
            List<Code<ObservationDefinition.ObservationDataType>> i_ = a?.PermittedDataTypeElement;
            FhirBoolean j_ = a?.MultipleResultsAllowedElement;
            CodeableConcept k_ = a?.Method;
            FhirString l_ = a?.PreferredReportNameElement;
            ObservationDefinition.QuantitativeDetailsComponent m_ = a?.QuantitativeDetails;
            List<ObservationDefinition.QualifiedIntervalComponent> n_ = a?.QualifiedInterval;
            ResourceReference o_ = a?.ValidCodedValueSet;
            ResourceReference p_ = a?.NormalCodedValueSet;
            ResourceReference q_ = a?.AbnormalCodedValueSet;
            ResourceReference r_ = a?.CriticalCodedValueSet;
            ObservationDefinition s_ = new ObservationDefinition
            {
                Category = new List<CodeableConcept>((IEnumerable<CodeableConcept>)f_),
                Code = g_,
                Identifier = new List<Identifier>((IEnumerable<Identifier>)h_),
                PermittedDataTypeElement = new List<Code<ObservationDefinition.ObservationDataType>>((IEnumerable<Code<ObservationDefinition.ObservationDataType>>)i_),
                MultipleResultsAllowedElement = j_,
                Method = k_,
                PreferredReportNameElement = l_,
                QuantitativeDetails = m_,
                QualifiedInterval = new List<ObservationDefinition.QualifiedIntervalComponent>((IEnumerable<ObservationDefinition.QualifiedIntervalComponent>)n_),
                ValidCodedValueSet = o_,
                NormalCodedValueSet = p_,
                AbnormalCodedValueSet = q_,
                CriticalCodedValueSet = r_,
            };
            return s_;
        }

        IEnumerable<ObservationDefinition> c_ = context.Operators.Select<ObservationDefinition, ObservationDefinition>((IEnumerable<ObservationDefinition>)a_, b_);
        IEnumerable<ObservationDefinition> d_ = context.Operators.Distinct<ObservationDefinition>(c_);
        ObservationDefinition e_ = context.Operators.SingletonFrom<ObservationDefinition>(d_);
        return e_;
    }


    [CqlFunctionDefinition("OperationOutcomeResource")]
    public OperationOutcome OperationOutcomeResource(CqlContext context, OperationOutcome arg)
    {
        OperationOutcome[] a_ = [
            arg,
        ];

        OperationOutcome b_(OperationOutcome a) {
            List<OperationOutcome.IssueComponent> f_ = a?.Issue;
            OperationOutcome g_ = new OperationOutcome
            {
                Issue = new List<OperationOutcome.IssueComponent>((IEnumerable<OperationOutcome.IssueComponent>)f_),
            };
            return g_;
        }

        IEnumerable<OperationOutcome> c_ = context.Operators.Select<OperationOutcome, OperationOutcome>((IEnumerable<OperationOutcome>)a_, b_);
        IEnumerable<OperationOutcome> d_ = context.Operators.Distinct<OperationOutcome>(c_);
        OperationOutcome e_ = context.Operators.SingletonFrom<OperationOutcome>(d_);
        return e_;
    }


    [CqlFunctionDefinition("OrganizationResource")]
    public Organization OrganizationResource(CqlContext context, Organization arg)
    {
        Organization[] a_ = [
            arg,
        ];

        Organization b_(Organization a) {
            List<Identifier> f_ = a?.Identifier;
            FhirBoolean g_ = a?.ActiveElement;
            List<CodeableConcept> h_ = a?.Type;
            FhirString i_ = a?.NameElement;
            List<FhirString> j_ = a?.AliasElement;
            List<ContactPoint> k_ = a?.Telecom;
            List<Address> l_ = a?.Address;
            ResourceReference m_ = a?.PartOf;
            List<Organization.ContactComponent> n_ = a?.Contact;
            List<ResourceReference> o_ = a?.Endpoint;
            Organization p_ = new Organization
            {
                Identifier = new List<Identifier>((IEnumerable<Identifier>)f_),
                ActiveElement = g_,
                Type = new List<CodeableConcept>((IEnumerable<CodeableConcept>)h_),
                NameElement = i_,
                AliasElement = new List<FhirString>((IEnumerable<FhirString>)j_),
                Telecom = new List<ContactPoint>((IEnumerable<ContactPoint>)k_),
                Address = new List<Address>((IEnumerable<Address>)l_),
                PartOf = m_,
                Contact = new List<Organization.ContactComponent>((IEnumerable<Organization.ContactComponent>)n_),
                Endpoint = new List<ResourceReference>((IEnumerable<ResourceReference>)o_),
            };
            return p_;
        }

        IEnumerable<Organization> c_ = context.Operators.Select<Organization, Organization>((IEnumerable<Organization>)a_, b_);
        IEnumerable<Organization> d_ = context.Operators.Distinct<Organization>(c_);
        Organization e_ = context.Operators.SingletonFrom<Organization>(d_);
        return e_;
    }


    [CqlFunctionDefinition("OrganizationAffiliationResource")]
    public OrganizationAffiliation OrganizationAffiliationResource(CqlContext context, OrganizationAffiliation arg)
    {
        OrganizationAffiliation[] a_ = [
            arg,
        ];

        OrganizationAffiliation b_(OrganizationAffiliation a) {
            List<Identifier> f_ = a?.Identifier;
            FhirBoolean g_ = a?.ActiveElement;
            Period h_ = a?.Period;
            ResourceReference i_ = a?.Organization;
            ResourceReference j_ = a?.ParticipatingOrganization;
            List<ResourceReference> k_ = a?.Network;
            List<CodeableConcept> l_ = a?.Code;
            List<CodeableConcept> m_ = a?.Specialty;
            List<ResourceReference> n_ = a?.Location;
            List<ResourceReference> o_ = a?.HealthcareService;
            List<ContactPoint> p_ = a?.Telecom;
            List<ResourceReference> q_ = a?.Endpoint;
            OrganizationAffiliation r_ = new OrganizationAffiliation
            {
                Identifier = new List<Identifier>((IEnumerable<Identifier>)f_),
                ActiveElement = g_,
                Period = h_,
                Organization = i_,
                ParticipatingOrganization = j_,
                Network = new List<ResourceReference>((IEnumerable<ResourceReference>)k_),
                Code = new List<CodeableConcept>((IEnumerable<CodeableConcept>)l_),
                Specialty = new List<CodeableConcept>((IEnumerable<CodeableConcept>)m_),
                Location = new List<ResourceReference>((IEnumerable<ResourceReference>)n_),
                HealthcareService = new List<ResourceReference>((IEnumerable<ResourceReference>)o_),
                Telecom = new List<ContactPoint>((IEnumerable<ContactPoint>)p_),
                Endpoint = new List<ResourceReference>((IEnumerable<ResourceReference>)q_),
            };
            return r_;
        }

        IEnumerable<OrganizationAffiliation> c_ = context.Operators.Select<OrganizationAffiliation, OrganizationAffiliation>((IEnumerable<OrganizationAffiliation>)a_, b_);
        IEnumerable<OrganizationAffiliation> d_ = context.Operators.Distinct<OrganizationAffiliation>(c_);
        OrganizationAffiliation e_ = context.Operators.SingletonFrom<OrganizationAffiliation>(d_);
        return e_;
    }


    [CqlFunctionDefinition("PatientResource")]
    public Patient PatientResource(CqlContext context, Patient arg)
    {
        Patient[] a_ = [
            arg,
        ];

        Patient b_(Patient a) {
            List<Identifier> f_ = a?.Identifier;
            FhirBoolean g_ = a?.ActiveElement;
            List<HumanName> h_ = a?.Name;
            List<ContactPoint> i_ = a?.Telecom;
            Code<AdministrativeGender> j_ = a?.GenderElement;
            Date k_ = a?.BirthDateElement;
            DataType l_ = a?.Deceased;
            List<Address> m_ = a?.Address;
            CodeableConcept n_ = a?.MaritalStatus;
            DataType o_ = a?.MultipleBirth;
            List<Attachment> p_ = a?.Photo;
            List<Patient.ContactComponent> q_ = a?.Contact;
            List<Patient.CommunicationComponent> r_ = a?.Communication;
            List<ResourceReference> s_ = a?.GeneralPractitioner;
            ResourceReference t_ = a?.ManagingOrganization;
            List<Patient.LinkComponent> u_ = a?.Link;
            Patient v_ = new Patient
            {
                Identifier = new List<Identifier>((IEnumerable<Identifier>)f_),
                ActiveElement = g_,
                Name = new List<HumanName>((IEnumerable<HumanName>)h_),
                Telecom = new List<ContactPoint>((IEnumerable<ContactPoint>)i_),
                GenderElement = j_,
                BirthDateElement = k_,
                Deceased = (DataType)l_,
                Address = new List<Address>((IEnumerable<Address>)m_),
                MaritalStatus = n_,
                MultipleBirth = (DataType)o_,
                Photo = new List<Attachment>((IEnumerable<Attachment>)p_),
                Contact = new List<Patient.ContactComponent>((IEnumerable<Patient.ContactComponent>)q_),
                Communication = new List<Patient.CommunicationComponent>((IEnumerable<Patient.CommunicationComponent>)r_),
                GeneralPractitioner = new List<ResourceReference>((IEnumerable<ResourceReference>)s_),
                ManagingOrganization = t_,
                Link = new List<Patient.LinkComponent>((IEnumerable<Patient.LinkComponent>)u_),
            };
            return v_;
        }

        IEnumerable<Patient> c_ = context.Operators.Select<Patient, Patient>((IEnumerable<Patient>)a_, b_);
        IEnumerable<Patient> d_ = context.Operators.Distinct<Patient>(c_);
        Patient e_ = context.Operators.SingletonFrom<Patient>(d_);
        return e_;
    }


    [CqlFunctionDefinition("PaymentNoticeResource")]
    public PaymentNotice PaymentNoticeResource(CqlContext context, PaymentNotice arg)
    {
        PaymentNotice[] a_ = [
            arg,
        ];

        PaymentNotice b_(PaymentNotice a) {
            List<Identifier> f_ = a?.Identifier;
            Code<FinancialResourceStatusCodes> g_ = a?.StatusElement;
            ResourceReference h_ = a?.Request;
            ResourceReference i_ = a?.Response;
            FhirDateTime j_ = a?.CreatedElement;
            ResourceReference k_ = a?.Provider;
            ResourceReference l_ = a?.Payment;
            Date m_ = a?.PaymentDateElement;
            ResourceReference n_ = a?.Payee;
            ResourceReference o_ = a?.Recipient;
            Money p_ = a?.Amount;
            CodeableConcept q_ = a?.PaymentStatus;
            PaymentNotice r_ = new PaymentNotice
            {
                Identifier = new List<Identifier>((IEnumerable<Identifier>)f_),
                StatusElement = g_,
                Request = h_,
                Response = i_,
                CreatedElement = j_,
                Provider = k_,
                Payment = l_,
                PaymentDateElement = m_,
                Payee = n_,
                Recipient = o_,
                Amount = p_,
                PaymentStatus = q_,
            };
            return r_;
        }

        IEnumerable<PaymentNotice> c_ = context.Operators.Select<PaymentNotice, PaymentNotice>((IEnumerable<PaymentNotice>)a_, b_);
        IEnumerable<PaymentNotice> d_ = context.Operators.Distinct<PaymentNotice>(c_);
        PaymentNotice e_ = context.Operators.SingletonFrom<PaymentNotice>(d_);
        return e_;
    }


    [CqlFunctionDefinition("PaymentReconciliationResource")]
    public PaymentReconciliation PaymentReconciliationResource(CqlContext context, PaymentReconciliation arg)
    {
        PaymentReconciliation[] a_ = [
            arg,
        ];

        PaymentReconciliation b_(PaymentReconciliation a) {
            List<Identifier> f_ = a?.Identifier;
            Code<FinancialResourceStatusCodes> g_ = a?.StatusElement;
            Period h_ = a?.Period;
            FhirDateTime i_ = a?.CreatedElement;
            ResourceReference j_ = a?.PaymentIssuer;
            ResourceReference k_ = a?.Request;
            ResourceReference l_ = a?.Requestor;
            Code<ClaimProcessingCodes> m_ = a?.OutcomeElement;
            FhirString n_ = a?.DispositionElement;
            Date o_ = a?.PaymentDateElement;
            Money p_ = a?.PaymentAmount;
            Identifier q_ = a?.PaymentIdentifier;
            List<PaymentReconciliation.DetailsComponent> r_ = a?.Detail;
            CodeableConcept s_ = a?.FormCode;
            List<PaymentReconciliation.NotesComponent> t_ = a?.ProcessNote;
            PaymentReconciliation u_ = new PaymentReconciliation
            {
                Identifier = new List<Identifier>((IEnumerable<Identifier>)f_),
                StatusElement = g_,
                Period = h_,
                CreatedElement = i_,
                PaymentIssuer = j_,
                Request = k_,
                Requestor = l_,
                OutcomeElement = m_,
                DispositionElement = n_,
                PaymentDateElement = o_,
                PaymentAmount = p_,
                PaymentIdentifier = q_,
                Detail = new List<PaymentReconciliation.DetailsComponent>((IEnumerable<PaymentReconciliation.DetailsComponent>)r_),
                FormCode = s_,
                ProcessNote = new List<PaymentReconciliation.NotesComponent>((IEnumerable<PaymentReconciliation.NotesComponent>)t_),
            };
            return u_;
        }

        IEnumerable<PaymentReconciliation> c_ = context.Operators.Select<PaymentReconciliation, PaymentReconciliation>((IEnumerable<PaymentReconciliation>)a_, b_);
        IEnumerable<PaymentReconciliation> d_ = context.Operators.Distinct<PaymentReconciliation>(c_);
        PaymentReconciliation e_ = context.Operators.SingletonFrom<PaymentReconciliation>(d_);
        return e_;
    }


    [CqlFunctionDefinition("PersonResource")]
    public Person PersonResource(CqlContext context, Person arg)
    {
        Person[] a_ = [
            arg,
        ];

        Person b_(Person a) {
            List<Identifier> f_ = a?.Identifier;
            List<HumanName> g_ = a?.Name;
            List<ContactPoint> h_ = a?.Telecom;
            Code<AdministrativeGender> i_ = a?.GenderElement;
            Date j_ = a?.BirthDateElement;
            List<Address> k_ = a?.Address;
            Attachment l_ = a?.Photo;
            ResourceReference m_ = a?.ManagingOrganization;
            FhirBoolean n_ = a?.ActiveElement;
            List<Person.LinkComponent> o_ = a?.Link;
            Person p_ = new Person
            {
                Identifier = new List<Identifier>((IEnumerable<Identifier>)f_),
                Name = new List<HumanName>((IEnumerable<HumanName>)g_),
                Telecom = new List<ContactPoint>((IEnumerable<ContactPoint>)h_),
                GenderElement = i_,
                BirthDateElement = j_,
                Address = new List<Address>((IEnumerable<Address>)k_),
                Photo = l_,
                ManagingOrganization = m_,
                ActiveElement = n_,
                Link = new List<Person.LinkComponent>((IEnumerable<Person.LinkComponent>)o_),
            };
            return p_;
        }

        IEnumerable<Person> c_ = context.Operators.Select<Person, Person>((IEnumerable<Person>)a_, b_);
        IEnumerable<Person> d_ = context.Operators.Distinct<Person>(c_);
        Person e_ = context.Operators.SingletonFrom<Person>(d_);
        return e_;
    }


    [CqlFunctionDefinition("PlanDefinitionResource")]
    public PlanDefinition PlanDefinitionResource(CqlContext context, PlanDefinition arg)
    {
        PlanDefinition[] a_ = [
            arg,
        ];

        PlanDefinition b_(PlanDefinition a) {
            FhirUri f_ = a?.UrlElement;
            List<Identifier> g_ = a?.Identifier;
            FhirString h_ = a?.VersionElement;
            FhirString i_ = a?.NameElement;
            FhirString j_ = a?.TitleElement;
            FhirString k_ = a?.SubtitleElement;
            CodeableConcept l_ = a?.Type;
            Code<PublicationStatus> m_ = a?.StatusElement;
            FhirBoolean n_ = a?.ExperimentalElement;
            DataType o_ = a?.Subject;
            FhirDateTime p_ = a?.DateElement;
            FhirString q_ = a?.PublisherElement;
            List<ContactDetail> r_ = a?.Contact;
            Markdown s_ = a?.DescriptionElement;
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
            List<PlanDefinition.GoalComponent> ai_ = a?.Goal;
            List<PlanDefinition.ActionComponent> aj_ = a?.Action;
            PlanDefinition ak_ = new PlanDefinition
            {
                UrlElement = f_,
                Identifier = new List<Identifier>((IEnumerable<Identifier>)g_),
                VersionElement = h_,
                NameElement = i_,
                TitleElement = j_,
                SubtitleElement = k_,
                Type = l_,
                StatusElement = m_,
                ExperimentalElement = n_,
                Subject = (DataType)o_,
                DateElement = p_,
                PublisherElement = q_,
                Contact = new List<ContactDetail>((IEnumerable<ContactDetail>)r_),
                DescriptionElement = s_,
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
                Goal = new List<PlanDefinition.GoalComponent>((IEnumerable<PlanDefinition.GoalComponent>)ai_),
                Action = new List<PlanDefinition.ActionComponent>((IEnumerable<PlanDefinition.ActionComponent>)aj_),
            };
            return ak_;
        }

        IEnumerable<PlanDefinition> c_ = context.Operators.Select<PlanDefinition, PlanDefinition>((IEnumerable<PlanDefinition>)a_, b_);
        IEnumerable<PlanDefinition> d_ = context.Operators.Distinct<PlanDefinition>(c_);
        PlanDefinition e_ = context.Operators.SingletonFrom<PlanDefinition>(d_);
        return e_;
    }


    [CqlFunctionDefinition("PractitionerResource")]
    public Practitioner PractitionerResource(CqlContext context, Practitioner arg)
    {
        Practitioner[] a_ = [
            arg,
        ];

        Practitioner b_(Practitioner a) {
            List<Identifier> f_ = a?.Identifier;
            FhirBoolean g_ = a?.ActiveElement;
            List<HumanName> h_ = a?.Name;
            List<ContactPoint> i_ = a?.Telecom;
            List<Address> j_ = a?.Address;
            Code<AdministrativeGender> k_ = a?.GenderElement;
            Date l_ = a?.BirthDateElement;
            List<Attachment> m_ = a?.Photo;
            List<Practitioner.QualificationComponent> n_ = a?.Qualification;
            List<CodeableConcept> o_ = a?.Communication;
            Practitioner p_ = new Practitioner
            {
                Identifier = new List<Identifier>((IEnumerable<Identifier>)f_),
                ActiveElement = g_,
                Name = new List<HumanName>((IEnumerable<HumanName>)h_),
                Telecom = new List<ContactPoint>((IEnumerable<ContactPoint>)i_),
                Address = new List<Address>((IEnumerable<Address>)j_),
                GenderElement = k_,
                BirthDateElement = l_,
                Photo = new List<Attachment>((IEnumerable<Attachment>)m_),
                Qualification = new List<Practitioner.QualificationComponent>((IEnumerable<Practitioner.QualificationComponent>)n_),
                Communication = new List<CodeableConcept>((IEnumerable<CodeableConcept>)o_),
            };
            return p_;
        }

        IEnumerable<Practitioner> c_ = context.Operators.Select<Practitioner, Practitioner>((IEnumerable<Practitioner>)a_, b_);
        IEnumerable<Practitioner> d_ = context.Operators.Distinct<Practitioner>(c_);
        Practitioner e_ = context.Operators.SingletonFrom<Practitioner>(d_);
        return e_;
    }


    [CqlFunctionDefinition("PractitionerRoleResource")]
    public PractitionerRole PractitionerRoleResource(CqlContext context, PractitionerRole arg)
    {
        PractitionerRole[] a_ = [
            arg,
        ];

        PractitionerRole b_(PractitionerRole a) {
            List<Identifier> f_ = a?.Identifier;
            FhirBoolean g_ = a?.ActiveElement;
            Period h_ = a?.Period;
            ResourceReference i_ = a?.Practitioner;
            ResourceReference j_ = a?.Organization;
            List<CodeableConcept> k_ = a?.Code;
            List<CodeableConcept> l_ = a?.Specialty;
            List<ResourceReference> m_ = a?.Location;
            List<ResourceReference> n_ = a?.HealthcareService;
            List<ContactPoint> o_ = a?.Telecom;
            List<PractitionerRole.AvailableTimeComponent> p_ = a?.AvailableTime;
            List<PractitionerRole.NotAvailableComponent> q_ = a?.NotAvailable;
            FhirString r_ = a?.AvailabilityExceptionsElement;
            List<ResourceReference> s_ = a?.Endpoint;
            PractitionerRole t_ = new PractitionerRole
            {
                Identifier = new List<Identifier>((IEnumerable<Identifier>)f_),
                ActiveElement = g_,
                Period = h_,
                Practitioner = i_,
                Organization = j_,
                Code = new List<CodeableConcept>((IEnumerable<CodeableConcept>)k_),
                Specialty = new List<CodeableConcept>((IEnumerable<CodeableConcept>)l_),
                Location = new List<ResourceReference>((IEnumerable<ResourceReference>)m_),
                HealthcareService = new List<ResourceReference>((IEnumerable<ResourceReference>)n_),
                Telecom = new List<ContactPoint>((IEnumerable<ContactPoint>)o_),
                AvailableTime = new List<PractitionerRole.AvailableTimeComponent>((IEnumerable<PractitionerRole.AvailableTimeComponent>)p_),
                NotAvailable = new List<PractitionerRole.NotAvailableComponent>((IEnumerable<PractitionerRole.NotAvailableComponent>)q_),
                AvailabilityExceptionsElement = r_,
                Endpoint = new List<ResourceReference>((IEnumerable<ResourceReference>)s_),
            };
            return t_;
        }

        IEnumerable<PractitionerRole> c_ = context.Operators.Select<PractitionerRole, PractitionerRole>((IEnumerable<PractitionerRole>)a_, b_);
        IEnumerable<PractitionerRole> d_ = context.Operators.Distinct<PractitionerRole>(c_);
        PractitionerRole e_ = context.Operators.SingletonFrom<PractitionerRole>(d_);
        return e_;
    }


    [CqlFunctionDefinition("ProcedureResource")]
    public Procedure ProcedureResource(CqlContext context, Procedure arg)
    {
        Procedure[] a_ = [
            arg,
        ];

        Procedure b_(Procedure a) {
            List<Identifier> f_ = a?.Identifier;
            List<Canonical> g_ = a?.InstantiatesCanonicalElement;
            List<FhirUri> h_ = a?.InstantiatesUriElement;
            List<ResourceReference> i_ = a?.BasedOn;
            List<ResourceReference> j_ = a?.PartOf;
            Code<EventStatus> k_ = a?.StatusElement;
            CodeableConcept l_ = a?.StatusReason;
            CodeableConcept m_ = a?.Category;
            CodeableConcept n_ = a?.Code;
            ResourceReference o_ = a?.Subject;
            ResourceReference p_ = a?.Encounter;
            DataType q_ = a?.Performed;
            ResourceReference r_ = a?.Recorder;
            ResourceReference s_ = a?.Asserter;
            List<Procedure.PerformerComponent> t_ = a?.Performer;
            ResourceReference u_ = a?.Location;
            List<CodeableConcept> v_ = a?.ReasonCode;
            List<ResourceReference> w_ = a?.ReasonReference;
            List<CodeableConcept> x_ = a?.BodySite;
            CodeableConcept y_ = a?.Outcome;
            List<ResourceReference> z_ = a?.Report;
            List<CodeableConcept> aa_ = a?.Complication;
            List<ResourceReference> ab_ = a?.ComplicationDetail;
            List<CodeableConcept> ac_ = a?.FollowUp;
            List<Annotation> ad_ = a?.Note;
            List<Procedure.FocalDeviceComponent> ae_ = a?.FocalDevice;
            List<ResourceReference> af_ = a?.UsedReference;
            List<CodeableConcept> ag_ = a?.UsedCode;
            Procedure ah_ = new Procedure
            {
                Identifier = new List<Identifier>((IEnumerable<Identifier>)f_),
                InstantiatesCanonicalElement = new List<Canonical>((IEnumerable<Canonical>)g_),
                InstantiatesUriElement = new List<FhirUri>((IEnumerable<FhirUri>)h_),
                BasedOn = new List<ResourceReference>((IEnumerable<ResourceReference>)i_),
                PartOf = new List<ResourceReference>((IEnumerable<ResourceReference>)j_),
                StatusElement = k_,
                StatusReason = l_,
                Category = m_,
                Code = n_,
                Subject = o_,
                Encounter = p_,
                Performed = (DataType)q_,
                Recorder = r_,
                Asserter = s_,
                Performer = new List<Procedure.PerformerComponent>((IEnumerable<Procedure.PerformerComponent>)t_),
                Location = u_,
                ReasonCode = new List<CodeableConcept>((IEnumerable<CodeableConcept>)v_),
                ReasonReference = new List<ResourceReference>((IEnumerable<ResourceReference>)w_),
                BodySite = new List<CodeableConcept>((IEnumerable<CodeableConcept>)x_),
                Outcome = y_,
                Report = new List<ResourceReference>((IEnumerable<ResourceReference>)z_),
                Complication = new List<CodeableConcept>((IEnumerable<CodeableConcept>)aa_),
                ComplicationDetail = new List<ResourceReference>((IEnumerable<ResourceReference>)ab_),
                FollowUp = new List<CodeableConcept>((IEnumerable<CodeableConcept>)ac_),
                Note = new List<Annotation>((IEnumerable<Annotation>)ad_),
                FocalDevice = new List<Procedure.FocalDeviceComponent>((IEnumerable<Procedure.FocalDeviceComponent>)ae_),
                UsedReference = new List<ResourceReference>((IEnumerable<ResourceReference>)af_),
                UsedCode = new List<CodeableConcept>((IEnumerable<CodeableConcept>)ag_),
            };
            return ah_;
        }

        IEnumerable<Procedure> c_ = context.Operators.Select<Procedure, Procedure>((IEnumerable<Procedure>)a_, b_);
        IEnumerable<Procedure> d_ = context.Operators.Distinct<Procedure>(c_);
        Procedure e_ = context.Operators.SingletonFrom<Procedure>(d_);
        return e_;
    }


    [CqlFunctionDefinition("ProvenanceResource")]
    public Provenance ProvenanceResource(CqlContext context, Provenance arg)
    {
        Provenance[] a_ = [
            arg,
        ];

        Provenance b_(Provenance a) {
            List<ResourceReference> f_ = a?.Target;
            DataType g_ = a?.Occurred;
            Instant h_ = a?.RecordedElement;
            List<FhirUri> i_ = a?.PolicyElement;
            ResourceReference j_ = a?.Location;
            List<CodeableConcept> k_ = a?.Reason;
            CodeableConcept l_ = a?.Activity;
            List<Provenance.AgentComponent> m_ = a?.Agent;
            List<Provenance.EntityComponent> n_ = a?.Entity;
            List<Signature> o_ = a?.Signature;
            Provenance p_ = new Provenance
            {
                Target = new List<ResourceReference>((IEnumerable<ResourceReference>)f_),
                Occurred = (DataType)g_,
                RecordedElement = h_,
                PolicyElement = new List<FhirUri>((IEnumerable<FhirUri>)i_),
                Location = j_,
                Reason = new List<CodeableConcept>((IEnumerable<CodeableConcept>)k_),
                Activity = l_,
                Agent = new List<Provenance.AgentComponent>((IEnumerable<Provenance.AgentComponent>)m_),
                Entity = new List<Provenance.EntityComponent>((IEnumerable<Provenance.EntityComponent>)n_),
                Signature = new List<Signature>((IEnumerable<Signature>)o_),
            };
            return p_;
        }

        IEnumerable<Provenance> c_ = context.Operators.Select<Provenance, Provenance>((IEnumerable<Provenance>)a_, b_);
        IEnumerable<Provenance> d_ = context.Operators.Distinct<Provenance>(c_);
        Provenance e_ = context.Operators.SingletonFrom<Provenance>(d_);
        return e_;
    }


    [CqlFunctionDefinition("QuestionnaireResponseResource")]
    public QuestionnaireResponse QuestionnaireResponseResource(CqlContext context, QuestionnaireResponse arg)
    {
        QuestionnaireResponse[] a_ = [
            arg,
        ];

        QuestionnaireResponse b_(QuestionnaireResponse a) {
            Identifier f_ = a?.Identifier;
            List<ResourceReference> g_ = a?.BasedOn;
            List<ResourceReference> h_ = a?.PartOf;
            Canonical i_ = a?.QuestionnaireElement;
            Code<QuestionnaireResponse.QuestionnaireResponseStatus> j_ = a?.StatusElement;
            ResourceReference k_ = a?.Subject;
            ResourceReference l_ = a?.Encounter;
            FhirDateTime m_ = a?.AuthoredElement;
            ResourceReference n_ = a?.Author;
            ResourceReference o_ = a?.Source;
            List<QuestionnaireResponse.ItemComponent> p_ = a?.Item;
            QuestionnaireResponse q_ = new QuestionnaireResponse
            {
                Identifier = f_,
                BasedOn = new List<ResourceReference>((IEnumerable<ResourceReference>)g_),
                PartOf = new List<ResourceReference>((IEnumerable<ResourceReference>)h_),
                QuestionnaireElement = i_,
                StatusElement = j_,
                Subject = k_,
                Encounter = l_,
                AuthoredElement = m_,
                Author = n_,
                Source = o_,
                Item = new List<QuestionnaireResponse.ItemComponent>((IEnumerable<QuestionnaireResponse.ItemComponent>)p_),
            };
            return q_;
        }

        IEnumerable<QuestionnaireResponse> c_ = context.Operators.Select<QuestionnaireResponse, QuestionnaireResponse>((IEnumerable<QuestionnaireResponse>)a_, b_);
        IEnumerable<QuestionnaireResponse> d_ = context.Operators.Distinct<QuestionnaireResponse>(c_);
        QuestionnaireResponse e_ = context.Operators.SingletonFrom<QuestionnaireResponse>(d_);
        return e_;
    }


    [CqlFunctionDefinition("RelatedPersonResource")]
    public RelatedPerson RelatedPersonResource(CqlContext context, RelatedPerson arg)
    {
        RelatedPerson[] a_ = [
            arg,
        ];

        RelatedPerson b_(RelatedPerson a) {
            List<Identifier> f_ = a?.Identifier;
            FhirBoolean g_ = a?.ActiveElement;
            ResourceReference h_ = a?.Patient;
            List<CodeableConcept> i_ = a?.Relationship;
            List<HumanName> j_ = a?.Name;
            List<ContactPoint> k_ = a?.Telecom;
            Code<AdministrativeGender> l_ = a?.GenderElement;
            Date m_ = a?.BirthDateElement;
            List<Address> n_ = a?.Address;
            List<Attachment> o_ = a?.Photo;
            Period p_ = a?.Period;
            List<RelatedPerson.CommunicationComponent> q_ = a?.Communication;
            RelatedPerson r_ = new RelatedPerson
            {
                Identifier = new List<Identifier>((IEnumerable<Identifier>)f_),
                ActiveElement = g_,
                Patient = h_,
                Relationship = new List<CodeableConcept>((IEnumerable<CodeableConcept>)i_),
                Name = new List<HumanName>((IEnumerable<HumanName>)j_),
                Telecom = new List<ContactPoint>((IEnumerable<ContactPoint>)k_),
                GenderElement = l_,
                BirthDateElement = m_,
                Address = new List<Address>((IEnumerable<Address>)n_),
                Photo = new List<Attachment>((IEnumerable<Attachment>)o_),
                Period = p_,
                Communication = new List<RelatedPerson.CommunicationComponent>((IEnumerable<RelatedPerson.CommunicationComponent>)q_),
            };
            return r_;
        }

        IEnumerable<RelatedPerson> c_ = context.Operators.Select<RelatedPerson, RelatedPerson>((IEnumerable<RelatedPerson>)a_, b_);
        IEnumerable<RelatedPerson> d_ = context.Operators.Distinct<RelatedPerson>(c_);
        RelatedPerson e_ = context.Operators.SingletonFrom<RelatedPerson>(d_);
        return e_;
    }


    [CqlFunctionDefinition("RequestGroupResource")]
    public RequestGroup RequestGroupResource(CqlContext context, RequestGroup arg)
    {
        RequestGroup[] a_ = [
            arg,
        ];

        RequestGroup b_(RequestGroup a) {
            List<Identifier> f_ = a?.Identifier;
            List<Canonical> g_ = a?.InstantiatesCanonicalElement;
            List<FhirUri> h_ = a?.InstantiatesUriElement;
            List<ResourceReference> i_ = a?.BasedOn;
            List<ResourceReference> j_ = a?.Replaces;
            Identifier k_ = a?.GroupIdentifier;
            Code<RequestStatus> l_ = a?.StatusElement;
            Code<RequestIntent> m_ = a?.IntentElement;
            Code<RequestPriority> n_ = a?.PriorityElement;
            CodeableConcept o_ = a?.Code;
            ResourceReference p_ = a?.Subject;
            ResourceReference q_ = a?.Encounter;
            FhirDateTime r_ = a?.AuthoredOnElement;
            ResourceReference s_ = a?.Author;
            List<CodeableConcept> t_ = a?.ReasonCode;
            List<ResourceReference> u_ = a?.ReasonReference;
            List<Annotation> v_ = a?.Note;
            List<RequestGroup.ActionComponent> w_ = a?.Action;
            RequestGroup x_ = new RequestGroup
            {
                Identifier = new List<Identifier>((IEnumerable<Identifier>)f_),
                InstantiatesCanonicalElement = new List<Canonical>((IEnumerable<Canonical>)g_),
                InstantiatesUriElement = new List<FhirUri>((IEnumerable<FhirUri>)h_),
                BasedOn = new List<ResourceReference>((IEnumerable<ResourceReference>)i_),
                Replaces = new List<ResourceReference>((IEnumerable<ResourceReference>)j_),
                GroupIdentifier = k_,
                StatusElement = l_,
                IntentElement = m_,
                PriorityElement = n_,
                Code = o_,
                Subject = p_,
                Encounter = q_,
                AuthoredOnElement = r_,
                Author = s_,
                ReasonCode = new List<CodeableConcept>((IEnumerable<CodeableConcept>)t_),
                ReasonReference = new List<ResourceReference>((IEnumerable<ResourceReference>)u_),
                Note = new List<Annotation>((IEnumerable<Annotation>)v_),
                Action = new List<RequestGroup.ActionComponent>((IEnumerable<RequestGroup.ActionComponent>)w_),
            };
            return x_;
        }

        IEnumerable<RequestGroup> c_ = context.Operators.Select<RequestGroup, RequestGroup>((IEnumerable<RequestGroup>)a_, b_);
        IEnumerable<RequestGroup> d_ = context.Operators.Distinct<RequestGroup>(c_);
        RequestGroup e_ = context.Operators.SingletonFrom<RequestGroup>(d_);
        return e_;
    }


    [CqlFunctionDefinition("ResearchDefinitionResource")]
    public ResearchDefinition ResearchDefinitionResource(CqlContext context, ResearchDefinition arg)
    {
        ResearchDefinition[] a_ = [
            arg,
        ];

        ResearchDefinition b_(ResearchDefinition a) {
            FhirUri f_ = a?.UrlElement;
            List<Identifier> g_ = a?.Identifier;
            FhirString h_ = a?.VersionElement;
            FhirString i_ = a?.NameElement;
            FhirString j_ = a?.TitleElement;
            FhirString k_ = a?.ShortTitleElement;
            FhirString l_ = a?.SubtitleElement;
            Code<PublicationStatus> m_ = a?.StatusElement;
            FhirBoolean n_ = a?.ExperimentalElement;
            DataType o_ = a?.Subject;
            FhirDateTime p_ = a?.DateElement;
            FhirString q_ = a?.PublisherElement;
            List<ContactDetail> r_ = a?.Contact;
            Markdown s_ = a?.DescriptionElement;
            List<FhirString> t_ = a?.CommentElement;
            List<UsageContext> u_ = a?.UseContext;
            List<CodeableConcept> v_ = a?.Jurisdiction;
            Markdown w_ = a?.PurposeElement;
            FhirString x_ = a?.UsageElement;
            Markdown y_ = a?.CopyrightElement;
            Date z_ = a?.ApprovalDateElement;
            Date aa_ = a?.LastReviewDateElement;
            Period ab_ = a?.EffectivePeriod;
            List<CodeableConcept> ac_ = a?.Topic;
            List<ContactDetail> ad_ = a?.Author;
            List<ContactDetail> ae_ = a?.Editor;
            List<ContactDetail> af_ = a?.Reviewer;
            List<ContactDetail> ag_ = a?.Endorser;
            List<RelatedArtifact> ah_ = a?.RelatedArtifact;
            List<Canonical> ai_ = a?.LibraryElement;
            ResourceReference aj_ = a?.Population;
            ResourceReference ak_ = a?.Exposure;
            ResourceReference al_ = a?.ExposureAlternative;
            ResourceReference am_ = a?.Outcome;
            ResearchDefinition an_ = new ResearchDefinition
            {
                UrlElement = f_,
                Identifier = new List<Identifier>((IEnumerable<Identifier>)g_),
                VersionElement = h_,
                NameElement = i_,
                TitleElement = j_,
                ShortTitleElement = k_,
                SubtitleElement = l_,
                StatusElement = m_,
                ExperimentalElement = n_,
                Subject = (DataType)o_,
                DateElement = p_,
                PublisherElement = q_,
                Contact = new List<ContactDetail>((IEnumerable<ContactDetail>)r_),
                DescriptionElement = s_,
                CommentElement = new List<FhirString>((IEnumerable<FhirString>)t_),
                UseContext = new List<UsageContext>((IEnumerable<UsageContext>)u_),
                Jurisdiction = new List<CodeableConcept>((IEnumerable<CodeableConcept>)v_),
                PurposeElement = w_,
                UsageElement = x_,
                CopyrightElement = y_,
                ApprovalDateElement = z_,
                LastReviewDateElement = aa_,
                EffectivePeriod = ab_,
                Topic = new List<CodeableConcept>((IEnumerable<CodeableConcept>)ac_),
                Author = new List<ContactDetail>((IEnumerable<ContactDetail>)ad_),
                Editor = new List<ContactDetail>((IEnumerable<ContactDetail>)ae_),
                Reviewer = new List<ContactDetail>((IEnumerable<ContactDetail>)af_),
                Endorser = new List<ContactDetail>((IEnumerable<ContactDetail>)ag_),
                RelatedArtifact = new List<RelatedArtifact>((IEnumerable<RelatedArtifact>)ah_),
                LibraryElement = new List<Canonical>((IEnumerable<Canonical>)ai_),
                Population = aj_,
                Exposure = ak_,
                ExposureAlternative = al_,
                Outcome = am_,
            };
            return an_;
        }

        IEnumerable<ResearchDefinition> c_ = context.Operators.Select<ResearchDefinition, ResearchDefinition>((IEnumerable<ResearchDefinition>)a_, b_);
        IEnumerable<ResearchDefinition> d_ = context.Operators.Distinct<ResearchDefinition>(c_);
        ResearchDefinition e_ = context.Operators.SingletonFrom<ResearchDefinition>(d_);
        return e_;
    }


    [CqlFunctionDefinition("ResearchElementDefinitionResource")]
    public ResearchElementDefinition ResearchElementDefinitionResource(CqlContext context, ResearchElementDefinition arg)
    {
        ResearchElementDefinition[] a_ = [
            arg,
        ];

        ResearchElementDefinition b_(ResearchElementDefinition a) {
            FhirUri f_ = a?.UrlElement;
            List<Identifier> g_ = a?.Identifier;
            FhirString h_ = a?.VersionElement;
            FhirString i_ = a?.NameElement;
            FhirString j_ = a?.TitleElement;
            FhirString k_ = a?.ShortTitleElement;
            FhirString l_ = a?.SubtitleElement;
            Code<PublicationStatus> m_ = a?.StatusElement;
            FhirBoolean n_ = a?.ExperimentalElement;
            DataType o_ = a?.Subject;
            FhirDateTime p_ = a?.DateElement;
            FhirString q_ = a?.PublisherElement;
            List<ContactDetail> r_ = a?.Contact;
            Markdown s_ = a?.DescriptionElement;
            List<FhirString> t_ = a?.CommentElement;
            List<UsageContext> u_ = a?.UseContext;
            List<CodeableConcept> v_ = a?.Jurisdiction;
            Markdown w_ = a?.PurposeElement;
            FhirString x_ = a?.UsageElement;
            Markdown y_ = a?.CopyrightElement;
            Date z_ = a?.ApprovalDateElement;
            Date aa_ = a?.LastReviewDateElement;
            Period ab_ = a?.EffectivePeriod;
            List<CodeableConcept> ac_ = a?.Topic;
            List<ContactDetail> ad_ = a?.Author;
            List<ContactDetail> ae_ = a?.Editor;
            List<ContactDetail> af_ = a?.Reviewer;
            List<ContactDetail> ag_ = a?.Endorser;
            List<RelatedArtifact> ah_ = a?.RelatedArtifact;
            List<Canonical> ai_ = a?.LibraryElement;
            Code<ResearchElementDefinition.ResearchElementType> aj_ = a?.TypeElement;
            Code<VariableTypeCode> ak_ = a?.VariableTypeElement;
            List<ResearchElementDefinition.CharacteristicComponent> al_ = a?.Characteristic;
            ResearchElementDefinition am_ = new ResearchElementDefinition
            {
                UrlElement = f_,
                Identifier = new List<Identifier>((IEnumerable<Identifier>)g_),
                VersionElement = h_,
                NameElement = i_,
                TitleElement = j_,
                ShortTitleElement = k_,
                SubtitleElement = l_,
                StatusElement = m_,
                ExperimentalElement = n_,
                Subject = (DataType)o_,
                DateElement = p_,
                PublisherElement = q_,
                Contact = new List<ContactDetail>((IEnumerable<ContactDetail>)r_),
                DescriptionElement = s_,
                CommentElement = new List<FhirString>((IEnumerable<FhirString>)t_),
                UseContext = new List<UsageContext>((IEnumerable<UsageContext>)u_),
                Jurisdiction = new List<CodeableConcept>((IEnumerable<CodeableConcept>)v_),
                PurposeElement = w_,
                UsageElement = x_,
                CopyrightElement = y_,
                ApprovalDateElement = z_,
                LastReviewDateElement = aa_,
                EffectivePeriod = ab_,
                Topic = new List<CodeableConcept>((IEnumerable<CodeableConcept>)ac_),
                Author = new List<ContactDetail>((IEnumerable<ContactDetail>)ad_),
                Editor = new List<ContactDetail>((IEnumerable<ContactDetail>)ae_),
                Reviewer = new List<ContactDetail>((IEnumerable<ContactDetail>)af_),
                Endorser = new List<ContactDetail>((IEnumerable<ContactDetail>)ag_),
                RelatedArtifact = new List<RelatedArtifact>((IEnumerable<RelatedArtifact>)ah_),
                LibraryElement = new List<Canonical>((IEnumerable<Canonical>)ai_),
                TypeElement = aj_,
                VariableTypeElement = ak_,
                Characteristic = new List<ResearchElementDefinition.CharacteristicComponent>((IEnumerable<ResearchElementDefinition.CharacteristicComponent>)al_),
            };
            return am_;
        }

        IEnumerable<ResearchElementDefinition> c_ = context.Operators.Select<ResearchElementDefinition, ResearchElementDefinition>((IEnumerable<ResearchElementDefinition>)a_, b_);
        IEnumerable<ResearchElementDefinition> d_ = context.Operators.Distinct<ResearchElementDefinition>(c_);
        ResearchElementDefinition e_ = context.Operators.SingletonFrom<ResearchElementDefinition>(d_);
        return e_;
    }


    [CqlFunctionDefinition("ResearchStudyResource")]
    public ResearchStudy ResearchStudyResource(CqlContext context, ResearchStudy arg)
    {
        ResearchStudy[] a_ = [
            arg,
        ];

        ResearchStudy b_(ResearchStudy a) {
            List<Identifier> f_ = a?.Identifier;
            FhirString g_ = a?.TitleElement;
            List<ResourceReference> h_ = a?.Protocol;
            List<ResourceReference> i_ = a?.PartOf;
            Code<ResearchStudy.ResearchStudyStatus> j_ = a?.StatusElement;
            CodeableConcept k_ = a?.PrimaryPurposeType;
            CodeableConcept l_ = a?.Phase;
            List<CodeableConcept> m_ = a?.Category;
            List<CodeableConcept> n_ = a?.Focus;
            List<CodeableConcept> o_ = a?.Condition;
            List<ContactDetail> p_ = a?.Contact;
            List<RelatedArtifact> q_ = a?.RelatedArtifact;
            List<CodeableConcept> r_ = a?.Keyword;
            List<CodeableConcept> s_ = a?.Location;
            Markdown t_ = a?.DescriptionElement;
            List<ResourceReference> u_ = a?.Enrollment;
            Period v_ = a?.Period;
            ResourceReference w_ = a?.Sponsor;
            ResourceReference x_ = a?.PrincipalInvestigator;
            List<ResourceReference> y_ = a?.Site;
            CodeableConcept z_ = a?.ReasonStopped;
            List<Annotation> aa_ = a?.Note;
            List<ResearchStudy.ArmComponent> ab_ = a?.Arm;
            List<ResearchStudy.ObjectiveComponent> ac_ = a?.Objective;
            ResearchStudy ad_ = new ResearchStudy
            {
                Identifier = new List<Identifier>((IEnumerable<Identifier>)f_),
                TitleElement = g_,
                Protocol = new List<ResourceReference>((IEnumerable<ResourceReference>)h_),
                PartOf = new List<ResourceReference>((IEnumerable<ResourceReference>)i_),
                StatusElement = j_,
                PrimaryPurposeType = k_,
                Phase = l_,
                Category = new List<CodeableConcept>((IEnumerable<CodeableConcept>)m_),
                Focus = new List<CodeableConcept>((IEnumerable<CodeableConcept>)n_),
                Condition = new List<CodeableConcept>((IEnumerable<CodeableConcept>)o_),
                Contact = new List<ContactDetail>((IEnumerable<ContactDetail>)p_),
                RelatedArtifact = new List<RelatedArtifact>((IEnumerable<RelatedArtifact>)q_),
                Keyword = new List<CodeableConcept>((IEnumerable<CodeableConcept>)r_),
                Location = new List<CodeableConcept>((IEnumerable<CodeableConcept>)s_),
                DescriptionElement = t_,
                Enrollment = new List<ResourceReference>((IEnumerable<ResourceReference>)u_),
                Period = v_,
                Sponsor = w_,
                PrincipalInvestigator = x_,
                Site = new List<ResourceReference>((IEnumerable<ResourceReference>)y_),
                ReasonStopped = z_,
                Note = new List<Annotation>((IEnumerable<Annotation>)aa_),
                Arm = new List<ResearchStudy.ArmComponent>((IEnumerable<ResearchStudy.ArmComponent>)ab_),
                Objective = new List<ResearchStudy.ObjectiveComponent>((IEnumerable<ResearchStudy.ObjectiveComponent>)ac_),
            };
            return ad_;
        }

        IEnumerable<ResearchStudy> c_ = context.Operators.Select<ResearchStudy, ResearchStudy>((IEnumerable<ResearchStudy>)a_, b_);
        IEnumerable<ResearchStudy> d_ = context.Operators.Distinct<ResearchStudy>(c_);
        ResearchStudy e_ = context.Operators.SingletonFrom<ResearchStudy>(d_);
        return e_;
    }


    [CqlFunctionDefinition("ResearchSubjectResource")]
    public ResearchSubject ResearchSubjectResource(CqlContext context, ResearchSubject arg)
    {
        ResearchSubject[] a_ = [
            arg,
        ];

        ResearchSubject b_(ResearchSubject a) {
            List<Identifier> f_ = a?.Identifier;
            Code<ResearchSubject.ResearchSubjectStatus> g_ = a?.StatusElement;
            Period h_ = a?.Period;
            ResourceReference i_ = a?.Study;
            ResourceReference j_ = a?.Individual;
            FhirString k_ = a?.AssignedArmElement;
            FhirString l_ = a?.ActualArmElement;
            ResourceReference m_ = a?.Consent;
            ResearchSubject n_ = new ResearchSubject
            {
                Identifier = new List<Identifier>((IEnumerable<Identifier>)f_),
                StatusElement = g_,
                Period = h_,
                Study = i_,
                Individual = j_,
                AssignedArmElement = k_,
                ActualArmElement = l_,
                Consent = m_,
            };
            return n_;
        }

        IEnumerable<ResearchSubject> c_ = context.Operators.Select<ResearchSubject, ResearchSubject>((IEnumerable<ResearchSubject>)a_, b_);
        IEnumerable<ResearchSubject> d_ = context.Operators.Distinct<ResearchSubject>(c_);
        ResearchSubject e_ = context.Operators.SingletonFrom<ResearchSubject>(d_);
        return e_;
    }


    [CqlFunctionDefinition("RiskAssessmentResource")]
    public RiskAssessment RiskAssessmentResource(CqlContext context, RiskAssessment arg)
    {
        RiskAssessment[] a_ = [
            arg,
        ];

        RiskAssessment b_(RiskAssessment a) {
            List<Identifier> f_ = a?.Identifier;
            ResourceReference g_ = a?.BasedOn;
            ResourceReference h_ = a?.Parent;
            Code<ObservationStatus> i_ = a?.StatusElement;
            CodeableConcept j_ = a?.Method;
            CodeableConcept k_ = a?.Code;
            ResourceReference l_ = a?.Subject;
            ResourceReference m_ = a?.Encounter;
            DataType n_ = a?.Occurrence;
            ResourceReference o_ = a?.Condition;
            ResourceReference p_ = a?.Performer;
            List<CodeableConcept> q_ = a?.ReasonCode;
            List<ResourceReference> r_ = a?.ReasonReference;
            List<ResourceReference> s_ = a?.Basis;
            List<RiskAssessment.PredictionComponent> t_ = a?.Prediction;
            FhirString u_ = a?.MitigationElement;
            List<Annotation> v_ = a?.Note;
            RiskAssessment w_ = new RiskAssessment
            {
                Identifier = new List<Identifier>((IEnumerable<Identifier>)f_),
                BasedOn = g_,
                Parent = h_,
                StatusElement = i_,
                Method = j_,
                Code = k_,
                Subject = l_,
                Encounter = m_,
                Occurrence = (DataType)n_,
                Condition = o_,
                Performer = p_,
                ReasonCode = new List<CodeableConcept>((IEnumerable<CodeableConcept>)q_),
                ReasonReference = new List<ResourceReference>((IEnumerable<ResourceReference>)r_),
                Basis = new List<ResourceReference>((IEnumerable<ResourceReference>)s_),
                Prediction = new List<RiskAssessment.PredictionComponent>((IEnumerable<RiskAssessment.PredictionComponent>)t_),
                MitigationElement = u_,
                Note = new List<Annotation>((IEnumerable<Annotation>)v_),
            };
            return w_;
        }

        IEnumerable<RiskAssessment> c_ = context.Operators.Select<RiskAssessment, RiskAssessment>((IEnumerable<RiskAssessment>)a_, b_);
        IEnumerable<RiskAssessment> d_ = context.Operators.Distinct<RiskAssessment>(c_);
        RiskAssessment e_ = context.Operators.SingletonFrom<RiskAssessment>(d_);
        return e_;
    }


    [CqlFunctionDefinition("RiskEvidenceSynthesisResource")]
    public RiskEvidenceSynthesis RiskEvidenceSynthesisResource(CqlContext context, RiskEvidenceSynthesis arg)
    {
        RiskEvidenceSynthesis[] a_ = [
            arg,
        ];

        RiskEvidenceSynthesis b_(RiskEvidenceSynthesis a) {
            FhirUri f_ = a?.UrlElement;
            List<Identifier> g_ = a?.Identifier;
            FhirString h_ = a?.VersionElement;
            FhirString i_ = a?.NameElement;
            FhirString j_ = a?.TitleElement;
            Code<PublicationStatus> k_ = a?.StatusElement;
            FhirDateTime l_ = a?.DateElement;
            FhirString m_ = a?.PublisherElement;
            List<ContactDetail> n_ = a?.Contact;
            Markdown o_ = a?.DescriptionElement;
            List<Annotation> p_ = a?.Note;
            List<UsageContext> q_ = a?.UseContext;
            List<CodeableConcept> r_ = a?.Jurisdiction;
            Markdown s_ = a?.CopyrightElement;
            Date t_ = a?.ApprovalDateElement;
            Date u_ = a?.LastReviewDateElement;
            Period v_ = a?.EffectivePeriod;
            List<CodeableConcept> w_ = a?.Topic;
            List<ContactDetail> x_ = a?.Author;
            List<ContactDetail> y_ = a?.Editor;
            List<ContactDetail> z_ = a?.Reviewer;
            List<ContactDetail> aa_ = a?.Endorser;
            List<RelatedArtifact> ab_ = a?.RelatedArtifact;
            CodeableConcept ac_ = a?.SynthesisType;
            CodeableConcept ad_ = a?.StudyType;
            ResourceReference ae_ = a?.Population;
            ResourceReference af_ = a?.Exposure;
            ResourceReference ag_ = a?.Outcome;
            RiskEvidenceSynthesis.SampleSizeComponent ah_ = a?.SampleSize;
            RiskEvidenceSynthesis.RiskEstimateComponent ai_ = a?.RiskEstimate;
            List<RiskEvidenceSynthesis.CertaintyComponent> aj_ = a?.Certainty;
            RiskEvidenceSynthesis ak_ = new RiskEvidenceSynthesis
            {
                UrlElement = f_,
                Identifier = new List<Identifier>((IEnumerable<Identifier>)g_),
                VersionElement = h_,
                NameElement = i_,
                TitleElement = j_,
                StatusElement = k_,
                DateElement = l_,
                PublisherElement = m_,
                Contact = new List<ContactDetail>((IEnumerable<ContactDetail>)n_),
                DescriptionElement = o_,
                Note = new List<Annotation>((IEnumerable<Annotation>)p_),
                UseContext = new List<UsageContext>((IEnumerable<UsageContext>)q_),
                Jurisdiction = new List<CodeableConcept>((IEnumerable<CodeableConcept>)r_),
                CopyrightElement = s_,
                ApprovalDateElement = t_,
                LastReviewDateElement = u_,
                EffectivePeriod = v_,
                Topic = new List<CodeableConcept>((IEnumerable<CodeableConcept>)w_),
                Author = new List<ContactDetail>((IEnumerable<ContactDetail>)x_),
                Editor = new List<ContactDetail>((IEnumerable<ContactDetail>)y_),
                Reviewer = new List<ContactDetail>((IEnumerable<ContactDetail>)z_),
                Endorser = new List<ContactDetail>((IEnumerable<ContactDetail>)aa_),
                RelatedArtifact = new List<RelatedArtifact>((IEnumerable<RelatedArtifact>)ab_),
                SynthesisType = ac_,
                StudyType = ad_,
                Population = ae_,
                Exposure = af_,
                Outcome = ag_,
                SampleSize = ah_,
                RiskEstimate = ai_,
                Certainty = new List<RiskEvidenceSynthesis.CertaintyComponent>((IEnumerable<RiskEvidenceSynthesis.CertaintyComponent>)aj_),
            };
            return ak_;
        }

        IEnumerable<RiskEvidenceSynthesis> c_ = context.Operators.Select<RiskEvidenceSynthesis, RiskEvidenceSynthesis>((IEnumerable<RiskEvidenceSynthesis>)a_, b_);
        IEnumerable<RiskEvidenceSynthesis> d_ = context.Operators.Distinct<RiskEvidenceSynthesis>(c_);
        RiskEvidenceSynthesis e_ = context.Operators.SingletonFrom<RiskEvidenceSynthesis>(d_);
        return e_;
    }


    [CqlFunctionDefinition("ScheduleResource")]
    public Schedule ScheduleResource(CqlContext context, Schedule arg)
    {
        Schedule[] a_ = [
            arg,
        ];

        Schedule b_(Schedule a) {
            List<Identifier> f_ = a?.Identifier;
            FhirBoolean g_ = a?.ActiveElement;
            List<CodeableConcept> h_ = a?.ServiceCategory;
            List<CodeableConcept> i_ = a?.ServiceType;
            List<CodeableConcept> j_ = a?.Specialty;
            List<ResourceReference> k_ = a?.Actor;
            Period l_ = a?.PlanningHorizon;
            FhirString m_ = a?.CommentElement;
            Schedule n_ = new Schedule
            {
                Identifier = new List<Identifier>((IEnumerable<Identifier>)f_),
                ActiveElement = g_,
                ServiceCategory = new List<CodeableConcept>((IEnumerable<CodeableConcept>)h_),
                ServiceType = new List<CodeableConcept>((IEnumerable<CodeableConcept>)i_),
                Specialty = new List<CodeableConcept>((IEnumerable<CodeableConcept>)j_),
                Actor = new List<ResourceReference>((IEnumerable<ResourceReference>)k_),
                PlanningHorizon = l_,
                CommentElement = m_,
            };
            return n_;
        }

        IEnumerable<Schedule> c_ = context.Operators.Select<Schedule, Schedule>((IEnumerable<Schedule>)a_, b_);
        IEnumerable<Schedule> d_ = context.Operators.Distinct<Schedule>(c_);
        Schedule e_ = context.Operators.SingletonFrom<Schedule>(d_);
        return e_;
    }


    [CqlFunctionDefinition("ServiceRequestResource")]
    public ServiceRequest ServiceRequestResource(CqlContext context, ServiceRequest arg)
    {
        ServiceRequest[] a_ = [
            arg,
        ];

        ServiceRequest b_(ServiceRequest a) {
            List<Identifier> f_ = a?.Identifier;
            List<Canonical> g_ = a?.InstantiatesCanonicalElement;
            List<FhirUri> h_ = a?.InstantiatesUriElement;
            List<ResourceReference> i_ = a?.BasedOn;
            List<ResourceReference> j_ = a?.Replaces;
            Identifier k_ = a?.Requisition;
            Code<RequestStatus> l_ = a?.StatusElement;
            Code<RequestIntent> m_ = a?.IntentElement;
            List<CodeableConcept> n_ = a?.Category;
            Code<RequestPriority> o_ = a?.PriorityElement;
            FhirBoolean p_ = a?.DoNotPerformElement;
            CodeableConcept q_ = a?.Code;
            List<CodeableConcept> r_ = a?.OrderDetail;
            DataType s_ = a?.Quantity;
            ResourceReference t_ = a?.Subject;
            ResourceReference u_ = a?.Encounter;
            DataType v_ = a?.Occurrence;
            DataType w_ = a?.AsNeeded;
            FhirDateTime x_ = a?.AuthoredOnElement;
            ResourceReference y_ = a?.Requester;
            CodeableConcept z_ = a?.PerformerType;
            List<ResourceReference> aa_ = a?.Performer;
            List<CodeableConcept> ab_ = a?.LocationCode;
            List<ResourceReference> ac_ = a?.LocationReference;
            List<CodeableConcept> ad_ = a?.ReasonCode;
            List<ResourceReference> ae_ = a?.ReasonReference;
            List<ResourceReference> af_ = a?.Insurance;
            List<ResourceReference> ag_ = a?.SupportingInfo;
            List<ResourceReference> ah_ = a?.Specimen;
            List<CodeableConcept> ai_ = a?.BodySite;
            List<Annotation> aj_ = a?.Note;
            FhirString ak_ = a?.PatientInstructionElement;
            List<ResourceReference> al_ = a?.RelevantHistory;
            ServiceRequest am_ = new ServiceRequest
            {
                Identifier = new List<Identifier>((IEnumerable<Identifier>)f_),
                InstantiatesCanonicalElement = new List<Canonical>((IEnumerable<Canonical>)g_),
                InstantiatesUriElement = new List<FhirUri>((IEnumerable<FhirUri>)h_),
                BasedOn = new List<ResourceReference>((IEnumerable<ResourceReference>)i_),
                Replaces = new List<ResourceReference>((IEnumerable<ResourceReference>)j_),
                Requisition = k_,
                StatusElement = l_,
                IntentElement = m_,
                Category = new List<CodeableConcept>((IEnumerable<CodeableConcept>)n_),
                PriorityElement = o_,
                DoNotPerformElement = p_,
                Code = q_,
                OrderDetail = new List<CodeableConcept>((IEnumerable<CodeableConcept>)r_),
                Quantity = (DataType)s_,
                Subject = t_,
                Encounter = u_,
                Occurrence = (DataType)v_,
                AsNeeded = (DataType)w_,
                AuthoredOnElement = x_,
                Requester = y_,
                PerformerType = z_,
                Performer = new List<ResourceReference>((IEnumerable<ResourceReference>)aa_),
                LocationCode = new List<CodeableConcept>((IEnumerable<CodeableConcept>)ab_),
                LocationReference = new List<ResourceReference>((IEnumerable<ResourceReference>)ac_),
                ReasonCode = new List<CodeableConcept>((IEnumerable<CodeableConcept>)ad_),
                ReasonReference = new List<ResourceReference>((IEnumerable<ResourceReference>)ae_),
                Insurance = new List<ResourceReference>((IEnumerable<ResourceReference>)af_),
                SupportingInfo = new List<ResourceReference>((IEnumerable<ResourceReference>)ag_),
                Specimen = new List<ResourceReference>((IEnumerable<ResourceReference>)ah_),
                BodySite = new List<CodeableConcept>((IEnumerable<CodeableConcept>)ai_),
                Note = new List<Annotation>((IEnumerable<Annotation>)aj_),
                PatientInstructionElement = ak_,
                RelevantHistory = new List<ResourceReference>((IEnumerable<ResourceReference>)al_),
            };
            return am_;
        }

        IEnumerable<ServiceRequest> c_ = context.Operators.Select<ServiceRequest, ServiceRequest>((IEnumerable<ServiceRequest>)a_, b_);
        IEnumerable<ServiceRequest> d_ = context.Operators.Distinct<ServiceRequest>(c_);
        ServiceRequest e_ = context.Operators.SingletonFrom<ServiceRequest>(d_);
        return e_;
    }


    [CqlFunctionDefinition("SlotResource")]
    public Slot SlotResource(CqlContext context, Slot arg)
    {
        Slot[] a_ = [
            arg,
        ];

        Slot b_(Slot a) {
            List<Identifier> f_ = a?.Identifier;
            List<CodeableConcept> g_ = a?.ServiceCategory;
            List<CodeableConcept> h_ = a?.ServiceType;
            List<CodeableConcept> i_ = a?.Specialty;
            CodeableConcept j_ = a?.AppointmentType;
            ResourceReference k_ = a?.Schedule;
            Code<Slot.SlotStatus> l_ = a?.StatusElement;
            Instant m_ = a?.StartElement;
            Instant n_ = a?.EndElement;
            FhirBoolean o_ = a?.OverbookedElement;
            FhirString p_ = a?.CommentElement;
            Slot q_ = new Slot
            {
                Identifier = new List<Identifier>((IEnumerable<Identifier>)f_),
                ServiceCategory = new List<CodeableConcept>((IEnumerable<CodeableConcept>)g_),
                ServiceType = new List<CodeableConcept>((IEnumerable<CodeableConcept>)h_),
                Specialty = new List<CodeableConcept>((IEnumerable<CodeableConcept>)i_),
                AppointmentType = j_,
                Schedule = k_,
                StatusElement = l_,
                StartElement = m_,
                EndElement = n_,
                OverbookedElement = o_,
                CommentElement = p_,
            };
            return q_;
        }

        IEnumerable<Slot> c_ = context.Operators.Select<Slot, Slot>((IEnumerable<Slot>)a_, b_);
        IEnumerable<Slot> d_ = context.Operators.Distinct<Slot>(c_);
        Slot e_ = context.Operators.SingletonFrom<Slot>(d_);
        return e_;
    }


    [CqlFunctionDefinition("SpecimenResource")]
    public Specimen SpecimenResource(CqlContext context, Specimen arg)
    {
        Specimen[] a_ = [
            arg,
        ];

        Specimen b_(Specimen a) {
            List<Identifier> f_ = a?.Identifier;
            Identifier g_ = a?.AccessionIdentifier;
            Code<Specimen.SpecimenStatus> h_ = a?.StatusElement;
            CodeableConcept i_ = a?.Type;
            ResourceReference j_ = a?.Subject;
            FhirDateTime k_ = a?.ReceivedTimeElement;
            List<ResourceReference> l_ = a?.Parent;
            List<ResourceReference> m_ = a?.Request;
            Specimen.CollectionComponent n_ = a?.Collection;
            List<Specimen.ProcessingComponent> o_ = a?.Processing;
            List<Specimen.ContainerComponent> p_ = a?.Container;
            List<CodeableConcept> q_ = a?.Condition;
            List<Annotation> r_ = a?.Note;
            Specimen s_ = new Specimen
            {
                Identifier = new List<Identifier>((IEnumerable<Identifier>)f_),
                AccessionIdentifier = g_,
                StatusElement = h_,
                Type = i_,
                Subject = j_,
                ReceivedTimeElement = k_,
                Parent = new List<ResourceReference>((IEnumerable<ResourceReference>)l_),
                Request = new List<ResourceReference>((IEnumerable<ResourceReference>)m_),
                Collection = n_,
                Processing = new List<Specimen.ProcessingComponent>((IEnumerable<Specimen.ProcessingComponent>)o_),
                Container = new List<Specimen.ContainerComponent>((IEnumerable<Specimen.ContainerComponent>)p_),
                Condition = new List<CodeableConcept>((IEnumerable<CodeableConcept>)q_),
                Note = new List<Annotation>((IEnumerable<Annotation>)r_),
            };
            return s_;
        }

        IEnumerable<Specimen> c_ = context.Operators.Select<Specimen, Specimen>((IEnumerable<Specimen>)a_, b_);
        IEnumerable<Specimen> d_ = context.Operators.Distinct<Specimen>(c_);
        Specimen e_ = context.Operators.SingletonFrom<Specimen>(d_);
        return e_;
    }


    [CqlFunctionDefinition("SpecimenDefinitionResource")]
    public SpecimenDefinition SpecimenDefinitionResource(CqlContext context, SpecimenDefinition arg)
    {
        SpecimenDefinition[] a_ = [
            arg,
        ];

        SpecimenDefinition b_(SpecimenDefinition a) {
            Identifier f_ = a?.Identifier;
            CodeableConcept g_ = a?.TypeCollected;
            List<CodeableConcept> h_ = a?.PatientPreparation;
            FhirString i_ = a?.TimeAspectElement;
            List<CodeableConcept> j_ = a?.Collection;
            List<SpecimenDefinition.TypeTestedComponent> k_ = a?.TypeTested;
            SpecimenDefinition l_ = new SpecimenDefinition
            {
                Identifier = f_,
                TypeCollected = g_,
                PatientPreparation = new List<CodeableConcept>((IEnumerable<CodeableConcept>)h_),
                TimeAspectElement = i_,
                Collection = new List<CodeableConcept>((IEnumerable<CodeableConcept>)j_),
                TypeTested = new List<SpecimenDefinition.TypeTestedComponent>((IEnumerable<SpecimenDefinition.TypeTestedComponent>)k_),
            };
            return l_;
        }

        IEnumerable<SpecimenDefinition> c_ = context.Operators.Select<SpecimenDefinition, SpecimenDefinition>((IEnumerable<SpecimenDefinition>)a_, b_);
        IEnumerable<SpecimenDefinition> d_ = context.Operators.Distinct<SpecimenDefinition>(c_);
        SpecimenDefinition e_ = context.Operators.SingletonFrom<SpecimenDefinition>(d_);
        return e_;
    }


    [CqlFunctionDefinition("StructureDefinitionResource")]
    public StructureDefinition StructureDefinitionResource(CqlContext context, StructureDefinition arg)
    {
        StructureDefinition[] a_ = [
            arg,
        ];

        StructureDefinition b_(StructureDefinition a) {
            FhirUri f_ = a?.UrlElement;
            List<Identifier> g_ = a?.Identifier;
            FhirString h_ = a?.VersionElement;
            FhirString i_ = a?.NameElement;
            FhirString j_ = a?.TitleElement;
            Code<PublicationStatus> k_ = a?.StatusElement;
            FhirBoolean l_ = a?.ExperimentalElement;
            FhirDateTime m_ = a?.DateElement;
            FhirString n_ = a?.PublisherElement;
            List<ContactDetail> o_ = a?.Contact;
            Markdown p_ = a?.DescriptionElement;
            List<UsageContext> q_ = a?.UseContext;
            List<CodeableConcept> r_ = a?.Jurisdiction;
            Markdown s_ = a?.PurposeElement;
            Markdown t_ = a?.CopyrightElement;
            List<Coding> u_ = a?.Keyword;
            Code<FHIRVersion> v_ = a?.FhirVersionElement;
            List<StructureDefinition.MappingComponent> w_ = a?.Mapping;
            Code<StructureDefinition.StructureDefinitionKind> x_ = a?.KindElement;
            FhirBoolean y_ = a?.AbstractElement;
            List<StructureDefinition.ContextComponent> z_ = a?.Context;
            List<FhirString> aa_ = a?.ContextInvariantElement;
            FhirUri ab_ = a?.TypeElement;
            Canonical ac_ = a?.BaseDefinitionElement;
            Code<StructureDefinition.TypeDerivationRule> ad_ = a?.DerivationElement;
            StructureDefinition.SnapshotComponent ae_ = a?.Snapshot;
            StructureDefinition.DifferentialComponent af_ = a?.Differential;
            StructureDefinition ag_ = new StructureDefinition
            {
                UrlElement = f_,
                Identifier = new List<Identifier>((IEnumerable<Identifier>)g_),
                VersionElement = h_,
                NameElement = i_,
                TitleElement = j_,
                StatusElement = k_,
                ExperimentalElement = l_,
                DateElement = m_,
                PublisherElement = n_,
                Contact = new List<ContactDetail>((IEnumerable<ContactDetail>)o_),
                DescriptionElement = p_,
                UseContext = new List<UsageContext>((IEnumerable<UsageContext>)q_),
                Jurisdiction = new List<CodeableConcept>((IEnumerable<CodeableConcept>)r_),
                PurposeElement = s_,
                CopyrightElement = t_,
                Keyword = new List<Coding>((IEnumerable<Coding>)u_),
                FhirVersionElement = v_,
                Mapping = new List<StructureDefinition.MappingComponent>((IEnumerable<StructureDefinition.MappingComponent>)w_),
                KindElement = x_,
                AbstractElement = y_,
                Context = new List<StructureDefinition.ContextComponent>((IEnumerable<StructureDefinition.ContextComponent>)z_),
                ContextInvariantElement = new List<FhirString>((IEnumerable<FhirString>)aa_),
                TypeElement = ab_,
                BaseDefinitionElement = ac_,
                DerivationElement = ad_,
                Snapshot = ae_,
                Differential = af_,
            };
            return ag_;
        }

        IEnumerable<StructureDefinition> c_ = context.Operators.Select<StructureDefinition, StructureDefinition>((IEnumerable<StructureDefinition>)a_, b_);
        IEnumerable<StructureDefinition> d_ = context.Operators.Distinct<StructureDefinition>(c_);
        StructureDefinition e_ = context.Operators.SingletonFrom<StructureDefinition>(d_);
        return e_;
    }


    [CqlFunctionDefinition("StructureMapResource")]
    public StructureMap StructureMapResource(CqlContext context, StructureMap arg)
    {
        StructureMap[] a_ = [
            arg,
        ];

        StructureMap b_(StructureMap a) {
            FhirUri f_ = a?.UrlElement;
            List<Identifier> g_ = a?.Identifier;
            FhirString h_ = a?.VersionElement;
            FhirString i_ = a?.NameElement;
            FhirString j_ = a?.TitleElement;
            Code<PublicationStatus> k_ = a?.StatusElement;
            FhirBoolean l_ = a?.ExperimentalElement;
            FhirDateTime m_ = a?.DateElement;
            FhirString n_ = a?.PublisherElement;
            List<ContactDetail> o_ = a?.Contact;
            Markdown p_ = a?.DescriptionElement;
            List<UsageContext> q_ = a?.UseContext;
            List<CodeableConcept> r_ = a?.Jurisdiction;
            Markdown s_ = a?.PurposeElement;
            Markdown t_ = a?.CopyrightElement;
            List<StructureMap.StructureComponent> u_ = a?.Structure;
            List<Canonical> v_ = a?.ImportElement;
            List<StructureMap.GroupComponent> w_ = a?.Group;
            StructureMap x_ = new StructureMap
            {
                UrlElement = f_,
                Identifier = new List<Identifier>((IEnumerable<Identifier>)g_),
                VersionElement = h_,
                NameElement = i_,
                TitleElement = j_,
                StatusElement = k_,
                ExperimentalElement = l_,
                DateElement = m_,
                PublisherElement = n_,
                Contact = new List<ContactDetail>((IEnumerable<ContactDetail>)o_),
                DescriptionElement = p_,
                UseContext = new List<UsageContext>((IEnumerable<UsageContext>)q_),
                Jurisdiction = new List<CodeableConcept>((IEnumerable<CodeableConcept>)r_),
                PurposeElement = s_,
                CopyrightElement = t_,
                Structure = new List<StructureMap.StructureComponent>((IEnumerable<StructureMap.StructureComponent>)u_),
                ImportElement = new List<Canonical>((IEnumerable<Canonical>)v_),
                Group = new List<StructureMap.GroupComponent>((IEnumerable<StructureMap.GroupComponent>)w_),
            };
            return x_;
        }

        IEnumerable<StructureMap> c_ = context.Operators.Select<StructureMap, StructureMap>((IEnumerable<StructureMap>)a_, b_);
        IEnumerable<StructureMap> d_ = context.Operators.Distinct<StructureMap>(c_);
        StructureMap e_ = context.Operators.SingletonFrom<StructureMap>(d_);
        return e_;
    }


    [CqlFunctionDefinition("SubscriptionResource")]
    public Subscription SubscriptionResource(CqlContext context, Subscription arg)
    {
        Subscription[] a_ = [
            arg,
        ];

        Subscription b_(Subscription a) {
            Code<Subscription.SubscriptionStatus> f_ = a?.StatusElement;
            List<ContactPoint> g_ = a?.Contact;
            Instant h_ = a?.EndElement;
            FhirString i_ = a?.ReasonElement;
            FhirString j_ = a?.CriteriaElement;
            FhirString k_ = a?.ErrorElement;
            Subscription.ChannelComponent l_ = a?.Channel;
            Subscription m_ = new Subscription
            {
                StatusElement = f_,
                Contact = new List<ContactPoint>((IEnumerable<ContactPoint>)g_),
                EndElement = h_,
                ReasonElement = i_,
                CriteriaElement = j_,
                ErrorElement = k_,
                Channel = l_,
            };
            return m_;
        }

        IEnumerable<Subscription> c_ = context.Operators.Select<Subscription, Subscription>((IEnumerable<Subscription>)a_, b_);
        IEnumerable<Subscription> d_ = context.Operators.Distinct<Subscription>(c_);
        Subscription e_ = context.Operators.SingletonFrom<Subscription>(d_);
        return e_;
    }


    [CqlFunctionDefinition("SubstanceResource")]
    public Substance SubstanceResource(CqlContext context, Substance arg)
    {
        Substance[] a_ = [
            arg,
        ];

        Substance b_(Substance a) {
            List<Identifier> f_ = a?.Identifier;
            Code<Substance.FHIRSubstanceStatus> g_ = a?.StatusElement;
            List<CodeableConcept> h_ = a?.Category;
            CodeableConcept i_ = a?.Code;
            FhirString j_ = a?.DescriptionElement;
            List<Substance.InstanceComponent> k_ = a?.Instance;
            List<Substance.IngredientComponent> l_ = a?.Ingredient;
            Substance m_ = new Substance
            {
                Identifier = new List<Identifier>((IEnumerable<Identifier>)f_),
                StatusElement = g_,
                Category = new List<CodeableConcept>((IEnumerable<CodeableConcept>)h_),
                Code = i_,
                DescriptionElement = j_,
                Instance = new List<Substance.InstanceComponent>((IEnumerable<Substance.InstanceComponent>)k_),
                Ingredient = new List<Substance.IngredientComponent>((IEnumerable<Substance.IngredientComponent>)l_),
            };
            return m_;
        }

        IEnumerable<Substance> c_ = context.Operators.Select<Substance, Substance>((IEnumerable<Substance>)a_, b_);
        IEnumerable<Substance> d_ = context.Operators.Distinct<Substance>(c_);
        Substance e_ = context.Operators.SingletonFrom<Substance>(d_);
        return e_;
    }


    [CqlFunctionDefinition("SubstanceNucleicAcidResource")]
    public SubstanceNucleicAcid SubstanceNucleicAcidResource(CqlContext context, SubstanceNucleicAcid arg)
    {
        SubstanceNucleicAcid[] a_ = [
            arg,
        ];

        SubstanceNucleicAcid b_(SubstanceNucleicAcid a) {
            CodeableConcept f_ = a?.SequenceType;
            Integer g_ = a?.NumberOfSubunitsElement;
            FhirString h_ = a?.AreaOfHybridisationElement;
            CodeableConcept i_ = a?.OligoNucleotideType;
            List<SubstanceNucleicAcid.SubunitComponent> j_ = a?.Subunit;
            SubstanceNucleicAcid k_ = new SubstanceNucleicAcid
            {
                SequenceType = f_,
                NumberOfSubunitsElement = g_,
                AreaOfHybridisationElement = h_,
                OligoNucleotideType = i_,
                Subunit = new List<SubstanceNucleicAcid.SubunitComponent>((IEnumerable<SubstanceNucleicAcid.SubunitComponent>)j_),
            };
            return k_;
        }

        IEnumerable<SubstanceNucleicAcid> c_ = context.Operators.Select<SubstanceNucleicAcid, SubstanceNucleicAcid>((IEnumerable<SubstanceNucleicAcid>)a_, b_);
        IEnumerable<SubstanceNucleicAcid> d_ = context.Operators.Distinct<SubstanceNucleicAcid>(c_);
        SubstanceNucleicAcid e_ = context.Operators.SingletonFrom<SubstanceNucleicAcid>(d_);
        return e_;
    }


    [CqlFunctionDefinition("SubstancePolymerResource")]
    public SubstancePolymer SubstancePolymerResource(CqlContext context, SubstancePolymer arg)
    {
        SubstancePolymer[] a_ = [
            arg,
        ];

        SubstancePolymer b_(SubstancePolymer a) {
            CodeableConcept f_ = a?.Class;
            CodeableConcept g_ = a?.Geometry;
            List<CodeableConcept> h_ = a?.CopolymerConnectivity;
            List<FhirString> i_ = a?.ModificationElement;
            List<SubstancePolymer.MonomerSetComponent> j_ = a?.MonomerSet;
            List<SubstancePolymer.RepeatComponent> k_ = a?.Repeat;
            SubstancePolymer l_ = new SubstancePolymer
            {
                Class = f_,
                Geometry = g_,
                CopolymerConnectivity = new List<CodeableConcept>((IEnumerable<CodeableConcept>)h_),
                ModificationElement = new List<FhirString>((IEnumerable<FhirString>)i_),
                MonomerSet = new List<SubstancePolymer.MonomerSetComponent>((IEnumerable<SubstancePolymer.MonomerSetComponent>)j_),
                Repeat = new List<SubstancePolymer.RepeatComponent>((IEnumerable<SubstancePolymer.RepeatComponent>)k_),
            };
            return l_;
        }

        IEnumerable<SubstancePolymer> c_ = context.Operators.Select<SubstancePolymer, SubstancePolymer>((IEnumerable<SubstancePolymer>)a_, b_);
        IEnumerable<SubstancePolymer> d_ = context.Operators.Distinct<SubstancePolymer>(c_);
        SubstancePolymer e_ = context.Operators.SingletonFrom<SubstancePolymer>(d_);
        return e_;
    }


    [CqlFunctionDefinition("SubstanceProteinResource")]
    public SubstanceProtein SubstanceProteinResource(CqlContext context, SubstanceProtein arg)
    {
        SubstanceProtein[] a_ = [
            arg,
        ];

        SubstanceProtein b_(SubstanceProtein a) {
            CodeableConcept f_ = a?.SequenceType;
            Integer g_ = a?.NumberOfSubunitsElement;
            List<FhirString> h_ = a?.DisulfideLinkageElement;
            List<SubstanceProtein.SubunitComponent> i_ = a?.Subunit;
            SubstanceProtein j_ = new SubstanceProtein
            {
                SequenceType = f_,
                NumberOfSubunitsElement = g_,
                DisulfideLinkageElement = new List<FhirString>((IEnumerable<FhirString>)h_),
                Subunit = new List<SubstanceProtein.SubunitComponent>((IEnumerable<SubstanceProtein.SubunitComponent>)i_),
            };
            return j_;
        }

        IEnumerable<SubstanceProtein> c_ = context.Operators.Select<SubstanceProtein, SubstanceProtein>((IEnumerable<SubstanceProtein>)a_, b_);
        IEnumerable<SubstanceProtein> d_ = context.Operators.Distinct<SubstanceProtein>(c_);
        SubstanceProtein e_ = context.Operators.SingletonFrom<SubstanceProtein>(d_);
        return e_;
    }


    [CqlFunctionDefinition("SubstanceReferenceInformationResource")]
    public SubstanceReferenceInformation SubstanceReferenceInformationResource(CqlContext context, SubstanceReferenceInformation arg)
    {
        SubstanceReferenceInformation[] a_ = [
            arg,
        ];

        SubstanceReferenceInformation b_(SubstanceReferenceInformation a) {
            FhirString f_ = a?.CommentElement;
            List<SubstanceReferenceInformation.GeneComponent> g_ = a?.Gene;
            List<SubstanceReferenceInformation.GeneElementComponent> h_ = a?.GeneElement;
            List<SubstanceReferenceInformation.ClassificationComponent> i_ = a?.Classification;
            List<SubstanceReferenceInformation.TargetComponent> j_ = a?.Target;
            SubstanceReferenceInformation k_ = new SubstanceReferenceInformation
            {
                CommentElement = f_,
                Gene = new List<SubstanceReferenceInformation.GeneComponent>((IEnumerable<SubstanceReferenceInformation.GeneComponent>)g_),
                GeneElement = new List<SubstanceReferenceInformation.GeneElementComponent>((IEnumerable<SubstanceReferenceInformation.GeneElementComponent>)h_),
                Classification = new List<SubstanceReferenceInformation.ClassificationComponent>((IEnumerable<SubstanceReferenceInformation.ClassificationComponent>)i_),
                Target = new List<SubstanceReferenceInformation.TargetComponent>((IEnumerable<SubstanceReferenceInformation.TargetComponent>)j_),
            };
            return k_;
        }

        IEnumerable<SubstanceReferenceInformation> c_ = context.Operators.Select<SubstanceReferenceInformation, SubstanceReferenceInformation>((IEnumerable<SubstanceReferenceInformation>)a_, b_);
        IEnumerable<SubstanceReferenceInformation> d_ = context.Operators.Distinct<SubstanceReferenceInformation>(c_);
        SubstanceReferenceInformation e_ = context.Operators.SingletonFrom<SubstanceReferenceInformation>(d_);
        return e_;
    }


    [CqlFunctionDefinition("SubstanceSourceMaterialResource")]
    public SubstanceSourceMaterial SubstanceSourceMaterialResource(CqlContext context, SubstanceSourceMaterial arg)
    {
        SubstanceSourceMaterial[] a_ = [
            arg,
        ];

        SubstanceSourceMaterial b_(SubstanceSourceMaterial a) {
            CodeableConcept f_ = a?.SourceMaterialClass;
            CodeableConcept g_ = a?.SourceMaterialType;
            CodeableConcept h_ = a?.SourceMaterialState;
            Identifier i_ = a?.OrganismId;
            FhirString j_ = a?.OrganismNameElement;
            List<Identifier> k_ = a?.ParentSubstanceId;
            List<FhirString> l_ = a?.ParentSubstanceNameElement;
            List<CodeableConcept> m_ = a?.CountryOfOrigin;
            List<FhirString> n_ = a?.GeographicalLocationElement;
            CodeableConcept o_ = a?.DevelopmentStage;
            List<SubstanceSourceMaterial.FractionDescriptionComponent> p_ = a?.FractionDescription;
            SubstanceSourceMaterial.OrganismComponent q_ = a?.Organism;
            List<SubstanceSourceMaterial.PartDescriptionComponent> r_ = a?.PartDescription;
            SubstanceSourceMaterial s_ = new SubstanceSourceMaterial
            {
                SourceMaterialClass = f_,
                SourceMaterialType = g_,
                SourceMaterialState = h_,
                OrganismId = i_,
                OrganismNameElement = j_,
                ParentSubstanceId = new List<Identifier>((IEnumerable<Identifier>)k_),
                ParentSubstanceNameElement = new List<FhirString>((IEnumerable<FhirString>)l_),
                CountryOfOrigin = new List<CodeableConcept>((IEnumerable<CodeableConcept>)m_),
                GeographicalLocationElement = new List<FhirString>((IEnumerable<FhirString>)n_),
                DevelopmentStage = o_,
                FractionDescription = new List<SubstanceSourceMaterial.FractionDescriptionComponent>((IEnumerable<SubstanceSourceMaterial.FractionDescriptionComponent>)p_),
                Organism = q_,
                PartDescription = new List<SubstanceSourceMaterial.PartDescriptionComponent>((IEnumerable<SubstanceSourceMaterial.PartDescriptionComponent>)r_),
            };
            return s_;
        }

        IEnumerable<SubstanceSourceMaterial> c_ = context.Operators.Select<SubstanceSourceMaterial, SubstanceSourceMaterial>((IEnumerable<SubstanceSourceMaterial>)a_, b_);
        IEnumerable<SubstanceSourceMaterial> d_ = context.Operators.Distinct<SubstanceSourceMaterial>(c_);
        SubstanceSourceMaterial e_ = context.Operators.SingletonFrom<SubstanceSourceMaterial>(d_);
        return e_;
    }


    [CqlFunctionDefinition("SubstanceSpecificationResource")]
    public SubstanceSpecification SubstanceSpecificationResource(CqlContext context, SubstanceSpecification arg)
    {
        SubstanceSpecification[] a_ = [
            arg,
        ];

        SubstanceSpecification b_(SubstanceSpecification a) {
            Identifier f_ = a?.Identifier;
            CodeableConcept g_ = a?.Type;
            CodeableConcept h_ = a?.Status;
            CodeableConcept i_ = a?.Domain;
            FhirString j_ = a?.DescriptionElement;
            List<ResourceReference> k_ = a?.Source;
            FhirString l_ = a?.CommentElement;
            List<SubstanceSpecification.MoietyComponent> m_ = a?.Moiety;
            List<SubstanceSpecification.PropertyComponent> n_ = a?.Property;
            ResourceReference o_ = a?.ReferenceInformation;
            SubstanceSpecification.StructureComponent p_ = a?.Structure;
            List<SubstanceSpecification.CodeComponent> q_ = a?.Code;
            List<SubstanceSpecification.NameComponent> r_ = a?.Name;
            List<SubstanceSpecification.MolecularWeightComponent> s_ = a?.MolecularWeight;
            List<SubstanceSpecification.RelationshipComponent> t_ = a?.Relationship;
            ResourceReference u_ = a?.NucleicAcid;
            ResourceReference v_ = a?.Polymer;
            ResourceReference w_ = a?.Protein;
            ResourceReference x_ = a?.SourceMaterial;
            SubstanceSpecification y_ = new SubstanceSpecification
            {
                Identifier = f_,
                Type = g_,
                Status = h_,
                Domain = i_,
                DescriptionElement = j_,
                Source = new List<ResourceReference>((IEnumerable<ResourceReference>)k_),
                CommentElement = l_,
                Moiety = new List<SubstanceSpecification.MoietyComponent>((IEnumerable<SubstanceSpecification.MoietyComponent>)m_),
                Property = new List<SubstanceSpecification.PropertyComponent>((IEnumerable<SubstanceSpecification.PropertyComponent>)n_),
                ReferenceInformation = o_,
                Structure = p_,
                Code = new List<SubstanceSpecification.CodeComponent>((IEnumerable<SubstanceSpecification.CodeComponent>)q_),
                Name = new List<SubstanceSpecification.NameComponent>((IEnumerable<SubstanceSpecification.NameComponent>)r_),
                MolecularWeight = new List<SubstanceSpecification.MolecularWeightComponent>((IEnumerable<SubstanceSpecification.MolecularWeightComponent>)s_),
                Relationship = new List<SubstanceSpecification.RelationshipComponent>((IEnumerable<SubstanceSpecification.RelationshipComponent>)t_),
                NucleicAcid = u_,
                Polymer = v_,
                Protein = w_,
                SourceMaterial = x_,
            };
            return y_;
        }

        IEnumerable<SubstanceSpecification> c_ = context.Operators.Select<SubstanceSpecification, SubstanceSpecification>((IEnumerable<SubstanceSpecification>)a_, b_);
        IEnumerable<SubstanceSpecification> d_ = context.Operators.Distinct<SubstanceSpecification>(c_);
        SubstanceSpecification e_ = context.Operators.SingletonFrom<SubstanceSpecification>(d_);
        return e_;
    }


    [CqlFunctionDefinition("SupplyDeliveryResource")]
    public SupplyDelivery SupplyDeliveryResource(CqlContext context, SupplyDelivery arg)
    {
        SupplyDelivery[] a_ = [
            arg,
        ];

        SupplyDelivery b_(SupplyDelivery a) {
            List<Identifier> f_ = a?.Identifier;
            List<ResourceReference> g_ = a?.BasedOn;
            List<ResourceReference> h_ = a?.PartOf;
            Code<SupplyDelivery.SupplyDeliveryStatus> i_ = a?.StatusElement;
            ResourceReference j_ = a?.Patient;
            CodeableConcept k_ = a?.Type;
            SupplyDelivery.SuppliedItemComponent l_ = a?.SuppliedItem;
            DataType m_ = a?.Occurrence;
            ResourceReference n_ = a?.Supplier;
            ResourceReference o_ = a?.Destination;
            List<ResourceReference> p_ = a?.Receiver;
            SupplyDelivery q_ = new SupplyDelivery
            {
                Identifier = new List<Identifier>((IEnumerable<Identifier>)f_),
                BasedOn = new List<ResourceReference>((IEnumerable<ResourceReference>)g_),
                PartOf = new List<ResourceReference>((IEnumerable<ResourceReference>)h_),
                StatusElement = i_,
                Patient = j_,
                Type = k_,
                SuppliedItem = l_,
                Occurrence = (DataType)m_,
                Supplier = n_,
                Destination = o_,
                Receiver = new List<ResourceReference>((IEnumerable<ResourceReference>)p_),
            };
            return q_;
        }

        IEnumerable<SupplyDelivery> c_ = context.Operators.Select<SupplyDelivery, SupplyDelivery>((IEnumerable<SupplyDelivery>)a_, b_);
        IEnumerable<SupplyDelivery> d_ = context.Operators.Distinct<SupplyDelivery>(c_);
        SupplyDelivery e_ = context.Operators.SingletonFrom<SupplyDelivery>(d_);
        return e_;
    }


    [CqlFunctionDefinition("SupplyRequestResource")]
    public SupplyRequest SupplyRequestResource(CqlContext context, SupplyRequest arg)
    {
        SupplyRequest[] a_ = [
            arg,
        ];

        SupplyRequest b_(SupplyRequest a) {
            List<Identifier> f_ = a?.Identifier;
            Code<SupplyRequest.SupplyRequestStatus> g_ = a?.StatusElement;
            CodeableConcept h_ = a?.Category;
            Code<RequestPriority> i_ = a?.PriorityElement;
            DataType j_ = a?.Item;
            Quantity k_ = a?.Quantity;
            List<SupplyRequest.ParameterComponent> l_ = a?.Parameter;
            DataType m_ = a?.Occurrence;
            FhirDateTime n_ = a?.AuthoredOnElement;
            ResourceReference o_ = a?.Requester;
            List<ResourceReference> p_ = a?.Supplier;
            List<CodeableConcept> q_ = a?.ReasonCode;
            List<ResourceReference> r_ = a?.ReasonReference;
            ResourceReference s_ = a?.DeliverFrom;
            ResourceReference t_ = a?.DeliverTo;
            SupplyRequest u_ = new SupplyRequest
            {
                Identifier = new List<Identifier>((IEnumerable<Identifier>)f_),
                StatusElement = g_,
                Category = h_,
                PriorityElement = i_,
                Item = (DataType)j_,
                Quantity = k_,
                Parameter = new List<SupplyRequest.ParameterComponent>((IEnumerable<SupplyRequest.ParameterComponent>)l_),
                Occurrence = (DataType)m_,
                AuthoredOnElement = n_,
                Requester = o_,
                Supplier = new List<ResourceReference>((IEnumerable<ResourceReference>)p_),
                ReasonCode = new List<CodeableConcept>((IEnumerable<CodeableConcept>)q_),
                ReasonReference = new List<ResourceReference>((IEnumerable<ResourceReference>)r_),
                DeliverFrom = s_,
                DeliverTo = t_,
            };
            return u_;
        }

        IEnumerable<SupplyRequest> c_ = context.Operators.Select<SupplyRequest, SupplyRequest>((IEnumerable<SupplyRequest>)a_, b_);
        IEnumerable<SupplyRequest> d_ = context.Operators.Distinct<SupplyRequest>(c_);
        SupplyRequest e_ = context.Operators.SingletonFrom<SupplyRequest>(d_);
        return e_;
    }


    [CqlFunctionDefinition("TaskResource")]
    public Task TaskResource(CqlContext context, Task arg)
    {
        Task[] a_ = [
            arg,
        ];

        Task b_(Task a) {
            List<Identifier> f_ = a?.Identifier;
            Canonical g_ = a?.InstantiatesCanonicalElement;
            FhirUri h_ = a?.InstantiatesUriElement;
            List<ResourceReference> i_ = a?.BasedOn;
            Identifier j_ = a?.GroupIdentifier;
            List<ResourceReference> k_ = a?.PartOf;
            Code<Task.TaskStatus> l_ = a?.StatusElement;
            CodeableConcept m_ = a?.StatusReason;
            CodeableConcept n_ = a?.BusinessStatus;
            Code<Task.TaskIntent> o_ = a?.IntentElement;
            Code<RequestPriority> p_ = a?.PriorityElement;
            CodeableConcept q_ = a?.Code;
            FhirString r_ = a?.DescriptionElement;
            ResourceReference s_ = a?.Focus;
            ResourceReference t_ = a?.For;
            ResourceReference u_ = a?.Encounter;
            Period v_ = a?.ExecutionPeriod;
            FhirDateTime w_ = a?.AuthoredOnElement;
            FhirDateTime x_ = a?.LastModifiedElement;
            ResourceReference y_ = a?.Requester;
            List<CodeableConcept> z_ = a?.PerformerType;
            ResourceReference aa_ = a?.Owner;
            ResourceReference ab_ = a?.Location;
            CodeableConcept ac_ = a?.ReasonCode;
            ResourceReference ad_ = a?.ReasonReference;
            List<ResourceReference> ae_ = a?.Insurance;
            List<Annotation> af_ = a?.Note;
            List<ResourceReference> ag_ = a?.RelevantHistory;
            Task.RestrictionComponent ah_ = a?.Restriction;
            List<Task.ParameterComponent> ai_ = a?.Input;
            List<Task.OutputComponent> aj_ = a?.Output;
            Task ak_ = new Task
            {
                Identifier = new List<Identifier>((IEnumerable<Identifier>)f_),
                InstantiatesCanonicalElement = g_,
                InstantiatesUriElement = h_,
                BasedOn = new List<ResourceReference>((IEnumerable<ResourceReference>)i_),
                GroupIdentifier = j_,
                PartOf = new List<ResourceReference>((IEnumerable<ResourceReference>)k_),
                StatusElement = l_,
                StatusReason = m_,
                BusinessStatus = n_,
                IntentElement = o_,
                PriorityElement = p_,
                Code = q_,
                DescriptionElement = r_,
                Focus = s_,
                For = t_,
                Encounter = u_,
                ExecutionPeriod = v_,
                AuthoredOnElement = w_,
                LastModifiedElement = x_,
                Requester = y_,
                PerformerType = new List<CodeableConcept>((IEnumerable<CodeableConcept>)z_),
                Owner = aa_,
                Location = ab_,
                ReasonCode = ac_,
                ReasonReference = ad_,
                Insurance = new List<ResourceReference>((IEnumerable<ResourceReference>)ae_),
                Note = new List<Annotation>((IEnumerable<Annotation>)af_),
                RelevantHistory = new List<ResourceReference>((IEnumerable<ResourceReference>)ag_),
                Restriction = ah_,
                Input = new List<Task.ParameterComponent>((IEnumerable<Task.ParameterComponent>)ai_),
                Output = new List<Task.OutputComponent>((IEnumerable<Task.OutputComponent>)aj_),
            };
            return ak_;
        }

        IEnumerable<Task> c_ = context.Operators.Select<Task, Task>((IEnumerable<Task>)a_, b_);
        IEnumerable<Task> d_ = context.Operators.Distinct<Task>(c_);
        Task e_ = context.Operators.SingletonFrom<Task>(d_);
        return e_;
    }


    [CqlFunctionDefinition("TerminologyCapabilitiesResource")]
    public TerminologyCapabilities TerminologyCapabilitiesResource(CqlContext context, TerminologyCapabilities arg)
    {
        TerminologyCapabilities[] a_ = [
            arg,
        ];

        TerminologyCapabilities b_(TerminologyCapabilities a) {
            FhirUri f_ = a?.UrlElement;
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
            Code<CapabilityStatementKind> t_ = a?.KindElement;
            TerminologyCapabilities.SoftwareComponent u_ = a?.Software;
            TerminologyCapabilities.ImplementationComponent v_ = a?.Implementation;
            FhirBoolean w_ = a?.LockedDateElement;
            List<TerminologyCapabilities.CodeSystemComponent> x_ = a?.CodeSystem;
            TerminologyCapabilities.ExpansionComponent y_ = a?.Expansion;
            Code<TerminologyCapabilities.CodeSearchSupport> z_ = a?.CodeSearchElement;
            TerminologyCapabilities.ValidateCodeComponent aa_ = a?.ValidateCode;
            TerminologyCapabilities.TranslationComponent ab_ = a?.Translation;
            TerminologyCapabilities.ClosureComponent ac_ = a?.Closure;
            TerminologyCapabilities ad_ = new TerminologyCapabilities
            {
                UrlElement = f_,
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
                KindElement = t_,
                Software = u_,
                Implementation = v_,
                LockedDateElement = w_,
                CodeSystem = new List<TerminologyCapabilities.CodeSystemComponent>((IEnumerable<TerminologyCapabilities.CodeSystemComponent>)x_),
                Expansion = y_,
                CodeSearchElement = z_,
                ValidateCode = aa_,
                Translation = ab_,
                Closure = ac_,
            };
            return ad_;
        }

        IEnumerable<TerminologyCapabilities> c_ = context.Operators.Select<TerminologyCapabilities, TerminologyCapabilities>((IEnumerable<TerminologyCapabilities>)a_, b_);
        IEnumerable<TerminologyCapabilities> d_ = context.Operators.Distinct<TerminologyCapabilities>(c_);
        TerminologyCapabilities e_ = context.Operators.SingletonFrom<TerminologyCapabilities>(d_);
        return e_;
    }


    [CqlFunctionDefinition("TestReportResource")]
    public TestReport TestReportResource(CqlContext context, TestReport arg)
    {
        TestReport[] a_ = [
            arg,
        ];

        TestReport b_(TestReport a) {
            Identifier f_ = a?.Identifier;
            FhirString g_ = a?.NameElement;
            Code<TestReport.TestReportStatus> h_ = a?.StatusElement;
            ResourceReference i_ = a?.TestScript;
            Code<TestReport.TestReportResult> j_ = a?.ResultElement;
            FhirDecimal k_ = a?.ScoreElement;
            FhirString l_ = a?.TesterElement;
            FhirDateTime m_ = a?.IssuedElement;
            List<TestReport.ParticipantComponent> n_ = a?.Participant;
            TestReport.SetupComponent o_ = a?.Setup;
            List<TestReport.TestComponent> p_ = a?.Test;
            TestReport.TeardownComponent q_ = a?.Teardown;
            TestReport r_ = new TestReport
            {
                Identifier = f_,
                NameElement = g_,
                StatusElement = h_,
                TestScript = i_,
                ResultElement = j_,
                ScoreElement = k_,
                TesterElement = l_,
                IssuedElement = m_,
                Participant = new List<TestReport.ParticipantComponent>((IEnumerable<TestReport.ParticipantComponent>)n_),
                Setup = o_,
                Test = new List<TestReport.TestComponent>((IEnumerable<TestReport.TestComponent>)p_),
                Teardown = q_,
            };
            return r_;
        }

        IEnumerable<TestReport> c_ = context.Operators.Select<TestReport, TestReport>((IEnumerable<TestReport>)a_, b_);
        IEnumerable<TestReport> d_ = context.Operators.Distinct<TestReport>(c_);
        TestReport e_ = context.Operators.SingletonFrom<TestReport>(d_);
        return e_;
    }


    [CqlFunctionDefinition("TestScriptResource")]
    public TestScript TestScriptResource(CqlContext context, TestScript arg)
    {
        TestScript[] a_ = [
            arg,
        ];

        TestScript b_(TestScript a) {
            FhirUri f_ = a?.UrlElement;
            Identifier g_ = a?.Identifier;
            FhirString h_ = a?.VersionElement;
            FhirString i_ = a?.NameElement;
            FhirString j_ = a?.TitleElement;
            Code<PublicationStatus> k_ = a?.StatusElement;
            FhirBoolean l_ = a?.ExperimentalElement;
            FhirDateTime m_ = a?.DateElement;
            FhirString n_ = a?.PublisherElement;
            List<ContactDetail> o_ = a?.Contact;
            Markdown p_ = a?.DescriptionElement;
            List<UsageContext> q_ = a?.UseContext;
            List<CodeableConcept> r_ = a?.Jurisdiction;
            Markdown s_ = a?.PurposeElement;
            Markdown t_ = a?.CopyrightElement;
            List<TestScript.OriginComponent> u_ = a?.Origin;
            List<TestScript.DestinationComponent> v_ = a?.Destination;
            TestScript.MetadataComponent w_ = a?.Metadata;
            List<TestScript.FixtureComponent> x_ = a?.Fixture;
            List<ResourceReference> y_ = a?.Profile;
            List<TestScript.VariableComponent> z_ = a?.Variable;
            TestScript.SetupComponent aa_ = a?.Setup;
            List<TestScript.TestComponent> ab_ = a?.Test;
            TestScript.TeardownComponent ac_ = a?.Teardown;
            TestScript ad_ = new TestScript
            {
                UrlElement = f_,
                Identifier = g_,
                VersionElement = h_,
                NameElement = i_,
                TitleElement = j_,
                StatusElement = k_,
                ExperimentalElement = l_,
                DateElement = m_,
                PublisherElement = n_,
                Contact = new List<ContactDetail>((IEnumerable<ContactDetail>)o_),
                DescriptionElement = p_,
                UseContext = new List<UsageContext>((IEnumerable<UsageContext>)q_),
                Jurisdiction = new List<CodeableConcept>((IEnumerable<CodeableConcept>)r_),
                PurposeElement = s_,
                CopyrightElement = t_,
                Origin = new List<TestScript.OriginComponent>((IEnumerable<TestScript.OriginComponent>)u_),
                Destination = new List<TestScript.DestinationComponent>((IEnumerable<TestScript.DestinationComponent>)v_),
                Metadata = w_,
                Fixture = new List<TestScript.FixtureComponent>((IEnumerable<TestScript.FixtureComponent>)x_),
                Profile = new List<ResourceReference>((IEnumerable<ResourceReference>)y_),
                Variable = new List<TestScript.VariableComponent>((IEnumerable<TestScript.VariableComponent>)z_),
                Setup = aa_,
                Test = new List<TestScript.TestComponent>((IEnumerable<TestScript.TestComponent>)ab_),
                Teardown = ac_,
            };
            return ad_;
        }

        IEnumerable<TestScript> c_ = context.Operators.Select<TestScript, TestScript>((IEnumerable<TestScript>)a_, b_);
        IEnumerable<TestScript> d_ = context.Operators.Distinct<TestScript>(c_);
        TestScript e_ = context.Operators.SingletonFrom<TestScript>(d_);
        return e_;
    }


    [CqlFunctionDefinition("ValueSetResource")]
    public ValueSet ValueSetResource(CqlContext context, ValueSet arg)
    {
        ValueSet[] a_ = [
            arg,
        ];

        ValueSet b_(ValueSet a) {
            FhirUri f_ = a?.UrlElement;
            List<Identifier> g_ = a?.Identifier;
            FhirString h_ = a?.VersionElement;
            FhirString i_ = a?.NameElement;
            FhirString j_ = a?.TitleElement;
            Code<PublicationStatus> k_ = a?.StatusElement;
            FhirBoolean l_ = a?.ExperimentalElement;
            FhirDateTime m_ = a?.DateElement;
            FhirString n_ = a?.PublisherElement;
            List<ContactDetail> o_ = a?.Contact;
            Markdown p_ = a?.DescriptionElement;
            List<UsageContext> q_ = a?.UseContext;
            List<CodeableConcept> r_ = a?.Jurisdiction;
            FhirBoolean s_ = a?.ImmutableElement;
            Markdown t_ = a?.PurposeElement;
            Markdown u_ = a?.CopyrightElement;
            ValueSet.ComposeComponent v_ = a?.Compose;
            ValueSet.ExpansionComponent w_ = a?.Expansion;
            ValueSet x_ = new ValueSet
            {
                UrlElement = f_,
                Identifier = new List<Identifier>((IEnumerable<Identifier>)g_),
                VersionElement = h_,
                NameElement = i_,
                TitleElement = j_,
                StatusElement = k_,
                ExperimentalElement = l_,
                DateElement = m_,
                PublisherElement = n_,
                Contact = new List<ContactDetail>((IEnumerable<ContactDetail>)o_),
                DescriptionElement = p_,
                UseContext = new List<UsageContext>((IEnumerable<UsageContext>)q_),
                Jurisdiction = new List<CodeableConcept>((IEnumerable<CodeableConcept>)r_),
                ImmutableElement = s_,
                PurposeElement = t_,
                CopyrightElement = u_,
                Compose = v_,
                Expansion = w_,
            };
            return x_;
        }

        IEnumerable<ValueSet> c_ = context.Operators.Select<ValueSet, ValueSet>((IEnumerable<ValueSet>)a_, b_);
        IEnumerable<ValueSet> d_ = context.Operators.Distinct<ValueSet>(c_);
        ValueSet e_ = context.Operators.SingletonFrom<ValueSet>(d_);
        return e_;
    }


    [CqlFunctionDefinition("VerificationResultResource")]
    public VerificationResult VerificationResultResource(CqlContext context, VerificationResult arg)
    {
        VerificationResult[] a_ = [
            arg,
        ];

        VerificationResult b_(VerificationResult a) {
            List<ResourceReference> f_ = a?.Target;
            List<FhirString> g_ = a?.TargetLocationElement;
            CodeableConcept h_ = a?.Need;
            Code<VerificationResult.StatusCode> i_ = a?.StatusElement;
            FhirDateTime j_ = a?.StatusDateElement;
            CodeableConcept k_ = a?.ValidationType;
            List<CodeableConcept> l_ = a?.ValidationProcess;
            Timing m_ = a?.Frequency;
            FhirDateTime n_ = a?.LastPerformedElement;
            Date o_ = a?.NextScheduledElement;
            CodeableConcept p_ = a?.FailureAction;
            List<VerificationResult.PrimarySourceComponent> q_ = a?.PrimarySource;
            VerificationResult.AttestationComponent r_ = a?.Attestation;
            List<VerificationResult.ValidatorComponent> s_ = a?.Validator;
            VerificationResult t_ = new VerificationResult
            {
                Target = new List<ResourceReference>((IEnumerable<ResourceReference>)f_),
                TargetLocationElement = new List<FhirString>((IEnumerable<FhirString>)g_),
                Need = h_,
                StatusElement = i_,
                StatusDateElement = j_,
                ValidationType = k_,
                ValidationProcess = new List<CodeableConcept>((IEnumerable<CodeableConcept>)l_),
                Frequency = m_,
                LastPerformedElement = n_,
                NextScheduledElement = o_,
                FailureAction = p_,
                PrimarySource = new List<VerificationResult.PrimarySourceComponent>((IEnumerable<VerificationResult.PrimarySourceComponent>)q_),
                Attestation = r_,
                Validator = new List<VerificationResult.ValidatorComponent>((IEnumerable<VerificationResult.ValidatorComponent>)s_),
            };
            return t_;
        }

        IEnumerable<VerificationResult> c_ = context.Operators.Select<VerificationResult, VerificationResult>((IEnumerable<VerificationResult>)a_, b_);
        IEnumerable<VerificationResult> d_ = context.Operators.Distinct<VerificationResult>(c_);
        VerificationResult e_ = context.Operators.SingletonFrom<VerificationResult>(d_);
        return e_;
    }


    [CqlFunctionDefinition("VisionPrescriptionResource")]
    public VisionPrescription VisionPrescriptionResource(CqlContext context, VisionPrescription arg)
    {
        VisionPrescription[] a_ = [
            arg,
        ];

        VisionPrescription b_(VisionPrescription a) {
            List<Identifier> f_ = a?.Identifier;
            Code<FinancialResourceStatusCodes> g_ = a?.StatusElement;
            FhirDateTime h_ = a?.CreatedElement;
            ResourceReference i_ = a?.Patient;
            ResourceReference j_ = a?.Encounter;
            FhirDateTime k_ = a?.DateWrittenElement;
            ResourceReference l_ = a?.Prescriber;
            List<VisionPrescription.LensSpecificationComponent> m_ = a?.LensSpecification;
            VisionPrescription n_ = new VisionPrescription
            {
                Identifier = new List<Identifier>((IEnumerable<Identifier>)f_),
                StatusElement = g_,
                CreatedElement = h_,
                Patient = i_,
                Encounter = j_,
                DateWrittenElement = k_,
                Prescriber = l_,
                LensSpecification = new List<VisionPrescription.LensSpecificationComponent>((IEnumerable<VisionPrescription.LensSpecificationComponent>)m_),
            };
            return n_;
        }

        IEnumerable<VisionPrescription> c_ = context.Operators.Select<VisionPrescription, VisionPrescription>((IEnumerable<VisionPrescription>)a_, b_);
        IEnumerable<VisionPrescription> d_ = context.Operators.Distinct<VisionPrescription>(c_);
        VisionPrescription e_ = context.Operators.SingletonFrom<VisionPrescription>(d_);
        return e_;
    }


    #endregion Functions and Expressions

    #region Singleton Lifetime Members

    private FHIRConversionTest_2023_0_0() {}

    public static FHIRConversionTest_2023_0_0 Instance { get; } = new();

    #endregion

    #region ILibrary Implementation

    public string Name => "FHIRConversionTest";
    public string Version => "2023.0.0";
    public ILibrary[] Dependencies => [FHIRHelpers_4_0_1.Instance];

    #endregion ILibrary Implementation

}

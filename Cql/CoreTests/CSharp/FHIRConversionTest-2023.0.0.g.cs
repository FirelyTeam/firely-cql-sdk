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

[System.CodeDom.Compiler.GeneratedCode(".NET Code Generation", "4.1.0.0")]
[CqlLibrary("FHIRConversionTest", "2023.0.0")]
public partial class FHIRConversionTest_2023_0_0 : ILibrary, ISingleton<FHIRConversionTest_2023_0_0>
{
    #region Functions and Expressions

    [CqlFunctionDefinition("AccountResource")]
    public Account AccountResource(CqlContext context, Account arg)
    {
        Account[] a_ = [
            arg /* CQL: 8:3-8:5 */,
        ];

        Account b_(Account a) {
            List<Identifier> f_ = a?.Identifier;
            Code<Account.AccountStatus> g_ = a?.StatusElement /* CQL: 11:14-11:21 */;
            CodeableConcept h_ = a?.Type /* CQL: 12:12-12:17 */;
            FhirString i_ = a?.NameElement /* CQL: 13:12-13:17 */;
            List<ResourceReference> j_ = a?.Subject;
            Period k_ = a?.ServicePeriod /* CQL: 15:21-15:35 */;
            List<Account.CoverageComponent> l_ = a?.Coverage;
            ResourceReference m_ = a?.Owner /* CQL: 17:13-17:19 */;
            FhirString n_ = a?.DescriptionElement /* CQL: 18:19-18:31 */;
            List<Account.GuarantorComponent> o_ = a?.Guarantor;
            ResourceReference p_ = a?.PartOf /* CQL: 20:14-20:21 */;
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
            arg /* CQL: 24:3-24:5 */,
        ];

        ActivityDefinition b_(ActivityDefinition a) {
            FhirUri f_ = a?.UrlElement /* CQL: 26:11-26:15 */;
            List<Identifier> g_ = a?.Identifier;
            FhirString h_ = a?.VersionElement /* CQL: 28:15-28:23 */;
            FhirString i_ = a?.NameElement /* CQL: 29:12-29:17 */;
            FhirString j_ = a?.TitleElement /* CQL: 30:13-30:19 */;
            FhirString k_ = a?.SubtitleElement /* CQL: 31:16-31:25 */;
            Code<PublicationStatus> l_ = a?.StatusElement /* CQL: 32:14-32:21 */;
            FhirBoolean m_ = a?.ExperimentalElement /* CQL: 33:20-33:33 */;
            DataType n_ = a?.Subject;
            FhirDateTime o_ = a?.DateElement /* CQL: 35:12-35:17 */;
            FhirString p_ = a?.PublisherElement /* CQL: 36:17-36:27 */;
            List<ContactDetail> q_ = a?.Contact;
            Markdown r_ = a?.DescriptionElement /* CQL: 38:19-38:31 */;
            List<UsageContext> s_ = a?.UseContext;
            List<CodeableConcept> t_ = a?.Jurisdiction;
            Markdown u_ = a?.PurposeElement /* CQL: 41:15-41:23 */;
            FhirString v_ = a?.UsageElement /* CQL: 42:13-42:19 */;
            Markdown w_ = a?.CopyrightElement /* CQL: 43:17-43:27 */;
            Date x_ = a?.ApprovalDateElement /* CQL: 44:20-44:33 */;
            Date y_ = a?.LastReviewDateElement /* CQL: 45:22-45:37 */;
            Period z_ = a?.EffectivePeriod /* CQL: 46:23-46:39 */;
            List<CodeableConcept> aa_ = a?.Topic;
            List<ContactDetail> ab_ = a?.Author;
            List<ContactDetail> ac_ = a?.Editor;
            List<ContactDetail> ad_ = a?.Reviewer;
            List<ContactDetail> ae_ = a?.Endorser;
            List<RelatedArtifact> af_ = a?.RelatedArtifact;
            List<Canonical> ag_ = a?.LibraryElement;
            Code<ActivityDefinition.RequestResourceType> ah_ = a?.KindElement /* CQL: 54:12-54:17 */;
            Canonical ai_ = a?.ProfileElement /* CQL: 55:15-55:23 */;
            CodeableConcept aj_ = a?.Code /* CQL: 56:12-56:17 */;
            Code<RequestIntent> ak_ = a?.IntentElement /* CQL: 57:14-57:21 */;
            Code<RequestPriority> al_ = a?.PriorityElement /* CQL: 58:16-58:25 */;
            FhirBoolean am_ = a?.DoNotPerformElement /* CQL: 59:20-59:33 */;
            DataType an_ = a?.Timing;
            ResourceReference ao_ = a?.Location /* CQL: 61:16-61:25 */;
            List<ActivityDefinition.ParticipantComponent> ap_ = a?.Participant;
            DataType aq_ = a?.Product;
            Quantity ar_ = a?.Quantity /* CQL: 64:16-64:25 */;
            List<Dosage> as_ = a?.Dosage;
            List<CodeableConcept> at_ = a?.BodySite;
            List<ResourceReference> au_ = a?.SpecimenRequirement;
            List<ResourceReference> av_ = a?.ObservationRequirement;
            List<ResourceReference> aw_ = a?.ObservationResultRequirement;
            Canonical ax_ = a?.TransformElement /* CQL: 70:17-70:27 */;
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
            arg /* CQL: 75:3-75:5 */,
        ];

        AdverseEvent b_(AdverseEvent a) {
            Identifier f_ = a?.Identifier /* CQL: 77:18-77:29 */;
            Code<AdverseEvent.AdverseEventActuality> g_ = a?.ActualityElement /* CQL: 78:17-78:27 */;
            List<CodeableConcept> h_ = a?.Category;
            CodeableConcept i_ = a?.Event /* CQL: 80:13-80:19 */;
            ResourceReference j_ = a?.Subject /* CQL: 81:15-81:23 */;
            ResourceReference k_ = a?.Encounter /* CQL: 82:17-82:27 */;
            FhirDateTime l_ = a?.DateElement /* CQL: 83:12-83:17 */;
            FhirDateTime m_ = a?.DetectedElement /* CQL: 84:16-84:25 */;
            FhirDateTime n_ = a?.RecordedDateElement /* CQL: 85:20-85:33 */;
            List<ResourceReference> o_ = a?.ResultingCondition;
            ResourceReference p_ = a?.Location /* CQL: 87:16-87:25 */;
            CodeableConcept q_ = a?.Seriousness /* CQL: 88:19-88:31 */;
            CodeableConcept r_ = a?.Severity /* CQL: 89:16-89:25 */;
            CodeableConcept s_ = a?.Outcome /* CQL: 90:15-90:23 */;
            ResourceReference t_ = a?.Recorder /* CQL: 91:16-91:25 */;
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
            arg /* CQL: 100:3-100:5 */,
        ];

        AllergyIntolerance b_(AllergyIntolerance a) {
            List<Identifier> f_ = a?.Identifier;
            CodeableConcept g_ = a?.ClinicalStatus /* CQL: 103:22-103:37 */;
            CodeableConcept h_ = a?.VerificationStatus /* CQL: 104:26-104:45 */;
            Code<AllergyIntolerance.AllergyIntoleranceType> i_ = a?.TypeElement /* CQL: 105:12-105:17 */;
            List<Code<AllergyIntolerance.AllergyIntoleranceCategory>> j_ = a?.CategoryElement;
            Code<AllergyIntolerance.AllergyIntoleranceCriticality> k_ = a?.CriticalityElement /* CQL: 107:19-107:31 */;
            CodeableConcept l_ = a?.Code /* CQL: 108:12-108:17 */;
            ResourceReference m_ = a?.Patient /* CQL: 109:15-109:23 */;
            ResourceReference n_ = a?.Encounter /* CQL: 110:17-110:27 */;
            DataType o_ = a?.Onset;
            FhirDateTime p_ = a?.RecordedDateElement /* CQL: 112:20-112:33 */;
            ResourceReference q_ = a?.Recorder /* CQL: 113:16-113:25 */;
            ResourceReference r_ = a?.Asserter /* CQL: 114:16-114:25 */;
            FhirDateTime s_ = a?.LastOccurrenceElement /* CQL: 115:22-115:37 */;
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
            arg /* CQL: 121:3-121:5 */,
        ];

        Appointment b_(Appointment a) {
            List<Identifier> f_ = a?.Identifier;
            Code<Appointment.AppointmentStatus> g_ = a?.StatusElement /* CQL: 124:14-124:21 */;
            CodeableConcept h_ = a?.CancelationReason /* CQL: 125:25-125:43 */;
            List<CodeableConcept> i_ = a?.ServiceCategory;
            List<CodeableConcept> j_ = a?.ServiceType;
            List<CodeableConcept> k_ = a?.Specialty;
            CodeableConcept l_ = a?.AppointmentType /* CQL: 129:23-129:39 */;
            List<CodeableConcept> m_ = a?.ReasonCode;
            List<ResourceReference> n_ = a?.ReasonReference;
            UnsignedInt o_ = a?.PriorityElement;
            Integer p_ = context.Operators.Convert<Integer>(o_);
            UnsignedInt q_ = context.Operators.Convert<UnsignedInt>(p_);
            FhirString r_ = a?.DescriptionElement /* CQL: 133:19-133:31 */;
            List<ResourceReference> s_ = a?.SupportingInformation;
            Instant t_ = a?.StartElement /* CQL: 135:13-135:19 */;
            Instant u_ = a?.EndElement /* CQL: 136:11-136:15 */;
            PositiveInt v_ = a?.MinutesDurationElement;
            Integer w_ = context.Operators.Convert<Integer>(v_);
            PositiveInt x_ = context.Operators.Convert<PositiveInt>(w_);
            List<ResourceReference> y_ = a?.Slot;
            FhirDateTime z_ = a?.CreatedElement /* CQL: 139:15-139:23 */;
            FhirString aa_ = a?.CommentElement /* CQL: 140:15-140:23 */;
            FhirString ab_ = a?.PatientInstructionElement /* CQL: 141:26-141:45 */;
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
            arg /* CQL: 148:3-148:5 */,
        ];

        AppointmentResponse b_(AppointmentResponse a) {
            List<Identifier> f_ = a?.Identifier;
            ResourceReference g_ = a?.Appointment /* CQL: 151:19-151:31 */;
            Instant h_ = a?.StartElement /* CQL: 152:13-152:19 */;
            Instant i_ = a?.EndElement /* CQL: 153:11-153:15 */;
            List<CodeableConcept> j_ = a?.ParticipantType;
            ResourceReference k_ = a?.Actor /* CQL: 155:13-155:19 */;
            Code<ParticipationStatus> l_ = a?.ParticipantStatusElement /* CQL: 156:25-156:43 */;
            FhirString m_ = a?.CommentElement /* CQL: 157:15-157:23 */;
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
            arg /* CQL: 161:3-161:5 */,
        ];

        AuditEvent b_(AuditEvent a) {
            Coding f_ = a?.Type /* CQL: 163:12-163:17 */;
            List<Coding> g_ = a?.Subtype;
            Code<AuditEvent.AuditEventAction> h_ = a?.ActionElement /* CQL: 165:14-165:21 */;
            Period i_ = a?.Period /* CQL: 166:14-166:21 */;
            Instant j_ = a?.RecordedElement /* CQL: 167:16-167:25 */;
            Code<AuditEvent.AuditEventOutcome> k_ = a?.OutcomeElement /* CQL: 168:15-168:23 */;
            FhirString l_ = a?.OutcomeDescElement /* CQL: 169:19-169:31 */;
            List<CodeableConcept> m_ = a?.PurposeOfEvent;
            List<AuditEvent.AgentComponent> n_ = a?.Agent;
            AuditEvent.SourceComponent o_ = a?.Source /* CQL: 172:14-172:21 */;
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
            arg /* CQL: 177:3-177:5 */,
        ];

        Basic b_(Basic a) {
            List<Identifier> f_ = a?.Identifier;
            CodeableConcept g_ = a?.Code /* CQL: 180:12-180:17 */;
            ResourceReference h_ = a?.Subject /* CQL: 181:15-181:23 */;
            Date i_ = a?.CreatedElement /* CQL: 182:15-182:23 */;
            ResourceReference j_ = a?.Author /* CQL: 183:14-183:21 */;
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
            arg /* CQL: 187:3-187:5 */,
        ];

        BiologicallyDerivedProduct b_(BiologicallyDerivedProduct a) {
            List<Identifier> f_ = a?.Identifier;
            Code<BiologicallyDerivedProduct.BiologicallyDerivedProductCategory> g_ = a?.ProductCategoryElement /* CQL: 190:23-190:39 */;
            CodeableConcept h_ = a?.ProductCode /* CQL: 191:19-191:31 */;
            Code<BiologicallyDerivedProduct.BiologicallyDerivedProductStatus> i_ = a?.StatusElement /* CQL: 192:14-192:21 */;
            List<ResourceReference> j_ = a?.Request;
            Integer k_ = a?.QuantityElement /* CQL: 194:16-194:25 */;
            List<ResourceReference> l_ = a?.Parent;
            BiologicallyDerivedProduct.CollectionComponent m_ = a?.Collection /* CQL: 196:18-196:29 */;
            List<BiologicallyDerivedProduct.ProcessingComponent> n_ = a?.Processing;
            BiologicallyDerivedProduct.ManipulationComponent o_ = a?.Manipulation /* CQL: 198:20-198:33 */;
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
            arg /* CQL: 203:3-203:5 */,
        ];

        BodyStructure b_(BodyStructure a) {
            List<Identifier> f_ = a?.Identifier;
            FhirBoolean g_ = a?.ActiveElement /* CQL: 206:14-206:21 */;
            CodeableConcept h_ = a?.Morphology /* CQL: 207:18-207:29 */;
            CodeableConcept i_ = a?.Location /* CQL: 208:16-208:25 */;
            List<CodeableConcept> j_ = a?.LocationQualifier;
            FhirString k_ = a?.DescriptionElement /* CQL: 210:19-210:31 */;
            List<Attachment> l_ = a?.Image;
            ResourceReference m_ = a?.Patient /* CQL: 212:15-212:23 */;
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
            arg /* CQL: 247:3-247:5 */,
        ];

        CarePlan b_(CarePlan a) {
            List<Identifier> f_ = a?.Identifier;
            List<Canonical> g_ = a?.InstantiatesCanonicalElement;
            List<FhirUri> h_ = a?.InstantiatesUriElement;
            List<ResourceReference> i_ = a?.BasedOn;
            List<ResourceReference> j_ = a?.Replaces;
            List<ResourceReference> k_ = a?.PartOf;
            Code<RequestStatus> l_ = a?.StatusElement /* CQL: 255:14-255:21 */;
            Code<CarePlan.CarePlanIntent> m_ = a?.IntentElement /* CQL: 256:14-256:21 */;
            List<CodeableConcept> n_ = a?.Category;
            FhirString o_ = a?.TitleElement /* CQL: 258:13-258:19 */;
            FhirString p_ = a?.DescriptionElement /* CQL: 259:19-259:31 */;
            ResourceReference q_ = a?.Subject /* CQL: 260:15-260:23 */;
            ResourceReference r_ = a?.Encounter /* CQL: 261:17-261:27 */;
            Period s_ = a?.Period /* CQL: 262:14-262:21 */;
            FhirDateTime t_ = a?.CreatedElement /* CQL: 263:15-263:23 */;
            ResourceReference u_ = a?.Author /* CQL: 264:14-264:21 */;
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
            arg /* CQL: 275:3-275:5 */,
        ];

        CareTeam b_(CareTeam a) {
            List<Identifier> f_ = a?.Identifier;
            Code<CareTeam.CareTeamStatus> g_ = a?.StatusElement /* CQL: 278:14-278:21 */;
            List<CodeableConcept> h_ = a?.Category;
            FhirString i_ = a?.NameElement /* CQL: 280:12-280:17 */;
            ResourceReference j_ = a?.Subject /* CQL: 281:15-281:23 */;
            ResourceReference k_ = a?.Encounter /* CQL: 282:17-282:27 */;
            Period l_ = a?.Period /* CQL: 283:14-283:21 */;
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
            arg /* CQL: 293:3-293:5 */,
        ];

        CatalogEntry b_(CatalogEntry a) {
            List<Identifier> f_ = a?.Identifier;
            CodeableConcept g_ = a?.Type /* CQL: 296:12-296:17 */;
            FhirBoolean h_ = a?.OrderableElement /* CQL: 297:17-297:27 */;
            ResourceReference i_ = a?.ReferencedItem /* CQL: 298:22-298:37 */;
            List<Identifier> j_ = a?.AdditionalIdentifier;
            List<CodeableConcept> k_ = a?.Classification;
            Code<PublicationStatus> l_ = a?.StatusElement /* CQL: 301:14-301:21 */;
            Period m_ = a?.ValidityPeriod /* CQL: 302:22-302:37 */;
            FhirDateTime n_ = a?.ValidToElement /* CQL: 303:15-303:23 */;
            FhirDateTime o_ = a?.LastUpdatedElement /* CQL: 304:19-304:31 */;
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
            arg /* CQL: 311:3-311:5 */,
        ];

        ChargeItem b_(ChargeItem a) {
            List<Identifier> f_ = a?.Identifier;
            List<FhirUri> g_ = a?.DefinitionUriElement;
            List<Canonical> h_ = a?.DefinitionCanonicalElement;
            Code<ChargeItem.ChargeItemStatus> i_ = a?.StatusElement /* CQL: 316:14-316:21 */;
            List<ResourceReference> j_ = a?.PartOf;
            CodeableConcept k_ = a?.Code /* CQL: 318:12-318:17 */;
            ResourceReference l_ = a?.Subject /* CQL: 319:15-319:23 */;
            ResourceReference m_ = a?.Context /* CQL: 320:15-320:23 */;
            DataType n_ = a?.Occurrence;
            List<ChargeItem.PerformerComponent> o_ = a?.Performer;
            ResourceReference p_ = a?.PerformingOrganization /* CQL: 323:30-323:53 */;
            ResourceReference q_ = a?.RequestingOrganization /* CQL: 324:30-324:53 */;
            ResourceReference r_ = a?.CostCenter /* CQL: 325:18-325:29 */;
            Quantity s_ = a?.Quantity /* CQL: 326:16-326:25 */;
            List<CodeableConcept> t_ = a?.Bodysite;
            FhirDecimal u_ = a?.FactorOverrideElement /* CQL: 328:22-328:37 */;
            Money v_ = a?.PriceOverride /* CQL: 329:21-329:35 */;
            FhirString w_ = a?.OverrideReasonElement /* CQL: 330:22-330:37 */;
            ResourceReference x_ = a?.Enterer /* CQL: 331:15-331:23 */;
            FhirDateTime y_ = a?.EnteredDateElement /* CQL: 332:19-332:31 */;
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
            arg /* CQL: 342:3-342:5 */,
        ];

        ChargeItemDefinition b_(ChargeItemDefinition a) {
            FhirUri f_ = a?.UrlElement /* CQL: 344:11-344:15 */;
            List<Identifier> g_ = a?.Identifier;
            FhirString h_ = a?.VersionElement /* CQL: 346:15-346:23 */;
            FhirString i_ = a?.TitleElement /* CQL: 347:13-347:19 */;
            List<FhirUri> j_ = a?.DerivedFromUriElement;
            List<Canonical> k_ = a?.PartOfElement;
            List<Canonical> l_ = a?.ReplacesElement;
            Code<PublicationStatus> m_ = a?.StatusElement /* CQL: 351:14-351:21 */;
            FhirBoolean n_ = a?.ExperimentalElement /* CQL: 352:20-352:33 */;
            FhirDateTime o_ = a?.DateElement /* CQL: 353:12-353:17 */;
            FhirString p_ = a?.PublisherElement /* CQL: 354:17-354:27 */;
            List<ContactDetail> q_ = a?.Contact;
            Markdown r_ = a?.DescriptionElement /* CQL: 356:19-356:31 */;
            List<UsageContext> s_ = a?.UseContext;
            List<CodeableConcept> t_ = a?.Jurisdiction;
            Markdown u_ = a?.CopyrightElement /* CQL: 359:17-359:27 */;
            Date v_ = a?.ApprovalDateElement /* CQL: 360:20-360:33 */;
            Date w_ = a?.LastReviewDateElement /* CQL: 361:22-361:37 */;
            Period x_ = a?.EffectivePeriod /* CQL: 362:23-362:39 */;
            CodeableConcept y_ = a?.Code /* CQL: 363:12-363:17 */;
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
            arg /* CQL: 370:3-370:5 */,
        ];

        Claim b_(Claim a) {
            List<Identifier> f_ = a?.Identifier;
            Code<FinancialResourceStatusCodes> g_ = a?.StatusElement /* CQL: 373:14-373:21 */;
            CodeableConcept h_ = a?.Type /* CQL: 374:12-374:17 */;
            CodeableConcept i_ = a?.SubType /* CQL: 375:15-375:23 */;
            Code<ClaimUseCode> j_ = a?.UseElement /* CQL: 376:11-376:15 */;
            ResourceReference k_ = a?.Patient /* CQL: 377:15-377:23 */;
            Period l_ = a?.BillablePeriod /* CQL: 378:22-378:37 */;
            FhirDateTime m_ = a?.CreatedElement /* CQL: 379:15-379:23 */;
            ResourceReference n_ = a?.Enterer /* CQL: 380:15-380:23 */;
            ResourceReference o_ = a?.Insurer /* CQL: 381:15-381:23 */;
            ResourceReference p_ = a?.Provider /* CQL: 382:16-382:25 */;
            CodeableConcept q_ = a?.Priority /* CQL: 383:16-383:25 */;
            CodeableConcept r_ = a?.FundsReserve /* CQL: 384:20-384:33 */;
            List<Claim.RelatedClaimComponent> s_ = a?.Related;
            ResourceReference t_ = a?.Prescription /* CQL: 386:20-386:33 */;
            ResourceReference u_ = a?.OriginalPrescription /* CQL: 387:28-387:49 */;
            Claim.PayeeComponent v_ = a?.Payee /* CQL: 388:13-388:19 */;
            ResourceReference w_ = a?.Referral /* CQL: 389:16-389:25 */;
            ResourceReference x_ = a?.Facility /* CQL: 390:16-390:25 */;
            List<Claim.CareTeamComponent> y_ = a?.CareTeam;
            List<Claim.SupportingInformationComponent> z_ = a?.SupportingInfo;
            List<Claim.DiagnosisComponent> aa_ = a?.Diagnosis;
            List<Claim.ProcedureComponent> ab_ = a?.Procedure;
            List<Claim.InsuranceComponent> ac_ = a?.Insurance;
            Claim.AccidentComponent ad_ = a?.Accident /* CQL: 396:16-396:25 */;
            List<Claim.ItemComponent> ae_ = a?.Item;
            Money af_ = a?.Total /* CQL: 398:13-398:19 */;
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
            arg /* CQL: 402:3-402:5 */,
        ];

        ClaimResponse b_(ClaimResponse a) {
            List<Identifier> f_ = a?.Identifier;
            Code<FinancialResourceStatusCodes> g_ = a?.StatusElement /* CQL: 405:14-405:21 */;
            CodeableConcept h_ = a?.Type /* CQL: 406:12-406:17 */;
            CodeableConcept i_ = a?.SubType /* CQL: 407:15-407:23 */;
            Code<ClaimUseCode> j_ = a?.UseElement /* CQL: 408:11-408:15 */;
            ResourceReference k_ = a?.Patient /* CQL: 409:15-409:23 */;
            FhirDateTime l_ = a?.CreatedElement /* CQL: 410:15-410:23 */;
            ResourceReference m_ = a?.Insurer /* CQL: 411:15-411:23 */;
            ResourceReference n_ = a?.Requestor /* CQL: 412:17-412:27 */;
            ResourceReference o_ = a?.Request /* CQL: 413:15-413:23 */;
            Code<ClaimProcessingCodes> p_ = a?.OutcomeElement /* CQL: 414:15-414:23 */;
            FhirString q_ = a?.DispositionElement /* CQL: 415:19-415:31 */;
            FhirString r_ = a?.PreAuthRefElement /* CQL: 416:18-416:29 */;
            Period s_ = a?.PreAuthPeriod /* CQL: 417:21-417:35 */;
            CodeableConcept t_ = a?.PayeeType /* CQL: 418:17-418:27 */;
            List<ClaimResponse.ItemComponent> u_ = a?.Item;
            List<ClaimResponse.AddedItemComponent> v_ = a?.AddItem;
            List<ClaimResponse.AdjudicationComponent> w_ = a?.Adjudication;
            List<ClaimResponse.TotalComponent> x_ = a?.Total;
            ClaimResponse.PaymentComponent y_ = a?.Payment /* CQL: 423:15-423:23 */;
            CodeableConcept z_ = a?.FundsReserve /* CQL: 424:20-424:33 */;
            CodeableConcept aa_ = a?.FormCode /* CQL: 425:16-425:25 */;
            Attachment ab_ = a?.Form /* CQL: 426:12-426:17 */;
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
            arg /* CQL: 434:3-434:5 */,
        ];

        ClinicalImpression b_(ClinicalImpression a) {
            List<Identifier> f_ = a?.Identifier;
            Code<ClinicalImpression.ClinicalImpressionStatus> g_ = a?.StatusElement /* CQL: 437:14-437:21 */;
            CodeableConcept h_ = a?.StatusReason /* CQL: 438:20-438:33 */;
            CodeableConcept i_ = a?.Code /* CQL: 439:12-439:17 */;
            FhirString j_ = a?.DescriptionElement /* CQL: 440:19-440:31 */;
            ResourceReference k_ = a?.Subject /* CQL: 441:15-441:23 */;
            ResourceReference l_ = a?.Encounter /* CQL: 442:17-442:27 */;
            DataType m_ = a?.Effective;
            FhirDateTime n_ = a?.DateElement /* CQL: 444:12-444:17 */;
            ResourceReference o_ = a?.Assessor /* CQL: 445:16-445:25 */;
            ResourceReference p_ = a?.Previous /* CQL: 446:16-446:25 */;
            List<ResourceReference> q_ = a?.Problem;
            List<ClinicalImpression.InvestigationComponent> r_ = a?.Investigation;
            List<FhirUri> s_ = a?.ProtocolElement;
            FhirString t_ = a?.SummaryElement /* CQL: 450:15-450:23 */;
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
            arg /* CQL: 459:3-459:5 */,
        ];

        CodeSystem b_(CodeSystem a) {
            FhirUri f_ = a?.UrlElement /* CQL: 461:11-461:15 */;
            List<Identifier> g_ = a?.Identifier;
            FhirString h_ = a?.VersionElement /* CQL: 463:15-463:23 */;
            FhirString i_ = a?.NameElement /* CQL: 464:12-464:17 */;
            FhirString j_ = a?.TitleElement /* CQL: 465:13-465:19 */;
            Code<PublicationStatus> k_ = a?.StatusElement /* CQL: 466:14-466:21 */;
            FhirBoolean l_ = a?.ExperimentalElement /* CQL: 467:20-467:33 */;
            FhirDateTime m_ = a?.DateElement /* CQL: 468:12-468:17 */;
            FhirString n_ = a?.PublisherElement /* CQL: 469:17-469:27 */;
            List<ContactDetail> o_ = a?.Contact;
            Markdown p_ = a?.DescriptionElement /* CQL: 471:19-471:31 */;
            List<UsageContext> q_ = a?.UseContext;
            List<CodeableConcept> r_ = a?.Jurisdiction;
            Markdown s_ = a?.PurposeElement /* CQL: 474:15-474:23 */;
            Markdown t_ = a?.CopyrightElement /* CQL: 475:17-475:27 */;
            FhirBoolean u_ = a?.CaseSensitiveElement /* CQL: 476:21-476:35 */;
            Canonical v_ = a?.ValueSetElement /* CQL: 477:16-477:25 */;
            Code<CodeSystem.CodeSystemHierarchyMeaning> w_ = a?.HierarchyMeaningElement /* CQL: 478:24-478:41 */;
            FhirBoolean x_ = a?.CompositionalElement /* CQL: 479:21-479:35 */;
            FhirBoolean y_ = a?.VersionNeededElement /* CQL: 480:21-480:35 */;
            Code<CodeSystemContentMode> z_ = a?.ContentElement /* CQL: 481:15-481:23 */;
            Canonical aa_ = a?.SupplementsElement /* CQL: 482:19-482:31 */;
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
            arg /* CQL: 490:3-490:5 */,
        ];

        Communication b_(Communication a) {
            List<Identifier> f_ = a?.Identifier;
            List<Canonical> g_ = a?.InstantiatesCanonicalElement;
            List<FhirUri> h_ = a?.InstantiatesUriElement;
            List<ResourceReference> i_ = a?.BasedOn;
            List<ResourceReference> j_ = a?.PartOf;
            List<ResourceReference> k_ = a?.InResponseTo;
            Code<EventStatus> l_ = a?.StatusElement /* CQL: 498:14-498:21 */;
            CodeableConcept m_ = a?.StatusReason /* CQL: 499:20-499:33 */;
            List<CodeableConcept> n_ = a?.Category;
            Code<RequestPriority> o_ = a?.PriorityElement /* CQL: 501:16-501:25 */;
            List<CodeableConcept> p_ = a?.Medium;
            ResourceReference q_ = a?.Subject /* CQL: 503:15-503:23 */;
            CodeableConcept r_ = a?.Topic /* CQL: 504:13-504:19 */;
            List<ResourceReference> s_ = a?.About;
            ResourceReference t_ = a?.Encounter /* CQL: 506:17-506:27 */;
            FhirDateTime u_ = a?.SentElement /* CQL: 507:12-507:17 */;
            FhirDateTime v_ = a?.ReceivedElement /* CQL: 508:16-508:25 */;
            List<ResourceReference> w_ = a?.Recipient;
            ResourceReference x_ = a?.Sender /* CQL: 510:14-510:21 */;
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
            arg /* CQL: 518:3-518:5 */,
        ];

        CommunicationRequest b_(CommunicationRequest a) {
            List<Identifier> f_ = a?.Identifier;
            List<ResourceReference> g_ = a?.BasedOn;
            List<ResourceReference> h_ = a?.Replaces;
            Identifier i_ = a?.GroupIdentifier /* CQL: 523:23-523:39 */;
            Code<RequestStatus> j_ = a?.StatusElement /* CQL: 524:14-524:21 */;
            CodeableConcept k_ = a?.StatusReason /* CQL: 525:20-525:33 */;
            List<CodeableConcept> l_ = a?.Category;
            Code<RequestPriority> m_ = a?.PriorityElement /* CQL: 527:16-527:25 */;
            FhirBoolean n_ = a?.DoNotPerformElement /* CQL: 528:20-528:33 */;
            List<CodeableConcept> o_ = a?.Medium;
            ResourceReference p_ = a?.Subject /* CQL: 530:15-530:23 */;
            List<ResourceReference> q_ = a?.About;
            ResourceReference r_ = a?.Encounter /* CQL: 532:17-532:27 */;
            List<CommunicationRequest.PayloadComponent> s_ = a?.Payload;
            DataType t_ = a?.Occurrence;
            FhirDateTime u_ = a?.AuthoredOnElement /* CQL: 535:18-535:29 */;
            ResourceReference v_ = a?.Requester /* CQL: 536:17-536:27 */;
            List<ResourceReference> w_ = a?.Recipient;
            ResourceReference x_ = a?.Sender /* CQL: 538:14-538:21 */;
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
            arg /* CQL: 564:3-564:5 */,
        ];

        Composition b_(Composition a) {
            Identifier f_ = a?.Identifier /* CQL: 566:18-566:29 */;
            Code<CompositionStatus> g_ = a?.StatusElement /* CQL: 567:14-567:21 */;
            CodeableConcept h_ = a?.Type /* CQL: 568:12-568:17 */;
            List<CodeableConcept> i_ = a?.Category;
            ResourceReference j_ = a?.Subject /* CQL: 570:15-570:23 */;
            ResourceReference k_ = a?.Encounter /* CQL: 571:17-571:27 */;
            FhirDateTime l_ = a?.DateElement /* CQL: 572:12-572:17 */;
            List<ResourceReference> m_ = a?.Author;
            FhirString n_ = a?.TitleElement /* CQL: 574:13-574:19 */;
            Code<Composition.V3ConfidentialityClassification> o_ = a?.ConfidentialityElement /* CQL: 575:23-575:39 */;
            List<Composition.AttesterComponent> p_ = a?.Attester;
            ResourceReference q_ = a?.Custodian /* CQL: 577:17-577:27 */;
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
            arg /* CQL: 584:3-584:5 */,
        ];

        ConceptMap b_(ConceptMap a) {
            FhirUri f_ = a?.UrlElement /* CQL: 586:11-586:15 */;
            Identifier g_ = a?.Identifier /* CQL: 587:18-587:29 */;
            FhirString h_ = a?.VersionElement /* CQL: 588:15-588:23 */;
            FhirString i_ = a?.NameElement /* CQL: 589:12-589:17 */;
            FhirString j_ = a?.TitleElement /* CQL: 590:13-590:19 */;
            Code<PublicationStatus> k_ = a?.StatusElement /* CQL: 591:14-591:21 */;
            FhirBoolean l_ = a?.ExperimentalElement /* CQL: 592:20-592:33 */;
            FhirDateTime m_ = a?.DateElement /* CQL: 593:12-593:17 */;
            FhirString n_ = a?.PublisherElement /* CQL: 594:17-594:27 */;
            List<ContactDetail> o_ = a?.Contact;
            Markdown p_ = a?.DescriptionElement /* CQL: 596:19-596:31 */;
            List<UsageContext> q_ = a?.UseContext;
            List<CodeableConcept> r_ = a?.Jurisdiction;
            Markdown s_ = a?.PurposeElement /* CQL: 599:15-599:23 */;
            Markdown t_ = a?.CopyrightElement /* CQL: 600:17-600:27 */;
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
            arg /* CQL: 607:3-607:5 */,
        ];

        Condition b_(Condition a) {
            List<Identifier> f_ = a?.Identifier;
            CodeableConcept g_ = a?.ClinicalStatus /* CQL: 610:22-610:37 */;
            CodeableConcept h_ = a?.VerificationStatus /* CQL: 611:26-611:45 */;
            List<CodeableConcept> i_ = a?.Category;
            CodeableConcept j_ = a?.Severity /* CQL: 613:16-613:25 */;
            CodeableConcept k_ = a?.Code /* CQL: 614:12-614:17 */;
            List<CodeableConcept> l_ = a?.BodySite;
            ResourceReference m_ = a?.Subject /* CQL: 616:15-616:23 */;
            ResourceReference n_ = a?.Encounter /* CQL: 617:17-617:27 */;
            DataType o_ = a?.Onset;
            DataType p_ = a?.Abatement;
            FhirDateTime q_ = a?.RecordedDateElement /* CQL: 620:20-620:33 */;
            ResourceReference r_ = a?.Recorder /* CQL: 621:16-621:25 */;
            ResourceReference s_ = a?.Asserter /* CQL: 622:16-622:25 */;
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
            arg /* CQL: 629:3-629:5 */,
        ];

        Consent b_(Consent a) {
            List<Identifier> f_ = a?.Identifier;
            Code<Consent.ConsentState> g_ = a?.StatusElement /* CQL: 632:14-632:21 */;
            CodeableConcept h_ = a?.Scope /* CQL: 633:13-633:19 */;
            List<CodeableConcept> i_ = a?.Category;
            ResourceReference j_ = a?.Patient /* CQL: 635:15-635:23 */;
            FhirDateTime k_ = a?.DateTimeElement /* CQL: 636:16-636:25 */;
            List<ResourceReference> l_ = a?.Performer;
            List<ResourceReference> m_ = a?.Organization;
            DataType n_ = a?.Source;
            List<Consent.PolicyComponent> o_ = a?.Policy;
            CodeableConcept p_ = a?.PolicyRule /* CQL: 641:18-641:29 */;
            List<Consent.VerificationComponent> q_ = a?.Verification;
            Consent.provisionComponent r_ = a?.Provision /* CQL: 643:17-643:27 */;
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
            arg /* CQL: 647:3-647:5 */,
        ];

        Contract b_(Contract a) {
            List<Identifier> f_ = a?.Identifier;
            FhirUri g_ = a?.UrlElement /* CQL: 650:11-650:15 */;
            FhirString h_ = a?.VersionElement /* CQL: 651:15-651:23 */;
            Code<Contract.ContractResourceStatusCodes> i_ = a?.StatusElement /* CQL: 652:14-652:21 */;
            CodeableConcept j_ = a?.LegalState /* CQL: 653:18-653:29 */;
            ResourceReference k_ = a?.InstantiatesCanonical /* CQL: 654:29-654:51 */;
            FhirUri l_ = a?.InstantiatesUriElement /* CQL: 655:23-655:39 */;
            CodeableConcept m_ = a?.ContentDerivative /* CQL: 656:25-656:43 */;
            FhirDateTime n_ = a?.IssuedElement /* CQL: 657:14-657:21 */;
            Period o_ = a?.Applies /* CQL: 658:15-658:23 */;
            CodeableConcept p_ = a?.ExpirationType /* CQL: 659:22-659:37 */;
            List<ResourceReference> q_ = a?.Subject;
            List<ResourceReference> r_ = a?.Authority;
            List<ResourceReference> s_ = a?.Domain;
            List<ResourceReference> t_ = a?.Site;
            FhirString u_ = a?.NameElement /* CQL: 664:12-664:17 */;
            FhirString v_ = a?.TitleElement /* CQL: 665:13-665:19 */;
            FhirString w_ = a?.SubtitleElement /* CQL: 666:16-666:25 */;
            List<FhirString> x_ = a?.AliasElement;
            ResourceReference y_ = a?.Author /* CQL: 668:14-668:21 */;
            CodeableConcept z_ = a?.Scope /* CQL: 669:13-669:19 */;
            DataType aa_ = a?.Topic;
            CodeableConcept ab_ = a?.Type /* CQL: 671:12-671:17 */;
            List<CodeableConcept> ac_ = a?.SubType;
            Contract.ContentDefinitionComponent ad_ = a?.ContentDefinition /* CQL: 673:25-673:43 */;
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
            arg /* CQL: 685:3-685:5 */,
        ];

        Coverage b_(Coverage a) {
            List<Identifier> f_ = a?.Identifier;
            Code<FinancialResourceStatusCodes> g_ = a?.StatusElement /* CQL: 688:14-688:21 */;
            CodeableConcept h_ = a?.Type /* CQL: 689:12-689:17 */;
            ResourceReference i_ = a?.PolicyHolder /* CQL: 690:20-690:33 */;
            ResourceReference j_ = a?.Subscriber /* CQL: 691:18-691:29 */;
            FhirString k_ = a?.SubscriberIdElement /* CQL: 692:20-692:33 */;
            ResourceReference l_ = a?.Beneficiary /* CQL: 693:19-693:31 */;
            FhirString m_ = a?.DependentElement /* CQL: 694:17-694:27 */;
            CodeableConcept n_ = a?.Relationship /* CQL: 695:20-695:33 */;
            Period o_ = a?.Period /* CQL: 696:14-696:21 */;
            List<ResourceReference> p_ = a?.Payor;
            List<Coverage.ClassComponent> q_ = a?.Class;
            PositiveInt r_ = a?.OrderElement;
            Integer s_ = context.Operators.Convert<Integer>(r_);
            PositiveInt t_ = context.Operators.Convert<PositiveInt>(s_);
            FhirString u_ = a?.NetworkElement /* CQL: 700:15-700:23 */;
            List<Coverage.CostToBeneficiaryComponent> v_ = a?.CostToBeneficiary;
            FhirBoolean w_ = a?.SubrogationElement /* CQL: 702:19-702:31 */;
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
            arg /* CQL: 707:3-707:5 */,
        ];

        CoverageEligibilityRequest b_(CoverageEligibilityRequest a) {
            List<Identifier> f_ = a?.Identifier;
            Code<FinancialResourceStatusCodes> g_ = a?.StatusElement /* CQL: 710:14-710:21 */;
            CodeableConcept h_ = a?.Priority /* CQL: 711:16-711:25 */;
            List<Code<CoverageEligibilityRequest.EligibilityRequestPurpose>> i_ = a?.PurposeElement;
            ResourceReference j_ = a?.Patient /* CQL: 713:15-713:23 */;
            DataType k_ = a?.Serviced;
            FhirDateTime l_ = a?.CreatedElement /* CQL: 715:15-715:23 */;
            ResourceReference m_ = a?.Enterer /* CQL: 716:15-716:23 */;
            ResourceReference n_ = a?.Provider /* CQL: 717:16-717:25 */;
            ResourceReference o_ = a?.Insurer /* CQL: 718:15-718:23 */;
            ResourceReference p_ = a?.Facility /* CQL: 719:16-719:25 */;
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
            arg /* CQL: 726:3-726:5 */,
        ];

        CoverageEligibilityResponse b_(CoverageEligibilityResponse a) {
            List<Identifier> f_ = a?.Identifier;
            Code<FinancialResourceStatusCodes> g_ = a?.StatusElement /* CQL: 729:14-729:21 */;
            List<Code<CoverageEligibilityResponse.EligibilityResponsePurpose>> h_ = a?.PurposeElement;
            ResourceReference i_ = a?.Patient /* CQL: 731:15-731:23 */;
            DataType j_ = a?.Serviced;
            FhirDateTime k_ = a?.CreatedElement /* CQL: 733:15-733:23 */;
            ResourceReference l_ = a?.Requestor /* CQL: 734:17-734:27 */;
            ResourceReference m_ = a?.Request /* CQL: 735:15-735:23 */;
            Code<ClaimProcessingCodes> n_ = a?.OutcomeElement /* CQL: 736:15-736:23 */;
            FhirString o_ = a?.DispositionElement /* CQL: 737:19-737:31 */;
            ResourceReference p_ = a?.Insurer /* CQL: 738:15-738:23 */;
            List<CoverageEligibilityResponse.InsuranceComponent> q_ = a?.Insurance;
            FhirString r_ = a?.PreAuthRefElement /* CQL: 740:18-740:29 */;
            CodeableConcept s_ = a?.Form /* CQL: 741:12-741:17 */;
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
            arg /* CQL: 746:3-746:5 */,
        ];

        DetectedIssue b_(DetectedIssue a) {
            List<Identifier> f_ = a?.Identifier;
            Code<ObservationStatus> g_ = a?.StatusElement /* CQL: 749:14-749:21 */;
            CodeableConcept h_ = a?.Code /* CQL: 750:12-750:17 */;
            Code<DetectedIssue.DetectedIssueSeverity> i_ = a?.SeverityElement /* CQL: 751:16-751:25 */;
            ResourceReference j_ = a?.Patient /* CQL: 752:15-752:23 */;
            DataType k_ = a?.Identified;
            ResourceReference l_ = a?.Author /* CQL: 754:14-754:21 */;
            List<ResourceReference> m_ = a?.Implicated;
            List<DetectedIssue.EvidenceComponent> n_ = a?.Evidence;
            FhirString o_ = a?.DetailElement /* CQL: 757:14-757:21 */;
            FhirUri p_ = a?.ReferenceElement /* CQL: 758:17-758:27 */;
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
            arg /* CQL: 763:3-763:5 */,
        ];

        Device b_(Device a) {
            List<Identifier> f_ = a?.Identifier;
            ResourceReference g_ = a?.Definition /* CQL: 766:18-766:29 */;
            List<Device.UdiCarrierComponent> h_ = a?.UdiCarrier;
            Code<Device.FHIRDeviceStatus> i_ = a?.StatusElement /* CQL: 768:14-768:21 */;
            List<CodeableConcept> j_ = a?.StatusReason;
            FhirString k_ = a?.DistinctIdentifierElement /* CQL: 770:26-770:45 */;
            FhirString l_ = a?.ManufacturerElement /* CQL: 771:20-771:33 */;
            FhirDateTime m_ = a?.ManufactureDateElement /* CQL: 772:23-772:39 */;
            FhirDateTime n_ = a?.ExpirationDateElement /* CQL: 773:22-773:37 */;
            FhirString o_ = a?.LotNumberElement /* CQL: 774:17-774:27 */;
            FhirString p_ = a?.SerialNumberElement /* CQL: 775:20-775:33 */;
            List<Device.DeviceNameComponent> q_ = a?.DeviceName;
            FhirString r_ = a?.ModelNumberElement /* CQL: 777:19-777:31 */;
            FhirString s_ = a?.PartNumberElement /* CQL: 778:18-778:29 */;
            CodeableConcept t_ = a?.Type /* CQL: 779:12-779:17 */;
            List<Device.SpecializationComponent> u_ = a?.Specialization;
            List<Device.VersionComponent> v_ = a?.Version;
            List<Device.PropertyComponent> w_ = a?.Property;
            ResourceReference x_ = a?.Patient /* CQL: 783:15-783:23 */;
            ResourceReference y_ = a?.Owner /* CQL: 784:13-784:19 */;
            List<ContactPoint> z_ = a?.Contact;
            ResourceReference aa_ = a?.Location /* CQL: 786:16-786:25 */;
            FhirUri ab_ = a?.UrlElement /* CQL: 787:11-787:15 */;
            List<Annotation> ac_ = a?.Note;
            List<CodeableConcept> ad_ = a?.Safety;
            ResourceReference ae_ = a?.Parent /* CQL: 790:14-790:21 */;
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
            arg /* CQL: 794:3-794:5 */,
        ];

        DeviceDefinition b_(DeviceDefinition a) {
            List<Identifier> f_ = a?.Identifier;
            List<DeviceDefinition.UdiDeviceIdentifierComponent> g_ = a?.UdiDeviceIdentifier;
            DataType h_ = a?.Manufacturer;
            List<DeviceDefinition.DeviceNameComponent> i_ = a?.DeviceName;
            FhirString j_ = a?.ModelNumberElement /* CQL: 800:19-800:31 */;
            CodeableConcept k_ = a?.Type /* CQL: 801:12-801:17 */;
            List<DeviceDefinition.SpecializationComponent> l_ = a?.Specialization;
            List<FhirString> m_ = a?.VersionElement;
            List<CodeableConcept> n_ = a?.Safety;
            List<ProductShelfLife> o_ = a?.ShelfLifeStorage;
            ProdCharacteristic p_ = a?.PhysicalCharacteristics /* CQL: 806:31-806:55 */;
            List<CodeableConcept> q_ = a?.LanguageCode;
            List<DeviceDefinition.CapabilityComponent> r_ = a?.Capability;
            List<DeviceDefinition.PropertyComponent> s_ = a?.Property;
            ResourceReference t_ = a?.Owner /* CQL: 810:13-810:19 */;
            List<ContactPoint> u_ = a?.Contact;
            FhirUri v_ = a?.UrlElement /* CQL: 812:11-812:15 */;
            FhirUri w_ = a?.OnlineInformationElement /* CQL: 813:25-813:43 */;
            List<Annotation> x_ = a?.Note;
            Quantity y_ = a?.Quantity /* CQL: 815:16-815:25 */;
            ResourceReference z_ = a?.ParentDevice /* CQL: 816:20-816:33 */;
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
            arg /* CQL: 821:3-821:5 */,
        ];

        DeviceMetric b_(DeviceMetric a) {
            List<Identifier> f_ = a?.Identifier;
            CodeableConcept g_ = a?.Type /* CQL: 824:12-824:17 */;
            CodeableConcept h_ = a?.Unit /* CQL: 825:12-825:17 */;
            ResourceReference i_ = a?.Source /* CQL: 826:14-826:21 */;
            ResourceReference j_ = a?.Parent /* CQL: 827:14-827:21 */;
            Code<DeviceMetric.DeviceMetricOperationalStatus> k_ = a?.OperationalStatusElement /* CQL: 828:25-828:43 */;
            Code<DeviceMetric.DeviceMetricColor> l_ = a?.ColorElement /* CQL: 829:13-829:19 */;
            Code<DeviceMetric.DeviceMetricCategory> m_ = a?.CategoryElement /* CQL: 830:16-830:25 */;
            Timing n_ = a?.MeasurementPeriod /* CQL: 831:25-831:43 */;
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
            arg /* CQL: 836:3-836:5 */,
        ];

        DeviceRequest b_(DeviceRequest a) {
            List<Identifier> f_ = a?.Identifier;
            List<Canonical> g_ = a?.InstantiatesCanonicalElement;
            List<FhirUri> h_ = a?.InstantiatesUriElement;
            List<ResourceReference> i_ = a?.BasedOn;
            List<ResourceReference> j_ = a?.PriorRequest;
            Identifier k_ = a?.GroupIdentifier /* CQL: 843:23-843:39 */;
            Code<RequestStatus> l_ = a?.StatusElement /* CQL: 844:14-844:21 */;
            Code<RequestIntent> m_ = a?.IntentElement /* CQL: 845:14-845:21 */;
            Code<RequestPriority> n_ = a?.PriorityElement /* CQL: 846:16-846:25 */;
            DataType o_ = a?.Code;
            List<DeviceRequest.ParameterComponent> p_ = a?.Parameter;
            ResourceReference q_ = a?.Subject /* CQL: 849:15-849:23 */;
            ResourceReference r_ = a?.Encounter /* CQL: 850:17-850:27 */;
            DataType s_ = a?.Occurrence;
            FhirDateTime t_ = a?.AuthoredOnElement /* CQL: 852:18-852:29 */;
            ResourceReference u_ = a?.Requester /* CQL: 853:17-853:27 */;
            CodeableConcept v_ = a?.PerformerType /* CQL: 854:21-854:35 */;
            ResourceReference w_ = a?.Performer /* CQL: 855:17-855:27 */;
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
            arg /* CQL: 865:3-865:5 */,
        ];

        DeviceUseStatement b_(DeviceUseStatement a) {
            List<Identifier> f_ = a?.Identifier;
            List<ResourceReference> g_ = a?.BasedOn;
            Code<DeviceUseStatement.DeviceUseStatementStatus> h_ = a?.StatusElement /* CQL: 869:14-869:21 */;
            ResourceReference i_ = a?.Subject /* CQL: 870:15-870:23 */;
            List<ResourceReference> j_ = a?.DerivedFrom;
            DataType k_ = a?.Timing;
            FhirDateTime l_ = a?.RecordedOnElement /* CQL: 873:18-873:29 */;
            ResourceReference m_ = a?.Source /* CQL: 874:14-874:21 */;
            ResourceReference n_ = a?.Device /* CQL: 875:14-875:21 */;
            List<CodeableConcept> o_ = a?.ReasonCode;
            List<ResourceReference> p_ = a?.ReasonReference;
            CodeableConcept q_ = a?.BodySite /* CQL: 878:16-878:25 */;
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
            arg /* CQL: 883:3-883:5 */,
        ];

        DiagnosticReport b_(DiagnosticReport a) {
            List<Identifier> f_ = a?.Identifier;
            List<ResourceReference> g_ = a?.BasedOn;
            Code<DiagnosticReport.DiagnosticReportStatus> h_ = a?.StatusElement /* CQL: 887:14-887:21 */;
            List<CodeableConcept> i_ = a?.Category;
            CodeableConcept j_ = a?.Code /* CQL: 889:12-889:17 */;
            ResourceReference k_ = a?.Subject /* CQL: 890:15-890:23 */;
            ResourceReference l_ = a?.Encounter /* CQL: 891:17-891:27 */;
            DataType m_ = a?.Effective;
            Instant n_ = a?.IssuedElement /* CQL: 893:14-893:21 */;
            List<ResourceReference> o_ = a?.Performer;
            List<ResourceReference> p_ = a?.ResultsInterpreter;
            List<ResourceReference> q_ = a?.Specimen;
            List<ResourceReference> r_ = a?.Result;
            List<ResourceReference> s_ = a?.ImagingStudy;
            List<DiagnosticReport.MediaComponent> t_ = a?.Media;
            FhirString u_ = a?.ConclusionElement /* CQL: 900:18-900:29 */;
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
            arg /* CQL: 906:3-906:5 */,
        ];

        DocumentManifest b_(DocumentManifest a) {
            Identifier f_ = a?.MasterIdentifier /* CQL: 908:24-908:41 */;
            List<Identifier> g_ = a?.Identifier;
            Code<DocumentReferenceStatus> h_ = a?.StatusElement /* CQL: 910:14-910:21 */;
            CodeableConcept i_ = a?.Type /* CQL: 911:12-911:17 */;
            ResourceReference j_ = a?.Subject /* CQL: 912:15-912:23 */;
            FhirDateTime k_ = a?.CreatedElement /* CQL: 913:15-913:23 */;
            List<ResourceReference> l_ = a?.Author;
            List<ResourceReference> m_ = a?.Recipient;
            FhirUri n_ = a?.SourceElement /* CQL: 916:14-916:21 */;
            FhirString o_ = a?.DescriptionElement /* CQL: 917:19-917:31 */;
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
            arg /* CQL: 923:3-923:5 */,
        ];

        DocumentReference b_(DocumentReference a) {
            Identifier f_ = a?.MasterIdentifier /* CQL: 925:24-925:41 */;
            List<Identifier> g_ = a?.Identifier;
            Code<DocumentReferenceStatus> h_ = a?.StatusElement /* CQL: 927:14-927:21 */;
            Code<CompositionStatus> i_ = a?.DocStatusElement /* CQL: 928:17-928:27 */;
            CodeableConcept j_ = a?.Type /* CQL: 929:12-929:17 */;
            List<CodeableConcept> k_ = a?.Category;
            ResourceReference l_ = a?.Subject /* CQL: 931:15-931:23 */;
            Instant m_ = a?.DateElement /* CQL: 932:12-932:17 */;
            List<ResourceReference> n_ = a?.Author;
            ResourceReference o_ = a?.Authenticator /* CQL: 934:21-934:35 */;
            ResourceReference p_ = a?.Custodian /* CQL: 935:17-935:27 */;
            List<DocumentReference.RelatesToComponent> q_ = a?.RelatesTo;
            FhirString r_ = a?.DescriptionElement /* CQL: 937:19-937:31 */;
            List<CodeableConcept> s_ = a?.SecurityLabel;
            List<DocumentReference.ContentComponent> t_ = a?.Content;
            DocumentReference.ContextComponent u_ = a?.Context /* CQL: 940:15-940:23 */;
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
            arg /* CQL: 944:3-944:5 */,
        ];

        EffectEvidenceSynthesis b_(EffectEvidenceSynthesis a) {
            FhirUri f_ = a?.UrlElement /* CQL: 946:11-946:15 */;
            List<Identifier> g_ = a?.Identifier;
            FhirString h_ = a?.VersionElement /* CQL: 948:15-948:23 */;
            FhirString i_ = a?.NameElement /* CQL: 949:12-949:17 */;
            FhirString j_ = a?.TitleElement /* CQL: 950:13-950:19 */;
            Code<PublicationStatus> k_ = a?.StatusElement /* CQL: 951:14-951:21 */;
            FhirDateTime l_ = a?.DateElement /* CQL: 952:12-952:17 */;
            FhirString m_ = a?.PublisherElement /* CQL: 953:17-953:27 */;
            List<ContactDetail> n_ = a?.Contact;
            Markdown o_ = a?.DescriptionElement /* CQL: 955:19-955:31 */;
            List<Annotation> p_ = a?.Note;
            List<UsageContext> q_ = a?.UseContext;
            List<CodeableConcept> r_ = a?.Jurisdiction;
            Markdown s_ = a?.CopyrightElement /* CQL: 959:17-959:27 */;
            Date t_ = a?.ApprovalDateElement /* CQL: 960:20-960:33 */;
            Date u_ = a?.LastReviewDateElement /* CQL: 961:22-961:37 */;
            Period v_ = a?.EffectivePeriod /* CQL: 962:23-962:39 */;
            List<CodeableConcept> w_ = a?.Topic;
            List<ContactDetail> x_ = a?.Author;
            List<ContactDetail> y_ = a?.Editor;
            List<ContactDetail> z_ = a?.Reviewer;
            List<ContactDetail> aa_ = a?.Endorser;
            List<RelatedArtifact> ab_ = a?.RelatedArtifact;
            CodeableConcept ac_ = a?.SynthesisType /* CQL: 969:21-969:35 */;
            CodeableConcept ad_ = a?.StudyType /* CQL: 970:17-970:27 */;
            ResourceReference ae_ = a?.Population /* CQL: 971:18-971:29 */;
            ResourceReference af_ = a?.Exposure /* CQL: 972:16-972:25 */;
            ResourceReference ag_ = a?.ExposureAlternative /* CQL: 973:27-973:47 */;
            ResourceReference ah_ = a?.Outcome /* CQL: 974:15-974:23 */;
            EffectEvidenceSynthesis.SampleSizeComponent ai_ = a?.SampleSize /* CQL: 975:18-975:29 */;
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
            arg /* CQL: 982:3-982:5 */,
        ];

        Encounter b_(Encounter a) {
            List<Identifier> f_ = a?.Identifier;
            Code<Encounter.EncounterStatus> g_ = a?.StatusElement /* CQL: 985:14-985:21 */;
            List<Encounter.StatusHistoryComponent> h_ = a?.StatusHistory;
            Coding i_ = a?.Class /* CQL: 987:13-987:19 */;
            List<Encounter.ClassHistoryComponent> j_ = a?.ClassHistory;
            List<CodeableConcept> k_ = a?.Type;
            CodeableConcept l_ = a?.ServiceType /* CQL: 990:19-990:31 */;
            CodeableConcept m_ = a?.Priority /* CQL: 991:16-991:25 */;
            ResourceReference n_ = a?.Subject /* CQL: 992:15-992:23 */;
            List<ResourceReference> o_ = a?.EpisodeOfCare;
            List<ResourceReference> p_ = a?.BasedOn;
            List<Encounter.ParticipantComponent> q_ = a?.Participant;
            List<ResourceReference> r_ = a?.Appointment;
            Period s_ = a?.Period /* CQL: 997:14-997:21 */;
            Duration t_ = a?.Length /* CQL: 998:14-998:21 */;
            List<CodeableConcept> u_ = a?.ReasonCode;
            List<ResourceReference> v_ = a?.ReasonReference;
            List<Encounter.DiagnosisComponent> w_ = a?.Diagnosis;
            List<ResourceReference> x_ = a?.Account;
            Encounter.HospitalizationComponent y_ = a?.Hospitalization /* CQL: 1003:23-1003:39 */;
            List<Encounter.LocationComponent> z_ = a?.Location;
            ResourceReference aa_ = a?.ServiceProvider /* CQL: 1005:23-1005:39 */;
            ResourceReference ab_ = a?.PartOf /* CQL: 1006:14-1006:21 */;
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
            arg /* CQL: 1010:3-1010:5 */,
        ];

        Endpoint b_(Endpoint a) {
            List<Identifier> f_ = a?.Identifier;
            Code<Endpoint.EndpointStatus> g_ = a?.StatusElement /* CQL: 1013:14-1013:21 */;
            Coding h_ = a?.ConnectionType /* CQL: 1014:22-1014:37 */;
            FhirString i_ = a?.NameElement /* CQL: 1015:12-1015:17 */;
            ResourceReference j_ = a?.ManagingOrganization /* CQL: 1016:28-1016:49 */;
            List<ContactPoint> k_ = a?.Contact;
            Period l_ = a?.Period /* CQL: 1018:14-1018:21 */;
            List<CodeableConcept> m_ = a?.PayloadType;
            List<Code> n_ = a?.PayloadMimeTypeElement;
            FhirUrl o_ = a?.AddressElement /* CQL: 1021:15-1021:23 */;
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
            arg /* CQL: 1026:3-1026:5 */,
        ];

        EnrollmentRequest b_(EnrollmentRequest a) {
            List<Identifier> f_ = a?.Identifier;
            Code<FinancialResourceStatusCodes> g_ = a?.StatusElement /* CQL: 1029:14-1029:21 */;
            FhirDateTime h_ = a?.CreatedElement /* CQL: 1030:15-1030:23 */;
            ResourceReference i_ = a?.Insurer /* CQL: 1031:15-1031:23 */;
            ResourceReference j_ = a?.Provider /* CQL: 1032:16-1032:25 */;
            ResourceReference k_ = a?.Candidate /* CQL: 1033:17-1033:27 */;
            ResourceReference l_ = a?.Coverage /* CQL: 1034:16-1034:25 */;
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
            arg /* CQL: 1038:3-1038:5 */,
        ];

        EnrollmentResponse b_(EnrollmentResponse a) {
            List<Identifier> f_ = a?.Identifier;
            Code<FinancialResourceStatusCodes> g_ = a?.StatusElement /* CQL: 1041:14-1041:21 */;
            ResourceReference h_ = a?.Request /* CQL: 1042:15-1042:23 */;
            Code<ClaimProcessingCodes> i_ = a?.OutcomeElement /* CQL: 1043:15-1043:23 */;
            FhirString j_ = a?.DispositionElement /* CQL: 1044:19-1044:31 */;
            FhirDateTime k_ = a?.CreatedElement /* CQL: 1045:15-1045:23 */;
            ResourceReference l_ = a?.Organization /* CQL: 1046:20-1046:33 */;
            ResourceReference m_ = a?.RequestProvider /* CQL: 1047:23-1047:39 */;
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
            arg /* CQL: 1051:3-1051:5 */,
        ];

        EpisodeOfCare b_(EpisodeOfCare a) {
            List<Identifier> f_ = a?.Identifier;
            Code<EpisodeOfCare.EpisodeOfCareStatus> g_ = a?.StatusElement /* CQL: 1054:14-1054:21 */;
            List<EpisodeOfCare.StatusHistoryComponent> h_ = a?.StatusHistory;
            List<CodeableConcept> i_ = a?.Type;
            List<EpisodeOfCare.DiagnosisComponent> j_ = a?.Diagnosis;
            ResourceReference k_ = a?.Patient /* CQL: 1058:15-1058:23 */;
            ResourceReference l_ = a?.ManagingOrganization /* CQL: 1059:28-1059:49 */;
            Period m_ = a?.Period /* CQL: 1060:14-1060:21 */;
            List<ResourceReference> n_ = a?.ReferralRequest;
            ResourceReference o_ = a?.CareManager /* CQL: 1062:19-1062:31 */;
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
            arg /* CQL: 1068:3-1068:5 */,
        ];

        EventDefinition b_(EventDefinition a) {
            FhirUri f_ = a?.UrlElement /* CQL: 1070:11-1070:15 */;
            List<Identifier> g_ = a?.Identifier;
            FhirString h_ = a?.VersionElement /* CQL: 1072:15-1072:23 */;
            FhirString i_ = a?.NameElement /* CQL: 1073:12-1073:17 */;
            FhirString j_ = a?.TitleElement /* CQL: 1074:13-1074:19 */;
            FhirString k_ = a?.SubtitleElement /* CQL: 1075:16-1075:25 */;
            Code<PublicationStatus> l_ = a?.StatusElement /* CQL: 1076:14-1076:21 */;
            FhirBoolean m_ = a?.ExperimentalElement /* CQL: 1077:20-1077:33 */;
            DataType n_ = a?.Subject;
            FhirDateTime o_ = a?.DateElement /* CQL: 1079:12-1079:17 */;
            FhirString p_ = a?.PublisherElement /* CQL: 1080:17-1080:27 */;
            List<ContactDetail> q_ = a?.Contact;
            Markdown r_ = a?.DescriptionElement /* CQL: 1082:19-1082:31 */;
            List<UsageContext> s_ = a?.UseContext;
            List<CodeableConcept> t_ = a?.Jurisdiction;
            Markdown u_ = a?.PurposeElement /* CQL: 1085:15-1085:23 */;
            FhirString v_ = a?.UsageElement /* CQL: 1086:13-1086:19 */;
            Markdown w_ = a?.CopyrightElement /* CQL: 1087:17-1087:27 */;
            Date x_ = a?.ApprovalDateElement /* CQL: 1088:20-1088:33 */;
            Date y_ = a?.LastReviewDateElement /* CQL: 1089:22-1089:37 */;
            Period z_ = a?.EffectivePeriod /* CQL: 1090:23-1090:39 */;
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
            arg /* CQL: 1101:3-1101:5 */,
        ];

        Evidence b_(Evidence a) {
            FhirUri f_ = a?.UrlElement /* CQL: 1103:11-1103:15 */;
            List<Identifier> g_ = a?.Identifier;
            FhirString h_ = a?.VersionElement /* CQL: 1105:15-1105:23 */;
            FhirString i_ = a?.NameElement /* CQL: 1106:12-1106:17 */;
            FhirString j_ = a?.TitleElement /* CQL: 1107:13-1107:19 */;
            FhirString k_ = a?.ShortTitleElement /* CQL: 1108:18-1108:29 */;
            FhirString l_ = a?.SubtitleElement /* CQL: 1109:16-1109:25 */;
            Code<PublicationStatus> m_ = a?.StatusElement /* CQL: 1110:14-1110:21 */;
            FhirDateTime n_ = a?.DateElement /* CQL: 1111:12-1111:17 */;
            FhirString o_ = a?.PublisherElement /* CQL: 1112:17-1112:27 */;
            List<ContactDetail> p_ = a?.Contact;
            Markdown q_ = a?.DescriptionElement /* CQL: 1114:19-1114:31 */;
            List<Annotation> r_ = a?.Note;
            List<UsageContext> s_ = a?.UseContext;
            List<CodeableConcept> t_ = a?.Jurisdiction;
            Markdown u_ = a?.CopyrightElement /* CQL: 1118:17-1118:27 */;
            Date v_ = a?.ApprovalDateElement /* CQL: 1119:20-1119:33 */;
            Date w_ = a?.LastReviewDateElement /* CQL: 1120:22-1120:37 */;
            Period x_ = a?.EffectivePeriod /* CQL: 1121:23-1121:39 */;
            List<CodeableConcept> y_ = a?.Topic;
            List<ContactDetail> z_ = a?.Author;
            List<ContactDetail> aa_ = a?.Editor;
            List<ContactDetail> ab_ = a?.Reviewer;
            List<ContactDetail> ac_ = a?.Endorser;
            List<RelatedArtifact> ad_ = a?.RelatedArtifact;
            ResourceReference ae_ = a?.ExposureBackground /* CQL: 1128:26-1128:45 */;
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
            arg /* CQL: 1134:3-1134:5 */,
        ];

        EvidenceVariable b_(EvidenceVariable a) {
            FhirUri f_ = a?.UrlElement /* CQL: 1136:11-1136:15 */;
            List<Identifier> g_ = a?.Identifier;
            FhirString h_ = a?.VersionElement /* CQL: 1138:15-1138:23 */;
            FhirString i_ = a?.NameElement /* CQL: 1139:12-1139:17 */;
            FhirString j_ = a?.TitleElement /* CQL: 1140:13-1140:19 */;
            FhirString k_ = a?.ShortTitleElement /* CQL: 1141:18-1141:29 */;
            FhirString l_ = a?.SubtitleElement /* CQL: 1142:16-1142:25 */;
            Code<PublicationStatus> m_ = a?.StatusElement /* CQL: 1143:14-1143:21 */;
            FhirDateTime n_ = a?.DateElement /* CQL: 1144:12-1144:17 */;
            FhirString o_ = a?.PublisherElement /* CQL: 1145:17-1145:27 */;
            List<ContactDetail> p_ = a?.Contact;
            Markdown q_ = a?.DescriptionElement /* CQL: 1147:19-1147:31 */;
            List<Annotation> r_ = a?.Note;
            List<UsageContext> s_ = a?.UseContext;
            List<CodeableConcept> t_ = a?.Jurisdiction;
            Markdown u_ = a?.CopyrightElement /* CQL: 1151:17-1151:27 */;
            Date v_ = a?.ApprovalDateElement /* CQL: 1152:20-1152:33 */;
            Date w_ = a?.LastReviewDateElement /* CQL: 1153:22-1153:37 */;
            Period x_ = a?.EffectivePeriod /* CQL: 1154:23-1154:39 */;
            List<CodeableConcept> y_ = a?.Topic;
            List<ContactDetail> z_ = a?.Author;
            List<ContactDetail> aa_ = a?.Editor;
            List<ContactDetail> ab_ = a?.Reviewer;
            List<ContactDetail> ac_ = a?.Endorser;
            List<RelatedArtifact> ad_ = a?.RelatedArtifact;
            Code<VariableTypeCode> ae_ = a?.TypeElement /* CQL: 1161:12-1161:17 */;
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
            arg /* CQL: 1188:3-1188:5 */,
        ];

        ExplanationOfBenefit b_(ExplanationOfBenefit a) {
            List<Identifier> f_ = a?.Identifier;
            Code<ExplanationOfBenefit.ExplanationOfBenefitStatus> g_ = a?.StatusElement /* CQL: 1191:14-1191:21 */;
            CodeableConcept h_ = a?.Type /* CQL: 1192:12-1192:17 */;
            CodeableConcept i_ = a?.SubType /* CQL: 1193:15-1193:23 */;
            Code<ClaimUseCode> j_ = a?.UseElement /* CQL: 1194:11-1194:15 */;
            ResourceReference k_ = a?.Patient /* CQL: 1195:15-1195:23 */;
            Period l_ = a?.BillablePeriod /* CQL: 1196:22-1196:37 */;
            FhirDateTime m_ = a?.CreatedElement /* CQL: 1197:15-1197:23 */;
            ResourceReference n_ = a?.Enterer /* CQL: 1198:15-1198:23 */;
            ResourceReference o_ = a?.Insurer /* CQL: 1199:15-1199:23 */;
            ResourceReference p_ = a?.Provider /* CQL: 1200:16-1200:25 */;
            CodeableConcept q_ = a?.Priority /* CQL: 1201:16-1201:25 */;
            CodeableConcept r_ = a?.FundsReserveRequested /* CQL: 1202:29-1202:51 */;
            CodeableConcept s_ = a?.FundsReserve /* CQL: 1203:20-1203:33 */;
            List<ExplanationOfBenefit.RelatedClaimComponent> t_ = a?.Related;
            ResourceReference u_ = a?.Prescription /* CQL: 1205:20-1205:33 */;
            ResourceReference v_ = a?.OriginalPrescription /* CQL: 1206:28-1206:49 */;
            ExplanationOfBenefit.PayeeComponent w_ = a?.Payee /* CQL: 1207:13-1207:19 */;
            ResourceReference x_ = a?.Referral /* CQL: 1208:16-1208:25 */;
            ResourceReference y_ = a?.Facility /* CQL: 1209:16-1209:25 */;
            ResourceReference z_ = a?.Claim /* CQL: 1210:13-1210:19 */;
            ResourceReference aa_ = a?.ClaimResponse /* CQL: 1211:21-1211:35 */;
            Code<ClaimProcessingCodes> ab_ = a?.OutcomeElement /* CQL: 1212:15-1212:23 */;
            FhirString ac_ = a?.DispositionElement /* CQL: 1213:19-1213:31 */;
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
            ExplanationOfBenefit.AccidentComponent an_ = a?.Accident /* CQL: 1222:16-1222:25 */;
            List<ExplanationOfBenefit.ItemComponent> ao_ = a?.Item;
            List<ExplanationOfBenefit.AddedItemComponent> ap_ = a?.AddItem;
            List<ExplanationOfBenefit.AdjudicationComponent> aq_ = a?.Adjudication;
            List<ExplanationOfBenefit.TotalComponent> ar_ = a?.Total;
            ExplanationOfBenefit.PaymentComponent as_ = a?.Payment /* CQL: 1227:15-1227:23 */;
            CodeableConcept at_ = a?.FormCode /* CQL: 1228:16-1228:25 */;
            Attachment au_ = a?.Form /* CQL: 1229:12-1229:17 */;
            List<ExplanationOfBenefit.NoteComponent> av_ = a?.ProcessNote;
            Period aw_ = a?.BenefitPeriod /* CQL: 1231:21-1231:35 */;
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
            arg /* CQL: 1236:3-1236:5 */,
        ];

        FamilyMemberHistory b_(FamilyMemberHistory a) {
            List<Identifier> f_ = a?.Identifier;
            List<Canonical> g_ = a?.InstantiatesCanonicalElement;
            List<FhirUri> h_ = a?.InstantiatesUriElement;
            Code<FamilyMemberHistory.FamilyHistoryStatus> i_ = a?.StatusElement /* CQL: 1241:14-1241:21 */;
            CodeableConcept j_ = a?.DataAbsentReason /* CQL: 1242:24-1242:41 */;
            ResourceReference k_ = a?.Patient /* CQL: 1243:15-1243:23 */;
            FhirDateTime l_ = a?.DateElement /* CQL: 1244:12-1244:17 */;
            FhirString m_ = a?.NameElement /* CQL: 1245:12-1245:17 */;
            CodeableConcept n_ = a?.Relationship /* CQL: 1246:20-1246:33 */;
            CodeableConcept o_ = a?.Sex /* CQL: 1247:11-1247:15 */;
            DataType p_ = a?.Born;
            DataType q_ = a?.Age;
            FhirBoolean r_ = a?.EstimatedAgeElement /* CQL: 1250:20-1250:33 */;
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
            arg /* CQL: 1259:3-1259:5 */,
        ];

        Flag b_(Flag a) {
            List<Identifier> f_ = a?.Identifier;
            Code<Flag.FlagStatus> g_ = a?.StatusElement /* CQL: 1262:14-1262:21 */;
            List<CodeableConcept> h_ = a?.Category;
            CodeableConcept i_ = a?.Code /* CQL: 1264:12-1264:17 */;
            ResourceReference j_ = a?.Subject /* CQL: 1265:15-1265:23 */;
            Period k_ = a?.Period /* CQL: 1266:14-1266:21 */;
            ResourceReference l_ = a?.Encounter /* CQL: 1267:17-1267:27 */;
            ResourceReference m_ = a?.Author /* CQL: 1268:14-1268:21 */;
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
            arg /* CQL: 1272:3-1272:5 */,
        ];

        Goal b_(Goal a) {
            List<Identifier> f_ = a?.Identifier;
            Code<Goal.GoalLifecycleStatus> g_ = a?.LifecycleStatusElement /* CQL: 1275:23-1275:39 */;
            CodeableConcept h_ = a?.AchievementStatus /* CQL: 1276:25-1276:43 */;
            List<CodeableConcept> i_ = a?.Category;
            CodeableConcept j_ = a?.Priority /* CQL: 1278:16-1278:25 */;
            CodeableConcept k_ = a?.Description /* CQL: 1279:19-1279:31 */;
            ResourceReference l_ = a?.Subject /* CQL: 1280:15-1280:23 */;
            DataType m_ = a?.Start;
            List<Goal.TargetComponent> n_ = a?.Target;
            Date o_ = a?.StatusDateElement /* CQL: 1283:18-1283:29 */;
            FhirString p_ = a?.StatusReasonElement /* CQL: 1284:20-1284:33 */;
            ResourceReference q_ = a?.ExpressedBy /* CQL: 1285:19-1285:31 */;
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
            arg /* CQL: 1313:3-1313:5 */,
        ];

        Group b_(Group a) {
            List<Identifier> f_ = a?.Identifier;
            FhirBoolean g_ = a?.ActiveElement /* CQL: 1316:14-1316:21 */;
            Code<Group.GroupType> h_ = a?.TypeElement /* CQL: 1317:12-1317:17 */;
            FhirBoolean i_ = a?.ActualElement /* CQL: 1318:14-1318:21 */;
            CodeableConcept j_ = a?.Code /* CQL: 1319:12-1319:17 */;
            FhirString k_ = a?.NameElement /* CQL: 1320:12-1320:17 */;
            UnsignedInt l_ = a?.QuantityElement;
            Integer m_ = context.Operators.Convert<Integer>(l_);
            UnsignedInt n_ = context.Operators.Convert<UnsignedInt>(m_);
            ResourceReference o_ = a?.ManagingEntity /* CQL: 1322:22-1322:37 */;
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
            arg /* CQL: 1328:3-1328:5 */,
        ];

        GuidanceResponse b_(GuidanceResponse a) {
            Identifier f_ = a?.RequestIdentifier /* CQL: 1330:25-1330:43 */;
            List<Identifier> g_ = a?.Identifier;
            DataType h_ = a?.Module;
            Code<GuidanceResponse.GuidanceResponseStatus> i_ = a?.StatusElement /* CQL: 1333:14-1333:21 */;
            ResourceReference j_ = a?.Subject /* CQL: 1334:15-1334:23 */;
            ResourceReference k_ = a?.Encounter /* CQL: 1335:17-1335:27 */;
            FhirDateTime l_ = a?.OccurrenceDateTimeElement /* CQL: 1336:26-1336:45 */;
            ResourceReference m_ = a?.Performer /* CQL: 1337:17-1337:27 */;
            List<CodeableConcept> n_ = a?.ReasonCode;
            List<ResourceReference> o_ = a?.ReasonReference;
            List<Annotation> p_ = a?.Note;
            List<ResourceReference> q_ = a?.EvaluationMessage;
            ResourceReference r_ = a?.OutputParameters /* CQL: 1342:24-1342:41 */;
            ResourceReference s_ = a?.Result /* CQL: 1343:14-1343:21 */;
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
            arg /* CQL: 1348:3-1348:5 */,
        ];

        HealthcareService b_(HealthcareService a) {
            List<Identifier> f_ = a?.Identifier;
            FhirBoolean g_ = a?.ActiveElement /* CQL: 1351:14-1351:21 */;
            ResourceReference h_ = a?.ProvidedBy /* CQL: 1352:18-1352:29 */;
            List<CodeableConcept> i_ = a?.Category;
            List<CodeableConcept> j_ = a?.Type;
            List<CodeableConcept> k_ = a?.Specialty;
            List<ResourceReference> l_ = a?.Location;
            FhirString m_ = a?.NameElement /* CQL: 1357:12-1357:17 */;
            FhirString n_ = a?.CommentElement /* CQL: 1358:15-1358:23 */;
            Markdown o_ = a?.ExtraDetailsElement /* CQL: 1359:20-1359:33 */;
            Attachment p_ = a?.Photo /* CQL: 1360:13-1360:19 */;
            List<ContactPoint> q_ = a?.Telecom;
            List<ResourceReference> r_ = a?.CoverageArea;
            List<CodeableConcept> s_ = a?.ServiceProvisionCode;
            List<HealthcareService.EligibilityComponent> t_ = a?.Eligibility;
            List<CodeableConcept> u_ = a?.Program;
            List<CodeableConcept> v_ = a?.Characteristic;
            List<CodeableConcept> w_ = a?.Communication;
            List<CodeableConcept> x_ = a?.ReferralMethod;
            FhirBoolean y_ = a?.AppointmentRequiredElement /* CQL: 1369:27-1369:47 */;
            List<HealthcareService.AvailableTimeComponent> z_ = a?.AvailableTime;
            List<HealthcareService.NotAvailableComponent> aa_ = a?.NotAvailable;
            FhirString ab_ = a?.AvailabilityExceptionsElement /* CQL: 1372:30-1372:53 */;
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
            arg /* CQL: 1377:3-1377:5 */,
        ];

        ImagingStudy b_(ImagingStudy a) {
            List<Identifier> f_ = a?.Identifier;
            Code<ImagingStudy.ImagingStudyStatus> g_ = a?.StatusElement /* CQL: 1380:14-1380:21 */;
            List<Coding> h_ = a?.Modality;
            ResourceReference i_ = a?.Subject /* CQL: 1382:15-1382:23 */;
            ResourceReference j_ = a?.Encounter /* CQL: 1383:17-1383:27 */;
            FhirDateTime k_ = a?.StartedElement /* CQL: 1384:15-1384:23 */;
            List<ResourceReference> l_ = a?.BasedOn;
            ResourceReference m_ = a?.Referrer /* CQL: 1386:16-1386:25 */;
            List<ResourceReference> n_ = a?.Interpreter;
            List<ResourceReference> o_ = a?.Endpoint;
            UnsignedInt p_ = a?.NumberOfSeriesElement;
            Integer q_ = context.Operators.Convert<Integer>(p_);
            UnsignedInt r_ = context.Operators.Convert<UnsignedInt>(q_);
            UnsignedInt s_ = a?.NumberOfInstancesElement;
            Integer t_ = context.Operators.Convert<Integer>(s_);
            UnsignedInt u_ = context.Operators.Convert<UnsignedInt>(t_);
            ResourceReference v_ = a?.ProcedureReference /* CQL: 1391:26-1391:45 */;
            List<CodeableConcept> w_ = a?.ProcedureCode;
            ResourceReference x_ = a?.Location /* CQL: 1393:16-1393:25 */;
            List<CodeableConcept> y_ = a?.ReasonCode;
            List<ResourceReference> z_ = a?.ReasonReference;
            List<Annotation> aa_ = a?.Note;
            FhirString ab_ = a?.DescriptionElement /* CQL: 1397:19-1397:31 */;
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
            arg /* CQL: 1402:3-1402:5 */,
        ];

        Immunization b_(Immunization a) {
            List<Identifier> f_ = a?.Identifier;
            Code<Immunization.ImmunizationStatusCodes> g_ = a?.StatusElement /* CQL: 1405:14-1405:21 */;
            CodeableConcept h_ = a?.StatusReason /* CQL: 1406:20-1406:33 */;
            CodeableConcept i_ = a?.VaccineCode /* CQL: 1407:19-1407:31 */;
            ResourceReference j_ = a?.Patient /* CQL: 1408:15-1408:23 */;
            ResourceReference k_ = a?.Encounter /* CQL: 1409:17-1409:27 */;
            DataType l_ = a?.Occurrence;
            FhirDateTime m_ = a?.RecordedElement /* CQL: 1411:16-1411:25 */;
            FhirBoolean n_ = a?.PrimarySourceElement /* CQL: 1412:21-1412:35 */;
            CodeableConcept o_ = a?.ReportOrigin /* CQL: 1413:20-1413:33 */;
            ResourceReference p_ = a?.Location /* CQL: 1414:16-1414:25 */;
            ResourceReference q_ = a?.Manufacturer /* CQL: 1415:20-1415:33 */;
            FhirString r_ = a?.LotNumberElement /* CQL: 1416:17-1416:27 */;
            Date s_ = a?.ExpirationDateElement /* CQL: 1417:22-1417:37 */;
            CodeableConcept t_ = a?.Site /* CQL: 1418:12-1418:17 */;
            CodeableConcept u_ = a?.Route /* CQL: 1419:13-1419:19 */;
            Quantity v_ = a?.DoseQuantity /* CQL: 1420:20-1420:33 */;
            List<Immunization.PerformerComponent> w_ = a?.Performer;
            List<Annotation> x_ = a?.Note;
            List<CodeableConcept> y_ = a?.ReasonCode;
            List<ResourceReference> z_ = a?.ReasonReference;
            FhirBoolean aa_ = a?.IsSubpotentElement /* CQL: 1425:19-1425:31 */;
            List<CodeableConcept> ab_ = a?.SubpotentReason;
            List<Immunization.EducationComponent> ac_ = a?.Education;
            List<CodeableConcept> ad_ = a?.ProgramEligibility;
            CodeableConcept ae_ = a?.FundingSource /* CQL: 1429:21-1429:35 */;
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
            arg /* CQL: 1435:3-1435:5 */,
        ];

        ImmunizationEvaluation b_(ImmunizationEvaluation a) {
            List<Identifier> f_ = a?.Identifier;
            Code<ImmunizationEvaluation.ImmunizationEvaluationStatusCodes> g_ = a?.StatusElement /* CQL: 1438:14-1438:21 */;
            ResourceReference h_ = a?.Patient /* CQL: 1439:15-1439:23 */;
            FhirDateTime i_ = a?.DateElement /* CQL: 1440:12-1440:17 */;
            ResourceReference j_ = a?.Authority /* CQL: 1441:17-1441:27 */;
            CodeableConcept k_ = a?.TargetDisease /* CQL: 1442:21-1442:35 */;
            ResourceReference l_ = a?.ImmunizationEvent /* CQL: 1443:25-1443:43 */;
            CodeableConcept m_ = a?.DoseStatus /* CQL: 1444:18-1444:29 */;
            List<CodeableConcept> n_ = a?.DoseStatusReason;
            FhirString o_ = a?.DescriptionElement /* CQL: 1446:19-1446:31 */;
            FhirString p_ = a?.SeriesElement /* CQL: 1447:14-1447:21 */;
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
            arg /* CQL: 1453:3-1453:5 */,
        ];

        ImmunizationRecommendation b_(ImmunizationRecommendation a) {
            List<Identifier> f_ = a?.Identifier;
            ResourceReference g_ = a?.Patient /* CQL: 1456:15-1456:23 */;
            FhirDateTime h_ = a?.DateElement /* CQL: 1457:12-1457:17 */;
            ResourceReference i_ = a?.Authority /* CQL: 1458:17-1458:27 */;
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
            arg /* CQL: 1488:3-1488:5 */,
        ];

        InsurancePlan b_(InsurancePlan a) {
            List<Identifier> f_ = a?.Identifier;
            Code<PublicationStatus> g_ = a?.StatusElement /* CQL: 1491:14-1491:21 */;
            List<CodeableConcept> h_ = a?.Type;
            FhirString i_ = a?.NameElement /* CQL: 1493:12-1493:17 */;
            List<FhirString> j_ = a?.AliasElement;
            Period k_ = a?.Period /* CQL: 1495:14-1495:21 */;
            ResourceReference l_ = a?.OwnedBy /* CQL: 1496:15-1496:23 */;
            ResourceReference m_ = a?.AdministeredBy /* CQL: 1497:22-1497:37 */;
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
            arg /* CQL: 1507:3-1507:5 */,
        ];

        Invoice b_(Invoice a) {
            List<Identifier> f_ = a?.Identifier;
            Code<Invoice.InvoiceStatus> g_ = a?.StatusElement /* CQL: 1510:14-1510:21 */;
            FhirString h_ = a?.CancelledReasonElement /* CQL: 1511:23-1511:39 */;
            CodeableConcept i_ = a?.Type /* CQL: 1512:12-1512:17 */;
            ResourceReference j_ = a?.Subject /* CQL: 1513:15-1513:23 */;
            ResourceReference k_ = a?.Recipient /* CQL: 1514:17-1514:27 */;
            FhirDateTime l_ = a?.DateElement /* CQL: 1515:12-1515:17 */;
            List<Invoice.ParticipantComponent> m_ = a?.Participant;
            ResourceReference n_ = a?.Issuer /* CQL: 1517:14-1517:21 */;
            ResourceReference o_ = a?.Account /* CQL: 1518:15-1518:23 */;
            List<Invoice.LineItemComponent> p_ = a?.LineItem;
            List<Invoice.PriceComponentComponent> q_ = a?.TotalPriceComponent;
            Money r_ = a?.TotalNet /* CQL: 1521:16-1521:25 */;
            Money s_ = a?.TotalGross /* CQL: 1522:18-1522:29 */;
            Markdown t_ = a?.PaymentTermsElement /* CQL: 1523:20-1523:33 */;
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
            arg /* CQL: 1528:3-1528:5 */,
        ];

        Library b_(Library a) {
            FhirUri f_ = a?.UrlElement /* CQL: 1530:11-1530:15 */;
            List<Identifier> g_ = a?.Identifier;
            FhirString h_ = a?.VersionElement /* CQL: 1532:15-1532:23 */;
            FhirString i_ = a?.NameElement /* CQL: 1533:12-1533:17 */;
            FhirString j_ = a?.TitleElement /* CQL: 1534:13-1534:19 */;
            FhirString k_ = a?.SubtitleElement /* CQL: 1535:16-1535:25 */;
            Code<PublicationStatus> l_ = a?.StatusElement /* CQL: 1536:14-1536:21 */;
            FhirBoolean m_ = a?.ExperimentalElement /* CQL: 1537:20-1537:33 */;
            CodeableConcept n_ = a?.Type /* CQL: 1538:12-1538:17 */;
            DataType o_ = a?.Subject;
            FhirDateTime p_ = a?.DateElement /* CQL: 1540:12-1540:17 */;
            FhirString q_ = a?.PublisherElement /* CQL: 1541:17-1541:27 */;
            List<ContactDetail> r_ = a?.Contact;
            Markdown s_ = a?.DescriptionElement /* CQL: 1543:19-1543:31 */;
            List<UsageContext> t_ = a?.UseContext;
            List<CodeableConcept> u_ = a?.Jurisdiction;
            Markdown v_ = a?.PurposeElement /* CQL: 1546:15-1546:23 */;
            FhirString w_ = a?.UsageElement /* CQL: 1547:13-1547:19 */;
            Markdown x_ = a?.CopyrightElement /* CQL: 1548:17-1548:27 */;
            Date y_ = a?.ApprovalDateElement /* CQL: 1549:20-1549:33 */;
            Date z_ = a?.LastReviewDateElement /* CQL: 1550:22-1550:37 */;
            Period aa_ = a?.EffectivePeriod /* CQL: 1551:23-1551:39 */;
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
            arg /* CQL: 1564:3-1564:5 */,
        ];

        Linkage b_(Linkage a) {
            FhirBoolean f_ = a?.ActiveElement /* CQL: 1566:14-1566:21 */;
            ResourceReference g_ = a?.Author /* CQL: 1567:14-1567:21 */;
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
            arg /* CQL: 1590:3-1590:5 */,
        ];

        Location b_(Location a) {
            List<Identifier> f_ = a?.Identifier;
            Code<Location.LocationStatus> g_ = a?.StatusElement /* CQL: 1593:14-1593:21 */;
            Coding h_ = a?.OperationalStatus /* CQL: 1594:25-1594:43 */;
            FhirString i_ = a?.NameElement /* CQL: 1595:12-1595:17 */;
            List<FhirString> j_ = a?.AliasElement;
            FhirString k_ = a?.DescriptionElement /* CQL: 1597:19-1597:31 */;
            Code<Location.LocationMode> l_ = a?.ModeElement /* CQL: 1598:12-1598:17 */;
            List<CodeableConcept> m_ = a?.Type;
            List<ContactPoint> n_ = a?.Telecom;
            Address o_ = a?.Address /* CQL: 1601:15-1601:23 */;
            CodeableConcept p_ = a?.PhysicalType /* CQL: 1602:20-1602:33 */;
            Location.PositionComponent q_ = a?.Position /* CQL: 1603:16-1603:25 */;
            ResourceReference r_ = a?.ManagingOrganization /* CQL: 1604:28-1604:49 */;
            ResourceReference s_ = a?.PartOf /* CQL: 1605:14-1605:21 */;
            List<Location.HoursOfOperationComponent> t_ = a?.HoursOfOperation;
            FhirString u_ = a?.AvailabilityExceptionsElement /* CQL: 1607:30-1607:53 */;
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
            arg /* CQL: 1612:3-1612:5 */,
        ];

        Measure b_(Measure a) {
            FhirUri f_ = a?.UrlElement /* CQL: 1614:11-1614:15 */;
            List<Identifier> g_ = a?.Identifier;
            FhirString h_ = a?.VersionElement /* CQL: 1616:15-1616:23 */;
            FhirString i_ = a?.NameElement /* CQL: 1617:12-1617:17 */;
            FhirString j_ = a?.TitleElement /* CQL: 1618:13-1618:19 */;
            FhirString k_ = a?.SubtitleElement /* CQL: 1619:16-1619:25 */;
            Code<PublicationStatus> l_ = a?.StatusElement /* CQL: 1620:14-1620:21 */;
            FhirBoolean m_ = a?.ExperimentalElement /* CQL: 1621:20-1621:33 */;
            DataType n_ = a?.Subject;
            FhirDateTime o_ = a?.DateElement /* CQL: 1623:12-1623:17 */;
            FhirString p_ = a?.PublisherElement /* CQL: 1624:17-1624:27 */;
            List<ContactDetail> q_ = a?.Contact;
            Markdown r_ = a?.DescriptionElement /* CQL: 1626:19-1626:31 */;
            List<UsageContext> s_ = a?.UseContext;
            List<CodeableConcept> t_ = a?.Jurisdiction;
            Markdown u_ = a?.PurposeElement /* CQL: 1629:15-1629:23 */;
            FhirString v_ = a?.UsageElement /* CQL: 1630:13-1630:19 */;
            Markdown w_ = a?.CopyrightElement /* CQL: 1631:17-1631:27 */;
            Date x_ = a?.ApprovalDateElement /* CQL: 1632:20-1632:33 */;
            Date y_ = a?.LastReviewDateElement /* CQL: 1633:22-1633:37 */;
            Period z_ = a?.EffectivePeriod /* CQL: 1634:23-1634:39 */;
            List<CodeableConcept> aa_ = a?.Topic;
            List<ContactDetail> ab_ = a?.Author;
            List<ContactDetail> ac_ = a?.Editor;
            List<ContactDetail> ad_ = a?.Reviewer;
            List<ContactDetail> ae_ = a?.Endorser;
            List<RelatedArtifact> af_ = a?.RelatedArtifact;
            List<Canonical> ag_ = a?.LibraryElement;
            Markdown ah_ = a?.DisclaimerElement /* CQL: 1642:18-1642:29 */;
            CodeableConcept ai_ = a?.Scoring /* CQL: 1643:15-1643:23 */;
            CodeableConcept aj_ = a?.CompositeScoring /* CQL: 1644:24-1644:41 */;
            List<CodeableConcept> ak_ = a?.Type;
            FhirString al_ = a?.RiskAdjustmentElement /* CQL: 1646:22-1646:37 */;
            FhirString am_ = a?.RateAggregationElement /* CQL: 1647:23-1647:39 */;
            Markdown an_ = a?.RationaleElement /* CQL: 1648:17-1648:27 */;
            Markdown ao_ = a?.ClinicalRecommendationStatementElement /* CQL: 1649:39-1649:71 */;
            CodeableConcept ap_ = a?.ImprovementNotation /* CQL: 1650:27-1650:47 */;
            List<Markdown> aq_ = a?.DefinitionElement;
            Markdown ar_ = a?.GuidanceElement /* CQL: 1652:16-1652:25 */;
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
            arg /* CQL: 1658:3-1658:5 */,
        ];

        MeasureReport b_(MeasureReport a) {
            List<Identifier> f_ = a?.Identifier;
            Code<MeasureReport.MeasureReportStatus> g_ = a?.StatusElement /* CQL: 1661:14-1661:21 */;
            Code<MeasureReport.MeasureReportType> h_ = a?.TypeElement /* CQL: 1662:12-1662:17 */;
            Canonical i_ = a?.MeasureElement /* CQL: 1663:15-1663:23 */;
            ResourceReference j_ = a?.Subject /* CQL: 1664:15-1664:23 */;
            FhirDateTime k_ = a?.DateElement /* CQL: 1665:12-1665:17 */;
            ResourceReference l_ = a?.Reporter /* CQL: 1666:16-1666:25 */;
            Period m_ = a?.Period /* CQL: 1667:14-1667:21 */;
            CodeableConcept n_ = a?.ImprovementNotation /* CQL: 1668:27-1668:47 */;
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
            arg /* CQL: 1701:3-1701:5 */,
        ];

        Medication b_(Medication a) {
            List<Identifier> f_ = a?.Identifier;
            CodeableConcept g_ = a?.Code /* CQL: 1704:12-1704:17 */;
            Code<Medication.MedicationStatusCodes> h_ = a?.StatusElement /* CQL: 1705:14-1705:21 */;
            ResourceReference i_ = a?.Manufacturer /* CQL: 1706:20-1706:33 */;
            CodeableConcept j_ = a?.Form /* CQL: 1707:12-1707:17 */;
            Ratio k_ = a?.Amount /* CQL: 1708:14-1708:21 */;
            List<Medication.IngredientComponent> l_ = a?.Ingredient;
            Medication.BatchComponent m_ = a?.Batch /* CQL: 1710:13-1710:19 */;
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
            arg /* CQL: 1714:3-1714:5 */,
        ];

        MedicationAdministration b_(MedicationAdministration a) {
            List<Identifier> f_ = a?.Identifier;
            List<FhirUri> g_ = a?.InstantiatesElement;
            List<ResourceReference> h_ = a?.PartOf;
            Code<MedicationAdministration.MedicationAdministrationStatusCodes> i_ = a?.StatusElement /* CQL: 1719:14-1719:21 */;
            List<CodeableConcept> j_ = a?.StatusReason;
            CodeableConcept k_ = a?.Category /* CQL: 1721:16-1721:25 */;
            DataType l_ = a?.Medication;
            ResourceReference m_ = a?.Subject /* CQL: 1723:15-1723:23 */;
            ResourceReference n_ = a?.Context /* CQL: 1724:15-1724:23 */;
            List<ResourceReference> o_ = a?.SupportingInformation;
            DataType p_ = a?.Effective;
            List<MedicationAdministration.PerformerComponent> q_ = a?.Performer;
            List<CodeableConcept> r_ = a?.ReasonCode;
            List<ResourceReference> s_ = a?.ReasonReference;
            ResourceReference t_ = a?.Request /* CQL: 1730:15-1730:23 */;
            List<ResourceReference> u_ = a?.Device;
            List<Annotation> v_ = a?.Note;
            MedicationAdministration.DosageComponent w_ = a?.Dosage /* CQL: 1733:14-1733:21 */;
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
            arg /* CQL: 1738:3-1738:5 */,
        ];

        MedicationDispense b_(MedicationDispense a) {
            List<Identifier> f_ = a?.Identifier;
            List<ResourceReference> g_ = a?.PartOf;
            Code<MedicationDispense.MedicationDispenseStatusCodes> h_ = a?.StatusElement /* CQL: 1742:14-1742:21 */;
            DataType i_ = a?.StatusReason;
            CodeableConcept j_ = a?.Category /* CQL: 1744:16-1744:25 */;
            DataType k_ = a?.Medication;
            ResourceReference l_ = a?.Subject /* CQL: 1746:15-1746:23 */;
            ResourceReference m_ = a?.Context /* CQL: 1747:15-1747:23 */;
            List<ResourceReference> n_ = a?.SupportingInformation;
            List<MedicationDispense.PerformerComponent> o_ = a?.Performer;
            ResourceReference p_ = a?.Location /* CQL: 1750:16-1750:25 */;
            List<ResourceReference> q_ = a?.AuthorizingPrescription;
            CodeableConcept r_ = a?.Type /* CQL: 1752:12-1752:17 */;
            Quantity s_ = a?.Quantity /* CQL: 1753:16-1753:25 */;
            Quantity t_ = a?.DaysSupply /* CQL: 1754:18-1754:29 */;
            FhirDateTime u_ = a?.WhenPreparedElement /* CQL: 1755:20-1755:33 */;
            FhirDateTime v_ = a?.WhenHandedOverElement /* CQL: 1756:22-1756:37 */;
            ResourceReference w_ = a?.Destination /* CQL: 1757:19-1757:31 */;
            List<ResourceReference> x_ = a?.Receiver;
            List<Annotation> y_ = a?.Note;
            List<Dosage> z_ = a?.DosageInstruction;
            MedicationDispense.SubstitutionComponent aa_ = a?.Substitution /* CQL: 1761:20-1761:33 */;
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
            arg /* CQL: 1767:3-1767:5 */,
        ];

        MedicationKnowledge b_(MedicationKnowledge a) {
            CodeableConcept f_ = a?.Code /* CQL: 1769:12-1769:17 */;
            Code<MedicationKnowledge.MedicationKnowledgeStatusCodes> g_ = a?.StatusElement /* CQL: 1770:14-1770:21 */;
            ResourceReference h_ = a?.Manufacturer /* CQL: 1771:20-1771:33 */;
            CodeableConcept i_ = a?.DoseForm /* CQL: 1772:16-1772:25 */;
            Quantity j_ = a?.Amount /* CQL: 1773:14-1773:21 */;
            List<FhirString> k_ = a?.SynonymElement;
            List<MedicationKnowledge.RelatedMedicationKnowledgeComponent> l_ = a?.RelatedMedicationKnowledge;
            List<ResourceReference> m_ = a?.AssociatedMedication;
            List<CodeableConcept> n_ = a?.ProductType;
            List<MedicationKnowledge.MonographComponent> o_ = a?.Monograph;
            List<MedicationKnowledge.IngredientComponent> p_ = a?.Ingredient;
            Markdown q_ = a?.PreparationInstructionElement /* CQL: 1780:30-1780:53 */;
            List<CodeableConcept> r_ = a?.IntendedRoute;
            List<MedicationKnowledge.CostComponent> s_ = a?.Cost;
            List<MedicationKnowledge.MonitoringProgramComponent> t_ = a?.MonitoringProgram;
            List<MedicationKnowledge.AdministrationGuidelinesComponent> u_ = a?.AdministrationGuidelines;
            List<MedicationKnowledge.MedicineClassificationComponent> v_ = a?.MedicineClassification;
            MedicationKnowledge.PackagingComponent w_ = a?.Packaging /* CQL: 1786:17-1786:27 */;
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
            arg /* CQL: 1794:3-1794:5 */,
        ];

        MedicationRequest b_(MedicationRequest a) {
            List<Identifier> f_ = a?.Identifier;
            Code<MedicationRequest.MedicationrequestStatus> g_ = a?.StatusElement /* CQL: 1797:14-1797:21 */;
            CodeableConcept h_ = a?.StatusReason /* CQL: 1798:20-1798:33 */;
            Code<MedicationRequest.MedicationRequestIntent> i_ = a?.IntentElement /* CQL: 1799:14-1799:21 */;
            List<CodeableConcept> j_ = a?.Category;
            Code<RequestPriority> k_ = a?.PriorityElement /* CQL: 1801:16-1801:25 */;
            FhirBoolean l_ = a?.DoNotPerformElement /* CQL: 1802:20-1802:33 */;
            DataType m_ = a?.Reported;
            DataType n_ = a?.Medication;
            ResourceReference o_ = a?.Subject /* CQL: 1805:15-1805:23 */;
            ResourceReference p_ = a?.Encounter /* CQL: 1806:17-1806:27 */;
            List<ResourceReference> q_ = a?.SupportingInformation;
            FhirDateTime r_ = a?.AuthoredOnElement /* CQL: 1808:18-1808:29 */;
            ResourceReference s_ = a?.Requester /* CQL: 1809:17-1809:27 */;
            ResourceReference t_ = a?.Performer /* CQL: 1810:17-1810:27 */;
            CodeableConcept u_ = a?.PerformerType /* CQL: 1811:21-1811:35 */;
            ResourceReference v_ = a?.Recorder /* CQL: 1812:16-1812:25 */;
            List<CodeableConcept> w_ = a?.ReasonCode;
            List<ResourceReference> x_ = a?.ReasonReference;
            List<Canonical> y_ = a?.InstantiatesCanonicalElement;
            List<FhirUri> z_ = a?.InstantiatesUriElement;
            List<ResourceReference> aa_ = a?.BasedOn;
            Identifier ab_ = a?.GroupIdentifier /* CQL: 1818:23-1818:39 */;
            CodeableConcept ac_ = a?.CourseOfTherapyType /* CQL: 1819:27-1819:47 */;
            List<ResourceReference> ad_ = a?.Insurance;
            List<Annotation> ae_ = a?.Note;
            List<Dosage> af_ = a?.DosageInstruction;
            MedicationRequest.DispenseRequestComponent ag_ = a?.DispenseRequest /* CQL: 1823:23-1823:39 */;
            MedicationRequest.SubstitutionComponent ah_ = a?.Substitution /* CQL: 1824:20-1824:33 */;
            ResourceReference ai_ = a?.PriorPrescription /* CQL: 1825:25-1825:43 */;
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
            arg /* CQL: 1831:3-1831:5 */,
        ];

        MedicationStatement b_(MedicationStatement a) {
            List<Identifier> f_ = a?.Identifier;
            List<ResourceReference> g_ = a?.BasedOn;
            List<ResourceReference> h_ = a?.PartOf;
            Code<MedicationStatement.MedicationStatusCodes> i_ = a?.StatusElement /* CQL: 1836:14-1836:21 */;
            List<CodeableConcept> j_ = a?.StatusReason;
            CodeableConcept k_ = a?.Category /* CQL: 1838:16-1838:25 */;
            DataType l_ = a?.Medication;
            ResourceReference m_ = a?.Subject /* CQL: 1840:15-1840:23 */;
            ResourceReference n_ = a?.Context /* CQL: 1841:15-1841:23 */;
            DataType o_ = a?.Effective;
            FhirDateTime p_ = a?.DateAssertedElement /* CQL: 1843:20-1843:33 */;
            ResourceReference q_ = a?.InformationSource /* CQL: 1844:25-1844:43 */;
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
            arg /* CQL: 1853:3-1853:5 */,
        ];

        MedicinalProduct b_(MedicinalProduct a) {
            List<Identifier> f_ = a?.Identifier;
            CodeableConcept g_ = a?.Type /* CQL: 1856:12-1856:17 */;
            Coding h_ = a?.Domain /* CQL: 1857:14-1857:21 */;
            CodeableConcept i_ = a?.CombinedPharmaceuticalDoseForm /* CQL: 1858:38-1858:69 */;
            CodeableConcept j_ = a?.LegalStatusOfSupply /* CQL: 1859:27-1859:47 */;
            CodeableConcept k_ = a?.AdditionalMonitoringIndicator /* CQL: 1860:37-1860:67 */;
            List<FhirString> l_ = a?.SpecialMeasuresElement;
            CodeableConcept m_ = a?.PaediatricUseIndicator /* CQL: 1862:30-1862:53 */;
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
            arg /* CQL: 1878:3-1878:5 */,
        ];

        MedicinalProductAuthorization b_(MedicinalProductAuthorization a) {
            List<Identifier> f_ = a?.Identifier;
            ResourceReference g_ = a?.Subject /* CQL: 1881:15-1881:23 */;
            List<CodeableConcept> h_ = a?.Country;
            List<CodeableConcept> i_ = a?.Jurisdiction;
            CodeableConcept j_ = a?.Status /* CQL: 1884:14-1884:21 */;
            FhirDateTime k_ = a?.StatusDateElement /* CQL: 1885:18-1885:29 */;
            FhirDateTime l_ = a?.RestoreDateElement /* CQL: 1886:19-1886:31 */;
            Period m_ = a?.ValidityPeriod /* CQL: 1887:22-1887:37 */;
            Period n_ = a?.DataExclusivityPeriod /* CQL: 1888:29-1888:51 */;
            FhirDateTime o_ = a?.DateOfFirstAuthorizationElement /* CQL: 1889:32-1889:57 */;
            FhirDateTime p_ = a?.InternationalBirthDateElement /* CQL: 1890:30-1890:53 */;
            CodeableConcept q_ = a?.LegalBasis /* CQL: 1891:18-1891:29 */;
            List<MedicinalProductAuthorization.JurisdictionalAuthorizationComponent> r_ = a?.JurisdictionalAuthorization;
            ResourceReference s_ = a?.Holder /* CQL: 1893:14-1893:21 */;
            ResourceReference t_ = a?.Regulator /* CQL: 1894:17-1894:27 */;
            MedicinalProductAuthorization.ProcedureComponent u_ = a?.Procedure /* CQL: 1895:17-1895:27 */;
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
            arg /* CQL: 1899:3-1899:5 */,
        ];

        MedicinalProductContraindication b_(MedicinalProductContraindication a) {
            List<ResourceReference> f_ = a?.Subject;
            CodeableConcept g_ = a?.Disease /* CQL: 1902:15-1902:23 */;
            CodeableConcept h_ = a?.DiseaseStatus /* CQL: 1903:21-1903:35 */;
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
            arg /* CQL: 1925:3-1925:5 */,
        ];

        MedicinalProductIngredient b_(MedicinalProductIngredient a) {
            Identifier f_ = a?.Identifier /* CQL: 1927:18-1927:29 */;
            CodeableConcept g_ = a?.Role /* CQL: 1928:12-1928:17 */;
            FhirBoolean h_ = a?.AllergenicIndicatorElement /* CQL: 1929:27-1929:47 */;
            List<ResourceReference> i_ = a?.Manufacturer;
            List<MedicinalProductIngredient.SpecifiedSubstanceComponent> j_ = a?.SpecifiedSubstance;
            MedicinalProductIngredient.SubstanceComponent k_ = a?.Substance /* CQL: 1932:17-1932:27 */;
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
            arg /* CQL: 1936:3-1936:5 */,
        ];

        MedicinalProductInteraction b_(MedicinalProductInteraction a) {
            List<ResourceReference> f_ = a?.Subject;
            FhirString g_ = a?.DescriptionElement /* CQL: 1939:19-1939:31 */;
            List<MedicinalProductInteraction.InteractantComponent> h_ = a?.Interactant;
            CodeableConcept i_ = a?.Type /* CQL: 1941:12-1941:17 */;
            CodeableConcept j_ = a?.Effect /* CQL: 1942:14-1942:21 */;
            CodeableConcept k_ = a?.Incidence /* CQL: 1943:17-1943:27 */;
            CodeableConcept l_ = a?.Management /* CQL: 1944:18-1944:29 */;
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
            arg /* CQL: 1948:3-1948:5 */,
        ];

        MedicinalProductManufactured b_(MedicinalProductManufactured a) {
            CodeableConcept f_ = a?.ManufacturedDoseForm /* CQL: 1950:28-1950:49 */;
            CodeableConcept g_ = a?.UnitOfPresentation /* CQL: 1951:26-1951:45 */;
            Quantity h_ = a?.Quantity /* CQL: 1952:16-1952:25 */;
            List<ResourceReference> i_ = a?.Manufacturer;
            List<ResourceReference> j_ = a?.Ingredient;
            ProdCharacteristic k_ = a?.PhysicalCharacteristics /* CQL: 1955:31-1955:55 */;
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
            arg /* CQL: 1960:3-1960:5 */,
        ];

        MedicinalProductPackaged b_(MedicinalProductPackaged a) {
            List<Identifier> f_ = a?.Identifier;
            List<ResourceReference> g_ = a?.Subject;
            FhirString h_ = a?.DescriptionElement /* CQL: 1964:19-1964:31 */;
            CodeableConcept i_ = a?.LegalStatusOfSupply /* CQL: 1965:27-1965:47 */;
            List<MarketingStatus> j_ = a?.MarketingStatus;
            ResourceReference k_ = a?.MarketingAuthorization /* CQL: 1967:30-1967:53 */;
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
            arg /* CQL: 1974:3-1974:5 */,
        ];

        MedicinalProductPharmaceutical b_(MedicinalProductPharmaceutical a) {
            List<Identifier> f_ = a?.Identifier;
            CodeableConcept g_ = a?.AdministrableDoseForm /* CQL: 1977:29-1977:51 */;
            CodeableConcept h_ = a?.UnitOfPresentation /* CQL: 1978:26-1978:45 */;
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
            arg /* CQL: 1986:3-1986:5 */,
        ];

        MedicinalProductUndesirableEffect b_(MedicinalProductUndesirableEffect a) {
            List<ResourceReference> f_ = a?.Subject;
            CodeableConcept g_ = a?.SymptomConditionEffect /* CQL: 1989:30-1989:53 */;
            CodeableConcept h_ = a?.Classification /* CQL: 1990:22-1990:37 */;
            CodeableConcept i_ = a?.FrequencyOfOccurrence /* CQL: 1991:29-1991:51 */;
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
            arg /* CQL: 2025:3-2025:5 */,
        ];

        MessageHeader b_(MessageHeader a) {
            DataType f_ = a?.Event;
            List<MessageHeader.MessageDestinationComponent> g_ = a?.Destination;
            ResourceReference h_ = a?.Sender /* CQL: 2029:14-2029:21 */;
            ResourceReference i_ = a?.Enterer /* CQL: 2030:15-2030:23 */;
            ResourceReference j_ = a?.Author /* CQL: 2031:14-2031:21 */;
            MessageHeader.MessageSourceComponent k_ = a?.Source /* CQL: 2032:14-2032:21 */;
            ResourceReference l_ = a?.Responsible /* CQL: 2033:19-2033:31 */;
            CodeableConcept m_ = a?.Reason /* CQL: 2034:14-2034:21 */;
            MessageHeader.ResponseComponent n_ = a?.Response /* CQL: 2035:16-2035:25 */;
            List<ResourceReference> o_ = a?.Focus;
            Canonical p_ = a?.DefinitionElement /* CQL: 2037:18-2037:29 */;
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
            arg /* CQL: 2041:3-2041:5 */,
        ];

        MolecularSequence b_(MolecularSequence a) {
            List<Identifier> f_ = a?.Identifier;
            Code<MolecularSequence.SequenceType> g_ = a?.TypeElement /* CQL: 2044:12-2044:17 */;
            Integer h_ = a?.CoordinateSystemElement /* CQL: 2045:24-2045:41 */;
            ResourceReference i_ = a?.Patient /* CQL: 2046:15-2046:23 */;
            ResourceReference j_ = a?.Specimen /* CQL: 2047:16-2047:25 */;
            ResourceReference k_ = a?.Device /* CQL: 2048:14-2048:21 */;
            ResourceReference l_ = a?.Performer /* CQL: 2049:17-2049:27 */;
            Quantity m_ = a?.Quantity /* CQL: 2050:16-2050:25 */;
            MolecularSequence.ReferenceSeqComponent n_ = a?.ReferenceSeq /* CQL: 2051:20-2051:33 */;
            List<MolecularSequence.VariantComponent> o_ = a?.Variant;
            FhirString p_ = a?.ObservedSeqElement /* CQL: 2053:19-2053:31 */;
            List<MolecularSequence.QualityComponent> q_ = a?.Quality;
            Integer r_ = a?.ReadCoverageElement /* CQL: 2055:20-2055:33 */;
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
            arg /* CQL: 2062:3-2062:5 */,
        ];

        NamingSystem b_(NamingSystem a) {
            FhirString f_ = a?.NameElement /* CQL: 2064:12-2064:17 */;
            Code<PublicationStatus> g_ = a?.StatusElement /* CQL: 2065:14-2065:21 */;
            Code<NamingSystem.NamingSystemType> h_ = a?.KindElement /* CQL: 2066:12-2066:17 */;
            FhirDateTime i_ = a?.DateElement /* CQL: 2067:12-2067:17 */;
            FhirString j_ = a?.PublisherElement /* CQL: 2068:17-2068:27 */;
            List<ContactDetail> k_ = a?.Contact;
            FhirString l_ = a?.ResponsibleElement /* CQL: 2070:19-2070:31 */;
            CodeableConcept m_ = a?.Type /* CQL: 2071:12-2071:17 */;
            Markdown n_ = a?.DescriptionElement /* CQL: 2072:19-2072:31 */;
            List<UsageContext> o_ = a?.UseContext;
            List<CodeableConcept> p_ = a?.Jurisdiction;
            FhirString q_ = a?.UsageElement /* CQL: 2075:13-2075:19 */;
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
            arg /* CQL: 2080:3-2080:5 */,
        ];

        NutritionOrder b_(NutritionOrder a) {
            List<Identifier> f_ = a?.Identifier;
            List<Canonical> g_ = a?.InstantiatesCanonicalElement;
            List<FhirUri> h_ = a?.InstantiatesUriElement;
            List<FhirUri> i_ = a?.InstantiatesElement;
            Code<RequestStatus> j_ = a?.StatusElement /* CQL: 2086:14-2086:21 */;
            Code<RequestIntent> k_ = a?.IntentElement /* CQL: 2087:14-2087:21 */;
            ResourceReference l_ = a?.Patient /* CQL: 2088:15-2088:23 */;
            ResourceReference m_ = a?.Encounter /* CQL: 2089:17-2089:27 */;
            FhirDateTime n_ = a?.DateTimeElement /* CQL: 2090:16-2090:25 */;
            ResourceReference o_ = a?.Orderer /* CQL: 2091:15-2091:23 */;
            List<ResourceReference> p_ = a?.AllergyIntolerance;
            List<CodeableConcept> q_ = a?.FoodPreferenceModifier;
            List<CodeableConcept> r_ = a?.ExcludeFoodModifier;
            NutritionOrder.OralDietComponent s_ = a?.OralDiet /* CQL: 2095:16-2095:25 */;
            List<NutritionOrder.SupplementComponent> t_ = a?.Supplement;
            NutritionOrder.EnteralFormulaComponent u_ = a?.EnteralFormula /* CQL: 2097:22-2097:37 */;
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
            arg /* CQL: 2102:3-2102:5 */,
        ];

        Observation b_(Observation a) {
            List<Identifier> f_ = a?.Identifier;
            List<ResourceReference> g_ = a?.BasedOn;
            List<ResourceReference> h_ = a?.PartOf;
            Code<ObservationStatus> i_ = a?.StatusElement /* CQL: 2107:14-2107:21 */;
            List<CodeableConcept> j_ = a?.Category;
            CodeableConcept k_ = a?.Code /* CQL: 2109:12-2109:17 */;
            ResourceReference l_ = a?.Subject /* CQL: 2110:15-2110:23 */;
            List<ResourceReference> m_ = a?.Focus;
            ResourceReference n_ = a?.Encounter /* CQL: 2112:17-2112:27 */;
            DataType o_ = a?.Effective;
            Instant p_ = a?.IssuedElement /* CQL: 2114:14-2114:21 */;
            List<ResourceReference> q_ = a?.Performer;
            DataType r_ = a?.Value;
            CodeableConcept s_ = a?.DataAbsentReason /* CQL: 2117:24-2117:41 */;
            List<CodeableConcept> t_ = a?.Interpretation;
            List<Annotation> u_ = a?.Note;
            CodeableConcept v_ = a?.BodySite /* CQL: 2120:16-2120:25 */;
            CodeableConcept w_ = a?.Method /* CQL: 2121:14-2121:21 */;
            ResourceReference x_ = a?.Specimen /* CQL: 2122:16-2122:25 */;
            ResourceReference y_ = a?.Device /* CQL: 2123:14-2123:21 */;
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
            arg /* CQL: 2131:3-2131:5 */,
        ];

        ObservationDefinition b_(ObservationDefinition a) {
            List<CodeableConcept> f_ = a?.Category;
            CodeableConcept g_ = a?.Code /* CQL: 2134:12-2134:17 */;
            List<Identifier> h_ = a?.Identifier;
            List<Code<ObservationDefinition.ObservationDataType>> i_ = a?.PermittedDataTypeElement;
            FhirBoolean j_ = a?.MultipleResultsAllowedElement /* CQL: 2137:30-2137:53 */;
            CodeableConcept k_ = a?.Method /* CQL: 2138:14-2138:21 */;
            FhirString l_ = a?.PreferredReportNameElement /* CQL: 2139:27-2139:47 */;
            ObservationDefinition.QuantitativeDetailsComponent m_ = a?.QuantitativeDetails /* CQL: 2140:27-2140:47 */;
            List<ObservationDefinition.QualifiedIntervalComponent> n_ = a?.QualifiedInterval;
            ResourceReference o_ = a?.ValidCodedValueSet /* CQL: 2142:26-2142:45 */;
            ResourceReference p_ = a?.NormalCodedValueSet /* CQL: 2143:27-2143:47 */;
            ResourceReference q_ = a?.AbnormalCodedValueSet /* CQL: 2144:29-2144:51 */;
            ResourceReference r_ = a?.CriticalCodedValueSet /* CQL: 2145:29-2145:51 */;
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
            arg /* CQL: 2180:3-2180:5 */,
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
            arg /* CQL: 2186:3-2186:5 */,
        ];

        Organization b_(Organization a) {
            List<Identifier> f_ = a?.Identifier;
            FhirBoolean g_ = a?.ActiveElement /* CQL: 2189:14-2189:21 */;
            List<CodeableConcept> h_ = a?.Type;
            FhirString i_ = a?.NameElement /* CQL: 2191:12-2191:17 */;
            List<FhirString> j_ = a?.AliasElement;
            List<ContactPoint> k_ = a?.Telecom;
            List<Address> l_ = a?.Address;
            ResourceReference m_ = a?.PartOf /* CQL: 2195:14-2195:21 */;
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
            arg /* CQL: 2201:3-2201:5 */,
        ];

        OrganizationAffiliation b_(OrganizationAffiliation a) {
            List<Identifier> f_ = a?.Identifier;
            FhirBoolean g_ = a?.ActiveElement /* CQL: 2204:14-2204:21 */;
            Period h_ = a?.Period /* CQL: 2205:14-2205:21 */;
            ResourceReference i_ = a?.Organization /* CQL: 2206:20-2206:33 */;
            ResourceReference j_ = a?.ParticipatingOrganization /* CQL: 2207:33-2207:59 */;
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
            arg /* CQL: 2218:3-2218:5 */,
        ];

        Patient b_(Patient a) {
            List<Identifier> f_ = a?.Identifier;
            FhirBoolean g_ = a?.ActiveElement /* CQL: 2221:14-2221:21 */;
            List<HumanName> h_ = a?.Name;
            List<ContactPoint> i_ = a?.Telecom;
            Code<AdministrativeGender> j_ = a?.GenderElement /* CQL: 2224:14-2224:21 */;
            Date k_ = a?.BirthDateElement /* CQL: 2225:17-2225:27 */;
            DataType l_ = a?.Deceased;
            List<Address> m_ = a?.Address;
            CodeableConcept n_ = a?.MaritalStatus /* CQL: 2228:21-2228:35 */;
            DataType o_ = a?.MultipleBirth;
            List<Attachment> p_ = a?.Photo;
            List<Patient.ContactComponent> q_ = a?.Contact;
            List<Patient.CommunicationComponent> r_ = a?.Communication;
            List<ResourceReference> s_ = a?.GeneralPractitioner;
            ResourceReference t_ = a?.ManagingOrganization /* CQL: 2234:28-2234:49 */;
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
            arg /* CQL: 2239:3-2239:5 */,
        ];

        PaymentNotice b_(PaymentNotice a) {
            List<Identifier> f_ = a?.Identifier;
            Code<FinancialResourceStatusCodes> g_ = a?.StatusElement /* CQL: 2242:14-2242:21 */;
            ResourceReference h_ = a?.Request /* CQL: 2243:15-2243:23 */;
            ResourceReference i_ = a?.Response /* CQL: 2244:16-2244:25 */;
            FhirDateTime j_ = a?.CreatedElement /* CQL: 2245:15-2245:23 */;
            ResourceReference k_ = a?.Provider /* CQL: 2246:16-2246:25 */;
            ResourceReference l_ = a?.Payment /* CQL: 2247:15-2247:23 */;
            Date m_ = a?.PaymentDateElement /* CQL: 2248:19-2248:31 */;
            ResourceReference n_ = a?.Payee /* CQL: 2249:13-2249:19 */;
            ResourceReference o_ = a?.Recipient /* CQL: 2250:17-2250:27 */;
            Money p_ = a?.Amount /* CQL: 2251:14-2251:21 */;
            CodeableConcept q_ = a?.PaymentStatus /* CQL: 2252:21-2252:35 */;
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
            arg /* CQL: 2256:3-2256:5 */,
        ];

        PaymentReconciliation b_(PaymentReconciliation a) {
            List<Identifier> f_ = a?.Identifier;
            Code<FinancialResourceStatusCodes> g_ = a?.StatusElement /* CQL: 2259:14-2259:21 */;
            Period h_ = a?.Period /* CQL: 2260:14-2260:21 */;
            FhirDateTime i_ = a?.CreatedElement /* CQL: 2261:15-2261:23 */;
            ResourceReference j_ = a?.PaymentIssuer /* CQL: 2262:21-2262:35 */;
            ResourceReference k_ = a?.Request /* CQL: 2263:15-2263:23 */;
            ResourceReference l_ = a?.Requestor /* CQL: 2264:17-2264:27 */;
            Code<ClaimProcessingCodes> m_ = a?.OutcomeElement /* CQL: 2265:15-2265:23 */;
            FhirString n_ = a?.DispositionElement /* CQL: 2266:19-2266:31 */;
            Date o_ = a?.PaymentDateElement /* CQL: 2267:19-2267:31 */;
            Money p_ = a?.PaymentAmount /* CQL: 2268:21-2268:35 */;
            Identifier q_ = a?.PaymentIdentifier /* CQL: 2269:25-2269:43 */;
            List<PaymentReconciliation.DetailsComponent> r_ = a?.Detail;
            CodeableConcept s_ = a?.FormCode /* CQL: 2271:16-2271:25 */;
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
            arg /* CQL: 2276:3-2276:5 */,
        ];

        Person b_(Person a) {
            List<Identifier> f_ = a?.Identifier;
            List<HumanName> g_ = a?.Name;
            List<ContactPoint> h_ = a?.Telecom;
            Code<AdministrativeGender> i_ = a?.GenderElement /* CQL: 2281:14-2281:21 */;
            Date j_ = a?.BirthDateElement /* CQL: 2282:17-2282:27 */;
            List<Address> k_ = a?.Address;
            Attachment l_ = a?.Photo /* CQL: 2284:13-2284:19 */;
            ResourceReference m_ = a?.ManagingOrganization /* CQL: 2285:28-2285:49 */;
            FhirBoolean n_ = a?.ActiveElement /* CQL: 2286:14-2286:21 */;
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
            arg /* CQL: 2291:3-2291:5 */,
        ];

        PlanDefinition b_(PlanDefinition a) {
            FhirUri f_ = a?.UrlElement /* CQL: 2293:11-2293:15 */;
            List<Identifier> g_ = a?.Identifier;
            FhirString h_ = a?.VersionElement /* CQL: 2295:15-2295:23 */;
            FhirString i_ = a?.NameElement /* CQL: 2296:12-2296:17 */;
            FhirString j_ = a?.TitleElement /* CQL: 2297:13-2297:19 */;
            FhirString k_ = a?.SubtitleElement /* CQL: 2298:16-2298:25 */;
            CodeableConcept l_ = a?.Type /* CQL: 2299:12-2299:17 */;
            Code<PublicationStatus> m_ = a?.StatusElement /* CQL: 2300:14-2300:21 */;
            FhirBoolean n_ = a?.ExperimentalElement /* CQL: 2301:20-2301:33 */;
            DataType o_ = a?.Subject;
            FhirDateTime p_ = a?.DateElement /* CQL: 2303:12-2303:17 */;
            FhirString q_ = a?.PublisherElement /* CQL: 2304:17-2304:27 */;
            List<ContactDetail> r_ = a?.Contact;
            Markdown s_ = a?.DescriptionElement /* CQL: 2306:19-2306:31 */;
            List<UsageContext> t_ = a?.UseContext;
            List<CodeableConcept> u_ = a?.Jurisdiction;
            Markdown v_ = a?.PurposeElement /* CQL: 2309:15-2309:23 */;
            FhirString w_ = a?.UsageElement /* CQL: 2310:13-2310:19 */;
            Markdown x_ = a?.CopyrightElement /* CQL: 2311:17-2311:27 */;
            Date y_ = a?.ApprovalDateElement /* CQL: 2312:20-2312:33 */;
            Date z_ = a?.LastReviewDateElement /* CQL: 2313:22-2313:37 */;
            Period aa_ = a?.EffectivePeriod /* CQL: 2314:23-2314:39 */;
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
            arg /* CQL: 2327:3-2327:5 */,
        ];

        Practitioner b_(Practitioner a) {
            List<Identifier> f_ = a?.Identifier;
            FhirBoolean g_ = a?.ActiveElement /* CQL: 2330:14-2330:21 */;
            List<HumanName> h_ = a?.Name;
            List<ContactPoint> i_ = a?.Telecom;
            List<Address> j_ = a?.Address;
            Code<AdministrativeGender> k_ = a?.GenderElement /* CQL: 2334:14-2334:21 */;
            Date l_ = a?.BirthDateElement /* CQL: 2335:17-2335:27 */;
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
            arg /* CQL: 2342:3-2342:5 */,
        ];

        PractitionerRole b_(PractitionerRole a) {
            List<Identifier> f_ = a?.Identifier;
            FhirBoolean g_ = a?.ActiveElement /* CQL: 2345:14-2345:21 */;
            Period h_ = a?.Period /* CQL: 2346:14-2346:21 */;
            ResourceReference i_ = a?.Practitioner /* CQL: 2347:20-2347:33 */;
            ResourceReference j_ = a?.Organization /* CQL: 2348:20-2348:33 */;
            List<CodeableConcept> k_ = a?.Code;
            List<CodeableConcept> l_ = a?.Specialty;
            List<ResourceReference> m_ = a?.Location;
            List<ResourceReference> n_ = a?.HealthcareService;
            List<ContactPoint> o_ = a?.Telecom;
            List<PractitionerRole.AvailableTimeComponent> p_ = a?.AvailableTime;
            List<PractitionerRole.NotAvailableComponent> q_ = a?.NotAvailable;
            FhirString r_ = a?.AvailabilityExceptionsElement /* CQL: 2356:30-2356:53 */;
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
            arg /* CQL: 2361:3-2361:5 */,
        ];

        Procedure b_(Procedure a) {
            List<Identifier> f_ = a?.Identifier;
            List<Canonical> g_ = a?.InstantiatesCanonicalElement;
            List<FhirUri> h_ = a?.InstantiatesUriElement;
            List<ResourceReference> i_ = a?.BasedOn;
            List<ResourceReference> j_ = a?.PartOf;
            Code<EventStatus> k_ = a?.StatusElement /* CQL: 2368:14-2368:21 */;
            CodeableConcept l_ = a?.StatusReason /* CQL: 2369:20-2369:33 */;
            CodeableConcept m_ = a?.Category /* CQL: 2370:16-2370:25 */;
            CodeableConcept n_ = a?.Code /* CQL: 2371:12-2371:17 */;
            ResourceReference o_ = a?.Subject /* CQL: 2372:15-2372:23 */;
            ResourceReference p_ = a?.Encounter /* CQL: 2373:17-2373:27 */;
            DataType q_ = a?.Performed;
            ResourceReference r_ = a?.Recorder /* CQL: 2375:16-2375:25 */;
            ResourceReference s_ = a?.Asserter /* CQL: 2376:16-2376:25 */;
            List<Procedure.PerformerComponent> t_ = a?.Performer;
            ResourceReference u_ = a?.Location /* CQL: 2378:16-2378:25 */;
            List<CodeableConcept> v_ = a?.ReasonCode;
            List<ResourceReference> w_ = a?.ReasonReference;
            List<CodeableConcept> x_ = a?.BodySite;
            CodeableConcept y_ = a?.Outcome /* CQL: 2382:15-2382:23 */;
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
            arg /* CQL: 2394:3-2394:5 */,
        ];

        Provenance b_(Provenance a) {
            List<ResourceReference> f_ = a?.Target;
            DataType g_ = a?.Occurred;
            Instant h_ = a?.RecordedElement /* CQL: 2398:16-2398:25 */;
            List<FhirUri> i_ = a?.PolicyElement;
            ResourceReference j_ = a?.Location /* CQL: 2400:16-2400:25 */;
            List<CodeableConcept> k_ = a?.Reason;
            CodeableConcept l_ = a?.Activity /* CQL: 2402:16-2402:25 */;
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
            arg /* CQL: 2436:3-2436:5 */,
        ];

        QuestionnaireResponse b_(QuestionnaireResponse a) {
            Identifier f_ = a?.Identifier /* CQL: 2438:18-2438:29 */;
            List<ResourceReference> g_ = a?.BasedOn;
            List<ResourceReference> h_ = a?.PartOf;
            Canonical i_ = a?.QuestionnaireElement /* CQL: 2441:21-2441:35 */;
            Code<QuestionnaireResponse.QuestionnaireResponseStatus> j_ = a?.StatusElement /* CQL: 2442:14-2442:21 */;
            ResourceReference k_ = a?.Subject /* CQL: 2443:15-2443:23 */;
            ResourceReference l_ = a?.Encounter /* CQL: 2444:17-2444:27 */;
            FhirDateTime m_ = a?.AuthoredElement /* CQL: 2445:16-2445:25 */;
            ResourceReference n_ = a?.Author /* CQL: 2446:14-2446:21 */;
            ResourceReference o_ = a?.Source /* CQL: 2447:14-2447:21 */;
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
            arg /* CQL: 2452:3-2452:5 */,
        ];

        RelatedPerson b_(RelatedPerson a) {
            List<Identifier> f_ = a?.Identifier;
            FhirBoolean g_ = a?.ActiveElement /* CQL: 2455:14-2455:21 */;
            ResourceReference h_ = a?.Patient /* CQL: 2456:15-2456:23 */;
            List<CodeableConcept> i_ = a?.Relationship;
            List<HumanName> j_ = a?.Name;
            List<ContactPoint> k_ = a?.Telecom;
            Code<AdministrativeGender> l_ = a?.GenderElement /* CQL: 2460:14-2460:21 */;
            Date m_ = a?.BirthDateElement /* CQL: 2461:17-2461:27 */;
            List<Address> n_ = a?.Address;
            List<Attachment> o_ = a?.Photo;
            Period p_ = a?.Period /* CQL: 2464:14-2464:21 */;
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
            arg /* CQL: 2469:3-2469:5 */,
        ];

        RequestGroup b_(RequestGroup a) {
            List<Identifier> f_ = a?.Identifier;
            List<Canonical> g_ = a?.InstantiatesCanonicalElement;
            List<FhirUri> h_ = a?.InstantiatesUriElement;
            List<ResourceReference> i_ = a?.BasedOn;
            List<ResourceReference> j_ = a?.Replaces;
            Identifier k_ = a?.GroupIdentifier /* CQL: 2476:23-2476:39 */;
            Code<RequestStatus> l_ = a?.StatusElement /* CQL: 2477:14-2477:21 */;
            Code<RequestIntent> m_ = a?.IntentElement /* CQL: 2478:14-2478:21 */;
            Code<RequestPriority> n_ = a?.PriorityElement /* CQL: 2479:16-2479:25 */;
            CodeableConcept o_ = a?.Code /* CQL: 2480:12-2480:17 */;
            ResourceReference p_ = a?.Subject /* CQL: 2481:15-2481:23 */;
            ResourceReference q_ = a?.Encounter /* CQL: 2482:17-2482:27 */;
            FhirDateTime r_ = a?.AuthoredOnElement /* CQL: 2483:18-2483:29 */;
            ResourceReference s_ = a?.Author /* CQL: 2484:14-2484:21 */;
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
            arg /* CQL: 2492:3-2492:5 */,
        ];

        ResearchDefinition b_(ResearchDefinition a) {
            FhirUri f_ = a?.UrlElement /* CQL: 2494:11-2494:15 */;
            List<Identifier> g_ = a?.Identifier;
            FhirString h_ = a?.VersionElement /* CQL: 2496:15-2496:23 */;
            FhirString i_ = a?.NameElement /* CQL: 2497:12-2497:17 */;
            FhirString j_ = a?.TitleElement /* CQL: 2498:13-2498:19 */;
            FhirString k_ = a?.ShortTitleElement /* CQL: 2499:18-2499:29 */;
            FhirString l_ = a?.SubtitleElement /* CQL: 2500:16-2500:25 */;
            Code<PublicationStatus> m_ = a?.StatusElement /* CQL: 2501:14-2501:21 */;
            FhirBoolean n_ = a?.ExperimentalElement /* CQL: 2502:20-2502:33 */;
            DataType o_ = a?.Subject;
            FhirDateTime p_ = a?.DateElement /* CQL: 2504:12-2504:17 */;
            FhirString q_ = a?.PublisherElement /* CQL: 2505:17-2505:27 */;
            List<ContactDetail> r_ = a?.Contact;
            Markdown s_ = a?.DescriptionElement /* CQL: 2507:19-2507:31 */;
            List<FhirString> t_ = a?.CommentElement;
            List<UsageContext> u_ = a?.UseContext;
            List<CodeableConcept> v_ = a?.Jurisdiction;
            Markdown w_ = a?.PurposeElement /* CQL: 2511:15-2511:23 */;
            FhirString x_ = a?.UsageElement /* CQL: 2512:13-2512:19 */;
            Markdown y_ = a?.CopyrightElement /* CQL: 2513:17-2513:27 */;
            Date z_ = a?.ApprovalDateElement /* CQL: 2514:20-2514:33 */;
            Date aa_ = a?.LastReviewDateElement /* CQL: 2515:22-2515:37 */;
            Period ab_ = a?.EffectivePeriod /* CQL: 2516:23-2516:39 */;
            List<CodeableConcept> ac_ = a?.Topic;
            List<ContactDetail> ad_ = a?.Author;
            List<ContactDetail> ae_ = a?.Editor;
            List<ContactDetail> af_ = a?.Reviewer;
            List<ContactDetail> ag_ = a?.Endorser;
            List<RelatedArtifact> ah_ = a?.RelatedArtifact;
            List<Canonical> ai_ = a?.LibraryElement;
            ResourceReference aj_ = a?.Population /* CQL: 2524:18-2524:29 */;
            ResourceReference ak_ = a?.Exposure /* CQL: 2525:16-2525:25 */;
            ResourceReference al_ = a?.ExposureAlternative /* CQL: 2526:27-2526:47 */;
            ResourceReference am_ = a?.Outcome /* CQL: 2527:15-2527:23 */;
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
            arg /* CQL: 2531:3-2531:5 */,
        ];

        ResearchElementDefinition b_(ResearchElementDefinition a) {
            FhirUri f_ = a?.UrlElement /* CQL: 2533:11-2533:15 */;
            List<Identifier> g_ = a?.Identifier;
            FhirString h_ = a?.VersionElement /* CQL: 2535:15-2535:23 */;
            FhirString i_ = a?.NameElement /* CQL: 2536:12-2536:17 */;
            FhirString j_ = a?.TitleElement /* CQL: 2537:13-2537:19 */;
            FhirString k_ = a?.ShortTitleElement /* CQL: 2538:18-2538:29 */;
            FhirString l_ = a?.SubtitleElement /* CQL: 2539:16-2539:25 */;
            Code<PublicationStatus> m_ = a?.StatusElement /* CQL: 2540:14-2540:21 */;
            FhirBoolean n_ = a?.ExperimentalElement /* CQL: 2541:20-2541:33 */;
            DataType o_ = a?.Subject;
            FhirDateTime p_ = a?.DateElement /* CQL: 2543:12-2543:17 */;
            FhirString q_ = a?.PublisherElement /* CQL: 2544:17-2544:27 */;
            List<ContactDetail> r_ = a?.Contact;
            Markdown s_ = a?.DescriptionElement /* CQL: 2546:19-2546:31 */;
            List<FhirString> t_ = a?.CommentElement;
            List<UsageContext> u_ = a?.UseContext;
            List<CodeableConcept> v_ = a?.Jurisdiction;
            Markdown w_ = a?.PurposeElement /* CQL: 2550:15-2550:23 */;
            FhirString x_ = a?.UsageElement /* CQL: 2551:13-2551:19 */;
            Markdown y_ = a?.CopyrightElement /* CQL: 2552:17-2552:27 */;
            Date z_ = a?.ApprovalDateElement /* CQL: 2553:20-2553:33 */;
            Date aa_ = a?.LastReviewDateElement /* CQL: 2554:22-2554:37 */;
            Period ab_ = a?.EffectivePeriod /* CQL: 2555:23-2555:39 */;
            List<CodeableConcept> ac_ = a?.Topic;
            List<ContactDetail> ad_ = a?.Author;
            List<ContactDetail> ae_ = a?.Editor;
            List<ContactDetail> af_ = a?.Reviewer;
            List<ContactDetail> ag_ = a?.Endorser;
            List<RelatedArtifact> ah_ = a?.RelatedArtifact;
            List<Canonical> ai_ = a?.LibraryElement;
            Code<ResearchElementDefinition.ResearchElementType> aj_ = a?.TypeElement /* CQL: 2563:12-2563:17 */;
            Code<VariableTypeCode> ak_ = a?.VariableTypeElement /* CQL: 2564:20-2564:33 */;
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
            arg /* CQL: 2569:3-2569:5 */,
        ];

        ResearchStudy b_(ResearchStudy a) {
            List<Identifier> f_ = a?.Identifier;
            FhirString g_ = a?.TitleElement /* CQL: 2572:13-2572:19 */;
            List<ResourceReference> h_ = a?.Protocol;
            List<ResourceReference> i_ = a?.PartOf;
            Code<ResearchStudy.ResearchStudyStatus> j_ = a?.StatusElement /* CQL: 2575:14-2575:21 */;
            CodeableConcept k_ = a?.PrimaryPurposeType /* CQL: 2576:26-2576:45 */;
            CodeableConcept l_ = a?.Phase /* CQL: 2577:13-2577:19 */;
            List<CodeableConcept> m_ = a?.Category;
            List<CodeableConcept> n_ = a?.Focus;
            List<CodeableConcept> o_ = a?.Condition;
            List<ContactDetail> p_ = a?.Contact;
            List<RelatedArtifact> q_ = a?.RelatedArtifact;
            List<CodeableConcept> r_ = a?.Keyword;
            List<CodeableConcept> s_ = a?.Location;
            Markdown t_ = a?.DescriptionElement /* CQL: 2585:19-2585:31 */;
            List<ResourceReference> u_ = a?.Enrollment;
            Period v_ = a?.Period /* CQL: 2587:14-2587:21 */;
            ResourceReference w_ = a?.Sponsor /* CQL: 2588:15-2588:23 */;
            ResourceReference x_ = a?.PrincipalInvestigator /* CQL: 2589:29-2589:51 */;
            List<ResourceReference> y_ = a?.Site;
            CodeableConcept z_ = a?.ReasonStopped /* CQL: 2591:21-2591:35 */;
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
            arg /* CQL: 2598:3-2598:5 */,
        ];

        ResearchSubject b_(ResearchSubject a) {
            List<Identifier> f_ = a?.Identifier;
            Code<ResearchSubject.ResearchSubjectStatus> g_ = a?.StatusElement /* CQL: 2601:14-2601:21 */;
            Period h_ = a?.Period /* CQL: 2602:14-2602:21 */;
            ResourceReference i_ = a?.Study /* CQL: 2603:13-2603:19 */;
            ResourceReference j_ = a?.Individual /* CQL: 2604:18-2604:29 */;
            FhirString k_ = a?.AssignedArmElement /* CQL: 2605:19-2605:31 */;
            FhirString l_ = a?.ActualArmElement /* CQL: 2606:17-2606:27 */;
            ResourceReference m_ = a?.Consent /* CQL: 2607:15-2607:23 */;
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
            arg /* CQL: 2611:3-2611:5 */,
        ];

        RiskAssessment b_(RiskAssessment a) {
            List<Identifier> f_ = a?.Identifier;
            ResourceReference g_ = a?.BasedOn /* CQL: 2614:15-2614:23 */;
            ResourceReference h_ = a?.Parent /* CQL: 2615:14-2615:21 */;
            Code<ObservationStatus> i_ = a?.StatusElement /* CQL: 2616:14-2616:21 */;
            CodeableConcept j_ = a?.Method /* CQL: 2617:14-2617:21 */;
            CodeableConcept k_ = a?.Code /* CQL: 2618:12-2618:17 */;
            ResourceReference l_ = a?.Subject /* CQL: 2619:15-2619:23 */;
            ResourceReference m_ = a?.Encounter /* CQL: 2620:17-2620:27 */;
            DataType n_ = a?.Occurrence;
            ResourceReference o_ = a?.Condition /* CQL: 2622:17-2622:27 */;
            ResourceReference p_ = a?.Performer /* CQL: 2623:17-2623:27 */;
            List<CodeableConcept> q_ = a?.ReasonCode;
            List<ResourceReference> r_ = a?.ReasonReference;
            List<ResourceReference> s_ = a?.Basis;
            List<RiskAssessment.PredictionComponent> t_ = a?.Prediction;
            FhirString u_ = a?.MitigationElement /* CQL: 2628:18-2628:29 */;
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
            arg /* CQL: 2633:3-2633:5 */,
        ];

        RiskEvidenceSynthesis b_(RiskEvidenceSynthesis a) {
            FhirUri f_ = a?.UrlElement /* CQL: 2635:11-2635:15 */;
            List<Identifier> g_ = a?.Identifier;
            FhirString h_ = a?.VersionElement /* CQL: 2637:15-2637:23 */;
            FhirString i_ = a?.NameElement /* CQL: 2638:12-2638:17 */;
            FhirString j_ = a?.TitleElement /* CQL: 2639:13-2639:19 */;
            Code<PublicationStatus> k_ = a?.StatusElement /* CQL: 2640:14-2640:21 */;
            FhirDateTime l_ = a?.DateElement /* CQL: 2641:12-2641:17 */;
            FhirString m_ = a?.PublisherElement /* CQL: 2642:17-2642:27 */;
            List<ContactDetail> n_ = a?.Contact;
            Markdown o_ = a?.DescriptionElement /* CQL: 2644:19-2644:31 */;
            List<Annotation> p_ = a?.Note;
            List<UsageContext> q_ = a?.UseContext;
            List<CodeableConcept> r_ = a?.Jurisdiction;
            Markdown s_ = a?.CopyrightElement /* CQL: 2648:17-2648:27 */;
            Date t_ = a?.ApprovalDateElement /* CQL: 2649:20-2649:33 */;
            Date u_ = a?.LastReviewDateElement /* CQL: 2650:22-2650:37 */;
            Period v_ = a?.EffectivePeriod /* CQL: 2651:23-2651:39 */;
            List<CodeableConcept> w_ = a?.Topic;
            List<ContactDetail> x_ = a?.Author;
            List<ContactDetail> y_ = a?.Editor;
            List<ContactDetail> z_ = a?.Reviewer;
            List<ContactDetail> aa_ = a?.Endorser;
            List<RelatedArtifact> ab_ = a?.RelatedArtifact;
            CodeableConcept ac_ = a?.SynthesisType /* CQL: 2658:21-2658:35 */;
            CodeableConcept ad_ = a?.StudyType /* CQL: 2659:17-2659:27 */;
            ResourceReference ae_ = a?.Population /* CQL: 2660:18-2660:29 */;
            ResourceReference af_ = a?.Exposure /* CQL: 2661:16-2661:25 */;
            ResourceReference ag_ = a?.Outcome /* CQL: 2662:15-2662:23 */;
            RiskEvidenceSynthesis.SampleSizeComponent ah_ = a?.SampleSize /* CQL: 2663:18-2663:29 */;
            RiskEvidenceSynthesis.RiskEstimateComponent ai_ = a?.RiskEstimate /* CQL: 2664:20-2664:33 */;
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
            arg /* CQL: 2669:3-2669:5 */,
        ];

        Schedule b_(Schedule a) {
            List<Identifier> f_ = a?.Identifier;
            FhirBoolean g_ = a?.ActiveElement /* CQL: 2672:14-2672:21 */;
            List<CodeableConcept> h_ = a?.ServiceCategory;
            List<CodeableConcept> i_ = a?.ServiceType;
            List<CodeableConcept> j_ = a?.Specialty;
            List<ResourceReference> k_ = a?.Actor;
            Period l_ = a?.PlanningHorizon /* CQL: 2677:23-2677:39 */;
            FhirString m_ = a?.CommentElement /* CQL: 2678:15-2678:23 */;
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
            arg /* CQL: 2713:3-2713:5 */,
        ];

        ServiceRequest b_(ServiceRequest a) {
            List<Identifier> f_ = a?.Identifier;
            List<Canonical> g_ = a?.InstantiatesCanonicalElement;
            List<FhirUri> h_ = a?.InstantiatesUriElement;
            List<ResourceReference> i_ = a?.BasedOn;
            List<ResourceReference> j_ = a?.Replaces;
            Identifier k_ = a?.Requisition /* CQL: 2720:19-2720:31 */;
            Code<RequestStatus> l_ = a?.StatusElement /* CQL: 2721:14-2721:21 */;
            Code<RequestIntent> m_ = a?.IntentElement /* CQL: 2722:14-2722:21 */;
            List<CodeableConcept> n_ = a?.Category;
            Code<RequestPriority> o_ = a?.PriorityElement /* CQL: 2724:16-2724:25 */;
            FhirBoolean p_ = a?.DoNotPerformElement /* CQL: 2725:20-2725:33 */;
            CodeableConcept q_ = a?.Code /* CQL: 2726:12-2726:17 */;
            List<CodeableConcept> r_ = a?.OrderDetail;
            DataType s_ = a?.Quantity;
            ResourceReference t_ = a?.Subject /* CQL: 2729:15-2729:23 */;
            ResourceReference u_ = a?.Encounter /* CQL: 2730:17-2730:27 */;
            DataType v_ = a?.Occurrence;
            DataType w_ = a?.AsNeeded;
            FhirDateTime x_ = a?.AuthoredOnElement /* CQL: 2733:18-2733:29 */;
            ResourceReference y_ = a?.Requester /* CQL: 2734:17-2734:27 */;
            CodeableConcept z_ = a?.PerformerType /* CQL: 2735:21-2735:35 */;
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
            FhirString ak_ = a?.PatientInstructionElement /* CQL: 2746:26-2746:45 */;
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
            arg /* CQL: 2751:3-2751:5 */,
        ];

        Slot b_(Slot a) {
            List<Identifier> f_ = a?.Identifier;
            List<CodeableConcept> g_ = a?.ServiceCategory;
            List<CodeableConcept> h_ = a?.ServiceType;
            List<CodeableConcept> i_ = a?.Specialty;
            CodeableConcept j_ = a?.AppointmentType /* CQL: 2757:23-2757:39 */;
            ResourceReference k_ = a?.Schedule /* CQL: 2758:16-2758:25 */;
            Code<Slot.SlotStatus> l_ = a?.StatusElement /* CQL: 2759:14-2759:21 */;
            Instant m_ = a?.StartElement /* CQL: 2760:13-2760:19 */;
            Instant n_ = a?.EndElement /* CQL: 2761:11-2761:15 */;
            FhirBoolean o_ = a?.OverbookedElement /* CQL: 2762:18-2762:29 */;
            FhirString p_ = a?.CommentElement /* CQL: 2763:15-2763:23 */;
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
            arg /* CQL: 2767:3-2767:5 */,
        ];

        Specimen b_(Specimen a) {
            List<Identifier> f_ = a?.Identifier;
            Identifier g_ = a?.AccessionIdentifier /* CQL: 2770:27-2770:47 */;
            Code<Specimen.SpecimenStatus> h_ = a?.StatusElement /* CQL: 2771:14-2771:21 */;
            CodeableConcept i_ = a?.Type /* CQL: 2772:12-2772:17 */;
            ResourceReference j_ = a?.Subject /* CQL: 2773:15-2773:23 */;
            FhirDateTime k_ = a?.ReceivedTimeElement /* CQL: 2774:20-2774:33 */;
            List<ResourceReference> l_ = a?.Parent;
            List<ResourceReference> m_ = a?.Request;
            Specimen.CollectionComponent n_ = a?.Collection /* CQL: 2777:18-2777:29 */;
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
            arg /* CQL: 2785:3-2785:5 */,
        ];

        SpecimenDefinition b_(SpecimenDefinition a) {
            Identifier f_ = a?.Identifier /* CQL: 2787:18-2787:29 */;
            CodeableConcept g_ = a?.TypeCollected /* CQL: 2788:21-2788:35 */;
            List<CodeableConcept> h_ = a?.PatientPreparation;
            FhirString i_ = a?.TimeAspectElement /* CQL: 2790:18-2790:29 */;
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
            arg /* CQL: 2796:3-2796:5 */,
        ];

        StructureDefinition b_(StructureDefinition a) {
            FhirUri f_ = a?.UrlElement /* CQL: 2798:11-2798:15 */;
            List<Identifier> g_ = a?.Identifier;
            FhirString h_ = a?.VersionElement /* CQL: 2800:15-2800:23 */;
            FhirString i_ = a?.NameElement /* CQL: 2801:12-2801:17 */;
            FhirString j_ = a?.TitleElement /* CQL: 2802:13-2802:19 */;
            Code<PublicationStatus> k_ = a?.StatusElement /* CQL: 2803:14-2803:21 */;
            FhirBoolean l_ = a?.ExperimentalElement /* CQL: 2804:20-2804:33 */;
            FhirDateTime m_ = a?.DateElement /* CQL: 2805:12-2805:17 */;
            FhirString n_ = a?.PublisherElement /* CQL: 2806:17-2806:27 */;
            List<ContactDetail> o_ = a?.Contact;
            Markdown p_ = a?.DescriptionElement /* CQL: 2808:19-2808:31 */;
            List<UsageContext> q_ = a?.UseContext;
            List<CodeableConcept> r_ = a?.Jurisdiction;
            Markdown s_ = a?.PurposeElement /* CQL: 2811:15-2811:23 */;
            Markdown t_ = a?.CopyrightElement /* CQL: 2812:17-2812:27 */;
            List<Coding> u_ = a?.Keyword;
            Code<FHIRVersion> v_ = a?.FhirVersionElement /* CQL: 2814:19-2814:31 */;
            List<StructureDefinition.MappingComponent> w_ = a?.Mapping;
            Code<StructureDefinition.StructureDefinitionKind> x_ = a?.KindElement /* CQL: 2816:12-2816:17 */;
            FhirBoolean y_ = a?.AbstractElement /* CQL: 2817:16-2817:25 */;
            List<StructureDefinition.ContextComponent> z_ = a?.Context;
            List<FhirString> aa_ = a?.ContextInvariantElement;
            FhirUri ab_ = a?.TypeElement /* CQL: 2820:12-2820:17 */;
            Canonical ac_ = a?.BaseDefinitionElement /* CQL: 2821:22-2821:37 */;
            Code<StructureDefinition.TypeDerivationRule> ad_ = a?.DerivationElement /* CQL: 2822:18-2822:29 */;
            StructureDefinition.SnapshotComponent ae_ = a?.Snapshot /* CQL: 2823:16-2823:25 */;
            StructureDefinition.DifferentialComponent af_ = a?.Differential /* CQL: 2824:20-2824:33 */;
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
            arg /* CQL: 2828:3-2828:5 */,
        ];

        StructureMap b_(StructureMap a) {
            FhirUri f_ = a?.UrlElement /* CQL: 2830:11-2830:15 */;
            List<Identifier> g_ = a?.Identifier;
            FhirString h_ = a?.VersionElement /* CQL: 2832:15-2832:23 */;
            FhirString i_ = a?.NameElement /* CQL: 2833:12-2833:17 */;
            FhirString j_ = a?.TitleElement /* CQL: 2834:13-2834:19 */;
            Code<PublicationStatus> k_ = a?.StatusElement /* CQL: 2835:14-2835:21 */;
            FhirBoolean l_ = a?.ExperimentalElement /* CQL: 2836:20-2836:33 */;
            FhirDateTime m_ = a?.DateElement /* CQL: 2837:12-2837:17 */;
            FhirString n_ = a?.PublisherElement /* CQL: 2838:17-2838:27 */;
            List<ContactDetail> o_ = a?.Contact;
            Markdown p_ = a?.DescriptionElement /* CQL: 2840:19-2840:31 */;
            List<UsageContext> q_ = a?.UseContext;
            List<CodeableConcept> r_ = a?.Jurisdiction;
            Markdown s_ = a?.PurposeElement /* CQL: 2843:15-2843:23 */;
            Markdown t_ = a?.CopyrightElement /* CQL: 2844:17-2844:27 */;
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
            arg /* CQL: 2851:3-2851:5 */,
        ];

        Subscription b_(Subscription a) {
            Code<Subscription.SubscriptionStatus> f_ = a?.StatusElement /* CQL: 2853:14-2853:21 */;
            List<ContactPoint> g_ = a?.Contact;
            Instant h_ = a?.EndElement /* CQL: 2855:11-2855:15 */;
            FhirString i_ = a?.ReasonElement /* CQL: 2856:14-2856:21 */;
            FhirString j_ = a?.CriteriaElement /* CQL: 2857:16-2857:25 */;
            FhirString k_ = a?.ErrorElement /* CQL: 2858:13-2858:19 */;
            Subscription.ChannelComponent l_ = a?.Channel /* CQL: 2859:15-2859:23 */;
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
            arg /* CQL: 2863:3-2863:5 */,
        ];

        Substance b_(Substance a) {
            List<Identifier> f_ = a?.Identifier;
            Code<Substance.FHIRSubstanceStatus> g_ = a?.StatusElement /* CQL: 2866:14-2866:21 */;
            List<CodeableConcept> h_ = a?.Category;
            CodeableConcept i_ = a?.Code /* CQL: 2868:12-2868:17 */;
            FhirString j_ = a?.DescriptionElement /* CQL: 2869:19-2869:31 */;
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
            arg /* CQL: 2875:3-2875:5 */,
        ];

        SubstanceNucleicAcid b_(SubstanceNucleicAcid a) {
            CodeableConcept f_ = a?.SequenceType /* CQL: 2877:20-2877:33 */;
            Integer g_ = a?.NumberOfSubunitsElement /* CQL: 2878:24-2878:41 */;
            FhirString h_ = a?.AreaOfHybridisationElement /* CQL: 2879:27-2879:47 */;
            CodeableConcept i_ = a?.OligoNucleotideType /* CQL: 2880:27-2880:47 */;
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
            arg /* CQL: 2885:3-2885:5 */,
        ];

        SubstancePolymer b_(SubstancePolymer a) {
            CodeableConcept f_ = a?.Class /* CQL: 2887:13-2887:19 */;
            CodeableConcept g_ = a?.Geometry /* CQL: 2888:16-2888:25 */;
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
            arg /* CQL: 2896:3-2896:5 */,
        ];

        SubstanceProtein b_(SubstanceProtein a) {
            CodeableConcept f_ = a?.SequenceType /* CQL: 2898:20-2898:33 */;
            Integer g_ = a?.NumberOfSubunitsElement /* CQL: 2899:24-2899:41 */;
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
            arg /* CQL: 2905:3-2905:5 */,
        ];

        SubstanceReferenceInformation b_(SubstanceReferenceInformation a) {
            FhirString f_ = a?.CommentElement /* CQL: 2907:15-2907:23 */;
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
            arg /* CQL: 2915:3-2915:5 */,
        ];

        SubstanceSourceMaterial b_(SubstanceSourceMaterial a) {
            CodeableConcept f_ = a?.SourceMaterialClass /* CQL: 2917:27-2917:47 */;
            CodeableConcept g_ = a?.SourceMaterialType /* CQL: 2918:26-2918:45 */;
            CodeableConcept h_ = a?.SourceMaterialState /* CQL: 2919:27-2919:47 */;
            Identifier i_ = a?.OrganismId /* CQL: 2920:18-2920:29 */;
            FhirString j_ = a?.OrganismNameElement /* CQL: 2921:20-2921:33 */;
            List<Identifier> k_ = a?.ParentSubstanceId;
            List<FhirString> l_ = a?.ParentSubstanceNameElement;
            List<CodeableConcept> m_ = a?.CountryOfOrigin;
            List<FhirString> n_ = a?.GeographicalLocationElement;
            CodeableConcept o_ = a?.DevelopmentStage /* CQL: 2926:24-2926:41 */;
            List<SubstanceSourceMaterial.FractionDescriptionComponent> p_ = a?.FractionDescription;
            SubstanceSourceMaterial.OrganismComponent q_ = a?.Organism /* CQL: 2928:16-2928:25 */;
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
            arg /* CQL: 2933:3-2933:5 */,
        ];

        SubstanceSpecification b_(SubstanceSpecification a) {
            Identifier f_ = a?.Identifier /* CQL: 2935:18-2935:29 */;
            CodeableConcept g_ = a?.Type /* CQL: 2936:12-2936:17 */;
            CodeableConcept h_ = a?.Status /* CQL: 2937:14-2937:21 */;
            CodeableConcept i_ = a?.Domain /* CQL: 2938:14-2938:21 */;
            FhirString j_ = a?.DescriptionElement /* CQL: 2939:19-2939:31 */;
            List<ResourceReference> k_ = a?.Source;
            FhirString l_ = a?.CommentElement /* CQL: 2941:15-2941:23 */;
            List<SubstanceSpecification.MoietyComponent> m_ = a?.Moiety;
            List<SubstanceSpecification.PropertyComponent> n_ = a?.Property;
            ResourceReference o_ = a?.ReferenceInformation /* CQL: 2944:28-2944:49 */;
            SubstanceSpecification.StructureComponent p_ = a?.Structure /* CQL: 2945:17-2945:27 */;
            List<SubstanceSpecification.CodeComponent> q_ = a?.Code;
            List<SubstanceSpecification.NameComponent> r_ = a?.Name;
            List<SubstanceSpecification.MolecularWeightComponent> s_ = a?.MolecularWeight;
            List<SubstanceSpecification.RelationshipComponent> t_ = a?.Relationship;
            ResourceReference u_ = a?.NucleicAcid /* CQL: 2950:19-2950:31 */;
            ResourceReference v_ = a?.Polymer /* CQL: 2951:15-2951:23 */;
            ResourceReference w_ = a?.Protein /* CQL: 2952:15-2952:23 */;
            ResourceReference x_ = a?.SourceMaterial /* CQL: 2953:22-2953:37 */;
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
            arg /* CQL: 2957:3-2957:5 */,
        ];

        SupplyDelivery b_(SupplyDelivery a) {
            List<Identifier> f_ = a?.Identifier;
            List<ResourceReference> g_ = a?.BasedOn;
            List<ResourceReference> h_ = a?.PartOf;
            Code<SupplyDelivery.SupplyDeliveryStatus> i_ = a?.StatusElement /* CQL: 2962:14-2962:21 */;
            ResourceReference j_ = a?.Patient /* CQL: 2963:15-2963:23 */;
            CodeableConcept k_ = a?.Type /* CQL: 2964:12-2964:17 */;
            SupplyDelivery.SuppliedItemComponent l_ = a?.SuppliedItem /* CQL: 2965:20-2965:33 */;
            DataType m_ = a?.Occurrence;
            ResourceReference n_ = a?.Supplier /* CQL: 2967:16-2967:25 */;
            ResourceReference o_ = a?.Destination /* CQL: 2968:19-2968:31 */;
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
            arg /* CQL: 2973:3-2973:5 */,
        ];

        SupplyRequest b_(SupplyRequest a) {
            List<Identifier> f_ = a?.Identifier;
            Code<SupplyRequest.SupplyRequestStatus> g_ = a?.StatusElement /* CQL: 2976:14-2976:21 */;
            CodeableConcept h_ = a?.Category /* CQL: 2977:16-2977:25 */;
            Code<RequestPriority> i_ = a?.PriorityElement /* CQL: 2978:16-2978:25 */;
            DataType j_ = a?.Item;
            Quantity k_ = a?.Quantity /* CQL: 2980:16-2980:25 */;
            List<SupplyRequest.ParameterComponent> l_ = a?.Parameter;
            DataType m_ = a?.Occurrence;
            FhirDateTime n_ = a?.AuthoredOnElement /* CQL: 2983:18-2983:29 */;
            ResourceReference o_ = a?.Requester /* CQL: 2984:17-2984:27 */;
            List<ResourceReference> p_ = a?.Supplier;
            List<CodeableConcept> q_ = a?.ReasonCode;
            List<ResourceReference> r_ = a?.ReasonReference;
            ResourceReference s_ = a?.DeliverFrom /* CQL: 2988:19-2988:31 */;
            ResourceReference t_ = a?.DeliverTo /* CQL: 2989:17-2989:27 */;
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
            arg /* CQL: 2993:3-2993:5 */,
        ];

        Task b_(Task a) {
            List<Identifier> f_ = a?.Identifier;
            Canonical g_ = a?.InstantiatesCanonicalElement /* CQL: 2996:29-2996:51 */;
            FhirUri h_ = a?.InstantiatesUriElement /* CQL: 2997:23-2997:39 */;
            List<ResourceReference> i_ = a?.BasedOn;
            Identifier j_ = a?.GroupIdentifier /* CQL: 2999:23-2999:39 */;
            List<ResourceReference> k_ = a?.PartOf;
            Code<Task.TaskStatus> l_ = a?.StatusElement /* CQL: 3001:14-3001:21 */;
            CodeableConcept m_ = a?.StatusReason /* CQL: 3002:20-3002:33 */;
            CodeableConcept n_ = a?.BusinessStatus /* CQL: 3003:22-3003:37 */;
            Code<Task.TaskIntent> o_ = a?.IntentElement /* CQL: 3004:14-3004:21 */;
            Code<RequestPriority> p_ = a?.PriorityElement /* CQL: 3005:16-3005:25 */;
            CodeableConcept q_ = a?.Code /* CQL: 3006:12-3006:17 */;
            FhirString r_ = a?.DescriptionElement /* CQL: 3007:19-3007:31 */;
            ResourceReference s_ = a?.Focus /* CQL: 3008:13-3008:19 */;
            ResourceReference t_ = a?.For /* CQL: 3009:11-3009:15 */;
            ResourceReference u_ = a?.Encounter /* CQL: 3010:17-3010:27 */;
            Period v_ = a?.ExecutionPeriod /* CQL: 3011:23-3011:39 */;
            FhirDateTime w_ = a?.AuthoredOnElement /* CQL: 3012:18-3012:29 */;
            FhirDateTime x_ = a?.LastModifiedElement /* CQL: 3013:20-3013:33 */;
            ResourceReference y_ = a?.Requester /* CQL: 3014:17-3014:27 */;
            List<CodeableConcept> z_ = a?.PerformerType;
            ResourceReference aa_ = a?.Owner /* CQL: 3016:13-3016:19 */;
            ResourceReference ab_ = a?.Location /* CQL: 3017:16-3017:25 */;
            CodeableConcept ac_ = a?.ReasonCode /* CQL: 3018:18-3018:29 */;
            ResourceReference ad_ = a?.ReasonReference /* CQL: 3019:23-3019:39 */;
            List<ResourceReference> ae_ = a?.Insurance;
            List<Annotation> af_ = a?.Note;
            List<ResourceReference> ag_ = a?.RelevantHistory;
            Task.RestrictionComponent ah_ = a?.Restriction /* CQL: 3023:19-3023:31 */;
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
            arg /* CQL: 3029:3-3029:5 */,
        ];

        TerminologyCapabilities b_(TerminologyCapabilities a) {
            FhirUri f_ = a?.UrlElement /* CQL: 3031:11-3031:15 */;
            FhirString g_ = a?.VersionElement /* CQL: 3032:15-3032:23 */;
            FhirString h_ = a?.NameElement /* CQL: 3033:12-3033:17 */;
            FhirString i_ = a?.TitleElement /* CQL: 3034:13-3034:19 */;
            Code<PublicationStatus> j_ = a?.StatusElement /* CQL: 3035:14-3035:21 */;
            FhirBoolean k_ = a?.ExperimentalElement /* CQL: 3036:20-3036:33 */;
            FhirDateTime l_ = a?.DateElement /* CQL: 3037:12-3037:17 */;
            FhirString m_ = a?.PublisherElement /* CQL: 3038:17-3038:27 */;
            List<ContactDetail> n_ = a?.Contact;
            Markdown o_ = a?.DescriptionElement /* CQL: 3040:19-3040:31 */;
            List<UsageContext> p_ = a?.UseContext;
            List<CodeableConcept> q_ = a?.Jurisdiction;
            Markdown r_ = a?.PurposeElement /* CQL: 3043:15-3043:23 */;
            Markdown s_ = a?.CopyrightElement /* CQL: 3044:17-3044:27 */;
            Code<CapabilityStatementKind> t_ = a?.KindElement /* CQL: 3045:12-3045:17 */;
            TerminologyCapabilities.SoftwareComponent u_ = a?.Software /* CQL: 3046:16-3046:25 */;
            TerminologyCapabilities.ImplementationComponent v_ = a?.Implementation /* CQL: 3047:22-3047:37 */;
            FhirBoolean w_ = a?.LockedDateElement /* CQL: 3048:18-3048:29 */;
            List<TerminologyCapabilities.CodeSystemComponent> x_ = a?.CodeSystem;
            TerminologyCapabilities.ExpansionComponent y_ = a?.Expansion /* CQL: 3050:17-3050:27 */;
            Code<TerminologyCapabilities.CodeSearchSupport> z_ = a?.CodeSearchElement /* CQL: 3051:18-3051:29 */;
            TerminologyCapabilities.ValidateCodeComponent aa_ = a?.ValidateCode /* CQL: 3052:20-3052:33 */;
            TerminologyCapabilities.TranslationComponent ab_ = a?.Translation /* CQL: 3053:19-3053:31 */;
            TerminologyCapabilities.ClosureComponent ac_ = a?.Closure /* CQL: 3054:15-3054:23 */;
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
            arg /* CQL: 3058:3-3058:5 */,
        ];

        TestReport b_(TestReport a) {
            Identifier f_ = a?.Identifier /* CQL: 3060:18-3060:29 */;
            FhirString g_ = a?.NameElement /* CQL: 3061:12-3061:17 */;
            Code<TestReport.TestReportStatus> h_ = a?.StatusElement /* CQL: 3062:14-3062:21 */;
            ResourceReference i_ = a?.TestScript /* CQL: 3063:18-3063:29 */;
            Code<TestReport.TestReportResult> j_ = a?.ResultElement /* CQL: 3064:14-3064:21 */;
            FhirDecimal k_ = a?.ScoreElement /* CQL: 3065:13-3065:19 */;
            FhirString l_ = a?.TesterElement /* CQL: 3066:14-3066:21 */;
            FhirDateTime m_ = a?.IssuedElement /* CQL: 3067:14-3067:21 */;
            List<TestReport.ParticipantComponent> n_ = a?.Participant;
            TestReport.SetupComponent o_ = a?.Setup /* CQL: 3069:13-3069:19 */;
            List<TestReport.TestComponent> p_ = a?.Test;
            TestReport.TeardownComponent q_ = a?.Teardown /* CQL: 3071:16-3071:25 */;
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
            arg /* CQL: 3075:3-3075:5 */,
        ];

        TestScript b_(TestScript a) {
            FhirUri f_ = a?.UrlElement /* CQL: 3077:11-3077:15 */;
            Identifier g_ = a?.Identifier /* CQL: 3078:18-3078:29 */;
            FhirString h_ = a?.VersionElement /* CQL: 3079:15-3079:23 */;
            FhirString i_ = a?.NameElement /* CQL: 3080:12-3080:17 */;
            FhirString j_ = a?.TitleElement /* CQL: 3081:13-3081:19 */;
            Code<PublicationStatus> k_ = a?.StatusElement /* CQL: 3082:14-3082:21 */;
            FhirBoolean l_ = a?.ExperimentalElement /* CQL: 3083:20-3083:33 */;
            FhirDateTime m_ = a?.DateElement /* CQL: 3084:12-3084:17 */;
            FhirString n_ = a?.PublisherElement /* CQL: 3085:17-3085:27 */;
            List<ContactDetail> o_ = a?.Contact;
            Markdown p_ = a?.DescriptionElement /* CQL: 3087:19-3087:31 */;
            List<UsageContext> q_ = a?.UseContext;
            List<CodeableConcept> r_ = a?.Jurisdiction;
            Markdown s_ = a?.PurposeElement /* CQL: 3090:15-3090:23 */;
            Markdown t_ = a?.CopyrightElement /* CQL: 3091:17-3091:27 */;
            List<TestScript.OriginComponent> u_ = a?.Origin;
            List<TestScript.DestinationComponent> v_ = a?.Destination;
            TestScript.MetadataComponent w_ = a?.Metadata /* CQL: 3094:16-3094:25 */;
            List<TestScript.FixtureComponent> x_ = a?.Fixture;
            List<ResourceReference> y_ = a?.Profile;
            List<TestScript.VariableComponent> z_ = a?.Variable;
            TestScript.SetupComponent aa_ = a?.Setup /* CQL: 3098:13-3098:19 */;
            List<TestScript.TestComponent> ab_ = a?.Test;
            TestScript.TeardownComponent ac_ = a?.Teardown /* CQL: 3100:16-3100:25 */;
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
            arg /* CQL: 3104:3-3104:5 */,
        ];

        ValueSet b_(ValueSet a) {
            FhirUri f_ = a?.UrlElement /* CQL: 3106:11-3106:15 */;
            List<Identifier> g_ = a?.Identifier;
            FhirString h_ = a?.VersionElement /* CQL: 3108:15-3108:23 */;
            FhirString i_ = a?.NameElement /* CQL: 3109:12-3109:17 */;
            FhirString j_ = a?.TitleElement /* CQL: 3110:13-3110:19 */;
            Code<PublicationStatus> k_ = a?.StatusElement /* CQL: 3111:14-3111:21 */;
            FhirBoolean l_ = a?.ExperimentalElement /* CQL: 3112:20-3112:33 */;
            FhirDateTime m_ = a?.DateElement /* CQL: 3113:12-3113:17 */;
            FhirString n_ = a?.PublisherElement /* CQL: 3114:17-3114:27 */;
            List<ContactDetail> o_ = a?.Contact;
            Markdown p_ = a?.DescriptionElement /* CQL: 3116:19-3116:31 */;
            List<UsageContext> q_ = a?.UseContext;
            List<CodeableConcept> r_ = a?.Jurisdiction;
            FhirBoolean s_ = a?.ImmutableElement /* CQL: 3119:17-3119:27 */;
            Markdown t_ = a?.PurposeElement /* CQL: 3120:15-3120:23 */;
            Markdown u_ = a?.CopyrightElement /* CQL: 3121:17-3121:27 */;
            ValueSet.ComposeComponent v_ = a?.Compose /* CQL: 3122:15-3122:23 */;
            ValueSet.ExpansionComponent w_ = a?.Expansion /* CQL: 3123:17-3123:27 */;
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
            arg /* CQL: 3127:3-3127:5 */,
        ];

        VerificationResult b_(VerificationResult a) {
            List<ResourceReference> f_ = a?.Target;
            List<FhirString> g_ = a?.TargetLocationElement;
            CodeableConcept h_ = a?.Need /* CQL: 3131:12-3131:17 */;
            Code<VerificationResult.StatusCode> i_ = a?.StatusElement /* CQL: 3132:14-3132:21 */;
            FhirDateTime j_ = a?.StatusDateElement /* CQL: 3133:18-3133:29 */;
            CodeableConcept k_ = a?.ValidationType /* CQL: 3134:22-3134:37 */;
            List<CodeableConcept> l_ = a?.ValidationProcess;
            Timing m_ = a?.Frequency /* CQL: 3136:17-3136:27 */;
            FhirDateTime n_ = a?.LastPerformedElement /* CQL: 3137:21-3137:35 */;
            Date o_ = a?.NextScheduledElement /* CQL: 3138:21-3138:35 */;
            CodeableConcept p_ = a?.FailureAction /* CQL: 3139:21-3139:35 */;
            List<VerificationResult.PrimarySourceComponent> q_ = a?.PrimarySource;
            VerificationResult.AttestationComponent r_ = a?.Attestation /* CQL: 3141:19-3141:31 */;
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
            arg /* CQL: 3146:3-3146:5 */,
        ];

        VisionPrescription b_(VisionPrescription a) {
            List<Identifier> f_ = a?.Identifier;
            Code<FinancialResourceStatusCodes> g_ = a?.StatusElement /* CQL: 3149:14-3149:21 */;
            FhirDateTime h_ = a?.CreatedElement /* CQL: 3150:15-3150:23 */;
            ResourceReference i_ = a?.Patient /* CQL: 3151:15-3151:23 */;
            ResourceReference j_ = a?.Encounter /* CQL: 3152:17-3152:27 */;
            FhirDateTime k_ = a?.DateWrittenElement /* CQL: 3153:19-3153:31 */;
            ResourceReference l_ = a?.Prescriber /* CQL: 3154:18-3154:29 */;
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

    #region Nested Type - Cached<T>

    private struct Cached<T>(long CacheVersion, T CachedValue)
    {
        public T GetOrReplace(ICqlContextInternals cqlContext, Func<T> factory)
        {
            var cqlContextCacheVersion = cqlContext.CacheVersion;
            if (cqlContextCacheVersion is 0)
            {
                // No caching, clear out previous values
                CacheVersion = 0;
                CachedValue = default;
                var value = factory();
                return value;
            }

            if (CacheVersion == cqlContextCacheVersion)
            {
                // Cache hit
                return CachedValue;
            }
            else
            {
                // Cache miss, refresh and store
                var value = factory();
                CachedValue = value;
                CacheVersion = cqlContextCacheVersion;
                return value;
            }
        }
    }

    #endregion

}

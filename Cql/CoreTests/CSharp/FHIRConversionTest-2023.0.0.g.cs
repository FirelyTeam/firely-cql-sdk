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

[System.CodeDom.Compiler.GeneratedCode(".NET Code Generation", "3.0.0.0")]
[CqlLibrary("FHIRConversionTest", "2023.0.0")]
public partial class FHIRConversionTest_2023_0_0 : ILibrary, ISingleton<FHIRConversionTest_2023_0_0>
{
    private FHIRConversionTest_2023_0_0() {}

    public static FHIRConversionTest_2023_0_0 Instance { get; } = new();

    #region ILibrary Implementation

    public string Name => "FHIRConversionTest";
    public string Version => "2023.0.0";
    public ILibrary[] Dependencies => [FHIRHelpers_4_0_1.Instance];

    #endregion ILibrary Implementation

    #region Expressions

    // NOT A DEFINITION CqlExpressionDefinition//
    public Account AccountResource(CqlContext context, Account arg)
    {
        Account[] vj_ = [
            arg,
        ];
        Account vk_(Account a)
        {
            List<Identifier> vo_ = a?.Identifier;
            Code<Account.AccountStatus> vp_ = a?.StatusElement;
            CodeableConcept vq_ = a?.Type;
            FhirString vr_ = a?.NameElement;
            List<ResourceReference> vs_ = a?.Subject;
            Period vt_ = a?.ServicePeriod;
            List<Account.CoverageComponent> vu_ = a?.Coverage;
            ResourceReference vv_ = a?.Owner;
            FhirString vw_ = a?.DescriptionElement;
            List<Account.GuarantorComponent> vx_ = a?.Guarantor;
            ResourceReference vy_ = a?.PartOf;
            Account vz_ = new Account
            {
                Identifier = new List<Identifier>((IEnumerable<Identifier>)vo_),
                StatusElement = vp_,
                Type = vq_,
                NameElement = vr_,
                Subject = new List<ResourceReference>((IEnumerable<ResourceReference>)vs_),
                ServicePeriod = vt_,
                Coverage = new List<Account.CoverageComponent>((IEnumerable<Account.CoverageComponent>)vu_),
                Owner = vv_,
                DescriptionElement = vw_,
                Guarantor = new List<Account.GuarantorComponent>((IEnumerable<Account.GuarantorComponent>)vx_),
                PartOf = vy_,
            };

            return vz_;
        };
        IEnumerable<Account> vl_ = context.Operators.Select<Account, Account>((IEnumerable<Account>)vj_, vk_);
        IEnumerable<Account> vm_ = context.Operators.Distinct<Account>(vl_);
        Account vn_ = context.Operators.SingletonFrom<Account>(vm_);

        return vn_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public ActivityDefinition ActivityDefinitionResource(CqlContext context, ActivityDefinition arg)
    {
        ActivityDefinition[] wa_ = [
            arg,
        ];
        ActivityDefinition wb_(ActivityDefinition a)
        {
            FhirUri wf_ = a?.UrlElement;
            List<Identifier> wg_ = a?.Identifier;
            FhirString wh_ = a?.VersionElement;
            FhirString wi_ = a?.NameElement;
            FhirString wj_ = a?.TitleElement;
            FhirString wk_ = a?.SubtitleElement;
            Code<PublicationStatus> wl_ = a?.StatusElement;
            FhirBoolean wm_ = a?.ExperimentalElement;
            DataType wn_ = a?.Subject;
            FhirDateTime wo_ = a?.DateElement;
            FhirString wp_ = a?.PublisherElement;
            List<ContactDetail> wq_ = a?.Contact;
            Markdown wr_ = a?.DescriptionElement;
            List<UsageContext> ws_ = a?.UseContext;
            List<CodeableConcept> wt_ = a?.Jurisdiction;
            Markdown wu_ = a?.PurposeElement;
            FhirString wv_ = a?.UsageElement;
            Markdown ww_ = a?.CopyrightElement;
            Date wx_ = a?.ApprovalDateElement;
            Date wy_ = a?.LastReviewDateElement;
            Period wz_ = a?.EffectivePeriod;
            List<CodeableConcept> xa_ = a?.Topic;
            List<ContactDetail> xb_ = a?.Author;
            List<ContactDetail> xc_ = a?.Editor;
            List<ContactDetail> xd_ = a?.Reviewer;
            List<ContactDetail> xe_ = a?.Endorser;
            List<RelatedArtifact> xf_ = a?.RelatedArtifact;
            List<Canonical> xg_ = a?.LibraryElement;
            Code<ActivityDefinition.RequestResourceType> xh_ = a?.KindElement;
            Canonical xi_ = a?.ProfileElement;
            CodeableConcept xj_ = a?.Code;
            Code<RequestIntent> xk_ = a?.IntentElement;
            Code<RequestPriority> xl_ = a?.PriorityElement;
            FhirBoolean xm_ = a?.DoNotPerformElement;
            DataType xn_ = a?.Timing;
            ResourceReference xo_ = a?.Location;
            List<ActivityDefinition.ParticipantComponent> xp_ = a?.Participant;
            DataType xq_ = a?.Product;
            Quantity xr_ = a?.Quantity;
            List<Dosage> xs_ = a?.Dosage;
            List<CodeableConcept> xt_ = a?.BodySite;
            List<ResourceReference> xu_ = a?.SpecimenRequirement;
            List<ResourceReference> xv_ = a?.ObservationRequirement;
            List<ResourceReference> xw_ = a?.ObservationResultRequirement;
            Canonical xx_ = a?.TransformElement;
            List<ActivityDefinition.DynamicValueComponent> xy_ = a?.DynamicValue;
            ActivityDefinition xz_ = new ActivityDefinition
            {
                UrlElement = wf_,
                Identifier = new List<Identifier>((IEnumerable<Identifier>)wg_),
                VersionElement = wh_,
                NameElement = wi_,
                TitleElement = wj_,
                SubtitleElement = wk_,
                StatusElement = wl_,
                ExperimentalElement = wm_,
                Subject = (DataType)wn_,
                DateElement = wo_,
                PublisherElement = wp_,
                Contact = new List<ContactDetail>((IEnumerable<ContactDetail>)wq_),
                DescriptionElement = wr_,
                UseContext = new List<UsageContext>((IEnumerable<UsageContext>)ws_),
                Jurisdiction = new List<CodeableConcept>((IEnumerable<CodeableConcept>)wt_),
                PurposeElement = wu_,
                UsageElement = wv_,
                CopyrightElement = ww_,
                ApprovalDateElement = wx_,
                LastReviewDateElement = wy_,
                EffectivePeriod = wz_,
                Topic = new List<CodeableConcept>((IEnumerable<CodeableConcept>)xa_),
                Author = new List<ContactDetail>((IEnumerable<ContactDetail>)xb_),
                Editor = new List<ContactDetail>((IEnumerable<ContactDetail>)xc_),
                Reviewer = new List<ContactDetail>((IEnumerable<ContactDetail>)xd_),
                Endorser = new List<ContactDetail>((IEnumerable<ContactDetail>)xe_),
                RelatedArtifact = new List<RelatedArtifact>((IEnumerable<RelatedArtifact>)xf_),
                LibraryElement = new List<Canonical>((IEnumerable<Canonical>)xg_),
                KindElement = xh_,
                ProfileElement = xi_,
                Code = xj_,
                IntentElement = xk_,
                PriorityElement = xl_,
                DoNotPerformElement = xm_,
                Timing = (DataType)xn_,
                Location = xo_,
                Participant = new List<ActivityDefinition.ParticipantComponent>((IEnumerable<ActivityDefinition.ParticipantComponent>)xp_),
                Product = (DataType)xq_,
                Quantity = xr_,
                Dosage = new List<Dosage>((IEnumerable<Dosage>)xs_),
                BodySite = new List<CodeableConcept>((IEnumerable<CodeableConcept>)xt_),
                SpecimenRequirement = new List<ResourceReference>((IEnumerable<ResourceReference>)xu_),
                ObservationRequirement = new List<ResourceReference>((IEnumerable<ResourceReference>)xv_),
                ObservationResultRequirement = new List<ResourceReference>((IEnumerable<ResourceReference>)xw_),
                TransformElement = xx_,
                DynamicValue = new List<ActivityDefinition.DynamicValueComponent>((IEnumerable<ActivityDefinition.DynamicValueComponent>)xy_),
            };

            return xz_;
        };
        IEnumerable<ActivityDefinition> wc_ = context.Operators.Select<ActivityDefinition, ActivityDefinition>((IEnumerable<ActivityDefinition>)wa_, wb_);
        IEnumerable<ActivityDefinition> wd_ = context.Operators.Distinct<ActivityDefinition>(wc_);
        ActivityDefinition we_ = context.Operators.SingletonFrom<ActivityDefinition>(wd_);

        return we_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public AdverseEvent AdverseEventResource(CqlContext context, AdverseEvent arg)
    {
        AdverseEvent[] ya_ = [
            arg,
        ];
        AdverseEvent yb_(AdverseEvent a)
        {
            Identifier yf_ = a?.Identifier;
            Code<AdverseEvent.AdverseEventActuality> yg_ = a?.ActualityElement;
            List<CodeableConcept> yh_ = a?.Category;
            CodeableConcept yi_ = a?.Event;
            ResourceReference yj_ = a?.Subject;
            ResourceReference yk_ = a?.Encounter;
            FhirDateTime yl_ = a?.DateElement;
            FhirDateTime ym_ = a?.DetectedElement;
            FhirDateTime yn_ = a?.RecordedDateElement;
            List<ResourceReference> yo_ = a?.ResultingCondition;
            ResourceReference yp_ = a?.Location;
            CodeableConcept yq_ = a?.Seriousness;
            CodeableConcept yr_ = a?.Severity;
            CodeableConcept ys_ = a?.Outcome;
            ResourceReference yt_ = a?.Recorder;
            List<ResourceReference> yu_ = a?.Contributor;
            List<AdverseEvent.SuspectEntityComponent> yv_ = a?.SuspectEntity;
            List<ResourceReference> yw_ = a?.SubjectMedicalHistory;
            List<ResourceReference> yx_ = a?.ReferenceDocument;
            List<ResourceReference> yy_ = a?.Study;
            AdverseEvent yz_ = new AdverseEvent
            {
                Identifier = yf_,
                ActualityElement = yg_,
                Category = new List<CodeableConcept>((IEnumerable<CodeableConcept>)yh_),
                Event = yi_,
                Subject = yj_,
                Encounter = yk_,
                DateElement = yl_,
                DetectedElement = ym_,
                RecordedDateElement = yn_,
                ResultingCondition = new List<ResourceReference>((IEnumerable<ResourceReference>)yo_),
                Location = yp_,
                Seriousness = yq_,
                Severity = yr_,
                Outcome = ys_,
                Recorder = yt_,
                Contributor = new List<ResourceReference>((IEnumerable<ResourceReference>)yu_),
                SuspectEntity = new List<AdverseEvent.SuspectEntityComponent>((IEnumerable<AdverseEvent.SuspectEntityComponent>)yv_),
                SubjectMedicalHistory = new List<ResourceReference>((IEnumerable<ResourceReference>)yw_),
                ReferenceDocument = new List<ResourceReference>((IEnumerable<ResourceReference>)yx_),
                Study = new List<ResourceReference>((IEnumerable<ResourceReference>)yy_),
            };

            return yz_;
        };
        IEnumerable<AdverseEvent> yc_ = context.Operators.Select<AdverseEvent, AdverseEvent>((IEnumerable<AdverseEvent>)ya_, yb_);
        IEnumerable<AdverseEvent> yd_ = context.Operators.Distinct<AdverseEvent>(yc_);
        AdverseEvent ye_ = context.Operators.SingletonFrom<AdverseEvent>(yd_);

        return ye_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public AllergyIntolerance AllergyIntoleranceResource(CqlContext context, AllergyIntolerance arg)
    {
        AllergyIntolerance[] za_ = [
            arg,
        ];
        AllergyIntolerance zb_(AllergyIntolerance a)
        {
            List<Identifier> zf_ = a?.Identifier;
            CodeableConcept zg_ = a?.ClinicalStatus;
            CodeableConcept zh_ = a?.VerificationStatus;
            Code<AllergyIntolerance.AllergyIntoleranceType> zi_ = a?.TypeElement;
            List<Code<AllergyIntolerance.AllergyIntoleranceCategory>> zj_ = a?.CategoryElement;
            Code<AllergyIntolerance.AllergyIntoleranceCriticality> zk_ = a?.CriticalityElement;
            CodeableConcept zl_ = a?.Code;
            ResourceReference zm_ = a?.Patient;
            ResourceReference zn_ = a?.Encounter;
            DataType zo_ = a?.Onset;
            FhirDateTime zp_ = a?.RecordedDateElement;
            ResourceReference zq_ = a?.Recorder;
            ResourceReference zr_ = a?.Asserter;
            FhirDateTime zs_ = a?.LastOccurrenceElement;
            List<Annotation> zt_ = a?.Note;
            List<AllergyIntolerance.ReactionComponent> zu_ = a?.Reaction;
            AllergyIntolerance zv_ = new AllergyIntolerance
            {
                Identifier = new List<Identifier>((IEnumerable<Identifier>)zf_),
                ClinicalStatus = zg_,
                VerificationStatus = zh_,
                TypeElement = zi_,
                CategoryElement = new List<Code<AllergyIntolerance.AllergyIntoleranceCategory>>((IEnumerable<Code<AllergyIntolerance.AllergyIntoleranceCategory>>)zj_),
                CriticalityElement = zk_,
                Code = zl_,
                Patient = zm_,
                Encounter = zn_,
                Onset = (DataType)zo_,
                RecordedDateElement = zp_,
                Recorder = zq_,
                Asserter = zr_,
                LastOccurrenceElement = zs_,
                Note = new List<Annotation>((IEnumerable<Annotation>)zt_),
                Reaction = new List<AllergyIntolerance.ReactionComponent>((IEnumerable<AllergyIntolerance.ReactionComponent>)zu_),
            };

            return zv_;
        };
        IEnumerable<AllergyIntolerance> zc_ = context.Operators.Select<AllergyIntolerance, AllergyIntolerance>((IEnumerable<AllergyIntolerance>)za_, zb_);
        IEnumerable<AllergyIntolerance> zd_ = context.Operators.Distinct<AllergyIntolerance>(zc_);
        AllergyIntolerance ze_ = context.Operators.SingletonFrom<AllergyIntolerance>(zd_);

        return ze_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public Appointment AppointmentResource(CqlContext context, Appointment arg)
    {
        Appointment[] zw_ = [
            arg,
        ];
        Appointment zx_(Appointment a)
        {
            List<Identifier> azb_ = a?.Identifier;
            Code<Appointment.AppointmentStatus> azc_ = a?.StatusElement;
            CodeableConcept azd_ = a?.CancelationReason;
            List<CodeableConcept> aze_ = a?.ServiceCategory;
            List<CodeableConcept> azf_ = a?.ServiceType;
            List<CodeableConcept> azg_ = a?.Specialty;
            CodeableConcept azh_ = a?.AppointmentType;
            List<CodeableConcept> azi_ = a?.ReasonCode;
            List<ResourceReference> azj_ = a?.ReasonReference;
            UnsignedInt azk_ = a?.PriorityElement;
            Integer azl_ = context.Operators.Convert<Integer>(azk_);
            UnsignedInt azm_ = context.Operators.Convert<UnsignedInt>(azl_);
            FhirString azn_ = a?.DescriptionElement;
            List<ResourceReference> azo_ = a?.SupportingInformation;
            Instant azp_ = a?.StartElement;
            Instant azq_ = a?.EndElement;
            PositiveInt azr_ = a?.MinutesDurationElement;
            Integer azs_ = context.Operators.Convert<Integer>(azr_);
            PositiveInt azt_ = context.Operators.Convert<PositiveInt>(azs_);
            List<ResourceReference> azu_ = a?.Slot;
            FhirDateTime azv_ = a?.CreatedElement;
            FhirString azw_ = a?.CommentElement;
            FhirString azx_ = a?.PatientInstructionElement;
            List<ResourceReference> azy_ = a?.BasedOn;
            List<Appointment.ParticipantComponent> azz_ = a?.Participant;
            List<Period> bza_ = a?.RequestedPeriod;
            Appointment bzb_ = new Appointment
            {
                Identifier = new List<Identifier>((IEnumerable<Identifier>)azb_),
                StatusElement = azc_,
                CancelationReason = azd_,
                ServiceCategory = new List<CodeableConcept>((IEnumerable<CodeableConcept>)aze_),
                ServiceType = new List<CodeableConcept>((IEnumerable<CodeableConcept>)azf_),
                Specialty = new List<CodeableConcept>((IEnumerable<CodeableConcept>)azg_),
                AppointmentType = azh_,
                ReasonCode = new List<CodeableConcept>((IEnumerable<CodeableConcept>)azi_),
                ReasonReference = new List<ResourceReference>((IEnumerable<ResourceReference>)azj_),
                PriorityElement = azm_,
                DescriptionElement = azn_,
                SupportingInformation = new List<ResourceReference>((IEnumerable<ResourceReference>)azo_),
                StartElement = azp_,
                EndElement = azq_,
                MinutesDurationElement = azt_,
                Slot = new List<ResourceReference>((IEnumerable<ResourceReference>)azu_),
                CreatedElement = azv_,
                CommentElement = azw_,
                PatientInstructionElement = azx_,
                BasedOn = new List<ResourceReference>((IEnumerable<ResourceReference>)azy_),
                Participant = new List<Appointment.ParticipantComponent>((IEnumerable<Appointment.ParticipantComponent>)azz_),
                RequestedPeriod = new List<Period>((IEnumerable<Period>)bza_),
            };

            return bzb_;
        };
        IEnumerable<Appointment> zy_ = context.Operators.Select<Appointment, Appointment>((IEnumerable<Appointment>)zw_, zx_);
        IEnumerable<Appointment> zz_ = context.Operators.Distinct<Appointment>(zy_);
        Appointment aza_ = context.Operators.SingletonFrom<Appointment>(zz_);

        return aza_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public AppointmentResponse AppointmentResponseResource(CqlContext context, AppointmentResponse arg)
    {
        AppointmentResponse[] bzc_ = [
            arg,
        ];
        AppointmentResponse bzd_(AppointmentResponse a)
        {
            List<Identifier> bzh_ = a?.Identifier;
            ResourceReference bzi_ = a?.Appointment;
            Instant bzj_ = a?.StartElement;
            Instant bzk_ = a?.EndElement;
            List<CodeableConcept> bzl_ = a?.ParticipantType;
            ResourceReference bzm_ = a?.Actor;
            Code<ParticipationStatus> bzn_ = a?.ParticipantStatusElement;
            FhirString bzo_ = a?.CommentElement;
            AppointmentResponse bzp_ = new AppointmentResponse
            {
                Identifier = new List<Identifier>((IEnumerable<Identifier>)bzh_),
                Appointment = bzi_,
                StartElement = bzj_,
                EndElement = bzk_,
                ParticipantType = new List<CodeableConcept>((IEnumerable<CodeableConcept>)bzl_),
                Actor = bzm_,
                ParticipantStatusElement = bzn_,
                CommentElement = bzo_,
            };

            return bzp_;
        };
        IEnumerable<AppointmentResponse> bze_ = context.Operators.Select<AppointmentResponse, AppointmentResponse>((IEnumerable<AppointmentResponse>)bzc_, bzd_);
        IEnumerable<AppointmentResponse> bzf_ = context.Operators.Distinct<AppointmentResponse>(bze_);
        AppointmentResponse bzg_ = context.Operators.SingletonFrom<AppointmentResponse>(bzf_);

        return bzg_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public AuditEvent AuditEventResource(CqlContext context, AuditEvent arg)
    {
        AuditEvent[] bzq_ = [
            arg,
        ];
        AuditEvent bzr_(AuditEvent a)
        {
            Coding bzv_ = a?.Type;
            List<Coding> bzw_ = a?.Subtype;
            Code<AuditEvent.AuditEventAction> bzx_ = a?.ActionElement;
            Period bzy_ = a?.Period;
            Instant bzz_ = a?.RecordedElement;
            Code<AuditEvent.AuditEventOutcome> cza_ = a?.OutcomeElement;
            FhirString czb_ = a?.OutcomeDescElement;
            List<CodeableConcept> czc_ = a?.PurposeOfEvent;
            List<AuditEvent.AgentComponent> czd_ = a?.Agent;
            AuditEvent.SourceComponent cze_ = a?.Source;
            List<AuditEvent.EntityComponent> czf_ = a?.Entity;
            AuditEvent czg_ = new AuditEvent
            {
                Type = bzv_,
                Subtype = new List<Coding>((IEnumerable<Coding>)bzw_),
                ActionElement = bzx_,
                Period = bzy_,
                RecordedElement = bzz_,
                OutcomeElement = cza_,
                OutcomeDescElement = czb_,
                PurposeOfEvent = new List<CodeableConcept>((IEnumerable<CodeableConcept>)czc_),
                Agent = new List<AuditEvent.AgentComponent>((IEnumerable<AuditEvent.AgentComponent>)czd_),
                Source = cze_,
                Entity = new List<AuditEvent.EntityComponent>((IEnumerable<AuditEvent.EntityComponent>)czf_),
            };

            return czg_;
        };
        IEnumerable<AuditEvent> bzs_ = context.Operators.Select<AuditEvent, AuditEvent>((IEnumerable<AuditEvent>)bzq_, bzr_);
        IEnumerable<AuditEvent> bzt_ = context.Operators.Distinct<AuditEvent>(bzs_);
        AuditEvent bzu_ = context.Operators.SingletonFrom<AuditEvent>(bzt_);

        return bzu_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public Basic BasicResource(CqlContext context, Basic arg)
    {
        Basic[] czh_ = [
            arg,
        ];
        Basic czi_(Basic a)
        {
            List<Identifier> czm_ = a?.Identifier;
            CodeableConcept czn_ = a?.Code;
            ResourceReference czo_ = a?.Subject;
            Date czp_ = a?.CreatedElement;
            ResourceReference czq_ = a?.Author;
            Basic czr_ = new Basic
            {
                Identifier = new List<Identifier>((IEnumerable<Identifier>)czm_),
                Code = czn_,
                Subject = czo_,
                CreatedElement = czp_,
                Author = czq_,
            };

            return czr_;
        };
        IEnumerable<Basic> czj_ = context.Operators.Select<Basic, Basic>((IEnumerable<Basic>)czh_, czi_);
        IEnumerable<Basic> czk_ = context.Operators.Distinct<Basic>(czj_);
        Basic czl_ = context.Operators.SingletonFrom<Basic>(czk_);

        return czl_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public BiologicallyDerivedProduct BiologicallyDerivedProductResource(CqlContext context, BiologicallyDerivedProduct arg)
    {
        BiologicallyDerivedProduct[] czs_ = [
            arg,
        ];
        BiologicallyDerivedProduct czt_(BiologicallyDerivedProduct a)
        {
            List<Identifier> czx_ = a?.Identifier;
            Code<BiologicallyDerivedProduct.BiologicallyDerivedProductCategory> czy_ = a?.ProductCategoryElement;
            CodeableConcept czz_ = a?.ProductCode;
            Code<BiologicallyDerivedProduct.BiologicallyDerivedProductStatus> dza_ = a?.StatusElement;
            List<ResourceReference> dzb_ = a?.Request;
            Integer dzc_ = a?.QuantityElement;
            List<ResourceReference> dzd_ = a?.Parent;
            BiologicallyDerivedProduct.CollectionComponent dze_ = a?.Collection;
            List<BiologicallyDerivedProduct.ProcessingComponent> dzf_ = a?.Processing;
            BiologicallyDerivedProduct.ManipulationComponent dzg_ = a?.Manipulation;
            List<BiologicallyDerivedProduct.StorageComponent> dzh_ = a?.Storage;
            BiologicallyDerivedProduct dzi_ = new BiologicallyDerivedProduct
            {
                Identifier = new List<Identifier>((IEnumerable<Identifier>)czx_),
                ProductCategoryElement = czy_,
                ProductCode = czz_,
                StatusElement = dza_,
                Request = new List<ResourceReference>((IEnumerable<ResourceReference>)dzb_),
                QuantityElement = dzc_,
                Parent = new List<ResourceReference>((IEnumerable<ResourceReference>)dzd_),
                Collection = dze_,
                Processing = new List<BiologicallyDerivedProduct.ProcessingComponent>((IEnumerable<BiologicallyDerivedProduct.ProcessingComponent>)dzf_),
                Manipulation = dzg_,
                Storage = new List<BiologicallyDerivedProduct.StorageComponent>((IEnumerable<BiologicallyDerivedProduct.StorageComponent>)dzh_),
            };

            return dzi_;
        };
        IEnumerable<BiologicallyDerivedProduct> czu_ = context.Operators.Select<BiologicallyDerivedProduct, BiologicallyDerivedProduct>((IEnumerable<BiologicallyDerivedProduct>)czs_, czt_);
        IEnumerable<BiologicallyDerivedProduct> czv_ = context.Operators.Distinct<BiologicallyDerivedProduct>(czu_);
        BiologicallyDerivedProduct czw_ = context.Operators.SingletonFrom<BiologicallyDerivedProduct>(czv_);

        return czw_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public BodyStructure BodyStructureResource(CqlContext context, BodyStructure arg)
    {
        BodyStructure[] dzj_ = [
            arg,
        ];
        BodyStructure dzk_(BodyStructure a)
        {
            List<Identifier> dzo_ = a?.Identifier;
            FhirBoolean dzp_ = a?.ActiveElement;
            CodeableConcept dzq_ = a?.Morphology;
            CodeableConcept dzr_ = a?.Location;
            List<CodeableConcept> dzs_ = a?.LocationQualifier;
            FhirString dzt_ = a?.DescriptionElement;
            List<Attachment> dzu_ = a?.Image;
            ResourceReference dzv_ = a?.Patient;
            BodyStructure dzw_ = new BodyStructure
            {
                Identifier = new List<Identifier>((IEnumerable<Identifier>)dzo_),
                ActiveElement = dzp_,
                Morphology = dzq_,
                Location = dzr_,
                LocationQualifier = new List<CodeableConcept>((IEnumerable<CodeableConcept>)dzs_),
                DescriptionElement = dzt_,
                Image = new List<Attachment>((IEnumerable<Attachment>)dzu_),
                Patient = dzv_,
            };

            return dzw_;
        };
        IEnumerable<BodyStructure> dzl_ = context.Operators.Select<BodyStructure, BodyStructure>((IEnumerable<BodyStructure>)dzj_, dzk_);
        IEnumerable<BodyStructure> dzm_ = context.Operators.Distinct<BodyStructure>(dzl_);
        BodyStructure dzn_ = context.Operators.SingletonFrom<BodyStructure>(dzm_);

        return dzn_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public CarePlan CarePlanResource(CqlContext context, CarePlan arg)
    {
        CarePlan[] dzx_ = [
            arg,
        ];
        CarePlan dzy_(CarePlan a)
        {
            List<Identifier> ezc_ = a?.Identifier;
            List<Canonical> ezd_ = a?.InstantiatesCanonicalElement;
            List<FhirUri> eze_ = a?.InstantiatesUriElement;
            List<ResourceReference> ezf_ = a?.BasedOn;
            List<ResourceReference> ezg_ = a?.Replaces;
            List<ResourceReference> ezh_ = a?.PartOf;
            Code<RequestStatus> ezi_ = a?.StatusElement;
            Code<CarePlan.CarePlanIntent> ezj_ = a?.IntentElement;
            List<CodeableConcept> ezk_ = a?.Category;
            FhirString ezl_ = a?.TitleElement;
            FhirString ezm_ = a?.DescriptionElement;
            ResourceReference ezn_ = a?.Subject;
            ResourceReference ezo_ = a?.Encounter;
            Period ezp_ = a?.Period;
            FhirDateTime ezq_ = a?.CreatedElement;
            ResourceReference ezr_ = a?.Author;
            List<ResourceReference> ezs_ = a?.Contributor;
            List<ResourceReference> ezt_ = a?.CareTeam;
            List<ResourceReference> ezu_ = a?.Addresses;
            List<ResourceReference> ezv_ = a?.SupportingInfo;
            List<ResourceReference> ezw_ = a?.Goal;
            List<CarePlan.ActivityComponent> ezx_ = a?.Activity;
            List<Annotation> ezy_ = a?.Note;
            CarePlan ezz_ = new CarePlan
            {
                Identifier = new List<Identifier>((IEnumerable<Identifier>)ezc_),
                InstantiatesCanonicalElement = new List<Canonical>((IEnumerable<Canonical>)ezd_),
                InstantiatesUriElement = new List<FhirUri>((IEnumerable<FhirUri>)eze_),
                BasedOn = new List<ResourceReference>((IEnumerable<ResourceReference>)ezf_),
                Replaces = new List<ResourceReference>((IEnumerable<ResourceReference>)ezg_),
                PartOf = new List<ResourceReference>((IEnumerable<ResourceReference>)ezh_),
                StatusElement = ezi_,
                IntentElement = ezj_,
                Category = new List<CodeableConcept>((IEnumerable<CodeableConcept>)ezk_),
                TitleElement = ezl_,
                DescriptionElement = ezm_,
                Subject = ezn_,
                Encounter = ezo_,
                Period = ezp_,
                CreatedElement = ezq_,
                Author = ezr_,
                Contributor = new List<ResourceReference>((IEnumerable<ResourceReference>)ezs_),
                CareTeam = new List<ResourceReference>((IEnumerable<ResourceReference>)ezt_),
                Addresses = new List<ResourceReference>((IEnumerable<ResourceReference>)ezu_),
                SupportingInfo = new List<ResourceReference>((IEnumerable<ResourceReference>)ezv_),
                Goal = new List<ResourceReference>((IEnumerable<ResourceReference>)ezw_),
                Activity = new List<CarePlan.ActivityComponent>((IEnumerable<CarePlan.ActivityComponent>)ezx_),
                Note = new List<Annotation>((IEnumerable<Annotation>)ezy_),
            };

            return ezz_;
        };
        IEnumerable<CarePlan> dzz_ = context.Operators.Select<CarePlan, CarePlan>((IEnumerable<CarePlan>)dzx_, dzy_);
        IEnumerable<CarePlan> eza_ = context.Operators.Distinct<CarePlan>(dzz_);
        CarePlan ezb_ = context.Operators.SingletonFrom<CarePlan>(eza_);

        return ezb_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public CareTeam CareTeamResource(CqlContext context, CareTeam arg)
    {
        CareTeam[] fza_ = [
            arg,
        ];
        CareTeam fzb_(CareTeam a)
        {
            List<Identifier> fzf_ = a?.Identifier;
            Code<CareTeam.CareTeamStatus> fzg_ = a?.StatusElement;
            List<CodeableConcept> fzh_ = a?.Category;
            FhirString fzi_ = a?.NameElement;
            ResourceReference fzj_ = a?.Subject;
            ResourceReference fzk_ = a?.Encounter;
            Period fzl_ = a?.Period;
            List<CareTeam.ParticipantComponent> fzm_ = a?.Participant;
            List<CodeableConcept> fzn_ = a?.ReasonCode;
            List<ResourceReference> fzo_ = a?.ReasonReference;
            List<ResourceReference> fzp_ = a?.ManagingOrganization;
            List<ContactPoint> fzq_ = a?.Telecom;
            List<Annotation> fzr_ = a?.Note;
            CareTeam fzs_ = new CareTeam
            {
                Identifier = new List<Identifier>((IEnumerable<Identifier>)fzf_),
                StatusElement = fzg_,
                Category = new List<CodeableConcept>((IEnumerable<CodeableConcept>)fzh_),
                NameElement = fzi_,
                Subject = fzj_,
                Encounter = fzk_,
                Period = fzl_,
                Participant = new List<CareTeam.ParticipantComponent>((IEnumerable<CareTeam.ParticipantComponent>)fzm_),
                ReasonCode = new List<CodeableConcept>((IEnumerable<CodeableConcept>)fzn_),
                ReasonReference = new List<ResourceReference>((IEnumerable<ResourceReference>)fzo_),
                ManagingOrganization = new List<ResourceReference>((IEnumerable<ResourceReference>)fzp_),
                Telecom = new List<ContactPoint>((IEnumerable<ContactPoint>)fzq_),
                Note = new List<Annotation>((IEnumerable<Annotation>)fzr_),
            };

            return fzs_;
        };
        IEnumerable<CareTeam> fzc_ = context.Operators.Select<CareTeam, CareTeam>((IEnumerable<CareTeam>)fza_, fzb_);
        IEnumerable<CareTeam> fzd_ = context.Operators.Distinct<CareTeam>(fzc_);
        CareTeam fze_ = context.Operators.SingletonFrom<CareTeam>(fzd_);

        return fze_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public CatalogEntry CatalogEntryResource(CqlContext context, CatalogEntry arg)
    {
        CatalogEntry[] fzt_ = [
            arg,
        ];
        CatalogEntry fzu_(CatalogEntry a)
        {
            List<Identifier> fzy_ = a?.Identifier;
            CodeableConcept fzz_ = a?.Type;
            FhirBoolean gza_ = a?.OrderableElement;
            ResourceReference gzb_ = a?.ReferencedItem;
            List<Identifier> gzc_ = a?.AdditionalIdentifier;
            List<CodeableConcept> gzd_ = a?.Classification;
            Code<PublicationStatus> gze_ = a?.StatusElement;
            Period gzf_ = a?.ValidityPeriod;
            FhirDateTime gzg_ = a?.ValidToElement;
            FhirDateTime gzh_ = a?.LastUpdatedElement;
            List<CodeableConcept> gzi_ = a?.AdditionalCharacteristic;
            List<CodeableConcept> gzj_ = a?.AdditionalClassification;
            List<CatalogEntry.RelatedEntryComponent> gzk_ = a?.RelatedEntry;
            CatalogEntry gzl_ = new CatalogEntry
            {
                Identifier = new List<Identifier>((IEnumerable<Identifier>)fzy_),
                Type = fzz_,
                OrderableElement = gza_,
                ReferencedItem = gzb_,
                AdditionalIdentifier = new List<Identifier>((IEnumerable<Identifier>)gzc_),
                Classification = new List<CodeableConcept>((IEnumerable<CodeableConcept>)gzd_),
                StatusElement = gze_,
                ValidityPeriod = gzf_,
                ValidToElement = gzg_,
                LastUpdatedElement = gzh_,
                AdditionalCharacteristic = new List<CodeableConcept>((IEnumerable<CodeableConcept>)gzi_),
                AdditionalClassification = new List<CodeableConcept>((IEnumerable<CodeableConcept>)gzj_),
                RelatedEntry = new List<CatalogEntry.RelatedEntryComponent>((IEnumerable<CatalogEntry.RelatedEntryComponent>)gzk_),
            };

            return gzl_;
        };
        IEnumerable<CatalogEntry> fzv_ = context.Operators.Select<CatalogEntry, CatalogEntry>((IEnumerable<CatalogEntry>)fzt_, fzu_);
        IEnumerable<CatalogEntry> fzw_ = context.Operators.Distinct<CatalogEntry>(fzv_);
        CatalogEntry fzx_ = context.Operators.SingletonFrom<CatalogEntry>(fzw_);

        return fzx_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public ChargeItem ChargeItemResource(CqlContext context, ChargeItem arg)
    {
        ChargeItem[] gzm_ = [
            arg,
        ];
        ChargeItem gzn_(ChargeItem a)
        {
            List<Identifier> gzr_ = a?.Identifier;
            List<FhirUri> gzs_ = a?.DefinitionUriElement;
            List<Canonical> gzt_ = a?.DefinitionCanonicalElement;
            Code<ChargeItem.ChargeItemStatus> gzu_ = a?.StatusElement;
            List<ResourceReference> gzv_ = a?.PartOf;
            CodeableConcept gzw_ = a?.Code;
            ResourceReference gzx_ = a?.Subject;
            ResourceReference gzy_ = a?.Context;
            DataType gzz_ = a?.Occurrence;
            List<ChargeItem.PerformerComponent> hza_ = a?.Performer;
            ResourceReference hzb_ = a?.PerformingOrganization;
            ResourceReference hzc_ = a?.RequestingOrganization;
            ResourceReference hzd_ = a?.CostCenter;
            Quantity hze_ = a?.Quantity;
            List<CodeableConcept> hzf_ = a?.Bodysite;
            FhirDecimal hzg_ = a?.FactorOverrideElement;
            Money hzh_ = a?.PriceOverride;
            FhirString hzi_ = a?.OverrideReasonElement;
            ResourceReference hzj_ = a?.Enterer;
            FhirDateTime hzk_ = a?.EnteredDateElement;
            List<CodeableConcept> hzl_ = a?.Reason;
            List<ResourceReference> hzm_ = a?.Service;
            DataType hzn_ = a?.Product;
            List<ResourceReference> hzo_ = a?.Account;
            List<Annotation> hzp_ = a?.Note;
            List<ResourceReference> hzq_ = a?.SupportingInformation;
            ChargeItem hzr_ = new ChargeItem
            {
                Identifier = new List<Identifier>((IEnumerable<Identifier>)gzr_),
                DefinitionUriElement = new List<FhirUri>((IEnumerable<FhirUri>)gzs_),
                DefinitionCanonicalElement = new List<Canonical>((IEnumerable<Canonical>)gzt_),
                StatusElement = gzu_,
                PartOf = new List<ResourceReference>((IEnumerable<ResourceReference>)gzv_),
                Code = gzw_,
                Subject = gzx_,
                Context = gzy_,
                Occurrence = (DataType)gzz_,
                Performer = new List<ChargeItem.PerformerComponent>((IEnumerable<ChargeItem.PerformerComponent>)hza_),
                PerformingOrganization = hzb_,
                RequestingOrganization = hzc_,
                CostCenter = hzd_,
                Quantity = hze_,
                Bodysite = new List<CodeableConcept>((IEnumerable<CodeableConcept>)hzf_),
                FactorOverrideElement = hzg_,
                PriceOverride = hzh_,
                OverrideReasonElement = hzi_,
                Enterer = hzj_,
                EnteredDateElement = hzk_,
                Reason = new List<CodeableConcept>((IEnumerable<CodeableConcept>)hzl_),
                Service = new List<ResourceReference>((IEnumerable<ResourceReference>)hzm_),
                Product = (DataType)hzn_,
                Account = new List<ResourceReference>((IEnumerable<ResourceReference>)hzo_),
                Note = new List<Annotation>((IEnumerable<Annotation>)hzp_),
                SupportingInformation = new List<ResourceReference>((IEnumerable<ResourceReference>)hzq_),
            };

            return hzr_;
        };
        IEnumerable<ChargeItem> gzo_ = context.Operators.Select<ChargeItem, ChargeItem>((IEnumerable<ChargeItem>)gzm_, gzn_);
        IEnumerable<ChargeItem> gzp_ = context.Operators.Distinct<ChargeItem>(gzo_);
        ChargeItem gzq_ = context.Operators.SingletonFrom<ChargeItem>(gzp_);

        return gzq_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public ChargeItemDefinition ChargeItemDefinitionResource(CqlContext context, ChargeItemDefinition arg)
    {
        ChargeItemDefinition[] hzs_ = [
            arg,
        ];
        ChargeItemDefinition hzt_(ChargeItemDefinition a)
        {
            FhirUri hzx_ = a?.UrlElement;
            List<Identifier> hzy_ = a?.Identifier;
            FhirString hzz_ = a?.VersionElement;
            FhirString iza_ = a?.TitleElement;
            List<FhirUri> izb_ = a?.DerivedFromUriElement;
            List<Canonical> izc_ = a?.PartOfElement;
            List<Canonical> izd_ = a?.ReplacesElement;
            Code<PublicationStatus> ize_ = a?.StatusElement;
            FhirBoolean izf_ = a?.ExperimentalElement;
            FhirDateTime izg_ = a?.DateElement;
            FhirString izh_ = a?.PublisherElement;
            List<ContactDetail> izi_ = a?.Contact;
            Markdown izj_ = a?.DescriptionElement;
            List<UsageContext> izk_ = a?.UseContext;
            List<CodeableConcept> izl_ = a?.Jurisdiction;
            Markdown izm_ = a?.CopyrightElement;
            Date izn_ = a?.ApprovalDateElement;
            Date izo_ = a?.LastReviewDateElement;
            Period izp_ = a?.EffectivePeriod;
            CodeableConcept izq_ = a?.Code;
            List<ResourceReference> izr_ = a?.Instance;
            List<ChargeItemDefinition.ApplicabilityComponent> izs_ = a?.Applicability;
            List<ChargeItemDefinition.PropertyGroupComponent> izt_ = a?.PropertyGroup;
            ChargeItemDefinition izu_ = new ChargeItemDefinition
            {
                UrlElement = hzx_,
                Identifier = new List<Identifier>((IEnumerable<Identifier>)hzy_),
                VersionElement = hzz_,
                TitleElement = iza_,
                DerivedFromUriElement = new List<FhirUri>((IEnumerable<FhirUri>)izb_),
                PartOfElement = new List<Canonical>((IEnumerable<Canonical>)izc_),
                ReplacesElement = new List<Canonical>((IEnumerable<Canonical>)izd_),
                StatusElement = ize_,
                ExperimentalElement = izf_,
                DateElement = izg_,
                PublisherElement = izh_,
                Contact = new List<ContactDetail>((IEnumerable<ContactDetail>)izi_),
                DescriptionElement = izj_,
                UseContext = new List<UsageContext>((IEnumerable<UsageContext>)izk_),
                Jurisdiction = new List<CodeableConcept>((IEnumerable<CodeableConcept>)izl_),
                CopyrightElement = izm_,
                ApprovalDateElement = izn_,
                LastReviewDateElement = izo_,
                EffectivePeriod = izp_,
                Code = izq_,
                Instance = new List<ResourceReference>((IEnumerable<ResourceReference>)izr_),
                Applicability = new List<ChargeItemDefinition.ApplicabilityComponent>((IEnumerable<ChargeItemDefinition.ApplicabilityComponent>)izs_),
                PropertyGroup = new List<ChargeItemDefinition.PropertyGroupComponent>((IEnumerable<ChargeItemDefinition.PropertyGroupComponent>)izt_),
            };

            return izu_;
        };
        IEnumerable<ChargeItemDefinition> hzu_ = context.Operators.Select<ChargeItemDefinition, ChargeItemDefinition>((IEnumerable<ChargeItemDefinition>)hzs_, hzt_);
        IEnumerable<ChargeItemDefinition> hzv_ = context.Operators.Distinct<ChargeItemDefinition>(hzu_);
        ChargeItemDefinition hzw_ = context.Operators.SingletonFrom<ChargeItemDefinition>(hzv_);

        return hzw_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public Claim ClaimResource(CqlContext context, Claim arg)
    {
        Claim[] izv_ = [
            arg,
        ];
        Claim izw_(Claim a)
        {
            List<Identifier> jza_ = a?.Identifier;
            Code<FinancialResourceStatusCodes> jzb_ = a?.StatusElement;
            CodeableConcept jzc_ = a?.Type;
            CodeableConcept jzd_ = a?.SubType;
            Code<ClaimUseCode> jze_ = a?.UseElement;
            ResourceReference jzf_ = a?.Patient;
            Period jzg_ = a?.BillablePeriod;
            FhirDateTime jzh_ = a?.CreatedElement;
            ResourceReference jzi_ = a?.Enterer;
            ResourceReference jzj_ = a?.Insurer;
            ResourceReference jzk_ = a?.Provider;
            CodeableConcept jzl_ = a?.Priority;
            CodeableConcept jzm_ = a?.FundsReserve;
            List<Claim.RelatedClaimComponent> jzn_ = a?.Related;
            ResourceReference jzo_ = a?.Prescription;
            ResourceReference jzp_ = a?.OriginalPrescription;
            Claim.PayeeComponent jzq_ = a?.Payee;
            ResourceReference jzr_ = a?.Referral;
            ResourceReference jzs_ = a?.Facility;
            List<Claim.CareTeamComponent> jzt_ = a?.CareTeam;
            List<Claim.SupportingInformationComponent> jzu_ = a?.SupportingInfo;
            List<Claim.DiagnosisComponent> jzv_ = a?.Diagnosis;
            List<Claim.ProcedureComponent> jzw_ = a?.Procedure;
            List<Claim.InsuranceComponent> jzx_ = a?.Insurance;
            Claim.AccidentComponent jzy_ = a?.Accident;
            List<Claim.ItemComponent> jzz_ = a?.Item;
            Money kza_ = a?.Total;
            Claim kzb_ = new Claim
            {
                Identifier = new List<Identifier>((IEnumerable<Identifier>)jza_),
                StatusElement = jzb_,
                Type = jzc_,
                SubType = jzd_,
                UseElement = jze_,
                Patient = jzf_,
                BillablePeriod = jzg_,
                CreatedElement = jzh_,
                Enterer = jzi_,
                Insurer = jzj_,
                Provider = jzk_,
                Priority = jzl_,
                FundsReserve = jzm_,
                Related = new List<Claim.RelatedClaimComponent>((IEnumerable<Claim.RelatedClaimComponent>)jzn_),
                Prescription = jzo_,
                OriginalPrescription = jzp_,
                Payee = jzq_,
                Referral = jzr_,
                Facility = jzs_,
                CareTeam = new List<Claim.CareTeamComponent>((IEnumerable<Claim.CareTeamComponent>)jzt_),
                SupportingInfo = new List<Claim.SupportingInformationComponent>((IEnumerable<Claim.SupportingInformationComponent>)jzu_),
                Diagnosis = new List<Claim.DiagnosisComponent>((IEnumerable<Claim.DiagnosisComponent>)jzv_),
                Procedure = new List<Claim.ProcedureComponent>((IEnumerable<Claim.ProcedureComponent>)jzw_),
                Insurance = new List<Claim.InsuranceComponent>((IEnumerable<Claim.InsuranceComponent>)jzx_),
                Accident = jzy_,
                Item = new List<Claim.ItemComponent>((IEnumerable<Claim.ItemComponent>)jzz_),
                Total = kza_,
            };

            return kzb_;
        };
        IEnumerable<Claim> izx_ = context.Operators.Select<Claim, Claim>((IEnumerable<Claim>)izv_, izw_);
        IEnumerable<Claim> izy_ = context.Operators.Distinct<Claim>(izx_);
        Claim izz_ = context.Operators.SingletonFrom<Claim>(izy_);

        return izz_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public ClaimResponse ClaimResponseResource(CqlContext context, ClaimResponse arg)
    {
        ClaimResponse[] kzc_ = [
            arg,
        ];
        ClaimResponse kzd_(ClaimResponse a)
        {
            List<Identifier> kzh_ = a?.Identifier;
            Code<FinancialResourceStatusCodes> kzi_ = a?.StatusElement;
            CodeableConcept kzj_ = a?.Type;
            CodeableConcept kzk_ = a?.SubType;
            Code<ClaimUseCode> kzl_ = a?.UseElement;
            ResourceReference kzm_ = a?.Patient;
            FhirDateTime kzn_ = a?.CreatedElement;
            ResourceReference kzo_ = a?.Insurer;
            ResourceReference kzp_ = a?.Requestor;
            ResourceReference kzq_ = a?.Request;
            Code<ClaimProcessingCodes> kzr_ = a?.OutcomeElement;
            FhirString kzs_ = a?.DispositionElement;
            FhirString kzt_ = a?.PreAuthRefElement;
            Period kzu_ = a?.PreAuthPeriod;
            CodeableConcept kzv_ = a?.PayeeType;
            List<ClaimResponse.ItemComponent> kzw_ = a?.Item;
            List<ClaimResponse.AddedItemComponent> kzx_ = a?.AddItem;
            List<ClaimResponse.AdjudicationComponent> kzy_ = a?.Adjudication;
            List<ClaimResponse.TotalComponent> kzz_ = a?.Total;
            ClaimResponse.PaymentComponent lza_ = a?.Payment;
            CodeableConcept lzb_ = a?.FundsReserve;
            CodeableConcept lzc_ = a?.FormCode;
            Attachment lzd_ = a?.Form;
            List<ClaimResponse.NoteComponent> lze_ = a?.ProcessNote;
            List<ResourceReference> lzf_ = a?.CommunicationRequest;
            List<ClaimResponse.InsuranceComponent> lzg_ = a?.Insurance;
            List<ClaimResponse.ErrorComponent> lzh_ = a?.Error;
            ClaimResponse lzi_ = new ClaimResponse
            {
                Identifier = new List<Identifier>((IEnumerable<Identifier>)kzh_),
                StatusElement = kzi_,
                Type = kzj_,
                SubType = kzk_,
                UseElement = kzl_,
                Patient = kzm_,
                CreatedElement = kzn_,
                Insurer = kzo_,
                Requestor = kzp_,
                Request = kzq_,
                OutcomeElement = kzr_,
                DispositionElement = kzs_,
                PreAuthRefElement = kzt_,
                PreAuthPeriod = kzu_,
                PayeeType = kzv_,
                Item = new List<ClaimResponse.ItemComponent>((IEnumerable<ClaimResponse.ItemComponent>)kzw_),
                AddItem = new List<ClaimResponse.AddedItemComponent>((IEnumerable<ClaimResponse.AddedItemComponent>)kzx_),
                Adjudication = new List<ClaimResponse.AdjudicationComponent>((IEnumerable<ClaimResponse.AdjudicationComponent>)kzy_),
                Total = new List<ClaimResponse.TotalComponent>((IEnumerable<ClaimResponse.TotalComponent>)kzz_),
                Payment = lza_,
                FundsReserve = lzb_,
                FormCode = lzc_,
                Form = lzd_,
                ProcessNote = new List<ClaimResponse.NoteComponent>((IEnumerable<ClaimResponse.NoteComponent>)lze_),
                CommunicationRequest = new List<ResourceReference>((IEnumerable<ResourceReference>)lzf_),
                Insurance = new List<ClaimResponse.InsuranceComponent>((IEnumerable<ClaimResponse.InsuranceComponent>)lzg_),
                Error = new List<ClaimResponse.ErrorComponent>((IEnumerable<ClaimResponse.ErrorComponent>)lzh_),
            };

            return lzi_;
        };
        IEnumerable<ClaimResponse> kze_ = context.Operators.Select<ClaimResponse, ClaimResponse>((IEnumerable<ClaimResponse>)kzc_, kzd_);
        IEnumerable<ClaimResponse> kzf_ = context.Operators.Distinct<ClaimResponse>(kze_);
        ClaimResponse kzg_ = context.Operators.SingletonFrom<ClaimResponse>(kzf_);

        return kzg_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public ClinicalImpression ClinicalImpressionResource(CqlContext context, ClinicalImpression arg)
    {
        ClinicalImpression[] lzj_ = [
            arg,
        ];
        ClinicalImpression lzk_(ClinicalImpression a)
        {
            List<Identifier> lzo_ = a?.Identifier;
            Code<ClinicalImpression.ClinicalImpressionStatus> lzp_ = a?.StatusElement;
            CodeableConcept lzq_ = a?.StatusReason;
            CodeableConcept lzr_ = a?.Code;
            FhirString lzs_ = a?.DescriptionElement;
            ResourceReference lzt_ = a?.Subject;
            ResourceReference lzu_ = a?.Encounter;
            DataType lzv_ = a?.Effective;
            FhirDateTime lzw_ = a?.DateElement;
            ResourceReference lzx_ = a?.Assessor;
            ResourceReference lzy_ = a?.Previous;
            List<ResourceReference> lzz_ = a?.Problem;
            List<ClinicalImpression.InvestigationComponent> mza_ = a?.Investigation;
            List<FhirUri> mzb_ = a?.ProtocolElement;
            FhirString mzc_ = a?.SummaryElement;
            List<ClinicalImpression.FindingComponent> mzd_ = a?.Finding;
            List<CodeableConcept> mze_ = a?.PrognosisCodeableConcept;
            List<ResourceReference> mzf_ = a?.PrognosisReference;
            List<ResourceReference> mzg_ = a?.SupportingInfo;
            List<Annotation> mzh_ = a?.Note;
            ClinicalImpression mzi_ = new ClinicalImpression
            {
                Identifier = new List<Identifier>((IEnumerable<Identifier>)lzo_),
                StatusElement = lzp_,
                StatusReason = lzq_,
                Code = lzr_,
                DescriptionElement = lzs_,
                Subject = lzt_,
                Encounter = lzu_,
                Effective = (DataType)lzv_,
                DateElement = lzw_,
                Assessor = lzx_,
                Previous = lzy_,
                Problem = new List<ResourceReference>((IEnumerable<ResourceReference>)lzz_),
                Investigation = new List<ClinicalImpression.InvestigationComponent>((IEnumerable<ClinicalImpression.InvestigationComponent>)mza_),
                ProtocolElement = new List<FhirUri>((IEnumerable<FhirUri>)mzb_),
                SummaryElement = mzc_,
                Finding = new List<ClinicalImpression.FindingComponent>((IEnumerable<ClinicalImpression.FindingComponent>)mzd_),
                PrognosisCodeableConcept = new List<CodeableConcept>((IEnumerable<CodeableConcept>)mze_),
                PrognosisReference = new List<ResourceReference>((IEnumerable<ResourceReference>)mzf_),
                SupportingInfo = new List<ResourceReference>((IEnumerable<ResourceReference>)mzg_),
                Note = new List<Annotation>((IEnumerable<Annotation>)mzh_),
            };

            return mzi_;
        };
        IEnumerable<ClinicalImpression> lzl_ = context.Operators.Select<ClinicalImpression, ClinicalImpression>((IEnumerable<ClinicalImpression>)lzj_, lzk_);
        IEnumerable<ClinicalImpression> lzm_ = context.Operators.Distinct<ClinicalImpression>(lzl_);
        ClinicalImpression lzn_ = context.Operators.SingletonFrom<ClinicalImpression>(lzm_);

        return lzn_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public CodeSystem CodeSystemResource(CqlContext context, CodeSystem arg)
    {
        CodeSystem[] mzj_ = [
            arg,
        ];
        CodeSystem mzk_(CodeSystem a)
        {
            FhirUri mzo_ = a?.UrlElement;
            List<Identifier> mzp_ = a?.Identifier;
            FhirString mzq_ = a?.VersionElement;
            FhirString mzr_ = a?.NameElement;
            FhirString mzs_ = a?.TitleElement;
            Code<PublicationStatus> mzt_ = a?.StatusElement;
            FhirBoolean mzu_ = a?.ExperimentalElement;
            FhirDateTime mzv_ = a?.DateElement;
            FhirString mzw_ = a?.PublisherElement;
            List<ContactDetail> mzx_ = a?.Contact;
            Markdown mzy_ = a?.DescriptionElement;
            List<UsageContext> mzz_ = a?.UseContext;
            List<CodeableConcept> nza_ = a?.Jurisdiction;
            Markdown nzb_ = a?.PurposeElement;
            Markdown nzc_ = a?.CopyrightElement;
            FhirBoolean nzd_ = a?.CaseSensitiveElement;
            Canonical nze_ = a?.ValueSetElement;
            Code<CodeSystem.CodeSystemHierarchyMeaning> nzf_ = a?.HierarchyMeaningElement;
            FhirBoolean nzg_ = a?.CompositionalElement;
            FhirBoolean nzh_ = a?.VersionNeededElement;
            Code<CodeSystemContentMode> nzi_ = a?.ContentElement;
            Canonical nzj_ = a?.SupplementsElement;
            UnsignedInt nzk_ = a?.CountElement;
            Integer nzl_ = context.Operators.Convert<Integer>(nzk_);
            UnsignedInt nzm_ = context.Operators.Convert<UnsignedInt>(nzl_);
            List<CodeSystem.FilterComponent> nzn_ = a?.Filter;
            List<CodeSystem.PropertyComponent> nzo_ = a?.Property;
            List<CodeSystem.ConceptDefinitionComponent> nzp_ = a?.Concept;
            CodeSystem nzq_ = new CodeSystem
            {
                UrlElement = mzo_,
                Identifier = new List<Identifier>((IEnumerable<Identifier>)mzp_),
                VersionElement = mzq_,
                NameElement = mzr_,
                TitleElement = mzs_,
                StatusElement = mzt_,
                ExperimentalElement = mzu_,
                DateElement = mzv_,
                PublisherElement = mzw_,
                Contact = new List<ContactDetail>((IEnumerable<ContactDetail>)mzx_),
                DescriptionElement = mzy_,
                UseContext = new List<UsageContext>((IEnumerable<UsageContext>)mzz_),
                Jurisdiction = new List<CodeableConcept>((IEnumerable<CodeableConcept>)nza_),
                PurposeElement = nzb_,
                CopyrightElement = nzc_,
                CaseSensitiveElement = nzd_,
                ValueSetElement = nze_,
                HierarchyMeaningElement = nzf_,
                CompositionalElement = nzg_,
                VersionNeededElement = nzh_,
                ContentElement = nzi_,
                SupplementsElement = nzj_,
                CountElement = nzm_,
                Filter = new List<CodeSystem.FilterComponent>((IEnumerable<CodeSystem.FilterComponent>)nzn_),
                Property = new List<CodeSystem.PropertyComponent>((IEnumerable<CodeSystem.PropertyComponent>)nzo_),
                Concept = new List<CodeSystem.ConceptDefinitionComponent>((IEnumerable<CodeSystem.ConceptDefinitionComponent>)nzp_),
            };

            return nzq_;
        };
        IEnumerable<CodeSystem> mzl_ = context.Operators.Select<CodeSystem, CodeSystem>((IEnumerable<CodeSystem>)mzj_, mzk_);
        IEnumerable<CodeSystem> mzm_ = context.Operators.Distinct<CodeSystem>(mzl_);
        CodeSystem mzn_ = context.Operators.SingletonFrom<CodeSystem>(mzm_);

        return mzn_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public Communication CommunicationResource(CqlContext context, Communication arg)
    {
        Communication[] nzr_ = [
            arg,
        ];
        Communication nzs_(Communication a)
        {
            List<Identifier> nzw_ = a?.Identifier;
            List<Canonical> nzx_ = a?.InstantiatesCanonicalElement;
            List<FhirUri> nzy_ = a?.InstantiatesUriElement;
            List<ResourceReference> nzz_ = a?.BasedOn;
            List<ResourceReference> oza_ = a?.PartOf;
            List<ResourceReference> ozb_ = a?.InResponseTo;
            Code<EventStatus> ozc_ = a?.StatusElement;
            CodeableConcept ozd_ = a?.StatusReason;
            List<CodeableConcept> oze_ = a?.Category;
            Code<RequestPriority> ozf_ = a?.PriorityElement;
            List<CodeableConcept> ozg_ = a?.Medium;
            ResourceReference ozh_ = a?.Subject;
            CodeableConcept ozi_ = a?.Topic;
            List<ResourceReference> ozj_ = a?.About;
            ResourceReference ozk_ = a?.Encounter;
            FhirDateTime ozl_ = a?.SentElement;
            FhirDateTime ozm_ = a?.ReceivedElement;
            List<ResourceReference> ozn_ = a?.Recipient;
            ResourceReference ozo_ = a?.Sender;
            List<CodeableConcept> ozp_ = a?.ReasonCode;
            List<ResourceReference> ozq_ = a?.ReasonReference;
            List<Communication.PayloadComponent> ozr_ = a?.Payload;
            List<Annotation> ozs_ = a?.Note;
            Communication ozt_ = new Communication
            {
                Identifier = new List<Identifier>((IEnumerable<Identifier>)nzw_),
                InstantiatesCanonicalElement = new List<Canonical>((IEnumerable<Canonical>)nzx_),
                InstantiatesUriElement = new List<FhirUri>((IEnumerable<FhirUri>)nzy_),
                BasedOn = new List<ResourceReference>((IEnumerable<ResourceReference>)nzz_),
                PartOf = new List<ResourceReference>((IEnumerable<ResourceReference>)oza_),
                InResponseTo = new List<ResourceReference>((IEnumerable<ResourceReference>)ozb_),
                StatusElement = ozc_,
                StatusReason = ozd_,
                Category = new List<CodeableConcept>((IEnumerable<CodeableConcept>)oze_),
                PriorityElement = ozf_,
                Medium = new List<CodeableConcept>((IEnumerable<CodeableConcept>)ozg_),
                Subject = ozh_,
                Topic = ozi_,
                About = new List<ResourceReference>((IEnumerable<ResourceReference>)ozj_),
                Encounter = ozk_,
                SentElement = ozl_,
                ReceivedElement = ozm_,
                Recipient = new List<ResourceReference>((IEnumerable<ResourceReference>)ozn_),
                Sender = ozo_,
                ReasonCode = new List<CodeableConcept>((IEnumerable<CodeableConcept>)ozp_),
                ReasonReference = new List<ResourceReference>((IEnumerable<ResourceReference>)ozq_),
                Payload = new List<Communication.PayloadComponent>((IEnumerable<Communication.PayloadComponent>)ozr_),
                Note = new List<Annotation>((IEnumerable<Annotation>)ozs_),
            };

            return ozt_;
        };
        IEnumerable<Communication> nzt_ = context.Operators.Select<Communication, Communication>((IEnumerable<Communication>)nzr_, nzs_);
        IEnumerable<Communication> nzu_ = context.Operators.Distinct<Communication>(nzt_);
        Communication nzv_ = context.Operators.SingletonFrom<Communication>(nzu_);

        return nzv_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public CommunicationRequest CommunicationRequestResource(CqlContext context, CommunicationRequest arg)
    {
        CommunicationRequest[] ozu_ = [
            arg,
        ];
        CommunicationRequest ozv_(CommunicationRequest a)
        {
            List<Identifier> ozz_ = a?.Identifier;
            List<ResourceReference> pza_ = a?.BasedOn;
            List<ResourceReference> pzb_ = a?.Replaces;
            Identifier pzc_ = a?.GroupIdentifier;
            Code<RequestStatus> pzd_ = a?.StatusElement;
            CodeableConcept pze_ = a?.StatusReason;
            List<CodeableConcept> pzf_ = a?.Category;
            Code<RequestPriority> pzg_ = a?.PriorityElement;
            FhirBoolean pzh_ = a?.DoNotPerformElement;
            List<CodeableConcept> pzi_ = a?.Medium;
            ResourceReference pzj_ = a?.Subject;
            List<ResourceReference> pzk_ = a?.About;
            ResourceReference pzl_ = a?.Encounter;
            List<CommunicationRequest.PayloadComponent> pzm_ = a?.Payload;
            DataType pzn_ = a?.Occurrence;
            FhirDateTime pzo_ = a?.AuthoredOnElement;
            ResourceReference pzp_ = a?.Requester;
            List<ResourceReference> pzq_ = a?.Recipient;
            ResourceReference pzr_ = a?.Sender;
            List<CodeableConcept> pzs_ = a?.ReasonCode;
            List<ResourceReference> pzt_ = a?.ReasonReference;
            List<Annotation> pzu_ = a?.Note;
            CommunicationRequest pzv_ = new CommunicationRequest
            {
                Identifier = new List<Identifier>((IEnumerable<Identifier>)ozz_),
                BasedOn = new List<ResourceReference>((IEnumerable<ResourceReference>)pza_),
                Replaces = new List<ResourceReference>((IEnumerable<ResourceReference>)pzb_),
                GroupIdentifier = pzc_,
                StatusElement = pzd_,
                StatusReason = pze_,
                Category = new List<CodeableConcept>((IEnumerable<CodeableConcept>)pzf_),
                PriorityElement = pzg_,
                DoNotPerformElement = pzh_,
                Medium = new List<CodeableConcept>((IEnumerable<CodeableConcept>)pzi_),
                Subject = pzj_,
                About = new List<ResourceReference>((IEnumerable<ResourceReference>)pzk_),
                Encounter = pzl_,
                Payload = new List<CommunicationRequest.PayloadComponent>((IEnumerable<CommunicationRequest.PayloadComponent>)pzm_),
                Occurrence = (DataType)pzn_,
                AuthoredOnElement = pzo_,
                Requester = pzp_,
                Recipient = new List<ResourceReference>((IEnumerable<ResourceReference>)pzq_),
                Sender = pzr_,
                ReasonCode = new List<CodeableConcept>((IEnumerable<CodeableConcept>)pzs_),
                ReasonReference = new List<ResourceReference>((IEnumerable<ResourceReference>)pzt_),
                Note = new List<Annotation>((IEnumerable<Annotation>)pzu_),
            };

            return pzv_;
        };
        IEnumerable<CommunicationRequest> ozw_ = context.Operators.Select<CommunicationRequest, CommunicationRequest>((IEnumerable<CommunicationRequest>)ozu_, ozv_);
        IEnumerable<CommunicationRequest> ozx_ = context.Operators.Distinct<CommunicationRequest>(ozw_);
        CommunicationRequest ozy_ = context.Operators.SingletonFrom<CommunicationRequest>(ozx_);

        return ozy_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public Composition CompositionResource(CqlContext context, Composition arg)
    {
        Composition[] pzw_ = [
            arg,
        ];
        Composition pzx_(Composition a)
        {
            Identifier qzb_ = a?.Identifier;
            Code<CompositionStatus> qzc_ = a?.StatusElement;
            CodeableConcept qzd_ = a?.Type;
            List<CodeableConcept> qze_ = a?.Category;
            ResourceReference qzf_ = a?.Subject;
            ResourceReference qzg_ = a?.Encounter;
            FhirDateTime qzh_ = a?.DateElement;
            List<ResourceReference> qzi_ = a?.Author;
            FhirString qzj_ = a?.TitleElement;
            Code<Composition.V3ConfidentialityClassification> qzk_ = a?.ConfidentialityElement;
            List<Composition.AttesterComponent> qzl_ = a?.Attester;
            ResourceReference qzm_ = a?.Custodian;
            List<Composition.RelatesToComponent> qzn_ = a?.RelatesTo;
            List<Composition.EventComponent> qzo_ = a?.Event;
            List<Composition.SectionComponent> qzp_ = a?.Section;
            Composition qzq_ = new Composition
            {
                Identifier = qzb_,
                StatusElement = qzc_,
                Type = qzd_,
                Category = new List<CodeableConcept>((IEnumerable<CodeableConcept>)qze_),
                Subject = qzf_,
                Encounter = qzg_,
                DateElement = qzh_,
                Author = new List<ResourceReference>((IEnumerable<ResourceReference>)qzi_),
                TitleElement = qzj_,
                ConfidentialityElement = qzk_,
                Attester = new List<Composition.AttesterComponent>((IEnumerable<Composition.AttesterComponent>)qzl_),
                Custodian = qzm_,
                RelatesTo = new List<Composition.RelatesToComponent>((IEnumerable<Composition.RelatesToComponent>)qzn_),
                Event = new List<Composition.EventComponent>((IEnumerable<Composition.EventComponent>)qzo_),
                Section = new List<Composition.SectionComponent>((IEnumerable<Composition.SectionComponent>)qzp_),
            };

            return qzq_;
        };
        IEnumerable<Composition> pzy_ = context.Operators.Select<Composition, Composition>((IEnumerable<Composition>)pzw_, pzx_);
        IEnumerable<Composition> pzz_ = context.Operators.Distinct<Composition>(pzy_);
        Composition qza_ = context.Operators.SingletonFrom<Composition>(pzz_);

        return qza_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public ConceptMap ConceptMapResource(CqlContext context, ConceptMap arg)
    {
        ConceptMap[] qzr_ = [
            arg,
        ];
        ConceptMap qzs_(ConceptMap a)
        {
            FhirUri qzw_ = a?.UrlElement;
            Identifier qzx_ = a?.Identifier;
            FhirString qzy_ = a?.VersionElement;
            FhirString qzz_ = a?.NameElement;
            FhirString rza_ = a?.TitleElement;
            Code<PublicationStatus> rzb_ = a?.StatusElement;
            FhirBoolean rzc_ = a?.ExperimentalElement;
            FhirDateTime rzd_ = a?.DateElement;
            FhirString rze_ = a?.PublisherElement;
            List<ContactDetail> rzf_ = a?.Contact;
            Markdown rzg_ = a?.DescriptionElement;
            List<UsageContext> rzh_ = a?.UseContext;
            List<CodeableConcept> rzi_ = a?.Jurisdiction;
            Markdown rzj_ = a?.PurposeElement;
            Markdown rzk_ = a?.CopyrightElement;
            DataType rzl_ = a?.Source;
            DataType rzm_ = a?.Target;
            List<ConceptMap.GroupComponent> rzn_ = a?.Group;
            ConceptMap rzo_ = new ConceptMap
            {
                UrlElement = qzw_,
                Identifier = qzx_,
                VersionElement = qzy_,
                NameElement = qzz_,
                TitleElement = rza_,
                StatusElement = rzb_,
                ExperimentalElement = rzc_,
                DateElement = rzd_,
                PublisherElement = rze_,
                Contact = new List<ContactDetail>((IEnumerable<ContactDetail>)rzf_),
                DescriptionElement = rzg_,
                UseContext = new List<UsageContext>((IEnumerable<UsageContext>)rzh_),
                Jurisdiction = new List<CodeableConcept>((IEnumerable<CodeableConcept>)rzi_),
                PurposeElement = rzj_,
                CopyrightElement = rzk_,
                Source = (DataType)rzl_,
                Target = (DataType)rzm_,
                Group = new List<ConceptMap.GroupComponent>((IEnumerable<ConceptMap.GroupComponent>)rzn_),
            };

            return rzo_;
        };
        IEnumerable<ConceptMap> qzt_ = context.Operators.Select<ConceptMap, ConceptMap>((IEnumerable<ConceptMap>)qzr_, qzs_);
        IEnumerable<ConceptMap> qzu_ = context.Operators.Distinct<ConceptMap>(qzt_);
        ConceptMap qzv_ = context.Operators.SingletonFrom<ConceptMap>(qzu_);

        return qzv_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public Condition ConditionResource(CqlContext context, Condition arg)
    {
        Condition[] rzp_ = [
            arg,
        ];
        Condition rzq_(Condition a)
        {
            List<Identifier> rzu_ = a?.Identifier;
            CodeableConcept rzv_ = a?.ClinicalStatus;
            CodeableConcept rzw_ = a?.VerificationStatus;
            List<CodeableConcept> rzx_ = a?.Category;
            CodeableConcept rzy_ = a?.Severity;
            CodeableConcept rzz_ = a?.Code;
            List<CodeableConcept> sza_ = a?.BodySite;
            ResourceReference szb_ = a?.Subject;
            ResourceReference szc_ = a?.Encounter;
            DataType szd_ = a?.Onset;
            DataType sze_ = a?.Abatement;
            FhirDateTime szf_ = a?.RecordedDateElement;
            ResourceReference szg_ = a?.Recorder;
            ResourceReference szh_ = a?.Asserter;
            List<Condition.StageComponent> szi_ = a?.Stage;
            List<Condition.EvidenceComponent> szj_ = a?.Evidence;
            List<Annotation> szk_ = a?.Note;
            Condition szl_ = new Condition
            {
                Identifier = new List<Identifier>((IEnumerable<Identifier>)rzu_),
                ClinicalStatus = rzv_,
                VerificationStatus = rzw_,
                Category = new List<CodeableConcept>((IEnumerable<CodeableConcept>)rzx_),
                Severity = rzy_,
                Code = rzz_,
                BodySite = new List<CodeableConcept>((IEnumerable<CodeableConcept>)sza_),
                Subject = szb_,
                Encounter = szc_,
                Onset = (DataType)szd_,
                Abatement = (DataType)sze_,
                RecordedDateElement = szf_,
                Recorder = szg_,
                Asserter = szh_,
                Stage = new List<Condition.StageComponent>((IEnumerable<Condition.StageComponent>)szi_),
                Evidence = new List<Condition.EvidenceComponent>((IEnumerable<Condition.EvidenceComponent>)szj_),
                Note = new List<Annotation>((IEnumerable<Annotation>)szk_),
            };

            return szl_;
        };
        IEnumerable<Condition> rzr_ = context.Operators.Select<Condition, Condition>((IEnumerable<Condition>)rzp_, rzq_);
        IEnumerable<Condition> rzs_ = context.Operators.Distinct<Condition>(rzr_);
        Condition rzt_ = context.Operators.SingletonFrom<Condition>(rzs_);

        return rzt_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public Consent ConsentResource(CqlContext context, Consent arg)
    {
        Consent[] szm_ = [
            arg,
        ];
        Consent szn_(Consent a)
        {
            List<Identifier> szr_ = a?.Identifier;
            Code<Consent.ConsentState> szs_ = a?.StatusElement;
            CodeableConcept szt_ = a?.Scope;
            List<CodeableConcept> szu_ = a?.Category;
            ResourceReference szv_ = a?.Patient;
            FhirDateTime szw_ = a?.DateTimeElement;
            List<ResourceReference> szx_ = a?.Performer;
            List<ResourceReference> szy_ = a?.Organization;
            DataType szz_ = a?.Source;
            List<Consent.PolicyComponent> tza_ = a?.Policy;
            CodeableConcept tzb_ = a?.PolicyRule;
            List<Consent.VerificationComponent> tzc_ = a?.Verification;
            Consent.provisionComponent tzd_ = a?.Provision;
            Consent tze_ = new Consent
            {
                Identifier = new List<Identifier>((IEnumerable<Identifier>)szr_),
                StatusElement = szs_,
                Scope = szt_,
                Category = new List<CodeableConcept>((IEnumerable<CodeableConcept>)szu_),
                Patient = szv_,
                DateTimeElement = szw_,
                Performer = new List<ResourceReference>((IEnumerable<ResourceReference>)szx_),
                Organization = new List<ResourceReference>((IEnumerable<ResourceReference>)szy_),
                Source = (DataType)szz_,
                Policy = new List<Consent.PolicyComponent>((IEnumerable<Consent.PolicyComponent>)tza_),
                PolicyRule = tzb_,
                Verification = new List<Consent.VerificationComponent>((IEnumerable<Consent.VerificationComponent>)tzc_),
                Provision = tzd_,
            };

            return tze_;
        };
        IEnumerable<Consent> szo_ = context.Operators.Select<Consent, Consent>((IEnumerable<Consent>)szm_, szn_);
        IEnumerable<Consent> szp_ = context.Operators.Distinct<Consent>(szo_);
        Consent szq_ = context.Operators.SingletonFrom<Consent>(szp_);

        return szq_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public Contract ContractResource(CqlContext context, Contract arg)
    {
        Contract[] tzf_ = [
            arg,
        ];
        Contract tzg_(Contract a)
        {
            List<Identifier> tzk_ = a?.Identifier;
            FhirUri tzl_ = a?.UrlElement;
            FhirString tzm_ = a?.VersionElement;
            Code<Contract.ContractResourceStatusCodes> tzn_ = a?.StatusElement;
            CodeableConcept tzo_ = a?.LegalState;
            ResourceReference tzp_ = a?.InstantiatesCanonical;
            FhirUri tzq_ = a?.InstantiatesUriElement;
            CodeableConcept tzr_ = a?.ContentDerivative;
            FhirDateTime tzs_ = a?.IssuedElement;
            Period tzt_ = a?.Applies;
            CodeableConcept tzu_ = a?.ExpirationType;
            List<ResourceReference> tzv_ = a?.Subject;
            List<ResourceReference> tzw_ = a?.Authority;
            List<ResourceReference> tzx_ = a?.Domain;
            List<ResourceReference> tzy_ = a?.Site;
            FhirString tzz_ = a?.NameElement;
            FhirString uza_ = a?.TitleElement;
            FhirString uzb_ = a?.SubtitleElement;
            List<FhirString> uzc_ = a?.AliasElement;
            ResourceReference uzd_ = a?.Author;
            CodeableConcept uze_ = a?.Scope;
            DataType uzf_ = a?.Topic;
            CodeableConcept uzg_ = a?.Type;
            List<CodeableConcept> uzh_ = a?.SubType;
            Contract.ContentDefinitionComponent uzi_ = a?.ContentDefinition;
            List<Contract.TermComponent> uzj_ = a?.Term;
            List<ResourceReference> uzk_ = a?.SupportingInfo;
            List<ResourceReference> uzl_ = a?.RelevantHistory;
            List<Contract.SignatoryComponent> uzm_ = a?.Signer;
            List<Contract.FriendlyLanguageComponent> uzn_ = a?.Friendly;
            List<Contract.LegalLanguageComponent> uzo_ = a?.Legal;
            List<Contract.ComputableLanguageComponent> uzp_ = a?.Rule;
            DataType uzq_ = a?.LegallyBinding;
            Contract uzr_ = new Contract
            {
                Identifier = new List<Identifier>((IEnumerable<Identifier>)tzk_),
                UrlElement = tzl_,
                VersionElement = tzm_,
                StatusElement = tzn_,
                LegalState = tzo_,
                InstantiatesCanonical = tzp_,
                InstantiatesUriElement = tzq_,
                ContentDerivative = tzr_,
                IssuedElement = tzs_,
                Applies = tzt_,
                ExpirationType = tzu_,
                Subject = new List<ResourceReference>((IEnumerable<ResourceReference>)tzv_),
                Authority = new List<ResourceReference>((IEnumerable<ResourceReference>)tzw_),
                Domain = new List<ResourceReference>((IEnumerable<ResourceReference>)tzx_),
                Site = new List<ResourceReference>((IEnumerable<ResourceReference>)tzy_),
                NameElement = tzz_,
                TitleElement = uza_,
                SubtitleElement = uzb_,
                AliasElement = new List<FhirString>((IEnumerable<FhirString>)uzc_),
                Author = uzd_,
                Scope = uze_,
                Topic = (DataType)uzf_,
                Type = uzg_,
                SubType = new List<CodeableConcept>((IEnumerable<CodeableConcept>)uzh_),
                ContentDefinition = uzi_,
                Term = new List<Contract.TermComponent>((IEnumerable<Contract.TermComponent>)uzj_),
                SupportingInfo = new List<ResourceReference>((IEnumerable<ResourceReference>)uzk_),
                RelevantHistory = new List<ResourceReference>((IEnumerable<ResourceReference>)uzl_),
                Signer = new List<Contract.SignatoryComponent>((IEnumerable<Contract.SignatoryComponent>)uzm_),
                Friendly = new List<Contract.FriendlyLanguageComponent>((IEnumerable<Contract.FriendlyLanguageComponent>)uzn_),
                Legal = new List<Contract.LegalLanguageComponent>((IEnumerable<Contract.LegalLanguageComponent>)uzo_),
                Rule = new List<Contract.ComputableLanguageComponent>((IEnumerable<Contract.ComputableLanguageComponent>)uzp_),
                LegallyBinding = (DataType)uzq_,
            };

            return uzr_;
        };
        IEnumerable<Contract> tzh_ = context.Operators.Select<Contract, Contract>((IEnumerable<Contract>)tzf_, tzg_);
        IEnumerable<Contract> tzi_ = context.Operators.Distinct<Contract>(tzh_);
        Contract tzj_ = context.Operators.SingletonFrom<Contract>(tzi_);

        return tzj_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public Coverage CoverageResource(CqlContext context, Coverage arg)
    {
        Coverage[] uzs_ = [
            arg,
        ];
        Coverage uzt_(Coverage a)
        {
            List<Identifier> uzx_ = a?.Identifier;
            Code<FinancialResourceStatusCodes> uzy_ = a?.StatusElement;
            CodeableConcept uzz_ = a?.Type;
            ResourceReference vza_ = a?.PolicyHolder;
            ResourceReference vzb_ = a?.Subscriber;
            FhirString vzc_ = a?.SubscriberIdElement;
            ResourceReference vzd_ = a?.Beneficiary;
            FhirString vze_ = a?.DependentElement;
            CodeableConcept vzf_ = a?.Relationship;
            Period vzg_ = a?.Period;
            List<ResourceReference> vzh_ = a?.Payor;
            List<Coverage.ClassComponent> vzi_ = a?.Class;
            PositiveInt vzj_ = a?.OrderElement;
            Integer vzk_ = context.Operators.Convert<Integer>(vzj_);
            PositiveInt vzl_ = context.Operators.Convert<PositiveInt>(vzk_);
            FhirString vzm_ = a?.NetworkElement;
            List<Coverage.CostToBeneficiaryComponent> vzn_ = a?.CostToBeneficiary;
            FhirBoolean vzo_ = a?.SubrogationElement;
            List<ResourceReference> vzp_ = a?.Contract;
            Coverage vzq_ = new Coverage
            {
                Identifier = new List<Identifier>((IEnumerable<Identifier>)uzx_),
                StatusElement = uzy_,
                Type = uzz_,
                PolicyHolder = vza_,
                Subscriber = vzb_,
                SubscriberIdElement = vzc_,
                Beneficiary = vzd_,
                DependentElement = vze_,
                Relationship = vzf_,
                Period = vzg_,
                Payor = new List<ResourceReference>((IEnumerable<ResourceReference>)vzh_),
                Class = new List<Coverage.ClassComponent>((IEnumerable<Coverage.ClassComponent>)vzi_),
                OrderElement = vzl_,
                NetworkElement = vzm_,
                CostToBeneficiary = new List<Coverage.CostToBeneficiaryComponent>((IEnumerable<Coverage.CostToBeneficiaryComponent>)vzn_),
                SubrogationElement = vzo_,
                Contract = new List<ResourceReference>((IEnumerable<ResourceReference>)vzp_),
            };

            return vzq_;
        };
        IEnumerable<Coverage> uzu_ = context.Operators.Select<Coverage, Coverage>((IEnumerable<Coverage>)uzs_, uzt_);
        IEnumerable<Coverage> uzv_ = context.Operators.Distinct<Coverage>(uzu_);
        Coverage uzw_ = context.Operators.SingletonFrom<Coverage>(uzv_);

        return uzw_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public CoverageEligibilityRequest CoverageEligibilityRequestResource(CqlContext context, CoverageEligibilityRequest arg)
    {
        CoverageEligibilityRequest[] vzr_ = [
            arg,
        ];
        CoverageEligibilityRequest vzs_(CoverageEligibilityRequest a)
        {
            List<Identifier> vzw_ = a?.Identifier;
            Code<FinancialResourceStatusCodes> vzx_ = a?.StatusElement;
            CodeableConcept vzy_ = a?.Priority;
            List<Code<CoverageEligibilityRequest.EligibilityRequestPurpose>> vzz_ = a?.PurposeElement;
            ResourceReference wza_ = a?.Patient;
            DataType wzb_ = a?.Serviced;
            FhirDateTime wzc_ = a?.CreatedElement;
            ResourceReference wzd_ = a?.Enterer;
            ResourceReference wze_ = a?.Provider;
            ResourceReference wzf_ = a?.Insurer;
            ResourceReference wzg_ = a?.Facility;
            List<CoverageEligibilityRequest.SupportingInformationComponent> wzh_ = a?.SupportingInfo;
            List<CoverageEligibilityRequest.InsuranceComponent> wzi_ = a?.Insurance;
            List<CoverageEligibilityRequest.DetailsComponent> wzj_ = a?.Item;
            CoverageEligibilityRequest wzk_ = new CoverageEligibilityRequest
            {
                Identifier = new List<Identifier>((IEnumerable<Identifier>)vzw_),
                StatusElement = vzx_,
                Priority = vzy_,
                PurposeElement = new List<Code<CoverageEligibilityRequest.EligibilityRequestPurpose>>((IEnumerable<Code<CoverageEligibilityRequest.EligibilityRequestPurpose>>)vzz_),
                Patient = wza_,
                Serviced = (DataType)wzb_,
                CreatedElement = wzc_,
                Enterer = wzd_,
                Provider = wze_,
                Insurer = wzf_,
                Facility = wzg_,
                SupportingInfo = new List<CoverageEligibilityRequest.SupportingInformationComponent>((IEnumerable<CoverageEligibilityRequest.SupportingInformationComponent>)wzh_),
                Insurance = new List<CoverageEligibilityRequest.InsuranceComponent>((IEnumerable<CoverageEligibilityRequest.InsuranceComponent>)wzi_),
                Item = new List<CoverageEligibilityRequest.DetailsComponent>((IEnumerable<CoverageEligibilityRequest.DetailsComponent>)wzj_),
            };

            return wzk_;
        };
        IEnumerable<CoverageEligibilityRequest> vzt_ = context.Operators.Select<CoverageEligibilityRequest, CoverageEligibilityRequest>((IEnumerable<CoverageEligibilityRequest>)vzr_, vzs_);
        IEnumerable<CoverageEligibilityRequest> vzu_ = context.Operators.Distinct<CoverageEligibilityRequest>(vzt_);
        CoverageEligibilityRequest vzv_ = context.Operators.SingletonFrom<CoverageEligibilityRequest>(vzu_);

        return vzv_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public CoverageEligibilityResponse CoverageEligibilityResponseResource(CqlContext context, CoverageEligibilityResponse arg)
    {
        CoverageEligibilityResponse[] wzl_ = [
            arg,
        ];
        CoverageEligibilityResponse wzm_(CoverageEligibilityResponse a)
        {
            List<Identifier> wzq_ = a?.Identifier;
            Code<FinancialResourceStatusCodes> wzr_ = a?.StatusElement;
            List<Code<CoverageEligibilityResponse.EligibilityResponsePurpose>> wzs_ = a?.PurposeElement;
            ResourceReference wzt_ = a?.Patient;
            DataType wzu_ = a?.Serviced;
            FhirDateTime wzv_ = a?.CreatedElement;
            ResourceReference wzw_ = a?.Requestor;
            ResourceReference wzx_ = a?.Request;
            Code<ClaimProcessingCodes> wzy_ = a?.OutcomeElement;
            FhirString wzz_ = a?.DispositionElement;
            ResourceReference xza_ = a?.Insurer;
            List<CoverageEligibilityResponse.InsuranceComponent> xzb_ = a?.Insurance;
            FhirString xzc_ = a?.PreAuthRefElement;
            CodeableConcept xzd_ = a?.Form;
            List<CoverageEligibilityResponse.ErrorsComponent> xze_ = a?.Error;
            CoverageEligibilityResponse xzf_ = new CoverageEligibilityResponse
            {
                Identifier = new List<Identifier>((IEnumerable<Identifier>)wzq_),
                StatusElement = wzr_,
                PurposeElement = new List<Code<CoverageEligibilityResponse.EligibilityResponsePurpose>>((IEnumerable<Code<CoverageEligibilityResponse.EligibilityResponsePurpose>>)wzs_),
                Patient = wzt_,
                Serviced = (DataType)wzu_,
                CreatedElement = wzv_,
                Requestor = wzw_,
                Request = wzx_,
                OutcomeElement = wzy_,
                DispositionElement = wzz_,
                Insurer = xza_,
                Insurance = new List<CoverageEligibilityResponse.InsuranceComponent>((IEnumerable<CoverageEligibilityResponse.InsuranceComponent>)xzb_),
                PreAuthRefElement = xzc_,
                Form = xzd_,
                Error = new List<CoverageEligibilityResponse.ErrorsComponent>((IEnumerable<CoverageEligibilityResponse.ErrorsComponent>)xze_),
            };

            return xzf_;
        };
        IEnumerable<CoverageEligibilityResponse> wzn_ = context.Operators.Select<CoverageEligibilityResponse, CoverageEligibilityResponse>((IEnumerable<CoverageEligibilityResponse>)wzl_, wzm_);
        IEnumerable<CoverageEligibilityResponse> wzo_ = context.Operators.Distinct<CoverageEligibilityResponse>(wzn_);
        CoverageEligibilityResponse wzp_ = context.Operators.SingletonFrom<CoverageEligibilityResponse>(wzo_);

        return wzp_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public DetectedIssue DetectedIssueResource(CqlContext context, DetectedIssue arg)
    {
        DetectedIssue[] xzg_ = [
            arg,
        ];
        DetectedIssue xzh_(DetectedIssue a)
        {
            List<Identifier> xzl_ = a?.Identifier;
            Code<ObservationStatus> xzm_ = a?.StatusElement;
            CodeableConcept xzn_ = a?.Code;
            Code<DetectedIssue.DetectedIssueSeverity> xzo_ = a?.SeverityElement;
            ResourceReference xzp_ = a?.Patient;
            DataType xzq_ = a?.Identified;
            ResourceReference xzr_ = a?.Author;
            List<ResourceReference> xzs_ = a?.Implicated;
            List<DetectedIssue.EvidenceComponent> xzt_ = a?.Evidence;
            FhirString xzu_ = a?.DetailElement;
            FhirUri xzv_ = a?.ReferenceElement;
            List<DetectedIssue.MitigationComponent> xzw_ = a?.Mitigation;
            DetectedIssue xzx_ = new DetectedIssue
            {
                Identifier = new List<Identifier>((IEnumerable<Identifier>)xzl_),
                StatusElement = xzm_,
                Code = xzn_,
                SeverityElement = xzo_,
                Patient = xzp_,
                Identified = (DataType)xzq_,
                Author = xzr_,
                Implicated = new List<ResourceReference>((IEnumerable<ResourceReference>)xzs_),
                Evidence = new List<DetectedIssue.EvidenceComponent>((IEnumerable<DetectedIssue.EvidenceComponent>)xzt_),
                DetailElement = xzu_,
                ReferenceElement = xzv_,
                Mitigation = new List<DetectedIssue.MitigationComponent>((IEnumerable<DetectedIssue.MitigationComponent>)xzw_),
            };

            return xzx_;
        };
        IEnumerable<DetectedIssue> xzi_ = context.Operators.Select<DetectedIssue, DetectedIssue>((IEnumerable<DetectedIssue>)xzg_, xzh_);
        IEnumerable<DetectedIssue> xzj_ = context.Operators.Distinct<DetectedIssue>(xzi_);
        DetectedIssue xzk_ = context.Operators.SingletonFrom<DetectedIssue>(xzj_);

        return xzk_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public Device DeviceResource(CqlContext context, Device arg)
    {
        Device[] xzy_ = [
            arg,
        ];
        Device xzz_(Device a)
        {
            List<Identifier> yzd_ = a?.Identifier;
            ResourceReference yze_ = a?.Definition;
            List<Device.UdiCarrierComponent> yzf_ = a?.UdiCarrier;
            Code<Device.FHIRDeviceStatus> yzg_ = a?.StatusElement;
            List<CodeableConcept> yzh_ = a?.StatusReason;
            FhirString yzi_ = a?.DistinctIdentifierElement;
            FhirString yzj_ = a?.ManufacturerElement;
            FhirDateTime yzk_ = a?.ManufactureDateElement;
            FhirDateTime yzl_ = a?.ExpirationDateElement;
            FhirString yzm_ = a?.LotNumberElement;
            FhirString yzn_ = a?.SerialNumberElement;
            List<Device.DeviceNameComponent> yzo_ = a?.DeviceName;
            FhirString yzp_ = a?.ModelNumberElement;
            FhirString yzq_ = a?.PartNumberElement;
            CodeableConcept yzr_ = a?.Type;
            List<Device.SpecializationComponent> yzs_ = a?.Specialization;
            List<Device.VersionComponent> yzt_ = a?.Version;
            List<Device.PropertyComponent> yzu_ = a?.Property;
            ResourceReference yzv_ = a?.Patient;
            ResourceReference yzw_ = a?.Owner;
            List<ContactPoint> yzx_ = a?.Contact;
            ResourceReference yzy_ = a?.Location;
            FhirUri yzz_ = a?.UrlElement;
            List<Annotation> zza_ = a?.Note;
            List<CodeableConcept> zzb_ = a?.Safety;
            ResourceReference zzc_ = a?.Parent;
            Device zzd_ = new Device
            {
                Identifier = new List<Identifier>((IEnumerable<Identifier>)yzd_),
                Definition = yze_,
                UdiCarrier = new List<Device.UdiCarrierComponent>((IEnumerable<Device.UdiCarrierComponent>)yzf_),
                StatusElement = yzg_,
                StatusReason = new List<CodeableConcept>((IEnumerable<CodeableConcept>)yzh_),
                DistinctIdentifierElement = yzi_,
                ManufacturerElement = yzj_,
                ManufactureDateElement = yzk_,
                ExpirationDateElement = yzl_,
                LotNumberElement = yzm_,
                SerialNumberElement = yzn_,
                DeviceName = new List<Device.DeviceNameComponent>((IEnumerable<Device.DeviceNameComponent>)yzo_),
                ModelNumberElement = yzp_,
                PartNumberElement = yzq_,
                Type = yzr_,
                Specialization = new List<Device.SpecializationComponent>((IEnumerable<Device.SpecializationComponent>)yzs_),
                Version = new List<Device.VersionComponent>((IEnumerable<Device.VersionComponent>)yzt_),
                Property = new List<Device.PropertyComponent>((IEnumerable<Device.PropertyComponent>)yzu_),
                Patient = yzv_,
                Owner = yzw_,
                Contact = new List<ContactPoint>((IEnumerable<ContactPoint>)yzx_),
                Location = yzy_,
                UrlElement = yzz_,
                Note = new List<Annotation>((IEnumerable<Annotation>)zza_),
                Safety = new List<CodeableConcept>((IEnumerable<CodeableConcept>)zzb_),
                Parent = zzc_,
            };

            return zzd_;
        };
        IEnumerable<Device> yza_ = context.Operators.Select<Device, Device>((IEnumerable<Device>)xzy_, xzz_);
        IEnumerable<Device> yzb_ = context.Operators.Distinct<Device>(yza_);
        Device yzc_ = context.Operators.SingletonFrom<Device>(yzb_);

        return yzc_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public DeviceDefinition DeviceDefinitionResource(CqlContext context, DeviceDefinition arg)
    {
        DeviceDefinition[] zze_ = [
            arg,
        ];
        DeviceDefinition zzf_(DeviceDefinition a)
        {
            List<Identifier> zzj_ = a?.Identifier;
            List<DeviceDefinition.UdiDeviceIdentifierComponent> zzk_ = a?.UdiDeviceIdentifier;
            DataType zzl_ = a?.Manufacturer;
            List<DeviceDefinition.DeviceNameComponent> zzm_ = a?.DeviceName;
            FhirString zzn_ = a?.ModelNumberElement;
            CodeableConcept zzo_ = a?.Type;
            List<DeviceDefinition.SpecializationComponent> zzp_ = a?.Specialization;
            List<FhirString> zzq_ = a?.VersionElement;
            List<CodeableConcept> zzr_ = a?.Safety;
            List<ProductShelfLife> zzs_ = a?.ShelfLifeStorage;
            ProdCharacteristic zzt_ = a?.PhysicalCharacteristics;
            List<CodeableConcept> zzu_ = a?.LanguageCode;
            List<DeviceDefinition.CapabilityComponent> zzv_ = a?.Capability;
            List<DeviceDefinition.PropertyComponent> zzw_ = a?.Property;
            ResourceReference zzx_ = a?.Owner;
            List<ContactPoint> zzy_ = a?.Contact;
            FhirUri zzz_ = a?.UrlElement;
            FhirUri azza_ = a?.OnlineInformationElement;
            List<Annotation> azzb_ = a?.Note;
            Quantity azzc_ = a?.Quantity;
            ResourceReference azzd_ = a?.ParentDevice;
            List<DeviceDefinition.MaterialComponent> azze_ = a?.Material;
            DeviceDefinition azzf_ = new DeviceDefinition
            {
                Identifier = new List<Identifier>((IEnumerable<Identifier>)zzj_),
                UdiDeviceIdentifier = new List<DeviceDefinition.UdiDeviceIdentifierComponent>((IEnumerable<DeviceDefinition.UdiDeviceIdentifierComponent>)zzk_),
                Manufacturer = (DataType)zzl_,
                DeviceName = new List<DeviceDefinition.DeviceNameComponent>((IEnumerable<DeviceDefinition.DeviceNameComponent>)zzm_),
                ModelNumberElement = zzn_,
                Type = zzo_,
                Specialization = new List<DeviceDefinition.SpecializationComponent>((IEnumerable<DeviceDefinition.SpecializationComponent>)zzp_),
                VersionElement = new List<FhirString>((IEnumerable<FhirString>)zzq_),
                Safety = new List<CodeableConcept>((IEnumerable<CodeableConcept>)zzr_),
                ShelfLifeStorage = new List<ProductShelfLife>((IEnumerable<ProductShelfLife>)zzs_),
                PhysicalCharacteristics = zzt_,
                LanguageCode = new List<CodeableConcept>((IEnumerable<CodeableConcept>)zzu_),
                Capability = new List<DeviceDefinition.CapabilityComponent>((IEnumerable<DeviceDefinition.CapabilityComponent>)zzv_),
                Property = new List<DeviceDefinition.PropertyComponent>((IEnumerable<DeviceDefinition.PropertyComponent>)zzw_),
                Owner = zzx_,
                Contact = new List<ContactPoint>((IEnumerable<ContactPoint>)zzy_),
                UrlElement = zzz_,
                OnlineInformationElement = azza_,
                Note = new List<Annotation>((IEnumerable<Annotation>)azzb_),
                Quantity = azzc_,
                ParentDevice = azzd_,
                Material = new List<DeviceDefinition.MaterialComponent>((IEnumerable<DeviceDefinition.MaterialComponent>)azze_),
            };

            return azzf_;
        };
        IEnumerable<DeviceDefinition> zzg_ = context.Operators.Select<DeviceDefinition, DeviceDefinition>((IEnumerable<DeviceDefinition>)zze_, zzf_);
        IEnumerable<DeviceDefinition> zzh_ = context.Operators.Distinct<DeviceDefinition>(zzg_);
        DeviceDefinition zzi_ = context.Operators.SingletonFrom<DeviceDefinition>(zzh_);

        return zzi_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public DeviceMetric DeviceMetricResource(CqlContext context, DeviceMetric arg)
    {
        DeviceMetric[] azzg_ = [
            arg,
        ];
        DeviceMetric azzh_(DeviceMetric a)
        {
            List<Identifier> azzl_ = a?.Identifier;
            CodeableConcept azzm_ = a?.Type;
            CodeableConcept azzn_ = a?.Unit;
            ResourceReference azzo_ = a?.Source;
            ResourceReference azzp_ = a?.Parent;
            Code<DeviceMetric.DeviceMetricOperationalStatus> azzq_ = a?.OperationalStatusElement;
            Code<DeviceMetric.DeviceMetricColor> azzr_ = a?.ColorElement;
            Code<DeviceMetric.DeviceMetricCategory> azzs_ = a?.CategoryElement;
            Timing azzt_ = a?.MeasurementPeriod;
            List<DeviceMetric.CalibrationComponent> azzu_ = a?.Calibration;
            DeviceMetric azzv_ = new DeviceMetric
            {
                Identifier = new List<Identifier>((IEnumerable<Identifier>)azzl_),
                Type = azzm_,
                Unit = azzn_,
                Source = azzo_,
                Parent = azzp_,
                OperationalStatusElement = azzq_,
                ColorElement = azzr_,
                CategoryElement = azzs_,
                MeasurementPeriod = azzt_,
                Calibration = new List<DeviceMetric.CalibrationComponent>((IEnumerable<DeviceMetric.CalibrationComponent>)azzu_),
            };

            return azzv_;
        };
        IEnumerable<DeviceMetric> azzi_ = context.Operators.Select<DeviceMetric, DeviceMetric>((IEnumerable<DeviceMetric>)azzg_, azzh_);
        IEnumerable<DeviceMetric> azzj_ = context.Operators.Distinct<DeviceMetric>(azzi_);
        DeviceMetric azzk_ = context.Operators.SingletonFrom<DeviceMetric>(azzj_);

        return azzk_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public DeviceRequest DeviceRequestResource(CqlContext context, DeviceRequest arg)
    {
        DeviceRequest[] azzw_ = [
            arg,
        ];
        DeviceRequest azzx_(DeviceRequest a)
        {
            List<Identifier> bzzb_ = a?.Identifier;
            List<Canonical> bzzc_ = a?.InstantiatesCanonicalElement;
            List<FhirUri> bzzd_ = a?.InstantiatesUriElement;
            List<ResourceReference> bzze_ = a?.BasedOn;
            List<ResourceReference> bzzf_ = a?.PriorRequest;
            Identifier bzzg_ = a?.GroupIdentifier;
            Code<RequestStatus> bzzh_ = a?.StatusElement;
            Code<RequestIntent> bzzi_ = a?.IntentElement;
            Code<RequestPriority> bzzj_ = a?.PriorityElement;
            DataType bzzk_ = a?.Code;
            List<DeviceRequest.ParameterComponent> bzzl_ = a?.Parameter;
            ResourceReference bzzm_ = a?.Subject;
            ResourceReference bzzn_ = a?.Encounter;
            DataType bzzo_ = a?.Occurrence;
            FhirDateTime bzzp_ = a?.AuthoredOnElement;
            ResourceReference bzzq_ = a?.Requester;
            CodeableConcept bzzr_ = a?.PerformerType;
            ResourceReference bzzs_ = a?.Performer;
            List<CodeableConcept> bzzt_ = a?.ReasonCode;
            List<ResourceReference> bzzu_ = a?.ReasonReference;
            List<ResourceReference> bzzv_ = a?.Insurance;
            List<ResourceReference> bzzw_ = a?.SupportingInfo;
            List<Annotation> bzzx_ = a?.Note;
            List<ResourceReference> bzzy_ = a?.RelevantHistory;
            DeviceRequest bzzz_ = new DeviceRequest
            {
                Identifier = new List<Identifier>((IEnumerable<Identifier>)bzzb_),
                InstantiatesCanonicalElement = new List<Canonical>((IEnumerable<Canonical>)bzzc_),
                InstantiatesUriElement = new List<FhirUri>((IEnumerable<FhirUri>)bzzd_),
                BasedOn = new List<ResourceReference>((IEnumerable<ResourceReference>)bzze_),
                PriorRequest = new List<ResourceReference>((IEnumerable<ResourceReference>)bzzf_),
                GroupIdentifier = bzzg_,
                StatusElement = bzzh_,
                IntentElement = bzzi_,
                PriorityElement = bzzj_,
                Code = (DataType)bzzk_,
                Parameter = new List<DeviceRequest.ParameterComponent>((IEnumerable<DeviceRequest.ParameterComponent>)bzzl_),
                Subject = bzzm_,
                Encounter = bzzn_,
                Occurrence = (DataType)bzzo_,
                AuthoredOnElement = bzzp_,
                Requester = bzzq_,
                PerformerType = bzzr_,
                Performer = bzzs_,
                ReasonCode = new List<CodeableConcept>((IEnumerable<CodeableConcept>)bzzt_),
                ReasonReference = new List<ResourceReference>((IEnumerable<ResourceReference>)bzzu_),
                Insurance = new List<ResourceReference>((IEnumerable<ResourceReference>)bzzv_),
                SupportingInfo = new List<ResourceReference>((IEnumerable<ResourceReference>)bzzw_),
                Note = new List<Annotation>((IEnumerable<Annotation>)bzzx_),
                RelevantHistory = new List<ResourceReference>((IEnumerable<ResourceReference>)bzzy_),
            };

            return bzzz_;
        };
        IEnumerable<DeviceRequest> azzy_ = context.Operators.Select<DeviceRequest, DeviceRequest>((IEnumerable<DeviceRequest>)azzw_, azzx_);
        IEnumerable<DeviceRequest> azzz_ = context.Operators.Distinct<DeviceRequest>(azzy_);
        DeviceRequest bzza_ = context.Operators.SingletonFrom<DeviceRequest>(azzz_);

        return bzza_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public DeviceUseStatement DeviceUseStatementResource(CqlContext context, DeviceUseStatement arg)
    {
        DeviceUseStatement[] czza_ = [
            arg,
        ];
        DeviceUseStatement czzb_(DeviceUseStatement a)
        {
            List<Identifier> czzf_ = a?.Identifier;
            List<ResourceReference> czzg_ = a?.BasedOn;
            Code<DeviceUseStatement.DeviceUseStatementStatus> czzh_ = a?.StatusElement;
            ResourceReference czzi_ = a?.Subject;
            List<ResourceReference> czzj_ = a?.DerivedFrom;
            DataType czzk_ = a?.Timing;
            FhirDateTime czzl_ = a?.RecordedOnElement;
            ResourceReference czzm_ = a?.Source;
            ResourceReference czzn_ = a?.Device;
            List<CodeableConcept> czzo_ = a?.ReasonCode;
            List<ResourceReference> czzp_ = a?.ReasonReference;
            CodeableConcept czzq_ = a?.BodySite;
            List<Annotation> czzr_ = a?.Note;
            DeviceUseStatement czzs_ = new DeviceUseStatement
            {
                Identifier = new List<Identifier>((IEnumerable<Identifier>)czzf_),
                BasedOn = new List<ResourceReference>((IEnumerable<ResourceReference>)czzg_),
                StatusElement = czzh_,
                Subject = czzi_,
                DerivedFrom = new List<ResourceReference>((IEnumerable<ResourceReference>)czzj_),
                Timing = (DataType)czzk_,
                RecordedOnElement = czzl_,
                Source = czzm_,
                Device = czzn_,
                ReasonCode = new List<CodeableConcept>((IEnumerable<CodeableConcept>)czzo_),
                ReasonReference = new List<ResourceReference>((IEnumerable<ResourceReference>)czzp_),
                BodySite = czzq_,
                Note = new List<Annotation>((IEnumerable<Annotation>)czzr_),
            };

            return czzs_;
        };
        IEnumerable<DeviceUseStatement> czzc_ = context.Operators.Select<DeviceUseStatement, DeviceUseStatement>((IEnumerable<DeviceUseStatement>)czza_, czzb_);
        IEnumerable<DeviceUseStatement> czzd_ = context.Operators.Distinct<DeviceUseStatement>(czzc_);
        DeviceUseStatement czze_ = context.Operators.SingletonFrom<DeviceUseStatement>(czzd_);

        return czze_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public DiagnosticReport DiagnosticReportResource(CqlContext context, DiagnosticReport arg)
    {
        DiagnosticReport[] czzt_ = [
            arg,
        ];
        DiagnosticReport czzu_(DiagnosticReport a)
        {
            List<Identifier> czzy_ = a?.Identifier;
            List<ResourceReference> czzz_ = a?.BasedOn;
            Code<DiagnosticReport.DiagnosticReportStatus> dzza_ = a?.StatusElement;
            List<CodeableConcept> dzzb_ = a?.Category;
            CodeableConcept dzzc_ = a?.Code;
            ResourceReference dzzd_ = a?.Subject;
            ResourceReference dzze_ = a?.Encounter;
            DataType dzzf_ = a?.Effective;
            Instant dzzg_ = a?.IssuedElement;
            List<ResourceReference> dzzh_ = a?.Performer;
            List<ResourceReference> dzzi_ = a?.ResultsInterpreter;
            List<ResourceReference> dzzj_ = a?.Specimen;
            List<ResourceReference> dzzk_ = a?.Result;
            List<ResourceReference> dzzl_ = a?.ImagingStudy;
            List<DiagnosticReport.MediaComponent> dzzm_ = a?.Media;
            FhirString dzzn_ = a?.ConclusionElement;
            List<CodeableConcept> dzzo_ = a?.ConclusionCode;
            List<Attachment> dzzp_ = a?.PresentedForm;
            DiagnosticReport dzzq_ = new DiagnosticReport
            {
                Identifier = new List<Identifier>((IEnumerable<Identifier>)czzy_),
                BasedOn = new List<ResourceReference>((IEnumerable<ResourceReference>)czzz_),
                StatusElement = dzza_,
                Category = new List<CodeableConcept>((IEnumerable<CodeableConcept>)dzzb_),
                Code = dzzc_,
                Subject = dzzd_,
                Encounter = dzze_,
                Effective = (DataType)dzzf_,
                IssuedElement = dzzg_,
                Performer = new List<ResourceReference>((IEnumerable<ResourceReference>)dzzh_),
                ResultsInterpreter = new List<ResourceReference>((IEnumerable<ResourceReference>)dzzi_),
                Specimen = new List<ResourceReference>((IEnumerable<ResourceReference>)dzzj_),
                Result = new List<ResourceReference>((IEnumerable<ResourceReference>)dzzk_),
                ImagingStudy = new List<ResourceReference>((IEnumerable<ResourceReference>)dzzl_),
                Media = new List<DiagnosticReport.MediaComponent>((IEnumerable<DiagnosticReport.MediaComponent>)dzzm_),
                ConclusionElement = dzzn_,
                ConclusionCode = new List<CodeableConcept>((IEnumerable<CodeableConcept>)dzzo_),
                PresentedForm = new List<Attachment>((IEnumerable<Attachment>)dzzp_),
            };

            return dzzq_;
        };
        IEnumerable<DiagnosticReport> czzv_ = context.Operators.Select<DiagnosticReport, DiagnosticReport>((IEnumerable<DiagnosticReport>)czzt_, czzu_);
        IEnumerable<DiagnosticReport> czzw_ = context.Operators.Distinct<DiagnosticReport>(czzv_);
        DiagnosticReport czzx_ = context.Operators.SingletonFrom<DiagnosticReport>(czzw_);

        return czzx_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public DocumentManifest DocumentManifestResource(CqlContext context, DocumentManifest arg)
    {
        DocumentManifest[] dzzr_ = [
            arg,
        ];
        DocumentManifest dzzs_(DocumentManifest a)
        {
            Identifier dzzw_ = a?.MasterIdentifier;
            List<Identifier> dzzx_ = a?.Identifier;
            Code<DocumentReferenceStatus> dzzy_ = a?.StatusElement;
            CodeableConcept dzzz_ = a?.Type;
            ResourceReference ezza_ = a?.Subject;
            FhirDateTime ezzb_ = a?.CreatedElement;
            List<ResourceReference> ezzc_ = a?.Author;
            List<ResourceReference> ezzd_ = a?.Recipient;
            FhirUri ezze_ = a?.SourceElement;
            FhirString ezzf_ = a?.DescriptionElement;
            List<ResourceReference> ezzg_ = a?.Content;
            List<DocumentManifest.RelatedComponent> ezzh_ = a?.Related;
            DocumentManifest ezzi_ = new DocumentManifest
            {
                MasterIdentifier = dzzw_,
                Identifier = new List<Identifier>((IEnumerable<Identifier>)dzzx_),
                StatusElement = dzzy_,
                Type = dzzz_,
                Subject = ezza_,
                CreatedElement = ezzb_,
                Author = new List<ResourceReference>((IEnumerable<ResourceReference>)ezzc_),
                Recipient = new List<ResourceReference>((IEnumerable<ResourceReference>)ezzd_),
                SourceElement = ezze_,
                DescriptionElement = ezzf_,
                Content = new List<ResourceReference>((IEnumerable<ResourceReference>)ezzg_),
                Related = new List<DocumentManifest.RelatedComponent>((IEnumerable<DocumentManifest.RelatedComponent>)ezzh_),
            };

            return ezzi_;
        };
        IEnumerable<DocumentManifest> dzzt_ = context.Operators.Select<DocumentManifest, DocumentManifest>((IEnumerable<DocumentManifest>)dzzr_, dzzs_);
        IEnumerable<DocumentManifest> dzzu_ = context.Operators.Distinct<DocumentManifest>(dzzt_);
        DocumentManifest dzzv_ = context.Operators.SingletonFrom<DocumentManifest>(dzzu_);

        return dzzv_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public DocumentReference DocumentReferenceResource(CqlContext context, DocumentReference arg)
    {
        DocumentReference[] ezzj_ = [
            arg,
        ];
        DocumentReference ezzk_(DocumentReference a)
        {
            Identifier ezzo_ = a?.MasterIdentifier;
            List<Identifier> ezzp_ = a?.Identifier;
            Code<DocumentReferenceStatus> ezzq_ = a?.StatusElement;
            Code<CompositionStatus> ezzr_ = a?.DocStatusElement;
            CodeableConcept ezzs_ = a?.Type;
            List<CodeableConcept> ezzt_ = a?.Category;
            ResourceReference ezzu_ = a?.Subject;
            Instant ezzv_ = a?.DateElement;
            List<ResourceReference> ezzw_ = a?.Author;
            ResourceReference ezzx_ = a?.Authenticator;
            ResourceReference ezzy_ = a?.Custodian;
            List<DocumentReference.RelatesToComponent> ezzz_ = a?.RelatesTo;
            FhirString fzza_ = a?.DescriptionElement;
            List<CodeableConcept> fzzb_ = a?.SecurityLabel;
            List<DocumentReference.ContentComponent> fzzc_ = a?.Content;
            DocumentReference.ContextComponent fzzd_ = a?.Context;
            DocumentReference fzze_ = new DocumentReference
            {
                MasterIdentifier = ezzo_,
                Identifier = new List<Identifier>((IEnumerable<Identifier>)ezzp_),
                StatusElement = ezzq_,
                DocStatusElement = ezzr_,
                Type = ezzs_,
                Category = new List<CodeableConcept>((IEnumerable<CodeableConcept>)ezzt_),
                Subject = ezzu_,
                DateElement = ezzv_,
                Author = new List<ResourceReference>((IEnumerable<ResourceReference>)ezzw_),
                Authenticator = ezzx_,
                Custodian = ezzy_,
                RelatesTo = new List<DocumentReference.RelatesToComponent>((IEnumerable<DocumentReference.RelatesToComponent>)ezzz_),
                DescriptionElement = fzza_,
                SecurityLabel = new List<CodeableConcept>((IEnumerable<CodeableConcept>)fzzb_),
                Content = new List<DocumentReference.ContentComponent>((IEnumerable<DocumentReference.ContentComponent>)fzzc_),
                Context = fzzd_,
            };

            return fzze_;
        };
        IEnumerable<DocumentReference> ezzl_ = context.Operators.Select<DocumentReference, DocumentReference>((IEnumerable<DocumentReference>)ezzj_, ezzk_);
        IEnumerable<DocumentReference> ezzm_ = context.Operators.Distinct<DocumentReference>(ezzl_);
        DocumentReference ezzn_ = context.Operators.SingletonFrom<DocumentReference>(ezzm_);

        return ezzn_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public EffectEvidenceSynthesis EffectEvidenceSynthesisResource(CqlContext context, EffectEvidenceSynthesis arg)
    {
        EffectEvidenceSynthesis[] fzzf_ = [
            arg,
        ];
        EffectEvidenceSynthesis fzzg_(EffectEvidenceSynthesis a)
        {
            FhirUri fzzk_ = a?.UrlElement;
            List<Identifier> fzzl_ = a?.Identifier;
            FhirString fzzm_ = a?.VersionElement;
            FhirString fzzn_ = a?.NameElement;
            FhirString fzzo_ = a?.TitleElement;
            Code<PublicationStatus> fzzp_ = a?.StatusElement;
            FhirDateTime fzzq_ = a?.DateElement;
            FhirString fzzr_ = a?.PublisherElement;
            List<ContactDetail> fzzs_ = a?.Contact;
            Markdown fzzt_ = a?.DescriptionElement;
            List<Annotation> fzzu_ = a?.Note;
            List<UsageContext> fzzv_ = a?.UseContext;
            List<CodeableConcept> fzzw_ = a?.Jurisdiction;
            Markdown fzzx_ = a?.CopyrightElement;
            Date fzzy_ = a?.ApprovalDateElement;
            Date fzzz_ = a?.LastReviewDateElement;
            Period gzza_ = a?.EffectivePeriod;
            List<CodeableConcept> gzzb_ = a?.Topic;
            List<ContactDetail> gzzc_ = a?.Author;
            List<ContactDetail> gzzd_ = a?.Editor;
            List<ContactDetail> gzze_ = a?.Reviewer;
            List<ContactDetail> gzzf_ = a?.Endorser;
            List<RelatedArtifact> gzzg_ = a?.RelatedArtifact;
            CodeableConcept gzzh_ = a?.SynthesisType;
            CodeableConcept gzzi_ = a?.StudyType;
            ResourceReference gzzj_ = a?.Population;
            ResourceReference gzzk_ = a?.Exposure;
            ResourceReference gzzl_ = a?.ExposureAlternative;
            ResourceReference gzzm_ = a?.Outcome;
            EffectEvidenceSynthesis.SampleSizeComponent gzzn_ = a?.SampleSize;
            List<EffectEvidenceSynthesis.ResultsByExposureComponent> gzzo_ = a?.ResultsByExposure;
            List<EffectEvidenceSynthesis.EffectEstimateComponent> gzzp_ = a?.EffectEstimate;
            List<EffectEvidenceSynthesis.CertaintyComponent> gzzq_ = a?.Certainty;
            EffectEvidenceSynthesis gzzr_ = new EffectEvidenceSynthesis
            {
                UrlElement = fzzk_,
                Identifier = new List<Identifier>((IEnumerable<Identifier>)fzzl_),
                VersionElement = fzzm_,
                NameElement = fzzn_,
                TitleElement = fzzo_,
                StatusElement = fzzp_,
                DateElement = fzzq_,
                PublisherElement = fzzr_,
                Contact = new List<ContactDetail>((IEnumerable<ContactDetail>)fzzs_),
                DescriptionElement = fzzt_,
                Note = new List<Annotation>((IEnumerable<Annotation>)fzzu_),
                UseContext = new List<UsageContext>((IEnumerable<UsageContext>)fzzv_),
                Jurisdiction = new List<CodeableConcept>((IEnumerable<CodeableConcept>)fzzw_),
                CopyrightElement = fzzx_,
                ApprovalDateElement = fzzy_,
                LastReviewDateElement = fzzz_,
                EffectivePeriod = gzza_,
                Topic = new List<CodeableConcept>((IEnumerable<CodeableConcept>)gzzb_),
                Author = new List<ContactDetail>((IEnumerable<ContactDetail>)gzzc_),
                Editor = new List<ContactDetail>((IEnumerable<ContactDetail>)gzzd_),
                Reviewer = new List<ContactDetail>((IEnumerable<ContactDetail>)gzze_),
                Endorser = new List<ContactDetail>((IEnumerable<ContactDetail>)gzzf_),
                RelatedArtifact = new List<RelatedArtifact>((IEnumerable<RelatedArtifact>)gzzg_),
                SynthesisType = gzzh_,
                StudyType = gzzi_,
                Population = gzzj_,
                Exposure = gzzk_,
                ExposureAlternative = gzzl_,
                Outcome = gzzm_,
                SampleSize = gzzn_,
                ResultsByExposure = new List<EffectEvidenceSynthesis.ResultsByExposureComponent>((IEnumerable<EffectEvidenceSynthesis.ResultsByExposureComponent>)gzzo_),
                EffectEstimate = new List<EffectEvidenceSynthesis.EffectEstimateComponent>((IEnumerable<EffectEvidenceSynthesis.EffectEstimateComponent>)gzzp_),
                Certainty = new List<EffectEvidenceSynthesis.CertaintyComponent>((IEnumerable<EffectEvidenceSynthesis.CertaintyComponent>)gzzq_),
            };

            return gzzr_;
        };
        IEnumerable<EffectEvidenceSynthesis> fzzh_ = context.Operators.Select<EffectEvidenceSynthesis, EffectEvidenceSynthesis>((IEnumerable<EffectEvidenceSynthesis>)fzzf_, fzzg_);
        IEnumerable<EffectEvidenceSynthesis> fzzi_ = context.Operators.Distinct<EffectEvidenceSynthesis>(fzzh_);
        EffectEvidenceSynthesis fzzj_ = context.Operators.SingletonFrom<EffectEvidenceSynthesis>(fzzi_);

        return fzzj_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public Encounter EncounterResource(CqlContext context, Encounter arg)
    {
        Encounter[] gzzs_ = [
            arg,
        ];
        Encounter gzzt_(Encounter a)
        {
            List<Identifier> gzzx_ = a?.Identifier;
            Code<Encounter.EncounterStatus> gzzy_ = a?.StatusElement;
            List<Encounter.StatusHistoryComponent> gzzz_ = a?.StatusHistory;
            Coding hzza_ = a?.Class;
            List<Encounter.ClassHistoryComponent> hzzb_ = a?.ClassHistory;
            List<CodeableConcept> hzzc_ = a?.Type;
            CodeableConcept hzzd_ = a?.ServiceType;
            CodeableConcept hzze_ = a?.Priority;
            ResourceReference hzzf_ = a?.Subject;
            List<ResourceReference> hzzg_ = a?.EpisodeOfCare;
            List<ResourceReference> hzzh_ = a?.BasedOn;
            List<Encounter.ParticipantComponent> hzzi_ = a?.Participant;
            List<ResourceReference> hzzj_ = a?.Appointment;
            Period hzzk_ = a?.Period;
            Duration hzzl_ = a?.Length;
            List<CodeableConcept> hzzm_ = a?.ReasonCode;
            List<ResourceReference> hzzn_ = a?.ReasonReference;
            List<Encounter.DiagnosisComponent> hzzo_ = a?.Diagnosis;
            List<ResourceReference> hzzp_ = a?.Account;
            Encounter.HospitalizationComponent hzzq_ = a?.Hospitalization;
            List<Encounter.LocationComponent> hzzr_ = a?.Location;
            ResourceReference hzzs_ = a?.ServiceProvider;
            ResourceReference hzzt_ = a?.PartOf;
            Encounter hzzu_ = new Encounter
            {
                Identifier = new List<Identifier>((IEnumerable<Identifier>)gzzx_),
                StatusElement = gzzy_,
                StatusHistory = new List<Encounter.StatusHistoryComponent>((IEnumerable<Encounter.StatusHistoryComponent>)gzzz_),
                Class = hzza_,
                ClassHistory = new List<Encounter.ClassHistoryComponent>((IEnumerable<Encounter.ClassHistoryComponent>)hzzb_),
                Type = new List<CodeableConcept>((IEnumerable<CodeableConcept>)hzzc_),
                ServiceType = hzzd_,
                Priority = hzze_,
                Subject = hzzf_,
                EpisodeOfCare = new List<ResourceReference>((IEnumerable<ResourceReference>)hzzg_),
                BasedOn = new List<ResourceReference>((IEnumerable<ResourceReference>)hzzh_),
                Participant = new List<Encounter.ParticipantComponent>((IEnumerable<Encounter.ParticipantComponent>)hzzi_),
                Appointment = new List<ResourceReference>((IEnumerable<ResourceReference>)hzzj_),
                Period = hzzk_,
                Length = hzzl_,
                ReasonCode = new List<CodeableConcept>((IEnumerable<CodeableConcept>)hzzm_),
                ReasonReference = new List<ResourceReference>((IEnumerable<ResourceReference>)hzzn_),
                Diagnosis = new List<Encounter.DiagnosisComponent>((IEnumerable<Encounter.DiagnosisComponent>)hzzo_),
                Account = new List<ResourceReference>((IEnumerable<ResourceReference>)hzzp_),
                Hospitalization = hzzq_,
                Location = new List<Encounter.LocationComponent>((IEnumerable<Encounter.LocationComponent>)hzzr_),
                ServiceProvider = hzzs_,
                PartOf = hzzt_,
            };

            return hzzu_;
        };
        IEnumerable<Encounter> gzzu_ = context.Operators.Select<Encounter, Encounter>((IEnumerable<Encounter>)gzzs_, gzzt_);
        IEnumerable<Encounter> gzzv_ = context.Operators.Distinct<Encounter>(gzzu_);
        Encounter gzzw_ = context.Operators.SingletonFrom<Encounter>(gzzv_);

        return gzzw_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public Endpoint EndpointResource(CqlContext context, Endpoint arg)
    {
        Endpoint[] hzzv_ = [
            arg,
        ];
        Endpoint hzzw_(Endpoint a)
        {
            List<Identifier> izza_ = a?.Identifier;
            Code<Endpoint.EndpointStatus> izzb_ = a?.StatusElement;
            Coding izzc_ = a?.ConnectionType;
            FhirString izzd_ = a?.NameElement;
            ResourceReference izze_ = a?.ManagingOrganization;
            List<ContactPoint> izzf_ = a?.Contact;
            Period izzg_ = a?.Period;
            List<CodeableConcept> izzh_ = a?.PayloadType;
            List<Code> izzi_ = a?.PayloadMimeTypeElement;
            FhirUrl izzj_ = a?.AddressElement;
            List<FhirString> izzk_ = a?.HeaderElement;
            Endpoint izzl_ = new Endpoint
            {
                Identifier = new List<Identifier>((IEnumerable<Identifier>)izza_),
                StatusElement = izzb_,
                ConnectionType = izzc_,
                NameElement = izzd_,
                ManagingOrganization = izze_,
                Contact = new List<ContactPoint>((IEnumerable<ContactPoint>)izzf_),
                Period = izzg_,
                PayloadType = new List<CodeableConcept>((IEnumerable<CodeableConcept>)izzh_),
                PayloadMimeTypeElement = new List<Code>((IEnumerable<Code>)izzi_),
                AddressElement = izzj_,
                HeaderElement = new List<FhirString>((IEnumerable<FhirString>)izzk_),
            };

            return izzl_;
        };
        IEnumerable<Endpoint> hzzx_ = context.Operators.Select<Endpoint, Endpoint>((IEnumerable<Endpoint>)hzzv_, hzzw_);
        IEnumerable<Endpoint> hzzy_ = context.Operators.Distinct<Endpoint>(hzzx_);
        Endpoint hzzz_ = context.Operators.SingletonFrom<Endpoint>(hzzy_);

        return hzzz_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public EnrollmentRequest EnrollmentRequestResource(CqlContext context, EnrollmentRequest arg)
    {
        EnrollmentRequest[] izzm_ = [
            arg,
        ];
        EnrollmentRequest izzn_(EnrollmentRequest a)
        {
            List<Identifier> izzr_ = a?.Identifier;
            Code<FinancialResourceStatusCodes> izzs_ = a?.StatusElement;
            FhirDateTime izzt_ = a?.CreatedElement;
            ResourceReference izzu_ = a?.Insurer;
            ResourceReference izzv_ = a?.Provider;
            ResourceReference izzw_ = a?.Candidate;
            ResourceReference izzx_ = a?.Coverage;
            EnrollmentRequest izzy_ = new EnrollmentRequest
            {
                Identifier = new List<Identifier>((IEnumerable<Identifier>)izzr_),
                StatusElement = izzs_,
                CreatedElement = izzt_,
                Insurer = izzu_,
                Provider = izzv_,
                Candidate = izzw_,
                Coverage = izzx_,
            };

            return izzy_;
        };
        IEnumerable<EnrollmentRequest> izzo_ = context.Operators.Select<EnrollmentRequest, EnrollmentRequest>((IEnumerable<EnrollmentRequest>)izzm_, izzn_);
        IEnumerable<EnrollmentRequest> izzp_ = context.Operators.Distinct<EnrollmentRequest>(izzo_);
        EnrollmentRequest izzq_ = context.Operators.SingletonFrom<EnrollmentRequest>(izzp_);

        return izzq_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public EnrollmentResponse EnrollmentResponseResource(CqlContext context, EnrollmentResponse arg)
    {
        EnrollmentResponse[] izzz_ = [
            arg,
        ];
        EnrollmentResponse jzza_(EnrollmentResponse a)
        {
            List<Identifier> jzze_ = a?.Identifier;
            Code<FinancialResourceStatusCodes> jzzf_ = a?.StatusElement;
            ResourceReference jzzg_ = a?.Request;
            Code<ClaimProcessingCodes> jzzh_ = a?.OutcomeElement;
            FhirString jzzi_ = a?.DispositionElement;
            FhirDateTime jzzj_ = a?.CreatedElement;
            ResourceReference jzzk_ = a?.Organization;
            ResourceReference jzzl_ = a?.RequestProvider;
            EnrollmentResponse jzzm_ = new EnrollmentResponse
            {
                Identifier = new List<Identifier>((IEnumerable<Identifier>)jzze_),
                StatusElement = jzzf_,
                Request = jzzg_,
                OutcomeElement = jzzh_,
                DispositionElement = jzzi_,
                CreatedElement = jzzj_,
                Organization = jzzk_,
                RequestProvider = jzzl_,
            };

            return jzzm_;
        };
        IEnumerable<EnrollmentResponse> jzzb_ = context.Operators.Select<EnrollmentResponse, EnrollmentResponse>((IEnumerable<EnrollmentResponse>)izzz_, jzza_);
        IEnumerable<EnrollmentResponse> jzzc_ = context.Operators.Distinct<EnrollmentResponse>(jzzb_);
        EnrollmentResponse jzzd_ = context.Operators.SingletonFrom<EnrollmentResponse>(jzzc_);

        return jzzd_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public EpisodeOfCare EpisodeOfCareResource(CqlContext context, EpisodeOfCare arg)
    {
        EpisodeOfCare[] jzzn_ = [
            arg,
        ];
        EpisodeOfCare jzzo_(EpisodeOfCare a)
        {
            List<Identifier> jzzs_ = a?.Identifier;
            Code<EpisodeOfCare.EpisodeOfCareStatus> jzzt_ = a?.StatusElement;
            List<EpisodeOfCare.StatusHistoryComponent> jzzu_ = a?.StatusHistory;
            List<CodeableConcept> jzzv_ = a?.Type;
            List<EpisodeOfCare.DiagnosisComponent> jzzw_ = a?.Diagnosis;
            ResourceReference jzzx_ = a?.Patient;
            ResourceReference jzzy_ = a?.ManagingOrganization;
            Period jzzz_ = a?.Period;
            List<ResourceReference> kzza_ = a?.ReferralRequest;
            ResourceReference kzzb_ = a?.CareManager;
            List<ResourceReference> kzzc_ = a?.Team;
            List<ResourceReference> kzzd_ = a?.Account;
            EpisodeOfCare kzze_ = new EpisodeOfCare
            {
                Identifier = new List<Identifier>((IEnumerable<Identifier>)jzzs_),
                StatusElement = jzzt_,
                StatusHistory = new List<EpisodeOfCare.StatusHistoryComponent>((IEnumerable<EpisodeOfCare.StatusHistoryComponent>)jzzu_),
                Type = new List<CodeableConcept>((IEnumerable<CodeableConcept>)jzzv_),
                Diagnosis = new List<EpisodeOfCare.DiagnosisComponent>((IEnumerable<EpisodeOfCare.DiagnosisComponent>)jzzw_),
                Patient = jzzx_,
                ManagingOrganization = jzzy_,
                Period = jzzz_,
                ReferralRequest = new List<ResourceReference>((IEnumerable<ResourceReference>)kzza_),
                CareManager = kzzb_,
                Team = new List<ResourceReference>((IEnumerable<ResourceReference>)kzzc_),
                Account = new List<ResourceReference>((IEnumerable<ResourceReference>)kzzd_),
            };

            return kzze_;
        };
        IEnumerable<EpisodeOfCare> jzzp_ = context.Operators.Select<EpisodeOfCare, EpisodeOfCare>((IEnumerable<EpisodeOfCare>)jzzn_, jzzo_);
        IEnumerable<EpisodeOfCare> jzzq_ = context.Operators.Distinct<EpisodeOfCare>(jzzp_);
        EpisodeOfCare jzzr_ = context.Operators.SingletonFrom<EpisodeOfCare>(jzzq_);

        return jzzr_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public EventDefinition EventDefinitionResource(CqlContext context, EventDefinition arg)
    {
        EventDefinition[] kzzf_ = [
            arg,
        ];
        EventDefinition kzzg_(EventDefinition a)
        {
            FhirUri kzzk_ = a?.UrlElement;
            List<Identifier> kzzl_ = a?.Identifier;
            FhirString kzzm_ = a?.VersionElement;
            FhirString kzzn_ = a?.NameElement;
            FhirString kzzo_ = a?.TitleElement;
            FhirString kzzp_ = a?.SubtitleElement;
            Code<PublicationStatus> kzzq_ = a?.StatusElement;
            FhirBoolean kzzr_ = a?.ExperimentalElement;
            DataType kzzs_ = a?.Subject;
            FhirDateTime kzzt_ = a?.DateElement;
            FhirString kzzu_ = a?.PublisherElement;
            List<ContactDetail> kzzv_ = a?.Contact;
            Markdown kzzw_ = a?.DescriptionElement;
            List<UsageContext> kzzx_ = a?.UseContext;
            List<CodeableConcept> kzzy_ = a?.Jurisdiction;
            Markdown kzzz_ = a?.PurposeElement;
            FhirString lzza_ = a?.UsageElement;
            Markdown lzzb_ = a?.CopyrightElement;
            Date lzzc_ = a?.ApprovalDateElement;
            Date lzzd_ = a?.LastReviewDateElement;
            Period lzze_ = a?.EffectivePeriod;
            List<CodeableConcept> lzzf_ = a?.Topic;
            List<ContactDetail> lzzg_ = a?.Author;
            List<ContactDetail> lzzh_ = a?.Editor;
            List<ContactDetail> lzzi_ = a?.Reviewer;
            List<ContactDetail> lzzj_ = a?.Endorser;
            List<RelatedArtifact> lzzk_ = a?.RelatedArtifact;
            List<TriggerDefinition> lzzl_ = a?.Trigger;
            EventDefinition lzzm_ = new EventDefinition
            {
                UrlElement = kzzk_,
                Identifier = new List<Identifier>((IEnumerable<Identifier>)kzzl_),
                VersionElement = kzzm_,
                NameElement = kzzn_,
                TitleElement = kzzo_,
                SubtitleElement = kzzp_,
                StatusElement = kzzq_,
                ExperimentalElement = kzzr_,
                Subject = (DataType)kzzs_,
                DateElement = kzzt_,
                PublisherElement = kzzu_,
                Contact = new List<ContactDetail>((IEnumerable<ContactDetail>)kzzv_),
                DescriptionElement = kzzw_,
                UseContext = new List<UsageContext>((IEnumerable<UsageContext>)kzzx_),
                Jurisdiction = new List<CodeableConcept>((IEnumerable<CodeableConcept>)kzzy_),
                PurposeElement = kzzz_,
                UsageElement = lzza_,
                CopyrightElement = lzzb_,
                ApprovalDateElement = lzzc_,
                LastReviewDateElement = lzzd_,
                EffectivePeriod = lzze_,
                Topic = new List<CodeableConcept>((IEnumerable<CodeableConcept>)lzzf_),
                Author = new List<ContactDetail>((IEnumerable<ContactDetail>)lzzg_),
                Editor = new List<ContactDetail>((IEnumerable<ContactDetail>)lzzh_),
                Reviewer = new List<ContactDetail>((IEnumerable<ContactDetail>)lzzi_),
                Endorser = new List<ContactDetail>((IEnumerable<ContactDetail>)lzzj_),
                RelatedArtifact = new List<RelatedArtifact>((IEnumerable<RelatedArtifact>)lzzk_),
                Trigger = new List<TriggerDefinition>((IEnumerable<TriggerDefinition>)lzzl_),
            };

            return lzzm_;
        };
        IEnumerable<EventDefinition> kzzh_ = context.Operators.Select<EventDefinition, EventDefinition>((IEnumerable<EventDefinition>)kzzf_, kzzg_);
        IEnumerable<EventDefinition> kzzi_ = context.Operators.Distinct<EventDefinition>(kzzh_);
        EventDefinition kzzj_ = context.Operators.SingletonFrom<EventDefinition>(kzzi_);

        return kzzj_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public Evidence EvidenceResource(CqlContext context, Evidence arg)
    {
        Evidence[] lzzn_ = [
            arg,
        ];
        Evidence lzzo_(Evidence a)
        {
            FhirUri lzzs_ = a?.UrlElement;
            List<Identifier> lzzt_ = a?.Identifier;
            FhirString lzzu_ = a?.VersionElement;
            FhirString lzzv_ = a?.NameElement;
            FhirString lzzw_ = a?.TitleElement;
            FhirString lzzx_ = a?.ShortTitleElement;
            FhirString lzzy_ = a?.SubtitleElement;
            Code<PublicationStatus> lzzz_ = a?.StatusElement;
            FhirDateTime mzza_ = a?.DateElement;
            FhirString mzzb_ = a?.PublisherElement;
            List<ContactDetail> mzzc_ = a?.Contact;
            Markdown mzzd_ = a?.DescriptionElement;
            List<Annotation> mzze_ = a?.Note;
            List<UsageContext> mzzf_ = a?.UseContext;
            List<CodeableConcept> mzzg_ = a?.Jurisdiction;
            Markdown mzzh_ = a?.CopyrightElement;
            Date mzzi_ = a?.ApprovalDateElement;
            Date mzzj_ = a?.LastReviewDateElement;
            Period mzzk_ = a?.EffectivePeriod;
            List<CodeableConcept> mzzl_ = a?.Topic;
            List<ContactDetail> mzzm_ = a?.Author;
            List<ContactDetail> mzzn_ = a?.Editor;
            List<ContactDetail> mzzo_ = a?.Reviewer;
            List<ContactDetail> mzzp_ = a?.Endorser;
            List<RelatedArtifact> mzzq_ = a?.RelatedArtifact;
            ResourceReference mzzr_ = a?.ExposureBackground;
            List<ResourceReference> mzzs_ = a?.ExposureVariant;
            List<ResourceReference> mzzt_ = a?.Outcome;
            Evidence mzzu_ = new Evidence
            {
                UrlElement = lzzs_,
                Identifier = new List<Identifier>((IEnumerable<Identifier>)lzzt_),
                VersionElement = lzzu_,
                NameElement = lzzv_,
                TitleElement = lzzw_,
                ShortTitleElement = lzzx_,
                SubtitleElement = lzzy_,
                StatusElement = lzzz_,
                DateElement = mzza_,
                PublisherElement = mzzb_,
                Contact = new List<ContactDetail>((IEnumerable<ContactDetail>)mzzc_),
                DescriptionElement = mzzd_,
                Note = new List<Annotation>((IEnumerable<Annotation>)mzze_),
                UseContext = new List<UsageContext>((IEnumerable<UsageContext>)mzzf_),
                Jurisdiction = new List<CodeableConcept>((IEnumerable<CodeableConcept>)mzzg_),
                CopyrightElement = mzzh_,
                ApprovalDateElement = mzzi_,
                LastReviewDateElement = mzzj_,
                EffectivePeriod = mzzk_,
                Topic = new List<CodeableConcept>((IEnumerable<CodeableConcept>)mzzl_),
                Author = new List<ContactDetail>((IEnumerable<ContactDetail>)mzzm_),
                Editor = new List<ContactDetail>((IEnumerable<ContactDetail>)mzzn_),
                Reviewer = new List<ContactDetail>((IEnumerable<ContactDetail>)mzzo_),
                Endorser = new List<ContactDetail>((IEnumerable<ContactDetail>)mzzp_),
                RelatedArtifact = new List<RelatedArtifact>((IEnumerable<RelatedArtifact>)mzzq_),
                ExposureBackground = mzzr_,
                ExposureVariant = new List<ResourceReference>((IEnumerable<ResourceReference>)mzzs_),
                Outcome = new List<ResourceReference>((IEnumerable<ResourceReference>)mzzt_),
            };

            return mzzu_;
        };
        IEnumerable<Evidence> lzzp_ = context.Operators.Select<Evidence, Evidence>((IEnumerable<Evidence>)lzzn_, lzzo_);
        IEnumerable<Evidence> lzzq_ = context.Operators.Distinct<Evidence>(lzzp_);
        Evidence lzzr_ = context.Operators.SingletonFrom<Evidence>(lzzq_);

        return lzzr_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public EvidenceVariable EvidenceVariableResource(CqlContext context, EvidenceVariable arg)
    {
        EvidenceVariable[] mzzv_ = [
            arg,
        ];
        EvidenceVariable mzzw_(EvidenceVariable a)
        {
            FhirUri nzza_ = a?.UrlElement;
            List<Identifier> nzzb_ = a?.Identifier;
            FhirString nzzc_ = a?.VersionElement;
            FhirString nzzd_ = a?.NameElement;
            FhirString nzze_ = a?.TitleElement;
            FhirString nzzf_ = a?.ShortTitleElement;
            FhirString nzzg_ = a?.SubtitleElement;
            Code<PublicationStatus> nzzh_ = a?.StatusElement;
            FhirDateTime nzzi_ = a?.DateElement;
            FhirString nzzj_ = a?.PublisherElement;
            List<ContactDetail> nzzk_ = a?.Contact;
            Markdown nzzl_ = a?.DescriptionElement;
            List<Annotation> nzzm_ = a?.Note;
            List<UsageContext> nzzn_ = a?.UseContext;
            List<CodeableConcept> nzzo_ = a?.Jurisdiction;
            Markdown nzzp_ = a?.CopyrightElement;
            Date nzzq_ = a?.ApprovalDateElement;
            Date nzzr_ = a?.LastReviewDateElement;
            Period nzzs_ = a?.EffectivePeriod;
            List<CodeableConcept> nzzt_ = a?.Topic;
            List<ContactDetail> nzzu_ = a?.Author;
            List<ContactDetail> nzzv_ = a?.Editor;
            List<ContactDetail> nzzw_ = a?.Reviewer;
            List<ContactDetail> nzzx_ = a?.Endorser;
            List<RelatedArtifact> nzzy_ = a?.RelatedArtifact;
            Code<VariableTypeCode> nzzz_ = a?.TypeElement;
            List<EvidenceVariable.CharacteristicComponent> ozza_ = a?.Characteristic;
            EvidenceVariable ozzb_ = new EvidenceVariable
            {
                UrlElement = nzza_,
                Identifier = new List<Identifier>((IEnumerable<Identifier>)nzzb_),
                VersionElement = nzzc_,
                NameElement = nzzd_,
                TitleElement = nzze_,
                ShortTitleElement = nzzf_,
                SubtitleElement = nzzg_,
                StatusElement = nzzh_,
                DateElement = nzzi_,
                PublisherElement = nzzj_,
                Contact = new List<ContactDetail>((IEnumerable<ContactDetail>)nzzk_),
                DescriptionElement = nzzl_,
                Note = new List<Annotation>((IEnumerable<Annotation>)nzzm_),
                UseContext = new List<UsageContext>((IEnumerable<UsageContext>)nzzn_),
                Jurisdiction = new List<CodeableConcept>((IEnumerable<CodeableConcept>)nzzo_),
                CopyrightElement = nzzp_,
                ApprovalDateElement = nzzq_,
                LastReviewDateElement = nzzr_,
                EffectivePeriod = nzzs_,
                Topic = new List<CodeableConcept>((IEnumerable<CodeableConcept>)nzzt_),
                Author = new List<ContactDetail>((IEnumerable<ContactDetail>)nzzu_),
                Editor = new List<ContactDetail>((IEnumerable<ContactDetail>)nzzv_),
                Reviewer = new List<ContactDetail>((IEnumerable<ContactDetail>)nzzw_),
                Endorser = new List<ContactDetail>((IEnumerable<ContactDetail>)nzzx_),
                RelatedArtifact = new List<RelatedArtifact>((IEnumerable<RelatedArtifact>)nzzy_),
                TypeElement = nzzz_,
                Characteristic = new List<EvidenceVariable.CharacteristicComponent>((IEnumerable<EvidenceVariable.CharacteristicComponent>)ozza_),
            };

            return ozzb_;
        };
        IEnumerable<EvidenceVariable> mzzx_ = context.Operators.Select<EvidenceVariable, EvidenceVariable>((IEnumerable<EvidenceVariable>)mzzv_, mzzw_);
        IEnumerable<EvidenceVariable> mzzy_ = context.Operators.Distinct<EvidenceVariable>(mzzx_);
        EvidenceVariable mzzz_ = context.Operators.SingletonFrom<EvidenceVariable>(mzzy_);

        return mzzz_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public ExplanationOfBenefit ExplanationOfBenefitResource(CqlContext context, ExplanationOfBenefit arg)
    {
        ExplanationOfBenefit[] ozzc_ = [
            arg,
        ];
        ExplanationOfBenefit ozzd_(ExplanationOfBenefit a)
        {
            List<Identifier> ozzh_ = a?.Identifier;
            Code<ExplanationOfBenefit.ExplanationOfBenefitStatus> ozzi_ = a?.StatusElement;
            CodeableConcept ozzj_ = a?.Type;
            CodeableConcept ozzk_ = a?.SubType;
            Code<ClaimUseCode> ozzl_ = a?.UseElement;
            ResourceReference ozzm_ = a?.Patient;
            Period ozzn_ = a?.BillablePeriod;
            FhirDateTime ozzo_ = a?.CreatedElement;
            ResourceReference ozzp_ = a?.Enterer;
            ResourceReference ozzq_ = a?.Insurer;
            ResourceReference ozzr_ = a?.Provider;
            CodeableConcept ozzs_ = a?.Priority;
            CodeableConcept ozzt_ = a?.FundsReserveRequested;
            CodeableConcept ozzu_ = a?.FundsReserve;
            List<ExplanationOfBenefit.RelatedClaimComponent> ozzv_ = a?.Related;
            ResourceReference ozzw_ = a?.Prescription;
            ResourceReference ozzx_ = a?.OriginalPrescription;
            ExplanationOfBenefit.PayeeComponent ozzy_ = a?.Payee;
            ResourceReference ozzz_ = a?.Referral;
            ResourceReference pzza_ = a?.Facility;
            ResourceReference pzzb_ = a?.Claim;
            ResourceReference pzzc_ = a?.ClaimResponse;
            Code<ClaimProcessingCodes> pzzd_ = a?.OutcomeElement;
            FhirString pzze_ = a?.DispositionElement;
            List<FhirString> pzzf_ = a?.PreAuthRefElement;
            List<Period> pzzg_ = a?.PreAuthRefPeriod;
            List<ExplanationOfBenefit.CareTeamComponent> pzzh_ = a?.CareTeam;
            List<ExplanationOfBenefit.SupportingInformationComponent> pzzi_ = a?.SupportingInfo;
            List<ExplanationOfBenefit.DiagnosisComponent> pzzj_ = a?.Diagnosis;
            List<ExplanationOfBenefit.ProcedureComponent> pzzk_ = a?.Procedure;
            PositiveInt pzzl_ = a?.PrecedenceElement;
            Integer pzzm_ = context.Operators.Convert<Integer>(pzzl_);
            PositiveInt pzzn_ = context.Operators.Convert<PositiveInt>(pzzm_);
            List<ExplanationOfBenefit.InsuranceComponent> pzzo_ = a?.Insurance;
            ExplanationOfBenefit.AccidentComponent pzzp_ = a?.Accident;
            List<ExplanationOfBenefit.ItemComponent> pzzq_ = a?.Item;
            List<ExplanationOfBenefit.AddedItemComponent> pzzr_ = a?.AddItem;
            List<ExplanationOfBenefit.AdjudicationComponent> pzzs_ = a?.Adjudication;
            List<ExplanationOfBenefit.TotalComponent> pzzt_ = a?.Total;
            ExplanationOfBenefit.PaymentComponent pzzu_ = a?.Payment;
            CodeableConcept pzzv_ = a?.FormCode;
            Attachment pzzw_ = a?.Form;
            List<ExplanationOfBenefit.NoteComponent> pzzx_ = a?.ProcessNote;
            Period pzzy_ = a?.BenefitPeriod;
            List<ExplanationOfBenefit.BenefitBalanceComponent> pzzz_ = a?.BenefitBalance;
            ExplanationOfBenefit qzza_ = new ExplanationOfBenefit
            {
                Identifier = new List<Identifier>((IEnumerable<Identifier>)ozzh_),
                StatusElement = ozzi_,
                Type = ozzj_,
                SubType = ozzk_,
                UseElement = ozzl_,
                Patient = ozzm_,
                BillablePeriod = ozzn_,
                CreatedElement = ozzo_,
                Enterer = ozzp_,
                Insurer = ozzq_,
                Provider = ozzr_,
                Priority = ozzs_,
                FundsReserveRequested = ozzt_,
                FundsReserve = ozzu_,
                Related = new List<ExplanationOfBenefit.RelatedClaimComponent>((IEnumerable<ExplanationOfBenefit.RelatedClaimComponent>)ozzv_),
                Prescription = ozzw_,
                OriginalPrescription = ozzx_,
                Payee = ozzy_,
                Referral = ozzz_,
                Facility = pzza_,
                Claim = pzzb_,
                ClaimResponse = pzzc_,
                OutcomeElement = pzzd_,
                DispositionElement = pzze_,
                PreAuthRefElement = new List<FhirString>((IEnumerable<FhirString>)pzzf_),
                PreAuthRefPeriod = new List<Period>((IEnumerable<Period>)pzzg_),
                CareTeam = new List<ExplanationOfBenefit.CareTeamComponent>((IEnumerable<ExplanationOfBenefit.CareTeamComponent>)pzzh_),
                SupportingInfo = new List<ExplanationOfBenefit.SupportingInformationComponent>((IEnumerable<ExplanationOfBenefit.SupportingInformationComponent>)pzzi_),
                Diagnosis = new List<ExplanationOfBenefit.DiagnosisComponent>((IEnumerable<ExplanationOfBenefit.DiagnosisComponent>)pzzj_),
                Procedure = new List<ExplanationOfBenefit.ProcedureComponent>((IEnumerable<ExplanationOfBenefit.ProcedureComponent>)pzzk_),
                PrecedenceElement = pzzn_,
                Insurance = new List<ExplanationOfBenefit.InsuranceComponent>((IEnumerable<ExplanationOfBenefit.InsuranceComponent>)pzzo_),
                Accident = pzzp_,
                Item = new List<ExplanationOfBenefit.ItemComponent>((IEnumerable<ExplanationOfBenefit.ItemComponent>)pzzq_),
                AddItem = new List<ExplanationOfBenefit.AddedItemComponent>((IEnumerable<ExplanationOfBenefit.AddedItemComponent>)pzzr_),
                Adjudication = new List<ExplanationOfBenefit.AdjudicationComponent>((IEnumerable<ExplanationOfBenefit.AdjudicationComponent>)pzzs_),
                Total = new List<ExplanationOfBenefit.TotalComponent>((IEnumerable<ExplanationOfBenefit.TotalComponent>)pzzt_),
                Payment = pzzu_,
                FormCode = pzzv_,
                Form = pzzw_,
                ProcessNote = new List<ExplanationOfBenefit.NoteComponent>((IEnumerable<ExplanationOfBenefit.NoteComponent>)pzzx_),
                BenefitPeriod = pzzy_,
                BenefitBalance = new List<ExplanationOfBenefit.BenefitBalanceComponent>((IEnumerable<ExplanationOfBenefit.BenefitBalanceComponent>)pzzz_),
            };

            return qzza_;
        };
        IEnumerable<ExplanationOfBenefit> ozze_ = context.Operators.Select<ExplanationOfBenefit, ExplanationOfBenefit>((IEnumerable<ExplanationOfBenefit>)ozzc_, ozzd_);
        IEnumerable<ExplanationOfBenefit> ozzf_ = context.Operators.Distinct<ExplanationOfBenefit>(ozze_);
        ExplanationOfBenefit ozzg_ = context.Operators.SingletonFrom<ExplanationOfBenefit>(ozzf_);

        return ozzg_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public FamilyMemberHistory FamilyMemberHistoryResource(CqlContext context, FamilyMemberHistory arg)
    {
        FamilyMemberHistory[] qzzb_ = [
            arg,
        ];
        FamilyMemberHistory qzzc_(FamilyMemberHistory a)
        {
            List<Identifier> qzzg_ = a?.Identifier;
            List<Canonical> qzzh_ = a?.InstantiatesCanonicalElement;
            List<FhirUri> qzzi_ = a?.InstantiatesUriElement;
            Code<FamilyMemberHistory.FamilyHistoryStatus> qzzj_ = a?.StatusElement;
            CodeableConcept qzzk_ = a?.DataAbsentReason;
            ResourceReference qzzl_ = a?.Patient;
            FhirDateTime qzzm_ = a?.DateElement;
            FhirString qzzn_ = a?.NameElement;
            CodeableConcept qzzo_ = a?.Relationship;
            CodeableConcept qzzp_ = a?.Sex;
            DataType qzzq_ = a?.Born;
            DataType qzzr_ = a?.Age;
            FhirBoolean qzzs_ = a?.EstimatedAgeElement;
            DataType qzzt_ = a?.Deceased;
            List<CodeableConcept> qzzu_ = a?.ReasonCode;
            List<ResourceReference> qzzv_ = a?.ReasonReference;
            List<Annotation> qzzw_ = a?.Note;
            List<FamilyMemberHistory.ConditionComponent> qzzx_ = a?.Condition;
            FamilyMemberHistory qzzy_ = new FamilyMemberHistory
            {
                Identifier = new List<Identifier>((IEnumerable<Identifier>)qzzg_),
                InstantiatesCanonicalElement = new List<Canonical>((IEnumerable<Canonical>)qzzh_),
                InstantiatesUriElement = new List<FhirUri>((IEnumerable<FhirUri>)qzzi_),
                StatusElement = qzzj_,
                DataAbsentReason = qzzk_,
                Patient = qzzl_,
                DateElement = qzzm_,
                NameElement = qzzn_,
                Relationship = qzzo_,
                Sex = qzzp_,
                Born = (DataType)qzzq_,
                Age = (DataType)qzzr_,
                EstimatedAgeElement = qzzs_,
                Deceased = (DataType)qzzt_,
                ReasonCode = new List<CodeableConcept>((IEnumerable<CodeableConcept>)qzzu_),
                ReasonReference = new List<ResourceReference>((IEnumerable<ResourceReference>)qzzv_),
                Note = new List<Annotation>((IEnumerable<Annotation>)qzzw_),
                Condition = new List<FamilyMemberHistory.ConditionComponent>((IEnumerable<FamilyMemberHistory.ConditionComponent>)qzzx_),
            };

            return qzzy_;
        };
        IEnumerable<FamilyMemberHistory> qzzd_ = context.Operators.Select<FamilyMemberHistory, FamilyMemberHistory>((IEnumerable<FamilyMemberHistory>)qzzb_, qzzc_);
        IEnumerable<FamilyMemberHistory> qzze_ = context.Operators.Distinct<FamilyMemberHistory>(qzzd_);
        FamilyMemberHistory qzzf_ = context.Operators.SingletonFrom<FamilyMemberHistory>(qzze_);

        return qzzf_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public Flag FlagResource(CqlContext context, Flag arg)
    {
        Flag[] qzzz_ = [
            arg,
        ];
        Flag rzza_(Flag a)
        {
            List<Identifier> rzze_ = a?.Identifier;
            Code<Flag.FlagStatus> rzzf_ = a?.StatusElement;
            List<CodeableConcept> rzzg_ = a?.Category;
            CodeableConcept rzzh_ = a?.Code;
            ResourceReference rzzi_ = a?.Subject;
            Period rzzj_ = a?.Period;
            ResourceReference rzzk_ = a?.Encounter;
            ResourceReference rzzl_ = a?.Author;
            Flag rzzm_ = new Flag
            {
                Identifier = new List<Identifier>((IEnumerable<Identifier>)rzze_),
                StatusElement = rzzf_,
                Category = new List<CodeableConcept>((IEnumerable<CodeableConcept>)rzzg_),
                Code = rzzh_,
                Subject = rzzi_,
                Period = rzzj_,
                Encounter = rzzk_,
                Author = rzzl_,
            };

            return rzzm_;
        };
        IEnumerable<Flag> rzzb_ = context.Operators.Select<Flag, Flag>((IEnumerable<Flag>)qzzz_, rzza_);
        IEnumerable<Flag> rzzc_ = context.Operators.Distinct<Flag>(rzzb_);
        Flag rzzd_ = context.Operators.SingletonFrom<Flag>(rzzc_);

        return rzzd_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public Goal GoalResource(CqlContext context, Goal arg)
    {
        Goal[] rzzn_ = [
            arg,
        ];
        Goal rzzo_(Goal a)
        {
            List<Identifier> rzzs_ = a?.Identifier;
            Code<Goal.GoalLifecycleStatus> rzzt_ = a?.LifecycleStatusElement;
            CodeableConcept rzzu_ = a?.AchievementStatus;
            List<CodeableConcept> rzzv_ = a?.Category;
            CodeableConcept rzzw_ = a?.Priority;
            CodeableConcept rzzx_ = a?.Description;
            ResourceReference rzzy_ = a?.Subject;
            DataType rzzz_ = a?.Start;
            List<Goal.TargetComponent> szza_ = a?.Target;
            Date szzb_ = a?.StatusDateElement;
            FhirString szzc_ = a?.StatusReasonElement;
            ResourceReference szzd_ = a?.ExpressedBy;
            List<ResourceReference> szze_ = a?.Addresses;
            List<Annotation> szzf_ = a?.Note;
            List<CodeableConcept> szzg_ = a?.OutcomeCode;
            List<ResourceReference> szzh_ = a?.OutcomeReference;
            Goal szzi_ = new Goal
            {
                Identifier = new List<Identifier>((IEnumerable<Identifier>)rzzs_),
                LifecycleStatusElement = rzzt_,
                AchievementStatus = rzzu_,
                Category = new List<CodeableConcept>((IEnumerable<CodeableConcept>)rzzv_),
                Priority = rzzw_,
                Description = rzzx_,
                Subject = rzzy_,
                Start = (DataType)rzzz_,
                Target = new List<Goal.TargetComponent>((IEnumerable<Goal.TargetComponent>)szza_),
                StatusDateElement = szzb_,
                StatusReasonElement = szzc_,
                ExpressedBy = szzd_,
                Addresses = new List<ResourceReference>((IEnumerable<ResourceReference>)szze_),
                Note = new List<Annotation>((IEnumerable<Annotation>)szzf_),
                OutcomeCode = new List<CodeableConcept>((IEnumerable<CodeableConcept>)szzg_),
                OutcomeReference = new List<ResourceReference>((IEnumerable<ResourceReference>)szzh_),
            };

            return szzi_;
        };
        IEnumerable<Goal> rzzp_ = context.Operators.Select<Goal, Goal>((IEnumerable<Goal>)rzzn_, rzzo_);
        IEnumerable<Goal> rzzq_ = context.Operators.Distinct<Goal>(rzzp_);
        Goal rzzr_ = context.Operators.SingletonFrom<Goal>(rzzq_);

        return rzzr_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public Group GroupResource(CqlContext context, Group arg)
    {
        Group[] szzj_ = [
            arg,
        ];
        Group szzk_(Group a)
        {
            List<Identifier> szzo_ = a?.Identifier;
            FhirBoolean szzp_ = a?.ActiveElement;
            Code<Group.GroupType> szzq_ = a?.TypeElement;
            FhirBoolean szzr_ = a?.ActualElement;
            CodeableConcept szzs_ = a?.Code;
            FhirString szzt_ = a?.NameElement;
            UnsignedInt szzu_ = a?.QuantityElement;
            Integer szzv_ = context.Operators.Convert<Integer>(szzu_);
            UnsignedInt szzw_ = context.Operators.Convert<UnsignedInt>(szzv_);
            ResourceReference szzx_ = a?.ManagingEntity;
            List<Group.CharacteristicComponent> szzy_ = a?.Characteristic;
            List<Group.MemberComponent> szzz_ = a?.Member;
            Group tzza_ = new Group
            {
                Identifier = new List<Identifier>((IEnumerable<Identifier>)szzo_),
                ActiveElement = szzp_,
                TypeElement = szzq_,
                ActualElement = szzr_,
                Code = szzs_,
                NameElement = szzt_,
                QuantityElement = szzw_,
                ManagingEntity = szzx_,
                Characteristic = new List<Group.CharacteristicComponent>((IEnumerable<Group.CharacteristicComponent>)szzy_),
                Member = new List<Group.MemberComponent>((IEnumerable<Group.MemberComponent>)szzz_),
            };

            return tzza_;
        };
        IEnumerable<Group> szzl_ = context.Operators.Select<Group, Group>((IEnumerable<Group>)szzj_, szzk_);
        IEnumerable<Group> szzm_ = context.Operators.Distinct<Group>(szzl_);
        Group szzn_ = context.Operators.SingletonFrom<Group>(szzm_);

        return szzn_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public GuidanceResponse GuidanceResponseResource(CqlContext context, GuidanceResponse arg)
    {
        GuidanceResponse[] tzzb_ = [
            arg,
        ];
        GuidanceResponse tzzc_(GuidanceResponse a)
        {
            Identifier tzzg_ = a?.RequestIdentifier;
            List<Identifier> tzzh_ = a?.Identifier;
            DataType tzzi_ = a?.Module;
            Code<GuidanceResponse.GuidanceResponseStatus> tzzj_ = a?.StatusElement;
            ResourceReference tzzk_ = a?.Subject;
            ResourceReference tzzl_ = a?.Encounter;
            FhirDateTime tzzm_ = a?.OccurrenceDateTimeElement;
            ResourceReference tzzn_ = a?.Performer;
            List<CodeableConcept> tzzo_ = a?.ReasonCode;
            List<ResourceReference> tzzp_ = a?.ReasonReference;
            List<Annotation> tzzq_ = a?.Note;
            List<ResourceReference> tzzr_ = a?.EvaluationMessage;
            ResourceReference tzzs_ = a?.OutputParameters;
            ResourceReference tzzt_ = a?.Result;
            List<DataRequirement> tzzu_ = a?.DataRequirement;
            GuidanceResponse tzzv_ = new GuidanceResponse
            {
                RequestIdentifier = tzzg_,
                Identifier = new List<Identifier>((IEnumerable<Identifier>)tzzh_),
                Module = (DataType)tzzi_,
                StatusElement = tzzj_,
                Subject = tzzk_,
                Encounter = tzzl_,
                OccurrenceDateTimeElement = tzzm_,
                Performer = tzzn_,
                ReasonCode = new List<CodeableConcept>((IEnumerable<CodeableConcept>)tzzo_),
                ReasonReference = new List<ResourceReference>((IEnumerable<ResourceReference>)tzzp_),
                Note = new List<Annotation>((IEnumerable<Annotation>)tzzq_),
                EvaluationMessage = new List<ResourceReference>((IEnumerable<ResourceReference>)tzzr_),
                OutputParameters = tzzs_,
                Result = tzzt_,
                DataRequirement = new List<DataRequirement>((IEnumerable<DataRequirement>)tzzu_),
            };

            return tzzv_;
        };
        IEnumerable<GuidanceResponse> tzzd_ = context.Operators.Select<GuidanceResponse, GuidanceResponse>((IEnumerable<GuidanceResponse>)tzzb_, tzzc_);
        IEnumerable<GuidanceResponse> tzze_ = context.Operators.Distinct<GuidanceResponse>(tzzd_);
        GuidanceResponse tzzf_ = context.Operators.SingletonFrom<GuidanceResponse>(tzze_);

        return tzzf_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public HealthcareService HealthcareServiceResource(CqlContext context, HealthcareService arg)
    {
        HealthcareService[] tzzw_ = [
            arg,
        ];
        HealthcareService tzzx_(HealthcareService a)
        {
            List<Identifier> uzzb_ = a?.Identifier;
            FhirBoolean uzzc_ = a?.ActiveElement;
            ResourceReference uzzd_ = a?.ProvidedBy;
            List<CodeableConcept> uzze_ = a?.Category;
            List<CodeableConcept> uzzf_ = a?.Type;
            List<CodeableConcept> uzzg_ = a?.Specialty;
            List<ResourceReference> uzzh_ = a?.Location;
            FhirString uzzi_ = a?.NameElement;
            FhirString uzzj_ = a?.CommentElement;
            Markdown uzzk_ = a?.ExtraDetailsElement;
            Attachment uzzl_ = a?.Photo;
            List<ContactPoint> uzzm_ = a?.Telecom;
            List<ResourceReference> uzzn_ = a?.CoverageArea;
            List<CodeableConcept> uzzo_ = a?.ServiceProvisionCode;
            List<HealthcareService.EligibilityComponent> uzzp_ = a?.Eligibility;
            List<CodeableConcept> uzzq_ = a?.Program;
            List<CodeableConcept> uzzr_ = a?.Characteristic;
            List<CodeableConcept> uzzs_ = a?.Communication;
            List<CodeableConcept> uzzt_ = a?.ReferralMethod;
            FhirBoolean uzzu_ = a?.AppointmentRequiredElement;
            List<HealthcareService.AvailableTimeComponent> uzzv_ = a?.AvailableTime;
            List<HealthcareService.NotAvailableComponent> uzzw_ = a?.NotAvailable;
            FhirString uzzx_ = a?.AvailabilityExceptionsElement;
            List<ResourceReference> uzzy_ = a?.Endpoint;
            HealthcareService uzzz_ = new HealthcareService
            {
                Identifier = new List<Identifier>((IEnumerable<Identifier>)uzzb_),
                ActiveElement = uzzc_,
                ProvidedBy = uzzd_,
                Category = new List<CodeableConcept>((IEnumerable<CodeableConcept>)uzze_),
                Type = new List<CodeableConcept>((IEnumerable<CodeableConcept>)uzzf_),
                Specialty = new List<CodeableConcept>((IEnumerable<CodeableConcept>)uzzg_),
                Location = new List<ResourceReference>((IEnumerable<ResourceReference>)uzzh_),
                NameElement = uzzi_,
                CommentElement = uzzj_,
                ExtraDetailsElement = uzzk_,
                Photo = uzzl_,
                Telecom = new List<ContactPoint>((IEnumerable<ContactPoint>)uzzm_),
                CoverageArea = new List<ResourceReference>((IEnumerable<ResourceReference>)uzzn_),
                ServiceProvisionCode = new List<CodeableConcept>((IEnumerable<CodeableConcept>)uzzo_),
                Eligibility = new List<HealthcareService.EligibilityComponent>((IEnumerable<HealthcareService.EligibilityComponent>)uzzp_),
                Program = new List<CodeableConcept>((IEnumerable<CodeableConcept>)uzzq_),
                Characteristic = new List<CodeableConcept>((IEnumerable<CodeableConcept>)uzzr_),
                Communication = new List<CodeableConcept>((IEnumerable<CodeableConcept>)uzzs_),
                ReferralMethod = new List<CodeableConcept>((IEnumerable<CodeableConcept>)uzzt_),
                AppointmentRequiredElement = uzzu_,
                AvailableTime = new List<HealthcareService.AvailableTimeComponent>((IEnumerable<HealthcareService.AvailableTimeComponent>)uzzv_),
                NotAvailable = new List<HealthcareService.NotAvailableComponent>((IEnumerable<HealthcareService.NotAvailableComponent>)uzzw_),
                AvailabilityExceptionsElement = uzzx_,
                Endpoint = new List<ResourceReference>((IEnumerable<ResourceReference>)uzzy_),
            };

            return uzzz_;
        };
        IEnumerable<HealthcareService> tzzy_ = context.Operators.Select<HealthcareService, HealthcareService>((IEnumerable<HealthcareService>)tzzw_, tzzx_);
        IEnumerable<HealthcareService> tzzz_ = context.Operators.Distinct<HealthcareService>(tzzy_);
        HealthcareService uzza_ = context.Operators.SingletonFrom<HealthcareService>(tzzz_);

        return uzza_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public ImagingStudy ImagingStudyResource(CqlContext context, ImagingStudy arg)
    {
        ImagingStudy[] vzza_ = [
            arg,
        ];
        ImagingStudy vzzb_(ImagingStudy a)
        {
            List<Identifier> vzzf_ = a?.Identifier;
            Code<ImagingStudy.ImagingStudyStatus> vzzg_ = a?.StatusElement;
            List<Coding> vzzh_ = a?.Modality;
            ResourceReference vzzi_ = a?.Subject;
            ResourceReference vzzj_ = a?.Encounter;
            FhirDateTime vzzk_ = a?.StartedElement;
            List<ResourceReference> vzzl_ = a?.BasedOn;
            ResourceReference vzzm_ = a?.Referrer;
            List<ResourceReference> vzzn_ = a?.Interpreter;
            List<ResourceReference> vzzo_ = a?.Endpoint;
            UnsignedInt vzzp_ = a?.NumberOfSeriesElement;
            Integer vzzq_ = context.Operators.Convert<Integer>(vzzp_);
            UnsignedInt vzzr_ = context.Operators.Convert<UnsignedInt>(vzzq_);
            UnsignedInt vzzs_ = a?.NumberOfInstancesElement;
            Integer vzzt_ = context.Operators.Convert<Integer>(vzzs_);
            UnsignedInt vzzu_ = context.Operators.Convert<UnsignedInt>(vzzt_);
            ResourceReference vzzv_ = a?.ProcedureReference;
            List<CodeableConcept> vzzw_ = a?.ProcedureCode;
            ResourceReference vzzx_ = a?.Location;
            List<CodeableConcept> vzzy_ = a?.ReasonCode;
            List<ResourceReference> vzzz_ = a?.ReasonReference;
            List<Annotation> wzza_ = a?.Note;
            FhirString wzzb_ = a?.DescriptionElement;
            List<ImagingStudy.SeriesComponent> wzzc_ = a?.Series;
            ImagingStudy wzzd_ = new ImagingStudy
            {
                Identifier = new List<Identifier>((IEnumerable<Identifier>)vzzf_),
                StatusElement = vzzg_,
                Modality = new List<Coding>((IEnumerable<Coding>)vzzh_),
                Subject = vzzi_,
                Encounter = vzzj_,
                StartedElement = vzzk_,
                BasedOn = new List<ResourceReference>((IEnumerable<ResourceReference>)vzzl_),
                Referrer = vzzm_,
                Interpreter = new List<ResourceReference>((IEnumerable<ResourceReference>)vzzn_),
                Endpoint = new List<ResourceReference>((IEnumerable<ResourceReference>)vzzo_),
                NumberOfSeriesElement = vzzr_,
                NumberOfInstancesElement = vzzu_,
                ProcedureReference = vzzv_,
                ProcedureCode = new List<CodeableConcept>((IEnumerable<CodeableConcept>)vzzw_),
                Location = vzzx_,
                ReasonCode = new List<CodeableConcept>((IEnumerable<CodeableConcept>)vzzy_),
                ReasonReference = new List<ResourceReference>((IEnumerable<ResourceReference>)vzzz_),
                Note = new List<Annotation>((IEnumerable<Annotation>)wzza_),
                DescriptionElement = wzzb_,
                Series = new List<ImagingStudy.SeriesComponent>((IEnumerable<ImagingStudy.SeriesComponent>)wzzc_),
            };

            return wzzd_;
        };
        IEnumerable<ImagingStudy> vzzc_ = context.Operators.Select<ImagingStudy, ImagingStudy>((IEnumerable<ImagingStudy>)vzza_, vzzb_);
        IEnumerable<ImagingStudy> vzzd_ = context.Operators.Distinct<ImagingStudy>(vzzc_);
        ImagingStudy vzze_ = context.Operators.SingletonFrom<ImagingStudy>(vzzd_);

        return vzze_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public Immunization ImmunizationResource(CqlContext context, Immunization arg)
    {
        Immunization[] wzze_ = [
            arg,
        ];
        Immunization wzzf_(Immunization a)
        {
            List<Identifier> wzzj_ = a?.Identifier;
            Code<Immunization.ImmunizationStatusCodes> wzzk_ = a?.StatusElement;
            CodeableConcept wzzl_ = a?.StatusReason;
            CodeableConcept wzzm_ = a?.VaccineCode;
            ResourceReference wzzn_ = a?.Patient;
            ResourceReference wzzo_ = a?.Encounter;
            DataType wzzp_ = a?.Occurrence;
            FhirDateTime wzzq_ = a?.RecordedElement;
            FhirBoolean wzzr_ = a?.PrimarySourceElement;
            CodeableConcept wzzs_ = a?.ReportOrigin;
            ResourceReference wzzt_ = a?.Location;
            ResourceReference wzzu_ = a?.Manufacturer;
            FhirString wzzv_ = a?.LotNumberElement;
            Date wzzw_ = a?.ExpirationDateElement;
            CodeableConcept wzzx_ = a?.Site;
            CodeableConcept wzzy_ = a?.Route;
            Quantity wzzz_ = a?.DoseQuantity;
            List<Immunization.PerformerComponent> xzza_ = a?.Performer;
            List<Annotation> xzzb_ = a?.Note;
            List<CodeableConcept> xzzc_ = a?.ReasonCode;
            List<ResourceReference> xzzd_ = a?.ReasonReference;
            FhirBoolean xzze_ = a?.IsSubpotentElement;
            List<CodeableConcept> xzzf_ = a?.SubpotentReason;
            List<Immunization.EducationComponent> xzzg_ = a?.Education;
            List<CodeableConcept> xzzh_ = a?.ProgramEligibility;
            CodeableConcept xzzi_ = a?.FundingSource;
            List<Immunization.ReactionComponent> xzzj_ = a?.Reaction;
            List<Immunization.ProtocolAppliedComponent> xzzk_ = a?.ProtocolApplied;
            Immunization xzzl_ = new Immunization
            {
                Identifier = new List<Identifier>((IEnumerable<Identifier>)wzzj_),
                StatusElement = wzzk_,
                StatusReason = wzzl_,
                VaccineCode = wzzm_,
                Patient = wzzn_,
                Encounter = wzzo_,
                Occurrence = (DataType)wzzp_,
                RecordedElement = wzzq_,
                PrimarySourceElement = wzzr_,
                ReportOrigin = wzzs_,
                Location = wzzt_,
                Manufacturer = wzzu_,
                LotNumberElement = wzzv_,
                ExpirationDateElement = wzzw_,
                Site = wzzx_,
                Route = wzzy_,
                DoseQuantity = wzzz_,
                Performer = new List<Immunization.PerformerComponent>((IEnumerable<Immunization.PerformerComponent>)xzza_),
                Note = new List<Annotation>((IEnumerable<Annotation>)xzzb_),
                ReasonCode = new List<CodeableConcept>((IEnumerable<CodeableConcept>)xzzc_),
                ReasonReference = new List<ResourceReference>((IEnumerable<ResourceReference>)xzzd_),
                IsSubpotentElement = xzze_,
                SubpotentReason = new List<CodeableConcept>((IEnumerable<CodeableConcept>)xzzf_),
                Education = new List<Immunization.EducationComponent>((IEnumerable<Immunization.EducationComponent>)xzzg_),
                ProgramEligibility = new List<CodeableConcept>((IEnumerable<CodeableConcept>)xzzh_),
                FundingSource = xzzi_,
                Reaction = new List<Immunization.ReactionComponent>((IEnumerable<Immunization.ReactionComponent>)xzzj_),
                ProtocolApplied = new List<Immunization.ProtocolAppliedComponent>((IEnumerable<Immunization.ProtocolAppliedComponent>)xzzk_),
            };

            return xzzl_;
        };
        IEnumerable<Immunization> wzzg_ = context.Operators.Select<Immunization, Immunization>((IEnumerable<Immunization>)wzze_, wzzf_);
        IEnumerable<Immunization> wzzh_ = context.Operators.Distinct<Immunization>(wzzg_);
        Immunization wzzi_ = context.Operators.SingletonFrom<Immunization>(wzzh_);

        return wzzi_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public ImmunizationEvaluation ImmunizationEvaluationResource(CqlContext context, ImmunizationEvaluation arg)
    {
        ImmunizationEvaluation[] xzzm_ = [
            arg,
        ];
        ImmunizationEvaluation xzzn_(ImmunizationEvaluation a)
        {
            List<Identifier> xzzr_ = a?.Identifier;
            Code<ImmunizationEvaluation.ImmunizationEvaluationStatusCodes> xzzs_ = a?.StatusElement;
            ResourceReference xzzt_ = a?.Patient;
            FhirDateTime xzzu_ = a?.DateElement;
            ResourceReference xzzv_ = a?.Authority;
            CodeableConcept xzzw_ = a?.TargetDisease;
            ResourceReference xzzx_ = a?.ImmunizationEvent;
            CodeableConcept xzzy_ = a?.DoseStatus;
            List<CodeableConcept> xzzz_ = a?.DoseStatusReason;
            FhirString yzza_ = a?.DescriptionElement;
            FhirString yzzb_ = a?.SeriesElement;
            DataType yzzc_ = a?.DoseNumber;
            DataType yzzd_ = a?.SeriesDoses;
            ImmunizationEvaluation yzze_ = new ImmunizationEvaluation
            {
                Identifier = new List<Identifier>((IEnumerable<Identifier>)xzzr_),
                StatusElement = xzzs_,
                Patient = xzzt_,
                DateElement = xzzu_,
                Authority = xzzv_,
                TargetDisease = xzzw_,
                ImmunizationEvent = xzzx_,
                DoseStatus = xzzy_,
                DoseStatusReason = new List<CodeableConcept>((IEnumerable<CodeableConcept>)xzzz_),
                DescriptionElement = yzza_,
                SeriesElement = yzzb_,
                DoseNumber = (DataType)yzzc_,
                SeriesDoses = (DataType)yzzd_,
            };

            return yzze_;
        };
        IEnumerable<ImmunizationEvaluation> xzzo_ = context.Operators.Select<ImmunizationEvaluation, ImmunizationEvaluation>((IEnumerable<ImmunizationEvaluation>)xzzm_, xzzn_);
        IEnumerable<ImmunizationEvaluation> xzzp_ = context.Operators.Distinct<ImmunizationEvaluation>(xzzo_);
        ImmunizationEvaluation xzzq_ = context.Operators.SingletonFrom<ImmunizationEvaluation>(xzzp_);

        return xzzq_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public ImmunizationRecommendation ImmunizationRecommendationResource(CqlContext context, ImmunizationRecommendation arg)
    {
        ImmunizationRecommendation[] yzzf_ = [
            arg,
        ];
        ImmunizationRecommendation yzzg_(ImmunizationRecommendation a)
        {
            List<Identifier> yzzk_ = a?.Identifier;
            ResourceReference yzzl_ = a?.Patient;
            FhirDateTime yzzm_ = a?.DateElement;
            ResourceReference yzzn_ = a?.Authority;
            List<ImmunizationRecommendation.RecommendationComponent> yzzo_ = a?.Recommendation;
            ImmunizationRecommendation yzzp_ = new ImmunizationRecommendation
            {
                Identifier = new List<Identifier>((IEnumerable<Identifier>)yzzk_),
                Patient = yzzl_,
                DateElement = yzzm_,
                Authority = yzzn_,
                Recommendation = new List<ImmunizationRecommendation.RecommendationComponent>((IEnumerable<ImmunizationRecommendation.RecommendationComponent>)yzzo_),
            };

            return yzzp_;
        };
        IEnumerable<ImmunizationRecommendation> yzzh_ = context.Operators.Select<ImmunizationRecommendation, ImmunizationRecommendation>((IEnumerable<ImmunizationRecommendation>)yzzf_, yzzg_);
        IEnumerable<ImmunizationRecommendation> yzzi_ = context.Operators.Distinct<ImmunizationRecommendation>(yzzh_);
        ImmunizationRecommendation yzzj_ = context.Operators.SingletonFrom<ImmunizationRecommendation>(yzzi_);

        return yzzj_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public InsurancePlan InsurancePlanResource(CqlContext context, InsurancePlan arg)
    {
        InsurancePlan[] yzzq_ = [
            arg,
        ];
        InsurancePlan yzzr_(InsurancePlan a)
        {
            List<Identifier> yzzv_ = a?.Identifier;
            Code<PublicationStatus> yzzw_ = a?.StatusElement;
            List<CodeableConcept> yzzx_ = a?.Type;
            FhirString yzzy_ = a?.NameElement;
            List<FhirString> yzzz_ = a?.AliasElement;
            Period zzza_ = a?.Period;
            ResourceReference zzzb_ = a?.OwnedBy;
            ResourceReference zzzc_ = a?.AdministeredBy;
            List<ResourceReference> zzzd_ = a?.CoverageArea;
            List<InsurancePlan.ContactComponent> zzze_ = a?.Contact;
            List<ResourceReference> zzzf_ = a?.Endpoint;
            List<ResourceReference> zzzg_ = a?.Network;
            List<InsurancePlan.CoverageComponent> zzzh_ = a?.Coverage;
            List<InsurancePlan.PlanComponent> zzzi_ = a?.Plan;
            InsurancePlan zzzj_ = new InsurancePlan
            {
                Identifier = new List<Identifier>((IEnumerable<Identifier>)yzzv_),
                StatusElement = yzzw_,
                Type = new List<CodeableConcept>((IEnumerable<CodeableConcept>)yzzx_),
                NameElement = yzzy_,
                AliasElement = new List<FhirString>((IEnumerable<FhirString>)yzzz_),
                Period = zzza_,
                OwnedBy = zzzb_,
                AdministeredBy = zzzc_,
                CoverageArea = new List<ResourceReference>((IEnumerable<ResourceReference>)zzzd_),
                Contact = new List<InsurancePlan.ContactComponent>((IEnumerable<InsurancePlan.ContactComponent>)zzze_),
                Endpoint = new List<ResourceReference>((IEnumerable<ResourceReference>)zzzf_),
                Network = new List<ResourceReference>((IEnumerable<ResourceReference>)zzzg_),
                Coverage = new List<InsurancePlan.CoverageComponent>((IEnumerable<InsurancePlan.CoverageComponent>)zzzh_),
                Plan = new List<InsurancePlan.PlanComponent>((IEnumerable<InsurancePlan.PlanComponent>)zzzi_),
            };

            return zzzj_;
        };
        IEnumerable<InsurancePlan> yzzs_ = context.Operators.Select<InsurancePlan, InsurancePlan>((IEnumerable<InsurancePlan>)yzzq_, yzzr_);
        IEnumerable<InsurancePlan> yzzt_ = context.Operators.Distinct<InsurancePlan>(yzzs_);
        InsurancePlan yzzu_ = context.Operators.SingletonFrom<InsurancePlan>(yzzt_);

        return yzzu_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public Invoice InvoiceResource(CqlContext context, Invoice arg)
    {
        Invoice[] zzzk_ = [
            arg,
        ];
        Invoice zzzl_(Invoice a)
        {
            List<Identifier> zzzp_ = a?.Identifier;
            Code<Invoice.InvoiceStatus> zzzq_ = a?.StatusElement;
            FhirString zzzr_ = a?.CancelledReasonElement;
            CodeableConcept zzzs_ = a?.Type;
            ResourceReference zzzt_ = a?.Subject;
            ResourceReference zzzu_ = a?.Recipient;
            FhirDateTime zzzv_ = a?.DateElement;
            List<Invoice.ParticipantComponent> zzzw_ = a?.Participant;
            ResourceReference zzzx_ = a?.Issuer;
            ResourceReference zzzy_ = a?.Account;
            List<Invoice.LineItemComponent> zzzz_ = a?.LineItem;
            List<Invoice.PriceComponentComponent> azzza_ = a?.TotalPriceComponent;
            Money azzzb_ = a?.TotalNet;
            Money azzzc_ = a?.TotalGross;
            Markdown azzzd_ = a?.PaymentTermsElement;
            List<Annotation> azzze_ = a?.Note;
            Invoice azzzf_ = new Invoice
            {
                Identifier = new List<Identifier>((IEnumerable<Identifier>)zzzp_),
                StatusElement = zzzq_,
                CancelledReasonElement = zzzr_,
                Type = zzzs_,
                Subject = zzzt_,
                Recipient = zzzu_,
                DateElement = zzzv_,
                Participant = new List<Invoice.ParticipantComponent>((IEnumerable<Invoice.ParticipantComponent>)zzzw_),
                Issuer = zzzx_,
                Account = zzzy_,
                LineItem = new List<Invoice.LineItemComponent>((IEnumerable<Invoice.LineItemComponent>)zzzz_),
                TotalPriceComponent = new List<Invoice.PriceComponentComponent>((IEnumerable<Invoice.PriceComponentComponent>)azzza_),
                TotalNet = azzzb_,
                TotalGross = azzzc_,
                PaymentTermsElement = azzzd_,
                Note = new List<Annotation>((IEnumerable<Annotation>)azzze_),
            };

            return azzzf_;
        };
        IEnumerable<Invoice> zzzm_ = context.Operators.Select<Invoice, Invoice>((IEnumerable<Invoice>)zzzk_, zzzl_);
        IEnumerable<Invoice> zzzn_ = context.Operators.Distinct<Invoice>(zzzm_);
        Invoice zzzo_ = context.Operators.SingletonFrom<Invoice>(zzzn_);

        return zzzo_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public Library LibraryResource(CqlContext context, Library arg)
    {
        Library[] azzzg_ = [
            arg,
        ];
        Library azzzh_(Library a)
        {
            FhirUri azzzl_ = a?.UrlElement;
            List<Identifier> azzzm_ = a?.Identifier;
            FhirString azzzn_ = a?.VersionElement;
            FhirString azzzo_ = a?.NameElement;
            FhirString azzzp_ = a?.TitleElement;
            FhirString azzzq_ = a?.SubtitleElement;
            Code<PublicationStatus> azzzr_ = a?.StatusElement;
            FhirBoolean azzzs_ = a?.ExperimentalElement;
            CodeableConcept azzzt_ = a?.Type;
            DataType azzzu_ = a?.Subject;
            FhirDateTime azzzv_ = a?.DateElement;
            FhirString azzzw_ = a?.PublisherElement;
            List<ContactDetail> azzzx_ = a?.Contact;
            Markdown azzzy_ = a?.DescriptionElement;
            List<UsageContext> azzzz_ = a?.UseContext;
            List<CodeableConcept> bzzza_ = a?.Jurisdiction;
            Markdown bzzzb_ = a?.PurposeElement;
            FhirString bzzzc_ = a?.UsageElement;
            Markdown bzzzd_ = a?.CopyrightElement;
            Date bzzze_ = a?.ApprovalDateElement;
            Date bzzzf_ = a?.LastReviewDateElement;
            Period bzzzg_ = a?.EffectivePeriod;
            List<CodeableConcept> bzzzh_ = a?.Topic;
            List<ContactDetail> bzzzi_ = a?.Author;
            List<ContactDetail> bzzzj_ = a?.Editor;
            List<ContactDetail> bzzzk_ = a?.Reviewer;
            List<ContactDetail> bzzzl_ = a?.Endorser;
            List<RelatedArtifact> bzzzm_ = a?.RelatedArtifact;
            List<ParameterDefinition> bzzzn_ = a?.Parameter;
            List<DataRequirement> bzzzo_ = a?.DataRequirement;
            List<Attachment> bzzzp_ = a?.Content;
            Library bzzzq_ = new Library
            {
                UrlElement = azzzl_,
                Identifier = new List<Identifier>((IEnumerable<Identifier>)azzzm_),
                VersionElement = azzzn_,
                NameElement = azzzo_,
                TitleElement = azzzp_,
                SubtitleElement = azzzq_,
                StatusElement = azzzr_,
                ExperimentalElement = azzzs_,
                Type = azzzt_,
                Subject = (DataType)azzzu_,
                DateElement = azzzv_,
                PublisherElement = azzzw_,
                Contact = new List<ContactDetail>((IEnumerable<ContactDetail>)azzzx_),
                DescriptionElement = azzzy_,
                UseContext = new List<UsageContext>((IEnumerable<UsageContext>)azzzz_),
                Jurisdiction = new List<CodeableConcept>((IEnumerable<CodeableConcept>)bzzza_),
                PurposeElement = bzzzb_,
                UsageElement = bzzzc_,
                CopyrightElement = bzzzd_,
                ApprovalDateElement = bzzze_,
                LastReviewDateElement = bzzzf_,
                EffectivePeriod = bzzzg_,
                Topic = new List<CodeableConcept>((IEnumerable<CodeableConcept>)bzzzh_),
                Author = new List<ContactDetail>((IEnumerable<ContactDetail>)bzzzi_),
                Editor = new List<ContactDetail>((IEnumerable<ContactDetail>)bzzzj_),
                Reviewer = new List<ContactDetail>((IEnumerable<ContactDetail>)bzzzk_),
                Endorser = new List<ContactDetail>((IEnumerable<ContactDetail>)bzzzl_),
                RelatedArtifact = new List<RelatedArtifact>((IEnumerable<RelatedArtifact>)bzzzm_),
                Parameter = new List<ParameterDefinition>((IEnumerable<ParameterDefinition>)bzzzn_),
                DataRequirement = new List<DataRequirement>((IEnumerable<DataRequirement>)bzzzo_),
                Content = new List<Attachment>((IEnumerable<Attachment>)bzzzp_),
            };

            return bzzzq_;
        };
        IEnumerable<Library> azzzi_ = context.Operators.Select<Library, Library>((IEnumerable<Library>)azzzg_, azzzh_);
        IEnumerable<Library> azzzj_ = context.Operators.Distinct<Library>(azzzi_);
        Library azzzk_ = context.Operators.SingletonFrom<Library>(azzzj_);

        return azzzk_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public Linkage LinkageResource(CqlContext context, Linkage arg)
    {
        Linkage[] bzzzr_ = [
            arg,
        ];
        Linkage bzzzs_(Linkage a)
        {
            FhirBoolean bzzzw_ = a?.ActiveElement;
            ResourceReference bzzzx_ = a?.Author;
            List<Linkage.ItemComponent> bzzzy_ = a?.Item;
            Linkage bzzzz_ = new Linkage
            {
                ActiveElement = bzzzw_,
                Author = bzzzx_,
                Item = new List<Linkage.ItemComponent>((IEnumerable<Linkage.ItemComponent>)bzzzy_),
            };

            return bzzzz_;
        };
        IEnumerable<Linkage> bzzzt_ = context.Operators.Select<Linkage, Linkage>((IEnumerable<Linkage>)bzzzr_, bzzzs_);
        IEnumerable<Linkage> bzzzu_ = context.Operators.Distinct<Linkage>(bzzzt_);
        Linkage bzzzv_ = context.Operators.SingletonFrom<Linkage>(bzzzu_);

        return bzzzv_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public Location LocationResource(CqlContext context, Location arg)
    {
        Location[] czzza_ = [
            arg,
        ];
        Location czzzb_(Location a)
        {
            List<Identifier> czzzf_ = a?.Identifier;
            Code<Location.LocationStatus> czzzg_ = a?.StatusElement;
            Coding czzzh_ = a?.OperationalStatus;
            FhirString czzzi_ = a?.NameElement;
            List<FhirString> czzzj_ = a?.AliasElement;
            FhirString czzzk_ = a?.DescriptionElement;
            Code<Location.LocationMode> czzzl_ = a?.ModeElement;
            List<CodeableConcept> czzzm_ = a?.Type;
            List<ContactPoint> czzzn_ = a?.Telecom;
            Address czzzo_ = a?.Address;
            CodeableConcept czzzp_ = a?.PhysicalType;
            Location.PositionComponent czzzq_ = a?.Position;
            ResourceReference czzzr_ = a?.ManagingOrganization;
            ResourceReference czzzs_ = a?.PartOf;
            List<Location.HoursOfOperationComponent> czzzt_ = a?.HoursOfOperation;
            FhirString czzzu_ = a?.AvailabilityExceptionsElement;
            List<ResourceReference> czzzv_ = a?.Endpoint;
            Location czzzw_ = new Location
            {
                Identifier = new List<Identifier>((IEnumerable<Identifier>)czzzf_),
                StatusElement = czzzg_,
                OperationalStatus = czzzh_,
                NameElement = czzzi_,
                AliasElement = new List<FhirString>((IEnumerable<FhirString>)czzzj_),
                DescriptionElement = czzzk_,
                ModeElement = czzzl_,
                Type = new List<CodeableConcept>((IEnumerable<CodeableConcept>)czzzm_),
                Telecom = new List<ContactPoint>((IEnumerable<ContactPoint>)czzzn_),
                Address = czzzo_,
                PhysicalType = czzzp_,
                Position = czzzq_,
                ManagingOrganization = czzzr_,
                PartOf = czzzs_,
                HoursOfOperation = new List<Location.HoursOfOperationComponent>((IEnumerable<Location.HoursOfOperationComponent>)czzzt_),
                AvailabilityExceptionsElement = czzzu_,
                Endpoint = new List<ResourceReference>((IEnumerable<ResourceReference>)czzzv_),
            };

            return czzzw_;
        };
        IEnumerable<Location> czzzc_ = context.Operators.Select<Location, Location>((IEnumerable<Location>)czzza_, czzzb_);
        IEnumerable<Location> czzzd_ = context.Operators.Distinct<Location>(czzzc_);
        Location czzze_ = context.Operators.SingletonFrom<Location>(czzzd_);

        return czzze_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public Measure MeasureResource(CqlContext context, Measure arg)
    {
        Measure[] czzzx_ = [
            arg,
        ];
        Measure czzzy_(Measure a)
        {
            FhirUri dzzzc_ = a?.UrlElement;
            List<Identifier> dzzzd_ = a?.Identifier;
            FhirString dzzze_ = a?.VersionElement;
            FhirString dzzzf_ = a?.NameElement;
            FhirString dzzzg_ = a?.TitleElement;
            FhirString dzzzh_ = a?.SubtitleElement;
            Code<PublicationStatus> dzzzi_ = a?.StatusElement;
            FhirBoolean dzzzj_ = a?.ExperimentalElement;
            DataType dzzzk_ = a?.Subject;
            FhirDateTime dzzzl_ = a?.DateElement;
            FhirString dzzzm_ = a?.PublisherElement;
            List<ContactDetail> dzzzn_ = a?.Contact;
            Markdown dzzzo_ = a?.DescriptionElement;
            List<UsageContext> dzzzp_ = a?.UseContext;
            List<CodeableConcept> dzzzq_ = a?.Jurisdiction;
            Markdown dzzzr_ = a?.PurposeElement;
            FhirString dzzzs_ = a?.UsageElement;
            Markdown dzzzt_ = a?.CopyrightElement;
            Date dzzzu_ = a?.ApprovalDateElement;
            Date dzzzv_ = a?.LastReviewDateElement;
            Period dzzzw_ = a?.EffectivePeriod;
            List<CodeableConcept> dzzzx_ = a?.Topic;
            List<ContactDetail> dzzzy_ = a?.Author;
            List<ContactDetail> dzzzz_ = a?.Editor;
            List<ContactDetail> ezzza_ = a?.Reviewer;
            List<ContactDetail> ezzzb_ = a?.Endorser;
            List<RelatedArtifact> ezzzc_ = a?.RelatedArtifact;
            List<Canonical> ezzzd_ = a?.LibraryElement;
            Markdown ezzze_ = a?.DisclaimerElement;
            CodeableConcept ezzzf_ = a?.Scoring;
            CodeableConcept ezzzg_ = a?.CompositeScoring;
            List<CodeableConcept> ezzzh_ = a?.Type;
            FhirString ezzzi_ = a?.RiskAdjustmentElement;
            FhirString ezzzj_ = a?.RateAggregationElement;
            Markdown ezzzk_ = a?.RationaleElement;
            Markdown ezzzl_ = a?.ClinicalRecommendationStatementElement;
            CodeableConcept ezzzm_ = a?.ImprovementNotation;
            List<Markdown> ezzzn_ = a?.DefinitionElement;
            Markdown ezzzo_ = a?.GuidanceElement;
            List<Measure.GroupComponent> ezzzp_ = a?.Group;
            List<Measure.SupplementalDataComponent> ezzzq_ = a?.SupplementalData;
            Measure ezzzr_ = new Measure
            {
                UrlElement = dzzzc_,
                Identifier = new List<Identifier>((IEnumerable<Identifier>)dzzzd_),
                VersionElement = dzzze_,
                NameElement = dzzzf_,
                TitleElement = dzzzg_,
                SubtitleElement = dzzzh_,
                StatusElement = dzzzi_,
                ExperimentalElement = dzzzj_,
                Subject = (DataType)dzzzk_,
                DateElement = dzzzl_,
                PublisherElement = dzzzm_,
                Contact = new List<ContactDetail>((IEnumerable<ContactDetail>)dzzzn_),
                DescriptionElement = dzzzo_,
                UseContext = new List<UsageContext>((IEnumerable<UsageContext>)dzzzp_),
                Jurisdiction = new List<CodeableConcept>((IEnumerable<CodeableConcept>)dzzzq_),
                PurposeElement = dzzzr_,
                UsageElement = dzzzs_,
                CopyrightElement = dzzzt_,
                ApprovalDateElement = dzzzu_,
                LastReviewDateElement = dzzzv_,
                EffectivePeriod = dzzzw_,
                Topic = new List<CodeableConcept>((IEnumerable<CodeableConcept>)dzzzx_),
                Author = new List<ContactDetail>((IEnumerable<ContactDetail>)dzzzy_),
                Editor = new List<ContactDetail>((IEnumerable<ContactDetail>)dzzzz_),
                Reviewer = new List<ContactDetail>((IEnumerable<ContactDetail>)ezzza_),
                Endorser = new List<ContactDetail>((IEnumerable<ContactDetail>)ezzzb_),
                RelatedArtifact = new List<RelatedArtifact>((IEnumerable<RelatedArtifact>)ezzzc_),
                LibraryElement = new List<Canonical>((IEnumerable<Canonical>)ezzzd_),
                DisclaimerElement = ezzze_,
                Scoring = ezzzf_,
                CompositeScoring = ezzzg_,
                Type = new List<CodeableConcept>((IEnumerable<CodeableConcept>)ezzzh_),
                RiskAdjustmentElement = ezzzi_,
                RateAggregationElement = ezzzj_,
                RationaleElement = ezzzk_,
                ClinicalRecommendationStatementElement = ezzzl_,
                ImprovementNotation = ezzzm_,
                DefinitionElement = new List<Markdown>((IEnumerable<Markdown>)ezzzn_),
                GuidanceElement = ezzzo_,
                Group = new List<Measure.GroupComponent>((IEnumerable<Measure.GroupComponent>)ezzzp_),
                SupplementalData = new List<Measure.SupplementalDataComponent>((IEnumerable<Measure.SupplementalDataComponent>)ezzzq_),
            };

            return ezzzr_;
        };
        IEnumerable<Measure> czzzz_ = context.Operators.Select<Measure, Measure>((IEnumerable<Measure>)czzzx_, czzzy_);
        IEnumerable<Measure> dzzza_ = context.Operators.Distinct<Measure>(czzzz_);
        Measure dzzzb_ = context.Operators.SingletonFrom<Measure>(dzzza_);

        return dzzzb_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public MeasureReport MeasureReportResource(CqlContext context, MeasureReport arg)
    {
        MeasureReport[] ezzzs_ = [
            arg,
        ];
        MeasureReport ezzzt_(MeasureReport a)
        {
            List<Identifier> ezzzx_ = a?.Identifier;
            Code<MeasureReport.MeasureReportStatus> ezzzy_ = a?.StatusElement;
            Code<MeasureReport.MeasureReportType> ezzzz_ = a?.TypeElement;
            Canonical fzzza_ = a?.MeasureElement;
            ResourceReference fzzzb_ = a?.Subject;
            FhirDateTime fzzzc_ = a?.DateElement;
            ResourceReference fzzzd_ = a?.Reporter;
            Period fzzze_ = a?.Period;
            CodeableConcept fzzzf_ = a?.ImprovementNotation;
            List<MeasureReport.GroupComponent> fzzzg_ = a?.Group;
            List<ResourceReference> fzzzh_ = a?.EvaluatedResource;
            MeasureReport fzzzi_ = new MeasureReport
            {
                Identifier = new List<Identifier>((IEnumerable<Identifier>)ezzzx_),
                StatusElement = ezzzy_,
                TypeElement = ezzzz_,
                MeasureElement = fzzza_,
                Subject = fzzzb_,
                DateElement = fzzzc_,
                Reporter = fzzzd_,
                Period = fzzze_,
                ImprovementNotation = fzzzf_,
                Group = new List<MeasureReport.GroupComponent>((IEnumerable<MeasureReport.GroupComponent>)fzzzg_),
                EvaluatedResource = new List<ResourceReference>((IEnumerable<ResourceReference>)fzzzh_),
            };

            return fzzzi_;
        };
        IEnumerable<MeasureReport> ezzzu_ = context.Operators.Select<MeasureReport, MeasureReport>((IEnumerable<MeasureReport>)ezzzs_, ezzzt_);
        IEnumerable<MeasureReport> ezzzv_ = context.Operators.Distinct<MeasureReport>(ezzzu_);
        MeasureReport ezzzw_ = context.Operators.SingletonFrom<MeasureReport>(ezzzv_);

        return ezzzw_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public Medication MedicationResource(CqlContext context, Medication arg)
    {
        Medication[] fzzzj_ = [
            arg,
        ];
        Medication fzzzk_(Medication a)
        {
            List<Identifier> fzzzo_ = a?.Identifier;
            CodeableConcept fzzzp_ = a?.Code;
            Code<Medication.MedicationStatusCodes> fzzzq_ = a?.StatusElement;
            ResourceReference fzzzr_ = a?.Manufacturer;
            CodeableConcept fzzzs_ = a?.Form;
            Ratio fzzzt_ = a?.Amount;
            List<Medication.IngredientComponent> fzzzu_ = a?.Ingredient;
            Medication.BatchComponent fzzzv_ = a?.Batch;
            Medication fzzzw_ = new Medication
            {
                Identifier = new List<Identifier>((IEnumerable<Identifier>)fzzzo_),
                Code = fzzzp_,
                StatusElement = fzzzq_,
                Manufacturer = fzzzr_,
                Form = fzzzs_,
                Amount = fzzzt_,
                Ingredient = new List<Medication.IngredientComponent>((IEnumerable<Medication.IngredientComponent>)fzzzu_),
                Batch = fzzzv_,
            };

            return fzzzw_;
        };
        IEnumerable<Medication> fzzzl_ = context.Operators.Select<Medication, Medication>((IEnumerable<Medication>)fzzzj_, fzzzk_);
        IEnumerable<Medication> fzzzm_ = context.Operators.Distinct<Medication>(fzzzl_);
        Medication fzzzn_ = context.Operators.SingletonFrom<Medication>(fzzzm_);

        return fzzzn_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public MedicationAdministration MedicationAdministrationResource(CqlContext context, MedicationAdministration arg)
    {
        MedicationAdministration[] fzzzx_ = [
            arg,
        ];
        MedicationAdministration fzzzy_(MedicationAdministration a)
        {
            List<Identifier> gzzzc_ = a?.Identifier;
            List<FhirUri> gzzzd_ = a?.InstantiatesElement;
            List<ResourceReference> gzzze_ = a?.PartOf;
            Code<MedicationAdministration.MedicationAdministrationStatusCodes> gzzzf_ = a?.StatusElement;
            List<CodeableConcept> gzzzg_ = a?.StatusReason;
            CodeableConcept gzzzh_ = a?.Category;
            DataType gzzzi_ = a?.Medication;
            ResourceReference gzzzj_ = a?.Subject;
            ResourceReference gzzzk_ = a?.Context;
            List<ResourceReference> gzzzl_ = a?.SupportingInformation;
            DataType gzzzm_ = a?.Effective;
            List<MedicationAdministration.PerformerComponent> gzzzn_ = a?.Performer;
            List<CodeableConcept> gzzzo_ = a?.ReasonCode;
            List<ResourceReference> gzzzp_ = a?.ReasonReference;
            ResourceReference gzzzq_ = a?.Request;
            List<ResourceReference> gzzzr_ = a?.Device;
            List<Annotation> gzzzs_ = a?.Note;
            MedicationAdministration.DosageComponent gzzzt_ = a?.Dosage;
            List<ResourceReference> gzzzu_ = a?.EventHistory;
            MedicationAdministration gzzzv_ = new MedicationAdministration
            {
                Identifier = new List<Identifier>((IEnumerable<Identifier>)gzzzc_),
                InstantiatesElement = new List<FhirUri>((IEnumerable<FhirUri>)gzzzd_),
                PartOf = new List<ResourceReference>((IEnumerable<ResourceReference>)gzzze_),
                StatusElement = gzzzf_,
                StatusReason = new List<CodeableConcept>((IEnumerable<CodeableConcept>)gzzzg_),
                Category = gzzzh_,
                Medication = (DataType)gzzzi_,
                Subject = gzzzj_,
                Context = gzzzk_,
                SupportingInformation = new List<ResourceReference>((IEnumerable<ResourceReference>)gzzzl_),
                Effective = (DataType)gzzzm_,
                Performer = new List<MedicationAdministration.PerformerComponent>((IEnumerable<MedicationAdministration.PerformerComponent>)gzzzn_),
                ReasonCode = new List<CodeableConcept>((IEnumerable<CodeableConcept>)gzzzo_),
                ReasonReference = new List<ResourceReference>((IEnumerable<ResourceReference>)gzzzp_),
                Request = gzzzq_,
                Device = new List<ResourceReference>((IEnumerable<ResourceReference>)gzzzr_),
                Note = new List<Annotation>((IEnumerable<Annotation>)gzzzs_),
                Dosage = gzzzt_,
                EventHistory = new List<ResourceReference>((IEnumerable<ResourceReference>)gzzzu_),
            };

            return gzzzv_;
        };
        IEnumerable<MedicationAdministration> fzzzz_ = context.Operators.Select<MedicationAdministration, MedicationAdministration>((IEnumerable<MedicationAdministration>)fzzzx_, fzzzy_);
        IEnumerable<MedicationAdministration> gzzza_ = context.Operators.Distinct<MedicationAdministration>(fzzzz_);
        MedicationAdministration gzzzb_ = context.Operators.SingletonFrom<MedicationAdministration>(gzzza_);

        return gzzzb_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public MedicationDispense MedicationDispenseResource(CqlContext context, MedicationDispense arg)
    {
        MedicationDispense[] gzzzw_ = [
            arg,
        ];
        MedicationDispense gzzzx_(MedicationDispense a)
        {
            List<Identifier> hzzzb_ = a?.Identifier;
            List<ResourceReference> hzzzc_ = a?.PartOf;
            Code<MedicationDispense.MedicationDispenseStatusCodes> hzzzd_ = a?.StatusElement;
            DataType hzzze_ = a?.StatusReason;
            CodeableConcept hzzzf_ = a?.Category;
            DataType hzzzg_ = a?.Medication;
            ResourceReference hzzzh_ = a?.Subject;
            ResourceReference hzzzi_ = a?.Context;
            List<ResourceReference> hzzzj_ = a?.SupportingInformation;
            List<MedicationDispense.PerformerComponent> hzzzk_ = a?.Performer;
            ResourceReference hzzzl_ = a?.Location;
            List<ResourceReference> hzzzm_ = a?.AuthorizingPrescription;
            CodeableConcept hzzzn_ = a?.Type;
            Quantity hzzzo_ = a?.Quantity;
            Quantity hzzzp_ = a?.DaysSupply;
            FhirDateTime hzzzq_ = a?.WhenPreparedElement;
            FhirDateTime hzzzr_ = a?.WhenHandedOverElement;
            ResourceReference hzzzs_ = a?.Destination;
            List<ResourceReference> hzzzt_ = a?.Receiver;
            List<Annotation> hzzzu_ = a?.Note;
            List<Dosage> hzzzv_ = a?.DosageInstruction;
            MedicationDispense.SubstitutionComponent hzzzw_ = a?.Substitution;
            List<ResourceReference> hzzzx_ = a?.DetectedIssue;
            List<ResourceReference> hzzzy_ = a?.EventHistory;
            MedicationDispense hzzzz_ = new MedicationDispense
            {
                Identifier = new List<Identifier>((IEnumerable<Identifier>)hzzzb_),
                PartOf = new List<ResourceReference>((IEnumerable<ResourceReference>)hzzzc_),
                StatusElement = hzzzd_,
                StatusReason = (DataType)hzzze_,
                Category = hzzzf_,
                Medication = (DataType)hzzzg_,
                Subject = hzzzh_,
                Context = hzzzi_,
                SupportingInformation = new List<ResourceReference>((IEnumerable<ResourceReference>)hzzzj_),
                Performer = new List<MedicationDispense.PerformerComponent>((IEnumerable<MedicationDispense.PerformerComponent>)hzzzk_),
                Location = hzzzl_,
                AuthorizingPrescription = new List<ResourceReference>((IEnumerable<ResourceReference>)hzzzm_),
                Type = hzzzn_,
                Quantity = hzzzo_,
                DaysSupply = hzzzp_,
                WhenPreparedElement = hzzzq_,
                WhenHandedOverElement = hzzzr_,
                Destination = hzzzs_,
                Receiver = new List<ResourceReference>((IEnumerable<ResourceReference>)hzzzt_),
                Note = new List<Annotation>((IEnumerable<Annotation>)hzzzu_),
                DosageInstruction = new List<Dosage>((IEnumerable<Dosage>)hzzzv_),
                Substitution = hzzzw_,
                DetectedIssue = new List<ResourceReference>((IEnumerable<ResourceReference>)hzzzx_),
                EventHistory = new List<ResourceReference>((IEnumerable<ResourceReference>)hzzzy_),
            };

            return hzzzz_;
        };
        IEnumerable<MedicationDispense> gzzzy_ = context.Operators.Select<MedicationDispense, MedicationDispense>((IEnumerable<MedicationDispense>)gzzzw_, gzzzx_);
        IEnumerable<MedicationDispense> gzzzz_ = context.Operators.Distinct<MedicationDispense>(gzzzy_);
        MedicationDispense hzzza_ = context.Operators.SingletonFrom<MedicationDispense>(gzzzz_);

        return hzzza_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public MedicationKnowledge MedicationKnowledgeResource(CqlContext context, MedicationKnowledge arg)
    {
        MedicationKnowledge[] izzza_ = [
            arg,
        ];
        MedicationKnowledge izzzb_(MedicationKnowledge a)
        {
            CodeableConcept izzzf_ = a?.Code;
            Code<MedicationKnowledge.MedicationKnowledgeStatusCodes> izzzg_ = a?.StatusElement;
            ResourceReference izzzh_ = a?.Manufacturer;
            CodeableConcept izzzi_ = a?.DoseForm;
            Quantity izzzj_ = a?.Amount;
            List<FhirString> izzzk_ = a?.SynonymElement;
            List<MedicationKnowledge.RelatedMedicationKnowledgeComponent> izzzl_ = a?.RelatedMedicationKnowledge;
            List<ResourceReference> izzzm_ = a?.AssociatedMedication;
            List<CodeableConcept> izzzn_ = a?.ProductType;
            List<MedicationKnowledge.MonographComponent> izzzo_ = a?.Monograph;
            List<MedicationKnowledge.IngredientComponent> izzzp_ = a?.Ingredient;
            Markdown izzzq_ = a?.PreparationInstructionElement;
            List<CodeableConcept> izzzr_ = a?.IntendedRoute;
            List<MedicationKnowledge.CostComponent> izzzs_ = a?.Cost;
            List<MedicationKnowledge.MonitoringProgramComponent> izzzt_ = a?.MonitoringProgram;
            List<MedicationKnowledge.AdministrationGuidelinesComponent> izzzu_ = a?.AdministrationGuidelines;
            List<MedicationKnowledge.MedicineClassificationComponent> izzzv_ = a?.MedicineClassification;
            MedicationKnowledge.PackagingComponent izzzw_ = a?.Packaging;
            List<MedicationKnowledge.DrugCharacteristicComponent> izzzx_ = a?.DrugCharacteristic;
            List<ResourceReference> izzzy_ = a?.Contraindication;
            List<MedicationKnowledge.RegulatoryComponent> izzzz_ = a?.Regulatory;
            List<MedicationKnowledge.KineticsComponent> jzzza_ = a?.Kinetics;
            MedicationKnowledge jzzzb_ = new MedicationKnowledge
            {
                Code = izzzf_,
                StatusElement = izzzg_,
                Manufacturer = izzzh_,
                DoseForm = izzzi_,
                Amount = izzzj_,
                SynonymElement = new List<FhirString>((IEnumerable<FhirString>)izzzk_),
                RelatedMedicationKnowledge = new List<MedicationKnowledge.RelatedMedicationKnowledgeComponent>((IEnumerable<MedicationKnowledge.RelatedMedicationKnowledgeComponent>)izzzl_),
                AssociatedMedication = new List<ResourceReference>((IEnumerable<ResourceReference>)izzzm_),
                ProductType = new List<CodeableConcept>((IEnumerable<CodeableConcept>)izzzn_),
                Monograph = new List<MedicationKnowledge.MonographComponent>((IEnumerable<MedicationKnowledge.MonographComponent>)izzzo_),
                Ingredient = new List<MedicationKnowledge.IngredientComponent>((IEnumerable<MedicationKnowledge.IngredientComponent>)izzzp_),
                PreparationInstructionElement = izzzq_,
                IntendedRoute = new List<CodeableConcept>((IEnumerable<CodeableConcept>)izzzr_),
                Cost = new List<MedicationKnowledge.CostComponent>((IEnumerable<MedicationKnowledge.CostComponent>)izzzs_),
                MonitoringProgram = new List<MedicationKnowledge.MonitoringProgramComponent>((IEnumerable<MedicationKnowledge.MonitoringProgramComponent>)izzzt_),
                AdministrationGuidelines = new List<MedicationKnowledge.AdministrationGuidelinesComponent>((IEnumerable<MedicationKnowledge.AdministrationGuidelinesComponent>)izzzu_),
                MedicineClassification = new List<MedicationKnowledge.MedicineClassificationComponent>((IEnumerable<MedicationKnowledge.MedicineClassificationComponent>)izzzv_),
                Packaging = izzzw_,
                DrugCharacteristic = new List<MedicationKnowledge.DrugCharacteristicComponent>((IEnumerable<MedicationKnowledge.DrugCharacteristicComponent>)izzzx_),
                Contraindication = new List<ResourceReference>((IEnumerable<ResourceReference>)izzzy_),
                Regulatory = new List<MedicationKnowledge.RegulatoryComponent>((IEnumerable<MedicationKnowledge.RegulatoryComponent>)izzzz_),
                Kinetics = new List<MedicationKnowledge.KineticsComponent>((IEnumerable<MedicationKnowledge.KineticsComponent>)jzzza_),
            };

            return jzzzb_;
        };
        IEnumerable<MedicationKnowledge> izzzc_ = context.Operators.Select<MedicationKnowledge, MedicationKnowledge>((IEnumerable<MedicationKnowledge>)izzza_, izzzb_);
        IEnumerable<MedicationKnowledge> izzzd_ = context.Operators.Distinct<MedicationKnowledge>(izzzc_);
        MedicationKnowledge izzze_ = context.Operators.SingletonFrom<MedicationKnowledge>(izzzd_);

        return izzze_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public MedicationRequest MedicationRequestResource(CqlContext context, MedicationRequest arg)
    {
        MedicationRequest[] jzzzc_ = [
            arg,
        ];
        MedicationRequest jzzzd_(MedicationRequest a)
        {
            List<Identifier> jzzzh_ = a?.Identifier;
            Code<MedicationRequest.MedicationrequestStatus> jzzzi_ = a?.StatusElement;
            CodeableConcept jzzzj_ = a?.StatusReason;
            Code<MedicationRequest.MedicationRequestIntent> jzzzk_ = a?.IntentElement;
            List<CodeableConcept> jzzzl_ = a?.Category;
            Code<RequestPriority> jzzzm_ = a?.PriorityElement;
            FhirBoolean jzzzn_ = a?.DoNotPerformElement;
            DataType jzzzo_ = a?.Reported;
            DataType jzzzp_ = a?.Medication;
            ResourceReference jzzzq_ = a?.Subject;
            ResourceReference jzzzr_ = a?.Encounter;
            List<ResourceReference> jzzzs_ = a?.SupportingInformation;
            FhirDateTime jzzzt_ = a?.AuthoredOnElement;
            ResourceReference jzzzu_ = a?.Requester;
            ResourceReference jzzzv_ = a?.Performer;
            CodeableConcept jzzzw_ = a?.PerformerType;
            ResourceReference jzzzx_ = a?.Recorder;
            List<CodeableConcept> jzzzy_ = a?.ReasonCode;
            List<ResourceReference> jzzzz_ = a?.ReasonReference;
            List<Canonical> kzzza_ = a?.InstantiatesCanonicalElement;
            List<FhirUri> kzzzb_ = a?.InstantiatesUriElement;
            List<ResourceReference> kzzzc_ = a?.BasedOn;
            Identifier kzzzd_ = a?.GroupIdentifier;
            CodeableConcept kzzze_ = a?.CourseOfTherapyType;
            List<ResourceReference> kzzzf_ = a?.Insurance;
            List<Annotation> kzzzg_ = a?.Note;
            List<Dosage> kzzzh_ = a?.DosageInstruction;
            MedicationRequest.DispenseRequestComponent kzzzi_ = a?.DispenseRequest;
            MedicationRequest.SubstitutionComponent kzzzj_ = a?.Substitution;
            ResourceReference kzzzk_ = a?.PriorPrescription;
            List<ResourceReference> kzzzl_ = a?.DetectedIssue;
            List<ResourceReference> kzzzm_ = a?.EventHistory;
            MedicationRequest kzzzn_ = new MedicationRequest
            {
                Identifier = new List<Identifier>((IEnumerable<Identifier>)jzzzh_),
                StatusElement = jzzzi_,
                StatusReason = jzzzj_,
                IntentElement = jzzzk_,
                Category = new List<CodeableConcept>((IEnumerable<CodeableConcept>)jzzzl_),
                PriorityElement = jzzzm_,
                DoNotPerformElement = jzzzn_,
                Reported = (DataType)jzzzo_,
                Medication = (DataType)jzzzp_,
                Subject = jzzzq_,
                Encounter = jzzzr_,
                SupportingInformation = new List<ResourceReference>((IEnumerable<ResourceReference>)jzzzs_),
                AuthoredOnElement = jzzzt_,
                Requester = jzzzu_,
                Performer = jzzzv_,
                PerformerType = jzzzw_,
                Recorder = jzzzx_,
                ReasonCode = new List<CodeableConcept>((IEnumerable<CodeableConcept>)jzzzy_),
                ReasonReference = new List<ResourceReference>((IEnumerable<ResourceReference>)jzzzz_),
                InstantiatesCanonicalElement = new List<Canonical>((IEnumerable<Canonical>)kzzza_),
                InstantiatesUriElement = new List<FhirUri>((IEnumerable<FhirUri>)kzzzb_),
                BasedOn = new List<ResourceReference>((IEnumerable<ResourceReference>)kzzzc_),
                GroupIdentifier = kzzzd_,
                CourseOfTherapyType = kzzze_,
                Insurance = new List<ResourceReference>((IEnumerable<ResourceReference>)kzzzf_),
                Note = new List<Annotation>((IEnumerable<Annotation>)kzzzg_),
                DosageInstruction = new List<Dosage>((IEnumerable<Dosage>)kzzzh_),
                DispenseRequest = kzzzi_,
                Substitution = kzzzj_,
                PriorPrescription = kzzzk_,
                DetectedIssue = new List<ResourceReference>((IEnumerable<ResourceReference>)kzzzl_),
                EventHistory = new List<ResourceReference>((IEnumerable<ResourceReference>)kzzzm_),
            };

            return kzzzn_;
        };
        IEnumerable<MedicationRequest> jzzze_ = context.Operators.Select<MedicationRequest, MedicationRequest>((IEnumerable<MedicationRequest>)jzzzc_, jzzzd_);
        IEnumerable<MedicationRequest> jzzzf_ = context.Operators.Distinct<MedicationRequest>(jzzze_);
        MedicationRequest jzzzg_ = context.Operators.SingletonFrom<MedicationRequest>(jzzzf_);

        return jzzzg_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public MedicationStatement MedicationStatementResource(CqlContext context, MedicationStatement arg)
    {
        MedicationStatement[] kzzzo_ = [
            arg,
        ];
        MedicationStatement kzzzp_(MedicationStatement a)
        {
            List<Identifier> kzzzt_ = a?.Identifier;
            List<ResourceReference> kzzzu_ = a?.BasedOn;
            List<ResourceReference> kzzzv_ = a?.PartOf;
            Code<MedicationStatement.MedicationStatusCodes> kzzzw_ = a?.StatusElement;
            List<CodeableConcept> kzzzx_ = a?.StatusReason;
            CodeableConcept kzzzy_ = a?.Category;
            DataType kzzzz_ = a?.Medication;
            ResourceReference lzzza_ = a?.Subject;
            ResourceReference lzzzb_ = a?.Context;
            DataType lzzzc_ = a?.Effective;
            FhirDateTime lzzzd_ = a?.DateAssertedElement;
            ResourceReference lzzze_ = a?.InformationSource;
            List<ResourceReference> lzzzf_ = a?.DerivedFrom;
            List<CodeableConcept> lzzzg_ = a?.ReasonCode;
            List<ResourceReference> lzzzh_ = a?.ReasonReference;
            List<Annotation> lzzzi_ = a?.Note;
            List<Dosage> lzzzj_ = a?.Dosage;
            MedicationStatement lzzzk_ = new MedicationStatement
            {
                Identifier = new List<Identifier>((IEnumerable<Identifier>)kzzzt_),
                BasedOn = new List<ResourceReference>((IEnumerable<ResourceReference>)kzzzu_),
                PartOf = new List<ResourceReference>((IEnumerable<ResourceReference>)kzzzv_),
                StatusElement = kzzzw_,
                StatusReason = new List<CodeableConcept>((IEnumerable<CodeableConcept>)kzzzx_),
                Category = kzzzy_,
                Medication = (DataType)kzzzz_,
                Subject = lzzza_,
                Context = lzzzb_,
                Effective = (DataType)lzzzc_,
                DateAssertedElement = lzzzd_,
                InformationSource = lzzze_,
                DerivedFrom = new List<ResourceReference>((IEnumerable<ResourceReference>)lzzzf_),
                ReasonCode = new List<CodeableConcept>((IEnumerable<CodeableConcept>)lzzzg_),
                ReasonReference = new List<ResourceReference>((IEnumerable<ResourceReference>)lzzzh_),
                Note = new List<Annotation>((IEnumerable<Annotation>)lzzzi_),
                Dosage = new List<Dosage>((IEnumerable<Dosage>)lzzzj_),
            };

            return lzzzk_;
        };
        IEnumerable<MedicationStatement> kzzzq_ = context.Operators.Select<MedicationStatement, MedicationStatement>((IEnumerable<MedicationStatement>)kzzzo_, kzzzp_);
        IEnumerable<MedicationStatement> kzzzr_ = context.Operators.Distinct<MedicationStatement>(kzzzq_);
        MedicationStatement kzzzs_ = context.Operators.SingletonFrom<MedicationStatement>(kzzzr_);

        return kzzzs_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public MedicinalProduct MedicinalProductResource(CqlContext context, MedicinalProduct arg)
    {
        MedicinalProduct[] lzzzl_ = [
            arg,
        ];
        MedicinalProduct lzzzm_(MedicinalProduct a)
        {
            List<Identifier> lzzzq_ = a?.Identifier;
            CodeableConcept lzzzr_ = a?.Type;
            Coding lzzzs_ = a?.Domain;
            CodeableConcept lzzzt_ = a?.CombinedPharmaceuticalDoseForm;
            CodeableConcept lzzzu_ = a?.LegalStatusOfSupply;
            CodeableConcept lzzzv_ = a?.AdditionalMonitoringIndicator;
            List<FhirString> lzzzw_ = a?.SpecialMeasuresElement;
            CodeableConcept lzzzx_ = a?.PaediatricUseIndicator;
            List<CodeableConcept> lzzzy_ = a?.ProductClassification;
            List<MarketingStatus> lzzzz_ = a?.MarketingStatus;
            List<ResourceReference> mzzza_ = a?.PharmaceuticalProduct;
            List<ResourceReference> mzzzb_ = a?.PackagedMedicinalProduct;
            List<ResourceReference> mzzzc_ = a?.AttachedDocument;
            List<ResourceReference> mzzzd_ = a?.MasterFile;
            List<ResourceReference> mzzze_ = a?.Contact;
            List<ResourceReference> mzzzf_ = a?.ClinicalTrial;
            List<MedicinalProduct.NameComponent> mzzzg_ = a?.Name;
            List<Identifier> mzzzh_ = a?.CrossReference;
            List<MedicinalProduct.ManufacturingBusinessOperationComponent> mzzzi_ = a?.ManufacturingBusinessOperation;
            List<MedicinalProduct.SpecialDesignationComponent> mzzzj_ = a?.SpecialDesignation;
            MedicinalProduct mzzzk_ = new MedicinalProduct
            {
                Identifier = new List<Identifier>((IEnumerable<Identifier>)lzzzq_),
                Type = lzzzr_,
                Domain = lzzzs_,
                CombinedPharmaceuticalDoseForm = lzzzt_,
                LegalStatusOfSupply = lzzzu_,
                AdditionalMonitoringIndicator = lzzzv_,
                SpecialMeasuresElement = new List<FhirString>((IEnumerable<FhirString>)lzzzw_),
                PaediatricUseIndicator = lzzzx_,
                ProductClassification = new List<CodeableConcept>((IEnumerable<CodeableConcept>)lzzzy_),
                MarketingStatus = new List<MarketingStatus>((IEnumerable<MarketingStatus>)lzzzz_),
                PharmaceuticalProduct = new List<ResourceReference>((IEnumerable<ResourceReference>)mzzza_),
                PackagedMedicinalProduct = new List<ResourceReference>((IEnumerable<ResourceReference>)mzzzb_),
                AttachedDocument = new List<ResourceReference>((IEnumerable<ResourceReference>)mzzzc_),
                MasterFile = new List<ResourceReference>((IEnumerable<ResourceReference>)mzzzd_),
                Contact = new List<ResourceReference>((IEnumerable<ResourceReference>)mzzze_),
                ClinicalTrial = new List<ResourceReference>((IEnumerable<ResourceReference>)mzzzf_),
                Name = new List<MedicinalProduct.NameComponent>((IEnumerable<MedicinalProduct.NameComponent>)mzzzg_),
                CrossReference = new List<Identifier>((IEnumerable<Identifier>)mzzzh_),
                ManufacturingBusinessOperation = new List<MedicinalProduct.ManufacturingBusinessOperationComponent>((IEnumerable<MedicinalProduct.ManufacturingBusinessOperationComponent>)mzzzi_),
                SpecialDesignation = new List<MedicinalProduct.SpecialDesignationComponent>((IEnumerable<MedicinalProduct.SpecialDesignationComponent>)mzzzj_),
            };

            return mzzzk_;
        };
        IEnumerable<MedicinalProduct> lzzzn_ = context.Operators.Select<MedicinalProduct, MedicinalProduct>((IEnumerable<MedicinalProduct>)lzzzl_, lzzzm_);
        IEnumerable<MedicinalProduct> lzzzo_ = context.Operators.Distinct<MedicinalProduct>(lzzzn_);
        MedicinalProduct lzzzp_ = context.Operators.SingletonFrom<MedicinalProduct>(lzzzo_);

        return lzzzp_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public MedicinalProductAuthorization MedicinalProductAuthorizationResource(CqlContext context, MedicinalProductAuthorization arg)
    {
        MedicinalProductAuthorization[] mzzzl_ = [
            arg,
        ];
        MedicinalProductAuthorization mzzzm_(MedicinalProductAuthorization a)
        {
            List<Identifier> mzzzq_ = a?.Identifier;
            ResourceReference mzzzr_ = a?.Subject;
            List<CodeableConcept> mzzzs_ = a?.Country;
            List<CodeableConcept> mzzzt_ = a?.Jurisdiction;
            CodeableConcept mzzzu_ = a?.Status;
            FhirDateTime mzzzv_ = a?.StatusDateElement;
            FhirDateTime mzzzw_ = a?.RestoreDateElement;
            Period mzzzx_ = a?.ValidityPeriod;
            Period mzzzy_ = a?.DataExclusivityPeriod;
            FhirDateTime mzzzz_ = a?.DateOfFirstAuthorizationElement;
            FhirDateTime nzzza_ = a?.InternationalBirthDateElement;
            CodeableConcept nzzzb_ = a?.LegalBasis;
            List<MedicinalProductAuthorization.JurisdictionalAuthorizationComponent> nzzzc_ = a?.JurisdictionalAuthorization;
            ResourceReference nzzzd_ = a?.Holder;
            ResourceReference nzzze_ = a?.Regulator;
            MedicinalProductAuthorization.ProcedureComponent nzzzf_ = a?.Procedure;
            MedicinalProductAuthorization nzzzg_ = new MedicinalProductAuthorization
            {
                Identifier = new List<Identifier>((IEnumerable<Identifier>)mzzzq_),
                Subject = mzzzr_,
                Country = new List<CodeableConcept>((IEnumerable<CodeableConcept>)mzzzs_),
                Jurisdiction = new List<CodeableConcept>((IEnumerable<CodeableConcept>)mzzzt_),
                Status = mzzzu_,
                StatusDateElement = mzzzv_,
                RestoreDateElement = mzzzw_,
                ValidityPeriod = mzzzx_,
                DataExclusivityPeriod = mzzzy_,
                DateOfFirstAuthorizationElement = mzzzz_,
                InternationalBirthDateElement = nzzza_,
                LegalBasis = nzzzb_,
                JurisdictionalAuthorization = new List<MedicinalProductAuthorization.JurisdictionalAuthorizationComponent>((IEnumerable<MedicinalProductAuthorization.JurisdictionalAuthorizationComponent>)nzzzc_),
                Holder = nzzzd_,
                Regulator = nzzze_,
                Procedure = nzzzf_,
            };

            return nzzzg_;
        };
        IEnumerable<MedicinalProductAuthorization> mzzzn_ = context.Operators.Select<MedicinalProductAuthorization, MedicinalProductAuthorization>((IEnumerable<MedicinalProductAuthorization>)mzzzl_, mzzzm_);
        IEnumerable<MedicinalProductAuthorization> mzzzo_ = context.Operators.Distinct<MedicinalProductAuthorization>(mzzzn_);
        MedicinalProductAuthorization mzzzp_ = context.Operators.SingletonFrom<MedicinalProductAuthorization>(mzzzo_);

        return mzzzp_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public MedicinalProductContraindication MedicinalProductContraindicationResource(CqlContext context, MedicinalProductContraindication arg)
    {
        MedicinalProductContraindication[] nzzzh_ = [
            arg,
        ];
        MedicinalProductContraindication nzzzi_(MedicinalProductContraindication a)
        {
            List<ResourceReference> nzzzm_ = a?.Subject;
            CodeableConcept nzzzn_ = a?.Disease;
            CodeableConcept nzzzo_ = a?.DiseaseStatus;
            List<CodeableConcept> nzzzp_ = a?.Comorbidity;
            List<ResourceReference> nzzzq_ = a?.TherapeuticIndication;
            List<MedicinalProductContraindication.OtherTherapyComponent> nzzzr_ = a?.OtherTherapy;
            List<Population> nzzzs_ = a?.Population;
            MedicinalProductContraindication nzzzt_ = new MedicinalProductContraindication
            {
                Subject = new List<ResourceReference>((IEnumerable<ResourceReference>)nzzzm_),
                Disease = nzzzn_,
                DiseaseStatus = nzzzo_,
                Comorbidity = new List<CodeableConcept>((IEnumerable<CodeableConcept>)nzzzp_),
                TherapeuticIndication = new List<ResourceReference>((IEnumerable<ResourceReference>)nzzzq_),
                OtherTherapy = new List<MedicinalProductContraindication.OtherTherapyComponent>((IEnumerable<MedicinalProductContraindication.OtherTherapyComponent>)nzzzr_),
                Population = new List<Population>((IEnumerable<Population>)nzzzs_),
            };

            return nzzzt_;
        };
        IEnumerable<MedicinalProductContraindication> nzzzj_ = context.Operators.Select<MedicinalProductContraindication, MedicinalProductContraindication>((IEnumerable<MedicinalProductContraindication>)nzzzh_, nzzzi_);
        IEnumerable<MedicinalProductContraindication> nzzzk_ = context.Operators.Distinct<MedicinalProductContraindication>(nzzzj_);
        MedicinalProductContraindication nzzzl_ = context.Operators.SingletonFrom<MedicinalProductContraindication>(nzzzk_);

        return nzzzl_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public MedicinalProductIngredient MedicinalProductIngredientResource(CqlContext context, MedicinalProductIngredient arg)
    {
        MedicinalProductIngredient[] nzzzu_ = [
            arg,
        ];
        MedicinalProductIngredient nzzzv_(MedicinalProductIngredient a)
        {
            Identifier nzzzz_ = a?.Identifier;
            CodeableConcept ozzza_ = a?.Role;
            FhirBoolean ozzzb_ = a?.AllergenicIndicatorElement;
            List<ResourceReference> ozzzc_ = a?.Manufacturer;
            List<MedicinalProductIngredient.SpecifiedSubstanceComponent> ozzzd_ = a?.SpecifiedSubstance;
            MedicinalProductIngredient.SubstanceComponent ozzze_ = a?.Substance;
            MedicinalProductIngredient ozzzf_ = new MedicinalProductIngredient
            {
                Identifier = nzzzz_,
                Role = ozzza_,
                AllergenicIndicatorElement = ozzzb_,
                Manufacturer = new List<ResourceReference>((IEnumerable<ResourceReference>)ozzzc_),
                SpecifiedSubstance = new List<MedicinalProductIngredient.SpecifiedSubstanceComponent>((IEnumerable<MedicinalProductIngredient.SpecifiedSubstanceComponent>)ozzzd_),
                Substance = ozzze_,
            };

            return ozzzf_;
        };
        IEnumerable<MedicinalProductIngredient> nzzzw_ = context.Operators.Select<MedicinalProductIngredient, MedicinalProductIngredient>((IEnumerable<MedicinalProductIngredient>)nzzzu_, nzzzv_);
        IEnumerable<MedicinalProductIngredient> nzzzx_ = context.Operators.Distinct<MedicinalProductIngredient>(nzzzw_);
        MedicinalProductIngredient nzzzy_ = context.Operators.SingletonFrom<MedicinalProductIngredient>(nzzzx_);

        return nzzzy_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public MedicinalProductInteraction MedicinalProductInteractionResource(CqlContext context, MedicinalProductInteraction arg)
    {
        MedicinalProductInteraction[] ozzzg_ = [
            arg,
        ];
        MedicinalProductInteraction ozzzh_(MedicinalProductInteraction a)
        {
            List<ResourceReference> ozzzl_ = a?.Subject;
            FhirString ozzzm_ = a?.DescriptionElement;
            List<MedicinalProductInteraction.InteractantComponent> ozzzn_ = a?.Interactant;
            CodeableConcept ozzzo_ = a?.Type;
            CodeableConcept ozzzp_ = a?.Effect;
            CodeableConcept ozzzq_ = a?.Incidence;
            CodeableConcept ozzzr_ = a?.Management;
            MedicinalProductInteraction ozzzs_ = new MedicinalProductInteraction
            {
                Subject = new List<ResourceReference>((IEnumerable<ResourceReference>)ozzzl_),
                DescriptionElement = ozzzm_,
                Interactant = new List<MedicinalProductInteraction.InteractantComponent>((IEnumerable<MedicinalProductInteraction.InteractantComponent>)ozzzn_),
                Type = ozzzo_,
                Effect = ozzzp_,
                Incidence = ozzzq_,
                Management = ozzzr_,
            };

            return ozzzs_;
        };
        IEnumerable<MedicinalProductInteraction> ozzzi_ = context.Operators.Select<MedicinalProductInteraction, MedicinalProductInteraction>((IEnumerable<MedicinalProductInteraction>)ozzzg_, ozzzh_);
        IEnumerable<MedicinalProductInteraction> ozzzj_ = context.Operators.Distinct<MedicinalProductInteraction>(ozzzi_);
        MedicinalProductInteraction ozzzk_ = context.Operators.SingletonFrom<MedicinalProductInteraction>(ozzzj_);

        return ozzzk_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public MedicinalProductManufactured MedicinalProductManufacturedResource(CqlContext context, MedicinalProductManufactured arg)
    {
        MedicinalProductManufactured[] ozzzt_ = [
            arg,
        ];
        MedicinalProductManufactured ozzzu_(MedicinalProductManufactured a)
        {
            CodeableConcept ozzzy_ = a?.ManufacturedDoseForm;
            CodeableConcept ozzzz_ = a?.UnitOfPresentation;
            Quantity pzzza_ = a?.Quantity;
            List<ResourceReference> pzzzb_ = a?.Manufacturer;
            List<ResourceReference> pzzzc_ = a?.Ingredient;
            ProdCharacteristic pzzzd_ = a?.PhysicalCharacteristics;
            List<CodeableConcept> pzzze_ = a?.OtherCharacteristics;
            MedicinalProductManufactured pzzzf_ = new MedicinalProductManufactured
            {
                ManufacturedDoseForm = ozzzy_,
                UnitOfPresentation = ozzzz_,
                Quantity = pzzza_,
                Manufacturer = new List<ResourceReference>((IEnumerable<ResourceReference>)pzzzb_),
                Ingredient = new List<ResourceReference>((IEnumerable<ResourceReference>)pzzzc_),
                PhysicalCharacteristics = pzzzd_,
                OtherCharacteristics = new List<CodeableConcept>((IEnumerable<CodeableConcept>)pzzze_),
            };

            return pzzzf_;
        };
        IEnumerable<MedicinalProductManufactured> ozzzv_ = context.Operators.Select<MedicinalProductManufactured, MedicinalProductManufactured>((IEnumerable<MedicinalProductManufactured>)ozzzt_, ozzzu_);
        IEnumerable<MedicinalProductManufactured> ozzzw_ = context.Operators.Distinct<MedicinalProductManufactured>(ozzzv_);
        MedicinalProductManufactured ozzzx_ = context.Operators.SingletonFrom<MedicinalProductManufactured>(ozzzw_);

        return ozzzx_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public MedicinalProductPackaged MedicinalProductPackagedResource(CqlContext context, MedicinalProductPackaged arg)
    {
        MedicinalProductPackaged[] pzzzg_ = [
            arg,
        ];
        MedicinalProductPackaged pzzzh_(MedicinalProductPackaged a)
        {
            List<Identifier> pzzzl_ = a?.Identifier;
            List<ResourceReference> pzzzm_ = a?.Subject;
            FhirString pzzzn_ = a?.DescriptionElement;
            CodeableConcept pzzzo_ = a?.LegalStatusOfSupply;
            List<MarketingStatus> pzzzp_ = a?.MarketingStatus;
            ResourceReference pzzzq_ = a?.MarketingAuthorization;
            List<ResourceReference> pzzzr_ = a?.Manufacturer;
            List<MedicinalProductPackaged.BatchIdentifierComponent> pzzzs_ = a?.BatchIdentifier;
            List<MedicinalProductPackaged.PackageItemComponent> pzzzt_ = a?.PackageItem;
            MedicinalProductPackaged pzzzu_ = new MedicinalProductPackaged
            {
                Identifier = new List<Identifier>((IEnumerable<Identifier>)pzzzl_),
                Subject = new List<ResourceReference>((IEnumerable<ResourceReference>)pzzzm_),
                DescriptionElement = pzzzn_,
                LegalStatusOfSupply = pzzzo_,
                MarketingStatus = new List<MarketingStatus>((IEnumerable<MarketingStatus>)pzzzp_),
                MarketingAuthorization = pzzzq_,
                Manufacturer = new List<ResourceReference>((IEnumerable<ResourceReference>)pzzzr_),
                BatchIdentifier = new List<MedicinalProductPackaged.BatchIdentifierComponent>((IEnumerable<MedicinalProductPackaged.BatchIdentifierComponent>)pzzzs_),
                PackageItem = new List<MedicinalProductPackaged.PackageItemComponent>((IEnumerable<MedicinalProductPackaged.PackageItemComponent>)pzzzt_),
            };

            return pzzzu_;
        };
        IEnumerable<MedicinalProductPackaged> pzzzi_ = context.Operators.Select<MedicinalProductPackaged, MedicinalProductPackaged>((IEnumerable<MedicinalProductPackaged>)pzzzg_, pzzzh_);
        IEnumerable<MedicinalProductPackaged> pzzzj_ = context.Operators.Distinct<MedicinalProductPackaged>(pzzzi_);
        MedicinalProductPackaged pzzzk_ = context.Operators.SingletonFrom<MedicinalProductPackaged>(pzzzj_);

        return pzzzk_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public MedicinalProductPharmaceutical MedicinalProductPharmaceuticalResource(CqlContext context, MedicinalProductPharmaceutical arg)
    {
        MedicinalProductPharmaceutical[] pzzzv_ = [
            arg,
        ];
        MedicinalProductPharmaceutical pzzzw_(MedicinalProductPharmaceutical a)
        {
            List<Identifier> qzzza_ = a?.Identifier;
            CodeableConcept qzzzb_ = a?.AdministrableDoseForm;
            CodeableConcept qzzzc_ = a?.UnitOfPresentation;
            List<ResourceReference> qzzzd_ = a?.Ingredient;
            List<ResourceReference> qzzze_ = a?.Device;
            List<MedicinalProductPharmaceutical.CharacteristicsComponent> qzzzf_ = a?.Characteristics;
            List<MedicinalProductPharmaceutical.RouteOfAdministrationComponent> qzzzg_ = a?.RouteOfAdministration;
            MedicinalProductPharmaceutical qzzzh_ = new MedicinalProductPharmaceutical
            {
                Identifier = new List<Identifier>((IEnumerable<Identifier>)qzzza_),
                AdministrableDoseForm = qzzzb_,
                UnitOfPresentation = qzzzc_,
                Ingredient = new List<ResourceReference>((IEnumerable<ResourceReference>)qzzzd_),
                Device = new List<ResourceReference>((IEnumerable<ResourceReference>)qzzze_),
                Characteristics = new List<MedicinalProductPharmaceutical.CharacteristicsComponent>((IEnumerable<MedicinalProductPharmaceutical.CharacteristicsComponent>)qzzzf_),
                RouteOfAdministration = new List<MedicinalProductPharmaceutical.RouteOfAdministrationComponent>((IEnumerable<MedicinalProductPharmaceutical.RouteOfAdministrationComponent>)qzzzg_),
            };

            return qzzzh_;
        };
        IEnumerable<MedicinalProductPharmaceutical> pzzzx_ = context.Operators.Select<MedicinalProductPharmaceutical, MedicinalProductPharmaceutical>((IEnumerable<MedicinalProductPharmaceutical>)pzzzv_, pzzzw_);
        IEnumerable<MedicinalProductPharmaceutical> pzzzy_ = context.Operators.Distinct<MedicinalProductPharmaceutical>(pzzzx_);
        MedicinalProductPharmaceutical pzzzz_ = context.Operators.SingletonFrom<MedicinalProductPharmaceutical>(pzzzy_);

        return pzzzz_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public MedicinalProductUndesirableEffect MedicinalProductUndesirableEffectResource(CqlContext context, MedicinalProductUndesirableEffect arg)
    {
        MedicinalProductUndesirableEffect[] qzzzi_ = [
            arg,
        ];
        MedicinalProductUndesirableEffect qzzzj_(MedicinalProductUndesirableEffect a)
        {
            List<ResourceReference> qzzzn_ = a?.Subject;
            CodeableConcept qzzzo_ = a?.SymptomConditionEffect;
            CodeableConcept qzzzp_ = a?.Classification;
            CodeableConcept qzzzq_ = a?.FrequencyOfOccurrence;
            List<Population> qzzzr_ = a?.Population;
            MedicinalProductUndesirableEffect qzzzs_ = new MedicinalProductUndesirableEffect
            {
                Subject = new List<ResourceReference>((IEnumerable<ResourceReference>)qzzzn_),
                SymptomConditionEffect = qzzzo_,
                Classification = qzzzp_,
                FrequencyOfOccurrence = qzzzq_,
                Population = new List<Population>((IEnumerable<Population>)qzzzr_),
            };

            return qzzzs_;
        };
        IEnumerable<MedicinalProductUndesirableEffect> qzzzk_ = context.Operators.Select<MedicinalProductUndesirableEffect, MedicinalProductUndesirableEffect>((IEnumerable<MedicinalProductUndesirableEffect>)qzzzi_, qzzzj_);
        IEnumerable<MedicinalProductUndesirableEffect> qzzzl_ = context.Operators.Distinct<MedicinalProductUndesirableEffect>(qzzzk_);
        MedicinalProductUndesirableEffect qzzzm_ = context.Operators.SingletonFrom<MedicinalProductUndesirableEffect>(qzzzl_);

        return qzzzm_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public MessageHeader MessageHeaderResource(CqlContext context, MessageHeader arg)
    {
        MessageHeader[] qzzzt_ = [
            arg,
        ];
        MessageHeader qzzzu_(MessageHeader a)
        {
            DataType qzzzy_ = a?.Event;
            List<MessageHeader.MessageDestinationComponent> qzzzz_ = a?.Destination;
            ResourceReference rzzza_ = a?.Sender;
            ResourceReference rzzzb_ = a?.Enterer;
            ResourceReference rzzzc_ = a?.Author;
            MessageHeader.MessageSourceComponent rzzzd_ = a?.Source;
            ResourceReference rzzze_ = a?.Responsible;
            CodeableConcept rzzzf_ = a?.Reason;
            MessageHeader.ResponseComponent rzzzg_ = a?.Response;
            List<ResourceReference> rzzzh_ = a?.Focus;
            Canonical rzzzi_ = a?.DefinitionElement;
            MessageHeader rzzzj_ = new MessageHeader
            {
                Event = (DataType)qzzzy_,
                Destination = new List<MessageHeader.MessageDestinationComponent>((IEnumerable<MessageHeader.MessageDestinationComponent>)qzzzz_),
                Sender = rzzza_,
                Enterer = rzzzb_,
                Author = rzzzc_,
                Source = rzzzd_,
                Responsible = rzzze_,
                Reason = rzzzf_,
                Response = rzzzg_,
                Focus = new List<ResourceReference>((IEnumerable<ResourceReference>)rzzzh_),
                DefinitionElement = rzzzi_,
            };

            return rzzzj_;
        };
        IEnumerable<MessageHeader> qzzzv_ = context.Operators.Select<MessageHeader, MessageHeader>((IEnumerable<MessageHeader>)qzzzt_, qzzzu_);
        IEnumerable<MessageHeader> qzzzw_ = context.Operators.Distinct<MessageHeader>(qzzzv_);
        MessageHeader qzzzx_ = context.Operators.SingletonFrom<MessageHeader>(qzzzw_);

        return qzzzx_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public MolecularSequence MolecularSequenceResource(CqlContext context, MolecularSequence arg)
    {
        MolecularSequence[] rzzzk_ = [
            arg,
        ];
        MolecularSequence rzzzl_(MolecularSequence a)
        {
            List<Identifier> rzzzp_ = a?.Identifier;
            Code<MolecularSequence.SequenceType> rzzzq_ = a?.TypeElement;
            Integer rzzzr_ = a?.CoordinateSystemElement;
            ResourceReference rzzzs_ = a?.Patient;
            ResourceReference rzzzt_ = a?.Specimen;
            ResourceReference rzzzu_ = a?.Device;
            ResourceReference rzzzv_ = a?.Performer;
            Quantity rzzzw_ = a?.Quantity;
            MolecularSequence.ReferenceSeqComponent rzzzx_ = a?.ReferenceSeq;
            List<MolecularSequence.VariantComponent> rzzzy_ = a?.Variant;
            FhirString rzzzz_ = a?.ObservedSeqElement;
            List<MolecularSequence.QualityComponent> szzza_ = a?.Quality;
            Integer szzzb_ = a?.ReadCoverageElement;
            List<MolecularSequence.RepositoryComponent> szzzc_ = a?.Repository;
            List<ResourceReference> szzzd_ = a?.Pointer;
            List<MolecularSequence.StructureVariantComponent> szzze_ = a?.StructureVariant;
            MolecularSequence szzzf_ = new MolecularSequence
            {
                Identifier = new List<Identifier>((IEnumerable<Identifier>)rzzzp_),
                TypeElement = rzzzq_,
                CoordinateSystemElement = rzzzr_,
                Patient = rzzzs_,
                Specimen = rzzzt_,
                Device = rzzzu_,
                Performer = rzzzv_,
                Quantity = rzzzw_,
                ReferenceSeq = rzzzx_,
                Variant = new List<MolecularSequence.VariantComponent>((IEnumerable<MolecularSequence.VariantComponent>)rzzzy_),
                ObservedSeqElement = rzzzz_,
                Quality = new List<MolecularSequence.QualityComponent>((IEnumerable<MolecularSequence.QualityComponent>)szzza_),
                ReadCoverageElement = szzzb_,
                Repository = new List<MolecularSequence.RepositoryComponent>((IEnumerable<MolecularSequence.RepositoryComponent>)szzzc_),
                Pointer = new List<ResourceReference>((IEnumerable<ResourceReference>)szzzd_),
                StructureVariant = new List<MolecularSequence.StructureVariantComponent>((IEnumerable<MolecularSequence.StructureVariantComponent>)szzze_),
            };

            return szzzf_;
        };
        IEnumerable<MolecularSequence> rzzzm_ = context.Operators.Select<MolecularSequence, MolecularSequence>((IEnumerable<MolecularSequence>)rzzzk_, rzzzl_);
        IEnumerable<MolecularSequence> rzzzn_ = context.Operators.Distinct<MolecularSequence>(rzzzm_);
        MolecularSequence rzzzo_ = context.Operators.SingletonFrom<MolecularSequence>(rzzzn_);

        return rzzzo_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public NamingSystem NamingSystemResource(CqlContext context, NamingSystem arg)
    {
        NamingSystem[] szzzg_ = [
            arg,
        ];
        NamingSystem szzzh_(NamingSystem a)
        {
            FhirString szzzl_ = a?.NameElement;
            Code<PublicationStatus> szzzm_ = a?.StatusElement;
            Code<NamingSystem.NamingSystemType> szzzn_ = a?.KindElement;
            FhirDateTime szzzo_ = a?.DateElement;
            FhirString szzzp_ = a?.PublisherElement;
            List<ContactDetail> szzzq_ = a?.Contact;
            FhirString szzzr_ = a?.ResponsibleElement;
            CodeableConcept szzzs_ = a?.Type;
            Markdown szzzt_ = a?.DescriptionElement;
            List<UsageContext> szzzu_ = a?.UseContext;
            List<CodeableConcept> szzzv_ = a?.Jurisdiction;
            FhirString szzzw_ = a?.UsageElement;
            List<NamingSystem.UniqueIdComponent> szzzx_ = a?.UniqueId;
            NamingSystem szzzy_ = new NamingSystem
            {
                NameElement = szzzl_,
                StatusElement = szzzm_,
                KindElement = szzzn_,
                DateElement = szzzo_,
                PublisherElement = szzzp_,
                Contact = new List<ContactDetail>((IEnumerable<ContactDetail>)szzzq_),
                ResponsibleElement = szzzr_,
                Type = szzzs_,
                DescriptionElement = szzzt_,
                UseContext = new List<UsageContext>((IEnumerable<UsageContext>)szzzu_),
                Jurisdiction = new List<CodeableConcept>((IEnumerable<CodeableConcept>)szzzv_),
                UsageElement = szzzw_,
                UniqueId = new List<NamingSystem.UniqueIdComponent>((IEnumerable<NamingSystem.UniqueIdComponent>)szzzx_),
            };

            return szzzy_;
        };
        IEnumerable<NamingSystem> szzzi_ = context.Operators.Select<NamingSystem, NamingSystem>((IEnumerable<NamingSystem>)szzzg_, szzzh_);
        IEnumerable<NamingSystem> szzzj_ = context.Operators.Distinct<NamingSystem>(szzzi_);
        NamingSystem szzzk_ = context.Operators.SingletonFrom<NamingSystem>(szzzj_);

        return szzzk_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public NutritionOrder NutritionOrderResource(CqlContext context, NutritionOrder arg)
    {
        NutritionOrder[] szzzz_ = [
            arg,
        ];
        NutritionOrder tzzza_(NutritionOrder a)
        {
            List<Identifier> tzzze_ = a?.Identifier;
            List<Canonical> tzzzf_ = a?.InstantiatesCanonicalElement;
            List<FhirUri> tzzzg_ = a?.InstantiatesUriElement;
            List<FhirUri> tzzzh_ = a?.InstantiatesElement;
            Code<RequestStatus> tzzzi_ = a?.StatusElement;
            Code<RequestIntent> tzzzj_ = a?.IntentElement;
            ResourceReference tzzzk_ = a?.Patient;
            ResourceReference tzzzl_ = a?.Encounter;
            FhirDateTime tzzzm_ = a?.DateTimeElement;
            ResourceReference tzzzn_ = a?.Orderer;
            List<ResourceReference> tzzzo_ = a?.AllergyIntolerance;
            List<CodeableConcept> tzzzp_ = a?.FoodPreferenceModifier;
            List<CodeableConcept> tzzzq_ = a?.ExcludeFoodModifier;
            NutritionOrder.OralDietComponent tzzzr_ = a?.OralDiet;
            List<NutritionOrder.SupplementComponent> tzzzs_ = a?.Supplement;
            NutritionOrder.EnteralFormulaComponent tzzzt_ = a?.EnteralFormula;
            List<Annotation> tzzzu_ = a?.Note;
            NutritionOrder tzzzv_ = new NutritionOrder
            {
                Identifier = new List<Identifier>((IEnumerable<Identifier>)tzzze_),
                InstantiatesCanonicalElement = new List<Canonical>((IEnumerable<Canonical>)tzzzf_),
                InstantiatesUriElement = new List<FhirUri>((IEnumerable<FhirUri>)tzzzg_),
                InstantiatesElement = new List<FhirUri>((IEnumerable<FhirUri>)tzzzh_),
                StatusElement = tzzzi_,
                IntentElement = tzzzj_,
                Patient = tzzzk_,
                Encounter = tzzzl_,
                DateTimeElement = tzzzm_,
                Orderer = tzzzn_,
                AllergyIntolerance = new List<ResourceReference>((IEnumerable<ResourceReference>)tzzzo_),
                FoodPreferenceModifier = new List<CodeableConcept>((IEnumerable<CodeableConcept>)tzzzp_),
                ExcludeFoodModifier = new List<CodeableConcept>((IEnumerable<CodeableConcept>)tzzzq_),
                OralDiet = tzzzr_,
                Supplement = new List<NutritionOrder.SupplementComponent>((IEnumerable<NutritionOrder.SupplementComponent>)tzzzs_),
                EnteralFormula = tzzzt_,
                Note = new List<Annotation>((IEnumerable<Annotation>)tzzzu_),
            };

            return tzzzv_;
        };
        IEnumerable<NutritionOrder> tzzzb_ = context.Operators.Select<NutritionOrder, NutritionOrder>((IEnumerable<NutritionOrder>)szzzz_, tzzza_);
        IEnumerable<NutritionOrder> tzzzc_ = context.Operators.Distinct<NutritionOrder>(tzzzb_);
        NutritionOrder tzzzd_ = context.Operators.SingletonFrom<NutritionOrder>(tzzzc_);

        return tzzzd_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public Observation ObservationResource(CqlContext context, Observation arg)
    {
        Observation[] tzzzw_ = [
            arg,
        ];
        Observation tzzzx_(Observation a)
        {
            List<Identifier> uzzzb_ = a?.Identifier;
            List<ResourceReference> uzzzc_ = a?.BasedOn;
            List<ResourceReference> uzzzd_ = a?.PartOf;
            Code<ObservationStatus> uzzze_ = a?.StatusElement;
            List<CodeableConcept> uzzzf_ = a?.Category;
            CodeableConcept uzzzg_ = a?.Code;
            ResourceReference uzzzh_ = a?.Subject;
            List<ResourceReference> uzzzi_ = a?.Focus;
            ResourceReference uzzzj_ = a?.Encounter;
            DataType uzzzk_ = a?.Effective;
            Instant uzzzl_ = a?.IssuedElement;
            List<ResourceReference> uzzzm_ = a?.Performer;
            DataType uzzzn_ = a?.Value;
            CodeableConcept uzzzo_ = a?.DataAbsentReason;
            List<CodeableConcept> uzzzp_ = a?.Interpretation;
            List<Annotation> uzzzq_ = a?.Note;
            CodeableConcept uzzzr_ = a?.BodySite;
            CodeableConcept uzzzs_ = a?.Method;
            ResourceReference uzzzt_ = a?.Specimen;
            ResourceReference uzzzu_ = a?.Device;
            List<Observation.ReferenceRangeComponent> uzzzv_ = a?.ReferenceRange;
            List<ResourceReference> uzzzw_ = a?.HasMember;
            List<ResourceReference> uzzzx_ = a?.DerivedFrom;
            List<Observation.ComponentComponent> uzzzy_ = a?.Component;
            Observation uzzzz_ = new Observation
            {
                Identifier = new List<Identifier>((IEnumerable<Identifier>)uzzzb_),
                BasedOn = new List<ResourceReference>((IEnumerable<ResourceReference>)uzzzc_),
                PartOf = new List<ResourceReference>((IEnumerable<ResourceReference>)uzzzd_),
                StatusElement = uzzze_,
                Category = new List<CodeableConcept>((IEnumerable<CodeableConcept>)uzzzf_),
                Code = uzzzg_,
                Subject = uzzzh_,
                Focus = new List<ResourceReference>((IEnumerable<ResourceReference>)uzzzi_),
                Encounter = uzzzj_,
                Effective = (DataType)uzzzk_,
                IssuedElement = uzzzl_,
                Performer = new List<ResourceReference>((IEnumerable<ResourceReference>)uzzzm_),
                Value = (DataType)uzzzn_,
                DataAbsentReason = uzzzo_,
                Interpretation = new List<CodeableConcept>((IEnumerable<CodeableConcept>)uzzzp_),
                Note = new List<Annotation>((IEnumerable<Annotation>)uzzzq_),
                BodySite = uzzzr_,
                Method = uzzzs_,
                Specimen = uzzzt_,
                Device = uzzzu_,
                ReferenceRange = new List<Observation.ReferenceRangeComponent>((IEnumerable<Observation.ReferenceRangeComponent>)uzzzv_),
                HasMember = new List<ResourceReference>((IEnumerable<ResourceReference>)uzzzw_),
                DerivedFrom = new List<ResourceReference>((IEnumerable<ResourceReference>)uzzzx_),
                Component = new List<Observation.ComponentComponent>((IEnumerable<Observation.ComponentComponent>)uzzzy_),
            };

            return uzzzz_;
        };
        IEnumerable<Observation> tzzzy_ = context.Operators.Select<Observation, Observation>((IEnumerable<Observation>)tzzzw_, tzzzx_);
        IEnumerable<Observation> tzzzz_ = context.Operators.Distinct<Observation>(tzzzy_);
        Observation uzzza_ = context.Operators.SingletonFrom<Observation>(tzzzz_);

        return uzzza_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public ObservationDefinition ObservationDefinitionResource(CqlContext context, ObservationDefinition arg)
    {
        ObservationDefinition[] vzzza_ = [
            arg,
        ];
        ObservationDefinition vzzzb_(ObservationDefinition a)
        {
            List<CodeableConcept> vzzzf_ = a?.Category;
            CodeableConcept vzzzg_ = a?.Code;
            List<Identifier> vzzzh_ = a?.Identifier;
            List<Code<ObservationDefinition.ObservationDataType>> vzzzi_ = a?.PermittedDataTypeElement;
            FhirBoolean vzzzj_ = a?.MultipleResultsAllowedElement;
            CodeableConcept vzzzk_ = a?.Method;
            FhirString vzzzl_ = a?.PreferredReportNameElement;
            ObservationDefinition.QuantitativeDetailsComponent vzzzm_ = a?.QuantitativeDetails;
            List<ObservationDefinition.QualifiedIntervalComponent> vzzzn_ = a?.QualifiedInterval;
            ResourceReference vzzzo_ = a?.ValidCodedValueSet;
            ResourceReference vzzzp_ = a?.NormalCodedValueSet;
            ResourceReference vzzzq_ = a?.AbnormalCodedValueSet;
            ResourceReference vzzzr_ = a?.CriticalCodedValueSet;
            ObservationDefinition vzzzs_ = new ObservationDefinition
            {
                Category = new List<CodeableConcept>((IEnumerable<CodeableConcept>)vzzzf_),
                Code = vzzzg_,
                Identifier = new List<Identifier>((IEnumerable<Identifier>)vzzzh_),
                PermittedDataTypeElement = new List<Code<ObservationDefinition.ObservationDataType>>((IEnumerable<Code<ObservationDefinition.ObservationDataType>>)vzzzi_),
                MultipleResultsAllowedElement = vzzzj_,
                Method = vzzzk_,
                PreferredReportNameElement = vzzzl_,
                QuantitativeDetails = vzzzm_,
                QualifiedInterval = new List<ObservationDefinition.QualifiedIntervalComponent>((IEnumerable<ObservationDefinition.QualifiedIntervalComponent>)vzzzn_),
                ValidCodedValueSet = vzzzo_,
                NormalCodedValueSet = vzzzp_,
                AbnormalCodedValueSet = vzzzq_,
                CriticalCodedValueSet = vzzzr_,
            };

            return vzzzs_;
        };
        IEnumerable<ObservationDefinition> vzzzc_ = context.Operators.Select<ObservationDefinition, ObservationDefinition>((IEnumerable<ObservationDefinition>)vzzza_, vzzzb_);
        IEnumerable<ObservationDefinition> vzzzd_ = context.Operators.Distinct<ObservationDefinition>(vzzzc_);
        ObservationDefinition vzzze_ = context.Operators.SingletonFrom<ObservationDefinition>(vzzzd_);

        return vzzze_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public OperationOutcome OperationOutcomeResource(CqlContext context, OperationOutcome arg)
    {
        OperationOutcome[] vzzzt_ = [
            arg,
        ];
        OperationOutcome vzzzu_(OperationOutcome a)
        {
            List<OperationOutcome.IssueComponent> vzzzy_ = a?.Issue;
            OperationOutcome vzzzz_ = new OperationOutcome
            {
                Issue = new List<OperationOutcome.IssueComponent>((IEnumerable<OperationOutcome.IssueComponent>)vzzzy_),
            };

            return vzzzz_;
        };
        IEnumerable<OperationOutcome> vzzzv_ = context.Operators.Select<OperationOutcome, OperationOutcome>((IEnumerable<OperationOutcome>)vzzzt_, vzzzu_);
        IEnumerable<OperationOutcome> vzzzw_ = context.Operators.Distinct<OperationOutcome>(vzzzv_);
        OperationOutcome vzzzx_ = context.Operators.SingletonFrom<OperationOutcome>(vzzzw_);

        return vzzzx_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public Organization OrganizationResource(CqlContext context, Organization arg)
    {
        Organization[] wzzza_ = [
            arg,
        ];
        Organization wzzzb_(Organization a)
        {
            List<Identifier> wzzzf_ = a?.Identifier;
            FhirBoolean wzzzg_ = a?.ActiveElement;
            List<CodeableConcept> wzzzh_ = a?.Type;
            FhirString wzzzi_ = a?.NameElement;
            List<FhirString> wzzzj_ = a?.AliasElement;
            List<ContactPoint> wzzzk_ = a?.Telecom;
            List<Address> wzzzl_ = a?.Address;
            ResourceReference wzzzm_ = a?.PartOf;
            List<Organization.ContactComponent> wzzzn_ = a?.Contact;
            List<ResourceReference> wzzzo_ = a?.Endpoint;
            Organization wzzzp_ = new Organization
            {
                Identifier = new List<Identifier>((IEnumerable<Identifier>)wzzzf_),
                ActiveElement = wzzzg_,
                Type = new List<CodeableConcept>((IEnumerable<CodeableConcept>)wzzzh_),
                NameElement = wzzzi_,
                AliasElement = new List<FhirString>((IEnumerable<FhirString>)wzzzj_),
                Telecom = new List<ContactPoint>((IEnumerable<ContactPoint>)wzzzk_),
                Address = new List<Address>((IEnumerable<Address>)wzzzl_),
                PartOf = wzzzm_,
                Contact = new List<Organization.ContactComponent>((IEnumerable<Organization.ContactComponent>)wzzzn_),
                Endpoint = new List<ResourceReference>((IEnumerable<ResourceReference>)wzzzo_),
            };

            return wzzzp_;
        };
        IEnumerable<Organization> wzzzc_ = context.Operators.Select<Organization, Organization>((IEnumerable<Organization>)wzzza_, wzzzb_);
        IEnumerable<Organization> wzzzd_ = context.Operators.Distinct<Organization>(wzzzc_);
        Organization wzzze_ = context.Operators.SingletonFrom<Organization>(wzzzd_);

        return wzzze_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public OrganizationAffiliation OrganizationAffiliationResource(CqlContext context, OrganizationAffiliation arg)
    {
        OrganizationAffiliation[] wzzzq_ = [
            arg,
        ];
        OrganizationAffiliation wzzzr_(OrganizationAffiliation a)
        {
            List<Identifier> wzzzv_ = a?.Identifier;
            FhirBoolean wzzzw_ = a?.ActiveElement;
            Period wzzzx_ = a?.Period;
            ResourceReference wzzzy_ = a?.Organization;
            ResourceReference wzzzz_ = a?.ParticipatingOrganization;
            List<ResourceReference> xzzza_ = a?.Network;
            List<CodeableConcept> xzzzb_ = a?.Code;
            List<CodeableConcept> xzzzc_ = a?.Specialty;
            List<ResourceReference> xzzzd_ = a?.Location;
            List<ResourceReference> xzzze_ = a?.HealthcareService;
            List<ContactPoint> xzzzf_ = a?.Telecom;
            List<ResourceReference> xzzzg_ = a?.Endpoint;
            OrganizationAffiliation xzzzh_ = new OrganizationAffiliation
            {
                Identifier = new List<Identifier>((IEnumerable<Identifier>)wzzzv_),
                ActiveElement = wzzzw_,
                Period = wzzzx_,
                Organization = wzzzy_,
                ParticipatingOrganization = wzzzz_,
                Network = new List<ResourceReference>((IEnumerable<ResourceReference>)xzzza_),
                Code = new List<CodeableConcept>((IEnumerable<CodeableConcept>)xzzzb_),
                Specialty = new List<CodeableConcept>((IEnumerable<CodeableConcept>)xzzzc_),
                Location = new List<ResourceReference>((IEnumerable<ResourceReference>)xzzzd_),
                HealthcareService = new List<ResourceReference>((IEnumerable<ResourceReference>)xzzze_),
                Telecom = new List<ContactPoint>((IEnumerable<ContactPoint>)xzzzf_),
                Endpoint = new List<ResourceReference>((IEnumerable<ResourceReference>)xzzzg_),
            };

            return xzzzh_;
        };
        IEnumerable<OrganizationAffiliation> wzzzs_ = context.Operators.Select<OrganizationAffiliation, OrganizationAffiliation>((IEnumerable<OrganizationAffiliation>)wzzzq_, wzzzr_);
        IEnumerable<OrganizationAffiliation> wzzzt_ = context.Operators.Distinct<OrganizationAffiliation>(wzzzs_);
        OrganizationAffiliation wzzzu_ = context.Operators.SingletonFrom<OrganizationAffiliation>(wzzzt_);

        return wzzzu_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public Patient PatientResource(CqlContext context, Patient arg)
    {
        Patient[] xzzzi_ = [
            arg,
        ];
        Patient xzzzj_(Patient a)
        {
            List<Identifier> xzzzn_ = a?.Identifier;
            FhirBoolean xzzzo_ = a?.ActiveElement;
            List<HumanName> xzzzp_ = a?.Name;
            List<ContactPoint> xzzzq_ = a?.Telecom;
            Code<AdministrativeGender> xzzzr_ = a?.GenderElement;
            Date xzzzs_ = a?.BirthDateElement;
            DataType xzzzt_ = a?.Deceased;
            List<Address> xzzzu_ = a?.Address;
            CodeableConcept xzzzv_ = a?.MaritalStatus;
            DataType xzzzw_ = a?.MultipleBirth;
            List<Attachment> xzzzx_ = a?.Photo;
            List<Patient.ContactComponent> xzzzy_ = a?.Contact;
            List<Patient.CommunicationComponent> xzzzz_ = a?.Communication;
            List<ResourceReference> yzzza_ = a?.GeneralPractitioner;
            ResourceReference yzzzb_ = a?.ManagingOrganization;
            List<Patient.LinkComponent> yzzzc_ = a?.Link;
            Patient yzzzd_ = new Patient
            {
                Identifier = new List<Identifier>((IEnumerable<Identifier>)xzzzn_),
                ActiveElement = xzzzo_,
                Name = new List<HumanName>((IEnumerable<HumanName>)xzzzp_),
                Telecom = new List<ContactPoint>((IEnumerable<ContactPoint>)xzzzq_),
                GenderElement = xzzzr_,
                BirthDateElement = xzzzs_,
                Deceased = (DataType)xzzzt_,
                Address = new List<Address>((IEnumerable<Address>)xzzzu_),
                MaritalStatus = xzzzv_,
                MultipleBirth = (DataType)xzzzw_,
                Photo = new List<Attachment>((IEnumerable<Attachment>)xzzzx_),
                Contact = new List<Patient.ContactComponent>((IEnumerable<Patient.ContactComponent>)xzzzy_),
                Communication = new List<Patient.CommunicationComponent>((IEnumerable<Patient.CommunicationComponent>)xzzzz_),
                GeneralPractitioner = new List<ResourceReference>((IEnumerable<ResourceReference>)yzzza_),
                ManagingOrganization = yzzzb_,
                Link = new List<Patient.LinkComponent>((IEnumerable<Patient.LinkComponent>)yzzzc_),
            };

            return yzzzd_;
        };
        IEnumerable<Patient> xzzzk_ = context.Operators.Select<Patient, Patient>((IEnumerable<Patient>)xzzzi_, xzzzj_);
        IEnumerable<Patient> xzzzl_ = context.Operators.Distinct<Patient>(xzzzk_);
        Patient xzzzm_ = context.Operators.SingletonFrom<Patient>(xzzzl_);

        return xzzzm_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public PaymentNotice PaymentNoticeResource(CqlContext context, PaymentNotice arg)
    {
        PaymentNotice[] yzzze_ = [
            arg,
        ];
        PaymentNotice yzzzf_(PaymentNotice a)
        {
            List<Identifier> yzzzj_ = a?.Identifier;
            Code<FinancialResourceStatusCodes> yzzzk_ = a?.StatusElement;
            ResourceReference yzzzl_ = a?.Request;
            ResourceReference yzzzm_ = a?.Response;
            FhirDateTime yzzzn_ = a?.CreatedElement;
            ResourceReference yzzzo_ = a?.Provider;
            ResourceReference yzzzp_ = a?.Payment;
            Date yzzzq_ = a?.PaymentDateElement;
            ResourceReference yzzzr_ = a?.Payee;
            ResourceReference yzzzs_ = a?.Recipient;
            Money yzzzt_ = a?.Amount;
            CodeableConcept yzzzu_ = a?.PaymentStatus;
            PaymentNotice yzzzv_ = new PaymentNotice
            {
                Identifier = new List<Identifier>((IEnumerable<Identifier>)yzzzj_),
                StatusElement = yzzzk_,
                Request = yzzzl_,
                Response = yzzzm_,
                CreatedElement = yzzzn_,
                Provider = yzzzo_,
                Payment = yzzzp_,
                PaymentDateElement = yzzzq_,
                Payee = yzzzr_,
                Recipient = yzzzs_,
                Amount = yzzzt_,
                PaymentStatus = yzzzu_,
            };

            return yzzzv_;
        };
        IEnumerable<PaymentNotice> yzzzg_ = context.Operators.Select<PaymentNotice, PaymentNotice>((IEnumerable<PaymentNotice>)yzzze_, yzzzf_);
        IEnumerable<PaymentNotice> yzzzh_ = context.Operators.Distinct<PaymentNotice>(yzzzg_);
        PaymentNotice yzzzi_ = context.Operators.SingletonFrom<PaymentNotice>(yzzzh_);

        return yzzzi_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public PaymentReconciliation PaymentReconciliationResource(CqlContext context, PaymentReconciliation arg)
    {
        PaymentReconciliation[] yzzzw_ = [
            arg,
        ];
        PaymentReconciliation yzzzx_(PaymentReconciliation a)
        {
            List<Identifier> zzzzb_ = a?.Identifier;
            Code<FinancialResourceStatusCodes> zzzzc_ = a?.StatusElement;
            Period zzzzd_ = a?.Period;
            FhirDateTime zzzze_ = a?.CreatedElement;
            ResourceReference zzzzf_ = a?.PaymentIssuer;
            ResourceReference zzzzg_ = a?.Request;
            ResourceReference zzzzh_ = a?.Requestor;
            Code<ClaimProcessingCodes> zzzzi_ = a?.OutcomeElement;
            FhirString zzzzj_ = a?.DispositionElement;
            Date zzzzk_ = a?.PaymentDateElement;
            Money zzzzl_ = a?.PaymentAmount;
            Identifier zzzzm_ = a?.PaymentIdentifier;
            List<PaymentReconciliation.DetailsComponent> zzzzn_ = a?.Detail;
            CodeableConcept zzzzo_ = a?.FormCode;
            List<PaymentReconciliation.NotesComponent> zzzzp_ = a?.ProcessNote;
            PaymentReconciliation zzzzq_ = new PaymentReconciliation
            {
                Identifier = new List<Identifier>((IEnumerable<Identifier>)zzzzb_),
                StatusElement = zzzzc_,
                Period = zzzzd_,
                CreatedElement = zzzze_,
                PaymentIssuer = zzzzf_,
                Request = zzzzg_,
                Requestor = zzzzh_,
                OutcomeElement = zzzzi_,
                DispositionElement = zzzzj_,
                PaymentDateElement = zzzzk_,
                PaymentAmount = zzzzl_,
                PaymentIdentifier = zzzzm_,
                Detail = new List<PaymentReconciliation.DetailsComponent>((IEnumerable<PaymentReconciliation.DetailsComponent>)zzzzn_),
                FormCode = zzzzo_,
                ProcessNote = new List<PaymentReconciliation.NotesComponent>((IEnumerable<PaymentReconciliation.NotesComponent>)zzzzp_),
            };

            return zzzzq_;
        };
        IEnumerable<PaymentReconciliation> yzzzy_ = context.Operators.Select<PaymentReconciliation, PaymentReconciliation>((IEnumerable<PaymentReconciliation>)yzzzw_, yzzzx_);
        IEnumerable<PaymentReconciliation> yzzzz_ = context.Operators.Distinct<PaymentReconciliation>(yzzzy_);
        PaymentReconciliation zzzza_ = context.Operators.SingletonFrom<PaymentReconciliation>(yzzzz_);

        return zzzza_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public Person PersonResource(CqlContext context, Person arg)
    {
        Person[] zzzzr_ = [
            arg,
        ];
        Person zzzzs_(Person a)
        {
            List<Identifier> zzzzw_ = a?.Identifier;
            List<HumanName> zzzzx_ = a?.Name;
            List<ContactPoint> zzzzy_ = a?.Telecom;
            Code<AdministrativeGender> zzzzz_ = a?.GenderElement;
            Date azzzza_ = a?.BirthDateElement;
            List<Address> azzzzb_ = a?.Address;
            Attachment azzzzc_ = a?.Photo;
            ResourceReference azzzzd_ = a?.ManagingOrganization;
            FhirBoolean azzzze_ = a?.ActiveElement;
            List<Person.LinkComponent> azzzzf_ = a?.Link;
            Person azzzzg_ = new Person
            {
                Identifier = new List<Identifier>((IEnumerable<Identifier>)zzzzw_),
                Name = new List<HumanName>((IEnumerable<HumanName>)zzzzx_),
                Telecom = new List<ContactPoint>((IEnumerable<ContactPoint>)zzzzy_),
                GenderElement = zzzzz_,
                BirthDateElement = azzzza_,
                Address = new List<Address>((IEnumerable<Address>)azzzzb_),
                Photo = azzzzc_,
                ManagingOrganization = azzzzd_,
                ActiveElement = azzzze_,
                Link = new List<Person.LinkComponent>((IEnumerable<Person.LinkComponent>)azzzzf_),
            };

            return azzzzg_;
        };
        IEnumerable<Person> zzzzt_ = context.Operators.Select<Person, Person>((IEnumerable<Person>)zzzzr_, zzzzs_);
        IEnumerable<Person> zzzzu_ = context.Operators.Distinct<Person>(zzzzt_);
        Person zzzzv_ = context.Operators.SingletonFrom<Person>(zzzzu_);

        return zzzzv_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public PlanDefinition PlanDefinitionResource(CqlContext context, PlanDefinition arg)
    {
        PlanDefinition[] azzzzh_ = [
            arg,
        ];
        PlanDefinition azzzzi_(PlanDefinition a)
        {
            FhirUri azzzzm_ = a?.UrlElement;
            List<Identifier> azzzzn_ = a?.Identifier;
            FhirString azzzzo_ = a?.VersionElement;
            FhirString azzzzp_ = a?.NameElement;
            FhirString azzzzq_ = a?.TitleElement;
            FhirString azzzzr_ = a?.SubtitleElement;
            CodeableConcept azzzzs_ = a?.Type;
            Code<PublicationStatus> azzzzt_ = a?.StatusElement;
            FhirBoolean azzzzu_ = a?.ExperimentalElement;
            DataType azzzzv_ = a?.Subject;
            FhirDateTime azzzzw_ = a?.DateElement;
            FhirString azzzzx_ = a?.PublisherElement;
            List<ContactDetail> azzzzy_ = a?.Contact;
            Markdown azzzzz_ = a?.DescriptionElement;
            List<UsageContext> bzzzza_ = a?.UseContext;
            List<CodeableConcept> bzzzzb_ = a?.Jurisdiction;
            Markdown bzzzzc_ = a?.PurposeElement;
            FhirString bzzzzd_ = a?.UsageElement;
            Markdown bzzzze_ = a?.CopyrightElement;
            Date bzzzzf_ = a?.ApprovalDateElement;
            Date bzzzzg_ = a?.LastReviewDateElement;
            Period bzzzzh_ = a?.EffectivePeriod;
            List<CodeableConcept> bzzzzi_ = a?.Topic;
            List<ContactDetail> bzzzzj_ = a?.Author;
            List<ContactDetail> bzzzzk_ = a?.Editor;
            List<ContactDetail> bzzzzl_ = a?.Reviewer;
            List<ContactDetail> bzzzzm_ = a?.Endorser;
            List<RelatedArtifact> bzzzzn_ = a?.RelatedArtifact;
            List<Canonical> bzzzzo_ = a?.LibraryElement;
            List<PlanDefinition.GoalComponent> bzzzzp_ = a?.Goal;
            List<PlanDefinition.ActionComponent> bzzzzq_ = a?.Action;
            PlanDefinition bzzzzr_ = new PlanDefinition
            {
                UrlElement = azzzzm_,
                Identifier = new List<Identifier>((IEnumerable<Identifier>)azzzzn_),
                VersionElement = azzzzo_,
                NameElement = azzzzp_,
                TitleElement = azzzzq_,
                SubtitleElement = azzzzr_,
                Type = azzzzs_,
                StatusElement = azzzzt_,
                ExperimentalElement = azzzzu_,
                Subject = (DataType)azzzzv_,
                DateElement = azzzzw_,
                PublisherElement = azzzzx_,
                Contact = new List<ContactDetail>((IEnumerable<ContactDetail>)azzzzy_),
                DescriptionElement = azzzzz_,
                UseContext = new List<UsageContext>((IEnumerable<UsageContext>)bzzzza_),
                Jurisdiction = new List<CodeableConcept>((IEnumerable<CodeableConcept>)bzzzzb_),
                PurposeElement = bzzzzc_,
                UsageElement = bzzzzd_,
                CopyrightElement = bzzzze_,
                ApprovalDateElement = bzzzzf_,
                LastReviewDateElement = bzzzzg_,
                EffectivePeriod = bzzzzh_,
                Topic = new List<CodeableConcept>((IEnumerable<CodeableConcept>)bzzzzi_),
                Author = new List<ContactDetail>((IEnumerable<ContactDetail>)bzzzzj_),
                Editor = new List<ContactDetail>((IEnumerable<ContactDetail>)bzzzzk_),
                Reviewer = new List<ContactDetail>((IEnumerable<ContactDetail>)bzzzzl_),
                Endorser = new List<ContactDetail>((IEnumerable<ContactDetail>)bzzzzm_),
                RelatedArtifact = new List<RelatedArtifact>((IEnumerable<RelatedArtifact>)bzzzzn_),
                LibraryElement = new List<Canonical>((IEnumerable<Canonical>)bzzzzo_),
                Goal = new List<PlanDefinition.GoalComponent>((IEnumerable<PlanDefinition.GoalComponent>)bzzzzp_),
                Action = new List<PlanDefinition.ActionComponent>((IEnumerable<PlanDefinition.ActionComponent>)bzzzzq_),
            };

            return bzzzzr_;
        };
        IEnumerable<PlanDefinition> azzzzj_ = context.Operators.Select<PlanDefinition, PlanDefinition>((IEnumerable<PlanDefinition>)azzzzh_, azzzzi_);
        IEnumerable<PlanDefinition> azzzzk_ = context.Operators.Distinct<PlanDefinition>(azzzzj_);
        PlanDefinition azzzzl_ = context.Operators.SingletonFrom<PlanDefinition>(azzzzk_);

        return azzzzl_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public Practitioner PractitionerResource(CqlContext context, Practitioner arg)
    {
        Practitioner[] bzzzzs_ = [
            arg,
        ];
        Practitioner bzzzzt_(Practitioner a)
        {
            List<Identifier> bzzzzx_ = a?.Identifier;
            FhirBoolean bzzzzy_ = a?.ActiveElement;
            List<HumanName> bzzzzz_ = a?.Name;
            List<ContactPoint> czzzza_ = a?.Telecom;
            List<Address> czzzzb_ = a?.Address;
            Code<AdministrativeGender> czzzzc_ = a?.GenderElement;
            Date czzzzd_ = a?.BirthDateElement;
            List<Attachment> czzzze_ = a?.Photo;
            List<Practitioner.QualificationComponent> czzzzf_ = a?.Qualification;
            List<CodeableConcept> czzzzg_ = a?.Communication;
            Practitioner czzzzh_ = new Practitioner
            {
                Identifier = new List<Identifier>((IEnumerable<Identifier>)bzzzzx_),
                ActiveElement = bzzzzy_,
                Name = new List<HumanName>((IEnumerable<HumanName>)bzzzzz_),
                Telecom = new List<ContactPoint>((IEnumerable<ContactPoint>)czzzza_),
                Address = new List<Address>((IEnumerable<Address>)czzzzb_),
                GenderElement = czzzzc_,
                BirthDateElement = czzzzd_,
                Photo = new List<Attachment>((IEnumerable<Attachment>)czzzze_),
                Qualification = new List<Practitioner.QualificationComponent>((IEnumerable<Practitioner.QualificationComponent>)czzzzf_),
                Communication = new List<CodeableConcept>((IEnumerable<CodeableConcept>)czzzzg_),
            };

            return czzzzh_;
        };
        IEnumerable<Practitioner> bzzzzu_ = context.Operators.Select<Practitioner, Practitioner>((IEnumerable<Practitioner>)bzzzzs_, bzzzzt_);
        IEnumerable<Practitioner> bzzzzv_ = context.Operators.Distinct<Practitioner>(bzzzzu_);
        Practitioner bzzzzw_ = context.Operators.SingletonFrom<Practitioner>(bzzzzv_);

        return bzzzzw_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public PractitionerRole PractitionerRoleResource(CqlContext context, PractitionerRole arg)
    {
        PractitionerRole[] czzzzi_ = [
            arg,
        ];
        PractitionerRole czzzzj_(PractitionerRole a)
        {
            List<Identifier> czzzzn_ = a?.Identifier;
            FhirBoolean czzzzo_ = a?.ActiveElement;
            Period czzzzp_ = a?.Period;
            ResourceReference czzzzq_ = a?.Practitioner;
            ResourceReference czzzzr_ = a?.Organization;
            List<CodeableConcept> czzzzs_ = a?.Code;
            List<CodeableConcept> czzzzt_ = a?.Specialty;
            List<ResourceReference> czzzzu_ = a?.Location;
            List<ResourceReference> czzzzv_ = a?.HealthcareService;
            List<ContactPoint> czzzzw_ = a?.Telecom;
            List<PractitionerRole.AvailableTimeComponent> czzzzx_ = a?.AvailableTime;
            List<PractitionerRole.NotAvailableComponent> czzzzy_ = a?.NotAvailable;
            FhirString czzzzz_ = a?.AvailabilityExceptionsElement;
            List<ResourceReference> dzzzza_ = a?.Endpoint;
            PractitionerRole dzzzzb_ = new PractitionerRole
            {
                Identifier = new List<Identifier>((IEnumerable<Identifier>)czzzzn_),
                ActiveElement = czzzzo_,
                Period = czzzzp_,
                Practitioner = czzzzq_,
                Organization = czzzzr_,
                Code = new List<CodeableConcept>((IEnumerable<CodeableConcept>)czzzzs_),
                Specialty = new List<CodeableConcept>((IEnumerable<CodeableConcept>)czzzzt_),
                Location = new List<ResourceReference>((IEnumerable<ResourceReference>)czzzzu_),
                HealthcareService = new List<ResourceReference>((IEnumerable<ResourceReference>)czzzzv_),
                Telecom = new List<ContactPoint>((IEnumerable<ContactPoint>)czzzzw_),
                AvailableTime = new List<PractitionerRole.AvailableTimeComponent>((IEnumerable<PractitionerRole.AvailableTimeComponent>)czzzzx_),
                NotAvailable = new List<PractitionerRole.NotAvailableComponent>((IEnumerable<PractitionerRole.NotAvailableComponent>)czzzzy_),
                AvailabilityExceptionsElement = czzzzz_,
                Endpoint = new List<ResourceReference>((IEnumerable<ResourceReference>)dzzzza_),
            };

            return dzzzzb_;
        };
        IEnumerable<PractitionerRole> czzzzk_ = context.Operators.Select<PractitionerRole, PractitionerRole>((IEnumerable<PractitionerRole>)czzzzi_, czzzzj_);
        IEnumerable<PractitionerRole> czzzzl_ = context.Operators.Distinct<PractitionerRole>(czzzzk_);
        PractitionerRole czzzzm_ = context.Operators.SingletonFrom<PractitionerRole>(czzzzl_);

        return czzzzm_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public Procedure ProcedureResource(CqlContext context, Procedure arg)
    {
        Procedure[] dzzzzc_ = [
            arg,
        ];
        Procedure dzzzzd_(Procedure a)
        {
            List<Identifier> dzzzzh_ = a?.Identifier;
            List<Canonical> dzzzzi_ = a?.InstantiatesCanonicalElement;
            List<FhirUri> dzzzzj_ = a?.InstantiatesUriElement;
            List<ResourceReference> dzzzzk_ = a?.BasedOn;
            List<ResourceReference> dzzzzl_ = a?.PartOf;
            Code<EventStatus> dzzzzm_ = a?.StatusElement;
            CodeableConcept dzzzzn_ = a?.StatusReason;
            CodeableConcept dzzzzo_ = a?.Category;
            CodeableConcept dzzzzp_ = a?.Code;
            ResourceReference dzzzzq_ = a?.Subject;
            ResourceReference dzzzzr_ = a?.Encounter;
            DataType dzzzzs_ = a?.Performed;
            ResourceReference dzzzzt_ = a?.Recorder;
            ResourceReference dzzzzu_ = a?.Asserter;
            List<Procedure.PerformerComponent> dzzzzv_ = a?.Performer;
            ResourceReference dzzzzw_ = a?.Location;
            List<CodeableConcept> dzzzzx_ = a?.ReasonCode;
            List<ResourceReference> dzzzzy_ = a?.ReasonReference;
            List<CodeableConcept> dzzzzz_ = a?.BodySite;
            CodeableConcept ezzzza_ = a?.Outcome;
            List<ResourceReference> ezzzzb_ = a?.Report;
            List<CodeableConcept> ezzzzc_ = a?.Complication;
            List<ResourceReference> ezzzzd_ = a?.ComplicationDetail;
            List<CodeableConcept> ezzzze_ = a?.FollowUp;
            List<Annotation> ezzzzf_ = a?.Note;
            List<Procedure.FocalDeviceComponent> ezzzzg_ = a?.FocalDevice;
            List<ResourceReference> ezzzzh_ = a?.UsedReference;
            List<CodeableConcept> ezzzzi_ = a?.UsedCode;
            Procedure ezzzzj_ = new Procedure
            {
                Identifier = new List<Identifier>((IEnumerable<Identifier>)dzzzzh_),
                InstantiatesCanonicalElement = new List<Canonical>((IEnumerable<Canonical>)dzzzzi_),
                InstantiatesUriElement = new List<FhirUri>((IEnumerable<FhirUri>)dzzzzj_),
                BasedOn = new List<ResourceReference>((IEnumerable<ResourceReference>)dzzzzk_),
                PartOf = new List<ResourceReference>((IEnumerable<ResourceReference>)dzzzzl_),
                StatusElement = dzzzzm_,
                StatusReason = dzzzzn_,
                Category = dzzzzo_,
                Code = dzzzzp_,
                Subject = dzzzzq_,
                Encounter = dzzzzr_,
                Performed = (DataType)dzzzzs_,
                Recorder = dzzzzt_,
                Asserter = dzzzzu_,
                Performer = new List<Procedure.PerformerComponent>((IEnumerable<Procedure.PerformerComponent>)dzzzzv_),
                Location = dzzzzw_,
                ReasonCode = new List<CodeableConcept>((IEnumerable<CodeableConcept>)dzzzzx_),
                ReasonReference = new List<ResourceReference>((IEnumerable<ResourceReference>)dzzzzy_),
                BodySite = new List<CodeableConcept>((IEnumerable<CodeableConcept>)dzzzzz_),
                Outcome = ezzzza_,
                Report = new List<ResourceReference>((IEnumerable<ResourceReference>)ezzzzb_),
                Complication = new List<CodeableConcept>((IEnumerable<CodeableConcept>)ezzzzc_),
                ComplicationDetail = new List<ResourceReference>((IEnumerable<ResourceReference>)ezzzzd_),
                FollowUp = new List<CodeableConcept>((IEnumerable<CodeableConcept>)ezzzze_),
                Note = new List<Annotation>((IEnumerable<Annotation>)ezzzzf_),
                FocalDevice = new List<Procedure.FocalDeviceComponent>((IEnumerable<Procedure.FocalDeviceComponent>)ezzzzg_),
                UsedReference = new List<ResourceReference>((IEnumerable<ResourceReference>)ezzzzh_),
                UsedCode = new List<CodeableConcept>((IEnumerable<CodeableConcept>)ezzzzi_),
            };

            return ezzzzj_;
        };
        IEnumerable<Procedure> dzzzze_ = context.Operators.Select<Procedure, Procedure>((IEnumerable<Procedure>)dzzzzc_, dzzzzd_);
        IEnumerable<Procedure> dzzzzf_ = context.Operators.Distinct<Procedure>(dzzzze_);
        Procedure dzzzzg_ = context.Operators.SingletonFrom<Procedure>(dzzzzf_);

        return dzzzzg_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public Provenance ProvenanceResource(CqlContext context, Provenance arg)
    {
        Provenance[] ezzzzk_ = [
            arg,
        ];
        Provenance ezzzzl_(Provenance a)
        {
            List<ResourceReference> ezzzzp_ = a?.Target;
            DataType ezzzzq_ = a?.Occurred;
            Instant ezzzzr_ = a?.RecordedElement;
            List<FhirUri> ezzzzs_ = a?.PolicyElement;
            ResourceReference ezzzzt_ = a?.Location;
            List<CodeableConcept> ezzzzu_ = a?.Reason;
            CodeableConcept ezzzzv_ = a?.Activity;
            List<Provenance.AgentComponent> ezzzzw_ = a?.Agent;
            List<Provenance.EntityComponent> ezzzzx_ = a?.Entity;
            List<Signature> ezzzzy_ = a?.Signature;
            Provenance ezzzzz_ = new Provenance
            {
                Target = new List<ResourceReference>((IEnumerable<ResourceReference>)ezzzzp_),
                Occurred = (DataType)ezzzzq_,
                RecordedElement = ezzzzr_,
                PolicyElement = new List<FhirUri>((IEnumerable<FhirUri>)ezzzzs_),
                Location = ezzzzt_,
                Reason = new List<CodeableConcept>((IEnumerable<CodeableConcept>)ezzzzu_),
                Activity = ezzzzv_,
                Agent = new List<Provenance.AgentComponent>((IEnumerable<Provenance.AgentComponent>)ezzzzw_),
                Entity = new List<Provenance.EntityComponent>((IEnumerable<Provenance.EntityComponent>)ezzzzx_),
                Signature = new List<Signature>((IEnumerable<Signature>)ezzzzy_),
            };

            return ezzzzz_;
        };
        IEnumerable<Provenance> ezzzzm_ = context.Operators.Select<Provenance, Provenance>((IEnumerable<Provenance>)ezzzzk_, ezzzzl_);
        IEnumerable<Provenance> ezzzzn_ = context.Operators.Distinct<Provenance>(ezzzzm_);
        Provenance ezzzzo_ = context.Operators.SingletonFrom<Provenance>(ezzzzn_);

        return ezzzzo_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public QuestionnaireResponse QuestionnaireResponseResource(CqlContext context, QuestionnaireResponse arg)
    {
        QuestionnaireResponse[] fzzzza_ = [
            arg,
        ];
        QuestionnaireResponse fzzzzb_(QuestionnaireResponse a)
        {
            Identifier fzzzzf_ = a?.Identifier;
            List<ResourceReference> fzzzzg_ = a?.BasedOn;
            List<ResourceReference> fzzzzh_ = a?.PartOf;
            Canonical fzzzzi_ = a?.QuestionnaireElement;
            Code<QuestionnaireResponse.QuestionnaireResponseStatus> fzzzzj_ = a?.StatusElement;
            ResourceReference fzzzzk_ = a?.Subject;
            ResourceReference fzzzzl_ = a?.Encounter;
            FhirDateTime fzzzzm_ = a?.AuthoredElement;
            ResourceReference fzzzzn_ = a?.Author;
            ResourceReference fzzzzo_ = a?.Source;
            List<QuestionnaireResponse.ItemComponent> fzzzzp_ = a?.Item;
            QuestionnaireResponse fzzzzq_ = new QuestionnaireResponse
            {
                Identifier = fzzzzf_,
                BasedOn = new List<ResourceReference>((IEnumerable<ResourceReference>)fzzzzg_),
                PartOf = new List<ResourceReference>((IEnumerable<ResourceReference>)fzzzzh_),
                QuestionnaireElement = fzzzzi_,
                StatusElement = fzzzzj_,
                Subject = fzzzzk_,
                Encounter = fzzzzl_,
                AuthoredElement = fzzzzm_,
                Author = fzzzzn_,
                Source = fzzzzo_,
                Item = new List<QuestionnaireResponse.ItemComponent>((IEnumerable<QuestionnaireResponse.ItemComponent>)fzzzzp_),
            };

            return fzzzzq_;
        };
        IEnumerable<QuestionnaireResponse> fzzzzc_ = context.Operators.Select<QuestionnaireResponse, QuestionnaireResponse>((IEnumerable<QuestionnaireResponse>)fzzzza_, fzzzzb_);
        IEnumerable<QuestionnaireResponse> fzzzzd_ = context.Operators.Distinct<QuestionnaireResponse>(fzzzzc_);
        QuestionnaireResponse fzzzze_ = context.Operators.SingletonFrom<QuestionnaireResponse>(fzzzzd_);

        return fzzzze_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public RelatedPerson RelatedPersonResource(CqlContext context, RelatedPerson arg)
    {
        RelatedPerson[] fzzzzr_ = [
            arg,
        ];
        RelatedPerson fzzzzs_(RelatedPerson a)
        {
            List<Identifier> fzzzzw_ = a?.Identifier;
            FhirBoolean fzzzzx_ = a?.ActiveElement;
            ResourceReference fzzzzy_ = a?.Patient;
            List<CodeableConcept> fzzzzz_ = a?.Relationship;
            List<HumanName> gzzzza_ = a?.Name;
            List<ContactPoint> gzzzzb_ = a?.Telecom;
            Code<AdministrativeGender> gzzzzc_ = a?.GenderElement;
            Date gzzzzd_ = a?.BirthDateElement;
            List<Address> gzzzze_ = a?.Address;
            List<Attachment> gzzzzf_ = a?.Photo;
            Period gzzzzg_ = a?.Period;
            List<RelatedPerson.CommunicationComponent> gzzzzh_ = a?.Communication;
            RelatedPerson gzzzzi_ = new RelatedPerson
            {
                Identifier = new List<Identifier>((IEnumerable<Identifier>)fzzzzw_),
                ActiveElement = fzzzzx_,
                Patient = fzzzzy_,
                Relationship = new List<CodeableConcept>((IEnumerable<CodeableConcept>)fzzzzz_),
                Name = new List<HumanName>((IEnumerable<HumanName>)gzzzza_),
                Telecom = new List<ContactPoint>((IEnumerable<ContactPoint>)gzzzzb_),
                GenderElement = gzzzzc_,
                BirthDateElement = gzzzzd_,
                Address = new List<Address>((IEnumerable<Address>)gzzzze_),
                Photo = new List<Attachment>((IEnumerable<Attachment>)gzzzzf_),
                Period = gzzzzg_,
                Communication = new List<RelatedPerson.CommunicationComponent>((IEnumerable<RelatedPerson.CommunicationComponent>)gzzzzh_),
            };

            return gzzzzi_;
        };
        IEnumerable<RelatedPerson> fzzzzt_ = context.Operators.Select<RelatedPerson, RelatedPerson>((IEnumerable<RelatedPerson>)fzzzzr_, fzzzzs_);
        IEnumerable<RelatedPerson> fzzzzu_ = context.Operators.Distinct<RelatedPerson>(fzzzzt_);
        RelatedPerson fzzzzv_ = context.Operators.SingletonFrom<RelatedPerson>(fzzzzu_);

        return fzzzzv_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public RequestGroup RequestGroupResource(CqlContext context, RequestGroup arg)
    {
        RequestGroup[] gzzzzj_ = [
            arg,
        ];
        RequestGroup gzzzzk_(RequestGroup a)
        {
            List<Identifier> gzzzzo_ = a?.Identifier;
            List<Canonical> gzzzzp_ = a?.InstantiatesCanonicalElement;
            List<FhirUri> gzzzzq_ = a?.InstantiatesUriElement;
            List<ResourceReference> gzzzzr_ = a?.BasedOn;
            List<ResourceReference> gzzzzs_ = a?.Replaces;
            Identifier gzzzzt_ = a?.GroupIdentifier;
            Code<RequestStatus> gzzzzu_ = a?.StatusElement;
            Code<RequestIntent> gzzzzv_ = a?.IntentElement;
            Code<RequestPriority> gzzzzw_ = a?.PriorityElement;
            CodeableConcept gzzzzx_ = a?.Code;
            ResourceReference gzzzzy_ = a?.Subject;
            ResourceReference gzzzzz_ = a?.Encounter;
            FhirDateTime hzzzza_ = a?.AuthoredOnElement;
            ResourceReference hzzzzb_ = a?.Author;
            List<CodeableConcept> hzzzzc_ = a?.ReasonCode;
            List<ResourceReference> hzzzzd_ = a?.ReasonReference;
            List<Annotation> hzzzze_ = a?.Note;
            List<RequestGroup.ActionComponent> hzzzzf_ = a?.Action;
            RequestGroup hzzzzg_ = new RequestGroup
            {
                Identifier = new List<Identifier>((IEnumerable<Identifier>)gzzzzo_),
                InstantiatesCanonicalElement = new List<Canonical>((IEnumerable<Canonical>)gzzzzp_),
                InstantiatesUriElement = new List<FhirUri>((IEnumerable<FhirUri>)gzzzzq_),
                BasedOn = new List<ResourceReference>((IEnumerable<ResourceReference>)gzzzzr_),
                Replaces = new List<ResourceReference>((IEnumerable<ResourceReference>)gzzzzs_),
                GroupIdentifier = gzzzzt_,
                StatusElement = gzzzzu_,
                IntentElement = gzzzzv_,
                PriorityElement = gzzzzw_,
                Code = gzzzzx_,
                Subject = gzzzzy_,
                Encounter = gzzzzz_,
                AuthoredOnElement = hzzzza_,
                Author = hzzzzb_,
                ReasonCode = new List<CodeableConcept>((IEnumerable<CodeableConcept>)hzzzzc_),
                ReasonReference = new List<ResourceReference>((IEnumerable<ResourceReference>)hzzzzd_),
                Note = new List<Annotation>((IEnumerable<Annotation>)hzzzze_),
                Action = new List<RequestGroup.ActionComponent>((IEnumerable<RequestGroup.ActionComponent>)hzzzzf_),
            };

            return hzzzzg_;
        };
        IEnumerable<RequestGroup> gzzzzl_ = context.Operators.Select<RequestGroup, RequestGroup>((IEnumerable<RequestGroup>)gzzzzj_, gzzzzk_);
        IEnumerable<RequestGroup> gzzzzm_ = context.Operators.Distinct<RequestGroup>(gzzzzl_);
        RequestGroup gzzzzn_ = context.Operators.SingletonFrom<RequestGroup>(gzzzzm_);

        return gzzzzn_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public ResearchDefinition ResearchDefinitionResource(CqlContext context, ResearchDefinition arg)
    {
        ResearchDefinition[] hzzzzh_ = [
            arg,
        ];
        ResearchDefinition hzzzzi_(ResearchDefinition a)
        {
            FhirUri hzzzzm_ = a?.UrlElement;
            List<Identifier> hzzzzn_ = a?.Identifier;
            FhirString hzzzzo_ = a?.VersionElement;
            FhirString hzzzzp_ = a?.NameElement;
            FhirString hzzzzq_ = a?.TitleElement;
            FhirString hzzzzr_ = a?.ShortTitleElement;
            FhirString hzzzzs_ = a?.SubtitleElement;
            Code<PublicationStatus> hzzzzt_ = a?.StatusElement;
            FhirBoolean hzzzzu_ = a?.ExperimentalElement;
            DataType hzzzzv_ = a?.Subject;
            FhirDateTime hzzzzw_ = a?.DateElement;
            FhirString hzzzzx_ = a?.PublisherElement;
            List<ContactDetail> hzzzzy_ = a?.Contact;
            Markdown hzzzzz_ = a?.DescriptionElement;
            List<FhirString> izzzza_ = a?.CommentElement;
            List<UsageContext> izzzzb_ = a?.UseContext;
            List<CodeableConcept> izzzzc_ = a?.Jurisdiction;
            Markdown izzzzd_ = a?.PurposeElement;
            FhirString izzzze_ = a?.UsageElement;
            Markdown izzzzf_ = a?.CopyrightElement;
            Date izzzzg_ = a?.ApprovalDateElement;
            Date izzzzh_ = a?.LastReviewDateElement;
            Period izzzzi_ = a?.EffectivePeriod;
            List<CodeableConcept> izzzzj_ = a?.Topic;
            List<ContactDetail> izzzzk_ = a?.Author;
            List<ContactDetail> izzzzl_ = a?.Editor;
            List<ContactDetail> izzzzm_ = a?.Reviewer;
            List<ContactDetail> izzzzn_ = a?.Endorser;
            List<RelatedArtifact> izzzzo_ = a?.RelatedArtifact;
            List<Canonical> izzzzp_ = a?.LibraryElement;
            ResourceReference izzzzq_ = a?.Population;
            ResourceReference izzzzr_ = a?.Exposure;
            ResourceReference izzzzs_ = a?.ExposureAlternative;
            ResourceReference izzzzt_ = a?.Outcome;
            ResearchDefinition izzzzu_ = new ResearchDefinition
            {
                UrlElement = hzzzzm_,
                Identifier = new List<Identifier>((IEnumerable<Identifier>)hzzzzn_),
                VersionElement = hzzzzo_,
                NameElement = hzzzzp_,
                TitleElement = hzzzzq_,
                ShortTitleElement = hzzzzr_,
                SubtitleElement = hzzzzs_,
                StatusElement = hzzzzt_,
                ExperimentalElement = hzzzzu_,
                Subject = (DataType)hzzzzv_,
                DateElement = hzzzzw_,
                PublisherElement = hzzzzx_,
                Contact = new List<ContactDetail>((IEnumerable<ContactDetail>)hzzzzy_),
                DescriptionElement = hzzzzz_,
                CommentElement = new List<FhirString>((IEnumerable<FhirString>)izzzza_),
                UseContext = new List<UsageContext>((IEnumerable<UsageContext>)izzzzb_),
                Jurisdiction = new List<CodeableConcept>((IEnumerable<CodeableConcept>)izzzzc_),
                PurposeElement = izzzzd_,
                UsageElement = izzzze_,
                CopyrightElement = izzzzf_,
                ApprovalDateElement = izzzzg_,
                LastReviewDateElement = izzzzh_,
                EffectivePeriod = izzzzi_,
                Topic = new List<CodeableConcept>((IEnumerable<CodeableConcept>)izzzzj_),
                Author = new List<ContactDetail>((IEnumerable<ContactDetail>)izzzzk_),
                Editor = new List<ContactDetail>((IEnumerable<ContactDetail>)izzzzl_),
                Reviewer = new List<ContactDetail>((IEnumerable<ContactDetail>)izzzzm_),
                Endorser = new List<ContactDetail>((IEnumerable<ContactDetail>)izzzzn_),
                RelatedArtifact = new List<RelatedArtifact>((IEnumerable<RelatedArtifact>)izzzzo_),
                LibraryElement = new List<Canonical>((IEnumerable<Canonical>)izzzzp_),
                Population = izzzzq_,
                Exposure = izzzzr_,
                ExposureAlternative = izzzzs_,
                Outcome = izzzzt_,
            };

            return izzzzu_;
        };
        IEnumerable<ResearchDefinition> hzzzzj_ = context.Operators.Select<ResearchDefinition, ResearchDefinition>((IEnumerable<ResearchDefinition>)hzzzzh_, hzzzzi_);
        IEnumerable<ResearchDefinition> hzzzzk_ = context.Operators.Distinct<ResearchDefinition>(hzzzzj_);
        ResearchDefinition hzzzzl_ = context.Operators.SingletonFrom<ResearchDefinition>(hzzzzk_);

        return hzzzzl_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public ResearchElementDefinition ResearchElementDefinitionResource(CqlContext context, ResearchElementDefinition arg)
    {
        ResearchElementDefinition[] izzzzv_ = [
            arg,
        ];
        ResearchElementDefinition izzzzw_(ResearchElementDefinition a)
        {
            FhirUri jzzzza_ = a?.UrlElement;
            List<Identifier> jzzzzb_ = a?.Identifier;
            FhirString jzzzzc_ = a?.VersionElement;
            FhirString jzzzzd_ = a?.NameElement;
            FhirString jzzzze_ = a?.TitleElement;
            FhirString jzzzzf_ = a?.ShortTitleElement;
            FhirString jzzzzg_ = a?.SubtitleElement;
            Code<PublicationStatus> jzzzzh_ = a?.StatusElement;
            FhirBoolean jzzzzi_ = a?.ExperimentalElement;
            DataType jzzzzj_ = a?.Subject;
            FhirDateTime jzzzzk_ = a?.DateElement;
            FhirString jzzzzl_ = a?.PublisherElement;
            List<ContactDetail> jzzzzm_ = a?.Contact;
            Markdown jzzzzn_ = a?.DescriptionElement;
            List<FhirString> jzzzzo_ = a?.CommentElement;
            List<UsageContext> jzzzzp_ = a?.UseContext;
            List<CodeableConcept> jzzzzq_ = a?.Jurisdiction;
            Markdown jzzzzr_ = a?.PurposeElement;
            FhirString jzzzzs_ = a?.UsageElement;
            Markdown jzzzzt_ = a?.CopyrightElement;
            Date jzzzzu_ = a?.ApprovalDateElement;
            Date jzzzzv_ = a?.LastReviewDateElement;
            Period jzzzzw_ = a?.EffectivePeriod;
            List<CodeableConcept> jzzzzx_ = a?.Topic;
            List<ContactDetail> jzzzzy_ = a?.Author;
            List<ContactDetail> jzzzzz_ = a?.Editor;
            List<ContactDetail> kzzzza_ = a?.Reviewer;
            List<ContactDetail> kzzzzb_ = a?.Endorser;
            List<RelatedArtifact> kzzzzc_ = a?.RelatedArtifact;
            List<Canonical> kzzzzd_ = a?.LibraryElement;
            Code<ResearchElementDefinition.ResearchElementType> kzzzze_ = a?.TypeElement;
            Code<VariableTypeCode> kzzzzf_ = a?.VariableTypeElement;
            List<ResearchElementDefinition.CharacteristicComponent> kzzzzg_ = a?.Characteristic;
            ResearchElementDefinition kzzzzh_ = new ResearchElementDefinition
            {
                UrlElement = jzzzza_,
                Identifier = new List<Identifier>((IEnumerable<Identifier>)jzzzzb_),
                VersionElement = jzzzzc_,
                NameElement = jzzzzd_,
                TitleElement = jzzzze_,
                ShortTitleElement = jzzzzf_,
                SubtitleElement = jzzzzg_,
                StatusElement = jzzzzh_,
                ExperimentalElement = jzzzzi_,
                Subject = (DataType)jzzzzj_,
                DateElement = jzzzzk_,
                PublisherElement = jzzzzl_,
                Contact = new List<ContactDetail>((IEnumerable<ContactDetail>)jzzzzm_),
                DescriptionElement = jzzzzn_,
                CommentElement = new List<FhirString>((IEnumerable<FhirString>)jzzzzo_),
                UseContext = new List<UsageContext>((IEnumerable<UsageContext>)jzzzzp_),
                Jurisdiction = new List<CodeableConcept>((IEnumerable<CodeableConcept>)jzzzzq_),
                PurposeElement = jzzzzr_,
                UsageElement = jzzzzs_,
                CopyrightElement = jzzzzt_,
                ApprovalDateElement = jzzzzu_,
                LastReviewDateElement = jzzzzv_,
                EffectivePeriod = jzzzzw_,
                Topic = new List<CodeableConcept>((IEnumerable<CodeableConcept>)jzzzzx_),
                Author = new List<ContactDetail>((IEnumerable<ContactDetail>)jzzzzy_),
                Editor = new List<ContactDetail>((IEnumerable<ContactDetail>)jzzzzz_),
                Reviewer = new List<ContactDetail>((IEnumerable<ContactDetail>)kzzzza_),
                Endorser = new List<ContactDetail>((IEnumerable<ContactDetail>)kzzzzb_),
                RelatedArtifact = new List<RelatedArtifact>((IEnumerable<RelatedArtifact>)kzzzzc_),
                LibraryElement = new List<Canonical>((IEnumerable<Canonical>)kzzzzd_),
                TypeElement = kzzzze_,
                VariableTypeElement = kzzzzf_,
                Characteristic = new List<ResearchElementDefinition.CharacteristicComponent>((IEnumerable<ResearchElementDefinition.CharacteristicComponent>)kzzzzg_),
            };

            return kzzzzh_;
        };
        IEnumerable<ResearchElementDefinition> izzzzx_ = context.Operators.Select<ResearchElementDefinition, ResearchElementDefinition>((IEnumerable<ResearchElementDefinition>)izzzzv_, izzzzw_);
        IEnumerable<ResearchElementDefinition> izzzzy_ = context.Operators.Distinct<ResearchElementDefinition>(izzzzx_);
        ResearchElementDefinition izzzzz_ = context.Operators.SingletonFrom<ResearchElementDefinition>(izzzzy_);

        return izzzzz_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public ResearchStudy ResearchStudyResource(CqlContext context, ResearchStudy arg)
    {
        ResearchStudy[] kzzzzi_ = [
            arg,
        ];
        ResearchStudy kzzzzj_(ResearchStudy a)
        {
            List<Identifier> kzzzzn_ = a?.Identifier;
            FhirString kzzzzo_ = a?.TitleElement;
            List<ResourceReference> kzzzzp_ = a?.Protocol;
            List<ResourceReference> kzzzzq_ = a?.PartOf;
            Code<ResearchStudy.ResearchStudyStatus> kzzzzr_ = a?.StatusElement;
            CodeableConcept kzzzzs_ = a?.PrimaryPurposeType;
            CodeableConcept kzzzzt_ = a?.Phase;
            List<CodeableConcept> kzzzzu_ = a?.Category;
            List<CodeableConcept> kzzzzv_ = a?.Focus;
            List<CodeableConcept> kzzzzw_ = a?.Condition;
            List<ContactDetail> kzzzzx_ = a?.Contact;
            List<RelatedArtifact> kzzzzy_ = a?.RelatedArtifact;
            List<CodeableConcept> kzzzzz_ = a?.Keyword;
            List<CodeableConcept> lzzzza_ = a?.Location;
            Markdown lzzzzb_ = a?.DescriptionElement;
            List<ResourceReference> lzzzzc_ = a?.Enrollment;
            Period lzzzzd_ = a?.Period;
            ResourceReference lzzzze_ = a?.Sponsor;
            ResourceReference lzzzzf_ = a?.PrincipalInvestigator;
            List<ResourceReference> lzzzzg_ = a?.Site;
            CodeableConcept lzzzzh_ = a?.ReasonStopped;
            List<Annotation> lzzzzi_ = a?.Note;
            List<ResearchStudy.ArmComponent> lzzzzj_ = a?.Arm;
            List<ResearchStudy.ObjectiveComponent> lzzzzk_ = a?.Objective;
            ResearchStudy lzzzzl_ = new ResearchStudy
            {
                Identifier = new List<Identifier>((IEnumerable<Identifier>)kzzzzn_),
                TitleElement = kzzzzo_,
                Protocol = new List<ResourceReference>((IEnumerable<ResourceReference>)kzzzzp_),
                PartOf = new List<ResourceReference>((IEnumerable<ResourceReference>)kzzzzq_),
                StatusElement = kzzzzr_,
                PrimaryPurposeType = kzzzzs_,
                Phase = kzzzzt_,
                Category = new List<CodeableConcept>((IEnumerable<CodeableConcept>)kzzzzu_),
                Focus = new List<CodeableConcept>((IEnumerable<CodeableConcept>)kzzzzv_),
                Condition = new List<CodeableConcept>((IEnumerable<CodeableConcept>)kzzzzw_),
                Contact = new List<ContactDetail>((IEnumerable<ContactDetail>)kzzzzx_),
                RelatedArtifact = new List<RelatedArtifact>((IEnumerable<RelatedArtifact>)kzzzzy_),
                Keyword = new List<CodeableConcept>((IEnumerable<CodeableConcept>)kzzzzz_),
                Location = new List<CodeableConcept>((IEnumerable<CodeableConcept>)lzzzza_),
                DescriptionElement = lzzzzb_,
                Enrollment = new List<ResourceReference>((IEnumerable<ResourceReference>)lzzzzc_),
                Period = lzzzzd_,
                Sponsor = lzzzze_,
                PrincipalInvestigator = lzzzzf_,
                Site = new List<ResourceReference>((IEnumerable<ResourceReference>)lzzzzg_),
                ReasonStopped = lzzzzh_,
                Note = new List<Annotation>((IEnumerable<Annotation>)lzzzzi_),
                Arm = new List<ResearchStudy.ArmComponent>((IEnumerable<ResearchStudy.ArmComponent>)lzzzzj_),
                Objective = new List<ResearchStudy.ObjectiveComponent>((IEnumerable<ResearchStudy.ObjectiveComponent>)lzzzzk_),
            };

            return lzzzzl_;
        };
        IEnumerable<ResearchStudy> kzzzzk_ = context.Operators.Select<ResearchStudy, ResearchStudy>((IEnumerable<ResearchStudy>)kzzzzi_, kzzzzj_);
        IEnumerable<ResearchStudy> kzzzzl_ = context.Operators.Distinct<ResearchStudy>(kzzzzk_);
        ResearchStudy kzzzzm_ = context.Operators.SingletonFrom<ResearchStudy>(kzzzzl_);

        return kzzzzm_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public ResearchSubject ResearchSubjectResource(CqlContext context, ResearchSubject arg)
    {
        ResearchSubject[] lzzzzm_ = [
            arg,
        ];
        ResearchSubject lzzzzn_(ResearchSubject a)
        {
            List<Identifier> lzzzzr_ = a?.Identifier;
            Code<ResearchSubject.ResearchSubjectStatus> lzzzzs_ = a?.StatusElement;
            Period lzzzzt_ = a?.Period;
            ResourceReference lzzzzu_ = a?.Study;
            ResourceReference lzzzzv_ = a?.Individual;
            FhirString lzzzzw_ = a?.AssignedArmElement;
            FhirString lzzzzx_ = a?.ActualArmElement;
            ResourceReference lzzzzy_ = a?.Consent;
            ResearchSubject lzzzzz_ = new ResearchSubject
            {
                Identifier = new List<Identifier>((IEnumerable<Identifier>)lzzzzr_),
                StatusElement = lzzzzs_,
                Period = lzzzzt_,
                Study = lzzzzu_,
                Individual = lzzzzv_,
                AssignedArmElement = lzzzzw_,
                ActualArmElement = lzzzzx_,
                Consent = lzzzzy_,
            };

            return lzzzzz_;
        };
        IEnumerable<ResearchSubject> lzzzzo_ = context.Operators.Select<ResearchSubject, ResearchSubject>((IEnumerable<ResearchSubject>)lzzzzm_, lzzzzn_);
        IEnumerable<ResearchSubject> lzzzzp_ = context.Operators.Distinct<ResearchSubject>(lzzzzo_);
        ResearchSubject lzzzzq_ = context.Operators.SingletonFrom<ResearchSubject>(lzzzzp_);

        return lzzzzq_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public RiskAssessment RiskAssessmentResource(CqlContext context, RiskAssessment arg)
    {
        RiskAssessment[] mzzzza_ = [
            arg,
        ];
        RiskAssessment mzzzzb_(RiskAssessment a)
        {
            List<Identifier> mzzzzf_ = a?.Identifier;
            ResourceReference mzzzzg_ = a?.BasedOn;
            ResourceReference mzzzzh_ = a?.Parent;
            Code<ObservationStatus> mzzzzi_ = a?.StatusElement;
            CodeableConcept mzzzzj_ = a?.Method;
            CodeableConcept mzzzzk_ = a?.Code;
            ResourceReference mzzzzl_ = a?.Subject;
            ResourceReference mzzzzm_ = a?.Encounter;
            DataType mzzzzn_ = a?.Occurrence;
            ResourceReference mzzzzo_ = a?.Condition;
            ResourceReference mzzzzp_ = a?.Performer;
            List<CodeableConcept> mzzzzq_ = a?.ReasonCode;
            List<ResourceReference> mzzzzr_ = a?.ReasonReference;
            List<ResourceReference> mzzzzs_ = a?.Basis;
            List<RiskAssessment.PredictionComponent> mzzzzt_ = a?.Prediction;
            FhirString mzzzzu_ = a?.MitigationElement;
            List<Annotation> mzzzzv_ = a?.Note;
            RiskAssessment mzzzzw_ = new RiskAssessment
            {
                Identifier = new List<Identifier>((IEnumerable<Identifier>)mzzzzf_),
                BasedOn = mzzzzg_,
                Parent = mzzzzh_,
                StatusElement = mzzzzi_,
                Method = mzzzzj_,
                Code = mzzzzk_,
                Subject = mzzzzl_,
                Encounter = mzzzzm_,
                Occurrence = (DataType)mzzzzn_,
                Condition = mzzzzo_,
                Performer = mzzzzp_,
                ReasonCode = new List<CodeableConcept>((IEnumerable<CodeableConcept>)mzzzzq_),
                ReasonReference = new List<ResourceReference>((IEnumerable<ResourceReference>)mzzzzr_),
                Basis = new List<ResourceReference>((IEnumerable<ResourceReference>)mzzzzs_),
                Prediction = new List<RiskAssessment.PredictionComponent>((IEnumerable<RiskAssessment.PredictionComponent>)mzzzzt_),
                MitigationElement = mzzzzu_,
                Note = new List<Annotation>((IEnumerable<Annotation>)mzzzzv_),
            };

            return mzzzzw_;
        };
        IEnumerable<RiskAssessment> mzzzzc_ = context.Operators.Select<RiskAssessment, RiskAssessment>((IEnumerable<RiskAssessment>)mzzzza_, mzzzzb_);
        IEnumerable<RiskAssessment> mzzzzd_ = context.Operators.Distinct<RiskAssessment>(mzzzzc_);
        RiskAssessment mzzzze_ = context.Operators.SingletonFrom<RiskAssessment>(mzzzzd_);

        return mzzzze_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public RiskEvidenceSynthesis RiskEvidenceSynthesisResource(CqlContext context, RiskEvidenceSynthesis arg)
    {
        RiskEvidenceSynthesis[] mzzzzx_ = [
            arg,
        ];
        RiskEvidenceSynthesis mzzzzy_(RiskEvidenceSynthesis a)
        {
            FhirUri nzzzzc_ = a?.UrlElement;
            List<Identifier> nzzzzd_ = a?.Identifier;
            FhirString nzzzze_ = a?.VersionElement;
            FhirString nzzzzf_ = a?.NameElement;
            FhirString nzzzzg_ = a?.TitleElement;
            Code<PublicationStatus> nzzzzh_ = a?.StatusElement;
            FhirDateTime nzzzzi_ = a?.DateElement;
            FhirString nzzzzj_ = a?.PublisherElement;
            List<ContactDetail> nzzzzk_ = a?.Contact;
            Markdown nzzzzl_ = a?.DescriptionElement;
            List<Annotation> nzzzzm_ = a?.Note;
            List<UsageContext> nzzzzn_ = a?.UseContext;
            List<CodeableConcept> nzzzzo_ = a?.Jurisdiction;
            Markdown nzzzzp_ = a?.CopyrightElement;
            Date nzzzzq_ = a?.ApprovalDateElement;
            Date nzzzzr_ = a?.LastReviewDateElement;
            Period nzzzzs_ = a?.EffectivePeriod;
            List<CodeableConcept> nzzzzt_ = a?.Topic;
            List<ContactDetail> nzzzzu_ = a?.Author;
            List<ContactDetail> nzzzzv_ = a?.Editor;
            List<ContactDetail> nzzzzw_ = a?.Reviewer;
            List<ContactDetail> nzzzzx_ = a?.Endorser;
            List<RelatedArtifact> nzzzzy_ = a?.RelatedArtifact;
            CodeableConcept nzzzzz_ = a?.SynthesisType;
            CodeableConcept ozzzza_ = a?.StudyType;
            ResourceReference ozzzzb_ = a?.Population;
            ResourceReference ozzzzc_ = a?.Exposure;
            ResourceReference ozzzzd_ = a?.Outcome;
            RiskEvidenceSynthesis.SampleSizeComponent ozzzze_ = a?.SampleSize;
            RiskEvidenceSynthesis.RiskEstimateComponent ozzzzf_ = a?.RiskEstimate;
            List<RiskEvidenceSynthesis.CertaintyComponent> ozzzzg_ = a?.Certainty;
            RiskEvidenceSynthesis ozzzzh_ = new RiskEvidenceSynthesis
            {
                UrlElement = nzzzzc_,
                Identifier = new List<Identifier>((IEnumerable<Identifier>)nzzzzd_),
                VersionElement = nzzzze_,
                NameElement = nzzzzf_,
                TitleElement = nzzzzg_,
                StatusElement = nzzzzh_,
                DateElement = nzzzzi_,
                PublisherElement = nzzzzj_,
                Contact = new List<ContactDetail>((IEnumerable<ContactDetail>)nzzzzk_),
                DescriptionElement = nzzzzl_,
                Note = new List<Annotation>((IEnumerable<Annotation>)nzzzzm_),
                UseContext = new List<UsageContext>((IEnumerable<UsageContext>)nzzzzn_),
                Jurisdiction = new List<CodeableConcept>((IEnumerable<CodeableConcept>)nzzzzo_),
                CopyrightElement = nzzzzp_,
                ApprovalDateElement = nzzzzq_,
                LastReviewDateElement = nzzzzr_,
                EffectivePeriod = nzzzzs_,
                Topic = new List<CodeableConcept>((IEnumerable<CodeableConcept>)nzzzzt_),
                Author = new List<ContactDetail>((IEnumerable<ContactDetail>)nzzzzu_),
                Editor = new List<ContactDetail>((IEnumerable<ContactDetail>)nzzzzv_),
                Reviewer = new List<ContactDetail>((IEnumerable<ContactDetail>)nzzzzw_),
                Endorser = new List<ContactDetail>((IEnumerable<ContactDetail>)nzzzzx_),
                RelatedArtifact = new List<RelatedArtifact>((IEnumerable<RelatedArtifact>)nzzzzy_),
                SynthesisType = nzzzzz_,
                StudyType = ozzzza_,
                Population = ozzzzb_,
                Exposure = ozzzzc_,
                Outcome = ozzzzd_,
                SampleSize = ozzzze_,
                RiskEstimate = ozzzzf_,
                Certainty = new List<RiskEvidenceSynthesis.CertaintyComponent>((IEnumerable<RiskEvidenceSynthesis.CertaintyComponent>)ozzzzg_),
            };

            return ozzzzh_;
        };
        IEnumerable<RiskEvidenceSynthesis> mzzzzz_ = context.Operators.Select<RiskEvidenceSynthesis, RiskEvidenceSynthesis>((IEnumerable<RiskEvidenceSynthesis>)mzzzzx_, mzzzzy_);
        IEnumerable<RiskEvidenceSynthesis> nzzzza_ = context.Operators.Distinct<RiskEvidenceSynthesis>(mzzzzz_);
        RiskEvidenceSynthesis nzzzzb_ = context.Operators.SingletonFrom<RiskEvidenceSynthesis>(nzzzza_);

        return nzzzzb_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public Schedule ScheduleResource(CqlContext context, Schedule arg)
    {
        Schedule[] ozzzzi_ = [
            arg,
        ];
        Schedule ozzzzj_(Schedule a)
        {
            List<Identifier> ozzzzn_ = a?.Identifier;
            FhirBoolean ozzzzo_ = a?.ActiveElement;
            List<CodeableConcept> ozzzzp_ = a?.ServiceCategory;
            List<CodeableConcept> ozzzzq_ = a?.ServiceType;
            List<CodeableConcept> ozzzzr_ = a?.Specialty;
            List<ResourceReference> ozzzzs_ = a?.Actor;
            Period ozzzzt_ = a?.PlanningHorizon;
            FhirString ozzzzu_ = a?.CommentElement;
            Schedule ozzzzv_ = new Schedule
            {
                Identifier = new List<Identifier>((IEnumerable<Identifier>)ozzzzn_),
                ActiveElement = ozzzzo_,
                ServiceCategory = new List<CodeableConcept>((IEnumerable<CodeableConcept>)ozzzzp_),
                ServiceType = new List<CodeableConcept>((IEnumerable<CodeableConcept>)ozzzzq_),
                Specialty = new List<CodeableConcept>((IEnumerable<CodeableConcept>)ozzzzr_),
                Actor = new List<ResourceReference>((IEnumerable<ResourceReference>)ozzzzs_),
                PlanningHorizon = ozzzzt_,
                CommentElement = ozzzzu_,
            };

            return ozzzzv_;
        };
        IEnumerable<Schedule> ozzzzk_ = context.Operators.Select<Schedule, Schedule>((IEnumerable<Schedule>)ozzzzi_, ozzzzj_);
        IEnumerable<Schedule> ozzzzl_ = context.Operators.Distinct<Schedule>(ozzzzk_);
        Schedule ozzzzm_ = context.Operators.SingletonFrom<Schedule>(ozzzzl_);

        return ozzzzm_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public ServiceRequest ServiceRequestResource(CqlContext context, ServiceRequest arg)
    {
        ServiceRequest[] ozzzzw_ = [
            arg,
        ];
        ServiceRequest ozzzzx_(ServiceRequest a)
        {
            List<Identifier> pzzzzb_ = a?.Identifier;
            List<Canonical> pzzzzc_ = a?.InstantiatesCanonicalElement;
            List<FhirUri> pzzzzd_ = a?.InstantiatesUriElement;
            List<ResourceReference> pzzzze_ = a?.BasedOn;
            List<ResourceReference> pzzzzf_ = a?.Replaces;
            Identifier pzzzzg_ = a?.Requisition;
            Code<RequestStatus> pzzzzh_ = a?.StatusElement;
            Code<RequestIntent> pzzzzi_ = a?.IntentElement;
            List<CodeableConcept> pzzzzj_ = a?.Category;
            Code<RequestPriority> pzzzzk_ = a?.PriorityElement;
            FhirBoolean pzzzzl_ = a?.DoNotPerformElement;
            CodeableConcept pzzzzm_ = a?.Code;
            List<CodeableConcept> pzzzzn_ = a?.OrderDetail;
            DataType pzzzzo_ = a?.Quantity;
            ResourceReference pzzzzp_ = a?.Subject;
            ResourceReference pzzzzq_ = a?.Encounter;
            DataType pzzzzr_ = a?.Occurrence;
            DataType pzzzzs_ = a?.AsNeeded;
            FhirDateTime pzzzzt_ = a?.AuthoredOnElement;
            ResourceReference pzzzzu_ = a?.Requester;
            CodeableConcept pzzzzv_ = a?.PerformerType;
            List<ResourceReference> pzzzzw_ = a?.Performer;
            List<CodeableConcept> pzzzzx_ = a?.LocationCode;
            List<ResourceReference> pzzzzy_ = a?.LocationReference;
            List<CodeableConcept> pzzzzz_ = a?.ReasonCode;
            List<ResourceReference> qzzzza_ = a?.ReasonReference;
            List<ResourceReference> qzzzzb_ = a?.Insurance;
            List<ResourceReference> qzzzzc_ = a?.SupportingInfo;
            List<ResourceReference> qzzzzd_ = a?.Specimen;
            List<CodeableConcept> qzzzze_ = a?.BodySite;
            List<Annotation> qzzzzf_ = a?.Note;
            FhirString qzzzzg_ = a?.PatientInstructionElement;
            List<ResourceReference> qzzzzh_ = a?.RelevantHistory;
            ServiceRequest qzzzzi_ = new ServiceRequest
            {
                Identifier = new List<Identifier>((IEnumerable<Identifier>)pzzzzb_),
                InstantiatesCanonicalElement = new List<Canonical>((IEnumerable<Canonical>)pzzzzc_),
                InstantiatesUriElement = new List<FhirUri>((IEnumerable<FhirUri>)pzzzzd_),
                BasedOn = new List<ResourceReference>((IEnumerable<ResourceReference>)pzzzze_),
                Replaces = new List<ResourceReference>((IEnumerable<ResourceReference>)pzzzzf_),
                Requisition = pzzzzg_,
                StatusElement = pzzzzh_,
                IntentElement = pzzzzi_,
                Category = new List<CodeableConcept>((IEnumerable<CodeableConcept>)pzzzzj_),
                PriorityElement = pzzzzk_,
                DoNotPerformElement = pzzzzl_,
                Code = pzzzzm_,
                OrderDetail = new List<CodeableConcept>((IEnumerable<CodeableConcept>)pzzzzn_),
                Quantity = (DataType)pzzzzo_,
                Subject = pzzzzp_,
                Encounter = pzzzzq_,
                Occurrence = (DataType)pzzzzr_,
                AsNeeded = (DataType)pzzzzs_,
                AuthoredOnElement = pzzzzt_,
                Requester = pzzzzu_,
                PerformerType = pzzzzv_,
                Performer = new List<ResourceReference>((IEnumerable<ResourceReference>)pzzzzw_),
                LocationCode = new List<CodeableConcept>((IEnumerable<CodeableConcept>)pzzzzx_),
                LocationReference = new List<ResourceReference>((IEnumerable<ResourceReference>)pzzzzy_),
                ReasonCode = new List<CodeableConcept>((IEnumerable<CodeableConcept>)pzzzzz_),
                ReasonReference = new List<ResourceReference>((IEnumerable<ResourceReference>)qzzzza_),
                Insurance = new List<ResourceReference>((IEnumerable<ResourceReference>)qzzzzb_),
                SupportingInfo = new List<ResourceReference>((IEnumerable<ResourceReference>)qzzzzc_),
                Specimen = new List<ResourceReference>((IEnumerable<ResourceReference>)qzzzzd_),
                BodySite = new List<CodeableConcept>((IEnumerable<CodeableConcept>)qzzzze_),
                Note = new List<Annotation>((IEnumerable<Annotation>)qzzzzf_),
                PatientInstructionElement = qzzzzg_,
                RelevantHistory = new List<ResourceReference>((IEnumerable<ResourceReference>)qzzzzh_),
            };

            return qzzzzi_;
        };
        IEnumerable<ServiceRequest> ozzzzy_ = context.Operators.Select<ServiceRequest, ServiceRequest>((IEnumerable<ServiceRequest>)ozzzzw_, ozzzzx_);
        IEnumerable<ServiceRequest> ozzzzz_ = context.Operators.Distinct<ServiceRequest>(ozzzzy_);
        ServiceRequest pzzzza_ = context.Operators.SingletonFrom<ServiceRequest>(ozzzzz_);

        return pzzzza_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public Slot SlotResource(CqlContext context, Slot arg)
    {
        Slot[] qzzzzj_ = [
            arg,
        ];
        Slot qzzzzk_(Slot a)
        {
            List<Identifier> qzzzzo_ = a?.Identifier;
            List<CodeableConcept> qzzzzp_ = a?.ServiceCategory;
            List<CodeableConcept> qzzzzq_ = a?.ServiceType;
            List<CodeableConcept> qzzzzr_ = a?.Specialty;
            CodeableConcept qzzzzs_ = a?.AppointmentType;
            ResourceReference qzzzzt_ = a?.Schedule;
            Code<Slot.SlotStatus> qzzzzu_ = a?.StatusElement;
            Instant qzzzzv_ = a?.StartElement;
            Instant qzzzzw_ = a?.EndElement;
            FhirBoolean qzzzzx_ = a?.OverbookedElement;
            FhirString qzzzzy_ = a?.CommentElement;
            Slot qzzzzz_ = new Slot
            {
                Identifier = new List<Identifier>((IEnumerable<Identifier>)qzzzzo_),
                ServiceCategory = new List<CodeableConcept>((IEnumerable<CodeableConcept>)qzzzzp_),
                ServiceType = new List<CodeableConcept>((IEnumerable<CodeableConcept>)qzzzzq_),
                Specialty = new List<CodeableConcept>((IEnumerable<CodeableConcept>)qzzzzr_),
                AppointmentType = qzzzzs_,
                Schedule = qzzzzt_,
                StatusElement = qzzzzu_,
                StartElement = qzzzzv_,
                EndElement = qzzzzw_,
                OverbookedElement = qzzzzx_,
                CommentElement = qzzzzy_,
            };

            return qzzzzz_;
        };
        IEnumerable<Slot> qzzzzl_ = context.Operators.Select<Slot, Slot>((IEnumerable<Slot>)qzzzzj_, qzzzzk_);
        IEnumerable<Slot> qzzzzm_ = context.Operators.Distinct<Slot>(qzzzzl_);
        Slot qzzzzn_ = context.Operators.SingletonFrom<Slot>(qzzzzm_);

        return qzzzzn_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public Specimen SpecimenResource(CqlContext context, Specimen arg)
    {
        Specimen[] rzzzza_ = [
            arg,
        ];
        Specimen rzzzzb_(Specimen a)
        {
            List<Identifier> rzzzzf_ = a?.Identifier;
            Identifier rzzzzg_ = a?.AccessionIdentifier;
            Code<Specimen.SpecimenStatus> rzzzzh_ = a?.StatusElement;
            CodeableConcept rzzzzi_ = a?.Type;
            ResourceReference rzzzzj_ = a?.Subject;
            FhirDateTime rzzzzk_ = a?.ReceivedTimeElement;
            List<ResourceReference> rzzzzl_ = a?.Parent;
            List<ResourceReference> rzzzzm_ = a?.Request;
            Specimen.CollectionComponent rzzzzn_ = a?.Collection;
            List<Specimen.ProcessingComponent> rzzzzo_ = a?.Processing;
            List<Specimen.ContainerComponent> rzzzzp_ = a?.Container;
            List<CodeableConcept> rzzzzq_ = a?.Condition;
            List<Annotation> rzzzzr_ = a?.Note;
            Specimen rzzzzs_ = new Specimen
            {
                Identifier = new List<Identifier>((IEnumerable<Identifier>)rzzzzf_),
                AccessionIdentifier = rzzzzg_,
                StatusElement = rzzzzh_,
                Type = rzzzzi_,
                Subject = rzzzzj_,
                ReceivedTimeElement = rzzzzk_,
                Parent = new List<ResourceReference>((IEnumerable<ResourceReference>)rzzzzl_),
                Request = new List<ResourceReference>((IEnumerable<ResourceReference>)rzzzzm_),
                Collection = rzzzzn_,
                Processing = new List<Specimen.ProcessingComponent>((IEnumerable<Specimen.ProcessingComponent>)rzzzzo_),
                Container = new List<Specimen.ContainerComponent>((IEnumerable<Specimen.ContainerComponent>)rzzzzp_),
                Condition = new List<CodeableConcept>((IEnumerable<CodeableConcept>)rzzzzq_),
                Note = new List<Annotation>((IEnumerable<Annotation>)rzzzzr_),
            };

            return rzzzzs_;
        };
        IEnumerable<Specimen> rzzzzc_ = context.Operators.Select<Specimen, Specimen>((IEnumerable<Specimen>)rzzzza_, rzzzzb_);
        IEnumerable<Specimen> rzzzzd_ = context.Operators.Distinct<Specimen>(rzzzzc_);
        Specimen rzzzze_ = context.Operators.SingletonFrom<Specimen>(rzzzzd_);

        return rzzzze_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public SpecimenDefinition SpecimenDefinitionResource(CqlContext context, SpecimenDefinition arg)
    {
        SpecimenDefinition[] rzzzzt_ = [
            arg,
        ];
        SpecimenDefinition rzzzzu_(SpecimenDefinition a)
        {
            Identifier rzzzzy_ = a?.Identifier;
            CodeableConcept rzzzzz_ = a?.TypeCollected;
            List<CodeableConcept> szzzza_ = a?.PatientPreparation;
            FhirString szzzzb_ = a?.TimeAspectElement;
            List<CodeableConcept> szzzzc_ = a?.Collection;
            List<SpecimenDefinition.TypeTestedComponent> szzzzd_ = a?.TypeTested;
            SpecimenDefinition szzzze_ = new SpecimenDefinition
            {
                Identifier = rzzzzy_,
                TypeCollected = rzzzzz_,
                PatientPreparation = new List<CodeableConcept>((IEnumerable<CodeableConcept>)szzzza_),
                TimeAspectElement = szzzzb_,
                Collection = new List<CodeableConcept>((IEnumerable<CodeableConcept>)szzzzc_),
                TypeTested = new List<SpecimenDefinition.TypeTestedComponent>((IEnumerable<SpecimenDefinition.TypeTestedComponent>)szzzzd_),
            };

            return szzzze_;
        };
        IEnumerable<SpecimenDefinition> rzzzzv_ = context.Operators.Select<SpecimenDefinition, SpecimenDefinition>((IEnumerable<SpecimenDefinition>)rzzzzt_, rzzzzu_);
        IEnumerable<SpecimenDefinition> rzzzzw_ = context.Operators.Distinct<SpecimenDefinition>(rzzzzv_);
        SpecimenDefinition rzzzzx_ = context.Operators.SingletonFrom<SpecimenDefinition>(rzzzzw_);

        return rzzzzx_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public StructureDefinition StructureDefinitionResource(CqlContext context, StructureDefinition arg)
    {
        StructureDefinition[] szzzzf_ = [
            arg,
        ];
        StructureDefinition szzzzg_(StructureDefinition a)
        {
            FhirUri szzzzk_ = a?.UrlElement;
            List<Identifier> szzzzl_ = a?.Identifier;
            FhirString szzzzm_ = a?.VersionElement;
            FhirString szzzzn_ = a?.NameElement;
            FhirString szzzzo_ = a?.TitleElement;
            Code<PublicationStatus> szzzzp_ = a?.StatusElement;
            FhirBoolean szzzzq_ = a?.ExperimentalElement;
            FhirDateTime szzzzr_ = a?.DateElement;
            FhirString szzzzs_ = a?.PublisherElement;
            List<ContactDetail> szzzzt_ = a?.Contact;
            Markdown szzzzu_ = a?.DescriptionElement;
            List<UsageContext> szzzzv_ = a?.UseContext;
            List<CodeableConcept> szzzzw_ = a?.Jurisdiction;
            Markdown szzzzx_ = a?.PurposeElement;
            Markdown szzzzy_ = a?.CopyrightElement;
            List<Coding> szzzzz_ = a?.Keyword;
            Code<FHIRVersion> tzzzza_ = a?.FhirVersionElement;
            List<StructureDefinition.MappingComponent> tzzzzb_ = a?.Mapping;
            Code<StructureDefinition.StructureDefinitionKind> tzzzzc_ = a?.KindElement;
            FhirBoolean tzzzzd_ = a?.AbstractElement;
            List<StructureDefinition.ContextComponent> tzzzze_ = a?.Context;
            List<FhirString> tzzzzf_ = a?.ContextInvariantElement;
            FhirUri tzzzzg_ = a?.TypeElement;
            Canonical tzzzzh_ = a?.BaseDefinitionElement;
            Code<StructureDefinition.TypeDerivationRule> tzzzzi_ = a?.DerivationElement;
            StructureDefinition.SnapshotComponent tzzzzj_ = a?.Snapshot;
            StructureDefinition.DifferentialComponent tzzzzk_ = a?.Differential;
            StructureDefinition tzzzzl_ = new StructureDefinition
            {
                UrlElement = szzzzk_,
                Identifier = new List<Identifier>((IEnumerable<Identifier>)szzzzl_),
                VersionElement = szzzzm_,
                NameElement = szzzzn_,
                TitleElement = szzzzo_,
                StatusElement = szzzzp_,
                ExperimentalElement = szzzzq_,
                DateElement = szzzzr_,
                PublisherElement = szzzzs_,
                Contact = new List<ContactDetail>((IEnumerable<ContactDetail>)szzzzt_),
                DescriptionElement = szzzzu_,
                UseContext = new List<UsageContext>((IEnumerable<UsageContext>)szzzzv_),
                Jurisdiction = new List<CodeableConcept>((IEnumerable<CodeableConcept>)szzzzw_),
                PurposeElement = szzzzx_,
                CopyrightElement = szzzzy_,
                Keyword = new List<Coding>((IEnumerable<Coding>)szzzzz_),
                FhirVersionElement = tzzzza_,
                Mapping = new List<StructureDefinition.MappingComponent>((IEnumerable<StructureDefinition.MappingComponent>)tzzzzb_),
                KindElement = tzzzzc_,
                AbstractElement = tzzzzd_,
                Context = new List<StructureDefinition.ContextComponent>((IEnumerable<StructureDefinition.ContextComponent>)tzzzze_),
                ContextInvariantElement = new List<FhirString>((IEnumerable<FhirString>)tzzzzf_),
                TypeElement = tzzzzg_,
                BaseDefinitionElement = tzzzzh_,
                DerivationElement = tzzzzi_,
                Snapshot = tzzzzj_,
                Differential = tzzzzk_,
            };

            return tzzzzl_;
        };
        IEnumerable<StructureDefinition> szzzzh_ = context.Operators.Select<StructureDefinition, StructureDefinition>((IEnumerable<StructureDefinition>)szzzzf_, szzzzg_);
        IEnumerable<StructureDefinition> szzzzi_ = context.Operators.Distinct<StructureDefinition>(szzzzh_);
        StructureDefinition szzzzj_ = context.Operators.SingletonFrom<StructureDefinition>(szzzzi_);

        return szzzzj_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public StructureMap StructureMapResource(CqlContext context, StructureMap arg)
    {
        StructureMap[] tzzzzm_ = [
            arg,
        ];
        StructureMap tzzzzn_(StructureMap a)
        {
            FhirUri tzzzzr_ = a?.UrlElement;
            List<Identifier> tzzzzs_ = a?.Identifier;
            FhirString tzzzzt_ = a?.VersionElement;
            FhirString tzzzzu_ = a?.NameElement;
            FhirString tzzzzv_ = a?.TitleElement;
            Code<PublicationStatus> tzzzzw_ = a?.StatusElement;
            FhirBoolean tzzzzx_ = a?.ExperimentalElement;
            FhirDateTime tzzzzy_ = a?.DateElement;
            FhirString tzzzzz_ = a?.PublisherElement;
            List<ContactDetail> uzzzza_ = a?.Contact;
            Markdown uzzzzb_ = a?.DescriptionElement;
            List<UsageContext> uzzzzc_ = a?.UseContext;
            List<CodeableConcept> uzzzzd_ = a?.Jurisdiction;
            Markdown uzzzze_ = a?.PurposeElement;
            Markdown uzzzzf_ = a?.CopyrightElement;
            List<StructureMap.StructureComponent> uzzzzg_ = a?.Structure;
            List<Canonical> uzzzzh_ = a?.ImportElement;
            List<StructureMap.GroupComponent> uzzzzi_ = a?.Group;
            StructureMap uzzzzj_ = new StructureMap
            {
                UrlElement = tzzzzr_,
                Identifier = new List<Identifier>((IEnumerable<Identifier>)tzzzzs_),
                VersionElement = tzzzzt_,
                NameElement = tzzzzu_,
                TitleElement = tzzzzv_,
                StatusElement = tzzzzw_,
                ExperimentalElement = tzzzzx_,
                DateElement = tzzzzy_,
                PublisherElement = tzzzzz_,
                Contact = new List<ContactDetail>((IEnumerable<ContactDetail>)uzzzza_),
                DescriptionElement = uzzzzb_,
                UseContext = new List<UsageContext>((IEnumerable<UsageContext>)uzzzzc_),
                Jurisdiction = new List<CodeableConcept>((IEnumerable<CodeableConcept>)uzzzzd_),
                PurposeElement = uzzzze_,
                CopyrightElement = uzzzzf_,
                Structure = new List<StructureMap.StructureComponent>((IEnumerable<StructureMap.StructureComponent>)uzzzzg_),
                ImportElement = new List<Canonical>((IEnumerable<Canonical>)uzzzzh_),
                Group = new List<StructureMap.GroupComponent>((IEnumerable<StructureMap.GroupComponent>)uzzzzi_),
            };

            return uzzzzj_;
        };
        IEnumerable<StructureMap> tzzzzo_ = context.Operators.Select<StructureMap, StructureMap>((IEnumerable<StructureMap>)tzzzzm_, tzzzzn_);
        IEnumerable<StructureMap> tzzzzp_ = context.Operators.Distinct<StructureMap>(tzzzzo_);
        StructureMap tzzzzq_ = context.Operators.SingletonFrom<StructureMap>(tzzzzp_);

        return tzzzzq_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public Subscription SubscriptionResource(CqlContext context, Subscription arg)
    {
        Subscription[] uzzzzk_ = [
            arg,
        ];
        Subscription uzzzzl_(Subscription a)
        {
            Code<Subscription.SubscriptionStatus> uzzzzp_ = a?.StatusElement;
            List<ContactPoint> uzzzzq_ = a?.Contact;
            Instant uzzzzr_ = a?.EndElement;
            FhirString uzzzzs_ = a?.ReasonElement;
            FhirString uzzzzt_ = a?.CriteriaElement;
            FhirString uzzzzu_ = a?.ErrorElement;
            Subscription.ChannelComponent uzzzzv_ = a?.Channel;
            Subscription uzzzzw_ = new Subscription
            {
                StatusElement = uzzzzp_,
                Contact = new List<ContactPoint>((IEnumerable<ContactPoint>)uzzzzq_),
                EndElement = uzzzzr_,
                ReasonElement = uzzzzs_,
                CriteriaElement = uzzzzt_,
                ErrorElement = uzzzzu_,
                Channel = uzzzzv_,
            };

            return uzzzzw_;
        };
        IEnumerable<Subscription> uzzzzm_ = context.Operators.Select<Subscription, Subscription>((IEnumerable<Subscription>)uzzzzk_, uzzzzl_);
        IEnumerable<Subscription> uzzzzn_ = context.Operators.Distinct<Subscription>(uzzzzm_);
        Subscription uzzzzo_ = context.Operators.SingletonFrom<Subscription>(uzzzzn_);

        return uzzzzo_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public Substance SubstanceResource(CqlContext context, Substance arg)
    {
        Substance[] uzzzzx_ = [
            arg,
        ];
        Substance uzzzzy_(Substance a)
        {
            List<Identifier> vzzzzc_ = a?.Identifier;
            Code<Substance.FHIRSubstanceStatus> vzzzzd_ = a?.StatusElement;
            List<CodeableConcept> vzzzze_ = a?.Category;
            CodeableConcept vzzzzf_ = a?.Code;
            FhirString vzzzzg_ = a?.DescriptionElement;
            List<Substance.InstanceComponent> vzzzzh_ = a?.Instance;
            List<Substance.IngredientComponent> vzzzzi_ = a?.Ingredient;
            Substance vzzzzj_ = new Substance
            {
                Identifier = new List<Identifier>((IEnumerable<Identifier>)vzzzzc_),
                StatusElement = vzzzzd_,
                Category = new List<CodeableConcept>((IEnumerable<CodeableConcept>)vzzzze_),
                Code = vzzzzf_,
                DescriptionElement = vzzzzg_,
                Instance = new List<Substance.InstanceComponent>((IEnumerable<Substance.InstanceComponent>)vzzzzh_),
                Ingredient = new List<Substance.IngredientComponent>((IEnumerable<Substance.IngredientComponent>)vzzzzi_),
            };

            return vzzzzj_;
        };
        IEnumerable<Substance> uzzzzz_ = context.Operators.Select<Substance, Substance>((IEnumerable<Substance>)uzzzzx_, uzzzzy_);
        IEnumerable<Substance> vzzzza_ = context.Operators.Distinct<Substance>(uzzzzz_);
        Substance vzzzzb_ = context.Operators.SingletonFrom<Substance>(vzzzza_);

        return vzzzzb_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public SubstanceNucleicAcid SubstanceNucleicAcidResource(CqlContext context, SubstanceNucleicAcid arg)
    {
        SubstanceNucleicAcid[] vzzzzk_ = [
            arg,
        ];
        SubstanceNucleicAcid vzzzzl_(SubstanceNucleicAcid a)
        {
            CodeableConcept vzzzzp_ = a?.SequenceType;
            Integer vzzzzq_ = a?.NumberOfSubunitsElement;
            FhirString vzzzzr_ = a?.AreaOfHybridisationElement;
            CodeableConcept vzzzzs_ = a?.OligoNucleotideType;
            List<SubstanceNucleicAcid.SubunitComponent> vzzzzt_ = a?.Subunit;
            SubstanceNucleicAcid vzzzzu_ = new SubstanceNucleicAcid
            {
                SequenceType = vzzzzp_,
                NumberOfSubunitsElement = vzzzzq_,
                AreaOfHybridisationElement = vzzzzr_,
                OligoNucleotideType = vzzzzs_,
                Subunit = new List<SubstanceNucleicAcid.SubunitComponent>((IEnumerable<SubstanceNucleicAcid.SubunitComponent>)vzzzzt_),
            };

            return vzzzzu_;
        };
        IEnumerable<SubstanceNucleicAcid> vzzzzm_ = context.Operators.Select<SubstanceNucleicAcid, SubstanceNucleicAcid>((IEnumerable<SubstanceNucleicAcid>)vzzzzk_, vzzzzl_);
        IEnumerable<SubstanceNucleicAcid> vzzzzn_ = context.Operators.Distinct<SubstanceNucleicAcid>(vzzzzm_);
        SubstanceNucleicAcid vzzzzo_ = context.Operators.SingletonFrom<SubstanceNucleicAcid>(vzzzzn_);

        return vzzzzo_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public SubstancePolymer SubstancePolymerResource(CqlContext context, SubstancePolymer arg)
    {
        SubstancePolymer[] vzzzzv_ = [
            arg,
        ];
        SubstancePolymer vzzzzw_(SubstancePolymer a)
        {
            CodeableConcept wzzzza_ = a?.Class;
            CodeableConcept wzzzzb_ = a?.Geometry;
            List<CodeableConcept> wzzzzc_ = a?.CopolymerConnectivity;
            List<FhirString> wzzzzd_ = a?.ModificationElement;
            List<SubstancePolymer.MonomerSetComponent> wzzzze_ = a?.MonomerSet;
            List<SubstancePolymer.RepeatComponent> wzzzzf_ = a?.Repeat;
            SubstancePolymer wzzzzg_ = new SubstancePolymer
            {
                Class = wzzzza_,
                Geometry = wzzzzb_,
                CopolymerConnectivity = new List<CodeableConcept>((IEnumerable<CodeableConcept>)wzzzzc_),
                ModificationElement = new List<FhirString>((IEnumerable<FhirString>)wzzzzd_),
                MonomerSet = new List<SubstancePolymer.MonomerSetComponent>((IEnumerable<SubstancePolymer.MonomerSetComponent>)wzzzze_),
                Repeat = new List<SubstancePolymer.RepeatComponent>((IEnumerable<SubstancePolymer.RepeatComponent>)wzzzzf_),
            };

            return wzzzzg_;
        };
        IEnumerable<SubstancePolymer> vzzzzx_ = context.Operators.Select<SubstancePolymer, SubstancePolymer>((IEnumerable<SubstancePolymer>)vzzzzv_, vzzzzw_);
        IEnumerable<SubstancePolymer> vzzzzy_ = context.Operators.Distinct<SubstancePolymer>(vzzzzx_);
        SubstancePolymer vzzzzz_ = context.Operators.SingletonFrom<SubstancePolymer>(vzzzzy_);

        return vzzzzz_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public SubstanceProtein SubstanceProteinResource(CqlContext context, SubstanceProtein arg)
    {
        SubstanceProtein[] wzzzzh_ = [
            arg,
        ];
        SubstanceProtein wzzzzi_(SubstanceProtein a)
        {
            CodeableConcept wzzzzm_ = a?.SequenceType;
            Integer wzzzzn_ = a?.NumberOfSubunitsElement;
            List<FhirString> wzzzzo_ = a?.DisulfideLinkageElement;
            List<SubstanceProtein.SubunitComponent> wzzzzp_ = a?.Subunit;
            SubstanceProtein wzzzzq_ = new SubstanceProtein
            {
                SequenceType = wzzzzm_,
                NumberOfSubunitsElement = wzzzzn_,
                DisulfideLinkageElement = new List<FhirString>((IEnumerable<FhirString>)wzzzzo_),
                Subunit = new List<SubstanceProtein.SubunitComponent>((IEnumerable<SubstanceProtein.SubunitComponent>)wzzzzp_),
            };

            return wzzzzq_;
        };
        IEnumerable<SubstanceProtein> wzzzzj_ = context.Operators.Select<SubstanceProtein, SubstanceProtein>((IEnumerable<SubstanceProtein>)wzzzzh_, wzzzzi_);
        IEnumerable<SubstanceProtein> wzzzzk_ = context.Operators.Distinct<SubstanceProtein>(wzzzzj_);
        SubstanceProtein wzzzzl_ = context.Operators.SingletonFrom<SubstanceProtein>(wzzzzk_);

        return wzzzzl_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public SubstanceReferenceInformation SubstanceReferenceInformationResource(CqlContext context, SubstanceReferenceInformation arg)
    {
        SubstanceReferenceInformation[] wzzzzr_ = [
            arg,
        ];
        SubstanceReferenceInformation wzzzzs_(SubstanceReferenceInformation a)
        {
            FhirString wzzzzw_ = a?.CommentElement;
            List<SubstanceReferenceInformation.GeneComponent> wzzzzx_ = a?.Gene;
            List<SubstanceReferenceInformation.GeneElementComponent> wzzzzy_ = a?.GeneElement;
            List<SubstanceReferenceInformation.ClassificationComponent> wzzzzz_ = a?.Classification;
            List<SubstanceReferenceInformation.TargetComponent> xzzzza_ = a?.Target;
            SubstanceReferenceInformation xzzzzb_ = new SubstanceReferenceInformation
            {
                CommentElement = wzzzzw_,
                Gene = new List<SubstanceReferenceInformation.GeneComponent>((IEnumerable<SubstanceReferenceInformation.GeneComponent>)wzzzzx_),
                GeneElement = new List<SubstanceReferenceInformation.GeneElementComponent>((IEnumerable<SubstanceReferenceInformation.GeneElementComponent>)wzzzzy_),
                Classification = new List<SubstanceReferenceInformation.ClassificationComponent>((IEnumerable<SubstanceReferenceInformation.ClassificationComponent>)wzzzzz_),
                Target = new List<SubstanceReferenceInformation.TargetComponent>((IEnumerable<SubstanceReferenceInformation.TargetComponent>)xzzzza_),
            };

            return xzzzzb_;
        };
        IEnumerable<SubstanceReferenceInformation> wzzzzt_ = context.Operators.Select<SubstanceReferenceInformation, SubstanceReferenceInformation>((IEnumerable<SubstanceReferenceInformation>)wzzzzr_, wzzzzs_);
        IEnumerable<SubstanceReferenceInformation> wzzzzu_ = context.Operators.Distinct<SubstanceReferenceInformation>(wzzzzt_);
        SubstanceReferenceInformation wzzzzv_ = context.Operators.SingletonFrom<SubstanceReferenceInformation>(wzzzzu_);

        return wzzzzv_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public SubstanceSourceMaterial SubstanceSourceMaterialResource(CqlContext context, SubstanceSourceMaterial arg)
    {
        SubstanceSourceMaterial[] xzzzzc_ = [
            arg,
        ];
        SubstanceSourceMaterial xzzzzd_(SubstanceSourceMaterial a)
        {
            CodeableConcept xzzzzh_ = a?.SourceMaterialClass;
            CodeableConcept xzzzzi_ = a?.SourceMaterialType;
            CodeableConcept xzzzzj_ = a?.SourceMaterialState;
            Identifier xzzzzk_ = a?.OrganismId;
            FhirString xzzzzl_ = a?.OrganismNameElement;
            List<Identifier> xzzzzm_ = a?.ParentSubstanceId;
            List<FhirString> xzzzzn_ = a?.ParentSubstanceNameElement;
            List<CodeableConcept> xzzzzo_ = a?.CountryOfOrigin;
            List<FhirString> xzzzzp_ = a?.GeographicalLocationElement;
            CodeableConcept xzzzzq_ = a?.DevelopmentStage;
            List<SubstanceSourceMaterial.FractionDescriptionComponent> xzzzzr_ = a?.FractionDescription;
            SubstanceSourceMaterial.OrganismComponent xzzzzs_ = a?.Organism;
            List<SubstanceSourceMaterial.PartDescriptionComponent> xzzzzt_ = a?.PartDescription;
            SubstanceSourceMaterial xzzzzu_ = new SubstanceSourceMaterial
            {
                SourceMaterialClass = xzzzzh_,
                SourceMaterialType = xzzzzi_,
                SourceMaterialState = xzzzzj_,
                OrganismId = xzzzzk_,
                OrganismNameElement = xzzzzl_,
                ParentSubstanceId = new List<Identifier>((IEnumerable<Identifier>)xzzzzm_),
                ParentSubstanceNameElement = new List<FhirString>((IEnumerable<FhirString>)xzzzzn_),
                CountryOfOrigin = new List<CodeableConcept>((IEnumerable<CodeableConcept>)xzzzzo_),
                GeographicalLocationElement = new List<FhirString>((IEnumerable<FhirString>)xzzzzp_),
                DevelopmentStage = xzzzzq_,
                FractionDescription = new List<SubstanceSourceMaterial.FractionDescriptionComponent>((IEnumerable<SubstanceSourceMaterial.FractionDescriptionComponent>)xzzzzr_),
                Organism = xzzzzs_,
                PartDescription = new List<SubstanceSourceMaterial.PartDescriptionComponent>((IEnumerable<SubstanceSourceMaterial.PartDescriptionComponent>)xzzzzt_),
            };

            return xzzzzu_;
        };
        IEnumerable<SubstanceSourceMaterial> xzzzze_ = context.Operators.Select<SubstanceSourceMaterial, SubstanceSourceMaterial>((IEnumerable<SubstanceSourceMaterial>)xzzzzc_, xzzzzd_);
        IEnumerable<SubstanceSourceMaterial> xzzzzf_ = context.Operators.Distinct<SubstanceSourceMaterial>(xzzzze_);
        SubstanceSourceMaterial xzzzzg_ = context.Operators.SingletonFrom<SubstanceSourceMaterial>(xzzzzf_);

        return xzzzzg_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public SubstanceSpecification SubstanceSpecificationResource(CqlContext context, SubstanceSpecification arg)
    {
        SubstanceSpecification[] xzzzzv_ = [
            arg,
        ];
        SubstanceSpecification xzzzzw_(SubstanceSpecification a)
        {
            Identifier yzzzza_ = a?.Identifier;
            CodeableConcept yzzzzb_ = a?.Type;
            CodeableConcept yzzzzc_ = a?.Status;
            CodeableConcept yzzzzd_ = a?.Domain;
            FhirString yzzzze_ = a?.DescriptionElement;
            List<ResourceReference> yzzzzf_ = a?.Source;
            FhirString yzzzzg_ = a?.CommentElement;
            List<SubstanceSpecification.MoietyComponent> yzzzzh_ = a?.Moiety;
            List<SubstanceSpecification.PropertyComponent> yzzzzi_ = a?.Property;
            ResourceReference yzzzzj_ = a?.ReferenceInformation;
            SubstanceSpecification.StructureComponent yzzzzk_ = a?.Structure;
            List<SubstanceSpecification.CodeComponent> yzzzzl_ = a?.Code;
            List<SubstanceSpecification.NameComponent> yzzzzm_ = a?.Name;
            List<SubstanceSpecification.MolecularWeightComponent> yzzzzn_ = a?.MolecularWeight;
            List<SubstanceSpecification.RelationshipComponent> yzzzzo_ = a?.Relationship;
            ResourceReference yzzzzp_ = a?.NucleicAcid;
            ResourceReference yzzzzq_ = a?.Polymer;
            ResourceReference yzzzzr_ = a?.Protein;
            ResourceReference yzzzzs_ = a?.SourceMaterial;
            SubstanceSpecification yzzzzt_ = new SubstanceSpecification
            {
                Identifier = yzzzza_,
                Type = yzzzzb_,
                Status = yzzzzc_,
                Domain = yzzzzd_,
                DescriptionElement = yzzzze_,
                Source = new List<ResourceReference>((IEnumerable<ResourceReference>)yzzzzf_),
                CommentElement = yzzzzg_,
                Moiety = new List<SubstanceSpecification.MoietyComponent>((IEnumerable<SubstanceSpecification.MoietyComponent>)yzzzzh_),
                Property = new List<SubstanceSpecification.PropertyComponent>((IEnumerable<SubstanceSpecification.PropertyComponent>)yzzzzi_),
                ReferenceInformation = yzzzzj_,
                Structure = yzzzzk_,
                Code = new List<SubstanceSpecification.CodeComponent>((IEnumerable<SubstanceSpecification.CodeComponent>)yzzzzl_),
                Name = new List<SubstanceSpecification.NameComponent>((IEnumerable<SubstanceSpecification.NameComponent>)yzzzzm_),
                MolecularWeight = new List<SubstanceSpecification.MolecularWeightComponent>((IEnumerable<SubstanceSpecification.MolecularWeightComponent>)yzzzzn_),
                Relationship = new List<SubstanceSpecification.RelationshipComponent>((IEnumerable<SubstanceSpecification.RelationshipComponent>)yzzzzo_),
                NucleicAcid = yzzzzp_,
                Polymer = yzzzzq_,
                Protein = yzzzzr_,
                SourceMaterial = yzzzzs_,
            };

            return yzzzzt_;
        };
        IEnumerable<SubstanceSpecification> xzzzzx_ = context.Operators.Select<SubstanceSpecification, SubstanceSpecification>((IEnumerable<SubstanceSpecification>)xzzzzv_, xzzzzw_);
        IEnumerable<SubstanceSpecification> xzzzzy_ = context.Operators.Distinct<SubstanceSpecification>(xzzzzx_);
        SubstanceSpecification xzzzzz_ = context.Operators.SingletonFrom<SubstanceSpecification>(xzzzzy_);

        return xzzzzz_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public SupplyDelivery SupplyDeliveryResource(CqlContext context, SupplyDelivery arg)
    {
        SupplyDelivery[] yzzzzu_ = [
            arg,
        ];
        SupplyDelivery yzzzzv_(SupplyDelivery a)
        {
            List<Identifier> yzzzzz_ = a?.Identifier;
            List<ResourceReference> zzzzza_ = a?.BasedOn;
            List<ResourceReference> zzzzzb_ = a?.PartOf;
            Code<SupplyDelivery.SupplyDeliveryStatus> zzzzzc_ = a?.StatusElement;
            ResourceReference zzzzzd_ = a?.Patient;
            CodeableConcept zzzzze_ = a?.Type;
            SupplyDelivery.SuppliedItemComponent zzzzzf_ = a?.SuppliedItem;
            DataType zzzzzg_ = a?.Occurrence;
            ResourceReference zzzzzh_ = a?.Supplier;
            ResourceReference zzzzzi_ = a?.Destination;
            List<ResourceReference> zzzzzj_ = a?.Receiver;
            SupplyDelivery zzzzzk_ = new SupplyDelivery
            {
                Identifier = new List<Identifier>((IEnumerable<Identifier>)yzzzzz_),
                BasedOn = new List<ResourceReference>((IEnumerable<ResourceReference>)zzzzza_),
                PartOf = new List<ResourceReference>((IEnumerable<ResourceReference>)zzzzzb_),
                StatusElement = zzzzzc_,
                Patient = zzzzzd_,
                Type = zzzzze_,
                SuppliedItem = zzzzzf_,
                Occurrence = (DataType)zzzzzg_,
                Supplier = zzzzzh_,
                Destination = zzzzzi_,
                Receiver = new List<ResourceReference>((IEnumerable<ResourceReference>)zzzzzj_),
            };

            return zzzzzk_;
        };
        IEnumerable<SupplyDelivery> yzzzzw_ = context.Operators.Select<SupplyDelivery, SupplyDelivery>((IEnumerable<SupplyDelivery>)yzzzzu_, yzzzzv_);
        IEnumerable<SupplyDelivery> yzzzzx_ = context.Operators.Distinct<SupplyDelivery>(yzzzzw_);
        SupplyDelivery yzzzzy_ = context.Operators.SingletonFrom<SupplyDelivery>(yzzzzx_);

        return yzzzzy_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public SupplyRequest SupplyRequestResource(CqlContext context, SupplyRequest arg)
    {
        SupplyRequest[] zzzzzl_ = [
            arg,
        ];
        SupplyRequest zzzzzm_(SupplyRequest a)
        {
            List<Identifier> zzzzzq_ = a?.Identifier;
            Code<SupplyRequest.SupplyRequestStatus> zzzzzr_ = a?.StatusElement;
            CodeableConcept zzzzzs_ = a?.Category;
            Code<RequestPriority> zzzzzt_ = a?.PriorityElement;
            DataType zzzzzu_ = a?.Item;
            Quantity zzzzzv_ = a?.Quantity;
            List<SupplyRequest.ParameterComponent> zzzzzw_ = a?.Parameter;
            DataType zzzzzx_ = a?.Occurrence;
            FhirDateTime zzzzzy_ = a?.AuthoredOnElement;
            ResourceReference zzzzzz_ = a?.Requester;
            List<ResourceReference> azzzzza_ = a?.Supplier;
            List<CodeableConcept> azzzzzb_ = a?.ReasonCode;
            List<ResourceReference> azzzzzc_ = a?.ReasonReference;
            ResourceReference azzzzzd_ = a?.DeliverFrom;
            ResourceReference azzzzze_ = a?.DeliverTo;
            SupplyRequest azzzzzf_ = new SupplyRequest
            {
                Identifier = new List<Identifier>((IEnumerable<Identifier>)zzzzzq_),
                StatusElement = zzzzzr_,
                Category = zzzzzs_,
                PriorityElement = zzzzzt_,
                Item = (DataType)zzzzzu_,
                Quantity = zzzzzv_,
                Parameter = new List<SupplyRequest.ParameterComponent>((IEnumerable<SupplyRequest.ParameterComponent>)zzzzzw_),
                Occurrence = (DataType)zzzzzx_,
                AuthoredOnElement = zzzzzy_,
                Requester = zzzzzz_,
                Supplier = new List<ResourceReference>((IEnumerable<ResourceReference>)azzzzza_),
                ReasonCode = new List<CodeableConcept>((IEnumerable<CodeableConcept>)azzzzzb_),
                ReasonReference = new List<ResourceReference>((IEnumerable<ResourceReference>)azzzzzc_),
                DeliverFrom = azzzzzd_,
                DeliverTo = azzzzze_,
            };

            return azzzzzf_;
        };
        IEnumerable<SupplyRequest> zzzzzn_ = context.Operators.Select<SupplyRequest, SupplyRequest>((IEnumerable<SupplyRequest>)zzzzzl_, zzzzzm_);
        IEnumerable<SupplyRequest> zzzzzo_ = context.Operators.Distinct<SupplyRequest>(zzzzzn_);
        SupplyRequest zzzzzp_ = context.Operators.SingletonFrom<SupplyRequest>(zzzzzo_);

        return zzzzzp_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public Task TaskResource(CqlContext context, Task arg)
    {
        Task[] azzzzzg_ = [
            arg,
        ];
        Task azzzzzh_(Task a)
        {
            List<Identifier> azzzzzl_ = a?.Identifier;
            Canonical azzzzzm_ = a?.InstantiatesCanonicalElement;
            FhirUri azzzzzn_ = a?.InstantiatesUriElement;
            List<ResourceReference> azzzzzo_ = a?.BasedOn;
            Identifier azzzzzp_ = a?.GroupIdentifier;
            List<ResourceReference> azzzzzq_ = a?.PartOf;
            Code<Task.TaskStatus> azzzzzr_ = a?.StatusElement;
            CodeableConcept azzzzzs_ = a?.StatusReason;
            CodeableConcept azzzzzt_ = a?.BusinessStatus;
            Code<Task.TaskIntent> azzzzzu_ = a?.IntentElement;
            Code<RequestPriority> azzzzzv_ = a?.PriorityElement;
            CodeableConcept azzzzzw_ = a?.Code;
            FhirString azzzzzx_ = a?.DescriptionElement;
            ResourceReference azzzzzy_ = a?.Focus;
            ResourceReference azzzzzz_ = a?.For;
            ResourceReference bzzzzza_ = a?.Encounter;
            Period bzzzzzb_ = a?.ExecutionPeriod;
            FhirDateTime bzzzzzc_ = a?.AuthoredOnElement;
            FhirDateTime bzzzzzd_ = a?.LastModifiedElement;
            ResourceReference bzzzzze_ = a?.Requester;
            List<CodeableConcept> bzzzzzf_ = a?.PerformerType;
            ResourceReference bzzzzzg_ = a?.Owner;
            ResourceReference bzzzzzh_ = a?.Location;
            CodeableConcept bzzzzzi_ = a?.ReasonCode;
            ResourceReference bzzzzzj_ = a?.ReasonReference;
            List<ResourceReference> bzzzzzk_ = a?.Insurance;
            List<Annotation> bzzzzzl_ = a?.Note;
            List<ResourceReference> bzzzzzm_ = a?.RelevantHistory;
            Task.RestrictionComponent bzzzzzn_ = a?.Restriction;
            List<Task.ParameterComponent> bzzzzzo_ = a?.Input;
            List<Task.OutputComponent> bzzzzzp_ = a?.Output;
            Task bzzzzzq_ = new Task
            {
                Identifier = new List<Identifier>((IEnumerable<Identifier>)azzzzzl_),
                InstantiatesCanonicalElement = azzzzzm_,
                InstantiatesUriElement = azzzzzn_,
                BasedOn = new List<ResourceReference>((IEnumerable<ResourceReference>)azzzzzo_),
                GroupIdentifier = azzzzzp_,
                PartOf = new List<ResourceReference>((IEnumerable<ResourceReference>)azzzzzq_),
                StatusElement = azzzzzr_,
                StatusReason = azzzzzs_,
                BusinessStatus = azzzzzt_,
                IntentElement = azzzzzu_,
                PriorityElement = azzzzzv_,
                Code = azzzzzw_,
                DescriptionElement = azzzzzx_,
                Focus = azzzzzy_,
                For = azzzzzz_,
                Encounter = bzzzzza_,
                ExecutionPeriod = bzzzzzb_,
                AuthoredOnElement = bzzzzzc_,
                LastModifiedElement = bzzzzzd_,
                Requester = bzzzzze_,
                PerformerType = new List<CodeableConcept>((IEnumerable<CodeableConcept>)bzzzzzf_),
                Owner = bzzzzzg_,
                Location = bzzzzzh_,
                ReasonCode = bzzzzzi_,
                ReasonReference = bzzzzzj_,
                Insurance = new List<ResourceReference>((IEnumerable<ResourceReference>)bzzzzzk_),
                Note = new List<Annotation>((IEnumerable<Annotation>)bzzzzzl_),
                RelevantHistory = new List<ResourceReference>((IEnumerable<ResourceReference>)bzzzzzm_),
                Restriction = bzzzzzn_,
                Input = new List<Task.ParameterComponent>((IEnumerable<Task.ParameterComponent>)bzzzzzo_),
                Output = new List<Task.OutputComponent>((IEnumerable<Task.OutputComponent>)bzzzzzp_),
            };

            return bzzzzzq_;
        };
        IEnumerable<Task> azzzzzi_ = context.Operators.Select<Task, Task>((IEnumerable<Task>)azzzzzg_, azzzzzh_);
        IEnumerable<Task> azzzzzj_ = context.Operators.Distinct<Task>(azzzzzi_);
        Task azzzzzk_ = context.Operators.SingletonFrom<Task>(azzzzzj_);

        return azzzzzk_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public TerminologyCapabilities TerminologyCapabilitiesResource(CqlContext context, TerminologyCapabilities arg)
    {
        TerminologyCapabilities[] bzzzzzr_ = [
            arg,
        ];
        TerminologyCapabilities bzzzzzs_(TerminologyCapabilities a)
        {
            FhirUri bzzzzzw_ = a?.UrlElement;
            FhirString bzzzzzx_ = a?.VersionElement;
            FhirString bzzzzzy_ = a?.NameElement;
            FhirString bzzzzzz_ = a?.TitleElement;
            Code<PublicationStatus> czzzzza_ = a?.StatusElement;
            FhirBoolean czzzzzb_ = a?.ExperimentalElement;
            FhirDateTime czzzzzc_ = a?.DateElement;
            FhirString czzzzzd_ = a?.PublisherElement;
            List<ContactDetail> czzzzze_ = a?.Contact;
            Markdown czzzzzf_ = a?.DescriptionElement;
            List<UsageContext> czzzzzg_ = a?.UseContext;
            List<CodeableConcept> czzzzzh_ = a?.Jurisdiction;
            Markdown czzzzzi_ = a?.PurposeElement;
            Markdown czzzzzj_ = a?.CopyrightElement;
            Code<CapabilityStatementKind> czzzzzk_ = a?.KindElement;
            TerminologyCapabilities.SoftwareComponent czzzzzl_ = a?.Software;
            TerminologyCapabilities.ImplementationComponent czzzzzm_ = a?.Implementation;
            FhirBoolean czzzzzn_ = a?.LockedDateElement;
            List<TerminologyCapabilities.CodeSystemComponent> czzzzzo_ = a?.CodeSystem;
            TerminologyCapabilities.ExpansionComponent czzzzzp_ = a?.Expansion;
            Code<TerminologyCapabilities.CodeSearchSupport> czzzzzq_ = a?.CodeSearchElement;
            TerminologyCapabilities.ValidateCodeComponent czzzzzr_ = a?.ValidateCode;
            TerminologyCapabilities.TranslationComponent czzzzzs_ = a?.Translation;
            TerminologyCapabilities.ClosureComponent czzzzzt_ = a?.Closure;
            TerminologyCapabilities czzzzzu_ = new TerminologyCapabilities
            {
                UrlElement = bzzzzzw_,
                VersionElement = bzzzzzx_,
                NameElement = bzzzzzy_,
                TitleElement = bzzzzzz_,
                StatusElement = czzzzza_,
                ExperimentalElement = czzzzzb_,
                DateElement = czzzzzc_,
                PublisherElement = czzzzzd_,
                Contact = new List<ContactDetail>((IEnumerable<ContactDetail>)czzzzze_),
                DescriptionElement = czzzzzf_,
                UseContext = new List<UsageContext>((IEnumerable<UsageContext>)czzzzzg_),
                Jurisdiction = new List<CodeableConcept>((IEnumerable<CodeableConcept>)czzzzzh_),
                PurposeElement = czzzzzi_,
                CopyrightElement = czzzzzj_,
                KindElement = czzzzzk_,
                Software = czzzzzl_,
                Implementation = czzzzzm_,
                LockedDateElement = czzzzzn_,
                CodeSystem = new List<TerminologyCapabilities.CodeSystemComponent>((IEnumerable<TerminologyCapabilities.CodeSystemComponent>)czzzzzo_),
                Expansion = czzzzzp_,
                CodeSearchElement = czzzzzq_,
                ValidateCode = czzzzzr_,
                Translation = czzzzzs_,
                Closure = czzzzzt_,
            };

            return czzzzzu_;
        };
        IEnumerable<TerminologyCapabilities> bzzzzzt_ = context.Operators.Select<TerminologyCapabilities, TerminologyCapabilities>((IEnumerable<TerminologyCapabilities>)bzzzzzr_, bzzzzzs_);
        IEnumerable<TerminologyCapabilities> bzzzzzu_ = context.Operators.Distinct<TerminologyCapabilities>(bzzzzzt_);
        TerminologyCapabilities bzzzzzv_ = context.Operators.SingletonFrom<TerminologyCapabilities>(bzzzzzu_);

        return bzzzzzv_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public TestReport TestReportResource(CqlContext context, TestReport arg)
    {
        TestReport[] czzzzzv_ = [
            arg,
        ];
        TestReport czzzzzw_(TestReport a)
        {
            Identifier dzzzzza_ = a?.Identifier;
            FhirString dzzzzzb_ = a?.NameElement;
            Code<TestReport.TestReportStatus> dzzzzzc_ = a?.StatusElement;
            ResourceReference dzzzzzd_ = a?.TestScript;
            Code<TestReport.TestReportResult> dzzzzze_ = a?.ResultElement;
            FhirDecimal dzzzzzf_ = a?.ScoreElement;
            FhirString dzzzzzg_ = a?.TesterElement;
            FhirDateTime dzzzzzh_ = a?.IssuedElement;
            List<TestReport.ParticipantComponent> dzzzzzi_ = a?.Participant;
            TestReport.SetupComponent dzzzzzj_ = a?.Setup;
            List<TestReport.TestComponent> dzzzzzk_ = a?.Test;
            TestReport.TeardownComponent dzzzzzl_ = a?.Teardown;
            TestReport dzzzzzm_ = new TestReport
            {
                Identifier = dzzzzza_,
                NameElement = dzzzzzb_,
                StatusElement = dzzzzzc_,
                TestScript = dzzzzzd_,
                ResultElement = dzzzzze_,
                ScoreElement = dzzzzzf_,
                TesterElement = dzzzzzg_,
                IssuedElement = dzzzzzh_,
                Participant = new List<TestReport.ParticipantComponent>((IEnumerable<TestReport.ParticipantComponent>)dzzzzzi_),
                Setup = dzzzzzj_,
                Test = new List<TestReport.TestComponent>((IEnumerable<TestReport.TestComponent>)dzzzzzk_),
                Teardown = dzzzzzl_,
            };

            return dzzzzzm_;
        };
        IEnumerable<TestReport> czzzzzx_ = context.Operators.Select<TestReport, TestReport>((IEnumerable<TestReport>)czzzzzv_, czzzzzw_);
        IEnumerable<TestReport> czzzzzy_ = context.Operators.Distinct<TestReport>(czzzzzx_);
        TestReport czzzzzz_ = context.Operators.SingletonFrom<TestReport>(czzzzzy_);

        return czzzzzz_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public TestScript TestScriptResource(CqlContext context, TestScript arg)
    {
        TestScript[] dzzzzzn_ = [
            arg,
        ];
        TestScript dzzzzzo_(TestScript a)
        {
            FhirUri dzzzzzs_ = a?.UrlElement;
            Identifier dzzzzzt_ = a?.Identifier;
            FhirString dzzzzzu_ = a?.VersionElement;
            FhirString dzzzzzv_ = a?.NameElement;
            FhirString dzzzzzw_ = a?.TitleElement;
            Code<PublicationStatus> dzzzzzx_ = a?.StatusElement;
            FhirBoolean dzzzzzy_ = a?.ExperimentalElement;
            FhirDateTime dzzzzzz_ = a?.DateElement;
            FhirString ezzzzza_ = a?.PublisherElement;
            List<ContactDetail> ezzzzzb_ = a?.Contact;
            Markdown ezzzzzc_ = a?.DescriptionElement;
            List<UsageContext> ezzzzzd_ = a?.UseContext;
            List<CodeableConcept> ezzzzze_ = a?.Jurisdiction;
            Markdown ezzzzzf_ = a?.PurposeElement;
            Markdown ezzzzzg_ = a?.CopyrightElement;
            List<TestScript.OriginComponent> ezzzzzh_ = a?.Origin;
            List<TestScript.DestinationComponent> ezzzzzi_ = a?.Destination;
            TestScript.MetadataComponent ezzzzzj_ = a?.Metadata;
            List<TestScript.FixtureComponent> ezzzzzk_ = a?.Fixture;
            List<ResourceReference> ezzzzzl_ = a?.Profile;
            List<TestScript.VariableComponent> ezzzzzm_ = a?.Variable;
            TestScript.SetupComponent ezzzzzn_ = a?.Setup;
            List<TestScript.TestComponent> ezzzzzo_ = a?.Test;
            TestScript.TeardownComponent ezzzzzp_ = a?.Teardown;
            TestScript ezzzzzq_ = new TestScript
            {
                UrlElement = dzzzzzs_,
                Identifier = dzzzzzt_,
                VersionElement = dzzzzzu_,
                NameElement = dzzzzzv_,
                TitleElement = dzzzzzw_,
                StatusElement = dzzzzzx_,
                ExperimentalElement = dzzzzzy_,
                DateElement = dzzzzzz_,
                PublisherElement = ezzzzza_,
                Contact = new List<ContactDetail>((IEnumerable<ContactDetail>)ezzzzzb_),
                DescriptionElement = ezzzzzc_,
                UseContext = new List<UsageContext>((IEnumerable<UsageContext>)ezzzzzd_),
                Jurisdiction = new List<CodeableConcept>((IEnumerable<CodeableConcept>)ezzzzze_),
                PurposeElement = ezzzzzf_,
                CopyrightElement = ezzzzzg_,
                Origin = new List<TestScript.OriginComponent>((IEnumerable<TestScript.OriginComponent>)ezzzzzh_),
                Destination = new List<TestScript.DestinationComponent>((IEnumerable<TestScript.DestinationComponent>)ezzzzzi_),
                Metadata = ezzzzzj_,
                Fixture = new List<TestScript.FixtureComponent>((IEnumerable<TestScript.FixtureComponent>)ezzzzzk_),
                Profile = new List<ResourceReference>((IEnumerable<ResourceReference>)ezzzzzl_),
                Variable = new List<TestScript.VariableComponent>((IEnumerable<TestScript.VariableComponent>)ezzzzzm_),
                Setup = ezzzzzn_,
                Test = new List<TestScript.TestComponent>((IEnumerable<TestScript.TestComponent>)ezzzzzo_),
                Teardown = ezzzzzp_,
            };

            return ezzzzzq_;
        };
        IEnumerable<TestScript> dzzzzzp_ = context.Operators.Select<TestScript, TestScript>((IEnumerable<TestScript>)dzzzzzn_, dzzzzzo_);
        IEnumerable<TestScript> dzzzzzq_ = context.Operators.Distinct<TestScript>(dzzzzzp_);
        TestScript dzzzzzr_ = context.Operators.SingletonFrom<TestScript>(dzzzzzq_);

        return dzzzzzr_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public ValueSet ValueSetResource(CqlContext context, ValueSet arg)
    {
        ValueSet[] ezzzzzr_ = [
            arg,
        ];
        ValueSet ezzzzzs_(ValueSet a)
        {
            FhirUri ezzzzzw_ = a?.UrlElement;
            List<Identifier> ezzzzzx_ = a?.Identifier;
            FhirString ezzzzzy_ = a?.VersionElement;
            FhirString ezzzzzz_ = a?.NameElement;
            FhirString fzzzzza_ = a?.TitleElement;
            Code<PublicationStatus> fzzzzzb_ = a?.StatusElement;
            FhirBoolean fzzzzzc_ = a?.ExperimentalElement;
            FhirDateTime fzzzzzd_ = a?.DateElement;
            FhirString fzzzzze_ = a?.PublisherElement;
            List<ContactDetail> fzzzzzf_ = a?.Contact;
            Markdown fzzzzzg_ = a?.DescriptionElement;
            List<UsageContext> fzzzzzh_ = a?.UseContext;
            List<CodeableConcept> fzzzzzi_ = a?.Jurisdiction;
            FhirBoolean fzzzzzj_ = a?.ImmutableElement;
            Markdown fzzzzzk_ = a?.PurposeElement;
            Markdown fzzzzzl_ = a?.CopyrightElement;
            ValueSet.ComposeComponent fzzzzzm_ = a?.Compose;
            ValueSet.ExpansionComponent fzzzzzn_ = a?.Expansion;
            ValueSet fzzzzzo_ = new ValueSet
            {
                UrlElement = ezzzzzw_,
                Identifier = new List<Identifier>((IEnumerable<Identifier>)ezzzzzx_),
                VersionElement = ezzzzzy_,
                NameElement = ezzzzzz_,
                TitleElement = fzzzzza_,
                StatusElement = fzzzzzb_,
                ExperimentalElement = fzzzzzc_,
                DateElement = fzzzzzd_,
                PublisherElement = fzzzzze_,
                Contact = new List<ContactDetail>((IEnumerable<ContactDetail>)fzzzzzf_),
                DescriptionElement = fzzzzzg_,
                UseContext = new List<UsageContext>((IEnumerable<UsageContext>)fzzzzzh_),
                Jurisdiction = new List<CodeableConcept>((IEnumerable<CodeableConcept>)fzzzzzi_),
                ImmutableElement = fzzzzzj_,
                PurposeElement = fzzzzzk_,
                CopyrightElement = fzzzzzl_,
                Compose = fzzzzzm_,
                Expansion = fzzzzzn_,
            };

            return fzzzzzo_;
        };
        IEnumerable<ValueSet> ezzzzzt_ = context.Operators.Select<ValueSet, ValueSet>((IEnumerable<ValueSet>)ezzzzzr_, ezzzzzs_);
        IEnumerable<ValueSet> ezzzzzu_ = context.Operators.Distinct<ValueSet>(ezzzzzt_);
        ValueSet ezzzzzv_ = context.Operators.SingletonFrom<ValueSet>(ezzzzzu_);

        return ezzzzzv_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public VerificationResult VerificationResultResource(CqlContext context, VerificationResult arg)
    {
        VerificationResult[] fzzzzzp_ = [
            arg,
        ];
        VerificationResult fzzzzzq_(VerificationResult a)
        {
            List<ResourceReference> fzzzzzu_ = a?.Target;
            List<FhirString> fzzzzzv_ = a?.TargetLocationElement;
            CodeableConcept fzzzzzw_ = a?.Need;
            Code<VerificationResult.StatusCode> fzzzzzx_ = a?.StatusElement;
            FhirDateTime fzzzzzy_ = a?.StatusDateElement;
            CodeableConcept fzzzzzz_ = a?.ValidationType;
            List<CodeableConcept> gzzzzza_ = a?.ValidationProcess;
            Timing gzzzzzb_ = a?.Frequency;
            FhirDateTime gzzzzzc_ = a?.LastPerformedElement;
            Date gzzzzzd_ = a?.NextScheduledElement;
            CodeableConcept gzzzzze_ = a?.FailureAction;
            List<VerificationResult.PrimarySourceComponent> gzzzzzf_ = a?.PrimarySource;
            VerificationResult.AttestationComponent gzzzzzg_ = a?.Attestation;
            List<VerificationResult.ValidatorComponent> gzzzzzh_ = a?.Validator;
            VerificationResult gzzzzzi_ = new VerificationResult
            {
                Target = new List<ResourceReference>((IEnumerable<ResourceReference>)fzzzzzu_),
                TargetLocationElement = new List<FhirString>((IEnumerable<FhirString>)fzzzzzv_),
                Need = fzzzzzw_,
                StatusElement = fzzzzzx_,
                StatusDateElement = fzzzzzy_,
                ValidationType = fzzzzzz_,
                ValidationProcess = new List<CodeableConcept>((IEnumerable<CodeableConcept>)gzzzzza_),
                Frequency = gzzzzzb_,
                LastPerformedElement = gzzzzzc_,
                NextScheduledElement = gzzzzzd_,
                FailureAction = gzzzzze_,
                PrimarySource = new List<VerificationResult.PrimarySourceComponent>((IEnumerable<VerificationResult.PrimarySourceComponent>)gzzzzzf_),
                Attestation = gzzzzzg_,
                Validator = new List<VerificationResult.ValidatorComponent>((IEnumerable<VerificationResult.ValidatorComponent>)gzzzzzh_),
            };

            return gzzzzzi_;
        };
        IEnumerable<VerificationResult> fzzzzzr_ = context.Operators.Select<VerificationResult, VerificationResult>((IEnumerable<VerificationResult>)fzzzzzp_, fzzzzzq_);
        IEnumerable<VerificationResult> fzzzzzs_ = context.Operators.Distinct<VerificationResult>(fzzzzzr_);
        VerificationResult fzzzzzt_ = context.Operators.SingletonFrom<VerificationResult>(fzzzzzs_);

        return fzzzzzt_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public VisionPrescription VisionPrescriptionResource(CqlContext context, VisionPrescription arg)
    {
        VisionPrescription[] gzzzzzj_ = [
            arg,
        ];
        VisionPrescription gzzzzzk_(VisionPrescription a)
        {
            List<Identifier> gzzzzzo_ = a?.Identifier;
            Code<FinancialResourceStatusCodes> gzzzzzp_ = a?.StatusElement;
            FhirDateTime gzzzzzq_ = a?.CreatedElement;
            ResourceReference gzzzzzr_ = a?.Patient;
            ResourceReference gzzzzzs_ = a?.Encounter;
            FhirDateTime gzzzzzt_ = a?.DateWrittenElement;
            ResourceReference gzzzzzu_ = a?.Prescriber;
            List<VisionPrescription.LensSpecificationComponent> gzzzzzv_ = a?.LensSpecification;
            VisionPrescription gzzzzzw_ = new VisionPrescription
            {
                Identifier = new List<Identifier>((IEnumerable<Identifier>)gzzzzzo_),
                StatusElement = gzzzzzp_,
                CreatedElement = gzzzzzq_,
                Patient = gzzzzzr_,
                Encounter = gzzzzzs_,
                DateWrittenElement = gzzzzzt_,
                Prescriber = gzzzzzu_,
                LensSpecification = new List<VisionPrescription.LensSpecificationComponent>((IEnumerable<VisionPrescription.LensSpecificationComponent>)gzzzzzv_),
            };

            return gzzzzzw_;
        };
        IEnumerable<VisionPrescription> gzzzzzl_ = context.Operators.Select<VisionPrescription, VisionPrescription>((IEnumerable<VisionPrescription>)gzzzzzj_, gzzzzzk_);
        IEnumerable<VisionPrescription> gzzzzzm_ = context.Operators.Distinct<VisionPrescription>(gzzzzzl_);
        VisionPrescription gzzzzzn_ = context.Operators.SingletonFrom<VisionPrescription>(gzzzzzm_);

        return gzzzzzn_;
    }


    #endregion Expressions

}

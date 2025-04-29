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

    [CqlExpressionDefinition("AccountResource")]
    public Account AccountResource(CqlContext context, Account arg)
    {
        Account[] vh_ = [
            arg,
        ];
        Account vi_(Account a)
        {
            List<Identifier> vm_ = a?.Identifier;
            Code<Account.AccountStatus> vn_ = a?.StatusElement;
            CodeableConcept vo_ = a?.Type;
            FhirString vp_ = a?.NameElement;
            List<ResourceReference> vq_ = a?.Subject;
            Period vr_ = a?.ServicePeriod;
            List<Account.CoverageComponent> vs_ = a?.Coverage;
            ResourceReference vt_ = a?.Owner;
            FhirString vu_ = a?.DescriptionElement;
            List<Account.GuarantorComponent> vv_ = a?.Guarantor;
            ResourceReference vw_ = a?.PartOf;
            Account vx_ = new Account
            {
                Identifier = new List<Identifier>((IEnumerable<Identifier>)vm_),
                StatusElement = vn_,
                Type = vo_,
                NameElement = vp_,
                Subject = new List<ResourceReference>((IEnumerable<ResourceReference>)vq_),
                ServicePeriod = vr_,
                Coverage = new List<Account.CoverageComponent>((IEnumerable<Account.CoverageComponent>)vs_),
                Owner = vt_,
                DescriptionElement = vu_,
                Guarantor = new List<Account.GuarantorComponent>((IEnumerable<Account.GuarantorComponent>)vv_),
                PartOf = vw_,
            };

            return vx_;
        };
        IEnumerable<Account> vj_ = context.Operators.Select<Account, Account>((IEnumerable<Account>)vh_, vi_);
        IEnumerable<Account> vk_ = context.Operators.Distinct<Account>(vj_);
        Account vl_ = context.Operators.SingletonFrom<Account>(vk_);

        return vl_;
    }


    [CqlExpressionDefinition("ActivityDefinitionResource")]
    public ActivityDefinition ActivityDefinitionResource(CqlContext context, ActivityDefinition arg)
    {
        ActivityDefinition[] vy_ = [
            arg,
        ];
        ActivityDefinition vz_(ActivityDefinition a)
        {
            FhirUri wd_ = a?.UrlElement;
            List<Identifier> we_ = a?.Identifier;
            FhirString wf_ = a?.VersionElement;
            FhirString wg_ = a?.NameElement;
            FhirString wh_ = a?.TitleElement;
            FhirString wi_ = a?.SubtitleElement;
            Code<PublicationStatus> wj_ = a?.StatusElement;
            FhirBoolean wk_ = a?.ExperimentalElement;
            DataType wl_ = a?.Subject;
            FhirDateTime wm_ = a?.DateElement;
            FhirString wn_ = a?.PublisherElement;
            List<ContactDetail> wo_ = a?.Contact;
            Markdown wp_ = a?.DescriptionElement;
            List<UsageContext> wq_ = a?.UseContext;
            List<CodeableConcept> wr_ = a?.Jurisdiction;
            Markdown ws_ = a?.PurposeElement;
            FhirString wt_ = a?.UsageElement;
            Markdown wu_ = a?.CopyrightElement;
            Date wv_ = a?.ApprovalDateElement;
            Date ww_ = a?.LastReviewDateElement;
            Period wx_ = a?.EffectivePeriod;
            List<CodeableConcept> wy_ = a?.Topic;
            List<ContactDetail> wz_ = a?.Author;
            List<ContactDetail> xa_ = a?.Editor;
            List<ContactDetail> xb_ = a?.Reviewer;
            List<ContactDetail> xc_ = a?.Endorser;
            List<RelatedArtifact> xd_ = a?.RelatedArtifact;
            List<Canonical> xe_ = a?.LibraryElement;
            Code<ActivityDefinition.RequestResourceType> xf_ = a?.KindElement;
            Canonical xg_ = a?.ProfileElement;
            CodeableConcept xh_ = a?.Code;
            Code<RequestIntent> xi_ = a?.IntentElement;
            Code<RequestPriority> xj_ = a?.PriorityElement;
            FhirBoolean xk_ = a?.DoNotPerformElement;
            DataType xl_ = a?.Timing;
            ResourceReference xm_ = a?.Location;
            List<ActivityDefinition.ParticipantComponent> xn_ = a?.Participant;
            DataType xo_ = a?.Product;
            Quantity xp_ = a?.Quantity;
            List<Dosage> xq_ = a?.Dosage;
            List<CodeableConcept> xr_ = a?.BodySite;
            List<ResourceReference> xs_ = a?.SpecimenRequirement;
            List<ResourceReference> xt_ = a?.ObservationRequirement;
            List<ResourceReference> xu_ = a?.ObservationResultRequirement;
            Canonical xv_ = a?.TransformElement;
            List<ActivityDefinition.DynamicValueComponent> xw_ = a?.DynamicValue;
            ActivityDefinition xx_ = new ActivityDefinition
            {
                UrlElement = wd_,
                Identifier = new List<Identifier>((IEnumerable<Identifier>)we_),
                VersionElement = wf_,
                NameElement = wg_,
                TitleElement = wh_,
                SubtitleElement = wi_,
                StatusElement = wj_,
                ExperimentalElement = wk_,
                Subject = (DataType)wl_,
                DateElement = wm_,
                PublisherElement = wn_,
                Contact = new List<ContactDetail>((IEnumerable<ContactDetail>)wo_),
                DescriptionElement = wp_,
                UseContext = new List<UsageContext>((IEnumerable<UsageContext>)wq_),
                Jurisdiction = new List<CodeableConcept>((IEnumerable<CodeableConcept>)wr_),
                PurposeElement = ws_,
                UsageElement = wt_,
                CopyrightElement = wu_,
                ApprovalDateElement = wv_,
                LastReviewDateElement = ww_,
                EffectivePeriod = wx_,
                Topic = new List<CodeableConcept>((IEnumerable<CodeableConcept>)wy_),
                Author = new List<ContactDetail>((IEnumerable<ContactDetail>)wz_),
                Editor = new List<ContactDetail>((IEnumerable<ContactDetail>)xa_),
                Reviewer = new List<ContactDetail>((IEnumerable<ContactDetail>)xb_),
                Endorser = new List<ContactDetail>((IEnumerable<ContactDetail>)xc_),
                RelatedArtifact = new List<RelatedArtifact>((IEnumerable<RelatedArtifact>)xd_),
                LibraryElement = new List<Canonical>((IEnumerable<Canonical>)xe_),
                KindElement = xf_,
                ProfileElement = xg_,
                Code = xh_,
                IntentElement = xi_,
                PriorityElement = xj_,
                DoNotPerformElement = xk_,
                Timing = (DataType)xl_,
                Location = xm_,
                Participant = new List<ActivityDefinition.ParticipantComponent>((IEnumerable<ActivityDefinition.ParticipantComponent>)xn_),
                Product = (DataType)xo_,
                Quantity = xp_,
                Dosage = new List<Dosage>((IEnumerable<Dosage>)xq_),
                BodySite = new List<CodeableConcept>((IEnumerable<CodeableConcept>)xr_),
                SpecimenRequirement = new List<ResourceReference>((IEnumerable<ResourceReference>)xs_),
                ObservationRequirement = new List<ResourceReference>((IEnumerable<ResourceReference>)xt_),
                ObservationResultRequirement = new List<ResourceReference>((IEnumerable<ResourceReference>)xu_),
                TransformElement = xv_,
                DynamicValue = new List<ActivityDefinition.DynamicValueComponent>((IEnumerable<ActivityDefinition.DynamicValueComponent>)xw_),
            };

            return xx_;
        };
        IEnumerable<ActivityDefinition> wa_ = context.Operators.Select<ActivityDefinition, ActivityDefinition>((IEnumerable<ActivityDefinition>)vy_, vz_);
        IEnumerable<ActivityDefinition> wb_ = context.Operators.Distinct<ActivityDefinition>(wa_);
        ActivityDefinition wc_ = context.Operators.SingletonFrom<ActivityDefinition>(wb_);

        return wc_;
    }


    [CqlExpressionDefinition("AdverseEventResource")]
    public AdverseEvent AdverseEventResource(CqlContext context, AdverseEvent arg)
    {
        AdverseEvent[] xy_ = [
            arg,
        ];
        AdverseEvent xz_(AdverseEvent a)
        {
            Identifier yd_ = a?.Identifier;
            Code<AdverseEvent.AdverseEventActuality> ye_ = a?.ActualityElement;
            List<CodeableConcept> yf_ = a?.Category;
            CodeableConcept yg_ = a?.Event;
            ResourceReference yh_ = a?.Subject;
            ResourceReference yi_ = a?.Encounter;
            FhirDateTime yj_ = a?.DateElement;
            FhirDateTime yk_ = a?.DetectedElement;
            FhirDateTime yl_ = a?.RecordedDateElement;
            List<ResourceReference> ym_ = a?.ResultingCondition;
            ResourceReference yn_ = a?.Location;
            CodeableConcept yo_ = a?.Seriousness;
            CodeableConcept yp_ = a?.Severity;
            CodeableConcept yq_ = a?.Outcome;
            ResourceReference yr_ = a?.Recorder;
            List<ResourceReference> ys_ = a?.Contributor;
            List<AdverseEvent.SuspectEntityComponent> yt_ = a?.SuspectEntity;
            List<ResourceReference> yu_ = a?.SubjectMedicalHistory;
            List<ResourceReference> yv_ = a?.ReferenceDocument;
            List<ResourceReference> yw_ = a?.Study;
            AdverseEvent yx_ = new AdverseEvent
            {
                Identifier = yd_,
                ActualityElement = ye_,
                Category = new List<CodeableConcept>((IEnumerable<CodeableConcept>)yf_),
                Event = yg_,
                Subject = yh_,
                Encounter = yi_,
                DateElement = yj_,
                DetectedElement = yk_,
                RecordedDateElement = yl_,
                ResultingCondition = new List<ResourceReference>((IEnumerable<ResourceReference>)ym_),
                Location = yn_,
                Seriousness = yo_,
                Severity = yp_,
                Outcome = yq_,
                Recorder = yr_,
                Contributor = new List<ResourceReference>((IEnumerable<ResourceReference>)ys_),
                SuspectEntity = new List<AdverseEvent.SuspectEntityComponent>((IEnumerable<AdverseEvent.SuspectEntityComponent>)yt_),
                SubjectMedicalHistory = new List<ResourceReference>((IEnumerable<ResourceReference>)yu_),
                ReferenceDocument = new List<ResourceReference>((IEnumerable<ResourceReference>)yv_),
                Study = new List<ResourceReference>((IEnumerable<ResourceReference>)yw_),
            };

            return yx_;
        };
        IEnumerable<AdverseEvent> ya_ = context.Operators.Select<AdverseEvent, AdverseEvent>((IEnumerable<AdverseEvent>)xy_, xz_);
        IEnumerable<AdverseEvent> yb_ = context.Operators.Distinct<AdverseEvent>(ya_);
        AdverseEvent yc_ = context.Operators.SingletonFrom<AdverseEvent>(yb_);

        return yc_;
    }


    [CqlExpressionDefinition("AllergyIntoleranceResource")]
    public AllergyIntolerance AllergyIntoleranceResource(CqlContext context, AllergyIntolerance arg)
    {
        AllergyIntolerance[] yy_ = [
            arg,
        ];
        AllergyIntolerance yz_(AllergyIntolerance a)
        {
            List<Identifier> zd_ = a?.Identifier;
            CodeableConcept ze_ = a?.ClinicalStatus;
            CodeableConcept zf_ = a?.VerificationStatus;
            Code<AllergyIntolerance.AllergyIntoleranceType> zg_ = a?.TypeElement;
            List<Code<AllergyIntolerance.AllergyIntoleranceCategory>> zh_ = a?.CategoryElement;
            Code<AllergyIntolerance.AllergyIntoleranceCriticality> zi_ = a?.CriticalityElement;
            CodeableConcept zj_ = a?.Code;
            ResourceReference zk_ = a?.Patient;
            ResourceReference zl_ = a?.Encounter;
            DataType zm_ = a?.Onset;
            FhirDateTime zn_ = a?.RecordedDateElement;
            ResourceReference zo_ = a?.Recorder;
            ResourceReference zp_ = a?.Asserter;
            FhirDateTime zq_ = a?.LastOccurrenceElement;
            List<Annotation> zr_ = a?.Note;
            List<AllergyIntolerance.ReactionComponent> zs_ = a?.Reaction;
            AllergyIntolerance zt_ = new AllergyIntolerance
            {
                Identifier = new List<Identifier>((IEnumerable<Identifier>)zd_),
                ClinicalStatus = ze_,
                VerificationStatus = zf_,
                TypeElement = zg_,
                CategoryElement = new List<Code<AllergyIntolerance.AllergyIntoleranceCategory>>((IEnumerable<Code<AllergyIntolerance.AllergyIntoleranceCategory>>)zh_),
                CriticalityElement = zi_,
                Code = zj_,
                Patient = zk_,
                Encounter = zl_,
                Onset = (DataType)zm_,
                RecordedDateElement = zn_,
                Recorder = zo_,
                Asserter = zp_,
                LastOccurrenceElement = zq_,
                Note = new List<Annotation>((IEnumerable<Annotation>)zr_),
                Reaction = new List<AllergyIntolerance.ReactionComponent>((IEnumerable<AllergyIntolerance.ReactionComponent>)zs_),
            };

            return zt_;
        };
        IEnumerable<AllergyIntolerance> za_ = context.Operators.Select<AllergyIntolerance, AllergyIntolerance>((IEnumerable<AllergyIntolerance>)yy_, yz_);
        IEnumerable<AllergyIntolerance> zb_ = context.Operators.Distinct<AllergyIntolerance>(za_);
        AllergyIntolerance zc_ = context.Operators.SingletonFrom<AllergyIntolerance>(zb_);

        return zc_;
    }


    [CqlExpressionDefinition("AppointmentResource")]
    public Appointment AppointmentResource(CqlContext context, Appointment arg)
    {
        Appointment[] zu_ = [
            arg,
        ];
        Appointment zv_(Appointment a)
        {
            List<Identifier> zz_ = a?.Identifier;
            Code<Appointment.AppointmentStatus> aza_ = a?.StatusElement;
            CodeableConcept azb_ = a?.CancelationReason;
            List<CodeableConcept> azc_ = a?.ServiceCategory;
            List<CodeableConcept> azd_ = a?.ServiceType;
            List<CodeableConcept> aze_ = a?.Specialty;
            CodeableConcept azf_ = a?.AppointmentType;
            List<CodeableConcept> azg_ = a?.ReasonCode;
            List<ResourceReference> azh_ = a?.ReasonReference;
            UnsignedInt azi_ = a?.PriorityElement;
            Integer azj_ = context.Operators.Convert<Integer>(azi_);
            UnsignedInt azk_ = context.Operators.Convert<UnsignedInt>(azj_);
            FhirString azl_ = a?.DescriptionElement;
            List<ResourceReference> azm_ = a?.SupportingInformation;
            Instant azn_ = a?.StartElement;
            Instant azo_ = a?.EndElement;
            PositiveInt azp_ = a?.MinutesDurationElement;
            Integer azq_ = context.Operators.Convert<Integer>(azp_);
            PositiveInt azr_ = context.Operators.Convert<PositiveInt>(azq_);
            List<ResourceReference> azs_ = a?.Slot;
            FhirDateTime azt_ = a?.CreatedElement;
            FhirString azu_ = a?.CommentElement;
            FhirString azv_ = a?.PatientInstructionElement;
            List<ResourceReference> azw_ = a?.BasedOn;
            List<Appointment.ParticipantComponent> azx_ = a?.Participant;
            List<Period> azy_ = a?.RequestedPeriod;
            Appointment azz_ = new Appointment
            {
                Identifier = new List<Identifier>((IEnumerable<Identifier>)zz_),
                StatusElement = aza_,
                CancelationReason = azb_,
                ServiceCategory = new List<CodeableConcept>((IEnumerable<CodeableConcept>)azc_),
                ServiceType = new List<CodeableConcept>((IEnumerable<CodeableConcept>)azd_),
                Specialty = new List<CodeableConcept>((IEnumerable<CodeableConcept>)aze_),
                AppointmentType = azf_,
                ReasonCode = new List<CodeableConcept>((IEnumerable<CodeableConcept>)azg_),
                ReasonReference = new List<ResourceReference>((IEnumerable<ResourceReference>)azh_),
                PriorityElement = azk_,
                DescriptionElement = azl_,
                SupportingInformation = new List<ResourceReference>((IEnumerable<ResourceReference>)azm_),
                StartElement = azn_,
                EndElement = azo_,
                MinutesDurationElement = azr_,
                Slot = new List<ResourceReference>((IEnumerable<ResourceReference>)azs_),
                CreatedElement = azt_,
                CommentElement = azu_,
                PatientInstructionElement = azv_,
                BasedOn = new List<ResourceReference>((IEnumerable<ResourceReference>)azw_),
                Participant = new List<Appointment.ParticipantComponent>((IEnumerable<Appointment.ParticipantComponent>)azx_),
                RequestedPeriod = new List<Period>((IEnumerable<Period>)azy_),
            };

            return azz_;
        };
        IEnumerable<Appointment> zw_ = context.Operators.Select<Appointment, Appointment>((IEnumerable<Appointment>)zu_, zv_);
        IEnumerable<Appointment> zx_ = context.Operators.Distinct<Appointment>(zw_);
        Appointment zy_ = context.Operators.SingletonFrom<Appointment>(zx_);

        return zy_;
    }


    [CqlExpressionDefinition("AppointmentResponseResource")]
    public AppointmentResponse AppointmentResponseResource(CqlContext context, AppointmentResponse arg)
    {
        AppointmentResponse[] bza_ = [
            arg,
        ];
        AppointmentResponse bzb_(AppointmentResponse a)
        {
            List<Identifier> bzf_ = a?.Identifier;
            ResourceReference bzg_ = a?.Appointment;
            Instant bzh_ = a?.StartElement;
            Instant bzi_ = a?.EndElement;
            List<CodeableConcept> bzj_ = a?.ParticipantType;
            ResourceReference bzk_ = a?.Actor;
            Code<ParticipationStatus> bzl_ = a?.ParticipantStatusElement;
            FhirString bzm_ = a?.CommentElement;
            AppointmentResponse bzn_ = new AppointmentResponse
            {
                Identifier = new List<Identifier>((IEnumerable<Identifier>)bzf_),
                Appointment = bzg_,
                StartElement = bzh_,
                EndElement = bzi_,
                ParticipantType = new List<CodeableConcept>((IEnumerable<CodeableConcept>)bzj_),
                Actor = bzk_,
                ParticipantStatusElement = bzl_,
                CommentElement = bzm_,
            };

            return bzn_;
        };
        IEnumerable<AppointmentResponse> bzc_ = context.Operators.Select<AppointmentResponse, AppointmentResponse>((IEnumerable<AppointmentResponse>)bza_, bzb_);
        IEnumerable<AppointmentResponse> bzd_ = context.Operators.Distinct<AppointmentResponse>(bzc_);
        AppointmentResponse bze_ = context.Operators.SingletonFrom<AppointmentResponse>(bzd_);

        return bze_;
    }


    [CqlExpressionDefinition("AuditEventResource")]
    public AuditEvent AuditEventResource(CqlContext context, AuditEvent arg)
    {
        AuditEvent[] bzo_ = [
            arg,
        ];
        AuditEvent bzp_(AuditEvent a)
        {
            Coding bzt_ = a?.Type;
            List<Coding> bzu_ = a?.Subtype;
            Code<AuditEvent.AuditEventAction> bzv_ = a?.ActionElement;
            Period bzw_ = a?.Period;
            Instant bzx_ = a?.RecordedElement;
            Code<AuditEvent.AuditEventOutcome> bzy_ = a?.OutcomeElement;
            FhirString bzz_ = a?.OutcomeDescElement;
            List<CodeableConcept> cza_ = a?.PurposeOfEvent;
            List<AuditEvent.AgentComponent> czb_ = a?.Agent;
            AuditEvent.SourceComponent czc_ = a?.Source;
            List<AuditEvent.EntityComponent> czd_ = a?.Entity;
            AuditEvent cze_ = new AuditEvent
            {
                Type = bzt_,
                Subtype = new List<Coding>((IEnumerable<Coding>)bzu_),
                ActionElement = bzv_,
                Period = bzw_,
                RecordedElement = bzx_,
                OutcomeElement = bzy_,
                OutcomeDescElement = bzz_,
                PurposeOfEvent = new List<CodeableConcept>((IEnumerable<CodeableConcept>)cza_),
                Agent = new List<AuditEvent.AgentComponent>((IEnumerable<AuditEvent.AgentComponent>)czb_),
                Source = czc_,
                Entity = new List<AuditEvent.EntityComponent>((IEnumerable<AuditEvent.EntityComponent>)czd_),
            };

            return cze_;
        };
        IEnumerable<AuditEvent> bzq_ = context.Operators.Select<AuditEvent, AuditEvent>((IEnumerable<AuditEvent>)bzo_, bzp_);
        IEnumerable<AuditEvent> bzr_ = context.Operators.Distinct<AuditEvent>(bzq_);
        AuditEvent bzs_ = context.Operators.SingletonFrom<AuditEvent>(bzr_);

        return bzs_;
    }


    [CqlExpressionDefinition("BasicResource")]
    public Basic BasicResource(CqlContext context, Basic arg)
    {
        Basic[] czf_ = [
            arg,
        ];
        Basic czg_(Basic a)
        {
            List<Identifier> czk_ = a?.Identifier;
            CodeableConcept czl_ = a?.Code;
            ResourceReference czm_ = a?.Subject;
            Date czn_ = a?.CreatedElement;
            ResourceReference czo_ = a?.Author;
            Basic czp_ = new Basic
            {
                Identifier = new List<Identifier>((IEnumerable<Identifier>)czk_),
                Code = czl_,
                Subject = czm_,
                CreatedElement = czn_,
                Author = czo_,
            };

            return czp_;
        };
        IEnumerable<Basic> czh_ = context.Operators.Select<Basic, Basic>((IEnumerable<Basic>)czf_, czg_);
        IEnumerable<Basic> czi_ = context.Operators.Distinct<Basic>(czh_);
        Basic czj_ = context.Operators.SingletonFrom<Basic>(czi_);

        return czj_;
    }


    [CqlExpressionDefinition("BiologicallyDerivedProductResource")]
    public BiologicallyDerivedProduct BiologicallyDerivedProductResource(CqlContext context, BiologicallyDerivedProduct arg)
    {
        BiologicallyDerivedProduct[] czq_ = [
            arg,
        ];
        BiologicallyDerivedProduct czr_(BiologicallyDerivedProduct a)
        {
            List<Identifier> czv_ = a?.Identifier;
            Code<BiologicallyDerivedProduct.BiologicallyDerivedProductCategory> czw_ = a?.ProductCategoryElement;
            CodeableConcept czx_ = a?.ProductCode;
            Code<BiologicallyDerivedProduct.BiologicallyDerivedProductStatus> czy_ = a?.StatusElement;
            List<ResourceReference> czz_ = a?.Request;
            Integer dza_ = a?.QuantityElement;
            List<ResourceReference> dzb_ = a?.Parent;
            BiologicallyDerivedProduct.CollectionComponent dzc_ = a?.Collection;
            List<BiologicallyDerivedProduct.ProcessingComponent> dzd_ = a?.Processing;
            BiologicallyDerivedProduct.ManipulationComponent dze_ = a?.Manipulation;
            List<BiologicallyDerivedProduct.StorageComponent> dzf_ = a?.Storage;
            BiologicallyDerivedProduct dzg_ = new BiologicallyDerivedProduct
            {
                Identifier = new List<Identifier>((IEnumerable<Identifier>)czv_),
                ProductCategoryElement = czw_,
                ProductCode = czx_,
                StatusElement = czy_,
                Request = new List<ResourceReference>((IEnumerable<ResourceReference>)czz_),
                QuantityElement = dza_,
                Parent = new List<ResourceReference>((IEnumerable<ResourceReference>)dzb_),
                Collection = dzc_,
                Processing = new List<BiologicallyDerivedProduct.ProcessingComponent>((IEnumerable<BiologicallyDerivedProduct.ProcessingComponent>)dzd_),
                Manipulation = dze_,
                Storage = new List<BiologicallyDerivedProduct.StorageComponent>((IEnumerable<BiologicallyDerivedProduct.StorageComponent>)dzf_),
            };

            return dzg_;
        };
        IEnumerable<BiologicallyDerivedProduct> czs_ = context.Operators.Select<BiologicallyDerivedProduct, BiologicallyDerivedProduct>((IEnumerable<BiologicallyDerivedProduct>)czq_, czr_);
        IEnumerable<BiologicallyDerivedProduct> czt_ = context.Operators.Distinct<BiologicallyDerivedProduct>(czs_);
        BiologicallyDerivedProduct czu_ = context.Operators.SingletonFrom<BiologicallyDerivedProduct>(czt_);

        return czu_;
    }


    [CqlExpressionDefinition("BodyStructureResource")]
    public BodyStructure BodyStructureResource(CqlContext context, BodyStructure arg)
    {
        BodyStructure[] dzh_ = [
            arg,
        ];
        BodyStructure dzi_(BodyStructure a)
        {
            List<Identifier> dzm_ = a?.Identifier;
            FhirBoolean dzn_ = a?.ActiveElement;
            CodeableConcept dzo_ = a?.Morphology;
            CodeableConcept dzp_ = a?.Location;
            List<CodeableConcept> dzq_ = a?.LocationQualifier;
            FhirString dzr_ = a?.DescriptionElement;
            List<Attachment> dzs_ = a?.Image;
            ResourceReference dzt_ = a?.Patient;
            BodyStructure dzu_ = new BodyStructure
            {
                Identifier = new List<Identifier>((IEnumerable<Identifier>)dzm_),
                ActiveElement = dzn_,
                Morphology = dzo_,
                Location = dzp_,
                LocationQualifier = new List<CodeableConcept>((IEnumerable<CodeableConcept>)dzq_),
                DescriptionElement = dzr_,
                Image = new List<Attachment>((IEnumerable<Attachment>)dzs_),
                Patient = dzt_,
            };

            return dzu_;
        };
        IEnumerable<BodyStructure> dzj_ = context.Operators.Select<BodyStructure, BodyStructure>((IEnumerable<BodyStructure>)dzh_, dzi_);
        IEnumerable<BodyStructure> dzk_ = context.Operators.Distinct<BodyStructure>(dzj_);
        BodyStructure dzl_ = context.Operators.SingletonFrom<BodyStructure>(dzk_);

        return dzl_;
    }


    [CqlExpressionDefinition("CarePlanResource")]
    public CarePlan CarePlanResource(CqlContext context, CarePlan arg)
    {
        CarePlan[] dzv_ = [
            arg,
        ];
        CarePlan dzw_(CarePlan a)
        {
            List<Identifier> eza_ = a?.Identifier;
            List<Canonical> ezb_ = a?.InstantiatesCanonicalElement;
            List<FhirUri> ezc_ = a?.InstantiatesUriElement;
            List<ResourceReference> ezd_ = a?.BasedOn;
            List<ResourceReference> eze_ = a?.Replaces;
            List<ResourceReference> ezf_ = a?.PartOf;
            Code<RequestStatus> ezg_ = a?.StatusElement;
            Code<CarePlan.CarePlanIntent> ezh_ = a?.IntentElement;
            List<CodeableConcept> ezi_ = a?.Category;
            FhirString ezj_ = a?.TitleElement;
            FhirString ezk_ = a?.DescriptionElement;
            ResourceReference ezl_ = a?.Subject;
            ResourceReference ezm_ = a?.Encounter;
            Period ezn_ = a?.Period;
            FhirDateTime ezo_ = a?.CreatedElement;
            ResourceReference ezp_ = a?.Author;
            List<ResourceReference> ezq_ = a?.Contributor;
            List<ResourceReference> ezr_ = a?.CareTeam;
            List<ResourceReference> ezs_ = a?.Addresses;
            List<ResourceReference> ezt_ = a?.SupportingInfo;
            List<ResourceReference> ezu_ = a?.Goal;
            List<CarePlan.ActivityComponent> ezv_ = a?.Activity;
            List<Annotation> ezw_ = a?.Note;
            CarePlan ezx_ = new CarePlan
            {
                Identifier = new List<Identifier>((IEnumerable<Identifier>)eza_),
                InstantiatesCanonicalElement = new List<Canonical>((IEnumerable<Canonical>)ezb_),
                InstantiatesUriElement = new List<FhirUri>((IEnumerable<FhirUri>)ezc_),
                BasedOn = new List<ResourceReference>((IEnumerable<ResourceReference>)ezd_),
                Replaces = new List<ResourceReference>((IEnumerable<ResourceReference>)eze_),
                PartOf = new List<ResourceReference>((IEnumerable<ResourceReference>)ezf_),
                StatusElement = ezg_,
                IntentElement = ezh_,
                Category = new List<CodeableConcept>((IEnumerable<CodeableConcept>)ezi_),
                TitleElement = ezj_,
                DescriptionElement = ezk_,
                Subject = ezl_,
                Encounter = ezm_,
                Period = ezn_,
                CreatedElement = ezo_,
                Author = ezp_,
                Contributor = new List<ResourceReference>((IEnumerable<ResourceReference>)ezq_),
                CareTeam = new List<ResourceReference>((IEnumerable<ResourceReference>)ezr_),
                Addresses = new List<ResourceReference>((IEnumerable<ResourceReference>)ezs_),
                SupportingInfo = new List<ResourceReference>((IEnumerable<ResourceReference>)ezt_),
                Goal = new List<ResourceReference>((IEnumerable<ResourceReference>)ezu_),
                Activity = new List<CarePlan.ActivityComponent>((IEnumerable<CarePlan.ActivityComponent>)ezv_),
                Note = new List<Annotation>((IEnumerable<Annotation>)ezw_),
            };

            return ezx_;
        };
        IEnumerable<CarePlan> dzx_ = context.Operators.Select<CarePlan, CarePlan>((IEnumerable<CarePlan>)dzv_, dzw_);
        IEnumerable<CarePlan> dzy_ = context.Operators.Distinct<CarePlan>(dzx_);
        CarePlan dzz_ = context.Operators.SingletonFrom<CarePlan>(dzy_);

        return dzz_;
    }


    [CqlExpressionDefinition("CareTeamResource")]
    public CareTeam CareTeamResource(CqlContext context, CareTeam arg)
    {
        CareTeam[] ezy_ = [
            arg,
        ];
        CareTeam ezz_(CareTeam a)
        {
            List<Identifier> fzd_ = a?.Identifier;
            Code<CareTeam.CareTeamStatus> fze_ = a?.StatusElement;
            List<CodeableConcept> fzf_ = a?.Category;
            FhirString fzg_ = a?.NameElement;
            ResourceReference fzh_ = a?.Subject;
            ResourceReference fzi_ = a?.Encounter;
            Period fzj_ = a?.Period;
            List<CareTeam.ParticipantComponent> fzk_ = a?.Participant;
            List<CodeableConcept> fzl_ = a?.ReasonCode;
            List<ResourceReference> fzm_ = a?.ReasonReference;
            List<ResourceReference> fzn_ = a?.ManagingOrganization;
            List<ContactPoint> fzo_ = a?.Telecom;
            List<Annotation> fzp_ = a?.Note;
            CareTeam fzq_ = new CareTeam
            {
                Identifier = new List<Identifier>((IEnumerable<Identifier>)fzd_),
                StatusElement = fze_,
                Category = new List<CodeableConcept>((IEnumerable<CodeableConcept>)fzf_),
                NameElement = fzg_,
                Subject = fzh_,
                Encounter = fzi_,
                Period = fzj_,
                Participant = new List<CareTeam.ParticipantComponent>((IEnumerable<CareTeam.ParticipantComponent>)fzk_),
                ReasonCode = new List<CodeableConcept>((IEnumerable<CodeableConcept>)fzl_),
                ReasonReference = new List<ResourceReference>((IEnumerable<ResourceReference>)fzm_),
                ManagingOrganization = new List<ResourceReference>((IEnumerable<ResourceReference>)fzn_),
                Telecom = new List<ContactPoint>((IEnumerable<ContactPoint>)fzo_),
                Note = new List<Annotation>((IEnumerable<Annotation>)fzp_),
            };

            return fzq_;
        };
        IEnumerable<CareTeam> fza_ = context.Operators.Select<CareTeam, CareTeam>((IEnumerable<CareTeam>)ezy_, ezz_);
        IEnumerable<CareTeam> fzb_ = context.Operators.Distinct<CareTeam>(fza_);
        CareTeam fzc_ = context.Operators.SingletonFrom<CareTeam>(fzb_);

        return fzc_;
    }


    [CqlExpressionDefinition("CatalogEntryResource")]
    public CatalogEntry CatalogEntryResource(CqlContext context, CatalogEntry arg)
    {
        CatalogEntry[] fzr_ = [
            arg,
        ];
        CatalogEntry fzs_(CatalogEntry a)
        {
            List<Identifier> fzw_ = a?.Identifier;
            CodeableConcept fzx_ = a?.Type;
            FhirBoolean fzy_ = a?.OrderableElement;
            ResourceReference fzz_ = a?.ReferencedItem;
            List<Identifier> gza_ = a?.AdditionalIdentifier;
            List<CodeableConcept> gzb_ = a?.Classification;
            Code<PublicationStatus> gzc_ = a?.StatusElement;
            Period gzd_ = a?.ValidityPeriod;
            FhirDateTime gze_ = a?.ValidToElement;
            FhirDateTime gzf_ = a?.LastUpdatedElement;
            List<CodeableConcept> gzg_ = a?.AdditionalCharacteristic;
            List<CodeableConcept> gzh_ = a?.AdditionalClassification;
            List<CatalogEntry.RelatedEntryComponent> gzi_ = a?.RelatedEntry;
            CatalogEntry gzj_ = new CatalogEntry
            {
                Identifier = new List<Identifier>((IEnumerable<Identifier>)fzw_),
                Type = fzx_,
                OrderableElement = fzy_,
                ReferencedItem = fzz_,
                AdditionalIdentifier = new List<Identifier>((IEnumerable<Identifier>)gza_),
                Classification = new List<CodeableConcept>((IEnumerable<CodeableConcept>)gzb_),
                StatusElement = gzc_,
                ValidityPeriod = gzd_,
                ValidToElement = gze_,
                LastUpdatedElement = gzf_,
                AdditionalCharacteristic = new List<CodeableConcept>((IEnumerable<CodeableConcept>)gzg_),
                AdditionalClassification = new List<CodeableConcept>((IEnumerable<CodeableConcept>)gzh_),
                RelatedEntry = new List<CatalogEntry.RelatedEntryComponent>((IEnumerable<CatalogEntry.RelatedEntryComponent>)gzi_),
            };

            return gzj_;
        };
        IEnumerable<CatalogEntry> fzt_ = context.Operators.Select<CatalogEntry, CatalogEntry>((IEnumerable<CatalogEntry>)fzr_, fzs_);
        IEnumerable<CatalogEntry> fzu_ = context.Operators.Distinct<CatalogEntry>(fzt_);
        CatalogEntry fzv_ = context.Operators.SingletonFrom<CatalogEntry>(fzu_);

        return fzv_;
    }


    [CqlExpressionDefinition("ChargeItemResource")]
    public ChargeItem ChargeItemResource(CqlContext context, ChargeItem arg)
    {
        ChargeItem[] gzk_ = [
            arg,
        ];
        ChargeItem gzl_(ChargeItem a)
        {
            List<Identifier> gzp_ = a?.Identifier;
            List<FhirUri> gzq_ = a?.DefinitionUriElement;
            List<Canonical> gzr_ = a?.DefinitionCanonicalElement;
            Code<ChargeItem.ChargeItemStatus> gzs_ = a?.StatusElement;
            List<ResourceReference> gzt_ = a?.PartOf;
            CodeableConcept gzu_ = a?.Code;
            ResourceReference gzv_ = a?.Subject;
            ResourceReference gzw_ = a?.Context;
            DataType gzx_ = a?.Occurrence;
            List<ChargeItem.PerformerComponent> gzy_ = a?.Performer;
            ResourceReference gzz_ = a?.PerformingOrganization;
            ResourceReference hza_ = a?.RequestingOrganization;
            ResourceReference hzb_ = a?.CostCenter;
            Quantity hzc_ = a?.Quantity;
            List<CodeableConcept> hzd_ = a?.Bodysite;
            FhirDecimal hze_ = a?.FactorOverrideElement;
            Money hzf_ = a?.PriceOverride;
            FhirString hzg_ = a?.OverrideReasonElement;
            ResourceReference hzh_ = a?.Enterer;
            FhirDateTime hzi_ = a?.EnteredDateElement;
            List<CodeableConcept> hzj_ = a?.Reason;
            List<ResourceReference> hzk_ = a?.Service;
            DataType hzl_ = a?.Product;
            List<ResourceReference> hzm_ = a?.Account;
            List<Annotation> hzn_ = a?.Note;
            List<ResourceReference> hzo_ = a?.SupportingInformation;
            ChargeItem hzp_ = new ChargeItem
            {
                Identifier = new List<Identifier>((IEnumerable<Identifier>)gzp_),
                DefinitionUriElement = new List<FhirUri>((IEnumerable<FhirUri>)gzq_),
                DefinitionCanonicalElement = new List<Canonical>((IEnumerable<Canonical>)gzr_),
                StatusElement = gzs_,
                PartOf = new List<ResourceReference>((IEnumerable<ResourceReference>)gzt_),
                Code = gzu_,
                Subject = gzv_,
                Context = gzw_,
                Occurrence = (DataType)gzx_,
                Performer = new List<ChargeItem.PerformerComponent>((IEnumerable<ChargeItem.PerformerComponent>)gzy_),
                PerformingOrganization = gzz_,
                RequestingOrganization = hza_,
                CostCenter = hzb_,
                Quantity = hzc_,
                Bodysite = new List<CodeableConcept>((IEnumerable<CodeableConcept>)hzd_),
                FactorOverrideElement = hze_,
                PriceOverride = hzf_,
                OverrideReasonElement = hzg_,
                Enterer = hzh_,
                EnteredDateElement = hzi_,
                Reason = new List<CodeableConcept>((IEnumerable<CodeableConcept>)hzj_),
                Service = new List<ResourceReference>((IEnumerable<ResourceReference>)hzk_),
                Product = (DataType)hzl_,
                Account = new List<ResourceReference>((IEnumerable<ResourceReference>)hzm_),
                Note = new List<Annotation>((IEnumerable<Annotation>)hzn_),
                SupportingInformation = new List<ResourceReference>((IEnumerable<ResourceReference>)hzo_),
            };

            return hzp_;
        };
        IEnumerable<ChargeItem> gzm_ = context.Operators.Select<ChargeItem, ChargeItem>((IEnumerable<ChargeItem>)gzk_, gzl_);
        IEnumerable<ChargeItem> gzn_ = context.Operators.Distinct<ChargeItem>(gzm_);
        ChargeItem gzo_ = context.Operators.SingletonFrom<ChargeItem>(gzn_);

        return gzo_;
    }


    [CqlExpressionDefinition("ChargeItemDefinitionResource")]
    public ChargeItemDefinition ChargeItemDefinitionResource(CqlContext context, ChargeItemDefinition arg)
    {
        ChargeItemDefinition[] hzq_ = [
            arg,
        ];
        ChargeItemDefinition hzr_(ChargeItemDefinition a)
        {
            FhirUri hzv_ = a?.UrlElement;
            List<Identifier> hzw_ = a?.Identifier;
            FhirString hzx_ = a?.VersionElement;
            FhirString hzy_ = a?.TitleElement;
            List<FhirUri> hzz_ = a?.DerivedFromUriElement;
            List<Canonical> iza_ = a?.PartOfElement;
            List<Canonical> izb_ = a?.ReplacesElement;
            Code<PublicationStatus> izc_ = a?.StatusElement;
            FhirBoolean izd_ = a?.ExperimentalElement;
            FhirDateTime ize_ = a?.DateElement;
            FhirString izf_ = a?.PublisherElement;
            List<ContactDetail> izg_ = a?.Contact;
            Markdown izh_ = a?.DescriptionElement;
            List<UsageContext> izi_ = a?.UseContext;
            List<CodeableConcept> izj_ = a?.Jurisdiction;
            Markdown izk_ = a?.CopyrightElement;
            Date izl_ = a?.ApprovalDateElement;
            Date izm_ = a?.LastReviewDateElement;
            Period izn_ = a?.EffectivePeriod;
            CodeableConcept izo_ = a?.Code;
            List<ResourceReference> izp_ = a?.Instance;
            List<ChargeItemDefinition.ApplicabilityComponent> izq_ = a?.Applicability;
            List<ChargeItemDefinition.PropertyGroupComponent> izr_ = a?.PropertyGroup;
            ChargeItemDefinition izs_ = new ChargeItemDefinition
            {
                UrlElement = hzv_,
                Identifier = new List<Identifier>((IEnumerable<Identifier>)hzw_),
                VersionElement = hzx_,
                TitleElement = hzy_,
                DerivedFromUriElement = new List<FhirUri>((IEnumerable<FhirUri>)hzz_),
                PartOfElement = new List<Canonical>((IEnumerable<Canonical>)iza_),
                ReplacesElement = new List<Canonical>((IEnumerable<Canonical>)izb_),
                StatusElement = izc_,
                ExperimentalElement = izd_,
                DateElement = ize_,
                PublisherElement = izf_,
                Contact = new List<ContactDetail>((IEnumerable<ContactDetail>)izg_),
                DescriptionElement = izh_,
                UseContext = new List<UsageContext>((IEnumerable<UsageContext>)izi_),
                Jurisdiction = new List<CodeableConcept>((IEnumerable<CodeableConcept>)izj_),
                CopyrightElement = izk_,
                ApprovalDateElement = izl_,
                LastReviewDateElement = izm_,
                EffectivePeriod = izn_,
                Code = izo_,
                Instance = new List<ResourceReference>((IEnumerable<ResourceReference>)izp_),
                Applicability = new List<ChargeItemDefinition.ApplicabilityComponent>((IEnumerable<ChargeItemDefinition.ApplicabilityComponent>)izq_),
                PropertyGroup = new List<ChargeItemDefinition.PropertyGroupComponent>((IEnumerable<ChargeItemDefinition.PropertyGroupComponent>)izr_),
            };

            return izs_;
        };
        IEnumerable<ChargeItemDefinition> hzs_ = context.Operators.Select<ChargeItemDefinition, ChargeItemDefinition>((IEnumerable<ChargeItemDefinition>)hzq_, hzr_);
        IEnumerable<ChargeItemDefinition> hzt_ = context.Operators.Distinct<ChargeItemDefinition>(hzs_);
        ChargeItemDefinition hzu_ = context.Operators.SingletonFrom<ChargeItemDefinition>(hzt_);

        return hzu_;
    }


    [CqlExpressionDefinition("ClaimResource")]
    public Claim ClaimResource(CqlContext context, Claim arg)
    {
        Claim[] izt_ = [
            arg,
        ];
        Claim izu_(Claim a)
        {
            List<Identifier> izy_ = a?.Identifier;
            Code<FinancialResourceStatusCodes> izz_ = a?.StatusElement;
            CodeableConcept jza_ = a?.Type;
            CodeableConcept jzb_ = a?.SubType;
            Code<ClaimUseCode> jzc_ = a?.UseElement;
            ResourceReference jzd_ = a?.Patient;
            Period jze_ = a?.BillablePeriod;
            FhirDateTime jzf_ = a?.CreatedElement;
            ResourceReference jzg_ = a?.Enterer;
            ResourceReference jzh_ = a?.Insurer;
            ResourceReference jzi_ = a?.Provider;
            CodeableConcept jzj_ = a?.Priority;
            CodeableConcept jzk_ = a?.FundsReserve;
            List<Claim.RelatedClaimComponent> jzl_ = a?.Related;
            ResourceReference jzm_ = a?.Prescription;
            ResourceReference jzn_ = a?.OriginalPrescription;
            Claim.PayeeComponent jzo_ = a?.Payee;
            ResourceReference jzp_ = a?.Referral;
            ResourceReference jzq_ = a?.Facility;
            List<Claim.CareTeamComponent> jzr_ = a?.CareTeam;
            List<Claim.SupportingInformationComponent> jzs_ = a?.SupportingInfo;
            List<Claim.DiagnosisComponent> jzt_ = a?.Diagnosis;
            List<Claim.ProcedureComponent> jzu_ = a?.Procedure;
            List<Claim.InsuranceComponent> jzv_ = a?.Insurance;
            Claim.AccidentComponent jzw_ = a?.Accident;
            List<Claim.ItemComponent> jzx_ = a?.Item;
            Money jzy_ = a?.Total;
            Claim jzz_ = new Claim
            {
                Identifier = new List<Identifier>((IEnumerable<Identifier>)izy_),
                StatusElement = izz_,
                Type = jza_,
                SubType = jzb_,
                UseElement = jzc_,
                Patient = jzd_,
                BillablePeriod = jze_,
                CreatedElement = jzf_,
                Enterer = jzg_,
                Insurer = jzh_,
                Provider = jzi_,
                Priority = jzj_,
                FundsReserve = jzk_,
                Related = new List<Claim.RelatedClaimComponent>((IEnumerable<Claim.RelatedClaimComponent>)jzl_),
                Prescription = jzm_,
                OriginalPrescription = jzn_,
                Payee = jzo_,
                Referral = jzp_,
                Facility = jzq_,
                CareTeam = new List<Claim.CareTeamComponent>((IEnumerable<Claim.CareTeamComponent>)jzr_),
                SupportingInfo = new List<Claim.SupportingInformationComponent>((IEnumerable<Claim.SupportingInformationComponent>)jzs_),
                Diagnosis = new List<Claim.DiagnosisComponent>((IEnumerable<Claim.DiagnosisComponent>)jzt_),
                Procedure = new List<Claim.ProcedureComponent>((IEnumerable<Claim.ProcedureComponent>)jzu_),
                Insurance = new List<Claim.InsuranceComponent>((IEnumerable<Claim.InsuranceComponent>)jzv_),
                Accident = jzw_,
                Item = new List<Claim.ItemComponent>((IEnumerable<Claim.ItemComponent>)jzx_),
                Total = jzy_,
            };

            return jzz_;
        };
        IEnumerable<Claim> izv_ = context.Operators.Select<Claim, Claim>((IEnumerable<Claim>)izt_, izu_);
        IEnumerable<Claim> izw_ = context.Operators.Distinct<Claim>(izv_);
        Claim izx_ = context.Operators.SingletonFrom<Claim>(izw_);

        return izx_;
    }


    [CqlExpressionDefinition("ClaimResponseResource")]
    public ClaimResponse ClaimResponseResource(CqlContext context, ClaimResponse arg)
    {
        ClaimResponse[] kza_ = [
            arg,
        ];
        ClaimResponse kzb_(ClaimResponse a)
        {
            List<Identifier> kzf_ = a?.Identifier;
            Code<FinancialResourceStatusCodes> kzg_ = a?.StatusElement;
            CodeableConcept kzh_ = a?.Type;
            CodeableConcept kzi_ = a?.SubType;
            Code<ClaimUseCode> kzj_ = a?.UseElement;
            ResourceReference kzk_ = a?.Patient;
            FhirDateTime kzl_ = a?.CreatedElement;
            ResourceReference kzm_ = a?.Insurer;
            ResourceReference kzn_ = a?.Requestor;
            ResourceReference kzo_ = a?.Request;
            Code<ClaimProcessingCodes> kzp_ = a?.OutcomeElement;
            FhirString kzq_ = a?.DispositionElement;
            FhirString kzr_ = a?.PreAuthRefElement;
            Period kzs_ = a?.PreAuthPeriod;
            CodeableConcept kzt_ = a?.PayeeType;
            List<ClaimResponse.ItemComponent> kzu_ = a?.Item;
            List<ClaimResponse.AddedItemComponent> kzv_ = a?.AddItem;
            List<ClaimResponse.AdjudicationComponent> kzw_ = a?.Adjudication;
            List<ClaimResponse.TotalComponent> kzx_ = a?.Total;
            ClaimResponse.PaymentComponent kzy_ = a?.Payment;
            CodeableConcept kzz_ = a?.FundsReserve;
            CodeableConcept lza_ = a?.FormCode;
            Attachment lzb_ = a?.Form;
            List<ClaimResponse.NoteComponent> lzc_ = a?.ProcessNote;
            List<ResourceReference> lzd_ = a?.CommunicationRequest;
            List<ClaimResponse.InsuranceComponent> lze_ = a?.Insurance;
            List<ClaimResponse.ErrorComponent> lzf_ = a?.Error;
            ClaimResponse lzg_ = new ClaimResponse
            {
                Identifier = new List<Identifier>((IEnumerable<Identifier>)kzf_),
                StatusElement = kzg_,
                Type = kzh_,
                SubType = kzi_,
                UseElement = kzj_,
                Patient = kzk_,
                CreatedElement = kzl_,
                Insurer = kzm_,
                Requestor = kzn_,
                Request = kzo_,
                OutcomeElement = kzp_,
                DispositionElement = kzq_,
                PreAuthRefElement = kzr_,
                PreAuthPeriod = kzs_,
                PayeeType = kzt_,
                Item = new List<ClaimResponse.ItemComponent>((IEnumerable<ClaimResponse.ItemComponent>)kzu_),
                AddItem = new List<ClaimResponse.AddedItemComponent>((IEnumerable<ClaimResponse.AddedItemComponent>)kzv_),
                Adjudication = new List<ClaimResponse.AdjudicationComponent>((IEnumerable<ClaimResponse.AdjudicationComponent>)kzw_),
                Total = new List<ClaimResponse.TotalComponent>((IEnumerable<ClaimResponse.TotalComponent>)kzx_),
                Payment = kzy_,
                FundsReserve = kzz_,
                FormCode = lza_,
                Form = lzb_,
                ProcessNote = new List<ClaimResponse.NoteComponent>((IEnumerable<ClaimResponse.NoteComponent>)lzc_),
                CommunicationRequest = new List<ResourceReference>((IEnumerable<ResourceReference>)lzd_),
                Insurance = new List<ClaimResponse.InsuranceComponent>((IEnumerable<ClaimResponse.InsuranceComponent>)lze_),
                Error = new List<ClaimResponse.ErrorComponent>((IEnumerable<ClaimResponse.ErrorComponent>)lzf_),
            };

            return lzg_;
        };
        IEnumerable<ClaimResponse> kzc_ = context.Operators.Select<ClaimResponse, ClaimResponse>((IEnumerable<ClaimResponse>)kza_, kzb_);
        IEnumerable<ClaimResponse> kzd_ = context.Operators.Distinct<ClaimResponse>(kzc_);
        ClaimResponse kze_ = context.Operators.SingletonFrom<ClaimResponse>(kzd_);

        return kze_;
    }


    [CqlExpressionDefinition("ClinicalImpressionResource")]
    public ClinicalImpression ClinicalImpressionResource(CqlContext context, ClinicalImpression arg)
    {
        ClinicalImpression[] lzh_ = [
            arg,
        ];
        ClinicalImpression lzi_(ClinicalImpression a)
        {
            List<Identifier> lzm_ = a?.Identifier;
            Code<ClinicalImpression.ClinicalImpressionStatus> lzn_ = a?.StatusElement;
            CodeableConcept lzo_ = a?.StatusReason;
            CodeableConcept lzp_ = a?.Code;
            FhirString lzq_ = a?.DescriptionElement;
            ResourceReference lzr_ = a?.Subject;
            ResourceReference lzs_ = a?.Encounter;
            DataType lzt_ = a?.Effective;
            FhirDateTime lzu_ = a?.DateElement;
            ResourceReference lzv_ = a?.Assessor;
            ResourceReference lzw_ = a?.Previous;
            List<ResourceReference> lzx_ = a?.Problem;
            List<ClinicalImpression.InvestigationComponent> lzy_ = a?.Investigation;
            List<FhirUri> lzz_ = a?.ProtocolElement;
            FhirString mza_ = a?.SummaryElement;
            List<ClinicalImpression.FindingComponent> mzb_ = a?.Finding;
            List<CodeableConcept> mzc_ = a?.PrognosisCodeableConcept;
            List<ResourceReference> mzd_ = a?.PrognosisReference;
            List<ResourceReference> mze_ = a?.SupportingInfo;
            List<Annotation> mzf_ = a?.Note;
            ClinicalImpression mzg_ = new ClinicalImpression
            {
                Identifier = new List<Identifier>((IEnumerable<Identifier>)lzm_),
                StatusElement = lzn_,
                StatusReason = lzo_,
                Code = lzp_,
                DescriptionElement = lzq_,
                Subject = lzr_,
                Encounter = lzs_,
                Effective = (DataType)lzt_,
                DateElement = lzu_,
                Assessor = lzv_,
                Previous = lzw_,
                Problem = new List<ResourceReference>((IEnumerable<ResourceReference>)lzx_),
                Investigation = new List<ClinicalImpression.InvestigationComponent>((IEnumerable<ClinicalImpression.InvestigationComponent>)lzy_),
                ProtocolElement = new List<FhirUri>((IEnumerable<FhirUri>)lzz_),
                SummaryElement = mza_,
                Finding = new List<ClinicalImpression.FindingComponent>((IEnumerable<ClinicalImpression.FindingComponent>)mzb_),
                PrognosisCodeableConcept = new List<CodeableConcept>((IEnumerable<CodeableConcept>)mzc_),
                PrognosisReference = new List<ResourceReference>((IEnumerable<ResourceReference>)mzd_),
                SupportingInfo = new List<ResourceReference>((IEnumerable<ResourceReference>)mze_),
                Note = new List<Annotation>((IEnumerable<Annotation>)mzf_),
            };

            return mzg_;
        };
        IEnumerable<ClinicalImpression> lzj_ = context.Operators.Select<ClinicalImpression, ClinicalImpression>((IEnumerable<ClinicalImpression>)lzh_, lzi_);
        IEnumerable<ClinicalImpression> lzk_ = context.Operators.Distinct<ClinicalImpression>(lzj_);
        ClinicalImpression lzl_ = context.Operators.SingletonFrom<ClinicalImpression>(lzk_);

        return lzl_;
    }


    [CqlExpressionDefinition("CodeSystemResource")]
    public CodeSystem CodeSystemResource(CqlContext context, CodeSystem arg)
    {
        CodeSystem[] mzh_ = [
            arg,
        ];
        CodeSystem mzi_(CodeSystem a)
        {
            FhirUri mzm_ = a?.UrlElement;
            List<Identifier> mzn_ = a?.Identifier;
            FhirString mzo_ = a?.VersionElement;
            FhirString mzp_ = a?.NameElement;
            FhirString mzq_ = a?.TitleElement;
            Code<PublicationStatus> mzr_ = a?.StatusElement;
            FhirBoolean mzs_ = a?.ExperimentalElement;
            FhirDateTime mzt_ = a?.DateElement;
            FhirString mzu_ = a?.PublisherElement;
            List<ContactDetail> mzv_ = a?.Contact;
            Markdown mzw_ = a?.DescriptionElement;
            List<UsageContext> mzx_ = a?.UseContext;
            List<CodeableConcept> mzy_ = a?.Jurisdiction;
            Markdown mzz_ = a?.PurposeElement;
            Markdown nza_ = a?.CopyrightElement;
            FhirBoolean nzb_ = a?.CaseSensitiveElement;
            Canonical nzc_ = a?.ValueSetElement;
            Code<CodeSystem.CodeSystemHierarchyMeaning> nzd_ = a?.HierarchyMeaningElement;
            FhirBoolean nze_ = a?.CompositionalElement;
            FhirBoolean nzf_ = a?.VersionNeededElement;
            Code<CodeSystemContentMode> nzg_ = a?.ContentElement;
            Canonical nzh_ = a?.SupplementsElement;
            UnsignedInt nzi_ = a?.CountElement;
            Integer nzj_ = context.Operators.Convert<Integer>(nzi_);
            UnsignedInt nzk_ = context.Operators.Convert<UnsignedInt>(nzj_);
            List<CodeSystem.FilterComponent> nzl_ = a?.Filter;
            List<CodeSystem.PropertyComponent> nzm_ = a?.Property;
            List<CodeSystem.ConceptDefinitionComponent> nzn_ = a?.Concept;
            CodeSystem nzo_ = new CodeSystem
            {
                UrlElement = mzm_,
                Identifier = new List<Identifier>((IEnumerable<Identifier>)mzn_),
                VersionElement = mzo_,
                NameElement = mzp_,
                TitleElement = mzq_,
                StatusElement = mzr_,
                ExperimentalElement = mzs_,
                DateElement = mzt_,
                PublisherElement = mzu_,
                Contact = new List<ContactDetail>((IEnumerable<ContactDetail>)mzv_),
                DescriptionElement = mzw_,
                UseContext = new List<UsageContext>((IEnumerable<UsageContext>)mzx_),
                Jurisdiction = new List<CodeableConcept>((IEnumerable<CodeableConcept>)mzy_),
                PurposeElement = mzz_,
                CopyrightElement = nza_,
                CaseSensitiveElement = nzb_,
                ValueSetElement = nzc_,
                HierarchyMeaningElement = nzd_,
                CompositionalElement = nze_,
                VersionNeededElement = nzf_,
                ContentElement = nzg_,
                SupplementsElement = nzh_,
                CountElement = nzk_,
                Filter = new List<CodeSystem.FilterComponent>((IEnumerable<CodeSystem.FilterComponent>)nzl_),
                Property = new List<CodeSystem.PropertyComponent>((IEnumerable<CodeSystem.PropertyComponent>)nzm_),
                Concept = new List<CodeSystem.ConceptDefinitionComponent>((IEnumerable<CodeSystem.ConceptDefinitionComponent>)nzn_),
            };

            return nzo_;
        };
        IEnumerable<CodeSystem> mzj_ = context.Operators.Select<CodeSystem, CodeSystem>((IEnumerable<CodeSystem>)mzh_, mzi_);
        IEnumerable<CodeSystem> mzk_ = context.Operators.Distinct<CodeSystem>(mzj_);
        CodeSystem mzl_ = context.Operators.SingletonFrom<CodeSystem>(mzk_);

        return mzl_;
    }


    [CqlExpressionDefinition("CommunicationResource")]
    public Communication CommunicationResource(CqlContext context, Communication arg)
    {
        Communication[] nzp_ = [
            arg,
        ];
        Communication nzq_(Communication a)
        {
            List<Identifier> nzu_ = a?.Identifier;
            List<Canonical> nzv_ = a?.InstantiatesCanonicalElement;
            List<FhirUri> nzw_ = a?.InstantiatesUriElement;
            List<ResourceReference> nzx_ = a?.BasedOn;
            List<ResourceReference> nzy_ = a?.PartOf;
            List<ResourceReference> nzz_ = a?.InResponseTo;
            Code<EventStatus> oza_ = a?.StatusElement;
            CodeableConcept ozb_ = a?.StatusReason;
            List<CodeableConcept> ozc_ = a?.Category;
            Code<RequestPriority> ozd_ = a?.PriorityElement;
            List<CodeableConcept> oze_ = a?.Medium;
            ResourceReference ozf_ = a?.Subject;
            CodeableConcept ozg_ = a?.Topic;
            List<ResourceReference> ozh_ = a?.About;
            ResourceReference ozi_ = a?.Encounter;
            FhirDateTime ozj_ = a?.SentElement;
            FhirDateTime ozk_ = a?.ReceivedElement;
            List<ResourceReference> ozl_ = a?.Recipient;
            ResourceReference ozm_ = a?.Sender;
            List<CodeableConcept> ozn_ = a?.ReasonCode;
            List<ResourceReference> ozo_ = a?.ReasonReference;
            List<Communication.PayloadComponent> ozp_ = a?.Payload;
            List<Annotation> ozq_ = a?.Note;
            Communication ozr_ = new Communication
            {
                Identifier = new List<Identifier>((IEnumerable<Identifier>)nzu_),
                InstantiatesCanonicalElement = new List<Canonical>((IEnumerable<Canonical>)nzv_),
                InstantiatesUriElement = new List<FhirUri>((IEnumerable<FhirUri>)nzw_),
                BasedOn = new List<ResourceReference>((IEnumerable<ResourceReference>)nzx_),
                PartOf = new List<ResourceReference>((IEnumerable<ResourceReference>)nzy_),
                InResponseTo = new List<ResourceReference>((IEnumerable<ResourceReference>)nzz_),
                StatusElement = oza_,
                StatusReason = ozb_,
                Category = new List<CodeableConcept>((IEnumerable<CodeableConcept>)ozc_),
                PriorityElement = ozd_,
                Medium = new List<CodeableConcept>((IEnumerable<CodeableConcept>)oze_),
                Subject = ozf_,
                Topic = ozg_,
                About = new List<ResourceReference>((IEnumerable<ResourceReference>)ozh_),
                Encounter = ozi_,
                SentElement = ozj_,
                ReceivedElement = ozk_,
                Recipient = new List<ResourceReference>((IEnumerable<ResourceReference>)ozl_),
                Sender = ozm_,
                ReasonCode = new List<CodeableConcept>((IEnumerable<CodeableConcept>)ozn_),
                ReasonReference = new List<ResourceReference>((IEnumerable<ResourceReference>)ozo_),
                Payload = new List<Communication.PayloadComponent>((IEnumerable<Communication.PayloadComponent>)ozp_),
                Note = new List<Annotation>((IEnumerable<Annotation>)ozq_),
            };

            return ozr_;
        };
        IEnumerable<Communication> nzr_ = context.Operators.Select<Communication, Communication>((IEnumerable<Communication>)nzp_, nzq_);
        IEnumerable<Communication> nzs_ = context.Operators.Distinct<Communication>(nzr_);
        Communication nzt_ = context.Operators.SingletonFrom<Communication>(nzs_);

        return nzt_;
    }


    [CqlExpressionDefinition("CommunicationRequestResource")]
    public CommunicationRequest CommunicationRequestResource(CqlContext context, CommunicationRequest arg)
    {
        CommunicationRequest[] ozs_ = [
            arg,
        ];
        CommunicationRequest ozt_(CommunicationRequest a)
        {
            List<Identifier> ozx_ = a?.Identifier;
            List<ResourceReference> ozy_ = a?.BasedOn;
            List<ResourceReference> ozz_ = a?.Replaces;
            Identifier pza_ = a?.GroupIdentifier;
            Code<RequestStatus> pzb_ = a?.StatusElement;
            CodeableConcept pzc_ = a?.StatusReason;
            List<CodeableConcept> pzd_ = a?.Category;
            Code<RequestPriority> pze_ = a?.PriorityElement;
            FhirBoolean pzf_ = a?.DoNotPerformElement;
            List<CodeableConcept> pzg_ = a?.Medium;
            ResourceReference pzh_ = a?.Subject;
            List<ResourceReference> pzi_ = a?.About;
            ResourceReference pzj_ = a?.Encounter;
            List<CommunicationRequest.PayloadComponent> pzk_ = a?.Payload;
            DataType pzl_ = a?.Occurrence;
            FhirDateTime pzm_ = a?.AuthoredOnElement;
            ResourceReference pzn_ = a?.Requester;
            List<ResourceReference> pzo_ = a?.Recipient;
            ResourceReference pzp_ = a?.Sender;
            List<CodeableConcept> pzq_ = a?.ReasonCode;
            List<ResourceReference> pzr_ = a?.ReasonReference;
            List<Annotation> pzs_ = a?.Note;
            CommunicationRequest pzt_ = new CommunicationRequest
            {
                Identifier = new List<Identifier>((IEnumerable<Identifier>)ozx_),
                BasedOn = new List<ResourceReference>((IEnumerable<ResourceReference>)ozy_),
                Replaces = new List<ResourceReference>((IEnumerable<ResourceReference>)ozz_),
                GroupIdentifier = pza_,
                StatusElement = pzb_,
                StatusReason = pzc_,
                Category = new List<CodeableConcept>((IEnumerable<CodeableConcept>)pzd_),
                PriorityElement = pze_,
                DoNotPerformElement = pzf_,
                Medium = new List<CodeableConcept>((IEnumerable<CodeableConcept>)pzg_),
                Subject = pzh_,
                About = new List<ResourceReference>((IEnumerable<ResourceReference>)pzi_),
                Encounter = pzj_,
                Payload = new List<CommunicationRequest.PayloadComponent>((IEnumerable<CommunicationRequest.PayloadComponent>)pzk_),
                Occurrence = (DataType)pzl_,
                AuthoredOnElement = pzm_,
                Requester = pzn_,
                Recipient = new List<ResourceReference>((IEnumerable<ResourceReference>)pzo_),
                Sender = pzp_,
                ReasonCode = new List<CodeableConcept>((IEnumerable<CodeableConcept>)pzq_),
                ReasonReference = new List<ResourceReference>((IEnumerable<ResourceReference>)pzr_),
                Note = new List<Annotation>((IEnumerable<Annotation>)pzs_),
            };

            return pzt_;
        };
        IEnumerable<CommunicationRequest> ozu_ = context.Operators.Select<CommunicationRequest, CommunicationRequest>((IEnumerable<CommunicationRequest>)ozs_, ozt_);
        IEnumerable<CommunicationRequest> ozv_ = context.Operators.Distinct<CommunicationRequest>(ozu_);
        CommunicationRequest ozw_ = context.Operators.SingletonFrom<CommunicationRequest>(ozv_);

        return ozw_;
    }


    [CqlExpressionDefinition("CompositionResource")]
    public Composition CompositionResource(CqlContext context, Composition arg)
    {
        Composition[] pzu_ = [
            arg,
        ];
        Composition pzv_(Composition a)
        {
            Identifier pzz_ = a?.Identifier;
            Code<CompositionStatus> qza_ = a?.StatusElement;
            CodeableConcept qzb_ = a?.Type;
            List<CodeableConcept> qzc_ = a?.Category;
            ResourceReference qzd_ = a?.Subject;
            ResourceReference qze_ = a?.Encounter;
            FhirDateTime qzf_ = a?.DateElement;
            List<ResourceReference> qzg_ = a?.Author;
            FhirString qzh_ = a?.TitleElement;
            Code<Composition.V3ConfidentialityClassification> qzi_ = a?.ConfidentialityElement;
            List<Composition.AttesterComponent> qzj_ = a?.Attester;
            ResourceReference qzk_ = a?.Custodian;
            List<Composition.RelatesToComponent> qzl_ = a?.RelatesTo;
            List<Composition.EventComponent> qzm_ = a?.Event;
            List<Composition.SectionComponent> qzn_ = a?.Section;
            Composition qzo_ = new Composition
            {
                Identifier = pzz_,
                StatusElement = qza_,
                Type = qzb_,
                Category = new List<CodeableConcept>((IEnumerable<CodeableConcept>)qzc_),
                Subject = qzd_,
                Encounter = qze_,
                DateElement = qzf_,
                Author = new List<ResourceReference>((IEnumerable<ResourceReference>)qzg_),
                TitleElement = qzh_,
                ConfidentialityElement = qzi_,
                Attester = new List<Composition.AttesterComponent>((IEnumerable<Composition.AttesterComponent>)qzj_),
                Custodian = qzk_,
                RelatesTo = new List<Composition.RelatesToComponent>((IEnumerable<Composition.RelatesToComponent>)qzl_),
                Event = new List<Composition.EventComponent>((IEnumerable<Composition.EventComponent>)qzm_),
                Section = new List<Composition.SectionComponent>((IEnumerable<Composition.SectionComponent>)qzn_),
            };

            return qzo_;
        };
        IEnumerable<Composition> pzw_ = context.Operators.Select<Composition, Composition>((IEnumerable<Composition>)pzu_, pzv_);
        IEnumerable<Composition> pzx_ = context.Operators.Distinct<Composition>(pzw_);
        Composition pzy_ = context.Operators.SingletonFrom<Composition>(pzx_);

        return pzy_;
    }


    [CqlExpressionDefinition("ConceptMapResource")]
    public ConceptMap ConceptMapResource(CqlContext context, ConceptMap arg)
    {
        ConceptMap[] qzp_ = [
            arg,
        ];
        ConceptMap qzq_(ConceptMap a)
        {
            FhirUri qzu_ = a?.UrlElement;
            Identifier qzv_ = a?.Identifier;
            FhirString qzw_ = a?.VersionElement;
            FhirString qzx_ = a?.NameElement;
            FhirString qzy_ = a?.TitleElement;
            Code<PublicationStatus> qzz_ = a?.StatusElement;
            FhirBoolean rza_ = a?.ExperimentalElement;
            FhirDateTime rzb_ = a?.DateElement;
            FhirString rzc_ = a?.PublisherElement;
            List<ContactDetail> rzd_ = a?.Contact;
            Markdown rze_ = a?.DescriptionElement;
            List<UsageContext> rzf_ = a?.UseContext;
            List<CodeableConcept> rzg_ = a?.Jurisdiction;
            Markdown rzh_ = a?.PurposeElement;
            Markdown rzi_ = a?.CopyrightElement;
            DataType rzj_ = a?.Source;
            DataType rzk_ = a?.Target;
            List<ConceptMap.GroupComponent> rzl_ = a?.Group;
            ConceptMap rzm_ = new ConceptMap
            {
                UrlElement = qzu_,
                Identifier = qzv_,
                VersionElement = qzw_,
                NameElement = qzx_,
                TitleElement = qzy_,
                StatusElement = qzz_,
                ExperimentalElement = rza_,
                DateElement = rzb_,
                PublisherElement = rzc_,
                Contact = new List<ContactDetail>((IEnumerable<ContactDetail>)rzd_),
                DescriptionElement = rze_,
                UseContext = new List<UsageContext>((IEnumerable<UsageContext>)rzf_),
                Jurisdiction = new List<CodeableConcept>((IEnumerable<CodeableConcept>)rzg_),
                PurposeElement = rzh_,
                CopyrightElement = rzi_,
                Source = (DataType)rzj_,
                Target = (DataType)rzk_,
                Group = new List<ConceptMap.GroupComponent>((IEnumerable<ConceptMap.GroupComponent>)rzl_),
            };

            return rzm_;
        };
        IEnumerable<ConceptMap> qzr_ = context.Operators.Select<ConceptMap, ConceptMap>((IEnumerable<ConceptMap>)qzp_, qzq_);
        IEnumerable<ConceptMap> qzs_ = context.Operators.Distinct<ConceptMap>(qzr_);
        ConceptMap qzt_ = context.Operators.SingletonFrom<ConceptMap>(qzs_);

        return qzt_;
    }


    [CqlExpressionDefinition("ConditionResource")]
    public Condition ConditionResource(CqlContext context, Condition arg)
    {
        Condition[] rzn_ = [
            arg,
        ];
        Condition rzo_(Condition a)
        {
            List<Identifier> rzs_ = a?.Identifier;
            CodeableConcept rzt_ = a?.ClinicalStatus;
            CodeableConcept rzu_ = a?.VerificationStatus;
            List<CodeableConcept> rzv_ = a?.Category;
            CodeableConcept rzw_ = a?.Severity;
            CodeableConcept rzx_ = a?.Code;
            List<CodeableConcept> rzy_ = a?.BodySite;
            ResourceReference rzz_ = a?.Subject;
            ResourceReference sza_ = a?.Encounter;
            DataType szb_ = a?.Onset;
            DataType szc_ = a?.Abatement;
            FhirDateTime szd_ = a?.RecordedDateElement;
            ResourceReference sze_ = a?.Recorder;
            ResourceReference szf_ = a?.Asserter;
            List<Condition.StageComponent> szg_ = a?.Stage;
            List<Condition.EvidenceComponent> szh_ = a?.Evidence;
            List<Annotation> szi_ = a?.Note;
            Condition szj_ = new Condition
            {
                Identifier = new List<Identifier>((IEnumerable<Identifier>)rzs_),
                ClinicalStatus = rzt_,
                VerificationStatus = rzu_,
                Category = new List<CodeableConcept>((IEnumerable<CodeableConcept>)rzv_),
                Severity = rzw_,
                Code = rzx_,
                BodySite = new List<CodeableConcept>((IEnumerable<CodeableConcept>)rzy_),
                Subject = rzz_,
                Encounter = sza_,
                Onset = (DataType)szb_,
                Abatement = (DataType)szc_,
                RecordedDateElement = szd_,
                Recorder = sze_,
                Asserter = szf_,
                Stage = new List<Condition.StageComponent>((IEnumerable<Condition.StageComponent>)szg_),
                Evidence = new List<Condition.EvidenceComponent>((IEnumerable<Condition.EvidenceComponent>)szh_),
                Note = new List<Annotation>((IEnumerable<Annotation>)szi_),
            };

            return szj_;
        };
        IEnumerable<Condition> rzp_ = context.Operators.Select<Condition, Condition>((IEnumerable<Condition>)rzn_, rzo_);
        IEnumerable<Condition> rzq_ = context.Operators.Distinct<Condition>(rzp_);
        Condition rzr_ = context.Operators.SingletonFrom<Condition>(rzq_);

        return rzr_;
    }


    [CqlExpressionDefinition("ConsentResource")]
    public Consent ConsentResource(CqlContext context, Consent arg)
    {
        Consent[] szk_ = [
            arg,
        ];
        Consent szl_(Consent a)
        {
            List<Identifier> szp_ = a?.Identifier;
            Code<Consent.ConsentState> szq_ = a?.StatusElement;
            CodeableConcept szr_ = a?.Scope;
            List<CodeableConcept> szs_ = a?.Category;
            ResourceReference szt_ = a?.Patient;
            FhirDateTime szu_ = a?.DateTimeElement;
            List<ResourceReference> szv_ = a?.Performer;
            List<ResourceReference> szw_ = a?.Organization;
            DataType szx_ = a?.Source;
            List<Consent.PolicyComponent> szy_ = a?.Policy;
            CodeableConcept szz_ = a?.PolicyRule;
            List<Consent.VerificationComponent> tza_ = a?.Verification;
            Consent.provisionComponent tzb_ = a?.Provision;
            Consent tzc_ = new Consent
            {
                Identifier = new List<Identifier>((IEnumerable<Identifier>)szp_),
                StatusElement = szq_,
                Scope = szr_,
                Category = new List<CodeableConcept>((IEnumerable<CodeableConcept>)szs_),
                Patient = szt_,
                DateTimeElement = szu_,
                Performer = new List<ResourceReference>((IEnumerable<ResourceReference>)szv_),
                Organization = new List<ResourceReference>((IEnumerable<ResourceReference>)szw_),
                Source = (DataType)szx_,
                Policy = new List<Consent.PolicyComponent>((IEnumerable<Consent.PolicyComponent>)szy_),
                PolicyRule = szz_,
                Verification = new List<Consent.VerificationComponent>((IEnumerable<Consent.VerificationComponent>)tza_),
                Provision = tzb_,
            };

            return tzc_;
        };
        IEnumerable<Consent> szm_ = context.Operators.Select<Consent, Consent>((IEnumerable<Consent>)szk_, szl_);
        IEnumerable<Consent> szn_ = context.Operators.Distinct<Consent>(szm_);
        Consent szo_ = context.Operators.SingletonFrom<Consent>(szn_);

        return szo_;
    }


    [CqlExpressionDefinition("ContractResource")]
    public Contract ContractResource(CqlContext context, Contract arg)
    {
        Contract[] tzd_ = [
            arg,
        ];
        Contract tze_(Contract a)
        {
            List<Identifier> tzi_ = a?.Identifier;
            FhirUri tzj_ = a?.UrlElement;
            FhirString tzk_ = a?.VersionElement;
            Code<Contract.ContractResourceStatusCodes> tzl_ = a?.StatusElement;
            CodeableConcept tzm_ = a?.LegalState;
            ResourceReference tzn_ = a?.InstantiatesCanonical;
            FhirUri tzo_ = a?.InstantiatesUriElement;
            CodeableConcept tzp_ = a?.ContentDerivative;
            FhirDateTime tzq_ = a?.IssuedElement;
            Period tzr_ = a?.Applies;
            CodeableConcept tzs_ = a?.ExpirationType;
            List<ResourceReference> tzt_ = a?.Subject;
            List<ResourceReference> tzu_ = a?.Authority;
            List<ResourceReference> tzv_ = a?.Domain;
            List<ResourceReference> tzw_ = a?.Site;
            FhirString tzx_ = a?.NameElement;
            FhirString tzy_ = a?.TitleElement;
            FhirString tzz_ = a?.SubtitleElement;
            List<FhirString> uza_ = a?.AliasElement;
            ResourceReference uzb_ = a?.Author;
            CodeableConcept uzc_ = a?.Scope;
            DataType uzd_ = a?.Topic;
            CodeableConcept uze_ = a?.Type;
            List<CodeableConcept> uzf_ = a?.SubType;
            Contract.ContentDefinitionComponent uzg_ = a?.ContentDefinition;
            List<Contract.TermComponent> uzh_ = a?.Term;
            List<ResourceReference> uzi_ = a?.SupportingInfo;
            List<ResourceReference> uzj_ = a?.RelevantHistory;
            List<Contract.SignatoryComponent> uzk_ = a?.Signer;
            List<Contract.FriendlyLanguageComponent> uzl_ = a?.Friendly;
            List<Contract.LegalLanguageComponent> uzm_ = a?.Legal;
            List<Contract.ComputableLanguageComponent> uzn_ = a?.Rule;
            DataType uzo_ = a?.LegallyBinding;
            Contract uzp_ = new Contract
            {
                Identifier = new List<Identifier>((IEnumerable<Identifier>)tzi_),
                UrlElement = tzj_,
                VersionElement = tzk_,
                StatusElement = tzl_,
                LegalState = tzm_,
                InstantiatesCanonical = tzn_,
                InstantiatesUriElement = tzo_,
                ContentDerivative = tzp_,
                IssuedElement = tzq_,
                Applies = tzr_,
                ExpirationType = tzs_,
                Subject = new List<ResourceReference>((IEnumerable<ResourceReference>)tzt_),
                Authority = new List<ResourceReference>((IEnumerable<ResourceReference>)tzu_),
                Domain = new List<ResourceReference>((IEnumerable<ResourceReference>)tzv_),
                Site = new List<ResourceReference>((IEnumerable<ResourceReference>)tzw_),
                NameElement = tzx_,
                TitleElement = tzy_,
                SubtitleElement = tzz_,
                AliasElement = new List<FhirString>((IEnumerable<FhirString>)uza_),
                Author = uzb_,
                Scope = uzc_,
                Topic = (DataType)uzd_,
                Type = uze_,
                SubType = new List<CodeableConcept>((IEnumerable<CodeableConcept>)uzf_),
                ContentDefinition = uzg_,
                Term = new List<Contract.TermComponent>((IEnumerable<Contract.TermComponent>)uzh_),
                SupportingInfo = new List<ResourceReference>((IEnumerable<ResourceReference>)uzi_),
                RelevantHistory = new List<ResourceReference>((IEnumerable<ResourceReference>)uzj_),
                Signer = new List<Contract.SignatoryComponent>((IEnumerable<Contract.SignatoryComponent>)uzk_),
                Friendly = new List<Contract.FriendlyLanguageComponent>((IEnumerable<Contract.FriendlyLanguageComponent>)uzl_),
                Legal = new List<Contract.LegalLanguageComponent>((IEnumerable<Contract.LegalLanguageComponent>)uzm_),
                Rule = new List<Contract.ComputableLanguageComponent>((IEnumerable<Contract.ComputableLanguageComponent>)uzn_),
                LegallyBinding = (DataType)uzo_,
            };

            return uzp_;
        };
        IEnumerable<Contract> tzf_ = context.Operators.Select<Contract, Contract>((IEnumerable<Contract>)tzd_, tze_);
        IEnumerable<Contract> tzg_ = context.Operators.Distinct<Contract>(tzf_);
        Contract tzh_ = context.Operators.SingletonFrom<Contract>(tzg_);

        return tzh_;
    }


    [CqlExpressionDefinition("CoverageResource")]
    public Coverage CoverageResource(CqlContext context, Coverage arg)
    {
        Coverage[] uzq_ = [
            arg,
        ];
        Coverage uzr_(Coverage a)
        {
            List<Identifier> uzv_ = a?.Identifier;
            Code<FinancialResourceStatusCodes> uzw_ = a?.StatusElement;
            CodeableConcept uzx_ = a?.Type;
            ResourceReference uzy_ = a?.PolicyHolder;
            ResourceReference uzz_ = a?.Subscriber;
            FhirString vza_ = a?.SubscriberIdElement;
            ResourceReference vzb_ = a?.Beneficiary;
            FhirString vzc_ = a?.DependentElement;
            CodeableConcept vzd_ = a?.Relationship;
            Period vze_ = a?.Period;
            List<ResourceReference> vzf_ = a?.Payor;
            List<Coverage.ClassComponent> vzg_ = a?.Class;
            PositiveInt vzh_ = a?.OrderElement;
            Integer vzi_ = context.Operators.Convert<Integer>(vzh_);
            PositiveInt vzj_ = context.Operators.Convert<PositiveInt>(vzi_);
            FhirString vzk_ = a?.NetworkElement;
            List<Coverage.CostToBeneficiaryComponent> vzl_ = a?.CostToBeneficiary;
            FhirBoolean vzm_ = a?.SubrogationElement;
            List<ResourceReference> vzn_ = a?.Contract;
            Coverage vzo_ = new Coverage
            {
                Identifier = new List<Identifier>((IEnumerable<Identifier>)uzv_),
                StatusElement = uzw_,
                Type = uzx_,
                PolicyHolder = uzy_,
                Subscriber = uzz_,
                SubscriberIdElement = vza_,
                Beneficiary = vzb_,
                DependentElement = vzc_,
                Relationship = vzd_,
                Period = vze_,
                Payor = new List<ResourceReference>((IEnumerable<ResourceReference>)vzf_),
                Class = new List<Coverage.ClassComponent>((IEnumerable<Coverage.ClassComponent>)vzg_),
                OrderElement = vzj_,
                NetworkElement = vzk_,
                CostToBeneficiary = new List<Coverage.CostToBeneficiaryComponent>((IEnumerable<Coverage.CostToBeneficiaryComponent>)vzl_),
                SubrogationElement = vzm_,
                Contract = new List<ResourceReference>((IEnumerable<ResourceReference>)vzn_),
            };

            return vzo_;
        };
        IEnumerable<Coverage> uzs_ = context.Operators.Select<Coverage, Coverage>((IEnumerable<Coverage>)uzq_, uzr_);
        IEnumerable<Coverage> uzt_ = context.Operators.Distinct<Coverage>(uzs_);
        Coverage uzu_ = context.Operators.SingletonFrom<Coverage>(uzt_);

        return uzu_;
    }


    [CqlExpressionDefinition("CoverageEligibilityRequestResource")]
    public CoverageEligibilityRequest CoverageEligibilityRequestResource(CqlContext context, CoverageEligibilityRequest arg)
    {
        CoverageEligibilityRequest[] vzp_ = [
            arg,
        ];
        CoverageEligibilityRequest vzq_(CoverageEligibilityRequest a)
        {
            List<Identifier> vzu_ = a?.Identifier;
            Code<FinancialResourceStatusCodes> vzv_ = a?.StatusElement;
            CodeableConcept vzw_ = a?.Priority;
            List<Code<CoverageEligibilityRequest.EligibilityRequestPurpose>> vzx_ = a?.PurposeElement;
            ResourceReference vzy_ = a?.Patient;
            DataType vzz_ = a?.Serviced;
            FhirDateTime wza_ = a?.CreatedElement;
            ResourceReference wzb_ = a?.Enterer;
            ResourceReference wzc_ = a?.Provider;
            ResourceReference wzd_ = a?.Insurer;
            ResourceReference wze_ = a?.Facility;
            List<CoverageEligibilityRequest.SupportingInformationComponent> wzf_ = a?.SupportingInfo;
            List<CoverageEligibilityRequest.InsuranceComponent> wzg_ = a?.Insurance;
            List<CoverageEligibilityRequest.DetailsComponent> wzh_ = a?.Item;
            CoverageEligibilityRequest wzi_ = new CoverageEligibilityRequest
            {
                Identifier = new List<Identifier>((IEnumerable<Identifier>)vzu_),
                StatusElement = vzv_,
                Priority = vzw_,
                PurposeElement = new List<Code<CoverageEligibilityRequest.EligibilityRequestPurpose>>((IEnumerable<Code<CoverageEligibilityRequest.EligibilityRequestPurpose>>)vzx_),
                Patient = vzy_,
                Serviced = (DataType)vzz_,
                CreatedElement = wza_,
                Enterer = wzb_,
                Provider = wzc_,
                Insurer = wzd_,
                Facility = wze_,
                SupportingInfo = new List<CoverageEligibilityRequest.SupportingInformationComponent>((IEnumerable<CoverageEligibilityRequest.SupportingInformationComponent>)wzf_),
                Insurance = new List<CoverageEligibilityRequest.InsuranceComponent>((IEnumerable<CoverageEligibilityRequest.InsuranceComponent>)wzg_),
                Item = new List<CoverageEligibilityRequest.DetailsComponent>((IEnumerable<CoverageEligibilityRequest.DetailsComponent>)wzh_),
            };

            return wzi_;
        };
        IEnumerable<CoverageEligibilityRequest> vzr_ = context.Operators.Select<CoverageEligibilityRequest, CoverageEligibilityRequest>((IEnumerable<CoverageEligibilityRequest>)vzp_, vzq_);
        IEnumerable<CoverageEligibilityRequest> vzs_ = context.Operators.Distinct<CoverageEligibilityRequest>(vzr_);
        CoverageEligibilityRequest vzt_ = context.Operators.SingletonFrom<CoverageEligibilityRequest>(vzs_);

        return vzt_;
    }


    [CqlExpressionDefinition("CoverageEligibilityResponseResource")]
    public CoverageEligibilityResponse CoverageEligibilityResponseResource(CqlContext context, CoverageEligibilityResponse arg)
    {
        CoverageEligibilityResponse[] wzj_ = [
            arg,
        ];
        CoverageEligibilityResponse wzk_(CoverageEligibilityResponse a)
        {
            List<Identifier> wzo_ = a?.Identifier;
            Code<FinancialResourceStatusCodes> wzp_ = a?.StatusElement;
            List<Code<CoverageEligibilityResponse.EligibilityResponsePurpose>> wzq_ = a?.PurposeElement;
            ResourceReference wzr_ = a?.Patient;
            DataType wzs_ = a?.Serviced;
            FhirDateTime wzt_ = a?.CreatedElement;
            ResourceReference wzu_ = a?.Requestor;
            ResourceReference wzv_ = a?.Request;
            Code<ClaimProcessingCodes> wzw_ = a?.OutcomeElement;
            FhirString wzx_ = a?.DispositionElement;
            ResourceReference wzy_ = a?.Insurer;
            List<CoverageEligibilityResponse.InsuranceComponent> wzz_ = a?.Insurance;
            FhirString xza_ = a?.PreAuthRefElement;
            CodeableConcept xzb_ = a?.Form;
            List<CoverageEligibilityResponse.ErrorsComponent> xzc_ = a?.Error;
            CoverageEligibilityResponse xzd_ = new CoverageEligibilityResponse
            {
                Identifier = new List<Identifier>((IEnumerable<Identifier>)wzo_),
                StatusElement = wzp_,
                PurposeElement = new List<Code<CoverageEligibilityResponse.EligibilityResponsePurpose>>((IEnumerable<Code<CoverageEligibilityResponse.EligibilityResponsePurpose>>)wzq_),
                Patient = wzr_,
                Serviced = (DataType)wzs_,
                CreatedElement = wzt_,
                Requestor = wzu_,
                Request = wzv_,
                OutcomeElement = wzw_,
                DispositionElement = wzx_,
                Insurer = wzy_,
                Insurance = new List<CoverageEligibilityResponse.InsuranceComponent>((IEnumerable<CoverageEligibilityResponse.InsuranceComponent>)wzz_),
                PreAuthRefElement = xza_,
                Form = xzb_,
                Error = new List<CoverageEligibilityResponse.ErrorsComponent>((IEnumerable<CoverageEligibilityResponse.ErrorsComponent>)xzc_),
            };

            return xzd_;
        };
        IEnumerable<CoverageEligibilityResponse> wzl_ = context.Operators.Select<CoverageEligibilityResponse, CoverageEligibilityResponse>((IEnumerable<CoverageEligibilityResponse>)wzj_, wzk_);
        IEnumerable<CoverageEligibilityResponse> wzm_ = context.Operators.Distinct<CoverageEligibilityResponse>(wzl_);
        CoverageEligibilityResponse wzn_ = context.Operators.SingletonFrom<CoverageEligibilityResponse>(wzm_);

        return wzn_;
    }


    [CqlExpressionDefinition("DetectedIssueResource")]
    public DetectedIssue DetectedIssueResource(CqlContext context, DetectedIssue arg)
    {
        DetectedIssue[] xze_ = [
            arg,
        ];
        DetectedIssue xzf_(DetectedIssue a)
        {
            List<Identifier> xzj_ = a?.Identifier;
            Code<ObservationStatus> xzk_ = a?.StatusElement;
            CodeableConcept xzl_ = a?.Code;
            Code<DetectedIssue.DetectedIssueSeverity> xzm_ = a?.SeverityElement;
            ResourceReference xzn_ = a?.Patient;
            DataType xzo_ = a?.Identified;
            ResourceReference xzp_ = a?.Author;
            List<ResourceReference> xzq_ = a?.Implicated;
            List<DetectedIssue.EvidenceComponent> xzr_ = a?.Evidence;
            FhirString xzs_ = a?.DetailElement;
            FhirUri xzt_ = a?.ReferenceElement;
            List<DetectedIssue.MitigationComponent> xzu_ = a?.Mitigation;
            DetectedIssue xzv_ = new DetectedIssue
            {
                Identifier = new List<Identifier>((IEnumerable<Identifier>)xzj_),
                StatusElement = xzk_,
                Code = xzl_,
                SeverityElement = xzm_,
                Patient = xzn_,
                Identified = (DataType)xzo_,
                Author = xzp_,
                Implicated = new List<ResourceReference>((IEnumerable<ResourceReference>)xzq_),
                Evidence = new List<DetectedIssue.EvidenceComponent>((IEnumerable<DetectedIssue.EvidenceComponent>)xzr_),
                DetailElement = xzs_,
                ReferenceElement = xzt_,
                Mitigation = new List<DetectedIssue.MitigationComponent>((IEnumerable<DetectedIssue.MitigationComponent>)xzu_),
            };

            return xzv_;
        };
        IEnumerable<DetectedIssue> xzg_ = context.Operators.Select<DetectedIssue, DetectedIssue>((IEnumerable<DetectedIssue>)xze_, xzf_);
        IEnumerable<DetectedIssue> xzh_ = context.Operators.Distinct<DetectedIssue>(xzg_);
        DetectedIssue xzi_ = context.Operators.SingletonFrom<DetectedIssue>(xzh_);

        return xzi_;
    }


    [CqlExpressionDefinition("DeviceResource")]
    public Device DeviceResource(CqlContext context, Device arg)
    {
        Device[] xzw_ = [
            arg,
        ];
        Device xzx_(Device a)
        {
            List<Identifier> yzb_ = a?.Identifier;
            ResourceReference yzc_ = a?.Definition;
            List<Device.UdiCarrierComponent> yzd_ = a?.UdiCarrier;
            Code<Device.FHIRDeviceStatus> yze_ = a?.StatusElement;
            List<CodeableConcept> yzf_ = a?.StatusReason;
            FhirString yzg_ = a?.DistinctIdentifierElement;
            FhirString yzh_ = a?.ManufacturerElement;
            FhirDateTime yzi_ = a?.ManufactureDateElement;
            FhirDateTime yzj_ = a?.ExpirationDateElement;
            FhirString yzk_ = a?.LotNumberElement;
            FhirString yzl_ = a?.SerialNumberElement;
            List<Device.DeviceNameComponent> yzm_ = a?.DeviceName;
            FhirString yzn_ = a?.ModelNumberElement;
            FhirString yzo_ = a?.PartNumberElement;
            CodeableConcept yzp_ = a?.Type;
            List<Device.SpecializationComponent> yzq_ = a?.Specialization;
            List<Device.VersionComponent> yzr_ = a?.Version;
            List<Device.PropertyComponent> yzs_ = a?.Property;
            ResourceReference yzt_ = a?.Patient;
            ResourceReference yzu_ = a?.Owner;
            List<ContactPoint> yzv_ = a?.Contact;
            ResourceReference yzw_ = a?.Location;
            FhirUri yzx_ = a?.UrlElement;
            List<Annotation> yzy_ = a?.Note;
            List<CodeableConcept> yzz_ = a?.Safety;
            ResourceReference zza_ = a?.Parent;
            Device zzb_ = new Device
            {
                Identifier = new List<Identifier>((IEnumerable<Identifier>)yzb_),
                Definition = yzc_,
                UdiCarrier = new List<Device.UdiCarrierComponent>((IEnumerable<Device.UdiCarrierComponent>)yzd_),
                StatusElement = yze_,
                StatusReason = new List<CodeableConcept>((IEnumerable<CodeableConcept>)yzf_),
                DistinctIdentifierElement = yzg_,
                ManufacturerElement = yzh_,
                ManufactureDateElement = yzi_,
                ExpirationDateElement = yzj_,
                LotNumberElement = yzk_,
                SerialNumberElement = yzl_,
                DeviceName = new List<Device.DeviceNameComponent>((IEnumerable<Device.DeviceNameComponent>)yzm_),
                ModelNumberElement = yzn_,
                PartNumberElement = yzo_,
                Type = yzp_,
                Specialization = new List<Device.SpecializationComponent>((IEnumerable<Device.SpecializationComponent>)yzq_),
                Version = new List<Device.VersionComponent>((IEnumerable<Device.VersionComponent>)yzr_),
                Property = new List<Device.PropertyComponent>((IEnumerable<Device.PropertyComponent>)yzs_),
                Patient = yzt_,
                Owner = yzu_,
                Contact = new List<ContactPoint>((IEnumerable<ContactPoint>)yzv_),
                Location = yzw_,
                UrlElement = yzx_,
                Note = new List<Annotation>((IEnumerable<Annotation>)yzy_),
                Safety = new List<CodeableConcept>((IEnumerable<CodeableConcept>)yzz_),
                Parent = zza_,
            };

            return zzb_;
        };
        IEnumerable<Device> xzy_ = context.Operators.Select<Device, Device>((IEnumerable<Device>)xzw_, xzx_);
        IEnumerable<Device> xzz_ = context.Operators.Distinct<Device>(xzy_);
        Device yza_ = context.Operators.SingletonFrom<Device>(xzz_);

        return yza_;
    }


    [CqlExpressionDefinition("DeviceDefinitionResource")]
    public DeviceDefinition DeviceDefinitionResource(CqlContext context, DeviceDefinition arg)
    {
        DeviceDefinition[] zzc_ = [
            arg,
        ];
        DeviceDefinition zzd_(DeviceDefinition a)
        {
            List<Identifier> zzh_ = a?.Identifier;
            List<DeviceDefinition.UdiDeviceIdentifierComponent> zzi_ = a?.UdiDeviceIdentifier;
            DataType zzj_ = a?.Manufacturer;
            List<DeviceDefinition.DeviceNameComponent> zzk_ = a?.DeviceName;
            FhirString zzl_ = a?.ModelNumberElement;
            CodeableConcept zzm_ = a?.Type;
            List<DeviceDefinition.SpecializationComponent> zzn_ = a?.Specialization;
            List<FhirString> zzo_ = a?.VersionElement;
            List<CodeableConcept> zzp_ = a?.Safety;
            List<ProductShelfLife> zzq_ = a?.ShelfLifeStorage;
            ProdCharacteristic zzr_ = a?.PhysicalCharacteristics;
            List<CodeableConcept> zzs_ = a?.LanguageCode;
            List<DeviceDefinition.CapabilityComponent> zzt_ = a?.Capability;
            List<DeviceDefinition.PropertyComponent> zzu_ = a?.Property;
            ResourceReference zzv_ = a?.Owner;
            List<ContactPoint> zzw_ = a?.Contact;
            FhirUri zzx_ = a?.UrlElement;
            FhirUri zzy_ = a?.OnlineInformationElement;
            List<Annotation> zzz_ = a?.Note;
            Quantity azza_ = a?.Quantity;
            ResourceReference azzb_ = a?.ParentDevice;
            List<DeviceDefinition.MaterialComponent> azzc_ = a?.Material;
            DeviceDefinition azzd_ = new DeviceDefinition
            {
                Identifier = new List<Identifier>((IEnumerable<Identifier>)zzh_),
                UdiDeviceIdentifier = new List<DeviceDefinition.UdiDeviceIdentifierComponent>((IEnumerable<DeviceDefinition.UdiDeviceIdentifierComponent>)zzi_),
                Manufacturer = (DataType)zzj_,
                DeviceName = new List<DeviceDefinition.DeviceNameComponent>((IEnumerable<DeviceDefinition.DeviceNameComponent>)zzk_),
                ModelNumberElement = zzl_,
                Type = zzm_,
                Specialization = new List<DeviceDefinition.SpecializationComponent>((IEnumerable<DeviceDefinition.SpecializationComponent>)zzn_),
                VersionElement = new List<FhirString>((IEnumerable<FhirString>)zzo_),
                Safety = new List<CodeableConcept>((IEnumerable<CodeableConcept>)zzp_),
                ShelfLifeStorage = new List<ProductShelfLife>((IEnumerable<ProductShelfLife>)zzq_),
                PhysicalCharacteristics = zzr_,
                LanguageCode = new List<CodeableConcept>((IEnumerable<CodeableConcept>)zzs_),
                Capability = new List<DeviceDefinition.CapabilityComponent>((IEnumerable<DeviceDefinition.CapabilityComponent>)zzt_),
                Property = new List<DeviceDefinition.PropertyComponent>((IEnumerable<DeviceDefinition.PropertyComponent>)zzu_),
                Owner = zzv_,
                Contact = new List<ContactPoint>((IEnumerable<ContactPoint>)zzw_),
                UrlElement = zzx_,
                OnlineInformationElement = zzy_,
                Note = new List<Annotation>((IEnumerable<Annotation>)zzz_),
                Quantity = azza_,
                ParentDevice = azzb_,
                Material = new List<DeviceDefinition.MaterialComponent>((IEnumerable<DeviceDefinition.MaterialComponent>)azzc_),
            };

            return azzd_;
        };
        IEnumerable<DeviceDefinition> zze_ = context.Operators.Select<DeviceDefinition, DeviceDefinition>((IEnumerable<DeviceDefinition>)zzc_, zzd_);
        IEnumerable<DeviceDefinition> zzf_ = context.Operators.Distinct<DeviceDefinition>(zze_);
        DeviceDefinition zzg_ = context.Operators.SingletonFrom<DeviceDefinition>(zzf_);

        return zzg_;
    }


    [CqlExpressionDefinition("DeviceMetricResource")]
    public DeviceMetric DeviceMetricResource(CqlContext context, DeviceMetric arg)
    {
        DeviceMetric[] azze_ = [
            arg,
        ];
        DeviceMetric azzf_(DeviceMetric a)
        {
            List<Identifier> azzj_ = a?.Identifier;
            CodeableConcept azzk_ = a?.Type;
            CodeableConcept azzl_ = a?.Unit;
            ResourceReference azzm_ = a?.Source;
            ResourceReference azzn_ = a?.Parent;
            Code<DeviceMetric.DeviceMetricOperationalStatus> azzo_ = a?.OperationalStatusElement;
            Code<DeviceMetric.DeviceMetricColor> azzp_ = a?.ColorElement;
            Code<DeviceMetric.DeviceMetricCategory> azzq_ = a?.CategoryElement;
            Timing azzr_ = a?.MeasurementPeriod;
            List<DeviceMetric.CalibrationComponent> azzs_ = a?.Calibration;
            DeviceMetric azzt_ = new DeviceMetric
            {
                Identifier = new List<Identifier>((IEnumerable<Identifier>)azzj_),
                Type = azzk_,
                Unit = azzl_,
                Source = azzm_,
                Parent = azzn_,
                OperationalStatusElement = azzo_,
                ColorElement = azzp_,
                CategoryElement = azzq_,
                MeasurementPeriod = azzr_,
                Calibration = new List<DeviceMetric.CalibrationComponent>((IEnumerable<DeviceMetric.CalibrationComponent>)azzs_),
            };

            return azzt_;
        };
        IEnumerable<DeviceMetric> azzg_ = context.Operators.Select<DeviceMetric, DeviceMetric>((IEnumerable<DeviceMetric>)azze_, azzf_);
        IEnumerable<DeviceMetric> azzh_ = context.Operators.Distinct<DeviceMetric>(azzg_);
        DeviceMetric azzi_ = context.Operators.SingletonFrom<DeviceMetric>(azzh_);

        return azzi_;
    }


    [CqlExpressionDefinition("DeviceRequestResource")]
    public DeviceRequest DeviceRequestResource(CqlContext context, DeviceRequest arg)
    {
        DeviceRequest[] azzu_ = [
            arg,
        ];
        DeviceRequest azzv_(DeviceRequest a)
        {
            List<Identifier> azzz_ = a?.Identifier;
            List<Canonical> bzza_ = a?.InstantiatesCanonicalElement;
            List<FhirUri> bzzb_ = a?.InstantiatesUriElement;
            List<ResourceReference> bzzc_ = a?.BasedOn;
            List<ResourceReference> bzzd_ = a?.PriorRequest;
            Identifier bzze_ = a?.GroupIdentifier;
            Code<RequestStatus> bzzf_ = a?.StatusElement;
            Code<RequestIntent> bzzg_ = a?.IntentElement;
            Code<RequestPriority> bzzh_ = a?.PriorityElement;
            DataType bzzi_ = a?.Code;
            List<DeviceRequest.ParameterComponent> bzzj_ = a?.Parameter;
            ResourceReference bzzk_ = a?.Subject;
            ResourceReference bzzl_ = a?.Encounter;
            DataType bzzm_ = a?.Occurrence;
            FhirDateTime bzzn_ = a?.AuthoredOnElement;
            ResourceReference bzzo_ = a?.Requester;
            CodeableConcept bzzp_ = a?.PerformerType;
            ResourceReference bzzq_ = a?.Performer;
            List<CodeableConcept> bzzr_ = a?.ReasonCode;
            List<ResourceReference> bzzs_ = a?.ReasonReference;
            List<ResourceReference> bzzt_ = a?.Insurance;
            List<ResourceReference> bzzu_ = a?.SupportingInfo;
            List<Annotation> bzzv_ = a?.Note;
            List<ResourceReference> bzzw_ = a?.RelevantHistory;
            DeviceRequest bzzx_ = new DeviceRequest
            {
                Identifier = new List<Identifier>((IEnumerable<Identifier>)azzz_),
                InstantiatesCanonicalElement = new List<Canonical>((IEnumerable<Canonical>)bzza_),
                InstantiatesUriElement = new List<FhirUri>((IEnumerable<FhirUri>)bzzb_),
                BasedOn = new List<ResourceReference>((IEnumerable<ResourceReference>)bzzc_),
                PriorRequest = new List<ResourceReference>((IEnumerable<ResourceReference>)bzzd_),
                GroupIdentifier = bzze_,
                StatusElement = bzzf_,
                IntentElement = bzzg_,
                PriorityElement = bzzh_,
                Code = (DataType)bzzi_,
                Parameter = new List<DeviceRequest.ParameterComponent>((IEnumerable<DeviceRequest.ParameterComponent>)bzzj_),
                Subject = bzzk_,
                Encounter = bzzl_,
                Occurrence = (DataType)bzzm_,
                AuthoredOnElement = bzzn_,
                Requester = bzzo_,
                PerformerType = bzzp_,
                Performer = bzzq_,
                ReasonCode = new List<CodeableConcept>((IEnumerable<CodeableConcept>)bzzr_),
                ReasonReference = new List<ResourceReference>((IEnumerable<ResourceReference>)bzzs_),
                Insurance = new List<ResourceReference>((IEnumerable<ResourceReference>)bzzt_),
                SupportingInfo = new List<ResourceReference>((IEnumerable<ResourceReference>)bzzu_),
                Note = new List<Annotation>((IEnumerable<Annotation>)bzzv_),
                RelevantHistory = new List<ResourceReference>((IEnumerable<ResourceReference>)bzzw_),
            };

            return bzzx_;
        };
        IEnumerable<DeviceRequest> azzw_ = context.Operators.Select<DeviceRequest, DeviceRequest>((IEnumerable<DeviceRequest>)azzu_, azzv_);
        IEnumerable<DeviceRequest> azzx_ = context.Operators.Distinct<DeviceRequest>(azzw_);
        DeviceRequest azzy_ = context.Operators.SingletonFrom<DeviceRequest>(azzx_);

        return azzy_;
    }


    [CqlExpressionDefinition("DeviceUseStatementResource")]
    public DeviceUseStatement DeviceUseStatementResource(CqlContext context, DeviceUseStatement arg)
    {
        DeviceUseStatement[] bzzy_ = [
            arg,
        ];
        DeviceUseStatement bzzz_(DeviceUseStatement a)
        {
            List<Identifier> czzd_ = a?.Identifier;
            List<ResourceReference> czze_ = a?.BasedOn;
            Code<DeviceUseStatement.DeviceUseStatementStatus> czzf_ = a?.StatusElement;
            ResourceReference czzg_ = a?.Subject;
            List<ResourceReference> czzh_ = a?.DerivedFrom;
            DataType czzi_ = a?.Timing;
            FhirDateTime czzj_ = a?.RecordedOnElement;
            ResourceReference czzk_ = a?.Source;
            ResourceReference czzl_ = a?.Device;
            List<CodeableConcept> czzm_ = a?.ReasonCode;
            List<ResourceReference> czzn_ = a?.ReasonReference;
            CodeableConcept czzo_ = a?.BodySite;
            List<Annotation> czzp_ = a?.Note;
            DeviceUseStatement czzq_ = new DeviceUseStatement
            {
                Identifier = new List<Identifier>((IEnumerable<Identifier>)czzd_),
                BasedOn = new List<ResourceReference>((IEnumerable<ResourceReference>)czze_),
                StatusElement = czzf_,
                Subject = czzg_,
                DerivedFrom = new List<ResourceReference>((IEnumerable<ResourceReference>)czzh_),
                Timing = (DataType)czzi_,
                RecordedOnElement = czzj_,
                Source = czzk_,
                Device = czzl_,
                ReasonCode = new List<CodeableConcept>((IEnumerable<CodeableConcept>)czzm_),
                ReasonReference = new List<ResourceReference>((IEnumerable<ResourceReference>)czzn_),
                BodySite = czzo_,
                Note = new List<Annotation>((IEnumerable<Annotation>)czzp_),
            };

            return czzq_;
        };
        IEnumerable<DeviceUseStatement> czza_ = context.Operators.Select<DeviceUseStatement, DeviceUseStatement>((IEnumerable<DeviceUseStatement>)bzzy_, bzzz_);
        IEnumerable<DeviceUseStatement> czzb_ = context.Operators.Distinct<DeviceUseStatement>(czza_);
        DeviceUseStatement czzc_ = context.Operators.SingletonFrom<DeviceUseStatement>(czzb_);

        return czzc_;
    }


    [CqlExpressionDefinition("DiagnosticReportResource")]
    public DiagnosticReport DiagnosticReportResource(CqlContext context, DiagnosticReport arg)
    {
        DiagnosticReport[] czzr_ = [
            arg,
        ];
        DiagnosticReport czzs_(DiagnosticReport a)
        {
            List<Identifier> czzw_ = a?.Identifier;
            List<ResourceReference> czzx_ = a?.BasedOn;
            Code<DiagnosticReport.DiagnosticReportStatus> czzy_ = a?.StatusElement;
            List<CodeableConcept> czzz_ = a?.Category;
            CodeableConcept dzza_ = a?.Code;
            ResourceReference dzzb_ = a?.Subject;
            ResourceReference dzzc_ = a?.Encounter;
            DataType dzzd_ = a?.Effective;
            Instant dzze_ = a?.IssuedElement;
            List<ResourceReference> dzzf_ = a?.Performer;
            List<ResourceReference> dzzg_ = a?.ResultsInterpreter;
            List<ResourceReference> dzzh_ = a?.Specimen;
            List<ResourceReference> dzzi_ = a?.Result;
            List<ResourceReference> dzzj_ = a?.ImagingStudy;
            List<DiagnosticReport.MediaComponent> dzzk_ = a?.Media;
            FhirString dzzl_ = a?.ConclusionElement;
            List<CodeableConcept> dzzm_ = a?.ConclusionCode;
            List<Attachment> dzzn_ = a?.PresentedForm;
            DiagnosticReport dzzo_ = new DiagnosticReport
            {
                Identifier = new List<Identifier>((IEnumerable<Identifier>)czzw_),
                BasedOn = new List<ResourceReference>((IEnumerable<ResourceReference>)czzx_),
                StatusElement = czzy_,
                Category = new List<CodeableConcept>((IEnumerable<CodeableConcept>)czzz_),
                Code = dzza_,
                Subject = dzzb_,
                Encounter = dzzc_,
                Effective = (DataType)dzzd_,
                IssuedElement = dzze_,
                Performer = new List<ResourceReference>((IEnumerable<ResourceReference>)dzzf_),
                ResultsInterpreter = new List<ResourceReference>((IEnumerable<ResourceReference>)dzzg_),
                Specimen = new List<ResourceReference>((IEnumerable<ResourceReference>)dzzh_),
                Result = new List<ResourceReference>((IEnumerable<ResourceReference>)dzzi_),
                ImagingStudy = new List<ResourceReference>((IEnumerable<ResourceReference>)dzzj_),
                Media = new List<DiagnosticReport.MediaComponent>((IEnumerable<DiagnosticReport.MediaComponent>)dzzk_),
                ConclusionElement = dzzl_,
                ConclusionCode = new List<CodeableConcept>((IEnumerable<CodeableConcept>)dzzm_),
                PresentedForm = new List<Attachment>((IEnumerable<Attachment>)dzzn_),
            };

            return dzzo_;
        };
        IEnumerable<DiagnosticReport> czzt_ = context.Operators.Select<DiagnosticReport, DiagnosticReport>((IEnumerable<DiagnosticReport>)czzr_, czzs_);
        IEnumerable<DiagnosticReport> czzu_ = context.Operators.Distinct<DiagnosticReport>(czzt_);
        DiagnosticReport czzv_ = context.Operators.SingletonFrom<DiagnosticReport>(czzu_);

        return czzv_;
    }


    [CqlExpressionDefinition("DocumentManifestResource")]
    public DocumentManifest DocumentManifestResource(CqlContext context, DocumentManifest arg)
    {
        DocumentManifest[] dzzp_ = [
            arg,
        ];
        DocumentManifest dzzq_(DocumentManifest a)
        {
            Identifier dzzu_ = a?.MasterIdentifier;
            List<Identifier> dzzv_ = a?.Identifier;
            Code<DocumentReferenceStatus> dzzw_ = a?.StatusElement;
            CodeableConcept dzzx_ = a?.Type;
            ResourceReference dzzy_ = a?.Subject;
            FhirDateTime dzzz_ = a?.CreatedElement;
            List<ResourceReference> ezza_ = a?.Author;
            List<ResourceReference> ezzb_ = a?.Recipient;
            FhirUri ezzc_ = a?.SourceElement;
            FhirString ezzd_ = a?.DescriptionElement;
            List<ResourceReference> ezze_ = a?.Content;
            List<DocumentManifest.RelatedComponent> ezzf_ = a?.Related;
            DocumentManifest ezzg_ = new DocumentManifest
            {
                MasterIdentifier = dzzu_,
                Identifier = new List<Identifier>((IEnumerable<Identifier>)dzzv_),
                StatusElement = dzzw_,
                Type = dzzx_,
                Subject = dzzy_,
                CreatedElement = dzzz_,
                Author = new List<ResourceReference>((IEnumerable<ResourceReference>)ezza_),
                Recipient = new List<ResourceReference>((IEnumerable<ResourceReference>)ezzb_),
                SourceElement = ezzc_,
                DescriptionElement = ezzd_,
                Content = new List<ResourceReference>((IEnumerable<ResourceReference>)ezze_),
                Related = new List<DocumentManifest.RelatedComponent>((IEnumerable<DocumentManifest.RelatedComponent>)ezzf_),
            };

            return ezzg_;
        };
        IEnumerable<DocumentManifest> dzzr_ = context.Operators.Select<DocumentManifest, DocumentManifest>((IEnumerable<DocumentManifest>)dzzp_, dzzq_);
        IEnumerable<DocumentManifest> dzzs_ = context.Operators.Distinct<DocumentManifest>(dzzr_);
        DocumentManifest dzzt_ = context.Operators.SingletonFrom<DocumentManifest>(dzzs_);

        return dzzt_;
    }


    [CqlExpressionDefinition("DocumentReferenceResource")]
    public DocumentReference DocumentReferenceResource(CqlContext context, DocumentReference arg)
    {
        DocumentReference[] ezzh_ = [
            arg,
        ];
        DocumentReference ezzi_(DocumentReference a)
        {
            Identifier ezzm_ = a?.MasterIdentifier;
            List<Identifier> ezzn_ = a?.Identifier;
            Code<DocumentReferenceStatus> ezzo_ = a?.StatusElement;
            Code<CompositionStatus> ezzp_ = a?.DocStatusElement;
            CodeableConcept ezzq_ = a?.Type;
            List<CodeableConcept> ezzr_ = a?.Category;
            ResourceReference ezzs_ = a?.Subject;
            Instant ezzt_ = a?.DateElement;
            List<ResourceReference> ezzu_ = a?.Author;
            ResourceReference ezzv_ = a?.Authenticator;
            ResourceReference ezzw_ = a?.Custodian;
            List<DocumentReference.RelatesToComponent> ezzx_ = a?.RelatesTo;
            FhirString ezzy_ = a?.DescriptionElement;
            List<CodeableConcept> ezzz_ = a?.SecurityLabel;
            List<DocumentReference.ContentComponent> fzza_ = a?.Content;
            DocumentReference.ContextComponent fzzb_ = a?.Context;
            DocumentReference fzzc_ = new DocumentReference
            {
                MasterIdentifier = ezzm_,
                Identifier = new List<Identifier>((IEnumerable<Identifier>)ezzn_),
                StatusElement = ezzo_,
                DocStatusElement = ezzp_,
                Type = ezzq_,
                Category = new List<CodeableConcept>((IEnumerable<CodeableConcept>)ezzr_),
                Subject = ezzs_,
                DateElement = ezzt_,
                Author = new List<ResourceReference>((IEnumerable<ResourceReference>)ezzu_),
                Authenticator = ezzv_,
                Custodian = ezzw_,
                RelatesTo = new List<DocumentReference.RelatesToComponent>((IEnumerable<DocumentReference.RelatesToComponent>)ezzx_),
                DescriptionElement = ezzy_,
                SecurityLabel = new List<CodeableConcept>((IEnumerable<CodeableConcept>)ezzz_),
                Content = new List<DocumentReference.ContentComponent>((IEnumerable<DocumentReference.ContentComponent>)fzza_),
                Context = fzzb_,
            };

            return fzzc_;
        };
        IEnumerable<DocumentReference> ezzj_ = context.Operators.Select<DocumentReference, DocumentReference>((IEnumerable<DocumentReference>)ezzh_, ezzi_);
        IEnumerable<DocumentReference> ezzk_ = context.Operators.Distinct<DocumentReference>(ezzj_);
        DocumentReference ezzl_ = context.Operators.SingletonFrom<DocumentReference>(ezzk_);

        return ezzl_;
    }


    [CqlExpressionDefinition("EffectEvidenceSynthesisResource")]
    public EffectEvidenceSynthesis EffectEvidenceSynthesisResource(CqlContext context, EffectEvidenceSynthesis arg)
    {
        EffectEvidenceSynthesis[] fzzd_ = [
            arg,
        ];
        EffectEvidenceSynthesis fzze_(EffectEvidenceSynthesis a)
        {
            FhirUri fzzi_ = a?.UrlElement;
            List<Identifier> fzzj_ = a?.Identifier;
            FhirString fzzk_ = a?.VersionElement;
            FhirString fzzl_ = a?.NameElement;
            FhirString fzzm_ = a?.TitleElement;
            Code<PublicationStatus> fzzn_ = a?.StatusElement;
            FhirDateTime fzzo_ = a?.DateElement;
            FhirString fzzp_ = a?.PublisherElement;
            List<ContactDetail> fzzq_ = a?.Contact;
            Markdown fzzr_ = a?.DescriptionElement;
            List<Annotation> fzzs_ = a?.Note;
            List<UsageContext> fzzt_ = a?.UseContext;
            List<CodeableConcept> fzzu_ = a?.Jurisdiction;
            Markdown fzzv_ = a?.CopyrightElement;
            Date fzzw_ = a?.ApprovalDateElement;
            Date fzzx_ = a?.LastReviewDateElement;
            Period fzzy_ = a?.EffectivePeriod;
            List<CodeableConcept> fzzz_ = a?.Topic;
            List<ContactDetail> gzza_ = a?.Author;
            List<ContactDetail> gzzb_ = a?.Editor;
            List<ContactDetail> gzzc_ = a?.Reviewer;
            List<ContactDetail> gzzd_ = a?.Endorser;
            List<RelatedArtifact> gzze_ = a?.RelatedArtifact;
            CodeableConcept gzzf_ = a?.SynthesisType;
            CodeableConcept gzzg_ = a?.StudyType;
            ResourceReference gzzh_ = a?.Population;
            ResourceReference gzzi_ = a?.Exposure;
            ResourceReference gzzj_ = a?.ExposureAlternative;
            ResourceReference gzzk_ = a?.Outcome;
            EffectEvidenceSynthesis.SampleSizeComponent gzzl_ = a?.SampleSize;
            List<EffectEvidenceSynthesis.ResultsByExposureComponent> gzzm_ = a?.ResultsByExposure;
            List<EffectEvidenceSynthesis.EffectEstimateComponent> gzzn_ = a?.EffectEstimate;
            List<EffectEvidenceSynthesis.CertaintyComponent> gzzo_ = a?.Certainty;
            EffectEvidenceSynthesis gzzp_ = new EffectEvidenceSynthesis
            {
                UrlElement = fzzi_,
                Identifier = new List<Identifier>((IEnumerable<Identifier>)fzzj_),
                VersionElement = fzzk_,
                NameElement = fzzl_,
                TitleElement = fzzm_,
                StatusElement = fzzn_,
                DateElement = fzzo_,
                PublisherElement = fzzp_,
                Contact = new List<ContactDetail>((IEnumerable<ContactDetail>)fzzq_),
                DescriptionElement = fzzr_,
                Note = new List<Annotation>((IEnumerable<Annotation>)fzzs_),
                UseContext = new List<UsageContext>((IEnumerable<UsageContext>)fzzt_),
                Jurisdiction = new List<CodeableConcept>((IEnumerable<CodeableConcept>)fzzu_),
                CopyrightElement = fzzv_,
                ApprovalDateElement = fzzw_,
                LastReviewDateElement = fzzx_,
                EffectivePeriod = fzzy_,
                Topic = new List<CodeableConcept>((IEnumerable<CodeableConcept>)fzzz_),
                Author = new List<ContactDetail>((IEnumerable<ContactDetail>)gzza_),
                Editor = new List<ContactDetail>((IEnumerable<ContactDetail>)gzzb_),
                Reviewer = new List<ContactDetail>((IEnumerable<ContactDetail>)gzzc_),
                Endorser = new List<ContactDetail>((IEnumerable<ContactDetail>)gzzd_),
                RelatedArtifact = new List<RelatedArtifact>((IEnumerable<RelatedArtifact>)gzze_),
                SynthesisType = gzzf_,
                StudyType = gzzg_,
                Population = gzzh_,
                Exposure = gzzi_,
                ExposureAlternative = gzzj_,
                Outcome = gzzk_,
                SampleSize = gzzl_,
                ResultsByExposure = new List<EffectEvidenceSynthesis.ResultsByExposureComponent>((IEnumerable<EffectEvidenceSynthesis.ResultsByExposureComponent>)gzzm_),
                EffectEstimate = new List<EffectEvidenceSynthesis.EffectEstimateComponent>((IEnumerable<EffectEvidenceSynthesis.EffectEstimateComponent>)gzzn_),
                Certainty = new List<EffectEvidenceSynthesis.CertaintyComponent>((IEnumerable<EffectEvidenceSynthesis.CertaintyComponent>)gzzo_),
            };

            return gzzp_;
        };
        IEnumerable<EffectEvidenceSynthesis> fzzf_ = context.Operators.Select<EffectEvidenceSynthesis, EffectEvidenceSynthesis>((IEnumerable<EffectEvidenceSynthesis>)fzzd_, fzze_);
        IEnumerable<EffectEvidenceSynthesis> fzzg_ = context.Operators.Distinct<EffectEvidenceSynthesis>(fzzf_);
        EffectEvidenceSynthesis fzzh_ = context.Operators.SingletonFrom<EffectEvidenceSynthesis>(fzzg_);

        return fzzh_;
    }


    [CqlExpressionDefinition("EncounterResource")]
    public Encounter EncounterResource(CqlContext context, Encounter arg)
    {
        Encounter[] gzzq_ = [
            arg,
        ];
        Encounter gzzr_(Encounter a)
        {
            List<Identifier> gzzv_ = a?.Identifier;
            Code<Encounter.EncounterStatus> gzzw_ = a?.StatusElement;
            List<Encounter.StatusHistoryComponent> gzzx_ = a?.StatusHistory;
            Coding gzzy_ = a?.Class;
            List<Encounter.ClassHistoryComponent> gzzz_ = a?.ClassHistory;
            List<CodeableConcept> hzza_ = a?.Type;
            CodeableConcept hzzb_ = a?.ServiceType;
            CodeableConcept hzzc_ = a?.Priority;
            ResourceReference hzzd_ = a?.Subject;
            List<ResourceReference> hzze_ = a?.EpisodeOfCare;
            List<ResourceReference> hzzf_ = a?.BasedOn;
            List<Encounter.ParticipantComponent> hzzg_ = a?.Participant;
            List<ResourceReference> hzzh_ = a?.Appointment;
            Period hzzi_ = a?.Period;
            Duration hzzj_ = a?.Length;
            List<CodeableConcept> hzzk_ = a?.ReasonCode;
            List<ResourceReference> hzzl_ = a?.ReasonReference;
            List<Encounter.DiagnosisComponent> hzzm_ = a?.Diagnosis;
            List<ResourceReference> hzzn_ = a?.Account;
            Encounter.HospitalizationComponent hzzo_ = a?.Hospitalization;
            List<Encounter.LocationComponent> hzzp_ = a?.Location;
            ResourceReference hzzq_ = a?.ServiceProvider;
            ResourceReference hzzr_ = a?.PartOf;
            Encounter hzzs_ = new Encounter
            {
                Identifier = new List<Identifier>((IEnumerable<Identifier>)gzzv_),
                StatusElement = gzzw_,
                StatusHistory = new List<Encounter.StatusHistoryComponent>((IEnumerable<Encounter.StatusHistoryComponent>)gzzx_),
                Class = gzzy_,
                ClassHistory = new List<Encounter.ClassHistoryComponent>((IEnumerable<Encounter.ClassHistoryComponent>)gzzz_),
                Type = new List<CodeableConcept>((IEnumerable<CodeableConcept>)hzza_),
                ServiceType = hzzb_,
                Priority = hzzc_,
                Subject = hzzd_,
                EpisodeOfCare = new List<ResourceReference>((IEnumerable<ResourceReference>)hzze_),
                BasedOn = new List<ResourceReference>((IEnumerable<ResourceReference>)hzzf_),
                Participant = new List<Encounter.ParticipantComponent>((IEnumerable<Encounter.ParticipantComponent>)hzzg_),
                Appointment = new List<ResourceReference>((IEnumerable<ResourceReference>)hzzh_),
                Period = hzzi_,
                Length = hzzj_,
                ReasonCode = new List<CodeableConcept>((IEnumerable<CodeableConcept>)hzzk_),
                ReasonReference = new List<ResourceReference>((IEnumerable<ResourceReference>)hzzl_),
                Diagnosis = new List<Encounter.DiagnosisComponent>((IEnumerable<Encounter.DiagnosisComponent>)hzzm_),
                Account = new List<ResourceReference>((IEnumerable<ResourceReference>)hzzn_),
                Hospitalization = hzzo_,
                Location = new List<Encounter.LocationComponent>((IEnumerable<Encounter.LocationComponent>)hzzp_),
                ServiceProvider = hzzq_,
                PartOf = hzzr_,
            };

            return hzzs_;
        };
        IEnumerable<Encounter> gzzs_ = context.Operators.Select<Encounter, Encounter>((IEnumerable<Encounter>)gzzq_, gzzr_);
        IEnumerable<Encounter> gzzt_ = context.Operators.Distinct<Encounter>(gzzs_);
        Encounter gzzu_ = context.Operators.SingletonFrom<Encounter>(gzzt_);

        return gzzu_;
    }


    [CqlExpressionDefinition("EndpointResource")]
    public Endpoint EndpointResource(CqlContext context, Endpoint arg)
    {
        Endpoint[] hzzt_ = [
            arg,
        ];
        Endpoint hzzu_(Endpoint a)
        {
            List<Identifier> hzzy_ = a?.Identifier;
            Code<Endpoint.EndpointStatus> hzzz_ = a?.StatusElement;
            Coding izza_ = a?.ConnectionType;
            FhirString izzb_ = a?.NameElement;
            ResourceReference izzc_ = a?.ManagingOrganization;
            List<ContactPoint> izzd_ = a?.Contact;
            Period izze_ = a?.Period;
            List<CodeableConcept> izzf_ = a?.PayloadType;
            List<Code> izzg_ = a?.PayloadMimeTypeElement;
            FhirUrl izzh_ = a?.AddressElement;
            List<FhirString> izzi_ = a?.HeaderElement;
            Endpoint izzj_ = new Endpoint
            {
                Identifier = new List<Identifier>((IEnumerable<Identifier>)hzzy_),
                StatusElement = hzzz_,
                ConnectionType = izza_,
                NameElement = izzb_,
                ManagingOrganization = izzc_,
                Contact = new List<ContactPoint>((IEnumerable<ContactPoint>)izzd_),
                Period = izze_,
                PayloadType = new List<CodeableConcept>((IEnumerable<CodeableConcept>)izzf_),
                PayloadMimeTypeElement = new List<Code>((IEnumerable<Code>)izzg_),
                AddressElement = izzh_,
                HeaderElement = new List<FhirString>((IEnumerable<FhirString>)izzi_),
            };

            return izzj_;
        };
        IEnumerable<Endpoint> hzzv_ = context.Operators.Select<Endpoint, Endpoint>((IEnumerable<Endpoint>)hzzt_, hzzu_);
        IEnumerable<Endpoint> hzzw_ = context.Operators.Distinct<Endpoint>(hzzv_);
        Endpoint hzzx_ = context.Operators.SingletonFrom<Endpoint>(hzzw_);

        return hzzx_;
    }


    [CqlExpressionDefinition("EnrollmentRequestResource")]
    public EnrollmentRequest EnrollmentRequestResource(CqlContext context, EnrollmentRequest arg)
    {
        EnrollmentRequest[] izzk_ = [
            arg,
        ];
        EnrollmentRequest izzl_(EnrollmentRequest a)
        {
            List<Identifier> izzp_ = a?.Identifier;
            Code<FinancialResourceStatusCodes> izzq_ = a?.StatusElement;
            FhirDateTime izzr_ = a?.CreatedElement;
            ResourceReference izzs_ = a?.Insurer;
            ResourceReference izzt_ = a?.Provider;
            ResourceReference izzu_ = a?.Candidate;
            ResourceReference izzv_ = a?.Coverage;
            EnrollmentRequest izzw_ = new EnrollmentRequest
            {
                Identifier = new List<Identifier>((IEnumerable<Identifier>)izzp_),
                StatusElement = izzq_,
                CreatedElement = izzr_,
                Insurer = izzs_,
                Provider = izzt_,
                Candidate = izzu_,
                Coverage = izzv_,
            };

            return izzw_;
        };
        IEnumerable<EnrollmentRequest> izzm_ = context.Operators.Select<EnrollmentRequest, EnrollmentRequest>((IEnumerable<EnrollmentRequest>)izzk_, izzl_);
        IEnumerable<EnrollmentRequest> izzn_ = context.Operators.Distinct<EnrollmentRequest>(izzm_);
        EnrollmentRequest izzo_ = context.Operators.SingletonFrom<EnrollmentRequest>(izzn_);

        return izzo_;
    }


    [CqlExpressionDefinition("EnrollmentResponseResource")]
    public EnrollmentResponse EnrollmentResponseResource(CqlContext context, EnrollmentResponse arg)
    {
        EnrollmentResponse[] izzx_ = [
            arg,
        ];
        EnrollmentResponse izzy_(EnrollmentResponse a)
        {
            List<Identifier> jzzc_ = a?.Identifier;
            Code<FinancialResourceStatusCodes> jzzd_ = a?.StatusElement;
            ResourceReference jzze_ = a?.Request;
            Code<ClaimProcessingCodes> jzzf_ = a?.OutcomeElement;
            FhirString jzzg_ = a?.DispositionElement;
            FhirDateTime jzzh_ = a?.CreatedElement;
            ResourceReference jzzi_ = a?.Organization;
            ResourceReference jzzj_ = a?.RequestProvider;
            EnrollmentResponse jzzk_ = new EnrollmentResponse
            {
                Identifier = new List<Identifier>((IEnumerable<Identifier>)jzzc_),
                StatusElement = jzzd_,
                Request = jzze_,
                OutcomeElement = jzzf_,
                DispositionElement = jzzg_,
                CreatedElement = jzzh_,
                Organization = jzzi_,
                RequestProvider = jzzj_,
            };

            return jzzk_;
        };
        IEnumerable<EnrollmentResponse> izzz_ = context.Operators.Select<EnrollmentResponse, EnrollmentResponse>((IEnumerable<EnrollmentResponse>)izzx_, izzy_);
        IEnumerable<EnrollmentResponse> jzza_ = context.Operators.Distinct<EnrollmentResponse>(izzz_);
        EnrollmentResponse jzzb_ = context.Operators.SingletonFrom<EnrollmentResponse>(jzza_);

        return jzzb_;
    }


    [CqlExpressionDefinition("EpisodeOfCareResource")]
    public EpisodeOfCare EpisodeOfCareResource(CqlContext context, EpisodeOfCare arg)
    {
        EpisodeOfCare[] jzzl_ = [
            arg,
        ];
        EpisodeOfCare jzzm_(EpisodeOfCare a)
        {
            List<Identifier> jzzq_ = a?.Identifier;
            Code<EpisodeOfCare.EpisodeOfCareStatus> jzzr_ = a?.StatusElement;
            List<EpisodeOfCare.StatusHistoryComponent> jzzs_ = a?.StatusHistory;
            List<CodeableConcept> jzzt_ = a?.Type;
            List<EpisodeOfCare.DiagnosisComponent> jzzu_ = a?.Diagnosis;
            ResourceReference jzzv_ = a?.Patient;
            ResourceReference jzzw_ = a?.ManagingOrganization;
            Period jzzx_ = a?.Period;
            List<ResourceReference> jzzy_ = a?.ReferralRequest;
            ResourceReference jzzz_ = a?.CareManager;
            List<ResourceReference> kzza_ = a?.Team;
            List<ResourceReference> kzzb_ = a?.Account;
            EpisodeOfCare kzzc_ = new EpisodeOfCare
            {
                Identifier = new List<Identifier>((IEnumerable<Identifier>)jzzq_),
                StatusElement = jzzr_,
                StatusHistory = new List<EpisodeOfCare.StatusHistoryComponent>((IEnumerable<EpisodeOfCare.StatusHistoryComponent>)jzzs_),
                Type = new List<CodeableConcept>((IEnumerable<CodeableConcept>)jzzt_),
                Diagnosis = new List<EpisodeOfCare.DiagnosisComponent>((IEnumerable<EpisodeOfCare.DiagnosisComponent>)jzzu_),
                Patient = jzzv_,
                ManagingOrganization = jzzw_,
                Period = jzzx_,
                ReferralRequest = new List<ResourceReference>((IEnumerable<ResourceReference>)jzzy_),
                CareManager = jzzz_,
                Team = new List<ResourceReference>((IEnumerable<ResourceReference>)kzza_),
                Account = new List<ResourceReference>((IEnumerable<ResourceReference>)kzzb_),
            };

            return kzzc_;
        };
        IEnumerable<EpisodeOfCare> jzzn_ = context.Operators.Select<EpisodeOfCare, EpisodeOfCare>((IEnumerable<EpisodeOfCare>)jzzl_, jzzm_);
        IEnumerable<EpisodeOfCare> jzzo_ = context.Operators.Distinct<EpisodeOfCare>(jzzn_);
        EpisodeOfCare jzzp_ = context.Operators.SingletonFrom<EpisodeOfCare>(jzzo_);

        return jzzp_;
    }


    [CqlExpressionDefinition("EventDefinitionResource")]
    public EventDefinition EventDefinitionResource(CqlContext context, EventDefinition arg)
    {
        EventDefinition[] kzzd_ = [
            arg,
        ];
        EventDefinition kzze_(EventDefinition a)
        {
            FhirUri kzzi_ = a?.UrlElement;
            List<Identifier> kzzj_ = a?.Identifier;
            FhirString kzzk_ = a?.VersionElement;
            FhirString kzzl_ = a?.NameElement;
            FhirString kzzm_ = a?.TitleElement;
            FhirString kzzn_ = a?.SubtitleElement;
            Code<PublicationStatus> kzzo_ = a?.StatusElement;
            FhirBoolean kzzp_ = a?.ExperimentalElement;
            DataType kzzq_ = a?.Subject;
            FhirDateTime kzzr_ = a?.DateElement;
            FhirString kzzs_ = a?.PublisherElement;
            List<ContactDetail> kzzt_ = a?.Contact;
            Markdown kzzu_ = a?.DescriptionElement;
            List<UsageContext> kzzv_ = a?.UseContext;
            List<CodeableConcept> kzzw_ = a?.Jurisdiction;
            Markdown kzzx_ = a?.PurposeElement;
            FhirString kzzy_ = a?.UsageElement;
            Markdown kzzz_ = a?.CopyrightElement;
            Date lzza_ = a?.ApprovalDateElement;
            Date lzzb_ = a?.LastReviewDateElement;
            Period lzzc_ = a?.EffectivePeriod;
            List<CodeableConcept> lzzd_ = a?.Topic;
            List<ContactDetail> lzze_ = a?.Author;
            List<ContactDetail> lzzf_ = a?.Editor;
            List<ContactDetail> lzzg_ = a?.Reviewer;
            List<ContactDetail> lzzh_ = a?.Endorser;
            List<RelatedArtifact> lzzi_ = a?.RelatedArtifact;
            List<TriggerDefinition> lzzj_ = a?.Trigger;
            EventDefinition lzzk_ = new EventDefinition
            {
                UrlElement = kzzi_,
                Identifier = new List<Identifier>((IEnumerable<Identifier>)kzzj_),
                VersionElement = kzzk_,
                NameElement = kzzl_,
                TitleElement = kzzm_,
                SubtitleElement = kzzn_,
                StatusElement = kzzo_,
                ExperimentalElement = kzzp_,
                Subject = (DataType)kzzq_,
                DateElement = kzzr_,
                PublisherElement = kzzs_,
                Contact = new List<ContactDetail>((IEnumerable<ContactDetail>)kzzt_),
                DescriptionElement = kzzu_,
                UseContext = new List<UsageContext>((IEnumerable<UsageContext>)kzzv_),
                Jurisdiction = new List<CodeableConcept>((IEnumerable<CodeableConcept>)kzzw_),
                PurposeElement = kzzx_,
                UsageElement = kzzy_,
                CopyrightElement = kzzz_,
                ApprovalDateElement = lzza_,
                LastReviewDateElement = lzzb_,
                EffectivePeriod = lzzc_,
                Topic = new List<CodeableConcept>((IEnumerable<CodeableConcept>)lzzd_),
                Author = new List<ContactDetail>((IEnumerable<ContactDetail>)lzze_),
                Editor = new List<ContactDetail>((IEnumerable<ContactDetail>)lzzf_),
                Reviewer = new List<ContactDetail>((IEnumerable<ContactDetail>)lzzg_),
                Endorser = new List<ContactDetail>((IEnumerable<ContactDetail>)lzzh_),
                RelatedArtifact = new List<RelatedArtifact>((IEnumerable<RelatedArtifact>)lzzi_),
                Trigger = new List<TriggerDefinition>((IEnumerable<TriggerDefinition>)lzzj_),
            };

            return lzzk_;
        };
        IEnumerable<EventDefinition> kzzf_ = context.Operators.Select<EventDefinition, EventDefinition>((IEnumerable<EventDefinition>)kzzd_, kzze_);
        IEnumerable<EventDefinition> kzzg_ = context.Operators.Distinct<EventDefinition>(kzzf_);
        EventDefinition kzzh_ = context.Operators.SingletonFrom<EventDefinition>(kzzg_);

        return kzzh_;
    }


    [CqlExpressionDefinition("EvidenceResource")]
    public Evidence EvidenceResource(CqlContext context, Evidence arg)
    {
        Evidence[] lzzl_ = [
            arg,
        ];
        Evidence lzzm_(Evidence a)
        {
            FhirUri lzzq_ = a?.UrlElement;
            List<Identifier> lzzr_ = a?.Identifier;
            FhirString lzzs_ = a?.VersionElement;
            FhirString lzzt_ = a?.NameElement;
            FhirString lzzu_ = a?.TitleElement;
            FhirString lzzv_ = a?.ShortTitleElement;
            FhirString lzzw_ = a?.SubtitleElement;
            Code<PublicationStatus> lzzx_ = a?.StatusElement;
            FhirDateTime lzzy_ = a?.DateElement;
            FhirString lzzz_ = a?.PublisherElement;
            List<ContactDetail> mzza_ = a?.Contact;
            Markdown mzzb_ = a?.DescriptionElement;
            List<Annotation> mzzc_ = a?.Note;
            List<UsageContext> mzzd_ = a?.UseContext;
            List<CodeableConcept> mzze_ = a?.Jurisdiction;
            Markdown mzzf_ = a?.CopyrightElement;
            Date mzzg_ = a?.ApprovalDateElement;
            Date mzzh_ = a?.LastReviewDateElement;
            Period mzzi_ = a?.EffectivePeriod;
            List<CodeableConcept> mzzj_ = a?.Topic;
            List<ContactDetail> mzzk_ = a?.Author;
            List<ContactDetail> mzzl_ = a?.Editor;
            List<ContactDetail> mzzm_ = a?.Reviewer;
            List<ContactDetail> mzzn_ = a?.Endorser;
            List<RelatedArtifact> mzzo_ = a?.RelatedArtifact;
            ResourceReference mzzp_ = a?.ExposureBackground;
            List<ResourceReference> mzzq_ = a?.ExposureVariant;
            List<ResourceReference> mzzr_ = a?.Outcome;
            Evidence mzzs_ = new Evidence
            {
                UrlElement = lzzq_,
                Identifier = new List<Identifier>((IEnumerable<Identifier>)lzzr_),
                VersionElement = lzzs_,
                NameElement = lzzt_,
                TitleElement = lzzu_,
                ShortTitleElement = lzzv_,
                SubtitleElement = lzzw_,
                StatusElement = lzzx_,
                DateElement = lzzy_,
                PublisherElement = lzzz_,
                Contact = new List<ContactDetail>((IEnumerable<ContactDetail>)mzza_),
                DescriptionElement = mzzb_,
                Note = new List<Annotation>((IEnumerable<Annotation>)mzzc_),
                UseContext = new List<UsageContext>((IEnumerable<UsageContext>)mzzd_),
                Jurisdiction = new List<CodeableConcept>((IEnumerable<CodeableConcept>)mzze_),
                CopyrightElement = mzzf_,
                ApprovalDateElement = mzzg_,
                LastReviewDateElement = mzzh_,
                EffectivePeriod = mzzi_,
                Topic = new List<CodeableConcept>((IEnumerable<CodeableConcept>)mzzj_),
                Author = new List<ContactDetail>((IEnumerable<ContactDetail>)mzzk_),
                Editor = new List<ContactDetail>((IEnumerable<ContactDetail>)mzzl_),
                Reviewer = new List<ContactDetail>((IEnumerable<ContactDetail>)mzzm_),
                Endorser = new List<ContactDetail>((IEnumerable<ContactDetail>)mzzn_),
                RelatedArtifact = new List<RelatedArtifact>((IEnumerable<RelatedArtifact>)mzzo_),
                ExposureBackground = mzzp_,
                ExposureVariant = new List<ResourceReference>((IEnumerable<ResourceReference>)mzzq_),
                Outcome = new List<ResourceReference>((IEnumerable<ResourceReference>)mzzr_),
            };

            return mzzs_;
        };
        IEnumerable<Evidence> lzzn_ = context.Operators.Select<Evidence, Evidence>((IEnumerable<Evidence>)lzzl_, lzzm_);
        IEnumerable<Evidence> lzzo_ = context.Operators.Distinct<Evidence>(lzzn_);
        Evidence lzzp_ = context.Operators.SingletonFrom<Evidence>(lzzo_);

        return lzzp_;
    }


    [CqlExpressionDefinition("EvidenceVariableResource")]
    public EvidenceVariable EvidenceVariableResource(CqlContext context, EvidenceVariable arg)
    {
        EvidenceVariable[] mzzt_ = [
            arg,
        ];
        EvidenceVariable mzzu_(EvidenceVariable a)
        {
            FhirUri mzzy_ = a?.UrlElement;
            List<Identifier> mzzz_ = a?.Identifier;
            FhirString nzza_ = a?.VersionElement;
            FhirString nzzb_ = a?.NameElement;
            FhirString nzzc_ = a?.TitleElement;
            FhirString nzzd_ = a?.ShortTitleElement;
            FhirString nzze_ = a?.SubtitleElement;
            Code<PublicationStatus> nzzf_ = a?.StatusElement;
            FhirDateTime nzzg_ = a?.DateElement;
            FhirString nzzh_ = a?.PublisherElement;
            List<ContactDetail> nzzi_ = a?.Contact;
            Markdown nzzj_ = a?.DescriptionElement;
            List<Annotation> nzzk_ = a?.Note;
            List<UsageContext> nzzl_ = a?.UseContext;
            List<CodeableConcept> nzzm_ = a?.Jurisdiction;
            Markdown nzzn_ = a?.CopyrightElement;
            Date nzzo_ = a?.ApprovalDateElement;
            Date nzzp_ = a?.LastReviewDateElement;
            Period nzzq_ = a?.EffectivePeriod;
            List<CodeableConcept> nzzr_ = a?.Topic;
            List<ContactDetail> nzzs_ = a?.Author;
            List<ContactDetail> nzzt_ = a?.Editor;
            List<ContactDetail> nzzu_ = a?.Reviewer;
            List<ContactDetail> nzzv_ = a?.Endorser;
            List<RelatedArtifact> nzzw_ = a?.RelatedArtifact;
            Code<VariableTypeCode> nzzx_ = a?.TypeElement;
            List<EvidenceVariable.CharacteristicComponent> nzzy_ = a?.Characteristic;
            EvidenceVariable nzzz_ = new EvidenceVariable
            {
                UrlElement = mzzy_,
                Identifier = new List<Identifier>((IEnumerable<Identifier>)mzzz_),
                VersionElement = nzza_,
                NameElement = nzzb_,
                TitleElement = nzzc_,
                ShortTitleElement = nzzd_,
                SubtitleElement = nzze_,
                StatusElement = nzzf_,
                DateElement = nzzg_,
                PublisherElement = nzzh_,
                Contact = new List<ContactDetail>((IEnumerable<ContactDetail>)nzzi_),
                DescriptionElement = nzzj_,
                Note = new List<Annotation>((IEnumerable<Annotation>)nzzk_),
                UseContext = new List<UsageContext>((IEnumerable<UsageContext>)nzzl_),
                Jurisdiction = new List<CodeableConcept>((IEnumerable<CodeableConcept>)nzzm_),
                CopyrightElement = nzzn_,
                ApprovalDateElement = nzzo_,
                LastReviewDateElement = nzzp_,
                EffectivePeriod = nzzq_,
                Topic = new List<CodeableConcept>((IEnumerable<CodeableConcept>)nzzr_),
                Author = new List<ContactDetail>((IEnumerable<ContactDetail>)nzzs_),
                Editor = new List<ContactDetail>((IEnumerable<ContactDetail>)nzzt_),
                Reviewer = new List<ContactDetail>((IEnumerable<ContactDetail>)nzzu_),
                Endorser = new List<ContactDetail>((IEnumerable<ContactDetail>)nzzv_),
                RelatedArtifact = new List<RelatedArtifact>((IEnumerable<RelatedArtifact>)nzzw_),
                TypeElement = nzzx_,
                Characteristic = new List<EvidenceVariable.CharacteristicComponent>((IEnumerable<EvidenceVariable.CharacteristicComponent>)nzzy_),
            };

            return nzzz_;
        };
        IEnumerable<EvidenceVariable> mzzv_ = context.Operators.Select<EvidenceVariable, EvidenceVariable>((IEnumerable<EvidenceVariable>)mzzt_, mzzu_);
        IEnumerable<EvidenceVariable> mzzw_ = context.Operators.Distinct<EvidenceVariable>(mzzv_);
        EvidenceVariable mzzx_ = context.Operators.SingletonFrom<EvidenceVariable>(mzzw_);

        return mzzx_;
    }


    [CqlExpressionDefinition("ExplanationOfBenefitResource")]
    public ExplanationOfBenefit ExplanationOfBenefitResource(CqlContext context, ExplanationOfBenefit arg)
    {
        ExplanationOfBenefit[] ozza_ = [
            arg,
        ];
        ExplanationOfBenefit ozzb_(ExplanationOfBenefit a)
        {
            List<Identifier> ozzf_ = a?.Identifier;
            Code<ExplanationOfBenefit.ExplanationOfBenefitStatus> ozzg_ = a?.StatusElement;
            CodeableConcept ozzh_ = a?.Type;
            CodeableConcept ozzi_ = a?.SubType;
            Code<ClaimUseCode> ozzj_ = a?.UseElement;
            ResourceReference ozzk_ = a?.Patient;
            Period ozzl_ = a?.BillablePeriod;
            FhirDateTime ozzm_ = a?.CreatedElement;
            ResourceReference ozzn_ = a?.Enterer;
            ResourceReference ozzo_ = a?.Insurer;
            ResourceReference ozzp_ = a?.Provider;
            CodeableConcept ozzq_ = a?.Priority;
            CodeableConcept ozzr_ = a?.FundsReserveRequested;
            CodeableConcept ozzs_ = a?.FundsReserve;
            List<ExplanationOfBenefit.RelatedClaimComponent> ozzt_ = a?.Related;
            ResourceReference ozzu_ = a?.Prescription;
            ResourceReference ozzv_ = a?.OriginalPrescription;
            ExplanationOfBenefit.PayeeComponent ozzw_ = a?.Payee;
            ResourceReference ozzx_ = a?.Referral;
            ResourceReference ozzy_ = a?.Facility;
            ResourceReference ozzz_ = a?.Claim;
            ResourceReference pzza_ = a?.ClaimResponse;
            Code<ClaimProcessingCodes> pzzb_ = a?.OutcomeElement;
            FhirString pzzc_ = a?.DispositionElement;
            List<FhirString> pzzd_ = a?.PreAuthRefElement;
            List<Period> pzze_ = a?.PreAuthRefPeriod;
            List<ExplanationOfBenefit.CareTeamComponent> pzzf_ = a?.CareTeam;
            List<ExplanationOfBenefit.SupportingInformationComponent> pzzg_ = a?.SupportingInfo;
            List<ExplanationOfBenefit.DiagnosisComponent> pzzh_ = a?.Diagnosis;
            List<ExplanationOfBenefit.ProcedureComponent> pzzi_ = a?.Procedure;
            PositiveInt pzzj_ = a?.PrecedenceElement;
            Integer pzzk_ = context.Operators.Convert<Integer>(pzzj_);
            PositiveInt pzzl_ = context.Operators.Convert<PositiveInt>(pzzk_);
            List<ExplanationOfBenefit.InsuranceComponent> pzzm_ = a?.Insurance;
            ExplanationOfBenefit.AccidentComponent pzzn_ = a?.Accident;
            List<ExplanationOfBenefit.ItemComponent> pzzo_ = a?.Item;
            List<ExplanationOfBenefit.AddedItemComponent> pzzp_ = a?.AddItem;
            List<ExplanationOfBenefit.AdjudicationComponent> pzzq_ = a?.Adjudication;
            List<ExplanationOfBenefit.TotalComponent> pzzr_ = a?.Total;
            ExplanationOfBenefit.PaymentComponent pzzs_ = a?.Payment;
            CodeableConcept pzzt_ = a?.FormCode;
            Attachment pzzu_ = a?.Form;
            List<ExplanationOfBenefit.NoteComponent> pzzv_ = a?.ProcessNote;
            Period pzzw_ = a?.BenefitPeriod;
            List<ExplanationOfBenefit.BenefitBalanceComponent> pzzx_ = a?.BenefitBalance;
            ExplanationOfBenefit pzzy_ = new ExplanationOfBenefit
            {
                Identifier = new List<Identifier>((IEnumerable<Identifier>)ozzf_),
                StatusElement = ozzg_,
                Type = ozzh_,
                SubType = ozzi_,
                UseElement = ozzj_,
                Patient = ozzk_,
                BillablePeriod = ozzl_,
                CreatedElement = ozzm_,
                Enterer = ozzn_,
                Insurer = ozzo_,
                Provider = ozzp_,
                Priority = ozzq_,
                FundsReserveRequested = ozzr_,
                FundsReserve = ozzs_,
                Related = new List<ExplanationOfBenefit.RelatedClaimComponent>((IEnumerable<ExplanationOfBenefit.RelatedClaimComponent>)ozzt_),
                Prescription = ozzu_,
                OriginalPrescription = ozzv_,
                Payee = ozzw_,
                Referral = ozzx_,
                Facility = ozzy_,
                Claim = ozzz_,
                ClaimResponse = pzza_,
                OutcomeElement = pzzb_,
                DispositionElement = pzzc_,
                PreAuthRefElement = new List<FhirString>((IEnumerable<FhirString>)pzzd_),
                PreAuthRefPeriod = new List<Period>((IEnumerable<Period>)pzze_),
                CareTeam = new List<ExplanationOfBenefit.CareTeamComponent>((IEnumerable<ExplanationOfBenefit.CareTeamComponent>)pzzf_),
                SupportingInfo = new List<ExplanationOfBenefit.SupportingInformationComponent>((IEnumerable<ExplanationOfBenefit.SupportingInformationComponent>)pzzg_),
                Diagnosis = new List<ExplanationOfBenefit.DiagnosisComponent>((IEnumerable<ExplanationOfBenefit.DiagnosisComponent>)pzzh_),
                Procedure = new List<ExplanationOfBenefit.ProcedureComponent>((IEnumerable<ExplanationOfBenefit.ProcedureComponent>)pzzi_),
                PrecedenceElement = pzzl_,
                Insurance = new List<ExplanationOfBenefit.InsuranceComponent>((IEnumerable<ExplanationOfBenefit.InsuranceComponent>)pzzm_),
                Accident = pzzn_,
                Item = new List<ExplanationOfBenefit.ItemComponent>((IEnumerable<ExplanationOfBenefit.ItemComponent>)pzzo_),
                AddItem = new List<ExplanationOfBenefit.AddedItemComponent>((IEnumerable<ExplanationOfBenefit.AddedItemComponent>)pzzp_),
                Adjudication = new List<ExplanationOfBenefit.AdjudicationComponent>((IEnumerable<ExplanationOfBenefit.AdjudicationComponent>)pzzq_),
                Total = new List<ExplanationOfBenefit.TotalComponent>((IEnumerable<ExplanationOfBenefit.TotalComponent>)pzzr_),
                Payment = pzzs_,
                FormCode = pzzt_,
                Form = pzzu_,
                ProcessNote = new List<ExplanationOfBenefit.NoteComponent>((IEnumerable<ExplanationOfBenefit.NoteComponent>)pzzv_),
                BenefitPeriod = pzzw_,
                BenefitBalance = new List<ExplanationOfBenefit.BenefitBalanceComponent>((IEnumerable<ExplanationOfBenefit.BenefitBalanceComponent>)pzzx_),
            };

            return pzzy_;
        };
        IEnumerable<ExplanationOfBenefit> ozzc_ = context.Operators.Select<ExplanationOfBenefit, ExplanationOfBenefit>((IEnumerable<ExplanationOfBenefit>)ozza_, ozzb_);
        IEnumerable<ExplanationOfBenefit> ozzd_ = context.Operators.Distinct<ExplanationOfBenefit>(ozzc_);
        ExplanationOfBenefit ozze_ = context.Operators.SingletonFrom<ExplanationOfBenefit>(ozzd_);

        return ozze_;
    }


    [CqlExpressionDefinition("FamilyMemberHistoryResource")]
    public FamilyMemberHistory FamilyMemberHistoryResource(CqlContext context, FamilyMemberHistory arg)
    {
        FamilyMemberHistory[] pzzz_ = [
            arg,
        ];
        FamilyMemberHistory qzza_(FamilyMemberHistory a)
        {
            List<Identifier> qzze_ = a?.Identifier;
            List<Canonical> qzzf_ = a?.InstantiatesCanonicalElement;
            List<FhirUri> qzzg_ = a?.InstantiatesUriElement;
            Code<FamilyMemberHistory.FamilyHistoryStatus> qzzh_ = a?.StatusElement;
            CodeableConcept qzzi_ = a?.DataAbsentReason;
            ResourceReference qzzj_ = a?.Patient;
            FhirDateTime qzzk_ = a?.DateElement;
            FhirString qzzl_ = a?.NameElement;
            CodeableConcept qzzm_ = a?.Relationship;
            CodeableConcept qzzn_ = a?.Sex;
            DataType qzzo_ = a?.Born;
            DataType qzzp_ = a?.Age;
            FhirBoolean qzzq_ = a?.EstimatedAgeElement;
            DataType qzzr_ = a?.Deceased;
            List<CodeableConcept> qzzs_ = a?.ReasonCode;
            List<ResourceReference> qzzt_ = a?.ReasonReference;
            List<Annotation> qzzu_ = a?.Note;
            List<FamilyMemberHistory.ConditionComponent> qzzv_ = a?.Condition;
            FamilyMemberHistory qzzw_ = new FamilyMemberHistory
            {
                Identifier = new List<Identifier>((IEnumerable<Identifier>)qzze_),
                InstantiatesCanonicalElement = new List<Canonical>((IEnumerable<Canonical>)qzzf_),
                InstantiatesUriElement = new List<FhirUri>((IEnumerable<FhirUri>)qzzg_),
                StatusElement = qzzh_,
                DataAbsentReason = qzzi_,
                Patient = qzzj_,
                DateElement = qzzk_,
                NameElement = qzzl_,
                Relationship = qzzm_,
                Sex = qzzn_,
                Born = (DataType)qzzo_,
                Age = (DataType)qzzp_,
                EstimatedAgeElement = qzzq_,
                Deceased = (DataType)qzzr_,
                ReasonCode = new List<CodeableConcept>((IEnumerable<CodeableConcept>)qzzs_),
                ReasonReference = new List<ResourceReference>((IEnumerable<ResourceReference>)qzzt_),
                Note = new List<Annotation>((IEnumerable<Annotation>)qzzu_),
                Condition = new List<FamilyMemberHistory.ConditionComponent>((IEnumerable<FamilyMemberHistory.ConditionComponent>)qzzv_),
            };

            return qzzw_;
        };
        IEnumerable<FamilyMemberHistory> qzzb_ = context.Operators.Select<FamilyMemberHistory, FamilyMemberHistory>((IEnumerable<FamilyMemberHistory>)pzzz_, qzza_);
        IEnumerable<FamilyMemberHistory> qzzc_ = context.Operators.Distinct<FamilyMemberHistory>(qzzb_);
        FamilyMemberHistory qzzd_ = context.Operators.SingletonFrom<FamilyMemberHistory>(qzzc_);

        return qzzd_;
    }


    [CqlExpressionDefinition("FlagResource")]
    public Flag FlagResource(CqlContext context, Flag arg)
    {
        Flag[] qzzx_ = [
            arg,
        ];
        Flag qzzy_(Flag a)
        {
            List<Identifier> rzzc_ = a?.Identifier;
            Code<Flag.FlagStatus> rzzd_ = a?.StatusElement;
            List<CodeableConcept> rzze_ = a?.Category;
            CodeableConcept rzzf_ = a?.Code;
            ResourceReference rzzg_ = a?.Subject;
            Period rzzh_ = a?.Period;
            ResourceReference rzzi_ = a?.Encounter;
            ResourceReference rzzj_ = a?.Author;
            Flag rzzk_ = new Flag
            {
                Identifier = new List<Identifier>((IEnumerable<Identifier>)rzzc_),
                StatusElement = rzzd_,
                Category = new List<CodeableConcept>((IEnumerable<CodeableConcept>)rzze_),
                Code = rzzf_,
                Subject = rzzg_,
                Period = rzzh_,
                Encounter = rzzi_,
                Author = rzzj_,
            };

            return rzzk_;
        };
        IEnumerable<Flag> qzzz_ = context.Operators.Select<Flag, Flag>((IEnumerable<Flag>)qzzx_, qzzy_);
        IEnumerable<Flag> rzza_ = context.Operators.Distinct<Flag>(qzzz_);
        Flag rzzb_ = context.Operators.SingletonFrom<Flag>(rzza_);

        return rzzb_;
    }


    [CqlExpressionDefinition("GoalResource")]
    public Goal GoalResource(CqlContext context, Goal arg)
    {
        Goal[] rzzl_ = [
            arg,
        ];
        Goal rzzm_(Goal a)
        {
            List<Identifier> rzzq_ = a?.Identifier;
            Code<Goal.GoalLifecycleStatus> rzzr_ = a?.LifecycleStatusElement;
            CodeableConcept rzzs_ = a?.AchievementStatus;
            List<CodeableConcept> rzzt_ = a?.Category;
            CodeableConcept rzzu_ = a?.Priority;
            CodeableConcept rzzv_ = a?.Description;
            ResourceReference rzzw_ = a?.Subject;
            DataType rzzx_ = a?.Start;
            List<Goal.TargetComponent> rzzy_ = a?.Target;
            Date rzzz_ = a?.StatusDateElement;
            FhirString szza_ = a?.StatusReasonElement;
            ResourceReference szzb_ = a?.ExpressedBy;
            List<ResourceReference> szzc_ = a?.Addresses;
            List<Annotation> szzd_ = a?.Note;
            List<CodeableConcept> szze_ = a?.OutcomeCode;
            List<ResourceReference> szzf_ = a?.OutcomeReference;
            Goal szzg_ = new Goal
            {
                Identifier = new List<Identifier>((IEnumerable<Identifier>)rzzq_),
                LifecycleStatusElement = rzzr_,
                AchievementStatus = rzzs_,
                Category = new List<CodeableConcept>((IEnumerable<CodeableConcept>)rzzt_),
                Priority = rzzu_,
                Description = rzzv_,
                Subject = rzzw_,
                Start = (DataType)rzzx_,
                Target = new List<Goal.TargetComponent>((IEnumerable<Goal.TargetComponent>)rzzy_),
                StatusDateElement = rzzz_,
                StatusReasonElement = szza_,
                ExpressedBy = szzb_,
                Addresses = new List<ResourceReference>((IEnumerable<ResourceReference>)szzc_),
                Note = new List<Annotation>((IEnumerable<Annotation>)szzd_),
                OutcomeCode = new List<CodeableConcept>((IEnumerable<CodeableConcept>)szze_),
                OutcomeReference = new List<ResourceReference>((IEnumerable<ResourceReference>)szzf_),
            };

            return szzg_;
        };
        IEnumerable<Goal> rzzn_ = context.Operators.Select<Goal, Goal>((IEnumerable<Goal>)rzzl_, rzzm_);
        IEnumerable<Goal> rzzo_ = context.Operators.Distinct<Goal>(rzzn_);
        Goal rzzp_ = context.Operators.SingletonFrom<Goal>(rzzo_);

        return rzzp_;
    }


    [CqlExpressionDefinition("GroupResource")]
    public Group GroupResource(CqlContext context, Group arg)
    {
        Group[] szzh_ = [
            arg,
        ];
        Group szzi_(Group a)
        {
            List<Identifier> szzm_ = a?.Identifier;
            FhirBoolean szzn_ = a?.ActiveElement;
            Code<Group.GroupType> szzo_ = a?.TypeElement;
            FhirBoolean szzp_ = a?.ActualElement;
            CodeableConcept szzq_ = a?.Code;
            FhirString szzr_ = a?.NameElement;
            UnsignedInt szzs_ = a?.QuantityElement;
            Integer szzt_ = context.Operators.Convert<Integer>(szzs_);
            UnsignedInt szzu_ = context.Operators.Convert<UnsignedInt>(szzt_);
            ResourceReference szzv_ = a?.ManagingEntity;
            List<Group.CharacteristicComponent> szzw_ = a?.Characteristic;
            List<Group.MemberComponent> szzx_ = a?.Member;
            Group szzy_ = new Group
            {
                Identifier = new List<Identifier>((IEnumerable<Identifier>)szzm_),
                ActiveElement = szzn_,
                TypeElement = szzo_,
                ActualElement = szzp_,
                Code = szzq_,
                NameElement = szzr_,
                QuantityElement = szzu_,
                ManagingEntity = szzv_,
                Characteristic = new List<Group.CharacteristicComponent>((IEnumerable<Group.CharacteristicComponent>)szzw_),
                Member = new List<Group.MemberComponent>((IEnumerable<Group.MemberComponent>)szzx_),
            };

            return szzy_;
        };
        IEnumerable<Group> szzj_ = context.Operators.Select<Group, Group>((IEnumerable<Group>)szzh_, szzi_);
        IEnumerable<Group> szzk_ = context.Operators.Distinct<Group>(szzj_);
        Group szzl_ = context.Operators.SingletonFrom<Group>(szzk_);

        return szzl_;
    }


    [CqlExpressionDefinition("GuidanceResponseResource")]
    public GuidanceResponse GuidanceResponseResource(CqlContext context, GuidanceResponse arg)
    {
        GuidanceResponse[] szzz_ = [
            arg,
        ];
        GuidanceResponse tzza_(GuidanceResponse a)
        {
            Identifier tzze_ = a?.RequestIdentifier;
            List<Identifier> tzzf_ = a?.Identifier;
            DataType tzzg_ = a?.Module;
            Code<GuidanceResponse.GuidanceResponseStatus> tzzh_ = a?.StatusElement;
            ResourceReference tzzi_ = a?.Subject;
            ResourceReference tzzj_ = a?.Encounter;
            FhirDateTime tzzk_ = a?.OccurrenceDateTimeElement;
            ResourceReference tzzl_ = a?.Performer;
            List<CodeableConcept> tzzm_ = a?.ReasonCode;
            List<ResourceReference> tzzn_ = a?.ReasonReference;
            List<Annotation> tzzo_ = a?.Note;
            List<ResourceReference> tzzp_ = a?.EvaluationMessage;
            ResourceReference tzzq_ = a?.OutputParameters;
            ResourceReference tzzr_ = a?.Result;
            List<DataRequirement> tzzs_ = a?.DataRequirement;
            GuidanceResponse tzzt_ = new GuidanceResponse
            {
                RequestIdentifier = tzze_,
                Identifier = new List<Identifier>((IEnumerable<Identifier>)tzzf_),
                Module = (DataType)tzzg_,
                StatusElement = tzzh_,
                Subject = tzzi_,
                Encounter = tzzj_,
                OccurrenceDateTimeElement = tzzk_,
                Performer = tzzl_,
                ReasonCode = new List<CodeableConcept>((IEnumerable<CodeableConcept>)tzzm_),
                ReasonReference = new List<ResourceReference>((IEnumerable<ResourceReference>)tzzn_),
                Note = new List<Annotation>((IEnumerable<Annotation>)tzzo_),
                EvaluationMessage = new List<ResourceReference>((IEnumerable<ResourceReference>)tzzp_),
                OutputParameters = tzzq_,
                Result = tzzr_,
                DataRequirement = new List<DataRequirement>((IEnumerable<DataRequirement>)tzzs_),
            };

            return tzzt_;
        };
        IEnumerable<GuidanceResponse> tzzb_ = context.Operators.Select<GuidanceResponse, GuidanceResponse>((IEnumerable<GuidanceResponse>)szzz_, tzza_);
        IEnumerable<GuidanceResponse> tzzc_ = context.Operators.Distinct<GuidanceResponse>(tzzb_);
        GuidanceResponse tzzd_ = context.Operators.SingletonFrom<GuidanceResponse>(tzzc_);

        return tzzd_;
    }


    [CqlExpressionDefinition("HealthcareServiceResource")]
    public HealthcareService HealthcareServiceResource(CqlContext context, HealthcareService arg)
    {
        HealthcareService[] tzzu_ = [
            arg,
        ];
        HealthcareService tzzv_(HealthcareService a)
        {
            List<Identifier> tzzz_ = a?.Identifier;
            FhirBoolean uzza_ = a?.ActiveElement;
            ResourceReference uzzb_ = a?.ProvidedBy;
            List<CodeableConcept> uzzc_ = a?.Category;
            List<CodeableConcept> uzzd_ = a?.Type;
            List<CodeableConcept> uzze_ = a?.Specialty;
            List<ResourceReference> uzzf_ = a?.Location;
            FhirString uzzg_ = a?.NameElement;
            FhirString uzzh_ = a?.CommentElement;
            Markdown uzzi_ = a?.ExtraDetailsElement;
            Attachment uzzj_ = a?.Photo;
            List<ContactPoint> uzzk_ = a?.Telecom;
            List<ResourceReference> uzzl_ = a?.CoverageArea;
            List<CodeableConcept> uzzm_ = a?.ServiceProvisionCode;
            List<HealthcareService.EligibilityComponent> uzzn_ = a?.Eligibility;
            List<CodeableConcept> uzzo_ = a?.Program;
            List<CodeableConcept> uzzp_ = a?.Characteristic;
            List<CodeableConcept> uzzq_ = a?.Communication;
            List<CodeableConcept> uzzr_ = a?.ReferralMethod;
            FhirBoolean uzzs_ = a?.AppointmentRequiredElement;
            List<HealthcareService.AvailableTimeComponent> uzzt_ = a?.AvailableTime;
            List<HealthcareService.NotAvailableComponent> uzzu_ = a?.NotAvailable;
            FhirString uzzv_ = a?.AvailabilityExceptionsElement;
            List<ResourceReference> uzzw_ = a?.Endpoint;
            HealthcareService uzzx_ = new HealthcareService
            {
                Identifier = new List<Identifier>((IEnumerable<Identifier>)tzzz_),
                ActiveElement = uzza_,
                ProvidedBy = uzzb_,
                Category = new List<CodeableConcept>((IEnumerable<CodeableConcept>)uzzc_),
                Type = new List<CodeableConcept>((IEnumerable<CodeableConcept>)uzzd_),
                Specialty = new List<CodeableConcept>((IEnumerable<CodeableConcept>)uzze_),
                Location = new List<ResourceReference>((IEnumerable<ResourceReference>)uzzf_),
                NameElement = uzzg_,
                CommentElement = uzzh_,
                ExtraDetailsElement = uzzi_,
                Photo = uzzj_,
                Telecom = new List<ContactPoint>((IEnumerable<ContactPoint>)uzzk_),
                CoverageArea = new List<ResourceReference>((IEnumerable<ResourceReference>)uzzl_),
                ServiceProvisionCode = new List<CodeableConcept>((IEnumerable<CodeableConcept>)uzzm_),
                Eligibility = new List<HealthcareService.EligibilityComponent>((IEnumerable<HealthcareService.EligibilityComponent>)uzzn_),
                Program = new List<CodeableConcept>((IEnumerable<CodeableConcept>)uzzo_),
                Characteristic = new List<CodeableConcept>((IEnumerable<CodeableConcept>)uzzp_),
                Communication = new List<CodeableConcept>((IEnumerable<CodeableConcept>)uzzq_),
                ReferralMethod = new List<CodeableConcept>((IEnumerable<CodeableConcept>)uzzr_),
                AppointmentRequiredElement = uzzs_,
                AvailableTime = new List<HealthcareService.AvailableTimeComponent>((IEnumerable<HealthcareService.AvailableTimeComponent>)uzzt_),
                NotAvailable = new List<HealthcareService.NotAvailableComponent>((IEnumerable<HealthcareService.NotAvailableComponent>)uzzu_),
                AvailabilityExceptionsElement = uzzv_,
                Endpoint = new List<ResourceReference>((IEnumerable<ResourceReference>)uzzw_),
            };

            return uzzx_;
        };
        IEnumerable<HealthcareService> tzzw_ = context.Operators.Select<HealthcareService, HealthcareService>((IEnumerable<HealthcareService>)tzzu_, tzzv_);
        IEnumerable<HealthcareService> tzzx_ = context.Operators.Distinct<HealthcareService>(tzzw_);
        HealthcareService tzzy_ = context.Operators.SingletonFrom<HealthcareService>(tzzx_);

        return tzzy_;
    }


    [CqlExpressionDefinition("ImagingStudyResource")]
    public ImagingStudy ImagingStudyResource(CqlContext context, ImagingStudy arg)
    {
        ImagingStudy[] uzzy_ = [
            arg,
        ];
        ImagingStudy uzzz_(ImagingStudy a)
        {
            List<Identifier> vzzd_ = a?.Identifier;
            Code<ImagingStudy.ImagingStudyStatus> vzze_ = a?.StatusElement;
            List<Coding> vzzf_ = a?.Modality;
            ResourceReference vzzg_ = a?.Subject;
            ResourceReference vzzh_ = a?.Encounter;
            FhirDateTime vzzi_ = a?.StartedElement;
            List<ResourceReference> vzzj_ = a?.BasedOn;
            ResourceReference vzzk_ = a?.Referrer;
            List<ResourceReference> vzzl_ = a?.Interpreter;
            List<ResourceReference> vzzm_ = a?.Endpoint;
            UnsignedInt vzzn_ = a?.NumberOfSeriesElement;
            Integer vzzo_ = context.Operators.Convert<Integer>(vzzn_);
            UnsignedInt vzzp_ = context.Operators.Convert<UnsignedInt>(vzzo_);
            UnsignedInt vzzq_ = a?.NumberOfInstancesElement;
            Integer vzzr_ = context.Operators.Convert<Integer>(vzzq_);
            UnsignedInt vzzs_ = context.Operators.Convert<UnsignedInt>(vzzr_);
            ResourceReference vzzt_ = a?.ProcedureReference;
            List<CodeableConcept> vzzu_ = a?.ProcedureCode;
            ResourceReference vzzv_ = a?.Location;
            List<CodeableConcept> vzzw_ = a?.ReasonCode;
            List<ResourceReference> vzzx_ = a?.ReasonReference;
            List<Annotation> vzzy_ = a?.Note;
            FhirString vzzz_ = a?.DescriptionElement;
            List<ImagingStudy.SeriesComponent> wzza_ = a?.Series;
            ImagingStudy wzzb_ = new ImagingStudy
            {
                Identifier = new List<Identifier>((IEnumerable<Identifier>)vzzd_),
                StatusElement = vzze_,
                Modality = new List<Coding>((IEnumerable<Coding>)vzzf_),
                Subject = vzzg_,
                Encounter = vzzh_,
                StartedElement = vzzi_,
                BasedOn = new List<ResourceReference>((IEnumerable<ResourceReference>)vzzj_),
                Referrer = vzzk_,
                Interpreter = new List<ResourceReference>((IEnumerable<ResourceReference>)vzzl_),
                Endpoint = new List<ResourceReference>((IEnumerable<ResourceReference>)vzzm_),
                NumberOfSeriesElement = vzzp_,
                NumberOfInstancesElement = vzzs_,
                ProcedureReference = vzzt_,
                ProcedureCode = new List<CodeableConcept>((IEnumerable<CodeableConcept>)vzzu_),
                Location = vzzv_,
                ReasonCode = new List<CodeableConcept>((IEnumerable<CodeableConcept>)vzzw_),
                ReasonReference = new List<ResourceReference>((IEnumerable<ResourceReference>)vzzx_),
                Note = new List<Annotation>((IEnumerable<Annotation>)vzzy_),
                DescriptionElement = vzzz_,
                Series = new List<ImagingStudy.SeriesComponent>((IEnumerable<ImagingStudy.SeriesComponent>)wzza_),
            };

            return wzzb_;
        };
        IEnumerable<ImagingStudy> vzza_ = context.Operators.Select<ImagingStudy, ImagingStudy>((IEnumerable<ImagingStudy>)uzzy_, uzzz_);
        IEnumerable<ImagingStudy> vzzb_ = context.Operators.Distinct<ImagingStudy>(vzza_);
        ImagingStudy vzzc_ = context.Operators.SingletonFrom<ImagingStudy>(vzzb_);

        return vzzc_;
    }


    [CqlExpressionDefinition("ImmunizationResource")]
    public Immunization ImmunizationResource(CqlContext context, Immunization arg)
    {
        Immunization[] wzzc_ = [
            arg,
        ];
        Immunization wzzd_(Immunization a)
        {
            List<Identifier> wzzh_ = a?.Identifier;
            Code<Immunization.ImmunizationStatusCodes> wzzi_ = a?.StatusElement;
            CodeableConcept wzzj_ = a?.StatusReason;
            CodeableConcept wzzk_ = a?.VaccineCode;
            ResourceReference wzzl_ = a?.Patient;
            ResourceReference wzzm_ = a?.Encounter;
            DataType wzzn_ = a?.Occurrence;
            FhirDateTime wzzo_ = a?.RecordedElement;
            FhirBoolean wzzp_ = a?.PrimarySourceElement;
            CodeableConcept wzzq_ = a?.ReportOrigin;
            ResourceReference wzzr_ = a?.Location;
            ResourceReference wzzs_ = a?.Manufacturer;
            FhirString wzzt_ = a?.LotNumberElement;
            Date wzzu_ = a?.ExpirationDateElement;
            CodeableConcept wzzv_ = a?.Site;
            CodeableConcept wzzw_ = a?.Route;
            Quantity wzzx_ = a?.DoseQuantity;
            List<Immunization.PerformerComponent> wzzy_ = a?.Performer;
            List<Annotation> wzzz_ = a?.Note;
            List<CodeableConcept> xzza_ = a?.ReasonCode;
            List<ResourceReference> xzzb_ = a?.ReasonReference;
            FhirBoolean xzzc_ = a?.IsSubpotentElement;
            List<CodeableConcept> xzzd_ = a?.SubpotentReason;
            List<Immunization.EducationComponent> xzze_ = a?.Education;
            List<CodeableConcept> xzzf_ = a?.ProgramEligibility;
            CodeableConcept xzzg_ = a?.FundingSource;
            List<Immunization.ReactionComponent> xzzh_ = a?.Reaction;
            List<Immunization.ProtocolAppliedComponent> xzzi_ = a?.ProtocolApplied;
            Immunization xzzj_ = new Immunization
            {
                Identifier = new List<Identifier>((IEnumerable<Identifier>)wzzh_),
                StatusElement = wzzi_,
                StatusReason = wzzj_,
                VaccineCode = wzzk_,
                Patient = wzzl_,
                Encounter = wzzm_,
                Occurrence = (DataType)wzzn_,
                RecordedElement = wzzo_,
                PrimarySourceElement = wzzp_,
                ReportOrigin = wzzq_,
                Location = wzzr_,
                Manufacturer = wzzs_,
                LotNumberElement = wzzt_,
                ExpirationDateElement = wzzu_,
                Site = wzzv_,
                Route = wzzw_,
                DoseQuantity = wzzx_,
                Performer = new List<Immunization.PerformerComponent>((IEnumerable<Immunization.PerformerComponent>)wzzy_),
                Note = new List<Annotation>((IEnumerable<Annotation>)wzzz_),
                ReasonCode = new List<CodeableConcept>((IEnumerable<CodeableConcept>)xzza_),
                ReasonReference = new List<ResourceReference>((IEnumerable<ResourceReference>)xzzb_),
                IsSubpotentElement = xzzc_,
                SubpotentReason = new List<CodeableConcept>((IEnumerable<CodeableConcept>)xzzd_),
                Education = new List<Immunization.EducationComponent>((IEnumerable<Immunization.EducationComponent>)xzze_),
                ProgramEligibility = new List<CodeableConcept>((IEnumerable<CodeableConcept>)xzzf_),
                FundingSource = xzzg_,
                Reaction = new List<Immunization.ReactionComponent>((IEnumerable<Immunization.ReactionComponent>)xzzh_),
                ProtocolApplied = new List<Immunization.ProtocolAppliedComponent>((IEnumerable<Immunization.ProtocolAppliedComponent>)xzzi_),
            };

            return xzzj_;
        };
        IEnumerable<Immunization> wzze_ = context.Operators.Select<Immunization, Immunization>((IEnumerable<Immunization>)wzzc_, wzzd_);
        IEnumerable<Immunization> wzzf_ = context.Operators.Distinct<Immunization>(wzze_);
        Immunization wzzg_ = context.Operators.SingletonFrom<Immunization>(wzzf_);

        return wzzg_;
    }


    [CqlExpressionDefinition("ImmunizationEvaluationResource")]
    public ImmunizationEvaluation ImmunizationEvaluationResource(CqlContext context, ImmunizationEvaluation arg)
    {
        ImmunizationEvaluation[] xzzk_ = [
            arg,
        ];
        ImmunizationEvaluation xzzl_(ImmunizationEvaluation a)
        {
            List<Identifier> xzzp_ = a?.Identifier;
            Code<ImmunizationEvaluation.ImmunizationEvaluationStatusCodes> xzzq_ = a?.StatusElement;
            ResourceReference xzzr_ = a?.Patient;
            FhirDateTime xzzs_ = a?.DateElement;
            ResourceReference xzzt_ = a?.Authority;
            CodeableConcept xzzu_ = a?.TargetDisease;
            ResourceReference xzzv_ = a?.ImmunizationEvent;
            CodeableConcept xzzw_ = a?.DoseStatus;
            List<CodeableConcept> xzzx_ = a?.DoseStatusReason;
            FhirString xzzy_ = a?.DescriptionElement;
            FhirString xzzz_ = a?.SeriesElement;
            DataType yzza_ = a?.DoseNumber;
            DataType yzzb_ = a?.SeriesDoses;
            ImmunizationEvaluation yzzc_ = new ImmunizationEvaluation
            {
                Identifier = new List<Identifier>((IEnumerable<Identifier>)xzzp_),
                StatusElement = xzzq_,
                Patient = xzzr_,
                DateElement = xzzs_,
                Authority = xzzt_,
                TargetDisease = xzzu_,
                ImmunizationEvent = xzzv_,
                DoseStatus = xzzw_,
                DoseStatusReason = new List<CodeableConcept>((IEnumerable<CodeableConcept>)xzzx_),
                DescriptionElement = xzzy_,
                SeriesElement = xzzz_,
                DoseNumber = (DataType)yzza_,
                SeriesDoses = (DataType)yzzb_,
            };

            return yzzc_;
        };
        IEnumerable<ImmunizationEvaluation> xzzm_ = context.Operators.Select<ImmunizationEvaluation, ImmunizationEvaluation>((IEnumerable<ImmunizationEvaluation>)xzzk_, xzzl_);
        IEnumerable<ImmunizationEvaluation> xzzn_ = context.Operators.Distinct<ImmunizationEvaluation>(xzzm_);
        ImmunizationEvaluation xzzo_ = context.Operators.SingletonFrom<ImmunizationEvaluation>(xzzn_);

        return xzzo_;
    }


    [CqlExpressionDefinition("ImmunizationRecommendationResource")]
    public ImmunizationRecommendation ImmunizationRecommendationResource(CqlContext context, ImmunizationRecommendation arg)
    {
        ImmunizationRecommendation[] yzzd_ = [
            arg,
        ];
        ImmunizationRecommendation yzze_(ImmunizationRecommendation a)
        {
            List<Identifier> yzzi_ = a?.Identifier;
            ResourceReference yzzj_ = a?.Patient;
            FhirDateTime yzzk_ = a?.DateElement;
            ResourceReference yzzl_ = a?.Authority;
            List<ImmunizationRecommendation.RecommendationComponent> yzzm_ = a?.Recommendation;
            ImmunizationRecommendation yzzn_ = new ImmunizationRecommendation
            {
                Identifier = new List<Identifier>((IEnumerable<Identifier>)yzzi_),
                Patient = yzzj_,
                DateElement = yzzk_,
                Authority = yzzl_,
                Recommendation = new List<ImmunizationRecommendation.RecommendationComponent>((IEnumerable<ImmunizationRecommendation.RecommendationComponent>)yzzm_),
            };

            return yzzn_;
        };
        IEnumerable<ImmunizationRecommendation> yzzf_ = context.Operators.Select<ImmunizationRecommendation, ImmunizationRecommendation>((IEnumerable<ImmunizationRecommendation>)yzzd_, yzze_);
        IEnumerable<ImmunizationRecommendation> yzzg_ = context.Operators.Distinct<ImmunizationRecommendation>(yzzf_);
        ImmunizationRecommendation yzzh_ = context.Operators.SingletonFrom<ImmunizationRecommendation>(yzzg_);

        return yzzh_;
    }


    [CqlExpressionDefinition("InsurancePlanResource")]
    public InsurancePlan InsurancePlanResource(CqlContext context, InsurancePlan arg)
    {
        InsurancePlan[] yzzo_ = [
            arg,
        ];
        InsurancePlan yzzp_(InsurancePlan a)
        {
            List<Identifier> yzzt_ = a?.Identifier;
            Code<PublicationStatus> yzzu_ = a?.StatusElement;
            List<CodeableConcept> yzzv_ = a?.Type;
            FhirString yzzw_ = a?.NameElement;
            List<FhirString> yzzx_ = a?.AliasElement;
            Period yzzy_ = a?.Period;
            ResourceReference yzzz_ = a?.OwnedBy;
            ResourceReference zzza_ = a?.AdministeredBy;
            List<ResourceReference> zzzb_ = a?.CoverageArea;
            List<InsurancePlan.ContactComponent> zzzc_ = a?.Contact;
            List<ResourceReference> zzzd_ = a?.Endpoint;
            List<ResourceReference> zzze_ = a?.Network;
            List<InsurancePlan.CoverageComponent> zzzf_ = a?.Coverage;
            List<InsurancePlan.PlanComponent> zzzg_ = a?.Plan;
            InsurancePlan zzzh_ = new InsurancePlan
            {
                Identifier = new List<Identifier>((IEnumerable<Identifier>)yzzt_),
                StatusElement = yzzu_,
                Type = new List<CodeableConcept>((IEnumerable<CodeableConcept>)yzzv_),
                NameElement = yzzw_,
                AliasElement = new List<FhirString>((IEnumerable<FhirString>)yzzx_),
                Period = yzzy_,
                OwnedBy = yzzz_,
                AdministeredBy = zzza_,
                CoverageArea = new List<ResourceReference>((IEnumerable<ResourceReference>)zzzb_),
                Contact = new List<InsurancePlan.ContactComponent>((IEnumerable<InsurancePlan.ContactComponent>)zzzc_),
                Endpoint = new List<ResourceReference>((IEnumerable<ResourceReference>)zzzd_),
                Network = new List<ResourceReference>((IEnumerable<ResourceReference>)zzze_),
                Coverage = new List<InsurancePlan.CoverageComponent>((IEnumerable<InsurancePlan.CoverageComponent>)zzzf_),
                Plan = new List<InsurancePlan.PlanComponent>((IEnumerable<InsurancePlan.PlanComponent>)zzzg_),
            };

            return zzzh_;
        };
        IEnumerable<InsurancePlan> yzzq_ = context.Operators.Select<InsurancePlan, InsurancePlan>((IEnumerable<InsurancePlan>)yzzo_, yzzp_);
        IEnumerable<InsurancePlan> yzzr_ = context.Operators.Distinct<InsurancePlan>(yzzq_);
        InsurancePlan yzzs_ = context.Operators.SingletonFrom<InsurancePlan>(yzzr_);

        return yzzs_;
    }


    [CqlExpressionDefinition("InvoiceResource")]
    public Invoice InvoiceResource(CqlContext context, Invoice arg)
    {
        Invoice[] zzzi_ = [
            arg,
        ];
        Invoice zzzj_(Invoice a)
        {
            List<Identifier> zzzn_ = a?.Identifier;
            Code<Invoice.InvoiceStatus> zzzo_ = a?.StatusElement;
            FhirString zzzp_ = a?.CancelledReasonElement;
            CodeableConcept zzzq_ = a?.Type;
            ResourceReference zzzr_ = a?.Subject;
            ResourceReference zzzs_ = a?.Recipient;
            FhirDateTime zzzt_ = a?.DateElement;
            List<Invoice.ParticipantComponent> zzzu_ = a?.Participant;
            ResourceReference zzzv_ = a?.Issuer;
            ResourceReference zzzw_ = a?.Account;
            List<Invoice.LineItemComponent> zzzx_ = a?.LineItem;
            List<Invoice.PriceComponentComponent> zzzy_ = a?.TotalPriceComponent;
            Money zzzz_ = a?.TotalNet;
            Money azzza_ = a?.TotalGross;
            Markdown azzzb_ = a?.PaymentTermsElement;
            List<Annotation> azzzc_ = a?.Note;
            Invoice azzzd_ = new Invoice
            {
                Identifier = new List<Identifier>((IEnumerable<Identifier>)zzzn_),
                StatusElement = zzzo_,
                CancelledReasonElement = zzzp_,
                Type = zzzq_,
                Subject = zzzr_,
                Recipient = zzzs_,
                DateElement = zzzt_,
                Participant = new List<Invoice.ParticipantComponent>((IEnumerable<Invoice.ParticipantComponent>)zzzu_),
                Issuer = zzzv_,
                Account = zzzw_,
                LineItem = new List<Invoice.LineItemComponent>((IEnumerable<Invoice.LineItemComponent>)zzzx_),
                TotalPriceComponent = new List<Invoice.PriceComponentComponent>((IEnumerable<Invoice.PriceComponentComponent>)zzzy_),
                TotalNet = zzzz_,
                TotalGross = azzza_,
                PaymentTermsElement = azzzb_,
                Note = new List<Annotation>((IEnumerable<Annotation>)azzzc_),
            };

            return azzzd_;
        };
        IEnumerable<Invoice> zzzk_ = context.Operators.Select<Invoice, Invoice>((IEnumerable<Invoice>)zzzi_, zzzj_);
        IEnumerable<Invoice> zzzl_ = context.Operators.Distinct<Invoice>(zzzk_);
        Invoice zzzm_ = context.Operators.SingletonFrom<Invoice>(zzzl_);

        return zzzm_;
    }


    [CqlExpressionDefinition("LibraryResource")]
    public Library LibraryResource(CqlContext context, Library arg)
    {
        Library[] azzze_ = [
            arg,
        ];
        Library azzzf_(Library a)
        {
            FhirUri azzzj_ = a?.UrlElement;
            List<Identifier> azzzk_ = a?.Identifier;
            FhirString azzzl_ = a?.VersionElement;
            FhirString azzzm_ = a?.NameElement;
            FhirString azzzn_ = a?.TitleElement;
            FhirString azzzo_ = a?.SubtitleElement;
            Code<PublicationStatus> azzzp_ = a?.StatusElement;
            FhirBoolean azzzq_ = a?.ExperimentalElement;
            CodeableConcept azzzr_ = a?.Type;
            DataType azzzs_ = a?.Subject;
            FhirDateTime azzzt_ = a?.DateElement;
            FhirString azzzu_ = a?.PublisherElement;
            List<ContactDetail> azzzv_ = a?.Contact;
            Markdown azzzw_ = a?.DescriptionElement;
            List<UsageContext> azzzx_ = a?.UseContext;
            List<CodeableConcept> azzzy_ = a?.Jurisdiction;
            Markdown azzzz_ = a?.PurposeElement;
            FhirString bzzza_ = a?.UsageElement;
            Markdown bzzzb_ = a?.CopyrightElement;
            Date bzzzc_ = a?.ApprovalDateElement;
            Date bzzzd_ = a?.LastReviewDateElement;
            Period bzzze_ = a?.EffectivePeriod;
            List<CodeableConcept> bzzzf_ = a?.Topic;
            List<ContactDetail> bzzzg_ = a?.Author;
            List<ContactDetail> bzzzh_ = a?.Editor;
            List<ContactDetail> bzzzi_ = a?.Reviewer;
            List<ContactDetail> bzzzj_ = a?.Endorser;
            List<RelatedArtifact> bzzzk_ = a?.RelatedArtifact;
            List<ParameterDefinition> bzzzl_ = a?.Parameter;
            List<DataRequirement> bzzzm_ = a?.DataRequirement;
            List<Attachment> bzzzn_ = a?.Content;
            Library bzzzo_ = new Library
            {
                UrlElement = azzzj_,
                Identifier = new List<Identifier>((IEnumerable<Identifier>)azzzk_),
                VersionElement = azzzl_,
                NameElement = azzzm_,
                TitleElement = azzzn_,
                SubtitleElement = azzzo_,
                StatusElement = azzzp_,
                ExperimentalElement = azzzq_,
                Type = azzzr_,
                Subject = (DataType)azzzs_,
                DateElement = azzzt_,
                PublisherElement = azzzu_,
                Contact = new List<ContactDetail>((IEnumerable<ContactDetail>)azzzv_),
                DescriptionElement = azzzw_,
                UseContext = new List<UsageContext>((IEnumerable<UsageContext>)azzzx_),
                Jurisdiction = new List<CodeableConcept>((IEnumerable<CodeableConcept>)azzzy_),
                PurposeElement = azzzz_,
                UsageElement = bzzza_,
                CopyrightElement = bzzzb_,
                ApprovalDateElement = bzzzc_,
                LastReviewDateElement = bzzzd_,
                EffectivePeriod = bzzze_,
                Topic = new List<CodeableConcept>((IEnumerable<CodeableConcept>)bzzzf_),
                Author = new List<ContactDetail>((IEnumerable<ContactDetail>)bzzzg_),
                Editor = new List<ContactDetail>((IEnumerable<ContactDetail>)bzzzh_),
                Reviewer = new List<ContactDetail>((IEnumerable<ContactDetail>)bzzzi_),
                Endorser = new List<ContactDetail>((IEnumerable<ContactDetail>)bzzzj_),
                RelatedArtifact = new List<RelatedArtifact>((IEnumerable<RelatedArtifact>)bzzzk_),
                Parameter = new List<ParameterDefinition>((IEnumerable<ParameterDefinition>)bzzzl_),
                DataRequirement = new List<DataRequirement>((IEnumerable<DataRequirement>)bzzzm_),
                Content = new List<Attachment>((IEnumerable<Attachment>)bzzzn_),
            };

            return bzzzo_;
        };
        IEnumerable<Library> azzzg_ = context.Operators.Select<Library, Library>((IEnumerable<Library>)azzze_, azzzf_);
        IEnumerable<Library> azzzh_ = context.Operators.Distinct<Library>(azzzg_);
        Library azzzi_ = context.Operators.SingletonFrom<Library>(azzzh_);

        return azzzi_;
    }


    [CqlExpressionDefinition("LinkageResource")]
    public Linkage LinkageResource(CqlContext context, Linkage arg)
    {
        Linkage[] bzzzp_ = [
            arg,
        ];
        Linkage bzzzq_(Linkage a)
        {
            FhirBoolean bzzzu_ = a?.ActiveElement;
            ResourceReference bzzzv_ = a?.Author;
            List<Linkage.ItemComponent> bzzzw_ = a?.Item;
            Linkage bzzzx_ = new Linkage
            {
                ActiveElement = bzzzu_,
                Author = bzzzv_,
                Item = new List<Linkage.ItemComponent>((IEnumerable<Linkage.ItemComponent>)bzzzw_),
            };

            return bzzzx_;
        };
        IEnumerable<Linkage> bzzzr_ = context.Operators.Select<Linkage, Linkage>((IEnumerable<Linkage>)bzzzp_, bzzzq_);
        IEnumerable<Linkage> bzzzs_ = context.Operators.Distinct<Linkage>(bzzzr_);
        Linkage bzzzt_ = context.Operators.SingletonFrom<Linkage>(bzzzs_);

        return bzzzt_;
    }


    [CqlExpressionDefinition("LocationResource")]
    public Location LocationResource(CqlContext context, Location arg)
    {
        Location[] bzzzy_ = [
            arg,
        ];
        Location bzzzz_(Location a)
        {
            List<Identifier> czzzd_ = a?.Identifier;
            Code<Location.LocationStatus> czzze_ = a?.StatusElement;
            Coding czzzf_ = a?.OperationalStatus;
            FhirString czzzg_ = a?.NameElement;
            List<FhirString> czzzh_ = a?.AliasElement;
            FhirString czzzi_ = a?.DescriptionElement;
            Code<Location.LocationMode> czzzj_ = a?.ModeElement;
            List<CodeableConcept> czzzk_ = a?.Type;
            List<ContactPoint> czzzl_ = a?.Telecom;
            Address czzzm_ = a?.Address;
            CodeableConcept czzzn_ = a?.PhysicalType;
            Location.PositionComponent czzzo_ = a?.Position;
            ResourceReference czzzp_ = a?.ManagingOrganization;
            ResourceReference czzzq_ = a?.PartOf;
            List<Location.HoursOfOperationComponent> czzzr_ = a?.HoursOfOperation;
            FhirString czzzs_ = a?.AvailabilityExceptionsElement;
            List<ResourceReference> czzzt_ = a?.Endpoint;
            Location czzzu_ = new Location
            {
                Identifier = new List<Identifier>((IEnumerable<Identifier>)czzzd_),
                StatusElement = czzze_,
                OperationalStatus = czzzf_,
                NameElement = czzzg_,
                AliasElement = new List<FhirString>((IEnumerable<FhirString>)czzzh_),
                DescriptionElement = czzzi_,
                ModeElement = czzzj_,
                Type = new List<CodeableConcept>((IEnumerable<CodeableConcept>)czzzk_),
                Telecom = new List<ContactPoint>((IEnumerable<ContactPoint>)czzzl_),
                Address = czzzm_,
                PhysicalType = czzzn_,
                Position = czzzo_,
                ManagingOrganization = czzzp_,
                PartOf = czzzq_,
                HoursOfOperation = new List<Location.HoursOfOperationComponent>((IEnumerable<Location.HoursOfOperationComponent>)czzzr_),
                AvailabilityExceptionsElement = czzzs_,
                Endpoint = new List<ResourceReference>((IEnumerable<ResourceReference>)czzzt_),
            };

            return czzzu_;
        };
        IEnumerable<Location> czzza_ = context.Operators.Select<Location, Location>((IEnumerable<Location>)bzzzy_, bzzzz_);
        IEnumerable<Location> czzzb_ = context.Operators.Distinct<Location>(czzza_);
        Location czzzc_ = context.Operators.SingletonFrom<Location>(czzzb_);

        return czzzc_;
    }


    [CqlExpressionDefinition("MeasureResource")]
    public Measure MeasureResource(CqlContext context, Measure arg)
    {
        Measure[] czzzv_ = [
            arg,
        ];
        Measure czzzw_(Measure a)
        {
            FhirUri dzzza_ = a?.UrlElement;
            List<Identifier> dzzzb_ = a?.Identifier;
            FhirString dzzzc_ = a?.VersionElement;
            FhirString dzzzd_ = a?.NameElement;
            FhirString dzzze_ = a?.TitleElement;
            FhirString dzzzf_ = a?.SubtitleElement;
            Code<PublicationStatus> dzzzg_ = a?.StatusElement;
            FhirBoolean dzzzh_ = a?.ExperimentalElement;
            DataType dzzzi_ = a?.Subject;
            FhirDateTime dzzzj_ = a?.DateElement;
            FhirString dzzzk_ = a?.PublisherElement;
            List<ContactDetail> dzzzl_ = a?.Contact;
            Markdown dzzzm_ = a?.DescriptionElement;
            List<UsageContext> dzzzn_ = a?.UseContext;
            List<CodeableConcept> dzzzo_ = a?.Jurisdiction;
            Markdown dzzzp_ = a?.PurposeElement;
            FhirString dzzzq_ = a?.UsageElement;
            Markdown dzzzr_ = a?.CopyrightElement;
            Date dzzzs_ = a?.ApprovalDateElement;
            Date dzzzt_ = a?.LastReviewDateElement;
            Period dzzzu_ = a?.EffectivePeriod;
            List<CodeableConcept> dzzzv_ = a?.Topic;
            List<ContactDetail> dzzzw_ = a?.Author;
            List<ContactDetail> dzzzx_ = a?.Editor;
            List<ContactDetail> dzzzy_ = a?.Reviewer;
            List<ContactDetail> dzzzz_ = a?.Endorser;
            List<RelatedArtifact> ezzza_ = a?.RelatedArtifact;
            List<Canonical> ezzzb_ = a?.LibraryElement;
            Markdown ezzzc_ = a?.DisclaimerElement;
            CodeableConcept ezzzd_ = a?.Scoring;
            CodeableConcept ezzze_ = a?.CompositeScoring;
            List<CodeableConcept> ezzzf_ = a?.Type;
            FhirString ezzzg_ = a?.RiskAdjustmentElement;
            FhirString ezzzh_ = a?.RateAggregationElement;
            Markdown ezzzi_ = a?.RationaleElement;
            Markdown ezzzj_ = a?.ClinicalRecommendationStatementElement;
            CodeableConcept ezzzk_ = a?.ImprovementNotation;
            List<Markdown> ezzzl_ = a?.DefinitionElement;
            Markdown ezzzm_ = a?.GuidanceElement;
            List<Measure.GroupComponent> ezzzn_ = a?.Group;
            List<Measure.SupplementalDataComponent> ezzzo_ = a?.SupplementalData;
            Measure ezzzp_ = new Measure
            {
                UrlElement = dzzza_,
                Identifier = new List<Identifier>((IEnumerable<Identifier>)dzzzb_),
                VersionElement = dzzzc_,
                NameElement = dzzzd_,
                TitleElement = dzzze_,
                SubtitleElement = dzzzf_,
                StatusElement = dzzzg_,
                ExperimentalElement = dzzzh_,
                Subject = (DataType)dzzzi_,
                DateElement = dzzzj_,
                PublisherElement = dzzzk_,
                Contact = new List<ContactDetail>((IEnumerable<ContactDetail>)dzzzl_),
                DescriptionElement = dzzzm_,
                UseContext = new List<UsageContext>((IEnumerable<UsageContext>)dzzzn_),
                Jurisdiction = new List<CodeableConcept>((IEnumerable<CodeableConcept>)dzzzo_),
                PurposeElement = dzzzp_,
                UsageElement = dzzzq_,
                CopyrightElement = dzzzr_,
                ApprovalDateElement = dzzzs_,
                LastReviewDateElement = dzzzt_,
                EffectivePeriod = dzzzu_,
                Topic = new List<CodeableConcept>((IEnumerable<CodeableConcept>)dzzzv_),
                Author = new List<ContactDetail>((IEnumerable<ContactDetail>)dzzzw_),
                Editor = new List<ContactDetail>((IEnumerable<ContactDetail>)dzzzx_),
                Reviewer = new List<ContactDetail>((IEnumerable<ContactDetail>)dzzzy_),
                Endorser = new List<ContactDetail>((IEnumerable<ContactDetail>)dzzzz_),
                RelatedArtifact = new List<RelatedArtifact>((IEnumerable<RelatedArtifact>)ezzza_),
                LibraryElement = new List<Canonical>((IEnumerable<Canonical>)ezzzb_),
                DisclaimerElement = ezzzc_,
                Scoring = ezzzd_,
                CompositeScoring = ezzze_,
                Type = new List<CodeableConcept>((IEnumerable<CodeableConcept>)ezzzf_),
                RiskAdjustmentElement = ezzzg_,
                RateAggregationElement = ezzzh_,
                RationaleElement = ezzzi_,
                ClinicalRecommendationStatementElement = ezzzj_,
                ImprovementNotation = ezzzk_,
                DefinitionElement = new List<Markdown>((IEnumerable<Markdown>)ezzzl_),
                GuidanceElement = ezzzm_,
                Group = new List<Measure.GroupComponent>((IEnumerable<Measure.GroupComponent>)ezzzn_),
                SupplementalData = new List<Measure.SupplementalDataComponent>((IEnumerable<Measure.SupplementalDataComponent>)ezzzo_),
            };

            return ezzzp_;
        };
        IEnumerable<Measure> czzzx_ = context.Operators.Select<Measure, Measure>((IEnumerable<Measure>)czzzv_, czzzw_);
        IEnumerable<Measure> czzzy_ = context.Operators.Distinct<Measure>(czzzx_);
        Measure czzzz_ = context.Operators.SingletonFrom<Measure>(czzzy_);

        return czzzz_;
    }


    [CqlExpressionDefinition("MeasureReportResource")]
    public MeasureReport MeasureReportResource(CqlContext context, MeasureReport arg)
    {
        MeasureReport[] ezzzq_ = [
            arg,
        ];
        MeasureReport ezzzr_(MeasureReport a)
        {
            List<Identifier> ezzzv_ = a?.Identifier;
            Code<MeasureReport.MeasureReportStatus> ezzzw_ = a?.StatusElement;
            Code<MeasureReport.MeasureReportType> ezzzx_ = a?.TypeElement;
            Canonical ezzzy_ = a?.MeasureElement;
            ResourceReference ezzzz_ = a?.Subject;
            FhirDateTime fzzza_ = a?.DateElement;
            ResourceReference fzzzb_ = a?.Reporter;
            Period fzzzc_ = a?.Period;
            CodeableConcept fzzzd_ = a?.ImprovementNotation;
            List<MeasureReport.GroupComponent> fzzze_ = a?.Group;
            List<ResourceReference> fzzzf_ = a?.EvaluatedResource;
            MeasureReport fzzzg_ = new MeasureReport
            {
                Identifier = new List<Identifier>((IEnumerable<Identifier>)ezzzv_),
                StatusElement = ezzzw_,
                TypeElement = ezzzx_,
                MeasureElement = ezzzy_,
                Subject = ezzzz_,
                DateElement = fzzza_,
                Reporter = fzzzb_,
                Period = fzzzc_,
                ImprovementNotation = fzzzd_,
                Group = new List<MeasureReport.GroupComponent>((IEnumerable<MeasureReport.GroupComponent>)fzzze_),
                EvaluatedResource = new List<ResourceReference>((IEnumerable<ResourceReference>)fzzzf_),
            };

            return fzzzg_;
        };
        IEnumerable<MeasureReport> ezzzs_ = context.Operators.Select<MeasureReport, MeasureReport>((IEnumerable<MeasureReport>)ezzzq_, ezzzr_);
        IEnumerable<MeasureReport> ezzzt_ = context.Operators.Distinct<MeasureReport>(ezzzs_);
        MeasureReport ezzzu_ = context.Operators.SingletonFrom<MeasureReport>(ezzzt_);

        return ezzzu_;
    }


    [CqlExpressionDefinition("MedicationResource")]
    public Medication MedicationResource(CqlContext context, Medication arg)
    {
        Medication[] fzzzh_ = [
            arg,
        ];
        Medication fzzzi_(Medication a)
        {
            List<Identifier> fzzzm_ = a?.Identifier;
            CodeableConcept fzzzn_ = a?.Code;
            Code<Medication.MedicationStatusCodes> fzzzo_ = a?.StatusElement;
            ResourceReference fzzzp_ = a?.Manufacturer;
            CodeableConcept fzzzq_ = a?.Form;
            Ratio fzzzr_ = a?.Amount;
            List<Medication.IngredientComponent> fzzzs_ = a?.Ingredient;
            Medication.BatchComponent fzzzt_ = a?.Batch;
            Medication fzzzu_ = new Medication
            {
                Identifier = new List<Identifier>((IEnumerable<Identifier>)fzzzm_),
                Code = fzzzn_,
                StatusElement = fzzzo_,
                Manufacturer = fzzzp_,
                Form = fzzzq_,
                Amount = fzzzr_,
                Ingredient = new List<Medication.IngredientComponent>((IEnumerable<Medication.IngredientComponent>)fzzzs_),
                Batch = fzzzt_,
            };

            return fzzzu_;
        };
        IEnumerable<Medication> fzzzj_ = context.Operators.Select<Medication, Medication>((IEnumerable<Medication>)fzzzh_, fzzzi_);
        IEnumerable<Medication> fzzzk_ = context.Operators.Distinct<Medication>(fzzzj_);
        Medication fzzzl_ = context.Operators.SingletonFrom<Medication>(fzzzk_);

        return fzzzl_;
    }


    [CqlExpressionDefinition("MedicationAdministrationResource")]
    public MedicationAdministration MedicationAdministrationResource(CqlContext context, MedicationAdministration arg)
    {
        MedicationAdministration[] fzzzv_ = [
            arg,
        ];
        MedicationAdministration fzzzw_(MedicationAdministration a)
        {
            List<Identifier> gzzza_ = a?.Identifier;
            List<FhirUri> gzzzb_ = a?.InstantiatesElement;
            List<ResourceReference> gzzzc_ = a?.PartOf;
            Code<MedicationAdministration.MedicationAdministrationStatusCodes> gzzzd_ = a?.StatusElement;
            List<CodeableConcept> gzzze_ = a?.StatusReason;
            CodeableConcept gzzzf_ = a?.Category;
            DataType gzzzg_ = a?.Medication;
            ResourceReference gzzzh_ = a?.Subject;
            ResourceReference gzzzi_ = a?.Context;
            List<ResourceReference> gzzzj_ = a?.SupportingInformation;
            DataType gzzzk_ = a?.Effective;
            List<MedicationAdministration.PerformerComponent> gzzzl_ = a?.Performer;
            List<CodeableConcept> gzzzm_ = a?.ReasonCode;
            List<ResourceReference> gzzzn_ = a?.ReasonReference;
            ResourceReference gzzzo_ = a?.Request;
            List<ResourceReference> gzzzp_ = a?.Device;
            List<Annotation> gzzzq_ = a?.Note;
            MedicationAdministration.DosageComponent gzzzr_ = a?.Dosage;
            List<ResourceReference> gzzzs_ = a?.EventHistory;
            MedicationAdministration gzzzt_ = new MedicationAdministration
            {
                Identifier = new List<Identifier>((IEnumerable<Identifier>)gzzza_),
                InstantiatesElement = new List<FhirUri>((IEnumerable<FhirUri>)gzzzb_),
                PartOf = new List<ResourceReference>((IEnumerable<ResourceReference>)gzzzc_),
                StatusElement = gzzzd_,
                StatusReason = new List<CodeableConcept>((IEnumerable<CodeableConcept>)gzzze_),
                Category = gzzzf_,
                Medication = (DataType)gzzzg_,
                Subject = gzzzh_,
                Context = gzzzi_,
                SupportingInformation = new List<ResourceReference>((IEnumerable<ResourceReference>)gzzzj_),
                Effective = (DataType)gzzzk_,
                Performer = new List<MedicationAdministration.PerformerComponent>((IEnumerable<MedicationAdministration.PerformerComponent>)gzzzl_),
                ReasonCode = new List<CodeableConcept>((IEnumerable<CodeableConcept>)gzzzm_),
                ReasonReference = new List<ResourceReference>((IEnumerable<ResourceReference>)gzzzn_),
                Request = gzzzo_,
                Device = new List<ResourceReference>((IEnumerable<ResourceReference>)gzzzp_),
                Note = new List<Annotation>((IEnumerable<Annotation>)gzzzq_),
                Dosage = gzzzr_,
                EventHistory = new List<ResourceReference>((IEnumerable<ResourceReference>)gzzzs_),
            };

            return gzzzt_;
        };
        IEnumerable<MedicationAdministration> fzzzx_ = context.Operators.Select<MedicationAdministration, MedicationAdministration>((IEnumerable<MedicationAdministration>)fzzzv_, fzzzw_);
        IEnumerable<MedicationAdministration> fzzzy_ = context.Operators.Distinct<MedicationAdministration>(fzzzx_);
        MedicationAdministration fzzzz_ = context.Operators.SingletonFrom<MedicationAdministration>(fzzzy_);

        return fzzzz_;
    }


    [CqlExpressionDefinition("MedicationDispenseResource")]
    public MedicationDispense MedicationDispenseResource(CqlContext context, MedicationDispense arg)
    {
        MedicationDispense[] gzzzu_ = [
            arg,
        ];
        MedicationDispense gzzzv_(MedicationDispense a)
        {
            List<Identifier> gzzzz_ = a?.Identifier;
            List<ResourceReference> hzzza_ = a?.PartOf;
            Code<MedicationDispense.MedicationDispenseStatusCodes> hzzzb_ = a?.StatusElement;
            DataType hzzzc_ = a?.StatusReason;
            CodeableConcept hzzzd_ = a?.Category;
            DataType hzzze_ = a?.Medication;
            ResourceReference hzzzf_ = a?.Subject;
            ResourceReference hzzzg_ = a?.Context;
            List<ResourceReference> hzzzh_ = a?.SupportingInformation;
            List<MedicationDispense.PerformerComponent> hzzzi_ = a?.Performer;
            ResourceReference hzzzj_ = a?.Location;
            List<ResourceReference> hzzzk_ = a?.AuthorizingPrescription;
            CodeableConcept hzzzl_ = a?.Type;
            Quantity hzzzm_ = a?.Quantity;
            Quantity hzzzn_ = a?.DaysSupply;
            FhirDateTime hzzzo_ = a?.WhenPreparedElement;
            FhirDateTime hzzzp_ = a?.WhenHandedOverElement;
            ResourceReference hzzzq_ = a?.Destination;
            List<ResourceReference> hzzzr_ = a?.Receiver;
            List<Annotation> hzzzs_ = a?.Note;
            List<Dosage> hzzzt_ = a?.DosageInstruction;
            MedicationDispense.SubstitutionComponent hzzzu_ = a?.Substitution;
            List<ResourceReference> hzzzv_ = a?.DetectedIssue;
            List<ResourceReference> hzzzw_ = a?.EventHistory;
            MedicationDispense hzzzx_ = new MedicationDispense
            {
                Identifier = new List<Identifier>((IEnumerable<Identifier>)gzzzz_),
                PartOf = new List<ResourceReference>((IEnumerable<ResourceReference>)hzzza_),
                StatusElement = hzzzb_,
                StatusReason = (DataType)hzzzc_,
                Category = hzzzd_,
                Medication = (DataType)hzzze_,
                Subject = hzzzf_,
                Context = hzzzg_,
                SupportingInformation = new List<ResourceReference>((IEnumerable<ResourceReference>)hzzzh_),
                Performer = new List<MedicationDispense.PerformerComponent>((IEnumerable<MedicationDispense.PerformerComponent>)hzzzi_),
                Location = hzzzj_,
                AuthorizingPrescription = new List<ResourceReference>((IEnumerable<ResourceReference>)hzzzk_),
                Type = hzzzl_,
                Quantity = hzzzm_,
                DaysSupply = hzzzn_,
                WhenPreparedElement = hzzzo_,
                WhenHandedOverElement = hzzzp_,
                Destination = hzzzq_,
                Receiver = new List<ResourceReference>((IEnumerable<ResourceReference>)hzzzr_),
                Note = new List<Annotation>((IEnumerable<Annotation>)hzzzs_),
                DosageInstruction = new List<Dosage>((IEnumerable<Dosage>)hzzzt_),
                Substitution = hzzzu_,
                DetectedIssue = new List<ResourceReference>((IEnumerable<ResourceReference>)hzzzv_),
                EventHistory = new List<ResourceReference>((IEnumerable<ResourceReference>)hzzzw_),
            };

            return hzzzx_;
        };
        IEnumerable<MedicationDispense> gzzzw_ = context.Operators.Select<MedicationDispense, MedicationDispense>((IEnumerable<MedicationDispense>)gzzzu_, gzzzv_);
        IEnumerable<MedicationDispense> gzzzx_ = context.Operators.Distinct<MedicationDispense>(gzzzw_);
        MedicationDispense gzzzy_ = context.Operators.SingletonFrom<MedicationDispense>(gzzzx_);

        return gzzzy_;
    }


    [CqlExpressionDefinition("MedicationKnowledgeResource")]
    public MedicationKnowledge MedicationKnowledgeResource(CqlContext context, MedicationKnowledge arg)
    {
        MedicationKnowledge[] hzzzy_ = [
            arg,
        ];
        MedicationKnowledge hzzzz_(MedicationKnowledge a)
        {
            CodeableConcept izzzd_ = a?.Code;
            Code<MedicationKnowledge.MedicationKnowledgeStatusCodes> izzze_ = a?.StatusElement;
            ResourceReference izzzf_ = a?.Manufacturer;
            CodeableConcept izzzg_ = a?.DoseForm;
            Quantity izzzh_ = a?.Amount;
            List<FhirString> izzzi_ = a?.SynonymElement;
            List<MedicationKnowledge.RelatedMedicationKnowledgeComponent> izzzj_ = a?.RelatedMedicationKnowledge;
            List<ResourceReference> izzzk_ = a?.AssociatedMedication;
            List<CodeableConcept> izzzl_ = a?.ProductType;
            List<MedicationKnowledge.MonographComponent> izzzm_ = a?.Monograph;
            List<MedicationKnowledge.IngredientComponent> izzzn_ = a?.Ingredient;
            Markdown izzzo_ = a?.PreparationInstructionElement;
            List<CodeableConcept> izzzp_ = a?.IntendedRoute;
            List<MedicationKnowledge.CostComponent> izzzq_ = a?.Cost;
            List<MedicationKnowledge.MonitoringProgramComponent> izzzr_ = a?.MonitoringProgram;
            List<MedicationKnowledge.AdministrationGuidelinesComponent> izzzs_ = a?.AdministrationGuidelines;
            List<MedicationKnowledge.MedicineClassificationComponent> izzzt_ = a?.MedicineClassification;
            MedicationKnowledge.PackagingComponent izzzu_ = a?.Packaging;
            List<MedicationKnowledge.DrugCharacteristicComponent> izzzv_ = a?.DrugCharacteristic;
            List<ResourceReference> izzzw_ = a?.Contraindication;
            List<MedicationKnowledge.RegulatoryComponent> izzzx_ = a?.Regulatory;
            List<MedicationKnowledge.KineticsComponent> izzzy_ = a?.Kinetics;
            MedicationKnowledge izzzz_ = new MedicationKnowledge
            {
                Code = izzzd_,
                StatusElement = izzze_,
                Manufacturer = izzzf_,
                DoseForm = izzzg_,
                Amount = izzzh_,
                SynonymElement = new List<FhirString>((IEnumerable<FhirString>)izzzi_),
                RelatedMedicationKnowledge = new List<MedicationKnowledge.RelatedMedicationKnowledgeComponent>((IEnumerable<MedicationKnowledge.RelatedMedicationKnowledgeComponent>)izzzj_),
                AssociatedMedication = new List<ResourceReference>((IEnumerable<ResourceReference>)izzzk_),
                ProductType = new List<CodeableConcept>((IEnumerable<CodeableConcept>)izzzl_),
                Monograph = new List<MedicationKnowledge.MonographComponent>((IEnumerable<MedicationKnowledge.MonographComponent>)izzzm_),
                Ingredient = new List<MedicationKnowledge.IngredientComponent>((IEnumerable<MedicationKnowledge.IngredientComponent>)izzzn_),
                PreparationInstructionElement = izzzo_,
                IntendedRoute = new List<CodeableConcept>((IEnumerable<CodeableConcept>)izzzp_),
                Cost = new List<MedicationKnowledge.CostComponent>((IEnumerable<MedicationKnowledge.CostComponent>)izzzq_),
                MonitoringProgram = new List<MedicationKnowledge.MonitoringProgramComponent>((IEnumerable<MedicationKnowledge.MonitoringProgramComponent>)izzzr_),
                AdministrationGuidelines = new List<MedicationKnowledge.AdministrationGuidelinesComponent>((IEnumerable<MedicationKnowledge.AdministrationGuidelinesComponent>)izzzs_),
                MedicineClassification = new List<MedicationKnowledge.MedicineClassificationComponent>((IEnumerable<MedicationKnowledge.MedicineClassificationComponent>)izzzt_),
                Packaging = izzzu_,
                DrugCharacteristic = new List<MedicationKnowledge.DrugCharacteristicComponent>((IEnumerable<MedicationKnowledge.DrugCharacteristicComponent>)izzzv_),
                Contraindication = new List<ResourceReference>((IEnumerable<ResourceReference>)izzzw_),
                Regulatory = new List<MedicationKnowledge.RegulatoryComponent>((IEnumerable<MedicationKnowledge.RegulatoryComponent>)izzzx_),
                Kinetics = new List<MedicationKnowledge.KineticsComponent>((IEnumerable<MedicationKnowledge.KineticsComponent>)izzzy_),
            };

            return izzzz_;
        };
        IEnumerable<MedicationKnowledge> izzza_ = context.Operators.Select<MedicationKnowledge, MedicationKnowledge>((IEnumerable<MedicationKnowledge>)hzzzy_, hzzzz_);
        IEnumerable<MedicationKnowledge> izzzb_ = context.Operators.Distinct<MedicationKnowledge>(izzza_);
        MedicationKnowledge izzzc_ = context.Operators.SingletonFrom<MedicationKnowledge>(izzzb_);

        return izzzc_;
    }


    [CqlExpressionDefinition("MedicationRequestResource")]
    public MedicationRequest MedicationRequestResource(CqlContext context, MedicationRequest arg)
    {
        MedicationRequest[] jzzza_ = [
            arg,
        ];
        MedicationRequest jzzzb_(MedicationRequest a)
        {
            List<Identifier> jzzzf_ = a?.Identifier;
            Code<MedicationRequest.MedicationrequestStatus> jzzzg_ = a?.StatusElement;
            CodeableConcept jzzzh_ = a?.StatusReason;
            Code<MedicationRequest.MedicationRequestIntent> jzzzi_ = a?.IntentElement;
            List<CodeableConcept> jzzzj_ = a?.Category;
            Code<RequestPriority> jzzzk_ = a?.PriorityElement;
            FhirBoolean jzzzl_ = a?.DoNotPerformElement;
            DataType jzzzm_ = a?.Reported;
            DataType jzzzn_ = a?.Medication;
            ResourceReference jzzzo_ = a?.Subject;
            ResourceReference jzzzp_ = a?.Encounter;
            List<ResourceReference> jzzzq_ = a?.SupportingInformation;
            FhirDateTime jzzzr_ = a?.AuthoredOnElement;
            ResourceReference jzzzs_ = a?.Requester;
            ResourceReference jzzzt_ = a?.Performer;
            CodeableConcept jzzzu_ = a?.PerformerType;
            ResourceReference jzzzv_ = a?.Recorder;
            List<CodeableConcept> jzzzw_ = a?.ReasonCode;
            List<ResourceReference> jzzzx_ = a?.ReasonReference;
            List<Canonical> jzzzy_ = a?.InstantiatesCanonicalElement;
            List<FhirUri> jzzzz_ = a?.InstantiatesUriElement;
            List<ResourceReference> kzzza_ = a?.BasedOn;
            Identifier kzzzb_ = a?.GroupIdentifier;
            CodeableConcept kzzzc_ = a?.CourseOfTherapyType;
            List<ResourceReference> kzzzd_ = a?.Insurance;
            List<Annotation> kzzze_ = a?.Note;
            List<Dosage> kzzzf_ = a?.DosageInstruction;
            MedicationRequest.DispenseRequestComponent kzzzg_ = a?.DispenseRequest;
            MedicationRequest.SubstitutionComponent kzzzh_ = a?.Substitution;
            ResourceReference kzzzi_ = a?.PriorPrescription;
            List<ResourceReference> kzzzj_ = a?.DetectedIssue;
            List<ResourceReference> kzzzk_ = a?.EventHistory;
            MedicationRequest kzzzl_ = new MedicationRequest
            {
                Identifier = new List<Identifier>((IEnumerable<Identifier>)jzzzf_),
                StatusElement = jzzzg_,
                StatusReason = jzzzh_,
                IntentElement = jzzzi_,
                Category = new List<CodeableConcept>((IEnumerable<CodeableConcept>)jzzzj_),
                PriorityElement = jzzzk_,
                DoNotPerformElement = jzzzl_,
                Reported = (DataType)jzzzm_,
                Medication = (DataType)jzzzn_,
                Subject = jzzzo_,
                Encounter = jzzzp_,
                SupportingInformation = new List<ResourceReference>((IEnumerable<ResourceReference>)jzzzq_),
                AuthoredOnElement = jzzzr_,
                Requester = jzzzs_,
                Performer = jzzzt_,
                PerformerType = jzzzu_,
                Recorder = jzzzv_,
                ReasonCode = new List<CodeableConcept>((IEnumerable<CodeableConcept>)jzzzw_),
                ReasonReference = new List<ResourceReference>((IEnumerable<ResourceReference>)jzzzx_),
                InstantiatesCanonicalElement = new List<Canonical>((IEnumerable<Canonical>)jzzzy_),
                InstantiatesUriElement = new List<FhirUri>((IEnumerable<FhirUri>)jzzzz_),
                BasedOn = new List<ResourceReference>((IEnumerable<ResourceReference>)kzzza_),
                GroupIdentifier = kzzzb_,
                CourseOfTherapyType = kzzzc_,
                Insurance = new List<ResourceReference>((IEnumerable<ResourceReference>)kzzzd_),
                Note = new List<Annotation>((IEnumerable<Annotation>)kzzze_),
                DosageInstruction = new List<Dosage>((IEnumerable<Dosage>)kzzzf_),
                DispenseRequest = kzzzg_,
                Substitution = kzzzh_,
                PriorPrescription = kzzzi_,
                DetectedIssue = new List<ResourceReference>((IEnumerable<ResourceReference>)kzzzj_),
                EventHistory = new List<ResourceReference>((IEnumerable<ResourceReference>)kzzzk_),
            };

            return kzzzl_;
        };
        IEnumerable<MedicationRequest> jzzzc_ = context.Operators.Select<MedicationRequest, MedicationRequest>((IEnumerable<MedicationRequest>)jzzza_, jzzzb_);
        IEnumerable<MedicationRequest> jzzzd_ = context.Operators.Distinct<MedicationRequest>(jzzzc_);
        MedicationRequest jzzze_ = context.Operators.SingletonFrom<MedicationRequest>(jzzzd_);

        return jzzze_;
    }


    [CqlExpressionDefinition("MedicationStatementResource")]
    public MedicationStatement MedicationStatementResource(CqlContext context, MedicationStatement arg)
    {
        MedicationStatement[] kzzzm_ = [
            arg,
        ];
        MedicationStatement kzzzn_(MedicationStatement a)
        {
            List<Identifier> kzzzr_ = a?.Identifier;
            List<ResourceReference> kzzzs_ = a?.BasedOn;
            List<ResourceReference> kzzzt_ = a?.PartOf;
            Code<MedicationStatement.MedicationStatusCodes> kzzzu_ = a?.StatusElement;
            List<CodeableConcept> kzzzv_ = a?.StatusReason;
            CodeableConcept kzzzw_ = a?.Category;
            DataType kzzzx_ = a?.Medication;
            ResourceReference kzzzy_ = a?.Subject;
            ResourceReference kzzzz_ = a?.Context;
            DataType lzzza_ = a?.Effective;
            FhirDateTime lzzzb_ = a?.DateAssertedElement;
            ResourceReference lzzzc_ = a?.InformationSource;
            List<ResourceReference> lzzzd_ = a?.DerivedFrom;
            List<CodeableConcept> lzzze_ = a?.ReasonCode;
            List<ResourceReference> lzzzf_ = a?.ReasonReference;
            List<Annotation> lzzzg_ = a?.Note;
            List<Dosage> lzzzh_ = a?.Dosage;
            MedicationStatement lzzzi_ = new MedicationStatement
            {
                Identifier = new List<Identifier>((IEnumerable<Identifier>)kzzzr_),
                BasedOn = new List<ResourceReference>((IEnumerable<ResourceReference>)kzzzs_),
                PartOf = new List<ResourceReference>((IEnumerable<ResourceReference>)kzzzt_),
                StatusElement = kzzzu_,
                StatusReason = new List<CodeableConcept>((IEnumerable<CodeableConcept>)kzzzv_),
                Category = kzzzw_,
                Medication = (DataType)kzzzx_,
                Subject = kzzzy_,
                Context = kzzzz_,
                Effective = (DataType)lzzza_,
                DateAssertedElement = lzzzb_,
                InformationSource = lzzzc_,
                DerivedFrom = new List<ResourceReference>((IEnumerable<ResourceReference>)lzzzd_),
                ReasonCode = new List<CodeableConcept>((IEnumerable<CodeableConcept>)lzzze_),
                ReasonReference = new List<ResourceReference>((IEnumerable<ResourceReference>)lzzzf_),
                Note = new List<Annotation>((IEnumerable<Annotation>)lzzzg_),
                Dosage = new List<Dosage>((IEnumerable<Dosage>)lzzzh_),
            };

            return lzzzi_;
        };
        IEnumerable<MedicationStatement> kzzzo_ = context.Operators.Select<MedicationStatement, MedicationStatement>((IEnumerable<MedicationStatement>)kzzzm_, kzzzn_);
        IEnumerable<MedicationStatement> kzzzp_ = context.Operators.Distinct<MedicationStatement>(kzzzo_);
        MedicationStatement kzzzq_ = context.Operators.SingletonFrom<MedicationStatement>(kzzzp_);

        return kzzzq_;
    }


    [CqlExpressionDefinition("MedicinalProductResource")]
    public MedicinalProduct MedicinalProductResource(CqlContext context, MedicinalProduct arg)
    {
        MedicinalProduct[] lzzzj_ = [
            arg,
        ];
        MedicinalProduct lzzzk_(MedicinalProduct a)
        {
            List<Identifier> lzzzo_ = a?.Identifier;
            CodeableConcept lzzzp_ = a?.Type;
            Coding lzzzq_ = a?.Domain;
            CodeableConcept lzzzr_ = a?.CombinedPharmaceuticalDoseForm;
            CodeableConcept lzzzs_ = a?.LegalStatusOfSupply;
            CodeableConcept lzzzt_ = a?.AdditionalMonitoringIndicator;
            List<FhirString> lzzzu_ = a?.SpecialMeasuresElement;
            CodeableConcept lzzzv_ = a?.PaediatricUseIndicator;
            List<CodeableConcept> lzzzw_ = a?.ProductClassification;
            List<MarketingStatus> lzzzx_ = a?.MarketingStatus;
            List<ResourceReference> lzzzy_ = a?.PharmaceuticalProduct;
            List<ResourceReference> lzzzz_ = a?.PackagedMedicinalProduct;
            List<ResourceReference> mzzza_ = a?.AttachedDocument;
            List<ResourceReference> mzzzb_ = a?.MasterFile;
            List<ResourceReference> mzzzc_ = a?.Contact;
            List<ResourceReference> mzzzd_ = a?.ClinicalTrial;
            List<MedicinalProduct.NameComponent> mzzze_ = a?.Name;
            List<Identifier> mzzzf_ = a?.CrossReference;
            List<MedicinalProduct.ManufacturingBusinessOperationComponent> mzzzg_ = a?.ManufacturingBusinessOperation;
            List<MedicinalProduct.SpecialDesignationComponent> mzzzh_ = a?.SpecialDesignation;
            MedicinalProduct mzzzi_ = new MedicinalProduct
            {
                Identifier = new List<Identifier>((IEnumerable<Identifier>)lzzzo_),
                Type = lzzzp_,
                Domain = lzzzq_,
                CombinedPharmaceuticalDoseForm = lzzzr_,
                LegalStatusOfSupply = lzzzs_,
                AdditionalMonitoringIndicator = lzzzt_,
                SpecialMeasuresElement = new List<FhirString>((IEnumerable<FhirString>)lzzzu_),
                PaediatricUseIndicator = lzzzv_,
                ProductClassification = new List<CodeableConcept>((IEnumerable<CodeableConcept>)lzzzw_),
                MarketingStatus = new List<MarketingStatus>((IEnumerable<MarketingStatus>)lzzzx_),
                PharmaceuticalProduct = new List<ResourceReference>((IEnumerable<ResourceReference>)lzzzy_),
                PackagedMedicinalProduct = new List<ResourceReference>((IEnumerable<ResourceReference>)lzzzz_),
                AttachedDocument = new List<ResourceReference>((IEnumerable<ResourceReference>)mzzza_),
                MasterFile = new List<ResourceReference>((IEnumerable<ResourceReference>)mzzzb_),
                Contact = new List<ResourceReference>((IEnumerable<ResourceReference>)mzzzc_),
                ClinicalTrial = new List<ResourceReference>((IEnumerable<ResourceReference>)mzzzd_),
                Name = new List<MedicinalProduct.NameComponent>((IEnumerable<MedicinalProduct.NameComponent>)mzzze_),
                CrossReference = new List<Identifier>((IEnumerable<Identifier>)mzzzf_),
                ManufacturingBusinessOperation = new List<MedicinalProduct.ManufacturingBusinessOperationComponent>((IEnumerable<MedicinalProduct.ManufacturingBusinessOperationComponent>)mzzzg_),
                SpecialDesignation = new List<MedicinalProduct.SpecialDesignationComponent>((IEnumerable<MedicinalProduct.SpecialDesignationComponent>)mzzzh_),
            };

            return mzzzi_;
        };
        IEnumerable<MedicinalProduct> lzzzl_ = context.Operators.Select<MedicinalProduct, MedicinalProduct>((IEnumerable<MedicinalProduct>)lzzzj_, lzzzk_);
        IEnumerable<MedicinalProduct> lzzzm_ = context.Operators.Distinct<MedicinalProduct>(lzzzl_);
        MedicinalProduct lzzzn_ = context.Operators.SingletonFrom<MedicinalProduct>(lzzzm_);

        return lzzzn_;
    }


    [CqlExpressionDefinition("MedicinalProductAuthorizationResource")]
    public MedicinalProductAuthorization MedicinalProductAuthorizationResource(CqlContext context, MedicinalProductAuthorization arg)
    {
        MedicinalProductAuthorization[] mzzzj_ = [
            arg,
        ];
        MedicinalProductAuthorization mzzzk_(MedicinalProductAuthorization a)
        {
            List<Identifier> mzzzo_ = a?.Identifier;
            ResourceReference mzzzp_ = a?.Subject;
            List<CodeableConcept> mzzzq_ = a?.Country;
            List<CodeableConcept> mzzzr_ = a?.Jurisdiction;
            CodeableConcept mzzzs_ = a?.Status;
            FhirDateTime mzzzt_ = a?.StatusDateElement;
            FhirDateTime mzzzu_ = a?.RestoreDateElement;
            Period mzzzv_ = a?.ValidityPeriod;
            Period mzzzw_ = a?.DataExclusivityPeriod;
            FhirDateTime mzzzx_ = a?.DateOfFirstAuthorizationElement;
            FhirDateTime mzzzy_ = a?.InternationalBirthDateElement;
            CodeableConcept mzzzz_ = a?.LegalBasis;
            List<MedicinalProductAuthorization.JurisdictionalAuthorizationComponent> nzzza_ = a?.JurisdictionalAuthorization;
            ResourceReference nzzzb_ = a?.Holder;
            ResourceReference nzzzc_ = a?.Regulator;
            MedicinalProductAuthorization.ProcedureComponent nzzzd_ = a?.Procedure;
            MedicinalProductAuthorization nzzze_ = new MedicinalProductAuthorization
            {
                Identifier = new List<Identifier>((IEnumerable<Identifier>)mzzzo_),
                Subject = mzzzp_,
                Country = new List<CodeableConcept>((IEnumerable<CodeableConcept>)mzzzq_),
                Jurisdiction = new List<CodeableConcept>((IEnumerable<CodeableConcept>)mzzzr_),
                Status = mzzzs_,
                StatusDateElement = mzzzt_,
                RestoreDateElement = mzzzu_,
                ValidityPeriod = mzzzv_,
                DataExclusivityPeriod = mzzzw_,
                DateOfFirstAuthorizationElement = mzzzx_,
                InternationalBirthDateElement = mzzzy_,
                LegalBasis = mzzzz_,
                JurisdictionalAuthorization = new List<MedicinalProductAuthorization.JurisdictionalAuthorizationComponent>((IEnumerable<MedicinalProductAuthorization.JurisdictionalAuthorizationComponent>)nzzza_),
                Holder = nzzzb_,
                Regulator = nzzzc_,
                Procedure = nzzzd_,
            };

            return nzzze_;
        };
        IEnumerable<MedicinalProductAuthorization> mzzzl_ = context.Operators.Select<MedicinalProductAuthorization, MedicinalProductAuthorization>((IEnumerable<MedicinalProductAuthorization>)mzzzj_, mzzzk_);
        IEnumerable<MedicinalProductAuthorization> mzzzm_ = context.Operators.Distinct<MedicinalProductAuthorization>(mzzzl_);
        MedicinalProductAuthorization mzzzn_ = context.Operators.SingletonFrom<MedicinalProductAuthorization>(mzzzm_);

        return mzzzn_;
    }


    [CqlExpressionDefinition("MedicinalProductContraindicationResource")]
    public MedicinalProductContraindication MedicinalProductContraindicationResource(CqlContext context, MedicinalProductContraindication arg)
    {
        MedicinalProductContraindication[] nzzzf_ = [
            arg,
        ];
        MedicinalProductContraindication nzzzg_(MedicinalProductContraindication a)
        {
            List<ResourceReference> nzzzk_ = a?.Subject;
            CodeableConcept nzzzl_ = a?.Disease;
            CodeableConcept nzzzm_ = a?.DiseaseStatus;
            List<CodeableConcept> nzzzn_ = a?.Comorbidity;
            List<ResourceReference> nzzzo_ = a?.TherapeuticIndication;
            List<MedicinalProductContraindication.OtherTherapyComponent> nzzzp_ = a?.OtherTherapy;
            List<Population> nzzzq_ = a?.Population;
            MedicinalProductContraindication nzzzr_ = new MedicinalProductContraindication
            {
                Subject = new List<ResourceReference>((IEnumerable<ResourceReference>)nzzzk_),
                Disease = nzzzl_,
                DiseaseStatus = nzzzm_,
                Comorbidity = new List<CodeableConcept>((IEnumerable<CodeableConcept>)nzzzn_),
                TherapeuticIndication = new List<ResourceReference>((IEnumerable<ResourceReference>)nzzzo_),
                OtherTherapy = new List<MedicinalProductContraindication.OtherTherapyComponent>((IEnumerable<MedicinalProductContraindication.OtherTherapyComponent>)nzzzp_),
                Population = new List<Population>((IEnumerable<Population>)nzzzq_),
            };

            return nzzzr_;
        };
        IEnumerable<MedicinalProductContraindication> nzzzh_ = context.Operators.Select<MedicinalProductContraindication, MedicinalProductContraindication>((IEnumerable<MedicinalProductContraindication>)nzzzf_, nzzzg_);
        IEnumerable<MedicinalProductContraindication> nzzzi_ = context.Operators.Distinct<MedicinalProductContraindication>(nzzzh_);
        MedicinalProductContraindication nzzzj_ = context.Operators.SingletonFrom<MedicinalProductContraindication>(nzzzi_);

        return nzzzj_;
    }


    [CqlExpressionDefinition("MedicinalProductIngredientResource")]
    public MedicinalProductIngredient MedicinalProductIngredientResource(CqlContext context, MedicinalProductIngredient arg)
    {
        MedicinalProductIngredient[] nzzzs_ = [
            arg,
        ];
        MedicinalProductIngredient nzzzt_(MedicinalProductIngredient a)
        {
            Identifier nzzzx_ = a?.Identifier;
            CodeableConcept nzzzy_ = a?.Role;
            FhirBoolean nzzzz_ = a?.AllergenicIndicatorElement;
            List<ResourceReference> ozzza_ = a?.Manufacturer;
            List<MedicinalProductIngredient.SpecifiedSubstanceComponent> ozzzb_ = a?.SpecifiedSubstance;
            MedicinalProductIngredient.SubstanceComponent ozzzc_ = a?.Substance;
            MedicinalProductIngredient ozzzd_ = new MedicinalProductIngredient
            {
                Identifier = nzzzx_,
                Role = nzzzy_,
                AllergenicIndicatorElement = nzzzz_,
                Manufacturer = new List<ResourceReference>((IEnumerable<ResourceReference>)ozzza_),
                SpecifiedSubstance = new List<MedicinalProductIngredient.SpecifiedSubstanceComponent>((IEnumerable<MedicinalProductIngredient.SpecifiedSubstanceComponent>)ozzzb_),
                Substance = ozzzc_,
            };

            return ozzzd_;
        };
        IEnumerable<MedicinalProductIngredient> nzzzu_ = context.Operators.Select<MedicinalProductIngredient, MedicinalProductIngredient>((IEnumerable<MedicinalProductIngredient>)nzzzs_, nzzzt_);
        IEnumerable<MedicinalProductIngredient> nzzzv_ = context.Operators.Distinct<MedicinalProductIngredient>(nzzzu_);
        MedicinalProductIngredient nzzzw_ = context.Operators.SingletonFrom<MedicinalProductIngredient>(nzzzv_);

        return nzzzw_;
    }


    [CqlExpressionDefinition("MedicinalProductInteractionResource")]
    public MedicinalProductInteraction MedicinalProductInteractionResource(CqlContext context, MedicinalProductInteraction arg)
    {
        MedicinalProductInteraction[] ozzze_ = [
            arg,
        ];
        MedicinalProductInteraction ozzzf_(MedicinalProductInteraction a)
        {
            List<ResourceReference> ozzzj_ = a?.Subject;
            FhirString ozzzk_ = a?.DescriptionElement;
            List<MedicinalProductInteraction.InteractantComponent> ozzzl_ = a?.Interactant;
            CodeableConcept ozzzm_ = a?.Type;
            CodeableConcept ozzzn_ = a?.Effect;
            CodeableConcept ozzzo_ = a?.Incidence;
            CodeableConcept ozzzp_ = a?.Management;
            MedicinalProductInteraction ozzzq_ = new MedicinalProductInteraction
            {
                Subject = new List<ResourceReference>((IEnumerable<ResourceReference>)ozzzj_),
                DescriptionElement = ozzzk_,
                Interactant = new List<MedicinalProductInteraction.InteractantComponent>((IEnumerable<MedicinalProductInteraction.InteractantComponent>)ozzzl_),
                Type = ozzzm_,
                Effect = ozzzn_,
                Incidence = ozzzo_,
                Management = ozzzp_,
            };

            return ozzzq_;
        };
        IEnumerable<MedicinalProductInteraction> ozzzg_ = context.Operators.Select<MedicinalProductInteraction, MedicinalProductInteraction>((IEnumerable<MedicinalProductInteraction>)ozzze_, ozzzf_);
        IEnumerable<MedicinalProductInteraction> ozzzh_ = context.Operators.Distinct<MedicinalProductInteraction>(ozzzg_);
        MedicinalProductInteraction ozzzi_ = context.Operators.SingletonFrom<MedicinalProductInteraction>(ozzzh_);

        return ozzzi_;
    }


    [CqlExpressionDefinition("MedicinalProductManufacturedResource")]
    public MedicinalProductManufactured MedicinalProductManufacturedResource(CqlContext context, MedicinalProductManufactured arg)
    {
        MedicinalProductManufactured[] ozzzr_ = [
            arg,
        ];
        MedicinalProductManufactured ozzzs_(MedicinalProductManufactured a)
        {
            CodeableConcept ozzzw_ = a?.ManufacturedDoseForm;
            CodeableConcept ozzzx_ = a?.UnitOfPresentation;
            Quantity ozzzy_ = a?.Quantity;
            List<ResourceReference> ozzzz_ = a?.Manufacturer;
            List<ResourceReference> pzzza_ = a?.Ingredient;
            ProdCharacteristic pzzzb_ = a?.PhysicalCharacteristics;
            List<CodeableConcept> pzzzc_ = a?.OtherCharacteristics;
            MedicinalProductManufactured pzzzd_ = new MedicinalProductManufactured
            {
                ManufacturedDoseForm = ozzzw_,
                UnitOfPresentation = ozzzx_,
                Quantity = ozzzy_,
                Manufacturer = new List<ResourceReference>((IEnumerable<ResourceReference>)ozzzz_),
                Ingredient = new List<ResourceReference>((IEnumerable<ResourceReference>)pzzza_),
                PhysicalCharacteristics = pzzzb_,
                OtherCharacteristics = new List<CodeableConcept>((IEnumerable<CodeableConcept>)pzzzc_),
            };

            return pzzzd_;
        };
        IEnumerable<MedicinalProductManufactured> ozzzt_ = context.Operators.Select<MedicinalProductManufactured, MedicinalProductManufactured>((IEnumerable<MedicinalProductManufactured>)ozzzr_, ozzzs_);
        IEnumerable<MedicinalProductManufactured> ozzzu_ = context.Operators.Distinct<MedicinalProductManufactured>(ozzzt_);
        MedicinalProductManufactured ozzzv_ = context.Operators.SingletonFrom<MedicinalProductManufactured>(ozzzu_);

        return ozzzv_;
    }


    [CqlExpressionDefinition("MedicinalProductPackagedResource")]
    public MedicinalProductPackaged MedicinalProductPackagedResource(CqlContext context, MedicinalProductPackaged arg)
    {
        MedicinalProductPackaged[] pzzze_ = [
            arg,
        ];
        MedicinalProductPackaged pzzzf_(MedicinalProductPackaged a)
        {
            List<Identifier> pzzzj_ = a?.Identifier;
            List<ResourceReference> pzzzk_ = a?.Subject;
            FhirString pzzzl_ = a?.DescriptionElement;
            CodeableConcept pzzzm_ = a?.LegalStatusOfSupply;
            List<MarketingStatus> pzzzn_ = a?.MarketingStatus;
            ResourceReference pzzzo_ = a?.MarketingAuthorization;
            List<ResourceReference> pzzzp_ = a?.Manufacturer;
            List<MedicinalProductPackaged.BatchIdentifierComponent> pzzzq_ = a?.BatchIdentifier;
            List<MedicinalProductPackaged.PackageItemComponent> pzzzr_ = a?.PackageItem;
            MedicinalProductPackaged pzzzs_ = new MedicinalProductPackaged
            {
                Identifier = new List<Identifier>((IEnumerable<Identifier>)pzzzj_),
                Subject = new List<ResourceReference>((IEnumerable<ResourceReference>)pzzzk_),
                DescriptionElement = pzzzl_,
                LegalStatusOfSupply = pzzzm_,
                MarketingStatus = new List<MarketingStatus>((IEnumerable<MarketingStatus>)pzzzn_),
                MarketingAuthorization = pzzzo_,
                Manufacturer = new List<ResourceReference>((IEnumerable<ResourceReference>)pzzzp_),
                BatchIdentifier = new List<MedicinalProductPackaged.BatchIdentifierComponent>((IEnumerable<MedicinalProductPackaged.BatchIdentifierComponent>)pzzzq_),
                PackageItem = new List<MedicinalProductPackaged.PackageItemComponent>((IEnumerable<MedicinalProductPackaged.PackageItemComponent>)pzzzr_),
            };

            return pzzzs_;
        };
        IEnumerable<MedicinalProductPackaged> pzzzg_ = context.Operators.Select<MedicinalProductPackaged, MedicinalProductPackaged>((IEnumerable<MedicinalProductPackaged>)pzzze_, pzzzf_);
        IEnumerable<MedicinalProductPackaged> pzzzh_ = context.Operators.Distinct<MedicinalProductPackaged>(pzzzg_);
        MedicinalProductPackaged pzzzi_ = context.Operators.SingletonFrom<MedicinalProductPackaged>(pzzzh_);

        return pzzzi_;
    }


    [CqlExpressionDefinition("MedicinalProductPharmaceuticalResource")]
    public MedicinalProductPharmaceutical MedicinalProductPharmaceuticalResource(CqlContext context, MedicinalProductPharmaceutical arg)
    {
        MedicinalProductPharmaceutical[] pzzzt_ = [
            arg,
        ];
        MedicinalProductPharmaceutical pzzzu_(MedicinalProductPharmaceutical a)
        {
            List<Identifier> pzzzy_ = a?.Identifier;
            CodeableConcept pzzzz_ = a?.AdministrableDoseForm;
            CodeableConcept qzzza_ = a?.UnitOfPresentation;
            List<ResourceReference> qzzzb_ = a?.Ingredient;
            List<ResourceReference> qzzzc_ = a?.Device;
            List<MedicinalProductPharmaceutical.CharacteristicsComponent> qzzzd_ = a?.Characteristics;
            List<MedicinalProductPharmaceutical.RouteOfAdministrationComponent> qzzze_ = a?.RouteOfAdministration;
            MedicinalProductPharmaceutical qzzzf_ = new MedicinalProductPharmaceutical
            {
                Identifier = new List<Identifier>((IEnumerable<Identifier>)pzzzy_),
                AdministrableDoseForm = pzzzz_,
                UnitOfPresentation = qzzza_,
                Ingredient = new List<ResourceReference>((IEnumerable<ResourceReference>)qzzzb_),
                Device = new List<ResourceReference>((IEnumerable<ResourceReference>)qzzzc_),
                Characteristics = new List<MedicinalProductPharmaceutical.CharacteristicsComponent>((IEnumerable<MedicinalProductPharmaceutical.CharacteristicsComponent>)qzzzd_),
                RouteOfAdministration = new List<MedicinalProductPharmaceutical.RouteOfAdministrationComponent>((IEnumerable<MedicinalProductPharmaceutical.RouteOfAdministrationComponent>)qzzze_),
            };

            return qzzzf_;
        };
        IEnumerable<MedicinalProductPharmaceutical> pzzzv_ = context.Operators.Select<MedicinalProductPharmaceutical, MedicinalProductPharmaceutical>((IEnumerable<MedicinalProductPharmaceutical>)pzzzt_, pzzzu_);
        IEnumerable<MedicinalProductPharmaceutical> pzzzw_ = context.Operators.Distinct<MedicinalProductPharmaceutical>(pzzzv_);
        MedicinalProductPharmaceutical pzzzx_ = context.Operators.SingletonFrom<MedicinalProductPharmaceutical>(pzzzw_);

        return pzzzx_;
    }


    [CqlExpressionDefinition("MedicinalProductUndesirableEffectResource")]
    public MedicinalProductUndesirableEffect MedicinalProductUndesirableEffectResource(CqlContext context, MedicinalProductUndesirableEffect arg)
    {
        MedicinalProductUndesirableEffect[] qzzzg_ = [
            arg,
        ];
        MedicinalProductUndesirableEffect qzzzh_(MedicinalProductUndesirableEffect a)
        {
            List<ResourceReference> qzzzl_ = a?.Subject;
            CodeableConcept qzzzm_ = a?.SymptomConditionEffect;
            CodeableConcept qzzzn_ = a?.Classification;
            CodeableConcept qzzzo_ = a?.FrequencyOfOccurrence;
            List<Population> qzzzp_ = a?.Population;
            MedicinalProductUndesirableEffect qzzzq_ = new MedicinalProductUndesirableEffect
            {
                Subject = new List<ResourceReference>((IEnumerable<ResourceReference>)qzzzl_),
                SymptomConditionEffect = qzzzm_,
                Classification = qzzzn_,
                FrequencyOfOccurrence = qzzzo_,
                Population = new List<Population>((IEnumerable<Population>)qzzzp_),
            };

            return qzzzq_;
        };
        IEnumerable<MedicinalProductUndesirableEffect> qzzzi_ = context.Operators.Select<MedicinalProductUndesirableEffect, MedicinalProductUndesirableEffect>((IEnumerable<MedicinalProductUndesirableEffect>)qzzzg_, qzzzh_);
        IEnumerable<MedicinalProductUndesirableEffect> qzzzj_ = context.Operators.Distinct<MedicinalProductUndesirableEffect>(qzzzi_);
        MedicinalProductUndesirableEffect qzzzk_ = context.Operators.SingletonFrom<MedicinalProductUndesirableEffect>(qzzzj_);

        return qzzzk_;
    }


    [CqlExpressionDefinition("MessageHeaderResource")]
    public MessageHeader MessageHeaderResource(CqlContext context, MessageHeader arg)
    {
        MessageHeader[] qzzzr_ = [
            arg,
        ];
        MessageHeader qzzzs_(MessageHeader a)
        {
            DataType qzzzw_ = a?.Event;
            List<MessageHeader.MessageDestinationComponent> qzzzx_ = a?.Destination;
            ResourceReference qzzzy_ = a?.Sender;
            ResourceReference qzzzz_ = a?.Enterer;
            ResourceReference rzzza_ = a?.Author;
            MessageHeader.MessageSourceComponent rzzzb_ = a?.Source;
            ResourceReference rzzzc_ = a?.Responsible;
            CodeableConcept rzzzd_ = a?.Reason;
            MessageHeader.ResponseComponent rzzze_ = a?.Response;
            List<ResourceReference> rzzzf_ = a?.Focus;
            Canonical rzzzg_ = a?.DefinitionElement;
            MessageHeader rzzzh_ = new MessageHeader
            {
                Event = (DataType)qzzzw_,
                Destination = new List<MessageHeader.MessageDestinationComponent>((IEnumerable<MessageHeader.MessageDestinationComponent>)qzzzx_),
                Sender = qzzzy_,
                Enterer = qzzzz_,
                Author = rzzza_,
                Source = rzzzb_,
                Responsible = rzzzc_,
                Reason = rzzzd_,
                Response = rzzze_,
                Focus = new List<ResourceReference>((IEnumerable<ResourceReference>)rzzzf_),
                DefinitionElement = rzzzg_,
            };

            return rzzzh_;
        };
        IEnumerable<MessageHeader> qzzzt_ = context.Operators.Select<MessageHeader, MessageHeader>((IEnumerable<MessageHeader>)qzzzr_, qzzzs_);
        IEnumerable<MessageHeader> qzzzu_ = context.Operators.Distinct<MessageHeader>(qzzzt_);
        MessageHeader qzzzv_ = context.Operators.SingletonFrom<MessageHeader>(qzzzu_);

        return qzzzv_;
    }


    [CqlExpressionDefinition("MolecularSequenceResource")]
    public MolecularSequence MolecularSequenceResource(CqlContext context, MolecularSequence arg)
    {
        MolecularSequence[] rzzzi_ = [
            arg,
        ];
        MolecularSequence rzzzj_(MolecularSequence a)
        {
            List<Identifier> rzzzn_ = a?.Identifier;
            Code<MolecularSequence.SequenceType> rzzzo_ = a?.TypeElement;
            Integer rzzzp_ = a?.CoordinateSystemElement;
            ResourceReference rzzzq_ = a?.Patient;
            ResourceReference rzzzr_ = a?.Specimen;
            ResourceReference rzzzs_ = a?.Device;
            ResourceReference rzzzt_ = a?.Performer;
            Quantity rzzzu_ = a?.Quantity;
            MolecularSequence.ReferenceSeqComponent rzzzv_ = a?.ReferenceSeq;
            List<MolecularSequence.VariantComponent> rzzzw_ = a?.Variant;
            FhirString rzzzx_ = a?.ObservedSeqElement;
            List<MolecularSequence.QualityComponent> rzzzy_ = a?.Quality;
            Integer rzzzz_ = a?.ReadCoverageElement;
            List<MolecularSequence.RepositoryComponent> szzza_ = a?.Repository;
            List<ResourceReference> szzzb_ = a?.Pointer;
            List<MolecularSequence.StructureVariantComponent> szzzc_ = a?.StructureVariant;
            MolecularSequence szzzd_ = new MolecularSequence
            {
                Identifier = new List<Identifier>((IEnumerable<Identifier>)rzzzn_),
                TypeElement = rzzzo_,
                CoordinateSystemElement = rzzzp_,
                Patient = rzzzq_,
                Specimen = rzzzr_,
                Device = rzzzs_,
                Performer = rzzzt_,
                Quantity = rzzzu_,
                ReferenceSeq = rzzzv_,
                Variant = new List<MolecularSequence.VariantComponent>((IEnumerable<MolecularSequence.VariantComponent>)rzzzw_),
                ObservedSeqElement = rzzzx_,
                Quality = new List<MolecularSequence.QualityComponent>((IEnumerable<MolecularSequence.QualityComponent>)rzzzy_),
                ReadCoverageElement = rzzzz_,
                Repository = new List<MolecularSequence.RepositoryComponent>((IEnumerable<MolecularSequence.RepositoryComponent>)szzza_),
                Pointer = new List<ResourceReference>((IEnumerable<ResourceReference>)szzzb_),
                StructureVariant = new List<MolecularSequence.StructureVariantComponent>((IEnumerable<MolecularSequence.StructureVariantComponent>)szzzc_),
            };

            return szzzd_;
        };
        IEnumerable<MolecularSequence> rzzzk_ = context.Operators.Select<MolecularSequence, MolecularSequence>((IEnumerable<MolecularSequence>)rzzzi_, rzzzj_);
        IEnumerable<MolecularSequence> rzzzl_ = context.Operators.Distinct<MolecularSequence>(rzzzk_);
        MolecularSequence rzzzm_ = context.Operators.SingletonFrom<MolecularSequence>(rzzzl_);

        return rzzzm_;
    }


    [CqlExpressionDefinition("NamingSystemResource")]
    public NamingSystem NamingSystemResource(CqlContext context, NamingSystem arg)
    {
        NamingSystem[] szzze_ = [
            arg,
        ];
        NamingSystem szzzf_(NamingSystem a)
        {
            FhirString szzzj_ = a?.NameElement;
            Code<PublicationStatus> szzzk_ = a?.StatusElement;
            Code<NamingSystem.NamingSystemType> szzzl_ = a?.KindElement;
            FhirDateTime szzzm_ = a?.DateElement;
            FhirString szzzn_ = a?.PublisherElement;
            List<ContactDetail> szzzo_ = a?.Contact;
            FhirString szzzp_ = a?.ResponsibleElement;
            CodeableConcept szzzq_ = a?.Type;
            Markdown szzzr_ = a?.DescriptionElement;
            List<UsageContext> szzzs_ = a?.UseContext;
            List<CodeableConcept> szzzt_ = a?.Jurisdiction;
            FhirString szzzu_ = a?.UsageElement;
            List<NamingSystem.UniqueIdComponent> szzzv_ = a?.UniqueId;
            NamingSystem szzzw_ = new NamingSystem
            {
                NameElement = szzzj_,
                StatusElement = szzzk_,
                KindElement = szzzl_,
                DateElement = szzzm_,
                PublisherElement = szzzn_,
                Contact = new List<ContactDetail>((IEnumerable<ContactDetail>)szzzo_),
                ResponsibleElement = szzzp_,
                Type = szzzq_,
                DescriptionElement = szzzr_,
                UseContext = new List<UsageContext>((IEnumerable<UsageContext>)szzzs_),
                Jurisdiction = new List<CodeableConcept>((IEnumerable<CodeableConcept>)szzzt_),
                UsageElement = szzzu_,
                UniqueId = new List<NamingSystem.UniqueIdComponent>((IEnumerable<NamingSystem.UniqueIdComponent>)szzzv_),
            };

            return szzzw_;
        };
        IEnumerable<NamingSystem> szzzg_ = context.Operators.Select<NamingSystem, NamingSystem>((IEnumerable<NamingSystem>)szzze_, szzzf_);
        IEnumerable<NamingSystem> szzzh_ = context.Operators.Distinct<NamingSystem>(szzzg_);
        NamingSystem szzzi_ = context.Operators.SingletonFrom<NamingSystem>(szzzh_);

        return szzzi_;
    }


    [CqlExpressionDefinition("NutritionOrderResource")]
    public NutritionOrder NutritionOrderResource(CqlContext context, NutritionOrder arg)
    {
        NutritionOrder[] szzzx_ = [
            arg,
        ];
        NutritionOrder szzzy_(NutritionOrder a)
        {
            List<Identifier> tzzzc_ = a?.Identifier;
            List<Canonical> tzzzd_ = a?.InstantiatesCanonicalElement;
            List<FhirUri> tzzze_ = a?.InstantiatesUriElement;
            List<FhirUri> tzzzf_ = a?.InstantiatesElement;
            Code<RequestStatus> tzzzg_ = a?.StatusElement;
            Code<RequestIntent> tzzzh_ = a?.IntentElement;
            ResourceReference tzzzi_ = a?.Patient;
            ResourceReference tzzzj_ = a?.Encounter;
            FhirDateTime tzzzk_ = a?.DateTimeElement;
            ResourceReference tzzzl_ = a?.Orderer;
            List<ResourceReference> tzzzm_ = a?.AllergyIntolerance;
            List<CodeableConcept> tzzzn_ = a?.FoodPreferenceModifier;
            List<CodeableConcept> tzzzo_ = a?.ExcludeFoodModifier;
            NutritionOrder.OralDietComponent tzzzp_ = a?.OralDiet;
            List<NutritionOrder.SupplementComponent> tzzzq_ = a?.Supplement;
            NutritionOrder.EnteralFormulaComponent tzzzr_ = a?.EnteralFormula;
            List<Annotation> tzzzs_ = a?.Note;
            NutritionOrder tzzzt_ = new NutritionOrder
            {
                Identifier = new List<Identifier>((IEnumerable<Identifier>)tzzzc_),
                InstantiatesCanonicalElement = new List<Canonical>((IEnumerable<Canonical>)tzzzd_),
                InstantiatesUriElement = new List<FhirUri>((IEnumerable<FhirUri>)tzzze_),
                InstantiatesElement = new List<FhirUri>((IEnumerable<FhirUri>)tzzzf_),
                StatusElement = tzzzg_,
                IntentElement = tzzzh_,
                Patient = tzzzi_,
                Encounter = tzzzj_,
                DateTimeElement = tzzzk_,
                Orderer = tzzzl_,
                AllergyIntolerance = new List<ResourceReference>((IEnumerable<ResourceReference>)tzzzm_),
                FoodPreferenceModifier = new List<CodeableConcept>((IEnumerable<CodeableConcept>)tzzzn_),
                ExcludeFoodModifier = new List<CodeableConcept>((IEnumerable<CodeableConcept>)tzzzo_),
                OralDiet = tzzzp_,
                Supplement = new List<NutritionOrder.SupplementComponent>((IEnumerable<NutritionOrder.SupplementComponent>)tzzzq_),
                EnteralFormula = tzzzr_,
                Note = new List<Annotation>((IEnumerable<Annotation>)tzzzs_),
            };

            return tzzzt_;
        };
        IEnumerable<NutritionOrder> szzzz_ = context.Operators.Select<NutritionOrder, NutritionOrder>((IEnumerable<NutritionOrder>)szzzx_, szzzy_);
        IEnumerable<NutritionOrder> tzzza_ = context.Operators.Distinct<NutritionOrder>(szzzz_);
        NutritionOrder tzzzb_ = context.Operators.SingletonFrom<NutritionOrder>(tzzza_);

        return tzzzb_;
    }


    [CqlExpressionDefinition("ObservationResource")]
    public Observation ObservationResource(CqlContext context, Observation arg)
    {
        Observation[] tzzzu_ = [
            arg,
        ];
        Observation tzzzv_(Observation a)
        {
            List<Identifier> tzzzz_ = a?.Identifier;
            List<ResourceReference> uzzza_ = a?.BasedOn;
            List<ResourceReference> uzzzb_ = a?.PartOf;
            Code<ObservationStatus> uzzzc_ = a?.StatusElement;
            List<CodeableConcept> uzzzd_ = a?.Category;
            CodeableConcept uzzze_ = a?.Code;
            ResourceReference uzzzf_ = a?.Subject;
            List<ResourceReference> uzzzg_ = a?.Focus;
            ResourceReference uzzzh_ = a?.Encounter;
            DataType uzzzi_ = a?.Effective;
            Instant uzzzj_ = a?.IssuedElement;
            List<ResourceReference> uzzzk_ = a?.Performer;
            DataType uzzzl_ = a?.Value;
            CodeableConcept uzzzm_ = a?.DataAbsentReason;
            List<CodeableConcept> uzzzn_ = a?.Interpretation;
            List<Annotation> uzzzo_ = a?.Note;
            CodeableConcept uzzzp_ = a?.BodySite;
            CodeableConcept uzzzq_ = a?.Method;
            ResourceReference uzzzr_ = a?.Specimen;
            ResourceReference uzzzs_ = a?.Device;
            List<Observation.ReferenceRangeComponent> uzzzt_ = a?.ReferenceRange;
            List<ResourceReference> uzzzu_ = a?.HasMember;
            List<ResourceReference> uzzzv_ = a?.DerivedFrom;
            List<Observation.ComponentComponent> uzzzw_ = a?.Component;
            Observation uzzzx_ = new Observation
            {
                Identifier = new List<Identifier>((IEnumerable<Identifier>)tzzzz_),
                BasedOn = new List<ResourceReference>((IEnumerable<ResourceReference>)uzzza_),
                PartOf = new List<ResourceReference>((IEnumerable<ResourceReference>)uzzzb_),
                StatusElement = uzzzc_,
                Category = new List<CodeableConcept>((IEnumerable<CodeableConcept>)uzzzd_),
                Code = uzzze_,
                Subject = uzzzf_,
                Focus = new List<ResourceReference>((IEnumerable<ResourceReference>)uzzzg_),
                Encounter = uzzzh_,
                Effective = (DataType)uzzzi_,
                IssuedElement = uzzzj_,
                Performer = new List<ResourceReference>((IEnumerable<ResourceReference>)uzzzk_),
                Value = (DataType)uzzzl_,
                DataAbsentReason = uzzzm_,
                Interpretation = new List<CodeableConcept>((IEnumerable<CodeableConcept>)uzzzn_),
                Note = new List<Annotation>((IEnumerable<Annotation>)uzzzo_),
                BodySite = uzzzp_,
                Method = uzzzq_,
                Specimen = uzzzr_,
                Device = uzzzs_,
                ReferenceRange = new List<Observation.ReferenceRangeComponent>((IEnumerable<Observation.ReferenceRangeComponent>)uzzzt_),
                HasMember = new List<ResourceReference>((IEnumerable<ResourceReference>)uzzzu_),
                DerivedFrom = new List<ResourceReference>((IEnumerable<ResourceReference>)uzzzv_),
                Component = new List<Observation.ComponentComponent>((IEnumerable<Observation.ComponentComponent>)uzzzw_),
            };

            return uzzzx_;
        };
        IEnumerable<Observation> tzzzw_ = context.Operators.Select<Observation, Observation>((IEnumerable<Observation>)tzzzu_, tzzzv_);
        IEnumerable<Observation> tzzzx_ = context.Operators.Distinct<Observation>(tzzzw_);
        Observation tzzzy_ = context.Operators.SingletonFrom<Observation>(tzzzx_);

        return tzzzy_;
    }


    [CqlExpressionDefinition("ObservationDefinitionResource")]
    public ObservationDefinition ObservationDefinitionResource(CqlContext context, ObservationDefinition arg)
    {
        ObservationDefinition[] uzzzy_ = [
            arg,
        ];
        ObservationDefinition uzzzz_(ObservationDefinition a)
        {
            List<CodeableConcept> vzzzd_ = a?.Category;
            CodeableConcept vzzze_ = a?.Code;
            List<Identifier> vzzzf_ = a?.Identifier;
            List<Code<ObservationDefinition.ObservationDataType>> vzzzg_ = a?.PermittedDataTypeElement;
            FhirBoolean vzzzh_ = a?.MultipleResultsAllowedElement;
            CodeableConcept vzzzi_ = a?.Method;
            FhirString vzzzj_ = a?.PreferredReportNameElement;
            ObservationDefinition.QuantitativeDetailsComponent vzzzk_ = a?.QuantitativeDetails;
            List<ObservationDefinition.QualifiedIntervalComponent> vzzzl_ = a?.QualifiedInterval;
            ResourceReference vzzzm_ = a?.ValidCodedValueSet;
            ResourceReference vzzzn_ = a?.NormalCodedValueSet;
            ResourceReference vzzzo_ = a?.AbnormalCodedValueSet;
            ResourceReference vzzzp_ = a?.CriticalCodedValueSet;
            ObservationDefinition vzzzq_ = new ObservationDefinition
            {
                Category = new List<CodeableConcept>((IEnumerable<CodeableConcept>)vzzzd_),
                Code = vzzze_,
                Identifier = new List<Identifier>((IEnumerable<Identifier>)vzzzf_),
                PermittedDataTypeElement = new List<Code<ObservationDefinition.ObservationDataType>>((IEnumerable<Code<ObservationDefinition.ObservationDataType>>)vzzzg_),
                MultipleResultsAllowedElement = vzzzh_,
                Method = vzzzi_,
                PreferredReportNameElement = vzzzj_,
                QuantitativeDetails = vzzzk_,
                QualifiedInterval = new List<ObservationDefinition.QualifiedIntervalComponent>((IEnumerable<ObservationDefinition.QualifiedIntervalComponent>)vzzzl_),
                ValidCodedValueSet = vzzzm_,
                NormalCodedValueSet = vzzzn_,
                AbnormalCodedValueSet = vzzzo_,
                CriticalCodedValueSet = vzzzp_,
            };

            return vzzzq_;
        };
        IEnumerable<ObservationDefinition> vzzza_ = context.Operators.Select<ObservationDefinition, ObservationDefinition>((IEnumerable<ObservationDefinition>)uzzzy_, uzzzz_);
        IEnumerable<ObservationDefinition> vzzzb_ = context.Operators.Distinct<ObservationDefinition>(vzzza_);
        ObservationDefinition vzzzc_ = context.Operators.SingletonFrom<ObservationDefinition>(vzzzb_);

        return vzzzc_;
    }


    [CqlExpressionDefinition("OperationOutcomeResource")]
    public OperationOutcome OperationOutcomeResource(CqlContext context, OperationOutcome arg)
    {
        OperationOutcome[] vzzzr_ = [
            arg,
        ];
        OperationOutcome vzzzs_(OperationOutcome a)
        {
            List<OperationOutcome.IssueComponent> vzzzw_ = a?.Issue;
            OperationOutcome vzzzx_ = new OperationOutcome
            {
                Issue = new List<OperationOutcome.IssueComponent>((IEnumerable<OperationOutcome.IssueComponent>)vzzzw_),
            };

            return vzzzx_;
        };
        IEnumerable<OperationOutcome> vzzzt_ = context.Operators.Select<OperationOutcome, OperationOutcome>((IEnumerable<OperationOutcome>)vzzzr_, vzzzs_);
        IEnumerable<OperationOutcome> vzzzu_ = context.Operators.Distinct<OperationOutcome>(vzzzt_);
        OperationOutcome vzzzv_ = context.Operators.SingletonFrom<OperationOutcome>(vzzzu_);

        return vzzzv_;
    }


    [CqlExpressionDefinition("OrganizationResource")]
    public Organization OrganizationResource(CqlContext context, Organization arg)
    {
        Organization[] vzzzy_ = [
            arg,
        ];
        Organization vzzzz_(Organization a)
        {
            List<Identifier> wzzzd_ = a?.Identifier;
            FhirBoolean wzzze_ = a?.ActiveElement;
            List<CodeableConcept> wzzzf_ = a?.Type;
            FhirString wzzzg_ = a?.NameElement;
            List<FhirString> wzzzh_ = a?.AliasElement;
            List<ContactPoint> wzzzi_ = a?.Telecom;
            List<Address> wzzzj_ = a?.Address;
            ResourceReference wzzzk_ = a?.PartOf;
            List<Organization.ContactComponent> wzzzl_ = a?.Contact;
            List<ResourceReference> wzzzm_ = a?.Endpoint;
            Organization wzzzn_ = new Organization
            {
                Identifier = new List<Identifier>((IEnumerable<Identifier>)wzzzd_),
                ActiveElement = wzzze_,
                Type = new List<CodeableConcept>((IEnumerable<CodeableConcept>)wzzzf_),
                NameElement = wzzzg_,
                AliasElement = new List<FhirString>((IEnumerable<FhirString>)wzzzh_),
                Telecom = new List<ContactPoint>((IEnumerable<ContactPoint>)wzzzi_),
                Address = new List<Address>((IEnumerable<Address>)wzzzj_),
                PartOf = wzzzk_,
                Contact = new List<Organization.ContactComponent>((IEnumerable<Organization.ContactComponent>)wzzzl_),
                Endpoint = new List<ResourceReference>((IEnumerable<ResourceReference>)wzzzm_),
            };

            return wzzzn_;
        };
        IEnumerable<Organization> wzzza_ = context.Operators.Select<Organization, Organization>((IEnumerable<Organization>)vzzzy_, vzzzz_);
        IEnumerable<Organization> wzzzb_ = context.Operators.Distinct<Organization>(wzzza_);
        Organization wzzzc_ = context.Operators.SingletonFrom<Organization>(wzzzb_);

        return wzzzc_;
    }


    [CqlExpressionDefinition("OrganizationAffiliationResource")]
    public OrganizationAffiliation OrganizationAffiliationResource(CqlContext context, OrganizationAffiliation arg)
    {
        OrganizationAffiliation[] wzzzo_ = [
            arg,
        ];
        OrganizationAffiliation wzzzp_(OrganizationAffiliation a)
        {
            List<Identifier> wzzzt_ = a?.Identifier;
            FhirBoolean wzzzu_ = a?.ActiveElement;
            Period wzzzv_ = a?.Period;
            ResourceReference wzzzw_ = a?.Organization;
            ResourceReference wzzzx_ = a?.ParticipatingOrganization;
            List<ResourceReference> wzzzy_ = a?.Network;
            List<CodeableConcept> wzzzz_ = a?.Code;
            List<CodeableConcept> xzzza_ = a?.Specialty;
            List<ResourceReference> xzzzb_ = a?.Location;
            List<ResourceReference> xzzzc_ = a?.HealthcareService;
            List<ContactPoint> xzzzd_ = a?.Telecom;
            List<ResourceReference> xzzze_ = a?.Endpoint;
            OrganizationAffiliation xzzzf_ = new OrganizationAffiliation
            {
                Identifier = new List<Identifier>((IEnumerable<Identifier>)wzzzt_),
                ActiveElement = wzzzu_,
                Period = wzzzv_,
                Organization = wzzzw_,
                ParticipatingOrganization = wzzzx_,
                Network = new List<ResourceReference>((IEnumerable<ResourceReference>)wzzzy_),
                Code = new List<CodeableConcept>((IEnumerable<CodeableConcept>)wzzzz_),
                Specialty = new List<CodeableConcept>((IEnumerable<CodeableConcept>)xzzza_),
                Location = new List<ResourceReference>((IEnumerable<ResourceReference>)xzzzb_),
                HealthcareService = new List<ResourceReference>((IEnumerable<ResourceReference>)xzzzc_),
                Telecom = new List<ContactPoint>((IEnumerable<ContactPoint>)xzzzd_),
                Endpoint = new List<ResourceReference>((IEnumerable<ResourceReference>)xzzze_),
            };

            return xzzzf_;
        };
        IEnumerable<OrganizationAffiliation> wzzzq_ = context.Operators.Select<OrganizationAffiliation, OrganizationAffiliation>((IEnumerable<OrganizationAffiliation>)wzzzo_, wzzzp_);
        IEnumerable<OrganizationAffiliation> wzzzr_ = context.Operators.Distinct<OrganizationAffiliation>(wzzzq_);
        OrganizationAffiliation wzzzs_ = context.Operators.SingletonFrom<OrganizationAffiliation>(wzzzr_);

        return wzzzs_;
    }


    [CqlExpressionDefinition("PatientResource")]
    public Patient PatientResource(CqlContext context, Patient arg)
    {
        Patient[] xzzzg_ = [
            arg,
        ];
        Patient xzzzh_(Patient a)
        {
            List<Identifier> xzzzl_ = a?.Identifier;
            FhirBoolean xzzzm_ = a?.ActiveElement;
            List<HumanName> xzzzn_ = a?.Name;
            List<ContactPoint> xzzzo_ = a?.Telecom;
            Code<AdministrativeGender> xzzzp_ = a?.GenderElement;
            Date xzzzq_ = a?.BirthDateElement;
            DataType xzzzr_ = a?.Deceased;
            List<Address> xzzzs_ = a?.Address;
            CodeableConcept xzzzt_ = a?.MaritalStatus;
            DataType xzzzu_ = a?.MultipleBirth;
            List<Attachment> xzzzv_ = a?.Photo;
            List<Patient.ContactComponent> xzzzw_ = a?.Contact;
            List<Patient.CommunicationComponent> xzzzx_ = a?.Communication;
            List<ResourceReference> xzzzy_ = a?.GeneralPractitioner;
            ResourceReference xzzzz_ = a?.ManagingOrganization;
            List<Patient.LinkComponent> yzzza_ = a?.Link;
            Patient yzzzb_ = new Patient
            {
                Identifier = new List<Identifier>((IEnumerable<Identifier>)xzzzl_),
                ActiveElement = xzzzm_,
                Name = new List<HumanName>((IEnumerable<HumanName>)xzzzn_),
                Telecom = new List<ContactPoint>((IEnumerable<ContactPoint>)xzzzo_),
                GenderElement = xzzzp_,
                BirthDateElement = xzzzq_,
                Deceased = (DataType)xzzzr_,
                Address = new List<Address>((IEnumerable<Address>)xzzzs_),
                MaritalStatus = xzzzt_,
                MultipleBirth = (DataType)xzzzu_,
                Photo = new List<Attachment>((IEnumerable<Attachment>)xzzzv_),
                Contact = new List<Patient.ContactComponent>((IEnumerable<Patient.ContactComponent>)xzzzw_),
                Communication = new List<Patient.CommunicationComponent>((IEnumerable<Patient.CommunicationComponent>)xzzzx_),
                GeneralPractitioner = new List<ResourceReference>((IEnumerable<ResourceReference>)xzzzy_),
                ManagingOrganization = xzzzz_,
                Link = new List<Patient.LinkComponent>((IEnumerable<Patient.LinkComponent>)yzzza_),
            };

            return yzzzb_;
        };
        IEnumerable<Patient> xzzzi_ = context.Operators.Select<Patient, Patient>((IEnumerable<Patient>)xzzzg_, xzzzh_);
        IEnumerable<Patient> xzzzj_ = context.Operators.Distinct<Patient>(xzzzi_);
        Patient xzzzk_ = context.Operators.SingletonFrom<Patient>(xzzzj_);

        return xzzzk_;
    }


    [CqlExpressionDefinition("PaymentNoticeResource")]
    public PaymentNotice PaymentNoticeResource(CqlContext context, PaymentNotice arg)
    {
        PaymentNotice[] yzzzc_ = [
            arg,
        ];
        PaymentNotice yzzzd_(PaymentNotice a)
        {
            List<Identifier> yzzzh_ = a?.Identifier;
            Code<FinancialResourceStatusCodes> yzzzi_ = a?.StatusElement;
            ResourceReference yzzzj_ = a?.Request;
            ResourceReference yzzzk_ = a?.Response;
            FhirDateTime yzzzl_ = a?.CreatedElement;
            ResourceReference yzzzm_ = a?.Provider;
            ResourceReference yzzzn_ = a?.Payment;
            Date yzzzo_ = a?.PaymentDateElement;
            ResourceReference yzzzp_ = a?.Payee;
            ResourceReference yzzzq_ = a?.Recipient;
            Money yzzzr_ = a?.Amount;
            CodeableConcept yzzzs_ = a?.PaymentStatus;
            PaymentNotice yzzzt_ = new PaymentNotice
            {
                Identifier = new List<Identifier>((IEnumerable<Identifier>)yzzzh_),
                StatusElement = yzzzi_,
                Request = yzzzj_,
                Response = yzzzk_,
                CreatedElement = yzzzl_,
                Provider = yzzzm_,
                Payment = yzzzn_,
                PaymentDateElement = yzzzo_,
                Payee = yzzzp_,
                Recipient = yzzzq_,
                Amount = yzzzr_,
                PaymentStatus = yzzzs_,
            };

            return yzzzt_;
        };
        IEnumerable<PaymentNotice> yzzze_ = context.Operators.Select<PaymentNotice, PaymentNotice>((IEnumerable<PaymentNotice>)yzzzc_, yzzzd_);
        IEnumerable<PaymentNotice> yzzzf_ = context.Operators.Distinct<PaymentNotice>(yzzze_);
        PaymentNotice yzzzg_ = context.Operators.SingletonFrom<PaymentNotice>(yzzzf_);

        return yzzzg_;
    }


    [CqlExpressionDefinition("PaymentReconciliationResource")]
    public PaymentReconciliation PaymentReconciliationResource(CqlContext context, PaymentReconciliation arg)
    {
        PaymentReconciliation[] yzzzu_ = [
            arg,
        ];
        PaymentReconciliation yzzzv_(PaymentReconciliation a)
        {
            List<Identifier> yzzzz_ = a?.Identifier;
            Code<FinancialResourceStatusCodes> zzzza_ = a?.StatusElement;
            Period zzzzb_ = a?.Period;
            FhirDateTime zzzzc_ = a?.CreatedElement;
            ResourceReference zzzzd_ = a?.PaymentIssuer;
            ResourceReference zzzze_ = a?.Request;
            ResourceReference zzzzf_ = a?.Requestor;
            Code<ClaimProcessingCodes> zzzzg_ = a?.OutcomeElement;
            FhirString zzzzh_ = a?.DispositionElement;
            Date zzzzi_ = a?.PaymentDateElement;
            Money zzzzj_ = a?.PaymentAmount;
            Identifier zzzzk_ = a?.PaymentIdentifier;
            List<PaymentReconciliation.DetailsComponent> zzzzl_ = a?.Detail;
            CodeableConcept zzzzm_ = a?.FormCode;
            List<PaymentReconciliation.NotesComponent> zzzzn_ = a?.ProcessNote;
            PaymentReconciliation zzzzo_ = new PaymentReconciliation
            {
                Identifier = new List<Identifier>((IEnumerable<Identifier>)yzzzz_),
                StatusElement = zzzza_,
                Period = zzzzb_,
                CreatedElement = zzzzc_,
                PaymentIssuer = zzzzd_,
                Request = zzzze_,
                Requestor = zzzzf_,
                OutcomeElement = zzzzg_,
                DispositionElement = zzzzh_,
                PaymentDateElement = zzzzi_,
                PaymentAmount = zzzzj_,
                PaymentIdentifier = zzzzk_,
                Detail = new List<PaymentReconciliation.DetailsComponent>((IEnumerable<PaymentReconciliation.DetailsComponent>)zzzzl_),
                FormCode = zzzzm_,
                ProcessNote = new List<PaymentReconciliation.NotesComponent>((IEnumerable<PaymentReconciliation.NotesComponent>)zzzzn_),
            };

            return zzzzo_;
        };
        IEnumerable<PaymentReconciliation> yzzzw_ = context.Operators.Select<PaymentReconciliation, PaymentReconciliation>((IEnumerable<PaymentReconciliation>)yzzzu_, yzzzv_);
        IEnumerable<PaymentReconciliation> yzzzx_ = context.Operators.Distinct<PaymentReconciliation>(yzzzw_);
        PaymentReconciliation yzzzy_ = context.Operators.SingletonFrom<PaymentReconciliation>(yzzzx_);

        return yzzzy_;
    }


    [CqlExpressionDefinition("PersonResource")]
    public Person PersonResource(CqlContext context, Person arg)
    {
        Person[] zzzzp_ = [
            arg,
        ];
        Person zzzzq_(Person a)
        {
            List<Identifier> zzzzu_ = a?.Identifier;
            List<HumanName> zzzzv_ = a?.Name;
            List<ContactPoint> zzzzw_ = a?.Telecom;
            Code<AdministrativeGender> zzzzx_ = a?.GenderElement;
            Date zzzzy_ = a?.BirthDateElement;
            List<Address> zzzzz_ = a?.Address;
            Attachment azzzza_ = a?.Photo;
            ResourceReference azzzzb_ = a?.ManagingOrganization;
            FhirBoolean azzzzc_ = a?.ActiveElement;
            List<Person.LinkComponent> azzzzd_ = a?.Link;
            Person azzzze_ = new Person
            {
                Identifier = new List<Identifier>((IEnumerable<Identifier>)zzzzu_),
                Name = new List<HumanName>((IEnumerable<HumanName>)zzzzv_),
                Telecom = new List<ContactPoint>((IEnumerable<ContactPoint>)zzzzw_),
                GenderElement = zzzzx_,
                BirthDateElement = zzzzy_,
                Address = new List<Address>((IEnumerable<Address>)zzzzz_),
                Photo = azzzza_,
                ManagingOrganization = azzzzb_,
                ActiveElement = azzzzc_,
                Link = new List<Person.LinkComponent>((IEnumerable<Person.LinkComponent>)azzzzd_),
            };

            return azzzze_;
        };
        IEnumerable<Person> zzzzr_ = context.Operators.Select<Person, Person>((IEnumerable<Person>)zzzzp_, zzzzq_);
        IEnumerable<Person> zzzzs_ = context.Operators.Distinct<Person>(zzzzr_);
        Person zzzzt_ = context.Operators.SingletonFrom<Person>(zzzzs_);

        return zzzzt_;
    }


    [CqlExpressionDefinition("PlanDefinitionResource")]
    public PlanDefinition PlanDefinitionResource(CqlContext context, PlanDefinition arg)
    {
        PlanDefinition[] azzzzf_ = [
            arg,
        ];
        PlanDefinition azzzzg_(PlanDefinition a)
        {
            FhirUri azzzzk_ = a?.UrlElement;
            List<Identifier> azzzzl_ = a?.Identifier;
            FhirString azzzzm_ = a?.VersionElement;
            FhirString azzzzn_ = a?.NameElement;
            FhirString azzzzo_ = a?.TitleElement;
            FhirString azzzzp_ = a?.SubtitleElement;
            CodeableConcept azzzzq_ = a?.Type;
            Code<PublicationStatus> azzzzr_ = a?.StatusElement;
            FhirBoolean azzzzs_ = a?.ExperimentalElement;
            DataType azzzzt_ = a?.Subject;
            FhirDateTime azzzzu_ = a?.DateElement;
            FhirString azzzzv_ = a?.PublisherElement;
            List<ContactDetail> azzzzw_ = a?.Contact;
            Markdown azzzzx_ = a?.DescriptionElement;
            List<UsageContext> azzzzy_ = a?.UseContext;
            List<CodeableConcept> azzzzz_ = a?.Jurisdiction;
            Markdown bzzzza_ = a?.PurposeElement;
            FhirString bzzzzb_ = a?.UsageElement;
            Markdown bzzzzc_ = a?.CopyrightElement;
            Date bzzzzd_ = a?.ApprovalDateElement;
            Date bzzzze_ = a?.LastReviewDateElement;
            Period bzzzzf_ = a?.EffectivePeriod;
            List<CodeableConcept> bzzzzg_ = a?.Topic;
            List<ContactDetail> bzzzzh_ = a?.Author;
            List<ContactDetail> bzzzzi_ = a?.Editor;
            List<ContactDetail> bzzzzj_ = a?.Reviewer;
            List<ContactDetail> bzzzzk_ = a?.Endorser;
            List<RelatedArtifact> bzzzzl_ = a?.RelatedArtifact;
            List<Canonical> bzzzzm_ = a?.LibraryElement;
            List<PlanDefinition.GoalComponent> bzzzzn_ = a?.Goal;
            List<PlanDefinition.ActionComponent> bzzzzo_ = a?.Action;
            PlanDefinition bzzzzp_ = new PlanDefinition
            {
                UrlElement = azzzzk_,
                Identifier = new List<Identifier>((IEnumerable<Identifier>)azzzzl_),
                VersionElement = azzzzm_,
                NameElement = azzzzn_,
                TitleElement = azzzzo_,
                SubtitleElement = azzzzp_,
                Type = azzzzq_,
                StatusElement = azzzzr_,
                ExperimentalElement = azzzzs_,
                Subject = (DataType)azzzzt_,
                DateElement = azzzzu_,
                PublisherElement = azzzzv_,
                Contact = new List<ContactDetail>((IEnumerable<ContactDetail>)azzzzw_),
                DescriptionElement = azzzzx_,
                UseContext = new List<UsageContext>((IEnumerable<UsageContext>)azzzzy_),
                Jurisdiction = new List<CodeableConcept>((IEnumerable<CodeableConcept>)azzzzz_),
                PurposeElement = bzzzza_,
                UsageElement = bzzzzb_,
                CopyrightElement = bzzzzc_,
                ApprovalDateElement = bzzzzd_,
                LastReviewDateElement = bzzzze_,
                EffectivePeriod = bzzzzf_,
                Topic = new List<CodeableConcept>((IEnumerable<CodeableConcept>)bzzzzg_),
                Author = new List<ContactDetail>((IEnumerable<ContactDetail>)bzzzzh_),
                Editor = new List<ContactDetail>((IEnumerable<ContactDetail>)bzzzzi_),
                Reviewer = new List<ContactDetail>((IEnumerable<ContactDetail>)bzzzzj_),
                Endorser = new List<ContactDetail>((IEnumerable<ContactDetail>)bzzzzk_),
                RelatedArtifact = new List<RelatedArtifact>((IEnumerable<RelatedArtifact>)bzzzzl_),
                LibraryElement = new List<Canonical>((IEnumerable<Canonical>)bzzzzm_),
                Goal = new List<PlanDefinition.GoalComponent>((IEnumerable<PlanDefinition.GoalComponent>)bzzzzn_),
                Action = new List<PlanDefinition.ActionComponent>((IEnumerable<PlanDefinition.ActionComponent>)bzzzzo_),
            };

            return bzzzzp_;
        };
        IEnumerable<PlanDefinition> azzzzh_ = context.Operators.Select<PlanDefinition, PlanDefinition>((IEnumerable<PlanDefinition>)azzzzf_, azzzzg_);
        IEnumerable<PlanDefinition> azzzzi_ = context.Operators.Distinct<PlanDefinition>(azzzzh_);
        PlanDefinition azzzzj_ = context.Operators.SingletonFrom<PlanDefinition>(azzzzi_);

        return azzzzj_;
    }


    [CqlExpressionDefinition("PractitionerResource")]
    public Practitioner PractitionerResource(CqlContext context, Practitioner arg)
    {
        Practitioner[] bzzzzq_ = [
            arg,
        ];
        Practitioner bzzzzr_(Practitioner a)
        {
            List<Identifier> bzzzzv_ = a?.Identifier;
            FhirBoolean bzzzzw_ = a?.ActiveElement;
            List<HumanName> bzzzzx_ = a?.Name;
            List<ContactPoint> bzzzzy_ = a?.Telecom;
            List<Address> bzzzzz_ = a?.Address;
            Code<AdministrativeGender> czzzza_ = a?.GenderElement;
            Date czzzzb_ = a?.BirthDateElement;
            List<Attachment> czzzzc_ = a?.Photo;
            List<Practitioner.QualificationComponent> czzzzd_ = a?.Qualification;
            List<CodeableConcept> czzzze_ = a?.Communication;
            Practitioner czzzzf_ = new Practitioner
            {
                Identifier = new List<Identifier>((IEnumerable<Identifier>)bzzzzv_),
                ActiveElement = bzzzzw_,
                Name = new List<HumanName>((IEnumerable<HumanName>)bzzzzx_),
                Telecom = new List<ContactPoint>((IEnumerable<ContactPoint>)bzzzzy_),
                Address = new List<Address>((IEnumerable<Address>)bzzzzz_),
                GenderElement = czzzza_,
                BirthDateElement = czzzzb_,
                Photo = new List<Attachment>((IEnumerable<Attachment>)czzzzc_),
                Qualification = new List<Practitioner.QualificationComponent>((IEnumerable<Practitioner.QualificationComponent>)czzzzd_),
                Communication = new List<CodeableConcept>((IEnumerable<CodeableConcept>)czzzze_),
            };

            return czzzzf_;
        };
        IEnumerable<Practitioner> bzzzzs_ = context.Operators.Select<Practitioner, Practitioner>((IEnumerable<Practitioner>)bzzzzq_, bzzzzr_);
        IEnumerable<Practitioner> bzzzzt_ = context.Operators.Distinct<Practitioner>(bzzzzs_);
        Practitioner bzzzzu_ = context.Operators.SingletonFrom<Practitioner>(bzzzzt_);

        return bzzzzu_;
    }


    [CqlExpressionDefinition("PractitionerRoleResource")]
    public PractitionerRole PractitionerRoleResource(CqlContext context, PractitionerRole arg)
    {
        PractitionerRole[] czzzzg_ = [
            arg,
        ];
        PractitionerRole czzzzh_(PractitionerRole a)
        {
            List<Identifier> czzzzl_ = a?.Identifier;
            FhirBoolean czzzzm_ = a?.ActiveElement;
            Period czzzzn_ = a?.Period;
            ResourceReference czzzzo_ = a?.Practitioner;
            ResourceReference czzzzp_ = a?.Organization;
            List<CodeableConcept> czzzzq_ = a?.Code;
            List<CodeableConcept> czzzzr_ = a?.Specialty;
            List<ResourceReference> czzzzs_ = a?.Location;
            List<ResourceReference> czzzzt_ = a?.HealthcareService;
            List<ContactPoint> czzzzu_ = a?.Telecom;
            List<PractitionerRole.AvailableTimeComponent> czzzzv_ = a?.AvailableTime;
            List<PractitionerRole.NotAvailableComponent> czzzzw_ = a?.NotAvailable;
            FhirString czzzzx_ = a?.AvailabilityExceptionsElement;
            List<ResourceReference> czzzzy_ = a?.Endpoint;
            PractitionerRole czzzzz_ = new PractitionerRole
            {
                Identifier = new List<Identifier>((IEnumerable<Identifier>)czzzzl_),
                ActiveElement = czzzzm_,
                Period = czzzzn_,
                Practitioner = czzzzo_,
                Organization = czzzzp_,
                Code = new List<CodeableConcept>((IEnumerable<CodeableConcept>)czzzzq_),
                Specialty = new List<CodeableConcept>((IEnumerable<CodeableConcept>)czzzzr_),
                Location = new List<ResourceReference>((IEnumerable<ResourceReference>)czzzzs_),
                HealthcareService = new List<ResourceReference>((IEnumerable<ResourceReference>)czzzzt_),
                Telecom = new List<ContactPoint>((IEnumerable<ContactPoint>)czzzzu_),
                AvailableTime = new List<PractitionerRole.AvailableTimeComponent>((IEnumerable<PractitionerRole.AvailableTimeComponent>)czzzzv_),
                NotAvailable = new List<PractitionerRole.NotAvailableComponent>((IEnumerable<PractitionerRole.NotAvailableComponent>)czzzzw_),
                AvailabilityExceptionsElement = czzzzx_,
                Endpoint = new List<ResourceReference>((IEnumerable<ResourceReference>)czzzzy_),
            };

            return czzzzz_;
        };
        IEnumerable<PractitionerRole> czzzzi_ = context.Operators.Select<PractitionerRole, PractitionerRole>((IEnumerable<PractitionerRole>)czzzzg_, czzzzh_);
        IEnumerable<PractitionerRole> czzzzj_ = context.Operators.Distinct<PractitionerRole>(czzzzi_);
        PractitionerRole czzzzk_ = context.Operators.SingletonFrom<PractitionerRole>(czzzzj_);

        return czzzzk_;
    }


    [CqlExpressionDefinition("ProcedureResource")]
    public Procedure ProcedureResource(CqlContext context, Procedure arg)
    {
        Procedure[] dzzzza_ = [
            arg,
        ];
        Procedure dzzzzb_(Procedure a)
        {
            List<Identifier> dzzzzf_ = a?.Identifier;
            List<Canonical> dzzzzg_ = a?.InstantiatesCanonicalElement;
            List<FhirUri> dzzzzh_ = a?.InstantiatesUriElement;
            List<ResourceReference> dzzzzi_ = a?.BasedOn;
            List<ResourceReference> dzzzzj_ = a?.PartOf;
            Code<EventStatus> dzzzzk_ = a?.StatusElement;
            CodeableConcept dzzzzl_ = a?.StatusReason;
            CodeableConcept dzzzzm_ = a?.Category;
            CodeableConcept dzzzzn_ = a?.Code;
            ResourceReference dzzzzo_ = a?.Subject;
            ResourceReference dzzzzp_ = a?.Encounter;
            DataType dzzzzq_ = a?.Performed;
            ResourceReference dzzzzr_ = a?.Recorder;
            ResourceReference dzzzzs_ = a?.Asserter;
            List<Procedure.PerformerComponent> dzzzzt_ = a?.Performer;
            ResourceReference dzzzzu_ = a?.Location;
            List<CodeableConcept> dzzzzv_ = a?.ReasonCode;
            List<ResourceReference> dzzzzw_ = a?.ReasonReference;
            List<CodeableConcept> dzzzzx_ = a?.BodySite;
            CodeableConcept dzzzzy_ = a?.Outcome;
            List<ResourceReference> dzzzzz_ = a?.Report;
            List<CodeableConcept> ezzzza_ = a?.Complication;
            List<ResourceReference> ezzzzb_ = a?.ComplicationDetail;
            List<CodeableConcept> ezzzzc_ = a?.FollowUp;
            List<Annotation> ezzzzd_ = a?.Note;
            List<Procedure.FocalDeviceComponent> ezzzze_ = a?.FocalDevice;
            List<ResourceReference> ezzzzf_ = a?.UsedReference;
            List<CodeableConcept> ezzzzg_ = a?.UsedCode;
            Procedure ezzzzh_ = new Procedure
            {
                Identifier = new List<Identifier>((IEnumerable<Identifier>)dzzzzf_),
                InstantiatesCanonicalElement = new List<Canonical>((IEnumerable<Canonical>)dzzzzg_),
                InstantiatesUriElement = new List<FhirUri>((IEnumerable<FhirUri>)dzzzzh_),
                BasedOn = new List<ResourceReference>((IEnumerable<ResourceReference>)dzzzzi_),
                PartOf = new List<ResourceReference>((IEnumerable<ResourceReference>)dzzzzj_),
                StatusElement = dzzzzk_,
                StatusReason = dzzzzl_,
                Category = dzzzzm_,
                Code = dzzzzn_,
                Subject = dzzzzo_,
                Encounter = dzzzzp_,
                Performed = (DataType)dzzzzq_,
                Recorder = dzzzzr_,
                Asserter = dzzzzs_,
                Performer = new List<Procedure.PerformerComponent>((IEnumerable<Procedure.PerformerComponent>)dzzzzt_),
                Location = dzzzzu_,
                ReasonCode = new List<CodeableConcept>((IEnumerable<CodeableConcept>)dzzzzv_),
                ReasonReference = new List<ResourceReference>((IEnumerable<ResourceReference>)dzzzzw_),
                BodySite = new List<CodeableConcept>((IEnumerable<CodeableConcept>)dzzzzx_),
                Outcome = dzzzzy_,
                Report = new List<ResourceReference>((IEnumerable<ResourceReference>)dzzzzz_),
                Complication = new List<CodeableConcept>((IEnumerable<CodeableConcept>)ezzzza_),
                ComplicationDetail = new List<ResourceReference>((IEnumerable<ResourceReference>)ezzzzb_),
                FollowUp = new List<CodeableConcept>((IEnumerable<CodeableConcept>)ezzzzc_),
                Note = new List<Annotation>((IEnumerable<Annotation>)ezzzzd_),
                FocalDevice = new List<Procedure.FocalDeviceComponent>((IEnumerable<Procedure.FocalDeviceComponent>)ezzzze_),
                UsedReference = new List<ResourceReference>((IEnumerable<ResourceReference>)ezzzzf_),
                UsedCode = new List<CodeableConcept>((IEnumerable<CodeableConcept>)ezzzzg_),
            };

            return ezzzzh_;
        };
        IEnumerable<Procedure> dzzzzc_ = context.Operators.Select<Procedure, Procedure>((IEnumerable<Procedure>)dzzzza_, dzzzzb_);
        IEnumerable<Procedure> dzzzzd_ = context.Operators.Distinct<Procedure>(dzzzzc_);
        Procedure dzzzze_ = context.Operators.SingletonFrom<Procedure>(dzzzzd_);

        return dzzzze_;
    }


    [CqlExpressionDefinition("ProvenanceResource")]
    public Provenance ProvenanceResource(CqlContext context, Provenance arg)
    {
        Provenance[] ezzzzi_ = [
            arg,
        ];
        Provenance ezzzzj_(Provenance a)
        {
            List<ResourceReference> ezzzzn_ = a?.Target;
            DataType ezzzzo_ = a?.Occurred;
            Instant ezzzzp_ = a?.RecordedElement;
            List<FhirUri> ezzzzq_ = a?.PolicyElement;
            ResourceReference ezzzzr_ = a?.Location;
            List<CodeableConcept> ezzzzs_ = a?.Reason;
            CodeableConcept ezzzzt_ = a?.Activity;
            List<Provenance.AgentComponent> ezzzzu_ = a?.Agent;
            List<Provenance.EntityComponent> ezzzzv_ = a?.Entity;
            List<Signature> ezzzzw_ = a?.Signature;
            Provenance ezzzzx_ = new Provenance
            {
                Target = new List<ResourceReference>((IEnumerable<ResourceReference>)ezzzzn_),
                Occurred = (DataType)ezzzzo_,
                RecordedElement = ezzzzp_,
                PolicyElement = new List<FhirUri>((IEnumerable<FhirUri>)ezzzzq_),
                Location = ezzzzr_,
                Reason = new List<CodeableConcept>((IEnumerable<CodeableConcept>)ezzzzs_),
                Activity = ezzzzt_,
                Agent = new List<Provenance.AgentComponent>((IEnumerable<Provenance.AgentComponent>)ezzzzu_),
                Entity = new List<Provenance.EntityComponent>((IEnumerable<Provenance.EntityComponent>)ezzzzv_),
                Signature = new List<Signature>((IEnumerable<Signature>)ezzzzw_),
            };

            return ezzzzx_;
        };
        IEnumerable<Provenance> ezzzzk_ = context.Operators.Select<Provenance, Provenance>((IEnumerable<Provenance>)ezzzzi_, ezzzzj_);
        IEnumerable<Provenance> ezzzzl_ = context.Operators.Distinct<Provenance>(ezzzzk_);
        Provenance ezzzzm_ = context.Operators.SingletonFrom<Provenance>(ezzzzl_);

        return ezzzzm_;
    }


    [CqlExpressionDefinition("QuestionnaireResponseResource")]
    public QuestionnaireResponse QuestionnaireResponseResource(CqlContext context, QuestionnaireResponse arg)
    {
        QuestionnaireResponse[] ezzzzy_ = [
            arg,
        ];
        QuestionnaireResponse ezzzzz_(QuestionnaireResponse a)
        {
            Identifier fzzzzd_ = a?.Identifier;
            List<ResourceReference> fzzzze_ = a?.BasedOn;
            List<ResourceReference> fzzzzf_ = a?.PartOf;
            Canonical fzzzzg_ = a?.QuestionnaireElement;
            Code<QuestionnaireResponse.QuestionnaireResponseStatus> fzzzzh_ = a?.StatusElement;
            ResourceReference fzzzzi_ = a?.Subject;
            ResourceReference fzzzzj_ = a?.Encounter;
            FhirDateTime fzzzzk_ = a?.AuthoredElement;
            ResourceReference fzzzzl_ = a?.Author;
            ResourceReference fzzzzm_ = a?.Source;
            List<QuestionnaireResponse.ItemComponent> fzzzzn_ = a?.Item;
            QuestionnaireResponse fzzzzo_ = new QuestionnaireResponse
            {
                Identifier = fzzzzd_,
                BasedOn = new List<ResourceReference>((IEnumerable<ResourceReference>)fzzzze_),
                PartOf = new List<ResourceReference>((IEnumerable<ResourceReference>)fzzzzf_),
                QuestionnaireElement = fzzzzg_,
                StatusElement = fzzzzh_,
                Subject = fzzzzi_,
                Encounter = fzzzzj_,
                AuthoredElement = fzzzzk_,
                Author = fzzzzl_,
                Source = fzzzzm_,
                Item = new List<QuestionnaireResponse.ItemComponent>((IEnumerable<QuestionnaireResponse.ItemComponent>)fzzzzn_),
            };

            return fzzzzo_;
        };
        IEnumerable<QuestionnaireResponse> fzzzza_ = context.Operators.Select<QuestionnaireResponse, QuestionnaireResponse>((IEnumerable<QuestionnaireResponse>)ezzzzy_, ezzzzz_);
        IEnumerable<QuestionnaireResponse> fzzzzb_ = context.Operators.Distinct<QuestionnaireResponse>(fzzzza_);
        QuestionnaireResponse fzzzzc_ = context.Operators.SingletonFrom<QuestionnaireResponse>(fzzzzb_);

        return fzzzzc_;
    }


    [CqlExpressionDefinition("RelatedPersonResource")]
    public RelatedPerson RelatedPersonResource(CqlContext context, RelatedPerson arg)
    {
        RelatedPerson[] fzzzzp_ = [
            arg,
        ];
        RelatedPerson fzzzzq_(RelatedPerson a)
        {
            List<Identifier> fzzzzu_ = a?.Identifier;
            FhirBoolean fzzzzv_ = a?.ActiveElement;
            ResourceReference fzzzzw_ = a?.Patient;
            List<CodeableConcept> fzzzzx_ = a?.Relationship;
            List<HumanName> fzzzzy_ = a?.Name;
            List<ContactPoint> fzzzzz_ = a?.Telecom;
            Code<AdministrativeGender> gzzzza_ = a?.GenderElement;
            Date gzzzzb_ = a?.BirthDateElement;
            List<Address> gzzzzc_ = a?.Address;
            List<Attachment> gzzzzd_ = a?.Photo;
            Period gzzzze_ = a?.Period;
            List<RelatedPerson.CommunicationComponent> gzzzzf_ = a?.Communication;
            RelatedPerson gzzzzg_ = new RelatedPerson
            {
                Identifier = new List<Identifier>((IEnumerable<Identifier>)fzzzzu_),
                ActiveElement = fzzzzv_,
                Patient = fzzzzw_,
                Relationship = new List<CodeableConcept>((IEnumerable<CodeableConcept>)fzzzzx_),
                Name = new List<HumanName>((IEnumerable<HumanName>)fzzzzy_),
                Telecom = new List<ContactPoint>((IEnumerable<ContactPoint>)fzzzzz_),
                GenderElement = gzzzza_,
                BirthDateElement = gzzzzb_,
                Address = new List<Address>((IEnumerable<Address>)gzzzzc_),
                Photo = new List<Attachment>((IEnumerable<Attachment>)gzzzzd_),
                Period = gzzzze_,
                Communication = new List<RelatedPerson.CommunicationComponent>((IEnumerable<RelatedPerson.CommunicationComponent>)gzzzzf_),
            };

            return gzzzzg_;
        };
        IEnumerable<RelatedPerson> fzzzzr_ = context.Operators.Select<RelatedPerson, RelatedPerson>((IEnumerable<RelatedPerson>)fzzzzp_, fzzzzq_);
        IEnumerable<RelatedPerson> fzzzzs_ = context.Operators.Distinct<RelatedPerson>(fzzzzr_);
        RelatedPerson fzzzzt_ = context.Operators.SingletonFrom<RelatedPerson>(fzzzzs_);

        return fzzzzt_;
    }


    [CqlExpressionDefinition("RequestGroupResource")]
    public RequestGroup RequestGroupResource(CqlContext context, RequestGroup arg)
    {
        RequestGroup[] gzzzzh_ = [
            arg,
        ];
        RequestGroup gzzzzi_(RequestGroup a)
        {
            List<Identifier> gzzzzm_ = a?.Identifier;
            List<Canonical> gzzzzn_ = a?.InstantiatesCanonicalElement;
            List<FhirUri> gzzzzo_ = a?.InstantiatesUriElement;
            List<ResourceReference> gzzzzp_ = a?.BasedOn;
            List<ResourceReference> gzzzzq_ = a?.Replaces;
            Identifier gzzzzr_ = a?.GroupIdentifier;
            Code<RequestStatus> gzzzzs_ = a?.StatusElement;
            Code<RequestIntent> gzzzzt_ = a?.IntentElement;
            Code<RequestPriority> gzzzzu_ = a?.PriorityElement;
            CodeableConcept gzzzzv_ = a?.Code;
            ResourceReference gzzzzw_ = a?.Subject;
            ResourceReference gzzzzx_ = a?.Encounter;
            FhirDateTime gzzzzy_ = a?.AuthoredOnElement;
            ResourceReference gzzzzz_ = a?.Author;
            List<CodeableConcept> hzzzza_ = a?.ReasonCode;
            List<ResourceReference> hzzzzb_ = a?.ReasonReference;
            List<Annotation> hzzzzc_ = a?.Note;
            List<RequestGroup.ActionComponent> hzzzzd_ = a?.Action;
            RequestGroup hzzzze_ = new RequestGroup
            {
                Identifier = new List<Identifier>((IEnumerable<Identifier>)gzzzzm_),
                InstantiatesCanonicalElement = new List<Canonical>((IEnumerable<Canonical>)gzzzzn_),
                InstantiatesUriElement = new List<FhirUri>((IEnumerable<FhirUri>)gzzzzo_),
                BasedOn = new List<ResourceReference>((IEnumerable<ResourceReference>)gzzzzp_),
                Replaces = new List<ResourceReference>((IEnumerable<ResourceReference>)gzzzzq_),
                GroupIdentifier = gzzzzr_,
                StatusElement = gzzzzs_,
                IntentElement = gzzzzt_,
                PriorityElement = gzzzzu_,
                Code = gzzzzv_,
                Subject = gzzzzw_,
                Encounter = gzzzzx_,
                AuthoredOnElement = gzzzzy_,
                Author = gzzzzz_,
                ReasonCode = new List<CodeableConcept>((IEnumerable<CodeableConcept>)hzzzza_),
                ReasonReference = new List<ResourceReference>((IEnumerable<ResourceReference>)hzzzzb_),
                Note = new List<Annotation>((IEnumerable<Annotation>)hzzzzc_),
                Action = new List<RequestGroup.ActionComponent>((IEnumerable<RequestGroup.ActionComponent>)hzzzzd_),
            };

            return hzzzze_;
        };
        IEnumerable<RequestGroup> gzzzzj_ = context.Operators.Select<RequestGroup, RequestGroup>((IEnumerable<RequestGroup>)gzzzzh_, gzzzzi_);
        IEnumerable<RequestGroup> gzzzzk_ = context.Operators.Distinct<RequestGroup>(gzzzzj_);
        RequestGroup gzzzzl_ = context.Operators.SingletonFrom<RequestGroup>(gzzzzk_);

        return gzzzzl_;
    }


    [CqlExpressionDefinition("ResearchDefinitionResource")]
    public ResearchDefinition ResearchDefinitionResource(CqlContext context, ResearchDefinition arg)
    {
        ResearchDefinition[] hzzzzf_ = [
            arg,
        ];
        ResearchDefinition hzzzzg_(ResearchDefinition a)
        {
            FhirUri hzzzzk_ = a?.UrlElement;
            List<Identifier> hzzzzl_ = a?.Identifier;
            FhirString hzzzzm_ = a?.VersionElement;
            FhirString hzzzzn_ = a?.NameElement;
            FhirString hzzzzo_ = a?.TitleElement;
            FhirString hzzzzp_ = a?.ShortTitleElement;
            FhirString hzzzzq_ = a?.SubtitleElement;
            Code<PublicationStatus> hzzzzr_ = a?.StatusElement;
            FhirBoolean hzzzzs_ = a?.ExperimentalElement;
            DataType hzzzzt_ = a?.Subject;
            FhirDateTime hzzzzu_ = a?.DateElement;
            FhirString hzzzzv_ = a?.PublisherElement;
            List<ContactDetail> hzzzzw_ = a?.Contact;
            Markdown hzzzzx_ = a?.DescriptionElement;
            List<FhirString> hzzzzy_ = a?.CommentElement;
            List<UsageContext> hzzzzz_ = a?.UseContext;
            List<CodeableConcept> izzzza_ = a?.Jurisdiction;
            Markdown izzzzb_ = a?.PurposeElement;
            FhirString izzzzc_ = a?.UsageElement;
            Markdown izzzzd_ = a?.CopyrightElement;
            Date izzzze_ = a?.ApprovalDateElement;
            Date izzzzf_ = a?.LastReviewDateElement;
            Period izzzzg_ = a?.EffectivePeriod;
            List<CodeableConcept> izzzzh_ = a?.Topic;
            List<ContactDetail> izzzzi_ = a?.Author;
            List<ContactDetail> izzzzj_ = a?.Editor;
            List<ContactDetail> izzzzk_ = a?.Reviewer;
            List<ContactDetail> izzzzl_ = a?.Endorser;
            List<RelatedArtifact> izzzzm_ = a?.RelatedArtifact;
            List<Canonical> izzzzn_ = a?.LibraryElement;
            ResourceReference izzzzo_ = a?.Population;
            ResourceReference izzzzp_ = a?.Exposure;
            ResourceReference izzzzq_ = a?.ExposureAlternative;
            ResourceReference izzzzr_ = a?.Outcome;
            ResearchDefinition izzzzs_ = new ResearchDefinition
            {
                UrlElement = hzzzzk_,
                Identifier = new List<Identifier>((IEnumerable<Identifier>)hzzzzl_),
                VersionElement = hzzzzm_,
                NameElement = hzzzzn_,
                TitleElement = hzzzzo_,
                ShortTitleElement = hzzzzp_,
                SubtitleElement = hzzzzq_,
                StatusElement = hzzzzr_,
                ExperimentalElement = hzzzzs_,
                Subject = (DataType)hzzzzt_,
                DateElement = hzzzzu_,
                PublisherElement = hzzzzv_,
                Contact = new List<ContactDetail>((IEnumerable<ContactDetail>)hzzzzw_),
                DescriptionElement = hzzzzx_,
                CommentElement = new List<FhirString>((IEnumerable<FhirString>)hzzzzy_),
                UseContext = new List<UsageContext>((IEnumerable<UsageContext>)hzzzzz_),
                Jurisdiction = new List<CodeableConcept>((IEnumerable<CodeableConcept>)izzzza_),
                PurposeElement = izzzzb_,
                UsageElement = izzzzc_,
                CopyrightElement = izzzzd_,
                ApprovalDateElement = izzzze_,
                LastReviewDateElement = izzzzf_,
                EffectivePeriod = izzzzg_,
                Topic = new List<CodeableConcept>((IEnumerable<CodeableConcept>)izzzzh_),
                Author = new List<ContactDetail>((IEnumerable<ContactDetail>)izzzzi_),
                Editor = new List<ContactDetail>((IEnumerable<ContactDetail>)izzzzj_),
                Reviewer = new List<ContactDetail>((IEnumerable<ContactDetail>)izzzzk_),
                Endorser = new List<ContactDetail>((IEnumerable<ContactDetail>)izzzzl_),
                RelatedArtifact = new List<RelatedArtifact>((IEnumerable<RelatedArtifact>)izzzzm_),
                LibraryElement = new List<Canonical>((IEnumerable<Canonical>)izzzzn_),
                Population = izzzzo_,
                Exposure = izzzzp_,
                ExposureAlternative = izzzzq_,
                Outcome = izzzzr_,
            };

            return izzzzs_;
        };
        IEnumerable<ResearchDefinition> hzzzzh_ = context.Operators.Select<ResearchDefinition, ResearchDefinition>((IEnumerable<ResearchDefinition>)hzzzzf_, hzzzzg_);
        IEnumerable<ResearchDefinition> hzzzzi_ = context.Operators.Distinct<ResearchDefinition>(hzzzzh_);
        ResearchDefinition hzzzzj_ = context.Operators.SingletonFrom<ResearchDefinition>(hzzzzi_);

        return hzzzzj_;
    }


    [CqlExpressionDefinition("ResearchElementDefinitionResource")]
    public ResearchElementDefinition ResearchElementDefinitionResource(CqlContext context, ResearchElementDefinition arg)
    {
        ResearchElementDefinition[] izzzzt_ = [
            arg,
        ];
        ResearchElementDefinition izzzzu_(ResearchElementDefinition a)
        {
            FhirUri izzzzy_ = a?.UrlElement;
            List<Identifier> izzzzz_ = a?.Identifier;
            FhirString jzzzza_ = a?.VersionElement;
            FhirString jzzzzb_ = a?.NameElement;
            FhirString jzzzzc_ = a?.TitleElement;
            FhirString jzzzzd_ = a?.ShortTitleElement;
            FhirString jzzzze_ = a?.SubtitleElement;
            Code<PublicationStatus> jzzzzf_ = a?.StatusElement;
            FhirBoolean jzzzzg_ = a?.ExperimentalElement;
            DataType jzzzzh_ = a?.Subject;
            FhirDateTime jzzzzi_ = a?.DateElement;
            FhirString jzzzzj_ = a?.PublisherElement;
            List<ContactDetail> jzzzzk_ = a?.Contact;
            Markdown jzzzzl_ = a?.DescriptionElement;
            List<FhirString> jzzzzm_ = a?.CommentElement;
            List<UsageContext> jzzzzn_ = a?.UseContext;
            List<CodeableConcept> jzzzzo_ = a?.Jurisdiction;
            Markdown jzzzzp_ = a?.PurposeElement;
            FhirString jzzzzq_ = a?.UsageElement;
            Markdown jzzzzr_ = a?.CopyrightElement;
            Date jzzzzs_ = a?.ApprovalDateElement;
            Date jzzzzt_ = a?.LastReviewDateElement;
            Period jzzzzu_ = a?.EffectivePeriod;
            List<CodeableConcept> jzzzzv_ = a?.Topic;
            List<ContactDetail> jzzzzw_ = a?.Author;
            List<ContactDetail> jzzzzx_ = a?.Editor;
            List<ContactDetail> jzzzzy_ = a?.Reviewer;
            List<ContactDetail> jzzzzz_ = a?.Endorser;
            List<RelatedArtifact> kzzzza_ = a?.RelatedArtifact;
            List<Canonical> kzzzzb_ = a?.LibraryElement;
            Code<ResearchElementDefinition.ResearchElementType> kzzzzc_ = a?.TypeElement;
            Code<VariableTypeCode> kzzzzd_ = a?.VariableTypeElement;
            List<ResearchElementDefinition.CharacteristicComponent> kzzzze_ = a?.Characteristic;
            ResearchElementDefinition kzzzzf_ = new ResearchElementDefinition
            {
                UrlElement = izzzzy_,
                Identifier = new List<Identifier>((IEnumerable<Identifier>)izzzzz_),
                VersionElement = jzzzza_,
                NameElement = jzzzzb_,
                TitleElement = jzzzzc_,
                ShortTitleElement = jzzzzd_,
                SubtitleElement = jzzzze_,
                StatusElement = jzzzzf_,
                ExperimentalElement = jzzzzg_,
                Subject = (DataType)jzzzzh_,
                DateElement = jzzzzi_,
                PublisherElement = jzzzzj_,
                Contact = new List<ContactDetail>((IEnumerable<ContactDetail>)jzzzzk_),
                DescriptionElement = jzzzzl_,
                CommentElement = new List<FhirString>((IEnumerable<FhirString>)jzzzzm_),
                UseContext = new List<UsageContext>((IEnumerable<UsageContext>)jzzzzn_),
                Jurisdiction = new List<CodeableConcept>((IEnumerable<CodeableConcept>)jzzzzo_),
                PurposeElement = jzzzzp_,
                UsageElement = jzzzzq_,
                CopyrightElement = jzzzzr_,
                ApprovalDateElement = jzzzzs_,
                LastReviewDateElement = jzzzzt_,
                EffectivePeriod = jzzzzu_,
                Topic = new List<CodeableConcept>((IEnumerable<CodeableConcept>)jzzzzv_),
                Author = new List<ContactDetail>((IEnumerable<ContactDetail>)jzzzzw_),
                Editor = new List<ContactDetail>((IEnumerable<ContactDetail>)jzzzzx_),
                Reviewer = new List<ContactDetail>((IEnumerable<ContactDetail>)jzzzzy_),
                Endorser = new List<ContactDetail>((IEnumerable<ContactDetail>)jzzzzz_),
                RelatedArtifact = new List<RelatedArtifact>((IEnumerable<RelatedArtifact>)kzzzza_),
                LibraryElement = new List<Canonical>((IEnumerable<Canonical>)kzzzzb_),
                TypeElement = kzzzzc_,
                VariableTypeElement = kzzzzd_,
                Characteristic = new List<ResearchElementDefinition.CharacteristicComponent>((IEnumerable<ResearchElementDefinition.CharacteristicComponent>)kzzzze_),
            };

            return kzzzzf_;
        };
        IEnumerable<ResearchElementDefinition> izzzzv_ = context.Operators.Select<ResearchElementDefinition, ResearchElementDefinition>((IEnumerable<ResearchElementDefinition>)izzzzt_, izzzzu_);
        IEnumerable<ResearchElementDefinition> izzzzw_ = context.Operators.Distinct<ResearchElementDefinition>(izzzzv_);
        ResearchElementDefinition izzzzx_ = context.Operators.SingletonFrom<ResearchElementDefinition>(izzzzw_);

        return izzzzx_;
    }


    [CqlExpressionDefinition("ResearchStudyResource")]
    public ResearchStudy ResearchStudyResource(CqlContext context, ResearchStudy arg)
    {
        ResearchStudy[] kzzzzg_ = [
            arg,
        ];
        ResearchStudy kzzzzh_(ResearchStudy a)
        {
            List<Identifier> kzzzzl_ = a?.Identifier;
            FhirString kzzzzm_ = a?.TitleElement;
            List<ResourceReference> kzzzzn_ = a?.Protocol;
            List<ResourceReference> kzzzzo_ = a?.PartOf;
            Code<ResearchStudy.ResearchStudyStatus> kzzzzp_ = a?.StatusElement;
            CodeableConcept kzzzzq_ = a?.PrimaryPurposeType;
            CodeableConcept kzzzzr_ = a?.Phase;
            List<CodeableConcept> kzzzzs_ = a?.Category;
            List<CodeableConcept> kzzzzt_ = a?.Focus;
            List<CodeableConcept> kzzzzu_ = a?.Condition;
            List<ContactDetail> kzzzzv_ = a?.Contact;
            List<RelatedArtifact> kzzzzw_ = a?.RelatedArtifact;
            List<CodeableConcept> kzzzzx_ = a?.Keyword;
            List<CodeableConcept> kzzzzy_ = a?.Location;
            Markdown kzzzzz_ = a?.DescriptionElement;
            List<ResourceReference> lzzzza_ = a?.Enrollment;
            Period lzzzzb_ = a?.Period;
            ResourceReference lzzzzc_ = a?.Sponsor;
            ResourceReference lzzzzd_ = a?.PrincipalInvestigator;
            List<ResourceReference> lzzzze_ = a?.Site;
            CodeableConcept lzzzzf_ = a?.ReasonStopped;
            List<Annotation> lzzzzg_ = a?.Note;
            List<ResearchStudy.ArmComponent> lzzzzh_ = a?.Arm;
            List<ResearchStudy.ObjectiveComponent> lzzzzi_ = a?.Objective;
            ResearchStudy lzzzzj_ = new ResearchStudy
            {
                Identifier = new List<Identifier>((IEnumerable<Identifier>)kzzzzl_),
                TitleElement = kzzzzm_,
                Protocol = new List<ResourceReference>((IEnumerable<ResourceReference>)kzzzzn_),
                PartOf = new List<ResourceReference>((IEnumerable<ResourceReference>)kzzzzo_),
                StatusElement = kzzzzp_,
                PrimaryPurposeType = kzzzzq_,
                Phase = kzzzzr_,
                Category = new List<CodeableConcept>((IEnumerable<CodeableConcept>)kzzzzs_),
                Focus = new List<CodeableConcept>((IEnumerable<CodeableConcept>)kzzzzt_),
                Condition = new List<CodeableConcept>((IEnumerable<CodeableConcept>)kzzzzu_),
                Contact = new List<ContactDetail>((IEnumerable<ContactDetail>)kzzzzv_),
                RelatedArtifact = new List<RelatedArtifact>((IEnumerable<RelatedArtifact>)kzzzzw_),
                Keyword = new List<CodeableConcept>((IEnumerable<CodeableConcept>)kzzzzx_),
                Location = new List<CodeableConcept>((IEnumerable<CodeableConcept>)kzzzzy_),
                DescriptionElement = kzzzzz_,
                Enrollment = new List<ResourceReference>((IEnumerable<ResourceReference>)lzzzza_),
                Period = lzzzzb_,
                Sponsor = lzzzzc_,
                PrincipalInvestigator = lzzzzd_,
                Site = new List<ResourceReference>((IEnumerable<ResourceReference>)lzzzze_),
                ReasonStopped = lzzzzf_,
                Note = new List<Annotation>((IEnumerable<Annotation>)lzzzzg_),
                Arm = new List<ResearchStudy.ArmComponent>((IEnumerable<ResearchStudy.ArmComponent>)lzzzzh_),
                Objective = new List<ResearchStudy.ObjectiveComponent>((IEnumerable<ResearchStudy.ObjectiveComponent>)lzzzzi_),
            };

            return lzzzzj_;
        };
        IEnumerable<ResearchStudy> kzzzzi_ = context.Operators.Select<ResearchStudy, ResearchStudy>((IEnumerable<ResearchStudy>)kzzzzg_, kzzzzh_);
        IEnumerable<ResearchStudy> kzzzzj_ = context.Operators.Distinct<ResearchStudy>(kzzzzi_);
        ResearchStudy kzzzzk_ = context.Operators.SingletonFrom<ResearchStudy>(kzzzzj_);

        return kzzzzk_;
    }


    [CqlExpressionDefinition("ResearchSubjectResource")]
    public ResearchSubject ResearchSubjectResource(CqlContext context, ResearchSubject arg)
    {
        ResearchSubject[] lzzzzk_ = [
            arg,
        ];
        ResearchSubject lzzzzl_(ResearchSubject a)
        {
            List<Identifier> lzzzzp_ = a?.Identifier;
            Code<ResearchSubject.ResearchSubjectStatus> lzzzzq_ = a?.StatusElement;
            Period lzzzzr_ = a?.Period;
            ResourceReference lzzzzs_ = a?.Study;
            ResourceReference lzzzzt_ = a?.Individual;
            FhirString lzzzzu_ = a?.AssignedArmElement;
            FhirString lzzzzv_ = a?.ActualArmElement;
            ResourceReference lzzzzw_ = a?.Consent;
            ResearchSubject lzzzzx_ = new ResearchSubject
            {
                Identifier = new List<Identifier>((IEnumerable<Identifier>)lzzzzp_),
                StatusElement = lzzzzq_,
                Period = lzzzzr_,
                Study = lzzzzs_,
                Individual = lzzzzt_,
                AssignedArmElement = lzzzzu_,
                ActualArmElement = lzzzzv_,
                Consent = lzzzzw_,
            };

            return lzzzzx_;
        };
        IEnumerable<ResearchSubject> lzzzzm_ = context.Operators.Select<ResearchSubject, ResearchSubject>((IEnumerable<ResearchSubject>)lzzzzk_, lzzzzl_);
        IEnumerable<ResearchSubject> lzzzzn_ = context.Operators.Distinct<ResearchSubject>(lzzzzm_);
        ResearchSubject lzzzzo_ = context.Operators.SingletonFrom<ResearchSubject>(lzzzzn_);

        return lzzzzo_;
    }


    [CqlExpressionDefinition("RiskAssessmentResource")]
    public RiskAssessment RiskAssessmentResource(CqlContext context, RiskAssessment arg)
    {
        RiskAssessment[] lzzzzy_ = [
            arg,
        ];
        RiskAssessment lzzzzz_(RiskAssessment a)
        {
            List<Identifier> mzzzzd_ = a?.Identifier;
            ResourceReference mzzzze_ = a?.BasedOn;
            ResourceReference mzzzzf_ = a?.Parent;
            Code<ObservationStatus> mzzzzg_ = a?.StatusElement;
            CodeableConcept mzzzzh_ = a?.Method;
            CodeableConcept mzzzzi_ = a?.Code;
            ResourceReference mzzzzj_ = a?.Subject;
            ResourceReference mzzzzk_ = a?.Encounter;
            DataType mzzzzl_ = a?.Occurrence;
            ResourceReference mzzzzm_ = a?.Condition;
            ResourceReference mzzzzn_ = a?.Performer;
            List<CodeableConcept> mzzzzo_ = a?.ReasonCode;
            List<ResourceReference> mzzzzp_ = a?.ReasonReference;
            List<ResourceReference> mzzzzq_ = a?.Basis;
            List<RiskAssessment.PredictionComponent> mzzzzr_ = a?.Prediction;
            FhirString mzzzzs_ = a?.MitigationElement;
            List<Annotation> mzzzzt_ = a?.Note;
            RiskAssessment mzzzzu_ = new RiskAssessment
            {
                Identifier = new List<Identifier>((IEnumerable<Identifier>)mzzzzd_),
                BasedOn = mzzzze_,
                Parent = mzzzzf_,
                StatusElement = mzzzzg_,
                Method = mzzzzh_,
                Code = mzzzzi_,
                Subject = mzzzzj_,
                Encounter = mzzzzk_,
                Occurrence = (DataType)mzzzzl_,
                Condition = mzzzzm_,
                Performer = mzzzzn_,
                ReasonCode = new List<CodeableConcept>((IEnumerable<CodeableConcept>)mzzzzo_),
                ReasonReference = new List<ResourceReference>((IEnumerable<ResourceReference>)mzzzzp_),
                Basis = new List<ResourceReference>((IEnumerable<ResourceReference>)mzzzzq_),
                Prediction = new List<RiskAssessment.PredictionComponent>((IEnumerable<RiskAssessment.PredictionComponent>)mzzzzr_),
                MitigationElement = mzzzzs_,
                Note = new List<Annotation>((IEnumerable<Annotation>)mzzzzt_),
            };

            return mzzzzu_;
        };
        IEnumerable<RiskAssessment> mzzzza_ = context.Operators.Select<RiskAssessment, RiskAssessment>((IEnumerable<RiskAssessment>)lzzzzy_, lzzzzz_);
        IEnumerable<RiskAssessment> mzzzzb_ = context.Operators.Distinct<RiskAssessment>(mzzzza_);
        RiskAssessment mzzzzc_ = context.Operators.SingletonFrom<RiskAssessment>(mzzzzb_);

        return mzzzzc_;
    }


    [CqlExpressionDefinition("RiskEvidenceSynthesisResource")]
    public RiskEvidenceSynthesis RiskEvidenceSynthesisResource(CqlContext context, RiskEvidenceSynthesis arg)
    {
        RiskEvidenceSynthesis[] mzzzzv_ = [
            arg,
        ];
        RiskEvidenceSynthesis mzzzzw_(RiskEvidenceSynthesis a)
        {
            FhirUri nzzzza_ = a?.UrlElement;
            List<Identifier> nzzzzb_ = a?.Identifier;
            FhirString nzzzzc_ = a?.VersionElement;
            FhirString nzzzzd_ = a?.NameElement;
            FhirString nzzzze_ = a?.TitleElement;
            Code<PublicationStatus> nzzzzf_ = a?.StatusElement;
            FhirDateTime nzzzzg_ = a?.DateElement;
            FhirString nzzzzh_ = a?.PublisherElement;
            List<ContactDetail> nzzzzi_ = a?.Contact;
            Markdown nzzzzj_ = a?.DescriptionElement;
            List<Annotation> nzzzzk_ = a?.Note;
            List<UsageContext> nzzzzl_ = a?.UseContext;
            List<CodeableConcept> nzzzzm_ = a?.Jurisdiction;
            Markdown nzzzzn_ = a?.CopyrightElement;
            Date nzzzzo_ = a?.ApprovalDateElement;
            Date nzzzzp_ = a?.LastReviewDateElement;
            Period nzzzzq_ = a?.EffectivePeriod;
            List<CodeableConcept> nzzzzr_ = a?.Topic;
            List<ContactDetail> nzzzzs_ = a?.Author;
            List<ContactDetail> nzzzzt_ = a?.Editor;
            List<ContactDetail> nzzzzu_ = a?.Reviewer;
            List<ContactDetail> nzzzzv_ = a?.Endorser;
            List<RelatedArtifact> nzzzzw_ = a?.RelatedArtifact;
            CodeableConcept nzzzzx_ = a?.SynthesisType;
            CodeableConcept nzzzzy_ = a?.StudyType;
            ResourceReference nzzzzz_ = a?.Population;
            ResourceReference ozzzza_ = a?.Exposure;
            ResourceReference ozzzzb_ = a?.Outcome;
            RiskEvidenceSynthesis.SampleSizeComponent ozzzzc_ = a?.SampleSize;
            RiskEvidenceSynthesis.RiskEstimateComponent ozzzzd_ = a?.RiskEstimate;
            List<RiskEvidenceSynthesis.CertaintyComponent> ozzzze_ = a?.Certainty;
            RiskEvidenceSynthesis ozzzzf_ = new RiskEvidenceSynthesis
            {
                UrlElement = nzzzza_,
                Identifier = new List<Identifier>((IEnumerable<Identifier>)nzzzzb_),
                VersionElement = nzzzzc_,
                NameElement = nzzzzd_,
                TitleElement = nzzzze_,
                StatusElement = nzzzzf_,
                DateElement = nzzzzg_,
                PublisherElement = nzzzzh_,
                Contact = new List<ContactDetail>((IEnumerable<ContactDetail>)nzzzzi_),
                DescriptionElement = nzzzzj_,
                Note = new List<Annotation>((IEnumerable<Annotation>)nzzzzk_),
                UseContext = new List<UsageContext>((IEnumerable<UsageContext>)nzzzzl_),
                Jurisdiction = new List<CodeableConcept>((IEnumerable<CodeableConcept>)nzzzzm_),
                CopyrightElement = nzzzzn_,
                ApprovalDateElement = nzzzzo_,
                LastReviewDateElement = nzzzzp_,
                EffectivePeriod = nzzzzq_,
                Topic = new List<CodeableConcept>((IEnumerable<CodeableConcept>)nzzzzr_),
                Author = new List<ContactDetail>((IEnumerable<ContactDetail>)nzzzzs_),
                Editor = new List<ContactDetail>((IEnumerable<ContactDetail>)nzzzzt_),
                Reviewer = new List<ContactDetail>((IEnumerable<ContactDetail>)nzzzzu_),
                Endorser = new List<ContactDetail>((IEnumerable<ContactDetail>)nzzzzv_),
                RelatedArtifact = new List<RelatedArtifact>((IEnumerable<RelatedArtifact>)nzzzzw_),
                SynthesisType = nzzzzx_,
                StudyType = nzzzzy_,
                Population = nzzzzz_,
                Exposure = ozzzza_,
                Outcome = ozzzzb_,
                SampleSize = ozzzzc_,
                RiskEstimate = ozzzzd_,
                Certainty = new List<RiskEvidenceSynthesis.CertaintyComponent>((IEnumerable<RiskEvidenceSynthesis.CertaintyComponent>)ozzzze_),
            };

            return ozzzzf_;
        };
        IEnumerable<RiskEvidenceSynthesis> mzzzzx_ = context.Operators.Select<RiskEvidenceSynthesis, RiskEvidenceSynthesis>((IEnumerable<RiskEvidenceSynthesis>)mzzzzv_, mzzzzw_);
        IEnumerable<RiskEvidenceSynthesis> mzzzzy_ = context.Operators.Distinct<RiskEvidenceSynthesis>(mzzzzx_);
        RiskEvidenceSynthesis mzzzzz_ = context.Operators.SingletonFrom<RiskEvidenceSynthesis>(mzzzzy_);

        return mzzzzz_;
    }


    [CqlExpressionDefinition("ScheduleResource")]
    public Schedule ScheduleResource(CqlContext context, Schedule arg)
    {
        Schedule[] ozzzzg_ = [
            arg,
        ];
        Schedule ozzzzh_(Schedule a)
        {
            List<Identifier> ozzzzl_ = a?.Identifier;
            FhirBoolean ozzzzm_ = a?.ActiveElement;
            List<CodeableConcept> ozzzzn_ = a?.ServiceCategory;
            List<CodeableConcept> ozzzzo_ = a?.ServiceType;
            List<CodeableConcept> ozzzzp_ = a?.Specialty;
            List<ResourceReference> ozzzzq_ = a?.Actor;
            Period ozzzzr_ = a?.PlanningHorizon;
            FhirString ozzzzs_ = a?.CommentElement;
            Schedule ozzzzt_ = new Schedule
            {
                Identifier = new List<Identifier>((IEnumerable<Identifier>)ozzzzl_),
                ActiveElement = ozzzzm_,
                ServiceCategory = new List<CodeableConcept>((IEnumerable<CodeableConcept>)ozzzzn_),
                ServiceType = new List<CodeableConcept>((IEnumerable<CodeableConcept>)ozzzzo_),
                Specialty = new List<CodeableConcept>((IEnumerable<CodeableConcept>)ozzzzp_),
                Actor = new List<ResourceReference>((IEnumerable<ResourceReference>)ozzzzq_),
                PlanningHorizon = ozzzzr_,
                CommentElement = ozzzzs_,
            };

            return ozzzzt_;
        };
        IEnumerable<Schedule> ozzzzi_ = context.Operators.Select<Schedule, Schedule>((IEnumerable<Schedule>)ozzzzg_, ozzzzh_);
        IEnumerable<Schedule> ozzzzj_ = context.Operators.Distinct<Schedule>(ozzzzi_);
        Schedule ozzzzk_ = context.Operators.SingletonFrom<Schedule>(ozzzzj_);

        return ozzzzk_;
    }


    [CqlExpressionDefinition("ServiceRequestResource")]
    public ServiceRequest ServiceRequestResource(CqlContext context, ServiceRequest arg)
    {
        ServiceRequest[] ozzzzu_ = [
            arg,
        ];
        ServiceRequest ozzzzv_(ServiceRequest a)
        {
            List<Identifier> ozzzzz_ = a?.Identifier;
            List<Canonical> pzzzza_ = a?.InstantiatesCanonicalElement;
            List<FhirUri> pzzzzb_ = a?.InstantiatesUriElement;
            List<ResourceReference> pzzzzc_ = a?.BasedOn;
            List<ResourceReference> pzzzzd_ = a?.Replaces;
            Identifier pzzzze_ = a?.Requisition;
            Code<RequestStatus> pzzzzf_ = a?.StatusElement;
            Code<RequestIntent> pzzzzg_ = a?.IntentElement;
            List<CodeableConcept> pzzzzh_ = a?.Category;
            Code<RequestPriority> pzzzzi_ = a?.PriorityElement;
            FhirBoolean pzzzzj_ = a?.DoNotPerformElement;
            CodeableConcept pzzzzk_ = a?.Code;
            List<CodeableConcept> pzzzzl_ = a?.OrderDetail;
            DataType pzzzzm_ = a?.Quantity;
            ResourceReference pzzzzn_ = a?.Subject;
            ResourceReference pzzzzo_ = a?.Encounter;
            DataType pzzzzp_ = a?.Occurrence;
            DataType pzzzzq_ = a?.AsNeeded;
            FhirDateTime pzzzzr_ = a?.AuthoredOnElement;
            ResourceReference pzzzzs_ = a?.Requester;
            CodeableConcept pzzzzt_ = a?.PerformerType;
            List<ResourceReference> pzzzzu_ = a?.Performer;
            List<CodeableConcept> pzzzzv_ = a?.LocationCode;
            List<ResourceReference> pzzzzw_ = a?.LocationReference;
            List<CodeableConcept> pzzzzx_ = a?.ReasonCode;
            List<ResourceReference> pzzzzy_ = a?.ReasonReference;
            List<ResourceReference> pzzzzz_ = a?.Insurance;
            List<ResourceReference> qzzzza_ = a?.SupportingInfo;
            List<ResourceReference> qzzzzb_ = a?.Specimen;
            List<CodeableConcept> qzzzzc_ = a?.BodySite;
            List<Annotation> qzzzzd_ = a?.Note;
            FhirString qzzzze_ = a?.PatientInstructionElement;
            List<ResourceReference> qzzzzf_ = a?.RelevantHistory;
            ServiceRequest qzzzzg_ = new ServiceRequest
            {
                Identifier = new List<Identifier>((IEnumerable<Identifier>)ozzzzz_),
                InstantiatesCanonicalElement = new List<Canonical>((IEnumerable<Canonical>)pzzzza_),
                InstantiatesUriElement = new List<FhirUri>((IEnumerable<FhirUri>)pzzzzb_),
                BasedOn = new List<ResourceReference>((IEnumerable<ResourceReference>)pzzzzc_),
                Replaces = new List<ResourceReference>((IEnumerable<ResourceReference>)pzzzzd_),
                Requisition = pzzzze_,
                StatusElement = pzzzzf_,
                IntentElement = pzzzzg_,
                Category = new List<CodeableConcept>((IEnumerable<CodeableConcept>)pzzzzh_),
                PriorityElement = pzzzzi_,
                DoNotPerformElement = pzzzzj_,
                Code = pzzzzk_,
                OrderDetail = new List<CodeableConcept>((IEnumerable<CodeableConcept>)pzzzzl_),
                Quantity = (DataType)pzzzzm_,
                Subject = pzzzzn_,
                Encounter = pzzzzo_,
                Occurrence = (DataType)pzzzzp_,
                AsNeeded = (DataType)pzzzzq_,
                AuthoredOnElement = pzzzzr_,
                Requester = pzzzzs_,
                PerformerType = pzzzzt_,
                Performer = new List<ResourceReference>((IEnumerable<ResourceReference>)pzzzzu_),
                LocationCode = new List<CodeableConcept>((IEnumerable<CodeableConcept>)pzzzzv_),
                LocationReference = new List<ResourceReference>((IEnumerable<ResourceReference>)pzzzzw_),
                ReasonCode = new List<CodeableConcept>((IEnumerable<CodeableConcept>)pzzzzx_),
                ReasonReference = new List<ResourceReference>((IEnumerable<ResourceReference>)pzzzzy_),
                Insurance = new List<ResourceReference>((IEnumerable<ResourceReference>)pzzzzz_),
                SupportingInfo = new List<ResourceReference>((IEnumerable<ResourceReference>)qzzzza_),
                Specimen = new List<ResourceReference>((IEnumerable<ResourceReference>)qzzzzb_),
                BodySite = new List<CodeableConcept>((IEnumerable<CodeableConcept>)qzzzzc_),
                Note = new List<Annotation>((IEnumerable<Annotation>)qzzzzd_),
                PatientInstructionElement = qzzzze_,
                RelevantHistory = new List<ResourceReference>((IEnumerable<ResourceReference>)qzzzzf_),
            };

            return qzzzzg_;
        };
        IEnumerable<ServiceRequest> ozzzzw_ = context.Operators.Select<ServiceRequest, ServiceRequest>((IEnumerable<ServiceRequest>)ozzzzu_, ozzzzv_);
        IEnumerable<ServiceRequest> ozzzzx_ = context.Operators.Distinct<ServiceRequest>(ozzzzw_);
        ServiceRequest ozzzzy_ = context.Operators.SingletonFrom<ServiceRequest>(ozzzzx_);

        return ozzzzy_;
    }


    [CqlExpressionDefinition("SlotResource")]
    public Slot SlotResource(CqlContext context, Slot arg)
    {
        Slot[] qzzzzh_ = [
            arg,
        ];
        Slot qzzzzi_(Slot a)
        {
            List<Identifier> qzzzzm_ = a?.Identifier;
            List<CodeableConcept> qzzzzn_ = a?.ServiceCategory;
            List<CodeableConcept> qzzzzo_ = a?.ServiceType;
            List<CodeableConcept> qzzzzp_ = a?.Specialty;
            CodeableConcept qzzzzq_ = a?.AppointmentType;
            ResourceReference qzzzzr_ = a?.Schedule;
            Code<Slot.SlotStatus> qzzzzs_ = a?.StatusElement;
            Instant qzzzzt_ = a?.StartElement;
            Instant qzzzzu_ = a?.EndElement;
            FhirBoolean qzzzzv_ = a?.OverbookedElement;
            FhirString qzzzzw_ = a?.CommentElement;
            Slot qzzzzx_ = new Slot
            {
                Identifier = new List<Identifier>((IEnumerable<Identifier>)qzzzzm_),
                ServiceCategory = new List<CodeableConcept>((IEnumerable<CodeableConcept>)qzzzzn_),
                ServiceType = new List<CodeableConcept>((IEnumerable<CodeableConcept>)qzzzzo_),
                Specialty = new List<CodeableConcept>((IEnumerable<CodeableConcept>)qzzzzp_),
                AppointmentType = qzzzzq_,
                Schedule = qzzzzr_,
                StatusElement = qzzzzs_,
                StartElement = qzzzzt_,
                EndElement = qzzzzu_,
                OverbookedElement = qzzzzv_,
                CommentElement = qzzzzw_,
            };

            return qzzzzx_;
        };
        IEnumerable<Slot> qzzzzj_ = context.Operators.Select<Slot, Slot>((IEnumerable<Slot>)qzzzzh_, qzzzzi_);
        IEnumerable<Slot> qzzzzk_ = context.Operators.Distinct<Slot>(qzzzzj_);
        Slot qzzzzl_ = context.Operators.SingletonFrom<Slot>(qzzzzk_);

        return qzzzzl_;
    }


    [CqlExpressionDefinition("SpecimenResource")]
    public Specimen SpecimenResource(CqlContext context, Specimen arg)
    {
        Specimen[] qzzzzy_ = [
            arg,
        ];
        Specimen qzzzzz_(Specimen a)
        {
            List<Identifier> rzzzzd_ = a?.Identifier;
            Identifier rzzzze_ = a?.AccessionIdentifier;
            Code<Specimen.SpecimenStatus> rzzzzf_ = a?.StatusElement;
            CodeableConcept rzzzzg_ = a?.Type;
            ResourceReference rzzzzh_ = a?.Subject;
            FhirDateTime rzzzzi_ = a?.ReceivedTimeElement;
            List<ResourceReference> rzzzzj_ = a?.Parent;
            List<ResourceReference> rzzzzk_ = a?.Request;
            Specimen.CollectionComponent rzzzzl_ = a?.Collection;
            List<Specimen.ProcessingComponent> rzzzzm_ = a?.Processing;
            List<Specimen.ContainerComponent> rzzzzn_ = a?.Container;
            List<CodeableConcept> rzzzzo_ = a?.Condition;
            List<Annotation> rzzzzp_ = a?.Note;
            Specimen rzzzzq_ = new Specimen
            {
                Identifier = new List<Identifier>((IEnumerable<Identifier>)rzzzzd_),
                AccessionIdentifier = rzzzze_,
                StatusElement = rzzzzf_,
                Type = rzzzzg_,
                Subject = rzzzzh_,
                ReceivedTimeElement = rzzzzi_,
                Parent = new List<ResourceReference>((IEnumerable<ResourceReference>)rzzzzj_),
                Request = new List<ResourceReference>((IEnumerable<ResourceReference>)rzzzzk_),
                Collection = rzzzzl_,
                Processing = new List<Specimen.ProcessingComponent>((IEnumerable<Specimen.ProcessingComponent>)rzzzzm_),
                Container = new List<Specimen.ContainerComponent>((IEnumerable<Specimen.ContainerComponent>)rzzzzn_),
                Condition = new List<CodeableConcept>((IEnumerable<CodeableConcept>)rzzzzo_),
                Note = new List<Annotation>((IEnumerable<Annotation>)rzzzzp_),
            };

            return rzzzzq_;
        };
        IEnumerable<Specimen> rzzzza_ = context.Operators.Select<Specimen, Specimen>((IEnumerable<Specimen>)qzzzzy_, qzzzzz_);
        IEnumerable<Specimen> rzzzzb_ = context.Operators.Distinct<Specimen>(rzzzza_);
        Specimen rzzzzc_ = context.Operators.SingletonFrom<Specimen>(rzzzzb_);

        return rzzzzc_;
    }


    [CqlExpressionDefinition("SpecimenDefinitionResource")]
    public SpecimenDefinition SpecimenDefinitionResource(CqlContext context, SpecimenDefinition arg)
    {
        SpecimenDefinition[] rzzzzr_ = [
            arg,
        ];
        SpecimenDefinition rzzzzs_(SpecimenDefinition a)
        {
            Identifier rzzzzw_ = a?.Identifier;
            CodeableConcept rzzzzx_ = a?.TypeCollected;
            List<CodeableConcept> rzzzzy_ = a?.PatientPreparation;
            FhirString rzzzzz_ = a?.TimeAspectElement;
            List<CodeableConcept> szzzza_ = a?.Collection;
            List<SpecimenDefinition.TypeTestedComponent> szzzzb_ = a?.TypeTested;
            SpecimenDefinition szzzzc_ = new SpecimenDefinition
            {
                Identifier = rzzzzw_,
                TypeCollected = rzzzzx_,
                PatientPreparation = new List<CodeableConcept>((IEnumerable<CodeableConcept>)rzzzzy_),
                TimeAspectElement = rzzzzz_,
                Collection = new List<CodeableConcept>((IEnumerable<CodeableConcept>)szzzza_),
                TypeTested = new List<SpecimenDefinition.TypeTestedComponent>((IEnumerable<SpecimenDefinition.TypeTestedComponent>)szzzzb_),
            };

            return szzzzc_;
        };
        IEnumerable<SpecimenDefinition> rzzzzt_ = context.Operators.Select<SpecimenDefinition, SpecimenDefinition>((IEnumerable<SpecimenDefinition>)rzzzzr_, rzzzzs_);
        IEnumerable<SpecimenDefinition> rzzzzu_ = context.Operators.Distinct<SpecimenDefinition>(rzzzzt_);
        SpecimenDefinition rzzzzv_ = context.Operators.SingletonFrom<SpecimenDefinition>(rzzzzu_);

        return rzzzzv_;
    }


    [CqlExpressionDefinition("StructureDefinitionResource")]
    public StructureDefinition StructureDefinitionResource(CqlContext context, StructureDefinition arg)
    {
        StructureDefinition[] szzzzd_ = [
            arg,
        ];
        StructureDefinition szzzze_(StructureDefinition a)
        {
            FhirUri szzzzi_ = a?.UrlElement;
            List<Identifier> szzzzj_ = a?.Identifier;
            FhirString szzzzk_ = a?.VersionElement;
            FhirString szzzzl_ = a?.NameElement;
            FhirString szzzzm_ = a?.TitleElement;
            Code<PublicationStatus> szzzzn_ = a?.StatusElement;
            FhirBoolean szzzzo_ = a?.ExperimentalElement;
            FhirDateTime szzzzp_ = a?.DateElement;
            FhirString szzzzq_ = a?.PublisherElement;
            List<ContactDetail> szzzzr_ = a?.Contact;
            Markdown szzzzs_ = a?.DescriptionElement;
            List<UsageContext> szzzzt_ = a?.UseContext;
            List<CodeableConcept> szzzzu_ = a?.Jurisdiction;
            Markdown szzzzv_ = a?.PurposeElement;
            Markdown szzzzw_ = a?.CopyrightElement;
            List<Coding> szzzzx_ = a?.Keyword;
            Code<FHIRVersion> szzzzy_ = a?.FhirVersionElement;
            List<StructureDefinition.MappingComponent> szzzzz_ = a?.Mapping;
            Code<StructureDefinition.StructureDefinitionKind> tzzzza_ = a?.KindElement;
            FhirBoolean tzzzzb_ = a?.AbstractElement;
            List<StructureDefinition.ContextComponent> tzzzzc_ = a?.Context;
            List<FhirString> tzzzzd_ = a?.ContextInvariantElement;
            FhirUri tzzzze_ = a?.TypeElement;
            Canonical tzzzzf_ = a?.BaseDefinitionElement;
            Code<StructureDefinition.TypeDerivationRule> tzzzzg_ = a?.DerivationElement;
            StructureDefinition.SnapshotComponent tzzzzh_ = a?.Snapshot;
            StructureDefinition.DifferentialComponent tzzzzi_ = a?.Differential;
            StructureDefinition tzzzzj_ = new StructureDefinition
            {
                UrlElement = szzzzi_,
                Identifier = new List<Identifier>((IEnumerable<Identifier>)szzzzj_),
                VersionElement = szzzzk_,
                NameElement = szzzzl_,
                TitleElement = szzzzm_,
                StatusElement = szzzzn_,
                ExperimentalElement = szzzzo_,
                DateElement = szzzzp_,
                PublisherElement = szzzzq_,
                Contact = new List<ContactDetail>((IEnumerable<ContactDetail>)szzzzr_),
                DescriptionElement = szzzzs_,
                UseContext = new List<UsageContext>((IEnumerable<UsageContext>)szzzzt_),
                Jurisdiction = new List<CodeableConcept>((IEnumerable<CodeableConcept>)szzzzu_),
                PurposeElement = szzzzv_,
                CopyrightElement = szzzzw_,
                Keyword = new List<Coding>((IEnumerable<Coding>)szzzzx_),
                FhirVersionElement = szzzzy_,
                Mapping = new List<StructureDefinition.MappingComponent>((IEnumerable<StructureDefinition.MappingComponent>)szzzzz_),
                KindElement = tzzzza_,
                AbstractElement = tzzzzb_,
                Context = new List<StructureDefinition.ContextComponent>((IEnumerable<StructureDefinition.ContextComponent>)tzzzzc_),
                ContextInvariantElement = new List<FhirString>((IEnumerable<FhirString>)tzzzzd_),
                TypeElement = tzzzze_,
                BaseDefinitionElement = tzzzzf_,
                DerivationElement = tzzzzg_,
                Snapshot = tzzzzh_,
                Differential = tzzzzi_,
            };

            return tzzzzj_;
        };
        IEnumerable<StructureDefinition> szzzzf_ = context.Operators.Select<StructureDefinition, StructureDefinition>((IEnumerable<StructureDefinition>)szzzzd_, szzzze_);
        IEnumerable<StructureDefinition> szzzzg_ = context.Operators.Distinct<StructureDefinition>(szzzzf_);
        StructureDefinition szzzzh_ = context.Operators.SingletonFrom<StructureDefinition>(szzzzg_);

        return szzzzh_;
    }


    [CqlExpressionDefinition("StructureMapResource")]
    public StructureMap StructureMapResource(CqlContext context, StructureMap arg)
    {
        StructureMap[] tzzzzk_ = [
            arg,
        ];
        StructureMap tzzzzl_(StructureMap a)
        {
            FhirUri tzzzzp_ = a?.UrlElement;
            List<Identifier> tzzzzq_ = a?.Identifier;
            FhirString tzzzzr_ = a?.VersionElement;
            FhirString tzzzzs_ = a?.NameElement;
            FhirString tzzzzt_ = a?.TitleElement;
            Code<PublicationStatus> tzzzzu_ = a?.StatusElement;
            FhirBoolean tzzzzv_ = a?.ExperimentalElement;
            FhirDateTime tzzzzw_ = a?.DateElement;
            FhirString tzzzzx_ = a?.PublisherElement;
            List<ContactDetail> tzzzzy_ = a?.Contact;
            Markdown tzzzzz_ = a?.DescriptionElement;
            List<UsageContext> uzzzza_ = a?.UseContext;
            List<CodeableConcept> uzzzzb_ = a?.Jurisdiction;
            Markdown uzzzzc_ = a?.PurposeElement;
            Markdown uzzzzd_ = a?.CopyrightElement;
            List<StructureMap.StructureComponent> uzzzze_ = a?.Structure;
            List<Canonical> uzzzzf_ = a?.ImportElement;
            List<StructureMap.GroupComponent> uzzzzg_ = a?.Group;
            StructureMap uzzzzh_ = new StructureMap
            {
                UrlElement = tzzzzp_,
                Identifier = new List<Identifier>((IEnumerable<Identifier>)tzzzzq_),
                VersionElement = tzzzzr_,
                NameElement = tzzzzs_,
                TitleElement = tzzzzt_,
                StatusElement = tzzzzu_,
                ExperimentalElement = tzzzzv_,
                DateElement = tzzzzw_,
                PublisherElement = tzzzzx_,
                Contact = new List<ContactDetail>((IEnumerable<ContactDetail>)tzzzzy_),
                DescriptionElement = tzzzzz_,
                UseContext = new List<UsageContext>((IEnumerable<UsageContext>)uzzzza_),
                Jurisdiction = new List<CodeableConcept>((IEnumerable<CodeableConcept>)uzzzzb_),
                PurposeElement = uzzzzc_,
                CopyrightElement = uzzzzd_,
                Structure = new List<StructureMap.StructureComponent>((IEnumerable<StructureMap.StructureComponent>)uzzzze_),
                ImportElement = new List<Canonical>((IEnumerable<Canonical>)uzzzzf_),
                Group = new List<StructureMap.GroupComponent>((IEnumerable<StructureMap.GroupComponent>)uzzzzg_),
            };

            return uzzzzh_;
        };
        IEnumerable<StructureMap> tzzzzm_ = context.Operators.Select<StructureMap, StructureMap>((IEnumerable<StructureMap>)tzzzzk_, tzzzzl_);
        IEnumerable<StructureMap> tzzzzn_ = context.Operators.Distinct<StructureMap>(tzzzzm_);
        StructureMap tzzzzo_ = context.Operators.SingletonFrom<StructureMap>(tzzzzn_);

        return tzzzzo_;
    }


    [CqlExpressionDefinition("SubscriptionResource")]
    public Subscription SubscriptionResource(CqlContext context, Subscription arg)
    {
        Subscription[] uzzzzi_ = [
            arg,
        ];
        Subscription uzzzzj_(Subscription a)
        {
            Code<Subscription.SubscriptionStatus> uzzzzn_ = a?.StatusElement;
            List<ContactPoint> uzzzzo_ = a?.Contact;
            Instant uzzzzp_ = a?.EndElement;
            FhirString uzzzzq_ = a?.ReasonElement;
            FhirString uzzzzr_ = a?.CriteriaElement;
            FhirString uzzzzs_ = a?.ErrorElement;
            Subscription.ChannelComponent uzzzzt_ = a?.Channel;
            Subscription uzzzzu_ = new Subscription
            {
                StatusElement = uzzzzn_,
                Contact = new List<ContactPoint>((IEnumerable<ContactPoint>)uzzzzo_),
                EndElement = uzzzzp_,
                ReasonElement = uzzzzq_,
                CriteriaElement = uzzzzr_,
                ErrorElement = uzzzzs_,
                Channel = uzzzzt_,
            };

            return uzzzzu_;
        };
        IEnumerable<Subscription> uzzzzk_ = context.Operators.Select<Subscription, Subscription>((IEnumerable<Subscription>)uzzzzi_, uzzzzj_);
        IEnumerable<Subscription> uzzzzl_ = context.Operators.Distinct<Subscription>(uzzzzk_);
        Subscription uzzzzm_ = context.Operators.SingletonFrom<Subscription>(uzzzzl_);

        return uzzzzm_;
    }


    [CqlExpressionDefinition("SubstanceResource")]
    public Substance SubstanceResource(CqlContext context, Substance arg)
    {
        Substance[] uzzzzv_ = [
            arg,
        ];
        Substance uzzzzw_(Substance a)
        {
            List<Identifier> vzzzza_ = a?.Identifier;
            Code<Substance.FHIRSubstanceStatus> vzzzzb_ = a?.StatusElement;
            List<CodeableConcept> vzzzzc_ = a?.Category;
            CodeableConcept vzzzzd_ = a?.Code;
            FhirString vzzzze_ = a?.DescriptionElement;
            List<Substance.InstanceComponent> vzzzzf_ = a?.Instance;
            List<Substance.IngredientComponent> vzzzzg_ = a?.Ingredient;
            Substance vzzzzh_ = new Substance
            {
                Identifier = new List<Identifier>((IEnumerable<Identifier>)vzzzza_),
                StatusElement = vzzzzb_,
                Category = new List<CodeableConcept>((IEnumerable<CodeableConcept>)vzzzzc_),
                Code = vzzzzd_,
                DescriptionElement = vzzzze_,
                Instance = new List<Substance.InstanceComponent>((IEnumerable<Substance.InstanceComponent>)vzzzzf_),
                Ingredient = new List<Substance.IngredientComponent>((IEnumerable<Substance.IngredientComponent>)vzzzzg_),
            };

            return vzzzzh_;
        };
        IEnumerable<Substance> uzzzzx_ = context.Operators.Select<Substance, Substance>((IEnumerable<Substance>)uzzzzv_, uzzzzw_);
        IEnumerable<Substance> uzzzzy_ = context.Operators.Distinct<Substance>(uzzzzx_);
        Substance uzzzzz_ = context.Operators.SingletonFrom<Substance>(uzzzzy_);

        return uzzzzz_;
    }


    [CqlExpressionDefinition("SubstanceNucleicAcidResource")]
    public SubstanceNucleicAcid SubstanceNucleicAcidResource(CqlContext context, SubstanceNucleicAcid arg)
    {
        SubstanceNucleicAcid[] vzzzzi_ = [
            arg,
        ];
        SubstanceNucleicAcid vzzzzj_(SubstanceNucleicAcid a)
        {
            CodeableConcept vzzzzn_ = a?.SequenceType;
            Integer vzzzzo_ = a?.NumberOfSubunitsElement;
            FhirString vzzzzp_ = a?.AreaOfHybridisationElement;
            CodeableConcept vzzzzq_ = a?.OligoNucleotideType;
            List<SubstanceNucleicAcid.SubunitComponent> vzzzzr_ = a?.Subunit;
            SubstanceNucleicAcid vzzzzs_ = new SubstanceNucleicAcid
            {
                SequenceType = vzzzzn_,
                NumberOfSubunitsElement = vzzzzo_,
                AreaOfHybridisationElement = vzzzzp_,
                OligoNucleotideType = vzzzzq_,
                Subunit = new List<SubstanceNucleicAcid.SubunitComponent>((IEnumerable<SubstanceNucleicAcid.SubunitComponent>)vzzzzr_),
            };

            return vzzzzs_;
        };
        IEnumerable<SubstanceNucleicAcid> vzzzzk_ = context.Operators.Select<SubstanceNucleicAcid, SubstanceNucleicAcid>((IEnumerable<SubstanceNucleicAcid>)vzzzzi_, vzzzzj_);
        IEnumerable<SubstanceNucleicAcid> vzzzzl_ = context.Operators.Distinct<SubstanceNucleicAcid>(vzzzzk_);
        SubstanceNucleicAcid vzzzzm_ = context.Operators.SingletonFrom<SubstanceNucleicAcid>(vzzzzl_);

        return vzzzzm_;
    }


    [CqlExpressionDefinition("SubstancePolymerResource")]
    public SubstancePolymer SubstancePolymerResource(CqlContext context, SubstancePolymer arg)
    {
        SubstancePolymer[] vzzzzt_ = [
            arg,
        ];
        SubstancePolymer vzzzzu_(SubstancePolymer a)
        {
            CodeableConcept vzzzzy_ = a?.Class;
            CodeableConcept vzzzzz_ = a?.Geometry;
            List<CodeableConcept> wzzzza_ = a?.CopolymerConnectivity;
            List<FhirString> wzzzzb_ = a?.ModificationElement;
            List<SubstancePolymer.MonomerSetComponent> wzzzzc_ = a?.MonomerSet;
            List<SubstancePolymer.RepeatComponent> wzzzzd_ = a?.Repeat;
            SubstancePolymer wzzzze_ = new SubstancePolymer
            {
                Class = vzzzzy_,
                Geometry = vzzzzz_,
                CopolymerConnectivity = new List<CodeableConcept>((IEnumerable<CodeableConcept>)wzzzza_),
                ModificationElement = new List<FhirString>((IEnumerable<FhirString>)wzzzzb_),
                MonomerSet = new List<SubstancePolymer.MonomerSetComponent>((IEnumerable<SubstancePolymer.MonomerSetComponent>)wzzzzc_),
                Repeat = new List<SubstancePolymer.RepeatComponent>((IEnumerable<SubstancePolymer.RepeatComponent>)wzzzzd_),
            };

            return wzzzze_;
        };
        IEnumerable<SubstancePolymer> vzzzzv_ = context.Operators.Select<SubstancePolymer, SubstancePolymer>((IEnumerable<SubstancePolymer>)vzzzzt_, vzzzzu_);
        IEnumerable<SubstancePolymer> vzzzzw_ = context.Operators.Distinct<SubstancePolymer>(vzzzzv_);
        SubstancePolymer vzzzzx_ = context.Operators.SingletonFrom<SubstancePolymer>(vzzzzw_);

        return vzzzzx_;
    }


    [CqlExpressionDefinition("SubstanceProteinResource")]
    public SubstanceProtein SubstanceProteinResource(CqlContext context, SubstanceProtein arg)
    {
        SubstanceProtein[] wzzzzf_ = [
            arg,
        ];
        SubstanceProtein wzzzzg_(SubstanceProtein a)
        {
            CodeableConcept wzzzzk_ = a?.SequenceType;
            Integer wzzzzl_ = a?.NumberOfSubunitsElement;
            List<FhirString> wzzzzm_ = a?.DisulfideLinkageElement;
            List<SubstanceProtein.SubunitComponent> wzzzzn_ = a?.Subunit;
            SubstanceProtein wzzzzo_ = new SubstanceProtein
            {
                SequenceType = wzzzzk_,
                NumberOfSubunitsElement = wzzzzl_,
                DisulfideLinkageElement = new List<FhirString>((IEnumerable<FhirString>)wzzzzm_),
                Subunit = new List<SubstanceProtein.SubunitComponent>((IEnumerable<SubstanceProtein.SubunitComponent>)wzzzzn_),
            };

            return wzzzzo_;
        };
        IEnumerable<SubstanceProtein> wzzzzh_ = context.Operators.Select<SubstanceProtein, SubstanceProtein>((IEnumerable<SubstanceProtein>)wzzzzf_, wzzzzg_);
        IEnumerable<SubstanceProtein> wzzzzi_ = context.Operators.Distinct<SubstanceProtein>(wzzzzh_);
        SubstanceProtein wzzzzj_ = context.Operators.SingletonFrom<SubstanceProtein>(wzzzzi_);

        return wzzzzj_;
    }


    [CqlExpressionDefinition("SubstanceReferenceInformationResource")]
    public SubstanceReferenceInformation SubstanceReferenceInformationResource(CqlContext context, SubstanceReferenceInformation arg)
    {
        SubstanceReferenceInformation[] wzzzzp_ = [
            arg,
        ];
        SubstanceReferenceInformation wzzzzq_(SubstanceReferenceInformation a)
        {
            FhirString wzzzzu_ = a?.CommentElement;
            List<SubstanceReferenceInformation.GeneComponent> wzzzzv_ = a?.Gene;
            List<SubstanceReferenceInformation.GeneElementComponent> wzzzzw_ = a?.GeneElement;
            List<SubstanceReferenceInformation.ClassificationComponent> wzzzzx_ = a?.Classification;
            List<SubstanceReferenceInformation.TargetComponent> wzzzzy_ = a?.Target;
            SubstanceReferenceInformation wzzzzz_ = new SubstanceReferenceInformation
            {
                CommentElement = wzzzzu_,
                Gene = new List<SubstanceReferenceInformation.GeneComponent>((IEnumerable<SubstanceReferenceInformation.GeneComponent>)wzzzzv_),
                GeneElement = new List<SubstanceReferenceInformation.GeneElementComponent>((IEnumerable<SubstanceReferenceInformation.GeneElementComponent>)wzzzzw_),
                Classification = new List<SubstanceReferenceInformation.ClassificationComponent>((IEnumerable<SubstanceReferenceInformation.ClassificationComponent>)wzzzzx_),
                Target = new List<SubstanceReferenceInformation.TargetComponent>((IEnumerable<SubstanceReferenceInformation.TargetComponent>)wzzzzy_),
            };

            return wzzzzz_;
        };
        IEnumerable<SubstanceReferenceInformation> wzzzzr_ = context.Operators.Select<SubstanceReferenceInformation, SubstanceReferenceInformation>((IEnumerable<SubstanceReferenceInformation>)wzzzzp_, wzzzzq_);
        IEnumerable<SubstanceReferenceInformation> wzzzzs_ = context.Operators.Distinct<SubstanceReferenceInformation>(wzzzzr_);
        SubstanceReferenceInformation wzzzzt_ = context.Operators.SingletonFrom<SubstanceReferenceInformation>(wzzzzs_);

        return wzzzzt_;
    }


    [CqlExpressionDefinition("SubstanceSourceMaterialResource")]
    public SubstanceSourceMaterial SubstanceSourceMaterialResource(CqlContext context, SubstanceSourceMaterial arg)
    {
        SubstanceSourceMaterial[] xzzzza_ = [
            arg,
        ];
        SubstanceSourceMaterial xzzzzb_(SubstanceSourceMaterial a)
        {
            CodeableConcept xzzzzf_ = a?.SourceMaterialClass;
            CodeableConcept xzzzzg_ = a?.SourceMaterialType;
            CodeableConcept xzzzzh_ = a?.SourceMaterialState;
            Identifier xzzzzi_ = a?.OrganismId;
            FhirString xzzzzj_ = a?.OrganismNameElement;
            List<Identifier> xzzzzk_ = a?.ParentSubstanceId;
            List<FhirString> xzzzzl_ = a?.ParentSubstanceNameElement;
            List<CodeableConcept> xzzzzm_ = a?.CountryOfOrigin;
            List<FhirString> xzzzzn_ = a?.GeographicalLocationElement;
            CodeableConcept xzzzzo_ = a?.DevelopmentStage;
            List<SubstanceSourceMaterial.FractionDescriptionComponent> xzzzzp_ = a?.FractionDescription;
            SubstanceSourceMaterial.OrganismComponent xzzzzq_ = a?.Organism;
            List<SubstanceSourceMaterial.PartDescriptionComponent> xzzzzr_ = a?.PartDescription;
            SubstanceSourceMaterial xzzzzs_ = new SubstanceSourceMaterial
            {
                SourceMaterialClass = xzzzzf_,
                SourceMaterialType = xzzzzg_,
                SourceMaterialState = xzzzzh_,
                OrganismId = xzzzzi_,
                OrganismNameElement = xzzzzj_,
                ParentSubstanceId = new List<Identifier>((IEnumerable<Identifier>)xzzzzk_),
                ParentSubstanceNameElement = new List<FhirString>((IEnumerable<FhirString>)xzzzzl_),
                CountryOfOrigin = new List<CodeableConcept>((IEnumerable<CodeableConcept>)xzzzzm_),
                GeographicalLocationElement = new List<FhirString>((IEnumerable<FhirString>)xzzzzn_),
                DevelopmentStage = xzzzzo_,
                FractionDescription = new List<SubstanceSourceMaterial.FractionDescriptionComponent>((IEnumerable<SubstanceSourceMaterial.FractionDescriptionComponent>)xzzzzp_),
                Organism = xzzzzq_,
                PartDescription = new List<SubstanceSourceMaterial.PartDescriptionComponent>((IEnumerable<SubstanceSourceMaterial.PartDescriptionComponent>)xzzzzr_),
            };

            return xzzzzs_;
        };
        IEnumerable<SubstanceSourceMaterial> xzzzzc_ = context.Operators.Select<SubstanceSourceMaterial, SubstanceSourceMaterial>((IEnumerable<SubstanceSourceMaterial>)xzzzza_, xzzzzb_);
        IEnumerable<SubstanceSourceMaterial> xzzzzd_ = context.Operators.Distinct<SubstanceSourceMaterial>(xzzzzc_);
        SubstanceSourceMaterial xzzzze_ = context.Operators.SingletonFrom<SubstanceSourceMaterial>(xzzzzd_);

        return xzzzze_;
    }


    [CqlExpressionDefinition("SubstanceSpecificationResource")]
    public SubstanceSpecification SubstanceSpecificationResource(CqlContext context, SubstanceSpecification arg)
    {
        SubstanceSpecification[] xzzzzt_ = [
            arg,
        ];
        SubstanceSpecification xzzzzu_(SubstanceSpecification a)
        {
            Identifier xzzzzy_ = a?.Identifier;
            CodeableConcept xzzzzz_ = a?.Type;
            CodeableConcept yzzzza_ = a?.Status;
            CodeableConcept yzzzzb_ = a?.Domain;
            FhirString yzzzzc_ = a?.DescriptionElement;
            List<ResourceReference> yzzzzd_ = a?.Source;
            FhirString yzzzze_ = a?.CommentElement;
            List<SubstanceSpecification.MoietyComponent> yzzzzf_ = a?.Moiety;
            List<SubstanceSpecification.PropertyComponent> yzzzzg_ = a?.Property;
            ResourceReference yzzzzh_ = a?.ReferenceInformation;
            SubstanceSpecification.StructureComponent yzzzzi_ = a?.Structure;
            List<SubstanceSpecification.CodeComponent> yzzzzj_ = a?.Code;
            List<SubstanceSpecification.NameComponent> yzzzzk_ = a?.Name;
            List<SubstanceSpecification.MolecularWeightComponent> yzzzzl_ = a?.MolecularWeight;
            List<SubstanceSpecification.RelationshipComponent> yzzzzm_ = a?.Relationship;
            ResourceReference yzzzzn_ = a?.NucleicAcid;
            ResourceReference yzzzzo_ = a?.Polymer;
            ResourceReference yzzzzp_ = a?.Protein;
            ResourceReference yzzzzq_ = a?.SourceMaterial;
            SubstanceSpecification yzzzzr_ = new SubstanceSpecification
            {
                Identifier = xzzzzy_,
                Type = xzzzzz_,
                Status = yzzzza_,
                Domain = yzzzzb_,
                DescriptionElement = yzzzzc_,
                Source = new List<ResourceReference>((IEnumerable<ResourceReference>)yzzzzd_),
                CommentElement = yzzzze_,
                Moiety = new List<SubstanceSpecification.MoietyComponent>((IEnumerable<SubstanceSpecification.MoietyComponent>)yzzzzf_),
                Property = new List<SubstanceSpecification.PropertyComponent>((IEnumerable<SubstanceSpecification.PropertyComponent>)yzzzzg_),
                ReferenceInformation = yzzzzh_,
                Structure = yzzzzi_,
                Code = new List<SubstanceSpecification.CodeComponent>((IEnumerable<SubstanceSpecification.CodeComponent>)yzzzzj_),
                Name = new List<SubstanceSpecification.NameComponent>((IEnumerable<SubstanceSpecification.NameComponent>)yzzzzk_),
                MolecularWeight = new List<SubstanceSpecification.MolecularWeightComponent>((IEnumerable<SubstanceSpecification.MolecularWeightComponent>)yzzzzl_),
                Relationship = new List<SubstanceSpecification.RelationshipComponent>((IEnumerable<SubstanceSpecification.RelationshipComponent>)yzzzzm_),
                NucleicAcid = yzzzzn_,
                Polymer = yzzzzo_,
                Protein = yzzzzp_,
                SourceMaterial = yzzzzq_,
            };

            return yzzzzr_;
        };
        IEnumerable<SubstanceSpecification> xzzzzv_ = context.Operators.Select<SubstanceSpecification, SubstanceSpecification>((IEnumerable<SubstanceSpecification>)xzzzzt_, xzzzzu_);
        IEnumerable<SubstanceSpecification> xzzzzw_ = context.Operators.Distinct<SubstanceSpecification>(xzzzzv_);
        SubstanceSpecification xzzzzx_ = context.Operators.SingletonFrom<SubstanceSpecification>(xzzzzw_);

        return xzzzzx_;
    }


    [CqlExpressionDefinition("SupplyDeliveryResource")]
    public SupplyDelivery SupplyDeliveryResource(CqlContext context, SupplyDelivery arg)
    {
        SupplyDelivery[] yzzzzs_ = [
            arg,
        ];
        SupplyDelivery yzzzzt_(SupplyDelivery a)
        {
            List<Identifier> yzzzzx_ = a?.Identifier;
            List<ResourceReference> yzzzzy_ = a?.BasedOn;
            List<ResourceReference> yzzzzz_ = a?.PartOf;
            Code<SupplyDelivery.SupplyDeliveryStatus> zzzzza_ = a?.StatusElement;
            ResourceReference zzzzzb_ = a?.Patient;
            CodeableConcept zzzzzc_ = a?.Type;
            SupplyDelivery.SuppliedItemComponent zzzzzd_ = a?.SuppliedItem;
            DataType zzzzze_ = a?.Occurrence;
            ResourceReference zzzzzf_ = a?.Supplier;
            ResourceReference zzzzzg_ = a?.Destination;
            List<ResourceReference> zzzzzh_ = a?.Receiver;
            SupplyDelivery zzzzzi_ = new SupplyDelivery
            {
                Identifier = new List<Identifier>((IEnumerable<Identifier>)yzzzzx_),
                BasedOn = new List<ResourceReference>((IEnumerable<ResourceReference>)yzzzzy_),
                PartOf = new List<ResourceReference>((IEnumerable<ResourceReference>)yzzzzz_),
                StatusElement = zzzzza_,
                Patient = zzzzzb_,
                Type = zzzzzc_,
                SuppliedItem = zzzzzd_,
                Occurrence = (DataType)zzzzze_,
                Supplier = zzzzzf_,
                Destination = zzzzzg_,
                Receiver = new List<ResourceReference>((IEnumerable<ResourceReference>)zzzzzh_),
            };

            return zzzzzi_;
        };
        IEnumerable<SupplyDelivery> yzzzzu_ = context.Operators.Select<SupplyDelivery, SupplyDelivery>((IEnumerable<SupplyDelivery>)yzzzzs_, yzzzzt_);
        IEnumerable<SupplyDelivery> yzzzzv_ = context.Operators.Distinct<SupplyDelivery>(yzzzzu_);
        SupplyDelivery yzzzzw_ = context.Operators.SingletonFrom<SupplyDelivery>(yzzzzv_);

        return yzzzzw_;
    }


    [CqlExpressionDefinition("SupplyRequestResource")]
    public SupplyRequest SupplyRequestResource(CqlContext context, SupplyRequest arg)
    {
        SupplyRequest[] zzzzzj_ = [
            arg,
        ];
        SupplyRequest zzzzzk_(SupplyRequest a)
        {
            List<Identifier> zzzzzo_ = a?.Identifier;
            Code<SupplyRequest.SupplyRequestStatus> zzzzzp_ = a?.StatusElement;
            CodeableConcept zzzzzq_ = a?.Category;
            Code<RequestPriority> zzzzzr_ = a?.PriorityElement;
            DataType zzzzzs_ = a?.Item;
            Quantity zzzzzt_ = a?.Quantity;
            List<SupplyRequest.ParameterComponent> zzzzzu_ = a?.Parameter;
            DataType zzzzzv_ = a?.Occurrence;
            FhirDateTime zzzzzw_ = a?.AuthoredOnElement;
            ResourceReference zzzzzx_ = a?.Requester;
            List<ResourceReference> zzzzzy_ = a?.Supplier;
            List<CodeableConcept> zzzzzz_ = a?.ReasonCode;
            List<ResourceReference> azzzzza_ = a?.ReasonReference;
            ResourceReference azzzzzb_ = a?.DeliverFrom;
            ResourceReference azzzzzc_ = a?.DeliverTo;
            SupplyRequest azzzzzd_ = new SupplyRequest
            {
                Identifier = new List<Identifier>((IEnumerable<Identifier>)zzzzzo_),
                StatusElement = zzzzzp_,
                Category = zzzzzq_,
                PriorityElement = zzzzzr_,
                Item = (DataType)zzzzzs_,
                Quantity = zzzzzt_,
                Parameter = new List<SupplyRequest.ParameterComponent>((IEnumerable<SupplyRequest.ParameterComponent>)zzzzzu_),
                Occurrence = (DataType)zzzzzv_,
                AuthoredOnElement = zzzzzw_,
                Requester = zzzzzx_,
                Supplier = new List<ResourceReference>((IEnumerable<ResourceReference>)zzzzzy_),
                ReasonCode = new List<CodeableConcept>((IEnumerable<CodeableConcept>)zzzzzz_),
                ReasonReference = new List<ResourceReference>((IEnumerable<ResourceReference>)azzzzza_),
                DeliverFrom = azzzzzb_,
                DeliverTo = azzzzzc_,
            };

            return azzzzzd_;
        };
        IEnumerable<SupplyRequest> zzzzzl_ = context.Operators.Select<SupplyRequest, SupplyRequest>((IEnumerable<SupplyRequest>)zzzzzj_, zzzzzk_);
        IEnumerable<SupplyRequest> zzzzzm_ = context.Operators.Distinct<SupplyRequest>(zzzzzl_);
        SupplyRequest zzzzzn_ = context.Operators.SingletonFrom<SupplyRequest>(zzzzzm_);

        return zzzzzn_;
    }


    [CqlExpressionDefinition("TaskResource")]
    public Task TaskResource(CqlContext context, Task arg)
    {
        Task[] azzzzze_ = [
            arg,
        ];
        Task azzzzzf_(Task a)
        {
            List<Identifier> azzzzzj_ = a?.Identifier;
            Canonical azzzzzk_ = a?.InstantiatesCanonicalElement;
            FhirUri azzzzzl_ = a?.InstantiatesUriElement;
            List<ResourceReference> azzzzzm_ = a?.BasedOn;
            Identifier azzzzzn_ = a?.GroupIdentifier;
            List<ResourceReference> azzzzzo_ = a?.PartOf;
            Code<Task.TaskStatus> azzzzzp_ = a?.StatusElement;
            CodeableConcept azzzzzq_ = a?.StatusReason;
            CodeableConcept azzzzzr_ = a?.BusinessStatus;
            Code<Task.TaskIntent> azzzzzs_ = a?.IntentElement;
            Code<RequestPriority> azzzzzt_ = a?.PriorityElement;
            CodeableConcept azzzzzu_ = a?.Code;
            FhirString azzzzzv_ = a?.DescriptionElement;
            ResourceReference azzzzzw_ = a?.Focus;
            ResourceReference azzzzzx_ = a?.For;
            ResourceReference azzzzzy_ = a?.Encounter;
            Period azzzzzz_ = a?.ExecutionPeriod;
            FhirDateTime bzzzzza_ = a?.AuthoredOnElement;
            FhirDateTime bzzzzzb_ = a?.LastModifiedElement;
            ResourceReference bzzzzzc_ = a?.Requester;
            List<CodeableConcept> bzzzzzd_ = a?.PerformerType;
            ResourceReference bzzzzze_ = a?.Owner;
            ResourceReference bzzzzzf_ = a?.Location;
            CodeableConcept bzzzzzg_ = a?.ReasonCode;
            ResourceReference bzzzzzh_ = a?.ReasonReference;
            List<ResourceReference> bzzzzzi_ = a?.Insurance;
            List<Annotation> bzzzzzj_ = a?.Note;
            List<ResourceReference> bzzzzzk_ = a?.RelevantHistory;
            Task.RestrictionComponent bzzzzzl_ = a?.Restriction;
            List<Task.ParameterComponent> bzzzzzm_ = a?.Input;
            List<Task.OutputComponent> bzzzzzn_ = a?.Output;
            Task bzzzzzo_ = new Task
            {
                Identifier = new List<Identifier>((IEnumerable<Identifier>)azzzzzj_),
                InstantiatesCanonicalElement = azzzzzk_,
                InstantiatesUriElement = azzzzzl_,
                BasedOn = new List<ResourceReference>((IEnumerable<ResourceReference>)azzzzzm_),
                GroupIdentifier = azzzzzn_,
                PartOf = new List<ResourceReference>((IEnumerable<ResourceReference>)azzzzzo_),
                StatusElement = azzzzzp_,
                StatusReason = azzzzzq_,
                BusinessStatus = azzzzzr_,
                IntentElement = azzzzzs_,
                PriorityElement = azzzzzt_,
                Code = azzzzzu_,
                DescriptionElement = azzzzzv_,
                Focus = azzzzzw_,
                For = azzzzzx_,
                Encounter = azzzzzy_,
                ExecutionPeriod = azzzzzz_,
                AuthoredOnElement = bzzzzza_,
                LastModifiedElement = bzzzzzb_,
                Requester = bzzzzzc_,
                PerformerType = new List<CodeableConcept>((IEnumerable<CodeableConcept>)bzzzzzd_),
                Owner = bzzzzze_,
                Location = bzzzzzf_,
                ReasonCode = bzzzzzg_,
                ReasonReference = bzzzzzh_,
                Insurance = new List<ResourceReference>((IEnumerable<ResourceReference>)bzzzzzi_),
                Note = new List<Annotation>((IEnumerable<Annotation>)bzzzzzj_),
                RelevantHistory = new List<ResourceReference>((IEnumerable<ResourceReference>)bzzzzzk_),
                Restriction = bzzzzzl_,
                Input = new List<Task.ParameterComponent>((IEnumerable<Task.ParameterComponent>)bzzzzzm_),
                Output = new List<Task.OutputComponent>((IEnumerable<Task.OutputComponent>)bzzzzzn_),
            };

            return bzzzzzo_;
        };
        IEnumerable<Task> azzzzzg_ = context.Operators.Select<Task, Task>((IEnumerable<Task>)azzzzze_, azzzzzf_);
        IEnumerable<Task> azzzzzh_ = context.Operators.Distinct<Task>(azzzzzg_);
        Task azzzzzi_ = context.Operators.SingletonFrom<Task>(azzzzzh_);

        return azzzzzi_;
    }


    [CqlExpressionDefinition("TerminologyCapabilitiesResource")]
    public TerminologyCapabilities TerminologyCapabilitiesResource(CqlContext context, TerminologyCapabilities arg)
    {
        TerminologyCapabilities[] bzzzzzp_ = [
            arg,
        ];
        TerminologyCapabilities bzzzzzq_(TerminologyCapabilities a)
        {
            FhirUri bzzzzzu_ = a?.UrlElement;
            FhirString bzzzzzv_ = a?.VersionElement;
            FhirString bzzzzzw_ = a?.NameElement;
            FhirString bzzzzzx_ = a?.TitleElement;
            Code<PublicationStatus> bzzzzzy_ = a?.StatusElement;
            FhirBoolean bzzzzzz_ = a?.ExperimentalElement;
            FhirDateTime czzzzza_ = a?.DateElement;
            FhirString czzzzzb_ = a?.PublisherElement;
            List<ContactDetail> czzzzzc_ = a?.Contact;
            Markdown czzzzzd_ = a?.DescriptionElement;
            List<UsageContext> czzzzze_ = a?.UseContext;
            List<CodeableConcept> czzzzzf_ = a?.Jurisdiction;
            Markdown czzzzzg_ = a?.PurposeElement;
            Markdown czzzzzh_ = a?.CopyrightElement;
            Code<CapabilityStatementKind> czzzzzi_ = a?.KindElement;
            TerminologyCapabilities.SoftwareComponent czzzzzj_ = a?.Software;
            TerminologyCapabilities.ImplementationComponent czzzzzk_ = a?.Implementation;
            FhirBoolean czzzzzl_ = a?.LockedDateElement;
            List<TerminologyCapabilities.CodeSystemComponent> czzzzzm_ = a?.CodeSystem;
            TerminologyCapabilities.ExpansionComponent czzzzzn_ = a?.Expansion;
            Code<TerminologyCapabilities.CodeSearchSupport> czzzzzo_ = a?.CodeSearchElement;
            TerminologyCapabilities.ValidateCodeComponent czzzzzp_ = a?.ValidateCode;
            TerminologyCapabilities.TranslationComponent czzzzzq_ = a?.Translation;
            TerminologyCapabilities.ClosureComponent czzzzzr_ = a?.Closure;
            TerminologyCapabilities czzzzzs_ = new TerminologyCapabilities
            {
                UrlElement = bzzzzzu_,
                VersionElement = bzzzzzv_,
                NameElement = bzzzzzw_,
                TitleElement = bzzzzzx_,
                StatusElement = bzzzzzy_,
                ExperimentalElement = bzzzzzz_,
                DateElement = czzzzza_,
                PublisherElement = czzzzzb_,
                Contact = new List<ContactDetail>((IEnumerable<ContactDetail>)czzzzzc_),
                DescriptionElement = czzzzzd_,
                UseContext = new List<UsageContext>((IEnumerable<UsageContext>)czzzzze_),
                Jurisdiction = new List<CodeableConcept>((IEnumerable<CodeableConcept>)czzzzzf_),
                PurposeElement = czzzzzg_,
                CopyrightElement = czzzzzh_,
                KindElement = czzzzzi_,
                Software = czzzzzj_,
                Implementation = czzzzzk_,
                LockedDateElement = czzzzzl_,
                CodeSystem = new List<TerminologyCapabilities.CodeSystemComponent>((IEnumerable<TerminologyCapabilities.CodeSystemComponent>)czzzzzm_),
                Expansion = czzzzzn_,
                CodeSearchElement = czzzzzo_,
                ValidateCode = czzzzzp_,
                Translation = czzzzzq_,
                Closure = czzzzzr_,
            };

            return czzzzzs_;
        };
        IEnumerable<TerminologyCapabilities> bzzzzzr_ = context.Operators.Select<TerminologyCapabilities, TerminologyCapabilities>((IEnumerable<TerminologyCapabilities>)bzzzzzp_, bzzzzzq_);
        IEnumerable<TerminologyCapabilities> bzzzzzs_ = context.Operators.Distinct<TerminologyCapabilities>(bzzzzzr_);
        TerminologyCapabilities bzzzzzt_ = context.Operators.SingletonFrom<TerminologyCapabilities>(bzzzzzs_);

        return bzzzzzt_;
    }


    [CqlExpressionDefinition("TestReportResource")]
    public TestReport TestReportResource(CqlContext context, TestReport arg)
    {
        TestReport[] czzzzzt_ = [
            arg,
        ];
        TestReport czzzzzu_(TestReport a)
        {
            Identifier czzzzzy_ = a?.Identifier;
            FhirString czzzzzz_ = a?.NameElement;
            Code<TestReport.TestReportStatus> dzzzzza_ = a?.StatusElement;
            ResourceReference dzzzzzb_ = a?.TestScript;
            Code<TestReport.TestReportResult> dzzzzzc_ = a?.ResultElement;
            FhirDecimal dzzzzzd_ = a?.ScoreElement;
            FhirString dzzzzze_ = a?.TesterElement;
            FhirDateTime dzzzzzf_ = a?.IssuedElement;
            List<TestReport.ParticipantComponent> dzzzzzg_ = a?.Participant;
            TestReport.SetupComponent dzzzzzh_ = a?.Setup;
            List<TestReport.TestComponent> dzzzzzi_ = a?.Test;
            TestReport.TeardownComponent dzzzzzj_ = a?.Teardown;
            TestReport dzzzzzk_ = new TestReport
            {
                Identifier = czzzzzy_,
                NameElement = czzzzzz_,
                StatusElement = dzzzzza_,
                TestScript = dzzzzzb_,
                ResultElement = dzzzzzc_,
                ScoreElement = dzzzzzd_,
                TesterElement = dzzzzze_,
                IssuedElement = dzzzzzf_,
                Participant = new List<TestReport.ParticipantComponent>((IEnumerable<TestReport.ParticipantComponent>)dzzzzzg_),
                Setup = dzzzzzh_,
                Test = new List<TestReport.TestComponent>((IEnumerable<TestReport.TestComponent>)dzzzzzi_),
                Teardown = dzzzzzj_,
            };

            return dzzzzzk_;
        };
        IEnumerable<TestReport> czzzzzv_ = context.Operators.Select<TestReport, TestReport>((IEnumerable<TestReport>)czzzzzt_, czzzzzu_);
        IEnumerable<TestReport> czzzzzw_ = context.Operators.Distinct<TestReport>(czzzzzv_);
        TestReport czzzzzx_ = context.Operators.SingletonFrom<TestReport>(czzzzzw_);

        return czzzzzx_;
    }


    [CqlExpressionDefinition("TestScriptResource")]
    public TestScript TestScriptResource(CqlContext context, TestScript arg)
    {
        TestScript[] dzzzzzl_ = [
            arg,
        ];
        TestScript dzzzzzm_(TestScript a)
        {
            FhirUri dzzzzzq_ = a?.UrlElement;
            Identifier dzzzzzr_ = a?.Identifier;
            FhirString dzzzzzs_ = a?.VersionElement;
            FhirString dzzzzzt_ = a?.NameElement;
            FhirString dzzzzzu_ = a?.TitleElement;
            Code<PublicationStatus> dzzzzzv_ = a?.StatusElement;
            FhirBoolean dzzzzzw_ = a?.ExperimentalElement;
            FhirDateTime dzzzzzx_ = a?.DateElement;
            FhirString dzzzzzy_ = a?.PublisherElement;
            List<ContactDetail> dzzzzzz_ = a?.Contact;
            Markdown ezzzzza_ = a?.DescriptionElement;
            List<UsageContext> ezzzzzb_ = a?.UseContext;
            List<CodeableConcept> ezzzzzc_ = a?.Jurisdiction;
            Markdown ezzzzzd_ = a?.PurposeElement;
            Markdown ezzzzze_ = a?.CopyrightElement;
            List<TestScript.OriginComponent> ezzzzzf_ = a?.Origin;
            List<TestScript.DestinationComponent> ezzzzzg_ = a?.Destination;
            TestScript.MetadataComponent ezzzzzh_ = a?.Metadata;
            List<TestScript.FixtureComponent> ezzzzzi_ = a?.Fixture;
            List<ResourceReference> ezzzzzj_ = a?.Profile;
            List<TestScript.VariableComponent> ezzzzzk_ = a?.Variable;
            TestScript.SetupComponent ezzzzzl_ = a?.Setup;
            List<TestScript.TestComponent> ezzzzzm_ = a?.Test;
            TestScript.TeardownComponent ezzzzzn_ = a?.Teardown;
            TestScript ezzzzzo_ = new TestScript
            {
                UrlElement = dzzzzzq_,
                Identifier = dzzzzzr_,
                VersionElement = dzzzzzs_,
                NameElement = dzzzzzt_,
                TitleElement = dzzzzzu_,
                StatusElement = dzzzzzv_,
                ExperimentalElement = dzzzzzw_,
                DateElement = dzzzzzx_,
                PublisherElement = dzzzzzy_,
                Contact = new List<ContactDetail>((IEnumerable<ContactDetail>)dzzzzzz_),
                DescriptionElement = ezzzzza_,
                UseContext = new List<UsageContext>((IEnumerable<UsageContext>)ezzzzzb_),
                Jurisdiction = new List<CodeableConcept>((IEnumerable<CodeableConcept>)ezzzzzc_),
                PurposeElement = ezzzzzd_,
                CopyrightElement = ezzzzze_,
                Origin = new List<TestScript.OriginComponent>((IEnumerable<TestScript.OriginComponent>)ezzzzzf_),
                Destination = new List<TestScript.DestinationComponent>((IEnumerable<TestScript.DestinationComponent>)ezzzzzg_),
                Metadata = ezzzzzh_,
                Fixture = new List<TestScript.FixtureComponent>((IEnumerable<TestScript.FixtureComponent>)ezzzzzi_),
                Profile = new List<ResourceReference>((IEnumerable<ResourceReference>)ezzzzzj_),
                Variable = new List<TestScript.VariableComponent>((IEnumerable<TestScript.VariableComponent>)ezzzzzk_),
                Setup = ezzzzzl_,
                Test = new List<TestScript.TestComponent>((IEnumerable<TestScript.TestComponent>)ezzzzzm_),
                Teardown = ezzzzzn_,
            };

            return ezzzzzo_;
        };
        IEnumerable<TestScript> dzzzzzn_ = context.Operators.Select<TestScript, TestScript>((IEnumerable<TestScript>)dzzzzzl_, dzzzzzm_);
        IEnumerable<TestScript> dzzzzzo_ = context.Operators.Distinct<TestScript>(dzzzzzn_);
        TestScript dzzzzzp_ = context.Operators.SingletonFrom<TestScript>(dzzzzzo_);

        return dzzzzzp_;
    }


    [CqlExpressionDefinition("ValueSetResource")]
    public ValueSet ValueSetResource(CqlContext context, ValueSet arg)
    {
        ValueSet[] ezzzzzp_ = [
            arg,
        ];
        ValueSet ezzzzzq_(ValueSet a)
        {
            FhirUri ezzzzzu_ = a?.UrlElement;
            List<Identifier> ezzzzzv_ = a?.Identifier;
            FhirString ezzzzzw_ = a?.VersionElement;
            FhirString ezzzzzx_ = a?.NameElement;
            FhirString ezzzzzy_ = a?.TitleElement;
            Code<PublicationStatus> ezzzzzz_ = a?.StatusElement;
            FhirBoolean fzzzzza_ = a?.ExperimentalElement;
            FhirDateTime fzzzzzb_ = a?.DateElement;
            FhirString fzzzzzc_ = a?.PublisherElement;
            List<ContactDetail> fzzzzzd_ = a?.Contact;
            Markdown fzzzzze_ = a?.DescriptionElement;
            List<UsageContext> fzzzzzf_ = a?.UseContext;
            List<CodeableConcept> fzzzzzg_ = a?.Jurisdiction;
            FhirBoolean fzzzzzh_ = a?.ImmutableElement;
            Markdown fzzzzzi_ = a?.PurposeElement;
            Markdown fzzzzzj_ = a?.CopyrightElement;
            ValueSet.ComposeComponent fzzzzzk_ = a?.Compose;
            ValueSet.ExpansionComponent fzzzzzl_ = a?.Expansion;
            ValueSet fzzzzzm_ = new ValueSet
            {
                UrlElement = ezzzzzu_,
                Identifier = new List<Identifier>((IEnumerable<Identifier>)ezzzzzv_),
                VersionElement = ezzzzzw_,
                NameElement = ezzzzzx_,
                TitleElement = ezzzzzy_,
                StatusElement = ezzzzzz_,
                ExperimentalElement = fzzzzza_,
                DateElement = fzzzzzb_,
                PublisherElement = fzzzzzc_,
                Contact = new List<ContactDetail>((IEnumerable<ContactDetail>)fzzzzzd_),
                DescriptionElement = fzzzzze_,
                UseContext = new List<UsageContext>((IEnumerable<UsageContext>)fzzzzzf_),
                Jurisdiction = new List<CodeableConcept>((IEnumerable<CodeableConcept>)fzzzzzg_),
                ImmutableElement = fzzzzzh_,
                PurposeElement = fzzzzzi_,
                CopyrightElement = fzzzzzj_,
                Compose = fzzzzzk_,
                Expansion = fzzzzzl_,
            };

            return fzzzzzm_;
        };
        IEnumerable<ValueSet> ezzzzzr_ = context.Operators.Select<ValueSet, ValueSet>((IEnumerable<ValueSet>)ezzzzzp_, ezzzzzq_);
        IEnumerable<ValueSet> ezzzzzs_ = context.Operators.Distinct<ValueSet>(ezzzzzr_);
        ValueSet ezzzzzt_ = context.Operators.SingletonFrom<ValueSet>(ezzzzzs_);

        return ezzzzzt_;
    }


    [CqlExpressionDefinition("VerificationResultResource")]
    public VerificationResult VerificationResultResource(CqlContext context, VerificationResult arg)
    {
        VerificationResult[] fzzzzzn_ = [
            arg,
        ];
        VerificationResult fzzzzzo_(VerificationResult a)
        {
            List<ResourceReference> fzzzzzs_ = a?.Target;
            List<FhirString> fzzzzzt_ = a?.TargetLocationElement;
            CodeableConcept fzzzzzu_ = a?.Need;
            Code<VerificationResult.StatusCode> fzzzzzv_ = a?.StatusElement;
            FhirDateTime fzzzzzw_ = a?.StatusDateElement;
            CodeableConcept fzzzzzx_ = a?.ValidationType;
            List<CodeableConcept> fzzzzzy_ = a?.ValidationProcess;
            Timing fzzzzzz_ = a?.Frequency;
            FhirDateTime gzzzzza_ = a?.LastPerformedElement;
            Date gzzzzzb_ = a?.NextScheduledElement;
            CodeableConcept gzzzzzc_ = a?.FailureAction;
            List<VerificationResult.PrimarySourceComponent> gzzzzzd_ = a?.PrimarySource;
            VerificationResult.AttestationComponent gzzzzze_ = a?.Attestation;
            List<VerificationResult.ValidatorComponent> gzzzzzf_ = a?.Validator;
            VerificationResult gzzzzzg_ = new VerificationResult
            {
                Target = new List<ResourceReference>((IEnumerable<ResourceReference>)fzzzzzs_),
                TargetLocationElement = new List<FhirString>((IEnumerable<FhirString>)fzzzzzt_),
                Need = fzzzzzu_,
                StatusElement = fzzzzzv_,
                StatusDateElement = fzzzzzw_,
                ValidationType = fzzzzzx_,
                ValidationProcess = new List<CodeableConcept>((IEnumerable<CodeableConcept>)fzzzzzy_),
                Frequency = fzzzzzz_,
                LastPerformedElement = gzzzzza_,
                NextScheduledElement = gzzzzzb_,
                FailureAction = gzzzzzc_,
                PrimarySource = new List<VerificationResult.PrimarySourceComponent>((IEnumerable<VerificationResult.PrimarySourceComponent>)gzzzzzd_),
                Attestation = gzzzzze_,
                Validator = new List<VerificationResult.ValidatorComponent>((IEnumerable<VerificationResult.ValidatorComponent>)gzzzzzf_),
            };

            return gzzzzzg_;
        };
        IEnumerable<VerificationResult> fzzzzzp_ = context.Operators.Select<VerificationResult, VerificationResult>((IEnumerable<VerificationResult>)fzzzzzn_, fzzzzzo_);
        IEnumerable<VerificationResult> fzzzzzq_ = context.Operators.Distinct<VerificationResult>(fzzzzzp_);
        VerificationResult fzzzzzr_ = context.Operators.SingletonFrom<VerificationResult>(fzzzzzq_);

        return fzzzzzr_;
    }


    [CqlExpressionDefinition("VisionPrescriptionResource")]
    public VisionPrescription VisionPrescriptionResource(CqlContext context, VisionPrescription arg)
    {
        VisionPrescription[] gzzzzzh_ = [
            arg,
        ];
        VisionPrescription gzzzzzi_(VisionPrescription a)
        {
            List<Identifier> gzzzzzm_ = a?.Identifier;
            Code<FinancialResourceStatusCodes> gzzzzzn_ = a?.StatusElement;
            FhirDateTime gzzzzzo_ = a?.CreatedElement;
            ResourceReference gzzzzzp_ = a?.Patient;
            ResourceReference gzzzzzq_ = a?.Encounter;
            FhirDateTime gzzzzzr_ = a?.DateWrittenElement;
            ResourceReference gzzzzzs_ = a?.Prescriber;
            List<VisionPrescription.LensSpecificationComponent> gzzzzzt_ = a?.LensSpecification;
            VisionPrescription gzzzzzu_ = new VisionPrescription
            {
                Identifier = new List<Identifier>((IEnumerable<Identifier>)gzzzzzm_),
                StatusElement = gzzzzzn_,
                CreatedElement = gzzzzzo_,
                Patient = gzzzzzp_,
                Encounter = gzzzzzq_,
                DateWrittenElement = gzzzzzr_,
                Prescriber = gzzzzzs_,
                LensSpecification = new List<VisionPrescription.LensSpecificationComponent>((IEnumerable<VisionPrescription.LensSpecificationComponent>)gzzzzzt_),
            };

            return gzzzzzu_;
        };
        IEnumerable<VisionPrescription> gzzzzzj_ = context.Operators.Select<VisionPrescription, VisionPrescription>((IEnumerable<VisionPrescription>)gzzzzzh_, gzzzzzi_);
        IEnumerable<VisionPrescription> gzzzzzk_ = context.Operators.Distinct<VisionPrescription>(gzzzzzj_);
        VisionPrescription gzzzzzl_ = context.Operators.SingletonFrom<VisionPrescription>(gzzzzzk_);

        return gzzzzzl_;
    }


    #endregion Expressions

}

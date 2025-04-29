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
        Account[] vi_ = [
            arg,
        ];
        Account vj_(Account a)
        {
            List<Identifier> vn_ = a?.Identifier;
            Code<Account.AccountStatus> vo_ = a?.StatusElement;
            CodeableConcept vp_ = a?.Type;
            FhirString vq_ = a?.NameElement;
            List<ResourceReference> vr_ = a?.Subject;
            Period vs_ = a?.ServicePeriod;
            List<Account.CoverageComponent> vt_ = a?.Coverage;
            ResourceReference vu_ = a?.Owner;
            FhirString vv_ = a?.DescriptionElement;
            List<Account.GuarantorComponent> vw_ = a?.Guarantor;
            ResourceReference vx_ = a?.PartOf;
            Account vy_ = new Account
            {
                Identifier = new List<Identifier>((IEnumerable<Identifier>)vn_),
                StatusElement = vo_,
                Type = vp_,
                NameElement = vq_,
                Subject = new List<ResourceReference>((IEnumerable<ResourceReference>)vr_),
                ServicePeriod = vs_,
                Coverage = new List<Account.CoverageComponent>((IEnumerable<Account.CoverageComponent>)vt_),
                Owner = vu_,
                DescriptionElement = vv_,
                Guarantor = new List<Account.GuarantorComponent>((IEnumerable<Account.GuarantorComponent>)vw_),
                PartOf = vx_,
            };

            return vy_;
        };
        IEnumerable<Account> vk_ = context.Operators.Select<Account, Account>((IEnumerable<Account>)vi_, vj_);
        IEnumerable<Account> vl_ = context.Operators.Distinct<Account>(vk_);
        Account vm_ = context.Operators.SingletonFrom<Account>(vl_);

        return vm_;
    }


    [CqlExpressionDefinition("ActivityDefinitionResource")]
    public ActivityDefinition ActivityDefinitionResource(CqlContext context, ActivityDefinition arg)
    {
        ActivityDefinition[] vz_ = [
            arg,
        ];
        ActivityDefinition wa_(ActivityDefinition a)
        {
            FhirUri we_ = a?.UrlElement;
            List<Identifier> wf_ = a?.Identifier;
            FhirString wg_ = a?.VersionElement;
            FhirString wh_ = a?.NameElement;
            FhirString wi_ = a?.TitleElement;
            FhirString wj_ = a?.SubtitleElement;
            Code<PublicationStatus> wk_ = a?.StatusElement;
            FhirBoolean wl_ = a?.ExperimentalElement;
            DataType wm_ = a?.Subject;
            FhirDateTime wn_ = a?.DateElement;
            FhirString wo_ = a?.PublisherElement;
            List<ContactDetail> wp_ = a?.Contact;
            Markdown wq_ = a?.DescriptionElement;
            List<UsageContext> wr_ = a?.UseContext;
            List<CodeableConcept> ws_ = a?.Jurisdiction;
            Markdown wt_ = a?.PurposeElement;
            FhirString wu_ = a?.UsageElement;
            Markdown wv_ = a?.CopyrightElement;
            Date ww_ = a?.ApprovalDateElement;
            Date wx_ = a?.LastReviewDateElement;
            Period wy_ = a?.EffectivePeriod;
            List<CodeableConcept> wz_ = a?.Topic;
            List<ContactDetail> xa_ = a?.Author;
            List<ContactDetail> xb_ = a?.Editor;
            List<ContactDetail> xc_ = a?.Reviewer;
            List<ContactDetail> xd_ = a?.Endorser;
            List<RelatedArtifact> xe_ = a?.RelatedArtifact;
            List<Canonical> xf_ = a?.LibraryElement;
            Code<ActivityDefinition.RequestResourceType> xg_ = a?.KindElement;
            Canonical xh_ = a?.ProfileElement;
            CodeableConcept xi_ = a?.Code;
            Code<RequestIntent> xj_ = a?.IntentElement;
            Code<RequestPriority> xk_ = a?.PriorityElement;
            FhirBoolean xl_ = a?.DoNotPerformElement;
            DataType xm_ = a?.Timing;
            ResourceReference xn_ = a?.Location;
            List<ActivityDefinition.ParticipantComponent> xo_ = a?.Participant;
            DataType xp_ = a?.Product;
            Quantity xq_ = a?.Quantity;
            List<Dosage> xr_ = a?.Dosage;
            List<CodeableConcept> xs_ = a?.BodySite;
            List<ResourceReference> xt_ = a?.SpecimenRequirement;
            List<ResourceReference> xu_ = a?.ObservationRequirement;
            List<ResourceReference> xv_ = a?.ObservationResultRequirement;
            Canonical xw_ = a?.TransformElement;
            List<ActivityDefinition.DynamicValueComponent> xx_ = a?.DynamicValue;
            ActivityDefinition xy_ = new ActivityDefinition
            {
                UrlElement = we_,
                Identifier = new List<Identifier>((IEnumerable<Identifier>)wf_),
                VersionElement = wg_,
                NameElement = wh_,
                TitleElement = wi_,
                SubtitleElement = wj_,
                StatusElement = wk_,
                ExperimentalElement = wl_,
                Subject = (DataType)wm_,
                DateElement = wn_,
                PublisherElement = wo_,
                Contact = new List<ContactDetail>((IEnumerable<ContactDetail>)wp_),
                DescriptionElement = wq_,
                UseContext = new List<UsageContext>((IEnumerable<UsageContext>)wr_),
                Jurisdiction = new List<CodeableConcept>((IEnumerable<CodeableConcept>)ws_),
                PurposeElement = wt_,
                UsageElement = wu_,
                CopyrightElement = wv_,
                ApprovalDateElement = ww_,
                LastReviewDateElement = wx_,
                EffectivePeriod = wy_,
                Topic = new List<CodeableConcept>((IEnumerable<CodeableConcept>)wz_),
                Author = new List<ContactDetail>((IEnumerable<ContactDetail>)xa_),
                Editor = new List<ContactDetail>((IEnumerable<ContactDetail>)xb_),
                Reviewer = new List<ContactDetail>((IEnumerable<ContactDetail>)xc_),
                Endorser = new List<ContactDetail>((IEnumerable<ContactDetail>)xd_),
                RelatedArtifact = new List<RelatedArtifact>((IEnumerable<RelatedArtifact>)xe_),
                LibraryElement = new List<Canonical>((IEnumerable<Canonical>)xf_),
                KindElement = xg_,
                ProfileElement = xh_,
                Code = xi_,
                IntentElement = xj_,
                PriorityElement = xk_,
                DoNotPerformElement = xl_,
                Timing = (DataType)xm_,
                Location = xn_,
                Participant = new List<ActivityDefinition.ParticipantComponent>((IEnumerable<ActivityDefinition.ParticipantComponent>)xo_),
                Product = (DataType)xp_,
                Quantity = xq_,
                Dosage = new List<Dosage>((IEnumerable<Dosage>)xr_),
                BodySite = new List<CodeableConcept>((IEnumerable<CodeableConcept>)xs_),
                SpecimenRequirement = new List<ResourceReference>((IEnumerable<ResourceReference>)xt_),
                ObservationRequirement = new List<ResourceReference>((IEnumerable<ResourceReference>)xu_),
                ObservationResultRequirement = new List<ResourceReference>((IEnumerable<ResourceReference>)xv_),
                TransformElement = xw_,
                DynamicValue = new List<ActivityDefinition.DynamicValueComponent>((IEnumerable<ActivityDefinition.DynamicValueComponent>)xx_),
            };

            return xy_;
        };
        IEnumerable<ActivityDefinition> wb_ = context.Operators.Select<ActivityDefinition, ActivityDefinition>((IEnumerable<ActivityDefinition>)vz_, wa_);
        IEnumerable<ActivityDefinition> wc_ = context.Operators.Distinct<ActivityDefinition>(wb_);
        ActivityDefinition wd_ = context.Operators.SingletonFrom<ActivityDefinition>(wc_);

        return wd_;
    }


    [CqlExpressionDefinition("AdverseEventResource")]
    public AdverseEvent AdverseEventResource(CqlContext context, AdverseEvent arg)
    {
        AdverseEvent[] xz_ = [
            arg,
        ];
        AdverseEvent ya_(AdverseEvent a)
        {
            Identifier ye_ = a?.Identifier;
            Code<AdverseEvent.AdverseEventActuality> yf_ = a?.ActualityElement;
            List<CodeableConcept> yg_ = a?.Category;
            CodeableConcept yh_ = a?.Event;
            ResourceReference yi_ = a?.Subject;
            ResourceReference yj_ = a?.Encounter;
            FhirDateTime yk_ = a?.DateElement;
            FhirDateTime yl_ = a?.DetectedElement;
            FhirDateTime ym_ = a?.RecordedDateElement;
            List<ResourceReference> yn_ = a?.ResultingCondition;
            ResourceReference yo_ = a?.Location;
            CodeableConcept yp_ = a?.Seriousness;
            CodeableConcept yq_ = a?.Severity;
            CodeableConcept yr_ = a?.Outcome;
            ResourceReference ys_ = a?.Recorder;
            List<ResourceReference> yt_ = a?.Contributor;
            List<AdverseEvent.SuspectEntityComponent> yu_ = a?.SuspectEntity;
            List<ResourceReference> yv_ = a?.SubjectMedicalHistory;
            List<ResourceReference> yw_ = a?.ReferenceDocument;
            List<ResourceReference> yx_ = a?.Study;
            AdverseEvent yy_ = new AdverseEvent
            {
                Identifier = ye_,
                ActualityElement = yf_,
                Category = new List<CodeableConcept>((IEnumerable<CodeableConcept>)yg_),
                Event = yh_,
                Subject = yi_,
                Encounter = yj_,
                DateElement = yk_,
                DetectedElement = yl_,
                RecordedDateElement = ym_,
                ResultingCondition = new List<ResourceReference>((IEnumerable<ResourceReference>)yn_),
                Location = yo_,
                Seriousness = yp_,
                Severity = yq_,
                Outcome = yr_,
                Recorder = ys_,
                Contributor = new List<ResourceReference>((IEnumerable<ResourceReference>)yt_),
                SuspectEntity = new List<AdverseEvent.SuspectEntityComponent>((IEnumerable<AdverseEvent.SuspectEntityComponent>)yu_),
                SubjectMedicalHistory = new List<ResourceReference>((IEnumerable<ResourceReference>)yv_),
                ReferenceDocument = new List<ResourceReference>((IEnumerable<ResourceReference>)yw_),
                Study = new List<ResourceReference>((IEnumerable<ResourceReference>)yx_),
            };

            return yy_;
        };
        IEnumerable<AdverseEvent> yb_ = context.Operators.Select<AdverseEvent, AdverseEvent>((IEnumerable<AdverseEvent>)xz_, ya_);
        IEnumerable<AdverseEvent> yc_ = context.Operators.Distinct<AdverseEvent>(yb_);
        AdverseEvent yd_ = context.Operators.SingletonFrom<AdverseEvent>(yc_);

        return yd_;
    }


    [CqlExpressionDefinition("AllergyIntoleranceResource")]
    public AllergyIntolerance AllergyIntoleranceResource(CqlContext context, AllergyIntolerance arg)
    {
        AllergyIntolerance[] yz_ = [
            arg,
        ];
        AllergyIntolerance za_(AllergyIntolerance a)
        {
            List<Identifier> ze_ = a?.Identifier;
            CodeableConcept zf_ = a?.ClinicalStatus;
            CodeableConcept zg_ = a?.VerificationStatus;
            Code<AllergyIntolerance.AllergyIntoleranceType> zh_ = a?.TypeElement;
            List<Code<AllergyIntolerance.AllergyIntoleranceCategory>> zi_ = a?.CategoryElement;
            Code<AllergyIntolerance.AllergyIntoleranceCriticality> zj_ = a?.CriticalityElement;
            CodeableConcept zk_ = a?.Code;
            ResourceReference zl_ = a?.Patient;
            ResourceReference zm_ = a?.Encounter;
            DataType zn_ = a?.Onset;
            FhirDateTime zo_ = a?.RecordedDateElement;
            ResourceReference zp_ = a?.Recorder;
            ResourceReference zq_ = a?.Asserter;
            FhirDateTime zr_ = a?.LastOccurrenceElement;
            List<Annotation> zs_ = a?.Note;
            List<AllergyIntolerance.ReactionComponent> zt_ = a?.Reaction;
            AllergyIntolerance zu_ = new AllergyIntolerance
            {
                Identifier = new List<Identifier>((IEnumerable<Identifier>)ze_),
                ClinicalStatus = zf_,
                VerificationStatus = zg_,
                TypeElement = zh_,
                CategoryElement = new List<Code<AllergyIntolerance.AllergyIntoleranceCategory>>((IEnumerable<Code<AllergyIntolerance.AllergyIntoleranceCategory>>)zi_),
                CriticalityElement = zj_,
                Code = zk_,
                Patient = zl_,
                Encounter = zm_,
                Onset = (DataType)zn_,
                RecordedDateElement = zo_,
                Recorder = zp_,
                Asserter = zq_,
                LastOccurrenceElement = zr_,
                Note = new List<Annotation>((IEnumerable<Annotation>)zs_),
                Reaction = new List<AllergyIntolerance.ReactionComponent>((IEnumerable<AllergyIntolerance.ReactionComponent>)zt_),
            };

            return zu_;
        };
        IEnumerable<AllergyIntolerance> zb_ = context.Operators.Select<AllergyIntolerance, AllergyIntolerance>((IEnumerable<AllergyIntolerance>)yz_, za_);
        IEnumerable<AllergyIntolerance> zc_ = context.Operators.Distinct<AllergyIntolerance>(zb_);
        AllergyIntolerance zd_ = context.Operators.SingletonFrom<AllergyIntolerance>(zc_);

        return zd_;
    }


    [CqlExpressionDefinition("AppointmentResource")]
    public Appointment AppointmentResource(CqlContext context, Appointment arg)
    {
        Appointment[] zv_ = [
            arg,
        ];
        Appointment zw_(Appointment a)
        {
            List<Identifier> aza_ = a?.Identifier;
            Code<Appointment.AppointmentStatus> azb_ = a?.StatusElement;
            CodeableConcept azc_ = a?.CancelationReason;
            List<CodeableConcept> azd_ = a?.ServiceCategory;
            List<CodeableConcept> aze_ = a?.ServiceType;
            List<CodeableConcept> azf_ = a?.Specialty;
            CodeableConcept azg_ = a?.AppointmentType;
            List<CodeableConcept> azh_ = a?.ReasonCode;
            List<ResourceReference> azi_ = a?.ReasonReference;
            UnsignedInt azj_ = a?.PriorityElement;
            Integer azk_ = context.Operators.Convert<Integer>(azj_);
            UnsignedInt azl_ = context.Operators.Convert<UnsignedInt>(azk_);
            FhirString azm_ = a?.DescriptionElement;
            List<ResourceReference> azn_ = a?.SupportingInformation;
            Instant azo_ = a?.StartElement;
            Instant azp_ = a?.EndElement;
            PositiveInt azq_ = a?.MinutesDurationElement;
            Integer azr_ = context.Operators.Convert<Integer>(azq_);
            PositiveInt azs_ = context.Operators.Convert<PositiveInt>(azr_);
            List<ResourceReference> azt_ = a?.Slot;
            FhirDateTime azu_ = a?.CreatedElement;
            FhirString azv_ = a?.CommentElement;
            FhirString azw_ = a?.PatientInstructionElement;
            List<ResourceReference> azx_ = a?.BasedOn;
            List<Appointment.ParticipantComponent> azy_ = a?.Participant;
            List<Period> azz_ = a?.RequestedPeriod;
            Appointment bza_ = new Appointment
            {
                Identifier = new List<Identifier>((IEnumerable<Identifier>)aza_),
                StatusElement = azb_,
                CancelationReason = azc_,
                ServiceCategory = new List<CodeableConcept>((IEnumerable<CodeableConcept>)azd_),
                ServiceType = new List<CodeableConcept>((IEnumerable<CodeableConcept>)aze_),
                Specialty = new List<CodeableConcept>((IEnumerable<CodeableConcept>)azf_),
                AppointmentType = azg_,
                ReasonCode = new List<CodeableConcept>((IEnumerable<CodeableConcept>)azh_),
                ReasonReference = new List<ResourceReference>((IEnumerable<ResourceReference>)azi_),
                PriorityElement = azl_,
                DescriptionElement = azm_,
                SupportingInformation = new List<ResourceReference>((IEnumerable<ResourceReference>)azn_),
                StartElement = azo_,
                EndElement = azp_,
                MinutesDurationElement = azs_,
                Slot = new List<ResourceReference>((IEnumerable<ResourceReference>)azt_),
                CreatedElement = azu_,
                CommentElement = azv_,
                PatientInstructionElement = azw_,
                BasedOn = new List<ResourceReference>((IEnumerable<ResourceReference>)azx_),
                Participant = new List<Appointment.ParticipantComponent>((IEnumerable<Appointment.ParticipantComponent>)azy_),
                RequestedPeriod = new List<Period>((IEnumerable<Period>)azz_),
            };

            return bza_;
        };
        IEnumerable<Appointment> zx_ = context.Operators.Select<Appointment, Appointment>((IEnumerable<Appointment>)zv_, zw_);
        IEnumerable<Appointment> zy_ = context.Operators.Distinct<Appointment>(zx_);
        Appointment zz_ = context.Operators.SingletonFrom<Appointment>(zy_);

        return zz_;
    }


    [CqlExpressionDefinition("AppointmentResponseResource")]
    public AppointmentResponse AppointmentResponseResource(CqlContext context, AppointmentResponse arg)
    {
        AppointmentResponse[] bzb_ = [
            arg,
        ];
        AppointmentResponse bzc_(AppointmentResponse a)
        {
            List<Identifier> bzg_ = a?.Identifier;
            ResourceReference bzh_ = a?.Appointment;
            Instant bzi_ = a?.StartElement;
            Instant bzj_ = a?.EndElement;
            List<CodeableConcept> bzk_ = a?.ParticipantType;
            ResourceReference bzl_ = a?.Actor;
            Code<ParticipationStatus> bzm_ = a?.ParticipantStatusElement;
            FhirString bzn_ = a?.CommentElement;
            AppointmentResponse bzo_ = new AppointmentResponse
            {
                Identifier = new List<Identifier>((IEnumerable<Identifier>)bzg_),
                Appointment = bzh_,
                StartElement = bzi_,
                EndElement = bzj_,
                ParticipantType = new List<CodeableConcept>((IEnumerable<CodeableConcept>)bzk_),
                Actor = bzl_,
                ParticipantStatusElement = bzm_,
                CommentElement = bzn_,
            };

            return bzo_;
        };
        IEnumerable<AppointmentResponse> bzd_ = context.Operators.Select<AppointmentResponse, AppointmentResponse>((IEnumerable<AppointmentResponse>)bzb_, bzc_);
        IEnumerable<AppointmentResponse> bze_ = context.Operators.Distinct<AppointmentResponse>(bzd_);
        AppointmentResponse bzf_ = context.Operators.SingletonFrom<AppointmentResponse>(bze_);

        return bzf_;
    }


    [CqlExpressionDefinition("AuditEventResource")]
    public AuditEvent AuditEventResource(CqlContext context, AuditEvent arg)
    {
        AuditEvent[] bzp_ = [
            arg,
        ];
        AuditEvent bzq_(AuditEvent a)
        {
            Coding bzu_ = a?.Type;
            List<Coding> bzv_ = a?.Subtype;
            Code<AuditEvent.AuditEventAction> bzw_ = a?.ActionElement;
            Period bzx_ = a?.Period;
            Instant bzy_ = a?.RecordedElement;
            Code<AuditEvent.AuditEventOutcome> bzz_ = a?.OutcomeElement;
            FhirString cza_ = a?.OutcomeDescElement;
            List<CodeableConcept> czb_ = a?.PurposeOfEvent;
            List<AuditEvent.AgentComponent> czc_ = a?.Agent;
            AuditEvent.SourceComponent czd_ = a?.Source;
            List<AuditEvent.EntityComponent> cze_ = a?.Entity;
            AuditEvent czf_ = new AuditEvent
            {
                Type = bzu_,
                Subtype = new List<Coding>((IEnumerable<Coding>)bzv_),
                ActionElement = bzw_,
                Period = bzx_,
                RecordedElement = bzy_,
                OutcomeElement = bzz_,
                OutcomeDescElement = cza_,
                PurposeOfEvent = new List<CodeableConcept>((IEnumerable<CodeableConcept>)czb_),
                Agent = new List<AuditEvent.AgentComponent>((IEnumerable<AuditEvent.AgentComponent>)czc_),
                Source = czd_,
                Entity = new List<AuditEvent.EntityComponent>((IEnumerable<AuditEvent.EntityComponent>)cze_),
            };

            return czf_;
        };
        IEnumerable<AuditEvent> bzr_ = context.Operators.Select<AuditEvent, AuditEvent>((IEnumerable<AuditEvent>)bzp_, bzq_);
        IEnumerable<AuditEvent> bzs_ = context.Operators.Distinct<AuditEvent>(bzr_);
        AuditEvent bzt_ = context.Operators.SingletonFrom<AuditEvent>(bzs_);

        return bzt_;
    }


    [CqlExpressionDefinition("BasicResource")]
    public Basic BasicResource(CqlContext context, Basic arg)
    {
        Basic[] czg_ = [
            arg,
        ];
        Basic czh_(Basic a)
        {
            List<Identifier> czl_ = a?.Identifier;
            CodeableConcept czm_ = a?.Code;
            ResourceReference czn_ = a?.Subject;
            Date czo_ = a?.CreatedElement;
            ResourceReference czp_ = a?.Author;
            Basic czq_ = new Basic
            {
                Identifier = new List<Identifier>((IEnumerable<Identifier>)czl_),
                Code = czm_,
                Subject = czn_,
                CreatedElement = czo_,
                Author = czp_,
            };

            return czq_;
        };
        IEnumerable<Basic> czi_ = context.Operators.Select<Basic, Basic>((IEnumerable<Basic>)czg_, czh_);
        IEnumerable<Basic> czj_ = context.Operators.Distinct<Basic>(czi_);
        Basic czk_ = context.Operators.SingletonFrom<Basic>(czj_);

        return czk_;
    }


    [CqlExpressionDefinition("BiologicallyDerivedProductResource")]
    public BiologicallyDerivedProduct BiologicallyDerivedProductResource(CqlContext context, BiologicallyDerivedProduct arg)
    {
        BiologicallyDerivedProduct[] czr_ = [
            arg,
        ];
        BiologicallyDerivedProduct czs_(BiologicallyDerivedProduct a)
        {
            List<Identifier> czw_ = a?.Identifier;
            Code<BiologicallyDerivedProduct.BiologicallyDerivedProductCategory> czx_ = a?.ProductCategoryElement;
            CodeableConcept czy_ = a?.ProductCode;
            Code<BiologicallyDerivedProduct.BiologicallyDerivedProductStatus> czz_ = a?.StatusElement;
            List<ResourceReference> dza_ = a?.Request;
            Integer dzb_ = a?.QuantityElement;
            List<ResourceReference> dzc_ = a?.Parent;
            BiologicallyDerivedProduct.CollectionComponent dzd_ = a?.Collection;
            List<BiologicallyDerivedProduct.ProcessingComponent> dze_ = a?.Processing;
            BiologicallyDerivedProduct.ManipulationComponent dzf_ = a?.Manipulation;
            List<BiologicallyDerivedProduct.StorageComponent> dzg_ = a?.Storage;
            BiologicallyDerivedProduct dzh_ = new BiologicallyDerivedProduct
            {
                Identifier = new List<Identifier>((IEnumerable<Identifier>)czw_),
                ProductCategoryElement = czx_,
                ProductCode = czy_,
                StatusElement = czz_,
                Request = new List<ResourceReference>((IEnumerable<ResourceReference>)dza_),
                QuantityElement = dzb_,
                Parent = new List<ResourceReference>((IEnumerable<ResourceReference>)dzc_),
                Collection = dzd_,
                Processing = new List<BiologicallyDerivedProduct.ProcessingComponent>((IEnumerable<BiologicallyDerivedProduct.ProcessingComponent>)dze_),
                Manipulation = dzf_,
                Storage = new List<BiologicallyDerivedProduct.StorageComponent>((IEnumerable<BiologicallyDerivedProduct.StorageComponent>)dzg_),
            };

            return dzh_;
        };
        IEnumerable<BiologicallyDerivedProduct> czt_ = context.Operators.Select<BiologicallyDerivedProduct, BiologicallyDerivedProduct>((IEnumerable<BiologicallyDerivedProduct>)czr_, czs_);
        IEnumerable<BiologicallyDerivedProduct> czu_ = context.Operators.Distinct<BiologicallyDerivedProduct>(czt_);
        BiologicallyDerivedProduct czv_ = context.Operators.SingletonFrom<BiologicallyDerivedProduct>(czu_);

        return czv_;
    }


    [CqlExpressionDefinition("BodyStructureResource")]
    public BodyStructure BodyStructureResource(CqlContext context, BodyStructure arg)
    {
        BodyStructure[] dzi_ = [
            arg,
        ];
        BodyStructure dzj_(BodyStructure a)
        {
            List<Identifier> dzn_ = a?.Identifier;
            FhirBoolean dzo_ = a?.ActiveElement;
            CodeableConcept dzp_ = a?.Morphology;
            CodeableConcept dzq_ = a?.Location;
            List<CodeableConcept> dzr_ = a?.LocationQualifier;
            FhirString dzs_ = a?.DescriptionElement;
            List<Attachment> dzt_ = a?.Image;
            ResourceReference dzu_ = a?.Patient;
            BodyStructure dzv_ = new BodyStructure
            {
                Identifier = new List<Identifier>((IEnumerable<Identifier>)dzn_),
                ActiveElement = dzo_,
                Morphology = dzp_,
                Location = dzq_,
                LocationQualifier = new List<CodeableConcept>((IEnumerable<CodeableConcept>)dzr_),
                DescriptionElement = dzs_,
                Image = new List<Attachment>((IEnumerable<Attachment>)dzt_),
                Patient = dzu_,
            };

            return dzv_;
        };
        IEnumerable<BodyStructure> dzk_ = context.Operators.Select<BodyStructure, BodyStructure>((IEnumerable<BodyStructure>)dzi_, dzj_);
        IEnumerable<BodyStructure> dzl_ = context.Operators.Distinct<BodyStructure>(dzk_);
        BodyStructure dzm_ = context.Operators.SingletonFrom<BodyStructure>(dzl_);

        return dzm_;
    }


    [CqlExpressionDefinition("CarePlanResource")]
    public CarePlan CarePlanResource(CqlContext context, CarePlan arg)
    {
        CarePlan[] dzw_ = [
            arg,
        ];
        CarePlan dzx_(CarePlan a)
        {
            List<Identifier> ezb_ = a?.Identifier;
            List<Canonical> ezc_ = a?.InstantiatesCanonicalElement;
            List<FhirUri> ezd_ = a?.InstantiatesUriElement;
            List<ResourceReference> eze_ = a?.BasedOn;
            List<ResourceReference> ezf_ = a?.Replaces;
            List<ResourceReference> ezg_ = a?.PartOf;
            Code<RequestStatus> ezh_ = a?.StatusElement;
            Code<CarePlan.CarePlanIntent> ezi_ = a?.IntentElement;
            List<CodeableConcept> ezj_ = a?.Category;
            FhirString ezk_ = a?.TitleElement;
            FhirString ezl_ = a?.DescriptionElement;
            ResourceReference ezm_ = a?.Subject;
            ResourceReference ezn_ = a?.Encounter;
            Period ezo_ = a?.Period;
            FhirDateTime ezp_ = a?.CreatedElement;
            ResourceReference ezq_ = a?.Author;
            List<ResourceReference> ezr_ = a?.Contributor;
            List<ResourceReference> ezs_ = a?.CareTeam;
            List<ResourceReference> ezt_ = a?.Addresses;
            List<ResourceReference> ezu_ = a?.SupportingInfo;
            List<ResourceReference> ezv_ = a?.Goal;
            List<CarePlan.ActivityComponent> ezw_ = a?.Activity;
            List<Annotation> ezx_ = a?.Note;
            CarePlan ezy_ = new CarePlan
            {
                Identifier = new List<Identifier>((IEnumerable<Identifier>)ezb_),
                InstantiatesCanonicalElement = new List<Canonical>((IEnumerable<Canonical>)ezc_),
                InstantiatesUriElement = new List<FhirUri>((IEnumerable<FhirUri>)ezd_),
                BasedOn = new List<ResourceReference>((IEnumerable<ResourceReference>)eze_),
                Replaces = new List<ResourceReference>((IEnumerable<ResourceReference>)ezf_),
                PartOf = new List<ResourceReference>((IEnumerable<ResourceReference>)ezg_),
                StatusElement = ezh_,
                IntentElement = ezi_,
                Category = new List<CodeableConcept>((IEnumerable<CodeableConcept>)ezj_),
                TitleElement = ezk_,
                DescriptionElement = ezl_,
                Subject = ezm_,
                Encounter = ezn_,
                Period = ezo_,
                CreatedElement = ezp_,
                Author = ezq_,
                Contributor = new List<ResourceReference>((IEnumerable<ResourceReference>)ezr_),
                CareTeam = new List<ResourceReference>((IEnumerable<ResourceReference>)ezs_),
                Addresses = new List<ResourceReference>((IEnumerable<ResourceReference>)ezt_),
                SupportingInfo = new List<ResourceReference>((IEnumerable<ResourceReference>)ezu_),
                Goal = new List<ResourceReference>((IEnumerable<ResourceReference>)ezv_),
                Activity = new List<CarePlan.ActivityComponent>((IEnumerable<CarePlan.ActivityComponent>)ezw_),
                Note = new List<Annotation>((IEnumerable<Annotation>)ezx_),
            };

            return ezy_;
        };
        IEnumerable<CarePlan> dzy_ = context.Operators.Select<CarePlan, CarePlan>((IEnumerable<CarePlan>)dzw_, dzx_);
        IEnumerable<CarePlan> dzz_ = context.Operators.Distinct<CarePlan>(dzy_);
        CarePlan eza_ = context.Operators.SingletonFrom<CarePlan>(dzz_);

        return eza_;
    }


    [CqlExpressionDefinition("CareTeamResource")]
    public CareTeam CareTeamResource(CqlContext context, CareTeam arg)
    {
        CareTeam[] ezz_ = [
            arg,
        ];
        CareTeam fza_(CareTeam a)
        {
            List<Identifier> fze_ = a?.Identifier;
            Code<CareTeam.CareTeamStatus> fzf_ = a?.StatusElement;
            List<CodeableConcept> fzg_ = a?.Category;
            FhirString fzh_ = a?.NameElement;
            ResourceReference fzi_ = a?.Subject;
            ResourceReference fzj_ = a?.Encounter;
            Period fzk_ = a?.Period;
            List<CareTeam.ParticipantComponent> fzl_ = a?.Participant;
            List<CodeableConcept> fzm_ = a?.ReasonCode;
            List<ResourceReference> fzn_ = a?.ReasonReference;
            List<ResourceReference> fzo_ = a?.ManagingOrganization;
            List<ContactPoint> fzp_ = a?.Telecom;
            List<Annotation> fzq_ = a?.Note;
            CareTeam fzr_ = new CareTeam
            {
                Identifier = new List<Identifier>((IEnumerable<Identifier>)fze_),
                StatusElement = fzf_,
                Category = new List<CodeableConcept>((IEnumerable<CodeableConcept>)fzg_),
                NameElement = fzh_,
                Subject = fzi_,
                Encounter = fzj_,
                Period = fzk_,
                Participant = new List<CareTeam.ParticipantComponent>((IEnumerable<CareTeam.ParticipantComponent>)fzl_),
                ReasonCode = new List<CodeableConcept>((IEnumerable<CodeableConcept>)fzm_),
                ReasonReference = new List<ResourceReference>((IEnumerable<ResourceReference>)fzn_),
                ManagingOrganization = new List<ResourceReference>((IEnumerable<ResourceReference>)fzo_),
                Telecom = new List<ContactPoint>((IEnumerable<ContactPoint>)fzp_),
                Note = new List<Annotation>((IEnumerable<Annotation>)fzq_),
            };

            return fzr_;
        };
        IEnumerable<CareTeam> fzb_ = context.Operators.Select<CareTeam, CareTeam>((IEnumerable<CareTeam>)ezz_, fza_);
        IEnumerable<CareTeam> fzc_ = context.Operators.Distinct<CareTeam>(fzb_);
        CareTeam fzd_ = context.Operators.SingletonFrom<CareTeam>(fzc_);

        return fzd_;
    }


    [CqlExpressionDefinition("CatalogEntryResource")]
    public CatalogEntry CatalogEntryResource(CqlContext context, CatalogEntry arg)
    {
        CatalogEntry[] fzs_ = [
            arg,
        ];
        CatalogEntry fzt_(CatalogEntry a)
        {
            List<Identifier> fzx_ = a?.Identifier;
            CodeableConcept fzy_ = a?.Type;
            FhirBoolean fzz_ = a?.OrderableElement;
            ResourceReference gza_ = a?.ReferencedItem;
            List<Identifier> gzb_ = a?.AdditionalIdentifier;
            List<CodeableConcept> gzc_ = a?.Classification;
            Code<PublicationStatus> gzd_ = a?.StatusElement;
            Period gze_ = a?.ValidityPeriod;
            FhirDateTime gzf_ = a?.ValidToElement;
            FhirDateTime gzg_ = a?.LastUpdatedElement;
            List<CodeableConcept> gzh_ = a?.AdditionalCharacteristic;
            List<CodeableConcept> gzi_ = a?.AdditionalClassification;
            List<CatalogEntry.RelatedEntryComponent> gzj_ = a?.RelatedEntry;
            CatalogEntry gzk_ = new CatalogEntry
            {
                Identifier = new List<Identifier>((IEnumerable<Identifier>)fzx_),
                Type = fzy_,
                OrderableElement = fzz_,
                ReferencedItem = gza_,
                AdditionalIdentifier = new List<Identifier>((IEnumerable<Identifier>)gzb_),
                Classification = new List<CodeableConcept>((IEnumerable<CodeableConcept>)gzc_),
                StatusElement = gzd_,
                ValidityPeriod = gze_,
                ValidToElement = gzf_,
                LastUpdatedElement = gzg_,
                AdditionalCharacteristic = new List<CodeableConcept>((IEnumerable<CodeableConcept>)gzh_),
                AdditionalClassification = new List<CodeableConcept>((IEnumerable<CodeableConcept>)gzi_),
                RelatedEntry = new List<CatalogEntry.RelatedEntryComponent>((IEnumerable<CatalogEntry.RelatedEntryComponent>)gzj_),
            };

            return gzk_;
        };
        IEnumerable<CatalogEntry> fzu_ = context.Operators.Select<CatalogEntry, CatalogEntry>((IEnumerable<CatalogEntry>)fzs_, fzt_);
        IEnumerable<CatalogEntry> fzv_ = context.Operators.Distinct<CatalogEntry>(fzu_);
        CatalogEntry fzw_ = context.Operators.SingletonFrom<CatalogEntry>(fzv_);

        return fzw_;
    }


    [CqlExpressionDefinition("ChargeItemResource")]
    public ChargeItem ChargeItemResource(CqlContext context, ChargeItem arg)
    {
        ChargeItem[] gzl_ = [
            arg,
        ];
        ChargeItem gzm_(ChargeItem a)
        {
            List<Identifier> gzq_ = a?.Identifier;
            List<FhirUri> gzr_ = a?.DefinitionUriElement;
            List<Canonical> gzs_ = a?.DefinitionCanonicalElement;
            Code<ChargeItem.ChargeItemStatus> gzt_ = a?.StatusElement;
            List<ResourceReference> gzu_ = a?.PartOf;
            CodeableConcept gzv_ = a?.Code;
            ResourceReference gzw_ = a?.Subject;
            ResourceReference gzx_ = a?.Context;
            DataType gzy_ = a?.Occurrence;
            List<ChargeItem.PerformerComponent> gzz_ = a?.Performer;
            ResourceReference hza_ = a?.PerformingOrganization;
            ResourceReference hzb_ = a?.RequestingOrganization;
            ResourceReference hzc_ = a?.CostCenter;
            Quantity hzd_ = a?.Quantity;
            List<CodeableConcept> hze_ = a?.Bodysite;
            FhirDecimal hzf_ = a?.FactorOverrideElement;
            Money hzg_ = a?.PriceOverride;
            FhirString hzh_ = a?.OverrideReasonElement;
            ResourceReference hzi_ = a?.Enterer;
            FhirDateTime hzj_ = a?.EnteredDateElement;
            List<CodeableConcept> hzk_ = a?.Reason;
            List<ResourceReference> hzl_ = a?.Service;
            DataType hzm_ = a?.Product;
            List<ResourceReference> hzn_ = a?.Account;
            List<Annotation> hzo_ = a?.Note;
            List<ResourceReference> hzp_ = a?.SupportingInformation;
            ChargeItem hzq_ = new ChargeItem
            {
                Identifier = new List<Identifier>((IEnumerable<Identifier>)gzq_),
                DefinitionUriElement = new List<FhirUri>((IEnumerable<FhirUri>)gzr_),
                DefinitionCanonicalElement = new List<Canonical>((IEnumerable<Canonical>)gzs_),
                StatusElement = gzt_,
                PartOf = new List<ResourceReference>((IEnumerable<ResourceReference>)gzu_),
                Code = gzv_,
                Subject = gzw_,
                Context = gzx_,
                Occurrence = (DataType)gzy_,
                Performer = new List<ChargeItem.PerformerComponent>((IEnumerable<ChargeItem.PerformerComponent>)gzz_),
                PerformingOrganization = hza_,
                RequestingOrganization = hzb_,
                CostCenter = hzc_,
                Quantity = hzd_,
                Bodysite = new List<CodeableConcept>((IEnumerable<CodeableConcept>)hze_),
                FactorOverrideElement = hzf_,
                PriceOverride = hzg_,
                OverrideReasonElement = hzh_,
                Enterer = hzi_,
                EnteredDateElement = hzj_,
                Reason = new List<CodeableConcept>((IEnumerable<CodeableConcept>)hzk_),
                Service = new List<ResourceReference>((IEnumerable<ResourceReference>)hzl_),
                Product = (DataType)hzm_,
                Account = new List<ResourceReference>((IEnumerable<ResourceReference>)hzn_),
                Note = new List<Annotation>((IEnumerable<Annotation>)hzo_),
                SupportingInformation = new List<ResourceReference>((IEnumerable<ResourceReference>)hzp_),
            };

            return hzq_;
        };
        IEnumerable<ChargeItem> gzn_ = context.Operators.Select<ChargeItem, ChargeItem>((IEnumerable<ChargeItem>)gzl_, gzm_);
        IEnumerable<ChargeItem> gzo_ = context.Operators.Distinct<ChargeItem>(gzn_);
        ChargeItem gzp_ = context.Operators.SingletonFrom<ChargeItem>(gzo_);

        return gzp_;
    }


    [CqlExpressionDefinition("ChargeItemDefinitionResource")]
    public ChargeItemDefinition ChargeItemDefinitionResource(CqlContext context, ChargeItemDefinition arg)
    {
        ChargeItemDefinition[] hzr_ = [
            arg,
        ];
        ChargeItemDefinition hzs_(ChargeItemDefinition a)
        {
            FhirUri hzw_ = a?.UrlElement;
            List<Identifier> hzx_ = a?.Identifier;
            FhirString hzy_ = a?.VersionElement;
            FhirString hzz_ = a?.TitleElement;
            List<FhirUri> iza_ = a?.DerivedFromUriElement;
            List<Canonical> izb_ = a?.PartOfElement;
            List<Canonical> izc_ = a?.ReplacesElement;
            Code<PublicationStatus> izd_ = a?.StatusElement;
            FhirBoolean ize_ = a?.ExperimentalElement;
            FhirDateTime izf_ = a?.DateElement;
            FhirString izg_ = a?.PublisherElement;
            List<ContactDetail> izh_ = a?.Contact;
            Markdown izi_ = a?.DescriptionElement;
            List<UsageContext> izj_ = a?.UseContext;
            List<CodeableConcept> izk_ = a?.Jurisdiction;
            Markdown izl_ = a?.CopyrightElement;
            Date izm_ = a?.ApprovalDateElement;
            Date izn_ = a?.LastReviewDateElement;
            Period izo_ = a?.EffectivePeriod;
            CodeableConcept izp_ = a?.Code;
            List<ResourceReference> izq_ = a?.Instance;
            List<ChargeItemDefinition.ApplicabilityComponent> izr_ = a?.Applicability;
            List<ChargeItemDefinition.PropertyGroupComponent> izs_ = a?.PropertyGroup;
            ChargeItemDefinition izt_ = new ChargeItemDefinition
            {
                UrlElement = hzw_,
                Identifier = new List<Identifier>((IEnumerable<Identifier>)hzx_),
                VersionElement = hzy_,
                TitleElement = hzz_,
                DerivedFromUriElement = new List<FhirUri>((IEnumerable<FhirUri>)iza_),
                PartOfElement = new List<Canonical>((IEnumerable<Canonical>)izb_),
                ReplacesElement = new List<Canonical>((IEnumerable<Canonical>)izc_),
                StatusElement = izd_,
                ExperimentalElement = ize_,
                DateElement = izf_,
                PublisherElement = izg_,
                Contact = new List<ContactDetail>((IEnumerable<ContactDetail>)izh_),
                DescriptionElement = izi_,
                UseContext = new List<UsageContext>((IEnumerable<UsageContext>)izj_),
                Jurisdiction = new List<CodeableConcept>((IEnumerable<CodeableConcept>)izk_),
                CopyrightElement = izl_,
                ApprovalDateElement = izm_,
                LastReviewDateElement = izn_,
                EffectivePeriod = izo_,
                Code = izp_,
                Instance = new List<ResourceReference>((IEnumerable<ResourceReference>)izq_),
                Applicability = new List<ChargeItemDefinition.ApplicabilityComponent>((IEnumerable<ChargeItemDefinition.ApplicabilityComponent>)izr_),
                PropertyGroup = new List<ChargeItemDefinition.PropertyGroupComponent>((IEnumerable<ChargeItemDefinition.PropertyGroupComponent>)izs_),
            };

            return izt_;
        };
        IEnumerable<ChargeItemDefinition> hzt_ = context.Operators.Select<ChargeItemDefinition, ChargeItemDefinition>((IEnumerable<ChargeItemDefinition>)hzr_, hzs_);
        IEnumerable<ChargeItemDefinition> hzu_ = context.Operators.Distinct<ChargeItemDefinition>(hzt_);
        ChargeItemDefinition hzv_ = context.Operators.SingletonFrom<ChargeItemDefinition>(hzu_);

        return hzv_;
    }


    [CqlExpressionDefinition("ClaimResource")]
    public Claim ClaimResource(CqlContext context, Claim arg)
    {
        Claim[] izu_ = [
            arg,
        ];
        Claim izv_(Claim a)
        {
            List<Identifier> izz_ = a?.Identifier;
            Code<FinancialResourceStatusCodes> jza_ = a?.StatusElement;
            CodeableConcept jzb_ = a?.Type;
            CodeableConcept jzc_ = a?.SubType;
            Code<ClaimUseCode> jzd_ = a?.UseElement;
            ResourceReference jze_ = a?.Patient;
            Period jzf_ = a?.BillablePeriod;
            FhirDateTime jzg_ = a?.CreatedElement;
            ResourceReference jzh_ = a?.Enterer;
            ResourceReference jzi_ = a?.Insurer;
            ResourceReference jzj_ = a?.Provider;
            CodeableConcept jzk_ = a?.Priority;
            CodeableConcept jzl_ = a?.FundsReserve;
            List<Claim.RelatedClaimComponent> jzm_ = a?.Related;
            ResourceReference jzn_ = a?.Prescription;
            ResourceReference jzo_ = a?.OriginalPrescription;
            Claim.PayeeComponent jzp_ = a?.Payee;
            ResourceReference jzq_ = a?.Referral;
            ResourceReference jzr_ = a?.Facility;
            List<Claim.CareTeamComponent> jzs_ = a?.CareTeam;
            List<Claim.SupportingInformationComponent> jzt_ = a?.SupportingInfo;
            List<Claim.DiagnosisComponent> jzu_ = a?.Diagnosis;
            List<Claim.ProcedureComponent> jzv_ = a?.Procedure;
            List<Claim.InsuranceComponent> jzw_ = a?.Insurance;
            Claim.AccidentComponent jzx_ = a?.Accident;
            List<Claim.ItemComponent> jzy_ = a?.Item;
            Money jzz_ = a?.Total;
            Claim kza_ = new Claim
            {
                Identifier = new List<Identifier>((IEnumerable<Identifier>)izz_),
                StatusElement = jza_,
                Type = jzb_,
                SubType = jzc_,
                UseElement = jzd_,
                Patient = jze_,
                BillablePeriod = jzf_,
                CreatedElement = jzg_,
                Enterer = jzh_,
                Insurer = jzi_,
                Provider = jzj_,
                Priority = jzk_,
                FundsReserve = jzl_,
                Related = new List<Claim.RelatedClaimComponent>((IEnumerable<Claim.RelatedClaimComponent>)jzm_),
                Prescription = jzn_,
                OriginalPrescription = jzo_,
                Payee = jzp_,
                Referral = jzq_,
                Facility = jzr_,
                CareTeam = new List<Claim.CareTeamComponent>((IEnumerable<Claim.CareTeamComponent>)jzs_),
                SupportingInfo = new List<Claim.SupportingInformationComponent>((IEnumerable<Claim.SupportingInformationComponent>)jzt_),
                Diagnosis = new List<Claim.DiagnosisComponent>((IEnumerable<Claim.DiagnosisComponent>)jzu_),
                Procedure = new List<Claim.ProcedureComponent>((IEnumerable<Claim.ProcedureComponent>)jzv_),
                Insurance = new List<Claim.InsuranceComponent>((IEnumerable<Claim.InsuranceComponent>)jzw_),
                Accident = jzx_,
                Item = new List<Claim.ItemComponent>((IEnumerable<Claim.ItemComponent>)jzy_),
                Total = jzz_,
            };

            return kza_;
        };
        IEnumerable<Claim> izw_ = context.Operators.Select<Claim, Claim>((IEnumerable<Claim>)izu_, izv_);
        IEnumerable<Claim> izx_ = context.Operators.Distinct<Claim>(izw_);
        Claim izy_ = context.Operators.SingletonFrom<Claim>(izx_);

        return izy_;
    }


    [CqlExpressionDefinition("ClaimResponseResource")]
    public ClaimResponse ClaimResponseResource(CqlContext context, ClaimResponse arg)
    {
        ClaimResponse[] kzb_ = [
            arg,
        ];
        ClaimResponse kzc_(ClaimResponse a)
        {
            List<Identifier> kzg_ = a?.Identifier;
            Code<FinancialResourceStatusCodes> kzh_ = a?.StatusElement;
            CodeableConcept kzi_ = a?.Type;
            CodeableConcept kzj_ = a?.SubType;
            Code<ClaimUseCode> kzk_ = a?.UseElement;
            ResourceReference kzl_ = a?.Patient;
            FhirDateTime kzm_ = a?.CreatedElement;
            ResourceReference kzn_ = a?.Insurer;
            ResourceReference kzo_ = a?.Requestor;
            ResourceReference kzp_ = a?.Request;
            Code<ClaimProcessingCodes> kzq_ = a?.OutcomeElement;
            FhirString kzr_ = a?.DispositionElement;
            FhirString kzs_ = a?.PreAuthRefElement;
            Period kzt_ = a?.PreAuthPeriod;
            CodeableConcept kzu_ = a?.PayeeType;
            List<ClaimResponse.ItemComponent> kzv_ = a?.Item;
            List<ClaimResponse.AddedItemComponent> kzw_ = a?.AddItem;
            List<ClaimResponse.AdjudicationComponent> kzx_ = a?.Adjudication;
            List<ClaimResponse.TotalComponent> kzy_ = a?.Total;
            ClaimResponse.PaymentComponent kzz_ = a?.Payment;
            CodeableConcept lza_ = a?.FundsReserve;
            CodeableConcept lzb_ = a?.FormCode;
            Attachment lzc_ = a?.Form;
            List<ClaimResponse.NoteComponent> lzd_ = a?.ProcessNote;
            List<ResourceReference> lze_ = a?.CommunicationRequest;
            List<ClaimResponse.InsuranceComponent> lzf_ = a?.Insurance;
            List<ClaimResponse.ErrorComponent> lzg_ = a?.Error;
            ClaimResponse lzh_ = new ClaimResponse
            {
                Identifier = new List<Identifier>((IEnumerable<Identifier>)kzg_),
                StatusElement = kzh_,
                Type = kzi_,
                SubType = kzj_,
                UseElement = kzk_,
                Patient = kzl_,
                CreatedElement = kzm_,
                Insurer = kzn_,
                Requestor = kzo_,
                Request = kzp_,
                OutcomeElement = kzq_,
                DispositionElement = kzr_,
                PreAuthRefElement = kzs_,
                PreAuthPeriod = kzt_,
                PayeeType = kzu_,
                Item = new List<ClaimResponse.ItemComponent>((IEnumerable<ClaimResponse.ItemComponent>)kzv_),
                AddItem = new List<ClaimResponse.AddedItemComponent>((IEnumerable<ClaimResponse.AddedItemComponent>)kzw_),
                Adjudication = new List<ClaimResponse.AdjudicationComponent>((IEnumerable<ClaimResponse.AdjudicationComponent>)kzx_),
                Total = new List<ClaimResponse.TotalComponent>((IEnumerable<ClaimResponse.TotalComponent>)kzy_),
                Payment = kzz_,
                FundsReserve = lza_,
                FormCode = lzb_,
                Form = lzc_,
                ProcessNote = new List<ClaimResponse.NoteComponent>((IEnumerable<ClaimResponse.NoteComponent>)lzd_),
                CommunicationRequest = new List<ResourceReference>((IEnumerable<ResourceReference>)lze_),
                Insurance = new List<ClaimResponse.InsuranceComponent>((IEnumerable<ClaimResponse.InsuranceComponent>)lzf_),
                Error = new List<ClaimResponse.ErrorComponent>((IEnumerable<ClaimResponse.ErrorComponent>)lzg_),
            };

            return lzh_;
        };
        IEnumerable<ClaimResponse> kzd_ = context.Operators.Select<ClaimResponse, ClaimResponse>((IEnumerable<ClaimResponse>)kzb_, kzc_);
        IEnumerable<ClaimResponse> kze_ = context.Operators.Distinct<ClaimResponse>(kzd_);
        ClaimResponse kzf_ = context.Operators.SingletonFrom<ClaimResponse>(kze_);

        return kzf_;
    }


    [CqlExpressionDefinition("ClinicalImpressionResource")]
    public ClinicalImpression ClinicalImpressionResource(CqlContext context, ClinicalImpression arg)
    {
        ClinicalImpression[] lzi_ = [
            arg,
        ];
        ClinicalImpression lzj_(ClinicalImpression a)
        {
            List<Identifier> lzn_ = a?.Identifier;
            Code<ClinicalImpression.ClinicalImpressionStatus> lzo_ = a?.StatusElement;
            CodeableConcept lzp_ = a?.StatusReason;
            CodeableConcept lzq_ = a?.Code;
            FhirString lzr_ = a?.DescriptionElement;
            ResourceReference lzs_ = a?.Subject;
            ResourceReference lzt_ = a?.Encounter;
            DataType lzu_ = a?.Effective;
            FhirDateTime lzv_ = a?.DateElement;
            ResourceReference lzw_ = a?.Assessor;
            ResourceReference lzx_ = a?.Previous;
            List<ResourceReference> lzy_ = a?.Problem;
            List<ClinicalImpression.InvestigationComponent> lzz_ = a?.Investigation;
            List<FhirUri> mza_ = a?.ProtocolElement;
            FhirString mzb_ = a?.SummaryElement;
            List<ClinicalImpression.FindingComponent> mzc_ = a?.Finding;
            List<CodeableConcept> mzd_ = a?.PrognosisCodeableConcept;
            List<ResourceReference> mze_ = a?.PrognosisReference;
            List<ResourceReference> mzf_ = a?.SupportingInfo;
            List<Annotation> mzg_ = a?.Note;
            ClinicalImpression mzh_ = new ClinicalImpression
            {
                Identifier = new List<Identifier>((IEnumerable<Identifier>)lzn_),
                StatusElement = lzo_,
                StatusReason = lzp_,
                Code = lzq_,
                DescriptionElement = lzr_,
                Subject = lzs_,
                Encounter = lzt_,
                Effective = (DataType)lzu_,
                DateElement = lzv_,
                Assessor = lzw_,
                Previous = lzx_,
                Problem = new List<ResourceReference>((IEnumerable<ResourceReference>)lzy_),
                Investigation = new List<ClinicalImpression.InvestigationComponent>((IEnumerable<ClinicalImpression.InvestigationComponent>)lzz_),
                ProtocolElement = new List<FhirUri>((IEnumerable<FhirUri>)mza_),
                SummaryElement = mzb_,
                Finding = new List<ClinicalImpression.FindingComponent>((IEnumerable<ClinicalImpression.FindingComponent>)mzc_),
                PrognosisCodeableConcept = new List<CodeableConcept>((IEnumerable<CodeableConcept>)mzd_),
                PrognosisReference = new List<ResourceReference>((IEnumerable<ResourceReference>)mze_),
                SupportingInfo = new List<ResourceReference>((IEnumerable<ResourceReference>)mzf_),
                Note = new List<Annotation>((IEnumerable<Annotation>)mzg_),
            };

            return mzh_;
        };
        IEnumerable<ClinicalImpression> lzk_ = context.Operators.Select<ClinicalImpression, ClinicalImpression>((IEnumerable<ClinicalImpression>)lzi_, lzj_);
        IEnumerable<ClinicalImpression> lzl_ = context.Operators.Distinct<ClinicalImpression>(lzk_);
        ClinicalImpression lzm_ = context.Operators.SingletonFrom<ClinicalImpression>(lzl_);

        return lzm_;
    }


    [CqlExpressionDefinition("CodeSystemResource")]
    public CodeSystem CodeSystemResource(CqlContext context, CodeSystem arg)
    {
        CodeSystem[] mzi_ = [
            arg,
        ];
        CodeSystem mzj_(CodeSystem a)
        {
            FhirUri mzn_ = a?.UrlElement;
            List<Identifier> mzo_ = a?.Identifier;
            FhirString mzp_ = a?.VersionElement;
            FhirString mzq_ = a?.NameElement;
            FhirString mzr_ = a?.TitleElement;
            Code<PublicationStatus> mzs_ = a?.StatusElement;
            FhirBoolean mzt_ = a?.ExperimentalElement;
            FhirDateTime mzu_ = a?.DateElement;
            FhirString mzv_ = a?.PublisherElement;
            List<ContactDetail> mzw_ = a?.Contact;
            Markdown mzx_ = a?.DescriptionElement;
            List<UsageContext> mzy_ = a?.UseContext;
            List<CodeableConcept> mzz_ = a?.Jurisdiction;
            Markdown nza_ = a?.PurposeElement;
            Markdown nzb_ = a?.CopyrightElement;
            FhirBoolean nzc_ = a?.CaseSensitiveElement;
            Canonical nzd_ = a?.ValueSetElement;
            Code<CodeSystem.CodeSystemHierarchyMeaning> nze_ = a?.HierarchyMeaningElement;
            FhirBoolean nzf_ = a?.CompositionalElement;
            FhirBoolean nzg_ = a?.VersionNeededElement;
            Code<CodeSystemContentMode> nzh_ = a?.ContentElement;
            Canonical nzi_ = a?.SupplementsElement;
            UnsignedInt nzj_ = a?.CountElement;
            Integer nzk_ = context.Operators.Convert<Integer>(nzj_);
            UnsignedInt nzl_ = context.Operators.Convert<UnsignedInt>(nzk_);
            List<CodeSystem.FilterComponent> nzm_ = a?.Filter;
            List<CodeSystem.PropertyComponent> nzn_ = a?.Property;
            List<CodeSystem.ConceptDefinitionComponent> nzo_ = a?.Concept;
            CodeSystem nzp_ = new CodeSystem
            {
                UrlElement = mzn_,
                Identifier = new List<Identifier>((IEnumerable<Identifier>)mzo_),
                VersionElement = mzp_,
                NameElement = mzq_,
                TitleElement = mzr_,
                StatusElement = mzs_,
                ExperimentalElement = mzt_,
                DateElement = mzu_,
                PublisherElement = mzv_,
                Contact = new List<ContactDetail>((IEnumerable<ContactDetail>)mzw_),
                DescriptionElement = mzx_,
                UseContext = new List<UsageContext>((IEnumerable<UsageContext>)mzy_),
                Jurisdiction = new List<CodeableConcept>((IEnumerable<CodeableConcept>)mzz_),
                PurposeElement = nza_,
                CopyrightElement = nzb_,
                CaseSensitiveElement = nzc_,
                ValueSetElement = nzd_,
                HierarchyMeaningElement = nze_,
                CompositionalElement = nzf_,
                VersionNeededElement = nzg_,
                ContentElement = nzh_,
                SupplementsElement = nzi_,
                CountElement = nzl_,
                Filter = new List<CodeSystem.FilterComponent>((IEnumerable<CodeSystem.FilterComponent>)nzm_),
                Property = new List<CodeSystem.PropertyComponent>((IEnumerable<CodeSystem.PropertyComponent>)nzn_),
                Concept = new List<CodeSystem.ConceptDefinitionComponent>((IEnumerable<CodeSystem.ConceptDefinitionComponent>)nzo_),
            };

            return nzp_;
        };
        IEnumerable<CodeSystem> mzk_ = context.Operators.Select<CodeSystem, CodeSystem>((IEnumerable<CodeSystem>)mzi_, mzj_);
        IEnumerable<CodeSystem> mzl_ = context.Operators.Distinct<CodeSystem>(mzk_);
        CodeSystem mzm_ = context.Operators.SingletonFrom<CodeSystem>(mzl_);

        return mzm_;
    }


    [CqlExpressionDefinition("CommunicationResource")]
    public Communication CommunicationResource(CqlContext context, Communication arg)
    {
        Communication[] nzq_ = [
            arg,
        ];
        Communication nzr_(Communication a)
        {
            List<Identifier> nzv_ = a?.Identifier;
            List<Canonical> nzw_ = a?.InstantiatesCanonicalElement;
            List<FhirUri> nzx_ = a?.InstantiatesUriElement;
            List<ResourceReference> nzy_ = a?.BasedOn;
            List<ResourceReference> nzz_ = a?.PartOf;
            List<ResourceReference> oza_ = a?.InResponseTo;
            Code<EventStatus> ozb_ = a?.StatusElement;
            CodeableConcept ozc_ = a?.StatusReason;
            List<CodeableConcept> ozd_ = a?.Category;
            Code<RequestPriority> oze_ = a?.PriorityElement;
            List<CodeableConcept> ozf_ = a?.Medium;
            ResourceReference ozg_ = a?.Subject;
            CodeableConcept ozh_ = a?.Topic;
            List<ResourceReference> ozi_ = a?.About;
            ResourceReference ozj_ = a?.Encounter;
            FhirDateTime ozk_ = a?.SentElement;
            FhirDateTime ozl_ = a?.ReceivedElement;
            List<ResourceReference> ozm_ = a?.Recipient;
            ResourceReference ozn_ = a?.Sender;
            List<CodeableConcept> ozo_ = a?.ReasonCode;
            List<ResourceReference> ozp_ = a?.ReasonReference;
            List<Communication.PayloadComponent> ozq_ = a?.Payload;
            List<Annotation> ozr_ = a?.Note;
            Communication ozs_ = new Communication
            {
                Identifier = new List<Identifier>((IEnumerable<Identifier>)nzv_),
                InstantiatesCanonicalElement = new List<Canonical>((IEnumerable<Canonical>)nzw_),
                InstantiatesUriElement = new List<FhirUri>((IEnumerable<FhirUri>)nzx_),
                BasedOn = new List<ResourceReference>((IEnumerable<ResourceReference>)nzy_),
                PartOf = new List<ResourceReference>((IEnumerable<ResourceReference>)nzz_),
                InResponseTo = new List<ResourceReference>((IEnumerable<ResourceReference>)oza_),
                StatusElement = ozb_,
                StatusReason = ozc_,
                Category = new List<CodeableConcept>((IEnumerable<CodeableConcept>)ozd_),
                PriorityElement = oze_,
                Medium = new List<CodeableConcept>((IEnumerable<CodeableConcept>)ozf_),
                Subject = ozg_,
                Topic = ozh_,
                About = new List<ResourceReference>((IEnumerable<ResourceReference>)ozi_),
                Encounter = ozj_,
                SentElement = ozk_,
                ReceivedElement = ozl_,
                Recipient = new List<ResourceReference>((IEnumerable<ResourceReference>)ozm_),
                Sender = ozn_,
                ReasonCode = new List<CodeableConcept>((IEnumerable<CodeableConcept>)ozo_),
                ReasonReference = new List<ResourceReference>((IEnumerable<ResourceReference>)ozp_),
                Payload = new List<Communication.PayloadComponent>((IEnumerable<Communication.PayloadComponent>)ozq_),
                Note = new List<Annotation>((IEnumerable<Annotation>)ozr_),
            };

            return ozs_;
        };
        IEnumerable<Communication> nzs_ = context.Operators.Select<Communication, Communication>((IEnumerable<Communication>)nzq_, nzr_);
        IEnumerable<Communication> nzt_ = context.Operators.Distinct<Communication>(nzs_);
        Communication nzu_ = context.Operators.SingletonFrom<Communication>(nzt_);

        return nzu_;
    }


    [CqlExpressionDefinition("CommunicationRequestResource")]
    public CommunicationRequest CommunicationRequestResource(CqlContext context, CommunicationRequest arg)
    {
        CommunicationRequest[] ozt_ = [
            arg,
        ];
        CommunicationRequest ozu_(CommunicationRequest a)
        {
            List<Identifier> ozy_ = a?.Identifier;
            List<ResourceReference> ozz_ = a?.BasedOn;
            List<ResourceReference> pza_ = a?.Replaces;
            Identifier pzb_ = a?.GroupIdentifier;
            Code<RequestStatus> pzc_ = a?.StatusElement;
            CodeableConcept pzd_ = a?.StatusReason;
            List<CodeableConcept> pze_ = a?.Category;
            Code<RequestPriority> pzf_ = a?.PriorityElement;
            FhirBoolean pzg_ = a?.DoNotPerformElement;
            List<CodeableConcept> pzh_ = a?.Medium;
            ResourceReference pzi_ = a?.Subject;
            List<ResourceReference> pzj_ = a?.About;
            ResourceReference pzk_ = a?.Encounter;
            List<CommunicationRequest.PayloadComponent> pzl_ = a?.Payload;
            DataType pzm_ = a?.Occurrence;
            FhirDateTime pzn_ = a?.AuthoredOnElement;
            ResourceReference pzo_ = a?.Requester;
            List<ResourceReference> pzp_ = a?.Recipient;
            ResourceReference pzq_ = a?.Sender;
            List<CodeableConcept> pzr_ = a?.ReasonCode;
            List<ResourceReference> pzs_ = a?.ReasonReference;
            List<Annotation> pzt_ = a?.Note;
            CommunicationRequest pzu_ = new CommunicationRequest
            {
                Identifier = new List<Identifier>((IEnumerable<Identifier>)ozy_),
                BasedOn = new List<ResourceReference>((IEnumerable<ResourceReference>)ozz_),
                Replaces = new List<ResourceReference>((IEnumerable<ResourceReference>)pza_),
                GroupIdentifier = pzb_,
                StatusElement = pzc_,
                StatusReason = pzd_,
                Category = new List<CodeableConcept>((IEnumerable<CodeableConcept>)pze_),
                PriorityElement = pzf_,
                DoNotPerformElement = pzg_,
                Medium = new List<CodeableConcept>((IEnumerable<CodeableConcept>)pzh_),
                Subject = pzi_,
                About = new List<ResourceReference>((IEnumerable<ResourceReference>)pzj_),
                Encounter = pzk_,
                Payload = new List<CommunicationRequest.PayloadComponent>((IEnumerable<CommunicationRequest.PayloadComponent>)pzl_),
                Occurrence = (DataType)pzm_,
                AuthoredOnElement = pzn_,
                Requester = pzo_,
                Recipient = new List<ResourceReference>((IEnumerable<ResourceReference>)pzp_),
                Sender = pzq_,
                ReasonCode = new List<CodeableConcept>((IEnumerable<CodeableConcept>)pzr_),
                ReasonReference = new List<ResourceReference>((IEnumerable<ResourceReference>)pzs_),
                Note = new List<Annotation>((IEnumerable<Annotation>)pzt_),
            };

            return pzu_;
        };
        IEnumerable<CommunicationRequest> ozv_ = context.Operators.Select<CommunicationRequest, CommunicationRequest>((IEnumerable<CommunicationRequest>)ozt_, ozu_);
        IEnumerable<CommunicationRequest> ozw_ = context.Operators.Distinct<CommunicationRequest>(ozv_);
        CommunicationRequest ozx_ = context.Operators.SingletonFrom<CommunicationRequest>(ozw_);

        return ozx_;
    }


    [CqlExpressionDefinition("CompositionResource")]
    public Composition CompositionResource(CqlContext context, Composition arg)
    {
        Composition[] pzv_ = [
            arg,
        ];
        Composition pzw_(Composition a)
        {
            Identifier qza_ = a?.Identifier;
            Code<CompositionStatus> qzb_ = a?.StatusElement;
            CodeableConcept qzc_ = a?.Type;
            List<CodeableConcept> qzd_ = a?.Category;
            ResourceReference qze_ = a?.Subject;
            ResourceReference qzf_ = a?.Encounter;
            FhirDateTime qzg_ = a?.DateElement;
            List<ResourceReference> qzh_ = a?.Author;
            FhirString qzi_ = a?.TitleElement;
            Code<Composition.V3ConfidentialityClassification> qzj_ = a?.ConfidentialityElement;
            List<Composition.AttesterComponent> qzk_ = a?.Attester;
            ResourceReference qzl_ = a?.Custodian;
            List<Composition.RelatesToComponent> qzm_ = a?.RelatesTo;
            List<Composition.EventComponent> qzn_ = a?.Event;
            List<Composition.SectionComponent> qzo_ = a?.Section;
            Composition qzp_ = new Composition
            {
                Identifier = qza_,
                StatusElement = qzb_,
                Type = qzc_,
                Category = new List<CodeableConcept>((IEnumerable<CodeableConcept>)qzd_),
                Subject = qze_,
                Encounter = qzf_,
                DateElement = qzg_,
                Author = new List<ResourceReference>((IEnumerable<ResourceReference>)qzh_),
                TitleElement = qzi_,
                ConfidentialityElement = qzj_,
                Attester = new List<Composition.AttesterComponent>((IEnumerable<Composition.AttesterComponent>)qzk_),
                Custodian = qzl_,
                RelatesTo = new List<Composition.RelatesToComponent>((IEnumerable<Composition.RelatesToComponent>)qzm_),
                Event = new List<Composition.EventComponent>((IEnumerable<Composition.EventComponent>)qzn_),
                Section = new List<Composition.SectionComponent>((IEnumerable<Composition.SectionComponent>)qzo_),
            };

            return qzp_;
        };
        IEnumerable<Composition> pzx_ = context.Operators.Select<Composition, Composition>((IEnumerable<Composition>)pzv_, pzw_);
        IEnumerable<Composition> pzy_ = context.Operators.Distinct<Composition>(pzx_);
        Composition pzz_ = context.Operators.SingletonFrom<Composition>(pzy_);

        return pzz_;
    }


    [CqlExpressionDefinition("ConceptMapResource")]
    public ConceptMap ConceptMapResource(CqlContext context, ConceptMap arg)
    {
        ConceptMap[] qzq_ = [
            arg,
        ];
        ConceptMap qzr_(ConceptMap a)
        {
            FhirUri qzv_ = a?.UrlElement;
            Identifier qzw_ = a?.Identifier;
            FhirString qzx_ = a?.VersionElement;
            FhirString qzy_ = a?.NameElement;
            FhirString qzz_ = a?.TitleElement;
            Code<PublicationStatus> rza_ = a?.StatusElement;
            FhirBoolean rzb_ = a?.ExperimentalElement;
            FhirDateTime rzc_ = a?.DateElement;
            FhirString rzd_ = a?.PublisherElement;
            List<ContactDetail> rze_ = a?.Contact;
            Markdown rzf_ = a?.DescriptionElement;
            List<UsageContext> rzg_ = a?.UseContext;
            List<CodeableConcept> rzh_ = a?.Jurisdiction;
            Markdown rzi_ = a?.PurposeElement;
            Markdown rzj_ = a?.CopyrightElement;
            DataType rzk_ = a?.Source;
            DataType rzl_ = a?.Target;
            List<ConceptMap.GroupComponent> rzm_ = a?.Group;
            ConceptMap rzn_ = new ConceptMap
            {
                UrlElement = qzv_,
                Identifier = qzw_,
                VersionElement = qzx_,
                NameElement = qzy_,
                TitleElement = qzz_,
                StatusElement = rza_,
                ExperimentalElement = rzb_,
                DateElement = rzc_,
                PublisherElement = rzd_,
                Contact = new List<ContactDetail>((IEnumerable<ContactDetail>)rze_),
                DescriptionElement = rzf_,
                UseContext = new List<UsageContext>((IEnumerable<UsageContext>)rzg_),
                Jurisdiction = new List<CodeableConcept>((IEnumerable<CodeableConcept>)rzh_),
                PurposeElement = rzi_,
                CopyrightElement = rzj_,
                Source = (DataType)rzk_,
                Target = (DataType)rzl_,
                Group = new List<ConceptMap.GroupComponent>((IEnumerable<ConceptMap.GroupComponent>)rzm_),
            };

            return rzn_;
        };
        IEnumerable<ConceptMap> qzs_ = context.Operators.Select<ConceptMap, ConceptMap>((IEnumerable<ConceptMap>)qzq_, qzr_);
        IEnumerable<ConceptMap> qzt_ = context.Operators.Distinct<ConceptMap>(qzs_);
        ConceptMap qzu_ = context.Operators.SingletonFrom<ConceptMap>(qzt_);

        return qzu_;
    }


    [CqlExpressionDefinition("ConditionResource")]
    public Condition ConditionResource(CqlContext context, Condition arg)
    {
        Condition[] rzo_ = [
            arg,
        ];
        Condition rzp_(Condition a)
        {
            List<Identifier> rzt_ = a?.Identifier;
            CodeableConcept rzu_ = a?.ClinicalStatus;
            CodeableConcept rzv_ = a?.VerificationStatus;
            List<CodeableConcept> rzw_ = a?.Category;
            CodeableConcept rzx_ = a?.Severity;
            CodeableConcept rzy_ = a?.Code;
            List<CodeableConcept> rzz_ = a?.BodySite;
            ResourceReference sza_ = a?.Subject;
            ResourceReference szb_ = a?.Encounter;
            DataType szc_ = a?.Onset;
            DataType szd_ = a?.Abatement;
            FhirDateTime sze_ = a?.RecordedDateElement;
            ResourceReference szf_ = a?.Recorder;
            ResourceReference szg_ = a?.Asserter;
            List<Condition.StageComponent> szh_ = a?.Stage;
            List<Condition.EvidenceComponent> szi_ = a?.Evidence;
            List<Annotation> szj_ = a?.Note;
            Condition szk_ = new Condition
            {
                Identifier = new List<Identifier>((IEnumerable<Identifier>)rzt_),
                ClinicalStatus = rzu_,
                VerificationStatus = rzv_,
                Category = new List<CodeableConcept>((IEnumerable<CodeableConcept>)rzw_),
                Severity = rzx_,
                Code = rzy_,
                BodySite = new List<CodeableConcept>((IEnumerable<CodeableConcept>)rzz_),
                Subject = sza_,
                Encounter = szb_,
                Onset = (DataType)szc_,
                Abatement = (DataType)szd_,
                RecordedDateElement = sze_,
                Recorder = szf_,
                Asserter = szg_,
                Stage = new List<Condition.StageComponent>((IEnumerable<Condition.StageComponent>)szh_),
                Evidence = new List<Condition.EvidenceComponent>((IEnumerable<Condition.EvidenceComponent>)szi_),
                Note = new List<Annotation>((IEnumerable<Annotation>)szj_),
            };

            return szk_;
        };
        IEnumerable<Condition> rzq_ = context.Operators.Select<Condition, Condition>((IEnumerable<Condition>)rzo_, rzp_);
        IEnumerable<Condition> rzr_ = context.Operators.Distinct<Condition>(rzq_);
        Condition rzs_ = context.Operators.SingletonFrom<Condition>(rzr_);

        return rzs_;
    }


    [CqlExpressionDefinition("ConsentResource")]
    public Consent ConsentResource(CqlContext context, Consent arg)
    {
        Consent[] szl_ = [
            arg,
        ];
        Consent szm_(Consent a)
        {
            List<Identifier> szq_ = a?.Identifier;
            Code<Consent.ConsentState> szr_ = a?.StatusElement;
            CodeableConcept szs_ = a?.Scope;
            List<CodeableConcept> szt_ = a?.Category;
            ResourceReference szu_ = a?.Patient;
            FhirDateTime szv_ = a?.DateTimeElement;
            List<ResourceReference> szw_ = a?.Performer;
            List<ResourceReference> szx_ = a?.Organization;
            DataType szy_ = a?.Source;
            List<Consent.PolicyComponent> szz_ = a?.Policy;
            CodeableConcept tza_ = a?.PolicyRule;
            List<Consent.VerificationComponent> tzb_ = a?.Verification;
            Consent.provisionComponent tzc_ = a?.Provision;
            Consent tzd_ = new Consent
            {
                Identifier = new List<Identifier>((IEnumerable<Identifier>)szq_),
                StatusElement = szr_,
                Scope = szs_,
                Category = new List<CodeableConcept>((IEnumerable<CodeableConcept>)szt_),
                Patient = szu_,
                DateTimeElement = szv_,
                Performer = new List<ResourceReference>((IEnumerable<ResourceReference>)szw_),
                Organization = new List<ResourceReference>((IEnumerable<ResourceReference>)szx_),
                Source = (DataType)szy_,
                Policy = new List<Consent.PolicyComponent>((IEnumerable<Consent.PolicyComponent>)szz_),
                PolicyRule = tza_,
                Verification = new List<Consent.VerificationComponent>((IEnumerable<Consent.VerificationComponent>)tzb_),
                Provision = tzc_,
            };

            return tzd_;
        };
        IEnumerable<Consent> szn_ = context.Operators.Select<Consent, Consent>((IEnumerable<Consent>)szl_, szm_);
        IEnumerable<Consent> szo_ = context.Operators.Distinct<Consent>(szn_);
        Consent szp_ = context.Operators.SingletonFrom<Consent>(szo_);

        return szp_;
    }


    [CqlExpressionDefinition("ContractResource")]
    public Contract ContractResource(CqlContext context, Contract arg)
    {
        Contract[] tze_ = [
            arg,
        ];
        Contract tzf_(Contract a)
        {
            List<Identifier> tzj_ = a?.Identifier;
            FhirUri tzk_ = a?.UrlElement;
            FhirString tzl_ = a?.VersionElement;
            Code<Contract.ContractResourceStatusCodes> tzm_ = a?.StatusElement;
            CodeableConcept tzn_ = a?.LegalState;
            ResourceReference tzo_ = a?.InstantiatesCanonical;
            FhirUri tzp_ = a?.InstantiatesUriElement;
            CodeableConcept tzq_ = a?.ContentDerivative;
            FhirDateTime tzr_ = a?.IssuedElement;
            Period tzs_ = a?.Applies;
            CodeableConcept tzt_ = a?.ExpirationType;
            List<ResourceReference> tzu_ = a?.Subject;
            List<ResourceReference> tzv_ = a?.Authority;
            List<ResourceReference> tzw_ = a?.Domain;
            List<ResourceReference> tzx_ = a?.Site;
            FhirString tzy_ = a?.NameElement;
            FhirString tzz_ = a?.TitleElement;
            FhirString uza_ = a?.SubtitleElement;
            List<FhirString> uzb_ = a?.AliasElement;
            ResourceReference uzc_ = a?.Author;
            CodeableConcept uzd_ = a?.Scope;
            DataType uze_ = a?.Topic;
            CodeableConcept uzf_ = a?.Type;
            List<CodeableConcept> uzg_ = a?.SubType;
            Contract.ContentDefinitionComponent uzh_ = a?.ContentDefinition;
            List<Contract.TermComponent> uzi_ = a?.Term;
            List<ResourceReference> uzj_ = a?.SupportingInfo;
            List<ResourceReference> uzk_ = a?.RelevantHistory;
            List<Contract.SignatoryComponent> uzl_ = a?.Signer;
            List<Contract.FriendlyLanguageComponent> uzm_ = a?.Friendly;
            List<Contract.LegalLanguageComponent> uzn_ = a?.Legal;
            List<Contract.ComputableLanguageComponent> uzo_ = a?.Rule;
            DataType uzp_ = a?.LegallyBinding;
            Contract uzq_ = new Contract
            {
                Identifier = new List<Identifier>((IEnumerable<Identifier>)tzj_),
                UrlElement = tzk_,
                VersionElement = tzl_,
                StatusElement = tzm_,
                LegalState = tzn_,
                InstantiatesCanonical = tzo_,
                InstantiatesUriElement = tzp_,
                ContentDerivative = tzq_,
                IssuedElement = tzr_,
                Applies = tzs_,
                ExpirationType = tzt_,
                Subject = new List<ResourceReference>((IEnumerable<ResourceReference>)tzu_),
                Authority = new List<ResourceReference>((IEnumerable<ResourceReference>)tzv_),
                Domain = new List<ResourceReference>((IEnumerable<ResourceReference>)tzw_),
                Site = new List<ResourceReference>((IEnumerable<ResourceReference>)tzx_),
                NameElement = tzy_,
                TitleElement = tzz_,
                SubtitleElement = uza_,
                AliasElement = new List<FhirString>((IEnumerable<FhirString>)uzb_),
                Author = uzc_,
                Scope = uzd_,
                Topic = (DataType)uze_,
                Type = uzf_,
                SubType = new List<CodeableConcept>((IEnumerable<CodeableConcept>)uzg_),
                ContentDefinition = uzh_,
                Term = new List<Contract.TermComponent>((IEnumerable<Contract.TermComponent>)uzi_),
                SupportingInfo = new List<ResourceReference>((IEnumerable<ResourceReference>)uzj_),
                RelevantHistory = new List<ResourceReference>((IEnumerable<ResourceReference>)uzk_),
                Signer = new List<Contract.SignatoryComponent>((IEnumerable<Contract.SignatoryComponent>)uzl_),
                Friendly = new List<Contract.FriendlyLanguageComponent>((IEnumerable<Contract.FriendlyLanguageComponent>)uzm_),
                Legal = new List<Contract.LegalLanguageComponent>((IEnumerable<Contract.LegalLanguageComponent>)uzn_),
                Rule = new List<Contract.ComputableLanguageComponent>((IEnumerable<Contract.ComputableLanguageComponent>)uzo_),
                LegallyBinding = (DataType)uzp_,
            };

            return uzq_;
        };
        IEnumerable<Contract> tzg_ = context.Operators.Select<Contract, Contract>((IEnumerable<Contract>)tze_, tzf_);
        IEnumerable<Contract> tzh_ = context.Operators.Distinct<Contract>(tzg_);
        Contract tzi_ = context.Operators.SingletonFrom<Contract>(tzh_);

        return tzi_;
    }


    [CqlExpressionDefinition("CoverageResource")]
    public Coverage CoverageResource(CqlContext context, Coverage arg)
    {
        Coverage[] uzr_ = [
            arg,
        ];
        Coverage uzs_(Coverage a)
        {
            List<Identifier> uzw_ = a?.Identifier;
            Code<FinancialResourceStatusCodes> uzx_ = a?.StatusElement;
            CodeableConcept uzy_ = a?.Type;
            ResourceReference uzz_ = a?.PolicyHolder;
            ResourceReference vza_ = a?.Subscriber;
            FhirString vzb_ = a?.SubscriberIdElement;
            ResourceReference vzc_ = a?.Beneficiary;
            FhirString vzd_ = a?.DependentElement;
            CodeableConcept vze_ = a?.Relationship;
            Period vzf_ = a?.Period;
            List<ResourceReference> vzg_ = a?.Payor;
            List<Coverage.ClassComponent> vzh_ = a?.Class;
            PositiveInt vzi_ = a?.OrderElement;
            Integer vzj_ = context.Operators.Convert<Integer>(vzi_);
            PositiveInt vzk_ = context.Operators.Convert<PositiveInt>(vzj_);
            FhirString vzl_ = a?.NetworkElement;
            List<Coverage.CostToBeneficiaryComponent> vzm_ = a?.CostToBeneficiary;
            FhirBoolean vzn_ = a?.SubrogationElement;
            List<ResourceReference> vzo_ = a?.Contract;
            Coverage vzp_ = new Coverage
            {
                Identifier = new List<Identifier>((IEnumerable<Identifier>)uzw_),
                StatusElement = uzx_,
                Type = uzy_,
                PolicyHolder = uzz_,
                Subscriber = vza_,
                SubscriberIdElement = vzb_,
                Beneficiary = vzc_,
                DependentElement = vzd_,
                Relationship = vze_,
                Period = vzf_,
                Payor = new List<ResourceReference>((IEnumerable<ResourceReference>)vzg_),
                Class = new List<Coverage.ClassComponent>((IEnumerable<Coverage.ClassComponent>)vzh_),
                OrderElement = vzk_,
                NetworkElement = vzl_,
                CostToBeneficiary = new List<Coverage.CostToBeneficiaryComponent>((IEnumerable<Coverage.CostToBeneficiaryComponent>)vzm_),
                SubrogationElement = vzn_,
                Contract = new List<ResourceReference>((IEnumerable<ResourceReference>)vzo_),
            };

            return vzp_;
        };
        IEnumerable<Coverage> uzt_ = context.Operators.Select<Coverage, Coverage>((IEnumerable<Coverage>)uzr_, uzs_);
        IEnumerable<Coverage> uzu_ = context.Operators.Distinct<Coverage>(uzt_);
        Coverage uzv_ = context.Operators.SingletonFrom<Coverage>(uzu_);

        return uzv_;
    }


    [CqlExpressionDefinition("CoverageEligibilityRequestResource")]
    public CoverageEligibilityRequest CoverageEligibilityRequestResource(CqlContext context, CoverageEligibilityRequest arg)
    {
        CoverageEligibilityRequest[] vzq_ = [
            arg,
        ];
        CoverageEligibilityRequest vzr_(CoverageEligibilityRequest a)
        {
            List<Identifier> vzv_ = a?.Identifier;
            Code<FinancialResourceStatusCodes> vzw_ = a?.StatusElement;
            CodeableConcept vzx_ = a?.Priority;
            List<Code<CoverageEligibilityRequest.EligibilityRequestPurpose>> vzy_ = a?.PurposeElement;
            ResourceReference vzz_ = a?.Patient;
            DataType wza_ = a?.Serviced;
            FhirDateTime wzb_ = a?.CreatedElement;
            ResourceReference wzc_ = a?.Enterer;
            ResourceReference wzd_ = a?.Provider;
            ResourceReference wze_ = a?.Insurer;
            ResourceReference wzf_ = a?.Facility;
            List<CoverageEligibilityRequest.SupportingInformationComponent> wzg_ = a?.SupportingInfo;
            List<CoverageEligibilityRequest.InsuranceComponent> wzh_ = a?.Insurance;
            List<CoverageEligibilityRequest.DetailsComponent> wzi_ = a?.Item;
            CoverageEligibilityRequest wzj_ = new CoverageEligibilityRequest
            {
                Identifier = new List<Identifier>((IEnumerable<Identifier>)vzv_),
                StatusElement = vzw_,
                Priority = vzx_,
                PurposeElement = new List<Code<CoverageEligibilityRequest.EligibilityRequestPurpose>>((IEnumerable<Code<CoverageEligibilityRequest.EligibilityRequestPurpose>>)vzy_),
                Patient = vzz_,
                Serviced = (DataType)wza_,
                CreatedElement = wzb_,
                Enterer = wzc_,
                Provider = wzd_,
                Insurer = wze_,
                Facility = wzf_,
                SupportingInfo = new List<CoverageEligibilityRequest.SupportingInformationComponent>((IEnumerable<CoverageEligibilityRequest.SupportingInformationComponent>)wzg_),
                Insurance = new List<CoverageEligibilityRequest.InsuranceComponent>((IEnumerable<CoverageEligibilityRequest.InsuranceComponent>)wzh_),
                Item = new List<CoverageEligibilityRequest.DetailsComponent>((IEnumerable<CoverageEligibilityRequest.DetailsComponent>)wzi_),
            };

            return wzj_;
        };
        IEnumerable<CoverageEligibilityRequest> vzs_ = context.Operators.Select<CoverageEligibilityRequest, CoverageEligibilityRequest>((IEnumerable<CoverageEligibilityRequest>)vzq_, vzr_);
        IEnumerable<CoverageEligibilityRequest> vzt_ = context.Operators.Distinct<CoverageEligibilityRequest>(vzs_);
        CoverageEligibilityRequest vzu_ = context.Operators.SingletonFrom<CoverageEligibilityRequest>(vzt_);

        return vzu_;
    }


    [CqlExpressionDefinition("CoverageEligibilityResponseResource")]
    public CoverageEligibilityResponse CoverageEligibilityResponseResource(CqlContext context, CoverageEligibilityResponse arg)
    {
        CoverageEligibilityResponse[] wzk_ = [
            arg,
        ];
        CoverageEligibilityResponse wzl_(CoverageEligibilityResponse a)
        {
            List<Identifier> wzp_ = a?.Identifier;
            Code<FinancialResourceStatusCodes> wzq_ = a?.StatusElement;
            List<Code<CoverageEligibilityResponse.EligibilityResponsePurpose>> wzr_ = a?.PurposeElement;
            ResourceReference wzs_ = a?.Patient;
            DataType wzt_ = a?.Serviced;
            FhirDateTime wzu_ = a?.CreatedElement;
            ResourceReference wzv_ = a?.Requestor;
            ResourceReference wzw_ = a?.Request;
            Code<ClaimProcessingCodes> wzx_ = a?.OutcomeElement;
            FhirString wzy_ = a?.DispositionElement;
            ResourceReference wzz_ = a?.Insurer;
            List<CoverageEligibilityResponse.InsuranceComponent> xza_ = a?.Insurance;
            FhirString xzb_ = a?.PreAuthRefElement;
            CodeableConcept xzc_ = a?.Form;
            List<CoverageEligibilityResponse.ErrorsComponent> xzd_ = a?.Error;
            CoverageEligibilityResponse xze_ = new CoverageEligibilityResponse
            {
                Identifier = new List<Identifier>((IEnumerable<Identifier>)wzp_),
                StatusElement = wzq_,
                PurposeElement = new List<Code<CoverageEligibilityResponse.EligibilityResponsePurpose>>((IEnumerable<Code<CoverageEligibilityResponse.EligibilityResponsePurpose>>)wzr_),
                Patient = wzs_,
                Serviced = (DataType)wzt_,
                CreatedElement = wzu_,
                Requestor = wzv_,
                Request = wzw_,
                OutcomeElement = wzx_,
                DispositionElement = wzy_,
                Insurer = wzz_,
                Insurance = new List<CoverageEligibilityResponse.InsuranceComponent>((IEnumerable<CoverageEligibilityResponse.InsuranceComponent>)xza_),
                PreAuthRefElement = xzb_,
                Form = xzc_,
                Error = new List<CoverageEligibilityResponse.ErrorsComponent>((IEnumerable<CoverageEligibilityResponse.ErrorsComponent>)xzd_),
            };

            return xze_;
        };
        IEnumerable<CoverageEligibilityResponse> wzm_ = context.Operators.Select<CoverageEligibilityResponse, CoverageEligibilityResponse>((IEnumerable<CoverageEligibilityResponse>)wzk_, wzl_);
        IEnumerable<CoverageEligibilityResponse> wzn_ = context.Operators.Distinct<CoverageEligibilityResponse>(wzm_);
        CoverageEligibilityResponse wzo_ = context.Operators.SingletonFrom<CoverageEligibilityResponse>(wzn_);

        return wzo_;
    }


    [CqlExpressionDefinition("DetectedIssueResource")]
    public DetectedIssue DetectedIssueResource(CqlContext context, DetectedIssue arg)
    {
        DetectedIssue[] xzf_ = [
            arg,
        ];
        DetectedIssue xzg_(DetectedIssue a)
        {
            List<Identifier> xzk_ = a?.Identifier;
            Code<ObservationStatus> xzl_ = a?.StatusElement;
            CodeableConcept xzm_ = a?.Code;
            Code<DetectedIssue.DetectedIssueSeverity> xzn_ = a?.SeverityElement;
            ResourceReference xzo_ = a?.Patient;
            DataType xzp_ = a?.Identified;
            ResourceReference xzq_ = a?.Author;
            List<ResourceReference> xzr_ = a?.Implicated;
            List<DetectedIssue.EvidenceComponent> xzs_ = a?.Evidence;
            FhirString xzt_ = a?.DetailElement;
            FhirUri xzu_ = a?.ReferenceElement;
            List<DetectedIssue.MitigationComponent> xzv_ = a?.Mitigation;
            DetectedIssue xzw_ = new DetectedIssue
            {
                Identifier = new List<Identifier>((IEnumerable<Identifier>)xzk_),
                StatusElement = xzl_,
                Code = xzm_,
                SeverityElement = xzn_,
                Patient = xzo_,
                Identified = (DataType)xzp_,
                Author = xzq_,
                Implicated = new List<ResourceReference>((IEnumerable<ResourceReference>)xzr_),
                Evidence = new List<DetectedIssue.EvidenceComponent>((IEnumerable<DetectedIssue.EvidenceComponent>)xzs_),
                DetailElement = xzt_,
                ReferenceElement = xzu_,
                Mitigation = new List<DetectedIssue.MitigationComponent>((IEnumerable<DetectedIssue.MitigationComponent>)xzv_),
            };

            return xzw_;
        };
        IEnumerable<DetectedIssue> xzh_ = context.Operators.Select<DetectedIssue, DetectedIssue>((IEnumerable<DetectedIssue>)xzf_, xzg_);
        IEnumerable<DetectedIssue> xzi_ = context.Operators.Distinct<DetectedIssue>(xzh_);
        DetectedIssue xzj_ = context.Operators.SingletonFrom<DetectedIssue>(xzi_);

        return xzj_;
    }


    [CqlExpressionDefinition("DeviceResource")]
    public Device DeviceResource(CqlContext context, Device arg)
    {
        Device[] xzx_ = [
            arg,
        ];
        Device xzy_(Device a)
        {
            List<Identifier> yzc_ = a?.Identifier;
            ResourceReference yzd_ = a?.Definition;
            List<Device.UdiCarrierComponent> yze_ = a?.UdiCarrier;
            Code<Device.FHIRDeviceStatus> yzf_ = a?.StatusElement;
            List<CodeableConcept> yzg_ = a?.StatusReason;
            FhirString yzh_ = a?.DistinctIdentifierElement;
            FhirString yzi_ = a?.ManufacturerElement;
            FhirDateTime yzj_ = a?.ManufactureDateElement;
            FhirDateTime yzk_ = a?.ExpirationDateElement;
            FhirString yzl_ = a?.LotNumberElement;
            FhirString yzm_ = a?.SerialNumberElement;
            List<Device.DeviceNameComponent> yzn_ = a?.DeviceName;
            FhirString yzo_ = a?.ModelNumberElement;
            FhirString yzp_ = a?.PartNumberElement;
            CodeableConcept yzq_ = a?.Type;
            List<Device.SpecializationComponent> yzr_ = a?.Specialization;
            List<Device.VersionComponent> yzs_ = a?.Version;
            List<Device.PropertyComponent> yzt_ = a?.Property;
            ResourceReference yzu_ = a?.Patient;
            ResourceReference yzv_ = a?.Owner;
            List<ContactPoint> yzw_ = a?.Contact;
            ResourceReference yzx_ = a?.Location;
            FhirUri yzy_ = a?.UrlElement;
            List<Annotation> yzz_ = a?.Note;
            List<CodeableConcept> zza_ = a?.Safety;
            ResourceReference zzb_ = a?.Parent;
            Device zzc_ = new Device
            {
                Identifier = new List<Identifier>((IEnumerable<Identifier>)yzc_),
                Definition = yzd_,
                UdiCarrier = new List<Device.UdiCarrierComponent>((IEnumerable<Device.UdiCarrierComponent>)yze_),
                StatusElement = yzf_,
                StatusReason = new List<CodeableConcept>((IEnumerable<CodeableConcept>)yzg_),
                DistinctIdentifierElement = yzh_,
                ManufacturerElement = yzi_,
                ManufactureDateElement = yzj_,
                ExpirationDateElement = yzk_,
                LotNumberElement = yzl_,
                SerialNumberElement = yzm_,
                DeviceName = new List<Device.DeviceNameComponent>((IEnumerable<Device.DeviceNameComponent>)yzn_),
                ModelNumberElement = yzo_,
                PartNumberElement = yzp_,
                Type = yzq_,
                Specialization = new List<Device.SpecializationComponent>((IEnumerable<Device.SpecializationComponent>)yzr_),
                Version = new List<Device.VersionComponent>((IEnumerable<Device.VersionComponent>)yzs_),
                Property = new List<Device.PropertyComponent>((IEnumerable<Device.PropertyComponent>)yzt_),
                Patient = yzu_,
                Owner = yzv_,
                Contact = new List<ContactPoint>((IEnumerable<ContactPoint>)yzw_),
                Location = yzx_,
                UrlElement = yzy_,
                Note = new List<Annotation>((IEnumerable<Annotation>)yzz_),
                Safety = new List<CodeableConcept>((IEnumerable<CodeableConcept>)zza_),
                Parent = zzb_,
            };

            return zzc_;
        };
        IEnumerable<Device> xzz_ = context.Operators.Select<Device, Device>((IEnumerable<Device>)xzx_, xzy_);
        IEnumerable<Device> yza_ = context.Operators.Distinct<Device>(xzz_);
        Device yzb_ = context.Operators.SingletonFrom<Device>(yza_);

        return yzb_;
    }


    [CqlExpressionDefinition("DeviceDefinitionResource")]
    public DeviceDefinition DeviceDefinitionResource(CqlContext context, DeviceDefinition arg)
    {
        DeviceDefinition[] zzd_ = [
            arg,
        ];
        DeviceDefinition zze_(DeviceDefinition a)
        {
            List<Identifier> zzi_ = a?.Identifier;
            List<DeviceDefinition.UdiDeviceIdentifierComponent> zzj_ = a?.UdiDeviceIdentifier;
            DataType zzk_ = a?.Manufacturer;
            List<DeviceDefinition.DeviceNameComponent> zzl_ = a?.DeviceName;
            FhirString zzm_ = a?.ModelNumberElement;
            CodeableConcept zzn_ = a?.Type;
            List<DeviceDefinition.SpecializationComponent> zzo_ = a?.Specialization;
            List<FhirString> zzp_ = a?.VersionElement;
            List<CodeableConcept> zzq_ = a?.Safety;
            List<ProductShelfLife> zzr_ = a?.ShelfLifeStorage;
            ProdCharacteristic zzs_ = a?.PhysicalCharacteristics;
            List<CodeableConcept> zzt_ = a?.LanguageCode;
            List<DeviceDefinition.CapabilityComponent> zzu_ = a?.Capability;
            List<DeviceDefinition.PropertyComponent> zzv_ = a?.Property;
            ResourceReference zzw_ = a?.Owner;
            List<ContactPoint> zzx_ = a?.Contact;
            FhirUri zzy_ = a?.UrlElement;
            FhirUri zzz_ = a?.OnlineInformationElement;
            List<Annotation> azza_ = a?.Note;
            Quantity azzb_ = a?.Quantity;
            ResourceReference azzc_ = a?.ParentDevice;
            List<DeviceDefinition.MaterialComponent> azzd_ = a?.Material;
            DeviceDefinition azze_ = new DeviceDefinition
            {
                Identifier = new List<Identifier>((IEnumerable<Identifier>)zzi_),
                UdiDeviceIdentifier = new List<DeviceDefinition.UdiDeviceIdentifierComponent>((IEnumerable<DeviceDefinition.UdiDeviceIdentifierComponent>)zzj_),
                Manufacturer = (DataType)zzk_,
                DeviceName = new List<DeviceDefinition.DeviceNameComponent>((IEnumerable<DeviceDefinition.DeviceNameComponent>)zzl_),
                ModelNumberElement = zzm_,
                Type = zzn_,
                Specialization = new List<DeviceDefinition.SpecializationComponent>((IEnumerable<DeviceDefinition.SpecializationComponent>)zzo_),
                VersionElement = new List<FhirString>((IEnumerable<FhirString>)zzp_),
                Safety = new List<CodeableConcept>((IEnumerable<CodeableConcept>)zzq_),
                ShelfLifeStorage = new List<ProductShelfLife>((IEnumerable<ProductShelfLife>)zzr_),
                PhysicalCharacteristics = zzs_,
                LanguageCode = new List<CodeableConcept>((IEnumerable<CodeableConcept>)zzt_),
                Capability = new List<DeviceDefinition.CapabilityComponent>((IEnumerable<DeviceDefinition.CapabilityComponent>)zzu_),
                Property = new List<DeviceDefinition.PropertyComponent>((IEnumerable<DeviceDefinition.PropertyComponent>)zzv_),
                Owner = zzw_,
                Contact = new List<ContactPoint>((IEnumerable<ContactPoint>)zzx_),
                UrlElement = zzy_,
                OnlineInformationElement = zzz_,
                Note = new List<Annotation>((IEnumerable<Annotation>)azza_),
                Quantity = azzb_,
                ParentDevice = azzc_,
                Material = new List<DeviceDefinition.MaterialComponent>((IEnumerable<DeviceDefinition.MaterialComponent>)azzd_),
            };

            return azze_;
        };
        IEnumerable<DeviceDefinition> zzf_ = context.Operators.Select<DeviceDefinition, DeviceDefinition>((IEnumerable<DeviceDefinition>)zzd_, zze_);
        IEnumerable<DeviceDefinition> zzg_ = context.Operators.Distinct<DeviceDefinition>(zzf_);
        DeviceDefinition zzh_ = context.Operators.SingletonFrom<DeviceDefinition>(zzg_);

        return zzh_;
    }


    [CqlExpressionDefinition("DeviceMetricResource")]
    public DeviceMetric DeviceMetricResource(CqlContext context, DeviceMetric arg)
    {
        DeviceMetric[] azzf_ = [
            arg,
        ];
        DeviceMetric azzg_(DeviceMetric a)
        {
            List<Identifier> azzk_ = a?.Identifier;
            CodeableConcept azzl_ = a?.Type;
            CodeableConcept azzm_ = a?.Unit;
            ResourceReference azzn_ = a?.Source;
            ResourceReference azzo_ = a?.Parent;
            Code<DeviceMetric.DeviceMetricOperationalStatus> azzp_ = a?.OperationalStatusElement;
            Code<DeviceMetric.DeviceMetricColor> azzq_ = a?.ColorElement;
            Code<DeviceMetric.DeviceMetricCategory> azzr_ = a?.CategoryElement;
            Timing azzs_ = a?.MeasurementPeriod;
            List<DeviceMetric.CalibrationComponent> azzt_ = a?.Calibration;
            DeviceMetric azzu_ = new DeviceMetric
            {
                Identifier = new List<Identifier>((IEnumerable<Identifier>)azzk_),
                Type = azzl_,
                Unit = azzm_,
                Source = azzn_,
                Parent = azzo_,
                OperationalStatusElement = azzp_,
                ColorElement = azzq_,
                CategoryElement = azzr_,
                MeasurementPeriod = azzs_,
                Calibration = new List<DeviceMetric.CalibrationComponent>((IEnumerable<DeviceMetric.CalibrationComponent>)azzt_),
            };

            return azzu_;
        };
        IEnumerable<DeviceMetric> azzh_ = context.Operators.Select<DeviceMetric, DeviceMetric>((IEnumerable<DeviceMetric>)azzf_, azzg_);
        IEnumerable<DeviceMetric> azzi_ = context.Operators.Distinct<DeviceMetric>(azzh_);
        DeviceMetric azzj_ = context.Operators.SingletonFrom<DeviceMetric>(azzi_);

        return azzj_;
    }


    [CqlExpressionDefinition("DeviceRequestResource")]
    public DeviceRequest DeviceRequestResource(CqlContext context, DeviceRequest arg)
    {
        DeviceRequest[] azzv_ = [
            arg,
        ];
        DeviceRequest azzw_(DeviceRequest a)
        {
            List<Identifier> bzza_ = a?.Identifier;
            List<Canonical> bzzb_ = a?.InstantiatesCanonicalElement;
            List<FhirUri> bzzc_ = a?.InstantiatesUriElement;
            List<ResourceReference> bzzd_ = a?.BasedOn;
            List<ResourceReference> bzze_ = a?.PriorRequest;
            Identifier bzzf_ = a?.GroupIdentifier;
            Code<RequestStatus> bzzg_ = a?.StatusElement;
            Code<RequestIntent> bzzh_ = a?.IntentElement;
            Code<RequestPriority> bzzi_ = a?.PriorityElement;
            DataType bzzj_ = a?.Code;
            List<DeviceRequest.ParameterComponent> bzzk_ = a?.Parameter;
            ResourceReference bzzl_ = a?.Subject;
            ResourceReference bzzm_ = a?.Encounter;
            DataType bzzn_ = a?.Occurrence;
            FhirDateTime bzzo_ = a?.AuthoredOnElement;
            ResourceReference bzzp_ = a?.Requester;
            CodeableConcept bzzq_ = a?.PerformerType;
            ResourceReference bzzr_ = a?.Performer;
            List<CodeableConcept> bzzs_ = a?.ReasonCode;
            List<ResourceReference> bzzt_ = a?.ReasonReference;
            List<ResourceReference> bzzu_ = a?.Insurance;
            List<ResourceReference> bzzv_ = a?.SupportingInfo;
            List<Annotation> bzzw_ = a?.Note;
            List<ResourceReference> bzzx_ = a?.RelevantHistory;
            DeviceRequest bzzy_ = new DeviceRequest
            {
                Identifier = new List<Identifier>((IEnumerable<Identifier>)bzza_),
                InstantiatesCanonicalElement = new List<Canonical>((IEnumerable<Canonical>)bzzb_),
                InstantiatesUriElement = new List<FhirUri>((IEnumerable<FhirUri>)bzzc_),
                BasedOn = new List<ResourceReference>((IEnumerable<ResourceReference>)bzzd_),
                PriorRequest = new List<ResourceReference>((IEnumerable<ResourceReference>)bzze_),
                GroupIdentifier = bzzf_,
                StatusElement = bzzg_,
                IntentElement = bzzh_,
                PriorityElement = bzzi_,
                Code = (DataType)bzzj_,
                Parameter = new List<DeviceRequest.ParameterComponent>((IEnumerable<DeviceRequest.ParameterComponent>)bzzk_),
                Subject = bzzl_,
                Encounter = bzzm_,
                Occurrence = (DataType)bzzn_,
                AuthoredOnElement = bzzo_,
                Requester = bzzp_,
                PerformerType = bzzq_,
                Performer = bzzr_,
                ReasonCode = new List<CodeableConcept>((IEnumerable<CodeableConcept>)bzzs_),
                ReasonReference = new List<ResourceReference>((IEnumerable<ResourceReference>)bzzt_),
                Insurance = new List<ResourceReference>((IEnumerable<ResourceReference>)bzzu_),
                SupportingInfo = new List<ResourceReference>((IEnumerable<ResourceReference>)bzzv_),
                Note = new List<Annotation>((IEnumerable<Annotation>)bzzw_),
                RelevantHistory = new List<ResourceReference>((IEnumerable<ResourceReference>)bzzx_),
            };

            return bzzy_;
        };
        IEnumerable<DeviceRequest> azzx_ = context.Operators.Select<DeviceRequest, DeviceRequest>((IEnumerable<DeviceRequest>)azzv_, azzw_);
        IEnumerable<DeviceRequest> azzy_ = context.Operators.Distinct<DeviceRequest>(azzx_);
        DeviceRequest azzz_ = context.Operators.SingletonFrom<DeviceRequest>(azzy_);

        return azzz_;
    }


    [CqlExpressionDefinition("DeviceUseStatementResource")]
    public DeviceUseStatement DeviceUseStatementResource(CqlContext context, DeviceUseStatement arg)
    {
        DeviceUseStatement[] bzzz_ = [
            arg,
        ];
        DeviceUseStatement czza_(DeviceUseStatement a)
        {
            List<Identifier> czze_ = a?.Identifier;
            List<ResourceReference> czzf_ = a?.BasedOn;
            Code<DeviceUseStatement.DeviceUseStatementStatus> czzg_ = a?.StatusElement;
            ResourceReference czzh_ = a?.Subject;
            List<ResourceReference> czzi_ = a?.DerivedFrom;
            DataType czzj_ = a?.Timing;
            FhirDateTime czzk_ = a?.RecordedOnElement;
            ResourceReference czzl_ = a?.Source;
            ResourceReference czzm_ = a?.Device;
            List<CodeableConcept> czzn_ = a?.ReasonCode;
            List<ResourceReference> czzo_ = a?.ReasonReference;
            CodeableConcept czzp_ = a?.BodySite;
            List<Annotation> czzq_ = a?.Note;
            DeviceUseStatement czzr_ = new DeviceUseStatement
            {
                Identifier = new List<Identifier>((IEnumerable<Identifier>)czze_),
                BasedOn = new List<ResourceReference>((IEnumerable<ResourceReference>)czzf_),
                StatusElement = czzg_,
                Subject = czzh_,
                DerivedFrom = new List<ResourceReference>((IEnumerable<ResourceReference>)czzi_),
                Timing = (DataType)czzj_,
                RecordedOnElement = czzk_,
                Source = czzl_,
                Device = czzm_,
                ReasonCode = new List<CodeableConcept>((IEnumerable<CodeableConcept>)czzn_),
                ReasonReference = new List<ResourceReference>((IEnumerable<ResourceReference>)czzo_),
                BodySite = czzp_,
                Note = new List<Annotation>((IEnumerable<Annotation>)czzq_),
            };

            return czzr_;
        };
        IEnumerable<DeviceUseStatement> czzb_ = context.Operators.Select<DeviceUseStatement, DeviceUseStatement>((IEnumerable<DeviceUseStatement>)bzzz_, czza_);
        IEnumerable<DeviceUseStatement> czzc_ = context.Operators.Distinct<DeviceUseStatement>(czzb_);
        DeviceUseStatement czzd_ = context.Operators.SingletonFrom<DeviceUseStatement>(czzc_);

        return czzd_;
    }


    [CqlExpressionDefinition("DiagnosticReportResource")]
    public DiagnosticReport DiagnosticReportResource(CqlContext context, DiagnosticReport arg)
    {
        DiagnosticReport[] czzs_ = [
            arg,
        ];
        DiagnosticReport czzt_(DiagnosticReport a)
        {
            List<Identifier> czzx_ = a?.Identifier;
            List<ResourceReference> czzy_ = a?.BasedOn;
            Code<DiagnosticReport.DiagnosticReportStatus> czzz_ = a?.StatusElement;
            List<CodeableConcept> dzza_ = a?.Category;
            CodeableConcept dzzb_ = a?.Code;
            ResourceReference dzzc_ = a?.Subject;
            ResourceReference dzzd_ = a?.Encounter;
            DataType dzze_ = a?.Effective;
            Instant dzzf_ = a?.IssuedElement;
            List<ResourceReference> dzzg_ = a?.Performer;
            List<ResourceReference> dzzh_ = a?.ResultsInterpreter;
            List<ResourceReference> dzzi_ = a?.Specimen;
            List<ResourceReference> dzzj_ = a?.Result;
            List<ResourceReference> dzzk_ = a?.ImagingStudy;
            List<DiagnosticReport.MediaComponent> dzzl_ = a?.Media;
            FhirString dzzm_ = a?.ConclusionElement;
            List<CodeableConcept> dzzn_ = a?.ConclusionCode;
            List<Attachment> dzzo_ = a?.PresentedForm;
            DiagnosticReport dzzp_ = new DiagnosticReport
            {
                Identifier = new List<Identifier>((IEnumerable<Identifier>)czzx_),
                BasedOn = new List<ResourceReference>((IEnumerable<ResourceReference>)czzy_),
                StatusElement = czzz_,
                Category = new List<CodeableConcept>((IEnumerable<CodeableConcept>)dzza_),
                Code = dzzb_,
                Subject = dzzc_,
                Encounter = dzzd_,
                Effective = (DataType)dzze_,
                IssuedElement = dzzf_,
                Performer = new List<ResourceReference>((IEnumerable<ResourceReference>)dzzg_),
                ResultsInterpreter = new List<ResourceReference>((IEnumerable<ResourceReference>)dzzh_),
                Specimen = new List<ResourceReference>((IEnumerable<ResourceReference>)dzzi_),
                Result = new List<ResourceReference>((IEnumerable<ResourceReference>)dzzj_),
                ImagingStudy = new List<ResourceReference>((IEnumerable<ResourceReference>)dzzk_),
                Media = new List<DiagnosticReport.MediaComponent>((IEnumerable<DiagnosticReport.MediaComponent>)dzzl_),
                ConclusionElement = dzzm_,
                ConclusionCode = new List<CodeableConcept>((IEnumerable<CodeableConcept>)dzzn_),
                PresentedForm = new List<Attachment>((IEnumerable<Attachment>)dzzo_),
            };

            return dzzp_;
        };
        IEnumerable<DiagnosticReport> czzu_ = context.Operators.Select<DiagnosticReport, DiagnosticReport>((IEnumerable<DiagnosticReport>)czzs_, czzt_);
        IEnumerable<DiagnosticReport> czzv_ = context.Operators.Distinct<DiagnosticReport>(czzu_);
        DiagnosticReport czzw_ = context.Operators.SingletonFrom<DiagnosticReport>(czzv_);

        return czzw_;
    }


    [CqlExpressionDefinition("DocumentManifestResource")]
    public DocumentManifest DocumentManifestResource(CqlContext context, DocumentManifest arg)
    {
        DocumentManifest[] dzzq_ = [
            arg,
        ];
        DocumentManifest dzzr_(DocumentManifest a)
        {
            Identifier dzzv_ = a?.MasterIdentifier;
            List<Identifier> dzzw_ = a?.Identifier;
            Code<DocumentReferenceStatus> dzzx_ = a?.StatusElement;
            CodeableConcept dzzy_ = a?.Type;
            ResourceReference dzzz_ = a?.Subject;
            FhirDateTime ezza_ = a?.CreatedElement;
            List<ResourceReference> ezzb_ = a?.Author;
            List<ResourceReference> ezzc_ = a?.Recipient;
            FhirUri ezzd_ = a?.SourceElement;
            FhirString ezze_ = a?.DescriptionElement;
            List<ResourceReference> ezzf_ = a?.Content;
            List<DocumentManifest.RelatedComponent> ezzg_ = a?.Related;
            DocumentManifest ezzh_ = new DocumentManifest
            {
                MasterIdentifier = dzzv_,
                Identifier = new List<Identifier>((IEnumerable<Identifier>)dzzw_),
                StatusElement = dzzx_,
                Type = dzzy_,
                Subject = dzzz_,
                CreatedElement = ezza_,
                Author = new List<ResourceReference>((IEnumerable<ResourceReference>)ezzb_),
                Recipient = new List<ResourceReference>((IEnumerable<ResourceReference>)ezzc_),
                SourceElement = ezzd_,
                DescriptionElement = ezze_,
                Content = new List<ResourceReference>((IEnumerable<ResourceReference>)ezzf_),
                Related = new List<DocumentManifest.RelatedComponent>((IEnumerable<DocumentManifest.RelatedComponent>)ezzg_),
            };

            return ezzh_;
        };
        IEnumerable<DocumentManifest> dzzs_ = context.Operators.Select<DocumentManifest, DocumentManifest>((IEnumerable<DocumentManifest>)dzzq_, dzzr_);
        IEnumerable<DocumentManifest> dzzt_ = context.Operators.Distinct<DocumentManifest>(dzzs_);
        DocumentManifest dzzu_ = context.Operators.SingletonFrom<DocumentManifest>(dzzt_);

        return dzzu_;
    }


    [CqlExpressionDefinition("DocumentReferenceResource")]
    public DocumentReference DocumentReferenceResource(CqlContext context, DocumentReference arg)
    {
        DocumentReference[] ezzi_ = [
            arg,
        ];
        DocumentReference ezzj_(DocumentReference a)
        {
            Identifier ezzn_ = a?.MasterIdentifier;
            List<Identifier> ezzo_ = a?.Identifier;
            Code<DocumentReferenceStatus> ezzp_ = a?.StatusElement;
            Code<CompositionStatus> ezzq_ = a?.DocStatusElement;
            CodeableConcept ezzr_ = a?.Type;
            List<CodeableConcept> ezzs_ = a?.Category;
            ResourceReference ezzt_ = a?.Subject;
            Instant ezzu_ = a?.DateElement;
            List<ResourceReference> ezzv_ = a?.Author;
            ResourceReference ezzw_ = a?.Authenticator;
            ResourceReference ezzx_ = a?.Custodian;
            List<DocumentReference.RelatesToComponent> ezzy_ = a?.RelatesTo;
            FhirString ezzz_ = a?.DescriptionElement;
            List<CodeableConcept> fzza_ = a?.SecurityLabel;
            List<DocumentReference.ContentComponent> fzzb_ = a?.Content;
            DocumentReference.ContextComponent fzzc_ = a?.Context;
            DocumentReference fzzd_ = new DocumentReference
            {
                MasterIdentifier = ezzn_,
                Identifier = new List<Identifier>((IEnumerable<Identifier>)ezzo_),
                StatusElement = ezzp_,
                DocStatusElement = ezzq_,
                Type = ezzr_,
                Category = new List<CodeableConcept>((IEnumerable<CodeableConcept>)ezzs_),
                Subject = ezzt_,
                DateElement = ezzu_,
                Author = new List<ResourceReference>((IEnumerable<ResourceReference>)ezzv_),
                Authenticator = ezzw_,
                Custodian = ezzx_,
                RelatesTo = new List<DocumentReference.RelatesToComponent>((IEnumerable<DocumentReference.RelatesToComponent>)ezzy_),
                DescriptionElement = ezzz_,
                SecurityLabel = new List<CodeableConcept>((IEnumerable<CodeableConcept>)fzza_),
                Content = new List<DocumentReference.ContentComponent>((IEnumerable<DocumentReference.ContentComponent>)fzzb_),
                Context = fzzc_,
            };

            return fzzd_;
        };
        IEnumerable<DocumentReference> ezzk_ = context.Operators.Select<DocumentReference, DocumentReference>((IEnumerable<DocumentReference>)ezzi_, ezzj_);
        IEnumerable<DocumentReference> ezzl_ = context.Operators.Distinct<DocumentReference>(ezzk_);
        DocumentReference ezzm_ = context.Operators.SingletonFrom<DocumentReference>(ezzl_);

        return ezzm_;
    }


    [CqlExpressionDefinition("EffectEvidenceSynthesisResource")]
    public EffectEvidenceSynthesis EffectEvidenceSynthesisResource(CqlContext context, EffectEvidenceSynthesis arg)
    {
        EffectEvidenceSynthesis[] fzze_ = [
            arg,
        ];
        EffectEvidenceSynthesis fzzf_(EffectEvidenceSynthesis a)
        {
            FhirUri fzzj_ = a?.UrlElement;
            List<Identifier> fzzk_ = a?.Identifier;
            FhirString fzzl_ = a?.VersionElement;
            FhirString fzzm_ = a?.NameElement;
            FhirString fzzn_ = a?.TitleElement;
            Code<PublicationStatus> fzzo_ = a?.StatusElement;
            FhirDateTime fzzp_ = a?.DateElement;
            FhirString fzzq_ = a?.PublisherElement;
            List<ContactDetail> fzzr_ = a?.Contact;
            Markdown fzzs_ = a?.DescriptionElement;
            List<Annotation> fzzt_ = a?.Note;
            List<UsageContext> fzzu_ = a?.UseContext;
            List<CodeableConcept> fzzv_ = a?.Jurisdiction;
            Markdown fzzw_ = a?.CopyrightElement;
            Date fzzx_ = a?.ApprovalDateElement;
            Date fzzy_ = a?.LastReviewDateElement;
            Period fzzz_ = a?.EffectivePeriod;
            List<CodeableConcept> gzza_ = a?.Topic;
            List<ContactDetail> gzzb_ = a?.Author;
            List<ContactDetail> gzzc_ = a?.Editor;
            List<ContactDetail> gzzd_ = a?.Reviewer;
            List<ContactDetail> gzze_ = a?.Endorser;
            List<RelatedArtifact> gzzf_ = a?.RelatedArtifact;
            CodeableConcept gzzg_ = a?.SynthesisType;
            CodeableConcept gzzh_ = a?.StudyType;
            ResourceReference gzzi_ = a?.Population;
            ResourceReference gzzj_ = a?.Exposure;
            ResourceReference gzzk_ = a?.ExposureAlternative;
            ResourceReference gzzl_ = a?.Outcome;
            EffectEvidenceSynthesis.SampleSizeComponent gzzm_ = a?.SampleSize;
            List<EffectEvidenceSynthesis.ResultsByExposureComponent> gzzn_ = a?.ResultsByExposure;
            List<EffectEvidenceSynthesis.EffectEstimateComponent> gzzo_ = a?.EffectEstimate;
            List<EffectEvidenceSynthesis.CertaintyComponent> gzzp_ = a?.Certainty;
            EffectEvidenceSynthesis gzzq_ = new EffectEvidenceSynthesis
            {
                UrlElement = fzzj_,
                Identifier = new List<Identifier>((IEnumerable<Identifier>)fzzk_),
                VersionElement = fzzl_,
                NameElement = fzzm_,
                TitleElement = fzzn_,
                StatusElement = fzzo_,
                DateElement = fzzp_,
                PublisherElement = fzzq_,
                Contact = new List<ContactDetail>((IEnumerable<ContactDetail>)fzzr_),
                DescriptionElement = fzzs_,
                Note = new List<Annotation>((IEnumerable<Annotation>)fzzt_),
                UseContext = new List<UsageContext>((IEnumerable<UsageContext>)fzzu_),
                Jurisdiction = new List<CodeableConcept>((IEnumerable<CodeableConcept>)fzzv_),
                CopyrightElement = fzzw_,
                ApprovalDateElement = fzzx_,
                LastReviewDateElement = fzzy_,
                EffectivePeriod = fzzz_,
                Topic = new List<CodeableConcept>((IEnumerable<CodeableConcept>)gzza_),
                Author = new List<ContactDetail>((IEnumerable<ContactDetail>)gzzb_),
                Editor = new List<ContactDetail>((IEnumerable<ContactDetail>)gzzc_),
                Reviewer = new List<ContactDetail>((IEnumerable<ContactDetail>)gzzd_),
                Endorser = new List<ContactDetail>((IEnumerable<ContactDetail>)gzze_),
                RelatedArtifact = new List<RelatedArtifact>((IEnumerable<RelatedArtifact>)gzzf_),
                SynthesisType = gzzg_,
                StudyType = gzzh_,
                Population = gzzi_,
                Exposure = gzzj_,
                ExposureAlternative = gzzk_,
                Outcome = gzzl_,
                SampleSize = gzzm_,
                ResultsByExposure = new List<EffectEvidenceSynthesis.ResultsByExposureComponent>((IEnumerable<EffectEvidenceSynthesis.ResultsByExposureComponent>)gzzn_),
                EffectEstimate = new List<EffectEvidenceSynthesis.EffectEstimateComponent>((IEnumerable<EffectEvidenceSynthesis.EffectEstimateComponent>)gzzo_),
                Certainty = new List<EffectEvidenceSynthesis.CertaintyComponent>((IEnumerable<EffectEvidenceSynthesis.CertaintyComponent>)gzzp_),
            };

            return gzzq_;
        };
        IEnumerable<EffectEvidenceSynthesis> fzzg_ = context.Operators.Select<EffectEvidenceSynthesis, EffectEvidenceSynthesis>((IEnumerable<EffectEvidenceSynthesis>)fzze_, fzzf_);
        IEnumerable<EffectEvidenceSynthesis> fzzh_ = context.Operators.Distinct<EffectEvidenceSynthesis>(fzzg_);
        EffectEvidenceSynthesis fzzi_ = context.Operators.SingletonFrom<EffectEvidenceSynthesis>(fzzh_);

        return fzzi_;
    }


    [CqlExpressionDefinition("EncounterResource")]
    public Encounter EncounterResource(CqlContext context, Encounter arg)
    {
        Encounter[] gzzr_ = [
            arg,
        ];
        Encounter gzzs_(Encounter a)
        {
            List<Identifier> gzzw_ = a?.Identifier;
            Code<Encounter.EncounterStatus> gzzx_ = a?.StatusElement;
            List<Encounter.StatusHistoryComponent> gzzy_ = a?.StatusHistory;
            Coding gzzz_ = a?.Class;
            List<Encounter.ClassHistoryComponent> hzza_ = a?.ClassHistory;
            List<CodeableConcept> hzzb_ = a?.Type;
            CodeableConcept hzzc_ = a?.ServiceType;
            CodeableConcept hzzd_ = a?.Priority;
            ResourceReference hzze_ = a?.Subject;
            List<ResourceReference> hzzf_ = a?.EpisodeOfCare;
            List<ResourceReference> hzzg_ = a?.BasedOn;
            List<Encounter.ParticipantComponent> hzzh_ = a?.Participant;
            List<ResourceReference> hzzi_ = a?.Appointment;
            Period hzzj_ = a?.Period;
            Duration hzzk_ = a?.Length;
            List<CodeableConcept> hzzl_ = a?.ReasonCode;
            List<ResourceReference> hzzm_ = a?.ReasonReference;
            List<Encounter.DiagnosisComponent> hzzn_ = a?.Diagnosis;
            List<ResourceReference> hzzo_ = a?.Account;
            Encounter.HospitalizationComponent hzzp_ = a?.Hospitalization;
            List<Encounter.LocationComponent> hzzq_ = a?.Location;
            ResourceReference hzzr_ = a?.ServiceProvider;
            ResourceReference hzzs_ = a?.PartOf;
            Encounter hzzt_ = new Encounter
            {
                Identifier = new List<Identifier>((IEnumerable<Identifier>)gzzw_),
                StatusElement = gzzx_,
                StatusHistory = new List<Encounter.StatusHistoryComponent>((IEnumerable<Encounter.StatusHistoryComponent>)gzzy_),
                Class = gzzz_,
                ClassHistory = new List<Encounter.ClassHistoryComponent>((IEnumerable<Encounter.ClassHistoryComponent>)hzza_),
                Type = new List<CodeableConcept>((IEnumerable<CodeableConcept>)hzzb_),
                ServiceType = hzzc_,
                Priority = hzzd_,
                Subject = hzze_,
                EpisodeOfCare = new List<ResourceReference>((IEnumerable<ResourceReference>)hzzf_),
                BasedOn = new List<ResourceReference>((IEnumerable<ResourceReference>)hzzg_),
                Participant = new List<Encounter.ParticipantComponent>((IEnumerable<Encounter.ParticipantComponent>)hzzh_),
                Appointment = new List<ResourceReference>((IEnumerable<ResourceReference>)hzzi_),
                Period = hzzj_,
                Length = hzzk_,
                ReasonCode = new List<CodeableConcept>((IEnumerable<CodeableConcept>)hzzl_),
                ReasonReference = new List<ResourceReference>((IEnumerable<ResourceReference>)hzzm_),
                Diagnosis = new List<Encounter.DiagnosisComponent>((IEnumerable<Encounter.DiagnosisComponent>)hzzn_),
                Account = new List<ResourceReference>((IEnumerable<ResourceReference>)hzzo_),
                Hospitalization = hzzp_,
                Location = new List<Encounter.LocationComponent>((IEnumerable<Encounter.LocationComponent>)hzzq_),
                ServiceProvider = hzzr_,
                PartOf = hzzs_,
            };

            return hzzt_;
        };
        IEnumerable<Encounter> gzzt_ = context.Operators.Select<Encounter, Encounter>((IEnumerable<Encounter>)gzzr_, gzzs_);
        IEnumerable<Encounter> gzzu_ = context.Operators.Distinct<Encounter>(gzzt_);
        Encounter gzzv_ = context.Operators.SingletonFrom<Encounter>(gzzu_);

        return gzzv_;
    }


    [CqlExpressionDefinition("EndpointResource")]
    public Endpoint EndpointResource(CqlContext context, Endpoint arg)
    {
        Endpoint[] hzzu_ = [
            arg,
        ];
        Endpoint hzzv_(Endpoint a)
        {
            List<Identifier> hzzz_ = a?.Identifier;
            Code<Endpoint.EndpointStatus> izza_ = a?.StatusElement;
            Coding izzb_ = a?.ConnectionType;
            FhirString izzc_ = a?.NameElement;
            ResourceReference izzd_ = a?.ManagingOrganization;
            List<ContactPoint> izze_ = a?.Contact;
            Period izzf_ = a?.Period;
            List<CodeableConcept> izzg_ = a?.PayloadType;
            List<Code> izzh_ = a?.PayloadMimeTypeElement;
            FhirUrl izzi_ = a?.AddressElement;
            List<FhirString> izzj_ = a?.HeaderElement;
            Endpoint izzk_ = new Endpoint
            {
                Identifier = new List<Identifier>((IEnumerable<Identifier>)hzzz_),
                StatusElement = izza_,
                ConnectionType = izzb_,
                NameElement = izzc_,
                ManagingOrganization = izzd_,
                Contact = new List<ContactPoint>((IEnumerable<ContactPoint>)izze_),
                Period = izzf_,
                PayloadType = new List<CodeableConcept>((IEnumerable<CodeableConcept>)izzg_),
                PayloadMimeTypeElement = new List<Code>((IEnumerable<Code>)izzh_),
                AddressElement = izzi_,
                HeaderElement = new List<FhirString>((IEnumerable<FhirString>)izzj_),
            };

            return izzk_;
        };
        IEnumerable<Endpoint> hzzw_ = context.Operators.Select<Endpoint, Endpoint>((IEnumerable<Endpoint>)hzzu_, hzzv_);
        IEnumerable<Endpoint> hzzx_ = context.Operators.Distinct<Endpoint>(hzzw_);
        Endpoint hzzy_ = context.Operators.SingletonFrom<Endpoint>(hzzx_);

        return hzzy_;
    }


    [CqlExpressionDefinition("EnrollmentRequestResource")]
    public EnrollmentRequest EnrollmentRequestResource(CqlContext context, EnrollmentRequest arg)
    {
        EnrollmentRequest[] izzl_ = [
            arg,
        ];
        EnrollmentRequest izzm_(EnrollmentRequest a)
        {
            List<Identifier> izzq_ = a?.Identifier;
            Code<FinancialResourceStatusCodes> izzr_ = a?.StatusElement;
            FhirDateTime izzs_ = a?.CreatedElement;
            ResourceReference izzt_ = a?.Insurer;
            ResourceReference izzu_ = a?.Provider;
            ResourceReference izzv_ = a?.Candidate;
            ResourceReference izzw_ = a?.Coverage;
            EnrollmentRequest izzx_ = new EnrollmentRequest
            {
                Identifier = new List<Identifier>((IEnumerable<Identifier>)izzq_),
                StatusElement = izzr_,
                CreatedElement = izzs_,
                Insurer = izzt_,
                Provider = izzu_,
                Candidate = izzv_,
                Coverage = izzw_,
            };

            return izzx_;
        };
        IEnumerable<EnrollmentRequest> izzn_ = context.Operators.Select<EnrollmentRequest, EnrollmentRequest>((IEnumerable<EnrollmentRequest>)izzl_, izzm_);
        IEnumerable<EnrollmentRequest> izzo_ = context.Operators.Distinct<EnrollmentRequest>(izzn_);
        EnrollmentRequest izzp_ = context.Operators.SingletonFrom<EnrollmentRequest>(izzo_);

        return izzp_;
    }


    [CqlExpressionDefinition("EnrollmentResponseResource")]
    public EnrollmentResponse EnrollmentResponseResource(CqlContext context, EnrollmentResponse arg)
    {
        EnrollmentResponse[] izzy_ = [
            arg,
        ];
        EnrollmentResponse izzz_(EnrollmentResponse a)
        {
            List<Identifier> jzzd_ = a?.Identifier;
            Code<FinancialResourceStatusCodes> jzze_ = a?.StatusElement;
            ResourceReference jzzf_ = a?.Request;
            Code<ClaimProcessingCodes> jzzg_ = a?.OutcomeElement;
            FhirString jzzh_ = a?.DispositionElement;
            FhirDateTime jzzi_ = a?.CreatedElement;
            ResourceReference jzzj_ = a?.Organization;
            ResourceReference jzzk_ = a?.RequestProvider;
            EnrollmentResponse jzzl_ = new EnrollmentResponse
            {
                Identifier = new List<Identifier>((IEnumerable<Identifier>)jzzd_),
                StatusElement = jzze_,
                Request = jzzf_,
                OutcomeElement = jzzg_,
                DispositionElement = jzzh_,
                CreatedElement = jzzi_,
                Organization = jzzj_,
                RequestProvider = jzzk_,
            };

            return jzzl_;
        };
        IEnumerable<EnrollmentResponse> jzza_ = context.Operators.Select<EnrollmentResponse, EnrollmentResponse>((IEnumerable<EnrollmentResponse>)izzy_, izzz_);
        IEnumerable<EnrollmentResponse> jzzb_ = context.Operators.Distinct<EnrollmentResponse>(jzza_);
        EnrollmentResponse jzzc_ = context.Operators.SingletonFrom<EnrollmentResponse>(jzzb_);

        return jzzc_;
    }


    [CqlExpressionDefinition("EpisodeOfCareResource")]
    public EpisodeOfCare EpisodeOfCareResource(CqlContext context, EpisodeOfCare arg)
    {
        EpisodeOfCare[] jzzm_ = [
            arg,
        ];
        EpisodeOfCare jzzn_(EpisodeOfCare a)
        {
            List<Identifier> jzzr_ = a?.Identifier;
            Code<EpisodeOfCare.EpisodeOfCareStatus> jzzs_ = a?.StatusElement;
            List<EpisodeOfCare.StatusHistoryComponent> jzzt_ = a?.StatusHistory;
            List<CodeableConcept> jzzu_ = a?.Type;
            List<EpisodeOfCare.DiagnosisComponent> jzzv_ = a?.Diagnosis;
            ResourceReference jzzw_ = a?.Patient;
            ResourceReference jzzx_ = a?.ManagingOrganization;
            Period jzzy_ = a?.Period;
            List<ResourceReference> jzzz_ = a?.ReferralRequest;
            ResourceReference kzza_ = a?.CareManager;
            List<ResourceReference> kzzb_ = a?.Team;
            List<ResourceReference> kzzc_ = a?.Account;
            EpisodeOfCare kzzd_ = new EpisodeOfCare
            {
                Identifier = new List<Identifier>((IEnumerable<Identifier>)jzzr_),
                StatusElement = jzzs_,
                StatusHistory = new List<EpisodeOfCare.StatusHistoryComponent>((IEnumerable<EpisodeOfCare.StatusHistoryComponent>)jzzt_),
                Type = new List<CodeableConcept>((IEnumerable<CodeableConcept>)jzzu_),
                Diagnosis = new List<EpisodeOfCare.DiagnosisComponent>((IEnumerable<EpisodeOfCare.DiagnosisComponent>)jzzv_),
                Patient = jzzw_,
                ManagingOrganization = jzzx_,
                Period = jzzy_,
                ReferralRequest = new List<ResourceReference>((IEnumerable<ResourceReference>)jzzz_),
                CareManager = kzza_,
                Team = new List<ResourceReference>((IEnumerable<ResourceReference>)kzzb_),
                Account = new List<ResourceReference>((IEnumerable<ResourceReference>)kzzc_),
            };

            return kzzd_;
        };
        IEnumerable<EpisodeOfCare> jzzo_ = context.Operators.Select<EpisodeOfCare, EpisodeOfCare>((IEnumerable<EpisodeOfCare>)jzzm_, jzzn_);
        IEnumerable<EpisodeOfCare> jzzp_ = context.Operators.Distinct<EpisodeOfCare>(jzzo_);
        EpisodeOfCare jzzq_ = context.Operators.SingletonFrom<EpisodeOfCare>(jzzp_);

        return jzzq_;
    }


    [CqlExpressionDefinition("EventDefinitionResource")]
    public EventDefinition EventDefinitionResource(CqlContext context, EventDefinition arg)
    {
        EventDefinition[] kzze_ = [
            arg,
        ];
        EventDefinition kzzf_(EventDefinition a)
        {
            FhirUri kzzj_ = a?.UrlElement;
            List<Identifier> kzzk_ = a?.Identifier;
            FhirString kzzl_ = a?.VersionElement;
            FhirString kzzm_ = a?.NameElement;
            FhirString kzzn_ = a?.TitleElement;
            FhirString kzzo_ = a?.SubtitleElement;
            Code<PublicationStatus> kzzp_ = a?.StatusElement;
            FhirBoolean kzzq_ = a?.ExperimentalElement;
            DataType kzzr_ = a?.Subject;
            FhirDateTime kzzs_ = a?.DateElement;
            FhirString kzzt_ = a?.PublisherElement;
            List<ContactDetail> kzzu_ = a?.Contact;
            Markdown kzzv_ = a?.DescriptionElement;
            List<UsageContext> kzzw_ = a?.UseContext;
            List<CodeableConcept> kzzx_ = a?.Jurisdiction;
            Markdown kzzy_ = a?.PurposeElement;
            FhirString kzzz_ = a?.UsageElement;
            Markdown lzza_ = a?.CopyrightElement;
            Date lzzb_ = a?.ApprovalDateElement;
            Date lzzc_ = a?.LastReviewDateElement;
            Period lzzd_ = a?.EffectivePeriod;
            List<CodeableConcept> lzze_ = a?.Topic;
            List<ContactDetail> lzzf_ = a?.Author;
            List<ContactDetail> lzzg_ = a?.Editor;
            List<ContactDetail> lzzh_ = a?.Reviewer;
            List<ContactDetail> lzzi_ = a?.Endorser;
            List<RelatedArtifact> lzzj_ = a?.RelatedArtifact;
            List<TriggerDefinition> lzzk_ = a?.Trigger;
            EventDefinition lzzl_ = new EventDefinition
            {
                UrlElement = kzzj_,
                Identifier = new List<Identifier>((IEnumerable<Identifier>)kzzk_),
                VersionElement = kzzl_,
                NameElement = kzzm_,
                TitleElement = kzzn_,
                SubtitleElement = kzzo_,
                StatusElement = kzzp_,
                ExperimentalElement = kzzq_,
                Subject = (DataType)kzzr_,
                DateElement = kzzs_,
                PublisherElement = kzzt_,
                Contact = new List<ContactDetail>((IEnumerable<ContactDetail>)kzzu_),
                DescriptionElement = kzzv_,
                UseContext = new List<UsageContext>((IEnumerable<UsageContext>)kzzw_),
                Jurisdiction = new List<CodeableConcept>((IEnumerable<CodeableConcept>)kzzx_),
                PurposeElement = kzzy_,
                UsageElement = kzzz_,
                CopyrightElement = lzza_,
                ApprovalDateElement = lzzb_,
                LastReviewDateElement = lzzc_,
                EffectivePeriod = lzzd_,
                Topic = new List<CodeableConcept>((IEnumerable<CodeableConcept>)lzze_),
                Author = new List<ContactDetail>((IEnumerable<ContactDetail>)lzzf_),
                Editor = new List<ContactDetail>((IEnumerable<ContactDetail>)lzzg_),
                Reviewer = new List<ContactDetail>((IEnumerable<ContactDetail>)lzzh_),
                Endorser = new List<ContactDetail>((IEnumerable<ContactDetail>)lzzi_),
                RelatedArtifact = new List<RelatedArtifact>((IEnumerable<RelatedArtifact>)lzzj_),
                Trigger = new List<TriggerDefinition>((IEnumerable<TriggerDefinition>)lzzk_),
            };

            return lzzl_;
        };
        IEnumerable<EventDefinition> kzzg_ = context.Operators.Select<EventDefinition, EventDefinition>((IEnumerable<EventDefinition>)kzze_, kzzf_);
        IEnumerable<EventDefinition> kzzh_ = context.Operators.Distinct<EventDefinition>(kzzg_);
        EventDefinition kzzi_ = context.Operators.SingletonFrom<EventDefinition>(kzzh_);

        return kzzi_;
    }


    [CqlExpressionDefinition("EvidenceResource")]
    public Evidence EvidenceResource(CqlContext context, Evidence arg)
    {
        Evidence[] lzzm_ = [
            arg,
        ];
        Evidence lzzn_(Evidence a)
        {
            FhirUri lzzr_ = a?.UrlElement;
            List<Identifier> lzzs_ = a?.Identifier;
            FhirString lzzt_ = a?.VersionElement;
            FhirString lzzu_ = a?.NameElement;
            FhirString lzzv_ = a?.TitleElement;
            FhirString lzzw_ = a?.ShortTitleElement;
            FhirString lzzx_ = a?.SubtitleElement;
            Code<PublicationStatus> lzzy_ = a?.StatusElement;
            FhirDateTime lzzz_ = a?.DateElement;
            FhirString mzza_ = a?.PublisherElement;
            List<ContactDetail> mzzb_ = a?.Contact;
            Markdown mzzc_ = a?.DescriptionElement;
            List<Annotation> mzzd_ = a?.Note;
            List<UsageContext> mzze_ = a?.UseContext;
            List<CodeableConcept> mzzf_ = a?.Jurisdiction;
            Markdown mzzg_ = a?.CopyrightElement;
            Date mzzh_ = a?.ApprovalDateElement;
            Date mzzi_ = a?.LastReviewDateElement;
            Period mzzj_ = a?.EffectivePeriod;
            List<CodeableConcept> mzzk_ = a?.Topic;
            List<ContactDetail> mzzl_ = a?.Author;
            List<ContactDetail> mzzm_ = a?.Editor;
            List<ContactDetail> mzzn_ = a?.Reviewer;
            List<ContactDetail> mzzo_ = a?.Endorser;
            List<RelatedArtifact> mzzp_ = a?.RelatedArtifact;
            ResourceReference mzzq_ = a?.ExposureBackground;
            List<ResourceReference> mzzr_ = a?.ExposureVariant;
            List<ResourceReference> mzzs_ = a?.Outcome;
            Evidence mzzt_ = new Evidence
            {
                UrlElement = lzzr_,
                Identifier = new List<Identifier>((IEnumerable<Identifier>)lzzs_),
                VersionElement = lzzt_,
                NameElement = lzzu_,
                TitleElement = lzzv_,
                ShortTitleElement = lzzw_,
                SubtitleElement = lzzx_,
                StatusElement = lzzy_,
                DateElement = lzzz_,
                PublisherElement = mzza_,
                Contact = new List<ContactDetail>((IEnumerable<ContactDetail>)mzzb_),
                DescriptionElement = mzzc_,
                Note = new List<Annotation>((IEnumerable<Annotation>)mzzd_),
                UseContext = new List<UsageContext>((IEnumerable<UsageContext>)mzze_),
                Jurisdiction = new List<CodeableConcept>((IEnumerable<CodeableConcept>)mzzf_),
                CopyrightElement = mzzg_,
                ApprovalDateElement = mzzh_,
                LastReviewDateElement = mzzi_,
                EffectivePeriod = mzzj_,
                Topic = new List<CodeableConcept>((IEnumerable<CodeableConcept>)mzzk_),
                Author = new List<ContactDetail>((IEnumerable<ContactDetail>)mzzl_),
                Editor = new List<ContactDetail>((IEnumerable<ContactDetail>)mzzm_),
                Reviewer = new List<ContactDetail>((IEnumerable<ContactDetail>)mzzn_),
                Endorser = new List<ContactDetail>((IEnumerable<ContactDetail>)mzzo_),
                RelatedArtifact = new List<RelatedArtifact>((IEnumerable<RelatedArtifact>)mzzp_),
                ExposureBackground = mzzq_,
                ExposureVariant = new List<ResourceReference>((IEnumerable<ResourceReference>)mzzr_),
                Outcome = new List<ResourceReference>((IEnumerable<ResourceReference>)mzzs_),
            };

            return mzzt_;
        };
        IEnumerable<Evidence> lzzo_ = context.Operators.Select<Evidence, Evidence>((IEnumerable<Evidence>)lzzm_, lzzn_);
        IEnumerable<Evidence> lzzp_ = context.Operators.Distinct<Evidence>(lzzo_);
        Evidence lzzq_ = context.Operators.SingletonFrom<Evidence>(lzzp_);

        return lzzq_;
    }


    [CqlExpressionDefinition("EvidenceVariableResource")]
    public EvidenceVariable EvidenceVariableResource(CqlContext context, EvidenceVariable arg)
    {
        EvidenceVariable[] mzzu_ = [
            arg,
        ];
        EvidenceVariable mzzv_(EvidenceVariable a)
        {
            FhirUri mzzz_ = a?.UrlElement;
            List<Identifier> nzza_ = a?.Identifier;
            FhirString nzzb_ = a?.VersionElement;
            FhirString nzzc_ = a?.NameElement;
            FhirString nzzd_ = a?.TitleElement;
            FhirString nzze_ = a?.ShortTitleElement;
            FhirString nzzf_ = a?.SubtitleElement;
            Code<PublicationStatus> nzzg_ = a?.StatusElement;
            FhirDateTime nzzh_ = a?.DateElement;
            FhirString nzzi_ = a?.PublisherElement;
            List<ContactDetail> nzzj_ = a?.Contact;
            Markdown nzzk_ = a?.DescriptionElement;
            List<Annotation> nzzl_ = a?.Note;
            List<UsageContext> nzzm_ = a?.UseContext;
            List<CodeableConcept> nzzn_ = a?.Jurisdiction;
            Markdown nzzo_ = a?.CopyrightElement;
            Date nzzp_ = a?.ApprovalDateElement;
            Date nzzq_ = a?.LastReviewDateElement;
            Period nzzr_ = a?.EffectivePeriod;
            List<CodeableConcept> nzzs_ = a?.Topic;
            List<ContactDetail> nzzt_ = a?.Author;
            List<ContactDetail> nzzu_ = a?.Editor;
            List<ContactDetail> nzzv_ = a?.Reviewer;
            List<ContactDetail> nzzw_ = a?.Endorser;
            List<RelatedArtifact> nzzx_ = a?.RelatedArtifact;
            Code<VariableTypeCode> nzzy_ = a?.TypeElement;
            List<EvidenceVariable.CharacteristicComponent> nzzz_ = a?.Characteristic;
            EvidenceVariable ozza_ = new EvidenceVariable
            {
                UrlElement = mzzz_,
                Identifier = new List<Identifier>((IEnumerable<Identifier>)nzza_),
                VersionElement = nzzb_,
                NameElement = nzzc_,
                TitleElement = nzzd_,
                ShortTitleElement = nzze_,
                SubtitleElement = nzzf_,
                StatusElement = nzzg_,
                DateElement = nzzh_,
                PublisherElement = nzzi_,
                Contact = new List<ContactDetail>((IEnumerable<ContactDetail>)nzzj_),
                DescriptionElement = nzzk_,
                Note = new List<Annotation>((IEnumerable<Annotation>)nzzl_),
                UseContext = new List<UsageContext>((IEnumerable<UsageContext>)nzzm_),
                Jurisdiction = new List<CodeableConcept>((IEnumerable<CodeableConcept>)nzzn_),
                CopyrightElement = nzzo_,
                ApprovalDateElement = nzzp_,
                LastReviewDateElement = nzzq_,
                EffectivePeriod = nzzr_,
                Topic = new List<CodeableConcept>((IEnumerable<CodeableConcept>)nzzs_),
                Author = new List<ContactDetail>((IEnumerable<ContactDetail>)nzzt_),
                Editor = new List<ContactDetail>((IEnumerable<ContactDetail>)nzzu_),
                Reviewer = new List<ContactDetail>((IEnumerable<ContactDetail>)nzzv_),
                Endorser = new List<ContactDetail>((IEnumerable<ContactDetail>)nzzw_),
                RelatedArtifact = new List<RelatedArtifact>((IEnumerable<RelatedArtifact>)nzzx_),
                TypeElement = nzzy_,
                Characteristic = new List<EvidenceVariable.CharacteristicComponent>((IEnumerable<EvidenceVariable.CharacteristicComponent>)nzzz_),
            };

            return ozza_;
        };
        IEnumerable<EvidenceVariable> mzzw_ = context.Operators.Select<EvidenceVariable, EvidenceVariable>((IEnumerable<EvidenceVariable>)mzzu_, mzzv_);
        IEnumerable<EvidenceVariable> mzzx_ = context.Operators.Distinct<EvidenceVariable>(mzzw_);
        EvidenceVariable mzzy_ = context.Operators.SingletonFrom<EvidenceVariable>(mzzx_);

        return mzzy_;
    }


    [CqlExpressionDefinition("ExplanationOfBenefitResource")]
    public ExplanationOfBenefit ExplanationOfBenefitResource(CqlContext context, ExplanationOfBenefit arg)
    {
        ExplanationOfBenefit[] ozzb_ = [
            arg,
        ];
        ExplanationOfBenefit ozzc_(ExplanationOfBenefit a)
        {
            List<Identifier> ozzg_ = a?.Identifier;
            Code<ExplanationOfBenefit.ExplanationOfBenefitStatus> ozzh_ = a?.StatusElement;
            CodeableConcept ozzi_ = a?.Type;
            CodeableConcept ozzj_ = a?.SubType;
            Code<ClaimUseCode> ozzk_ = a?.UseElement;
            ResourceReference ozzl_ = a?.Patient;
            Period ozzm_ = a?.BillablePeriod;
            FhirDateTime ozzn_ = a?.CreatedElement;
            ResourceReference ozzo_ = a?.Enterer;
            ResourceReference ozzp_ = a?.Insurer;
            ResourceReference ozzq_ = a?.Provider;
            CodeableConcept ozzr_ = a?.Priority;
            CodeableConcept ozzs_ = a?.FundsReserveRequested;
            CodeableConcept ozzt_ = a?.FundsReserve;
            List<ExplanationOfBenefit.RelatedClaimComponent> ozzu_ = a?.Related;
            ResourceReference ozzv_ = a?.Prescription;
            ResourceReference ozzw_ = a?.OriginalPrescription;
            ExplanationOfBenefit.PayeeComponent ozzx_ = a?.Payee;
            ResourceReference ozzy_ = a?.Referral;
            ResourceReference ozzz_ = a?.Facility;
            ResourceReference pzza_ = a?.Claim;
            ResourceReference pzzb_ = a?.ClaimResponse;
            Code<ClaimProcessingCodes> pzzc_ = a?.OutcomeElement;
            FhirString pzzd_ = a?.DispositionElement;
            List<FhirString> pzze_ = a?.PreAuthRefElement;
            List<Period> pzzf_ = a?.PreAuthRefPeriod;
            List<ExplanationOfBenefit.CareTeamComponent> pzzg_ = a?.CareTeam;
            List<ExplanationOfBenefit.SupportingInformationComponent> pzzh_ = a?.SupportingInfo;
            List<ExplanationOfBenefit.DiagnosisComponent> pzzi_ = a?.Diagnosis;
            List<ExplanationOfBenefit.ProcedureComponent> pzzj_ = a?.Procedure;
            PositiveInt pzzk_ = a?.PrecedenceElement;
            Integer pzzl_ = context.Operators.Convert<Integer>(pzzk_);
            PositiveInt pzzm_ = context.Operators.Convert<PositiveInt>(pzzl_);
            List<ExplanationOfBenefit.InsuranceComponent> pzzn_ = a?.Insurance;
            ExplanationOfBenefit.AccidentComponent pzzo_ = a?.Accident;
            List<ExplanationOfBenefit.ItemComponent> pzzp_ = a?.Item;
            List<ExplanationOfBenefit.AddedItemComponent> pzzq_ = a?.AddItem;
            List<ExplanationOfBenefit.AdjudicationComponent> pzzr_ = a?.Adjudication;
            List<ExplanationOfBenefit.TotalComponent> pzzs_ = a?.Total;
            ExplanationOfBenefit.PaymentComponent pzzt_ = a?.Payment;
            CodeableConcept pzzu_ = a?.FormCode;
            Attachment pzzv_ = a?.Form;
            List<ExplanationOfBenefit.NoteComponent> pzzw_ = a?.ProcessNote;
            Period pzzx_ = a?.BenefitPeriod;
            List<ExplanationOfBenefit.BenefitBalanceComponent> pzzy_ = a?.BenefitBalance;
            ExplanationOfBenefit pzzz_ = new ExplanationOfBenefit
            {
                Identifier = new List<Identifier>((IEnumerable<Identifier>)ozzg_),
                StatusElement = ozzh_,
                Type = ozzi_,
                SubType = ozzj_,
                UseElement = ozzk_,
                Patient = ozzl_,
                BillablePeriod = ozzm_,
                CreatedElement = ozzn_,
                Enterer = ozzo_,
                Insurer = ozzp_,
                Provider = ozzq_,
                Priority = ozzr_,
                FundsReserveRequested = ozzs_,
                FundsReserve = ozzt_,
                Related = new List<ExplanationOfBenefit.RelatedClaimComponent>((IEnumerable<ExplanationOfBenefit.RelatedClaimComponent>)ozzu_),
                Prescription = ozzv_,
                OriginalPrescription = ozzw_,
                Payee = ozzx_,
                Referral = ozzy_,
                Facility = ozzz_,
                Claim = pzza_,
                ClaimResponse = pzzb_,
                OutcomeElement = pzzc_,
                DispositionElement = pzzd_,
                PreAuthRefElement = new List<FhirString>((IEnumerable<FhirString>)pzze_),
                PreAuthRefPeriod = new List<Period>((IEnumerable<Period>)pzzf_),
                CareTeam = new List<ExplanationOfBenefit.CareTeamComponent>((IEnumerable<ExplanationOfBenefit.CareTeamComponent>)pzzg_),
                SupportingInfo = new List<ExplanationOfBenefit.SupportingInformationComponent>((IEnumerable<ExplanationOfBenefit.SupportingInformationComponent>)pzzh_),
                Diagnosis = new List<ExplanationOfBenefit.DiagnosisComponent>((IEnumerable<ExplanationOfBenefit.DiagnosisComponent>)pzzi_),
                Procedure = new List<ExplanationOfBenefit.ProcedureComponent>((IEnumerable<ExplanationOfBenefit.ProcedureComponent>)pzzj_),
                PrecedenceElement = pzzm_,
                Insurance = new List<ExplanationOfBenefit.InsuranceComponent>((IEnumerable<ExplanationOfBenefit.InsuranceComponent>)pzzn_),
                Accident = pzzo_,
                Item = new List<ExplanationOfBenefit.ItemComponent>((IEnumerable<ExplanationOfBenefit.ItemComponent>)pzzp_),
                AddItem = new List<ExplanationOfBenefit.AddedItemComponent>((IEnumerable<ExplanationOfBenefit.AddedItemComponent>)pzzq_),
                Adjudication = new List<ExplanationOfBenefit.AdjudicationComponent>((IEnumerable<ExplanationOfBenefit.AdjudicationComponent>)pzzr_),
                Total = new List<ExplanationOfBenefit.TotalComponent>((IEnumerable<ExplanationOfBenefit.TotalComponent>)pzzs_),
                Payment = pzzt_,
                FormCode = pzzu_,
                Form = pzzv_,
                ProcessNote = new List<ExplanationOfBenefit.NoteComponent>((IEnumerable<ExplanationOfBenefit.NoteComponent>)pzzw_),
                BenefitPeriod = pzzx_,
                BenefitBalance = new List<ExplanationOfBenefit.BenefitBalanceComponent>((IEnumerable<ExplanationOfBenefit.BenefitBalanceComponent>)pzzy_),
            };

            return pzzz_;
        };
        IEnumerable<ExplanationOfBenefit> ozzd_ = context.Operators.Select<ExplanationOfBenefit, ExplanationOfBenefit>((IEnumerable<ExplanationOfBenefit>)ozzb_, ozzc_);
        IEnumerable<ExplanationOfBenefit> ozze_ = context.Operators.Distinct<ExplanationOfBenefit>(ozzd_);
        ExplanationOfBenefit ozzf_ = context.Operators.SingletonFrom<ExplanationOfBenefit>(ozze_);

        return ozzf_;
    }


    [CqlExpressionDefinition("FamilyMemberHistoryResource")]
    public FamilyMemberHistory FamilyMemberHistoryResource(CqlContext context, FamilyMemberHistory arg)
    {
        FamilyMemberHistory[] qzza_ = [
            arg,
        ];
        FamilyMemberHistory qzzb_(FamilyMemberHistory a)
        {
            List<Identifier> qzzf_ = a?.Identifier;
            List<Canonical> qzzg_ = a?.InstantiatesCanonicalElement;
            List<FhirUri> qzzh_ = a?.InstantiatesUriElement;
            Code<FamilyMemberHistory.FamilyHistoryStatus> qzzi_ = a?.StatusElement;
            CodeableConcept qzzj_ = a?.DataAbsentReason;
            ResourceReference qzzk_ = a?.Patient;
            FhirDateTime qzzl_ = a?.DateElement;
            FhirString qzzm_ = a?.NameElement;
            CodeableConcept qzzn_ = a?.Relationship;
            CodeableConcept qzzo_ = a?.Sex;
            DataType qzzp_ = a?.Born;
            DataType qzzq_ = a?.Age;
            FhirBoolean qzzr_ = a?.EstimatedAgeElement;
            DataType qzzs_ = a?.Deceased;
            List<CodeableConcept> qzzt_ = a?.ReasonCode;
            List<ResourceReference> qzzu_ = a?.ReasonReference;
            List<Annotation> qzzv_ = a?.Note;
            List<FamilyMemberHistory.ConditionComponent> qzzw_ = a?.Condition;
            FamilyMemberHistory qzzx_ = new FamilyMemberHistory
            {
                Identifier = new List<Identifier>((IEnumerable<Identifier>)qzzf_),
                InstantiatesCanonicalElement = new List<Canonical>((IEnumerable<Canonical>)qzzg_),
                InstantiatesUriElement = new List<FhirUri>((IEnumerable<FhirUri>)qzzh_),
                StatusElement = qzzi_,
                DataAbsentReason = qzzj_,
                Patient = qzzk_,
                DateElement = qzzl_,
                NameElement = qzzm_,
                Relationship = qzzn_,
                Sex = qzzo_,
                Born = (DataType)qzzp_,
                Age = (DataType)qzzq_,
                EstimatedAgeElement = qzzr_,
                Deceased = (DataType)qzzs_,
                ReasonCode = new List<CodeableConcept>((IEnumerable<CodeableConcept>)qzzt_),
                ReasonReference = new List<ResourceReference>((IEnumerable<ResourceReference>)qzzu_),
                Note = new List<Annotation>((IEnumerable<Annotation>)qzzv_),
                Condition = new List<FamilyMemberHistory.ConditionComponent>((IEnumerable<FamilyMemberHistory.ConditionComponent>)qzzw_),
            };

            return qzzx_;
        };
        IEnumerable<FamilyMemberHistory> qzzc_ = context.Operators.Select<FamilyMemberHistory, FamilyMemberHistory>((IEnumerable<FamilyMemberHistory>)qzza_, qzzb_);
        IEnumerable<FamilyMemberHistory> qzzd_ = context.Operators.Distinct<FamilyMemberHistory>(qzzc_);
        FamilyMemberHistory qzze_ = context.Operators.SingletonFrom<FamilyMemberHistory>(qzzd_);

        return qzze_;
    }


    [CqlExpressionDefinition("FlagResource")]
    public Flag FlagResource(CqlContext context, Flag arg)
    {
        Flag[] qzzy_ = [
            arg,
        ];
        Flag qzzz_(Flag a)
        {
            List<Identifier> rzzd_ = a?.Identifier;
            Code<Flag.FlagStatus> rzze_ = a?.StatusElement;
            List<CodeableConcept> rzzf_ = a?.Category;
            CodeableConcept rzzg_ = a?.Code;
            ResourceReference rzzh_ = a?.Subject;
            Period rzzi_ = a?.Period;
            ResourceReference rzzj_ = a?.Encounter;
            ResourceReference rzzk_ = a?.Author;
            Flag rzzl_ = new Flag
            {
                Identifier = new List<Identifier>((IEnumerable<Identifier>)rzzd_),
                StatusElement = rzze_,
                Category = new List<CodeableConcept>((IEnumerable<CodeableConcept>)rzzf_),
                Code = rzzg_,
                Subject = rzzh_,
                Period = rzzi_,
                Encounter = rzzj_,
                Author = rzzk_,
            };

            return rzzl_;
        };
        IEnumerable<Flag> rzza_ = context.Operators.Select<Flag, Flag>((IEnumerable<Flag>)qzzy_, qzzz_);
        IEnumerable<Flag> rzzb_ = context.Operators.Distinct<Flag>(rzza_);
        Flag rzzc_ = context.Operators.SingletonFrom<Flag>(rzzb_);

        return rzzc_;
    }


    [CqlExpressionDefinition("GoalResource")]
    public Goal GoalResource(CqlContext context, Goal arg)
    {
        Goal[] rzzm_ = [
            arg,
        ];
        Goal rzzn_(Goal a)
        {
            List<Identifier> rzzr_ = a?.Identifier;
            Code<Goal.GoalLifecycleStatus> rzzs_ = a?.LifecycleStatusElement;
            CodeableConcept rzzt_ = a?.AchievementStatus;
            List<CodeableConcept> rzzu_ = a?.Category;
            CodeableConcept rzzv_ = a?.Priority;
            CodeableConcept rzzw_ = a?.Description;
            ResourceReference rzzx_ = a?.Subject;
            DataType rzzy_ = a?.Start;
            List<Goal.TargetComponent> rzzz_ = a?.Target;
            Date szza_ = a?.StatusDateElement;
            FhirString szzb_ = a?.StatusReasonElement;
            ResourceReference szzc_ = a?.ExpressedBy;
            List<ResourceReference> szzd_ = a?.Addresses;
            List<Annotation> szze_ = a?.Note;
            List<CodeableConcept> szzf_ = a?.OutcomeCode;
            List<ResourceReference> szzg_ = a?.OutcomeReference;
            Goal szzh_ = new Goal
            {
                Identifier = new List<Identifier>((IEnumerable<Identifier>)rzzr_),
                LifecycleStatusElement = rzzs_,
                AchievementStatus = rzzt_,
                Category = new List<CodeableConcept>((IEnumerable<CodeableConcept>)rzzu_),
                Priority = rzzv_,
                Description = rzzw_,
                Subject = rzzx_,
                Start = (DataType)rzzy_,
                Target = new List<Goal.TargetComponent>((IEnumerable<Goal.TargetComponent>)rzzz_),
                StatusDateElement = szza_,
                StatusReasonElement = szzb_,
                ExpressedBy = szzc_,
                Addresses = new List<ResourceReference>((IEnumerable<ResourceReference>)szzd_),
                Note = new List<Annotation>((IEnumerable<Annotation>)szze_),
                OutcomeCode = new List<CodeableConcept>((IEnumerable<CodeableConcept>)szzf_),
                OutcomeReference = new List<ResourceReference>((IEnumerable<ResourceReference>)szzg_),
            };

            return szzh_;
        };
        IEnumerable<Goal> rzzo_ = context.Operators.Select<Goal, Goal>((IEnumerable<Goal>)rzzm_, rzzn_);
        IEnumerable<Goal> rzzp_ = context.Operators.Distinct<Goal>(rzzo_);
        Goal rzzq_ = context.Operators.SingletonFrom<Goal>(rzzp_);

        return rzzq_;
    }


    [CqlExpressionDefinition("GroupResource")]
    public Group GroupResource(CqlContext context, Group arg)
    {
        Group[] szzi_ = [
            arg,
        ];
        Group szzj_(Group a)
        {
            List<Identifier> szzn_ = a?.Identifier;
            FhirBoolean szzo_ = a?.ActiveElement;
            Code<Group.GroupType> szzp_ = a?.TypeElement;
            FhirBoolean szzq_ = a?.ActualElement;
            CodeableConcept szzr_ = a?.Code;
            FhirString szzs_ = a?.NameElement;
            UnsignedInt szzt_ = a?.QuantityElement;
            Integer szzu_ = context.Operators.Convert<Integer>(szzt_);
            UnsignedInt szzv_ = context.Operators.Convert<UnsignedInt>(szzu_);
            ResourceReference szzw_ = a?.ManagingEntity;
            List<Group.CharacteristicComponent> szzx_ = a?.Characteristic;
            List<Group.MemberComponent> szzy_ = a?.Member;
            Group szzz_ = new Group
            {
                Identifier = new List<Identifier>((IEnumerable<Identifier>)szzn_),
                ActiveElement = szzo_,
                TypeElement = szzp_,
                ActualElement = szzq_,
                Code = szzr_,
                NameElement = szzs_,
                QuantityElement = szzv_,
                ManagingEntity = szzw_,
                Characteristic = new List<Group.CharacteristicComponent>((IEnumerable<Group.CharacteristicComponent>)szzx_),
                Member = new List<Group.MemberComponent>((IEnumerable<Group.MemberComponent>)szzy_),
            };

            return szzz_;
        };
        IEnumerable<Group> szzk_ = context.Operators.Select<Group, Group>((IEnumerable<Group>)szzi_, szzj_);
        IEnumerable<Group> szzl_ = context.Operators.Distinct<Group>(szzk_);
        Group szzm_ = context.Operators.SingletonFrom<Group>(szzl_);

        return szzm_;
    }


    [CqlExpressionDefinition("GuidanceResponseResource")]
    public GuidanceResponse GuidanceResponseResource(CqlContext context, GuidanceResponse arg)
    {
        GuidanceResponse[] tzza_ = [
            arg,
        ];
        GuidanceResponse tzzb_(GuidanceResponse a)
        {
            Identifier tzzf_ = a?.RequestIdentifier;
            List<Identifier> tzzg_ = a?.Identifier;
            DataType tzzh_ = a?.Module;
            Code<GuidanceResponse.GuidanceResponseStatus> tzzi_ = a?.StatusElement;
            ResourceReference tzzj_ = a?.Subject;
            ResourceReference tzzk_ = a?.Encounter;
            FhirDateTime tzzl_ = a?.OccurrenceDateTimeElement;
            ResourceReference tzzm_ = a?.Performer;
            List<CodeableConcept> tzzn_ = a?.ReasonCode;
            List<ResourceReference> tzzo_ = a?.ReasonReference;
            List<Annotation> tzzp_ = a?.Note;
            List<ResourceReference> tzzq_ = a?.EvaluationMessage;
            ResourceReference tzzr_ = a?.OutputParameters;
            ResourceReference tzzs_ = a?.Result;
            List<DataRequirement> tzzt_ = a?.DataRequirement;
            GuidanceResponse tzzu_ = new GuidanceResponse
            {
                RequestIdentifier = tzzf_,
                Identifier = new List<Identifier>((IEnumerable<Identifier>)tzzg_),
                Module = (DataType)tzzh_,
                StatusElement = tzzi_,
                Subject = tzzj_,
                Encounter = tzzk_,
                OccurrenceDateTimeElement = tzzl_,
                Performer = tzzm_,
                ReasonCode = new List<CodeableConcept>((IEnumerable<CodeableConcept>)tzzn_),
                ReasonReference = new List<ResourceReference>((IEnumerable<ResourceReference>)tzzo_),
                Note = new List<Annotation>((IEnumerable<Annotation>)tzzp_),
                EvaluationMessage = new List<ResourceReference>((IEnumerable<ResourceReference>)tzzq_),
                OutputParameters = tzzr_,
                Result = tzzs_,
                DataRequirement = new List<DataRequirement>((IEnumerable<DataRequirement>)tzzt_),
            };

            return tzzu_;
        };
        IEnumerable<GuidanceResponse> tzzc_ = context.Operators.Select<GuidanceResponse, GuidanceResponse>((IEnumerable<GuidanceResponse>)tzza_, tzzb_);
        IEnumerable<GuidanceResponse> tzzd_ = context.Operators.Distinct<GuidanceResponse>(tzzc_);
        GuidanceResponse tzze_ = context.Operators.SingletonFrom<GuidanceResponse>(tzzd_);

        return tzze_;
    }


    [CqlExpressionDefinition("HealthcareServiceResource")]
    public HealthcareService HealthcareServiceResource(CqlContext context, HealthcareService arg)
    {
        HealthcareService[] tzzv_ = [
            arg,
        ];
        HealthcareService tzzw_(HealthcareService a)
        {
            List<Identifier> uzza_ = a?.Identifier;
            FhirBoolean uzzb_ = a?.ActiveElement;
            ResourceReference uzzc_ = a?.ProvidedBy;
            List<CodeableConcept> uzzd_ = a?.Category;
            List<CodeableConcept> uzze_ = a?.Type;
            List<CodeableConcept> uzzf_ = a?.Specialty;
            List<ResourceReference> uzzg_ = a?.Location;
            FhirString uzzh_ = a?.NameElement;
            FhirString uzzi_ = a?.CommentElement;
            Markdown uzzj_ = a?.ExtraDetailsElement;
            Attachment uzzk_ = a?.Photo;
            List<ContactPoint> uzzl_ = a?.Telecom;
            List<ResourceReference> uzzm_ = a?.CoverageArea;
            List<CodeableConcept> uzzn_ = a?.ServiceProvisionCode;
            List<HealthcareService.EligibilityComponent> uzzo_ = a?.Eligibility;
            List<CodeableConcept> uzzp_ = a?.Program;
            List<CodeableConcept> uzzq_ = a?.Characteristic;
            List<CodeableConcept> uzzr_ = a?.Communication;
            List<CodeableConcept> uzzs_ = a?.ReferralMethod;
            FhirBoolean uzzt_ = a?.AppointmentRequiredElement;
            List<HealthcareService.AvailableTimeComponent> uzzu_ = a?.AvailableTime;
            List<HealthcareService.NotAvailableComponent> uzzv_ = a?.NotAvailable;
            FhirString uzzw_ = a?.AvailabilityExceptionsElement;
            List<ResourceReference> uzzx_ = a?.Endpoint;
            HealthcareService uzzy_ = new HealthcareService
            {
                Identifier = new List<Identifier>((IEnumerable<Identifier>)uzza_),
                ActiveElement = uzzb_,
                ProvidedBy = uzzc_,
                Category = new List<CodeableConcept>((IEnumerable<CodeableConcept>)uzzd_),
                Type = new List<CodeableConcept>((IEnumerable<CodeableConcept>)uzze_),
                Specialty = new List<CodeableConcept>((IEnumerable<CodeableConcept>)uzzf_),
                Location = new List<ResourceReference>((IEnumerable<ResourceReference>)uzzg_),
                NameElement = uzzh_,
                CommentElement = uzzi_,
                ExtraDetailsElement = uzzj_,
                Photo = uzzk_,
                Telecom = new List<ContactPoint>((IEnumerable<ContactPoint>)uzzl_),
                CoverageArea = new List<ResourceReference>((IEnumerable<ResourceReference>)uzzm_),
                ServiceProvisionCode = new List<CodeableConcept>((IEnumerable<CodeableConcept>)uzzn_),
                Eligibility = new List<HealthcareService.EligibilityComponent>((IEnumerable<HealthcareService.EligibilityComponent>)uzzo_),
                Program = new List<CodeableConcept>((IEnumerable<CodeableConcept>)uzzp_),
                Characteristic = new List<CodeableConcept>((IEnumerable<CodeableConcept>)uzzq_),
                Communication = new List<CodeableConcept>((IEnumerable<CodeableConcept>)uzzr_),
                ReferralMethod = new List<CodeableConcept>((IEnumerable<CodeableConcept>)uzzs_),
                AppointmentRequiredElement = uzzt_,
                AvailableTime = new List<HealthcareService.AvailableTimeComponent>((IEnumerable<HealthcareService.AvailableTimeComponent>)uzzu_),
                NotAvailable = new List<HealthcareService.NotAvailableComponent>((IEnumerable<HealthcareService.NotAvailableComponent>)uzzv_),
                AvailabilityExceptionsElement = uzzw_,
                Endpoint = new List<ResourceReference>((IEnumerable<ResourceReference>)uzzx_),
            };

            return uzzy_;
        };
        IEnumerable<HealthcareService> tzzx_ = context.Operators.Select<HealthcareService, HealthcareService>((IEnumerable<HealthcareService>)tzzv_, tzzw_);
        IEnumerable<HealthcareService> tzzy_ = context.Operators.Distinct<HealthcareService>(tzzx_);
        HealthcareService tzzz_ = context.Operators.SingletonFrom<HealthcareService>(tzzy_);

        return tzzz_;
    }


    [CqlExpressionDefinition("ImagingStudyResource")]
    public ImagingStudy ImagingStudyResource(CqlContext context, ImagingStudy arg)
    {
        ImagingStudy[] uzzz_ = [
            arg,
        ];
        ImagingStudy vzza_(ImagingStudy a)
        {
            List<Identifier> vzze_ = a?.Identifier;
            Code<ImagingStudy.ImagingStudyStatus> vzzf_ = a?.StatusElement;
            List<Coding> vzzg_ = a?.Modality;
            ResourceReference vzzh_ = a?.Subject;
            ResourceReference vzzi_ = a?.Encounter;
            FhirDateTime vzzj_ = a?.StartedElement;
            List<ResourceReference> vzzk_ = a?.BasedOn;
            ResourceReference vzzl_ = a?.Referrer;
            List<ResourceReference> vzzm_ = a?.Interpreter;
            List<ResourceReference> vzzn_ = a?.Endpoint;
            UnsignedInt vzzo_ = a?.NumberOfSeriesElement;
            Integer vzzp_ = context.Operators.Convert<Integer>(vzzo_);
            UnsignedInt vzzq_ = context.Operators.Convert<UnsignedInt>(vzzp_);
            UnsignedInt vzzr_ = a?.NumberOfInstancesElement;
            Integer vzzs_ = context.Operators.Convert<Integer>(vzzr_);
            UnsignedInt vzzt_ = context.Operators.Convert<UnsignedInt>(vzzs_);
            ResourceReference vzzu_ = a?.ProcedureReference;
            List<CodeableConcept> vzzv_ = a?.ProcedureCode;
            ResourceReference vzzw_ = a?.Location;
            List<CodeableConcept> vzzx_ = a?.ReasonCode;
            List<ResourceReference> vzzy_ = a?.ReasonReference;
            List<Annotation> vzzz_ = a?.Note;
            FhirString wzza_ = a?.DescriptionElement;
            List<ImagingStudy.SeriesComponent> wzzb_ = a?.Series;
            ImagingStudy wzzc_ = new ImagingStudy
            {
                Identifier = new List<Identifier>((IEnumerable<Identifier>)vzze_),
                StatusElement = vzzf_,
                Modality = new List<Coding>((IEnumerable<Coding>)vzzg_),
                Subject = vzzh_,
                Encounter = vzzi_,
                StartedElement = vzzj_,
                BasedOn = new List<ResourceReference>((IEnumerable<ResourceReference>)vzzk_),
                Referrer = vzzl_,
                Interpreter = new List<ResourceReference>((IEnumerable<ResourceReference>)vzzm_),
                Endpoint = new List<ResourceReference>((IEnumerable<ResourceReference>)vzzn_),
                NumberOfSeriesElement = vzzq_,
                NumberOfInstancesElement = vzzt_,
                ProcedureReference = vzzu_,
                ProcedureCode = new List<CodeableConcept>((IEnumerable<CodeableConcept>)vzzv_),
                Location = vzzw_,
                ReasonCode = new List<CodeableConcept>((IEnumerable<CodeableConcept>)vzzx_),
                ReasonReference = new List<ResourceReference>((IEnumerable<ResourceReference>)vzzy_),
                Note = new List<Annotation>((IEnumerable<Annotation>)vzzz_),
                DescriptionElement = wzza_,
                Series = new List<ImagingStudy.SeriesComponent>((IEnumerable<ImagingStudy.SeriesComponent>)wzzb_),
            };

            return wzzc_;
        };
        IEnumerable<ImagingStudy> vzzb_ = context.Operators.Select<ImagingStudy, ImagingStudy>((IEnumerable<ImagingStudy>)uzzz_, vzza_);
        IEnumerable<ImagingStudy> vzzc_ = context.Operators.Distinct<ImagingStudy>(vzzb_);
        ImagingStudy vzzd_ = context.Operators.SingletonFrom<ImagingStudy>(vzzc_);

        return vzzd_;
    }


    [CqlExpressionDefinition("ImmunizationResource")]
    public Immunization ImmunizationResource(CqlContext context, Immunization arg)
    {
        Immunization[] wzzd_ = [
            arg,
        ];
        Immunization wzze_(Immunization a)
        {
            List<Identifier> wzzi_ = a?.Identifier;
            Code<Immunization.ImmunizationStatusCodes> wzzj_ = a?.StatusElement;
            CodeableConcept wzzk_ = a?.StatusReason;
            CodeableConcept wzzl_ = a?.VaccineCode;
            ResourceReference wzzm_ = a?.Patient;
            ResourceReference wzzn_ = a?.Encounter;
            DataType wzzo_ = a?.Occurrence;
            FhirDateTime wzzp_ = a?.RecordedElement;
            FhirBoolean wzzq_ = a?.PrimarySourceElement;
            CodeableConcept wzzr_ = a?.ReportOrigin;
            ResourceReference wzzs_ = a?.Location;
            ResourceReference wzzt_ = a?.Manufacturer;
            FhirString wzzu_ = a?.LotNumberElement;
            Date wzzv_ = a?.ExpirationDateElement;
            CodeableConcept wzzw_ = a?.Site;
            CodeableConcept wzzx_ = a?.Route;
            Quantity wzzy_ = a?.DoseQuantity;
            List<Immunization.PerformerComponent> wzzz_ = a?.Performer;
            List<Annotation> xzza_ = a?.Note;
            List<CodeableConcept> xzzb_ = a?.ReasonCode;
            List<ResourceReference> xzzc_ = a?.ReasonReference;
            FhirBoolean xzzd_ = a?.IsSubpotentElement;
            List<CodeableConcept> xzze_ = a?.SubpotentReason;
            List<Immunization.EducationComponent> xzzf_ = a?.Education;
            List<CodeableConcept> xzzg_ = a?.ProgramEligibility;
            CodeableConcept xzzh_ = a?.FundingSource;
            List<Immunization.ReactionComponent> xzzi_ = a?.Reaction;
            List<Immunization.ProtocolAppliedComponent> xzzj_ = a?.ProtocolApplied;
            Immunization xzzk_ = new Immunization
            {
                Identifier = new List<Identifier>((IEnumerable<Identifier>)wzzi_),
                StatusElement = wzzj_,
                StatusReason = wzzk_,
                VaccineCode = wzzl_,
                Patient = wzzm_,
                Encounter = wzzn_,
                Occurrence = (DataType)wzzo_,
                RecordedElement = wzzp_,
                PrimarySourceElement = wzzq_,
                ReportOrigin = wzzr_,
                Location = wzzs_,
                Manufacturer = wzzt_,
                LotNumberElement = wzzu_,
                ExpirationDateElement = wzzv_,
                Site = wzzw_,
                Route = wzzx_,
                DoseQuantity = wzzy_,
                Performer = new List<Immunization.PerformerComponent>((IEnumerable<Immunization.PerformerComponent>)wzzz_),
                Note = new List<Annotation>((IEnumerable<Annotation>)xzza_),
                ReasonCode = new List<CodeableConcept>((IEnumerable<CodeableConcept>)xzzb_),
                ReasonReference = new List<ResourceReference>((IEnumerable<ResourceReference>)xzzc_),
                IsSubpotentElement = xzzd_,
                SubpotentReason = new List<CodeableConcept>((IEnumerable<CodeableConcept>)xzze_),
                Education = new List<Immunization.EducationComponent>((IEnumerable<Immunization.EducationComponent>)xzzf_),
                ProgramEligibility = new List<CodeableConcept>((IEnumerable<CodeableConcept>)xzzg_),
                FundingSource = xzzh_,
                Reaction = new List<Immunization.ReactionComponent>((IEnumerable<Immunization.ReactionComponent>)xzzi_),
                ProtocolApplied = new List<Immunization.ProtocolAppliedComponent>((IEnumerable<Immunization.ProtocolAppliedComponent>)xzzj_),
            };

            return xzzk_;
        };
        IEnumerable<Immunization> wzzf_ = context.Operators.Select<Immunization, Immunization>((IEnumerable<Immunization>)wzzd_, wzze_);
        IEnumerable<Immunization> wzzg_ = context.Operators.Distinct<Immunization>(wzzf_);
        Immunization wzzh_ = context.Operators.SingletonFrom<Immunization>(wzzg_);

        return wzzh_;
    }


    [CqlExpressionDefinition("ImmunizationEvaluationResource")]
    public ImmunizationEvaluation ImmunizationEvaluationResource(CqlContext context, ImmunizationEvaluation arg)
    {
        ImmunizationEvaluation[] xzzl_ = [
            arg,
        ];
        ImmunizationEvaluation xzzm_(ImmunizationEvaluation a)
        {
            List<Identifier> xzzq_ = a?.Identifier;
            Code<ImmunizationEvaluation.ImmunizationEvaluationStatusCodes> xzzr_ = a?.StatusElement;
            ResourceReference xzzs_ = a?.Patient;
            FhirDateTime xzzt_ = a?.DateElement;
            ResourceReference xzzu_ = a?.Authority;
            CodeableConcept xzzv_ = a?.TargetDisease;
            ResourceReference xzzw_ = a?.ImmunizationEvent;
            CodeableConcept xzzx_ = a?.DoseStatus;
            List<CodeableConcept> xzzy_ = a?.DoseStatusReason;
            FhirString xzzz_ = a?.DescriptionElement;
            FhirString yzza_ = a?.SeriesElement;
            DataType yzzb_ = a?.DoseNumber;
            DataType yzzc_ = a?.SeriesDoses;
            ImmunizationEvaluation yzzd_ = new ImmunizationEvaluation
            {
                Identifier = new List<Identifier>((IEnumerable<Identifier>)xzzq_),
                StatusElement = xzzr_,
                Patient = xzzs_,
                DateElement = xzzt_,
                Authority = xzzu_,
                TargetDisease = xzzv_,
                ImmunizationEvent = xzzw_,
                DoseStatus = xzzx_,
                DoseStatusReason = new List<CodeableConcept>((IEnumerable<CodeableConcept>)xzzy_),
                DescriptionElement = xzzz_,
                SeriesElement = yzza_,
                DoseNumber = (DataType)yzzb_,
                SeriesDoses = (DataType)yzzc_,
            };

            return yzzd_;
        };
        IEnumerable<ImmunizationEvaluation> xzzn_ = context.Operators.Select<ImmunizationEvaluation, ImmunizationEvaluation>((IEnumerable<ImmunizationEvaluation>)xzzl_, xzzm_);
        IEnumerable<ImmunizationEvaluation> xzzo_ = context.Operators.Distinct<ImmunizationEvaluation>(xzzn_);
        ImmunizationEvaluation xzzp_ = context.Operators.SingletonFrom<ImmunizationEvaluation>(xzzo_);

        return xzzp_;
    }


    [CqlExpressionDefinition("ImmunizationRecommendationResource")]
    public ImmunizationRecommendation ImmunizationRecommendationResource(CqlContext context, ImmunizationRecommendation arg)
    {
        ImmunizationRecommendation[] yzze_ = [
            arg,
        ];
        ImmunizationRecommendation yzzf_(ImmunizationRecommendation a)
        {
            List<Identifier> yzzj_ = a?.Identifier;
            ResourceReference yzzk_ = a?.Patient;
            FhirDateTime yzzl_ = a?.DateElement;
            ResourceReference yzzm_ = a?.Authority;
            List<ImmunizationRecommendation.RecommendationComponent> yzzn_ = a?.Recommendation;
            ImmunizationRecommendation yzzo_ = new ImmunizationRecommendation
            {
                Identifier = new List<Identifier>((IEnumerable<Identifier>)yzzj_),
                Patient = yzzk_,
                DateElement = yzzl_,
                Authority = yzzm_,
                Recommendation = new List<ImmunizationRecommendation.RecommendationComponent>((IEnumerable<ImmunizationRecommendation.RecommendationComponent>)yzzn_),
            };

            return yzzo_;
        };
        IEnumerable<ImmunizationRecommendation> yzzg_ = context.Operators.Select<ImmunizationRecommendation, ImmunizationRecommendation>((IEnumerable<ImmunizationRecommendation>)yzze_, yzzf_);
        IEnumerable<ImmunizationRecommendation> yzzh_ = context.Operators.Distinct<ImmunizationRecommendation>(yzzg_);
        ImmunizationRecommendation yzzi_ = context.Operators.SingletonFrom<ImmunizationRecommendation>(yzzh_);

        return yzzi_;
    }


    [CqlExpressionDefinition("InsurancePlanResource")]
    public InsurancePlan InsurancePlanResource(CqlContext context, InsurancePlan arg)
    {
        InsurancePlan[] yzzp_ = [
            arg,
        ];
        InsurancePlan yzzq_(InsurancePlan a)
        {
            List<Identifier> yzzu_ = a?.Identifier;
            Code<PublicationStatus> yzzv_ = a?.StatusElement;
            List<CodeableConcept> yzzw_ = a?.Type;
            FhirString yzzx_ = a?.NameElement;
            List<FhirString> yzzy_ = a?.AliasElement;
            Period yzzz_ = a?.Period;
            ResourceReference zzza_ = a?.OwnedBy;
            ResourceReference zzzb_ = a?.AdministeredBy;
            List<ResourceReference> zzzc_ = a?.CoverageArea;
            List<InsurancePlan.ContactComponent> zzzd_ = a?.Contact;
            List<ResourceReference> zzze_ = a?.Endpoint;
            List<ResourceReference> zzzf_ = a?.Network;
            List<InsurancePlan.CoverageComponent> zzzg_ = a?.Coverage;
            List<InsurancePlan.PlanComponent> zzzh_ = a?.Plan;
            InsurancePlan zzzi_ = new InsurancePlan
            {
                Identifier = new List<Identifier>((IEnumerable<Identifier>)yzzu_),
                StatusElement = yzzv_,
                Type = new List<CodeableConcept>((IEnumerable<CodeableConcept>)yzzw_),
                NameElement = yzzx_,
                AliasElement = new List<FhirString>((IEnumerable<FhirString>)yzzy_),
                Period = yzzz_,
                OwnedBy = zzza_,
                AdministeredBy = zzzb_,
                CoverageArea = new List<ResourceReference>((IEnumerable<ResourceReference>)zzzc_),
                Contact = new List<InsurancePlan.ContactComponent>((IEnumerable<InsurancePlan.ContactComponent>)zzzd_),
                Endpoint = new List<ResourceReference>((IEnumerable<ResourceReference>)zzze_),
                Network = new List<ResourceReference>((IEnumerable<ResourceReference>)zzzf_),
                Coverage = new List<InsurancePlan.CoverageComponent>((IEnumerable<InsurancePlan.CoverageComponent>)zzzg_),
                Plan = new List<InsurancePlan.PlanComponent>((IEnumerable<InsurancePlan.PlanComponent>)zzzh_),
            };

            return zzzi_;
        };
        IEnumerable<InsurancePlan> yzzr_ = context.Operators.Select<InsurancePlan, InsurancePlan>((IEnumerable<InsurancePlan>)yzzp_, yzzq_);
        IEnumerable<InsurancePlan> yzzs_ = context.Operators.Distinct<InsurancePlan>(yzzr_);
        InsurancePlan yzzt_ = context.Operators.SingletonFrom<InsurancePlan>(yzzs_);

        return yzzt_;
    }


    [CqlExpressionDefinition("InvoiceResource")]
    public Invoice InvoiceResource(CqlContext context, Invoice arg)
    {
        Invoice[] zzzj_ = [
            arg,
        ];
        Invoice zzzk_(Invoice a)
        {
            List<Identifier> zzzo_ = a?.Identifier;
            Code<Invoice.InvoiceStatus> zzzp_ = a?.StatusElement;
            FhirString zzzq_ = a?.CancelledReasonElement;
            CodeableConcept zzzr_ = a?.Type;
            ResourceReference zzzs_ = a?.Subject;
            ResourceReference zzzt_ = a?.Recipient;
            FhirDateTime zzzu_ = a?.DateElement;
            List<Invoice.ParticipantComponent> zzzv_ = a?.Participant;
            ResourceReference zzzw_ = a?.Issuer;
            ResourceReference zzzx_ = a?.Account;
            List<Invoice.LineItemComponent> zzzy_ = a?.LineItem;
            List<Invoice.PriceComponentComponent> zzzz_ = a?.TotalPriceComponent;
            Money azzza_ = a?.TotalNet;
            Money azzzb_ = a?.TotalGross;
            Markdown azzzc_ = a?.PaymentTermsElement;
            List<Annotation> azzzd_ = a?.Note;
            Invoice azzze_ = new Invoice
            {
                Identifier = new List<Identifier>((IEnumerable<Identifier>)zzzo_),
                StatusElement = zzzp_,
                CancelledReasonElement = zzzq_,
                Type = zzzr_,
                Subject = zzzs_,
                Recipient = zzzt_,
                DateElement = zzzu_,
                Participant = new List<Invoice.ParticipantComponent>((IEnumerable<Invoice.ParticipantComponent>)zzzv_),
                Issuer = zzzw_,
                Account = zzzx_,
                LineItem = new List<Invoice.LineItemComponent>((IEnumerable<Invoice.LineItemComponent>)zzzy_),
                TotalPriceComponent = new List<Invoice.PriceComponentComponent>((IEnumerable<Invoice.PriceComponentComponent>)zzzz_),
                TotalNet = azzza_,
                TotalGross = azzzb_,
                PaymentTermsElement = azzzc_,
                Note = new List<Annotation>((IEnumerable<Annotation>)azzzd_),
            };

            return azzze_;
        };
        IEnumerable<Invoice> zzzl_ = context.Operators.Select<Invoice, Invoice>((IEnumerable<Invoice>)zzzj_, zzzk_);
        IEnumerable<Invoice> zzzm_ = context.Operators.Distinct<Invoice>(zzzl_);
        Invoice zzzn_ = context.Operators.SingletonFrom<Invoice>(zzzm_);

        return zzzn_;
    }


    [CqlExpressionDefinition("LibraryResource")]
    public Library LibraryResource(CqlContext context, Library arg)
    {
        Library[] azzzf_ = [
            arg,
        ];
        Library azzzg_(Library a)
        {
            FhirUri azzzk_ = a?.UrlElement;
            List<Identifier> azzzl_ = a?.Identifier;
            FhirString azzzm_ = a?.VersionElement;
            FhirString azzzn_ = a?.NameElement;
            FhirString azzzo_ = a?.TitleElement;
            FhirString azzzp_ = a?.SubtitleElement;
            Code<PublicationStatus> azzzq_ = a?.StatusElement;
            FhirBoolean azzzr_ = a?.ExperimentalElement;
            CodeableConcept azzzs_ = a?.Type;
            DataType azzzt_ = a?.Subject;
            FhirDateTime azzzu_ = a?.DateElement;
            FhirString azzzv_ = a?.PublisherElement;
            List<ContactDetail> azzzw_ = a?.Contact;
            Markdown azzzx_ = a?.DescriptionElement;
            List<UsageContext> azzzy_ = a?.UseContext;
            List<CodeableConcept> azzzz_ = a?.Jurisdiction;
            Markdown bzzza_ = a?.PurposeElement;
            FhirString bzzzb_ = a?.UsageElement;
            Markdown bzzzc_ = a?.CopyrightElement;
            Date bzzzd_ = a?.ApprovalDateElement;
            Date bzzze_ = a?.LastReviewDateElement;
            Period bzzzf_ = a?.EffectivePeriod;
            List<CodeableConcept> bzzzg_ = a?.Topic;
            List<ContactDetail> bzzzh_ = a?.Author;
            List<ContactDetail> bzzzi_ = a?.Editor;
            List<ContactDetail> bzzzj_ = a?.Reviewer;
            List<ContactDetail> bzzzk_ = a?.Endorser;
            List<RelatedArtifact> bzzzl_ = a?.RelatedArtifact;
            List<ParameterDefinition> bzzzm_ = a?.Parameter;
            List<DataRequirement> bzzzn_ = a?.DataRequirement;
            List<Attachment> bzzzo_ = a?.Content;
            Library bzzzp_ = new Library
            {
                UrlElement = azzzk_,
                Identifier = new List<Identifier>((IEnumerable<Identifier>)azzzl_),
                VersionElement = azzzm_,
                NameElement = azzzn_,
                TitleElement = azzzo_,
                SubtitleElement = azzzp_,
                StatusElement = azzzq_,
                ExperimentalElement = azzzr_,
                Type = azzzs_,
                Subject = (DataType)azzzt_,
                DateElement = azzzu_,
                PublisherElement = azzzv_,
                Contact = new List<ContactDetail>((IEnumerable<ContactDetail>)azzzw_),
                DescriptionElement = azzzx_,
                UseContext = new List<UsageContext>((IEnumerable<UsageContext>)azzzy_),
                Jurisdiction = new List<CodeableConcept>((IEnumerable<CodeableConcept>)azzzz_),
                PurposeElement = bzzza_,
                UsageElement = bzzzb_,
                CopyrightElement = bzzzc_,
                ApprovalDateElement = bzzzd_,
                LastReviewDateElement = bzzze_,
                EffectivePeriod = bzzzf_,
                Topic = new List<CodeableConcept>((IEnumerable<CodeableConcept>)bzzzg_),
                Author = new List<ContactDetail>((IEnumerable<ContactDetail>)bzzzh_),
                Editor = new List<ContactDetail>((IEnumerable<ContactDetail>)bzzzi_),
                Reviewer = new List<ContactDetail>((IEnumerable<ContactDetail>)bzzzj_),
                Endorser = new List<ContactDetail>((IEnumerable<ContactDetail>)bzzzk_),
                RelatedArtifact = new List<RelatedArtifact>((IEnumerable<RelatedArtifact>)bzzzl_),
                Parameter = new List<ParameterDefinition>((IEnumerable<ParameterDefinition>)bzzzm_),
                DataRequirement = new List<DataRequirement>((IEnumerable<DataRequirement>)bzzzn_),
                Content = new List<Attachment>((IEnumerable<Attachment>)bzzzo_),
            };

            return bzzzp_;
        };
        IEnumerable<Library> azzzh_ = context.Operators.Select<Library, Library>((IEnumerable<Library>)azzzf_, azzzg_);
        IEnumerable<Library> azzzi_ = context.Operators.Distinct<Library>(azzzh_);
        Library azzzj_ = context.Operators.SingletonFrom<Library>(azzzi_);

        return azzzj_;
    }


    [CqlExpressionDefinition("LinkageResource")]
    public Linkage LinkageResource(CqlContext context, Linkage arg)
    {
        Linkage[] bzzzq_ = [
            arg,
        ];
        Linkage bzzzr_(Linkage a)
        {
            FhirBoolean bzzzv_ = a?.ActiveElement;
            ResourceReference bzzzw_ = a?.Author;
            List<Linkage.ItemComponent> bzzzx_ = a?.Item;
            Linkage bzzzy_ = new Linkage
            {
                ActiveElement = bzzzv_,
                Author = bzzzw_,
                Item = new List<Linkage.ItemComponent>((IEnumerable<Linkage.ItemComponent>)bzzzx_),
            };

            return bzzzy_;
        };
        IEnumerable<Linkage> bzzzs_ = context.Operators.Select<Linkage, Linkage>((IEnumerable<Linkage>)bzzzq_, bzzzr_);
        IEnumerable<Linkage> bzzzt_ = context.Operators.Distinct<Linkage>(bzzzs_);
        Linkage bzzzu_ = context.Operators.SingletonFrom<Linkage>(bzzzt_);

        return bzzzu_;
    }


    [CqlExpressionDefinition("LocationResource")]
    public Location LocationResource(CqlContext context, Location arg)
    {
        Location[] bzzzz_ = [
            arg,
        ];
        Location czzza_(Location a)
        {
            List<Identifier> czzze_ = a?.Identifier;
            Code<Location.LocationStatus> czzzf_ = a?.StatusElement;
            Coding czzzg_ = a?.OperationalStatus;
            FhirString czzzh_ = a?.NameElement;
            List<FhirString> czzzi_ = a?.AliasElement;
            FhirString czzzj_ = a?.DescriptionElement;
            Code<Location.LocationMode> czzzk_ = a?.ModeElement;
            List<CodeableConcept> czzzl_ = a?.Type;
            List<ContactPoint> czzzm_ = a?.Telecom;
            Address czzzn_ = a?.Address;
            CodeableConcept czzzo_ = a?.PhysicalType;
            Location.PositionComponent czzzp_ = a?.Position;
            ResourceReference czzzq_ = a?.ManagingOrganization;
            ResourceReference czzzr_ = a?.PartOf;
            List<Location.HoursOfOperationComponent> czzzs_ = a?.HoursOfOperation;
            FhirString czzzt_ = a?.AvailabilityExceptionsElement;
            List<ResourceReference> czzzu_ = a?.Endpoint;
            Location czzzv_ = new Location
            {
                Identifier = new List<Identifier>((IEnumerable<Identifier>)czzze_),
                StatusElement = czzzf_,
                OperationalStatus = czzzg_,
                NameElement = czzzh_,
                AliasElement = new List<FhirString>((IEnumerable<FhirString>)czzzi_),
                DescriptionElement = czzzj_,
                ModeElement = czzzk_,
                Type = new List<CodeableConcept>((IEnumerable<CodeableConcept>)czzzl_),
                Telecom = new List<ContactPoint>((IEnumerable<ContactPoint>)czzzm_),
                Address = czzzn_,
                PhysicalType = czzzo_,
                Position = czzzp_,
                ManagingOrganization = czzzq_,
                PartOf = czzzr_,
                HoursOfOperation = new List<Location.HoursOfOperationComponent>((IEnumerable<Location.HoursOfOperationComponent>)czzzs_),
                AvailabilityExceptionsElement = czzzt_,
                Endpoint = new List<ResourceReference>((IEnumerable<ResourceReference>)czzzu_),
            };

            return czzzv_;
        };
        IEnumerable<Location> czzzb_ = context.Operators.Select<Location, Location>((IEnumerable<Location>)bzzzz_, czzza_);
        IEnumerable<Location> czzzc_ = context.Operators.Distinct<Location>(czzzb_);
        Location czzzd_ = context.Operators.SingletonFrom<Location>(czzzc_);

        return czzzd_;
    }


    [CqlExpressionDefinition("MeasureResource")]
    public Measure MeasureResource(CqlContext context, Measure arg)
    {
        Measure[] czzzw_ = [
            arg,
        ];
        Measure czzzx_(Measure a)
        {
            FhirUri dzzzb_ = a?.UrlElement;
            List<Identifier> dzzzc_ = a?.Identifier;
            FhirString dzzzd_ = a?.VersionElement;
            FhirString dzzze_ = a?.NameElement;
            FhirString dzzzf_ = a?.TitleElement;
            FhirString dzzzg_ = a?.SubtitleElement;
            Code<PublicationStatus> dzzzh_ = a?.StatusElement;
            FhirBoolean dzzzi_ = a?.ExperimentalElement;
            DataType dzzzj_ = a?.Subject;
            FhirDateTime dzzzk_ = a?.DateElement;
            FhirString dzzzl_ = a?.PublisherElement;
            List<ContactDetail> dzzzm_ = a?.Contact;
            Markdown dzzzn_ = a?.DescriptionElement;
            List<UsageContext> dzzzo_ = a?.UseContext;
            List<CodeableConcept> dzzzp_ = a?.Jurisdiction;
            Markdown dzzzq_ = a?.PurposeElement;
            FhirString dzzzr_ = a?.UsageElement;
            Markdown dzzzs_ = a?.CopyrightElement;
            Date dzzzt_ = a?.ApprovalDateElement;
            Date dzzzu_ = a?.LastReviewDateElement;
            Period dzzzv_ = a?.EffectivePeriod;
            List<CodeableConcept> dzzzw_ = a?.Topic;
            List<ContactDetail> dzzzx_ = a?.Author;
            List<ContactDetail> dzzzy_ = a?.Editor;
            List<ContactDetail> dzzzz_ = a?.Reviewer;
            List<ContactDetail> ezzza_ = a?.Endorser;
            List<RelatedArtifact> ezzzb_ = a?.RelatedArtifact;
            List<Canonical> ezzzc_ = a?.LibraryElement;
            Markdown ezzzd_ = a?.DisclaimerElement;
            CodeableConcept ezzze_ = a?.Scoring;
            CodeableConcept ezzzf_ = a?.CompositeScoring;
            List<CodeableConcept> ezzzg_ = a?.Type;
            FhirString ezzzh_ = a?.RiskAdjustmentElement;
            FhirString ezzzi_ = a?.RateAggregationElement;
            Markdown ezzzj_ = a?.RationaleElement;
            Markdown ezzzk_ = a?.ClinicalRecommendationStatementElement;
            CodeableConcept ezzzl_ = a?.ImprovementNotation;
            List<Markdown> ezzzm_ = a?.DefinitionElement;
            Markdown ezzzn_ = a?.GuidanceElement;
            List<Measure.GroupComponent> ezzzo_ = a?.Group;
            List<Measure.SupplementalDataComponent> ezzzp_ = a?.SupplementalData;
            Measure ezzzq_ = new Measure
            {
                UrlElement = dzzzb_,
                Identifier = new List<Identifier>((IEnumerable<Identifier>)dzzzc_),
                VersionElement = dzzzd_,
                NameElement = dzzze_,
                TitleElement = dzzzf_,
                SubtitleElement = dzzzg_,
                StatusElement = dzzzh_,
                ExperimentalElement = dzzzi_,
                Subject = (DataType)dzzzj_,
                DateElement = dzzzk_,
                PublisherElement = dzzzl_,
                Contact = new List<ContactDetail>((IEnumerable<ContactDetail>)dzzzm_),
                DescriptionElement = dzzzn_,
                UseContext = new List<UsageContext>((IEnumerable<UsageContext>)dzzzo_),
                Jurisdiction = new List<CodeableConcept>((IEnumerable<CodeableConcept>)dzzzp_),
                PurposeElement = dzzzq_,
                UsageElement = dzzzr_,
                CopyrightElement = dzzzs_,
                ApprovalDateElement = dzzzt_,
                LastReviewDateElement = dzzzu_,
                EffectivePeriod = dzzzv_,
                Topic = new List<CodeableConcept>((IEnumerable<CodeableConcept>)dzzzw_),
                Author = new List<ContactDetail>((IEnumerable<ContactDetail>)dzzzx_),
                Editor = new List<ContactDetail>((IEnumerable<ContactDetail>)dzzzy_),
                Reviewer = new List<ContactDetail>((IEnumerable<ContactDetail>)dzzzz_),
                Endorser = new List<ContactDetail>((IEnumerable<ContactDetail>)ezzza_),
                RelatedArtifact = new List<RelatedArtifact>((IEnumerable<RelatedArtifact>)ezzzb_),
                LibraryElement = new List<Canonical>((IEnumerable<Canonical>)ezzzc_),
                DisclaimerElement = ezzzd_,
                Scoring = ezzze_,
                CompositeScoring = ezzzf_,
                Type = new List<CodeableConcept>((IEnumerable<CodeableConcept>)ezzzg_),
                RiskAdjustmentElement = ezzzh_,
                RateAggregationElement = ezzzi_,
                RationaleElement = ezzzj_,
                ClinicalRecommendationStatementElement = ezzzk_,
                ImprovementNotation = ezzzl_,
                DefinitionElement = new List<Markdown>((IEnumerable<Markdown>)ezzzm_),
                GuidanceElement = ezzzn_,
                Group = new List<Measure.GroupComponent>((IEnumerable<Measure.GroupComponent>)ezzzo_),
                SupplementalData = new List<Measure.SupplementalDataComponent>((IEnumerable<Measure.SupplementalDataComponent>)ezzzp_),
            };

            return ezzzq_;
        };
        IEnumerable<Measure> czzzy_ = context.Operators.Select<Measure, Measure>((IEnumerable<Measure>)czzzw_, czzzx_);
        IEnumerable<Measure> czzzz_ = context.Operators.Distinct<Measure>(czzzy_);
        Measure dzzza_ = context.Operators.SingletonFrom<Measure>(czzzz_);

        return dzzza_;
    }


    [CqlExpressionDefinition("MeasureReportResource")]
    public MeasureReport MeasureReportResource(CqlContext context, MeasureReport arg)
    {
        MeasureReport[] ezzzr_ = [
            arg,
        ];
        MeasureReport ezzzs_(MeasureReport a)
        {
            List<Identifier> ezzzw_ = a?.Identifier;
            Code<MeasureReport.MeasureReportStatus> ezzzx_ = a?.StatusElement;
            Code<MeasureReport.MeasureReportType> ezzzy_ = a?.TypeElement;
            Canonical ezzzz_ = a?.MeasureElement;
            ResourceReference fzzza_ = a?.Subject;
            FhirDateTime fzzzb_ = a?.DateElement;
            ResourceReference fzzzc_ = a?.Reporter;
            Period fzzzd_ = a?.Period;
            CodeableConcept fzzze_ = a?.ImprovementNotation;
            List<MeasureReport.GroupComponent> fzzzf_ = a?.Group;
            List<ResourceReference> fzzzg_ = a?.EvaluatedResource;
            MeasureReport fzzzh_ = new MeasureReport
            {
                Identifier = new List<Identifier>((IEnumerable<Identifier>)ezzzw_),
                StatusElement = ezzzx_,
                TypeElement = ezzzy_,
                MeasureElement = ezzzz_,
                Subject = fzzza_,
                DateElement = fzzzb_,
                Reporter = fzzzc_,
                Period = fzzzd_,
                ImprovementNotation = fzzze_,
                Group = new List<MeasureReport.GroupComponent>((IEnumerable<MeasureReport.GroupComponent>)fzzzf_),
                EvaluatedResource = new List<ResourceReference>((IEnumerable<ResourceReference>)fzzzg_),
            };

            return fzzzh_;
        };
        IEnumerable<MeasureReport> ezzzt_ = context.Operators.Select<MeasureReport, MeasureReport>((IEnumerable<MeasureReport>)ezzzr_, ezzzs_);
        IEnumerable<MeasureReport> ezzzu_ = context.Operators.Distinct<MeasureReport>(ezzzt_);
        MeasureReport ezzzv_ = context.Operators.SingletonFrom<MeasureReport>(ezzzu_);

        return ezzzv_;
    }


    [CqlExpressionDefinition("MedicationResource")]
    public Medication MedicationResource(CqlContext context, Medication arg)
    {
        Medication[] fzzzi_ = [
            arg,
        ];
        Medication fzzzj_(Medication a)
        {
            List<Identifier> fzzzn_ = a?.Identifier;
            CodeableConcept fzzzo_ = a?.Code;
            Code<Medication.MedicationStatusCodes> fzzzp_ = a?.StatusElement;
            ResourceReference fzzzq_ = a?.Manufacturer;
            CodeableConcept fzzzr_ = a?.Form;
            Ratio fzzzs_ = a?.Amount;
            List<Medication.IngredientComponent> fzzzt_ = a?.Ingredient;
            Medication.BatchComponent fzzzu_ = a?.Batch;
            Medication fzzzv_ = new Medication
            {
                Identifier = new List<Identifier>((IEnumerable<Identifier>)fzzzn_),
                Code = fzzzo_,
                StatusElement = fzzzp_,
                Manufacturer = fzzzq_,
                Form = fzzzr_,
                Amount = fzzzs_,
                Ingredient = new List<Medication.IngredientComponent>((IEnumerable<Medication.IngredientComponent>)fzzzt_),
                Batch = fzzzu_,
            };

            return fzzzv_;
        };
        IEnumerable<Medication> fzzzk_ = context.Operators.Select<Medication, Medication>((IEnumerable<Medication>)fzzzi_, fzzzj_);
        IEnumerable<Medication> fzzzl_ = context.Operators.Distinct<Medication>(fzzzk_);
        Medication fzzzm_ = context.Operators.SingletonFrom<Medication>(fzzzl_);

        return fzzzm_;
    }


    [CqlExpressionDefinition("MedicationAdministrationResource")]
    public MedicationAdministration MedicationAdministrationResource(CqlContext context, MedicationAdministration arg)
    {
        MedicationAdministration[] fzzzw_ = [
            arg,
        ];
        MedicationAdministration fzzzx_(MedicationAdministration a)
        {
            List<Identifier> gzzzb_ = a?.Identifier;
            List<FhirUri> gzzzc_ = a?.InstantiatesElement;
            List<ResourceReference> gzzzd_ = a?.PartOf;
            Code<MedicationAdministration.MedicationAdministrationStatusCodes> gzzze_ = a?.StatusElement;
            List<CodeableConcept> gzzzf_ = a?.StatusReason;
            CodeableConcept gzzzg_ = a?.Category;
            DataType gzzzh_ = a?.Medication;
            ResourceReference gzzzi_ = a?.Subject;
            ResourceReference gzzzj_ = a?.Context;
            List<ResourceReference> gzzzk_ = a?.SupportingInformation;
            DataType gzzzl_ = a?.Effective;
            List<MedicationAdministration.PerformerComponent> gzzzm_ = a?.Performer;
            List<CodeableConcept> gzzzn_ = a?.ReasonCode;
            List<ResourceReference> gzzzo_ = a?.ReasonReference;
            ResourceReference gzzzp_ = a?.Request;
            List<ResourceReference> gzzzq_ = a?.Device;
            List<Annotation> gzzzr_ = a?.Note;
            MedicationAdministration.DosageComponent gzzzs_ = a?.Dosage;
            List<ResourceReference> gzzzt_ = a?.EventHistory;
            MedicationAdministration gzzzu_ = new MedicationAdministration
            {
                Identifier = new List<Identifier>((IEnumerable<Identifier>)gzzzb_),
                InstantiatesElement = new List<FhirUri>((IEnumerable<FhirUri>)gzzzc_),
                PartOf = new List<ResourceReference>((IEnumerable<ResourceReference>)gzzzd_),
                StatusElement = gzzze_,
                StatusReason = new List<CodeableConcept>((IEnumerable<CodeableConcept>)gzzzf_),
                Category = gzzzg_,
                Medication = (DataType)gzzzh_,
                Subject = gzzzi_,
                Context = gzzzj_,
                SupportingInformation = new List<ResourceReference>((IEnumerable<ResourceReference>)gzzzk_),
                Effective = (DataType)gzzzl_,
                Performer = new List<MedicationAdministration.PerformerComponent>((IEnumerable<MedicationAdministration.PerformerComponent>)gzzzm_),
                ReasonCode = new List<CodeableConcept>((IEnumerable<CodeableConcept>)gzzzn_),
                ReasonReference = new List<ResourceReference>((IEnumerable<ResourceReference>)gzzzo_),
                Request = gzzzp_,
                Device = new List<ResourceReference>((IEnumerable<ResourceReference>)gzzzq_),
                Note = new List<Annotation>((IEnumerable<Annotation>)gzzzr_),
                Dosage = gzzzs_,
                EventHistory = new List<ResourceReference>((IEnumerable<ResourceReference>)gzzzt_),
            };

            return gzzzu_;
        };
        IEnumerable<MedicationAdministration> fzzzy_ = context.Operators.Select<MedicationAdministration, MedicationAdministration>((IEnumerable<MedicationAdministration>)fzzzw_, fzzzx_);
        IEnumerable<MedicationAdministration> fzzzz_ = context.Operators.Distinct<MedicationAdministration>(fzzzy_);
        MedicationAdministration gzzza_ = context.Operators.SingletonFrom<MedicationAdministration>(fzzzz_);

        return gzzza_;
    }


    [CqlExpressionDefinition("MedicationDispenseResource")]
    public MedicationDispense MedicationDispenseResource(CqlContext context, MedicationDispense arg)
    {
        MedicationDispense[] gzzzv_ = [
            arg,
        ];
        MedicationDispense gzzzw_(MedicationDispense a)
        {
            List<Identifier> hzzza_ = a?.Identifier;
            List<ResourceReference> hzzzb_ = a?.PartOf;
            Code<MedicationDispense.MedicationDispenseStatusCodes> hzzzc_ = a?.StatusElement;
            DataType hzzzd_ = a?.StatusReason;
            CodeableConcept hzzze_ = a?.Category;
            DataType hzzzf_ = a?.Medication;
            ResourceReference hzzzg_ = a?.Subject;
            ResourceReference hzzzh_ = a?.Context;
            List<ResourceReference> hzzzi_ = a?.SupportingInformation;
            List<MedicationDispense.PerformerComponent> hzzzj_ = a?.Performer;
            ResourceReference hzzzk_ = a?.Location;
            List<ResourceReference> hzzzl_ = a?.AuthorizingPrescription;
            CodeableConcept hzzzm_ = a?.Type;
            Quantity hzzzn_ = a?.Quantity;
            Quantity hzzzo_ = a?.DaysSupply;
            FhirDateTime hzzzp_ = a?.WhenPreparedElement;
            FhirDateTime hzzzq_ = a?.WhenHandedOverElement;
            ResourceReference hzzzr_ = a?.Destination;
            List<ResourceReference> hzzzs_ = a?.Receiver;
            List<Annotation> hzzzt_ = a?.Note;
            List<Dosage> hzzzu_ = a?.DosageInstruction;
            MedicationDispense.SubstitutionComponent hzzzv_ = a?.Substitution;
            List<ResourceReference> hzzzw_ = a?.DetectedIssue;
            List<ResourceReference> hzzzx_ = a?.EventHistory;
            MedicationDispense hzzzy_ = new MedicationDispense
            {
                Identifier = new List<Identifier>((IEnumerable<Identifier>)hzzza_),
                PartOf = new List<ResourceReference>((IEnumerable<ResourceReference>)hzzzb_),
                StatusElement = hzzzc_,
                StatusReason = (DataType)hzzzd_,
                Category = hzzze_,
                Medication = (DataType)hzzzf_,
                Subject = hzzzg_,
                Context = hzzzh_,
                SupportingInformation = new List<ResourceReference>((IEnumerable<ResourceReference>)hzzzi_),
                Performer = new List<MedicationDispense.PerformerComponent>((IEnumerable<MedicationDispense.PerformerComponent>)hzzzj_),
                Location = hzzzk_,
                AuthorizingPrescription = new List<ResourceReference>((IEnumerable<ResourceReference>)hzzzl_),
                Type = hzzzm_,
                Quantity = hzzzn_,
                DaysSupply = hzzzo_,
                WhenPreparedElement = hzzzp_,
                WhenHandedOverElement = hzzzq_,
                Destination = hzzzr_,
                Receiver = new List<ResourceReference>((IEnumerable<ResourceReference>)hzzzs_),
                Note = new List<Annotation>((IEnumerable<Annotation>)hzzzt_),
                DosageInstruction = new List<Dosage>((IEnumerable<Dosage>)hzzzu_),
                Substitution = hzzzv_,
                DetectedIssue = new List<ResourceReference>((IEnumerable<ResourceReference>)hzzzw_),
                EventHistory = new List<ResourceReference>((IEnumerable<ResourceReference>)hzzzx_),
            };

            return hzzzy_;
        };
        IEnumerable<MedicationDispense> gzzzx_ = context.Operators.Select<MedicationDispense, MedicationDispense>((IEnumerable<MedicationDispense>)gzzzv_, gzzzw_);
        IEnumerable<MedicationDispense> gzzzy_ = context.Operators.Distinct<MedicationDispense>(gzzzx_);
        MedicationDispense gzzzz_ = context.Operators.SingletonFrom<MedicationDispense>(gzzzy_);

        return gzzzz_;
    }


    [CqlExpressionDefinition("MedicationKnowledgeResource")]
    public MedicationKnowledge MedicationKnowledgeResource(CqlContext context, MedicationKnowledge arg)
    {
        MedicationKnowledge[] hzzzz_ = [
            arg,
        ];
        MedicationKnowledge izzza_(MedicationKnowledge a)
        {
            CodeableConcept izzze_ = a?.Code;
            Code<MedicationKnowledge.MedicationKnowledgeStatusCodes> izzzf_ = a?.StatusElement;
            ResourceReference izzzg_ = a?.Manufacturer;
            CodeableConcept izzzh_ = a?.DoseForm;
            Quantity izzzi_ = a?.Amount;
            List<FhirString> izzzj_ = a?.SynonymElement;
            List<MedicationKnowledge.RelatedMedicationKnowledgeComponent> izzzk_ = a?.RelatedMedicationKnowledge;
            List<ResourceReference> izzzl_ = a?.AssociatedMedication;
            List<CodeableConcept> izzzm_ = a?.ProductType;
            List<MedicationKnowledge.MonographComponent> izzzn_ = a?.Monograph;
            List<MedicationKnowledge.IngredientComponent> izzzo_ = a?.Ingredient;
            Markdown izzzp_ = a?.PreparationInstructionElement;
            List<CodeableConcept> izzzq_ = a?.IntendedRoute;
            List<MedicationKnowledge.CostComponent> izzzr_ = a?.Cost;
            List<MedicationKnowledge.MonitoringProgramComponent> izzzs_ = a?.MonitoringProgram;
            List<MedicationKnowledge.AdministrationGuidelinesComponent> izzzt_ = a?.AdministrationGuidelines;
            List<MedicationKnowledge.MedicineClassificationComponent> izzzu_ = a?.MedicineClassification;
            MedicationKnowledge.PackagingComponent izzzv_ = a?.Packaging;
            List<MedicationKnowledge.DrugCharacteristicComponent> izzzw_ = a?.DrugCharacteristic;
            List<ResourceReference> izzzx_ = a?.Contraindication;
            List<MedicationKnowledge.RegulatoryComponent> izzzy_ = a?.Regulatory;
            List<MedicationKnowledge.KineticsComponent> izzzz_ = a?.Kinetics;
            MedicationKnowledge jzzza_ = new MedicationKnowledge
            {
                Code = izzze_,
                StatusElement = izzzf_,
                Manufacturer = izzzg_,
                DoseForm = izzzh_,
                Amount = izzzi_,
                SynonymElement = new List<FhirString>((IEnumerable<FhirString>)izzzj_),
                RelatedMedicationKnowledge = new List<MedicationKnowledge.RelatedMedicationKnowledgeComponent>((IEnumerable<MedicationKnowledge.RelatedMedicationKnowledgeComponent>)izzzk_),
                AssociatedMedication = new List<ResourceReference>((IEnumerable<ResourceReference>)izzzl_),
                ProductType = new List<CodeableConcept>((IEnumerable<CodeableConcept>)izzzm_),
                Monograph = new List<MedicationKnowledge.MonographComponent>((IEnumerable<MedicationKnowledge.MonographComponent>)izzzn_),
                Ingredient = new List<MedicationKnowledge.IngredientComponent>((IEnumerable<MedicationKnowledge.IngredientComponent>)izzzo_),
                PreparationInstructionElement = izzzp_,
                IntendedRoute = new List<CodeableConcept>((IEnumerable<CodeableConcept>)izzzq_),
                Cost = new List<MedicationKnowledge.CostComponent>((IEnumerable<MedicationKnowledge.CostComponent>)izzzr_),
                MonitoringProgram = new List<MedicationKnowledge.MonitoringProgramComponent>((IEnumerable<MedicationKnowledge.MonitoringProgramComponent>)izzzs_),
                AdministrationGuidelines = new List<MedicationKnowledge.AdministrationGuidelinesComponent>((IEnumerable<MedicationKnowledge.AdministrationGuidelinesComponent>)izzzt_),
                MedicineClassification = new List<MedicationKnowledge.MedicineClassificationComponent>((IEnumerable<MedicationKnowledge.MedicineClassificationComponent>)izzzu_),
                Packaging = izzzv_,
                DrugCharacteristic = new List<MedicationKnowledge.DrugCharacteristicComponent>((IEnumerable<MedicationKnowledge.DrugCharacteristicComponent>)izzzw_),
                Contraindication = new List<ResourceReference>((IEnumerable<ResourceReference>)izzzx_),
                Regulatory = new List<MedicationKnowledge.RegulatoryComponent>((IEnumerable<MedicationKnowledge.RegulatoryComponent>)izzzy_),
                Kinetics = new List<MedicationKnowledge.KineticsComponent>((IEnumerable<MedicationKnowledge.KineticsComponent>)izzzz_),
            };

            return jzzza_;
        };
        IEnumerable<MedicationKnowledge> izzzb_ = context.Operators.Select<MedicationKnowledge, MedicationKnowledge>((IEnumerable<MedicationKnowledge>)hzzzz_, izzza_);
        IEnumerable<MedicationKnowledge> izzzc_ = context.Operators.Distinct<MedicationKnowledge>(izzzb_);
        MedicationKnowledge izzzd_ = context.Operators.SingletonFrom<MedicationKnowledge>(izzzc_);

        return izzzd_;
    }


    [CqlExpressionDefinition("MedicationRequestResource")]
    public MedicationRequest MedicationRequestResource(CqlContext context, MedicationRequest arg)
    {
        MedicationRequest[] jzzzb_ = [
            arg,
        ];
        MedicationRequest jzzzc_(MedicationRequest a)
        {
            List<Identifier> jzzzg_ = a?.Identifier;
            Code<MedicationRequest.MedicationrequestStatus> jzzzh_ = a?.StatusElement;
            CodeableConcept jzzzi_ = a?.StatusReason;
            Code<MedicationRequest.MedicationRequestIntent> jzzzj_ = a?.IntentElement;
            List<CodeableConcept> jzzzk_ = a?.Category;
            Code<RequestPriority> jzzzl_ = a?.PriorityElement;
            FhirBoolean jzzzm_ = a?.DoNotPerformElement;
            DataType jzzzn_ = a?.Reported;
            DataType jzzzo_ = a?.Medication;
            ResourceReference jzzzp_ = a?.Subject;
            ResourceReference jzzzq_ = a?.Encounter;
            List<ResourceReference> jzzzr_ = a?.SupportingInformation;
            FhirDateTime jzzzs_ = a?.AuthoredOnElement;
            ResourceReference jzzzt_ = a?.Requester;
            ResourceReference jzzzu_ = a?.Performer;
            CodeableConcept jzzzv_ = a?.PerformerType;
            ResourceReference jzzzw_ = a?.Recorder;
            List<CodeableConcept> jzzzx_ = a?.ReasonCode;
            List<ResourceReference> jzzzy_ = a?.ReasonReference;
            List<Canonical> jzzzz_ = a?.InstantiatesCanonicalElement;
            List<FhirUri> kzzza_ = a?.InstantiatesUriElement;
            List<ResourceReference> kzzzb_ = a?.BasedOn;
            Identifier kzzzc_ = a?.GroupIdentifier;
            CodeableConcept kzzzd_ = a?.CourseOfTherapyType;
            List<ResourceReference> kzzze_ = a?.Insurance;
            List<Annotation> kzzzf_ = a?.Note;
            List<Dosage> kzzzg_ = a?.DosageInstruction;
            MedicationRequest.DispenseRequestComponent kzzzh_ = a?.DispenseRequest;
            MedicationRequest.SubstitutionComponent kzzzi_ = a?.Substitution;
            ResourceReference kzzzj_ = a?.PriorPrescription;
            List<ResourceReference> kzzzk_ = a?.DetectedIssue;
            List<ResourceReference> kzzzl_ = a?.EventHistory;
            MedicationRequest kzzzm_ = new MedicationRequest
            {
                Identifier = new List<Identifier>((IEnumerable<Identifier>)jzzzg_),
                StatusElement = jzzzh_,
                StatusReason = jzzzi_,
                IntentElement = jzzzj_,
                Category = new List<CodeableConcept>((IEnumerable<CodeableConcept>)jzzzk_),
                PriorityElement = jzzzl_,
                DoNotPerformElement = jzzzm_,
                Reported = (DataType)jzzzn_,
                Medication = (DataType)jzzzo_,
                Subject = jzzzp_,
                Encounter = jzzzq_,
                SupportingInformation = new List<ResourceReference>((IEnumerable<ResourceReference>)jzzzr_),
                AuthoredOnElement = jzzzs_,
                Requester = jzzzt_,
                Performer = jzzzu_,
                PerformerType = jzzzv_,
                Recorder = jzzzw_,
                ReasonCode = new List<CodeableConcept>((IEnumerable<CodeableConcept>)jzzzx_),
                ReasonReference = new List<ResourceReference>((IEnumerable<ResourceReference>)jzzzy_),
                InstantiatesCanonicalElement = new List<Canonical>((IEnumerable<Canonical>)jzzzz_),
                InstantiatesUriElement = new List<FhirUri>((IEnumerable<FhirUri>)kzzza_),
                BasedOn = new List<ResourceReference>((IEnumerable<ResourceReference>)kzzzb_),
                GroupIdentifier = kzzzc_,
                CourseOfTherapyType = kzzzd_,
                Insurance = new List<ResourceReference>((IEnumerable<ResourceReference>)kzzze_),
                Note = new List<Annotation>((IEnumerable<Annotation>)kzzzf_),
                DosageInstruction = new List<Dosage>((IEnumerable<Dosage>)kzzzg_),
                DispenseRequest = kzzzh_,
                Substitution = kzzzi_,
                PriorPrescription = kzzzj_,
                DetectedIssue = new List<ResourceReference>((IEnumerable<ResourceReference>)kzzzk_),
                EventHistory = new List<ResourceReference>((IEnumerable<ResourceReference>)kzzzl_),
            };

            return kzzzm_;
        };
        IEnumerable<MedicationRequest> jzzzd_ = context.Operators.Select<MedicationRequest, MedicationRequest>((IEnumerable<MedicationRequest>)jzzzb_, jzzzc_);
        IEnumerable<MedicationRequest> jzzze_ = context.Operators.Distinct<MedicationRequest>(jzzzd_);
        MedicationRequest jzzzf_ = context.Operators.SingletonFrom<MedicationRequest>(jzzze_);

        return jzzzf_;
    }


    [CqlExpressionDefinition("MedicationStatementResource")]
    public MedicationStatement MedicationStatementResource(CqlContext context, MedicationStatement arg)
    {
        MedicationStatement[] kzzzn_ = [
            arg,
        ];
        MedicationStatement kzzzo_(MedicationStatement a)
        {
            List<Identifier> kzzzs_ = a?.Identifier;
            List<ResourceReference> kzzzt_ = a?.BasedOn;
            List<ResourceReference> kzzzu_ = a?.PartOf;
            Code<MedicationStatement.MedicationStatusCodes> kzzzv_ = a?.StatusElement;
            List<CodeableConcept> kzzzw_ = a?.StatusReason;
            CodeableConcept kzzzx_ = a?.Category;
            DataType kzzzy_ = a?.Medication;
            ResourceReference kzzzz_ = a?.Subject;
            ResourceReference lzzza_ = a?.Context;
            DataType lzzzb_ = a?.Effective;
            FhirDateTime lzzzc_ = a?.DateAssertedElement;
            ResourceReference lzzzd_ = a?.InformationSource;
            List<ResourceReference> lzzze_ = a?.DerivedFrom;
            List<CodeableConcept> lzzzf_ = a?.ReasonCode;
            List<ResourceReference> lzzzg_ = a?.ReasonReference;
            List<Annotation> lzzzh_ = a?.Note;
            List<Dosage> lzzzi_ = a?.Dosage;
            MedicationStatement lzzzj_ = new MedicationStatement
            {
                Identifier = new List<Identifier>((IEnumerable<Identifier>)kzzzs_),
                BasedOn = new List<ResourceReference>((IEnumerable<ResourceReference>)kzzzt_),
                PartOf = new List<ResourceReference>((IEnumerable<ResourceReference>)kzzzu_),
                StatusElement = kzzzv_,
                StatusReason = new List<CodeableConcept>((IEnumerable<CodeableConcept>)kzzzw_),
                Category = kzzzx_,
                Medication = (DataType)kzzzy_,
                Subject = kzzzz_,
                Context = lzzza_,
                Effective = (DataType)lzzzb_,
                DateAssertedElement = lzzzc_,
                InformationSource = lzzzd_,
                DerivedFrom = new List<ResourceReference>((IEnumerable<ResourceReference>)lzzze_),
                ReasonCode = new List<CodeableConcept>((IEnumerable<CodeableConcept>)lzzzf_),
                ReasonReference = new List<ResourceReference>((IEnumerable<ResourceReference>)lzzzg_),
                Note = new List<Annotation>((IEnumerable<Annotation>)lzzzh_),
                Dosage = new List<Dosage>((IEnumerable<Dosage>)lzzzi_),
            };

            return lzzzj_;
        };
        IEnumerable<MedicationStatement> kzzzp_ = context.Operators.Select<MedicationStatement, MedicationStatement>((IEnumerable<MedicationStatement>)kzzzn_, kzzzo_);
        IEnumerable<MedicationStatement> kzzzq_ = context.Operators.Distinct<MedicationStatement>(kzzzp_);
        MedicationStatement kzzzr_ = context.Operators.SingletonFrom<MedicationStatement>(kzzzq_);

        return kzzzr_;
    }


    [CqlExpressionDefinition("MedicinalProductResource")]
    public MedicinalProduct MedicinalProductResource(CqlContext context, MedicinalProduct arg)
    {
        MedicinalProduct[] lzzzk_ = [
            arg,
        ];
        MedicinalProduct lzzzl_(MedicinalProduct a)
        {
            List<Identifier> lzzzp_ = a?.Identifier;
            CodeableConcept lzzzq_ = a?.Type;
            Coding lzzzr_ = a?.Domain;
            CodeableConcept lzzzs_ = a?.CombinedPharmaceuticalDoseForm;
            CodeableConcept lzzzt_ = a?.LegalStatusOfSupply;
            CodeableConcept lzzzu_ = a?.AdditionalMonitoringIndicator;
            List<FhirString> lzzzv_ = a?.SpecialMeasuresElement;
            CodeableConcept lzzzw_ = a?.PaediatricUseIndicator;
            List<CodeableConcept> lzzzx_ = a?.ProductClassification;
            List<MarketingStatus> lzzzy_ = a?.MarketingStatus;
            List<ResourceReference> lzzzz_ = a?.PharmaceuticalProduct;
            List<ResourceReference> mzzza_ = a?.PackagedMedicinalProduct;
            List<ResourceReference> mzzzb_ = a?.AttachedDocument;
            List<ResourceReference> mzzzc_ = a?.MasterFile;
            List<ResourceReference> mzzzd_ = a?.Contact;
            List<ResourceReference> mzzze_ = a?.ClinicalTrial;
            List<MedicinalProduct.NameComponent> mzzzf_ = a?.Name;
            List<Identifier> mzzzg_ = a?.CrossReference;
            List<MedicinalProduct.ManufacturingBusinessOperationComponent> mzzzh_ = a?.ManufacturingBusinessOperation;
            List<MedicinalProduct.SpecialDesignationComponent> mzzzi_ = a?.SpecialDesignation;
            MedicinalProduct mzzzj_ = new MedicinalProduct
            {
                Identifier = new List<Identifier>((IEnumerable<Identifier>)lzzzp_),
                Type = lzzzq_,
                Domain = lzzzr_,
                CombinedPharmaceuticalDoseForm = lzzzs_,
                LegalStatusOfSupply = lzzzt_,
                AdditionalMonitoringIndicator = lzzzu_,
                SpecialMeasuresElement = new List<FhirString>((IEnumerable<FhirString>)lzzzv_),
                PaediatricUseIndicator = lzzzw_,
                ProductClassification = new List<CodeableConcept>((IEnumerable<CodeableConcept>)lzzzx_),
                MarketingStatus = new List<MarketingStatus>((IEnumerable<MarketingStatus>)lzzzy_),
                PharmaceuticalProduct = new List<ResourceReference>((IEnumerable<ResourceReference>)lzzzz_),
                PackagedMedicinalProduct = new List<ResourceReference>((IEnumerable<ResourceReference>)mzzza_),
                AttachedDocument = new List<ResourceReference>((IEnumerable<ResourceReference>)mzzzb_),
                MasterFile = new List<ResourceReference>((IEnumerable<ResourceReference>)mzzzc_),
                Contact = new List<ResourceReference>((IEnumerable<ResourceReference>)mzzzd_),
                ClinicalTrial = new List<ResourceReference>((IEnumerable<ResourceReference>)mzzze_),
                Name = new List<MedicinalProduct.NameComponent>((IEnumerable<MedicinalProduct.NameComponent>)mzzzf_),
                CrossReference = new List<Identifier>((IEnumerable<Identifier>)mzzzg_),
                ManufacturingBusinessOperation = new List<MedicinalProduct.ManufacturingBusinessOperationComponent>((IEnumerable<MedicinalProduct.ManufacturingBusinessOperationComponent>)mzzzh_),
                SpecialDesignation = new List<MedicinalProduct.SpecialDesignationComponent>((IEnumerable<MedicinalProduct.SpecialDesignationComponent>)mzzzi_),
            };

            return mzzzj_;
        };
        IEnumerable<MedicinalProduct> lzzzm_ = context.Operators.Select<MedicinalProduct, MedicinalProduct>((IEnumerable<MedicinalProduct>)lzzzk_, lzzzl_);
        IEnumerable<MedicinalProduct> lzzzn_ = context.Operators.Distinct<MedicinalProduct>(lzzzm_);
        MedicinalProduct lzzzo_ = context.Operators.SingletonFrom<MedicinalProduct>(lzzzn_);

        return lzzzo_;
    }


    [CqlExpressionDefinition("MedicinalProductAuthorizationResource")]
    public MedicinalProductAuthorization MedicinalProductAuthorizationResource(CqlContext context, MedicinalProductAuthorization arg)
    {
        MedicinalProductAuthorization[] mzzzk_ = [
            arg,
        ];
        MedicinalProductAuthorization mzzzl_(MedicinalProductAuthorization a)
        {
            List<Identifier> mzzzp_ = a?.Identifier;
            ResourceReference mzzzq_ = a?.Subject;
            List<CodeableConcept> mzzzr_ = a?.Country;
            List<CodeableConcept> mzzzs_ = a?.Jurisdiction;
            CodeableConcept mzzzt_ = a?.Status;
            FhirDateTime mzzzu_ = a?.StatusDateElement;
            FhirDateTime mzzzv_ = a?.RestoreDateElement;
            Period mzzzw_ = a?.ValidityPeriod;
            Period mzzzx_ = a?.DataExclusivityPeriod;
            FhirDateTime mzzzy_ = a?.DateOfFirstAuthorizationElement;
            FhirDateTime mzzzz_ = a?.InternationalBirthDateElement;
            CodeableConcept nzzza_ = a?.LegalBasis;
            List<MedicinalProductAuthorization.JurisdictionalAuthorizationComponent> nzzzb_ = a?.JurisdictionalAuthorization;
            ResourceReference nzzzc_ = a?.Holder;
            ResourceReference nzzzd_ = a?.Regulator;
            MedicinalProductAuthorization.ProcedureComponent nzzze_ = a?.Procedure;
            MedicinalProductAuthorization nzzzf_ = new MedicinalProductAuthorization
            {
                Identifier = new List<Identifier>((IEnumerable<Identifier>)mzzzp_),
                Subject = mzzzq_,
                Country = new List<CodeableConcept>((IEnumerable<CodeableConcept>)mzzzr_),
                Jurisdiction = new List<CodeableConcept>((IEnumerable<CodeableConcept>)mzzzs_),
                Status = mzzzt_,
                StatusDateElement = mzzzu_,
                RestoreDateElement = mzzzv_,
                ValidityPeriod = mzzzw_,
                DataExclusivityPeriod = mzzzx_,
                DateOfFirstAuthorizationElement = mzzzy_,
                InternationalBirthDateElement = mzzzz_,
                LegalBasis = nzzza_,
                JurisdictionalAuthorization = new List<MedicinalProductAuthorization.JurisdictionalAuthorizationComponent>((IEnumerable<MedicinalProductAuthorization.JurisdictionalAuthorizationComponent>)nzzzb_),
                Holder = nzzzc_,
                Regulator = nzzzd_,
                Procedure = nzzze_,
            };

            return nzzzf_;
        };
        IEnumerable<MedicinalProductAuthorization> mzzzm_ = context.Operators.Select<MedicinalProductAuthorization, MedicinalProductAuthorization>((IEnumerable<MedicinalProductAuthorization>)mzzzk_, mzzzl_);
        IEnumerable<MedicinalProductAuthorization> mzzzn_ = context.Operators.Distinct<MedicinalProductAuthorization>(mzzzm_);
        MedicinalProductAuthorization mzzzo_ = context.Operators.SingletonFrom<MedicinalProductAuthorization>(mzzzn_);

        return mzzzo_;
    }


    [CqlExpressionDefinition("MedicinalProductContraindicationResource")]
    public MedicinalProductContraindication MedicinalProductContraindicationResource(CqlContext context, MedicinalProductContraindication arg)
    {
        MedicinalProductContraindication[] nzzzg_ = [
            arg,
        ];
        MedicinalProductContraindication nzzzh_(MedicinalProductContraindication a)
        {
            List<ResourceReference> nzzzl_ = a?.Subject;
            CodeableConcept nzzzm_ = a?.Disease;
            CodeableConcept nzzzn_ = a?.DiseaseStatus;
            List<CodeableConcept> nzzzo_ = a?.Comorbidity;
            List<ResourceReference> nzzzp_ = a?.TherapeuticIndication;
            List<MedicinalProductContraindication.OtherTherapyComponent> nzzzq_ = a?.OtherTherapy;
            List<Population> nzzzr_ = a?.Population;
            MedicinalProductContraindication nzzzs_ = new MedicinalProductContraindication
            {
                Subject = new List<ResourceReference>((IEnumerable<ResourceReference>)nzzzl_),
                Disease = nzzzm_,
                DiseaseStatus = nzzzn_,
                Comorbidity = new List<CodeableConcept>((IEnumerable<CodeableConcept>)nzzzo_),
                TherapeuticIndication = new List<ResourceReference>((IEnumerable<ResourceReference>)nzzzp_),
                OtherTherapy = new List<MedicinalProductContraindication.OtherTherapyComponent>((IEnumerable<MedicinalProductContraindication.OtherTherapyComponent>)nzzzq_),
                Population = new List<Population>((IEnumerable<Population>)nzzzr_),
            };

            return nzzzs_;
        };
        IEnumerable<MedicinalProductContraindication> nzzzi_ = context.Operators.Select<MedicinalProductContraindication, MedicinalProductContraindication>((IEnumerable<MedicinalProductContraindication>)nzzzg_, nzzzh_);
        IEnumerable<MedicinalProductContraindication> nzzzj_ = context.Operators.Distinct<MedicinalProductContraindication>(nzzzi_);
        MedicinalProductContraindication nzzzk_ = context.Operators.SingletonFrom<MedicinalProductContraindication>(nzzzj_);

        return nzzzk_;
    }


    [CqlExpressionDefinition("MedicinalProductIngredientResource")]
    public MedicinalProductIngredient MedicinalProductIngredientResource(CqlContext context, MedicinalProductIngredient arg)
    {
        MedicinalProductIngredient[] nzzzt_ = [
            arg,
        ];
        MedicinalProductIngredient nzzzu_(MedicinalProductIngredient a)
        {
            Identifier nzzzy_ = a?.Identifier;
            CodeableConcept nzzzz_ = a?.Role;
            FhirBoolean ozzza_ = a?.AllergenicIndicatorElement;
            List<ResourceReference> ozzzb_ = a?.Manufacturer;
            List<MedicinalProductIngredient.SpecifiedSubstanceComponent> ozzzc_ = a?.SpecifiedSubstance;
            MedicinalProductIngredient.SubstanceComponent ozzzd_ = a?.Substance;
            MedicinalProductIngredient ozzze_ = new MedicinalProductIngredient
            {
                Identifier = nzzzy_,
                Role = nzzzz_,
                AllergenicIndicatorElement = ozzza_,
                Manufacturer = new List<ResourceReference>((IEnumerable<ResourceReference>)ozzzb_),
                SpecifiedSubstance = new List<MedicinalProductIngredient.SpecifiedSubstanceComponent>((IEnumerable<MedicinalProductIngredient.SpecifiedSubstanceComponent>)ozzzc_),
                Substance = ozzzd_,
            };

            return ozzze_;
        };
        IEnumerable<MedicinalProductIngredient> nzzzv_ = context.Operators.Select<MedicinalProductIngredient, MedicinalProductIngredient>((IEnumerable<MedicinalProductIngredient>)nzzzt_, nzzzu_);
        IEnumerable<MedicinalProductIngredient> nzzzw_ = context.Operators.Distinct<MedicinalProductIngredient>(nzzzv_);
        MedicinalProductIngredient nzzzx_ = context.Operators.SingletonFrom<MedicinalProductIngredient>(nzzzw_);

        return nzzzx_;
    }


    [CqlExpressionDefinition("MedicinalProductInteractionResource")]
    public MedicinalProductInteraction MedicinalProductInteractionResource(CqlContext context, MedicinalProductInteraction arg)
    {
        MedicinalProductInteraction[] ozzzf_ = [
            arg,
        ];
        MedicinalProductInteraction ozzzg_(MedicinalProductInteraction a)
        {
            List<ResourceReference> ozzzk_ = a?.Subject;
            FhirString ozzzl_ = a?.DescriptionElement;
            List<MedicinalProductInteraction.InteractantComponent> ozzzm_ = a?.Interactant;
            CodeableConcept ozzzn_ = a?.Type;
            CodeableConcept ozzzo_ = a?.Effect;
            CodeableConcept ozzzp_ = a?.Incidence;
            CodeableConcept ozzzq_ = a?.Management;
            MedicinalProductInteraction ozzzr_ = new MedicinalProductInteraction
            {
                Subject = new List<ResourceReference>((IEnumerable<ResourceReference>)ozzzk_),
                DescriptionElement = ozzzl_,
                Interactant = new List<MedicinalProductInteraction.InteractantComponent>((IEnumerable<MedicinalProductInteraction.InteractantComponent>)ozzzm_),
                Type = ozzzn_,
                Effect = ozzzo_,
                Incidence = ozzzp_,
                Management = ozzzq_,
            };

            return ozzzr_;
        };
        IEnumerable<MedicinalProductInteraction> ozzzh_ = context.Operators.Select<MedicinalProductInteraction, MedicinalProductInteraction>((IEnumerable<MedicinalProductInteraction>)ozzzf_, ozzzg_);
        IEnumerable<MedicinalProductInteraction> ozzzi_ = context.Operators.Distinct<MedicinalProductInteraction>(ozzzh_);
        MedicinalProductInteraction ozzzj_ = context.Operators.SingletonFrom<MedicinalProductInteraction>(ozzzi_);

        return ozzzj_;
    }


    [CqlExpressionDefinition("MedicinalProductManufacturedResource")]
    public MedicinalProductManufactured MedicinalProductManufacturedResource(CqlContext context, MedicinalProductManufactured arg)
    {
        MedicinalProductManufactured[] ozzzs_ = [
            arg,
        ];
        MedicinalProductManufactured ozzzt_(MedicinalProductManufactured a)
        {
            CodeableConcept ozzzx_ = a?.ManufacturedDoseForm;
            CodeableConcept ozzzy_ = a?.UnitOfPresentation;
            Quantity ozzzz_ = a?.Quantity;
            List<ResourceReference> pzzza_ = a?.Manufacturer;
            List<ResourceReference> pzzzb_ = a?.Ingredient;
            ProdCharacteristic pzzzc_ = a?.PhysicalCharacteristics;
            List<CodeableConcept> pzzzd_ = a?.OtherCharacteristics;
            MedicinalProductManufactured pzzze_ = new MedicinalProductManufactured
            {
                ManufacturedDoseForm = ozzzx_,
                UnitOfPresentation = ozzzy_,
                Quantity = ozzzz_,
                Manufacturer = new List<ResourceReference>((IEnumerable<ResourceReference>)pzzza_),
                Ingredient = new List<ResourceReference>((IEnumerable<ResourceReference>)pzzzb_),
                PhysicalCharacteristics = pzzzc_,
                OtherCharacteristics = new List<CodeableConcept>((IEnumerable<CodeableConcept>)pzzzd_),
            };

            return pzzze_;
        };
        IEnumerable<MedicinalProductManufactured> ozzzu_ = context.Operators.Select<MedicinalProductManufactured, MedicinalProductManufactured>((IEnumerable<MedicinalProductManufactured>)ozzzs_, ozzzt_);
        IEnumerable<MedicinalProductManufactured> ozzzv_ = context.Operators.Distinct<MedicinalProductManufactured>(ozzzu_);
        MedicinalProductManufactured ozzzw_ = context.Operators.SingletonFrom<MedicinalProductManufactured>(ozzzv_);

        return ozzzw_;
    }


    [CqlExpressionDefinition("MedicinalProductPackagedResource")]
    public MedicinalProductPackaged MedicinalProductPackagedResource(CqlContext context, MedicinalProductPackaged arg)
    {
        MedicinalProductPackaged[] pzzzf_ = [
            arg,
        ];
        MedicinalProductPackaged pzzzg_(MedicinalProductPackaged a)
        {
            List<Identifier> pzzzk_ = a?.Identifier;
            List<ResourceReference> pzzzl_ = a?.Subject;
            FhirString pzzzm_ = a?.DescriptionElement;
            CodeableConcept pzzzn_ = a?.LegalStatusOfSupply;
            List<MarketingStatus> pzzzo_ = a?.MarketingStatus;
            ResourceReference pzzzp_ = a?.MarketingAuthorization;
            List<ResourceReference> pzzzq_ = a?.Manufacturer;
            List<MedicinalProductPackaged.BatchIdentifierComponent> pzzzr_ = a?.BatchIdentifier;
            List<MedicinalProductPackaged.PackageItemComponent> pzzzs_ = a?.PackageItem;
            MedicinalProductPackaged pzzzt_ = new MedicinalProductPackaged
            {
                Identifier = new List<Identifier>((IEnumerable<Identifier>)pzzzk_),
                Subject = new List<ResourceReference>((IEnumerable<ResourceReference>)pzzzl_),
                DescriptionElement = pzzzm_,
                LegalStatusOfSupply = pzzzn_,
                MarketingStatus = new List<MarketingStatus>((IEnumerable<MarketingStatus>)pzzzo_),
                MarketingAuthorization = pzzzp_,
                Manufacturer = new List<ResourceReference>((IEnumerable<ResourceReference>)pzzzq_),
                BatchIdentifier = new List<MedicinalProductPackaged.BatchIdentifierComponent>((IEnumerable<MedicinalProductPackaged.BatchIdentifierComponent>)pzzzr_),
                PackageItem = new List<MedicinalProductPackaged.PackageItemComponent>((IEnumerable<MedicinalProductPackaged.PackageItemComponent>)pzzzs_),
            };

            return pzzzt_;
        };
        IEnumerable<MedicinalProductPackaged> pzzzh_ = context.Operators.Select<MedicinalProductPackaged, MedicinalProductPackaged>((IEnumerable<MedicinalProductPackaged>)pzzzf_, pzzzg_);
        IEnumerable<MedicinalProductPackaged> pzzzi_ = context.Operators.Distinct<MedicinalProductPackaged>(pzzzh_);
        MedicinalProductPackaged pzzzj_ = context.Operators.SingletonFrom<MedicinalProductPackaged>(pzzzi_);

        return pzzzj_;
    }


    [CqlExpressionDefinition("MedicinalProductPharmaceuticalResource")]
    public MedicinalProductPharmaceutical MedicinalProductPharmaceuticalResource(CqlContext context, MedicinalProductPharmaceutical arg)
    {
        MedicinalProductPharmaceutical[] pzzzu_ = [
            arg,
        ];
        MedicinalProductPharmaceutical pzzzv_(MedicinalProductPharmaceutical a)
        {
            List<Identifier> pzzzz_ = a?.Identifier;
            CodeableConcept qzzza_ = a?.AdministrableDoseForm;
            CodeableConcept qzzzb_ = a?.UnitOfPresentation;
            List<ResourceReference> qzzzc_ = a?.Ingredient;
            List<ResourceReference> qzzzd_ = a?.Device;
            List<MedicinalProductPharmaceutical.CharacteristicsComponent> qzzze_ = a?.Characteristics;
            List<MedicinalProductPharmaceutical.RouteOfAdministrationComponent> qzzzf_ = a?.RouteOfAdministration;
            MedicinalProductPharmaceutical qzzzg_ = new MedicinalProductPharmaceutical
            {
                Identifier = new List<Identifier>((IEnumerable<Identifier>)pzzzz_),
                AdministrableDoseForm = qzzza_,
                UnitOfPresentation = qzzzb_,
                Ingredient = new List<ResourceReference>((IEnumerable<ResourceReference>)qzzzc_),
                Device = new List<ResourceReference>((IEnumerable<ResourceReference>)qzzzd_),
                Characteristics = new List<MedicinalProductPharmaceutical.CharacteristicsComponent>((IEnumerable<MedicinalProductPharmaceutical.CharacteristicsComponent>)qzzze_),
                RouteOfAdministration = new List<MedicinalProductPharmaceutical.RouteOfAdministrationComponent>((IEnumerable<MedicinalProductPharmaceutical.RouteOfAdministrationComponent>)qzzzf_),
            };

            return qzzzg_;
        };
        IEnumerable<MedicinalProductPharmaceutical> pzzzw_ = context.Operators.Select<MedicinalProductPharmaceutical, MedicinalProductPharmaceutical>((IEnumerable<MedicinalProductPharmaceutical>)pzzzu_, pzzzv_);
        IEnumerable<MedicinalProductPharmaceutical> pzzzx_ = context.Operators.Distinct<MedicinalProductPharmaceutical>(pzzzw_);
        MedicinalProductPharmaceutical pzzzy_ = context.Operators.SingletonFrom<MedicinalProductPharmaceutical>(pzzzx_);

        return pzzzy_;
    }


    [CqlExpressionDefinition("MedicinalProductUndesirableEffectResource")]
    public MedicinalProductUndesirableEffect MedicinalProductUndesirableEffectResource(CqlContext context, MedicinalProductUndesirableEffect arg)
    {
        MedicinalProductUndesirableEffect[] qzzzh_ = [
            arg,
        ];
        MedicinalProductUndesirableEffect qzzzi_(MedicinalProductUndesirableEffect a)
        {
            List<ResourceReference> qzzzm_ = a?.Subject;
            CodeableConcept qzzzn_ = a?.SymptomConditionEffect;
            CodeableConcept qzzzo_ = a?.Classification;
            CodeableConcept qzzzp_ = a?.FrequencyOfOccurrence;
            List<Population> qzzzq_ = a?.Population;
            MedicinalProductUndesirableEffect qzzzr_ = new MedicinalProductUndesirableEffect
            {
                Subject = new List<ResourceReference>((IEnumerable<ResourceReference>)qzzzm_),
                SymptomConditionEffect = qzzzn_,
                Classification = qzzzo_,
                FrequencyOfOccurrence = qzzzp_,
                Population = new List<Population>((IEnumerable<Population>)qzzzq_),
            };

            return qzzzr_;
        };
        IEnumerable<MedicinalProductUndesirableEffect> qzzzj_ = context.Operators.Select<MedicinalProductUndesirableEffect, MedicinalProductUndesirableEffect>((IEnumerable<MedicinalProductUndesirableEffect>)qzzzh_, qzzzi_);
        IEnumerable<MedicinalProductUndesirableEffect> qzzzk_ = context.Operators.Distinct<MedicinalProductUndesirableEffect>(qzzzj_);
        MedicinalProductUndesirableEffect qzzzl_ = context.Operators.SingletonFrom<MedicinalProductUndesirableEffect>(qzzzk_);

        return qzzzl_;
    }


    [CqlExpressionDefinition("MessageHeaderResource")]
    public MessageHeader MessageHeaderResource(CqlContext context, MessageHeader arg)
    {
        MessageHeader[] qzzzs_ = [
            arg,
        ];
        MessageHeader qzzzt_(MessageHeader a)
        {
            DataType qzzzx_ = a?.Event;
            List<MessageHeader.MessageDestinationComponent> qzzzy_ = a?.Destination;
            ResourceReference qzzzz_ = a?.Sender;
            ResourceReference rzzza_ = a?.Enterer;
            ResourceReference rzzzb_ = a?.Author;
            MessageHeader.MessageSourceComponent rzzzc_ = a?.Source;
            ResourceReference rzzzd_ = a?.Responsible;
            CodeableConcept rzzze_ = a?.Reason;
            MessageHeader.ResponseComponent rzzzf_ = a?.Response;
            List<ResourceReference> rzzzg_ = a?.Focus;
            Canonical rzzzh_ = a?.DefinitionElement;
            MessageHeader rzzzi_ = new MessageHeader
            {
                Event = (DataType)qzzzx_,
                Destination = new List<MessageHeader.MessageDestinationComponent>((IEnumerable<MessageHeader.MessageDestinationComponent>)qzzzy_),
                Sender = qzzzz_,
                Enterer = rzzza_,
                Author = rzzzb_,
                Source = rzzzc_,
                Responsible = rzzzd_,
                Reason = rzzze_,
                Response = rzzzf_,
                Focus = new List<ResourceReference>((IEnumerable<ResourceReference>)rzzzg_),
                DefinitionElement = rzzzh_,
            };

            return rzzzi_;
        };
        IEnumerable<MessageHeader> qzzzu_ = context.Operators.Select<MessageHeader, MessageHeader>((IEnumerable<MessageHeader>)qzzzs_, qzzzt_);
        IEnumerable<MessageHeader> qzzzv_ = context.Operators.Distinct<MessageHeader>(qzzzu_);
        MessageHeader qzzzw_ = context.Operators.SingletonFrom<MessageHeader>(qzzzv_);

        return qzzzw_;
    }


    [CqlExpressionDefinition("MolecularSequenceResource")]
    public MolecularSequence MolecularSequenceResource(CqlContext context, MolecularSequence arg)
    {
        MolecularSequence[] rzzzj_ = [
            arg,
        ];
        MolecularSequence rzzzk_(MolecularSequence a)
        {
            List<Identifier> rzzzo_ = a?.Identifier;
            Code<MolecularSequence.SequenceType> rzzzp_ = a?.TypeElement;
            Integer rzzzq_ = a?.CoordinateSystemElement;
            ResourceReference rzzzr_ = a?.Patient;
            ResourceReference rzzzs_ = a?.Specimen;
            ResourceReference rzzzt_ = a?.Device;
            ResourceReference rzzzu_ = a?.Performer;
            Quantity rzzzv_ = a?.Quantity;
            MolecularSequence.ReferenceSeqComponent rzzzw_ = a?.ReferenceSeq;
            List<MolecularSequence.VariantComponent> rzzzx_ = a?.Variant;
            FhirString rzzzy_ = a?.ObservedSeqElement;
            List<MolecularSequence.QualityComponent> rzzzz_ = a?.Quality;
            Integer szzza_ = a?.ReadCoverageElement;
            List<MolecularSequence.RepositoryComponent> szzzb_ = a?.Repository;
            List<ResourceReference> szzzc_ = a?.Pointer;
            List<MolecularSequence.StructureVariantComponent> szzzd_ = a?.StructureVariant;
            MolecularSequence szzze_ = new MolecularSequence
            {
                Identifier = new List<Identifier>((IEnumerable<Identifier>)rzzzo_),
                TypeElement = rzzzp_,
                CoordinateSystemElement = rzzzq_,
                Patient = rzzzr_,
                Specimen = rzzzs_,
                Device = rzzzt_,
                Performer = rzzzu_,
                Quantity = rzzzv_,
                ReferenceSeq = rzzzw_,
                Variant = new List<MolecularSequence.VariantComponent>((IEnumerable<MolecularSequence.VariantComponent>)rzzzx_),
                ObservedSeqElement = rzzzy_,
                Quality = new List<MolecularSequence.QualityComponent>((IEnumerable<MolecularSequence.QualityComponent>)rzzzz_),
                ReadCoverageElement = szzza_,
                Repository = new List<MolecularSequence.RepositoryComponent>((IEnumerable<MolecularSequence.RepositoryComponent>)szzzb_),
                Pointer = new List<ResourceReference>((IEnumerable<ResourceReference>)szzzc_),
                StructureVariant = new List<MolecularSequence.StructureVariantComponent>((IEnumerable<MolecularSequence.StructureVariantComponent>)szzzd_),
            };

            return szzze_;
        };
        IEnumerable<MolecularSequence> rzzzl_ = context.Operators.Select<MolecularSequence, MolecularSequence>((IEnumerable<MolecularSequence>)rzzzj_, rzzzk_);
        IEnumerable<MolecularSequence> rzzzm_ = context.Operators.Distinct<MolecularSequence>(rzzzl_);
        MolecularSequence rzzzn_ = context.Operators.SingletonFrom<MolecularSequence>(rzzzm_);

        return rzzzn_;
    }


    [CqlExpressionDefinition("NamingSystemResource")]
    public NamingSystem NamingSystemResource(CqlContext context, NamingSystem arg)
    {
        NamingSystem[] szzzf_ = [
            arg,
        ];
        NamingSystem szzzg_(NamingSystem a)
        {
            FhirString szzzk_ = a?.NameElement;
            Code<PublicationStatus> szzzl_ = a?.StatusElement;
            Code<NamingSystem.NamingSystemType> szzzm_ = a?.KindElement;
            FhirDateTime szzzn_ = a?.DateElement;
            FhirString szzzo_ = a?.PublisherElement;
            List<ContactDetail> szzzp_ = a?.Contact;
            FhirString szzzq_ = a?.ResponsibleElement;
            CodeableConcept szzzr_ = a?.Type;
            Markdown szzzs_ = a?.DescriptionElement;
            List<UsageContext> szzzt_ = a?.UseContext;
            List<CodeableConcept> szzzu_ = a?.Jurisdiction;
            FhirString szzzv_ = a?.UsageElement;
            List<NamingSystem.UniqueIdComponent> szzzw_ = a?.UniqueId;
            NamingSystem szzzx_ = new NamingSystem
            {
                NameElement = szzzk_,
                StatusElement = szzzl_,
                KindElement = szzzm_,
                DateElement = szzzn_,
                PublisherElement = szzzo_,
                Contact = new List<ContactDetail>((IEnumerable<ContactDetail>)szzzp_),
                ResponsibleElement = szzzq_,
                Type = szzzr_,
                DescriptionElement = szzzs_,
                UseContext = new List<UsageContext>((IEnumerable<UsageContext>)szzzt_),
                Jurisdiction = new List<CodeableConcept>((IEnumerable<CodeableConcept>)szzzu_),
                UsageElement = szzzv_,
                UniqueId = new List<NamingSystem.UniqueIdComponent>((IEnumerable<NamingSystem.UniqueIdComponent>)szzzw_),
            };

            return szzzx_;
        };
        IEnumerable<NamingSystem> szzzh_ = context.Operators.Select<NamingSystem, NamingSystem>((IEnumerable<NamingSystem>)szzzf_, szzzg_);
        IEnumerable<NamingSystem> szzzi_ = context.Operators.Distinct<NamingSystem>(szzzh_);
        NamingSystem szzzj_ = context.Operators.SingletonFrom<NamingSystem>(szzzi_);

        return szzzj_;
    }


    [CqlExpressionDefinition("NutritionOrderResource")]
    public NutritionOrder NutritionOrderResource(CqlContext context, NutritionOrder arg)
    {
        NutritionOrder[] szzzy_ = [
            arg,
        ];
        NutritionOrder szzzz_(NutritionOrder a)
        {
            List<Identifier> tzzzd_ = a?.Identifier;
            List<Canonical> tzzze_ = a?.InstantiatesCanonicalElement;
            List<FhirUri> tzzzf_ = a?.InstantiatesUriElement;
            List<FhirUri> tzzzg_ = a?.InstantiatesElement;
            Code<RequestStatus> tzzzh_ = a?.StatusElement;
            Code<RequestIntent> tzzzi_ = a?.IntentElement;
            ResourceReference tzzzj_ = a?.Patient;
            ResourceReference tzzzk_ = a?.Encounter;
            FhirDateTime tzzzl_ = a?.DateTimeElement;
            ResourceReference tzzzm_ = a?.Orderer;
            List<ResourceReference> tzzzn_ = a?.AllergyIntolerance;
            List<CodeableConcept> tzzzo_ = a?.FoodPreferenceModifier;
            List<CodeableConcept> tzzzp_ = a?.ExcludeFoodModifier;
            NutritionOrder.OralDietComponent tzzzq_ = a?.OralDiet;
            List<NutritionOrder.SupplementComponent> tzzzr_ = a?.Supplement;
            NutritionOrder.EnteralFormulaComponent tzzzs_ = a?.EnteralFormula;
            List<Annotation> tzzzt_ = a?.Note;
            NutritionOrder tzzzu_ = new NutritionOrder
            {
                Identifier = new List<Identifier>((IEnumerable<Identifier>)tzzzd_),
                InstantiatesCanonicalElement = new List<Canonical>((IEnumerable<Canonical>)tzzze_),
                InstantiatesUriElement = new List<FhirUri>((IEnumerable<FhirUri>)tzzzf_),
                InstantiatesElement = new List<FhirUri>((IEnumerable<FhirUri>)tzzzg_),
                StatusElement = tzzzh_,
                IntentElement = tzzzi_,
                Patient = tzzzj_,
                Encounter = tzzzk_,
                DateTimeElement = tzzzl_,
                Orderer = tzzzm_,
                AllergyIntolerance = new List<ResourceReference>((IEnumerable<ResourceReference>)tzzzn_),
                FoodPreferenceModifier = new List<CodeableConcept>((IEnumerable<CodeableConcept>)tzzzo_),
                ExcludeFoodModifier = new List<CodeableConcept>((IEnumerable<CodeableConcept>)tzzzp_),
                OralDiet = tzzzq_,
                Supplement = new List<NutritionOrder.SupplementComponent>((IEnumerable<NutritionOrder.SupplementComponent>)tzzzr_),
                EnteralFormula = tzzzs_,
                Note = new List<Annotation>((IEnumerable<Annotation>)tzzzt_),
            };

            return tzzzu_;
        };
        IEnumerable<NutritionOrder> tzzza_ = context.Operators.Select<NutritionOrder, NutritionOrder>((IEnumerable<NutritionOrder>)szzzy_, szzzz_);
        IEnumerable<NutritionOrder> tzzzb_ = context.Operators.Distinct<NutritionOrder>(tzzza_);
        NutritionOrder tzzzc_ = context.Operators.SingletonFrom<NutritionOrder>(tzzzb_);

        return tzzzc_;
    }


    [CqlExpressionDefinition("ObservationResource")]
    public Observation ObservationResource(CqlContext context, Observation arg)
    {
        Observation[] tzzzv_ = [
            arg,
        ];
        Observation tzzzw_(Observation a)
        {
            List<Identifier> uzzza_ = a?.Identifier;
            List<ResourceReference> uzzzb_ = a?.BasedOn;
            List<ResourceReference> uzzzc_ = a?.PartOf;
            Code<ObservationStatus> uzzzd_ = a?.StatusElement;
            List<CodeableConcept> uzzze_ = a?.Category;
            CodeableConcept uzzzf_ = a?.Code;
            ResourceReference uzzzg_ = a?.Subject;
            List<ResourceReference> uzzzh_ = a?.Focus;
            ResourceReference uzzzi_ = a?.Encounter;
            DataType uzzzj_ = a?.Effective;
            Instant uzzzk_ = a?.IssuedElement;
            List<ResourceReference> uzzzl_ = a?.Performer;
            DataType uzzzm_ = a?.Value;
            CodeableConcept uzzzn_ = a?.DataAbsentReason;
            List<CodeableConcept> uzzzo_ = a?.Interpretation;
            List<Annotation> uzzzp_ = a?.Note;
            CodeableConcept uzzzq_ = a?.BodySite;
            CodeableConcept uzzzr_ = a?.Method;
            ResourceReference uzzzs_ = a?.Specimen;
            ResourceReference uzzzt_ = a?.Device;
            List<Observation.ReferenceRangeComponent> uzzzu_ = a?.ReferenceRange;
            List<ResourceReference> uzzzv_ = a?.HasMember;
            List<ResourceReference> uzzzw_ = a?.DerivedFrom;
            List<Observation.ComponentComponent> uzzzx_ = a?.Component;
            Observation uzzzy_ = new Observation
            {
                Identifier = new List<Identifier>((IEnumerable<Identifier>)uzzza_),
                BasedOn = new List<ResourceReference>((IEnumerable<ResourceReference>)uzzzb_),
                PartOf = new List<ResourceReference>((IEnumerable<ResourceReference>)uzzzc_),
                StatusElement = uzzzd_,
                Category = new List<CodeableConcept>((IEnumerable<CodeableConcept>)uzzze_),
                Code = uzzzf_,
                Subject = uzzzg_,
                Focus = new List<ResourceReference>((IEnumerable<ResourceReference>)uzzzh_),
                Encounter = uzzzi_,
                Effective = (DataType)uzzzj_,
                IssuedElement = uzzzk_,
                Performer = new List<ResourceReference>((IEnumerable<ResourceReference>)uzzzl_),
                Value = (DataType)uzzzm_,
                DataAbsentReason = uzzzn_,
                Interpretation = new List<CodeableConcept>((IEnumerable<CodeableConcept>)uzzzo_),
                Note = new List<Annotation>((IEnumerable<Annotation>)uzzzp_),
                BodySite = uzzzq_,
                Method = uzzzr_,
                Specimen = uzzzs_,
                Device = uzzzt_,
                ReferenceRange = new List<Observation.ReferenceRangeComponent>((IEnumerable<Observation.ReferenceRangeComponent>)uzzzu_),
                HasMember = new List<ResourceReference>((IEnumerable<ResourceReference>)uzzzv_),
                DerivedFrom = new List<ResourceReference>((IEnumerable<ResourceReference>)uzzzw_),
                Component = new List<Observation.ComponentComponent>((IEnumerable<Observation.ComponentComponent>)uzzzx_),
            };

            return uzzzy_;
        };
        IEnumerable<Observation> tzzzx_ = context.Operators.Select<Observation, Observation>((IEnumerable<Observation>)tzzzv_, tzzzw_);
        IEnumerable<Observation> tzzzy_ = context.Operators.Distinct<Observation>(tzzzx_);
        Observation tzzzz_ = context.Operators.SingletonFrom<Observation>(tzzzy_);

        return tzzzz_;
    }


    [CqlExpressionDefinition("ObservationDefinitionResource")]
    public ObservationDefinition ObservationDefinitionResource(CqlContext context, ObservationDefinition arg)
    {
        ObservationDefinition[] uzzzz_ = [
            arg,
        ];
        ObservationDefinition vzzza_(ObservationDefinition a)
        {
            List<CodeableConcept> vzzze_ = a?.Category;
            CodeableConcept vzzzf_ = a?.Code;
            List<Identifier> vzzzg_ = a?.Identifier;
            List<Code<ObservationDefinition.ObservationDataType>> vzzzh_ = a?.PermittedDataTypeElement;
            FhirBoolean vzzzi_ = a?.MultipleResultsAllowedElement;
            CodeableConcept vzzzj_ = a?.Method;
            FhirString vzzzk_ = a?.PreferredReportNameElement;
            ObservationDefinition.QuantitativeDetailsComponent vzzzl_ = a?.QuantitativeDetails;
            List<ObservationDefinition.QualifiedIntervalComponent> vzzzm_ = a?.QualifiedInterval;
            ResourceReference vzzzn_ = a?.ValidCodedValueSet;
            ResourceReference vzzzo_ = a?.NormalCodedValueSet;
            ResourceReference vzzzp_ = a?.AbnormalCodedValueSet;
            ResourceReference vzzzq_ = a?.CriticalCodedValueSet;
            ObservationDefinition vzzzr_ = new ObservationDefinition
            {
                Category = new List<CodeableConcept>((IEnumerable<CodeableConcept>)vzzze_),
                Code = vzzzf_,
                Identifier = new List<Identifier>((IEnumerable<Identifier>)vzzzg_),
                PermittedDataTypeElement = new List<Code<ObservationDefinition.ObservationDataType>>((IEnumerable<Code<ObservationDefinition.ObservationDataType>>)vzzzh_),
                MultipleResultsAllowedElement = vzzzi_,
                Method = vzzzj_,
                PreferredReportNameElement = vzzzk_,
                QuantitativeDetails = vzzzl_,
                QualifiedInterval = new List<ObservationDefinition.QualifiedIntervalComponent>((IEnumerable<ObservationDefinition.QualifiedIntervalComponent>)vzzzm_),
                ValidCodedValueSet = vzzzn_,
                NormalCodedValueSet = vzzzo_,
                AbnormalCodedValueSet = vzzzp_,
                CriticalCodedValueSet = vzzzq_,
            };

            return vzzzr_;
        };
        IEnumerable<ObservationDefinition> vzzzb_ = context.Operators.Select<ObservationDefinition, ObservationDefinition>((IEnumerable<ObservationDefinition>)uzzzz_, vzzza_);
        IEnumerable<ObservationDefinition> vzzzc_ = context.Operators.Distinct<ObservationDefinition>(vzzzb_);
        ObservationDefinition vzzzd_ = context.Operators.SingletonFrom<ObservationDefinition>(vzzzc_);

        return vzzzd_;
    }


    [CqlExpressionDefinition("OperationOutcomeResource")]
    public OperationOutcome OperationOutcomeResource(CqlContext context, OperationOutcome arg)
    {
        OperationOutcome[] vzzzs_ = [
            arg,
        ];
        OperationOutcome vzzzt_(OperationOutcome a)
        {
            List<OperationOutcome.IssueComponent> vzzzx_ = a?.Issue;
            OperationOutcome vzzzy_ = new OperationOutcome
            {
                Issue = new List<OperationOutcome.IssueComponent>((IEnumerable<OperationOutcome.IssueComponent>)vzzzx_),
            };

            return vzzzy_;
        };
        IEnumerable<OperationOutcome> vzzzu_ = context.Operators.Select<OperationOutcome, OperationOutcome>((IEnumerable<OperationOutcome>)vzzzs_, vzzzt_);
        IEnumerable<OperationOutcome> vzzzv_ = context.Operators.Distinct<OperationOutcome>(vzzzu_);
        OperationOutcome vzzzw_ = context.Operators.SingletonFrom<OperationOutcome>(vzzzv_);

        return vzzzw_;
    }


    [CqlExpressionDefinition("OrganizationResource")]
    public Organization OrganizationResource(CqlContext context, Organization arg)
    {
        Organization[] vzzzz_ = [
            arg,
        ];
        Organization wzzza_(Organization a)
        {
            List<Identifier> wzzze_ = a?.Identifier;
            FhirBoolean wzzzf_ = a?.ActiveElement;
            List<CodeableConcept> wzzzg_ = a?.Type;
            FhirString wzzzh_ = a?.NameElement;
            List<FhirString> wzzzi_ = a?.AliasElement;
            List<ContactPoint> wzzzj_ = a?.Telecom;
            List<Address> wzzzk_ = a?.Address;
            ResourceReference wzzzl_ = a?.PartOf;
            List<Organization.ContactComponent> wzzzm_ = a?.Contact;
            List<ResourceReference> wzzzn_ = a?.Endpoint;
            Organization wzzzo_ = new Organization
            {
                Identifier = new List<Identifier>((IEnumerable<Identifier>)wzzze_),
                ActiveElement = wzzzf_,
                Type = new List<CodeableConcept>((IEnumerable<CodeableConcept>)wzzzg_),
                NameElement = wzzzh_,
                AliasElement = new List<FhirString>((IEnumerable<FhirString>)wzzzi_),
                Telecom = new List<ContactPoint>((IEnumerable<ContactPoint>)wzzzj_),
                Address = new List<Address>((IEnumerable<Address>)wzzzk_),
                PartOf = wzzzl_,
                Contact = new List<Organization.ContactComponent>((IEnumerable<Organization.ContactComponent>)wzzzm_),
                Endpoint = new List<ResourceReference>((IEnumerable<ResourceReference>)wzzzn_),
            };

            return wzzzo_;
        };
        IEnumerable<Organization> wzzzb_ = context.Operators.Select<Organization, Organization>((IEnumerable<Organization>)vzzzz_, wzzza_);
        IEnumerable<Organization> wzzzc_ = context.Operators.Distinct<Organization>(wzzzb_);
        Organization wzzzd_ = context.Operators.SingletonFrom<Organization>(wzzzc_);

        return wzzzd_;
    }


    [CqlExpressionDefinition("OrganizationAffiliationResource")]
    public OrganizationAffiliation OrganizationAffiliationResource(CqlContext context, OrganizationAffiliation arg)
    {
        OrganizationAffiliation[] wzzzp_ = [
            arg,
        ];
        OrganizationAffiliation wzzzq_(OrganizationAffiliation a)
        {
            List<Identifier> wzzzu_ = a?.Identifier;
            FhirBoolean wzzzv_ = a?.ActiveElement;
            Period wzzzw_ = a?.Period;
            ResourceReference wzzzx_ = a?.Organization;
            ResourceReference wzzzy_ = a?.ParticipatingOrganization;
            List<ResourceReference> wzzzz_ = a?.Network;
            List<CodeableConcept> xzzza_ = a?.Code;
            List<CodeableConcept> xzzzb_ = a?.Specialty;
            List<ResourceReference> xzzzc_ = a?.Location;
            List<ResourceReference> xzzzd_ = a?.HealthcareService;
            List<ContactPoint> xzzze_ = a?.Telecom;
            List<ResourceReference> xzzzf_ = a?.Endpoint;
            OrganizationAffiliation xzzzg_ = new OrganizationAffiliation
            {
                Identifier = new List<Identifier>((IEnumerable<Identifier>)wzzzu_),
                ActiveElement = wzzzv_,
                Period = wzzzw_,
                Organization = wzzzx_,
                ParticipatingOrganization = wzzzy_,
                Network = new List<ResourceReference>((IEnumerable<ResourceReference>)wzzzz_),
                Code = new List<CodeableConcept>((IEnumerable<CodeableConcept>)xzzza_),
                Specialty = new List<CodeableConcept>((IEnumerable<CodeableConcept>)xzzzb_),
                Location = new List<ResourceReference>((IEnumerable<ResourceReference>)xzzzc_),
                HealthcareService = new List<ResourceReference>((IEnumerable<ResourceReference>)xzzzd_),
                Telecom = new List<ContactPoint>((IEnumerable<ContactPoint>)xzzze_),
                Endpoint = new List<ResourceReference>((IEnumerable<ResourceReference>)xzzzf_),
            };

            return xzzzg_;
        };
        IEnumerable<OrganizationAffiliation> wzzzr_ = context.Operators.Select<OrganizationAffiliation, OrganizationAffiliation>((IEnumerable<OrganizationAffiliation>)wzzzp_, wzzzq_);
        IEnumerable<OrganizationAffiliation> wzzzs_ = context.Operators.Distinct<OrganizationAffiliation>(wzzzr_);
        OrganizationAffiliation wzzzt_ = context.Operators.SingletonFrom<OrganizationAffiliation>(wzzzs_);

        return wzzzt_;
    }


    [CqlExpressionDefinition("PatientResource")]
    public Patient PatientResource(CqlContext context, Patient arg)
    {
        Patient[] xzzzh_ = [
            arg,
        ];
        Patient xzzzi_(Patient a)
        {
            List<Identifier> xzzzm_ = a?.Identifier;
            FhirBoolean xzzzn_ = a?.ActiveElement;
            List<HumanName> xzzzo_ = a?.Name;
            List<ContactPoint> xzzzp_ = a?.Telecom;
            Code<AdministrativeGender> xzzzq_ = a?.GenderElement;
            Date xzzzr_ = a?.BirthDateElement;
            DataType xzzzs_ = a?.Deceased;
            List<Address> xzzzt_ = a?.Address;
            CodeableConcept xzzzu_ = a?.MaritalStatus;
            DataType xzzzv_ = a?.MultipleBirth;
            List<Attachment> xzzzw_ = a?.Photo;
            List<Patient.ContactComponent> xzzzx_ = a?.Contact;
            List<Patient.CommunicationComponent> xzzzy_ = a?.Communication;
            List<ResourceReference> xzzzz_ = a?.GeneralPractitioner;
            ResourceReference yzzza_ = a?.ManagingOrganization;
            List<Patient.LinkComponent> yzzzb_ = a?.Link;
            Patient yzzzc_ = new Patient
            {
                Identifier = new List<Identifier>((IEnumerable<Identifier>)xzzzm_),
                ActiveElement = xzzzn_,
                Name = new List<HumanName>((IEnumerable<HumanName>)xzzzo_),
                Telecom = new List<ContactPoint>((IEnumerable<ContactPoint>)xzzzp_),
                GenderElement = xzzzq_,
                BirthDateElement = xzzzr_,
                Deceased = (DataType)xzzzs_,
                Address = new List<Address>((IEnumerable<Address>)xzzzt_),
                MaritalStatus = xzzzu_,
                MultipleBirth = (DataType)xzzzv_,
                Photo = new List<Attachment>((IEnumerable<Attachment>)xzzzw_),
                Contact = new List<Patient.ContactComponent>((IEnumerable<Patient.ContactComponent>)xzzzx_),
                Communication = new List<Patient.CommunicationComponent>((IEnumerable<Patient.CommunicationComponent>)xzzzy_),
                GeneralPractitioner = new List<ResourceReference>((IEnumerable<ResourceReference>)xzzzz_),
                ManagingOrganization = yzzza_,
                Link = new List<Patient.LinkComponent>((IEnumerable<Patient.LinkComponent>)yzzzb_),
            };

            return yzzzc_;
        };
        IEnumerable<Patient> xzzzj_ = context.Operators.Select<Patient, Patient>((IEnumerable<Patient>)xzzzh_, xzzzi_);
        IEnumerable<Patient> xzzzk_ = context.Operators.Distinct<Patient>(xzzzj_);
        Patient xzzzl_ = context.Operators.SingletonFrom<Patient>(xzzzk_);

        return xzzzl_;
    }


    [CqlExpressionDefinition("PaymentNoticeResource")]
    public PaymentNotice PaymentNoticeResource(CqlContext context, PaymentNotice arg)
    {
        PaymentNotice[] yzzzd_ = [
            arg,
        ];
        PaymentNotice yzzze_(PaymentNotice a)
        {
            List<Identifier> yzzzi_ = a?.Identifier;
            Code<FinancialResourceStatusCodes> yzzzj_ = a?.StatusElement;
            ResourceReference yzzzk_ = a?.Request;
            ResourceReference yzzzl_ = a?.Response;
            FhirDateTime yzzzm_ = a?.CreatedElement;
            ResourceReference yzzzn_ = a?.Provider;
            ResourceReference yzzzo_ = a?.Payment;
            Date yzzzp_ = a?.PaymentDateElement;
            ResourceReference yzzzq_ = a?.Payee;
            ResourceReference yzzzr_ = a?.Recipient;
            Money yzzzs_ = a?.Amount;
            CodeableConcept yzzzt_ = a?.PaymentStatus;
            PaymentNotice yzzzu_ = new PaymentNotice
            {
                Identifier = new List<Identifier>((IEnumerable<Identifier>)yzzzi_),
                StatusElement = yzzzj_,
                Request = yzzzk_,
                Response = yzzzl_,
                CreatedElement = yzzzm_,
                Provider = yzzzn_,
                Payment = yzzzo_,
                PaymentDateElement = yzzzp_,
                Payee = yzzzq_,
                Recipient = yzzzr_,
                Amount = yzzzs_,
                PaymentStatus = yzzzt_,
            };

            return yzzzu_;
        };
        IEnumerable<PaymentNotice> yzzzf_ = context.Operators.Select<PaymentNotice, PaymentNotice>((IEnumerable<PaymentNotice>)yzzzd_, yzzze_);
        IEnumerable<PaymentNotice> yzzzg_ = context.Operators.Distinct<PaymentNotice>(yzzzf_);
        PaymentNotice yzzzh_ = context.Operators.SingletonFrom<PaymentNotice>(yzzzg_);

        return yzzzh_;
    }


    [CqlExpressionDefinition("PaymentReconciliationResource")]
    public PaymentReconciliation PaymentReconciliationResource(CqlContext context, PaymentReconciliation arg)
    {
        PaymentReconciliation[] yzzzv_ = [
            arg,
        ];
        PaymentReconciliation yzzzw_(PaymentReconciliation a)
        {
            List<Identifier> zzzza_ = a?.Identifier;
            Code<FinancialResourceStatusCodes> zzzzb_ = a?.StatusElement;
            Period zzzzc_ = a?.Period;
            FhirDateTime zzzzd_ = a?.CreatedElement;
            ResourceReference zzzze_ = a?.PaymentIssuer;
            ResourceReference zzzzf_ = a?.Request;
            ResourceReference zzzzg_ = a?.Requestor;
            Code<ClaimProcessingCodes> zzzzh_ = a?.OutcomeElement;
            FhirString zzzzi_ = a?.DispositionElement;
            Date zzzzj_ = a?.PaymentDateElement;
            Money zzzzk_ = a?.PaymentAmount;
            Identifier zzzzl_ = a?.PaymentIdentifier;
            List<PaymentReconciliation.DetailsComponent> zzzzm_ = a?.Detail;
            CodeableConcept zzzzn_ = a?.FormCode;
            List<PaymentReconciliation.NotesComponent> zzzzo_ = a?.ProcessNote;
            PaymentReconciliation zzzzp_ = new PaymentReconciliation
            {
                Identifier = new List<Identifier>((IEnumerable<Identifier>)zzzza_),
                StatusElement = zzzzb_,
                Period = zzzzc_,
                CreatedElement = zzzzd_,
                PaymentIssuer = zzzze_,
                Request = zzzzf_,
                Requestor = zzzzg_,
                OutcomeElement = zzzzh_,
                DispositionElement = zzzzi_,
                PaymentDateElement = zzzzj_,
                PaymentAmount = zzzzk_,
                PaymentIdentifier = zzzzl_,
                Detail = new List<PaymentReconciliation.DetailsComponent>((IEnumerable<PaymentReconciliation.DetailsComponent>)zzzzm_),
                FormCode = zzzzn_,
                ProcessNote = new List<PaymentReconciliation.NotesComponent>((IEnumerable<PaymentReconciliation.NotesComponent>)zzzzo_),
            };

            return zzzzp_;
        };
        IEnumerable<PaymentReconciliation> yzzzx_ = context.Operators.Select<PaymentReconciliation, PaymentReconciliation>((IEnumerable<PaymentReconciliation>)yzzzv_, yzzzw_);
        IEnumerable<PaymentReconciliation> yzzzy_ = context.Operators.Distinct<PaymentReconciliation>(yzzzx_);
        PaymentReconciliation yzzzz_ = context.Operators.SingletonFrom<PaymentReconciliation>(yzzzy_);

        return yzzzz_;
    }


    [CqlExpressionDefinition("PersonResource")]
    public Person PersonResource(CqlContext context, Person arg)
    {
        Person[] zzzzq_ = [
            arg,
        ];
        Person zzzzr_(Person a)
        {
            List<Identifier> zzzzv_ = a?.Identifier;
            List<HumanName> zzzzw_ = a?.Name;
            List<ContactPoint> zzzzx_ = a?.Telecom;
            Code<AdministrativeGender> zzzzy_ = a?.GenderElement;
            Date zzzzz_ = a?.BirthDateElement;
            List<Address> azzzza_ = a?.Address;
            Attachment azzzzb_ = a?.Photo;
            ResourceReference azzzzc_ = a?.ManagingOrganization;
            FhirBoolean azzzzd_ = a?.ActiveElement;
            List<Person.LinkComponent> azzzze_ = a?.Link;
            Person azzzzf_ = new Person
            {
                Identifier = new List<Identifier>((IEnumerable<Identifier>)zzzzv_),
                Name = new List<HumanName>((IEnumerable<HumanName>)zzzzw_),
                Telecom = new List<ContactPoint>((IEnumerable<ContactPoint>)zzzzx_),
                GenderElement = zzzzy_,
                BirthDateElement = zzzzz_,
                Address = new List<Address>((IEnumerable<Address>)azzzza_),
                Photo = azzzzb_,
                ManagingOrganization = azzzzc_,
                ActiveElement = azzzzd_,
                Link = new List<Person.LinkComponent>((IEnumerable<Person.LinkComponent>)azzzze_),
            };

            return azzzzf_;
        };
        IEnumerable<Person> zzzzs_ = context.Operators.Select<Person, Person>((IEnumerable<Person>)zzzzq_, zzzzr_);
        IEnumerable<Person> zzzzt_ = context.Operators.Distinct<Person>(zzzzs_);
        Person zzzzu_ = context.Operators.SingletonFrom<Person>(zzzzt_);

        return zzzzu_;
    }


    [CqlExpressionDefinition("PlanDefinitionResource")]
    public PlanDefinition PlanDefinitionResource(CqlContext context, PlanDefinition arg)
    {
        PlanDefinition[] azzzzg_ = [
            arg,
        ];
        PlanDefinition azzzzh_(PlanDefinition a)
        {
            FhirUri azzzzl_ = a?.UrlElement;
            List<Identifier> azzzzm_ = a?.Identifier;
            FhirString azzzzn_ = a?.VersionElement;
            FhirString azzzzo_ = a?.NameElement;
            FhirString azzzzp_ = a?.TitleElement;
            FhirString azzzzq_ = a?.SubtitleElement;
            CodeableConcept azzzzr_ = a?.Type;
            Code<PublicationStatus> azzzzs_ = a?.StatusElement;
            FhirBoolean azzzzt_ = a?.ExperimentalElement;
            DataType azzzzu_ = a?.Subject;
            FhirDateTime azzzzv_ = a?.DateElement;
            FhirString azzzzw_ = a?.PublisherElement;
            List<ContactDetail> azzzzx_ = a?.Contact;
            Markdown azzzzy_ = a?.DescriptionElement;
            List<UsageContext> azzzzz_ = a?.UseContext;
            List<CodeableConcept> bzzzza_ = a?.Jurisdiction;
            Markdown bzzzzb_ = a?.PurposeElement;
            FhirString bzzzzc_ = a?.UsageElement;
            Markdown bzzzzd_ = a?.CopyrightElement;
            Date bzzzze_ = a?.ApprovalDateElement;
            Date bzzzzf_ = a?.LastReviewDateElement;
            Period bzzzzg_ = a?.EffectivePeriod;
            List<CodeableConcept> bzzzzh_ = a?.Topic;
            List<ContactDetail> bzzzzi_ = a?.Author;
            List<ContactDetail> bzzzzj_ = a?.Editor;
            List<ContactDetail> bzzzzk_ = a?.Reviewer;
            List<ContactDetail> bzzzzl_ = a?.Endorser;
            List<RelatedArtifact> bzzzzm_ = a?.RelatedArtifact;
            List<Canonical> bzzzzn_ = a?.LibraryElement;
            List<PlanDefinition.GoalComponent> bzzzzo_ = a?.Goal;
            List<PlanDefinition.ActionComponent> bzzzzp_ = a?.Action;
            PlanDefinition bzzzzq_ = new PlanDefinition
            {
                UrlElement = azzzzl_,
                Identifier = new List<Identifier>((IEnumerable<Identifier>)azzzzm_),
                VersionElement = azzzzn_,
                NameElement = azzzzo_,
                TitleElement = azzzzp_,
                SubtitleElement = azzzzq_,
                Type = azzzzr_,
                StatusElement = azzzzs_,
                ExperimentalElement = azzzzt_,
                Subject = (DataType)azzzzu_,
                DateElement = azzzzv_,
                PublisherElement = azzzzw_,
                Contact = new List<ContactDetail>((IEnumerable<ContactDetail>)azzzzx_),
                DescriptionElement = azzzzy_,
                UseContext = new List<UsageContext>((IEnumerable<UsageContext>)azzzzz_),
                Jurisdiction = new List<CodeableConcept>((IEnumerable<CodeableConcept>)bzzzza_),
                PurposeElement = bzzzzb_,
                UsageElement = bzzzzc_,
                CopyrightElement = bzzzzd_,
                ApprovalDateElement = bzzzze_,
                LastReviewDateElement = bzzzzf_,
                EffectivePeriod = bzzzzg_,
                Topic = new List<CodeableConcept>((IEnumerable<CodeableConcept>)bzzzzh_),
                Author = new List<ContactDetail>((IEnumerable<ContactDetail>)bzzzzi_),
                Editor = new List<ContactDetail>((IEnumerable<ContactDetail>)bzzzzj_),
                Reviewer = new List<ContactDetail>((IEnumerable<ContactDetail>)bzzzzk_),
                Endorser = new List<ContactDetail>((IEnumerable<ContactDetail>)bzzzzl_),
                RelatedArtifact = new List<RelatedArtifact>((IEnumerable<RelatedArtifact>)bzzzzm_),
                LibraryElement = new List<Canonical>((IEnumerable<Canonical>)bzzzzn_),
                Goal = new List<PlanDefinition.GoalComponent>((IEnumerable<PlanDefinition.GoalComponent>)bzzzzo_),
                Action = new List<PlanDefinition.ActionComponent>((IEnumerable<PlanDefinition.ActionComponent>)bzzzzp_),
            };

            return bzzzzq_;
        };
        IEnumerable<PlanDefinition> azzzzi_ = context.Operators.Select<PlanDefinition, PlanDefinition>((IEnumerable<PlanDefinition>)azzzzg_, azzzzh_);
        IEnumerable<PlanDefinition> azzzzj_ = context.Operators.Distinct<PlanDefinition>(azzzzi_);
        PlanDefinition azzzzk_ = context.Operators.SingletonFrom<PlanDefinition>(azzzzj_);

        return azzzzk_;
    }


    [CqlExpressionDefinition("PractitionerResource")]
    public Practitioner PractitionerResource(CqlContext context, Practitioner arg)
    {
        Practitioner[] bzzzzr_ = [
            arg,
        ];
        Practitioner bzzzzs_(Practitioner a)
        {
            List<Identifier> bzzzzw_ = a?.Identifier;
            FhirBoolean bzzzzx_ = a?.ActiveElement;
            List<HumanName> bzzzzy_ = a?.Name;
            List<ContactPoint> bzzzzz_ = a?.Telecom;
            List<Address> czzzza_ = a?.Address;
            Code<AdministrativeGender> czzzzb_ = a?.GenderElement;
            Date czzzzc_ = a?.BirthDateElement;
            List<Attachment> czzzzd_ = a?.Photo;
            List<Practitioner.QualificationComponent> czzzze_ = a?.Qualification;
            List<CodeableConcept> czzzzf_ = a?.Communication;
            Practitioner czzzzg_ = new Practitioner
            {
                Identifier = new List<Identifier>((IEnumerable<Identifier>)bzzzzw_),
                ActiveElement = bzzzzx_,
                Name = new List<HumanName>((IEnumerable<HumanName>)bzzzzy_),
                Telecom = new List<ContactPoint>((IEnumerable<ContactPoint>)bzzzzz_),
                Address = new List<Address>((IEnumerable<Address>)czzzza_),
                GenderElement = czzzzb_,
                BirthDateElement = czzzzc_,
                Photo = new List<Attachment>((IEnumerable<Attachment>)czzzzd_),
                Qualification = new List<Practitioner.QualificationComponent>((IEnumerable<Practitioner.QualificationComponent>)czzzze_),
                Communication = new List<CodeableConcept>((IEnumerable<CodeableConcept>)czzzzf_),
            };

            return czzzzg_;
        };
        IEnumerable<Practitioner> bzzzzt_ = context.Operators.Select<Practitioner, Practitioner>((IEnumerable<Practitioner>)bzzzzr_, bzzzzs_);
        IEnumerable<Practitioner> bzzzzu_ = context.Operators.Distinct<Practitioner>(bzzzzt_);
        Practitioner bzzzzv_ = context.Operators.SingletonFrom<Practitioner>(bzzzzu_);

        return bzzzzv_;
    }


    [CqlExpressionDefinition("PractitionerRoleResource")]
    public PractitionerRole PractitionerRoleResource(CqlContext context, PractitionerRole arg)
    {
        PractitionerRole[] czzzzh_ = [
            arg,
        ];
        PractitionerRole czzzzi_(PractitionerRole a)
        {
            List<Identifier> czzzzm_ = a?.Identifier;
            FhirBoolean czzzzn_ = a?.ActiveElement;
            Period czzzzo_ = a?.Period;
            ResourceReference czzzzp_ = a?.Practitioner;
            ResourceReference czzzzq_ = a?.Organization;
            List<CodeableConcept> czzzzr_ = a?.Code;
            List<CodeableConcept> czzzzs_ = a?.Specialty;
            List<ResourceReference> czzzzt_ = a?.Location;
            List<ResourceReference> czzzzu_ = a?.HealthcareService;
            List<ContactPoint> czzzzv_ = a?.Telecom;
            List<PractitionerRole.AvailableTimeComponent> czzzzw_ = a?.AvailableTime;
            List<PractitionerRole.NotAvailableComponent> czzzzx_ = a?.NotAvailable;
            FhirString czzzzy_ = a?.AvailabilityExceptionsElement;
            List<ResourceReference> czzzzz_ = a?.Endpoint;
            PractitionerRole dzzzza_ = new PractitionerRole
            {
                Identifier = new List<Identifier>((IEnumerable<Identifier>)czzzzm_),
                ActiveElement = czzzzn_,
                Period = czzzzo_,
                Practitioner = czzzzp_,
                Organization = czzzzq_,
                Code = new List<CodeableConcept>((IEnumerable<CodeableConcept>)czzzzr_),
                Specialty = new List<CodeableConcept>((IEnumerable<CodeableConcept>)czzzzs_),
                Location = new List<ResourceReference>((IEnumerable<ResourceReference>)czzzzt_),
                HealthcareService = new List<ResourceReference>((IEnumerable<ResourceReference>)czzzzu_),
                Telecom = new List<ContactPoint>((IEnumerable<ContactPoint>)czzzzv_),
                AvailableTime = new List<PractitionerRole.AvailableTimeComponent>((IEnumerable<PractitionerRole.AvailableTimeComponent>)czzzzw_),
                NotAvailable = new List<PractitionerRole.NotAvailableComponent>((IEnumerable<PractitionerRole.NotAvailableComponent>)czzzzx_),
                AvailabilityExceptionsElement = czzzzy_,
                Endpoint = new List<ResourceReference>((IEnumerable<ResourceReference>)czzzzz_),
            };

            return dzzzza_;
        };
        IEnumerable<PractitionerRole> czzzzj_ = context.Operators.Select<PractitionerRole, PractitionerRole>((IEnumerable<PractitionerRole>)czzzzh_, czzzzi_);
        IEnumerable<PractitionerRole> czzzzk_ = context.Operators.Distinct<PractitionerRole>(czzzzj_);
        PractitionerRole czzzzl_ = context.Operators.SingletonFrom<PractitionerRole>(czzzzk_);

        return czzzzl_;
    }


    [CqlExpressionDefinition("ProcedureResource")]
    public Procedure ProcedureResource(CqlContext context, Procedure arg)
    {
        Procedure[] dzzzzb_ = [
            arg,
        ];
        Procedure dzzzzc_(Procedure a)
        {
            List<Identifier> dzzzzg_ = a?.Identifier;
            List<Canonical> dzzzzh_ = a?.InstantiatesCanonicalElement;
            List<FhirUri> dzzzzi_ = a?.InstantiatesUriElement;
            List<ResourceReference> dzzzzj_ = a?.BasedOn;
            List<ResourceReference> dzzzzk_ = a?.PartOf;
            Code<EventStatus> dzzzzl_ = a?.StatusElement;
            CodeableConcept dzzzzm_ = a?.StatusReason;
            CodeableConcept dzzzzn_ = a?.Category;
            CodeableConcept dzzzzo_ = a?.Code;
            ResourceReference dzzzzp_ = a?.Subject;
            ResourceReference dzzzzq_ = a?.Encounter;
            DataType dzzzzr_ = a?.Performed;
            ResourceReference dzzzzs_ = a?.Recorder;
            ResourceReference dzzzzt_ = a?.Asserter;
            List<Procedure.PerformerComponent> dzzzzu_ = a?.Performer;
            ResourceReference dzzzzv_ = a?.Location;
            List<CodeableConcept> dzzzzw_ = a?.ReasonCode;
            List<ResourceReference> dzzzzx_ = a?.ReasonReference;
            List<CodeableConcept> dzzzzy_ = a?.BodySite;
            CodeableConcept dzzzzz_ = a?.Outcome;
            List<ResourceReference> ezzzza_ = a?.Report;
            List<CodeableConcept> ezzzzb_ = a?.Complication;
            List<ResourceReference> ezzzzc_ = a?.ComplicationDetail;
            List<CodeableConcept> ezzzzd_ = a?.FollowUp;
            List<Annotation> ezzzze_ = a?.Note;
            List<Procedure.FocalDeviceComponent> ezzzzf_ = a?.FocalDevice;
            List<ResourceReference> ezzzzg_ = a?.UsedReference;
            List<CodeableConcept> ezzzzh_ = a?.UsedCode;
            Procedure ezzzzi_ = new Procedure
            {
                Identifier = new List<Identifier>((IEnumerable<Identifier>)dzzzzg_),
                InstantiatesCanonicalElement = new List<Canonical>((IEnumerable<Canonical>)dzzzzh_),
                InstantiatesUriElement = new List<FhirUri>((IEnumerable<FhirUri>)dzzzzi_),
                BasedOn = new List<ResourceReference>((IEnumerable<ResourceReference>)dzzzzj_),
                PartOf = new List<ResourceReference>((IEnumerable<ResourceReference>)dzzzzk_),
                StatusElement = dzzzzl_,
                StatusReason = dzzzzm_,
                Category = dzzzzn_,
                Code = dzzzzo_,
                Subject = dzzzzp_,
                Encounter = dzzzzq_,
                Performed = (DataType)dzzzzr_,
                Recorder = dzzzzs_,
                Asserter = dzzzzt_,
                Performer = new List<Procedure.PerformerComponent>((IEnumerable<Procedure.PerformerComponent>)dzzzzu_),
                Location = dzzzzv_,
                ReasonCode = new List<CodeableConcept>((IEnumerable<CodeableConcept>)dzzzzw_),
                ReasonReference = new List<ResourceReference>((IEnumerable<ResourceReference>)dzzzzx_),
                BodySite = new List<CodeableConcept>((IEnumerable<CodeableConcept>)dzzzzy_),
                Outcome = dzzzzz_,
                Report = new List<ResourceReference>((IEnumerable<ResourceReference>)ezzzza_),
                Complication = new List<CodeableConcept>((IEnumerable<CodeableConcept>)ezzzzb_),
                ComplicationDetail = new List<ResourceReference>((IEnumerable<ResourceReference>)ezzzzc_),
                FollowUp = new List<CodeableConcept>((IEnumerable<CodeableConcept>)ezzzzd_),
                Note = new List<Annotation>((IEnumerable<Annotation>)ezzzze_),
                FocalDevice = new List<Procedure.FocalDeviceComponent>((IEnumerable<Procedure.FocalDeviceComponent>)ezzzzf_),
                UsedReference = new List<ResourceReference>((IEnumerable<ResourceReference>)ezzzzg_),
                UsedCode = new List<CodeableConcept>((IEnumerable<CodeableConcept>)ezzzzh_),
            };

            return ezzzzi_;
        };
        IEnumerable<Procedure> dzzzzd_ = context.Operators.Select<Procedure, Procedure>((IEnumerable<Procedure>)dzzzzb_, dzzzzc_);
        IEnumerable<Procedure> dzzzze_ = context.Operators.Distinct<Procedure>(dzzzzd_);
        Procedure dzzzzf_ = context.Operators.SingletonFrom<Procedure>(dzzzze_);

        return dzzzzf_;
    }


    [CqlExpressionDefinition("ProvenanceResource")]
    public Provenance ProvenanceResource(CqlContext context, Provenance arg)
    {
        Provenance[] ezzzzj_ = [
            arg,
        ];
        Provenance ezzzzk_(Provenance a)
        {
            List<ResourceReference> ezzzzo_ = a?.Target;
            DataType ezzzzp_ = a?.Occurred;
            Instant ezzzzq_ = a?.RecordedElement;
            List<FhirUri> ezzzzr_ = a?.PolicyElement;
            ResourceReference ezzzzs_ = a?.Location;
            List<CodeableConcept> ezzzzt_ = a?.Reason;
            CodeableConcept ezzzzu_ = a?.Activity;
            List<Provenance.AgentComponent> ezzzzv_ = a?.Agent;
            List<Provenance.EntityComponent> ezzzzw_ = a?.Entity;
            List<Signature> ezzzzx_ = a?.Signature;
            Provenance ezzzzy_ = new Provenance
            {
                Target = new List<ResourceReference>((IEnumerable<ResourceReference>)ezzzzo_),
                Occurred = (DataType)ezzzzp_,
                RecordedElement = ezzzzq_,
                PolicyElement = new List<FhirUri>((IEnumerable<FhirUri>)ezzzzr_),
                Location = ezzzzs_,
                Reason = new List<CodeableConcept>((IEnumerable<CodeableConcept>)ezzzzt_),
                Activity = ezzzzu_,
                Agent = new List<Provenance.AgentComponent>((IEnumerable<Provenance.AgentComponent>)ezzzzv_),
                Entity = new List<Provenance.EntityComponent>((IEnumerable<Provenance.EntityComponent>)ezzzzw_),
                Signature = new List<Signature>((IEnumerable<Signature>)ezzzzx_),
            };

            return ezzzzy_;
        };
        IEnumerable<Provenance> ezzzzl_ = context.Operators.Select<Provenance, Provenance>((IEnumerable<Provenance>)ezzzzj_, ezzzzk_);
        IEnumerable<Provenance> ezzzzm_ = context.Operators.Distinct<Provenance>(ezzzzl_);
        Provenance ezzzzn_ = context.Operators.SingletonFrom<Provenance>(ezzzzm_);

        return ezzzzn_;
    }


    [CqlExpressionDefinition("QuestionnaireResponseResource")]
    public QuestionnaireResponse QuestionnaireResponseResource(CqlContext context, QuestionnaireResponse arg)
    {
        QuestionnaireResponse[] ezzzzz_ = [
            arg,
        ];
        QuestionnaireResponse fzzzza_(QuestionnaireResponse a)
        {
            Identifier fzzzze_ = a?.Identifier;
            List<ResourceReference> fzzzzf_ = a?.BasedOn;
            List<ResourceReference> fzzzzg_ = a?.PartOf;
            Canonical fzzzzh_ = a?.QuestionnaireElement;
            Code<QuestionnaireResponse.QuestionnaireResponseStatus> fzzzzi_ = a?.StatusElement;
            ResourceReference fzzzzj_ = a?.Subject;
            ResourceReference fzzzzk_ = a?.Encounter;
            FhirDateTime fzzzzl_ = a?.AuthoredElement;
            ResourceReference fzzzzm_ = a?.Author;
            ResourceReference fzzzzn_ = a?.Source;
            List<QuestionnaireResponse.ItemComponent> fzzzzo_ = a?.Item;
            QuestionnaireResponse fzzzzp_ = new QuestionnaireResponse
            {
                Identifier = fzzzze_,
                BasedOn = new List<ResourceReference>((IEnumerable<ResourceReference>)fzzzzf_),
                PartOf = new List<ResourceReference>((IEnumerable<ResourceReference>)fzzzzg_),
                QuestionnaireElement = fzzzzh_,
                StatusElement = fzzzzi_,
                Subject = fzzzzj_,
                Encounter = fzzzzk_,
                AuthoredElement = fzzzzl_,
                Author = fzzzzm_,
                Source = fzzzzn_,
                Item = new List<QuestionnaireResponse.ItemComponent>((IEnumerable<QuestionnaireResponse.ItemComponent>)fzzzzo_),
            };

            return fzzzzp_;
        };
        IEnumerable<QuestionnaireResponse> fzzzzb_ = context.Operators.Select<QuestionnaireResponse, QuestionnaireResponse>((IEnumerable<QuestionnaireResponse>)ezzzzz_, fzzzza_);
        IEnumerable<QuestionnaireResponse> fzzzzc_ = context.Operators.Distinct<QuestionnaireResponse>(fzzzzb_);
        QuestionnaireResponse fzzzzd_ = context.Operators.SingletonFrom<QuestionnaireResponse>(fzzzzc_);

        return fzzzzd_;
    }


    [CqlExpressionDefinition("RelatedPersonResource")]
    public RelatedPerson RelatedPersonResource(CqlContext context, RelatedPerson arg)
    {
        RelatedPerson[] fzzzzq_ = [
            arg,
        ];
        RelatedPerson fzzzzr_(RelatedPerson a)
        {
            List<Identifier> fzzzzv_ = a?.Identifier;
            FhirBoolean fzzzzw_ = a?.ActiveElement;
            ResourceReference fzzzzx_ = a?.Patient;
            List<CodeableConcept> fzzzzy_ = a?.Relationship;
            List<HumanName> fzzzzz_ = a?.Name;
            List<ContactPoint> gzzzza_ = a?.Telecom;
            Code<AdministrativeGender> gzzzzb_ = a?.GenderElement;
            Date gzzzzc_ = a?.BirthDateElement;
            List<Address> gzzzzd_ = a?.Address;
            List<Attachment> gzzzze_ = a?.Photo;
            Period gzzzzf_ = a?.Period;
            List<RelatedPerson.CommunicationComponent> gzzzzg_ = a?.Communication;
            RelatedPerson gzzzzh_ = new RelatedPerson
            {
                Identifier = new List<Identifier>((IEnumerable<Identifier>)fzzzzv_),
                ActiveElement = fzzzzw_,
                Patient = fzzzzx_,
                Relationship = new List<CodeableConcept>((IEnumerable<CodeableConcept>)fzzzzy_),
                Name = new List<HumanName>((IEnumerable<HumanName>)fzzzzz_),
                Telecom = new List<ContactPoint>((IEnumerable<ContactPoint>)gzzzza_),
                GenderElement = gzzzzb_,
                BirthDateElement = gzzzzc_,
                Address = new List<Address>((IEnumerable<Address>)gzzzzd_),
                Photo = new List<Attachment>((IEnumerable<Attachment>)gzzzze_),
                Period = gzzzzf_,
                Communication = new List<RelatedPerson.CommunicationComponent>((IEnumerable<RelatedPerson.CommunicationComponent>)gzzzzg_),
            };

            return gzzzzh_;
        };
        IEnumerable<RelatedPerson> fzzzzs_ = context.Operators.Select<RelatedPerson, RelatedPerson>((IEnumerable<RelatedPerson>)fzzzzq_, fzzzzr_);
        IEnumerable<RelatedPerson> fzzzzt_ = context.Operators.Distinct<RelatedPerson>(fzzzzs_);
        RelatedPerson fzzzzu_ = context.Operators.SingletonFrom<RelatedPerson>(fzzzzt_);

        return fzzzzu_;
    }


    [CqlExpressionDefinition("RequestGroupResource")]
    public RequestGroup RequestGroupResource(CqlContext context, RequestGroup arg)
    {
        RequestGroup[] gzzzzi_ = [
            arg,
        ];
        RequestGroup gzzzzj_(RequestGroup a)
        {
            List<Identifier> gzzzzn_ = a?.Identifier;
            List<Canonical> gzzzzo_ = a?.InstantiatesCanonicalElement;
            List<FhirUri> gzzzzp_ = a?.InstantiatesUriElement;
            List<ResourceReference> gzzzzq_ = a?.BasedOn;
            List<ResourceReference> gzzzzr_ = a?.Replaces;
            Identifier gzzzzs_ = a?.GroupIdentifier;
            Code<RequestStatus> gzzzzt_ = a?.StatusElement;
            Code<RequestIntent> gzzzzu_ = a?.IntentElement;
            Code<RequestPriority> gzzzzv_ = a?.PriorityElement;
            CodeableConcept gzzzzw_ = a?.Code;
            ResourceReference gzzzzx_ = a?.Subject;
            ResourceReference gzzzzy_ = a?.Encounter;
            FhirDateTime gzzzzz_ = a?.AuthoredOnElement;
            ResourceReference hzzzza_ = a?.Author;
            List<CodeableConcept> hzzzzb_ = a?.ReasonCode;
            List<ResourceReference> hzzzzc_ = a?.ReasonReference;
            List<Annotation> hzzzzd_ = a?.Note;
            List<RequestGroup.ActionComponent> hzzzze_ = a?.Action;
            RequestGroup hzzzzf_ = new RequestGroup
            {
                Identifier = new List<Identifier>((IEnumerable<Identifier>)gzzzzn_),
                InstantiatesCanonicalElement = new List<Canonical>((IEnumerable<Canonical>)gzzzzo_),
                InstantiatesUriElement = new List<FhirUri>((IEnumerable<FhirUri>)gzzzzp_),
                BasedOn = new List<ResourceReference>((IEnumerable<ResourceReference>)gzzzzq_),
                Replaces = new List<ResourceReference>((IEnumerable<ResourceReference>)gzzzzr_),
                GroupIdentifier = gzzzzs_,
                StatusElement = gzzzzt_,
                IntentElement = gzzzzu_,
                PriorityElement = gzzzzv_,
                Code = gzzzzw_,
                Subject = gzzzzx_,
                Encounter = gzzzzy_,
                AuthoredOnElement = gzzzzz_,
                Author = hzzzza_,
                ReasonCode = new List<CodeableConcept>((IEnumerable<CodeableConcept>)hzzzzb_),
                ReasonReference = new List<ResourceReference>((IEnumerable<ResourceReference>)hzzzzc_),
                Note = new List<Annotation>((IEnumerable<Annotation>)hzzzzd_),
                Action = new List<RequestGroup.ActionComponent>((IEnumerable<RequestGroup.ActionComponent>)hzzzze_),
            };

            return hzzzzf_;
        };
        IEnumerable<RequestGroup> gzzzzk_ = context.Operators.Select<RequestGroup, RequestGroup>((IEnumerable<RequestGroup>)gzzzzi_, gzzzzj_);
        IEnumerable<RequestGroup> gzzzzl_ = context.Operators.Distinct<RequestGroup>(gzzzzk_);
        RequestGroup gzzzzm_ = context.Operators.SingletonFrom<RequestGroup>(gzzzzl_);

        return gzzzzm_;
    }


    [CqlExpressionDefinition("ResearchDefinitionResource")]
    public ResearchDefinition ResearchDefinitionResource(CqlContext context, ResearchDefinition arg)
    {
        ResearchDefinition[] hzzzzg_ = [
            arg,
        ];
        ResearchDefinition hzzzzh_(ResearchDefinition a)
        {
            FhirUri hzzzzl_ = a?.UrlElement;
            List<Identifier> hzzzzm_ = a?.Identifier;
            FhirString hzzzzn_ = a?.VersionElement;
            FhirString hzzzzo_ = a?.NameElement;
            FhirString hzzzzp_ = a?.TitleElement;
            FhirString hzzzzq_ = a?.ShortTitleElement;
            FhirString hzzzzr_ = a?.SubtitleElement;
            Code<PublicationStatus> hzzzzs_ = a?.StatusElement;
            FhirBoolean hzzzzt_ = a?.ExperimentalElement;
            DataType hzzzzu_ = a?.Subject;
            FhirDateTime hzzzzv_ = a?.DateElement;
            FhirString hzzzzw_ = a?.PublisherElement;
            List<ContactDetail> hzzzzx_ = a?.Contact;
            Markdown hzzzzy_ = a?.DescriptionElement;
            List<FhirString> hzzzzz_ = a?.CommentElement;
            List<UsageContext> izzzza_ = a?.UseContext;
            List<CodeableConcept> izzzzb_ = a?.Jurisdiction;
            Markdown izzzzc_ = a?.PurposeElement;
            FhirString izzzzd_ = a?.UsageElement;
            Markdown izzzze_ = a?.CopyrightElement;
            Date izzzzf_ = a?.ApprovalDateElement;
            Date izzzzg_ = a?.LastReviewDateElement;
            Period izzzzh_ = a?.EffectivePeriod;
            List<CodeableConcept> izzzzi_ = a?.Topic;
            List<ContactDetail> izzzzj_ = a?.Author;
            List<ContactDetail> izzzzk_ = a?.Editor;
            List<ContactDetail> izzzzl_ = a?.Reviewer;
            List<ContactDetail> izzzzm_ = a?.Endorser;
            List<RelatedArtifact> izzzzn_ = a?.RelatedArtifact;
            List<Canonical> izzzzo_ = a?.LibraryElement;
            ResourceReference izzzzp_ = a?.Population;
            ResourceReference izzzzq_ = a?.Exposure;
            ResourceReference izzzzr_ = a?.ExposureAlternative;
            ResourceReference izzzzs_ = a?.Outcome;
            ResearchDefinition izzzzt_ = new ResearchDefinition
            {
                UrlElement = hzzzzl_,
                Identifier = new List<Identifier>((IEnumerable<Identifier>)hzzzzm_),
                VersionElement = hzzzzn_,
                NameElement = hzzzzo_,
                TitleElement = hzzzzp_,
                ShortTitleElement = hzzzzq_,
                SubtitleElement = hzzzzr_,
                StatusElement = hzzzzs_,
                ExperimentalElement = hzzzzt_,
                Subject = (DataType)hzzzzu_,
                DateElement = hzzzzv_,
                PublisherElement = hzzzzw_,
                Contact = new List<ContactDetail>((IEnumerable<ContactDetail>)hzzzzx_),
                DescriptionElement = hzzzzy_,
                CommentElement = new List<FhirString>((IEnumerable<FhirString>)hzzzzz_),
                UseContext = new List<UsageContext>((IEnumerable<UsageContext>)izzzza_),
                Jurisdiction = new List<CodeableConcept>((IEnumerable<CodeableConcept>)izzzzb_),
                PurposeElement = izzzzc_,
                UsageElement = izzzzd_,
                CopyrightElement = izzzze_,
                ApprovalDateElement = izzzzf_,
                LastReviewDateElement = izzzzg_,
                EffectivePeriod = izzzzh_,
                Topic = new List<CodeableConcept>((IEnumerable<CodeableConcept>)izzzzi_),
                Author = new List<ContactDetail>((IEnumerable<ContactDetail>)izzzzj_),
                Editor = new List<ContactDetail>((IEnumerable<ContactDetail>)izzzzk_),
                Reviewer = new List<ContactDetail>((IEnumerable<ContactDetail>)izzzzl_),
                Endorser = new List<ContactDetail>((IEnumerable<ContactDetail>)izzzzm_),
                RelatedArtifact = new List<RelatedArtifact>((IEnumerable<RelatedArtifact>)izzzzn_),
                LibraryElement = new List<Canonical>((IEnumerable<Canonical>)izzzzo_),
                Population = izzzzp_,
                Exposure = izzzzq_,
                ExposureAlternative = izzzzr_,
                Outcome = izzzzs_,
            };

            return izzzzt_;
        };
        IEnumerable<ResearchDefinition> hzzzzi_ = context.Operators.Select<ResearchDefinition, ResearchDefinition>((IEnumerable<ResearchDefinition>)hzzzzg_, hzzzzh_);
        IEnumerable<ResearchDefinition> hzzzzj_ = context.Operators.Distinct<ResearchDefinition>(hzzzzi_);
        ResearchDefinition hzzzzk_ = context.Operators.SingletonFrom<ResearchDefinition>(hzzzzj_);

        return hzzzzk_;
    }


    [CqlExpressionDefinition("ResearchElementDefinitionResource")]
    public ResearchElementDefinition ResearchElementDefinitionResource(CqlContext context, ResearchElementDefinition arg)
    {
        ResearchElementDefinition[] izzzzu_ = [
            arg,
        ];
        ResearchElementDefinition izzzzv_(ResearchElementDefinition a)
        {
            FhirUri izzzzz_ = a?.UrlElement;
            List<Identifier> jzzzza_ = a?.Identifier;
            FhirString jzzzzb_ = a?.VersionElement;
            FhirString jzzzzc_ = a?.NameElement;
            FhirString jzzzzd_ = a?.TitleElement;
            FhirString jzzzze_ = a?.ShortTitleElement;
            FhirString jzzzzf_ = a?.SubtitleElement;
            Code<PublicationStatus> jzzzzg_ = a?.StatusElement;
            FhirBoolean jzzzzh_ = a?.ExperimentalElement;
            DataType jzzzzi_ = a?.Subject;
            FhirDateTime jzzzzj_ = a?.DateElement;
            FhirString jzzzzk_ = a?.PublisherElement;
            List<ContactDetail> jzzzzl_ = a?.Contact;
            Markdown jzzzzm_ = a?.DescriptionElement;
            List<FhirString> jzzzzn_ = a?.CommentElement;
            List<UsageContext> jzzzzo_ = a?.UseContext;
            List<CodeableConcept> jzzzzp_ = a?.Jurisdiction;
            Markdown jzzzzq_ = a?.PurposeElement;
            FhirString jzzzzr_ = a?.UsageElement;
            Markdown jzzzzs_ = a?.CopyrightElement;
            Date jzzzzt_ = a?.ApprovalDateElement;
            Date jzzzzu_ = a?.LastReviewDateElement;
            Period jzzzzv_ = a?.EffectivePeriod;
            List<CodeableConcept> jzzzzw_ = a?.Topic;
            List<ContactDetail> jzzzzx_ = a?.Author;
            List<ContactDetail> jzzzzy_ = a?.Editor;
            List<ContactDetail> jzzzzz_ = a?.Reviewer;
            List<ContactDetail> kzzzza_ = a?.Endorser;
            List<RelatedArtifact> kzzzzb_ = a?.RelatedArtifact;
            List<Canonical> kzzzzc_ = a?.LibraryElement;
            Code<ResearchElementDefinition.ResearchElementType> kzzzzd_ = a?.TypeElement;
            Code<VariableTypeCode> kzzzze_ = a?.VariableTypeElement;
            List<ResearchElementDefinition.CharacteristicComponent> kzzzzf_ = a?.Characteristic;
            ResearchElementDefinition kzzzzg_ = new ResearchElementDefinition
            {
                UrlElement = izzzzz_,
                Identifier = new List<Identifier>((IEnumerable<Identifier>)jzzzza_),
                VersionElement = jzzzzb_,
                NameElement = jzzzzc_,
                TitleElement = jzzzzd_,
                ShortTitleElement = jzzzze_,
                SubtitleElement = jzzzzf_,
                StatusElement = jzzzzg_,
                ExperimentalElement = jzzzzh_,
                Subject = (DataType)jzzzzi_,
                DateElement = jzzzzj_,
                PublisherElement = jzzzzk_,
                Contact = new List<ContactDetail>((IEnumerable<ContactDetail>)jzzzzl_),
                DescriptionElement = jzzzzm_,
                CommentElement = new List<FhirString>((IEnumerable<FhirString>)jzzzzn_),
                UseContext = new List<UsageContext>((IEnumerable<UsageContext>)jzzzzo_),
                Jurisdiction = new List<CodeableConcept>((IEnumerable<CodeableConcept>)jzzzzp_),
                PurposeElement = jzzzzq_,
                UsageElement = jzzzzr_,
                CopyrightElement = jzzzzs_,
                ApprovalDateElement = jzzzzt_,
                LastReviewDateElement = jzzzzu_,
                EffectivePeriod = jzzzzv_,
                Topic = new List<CodeableConcept>((IEnumerable<CodeableConcept>)jzzzzw_),
                Author = new List<ContactDetail>((IEnumerable<ContactDetail>)jzzzzx_),
                Editor = new List<ContactDetail>((IEnumerable<ContactDetail>)jzzzzy_),
                Reviewer = new List<ContactDetail>((IEnumerable<ContactDetail>)jzzzzz_),
                Endorser = new List<ContactDetail>((IEnumerable<ContactDetail>)kzzzza_),
                RelatedArtifact = new List<RelatedArtifact>((IEnumerable<RelatedArtifact>)kzzzzb_),
                LibraryElement = new List<Canonical>((IEnumerable<Canonical>)kzzzzc_),
                TypeElement = kzzzzd_,
                VariableTypeElement = kzzzze_,
                Characteristic = new List<ResearchElementDefinition.CharacteristicComponent>((IEnumerable<ResearchElementDefinition.CharacteristicComponent>)kzzzzf_),
            };

            return kzzzzg_;
        };
        IEnumerable<ResearchElementDefinition> izzzzw_ = context.Operators.Select<ResearchElementDefinition, ResearchElementDefinition>((IEnumerable<ResearchElementDefinition>)izzzzu_, izzzzv_);
        IEnumerable<ResearchElementDefinition> izzzzx_ = context.Operators.Distinct<ResearchElementDefinition>(izzzzw_);
        ResearchElementDefinition izzzzy_ = context.Operators.SingletonFrom<ResearchElementDefinition>(izzzzx_);

        return izzzzy_;
    }


    [CqlExpressionDefinition("ResearchStudyResource")]
    public ResearchStudy ResearchStudyResource(CqlContext context, ResearchStudy arg)
    {
        ResearchStudy[] kzzzzh_ = [
            arg,
        ];
        ResearchStudy kzzzzi_(ResearchStudy a)
        {
            List<Identifier> kzzzzm_ = a?.Identifier;
            FhirString kzzzzn_ = a?.TitleElement;
            List<ResourceReference> kzzzzo_ = a?.Protocol;
            List<ResourceReference> kzzzzp_ = a?.PartOf;
            Code<ResearchStudy.ResearchStudyStatus> kzzzzq_ = a?.StatusElement;
            CodeableConcept kzzzzr_ = a?.PrimaryPurposeType;
            CodeableConcept kzzzzs_ = a?.Phase;
            List<CodeableConcept> kzzzzt_ = a?.Category;
            List<CodeableConcept> kzzzzu_ = a?.Focus;
            List<CodeableConcept> kzzzzv_ = a?.Condition;
            List<ContactDetail> kzzzzw_ = a?.Contact;
            List<RelatedArtifact> kzzzzx_ = a?.RelatedArtifact;
            List<CodeableConcept> kzzzzy_ = a?.Keyword;
            List<CodeableConcept> kzzzzz_ = a?.Location;
            Markdown lzzzza_ = a?.DescriptionElement;
            List<ResourceReference> lzzzzb_ = a?.Enrollment;
            Period lzzzzc_ = a?.Period;
            ResourceReference lzzzzd_ = a?.Sponsor;
            ResourceReference lzzzze_ = a?.PrincipalInvestigator;
            List<ResourceReference> lzzzzf_ = a?.Site;
            CodeableConcept lzzzzg_ = a?.ReasonStopped;
            List<Annotation> lzzzzh_ = a?.Note;
            List<ResearchStudy.ArmComponent> lzzzzi_ = a?.Arm;
            List<ResearchStudy.ObjectiveComponent> lzzzzj_ = a?.Objective;
            ResearchStudy lzzzzk_ = new ResearchStudy
            {
                Identifier = new List<Identifier>((IEnumerable<Identifier>)kzzzzm_),
                TitleElement = kzzzzn_,
                Protocol = new List<ResourceReference>((IEnumerable<ResourceReference>)kzzzzo_),
                PartOf = new List<ResourceReference>((IEnumerable<ResourceReference>)kzzzzp_),
                StatusElement = kzzzzq_,
                PrimaryPurposeType = kzzzzr_,
                Phase = kzzzzs_,
                Category = new List<CodeableConcept>((IEnumerable<CodeableConcept>)kzzzzt_),
                Focus = new List<CodeableConcept>((IEnumerable<CodeableConcept>)kzzzzu_),
                Condition = new List<CodeableConcept>((IEnumerable<CodeableConcept>)kzzzzv_),
                Contact = new List<ContactDetail>((IEnumerable<ContactDetail>)kzzzzw_),
                RelatedArtifact = new List<RelatedArtifact>((IEnumerable<RelatedArtifact>)kzzzzx_),
                Keyword = new List<CodeableConcept>((IEnumerable<CodeableConcept>)kzzzzy_),
                Location = new List<CodeableConcept>((IEnumerable<CodeableConcept>)kzzzzz_),
                DescriptionElement = lzzzza_,
                Enrollment = new List<ResourceReference>((IEnumerable<ResourceReference>)lzzzzb_),
                Period = lzzzzc_,
                Sponsor = lzzzzd_,
                PrincipalInvestigator = lzzzze_,
                Site = new List<ResourceReference>((IEnumerable<ResourceReference>)lzzzzf_),
                ReasonStopped = lzzzzg_,
                Note = new List<Annotation>((IEnumerable<Annotation>)lzzzzh_),
                Arm = new List<ResearchStudy.ArmComponent>((IEnumerable<ResearchStudy.ArmComponent>)lzzzzi_),
                Objective = new List<ResearchStudy.ObjectiveComponent>((IEnumerable<ResearchStudy.ObjectiveComponent>)lzzzzj_),
            };

            return lzzzzk_;
        };
        IEnumerable<ResearchStudy> kzzzzj_ = context.Operators.Select<ResearchStudy, ResearchStudy>((IEnumerable<ResearchStudy>)kzzzzh_, kzzzzi_);
        IEnumerable<ResearchStudy> kzzzzk_ = context.Operators.Distinct<ResearchStudy>(kzzzzj_);
        ResearchStudy kzzzzl_ = context.Operators.SingletonFrom<ResearchStudy>(kzzzzk_);

        return kzzzzl_;
    }


    [CqlExpressionDefinition("ResearchSubjectResource")]
    public ResearchSubject ResearchSubjectResource(CqlContext context, ResearchSubject arg)
    {
        ResearchSubject[] lzzzzl_ = [
            arg,
        ];
        ResearchSubject lzzzzm_(ResearchSubject a)
        {
            List<Identifier> lzzzzq_ = a?.Identifier;
            Code<ResearchSubject.ResearchSubjectStatus> lzzzzr_ = a?.StatusElement;
            Period lzzzzs_ = a?.Period;
            ResourceReference lzzzzt_ = a?.Study;
            ResourceReference lzzzzu_ = a?.Individual;
            FhirString lzzzzv_ = a?.AssignedArmElement;
            FhirString lzzzzw_ = a?.ActualArmElement;
            ResourceReference lzzzzx_ = a?.Consent;
            ResearchSubject lzzzzy_ = new ResearchSubject
            {
                Identifier = new List<Identifier>((IEnumerable<Identifier>)lzzzzq_),
                StatusElement = lzzzzr_,
                Period = lzzzzs_,
                Study = lzzzzt_,
                Individual = lzzzzu_,
                AssignedArmElement = lzzzzv_,
                ActualArmElement = lzzzzw_,
                Consent = lzzzzx_,
            };

            return lzzzzy_;
        };
        IEnumerable<ResearchSubject> lzzzzn_ = context.Operators.Select<ResearchSubject, ResearchSubject>((IEnumerable<ResearchSubject>)lzzzzl_, lzzzzm_);
        IEnumerable<ResearchSubject> lzzzzo_ = context.Operators.Distinct<ResearchSubject>(lzzzzn_);
        ResearchSubject lzzzzp_ = context.Operators.SingletonFrom<ResearchSubject>(lzzzzo_);

        return lzzzzp_;
    }


    [CqlExpressionDefinition("RiskAssessmentResource")]
    public RiskAssessment RiskAssessmentResource(CqlContext context, RiskAssessment arg)
    {
        RiskAssessment[] lzzzzz_ = [
            arg,
        ];
        RiskAssessment mzzzza_(RiskAssessment a)
        {
            List<Identifier> mzzzze_ = a?.Identifier;
            ResourceReference mzzzzf_ = a?.BasedOn;
            ResourceReference mzzzzg_ = a?.Parent;
            Code<ObservationStatus> mzzzzh_ = a?.StatusElement;
            CodeableConcept mzzzzi_ = a?.Method;
            CodeableConcept mzzzzj_ = a?.Code;
            ResourceReference mzzzzk_ = a?.Subject;
            ResourceReference mzzzzl_ = a?.Encounter;
            DataType mzzzzm_ = a?.Occurrence;
            ResourceReference mzzzzn_ = a?.Condition;
            ResourceReference mzzzzo_ = a?.Performer;
            List<CodeableConcept> mzzzzp_ = a?.ReasonCode;
            List<ResourceReference> mzzzzq_ = a?.ReasonReference;
            List<ResourceReference> mzzzzr_ = a?.Basis;
            List<RiskAssessment.PredictionComponent> mzzzzs_ = a?.Prediction;
            FhirString mzzzzt_ = a?.MitigationElement;
            List<Annotation> mzzzzu_ = a?.Note;
            RiskAssessment mzzzzv_ = new RiskAssessment
            {
                Identifier = new List<Identifier>((IEnumerable<Identifier>)mzzzze_),
                BasedOn = mzzzzf_,
                Parent = mzzzzg_,
                StatusElement = mzzzzh_,
                Method = mzzzzi_,
                Code = mzzzzj_,
                Subject = mzzzzk_,
                Encounter = mzzzzl_,
                Occurrence = (DataType)mzzzzm_,
                Condition = mzzzzn_,
                Performer = mzzzzo_,
                ReasonCode = new List<CodeableConcept>((IEnumerable<CodeableConcept>)mzzzzp_),
                ReasonReference = new List<ResourceReference>((IEnumerable<ResourceReference>)mzzzzq_),
                Basis = new List<ResourceReference>((IEnumerable<ResourceReference>)mzzzzr_),
                Prediction = new List<RiskAssessment.PredictionComponent>((IEnumerable<RiskAssessment.PredictionComponent>)mzzzzs_),
                MitigationElement = mzzzzt_,
                Note = new List<Annotation>((IEnumerable<Annotation>)mzzzzu_),
            };

            return mzzzzv_;
        };
        IEnumerable<RiskAssessment> mzzzzb_ = context.Operators.Select<RiskAssessment, RiskAssessment>((IEnumerable<RiskAssessment>)lzzzzz_, mzzzza_);
        IEnumerable<RiskAssessment> mzzzzc_ = context.Operators.Distinct<RiskAssessment>(mzzzzb_);
        RiskAssessment mzzzzd_ = context.Operators.SingletonFrom<RiskAssessment>(mzzzzc_);

        return mzzzzd_;
    }


    [CqlExpressionDefinition("RiskEvidenceSynthesisResource")]
    public RiskEvidenceSynthesis RiskEvidenceSynthesisResource(CqlContext context, RiskEvidenceSynthesis arg)
    {
        RiskEvidenceSynthesis[] mzzzzw_ = [
            arg,
        ];
        RiskEvidenceSynthesis mzzzzx_(RiskEvidenceSynthesis a)
        {
            FhirUri nzzzzb_ = a?.UrlElement;
            List<Identifier> nzzzzc_ = a?.Identifier;
            FhirString nzzzzd_ = a?.VersionElement;
            FhirString nzzzze_ = a?.NameElement;
            FhirString nzzzzf_ = a?.TitleElement;
            Code<PublicationStatus> nzzzzg_ = a?.StatusElement;
            FhirDateTime nzzzzh_ = a?.DateElement;
            FhirString nzzzzi_ = a?.PublisherElement;
            List<ContactDetail> nzzzzj_ = a?.Contact;
            Markdown nzzzzk_ = a?.DescriptionElement;
            List<Annotation> nzzzzl_ = a?.Note;
            List<UsageContext> nzzzzm_ = a?.UseContext;
            List<CodeableConcept> nzzzzn_ = a?.Jurisdiction;
            Markdown nzzzzo_ = a?.CopyrightElement;
            Date nzzzzp_ = a?.ApprovalDateElement;
            Date nzzzzq_ = a?.LastReviewDateElement;
            Period nzzzzr_ = a?.EffectivePeriod;
            List<CodeableConcept> nzzzzs_ = a?.Topic;
            List<ContactDetail> nzzzzt_ = a?.Author;
            List<ContactDetail> nzzzzu_ = a?.Editor;
            List<ContactDetail> nzzzzv_ = a?.Reviewer;
            List<ContactDetail> nzzzzw_ = a?.Endorser;
            List<RelatedArtifact> nzzzzx_ = a?.RelatedArtifact;
            CodeableConcept nzzzzy_ = a?.SynthesisType;
            CodeableConcept nzzzzz_ = a?.StudyType;
            ResourceReference ozzzza_ = a?.Population;
            ResourceReference ozzzzb_ = a?.Exposure;
            ResourceReference ozzzzc_ = a?.Outcome;
            RiskEvidenceSynthesis.SampleSizeComponent ozzzzd_ = a?.SampleSize;
            RiskEvidenceSynthesis.RiskEstimateComponent ozzzze_ = a?.RiskEstimate;
            List<RiskEvidenceSynthesis.CertaintyComponent> ozzzzf_ = a?.Certainty;
            RiskEvidenceSynthesis ozzzzg_ = new RiskEvidenceSynthesis
            {
                UrlElement = nzzzzb_,
                Identifier = new List<Identifier>((IEnumerable<Identifier>)nzzzzc_),
                VersionElement = nzzzzd_,
                NameElement = nzzzze_,
                TitleElement = nzzzzf_,
                StatusElement = nzzzzg_,
                DateElement = nzzzzh_,
                PublisherElement = nzzzzi_,
                Contact = new List<ContactDetail>((IEnumerable<ContactDetail>)nzzzzj_),
                DescriptionElement = nzzzzk_,
                Note = new List<Annotation>((IEnumerable<Annotation>)nzzzzl_),
                UseContext = new List<UsageContext>((IEnumerable<UsageContext>)nzzzzm_),
                Jurisdiction = new List<CodeableConcept>((IEnumerable<CodeableConcept>)nzzzzn_),
                CopyrightElement = nzzzzo_,
                ApprovalDateElement = nzzzzp_,
                LastReviewDateElement = nzzzzq_,
                EffectivePeriod = nzzzzr_,
                Topic = new List<CodeableConcept>((IEnumerable<CodeableConcept>)nzzzzs_),
                Author = new List<ContactDetail>((IEnumerable<ContactDetail>)nzzzzt_),
                Editor = new List<ContactDetail>((IEnumerable<ContactDetail>)nzzzzu_),
                Reviewer = new List<ContactDetail>((IEnumerable<ContactDetail>)nzzzzv_),
                Endorser = new List<ContactDetail>((IEnumerable<ContactDetail>)nzzzzw_),
                RelatedArtifact = new List<RelatedArtifact>((IEnumerable<RelatedArtifact>)nzzzzx_),
                SynthesisType = nzzzzy_,
                StudyType = nzzzzz_,
                Population = ozzzza_,
                Exposure = ozzzzb_,
                Outcome = ozzzzc_,
                SampleSize = ozzzzd_,
                RiskEstimate = ozzzze_,
                Certainty = new List<RiskEvidenceSynthesis.CertaintyComponent>((IEnumerable<RiskEvidenceSynthesis.CertaintyComponent>)ozzzzf_),
            };

            return ozzzzg_;
        };
        IEnumerable<RiskEvidenceSynthesis> mzzzzy_ = context.Operators.Select<RiskEvidenceSynthesis, RiskEvidenceSynthesis>((IEnumerable<RiskEvidenceSynthesis>)mzzzzw_, mzzzzx_);
        IEnumerable<RiskEvidenceSynthesis> mzzzzz_ = context.Operators.Distinct<RiskEvidenceSynthesis>(mzzzzy_);
        RiskEvidenceSynthesis nzzzza_ = context.Operators.SingletonFrom<RiskEvidenceSynthesis>(mzzzzz_);

        return nzzzza_;
    }


    [CqlExpressionDefinition("ScheduleResource")]
    public Schedule ScheduleResource(CqlContext context, Schedule arg)
    {
        Schedule[] ozzzzh_ = [
            arg,
        ];
        Schedule ozzzzi_(Schedule a)
        {
            List<Identifier> ozzzzm_ = a?.Identifier;
            FhirBoolean ozzzzn_ = a?.ActiveElement;
            List<CodeableConcept> ozzzzo_ = a?.ServiceCategory;
            List<CodeableConcept> ozzzzp_ = a?.ServiceType;
            List<CodeableConcept> ozzzzq_ = a?.Specialty;
            List<ResourceReference> ozzzzr_ = a?.Actor;
            Period ozzzzs_ = a?.PlanningHorizon;
            FhirString ozzzzt_ = a?.CommentElement;
            Schedule ozzzzu_ = new Schedule
            {
                Identifier = new List<Identifier>((IEnumerable<Identifier>)ozzzzm_),
                ActiveElement = ozzzzn_,
                ServiceCategory = new List<CodeableConcept>((IEnumerable<CodeableConcept>)ozzzzo_),
                ServiceType = new List<CodeableConcept>((IEnumerable<CodeableConcept>)ozzzzp_),
                Specialty = new List<CodeableConcept>((IEnumerable<CodeableConcept>)ozzzzq_),
                Actor = new List<ResourceReference>((IEnumerable<ResourceReference>)ozzzzr_),
                PlanningHorizon = ozzzzs_,
                CommentElement = ozzzzt_,
            };

            return ozzzzu_;
        };
        IEnumerable<Schedule> ozzzzj_ = context.Operators.Select<Schedule, Schedule>((IEnumerable<Schedule>)ozzzzh_, ozzzzi_);
        IEnumerable<Schedule> ozzzzk_ = context.Operators.Distinct<Schedule>(ozzzzj_);
        Schedule ozzzzl_ = context.Operators.SingletonFrom<Schedule>(ozzzzk_);

        return ozzzzl_;
    }


    [CqlExpressionDefinition("ServiceRequestResource")]
    public ServiceRequest ServiceRequestResource(CqlContext context, ServiceRequest arg)
    {
        ServiceRequest[] ozzzzv_ = [
            arg,
        ];
        ServiceRequest ozzzzw_(ServiceRequest a)
        {
            List<Identifier> pzzzza_ = a?.Identifier;
            List<Canonical> pzzzzb_ = a?.InstantiatesCanonicalElement;
            List<FhirUri> pzzzzc_ = a?.InstantiatesUriElement;
            List<ResourceReference> pzzzzd_ = a?.BasedOn;
            List<ResourceReference> pzzzze_ = a?.Replaces;
            Identifier pzzzzf_ = a?.Requisition;
            Code<RequestStatus> pzzzzg_ = a?.StatusElement;
            Code<RequestIntent> pzzzzh_ = a?.IntentElement;
            List<CodeableConcept> pzzzzi_ = a?.Category;
            Code<RequestPriority> pzzzzj_ = a?.PriorityElement;
            FhirBoolean pzzzzk_ = a?.DoNotPerformElement;
            CodeableConcept pzzzzl_ = a?.Code;
            List<CodeableConcept> pzzzzm_ = a?.OrderDetail;
            DataType pzzzzn_ = a?.Quantity;
            ResourceReference pzzzzo_ = a?.Subject;
            ResourceReference pzzzzp_ = a?.Encounter;
            DataType pzzzzq_ = a?.Occurrence;
            DataType pzzzzr_ = a?.AsNeeded;
            FhirDateTime pzzzzs_ = a?.AuthoredOnElement;
            ResourceReference pzzzzt_ = a?.Requester;
            CodeableConcept pzzzzu_ = a?.PerformerType;
            List<ResourceReference> pzzzzv_ = a?.Performer;
            List<CodeableConcept> pzzzzw_ = a?.LocationCode;
            List<ResourceReference> pzzzzx_ = a?.LocationReference;
            List<CodeableConcept> pzzzzy_ = a?.ReasonCode;
            List<ResourceReference> pzzzzz_ = a?.ReasonReference;
            List<ResourceReference> qzzzza_ = a?.Insurance;
            List<ResourceReference> qzzzzb_ = a?.SupportingInfo;
            List<ResourceReference> qzzzzc_ = a?.Specimen;
            List<CodeableConcept> qzzzzd_ = a?.BodySite;
            List<Annotation> qzzzze_ = a?.Note;
            FhirString qzzzzf_ = a?.PatientInstructionElement;
            List<ResourceReference> qzzzzg_ = a?.RelevantHistory;
            ServiceRequest qzzzzh_ = new ServiceRequest
            {
                Identifier = new List<Identifier>((IEnumerable<Identifier>)pzzzza_),
                InstantiatesCanonicalElement = new List<Canonical>((IEnumerable<Canonical>)pzzzzb_),
                InstantiatesUriElement = new List<FhirUri>((IEnumerable<FhirUri>)pzzzzc_),
                BasedOn = new List<ResourceReference>((IEnumerable<ResourceReference>)pzzzzd_),
                Replaces = new List<ResourceReference>((IEnumerable<ResourceReference>)pzzzze_),
                Requisition = pzzzzf_,
                StatusElement = pzzzzg_,
                IntentElement = pzzzzh_,
                Category = new List<CodeableConcept>((IEnumerable<CodeableConcept>)pzzzzi_),
                PriorityElement = pzzzzj_,
                DoNotPerformElement = pzzzzk_,
                Code = pzzzzl_,
                OrderDetail = new List<CodeableConcept>((IEnumerable<CodeableConcept>)pzzzzm_),
                Quantity = (DataType)pzzzzn_,
                Subject = pzzzzo_,
                Encounter = pzzzzp_,
                Occurrence = (DataType)pzzzzq_,
                AsNeeded = (DataType)pzzzzr_,
                AuthoredOnElement = pzzzzs_,
                Requester = pzzzzt_,
                PerformerType = pzzzzu_,
                Performer = new List<ResourceReference>((IEnumerable<ResourceReference>)pzzzzv_),
                LocationCode = new List<CodeableConcept>((IEnumerable<CodeableConcept>)pzzzzw_),
                LocationReference = new List<ResourceReference>((IEnumerable<ResourceReference>)pzzzzx_),
                ReasonCode = new List<CodeableConcept>((IEnumerable<CodeableConcept>)pzzzzy_),
                ReasonReference = new List<ResourceReference>((IEnumerable<ResourceReference>)pzzzzz_),
                Insurance = new List<ResourceReference>((IEnumerable<ResourceReference>)qzzzza_),
                SupportingInfo = new List<ResourceReference>((IEnumerable<ResourceReference>)qzzzzb_),
                Specimen = new List<ResourceReference>((IEnumerable<ResourceReference>)qzzzzc_),
                BodySite = new List<CodeableConcept>((IEnumerable<CodeableConcept>)qzzzzd_),
                Note = new List<Annotation>((IEnumerable<Annotation>)qzzzze_),
                PatientInstructionElement = qzzzzf_,
                RelevantHistory = new List<ResourceReference>((IEnumerable<ResourceReference>)qzzzzg_),
            };

            return qzzzzh_;
        };
        IEnumerable<ServiceRequest> ozzzzx_ = context.Operators.Select<ServiceRequest, ServiceRequest>((IEnumerable<ServiceRequest>)ozzzzv_, ozzzzw_);
        IEnumerable<ServiceRequest> ozzzzy_ = context.Operators.Distinct<ServiceRequest>(ozzzzx_);
        ServiceRequest ozzzzz_ = context.Operators.SingletonFrom<ServiceRequest>(ozzzzy_);

        return ozzzzz_;
    }


    [CqlExpressionDefinition("SlotResource")]
    public Slot SlotResource(CqlContext context, Slot arg)
    {
        Slot[] qzzzzi_ = [
            arg,
        ];
        Slot qzzzzj_(Slot a)
        {
            List<Identifier> qzzzzn_ = a?.Identifier;
            List<CodeableConcept> qzzzzo_ = a?.ServiceCategory;
            List<CodeableConcept> qzzzzp_ = a?.ServiceType;
            List<CodeableConcept> qzzzzq_ = a?.Specialty;
            CodeableConcept qzzzzr_ = a?.AppointmentType;
            ResourceReference qzzzzs_ = a?.Schedule;
            Code<Slot.SlotStatus> qzzzzt_ = a?.StatusElement;
            Instant qzzzzu_ = a?.StartElement;
            Instant qzzzzv_ = a?.EndElement;
            FhirBoolean qzzzzw_ = a?.OverbookedElement;
            FhirString qzzzzx_ = a?.CommentElement;
            Slot qzzzzy_ = new Slot
            {
                Identifier = new List<Identifier>((IEnumerable<Identifier>)qzzzzn_),
                ServiceCategory = new List<CodeableConcept>((IEnumerable<CodeableConcept>)qzzzzo_),
                ServiceType = new List<CodeableConcept>((IEnumerable<CodeableConcept>)qzzzzp_),
                Specialty = new List<CodeableConcept>((IEnumerable<CodeableConcept>)qzzzzq_),
                AppointmentType = qzzzzr_,
                Schedule = qzzzzs_,
                StatusElement = qzzzzt_,
                StartElement = qzzzzu_,
                EndElement = qzzzzv_,
                OverbookedElement = qzzzzw_,
                CommentElement = qzzzzx_,
            };

            return qzzzzy_;
        };
        IEnumerable<Slot> qzzzzk_ = context.Operators.Select<Slot, Slot>((IEnumerable<Slot>)qzzzzi_, qzzzzj_);
        IEnumerable<Slot> qzzzzl_ = context.Operators.Distinct<Slot>(qzzzzk_);
        Slot qzzzzm_ = context.Operators.SingletonFrom<Slot>(qzzzzl_);

        return qzzzzm_;
    }


    [CqlExpressionDefinition("SpecimenResource")]
    public Specimen SpecimenResource(CqlContext context, Specimen arg)
    {
        Specimen[] qzzzzz_ = [
            arg,
        ];
        Specimen rzzzza_(Specimen a)
        {
            List<Identifier> rzzzze_ = a?.Identifier;
            Identifier rzzzzf_ = a?.AccessionIdentifier;
            Code<Specimen.SpecimenStatus> rzzzzg_ = a?.StatusElement;
            CodeableConcept rzzzzh_ = a?.Type;
            ResourceReference rzzzzi_ = a?.Subject;
            FhirDateTime rzzzzj_ = a?.ReceivedTimeElement;
            List<ResourceReference> rzzzzk_ = a?.Parent;
            List<ResourceReference> rzzzzl_ = a?.Request;
            Specimen.CollectionComponent rzzzzm_ = a?.Collection;
            List<Specimen.ProcessingComponent> rzzzzn_ = a?.Processing;
            List<Specimen.ContainerComponent> rzzzzo_ = a?.Container;
            List<CodeableConcept> rzzzzp_ = a?.Condition;
            List<Annotation> rzzzzq_ = a?.Note;
            Specimen rzzzzr_ = new Specimen
            {
                Identifier = new List<Identifier>((IEnumerable<Identifier>)rzzzze_),
                AccessionIdentifier = rzzzzf_,
                StatusElement = rzzzzg_,
                Type = rzzzzh_,
                Subject = rzzzzi_,
                ReceivedTimeElement = rzzzzj_,
                Parent = new List<ResourceReference>((IEnumerable<ResourceReference>)rzzzzk_),
                Request = new List<ResourceReference>((IEnumerable<ResourceReference>)rzzzzl_),
                Collection = rzzzzm_,
                Processing = new List<Specimen.ProcessingComponent>((IEnumerable<Specimen.ProcessingComponent>)rzzzzn_),
                Container = new List<Specimen.ContainerComponent>((IEnumerable<Specimen.ContainerComponent>)rzzzzo_),
                Condition = new List<CodeableConcept>((IEnumerable<CodeableConcept>)rzzzzp_),
                Note = new List<Annotation>((IEnumerable<Annotation>)rzzzzq_),
            };

            return rzzzzr_;
        };
        IEnumerable<Specimen> rzzzzb_ = context.Operators.Select<Specimen, Specimen>((IEnumerable<Specimen>)qzzzzz_, rzzzza_);
        IEnumerable<Specimen> rzzzzc_ = context.Operators.Distinct<Specimen>(rzzzzb_);
        Specimen rzzzzd_ = context.Operators.SingletonFrom<Specimen>(rzzzzc_);

        return rzzzzd_;
    }


    [CqlExpressionDefinition("SpecimenDefinitionResource")]
    public SpecimenDefinition SpecimenDefinitionResource(CqlContext context, SpecimenDefinition arg)
    {
        SpecimenDefinition[] rzzzzs_ = [
            arg,
        ];
        SpecimenDefinition rzzzzt_(SpecimenDefinition a)
        {
            Identifier rzzzzx_ = a?.Identifier;
            CodeableConcept rzzzzy_ = a?.TypeCollected;
            List<CodeableConcept> rzzzzz_ = a?.PatientPreparation;
            FhirString szzzza_ = a?.TimeAspectElement;
            List<CodeableConcept> szzzzb_ = a?.Collection;
            List<SpecimenDefinition.TypeTestedComponent> szzzzc_ = a?.TypeTested;
            SpecimenDefinition szzzzd_ = new SpecimenDefinition
            {
                Identifier = rzzzzx_,
                TypeCollected = rzzzzy_,
                PatientPreparation = new List<CodeableConcept>((IEnumerable<CodeableConcept>)rzzzzz_),
                TimeAspectElement = szzzza_,
                Collection = new List<CodeableConcept>((IEnumerable<CodeableConcept>)szzzzb_),
                TypeTested = new List<SpecimenDefinition.TypeTestedComponent>((IEnumerable<SpecimenDefinition.TypeTestedComponent>)szzzzc_),
            };

            return szzzzd_;
        };
        IEnumerable<SpecimenDefinition> rzzzzu_ = context.Operators.Select<SpecimenDefinition, SpecimenDefinition>((IEnumerable<SpecimenDefinition>)rzzzzs_, rzzzzt_);
        IEnumerable<SpecimenDefinition> rzzzzv_ = context.Operators.Distinct<SpecimenDefinition>(rzzzzu_);
        SpecimenDefinition rzzzzw_ = context.Operators.SingletonFrom<SpecimenDefinition>(rzzzzv_);

        return rzzzzw_;
    }


    [CqlExpressionDefinition("StructureDefinitionResource")]
    public StructureDefinition StructureDefinitionResource(CqlContext context, StructureDefinition arg)
    {
        StructureDefinition[] szzzze_ = [
            arg,
        ];
        StructureDefinition szzzzf_(StructureDefinition a)
        {
            FhirUri szzzzj_ = a?.UrlElement;
            List<Identifier> szzzzk_ = a?.Identifier;
            FhirString szzzzl_ = a?.VersionElement;
            FhirString szzzzm_ = a?.NameElement;
            FhirString szzzzn_ = a?.TitleElement;
            Code<PublicationStatus> szzzzo_ = a?.StatusElement;
            FhirBoolean szzzzp_ = a?.ExperimentalElement;
            FhirDateTime szzzzq_ = a?.DateElement;
            FhirString szzzzr_ = a?.PublisherElement;
            List<ContactDetail> szzzzs_ = a?.Contact;
            Markdown szzzzt_ = a?.DescriptionElement;
            List<UsageContext> szzzzu_ = a?.UseContext;
            List<CodeableConcept> szzzzv_ = a?.Jurisdiction;
            Markdown szzzzw_ = a?.PurposeElement;
            Markdown szzzzx_ = a?.CopyrightElement;
            List<Coding> szzzzy_ = a?.Keyword;
            Code<FHIRVersion> szzzzz_ = a?.FhirVersionElement;
            List<StructureDefinition.MappingComponent> tzzzza_ = a?.Mapping;
            Code<StructureDefinition.StructureDefinitionKind> tzzzzb_ = a?.KindElement;
            FhirBoolean tzzzzc_ = a?.AbstractElement;
            List<StructureDefinition.ContextComponent> tzzzzd_ = a?.Context;
            List<FhirString> tzzzze_ = a?.ContextInvariantElement;
            FhirUri tzzzzf_ = a?.TypeElement;
            Canonical tzzzzg_ = a?.BaseDefinitionElement;
            Code<StructureDefinition.TypeDerivationRule> tzzzzh_ = a?.DerivationElement;
            StructureDefinition.SnapshotComponent tzzzzi_ = a?.Snapshot;
            StructureDefinition.DifferentialComponent tzzzzj_ = a?.Differential;
            StructureDefinition tzzzzk_ = new StructureDefinition
            {
                UrlElement = szzzzj_,
                Identifier = new List<Identifier>((IEnumerable<Identifier>)szzzzk_),
                VersionElement = szzzzl_,
                NameElement = szzzzm_,
                TitleElement = szzzzn_,
                StatusElement = szzzzo_,
                ExperimentalElement = szzzzp_,
                DateElement = szzzzq_,
                PublisherElement = szzzzr_,
                Contact = new List<ContactDetail>((IEnumerable<ContactDetail>)szzzzs_),
                DescriptionElement = szzzzt_,
                UseContext = new List<UsageContext>((IEnumerable<UsageContext>)szzzzu_),
                Jurisdiction = new List<CodeableConcept>((IEnumerable<CodeableConcept>)szzzzv_),
                PurposeElement = szzzzw_,
                CopyrightElement = szzzzx_,
                Keyword = new List<Coding>((IEnumerable<Coding>)szzzzy_),
                FhirVersionElement = szzzzz_,
                Mapping = new List<StructureDefinition.MappingComponent>((IEnumerable<StructureDefinition.MappingComponent>)tzzzza_),
                KindElement = tzzzzb_,
                AbstractElement = tzzzzc_,
                Context = new List<StructureDefinition.ContextComponent>((IEnumerable<StructureDefinition.ContextComponent>)tzzzzd_),
                ContextInvariantElement = new List<FhirString>((IEnumerable<FhirString>)tzzzze_),
                TypeElement = tzzzzf_,
                BaseDefinitionElement = tzzzzg_,
                DerivationElement = tzzzzh_,
                Snapshot = tzzzzi_,
                Differential = tzzzzj_,
            };

            return tzzzzk_;
        };
        IEnumerable<StructureDefinition> szzzzg_ = context.Operators.Select<StructureDefinition, StructureDefinition>((IEnumerable<StructureDefinition>)szzzze_, szzzzf_);
        IEnumerable<StructureDefinition> szzzzh_ = context.Operators.Distinct<StructureDefinition>(szzzzg_);
        StructureDefinition szzzzi_ = context.Operators.SingletonFrom<StructureDefinition>(szzzzh_);

        return szzzzi_;
    }


    [CqlExpressionDefinition("StructureMapResource")]
    public StructureMap StructureMapResource(CqlContext context, StructureMap arg)
    {
        StructureMap[] tzzzzl_ = [
            arg,
        ];
        StructureMap tzzzzm_(StructureMap a)
        {
            FhirUri tzzzzq_ = a?.UrlElement;
            List<Identifier> tzzzzr_ = a?.Identifier;
            FhirString tzzzzs_ = a?.VersionElement;
            FhirString tzzzzt_ = a?.NameElement;
            FhirString tzzzzu_ = a?.TitleElement;
            Code<PublicationStatus> tzzzzv_ = a?.StatusElement;
            FhirBoolean tzzzzw_ = a?.ExperimentalElement;
            FhirDateTime tzzzzx_ = a?.DateElement;
            FhirString tzzzzy_ = a?.PublisherElement;
            List<ContactDetail> tzzzzz_ = a?.Contact;
            Markdown uzzzza_ = a?.DescriptionElement;
            List<UsageContext> uzzzzb_ = a?.UseContext;
            List<CodeableConcept> uzzzzc_ = a?.Jurisdiction;
            Markdown uzzzzd_ = a?.PurposeElement;
            Markdown uzzzze_ = a?.CopyrightElement;
            List<StructureMap.StructureComponent> uzzzzf_ = a?.Structure;
            List<Canonical> uzzzzg_ = a?.ImportElement;
            List<StructureMap.GroupComponent> uzzzzh_ = a?.Group;
            StructureMap uzzzzi_ = new StructureMap
            {
                UrlElement = tzzzzq_,
                Identifier = new List<Identifier>((IEnumerable<Identifier>)tzzzzr_),
                VersionElement = tzzzzs_,
                NameElement = tzzzzt_,
                TitleElement = tzzzzu_,
                StatusElement = tzzzzv_,
                ExperimentalElement = tzzzzw_,
                DateElement = tzzzzx_,
                PublisherElement = tzzzzy_,
                Contact = new List<ContactDetail>((IEnumerable<ContactDetail>)tzzzzz_),
                DescriptionElement = uzzzza_,
                UseContext = new List<UsageContext>((IEnumerable<UsageContext>)uzzzzb_),
                Jurisdiction = new List<CodeableConcept>((IEnumerable<CodeableConcept>)uzzzzc_),
                PurposeElement = uzzzzd_,
                CopyrightElement = uzzzze_,
                Structure = new List<StructureMap.StructureComponent>((IEnumerable<StructureMap.StructureComponent>)uzzzzf_),
                ImportElement = new List<Canonical>((IEnumerable<Canonical>)uzzzzg_),
                Group = new List<StructureMap.GroupComponent>((IEnumerable<StructureMap.GroupComponent>)uzzzzh_),
            };

            return uzzzzi_;
        };
        IEnumerable<StructureMap> tzzzzn_ = context.Operators.Select<StructureMap, StructureMap>((IEnumerable<StructureMap>)tzzzzl_, tzzzzm_);
        IEnumerable<StructureMap> tzzzzo_ = context.Operators.Distinct<StructureMap>(tzzzzn_);
        StructureMap tzzzzp_ = context.Operators.SingletonFrom<StructureMap>(tzzzzo_);

        return tzzzzp_;
    }


    [CqlExpressionDefinition("SubscriptionResource")]
    public Subscription SubscriptionResource(CqlContext context, Subscription arg)
    {
        Subscription[] uzzzzj_ = [
            arg,
        ];
        Subscription uzzzzk_(Subscription a)
        {
            Code<Subscription.SubscriptionStatus> uzzzzo_ = a?.StatusElement;
            List<ContactPoint> uzzzzp_ = a?.Contact;
            Instant uzzzzq_ = a?.EndElement;
            FhirString uzzzzr_ = a?.ReasonElement;
            FhirString uzzzzs_ = a?.CriteriaElement;
            FhirString uzzzzt_ = a?.ErrorElement;
            Subscription.ChannelComponent uzzzzu_ = a?.Channel;
            Subscription uzzzzv_ = new Subscription
            {
                StatusElement = uzzzzo_,
                Contact = new List<ContactPoint>((IEnumerable<ContactPoint>)uzzzzp_),
                EndElement = uzzzzq_,
                ReasonElement = uzzzzr_,
                CriteriaElement = uzzzzs_,
                ErrorElement = uzzzzt_,
                Channel = uzzzzu_,
            };

            return uzzzzv_;
        };
        IEnumerable<Subscription> uzzzzl_ = context.Operators.Select<Subscription, Subscription>((IEnumerable<Subscription>)uzzzzj_, uzzzzk_);
        IEnumerable<Subscription> uzzzzm_ = context.Operators.Distinct<Subscription>(uzzzzl_);
        Subscription uzzzzn_ = context.Operators.SingletonFrom<Subscription>(uzzzzm_);

        return uzzzzn_;
    }


    [CqlExpressionDefinition("SubstanceResource")]
    public Substance SubstanceResource(CqlContext context, Substance arg)
    {
        Substance[] uzzzzw_ = [
            arg,
        ];
        Substance uzzzzx_(Substance a)
        {
            List<Identifier> vzzzzb_ = a?.Identifier;
            Code<Substance.FHIRSubstanceStatus> vzzzzc_ = a?.StatusElement;
            List<CodeableConcept> vzzzzd_ = a?.Category;
            CodeableConcept vzzzze_ = a?.Code;
            FhirString vzzzzf_ = a?.DescriptionElement;
            List<Substance.InstanceComponent> vzzzzg_ = a?.Instance;
            List<Substance.IngredientComponent> vzzzzh_ = a?.Ingredient;
            Substance vzzzzi_ = new Substance
            {
                Identifier = new List<Identifier>((IEnumerable<Identifier>)vzzzzb_),
                StatusElement = vzzzzc_,
                Category = new List<CodeableConcept>((IEnumerable<CodeableConcept>)vzzzzd_),
                Code = vzzzze_,
                DescriptionElement = vzzzzf_,
                Instance = new List<Substance.InstanceComponent>((IEnumerable<Substance.InstanceComponent>)vzzzzg_),
                Ingredient = new List<Substance.IngredientComponent>((IEnumerable<Substance.IngredientComponent>)vzzzzh_),
            };

            return vzzzzi_;
        };
        IEnumerable<Substance> uzzzzy_ = context.Operators.Select<Substance, Substance>((IEnumerable<Substance>)uzzzzw_, uzzzzx_);
        IEnumerable<Substance> uzzzzz_ = context.Operators.Distinct<Substance>(uzzzzy_);
        Substance vzzzza_ = context.Operators.SingletonFrom<Substance>(uzzzzz_);

        return vzzzza_;
    }


    [CqlExpressionDefinition("SubstanceNucleicAcidResource")]
    public SubstanceNucleicAcid SubstanceNucleicAcidResource(CqlContext context, SubstanceNucleicAcid arg)
    {
        SubstanceNucleicAcid[] vzzzzj_ = [
            arg,
        ];
        SubstanceNucleicAcid vzzzzk_(SubstanceNucleicAcid a)
        {
            CodeableConcept vzzzzo_ = a?.SequenceType;
            Integer vzzzzp_ = a?.NumberOfSubunitsElement;
            FhirString vzzzzq_ = a?.AreaOfHybridisationElement;
            CodeableConcept vzzzzr_ = a?.OligoNucleotideType;
            List<SubstanceNucleicAcid.SubunitComponent> vzzzzs_ = a?.Subunit;
            SubstanceNucleicAcid vzzzzt_ = new SubstanceNucleicAcid
            {
                SequenceType = vzzzzo_,
                NumberOfSubunitsElement = vzzzzp_,
                AreaOfHybridisationElement = vzzzzq_,
                OligoNucleotideType = vzzzzr_,
                Subunit = new List<SubstanceNucleicAcid.SubunitComponent>((IEnumerable<SubstanceNucleicAcid.SubunitComponent>)vzzzzs_),
            };

            return vzzzzt_;
        };
        IEnumerable<SubstanceNucleicAcid> vzzzzl_ = context.Operators.Select<SubstanceNucleicAcid, SubstanceNucleicAcid>((IEnumerable<SubstanceNucleicAcid>)vzzzzj_, vzzzzk_);
        IEnumerable<SubstanceNucleicAcid> vzzzzm_ = context.Operators.Distinct<SubstanceNucleicAcid>(vzzzzl_);
        SubstanceNucleicAcid vzzzzn_ = context.Operators.SingletonFrom<SubstanceNucleicAcid>(vzzzzm_);

        return vzzzzn_;
    }


    [CqlExpressionDefinition("SubstancePolymerResource")]
    public SubstancePolymer SubstancePolymerResource(CqlContext context, SubstancePolymer arg)
    {
        SubstancePolymer[] vzzzzu_ = [
            arg,
        ];
        SubstancePolymer vzzzzv_(SubstancePolymer a)
        {
            CodeableConcept vzzzzz_ = a?.Class;
            CodeableConcept wzzzza_ = a?.Geometry;
            List<CodeableConcept> wzzzzb_ = a?.CopolymerConnectivity;
            List<FhirString> wzzzzc_ = a?.ModificationElement;
            List<SubstancePolymer.MonomerSetComponent> wzzzzd_ = a?.MonomerSet;
            List<SubstancePolymer.RepeatComponent> wzzzze_ = a?.Repeat;
            SubstancePolymer wzzzzf_ = new SubstancePolymer
            {
                Class = vzzzzz_,
                Geometry = wzzzza_,
                CopolymerConnectivity = new List<CodeableConcept>((IEnumerable<CodeableConcept>)wzzzzb_),
                ModificationElement = new List<FhirString>((IEnumerable<FhirString>)wzzzzc_),
                MonomerSet = new List<SubstancePolymer.MonomerSetComponent>((IEnumerable<SubstancePolymer.MonomerSetComponent>)wzzzzd_),
                Repeat = new List<SubstancePolymer.RepeatComponent>((IEnumerable<SubstancePolymer.RepeatComponent>)wzzzze_),
            };

            return wzzzzf_;
        };
        IEnumerable<SubstancePolymer> vzzzzw_ = context.Operators.Select<SubstancePolymer, SubstancePolymer>((IEnumerable<SubstancePolymer>)vzzzzu_, vzzzzv_);
        IEnumerable<SubstancePolymer> vzzzzx_ = context.Operators.Distinct<SubstancePolymer>(vzzzzw_);
        SubstancePolymer vzzzzy_ = context.Operators.SingletonFrom<SubstancePolymer>(vzzzzx_);

        return vzzzzy_;
    }


    [CqlExpressionDefinition("SubstanceProteinResource")]
    public SubstanceProtein SubstanceProteinResource(CqlContext context, SubstanceProtein arg)
    {
        SubstanceProtein[] wzzzzg_ = [
            arg,
        ];
        SubstanceProtein wzzzzh_(SubstanceProtein a)
        {
            CodeableConcept wzzzzl_ = a?.SequenceType;
            Integer wzzzzm_ = a?.NumberOfSubunitsElement;
            List<FhirString> wzzzzn_ = a?.DisulfideLinkageElement;
            List<SubstanceProtein.SubunitComponent> wzzzzo_ = a?.Subunit;
            SubstanceProtein wzzzzp_ = new SubstanceProtein
            {
                SequenceType = wzzzzl_,
                NumberOfSubunitsElement = wzzzzm_,
                DisulfideLinkageElement = new List<FhirString>((IEnumerable<FhirString>)wzzzzn_),
                Subunit = new List<SubstanceProtein.SubunitComponent>((IEnumerable<SubstanceProtein.SubunitComponent>)wzzzzo_),
            };

            return wzzzzp_;
        };
        IEnumerable<SubstanceProtein> wzzzzi_ = context.Operators.Select<SubstanceProtein, SubstanceProtein>((IEnumerable<SubstanceProtein>)wzzzzg_, wzzzzh_);
        IEnumerable<SubstanceProtein> wzzzzj_ = context.Operators.Distinct<SubstanceProtein>(wzzzzi_);
        SubstanceProtein wzzzzk_ = context.Operators.SingletonFrom<SubstanceProtein>(wzzzzj_);

        return wzzzzk_;
    }


    [CqlExpressionDefinition("SubstanceReferenceInformationResource")]
    public SubstanceReferenceInformation SubstanceReferenceInformationResource(CqlContext context, SubstanceReferenceInformation arg)
    {
        SubstanceReferenceInformation[] wzzzzq_ = [
            arg,
        ];
        SubstanceReferenceInformation wzzzzr_(SubstanceReferenceInformation a)
        {
            FhirString wzzzzv_ = a?.CommentElement;
            List<SubstanceReferenceInformation.GeneComponent> wzzzzw_ = a?.Gene;
            List<SubstanceReferenceInformation.GeneElementComponent> wzzzzx_ = a?.GeneElement;
            List<SubstanceReferenceInformation.ClassificationComponent> wzzzzy_ = a?.Classification;
            List<SubstanceReferenceInformation.TargetComponent> wzzzzz_ = a?.Target;
            SubstanceReferenceInformation xzzzza_ = new SubstanceReferenceInformation
            {
                CommentElement = wzzzzv_,
                Gene = new List<SubstanceReferenceInformation.GeneComponent>((IEnumerable<SubstanceReferenceInformation.GeneComponent>)wzzzzw_),
                GeneElement = new List<SubstanceReferenceInformation.GeneElementComponent>((IEnumerable<SubstanceReferenceInformation.GeneElementComponent>)wzzzzx_),
                Classification = new List<SubstanceReferenceInformation.ClassificationComponent>((IEnumerable<SubstanceReferenceInformation.ClassificationComponent>)wzzzzy_),
                Target = new List<SubstanceReferenceInformation.TargetComponent>((IEnumerable<SubstanceReferenceInformation.TargetComponent>)wzzzzz_),
            };

            return xzzzza_;
        };
        IEnumerable<SubstanceReferenceInformation> wzzzzs_ = context.Operators.Select<SubstanceReferenceInformation, SubstanceReferenceInformation>((IEnumerable<SubstanceReferenceInformation>)wzzzzq_, wzzzzr_);
        IEnumerable<SubstanceReferenceInformation> wzzzzt_ = context.Operators.Distinct<SubstanceReferenceInformation>(wzzzzs_);
        SubstanceReferenceInformation wzzzzu_ = context.Operators.SingletonFrom<SubstanceReferenceInformation>(wzzzzt_);

        return wzzzzu_;
    }


    [CqlExpressionDefinition("SubstanceSourceMaterialResource")]
    public SubstanceSourceMaterial SubstanceSourceMaterialResource(CqlContext context, SubstanceSourceMaterial arg)
    {
        SubstanceSourceMaterial[] xzzzzb_ = [
            arg,
        ];
        SubstanceSourceMaterial xzzzzc_(SubstanceSourceMaterial a)
        {
            CodeableConcept xzzzzg_ = a?.SourceMaterialClass;
            CodeableConcept xzzzzh_ = a?.SourceMaterialType;
            CodeableConcept xzzzzi_ = a?.SourceMaterialState;
            Identifier xzzzzj_ = a?.OrganismId;
            FhirString xzzzzk_ = a?.OrganismNameElement;
            List<Identifier> xzzzzl_ = a?.ParentSubstanceId;
            List<FhirString> xzzzzm_ = a?.ParentSubstanceNameElement;
            List<CodeableConcept> xzzzzn_ = a?.CountryOfOrigin;
            List<FhirString> xzzzzo_ = a?.GeographicalLocationElement;
            CodeableConcept xzzzzp_ = a?.DevelopmentStage;
            List<SubstanceSourceMaterial.FractionDescriptionComponent> xzzzzq_ = a?.FractionDescription;
            SubstanceSourceMaterial.OrganismComponent xzzzzr_ = a?.Organism;
            List<SubstanceSourceMaterial.PartDescriptionComponent> xzzzzs_ = a?.PartDescription;
            SubstanceSourceMaterial xzzzzt_ = new SubstanceSourceMaterial
            {
                SourceMaterialClass = xzzzzg_,
                SourceMaterialType = xzzzzh_,
                SourceMaterialState = xzzzzi_,
                OrganismId = xzzzzj_,
                OrganismNameElement = xzzzzk_,
                ParentSubstanceId = new List<Identifier>((IEnumerable<Identifier>)xzzzzl_),
                ParentSubstanceNameElement = new List<FhirString>((IEnumerable<FhirString>)xzzzzm_),
                CountryOfOrigin = new List<CodeableConcept>((IEnumerable<CodeableConcept>)xzzzzn_),
                GeographicalLocationElement = new List<FhirString>((IEnumerable<FhirString>)xzzzzo_),
                DevelopmentStage = xzzzzp_,
                FractionDescription = new List<SubstanceSourceMaterial.FractionDescriptionComponent>((IEnumerable<SubstanceSourceMaterial.FractionDescriptionComponent>)xzzzzq_),
                Organism = xzzzzr_,
                PartDescription = new List<SubstanceSourceMaterial.PartDescriptionComponent>((IEnumerable<SubstanceSourceMaterial.PartDescriptionComponent>)xzzzzs_),
            };

            return xzzzzt_;
        };
        IEnumerable<SubstanceSourceMaterial> xzzzzd_ = context.Operators.Select<SubstanceSourceMaterial, SubstanceSourceMaterial>((IEnumerable<SubstanceSourceMaterial>)xzzzzb_, xzzzzc_);
        IEnumerable<SubstanceSourceMaterial> xzzzze_ = context.Operators.Distinct<SubstanceSourceMaterial>(xzzzzd_);
        SubstanceSourceMaterial xzzzzf_ = context.Operators.SingletonFrom<SubstanceSourceMaterial>(xzzzze_);

        return xzzzzf_;
    }


    [CqlExpressionDefinition("SubstanceSpecificationResource")]
    public SubstanceSpecification SubstanceSpecificationResource(CqlContext context, SubstanceSpecification arg)
    {
        SubstanceSpecification[] xzzzzu_ = [
            arg,
        ];
        SubstanceSpecification xzzzzv_(SubstanceSpecification a)
        {
            Identifier xzzzzz_ = a?.Identifier;
            CodeableConcept yzzzza_ = a?.Type;
            CodeableConcept yzzzzb_ = a?.Status;
            CodeableConcept yzzzzc_ = a?.Domain;
            FhirString yzzzzd_ = a?.DescriptionElement;
            List<ResourceReference> yzzzze_ = a?.Source;
            FhirString yzzzzf_ = a?.CommentElement;
            List<SubstanceSpecification.MoietyComponent> yzzzzg_ = a?.Moiety;
            List<SubstanceSpecification.PropertyComponent> yzzzzh_ = a?.Property;
            ResourceReference yzzzzi_ = a?.ReferenceInformation;
            SubstanceSpecification.StructureComponent yzzzzj_ = a?.Structure;
            List<SubstanceSpecification.CodeComponent> yzzzzk_ = a?.Code;
            List<SubstanceSpecification.NameComponent> yzzzzl_ = a?.Name;
            List<SubstanceSpecification.MolecularWeightComponent> yzzzzm_ = a?.MolecularWeight;
            List<SubstanceSpecification.RelationshipComponent> yzzzzn_ = a?.Relationship;
            ResourceReference yzzzzo_ = a?.NucleicAcid;
            ResourceReference yzzzzp_ = a?.Polymer;
            ResourceReference yzzzzq_ = a?.Protein;
            ResourceReference yzzzzr_ = a?.SourceMaterial;
            SubstanceSpecification yzzzzs_ = new SubstanceSpecification
            {
                Identifier = xzzzzz_,
                Type = yzzzza_,
                Status = yzzzzb_,
                Domain = yzzzzc_,
                DescriptionElement = yzzzzd_,
                Source = new List<ResourceReference>((IEnumerable<ResourceReference>)yzzzze_),
                CommentElement = yzzzzf_,
                Moiety = new List<SubstanceSpecification.MoietyComponent>((IEnumerable<SubstanceSpecification.MoietyComponent>)yzzzzg_),
                Property = new List<SubstanceSpecification.PropertyComponent>((IEnumerable<SubstanceSpecification.PropertyComponent>)yzzzzh_),
                ReferenceInformation = yzzzzi_,
                Structure = yzzzzj_,
                Code = new List<SubstanceSpecification.CodeComponent>((IEnumerable<SubstanceSpecification.CodeComponent>)yzzzzk_),
                Name = new List<SubstanceSpecification.NameComponent>((IEnumerable<SubstanceSpecification.NameComponent>)yzzzzl_),
                MolecularWeight = new List<SubstanceSpecification.MolecularWeightComponent>((IEnumerable<SubstanceSpecification.MolecularWeightComponent>)yzzzzm_),
                Relationship = new List<SubstanceSpecification.RelationshipComponent>((IEnumerable<SubstanceSpecification.RelationshipComponent>)yzzzzn_),
                NucleicAcid = yzzzzo_,
                Polymer = yzzzzp_,
                Protein = yzzzzq_,
                SourceMaterial = yzzzzr_,
            };

            return yzzzzs_;
        };
        IEnumerable<SubstanceSpecification> xzzzzw_ = context.Operators.Select<SubstanceSpecification, SubstanceSpecification>((IEnumerable<SubstanceSpecification>)xzzzzu_, xzzzzv_);
        IEnumerable<SubstanceSpecification> xzzzzx_ = context.Operators.Distinct<SubstanceSpecification>(xzzzzw_);
        SubstanceSpecification xzzzzy_ = context.Operators.SingletonFrom<SubstanceSpecification>(xzzzzx_);

        return xzzzzy_;
    }


    [CqlExpressionDefinition("SupplyDeliveryResource")]
    public SupplyDelivery SupplyDeliveryResource(CqlContext context, SupplyDelivery arg)
    {
        SupplyDelivery[] yzzzzt_ = [
            arg,
        ];
        SupplyDelivery yzzzzu_(SupplyDelivery a)
        {
            List<Identifier> yzzzzy_ = a?.Identifier;
            List<ResourceReference> yzzzzz_ = a?.BasedOn;
            List<ResourceReference> zzzzza_ = a?.PartOf;
            Code<SupplyDelivery.SupplyDeliveryStatus> zzzzzb_ = a?.StatusElement;
            ResourceReference zzzzzc_ = a?.Patient;
            CodeableConcept zzzzzd_ = a?.Type;
            SupplyDelivery.SuppliedItemComponent zzzzze_ = a?.SuppliedItem;
            DataType zzzzzf_ = a?.Occurrence;
            ResourceReference zzzzzg_ = a?.Supplier;
            ResourceReference zzzzzh_ = a?.Destination;
            List<ResourceReference> zzzzzi_ = a?.Receiver;
            SupplyDelivery zzzzzj_ = new SupplyDelivery
            {
                Identifier = new List<Identifier>((IEnumerable<Identifier>)yzzzzy_),
                BasedOn = new List<ResourceReference>((IEnumerable<ResourceReference>)yzzzzz_),
                PartOf = new List<ResourceReference>((IEnumerable<ResourceReference>)zzzzza_),
                StatusElement = zzzzzb_,
                Patient = zzzzzc_,
                Type = zzzzzd_,
                SuppliedItem = zzzzze_,
                Occurrence = (DataType)zzzzzf_,
                Supplier = zzzzzg_,
                Destination = zzzzzh_,
                Receiver = new List<ResourceReference>((IEnumerable<ResourceReference>)zzzzzi_),
            };

            return zzzzzj_;
        };
        IEnumerable<SupplyDelivery> yzzzzv_ = context.Operators.Select<SupplyDelivery, SupplyDelivery>((IEnumerable<SupplyDelivery>)yzzzzt_, yzzzzu_);
        IEnumerable<SupplyDelivery> yzzzzw_ = context.Operators.Distinct<SupplyDelivery>(yzzzzv_);
        SupplyDelivery yzzzzx_ = context.Operators.SingletonFrom<SupplyDelivery>(yzzzzw_);

        return yzzzzx_;
    }


    [CqlExpressionDefinition("SupplyRequestResource")]
    public SupplyRequest SupplyRequestResource(CqlContext context, SupplyRequest arg)
    {
        SupplyRequest[] zzzzzk_ = [
            arg,
        ];
        SupplyRequest zzzzzl_(SupplyRequest a)
        {
            List<Identifier> zzzzzp_ = a?.Identifier;
            Code<SupplyRequest.SupplyRequestStatus> zzzzzq_ = a?.StatusElement;
            CodeableConcept zzzzzr_ = a?.Category;
            Code<RequestPriority> zzzzzs_ = a?.PriorityElement;
            DataType zzzzzt_ = a?.Item;
            Quantity zzzzzu_ = a?.Quantity;
            List<SupplyRequest.ParameterComponent> zzzzzv_ = a?.Parameter;
            DataType zzzzzw_ = a?.Occurrence;
            FhirDateTime zzzzzx_ = a?.AuthoredOnElement;
            ResourceReference zzzzzy_ = a?.Requester;
            List<ResourceReference> zzzzzz_ = a?.Supplier;
            List<CodeableConcept> azzzzza_ = a?.ReasonCode;
            List<ResourceReference> azzzzzb_ = a?.ReasonReference;
            ResourceReference azzzzzc_ = a?.DeliverFrom;
            ResourceReference azzzzzd_ = a?.DeliverTo;
            SupplyRequest azzzzze_ = new SupplyRequest
            {
                Identifier = new List<Identifier>((IEnumerable<Identifier>)zzzzzp_),
                StatusElement = zzzzzq_,
                Category = zzzzzr_,
                PriorityElement = zzzzzs_,
                Item = (DataType)zzzzzt_,
                Quantity = zzzzzu_,
                Parameter = new List<SupplyRequest.ParameterComponent>((IEnumerable<SupplyRequest.ParameterComponent>)zzzzzv_),
                Occurrence = (DataType)zzzzzw_,
                AuthoredOnElement = zzzzzx_,
                Requester = zzzzzy_,
                Supplier = new List<ResourceReference>((IEnumerable<ResourceReference>)zzzzzz_),
                ReasonCode = new List<CodeableConcept>((IEnumerable<CodeableConcept>)azzzzza_),
                ReasonReference = new List<ResourceReference>((IEnumerable<ResourceReference>)azzzzzb_),
                DeliverFrom = azzzzzc_,
                DeliverTo = azzzzzd_,
            };

            return azzzzze_;
        };
        IEnumerable<SupplyRequest> zzzzzm_ = context.Operators.Select<SupplyRequest, SupplyRequest>((IEnumerable<SupplyRequest>)zzzzzk_, zzzzzl_);
        IEnumerable<SupplyRequest> zzzzzn_ = context.Operators.Distinct<SupplyRequest>(zzzzzm_);
        SupplyRequest zzzzzo_ = context.Operators.SingletonFrom<SupplyRequest>(zzzzzn_);

        return zzzzzo_;
    }


    [CqlExpressionDefinition("TaskResource")]
    public Task TaskResource(CqlContext context, Task arg)
    {
        Task[] azzzzzf_ = [
            arg,
        ];
        Task azzzzzg_(Task a)
        {
            List<Identifier> azzzzzk_ = a?.Identifier;
            Canonical azzzzzl_ = a?.InstantiatesCanonicalElement;
            FhirUri azzzzzm_ = a?.InstantiatesUriElement;
            List<ResourceReference> azzzzzn_ = a?.BasedOn;
            Identifier azzzzzo_ = a?.GroupIdentifier;
            List<ResourceReference> azzzzzp_ = a?.PartOf;
            Code<Task.TaskStatus> azzzzzq_ = a?.StatusElement;
            CodeableConcept azzzzzr_ = a?.StatusReason;
            CodeableConcept azzzzzs_ = a?.BusinessStatus;
            Code<Task.TaskIntent> azzzzzt_ = a?.IntentElement;
            Code<RequestPriority> azzzzzu_ = a?.PriorityElement;
            CodeableConcept azzzzzv_ = a?.Code;
            FhirString azzzzzw_ = a?.DescriptionElement;
            ResourceReference azzzzzx_ = a?.Focus;
            ResourceReference azzzzzy_ = a?.For;
            ResourceReference azzzzzz_ = a?.Encounter;
            Period bzzzzza_ = a?.ExecutionPeriod;
            FhirDateTime bzzzzzb_ = a?.AuthoredOnElement;
            FhirDateTime bzzzzzc_ = a?.LastModifiedElement;
            ResourceReference bzzzzzd_ = a?.Requester;
            List<CodeableConcept> bzzzzze_ = a?.PerformerType;
            ResourceReference bzzzzzf_ = a?.Owner;
            ResourceReference bzzzzzg_ = a?.Location;
            CodeableConcept bzzzzzh_ = a?.ReasonCode;
            ResourceReference bzzzzzi_ = a?.ReasonReference;
            List<ResourceReference> bzzzzzj_ = a?.Insurance;
            List<Annotation> bzzzzzk_ = a?.Note;
            List<ResourceReference> bzzzzzl_ = a?.RelevantHistory;
            Task.RestrictionComponent bzzzzzm_ = a?.Restriction;
            List<Task.ParameterComponent> bzzzzzn_ = a?.Input;
            List<Task.OutputComponent> bzzzzzo_ = a?.Output;
            Task bzzzzzp_ = new Task
            {
                Identifier = new List<Identifier>((IEnumerable<Identifier>)azzzzzk_),
                InstantiatesCanonicalElement = azzzzzl_,
                InstantiatesUriElement = azzzzzm_,
                BasedOn = new List<ResourceReference>((IEnumerable<ResourceReference>)azzzzzn_),
                GroupIdentifier = azzzzzo_,
                PartOf = new List<ResourceReference>((IEnumerable<ResourceReference>)azzzzzp_),
                StatusElement = azzzzzq_,
                StatusReason = azzzzzr_,
                BusinessStatus = azzzzzs_,
                IntentElement = azzzzzt_,
                PriorityElement = azzzzzu_,
                Code = azzzzzv_,
                DescriptionElement = azzzzzw_,
                Focus = azzzzzx_,
                For = azzzzzy_,
                Encounter = azzzzzz_,
                ExecutionPeriod = bzzzzza_,
                AuthoredOnElement = bzzzzzb_,
                LastModifiedElement = bzzzzzc_,
                Requester = bzzzzzd_,
                PerformerType = new List<CodeableConcept>((IEnumerable<CodeableConcept>)bzzzzze_),
                Owner = bzzzzzf_,
                Location = bzzzzzg_,
                ReasonCode = bzzzzzh_,
                ReasonReference = bzzzzzi_,
                Insurance = new List<ResourceReference>((IEnumerable<ResourceReference>)bzzzzzj_),
                Note = new List<Annotation>((IEnumerable<Annotation>)bzzzzzk_),
                RelevantHistory = new List<ResourceReference>((IEnumerable<ResourceReference>)bzzzzzl_),
                Restriction = bzzzzzm_,
                Input = new List<Task.ParameterComponent>((IEnumerable<Task.ParameterComponent>)bzzzzzn_),
                Output = new List<Task.OutputComponent>((IEnumerable<Task.OutputComponent>)bzzzzzo_),
            };

            return bzzzzzp_;
        };
        IEnumerable<Task> azzzzzh_ = context.Operators.Select<Task, Task>((IEnumerable<Task>)azzzzzf_, azzzzzg_);
        IEnumerable<Task> azzzzzi_ = context.Operators.Distinct<Task>(azzzzzh_);
        Task azzzzzj_ = context.Operators.SingletonFrom<Task>(azzzzzi_);

        return azzzzzj_;
    }


    [CqlExpressionDefinition("TerminologyCapabilitiesResource")]
    public TerminologyCapabilities TerminologyCapabilitiesResource(CqlContext context, TerminologyCapabilities arg)
    {
        TerminologyCapabilities[] bzzzzzq_ = [
            arg,
        ];
        TerminologyCapabilities bzzzzzr_(TerminologyCapabilities a)
        {
            FhirUri bzzzzzv_ = a?.UrlElement;
            FhirString bzzzzzw_ = a?.VersionElement;
            FhirString bzzzzzx_ = a?.NameElement;
            FhirString bzzzzzy_ = a?.TitleElement;
            Code<PublicationStatus> bzzzzzz_ = a?.StatusElement;
            FhirBoolean czzzzza_ = a?.ExperimentalElement;
            FhirDateTime czzzzzb_ = a?.DateElement;
            FhirString czzzzzc_ = a?.PublisherElement;
            List<ContactDetail> czzzzzd_ = a?.Contact;
            Markdown czzzzze_ = a?.DescriptionElement;
            List<UsageContext> czzzzzf_ = a?.UseContext;
            List<CodeableConcept> czzzzzg_ = a?.Jurisdiction;
            Markdown czzzzzh_ = a?.PurposeElement;
            Markdown czzzzzi_ = a?.CopyrightElement;
            Code<CapabilityStatementKind> czzzzzj_ = a?.KindElement;
            TerminologyCapabilities.SoftwareComponent czzzzzk_ = a?.Software;
            TerminologyCapabilities.ImplementationComponent czzzzzl_ = a?.Implementation;
            FhirBoolean czzzzzm_ = a?.LockedDateElement;
            List<TerminologyCapabilities.CodeSystemComponent> czzzzzn_ = a?.CodeSystem;
            TerminologyCapabilities.ExpansionComponent czzzzzo_ = a?.Expansion;
            Code<TerminologyCapabilities.CodeSearchSupport> czzzzzp_ = a?.CodeSearchElement;
            TerminologyCapabilities.ValidateCodeComponent czzzzzq_ = a?.ValidateCode;
            TerminologyCapabilities.TranslationComponent czzzzzr_ = a?.Translation;
            TerminologyCapabilities.ClosureComponent czzzzzs_ = a?.Closure;
            TerminologyCapabilities czzzzzt_ = new TerminologyCapabilities
            {
                UrlElement = bzzzzzv_,
                VersionElement = bzzzzzw_,
                NameElement = bzzzzzx_,
                TitleElement = bzzzzzy_,
                StatusElement = bzzzzzz_,
                ExperimentalElement = czzzzza_,
                DateElement = czzzzzb_,
                PublisherElement = czzzzzc_,
                Contact = new List<ContactDetail>((IEnumerable<ContactDetail>)czzzzzd_),
                DescriptionElement = czzzzze_,
                UseContext = new List<UsageContext>((IEnumerable<UsageContext>)czzzzzf_),
                Jurisdiction = new List<CodeableConcept>((IEnumerable<CodeableConcept>)czzzzzg_),
                PurposeElement = czzzzzh_,
                CopyrightElement = czzzzzi_,
                KindElement = czzzzzj_,
                Software = czzzzzk_,
                Implementation = czzzzzl_,
                LockedDateElement = czzzzzm_,
                CodeSystem = new List<TerminologyCapabilities.CodeSystemComponent>((IEnumerable<TerminologyCapabilities.CodeSystemComponent>)czzzzzn_),
                Expansion = czzzzzo_,
                CodeSearchElement = czzzzzp_,
                ValidateCode = czzzzzq_,
                Translation = czzzzzr_,
                Closure = czzzzzs_,
            };

            return czzzzzt_;
        };
        IEnumerable<TerminologyCapabilities> bzzzzzs_ = context.Operators.Select<TerminologyCapabilities, TerminologyCapabilities>((IEnumerable<TerminologyCapabilities>)bzzzzzq_, bzzzzzr_);
        IEnumerable<TerminologyCapabilities> bzzzzzt_ = context.Operators.Distinct<TerminologyCapabilities>(bzzzzzs_);
        TerminologyCapabilities bzzzzzu_ = context.Operators.SingletonFrom<TerminologyCapabilities>(bzzzzzt_);

        return bzzzzzu_;
    }


    [CqlExpressionDefinition("TestReportResource")]
    public TestReport TestReportResource(CqlContext context, TestReport arg)
    {
        TestReport[] czzzzzu_ = [
            arg,
        ];
        TestReport czzzzzv_(TestReport a)
        {
            Identifier czzzzzz_ = a?.Identifier;
            FhirString dzzzzza_ = a?.NameElement;
            Code<TestReport.TestReportStatus> dzzzzzb_ = a?.StatusElement;
            ResourceReference dzzzzzc_ = a?.TestScript;
            Code<TestReport.TestReportResult> dzzzzzd_ = a?.ResultElement;
            FhirDecimal dzzzzze_ = a?.ScoreElement;
            FhirString dzzzzzf_ = a?.TesterElement;
            FhirDateTime dzzzzzg_ = a?.IssuedElement;
            List<TestReport.ParticipantComponent> dzzzzzh_ = a?.Participant;
            TestReport.SetupComponent dzzzzzi_ = a?.Setup;
            List<TestReport.TestComponent> dzzzzzj_ = a?.Test;
            TestReport.TeardownComponent dzzzzzk_ = a?.Teardown;
            TestReport dzzzzzl_ = new TestReport
            {
                Identifier = czzzzzz_,
                NameElement = dzzzzza_,
                StatusElement = dzzzzzb_,
                TestScript = dzzzzzc_,
                ResultElement = dzzzzzd_,
                ScoreElement = dzzzzze_,
                TesterElement = dzzzzzf_,
                IssuedElement = dzzzzzg_,
                Participant = new List<TestReport.ParticipantComponent>((IEnumerable<TestReport.ParticipantComponent>)dzzzzzh_),
                Setup = dzzzzzi_,
                Test = new List<TestReport.TestComponent>((IEnumerable<TestReport.TestComponent>)dzzzzzj_),
                Teardown = dzzzzzk_,
            };

            return dzzzzzl_;
        };
        IEnumerable<TestReport> czzzzzw_ = context.Operators.Select<TestReport, TestReport>((IEnumerable<TestReport>)czzzzzu_, czzzzzv_);
        IEnumerable<TestReport> czzzzzx_ = context.Operators.Distinct<TestReport>(czzzzzw_);
        TestReport czzzzzy_ = context.Operators.SingletonFrom<TestReport>(czzzzzx_);

        return czzzzzy_;
    }


    [CqlExpressionDefinition("TestScriptResource")]
    public TestScript TestScriptResource(CqlContext context, TestScript arg)
    {
        TestScript[] dzzzzzm_ = [
            arg,
        ];
        TestScript dzzzzzn_(TestScript a)
        {
            FhirUri dzzzzzr_ = a?.UrlElement;
            Identifier dzzzzzs_ = a?.Identifier;
            FhirString dzzzzzt_ = a?.VersionElement;
            FhirString dzzzzzu_ = a?.NameElement;
            FhirString dzzzzzv_ = a?.TitleElement;
            Code<PublicationStatus> dzzzzzw_ = a?.StatusElement;
            FhirBoolean dzzzzzx_ = a?.ExperimentalElement;
            FhirDateTime dzzzzzy_ = a?.DateElement;
            FhirString dzzzzzz_ = a?.PublisherElement;
            List<ContactDetail> ezzzzza_ = a?.Contact;
            Markdown ezzzzzb_ = a?.DescriptionElement;
            List<UsageContext> ezzzzzc_ = a?.UseContext;
            List<CodeableConcept> ezzzzzd_ = a?.Jurisdiction;
            Markdown ezzzzze_ = a?.PurposeElement;
            Markdown ezzzzzf_ = a?.CopyrightElement;
            List<TestScript.OriginComponent> ezzzzzg_ = a?.Origin;
            List<TestScript.DestinationComponent> ezzzzzh_ = a?.Destination;
            TestScript.MetadataComponent ezzzzzi_ = a?.Metadata;
            List<TestScript.FixtureComponent> ezzzzzj_ = a?.Fixture;
            List<ResourceReference> ezzzzzk_ = a?.Profile;
            List<TestScript.VariableComponent> ezzzzzl_ = a?.Variable;
            TestScript.SetupComponent ezzzzzm_ = a?.Setup;
            List<TestScript.TestComponent> ezzzzzn_ = a?.Test;
            TestScript.TeardownComponent ezzzzzo_ = a?.Teardown;
            TestScript ezzzzzp_ = new TestScript
            {
                UrlElement = dzzzzzr_,
                Identifier = dzzzzzs_,
                VersionElement = dzzzzzt_,
                NameElement = dzzzzzu_,
                TitleElement = dzzzzzv_,
                StatusElement = dzzzzzw_,
                ExperimentalElement = dzzzzzx_,
                DateElement = dzzzzzy_,
                PublisherElement = dzzzzzz_,
                Contact = new List<ContactDetail>((IEnumerable<ContactDetail>)ezzzzza_),
                DescriptionElement = ezzzzzb_,
                UseContext = new List<UsageContext>((IEnumerable<UsageContext>)ezzzzzc_),
                Jurisdiction = new List<CodeableConcept>((IEnumerable<CodeableConcept>)ezzzzzd_),
                PurposeElement = ezzzzze_,
                CopyrightElement = ezzzzzf_,
                Origin = new List<TestScript.OriginComponent>((IEnumerable<TestScript.OriginComponent>)ezzzzzg_),
                Destination = new List<TestScript.DestinationComponent>((IEnumerable<TestScript.DestinationComponent>)ezzzzzh_),
                Metadata = ezzzzzi_,
                Fixture = new List<TestScript.FixtureComponent>((IEnumerable<TestScript.FixtureComponent>)ezzzzzj_),
                Profile = new List<ResourceReference>((IEnumerable<ResourceReference>)ezzzzzk_),
                Variable = new List<TestScript.VariableComponent>((IEnumerable<TestScript.VariableComponent>)ezzzzzl_),
                Setup = ezzzzzm_,
                Test = new List<TestScript.TestComponent>((IEnumerable<TestScript.TestComponent>)ezzzzzn_),
                Teardown = ezzzzzo_,
            };

            return ezzzzzp_;
        };
        IEnumerable<TestScript> dzzzzzo_ = context.Operators.Select<TestScript, TestScript>((IEnumerable<TestScript>)dzzzzzm_, dzzzzzn_);
        IEnumerable<TestScript> dzzzzzp_ = context.Operators.Distinct<TestScript>(dzzzzzo_);
        TestScript dzzzzzq_ = context.Operators.SingletonFrom<TestScript>(dzzzzzp_);

        return dzzzzzq_;
    }


    [CqlExpressionDefinition("ValueSetResource")]
    public ValueSet ValueSetResource(CqlContext context, ValueSet arg)
    {
        ValueSet[] ezzzzzq_ = [
            arg,
        ];
        ValueSet ezzzzzr_(ValueSet a)
        {
            FhirUri ezzzzzv_ = a?.UrlElement;
            List<Identifier> ezzzzzw_ = a?.Identifier;
            FhirString ezzzzzx_ = a?.VersionElement;
            FhirString ezzzzzy_ = a?.NameElement;
            FhirString ezzzzzz_ = a?.TitleElement;
            Code<PublicationStatus> fzzzzza_ = a?.StatusElement;
            FhirBoolean fzzzzzb_ = a?.ExperimentalElement;
            FhirDateTime fzzzzzc_ = a?.DateElement;
            FhirString fzzzzzd_ = a?.PublisherElement;
            List<ContactDetail> fzzzzze_ = a?.Contact;
            Markdown fzzzzzf_ = a?.DescriptionElement;
            List<UsageContext> fzzzzzg_ = a?.UseContext;
            List<CodeableConcept> fzzzzzh_ = a?.Jurisdiction;
            FhirBoolean fzzzzzi_ = a?.ImmutableElement;
            Markdown fzzzzzj_ = a?.PurposeElement;
            Markdown fzzzzzk_ = a?.CopyrightElement;
            ValueSet.ComposeComponent fzzzzzl_ = a?.Compose;
            ValueSet.ExpansionComponent fzzzzzm_ = a?.Expansion;
            ValueSet fzzzzzn_ = new ValueSet
            {
                UrlElement = ezzzzzv_,
                Identifier = new List<Identifier>((IEnumerable<Identifier>)ezzzzzw_),
                VersionElement = ezzzzzx_,
                NameElement = ezzzzzy_,
                TitleElement = ezzzzzz_,
                StatusElement = fzzzzza_,
                ExperimentalElement = fzzzzzb_,
                DateElement = fzzzzzc_,
                PublisherElement = fzzzzzd_,
                Contact = new List<ContactDetail>((IEnumerable<ContactDetail>)fzzzzze_),
                DescriptionElement = fzzzzzf_,
                UseContext = new List<UsageContext>((IEnumerable<UsageContext>)fzzzzzg_),
                Jurisdiction = new List<CodeableConcept>((IEnumerable<CodeableConcept>)fzzzzzh_),
                ImmutableElement = fzzzzzi_,
                PurposeElement = fzzzzzj_,
                CopyrightElement = fzzzzzk_,
                Compose = fzzzzzl_,
                Expansion = fzzzzzm_,
            };

            return fzzzzzn_;
        };
        IEnumerable<ValueSet> ezzzzzs_ = context.Operators.Select<ValueSet, ValueSet>((IEnumerable<ValueSet>)ezzzzzq_, ezzzzzr_);
        IEnumerable<ValueSet> ezzzzzt_ = context.Operators.Distinct<ValueSet>(ezzzzzs_);
        ValueSet ezzzzzu_ = context.Operators.SingletonFrom<ValueSet>(ezzzzzt_);

        return ezzzzzu_;
    }


    [CqlExpressionDefinition("VerificationResultResource")]
    public VerificationResult VerificationResultResource(CqlContext context, VerificationResult arg)
    {
        VerificationResult[] fzzzzzo_ = [
            arg,
        ];
        VerificationResult fzzzzzp_(VerificationResult a)
        {
            List<ResourceReference> fzzzzzt_ = a?.Target;
            List<FhirString> fzzzzzu_ = a?.TargetLocationElement;
            CodeableConcept fzzzzzv_ = a?.Need;
            Code<VerificationResult.StatusCode> fzzzzzw_ = a?.StatusElement;
            FhirDateTime fzzzzzx_ = a?.StatusDateElement;
            CodeableConcept fzzzzzy_ = a?.ValidationType;
            List<CodeableConcept> fzzzzzz_ = a?.ValidationProcess;
            Timing gzzzzza_ = a?.Frequency;
            FhirDateTime gzzzzzb_ = a?.LastPerformedElement;
            Date gzzzzzc_ = a?.NextScheduledElement;
            CodeableConcept gzzzzzd_ = a?.FailureAction;
            List<VerificationResult.PrimarySourceComponent> gzzzzze_ = a?.PrimarySource;
            VerificationResult.AttestationComponent gzzzzzf_ = a?.Attestation;
            List<VerificationResult.ValidatorComponent> gzzzzzg_ = a?.Validator;
            VerificationResult gzzzzzh_ = new VerificationResult
            {
                Target = new List<ResourceReference>((IEnumerable<ResourceReference>)fzzzzzt_),
                TargetLocationElement = new List<FhirString>((IEnumerable<FhirString>)fzzzzzu_),
                Need = fzzzzzv_,
                StatusElement = fzzzzzw_,
                StatusDateElement = fzzzzzx_,
                ValidationType = fzzzzzy_,
                ValidationProcess = new List<CodeableConcept>((IEnumerable<CodeableConcept>)fzzzzzz_),
                Frequency = gzzzzza_,
                LastPerformedElement = gzzzzzb_,
                NextScheduledElement = gzzzzzc_,
                FailureAction = gzzzzzd_,
                PrimarySource = new List<VerificationResult.PrimarySourceComponent>((IEnumerable<VerificationResult.PrimarySourceComponent>)gzzzzze_),
                Attestation = gzzzzzf_,
                Validator = new List<VerificationResult.ValidatorComponent>((IEnumerable<VerificationResult.ValidatorComponent>)gzzzzzg_),
            };

            return gzzzzzh_;
        };
        IEnumerable<VerificationResult> fzzzzzq_ = context.Operators.Select<VerificationResult, VerificationResult>((IEnumerable<VerificationResult>)fzzzzzo_, fzzzzzp_);
        IEnumerable<VerificationResult> fzzzzzr_ = context.Operators.Distinct<VerificationResult>(fzzzzzq_);
        VerificationResult fzzzzzs_ = context.Operators.SingletonFrom<VerificationResult>(fzzzzzr_);

        return fzzzzzs_;
    }


    [CqlExpressionDefinition("VisionPrescriptionResource")]
    public VisionPrescription VisionPrescriptionResource(CqlContext context, VisionPrescription arg)
    {
        VisionPrescription[] gzzzzzi_ = [
            arg,
        ];
        VisionPrescription gzzzzzj_(VisionPrescription a)
        {
            List<Identifier> gzzzzzn_ = a?.Identifier;
            Code<FinancialResourceStatusCodes> gzzzzzo_ = a?.StatusElement;
            FhirDateTime gzzzzzp_ = a?.CreatedElement;
            ResourceReference gzzzzzq_ = a?.Patient;
            ResourceReference gzzzzzr_ = a?.Encounter;
            FhirDateTime gzzzzzs_ = a?.DateWrittenElement;
            ResourceReference gzzzzzt_ = a?.Prescriber;
            List<VisionPrescription.LensSpecificationComponent> gzzzzzu_ = a?.LensSpecification;
            VisionPrescription gzzzzzv_ = new VisionPrescription
            {
                Identifier = new List<Identifier>((IEnumerable<Identifier>)gzzzzzn_),
                StatusElement = gzzzzzo_,
                CreatedElement = gzzzzzp_,
                Patient = gzzzzzq_,
                Encounter = gzzzzzr_,
                DateWrittenElement = gzzzzzs_,
                Prescriber = gzzzzzt_,
                LensSpecification = new List<VisionPrescription.LensSpecificationComponent>((IEnumerable<VisionPrescription.LensSpecificationComponent>)gzzzzzu_),
            };

            return gzzzzzv_;
        };
        IEnumerable<VisionPrescription> gzzzzzk_ = context.Operators.Select<VisionPrescription, VisionPrescription>((IEnumerable<VisionPrescription>)gzzzzzi_, gzzzzzj_);
        IEnumerable<VisionPrescription> gzzzzzl_ = context.Operators.Distinct<VisionPrescription>(gzzzzzk_);
        VisionPrescription gzzzzzm_ = context.Operators.SingletonFrom<VisionPrescription>(gzzzzzl_);

        return gzzzzzm_;
    }


    #endregion Expressions

}

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
        Account[] wo_ = [
            arg,
        ];
        Account wp_(Account a)
        {
            List<Identifier> wt_ = a?.Identifier;
            Code<Account.AccountStatus> wu_ = a?.StatusElement;
            CodeableConcept wv_ = a?.Type;
            FhirString ww_ = a?.NameElement;
            List<ResourceReference> wx_ = a?.Subject;
            Period wy_ = a?.ServicePeriod;
            List<Account.CoverageComponent> wz_ = a?.Coverage;
            ResourceReference xa_ = a?.Owner;
            FhirString xb_ = a?.DescriptionElement;
            List<Account.GuarantorComponent> xc_ = a?.Guarantor;
            ResourceReference xd_ = a?.PartOf;
            Account xe_ = new Account
            {
                Identifier = new List<Identifier>((IEnumerable<Identifier>)wt_),
                StatusElement = wu_,
                Type = wv_,
                NameElement = ww_,
                Subject = new List<ResourceReference>((IEnumerable<ResourceReference>)wx_),
                ServicePeriod = wy_,
                Coverage = new List<Account.CoverageComponent>((IEnumerable<Account.CoverageComponent>)wz_),
                Owner = xa_,
                DescriptionElement = xb_,
                Guarantor = new List<Account.GuarantorComponent>((IEnumerable<Account.GuarantorComponent>)xc_),
                PartOf = xd_,
            };

            return xe_;
        };
        IEnumerable<Account> wq_ = context.Operators.Select<Account, Account>((IEnumerable<Account>)wo_, wp_);
        IEnumerable<Account> wr_ = context.Operators.Distinct<Account>(wq_);
        Account ws_ = context.Operators.SingletonFrom<Account>(wr_);

        return ws_;
    }


    [CqlExpressionDefinition("ActivityDefinitionResource")]
    public ActivityDefinition ActivityDefinitionResource(CqlContext context, ActivityDefinition arg)
    {
        ActivityDefinition[] xf_ = [
            arg,
        ];
        ActivityDefinition xg_(ActivityDefinition a)
        {
            FhirUri xk_ = a?.UrlElement;
            List<Identifier> xl_ = a?.Identifier;
            FhirString xm_ = a?.VersionElement;
            FhirString xn_ = a?.NameElement;
            FhirString xo_ = a?.TitleElement;
            FhirString xp_ = a?.SubtitleElement;
            Code<PublicationStatus> xq_ = a?.StatusElement;
            FhirBoolean xr_ = a?.ExperimentalElement;
            DataType xs_ = a?.Subject;
            FhirDateTime xt_ = a?.DateElement;
            FhirString xu_ = a?.PublisherElement;
            List<ContactDetail> xv_ = a?.Contact;
            Markdown xw_ = a?.DescriptionElement;
            List<UsageContext> xx_ = a?.UseContext;
            List<CodeableConcept> xy_ = a?.Jurisdiction;
            Markdown xz_ = a?.PurposeElement;
            FhirString ya_ = a?.UsageElement;
            Markdown yb_ = a?.CopyrightElement;
            Date yc_ = a?.ApprovalDateElement;
            Date yd_ = a?.LastReviewDateElement;
            Period ye_ = a?.EffectivePeriod;
            List<CodeableConcept> yf_ = a?.Topic;
            List<ContactDetail> yg_ = a?.Author;
            List<ContactDetail> yh_ = a?.Editor;
            List<ContactDetail> yi_ = a?.Reviewer;
            List<ContactDetail> yj_ = a?.Endorser;
            List<RelatedArtifact> yk_ = a?.RelatedArtifact;
            List<Canonical> yl_ = a?.LibraryElement;
            Code<ActivityDefinition.RequestResourceType> ym_ = a?.KindElement;
            Canonical yn_ = a?.ProfileElement;
            CodeableConcept yo_ = a?.Code;
            Code<RequestIntent> yp_ = a?.IntentElement;
            Code<RequestPriority> yq_ = a?.PriorityElement;
            FhirBoolean yr_ = a?.DoNotPerformElement;
            DataType ys_ = a?.Timing;
            ResourceReference yt_ = a?.Location;
            List<ActivityDefinition.ParticipantComponent> yu_ = a?.Participant;
            DataType yv_ = a?.Product;
            Quantity yw_ = a?.Quantity;
            List<Dosage> yx_ = a?.Dosage;
            List<CodeableConcept> yy_ = a?.BodySite;
            List<ResourceReference> yz_ = a?.SpecimenRequirement;
            List<ResourceReference> za_ = a?.ObservationRequirement;
            List<ResourceReference> zb_ = a?.ObservationResultRequirement;
            Canonical zc_ = a?.TransformElement;
            List<ActivityDefinition.DynamicValueComponent> zd_ = a?.DynamicValue;
            ActivityDefinition ze_ = new ActivityDefinition
            {
                UrlElement = xk_,
                Identifier = new List<Identifier>((IEnumerable<Identifier>)xl_),
                VersionElement = xm_,
                NameElement = xn_,
                TitleElement = xo_,
                SubtitleElement = xp_,
                StatusElement = xq_,
                ExperimentalElement = xr_,
                Subject = (DataType)xs_,
                DateElement = xt_,
                PublisherElement = xu_,
                Contact = new List<ContactDetail>((IEnumerable<ContactDetail>)xv_),
                DescriptionElement = xw_,
                UseContext = new List<UsageContext>((IEnumerable<UsageContext>)xx_),
                Jurisdiction = new List<CodeableConcept>((IEnumerable<CodeableConcept>)xy_),
                PurposeElement = xz_,
                UsageElement = ya_,
                CopyrightElement = yb_,
                ApprovalDateElement = yc_,
                LastReviewDateElement = yd_,
                EffectivePeriod = ye_,
                Topic = new List<CodeableConcept>((IEnumerable<CodeableConcept>)yf_),
                Author = new List<ContactDetail>((IEnumerable<ContactDetail>)yg_),
                Editor = new List<ContactDetail>((IEnumerable<ContactDetail>)yh_),
                Reviewer = new List<ContactDetail>((IEnumerable<ContactDetail>)yi_),
                Endorser = new List<ContactDetail>((IEnumerable<ContactDetail>)yj_),
                RelatedArtifact = new List<RelatedArtifact>((IEnumerable<RelatedArtifact>)yk_),
                LibraryElement = new List<Canonical>((IEnumerable<Canonical>)yl_),
                KindElement = ym_,
                ProfileElement = yn_,
                Code = yo_,
                IntentElement = yp_,
                PriorityElement = yq_,
                DoNotPerformElement = yr_,
                Timing = (DataType)ys_,
                Location = yt_,
                Participant = new List<ActivityDefinition.ParticipantComponent>((IEnumerable<ActivityDefinition.ParticipantComponent>)yu_),
                Product = (DataType)yv_,
                Quantity = yw_,
                Dosage = new List<Dosage>((IEnumerable<Dosage>)yx_),
                BodySite = new List<CodeableConcept>((IEnumerable<CodeableConcept>)yy_),
                SpecimenRequirement = new List<ResourceReference>((IEnumerable<ResourceReference>)yz_),
                ObservationRequirement = new List<ResourceReference>((IEnumerable<ResourceReference>)za_),
                ObservationResultRequirement = new List<ResourceReference>((IEnumerable<ResourceReference>)zb_),
                TransformElement = zc_,
                DynamicValue = new List<ActivityDefinition.DynamicValueComponent>((IEnumerable<ActivityDefinition.DynamicValueComponent>)zd_),
            };

            return ze_;
        };
        IEnumerable<ActivityDefinition> xh_ = context.Operators.Select<ActivityDefinition, ActivityDefinition>((IEnumerable<ActivityDefinition>)xf_, xg_);
        IEnumerable<ActivityDefinition> xi_ = context.Operators.Distinct<ActivityDefinition>(xh_);
        ActivityDefinition xj_ = context.Operators.SingletonFrom<ActivityDefinition>(xi_);

        return xj_;
    }


    [CqlExpressionDefinition("AdverseEventResource")]
    public AdverseEvent AdverseEventResource(CqlContext context, AdverseEvent arg)
    {
        AdverseEvent[] zf_ = [
            arg,
        ];
        AdverseEvent zg_(AdverseEvent a)
        {
            Identifier zk_ = a?.Identifier;
            Code<AdverseEvent.AdverseEventActuality> zl_ = a?.ActualityElement;
            List<CodeableConcept> zm_ = a?.Category;
            CodeableConcept zn_ = a?.Event;
            ResourceReference zo_ = a?.Subject;
            ResourceReference zp_ = a?.Encounter;
            FhirDateTime zq_ = a?.DateElement;
            FhirDateTime zr_ = a?.DetectedElement;
            FhirDateTime zs_ = a?.RecordedDateElement;
            List<ResourceReference> zt_ = a?.ResultingCondition;
            ResourceReference zu_ = a?.Location;
            CodeableConcept zv_ = a?.Seriousness;
            CodeableConcept zw_ = a?.Severity;
            CodeableConcept zx_ = a?.Outcome;
            ResourceReference zy_ = a?.Recorder;
            List<ResourceReference> zz_ = a?.Contributor;
            List<AdverseEvent.SuspectEntityComponent> aza_ = a?.SuspectEntity;
            List<ResourceReference> azb_ = a?.SubjectMedicalHistory;
            List<ResourceReference> azc_ = a?.ReferenceDocument;
            List<ResourceReference> azd_ = a?.Study;
            AdverseEvent aze_ = new AdverseEvent
            {
                Identifier = zk_,
                ActualityElement = zl_,
                Category = new List<CodeableConcept>((IEnumerable<CodeableConcept>)zm_),
                Event = zn_,
                Subject = zo_,
                Encounter = zp_,
                DateElement = zq_,
                DetectedElement = zr_,
                RecordedDateElement = zs_,
                ResultingCondition = new List<ResourceReference>((IEnumerable<ResourceReference>)zt_),
                Location = zu_,
                Seriousness = zv_,
                Severity = zw_,
                Outcome = zx_,
                Recorder = zy_,
                Contributor = new List<ResourceReference>((IEnumerable<ResourceReference>)zz_),
                SuspectEntity = new List<AdverseEvent.SuspectEntityComponent>((IEnumerable<AdverseEvent.SuspectEntityComponent>)aza_),
                SubjectMedicalHistory = new List<ResourceReference>((IEnumerable<ResourceReference>)azb_),
                ReferenceDocument = new List<ResourceReference>((IEnumerable<ResourceReference>)azc_),
                Study = new List<ResourceReference>((IEnumerable<ResourceReference>)azd_),
            };

            return aze_;
        };
        IEnumerable<AdverseEvent> zh_ = context.Operators.Select<AdverseEvent, AdverseEvent>((IEnumerable<AdverseEvent>)zf_, zg_);
        IEnumerable<AdverseEvent> zi_ = context.Operators.Distinct<AdverseEvent>(zh_);
        AdverseEvent zj_ = context.Operators.SingletonFrom<AdverseEvent>(zi_);

        return zj_;
    }


    [CqlExpressionDefinition("AllergyIntoleranceResource")]
    public AllergyIntolerance AllergyIntoleranceResource(CqlContext context, AllergyIntolerance arg)
    {
        AllergyIntolerance[] azf_ = [
            arg,
        ];
        AllergyIntolerance azg_(AllergyIntolerance a)
        {
            List<Identifier> azk_ = a?.Identifier;
            CodeableConcept azl_ = a?.ClinicalStatus;
            CodeableConcept azm_ = a?.VerificationStatus;
            Code<AllergyIntolerance.AllergyIntoleranceType> azn_ = a?.TypeElement;
            List<Code<AllergyIntolerance.AllergyIntoleranceCategory>> azo_ = a?.CategoryElement;
            Code<AllergyIntolerance.AllergyIntoleranceCriticality> azp_ = a?.CriticalityElement;
            CodeableConcept azq_ = a?.Code;
            ResourceReference azr_ = a?.Patient;
            ResourceReference azs_ = a?.Encounter;
            DataType azt_ = a?.Onset;
            FhirDateTime azu_ = a?.RecordedDateElement;
            ResourceReference azv_ = a?.Recorder;
            ResourceReference azw_ = a?.Asserter;
            FhirDateTime azx_ = a?.LastOccurrenceElement;
            List<Annotation> azy_ = a?.Note;
            List<AllergyIntolerance.ReactionComponent> azz_ = a?.Reaction;
            AllergyIntolerance bza_ = new AllergyIntolerance
            {
                Identifier = new List<Identifier>((IEnumerable<Identifier>)azk_),
                ClinicalStatus = azl_,
                VerificationStatus = azm_,
                TypeElement = azn_,
                CategoryElement = new List<Code<AllergyIntolerance.AllergyIntoleranceCategory>>((IEnumerable<Code<AllergyIntolerance.AllergyIntoleranceCategory>>)azo_),
                CriticalityElement = azp_,
                Code = azq_,
                Patient = azr_,
                Encounter = azs_,
                Onset = (DataType)azt_,
                RecordedDateElement = azu_,
                Recorder = azv_,
                Asserter = azw_,
                LastOccurrenceElement = azx_,
                Note = new List<Annotation>((IEnumerable<Annotation>)azy_),
                Reaction = new List<AllergyIntolerance.ReactionComponent>((IEnumerable<AllergyIntolerance.ReactionComponent>)azz_),
            };

            return bza_;
        };
        IEnumerable<AllergyIntolerance> azh_ = context.Operators.Select<AllergyIntolerance, AllergyIntolerance>((IEnumerable<AllergyIntolerance>)azf_, azg_);
        IEnumerable<AllergyIntolerance> azi_ = context.Operators.Distinct<AllergyIntolerance>(azh_);
        AllergyIntolerance azj_ = context.Operators.SingletonFrom<AllergyIntolerance>(azi_);

        return azj_;
    }


    [CqlExpressionDefinition("AppointmentResource")]
    public Appointment AppointmentResource(CqlContext context, Appointment arg)
    {
        Appointment[] bzb_ = [
            arg,
        ];
        Appointment bzc_(Appointment a)
        {
            List<Identifier> bzg_ = a?.Identifier;
            Code<Appointment.AppointmentStatus> bzh_ = a?.StatusElement;
            CodeableConcept bzi_ = a?.CancelationReason;
            List<CodeableConcept> bzj_ = a?.ServiceCategory;
            List<CodeableConcept> bzk_ = a?.ServiceType;
            List<CodeableConcept> bzl_ = a?.Specialty;
            CodeableConcept bzm_ = a?.AppointmentType;
            List<CodeableConcept> bzn_ = a?.ReasonCode;
            List<ResourceReference> bzo_ = a?.ReasonReference;
            UnsignedInt bzp_ = a?.PriorityElement;
            Integer bzq_ = context.Operators.Convert<Integer>(bzp_);
            UnsignedInt bzr_ = context.Operators.Convert<UnsignedInt>(bzq_);
            FhirString bzs_ = a?.DescriptionElement;
            List<ResourceReference> bzt_ = a?.SupportingInformation;
            Instant bzu_ = a?.StartElement;
            Instant bzv_ = a?.EndElement;
            PositiveInt bzw_ = a?.MinutesDurationElement;
            Integer bzx_ = context.Operators.Convert<Integer>(bzw_);
            PositiveInt bzy_ = context.Operators.Convert<PositiveInt>(bzx_);
            List<ResourceReference> bzz_ = a?.Slot;
            FhirDateTime cza_ = a?.CreatedElement;
            FhirString czb_ = a?.CommentElement;
            FhirString czc_ = a?.PatientInstructionElement;
            List<ResourceReference> czd_ = a?.BasedOn;
            List<Appointment.ParticipantComponent> cze_ = a?.Participant;
            List<Period> czf_ = a?.RequestedPeriod;
            Appointment czg_ = new Appointment
            {
                Identifier = new List<Identifier>((IEnumerable<Identifier>)bzg_),
                StatusElement = bzh_,
                CancelationReason = bzi_,
                ServiceCategory = new List<CodeableConcept>((IEnumerable<CodeableConcept>)bzj_),
                ServiceType = new List<CodeableConcept>((IEnumerable<CodeableConcept>)bzk_),
                Specialty = new List<CodeableConcept>((IEnumerable<CodeableConcept>)bzl_),
                AppointmentType = bzm_,
                ReasonCode = new List<CodeableConcept>((IEnumerable<CodeableConcept>)bzn_),
                ReasonReference = new List<ResourceReference>((IEnumerable<ResourceReference>)bzo_),
                PriorityElement = bzr_,
                DescriptionElement = bzs_,
                SupportingInformation = new List<ResourceReference>((IEnumerable<ResourceReference>)bzt_),
                StartElement = bzu_,
                EndElement = bzv_,
                MinutesDurationElement = bzy_,
                Slot = new List<ResourceReference>((IEnumerable<ResourceReference>)bzz_),
                CreatedElement = cza_,
                CommentElement = czb_,
                PatientInstructionElement = czc_,
                BasedOn = new List<ResourceReference>((IEnumerable<ResourceReference>)czd_),
                Participant = new List<Appointment.ParticipantComponent>((IEnumerable<Appointment.ParticipantComponent>)cze_),
                RequestedPeriod = new List<Period>((IEnumerable<Period>)czf_),
            };

            return czg_;
        };
        IEnumerable<Appointment> bzd_ = context.Operators.Select<Appointment, Appointment>((IEnumerable<Appointment>)bzb_, bzc_);
        IEnumerable<Appointment> bze_ = context.Operators.Distinct<Appointment>(bzd_);
        Appointment bzf_ = context.Operators.SingletonFrom<Appointment>(bze_);

        return bzf_;
    }


    [CqlExpressionDefinition("AppointmentResponseResource")]
    public AppointmentResponse AppointmentResponseResource(CqlContext context, AppointmentResponse arg)
    {
        AppointmentResponse[] czh_ = [
            arg,
        ];
        AppointmentResponse czi_(AppointmentResponse a)
        {
            List<Identifier> czm_ = a?.Identifier;
            ResourceReference czn_ = a?.Appointment;
            Instant czo_ = a?.StartElement;
            Instant czp_ = a?.EndElement;
            List<CodeableConcept> czq_ = a?.ParticipantType;
            ResourceReference czr_ = a?.Actor;
            Code<ParticipationStatus> czs_ = a?.ParticipantStatusElement;
            FhirString czt_ = a?.CommentElement;
            AppointmentResponse czu_ = new AppointmentResponse
            {
                Identifier = new List<Identifier>((IEnumerable<Identifier>)czm_),
                Appointment = czn_,
                StartElement = czo_,
                EndElement = czp_,
                ParticipantType = new List<CodeableConcept>((IEnumerable<CodeableConcept>)czq_),
                Actor = czr_,
                ParticipantStatusElement = czs_,
                CommentElement = czt_,
            };

            return czu_;
        };
        IEnumerable<AppointmentResponse> czj_ = context.Operators.Select<AppointmentResponse, AppointmentResponse>((IEnumerable<AppointmentResponse>)czh_, czi_);
        IEnumerable<AppointmentResponse> czk_ = context.Operators.Distinct<AppointmentResponse>(czj_);
        AppointmentResponse czl_ = context.Operators.SingletonFrom<AppointmentResponse>(czk_);

        return czl_;
    }


    [CqlExpressionDefinition("AuditEventResource")]
    public AuditEvent AuditEventResource(CqlContext context, AuditEvent arg)
    {
        AuditEvent[] czv_ = [
            arg,
        ];
        AuditEvent czw_(AuditEvent a)
        {
            Coding dza_ = a?.Type;
            List<Coding> dzb_ = a?.Subtype;
            Code<AuditEvent.AuditEventAction> dzc_ = a?.ActionElement;
            Period dzd_ = a?.Period;
            Instant dze_ = a?.RecordedElement;
            Code<AuditEvent.AuditEventOutcome> dzf_ = a?.OutcomeElement;
            FhirString dzg_ = a?.OutcomeDescElement;
            List<CodeableConcept> dzh_ = a?.PurposeOfEvent;
            List<AuditEvent.AgentComponent> dzi_ = a?.Agent;
            AuditEvent.SourceComponent dzj_ = a?.Source;
            List<AuditEvent.EntityComponent> dzk_ = a?.Entity;
            AuditEvent dzl_ = new AuditEvent
            {
                Type = dza_,
                Subtype = new List<Coding>((IEnumerable<Coding>)dzb_),
                ActionElement = dzc_,
                Period = dzd_,
                RecordedElement = dze_,
                OutcomeElement = dzf_,
                OutcomeDescElement = dzg_,
                PurposeOfEvent = new List<CodeableConcept>((IEnumerable<CodeableConcept>)dzh_),
                Agent = new List<AuditEvent.AgentComponent>((IEnumerable<AuditEvent.AgentComponent>)dzi_),
                Source = dzj_,
                Entity = new List<AuditEvent.EntityComponent>((IEnumerable<AuditEvent.EntityComponent>)dzk_),
            };

            return dzl_;
        };
        IEnumerable<AuditEvent> czx_ = context.Operators.Select<AuditEvent, AuditEvent>((IEnumerable<AuditEvent>)czv_, czw_);
        IEnumerable<AuditEvent> czy_ = context.Operators.Distinct<AuditEvent>(czx_);
        AuditEvent czz_ = context.Operators.SingletonFrom<AuditEvent>(czy_);

        return czz_;
    }


    [CqlExpressionDefinition("BasicResource")]
    public Basic BasicResource(CqlContext context, Basic arg)
    {
        Basic[] dzm_ = [
            arg,
        ];
        Basic dzn_(Basic a)
        {
            List<Identifier> dzr_ = a?.Identifier;
            CodeableConcept dzs_ = a?.Code;
            ResourceReference dzt_ = a?.Subject;
            Date dzu_ = a?.CreatedElement;
            ResourceReference dzv_ = a?.Author;
            Basic dzw_ = new Basic
            {
                Identifier = new List<Identifier>((IEnumerable<Identifier>)dzr_),
                Code = dzs_,
                Subject = dzt_,
                CreatedElement = dzu_,
                Author = dzv_,
            };

            return dzw_;
        };
        IEnumerable<Basic> dzo_ = context.Operators.Select<Basic, Basic>((IEnumerable<Basic>)dzm_, dzn_);
        IEnumerable<Basic> dzp_ = context.Operators.Distinct<Basic>(dzo_);
        Basic dzq_ = context.Operators.SingletonFrom<Basic>(dzp_);

        return dzq_;
    }


    [CqlExpressionDefinition("BiologicallyDerivedProductResource")]
    public BiologicallyDerivedProduct BiologicallyDerivedProductResource(CqlContext context, BiologicallyDerivedProduct arg)
    {
        BiologicallyDerivedProduct[] dzx_ = [
            arg,
        ];
        BiologicallyDerivedProduct dzy_(BiologicallyDerivedProduct a)
        {
            List<Identifier> ezc_ = a?.Identifier;
            Code<BiologicallyDerivedProduct.BiologicallyDerivedProductCategory> ezd_ = a?.ProductCategoryElement;
            CodeableConcept eze_ = a?.ProductCode;
            Code<BiologicallyDerivedProduct.BiologicallyDerivedProductStatus> ezf_ = a?.StatusElement;
            List<ResourceReference> ezg_ = a?.Request;
            Integer ezh_ = a?.QuantityElement;
            List<ResourceReference> ezi_ = a?.Parent;
            BiologicallyDerivedProduct.CollectionComponent ezj_ = a?.Collection;
            List<BiologicallyDerivedProduct.ProcessingComponent> ezk_ = a?.Processing;
            BiologicallyDerivedProduct.ManipulationComponent ezl_ = a?.Manipulation;
            List<BiologicallyDerivedProduct.StorageComponent> ezm_ = a?.Storage;
            BiologicallyDerivedProduct ezn_ = new BiologicallyDerivedProduct
            {
                Identifier = new List<Identifier>((IEnumerable<Identifier>)ezc_),
                ProductCategoryElement = ezd_,
                ProductCode = eze_,
                StatusElement = ezf_,
                Request = new List<ResourceReference>((IEnumerable<ResourceReference>)ezg_),
                QuantityElement = ezh_,
                Parent = new List<ResourceReference>((IEnumerable<ResourceReference>)ezi_),
                Collection = ezj_,
                Processing = new List<BiologicallyDerivedProduct.ProcessingComponent>((IEnumerable<BiologicallyDerivedProduct.ProcessingComponent>)ezk_),
                Manipulation = ezl_,
                Storage = new List<BiologicallyDerivedProduct.StorageComponent>((IEnumerable<BiologicallyDerivedProduct.StorageComponent>)ezm_),
            };

            return ezn_;
        };
        IEnumerable<BiologicallyDerivedProduct> dzz_ = context.Operators.Select<BiologicallyDerivedProduct, BiologicallyDerivedProduct>((IEnumerable<BiologicallyDerivedProduct>)dzx_, dzy_);
        IEnumerable<BiologicallyDerivedProduct> eza_ = context.Operators.Distinct<BiologicallyDerivedProduct>(dzz_);
        BiologicallyDerivedProduct ezb_ = context.Operators.SingletonFrom<BiologicallyDerivedProduct>(eza_);

        return ezb_;
    }


    [CqlExpressionDefinition("BodyStructureResource")]
    public BodyStructure BodyStructureResource(CqlContext context, BodyStructure arg)
    {
        BodyStructure[] ezo_ = [
            arg,
        ];
        BodyStructure ezp_(BodyStructure a)
        {
            List<Identifier> ezt_ = a?.Identifier;
            FhirBoolean ezu_ = a?.ActiveElement;
            CodeableConcept ezv_ = a?.Morphology;
            CodeableConcept ezw_ = a?.Location;
            List<CodeableConcept> ezx_ = a?.LocationQualifier;
            FhirString ezy_ = a?.DescriptionElement;
            List<Attachment> ezz_ = a?.Image;
            ResourceReference fza_ = a?.Patient;
            BodyStructure fzb_ = new BodyStructure
            {
                Identifier = new List<Identifier>((IEnumerable<Identifier>)ezt_),
                ActiveElement = ezu_,
                Morphology = ezv_,
                Location = ezw_,
                LocationQualifier = new List<CodeableConcept>((IEnumerable<CodeableConcept>)ezx_),
                DescriptionElement = ezy_,
                Image = new List<Attachment>((IEnumerable<Attachment>)ezz_),
                Patient = fza_,
            };

            return fzb_;
        };
        IEnumerable<BodyStructure> ezq_ = context.Operators.Select<BodyStructure, BodyStructure>((IEnumerable<BodyStructure>)ezo_, ezp_);
        IEnumerable<BodyStructure> ezr_ = context.Operators.Distinct<BodyStructure>(ezq_);
        BodyStructure ezs_ = context.Operators.SingletonFrom<BodyStructure>(ezr_);

        return ezs_;
    }


    [CqlExpressionDefinition("CarePlanResource")]
    public CarePlan CarePlanResource(CqlContext context, CarePlan arg)
    {
        CarePlan[] fzc_ = [
            arg,
        ];
        CarePlan fzd_(CarePlan a)
        {
            List<Identifier> fzh_ = a?.Identifier;
            List<Canonical> fzi_ = a?.InstantiatesCanonicalElement;
            List<FhirUri> fzj_ = a?.InstantiatesUriElement;
            List<ResourceReference> fzk_ = a?.BasedOn;
            List<ResourceReference> fzl_ = a?.Replaces;
            List<ResourceReference> fzm_ = a?.PartOf;
            Code<RequestStatus> fzn_ = a?.StatusElement;
            Code<CarePlan.CarePlanIntent> fzo_ = a?.IntentElement;
            List<CodeableConcept> fzp_ = a?.Category;
            FhirString fzq_ = a?.TitleElement;
            FhirString fzr_ = a?.DescriptionElement;
            ResourceReference fzs_ = a?.Subject;
            ResourceReference fzt_ = a?.Encounter;
            Period fzu_ = a?.Period;
            FhirDateTime fzv_ = a?.CreatedElement;
            ResourceReference fzw_ = a?.Author;
            List<ResourceReference> fzx_ = a?.Contributor;
            List<ResourceReference> fzy_ = a?.CareTeam;
            List<ResourceReference> fzz_ = a?.Addresses;
            List<ResourceReference> gza_ = a?.SupportingInfo;
            List<ResourceReference> gzb_ = a?.Goal;
            List<CarePlan.ActivityComponent> gzc_ = a?.Activity;
            List<Annotation> gzd_ = a?.Note;
            CarePlan gze_ = new CarePlan
            {
                Identifier = new List<Identifier>((IEnumerable<Identifier>)fzh_),
                InstantiatesCanonicalElement = new List<Canonical>((IEnumerable<Canonical>)fzi_),
                InstantiatesUriElement = new List<FhirUri>((IEnumerable<FhirUri>)fzj_),
                BasedOn = new List<ResourceReference>((IEnumerable<ResourceReference>)fzk_),
                Replaces = new List<ResourceReference>((IEnumerable<ResourceReference>)fzl_),
                PartOf = new List<ResourceReference>((IEnumerable<ResourceReference>)fzm_),
                StatusElement = fzn_,
                IntentElement = fzo_,
                Category = new List<CodeableConcept>((IEnumerable<CodeableConcept>)fzp_),
                TitleElement = fzq_,
                DescriptionElement = fzr_,
                Subject = fzs_,
                Encounter = fzt_,
                Period = fzu_,
                CreatedElement = fzv_,
                Author = fzw_,
                Contributor = new List<ResourceReference>((IEnumerable<ResourceReference>)fzx_),
                CareTeam = new List<ResourceReference>((IEnumerable<ResourceReference>)fzy_),
                Addresses = new List<ResourceReference>((IEnumerable<ResourceReference>)fzz_),
                SupportingInfo = new List<ResourceReference>((IEnumerable<ResourceReference>)gza_),
                Goal = new List<ResourceReference>((IEnumerable<ResourceReference>)gzb_),
                Activity = new List<CarePlan.ActivityComponent>((IEnumerable<CarePlan.ActivityComponent>)gzc_),
                Note = new List<Annotation>((IEnumerable<Annotation>)gzd_),
            };

            return gze_;
        };
        IEnumerable<CarePlan> fze_ = context.Operators.Select<CarePlan, CarePlan>((IEnumerable<CarePlan>)fzc_, fzd_);
        IEnumerable<CarePlan> fzf_ = context.Operators.Distinct<CarePlan>(fze_);
        CarePlan fzg_ = context.Operators.SingletonFrom<CarePlan>(fzf_);

        return fzg_;
    }


    [CqlExpressionDefinition("CareTeamResource")]
    public CareTeam CareTeamResource(CqlContext context, CareTeam arg)
    {
        CareTeam[] gzf_ = [
            arg,
        ];
        CareTeam gzg_(CareTeam a)
        {
            List<Identifier> gzk_ = a?.Identifier;
            Code<CareTeam.CareTeamStatus> gzl_ = a?.StatusElement;
            List<CodeableConcept> gzm_ = a?.Category;
            FhirString gzn_ = a?.NameElement;
            ResourceReference gzo_ = a?.Subject;
            ResourceReference gzp_ = a?.Encounter;
            Period gzq_ = a?.Period;
            List<CareTeam.ParticipantComponent> gzr_ = a?.Participant;
            List<CodeableConcept> gzs_ = a?.ReasonCode;
            List<ResourceReference> gzt_ = a?.ReasonReference;
            List<ResourceReference> gzu_ = a?.ManagingOrganization;
            List<ContactPoint> gzv_ = a?.Telecom;
            List<Annotation> gzw_ = a?.Note;
            CareTeam gzx_ = new CareTeam
            {
                Identifier = new List<Identifier>((IEnumerable<Identifier>)gzk_),
                StatusElement = gzl_,
                Category = new List<CodeableConcept>((IEnumerable<CodeableConcept>)gzm_),
                NameElement = gzn_,
                Subject = gzo_,
                Encounter = gzp_,
                Period = gzq_,
                Participant = new List<CareTeam.ParticipantComponent>((IEnumerable<CareTeam.ParticipantComponent>)gzr_),
                ReasonCode = new List<CodeableConcept>((IEnumerable<CodeableConcept>)gzs_),
                ReasonReference = new List<ResourceReference>((IEnumerable<ResourceReference>)gzt_),
                ManagingOrganization = new List<ResourceReference>((IEnumerable<ResourceReference>)gzu_),
                Telecom = new List<ContactPoint>((IEnumerable<ContactPoint>)gzv_),
                Note = new List<Annotation>((IEnumerable<Annotation>)gzw_),
            };

            return gzx_;
        };
        IEnumerable<CareTeam> gzh_ = context.Operators.Select<CareTeam, CareTeam>((IEnumerable<CareTeam>)gzf_, gzg_);
        IEnumerable<CareTeam> gzi_ = context.Operators.Distinct<CareTeam>(gzh_);
        CareTeam gzj_ = context.Operators.SingletonFrom<CareTeam>(gzi_);

        return gzj_;
    }


    [CqlExpressionDefinition("CatalogEntryResource")]
    public CatalogEntry CatalogEntryResource(CqlContext context, CatalogEntry arg)
    {
        CatalogEntry[] gzy_ = [
            arg,
        ];
        CatalogEntry gzz_(CatalogEntry a)
        {
            List<Identifier> hzd_ = a?.Identifier;
            CodeableConcept hze_ = a?.Type;
            FhirBoolean hzf_ = a?.OrderableElement;
            ResourceReference hzg_ = a?.ReferencedItem;
            List<Identifier> hzh_ = a?.AdditionalIdentifier;
            List<CodeableConcept> hzi_ = a?.Classification;
            Code<PublicationStatus> hzj_ = a?.StatusElement;
            Period hzk_ = a?.ValidityPeriod;
            FhirDateTime hzl_ = a?.ValidToElement;
            FhirDateTime hzm_ = a?.LastUpdatedElement;
            List<CodeableConcept> hzn_ = a?.AdditionalCharacteristic;
            List<CodeableConcept> hzo_ = a?.AdditionalClassification;
            List<CatalogEntry.RelatedEntryComponent> hzp_ = a?.RelatedEntry;
            CatalogEntry hzq_ = new CatalogEntry
            {
                Identifier = new List<Identifier>((IEnumerable<Identifier>)hzd_),
                Type = hze_,
                OrderableElement = hzf_,
                ReferencedItem = hzg_,
                AdditionalIdentifier = new List<Identifier>((IEnumerable<Identifier>)hzh_),
                Classification = new List<CodeableConcept>((IEnumerable<CodeableConcept>)hzi_),
                StatusElement = hzj_,
                ValidityPeriod = hzk_,
                ValidToElement = hzl_,
                LastUpdatedElement = hzm_,
                AdditionalCharacteristic = new List<CodeableConcept>((IEnumerable<CodeableConcept>)hzn_),
                AdditionalClassification = new List<CodeableConcept>((IEnumerable<CodeableConcept>)hzo_),
                RelatedEntry = new List<CatalogEntry.RelatedEntryComponent>((IEnumerable<CatalogEntry.RelatedEntryComponent>)hzp_),
            };

            return hzq_;
        };
        IEnumerable<CatalogEntry> hza_ = context.Operators.Select<CatalogEntry, CatalogEntry>((IEnumerable<CatalogEntry>)gzy_, gzz_);
        IEnumerable<CatalogEntry> hzb_ = context.Operators.Distinct<CatalogEntry>(hza_);
        CatalogEntry hzc_ = context.Operators.SingletonFrom<CatalogEntry>(hzb_);

        return hzc_;
    }


    [CqlExpressionDefinition("ChargeItemResource")]
    public ChargeItem ChargeItemResource(CqlContext context, ChargeItem arg)
    {
        ChargeItem[] hzr_ = [
            arg,
        ];
        ChargeItem hzs_(ChargeItem a)
        {
            List<Identifier> hzw_ = a?.Identifier;
            List<FhirUri> hzx_ = a?.DefinitionUriElement;
            List<Canonical> hzy_ = a?.DefinitionCanonicalElement;
            Code<ChargeItem.ChargeItemStatus> hzz_ = a?.StatusElement;
            List<ResourceReference> iza_ = a?.PartOf;
            CodeableConcept izb_ = a?.Code;
            ResourceReference izc_ = a?.Subject;
            ResourceReference izd_ = a?.Context;
            DataType ize_ = a?.Occurrence;
            List<ChargeItem.PerformerComponent> izf_ = a?.Performer;
            ResourceReference izg_ = a?.PerformingOrganization;
            ResourceReference izh_ = a?.RequestingOrganization;
            ResourceReference izi_ = a?.CostCenter;
            Quantity izj_ = a?.Quantity;
            List<CodeableConcept> izk_ = a?.Bodysite;
            FhirDecimal izl_ = a?.FactorOverrideElement;
            Money izm_ = a?.PriceOverride;
            FhirString izn_ = a?.OverrideReasonElement;
            ResourceReference izo_ = a?.Enterer;
            FhirDateTime izp_ = a?.EnteredDateElement;
            List<CodeableConcept> izq_ = a?.Reason;
            List<ResourceReference> izr_ = a?.Service;
            DataType izs_ = a?.Product;
            List<ResourceReference> izt_ = a?.Account;
            List<Annotation> izu_ = a?.Note;
            List<ResourceReference> izv_ = a?.SupportingInformation;
            ChargeItem izw_ = new ChargeItem
            {
                Identifier = new List<Identifier>((IEnumerable<Identifier>)hzw_),
                DefinitionUriElement = new List<FhirUri>((IEnumerable<FhirUri>)hzx_),
                DefinitionCanonicalElement = new List<Canonical>((IEnumerable<Canonical>)hzy_),
                StatusElement = hzz_,
                PartOf = new List<ResourceReference>((IEnumerable<ResourceReference>)iza_),
                Code = izb_,
                Subject = izc_,
                Context = izd_,
                Occurrence = (DataType)ize_,
                Performer = new List<ChargeItem.PerformerComponent>((IEnumerable<ChargeItem.PerformerComponent>)izf_),
                PerformingOrganization = izg_,
                RequestingOrganization = izh_,
                CostCenter = izi_,
                Quantity = izj_,
                Bodysite = new List<CodeableConcept>((IEnumerable<CodeableConcept>)izk_),
                FactorOverrideElement = izl_,
                PriceOverride = izm_,
                OverrideReasonElement = izn_,
                Enterer = izo_,
                EnteredDateElement = izp_,
                Reason = new List<CodeableConcept>((IEnumerable<CodeableConcept>)izq_),
                Service = new List<ResourceReference>((IEnumerable<ResourceReference>)izr_),
                Product = (DataType)izs_,
                Account = new List<ResourceReference>((IEnumerable<ResourceReference>)izt_),
                Note = new List<Annotation>((IEnumerable<Annotation>)izu_),
                SupportingInformation = new List<ResourceReference>((IEnumerable<ResourceReference>)izv_),
            };

            return izw_;
        };
        IEnumerable<ChargeItem> hzt_ = context.Operators.Select<ChargeItem, ChargeItem>((IEnumerable<ChargeItem>)hzr_, hzs_);
        IEnumerable<ChargeItem> hzu_ = context.Operators.Distinct<ChargeItem>(hzt_);
        ChargeItem hzv_ = context.Operators.SingletonFrom<ChargeItem>(hzu_);

        return hzv_;
    }


    [CqlExpressionDefinition("ChargeItemDefinitionResource")]
    public ChargeItemDefinition ChargeItemDefinitionResource(CqlContext context, ChargeItemDefinition arg)
    {
        ChargeItemDefinition[] izx_ = [
            arg,
        ];
        ChargeItemDefinition izy_(ChargeItemDefinition a)
        {
            FhirUri jzc_ = a?.UrlElement;
            List<Identifier> jzd_ = a?.Identifier;
            FhirString jze_ = a?.VersionElement;
            FhirString jzf_ = a?.TitleElement;
            List<FhirUri> jzg_ = a?.DerivedFromUriElement;
            List<Canonical> jzh_ = a?.PartOfElement;
            List<Canonical> jzi_ = a?.ReplacesElement;
            Code<PublicationStatus> jzj_ = a?.StatusElement;
            FhirBoolean jzk_ = a?.ExperimentalElement;
            FhirDateTime jzl_ = a?.DateElement;
            FhirString jzm_ = a?.PublisherElement;
            List<ContactDetail> jzn_ = a?.Contact;
            Markdown jzo_ = a?.DescriptionElement;
            List<UsageContext> jzp_ = a?.UseContext;
            List<CodeableConcept> jzq_ = a?.Jurisdiction;
            Markdown jzr_ = a?.CopyrightElement;
            Date jzs_ = a?.ApprovalDateElement;
            Date jzt_ = a?.LastReviewDateElement;
            Period jzu_ = a?.EffectivePeriod;
            CodeableConcept jzv_ = a?.Code;
            List<ResourceReference> jzw_ = a?.Instance;
            List<ChargeItemDefinition.ApplicabilityComponent> jzx_ = a?.Applicability;
            List<ChargeItemDefinition.PropertyGroupComponent> jzy_ = a?.PropertyGroup;
            ChargeItemDefinition jzz_ = new ChargeItemDefinition
            {
                UrlElement = jzc_,
                Identifier = new List<Identifier>((IEnumerable<Identifier>)jzd_),
                VersionElement = jze_,
                TitleElement = jzf_,
                DerivedFromUriElement = new List<FhirUri>((IEnumerable<FhirUri>)jzg_),
                PartOfElement = new List<Canonical>((IEnumerable<Canonical>)jzh_),
                ReplacesElement = new List<Canonical>((IEnumerable<Canonical>)jzi_),
                StatusElement = jzj_,
                ExperimentalElement = jzk_,
                DateElement = jzl_,
                PublisherElement = jzm_,
                Contact = new List<ContactDetail>((IEnumerable<ContactDetail>)jzn_),
                DescriptionElement = jzo_,
                UseContext = new List<UsageContext>((IEnumerable<UsageContext>)jzp_),
                Jurisdiction = new List<CodeableConcept>((IEnumerable<CodeableConcept>)jzq_),
                CopyrightElement = jzr_,
                ApprovalDateElement = jzs_,
                LastReviewDateElement = jzt_,
                EffectivePeriod = jzu_,
                Code = jzv_,
                Instance = new List<ResourceReference>((IEnumerable<ResourceReference>)jzw_),
                Applicability = new List<ChargeItemDefinition.ApplicabilityComponent>((IEnumerable<ChargeItemDefinition.ApplicabilityComponent>)jzx_),
                PropertyGroup = new List<ChargeItemDefinition.PropertyGroupComponent>((IEnumerable<ChargeItemDefinition.PropertyGroupComponent>)jzy_),
            };

            return jzz_;
        };
        IEnumerable<ChargeItemDefinition> izz_ = context.Operators.Select<ChargeItemDefinition, ChargeItemDefinition>((IEnumerable<ChargeItemDefinition>)izx_, izy_);
        IEnumerable<ChargeItemDefinition> jza_ = context.Operators.Distinct<ChargeItemDefinition>(izz_);
        ChargeItemDefinition jzb_ = context.Operators.SingletonFrom<ChargeItemDefinition>(jza_);

        return jzb_;
    }


    [CqlExpressionDefinition("ClaimResource")]
    public Claim ClaimResource(CqlContext context, Claim arg)
    {
        Claim[] kza_ = [
            arg,
        ];
        Claim kzb_(Claim a)
        {
            List<Identifier> kzf_ = a?.Identifier;
            Code<FinancialResourceStatusCodes> kzg_ = a?.StatusElement;
            CodeableConcept kzh_ = a?.Type;
            CodeableConcept kzi_ = a?.SubType;
            Code<ClaimUseCode> kzj_ = a?.UseElement;
            ResourceReference kzk_ = a?.Patient;
            Period kzl_ = a?.BillablePeriod;
            FhirDateTime kzm_ = a?.CreatedElement;
            ResourceReference kzn_ = a?.Enterer;
            ResourceReference kzo_ = a?.Insurer;
            ResourceReference kzp_ = a?.Provider;
            CodeableConcept kzq_ = a?.Priority;
            CodeableConcept kzr_ = a?.FundsReserve;
            List<Claim.RelatedClaimComponent> kzs_ = a?.Related;
            ResourceReference kzt_ = a?.Prescription;
            ResourceReference kzu_ = a?.OriginalPrescription;
            Claim.PayeeComponent kzv_ = a?.Payee;
            ResourceReference kzw_ = a?.Referral;
            ResourceReference kzx_ = a?.Facility;
            List<Claim.CareTeamComponent> kzy_ = a?.CareTeam;
            List<Claim.SupportingInformationComponent> kzz_ = a?.SupportingInfo;
            List<Claim.DiagnosisComponent> lza_ = a?.Diagnosis;
            List<Claim.ProcedureComponent> lzb_ = a?.Procedure;
            List<Claim.InsuranceComponent> lzc_ = a?.Insurance;
            Claim.AccidentComponent lzd_ = a?.Accident;
            List<Claim.ItemComponent> lze_ = a?.Item;
            Money lzf_ = a?.Total;
            Claim lzg_ = new Claim
            {
                Identifier = new List<Identifier>((IEnumerable<Identifier>)kzf_),
                StatusElement = kzg_,
                Type = kzh_,
                SubType = kzi_,
                UseElement = kzj_,
                Patient = kzk_,
                BillablePeriod = kzl_,
                CreatedElement = kzm_,
                Enterer = kzn_,
                Insurer = kzo_,
                Provider = kzp_,
                Priority = kzq_,
                FundsReserve = kzr_,
                Related = new List<Claim.RelatedClaimComponent>((IEnumerable<Claim.RelatedClaimComponent>)kzs_),
                Prescription = kzt_,
                OriginalPrescription = kzu_,
                Payee = kzv_,
                Referral = kzw_,
                Facility = kzx_,
                CareTeam = new List<Claim.CareTeamComponent>((IEnumerable<Claim.CareTeamComponent>)kzy_),
                SupportingInfo = new List<Claim.SupportingInformationComponent>((IEnumerable<Claim.SupportingInformationComponent>)kzz_),
                Diagnosis = new List<Claim.DiagnosisComponent>((IEnumerable<Claim.DiagnosisComponent>)lza_),
                Procedure = new List<Claim.ProcedureComponent>((IEnumerable<Claim.ProcedureComponent>)lzb_),
                Insurance = new List<Claim.InsuranceComponent>((IEnumerable<Claim.InsuranceComponent>)lzc_),
                Accident = lzd_,
                Item = new List<Claim.ItemComponent>((IEnumerable<Claim.ItemComponent>)lze_),
                Total = lzf_,
            };

            return lzg_;
        };
        IEnumerable<Claim> kzc_ = context.Operators.Select<Claim, Claim>((IEnumerable<Claim>)kza_, kzb_);
        IEnumerable<Claim> kzd_ = context.Operators.Distinct<Claim>(kzc_);
        Claim kze_ = context.Operators.SingletonFrom<Claim>(kzd_);

        return kze_;
    }


    [CqlExpressionDefinition("ClaimResponseResource")]
    public ClaimResponse ClaimResponseResource(CqlContext context, ClaimResponse arg)
    {
        ClaimResponse[] lzh_ = [
            arg,
        ];
        ClaimResponse lzi_(ClaimResponse a)
        {
            List<Identifier> lzm_ = a?.Identifier;
            Code<FinancialResourceStatusCodes> lzn_ = a?.StatusElement;
            CodeableConcept lzo_ = a?.Type;
            CodeableConcept lzp_ = a?.SubType;
            Code<ClaimUseCode> lzq_ = a?.UseElement;
            ResourceReference lzr_ = a?.Patient;
            FhirDateTime lzs_ = a?.CreatedElement;
            ResourceReference lzt_ = a?.Insurer;
            ResourceReference lzu_ = a?.Requestor;
            ResourceReference lzv_ = a?.Request;
            Code<ClaimProcessingCodes> lzw_ = a?.OutcomeElement;
            FhirString lzx_ = a?.DispositionElement;
            FhirString lzy_ = a?.PreAuthRefElement;
            Period lzz_ = a?.PreAuthPeriod;
            CodeableConcept mza_ = a?.PayeeType;
            List<ClaimResponse.ItemComponent> mzb_ = a?.Item;
            List<ClaimResponse.AddedItemComponent> mzc_ = a?.AddItem;
            List<ClaimResponse.AdjudicationComponent> mzd_ = a?.Adjudication;
            List<ClaimResponse.TotalComponent> mze_ = a?.Total;
            ClaimResponse.PaymentComponent mzf_ = a?.Payment;
            CodeableConcept mzg_ = a?.FundsReserve;
            CodeableConcept mzh_ = a?.FormCode;
            Attachment mzi_ = a?.Form;
            List<ClaimResponse.NoteComponent> mzj_ = a?.ProcessNote;
            List<ResourceReference> mzk_ = a?.CommunicationRequest;
            List<ClaimResponse.InsuranceComponent> mzl_ = a?.Insurance;
            List<ClaimResponse.ErrorComponent> mzm_ = a?.Error;
            ClaimResponse mzn_ = new ClaimResponse
            {
                Identifier = new List<Identifier>((IEnumerable<Identifier>)lzm_),
                StatusElement = lzn_,
                Type = lzo_,
                SubType = lzp_,
                UseElement = lzq_,
                Patient = lzr_,
                CreatedElement = lzs_,
                Insurer = lzt_,
                Requestor = lzu_,
                Request = lzv_,
                OutcomeElement = lzw_,
                DispositionElement = lzx_,
                PreAuthRefElement = lzy_,
                PreAuthPeriod = lzz_,
                PayeeType = mza_,
                Item = new List<ClaimResponse.ItemComponent>((IEnumerable<ClaimResponse.ItemComponent>)mzb_),
                AddItem = new List<ClaimResponse.AddedItemComponent>((IEnumerable<ClaimResponse.AddedItemComponent>)mzc_),
                Adjudication = new List<ClaimResponse.AdjudicationComponent>((IEnumerable<ClaimResponse.AdjudicationComponent>)mzd_),
                Total = new List<ClaimResponse.TotalComponent>((IEnumerable<ClaimResponse.TotalComponent>)mze_),
                Payment = mzf_,
                FundsReserve = mzg_,
                FormCode = mzh_,
                Form = mzi_,
                ProcessNote = new List<ClaimResponse.NoteComponent>((IEnumerable<ClaimResponse.NoteComponent>)mzj_),
                CommunicationRequest = new List<ResourceReference>((IEnumerable<ResourceReference>)mzk_),
                Insurance = new List<ClaimResponse.InsuranceComponent>((IEnumerable<ClaimResponse.InsuranceComponent>)mzl_),
                Error = new List<ClaimResponse.ErrorComponent>((IEnumerable<ClaimResponse.ErrorComponent>)mzm_),
            };

            return mzn_;
        };
        IEnumerable<ClaimResponse> lzj_ = context.Operators.Select<ClaimResponse, ClaimResponse>((IEnumerable<ClaimResponse>)lzh_, lzi_);
        IEnumerable<ClaimResponse> lzk_ = context.Operators.Distinct<ClaimResponse>(lzj_);
        ClaimResponse lzl_ = context.Operators.SingletonFrom<ClaimResponse>(lzk_);

        return lzl_;
    }


    [CqlExpressionDefinition("ClinicalImpressionResource")]
    public ClinicalImpression ClinicalImpressionResource(CqlContext context, ClinicalImpression arg)
    {
        ClinicalImpression[] mzo_ = [
            arg,
        ];
        ClinicalImpression mzp_(ClinicalImpression a)
        {
            List<Identifier> mzt_ = a?.Identifier;
            Code<ClinicalImpression.ClinicalImpressionStatus> mzu_ = a?.StatusElement;
            CodeableConcept mzv_ = a?.StatusReason;
            CodeableConcept mzw_ = a?.Code;
            FhirString mzx_ = a?.DescriptionElement;
            ResourceReference mzy_ = a?.Subject;
            ResourceReference mzz_ = a?.Encounter;
            DataType nza_ = a?.Effective;
            FhirDateTime nzb_ = a?.DateElement;
            ResourceReference nzc_ = a?.Assessor;
            ResourceReference nzd_ = a?.Previous;
            List<ResourceReference> nze_ = a?.Problem;
            List<ClinicalImpression.InvestigationComponent> nzf_ = a?.Investigation;
            List<FhirUri> nzg_ = a?.ProtocolElement;
            FhirString nzh_ = a?.SummaryElement;
            List<ClinicalImpression.FindingComponent> nzi_ = a?.Finding;
            List<CodeableConcept> nzj_ = a?.PrognosisCodeableConcept;
            List<ResourceReference> nzk_ = a?.PrognosisReference;
            List<ResourceReference> nzl_ = a?.SupportingInfo;
            List<Annotation> nzm_ = a?.Note;
            ClinicalImpression nzn_ = new ClinicalImpression
            {
                Identifier = new List<Identifier>((IEnumerable<Identifier>)mzt_),
                StatusElement = mzu_,
                StatusReason = mzv_,
                Code = mzw_,
                DescriptionElement = mzx_,
                Subject = mzy_,
                Encounter = mzz_,
                Effective = (DataType)nza_,
                DateElement = nzb_,
                Assessor = nzc_,
                Previous = nzd_,
                Problem = new List<ResourceReference>((IEnumerable<ResourceReference>)nze_),
                Investigation = new List<ClinicalImpression.InvestigationComponent>((IEnumerable<ClinicalImpression.InvestigationComponent>)nzf_),
                ProtocolElement = new List<FhirUri>((IEnumerable<FhirUri>)nzg_),
                SummaryElement = nzh_,
                Finding = new List<ClinicalImpression.FindingComponent>((IEnumerable<ClinicalImpression.FindingComponent>)nzi_),
                PrognosisCodeableConcept = new List<CodeableConcept>((IEnumerable<CodeableConcept>)nzj_),
                PrognosisReference = new List<ResourceReference>((IEnumerable<ResourceReference>)nzk_),
                SupportingInfo = new List<ResourceReference>((IEnumerable<ResourceReference>)nzl_),
                Note = new List<Annotation>((IEnumerable<Annotation>)nzm_),
            };

            return nzn_;
        };
        IEnumerable<ClinicalImpression> mzq_ = context.Operators.Select<ClinicalImpression, ClinicalImpression>((IEnumerable<ClinicalImpression>)mzo_, mzp_);
        IEnumerable<ClinicalImpression> mzr_ = context.Operators.Distinct<ClinicalImpression>(mzq_);
        ClinicalImpression mzs_ = context.Operators.SingletonFrom<ClinicalImpression>(mzr_);

        return mzs_;
    }


    [CqlExpressionDefinition("CodeSystemResource")]
    public CodeSystem CodeSystemResource(CqlContext context, CodeSystem arg)
    {
        CodeSystem[] nzo_ = [
            arg,
        ];
        CodeSystem nzp_(CodeSystem a)
        {
            FhirUri nzt_ = a?.UrlElement;
            List<Identifier> nzu_ = a?.Identifier;
            FhirString nzv_ = a?.VersionElement;
            FhirString nzw_ = a?.NameElement;
            FhirString nzx_ = a?.TitleElement;
            Code<PublicationStatus> nzy_ = a?.StatusElement;
            FhirBoolean nzz_ = a?.ExperimentalElement;
            FhirDateTime oza_ = a?.DateElement;
            FhirString ozb_ = a?.PublisherElement;
            List<ContactDetail> ozc_ = a?.Contact;
            Markdown ozd_ = a?.DescriptionElement;
            List<UsageContext> oze_ = a?.UseContext;
            List<CodeableConcept> ozf_ = a?.Jurisdiction;
            Markdown ozg_ = a?.PurposeElement;
            Markdown ozh_ = a?.CopyrightElement;
            FhirBoolean ozi_ = a?.CaseSensitiveElement;
            Canonical ozj_ = a?.ValueSetElement;
            Code<CodeSystem.CodeSystemHierarchyMeaning> ozk_ = a?.HierarchyMeaningElement;
            FhirBoolean ozl_ = a?.CompositionalElement;
            FhirBoolean ozm_ = a?.VersionNeededElement;
            Code<CodeSystemContentMode> ozn_ = a?.ContentElement;
            Canonical ozo_ = a?.SupplementsElement;
            UnsignedInt ozp_ = a?.CountElement;
            Integer ozq_ = context.Operators.Convert<Integer>(ozp_);
            UnsignedInt ozr_ = context.Operators.Convert<UnsignedInt>(ozq_);
            List<CodeSystem.FilterComponent> ozs_ = a?.Filter;
            List<CodeSystem.PropertyComponent> ozt_ = a?.Property;
            List<CodeSystem.ConceptDefinitionComponent> ozu_ = a?.Concept;
            CodeSystem ozv_ = new CodeSystem
            {
                UrlElement = nzt_,
                Identifier = new List<Identifier>((IEnumerable<Identifier>)nzu_),
                VersionElement = nzv_,
                NameElement = nzw_,
                TitleElement = nzx_,
                StatusElement = nzy_,
                ExperimentalElement = nzz_,
                DateElement = oza_,
                PublisherElement = ozb_,
                Contact = new List<ContactDetail>((IEnumerable<ContactDetail>)ozc_),
                DescriptionElement = ozd_,
                UseContext = new List<UsageContext>((IEnumerable<UsageContext>)oze_),
                Jurisdiction = new List<CodeableConcept>((IEnumerable<CodeableConcept>)ozf_),
                PurposeElement = ozg_,
                CopyrightElement = ozh_,
                CaseSensitiveElement = ozi_,
                ValueSetElement = ozj_,
                HierarchyMeaningElement = ozk_,
                CompositionalElement = ozl_,
                VersionNeededElement = ozm_,
                ContentElement = ozn_,
                SupplementsElement = ozo_,
                CountElement = ozr_,
                Filter = new List<CodeSystem.FilterComponent>((IEnumerable<CodeSystem.FilterComponent>)ozs_),
                Property = new List<CodeSystem.PropertyComponent>((IEnumerable<CodeSystem.PropertyComponent>)ozt_),
                Concept = new List<CodeSystem.ConceptDefinitionComponent>((IEnumerable<CodeSystem.ConceptDefinitionComponent>)ozu_),
            };

            return ozv_;
        };
        IEnumerable<CodeSystem> nzq_ = context.Operators.Select<CodeSystem, CodeSystem>((IEnumerable<CodeSystem>)nzo_, nzp_);
        IEnumerable<CodeSystem> nzr_ = context.Operators.Distinct<CodeSystem>(nzq_);
        CodeSystem nzs_ = context.Operators.SingletonFrom<CodeSystem>(nzr_);

        return nzs_;
    }


    [CqlExpressionDefinition("CommunicationResource")]
    public Communication CommunicationResource(CqlContext context, Communication arg)
    {
        Communication[] ozw_ = [
            arg,
        ];
        Communication ozx_(Communication a)
        {
            List<Identifier> pzb_ = a?.Identifier;
            List<Canonical> pzc_ = a?.InstantiatesCanonicalElement;
            List<FhirUri> pzd_ = a?.InstantiatesUriElement;
            List<ResourceReference> pze_ = a?.BasedOn;
            List<ResourceReference> pzf_ = a?.PartOf;
            List<ResourceReference> pzg_ = a?.InResponseTo;
            Code<EventStatus> pzh_ = a?.StatusElement;
            CodeableConcept pzi_ = a?.StatusReason;
            List<CodeableConcept> pzj_ = a?.Category;
            Code<RequestPriority> pzk_ = a?.PriorityElement;
            List<CodeableConcept> pzl_ = a?.Medium;
            ResourceReference pzm_ = a?.Subject;
            CodeableConcept pzn_ = a?.Topic;
            List<ResourceReference> pzo_ = a?.About;
            ResourceReference pzp_ = a?.Encounter;
            FhirDateTime pzq_ = a?.SentElement;
            FhirDateTime pzr_ = a?.ReceivedElement;
            List<ResourceReference> pzs_ = a?.Recipient;
            ResourceReference pzt_ = a?.Sender;
            List<CodeableConcept> pzu_ = a?.ReasonCode;
            List<ResourceReference> pzv_ = a?.ReasonReference;
            List<Communication.PayloadComponent> pzw_ = a?.Payload;
            List<Annotation> pzx_ = a?.Note;
            Communication pzy_ = new Communication
            {
                Identifier = new List<Identifier>((IEnumerable<Identifier>)pzb_),
                InstantiatesCanonicalElement = new List<Canonical>((IEnumerable<Canonical>)pzc_),
                InstantiatesUriElement = new List<FhirUri>((IEnumerable<FhirUri>)pzd_),
                BasedOn = new List<ResourceReference>((IEnumerable<ResourceReference>)pze_),
                PartOf = new List<ResourceReference>((IEnumerable<ResourceReference>)pzf_),
                InResponseTo = new List<ResourceReference>((IEnumerable<ResourceReference>)pzg_),
                StatusElement = pzh_,
                StatusReason = pzi_,
                Category = new List<CodeableConcept>((IEnumerable<CodeableConcept>)pzj_),
                PriorityElement = pzk_,
                Medium = new List<CodeableConcept>((IEnumerable<CodeableConcept>)pzl_),
                Subject = pzm_,
                Topic = pzn_,
                About = new List<ResourceReference>((IEnumerable<ResourceReference>)pzo_),
                Encounter = pzp_,
                SentElement = pzq_,
                ReceivedElement = pzr_,
                Recipient = new List<ResourceReference>((IEnumerable<ResourceReference>)pzs_),
                Sender = pzt_,
                ReasonCode = new List<CodeableConcept>((IEnumerable<CodeableConcept>)pzu_),
                ReasonReference = new List<ResourceReference>((IEnumerable<ResourceReference>)pzv_),
                Payload = new List<Communication.PayloadComponent>((IEnumerable<Communication.PayloadComponent>)pzw_),
                Note = new List<Annotation>((IEnumerable<Annotation>)pzx_),
            };

            return pzy_;
        };
        IEnumerable<Communication> ozy_ = context.Operators.Select<Communication, Communication>((IEnumerable<Communication>)ozw_, ozx_);
        IEnumerable<Communication> ozz_ = context.Operators.Distinct<Communication>(ozy_);
        Communication pza_ = context.Operators.SingletonFrom<Communication>(ozz_);

        return pza_;
    }


    [CqlExpressionDefinition("CommunicationRequestResource")]
    public CommunicationRequest CommunicationRequestResource(CqlContext context, CommunicationRequest arg)
    {
        CommunicationRequest[] pzz_ = [
            arg,
        ];
        CommunicationRequest qza_(CommunicationRequest a)
        {
            List<Identifier> qze_ = a?.Identifier;
            List<ResourceReference> qzf_ = a?.BasedOn;
            List<ResourceReference> qzg_ = a?.Replaces;
            Identifier qzh_ = a?.GroupIdentifier;
            Code<RequestStatus> qzi_ = a?.StatusElement;
            CodeableConcept qzj_ = a?.StatusReason;
            List<CodeableConcept> qzk_ = a?.Category;
            Code<RequestPriority> qzl_ = a?.PriorityElement;
            FhirBoolean qzm_ = a?.DoNotPerformElement;
            List<CodeableConcept> qzn_ = a?.Medium;
            ResourceReference qzo_ = a?.Subject;
            List<ResourceReference> qzp_ = a?.About;
            ResourceReference qzq_ = a?.Encounter;
            List<CommunicationRequest.PayloadComponent> qzr_ = a?.Payload;
            DataType qzs_ = a?.Occurrence;
            FhirDateTime qzt_ = a?.AuthoredOnElement;
            ResourceReference qzu_ = a?.Requester;
            List<ResourceReference> qzv_ = a?.Recipient;
            ResourceReference qzw_ = a?.Sender;
            List<CodeableConcept> qzx_ = a?.ReasonCode;
            List<ResourceReference> qzy_ = a?.ReasonReference;
            List<Annotation> qzz_ = a?.Note;
            CommunicationRequest rza_ = new CommunicationRequest
            {
                Identifier = new List<Identifier>((IEnumerable<Identifier>)qze_),
                BasedOn = new List<ResourceReference>((IEnumerable<ResourceReference>)qzf_),
                Replaces = new List<ResourceReference>((IEnumerable<ResourceReference>)qzg_),
                GroupIdentifier = qzh_,
                StatusElement = qzi_,
                StatusReason = qzj_,
                Category = new List<CodeableConcept>((IEnumerable<CodeableConcept>)qzk_),
                PriorityElement = qzl_,
                DoNotPerformElement = qzm_,
                Medium = new List<CodeableConcept>((IEnumerable<CodeableConcept>)qzn_),
                Subject = qzo_,
                About = new List<ResourceReference>((IEnumerable<ResourceReference>)qzp_),
                Encounter = qzq_,
                Payload = new List<CommunicationRequest.PayloadComponent>((IEnumerable<CommunicationRequest.PayloadComponent>)qzr_),
                Occurrence = (DataType)qzs_,
                AuthoredOnElement = qzt_,
                Requester = qzu_,
                Recipient = new List<ResourceReference>((IEnumerable<ResourceReference>)qzv_),
                Sender = qzw_,
                ReasonCode = new List<CodeableConcept>((IEnumerable<CodeableConcept>)qzx_),
                ReasonReference = new List<ResourceReference>((IEnumerable<ResourceReference>)qzy_),
                Note = new List<Annotation>((IEnumerable<Annotation>)qzz_),
            };

            return rza_;
        };
        IEnumerable<CommunicationRequest> qzb_ = context.Operators.Select<CommunicationRequest, CommunicationRequest>((IEnumerable<CommunicationRequest>)pzz_, qza_);
        IEnumerable<CommunicationRequest> qzc_ = context.Operators.Distinct<CommunicationRequest>(qzb_);
        CommunicationRequest qzd_ = context.Operators.SingletonFrom<CommunicationRequest>(qzc_);

        return qzd_;
    }


    [CqlExpressionDefinition("CompositionResource")]
    public Composition CompositionResource(CqlContext context, Composition arg)
    {
        Composition[] rzb_ = [
            arg,
        ];
        Composition rzc_(Composition a)
        {
            Identifier rzg_ = a?.Identifier;
            Code<CompositionStatus> rzh_ = a?.StatusElement;
            CodeableConcept rzi_ = a?.Type;
            List<CodeableConcept> rzj_ = a?.Category;
            ResourceReference rzk_ = a?.Subject;
            ResourceReference rzl_ = a?.Encounter;
            FhirDateTime rzm_ = a?.DateElement;
            List<ResourceReference> rzn_ = a?.Author;
            FhirString rzo_ = a?.TitleElement;
            Code<Composition.V3ConfidentialityClassification> rzp_ = a?.ConfidentialityElement;
            List<Composition.AttesterComponent> rzq_ = a?.Attester;
            ResourceReference rzr_ = a?.Custodian;
            List<Composition.RelatesToComponent> rzs_ = a?.RelatesTo;
            List<Composition.EventComponent> rzt_ = a?.Event;
            List<Composition.SectionComponent> rzu_ = a?.Section;
            Composition rzv_ = new Composition
            {
                Identifier = rzg_,
                StatusElement = rzh_,
                Type = rzi_,
                Category = new List<CodeableConcept>((IEnumerable<CodeableConcept>)rzj_),
                Subject = rzk_,
                Encounter = rzl_,
                DateElement = rzm_,
                Author = new List<ResourceReference>((IEnumerable<ResourceReference>)rzn_),
                TitleElement = rzo_,
                ConfidentialityElement = rzp_,
                Attester = new List<Composition.AttesterComponent>((IEnumerable<Composition.AttesterComponent>)rzq_),
                Custodian = rzr_,
                RelatesTo = new List<Composition.RelatesToComponent>((IEnumerable<Composition.RelatesToComponent>)rzs_),
                Event = new List<Composition.EventComponent>((IEnumerable<Composition.EventComponent>)rzt_),
                Section = new List<Composition.SectionComponent>((IEnumerable<Composition.SectionComponent>)rzu_),
            };

            return rzv_;
        };
        IEnumerable<Composition> rzd_ = context.Operators.Select<Composition, Composition>((IEnumerable<Composition>)rzb_, rzc_);
        IEnumerable<Composition> rze_ = context.Operators.Distinct<Composition>(rzd_);
        Composition rzf_ = context.Operators.SingletonFrom<Composition>(rze_);

        return rzf_;
    }


    [CqlExpressionDefinition("ConceptMapResource")]
    public ConceptMap ConceptMapResource(CqlContext context, ConceptMap arg)
    {
        ConceptMap[] rzw_ = [
            arg,
        ];
        ConceptMap rzx_(ConceptMap a)
        {
            FhirUri szb_ = a?.UrlElement;
            Identifier szc_ = a?.Identifier;
            FhirString szd_ = a?.VersionElement;
            FhirString sze_ = a?.NameElement;
            FhirString szf_ = a?.TitleElement;
            Code<PublicationStatus> szg_ = a?.StatusElement;
            FhirBoolean szh_ = a?.ExperimentalElement;
            FhirDateTime szi_ = a?.DateElement;
            FhirString szj_ = a?.PublisherElement;
            List<ContactDetail> szk_ = a?.Contact;
            Markdown szl_ = a?.DescriptionElement;
            List<UsageContext> szm_ = a?.UseContext;
            List<CodeableConcept> szn_ = a?.Jurisdiction;
            Markdown szo_ = a?.PurposeElement;
            Markdown szp_ = a?.CopyrightElement;
            DataType szq_ = a?.Source;
            DataType szr_ = a?.Target;
            List<ConceptMap.GroupComponent> szs_ = a?.Group;
            ConceptMap szt_ = new ConceptMap
            {
                UrlElement = szb_,
                Identifier = szc_,
                VersionElement = szd_,
                NameElement = sze_,
                TitleElement = szf_,
                StatusElement = szg_,
                ExperimentalElement = szh_,
                DateElement = szi_,
                PublisherElement = szj_,
                Contact = new List<ContactDetail>((IEnumerable<ContactDetail>)szk_),
                DescriptionElement = szl_,
                UseContext = new List<UsageContext>((IEnumerable<UsageContext>)szm_),
                Jurisdiction = new List<CodeableConcept>((IEnumerable<CodeableConcept>)szn_),
                PurposeElement = szo_,
                CopyrightElement = szp_,
                Source = (DataType)szq_,
                Target = (DataType)szr_,
                Group = new List<ConceptMap.GroupComponent>((IEnumerable<ConceptMap.GroupComponent>)szs_),
            };

            return szt_;
        };
        IEnumerable<ConceptMap> rzy_ = context.Operators.Select<ConceptMap, ConceptMap>((IEnumerable<ConceptMap>)rzw_, rzx_);
        IEnumerable<ConceptMap> rzz_ = context.Operators.Distinct<ConceptMap>(rzy_);
        ConceptMap sza_ = context.Operators.SingletonFrom<ConceptMap>(rzz_);

        return sza_;
    }


    [CqlExpressionDefinition("ConditionResource")]
    public Condition ConditionResource(CqlContext context, Condition arg)
    {
        Condition[] szu_ = [
            arg,
        ];
        Condition szv_(Condition a)
        {
            List<Identifier> szz_ = a?.Identifier;
            CodeableConcept tza_ = a?.ClinicalStatus;
            CodeableConcept tzb_ = a?.VerificationStatus;
            List<CodeableConcept> tzc_ = a?.Category;
            CodeableConcept tzd_ = a?.Severity;
            CodeableConcept tze_ = a?.Code;
            List<CodeableConcept> tzf_ = a?.BodySite;
            ResourceReference tzg_ = a?.Subject;
            ResourceReference tzh_ = a?.Encounter;
            DataType tzi_ = a?.Onset;
            DataType tzj_ = a?.Abatement;
            FhirDateTime tzk_ = a?.RecordedDateElement;
            ResourceReference tzl_ = a?.Recorder;
            ResourceReference tzm_ = a?.Asserter;
            List<Condition.StageComponent> tzn_ = a?.Stage;
            List<Condition.EvidenceComponent> tzo_ = a?.Evidence;
            List<Annotation> tzp_ = a?.Note;
            Condition tzq_ = new Condition
            {
                Identifier = new List<Identifier>((IEnumerable<Identifier>)szz_),
                ClinicalStatus = tza_,
                VerificationStatus = tzb_,
                Category = new List<CodeableConcept>((IEnumerable<CodeableConcept>)tzc_),
                Severity = tzd_,
                Code = tze_,
                BodySite = new List<CodeableConcept>((IEnumerable<CodeableConcept>)tzf_),
                Subject = tzg_,
                Encounter = tzh_,
                Onset = (DataType)tzi_,
                Abatement = (DataType)tzj_,
                RecordedDateElement = tzk_,
                Recorder = tzl_,
                Asserter = tzm_,
                Stage = new List<Condition.StageComponent>((IEnumerable<Condition.StageComponent>)tzn_),
                Evidence = new List<Condition.EvidenceComponent>((IEnumerable<Condition.EvidenceComponent>)tzo_),
                Note = new List<Annotation>((IEnumerable<Annotation>)tzp_),
            };

            return tzq_;
        };
        IEnumerable<Condition> szw_ = context.Operators.Select<Condition, Condition>((IEnumerable<Condition>)szu_, szv_);
        IEnumerable<Condition> szx_ = context.Operators.Distinct<Condition>(szw_);
        Condition szy_ = context.Operators.SingletonFrom<Condition>(szx_);

        return szy_;
    }


    [CqlExpressionDefinition("ConsentResource")]
    public Consent ConsentResource(CqlContext context, Consent arg)
    {
        Consent[] tzr_ = [
            arg,
        ];
        Consent tzs_(Consent a)
        {
            List<Identifier> tzw_ = a?.Identifier;
            Code<Consent.ConsentState> tzx_ = a?.StatusElement;
            CodeableConcept tzy_ = a?.Scope;
            List<CodeableConcept> tzz_ = a?.Category;
            ResourceReference uza_ = a?.Patient;
            FhirDateTime uzb_ = a?.DateTimeElement;
            List<ResourceReference> uzc_ = a?.Performer;
            List<ResourceReference> uzd_ = a?.Organization;
            DataType uze_ = a?.Source;
            List<Consent.PolicyComponent> uzf_ = a?.Policy;
            CodeableConcept uzg_ = a?.PolicyRule;
            List<Consent.VerificationComponent> uzh_ = a?.Verification;
            Consent.provisionComponent uzi_ = a?.Provision;
            Consent uzj_ = new Consent
            {
                Identifier = new List<Identifier>((IEnumerable<Identifier>)tzw_),
                StatusElement = tzx_,
                Scope = tzy_,
                Category = new List<CodeableConcept>((IEnumerable<CodeableConcept>)tzz_),
                Patient = uza_,
                DateTimeElement = uzb_,
                Performer = new List<ResourceReference>((IEnumerable<ResourceReference>)uzc_),
                Organization = new List<ResourceReference>((IEnumerable<ResourceReference>)uzd_),
                Source = (DataType)uze_,
                Policy = new List<Consent.PolicyComponent>((IEnumerable<Consent.PolicyComponent>)uzf_),
                PolicyRule = uzg_,
                Verification = new List<Consent.VerificationComponent>((IEnumerable<Consent.VerificationComponent>)uzh_),
                Provision = uzi_,
            };

            return uzj_;
        };
        IEnumerable<Consent> tzt_ = context.Operators.Select<Consent, Consent>((IEnumerable<Consent>)tzr_, tzs_);
        IEnumerable<Consent> tzu_ = context.Operators.Distinct<Consent>(tzt_);
        Consent tzv_ = context.Operators.SingletonFrom<Consent>(tzu_);

        return tzv_;
    }


    [CqlExpressionDefinition("ContractResource")]
    public Contract ContractResource(CqlContext context, Contract arg)
    {
        Contract[] uzk_ = [
            arg,
        ];
        Contract uzl_(Contract a)
        {
            List<Identifier> uzp_ = a?.Identifier;
            FhirUri uzq_ = a?.UrlElement;
            FhirString uzr_ = a?.VersionElement;
            Code<Contract.ContractResourceStatusCodes> uzs_ = a?.StatusElement;
            CodeableConcept uzt_ = a?.LegalState;
            ResourceReference uzu_ = a?.InstantiatesCanonical;
            FhirUri uzv_ = a?.InstantiatesUriElement;
            CodeableConcept uzw_ = a?.ContentDerivative;
            FhirDateTime uzx_ = a?.IssuedElement;
            Period uzy_ = a?.Applies;
            CodeableConcept uzz_ = a?.ExpirationType;
            List<ResourceReference> vza_ = a?.Subject;
            List<ResourceReference> vzb_ = a?.Authority;
            List<ResourceReference> vzc_ = a?.Domain;
            List<ResourceReference> vzd_ = a?.Site;
            FhirString vze_ = a?.NameElement;
            FhirString vzf_ = a?.TitleElement;
            FhirString vzg_ = a?.SubtitleElement;
            List<FhirString> vzh_ = a?.AliasElement;
            ResourceReference vzi_ = a?.Author;
            CodeableConcept vzj_ = a?.Scope;
            DataType vzk_ = a?.Topic;
            CodeableConcept vzl_ = a?.Type;
            List<CodeableConcept> vzm_ = a?.SubType;
            Contract.ContentDefinitionComponent vzn_ = a?.ContentDefinition;
            List<Contract.TermComponent> vzo_ = a?.Term;
            List<ResourceReference> vzp_ = a?.SupportingInfo;
            List<ResourceReference> vzq_ = a?.RelevantHistory;
            List<Contract.SignatoryComponent> vzr_ = a?.Signer;
            List<Contract.FriendlyLanguageComponent> vzs_ = a?.Friendly;
            List<Contract.LegalLanguageComponent> vzt_ = a?.Legal;
            List<Contract.ComputableLanguageComponent> vzu_ = a?.Rule;
            DataType vzv_ = a?.LegallyBinding;
            Contract vzw_ = new Contract
            {
                Identifier = new List<Identifier>((IEnumerable<Identifier>)uzp_),
                UrlElement = uzq_,
                VersionElement = uzr_,
                StatusElement = uzs_,
                LegalState = uzt_,
                InstantiatesCanonical = uzu_,
                InstantiatesUriElement = uzv_,
                ContentDerivative = uzw_,
                IssuedElement = uzx_,
                Applies = uzy_,
                ExpirationType = uzz_,
                Subject = new List<ResourceReference>((IEnumerable<ResourceReference>)vza_),
                Authority = new List<ResourceReference>((IEnumerable<ResourceReference>)vzb_),
                Domain = new List<ResourceReference>((IEnumerable<ResourceReference>)vzc_),
                Site = new List<ResourceReference>((IEnumerable<ResourceReference>)vzd_),
                NameElement = vze_,
                TitleElement = vzf_,
                SubtitleElement = vzg_,
                AliasElement = new List<FhirString>((IEnumerable<FhirString>)vzh_),
                Author = vzi_,
                Scope = vzj_,
                Topic = (DataType)vzk_,
                Type = vzl_,
                SubType = new List<CodeableConcept>((IEnumerable<CodeableConcept>)vzm_),
                ContentDefinition = vzn_,
                Term = new List<Contract.TermComponent>((IEnumerable<Contract.TermComponent>)vzo_),
                SupportingInfo = new List<ResourceReference>((IEnumerable<ResourceReference>)vzp_),
                RelevantHistory = new List<ResourceReference>((IEnumerable<ResourceReference>)vzq_),
                Signer = new List<Contract.SignatoryComponent>((IEnumerable<Contract.SignatoryComponent>)vzr_),
                Friendly = new List<Contract.FriendlyLanguageComponent>((IEnumerable<Contract.FriendlyLanguageComponent>)vzs_),
                Legal = new List<Contract.LegalLanguageComponent>((IEnumerable<Contract.LegalLanguageComponent>)vzt_),
                Rule = new List<Contract.ComputableLanguageComponent>((IEnumerable<Contract.ComputableLanguageComponent>)vzu_),
                LegallyBinding = (DataType)vzv_,
            };

            return vzw_;
        };
        IEnumerable<Contract> uzm_ = context.Operators.Select<Contract, Contract>((IEnumerable<Contract>)uzk_, uzl_);
        IEnumerable<Contract> uzn_ = context.Operators.Distinct<Contract>(uzm_);
        Contract uzo_ = context.Operators.SingletonFrom<Contract>(uzn_);

        return uzo_;
    }


    [CqlExpressionDefinition("CoverageResource")]
    public Coverage CoverageResource(CqlContext context, Coverage arg)
    {
        Coverage[] vzx_ = [
            arg,
        ];
        Coverage vzy_(Coverage a)
        {
            List<Identifier> wzc_ = a?.Identifier;
            Code<FinancialResourceStatusCodes> wzd_ = a?.StatusElement;
            CodeableConcept wze_ = a?.Type;
            ResourceReference wzf_ = a?.PolicyHolder;
            ResourceReference wzg_ = a?.Subscriber;
            FhirString wzh_ = a?.SubscriberIdElement;
            ResourceReference wzi_ = a?.Beneficiary;
            FhirString wzj_ = a?.DependentElement;
            CodeableConcept wzk_ = a?.Relationship;
            Period wzl_ = a?.Period;
            List<ResourceReference> wzm_ = a?.Payor;
            List<Coverage.ClassComponent> wzn_ = a?.Class;
            PositiveInt wzo_ = a?.OrderElement;
            Integer wzp_ = context.Operators.Convert<Integer>(wzo_);
            PositiveInt wzq_ = context.Operators.Convert<PositiveInt>(wzp_);
            FhirString wzr_ = a?.NetworkElement;
            List<Coverage.CostToBeneficiaryComponent> wzs_ = a?.CostToBeneficiary;
            FhirBoolean wzt_ = a?.SubrogationElement;
            List<ResourceReference> wzu_ = a?.Contract;
            Coverage wzv_ = new Coverage
            {
                Identifier = new List<Identifier>((IEnumerable<Identifier>)wzc_),
                StatusElement = wzd_,
                Type = wze_,
                PolicyHolder = wzf_,
                Subscriber = wzg_,
                SubscriberIdElement = wzh_,
                Beneficiary = wzi_,
                DependentElement = wzj_,
                Relationship = wzk_,
                Period = wzl_,
                Payor = new List<ResourceReference>((IEnumerable<ResourceReference>)wzm_),
                Class = new List<Coverage.ClassComponent>((IEnumerable<Coverage.ClassComponent>)wzn_),
                OrderElement = wzq_,
                NetworkElement = wzr_,
                CostToBeneficiary = new List<Coverage.CostToBeneficiaryComponent>((IEnumerable<Coverage.CostToBeneficiaryComponent>)wzs_),
                SubrogationElement = wzt_,
                Contract = new List<ResourceReference>((IEnumerable<ResourceReference>)wzu_),
            };

            return wzv_;
        };
        IEnumerable<Coverage> vzz_ = context.Operators.Select<Coverage, Coverage>((IEnumerable<Coverage>)vzx_, vzy_);
        IEnumerable<Coverage> wza_ = context.Operators.Distinct<Coverage>(vzz_);
        Coverage wzb_ = context.Operators.SingletonFrom<Coverage>(wza_);

        return wzb_;
    }


    [CqlExpressionDefinition("CoverageEligibilityRequestResource")]
    public CoverageEligibilityRequest CoverageEligibilityRequestResource(CqlContext context, CoverageEligibilityRequest arg)
    {
        CoverageEligibilityRequest[] wzw_ = [
            arg,
        ];
        CoverageEligibilityRequest wzx_(CoverageEligibilityRequest a)
        {
            List<Identifier> xzb_ = a?.Identifier;
            Code<FinancialResourceStatusCodes> xzc_ = a?.StatusElement;
            CodeableConcept xzd_ = a?.Priority;
            List<Code<CoverageEligibilityRequest.EligibilityRequestPurpose>> xze_ = a?.PurposeElement;
            ResourceReference xzf_ = a?.Patient;
            DataType xzg_ = a?.Serviced;
            FhirDateTime xzh_ = a?.CreatedElement;
            ResourceReference xzi_ = a?.Enterer;
            ResourceReference xzj_ = a?.Provider;
            ResourceReference xzk_ = a?.Insurer;
            ResourceReference xzl_ = a?.Facility;
            List<CoverageEligibilityRequest.SupportingInformationComponent> xzm_ = a?.SupportingInfo;
            List<CoverageEligibilityRequest.InsuranceComponent> xzn_ = a?.Insurance;
            List<CoverageEligibilityRequest.DetailsComponent> xzo_ = a?.Item;
            CoverageEligibilityRequest xzp_ = new CoverageEligibilityRequest
            {
                Identifier = new List<Identifier>((IEnumerable<Identifier>)xzb_),
                StatusElement = xzc_,
                Priority = xzd_,
                PurposeElement = new List<Code<CoverageEligibilityRequest.EligibilityRequestPurpose>>((IEnumerable<Code<CoverageEligibilityRequest.EligibilityRequestPurpose>>)xze_),
                Patient = xzf_,
                Serviced = (DataType)xzg_,
                CreatedElement = xzh_,
                Enterer = xzi_,
                Provider = xzj_,
                Insurer = xzk_,
                Facility = xzl_,
                SupportingInfo = new List<CoverageEligibilityRequest.SupportingInformationComponent>((IEnumerable<CoverageEligibilityRequest.SupportingInformationComponent>)xzm_),
                Insurance = new List<CoverageEligibilityRequest.InsuranceComponent>((IEnumerable<CoverageEligibilityRequest.InsuranceComponent>)xzn_),
                Item = new List<CoverageEligibilityRequest.DetailsComponent>((IEnumerable<CoverageEligibilityRequest.DetailsComponent>)xzo_),
            };

            return xzp_;
        };
        IEnumerable<CoverageEligibilityRequest> wzy_ = context.Operators.Select<CoverageEligibilityRequest, CoverageEligibilityRequest>((IEnumerable<CoverageEligibilityRequest>)wzw_, wzx_);
        IEnumerable<CoverageEligibilityRequest> wzz_ = context.Operators.Distinct<CoverageEligibilityRequest>(wzy_);
        CoverageEligibilityRequest xza_ = context.Operators.SingletonFrom<CoverageEligibilityRequest>(wzz_);

        return xza_;
    }


    [CqlExpressionDefinition("CoverageEligibilityResponseResource")]
    public CoverageEligibilityResponse CoverageEligibilityResponseResource(CqlContext context, CoverageEligibilityResponse arg)
    {
        CoverageEligibilityResponse[] xzq_ = [
            arg,
        ];
        CoverageEligibilityResponse xzr_(CoverageEligibilityResponse a)
        {
            List<Identifier> xzv_ = a?.Identifier;
            Code<FinancialResourceStatusCodes> xzw_ = a?.StatusElement;
            List<Code<CoverageEligibilityResponse.EligibilityResponsePurpose>> xzx_ = a?.PurposeElement;
            ResourceReference xzy_ = a?.Patient;
            DataType xzz_ = a?.Serviced;
            FhirDateTime yza_ = a?.CreatedElement;
            ResourceReference yzb_ = a?.Requestor;
            ResourceReference yzc_ = a?.Request;
            Code<ClaimProcessingCodes> yzd_ = a?.OutcomeElement;
            FhirString yze_ = a?.DispositionElement;
            ResourceReference yzf_ = a?.Insurer;
            List<CoverageEligibilityResponse.InsuranceComponent> yzg_ = a?.Insurance;
            FhirString yzh_ = a?.PreAuthRefElement;
            CodeableConcept yzi_ = a?.Form;
            List<CoverageEligibilityResponse.ErrorsComponent> yzj_ = a?.Error;
            CoverageEligibilityResponse yzk_ = new CoverageEligibilityResponse
            {
                Identifier = new List<Identifier>((IEnumerable<Identifier>)xzv_),
                StatusElement = xzw_,
                PurposeElement = new List<Code<CoverageEligibilityResponse.EligibilityResponsePurpose>>((IEnumerable<Code<CoverageEligibilityResponse.EligibilityResponsePurpose>>)xzx_),
                Patient = xzy_,
                Serviced = (DataType)xzz_,
                CreatedElement = yza_,
                Requestor = yzb_,
                Request = yzc_,
                OutcomeElement = yzd_,
                DispositionElement = yze_,
                Insurer = yzf_,
                Insurance = new List<CoverageEligibilityResponse.InsuranceComponent>((IEnumerable<CoverageEligibilityResponse.InsuranceComponent>)yzg_),
                PreAuthRefElement = yzh_,
                Form = yzi_,
                Error = new List<CoverageEligibilityResponse.ErrorsComponent>((IEnumerable<CoverageEligibilityResponse.ErrorsComponent>)yzj_),
            };

            return yzk_;
        };
        IEnumerable<CoverageEligibilityResponse> xzs_ = context.Operators.Select<CoverageEligibilityResponse, CoverageEligibilityResponse>((IEnumerable<CoverageEligibilityResponse>)xzq_, xzr_);
        IEnumerable<CoverageEligibilityResponse> xzt_ = context.Operators.Distinct<CoverageEligibilityResponse>(xzs_);
        CoverageEligibilityResponse xzu_ = context.Operators.SingletonFrom<CoverageEligibilityResponse>(xzt_);

        return xzu_;
    }


    [CqlExpressionDefinition("DetectedIssueResource")]
    public DetectedIssue DetectedIssueResource(CqlContext context, DetectedIssue arg)
    {
        DetectedIssue[] yzl_ = [
            arg,
        ];
        DetectedIssue yzm_(DetectedIssue a)
        {
            List<Identifier> yzq_ = a?.Identifier;
            Code<ObservationStatus> yzr_ = a?.StatusElement;
            CodeableConcept yzs_ = a?.Code;
            Code<DetectedIssue.DetectedIssueSeverity> yzt_ = a?.SeverityElement;
            ResourceReference yzu_ = a?.Patient;
            DataType yzv_ = a?.Identified;
            ResourceReference yzw_ = a?.Author;
            List<ResourceReference> yzx_ = a?.Implicated;
            List<DetectedIssue.EvidenceComponent> yzy_ = a?.Evidence;
            FhirString yzz_ = a?.DetailElement;
            FhirUri zza_ = a?.ReferenceElement;
            List<DetectedIssue.MitigationComponent> zzb_ = a?.Mitigation;
            DetectedIssue zzc_ = new DetectedIssue
            {
                Identifier = new List<Identifier>((IEnumerable<Identifier>)yzq_),
                StatusElement = yzr_,
                Code = yzs_,
                SeverityElement = yzt_,
                Patient = yzu_,
                Identified = (DataType)yzv_,
                Author = yzw_,
                Implicated = new List<ResourceReference>((IEnumerable<ResourceReference>)yzx_),
                Evidence = new List<DetectedIssue.EvidenceComponent>((IEnumerable<DetectedIssue.EvidenceComponent>)yzy_),
                DetailElement = yzz_,
                ReferenceElement = zza_,
                Mitigation = new List<DetectedIssue.MitigationComponent>((IEnumerable<DetectedIssue.MitigationComponent>)zzb_),
            };

            return zzc_;
        };
        IEnumerable<DetectedIssue> yzn_ = context.Operators.Select<DetectedIssue, DetectedIssue>((IEnumerable<DetectedIssue>)yzl_, yzm_);
        IEnumerable<DetectedIssue> yzo_ = context.Operators.Distinct<DetectedIssue>(yzn_);
        DetectedIssue yzp_ = context.Operators.SingletonFrom<DetectedIssue>(yzo_);

        return yzp_;
    }


    [CqlExpressionDefinition("DeviceResource")]
    public Device DeviceResource(CqlContext context, Device arg)
    {
        Device[] zzd_ = [
            arg,
        ];
        Device zze_(Device a)
        {
            List<Identifier> zzi_ = a?.Identifier;
            ResourceReference zzj_ = a?.Definition;
            List<Device.UdiCarrierComponent> zzk_ = a?.UdiCarrier;
            Code<Device.FHIRDeviceStatus> zzl_ = a?.StatusElement;
            List<CodeableConcept> zzm_ = a?.StatusReason;
            FhirString zzn_ = a?.DistinctIdentifierElement;
            FhirString zzo_ = a?.ManufacturerElement;
            FhirDateTime zzp_ = a?.ManufactureDateElement;
            FhirDateTime zzq_ = a?.ExpirationDateElement;
            FhirString zzr_ = a?.LotNumberElement;
            FhirString zzs_ = a?.SerialNumberElement;
            List<Device.DeviceNameComponent> zzt_ = a?.DeviceName;
            FhirString zzu_ = a?.ModelNumberElement;
            FhirString zzv_ = a?.PartNumberElement;
            CodeableConcept zzw_ = a?.Type;
            List<Device.SpecializationComponent> zzx_ = a?.Specialization;
            List<Device.VersionComponent> zzy_ = a?.Version;
            List<Device.PropertyComponent> zzz_ = a?.Property;
            ResourceReference azza_ = a?.Patient;
            ResourceReference azzb_ = a?.Owner;
            List<ContactPoint> azzc_ = a?.Contact;
            ResourceReference azzd_ = a?.Location;
            FhirUri azze_ = a?.UrlElement;
            List<Annotation> azzf_ = a?.Note;
            List<CodeableConcept> azzg_ = a?.Safety;
            ResourceReference azzh_ = a?.Parent;
            Device azzi_ = new Device
            {
                Identifier = new List<Identifier>((IEnumerable<Identifier>)zzi_),
                Definition = zzj_,
                UdiCarrier = new List<Device.UdiCarrierComponent>((IEnumerable<Device.UdiCarrierComponent>)zzk_),
                StatusElement = zzl_,
                StatusReason = new List<CodeableConcept>((IEnumerable<CodeableConcept>)zzm_),
                DistinctIdentifierElement = zzn_,
                ManufacturerElement = zzo_,
                ManufactureDateElement = zzp_,
                ExpirationDateElement = zzq_,
                LotNumberElement = zzr_,
                SerialNumberElement = zzs_,
                DeviceName = new List<Device.DeviceNameComponent>((IEnumerable<Device.DeviceNameComponent>)zzt_),
                ModelNumberElement = zzu_,
                PartNumberElement = zzv_,
                Type = zzw_,
                Specialization = new List<Device.SpecializationComponent>((IEnumerable<Device.SpecializationComponent>)zzx_),
                Version = new List<Device.VersionComponent>((IEnumerable<Device.VersionComponent>)zzy_),
                Property = new List<Device.PropertyComponent>((IEnumerable<Device.PropertyComponent>)zzz_),
                Patient = azza_,
                Owner = azzb_,
                Contact = new List<ContactPoint>((IEnumerable<ContactPoint>)azzc_),
                Location = azzd_,
                UrlElement = azze_,
                Note = new List<Annotation>((IEnumerable<Annotation>)azzf_),
                Safety = new List<CodeableConcept>((IEnumerable<CodeableConcept>)azzg_),
                Parent = azzh_,
            };

            return azzi_;
        };
        IEnumerable<Device> zzf_ = context.Operators.Select<Device, Device>((IEnumerable<Device>)zzd_, zze_);
        IEnumerable<Device> zzg_ = context.Operators.Distinct<Device>(zzf_);
        Device zzh_ = context.Operators.SingletonFrom<Device>(zzg_);

        return zzh_;
    }


    [CqlExpressionDefinition("DeviceDefinitionResource")]
    public DeviceDefinition DeviceDefinitionResource(CqlContext context, DeviceDefinition arg)
    {
        DeviceDefinition[] azzj_ = [
            arg,
        ];
        DeviceDefinition azzk_(DeviceDefinition a)
        {
            List<Identifier> azzo_ = a?.Identifier;
            List<DeviceDefinition.UdiDeviceIdentifierComponent> azzp_ = a?.UdiDeviceIdentifier;
            DataType azzq_ = a?.Manufacturer;
            List<DeviceDefinition.DeviceNameComponent> azzr_ = a?.DeviceName;
            FhirString azzs_ = a?.ModelNumberElement;
            CodeableConcept azzt_ = a?.Type;
            List<DeviceDefinition.SpecializationComponent> azzu_ = a?.Specialization;
            List<FhirString> azzv_ = a?.VersionElement;
            List<CodeableConcept> azzw_ = a?.Safety;
            List<ProductShelfLife> azzx_ = a?.ShelfLifeStorage;
            ProdCharacteristic azzy_ = a?.PhysicalCharacteristics;
            List<CodeableConcept> azzz_ = a?.LanguageCode;
            List<DeviceDefinition.CapabilityComponent> bzza_ = a?.Capability;
            List<DeviceDefinition.PropertyComponent> bzzb_ = a?.Property;
            ResourceReference bzzc_ = a?.Owner;
            List<ContactPoint> bzzd_ = a?.Contact;
            FhirUri bzze_ = a?.UrlElement;
            FhirUri bzzf_ = a?.OnlineInformationElement;
            List<Annotation> bzzg_ = a?.Note;
            Quantity bzzh_ = a?.Quantity;
            ResourceReference bzzi_ = a?.ParentDevice;
            List<DeviceDefinition.MaterialComponent> bzzj_ = a?.Material;
            DeviceDefinition bzzk_ = new DeviceDefinition
            {
                Identifier = new List<Identifier>((IEnumerable<Identifier>)azzo_),
                UdiDeviceIdentifier = new List<DeviceDefinition.UdiDeviceIdentifierComponent>((IEnumerable<DeviceDefinition.UdiDeviceIdentifierComponent>)azzp_),
                Manufacturer = (DataType)azzq_,
                DeviceName = new List<DeviceDefinition.DeviceNameComponent>((IEnumerable<DeviceDefinition.DeviceNameComponent>)azzr_),
                ModelNumberElement = azzs_,
                Type = azzt_,
                Specialization = new List<DeviceDefinition.SpecializationComponent>((IEnumerable<DeviceDefinition.SpecializationComponent>)azzu_),
                VersionElement = new List<FhirString>((IEnumerable<FhirString>)azzv_),
                Safety = new List<CodeableConcept>((IEnumerable<CodeableConcept>)azzw_),
                ShelfLifeStorage = new List<ProductShelfLife>((IEnumerable<ProductShelfLife>)azzx_),
                PhysicalCharacteristics = azzy_,
                LanguageCode = new List<CodeableConcept>((IEnumerable<CodeableConcept>)azzz_),
                Capability = new List<DeviceDefinition.CapabilityComponent>((IEnumerable<DeviceDefinition.CapabilityComponent>)bzza_),
                Property = new List<DeviceDefinition.PropertyComponent>((IEnumerable<DeviceDefinition.PropertyComponent>)bzzb_),
                Owner = bzzc_,
                Contact = new List<ContactPoint>((IEnumerable<ContactPoint>)bzzd_),
                UrlElement = bzze_,
                OnlineInformationElement = bzzf_,
                Note = new List<Annotation>((IEnumerable<Annotation>)bzzg_),
                Quantity = bzzh_,
                ParentDevice = bzzi_,
                Material = new List<DeviceDefinition.MaterialComponent>((IEnumerable<DeviceDefinition.MaterialComponent>)bzzj_),
            };

            return bzzk_;
        };
        IEnumerable<DeviceDefinition> azzl_ = context.Operators.Select<DeviceDefinition, DeviceDefinition>((IEnumerable<DeviceDefinition>)azzj_, azzk_);
        IEnumerable<DeviceDefinition> azzm_ = context.Operators.Distinct<DeviceDefinition>(azzl_);
        DeviceDefinition azzn_ = context.Operators.SingletonFrom<DeviceDefinition>(azzm_);

        return azzn_;
    }


    [CqlExpressionDefinition("DeviceMetricResource")]
    public DeviceMetric DeviceMetricResource(CqlContext context, DeviceMetric arg)
    {
        DeviceMetric[] bzzl_ = [
            arg,
        ];
        DeviceMetric bzzm_(DeviceMetric a)
        {
            List<Identifier> bzzq_ = a?.Identifier;
            CodeableConcept bzzr_ = a?.Type;
            CodeableConcept bzzs_ = a?.Unit;
            ResourceReference bzzt_ = a?.Source;
            ResourceReference bzzu_ = a?.Parent;
            Code<DeviceMetric.DeviceMetricOperationalStatus> bzzv_ = a?.OperationalStatusElement;
            Code<DeviceMetric.DeviceMetricColor> bzzw_ = a?.ColorElement;
            Code<DeviceMetric.DeviceMetricCategory> bzzx_ = a?.CategoryElement;
            Timing bzzy_ = a?.MeasurementPeriod;
            List<DeviceMetric.CalibrationComponent> bzzz_ = a?.Calibration;
            DeviceMetric czza_ = new DeviceMetric
            {
                Identifier = new List<Identifier>((IEnumerable<Identifier>)bzzq_),
                Type = bzzr_,
                Unit = bzzs_,
                Source = bzzt_,
                Parent = bzzu_,
                OperationalStatusElement = bzzv_,
                ColorElement = bzzw_,
                CategoryElement = bzzx_,
                MeasurementPeriod = bzzy_,
                Calibration = new List<DeviceMetric.CalibrationComponent>((IEnumerable<DeviceMetric.CalibrationComponent>)bzzz_),
            };

            return czza_;
        };
        IEnumerable<DeviceMetric> bzzn_ = context.Operators.Select<DeviceMetric, DeviceMetric>((IEnumerable<DeviceMetric>)bzzl_, bzzm_);
        IEnumerable<DeviceMetric> bzzo_ = context.Operators.Distinct<DeviceMetric>(bzzn_);
        DeviceMetric bzzp_ = context.Operators.SingletonFrom<DeviceMetric>(bzzo_);

        return bzzp_;
    }


    [CqlExpressionDefinition("DeviceRequestResource")]
    public DeviceRequest DeviceRequestResource(CqlContext context, DeviceRequest arg)
    {
        DeviceRequest[] czzb_ = [
            arg,
        ];
        DeviceRequest czzc_(DeviceRequest a)
        {
            List<Identifier> czzg_ = a?.Identifier;
            List<Canonical> czzh_ = a?.InstantiatesCanonicalElement;
            List<FhirUri> czzi_ = a?.InstantiatesUriElement;
            List<ResourceReference> czzj_ = a?.BasedOn;
            List<ResourceReference> czzk_ = a?.PriorRequest;
            Identifier czzl_ = a?.GroupIdentifier;
            Code<RequestStatus> czzm_ = a?.StatusElement;
            Code<RequestIntent> czzn_ = a?.IntentElement;
            Code<RequestPriority> czzo_ = a?.PriorityElement;
            DataType czzp_ = a?.Code;
            List<DeviceRequest.ParameterComponent> czzq_ = a?.Parameter;
            ResourceReference czzr_ = a?.Subject;
            ResourceReference czzs_ = a?.Encounter;
            DataType czzt_ = a?.Occurrence;
            FhirDateTime czzu_ = a?.AuthoredOnElement;
            ResourceReference czzv_ = a?.Requester;
            CodeableConcept czzw_ = a?.PerformerType;
            ResourceReference czzx_ = a?.Performer;
            List<CodeableConcept> czzy_ = a?.ReasonCode;
            List<ResourceReference> czzz_ = a?.ReasonReference;
            List<ResourceReference> dzza_ = a?.Insurance;
            List<ResourceReference> dzzb_ = a?.SupportingInfo;
            List<Annotation> dzzc_ = a?.Note;
            List<ResourceReference> dzzd_ = a?.RelevantHistory;
            DeviceRequest dzze_ = new DeviceRequest
            {
                Identifier = new List<Identifier>((IEnumerable<Identifier>)czzg_),
                InstantiatesCanonicalElement = new List<Canonical>((IEnumerable<Canonical>)czzh_),
                InstantiatesUriElement = new List<FhirUri>((IEnumerable<FhirUri>)czzi_),
                BasedOn = new List<ResourceReference>((IEnumerable<ResourceReference>)czzj_),
                PriorRequest = new List<ResourceReference>((IEnumerable<ResourceReference>)czzk_),
                GroupIdentifier = czzl_,
                StatusElement = czzm_,
                IntentElement = czzn_,
                PriorityElement = czzo_,
                Code = (DataType)czzp_,
                Parameter = new List<DeviceRequest.ParameterComponent>((IEnumerable<DeviceRequest.ParameterComponent>)czzq_),
                Subject = czzr_,
                Encounter = czzs_,
                Occurrence = (DataType)czzt_,
                AuthoredOnElement = czzu_,
                Requester = czzv_,
                PerformerType = czzw_,
                Performer = czzx_,
                ReasonCode = new List<CodeableConcept>((IEnumerable<CodeableConcept>)czzy_),
                ReasonReference = new List<ResourceReference>((IEnumerable<ResourceReference>)czzz_),
                Insurance = new List<ResourceReference>((IEnumerable<ResourceReference>)dzza_),
                SupportingInfo = new List<ResourceReference>((IEnumerable<ResourceReference>)dzzb_),
                Note = new List<Annotation>((IEnumerable<Annotation>)dzzc_),
                RelevantHistory = new List<ResourceReference>((IEnumerable<ResourceReference>)dzzd_),
            };

            return dzze_;
        };
        IEnumerable<DeviceRequest> czzd_ = context.Operators.Select<DeviceRequest, DeviceRequest>((IEnumerable<DeviceRequest>)czzb_, czzc_);
        IEnumerable<DeviceRequest> czze_ = context.Operators.Distinct<DeviceRequest>(czzd_);
        DeviceRequest czzf_ = context.Operators.SingletonFrom<DeviceRequest>(czze_);

        return czzf_;
    }


    [CqlExpressionDefinition("DeviceUseStatementResource")]
    public DeviceUseStatement DeviceUseStatementResource(CqlContext context, DeviceUseStatement arg)
    {
        DeviceUseStatement[] dzzf_ = [
            arg,
        ];
        DeviceUseStatement dzzg_(DeviceUseStatement a)
        {
            List<Identifier> dzzk_ = a?.Identifier;
            List<ResourceReference> dzzl_ = a?.BasedOn;
            Code<DeviceUseStatement.DeviceUseStatementStatus> dzzm_ = a?.StatusElement;
            ResourceReference dzzn_ = a?.Subject;
            List<ResourceReference> dzzo_ = a?.DerivedFrom;
            DataType dzzp_ = a?.Timing;
            FhirDateTime dzzq_ = a?.RecordedOnElement;
            ResourceReference dzzr_ = a?.Source;
            ResourceReference dzzs_ = a?.Device;
            List<CodeableConcept> dzzt_ = a?.ReasonCode;
            List<ResourceReference> dzzu_ = a?.ReasonReference;
            CodeableConcept dzzv_ = a?.BodySite;
            List<Annotation> dzzw_ = a?.Note;
            DeviceUseStatement dzzx_ = new DeviceUseStatement
            {
                Identifier = new List<Identifier>((IEnumerable<Identifier>)dzzk_),
                BasedOn = new List<ResourceReference>((IEnumerable<ResourceReference>)dzzl_),
                StatusElement = dzzm_,
                Subject = dzzn_,
                DerivedFrom = new List<ResourceReference>((IEnumerable<ResourceReference>)dzzo_),
                Timing = (DataType)dzzp_,
                RecordedOnElement = dzzq_,
                Source = dzzr_,
                Device = dzzs_,
                ReasonCode = new List<CodeableConcept>((IEnumerable<CodeableConcept>)dzzt_),
                ReasonReference = new List<ResourceReference>((IEnumerable<ResourceReference>)dzzu_),
                BodySite = dzzv_,
                Note = new List<Annotation>((IEnumerable<Annotation>)dzzw_),
            };

            return dzzx_;
        };
        IEnumerable<DeviceUseStatement> dzzh_ = context.Operators.Select<DeviceUseStatement, DeviceUseStatement>((IEnumerable<DeviceUseStatement>)dzzf_, dzzg_);
        IEnumerable<DeviceUseStatement> dzzi_ = context.Operators.Distinct<DeviceUseStatement>(dzzh_);
        DeviceUseStatement dzzj_ = context.Operators.SingletonFrom<DeviceUseStatement>(dzzi_);

        return dzzj_;
    }


    [CqlExpressionDefinition("DiagnosticReportResource")]
    public DiagnosticReport DiagnosticReportResource(CqlContext context, DiagnosticReport arg)
    {
        DiagnosticReport[] dzzy_ = [
            arg,
        ];
        DiagnosticReport dzzz_(DiagnosticReport a)
        {
            List<Identifier> ezzd_ = a?.Identifier;
            List<ResourceReference> ezze_ = a?.BasedOn;
            Code<DiagnosticReport.DiagnosticReportStatus> ezzf_ = a?.StatusElement;
            List<CodeableConcept> ezzg_ = a?.Category;
            CodeableConcept ezzh_ = a?.Code;
            ResourceReference ezzi_ = a?.Subject;
            ResourceReference ezzj_ = a?.Encounter;
            DataType ezzk_ = a?.Effective;
            Instant ezzl_ = a?.IssuedElement;
            List<ResourceReference> ezzm_ = a?.Performer;
            List<ResourceReference> ezzn_ = a?.ResultsInterpreter;
            List<ResourceReference> ezzo_ = a?.Specimen;
            List<ResourceReference> ezzp_ = a?.Result;
            List<ResourceReference> ezzq_ = a?.ImagingStudy;
            List<DiagnosticReport.MediaComponent> ezzr_ = a?.Media;
            FhirString ezzs_ = a?.ConclusionElement;
            List<CodeableConcept> ezzt_ = a?.ConclusionCode;
            List<Attachment> ezzu_ = a?.PresentedForm;
            DiagnosticReport ezzv_ = new DiagnosticReport
            {
                Identifier = new List<Identifier>((IEnumerable<Identifier>)ezzd_),
                BasedOn = new List<ResourceReference>((IEnumerable<ResourceReference>)ezze_),
                StatusElement = ezzf_,
                Category = new List<CodeableConcept>((IEnumerable<CodeableConcept>)ezzg_),
                Code = ezzh_,
                Subject = ezzi_,
                Encounter = ezzj_,
                Effective = (DataType)ezzk_,
                IssuedElement = ezzl_,
                Performer = new List<ResourceReference>((IEnumerable<ResourceReference>)ezzm_),
                ResultsInterpreter = new List<ResourceReference>((IEnumerable<ResourceReference>)ezzn_),
                Specimen = new List<ResourceReference>((IEnumerable<ResourceReference>)ezzo_),
                Result = new List<ResourceReference>((IEnumerable<ResourceReference>)ezzp_),
                ImagingStudy = new List<ResourceReference>((IEnumerable<ResourceReference>)ezzq_),
                Media = new List<DiagnosticReport.MediaComponent>((IEnumerable<DiagnosticReport.MediaComponent>)ezzr_),
                ConclusionElement = ezzs_,
                ConclusionCode = new List<CodeableConcept>((IEnumerable<CodeableConcept>)ezzt_),
                PresentedForm = new List<Attachment>((IEnumerable<Attachment>)ezzu_),
            };

            return ezzv_;
        };
        IEnumerable<DiagnosticReport> ezza_ = context.Operators.Select<DiagnosticReport, DiagnosticReport>((IEnumerable<DiagnosticReport>)dzzy_, dzzz_);
        IEnumerable<DiagnosticReport> ezzb_ = context.Operators.Distinct<DiagnosticReport>(ezza_);
        DiagnosticReport ezzc_ = context.Operators.SingletonFrom<DiagnosticReport>(ezzb_);

        return ezzc_;
    }


    [CqlExpressionDefinition("DocumentManifestResource")]
    public DocumentManifest DocumentManifestResource(CqlContext context, DocumentManifest arg)
    {
        DocumentManifest[] ezzw_ = [
            arg,
        ];
        DocumentManifest ezzx_(DocumentManifest a)
        {
            Identifier fzzb_ = a?.MasterIdentifier;
            List<Identifier> fzzc_ = a?.Identifier;
            Code<DocumentReferenceStatus> fzzd_ = a?.StatusElement;
            CodeableConcept fzze_ = a?.Type;
            ResourceReference fzzf_ = a?.Subject;
            FhirDateTime fzzg_ = a?.CreatedElement;
            List<ResourceReference> fzzh_ = a?.Author;
            List<ResourceReference> fzzi_ = a?.Recipient;
            FhirUri fzzj_ = a?.SourceElement;
            FhirString fzzk_ = a?.DescriptionElement;
            List<ResourceReference> fzzl_ = a?.Content;
            List<DocumentManifest.RelatedComponent> fzzm_ = a?.Related;
            DocumentManifest fzzn_ = new DocumentManifest
            {
                MasterIdentifier = fzzb_,
                Identifier = new List<Identifier>((IEnumerable<Identifier>)fzzc_),
                StatusElement = fzzd_,
                Type = fzze_,
                Subject = fzzf_,
                CreatedElement = fzzg_,
                Author = new List<ResourceReference>((IEnumerable<ResourceReference>)fzzh_),
                Recipient = new List<ResourceReference>((IEnumerable<ResourceReference>)fzzi_),
                SourceElement = fzzj_,
                DescriptionElement = fzzk_,
                Content = new List<ResourceReference>((IEnumerable<ResourceReference>)fzzl_),
                Related = new List<DocumentManifest.RelatedComponent>((IEnumerable<DocumentManifest.RelatedComponent>)fzzm_),
            };

            return fzzn_;
        };
        IEnumerable<DocumentManifest> ezzy_ = context.Operators.Select<DocumentManifest, DocumentManifest>((IEnumerable<DocumentManifest>)ezzw_, ezzx_);
        IEnumerable<DocumentManifest> ezzz_ = context.Operators.Distinct<DocumentManifest>(ezzy_);
        DocumentManifest fzza_ = context.Operators.SingletonFrom<DocumentManifest>(ezzz_);

        return fzza_;
    }


    [CqlExpressionDefinition("DocumentReferenceResource")]
    public DocumentReference DocumentReferenceResource(CqlContext context, DocumentReference arg)
    {
        DocumentReference[] fzzo_ = [
            arg,
        ];
        DocumentReference fzzp_(DocumentReference a)
        {
            Identifier fzzt_ = a?.MasterIdentifier;
            List<Identifier> fzzu_ = a?.Identifier;
            Code<DocumentReferenceStatus> fzzv_ = a?.StatusElement;
            Code<CompositionStatus> fzzw_ = a?.DocStatusElement;
            CodeableConcept fzzx_ = a?.Type;
            List<CodeableConcept> fzzy_ = a?.Category;
            ResourceReference fzzz_ = a?.Subject;
            Instant gzza_ = a?.DateElement;
            List<ResourceReference> gzzb_ = a?.Author;
            ResourceReference gzzc_ = a?.Authenticator;
            ResourceReference gzzd_ = a?.Custodian;
            List<DocumentReference.RelatesToComponent> gzze_ = a?.RelatesTo;
            FhirString gzzf_ = a?.DescriptionElement;
            List<CodeableConcept> gzzg_ = a?.SecurityLabel;
            List<DocumentReference.ContentComponent> gzzh_ = a?.Content;
            DocumentReference.ContextComponent gzzi_ = a?.Context;
            DocumentReference gzzj_ = new DocumentReference
            {
                MasterIdentifier = fzzt_,
                Identifier = new List<Identifier>((IEnumerable<Identifier>)fzzu_),
                StatusElement = fzzv_,
                DocStatusElement = fzzw_,
                Type = fzzx_,
                Category = new List<CodeableConcept>((IEnumerable<CodeableConcept>)fzzy_),
                Subject = fzzz_,
                DateElement = gzza_,
                Author = new List<ResourceReference>((IEnumerable<ResourceReference>)gzzb_),
                Authenticator = gzzc_,
                Custodian = gzzd_,
                RelatesTo = new List<DocumentReference.RelatesToComponent>((IEnumerable<DocumentReference.RelatesToComponent>)gzze_),
                DescriptionElement = gzzf_,
                SecurityLabel = new List<CodeableConcept>((IEnumerable<CodeableConcept>)gzzg_),
                Content = new List<DocumentReference.ContentComponent>((IEnumerable<DocumentReference.ContentComponent>)gzzh_),
                Context = gzzi_,
            };

            return gzzj_;
        };
        IEnumerable<DocumentReference> fzzq_ = context.Operators.Select<DocumentReference, DocumentReference>((IEnumerable<DocumentReference>)fzzo_, fzzp_);
        IEnumerable<DocumentReference> fzzr_ = context.Operators.Distinct<DocumentReference>(fzzq_);
        DocumentReference fzzs_ = context.Operators.SingletonFrom<DocumentReference>(fzzr_);

        return fzzs_;
    }


    [CqlExpressionDefinition("EffectEvidenceSynthesisResource")]
    public EffectEvidenceSynthesis EffectEvidenceSynthesisResource(CqlContext context, EffectEvidenceSynthesis arg)
    {
        EffectEvidenceSynthesis[] gzzk_ = [
            arg,
        ];
        EffectEvidenceSynthesis gzzl_(EffectEvidenceSynthesis a)
        {
            FhirUri gzzp_ = a?.UrlElement;
            List<Identifier> gzzq_ = a?.Identifier;
            FhirString gzzr_ = a?.VersionElement;
            FhirString gzzs_ = a?.NameElement;
            FhirString gzzt_ = a?.TitleElement;
            Code<PublicationStatus> gzzu_ = a?.StatusElement;
            FhirDateTime gzzv_ = a?.DateElement;
            FhirString gzzw_ = a?.PublisherElement;
            List<ContactDetail> gzzx_ = a?.Contact;
            Markdown gzzy_ = a?.DescriptionElement;
            List<Annotation> gzzz_ = a?.Note;
            List<UsageContext> hzza_ = a?.UseContext;
            List<CodeableConcept> hzzb_ = a?.Jurisdiction;
            Markdown hzzc_ = a?.CopyrightElement;
            Date hzzd_ = a?.ApprovalDateElement;
            Date hzze_ = a?.LastReviewDateElement;
            Period hzzf_ = a?.EffectivePeriod;
            List<CodeableConcept> hzzg_ = a?.Topic;
            List<ContactDetail> hzzh_ = a?.Author;
            List<ContactDetail> hzzi_ = a?.Editor;
            List<ContactDetail> hzzj_ = a?.Reviewer;
            List<ContactDetail> hzzk_ = a?.Endorser;
            List<RelatedArtifact> hzzl_ = a?.RelatedArtifact;
            CodeableConcept hzzm_ = a?.SynthesisType;
            CodeableConcept hzzn_ = a?.StudyType;
            ResourceReference hzzo_ = a?.Population;
            ResourceReference hzzp_ = a?.Exposure;
            ResourceReference hzzq_ = a?.ExposureAlternative;
            ResourceReference hzzr_ = a?.Outcome;
            EffectEvidenceSynthesis.SampleSizeComponent hzzs_ = a?.SampleSize;
            List<EffectEvidenceSynthesis.ResultsByExposureComponent> hzzt_ = a?.ResultsByExposure;
            List<EffectEvidenceSynthesis.EffectEstimateComponent> hzzu_ = a?.EffectEstimate;
            List<EffectEvidenceSynthesis.CertaintyComponent> hzzv_ = a?.Certainty;
            EffectEvidenceSynthesis hzzw_ = new EffectEvidenceSynthesis
            {
                UrlElement = gzzp_,
                Identifier = new List<Identifier>((IEnumerable<Identifier>)gzzq_),
                VersionElement = gzzr_,
                NameElement = gzzs_,
                TitleElement = gzzt_,
                StatusElement = gzzu_,
                DateElement = gzzv_,
                PublisherElement = gzzw_,
                Contact = new List<ContactDetail>((IEnumerable<ContactDetail>)gzzx_),
                DescriptionElement = gzzy_,
                Note = new List<Annotation>((IEnumerable<Annotation>)gzzz_),
                UseContext = new List<UsageContext>((IEnumerable<UsageContext>)hzza_),
                Jurisdiction = new List<CodeableConcept>((IEnumerable<CodeableConcept>)hzzb_),
                CopyrightElement = hzzc_,
                ApprovalDateElement = hzzd_,
                LastReviewDateElement = hzze_,
                EffectivePeriod = hzzf_,
                Topic = new List<CodeableConcept>((IEnumerable<CodeableConcept>)hzzg_),
                Author = new List<ContactDetail>((IEnumerable<ContactDetail>)hzzh_),
                Editor = new List<ContactDetail>((IEnumerable<ContactDetail>)hzzi_),
                Reviewer = new List<ContactDetail>((IEnumerable<ContactDetail>)hzzj_),
                Endorser = new List<ContactDetail>((IEnumerable<ContactDetail>)hzzk_),
                RelatedArtifact = new List<RelatedArtifact>((IEnumerable<RelatedArtifact>)hzzl_),
                SynthesisType = hzzm_,
                StudyType = hzzn_,
                Population = hzzo_,
                Exposure = hzzp_,
                ExposureAlternative = hzzq_,
                Outcome = hzzr_,
                SampleSize = hzzs_,
                ResultsByExposure = new List<EffectEvidenceSynthesis.ResultsByExposureComponent>((IEnumerable<EffectEvidenceSynthesis.ResultsByExposureComponent>)hzzt_),
                EffectEstimate = new List<EffectEvidenceSynthesis.EffectEstimateComponent>((IEnumerable<EffectEvidenceSynthesis.EffectEstimateComponent>)hzzu_),
                Certainty = new List<EffectEvidenceSynthesis.CertaintyComponent>((IEnumerable<EffectEvidenceSynthesis.CertaintyComponent>)hzzv_),
            };

            return hzzw_;
        };
        IEnumerable<EffectEvidenceSynthesis> gzzm_ = context.Operators.Select<EffectEvidenceSynthesis, EffectEvidenceSynthesis>((IEnumerable<EffectEvidenceSynthesis>)gzzk_, gzzl_);
        IEnumerable<EffectEvidenceSynthesis> gzzn_ = context.Operators.Distinct<EffectEvidenceSynthesis>(gzzm_);
        EffectEvidenceSynthesis gzzo_ = context.Operators.SingletonFrom<EffectEvidenceSynthesis>(gzzn_);

        return gzzo_;
    }


    [CqlExpressionDefinition("EncounterResource")]
    public Encounter EncounterResource(CqlContext context, Encounter arg)
    {
        Encounter[] hzzx_ = [
            arg,
        ];
        Encounter hzzy_(Encounter a)
        {
            List<Identifier> izzc_ = a?.Identifier;
            Code<Encounter.EncounterStatus> izzd_ = a?.StatusElement;
            List<Encounter.StatusHistoryComponent> izze_ = a?.StatusHistory;
            Coding izzf_ = a?.Class;
            List<Encounter.ClassHistoryComponent> izzg_ = a?.ClassHistory;
            List<CodeableConcept> izzh_ = a?.Type;
            CodeableConcept izzi_ = a?.ServiceType;
            CodeableConcept izzj_ = a?.Priority;
            ResourceReference izzk_ = a?.Subject;
            List<ResourceReference> izzl_ = a?.EpisodeOfCare;
            List<ResourceReference> izzm_ = a?.BasedOn;
            List<Encounter.ParticipantComponent> izzn_ = a?.Participant;
            List<ResourceReference> izzo_ = a?.Appointment;
            Period izzp_ = a?.Period;
            Duration izzq_ = a?.Length;
            List<CodeableConcept> izzr_ = a?.ReasonCode;
            List<ResourceReference> izzs_ = a?.ReasonReference;
            List<Encounter.DiagnosisComponent> izzt_ = a?.Diagnosis;
            List<ResourceReference> izzu_ = a?.Account;
            Encounter.HospitalizationComponent izzv_ = a?.Hospitalization;
            List<Encounter.LocationComponent> izzw_ = a?.Location;
            ResourceReference izzx_ = a?.ServiceProvider;
            ResourceReference izzy_ = a?.PartOf;
            Encounter izzz_ = new Encounter
            {
                Identifier = new List<Identifier>((IEnumerable<Identifier>)izzc_),
                StatusElement = izzd_,
                StatusHistory = new List<Encounter.StatusHistoryComponent>((IEnumerable<Encounter.StatusHistoryComponent>)izze_),
                Class = izzf_,
                ClassHistory = new List<Encounter.ClassHistoryComponent>((IEnumerable<Encounter.ClassHistoryComponent>)izzg_),
                Type = new List<CodeableConcept>((IEnumerable<CodeableConcept>)izzh_),
                ServiceType = izzi_,
                Priority = izzj_,
                Subject = izzk_,
                EpisodeOfCare = new List<ResourceReference>((IEnumerable<ResourceReference>)izzl_),
                BasedOn = new List<ResourceReference>((IEnumerable<ResourceReference>)izzm_),
                Participant = new List<Encounter.ParticipantComponent>((IEnumerable<Encounter.ParticipantComponent>)izzn_),
                Appointment = new List<ResourceReference>((IEnumerable<ResourceReference>)izzo_),
                Period = izzp_,
                Length = izzq_,
                ReasonCode = new List<CodeableConcept>((IEnumerable<CodeableConcept>)izzr_),
                ReasonReference = new List<ResourceReference>((IEnumerable<ResourceReference>)izzs_),
                Diagnosis = new List<Encounter.DiagnosisComponent>((IEnumerable<Encounter.DiagnosisComponent>)izzt_),
                Account = new List<ResourceReference>((IEnumerable<ResourceReference>)izzu_),
                Hospitalization = izzv_,
                Location = new List<Encounter.LocationComponent>((IEnumerable<Encounter.LocationComponent>)izzw_),
                ServiceProvider = izzx_,
                PartOf = izzy_,
            };

            return izzz_;
        };
        IEnumerable<Encounter> hzzz_ = context.Operators.Select<Encounter, Encounter>((IEnumerable<Encounter>)hzzx_, hzzy_);
        IEnumerable<Encounter> izza_ = context.Operators.Distinct<Encounter>(hzzz_);
        Encounter izzb_ = context.Operators.SingletonFrom<Encounter>(izza_);

        return izzb_;
    }


    [CqlExpressionDefinition("EndpointResource")]
    public Endpoint EndpointResource(CqlContext context, Endpoint arg)
    {
        Endpoint[] jzza_ = [
            arg,
        ];
        Endpoint jzzb_(Endpoint a)
        {
            List<Identifier> jzzf_ = a?.Identifier;
            Code<Endpoint.EndpointStatus> jzzg_ = a?.StatusElement;
            Coding jzzh_ = a?.ConnectionType;
            FhirString jzzi_ = a?.NameElement;
            ResourceReference jzzj_ = a?.ManagingOrganization;
            List<ContactPoint> jzzk_ = a?.Contact;
            Period jzzl_ = a?.Period;
            List<CodeableConcept> jzzm_ = a?.PayloadType;
            List<Code> jzzn_ = a?.PayloadMimeTypeElement;
            FhirUrl jzzo_ = a?.AddressElement;
            List<FhirString> jzzp_ = a?.HeaderElement;
            Endpoint jzzq_ = new Endpoint
            {
                Identifier = new List<Identifier>((IEnumerable<Identifier>)jzzf_),
                StatusElement = jzzg_,
                ConnectionType = jzzh_,
                NameElement = jzzi_,
                ManagingOrganization = jzzj_,
                Contact = new List<ContactPoint>((IEnumerable<ContactPoint>)jzzk_),
                Period = jzzl_,
                PayloadType = new List<CodeableConcept>((IEnumerable<CodeableConcept>)jzzm_),
                PayloadMimeTypeElement = new List<Code>((IEnumerable<Code>)jzzn_),
                AddressElement = jzzo_,
                HeaderElement = new List<FhirString>((IEnumerable<FhirString>)jzzp_),
            };

            return jzzq_;
        };
        IEnumerable<Endpoint> jzzc_ = context.Operators.Select<Endpoint, Endpoint>((IEnumerable<Endpoint>)jzza_, jzzb_);
        IEnumerable<Endpoint> jzzd_ = context.Operators.Distinct<Endpoint>(jzzc_);
        Endpoint jzze_ = context.Operators.SingletonFrom<Endpoint>(jzzd_);

        return jzze_;
    }


    [CqlExpressionDefinition("EnrollmentRequestResource")]
    public EnrollmentRequest EnrollmentRequestResource(CqlContext context, EnrollmentRequest arg)
    {
        EnrollmentRequest[] jzzr_ = [
            arg,
        ];
        EnrollmentRequest jzzs_(EnrollmentRequest a)
        {
            List<Identifier> jzzw_ = a?.Identifier;
            Code<FinancialResourceStatusCodes> jzzx_ = a?.StatusElement;
            FhirDateTime jzzy_ = a?.CreatedElement;
            ResourceReference jzzz_ = a?.Insurer;
            ResourceReference kzza_ = a?.Provider;
            ResourceReference kzzb_ = a?.Candidate;
            ResourceReference kzzc_ = a?.Coverage;
            EnrollmentRequest kzzd_ = new EnrollmentRequest
            {
                Identifier = new List<Identifier>((IEnumerable<Identifier>)jzzw_),
                StatusElement = jzzx_,
                CreatedElement = jzzy_,
                Insurer = jzzz_,
                Provider = kzza_,
                Candidate = kzzb_,
                Coverage = kzzc_,
            };

            return kzzd_;
        };
        IEnumerable<EnrollmentRequest> jzzt_ = context.Operators.Select<EnrollmentRequest, EnrollmentRequest>((IEnumerable<EnrollmentRequest>)jzzr_, jzzs_);
        IEnumerable<EnrollmentRequest> jzzu_ = context.Operators.Distinct<EnrollmentRequest>(jzzt_);
        EnrollmentRequest jzzv_ = context.Operators.SingletonFrom<EnrollmentRequest>(jzzu_);

        return jzzv_;
    }


    [CqlExpressionDefinition("EnrollmentResponseResource")]
    public EnrollmentResponse EnrollmentResponseResource(CqlContext context, EnrollmentResponse arg)
    {
        EnrollmentResponse[] kzze_ = [
            arg,
        ];
        EnrollmentResponse kzzf_(EnrollmentResponse a)
        {
            List<Identifier> kzzj_ = a?.Identifier;
            Code<FinancialResourceStatusCodes> kzzk_ = a?.StatusElement;
            ResourceReference kzzl_ = a?.Request;
            Code<ClaimProcessingCodes> kzzm_ = a?.OutcomeElement;
            FhirString kzzn_ = a?.DispositionElement;
            FhirDateTime kzzo_ = a?.CreatedElement;
            ResourceReference kzzp_ = a?.Organization;
            ResourceReference kzzq_ = a?.RequestProvider;
            EnrollmentResponse kzzr_ = new EnrollmentResponse
            {
                Identifier = new List<Identifier>((IEnumerable<Identifier>)kzzj_),
                StatusElement = kzzk_,
                Request = kzzl_,
                OutcomeElement = kzzm_,
                DispositionElement = kzzn_,
                CreatedElement = kzzo_,
                Organization = kzzp_,
                RequestProvider = kzzq_,
            };

            return kzzr_;
        };
        IEnumerable<EnrollmentResponse> kzzg_ = context.Operators.Select<EnrollmentResponse, EnrollmentResponse>((IEnumerable<EnrollmentResponse>)kzze_, kzzf_);
        IEnumerable<EnrollmentResponse> kzzh_ = context.Operators.Distinct<EnrollmentResponse>(kzzg_);
        EnrollmentResponse kzzi_ = context.Operators.SingletonFrom<EnrollmentResponse>(kzzh_);

        return kzzi_;
    }


    [CqlExpressionDefinition("EpisodeOfCareResource")]
    public EpisodeOfCare EpisodeOfCareResource(CqlContext context, EpisodeOfCare arg)
    {
        EpisodeOfCare[] kzzs_ = [
            arg,
        ];
        EpisodeOfCare kzzt_(EpisodeOfCare a)
        {
            List<Identifier> kzzx_ = a?.Identifier;
            Code<EpisodeOfCare.EpisodeOfCareStatus> kzzy_ = a?.StatusElement;
            List<EpisodeOfCare.StatusHistoryComponent> kzzz_ = a?.StatusHistory;
            List<CodeableConcept> lzza_ = a?.Type;
            List<EpisodeOfCare.DiagnosisComponent> lzzb_ = a?.Diagnosis;
            ResourceReference lzzc_ = a?.Patient;
            ResourceReference lzzd_ = a?.ManagingOrganization;
            Period lzze_ = a?.Period;
            List<ResourceReference> lzzf_ = a?.ReferralRequest;
            ResourceReference lzzg_ = a?.CareManager;
            List<ResourceReference> lzzh_ = a?.Team;
            List<ResourceReference> lzzi_ = a?.Account;
            EpisodeOfCare lzzj_ = new EpisodeOfCare
            {
                Identifier = new List<Identifier>((IEnumerable<Identifier>)kzzx_),
                StatusElement = kzzy_,
                StatusHistory = new List<EpisodeOfCare.StatusHistoryComponent>((IEnumerable<EpisodeOfCare.StatusHistoryComponent>)kzzz_),
                Type = new List<CodeableConcept>((IEnumerable<CodeableConcept>)lzza_),
                Diagnosis = new List<EpisodeOfCare.DiagnosisComponent>((IEnumerable<EpisodeOfCare.DiagnosisComponent>)lzzb_),
                Patient = lzzc_,
                ManagingOrganization = lzzd_,
                Period = lzze_,
                ReferralRequest = new List<ResourceReference>((IEnumerable<ResourceReference>)lzzf_),
                CareManager = lzzg_,
                Team = new List<ResourceReference>((IEnumerable<ResourceReference>)lzzh_),
                Account = new List<ResourceReference>((IEnumerable<ResourceReference>)lzzi_),
            };

            return lzzj_;
        };
        IEnumerable<EpisodeOfCare> kzzu_ = context.Operators.Select<EpisodeOfCare, EpisodeOfCare>((IEnumerable<EpisodeOfCare>)kzzs_, kzzt_);
        IEnumerable<EpisodeOfCare> kzzv_ = context.Operators.Distinct<EpisodeOfCare>(kzzu_);
        EpisodeOfCare kzzw_ = context.Operators.SingletonFrom<EpisodeOfCare>(kzzv_);

        return kzzw_;
    }


    [CqlExpressionDefinition("EventDefinitionResource")]
    public EventDefinition EventDefinitionResource(CqlContext context, EventDefinition arg)
    {
        EventDefinition[] lzzk_ = [
            arg,
        ];
        EventDefinition lzzl_(EventDefinition a)
        {
            FhirUri lzzp_ = a?.UrlElement;
            List<Identifier> lzzq_ = a?.Identifier;
            FhirString lzzr_ = a?.VersionElement;
            FhirString lzzs_ = a?.NameElement;
            FhirString lzzt_ = a?.TitleElement;
            FhirString lzzu_ = a?.SubtitleElement;
            Code<PublicationStatus> lzzv_ = a?.StatusElement;
            FhirBoolean lzzw_ = a?.ExperimentalElement;
            DataType lzzx_ = a?.Subject;
            FhirDateTime lzzy_ = a?.DateElement;
            FhirString lzzz_ = a?.PublisherElement;
            List<ContactDetail> mzza_ = a?.Contact;
            Markdown mzzb_ = a?.DescriptionElement;
            List<UsageContext> mzzc_ = a?.UseContext;
            List<CodeableConcept> mzzd_ = a?.Jurisdiction;
            Markdown mzze_ = a?.PurposeElement;
            FhirString mzzf_ = a?.UsageElement;
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
            List<TriggerDefinition> mzzq_ = a?.Trigger;
            EventDefinition mzzr_ = new EventDefinition
            {
                UrlElement = lzzp_,
                Identifier = new List<Identifier>((IEnumerable<Identifier>)lzzq_),
                VersionElement = lzzr_,
                NameElement = lzzs_,
                TitleElement = lzzt_,
                SubtitleElement = lzzu_,
                StatusElement = lzzv_,
                ExperimentalElement = lzzw_,
                Subject = (DataType)lzzx_,
                DateElement = lzzy_,
                PublisherElement = lzzz_,
                Contact = new List<ContactDetail>((IEnumerable<ContactDetail>)mzza_),
                DescriptionElement = mzzb_,
                UseContext = new List<UsageContext>((IEnumerable<UsageContext>)mzzc_),
                Jurisdiction = new List<CodeableConcept>((IEnumerable<CodeableConcept>)mzzd_),
                PurposeElement = mzze_,
                UsageElement = mzzf_,
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
                Trigger = new List<TriggerDefinition>((IEnumerable<TriggerDefinition>)mzzq_),
            };

            return mzzr_;
        };
        IEnumerable<EventDefinition> lzzm_ = context.Operators.Select<EventDefinition, EventDefinition>((IEnumerable<EventDefinition>)lzzk_, lzzl_);
        IEnumerable<EventDefinition> lzzn_ = context.Operators.Distinct<EventDefinition>(lzzm_);
        EventDefinition lzzo_ = context.Operators.SingletonFrom<EventDefinition>(lzzn_);

        return lzzo_;
    }


    [CqlExpressionDefinition("EvidenceResource")]
    public Evidence EvidenceResource(CqlContext context, Evidence arg)
    {
        Evidence[] mzzs_ = [
            arg,
        ];
        Evidence mzzt_(Evidence a)
        {
            FhirUri mzzx_ = a?.UrlElement;
            List<Identifier> mzzy_ = a?.Identifier;
            FhirString mzzz_ = a?.VersionElement;
            FhirString nzza_ = a?.NameElement;
            FhirString nzzb_ = a?.TitleElement;
            FhirString nzzc_ = a?.ShortTitleElement;
            FhirString nzzd_ = a?.SubtitleElement;
            Code<PublicationStatus> nzze_ = a?.StatusElement;
            FhirDateTime nzzf_ = a?.DateElement;
            FhirString nzzg_ = a?.PublisherElement;
            List<ContactDetail> nzzh_ = a?.Contact;
            Markdown nzzi_ = a?.DescriptionElement;
            List<Annotation> nzzj_ = a?.Note;
            List<UsageContext> nzzk_ = a?.UseContext;
            List<CodeableConcept> nzzl_ = a?.Jurisdiction;
            Markdown nzzm_ = a?.CopyrightElement;
            Date nzzn_ = a?.ApprovalDateElement;
            Date nzzo_ = a?.LastReviewDateElement;
            Period nzzp_ = a?.EffectivePeriod;
            List<CodeableConcept> nzzq_ = a?.Topic;
            List<ContactDetail> nzzr_ = a?.Author;
            List<ContactDetail> nzzs_ = a?.Editor;
            List<ContactDetail> nzzt_ = a?.Reviewer;
            List<ContactDetail> nzzu_ = a?.Endorser;
            List<RelatedArtifact> nzzv_ = a?.RelatedArtifact;
            ResourceReference nzzw_ = a?.ExposureBackground;
            List<ResourceReference> nzzx_ = a?.ExposureVariant;
            List<ResourceReference> nzzy_ = a?.Outcome;
            Evidence nzzz_ = new Evidence
            {
                UrlElement = mzzx_,
                Identifier = new List<Identifier>((IEnumerable<Identifier>)mzzy_),
                VersionElement = mzzz_,
                NameElement = nzza_,
                TitleElement = nzzb_,
                ShortTitleElement = nzzc_,
                SubtitleElement = nzzd_,
                StatusElement = nzze_,
                DateElement = nzzf_,
                PublisherElement = nzzg_,
                Contact = new List<ContactDetail>((IEnumerable<ContactDetail>)nzzh_),
                DescriptionElement = nzzi_,
                Note = new List<Annotation>((IEnumerable<Annotation>)nzzj_),
                UseContext = new List<UsageContext>((IEnumerable<UsageContext>)nzzk_),
                Jurisdiction = new List<CodeableConcept>((IEnumerable<CodeableConcept>)nzzl_),
                CopyrightElement = nzzm_,
                ApprovalDateElement = nzzn_,
                LastReviewDateElement = nzzo_,
                EffectivePeriod = nzzp_,
                Topic = new List<CodeableConcept>((IEnumerable<CodeableConcept>)nzzq_),
                Author = new List<ContactDetail>((IEnumerable<ContactDetail>)nzzr_),
                Editor = new List<ContactDetail>((IEnumerable<ContactDetail>)nzzs_),
                Reviewer = new List<ContactDetail>((IEnumerable<ContactDetail>)nzzt_),
                Endorser = new List<ContactDetail>((IEnumerable<ContactDetail>)nzzu_),
                RelatedArtifact = new List<RelatedArtifact>((IEnumerable<RelatedArtifact>)nzzv_),
                ExposureBackground = nzzw_,
                ExposureVariant = new List<ResourceReference>((IEnumerable<ResourceReference>)nzzx_),
                Outcome = new List<ResourceReference>((IEnumerable<ResourceReference>)nzzy_),
            };

            return nzzz_;
        };
        IEnumerable<Evidence> mzzu_ = context.Operators.Select<Evidence, Evidence>((IEnumerable<Evidence>)mzzs_, mzzt_);
        IEnumerable<Evidence> mzzv_ = context.Operators.Distinct<Evidence>(mzzu_);
        Evidence mzzw_ = context.Operators.SingletonFrom<Evidence>(mzzv_);

        return mzzw_;
    }


    [CqlExpressionDefinition("EvidenceVariableResource")]
    public EvidenceVariable EvidenceVariableResource(CqlContext context, EvidenceVariable arg)
    {
        EvidenceVariable[] ozza_ = [
            arg,
        ];
        EvidenceVariable ozzb_(EvidenceVariable a)
        {
            FhirUri ozzf_ = a?.UrlElement;
            List<Identifier> ozzg_ = a?.Identifier;
            FhirString ozzh_ = a?.VersionElement;
            FhirString ozzi_ = a?.NameElement;
            FhirString ozzj_ = a?.TitleElement;
            FhirString ozzk_ = a?.ShortTitleElement;
            FhirString ozzl_ = a?.SubtitleElement;
            Code<PublicationStatus> ozzm_ = a?.StatusElement;
            FhirDateTime ozzn_ = a?.DateElement;
            FhirString ozzo_ = a?.PublisherElement;
            List<ContactDetail> ozzp_ = a?.Contact;
            Markdown ozzq_ = a?.DescriptionElement;
            List<Annotation> ozzr_ = a?.Note;
            List<UsageContext> ozzs_ = a?.UseContext;
            List<CodeableConcept> ozzt_ = a?.Jurisdiction;
            Markdown ozzu_ = a?.CopyrightElement;
            Date ozzv_ = a?.ApprovalDateElement;
            Date ozzw_ = a?.LastReviewDateElement;
            Period ozzx_ = a?.EffectivePeriod;
            List<CodeableConcept> ozzy_ = a?.Topic;
            List<ContactDetail> ozzz_ = a?.Author;
            List<ContactDetail> pzza_ = a?.Editor;
            List<ContactDetail> pzzb_ = a?.Reviewer;
            List<ContactDetail> pzzc_ = a?.Endorser;
            List<RelatedArtifact> pzzd_ = a?.RelatedArtifact;
            Code<VariableTypeCode> pzze_ = a?.TypeElement;
            List<EvidenceVariable.CharacteristicComponent> pzzf_ = a?.Characteristic;
            EvidenceVariable pzzg_ = new EvidenceVariable
            {
                UrlElement = ozzf_,
                Identifier = new List<Identifier>((IEnumerable<Identifier>)ozzg_),
                VersionElement = ozzh_,
                NameElement = ozzi_,
                TitleElement = ozzj_,
                ShortTitleElement = ozzk_,
                SubtitleElement = ozzl_,
                StatusElement = ozzm_,
                DateElement = ozzn_,
                PublisherElement = ozzo_,
                Contact = new List<ContactDetail>((IEnumerable<ContactDetail>)ozzp_),
                DescriptionElement = ozzq_,
                Note = new List<Annotation>((IEnumerable<Annotation>)ozzr_),
                UseContext = new List<UsageContext>((IEnumerable<UsageContext>)ozzs_),
                Jurisdiction = new List<CodeableConcept>((IEnumerable<CodeableConcept>)ozzt_),
                CopyrightElement = ozzu_,
                ApprovalDateElement = ozzv_,
                LastReviewDateElement = ozzw_,
                EffectivePeriod = ozzx_,
                Topic = new List<CodeableConcept>((IEnumerable<CodeableConcept>)ozzy_),
                Author = new List<ContactDetail>((IEnumerable<ContactDetail>)ozzz_),
                Editor = new List<ContactDetail>((IEnumerable<ContactDetail>)pzza_),
                Reviewer = new List<ContactDetail>((IEnumerable<ContactDetail>)pzzb_),
                Endorser = new List<ContactDetail>((IEnumerable<ContactDetail>)pzzc_),
                RelatedArtifact = new List<RelatedArtifact>((IEnumerable<RelatedArtifact>)pzzd_),
                TypeElement = pzze_,
                Characteristic = new List<EvidenceVariable.CharacteristicComponent>((IEnumerable<EvidenceVariable.CharacteristicComponent>)pzzf_),
            };

            return pzzg_;
        };
        IEnumerable<EvidenceVariable> ozzc_ = context.Operators.Select<EvidenceVariable, EvidenceVariable>((IEnumerable<EvidenceVariable>)ozza_, ozzb_);
        IEnumerable<EvidenceVariable> ozzd_ = context.Operators.Distinct<EvidenceVariable>(ozzc_);
        EvidenceVariable ozze_ = context.Operators.SingletonFrom<EvidenceVariable>(ozzd_);

        return ozze_;
    }


    [CqlExpressionDefinition("ExplanationOfBenefitResource")]
    public ExplanationOfBenefit ExplanationOfBenefitResource(CqlContext context, ExplanationOfBenefit arg)
    {
        ExplanationOfBenefit[] pzzh_ = [
            arg,
        ];
        ExplanationOfBenefit pzzi_(ExplanationOfBenefit a)
        {
            List<Identifier> pzzm_ = a?.Identifier;
            Code<ExplanationOfBenefit.ExplanationOfBenefitStatus> pzzn_ = a?.StatusElement;
            CodeableConcept pzzo_ = a?.Type;
            CodeableConcept pzzp_ = a?.SubType;
            Code<ClaimUseCode> pzzq_ = a?.UseElement;
            ResourceReference pzzr_ = a?.Patient;
            Period pzzs_ = a?.BillablePeriod;
            FhirDateTime pzzt_ = a?.CreatedElement;
            ResourceReference pzzu_ = a?.Enterer;
            ResourceReference pzzv_ = a?.Insurer;
            ResourceReference pzzw_ = a?.Provider;
            CodeableConcept pzzx_ = a?.Priority;
            CodeableConcept pzzy_ = a?.FundsReserveRequested;
            CodeableConcept pzzz_ = a?.FundsReserve;
            List<ExplanationOfBenefit.RelatedClaimComponent> qzza_ = a?.Related;
            ResourceReference qzzb_ = a?.Prescription;
            ResourceReference qzzc_ = a?.OriginalPrescription;
            ExplanationOfBenefit.PayeeComponent qzzd_ = a?.Payee;
            ResourceReference qzze_ = a?.Referral;
            ResourceReference qzzf_ = a?.Facility;
            ResourceReference qzzg_ = a?.Claim;
            ResourceReference qzzh_ = a?.ClaimResponse;
            Code<ClaimProcessingCodes> qzzi_ = a?.OutcomeElement;
            FhirString qzzj_ = a?.DispositionElement;
            List<FhirString> qzzk_ = a?.PreAuthRefElement;
            List<Period> qzzl_ = a?.PreAuthRefPeriod;
            List<ExplanationOfBenefit.CareTeamComponent> qzzm_ = a?.CareTeam;
            List<ExplanationOfBenefit.SupportingInformationComponent> qzzn_ = a?.SupportingInfo;
            List<ExplanationOfBenefit.DiagnosisComponent> qzzo_ = a?.Diagnosis;
            List<ExplanationOfBenefit.ProcedureComponent> qzzp_ = a?.Procedure;
            PositiveInt qzzq_ = a?.PrecedenceElement;
            Integer qzzr_ = context.Operators.Convert<Integer>(qzzq_);
            PositiveInt qzzs_ = context.Operators.Convert<PositiveInt>(qzzr_);
            List<ExplanationOfBenefit.InsuranceComponent> qzzt_ = a?.Insurance;
            ExplanationOfBenefit.AccidentComponent qzzu_ = a?.Accident;
            List<ExplanationOfBenefit.ItemComponent> qzzv_ = a?.Item;
            List<ExplanationOfBenefit.AddedItemComponent> qzzw_ = a?.AddItem;
            List<ExplanationOfBenefit.AdjudicationComponent> qzzx_ = a?.Adjudication;
            List<ExplanationOfBenefit.TotalComponent> qzzy_ = a?.Total;
            ExplanationOfBenefit.PaymentComponent qzzz_ = a?.Payment;
            CodeableConcept rzza_ = a?.FormCode;
            Attachment rzzb_ = a?.Form;
            List<ExplanationOfBenefit.NoteComponent> rzzc_ = a?.ProcessNote;
            Period rzzd_ = a?.BenefitPeriod;
            List<ExplanationOfBenefit.BenefitBalanceComponent> rzze_ = a?.BenefitBalance;
            ExplanationOfBenefit rzzf_ = new ExplanationOfBenefit
            {
                Identifier = new List<Identifier>((IEnumerable<Identifier>)pzzm_),
                StatusElement = pzzn_,
                Type = pzzo_,
                SubType = pzzp_,
                UseElement = pzzq_,
                Patient = pzzr_,
                BillablePeriod = pzzs_,
                CreatedElement = pzzt_,
                Enterer = pzzu_,
                Insurer = pzzv_,
                Provider = pzzw_,
                Priority = pzzx_,
                FundsReserveRequested = pzzy_,
                FundsReserve = pzzz_,
                Related = new List<ExplanationOfBenefit.RelatedClaimComponent>((IEnumerable<ExplanationOfBenefit.RelatedClaimComponent>)qzza_),
                Prescription = qzzb_,
                OriginalPrescription = qzzc_,
                Payee = qzzd_,
                Referral = qzze_,
                Facility = qzzf_,
                Claim = qzzg_,
                ClaimResponse = qzzh_,
                OutcomeElement = qzzi_,
                DispositionElement = qzzj_,
                PreAuthRefElement = new List<FhirString>((IEnumerable<FhirString>)qzzk_),
                PreAuthRefPeriod = new List<Period>((IEnumerable<Period>)qzzl_),
                CareTeam = new List<ExplanationOfBenefit.CareTeamComponent>((IEnumerable<ExplanationOfBenefit.CareTeamComponent>)qzzm_),
                SupportingInfo = new List<ExplanationOfBenefit.SupportingInformationComponent>((IEnumerable<ExplanationOfBenefit.SupportingInformationComponent>)qzzn_),
                Diagnosis = new List<ExplanationOfBenefit.DiagnosisComponent>((IEnumerable<ExplanationOfBenefit.DiagnosisComponent>)qzzo_),
                Procedure = new List<ExplanationOfBenefit.ProcedureComponent>((IEnumerable<ExplanationOfBenefit.ProcedureComponent>)qzzp_),
                PrecedenceElement = qzzs_,
                Insurance = new List<ExplanationOfBenefit.InsuranceComponent>((IEnumerable<ExplanationOfBenefit.InsuranceComponent>)qzzt_),
                Accident = qzzu_,
                Item = new List<ExplanationOfBenefit.ItemComponent>((IEnumerable<ExplanationOfBenefit.ItemComponent>)qzzv_),
                AddItem = new List<ExplanationOfBenefit.AddedItemComponent>((IEnumerable<ExplanationOfBenefit.AddedItemComponent>)qzzw_),
                Adjudication = new List<ExplanationOfBenefit.AdjudicationComponent>((IEnumerable<ExplanationOfBenefit.AdjudicationComponent>)qzzx_),
                Total = new List<ExplanationOfBenefit.TotalComponent>((IEnumerable<ExplanationOfBenefit.TotalComponent>)qzzy_),
                Payment = qzzz_,
                FormCode = rzza_,
                Form = rzzb_,
                ProcessNote = new List<ExplanationOfBenefit.NoteComponent>((IEnumerable<ExplanationOfBenefit.NoteComponent>)rzzc_),
                BenefitPeriod = rzzd_,
                BenefitBalance = new List<ExplanationOfBenefit.BenefitBalanceComponent>((IEnumerable<ExplanationOfBenefit.BenefitBalanceComponent>)rzze_),
            };

            return rzzf_;
        };
        IEnumerable<ExplanationOfBenefit> pzzj_ = context.Operators.Select<ExplanationOfBenefit, ExplanationOfBenefit>((IEnumerable<ExplanationOfBenefit>)pzzh_, pzzi_);
        IEnumerable<ExplanationOfBenefit> pzzk_ = context.Operators.Distinct<ExplanationOfBenefit>(pzzj_);
        ExplanationOfBenefit pzzl_ = context.Operators.SingletonFrom<ExplanationOfBenefit>(pzzk_);

        return pzzl_;
    }


    [CqlExpressionDefinition("FamilyMemberHistoryResource")]
    public FamilyMemberHistory FamilyMemberHistoryResource(CqlContext context, FamilyMemberHistory arg)
    {
        FamilyMemberHistory[] rzzg_ = [
            arg,
        ];
        FamilyMemberHistory rzzh_(FamilyMemberHistory a)
        {
            List<Identifier> rzzl_ = a?.Identifier;
            List<Canonical> rzzm_ = a?.InstantiatesCanonicalElement;
            List<FhirUri> rzzn_ = a?.InstantiatesUriElement;
            Code<FamilyMemberHistory.FamilyHistoryStatus> rzzo_ = a?.StatusElement;
            CodeableConcept rzzp_ = a?.DataAbsentReason;
            ResourceReference rzzq_ = a?.Patient;
            FhirDateTime rzzr_ = a?.DateElement;
            FhirString rzzs_ = a?.NameElement;
            CodeableConcept rzzt_ = a?.Relationship;
            CodeableConcept rzzu_ = a?.Sex;
            DataType rzzv_ = a?.Born;
            DataType rzzw_ = a?.Age;
            FhirBoolean rzzx_ = a?.EstimatedAgeElement;
            DataType rzzy_ = a?.Deceased;
            List<CodeableConcept> rzzz_ = a?.ReasonCode;
            List<ResourceReference> szza_ = a?.ReasonReference;
            List<Annotation> szzb_ = a?.Note;
            List<FamilyMemberHistory.ConditionComponent> szzc_ = a?.Condition;
            FamilyMemberHistory szzd_ = new FamilyMemberHistory
            {
                Identifier = new List<Identifier>((IEnumerable<Identifier>)rzzl_),
                InstantiatesCanonicalElement = new List<Canonical>((IEnumerable<Canonical>)rzzm_),
                InstantiatesUriElement = new List<FhirUri>((IEnumerable<FhirUri>)rzzn_),
                StatusElement = rzzo_,
                DataAbsentReason = rzzp_,
                Patient = rzzq_,
                DateElement = rzzr_,
                NameElement = rzzs_,
                Relationship = rzzt_,
                Sex = rzzu_,
                Born = (DataType)rzzv_,
                Age = (DataType)rzzw_,
                EstimatedAgeElement = rzzx_,
                Deceased = (DataType)rzzy_,
                ReasonCode = new List<CodeableConcept>((IEnumerable<CodeableConcept>)rzzz_),
                ReasonReference = new List<ResourceReference>((IEnumerable<ResourceReference>)szza_),
                Note = new List<Annotation>((IEnumerable<Annotation>)szzb_),
                Condition = new List<FamilyMemberHistory.ConditionComponent>((IEnumerable<FamilyMemberHistory.ConditionComponent>)szzc_),
            };

            return szzd_;
        };
        IEnumerable<FamilyMemberHistory> rzzi_ = context.Operators.Select<FamilyMemberHistory, FamilyMemberHistory>((IEnumerable<FamilyMemberHistory>)rzzg_, rzzh_);
        IEnumerable<FamilyMemberHistory> rzzj_ = context.Operators.Distinct<FamilyMemberHistory>(rzzi_);
        FamilyMemberHistory rzzk_ = context.Operators.SingletonFrom<FamilyMemberHistory>(rzzj_);

        return rzzk_;
    }


    [CqlExpressionDefinition("FlagResource")]
    public Flag FlagResource(CqlContext context, Flag arg)
    {
        Flag[] szze_ = [
            arg,
        ];
        Flag szzf_(Flag a)
        {
            List<Identifier> szzj_ = a?.Identifier;
            Code<Flag.FlagStatus> szzk_ = a?.StatusElement;
            List<CodeableConcept> szzl_ = a?.Category;
            CodeableConcept szzm_ = a?.Code;
            ResourceReference szzn_ = a?.Subject;
            Period szzo_ = a?.Period;
            ResourceReference szzp_ = a?.Encounter;
            ResourceReference szzq_ = a?.Author;
            Flag szzr_ = new Flag
            {
                Identifier = new List<Identifier>((IEnumerable<Identifier>)szzj_),
                StatusElement = szzk_,
                Category = new List<CodeableConcept>((IEnumerable<CodeableConcept>)szzl_),
                Code = szzm_,
                Subject = szzn_,
                Period = szzo_,
                Encounter = szzp_,
                Author = szzq_,
            };

            return szzr_;
        };
        IEnumerable<Flag> szzg_ = context.Operators.Select<Flag, Flag>((IEnumerable<Flag>)szze_, szzf_);
        IEnumerable<Flag> szzh_ = context.Operators.Distinct<Flag>(szzg_);
        Flag szzi_ = context.Operators.SingletonFrom<Flag>(szzh_);

        return szzi_;
    }


    [CqlExpressionDefinition("GoalResource")]
    public Goal GoalResource(CqlContext context, Goal arg)
    {
        Goal[] szzs_ = [
            arg,
        ];
        Goal szzt_(Goal a)
        {
            List<Identifier> szzx_ = a?.Identifier;
            Code<Goal.GoalLifecycleStatus> szzy_ = a?.LifecycleStatusElement;
            CodeableConcept szzz_ = a?.AchievementStatus;
            List<CodeableConcept> tzza_ = a?.Category;
            CodeableConcept tzzb_ = a?.Priority;
            CodeableConcept tzzc_ = a?.Description;
            ResourceReference tzzd_ = a?.Subject;
            DataType tzze_ = a?.Start;
            List<Goal.TargetComponent> tzzf_ = a?.Target;
            Date tzzg_ = a?.StatusDateElement;
            FhirString tzzh_ = a?.StatusReasonElement;
            ResourceReference tzzi_ = a?.ExpressedBy;
            List<ResourceReference> tzzj_ = a?.Addresses;
            List<Annotation> tzzk_ = a?.Note;
            List<CodeableConcept> tzzl_ = a?.OutcomeCode;
            List<ResourceReference> tzzm_ = a?.OutcomeReference;
            Goal tzzn_ = new Goal
            {
                Identifier = new List<Identifier>((IEnumerable<Identifier>)szzx_),
                LifecycleStatusElement = szzy_,
                AchievementStatus = szzz_,
                Category = new List<CodeableConcept>((IEnumerable<CodeableConcept>)tzza_),
                Priority = tzzb_,
                Description = tzzc_,
                Subject = tzzd_,
                Start = (DataType)tzze_,
                Target = new List<Goal.TargetComponent>((IEnumerable<Goal.TargetComponent>)tzzf_),
                StatusDateElement = tzzg_,
                StatusReasonElement = tzzh_,
                ExpressedBy = tzzi_,
                Addresses = new List<ResourceReference>((IEnumerable<ResourceReference>)tzzj_),
                Note = new List<Annotation>((IEnumerable<Annotation>)tzzk_),
                OutcomeCode = new List<CodeableConcept>((IEnumerable<CodeableConcept>)tzzl_),
                OutcomeReference = new List<ResourceReference>((IEnumerable<ResourceReference>)tzzm_),
            };

            return tzzn_;
        };
        IEnumerable<Goal> szzu_ = context.Operators.Select<Goal, Goal>((IEnumerable<Goal>)szzs_, szzt_);
        IEnumerable<Goal> szzv_ = context.Operators.Distinct<Goal>(szzu_);
        Goal szzw_ = context.Operators.SingletonFrom<Goal>(szzv_);

        return szzw_;
    }


    [CqlExpressionDefinition("GroupResource")]
    public Group GroupResource(CqlContext context, Group arg)
    {
        Group[] tzzo_ = [
            arg,
        ];
        Group tzzp_(Group a)
        {
            List<Identifier> tzzt_ = a?.Identifier;
            FhirBoolean tzzu_ = a?.ActiveElement;
            Code<Group.GroupType> tzzv_ = a?.TypeElement;
            FhirBoolean tzzw_ = a?.ActualElement;
            CodeableConcept tzzx_ = a?.Code;
            FhirString tzzy_ = a?.NameElement;
            UnsignedInt tzzz_ = a?.QuantityElement;
            Integer uzza_ = context.Operators.Convert<Integer>(tzzz_);
            UnsignedInt uzzb_ = context.Operators.Convert<UnsignedInt>(uzza_);
            ResourceReference uzzc_ = a?.ManagingEntity;
            List<Group.CharacteristicComponent> uzzd_ = a?.Characteristic;
            List<Group.MemberComponent> uzze_ = a?.Member;
            Group uzzf_ = new Group
            {
                Identifier = new List<Identifier>((IEnumerable<Identifier>)tzzt_),
                ActiveElement = tzzu_,
                TypeElement = tzzv_,
                ActualElement = tzzw_,
                Code = tzzx_,
                NameElement = tzzy_,
                QuantityElement = uzzb_,
                ManagingEntity = uzzc_,
                Characteristic = new List<Group.CharacteristicComponent>((IEnumerable<Group.CharacteristicComponent>)uzzd_),
                Member = new List<Group.MemberComponent>((IEnumerable<Group.MemberComponent>)uzze_),
            };

            return uzzf_;
        };
        IEnumerable<Group> tzzq_ = context.Operators.Select<Group, Group>((IEnumerable<Group>)tzzo_, tzzp_);
        IEnumerable<Group> tzzr_ = context.Operators.Distinct<Group>(tzzq_);
        Group tzzs_ = context.Operators.SingletonFrom<Group>(tzzr_);

        return tzzs_;
    }


    [CqlExpressionDefinition("GuidanceResponseResource")]
    public GuidanceResponse GuidanceResponseResource(CqlContext context, GuidanceResponse arg)
    {
        GuidanceResponse[] uzzg_ = [
            arg,
        ];
        GuidanceResponse uzzh_(GuidanceResponse a)
        {
            Identifier uzzl_ = a?.RequestIdentifier;
            List<Identifier> uzzm_ = a?.Identifier;
            DataType uzzn_ = a?.Module;
            Code<GuidanceResponse.GuidanceResponseStatus> uzzo_ = a?.StatusElement;
            ResourceReference uzzp_ = a?.Subject;
            ResourceReference uzzq_ = a?.Encounter;
            FhirDateTime uzzr_ = a?.OccurrenceDateTimeElement;
            ResourceReference uzzs_ = a?.Performer;
            List<CodeableConcept> uzzt_ = a?.ReasonCode;
            List<ResourceReference> uzzu_ = a?.ReasonReference;
            List<Annotation> uzzv_ = a?.Note;
            List<ResourceReference> uzzw_ = a?.EvaluationMessage;
            ResourceReference uzzx_ = a?.OutputParameters;
            ResourceReference uzzy_ = a?.Result;
            List<DataRequirement> uzzz_ = a?.DataRequirement;
            GuidanceResponse vzza_ = new GuidanceResponse
            {
                RequestIdentifier = uzzl_,
                Identifier = new List<Identifier>((IEnumerable<Identifier>)uzzm_),
                Module = (DataType)uzzn_,
                StatusElement = uzzo_,
                Subject = uzzp_,
                Encounter = uzzq_,
                OccurrenceDateTimeElement = uzzr_,
                Performer = uzzs_,
                ReasonCode = new List<CodeableConcept>((IEnumerable<CodeableConcept>)uzzt_),
                ReasonReference = new List<ResourceReference>((IEnumerable<ResourceReference>)uzzu_),
                Note = new List<Annotation>((IEnumerable<Annotation>)uzzv_),
                EvaluationMessage = new List<ResourceReference>((IEnumerable<ResourceReference>)uzzw_),
                OutputParameters = uzzx_,
                Result = uzzy_,
                DataRequirement = new List<DataRequirement>((IEnumerable<DataRequirement>)uzzz_),
            };

            return vzza_;
        };
        IEnumerable<GuidanceResponse> uzzi_ = context.Operators.Select<GuidanceResponse, GuidanceResponse>((IEnumerable<GuidanceResponse>)uzzg_, uzzh_);
        IEnumerable<GuidanceResponse> uzzj_ = context.Operators.Distinct<GuidanceResponse>(uzzi_);
        GuidanceResponse uzzk_ = context.Operators.SingletonFrom<GuidanceResponse>(uzzj_);

        return uzzk_;
    }


    [CqlExpressionDefinition("HealthcareServiceResource")]
    public HealthcareService HealthcareServiceResource(CqlContext context, HealthcareService arg)
    {
        HealthcareService[] vzzb_ = [
            arg,
        ];
        HealthcareService vzzc_(HealthcareService a)
        {
            List<Identifier> vzzg_ = a?.Identifier;
            FhirBoolean vzzh_ = a?.ActiveElement;
            ResourceReference vzzi_ = a?.ProvidedBy;
            List<CodeableConcept> vzzj_ = a?.Category;
            List<CodeableConcept> vzzk_ = a?.Type;
            List<CodeableConcept> vzzl_ = a?.Specialty;
            List<ResourceReference> vzzm_ = a?.Location;
            FhirString vzzn_ = a?.NameElement;
            FhirString vzzo_ = a?.CommentElement;
            Markdown vzzp_ = a?.ExtraDetailsElement;
            Attachment vzzq_ = a?.Photo;
            List<ContactPoint> vzzr_ = a?.Telecom;
            List<ResourceReference> vzzs_ = a?.CoverageArea;
            List<CodeableConcept> vzzt_ = a?.ServiceProvisionCode;
            List<HealthcareService.EligibilityComponent> vzzu_ = a?.Eligibility;
            List<CodeableConcept> vzzv_ = a?.Program;
            List<CodeableConcept> vzzw_ = a?.Characteristic;
            List<CodeableConcept> vzzx_ = a?.Communication;
            List<CodeableConcept> vzzy_ = a?.ReferralMethod;
            FhirBoolean vzzz_ = a?.AppointmentRequiredElement;
            List<HealthcareService.AvailableTimeComponent> wzza_ = a?.AvailableTime;
            List<HealthcareService.NotAvailableComponent> wzzb_ = a?.NotAvailable;
            FhirString wzzc_ = a?.AvailabilityExceptionsElement;
            List<ResourceReference> wzzd_ = a?.Endpoint;
            HealthcareService wzze_ = new HealthcareService
            {
                Identifier = new List<Identifier>((IEnumerable<Identifier>)vzzg_),
                ActiveElement = vzzh_,
                ProvidedBy = vzzi_,
                Category = new List<CodeableConcept>((IEnumerable<CodeableConcept>)vzzj_),
                Type = new List<CodeableConcept>((IEnumerable<CodeableConcept>)vzzk_),
                Specialty = new List<CodeableConcept>((IEnumerable<CodeableConcept>)vzzl_),
                Location = new List<ResourceReference>((IEnumerable<ResourceReference>)vzzm_),
                NameElement = vzzn_,
                CommentElement = vzzo_,
                ExtraDetailsElement = vzzp_,
                Photo = vzzq_,
                Telecom = new List<ContactPoint>((IEnumerable<ContactPoint>)vzzr_),
                CoverageArea = new List<ResourceReference>((IEnumerable<ResourceReference>)vzzs_),
                ServiceProvisionCode = new List<CodeableConcept>((IEnumerable<CodeableConcept>)vzzt_),
                Eligibility = new List<HealthcareService.EligibilityComponent>((IEnumerable<HealthcareService.EligibilityComponent>)vzzu_),
                Program = new List<CodeableConcept>((IEnumerable<CodeableConcept>)vzzv_),
                Characteristic = new List<CodeableConcept>((IEnumerable<CodeableConcept>)vzzw_),
                Communication = new List<CodeableConcept>((IEnumerable<CodeableConcept>)vzzx_),
                ReferralMethod = new List<CodeableConcept>((IEnumerable<CodeableConcept>)vzzy_),
                AppointmentRequiredElement = vzzz_,
                AvailableTime = new List<HealthcareService.AvailableTimeComponent>((IEnumerable<HealthcareService.AvailableTimeComponent>)wzza_),
                NotAvailable = new List<HealthcareService.NotAvailableComponent>((IEnumerable<HealthcareService.NotAvailableComponent>)wzzb_),
                AvailabilityExceptionsElement = wzzc_,
                Endpoint = new List<ResourceReference>((IEnumerable<ResourceReference>)wzzd_),
            };

            return wzze_;
        };
        IEnumerable<HealthcareService> vzzd_ = context.Operators.Select<HealthcareService, HealthcareService>((IEnumerable<HealthcareService>)vzzb_, vzzc_);
        IEnumerable<HealthcareService> vzze_ = context.Operators.Distinct<HealthcareService>(vzzd_);
        HealthcareService vzzf_ = context.Operators.SingletonFrom<HealthcareService>(vzze_);

        return vzzf_;
    }


    [CqlExpressionDefinition("ImagingStudyResource")]
    public ImagingStudy ImagingStudyResource(CqlContext context, ImagingStudy arg)
    {
        ImagingStudy[] wzzf_ = [
            arg,
        ];
        ImagingStudy wzzg_(ImagingStudy a)
        {
            List<Identifier> wzzk_ = a?.Identifier;
            Code<ImagingStudy.ImagingStudyStatus> wzzl_ = a?.StatusElement;
            List<Coding> wzzm_ = a?.Modality;
            ResourceReference wzzn_ = a?.Subject;
            ResourceReference wzzo_ = a?.Encounter;
            FhirDateTime wzzp_ = a?.StartedElement;
            List<ResourceReference> wzzq_ = a?.BasedOn;
            ResourceReference wzzr_ = a?.Referrer;
            List<ResourceReference> wzzs_ = a?.Interpreter;
            List<ResourceReference> wzzt_ = a?.Endpoint;
            UnsignedInt wzzu_ = a?.NumberOfSeriesElement;
            Integer wzzv_ = context.Operators.Convert<Integer>(wzzu_);
            UnsignedInt wzzw_ = context.Operators.Convert<UnsignedInt>(wzzv_);
            UnsignedInt wzzx_ = a?.NumberOfInstancesElement;
            Integer wzzy_ = context.Operators.Convert<Integer>(wzzx_);
            UnsignedInt wzzz_ = context.Operators.Convert<UnsignedInt>(wzzy_);
            ResourceReference xzza_ = a?.ProcedureReference;
            List<CodeableConcept> xzzb_ = a?.ProcedureCode;
            ResourceReference xzzc_ = a?.Location;
            List<CodeableConcept> xzzd_ = a?.ReasonCode;
            List<ResourceReference> xzze_ = a?.ReasonReference;
            List<Annotation> xzzf_ = a?.Note;
            FhirString xzzg_ = a?.DescriptionElement;
            List<ImagingStudy.SeriesComponent> xzzh_ = a?.Series;
            ImagingStudy xzzi_ = new ImagingStudy
            {
                Identifier = new List<Identifier>((IEnumerable<Identifier>)wzzk_),
                StatusElement = wzzl_,
                Modality = new List<Coding>((IEnumerable<Coding>)wzzm_),
                Subject = wzzn_,
                Encounter = wzzo_,
                StartedElement = wzzp_,
                BasedOn = new List<ResourceReference>((IEnumerable<ResourceReference>)wzzq_),
                Referrer = wzzr_,
                Interpreter = new List<ResourceReference>((IEnumerable<ResourceReference>)wzzs_),
                Endpoint = new List<ResourceReference>((IEnumerable<ResourceReference>)wzzt_),
                NumberOfSeriesElement = wzzw_,
                NumberOfInstancesElement = wzzz_,
                ProcedureReference = xzza_,
                ProcedureCode = new List<CodeableConcept>((IEnumerable<CodeableConcept>)xzzb_),
                Location = xzzc_,
                ReasonCode = new List<CodeableConcept>((IEnumerable<CodeableConcept>)xzzd_),
                ReasonReference = new List<ResourceReference>((IEnumerable<ResourceReference>)xzze_),
                Note = new List<Annotation>((IEnumerable<Annotation>)xzzf_),
                DescriptionElement = xzzg_,
                Series = new List<ImagingStudy.SeriesComponent>((IEnumerable<ImagingStudy.SeriesComponent>)xzzh_),
            };

            return xzzi_;
        };
        IEnumerable<ImagingStudy> wzzh_ = context.Operators.Select<ImagingStudy, ImagingStudy>((IEnumerable<ImagingStudy>)wzzf_, wzzg_);
        IEnumerable<ImagingStudy> wzzi_ = context.Operators.Distinct<ImagingStudy>(wzzh_);
        ImagingStudy wzzj_ = context.Operators.SingletonFrom<ImagingStudy>(wzzi_);

        return wzzj_;
    }


    [CqlExpressionDefinition("ImmunizationResource")]
    public Immunization ImmunizationResource(CqlContext context, Immunization arg)
    {
        Immunization[] xzzj_ = [
            arg,
        ];
        Immunization xzzk_(Immunization a)
        {
            List<Identifier> xzzo_ = a?.Identifier;
            Code<Immunization.ImmunizationStatusCodes> xzzp_ = a?.StatusElement;
            CodeableConcept xzzq_ = a?.StatusReason;
            CodeableConcept xzzr_ = a?.VaccineCode;
            ResourceReference xzzs_ = a?.Patient;
            ResourceReference xzzt_ = a?.Encounter;
            DataType xzzu_ = a?.Occurrence;
            FhirDateTime xzzv_ = a?.RecordedElement;
            FhirBoolean xzzw_ = a?.PrimarySourceElement;
            CodeableConcept xzzx_ = a?.ReportOrigin;
            ResourceReference xzzy_ = a?.Location;
            ResourceReference xzzz_ = a?.Manufacturer;
            FhirString yzza_ = a?.LotNumberElement;
            Date yzzb_ = a?.ExpirationDateElement;
            CodeableConcept yzzc_ = a?.Site;
            CodeableConcept yzzd_ = a?.Route;
            Quantity yzze_ = a?.DoseQuantity;
            List<Immunization.PerformerComponent> yzzf_ = a?.Performer;
            List<Annotation> yzzg_ = a?.Note;
            List<CodeableConcept> yzzh_ = a?.ReasonCode;
            List<ResourceReference> yzzi_ = a?.ReasonReference;
            FhirBoolean yzzj_ = a?.IsSubpotentElement;
            List<CodeableConcept> yzzk_ = a?.SubpotentReason;
            List<Immunization.EducationComponent> yzzl_ = a?.Education;
            List<CodeableConcept> yzzm_ = a?.ProgramEligibility;
            CodeableConcept yzzn_ = a?.FundingSource;
            List<Immunization.ReactionComponent> yzzo_ = a?.Reaction;
            List<Immunization.ProtocolAppliedComponent> yzzp_ = a?.ProtocolApplied;
            Immunization yzzq_ = new Immunization
            {
                Identifier = new List<Identifier>((IEnumerable<Identifier>)xzzo_),
                StatusElement = xzzp_,
                StatusReason = xzzq_,
                VaccineCode = xzzr_,
                Patient = xzzs_,
                Encounter = xzzt_,
                Occurrence = (DataType)xzzu_,
                RecordedElement = xzzv_,
                PrimarySourceElement = xzzw_,
                ReportOrigin = xzzx_,
                Location = xzzy_,
                Manufacturer = xzzz_,
                LotNumberElement = yzza_,
                ExpirationDateElement = yzzb_,
                Site = yzzc_,
                Route = yzzd_,
                DoseQuantity = yzze_,
                Performer = new List<Immunization.PerformerComponent>((IEnumerable<Immunization.PerformerComponent>)yzzf_),
                Note = new List<Annotation>((IEnumerable<Annotation>)yzzg_),
                ReasonCode = new List<CodeableConcept>((IEnumerable<CodeableConcept>)yzzh_),
                ReasonReference = new List<ResourceReference>((IEnumerable<ResourceReference>)yzzi_),
                IsSubpotentElement = yzzj_,
                SubpotentReason = new List<CodeableConcept>((IEnumerable<CodeableConcept>)yzzk_),
                Education = new List<Immunization.EducationComponent>((IEnumerable<Immunization.EducationComponent>)yzzl_),
                ProgramEligibility = new List<CodeableConcept>((IEnumerable<CodeableConcept>)yzzm_),
                FundingSource = yzzn_,
                Reaction = new List<Immunization.ReactionComponent>((IEnumerable<Immunization.ReactionComponent>)yzzo_),
                ProtocolApplied = new List<Immunization.ProtocolAppliedComponent>((IEnumerable<Immunization.ProtocolAppliedComponent>)yzzp_),
            };

            return yzzq_;
        };
        IEnumerable<Immunization> xzzl_ = context.Operators.Select<Immunization, Immunization>((IEnumerable<Immunization>)xzzj_, xzzk_);
        IEnumerable<Immunization> xzzm_ = context.Operators.Distinct<Immunization>(xzzl_);
        Immunization xzzn_ = context.Operators.SingletonFrom<Immunization>(xzzm_);

        return xzzn_;
    }


    [CqlExpressionDefinition("ImmunizationEvaluationResource")]
    public ImmunizationEvaluation ImmunizationEvaluationResource(CqlContext context, ImmunizationEvaluation arg)
    {
        ImmunizationEvaluation[] yzzr_ = [
            arg,
        ];
        ImmunizationEvaluation yzzs_(ImmunizationEvaluation a)
        {
            List<Identifier> yzzw_ = a?.Identifier;
            Code<ImmunizationEvaluation.ImmunizationEvaluationStatusCodes> yzzx_ = a?.StatusElement;
            ResourceReference yzzy_ = a?.Patient;
            FhirDateTime yzzz_ = a?.DateElement;
            ResourceReference zzza_ = a?.Authority;
            CodeableConcept zzzb_ = a?.TargetDisease;
            ResourceReference zzzc_ = a?.ImmunizationEvent;
            CodeableConcept zzzd_ = a?.DoseStatus;
            List<CodeableConcept> zzze_ = a?.DoseStatusReason;
            FhirString zzzf_ = a?.DescriptionElement;
            FhirString zzzg_ = a?.SeriesElement;
            DataType zzzh_ = a?.DoseNumber;
            DataType zzzi_ = a?.SeriesDoses;
            ImmunizationEvaluation zzzj_ = new ImmunizationEvaluation
            {
                Identifier = new List<Identifier>((IEnumerable<Identifier>)yzzw_),
                StatusElement = yzzx_,
                Patient = yzzy_,
                DateElement = yzzz_,
                Authority = zzza_,
                TargetDisease = zzzb_,
                ImmunizationEvent = zzzc_,
                DoseStatus = zzzd_,
                DoseStatusReason = new List<CodeableConcept>((IEnumerable<CodeableConcept>)zzze_),
                DescriptionElement = zzzf_,
                SeriesElement = zzzg_,
                DoseNumber = (DataType)zzzh_,
                SeriesDoses = (DataType)zzzi_,
            };

            return zzzj_;
        };
        IEnumerable<ImmunizationEvaluation> yzzt_ = context.Operators.Select<ImmunizationEvaluation, ImmunizationEvaluation>((IEnumerable<ImmunizationEvaluation>)yzzr_, yzzs_);
        IEnumerable<ImmunizationEvaluation> yzzu_ = context.Operators.Distinct<ImmunizationEvaluation>(yzzt_);
        ImmunizationEvaluation yzzv_ = context.Operators.SingletonFrom<ImmunizationEvaluation>(yzzu_);

        return yzzv_;
    }


    [CqlExpressionDefinition("ImmunizationRecommendationResource")]
    public ImmunizationRecommendation ImmunizationRecommendationResource(CqlContext context, ImmunizationRecommendation arg)
    {
        ImmunizationRecommendation[] zzzk_ = [
            arg,
        ];
        ImmunizationRecommendation zzzl_(ImmunizationRecommendation a)
        {
            List<Identifier> zzzp_ = a?.Identifier;
            ResourceReference zzzq_ = a?.Patient;
            FhirDateTime zzzr_ = a?.DateElement;
            ResourceReference zzzs_ = a?.Authority;
            List<ImmunizationRecommendation.RecommendationComponent> zzzt_ = a?.Recommendation;
            ImmunizationRecommendation zzzu_ = new ImmunizationRecommendation
            {
                Identifier = new List<Identifier>((IEnumerable<Identifier>)zzzp_),
                Patient = zzzq_,
                DateElement = zzzr_,
                Authority = zzzs_,
                Recommendation = new List<ImmunizationRecommendation.RecommendationComponent>((IEnumerable<ImmunizationRecommendation.RecommendationComponent>)zzzt_),
            };

            return zzzu_;
        };
        IEnumerable<ImmunizationRecommendation> zzzm_ = context.Operators.Select<ImmunizationRecommendation, ImmunizationRecommendation>((IEnumerable<ImmunizationRecommendation>)zzzk_, zzzl_);
        IEnumerable<ImmunizationRecommendation> zzzn_ = context.Operators.Distinct<ImmunizationRecommendation>(zzzm_);
        ImmunizationRecommendation zzzo_ = context.Operators.SingletonFrom<ImmunizationRecommendation>(zzzn_);

        return zzzo_;
    }


    [CqlExpressionDefinition("InsurancePlanResource")]
    public InsurancePlan InsurancePlanResource(CqlContext context, InsurancePlan arg)
    {
        InsurancePlan[] zzzv_ = [
            arg,
        ];
        InsurancePlan zzzw_(InsurancePlan a)
        {
            List<Identifier> azzza_ = a?.Identifier;
            Code<PublicationStatus> azzzb_ = a?.StatusElement;
            List<CodeableConcept> azzzc_ = a?.Type;
            FhirString azzzd_ = a?.NameElement;
            List<FhirString> azzze_ = a?.AliasElement;
            Period azzzf_ = a?.Period;
            ResourceReference azzzg_ = a?.OwnedBy;
            ResourceReference azzzh_ = a?.AdministeredBy;
            List<ResourceReference> azzzi_ = a?.CoverageArea;
            List<InsurancePlan.ContactComponent> azzzj_ = a?.Contact;
            List<ResourceReference> azzzk_ = a?.Endpoint;
            List<ResourceReference> azzzl_ = a?.Network;
            List<InsurancePlan.CoverageComponent> azzzm_ = a?.Coverage;
            List<InsurancePlan.PlanComponent> azzzn_ = a?.Plan;
            InsurancePlan azzzo_ = new InsurancePlan
            {
                Identifier = new List<Identifier>((IEnumerable<Identifier>)azzza_),
                StatusElement = azzzb_,
                Type = new List<CodeableConcept>((IEnumerable<CodeableConcept>)azzzc_),
                NameElement = azzzd_,
                AliasElement = new List<FhirString>((IEnumerable<FhirString>)azzze_),
                Period = azzzf_,
                OwnedBy = azzzg_,
                AdministeredBy = azzzh_,
                CoverageArea = new List<ResourceReference>((IEnumerable<ResourceReference>)azzzi_),
                Contact = new List<InsurancePlan.ContactComponent>((IEnumerable<InsurancePlan.ContactComponent>)azzzj_),
                Endpoint = new List<ResourceReference>((IEnumerable<ResourceReference>)azzzk_),
                Network = new List<ResourceReference>((IEnumerable<ResourceReference>)azzzl_),
                Coverage = new List<InsurancePlan.CoverageComponent>((IEnumerable<InsurancePlan.CoverageComponent>)azzzm_),
                Plan = new List<InsurancePlan.PlanComponent>((IEnumerable<InsurancePlan.PlanComponent>)azzzn_),
            };

            return azzzo_;
        };
        IEnumerable<InsurancePlan> zzzx_ = context.Operators.Select<InsurancePlan, InsurancePlan>((IEnumerable<InsurancePlan>)zzzv_, zzzw_);
        IEnumerable<InsurancePlan> zzzy_ = context.Operators.Distinct<InsurancePlan>(zzzx_);
        InsurancePlan zzzz_ = context.Operators.SingletonFrom<InsurancePlan>(zzzy_);

        return zzzz_;
    }


    [CqlExpressionDefinition("InvoiceResource")]
    public Invoice InvoiceResource(CqlContext context, Invoice arg)
    {
        Invoice[] azzzp_ = [
            arg,
        ];
        Invoice azzzq_(Invoice a)
        {
            List<Identifier> azzzu_ = a?.Identifier;
            Code<Invoice.InvoiceStatus> azzzv_ = a?.StatusElement;
            FhirString azzzw_ = a?.CancelledReasonElement;
            CodeableConcept azzzx_ = a?.Type;
            ResourceReference azzzy_ = a?.Subject;
            ResourceReference azzzz_ = a?.Recipient;
            FhirDateTime bzzza_ = a?.DateElement;
            List<Invoice.ParticipantComponent> bzzzb_ = a?.Participant;
            ResourceReference bzzzc_ = a?.Issuer;
            ResourceReference bzzzd_ = a?.Account;
            List<Invoice.LineItemComponent> bzzze_ = a?.LineItem;
            List<Invoice.PriceComponentComponent> bzzzf_ = a?.TotalPriceComponent;
            Money bzzzg_ = a?.TotalNet;
            Money bzzzh_ = a?.TotalGross;
            Markdown bzzzi_ = a?.PaymentTermsElement;
            List<Annotation> bzzzj_ = a?.Note;
            Invoice bzzzk_ = new Invoice
            {
                Identifier = new List<Identifier>((IEnumerable<Identifier>)azzzu_),
                StatusElement = azzzv_,
                CancelledReasonElement = azzzw_,
                Type = azzzx_,
                Subject = azzzy_,
                Recipient = azzzz_,
                DateElement = bzzza_,
                Participant = new List<Invoice.ParticipantComponent>((IEnumerable<Invoice.ParticipantComponent>)bzzzb_),
                Issuer = bzzzc_,
                Account = bzzzd_,
                LineItem = new List<Invoice.LineItemComponent>((IEnumerable<Invoice.LineItemComponent>)bzzze_),
                TotalPriceComponent = new List<Invoice.PriceComponentComponent>((IEnumerable<Invoice.PriceComponentComponent>)bzzzf_),
                TotalNet = bzzzg_,
                TotalGross = bzzzh_,
                PaymentTermsElement = bzzzi_,
                Note = new List<Annotation>((IEnumerable<Annotation>)bzzzj_),
            };

            return bzzzk_;
        };
        IEnumerable<Invoice> azzzr_ = context.Operators.Select<Invoice, Invoice>((IEnumerable<Invoice>)azzzp_, azzzq_);
        IEnumerable<Invoice> azzzs_ = context.Operators.Distinct<Invoice>(azzzr_);
        Invoice azzzt_ = context.Operators.SingletonFrom<Invoice>(azzzs_);

        return azzzt_;
    }


    [CqlExpressionDefinition("LibraryResource")]
    public Library LibraryResource(CqlContext context, Library arg)
    {
        Library[] bzzzl_ = [
            arg,
        ];
        Library bzzzm_(Library a)
        {
            FhirUri bzzzq_ = a?.UrlElement;
            List<Identifier> bzzzr_ = a?.Identifier;
            FhirString bzzzs_ = a?.VersionElement;
            FhirString bzzzt_ = a?.NameElement;
            FhirString bzzzu_ = a?.TitleElement;
            FhirString bzzzv_ = a?.SubtitleElement;
            Code<PublicationStatus> bzzzw_ = a?.StatusElement;
            FhirBoolean bzzzx_ = a?.ExperimentalElement;
            CodeableConcept bzzzy_ = a?.Type;
            DataType bzzzz_ = a?.Subject;
            FhirDateTime czzza_ = a?.DateElement;
            FhirString czzzb_ = a?.PublisherElement;
            List<ContactDetail> czzzc_ = a?.Contact;
            Markdown czzzd_ = a?.DescriptionElement;
            List<UsageContext> czzze_ = a?.UseContext;
            List<CodeableConcept> czzzf_ = a?.Jurisdiction;
            Markdown czzzg_ = a?.PurposeElement;
            FhirString czzzh_ = a?.UsageElement;
            Markdown czzzi_ = a?.CopyrightElement;
            Date czzzj_ = a?.ApprovalDateElement;
            Date czzzk_ = a?.LastReviewDateElement;
            Period czzzl_ = a?.EffectivePeriod;
            List<CodeableConcept> czzzm_ = a?.Topic;
            List<ContactDetail> czzzn_ = a?.Author;
            List<ContactDetail> czzzo_ = a?.Editor;
            List<ContactDetail> czzzp_ = a?.Reviewer;
            List<ContactDetail> czzzq_ = a?.Endorser;
            List<RelatedArtifact> czzzr_ = a?.RelatedArtifact;
            List<ParameterDefinition> czzzs_ = a?.Parameter;
            List<DataRequirement> czzzt_ = a?.DataRequirement;
            List<Attachment> czzzu_ = a?.Content;
            Library czzzv_ = new Library
            {
                UrlElement = bzzzq_,
                Identifier = new List<Identifier>((IEnumerable<Identifier>)bzzzr_),
                VersionElement = bzzzs_,
                NameElement = bzzzt_,
                TitleElement = bzzzu_,
                SubtitleElement = bzzzv_,
                StatusElement = bzzzw_,
                ExperimentalElement = bzzzx_,
                Type = bzzzy_,
                Subject = (DataType)bzzzz_,
                DateElement = czzza_,
                PublisherElement = czzzb_,
                Contact = new List<ContactDetail>((IEnumerable<ContactDetail>)czzzc_),
                DescriptionElement = czzzd_,
                UseContext = new List<UsageContext>((IEnumerable<UsageContext>)czzze_),
                Jurisdiction = new List<CodeableConcept>((IEnumerable<CodeableConcept>)czzzf_),
                PurposeElement = czzzg_,
                UsageElement = czzzh_,
                CopyrightElement = czzzi_,
                ApprovalDateElement = czzzj_,
                LastReviewDateElement = czzzk_,
                EffectivePeriod = czzzl_,
                Topic = new List<CodeableConcept>((IEnumerable<CodeableConcept>)czzzm_),
                Author = new List<ContactDetail>((IEnumerable<ContactDetail>)czzzn_),
                Editor = new List<ContactDetail>((IEnumerable<ContactDetail>)czzzo_),
                Reviewer = new List<ContactDetail>((IEnumerable<ContactDetail>)czzzp_),
                Endorser = new List<ContactDetail>((IEnumerable<ContactDetail>)czzzq_),
                RelatedArtifact = new List<RelatedArtifact>((IEnumerable<RelatedArtifact>)czzzr_),
                Parameter = new List<ParameterDefinition>((IEnumerable<ParameterDefinition>)czzzs_),
                DataRequirement = new List<DataRequirement>((IEnumerable<DataRequirement>)czzzt_),
                Content = new List<Attachment>((IEnumerable<Attachment>)czzzu_),
            };

            return czzzv_;
        };
        IEnumerable<Library> bzzzn_ = context.Operators.Select<Library, Library>((IEnumerable<Library>)bzzzl_, bzzzm_);
        IEnumerable<Library> bzzzo_ = context.Operators.Distinct<Library>(bzzzn_);
        Library bzzzp_ = context.Operators.SingletonFrom<Library>(bzzzo_);

        return bzzzp_;
    }


    [CqlExpressionDefinition("LinkageResource")]
    public Linkage LinkageResource(CqlContext context, Linkage arg)
    {
        Linkage[] czzzw_ = [
            arg,
        ];
        Linkage czzzx_(Linkage a)
        {
            FhirBoolean dzzzb_ = a?.ActiveElement;
            ResourceReference dzzzc_ = a?.Author;
            List<Linkage.ItemComponent> dzzzd_ = a?.Item;
            Linkage dzzze_ = new Linkage
            {
                ActiveElement = dzzzb_,
                Author = dzzzc_,
                Item = new List<Linkage.ItemComponent>((IEnumerable<Linkage.ItemComponent>)dzzzd_),
            };

            return dzzze_;
        };
        IEnumerable<Linkage> czzzy_ = context.Operators.Select<Linkage, Linkage>((IEnumerable<Linkage>)czzzw_, czzzx_);
        IEnumerable<Linkage> czzzz_ = context.Operators.Distinct<Linkage>(czzzy_);
        Linkage dzzza_ = context.Operators.SingletonFrom<Linkage>(czzzz_);

        return dzzza_;
    }


    [CqlExpressionDefinition("LocationResource")]
    public Location LocationResource(CqlContext context, Location arg)
    {
        Location[] dzzzf_ = [
            arg,
        ];
        Location dzzzg_(Location a)
        {
            List<Identifier> dzzzk_ = a?.Identifier;
            Code<Location.LocationStatus> dzzzl_ = a?.StatusElement;
            Coding dzzzm_ = a?.OperationalStatus;
            FhirString dzzzn_ = a?.NameElement;
            List<FhirString> dzzzo_ = a?.AliasElement;
            FhirString dzzzp_ = a?.DescriptionElement;
            Code<Location.LocationMode> dzzzq_ = a?.ModeElement;
            List<CodeableConcept> dzzzr_ = a?.Type;
            List<ContactPoint> dzzzs_ = a?.Telecom;
            Address dzzzt_ = a?.Address;
            CodeableConcept dzzzu_ = a?.PhysicalType;
            Location.PositionComponent dzzzv_ = a?.Position;
            ResourceReference dzzzw_ = a?.ManagingOrganization;
            ResourceReference dzzzx_ = a?.PartOf;
            List<Location.HoursOfOperationComponent> dzzzy_ = a?.HoursOfOperation;
            FhirString dzzzz_ = a?.AvailabilityExceptionsElement;
            List<ResourceReference> ezzza_ = a?.Endpoint;
            Location ezzzb_ = new Location
            {
                Identifier = new List<Identifier>((IEnumerable<Identifier>)dzzzk_),
                StatusElement = dzzzl_,
                OperationalStatus = dzzzm_,
                NameElement = dzzzn_,
                AliasElement = new List<FhirString>((IEnumerable<FhirString>)dzzzo_),
                DescriptionElement = dzzzp_,
                ModeElement = dzzzq_,
                Type = new List<CodeableConcept>((IEnumerable<CodeableConcept>)dzzzr_),
                Telecom = new List<ContactPoint>((IEnumerable<ContactPoint>)dzzzs_),
                Address = dzzzt_,
                PhysicalType = dzzzu_,
                Position = dzzzv_,
                ManagingOrganization = dzzzw_,
                PartOf = dzzzx_,
                HoursOfOperation = new List<Location.HoursOfOperationComponent>((IEnumerable<Location.HoursOfOperationComponent>)dzzzy_),
                AvailabilityExceptionsElement = dzzzz_,
                Endpoint = new List<ResourceReference>((IEnumerable<ResourceReference>)ezzza_),
            };

            return ezzzb_;
        };
        IEnumerable<Location> dzzzh_ = context.Operators.Select<Location, Location>((IEnumerable<Location>)dzzzf_, dzzzg_);
        IEnumerable<Location> dzzzi_ = context.Operators.Distinct<Location>(dzzzh_);
        Location dzzzj_ = context.Operators.SingletonFrom<Location>(dzzzi_);

        return dzzzj_;
    }


    [CqlExpressionDefinition("MeasureResource")]
    public Measure MeasureResource(CqlContext context, Measure arg)
    {
        Measure[] ezzzc_ = [
            arg,
        ];
        Measure ezzzd_(Measure a)
        {
            FhirUri ezzzh_ = a?.UrlElement;
            List<Identifier> ezzzi_ = a?.Identifier;
            FhirString ezzzj_ = a?.VersionElement;
            FhirString ezzzk_ = a?.NameElement;
            FhirString ezzzl_ = a?.TitleElement;
            FhirString ezzzm_ = a?.SubtitleElement;
            Code<PublicationStatus> ezzzn_ = a?.StatusElement;
            FhirBoolean ezzzo_ = a?.ExperimentalElement;
            DataType ezzzp_ = a?.Subject;
            FhirDateTime ezzzq_ = a?.DateElement;
            FhirString ezzzr_ = a?.PublisherElement;
            List<ContactDetail> ezzzs_ = a?.Contact;
            Markdown ezzzt_ = a?.DescriptionElement;
            List<UsageContext> ezzzu_ = a?.UseContext;
            List<CodeableConcept> ezzzv_ = a?.Jurisdiction;
            Markdown ezzzw_ = a?.PurposeElement;
            FhirString ezzzx_ = a?.UsageElement;
            Markdown ezzzy_ = a?.CopyrightElement;
            Date ezzzz_ = a?.ApprovalDateElement;
            Date fzzza_ = a?.LastReviewDateElement;
            Period fzzzb_ = a?.EffectivePeriod;
            List<CodeableConcept> fzzzc_ = a?.Topic;
            List<ContactDetail> fzzzd_ = a?.Author;
            List<ContactDetail> fzzze_ = a?.Editor;
            List<ContactDetail> fzzzf_ = a?.Reviewer;
            List<ContactDetail> fzzzg_ = a?.Endorser;
            List<RelatedArtifact> fzzzh_ = a?.RelatedArtifact;
            List<Canonical> fzzzi_ = a?.LibraryElement;
            Markdown fzzzj_ = a?.DisclaimerElement;
            CodeableConcept fzzzk_ = a?.Scoring;
            CodeableConcept fzzzl_ = a?.CompositeScoring;
            List<CodeableConcept> fzzzm_ = a?.Type;
            FhirString fzzzn_ = a?.RiskAdjustmentElement;
            FhirString fzzzo_ = a?.RateAggregationElement;
            Markdown fzzzp_ = a?.RationaleElement;
            Markdown fzzzq_ = a?.ClinicalRecommendationStatementElement;
            CodeableConcept fzzzr_ = a?.ImprovementNotation;
            List<Markdown> fzzzs_ = a?.DefinitionElement;
            Markdown fzzzt_ = a?.GuidanceElement;
            List<Measure.GroupComponent> fzzzu_ = a?.Group;
            List<Measure.SupplementalDataComponent> fzzzv_ = a?.SupplementalData;
            Measure fzzzw_ = new Measure
            {
                UrlElement = ezzzh_,
                Identifier = new List<Identifier>((IEnumerable<Identifier>)ezzzi_),
                VersionElement = ezzzj_,
                NameElement = ezzzk_,
                TitleElement = ezzzl_,
                SubtitleElement = ezzzm_,
                StatusElement = ezzzn_,
                ExperimentalElement = ezzzo_,
                Subject = (DataType)ezzzp_,
                DateElement = ezzzq_,
                PublisherElement = ezzzr_,
                Contact = new List<ContactDetail>((IEnumerable<ContactDetail>)ezzzs_),
                DescriptionElement = ezzzt_,
                UseContext = new List<UsageContext>((IEnumerable<UsageContext>)ezzzu_),
                Jurisdiction = new List<CodeableConcept>((IEnumerable<CodeableConcept>)ezzzv_),
                PurposeElement = ezzzw_,
                UsageElement = ezzzx_,
                CopyrightElement = ezzzy_,
                ApprovalDateElement = ezzzz_,
                LastReviewDateElement = fzzza_,
                EffectivePeriod = fzzzb_,
                Topic = new List<CodeableConcept>((IEnumerable<CodeableConcept>)fzzzc_),
                Author = new List<ContactDetail>((IEnumerable<ContactDetail>)fzzzd_),
                Editor = new List<ContactDetail>((IEnumerable<ContactDetail>)fzzze_),
                Reviewer = new List<ContactDetail>((IEnumerable<ContactDetail>)fzzzf_),
                Endorser = new List<ContactDetail>((IEnumerable<ContactDetail>)fzzzg_),
                RelatedArtifact = new List<RelatedArtifact>((IEnumerable<RelatedArtifact>)fzzzh_),
                LibraryElement = new List<Canonical>((IEnumerable<Canonical>)fzzzi_),
                DisclaimerElement = fzzzj_,
                Scoring = fzzzk_,
                CompositeScoring = fzzzl_,
                Type = new List<CodeableConcept>((IEnumerable<CodeableConcept>)fzzzm_),
                RiskAdjustmentElement = fzzzn_,
                RateAggregationElement = fzzzo_,
                RationaleElement = fzzzp_,
                ClinicalRecommendationStatementElement = fzzzq_,
                ImprovementNotation = fzzzr_,
                DefinitionElement = new List<Markdown>((IEnumerable<Markdown>)fzzzs_),
                GuidanceElement = fzzzt_,
                Group = new List<Measure.GroupComponent>((IEnumerable<Measure.GroupComponent>)fzzzu_),
                SupplementalData = new List<Measure.SupplementalDataComponent>((IEnumerable<Measure.SupplementalDataComponent>)fzzzv_),
            };

            return fzzzw_;
        };
        IEnumerable<Measure> ezzze_ = context.Operators.Select<Measure, Measure>((IEnumerable<Measure>)ezzzc_, ezzzd_);
        IEnumerable<Measure> ezzzf_ = context.Operators.Distinct<Measure>(ezzze_);
        Measure ezzzg_ = context.Operators.SingletonFrom<Measure>(ezzzf_);

        return ezzzg_;
    }


    [CqlExpressionDefinition("MeasureReportResource")]
    public MeasureReport MeasureReportResource(CqlContext context, MeasureReport arg)
    {
        MeasureReport[] fzzzx_ = [
            arg,
        ];
        MeasureReport fzzzy_(MeasureReport a)
        {
            List<Identifier> gzzzc_ = a?.Identifier;
            Code<MeasureReport.MeasureReportStatus> gzzzd_ = a?.StatusElement;
            Code<MeasureReport.MeasureReportType> gzzze_ = a?.TypeElement;
            Canonical gzzzf_ = a?.MeasureElement;
            ResourceReference gzzzg_ = a?.Subject;
            FhirDateTime gzzzh_ = a?.DateElement;
            ResourceReference gzzzi_ = a?.Reporter;
            Period gzzzj_ = a?.Period;
            CodeableConcept gzzzk_ = a?.ImprovementNotation;
            List<MeasureReport.GroupComponent> gzzzl_ = a?.Group;
            List<ResourceReference> gzzzm_ = a?.EvaluatedResource;
            MeasureReport gzzzn_ = new MeasureReport
            {
                Identifier = new List<Identifier>((IEnumerable<Identifier>)gzzzc_),
                StatusElement = gzzzd_,
                TypeElement = gzzze_,
                MeasureElement = gzzzf_,
                Subject = gzzzg_,
                DateElement = gzzzh_,
                Reporter = gzzzi_,
                Period = gzzzj_,
                ImprovementNotation = gzzzk_,
                Group = new List<MeasureReport.GroupComponent>((IEnumerable<MeasureReport.GroupComponent>)gzzzl_),
                EvaluatedResource = new List<ResourceReference>((IEnumerable<ResourceReference>)gzzzm_),
            };

            return gzzzn_;
        };
        IEnumerable<MeasureReport> fzzzz_ = context.Operators.Select<MeasureReport, MeasureReport>((IEnumerable<MeasureReport>)fzzzx_, fzzzy_);
        IEnumerable<MeasureReport> gzzza_ = context.Operators.Distinct<MeasureReport>(fzzzz_);
        MeasureReport gzzzb_ = context.Operators.SingletonFrom<MeasureReport>(gzzza_);

        return gzzzb_;
    }


    [CqlExpressionDefinition("MedicationResource")]
    public Medication MedicationResource(CqlContext context, Medication arg)
    {
        Medication[] gzzzo_ = [
            arg,
        ];
        Medication gzzzp_(Medication a)
        {
            List<Identifier> gzzzt_ = a?.Identifier;
            CodeableConcept gzzzu_ = a?.Code;
            Code<Medication.MedicationStatusCodes> gzzzv_ = a?.StatusElement;
            ResourceReference gzzzw_ = a?.Manufacturer;
            CodeableConcept gzzzx_ = a?.Form;
            Ratio gzzzy_ = a?.Amount;
            List<Medication.IngredientComponent> gzzzz_ = a?.Ingredient;
            Medication.BatchComponent hzzza_ = a?.Batch;
            Medication hzzzb_ = new Medication
            {
                Identifier = new List<Identifier>((IEnumerable<Identifier>)gzzzt_),
                Code = gzzzu_,
                StatusElement = gzzzv_,
                Manufacturer = gzzzw_,
                Form = gzzzx_,
                Amount = gzzzy_,
                Ingredient = new List<Medication.IngredientComponent>((IEnumerable<Medication.IngredientComponent>)gzzzz_),
                Batch = hzzza_,
            };

            return hzzzb_;
        };
        IEnumerable<Medication> gzzzq_ = context.Operators.Select<Medication, Medication>((IEnumerable<Medication>)gzzzo_, gzzzp_);
        IEnumerable<Medication> gzzzr_ = context.Operators.Distinct<Medication>(gzzzq_);
        Medication gzzzs_ = context.Operators.SingletonFrom<Medication>(gzzzr_);

        return gzzzs_;
    }


    [CqlExpressionDefinition("MedicationAdministrationResource")]
    public MedicationAdministration MedicationAdministrationResource(CqlContext context, MedicationAdministration arg)
    {
        MedicationAdministration[] hzzzc_ = [
            arg,
        ];
        MedicationAdministration hzzzd_(MedicationAdministration a)
        {
            List<Identifier> hzzzh_ = a?.Identifier;
            List<FhirUri> hzzzi_ = a?.InstantiatesElement;
            List<ResourceReference> hzzzj_ = a?.PartOf;
            Code<MedicationAdministration.MedicationAdministrationStatusCodes> hzzzk_ = a?.StatusElement;
            List<CodeableConcept> hzzzl_ = a?.StatusReason;
            CodeableConcept hzzzm_ = a?.Category;
            DataType hzzzn_ = a?.Medication;
            ResourceReference hzzzo_ = a?.Subject;
            ResourceReference hzzzp_ = a?.Context;
            List<ResourceReference> hzzzq_ = a?.SupportingInformation;
            DataType hzzzr_ = a?.Effective;
            List<MedicationAdministration.PerformerComponent> hzzzs_ = a?.Performer;
            List<CodeableConcept> hzzzt_ = a?.ReasonCode;
            List<ResourceReference> hzzzu_ = a?.ReasonReference;
            ResourceReference hzzzv_ = a?.Request;
            List<ResourceReference> hzzzw_ = a?.Device;
            List<Annotation> hzzzx_ = a?.Note;
            MedicationAdministration.DosageComponent hzzzy_ = a?.Dosage;
            List<ResourceReference> hzzzz_ = a?.EventHistory;
            MedicationAdministration izzza_ = new MedicationAdministration
            {
                Identifier = new List<Identifier>((IEnumerable<Identifier>)hzzzh_),
                InstantiatesElement = new List<FhirUri>((IEnumerable<FhirUri>)hzzzi_),
                PartOf = new List<ResourceReference>((IEnumerable<ResourceReference>)hzzzj_),
                StatusElement = hzzzk_,
                StatusReason = new List<CodeableConcept>((IEnumerable<CodeableConcept>)hzzzl_),
                Category = hzzzm_,
                Medication = (DataType)hzzzn_,
                Subject = hzzzo_,
                Context = hzzzp_,
                SupportingInformation = new List<ResourceReference>((IEnumerable<ResourceReference>)hzzzq_),
                Effective = (DataType)hzzzr_,
                Performer = new List<MedicationAdministration.PerformerComponent>((IEnumerable<MedicationAdministration.PerformerComponent>)hzzzs_),
                ReasonCode = new List<CodeableConcept>((IEnumerable<CodeableConcept>)hzzzt_),
                ReasonReference = new List<ResourceReference>((IEnumerable<ResourceReference>)hzzzu_),
                Request = hzzzv_,
                Device = new List<ResourceReference>((IEnumerable<ResourceReference>)hzzzw_),
                Note = new List<Annotation>((IEnumerable<Annotation>)hzzzx_),
                Dosage = hzzzy_,
                EventHistory = new List<ResourceReference>((IEnumerable<ResourceReference>)hzzzz_),
            };

            return izzza_;
        };
        IEnumerable<MedicationAdministration> hzzze_ = context.Operators.Select<MedicationAdministration, MedicationAdministration>((IEnumerable<MedicationAdministration>)hzzzc_, hzzzd_);
        IEnumerable<MedicationAdministration> hzzzf_ = context.Operators.Distinct<MedicationAdministration>(hzzze_);
        MedicationAdministration hzzzg_ = context.Operators.SingletonFrom<MedicationAdministration>(hzzzf_);

        return hzzzg_;
    }


    [CqlExpressionDefinition("MedicationDispenseResource")]
    public MedicationDispense MedicationDispenseResource(CqlContext context, MedicationDispense arg)
    {
        MedicationDispense[] izzzb_ = [
            arg,
        ];
        MedicationDispense izzzc_(MedicationDispense a)
        {
            List<Identifier> izzzg_ = a?.Identifier;
            List<ResourceReference> izzzh_ = a?.PartOf;
            Code<MedicationDispense.MedicationDispenseStatusCodes> izzzi_ = a?.StatusElement;
            DataType izzzj_ = a?.StatusReason;
            CodeableConcept izzzk_ = a?.Category;
            DataType izzzl_ = a?.Medication;
            ResourceReference izzzm_ = a?.Subject;
            ResourceReference izzzn_ = a?.Context;
            List<ResourceReference> izzzo_ = a?.SupportingInformation;
            List<MedicationDispense.PerformerComponent> izzzp_ = a?.Performer;
            ResourceReference izzzq_ = a?.Location;
            List<ResourceReference> izzzr_ = a?.AuthorizingPrescription;
            CodeableConcept izzzs_ = a?.Type;
            Quantity izzzt_ = a?.Quantity;
            Quantity izzzu_ = a?.DaysSupply;
            FhirDateTime izzzv_ = a?.WhenPreparedElement;
            FhirDateTime izzzw_ = a?.WhenHandedOverElement;
            ResourceReference izzzx_ = a?.Destination;
            List<ResourceReference> izzzy_ = a?.Receiver;
            List<Annotation> izzzz_ = a?.Note;
            List<Dosage> jzzza_ = a?.DosageInstruction;
            MedicationDispense.SubstitutionComponent jzzzb_ = a?.Substitution;
            List<ResourceReference> jzzzc_ = a?.DetectedIssue;
            List<ResourceReference> jzzzd_ = a?.EventHistory;
            MedicationDispense jzzze_ = new MedicationDispense
            {
                Identifier = new List<Identifier>((IEnumerable<Identifier>)izzzg_),
                PartOf = new List<ResourceReference>((IEnumerable<ResourceReference>)izzzh_),
                StatusElement = izzzi_,
                StatusReason = (DataType)izzzj_,
                Category = izzzk_,
                Medication = (DataType)izzzl_,
                Subject = izzzm_,
                Context = izzzn_,
                SupportingInformation = new List<ResourceReference>((IEnumerable<ResourceReference>)izzzo_),
                Performer = new List<MedicationDispense.PerformerComponent>((IEnumerable<MedicationDispense.PerformerComponent>)izzzp_),
                Location = izzzq_,
                AuthorizingPrescription = new List<ResourceReference>((IEnumerable<ResourceReference>)izzzr_),
                Type = izzzs_,
                Quantity = izzzt_,
                DaysSupply = izzzu_,
                WhenPreparedElement = izzzv_,
                WhenHandedOverElement = izzzw_,
                Destination = izzzx_,
                Receiver = new List<ResourceReference>((IEnumerable<ResourceReference>)izzzy_),
                Note = new List<Annotation>((IEnumerable<Annotation>)izzzz_),
                DosageInstruction = new List<Dosage>((IEnumerable<Dosage>)jzzza_),
                Substitution = jzzzb_,
                DetectedIssue = new List<ResourceReference>((IEnumerable<ResourceReference>)jzzzc_),
                EventHistory = new List<ResourceReference>((IEnumerable<ResourceReference>)jzzzd_),
            };

            return jzzze_;
        };
        IEnumerable<MedicationDispense> izzzd_ = context.Operators.Select<MedicationDispense, MedicationDispense>((IEnumerable<MedicationDispense>)izzzb_, izzzc_);
        IEnumerable<MedicationDispense> izzze_ = context.Operators.Distinct<MedicationDispense>(izzzd_);
        MedicationDispense izzzf_ = context.Operators.SingletonFrom<MedicationDispense>(izzze_);

        return izzzf_;
    }


    [CqlExpressionDefinition("MedicationKnowledgeResource")]
    public MedicationKnowledge MedicationKnowledgeResource(CqlContext context, MedicationKnowledge arg)
    {
        MedicationKnowledge[] jzzzf_ = [
            arg,
        ];
        MedicationKnowledge jzzzg_(MedicationKnowledge a)
        {
            CodeableConcept jzzzk_ = a?.Code;
            Code<MedicationKnowledge.MedicationKnowledgeStatusCodes> jzzzl_ = a?.StatusElement;
            ResourceReference jzzzm_ = a?.Manufacturer;
            CodeableConcept jzzzn_ = a?.DoseForm;
            Quantity jzzzo_ = a?.Amount;
            List<FhirString> jzzzp_ = a?.SynonymElement;
            List<MedicationKnowledge.RelatedMedicationKnowledgeComponent> jzzzq_ = a?.RelatedMedicationKnowledge;
            List<ResourceReference> jzzzr_ = a?.AssociatedMedication;
            List<CodeableConcept> jzzzs_ = a?.ProductType;
            List<MedicationKnowledge.MonographComponent> jzzzt_ = a?.Monograph;
            List<MedicationKnowledge.IngredientComponent> jzzzu_ = a?.Ingredient;
            Markdown jzzzv_ = a?.PreparationInstructionElement;
            List<CodeableConcept> jzzzw_ = a?.IntendedRoute;
            List<MedicationKnowledge.CostComponent> jzzzx_ = a?.Cost;
            List<MedicationKnowledge.MonitoringProgramComponent> jzzzy_ = a?.MonitoringProgram;
            List<MedicationKnowledge.AdministrationGuidelinesComponent> jzzzz_ = a?.AdministrationGuidelines;
            List<MedicationKnowledge.MedicineClassificationComponent> kzzza_ = a?.MedicineClassification;
            MedicationKnowledge.PackagingComponent kzzzb_ = a?.Packaging;
            List<MedicationKnowledge.DrugCharacteristicComponent> kzzzc_ = a?.DrugCharacteristic;
            List<ResourceReference> kzzzd_ = a?.Contraindication;
            List<MedicationKnowledge.RegulatoryComponent> kzzze_ = a?.Regulatory;
            List<MedicationKnowledge.KineticsComponent> kzzzf_ = a?.Kinetics;
            MedicationKnowledge kzzzg_ = new MedicationKnowledge
            {
                Code = jzzzk_,
                StatusElement = jzzzl_,
                Manufacturer = jzzzm_,
                DoseForm = jzzzn_,
                Amount = jzzzo_,
                SynonymElement = new List<FhirString>((IEnumerable<FhirString>)jzzzp_),
                RelatedMedicationKnowledge = new List<MedicationKnowledge.RelatedMedicationKnowledgeComponent>((IEnumerable<MedicationKnowledge.RelatedMedicationKnowledgeComponent>)jzzzq_),
                AssociatedMedication = new List<ResourceReference>((IEnumerable<ResourceReference>)jzzzr_),
                ProductType = new List<CodeableConcept>((IEnumerable<CodeableConcept>)jzzzs_),
                Monograph = new List<MedicationKnowledge.MonographComponent>((IEnumerable<MedicationKnowledge.MonographComponent>)jzzzt_),
                Ingredient = new List<MedicationKnowledge.IngredientComponent>((IEnumerable<MedicationKnowledge.IngredientComponent>)jzzzu_),
                PreparationInstructionElement = jzzzv_,
                IntendedRoute = new List<CodeableConcept>((IEnumerable<CodeableConcept>)jzzzw_),
                Cost = new List<MedicationKnowledge.CostComponent>((IEnumerable<MedicationKnowledge.CostComponent>)jzzzx_),
                MonitoringProgram = new List<MedicationKnowledge.MonitoringProgramComponent>((IEnumerable<MedicationKnowledge.MonitoringProgramComponent>)jzzzy_),
                AdministrationGuidelines = new List<MedicationKnowledge.AdministrationGuidelinesComponent>((IEnumerable<MedicationKnowledge.AdministrationGuidelinesComponent>)jzzzz_),
                MedicineClassification = new List<MedicationKnowledge.MedicineClassificationComponent>((IEnumerable<MedicationKnowledge.MedicineClassificationComponent>)kzzza_),
                Packaging = kzzzb_,
                DrugCharacteristic = new List<MedicationKnowledge.DrugCharacteristicComponent>((IEnumerable<MedicationKnowledge.DrugCharacteristicComponent>)kzzzc_),
                Contraindication = new List<ResourceReference>((IEnumerable<ResourceReference>)kzzzd_),
                Regulatory = new List<MedicationKnowledge.RegulatoryComponent>((IEnumerable<MedicationKnowledge.RegulatoryComponent>)kzzze_),
                Kinetics = new List<MedicationKnowledge.KineticsComponent>((IEnumerable<MedicationKnowledge.KineticsComponent>)kzzzf_),
            };

            return kzzzg_;
        };
        IEnumerable<MedicationKnowledge> jzzzh_ = context.Operators.Select<MedicationKnowledge, MedicationKnowledge>((IEnumerable<MedicationKnowledge>)jzzzf_, jzzzg_);
        IEnumerable<MedicationKnowledge> jzzzi_ = context.Operators.Distinct<MedicationKnowledge>(jzzzh_);
        MedicationKnowledge jzzzj_ = context.Operators.SingletonFrom<MedicationKnowledge>(jzzzi_);

        return jzzzj_;
    }


    [CqlExpressionDefinition("MedicationRequestResource")]
    public MedicationRequest MedicationRequestResource(CqlContext context, MedicationRequest arg)
    {
        MedicationRequest[] kzzzh_ = [
            arg,
        ];
        MedicationRequest kzzzi_(MedicationRequest a)
        {
            List<Identifier> kzzzm_ = a?.Identifier;
            Code<MedicationRequest.MedicationrequestStatus> kzzzn_ = a?.StatusElement;
            CodeableConcept kzzzo_ = a?.StatusReason;
            Code<MedicationRequest.MedicationRequestIntent> kzzzp_ = a?.IntentElement;
            List<CodeableConcept> kzzzq_ = a?.Category;
            Code<RequestPriority> kzzzr_ = a?.PriorityElement;
            FhirBoolean kzzzs_ = a?.DoNotPerformElement;
            DataType kzzzt_ = a?.Reported;
            DataType kzzzu_ = a?.Medication;
            ResourceReference kzzzv_ = a?.Subject;
            ResourceReference kzzzw_ = a?.Encounter;
            List<ResourceReference> kzzzx_ = a?.SupportingInformation;
            FhirDateTime kzzzy_ = a?.AuthoredOnElement;
            ResourceReference kzzzz_ = a?.Requester;
            ResourceReference lzzza_ = a?.Performer;
            CodeableConcept lzzzb_ = a?.PerformerType;
            ResourceReference lzzzc_ = a?.Recorder;
            List<CodeableConcept> lzzzd_ = a?.ReasonCode;
            List<ResourceReference> lzzze_ = a?.ReasonReference;
            List<Canonical> lzzzf_ = a?.InstantiatesCanonicalElement;
            List<FhirUri> lzzzg_ = a?.InstantiatesUriElement;
            List<ResourceReference> lzzzh_ = a?.BasedOn;
            Identifier lzzzi_ = a?.GroupIdentifier;
            CodeableConcept lzzzj_ = a?.CourseOfTherapyType;
            List<ResourceReference> lzzzk_ = a?.Insurance;
            List<Annotation> lzzzl_ = a?.Note;
            List<Dosage> lzzzm_ = a?.DosageInstruction;
            MedicationRequest.DispenseRequestComponent lzzzn_ = a?.DispenseRequest;
            MedicationRequest.SubstitutionComponent lzzzo_ = a?.Substitution;
            ResourceReference lzzzp_ = a?.PriorPrescription;
            List<ResourceReference> lzzzq_ = a?.DetectedIssue;
            List<ResourceReference> lzzzr_ = a?.EventHistory;
            MedicationRequest lzzzs_ = new MedicationRequest
            {
                Identifier = new List<Identifier>((IEnumerable<Identifier>)kzzzm_),
                StatusElement = kzzzn_,
                StatusReason = kzzzo_,
                IntentElement = kzzzp_,
                Category = new List<CodeableConcept>((IEnumerable<CodeableConcept>)kzzzq_),
                PriorityElement = kzzzr_,
                DoNotPerformElement = kzzzs_,
                Reported = (DataType)kzzzt_,
                Medication = (DataType)kzzzu_,
                Subject = kzzzv_,
                Encounter = kzzzw_,
                SupportingInformation = new List<ResourceReference>((IEnumerable<ResourceReference>)kzzzx_),
                AuthoredOnElement = kzzzy_,
                Requester = kzzzz_,
                Performer = lzzza_,
                PerformerType = lzzzb_,
                Recorder = lzzzc_,
                ReasonCode = new List<CodeableConcept>((IEnumerable<CodeableConcept>)lzzzd_),
                ReasonReference = new List<ResourceReference>((IEnumerable<ResourceReference>)lzzze_),
                InstantiatesCanonicalElement = new List<Canonical>((IEnumerable<Canonical>)lzzzf_),
                InstantiatesUriElement = new List<FhirUri>((IEnumerable<FhirUri>)lzzzg_),
                BasedOn = new List<ResourceReference>((IEnumerable<ResourceReference>)lzzzh_),
                GroupIdentifier = lzzzi_,
                CourseOfTherapyType = lzzzj_,
                Insurance = new List<ResourceReference>((IEnumerable<ResourceReference>)lzzzk_),
                Note = new List<Annotation>((IEnumerable<Annotation>)lzzzl_),
                DosageInstruction = new List<Dosage>((IEnumerable<Dosage>)lzzzm_),
                DispenseRequest = lzzzn_,
                Substitution = lzzzo_,
                PriorPrescription = lzzzp_,
                DetectedIssue = new List<ResourceReference>((IEnumerable<ResourceReference>)lzzzq_),
                EventHistory = new List<ResourceReference>((IEnumerable<ResourceReference>)lzzzr_),
            };

            return lzzzs_;
        };
        IEnumerable<MedicationRequest> kzzzj_ = context.Operators.Select<MedicationRequest, MedicationRequest>((IEnumerable<MedicationRequest>)kzzzh_, kzzzi_);
        IEnumerable<MedicationRequest> kzzzk_ = context.Operators.Distinct<MedicationRequest>(kzzzj_);
        MedicationRequest kzzzl_ = context.Operators.SingletonFrom<MedicationRequest>(kzzzk_);

        return kzzzl_;
    }


    [CqlExpressionDefinition("MedicationStatementResource")]
    public MedicationStatement MedicationStatementResource(CqlContext context, MedicationStatement arg)
    {
        MedicationStatement[] lzzzt_ = [
            arg,
        ];
        MedicationStatement lzzzu_(MedicationStatement a)
        {
            List<Identifier> lzzzy_ = a?.Identifier;
            List<ResourceReference> lzzzz_ = a?.BasedOn;
            List<ResourceReference> mzzza_ = a?.PartOf;
            Code<MedicationStatement.MedicationStatusCodes> mzzzb_ = a?.StatusElement;
            List<CodeableConcept> mzzzc_ = a?.StatusReason;
            CodeableConcept mzzzd_ = a?.Category;
            DataType mzzze_ = a?.Medication;
            ResourceReference mzzzf_ = a?.Subject;
            ResourceReference mzzzg_ = a?.Context;
            DataType mzzzh_ = a?.Effective;
            FhirDateTime mzzzi_ = a?.DateAssertedElement;
            ResourceReference mzzzj_ = a?.InformationSource;
            List<ResourceReference> mzzzk_ = a?.DerivedFrom;
            List<CodeableConcept> mzzzl_ = a?.ReasonCode;
            List<ResourceReference> mzzzm_ = a?.ReasonReference;
            List<Annotation> mzzzn_ = a?.Note;
            List<Dosage> mzzzo_ = a?.Dosage;
            MedicationStatement mzzzp_ = new MedicationStatement
            {
                Identifier = new List<Identifier>((IEnumerable<Identifier>)lzzzy_),
                BasedOn = new List<ResourceReference>((IEnumerable<ResourceReference>)lzzzz_),
                PartOf = new List<ResourceReference>((IEnumerable<ResourceReference>)mzzza_),
                StatusElement = mzzzb_,
                StatusReason = new List<CodeableConcept>((IEnumerable<CodeableConcept>)mzzzc_),
                Category = mzzzd_,
                Medication = (DataType)mzzze_,
                Subject = mzzzf_,
                Context = mzzzg_,
                Effective = (DataType)mzzzh_,
                DateAssertedElement = mzzzi_,
                InformationSource = mzzzj_,
                DerivedFrom = new List<ResourceReference>((IEnumerable<ResourceReference>)mzzzk_),
                ReasonCode = new List<CodeableConcept>((IEnumerable<CodeableConcept>)mzzzl_),
                ReasonReference = new List<ResourceReference>((IEnumerable<ResourceReference>)mzzzm_),
                Note = new List<Annotation>((IEnumerable<Annotation>)mzzzn_),
                Dosage = new List<Dosage>((IEnumerable<Dosage>)mzzzo_),
            };

            return mzzzp_;
        };
        IEnumerable<MedicationStatement> lzzzv_ = context.Operators.Select<MedicationStatement, MedicationStatement>((IEnumerable<MedicationStatement>)lzzzt_, lzzzu_);
        IEnumerable<MedicationStatement> lzzzw_ = context.Operators.Distinct<MedicationStatement>(lzzzv_);
        MedicationStatement lzzzx_ = context.Operators.SingletonFrom<MedicationStatement>(lzzzw_);

        return lzzzx_;
    }


    [CqlExpressionDefinition("MedicinalProductResource")]
    public MedicinalProduct MedicinalProductResource(CqlContext context, MedicinalProduct arg)
    {
        MedicinalProduct[] mzzzq_ = [
            arg,
        ];
        MedicinalProduct mzzzr_(MedicinalProduct a)
        {
            List<Identifier> mzzzv_ = a?.Identifier;
            CodeableConcept mzzzw_ = a?.Type;
            Coding mzzzx_ = a?.Domain;
            CodeableConcept mzzzy_ = a?.CombinedPharmaceuticalDoseForm;
            CodeableConcept mzzzz_ = a?.LegalStatusOfSupply;
            CodeableConcept nzzza_ = a?.AdditionalMonitoringIndicator;
            List<FhirString> nzzzb_ = a?.SpecialMeasuresElement;
            CodeableConcept nzzzc_ = a?.PaediatricUseIndicator;
            List<CodeableConcept> nzzzd_ = a?.ProductClassification;
            List<MarketingStatus> nzzze_ = a?.MarketingStatus;
            List<ResourceReference> nzzzf_ = a?.PharmaceuticalProduct;
            List<ResourceReference> nzzzg_ = a?.PackagedMedicinalProduct;
            List<ResourceReference> nzzzh_ = a?.AttachedDocument;
            List<ResourceReference> nzzzi_ = a?.MasterFile;
            List<ResourceReference> nzzzj_ = a?.Contact;
            List<ResourceReference> nzzzk_ = a?.ClinicalTrial;
            List<MedicinalProduct.NameComponent> nzzzl_ = a?.Name;
            List<Identifier> nzzzm_ = a?.CrossReference;
            List<MedicinalProduct.ManufacturingBusinessOperationComponent> nzzzn_ = a?.ManufacturingBusinessOperation;
            List<MedicinalProduct.SpecialDesignationComponent> nzzzo_ = a?.SpecialDesignation;
            MedicinalProduct nzzzp_ = new MedicinalProduct
            {
                Identifier = new List<Identifier>((IEnumerable<Identifier>)mzzzv_),
                Type = mzzzw_,
                Domain = mzzzx_,
                CombinedPharmaceuticalDoseForm = mzzzy_,
                LegalStatusOfSupply = mzzzz_,
                AdditionalMonitoringIndicator = nzzza_,
                SpecialMeasuresElement = new List<FhirString>((IEnumerable<FhirString>)nzzzb_),
                PaediatricUseIndicator = nzzzc_,
                ProductClassification = new List<CodeableConcept>((IEnumerable<CodeableConcept>)nzzzd_),
                MarketingStatus = new List<MarketingStatus>((IEnumerable<MarketingStatus>)nzzze_),
                PharmaceuticalProduct = new List<ResourceReference>((IEnumerable<ResourceReference>)nzzzf_),
                PackagedMedicinalProduct = new List<ResourceReference>((IEnumerable<ResourceReference>)nzzzg_),
                AttachedDocument = new List<ResourceReference>((IEnumerable<ResourceReference>)nzzzh_),
                MasterFile = new List<ResourceReference>((IEnumerable<ResourceReference>)nzzzi_),
                Contact = new List<ResourceReference>((IEnumerable<ResourceReference>)nzzzj_),
                ClinicalTrial = new List<ResourceReference>((IEnumerable<ResourceReference>)nzzzk_),
                Name = new List<MedicinalProduct.NameComponent>((IEnumerable<MedicinalProduct.NameComponent>)nzzzl_),
                CrossReference = new List<Identifier>((IEnumerable<Identifier>)nzzzm_),
                ManufacturingBusinessOperation = new List<MedicinalProduct.ManufacturingBusinessOperationComponent>((IEnumerable<MedicinalProduct.ManufacturingBusinessOperationComponent>)nzzzn_),
                SpecialDesignation = new List<MedicinalProduct.SpecialDesignationComponent>((IEnumerable<MedicinalProduct.SpecialDesignationComponent>)nzzzo_),
            };

            return nzzzp_;
        };
        IEnumerable<MedicinalProduct> mzzzs_ = context.Operators.Select<MedicinalProduct, MedicinalProduct>((IEnumerable<MedicinalProduct>)mzzzq_, mzzzr_);
        IEnumerable<MedicinalProduct> mzzzt_ = context.Operators.Distinct<MedicinalProduct>(mzzzs_);
        MedicinalProduct mzzzu_ = context.Operators.SingletonFrom<MedicinalProduct>(mzzzt_);

        return mzzzu_;
    }


    [CqlExpressionDefinition("MedicinalProductAuthorizationResource")]
    public MedicinalProductAuthorization MedicinalProductAuthorizationResource(CqlContext context, MedicinalProductAuthorization arg)
    {
        MedicinalProductAuthorization[] nzzzq_ = [
            arg,
        ];
        MedicinalProductAuthorization nzzzr_(MedicinalProductAuthorization a)
        {
            List<Identifier> nzzzv_ = a?.Identifier;
            ResourceReference nzzzw_ = a?.Subject;
            List<CodeableConcept> nzzzx_ = a?.Country;
            List<CodeableConcept> nzzzy_ = a?.Jurisdiction;
            CodeableConcept nzzzz_ = a?.Status;
            FhirDateTime ozzza_ = a?.StatusDateElement;
            FhirDateTime ozzzb_ = a?.RestoreDateElement;
            Period ozzzc_ = a?.ValidityPeriod;
            Period ozzzd_ = a?.DataExclusivityPeriod;
            FhirDateTime ozzze_ = a?.DateOfFirstAuthorizationElement;
            FhirDateTime ozzzf_ = a?.InternationalBirthDateElement;
            CodeableConcept ozzzg_ = a?.LegalBasis;
            List<MedicinalProductAuthorization.JurisdictionalAuthorizationComponent> ozzzh_ = a?.JurisdictionalAuthorization;
            ResourceReference ozzzi_ = a?.Holder;
            ResourceReference ozzzj_ = a?.Regulator;
            MedicinalProductAuthorization.ProcedureComponent ozzzk_ = a?.Procedure;
            MedicinalProductAuthorization ozzzl_ = new MedicinalProductAuthorization
            {
                Identifier = new List<Identifier>((IEnumerable<Identifier>)nzzzv_),
                Subject = nzzzw_,
                Country = new List<CodeableConcept>((IEnumerable<CodeableConcept>)nzzzx_),
                Jurisdiction = new List<CodeableConcept>((IEnumerable<CodeableConcept>)nzzzy_),
                Status = nzzzz_,
                StatusDateElement = ozzza_,
                RestoreDateElement = ozzzb_,
                ValidityPeriod = ozzzc_,
                DataExclusivityPeriod = ozzzd_,
                DateOfFirstAuthorizationElement = ozzze_,
                InternationalBirthDateElement = ozzzf_,
                LegalBasis = ozzzg_,
                JurisdictionalAuthorization = new List<MedicinalProductAuthorization.JurisdictionalAuthorizationComponent>((IEnumerable<MedicinalProductAuthorization.JurisdictionalAuthorizationComponent>)ozzzh_),
                Holder = ozzzi_,
                Regulator = ozzzj_,
                Procedure = ozzzk_,
            };

            return ozzzl_;
        };
        IEnumerable<MedicinalProductAuthorization> nzzzs_ = context.Operators.Select<MedicinalProductAuthorization, MedicinalProductAuthorization>((IEnumerable<MedicinalProductAuthorization>)nzzzq_, nzzzr_);
        IEnumerable<MedicinalProductAuthorization> nzzzt_ = context.Operators.Distinct<MedicinalProductAuthorization>(nzzzs_);
        MedicinalProductAuthorization nzzzu_ = context.Operators.SingletonFrom<MedicinalProductAuthorization>(nzzzt_);

        return nzzzu_;
    }


    [CqlExpressionDefinition("MedicinalProductContraindicationResource")]
    public MedicinalProductContraindication MedicinalProductContraindicationResource(CqlContext context, MedicinalProductContraindication arg)
    {
        MedicinalProductContraindication[] ozzzm_ = [
            arg,
        ];
        MedicinalProductContraindication ozzzn_(MedicinalProductContraindication a)
        {
            List<ResourceReference> ozzzr_ = a?.Subject;
            CodeableConcept ozzzs_ = a?.Disease;
            CodeableConcept ozzzt_ = a?.DiseaseStatus;
            List<CodeableConcept> ozzzu_ = a?.Comorbidity;
            List<ResourceReference> ozzzv_ = a?.TherapeuticIndication;
            List<MedicinalProductContraindication.OtherTherapyComponent> ozzzw_ = a?.OtherTherapy;
            List<Population> ozzzx_ = a?.Population;
            MedicinalProductContraindication ozzzy_ = new MedicinalProductContraindication
            {
                Subject = new List<ResourceReference>((IEnumerable<ResourceReference>)ozzzr_),
                Disease = ozzzs_,
                DiseaseStatus = ozzzt_,
                Comorbidity = new List<CodeableConcept>((IEnumerable<CodeableConcept>)ozzzu_),
                TherapeuticIndication = new List<ResourceReference>((IEnumerable<ResourceReference>)ozzzv_),
                OtherTherapy = new List<MedicinalProductContraindication.OtherTherapyComponent>((IEnumerable<MedicinalProductContraindication.OtherTherapyComponent>)ozzzw_),
                Population = new List<Population>((IEnumerable<Population>)ozzzx_),
            };

            return ozzzy_;
        };
        IEnumerable<MedicinalProductContraindication> ozzzo_ = context.Operators.Select<MedicinalProductContraindication, MedicinalProductContraindication>((IEnumerable<MedicinalProductContraindication>)ozzzm_, ozzzn_);
        IEnumerable<MedicinalProductContraindication> ozzzp_ = context.Operators.Distinct<MedicinalProductContraindication>(ozzzo_);
        MedicinalProductContraindication ozzzq_ = context.Operators.SingletonFrom<MedicinalProductContraindication>(ozzzp_);

        return ozzzq_;
    }


    [CqlExpressionDefinition("MedicinalProductIngredientResource")]
    public MedicinalProductIngredient MedicinalProductIngredientResource(CqlContext context, MedicinalProductIngredient arg)
    {
        MedicinalProductIngredient[] ozzzz_ = [
            arg,
        ];
        MedicinalProductIngredient pzzza_(MedicinalProductIngredient a)
        {
            Identifier pzzze_ = a?.Identifier;
            CodeableConcept pzzzf_ = a?.Role;
            FhirBoolean pzzzg_ = a?.AllergenicIndicatorElement;
            List<ResourceReference> pzzzh_ = a?.Manufacturer;
            List<MedicinalProductIngredient.SpecifiedSubstanceComponent> pzzzi_ = a?.SpecifiedSubstance;
            MedicinalProductIngredient.SubstanceComponent pzzzj_ = a?.Substance;
            MedicinalProductIngredient pzzzk_ = new MedicinalProductIngredient
            {
                Identifier = pzzze_,
                Role = pzzzf_,
                AllergenicIndicatorElement = pzzzg_,
                Manufacturer = new List<ResourceReference>((IEnumerable<ResourceReference>)pzzzh_),
                SpecifiedSubstance = new List<MedicinalProductIngredient.SpecifiedSubstanceComponent>((IEnumerable<MedicinalProductIngredient.SpecifiedSubstanceComponent>)pzzzi_),
                Substance = pzzzj_,
            };

            return pzzzk_;
        };
        IEnumerable<MedicinalProductIngredient> pzzzb_ = context.Operators.Select<MedicinalProductIngredient, MedicinalProductIngredient>((IEnumerable<MedicinalProductIngredient>)ozzzz_, pzzza_);
        IEnumerable<MedicinalProductIngredient> pzzzc_ = context.Operators.Distinct<MedicinalProductIngredient>(pzzzb_);
        MedicinalProductIngredient pzzzd_ = context.Operators.SingletonFrom<MedicinalProductIngredient>(pzzzc_);

        return pzzzd_;
    }


    [CqlExpressionDefinition("MedicinalProductInteractionResource")]
    public MedicinalProductInteraction MedicinalProductInteractionResource(CqlContext context, MedicinalProductInteraction arg)
    {
        MedicinalProductInteraction[] pzzzl_ = [
            arg,
        ];
        MedicinalProductInteraction pzzzm_(MedicinalProductInteraction a)
        {
            List<ResourceReference> pzzzq_ = a?.Subject;
            FhirString pzzzr_ = a?.DescriptionElement;
            List<MedicinalProductInteraction.InteractantComponent> pzzzs_ = a?.Interactant;
            CodeableConcept pzzzt_ = a?.Type;
            CodeableConcept pzzzu_ = a?.Effect;
            CodeableConcept pzzzv_ = a?.Incidence;
            CodeableConcept pzzzw_ = a?.Management;
            MedicinalProductInteraction pzzzx_ = new MedicinalProductInteraction
            {
                Subject = new List<ResourceReference>((IEnumerable<ResourceReference>)pzzzq_),
                DescriptionElement = pzzzr_,
                Interactant = new List<MedicinalProductInteraction.InteractantComponent>((IEnumerable<MedicinalProductInteraction.InteractantComponent>)pzzzs_),
                Type = pzzzt_,
                Effect = pzzzu_,
                Incidence = pzzzv_,
                Management = pzzzw_,
            };

            return pzzzx_;
        };
        IEnumerable<MedicinalProductInteraction> pzzzn_ = context.Operators.Select<MedicinalProductInteraction, MedicinalProductInteraction>((IEnumerable<MedicinalProductInteraction>)pzzzl_, pzzzm_);
        IEnumerable<MedicinalProductInteraction> pzzzo_ = context.Operators.Distinct<MedicinalProductInteraction>(pzzzn_);
        MedicinalProductInteraction pzzzp_ = context.Operators.SingletonFrom<MedicinalProductInteraction>(pzzzo_);

        return pzzzp_;
    }


    [CqlExpressionDefinition("MedicinalProductManufacturedResource")]
    public MedicinalProductManufactured MedicinalProductManufacturedResource(CqlContext context, MedicinalProductManufactured arg)
    {
        MedicinalProductManufactured[] pzzzy_ = [
            arg,
        ];
        MedicinalProductManufactured pzzzz_(MedicinalProductManufactured a)
        {
            CodeableConcept qzzzd_ = a?.ManufacturedDoseForm;
            CodeableConcept qzzze_ = a?.UnitOfPresentation;
            Quantity qzzzf_ = a?.Quantity;
            List<ResourceReference> qzzzg_ = a?.Manufacturer;
            List<ResourceReference> qzzzh_ = a?.Ingredient;
            ProdCharacteristic qzzzi_ = a?.PhysicalCharacteristics;
            List<CodeableConcept> qzzzj_ = a?.OtherCharacteristics;
            MedicinalProductManufactured qzzzk_ = new MedicinalProductManufactured
            {
                ManufacturedDoseForm = qzzzd_,
                UnitOfPresentation = qzzze_,
                Quantity = qzzzf_,
                Manufacturer = new List<ResourceReference>((IEnumerable<ResourceReference>)qzzzg_),
                Ingredient = new List<ResourceReference>((IEnumerable<ResourceReference>)qzzzh_),
                PhysicalCharacteristics = qzzzi_,
                OtherCharacteristics = new List<CodeableConcept>((IEnumerable<CodeableConcept>)qzzzj_),
            };

            return qzzzk_;
        };
        IEnumerable<MedicinalProductManufactured> qzzza_ = context.Operators.Select<MedicinalProductManufactured, MedicinalProductManufactured>((IEnumerable<MedicinalProductManufactured>)pzzzy_, pzzzz_);
        IEnumerable<MedicinalProductManufactured> qzzzb_ = context.Operators.Distinct<MedicinalProductManufactured>(qzzza_);
        MedicinalProductManufactured qzzzc_ = context.Operators.SingletonFrom<MedicinalProductManufactured>(qzzzb_);

        return qzzzc_;
    }


    [CqlExpressionDefinition("MedicinalProductPackagedResource")]
    public MedicinalProductPackaged MedicinalProductPackagedResource(CqlContext context, MedicinalProductPackaged arg)
    {
        MedicinalProductPackaged[] qzzzl_ = [
            arg,
        ];
        MedicinalProductPackaged qzzzm_(MedicinalProductPackaged a)
        {
            List<Identifier> qzzzq_ = a?.Identifier;
            List<ResourceReference> qzzzr_ = a?.Subject;
            FhirString qzzzs_ = a?.DescriptionElement;
            CodeableConcept qzzzt_ = a?.LegalStatusOfSupply;
            List<MarketingStatus> qzzzu_ = a?.MarketingStatus;
            ResourceReference qzzzv_ = a?.MarketingAuthorization;
            List<ResourceReference> qzzzw_ = a?.Manufacturer;
            List<MedicinalProductPackaged.BatchIdentifierComponent> qzzzx_ = a?.BatchIdentifier;
            List<MedicinalProductPackaged.PackageItemComponent> qzzzy_ = a?.PackageItem;
            MedicinalProductPackaged qzzzz_ = new MedicinalProductPackaged
            {
                Identifier = new List<Identifier>((IEnumerable<Identifier>)qzzzq_),
                Subject = new List<ResourceReference>((IEnumerable<ResourceReference>)qzzzr_),
                DescriptionElement = qzzzs_,
                LegalStatusOfSupply = qzzzt_,
                MarketingStatus = new List<MarketingStatus>((IEnumerable<MarketingStatus>)qzzzu_),
                MarketingAuthorization = qzzzv_,
                Manufacturer = new List<ResourceReference>((IEnumerable<ResourceReference>)qzzzw_),
                BatchIdentifier = new List<MedicinalProductPackaged.BatchIdentifierComponent>((IEnumerable<MedicinalProductPackaged.BatchIdentifierComponent>)qzzzx_),
                PackageItem = new List<MedicinalProductPackaged.PackageItemComponent>((IEnumerable<MedicinalProductPackaged.PackageItemComponent>)qzzzy_),
            };

            return qzzzz_;
        };
        IEnumerable<MedicinalProductPackaged> qzzzn_ = context.Operators.Select<MedicinalProductPackaged, MedicinalProductPackaged>((IEnumerable<MedicinalProductPackaged>)qzzzl_, qzzzm_);
        IEnumerable<MedicinalProductPackaged> qzzzo_ = context.Operators.Distinct<MedicinalProductPackaged>(qzzzn_);
        MedicinalProductPackaged qzzzp_ = context.Operators.SingletonFrom<MedicinalProductPackaged>(qzzzo_);

        return qzzzp_;
    }


    [CqlExpressionDefinition("MedicinalProductPharmaceuticalResource")]
    public MedicinalProductPharmaceutical MedicinalProductPharmaceuticalResource(CqlContext context, MedicinalProductPharmaceutical arg)
    {
        MedicinalProductPharmaceutical[] rzzza_ = [
            arg,
        ];
        MedicinalProductPharmaceutical rzzzb_(MedicinalProductPharmaceutical a)
        {
            List<Identifier> rzzzf_ = a?.Identifier;
            CodeableConcept rzzzg_ = a?.AdministrableDoseForm;
            CodeableConcept rzzzh_ = a?.UnitOfPresentation;
            List<ResourceReference> rzzzi_ = a?.Ingredient;
            List<ResourceReference> rzzzj_ = a?.Device;
            List<MedicinalProductPharmaceutical.CharacteristicsComponent> rzzzk_ = a?.Characteristics;
            List<MedicinalProductPharmaceutical.RouteOfAdministrationComponent> rzzzl_ = a?.RouteOfAdministration;
            MedicinalProductPharmaceutical rzzzm_ = new MedicinalProductPharmaceutical
            {
                Identifier = new List<Identifier>((IEnumerable<Identifier>)rzzzf_),
                AdministrableDoseForm = rzzzg_,
                UnitOfPresentation = rzzzh_,
                Ingredient = new List<ResourceReference>((IEnumerable<ResourceReference>)rzzzi_),
                Device = new List<ResourceReference>((IEnumerable<ResourceReference>)rzzzj_),
                Characteristics = new List<MedicinalProductPharmaceutical.CharacteristicsComponent>((IEnumerable<MedicinalProductPharmaceutical.CharacteristicsComponent>)rzzzk_),
                RouteOfAdministration = new List<MedicinalProductPharmaceutical.RouteOfAdministrationComponent>((IEnumerable<MedicinalProductPharmaceutical.RouteOfAdministrationComponent>)rzzzl_),
            };

            return rzzzm_;
        };
        IEnumerable<MedicinalProductPharmaceutical> rzzzc_ = context.Operators.Select<MedicinalProductPharmaceutical, MedicinalProductPharmaceutical>((IEnumerable<MedicinalProductPharmaceutical>)rzzza_, rzzzb_);
        IEnumerable<MedicinalProductPharmaceutical> rzzzd_ = context.Operators.Distinct<MedicinalProductPharmaceutical>(rzzzc_);
        MedicinalProductPharmaceutical rzzze_ = context.Operators.SingletonFrom<MedicinalProductPharmaceutical>(rzzzd_);

        return rzzze_;
    }


    [CqlExpressionDefinition("MedicinalProductUndesirableEffectResource")]
    public MedicinalProductUndesirableEffect MedicinalProductUndesirableEffectResource(CqlContext context, MedicinalProductUndesirableEffect arg)
    {
        MedicinalProductUndesirableEffect[] rzzzn_ = [
            arg,
        ];
        MedicinalProductUndesirableEffect rzzzo_(MedicinalProductUndesirableEffect a)
        {
            List<ResourceReference> rzzzs_ = a?.Subject;
            CodeableConcept rzzzt_ = a?.SymptomConditionEffect;
            CodeableConcept rzzzu_ = a?.Classification;
            CodeableConcept rzzzv_ = a?.FrequencyOfOccurrence;
            List<Population> rzzzw_ = a?.Population;
            MedicinalProductUndesirableEffect rzzzx_ = new MedicinalProductUndesirableEffect
            {
                Subject = new List<ResourceReference>((IEnumerable<ResourceReference>)rzzzs_),
                SymptomConditionEffect = rzzzt_,
                Classification = rzzzu_,
                FrequencyOfOccurrence = rzzzv_,
                Population = new List<Population>((IEnumerable<Population>)rzzzw_),
            };

            return rzzzx_;
        };
        IEnumerable<MedicinalProductUndesirableEffect> rzzzp_ = context.Operators.Select<MedicinalProductUndesirableEffect, MedicinalProductUndesirableEffect>((IEnumerable<MedicinalProductUndesirableEffect>)rzzzn_, rzzzo_);
        IEnumerable<MedicinalProductUndesirableEffect> rzzzq_ = context.Operators.Distinct<MedicinalProductUndesirableEffect>(rzzzp_);
        MedicinalProductUndesirableEffect rzzzr_ = context.Operators.SingletonFrom<MedicinalProductUndesirableEffect>(rzzzq_);

        return rzzzr_;
    }


    [CqlExpressionDefinition("MessageHeaderResource")]
    public MessageHeader MessageHeaderResource(CqlContext context, MessageHeader arg)
    {
        MessageHeader[] rzzzy_ = [
            arg,
        ];
        MessageHeader rzzzz_(MessageHeader a)
        {
            DataType szzzd_ = a?.Event;
            List<MessageHeader.MessageDestinationComponent> szzze_ = a?.Destination;
            ResourceReference szzzf_ = a?.Sender;
            ResourceReference szzzg_ = a?.Enterer;
            ResourceReference szzzh_ = a?.Author;
            MessageHeader.MessageSourceComponent szzzi_ = a?.Source;
            ResourceReference szzzj_ = a?.Responsible;
            CodeableConcept szzzk_ = a?.Reason;
            MessageHeader.ResponseComponent szzzl_ = a?.Response;
            List<ResourceReference> szzzm_ = a?.Focus;
            Canonical szzzn_ = a?.DefinitionElement;
            MessageHeader szzzo_ = new MessageHeader
            {
                Event = (DataType)szzzd_,
                Destination = new List<MessageHeader.MessageDestinationComponent>((IEnumerable<MessageHeader.MessageDestinationComponent>)szzze_),
                Sender = szzzf_,
                Enterer = szzzg_,
                Author = szzzh_,
                Source = szzzi_,
                Responsible = szzzj_,
                Reason = szzzk_,
                Response = szzzl_,
                Focus = new List<ResourceReference>((IEnumerable<ResourceReference>)szzzm_),
                DefinitionElement = szzzn_,
            };

            return szzzo_;
        };
        IEnumerable<MessageHeader> szzza_ = context.Operators.Select<MessageHeader, MessageHeader>((IEnumerable<MessageHeader>)rzzzy_, rzzzz_);
        IEnumerable<MessageHeader> szzzb_ = context.Operators.Distinct<MessageHeader>(szzza_);
        MessageHeader szzzc_ = context.Operators.SingletonFrom<MessageHeader>(szzzb_);

        return szzzc_;
    }


    [CqlExpressionDefinition("MolecularSequenceResource")]
    public MolecularSequence MolecularSequenceResource(CqlContext context, MolecularSequence arg)
    {
        MolecularSequence[] szzzp_ = [
            arg,
        ];
        MolecularSequence szzzq_(MolecularSequence a)
        {
            List<Identifier> szzzu_ = a?.Identifier;
            Code<MolecularSequence.SequenceType> szzzv_ = a?.TypeElement;
            Integer szzzw_ = a?.CoordinateSystemElement;
            ResourceReference szzzx_ = a?.Patient;
            ResourceReference szzzy_ = a?.Specimen;
            ResourceReference szzzz_ = a?.Device;
            ResourceReference tzzza_ = a?.Performer;
            Quantity tzzzb_ = a?.Quantity;
            MolecularSequence.ReferenceSeqComponent tzzzc_ = a?.ReferenceSeq;
            List<MolecularSequence.VariantComponent> tzzzd_ = a?.Variant;
            FhirString tzzze_ = a?.ObservedSeqElement;
            List<MolecularSequence.QualityComponent> tzzzf_ = a?.Quality;
            Integer tzzzg_ = a?.ReadCoverageElement;
            List<MolecularSequence.RepositoryComponent> tzzzh_ = a?.Repository;
            List<ResourceReference> tzzzi_ = a?.Pointer;
            List<MolecularSequence.StructureVariantComponent> tzzzj_ = a?.StructureVariant;
            MolecularSequence tzzzk_ = new MolecularSequence
            {
                Identifier = new List<Identifier>((IEnumerable<Identifier>)szzzu_),
                TypeElement = szzzv_,
                CoordinateSystemElement = szzzw_,
                Patient = szzzx_,
                Specimen = szzzy_,
                Device = szzzz_,
                Performer = tzzza_,
                Quantity = tzzzb_,
                ReferenceSeq = tzzzc_,
                Variant = new List<MolecularSequence.VariantComponent>((IEnumerable<MolecularSequence.VariantComponent>)tzzzd_),
                ObservedSeqElement = tzzze_,
                Quality = new List<MolecularSequence.QualityComponent>((IEnumerable<MolecularSequence.QualityComponent>)tzzzf_),
                ReadCoverageElement = tzzzg_,
                Repository = new List<MolecularSequence.RepositoryComponent>((IEnumerable<MolecularSequence.RepositoryComponent>)tzzzh_),
                Pointer = new List<ResourceReference>((IEnumerable<ResourceReference>)tzzzi_),
                StructureVariant = new List<MolecularSequence.StructureVariantComponent>((IEnumerable<MolecularSequence.StructureVariantComponent>)tzzzj_),
            };

            return tzzzk_;
        };
        IEnumerable<MolecularSequence> szzzr_ = context.Operators.Select<MolecularSequence, MolecularSequence>((IEnumerable<MolecularSequence>)szzzp_, szzzq_);
        IEnumerable<MolecularSequence> szzzs_ = context.Operators.Distinct<MolecularSequence>(szzzr_);
        MolecularSequence szzzt_ = context.Operators.SingletonFrom<MolecularSequence>(szzzs_);

        return szzzt_;
    }


    [CqlExpressionDefinition("NamingSystemResource")]
    public NamingSystem NamingSystemResource(CqlContext context, NamingSystem arg)
    {
        NamingSystem[] tzzzl_ = [
            arg,
        ];
        NamingSystem tzzzm_(NamingSystem a)
        {
            FhirString tzzzq_ = a?.NameElement;
            Code<PublicationStatus> tzzzr_ = a?.StatusElement;
            Code<NamingSystem.NamingSystemType> tzzzs_ = a?.KindElement;
            FhirDateTime tzzzt_ = a?.DateElement;
            FhirString tzzzu_ = a?.PublisherElement;
            List<ContactDetail> tzzzv_ = a?.Contact;
            FhirString tzzzw_ = a?.ResponsibleElement;
            CodeableConcept tzzzx_ = a?.Type;
            Markdown tzzzy_ = a?.DescriptionElement;
            List<UsageContext> tzzzz_ = a?.UseContext;
            List<CodeableConcept> uzzza_ = a?.Jurisdiction;
            FhirString uzzzb_ = a?.UsageElement;
            List<NamingSystem.UniqueIdComponent> uzzzc_ = a?.UniqueId;
            NamingSystem uzzzd_ = new NamingSystem
            {
                NameElement = tzzzq_,
                StatusElement = tzzzr_,
                KindElement = tzzzs_,
                DateElement = tzzzt_,
                PublisherElement = tzzzu_,
                Contact = new List<ContactDetail>((IEnumerable<ContactDetail>)tzzzv_),
                ResponsibleElement = tzzzw_,
                Type = tzzzx_,
                DescriptionElement = tzzzy_,
                UseContext = new List<UsageContext>((IEnumerable<UsageContext>)tzzzz_),
                Jurisdiction = new List<CodeableConcept>((IEnumerable<CodeableConcept>)uzzza_),
                UsageElement = uzzzb_,
                UniqueId = new List<NamingSystem.UniqueIdComponent>((IEnumerable<NamingSystem.UniqueIdComponent>)uzzzc_),
            };

            return uzzzd_;
        };
        IEnumerable<NamingSystem> tzzzn_ = context.Operators.Select<NamingSystem, NamingSystem>((IEnumerable<NamingSystem>)tzzzl_, tzzzm_);
        IEnumerable<NamingSystem> tzzzo_ = context.Operators.Distinct<NamingSystem>(tzzzn_);
        NamingSystem tzzzp_ = context.Operators.SingletonFrom<NamingSystem>(tzzzo_);

        return tzzzp_;
    }


    [CqlExpressionDefinition("NutritionOrderResource")]
    public NutritionOrder NutritionOrderResource(CqlContext context, NutritionOrder arg)
    {
        NutritionOrder[] uzzze_ = [
            arg,
        ];
        NutritionOrder uzzzf_(NutritionOrder a)
        {
            List<Identifier> uzzzj_ = a?.Identifier;
            List<Canonical> uzzzk_ = a?.InstantiatesCanonicalElement;
            List<FhirUri> uzzzl_ = a?.InstantiatesUriElement;
            List<FhirUri> uzzzm_ = a?.InstantiatesElement;
            Code<RequestStatus> uzzzn_ = a?.StatusElement;
            Code<RequestIntent> uzzzo_ = a?.IntentElement;
            ResourceReference uzzzp_ = a?.Patient;
            ResourceReference uzzzq_ = a?.Encounter;
            FhirDateTime uzzzr_ = a?.DateTimeElement;
            ResourceReference uzzzs_ = a?.Orderer;
            List<ResourceReference> uzzzt_ = a?.AllergyIntolerance;
            List<CodeableConcept> uzzzu_ = a?.FoodPreferenceModifier;
            List<CodeableConcept> uzzzv_ = a?.ExcludeFoodModifier;
            NutritionOrder.OralDietComponent uzzzw_ = a?.OralDiet;
            List<NutritionOrder.SupplementComponent> uzzzx_ = a?.Supplement;
            NutritionOrder.EnteralFormulaComponent uzzzy_ = a?.EnteralFormula;
            List<Annotation> uzzzz_ = a?.Note;
            NutritionOrder vzzza_ = new NutritionOrder
            {
                Identifier = new List<Identifier>((IEnumerable<Identifier>)uzzzj_),
                InstantiatesCanonicalElement = new List<Canonical>((IEnumerable<Canonical>)uzzzk_),
                InstantiatesUriElement = new List<FhirUri>((IEnumerable<FhirUri>)uzzzl_),
                InstantiatesElement = new List<FhirUri>((IEnumerable<FhirUri>)uzzzm_),
                StatusElement = uzzzn_,
                IntentElement = uzzzo_,
                Patient = uzzzp_,
                Encounter = uzzzq_,
                DateTimeElement = uzzzr_,
                Orderer = uzzzs_,
                AllergyIntolerance = new List<ResourceReference>((IEnumerable<ResourceReference>)uzzzt_),
                FoodPreferenceModifier = new List<CodeableConcept>((IEnumerable<CodeableConcept>)uzzzu_),
                ExcludeFoodModifier = new List<CodeableConcept>((IEnumerable<CodeableConcept>)uzzzv_),
                OralDiet = uzzzw_,
                Supplement = new List<NutritionOrder.SupplementComponent>((IEnumerable<NutritionOrder.SupplementComponent>)uzzzx_),
                EnteralFormula = uzzzy_,
                Note = new List<Annotation>((IEnumerable<Annotation>)uzzzz_),
            };

            return vzzza_;
        };
        IEnumerable<NutritionOrder> uzzzg_ = context.Operators.Select<NutritionOrder, NutritionOrder>((IEnumerable<NutritionOrder>)uzzze_, uzzzf_);
        IEnumerable<NutritionOrder> uzzzh_ = context.Operators.Distinct<NutritionOrder>(uzzzg_);
        NutritionOrder uzzzi_ = context.Operators.SingletonFrom<NutritionOrder>(uzzzh_);

        return uzzzi_;
    }


    [CqlExpressionDefinition("ObservationResource")]
    public Observation ObservationResource(CqlContext context, Observation arg)
    {
        Observation[] vzzzb_ = [
            arg,
        ];
        Observation vzzzc_(Observation a)
        {
            List<Identifier> vzzzg_ = a?.Identifier;
            List<ResourceReference> vzzzh_ = a?.BasedOn;
            List<ResourceReference> vzzzi_ = a?.PartOf;
            Code<ObservationStatus> vzzzj_ = a?.StatusElement;
            List<CodeableConcept> vzzzk_ = a?.Category;
            CodeableConcept vzzzl_ = a?.Code;
            ResourceReference vzzzm_ = a?.Subject;
            List<ResourceReference> vzzzn_ = a?.Focus;
            ResourceReference vzzzo_ = a?.Encounter;
            DataType vzzzp_ = a?.Effective;
            Instant vzzzq_ = a?.IssuedElement;
            List<ResourceReference> vzzzr_ = a?.Performer;
            DataType vzzzs_ = a?.Value;
            CodeableConcept vzzzt_ = a?.DataAbsentReason;
            List<CodeableConcept> vzzzu_ = a?.Interpretation;
            List<Annotation> vzzzv_ = a?.Note;
            CodeableConcept vzzzw_ = a?.BodySite;
            CodeableConcept vzzzx_ = a?.Method;
            ResourceReference vzzzy_ = a?.Specimen;
            ResourceReference vzzzz_ = a?.Device;
            List<Observation.ReferenceRangeComponent> wzzza_ = a?.ReferenceRange;
            List<ResourceReference> wzzzb_ = a?.HasMember;
            List<ResourceReference> wzzzc_ = a?.DerivedFrom;
            List<Observation.ComponentComponent> wzzzd_ = a?.Component;
            Observation wzzze_ = new Observation
            {
                Identifier = new List<Identifier>((IEnumerable<Identifier>)vzzzg_),
                BasedOn = new List<ResourceReference>((IEnumerable<ResourceReference>)vzzzh_),
                PartOf = new List<ResourceReference>((IEnumerable<ResourceReference>)vzzzi_),
                StatusElement = vzzzj_,
                Category = new List<CodeableConcept>((IEnumerable<CodeableConcept>)vzzzk_),
                Code = vzzzl_,
                Subject = vzzzm_,
                Focus = new List<ResourceReference>((IEnumerable<ResourceReference>)vzzzn_),
                Encounter = vzzzo_,
                Effective = (DataType)vzzzp_,
                IssuedElement = vzzzq_,
                Performer = new List<ResourceReference>((IEnumerable<ResourceReference>)vzzzr_),
                Value = (DataType)vzzzs_,
                DataAbsentReason = vzzzt_,
                Interpretation = new List<CodeableConcept>((IEnumerable<CodeableConcept>)vzzzu_),
                Note = new List<Annotation>((IEnumerable<Annotation>)vzzzv_),
                BodySite = vzzzw_,
                Method = vzzzx_,
                Specimen = vzzzy_,
                Device = vzzzz_,
                ReferenceRange = new List<Observation.ReferenceRangeComponent>((IEnumerable<Observation.ReferenceRangeComponent>)wzzza_),
                HasMember = new List<ResourceReference>((IEnumerable<ResourceReference>)wzzzb_),
                DerivedFrom = new List<ResourceReference>((IEnumerable<ResourceReference>)wzzzc_),
                Component = new List<Observation.ComponentComponent>((IEnumerable<Observation.ComponentComponent>)wzzzd_),
            };

            return wzzze_;
        };
        IEnumerable<Observation> vzzzd_ = context.Operators.Select<Observation, Observation>((IEnumerable<Observation>)vzzzb_, vzzzc_);
        IEnumerable<Observation> vzzze_ = context.Operators.Distinct<Observation>(vzzzd_);
        Observation vzzzf_ = context.Operators.SingletonFrom<Observation>(vzzze_);

        return vzzzf_;
    }


    [CqlExpressionDefinition("ObservationDefinitionResource")]
    public ObservationDefinition ObservationDefinitionResource(CqlContext context, ObservationDefinition arg)
    {
        ObservationDefinition[] wzzzf_ = [
            arg,
        ];
        ObservationDefinition wzzzg_(ObservationDefinition a)
        {
            List<CodeableConcept> wzzzk_ = a?.Category;
            CodeableConcept wzzzl_ = a?.Code;
            List<Identifier> wzzzm_ = a?.Identifier;
            List<Code<ObservationDefinition.ObservationDataType>> wzzzn_ = a?.PermittedDataTypeElement;
            FhirBoolean wzzzo_ = a?.MultipleResultsAllowedElement;
            CodeableConcept wzzzp_ = a?.Method;
            FhirString wzzzq_ = a?.PreferredReportNameElement;
            ObservationDefinition.QuantitativeDetailsComponent wzzzr_ = a?.QuantitativeDetails;
            List<ObservationDefinition.QualifiedIntervalComponent> wzzzs_ = a?.QualifiedInterval;
            ResourceReference wzzzt_ = a?.ValidCodedValueSet;
            ResourceReference wzzzu_ = a?.NormalCodedValueSet;
            ResourceReference wzzzv_ = a?.AbnormalCodedValueSet;
            ResourceReference wzzzw_ = a?.CriticalCodedValueSet;
            ObservationDefinition wzzzx_ = new ObservationDefinition
            {
                Category = new List<CodeableConcept>((IEnumerable<CodeableConcept>)wzzzk_),
                Code = wzzzl_,
                Identifier = new List<Identifier>((IEnumerable<Identifier>)wzzzm_),
                PermittedDataTypeElement = new List<Code<ObservationDefinition.ObservationDataType>>((IEnumerable<Code<ObservationDefinition.ObservationDataType>>)wzzzn_),
                MultipleResultsAllowedElement = wzzzo_,
                Method = wzzzp_,
                PreferredReportNameElement = wzzzq_,
                QuantitativeDetails = wzzzr_,
                QualifiedInterval = new List<ObservationDefinition.QualifiedIntervalComponent>((IEnumerable<ObservationDefinition.QualifiedIntervalComponent>)wzzzs_),
                ValidCodedValueSet = wzzzt_,
                NormalCodedValueSet = wzzzu_,
                AbnormalCodedValueSet = wzzzv_,
                CriticalCodedValueSet = wzzzw_,
            };

            return wzzzx_;
        };
        IEnumerable<ObservationDefinition> wzzzh_ = context.Operators.Select<ObservationDefinition, ObservationDefinition>((IEnumerable<ObservationDefinition>)wzzzf_, wzzzg_);
        IEnumerable<ObservationDefinition> wzzzi_ = context.Operators.Distinct<ObservationDefinition>(wzzzh_);
        ObservationDefinition wzzzj_ = context.Operators.SingletonFrom<ObservationDefinition>(wzzzi_);

        return wzzzj_;
    }


    [CqlExpressionDefinition("OperationOutcomeResource")]
    public OperationOutcome OperationOutcomeResource(CqlContext context, OperationOutcome arg)
    {
        OperationOutcome[] wzzzy_ = [
            arg,
        ];
        OperationOutcome wzzzz_(OperationOutcome a)
        {
            List<OperationOutcome.IssueComponent> xzzzd_ = a?.Issue;
            OperationOutcome xzzze_ = new OperationOutcome
            {
                Issue = new List<OperationOutcome.IssueComponent>((IEnumerable<OperationOutcome.IssueComponent>)xzzzd_),
            };

            return xzzze_;
        };
        IEnumerable<OperationOutcome> xzzza_ = context.Operators.Select<OperationOutcome, OperationOutcome>((IEnumerable<OperationOutcome>)wzzzy_, wzzzz_);
        IEnumerable<OperationOutcome> xzzzb_ = context.Operators.Distinct<OperationOutcome>(xzzza_);
        OperationOutcome xzzzc_ = context.Operators.SingletonFrom<OperationOutcome>(xzzzb_);

        return xzzzc_;
    }


    [CqlExpressionDefinition("OrganizationResource")]
    public Organization OrganizationResource(CqlContext context, Organization arg)
    {
        Organization[] xzzzf_ = [
            arg,
        ];
        Organization xzzzg_(Organization a)
        {
            List<Identifier> xzzzk_ = a?.Identifier;
            FhirBoolean xzzzl_ = a?.ActiveElement;
            List<CodeableConcept> xzzzm_ = a?.Type;
            FhirString xzzzn_ = a?.NameElement;
            List<FhirString> xzzzo_ = a?.AliasElement;
            List<ContactPoint> xzzzp_ = a?.Telecom;
            List<Address> xzzzq_ = a?.Address;
            ResourceReference xzzzr_ = a?.PartOf;
            List<Organization.ContactComponent> xzzzs_ = a?.Contact;
            List<ResourceReference> xzzzt_ = a?.Endpoint;
            Organization xzzzu_ = new Organization
            {
                Identifier = new List<Identifier>((IEnumerable<Identifier>)xzzzk_),
                ActiveElement = xzzzl_,
                Type = new List<CodeableConcept>((IEnumerable<CodeableConcept>)xzzzm_),
                NameElement = xzzzn_,
                AliasElement = new List<FhirString>((IEnumerable<FhirString>)xzzzo_),
                Telecom = new List<ContactPoint>((IEnumerable<ContactPoint>)xzzzp_),
                Address = new List<Address>((IEnumerable<Address>)xzzzq_),
                PartOf = xzzzr_,
                Contact = new List<Organization.ContactComponent>((IEnumerable<Organization.ContactComponent>)xzzzs_),
                Endpoint = new List<ResourceReference>((IEnumerable<ResourceReference>)xzzzt_),
            };

            return xzzzu_;
        };
        IEnumerable<Organization> xzzzh_ = context.Operators.Select<Organization, Organization>((IEnumerable<Organization>)xzzzf_, xzzzg_);
        IEnumerable<Organization> xzzzi_ = context.Operators.Distinct<Organization>(xzzzh_);
        Organization xzzzj_ = context.Operators.SingletonFrom<Organization>(xzzzi_);

        return xzzzj_;
    }


    [CqlExpressionDefinition("OrganizationAffiliationResource")]
    public OrganizationAffiliation OrganizationAffiliationResource(CqlContext context, OrganizationAffiliation arg)
    {
        OrganizationAffiliation[] xzzzv_ = [
            arg,
        ];
        OrganizationAffiliation xzzzw_(OrganizationAffiliation a)
        {
            List<Identifier> yzzza_ = a?.Identifier;
            FhirBoolean yzzzb_ = a?.ActiveElement;
            Period yzzzc_ = a?.Period;
            ResourceReference yzzzd_ = a?.Organization;
            ResourceReference yzzze_ = a?.ParticipatingOrganization;
            List<ResourceReference> yzzzf_ = a?.Network;
            List<CodeableConcept> yzzzg_ = a?.Code;
            List<CodeableConcept> yzzzh_ = a?.Specialty;
            List<ResourceReference> yzzzi_ = a?.Location;
            List<ResourceReference> yzzzj_ = a?.HealthcareService;
            List<ContactPoint> yzzzk_ = a?.Telecom;
            List<ResourceReference> yzzzl_ = a?.Endpoint;
            OrganizationAffiliation yzzzm_ = new OrganizationAffiliation
            {
                Identifier = new List<Identifier>((IEnumerable<Identifier>)yzzza_),
                ActiveElement = yzzzb_,
                Period = yzzzc_,
                Organization = yzzzd_,
                ParticipatingOrganization = yzzze_,
                Network = new List<ResourceReference>((IEnumerable<ResourceReference>)yzzzf_),
                Code = new List<CodeableConcept>((IEnumerable<CodeableConcept>)yzzzg_),
                Specialty = new List<CodeableConcept>((IEnumerable<CodeableConcept>)yzzzh_),
                Location = new List<ResourceReference>((IEnumerable<ResourceReference>)yzzzi_),
                HealthcareService = new List<ResourceReference>((IEnumerable<ResourceReference>)yzzzj_),
                Telecom = new List<ContactPoint>((IEnumerable<ContactPoint>)yzzzk_),
                Endpoint = new List<ResourceReference>((IEnumerable<ResourceReference>)yzzzl_),
            };

            return yzzzm_;
        };
        IEnumerable<OrganizationAffiliation> xzzzx_ = context.Operators.Select<OrganizationAffiliation, OrganizationAffiliation>((IEnumerable<OrganizationAffiliation>)xzzzv_, xzzzw_);
        IEnumerable<OrganizationAffiliation> xzzzy_ = context.Operators.Distinct<OrganizationAffiliation>(xzzzx_);
        OrganizationAffiliation xzzzz_ = context.Operators.SingletonFrom<OrganizationAffiliation>(xzzzy_);

        return xzzzz_;
    }


    [CqlExpressionDefinition("PatientResource")]
    public Patient PatientResource(CqlContext context, Patient arg)
    {
        Patient[] yzzzn_ = [
            arg,
        ];
        Patient yzzzo_(Patient a)
        {
            List<Identifier> yzzzs_ = a?.Identifier;
            FhirBoolean yzzzt_ = a?.ActiveElement;
            List<HumanName> yzzzu_ = a?.Name;
            List<ContactPoint> yzzzv_ = a?.Telecom;
            Code<AdministrativeGender> yzzzw_ = a?.GenderElement;
            Date yzzzx_ = a?.BirthDateElement;
            DataType yzzzy_ = a?.Deceased;
            List<Address> yzzzz_ = a?.Address;
            CodeableConcept zzzza_ = a?.MaritalStatus;
            DataType zzzzb_ = a?.MultipleBirth;
            List<Attachment> zzzzc_ = a?.Photo;
            List<Patient.ContactComponent> zzzzd_ = a?.Contact;
            List<Patient.CommunicationComponent> zzzze_ = a?.Communication;
            List<ResourceReference> zzzzf_ = a?.GeneralPractitioner;
            ResourceReference zzzzg_ = a?.ManagingOrganization;
            List<Patient.LinkComponent> zzzzh_ = a?.Link;
            Patient zzzzi_ = new Patient
            {
                Identifier = new List<Identifier>((IEnumerable<Identifier>)yzzzs_),
                ActiveElement = yzzzt_,
                Name = new List<HumanName>((IEnumerable<HumanName>)yzzzu_),
                Telecom = new List<ContactPoint>((IEnumerable<ContactPoint>)yzzzv_),
                GenderElement = yzzzw_,
                BirthDateElement = yzzzx_,
                Deceased = (DataType)yzzzy_,
                Address = new List<Address>((IEnumerable<Address>)yzzzz_),
                MaritalStatus = zzzza_,
                MultipleBirth = (DataType)zzzzb_,
                Photo = new List<Attachment>((IEnumerable<Attachment>)zzzzc_),
                Contact = new List<Patient.ContactComponent>((IEnumerable<Patient.ContactComponent>)zzzzd_),
                Communication = new List<Patient.CommunicationComponent>((IEnumerable<Patient.CommunicationComponent>)zzzze_),
                GeneralPractitioner = new List<ResourceReference>((IEnumerable<ResourceReference>)zzzzf_),
                ManagingOrganization = zzzzg_,
                Link = new List<Patient.LinkComponent>((IEnumerable<Patient.LinkComponent>)zzzzh_),
            };

            return zzzzi_;
        };
        IEnumerable<Patient> yzzzp_ = context.Operators.Select<Patient, Patient>((IEnumerable<Patient>)yzzzn_, yzzzo_);
        IEnumerable<Patient> yzzzq_ = context.Operators.Distinct<Patient>(yzzzp_);
        Patient yzzzr_ = context.Operators.SingletonFrom<Patient>(yzzzq_);

        return yzzzr_;
    }


    [CqlExpressionDefinition("PaymentNoticeResource")]
    public PaymentNotice PaymentNoticeResource(CqlContext context, PaymentNotice arg)
    {
        PaymentNotice[] zzzzj_ = [
            arg,
        ];
        PaymentNotice zzzzk_(PaymentNotice a)
        {
            List<Identifier> zzzzo_ = a?.Identifier;
            Code<FinancialResourceStatusCodes> zzzzp_ = a?.StatusElement;
            ResourceReference zzzzq_ = a?.Request;
            ResourceReference zzzzr_ = a?.Response;
            FhirDateTime zzzzs_ = a?.CreatedElement;
            ResourceReference zzzzt_ = a?.Provider;
            ResourceReference zzzzu_ = a?.Payment;
            Date zzzzv_ = a?.PaymentDateElement;
            ResourceReference zzzzw_ = a?.Payee;
            ResourceReference zzzzx_ = a?.Recipient;
            Money zzzzy_ = a?.Amount;
            CodeableConcept zzzzz_ = a?.PaymentStatus;
            PaymentNotice azzzza_ = new PaymentNotice
            {
                Identifier = new List<Identifier>((IEnumerable<Identifier>)zzzzo_),
                StatusElement = zzzzp_,
                Request = zzzzq_,
                Response = zzzzr_,
                CreatedElement = zzzzs_,
                Provider = zzzzt_,
                Payment = zzzzu_,
                PaymentDateElement = zzzzv_,
                Payee = zzzzw_,
                Recipient = zzzzx_,
                Amount = zzzzy_,
                PaymentStatus = zzzzz_,
            };

            return azzzza_;
        };
        IEnumerable<PaymentNotice> zzzzl_ = context.Operators.Select<PaymentNotice, PaymentNotice>((IEnumerable<PaymentNotice>)zzzzj_, zzzzk_);
        IEnumerable<PaymentNotice> zzzzm_ = context.Operators.Distinct<PaymentNotice>(zzzzl_);
        PaymentNotice zzzzn_ = context.Operators.SingletonFrom<PaymentNotice>(zzzzm_);

        return zzzzn_;
    }


    [CqlExpressionDefinition("PaymentReconciliationResource")]
    public PaymentReconciliation PaymentReconciliationResource(CqlContext context, PaymentReconciliation arg)
    {
        PaymentReconciliation[] azzzzb_ = [
            arg,
        ];
        PaymentReconciliation azzzzc_(PaymentReconciliation a)
        {
            List<Identifier> azzzzg_ = a?.Identifier;
            Code<FinancialResourceStatusCodes> azzzzh_ = a?.StatusElement;
            Period azzzzi_ = a?.Period;
            FhirDateTime azzzzj_ = a?.CreatedElement;
            ResourceReference azzzzk_ = a?.PaymentIssuer;
            ResourceReference azzzzl_ = a?.Request;
            ResourceReference azzzzm_ = a?.Requestor;
            Code<ClaimProcessingCodes> azzzzn_ = a?.OutcomeElement;
            FhirString azzzzo_ = a?.DispositionElement;
            Date azzzzp_ = a?.PaymentDateElement;
            Money azzzzq_ = a?.PaymentAmount;
            Identifier azzzzr_ = a?.PaymentIdentifier;
            List<PaymentReconciliation.DetailsComponent> azzzzs_ = a?.Detail;
            CodeableConcept azzzzt_ = a?.FormCode;
            List<PaymentReconciliation.NotesComponent> azzzzu_ = a?.ProcessNote;
            PaymentReconciliation azzzzv_ = new PaymentReconciliation
            {
                Identifier = new List<Identifier>((IEnumerable<Identifier>)azzzzg_),
                StatusElement = azzzzh_,
                Period = azzzzi_,
                CreatedElement = azzzzj_,
                PaymentIssuer = azzzzk_,
                Request = azzzzl_,
                Requestor = azzzzm_,
                OutcomeElement = azzzzn_,
                DispositionElement = azzzzo_,
                PaymentDateElement = azzzzp_,
                PaymentAmount = azzzzq_,
                PaymentIdentifier = azzzzr_,
                Detail = new List<PaymentReconciliation.DetailsComponent>((IEnumerable<PaymentReconciliation.DetailsComponent>)azzzzs_),
                FormCode = azzzzt_,
                ProcessNote = new List<PaymentReconciliation.NotesComponent>((IEnumerable<PaymentReconciliation.NotesComponent>)azzzzu_),
            };

            return azzzzv_;
        };
        IEnumerable<PaymentReconciliation> azzzzd_ = context.Operators.Select<PaymentReconciliation, PaymentReconciliation>((IEnumerable<PaymentReconciliation>)azzzzb_, azzzzc_);
        IEnumerable<PaymentReconciliation> azzzze_ = context.Operators.Distinct<PaymentReconciliation>(azzzzd_);
        PaymentReconciliation azzzzf_ = context.Operators.SingletonFrom<PaymentReconciliation>(azzzze_);

        return azzzzf_;
    }


    [CqlExpressionDefinition("PersonResource")]
    public Person PersonResource(CqlContext context, Person arg)
    {
        Person[] azzzzw_ = [
            arg,
        ];
        Person azzzzx_(Person a)
        {
            List<Identifier> bzzzzb_ = a?.Identifier;
            List<HumanName> bzzzzc_ = a?.Name;
            List<ContactPoint> bzzzzd_ = a?.Telecom;
            Code<AdministrativeGender> bzzzze_ = a?.GenderElement;
            Date bzzzzf_ = a?.BirthDateElement;
            List<Address> bzzzzg_ = a?.Address;
            Attachment bzzzzh_ = a?.Photo;
            ResourceReference bzzzzi_ = a?.ManagingOrganization;
            FhirBoolean bzzzzj_ = a?.ActiveElement;
            List<Person.LinkComponent> bzzzzk_ = a?.Link;
            Person bzzzzl_ = new Person
            {
                Identifier = new List<Identifier>((IEnumerable<Identifier>)bzzzzb_),
                Name = new List<HumanName>((IEnumerable<HumanName>)bzzzzc_),
                Telecom = new List<ContactPoint>((IEnumerable<ContactPoint>)bzzzzd_),
                GenderElement = bzzzze_,
                BirthDateElement = bzzzzf_,
                Address = new List<Address>((IEnumerable<Address>)bzzzzg_),
                Photo = bzzzzh_,
                ManagingOrganization = bzzzzi_,
                ActiveElement = bzzzzj_,
                Link = new List<Person.LinkComponent>((IEnumerable<Person.LinkComponent>)bzzzzk_),
            };

            return bzzzzl_;
        };
        IEnumerable<Person> azzzzy_ = context.Operators.Select<Person, Person>((IEnumerable<Person>)azzzzw_, azzzzx_);
        IEnumerable<Person> azzzzz_ = context.Operators.Distinct<Person>(azzzzy_);
        Person bzzzza_ = context.Operators.SingletonFrom<Person>(azzzzz_);

        return bzzzza_;
    }


    [CqlExpressionDefinition("PlanDefinitionResource")]
    public PlanDefinition PlanDefinitionResource(CqlContext context, PlanDefinition arg)
    {
        PlanDefinition[] bzzzzm_ = [
            arg,
        ];
        PlanDefinition bzzzzn_(PlanDefinition a)
        {
            FhirUri bzzzzr_ = a?.UrlElement;
            List<Identifier> bzzzzs_ = a?.Identifier;
            FhirString bzzzzt_ = a?.VersionElement;
            FhirString bzzzzu_ = a?.NameElement;
            FhirString bzzzzv_ = a?.TitleElement;
            FhirString bzzzzw_ = a?.SubtitleElement;
            CodeableConcept bzzzzx_ = a?.Type;
            Code<PublicationStatus> bzzzzy_ = a?.StatusElement;
            FhirBoolean bzzzzz_ = a?.ExperimentalElement;
            DataType czzzza_ = a?.Subject;
            FhirDateTime czzzzb_ = a?.DateElement;
            FhirString czzzzc_ = a?.PublisherElement;
            List<ContactDetail> czzzzd_ = a?.Contact;
            Markdown czzzze_ = a?.DescriptionElement;
            List<UsageContext> czzzzf_ = a?.UseContext;
            List<CodeableConcept> czzzzg_ = a?.Jurisdiction;
            Markdown czzzzh_ = a?.PurposeElement;
            FhirString czzzzi_ = a?.UsageElement;
            Markdown czzzzj_ = a?.CopyrightElement;
            Date czzzzk_ = a?.ApprovalDateElement;
            Date czzzzl_ = a?.LastReviewDateElement;
            Period czzzzm_ = a?.EffectivePeriod;
            List<CodeableConcept> czzzzn_ = a?.Topic;
            List<ContactDetail> czzzzo_ = a?.Author;
            List<ContactDetail> czzzzp_ = a?.Editor;
            List<ContactDetail> czzzzq_ = a?.Reviewer;
            List<ContactDetail> czzzzr_ = a?.Endorser;
            List<RelatedArtifact> czzzzs_ = a?.RelatedArtifact;
            List<Canonical> czzzzt_ = a?.LibraryElement;
            List<PlanDefinition.GoalComponent> czzzzu_ = a?.Goal;
            List<PlanDefinition.ActionComponent> czzzzv_ = a?.Action;
            PlanDefinition czzzzw_ = new PlanDefinition
            {
                UrlElement = bzzzzr_,
                Identifier = new List<Identifier>((IEnumerable<Identifier>)bzzzzs_),
                VersionElement = bzzzzt_,
                NameElement = bzzzzu_,
                TitleElement = bzzzzv_,
                SubtitleElement = bzzzzw_,
                Type = bzzzzx_,
                StatusElement = bzzzzy_,
                ExperimentalElement = bzzzzz_,
                Subject = (DataType)czzzza_,
                DateElement = czzzzb_,
                PublisherElement = czzzzc_,
                Contact = new List<ContactDetail>((IEnumerable<ContactDetail>)czzzzd_),
                DescriptionElement = czzzze_,
                UseContext = new List<UsageContext>((IEnumerable<UsageContext>)czzzzf_),
                Jurisdiction = new List<CodeableConcept>((IEnumerable<CodeableConcept>)czzzzg_),
                PurposeElement = czzzzh_,
                UsageElement = czzzzi_,
                CopyrightElement = czzzzj_,
                ApprovalDateElement = czzzzk_,
                LastReviewDateElement = czzzzl_,
                EffectivePeriod = czzzzm_,
                Topic = new List<CodeableConcept>((IEnumerable<CodeableConcept>)czzzzn_),
                Author = new List<ContactDetail>((IEnumerable<ContactDetail>)czzzzo_),
                Editor = new List<ContactDetail>((IEnumerable<ContactDetail>)czzzzp_),
                Reviewer = new List<ContactDetail>((IEnumerable<ContactDetail>)czzzzq_),
                Endorser = new List<ContactDetail>((IEnumerable<ContactDetail>)czzzzr_),
                RelatedArtifact = new List<RelatedArtifact>((IEnumerable<RelatedArtifact>)czzzzs_),
                LibraryElement = new List<Canonical>((IEnumerable<Canonical>)czzzzt_),
                Goal = new List<PlanDefinition.GoalComponent>((IEnumerable<PlanDefinition.GoalComponent>)czzzzu_),
                Action = new List<PlanDefinition.ActionComponent>((IEnumerable<PlanDefinition.ActionComponent>)czzzzv_),
            };

            return czzzzw_;
        };
        IEnumerable<PlanDefinition> bzzzzo_ = context.Operators.Select<PlanDefinition, PlanDefinition>((IEnumerable<PlanDefinition>)bzzzzm_, bzzzzn_);
        IEnumerable<PlanDefinition> bzzzzp_ = context.Operators.Distinct<PlanDefinition>(bzzzzo_);
        PlanDefinition bzzzzq_ = context.Operators.SingletonFrom<PlanDefinition>(bzzzzp_);

        return bzzzzq_;
    }


    [CqlExpressionDefinition("PractitionerResource")]
    public Practitioner PractitionerResource(CqlContext context, Practitioner arg)
    {
        Practitioner[] czzzzx_ = [
            arg,
        ];
        Practitioner czzzzy_(Practitioner a)
        {
            List<Identifier> dzzzzc_ = a?.Identifier;
            FhirBoolean dzzzzd_ = a?.ActiveElement;
            List<HumanName> dzzzze_ = a?.Name;
            List<ContactPoint> dzzzzf_ = a?.Telecom;
            List<Address> dzzzzg_ = a?.Address;
            Code<AdministrativeGender> dzzzzh_ = a?.GenderElement;
            Date dzzzzi_ = a?.BirthDateElement;
            List<Attachment> dzzzzj_ = a?.Photo;
            List<Practitioner.QualificationComponent> dzzzzk_ = a?.Qualification;
            List<CodeableConcept> dzzzzl_ = a?.Communication;
            Practitioner dzzzzm_ = new Practitioner
            {
                Identifier = new List<Identifier>((IEnumerable<Identifier>)dzzzzc_),
                ActiveElement = dzzzzd_,
                Name = new List<HumanName>((IEnumerable<HumanName>)dzzzze_),
                Telecom = new List<ContactPoint>((IEnumerable<ContactPoint>)dzzzzf_),
                Address = new List<Address>((IEnumerable<Address>)dzzzzg_),
                GenderElement = dzzzzh_,
                BirthDateElement = dzzzzi_,
                Photo = new List<Attachment>((IEnumerable<Attachment>)dzzzzj_),
                Qualification = new List<Practitioner.QualificationComponent>((IEnumerable<Practitioner.QualificationComponent>)dzzzzk_),
                Communication = new List<CodeableConcept>((IEnumerable<CodeableConcept>)dzzzzl_),
            };

            return dzzzzm_;
        };
        IEnumerable<Practitioner> czzzzz_ = context.Operators.Select<Practitioner, Practitioner>((IEnumerable<Practitioner>)czzzzx_, czzzzy_);
        IEnumerable<Practitioner> dzzzza_ = context.Operators.Distinct<Practitioner>(czzzzz_);
        Practitioner dzzzzb_ = context.Operators.SingletonFrom<Practitioner>(dzzzza_);

        return dzzzzb_;
    }


    [CqlExpressionDefinition("PractitionerRoleResource")]
    public PractitionerRole PractitionerRoleResource(CqlContext context, PractitionerRole arg)
    {
        PractitionerRole[] dzzzzn_ = [
            arg,
        ];
        PractitionerRole dzzzzo_(PractitionerRole a)
        {
            List<Identifier> dzzzzs_ = a?.Identifier;
            FhirBoolean dzzzzt_ = a?.ActiveElement;
            Period dzzzzu_ = a?.Period;
            ResourceReference dzzzzv_ = a?.Practitioner;
            ResourceReference dzzzzw_ = a?.Organization;
            List<CodeableConcept> dzzzzx_ = a?.Code;
            List<CodeableConcept> dzzzzy_ = a?.Specialty;
            List<ResourceReference> dzzzzz_ = a?.Location;
            List<ResourceReference> ezzzza_ = a?.HealthcareService;
            List<ContactPoint> ezzzzb_ = a?.Telecom;
            List<PractitionerRole.AvailableTimeComponent> ezzzzc_ = a?.AvailableTime;
            List<PractitionerRole.NotAvailableComponent> ezzzzd_ = a?.NotAvailable;
            FhirString ezzzze_ = a?.AvailabilityExceptionsElement;
            List<ResourceReference> ezzzzf_ = a?.Endpoint;
            PractitionerRole ezzzzg_ = new PractitionerRole
            {
                Identifier = new List<Identifier>((IEnumerable<Identifier>)dzzzzs_),
                ActiveElement = dzzzzt_,
                Period = dzzzzu_,
                Practitioner = dzzzzv_,
                Organization = dzzzzw_,
                Code = new List<CodeableConcept>((IEnumerable<CodeableConcept>)dzzzzx_),
                Specialty = new List<CodeableConcept>((IEnumerable<CodeableConcept>)dzzzzy_),
                Location = new List<ResourceReference>((IEnumerable<ResourceReference>)dzzzzz_),
                HealthcareService = new List<ResourceReference>((IEnumerable<ResourceReference>)ezzzza_),
                Telecom = new List<ContactPoint>((IEnumerable<ContactPoint>)ezzzzb_),
                AvailableTime = new List<PractitionerRole.AvailableTimeComponent>((IEnumerable<PractitionerRole.AvailableTimeComponent>)ezzzzc_),
                NotAvailable = new List<PractitionerRole.NotAvailableComponent>((IEnumerable<PractitionerRole.NotAvailableComponent>)ezzzzd_),
                AvailabilityExceptionsElement = ezzzze_,
                Endpoint = new List<ResourceReference>((IEnumerable<ResourceReference>)ezzzzf_),
            };

            return ezzzzg_;
        };
        IEnumerable<PractitionerRole> dzzzzp_ = context.Operators.Select<PractitionerRole, PractitionerRole>((IEnumerable<PractitionerRole>)dzzzzn_, dzzzzo_);
        IEnumerable<PractitionerRole> dzzzzq_ = context.Operators.Distinct<PractitionerRole>(dzzzzp_);
        PractitionerRole dzzzzr_ = context.Operators.SingletonFrom<PractitionerRole>(dzzzzq_);

        return dzzzzr_;
    }


    [CqlExpressionDefinition("ProcedureResource")]
    public Procedure ProcedureResource(CqlContext context, Procedure arg)
    {
        Procedure[] ezzzzh_ = [
            arg,
        ];
        Procedure ezzzzi_(Procedure a)
        {
            List<Identifier> ezzzzm_ = a?.Identifier;
            List<Canonical> ezzzzn_ = a?.InstantiatesCanonicalElement;
            List<FhirUri> ezzzzo_ = a?.InstantiatesUriElement;
            List<ResourceReference> ezzzzp_ = a?.BasedOn;
            List<ResourceReference> ezzzzq_ = a?.PartOf;
            Code<EventStatus> ezzzzr_ = a?.StatusElement;
            CodeableConcept ezzzzs_ = a?.StatusReason;
            CodeableConcept ezzzzt_ = a?.Category;
            CodeableConcept ezzzzu_ = a?.Code;
            ResourceReference ezzzzv_ = a?.Subject;
            ResourceReference ezzzzw_ = a?.Encounter;
            DataType ezzzzx_ = a?.Performed;
            ResourceReference ezzzzy_ = a?.Recorder;
            ResourceReference ezzzzz_ = a?.Asserter;
            List<Procedure.PerformerComponent> fzzzza_ = a?.Performer;
            ResourceReference fzzzzb_ = a?.Location;
            List<CodeableConcept> fzzzzc_ = a?.ReasonCode;
            List<ResourceReference> fzzzzd_ = a?.ReasonReference;
            List<CodeableConcept> fzzzze_ = a?.BodySite;
            CodeableConcept fzzzzf_ = a?.Outcome;
            List<ResourceReference> fzzzzg_ = a?.Report;
            List<CodeableConcept> fzzzzh_ = a?.Complication;
            List<ResourceReference> fzzzzi_ = a?.ComplicationDetail;
            List<CodeableConcept> fzzzzj_ = a?.FollowUp;
            List<Annotation> fzzzzk_ = a?.Note;
            List<Procedure.FocalDeviceComponent> fzzzzl_ = a?.FocalDevice;
            List<ResourceReference> fzzzzm_ = a?.UsedReference;
            List<CodeableConcept> fzzzzn_ = a?.UsedCode;
            Procedure fzzzzo_ = new Procedure
            {
                Identifier = new List<Identifier>((IEnumerable<Identifier>)ezzzzm_),
                InstantiatesCanonicalElement = new List<Canonical>((IEnumerable<Canonical>)ezzzzn_),
                InstantiatesUriElement = new List<FhirUri>((IEnumerable<FhirUri>)ezzzzo_),
                BasedOn = new List<ResourceReference>((IEnumerable<ResourceReference>)ezzzzp_),
                PartOf = new List<ResourceReference>((IEnumerable<ResourceReference>)ezzzzq_),
                StatusElement = ezzzzr_,
                StatusReason = ezzzzs_,
                Category = ezzzzt_,
                Code = ezzzzu_,
                Subject = ezzzzv_,
                Encounter = ezzzzw_,
                Performed = (DataType)ezzzzx_,
                Recorder = ezzzzy_,
                Asserter = ezzzzz_,
                Performer = new List<Procedure.PerformerComponent>((IEnumerable<Procedure.PerformerComponent>)fzzzza_),
                Location = fzzzzb_,
                ReasonCode = new List<CodeableConcept>((IEnumerable<CodeableConcept>)fzzzzc_),
                ReasonReference = new List<ResourceReference>((IEnumerable<ResourceReference>)fzzzzd_),
                BodySite = new List<CodeableConcept>((IEnumerable<CodeableConcept>)fzzzze_),
                Outcome = fzzzzf_,
                Report = new List<ResourceReference>((IEnumerable<ResourceReference>)fzzzzg_),
                Complication = new List<CodeableConcept>((IEnumerable<CodeableConcept>)fzzzzh_),
                ComplicationDetail = new List<ResourceReference>((IEnumerable<ResourceReference>)fzzzzi_),
                FollowUp = new List<CodeableConcept>((IEnumerable<CodeableConcept>)fzzzzj_),
                Note = new List<Annotation>((IEnumerable<Annotation>)fzzzzk_),
                FocalDevice = new List<Procedure.FocalDeviceComponent>((IEnumerable<Procedure.FocalDeviceComponent>)fzzzzl_),
                UsedReference = new List<ResourceReference>((IEnumerable<ResourceReference>)fzzzzm_),
                UsedCode = new List<CodeableConcept>((IEnumerable<CodeableConcept>)fzzzzn_),
            };

            return fzzzzo_;
        };
        IEnumerable<Procedure> ezzzzj_ = context.Operators.Select<Procedure, Procedure>((IEnumerable<Procedure>)ezzzzh_, ezzzzi_);
        IEnumerable<Procedure> ezzzzk_ = context.Operators.Distinct<Procedure>(ezzzzj_);
        Procedure ezzzzl_ = context.Operators.SingletonFrom<Procedure>(ezzzzk_);

        return ezzzzl_;
    }


    [CqlExpressionDefinition("ProvenanceResource")]
    public Provenance ProvenanceResource(CqlContext context, Provenance arg)
    {
        Provenance[] fzzzzp_ = [
            arg,
        ];
        Provenance fzzzzq_(Provenance a)
        {
            List<ResourceReference> fzzzzu_ = a?.Target;
            DataType fzzzzv_ = a?.Occurred;
            Instant fzzzzw_ = a?.RecordedElement;
            List<FhirUri> fzzzzx_ = a?.PolicyElement;
            ResourceReference fzzzzy_ = a?.Location;
            List<CodeableConcept> fzzzzz_ = a?.Reason;
            CodeableConcept gzzzza_ = a?.Activity;
            List<Provenance.AgentComponent> gzzzzb_ = a?.Agent;
            List<Provenance.EntityComponent> gzzzzc_ = a?.Entity;
            List<Signature> gzzzzd_ = a?.Signature;
            Provenance gzzzze_ = new Provenance
            {
                Target = new List<ResourceReference>((IEnumerable<ResourceReference>)fzzzzu_),
                Occurred = (DataType)fzzzzv_,
                RecordedElement = fzzzzw_,
                PolicyElement = new List<FhirUri>((IEnumerable<FhirUri>)fzzzzx_),
                Location = fzzzzy_,
                Reason = new List<CodeableConcept>((IEnumerable<CodeableConcept>)fzzzzz_),
                Activity = gzzzza_,
                Agent = new List<Provenance.AgentComponent>((IEnumerable<Provenance.AgentComponent>)gzzzzb_),
                Entity = new List<Provenance.EntityComponent>((IEnumerable<Provenance.EntityComponent>)gzzzzc_),
                Signature = new List<Signature>((IEnumerable<Signature>)gzzzzd_),
            };

            return gzzzze_;
        };
        IEnumerable<Provenance> fzzzzr_ = context.Operators.Select<Provenance, Provenance>((IEnumerable<Provenance>)fzzzzp_, fzzzzq_);
        IEnumerable<Provenance> fzzzzs_ = context.Operators.Distinct<Provenance>(fzzzzr_);
        Provenance fzzzzt_ = context.Operators.SingletonFrom<Provenance>(fzzzzs_);

        return fzzzzt_;
    }


    [CqlExpressionDefinition("QuestionnaireResponseResource")]
    public QuestionnaireResponse QuestionnaireResponseResource(CqlContext context, QuestionnaireResponse arg)
    {
        QuestionnaireResponse[] gzzzzf_ = [
            arg,
        ];
        QuestionnaireResponse gzzzzg_(QuestionnaireResponse a)
        {
            Identifier gzzzzk_ = a?.Identifier;
            List<ResourceReference> gzzzzl_ = a?.BasedOn;
            List<ResourceReference> gzzzzm_ = a?.PartOf;
            Canonical gzzzzn_ = a?.QuestionnaireElement;
            Code<QuestionnaireResponse.QuestionnaireResponseStatus> gzzzzo_ = a?.StatusElement;
            ResourceReference gzzzzp_ = a?.Subject;
            ResourceReference gzzzzq_ = a?.Encounter;
            FhirDateTime gzzzzr_ = a?.AuthoredElement;
            ResourceReference gzzzzs_ = a?.Author;
            ResourceReference gzzzzt_ = a?.Source;
            List<QuestionnaireResponse.ItemComponent> gzzzzu_ = a?.Item;
            QuestionnaireResponse gzzzzv_ = new QuestionnaireResponse
            {
                Identifier = gzzzzk_,
                BasedOn = new List<ResourceReference>((IEnumerable<ResourceReference>)gzzzzl_),
                PartOf = new List<ResourceReference>((IEnumerable<ResourceReference>)gzzzzm_),
                QuestionnaireElement = gzzzzn_,
                StatusElement = gzzzzo_,
                Subject = gzzzzp_,
                Encounter = gzzzzq_,
                AuthoredElement = gzzzzr_,
                Author = gzzzzs_,
                Source = gzzzzt_,
                Item = new List<QuestionnaireResponse.ItemComponent>((IEnumerable<QuestionnaireResponse.ItemComponent>)gzzzzu_),
            };

            return gzzzzv_;
        };
        IEnumerable<QuestionnaireResponse> gzzzzh_ = context.Operators.Select<QuestionnaireResponse, QuestionnaireResponse>((IEnumerable<QuestionnaireResponse>)gzzzzf_, gzzzzg_);
        IEnumerable<QuestionnaireResponse> gzzzzi_ = context.Operators.Distinct<QuestionnaireResponse>(gzzzzh_);
        QuestionnaireResponse gzzzzj_ = context.Operators.SingletonFrom<QuestionnaireResponse>(gzzzzi_);

        return gzzzzj_;
    }


    [CqlExpressionDefinition("RelatedPersonResource")]
    public RelatedPerson RelatedPersonResource(CqlContext context, RelatedPerson arg)
    {
        RelatedPerson[] gzzzzw_ = [
            arg,
        ];
        RelatedPerson gzzzzx_(RelatedPerson a)
        {
            List<Identifier> hzzzzb_ = a?.Identifier;
            FhirBoolean hzzzzc_ = a?.ActiveElement;
            ResourceReference hzzzzd_ = a?.Patient;
            List<CodeableConcept> hzzzze_ = a?.Relationship;
            List<HumanName> hzzzzf_ = a?.Name;
            List<ContactPoint> hzzzzg_ = a?.Telecom;
            Code<AdministrativeGender> hzzzzh_ = a?.GenderElement;
            Date hzzzzi_ = a?.BirthDateElement;
            List<Address> hzzzzj_ = a?.Address;
            List<Attachment> hzzzzk_ = a?.Photo;
            Period hzzzzl_ = a?.Period;
            List<RelatedPerson.CommunicationComponent> hzzzzm_ = a?.Communication;
            RelatedPerson hzzzzn_ = new RelatedPerson
            {
                Identifier = new List<Identifier>((IEnumerable<Identifier>)hzzzzb_),
                ActiveElement = hzzzzc_,
                Patient = hzzzzd_,
                Relationship = new List<CodeableConcept>((IEnumerable<CodeableConcept>)hzzzze_),
                Name = new List<HumanName>((IEnumerable<HumanName>)hzzzzf_),
                Telecom = new List<ContactPoint>((IEnumerable<ContactPoint>)hzzzzg_),
                GenderElement = hzzzzh_,
                BirthDateElement = hzzzzi_,
                Address = new List<Address>((IEnumerable<Address>)hzzzzj_),
                Photo = new List<Attachment>((IEnumerable<Attachment>)hzzzzk_),
                Period = hzzzzl_,
                Communication = new List<RelatedPerson.CommunicationComponent>((IEnumerable<RelatedPerson.CommunicationComponent>)hzzzzm_),
            };

            return hzzzzn_;
        };
        IEnumerable<RelatedPerson> gzzzzy_ = context.Operators.Select<RelatedPerson, RelatedPerson>((IEnumerable<RelatedPerson>)gzzzzw_, gzzzzx_);
        IEnumerable<RelatedPerson> gzzzzz_ = context.Operators.Distinct<RelatedPerson>(gzzzzy_);
        RelatedPerson hzzzza_ = context.Operators.SingletonFrom<RelatedPerson>(gzzzzz_);

        return hzzzza_;
    }


    [CqlExpressionDefinition("RequestGroupResource")]
    public RequestGroup RequestGroupResource(CqlContext context, RequestGroup arg)
    {
        RequestGroup[] hzzzzo_ = [
            arg,
        ];
        RequestGroup hzzzzp_(RequestGroup a)
        {
            List<Identifier> hzzzzt_ = a?.Identifier;
            List<Canonical> hzzzzu_ = a?.InstantiatesCanonicalElement;
            List<FhirUri> hzzzzv_ = a?.InstantiatesUriElement;
            List<ResourceReference> hzzzzw_ = a?.BasedOn;
            List<ResourceReference> hzzzzx_ = a?.Replaces;
            Identifier hzzzzy_ = a?.GroupIdentifier;
            Code<RequestStatus> hzzzzz_ = a?.StatusElement;
            Code<RequestIntent> izzzza_ = a?.IntentElement;
            Code<RequestPriority> izzzzb_ = a?.PriorityElement;
            CodeableConcept izzzzc_ = a?.Code;
            ResourceReference izzzzd_ = a?.Subject;
            ResourceReference izzzze_ = a?.Encounter;
            FhirDateTime izzzzf_ = a?.AuthoredOnElement;
            ResourceReference izzzzg_ = a?.Author;
            List<CodeableConcept> izzzzh_ = a?.ReasonCode;
            List<ResourceReference> izzzzi_ = a?.ReasonReference;
            List<Annotation> izzzzj_ = a?.Note;
            List<RequestGroup.ActionComponent> izzzzk_ = a?.Action;
            RequestGroup izzzzl_ = new RequestGroup
            {
                Identifier = new List<Identifier>((IEnumerable<Identifier>)hzzzzt_),
                InstantiatesCanonicalElement = new List<Canonical>((IEnumerable<Canonical>)hzzzzu_),
                InstantiatesUriElement = new List<FhirUri>((IEnumerable<FhirUri>)hzzzzv_),
                BasedOn = new List<ResourceReference>((IEnumerable<ResourceReference>)hzzzzw_),
                Replaces = new List<ResourceReference>((IEnumerable<ResourceReference>)hzzzzx_),
                GroupIdentifier = hzzzzy_,
                StatusElement = hzzzzz_,
                IntentElement = izzzza_,
                PriorityElement = izzzzb_,
                Code = izzzzc_,
                Subject = izzzzd_,
                Encounter = izzzze_,
                AuthoredOnElement = izzzzf_,
                Author = izzzzg_,
                ReasonCode = new List<CodeableConcept>((IEnumerable<CodeableConcept>)izzzzh_),
                ReasonReference = new List<ResourceReference>((IEnumerable<ResourceReference>)izzzzi_),
                Note = new List<Annotation>((IEnumerable<Annotation>)izzzzj_),
                Action = new List<RequestGroup.ActionComponent>((IEnumerable<RequestGroup.ActionComponent>)izzzzk_),
            };

            return izzzzl_;
        };
        IEnumerable<RequestGroup> hzzzzq_ = context.Operators.Select<RequestGroup, RequestGroup>((IEnumerable<RequestGroup>)hzzzzo_, hzzzzp_);
        IEnumerable<RequestGroup> hzzzzr_ = context.Operators.Distinct<RequestGroup>(hzzzzq_);
        RequestGroup hzzzzs_ = context.Operators.SingletonFrom<RequestGroup>(hzzzzr_);

        return hzzzzs_;
    }


    [CqlExpressionDefinition("ResearchDefinitionResource")]
    public ResearchDefinition ResearchDefinitionResource(CqlContext context, ResearchDefinition arg)
    {
        ResearchDefinition[] izzzzm_ = [
            arg,
        ];
        ResearchDefinition izzzzn_(ResearchDefinition a)
        {
            FhirUri izzzzr_ = a?.UrlElement;
            List<Identifier> izzzzs_ = a?.Identifier;
            FhirString izzzzt_ = a?.VersionElement;
            FhirString izzzzu_ = a?.NameElement;
            FhirString izzzzv_ = a?.TitleElement;
            FhirString izzzzw_ = a?.ShortTitleElement;
            FhirString izzzzx_ = a?.SubtitleElement;
            Code<PublicationStatus> izzzzy_ = a?.StatusElement;
            FhirBoolean izzzzz_ = a?.ExperimentalElement;
            DataType jzzzza_ = a?.Subject;
            FhirDateTime jzzzzb_ = a?.DateElement;
            FhirString jzzzzc_ = a?.PublisherElement;
            List<ContactDetail> jzzzzd_ = a?.Contact;
            Markdown jzzzze_ = a?.DescriptionElement;
            List<FhirString> jzzzzf_ = a?.CommentElement;
            List<UsageContext> jzzzzg_ = a?.UseContext;
            List<CodeableConcept> jzzzzh_ = a?.Jurisdiction;
            Markdown jzzzzi_ = a?.PurposeElement;
            FhirString jzzzzj_ = a?.UsageElement;
            Markdown jzzzzk_ = a?.CopyrightElement;
            Date jzzzzl_ = a?.ApprovalDateElement;
            Date jzzzzm_ = a?.LastReviewDateElement;
            Period jzzzzn_ = a?.EffectivePeriod;
            List<CodeableConcept> jzzzzo_ = a?.Topic;
            List<ContactDetail> jzzzzp_ = a?.Author;
            List<ContactDetail> jzzzzq_ = a?.Editor;
            List<ContactDetail> jzzzzr_ = a?.Reviewer;
            List<ContactDetail> jzzzzs_ = a?.Endorser;
            List<RelatedArtifact> jzzzzt_ = a?.RelatedArtifact;
            List<Canonical> jzzzzu_ = a?.LibraryElement;
            ResourceReference jzzzzv_ = a?.Population;
            ResourceReference jzzzzw_ = a?.Exposure;
            ResourceReference jzzzzx_ = a?.ExposureAlternative;
            ResourceReference jzzzzy_ = a?.Outcome;
            ResearchDefinition jzzzzz_ = new ResearchDefinition
            {
                UrlElement = izzzzr_,
                Identifier = new List<Identifier>((IEnumerable<Identifier>)izzzzs_),
                VersionElement = izzzzt_,
                NameElement = izzzzu_,
                TitleElement = izzzzv_,
                ShortTitleElement = izzzzw_,
                SubtitleElement = izzzzx_,
                StatusElement = izzzzy_,
                ExperimentalElement = izzzzz_,
                Subject = (DataType)jzzzza_,
                DateElement = jzzzzb_,
                PublisherElement = jzzzzc_,
                Contact = new List<ContactDetail>((IEnumerable<ContactDetail>)jzzzzd_),
                DescriptionElement = jzzzze_,
                CommentElement = new List<FhirString>((IEnumerable<FhirString>)jzzzzf_),
                UseContext = new List<UsageContext>((IEnumerable<UsageContext>)jzzzzg_),
                Jurisdiction = new List<CodeableConcept>((IEnumerable<CodeableConcept>)jzzzzh_),
                PurposeElement = jzzzzi_,
                UsageElement = jzzzzj_,
                CopyrightElement = jzzzzk_,
                ApprovalDateElement = jzzzzl_,
                LastReviewDateElement = jzzzzm_,
                EffectivePeriod = jzzzzn_,
                Topic = new List<CodeableConcept>((IEnumerable<CodeableConcept>)jzzzzo_),
                Author = new List<ContactDetail>((IEnumerable<ContactDetail>)jzzzzp_),
                Editor = new List<ContactDetail>((IEnumerable<ContactDetail>)jzzzzq_),
                Reviewer = new List<ContactDetail>((IEnumerable<ContactDetail>)jzzzzr_),
                Endorser = new List<ContactDetail>((IEnumerable<ContactDetail>)jzzzzs_),
                RelatedArtifact = new List<RelatedArtifact>((IEnumerable<RelatedArtifact>)jzzzzt_),
                LibraryElement = new List<Canonical>((IEnumerable<Canonical>)jzzzzu_),
                Population = jzzzzv_,
                Exposure = jzzzzw_,
                ExposureAlternative = jzzzzx_,
                Outcome = jzzzzy_,
            };

            return jzzzzz_;
        };
        IEnumerable<ResearchDefinition> izzzzo_ = context.Operators.Select<ResearchDefinition, ResearchDefinition>((IEnumerable<ResearchDefinition>)izzzzm_, izzzzn_);
        IEnumerable<ResearchDefinition> izzzzp_ = context.Operators.Distinct<ResearchDefinition>(izzzzo_);
        ResearchDefinition izzzzq_ = context.Operators.SingletonFrom<ResearchDefinition>(izzzzp_);

        return izzzzq_;
    }


    [CqlExpressionDefinition("ResearchElementDefinitionResource")]
    public ResearchElementDefinition ResearchElementDefinitionResource(CqlContext context, ResearchElementDefinition arg)
    {
        ResearchElementDefinition[] kzzzza_ = [
            arg,
        ];
        ResearchElementDefinition kzzzzb_(ResearchElementDefinition a)
        {
            FhirUri kzzzzf_ = a?.UrlElement;
            List<Identifier> kzzzzg_ = a?.Identifier;
            FhirString kzzzzh_ = a?.VersionElement;
            FhirString kzzzzi_ = a?.NameElement;
            FhirString kzzzzj_ = a?.TitleElement;
            FhirString kzzzzk_ = a?.ShortTitleElement;
            FhirString kzzzzl_ = a?.SubtitleElement;
            Code<PublicationStatus> kzzzzm_ = a?.StatusElement;
            FhirBoolean kzzzzn_ = a?.ExperimentalElement;
            DataType kzzzzo_ = a?.Subject;
            FhirDateTime kzzzzp_ = a?.DateElement;
            FhirString kzzzzq_ = a?.PublisherElement;
            List<ContactDetail> kzzzzr_ = a?.Contact;
            Markdown kzzzzs_ = a?.DescriptionElement;
            List<FhirString> kzzzzt_ = a?.CommentElement;
            List<UsageContext> kzzzzu_ = a?.UseContext;
            List<CodeableConcept> kzzzzv_ = a?.Jurisdiction;
            Markdown kzzzzw_ = a?.PurposeElement;
            FhirString kzzzzx_ = a?.UsageElement;
            Markdown kzzzzy_ = a?.CopyrightElement;
            Date kzzzzz_ = a?.ApprovalDateElement;
            Date lzzzza_ = a?.LastReviewDateElement;
            Period lzzzzb_ = a?.EffectivePeriod;
            List<CodeableConcept> lzzzzc_ = a?.Topic;
            List<ContactDetail> lzzzzd_ = a?.Author;
            List<ContactDetail> lzzzze_ = a?.Editor;
            List<ContactDetail> lzzzzf_ = a?.Reviewer;
            List<ContactDetail> lzzzzg_ = a?.Endorser;
            List<RelatedArtifact> lzzzzh_ = a?.RelatedArtifact;
            List<Canonical> lzzzzi_ = a?.LibraryElement;
            Code<ResearchElementDefinition.ResearchElementType> lzzzzj_ = a?.TypeElement;
            Code<VariableTypeCode> lzzzzk_ = a?.VariableTypeElement;
            List<ResearchElementDefinition.CharacteristicComponent> lzzzzl_ = a?.Characteristic;
            ResearchElementDefinition lzzzzm_ = new ResearchElementDefinition
            {
                UrlElement = kzzzzf_,
                Identifier = new List<Identifier>((IEnumerable<Identifier>)kzzzzg_),
                VersionElement = kzzzzh_,
                NameElement = kzzzzi_,
                TitleElement = kzzzzj_,
                ShortTitleElement = kzzzzk_,
                SubtitleElement = kzzzzl_,
                StatusElement = kzzzzm_,
                ExperimentalElement = kzzzzn_,
                Subject = (DataType)kzzzzo_,
                DateElement = kzzzzp_,
                PublisherElement = kzzzzq_,
                Contact = new List<ContactDetail>((IEnumerable<ContactDetail>)kzzzzr_),
                DescriptionElement = kzzzzs_,
                CommentElement = new List<FhirString>((IEnumerable<FhirString>)kzzzzt_),
                UseContext = new List<UsageContext>((IEnumerable<UsageContext>)kzzzzu_),
                Jurisdiction = new List<CodeableConcept>((IEnumerable<CodeableConcept>)kzzzzv_),
                PurposeElement = kzzzzw_,
                UsageElement = kzzzzx_,
                CopyrightElement = kzzzzy_,
                ApprovalDateElement = kzzzzz_,
                LastReviewDateElement = lzzzza_,
                EffectivePeriod = lzzzzb_,
                Topic = new List<CodeableConcept>((IEnumerable<CodeableConcept>)lzzzzc_),
                Author = new List<ContactDetail>((IEnumerable<ContactDetail>)lzzzzd_),
                Editor = new List<ContactDetail>((IEnumerable<ContactDetail>)lzzzze_),
                Reviewer = new List<ContactDetail>((IEnumerable<ContactDetail>)lzzzzf_),
                Endorser = new List<ContactDetail>((IEnumerable<ContactDetail>)lzzzzg_),
                RelatedArtifact = new List<RelatedArtifact>((IEnumerable<RelatedArtifact>)lzzzzh_),
                LibraryElement = new List<Canonical>((IEnumerable<Canonical>)lzzzzi_),
                TypeElement = lzzzzj_,
                VariableTypeElement = lzzzzk_,
                Characteristic = new List<ResearchElementDefinition.CharacteristicComponent>((IEnumerable<ResearchElementDefinition.CharacteristicComponent>)lzzzzl_),
            };

            return lzzzzm_;
        };
        IEnumerable<ResearchElementDefinition> kzzzzc_ = context.Operators.Select<ResearchElementDefinition, ResearchElementDefinition>((IEnumerable<ResearchElementDefinition>)kzzzza_, kzzzzb_);
        IEnumerable<ResearchElementDefinition> kzzzzd_ = context.Operators.Distinct<ResearchElementDefinition>(kzzzzc_);
        ResearchElementDefinition kzzzze_ = context.Operators.SingletonFrom<ResearchElementDefinition>(kzzzzd_);

        return kzzzze_;
    }


    [CqlExpressionDefinition("ResearchStudyResource")]
    public ResearchStudy ResearchStudyResource(CqlContext context, ResearchStudy arg)
    {
        ResearchStudy[] lzzzzn_ = [
            arg,
        ];
        ResearchStudy lzzzzo_(ResearchStudy a)
        {
            List<Identifier> lzzzzs_ = a?.Identifier;
            FhirString lzzzzt_ = a?.TitleElement;
            List<ResourceReference> lzzzzu_ = a?.Protocol;
            List<ResourceReference> lzzzzv_ = a?.PartOf;
            Code<ResearchStudy.ResearchStudyStatus> lzzzzw_ = a?.StatusElement;
            CodeableConcept lzzzzx_ = a?.PrimaryPurposeType;
            CodeableConcept lzzzzy_ = a?.Phase;
            List<CodeableConcept> lzzzzz_ = a?.Category;
            List<CodeableConcept> mzzzza_ = a?.Focus;
            List<CodeableConcept> mzzzzb_ = a?.Condition;
            List<ContactDetail> mzzzzc_ = a?.Contact;
            List<RelatedArtifact> mzzzzd_ = a?.RelatedArtifact;
            List<CodeableConcept> mzzzze_ = a?.Keyword;
            List<CodeableConcept> mzzzzf_ = a?.Location;
            Markdown mzzzzg_ = a?.DescriptionElement;
            List<ResourceReference> mzzzzh_ = a?.Enrollment;
            Period mzzzzi_ = a?.Period;
            ResourceReference mzzzzj_ = a?.Sponsor;
            ResourceReference mzzzzk_ = a?.PrincipalInvestigator;
            List<ResourceReference> mzzzzl_ = a?.Site;
            CodeableConcept mzzzzm_ = a?.ReasonStopped;
            List<Annotation> mzzzzn_ = a?.Note;
            List<ResearchStudy.ArmComponent> mzzzzo_ = a?.Arm;
            List<ResearchStudy.ObjectiveComponent> mzzzzp_ = a?.Objective;
            ResearchStudy mzzzzq_ = new ResearchStudy
            {
                Identifier = new List<Identifier>((IEnumerable<Identifier>)lzzzzs_),
                TitleElement = lzzzzt_,
                Protocol = new List<ResourceReference>((IEnumerable<ResourceReference>)lzzzzu_),
                PartOf = new List<ResourceReference>((IEnumerable<ResourceReference>)lzzzzv_),
                StatusElement = lzzzzw_,
                PrimaryPurposeType = lzzzzx_,
                Phase = lzzzzy_,
                Category = new List<CodeableConcept>((IEnumerable<CodeableConcept>)lzzzzz_),
                Focus = new List<CodeableConcept>((IEnumerable<CodeableConcept>)mzzzza_),
                Condition = new List<CodeableConcept>((IEnumerable<CodeableConcept>)mzzzzb_),
                Contact = new List<ContactDetail>((IEnumerable<ContactDetail>)mzzzzc_),
                RelatedArtifact = new List<RelatedArtifact>((IEnumerable<RelatedArtifact>)mzzzzd_),
                Keyword = new List<CodeableConcept>((IEnumerable<CodeableConcept>)mzzzze_),
                Location = new List<CodeableConcept>((IEnumerable<CodeableConcept>)mzzzzf_),
                DescriptionElement = mzzzzg_,
                Enrollment = new List<ResourceReference>((IEnumerable<ResourceReference>)mzzzzh_),
                Period = mzzzzi_,
                Sponsor = mzzzzj_,
                PrincipalInvestigator = mzzzzk_,
                Site = new List<ResourceReference>((IEnumerable<ResourceReference>)mzzzzl_),
                ReasonStopped = mzzzzm_,
                Note = new List<Annotation>((IEnumerable<Annotation>)mzzzzn_),
                Arm = new List<ResearchStudy.ArmComponent>((IEnumerable<ResearchStudy.ArmComponent>)mzzzzo_),
                Objective = new List<ResearchStudy.ObjectiveComponent>((IEnumerable<ResearchStudy.ObjectiveComponent>)mzzzzp_),
            };

            return mzzzzq_;
        };
        IEnumerable<ResearchStudy> lzzzzp_ = context.Operators.Select<ResearchStudy, ResearchStudy>((IEnumerable<ResearchStudy>)lzzzzn_, lzzzzo_);
        IEnumerable<ResearchStudy> lzzzzq_ = context.Operators.Distinct<ResearchStudy>(lzzzzp_);
        ResearchStudy lzzzzr_ = context.Operators.SingletonFrom<ResearchStudy>(lzzzzq_);

        return lzzzzr_;
    }


    [CqlExpressionDefinition("ResearchSubjectResource")]
    public ResearchSubject ResearchSubjectResource(CqlContext context, ResearchSubject arg)
    {
        ResearchSubject[] mzzzzr_ = [
            arg,
        ];
        ResearchSubject mzzzzs_(ResearchSubject a)
        {
            List<Identifier> mzzzzw_ = a?.Identifier;
            Code<ResearchSubject.ResearchSubjectStatus> mzzzzx_ = a?.StatusElement;
            Period mzzzzy_ = a?.Period;
            ResourceReference mzzzzz_ = a?.Study;
            ResourceReference nzzzza_ = a?.Individual;
            FhirString nzzzzb_ = a?.AssignedArmElement;
            FhirString nzzzzc_ = a?.ActualArmElement;
            ResourceReference nzzzzd_ = a?.Consent;
            ResearchSubject nzzzze_ = new ResearchSubject
            {
                Identifier = new List<Identifier>((IEnumerable<Identifier>)mzzzzw_),
                StatusElement = mzzzzx_,
                Period = mzzzzy_,
                Study = mzzzzz_,
                Individual = nzzzza_,
                AssignedArmElement = nzzzzb_,
                ActualArmElement = nzzzzc_,
                Consent = nzzzzd_,
            };

            return nzzzze_;
        };
        IEnumerable<ResearchSubject> mzzzzt_ = context.Operators.Select<ResearchSubject, ResearchSubject>((IEnumerable<ResearchSubject>)mzzzzr_, mzzzzs_);
        IEnumerable<ResearchSubject> mzzzzu_ = context.Operators.Distinct<ResearchSubject>(mzzzzt_);
        ResearchSubject mzzzzv_ = context.Operators.SingletonFrom<ResearchSubject>(mzzzzu_);

        return mzzzzv_;
    }


    [CqlExpressionDefinition("RiskAssessmentResource")]
    public RiskAssessment RiskAssessmentResource(CqlContext context, RiskAssessment arg)
    {
        RiskAssessment[] nzzzzf_ = [
            arg,
        ];
        RiskAssessment nzzzzg_(RiskAssessment a)
        {
            List<Identifier> nzzzzk_ = a?.Identifier;
            ResourceReference nzzzzl_ = a?.BasedOn;
            ResourceReference nzzzzm_ = a?.Parent;
            Code<ObservationStatus> nzzzzn_ = a?.StatusElement;
            CodeableConcept nzzzzo_ = a?.Method;
            CodeableConcept nzzzzp_ = a?.Code;
            ResourceReference nzzzzq_ = a?.Subject;
            ResourceReference nzzzzr_ = a?.Encounter;
            DataType nzzzzs_ = a?.Occurrence;
            ResourceReference nzzzzt_ = a?.Condition;
            ResourceReference nzzzzu_ = a?.Performer;
            List<CodeableConcept> nzzzzv_ = a?.ReasonCode;
            List<ResourceReference> nzzzzw_ = a?.ReasonReference;
            List<ResourceReference> nzzzzx_ = a?.Basis;
            List<RiskAssessment.PredictionComponent> nzzzzy_ = a?.Prediction;
            FhirString nzzzzz_ = a?.MitigationElement;
            List<Annotation> ozzzza_ = a?.Note;
            RiskAssessment ozzzzb_ = new RiskAssessment
            {
                Identifier = new List<Identifier>((IEnumerable<Identifier>)nzzzzk_),
                BasedOn = nzzzzl_,
                Parent = nzzzzm_,
                StatusElement = nzzzzn_,
                Method = nzzzzo_,
                Code = nzzzzp_,
                Subject = nzzzzq_,
                Encounter = nzzzzr_,
                Occurrence = (DataType)nzzzzs_,
                Condition = nzzzzt_,
                Performer = nzzzzu_,
                ReasonCode = new List<CodeableConcept>((IEnumerable<CodeableConcept>)nzzzzv_),
                ReasonReference = new List<ResourceReference>((IEnumerable<ResourceReference>)nzzzzw_),
                Basis = new List<ResourceReference>((IEnumerable<ResourceReference>)nzzzzx_),
                Prediction = new List<RiskAssessment.PredictionComponent>((IEnumerable<RiskAssessment.PredictionComponent>)nzzzzy_),
                MitigationElement = nzzzzz_,
                Note = new List<Annotation>((IEnumerable<Annotation>)ozzzza_),
            };

            return ozzzzb_;
        };
        IEnumerable<RiskAssessment> nzzzzh_ = context.Operators.Select<RiskAssessment, RiskAssessment>((IEnumerable<RiskAssessment>)nzzzzf_, nzzzzg_);
        IEnumerable<RiskAssessment> nzzzzi_ = context.Operators.Distinct<RiskAssessment>(nzzzzh_);
        RiskAssessment nzzzzj_ = context.Operators.SingletonFrom<RiskAssessment>(nzzzzi_);

        return nzzzzj_;
    }


    [CqlExpressionDefinition("RiskEvidenceSynthesisResource")]
    public RiskEvidenceSynthesis RiskEvidenceSynthesisResource(CqlContext context, RiskEvidenceSynthesis arg)
    {
        RiskEvidenceSynthesis[] ozzzzc_ = [
            arg,
        ];
        RiskEvidenceSynthesis ozzzzd_(RiskEvidenceSynthesis a)
        {
            FhirUri ozzzzh_ = a?.UrlElement;
            List<Identifier> ozzzzi_ = a?.Identifier;
            FhirString ozzzzj_ = a?.VersionElement;
            FhirString ozzzzk_ = a?.NameElement;
            FhirString ozzzzl_ = a?.TitleElement;
            Code<PublicationStatus> ozzzzm_ = a?.StatusElement;
            FhirDateTime ozzzzn_ = a?.DateElement;
            FhirString ozzzzo_ = a?.PublisherElement;
            List<ContactDetail> ozzzzp_ = a?.Contact;
            Markdown ozzzzq_ = a?.DescriptionElement;
            List<Annotation> ozzzzr_ = a?.Note;
            List<UsageContext> ozzzzs_ = a?.UseContext;
            List<CodeableConcept> ozzzzt_ = a?.Jurisdiction;
            Markdown ozzzzu_ = a?.CopyrightElement;
            Date ozzzzv_ = a?.ApprovalDateElement;
            Date ozzzzw_ = a?.LastReviewDateElement;
            Period ozzzzx_ = a?.EffectivePeriod;
            List<CodeableConcept> ozzzzy_ = a?.Topic;
            List<ContactDetail> ozzzzz_ = a?.Author;
            List<ContactDetail> pzzzza_ = a?.Editor;
            List<ContactDetail> pzzzzb_ = a?.Reviewer;
            List<ContactDetail> pzzzzc_ = a?.Endorser;
            List<RelatedArtifact> pzzzzd_ = a?.RelatedArtifact;
            CodeableConcept pzzzze_ = a?.SynthesisType;
            CodeableConcept pzzzzf_ = a?.StudyType;
            ResourceReference pzzzzg_ = a?.Population;
            ResourceReference pzzzzh_ = a?.Exposure;
            ResourceReference pzzzzi_ = a?.Outcome;
            RiskEvidenceSynthesis.SampleSizeComponent pzzzzj_ = a?.SampleSize;
            RiskEvidenceSynthesis.RiskEstimateComponent pzzzzk_ = a?.RiskEstimate;
            List<RiskEvidenceSynthesis.CertaintyComponent> pzzzzl_ = a?.Certainty;
            RiskEvidenceSynthesis pzzzzm_ = new RiskEvidenceSynthesis
            {
                UrlElement = ozzzzh_,
                Identifier = new List<Identifier>((IEnumerable<Identifier>)ozzzzi_),
                VersionElement = ozzzzj_,
                NameElement = ozzzzk_,
                TitleElement = ozzzzl_,
                StatusElement = ozzzzm_,
                DateElement = ozzzzn_,
                PublisherElement = ozzzzo_,
                Contact = new List<ContactDetail>((IEnumerable<ContactDetail>)ozzzzp_),
                DescriptionElement = ozzzzq_,
                Note = new List<Annotation>((IEnumerable<Annotation>)ozzzzr_),
                UseContext = new List<UsageContext>((IEnumerable<UsageContext>)ozzzzs_),
                Jurisdiction = new List<CodeableConcept>((IEnumerable<CodeableConcept>)ozzzzt_),
                CopyrightElement = ozzzzu_,
                ApprovalDateElement = ozzzzv_,
                LastReviewDateElement = ozzzzw_,
                EffectivePeriod = ozzzzx_,
                Topic = new List<CodeableConcept>((IEnumerable<CodeableConcept>)ozzzzy_),
                Author = new List<ContactDetail>((IEnumerable<ContactDetail>)ozzzzz_),
                Editor = new List<ContactDetail>((IEnumerable<ContactDetail>)pzzzza_),
                Reviewer = new List<ContactDetail>((IEnumerable<ContactDetail>)pzzzzb_),
                Endorser = new List<ContactDetail>((IEnumerable<ContactDetail>)pzzzzc_),
                RelatedArtifact = new List<RelatedArtifact>((IEnumerable<RelatedArtifact>)pzzzzd_),
                SynthesisType = pzzzze_,
                StudyType = pzzzzf_,
                Population = pzzzzg_,
                Exposure = pzzzzh_,
                Outcome = pzzzzi_,
                SampleSize = pzzzzj_,
                RiskEstimate = pzzzzk_,
                Certainty = new List<RiskEvidenceSynthesis.CertaintyComponent>((IEnumerable<RiskEvidenceSynthesis.CertaintyComponent>)pzzzzl_),
            };

            return pzzzzm_;
        };
        IEnumerable<RiskEvidenceSynthesis> ozzzze_ = context.Operators.Select<RiskEvidenceSynthesis, RiskEvidenceSynthesis>((IEnumerable<RiskEvidenceSynthesis>)ozzzzc_, ozzzzd_);
        IEnumerable<RiskEvidenceSynthesis> ozzzzf_ = context.Operators.Distinct<RiskEvidenceSynthesis>(ozzzze_);
        RiskEvidenceSynthesis ozzzzg_ = context.Operators.SingletonFrom<RiskEvidenceSynthesis>(ozzzzf_);

        return ozzzzg_;
    }


    [CqlExpressionDefinition("ScheduleResource")]
    public Schedule ScheduleResource(CqlContext context, Schedule arg)
    {
        Schedule[] pzzzzn_ = [
            arg,
        ];
        Schedule pzzzzo_(Schedule a)
        {
            List<Identifier> pzzzzs_ = a?.Identifier;
            FhirBoolean pzzzzt_ = a?.ActiveElement;
            List<CodeableConcept> pzzzzu_ = a?.ServiceCategory;
            List<CodeableConcept> pzzzzv_ = a?.ServiceType;
            List<CodeableConcept> pzzzzw_ = a?.Specialty;
            List<ResourceReference> pzzzzx_ = a?.Actor;
            Period pzzzzy_ = a?.PlanningHorizon;
            FhirString pzzzzz_ = a?.CommentElement;
            Schedule qzzzza_ = new Schedule
            {
                Identifier = new List<Identifier>((IEnumerable<Identifier>)pzzzzs_),
                ActiveElement = pzzzzt_,
                ServiceCategory = new List<CodeableConcept>((IEnumerable<CodeableConcept>)pzzzzu_),
                ServiceType = new List<CodeableConcept>((IEnumerable<CodeableConcept>)pzzzzv_),
                Specialty = new List<CodeableConcept>((IEnumerable<CodeableConcept>)pzzzzw_),
                Actor = new List<ResourceReference>((IEnumerable<ResourceReference>)pzzzzx_),
                PlanningHorizon = pzzzzy_,
                CommentElement = pzzzzz_,
            };

            return qzzzza_;
        };
        IEnumerable<Schedule> pzzzzp_ = context.Operators.Select<Schedule, Schedule>((IEnumerable<Schedule>)pzzzzn_, pzzzzo_);
        IEnumerable<Schedule> pzzzzq_ = context.Operators.Distinct<Schedule>(pzzzzp_);
        Schedule pzzzzr_ = context.Operators.SingletonFrom<Schedule>(pzzzzq_);

        return pzzzzr_;
    }


    [CqlExpressionDefinition("ServiceRequestResource")]
    public ServiceRequest ServiceRequestResource(CqlContext context, ServiceRequest arg)
    {
        ServiceRequest[] qzzzzb_ = [
            arg,
        ];
        ServiceRequest qzzzzc_(ServiceRequest a)
        {
            List<Identifier> qzzzzg_ = a?.Identifier;
            List<Canonical> qzzzzh_ = a?.InstantiatesCanonicalElement;
            List<FhirUri> qzzzzi_ = a?.InstantiatesUriElement;
            List<ResourceReference> qzzzzj_ = a?.BasedOn;
            List<ResourceReference> qzzzzk_ = a?.Replaces;
            Identifier qzzzzl_ = a?.Requisition;
            Code<RequestStatus> qzzzzm_ = a?.StatusElement;
            Code<RequestIntent> qzzzzn_ = a?.IntentElement;
            List<CodeableConcept> qzzzzo_ = a?.Category;
            Code<RequestPriority> qzzzzp_ = a?.PriorityElement;
            FhirBoolean qzzzzq_ = a?.DoNotPerformElement;
            CodeableConcept qzzzzr_ = a?.Code;
            List<CodeableConcept> qzzzzs_ = a?.OrderDetail;
            DataType qzzzzt_ = a?.Quantity;
            ResourceReference qzzzzu_ = a?.Subject;
            ResourceReference qzzzzv_ = a?.Encounter;
            DataType qzzzzw_ = a?.Occurrence;
            DataType qzzzzx_ = a?.AsNeeded;
            FhirDateTime qzzzzy_ = a?.AuthoredOnElement;
            ResourceReference qzzzzz_ = a?.Requester;
            CodeableConcept rzzzza_ = a?.PerformerType;
            List<ResourceReference> rzzzzb_ = a?.Performer;
            List<CodeableConcept> rzzzzc_ = a?.LocationCode;
            List<ResourceReference> rzzzzd_ = a?.LocationReference;
            List<CodeableConcept> rzzzze_ = a?.ReasonCode;
            List<ResourceReference> rzzzzf_ = a?.ReasonReference;
            List<ResourceReference> rzzzzg_ = a?.Insurance;
            List<ResourceReference> rzzzzh_ = a?.SupportingInfo;
            List<ResourceReference> rzzzzi_ = a?.Specimen;
            List<CodeableConcept> rzzzzj_ = a?.BodySite;
            List<Annotation> rzzzzk_ = a?.Note;
            FhirString rzzzzl_ = a?.PatientInstructionElement;
            List<ResourceReference> rzzzzm_ = a?.RelevantHistory;
            ServiceRequest rzzzzn_ = new ServiceRequest
            {
                Identifier = new List<Identifier>((IEnumerable<Identifier>)qzzzzg_),
                InstantiatesCanonicalElement = new List<Canonical>((IEnumerable<Canonical>)qzzzzh_),
                InstantiatesUriElement = new List<FhirUri>((IEnumerable<FhirUri>)qzzzzi_),
                BasedOn = new List<ResourceReference>((IEnumerable<ResourceReference>)qzzzzj_),
                Replaces = new List<ResourceReference>((IEnumerable<ResourceReference>)qzzzzk_),
                Requisition = qzzzzl_,
                StatusElement = qzzzzm_,
                IntentElement = qzzzzn_,
                Category = new List<CodeableConcept>((IEnumerable<CodeableConcept>)qzzzzo_),
                PriorityElement = qzzzzp_,
                DoNotPerformElement = qzzzzq_,
                Code = qzzzzr_,
                OrderDetail = new List<CodeableConcept>((IEnumerable<CodeableConcept>)qzzzzs_),
                Quantity = (DataType)qzzzzt_,
                Subject = qzzzzu_,
                Encounter = qzzzzv_,
                Occurrence = (DataType)qzzzzw_,
                AsNeeded = (DataType)qzzzzx_,
                AuthoredOnElement = qzzzzy_,
                Requester = qzzzzz_,
                PerformerType = rzzzza_,
                Performer = new List<ResourceReference>((IEnumerable<ResourceReference>)rzzzzb_),
                LocationCode = new List<CodeableConcept>((IEnumerable<CodeableConcept>)rzzzzc_),
                LocationReference = new List<ResourceReference>((IEnumerable<ResourceReference>)rzzzzd_),
                ReasonCode = new List<CodeableConcept>((IEnumerable<CodeableConcept>)rzzzze_),
                ReasonReference = new List<ResourceReference>((IEnumerable<ResourceReference>)rzzzzf_),
                Insurance = new List<ResourceReference>((IEnumerable<ResourceReference>)rzzzzg_),
                SupportingInfo = new List<ResourceReference>((IEnumerable<ResourceReference>)rzzzzh_),
                Specimen = new List<ResourceReference>((IEnumerable<ResourceReference>)rzzzzi_),
                BodySite = new List<CodeableConcept>((IEnumerable<CodeableConcept>)rzzzzj_),
                Note = new List<Annotation>((IEnumerable<Annotation>)rzzzzk_),
                PatientInstructionElement = rzzzzl_,
                RelevantHistory = new List<ResourceReference>((IEnumerable<ResourceReference>)rzzzzm_),
            };

            return rzzzzn_;
        };
        IEnumerable<ServiceRequest> qzzzzd_ = context.Operators.Select<ServiceRequest, ServiceRequest>((IEnumerable<ServiceRequest>)qzzzzb_, qzzzzc_);
        IEnumerable<ServiceRequest> qzzzze_ = context.Operators.Distinct<ServiceRequest>(qzzzzd_);
        ServiceRequest qzzzzf_ = context.Operators.SingletonFrom<ServiceRequest>(qzzzze_);

        return qzzzzf_;
    }


    [CqlExpressionDefinition("SlotResource")]
    public Slot SlotResource(CqlContext context, Slot arg)
    {
        Slot[] rzzzzo_ = [
            arg,
        ];
        Slot rzzzzp_(Slot a)
        {
            List<Identifier> rzzzzt_ = a?.Identifier;
            List<CodeableConcept> rzzzzu_ = a?.ServiceCategory;
            List<CodeableConcept> rzzzzv_ = a?.ServiceType;
            List<CodeableConcept> rzzzzw_ = a?.Specialty;
            CodeableConcept rzzzzx_ = a?.AppointmentType;
            ResourceReference rzzzzy_ = a?.Schedule;
            Code<Slot.SlotStatus> rzzzzz_ = a?.StatusElement;
            Instant szzzza_ = a?.StartElement;
            Instant szzzzb_ = a?.EndElement;
            FhirBoolean szzzzc_ = a?.OverbookedElement;
            FhirString szzzzd_ = a?.CommentElement;
            Slot szzzze_ = new Slot
            {
                Identifier = new List<Identifier>((IEnumerable<Identifier>)rzzzzt_),
                ServiceCategory = new List<CodeableConcept>((IEnumerable<CodeableConcept>)rzzzzu_),
                ServiceType = new List<CodeableConcept>((IEnumerable<CodeableConcept>)rzzzzv_),
                Specialty = new List<CodeableConcept>((IEnumerable<CodeableConcept>)rzzzzw_),
                AppointmentType = rzzzzx_,
                Schedule = rzzzzy_,
                StatusElement = rzzzzz_,
                StartElement = szzzza_,
                EndElement = szzzzb_,
                OverbookedElement = szzzzc_,
                CommentElement = szzzzd_,
            };

            return szzzze_;
        };
        IEnumerable<Slot> rzzzzq_ = context.Operators.Select<Slot, Slot>((IEnumerable<Slot>)rzzzzo_, rzzzzp_);
        IEnumerable<Slot> rzzzzr_ = context.Operators.Distinct<Slot>(rzzzzq_);
        Slot rzzzzs_ = context.Operators.SingletonFrom<Slot>(rzzzzr_);

        return rzzzzs_;
    }


    [CqlExpressionDefinition("SpecimenResource")]
    public Specimen SpecimenResource(CqlContext context, Specimen arg)
    {
        Specimen[] szzzzf_ = [
            arg,
        ];
        Specimen szzzzg_(Specimen a)
        {
            List<Identifier> szzzzk_ = a?.Identifier;
            Identifier szzzzl_ = a?.AccessionIdentifier;
            Code<Specimen.SpecimenStatus> szzzzm_ = a?.StatusElement;
            CodeableConcept szzzzn_ = a?.Type;
            ResourceReference szzzzo_ = a?.Subject;
            FhirDateTime szzzzp_ = a?.ReceivedTimeElement;
            List<ResourceReference> szzzzq_ = a?.Parent;
            List<ResourceReference> szzzzr_ = a?.Request;
            Specimen.CollectionComponent szzzzs_ = a?.Collection;
            List<Specimen.ProcessingComponent> szzzzt_ = a?.Processing;
            List<Specimen.ContainerComponent> szzzzu_ = a?.Container;
            List<CodeableConcept> szzzzv_ = a?.Condition;
            List<Annotation> szzzzw_ = a?.Note;
            Specimen szzzzx_ = new Specimen
            {
                Identifier = new List<Identifier>((IEnumerable<Identifier>)szzzzk_),
                AccessionIdentifier = szzzzl_,
                StatusElement = szzzzm_,
                Type = szzzzn_,
                Subject = szzzzo_,
                ReceivedTimeElement = szzzzp_,
                Parent = new List<ResourceReference>((IEnumerable<ResourceReference>)szzzzq_),
                Request = new List<ResourceReference>((IEnumerable<ResourceReference>)szzzzr_),
                Collection = szzzzs_,
                Processing = new List<Specimen.ProcessingComponent>((IEnumerable<Specimen.ProcessingComponent>)szzzzt_),
                Container = new List<Specimen.ContainerComponent>((IEnumerable<Specimen.ContainerComponent>)szzzzu_),
                Condition = new List<CodeableConcept>((IEnumerable<CodeableConcept>)szzzzv_),
                Note = new List<Annotation>((IEnumerable<Annotation>)szzzzw_),
            };

            return szzzzx_;
        };
        IEnumerable<Specimen> szzzzh_ = context.Operators.Select<Specimen, Specimen>((IEnumerable<Specimen>)szzzzf_, szzzzg_);
        IEnumerable<Specimen> szzzzi_ = context.Operators.Distinct<Specimen>(szzzzh_);
        Specimen szzzzj_ = context.Operators.SingletonFrom<Specimen>(szzzzi_);

        return szzzzj_;
    }


    [CqlExpressionDefinition("SpecimenDefinitionResource")]
    public SpecimenDefinition SpecimenDefinitionResource(CqlContext context, SpecimenDefinition arg)
    {
        SpecimenDefinition[] szzzzy_ = [
            arg,
        ];
        SpecimenDefinition szzzzz_(SpecimenDefinition a)
        {
            Identifier tzzzzd_ = a?.Identifier;
            CodeableConcept tzzzze_ = a?.TypeCollected;
            List<CodeableConcept> tzzzzf_ = a?.PatientPreparation;
            FhirString tzzzzg_ = a?.TimeAspectElement;
            List<CodeableConcept> tzzzzh_ = a?.Collection;
            List<SpecimenDefinition.TypeTestedComponent> tzzzzi_ = a?.TypeTested;
            SpecimenDefinition tzzzzj_ = new SpecimenDefinition
            {
                Identifier = tzzzzd_,
                TypeCollected = tzzzze_,
                PatientPreparation = new List<CodeableConcept>((IEnumerable<CodeableConcept>)tzzzzf_),
                TimeAspectElement = tzzzzg_,
                Collection = new List<CodeableConcept>((IEnumerable<CodeableConcept>)tzzzzh_),
                TypeTested = new List<SpecimenDefinition.TypeTestedComponent>((IEnumerable<SpecimenDefinition.TypeTestedComponent>)tzzzzi_),
            };

            return tzzzzj_;
        };
        IEnumerable<SpecimenDefinition> tzzzza_ = context.Operators.Select<SpecimenDefinition, SpecimenDefinition>((IEnumerable<SpecimenDefinition>)szzzzy_, szzzzz_);
        IEnumerable<SpecimenDefinition> tzzzzb_ = context.Operators.Distinct<SpecimenDefinition>(tzzzza_);
        SpecimenDefinition tzzzzc_ = context.Operators.SingletonFrom<SpecimenDefinition>(tzzzzb_);

        return tzzzzc_;
    }


    [CqlExpressionDefinition("StructureDefinitionResource")]
    public StructureDefinition StructureDefinitionResource(CqlContext context, StructureDefinition arg)
    {
        StructureDefinition[] tzzzzk_ = [
            arg,
        ];
        StructureDefinition tzzzzl_(StructureDefinition a)
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
            List<Coding> uzzzze_ = a?.Keyword;
            Code<FHIRVersion> uzzzzf_ = a?.FhirVersionElement;
            List<StructureDefinition.MappingComponent> uzzzzg_ = a?.Mapping;
            Code<StructureDefinition.StructureDefinitionKind> uzzzzh_ = a?.KindElement;
            FhirBoolean uzzzzi_ = a?.AbstractElement;
            List<StructureDefinition.ContextComponent> uzzzzj_ = a?.Context;
            List<FhirString> uzzzzk_ = a?.ContextInvariantElement;
            FhirUri uzzzzl_ = a?.TypeElement;
            Canonical uzzzzm_ = a?.BaseDefinitionElement;
            Code<StructureDefinition.TypeDerivationRule> uzzzzn_ = a?.DerivationElement;
            StructureDefinition.SnapshotComponent uzzzzo_ = a?.Snapshot;
            StructureDefinition.DifferentialComponent uzzzzp_ = a?.Differential;
            StructureDefinition uzzzzq_ = new StructureDefinition
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
                Keyword = new List<Coding>((IEnumerable<Coding>)uzzzze_),
                FhirVersionElement = uzzzzf_,
                Mapping = new List<StructureDefinition.MappingComponent>((IEnumerable<StructureDefinition.MappingComponent>)uzzzzg_),
                KindElement = uzzzzh_,
                AbstractElement = uzzzzi_,
                Context = new List<StructureDefinition.ContextComponent>((IEnumerable<StructureDefinition.ContextComponent>)uzzzzj_),
                ContextInvariantElement = new List<FhirString>((IEnumerable<FhirString>)uzzzzk_),
                TypeElement = uzzzzl_,
                BaseDefinitionElement = uzzzzm_,
                DerivationElement = uzzzzn_,
                Snapshot = uzzzzo_,
                Differential = uzzzzp_,
            };

            return uzzzzq_;
        };
        IEnumerable<StructureDefinition> tzzzzm_ = context.Operators.Select<StructureDefinition, StructureDefinition>((IEnumerable<StructureDefinition>)tzzzzk_, tzzzzl_);
        IEnumerable<StructureDefinition> tzzzzn_ = context.Operators.Distinct<StructureDefinition>(tzzzzm_);
        StructureDefinition tzzzzo_ = context.Operators.SingletonFrom<StructureDefinition>(tzzzzn_);

        return tzzzzo_;
    }


    [CqlExpressionDefinition("StructureMapResource")]
    public StructureMap StructureMapResource(CqlContext context, StructureMap arg)
    {
        StructureMap[] uzzzzr_ = [
            arg,
        ];
        StructureMap uzzzzs_(StructureMap a)
        {
            FhirUri uzzzzw_ = a?.UrlElement;
            List<Identifier> uzzzzx_ = a?.Identifier;
            FhirString uzzzzy_ = a?.VersionElement;
            FhirString uzzzzz_ = a?.NameElement;
            FhirString vzzzza_ = a?.TitleElement;
            Code<PublicationStatus> vzzzzb_ = a?.StatusElement;
            FhirBoolean vzzzzc_ = a?.ExperimentalElement;
            FhirDateTime vzzzzd_ = a?.DateElement;
            FhirString vzzzze_ = a?.PublisherElement;
            List<ContactDetail> vzzzzf_ = a?.Contact;
            Markdown vzzzzg_ = a?.DescriptionElement;
            List<UsageContext> vzzzzh_ = a?.UseContext;
            List<CodeableConcept> vzzzzi_ = a?.Jurisdiction;
            Markdown vzzzzj_ = a?.PurposeElement;
            Markdown vzzzzk_ = a?.CopyrightElement;
            List<StructureMap.StructureComponent> vzzzzl_ = a?.Structure;
            List<Canonical> vzzzzm_ = a?.ImportElement;
            List<StructureMap.GroupComponent> vzzzzn_ = a?.Group;
            StructureMap vzzzzo_ = new StructureMap
            {
                UrlElement = uzzzzw_,
                Identifier = new List<Identifier>((IEnumerable<Identifier>)uzzzzx_),
                VersionElement = uzzzzy_,
                NameElement = uzzzzz_,
                TitleElement = vzzzza_,
                StatusElement = vzzzzb_,
                ExperimentalElement = vzzzzc_,
                DateElement = vzzzzd_,
                PublisherElement = vzzzze_,
                Contact = new List<ContactDetail>((IEnumerable<ContactDetail>)vzzzzf_),
                DescriptionElement = vzzzzg_,
                UseContext = new List<UsageContext>((IEnumerable<UsageContext>)vzzzzh_),
                Jurisdiction = new List<CodeableConcept>((IEnumerable<CodeableConcept>)vzzzzi_),
                PurposeElement = vzzzzj_,
                CopyrightElement = vzzzzk_,
                Structure = new List<StructureMap.StructureComponent>((IEnumerable<StructureMap.StructureComponent>)vzzzzl_),
                ImportElement = new List<Canonical>((IEnumerable<Canonical>)vzzzzm_),
                Group = new List<StructureMap.GroupComponent>((IEnumerable<StructureMap.GroupComponent>)vzzzzn_),
            };

            return vzzzzo_;
        };
        IEnumerable<StructureMap> uzzzzt_ = context.Operators.Select<StructureMap, StructureMap>((IEnumerable<StructureMap>)uzzzzr_, uzzzzs_);
        IEnumerable<StructureMap> uzzzzu_ = context.Operators.Distinct<StructureMap>(uzzzzt_);
        StructureMap uzzzzv_ = context.Operators.SingletonFrom<StructureMap>(uzzzzu_);

        return uzzzzv_;
    }


    [CqlExpressionDefinition("SubscriptionResource")]
    public Subscription SubscriptionResource(CqlContext context, Subscription arg)
    {
        Subscription[] vzzzzp_ = [
            arg,
        ];
        Subscription vzzzzq_(Subscription a)
        {
            Code<Subscription.SubscriptionStatus> vzzzzu_ = a?.StatusElement;
            List<ContactPoint> vzzzzv_ = a?.Contact;
            Instant vzzzzw_ = a?.EndElement;
            FhirString vzzzzx_ = a?.ReasonElement;
            FhirString vzzzzy_ = a?.CriteriaElement;
            FhirString vzzzzz_ = a?.ErrorElement;
            Subscription.ChannelComponent wzzzza_ = a?.Channel;
            Subscription wzzzzb_ = new Subscription
            {
                StatusElement = vzzzzu_,
                Contact = new List<ContactPoint>((IEnumerable<ContactPoint>)vzzzzv_),
                EndElement = vzzzzw_,
                ReasonElement = vzzzzx_,
                CriteriaElement = vzzzzy_,
                ErrorElement = vzzzzz_,
                Channel = wzzzza_,
            };

            return wzzzzb_;
        };
        IEnumerable<Subscription> vzzzzr_ = context.Operators.Select<Subscription, Subscription>((IEnumerable<Subscription>)vzzzzp_, vzzzzq_);
        IEnumerable<Subscription> vzzzzs_ = context.Operators.Distinct<Subscription>(vzzzzr_);
        Subscription vzzzzt_ = context.Operators.SingletonFrom<Subscription>(vzzzzs_);

        return vzzzzt_;
    }


    [CqlExpressionDefinition("SubstanceResource")]
    public Substance SubstanceResource(CqlContext context, Substance arg)
    {
        Substance[] wzzzzc_ = [
            arg,
        ];
        Substance wzzzzd_(Substance a)
        {
            List<Identifier> wzzzzh_ = a?.Identifier;
            Code<Substance.FHIRSubstanceStatus> wzzzzi_ = a?.StatusElement;
            List<CodeableConcept> wzzzzj_ = a?.Category;
            CodeableConcept wzzzzk_ = a?.Code;
            FhirString wzzzzl_ = a?.DescriptionElement;
            List<Substance.InstanceComponent> wzzzzm_ = a?.Instance;
            List<Substance.IngredientComponent> wzzzzn_ = a?.Ingredient;
            Substance wzzzzo_ = new Substance
            {
                Identifier = new List<Identifier>((IEnumerable<Identifier>)wzzzzh_),
                StatusElement = wzzzzi_,
                Category = new List<CodeableConcept>((IEnumerable<CodeableConcept>)wzzzzj_),
                Code = wzzzzk_,
                DescriptionElement = wzzzzl_,
                Instance = new List<Substance.InstanceComponent>((IEnumerable<Substance.InstanceComponent>)wzzzzm_),
                Ingredient = new List<Substance.IngredientComponent>((IEnumerable<Substance.IngredientComponent>)wzzzzn_),
            };

            return wzzzzo_;
        };
        IEnumerable<Substance> wzzzze_ = context.Operators.Select<Substance, Substance>((IEnumerable<Substance>)wzzzzc_, wzzzzd_);
        IEnumerable<Substance> wzzzzf_ = context.Operators.Distinct<Substance>(wzzzze_);
        Substance wzzzzg_ = context.Operators.SingletonFrom<Substance>(wzzzzf_);

        return wzzzzg_;
    }


    [CqlExpressionDefinition("SubstanceNucleicAcidResource")]
    public SubstanceNucleicAcid SubstanceNucleicAcidResource(CqlContext context, SubstanceNucleicAcid arg)
    {
        SubstanceNucleicAcid[] wzzzzp_ = [
            arg,
        ];
        SubstanceNucleicAcid wzzzzq_(SubstanceNucleicAcid a)
        {
            CodeableConcept wzzzzu_ = a?.SequenceType;
            Integer wzzzzv_ = a?.NumberOfSubunitsElement;
            FhirString wzzzzw_ = a?.AreaOfHybridisationElement;
            CodeableConcept wzzzzx_ = a?.OligoNucleotideType;
            List<SubstanceNucleicAcid.SubunitComponent> wzzzzy_ = a?.Subunit;
            SubstanceNucleicAcid wzzzzz_ = new SubstanceNucleicAcid
            {
                SequenceType = wzzzzu_,
                NumberOfSubunitsElement = wzzzzv_,
                AreaOfHybridisationElement = wzzzzw_,
                OligoNucleotideType = wzzzzx_,
                Subunit = new List<SubstanceNucleicAcid.SubunitComponent>((IEnumerable<SubstanceNucleicAcid.SubunitComponent>)wzzzzy_),
            };

            return wzzzzz_;
        };
        IEnumerable<SubstanceNucleicAcid> wzzzzr_ = context.Operators.Select<SubstanceNucleicAcid, SubstanceNucleicAcid>((IEnumerable<SubstanceNucleicAcid>)wzzzzp_, wzzzzq_);
        IEnumerable<SubstanceNucleicAcid> wzzzzs_ = context.Operators.Distinct<SubstanceNucleicAcid>(wzzzzr_);
        SubstanceNucleicAcid wzzzzt_ = context.Operators.SingletonFrom<SubstanceNucleicAcid>(wzzzzs_);

        return wzzzzt_;
    }


    [CqlExpressionDefinition("SubstancePolymerResource")]
    public SubstancePolymer SubstancePolymerResource(CqlContext context, SubstancePolymer arg)
    {
        SubstancePolymer[] xzzzza_ = [
            arg,
        ];
        SubstancePolymer xzzzzb_(SubstancePolymer a)
        {
            CodeableConcept xzzzzf_ = a?.Class;
            CodeableConcept xzzzzg_ = a?.Geometry;
            List<CodeableConcept> xzzzzh_ = a?.CopolymerConnectivity;
            List<FhirString> xzzzzi_ = a?.ModificationElement;
            List<SubstancePolymer.MonomerSetComponent> xzzzzj_ = a?.MonomerSet;
            List<SubstancePolymer.RepeatComponent> xzzzzk_ = a?.Repeat;
            SubstancePolymer xzzzzl_ = new SubstancePolymer
            {
                Class = xzzzzf_,
                Geometry = xzzzzg_,
                CopolymerConnectivity = new List<CodeableConcept>((IEnumerable<CodeableConcept>)xzzzzh_),
                ModificationElement = new List<FhirString>((IEnumerable<FhirString>)xzzzzi_),
                MonomerSet = new List<SubstancePolymer.MonomerSetComponent>((IEnumerable<SubstancePolymer.MonomerSetComponent>)xzzzzj_),
                Repeat = new List<SubstancePolymer.RepeatComponent>((IEnumerable<SubstancePolymer.RepeatComponent>)xzzzzk_),
            };

            return xzzzzl_;
        };
        IEnumerable<SubstancePolymer> xzzzzc_ = context.Operators.Select<SubstancePolymer, SubstancePolymer>((IEnumerable<SubstancePolymer>)xzzzza_, xzzzzb_);
        IEnumerable<SubstancePolymer> xzzzzd_ = context.Operators.Distinct<SubstancePolymer>(xzzzzc_);
        SubstancePolymer xzzzze_ = context.Operators.SingletonFrom<SubstancePolymer>(xzzzzd_);

        return xzzzze_;
    }


    [CqlExpressionDefinition("SubstanceProteinResource")]
    public SubstanceProtein SubstanceProteinResource(CqlContext context, SubstanceProtein arg)
    {
        SubstanceProtein[] xzzzzm_ = [
            arg,
        ];
        SubstanceProtein xzzzzn_(SubstanceProtein a)
        {
            CodeableConcept xzzzzr_ = a?.SequenceType;
            Integer xzzzzs_ = a?.NumberOfSubunitsElement;
            List<FhirString> xzzzzt_ = a?.DisulfideLinkageElement;
            List<SubstanceProtein.SubunitComponent> xzzzzu_ = a?.Subunit;
            SubstanceProtein xzzzzv_ = new SubstanceProtein
            {
                SequenceType = xzzzzr_,
                NumberOfSubunitsElement = xzzzzs_,
                DisulfideLinkageElement = new List<FhirString>((IEnumerable<FhirString>)xzzzzt_),
                Subunit = new List<SubstanceProtein.SubunitComponent>((IEnumerable<SubstanceProtein.SubunitComponent>)xzzzzu_),
            };

            return xzzzzv_;
        };
        IEnumerable<SubstanceProtein> xzzzzo_ = context.Operators.Select<SubstanceProtein, SubstanceProtein>((IEnumerable<SubstanceProtein>)xzzzzm_, xzzzzn_);
        IEnumerable<SubstanceProtein> xzzzzp_ = context.Operators.Distinct<SubstanceProtein>(xzzzzo_);
        SubstanceProtein xzzzzq_ = context.Operators.SingletonFrom<SubstanceProtein>(xzzzzp_);

        return xzzzzq_;
    }


    [CqlExpressionDefinition("SubstanceReferenceInformationResource")]
    public SubstanceReferenceInformation SubstanceReferenceInformationResource(CqlContext context, SubstanceReferenceInformation arg)
    {
        SubstanceReferenceInformation[] xzzzzw_ = [
            arg,
        ];
        SubstanceReferenceInformation xzzzzx_(SubstanceReferenceInformation a)
        {
            FhirString yzzzzb_ = a?.CommentElement;
            List<SubstanceReferenceInformation.GeneComponent> yzzzzc_ = a?.Gene;
            List<SubstanceReferenceInformation.GeneElementComponent> yzzzzd_ = a?.GeneElement;
            List<SubstanceReferenceInformation.ClassificationComponent> yzzzze_ = a?.Classification;
            List<SubstanceReferenceInformation.TargetComponent> yzzzzf_ = a?.Target;
            SubstanceReferenceInformation yzzzzg_ = new SubstanceReferenceInformation
            {
                CommentElement = yzzzzb_,
                Gene = new List<SubstanceReferenceInformation.GeneComponent>((IEnumerable<SubstanceReferenceInformation.GeneComponent>)yzzzzc_),
                GeneElement = new List<SubstanceReferenceInformation.GeneElementComponent>((IEnumerable<SubstanceReferenceInformation.GeneElementComponent>)yzzzzd_),
                Classification = new List<SubstanceReferenceInformation.ClassificationComponent>((IEnumerable<SubstanceReferenceInformation.ClassificationComponent>)yzzzze_),
                Target = new List<SubstanceReferenceInformation.TargetComponent>((IEnumerable<SubstanceReferenceInformation.TargetComponent>)yzzzzf_),
            };

            return yzzzzg_;
        };
        IEnumerable<SubstanceReferenceInformation> xzzzzy_ = context.Operators.Select<SubstanceReferenceInformation, SubstanceReferenceInformation>((IEnumerable<SubstanceReferenceInformation>)xzzzzw_, xzzzzx_);
        IEnumerable<SubstanceReferenceInformation> xzzzzz_ = context.Operators.Distinct<SubstanceReferenceInformation>(xzzzzy_);
        SubstanceReferenceInformation yzzzza_ = context.Operators.SingletonFrom<SubstanceReferenceInformation>(xzzzzz_);

        return yzzzza_;
    }


    [CqlExpressionDefinition("SubstanceSourceMaterialResource")]
    public SubstanceSourceMaterial SubstanceSourceMaterialResource(CqlContext context, SubstanceSourceMaterial arg)
    {
        SubstanceSourceMaterial[] yzzzzh_ = [
            arg,
        ];
        SubstanceSourceMaterial yzzzzi_(SubstanceSourceMaterial a)
        {
            CodeableConcept yzzzzm_ = a?.SourceMaterialClass;
            CodeableConcept yzzzzn_ = a?.SourceMaterialType;
            CodeableConcept yzzzzo_ = a?.SourceMaterialState;
            Identifier yzzzzp_ = a?.OrganismId;
            FhirString yzzzzq_ = a?.OrganismNameElement;
            List<Identifier> yzzzzr_ = a?.ParentSubstanceId;
            List<FhirString> yzzzzs_ = a?.ParentSubstanceNameElement;
            List<CodeableConcept> yzzzzt_ = a?.CountryOfOrigin;
            List<FhirString> yzzzzu_ = a?.GeographicalLocationElement;
            CodeableConcept yzzzzv_ = a?.DevelopmentStage;
            List<SubstanceSourceMaterial.FractionDescriptionComponent> yzzzzw_ = a?.FractionDescription;
            SubstanceSourceMaterial.OrganismComponent yzzzzx_ = a?.Organism;
            List<SubstanceSourceMaterial.PartDescriptionComponent> yzzzzy_ = a?.PartDescription;
            SubstanceSourceMaterial yzzzzz_ = new SubstanceSourceMaterial
            {
                SourceMaterialClass = yzzzzm_,
                SourceMaterialType = yzzzzn_,
                SourceMaterialState = yzzzzo_,
                OrganismId = yzzzzp_,
                OrganismNameElement = yzzzzq_,
                ParentSubstanceId = new List<Identifier>((IEnumerable<Identifier>)yzzzzr_),
                ParentSubstanceNameElement = new List<FhirString>((IEnumerable<FhirString>)yzzzzs_),
                CountryOfOrigin = new List<CodeableConcept>((IEnumerable<CodeableConcept>)yzzzzt_),
                GeographicalLocationElement = new List<FhirString>((IEnumerable<FhirString>)yzzzzu_),
                DevelopmentStage = yzzzzv_,
                FractionDescription = new List<SubstanceSourceMaterial.FractionDescriptionComponent>((IEnumerable<SubstanceSourceMaterial.FractionDescriptionComponent>)yzzzzw_),
                Organism = yzzzzx_,
                PartDescription = new List<SubstanceSourceMaterial.PartDescriptionComponent>((IEnumerable<SubstanceSourceMaterial.PartDescriptionComponent>)yzzzzy_),
            };

            return yzzzzz_;
        };
        IEnumerable<SubstanceSourceMaterial> yzzzzj_ = context.Operators.Select<SubstanceSourceMaterial, SubstanceSourceMaterial>((IEnumerable<SubstanceSourceMaterial>)yzzzzh_, yzzzzi_);
        IEnumerable<SubstanceSourceMaterial> yzzzzk_ = context.Operators.Distinct<SubstanceSourceMaterial>(yzzzzj_);
        SubstanceSourceMaterial yzzzzl_ = context.Operators.SingletonFrom<SubstanceSourceMaterial>(yzzzzk_);

        return yzzzzl_;
    }


    [CqlExpressionDefinition("SubstanceSpecificationResource")]
    public SubstanceSpecification SubstanceSpecificationResource(CqlContext context, SubstanceSpecification arg)
    {
        SubstanceSpecification[] zzzzza_ = [
            arg,
        ];
        SubstanceSpecification zzzzzb_(SubstanceSpecification a)
        {
            Identifier zzzzzf_ = a?.Identifier;
            CodeableConcept zzzzzg_ = a?.Type;
            CodeableConcept zzzzzh_ = a?.Status;
            CodeableConcept zzzzzi_ = a?.Domain;
            FhirString zzzzzj_ = a?.DescriptionElement;
            List<ResourceReference> zzzzzk_ = a?.Source;
            FhirString zzzzzl_ = a?.CommentElement;
            List<SubstanceSpecification.MoietyComponent> zzzzzm_ = a?.Moiety;
            List<SubstanceSpecification.PropertyComponent> zzzzzn_ = a?.Property;
            ResourceReference zzzzzo_ = a?.ReferenceInformation;
            SubstanceSpecification.StructureComponent zzzzzp_ = a?.Structure;
            List<SubstanceSpecification.CodeComponent> zzzzzq_ = a?.Code;
            List<SubstanceSpecification.NameComponent> zzzzzr_ = a?.Name;
            List<SubstanceSpecification.MolecularWeightComponent> zzzzzs_ = a?.MolecularWeight;
            List<SubstanceSpecification.RelationshipComponent> zzzzzt_ = a?.Relationship;
            ResourceReference zzzzzu_ = a?.NucleicAcid;
            ResourceReference zzzzzv_ = a?.Polymer;
            ResourceReference zzzzzw_ = a?.Protein;
            ResourceReference zzzzzx_ = a?.SourceMaterial;
            SubstanceSpecification zzzzzy_ = new SubstanceSpecification
            {
                Identifier = zzzzzf_,
                Type = zzzzzg_,
                Status = zzzzzh_,
                Domain = zzzzzi_,
                DescriptionElement = zzzzzj_,
                Source = new List<ResourceReference>((IEnumerable<ResourceReference>)zzzzzk_),
                CommentElement = zzzzzl_,
                Moiety = new List<SubstanceSpecification.MoietyComponent>((IEnumerable<SubstanceSpecification.MoietyComponent>)zzzzzm_),
                Property = new List<SubstanceSpecification.PropertyComponent>((IEnumerable<SubstanceSpecification.PropertyComponent>)zzzzzn_),
                ReferenceInformation = zzzzzo_,
                Structure = zzzzzp_,
                Code = new List<SubstanceSpecification.CodeComponent>((IEnumerable<SubstanceSpecification.CodeComponent>)zzzzzq_),
                Name = new List<SubstanceSpecification.NameComponent>((IEnumerable<SubstanceSpecification.NameComponent>)zzzzzr_),
                MolecularWeight = new List<SubstanceSpecification.MolecularWeightComponent>((IEnumerable<SubstanceSpecification.MolecularWeightComponent>)zzzzzs_),
                Relationship = new List<SubstanceSpecification.RelationshipComponent>((IEnumerable<SubstanceSpecification.RelationshipComponent>)zzzzzt_),
                NucleicAcid = zzzzzu_,
                Polymer = zzzzzv_,
                Protein = zzzzzw_,
                SourceMaterial = zzzzzx_,
            };

            return zzzzzy_;
        };
        IEnumerable<SubstanceSpecification> zzzzzc_ = context.Operators.Select<SubstanceSpecification, SubstanceSpecification>((IEnumerable<SubstanceSpecification>)zzzzza_, zzzzzb_);
        IEnumerable<SubstanceSpecification> zzzzzd_ = context.Operators.Distinct<SubstanceSpecification>(zzzzzc_);
        SubstanceSpecification zzzzze_ = context.Operators.SingletonFrom<SubstanceSpecification>(zzzzzd_);

        return zzzzze_;
    }


    [CqlExpressionDefinition("SupplyDeliveryResource")]
    public SupplyDelivery SupplyDeliveryResource(CqlContext context, SupplyDelivery arg)
    {
        SupplyDelivery[] zzzzzz_ = [
            arg,
        ];
        SupplyDelivery azzzzza_(SupplyDelivery a)
        {
            List<Identifier> azzzzze_ = a?.Identifier;
            List<ResourceReference> azzzzzf_ = a?.BasedOn;
            List<ResourceReference> azzzzzg_ = a?.PartOf;
            Code<SupplyDelivery.SupplyDeliveryStatus> azzzzzh_ = a?.StatusElement;
            ResourceReference azzzzzi_ = a?.Patient;
            CodeableConcept azzzzzj_ = a?.Type;
            SupplyDelivery.SuppliedItemComponent azzzzzk_ = a?.SuppliedItem;
            DataType azzzzzl_ = a?.Occurrence;
            ResourceReference azzzzzm_ = a?.Supplier;
            ResourceReference azzzzzn_ = a?.Destination;
            List<ResourceReference> azzzzzo_ = a?.Receiver;
            SupplyDelivery azzzzzp_ = new SupplyDelivery
            {
                Identifier = new List<Identifier>((IEnumerable<Identifier>)azzzzze_),
                BasedOn = new List<ResourceReference>((IEnumerable<ResourceReference>)azzzzzf_),
                PartOf = new List<ResourceReference>((IEnumerable<ResourceReference>)azzzzzg_),
                StatusElement = azzzzzh_,
                Patient = azzzzzi_,
                Type = azzzzzj_,
                SuppliedItem = azzzzzk_,
                Occurrence = (DataType)azzzzzl_,
                Supplier = azzzzzm_,
                Destination = azzzzzn_,
                Receiver = new List<ResourceReference>((IEnumerable<ResourceReference>)azzzzzo_),
            };

            return azzzzzp_;
        };
        IEnumerable<SupplyDelivery> azzzzzb_ = context.Operators.Select<SupplyDelivery, SupplyDelivery>((IEnumerable<SupplyDelivery>)zzzzzz_, azzzzza_);
        IEnumerable<SupplyDelivery> azzzzzc_ = context.Operators.Distinct<SupplyDelivery>(azzzzzb_);
        SupplyDelivery azzzzzd_ = context.Operators.SingletonFrom<SupplyDelivery>(azzzzzc_);

        return azzzzzd_;
    }


    [CqlExpressionDefinition("SupplyRequestResource")]
    public SupplyRequest SupplyRequestResource(CqlContext context, SupplyRequest arg)
    {
        SupplyRequest[] azzzzzq_ = [
            arg,
        ];
        SupplyRequest azzzzzr_(SupplyRequest a)
        {
            List<Identifier> azzzzzv_ = a?.Identifier;
            Code<SupplyRequest.SupplyRequestStatus> azzzzzw_ = a?.StatusElement;
            CodeableConcept azzzzzx_ = a?.Category;
            Code<RequestPriority> azzzzzy_ = a?.PriorityElement;
            DataType azzzzzz_ = a?.Item;
            Quantity bzzzzza_ = a?.Quantity;
            List<SupplyRequest.ParameterComponent> bzzzzzb_ = a?.Parameter;
            DataType bzzzzzc_ = a?.Occurrence;
            FhirDateTime bzzzzzd_ = a?.AuthoredOnElement;
            ResourceReference bzzzzze_ = a?.Requester;
            List<ResourceReference> bzzzzzf_ = a?.Supplier;
            List<CodeableConcept> bzzzzzg_ = a?.ReasonCode;
            List<ResourceReference> bzzzzzh_ = a?.ReasonReference;
            ResourceReference bzzzzzi_ = a?.DeliverFrom;
            ResourceReference bzzzzzj_ = a?.DeliverTo;
            SupplyRequest bzzzzzk_ = new SupplyRequest
            {
                Identifier = new List<Identifier>((IEnumerable<Identifier>)azzzzzv_),
                StatusElement = azzzzzw_,
                Category = azzzzzx_,
                PriorityElement = azzzzzy_,
                Item = (DataType)azzzzzz_,
                Quantity = bzzzzza_,
                Parameter = new List<SupplyRequest.ParameterComponent>((IEnumerable<SupplyRequest.ParameterComponent>)bzzzzzb_),
                Occurrence = (DataType)bzzzzzc_,
                AuthoredOnElement = bzzzzzd_,
                Requester = bzzzzze_,
                Supplier = new List<ResourceReference>((IEnumerable<ResourceReference>)bzzzzzf_),
                ReasonCode = new List<CodeableConcept>((IEnumerable<CodeableConcept>)bzzzzzg_),
                ReasonReference = new List<ResourceReference>((IEnumerable<ResourceReference>)bzzzzzh_),
                DeliverFrom = bzzzzzi_,
                DeliverTo = bzzzzzj_,
            };

            return bzzzzzk_;
        };
        IEnumerable<SupplyRequest> azzzzzs_ = context.Operators.Select<SupplyRequest, SupplyRequest>((IEnumerable<SupplyRequest>)azzzzzq_, azzzzzr_);
        IEnumerable<SupplyRequest> azzzzzt_ = context.Operators.Distinct<SupplyRequest>(azzzzzs_);
        SupplyRequest azzzzzu_ = context.Operators.SingletonFrom<SupplyRequest>(azzzzzt_);

        return azzzzzu_;
    }


    [CqlExpressionDefinition("TaskResource")]
    public Task TaskResource(CqlContext context, Task arg)
    {
        Task[] bzzzzzl_ = [
            arg,
        ];
        Task bzzzzzm_(Task a)
        {
            List<Identifier> bzzzzzq_ = a?.Identifier;
            Canonical bzzzzzr_ = a?.InstantiatesCanonicalElement;
            FhirUri bzzzzzs_ = a?.InstantiatesUriElement;
            List<ResourceReference> bzzzzzt_ = a?.BasedOn;
            Identifier bzzzzzu_ = a?.GroupIdentifier;
            List<ResourceReference> bzzzzzv_ = a?.PartOf;
            Code<Task.TaskStatus> bzzzzzw_ = a?.StatusElement;
            CodeableConcept bzzzzzx_ = a?.StatusReason;
            CodeableConcept bzzzzzy_ = a?.BusinessStatus;
            Code<Task.TaskIntent> bzzzzzz_ = a?.IntentElement;
            Code<RequestPriority> czzzzza_ = a?.PriorityElement;
            CodeableConcept czzzzzb_ = a?.Code;
            FhirString czzzzzc_ = a?.DescriptionElement;
            ResourceReference czzzzzd_ = a?.Focus;
            ResourceReference czzzzze_ = a?.For;
            ResourceReference czzzzzf_ = a?.Encounter;
            Period czzzzzg_ = a?.ExecutionPeriod;
            FhirDateTime czzzzzh_ = a?.AuthoredOnElement;
            FhirDateTime czzzzzi_ = a?.LastModifiedElement;
            ResourceReference czzzzzj_ = a?.Requester;
            List<CodeableConcept> czzzzzk_ = a?.PerformerType;
            ResourceReference czzzzzl_ = a?.Owner;
            ResourceReference czzzzzm_ = a?.Location;
            CodeableConcept czzzzzn_ = a?.ReasonCode;
            ResourceReference czzzzzo_ = a?.ReasonReference;
            List<ResourceReference> czzzzzp_ = a?.Insurance;
            List<Annotation> czzzzzq_ = a?.Note;
            List<ResourceReference> czzzzzr_ = a?.RelevantHistory;
            Task.RestrictionComponent czzzzzs_ = a?.Restriction;
            List<Task.ParameterComponent> czzzzzt_ = a?.Input;
            List<Task.OutputComponent> czzzzzu_ = a?.Output;
            Task czzzzzv_ = new Task
            {
                Identifier = new List<Identifier>((IEnumerable<Identifier>)bzzzzzq_),
                InstantiatesCanonicalElement = bzzzzzr_,
                InstantiatesUriElement = bzzzzzs_,
                BasedOn = new List<ResourceReference>((IEnumerable<ResourceReference>)bzzzzzt_),
                GroupIdentifier = bzzzzzu_,
                PartOf = new List<ResourceReference>((IEnumerable<ResourceReference>)bzzzzzv_),
                StatusElement = bzzzzzw_,
                StatusReason = bzzzzzx_,
                BusinessStatus = bzzzzzy_,
                IntentElement = bzzzzzz_,
                PriorityElement = czzzzza_,
                Code = czzzzzb_,
                DescriptionElement = czzzzzc_,
                Focus = czzzzzd_,
                For = czzzzze_,
                Encounter = czzzzzf_,
                ExecutionPeriod = czzzzzg_,
                AuthoredOnElement = czzzzzh_,
                LastModifiedElement = czzzzzi_,
                Requester = czzzzzj_,
                PerformerType = new List<CodeableConcept>((IEnumerable<CodeableConcept>)czzzzzk_),
                Owner = czzzzzl_,
                Location = czzzzzm_,
                ReasonCode = czzzzzn_,
                ReasonReference = czzzzzo_,
                Insurance = new List<ResourceReference>((IEnumerable<ResourceReference>)czzzzzp_),
                Note = new List<Annotation>((IEnumerable<Annotation>)czzzzzq_),
                RelevantHistory = new List<ResourceReference>((IEnumerable<ResourceReference>)czzzzzr_),
                Restriction = czzzzzs_,
                Input = new List<Task.ParameterComponent>((IEnumerable<Task.ParameterComponent>)czzzzzt_),
                Output = new List<Task.OutputComponent>((IEnumerable<Task.OutputComponent>)czzzzzu_),
            };

            return czzzzzv_;
        };
        IEnumerable<Task> bzzzzzn_ = context.Operators.Select<Task, Task>((IEnumerable<Task>)bzzzzzl_, bzzzzzm_);
        IEnumerable<Task> bzzzzzo_ = context.Operators.Distinct<Task>(bzzzzzn_);
        Task bzzzzzp_ = context.Operators.SingletonFrom<Task>(bzzzzzo_);

        return bzzzzzp_;
    }


    [CqlExpressionDefinition("TerminologyCapabilitiesResource")]
    public TerminologyCapabilities TerminologyCapabilitiesResource(CqlContext context, TerminologyCapabilities arg)
    {
        TerminologyCapabilities[] czzzzzw_ = [
            arg,
        ];
        TerminologyCapabilities czzzzzx_(TerminologyCapabilities a)
        {
            FhirUri dzzzzzb_ = a?.UrlElement;
            FhirString dzzzzzc_ = a?.VersionElement;
            FhirString dzzzzzd_ = a?.NameElement;
            FhirString dzzzzze_ = a?.TitleElement;
            Code<PublicationStatus> dzzzzzf_ = a?.StatusElement;
            FhirBoolean dzzzzzg_ = a?.ExperimentalElement;
            FhirDateTime dzzzzzh_ = a?.DateElement;
            FhirString dzzzzzi_ = a?.PublisherElement;
            List<ContactDetail> dzzzzzj_ = a?.Contact;
            Markdown dzzzzzk_ = a?.DescriptionElement;
            List<UsageContext> dzzzzzl_ = a?.UseContext;
            List<CodeableConcept> dzzzzzm_ = a?.Jurisdiction;
            Markdown dzzzzzn_ = a?.PurposeElement;
            Markdown dzzzzzo_ = a?.CopyrightElement;
            Code<CapabilityStatementKind> dzzzzzp_ = a?.KindElement;
            TerminologyCapabilities.SoftwareComponent dzzzzzq_ = a?.Software;
            TerminologyCapabilities.ImplementationComponent dzzzzzr_ = a?.Implementation;
            FhirBoolean dzzzzzs_ = a?.LockedDateElement;
            List<TerminologyCapabilities.CodeSystemComponent> dzzzzzt_ = a?.CodeSystem;
            TerminologyCapabilities.ExpansionComponent dzzzzzu_ = a?.Expansion;
            Code<TerminologyCapabilities.CodeSearchSupport> dzzzzzv_ = a?.CodeSearchElement;
            TerminologyCapabilities.ValidateCodeComponent dzzzzzw_ = a?.ValidateCode;
            TerminologyCapabilities.TranslationComponent dzzzzzx_ = a?.Translation;
            TerminologyCapabilities.ClosureComponent dzzzzzy_ = a?.Closure;
            TerminologyCapabilities dzzzzzz_ = new TerminologyCapabilities
            {
                UrlElement = dzzzzzb_,
                VersionElement = dzzzzzc_,
                NameElement = dzzzzzd_,
                TitleElement = dzzzzze_,
                StatusElement = dzzzzzf_,
                ExperimentalElement = dzzzzzg_,
                DateElement = dzzzzzh_,
                PublisherElement = dzzzzzi_,
                Contact = new List<ContactDetail>((IEnumerable<ContactDetail>)dzzzzzj_),
                DescriptionElement = dzzzzzk_,
                UseContext = new List<UsageContext>((IEnumerable<UsageContext>)dzzzzzl_),
                Jurisdiction = new List<CodeableConcept>((IEnumerable<CodeableConcept>)dzzzzzm_),
                PurposeElement = dzzzzzn_,
                CopyrightElement = dzzzzzo_,
                KindElement = dzzzzzp_,
                Software = dzzzzzq_,
                Implementation = dzzzzzr_,
                LockedDateElement = dzzzzzs_,
                CodeSystem = new List<TerminologyCapabilities.CodeSystemComponent>((IEnumerable<TerminologyCapabilities.CodeSystemComponent>)dzzzzzt_),
                Expansion = dzzzzzu_,
                CodeSearchElement = dzzzzzv_,
                ValidateCode = dzzzzzw_,
                Translation = dzzzzzx_,
                Closure = dzzzzzy_,
            };

            return dzzzzzz_;
        };
        IEnumerable<TerminologyCapabilities> czzzzzy_ = context.Operators.Select<TerminologyCapabilities, TerminologyCapabilities>((IEnumerable<TerminologyCapabilities>)czzzzzw_, czzzzzx_);
        IEnumerable<TerminologyCapabilities> czzzzzz_ = context.Operators.Distinct<TerminologyCapabilities>(czzzzzy_);
        TerminologyCapabilities dzzzzza_ = context.Operators.SingletonFrom<TerminologyCapabilities>(czzzzzz_);

        return dzzzzza_;
    }


    [CqlExpressionDefinition("TestReportResource")]
    public TestReport TestReportResource(CqlContext context, TestReport arg)
    {
        TestReport[] ezzzzza_ = [
            arg,
        ];
        TestReport ezzzzzb_(TestReport a)
        {
            Identifier ezzzzzf_ = a?.Identifier;
            FhirString ezzzzzg_ = a?.NameElement;
            Code<TestReport.TestReportStatus> ezzzzzh_ = a?.StatusElement;
            ResourceReference ezzzzzi_ = a?.TestScript;
            Code<TestReport.TestReportResult> ezzzzzj_ = a?.ResultElement;
            FhirDecimal ezzzzzk_ = a?.ScoreElement;
            FhirString ezzzzzl_ = a?.TesterElement;
            FhirDateTime ezzzzzm_ = a?.IssuedElement;
            List<TestReport.ParticipantComponent> ezzzzzn_ = a?.Participant;
            TestReport.SetupComponent ezzzzzo_ = a?.Setup;
            List<TestReport.TestComponent> ezzzzzp_ = a?.Test;
            TestReport.TeardownComponent ezzzzzq_ = a?.Teardown;
            TestReport ezzzzzr_ = new TestReport
            {
                Identifier = ezzzzzf_,
                NameElement = ezzzzzg_,
                StatusElement = ezzzzzh_,
                TestScript = ezzzzzi_,
                ResultElement = ezzzzzj_,
                ScoreElement = ezzzzzk_,
                TesterElement = ezzzzzl_,
                IssuedElement = ezzzzzm_,
                Participant = new List<TestReport.ParticipantComponent>((IEnumerable<TestReport.ParticipantComponent>)ezzzzzn_),
                Setup = ezzzzzo_,
                Test = new List<TestReport.TestComponent>((IEnumerable<TestReport.TestComponent>)ezzzzzp_),
                Teardown = ezzzzzq_,
            };

            return ezzzzzr_;
        };
        IEnumerable<TestReport> ezzzzzc_ = context.Operators.Select<TestReport, TestReport>((IEnumerable<TestReport>)ezzzzza_, ezzzzzb_);
        IEnumerable<TestReport> ezzzzzd_ = context.Operators.Distinct<TestReport>(ezzzzzc_);
        TestReport ezzzzze_ = context.Operators.SingletonFrom<TestReport>(ezzzzzd_);

        return ezzzzze_;
    }


    [CqlExpressionDefinition("TestScriptResource")]
    public TestScript TestScriptResource(CqlContext context, TestScript arg)
    {
        TestScript[] ezzzzzs_ = [
            arg,
        ];
        TestScript ezzzzzt_(TestScript a)
        {
            FhirUri ezzzzzx_ = a?.UrlElement;
            Identifier ezzzzzy_ = a?.Identifier;
            FhirString ezzzzzz_ = a?.VersionElement;
            FhirString fzzzzza_ = a?.NameElement;
            FhirString fzzzzzb_ = a?.TitleElement;
            Code<PublicationStatus> fzzzzzc_ = a?.StatusElement;
            FhirBoolean fzzzzzd_ = a?.ExperimentalElement;
            FhirDateTime fzzzzze_ = a?.DateElement;
            FhirString fzzzzzf_ = a?.PublisherElement;
            List<ContactDetail> fzzzzzg_ = a?.Contact;
            Markdown fzzzzzh_ = a?.DescriptionElement;
            List<UsageContext> fzzzzzi_ = a?.UseContext;
            List<CodeableConcept> fzzzzzj_ = a?.Jurisdiction;
            Markdown fzzzzzk_ = a?.PurposeElement;
            Markdown fzzzzzl_ = a?.CopyrightElement;
            List<TestScript.OriginComponent> fzzzzzm_ = a?.Origin;
            List<TestScript.DestinationComponent> fzzzzzn_ = a?.Destination;
            TestScript.MetadataComponent fzzzzzo_ = a?.Metadata;
            List<TestScript.FixtureComponent> fzzzzzp_ = a?.Fixture;
            List<ResourceReference> fzzzzzq_ = a?.Profile;
            List<TestScript.VariableComponent> fzzzzzr_ = a?.Variable;
            TestScript.SetupComponent fzzzzzs_ = a?.Setup;
            List<TestScript.TestComponent> fzzzzzt_ = a?.Test;
            TestScript.TeardownComponent fzzzzzu_ = a?.Teardown;
            TestScript fzzzzzv_ = new TestScript
            {
                UrlElement = ezzzzzx_,
                Identifier = ezzzzzy_,
                VersionElement = ezzzzzz_,
                NameElement = fzzzzza_,
                TitleElement = fzzzzzb_,
                StatusElement = fzzzzzc_,
                ExperimentalElement = fzzzzzd_,
                DateElement = fzzzzze_,
                PublisherElement = fzzzzzf_,
                Contact = new List<ContactDetail>((IEnumerable<ContactDetail>)fzzzzzg_),
                DescriptionElement = fzzzzzh_,
                UseContext = new List<UsageContext>((IEnumerable<UsageContext>)fzzzzzi_),
                Jurisdiction = new List<CodeableConcept>((IEnumerable<CodeableConcept>)fzzzzzj_),
                PurposeElement = fzzzzzk_,
                CopyrightElement = fzzzzzl_,
                Origin = new List<TestScript.OriginComponent>((IEnumerable<TestScript.OriginComponent>)fzzzzzm_),
                Destination = new List<TestScript.DestinationComponent>((IEnumerable<TestScript.DestinationComponent>)fzzzzzn_),
                Metadata = fzzzzzo_,
                Fixture = new List<TestScript.FixtureComponent>((IEnumerable<TestScript.FixtureComponent>)fzzzzzp_),
                Profile = new List<ResourceReference>((IEnumerable<ResourceReference>)fzzzzzq_),
                Variable = new List<TestScript.VariableComponent>((IEnumerable<TestScript.VariableComponent>)fzzzzzr_),
                Setup = fzzzzzs_,
                Test = new List<TestScript.TestComponent>((IEnumerable<TestScript.TestComponent>)fzzzzzt_),
                Teardown = fzzzzzu_,
            };

            return fzzzzzv_;
        };
        IEnumerable<TestScript> ezzzzzu_ = context.Operators.Select<TestScript, TestScript>((IEnumerable<TestScript>)ezzzzzs_, ezzzzzt_);
        IEnumerable<TestScript> ezzzzzv_ = context.Operators.Distinct<TestScript>(ezzzzzu_);
        TestScript ezzzzzw_ = context.Operators.SingletonFrom<TestScript>(ezzzzzv_);

        return ezzzzzw_;
    }


    [CqlExpressionDefinition("ValueSetResource")]
    public ValueSet ValueSetResource(CqlContext context, ValueSet arg)
    {
        ValueSet[] fzzzzzw_ = [
            arg,
        ];
        ValueSet fzzzzzx_(ValueSet a)
        {
            FhirUri gzzzzzb_ = a?.UrlElement;
            List<Identifier> gzzzzzc_ = a?.Identifier;
            FhirString gzzzzzd_ = a?.VersionElement;
            FhirString gzzzzze_ = a?.NameElement;
            FhirString gzzzzzf_ = a?.TitleElement;
            Code<PublicationStatus> gzzzzzg_ = a?.StatusElement;
            FhirBoolean gzzzzzh_ = a?.ExperimentalElement;
            FhirDateTime gzzzzzi_ = a?.DateElement;
            FhirString gzzzzzj_ = a?.PublisherElement;
            List<ContactDetail> gzzzzzk_ = a?.Contact;
            Markdown gzzzzzl_ = a?.DescriptionElement;
            List<UsageContext> gzzzzzm_ = a?.UseContext;
            List<CodeableConcept> gzzzzzn_ = a?.Jurisdiction;
            FhirBoolean gzzzzzo_ = a?.ImmutableElement;
            Markdown gzzzzzp_ = a?.PurposeElement;
            Markdown gzzzzzq_ = a?.CopyrightElement;
            ValueSet.ComposeComponent gzzzzzr_ = a?.Compose;
            ValueSet.ExpansionComponent gzzzzzs_ = a?.Expansion;
            ValueSet gzzzzzt_ = new ValueSet
            {
                UrlElement = gzzzzzb_,
                Identifier = new List<Identifier>((IEnumerable<Identifier>)gzzzzzc_),
                VersionElement = gzzzzzd_,
                NameElement = gzzzzze_,
                TitleElement = gzzzzzf_,
                StatusElement = gzzzzzg_,
                ExperimentalElement = gzzzzzh_,
                DateElement = gzzzzzi_,
                PublisherElement = gzzzzzj_,
                Contact = new List<ContactDetail>((IEnumerable<ContactDetail>)gzzzzzk_),
                DescriptionElement = gzzzzzl_,
                UseContext = new List<UsageContext>((IEnumerable<UsageContext>)gzzzzzm_),
                Jurisdiction = new List<CodeableConcept>((IEnumerable<CodeableConcept>)gzzzzzn_),
                ImmutableElement = gzzzzzo_,
                PurposeElement = gzzzzzp_,
                CopyrightElement = gzzzzzq_,
                Compose = gzzzzzr_,
                Expansion = gzzzzzs_,
            };

            return gzzzzzt_;
        };
        IEnumerable<ValueSet> fzzzzzy_ = context.Operators.Select<ValueSet, ValueSet>((IEnumerable<ValueSet>)fzzzzzw_, fzzzzzx_);
        IEnumerable<ValueSet> fzzzzzz_ = context.Operators.Distinct<ValueSet>(fzzzzzy_);
        ValueSet gzzzzza_ = context.Operators.SingletonFrom<ValueSet>(fzzzzzz_);

        return gzzzzza_;
    }


    [CqlExpressionDefinition("VerificationResultResource")]
    public VerificationResult VerificationResultResource(CqlContext context, VerificationResult arg)
    {
        VerificationResult[] gzzzzzu_ = [
            arg,
        ];
        VerificationResult gzzzzzv_(VerificationResult a)
        {
            List<ResourceReference> gzzzzzz_ = a?.Target;
            List<FhirString> hzzzzza_ = a?.TargetLocationElement;
            CodeableConcept hzzzzzb_ = a?.Need;
            Code<VerificationResult.StatusCode> hzzzzzc_ = a?.StatusElement;
            FhirDateTime hzzzzzd_ = a?.StatusDateElement;
            CodeableConcept hzzzzze_ = a?.ValidationType;
            List<CodeableConcept> hzzzzzf_ = a?.ValidationProcess;
            Timing hzzzzzg_ = a?.Frequency;
            FhirDateTime hzzzzzh_ = a?.LastPerformedElement;
            Date hzzzzzi_ = a?.NextScheduledElement;
            CodeableConcept hzzzzzj_ = a?.FailureAction;
            List<VerificationResult.PrimarySourceComponent> hzzzzzk_ = a?.PrimarySource;
            VerificationResult.AttestationComponent hzzzzzl_ = a?.Attestation;
            List<VerificationResult.ValidatorComponent> hzzzzzm_ = a?.Validator;
            VerificationResult hzzzzzn_ = new VerificationResult
            {
                Target = new List<ResourceReference>((IEnumerable<ResourceReference>)gzzzzzz_),
                TargetLocationElement = new List<FhirString>((IEnumerable<FhirString>)hzzzzza_),
                Need = hzzzzzb_,
                StatusElement = hzzzzzc_,
                StatusDateElement = hzzzzzd_,
                ValidationType = hzzzzze_,
                ValidationProcess = new List<CodeableConcept>((IEnumerable<CodeableConcept>)hzzzzzf_),
                Frequency = hzzzzzg_,
                LastPerformedElement = hzzzzzh_,
                NextScheduledElement = hzzzzzi_,
                FailureAction = hzzzzzj_,
                PrimarySource = new List<VerificationResult.PrimarySourceComponent>((IEnumerable<VerificationResult.PrimarySourceComponent>)hzzzzzk_),
                Attestation = hzzzzzl_,
                Validator = new List<VerificationResult.ValidatorComponent>((IEnumerable<VerificationResult.ValidatorComponent>)hzzzzzm_),
            };

            return hzzzzzn_;
        };
        IEnumerable<VerificationResult> gzzzzzw_ = context.Operators.Select<VerificationResult, VerificationResult>((IEnumerable<VerificationResult>)gzzzzzu_, gzzzzzv_);
        IEnumerable<VerificationResult> gzzzzzx_ = context.Operators.Distinct<VerificationResult>(gzzzzzw_);
        VerificationResult gzzzzzy_ = context.Operators.SingletonFrom<VerificationResult>(gzzzzzx_);

        return gzzzzzy_;
    }


    [CqlExpressionDefinition("VisionPrescriptionResource")]
    public VisionPrescription VisionPrescriptionResource(CqlContext context, VisionPrescription arg)
    {
        VisionPrescription[] hzzzzzo_ = [
            arg,
        ];
        VisionPrescription hzzzzzp_(VisionPrescription a)
        {
            List<Identifier> hzzzzzt_ = a?.Identifier;
            Code<FinancialResourceStatusCodes> hzzzzzu_ = a?.StatusElement;
            FhirDateTime hzzzzzv_ = a?.CreatedElement;
            ResourceReference hzzzzzw_ = a?.Patient;
            ResourceReference hzzzzzx_ = a?.Encounter;
            FhirDateTime hzzzzzy_ = a?.DateWrittenElement;
            ResourceReference hzzzzzz_ = a?.Prescriber;
            List<VisionPrescription.LensSpecificationComponent> izzzzza_ = a?.LensSpecification;
            VisionPrescription izzzzzb_ = new VisionPrescription
            {
                Identifier = new List<Identifier>((IEnumerable<Identifier>)hzzzzzt_),
                StatusElement = hzzzzzu_,
                CreatedElement = hzzzzzv_,
                Patient = hzzzzzw_,
                Encounter = hzzzzzx_,
                DateWrittenElement = hzzzzzy_,
                Prescriber = hzzzzzz_,
                LensSpecification = new List<VisionPrescription.LensSpecificationComponent>((IEnumerable<VisionPrescription.LensSpecificationComponent>)izzzzza_),
            };

            return izzzzzb_;
        };
        IEnumerable<VisionPrescription> hzzzzzq_ = context.Operators.Select<VisionPrescription, VisionPrescription>((IEnumerable<VisionPrescription>)hzzzzzo_, hzzzzzp_);
        IEnumerable<VisionPrescription> hzzzzzr_ = context.Operators.Distinct<VisionPrescription>(hzzzzzq_);
        VisionPrescription hzzzzzs_ = context.Operators.SingletonFrom<VisionPrescription>(hzzzzzr_);

        return hzzzzzs_;
    }


    #endregion Expressions

}

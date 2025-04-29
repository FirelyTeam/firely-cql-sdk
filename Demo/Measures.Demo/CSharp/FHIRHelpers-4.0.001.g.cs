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
[CqlLibrary("FHIRHelpers", "4.0.001")]
public partial class FHIRHelpers_4_0_001 : ILibrary, ISingleton<FHIRHelpers_4_0_001>
{
    private FHIRHelpers_4_0_001() {}

    public static FHIRHelpers_4_0_001 Instance { get; } = new();

    #region ILibrary Implementation

    public string Name => "FHIRHelpers";
    public string Version => "4.0.001";
    public ILibrary[] Dependencies => [];

    #endregion ILibrary Implementation

    #region Expressions

    [CqlExpressionDefinition("Patient")]
    public Patient Patient(CqlContext context)
    {
        IEnumerable<Patient> a_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/StructureDefinition/Patient"));
        Patient b_ = context.Operators.SingletonFrom<Patient>(a_);

        return b_;
    }


    [CqlExpressionDefinition("ToInterval")]
    public CqlInterval<CqlDateTime> ToInterval(CqlContext context, Period period)
    {
        CqlInterval<CqlDateTime> c_()
        {
            if (period is null)
            {
                return null as CqlInterval<CqlDateTime>;
            }
            else
            {
                FhirDateTime d_ = period?.StartElement;
                CqlDateTime e_ = context.Operators.Convert<CqlDateTime>(d_);
                FhirDateTime f_ = period?.EndElement;
                CqlDateTime g_ = context.Operators.Convert<CqlDateTime>(f_);
                CqlInterval<CqlDateTime> h_ = context.Operators.Interval(e_, g_, true, true);

                return h_;
            }
        };

        return c_();
    }


    [CqlExpressionDefinition("ToInterval")]
    public CqlInterval<CqlQuantity> ToInterval(CqlContext context, Range range)
    {
        CqlInterval<CqlQuantity> i_()
        {
            if (range is null)
            {
                return null as CqlInterval<CqlQuantity>;
            }
            else
            {
                Quantity j_ = range?.Low;
                CqlQuantity k_ = this.ToQuantity(context, j_);
                Quantity l_ = range?.High;
                CqlQuantity m_ = this.ToQuantity(context, l_);
                CqlInterval<CqlQuantity> n_ = context.Operators.Interval(k_, m_, true, true);

                return n_;
            }
        };

        return i_();
    }


    [CqlExpressionDefinition("ToQuantity")]
    public CqlQuantity ToQuantity(CqlContext context, Quantity quantity)
    {
        CqlQuantity o_()
        {
            if (quantity is null)
            {
                return default;
            }
            else
            {
                FhirDecimal p_ = quantity?.ValueElement;
                decimal? q_ = p_?.Value;
                FhirString r_ = quantity?.UnitElement;
                string s_ = r_?.Value;

                return new CqlQuantity(q_, s_);
            }
        };

        return o_();
    }


    [CqlExpressionDefinition("ToRatio")]
    public CqlRatio ToRatio(CqlContext context, Ratio ratio)
    {
        CqlRatio t_()
        {
            if (ratio is null)
            {
                return default;
            }
            else
            {
                Quantity u_ = ratio?.Numerator;
                CqlQuantity v_ = this.ToQuantity(context, u_);
                Quantity w_ = ratio?.Denominator;
                CqlQuantity x_ = this.ToQuantity(context, w_);

                return new CqlRatio(v_, x_);
            }
        };

        return t_();
    }


    [CqlExpressionDefinition("ToCode")]
    public CqlCode ToCode(CqlContext context, Coding coding)
    {
        CqlCode y_()
        {
            if (coding is null)
            {
                return default;
            }
            else
            {
                Code z_ = coding?.CodeElement;
                string aa_ = z_?.Value;
                FhirUri ab_ = coding?.SystemElement;
                string ac_ = ab_?.Value;
                FhirString ad_ = coding?.VersionElement;
                string ae_ = ad_?.Value;
                FhirString af_ = coding?.DisplayElement;
                string ag_ = af_?.Value;

                return new CqlCode(aa_, ac_, ae_, ag_);
            }
        };

        return y_();
    }


    [CqlExpressionDefinition("ToConcept")]
    public CqlConcept ToConcept(CqlContext context, CodeableConcept concept)
    {
        CqlConcept ah_()
        {
            if (concept is null)
            {
                return default;
            }
            else
            {
                List<Coding> ai_ = concept?.Coding;
                CqlCode aj_(Coding C)
                {
                    CqlCode ao_ = this.ToCode(context, C);

                    return ao_;
                };
                IEnumerable<CqlCode> ak_ = context.Operators.Select<Coding, CqlCode>((IEnumerable<Coding>)ai_, aj_);
                IEnumerable<CqlCode> al_ = context.Operators.Distinct<CqlCode>(ak_);
                FhirString am_ = concept?.TextElement;
                string an_ = am_?.Value;

                return new CqlConcept(al_, an_);
            }
        };

        return ah_();
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<Account.AccountStatus> value)
    {
        Account.AccountStatus? ap_ = value?.Value;
        string aq_ = context.Operators.Convert<string>(ap_);

        return aq_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<ActionCardinalityBehavior> value)
    {
        ActionCardinalityBehavior? ar_ = value?.Value;
        string as_ = context.Operators.Convert<string>(ar_);

        return as_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<ActionConditionKind> value)
    {
        ActionConditionKind? at_ = value?.Value;
        string au_ = context.Operators.Convert<string>(at_);

        return au_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<ActionGroupingBehavior> value)
    {
        ActionGroupingBehavior? av_ = value?.Value;
        string aw_ = context.Operators.Convert<string>(av_);

        return aw_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<ActionParticipantType> value)
    {
        ActionParticipantType? ax_ = value?.Value;
        string ay_ = context.Operators.Convert<string>(ax_);

        return ay_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<ActionPrecheckBehavior> value)
    {
        ActionPrecheckBehavior? az_ = value?.Value;
        string ba_ = context.Operators.Convert<string>(az_);

        return ba_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<ActionRelationshipType> value)
    {
        ActionRelationshipType? bb_ = value?.Value;
        string bc_ = context.Operators.Convert<string>(bb_);

        return bc_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<ActionRequiredBehavior> value)
    {
        ActionRequiredBehavior? bd_ = value?.Value;
        string be_ = context.Operators.Convert<string>(bd_);

        return be_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<ActionSelectionBehavior> value)
    {
        ActionSelectionBehavior? bf_ = value?.Value;
        string bg_ = context.Operators.Convert<string>(bf_);

        return bg_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<ActivityDefinition.RequestResourceType> value)
    {
        ActivityDefinition.RequestResourceType? bh_ = value?.Value;
        string bi_ = context.Operators.Convert<string>(bh_);

        return bi_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<Address.AddressType> value)
    {
        Address.AddressType? bj_ = value?.Value;
        string bk_ = context.Operators.Convert<string>(bj_);

        return bk_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<Address.AddressUse> value)
    {
        Address.AddressUse? bl_ = value?.Value;
        string bm_ = context.Operators.Convert<string>(bl_);

        return bm_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<AdministrativeGender> value)
    {
        AdministrativeGender? bn_ = value?.Value;
        string bo_ = context.Operators.Convert<string>(bn_);

        return bo_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<AdverseEvent.AdverseEventActuality> value)
    {
        AdverseEvent.AdverseEventActuality? bp_ = value?.Value;
        string bq_ = context.Operators.Convert<string>(bp_);

        return bq_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<ElementDefinition.AggregationMode> value)
    {
        ElementDefinition.AggregationMode? br_ = value?.Value;
        string bs_ = context.Operators.Convert<string>(br_);

        return bs_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<AllergyIntolerance.AllergyIntoleranceCategory> value)
    {
        AllergyIntolerance.AllergyIntoleranceCategory? bt_ = value?.Value;
        string bu_ = context.Operators.Convert<string>(bt_);

        return bu_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<AllergyIntolerance.AllergyIntoleranceCriticality> value)
    {
        AllergyIntolerance.AllergyIntoleranceCriticality? bv_ = value?.Value;
        string bw_ = context.Operators.Convert<string>(bv_);

        return bw_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<AllergyIntolerance.AllergyIntoleranceSeverity> value)
    {
        AllergyIntolerance.AllergyIntoleranceSeverity? bx_ = value?.Value;
        string by_ = context.Operators.Convert<string>(bx_);

        return by_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<AllergyIntolerance.AllergyIntoleranceType> value)
    {
        AllergyIntolerance.AllergyIntoleranceType? bz_ = value?.Value;
        string ca_ = context.Operators.Convert<string>(bz_);

        return ca_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<Appointment.AppointmentStatus> value)
    {
        Appointment.AppointmentStatus? cb_ = value?.Value;
        string cc_ = context.Operators.Convert<string>(cb_);

        return cc_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<TestScript.AssertionDirectionType> value)
    {
        TestScript.AssertionDirectionType? cd_ = value?.Value;
        string ce_ = context.Operators.Convert<string>(cd_);

        return ce_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<TestScript.AssertionOperatorType> value)
    {
        TestScript.AssertionOperatorType? cf_ = value?.Value;
        string cg_ = context.Operators.Convert<string>(cf_);

        return cg_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<TestScript.AssertionResponseTypes> value)
    {
        TestScript.AssertionResponseTypes? ch_ = value?.Value;
        string ci_ = context.Operators.Convert<string>(ch_);

        return ci_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<AuditEvent.AuditEventAction> value)
    {
        AuditEvent.AuditEventAction? cj_ = value?.Value;
        string ck_ = context.Operators.Convert<string>(cj_);

        return ck_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<AuditEvent.AuditEventAgentNetworkType> value)
    {
        AuditEvent.AuditEventAgentNetworkType? cl_ = value?.Value;
        string cm_ = context.Operators.Convert<string>(cl_);

        return cm_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<AuditEvent.AuditEventOutcome> value)
    {
        AuditEvent.AuditEventOutcome? cn_ = value?.Value;
        string co_ = context.Operators.Convert<string>(cn_);

        return co_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<BindingStrength> value)
    {
        BindingStrength? cp_ = value?.Value;
        string cq_ = context.Operators.Convert<string>(cp_);

        return cq_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<BiologicallyDerivedProduct.BiologicallyDerivedProductCategory> value)
    {
        BiologicallyDerivedProduct.BiologicallyDerivedProductCategory? cr_ = value?.Value;
        string cs_ = context.Operators.Convert<string>(cr_);

        return cs_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<BiologicallyDerivedProduct.BiologicallyDerivedProductStatus> value)
    {
        BiologicallyDerivedProduct.BiologicallyDerivedProductStatus? ct_ = value?.Value;
        string cu_ = context.Operators.Convert<string>(ct_);

        return cu_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<BiologicallyDerivedProduct.BiologicallyDerivedProductStorageScale> value)
    {
        BiologicallyDerivedProduct.BiologicallyDerivedProductStorageScale? cv_ = value?.Value;
        string cw_ = context.Operators.Convert<string>(cv_);

        return cw_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<Bundle.BundleType> value)
    {
        Bundle.BundleType? cx_ = value?.Value;
        string cy_ = context.Operators.Convert<string>(cx_);

        return cy_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<CapabilityStatementKind> value)
    {
        CapabilityStatementKind? cz_ = value?.Value;
        string da_ = context.Operators.Convert<string>(cz_);

        return da_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<CarePlan.CarePlanActivityKind> value)
    {
        CarePlan.CarePlanActivityKind? db_ = value?.Value;
        string dc_ = context.Operators.Convert<string>(db_);

        return dc_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<CarePlan.CarePlanActivityStatus> value)
    {
        CarePlan.CarePlanActivityStatus? dd_ = value?.Value;
        string de_ = context.Operators.Convert<string>(dd_);

        return de_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<CarePlan.CarePlanIntent> value)
    {
        CarePlan.CarePlanIntent? df_ = value?.Value;
        string dg_ = context.Operators.Convert<string>(df_);

        return dg_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<RequestStatus> value)
    {
        RequestStatus? dh_ = value?.Value;
        string di_ = context.Operators.Convert<string>(dh_);

        return di_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<CareTeam.CareTeamStatus> value)
    {
        CareTeam.CareTeamStatus? dj_ = value?.Value;
        string dk_ = context.Operators.Convert<string>(dj_);

        return dk_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<CatalogEntry.CatalogEntryRelationType> value)
    {
        CatalogEntry.CatalogEntryRelationType? dl_ = value?.Value;
        string dm_ = context.Operators.Convert<string>(dl_);

        return dm_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<InvoicePriceComponentType> value)
    {
        InvoicePriceComponentType? dn_ = value?.Value;
        string do_ = context.Operators.Convert<string>(dn_);

        return do_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<ChargeItem.ChargeItemStatus> value)
    {
        ChargeItem.ChargeItemStatus? dp_ = value?.Value;
        string dq_ = context.Operators.Convert<string>(dp_);

        return dq_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<FinancialResourceStatusCodes> value)
    {
        FinancialResourceStatusCodes? dr_ = value?.Value;
        string ds_ = context.Operators.Convert<string>(dr_);

        return ds_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<ClinicalImpression.ClinicalImpressionStatus> value)
    {
        ClinicalImpression.ClinicalImpressionStatus? dt_ = value?.Value;
        string du_ = context.Operators.Convert<string>(dt_);

        return du_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<TerminologyCapabilities.CodeSearchSupport> value)
    {
        TerminologyCapabilities.CodeSearchSupport? dv_ = value?.Value;
        string dw_ = context.Operators.Convert<string>(dv_);

        return dw_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<CodeSystemContentMode> value)
    {
        CodeSystemContentMode? dx_ = value?.Value;
        string dy_ = context.Operators.Convert<string>(dx_);

        return dy_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<CodeSystem.CodeSystemHierarchyMeaning> value)
    {
        CodeSystem.CodeSystemHierarchyMeaning? dz_ = value?.Value;
        string ea_ = context.Operators.Convert<string>(dz_);

        return ea_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<RequestPriority> value)
    {
        RequestPriority? eb_ = value?.Value;
        string ec_ = context.Operators.Convert<string>(eb_);

        return ec_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<EventStatus> value)
    {
        EventStatus? ed_ = value?.Value;
        string ee_ = context.Operators.Convert<string>(ed_);

        return ee_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<CompartmentType> value)
    {
        CompartmentType? ef_ = value?.Value;
        string eg_ = context.Operators.Convert<string>(ef_);

        return eg_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<Composition.CompositionAttestationMode> value)
    {
        Composition.CompositionAttestationMode? eh_ = value?.Value;
        string ei_ = context.Operators.Convert<string>(eh_);

        return ei_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<CompositionStatus> value)
    {
        CompositionStatus? ej_ = value?.Value;
        string ek_ = context.Operators.Convert<string>(ej_);

        return ek_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<ConceptMapEquivalence> value)
    {
        ConceptMapEquivalence? el_ = value?.Value;
        string em_ = context.Operators.Convert<string>(el_);

        return em_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<ConceptMap.ConceptMapGroupUnmappedMode> value)
    {
        ConceptMap.ConceptMapGroupUnmappedMode? en_ = value?.Value;
        string eo_ = context.Operators.Convert<string>(en_);

        return eo_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<CapabilityStatement.ConditionalDeleteStatus> value)
    {
        CapabilityStatement.ConditionalDeleteStatus? ep_ = value?.Value;
        string eq_ = context.Operators.Convert<string>(ep_);

        return eq_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<CapabilityStatement.ConditionalReadStatus> value)
    {
        CapabilityStatement.ConditionalReadStatus? er_ = value?.Value;
        string es_ = context.Operators.Convert<string>(er_);

        return es_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<Consent.ConsentDataMeaning> value)
    {
        Consent.ConsentDataMeaning? et_ = value?.Value;
        string eu_ = context.Operators.Convert<string>(et_);

        return eu_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<Consent.ConsentProvisionType> value)
    {
        Consent.ConsentProvisionType? ev_ = value?.Value;
        string ew_ = context.Operators.Convert<string>(ev_);

        return ew_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<Consent.ConsentState> value)
    {
        Consent.ConsentState? ex_ = value?.Value;
        string ey_ = context.Operators.Convert<string>(ex_);

        return ey_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<ConstraintSeverity> value)
    {
        ConstraintSeverity? ez_ = value?.Value;
        string fa_ = context.Operators.Convert<string>(ez_);

        return fa_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<ContactPoint.ContactPointSystem> value)
    {
        ContactPoint.ContactPointSystem? fb_ = value?.Value;
        string fc_ = context.Operators.Convert<string>(fb_);

        return fc_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<ContactPoint.ContactPointUse> value)
    {
        ContactPoint.ContactPointUse? fd_ = value?.Value;
        string fe_ = context.Operators.Convert<string>(fd_);

        return fe_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<Contract.ContractResourcePublicationStatusCodes> value)
    {
        Contract.ContractResourcePublicationStatusCodes? ff_ = value?.Value;
        string fg_ = context.Operators.Convert<string>(ff_);

        return fg_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<Contract.ContractResourceStatusCodes> value)
    {
        Contract.ContractResourceStatusCodes? fh_ = value?.Value;
        string fi_ = context.Operators.Convert<string>(fh_);

        return fi_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<Contributor.ContributorType> value)
    {
        Contributor.ContributorType? fj_ = value?.Value;
        string fk_ = context.Operators.Convert<string>(fj_);

        return fk_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<Money.Currencies> value)
    {
        Money.Currencies? fl_ = value?.Value;
        string fm_ = context.Operators.Convert<string>(fl_);

        return fm_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<DaysOfWeek> value)
    {
        DaysOfWeek? fn_ = value?.Value;
        string fo_ = context.Operators.Convert<string>(fn_);

        return fo_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<DetectedIssue.DetectedIssueSeverity> value)
    {
        DetectedIssue.DetectedIssueSeverity? fp_ = value?.Value;
        string fq_ = context.Operators.Convert<string>(fp_);

        return fq_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<ObservationStatus> value)
    {
        ObservationStatus? fr_ = value?.Value;
        string fs_ = context.Operators.Convert<string>(fr_);

        return fs_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<DeviceMetric.DeviceMetricCalibrationState> value)
    {
        DeviceMetric.DeviceMetricCalibrationState? ft_ = value?.Value;
        string fu_ = context.Operators.Convert<string>(ft_);

        return fu_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<DeviceMetric.DeviceMetricCalibrationType> value)
    {
        DeviceMetric.DeviceMetricCalibrationType? fv_ = value?.Value;
        string fw_ = context.Operators.Convert<string>(fv_);

        return fw_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<DeviceMetric.DeviceMetricCategory> value)
    {
        DeviceMetric.DeviceMetricCategory? fx_ = value?.Value;
        string fy_ = context.Operators.Convert<string>(fx_);

        return fy_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<DeviceMetric.DeviceMetricColor> value)
    {
        DeviceMetric.DeviceMetricColor? fz_ = value?.Value;
        string ga_ = context.Operators.Convert<string>(fz_);

        return ga_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<DeviceMetric.DeviceMetricOperationalStatus> value)
    {
        DeviceMetric.DeviceMetricOperationalStatus? gb_ = value?.Value;
        string gc_ = context.Operators.Convert<string>(gb_);

        return gc_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<DeviceNameType> value)
    {
        DeviceNameType? gd_ = value?.Value;
        string ge_ = context.Operators.Convert<string>(gd_);

        return ge_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<DeviceUseStatement.DeviceUseStatementStatus> value)
    {
        DeviceUseStatement.DeviceUseStatementStatus? gf_ = value?.Value;
        string gg_ = context.Operators.Convert<string>(gf_);

        return gg_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<DiagnosticReport.DiagnosticReportStatus> value)
    {
        DiagnosticReport.DiagnosticReportStatus? gh_ = value?.Value;
        string gi_ = context.Operators.Convert<string>(gh_);

        return gi_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<ElementDefinition.DiscriminatorType> value)
    {
        ElementDefinition.DiscriminatorType? gj_ = value?.Value;
        string gk_ = context.Operators.Convert<string>(gj_);

        return gk_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<Composition.V3ConfidentialityClassification> value)
    {
        Composition.V3ConfidentialityClassification? gl_ = value?.Value;
        string gm_ = context.Operators.Convert<string>(gl_);

        return gm_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<CapabilityStatement.DocumentMode> value)
    {
        CapabilityStatement.DocumentMode? gn_ = value?.Value;
        string go_ = context.Operators.Convert<string>(gn_);

        return go_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<DocumentReferenceStatus> value)
    {
        DocumentReferenceStatus? gp_ = value?.Value;
        string gq_ = context.Operators.Convert<string>(gp_);

        return gq_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<DocumentRelationshipType> value)
    {
        DocumentRelationshipType? gr_ = value?.Value;
        string gs_ = context.Operators.Convert<string>(gr_);

        return gs_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<CoverageEligibilityRequest.EligibilityRequestPurpose> value)
    {
        CoverageEligibilityRequest.EligibilityRequestPurpose? gt_ = value?.Value;
        string gu_ = context.Operators.Convert<string>(gt_);

        return gu_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<CoverageEligibilityResponse.EligibilityResponsePurpose> value)
    {
        CoverageEligibilityResponse.EligibilityResponsePurpose? gv_ = value?.Value;
        string gw_ = context.Operators.Convert<string>(gv_);

        return gw_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<Questionnaire.EnableWhenBehavior> value)
    {
        Questionnaire.EnableWhenBehavior? gx_ = value?.Value;
        string gy_ = context.Operators.Convert<string>(gx_);

        return gy_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<Encounter.EncounterLocationStatus> value)
    {
        Encounter.EncounterLocationStatus? gz_ = value?.Value;
        string ha_ = context.Operators.Convert<string>(gz_);

        return ha_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<Encounter.EncounterStatus> value)
    {
        Encounter.EncounterStatus? hb_ = value?.Value;
        string hc_ = context.Operators.Convert<string>(hb_);

        return hc_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<Endpoint.EndpointStatus> value)
    {
        Endpoint.EndpointStatus? hd_ = value?.Value;
        string he_ = context.Operators.Convert<string>(hd_);

        return he_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<EpisodeOfCare.EpisodeOfCareStatus> value)
    {
        EpisodeOfCare.EpisodeOfCareStatus? hf_ = value?.Value;
        string hg_ = context.Operators.Convert<string>(hf_);

        return hg_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<CapabilityStatement.EventCapabilityMode> value)
    {
        CapabilityStatement.EventCapabilityMode? hh_ = value?.Value;
        string hi_ = context.Operators.Convert<string>(hh_);

        return hi_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<Timing.EventTiming> value)
    {
        Timing.EventTiming? hj_ = value?.Value;
        string hk_ = context.Operators.Convert<string>(hj_);

        return hk_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<VariableTypeCode> value)
    {
        VariableTypeCode? hl_ = value?.Value;
        string hm_ = context.Operators.Convert<string>(hl_);

        return hm_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<ExampleScenario.ExampleScenarioActorType> value)
    {
        ExampleScenario.ExampleScenarioActorType? hn_ = value?.Value;
        string ho_ = context.Operators.Convert<string>(hn_);

        return ho_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<ExplanationOfBenefit.ExplanationOfBenefitStatus> value)
    {
        ExplanationOfBenefit.ExplanationOfBenefitStatus? hp_ = value?.Value;
        string hq_ = context.Operators.Convert<string>(hp_);

        return hq_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<EffectEvidenceSynthesis.ExposureStateCode> value)
    {
        EffectEvidenceSynthesis.ExposureStateCode? hr_ = value?.Value;
        string hs_ = context.Operators.Convert<string>(hr_);

        return hs_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<StructureDefinition.ExtensionContextType> value)
    {
        StructureDefinition.ExtensionContextType? ht_ = value?.Value;
        string hu_ = context.Operators.Convert<string>(ht_);

        return hu_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<FHIRAllTypes> value)
    {
        FHIRAllTypes? hv_ = value?.Value;
        string hw_ = context.Operators.Convert<string>(hv_);

        return hw_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<FHIRDefinedType> value)
    {
        FHIRDefinedType? hx_ = value?.Value;
        string hy_ = context.Operators.Convert<string>(hx_);

        return hy_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<Device.FHIRDeviceStatus> value)
    {
        Device.FHIRDeviceStatus? hz_ = value?.Value;
        string ia_ = context.Operators.Convert<string>(hz_);

        return ia_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<ResourceType> value)
    {
        ResourceType? ib_ = value?.Value;
        string ic_ = context.Operators.Convert<string>(ib_);

        return ic_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<Substance.FHIRSubstanceStatus> value)
    {
        Substance.FHIRSubstanceStatus? id_ = value?.Value;
        string ie_ = context.Operators.Convert<string>(id_);

        return ie_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<FHIRVersion> value)
    {
        FHIRVersion? if_ = value?.Value;
        string ig_ = context.Operators.Convert<string>(if_);

        return ig_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<FamilyMemberHistory.FamilyHistoryStatus> value)
    {
        FamilyMemberHistory.FamilyHistoryStatus? ih_ = value?.Value;
        string ii_ = context.Operators.Convert<string>(ih_);

        return ii_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<FilterOperator> value)
    {
        FilterOperator? ij_ = value?.Value;
        string ik_ = context.Operators.Convert<string>(ij_);

        return ik_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<Flag.FlagStatus> value)
    {
        Flag.FlagStatus? il_ = value?.Value;
        string im_ = context.Operators.Convert<string>(il_);

        return im_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<Goal.GoalLifecycleStatus> value)
    {
        Goal.GoalLifecycleStatus? in_ = value?.Value;
        string io_ = context.Operators.Convert<string>(in_);

        return io_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<GraphDefinition.GraphCompartmentRule> value)
    {
        GraphDefinition.GraphCompartmentRule? ip_ = value?.Value;
        string iq_ = context.Operators.Convert<string>(ip_);

        return iq_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<GraphDefinition.GraphCompartmentUse> value)
    {
        GraphDefinition.GraphCompartmentUse? ir_ = value?.Value;
        string is_ = context.Operators.Convert<string>(ir_);

        return is_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<GroupMeasureCode> value)
    {
        GroupMeasureCode? it_ = value?.Value;
        string iu_ = context.Operators.Convert<string>(it_);

        return iu_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<Group.GroupType> value)
    {
        Group.GroupType? iv_ = value?.Value;
        string iw_ = context.Operators.Convert<string>(iv_);

        return iw_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<GuidanceResponse.GuidanceResponseStatus> value)
    {
        GuidanceResponse.GuidanceResponseStatus? ix_ = value?.Value;
        string iy_ = context.Operators.Convert<string>(ix_);

        return iy_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<ImplementationGuide.GuidePageGeneration> value)
    {
        ImplementationGuide.GuidePageGeneration? iz_ = value?.Value;
        string ja_ = context.Operators.Convert<string>(iz_);

        return ja_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<ImplementationGuide.GuideParameterCode> value)
    {
        ImplementationGuide.GuideParameterCode? jb_ = value?.Value;
        string jc_ = context.Operators.Convert<string>(jb_);

        return jc_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<Bundle.HTTPVerb> value)
    {
        Bundle.HTTPVerb? jd_ = value?.Value;
        string je_ = context.Operators.Convert<string>(jd_);

        return je_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<Identifier.IdentifierUse> value)
    {
        Identifier.IdentifierUse? jf_ = value?.Value;
        string jg_ = context.Operators.Convert<string>(jf_);

        return jg_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<Person.IdentityAssuranceLevel> value)
    {
        Person.IdentityAssuranceLevel? jh_ = value?.Value;
        string ji_ = context.Operators.Convert<string>(jh_);

        return ji_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<ImagingStudy.ImagingStudyStatus> value)
    {
        ImagingStudy.ImagingStudyStatus? jj_ = value?.Value;
        string jk_ = context.Operators.Convert<string>(jj_);

        return jk_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<ImmunizationEvaluation.ImmunizationEvaluationStatusCodes> value)
    {
        ImmunizationEvaluation.ImmunizationEvaluationStatusCodes? jl_ = value?.Value;
        string jm_ = context.Operators.Convert<string>(jl_);

        return jm_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<Immunization.ImmunizationStatusCodes> value)
    {
        Immunization.ImmunizationStatusCodes? jn_ = value?.Value;
        string jo_ = context.Operators.Convert<string>(jn_);

        return jo_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<Invoice.InvoiceStatus> value)
    {
        Invoice.InvoiceStatus? jp_ = value?.Value;
        string jq_ = context.Operators.Convert<string>(jp_);

        return jq_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<OperationOutcome.IssueSeverity> value)
    {
        OperationOutcome.IssueSeverity? jr_ = value?.Value;
        string js_ = context.Operators.Convert<string>(jr_);

        return js_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<OperationOutcome.IssueType> value)
    {
        OperationOutcome.IssueType? jt_ = value?.Value;
        string ju_ = context.Operators.Convert<string>(jt_);

        return ju_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<Patient.LinkType> value)
    {
        Patient.LinkType? jv_ = value?.Value;
        string jw_ = context.Operators.Convert<string>(jv_);

        return jw_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<Linkage.LinkageType> value)
    {
        Linkage.LinkageType? jx_ = value?.Value;
        string jy_ = context.Operators.Convert<string>(jx_);

        return jy_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<ListMode> value)
    {
        ListMode? jz_ = value?.Value;
        string ka_ = context.Operators.Convert<string>(jz_);

        return ka_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<List.ListStatus> value)
    {
        List.ListStatus? kb_ = value?.Value;
        string kc_ = context.Operators.Convert<string>(kb_);

        return kc_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<Location.LocationMode> value)
    {
        Location.LocationMode? kd_ = value?.Value;
        string ke_ = context.Operators.Convert<string>(kd_);

        return ke_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<Location.LocationStatus> value)
    {
        Location.LocationStatus? kf_ = value?.Value;
        string kg_ = context.Operators.Convert<string>(kf_);

        return kg_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<MeasureReport.MeasureReportStatus> value)
    {
        MeasureReport.MeasureReportStatus? kh_ = value?.Value;
        string ki_ = context.Operators.Convert<string>(kh_);

        return ki_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<MeasureReport.MeasureReportType> value)
    {
        MeasureReport.MeasureReportType? kj_ = value?.Value;
        string kk_ = context.Operators.Convert<string>(kj_);

        return kk_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<MedicationAdministration.MedicationAdministrationStatusCodes> value)
    {
        MedicationAdministration.MedicationAdministrationStatusCodes? kl_ = value?.Value;
        string km_ = context.Operators.Convert<string>(kl_);

        return km_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<MedicationDispense.MedicationDispenseStatusCodes> value)
    {
        MedicationDispense.MedicationDispenseStatusCodes? kn_ = value?.Value;
        string ko_ = context.Operators.Convert<string>(kn_);

        return ko_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<MedicationKnowledge.MedicationKnowledgeStatusCodes> value)
    {
        MedicationKnowledge.MedicationKnowledgeStatusCodes? kp_ = value?.Value;
        string kq_ = context.Operators.Convert<string>(kp_);

        return kq_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<MedicationRequest.MedicationRequestIntent> value)
    {
        MedicationRequest.MedicationRequestIntent? kr_ = value?.Value;
        string ks_ = context.Operators.Convert<string>(kr_);

        return ks_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<MedicationRequest.MedicationrequestStatus> value)
    {
        MedicationRequest.MedicationrequestStatus? kt_ = value?.Value;
        string ku_ = context.Operators.Convert<string>(kt_);

        return ku_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<MedicationStatement.MedicationStatusCodes> value)
    {
        MedicationStatement.MedicationStatusCodes? kv_ = value?.Value;
        string kw_ = context.Operators.Convert<string>(kv_);

        return kw_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<Medication.MedicationStatusCodes> value)
    {
        Medication.MedicationStatusCodes? kx_ = value?.Value;
        string ky_ = context.Operators.Convert<string>(kx_);

        return ky_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<MessageDefinition.MessageSignificanceCategory> value)
    {
        MessageDefinition.MessageSignificanceCategory? kz_ = value?.Value;
        string la_ = context.Operators.Convert<string>(kz_);

        return la_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<MessageheaderResponseRequest> value)
    {
        MessageheaderResponseRequest? lb_ = value?.Value;
        string lc_ = context.Operators.Convert<string>(lb_);

        return lc_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code value)
    {
        string ld_ = value?.Value;

        return ld_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<HumanName.NameUse> value)
    {
        HumanName.NameUse? le_ = value?.Value;
        string lf_ = context.Operators.Convert<string>(le_);

        return lf_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<NamingSystem.NamingSystemIdentifierType> value)
    {
        NamingSystem.NamingSystemIdentifierType? lg_ = value?.Value;
        string lh_ = context.Operators.Convert<string>(lg_);

        return lh_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<NamingSystem.NamingSystemType> value)
    {
        NamingSystem.NamingSystemType? li_ = value?.Value;
        string lj_ = context.Operators.Convert<string>(li_);

        return lj_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<Narrative.NarrativeStatus> value)
    {
        Narrative.NarrativeStatus? lk_ = value?.Value;
        string ll_ = context.Operators.Convert<string>(lk_);

        return ll_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<NoteType> value)
    {
        NoteType? lm_ = value?.Value;
        string ln_ = context.Operators.Convert<string>(lm_);

        return ln_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<RequestIntent> value)
    {
        RequestIntent? lo_ = value?.Value;
        string lp_ = context.Operators.Convert<string>(lo_);

        return lp_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<ObservationDefinition.ObservationDataType> value)
    {
        ObservationDefinition.ObservationDataType? lq_ = value?.Value;
        string lr_ = context.Operators.Convert<string>(lq_);

        return lr_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<ObservationDefinition.ObservationRangeCategory> value)
    {
        ObservationDefinition.ObservationRangeCategory? ls_ = value?.Value;
        string lt_ = context.Operators.Convert<string>(ls_);

        return lt_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<OperationDefinition.OperationKind> value)
    {
        OperationDefinition.OperationKind? lu_ = value?.Value;
        string lv_ = context.Operators.Convert<string>(lu_);

        return lv_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<OperationParameterUse> value)
    {
        OperationParameterUse? lw_ = value?.Value;
        string lx_ = context.Operators.Convert<string>(lw_);

        return lx_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<MolecularSequence.OrientationType> value)
    {
        MolecularSequence.OrientationType? ly_ = value?.Value;
        string lz_ = context.Operators.Convert<string>(ly_);

        return lz_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<Appointment.ParticipantRequired> value)
    {
        Appointment.ParticipantRequired? ma_ = value?.Value;
        string mb_ = context.Operators.Convert<string>(ma_);

        return mb_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<ParticipationStatus> value)
    {
        ParticipationStatus? mc_ = value?.Value;
        string md_ = context.Operators.Convert<string>(mc_);

        return md_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<ElementDefinition.PropertyRepresentation> value)
    {
        ElementDefinition.PropertyRepresentation? me_ = value?.Value;
        string mf_ = context.Operators.Convert<string>(me_);

        return mf_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<CodeSystem.PropertyType> value)
    {
        CodeSystem.PropertyType? mg_ = value?.Value;
        string mh_ = context.Operators.Convert<string>(mg_);

        return mh_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<Provenance.ProvenanceEntityRole> value)
    {
        Provenance.ProvenanceEntityRole? mi_ = value?.Value;
        string mj_ = context.Operators.Convert<string>(mi_);

        return mj_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<PublicationStatus> value)
    {
        PublicationStatus? mk_ = value?.Value;
        string ml_ = context.Operators.Convert<string>(mk_);

        return ml_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<MolecularSequence.QualityType> value)
    {
        MolecularSequence.QualityType? mm_ = value?.Value;
        string mn_ = context.Operators.Convert<string>(mm_);

        return mn_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<Quantity.QuantityComparator> value)
    {
        Quantity.QuantityComparator? mo_ = value?.Value;
        string mp_ = context.Operators.Convert<string>(mo_);

        return mp_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<Questionnaire.QuestionnaireItemOperator> value)
    {
        Questionnaire.QuestionnaireItemOperator? mq_ = value?.Value;
        string mr_ = context.Operators.Convert<string>(mq_);

        return mr_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<Questionnaire.QuestionnaireItemType> value)
    {
        Questionnaire.QuestionnaireItemType? ms_ = value?.Value;
        string mt_ = context.Operators.Convert<string>(ms_);

        return mt_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<QuestionnaireResponse.QuestionnaireResponseStatus> value)
    {
        QuestionnaireResponse.QuestionnaireResponseStatus? mu_ = value?.Value;
        string mv_ = context.Operators.Convert<string>(mu_);

        return mv_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<CapabilityStatement.ReferenceHandlingPolicy> value)
    {
        CapabilityStatement.ReferenceHandlingPolicy? mw_ = value?.Value;
        string mx_ = context.Operators.Convert<string>(mw_);

        return mx_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<ElementDefinition.ReferenceVersionRules> value)
    {
        ElementDefinition.ReferenceVersionRules? my_ = value?.Value;
        string mz_ = context.Operators.Convert<string>(my_);

        return mz_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<RelatedArtifact.RelatedArtifactType> value)
    {
        RelatedArtifact.RelatedArtifactType? na_ = value?.Value;
        string nb_ = context.Operators.Convert<string>(na_);

        return nb_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<ClaimProcessingCodes> value)
    {
        ClaimProcessingCodes? nc_ = value?.Value;
        string nd_ = context.Operators.Convert<string>(nc_);

        return nd_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<MolecularSequence.RepositoryType> value)
    {
        MolecularSequence.RepositoryType? ne_ = value?.Value;
        string nf_ = context.Operators.Convert<string>(ne_);

        return nf_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<ResearchElementDefinition.ResearchElementType> value)
    {
        ResearchElementDefinition.ResearchElementType? ng_ = value?.Value;
        string nh_ = context.Operators.Convert<string>(ng_);

        return nh_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<ResearchStudy.ResearchStudyStatus> value)
    {
        ResearchStudy.ResearchStudyStatus? ni_ = value?.Value;
        string nj_ = context.Operators.Convert<string>(ni_);

        return nj_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<ResearchSubject.ResearchSubjectStatus> value)
    {
        ResearchSubject.ResearchSubjectStatus? nk_ = value?.Value;
        string nl_ = context.Operators.Convert<string>(nk_);

        return nl_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<CapabilityStatement.ResourceVersionPolicy> value)
    {
        CapabilityStatement.ResourceVersionPolicy? nm_ = value?.Value;
        string nn_ = context.Operators.Convert<string>(nm_);

        return nn_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<MessageHeader.ResponseType> value)
    {
        MessageHeader.ResponseType? no_ = value?.Value;
        string np_ = context.Operators.Convert<string>(no_);

        return np_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<CapabilityStatement.RestfulCapabilityMode> value)
    {
        CapabilityStatement.RestfulCapabilityMode? nq_ = value?.Value;
        string nr_ = context.Operators.Convert<string>(nq_);

        return nr_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<ImplementationGuide.SPDXLicense> value)
    {
        ImplementationGuide.SPDXLicense? ns_ = value?.Value;
        string nt_ = context.Operators.Convert<string>(ns_);

        return nt_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<SearchParameter.SearchComparator> value)
    {
        SearchParameter.SearchComparator? nu_ = value?.Value;
        string nv_ = context.Operators.Convert<string>(nu_);

        return nv_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<Bundle.SearchEntryMode> value)
    {
        Bundle.SearchEntryMode? nw_ = value?.Value;
        string nx_ = context.Operators.Convert<string>(nw_);

        return nx_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<SearchParameter.SearchModifierCode> value)
    {
        SearchParameter.SearchModifierCode? ny_ = value?.Value;
        string nz_ = context.Operators.Convert<string>(ny_);

        return nz_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<SearchParamType> value)
    {
        SearchParamType? oa_ = value?.Value;
        string ob_ = context.Operators.Convert<string>(oa_);

        return ob_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<MolecularSequence.SequenceType> value)
    {
        MolecularSequence.SequenceType? oc_ = value?.Value;
        string od_ = context.Operators.Convert<string>(oc_);

        return od_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<ElementDefinition.SlicingRules> value)
    {
        ElementDefinition.SlicingRules? oe_ = value?.Value;
        string of_ = context.Operators.Convert<string>(oe_);

        return of_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<Slot.SlotStatus> value)
    {
        Slot.SlotStatus? og_ = value?.Value;
        string oh_ = context.Operators.Convert<string>(og_);

        return oh_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<DataRequirement.SortDirection> value)
    {
        DataRequirement.SortDirection? oi_ = value?.Value;
        string oj_ = context.Operators.Convert<string>(oi_);

        return oj_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<SpecimenDefinition.SpecimenContainedPreference> value)
    {
        SpecimenDefinition.SpecimenContainedPreference? ok_ = value?.Value;
        string ol_ = context.Operators.Convert<string>(ok_);

        return ol_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<Specimen.SpecimenStatus> value)
    {
        Specimen.SpecimenStatus? om_ = value?.Value;
        string on_ = context.Operators.Convert<string>(om_);

        return on_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<VerificationResult.StatusCode> value)
    {
        VerificationResult.StatusCode? oo_ = value?.Value;
        string op_ = context.Operators.Convert<string>(oo_);

        return op_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<MolecularSequence.StrandType> value)
    {
        MolecularSequence.StrandType? oq_ = value?.Value;
        string or_ = context.Operators.Convert<string>(oq_);

        return or_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<StructureDefinition.StructureDefinitionKind> value)
    {
        StructureDefinition.StructureDefinitionKind? os_ = value?.Value;
        string ot_ = context.Operators.Convert<string>(os_);

        return ot_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<StructureMap.StructureMapContextType> value)
    {
        StructureMap.StructureMapContextType? ou_ = value?.Value;
        string ov_ = context.Operators.Convert<string>(ou_);

        return ov_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<StructureMap.StructureMapGroupTypeMode> value)
    {
        StructureMap.StructureMapGroupTypeMode? ow_ = value?.Value;
        string ox_ = context.Operators.Convert<string>(ow_);

        return ox_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<StructureMap.StructureMapInputMode> value)
    {
        StructureMap.StructureMapInputMode? oy_ = value?.Value;
        string oz_ = context.Operators.Convert<string>(oy_);

        return oz_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<StructureMap.StructureMapModelMode> value)
    {
        StructureMap.StructureMapModelMode? pa_ = value?.Value;
        string pb_ = context.Operators.Convert<string>(pa_);

        return pb_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<StructureMap.StructureMapSourceListMode> value)
    {
        StructureMap.StructureMapSourceListMode? pc_ = value?.Value;
        string pd_ = context.Operators.Convert<string>(pc_);

        return pd_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<StructureMap.StructureMapTargetListMode> value)
    {
        StructureMap.StructureMapTargetListMode? pe_ = value?.Value;
        string pf_ = context.Operators.Convert<string>(pe_);

        return pf_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<StructureMap.StructureMapTransform> value)
    {
        StructureMap.StructureMapTransform? pg_ = value?.Value;
        string ph_ = context.Operators.Convert<string>(pg_);

        return ph_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<Subscription.SubscriptionChannelType> value)
    {
        Subscription.SubscriptionChannelType? pi_ = value?.Value;
        string pj_ = context.Operators.Convert<string>(pi_);

        return pj_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<Subscription.SubscriptionStatus> value)
    {
        Subscription.SubscriptionStatus? pk_ = value?.Value;
        string pl_ = context.Operators.Convert<string>(pk_);

        return pl_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<SupplyDelivery.SupplyDeliveryStatus> value)
    {
        SupplyDelivery.SupplyDeliveryStatus? pm_ = value?.Value;
        string pn_ = context.Operators.Convert<string>(pm_);

        return pn_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<SupplyRequest.SupplyRequestStatus> value)
    {
        SupplyRequest.SupplyRequestStatus? po_ = value?.Value;
        string pp_ = context.Operators.Convert<string>(po_);

        return pp_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<CapabilityStatement.SystemRestfulInteraction> value)
    {
        CapabilityStatement.SystemRestfulInteraction? pq_ = value?.Value;
        string pr_ = context.Operators.Convert<string>(pq_);

        return pr_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<Task.TaskIntent> value)
    {
        Task.TaskIntent? ps_ = value?.Value;
        string pt_ = context.Operators.Convert<string>(ps_);

        return pt_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<Task.TaskStatus> value)
    {
        Task.TaskStatus? pu_ = value?.Value;
        string pv_ = context.Operators.Convert<string>(pu_);

        return pv_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<TestReport.TestReportActionResult> value)
    {
        TestReport.TestReportActionResult? pw_ = value?.Value;
        string px_ = context.Operators.Convert<string>(pw_);

        return px_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<TestReport.TestReportParticipantType> value)
    {
        TestReport.TestReportParticipantType? py_ = value?.Value;
        string pz_ = context.Operators.Convert<string>(py_);

        return pz_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<TestReport.TestReportResult> value)
    {
        TestReport.TestReportResult? qa_ = value?.Value;
        string qb_ = context.Operators.Convert<string>(qa_);

        return qb_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<TestReport.TestReportStatus> value)
    {
        TestReport.TestReportStatus? qc_ = value?.Value;
        string qd_ = context.Operators.Convert<string>(qc_);

        return qd_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<TestScript.TestScriptRequestMethodCode> value)
    {
        TestScript.TestScriptRequestMethodCode? qe_ = value?.Value;
        string qf_ = context.Operators.Convert<string>(qe_);

        return qf_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<TriggerDefinition.TriggerType> value)
    {
        TriggerDefinition.TriggerType? qg_ = value?.Value;
        string qh_ = context.Operators.Convert<string>(qg_);

        return qh_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<StructureDefinition.TypeDerivationRule> value)
    {
        StructureDefinition.TypeDerivationRule? qi_ = value?.Value;
        string qj_ = context.Operators.Convert<string>(qi_);

        return qj_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<CapabilityStatement.TypeRestfulInteraction> value)
    {
        CapabilityStatement.TypeRestfulInteraction? qk_ = value?.Value;
        string ql_ = context.Operators.Convert<string>(qk_);

        return ql_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<Device.UDIEntryType> value)
    {
        Device.UDIEntryType? qm_ = value?.Value;
        string qn_ = context.Operators.Convert<string>(qm_);

        return qn_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<Timing.UnitsOfTime> value)
    {
        Timing.UnitsOfTime? qo_ = value?.Value;
        string qp_ = context.Operators.Convert<string>(qo_);

        return qp_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<ClaimUseCode> value)
    {
        ClaimUseCode? qq_ = value?.Value;
        string qr_ = context.Operators.Convert<string>(qq_);

        return qr_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<VisionPrescription.VisionBase> value)
    {
        VisionPrescription.VisionBase? qs_ = value?.Value;
        string qt_ = context.Operators.Convert<string>(qs_);

        return qt_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<VisionPrescription.VisionEyes> value)
    {
        VisionPrescription.VisionEyes? qu_ = value?.Value;
        string qv_ = context.Operators.Convert<string>(qu_);

        return qv_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<SearchParameter.XPathUsageType> value)
    {
        SearchParameter.XPathUsageType? qw_ = value?.Value;
        string qx_ = context.Operators.Convert<string>(qw_);

        return qx_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Base64Binary value)
    {
        byte[] qy_ = value?.Value;
        string qz_ = context.Operators.Convert<string>(qy_);

        return qz_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Id value)
    {
        string ra_ = value?.Value;

        return ra_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, FhirString value)
    {
        string rb_ = value?.Value;

        return rb_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, FhirUri value)
    {
        string rc_ = value?.Value;

        return rc_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, XHtml value)
    {
        string rd_ = value?.Value;

        return rd_;
    }


    [CqlExpressionDefinition("ToBoolean")]
    public bool? ToBoolean(CqlContext context, FhirBoolean value)
    {
        bool? re_ = value?.Value;

        return re_;
    }


    [CqlExpressionDefinition("ToDate")]
    public CqlDate ToDate(CqlContext context, Date value)
    {
        string rf_ = value?.Value;
        CqlDate rg_ = context.Operators.ConvertStringToDate(rf_);

        return rg_;
    }


    [CqlExpressionDefinition("ToDateTime")]
    public CqlDateTime ToDateTime(CqlContext context, FhirDateTime value)
    {
        CqlDateTime rh_ = context.Operators.Convert<CqlDateTime>(value);

        return rh_;
    }


    [CqlExpressionDefinition("ToDateTime")]
    public CqlDateTime ToDateTime(CqlContext context, Instant value)
    {
        DateTimeOffset? ri_ = value?.Value;
        CqlDateTime rj_ = context.Operators.Convert<CqlDateTime>(ri_);

        return rj_;
    }


    [CqlExpressionDefinition("ToDecimal")]
    public decimal? ToDecimal(CqlContext context, FhirDecimal value)
    {
        decimal? rk_ = value?.Value;

        return rk_;
    }


    [CqlExpressionDefinition("ToInteger")]
    public int? ToInteger(CqlContext context, Integer value)
    {
        int? rl_ = value?.Value;

        return rl_;
    }


    [CqlExpressionDefinition("ToTime")]
    public CqlTime ToTime(CqlContext context, Time value)
    {
        string rm_ = value?.Value;
        CqlTime rn_ = context.Operators.ConvertStringToTime(rm_);

        return rn_;
    }


    #endregion Expressions

}

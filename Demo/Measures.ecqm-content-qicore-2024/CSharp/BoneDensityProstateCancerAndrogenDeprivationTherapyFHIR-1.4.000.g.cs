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

[System.CodeDom.Compiler.GeneratedCode(".NET Code Generation", "3.1.0.0")]
[CqlLibrary("BoneDensityProstateCancerAndrogenDeprivationTherapyFHIR", "1.4.000")]
public partial class BoneDensityProstateCancerAndrogenDeprivationTherapyFHIR_1_4_000 : ILibrary, ISingleton<BoneDensityProstateCancerAndrogenDeprivationTherapyFHIR_1_4_000>
{
    private BoneDensityProstateCancerAndrogenDeprivationTherapyFHIR_1_4_000() {}

    public static BoneDensityProstateCancerAndrogenDeprivationTherapyFHIR_1_4_000 Instance { get; } = new();

    #region ILibrary Implementation

    public string Name => "BoneDensityProstateCancerAndrogenDeprivationTherapyFHIR";
    public string Version => "1.4.000";
    public ILibrary[] Dependencies => [FHIRHelpers_4_4_000.Instance, SupplementalDataElements_3_5_000.Instance, QICoreCommon_2_1_000.Instance];

    #endregion ILibrary Implementation

    #region ValueSets

    [CqlValueSetDefinition("Androgen deprivation therapy for Urology Care", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1151.48", valueSetVersion: null)]
    public CqlValueSet Androgen_deprivation_therapy_for_Urology_Care(CqlContext _) => _Androgen_deprivation_therapy_for_Urology_Care;
    private static readonly CqlValueSet _Androgen_deprivation_therapy_for_Urology_Care = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1151.48", null);

    [CqlValueSetDefinition("DEXA Dual Energy Xray Absorptiometry, Bone Density for Urology Care", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1151.38", valueSetVersion: null)]
    public CqlValueSet DEXA_Dual_Energy_Xray_Absorptiometry__Bone_Density_for_Urology_Care(CqlContext _) => _DEXA_Dual_Energy_Xray_Absorptiometry__Bone_Density_for_Urology_Care;
    private static readonly CqlValueSet _DEXA_Dual_Energy_Xray_Absorptiometry__Bone_Density_for_Urology_Care = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1151.38", null);

    [CqlValueSetDefinition("Office Visit", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1001", valueSetVersion: null)]
    public CqlValueSet Office_Visit(CqlContext _) => _Office_Visit;
    private static readonly CqlValueSet _Office_Visit = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1001", null);

    [CqlValueSetDefinition("Patient Declined", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1582", valueSetVersion: null)]
    public CqlValueSet Patient_Declined(CqlContext _) => _Patient_Declined;
    private static readonly CqlValueSet _Patient_Declined = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1582", null);

    [CqlValueSetDefinition("Prostate Cancer", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.319", valueSetVersion: null)]
    public CqlValueSet Prostate_Cancer(CqlContext _) => _Prostate_Cancer;
    private static readonly CqlValueSet _Prostate_Cancer = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.319", null);

    #endregion ValueSets

    #region Codes

    [CqlCodeDefinition("Injection of leuprolide acetate for twelve month period (regime/therapy)", codeId: "456381000124102", codeSystem: "http://snomed.info/sct")]
    public CqlCode Injection_of_leuprolide_acetate_for_twelve_month_period__regime_therapy_(CqlContext _) => _Injection_of_leuprolide_acetate_for_twelve_month_period__regime_therapy_;
    private static readonly CqlCode _Injection_of_leuprolide_acetate_for_twelve_month_period__regime_therapy_ = new CqlCode("456381000124102", "http://snomed.info/sct");

    #endregion Codes

    #region CodeSystems

    [CqlCodeSystemDefinition("SNOMEDCT", codeSystemId: "http://snomed.info/sct", codeSystemVersion: null)]
    public CqlCodeSystem SNOMEDCT(CqlContext _) => _SNOMEDCT;
    private static readonly CqlCodeSystem _SNOMEDCT =
      new CqlCodeSystem("http://snomed.info/sct", null, [
          _Injection_of_leuprolide_acetate_for_twelve_month_period__regime_therapy_]);

    #endregion CodeSystems

    #region Parameters

    [CqlParameterDefinition("Measurement Period")]
    public CqlInterval<CqlDateTime> Measurement_Period(CqlContext context)
    {
        CqlDateTime a_ = context.Operators.DateTime(2025, 1, 1, 0, 0, 0, 0, 0.0m);
        CqlDateTime b_ = context.Operators.DateTime(2025, 12, 31, 23, 59, 59, 999, 0.0m);
        CqlInterval<CqlDateTime> c_ = context.Operators.Interval(a_, b_, true, true);
        object d_ = context.ResolveParameter("BoneDensityProstateCancerAndrogenDeprivationTherapyFHIR-1.4.000", "Measurement Period", c_);

        return (CqlInterval<CqlDateTime>)d_;
    }


    #endregion Parameters

    #region Functions and Expressions

    [CqlExpressionDefinition("Patient")]
    public Patient Patient(CqlContext context)
    {
        IEnumerable<Patient> a_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-patient"));
        Patient b_ = context.Operators.SingletonFrom<Patient>(a_);

        return b_;
    }


    [CqlExpressionDefinition("Has Qualifying Encounter")]
    public bool? Has_Qualifying_Encounter(CqlContext context)
    {
        CqlValueSet a_ = this.Office_Visit(context);
        IEnumerable<Encounter> b_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        bool? c_(Encounter OfficeVisit)
        {
            CqlInterval<CqlDateTime> f_ = this.Measurement_Period(context);
            Period g_ = OfficeVisit?.Period;
            CqlInterval<CqlDateTime> h_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, g_);
            bool? i_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(f_, h_, default);
            Code<Encounter.EncounterStatus> j_ = OfficeVisit?.StatusElement;
            Encounter.EncounterStatus? k_ = j_?.Value;
            Code<Encounter.EncounterStatus> l_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(k_);
            bool? m_ = context.Operators.Equal(l_, "finished");
            bool? n_ = context.Operators.And(i_, m_);

            return n_;
        };
        IEnumerable<Encounter> d_ = context.Operators.Where<Encounter>(b_, c_);
        bool? e_ = context.Operators.Exists<Encounter>(d_);

        return e_;
    }


    [CqlFunctionDefinition("NormalizeInterval")]
    public CqlInterval<CqlDateTime> NormalizeInterval(CqlContext context, CqlDateTime pointInTime, CqlInterval<CqlDateTime> dateTimeInterval)
    {
        CqlInterval<CqlDateTime> a_()
        {
            if ((context.Operators.Not((bool?)(pointInTime is null))) ?? false)
            {
                CqlInterval<CqlDateTime> b_ = context.Operators.Interval(pointInTime, pointInTime, true, true);

                return b_;
            }
            else if ((context.Operators.Not((bool?)(dateTimeInterval is null))) ?? false)
            {
                return dateTimeInterval;
            }
            else
            {
                return null as CqlInterval<CqlDateTime>;
            }
        };

        return a_();
    }


    [CqlExpressionDefinition("Androgen Deprivation Therapy for Urology Care Medication Active Start Dates")]
    public IEnumerable<CqlDateTime> Androgen_Deprivation_Therapy_for_Urology_Care_Medication_Active_Start_Dates(CqlContext context)
    {
        CqlValueSet a_ = this.Androgen_deprivation_therapy_for_Urology_Care(context);
        IEnumerable<MedicationRequest> b_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> c_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> d_(MedicationRequest MR)
        {
            IEnumerable<Medication> l_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));
            bool? m_(Medication M)
            {
                object q_ = context.Operators.LateBoundProperty<object>(M, "id.value");
                object r_ = context.Operators.LateBoundProperty<object>(MR, "medication.reference.value");
                IEnumerable<string> s_ = context.Operators.Split((string)r_, "/");
                string t_ = context.Operators.Last<string>(s_);
                bool? u_ = context.Operators.Equal(q_, t_);
                CodeableConcept v_ = M?.Code;
                CqlConcept w_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, v_);
                CqlValueSet x_ = this.Androgen_deprivation_therapy_for_Urology_Care(context);
                bool? y_ = context.Operators.ConceptInValueSet(w_, x_);
                bool? z_ = context.Operators.And(u_, y_);

                return z_;
            };
            IEnumerable<Medication> n_ = context.Operators.Where<Medication>(l_, m_);
            MedicationRequest o_(Medication M) =>
                MR;
            IEnumerable<MedicationRequest> p_ = context.Operators.Select<Medication, MedicationRequest>(n_, o_);

            return p_;
        };
        IEnumerable<MedicationRequest> e_ = context.Operators.SelectMany<MedicationRequest, MedicationRequest>(c_, d_);
        IEnumerable<MedicationRequest> f_ = context.Operators.Union<MedicationRequest>(b_, e_);
        bool? g_(MedicationRequest ADTActive)
        {
            Code<MedicationRequest.MedicationrequestStatus> aa_ = ADTActive?.StatusElement;
            MedicationRequest.MedicationrequestStatus? ab_ = aa_?.Value;
            string ac_ = context.Operators.Convert<string>(ab_);
            string[] ad_ = [
                "active",
                "completed",
            ];
            bool? ae_ = context.Operators.In<string>(ac_, (IEnumerable<string>)ad_);
            Code<MedicationRequest.MedicationRequestIntent> af_ = ADTActive?.IntentElement;
            MedicationRequest.MedicationRequestIntent? ag_ = af_?.Value;
            string ah_ = context.Operators.Convert<string>(ag_);
            string[] ai_ = [
                "order",
                "original-order",
                "reflex-order",
                "filler-order",
                "instance-order",
            ];
            bool? aj_ = context.Operators.In<string>(ah_, (IEnumerable<string>)ai_);
            bool? ak_ = context.Operators.And(ae_, aj_);

            return ak_;
        };
        IEnumerable<MedicationRequest> h_ = context.Operators.Where<MedicationRequest>(f_, g_);
        CqlDateTime i_(MedicationRequest ADTActive)
        {
            List<Dosage> al_ = ADTActive?.DosageInstruction;
            bool? am_(Dosage @this)
            {
                Timing br_ = @this?.Timing;
                bool? bs_ = context.Operators.Not((bool?)(br_ is null));

                return bs_;
            };
            IEnumerable<Dosage> an_ = context.Operators.Where<Dosage>((IEnumerable<Dosage>)al_, am_);
            Timing ao_(Dosage @this)
            {
                Timing bt_ = @this?.Timing;

                return bt_;
            };
            IEnumerable<Timing> ap_ = context.Operators.Select<Dosage, Timing>(an_, ao_);
            CqlDateTime aq_(Timing dosageTiming)
            {
                List<FhirDateTime> bu_ = dosageTiming?.EventElement;
                string bv_(FhirDateTime @this)
                {
                    string cb_ = @this?.Value;

                    return cb_;
                };
                IEnumerable<string> bw_ = context.Operators.Select<FhirDateTime, string>((IEnumerable<FhirDateTime>)bu_, bv_);
                CqlDateTime bx_(string @string)
                {
                    CqlDateTime cc_ = context.Operators.ConvertStringToDateTime(@string);

                    return cc_;
                };
                IEnumerable<CqlDateTime> by_ = context.Operators.Select<string, CqlDateTime>(bw_, bx_);
                IEnumerable<CqlDateTime> bz_ = context.Operators.ListSort<CqlDateTime>(by_, System.ComponentModel.ListSortDirection.Ascending);
                CqlDateTime ca_ = context.Operators.First<CqlDateTime>(bz_);

                return ca_;
            };
            IEnumerable<CqlDateTime> ar_ = context.Operators.Select<Timing, CqlDateTime>(ap_, aq_);
            IEnumerable<CqlDateTime> as_ = context.Operators.Distinct<CqlDateTime>(ar_);
            IEnumerable<CqlDateTime> at_ = context.Operators.ListSort<CqlDateTime>(as_, System.ComponentModel.ListSortDirection.Ascending);
            CqlDateTime au_ = context.Operators.First<CqlDateTime>(at_);
            bool? aw_(Dosage @this)
            {
                Timing cd_ = @this?.Timing;
                bool? ce_ = context.Operators.Not((bool?)(cd_ is null));

                return ce_;
            };
            IEnumerable<Dosage> ax_ = context.Operators.Where<Dosage>((IEnumerable<Dosage>)al_, aw_);
            Timing ay_(Dosage @this)
            {
                Timing cf_ = @this?.Timing;

                return cf_;
            };
            IEnumerable<Timing> az_ = context.Operators.Select<Dosage, Timing>(ax_, ay_);
            bool? ba_(Timing @this)
            {
                Timing.RepeatComponent cg_ = @this?.Repeat;
                bool? ch_ = context.Operators.Not((bool?)(cg_ is null));

                return ch_;
            };
            IEnumerable<Timing> bb_ = context.Operators.Where<Timing>(az_, ba_);
            Timing.RepeatComponent bc_(Timing @this)
            {
                Timing.RepeatComponent ci_ = @this?.Repeat;

                return ci_;
            };
            IEnumerable<Timing.RepeatComponent> bd_ = context.Operators.Select<Timing, Timing.RepeatComponent>(bb_, bc_);
            bool? be_(Timing.RepeatComponent @this)
            {
                DataType cj_ = @this?.Bounds;
                object ck_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cj_);
                bool? cl_ = context.Operators.Not((bool?)(ck_ is null));

                return cl_;
            };
            IEnumerable<Timing.RepeatComponent> bf_ = context.Operators.Where<Timing.RepeatComponent>(bd_, be_);
            object bg_(Timing.RepeatComponent @this)
            {
                DataType cm_ = @this?.Bounds;
                object cn_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cm_);

                return cn_;
            };
            IEnumerable<object> bh_ = context.Operators.Select<Timing.RepeatComponent, object>(bf_, bg_);
            CqlInterval<CqlDateTime> bi_(object DoseTime)
            {
                CqlInterval<CqlDateTime> co_ = QICoreCommon_2_1_000.Instance.toInterval(context, DoseTime);

                return co_;
            };
            IEnumerable<CqlInterval<CqlDateTime>> bj_ = context.Operators.Select<object, CqlInterval<CqlDateTime>>(bh_, bi_);
            IEnumerable<CqlInterval<CqlDateTime>> bk_ = context.Operators.Distinct<CqlInterval<CqlDateTime>>(bj_);
            IEnumerable<CqlInterval<CqlDateTime>> bl_ = context.Operators.Collapse(bk_, default);
            object bm_(CqlInterval<CqlDateTime> @this)
            {
                CqlDateTime cp_ = context.Operators.Start(@this);

                return cp_;
            };
            IEnumerable<CqlInterval<CqlDateTime>> bn_ = context.Operators.SortBy<CqlInterval<CqlDateTime>>(bl_, bm_, System.ComponentModel.ListSortDirection.Ascending);
            CqlInterval<CqlDateTime> bo_ = context.Operators.First<CqlInterval<CqlDateTime>>(bn_);
            CqlInterval<CqlDateTime> bp_ = this.NormalizeInterval(context, au_, bo_);
            CqlDateTime bq_ = QICoreCommon_2_1_000.Instance.earliest(context, bp_ as object);

            return bq_;
        };
        IEnumerable<CqlDateTime> j_ = context.Operators.Select<MedicationRequest, CqlDateTime>(h_, i_);
        IEnumerable<CqlDateTime> k_ = context.Operators.Distinct<CqlDateTime>(j_);

        return k_;
    }


    [CqlExpressionDefinition("Androgen Deprivation Therapy for Urology Care Medication Order Start Dates")]
    public IEnumerable<CqlDateTime> Androgen_Deprivation_Therapy_for_Urology_Care_Medication_Order_Start_Dates(CqlContext context)
    {
        CqlValueSet a_ = this.Androgen_deprivation_therapy_for_Urology_Care(context);
        IEnumerable<MedicationRequest> b_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> c_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> d_(MedicationRequest MR)
        {
            IEnumerable<Medication> l_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));
            bool? m_(Medication M)
            {
                object q_ = context.Operators.LateBoundProperty<object>(M, "id.value");
                object r_ = context.Operators.LateBoundProperty<object>(MR, "medication.reference.value");
                IEnumerable<string> s_ = context.Operators.Split((string)r_, "/");
                string t_ = context.Operators.Last<string>(s_);
                bool? u_ = context.Operators.Equal(q_, t_);
                CodeableConcept v_ = M?.Code;
                CqlConcept w_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, v_);
                CqlValueSet x_ = this.Androgen_deprivation_therapy_for_Urology_Care(context);
                bool? y_ = context.Operators.ConceptInValueSet(w_, x_);
                bool? z_ = context.Operators.And(u_, y_);

                return z_;
            };
            IEnumerable<Medication> n_ = context.Operators.Where<Medication>(l_, m_);
            MedicationRequest o_(Medication M) =>
                MR;
            IEnumerable<MedicationRequest> p_ = context.Operators.Select<Medication, MedicationRequest>(n_, o_);

            return p_;
        };
        IEnumerable<MedicationRequest> e_ = context.Operators.SelectMany<MedicationRequest, MedicationRequest>(c_, d_);
        IEnumerable<MedicationRequest> f_ = context.Operators.Union<MedicationRequest>(b_, e_);
        bool? g_(MedicationRequest ADTOrder)
        {
            Code<MedicationRequest.MedicationrequestStatus> aa_ = ADTOrder?.StatusElement;
            MedicationRequest.MedicationrequestStatus? ab_ = aa_?.Value;
            string ac_ = context.Operators.Convert<string>(ab_);
            string[] ad_ = [
                "active",
                "completed",
            ];
            bool? ae_ = context.Operators.In<string>(ac_, (IEnumerable<string>)ad_);
            Code<MedicationRequest.MedicationRequestIntent> af_ = ADTOrder?.IntentElement;
            MedicationRequest.MedicationRequestIntent? ag_ = af_?.Value;
            string ah_ = context.Operators.Convert<string>(ag_);
            string[] ai_ = [
                "order",
                "original-order",
                "reflex-order",
                "filler-order",
                "instance-order",
            ];
            bool? aj_ = context.Operators.In<string>(ah_, (IEnumerable<string>)ai_);
            bool? ak_ = context.Operators.And(ae_, aj_);

            return ak_;
        };
        IEnumerable<MedicationRequest> h_ = context.Operators.Where<MedicationRequest>(f_, g_);
        CqlDateTime i_(MedicationRequest ADTOrder)
        {
            FhirDateTime al_ = ADTOrder?.AuthoredOnElement;
            CqlDateTime am_ = context.Operators.Convert<CqlDateTime>(al_);
            List<Dosage> an_ = ADTOrder?.DosageInstruction;
            bool? ao_(Dosage @this)
            {
                Timing bj_ = @this?.Timing;
                bool? bk_ = context.Operators.Not((bool?)(bj_ is null));

                return bk_;
            };
            IEnumerable<Dosage> ap_ = context.Operators.Where<Dosage>((IEnumerable<Dosage>)an_, ao_);
            Timing aq_(Dosage @this)
            {
                Timing bl_ = @this?.Timing;

                return bl_;
            };
            IEnumerable<Timing> ar_ = context.Operators.Select<Dosage, Timing>(ap_, aq_);
            bool? as_(Timing @this)
            {
                Timing.RepeatComponent bm_ = @this?.Repeat;
                bool? bn_ = context.Operators.Not((bool?)(bm_ is null));

                return bn_;
            };
            IEnumerable<Timing> at_ = context.Operators.Where<Timing>(ar_, as_);
            Timing.RepeatComponent au_(Timing @this)
            {
                Timing.RepeatComponent bo_ = @this?.Repeat;

                return bo_;
            };
            IEnumerable<Timing.RepeatComponent> av_ = context.Operators.Select<Timing, Timing.RepeatComponent>(at_, au_);
            bool? aw_(Timing.RepeatComponent @this)
            {
                DataType bp_ = @this?.Bounds;
                object bq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bp_);
                bool? br_ = context.Operators.Not((bool?)(bq_ is null));

                return br_;
            };
            IEnumerable<Timing.RepeatComponent> ax_ = context.Operators.Where<Timing.RepeatComponent>(av_, aw_);
            object ay_(Timing.RepeatComponent @this)
            {
                DataType bs_ = @this?.Bounds;
                object bt_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bs_);

                return bt_;
            };
            IEnumerable<object> az_ = context.Operators.Select<Timing.RepeatComponent, object>(ax_, ay_);
            CqlInterval<CqlDateTime> ba_(object DoseTime)
            {
                CqlInterval<CqlDateTime> bu_ = QICoreCommon_2_1_000.Instance.toInterval(context, DoseTime);

                return bu_;
            };
            IEnumerable<CqlInterval<CqlDateTime>> bb_ = context.Operators.Select<object, CqlInterval<CqlDateTime>>(az_, ba_);
            IEnumerable<CqlInterval<CqlDateTime>> bc_ = context.Operators.Distinct<CqlInterval<CqlDateTime>>(bb_);
            IEnumerable<CqlInterval<CqlDateTime>> bd_ = context.Operators.Collapse(bc_, default);
            object be_(CqlInterval<CqlDateTime> @this)
            {
                CqlDateTime bv_ = context.Operators.Start(@this);

                return bv_;
            };
            IEnumerable<CqlInterval<CqlDateTime>> bf_ = context.Operators.SortBy<CqlInterval<CqlDateTime>>(bd_, be_, System.ComponentModel.ListSortDirection.Ascending);
            CqlInterval<CqlDateTime> bg_ = context.Operators.First<CqlInterval<CqlDateTime>>(bf_);
            CqlInterval<CqlDateTime> bh_ = this.NormalizeInterval(context, am_, bg_);
            CqlDateTime bi_ = QICoreCommon_2_1_000.Instance.earliest(context, bh_ as object);

            return bi_;
        };
        IEnumerable<CqlDateTime> j_ = context.Operators.Select<MedicationRequest, CqlDateTime>(h_, i_);
        IEnumerable<CqlDateTime> k_ = context.Operators.Distinct<CqlDateTime>(j_);

        return k_;
    }


    [CqlExpressionDefinition("Prostate Cancer Diagnosis")]
    public IEnumerable<Condition> Prostate_Cancer_Diagnosis(CqlContext context)
    {
        CqlValueSet a_ = this.Prostate_Cancer(context);
        IEnumerable<Condition> b_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        bool? c_(Condition ProstateCancer)
        {
            CqlInterval<CqlDateTime> e_ = QICoreCommon_2_1_000.Instance.prevalenceInterval(context, ProstateCancer);
            CqlInterval<CqlDateTime> f_ = this.Measurement_Period(context);
            bool? g_ = context.Operators.Overlaps(e_, f_, default);
            CodeableConcept h_ = ProstateCancer?.ClinicalStatus;
            CqlConcept i_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, h_);
            CqlCode j_ = QICoreCommon_2_1_000.Instance.active(context);
            CqlConcept k_ = context.Operators.ConvertCodeToConcept(j_);
            bool? l_ = context.Operators.Equivalent(i_, k_);
            bool? m_ = context.Operators.And(g_, l_);
            CodeableConcept n_ = ProstateCancer?.VerificationStatus;
            CqlConcept o_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, n_);
            CqlCode p_ = QICoreCommon_2_1_000.Instance.confirmed(context);
            CqlConcept q_ = context.Operators.ConvertCodeToConcept(p_);
            bool? r_ = context.Operators.Equivalent(o_, q_);
            bool? s_ = context.Operators.And(m_, r_);

            return s_;
        };
        IEnumerable<Condition> d_ = context.Operators.Where<Condition>(b_, c_);

        return d_;
    }


    [CqlExpressionDefinition("First ADT in 3 Months Before to 9 Months After Start of Measurement Period")]
    public CqlDateTime First_ADT_in_3_Months_Before_to_9_Months_After_Start_of_Measurement_Period(CqlContext context)
    {
        IEnumerable<CqlDateTime> a_ = this.Androgen_Deprivation_Therapy_for_Urology_Care_Medication_Active_Start_Dates(context);
        IEnumerable<CqlDateTime> b_ = this.Androgen_Deprivation_Therapy_for_Urology_Care_Medication_Order_Start_Dates(context);
        IEnumerable<CqlDateTime> c_ = context.Operators.Union<CqlDateTime>(a_, b_);
        IEnumerable<CqlDateTime> d_(CqlDateTime ADTDateTime)
        {
            IEnumerable<Condition> h_ = this.Prostate_Cancer_Diagnosis(context);
            bool? i_(Condition ProstateCancer)
            {
                CqlInterval<CqlDateTime> m_ = QICoreCommon_2_1_000.Instance.prevalenceInterval(context, ProstateCancer);
                bool? n_ = context.Operators.In<CqlDateTime>(ADTDateTime, m_, "day");
                CqlInterval<CqlDateTime> o_ = this.Measurement_Period(context);
                CqlDateTime p_ = context.Operators.Start(o_);
                CqlQuantity q_ = context.Operators.Quantity(3m, "months");
                CqlDateTime r_ = context.Operators.Subtract(p_, q_);
                CqlDateTime t_ = context.Operators.Start(o_);
                CqlQuantity u_ = context.Operators.Quantity(9m, "months");
                CqlDateTime v_ = context.Operators.Add(t_, u_);
                CqlInterval<CqlDateTime> w_ = context.Operators.Interval(r_, v_, true, true);
                bool? x_ = context.Operators.In<CqlDateTime>(ADTDateTime, w_, "day");
                bool? y_ = context.Operators.And(n_, x_);

                return y_;
            };
            IEnumerable<Condition> j_ = context.Operators.Where<Condition>(h_, i_);
            CqlDateTime k_(Condition ProstateCancer) =>
                ADTDateTime;
            IEnumerable<CqlDateTime> l_ = context.Operators.Select<Condition, CqlDateTime>(j_, k_);

            return l_;
        };
        IEnumerable<CqlDateTime> e_ = context.Operators.SelectMany<CqlDateTime, CqlDateTime>(c_, d_);
        IEnumerable<CqlDateTime> f_ = context.Operators.ListSort<CqlDateTime>(e_, System.ComponentModel.ListSortDirection.Ascending);
        CqlDateTime g_ = context.Operators.First<CqlDateTime>(f_);

        return g_;
    }


    [CqlExpressionDefinition("Order for 12 Months of ADT in 3 Months Before to 9 Months After Start of Measurement Period")]
    public IEnumerable<ServiceRequest> Order_for_12_Months_of_ADT_in_3_Months_Before_to_9_Months_After_Start_of_Measurement_Period(CqlContext context)
    {
        CqlCode a_ = this.Injection_of_leuprolide_acetate_for_twelve_month_period__regime_therapy_(context);
        IEnumerable<CqlCode> b_ = context.Operators.ToList<CqlCode>(a_);
        IEnumerable<ServiceRequest> c_ = context.Operators.Retrieve<ServiceRequest>(new RetrieveParameters(default, default, b_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-servicerequest"));
        IEnumerable<ServiceRequest> d_(ServiceRequest OrderTwelveMonthADT)
        {
            CqlDateTime f_ = this.First_ADT_in_3_Months_Before_to_9_Months_After_Start_of_Measurement_Period(context);
            CqlDateTime[] g_ = [
                f_,
            ];
            bool? h_(CqlDateTime FirstADTMP)
            {
                FhirDateTime l_ = OrderTwelveMonthADT?.AuthoredOnElement;
                CqlDateTime m_ = context.Operators.Convert<CqlDateTime>(l_);
                bool? n_ = context.Operators.SameOrAfter(m_, FirstADTMP, "day");
                CqlDateTime p_ = context.Operators.Convert<CqlDateTime>(l_);
                CqlInterval<CqlDateTime> q_ = this.Measurement_Period(context);
                CqlDateTime r_ = context.Operators.Start(q_);
                CqlQuantity s_ = context.Operators.Quantity(3m, "months");
                CqlDateTime t_ = context.Operators.Subtract(r_, s_);
                CqlDateTime v_ = context.Operators.Start(q_);
                CqlQuantity w_ = context.Operators.Quantity(9m, "months");
                CqlDateTime x_ = context.Operators.Add(v_, w_);
                CqlInterval<CqlDateTime> y_ = context.Operators.Interval(t_, x_, true, true);
                bool? z_ = context.Operators.In<CqlDateTime>(p_, y_, "day");
                bool? aa_ = context.Operators.And(n_, z_);
                Code<RequestStatus> ab_ = OrderTwelveMonthADT?.StatusElement;
                RequestStatus? ac_ = ab_?.Value;
                Code<RequestStatus> ad_ = context.Operators.Convert<Code<RequestStatus>>(ac_);
                string ae_ = context.Operators.Convert<string>(ad_);
                string[] af_ = [
                    "active",
                    "completed",
                ];
                bool? ag_ = context.Operators.In<string>(ae_, (IEnumerable<string>)af_);
                bool? ah_ = context.Operators.And(aa_, ag_);
                Code<RequestIntent> ai_ = OrderTwelveMonthADT?.IntentElement;
                RequestIntent? aj_ = ai_?.Value;
                Code<RequestIntent> ak_ = context.Operators.Convert<Code<RequestIntent>>(aj_);
                bool? al_ = context.Operators.Equal(ak_, "order");
                bool? am_ = context.Operators.And(ah_, al_);
                FhirBoolean an_ = OrderTwelveMonthADT?.DoNotPerformElement;
                bool? ao_ = an_?.Value;
                bool? ap_ = context.Operators.IsTrue(ao_);
                bool? aq_ = context.Operators.Not(ap_);
                bool? ar_ = context.Operators.And(am_, aq_);

                return ar_;
            };
            IEnumerable<CqlDateTime> i_ = context.Operators.Where<CqlDateTime>((IEnumerable<CqlDateTime>)g_, h_);
            ServiceRequest j_(CqlDateTime FirstADTMP) =>
                OrderTwelveMonthADT;
            IEnumerable<ServiceRequest> k_ = context.Operators.Select<CqlDateTime, ServiceRequest>(i_, j_);

            return k_;
        };
        IEnumerable<ServiceRequest> e_ = context.Operators.SelectMany<ServiceRequest, ServiceRequest>(c_, d_);

        return e_;
    }


    [CqlExpressionDefinition("Initial Population")]
    public bool? Initial_Population(CqlContext context)
    {
        bool? a_ = this.Has_Qualifying_Encounter(context);
        IEnumerable<ServiceRequest> b_ = this.Order_for_12_Months_of_ADT_in_3_Months_Before_to_9_Months_After_Start_of_Measurement_Period(context);
        bool? c_ = context.Operators.Exists<ServiceRequest>(b_);
        bool? d_ = context.Operators.And(a_, c_);

        return d_;
    }


    [CqlExpressionDefinition("Denominator")]
    public bool? Denominator(CqlContext context)
    {
        bool? a_ = this.Initial_Population(context);

        return a_;
    }


    [CqlExpressionDefinition("Has Baseline DEXA Scan Two Years Prior to the Start of or Less than Three Months After the Start of ADT")]
    public bool? Has_Baseline_DEXA_Scan_Two_Years_Prior_to_the_Start_of_or_Less_than_Three_Months_After_the_Start_of_ADT(CqlContext context)
    {
        CqlValueSet a_ = this.DEXA_Dual_Energy_Xray_Absorptiometry__Bone_Density_for_Urology_Care(context);
        IEnumerable<ServiceRequest> b_ = context.Operators.Retrieve<ServiceRequest>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-servicerequest"));
        IEnumerable<ServiceRequest> c_(ServiceRequest DEXAOrdered)
        {
            IEnumerable<ServiceRequest> o_ = this.Order_for_12_Months_of_ADT_in_3_Months_Before_to_9_Months_After_Start_of_Measurement_Period(context);
            bool? p_(ServiceRequest OrderTwelveMonthsADT)
            {
                FhirDateTime t_ = DEXAOrdered?.AuthoredOnElement;
                CqlDateTime u_ = context.Operators.Convert<CqlDateTime>(t_);
                FhirDateTime v_ = OrderTwelveMonthsADT?.AuthoredOnElement;
                CqlDateTime w_ = context.Operators.Convert<CqlDateTime>(v_);
                CqlDateTime y_ = context.Operators.Convert<CqlDateTime>(v_);
                CqlQuantity z_ = context.Operators.Quantity(3m, "months");
                CqlDateTime aa_ = context.Operators.Add(y_, z_);
                CqlInterval<CqlDateTime> ab_ = context.Operators.Interval(w_, aa_, true, true);
                bool? ac_ = context.Operators.In<CqlDateTime>(u_, ab_, "day");
                CqlDateTime ae_ = context.Operators.Convert<CqlDateTime>(v_);
                bool? af_ = context.Operators.Not((bool?)(ae_ is null));
                bool? ag_ = context.Operators.And(ac_, af_);
                CqlDateTime ai_ = context.Operators.Convert<CqlDateTime>(t_);
                CqlDateTime ak_ = context.Operators.Convert<CqlDateTime>(v_);
                CqlQuantity al_ = context.Operators.Quantity(2m, "years");
                CqlDateTime am_ = context.Operators.Subtract(ak_, al_);
                CqlDateTime ao_ = context.Operators.Convert<CqlDateTime>(v_);
                CqlInterval<CqlDateTime> ap_ = context.Operators.Interval(am_, ao_, true, false);
                bool? aq_ = context.Operators.In<CqlDateTime>(ai_, ap_, "day");
                CqlDateTime as_ = context.Operators.Convert<CqlDateTime>(v_);
                bool? at_ = context.Operators.Not((bool?)(as_ is null));
                bool? au_ = context.Operators.And(aq_, at_);
                bool? av_ = context.Operators.Or(ag_, au_);

                return av_;
            };
            IEnumerable<ServiceRequest> q_ = context.Operators.Where<ServiceRequest>(o_, p_);
            ServiceRequest r_(ServiceRequest OrderTwelveMonthsADT) =>
                DEXAOrdered;
            IEnumerable<ServiceRequest> s_ = context.Operators.Select<ServiceRequest, ServiceRequest>(q_, r_);

            return s_;
        };
        IEnumerable<ServiceRequest> d_ = context.Operators.SelectMany<ServiceRequest, ServiceRequest>(b_, c_);
        bool? e_(ServiceRequest DEXAOrdered)
        {
            Code<RequestStatus> aw_ = DEXAOrdered?.StatusElement;
            RequestStatus? ax_ = aw_?.Value;
            Code<RequestStatus> ay_ = context.Operators.Convert<Code<RequestStatus>>(ax_);
            string az_ = context.Operators.Convert<string>(ay_);
            string[] ba_ = [
                "active",
                "completed",
            ];
            bool? bb_ = context.Operators.In<string>(az_, (IEnumerable<string>)ba_);
            Code<RequestIntent> bc_ = DEXAOrdered?.IntentElement;
            RequestIntent? bd_ = bc_?.Value;
            Code<RequestIntent> be_ = context.Operators.Convert<Code<RequestIntent>>(bd_);
            bool? bf_ = context.Operators.Equal(be_, "order");
            bool? bg_ = context.Operators.And(bb_, bf_);
            FhirBoolean bh_ = DEXAOrdered?.DoNotPerformElement;
            bool? bi_ = bh_?.Value;
            bool? bj_ = context.Operators.IsTrue(bi_);
            bool? bk_ = context.Operators.Not(bj_);
            bool? bl_ = context.Operators.And(bg_, bk_);

            return bl_;
        };
        IEnumerable<ServiceRequest> f_ = context.Operators.Where<ServiceRequest>(d_, e_);
        IEnumerable<Observation> h_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
        IEnumerable<Observation> i_(Observation DEXAPerformed)
        {
            IEnumerable<ServiceRequest> bm_ = this.Order_for_12_Months_of_ADT_in_3_Months_Before_to_9_Months_After_Start_of_Measurement_Period(context);
            bool? bn_(ServiceRequest OrderTwelveMonthsADT)
            {
                DataType br_ = DEXAPerformed?.Effective;
                object bs_ = FHIRHelpers_4_4_000.Instance.ToValue(context, br_);
                CqlInterval<CqlDateTime> bt_ = QICoreCommon_2_1_000.Instance.toInterval(context, bs_);
                CqlDateTime bu_ = context.Operators.Start(bt_);
                FhirDateTime bv_ = OrderTwelveMonthsADT?.AuthoredOnElement;
                CqlDateTime bw_ = context.Operators.Convert<CqlDateTime>(bv_);
                CqlDateTime by_ = context.Operators.Convert<CqlDateTime>(bv_);
                CqlQuantity bz_ = context.Operators.Quantity(3m, "months");
                CqlDateTime ca_ = context.Operators.Add(by_, bz_);
                CqlInterval<CqlDateTime> cb_ = context.Operators.Interval(bw_, ca_, true, true);
                bool? cc_ = context.Operators.In<CqlDateTime>(bu_, cb_, "day");
                CqlDateTime ce_ = context.Operators.Convert<CqlDateTime>(bv_);
                bool? cf_ = context.Operators.Not((bool?)(ce_ is null));
                bool? cg_ = context.Operators.And(cc_, cf_);
                object ci_ = FHIRHelpers_4_4_000.Instance.ToValue(context, br_);
                CqlInterval<CqlDateTime> cj_ = QICoreCommon_2_1_000.Instance.toInterval(context, ci_);
                CqlDateTime ck_ = context.Operators.End(cj_);
                CqlDateTime cm_ = context.Operators.Convert<CqlDateTime>(bv_);
                CqlQuantity cn_ = context.Operators.Quantity(2m, "years");
                CqlDateTime co_ = context.Operators.Subtract(cm_, cn_);
                CqlDateTime cq_ = context.Operators.Convert<CqlDateTime>(bv_);
                CqlInterval<CqlDateTime> cr_ = context.Operators.Interval(co_, cq_, true, false);
                bool? cs_ = context.Operators.In<CqlDateTime>(ck_, cr_, "day");
                CqlDateTime cu_ = context.Operators.Convert<CqlDateTime>(bv_);
                bool? cv_ = context.Operators.Not((bool?)(cu_ is null));
                bool? cw_ = context.Operators.And(cs_, cv_);
                bool? cx_ = context.Operators.Or(cg_, cw_);

                return cx_;
            };
            IEnumerable<ServiceRequest> bo_ = context.Operators.Where<ServiceRequest>(bm_, bn_);
            Observation bp_(ServiceRequest OrderTwelveMonthsADT) =>
                DEXAPerformed;
            IEnumerable<Observation> bq_ = context.Operators.Select<ServiceRequest, Observation>(bo_, bp_);

            return bq_;
        };
        IEnumerable<Observation> j_ = context.Operators.SelectMany<Observation, Observation>(h_, i_);
        bool? k_(Observation DEXAPerformed)
        {
            Code<ObservationStatus> cy_ = DEXAPerformed?.StatusElement;
            ObservationStatus? cz_ = cy_?.Value;
            Code<ObservationStatus> da_ = context.Operators.Convert<Code<ObservationStatus>>(cz_);
            string db_ = context.Operators.Convert<string>(da_);
            string[] dc_ = [
                "final",
                "amended",
                "corrected",
            ];
            bool? dd_ = context.Operators.In<string>(db_, (IEnumerable<string>)dc_);

            return dd_;
        };
        IEnumerable<Observation> l_ = context.Operators.Where<Observation>(j_, k_);
        IEnumerable<object> m_ = context.Operators.Union<object>(f_ as IEnumerable<object>, l_ as IEnumerable<object>);
        bool? n_ = context.Operators.Exists<object>(m_);

        return n_;
    }


    [CqlExpressionDefinition("Numerator")]
    public bool? Numerator(CqlContext context)
    {
        bool? a_ = this.Has_Baseline_DEXA_Scan_Two_Years_Prior_to_the_Start_of_or_Less_than_Three_Months_After_the_Start_of_ADT(context);

        return a_;
    }


    [CqlExpressionDefinition("Denominator Exception")]
    [CqlTag("commentedOut", "\"No Bone Density Scan Ordered Due to Patient Refusal\" ) ")]
    [CqlTag("commmentedOutReason", "Negation issue related to https://github.com/cqframework/cql-execution/issues/296, which is tied to https://oncprojectracking.healthit.gov/support/browse/BONNIEMAT-1455. Due to this being the only logic in population, created a 'false' placeholder")]
    public bool? Denominator_Exception(CqlContext context) =>
        false;


    [CqlExpressionDefinition("SDE Ethnicity")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Ethnicity(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? a_ = SupplementalDataElements_3_5_000.Instance.SDE_Ethnicity(context);

        return a_;
    }


    [CqlExpressionDefinition("SDE Payer")]
    public IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> SDE_Payer(CqlContext context)
    {
        IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> a_ = SupplementalDataElements_3_5_000.Instance.SDE_Payer(context);

        return a_;
    }


    [CqlExpressionDefinition("SDE Race")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Race(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? a_ = SupplementalDataElements_3_5_000.Instance.SDE_Race(context);

        return a_;
    }


    [CqlExpressionDefinition("SDE Sex")]
    public CqlCode SDE_Sex(CqlContext context)
    {
        CqlCode a_ = SupplementalDataElements_3_5_000.Instance.SDE_Sex(context);

        return a_;
    }


    [CqlExpressionDefinition("No Bone Density Scan Ordered Due to Patient Refusal")]
    public IEnumerable<ServiceRequest> No_Bone_Density_Scan_Ordered_Due_to_Patient_Refusal(CqlContext context)
    {
        CqlValueSet a_ = this.DEXA_Dual_Energy_Xray_Absorptiometry__Bone_Density_for_Urology_Care(context);
        IEnumerable<ServiceRequest> b_ = context.Operators.Retrieve<ServiceRequest>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-servicenotrequested"));
        IEnumerable<ServiceRequest> d_ = context.Operators.Retrieve<ServiceRequest>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-servicenotrequested"));
        IEnumerable<ServiceRequest> e_ = context.Operators.Union<ServiceRequest>(b_, d_);
        IEnumerable<ServiceRequest> f_(ServiceRequest DEXANotOrdered)
        {
            IEnumerable<ServiceRequest> h_ = this.Order_for_12_Months_of_ADT_in_3_Months_Before_to_9_Months_After_Start_of_Measurement_Period(context);
            bool? i_(ServiceRequest OrderTwelveMonthsADT)
            {
                FhirDateTime m_ = DEXANotOrdered?.AuthoredOnElement;
                CqlDateTime n_ = context.Operators.Convert<CqlDateTime>(m_);
                FhirDateTime o_ = OrderTwelveMonthsADT?.AuthoredOnElement;
                CqlDateTime p_ = context.Operators.Convert<CqlDateTime>(o_);
                CqlDateTime r_ = context.Operators.Convert<CqlDateTime>(o_);
                CqlQuantity s_ = context.Operators.Quantity(3m, "months");
                CqlDateTime t_ = context.Operators.Add(r_, s_);
                CqlInterval<CqlDateTime> u_ = context.Operators.Interval(p_, t_, true, true);
                bool? v_ = context.Operators.In<CqlDateTime>(n_, u_, "day");
                CqlDateTime x_ = context.Operators.Convert<CqlDateTime>(o_);
                bool? y_ = context.Operators.Not((bool?)(x_ is null));
                bool? z_ = context.Operators.And(v_, y_);
                bool? aa_(Extension @this)
                {
                    string aj_ = @this?.Url;
                    FhirString ak_ = context.Operators.Convert<FhirString>(aj_);
                    string al_ = FHIRHelpers_4_4_000.Instance.ToString(context, ak_);
                    bool? am_ = context.Operators.Equal(al_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-doNotPerformReason");

                    return am_;
                };
                IEnumerable<Extension> ab_ = context.Operators.Where<Extension>((IEnumerable<Extension>)(DEXANotOrdered is DomainResource
                        ? (DEXANotOrdered as DomainResource).Extension
                        : default), aa_);
                object ac_(Extension @this)
                {
                    DataType an_ = @this?.Value;

                    return an_;
                };
                IEnumerable<object> ad_ = context.Operators.Select<Extension, object>(ab_, ac_);
                object ae_ = context.Operators.SingletonFrom<object>(ad_);
                CqlConcept af_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, ae_ as CodeableConcept);
                CqlValueSet ag_ = this.Patient_Declined(context);
                bool? ah_ = context.Operators.ConceptInValueSet(af_, ag_);
                bool? ai_ = context.Operators.And(z_, ah_);

                return ai_;
            };
            IEnumerable<ServiceRequest> j_ = context.Operators.Where<ServiceRequest>(h_, i_);
            ServiceRequest k_(ServiceRequest OrderTwelveMonthsADT) =>
                DEXANotOrdered;
            IEnumerable<ServiceRequest> l_ = context.Operators.Select<ServiceRequest, ServiceRequest>(j_, k_);

            return l_;
        };
        IEnumerable<ServiceRequest> g_ = context.Operators.SelectMany<ServiceRequest, ServiceRequest>(e_, f_);

        return g_;
    }


    [CqlExpressionDefinition("No Bone Density Scan Performed Due to Patient Refusal")]
    public IEnumerable<Observation> No_Bone_Density_Scan_Performed_Due_to_Patient_Refusal(CqlContext context)
    {
        CqlValueSet a_ = this.DEXA_Dual_Energy_Xray_Absorptiometry__Bone_Density_for_Urology_Care(context);
        IEnumerable<Observation> b_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observationnotdone"));
        IEnumerable<Observation> d_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observationnotdone"));
        IEnumerable<Observation> e_ = context.Operators.Union<Observation>(b_, d_);
        IEnumerable<Observation> f_(Observation DEXANotPerformed)
        {
            IEnumerable<ServiceRequest> h_ = this.Order_for_12_Months_of_ADT_in_3_Months_Before_to_9_Months_After_Start_of_Measurement_Period(context);
            bool? i_(ServiceRequest OrderTwelveMonthsADT)
            {
                Instant m_ = DEXANotPerformed?.IssuedElement;
                DateTimeOffset? n_ = m_?.Value;
                CqlDateTime o_ = context.Operators.Convert<CqlDateTime>(n_);
                FhirDateTime p_ = OrderTwelveMonthsADT?.AuthoredOnElement;
                CqlDateTime q_ = context.Operators.Convert<CqlDateTime>(p_);
                CqlDateTime s_ = context.Operators.Convert<CqlDateTime>(p_);
                CqlQuantity t_ = context.Operators.Quantity(3m, "months");
                CqlDateTime u_ = context.Operators.Add(s_, t_);
                CqlInterval<CqlDateTime> v_ = context.Operators.Interval(q_, u_, true, true);
                bool? w_ = context.Operators.In<CqlDateTime>(o_, v_, "day");
                CqlDateTime y_ = context.Operators.Convert<CqlDateTime>(p_);
                bool? z_ = context.Operators.Not((bool?)(y_ is null));
                bool? aa_ = context.Operators.And(w_, z_);
                bool? ab_(Extension @this)
                {
                    string ak_ = @this?.Url;
                    FhirString al_ = context.Operators.Convert<FhirString>(ak_);
                    string am_ = FHIRHelpers_4_4_000.Instance.ToString(context, al_);
                    bool? an_ = context.Operators.Equal(am_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-notDoneReason");

                    return an_;
                };
                IEnumerable<Extension> ac_ = context.Operators.Where<Extension>((IEnumerable<Extension>)(DEXANotPerformed is DomainResource
                        ? (DEXANotPerformed as DomainResource).Extension
                        : default), ab_);
                object ad_(Extension @this)
                {
                    DataType ao_ = @this?.Value;

                    return ao_;
                };
                IEnumerable<object> ae_ = context.Operators.Select<Extension, object>(ac_, ad_);
                object af_ = context.Operators.SingletonFrom<object>(ae_);
                CqlConcept ag_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, af_ as CodeableConcept);
                CqlValueSet ah_ = this.Patient_Declined(context);
                bool? ai_ = context.Operators.ConceptInValueSet(ag_, ah_);
                bool? aj_ = context.Operators.And(aa_, ai_);

                return aj_;
            };
            IEnumerable<ServiceRequest> j_ = context.Operators.Where<ServiceRequest>(h_, i_);
            Observation k_(ServiceRequest OrderTwelveMonthsADT) =>
                DEXANotPerformed;
            IEnumerable<Observation> l_ = context.Operators.Select<ServiceRequest, Observation>(j_, k_);

            return l_;
        };
        IEnumerable<Observation> g_ = context.Operators.SelectMany<Observation, Observation>(e_, f_);

        return g_;
    }


    #endregion Functions and Expressions

}

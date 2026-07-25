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

[System.CodeDom.Compiler.GeneratedCode(".NET Code Generation", "5.1.4.0")]
[CqlLibrary("CMS645FHIRBoneDensityPCADTherapy", "1.0.000")]
public partial class CMS645FHIRBoneDensityPCADTherapy_1_0_000 : ILibrary, ISingleton<CMS645FHIRBoneDensityPCADTherapy_1_0_000>
{
    #region ValueSets (5)

    [CqlValueSetDefinition("Androgen Deprivation Therapy for Urology Care", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1248.352", valueSetVersion: null)]
    public CqlValueSet Androgen_Deprivation_Therapy_for_Urology_Care(CqlContext _) => _Androgen_Deprivation_Therapy_for_Urology_Care;
    private static readonly CqlValueSet _Androgen_Deprivation_Therapy_for_Urology_Care = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1248.352", null);

    [CqlValueSetDefinition("DEXA Bone Density for Urology Care", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1248.359", valueSetVersion: null)]
    public CqlValueSet DEXA_Bone_Density_for_Urology_Care(CqlContext _) => _DEXA_Bone_Density_for_Urology_Care;
    private static readonly CqlValueSet _DEXA_Bone_Density_for_Urology_Care = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1248.359", null);

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

    #region Codes (1)

    [CqlCodeDefinition("Injection of leuprolide acetate for twelve month period (regime/therapy)", codeId: "456381000124102", codeSystem: "http://snomed.info/sct")]
    public CqlCode Injection_of_leuprolide_acetate_for_twelve_month_period__regime_therapy_(CqlContext _) => _Injection_of_leuprolide_acetate_for_twelve_month_period__regime_therapy_;
    private static readonly CqlCode _Injection_of_leuprolide_acetate_for_twelve_month_period__regime_therapy_ = new CqlCode("456381000124102", "http://snomed.info/sct");

    #endregion Codes

    #region CodeSystems (1)

    [CqlCodeSystemDefinition("SNOMEDCT", codeSystemId: "http://snomed.info/sct", codeSystemVersion: null)]
    public CqlCodeSystem SNOMEDCT(CqlContext _) => _SNOMEDCT;
    private static readonly CqlCodeSystem _SNOMEDCT =
      new CqlCodeSystem("http://snomed.info/sct", null, [
          _Injection_of_leuprolide_acetate_for_twelve_month_period__regime_therapy_]);

    #endregion CodeSystems

    #region Parameters (1)

    [CqlParameterDefinition("Measurement Period")]
    public CqlInterval<CqlDateTime> Measurement_Period(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Measurement_Period, Measurement_Period_Compute);

    private const long _cacheIndex_Measurement_Period = -734786439587116816L;

    private CqlInterval<CqlDateTime> Measurement_Period_Compute(CqlContext context)
    {
        CqlDateTime a_ = context.Operators.DateTime(2026, 1, 1, 0, 0, 0, 0, 0.0m);
        CqlDateTime b_ = context.Operators.DateTime(2027, 1, 1, 0, 0, 0, 0, 0.0m);
        CqlInterval<CqlDateTime> c_ = context.Operators.Interval(a_, b_, true, false);
        object d_ = context.ResolveParameter("CMS645FHIRBoneDensityPCADTherapy-1.0.000", "Measurement Period", c_);
        return (CqlInterval<CqlDateTime>)d_;
    }


    #endregion Parameters

    #region Functions and Expressions (19)

    [CqlExpressionDefinition("Patient")]
    public Patient Patient(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Patient, Patient_Compute);

    private const long _cacheIndex_Patient = -8229489559334500711L;

    private Patient Patient_Compute(CqlContext context)
    {
        IEnumerable<Patient> a_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-patient"));
        Patient b_ = context.Operators.SingletonFrom<Patient>(a_);
        return b_;
    }


    [CqlExpressionDefinition("Has Qualifying Encounter")]
    public bool? Has_Qualifying_Encounter(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Has_Qualifying_Encounter, Has_Qualifying_Encounter_Compute);

    private const long _cacheIndex_Has_Qualifying_Encounter = 9066402021790216149L;

    private bool? Has_Qualifying_Encounter_Compute(CqlContext context)
    {
        CqlValueSet a_ = this.Office_Visit(context);
        IEnumerable<Encounter> b_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));

        bool? c_(Encounter OfficeVisit) {
            CqlInterval<CqlDateTime> f_ = this.Measurement_Period(context);
            Period g_ = OfficeVisit?.Period;
            CqlInterval<CqlDateTime> h_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, g_);
            bool? i_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(f_, h_, "day");
            Code<Encounter.EncounterStatus> j_ = OfficeVisit?.StatusElement;
            Encounter.EncounterStatus? k_ = j_?.Value;
            Code<Encounter.EncounterStatus> l_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(k_);
            bool? m_ = context.Operators.Equal(l_, "finished");
            bool? n_ = context.Operators.And(i_, m_);
            return n_;
        }

        IEnumerable<Encounter> d_ = context.Operators.Where<Encounter>(b_, c_);
        bool? e_ = context.Operators.Exists<Encounter>(d_);
        return e_;
    }


    [CqlExpressionDefinition("Androgen Deprivation Therapy for Urology Care Medication Active Start Dates")]
    public IEnumerable<CqlDateTime> Androgen_Deprivation_Therapy_for_Urology_Care_Medication_Active_Start_Dates(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Androgen_Deprivation_Therapy_for_Urology_Care_Medication_Active_Start_Dates, Androgen_Deprivation_Therapy_for_Urology_Care_Medication_Active_Start_Dates_Compute);

    private const long _cacheIndex_Androgen_Deprivation_Therapy_for_Urology_Care_Medication_Active_Start_Dates = 1519890029288935373L;

    private IEnumerable<CqlDateTime> Androgen_Deprivation_Therapy_for_Urology_Care_Medication_Active_Start_Dates_Compute(CqlContext context)
    {
        CqlValueSet a_ = this.Androgen_Deprivation_Therapy_for_Urology_Care(context);
        IEnumerable<MedicationRequest> b_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> c_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));

        bool? d_(MedicationRequest MR) {
            IEnumerable<Medication> l_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));

            bool? m_(Medication M) {
                object p_ = context.Operators.LateBoundProperty<object>(M, "id.value");
                object q_ = context.Operators.LateBoundProperty<object>(MR, "medication.reference.value");
                IEnumerable<string> r_ = context.Operators.Split((string)q_, "/");
                string s_ = context.Operators.Last<string>(r_);
                bool? t_ = context.Operators.Equal(p_, s_);
                CodeableConcept u_ = M?.Code;
                CqlConcept v_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, u_);
                CqlValueSet w_ = this.Androgen_Deprivation_Therapy_for_Urology_Care(context);
                bool? x_ = context.Operators.ConceptInValueSet(v_, w_);
                bool? y_ = context.Operators.And(t_, x_);
                return y_;
            }

            IEnumerable<Medication> n_ = context.Operators.Where<Medication>(l_, m_);
            bool? o_ = context.Operators.Exists<Medication>(n_);
            return o_;
        }

        IEnumerable<MedicationRequest> e_ = context.Operators.Where<MedicationRequest>(c_, d_);
        IEnumerable<MedicationRequest> f_ = context.Operators.Union<MedicationRequest>(b_, e_);

        bool? g_(MedicationRequest ADTActive) {
            Code<MedicationRequest.MedicationrequestStatus> z_ = ADTActive?.StatusElement;
            MedicationRequest.MedicationrequestStatus? aa_ = z_?.Value;
            string ab_ = context.Operators.Convert<string>(aa_);
            string[] ac_ = [
                "active",
                "completed",
            ];
            bool? ad_ = context.Operators.In<string>(ab_, (IEnumerable<string>)ac_);
            Code<MedicationRequest.MedicationRequestIntent> ae_ = ADTActive?.IntentElement;
            MedicationRequest.MedicationRequestIntent? af_ = ae_?.Value;
            string ag_ = context.Operators.Convert<string>(af_);
            string[] ah_ = [
                "order",
                "original-order",
                "reflex-order",
                "filler-order",
                "instance-order",
            ];
            bool? ai_ = context.Operators.In<string>(ag_, (IEnumerable<string>)ah_);
            bool? aj_ = context.Operators.And(ad_, ai_);
            return aj_;
        }

        IEnumerable<MedicationRequest> h_ = context.Operators.Where<MedicationRequest>(f_, g_);

        CqlDateTime i_(MedicationRequest ADTActive) {
            List<Dosage> ak_ = ADTActive?.DosageInstruction;

            bool? al_(Dosage @this) {
                Timing ck_ = @this?.Timing;
                bool? cl_ = context.Operators.Not((bool?)(ck_ is null));
                return cl_;
            }

            IEnumerable<Dosage> am_ = context.Operators.Where<Dosage>((IEnumerable<Dosage>)ak_, al_);

            Timing an_(Dosage @this) {
                Timing cm_ = @this?.Timing;
                return cm_;
            }

            IEnumerable<Timing> ao_ = context.Operators.Select<Dosage, Timing>(am_, an_);

            CqlDateTime ap_(Timing dosageTiming) {
                List<FhirDateTime> cn_ = dosageTiming?.EventElement;

                string co_(FhirDateTime @this) {
                    string cu_ = @this?.Value;
                    return cu_;
                }

                IEnumerable<string> cp_ = context.Operators.Select<FhirDateTime, string>((IEnumerable<FhirDateTime>)cn_, co_);

                CqlDateTime cq_(string @string) {
                    CqlDateTime cv_ = context.Operators.ConvertStringToDateTime(@string);
                    return cv_;
                }

                IEnumerable<CqlDateTime> cr_ = context.Operators.Select<string, CqlDateTime>(cp_, cq_);
                IEnumerable<CqlDateTime> cs_ = context.Operators.ListSort<CqlDateTime>(cr_, System.ComponentModel.ListSortDirection.Ascending);
                CqlDateTime ct_ = context.Operators.First<CqlDateTime>(cs_);
                return ct_;
            }

            IEnumerable<CqlDateTime> aq_ = context.Operators.Select<Timing, CqlDateTime>(ao_, ap_);
            IEnumerable<CqlDateTime> ar_ = context.Operators.Distinct<CqlDateTime>(aq_);
            IEnumerable<CqlDateTime> as_ = context.Operators.ListSort<CqlDateTime>(ar_, System.ComponentModel.ListSortDirection.Ascending);
            CqlDateTime at_ = context.Operators.First<CqlDateTime>(as_);

            bool? au_(Dosage @this) {
                Timing cw_ = @this?.Timing;
                bool? cx_ = context.Operators.Not((bool?)(cw_ is null));
                return cx_;
            }

            IEnumerable<Dosage> av_ = context.Operators.Where<Dosage>((IEnumerable<Dosage>)ak_, au_);

            Timing aw_(Dosage @this) {
                Timing cy_ = @this?.Timing;
                return cy_;
            }

            IEnumerable<Timing> ax_ = context.Operators.Select<Dosage, Timing>(av_, aw_);

            bool? ay_(Timing @this) {
                Timing.RepeatComponent cz_ = @this?.Repeat;
                bool? da_ = context.Operators.Not((bool?)(cz_ is null));
                return da_;
            }

            IEnumerable<Timing> az_ = context.Operators.Where<Timing>(ax_, ay_);

            Timing.RepeatComponent ba_(Timing @this) {
                Timing.RepeatComponent db_ = @this?.Repeat;
                return db_;
            }

            IEnumerable<Timing.RepeatComponent> bb_ = context.Operators.Select<Timing, Timing.RepeatComponent>(az_, ba_);

            bool? bc_(Timing.RepeatComponent @this) {
                DataType dc_ = @this?.Bounds;
                object dd_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dc_);
                bool? de_ = context.Operators.Not((bool?)(dd_ is null));
                return de_;
            }

            IEnumerable<Timing.RepeatComponent> bd_ = context.Operators.Where<Timing.RepeatComponent>(bb_, bc_);

            object be_(Timing.RepeatComponent @this) {
                DataType df_ = @this?.Bounds;
                object dg_ = FHIRHelpers_4_4_000.Instance.ToValue(context, df_);
                return dg_;
            }

            IEnumerable<object> bf_ = context.Operators.Select<Timing.RepeatComponent, object>(bd_, be_);

            CqlInterval<CqlDateTime> bg_(object DoseTime) {
                CqlInterval<CqlDateTime> dh_ = QICoreCommon_4_0_000.Instance.toInterval(context, DoseTime);
                return dh_;
            }

            IEnumerable<CqlInterval<CqlDateTime>> bh_ = context.Operators.Select<object, CqlInterval<CqlDateTime>>(bf_, bg_);
            IEnumerable<CqlInterval<CqlDateTime>> bi_ = context.Operators.Distinct<CqlInterval<CqlDateTime>>(bh_);
            IEnumerable<CqlInterval<CqlDateTime>> bj_ = context.Operators.Collapse(bi_, (string)default);

            object bk_(CqlInterval<CqlDateTime> @this) {
                CqlDateTime di_ = context.Operators.Start(@this);
                return di_;
            }

            IEnumerable<CqlInterval<CqlDateTime>> bl_ = context.Operators.SortBy<CqlInterval<CqlDateTime>>(bj_, bk_, System.ComponentModel.ListSortDirection.Ascending);
            CqlInterval<CqlDateTime> bm_ = context.Operators.First<CqlInterval<CqlDateTime>>(bl_);
            CqlDateTime bn_ = context.Operators.Start(bm_);

            bool? bo_(Dosage @this) {
                Timing dj_ = @this?.Timing;
                bool? dk_ = context.Operators.Not((bool?)(dj_ is null));
                return dk_;
            }

            IEnumerable<Dosage> bp_ = context.Operators.Where<Dosage>((IEnumerable<Dosage>)ak_, bo_);

            Timing bq_(Dosage @this) {
                Timing dl_ = @this?.Timing;
                return dl_;
            }

            IEnumerable<Timing> br_ = context.Operators.Select<Dosage, Timing>(bp_, bq_);

            bool? bs_(Timing @this) {
                Timing.RepeatComponent dm_ = @this?.Repeat;
                bool? dn_ = context.Operators.Not((bool?)(dm_ is null));
                return dn_;
            }

            IEnumerable<Timing> bt_ = context.Operators.Where<Timing>(br_, bs_);

            Timing.RepeatComponent bu_(Timing @this) {
                Timing.RepeatComponent do_ = @this?.Repeat;
                return do_;
            }

            IEnumerable<Timing.RepeatComponent> bv_ = context.Operators.Select<Timing, Timing.RepeatComponent>(bt_, bu_);

            bool? bw_(Timing.RepeatComponent @this) {
                DataType dp_ = @this?.Bounds;
                object dq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dp_);
                bool? dr_ = context.Operators.Not((bool?)(dq_ is null));
                return dr_;
            }

            IEnumerable<Timing.RepeatComponent> bx_ = context.Operators.Where<Timing.RepeatComponent>(bv_, bw_);

            object by_(Timing.RepeatComponent @this) {
                DataType ds_ = @this?.Bounds;
                object dt_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ds_);
                return dt_;
            }

            IEnumerable<object> bz_ = context.Operators.Select<Timing.RepeatComponent, object>(bx_, by_);

            CqlInterval<CqlDateTime> ca_(object DoseTime) {
                CqlInterval<CqlDateTime> du_ = QICoreCommon_4_0_000.Instance.toInterval(context, DoseTime);
                return du_;
            }

            IEnumerable<CqlInterval<CqlDateTime>> cb_ = context.Operators.Select<object, CqlInterval<CqlDateTime>>(bz_, ca_);
            IEnumerable<CqlInterval<CqlDateTime>> cc_ = context.Operators.Distinct<CqlInterval<CqlDateTime>>(cb_);
            IEnumerable<CqlInterval<CqlDateTime>> cd_ = context.Operators.Collapse(cc_, (string)default);

            object ce_(CqlInterval<CqlDateTime> @this) {
                CqlDateTime dv_ = context.Operators.Start(@this);
                return dv_;
            }

            IEnumerable<CqlInterval<CqlDateTime>> cf_ = context.Operators.SortBy<CqlInterval<CqlDateTime>>(cd_, ce_, System.ComponentModel.ListSortDirection.Ascending);
            CqlInterval<CqlDateTime> cg_ = context.Operators.First<CqlInterval<CqlDateTime>>(cf_);
            CqlDateTime ch_ = context.Operators.End(cg_);
            CqlDateTime[] ci_ = [
                at_,
                bn_,
                ch_,
            ];
            CqlDateTime cj_ = context.Operators.Min<CqlDateTime>((IEnumerable<CqlDateTime>)ci_);
            return cj_;
        }

        IEnumerable<CqlDateTime> j_ = context.Operators.Select<MedicationRequest, CqlDateTime>(h_, i_);
        IEnumerable<CqlDateTime> k_ = context.Operators.Distinct<CqlDateTime>(j_);
        return k_;
    }


    [CqlExpressionDefinition("Androgen Deprivation Therapy for Urology Care Medication Order Start Dates")]
    public IEnumerable<CqlDateTime> Androgen_Deprivation_Therapy_for_Urology_Care_Medication_Order_Start_Dates(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Androgen_Deprivation_Therapy_for_Urology_Care_Medication_Order_Start_Dates, Androgen_Deprivation_Therapy_for_Urology_Care_Medication_Order_Start_Dates_Compute);

    private const long _cacheIndex_Androgen_Deprivation_Therapy_for_Urology_Care_Medication_Order_Start_Dates = -824991662083256949L;

    private IEnumerable<CqlDateTime> Androgen_Deprivation_Therapy_for_Urology_Care_Medication_Order_Start_Dates_Compute(CqlContext context)
    {
        CqlValueSet a_ = this.Androgen_Deprivation_Therapy_for_Urology_Care(context);
        IEnumerable<MedicationRequest> b_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> c_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));

        bool? d_(MedicationRequest MR) {
            IEnumerable<Medication> l_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));

            bool? m_(Medication M) {
                object p_ = context.Operators.LateBoundProperty<object>(M, "id.value");
                object q_ = context.Operators.LateBoundProperty<object>(MR, "medication.reference.value");
                IEnumerable<string> r_ = context.Operators.Split((string)q_, "/");
                string s_ = context.Operators.Last<string>(r_);
                bool? t_ = context.Operators.Equal(p_, s_);
                CodeableConcept u_ = M?.Code;
                CqlConcept v_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, u_);
                CqlValueSet w_ = this.Androgen_Deprivation_Therapy_for_Urology_Care(context);
                bool? x_ = context.Operators.ConceptInValueSet(v_, w_);
                bool? y_ = context.Operators.And(t_, x_);
                return y_;
            }

            IEnumerable<Medication> n_ = context.Operators.Where<Medication>(l_, m_);
            bool? o_ = context.Operators.Exists<Medication>(n_);
            return o_;
        }

        IEnumerable<MedicationRequest> e_ = context.Operators.Where<MedicationRequest>(c_, d_);
        IEnumerable<MedicationRequest> f_ = context.Operators.Union<MedicationRequest>(b_, e_);

        bool? g_(MedicationRequest ADTOrder) {
            Code<MedicationRequest.MedicationrequestStatus> z_ = ADTOrder?.StatusElement;
            MedicationRequest.MedicationrequestStatus? aa_ = z_?.Value;
            string ab_ = context.Operators.Convert<string>(aa_);
            string[] ac_ = [
                "active",
                "completed",
            ];
            bool? ad_ = context.Operators.In<string>(ab_, (IEnumerable<string>)ac_);
            Code<MedicationRequest.MedicationRequestIntent> ae_ = ADTOrder?.IntentElement;
            MedicationRequest.MedicationRequestIntent? af_ = ae_?.Value;
            string ag_ = context.Operators.Convert<string>(af_);
            string[] ah_ = [
                "order",
                "original-order",
                "reflex-order",
                "filler-order",
                "instance-order",
            ];
            bool? ai_ = context.Operators.In<string>(ag_, (IEnumerable<string>)ah_);
            bool? aj_ = context.Operators.And(ad_, ai_);
            return aj_;
        }

        IEnumerable<MedicationRequest> h_ = context.Operators.Where<MedicationRequest>(f_, g_);

        CqlDateTime i_(MedicationRequest ADTOrder) {
            FhirDateTime ak_ = ADTOrder?.AuthoredOnElement;
            CqlDateTime al_ = context.Operators.Convert<CqlDateTime>(ak_);
            List<Dosage> am_ = ADTOrder?.DosageInstruction;

            bool? an_(Dosage @this) {
                Timing cd_ = @this?.Timing;
                bool? ce_ = context.Operators.Not((bool?)(cd_ is null));
                return ce_;
            }

            IEnumerable<Dosage> ao_ = context.Operators.Where<Dosage>((IEnumerable<Dosage>)am_, an_);

            Timing ap_(Dosage @this) {
                Timing cf_ = @this?.Timing;
                return cf_;
            }

            IEnumerable<Timing> aq_ = context.Operators.Select<Dosage, Timing>(ao_, ap_);

            bool? ar_(Timing @this) {
                Timing.RepeatComponent cg_ = @this?.Repeat;
                bool? ch_ = context.Operators.Not((bool?)(cg_ is null));
                return ch_;
            }

            IEnumerable<Timing> as_ = context.Operators.Where<Timing>(aq_, ar_);

            Timing.RepeatComponent at_(Timing @this) {
                Timing.RepeatComponent ci_ = @this?.Repeat;
                return ci_;
            }

            IEnumerable<Timing.RepeatComponent> au_ = context.Operators.Select<Timing, Timing.RepeatComponent>(as_, at_);

            bool? av_(Timing.RepeatComponent @this) {
                DataType cj_ = @this?.Bounds;
                object ck_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cj_);
                bool? cl_ = context.Operators.Not((bool?)(ck_ is null));
                return cl_;
            }

            IEnumerable<Timing.RepeatComponent> aw_ = context.Operators.Where<Timing.RepeatComponent>(au_, av_);

            object ax_(Timing.RepeatComponent @this) {
                DataType cm_ = @this?.Bounds;
                object cn_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cm_);
                return cn_;
            }

            IEnumerable<object> ay_ = context.Operators.Select<Timing.RepeatComponent, object>(aw_, ax_);

            CqlInterval<CqlDateTime> az_(object DoseTime) {
                CqlInterval<CqlDateTime> co_ = QICoreCommon_4_0_000.Instance.toInterval(context, DoseTime);
                return co_;
            }

            IEnumerable<CqlInterval<CqlDateTime>> ba_ = context.Operators.Select<object, CqlInterval<CqlDateTime>>(ay_, az_);
            IEnumerable<CqlInterval<CqlDateTime>> bb_ = context.Operators.Distinct<CqlInterval<CqlDateTime>>(ba_);
            IEnumerable<CqlInterval<CqlDateTime>> bc_ = context.Operators.Collapse(bb_, (string)default);

            object bd_(CqlInterval<CqlDateTime> @this) {
                CqlDateTime cp_ = context.Operators.Start(@this);
                return cp_;
            }

            IEnumerable<CqlInterval<CqlDateTime>> be_ = context.Operators.SortBy<CqlInterval<CqlDateTime>>(bc_, bd_, System.ComponentModel.ListSortDirection.Ascending);
            CqlInterval<CqlDateTime> bf_ = context.Operators.First<CqlInterval<CqlDateTime>>(be_);
            CqlDateTime bg_ = context.Operators.Start(bf_);

            bool? bh_(Dosage @this) {
                Timing cq_ = @this?.Timing;
                bool? cr_ = context.Operators.Not((bool?)(cq_ is null));
                return cr_;
            }

            IEnumerable<Dosage> bi_ = context.Operators.Where<Dosage>((IEnumerable<Dosage>)am_, bh_);

            Timing bj_(Dosage @this) {
                Timing cs_ = @this?.Timing;
                return cs_;
            }

            IEnumerable<Timing> bk_ = context.Operators.Select<Dosage, Timing>(bi_, bj_);

            bool? bl_(Timing @this) {
                Timing.RepeatComponent ct_ = @this?.Repeat;
                bool? cu_ = context.Operators.Not((bool?)(ct_ is null));
                return cu_;
            }

            IEnumerable<Timing> bm_ = context.Operators.Where<Timing>(bk_, bl_);

            Timing.RepeatComponent bn_(Timing @this) {
                Timing.RepeatComponent cv_ = @this?.Repeat;
                return cv_;
            }

            IEnumerable<Timing.RepeatComponent> bo_ = context.Operators.Select<Timing, Timing.RepeatComponent>(bm_, bn_);

            bool? bp_(Timing.RepeatComponent @this) {
                DataType cw_ = @this?.Bounds;
                object cx_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cw_);
                bool? cy_ = context.Operators.Not((bool?)(cx_ is null));
                return cy_;
            }

            IEnumerable<Timing.RepeatComponent> bq_ = context.Operators.Where<Timing.RepeatComponent>(bo_, bp_);

            object br_(Timing.RepeatComponent @this) {
                DataType cz_ = @this?.Bounds;
                object da_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cz_);
                return da_;
            }

            IEnumerable<object> bs_ = context.Operators.Select<Timing.RepeatComponent, object>(bq_, br_);

            CqlInterval<CqlDateTime> bt_(object DoseTime) {
                CqlInterval<CqlDateTime> db_ = QICoreCommon_4_0_000.Instance.toInterval(context, DoseTime);
                return db_;
            }

            IEnumerable<CqlInterval<CqlDateTime>> bu_ = context.Operators.Select<object, CqlInterval<CqlDateTime>>(bs_, bt_);
            IEnumerable<CqlInterval<CqlDateTime>> bv_ = context.Operators.Distinct<CqlInterval<CqlDateTime>>(bu_);
            IEnumerable<CqlInterval<CqlDateTime>> bw_ = context.Operators.Collapse(bv_, (string)default);

            object bx_(CqlInterval<CqlDateTime> @this) {
                CqlDateTime dc_ = context.Operators.Start(@this);
                return dc_;
            }

            IEnumerable<CqlInterval<CqlDateTime>> by_ = context.Operators.SortBy<CqlInterval<CqlDateTime>>(bw_, bx_, System.ComponentModel.ListSortDirection.Ascending);
            CqlInterval<CqlDateTime> bz_ = context.Operators.First<CqlInterval<CqlDateTime>>(by_);
            CqlDateTime ca_ = context.Operators.End(bz_);
            CqlDateTime[] cb_ = [
                al_,
                bg_,
                ca_,
            ];
            CqlDateTime cc_ = context.Operators.Min<CqlDateTime>((IEnumerable<CqlDateTime>)cb_);
            return cc_;
        }

        IEnumerable<CqlDateTime> j_ = context.Operators.Select<MedicationRequest, CqlDateTime>(h_, i_);
        IEnumerable<CqlDateTime> k_ = context.Operators.Distinct<CqlDateTime>(j_);
        return k_;
    }


    [CqlFunctionDefinition("isVerified")]
    [CqlTag("description", "Returns true if the given condition either has no verification status or has a verification status of confirmed, unconfirmed, provisional, or differential")]
    public bool? isVerified(CqlContext context, Condition condition)
    {
        CodeableConcept a_ = condition?.VerificationStatus;
        CqlConcept b_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, a_);
        bool? c_ = context.Operators.Not((bool?)(b_ is null));
        CqlCode d_ = QICoreCommon_4_0_000.Instance.confirmed(context);
        CqlConcept e_ = context.Operators.ConvertCodeToConcept(d_);
        bool? f_ = context.Operators.Equivalent(b_, e_);
        CqlCode g_ = QICoreCommon_4_0_000.Instance.unconfirmed(context);
        CqlConcept h_ = context.Operators.ConvertCodeToConcept(g_);
        bool? i_ = context.Operators.Equivalent(b_, h_);
        bool? j_ = context.Operators.Or(f_, i_);
        CqlCode k_ = QICoreCommon_4_0_000.Instance.provisional(context);
        CqlConcept l_ = context.Operators.ConvertCodeToConcept(k_);
        bool? m_ = context.Operators.Equivalent(b_, l_);
        bool? n_ = context.Operators.Or(j_, m_);
        CqlCode o_ = QICoreCommon_4_0_000.Instance.differential(context);
        CqlConcept p_ = context.Operators.ConvertCodeToConcept(o_);
        bool? q_ = context.Operators.Equivalent(b_, p_);
        bool? r_ = context.Operators.Or(n_, q_);
        bool? s_ = context.Operators.Implies(c_, r_);
        return s_;
    }


    [CqlExpressionDefinition("Prostate Cancer Diagnosis")]
    public IEnumerable<Condition> Prostate_Cancer_Diagnosis(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Prostate_Cancer_Diagnosis, Prostate_Cancer_Diagnosis_Compute);

    private const long _cacheIndex_Prostate_Cancer_Diagnosis = 7940642882909434117L;

    private IEnumerable<Condition> Prostate_Cancer_Diagnosis_Compute(CqlContext context)
    {
        CqlValueSet a_ = this.Prostate_Cancer(context);
        IEnumerable<Condition> b_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-problems-health-concerns"));
        IEnumerable<Condition> c_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-encounter-diagnosis"));
        IEnumerable<Condition> d_ = context.Operators.Union<Condition>(b_ as IEnumerable<Condition>, c_ as IEnumerable<Condition>);

        bool? e_(Condition ProstateCancer) {
            CqlInterval<CqlDateTime> g_ = QICoreCommon_4_0_000.Instance.prevalenceInterval(context, ProstateCancer);
            CqlInterval<CqlDateTime> h_ = this.Measurement_Period(context);
            bool? i_ = context.Operators.Overlaps(g_, h_, "day");
            bool? j_ = this.isVerified(context, ProstateCancer);
            bool? k_ = context.Operators.And(i_, j_);
            return k_;
        }

        IEnumerable<Condition> f_ = context.Operators.Where<Condition>(d_, e_);
        return f_;
    }


    [CqlExpressionDefinition("First ADT in 3 Months Before to 9 Months After Start of Measurement Period")]
    public CqlDateTime First_ADT_in_3_Months_Before_to_9_Months_After_Start_of_Measurement_Period(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_First_ADT_in_3_Months_Before_to_9_Months_After_Start_of_Measurement_Period, First_ADT_in_3_Months_Before_to_9_Months_After_Start_of_Measurement_Period_Compute);

    private const long _cacheIndex_First_ADT_in_3_Months_Before_to_9_Months_After_Start_of_Measurement_Period = 6162761711183070057L;

    private CqlDateTime First_ADT_in_3_Months_Before_to_9_Months_After_Start_of_Measurement_Period_Compute(CqlContext context)
    {
        IEnumerable<CqlDateTime> a_ = this.Androgen_Deprivation_Therapy_for_Urology_Care_Medication_Active_Start_Dates(context);
        IEnumerable<CqlDateTime> b_ = this.Androgen_Deprivation_Therapy_for_Urology_Care_Medication_Order_Start_Dates(context);
        IEnumerable<CqlDateTime> c_ = context.Operators.Union<CqlDateTime>(a_, b_);

        bool? d_(CqlDateTime ADTDateTime) {
            IEnumerable<Condition> h_ = this.Prostate_Cancer_Diagnosis(context);

            bool? i_(Condition ProstateCancer) {
                CqlInterval<CqlDateTime> l_ = QICoreCommon_4_0_000.Instance.prevalenceInterval(context, ProstateCancer);
                bool? m_ = context.Operators.In<CqlDateTime>(ADTDateTime, l_, "day");
                CqlInterval<CqlDateTime> n_ = this.Measurement_Period(context);
                CqlDateTime o_ = context.Operators.Start(n_);
                CqlQuantity p_ = context.Operators.Quantity(3m, "months");
                CqlDateTime q_ = context.Operators.Subtract(o_, p_);
                CqlQuantity r_ = context.Operators.Quantity(9m, "months");
                CqlDateTime s_ = context.Operators.Add(o_, r_);
                CqlInterval<CqlDateTime> t_ = context.Operators.Interval(q_, s_, true, true);
                bool? u_ = context.Operators.In<CqlDateTime>(ADTDateTime, t_, "day");
                bool? v_ = context.Operators.And(m_, u_);
                return v_;
            }

            IEnumerable<Condition> j_ = context.Operators.Where<Condition>(h_, i_);
            bool? k_ = context.Operators.Exists<Condition>(j_);
            return k_;
        }

        IEnumerable<CqlDateTime> e_ = context.Operators.Where<CqlDateTime>(c_, d_);
        IEnumerable<CqlDateTime> f_ = context.Operators.ListSort<CqlDateTime>(e_, System.ComponentModel.ListSortDirection.Ascending);
        CqlDateTime g_ = context.Operators.First<CqlDateTime>(f_);
        return g_;
    }


    [CqlExpressionDefinition("Order for 12 Months of ADT in 3 Months Before to 9 Months After Start of Measurement Period")]
    public IEnumerable<ServiceRequest> Order_for_12_Months_of_ADT_in_3_Months_Before_to_9_Months_After_Start_of_Measurement_Period(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Order_for_12_Months_of_ADT_in_3_Months_Before_to_9_Months_After_Start_of_Measurement_Period, Order_for_12_Months_of_ADT_in_3_Months_Before_to_9_Months_After_Start_of_Measurement_Period_Compute);

    private const long _cacheIndex_Order_for_12_Months_of_ADT_in_3_Months_Before_to_9_Months_After_Start_of_Measurement_Period = -4992427232410550119L;

    private IEnumerable<ServiceRequest> Order_for_12_Months_of_ADT_in_3_Months_Before_to_9_Months_After_Start_of_Measurement_Period_Compute(CqlContext context)
    {
        CqlCode a_ = this.Injection_of_leuprolide_acetate_for_twelve_month_period__regime_therapy_(context);
        IEnumerable<CqlCode> b_ = context.Operators.ToList<CqlCode>(a_);
        IEnumerable<ServiceRequest> c_ = context.Operators.Retrieve<ServiceRequest>(new RetrieveParameters(default, default, b_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-servicerequest"));

        bool? d_(ServiceRequest OrderTwelveMonthADT) {
            CqlDateTime f_ = this.First_ADT_in_3_Months_Before_to_9_Months_After_Start_of_Measurement_Period(context);
            CqlDateTime[] g_ = [
                f_,
            ];

            bool? h_(CqlDateTime FirstADTMP) {
                FhirDateTime k_ = OrderTwelveMonthADT?.AuthoredOnElement;
                CqlDateTime l_ = context.Operators.Convert<CqlDateTime>(k_);
                bool? m_ = context.Operators.SameOrAfter(l_, FirstADTMP, "day");
                CqlInterval<CqlDateTime> n_ = this.Measurement_Period(context);
                CqlDateTime o_ = context.Operators.Start(n_);
                CqlQuantity p_ = context.Operators.Quantity(3m, "months");
                CqlDateTime q_ = context.Operators.Subtract(o_, p_);
                CqlQuantity r_ = context.Operators.Quantity(9m, "months");
                CqlDateTime s_ = context.Operators.Add(o_, r_);
                CqlInterval<CqlDateTime> t_ = context.Operators.Interval(q_, s_, true, true);
                bool? u_ = context.Operators.In<CqlDateTime>(l_, t_, "day");
                bool? v_ = context.Operators.And(m_, u_);
                Code<RequestStatus> w_ = OrderTwelveMonthADT?.StatusElement;
                RequestStatus? x_ = w_?.Value;
                Code<RequestStatus> y_ = context.Operators.Convert<Code<RequestStatus>>(x_);
                string z_ = context.Operators.Convert<string>(y_);
                string[] aa_ = [
                    "active",
                    "completed",
                ];
                bool? ab_ = context.Operators.In<string>(z_, (IEnumerable<string>)aa_);
                bool? ac_ = context.Operators.And(v_, ab_);
                Code<RequestIntent> ad_ = OrderTwelveMonthADT?.IntentElement;
                RequestIntent? ae_ = ad_?.Value;
                Code<RequestIntent> af_ = context.Operators.Convert<Code<RequestIntent>>(ae_);
                bool? ag_ = context.Operators.Equal(af_, "order");
                bool? ah_ = context.Operators.And(ac_, ag_);
                return ah_;
            }

            IEnumerable<CqlDateTime> i_ = context.Operators.Where<CqlDateTime>((IEnumerable<CqlDateTime>)g_, h_);
            bool? j_ = context.Operators.Exists<CqlDateTime>(i_);
            return j_;
        }

        IEnumerable<ServiceRequest> e_ = context.Operators.Where<ServiceRequest>(c_, d_);
        return e_;
    }


    [CqlExpressionDefinition("Initial Population")]
    public bool? Initial_Population(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Initial_Population, Initial_Population_Compute);

    private const long _cacheIndex_Initial_Population = 8108627335331730539L;

    private bool? Initial_Population_Compute(CqlContext context)
    {
        bool? a_ = this.Has_Qualifying_Encounter(context);
        IEnumerable<ServiceRequest> b_ = this.Order_for_12_Months_of_ADT_in_3_Months_Before_to_9_Months_After_Start_of_Measurement_Period(context);
        bool? c_ = context.Operators.Exists<ServiceRequest>(b_);
        bool? d_ = context.Operators.And(a_, c_);
        return d_;
    }


    [CqlExpressionDefinition("Denominator")]
    public bool? Denominator(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Denominator, Denominator_Compute);

    private const long _cacheIndex_Denominator = 7675616901970093677L;

    private bool? Denominator_Compute(CqlContext context)
    {
        bool? a_ = this.Initial_Population(context);
        return a_;
    }


    [CqlExpressionDefinition("Has Baseline DEXA Scan Two Years Prior to the Start of or Less than Three Months After the Start of ADT")]
    public bool? Has_Baseline_DEXA_Scan_Two_Years_Prior_to_the_Start_of_or_Less_than_Three_Months_After_the_Start_of_ADT(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Has_Baseline_DEXA_Scan_Two_Years_Prior_to_the_Start_of_or_Less_than_Three_Months_After_the_Start_of_ADT, Has_Baseline_DEXA_Scan_Two_Years_Prior_to_the_Start_of_or_Less_than_Three_Months_After_the_Start_of_ADT_Compute);

    private const long _cacheIndex_Has_Baseline_DEXA_Scan_Two_Years_Prior_to_the_Start_of_or_Less_than_Three_Months_After_the_Start_of_ADT = -2102955111071554229L;

    private bool? Has_Baseline_DEXA_Scan_Two_Years_Prior_to_the_Start_of_or_Less_than_Three_Months_After_the_Start_of_ADT_Compute(CqlContext context)
    {
        CqlValueSet a_ = this.DEXA_Bone_Density_for_Urology_Care(context);
        IEnumerable<ServiceRequest> b_ = context.Operators.Retrieve<ServiceRequest>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-servicerequest"));

        bool? c_(ServiceRequest DEXAOrdered) {
            IEnumerable<ServiceRequest> n_ = this.Order_for_12_Months_of_ADT_in_3_Months_Before_to_9_Months_After_Start_of_Measurement_Period(context);

            bool? o_(ServiceRequest OrderTwelveMonthsADT) {
                FhirDateTime r_ = DEXAOrdered?.AuthoredOnElement;
                CqlDateTime s_ = context.Operators.Convert<CqlDateTime>(r_);
                FhirDateTime t_ = OrderTwelveMonthsADT?.AuthoredOnElement;
                CqlDateTime u_ = context.Operators.Convert<CqlDateTime>(t_);
                CqlQuantity v_ = context.Operators.Quantity(3m, "months");
                CqlDateTime w_ = context.Operators.Add(u_, v_);
                CqlInterval<CqlDateTime> x_ = context.Operators.Interval(u_, w_, true, true);
                bool? y_ = context.Operators.In<CqlDateTime>(s_, x_, "day");
                bool? z_ = context.Operators.Not((bool?)(u_ is null));
                bool? aa_ = context.Operators.And(y_, z_);
                CqlQuantity ab_ = context.Operators.Quantity(2m, "years");
                CqlDateTime ac_ = context.Operators.Subtract(u_, ab_);
                CqlInterval<CqlDateTime> ad_ = context.Operators.Interval(ac_, u_, true, false);
                bool? ae_ = context.Operators.In<CqlDateTime>(s_, ad_, "day");
                bool? af_ = context.Operators.And(ae_, z_);
                bool? ag_ = context.Operators.Or(aa_, af_);
                return ag_;
            }

            IEnumerable<ServiceRequest> p_ = context.Operators.Where<ServiceRequest>(n_, o_);
            bool? q_ = context.Operators.Exists<ServiceRequest>(p_);
            return q_;
        }

        IEnumerable<ServiceRequest> d_ = context.Operators.Where<ServiceRequest>(b_, c_);

        bool? e_(ServiceRequest DEXAOrdered) {
            Code<RequestStatus> ah_ = DEXAOrdered?.StatusElement;
            RequestStatus? ai_ = ah_?.Value;
            Code<RequestStatus> aj_ = context.Operators.Convert<Code<RequestStatus>>(ai_);
            string ak_ = context.Operators.Convert<string>(aj_);
            string[] al_ = [
                "active",
                "completed",
            ];
            bool? am_ = context.Operators.In<string>(ak_, (IEnumerable<string>)al_);
            Code<RequestIntent> an_ = DEXAOrdered?.IntentElement;
            RequestIntent? ao_ = an_?.Value;
            Code<RequestIntent> ap_ = context.Operators.Convert<Code<RequestIntent>>(ao_);
            bool? aq_ = context.Operators.Equal(ap_, "order");
            bool? ar_ = context.Operators.And(am_, aq_);
            return ar_;
        }

        IEnumerable<ServiceRequest> f_ = context.Operators.Where<ServiceRequest>(d_, e_);
        IEnumerable<Observation> g_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation-clinical-result"));

        bool? h_(Observation DEXAPerformed) {
            IEnumerable<ServiceRequest> as_ = this.Order_for_12_Months_of_ADT_in_3_Months_Before_to_9_Months_After_Start_of_Measurement_Period(context);

            bool? at_(ServiceRequest OrderTwelveMonthsADT) {
                DataType aw_ = DEXAPerformed?.Effective;
                object ax_ = FHIRHelpers_4_4_000.Instance.ToValue(context, aw_);
                CqlInterval<CqlDateTime> ay_ = QICoreCommon_4_0_000.Instance.toInterval(context, ax_);
                CqlDateTime az_ = context.Operators.Start(ay_);
                FhirDateTime ba_ = OrderTwelveMonthsADT?.AuthoredOnElement;
                CqlDateTime bb_ = context.Operators.Convert<CqlDateTime>(ba_);
                CqlQuantity bc_ = context.Operators.Quantity(3m, "months");
                CqlDateTime bd_ = context.Operators.Add(bb_, bc_);
                CqlInterval<CqlDateTime> be_ = context.Operators.Interval(bb_, bd_, true, true);
                bool? bf_ = context.Operators.In<CqlDateTime>(az_, be_, "day");
                bool? bg_ = context.Operators.Not((bool?)(bb_ is null));
                bool? bh_ = context.Operators.And(bf_, bg_);
                CqlDateTime bi_ = context.Operators.End(ay_);
                CqlQuantity bj_ = context.Operators.Quantity(2m, "years");
                CqlDateTime bk_ = context.Operators.Subtract(bb_, bj_);
                CqlInterval<CqlDateTime> bl_ = context.Operators.Interval(bk_, bb_, true, false);
                bool? bm_ = context.Operators.In<CqlDateTime>(bi_, bl_, "day");
                bool? bn_ = context.Operators.And(bm_, bg_);
                bool? bo_ = context.Operators.Or(bh_, bn_);
                return bo_;
            }

            IEnumerable<ServiceRequest> au_ = context.Operators.Where<ServiceRequest>(as_, at_);
            bool? av_ = context.Operators.Exists<ServiceRequest>(au_);
            return av_;
        }

        IEnumerable<Observation> i_ = context.Operators.Where<Observation>(g_, h_);

        bool? j_(Observation DEXAPerformed) {
            Code<ObservationStatus> bp_ = DEXAPerformed?.StatusElement;
            ObservationStatus? bq_ = bp_?.Value;
            string br_ = context.Operators.Convert<string>(bq_);
            string[] bs_ = [
                "final",
                "amended",
                "corrected",
            ];
            bool? bt_ = context.Operators.In<string>(br_, (IEnumerable<string>)bs_);
            return bt_;
        }

        IEnumerable<Observation> k_ = context.Operators.Where<Observation>(i_, j_);
        IEnumerable<object> l_ = context.Operators.Union<object>(f_ as IEnumerable<object>, k_ as IEnumerable<object>);
        bool? m_ = context.Operators.Exists<object>(l_);
        return m_;
    }


    [CqlExpressionDefinition("Numerator")]
    public bool? Numerator(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Numerator, Numerator_Compute);

    private const long _cacheIndex_Numerator = 8957501733843970185L;

    private bool? Numerator_Compute(CqlContext context)
    {
        bool? a_ = this.Has_Baseline_DEXA_Scan_Two_Years_Prior_to_the_Start_of_or_Less_than_Three_Months_After_the_Start_of_ADT(context);
        return a_;
    }


    [CqlExpressionDefinition("No Bone Density Scan Ordered Due to Patient Refusal")]
    public IEnumerable<ServiceRequest> No_Bone_Density_Scan_Ordered_Due_to_Patient_Refusal(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_No_Bone_Density_Scan_Ordered_Due_to_Patient_Refusal, No_Bone_Density_Scan_Ordered_Due_to_Patient_Refusal_Compute);

    private const long _cacheIndex_No_Bone_Density_Scan_Ordered_Due_to_Patient_Refusal = 6622458788790457350L;

    private IEnumerable<ServiceRequest> No_Bone_Density_Scan_Ordered_Due_to_Patient_Refusal_Compute(CqlContext context)
    {
        CqlValueSet a_ = this.DEXA_Bone_Density_for_Urology_Care(context);
        IEnumerable<ServiceRequest> b_ = context.Operators.Retrieve<ServiceRequest>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-servicenotrequested"));
        IEnumerable<ServiceRequest> c_ = context.Operators.Union<ServiceRequest>(b_, b_);

        bool? d_(ServiceRequest DEXANotOrdered) {
            IEnumerable<ServiceRequest> f_ = this.Order_for_12_Months_of_ADT_in_3_Months_Before_to_9_Months_After_Start_of_Measurement_Period(context);

            bool? g_(ServiceRequest OrderTwelveMonthsADT) {
                FhirDateTime j_ = DEXANotOrdered?.AuthoredOnElement;
                CqlDateTime k_ = context.Operators.Convert<CqlDateTime>(j_);
                FhirDateTime l_ = OrderTwelveMonthsADT?.AuthoredOnElement;
                CqlDateTime m_ = context.Operators.Convert<CqlDateTime>(l_);
                CqlQuantity n_ = context.Operators.Quantity(3m, "months");
                CqlDateTime o_ = context.Operators.Add(m_, n_);
                CqlInterval<CqlDateTime> p_ = context.Operators.Interval(m_, o_, true, true);
                bool? q_ = context.Operators.In<CqlDateTime>(k_, p_, "day");
                bool? r_ = context.Operators.Not((bool?)(m_ is null));
                bool? s_ = context.Operators.And(q_, r_);

                bool? t_(Extension @this) {
                    FhirUri ac_ = @this?.UrlElement;
                    string ad_ = FHIRHelpers_4_4_000.Instance.ToString(context, ac_);
                    bool? ae_ = context.Operators.Equal(ad_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-doNotPerformReason");
                    return ae_;
                }

                IEnumerable<Extension> u_ = context.Operators.Where<Extension>((IEnumerable<Extension>)(DEXANotOrdered is DomainResource
                    ? (DEXANotOrdered as DomainResource).Extension
                    : default), t_);

                object v_(Extension @this) {
                    DataType af_ = @this?.Value;
                    return af_;
                }

                IEnumerable<object> w_ = context.Operators.Select<Extension, object>(u_, v_);
                object x_ = context.Operators.SingletonFrom<object>(w_);
                CqlConcept y_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, x_ as CodeableConcept);
                CqlValueSet z_ = this.Patient_Declined(context);
                bool? aa_ = context.Operators.ConceptInValueSet(y_, z_);
                bool? ab_ = context.Operators.And(s_, aa_);
                return ab_;
            }

            IEnumerable<ServiceRequest> h_ = context.Operators.Where<ServiceRequest>(f_, g_);
            bool? i_ = context.Operators.Exists<ServiceRequest>(h_);
            return i_;
        }

        IEnumerable<ServiceRequest> e_ = context.Operators.Where<ServiceRequest>(c_, d_);
        return e_;
    }


    [CqlExpressionDefinition("No Bone Density Scan Performed Due to Patient Refusal")]
    public IEnumerable<Observation> No_Bone_Density_Scan_Performed_Due_to_Patient_Refusal(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_No_Bone_Density_Scan_Performed_Due_to_Patient_Refusal, No_Bone_Density_Scan_Performed_Due_to_Patient_Refusal_Compute);

    private const long _cacheIndex_No_Bone_Density_Scan_Performed_Due_to_Patient_Refusal = -3751061519719478956L;

    private IEnumerable<Observation> No_Bone_Density_Scan_Performed_Due_to_Patient_Refusal_Compute(CqlContext context)
    {
        CqlValueSet a_ = this.DEXA_Bone_Density_for_Urology_Care(context);
        IEnumerable<Observation> b_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observationcancelled"));
        IEnumerable<Observation> c_ = context.Operators.Union<Observation>(b_, b_);

        bool? d_(Observation DEXANotPerformed) {
            IEnumerable<ServiceRequest> f_ = this.Order_for_12_Months_of_ADT_in_3_Months_Before_to_9_Months_After_Start_of_Measurement_Period(context);

            bool? g_(ServiceRequest OrderTwelveMonthsADT) {
                Instant j_ = DEXANotPerformed?.IssuedElement;
                DateTimeOffset? k_ = j_?.Value;
                CqlDateTime l_ = context.Operators.Convert<CqlDateTime>(k_);
                FhirDateTime m_ = OrderTwelveMonthsADT?.AuthoredOnElement;
                CqlDateTime n_ = context.Operators.Convert<CqlDateTime>(m_);
                CqlQuantity o_ = context.Operators.Quantity(3m, "months");
                CqlDateTime p_ = context.Operators.Add(n_, o_);
                CqlInterval<CqlDateTime> q_ = context.Operators.Interval(n_, p_, true, true);
                bool? r_ = context.Operators.In<CqlDateTime>(l_, q_, "day");
                bool? s_ = context.Operators.Not((bool?)(n_ is null));
                bool? t_ = context.Operators.And(r_, s_);

                bool? u_(Extension @this) {
                    FhirUri ad_ = @this?.UrlElement;
                    string ae_ = FHIRHelpers_4_4_000.Instance.ToString(context, ad_);
                    bool? af_ = context.Operators.Equal(ae_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-notDoneReason");
                    return af_;
                }

                IEnumerable<Extension> v_ = context.Operators.Where<Extension>((IEnumerable<Extension>)(DEXANotPerformed is DomainResource
                    ? (DEXANotPerformed as DomainResource).Extension
                    : default), u_);

                object w_(Extension @this) {
                    DataType ag_ = @this?.Value;
                    return ag_;
                }

                IEnumerable<object> x_ = context.Operators.Select<Extension, object>(v_, w_);
                object y_ = context.Operators.SingletonFrom<object>(x_);
                CqlConcept z_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, y_ as CodeableConcept);
                CqlValueSet aa_ = this.Patient_Declined(context);
                bool? ab_ = context.Operators.ConceptInValueSet(z_, aa_);
                bool? ac_ = context.Operators.And(t_, ab_);
                return ac_;
            }

            IEnumerable<ServiceRequest> h_ = context.Operators.Where<ServiceRequest>(f_, g_);
            bool? i_ = context.Operators.Exists<ServiceRequest>(h_);
            return i_;
        }

        IEnumerable<Observation> e_ = context.Operators.Where<Observation>(c_, d_);
        return e_;
    }


    [CqlExpressionDefinition("Denominator Exception")]
    public bool? Denominator_Exception(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Denominator_Exception, Denominator_Exception_Compute);

    private const long _cacheIndex_Denominator_Exception = -7408022328034518701L;

    private bool? Denominator_Exception_Compute(CqlContext context)
    {
        IEnumerable<ServiceRequest> a_ = this.No_Bone_Density_Scan_Ordered_Due_to_Patient_Refusal(context);
        bool? b_ = context.Operators.Exists<ServiceRequest>(a_);
        IEnumerable<Observation> c_ = this.No_Bone_Density_Scan_Performed_Due_to_Patient_Refusal(context);
        bool? d_ = context.Operators.Exists<Observation>(c_);
        bool? e_ = context.Operators.Or(b_, d_);
        return e_;
    }


    [CqlExpressionDefinition("SDE Ethnicity")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Ethnicity(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_SDE_Ethnicity, SDE_Ethnicity_Compute);

    private const long _cacheIndex_SDE_Ethnicity = -897900695652524114L;

    private (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Ethnicity_Compute(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? a_ = SupplementalDataElements_5_1_000.Instance.SDE_Ethnicity(context);
        return a_;
    }


    [CqlExpressionDefinition("SDE Payer")]
    public IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> SDE_Payer(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_SDE_Payer, SDE_Payer_Compute);

    private const long _cacheIndex_SDE_Payer = -7384445363689136194L;

    private IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> SDE_Payer_Compute(CqlContext context)
    {
        IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> a_ = SupplementalDataElements_5_1_000.Instance.SDE_Payer(context);
        return a_;
    }


    [CqlExpressionDefinition("SDE Race")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Race(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_SDE_Race, SDE_Race_Compute);

    private const long _cacheIndex_SDE_Race = -136145099253049696L;

    private (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Race_Compute(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? a_ = SupplementalDataElements_5_1_000.Instance.SDE_Race(context);
        return a_;
    }


    [CqlExpressionDefinition("SDE Sex")]
    public CqlCode SDE_Sex(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_SDE_Sex, SDE_Sex_Compute);

    private const long _cacheIndex_SDE_Sex = 5984134809747202532L;

    private CqlCode SDE_Sex_Compute(CqlContext context)
    {
        CqlCode a_ = SupplementalDataElements_5_1_000.Instance.SDE_Sex(context);
        return a_;
    }


    #endregion Functions and Expressions

    #region Singleton Lifetime Members

    private CMS645FHIRBoneDensityPCADTherapy_1_0_000() {}

    public static CMS645FHIRBoneDensityPCADTherapy_1_0_000 Instance { get; } = new();

    #endregion

    #region ILibrary Implementation

    public string Name => "CMS645FHIRBoneDensityPCADTherapy";
    public string Version => "1.0.000";
    public ILibrary[] Dependencies => [FHIRHelpers_4_4_000.Instance, SupplementalDataElements_5_1_000.Instance, QICoreCommon_4_0_000.Instance];

    #endregion ILibrary Implementation

}

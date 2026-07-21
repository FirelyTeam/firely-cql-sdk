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
                Timing cm_ = @this?.Timing;
                bool? cn_ = context.Operators.Not((bool?)(cm_ is null));
                return cn_;
            }

            IEnumerable<Dosage> am_ = context.Operators.Where<Dosage>((IEnumerable<Dosage>)ak_, al_);

            Timing an_(Dosage @this) {
                Timing co_ = @this?.Timing;
                return co_;
            }

            IEnumerable<Timing> ao_ = context.Operators.Select<Dosage, Timing>(am_, an_);

            CqlDateTime ap_(Timing dosageTiming) {
                List<FhirDateTime> cp_ = dosageTiming?.EventElement;

                string cq_(FhirDateTime @this) {
                    string cw_ = @this?.Value;
                    return cw_;
                }

                IEnumerable<string> cr_ = context.Operators.Select<FhirDateTime, string>((IEnumerable<FhirDateTime>)cp_, cq_);

                CqlDateTime cs_(string @string) {
                    CqlDateTime cx_ = context.Operators.ConvertStringToDateTime(@string);
                    return cx_;
                }

                IEnumerable<CqlDateTime> ct_ = context.Operators.Select<string, CqlDateTime>(cr_, cs_);
                IEnumerable<CqlDateTime> cu_ = context.Operators.ListSort<CqlDateTime>(ct_, System.ComponentModel.ListSortDirection.Ascending);
                CqlDateTime cv_ = context.Operators.First<CqlDateTime>(cu_);
                return cv_;
            }

            IEnumerable<CqlDateTime> aq_ = context.Operators.Select<Timing, CqlDateTime>(ao_, ap_);
            IEnumerable<CqlDateTime> ar_ = context.Operators.Distinct<CqlDateTime>(aq_);
            IEnumerable<CqlDateTime> as_ = context.Operators.ListSort<CqlDateTime>(ar_, System.ComponentModel.ListSortDirection.Ascending);
            CqlDateTime at_ = context.Operators.First<CqlDateTime>(as_);

            bool? av_(Dosage @this) {
                Timing cy_ = @this?.Timing;
                bool? cz_ = context.Operators.Not((bool?)(cy_ is null));
                return cz_;
            }

            IEnumerable<Dosage> aw_ = context.Operators.Where<Dosage>((IEnumerable<Dosage>)ak_, av_);

            Timing ax_(Dosage @this) {
                Timing da_ = @this?.Timing;
                return da_;
            }

            IEnumerable<Timing> ay_ = context.Operators.Select<Dosage, Timing>(aw_, ax_);

            bool? az_(Timing @this) {
                Timing.RepeatComponent db_ = @this?.Repeat;
                bool? dc_ = context.Operators.Not((bool?)(db_ is null));
                return dc_;
            }

            IEnumerable<Timing> ba_ = context.Operators.Where<Timing>(ay_, az_);

            Timing.RepeatComponent bb_(Timing @this) {
                Timing.RepeatComponent dd_ = @this?.Repeat;
                return dd_;
            }

            IEnumerable<Timing.RepeatComponent> bc_ = context.Operators.Select<Timing, Timing.RepeatComponent>(ba_, bb_);

            bool? bd_(Timing.RepeatComponent @this) {
                DataType de_ = @this?.Bounds;
                object df_ = FHIRHelpers_4_4_000.Instance.ToValue(context, de_);
                bool? dg_ = context.Operators.Not((bool?)(df_ is null));
                return dg_;
            }

            IEnumerable<Timing.RepeatComponent> be_ = context.Operators.Where<Timing.RepeatComponent>(bc_, bd_);

            object bf_(Timing.RepeatComponent @this) {
                DataType dh_ = @this?.Bounds;
                object di_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dh_);
                return di_;
            }

            IEnumerable<object> bg_ = context.Operators.Select<Timing.RepeatComponent, object>(be_, bf_);

            CqlInterval<CqlDateTime> bh_(object DoseTime) {
                CqlInterval<CqlDateTime> dj_ = QICoreCommon_4_0_000.Instance.toInterval(context, DoseTime);
                return dj_;
            }

            IEnumerable<CqlInterval<CqlDateTime>> bi_ = context.Operators.Select<object, CqlInterval<CqlDateTime>>(bg_, bh_);
            IEnumerable<CqlInterval<CqlDateTime>> bj_ = context.Operators.Distinct<CqlInterval<CqlDateTime>>(bi_);
            IEnumerable<CqlInterval<CqlDateTime>> bk_ = context.Operators.Collapse(bj_, (string)default);

            object bl_(CqlInterval<CqlDateTime> @this) {
                CqlDateTime dk_ = context.Operators.Start(@this);
                return dk_;
            }

            IEnumerable<CqlInterval<CqlDateTime>> bm_ = context.Operators.SortBy<CqlInterval<CqlDateTime>>(bk_, bl_, System.ComponentModel.ListSortDirection.Ascending);
            CqlInterval<CqlDateTime> bn_ = context.Operators.First<CqlInterval<CqlDateTime>>(bm_);
            CqlDateTime bo_ = context.Operators.Start(bn_);

            bool? bq_(Dosage @this) {
                Timing dl_ = @this?.Timing;
                bool? dm_ = context.Operators.Not((bool?)(dl_ is null));
                return dm_;
            }

            IEnumerable<Dosage> br_ = context.Operators.Where<Dosage>((IEnumerable<Dosage>)ak_, bq_);

            Timing bs_(Dosage @this) {
                Timing dn_ = @this?.Timing;
                return dn_;
            }

            IEnumerable<Timing> bt_ = context.Operators.Select<Dosage, Timing>(br_, bs_);

            bool? bu_(Timing @this) {
                Timing.RepeatComponent do_ = @this?.Repeat;
                bool? dp_ = context.Operators.Not((bool?)(do_ is null));
                return dp_;
            }

            IEnumerable<Timing> bv_ = context.Operators.Where<Timing>(bt_, bu_);

            Timing.RepeatComponent bw_(Timing @this) {
                Timing.RepeatComponent dq_ = @this?.Repeat;
                return dq_;
            }

            IEnumerable<Timing.RepeatComponent> bx_ = context.Operators.Select<Timing, Timing.RepeatComponent>(bv_, bw_);

            bool? by_(Timing.RepeatComponent @this) {
                DataType dr_ = @this?.Bounds;
                object ds_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dr_);
                bool? dt_ = context.Operators.Not((bool?)(ds_ is null));
                return dt_;
            }

            IEnumerable<Timing.RepeatComponent> bz_ = context.Operators.Where<Timing.RepeatComponent>(bx_, by_);

            object ca_(Timing.RepeatComponent @this) {
                DataType du_ = @this?.Bounds;
                object dv_ = FHIRHelpers_4_4_000.Instance.ToValue(context, du_);
                return dv_;
            }

            IEnumerable<object> cb_ = context.Operators.Select<Timing.RepeatComponent, object>(bz_, ca_);

            CqlInterval<CqlDateTime> cc_(object DoseTime) {
                CqlInterval<CqlDateTime> dw_ = QICoreCommon_4_0_000.Instance.toInterval(context, DoseTime);
                return dw_;
            }

            IEnumerable<CqlInterval<CqlDateTime>> cd_ = context.Operators.Select<object, CqlInterval<CqlDateTime>>(cb_, cc_);
            IEnumerable<CqlInterval<CqlDateTime>> ce_ = context.Operators.Distinct<CqlInterval<CqlDateTime>>(cd_);
            IEnumerable<CqlInterval<CqlDateTime>> cf_ = context.Operators.Collapse(ce_, (string)default);

            object cg_(CqlInterval<CqlDateTime> @this) {
                CqlDateTime dx_ = context.Operators.Start(@this);
                return dx_;
            }

            IEnumerable<CqlInterval<CqlDateTime>> ch_ = context.Operators.SortBy<CqlInterval<CqlDateTime>>(cf_, cg_, System.ComponentModel.ListSortDirection.Ascending);
            CqlInterval<CqlDateTime> ci_ = context.Operators.First<CqlInterval<CqlDateTime>>(ch_);
            CqlDateTime cj_ = context.Operators.End(ci_);
            CqlDateTime[] ck_ = [
                at_,
                bo_,
                cj_,
            ];
            CqlDateTime cl_ = context.Operators.Min<CqlDateTime>((IEnumerable<CqlDateTime>)ck_);
            return cl_;
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
                Timing ce_ = @this?.Timing;
                bool? cf_ = context.Operators.Not((bool?)(ce_ is null));
                return cf_;
            }

            IEnumerable<Dosage> ao_ = context.Operators.Where<Dosage>((IEnumerable<Dosage>)am_, an_);

            Timing ap_(Dosage @this) {
                Timing cg_ = @this?.Timing;
                return cg_;
            }

            IEnumerable<Timing> aq_ = context.Operators.Select<Dosage, Timing>(ao_, ap_);

            bool? ar_(Timing @this) {
                Timing.RepeatComponent ch_ = @this?.Repeat;
                bool? ci_ = context.Operators.Not((bool?)(ch_ is null));
                return ci_;
            }

            IEnumerable<Timing> as_ = context.Operators.Where<Timing>(aq_, ar_);

            Timing.RepeatComponent at_(Timing @this) {
                Timing.RepeatComponent cj_ = @this?.Repeat;
                return cj_;
            }

            IEnumerable<Timing.RepeatComponent> au_ = context.Operators.Select<Timing, Timing.RepeatComponent>(as_, at_);

            bool? av_(Timing.RepeatComponent @this) {
                DataType ck_ = @this?.Bounds;
                object cl_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ck_);
                bool? cm_ = context.Operators.Not((bool?)(cl_ is null));
                return cm_;
            }

            IEnumerable<Timing.RepeatComponent> aw_ = context.Operators.Where<Timing.RepeatComponent>(au_, av_);

            object ax_(Timing.RepeatComponent @this) {
                DataType cn_ = @this?.Bounds;
                object co_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cn_);
                return co_;
            }

            IEnumerable<object> ay_ = context.Operators.Select<Timing.RepeatComponent, object>(aw_, ax_);

            CqlInterval<CqlDateTime> az_(object DoseTime) {
                CqlInterval<CqlDateTime> cp_ = QICoreCommon_4_0_000.Instance.toInterval(context, DoseTime);
                return cp_;
            }

            IEnumerable<CqlInterval<CqlDateTime>> ba_ = context.Operators.Select<object, CqlInterval<CqlDateTime>>(ay_, az_);
            IEnumerable<CqlInterval<CqlDateTime>> bb_ = context.Operators.Distinct<CqlInterval<CqlDateTime>>(ba_);
            IEnumerable<CqlInterval<CqlDateTime>> bc_ = context.Operators.Collapse(bb_, (string)default);

            object bd_(CqlInterval<CqlDateTime> @this) {
                CqlDateTime cq_ = context.Operators.Start(@this);
                return cq_;
            }

            IEnumerable<CqlInterval<CqlDateTime>> be_ = context.Operators.SortBy<CqlInterval<CqlDateTime>>(bc_, bd_, System.ComponentModel.ListSortDirection.Ascending);
            CqlInterval<CqlDateTime> bf_ = context.Operators.First<CqlInterval<CqlDateTime>>(be_);
            CqlDateTime bg_ = context.Operators.Start(bf_);

            bool? bi_(Dosage @this) {
                Timing cr_ = @this?.Timing;
                bool? cs_ = context.Operators.Not((bool?)(cr_ is null));
                return cs_;
            }

            IEnumerable<Dosage> bj_ = context.Operators.Where<Dosage>((IEnumerable<Dosage>)am_, bi_);

            Timing bk_(Dosage @this) {
                Timing ct_ = @this?.Timing;
                return ct_;
            }

            IEnumerable<Timing> bl_ = context.Operators.Select<Dosage, Timing>(bj_, bk_);

            bool? bm_(Timing @this) {
                Timing.RepeatComponent cu_ = @this?.Repeat;
                bool? cv_ = context.Operators.Not((bool?)(cu_ is null));
                return cv_;
            }

            IEnumerable<Timing> bn_ = context.Operators.Where<Timing>(bl_, bm_);

            Timing.RepeatComponent bo_(Timing @this) {
                Timing.RepeatComponent cw_ = @this?.Repeat;
                return cw_;
            }

            IEnumerable<Timing.RepeatComponent> bp_ = context.Operators.Select<Timing, Timing.RepeatComponent>(bn_, bo_);

            bool? bq_(Timing.RepeatComponent @this) {
                DataType cx_ = @this?.Bounds;
                object cy_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cx_);
                bool? cz_ = context.Operators.Not((bool?)(cy_ is null));
                return cz_;
            }

            IEnumerable<Timing.RepeatComponent> br_ = context.Operators.Where<Timing.RepeatComponent>(bp_, bq_);

            object bs_(Timing.RepeatComponent @this) {
                DataType da_ = @this?.Bounds;
                object db_ = FHIRHelpers_4_4_000.Instance.ToValue(context, da_);
                return db_;
            }

            IEnumerable<object> bt_ = context.Operators.Select<Timing.RepeatComponent, object>(br_, bs_);

            CqlInterval<CqlDateTime> bu_(object DoseTime) {
                CqlInterval<CqlDateTime> dc_ = QICoreCommon_4_0_000.Instance.toInterval(context, DoseTime);
                return dc_;
            }

            IEnumerable<CqlInterval<CqlDateTime>> bv_ = context.Operators.Select<object, CqlInterval<CqlDateTime>>(bt_, bu_);
            IEnumerable<CqlInterval<CqlDateTime>> bw_ = context.Operators.Distinct<CqlInterval<CqlDateTime>>(bv_);
            IEnumerable<CqlInterval<CqlDateTime>> bx_ = context.Operators.Collapse(bw_, (string)default);

            object by_(CqlInterval<CqlDateTime> @this) {
                CqlDateTime dd_ = context.Operators.Start(@this);
                return dd_;
            }

            IEnumerable<CqlInterval<CqlDateTime>> bz_ = context.Operators.SortBy<CqlInterval<CqlDateTime>>(bx_, by_, System.ComponentModel.ListSortDirection.Ascending);
            CqlInterval<CqlDateTime> ca_ = context.Operators.First<CqlInterval<CqlDateTime>>(bz_);
            CqlDateTime cb_ = context.Operators.End(ca_);
            CqlDateTime[] cc_ = [
                al_,
                bg_,
                cb_,
            ];
            CqlDateTime cd_ = context.Operators.Min<CqlDateTime>((IEnumerable<CqlDateTime>)cc_);
            return cd_;
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
        CqlConcept e_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, a_);
        CqlCode f_ = QICoreCommon_4_0_000.Instance.confirmed(context);
        CqlConcept g_ = context.Operators.ConvertCodeToConcept(f_);
        bool? h_ = context.Operators.Equivalent(e_, g_);
        CqlConcept j_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, a_);
        CqlCode k_ = QICoreCommon_4_0_000.Instance.unconfirmed(context);
        CqlConcept l_ = context.Operators.ConvertCodeToConcept(k_);
        bool? m_ = context.Operators.Equivalent(j_, l_);
        bool? n_ = context.Operators.Or(h_, m_);
        CqlConcept p_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, a_);
        CqlCode q_ = QICoreCommon_4_0_000.Instance.provisional(context);
        CqlConcept r_ = context.Operators.ConvertCodeToConcept(q_);
        bool? s_ = context.Operators.Equivalent(p_, r_);
        bool? t_ = context.Operators.Or(n_, s_);
        CqlConcept v_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, a_);
        CqlCode w_ = QICoreCommon_4_0_000.Instance.differential(context);
        CqlConcept x_ = context.Operators.ConvertCodeToConcept(w_);
        bool? y_ = context.Operators.Equivalent(v_, x_);
        bool? z_ = context.Operators.Or(t_, y_);
        bool? aa_ = context.Operators.Implies(c_, z_);
        return aa_;
    }


    [CqlExpressionDefinition("Prostate Cancer Diagnosis")]
    public IEnumerable<Condition> Prostate_Cancer_Diagnosis(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Prostate_Cancer_Diagnosis, Prostate_Cancer_Diagnosis_Compute);

    private const long _cacheIndex_Prostate_Cancer_Diagnosis = 7940642882909434117L;

    private IEnumerable<Condition> Prostate_Cancer_Diagnosis_Compute(CqlContext context)
    {
        CqlValueSet a_ = this.Prostate_Cancer(context);
        IEnumerable<Condition> b_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-problems-health-concerns"));
        IEnumerable<Condition> d_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-encounter-diagnosis"));
        IEnumerable<Condition> e_ = context.Operators.Union<Condition>(b_ as IEnumerable<Condition>, d_ as IEnumerable<Condition>);

        bool? f_(Condition ProstateCancer) {
            CqlInterval<CqlDateTime> h_ = QICoreCommon_4_0_000.Instance.prevalenceInterval(context, ProstateCancer);
            CqlInterval<CqlDateTime> i_ = this.Measurement_Period(context);
            bool? j_ = context.Operators.Overlaps(h_, i_, "day");
            bool? k_ = this.isVerified(context, ProstateCancer);
            bool? l_ = context.Operators.And(j_, k_);
            return l_;
        }

        IEnumerable<Condition> g_ = context.Operators.Where<Condition>(e_, f_);
        return g_;
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
                CqlDateTime s_ = context.Operators.Start(n_);
                CqlQuantity t_ = context.Operators.Quantity(9m, "months");
                CqlDateTime u_ = context.Operators.Add(s_, t_);
                CqlInterval<CqlDateTime> v_ = context.Operators.Interval(q_, u_, true, true);
                bool? w_ = context.Operators.In<CqlDateTime>(ADTDateTime, v_, "day");
                bool? x_ = context.Operators.And(m_, w_);
                return x_;
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
                CqlDateTime o_ = context.Operators.Convert<CqlDateTime>(k_);
                CqlInterval<CqlDateTime> p_ = this.Measurement_Period(context);
                CqlDateTime q_ = context.Operators.Start(p_);
                CqlQuantity r_ = context.Operators.Quantity(3m, "months");
                CqlDateTime s_ = context.Operators.Subtract(q_, r_);
                CqlDateTime u_ = context.Operators.Start(p_);
                CqlQuantity v_ = context.Operators.Quantity(9m, "months");
                CqlDateTime w_ = context.Operators.Add(u_, v_);
                CqlInterval<CqlDateTime> x_ = context.Operators.Interval(s_, w_, true, true);
                bool? y_ = context.Operators.In<CqlDateTime>(o_, x_, "day");
                bool? z_ = context.Operators.And(m_, y_);
                Code<RequestStatus> aa_ = OrderTwelveMonthADT?.StatusElement;
                RequestStatus? ab_ = aa_?.Value;
                Code<RequestStatus> ac_ = context.Operators.Convert<Code<RequestStatus>>(ab_);
                string ad_ = context.Operators.Convert<string>(ac_);
                string[] ae_ = [
                    "active",
                    "completed",
                ];
                bool? af_ = context.Operators.In<string>(ad_, (IEnumerable<string>)ae_);
                bool? ag_ = context.Operators.And(z_, af_);
                Code<RequestIntent> ah_ = OrderTwelveMonthADT?.IntentElement;
                RequestIntent? ai_ = ah_?.Value;
                Code<RequestIntent> aj_ = context.Operators.Convert<Code<RequestIntent>>(ai_);
                bool? ak_ = context.Operators.Equal(aj_, "order");
                bool? al_ = context.Operators.And(ag_, ak_);
                return al_;
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
            IEnumerable<ServiceRequest> o_ = this.Order_for_12_Months_of_ADT_in_3_Months_Before_to_9_Months_After_Start_of_Measurement_Period(context);

            bool? p_(ServiceRequest OrderTwelveMonthsADT) {
                FhirDateTime s_ = DEXAOrdered?.AuthoredOnElement;
                CqlDateTime t_ = context.Operators.Convert<CqlDateTime>(s_);
                FhirDateTime u_ = OrderTwelveMonthsADT?.AuthoredOnElement;
                CqlDateTime v_ = context.Operators.Convert<CqlDateTime>(u_);
                CqlDateTime x_ = context.Operators.Convert<CqlDateTime>(u_);
                CqlQuantity y_ = context.Operators.Quantity(3m, "months");
                CqlDateTime z_ = context.Operators.Add(x_, y_);
                CqlInterval<CqlDateTime> aa_ = context.Operators.Interval(v_, z_, true, true);
                bool? ab_ = context.Operators.In<CqlDateTime>(t_, aa_, "day");
                CqlDateTime ad_ = context.Operators.Convert<CqlDateTime>(u_);
                bool? ae_ = context.Operators.Not((bool?)(ad_ is null));
                bool? af_ = context.Operators.And(ab_, ae_);
                CqlDateTime ah_ = context.Operators.Convert<CqlDateTime>(s_);
                CqlDateTime aj_ = context.Operators.Convert<CqlDateTime>(u_);
                CqlQuantity ak_ = context.Operators.Quantity(2m, "years");
                CqlDateTime al_ = context.Operators.Subtract(aj_, ak_);
                CqlDateTime an_ = context.Operators.Convert<CqlDateTime>(u_);
                CqlInterval<CqlDateTime> ao_ = context.Operators.Interval(al_, an_, true, false);
                bool? ap_ = context.Operators.In<CqlDateTime>(ah_, ao_, "day");
                CqlDateTime ar_ = context.Operators.Convert<CqlDateTime>(u_);
                bool? as_ = context.Operators.Not((bool?)(ar_ is null));
                bool? at_ = context.Operators.And(ap_, as_);
                bool? au_ = context.Operators.Or(af_, at_);
                return au_;
            }

            IEnumerable<ServiceRequest> q_ = context.Operators.Where<ServiceRequest>(o_, p_);
            bool? r_ = context.Operators.Exists<ServiceRequest>(q_);
            return r_;
        }

        IEnumerable<ServiceRequest> d_ = context.Operators.Where<ServiceRequest>(b_, c_);

        bool? e_(ServiceRequest DEXAOrdered) {
            Code<RequestStatus> av_ = DEXAOrdered?.StatusElement;
            RequestStatus? aw_ = av_?.Value;
            Code<RequestStatus> ax_ = context.Operators.Convert<Code<RequestStatus>>(aw_);
            string ay_ = context.Operators.Convert<string>(ax_);
            string[] az_ = [
                "active",
                "completed",
            ];
            bool? ba_ = context.Operators.In<string>(ay_, (IEnumerable<string>)az_);
            Code<RequestIntent> bb_ = DEXAOrdered?.IntentElement;
            RequestIntent? bc_ = bb_?.Value;
            Code<RequestIntent> bd_ = context.Operators.Convert<Code<RequestIntent>>(bc_);
            bool? be_ = context.Operators.Equal(bd_, "order");
            bool? bf_ = context.Operators.And(ba_, be_);
            return bf_;
        }

        IEnumerable<ServiceRequest> f_ = context.Operators.Where<ServiceRequest>(d_, e_);
        IEnumerable<Observation> h_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation-clinical-result"));

        bool? i_(Observation DEXAPerformed) {
            IEnumerable<ServiceRequest> bg_ = this.Order_for_12_Months_of_ADT_in_3_Months_Before_to_9_Months_After_Start_of_Measurement_Period(context);

            bool? bh_(ServiceRequest OrderTwelveMonthsADT) {
                DataType bk_ = DEXAPerformed?.Effective;
                object bl_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bk_);
                CqlInterval<CqlDateTime> bm_ = QICoreCommon_4_0_000.Instance.toInterval(context, bl_);
                CqlDateTime bn_ = context.Operators.Start(bm_);
                FhirDateTime bo_ = OrderTwelveMonthsADT?.AuthoredOnElement;
                CqlDateTime bp_ = context.Operators.Convert<CqlDateTime>(bo_);
                CqlDateTime br_ = context.Operators.Convert<CqlDateTime>(bo_);
                CqlQuantity bs_ = context.Operators.Quantity(3m, "months");
                CqlDateTime bt_ = context.Operators.Add(br_, bs_);
                CqlInterval<CqlDateTime> bu_ = context.Operators.Interval(bp_, bt_, true, true);
                bool? bv_ = context.Operators.In<CqlDateTime>(bn_, bu_, "day");
                CqlDateTime bx_ = context.Operators.Convert<CqlDateTime>(bo_);
                bool? by_ = context.Operators.Not((bool?)(bx_ is null));
                bool? bz_ = context.Operators.And(bv_, by_);
                object cb_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bk_);
                CqlInterval<CqlDateTime> cc_ = QICoreCommon_4_0_000.Instance.toInterval(context, cb_);
                CqlDateTime cd_ = context.Operators.End(cc_);
                CqlDateTime cf_ = context.Operators.Convert<CqlDateTime>(bo_);
                CqlQuantity cg_ = context.Operators.Quantity(2m, "years");
                CqlDateTime ch_ = context.Operators.Subtract(cf_, cg_);
                CqlDateTime cj_ = context.Operators.Convert<CqlDateTime>(bo_);
                CqlInterval<CqlDateTime> ck_ = context.Operators.Interval(ch_, cj_, true, false);
                bool? cl_ = context.Operators.In<CqlDateTime>(cd_, ck_, "day");
                CqlDateTime cn_ = context.Operators.Convert<CqlDateTime>(bo_);
                bool? co_ = context.Operators.Not((bool?)(cn_ is null));
                bool? cp_ = context.Operators.And(cl_, co_);
                bool? cq_ = context.Operators.Or(bz_, cp_);
                return cq_;
            }

            IEnumerable<ServiceRequest> bi_ = context.Operators.Where<ServiceRequest>(bg_, bh_);
            bool? bj_ = context.Operators.Exists<ServiceRequest>(bi_);
            return bj_;
        }

        IEnumerable<Observation> j_ = context.Operators.Where<Observation>(h_, i_);

        bool? k_(Observation DEXAPerformed) {
            Code<ObservationStatus> cr_ = DEXAPerformed?.StatusElement;
            ObservationStatus? cs_ = cr_?.Value;
            string ct_ = context.Operators.Convert<string>(cs_);
            string[] cu_ = [
                "final",
                "amended",
                "corrected",
            ];
            bool? cv_ = context.Operators.In<string>(ct_, (IEnumerable<string>)cu_);
            return cv_;
        }

        IEnumerable<Observation> l_ = context.Operators.Where<Observation>(j_, k_);
        IEnumerable<object> m_ = context.Operators.Union<object>(f_ as IEnumerable<object>, l_ as IEnumerable<object>);
        bool? n_ = context.Operators.Exists<object>(m_);
        return n_;
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
        IEnumerable<ServiceRequest> d_ = context.Operators.Retrieve<ServiceRequest>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-servicenotrequested"));
        IEnumerable<ServiceRequest> e_ = context.Operators.Union<ServiceRequest>(b_, d_);

        bool? f_(ServiceRequest DEXANotOrdered) {
            IEnumerable<ServiceRequest> h_ = this.Order_for_12_Months_of_ADT_in_3_Months_Before_to_9_Months_After_Start_of_Measurement_Period(context);

            bool? i_(ServiceRequest OrderTwelveMonthsADT) {
                FhirDateTime l_ = DEXANotOrdered?.AuthoredOnElement;
                CqlDateTime m_ = context.Operators.Convert<CqlDateTime>(l_);
                FhirDateTime n_ = OrderTwelveMonthsADT?.AuthoredOnElement;
                CqlDateTime o_ = context.Operators.Convert<CqlDateTime>(n_);
                CqlDateTime q_ = context.Operators.Convert<CqlDateTime>(n_);
                CqlQuantity r_ = context.Operators.Quantity(3m, "months");
                CqlDateTime s_ = context.Operators.Add(q_, r_);
                CqlInterval<CqlDateTime> t_ = context.Operators.Interval(o_, s_, true, true);
                bool? u_ = context.Operators.In<CqlDateTime>(m_, t_, "day");
                CqlDateTime w_ = context.Operators.Convert<CqlDateTime>(n_);
                bool? x_ = context.Operators.Not((bool?)(w_ is null));
                bool? y_ = context.Operators.And(u_, x_);

                bool? z_(Extension @this) {
                    FhirUri ai_ = @this?.UrlElement;
                    string aj_ = FHIRHelpers_4_4_000.Instance.ToString(context, ai_);
                    bool? ak_ = context.Operators.Equal(aj_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-doNotPerformReason");
                    return ak_;
                }

                IEnumerable<Extension> aa_ = context.Operators.Where<Extension>((IEnumerable<Extension>)(DEXANotOrdered is DomainResource
                    ? (DEXANotOrdered as DomainResource).Extension
                    : default), z_);

                object ab_(Extension @this) {
                    DataType al_ = @this?.Value;
                    return al_;
                }

                IEnumerable<object> ac_ = context.Operators.Select<Extension, object>(aa_, ab_);
                object ad_ = context.Operators.SingletonFrom<object>(ac_);
                CqlConcept ae_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, ad_ as CodeableConcept);
                CqlValueSet af_ = this.Patient_Declined(context);
                bool? ag_ = context.Operators.ConceptInValueSet(ae_, af_);
                bool? ah_ = context.Operators.And(y_, ag_);
                return ah_;
            }

            IEnumerable<ServiceRequest> j_ = context.Operators.Where<ServiceRequest>(h_, i_);
            bool? k_ = context.Operators.Exists<ServiceRequest>(j_);
            return k_;
        }

        IEnumerable<ServiceRequest> g_ = context.Operators.Where<ServiceRequest>(e_, f_);
        return g_;
    }


    [CqlExpressionDefinition("No Bone Density Scan Performed Due to Patient Refusal")]
    public IEnumerable<Observation> No_Bone_Density_Scan_Performed_Due_to_Patient_Refusal(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_No_Bone_Density_Scan_Performed_Due_to_Patient_Refusal, No_Bone_Density_Scan_Performed_Due_to_Patient_Refusal_Compute);

    private const long _cacheIndex_No_Bone_Density_Scan_Performed_Due_to_Patient_Refusal = -3751061519719478956L;

    private IEnumerable<Observation> No_Bone_Density_Scan_Performed_Due_to_Patient_Refusal_Compute(CqlContext context)
    {
        CqlValueSet a_ = this.DEXA_Bone_Density_for_Urology_Care(context);
        IEnumerable<Observation> b_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observationcancelled"));
        IEnumerable<Observation> d_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observationcancelled"));
        IEnumerable<Observation> e_ = context.Operators.Union<Observation>(b_, d_);

        bool? f_(Observation DEXANotPerformed) {
            IEnumerable<ServiceRequest> h_ = this.Order_for_12_Months_of_ADT_in_3_Months_Before_to_9_Months_After_Start_of_Measurement_Period(context);

            bool? i_(ServiceRequest OrderTwelveMonthsADT) {
                Instant l_ = DEXANotPerformed?.IssuedElement;
                DateTimeOffset? m_ = l_?.Value;
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

                bool? aa_(Extension @this) {
                    FhirUri aj_ = @this?.UrlElement;
                    string ak_ = FHIRHelpers_4_4_000.Instance.ToString(context, aj_);
                    bool? al_ = context.Operators.Equal(ak_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-notDoneReason");
                    return al_;
                }

                IEnumerable<Extension> ab_ = context.Operators.Where<Extension>((IEnumerable<Extension>)(DEXANotPerformed is DomainResource
                    ? (DEXANotPerformed as DomainResource).Extension
                    : default), aa_);

                object ac_(Extension @this) {
                    DataType am_ = @this?.Value;
                    return am_;
                }

                IEnumerable<object> ad_ = context.Operators.Select<Extension, object>(ab_, ac_);
                object ae_ = context.Operators.SingletonFrom<object>(ad_);
                CqlConcept af_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, ae_ as CodeableConcept);
                CqlValueSet ag_ = this.Patient_Declined(context);
                bool? ah_ = context.Operators.ConceptInValueSet(af_, ag_);
                bool? ai_ = context.Operators.And(z_, ah_);
                return ai_;
            }

            IEnumerable<ServiceRequest> j_ = context.Operators.Where<ServiceRequest>(h_, i_);
            bool? k_ = context.Operators.Exists<ServiceRequest>(j_);
            return k_;
        }

        IEnumerable<Observation> g_ = context.Operators.Where<Observation>(e_, f_);
        return g_;
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

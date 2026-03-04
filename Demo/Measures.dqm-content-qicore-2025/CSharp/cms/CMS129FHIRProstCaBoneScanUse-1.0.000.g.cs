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

[System.CodeDom.Compiler.GeneratedCode(".NET Code Generation", "5.1.0.0")]
[CqlLibrary("CMS129FHIRProstCaBoneScanUse", "1.0.000")]
public partial class CMS129FHIRProstCaBoneScanUse_1_0_000 : ILibrary, ISingleton<CMS129FHIRProstCaBoneScanUse_1_0_000>
{
    #region ValueSets (6)

    [CqlValueSetDefinition("Bone Scan", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.320", valueSetVersion: null)]
    public CqlValueSet Bone_Scan(CqlContext _) => _Bone_Scan;
    private static readonly CqlValueSet _Bone_Scan = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.320", null);

    [CqlValueSetDefinition("Pain Warranting Further Investigation for Prostate Cancer", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.451", valueSetVersion: null)]
    public CqlValueSet Pain_Warranting_Further_Investigation_for_Prostate_Cancer(CqlContext _) => _Pain_Warranting_Further_Investigation_for_Prostate_Cancer;
    private static readonly CqlValueSet _Pain_Warranting_Further_Investigation_for_Prostate_Cancer = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.451", null);

    [CqlValueSetDefinition("Prostate Cancer", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.319", valueSetVersion: null)]
    public CqlValueSet Prostate_Cancer(CqlContext _) => _Prostate_Cancer;
    private static readonly CqlValueSet _Prostate_Cancer = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.319", null);

    [CqlValueSetDefinition("Prostate Cancer Treatment", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.398", valueSetVersion: null)]
    public CqlValueSet Prostate_Cancer_Treatment(CqlContext _) => _Prostate_Cancer_Treatment;
    private static readonly CqlValueSet _Prostate_Cancer_Treatment = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.398", null);

    [CqlValueSetDefinition("Prostate Specific Antigen Test", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.401", valueSetVersion: null)]
    public CqlValueSet Prostate_Specific_Antigen_Test(CqlContext _) => _Prostate_Specific_Antigen_Test;
    private static readonly CqlValueSet _Prostate_Specific_Antigen_Test = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.401", null);

    [CqlValueSetDefinition("Salvage Therapy", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.399", valueSetVersion: null)]
    public CqlValueSet Salvage_Therapy(CqlContext _) => _Salvage_Therapy;
    private static readonly CqlValueSet _Salvage_Therapy = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.399", null);

    #endregion ValueSets

    #region Codes (7)

    [CqlCodeDefinition("American Joint Committee on Cancer cT1a (qualifier value)", codeId: "1228892002", codeSystem: "http://snomed.info/sct")]
    public CqlCode American_Joint_Committee_on_Cancer_cT1a__qualifier_value_(CqlContext _) => _American_Joint_Committee_on_Cancer_cT1a__qualifier_value_;
    private static readonly CqlCode _American_Joint_Committee_on_Cancer_cT1a__qualifier_value_ = new CqlCode("1228892002", "http://snomed.info/sct");

    [CqlCodeDefinition("American Joint Committee on Cancer cT1b (qualifier value)", codeId: "1228895000", codeSystem: "http://snomed.info/sct")]
    public CqlCode American_Joint_Committee_on_Cancer_cT1b__qualifier_value_(CqlContext _) => _American_Joint_Committee_on_Cancer_cT1b__qualifier_value_;
    private static readonly CqlCode _American_Joint_Committee_on_Cancer_cT1b__qualifier_value_ = new CqlCode("1228895000", "http://snomed.info/sct");

    [CqlCodeDefinition("American Joint Committee on Cancer cT1c (qualifier value)", codeId: "1228899006", codeSystem: "http://snomed.info/sct")]
    public CqlCode American_Joint_Committee_on_Cancer_cT1c__qualifier_value_(CqlContext _) => _American_Joint_Committee_on_Cancer_cT1c__qualifier_value_;
    private static readonly CqlCode _American_Joint_Committee_on_Cancer_cT1c__qualifier_value_ = new CqlCode("1228899006", "http://snomed.info/sct");

    [CqlCodeDefinition("American Joint Committee on Cancer cT2a (qualifier value)", codeId: "1228931008", codeSystem: "http://snomed.info/sct")]
    public CqlCode American_Joint_Committee_on_Cancer_cT2a__qualifier_value_(CqlContext _) => _American_Joint_Committee_on_Cancer_cT2a__qualifier_value_;
    private static readonly CqlCode _American_Joint_Committee_on_Cancer_cT2a__qualifier_value_ = new CqlCode("1228931008", "http://snomed.info/sct");

    [CqlCodeDefinition("Gleason score in Specimen Qualitative", codeId: "35266-6", codeSystem: "http://loinc.org")]
    public CqlCode Gleason_score_in_Specimen_Qualitative(CqlContext _) => _Gleason_score_in_Specimen_Qualitative;
    private static readonly CqlCode _Gleason_score_in_Specimen_Qualitative = new CqlCode("35266-6", "http://loinc.org");

    [CqlCodeDefinition("Procedure reason record (record artifact)", codeId: "433611000124109", codeSystem: "http://snomed.info/sct")]
    public CqlCode Procedure_reason_record__record_artifact_(CqlContext _) => _Procedure_reason_record__record_artifact_;
    private static readonly CqlCode _Procedure_reason_record__record_artifact_ = new CqlCode("433611000124109", "http://snomed.info/sct");

    [CqlCodeDefinition("Tumor staging (tumor staging)", codeId: "254292007", codeSystem: "http://snomed.info/sct")]
    public CqlCode Tumor_staging__tumor_staging_(CqlContext _) => _Tumor_staging__tumor_staging_;
    private static readonly CqlCode _Tumor_staging__tumor_staging_ = new CqlCode("254292007", "http://snomed.info/sct");

    #endregion Codes

    #region CodeSystems (3)

    [CqlCodeSystemDefinition("LOINC", codeSystemId: "http://loinc.org", codeSystemVersion: null)]
    public CqlCodeSystem LOINC(CqlContext _) => _LOINC;
    private static readonly CqlCodeSystem _LOINC =
      new CqlCodeSystem("http://loinc.org", null, [
          _Gleason_score_in_Specimen_Qualitative]);

    [CqlCodeSystemDefinition("SNOMEDCT", codeSystemId: "http://snomed.info/sct", codeSystemVersion: null)]
    public CqlCodeSystem SNOMEDCT(CqlContext _) => _SNOMEDCT;
    private static readonly CqlCodeSystem _SNOMEDCT =
      new CqlCodeSystem("http://snomed.info/sct", null, [
          _American_Joint_Committee_on_Cancer_cT1a__qualifier_value_,
          _American_Joint_Committee_on_Cancer_cT1b__qualifier_value_,
          _American_Joint_Committee_on_Cancer_cT1c__qualifier_value_,
          _American_Joint_Committee_on_Cancer_cT2a__qualifier_value_,
          _Procedure_reason_record__record_artifact_,
          _Tumor_staging__tumor_staging_]);

    [CqlCodeSystemDefinition("UCUM", codeSystemId: "http://unitsofmeasure.org", codeSystemVersion: null)]
    public CqlCodeSystem UCUM(CqlContext _) => _UCUM;
    private static readonly CqlCodeSystem _UCUM =
      new CqlCodeSystem("http://unitsofmeasure.org", null, []);

    #endregion CodeSystems

    #region Parameters (1)

    [CqlParameterDefinition("Measurement Period")]
    public CqlInterval<CqlDateTime> Measurement_Period(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Measurement_Period, Measurement_Period_Compute);

    private static readonly long _cacheIndex_Measurement_Period = -8140283047952446050L;

    private CqlInterval<CqlDateTime> Measurement_Period_Compute(CqlContext context)
    {
        CqlDateTime a_ = context.Operators.DateTime(2026, 1, 1, 0, 0, 0, 0, 0.0m);
        CqlDateTime b_ = context.Operators.DateTime(2027, 1, 1, 0, 0, 0, 0, 0.0m);
        CqlInterval<CqlDateTime> c_ = context.Operators.Interval(a_, b_, true, false);
        object d_ = context.ResolveParameter("CMS129FHIRProstCaBoneScanUse-1.0.000", "Measurement Period", c_);
        return (CqlInterval<CqlDateTime>)d_;
    }


    #endregion Parameters

    #region Functions and Expressions (19)

    [CqlExpressionDefinition("Patient")]
    public Patient Patient(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Patient, Patient_Compute);

    private static readonly long _cacheIndex_Patient = 4406994424031691662L;

    private Patient Patient_Compute(CqlContext context)
    {
        IEnumerable<Patient> a_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-patient"));
        Patient b_ = context.Operators.SingletonFrom<Patient>(a_);
        return b_;
    }


    [CqlExpressionDefinition("SDE Ethnicity")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Ethnicity(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_SDE_Ethnicity, SDE_Ethnicity_Compute);

    private static readonly long _cacheIndex_SDE_Ethnicity = -3741220856752493112L;

    private (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Ethnicity_Compute(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? a_ = SupplementalDataElements_5_1_000.Instance.SDE_Ethnicity(context);
        return a_;
    }


    [CqlExpressionDefinition("SDE Payer")]
    public IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> SDE_Payer(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_SDE_Payer, SDE_Payer_Compute);

    private static readonly long _cacheIndex_SDE_Payer = -2432525633866877819L;

    private IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> SDE_Payer_Compute(CqlContext context)
    {
        IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> a_ = SupplementalDataElements_5_1_000.Instance.SDE_Payer(context);
        return a_;
    }


    [CqlExpressionDefinition("SDE Race")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Race(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_SDE_Race, SDE_Race_Compute);

    private static readonly long _cacheIndex_SDE_Race = 3157958782746268240L;

    private (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Race_Compute(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? a_ = SupplementalDataElements_5_1_000.Instance.SDE_Race(context);
        return a_;
    }


    [CqlExpressionDefinition("SDE Sex")]
    public CqlCode SDE_Sex(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_SDE_Sex, SDE_Sex_Compute);

    private static readonly long _cacheIndex_SDE_Sex = 5879459535837422408L;

    private CqlCode SDE_Sex_Compute(CqlContext context)
    {
        CqlCode a_ = SupplementalDataElements_5_1_000.Instance.SDE_Sex(context);
        return a_;
    }


    [CqlFunctionDefinition("isVerified")]
    [CqlTag("note", "When possible, this function should be migrated to QICoreCommon.")]
    [CqlTag("description", "\"confirmed\", \"unconfirmed\", \"provisional\", or \"differential\"")]
    public bool? isVerified(CqlContext context, object condition)
    {
        object a_ = context.Operators.LateBoundProperty<object>(condition, "verificationStatus");
        CqlConcept b_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, a_ as CodeableConcept);
        bool? c_ = context.Operators.Not((bool?)(b_ is null));
        CqlConcept e_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, a_ as CodeableConcept);
        CqlCode f_ = QICoreCommon_4_0_000.Instance.confirmed(context);
        CqlConcept g_ = context.Operators.ConvertCodeToConcept(f_);
        bool? h_ = context.Operators.Equivalent(e_, g_);
        CqlConcept j_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, a_ as CodeableConcept);
        CqlCode k_ = QICoreCommon_4_0_000.Instance.unconfirmed(context);
        CqlConcept l_ = context.Operators.ConvertCodeToConcept(k_);
        bool? m_ = context.Operators.Equivalent(j_, l_);
        bool? n_ = context.Operators.Or(h_, m_);
        CqlConcept p_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, a_ as CodeableConcept);
        CqlCode q_ = QICoreCommon_4_0_000.Instance.provisional(context);
        CqlConcept r_ = context.Operators.ConvertCodeToConcept(q_);
        bool? s_ = context.Operators.Equivalent(p_, r_);
        bool? t_ = context.Operators.Or(n_, s_);
        CqlConcept v_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, a_ as CodeableConcept);
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

    private static readonly long _cacheIndex_Prostate_Cancer_Diagnosis = 7069960912159893930L;

    private IEnumerable<Condition> Prostate_Cancer_Diagnosis_Compute(CqlContext context)
    {
        CqlValueSet a_ = this.Prostate_Cancer(context);
        IEnumerable<Condition> b_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-problems-health-concerns"));

        bool? c_(Condition ProstateCancer) {
            CqlInterval<CqlDateTime> e_ = QICoreCommon_4_0_000.Instance.prevalenceInterval(context, ProstateCancer as object);
            CqlInterval<CqlDateTime> f_ = this.Measurement_Period(context);
            bool? g_ = context.Operators.Overlaps(e_, f_, "day");
            bool? h_ = this.isVerified(context, ProstateCancer as object);
            bool? i_ = context.Operators.And(g_, h_);
            return i_;
        }

        IEnumerable<Condition> d_ = context.Operators.Where<Condition>(b_, c_);
        return d_;
    }


    [CqlExpressionDefinition("Initial Population")]
    public bool? Initial_Population(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Initial_Population, Initial_Population_Compute);

    private static readonly long _cacheIndex_Initial_Population = 6349217679780301784L;

    private bool? Initial_Population_Compute(CqlContext context)
    {
        IEnumerable<Condition> a_ = this.Prostate_Cancer_Diagnosis(context);
        bool? b_ = context.Operators.Exists<Condition>(a_);
        return b_;
    }


    [CqlExpressionDefinition("First Prostate Cancer Treatment during day of Measurement Period")]
    public Procedure First_Prostate_Cancer_Treatment_during_day_of_Measurement_Period(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_First_Prostate_Cancer_Treatment_during_day_of_Measurement_Period, First_Prostate_Cancer_Treatment_during_day_of_Measurement_Period_Compute);

    private static readonly long _cacheIndex_First_Prostate_Cancer_Treatment_during_day_of_Measurement_Period = 2835648534723621959L;

    private Procedure First_Prostate_Cancer_Treatment_during_day_of_Measurement_Period_Compute(CqlContext context)
    {
        CqlValueSet a_ = this.Prostate_Cancer_Treatment(context);
        IEnumerable<Procedure> b_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));

        bool? c_(Procedure ProstateCancerTreatment) {

            object h_() {

                bool r_() {
                    DataType v_ = ProstateCancerTreatment?.Performed;
                    object w_ = FHIRHelpers_4_4_000.Instance.ToValue(context, v_);
                    bool x_ = w_ is CqlDateTime;
                    return x_;
                }


                bool s_() {
                    DataType y_ = ProstateCancerTreatment?.Performed;
                    object z_ = FHIRHelpers_4_4_000.Instance.ToValue(context, y_);
                    bool aa_ = z_ is CqlInterval<CqlDateTime>;
                    return aa_;
                }


                bool t_() {
                    DataType ab_ = ProstateCancerTreatment?.Performed;
                    object ac_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ab_);
                    bool ad_ = ac_ is CqlQuantity;
                    return ad_;
                }


                bool u_() {
                    DataType ae_ = ProstateCancerTreatment?.Performed;
                    object af_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ae_);
                    bool ag_ = af_ is CqlInterval<CqlQuantity>;
                    return ag_;
                }

                if (r_())
                {
                    DataType ah_ = ProstateCancerTreatment?.Performed;
                    object ai_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ah_);
                    return (ai_ as CqlDateTime) as object;
                }
                else if (s_())
                {
                    DataType aj_ = ProstateCancerTreatment?.Performed;
                    object ak_ = FHIRHelpers_4_4_000.Instance.ToValue(context, aj_);
                    return (ak_ as CqlInterval<CqlDateTime>) as object;
                }
                else if (t_())
                {
                    DataType al_ = ProstateCancerTreatment?.Performed;
                    object am_ = FHIRHelpers_4_4_000.Instance.ToValue(context, al_);
                    return (am_ as CqlQuantity) as object;
                }
                else if (u_())
                {
                    DataType an_ = ProstateCancerTreatment?.Performed;
                    object ao_ = FHIRHelpers_4_4_000.Instance.ToValue(context, an_);
                    return (ao_ as CqlInterval<CqlQuantity>) as object;
                }
                else
                {
                    return null;
                };
            }

            CqlInterval<CqlDateTime> i_ = QICoreCommon_4_0_000.Instance.toInterval(context, h_());
            CqlDateTime j_ = context.Operators.End(i_);
            CqlInterval<CqlDateTime> k_ = this.Measurement_Period(context);
            bool? l_ = context.Operators.In<CqlDateTime>(j_, k_, "day");
            Code<EventStatus> m_ = ProstateCancerTreatment?.StatusElement;
            EventStatus? n_ = m_?.Value;
            string o_ = context.Operators.Convert<string>(n_);
            bool? p_ = context.Operators.Equal(o_, "completed");
            bool? q_ = context.Operators.And(l_, p_);
            return q_;
        }

        IEnumerable<Procedure> d_ = context.Operators.Where<Procedure>(b_, c_);

        object e_(Procedure @this) {

            object ap_() {

                bool as_() {
                    DataType aw_ = @this?.Performed;
                    object ax_ = FHIRHelpers_4_4_000.Instance.ToValue(context, aw_);
                    bool ay_ = ax_ is CqlDateTime;
                    return ay_;
                }


                bool at_() {
                    DataType az_ = @this?.Performed;
                    object ba_ = FHIRHelpers_4_4_000.Instance.ToValue(context, az_);
                    bool bb_ = ba_ is CqlInterval<CqlDateTime>;
                    return bb_;
                }


                bool au_() {
                    DataType bc_ = @this?.Performed;
                    object bd_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bc_);
                    bool be_ = bd_ is CqlQuantity;
                    return be_;
                }


                bool av_() {
                    DataType bf_ = @this?.Performed;
                    object bg_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bf_);
                    bool bh_ = bg_ is CqlInterval<CqlQuantity>;
                    return bh_;
                }

                if (as_())
                {
                    DataType bi_ = @this?.Performed;
                    object bj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bi_);
                    return (bj_ as CqlDateTime) as object;
                }
                else if (at_())
                {
                    DataType bk_ = @this?.Performed;
                    object bl_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bk_);
                    return (bl_ as CqlInterval<CqlDateTime>) as object;
                }
                else if (au_())
                {
                    DataType bm_ = @this?.Performed;
                    object bn_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bm_);
                    return (bn_ as CqlQuantity) as object;
                }
                else if (av_())
                {
                    DataType bo_ = @this?.Performed;
                    object bp_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bo_);
                    return (bp_ as CqlInterval<CqlQuantity>) as object;
                }
                else
                {
                    return null;
                };
            }

            CqlInterval<CqlDateTime> aq_ = QICoreCommon_4_0_000.Instance.toInterval(context, ap_());
            CqlDateTime ar_ = context.Operators.Start(aq_);
            return ar_;
        }

        IEnumerable<Procedure> f_ = context.Operators.SortBy<Procedure>(d_, e_, System.ComponentModel.ListSortDirection.Ascending);
        Procedure g_ = context.Operators.First<Procedure>(f_);
        return g_;
    }


    [CqlExpressionDefinition("Most Recent Prostate Cancer Staging Tumor Size T1a to T2a")]
    public Observation Most_Recent_Prostate_Cancer_Staging_Tumor_Size_T1a_to_T2a(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Most_Recent_Prostate_Cancer_Staging_Tumor_Size_T1a_to_T2a, Most_Recent_Prostate_Cancer_Staging_Tumor_Size_T1a_to_T2a_Compute);

    private static readonly long _cacheIndex_Most_Recent_Prostate_Cancer_Staging_Tumor_Size_T1a_to_T2a = -4176122043776704687L;

    private Observation Most_Recent_Prostate_Cancer_Staging_Tumor_Size_T1a_to_T2a_Compute(CqlContext context)
    {
        CqlCode a_ = this.Tumor_staging__tumor_staging_(context);
        IEnumerable<CqlCode> b_ = context.Operators.ToList<CqlCode>(a_);
        IEnumerable<Observation> c_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, b_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation-clinical-result"));

        IEnumerable<Observation> d_(Observation ProstateCancerStaging) {
            Procedure m_ = this.First_Prostate_Cancer_Treatment_during_day_of_Measurement_Period(context);
            Procedure[] n_ = [
                m_,
            ];

            bool? o_(Procedure FirstProstateCancerTreatment) {
                DataType s_ = ProstateCancerStaging?.Effective;
                object t_ = FHIRHelpers_4_4_000.Instance.ToValue(context, s_);
                CqlInterval<CqlDateTime> u_ = QICoreCommon_4_0_000.Instance.toInterval(context, t_);
                CqlDateTime v_ = context.Operators.Start(u_);

                object w_() {

                    bool ag_() {
                        DataType ak_ = FirstProstateCancerTreatment?.Performed;
                        object al_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ak_);
                        bool am_ = al_ is CqlDateTime;
                        return am_;
                    }


                    bool ah_() {
                        DataType an_ = FirstProstateCancerTreatment?.Performed;
                        object ao_ = FHIRHelpers_4_4_000.Instance.ToValue(context, an_);
                        bool ap_ = ao_ is CqlInterval<CqlDateTime>;
                        return ap_;
                    }


                    bool ai_() {
                        DataType aq_ = FirstProstateCancerTreatment?.Performed;
                        object ar_ = FHIRHelpers_4_4_000.Instance.ToValue(context, aq_);
                        bool as_ = ar_ is CqlQuantity;
                        return as_;
                    }


                    bool aj_() {
                        DataType at_ = FirstProstateCancerTreatment?.Performed;
                        object au_ = FHIRHelpers_4_4_000.Instance.ToValue(context, at_);
                        bool av_ = au_ is CqlInterval<CqlQuantity>;
                        return av_;
                    }

                    if (ag_())
                    {
                        DataType aw_ = FirstProstateCancerTreatment?.Performed;
                        object ax_ = FHIRHelpers_4_4_000.Instance.ToValue(context, aw_);
                        return (ax_ as CqlDateTime) as object;
                    }
                    else if (ah_())
                    {
                        DataType ay_ = FirstProstateCancerTreatment?.Performed;
                        object az_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ay_);
                        return (az_ as CqlInterval<CqlDateTime>) as object;
                    }
                    else if (ai_())
                    {
                        DataType ba_ = FirstProstateCancerTreatment?.Performed;
                        object bb_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ba_);
                        return (bb_ as CqlQuantity) as object;
                    }
                    else if (aj_())
                    {
                        DataType bc_ = FirstProstateCancerTreatment?.Performed;
                        object bd_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bc_);
                        return (bd_ as CqlInterval<CqlQuantity>) as object;
                    }
                    else
                    {
                        return null;
                    };
                }

                CqlInterval<CqlDateTime> x_ = QICoreCommon_4_0_000.Instance.toInterval(context, w_());
                CqlDateTime y_ = context.Operators.Start(x_);
                bool? z_ = context.Operators.Before(v_, y_, (string)default);
                Code<ObservationStatus> aa_ = ProstateCancerStaging?.StatusElement;
                ObservationStatus? ab_ = aa_?.Value;
                string ac_ = context.Operators.Convert<string>(ab_);
                string[] ad_ = [
                    "final",
                    "amended",
                    "corrected",
                ];
                bool? ae_ = context.Operators.In<string>(ac_, (IEnumerable<string>)ad_);
                bool? af_ = context.Operators.And(z_, ae_);
                return af_;
            }

            IEnumerable<Procedure> p_ = context.Operators.Where<Procedure>((IEnumerable<Procedure>)n_, o_);
            Observation q_(Procedure FirstProstateCancerTreatment) => ProstateCancerStaging;
            IEnumerable<Observation> r_ = context.Operators.Select<Procedure, Observation>(p_, q_);
            return r_;
        }

        IEnumerable<Observation> e_ = context.Operators.SelectMany<Observation, Observation>(c_, d_);

        object f_(Observation @this) {
            DataType be_ = @this?.Effective;
            object bf_ = FHIRHelpers_4_4_000.Instance.ToValue(context, be_);
            CqlInterval<CqlDateTime> bg_ = QICoreCommon_4_0_000.Instance.toInterval(context, bf_);
            CqlDateTime bh_ = context.Operators.Start(bg_);
            return bh_;
        }

        IEnumerable<Observation> g_ = context.Operators.SortBy<Observation>(e_, f_, System.ComponentModel.ListSortDirection.Ascending);
        Observation h_ = context.Operators.Last<Observation>(g_);
        Observation[] i_ = [
            h_,
        ];

        bool? j_(Observation LastProstateCancerStaging) {
            DataType bi_ = LastProstateCancerStaging?.Value;
            object bj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bi_);
            CqlCode bk_ = this.American_Joint_Committee_on_Cancer_cT1a__qualifier_value_(context);
            CqlConcept bl_ = context.Operators.ConvertCodeToConcept(bk_);
            bool? bm_ = context.Operators.Equivalent(bj_ as CqlConcept, bl_);
            object bo_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bi_);
            CqlCode bp_ = this.American_Joint_Committee_on_Cancer_cT1b__qualifier_value_(context);
            CqlConcept bq_ = context.Operators.ConvertCodeToConcept(bp_);
            bool? br_ = context.Operators.Equivalent(bo_ as CqlConcept, bq_);
            bool? bs_ = context.Operators.Or(bm_, br_);
            object bu_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bi_);
            CqlCode bv_ = this.American_Joint_Committee_on_Cancer_cT1c__qualifier_value_(context);
            CqlConcept bw_ = context.Operators.ConvertCodeToConcept(bv_);
            bool? bx_ = context.Operators.Equivalent(bu_ as CqlConcept, bw_);
            bool? by_ = context.Operators.Or(bs_, bx_);
            object ca_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bi_);
            CqlCode cb_ = this.American_Joint_Committee_on_Cancer_cT2a__qualifier_value_(context);
            CqlConcept cc_ = context.Operators.ConvertCodeToConcept(cb_);
            bool? cd_ = context.Operators.Equivalent(ca_ as CqlConcept, cc_);
            bool? ce_ = context.Operators.Or(by_, cd_);
            return ce_;
        }

        IEnumerable<Observation> k_ = context.Operators.Where<Observation>((IEnumerable<Observation>)i_, j_);
        Observation l_ = context.Operators.SingletonFrom<Observation>(k_);
        return l_;
    }


    [CqlExpressionDefinition("Most Recent PSA Test Result is Low")]
    public bool? Most_Recent_PSA_Test_Result_is_Low(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Most_Recent_PSA_Test_Result_is_Low, Most_Recent_PSA_Test_Result_is_Low_Compute);

    private static readonly long _cacheIndex_Most_Recent_PSA_Test_Result_is_Low = 7161242736514616586L;

    private bool? Most_Recent_PSA_Test_Result_is_Low_Compute(CqlContext context)
    {
        CqlValueSet a_ = this.Prostate_Specific_Antigen_Test(context);
        IEnumerable<Observation> b_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation-lab"));

        IEnumerable<Observation> c_(Observation PSATest) {
            Observation m_ = this.Most_Recent_Prostate_Cancer_Staging_Tumor_Size_T1a_to_T2a(context);
            Observation[] n_ = [
                m_,
            ];

            bool? o_(Observation MostRecentProstateCancerStaging) {

                CqlInterval<CqlDateTime> s_() {

                    bool ad_() {
                        DataType ae_ = PSATest?.Effective;
                        object af_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ae_);
                        CqlInterval<CqlDateTime> ag_ = QICoreCommon_4_0_000.Instance.toInterval(context, af_);
                        CqlDateTime ah_ = context.Operators.Start(ag_);
                        return ah_ is null;
                    }

                    if (ad_())
                    {
                        return default;
                    }
                    else
                    {
                        DataType ai_ = PSATest?.Effective;
                        object aj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ai_);
                        CqlInterval<CqlDateTime> ak_ = QICoreCommon_4_0_000.Instance.toInterval(context, aj_);
                        CqlDateTime al_ = context.Operators.Start(ak_);
                        object an_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ai_);
                        CqlInterval<CqlDateTime> ao_ = QICoreCommon_4_0_000.Instance.toInterval(context, an_);
                        CqlDateTime ap_ = context.Operators.Start(ao_);
                        CqlInterval<CqlDateTime> aq_ = context.Operators.Interval(al_, ap_, true, true);
                        return aq_;
                    };
                }

                DataType t_ = MostRecentProstateCancerStaging?.Effective;
                object u_ = FHIRHelpers_4_4_000.Instance.ToValue(context, t_);
                CqlInterval<CqlDateTime> v_ = QICoreCommon_4_0_000.Instance.toInterval(context, u_);
                bool? w_ = context.Operators.Before(s_(), v_, (string)default);
                Code<ObservationStatus> x_ = PSATest?.StatusElement;
                ObservationStatus? y_ = x_?.Value;
                string z_ = context.Operators.Convert<string>(y_);
                string[] aa_ = [
                    "final",
                    "amended",
                    "corrected",
                ];
                bool? ab_ = context.Operators.In<string>(z_, (IEnumerable<string>)aa_);
                bool? ac_ = context.Operators.And(w_, ab_);
                return ac_;
            }

            IEnumerable<Observation> p_ = context.Operators.Where<Observation>((IEnumerable<Observation>)n_, o_);
            Observation q_(Observation MostRecentProstateCancerStaging) => PSATest;
            IEnumerable<Observation> r_ = context.Operators.Select<Observation, Observation>(p_, q_);
            return r_;
        }

        IEnumerable<Observation> d_ = context.Operators.SelectMany<Observation, Observation>(b_, c_);

        object e_(Observation @this) {
            DataType ar_ = @this?.Effective;
            object as_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ar_);
            CqlInterval<CqlDateTime> at_ = QICoreCommon_4_0_000.Instance.toInterval(context, as_);
            CqlDateTime au_ = context.Operators.Start(at_);
            return au_;
        }

        IEnumerable<Observation> f_ = context.Operators.SortBy<Observation>(d_, e_, System.ComponentModel.ListSortDirection.Ascending);
        Observation g_ = context.Operators.Last<Observation>(f_);
        Observation[] h_ = [
            g_,
        ];

        bool? i_(Observation LastPSATest) {
            DataType av_ = LastPSATest?.Value;
            object aw_ = FHIRHelpers_4_4_000.Instance.ToValue(context, av_);
            CqlQuantity ax_ = context.Operators.Quantity(10m, "ng/mL");
            bool? ay_ = context.Operators.Less(aw_ as CqlQuantity, ax_);
            return ay_;
        }

        IEnumerable<bool?> j_ = context.Operators.Select<Observation, bool?>((IEnumerable<Observation>)h_, i_);
        IEnumerable<bool?> k_ = context.Operators.Distinct<bool?>(j_);
        bool? l_ = context.Operators.SingletonFrom<bool?>(k_);
        return l_;
    }


    [CqlExpressionDefinition("Most Recent Gleason Score is Low")]
    public bool? Most_Recent_Gleason_Score_is_Low(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Most_Recent_Gleason_Score_is_Low, Most_Recent_Gleason_Score_is_Low_Compute);

    private static readonly long _cacheIndex_Most_Recent_Gleason_Score_is_Low = 7358005442362079522L;

    private bool? Most_Recent_Gleason_Score_is_Low_Compute(CqlContext context)
    {
        CqlCode a_ = this.Gleason_score_in_Specimen_Qualitative(context);
        IEnumerable<CqlCode> b_ = context.Operators.ToList<CqlCode>(a_);
        IEnumerable<Observation> c_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, b_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation-clinical-result"));

        IEnumerable<Observation> d_(Observation GleasonScore) {
            Procedure n_ = this.First_Prostate_Cancer_Treatment_during_day_of_Measurement_Period(context);
            Procedure[] o_ = [
                n_,
            ];

            bool? p_(Procedure FirstProstateCancerTreatment) {
                DataType t_ = GleasonScore?.Effective;
                object u_ = FHIRHelpers_4_4_000.Instance.ToValue(context, t_);
                CqlInterval<CqlDateTime> v_ = QICoreCommon_4_0_000.Instance.toInterval(context, u_);
                CqlDateTime w_ = context.Operators.Start(v_);

                object x_() {

                    bool ah_() {
                        DataType al_ = FirstProstateCancerTreatment?.Performed;
                        object am_ = FHIRHelpers_4_4_000.Instance.ToValue(context, al_);
                        bool an_ = am_ is CqlDateTime;
                        return an_;
                    }


                    bool ai_() {
                        DataType ao_ = FirstProstateCancerTreatment?.Performed;
                        object ap_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ao_);
                        bool aq_ = ap_ is CqlInterval<CqlDateTime>;
                        return aq_;
                    }


                    bool aj_() {
                        DataType ar_ = FirstProstateCancerTreatment?.Performed;
                        object as_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ar_);
                        bool at_ = as_ is CqlQuantity;
                        return at_;
                    }


                    bool ak_() {
                        DataType au_ = FirstProstateCancerTreatment?.Performed;
                        object av_ = FHIRHelpers_4_4_000.Instance.ToValue(context, au_);
                        bool aw_ = av_ is CqlInterval<CqlQuantity>;
                        return aw_;
                    }

                    if (ah_())
                    {
                        DataType ax_ = FirstProstateCancerTreatment?.Performed;
                        object ay_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ax_);
                        return (ay_ as CqlDateTime) as object;
                    }
                    else if (ai_())
                    {
                        DataType az_ = FirstProstateCancerTreatment?.Performed;
                        object ba_ = FHIRHelpers_4_4_000.Instance.ToValue(context, az_);
                        return (ba_ as CqlInterval<CqlDateTime>) as object;
                    }
                    else if (aj_())
                    {
                        DataType bb_ = FirstProstateCancerTreatment?.Performed;
                        object bc_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bb_);
                        return (bc_ as CqlQuantity) as object;
                    }
                    else if (ak_())
                    {
                        DataType bd_ = FirstProstateCancerTreatment?.Performed;
                        object be_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bd_);
                        return (be_ as CqlInterval<CqlQuantity>) as object;
                    }
                    else
                    {
                        return null;
                    };
                }

                CqlInterval<CqlDateTime> y_ = QICoreCommon_4_0_000.Instance.toInterval(context, x_());
                CqlDateTime z_ = context.Operators.Start(y_);
                bool? aa_ = context.Operators.Before(w_, z_, (string)default);
                Code<ObservationStatus> ab_ = GleasonScore?.StatusElement;
                ObservationStatus? ac_ = ab_?.Value;
                string ad_ = context.Operators.Convert<string>(ac_);
                string[] ae_ = [
                    "final",
                    "amended",
                    "corrected",
                ];
                bool? af_ = context.Operators.In<string>(ad_, (IEnumerable<string>)ae_);
                bool? ag_ = context.Operators.And(aa_, af_);
                return ag_;
            }

            IEnumerable<Procedure> q_ = context.Operators.Where<Procedure>((IEnumerable<Procedure>)o_, p_);
            Observation r_(Procedure FirstProstateCancerTreatment) => GleasonScore;
            IEnumerable<Observation> s_ = context.Operators.Select<Procedure, Observation>(q_, r_);
            return s_;
        }

        IEnumerable<Observation> e_ = context.Operators.SelectMany<Observation, Observation>(c_, d_);

        object f_(Observation @this) {
            DataType bf_ = @this?.Effective;
            object bg_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bf_);
            CqlInterval<CqlDateTime> bh_ = QICoreCommon_4_0_000.Instance.toInterval(context, bg_);
            CqlDateTime bi_ = context.Operators.Start(bh_);
            return bi_;
        }

        IEnumerable<Observation> g_ = context.Operators.SortBy<Observation>(e_, f_, System.ComponentModel.ListSortDirection.Ascending);
        Observation h_ = context.Operators.Last<Observation>(g_);
        Observation[] i_ = [
            h_,
        ];

        bool? j_(Observation LastGleasonScore) {
            DataType bj_ = LastGleasonScore?.Value;
            object bk_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bj_);
            bool? bl_ = context.Operators.LessOrEqual(bk_ as int?, 6);
            return bl_;
        }

        IEnumerable<bool?> k_ = context.Operators.Select<Observation, bool?>((IEnumerable<Observation>)i_, j_);
        IEnumerable<bool?> l_ = context.Operators.Distinct<bool?>(k_);
        bool? m_ = context.Operators.SingletonFrom<bool?>(l_);
        return m_;
    }


    [CqlExpressionDefinition("Denominator")]
    public bool? Denominator(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Denominator, Denominator_Compute);

    private static readonly long _cacheIndex_Denominator = 1246872489746454659L;

    private bool? Denominator_Compute(CqlContext context)
    {
        bool? a_ = this.Initial_Population(context);
        Procedure b_ = this.First_Prostate_Cancer_Treatment_during_day_of_Measurement_Period(context);
        bool? c_ = context.Operators.Not((bool?)(b_ is null));
        bool? d_ = context.Operators.And(a_, c_);
        Observation e_ = this.Most_Recent_Prostate_Cancer_Staging_Tumor_Size_T1a_to_T2a(context);
        bool? f_ = context.Operators.Not((bool?)(e_ is null));
        bool? g_ = context.Operators.And(d_, f_);
        bool? h_ = this.Most_Recent_PSA_Test_Result_is_Low(context);
        bool? i_ = context.Operators.And(g_, h_);
        bool? j_ = this.Most_Recent_Gleason_Score_is_Low(context);
        bool? k_ = context.Operators.And(i_, j_);
        return k_;
    }


    [CqlExpressionDefinition("Bone Scan Study Performed")]
    public IEnumerable<Observation> Bone_Scan_Study_Performed(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Bone_Scan_Study_Performed, Bone_Scan_Study_Performed_Compute);

    private static readonly long _cacheIndex_Bone_Scan_Study_Performed = 288628587474938786L;

    private IEnumerable<Observation> Bone_Scan_Study_Performed_Compute(CqlContext context)
    {
        CqlValueSet a_ = this.Bone_Scan(context);
        IEnumerable<Observation> b_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation-clinical-result"));

        IEnumerable<Observation> c_(Observation BoneScan) {
            IEnumerable<Condition> g_ = this.Prostate_Cancer_Diagnosis(context);

            bool? h_(Condition ActiveProstateCancer) {
                DataType l_ = BoneScan?.Effective;
                object m_ = FHIRHelpers_4_4_000.Instance.ToValue(context, l_);
                CqlInterval<CqlDateTime> n_ = QICoreCommon_4_0_000.Instance.toInterval(context, m_);
                CqlDateTime o_ = context.Operators.Start(n_);
                CqlInterval<CqlDateTime> p_ = QICoreCommon_4_0_000.Instance.prevalenceInterval(context, ActiveProstateCancer as object);
                CqlDateTime q_ = context.Operators.Start(p_);
                bool? r_ = context.Operators.After(o_, q_, (string)default);
                return r_;
            }

            IEnumerable<Condition> i_ = context.Operators.Where<Condition>(g_, h_);
            Observation j_(Condition ActiveProstateCancer) => BoneScan;
            IEnumerable<Observation> k_ = context.Operators.Select<Condition, Observation>(i_, j_);
            return k_;
        }

        IEnumerable<Observation> d_ = context.Operators.SelectMany<Observation, Observation>(b_, c_);

        bool? e_(Observation BoneScan) {
            DataType s_ = BoneScan?.Effective;
            object t_ = FHIRHelpers_4_4_000.Instance.ToValue(context, s_);
            CqlInterval<CqlDateTime> u_ = QICoreCommon_4_0_000.Instance.toInterval(context, t_);
            CqlDateTime v_ = context.Operators.End(u_);
            CqlInterval<CqlDateTime> w_ = this.Measurement_Period(context);
            bool? x_ = context.Operators.In<CqlDateTime>(v_, w_, "day");
            Code<ObservationStatus> y_ = BoneScan?.StatusElement;
            ObservationStatus? z_ = y_?.Value;
            string aa_ = context.Operators.Convert<string>(z_);
            string[] ab_ = [
                "final",
                "amended",
                "corrected",
            ];
            bool? ac_ = context.Operators.In<string>(aa_, (IEnumerable<string>)ab_);
            bool? ad_ = context.Operators.And(x_, ac_);
            return ad_;
        }

        IEnumerable<Observation> f_ = context.Operators.Where<Observation>(d_, e_);
        return f_;
    }


    [CqlExpressionDefinition("Numerator")]
    public bool? Numerator(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Numerator, Numerator_Compute);

    private static readonly long _cacheIndex_Numerator = 7820927283973067551L;

    private bool? Numerator_Compute(CqlContext context)
    {
        IEnumerable<Observation> a_ = this.Bone_Scan_Study_Performed(context);
        bool? b_ = context.Operators.Exists<Observation>(a_);
        bool? c_ = context.Operators.Not(b_);
        return c_;
    }


    [CqlExpressionDefinition("Has Diagnosis of Pain related to Prostate Cancer")]
    public bool? Has_Diagnosis_of_Pain_related_to_Prostate_Cancer(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Has_Diagnosis_of_Pain_related_to_Prostate_Cancer, Has_Diagnosis_of_Pain_related_to_Prostate_Cancer_Compute);

    private static readonly long _cacheIndex_Has_Diagnosis_of_Pain_related_to_Prostate_Cancer = 1074005850507574754L;

    private bool? Has_Diagnosis_of_Pain_related_to_Prostate_Cancer_Compute(CqlContext context)
    {
        CqlValueSet a_ = this.Pain_Warranting_Further_Investigation_for_Prostate_Cancer(context);
        IEnumerable<Condition> b_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-problems-health-concerns"));
        IEnumerable<Condition> d_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-encounter-diagnosis"));
        IEnumerable<object> e_ = context.Operators.Union<object>(b_ as IEnumerable<object>, d_ as IEnumerable<object>);

        IEnumerable<object> f_(object ProstateCancerPain) {
            IEnumerable<Condition> i_ = this.Prostate_Cancer_Diagnosis(context);

            bool? j_(Condition ActiveProstateCancer) {
                CqlInterval<CqlDateTime> n_ = QICoreCommon_4_0_000.Instance.prevalenceInterval(context, ProstateCancerPain);
                CqlDateTime o_ = context.Operators.Start(n_);
                CqlInterval<CqlDateTime> p_ = QICoreCommon_4_0_000.Instance.prevalenceInterval(context, ActiveProstateCancer as object);
                CqlDateTime q_ = context.Operators.Start(p_);
                bool? r_ = context.Operators.After(o_, q_, (string)default);
                bool? s_ = this.isVerified(context, ProstateCancerPain);
                bool? t_ = context.Operators.And(r_, s_);
                return t_;
            }

            IEnumerable<Condition> k_ = context.Operators.Where<Condition>(i_, j_);
            object l_(Condition ActiveProstateCancer) => ProstateCancerPain;
            IEnumerable<object> m_ = context.Operators.Select<Condition, object>(k_, l_);
            return m_;
        }

        IEnumerable<object> g_ = context.Operators.SelectMany<object, object>(e_, f_);
        bool? h_ = context.Operators.Exists<object>(g_);
        return h_;
    }


    [CqlExpressionDefinition("Has Salvage Therapy Performed after Prostate Cancer Diagnosis")]
    public bool? Has_Salvage_Therapy_Performed_after_Prostate_Cancer_Diagnosis(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Has_Salvage_Therapy_Performed_after_Prostate_Cancer_Diagnosis, Has_Salvage_Therapy_Performed_after_Prostate_Cancer_Diagnosis_Compute);

    private static readonly long _cacheIndex_Has_Salvage_Therapy_Performed_after_Prostate_Cancer_Diagnosis = 814682402894497576L;

    private bool? Has_Salvage_Therapy_Performed_after_Prostate_Cancer_Diagnosis_Compute(CqlContext context)
    {
        CqlValueSet a_ = this.Salvage_Therapy(context);
        IEnumerable<Procedure> b_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));

        IEnumerable<Procedure> c_(Procedure SalvageTherapy) {
            IEnumerable<Condition> f_ = this.Prostate_Cancer_Diagnosis(context);

            bool? g_(Condition ActiveProstateCancer) {

                object k_() {

                    bool v_() {
                        DataType z_ = SalvageTherapy?.Performed;
                        object aa_ = FHIRHelpers_4_4_000.Instance.ToValue(context, z_);
                        bool ab_ = aa_ is CqlDateTime;
                        return ab_;
                    }


                    bool w_() {
                        DataType ac_ = SalvageTherapy?.Performed;
                        object ad_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ac_);
                        bool ae_ = ad_ is CqlInterval<CqlDateTime>;
                        return ae_;
                    }


                    bool x_() {
                        DataType af_ = SalvageTherapy?.Performed;
                        object ag_ = FHIRHelpers_4_4_000.Instance.ToValue(context, af_);
                        bool ah_ = ag_ is CqlQuantity;
                        return ah_;
                    }


                    bool y_() {
                        DataType ai_ = SalvageTherapy?.Performed;
                        object aj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ai_);
                        bool ak_ = aj_ is CqlInterval<CqlQuantity>;
                        return ak_;
                    }

                    if (v_())
                    {
                        DataType al_ = SalvageTherapy?.Performed;
                        object am_ = FHIRHelpers_4_4_000.Instance.ToValue(context, al_);
                        return (am_ as CqlDateTime) as object;
                    }
                    else if (w_())
                    {
                        DataType an_ = SalvageTherapy?.Performed;
                        object ao_ = FHIRHelpers_4_4_000.Instance.ToValue(context, an_);
                        return (ao_ as CqlInterval<CqlDateTime>) as object;
                    }
                    else if (x_())
                    {
                        DataType ap_ = SalvageTherapy?.Performed;
                        object aq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ap_);
                        return (aq_ as CqlQuantity) as object;
                    }
                    else if (y_())
                    {
                        DataType ar_ = SalvageTherapy?.Performed;
                        object as_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ar_);
                        return (as_ as CqlInterval<CqlQuantity>) as object;
                    }
                    else
                    {
                        return null;
                    };
                }

                CqlInterval<CqlDateTime> l_ = QICoreCommon_4_0_000.Instance.toInterval(context, k_());
                CqlDateTime m_ = context.Operators.Start(l_);
                CqlInterval<CqlDateTime> n_ = QICoreCommon_4_0_000.Instance.prevalenceInterval(context, ActiveProstateCancer as object);
                CqlDateTime o_ = context.Operators.Start(n_);
                bool? p_ = context.Operators.After(m_, o_, (string)default);
                Code<EventStatus> q_ = SalvageTherapy?.StatusElement;
                EventStatus? r_ = q_?.Value;
                string s_ = context.Operators.Convert<string>(r_);
                bool? t_ = context.Operators.Equal(s_, "completed");
                bool? u_ = context.Operators.And(p_, t_);
                return u_;
            }

            IEnumerable<Condition> h_ = context.Operators.Where<Condition>(f_, g_);
            Procedure i_(Condition ActiveProstateCancer) => SalvageTherapy;
            IEnumerable<Procedure> j_ = context.Operators.Select<Condition, Procedure>(h_, i_);
            return j_;
        }

        IEnumerable<Procedure> d_ = context.Operators.SelectMany<Procedure, Procedure>(b_, c_);
        bool? e_ = context.Operators.Exists<Procedure>(d_);
        return e_;
    }


    [CqlExpressionDefinition("Has Bone Scan Study Performed with Documented Reason")]
    public bool? Has_Bone_Scan_Study_Performed_with_Documented_Reason(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Has_Bone_Scan_Study_Performed_with_Documented_Reason, Has_Bone_Scan_Study_Performed_with_Documented_Reason_Compute);

    private static readonly long _cacheIndex_Has_Bone_Scan_Study_Performed_with_Documented_Reason = -57594536143353413L;

    private bool? Has_Bone_Scan_Study_Performed_with_Documented_Reason_Compute(CqlContext context)
    {
        IEnumerable<Observation> a_ = this.Bone_Scan_Study_Performed(context);

        bool? b_(Observation BoneScanAfterDiagnosis) {
            DataType e_ = BoneScanAfterDiagnosis?.Value;
            object f_ = FHIRHelpers_4_4_000.Instance.ToValue(context, e_);
            CqlCode g_ = this.Procedure_reason_record__record_artifact_(context);
            CqlConcept h_ = context.Operators.ConvertCodeToConcept(g_);
            bool? i_ = context.Operators.Equivalent(f_ as CqlConcept, h_);
            return i_;
        }

        IEnumerable<Observation> c_ = context.Operators.Where<Observation>(a_, b_);
        bool? d_ = context.Operators.Exists<Observation>(c_);
        return d_;
    }


    [CqlExpressionDefinition("Denominator Exceptions")]
    public bool? Denominator_Exceptions(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Denominator_Exceptions, Denominator_Exceptions_Compute);

    private static readonly long _cacheIndex_Denominator_Exceptions = -2111890706368566952L;

    private bool? Denominator_Exceptions_Compute(CqlContext context)
    {
        bool? a_ = this.Has_Diagnosis_of_Pain_related_to_Prostate_Cancer(context);
        bool? b_ = this.Has_Salvage_Therapy_Performed_after_Prostate_Cancer_Diagnosis(context);
        bool? c_ = context.Operators.Or(a_, b_);
        bool? d_ = this.Has_Bone_Scan_Study_Performed_with_Documented_Reason(context);
        bool? e_ = context.Operators.Or(c_, d_);
        return e_;
    }


    #endregion Functions and Expressions

    #region Singleton Lifetime Members

    private CMS129FHIRProstCaBoneScanUse_1_0_000() {}

    public static CMS129FHIRProstCaBoneScanUse_1_0_000 Instance { get; } = new();

    #endregion

    #region ILibrary Implementation

    public string Name => "CMS129FHIRProstCaBoneScanUse";
    public string Version => "1.0.000";
    public ILibrary[] Dependencies => [FHIRHelpers_4_4_000.Instance, SupplementalDataElements_5_1_000.Instance, QICoreCommon_4_0_000.Instance];

    #endregion ILibrary Implementation

}

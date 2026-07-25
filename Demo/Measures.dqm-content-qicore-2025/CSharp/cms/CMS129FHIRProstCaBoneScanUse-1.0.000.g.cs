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

[System.CodeDom.Compiler.GeneratedCode(".NET Code Generation", "5.1.5.0")]
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

    private const long _cacheIndex_Measurement_Period = -8140283047952446050L;

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

    private const long _cacheIndex_Patient = 4406994424031691662L;

    private Patient Patient_Compute(CqlContext context)
    {
        IEnumerable<Patient> a_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-patient"));
        Patient b_ = context.Operators.SingletonFrom<Patient>(a_);
        return b_;
    }


    [CqlExpressionDefinition("SDE Ethnicity")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Ethnicity(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_SDE_Ethnicity, SDE_Ethnicity_Compute);

    private const long _cacheIndex_SDE_Ethnicity = -3741220856752493112L;

    private (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Ethnicity_Compute(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? a_ = SupplementalDataElements_5_1_000.Instance.SDE_Ethnicity(context);
        return a_;
    }


    [CqlExpressionDefinition("SDE Payer")]
    public IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> SDE_Payer(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_SDE_Payer, SDE_Payer_Compute);

    private const long _cacheIndex_SDE_Payer = -2432525633866877819L;

    private IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> SDE_Payer_Compute(CqlContext context)
    {
        IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> a_ = SupplementalDataElements_5_1_000.Instance.SDE_Payer(context);
        return a_;
    }


    [CqlExpressionDefinition("SDE Race")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Race(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_SDE_Race, SDE_Race_Compute);

    private const long _cacheIndex_SDE_Race = 3157958782746268240L;

    private (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Race_Compute(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? a_ = SupplementalDataElements_5_1_000.Instance.SDE_Race(context);
        return a_;
    }


    [CqlExpressionDefinition("SDE Sex")]
    public CqlCode SDE_Sex(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_SDE_Sex, SDE_Sex_Compute);

    private const long _cacheIndex_SDE_Sex = 5879459535837422408L;

    private CqlCode SDE_Sex_Compute(CqlContext context)
    {
        CqlCode a_ = SupplementalDataElements_5_1_000.Instance.SDE_Sex(context);
        return a_;
    }


    [CqlFunctionDefinition("isVerified")]
    [CqlTag("note", "When possible, this function should be migrated to QICoreCommon.")]
    [CqlTag("description", "\"confirmed\", \"unconfirmed\", \"provisional\", or \"differential\"")]
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

    private const long _cacheIndex_Prostate_Cancer_Diagnosis = 7069960912159893930L;

    private IEnumerable<Condition> Prostate_Cancer_Diagnosis_Compute(CqlContext context)
    {
        CqlValueSet a_ = this.Prostate_Cancer(context);
        IEnumerable<Condition> b_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-problems-health-concerns"));

        bool? c_(Condition ProstateCancer) {
            CqlInterval<CqlDateTime> e_ = QICoreCommon_4_0_000.Instance.prevalenceInterval(context, ProstateCancer as Condition);
            CqlInterval<CqlDateTime> f_ = this.Measurement_Period(context);
            bool? g_ = context.Operators.Overlaps(e_, f_, "day");
            bool? h_ = this.isVerified(context, ProstateCancer as Condition);
            bool? i_ = context.Operators.And(g_, h_);
            return i_;
        }

        IEnumerable<Condition> d_ = context.Operators.Where<Condition>(b_, c_);
        return d_;
    }


    [CqlExpressionDefinition("Initial Population")]
    public bool? Initial_Population(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Initial_Population, Initial_Population_Compute);

    private const long _cacheIndex_Initial_Population = 6349217679780301784L;

    private bool? Initial_Population_Compute(CqlContext context)
    {
        IEnumerable<Condition> a_ = this.Prostate_Cancer_Diagnosis(context);
        bool? b_ = context.Operators.Exists<Condition>(a_);
        return b_;
    }


    [CqlExpressionDefinition("First Prostate Cancer Treatment during day of Measurement Period")]
    public Procedure First_Prostate_Cancer_Treatment_during_day_of_Measurement_Period(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_First_Prostate_Cancer_Treatment_during_day_of_Measurement_Period, First_Prostate_Cancer_Treatment_during_day_of_Measurement_Period_Compute);

    private const long _cacheIndex_First_Prostate_Cancer_Treatment_during_day_of_Measurement_Period = 2835648534723621959L;

    private Procedure First_Prostate_Cancer_Treatment_during_day_of_Measurement_Period_Compute(CqlContext context)
    {
        CqlValueSet a_ = this.Prostate_Cancer_Treatment(context);
        IEnumerable<Procedure> b_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));

        bool? c_(Procedure ProstateCancerTreatment) {
            object h_;
            DataType r_ = ProstateCancerTreatment?.Performed;
            object s_ = FHIRHelpers_4_4_000.Instance.ToValue(context, r_);
            bool t_ = s_ is CqlDateTime;
            if (t_)
            {
                DataType u_ = ProstateCancerTreatment?.Performed;
                object v_ = FHIRHelpers_4_4_000.Instance.ToValue(context, u_);
                h_ = v_ as CqlDateTime;
            }
            else
            {
                DataType w_ = ProstateCancerTreatment?.Performed;
                object x_ = FHIRHelpers_4_4_000.Instance.ToValue(context, w_);
                bool y_ = x_ is CqlInterval<CqlDateTime>;
                if (y_)
                {
                    DataType z_ = ProstateCancerTreatment?.Performed;
                    object aa_ = FHIRHelpers_4_4_000.Instance.ToValue(context, z_);
                    h_ = aa_ as CqlInterval<CqlDateTime>;
                }
                else
                {
                    DataType ab_ = ProstateCancerTreatment?.Performed;
                    object ac_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ab_);
                    bool ad_ = ac_ is CqlQuantity;
                    if (ad_)
                    {
                        DataType ae_ = ProstateCancerTreatment?.Performed;
                        object af_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ae_);
                        h_ = af_ as CqlQuantity;
                    }
                    else
                    {
                        DataType ag_ = ProstateCancerTreatment?.Performed;
                        object ah_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ag_);
                        bool ai_ = ah_ is CqlInterval<CqlQuantity>;
                        if (ai_)
                        {
                            DataType aj_ = ProstateCancerTreatment?.Performed;
                            object ak_ = FHIRHelpers_4_4_000.Instance.ToValue(context, aj_);
                            h_ = ak_ as CqlInterval<CqlQuantity>;
                        }
                        else
                        {
                            h_ = null;
                        }
                    }
                }
            }
            CqlInterval<CqlDateTime> i_ = QICoreCommon_4_0_000.Instance.toInterval(context, h_);
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
            object al_;
            DataType ao_ = @this?.Performed;
            object ap_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ao_);
            bool aq_ = ap_ is CqlDateTime;
            if (aq_)
            {
                DataType ar_ = @this?.Performed;
                object as_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ar_);
                al_ = as_ as CqlDateTime;
            }
            else
            {
                DataType at_ = @this?.Performed;
                object au_ = FHIRHelpers_4_4_000.Instance.ToValue(context, at_);
                bool av_ = au_ is CqlInterval<CqlDateTime>;
                if (av_)
                {
                    DataType aw_ = @this?.Performed;
                    object ax_ = FHIRHelpers_4_4_000.Instance.ToValue(context, aw_);
                    al_ = ax_ as CqlInterval<CqlDateTime>;
                }
                else
                {
                    DataType ay_ = @this?.Performed;
                    object az_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ay_);
                    bool ba_ = az_ is CqlQuantity;
                    if (ba_)
                    {
                        DataType bb_ = @this?.Performed;
                        object bc_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bb_);
                        al_ = bc_ as CqlQuantity;
                    }
                    else
                    {
                        DataType bd_ = @this?.Performed;
                        object be_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bd_);
                        bool bf_ = be_ is CqlInterval<CqlQuantity>;
                        if (bf_)
                        {
                            DataType bg_ = @this?.Performed;
                            object bh_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bg_);
                            al_ = bh_ as CqlInterval<CqlQuantity>;
                        }
                        else
                        {
                            al_ = null;
                        }
                    }
                }
            }
            CqlInterval<CqlDateTime> am_ = QICoreCommon_4_0_000.Instance.toInterval(context, al_);
            CqlDateTime an_ = context.Operators.Start(am_);
            return an_;
        }

        IEnumerable<Procedure> f_ = context.Operators.SortBy<Procedure>(d_, e_, System.ComponentModel.ListSortDirection.Ascending);
        Procedure g_ = context.Operators.First<Procedure>(f_);
        return g_;
    }


    [CqlExpressionDefinition("Most Recent Prostate Cancer Staging Tumor Size T1a to T2a")]
    public Observation Most_Recent_Prostate_Cancer_Staging_Tumor_Size_T1a_to_T2a(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Most_Recent_Prostate_Cancer_Staging_Tumor_Size_T1a_to_T2a, Most_Recent_Prostate_Cancer_Staging_Tumor_Size_T1a_to_T2a_Compute);

    private const long _cacheIndex_Most_Recent_Prostate_Cancer_Staging_Tumor_Size_T1a_to_T2a = -4176122043776704687L;

    private Observation Most_Recent_Prostate_Cancer_Staging_Tumor_Size_T1a_to_T2a_Compute(CqlContext context)
    {
        CqlCode a_ = this.Tumor_staging__tumor_staging_(context);
        IEnumerable<CqlCode> b_ = context.Operators.ToList<CqlCode>(a_);
        IEnumerable<Observation> c_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, b_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation-clinical-result"));

        bool? d_(Observation ProstateCancerStaging) {
            Procedure m_ = this.First_Prostate_Cancer_Treatment_during_day_of_Measurement_Period(context);
            Procedure[] n_ = [
                m_,
            ];

            bool? o_(Procedure FirstProstateCancerTreatment) {
                DataType r_ = ProstateCancerStaging?.Effective;
                object s_ = FHIRHelpers_4_4_000.Instance.ToValue(context, r_);
                CqlInterval<CqlDateTime> t_ = QICoreCommon_4_0_000.Instance.toInterval(context, s_);
                CqlDateTime u_ = context.Operators.Start(t_);
                object v_;
                DataType af_ = FirstProstateCancerTreatment?.Performed;
                object ag_ = FHIRHelpers_4_4_000.Instance.ToValue(context, af_);
                bool ah_ = ag_ is CqlDateTime;
                if (ah_)
                {
                    DataType ai_ = FirstProstateCancerTreatment?.Performed;
                    object aj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ai_);
                    v_ = aj_ as CqlDateTime;
                }
                else
                {
                    DataType ak_ = FirstProstateCancerTreatment?.Performed;
                    object al_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ak_);
                    bool am_ = al_ is CqlInterval<CqlDateTime>;
                    if (am_)
                    {
                        DataType an_ = FirstProstateCancerTreatment?.Performed;
                        object ao_ = FHIRHelpers_4_4_000.Instance.ToValue(context, an_);
                        v_ = ao_ as CqlInterval<CqlDateTime>;
                    }
                    else
                    {
                        DataType ap_ = FirstProstateCancerTreatment?.Performed;
                        object aq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ap_);
                        bool ar_ = aq_ is CqlQuantity;
                        if (ar_)
                        {
                            DataType as_ = FirstProstateCancerTreatment?.Performed;
                            object at_ = FHIRHelpers_4_4_000.Instance.ToValue(context, as_);
                            v_ = at_ as CqlQuantity;
                        }
                        else
                        {
                            DataType au_ = FirstProstateCancerTreatment?.Performed;
                            object av_ = FHIRHelpers_4_4_000.Instance.ToValue(context, au_);
                            bool aw_ = av_ is CqlInterval<CqlQuantity>;
                            if (aw_)
                            {
                                DataType ax_ = FirstProstateCancerTreatment?.Performed;
                                object ay_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ax_);
                                v_ = ay_ as CqlInterval<CqlQuantity>;
                            }
                            else
                            {
                                v_ = null;
                            }
                        }
                    }
                }
                CqlInterval<CqlDateTime> w_ = QICoreCommon_4_0_000.Instance.toInterval(context, v_);
                CqlDateTime x_ = context.Operators.Start(w_);
                bool? y_ = context.Operators.Before(u_, x_, (string)default);
                Code<ObservationStatus> z_ = ProstateCancerStaging?.StatusElement;
                ObservationStatus? aa_ = z_?.Value;
                string ab_ = context.Operators.Convert<string>(aa_);
                string[] ac_ = [
                    "final",
                    "amended",
                    "corrected",
                ];
                bool? ad_ = context.Operators.In<string>(ab_, (IEnumerable<string>)ac_);
                bool? ae_ = context.Operators.And(y_, ad_);
                return ae_;
            }

            IEnumerable<Procedure> p_ = context.Operators.Where<Procedure>((IEnumerable<Procedure>)n_, o_);
            bool? q_ = context.Operators.Exists<Procedure>(p_);
            return q_;
        }

        IEnumerable<Observation> e_ = context.Operators.Where<Observation>(c_, d_);

        object f_(Observation @this) {
            DataType az_ = @this?.Effective;
            object ba_ = FHIRHelpers_4_4_000.Instance.ToValue(context, az_);
            CqlInterval<CqlDateTime> bb_ = QICoreCommon_4_0_000.Instance.toInterval(context, ba_);
            CqlDateTime bc_ = context.Operators.Start(bb_);
            return bc_;
        }

        IEnumerable<Observation> g_ = context.Operators.SortBy<Observation>(e_, f_, System.ComponentModel.ListSortDirection.Ascending);
        Observation h_ = context.Operators.Last<Observation>(g_);
        Observation[] i_ = [
            h_,
        ];

        bool? j_(Observation LastProstateCancerStaging) {
            DataType bd_ = LastProstateCancerStaging?.Value;
            object be_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bd_);
            CqlCode bf_ = this.American_Joint_Committee_on_Cancer_cT1a__qualifier_value_(context);
            CqlConcept bg_ = context.Operators.ConvertCodeToConcept(bf_);
            bool? bh_ = context.Operators.Equivalent(be_ as CqlConcept, bg_);
            CqlCode bi_ = this.American_Joint_Committee_on_Cancer_cT1b__qualifier_value_(context);
            CqlConcept bj_ = context.Operators.ConvertCodeToConcept(bi_);
            bool? bk_ = context.Operators.Equivalent(be_ as CqlConcept, bj_);
            bool? bl_ = context.Operators.Or(bh_, bk_);
            CqlCode bm_ = this.American_Joint_Committee_on_Cancer_cT1c__qualifier_value_(context);
            CqlConcept bn_ = context.Operators.ConvertCodeToConcept(bm_);
            bool? bo_ = context.Operators.Equivalent(be_ as CqlConcept, bn_);
            bool? bp_ = context.Operators.Or(bl_, bo_);
            CqlCode bq_ = this.American_Joint_Committee_on_Cancer_cT2a__qualifier_value_(context);
            CqlConcept br_ = context.Operators.ConvertCodeToConcept(bq_);
            bool? bs_ = context.Operators.Equivalent(be_ as CqlConcept, br_);
            bool? bt_ = context.Operators.Or(bp_, bs_);
            return bt_;
        }

        IEnumerable<Observation> k_ = context.Operators.Where<Observation>((IEnumerable<Observation>)i_, j_);
        Observation l_ = context.Operators.SingletonFrom<Observation>(k_);
        return l_;
    }


    [CqlExpressionDefinition("Most Recent PSA Test Result is Low")]
    public bool? Most_Recent_PSA_Test_Result_is_Low(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Most_Recent_PSA_Test_Result_is_Low, Most_Recent_PSA_Test_Result_is_Low_Compute);

    private const long _cacheIndex_Most_Recent_PSA_Test_Result_is_Low = 7161242736514616586L;

    private bool? Most_Recent_PSA_Test_Result_is_Low_Compute(CqlContext context)
    {
        CqlValueSet a_ = this.Prostate_Specific_Antigen_Test(context);
        IEnumerable<Observation> b_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation-lab"));

        bool? c_(Observation PSATest) {
            Observation m_ = this.Most_Recent_Prostate_Cancer_Staging_Tumor_Size_T1a_to_T2a(context);
            Observation[] n_ = [
                m_,
            ];

            bool? o_(Observation MostRecentProstateCancerStaging) {
                CqlInterval<CqlDateTime> r_;
                DataType ac_ = PSATest?.Effective;
                object ad_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ac_);
                CqlInterval<CqlDateTime> ae_ = QICoreCommon_4_0_000.Instance.toInterval(context, ad_);
                CqlDateTime af_ = context.Operators.Start(ae_);
                if (af_ is null)
                {
                    r_ = default;
                }
                else
                {
                    DataType ag_ = PSATest?.Effective;
                    object ah_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ag_);
                    CqlInterval<CqlDateTime> ai_ = QICoreCommon_4_0_000.Instance.toInterval(context, ah_);
                    CqlDateTime aj_ = context.Operators.Start(ai_);
                    CqlInterval<CqlDateTime> ak_ = context.Operators.Interval(aj_, aj_, true, true);
                    r_ = ak_;
                }
                DataType s_ = MostRecentProstateCancerStaging?.Effective;
                object t_ = FHIRHelpers_4_4_000.Instance.ToValue(context, s_);
                CqlInterval<CqlDateTime> u_ = QICoreCommon_4_0_000.Instance.toInterval(context, t_);
                bool? v_ = context.Operators.Before(r_, u_, (string)default);
                Code<ObservationStatus> w_ = PSATest?.StatusElement;
                ObservationStatus? x_ = w_?.Value;
                string y_ = context.Operators.Convert<string>(x_);
                string[] z_ = [
                    "final",
                    "amended",
                    "corrected",
                ];
                bool? aa_ = context.Operators.In<string>(y_, (IEnumerable<string>)z_);
                bool? ab_ = context.Operators.And(v_, aa_);
                return ab_;
            }

            IEnumerable<Observation> p_ = context.Operators.Where<Observation>((IEnumerable<Observation>)n_, o_);
            bool? q_ = context.Operators.Exists<Observation>(p_);
            return q_;
        }

        IEnumerable<Observation> d_ = context.Operators.Where<Observation>(b_, c_);

        object e_(Observation @this) {
            DataType al_ = @this?.Effective;
            object am_ = FHIRHelpers_4_4_000.Instance.ToValue(context, al_);
            CqlInterval<CqlDateTime> an_ = QICoreCommon_4_0_000.Instance.toInterval(context, am_);
            CqlDateTime ao_ = context.Operators.Start(an_);
            return ao_;
        }

        IEnumerable<Observation> f_ = context.Operators.SortBy<Observation>(d_, e_, System.ComponentModel.ListSortDirection.Ascending);
        Observation g_ = context.Operators.Last<Observation>(f_);
        Observation[] h_ = [
            g_,
        ];

        bool? i_(Observation LastPSATest) {
            DataType ap_ = LastPSATest?.Value;
            object aq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ap_);
            CqlQuantity ar_ = context.Operators.Quantity(10m, "ng/mL");
            bool? as_ = context.Operators.Less(aq_ as CqlQuantity, ar_);
            return as_;
        }

        IEnumerable<bool?> j_ = context.Operators.Select<Observation, bool?>((IEnumerable<Observation>)h_, i_);
        IEnumerable<bool?> k_ = context.Operators.Distinct<bool?>(j_);
        bool? l_ = context.Operators.SingletonFrom<bool?>(k_);
        return l_;
    }


    [CqlExpressionDefinition("Most Recent Gleason Score is Low")]
    public bool? Most_Recent_Gleason_Score_is_Low(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Most_Recent_Gleason_Score_is_Low, Most_Recent_Gleason_Score_is_Low_Compute);

    private const long _cacheIndex_Most_Recent_Gleason_Score_is_Low = 7358005442362079522L;

    private bool? Most_Recent_Gleason_Score_is_Low_Compute(CqlContext context)
    {
        CqlCode a_ = this.Gleason_score_in_Specimen_Qualitative(context);
        IEnumerable<CqlCode> b_ = context.Operators.ToList<CqlCode>(a_);
        IEnumerable<Observation> c_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, b_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation-clinical-result"));

        bool? d_(Observation GleasonScore) {
            Procedure n_ = this.First_Prostate_Cancer_Treatment_during_day_of_Measurement_Period(context);
            Procedure[] o_ = [
                n_,
            ];

            bool? p_(Procedure FirstProstateCancerTreatment) {
                DataType s_ = GleasonScore?.Effective;
                object t_ = FHIRHelpers_4_4_000.Instance.ToValue(context, s_);
                CqlInterval<CqlDateTime> u_ = QICoreCommon_4_0_000.Instance.toInterval(context, t_);
                CqlDateTime v_ = context.Operators.Start(u_);
                object w_;
                DataType ag_ = FirstProstateCancerTreatment?.Performed;
                object ah_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ag_);
                bool ai_ = ah_ is CqlDateTime;
                if (ai_)
                {
                    DataType aj_ = FirstProstateCancerTreatment?.Performed;
                    object ak_ = FHIRHelpers_4_4_000.Instance.ToValue(context, aj_);
                    w_ = ak_ as CqlDateTime;
                }
                else
                {
                    DataType al_ = FirstProstateCancerTreatment?.Performed;
                    object am_ = FHIRHelpers_4_4_000.Instance.ToValue(context, al_);
                    bool an_ = am_ is CqlInterval<CqlDateTime>;
                    if (an_)
                    {
                        DataType ao_ = FirstProstateCancerTreatment?.Performed;
                        object ap_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ao_);
                        w_ = ap_ as CqlInterval<CqlDateTime>;
                    }
                    else
                    {
                        DataType aq_ = FirstProstateCancerTreatment?.Performed;
                        object ar_ = FHIRHelpers_4_4_000.Instance.ToValue(context, aq_);
                        bool as_ = ar_ is CqlQuantity;
                        if (as_)
                        {
                            DataType at_ = FirstProstateCancerTreatment?.Performed;
                            object au_ = FHIRHelpers_4_4_000.Instance.ToValue(context, at_);
                            w_ = au_ as CqlQuantity;
                        }
                        else
                        {
                            DataType av_ = FirstProstateCancerTreatment?.Performed;
                            object aw_ = FHIRHelpers_4_4_000.Instance.ToValue(context, av_);
                            bool ax_ = aw_ is CqlInterval<CqlQuantity>;
                            if (ax_)
                            {
                                DataType ay_ = FirstProstateCancerTreatment?.Performed;
                                object az_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ay_);
                                w_ = az_ as CqlInterval<CqlQuantity>;
                            }
                            else
                            {
                                w_ = null;
                            }
                        }
                    }
                }
                CqlInterval<CqlDateTime> x_ = QICoreCommon_4_0_000.Instance.toInterval(context, w_);
                CqlDateTime y_ = context.Operators.Start(x_);
                bool? z_ = context.Operators.Before(v_, y_, (string)default);
                Code<ObservationStatus> aa_ = GleasonScore?.StatusElement;
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

            IEnumerable<Procedure> q_ = context.Operators.Where<Procedure>((IEnumerable<Procedure>)o_, p_);
            bool? r_ = context.Operators.Exists<Procedure>(q_);
            return r_;
        }

        IEnumerable<Observation> e_ = context.Operators.Where<Observation>(c_, d_);

        object f_(Observation @this) {
            DataType ba_ = @this?.Effective;
            object bb_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ba_);
            CqlInterval<CqlDateTime> bc_ = QICoreCommon_4_0_000.Instance.toInterval(context, bb_);
            CqlDateTime bd_ = context.Operators.Start(bc_);
            return bd_;
        }

        IEnumerable<Observation> g_ = context.Operators.SortBy<Observation>(e_, f_, System.ComponentModel.ListSortDirection.Ascending);
        Observation h_ = context.Operators.Last<Observation>(g_);
        Observation[] i_ = [
            h_,
        ];

        bool? j_(Observation LastGleasonScore) {
            DataType be_ = LastGleasonScore?.Value;
            object bf_ = FHIRHelpers_4_4_000.Instance.ToValue(context, be_);
            bool? bg_ = context.Operators.LessOrEqual(bf_ as int?, 6);
            return bg_;
        }

        IEnumerable<bool?> k_ = context.Operators.Select<Observation, bool?>((IEnumerable<Observation>)i_, j_);
        IEnumerable<bool?> l_ = context.Operators.Distinct<bool?>(k_);
        bool? m_ = context.Operators.SingletonFrom<bool?>(l_);
        return m_;
    }


    [CqlExpressionDefinition("Denominator")]
    public bool? Denominator(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Denominator, Denominator_Compute);

    private const long _cacheIndex_Denominator = 1246872489746454659L;

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

    private const long _cacheIndex_Bone_Scan_Study_Performed = 288628587474938786L;

    private IEnumerable<Observation> Bone_Scan_Study_Performed_Compute(CqlContext context)
    {
        CqlValueSet a_ = this.Bone_Scan(context);
        IEnumerable<Observation> b_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation-clinical-result"));

        bool? c_(Observation BoneScan) {
            IEnumerable<Condition> g_ = this.Prostate_Cancer_Diagnosis(context);

            bool? h_(Condition ActiveProstateCancer) {
                DataType k_ = BoneScan?.Effective;
                object l_ = FHIRHelpers_4_4_000.Instance.ToValue(context, k_);
                CqlInterval<CqlDateTime> m_ = QICoreCommon_4_0_000.Instance.toInterval(context, l_);
                CqlDateTime n_ = context.Operators.Start(m_);
                CqlInterval<CqlDateTime> o_ = QICoreCommon_4_0_000.Instance.prevalenceInterval(context, ActiveProstateCancer as Condition);
                CqlDateTime p_ = context.Operators.Start(o_);
                bool? q_ = context.Operators.After(n_, p_, (string)default);
                return q_;
            }

            IEnumerable<Condition> i_ = context.Operators.Where<Condition>(g_, h_);
            bool? j_ = context.Operators.Exists<Condition>(i_);
            return j_;
        }

        IEnumerable<Observation> d_ = context.Operators.Where<Observation>(b_, c_);

        bool? e_(Observation BoneScan) {
            DataType r_ = BoneScan?.Effective;
            object s_ = FHIRHelpers_4_4_000.Instance.ToValue(context, r_);
            CqlInterval<CqlDateTime> t_ = QICoreCommon_4_0_000.Instance.toInterval(context, s_);
            CqlDateTime u_ = context.Operators.End(t_);
            CqlInterval<CqlDateTime> v_ = this.Measurement_Period(context);
            bool? w_ = context.Operators.In<CqlDateTime>(u_, v_, "day");
            Code<ObservationStatus> x_ = BoneScan?.StatusElement;
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

        IEnumerable<Observation> f_ = context.Operators.Where<Observation>(d_, e_);
        return f_;
    }


    [CqlExpressionDefinition("Numerator")]
    public bool? Numerator(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Numerator, Numerator_Compute);

    private const long _cacheIndex_Numerator = 7820927283973067551L;

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

    private const long _cacheIndex_Has_Diagnosis_of_Pain_related_to_Prostate_Cancer = 1074005850507574754L;

    private bool? Has_Diagnosis_of_Pain_related_to_Prostate_Cancer_Compute(CqlContext context)
    {
        CqlValueSet a_ = this.Pain_Warranting_Further_Investigation_for_Prostate_Cancer(context);
        IEnumerable<Condition> b_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-problems-health-concerns"));
        IEnumerable<Condition> c_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-encounter-diagnosis"));
        IEnumerable<Condition> d_ = context.Operators.Union<Condition>(b_ as IEnumerable<Condition>, c_ as IEnumerable<Condition>);

        bool? e_(Condition ProstateCancerPain) {
            IEnumerable<Condition> h_ = this.Prostate_Cancer_Diagnosis(context);

            bool? i_(Condition ActiveProstateCancer) {
                CqlInterval<CqlDateTime> l_ = QICoreCommon_4_0_000.Instance.prevalenceInterval(context, ProstateCancerPain);
                CqlDateTime m_ = context.Operators.Start(l_);
                CqlInterval<CqlDateTime> n_ = QICoreCommon_4_0_000.Instance.prevalenceInterval(context, ActiveProstateCancer as Condition);
                CqlDateTime o_ = context.Operators.Start(n_);
                bool? p_ = context.Operators.After(m_, o_, (string)default);
                bool? q_ = this.isVerified(context, ProstateCancerPain);
                bool? r_ = context.Operators.And(p_, q_);
                return r_;
            }

            IEnumerable<Condition> j_ = context.Operators.Where<Condition>(h_, i_);
            bool? k_ = context.Operators.Exists<Condition>(j_);
            return k_;
        }

        IEnumerable<Condition> f_ = context.Operators.Where<Condition>(d_, e_);
        bool? g_ = context.Operators.Exists<Condition>(f_);
        return g_;
    }


    [CqlExpressionDefinition("Has Salvage Therapy Performed after Prostate Cancer Diagnosis")]
    public bool? Has_Salvage_Therapy_Performed_after_Prostate_Cancer_Diagnosis(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Has_Salvage_Therapy_Performed_after_Prostate_Cancer_Diagnosis, Has_Salvage_Therapy_Performed_after_Prostate_Cancer_Diagnosis_Compute);

    private const long _cacheIndex_Has_Salvage_Therapy_Performed_after_Prostate_Cancer_Diagnosis = 814682402894497576L;

    private bool? Has_Salvage_Therapy_Performed_after_Prostate_Cancer_Diagnosis_Compute(CqlContext context)
    {
        CqlValueSet a_ = this.Salvage_Therapy(context);
        IEnumerable<Procedure> b_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));

        bool? c_(Procedure SalvageTherapy) {
            IEnumerable<Condition> f_ = this.Prostate_Cancer_Diagnosis(context);

            bool? g_(Condition ActiveProstateCancer) {
                object j_;
                DataType u_ = SalvageTherapy?.Performed;
                object v_ = FHIRHelpers_4_4_000.Instance.ToValue(context, u_);
                bool w_ = v_ is CqlDateTime;
                if (w_)
                {
                    DataType x_ = SalvageTherapy?.Performed;
                    object y_ = FHIRHelpers_4_4_000.Instance.ToValue(context, x_);
                    j_ = y_ as CqlDateTime;
                }
                else
                {
                    DataType z_ = SalvageTherapy?.Performed;
                    object aa_ = FHIRHelpers_4_4_000.Instance.ToValue(context, z_);
                    bool ab_ = aa_ is CqlInterval<CqlDateTime>;
                    if (ab_)
                    {
                        DataType ac_ = SalvageTherapy?.Performed;
                        object ad_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ac_);
                        j_ = ad_ as CqlInterval<CqlDateTime>;
                    }
                    else
                    {
                        DataType ae_ = SalvageTherapy?.Performed;
                        object af_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ae_);
                        bool ag_ = af_ is CqlQuantity;
                        if (ag_)
                        {
                            DataType ah_ = SalvageTherapy?.Performed;
                            object ai_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ah_);
                            j_ = ai_ as CqlQuantity;
                        }
                        else
                        {
                            DataType aj_ = SalvageTherapy?.Performed;
                            object ak_ = FHIRHelpers_4_4_000.Instance.ToValue(context, aj_);
                            bool al_ = ak_ is CqlInterval<CqlQuantity>;
                            if (al_)
                            {
                                DataType am_ = SalvageTherapy?.Performed;
                                object an_ = FHIRHelpers_4_4_000.Instance.ToValue(context, am_);
                                j_ = an_ as CqlInterval<CqlQuantity>;
                            }
                            else
                            {
                                j_ = null;
                            }
                        }
                    }
                }
                CqlInterval<CqlDateTime> k_ = QICoreCommon_4_0_000.Instance.toInterval(context, j_);
                CqlDateTime l_ = context.Operators.Start(k_);
                CqlInterval<CqlDateTime> m_ = QICoreCommon_4_0_000.Instance.prevalenceInterval(context, ActiveProstateCancer as Condition);
                CqlDateTime n_ = context.Operators.Start(m_);
                bool? o_ = context.Operators.After(l_, n_, (string)default);
                Code<EventStatus> p_ = SalvageTherapy?.StatusElement;
                EventStatus? q_ = p_?.Value;
                string r_ = context.Operators.Convert<string>(q_);
                bool? s_ = context.Operators.Equal(r_, "completed");
                bool? t_ = context.Operators.And(o_, s_);
                return t_;
            }

            IEnumerable<Condition> h_ = context.Operators.Where<Condition>(f_, g_);
            bool? i_ = context.Operators.Exists<Condition>(h_);
            return i_;
        }

        IEnumerable<Procedure> d_ = context.Operators.Where<Procedure>(b_, c_);
        bool? e_ = context.Operators.Exists<Procedure>(d_);
        return e_;
    }


    [CqlExpressionDefinition("Has Bone Scan Study Performed with Documented Reason")]
    public bool? Has_Bone_Scan_Study_Performed_with_Documented_Reason(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Has_Bone_Scan_Study_Performed_with_Documented_Reason, Has_Bone_Scan_Study_Performed_with_Documented_Reason_Compute);

    private const long _cacheIndex_Has_Bone_Scan_Study_Performed_with_Documented_Reason = -57594536143353413L;

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

    private const long _cacheIndex_Denominator_Exceptions = -2111890706368566952L;

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

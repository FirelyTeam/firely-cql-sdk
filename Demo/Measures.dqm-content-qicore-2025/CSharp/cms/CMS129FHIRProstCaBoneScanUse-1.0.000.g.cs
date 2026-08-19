#nullable enable annotations

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

[System.CodeDom.Compiler.GeneratedCode(".NET Code Generation", "5.3.0.0")]
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
    public CqlInterval<CqlDateTime?>? Measurement_Period(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Measurement_Period, Measurement_Period_Compute);

    private const long _cacheIndex_Measurement_Period = -8140283047952446050L;

    private CqlInterval<CqlDateTime?>? Measurement_Period_Compute(CqlContext context)
    {
        CqlDateTime? a_ = context.Operators.DateTime(2026, 1, 1, 0, 0, 0, 0, 0.0m);
        CqlDateTime? b_ = context.Operators.DateTime(2027, 1, 1, 0, 0, 0, 0, 0.0m);
        CqlInterval<CqlDateTime?>? c_ = context.Operators.Interval(a_, b_, true, false);
        object? d_ = context.ResolveParameter("CMS129FHIRProstCaBoneScanUse-1.0.000", "Measurement Period", c_);
        return (CqlInterval<CqlDateTime?>?)d_;
    }


    #endregion Parameters

    #region Functions and Expressions (19)

    [CqlExpressionDefinition("Patient")]
    public Patient? Patient(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Patient, Patient_Compute);

    private const long _cacheIndex_Patient = 4406994424031691662L;

    private Patient? Patient_Compute(CqlContext context)
    {
        IEnumerable<Patient?>? a_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-patient"));
        Patient? b_ = context.Operators.SingletonFrom<Patient?>(a_);
        return b_;
    }


    [CqlExpressionDefinition("SDE Ethnicity")]
    public (CqlTupleMetadata, IEnumerable<CqlCode?>? codes, string? display)? SDE_Ethnicity(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_SDE_Ethnicity, SDE_Ethnicity_Compute);

    private const long _cacheIndex_SDE_Ethnicity = -3741220856752493112L;

    private (CqlTupleMetadata, IEnumerable<CqlCode?>? codes, string? display)? SDE_Ethnicity_Compute(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode?>? codes, string? display)? a_ = SupplementalDataElements_5_1_000.Instance.SDE_Ethnicity(context);
        return a_;
    }


    [CqlExpressionDefinition("SDE Payer")]
    public IEnumerable<(CqlTupleMetadata, CqlConcept? code, CqlInterval<CqlDateTime?>? period)?>? SDE_Payer(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_SDE_Payer, SDE_Payer_Compute);

    private const long _cacheIndex_SDE_Payer = -2432525633866877819L;

    private IEnumerable<(CqlTupleMetadata, CqlConcept? code, CqlInterval<CqlDateTime?>? period)?>? SDE_Payer_Compute(CqlContext context)
    {
        IEnumerable<(CqlTupleMetadata, CqlConcept? code, CqlInterval<CqlDateTime?>? period)?>? a_ = SupplementalDataElements_5_1_000.Instance.SDE_Payer(context);
        return a_;
    }


    [CqlExpressionDefinition("SDE Race")]
    public (CqlTupleMetadata, IEnumerable<CqlCode?>? codes, string? display)? SDE_Race(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_SDE_Race, SDE_Race_Compute);

    private const long _cacheIndex_SDE_Race = 3157958782746268240L;

    private (CqlTupleMetadata, IEnumerable<CqlCode?>? codes, string? display)? SDE_Race_Compute(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode?>? codes, string? display)? a_ = SupplementalDataElements_5_1_000.Instance.SDE_Race(context);
        return a_;
    }


    [CqlExpressionDefinition("SDE Sex")]
    public CqlCode? SDE_Sex(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_SDE_Sex, SDE_Sex_Compute);

    private const long _cacheIndex_SDE_Sex = 5879459535837422408L;

    private CqlCode? SDE_Sex_Compute(CqlContext context)
    {
        CqlCode? a_ = SupplementalDataElements_5_1_000.Instance.SDE_Sex(context);
        return a_;
    }


    [CqlFunctionDefinition("isVerified")]
    [CqlTag("note", "When possible, this function should be migrated to QICoreCommon.")]
    [CqlTag("description", "\"confirmed\", \"unconfirmed\", \"provisional\", or \"differential\"")]
    public bool? isVerified(CqlContext context, Condition? condition)
    {
        CodeableConcept? a_ = condition?.VerificationStatus;
        CqlConcept? b_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, a_);
        bool? c_ = context.Operators.Not((bool?)(b_ is null));
        CqlCode? d_ = QICoreCommon_4_0_000.Instance.confirmed(context);
        CqlConcept? e_ = context.Operators.ConvertCodeToConcept(d_);
        bool? f_ = context.Operators.Equivalent(b_, e_);
        CqlCode? g_ = QICoreCommon_4_0_000.Instance.unconfirmed(context);
        CqlConcept? h_ = context.Operators.ConvertCodeToConcept(g_);
        bool? i_ = context.Operators.Equivalent(b_, h_);
        bool? j_ = context.Operators.Or(f_, i_);
        CqlCode? k_ = QICoreCommon_4_0_000.Instance.provisional(context);
        CqlConcept? l_ = context.Operators.ConvertCodeToConcept(k_);
        bool? m_ = context.Operators.Equivalent(b_, l_);
        bool? n_ = context.Operators.Or(j_, m_);
        CqlCode? o_ = QICoreCommon_4_0_000.Instance.differential(context);
        CqlConcept? p_ = context.Operators.ConvertCodeToConcept(o_);
        bool? q_ = context.Operators.Equivalent(b_, p_);
        bool? r_ = context.Operators.Or(n_, q_);
        bool? s_ = context.Operators.Implies(c_, r_);
        return s_;
    }


    [CqlExpressionDefinition("Prostate Cancer Diagnosis")]
    public IEnumerable<Condition?>? Prostate_Cancer_Diagnosis(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Prostate_Cancer_Diagnosis, Prostate_Cancer_Diagnosis_Compute);

    private const long _cacheIndex_Prostate_Cancer_Diagnosis = 7069960912159893930L;

    private IEnumerable<Condition?>? Prostate_Cancer_Diagnosis_Compute(CqlContext context)
    {
        CqlValueSet? a_ = this.Prostate_Cancer(context);
        IEnumerable<Condition?>? b_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-problems-health-concerns"));

        bool? c_(Condition? ProstateCancer) {
            CqlInterval<CqlDateTime?>? e_ = QICoreCommon_4_0_000.Instance.prevalenceInterval(context, ProstateCancer as Condition);
            CqlInterval<CqlDateTime?>? f_ = this.Measurement_Period(context);
            bool? g_ = context.Operators.Overlaps(e_, f_, "day");
            bool? h_ = this.isVerified(context, ProstateCancer as Condition);
            bool? i_ = context.Operators.And(g_, h_);
            return i_;
        }

        IEnumerable<Condition?>? d_ = context.Operators.Where<Condition?>(b_, c_);
        return d_;
    }


    [CqlExpressionDefinition("Initial Population")]
    public bool? Initial_Population(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Initial_Population, Initial_Population_Compute);

    private const long _cacheIndex_Initial_Population = 6349217679780301784L;

    private bool? Initial_Population_Compute(CqlContext context)
    {
        IEnumerable<Condition?>? a_ = this.Prostate_Cancer_Diagnosis(context);
        bool? b_ = context.Operators.Exists<Condition?>(a_);
        return b_;
    }


    [CqlExpressionDefinition("First Prostate Cancer Treatment during day of Measurement Period")]
    public Procedure? First_Prostate_Cancer_Treatment_during_day_of_Measurement_Period(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_First_Prostate_Cancer_Treatment_during_day_of_Measurement_Period, First_Prostate_Cancer_Treatment_during_day_of_Measurement_Period_Compute);

    private const long _cacheIndex_First_Prostate_Cancer_Treatment_during_day_of_Measurement_Period = 2835648534723621959L;

    private Procedure? First_Prostate_Cancer_Treatment_during_day_of_Measurement_Period_Compute(CqlContext context)
    {
        CqlValueSet? a_ = this.Prostate_Cancer_Treatment(context);
        IEnumerable<Procedure?>? b_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));

        bool? c_(Procedure? ProstateCancerTreatment) {
            object? h_;
            DataType? r_ = ProstateCancerTreatment?.Performed;
            object? s_ = FHIRHelpers_4_4_000.Instance.ToValue(context, r_);
            bool t_ = s_ is CqlDateTime;
            if (t_)
            {
                DataType? u_ = ProstateCancerTreatment?.Performed;
                object? v_ = FHIRHelpers_4_4_000.Instance.ToValue(context, u_);
                h_ = v_ as CqlDateTime;
            }
            else
            {
                DataType? w_ = ProstateCancerTreatment?.Performed;
                object? x_ = FHIRHelpers_4_4_000.Instance.ToValue(context, w_);
                bool y_ = x_ is CqlQuantity;
                if (y_)
                {
                    DataType? z_ = ProstateCancerTreatment?.Performed;
                    object? aa_ = FHIRHelpers_4_4_000.Instance.ToValue(context, z_);
                    h_ = aa_ as CqlQuantity;
                }
                else
                {
                    DataType? ab_ = ProstateCancerTreatment?.Performed;
                    object? ac_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ab_);
                    bool ad_ = ac_ is CqlInterval<CqlDateTime>;
                    if (ad_)
                    {
                        DataType? ae_ = ProstateCancerTreatment?.Performed;
                        object? af_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ae_);
                        h_ = af_ as CqlInterval<CqlDateTime?>;
                    }
                    else
                    {
                        DataType? ag_ = ProstateCancerTreatment?.Performed;
                        object? ah_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ag_);
                        bool ai_ = ah_ is CqlInterval<CqlQuantity>;
                        if (ai_)
                        {
                            DataType? aj_ = ProstateCancerTreatment?.Performed;
                            object? ak_ = FHIRHelpers_4_4_000.Instance.ToValue(context, aj_);
                            h_ = ak_ as CqlInterval<CqlQuantity?>;
                        }
                        else
                        {
                            h_ = null;
                        }
                    }
                }
            }
            CqlInterval<CqlDateTime?>? i_ = QICoreCommon_4_0_000.Instance.toInterval(context, h_);
            CqlDateTime? j_ = context.Operators.End(i_);
            CqlInterval<CqlDateTime?>? k_ = this.Measurement_Period(context);
            bool? l_ = context.Operators.In<CqlDateTime?>(j_, k_, "day");
            Code<EventStatus>? m_ = ProstateCancerTreatment?.StatusElement;
            EventStatus? n_ = m_?.Value;
            string? o_ = context.Operators.Convert<string?>(n_);
            bool? p_ = context.Operators.Equal(o_, "completed");
            bool? q_ = context.Operators.And(l_, p_);
            return q_;
        }

        IEnumerable<Procedure?>? d_ = context.Operators.Where<Procedure?>(b_, c_);

        object e_(Procedure? @this) {
            object? al_;
            DataType? ao_ = @this?.Performed;
            object? ap_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ao_);
            bool aq_ = ap_ is CqlDateTime;
            if (aq_)
            {
                DataType? ar_ = @this?.Performed;
                object? as_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ar_);
                al_ = as_ as CqlDateTime;
            }
            else
            {
                DataType? at_ = @this?.Performed;
                object? au_ = FHIRHelpers_4_4_000.Instance.ToValue(context, at_);
                bool av_ = au_ is CqlQuantity;
                if (av_)
                {
                    DataType? aw_ = @this?.Performed;
                    object? ax_ = FHIRHelpers_4_4_000.Instance.ToValue(context, aw_);
                    al_ = ax_ as CqlQuantity;
                }
                else
                {
                    DataType? ay_ = @this?.Performed;
                    object? az_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ay_);
                    bool ba_ = az_ is CqlInterval<CqlDateTime>;
                    if (ba_)
                    {
                        DataType? bb_ = @this?.Performed;
                        object? bc_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bb_);
                        al_ = bc_ as CqlInterval<CqlDateTime?>;
                    }
                    else
                    {
                        DataType? bd_ = @this?.Performed;
                        object? be_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bd_);
                        bool bf_ = be_ is CqlInterval<CqlQuantity>;
                        if (bf_)
                        {
                            DataType? bg_ = @this?.Performed;
                            object? bh_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bg_);
                            al_ = bh_ as CqlInterval<CqlQuantity?>;
                        }
                        else
                        {
                            al_ = null;
                        }
                    }
                }
            }
            CqlInterval<CqlDateTime?>? am_ = QICoreCommon_4_0_000.Instance.toInterval(context, al_);
            CqlDateTime? an_ = context.Operators.Start(am_);
            return an_!;
        }

        IEnumerable<Procedure?>? f_ = context.Operators.SortBy<Procedure?>(d_, e_, System.ComponentModel.ListSortDirection.Ascending);
        Procedure? g_ = context.Operators.First<Procedure?>(f_);
        return g_;
    }


    [CqlExpressionDefinition("Most Recent Prostate Cancer Staging Tumor Size T1a to T2a")]
    public Observation? Most_Recent_Prostate_Cancer_Staging_Tumor_Size_T1a_to_T2a(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Most_Recent_Prostate_Cancer_Staging_Tumor_Size_T1a_to_T2a, Most_Recent_Prostate_Cancer_Staging_Tumor_Size_T1a_to_T2a_Compute);

    private const long _cacheIndex_Most_Recent_Prostate_Cancer_Staging_Tumor_Size_T1a_to_T2a = -4176122043776704687L;

    private Observation? Most_Recent_Prostate_Cancer_Staging_Tumor_Size_T1a_to_T2a_Compute(CqlContext context)
    {
        CqlCode? a_ = this.Tumor_staging__tumor_staging_(context);
        IEnumerable<CqlCode?>? b_ = context.Operators.ToList<CqlCode?>(a_);
        IEnumerable<Observation?>? c_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, b_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation-clinical-result"));

        bool? d_(Observation? ProstateCancerStaging) {
            Procedure? m_ = this.First_Prostate_Cancer_Treatment_during_day_of_Measurement_Period(context);
            Procedure?[]? n_ = [
                m_,
            ];

            bool? o_(Procedure? FirstProstateCancerTreatment) {
                DataType? q_ = ProstateCancerStaging?.Effective;
                object? r_ = FHIRHelpers_4_4_000.Instance.ToValue(context, q_);
                CqlInterval<CqlDateTime?>? s_ = QICoreCommon_4_0_000.Instance.toInterval(context, r_);
                CqlDateTime? t_ = context.Operators.Start(s_);
                object? u_;
                DataType? ae_ = FirstProstateCancerTreatment?.Performed;
                object? af_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ae_);
                bool ag_ = af_ is CqlDateTime;
                if (ag_)
                {
                    DataType? ah_ = FirstProstateCancerTreatment?.Performed;
                    object? ai_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ah_);
                    u_ = ai_ as CqlDateTime;
                }
                else
                {
                    DataType? aj_ = FirstProstateCancerTreatment?.Performed;
                    object? ak_ = FHIRHelpers_4_4_000.Instance.ToValue(context, aj_);
                    bool al_ = ak_ is CqlQuantity;
                    if (al_)
                    {
                        DataType? am_ = FirstProstateCancerTreatment?.Performed;
                        object? an_ = FHIRHelpers_4_4_000.Instance.ToValue(context, am_);
                        u_ = an_ as CqlQuantity;
                    }
                    else
                    {
                        DataType? ao_ = FirstProstateCancerTreatment?.Performed;
                        object? ap_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ao_);
                        bool aq_ = ap_ is CqlInterval<CqlDateTime>;
                        if (aq_)
                        {
                            DataType? ar_ = FirstProstateCancerTreatment?.Performed;
                            object? as_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ar_);
                            u_ = as_ as CqlInterval<CqlDateTime?>;
                        }
                        else
                        {
                            DataType? at_ = FirstProstateCancerTreatment?.Performed;
                            object? au_ = FHIRHelpers_4_4_000.Instance.ToValue(context, at_);
                            bool av_ = au_ is CqlInterval<CqlQuantity>;
                            if (av_)
                            {
                                DataType? aw_ = FirstProstateCancerTreatment?.Performed;
                                object? ax_ = FHIRHelpers_4_4_000.Instance.ToValue(context, aw_);
                                u_ = ax_ as CqlInterval<CqlQuantity?>;
                            }
                            else
                            {
                                u_ = null;
                            }
                        }
                    }
                }
                CqlInterval<CqlDateTime?>? v_ = QICoreCommon_4_0_000.Instance.toInterval(context, u_);
                CqlDateTime? w_ = context.Operators.Start(v_);
                bool? x_ = context.Operators.Before(t_, w_, (string?)default);
                Code<ObservationStatus>? y_ = ProstateCancerStaging?.StatusElement;
                ObservationStatus? z_ = y_?.Value;
                string? aa_ = context.Operators.Convert<string?>(z_);
                string?[]? ab_ = [
                    "final",
                    "amended",
                    "corrected",
                ];
                bool? ac_ = context.Operators.In<string?>(aa_, (IEnumerable<string?>?)ab_);
                bool? ad_ = context.Operators.And(x_, ac_);
                return ad_;
            }

            bool? p_ = context.Operators.WhereAny<Procedure?>((IEnumerable<Procedure?>?)n_, o_);
            return p_;
        }

        IEnumerable<Observation?>? e_ = context.Operators.Where<Observation?>(c_, d_);

        object f_(Observation? @this) {
            DataType? ay_ = @this?.Effective;
            object? az_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ay_);
            CqlInterval<CqlDateTime?>? ba_ = QICoreCommon_4_0_000.Instance.toInterval(context, az_);
            CqlDateTime? bb_ = context.Operators.Start(ba_);
            return bb_!;
        }

        IEnumerable<Observation?>? g_ = context.Operators.SortBy<Observation?>(e_, f_, System.ComponentModel.ListSortDirection.Ascending);
        Observation? h_ = context.Operators.Last<Observation?>(g_);
        Observation?[]? i_ = [
            h_,
        ];

        bool? j_(Observation? LastProstateCancerStaging) {
            DataType? bc_ = LastProstateCancerStaging?.Value;
            object? bd_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bc_);
            CqlCode? be_ = this.American_Joint_Committee_on_Cancer_cT1a__qualifier_value_(context);
            CqlConcept? bf_ = context.Operators.ConvertCodeToConcept(be_);
            bool? bg_ = context.Operators.Equivalent(bd_ as CqlConcept, bf_);
            CqlCode? bh_ = this.American_Joint_Committee_on_Cancer_cT1b__qualifier_value_(context);
            CqlConcept? bi_ = context.Operators.ConvertCodeToConcept(bh_);
            bool? bj_ = context.Operators.Equivalent(bd_ as CqlConcept, bi_);
            bool? bk_ = context.Operators.Or(bg_, bj_);
            CqlCode? bl_ = this.American_Joint_Committee_on_Cancer_cT1c__qualifier_value_(context);
            CqlConcept? bm_ = context.Operators.ConvertCodeToConcept(bl_);
            bool? bn_ = context.Operators.Equivalent(bd_ as CqlConcept, bm_);
            bool? bo_ = context.Operators.Or(bk_, bn_);
            CqlCode? bp_ = this.American_Joint_Committee_on_Cancer_cT2a__qualifier_value_(context);
            CqlConcept? bq_ = context.Operators.ConvertCodeToConcept(bp_);
            bool? br_ = context.Operators.Equivalent(bd_ as CqlConcept, bq_);
            bool? bs_ = context.Operators.Or(bo_, br_);
            return bs_;
        }

        IEnumerable<Observation?>? k_ = context.Operators.Where<Observation?>((IEnumerable<Observation?>?)i_, j_);
        Observation? l_ = context.Operators.SingletonFrom<Observation?>(k_);
        return l_;
    }


    [CqlExpressionDefinition("Most Recent PSA Test Result is Low")]
    public bool? Most_Recent_PSA_Test_Result_is_Low(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Most_Recent_PSA_Test_Result_is_Low, Most_Recent_PSA_Test_Result_is_Low_Compute);

    private const long _cacheIndex_Most_Recent_PSA_Test_Result_is_Low = 7161242736514616586L;

    private bool? Most_Recent_PSA_Test_Result_is_Low_Compute(CqlContext context)
    {
        CqlValueSet? a_ = this.Prostate_Specific_Antigen_Test(context);
        IEnumerable<Observation?>? b_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation-lab"));

        bool? c_(Observation? PSATest) {
            Observation? l_ = this.Most_Recent_Prostate_Cancer_Staging_Tumor_Size_T1a_to_T2a(context);
            Observation?[]? m_ = [
                l_,
            ];

            bool? n_(Observation? MostRecentProstateCancerStaging) {
                CqlInterval<CqlDateTime>? p_;
                DataType? aa_ = PSATest?.Effective;
                object? ab_ = FHIRHelpers_4_4_000.Instance.ToValue(context, aa_);
                CqlInterval<CqlDateTime?>? ac_ = QICoreCommon_4_0_000.Instance.toInterval(context, ab_);
                CqlDateTime? ad_ = context.Operators.Start(ac_);
                if (ad_ is null)
                {
                    p_ = default;
                }
                else
                {
                    DataType? ae_ = PSATest?.Effective;
                    object? af_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ae_);
                    CqlInterval<CqlDateTime?>? ag_ = QICoreCommon_4_0_000.Instance.toInterval(context, af_);
                    CqlDateTime? ah_ = context.Operators.Start(ag_);
                    CqlInterval<CqlDateTime?>? ai_ = context.Operators.Interval(ah_, ah_, true, true);
                    p_ = ai_;
                }
                DataType? q_ = MostRecentProstateCancerStaging?.Effective;
                object? r_ = FHIRHelpers_4_4_000.Instance.ToValue(context, q_);
                CqlInterval<CqlDateTime?>? s_ = QICoreCommon_4_0_000.Instance.toInterval(context, r_);
                bool? t_ = context.Operators.Before(p_, s_, (string?)default);
                Code<ObservationStatus>? u_ = PSATest?.StatusElement;
                ObservationStatus? v_ = u_?.Value;
                string? w_ = context.Operators.Convert<string?>(v_);
                string?[]? x_ = [
                    "final",
                    "amended",
                    "corrected",
                ];
                bool? y_ = context.Operators.In<string?>(w_, (IEnumerable<string?>?)x_);
                bool? z_ = context.Operators.And(t_, y_);
                return z_;
            }

            bool? o_ = context.Operators.WhereAny<Observation?>((IEnumerable<Observation?>?)m_, n_);
            return o_;
        }

        IEnumerable<Observation?>? d_ = context.Operators.Where<Observation?>(b_, c_);

        object e_(Observation? @this) {
            DataType? aj_ = @this?.Effective;
            object? ak_ = FHIRHelpers_4_4_000.Instance.ToValue(context, aj_);
            CqlInterval<CqlDateTime?>? al_ = QICoreCommon_4_0_000.Instance.toInterval(context, ak_);
            CqlDateTime? am_ = context.Operators.Start(al_);
            return am_!;
        }

        IEnumerable<Observation?>? f_ = context.Operators.SortBy<Observation?>(d_, e_, System.ComponentModel.ListSortDirection.Ascending);
        Observation? g_ = context.Operators.Last<Observation?>(f_);
        Observation?[]? h_ = [
            g_,
        ];

        bool? i_(Observation? LastPSATest) {
            DataType? an_ = LastPSATest?.Value;
            object? ao_ = FHIRHelpers_4_4_000.Instance.ToValue(context, an_);
            CqlQuantity? ap_ = context.Operators.Quantity(10m, "ng/mL");
            bool? aq_ = context.Operators.Less(ao_ as CqlQuantity, ap_);
            return aq_;
        }

        IEnumerable<bool?>? j_ = context.Operators.SelectDistinct<Observation?, bool?>((IEnumerable<Observation?>?)h_, i_);
        bool? k_ = context.Operators.SingletonFrom<bool?>(j_);
        return k_;
    }


    [CqlExpressionDefinition("Most Recent Gleason Score is Low")]
    public bool? Most_Recent_Gleason_Score_is_Low(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Most_Recent_Gleason_Score_is_Low, Most_Recent_Gleason_Score_is_Low_Compute);

    private const long _cacheIndex_Most_Recent_Gleason_Score_is_Low = 7358005442362079522L;

    private bool? Most_Recent_Gleason_Score_is_Low_Compute(CqlContext context)
    {
        CqlCode? a_ = this.Gleason_score_in_Specimen_Qualitative(context);
        IEnumerable<CqlCode?>? b_ = context.Operators.ToList<CqlCode?>(a_);
        IEnumerable<Observation?>? c_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, b_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation-clinical-result"));

        bool? d_(Observation? GleasonScore) {
            Procedure? m_ = this.First_Prostate_Cancer_Treatment_during_day_of_Measurement_Period(context);
            Procedure?[]? n_ = [
                m_,
            ];

            bool? o_(Procedure? FirstProstateCancerTreatment) {
                DataType? q_ = GleasonScore?.Effective;
                object? r_ = FHIRHelpers_4_4_000.Instance.ToValue(context, q_);
                CqlInterval<CqlDateTime?>? s_ = QICoreCommon_4_0_000.Instance.toInterval(context, r_);
                CqlDateTime? t_ = context.Operators.Start(s_);
                object? u_;
                DataType? ae_ = FirstProstateCancerTreatment?.Performed;
                object? af_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ae_);
                bool ag_ = af_ is CqlDateTime;
                if (ag_)
                {
                    DataType? ah_ = FirstProstateCancerTreatment?.Performed;
                    object? ai_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ah_);
                    u_ = ai_ as CqlDateTime;
                }
                else
                {
                    DataType? aj_ = FirstProstateCancerTreatment?.Performed;
                    object? ak_ = FHIRHelpers_4_4_000.Instance.ToValue(context, aj_);
                    bool al_ = ak_ is CqlQuantity;
                    if (al_)
                    {
                        DataType? am_ = FirstProstateCancerTreatment?.Performed;
                        object? an_ = FHIRHelpers_4_4_000.Instance.ToValue(context, am_);
                        u_ = an_ as CqlQuantity;
                    }
                    else
                    {
                        DataType? ao_ = FirstProstateCancerTreatment?.Performed;
                        object? ap_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ao_);
                        bool aq_ = ap_ is CqlInterval<CqlDateTime>;
                        if (aq_)
                        {
                            DataType? ar_ = FirstProstateCancerTreatment?.Performed;
                            object? as_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ar_);
                            u_ = as_ as CqlInterval<CqlDateTime?>;
                        }
                        else
                        {
                            DataType? at_ = FirstProstateCancerTreatment?.Performed;
                            object? au_ = FHIRHelpers_4_4_000.Instance.ToValue(context, at_);
                            bool av_ = au_ is CqlInterval<CqlQuantity>;
                            if (av_)
                            {
                                DataType? aw_ = FirstProstateCancerTreatment?.Performed;
                                object? ax_ = FHIRHelpers_4_4_000.Instance.ToValue(context, aw_);
                                u_ = ax_ as CqlInterval<CqlQuantity?>;
                            }
                            else
                            {
                                u_ = null;
                            }
                        }
                    }
                }
                CqlInterval<CqlDateTime?>? v_ = QICoreCommon_4_0_000.Instance.toInterval(context, u_);
                CqlDateTime? w_ = context.Operators.Start(v_);
                bool? x_ = context.Operators.Before(t_, w_, (string?)default);
                Code<ObservationStatus>? y_ = GleasonScore?.StatusElement;
                ObservationStatus? z_ = y_?.Value;
                string? aa_ = context.Operators.Convert<string?>(z_);
                string?[]? ab_ = [
                    "final",
                    "amended",
                    "corrected",
                ];
                bool? ac_ = context.Operators.In<string?>(aa_, (IEnumerable<string?>?)ab_);
                bool? ad_ = context.Operators.And(x_, ac_);
                return ad_;
            }

            bool? p_ = context.Operators.WhereAny<Procedure?>((IEnumerable<Procedure?>?)n_, o_);
            return p_;
        }

        IEnumerable<Observation?>? e_ = context.Operators.Where<Observation?>(c_, d_);

        object f_(Observation? @this) {
            DataType? ay_ = @this?.Effective;
            object? az_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ay_);
            CqlInterval<CqlDateTime?>? ba_ = QICoreCommon_4_0_000.Instance.toInterval(context, az_);
            CqlDateTime? bb_ = context.Operators.Start(ba_);
            return bb_!;
        }

        IEnumerable<Observation?>? g_ = context.Operators.SortBy<Observation?>(e_, f_, System.ComponentModel.ListSortDirection.Ascending);
        Observation? h_ = context.Operators.Last<Observation?>(g_);
        Observation?[]? i_ = [
            h_,
        ];

        bool? j_(Observation? LastGleasonScore) {
            DataType? bc_ = LastGleasonScore?.Value;
            object? bd_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bc_);
            bool? be_ = context.Operators.LessOrEqual(bd_ as int?, 6);
            return be_;
        }

        IEnumerable<bool?>? k_ = context.Operators.SelectDistinct<Observation?, bool?>((IEnumerable<Observation?>?)i_, j_);
        bool? l_ = context.Operators.SingletonFrom<bool?>(k_);
        return l_;
    }


    [CqlExpressionDefinition("Denominator")]
    public bool? Denominator(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Denominator, Denominator_Compute);

    private const long _cacheIndex_Denominator = 1246872489746454659L;

    private bool? Denominator_Compute(CqlContext context)
    {
        bool? a_ = this.Initial_Population(context);
        Procedure? b_ = this.First_Prostate_Cancer_Treatment_during_day_of_Measurement_Period(context);
        bool? c_ = context.Operators.Not((bool?)(b_ is null));
        bool? d_ = context.Operators.And(a_, c_);
        Observation? e_ = this.Most_Recent_Prostate_Cancer_Staging_Tumor_Size_T1a_to_T2a(context);
        bool? f_ = context.Operators.Not((bool?)(e_ is null));
        bool? g_ = context.Operators.And(d_, f_);
        bool? h_ = this.Most_Recent_PSA_Test_Result_is_Low(context);
        bool? i_ = context.Operators.And(g_, h_);
        bool? j_ = this.Most_Recent_Gleason_Score_is_Low(context);
        bool? k_ = context.Operators.And(i_, j_);
        return k_;
    }


    [CqlExpressionDefinition("Bone Scan Study Performed")]
    public IEnumerable<Observation?>? Bone_Scan_Study_Performed(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Bone_Scan_Study_Performed, Bone_Scan_Study_Performed_Compute);

    private const long _cacheIndex_Bone_Scan_Study_Performed = 288628587474938786L;

    private IEnumerable<Observation?>? Bone_Scan_Study_Performed_Compute(CqlContext context)
    {
        CqlValueSet? a_ = this.Bone_Scan(context);
        IEnumerable<Observation?>? b_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation-clinical-result"));

        bool? c_(Observation? BoneScan) {
            IEnumerable<Condition?>? g_ = this.Prostate_Cancer_Diagnosis(context);

            bool? h_(Condition? ActiveProstateCancer) {
                DataType? j_ = BoneScan?.Effective;
                object? k_ = FHIRHelpers_4_4_000.Instance.ToValue(context, j_);
                CqlInterval<CqlDateTime?>? l_ = QICoreCommon_4_0_000.Instance.toInterval(context, k_);
                CqlDateTime? m_ = context.Operators.Start(l_);
                CqlInterval<CqlDateTime?>? n_ = QICoreCommon_4_0_000.Instance.prevalenceInterval(context, ActiveProstateCancer as Condition);
                CqlDateTime? o_ = context.Operators.Start(n_);
                bool? p_ = context.Operators.After(m_, o_, (string?)default);
                return p_;
            }

            bool? i_ = context.Operators.WhereAny<Condition?>(g_, h_);
            return i_;
        }

        IEnumerable<Observation?>? d_ = context.Operators.Where<Observation?>(b_, c_);

        bool? e_(Observation? BoneScan) {
            DataType? q_ = BoneScan?.Effective;
            object? r_ = FHIRHelpers_4_4_000.Instance.ToValue(context, q_);
            CqlInterval<CqlDateTime?>? s_ = QICoreCommon_4_0_000.Instance.toInterval(context, r_);
            CqlDateTime? t_ = context.Operators.End(s_);
            CqlInterval<CqlDateTime?>? u_ = this.Measurement_Period(context);
            bool? v_ = context.Operators.In<CqlDateTime?>(t_, u_, "day");
            Code<ObservationStatus>? w_ = BoneScan?.StatusElement;
            ObservationStatus? x_ = w_?.Value;
            string? y_ = context.Operators.Convert<string?>(x_);
            string?[]? z_ = [
                "final",
                "amended",
                "corrected",
            ];
            bool? aa_ = context.Operators.In<string?>(y_, (IEnumerable<string?>?)z_);
            bool? ab_ = context.Operators.And(v_, aa_);
            return ab_;
        }

        IEnumerable<Observation?>? f_ = context.Operators.Where<Observation?>(d_, e_);
        return f_;
    }


    [CqlExpressionDefinition("Numerator")]
    public bool? Numerator(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Numerator, Numerator_Compute);

    private const long _cacheIndex_Numerator = 7820927283973067551L;

    private bool? Numerator_Compute(CqlContext context)
    {
        IEnumerable<Observation?>? a_ = this.Bone_Scan_Study_Performed(context);
        bool? b_ = context.Operators.Exists<Observation?>(a_);
        bool? c_ = context.Operators.Not(b_);
        return c_;
    }


    [CqlExpressionDefinition("Has Diagnosis of Pain related to Prostate Cancer")]
    public bool? Has_Diagnosis_of_Pain_related_to_Prostate_Cancer(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Has_Diagnosis_of_Pain_related_to_Prostate_Cancer, Has_Diagnosis_of_Pain_related_to_Prostate_Cancer_Compute);

    private const long _cacheIndex_Has_Diagnosis_of_Pain_related_to_Prostate_Cancer = 1074005850507574754L;

    private bool? Has_Diagnosis_of_Pain_related_to_Prostate_Cancer_Compute(CqlContext context)
    {
        CqlValueSet? a_ = this.Pain_Warranting_Further_Investigation_for_Prostate_Cancer(context);
        IEnumerable<Condition?>? b_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-problems-health-concerns"));
        IEnumerable<Condition?>? c_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-encounter-diagnosis"));
        IEnumerable<Condition?>? d_ = context.Operators.Union<Condition?>(b_ as IEnumerable<Condition?>, c_ as IEnumerable<Condition?>);

        bool? e_(Condition? ProstateCancerPain) {
            IEnumerable<Condition?>? g_ = this.Prostate_Cancer_Diagnosis(context);

            bool? h_(Condition? ActiveProstateCancer) {
                CqlInterval<CqlDateTime?>? j_ = QICoreCommon_4_0_000.Instance.prevalenceInterval(context, ProstateCancerPain);
                CqlDateTime? k_ = context.Operators.Start(j_);
                CqlInterval<CqlDateTime?>? l_ = QICoreCommon_4_0_000.Instance.prevalenceInterval(context, ActiveProstateCancer as Condition);
                CqlDateTime? m_ = context.Operators.Start(l_);
                bool? n_ = context.Operators.After(k_, m_, (string?)default);
                bool? o_ = this.isVerified(context, ProstateCancerPain);
                bool? p_ = context.Operators.And(n_, o_);
                return p_;
            }

            bool? i_ = context.Operators.WhereAny<Condition?>(g_, h_);
            return i_;
        }

        bool? f_ = context.Operators.WhereAny<Condition?>(d_, e_);
        return f_;
    }


    [CqlExpressionDefinition("Has Salvage Therapy Performed after Prostate Cancer Diagnosis")]
    public bool? Has_Salvage_Therapy_Performed_after_Prostate_Cancer_Diagnosis(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Has_Salvage_Therapy_Performed_after_Prostate_Cancer_Diagnosis, Has_Salvage_Therapy_Performed_after_Prostate_Cancer_Diagnosis_Compute);

    private const long _cacheIndex_Has_Salvage_Therapy_Performed_after_Prostate_Cancer_Diagnosis = 814682402894497576L;

    private bool? Has_Salvage_Therapy_Performed_after_Prostate_Cancer_Diagnosis_Compute(CqlContext context)
    {
        CqlValueSet? a_ = this.Salvage_Therapy(context);
        IEnumerable<Procedure?>? b_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));

        bool? c_(Procedure? SalvageTherapy) {
            IEnumerable<Condition?>? e_ = this.Prostate_Cancer_Diagnosis(context);

            bool? f_(Condition? ActiveProstateCancer) {
                object? h_;
                DataType? s_ = SalvageTherapy?.Performed;
                object? t_ = FHIRHelpers_4_4_000.Instance.ToValue(context, s_);
                bool u_ = t_ is CqlDateTime;
                if (u_)
                {
                    DataType? v_ = SalvageTherapy?.Performed;
                    object? w_ = FHIRHelpers_4_4_000.Instance.ToValue(context, v_);
                    h_ = w_ as CqlDateTime;
                }
                else
                {
                    DataType? x_ = SalvageTherapy?.Performed;
                    object? y_ = FHIRHelpers_4_4_000.Instance.ToValue(context, x_);
                    bool z_ = y_ is CqlQuantity;
                    if (z_)
                    {
                        DataType? aa_ = SalvageTherapy?.Performed;
                        object? ab_ = FHIRHelpers_4_4_000.Instance.ToValue(context, aa_);
                        h_ = ab_ as CqlQuantity;
                    }
                    else
                    {
                        DataType? ac_ = SalvageTherapy?.Performed;
                        object? ad_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ac_);
                        bool ae_ = ad_ is CqlInterval<CqlDateTime>;
                        if (ae_)
                        {
                            DataType? af_ = SalvageTherapy?.Performed;
                            object? ag_ = FHIRHelpers_4_4_000.Instance.ToValue(context, af_);
                            h_ = ag_ as CqlInterval<CqlDateTime?>;
                        }
                        else
                        {
                            DataType? ah_ = SalvageTherapy?.Performed;
                            object? ai_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ah_);
                            bool aj_ = ai_ is CqlInterval<CqlQuantity>;
                            if (aj_)
                            {
                                DataType? ak_ = SalvageTherapy?.Performed;
                                object? al_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ak_);
                                h_ = al_ as CqlInterval<CqlQuantity?>;
                            }
                            else
                            {
                                h_ = null;
                            }
                        }
                    }
                }
                CqlInterval<CqlDateTime?>? i_ = QICoreCommon_4_0_000.Instance.toInterval(context, h_);
                CqlDateTime? j_ = context.Operators.Start(i_);
                CqlInterval<CqlDateTime?>? k_ = QICoreCommon_4_0_000.Instance.prevalenceInterval(context, ActiveProstateCancer as Condition);
                CqlDateTime? l_ = context.Operators.Start(k_);
                bool? m_ = context.Operators.After(j_, l_, (string?)default);
                Code<EventStatus>? n_ = SalvageTherapy?.StatusElement;
                EventStatus? o_ = n_?.Value;
                string? p_ = context.Operators.Convert<string?>(o_);
                bool? q_ = context.Operators.Equal(p_, "completed");
                bool? r_ = context.Operators.And(m_, q_);
                return r_;
            }

            bool? g_ = context.Operators.WhereAny<Condition?>(e_, f_);
            return g_;
        }

        bool? d_ = context.Operators.WhereAny<Procedure?>(b_, c_);
        return d_;
    }


    [CqlExpressionDefinition("Has Bone Scan Study Performed with Documented Reason")]
    public bool? Has_Bone_Scan_Study_Performed_with_Documented_Reason(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Has_Bone_Scan_Study_Performed_with_Documented_Reason, Has_Bone_Scan_Study_Performed_with_Documented_Reason_Compute);

    private const long _cacheIndex_Has_Bone_Scan_Study_Performed_with_Documented_Reason = -57594536143353413L;

    private bool? Has_Bone_Scan_Study_Performed_with_Documented_Reason_Compute(CqlContext context)
    {
        IEnumerable<Observation?>? a_ = this.Bone_Scan_Study_Performed(context);

        bool? b_(Observation? BoneScanAfterDiagnosis) {
            DataType? d_ = BoneScanAfterDiagnosis?.Value;
            object? e_ = FHIRHelpers_4_4_000.Instance.ToValue(context, d_);
            CqlCode? f_ = this.Procedure_reason_record__record_artifact_(context);
            CqlConcept? g_ = context.Operators.ConvertCodeToConcept(f_);
            bool? h_ = context.Operators.Equivalent(e_ as CqlConcept, g_);
            return h_;
        }

        bool? c_ = context.Operators.WhereAny<Observation?>(a_, b_);
        return c_;
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

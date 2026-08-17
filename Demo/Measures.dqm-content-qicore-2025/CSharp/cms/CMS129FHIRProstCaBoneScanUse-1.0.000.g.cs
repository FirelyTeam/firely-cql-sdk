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

[System.CodeDom.Compiler.GeneratedCode(".NET Code Generation", "5.3.2.0")]
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

        CqlBoolean c_() {
            CodeableConcept d_ = condition?.VerificationStatus;
            CqlConcept e_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, d_);
            CqlCode f_ = QICoreCommon_4_0_000.Instance.confirmed(context);
            CqlConcept g_ = context.Operators.ConvertCodeToConcept(f_);
            bool? h_ = context.Operators.Equivalent(e_, g_);

            CqlBoolean i_() {
                CodeableConcept l_ = condition?.VerificationStatus;
                CqlConcept m_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, l_);
                CqlCode n_ = QICoreCommon_4_0_000.Instance.unconfirmed(context);
                CqlConcept o_ = context.Operators.ConvertCodeToConcept(n_);
                bool? p_ = context.Operators.Equivalent(m_, o_);
                return p_;
            }


            CqlBoolean j_() {
                CodeableConcept q_ = condition?.VerificationStatus;
                CqlConcept r_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, q_);
                CqlCode s_ = QICoreCommon_4_0_000.Instance.provisional(context);
                CqlConcept t_ = context.Operators.ConvertCodeToConcept(s_);
                bool? u_ = context.Operators.Equivalent(r_, t_);
                return u_;
            }


            CqlBoolean k_() {
                CodeableConcept v_ = condition?.VerificationStatus;
                CqlConcept w_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, v_);
                CqlCode x_ = QICoreCommon_4_0_000.Instance.differential(context);
                CqlConcept y_ = context.Operators.ConvertCodeToConcept(x_);
                bool? z_ = context.Operators.Equivalent(w_, y_);
                return z_;
            }

            return /* CQL 'or' (143:52-147:3) */ (/* CQL 'or' (143:54-145:66) */ (/* CQL 'or' (143:54-144:66) */ ((CqlBoolean)h_
                || i_())
                || j_())
                || k_());
        }

        return /* CQL 'implies' (143:3-147:3) */ ((CqlBoolean)(!(!((bool?)(b_ is null))))
            || c_());
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
            return /* CQL 'and' (133:5-134:39) */ ((CqlBoolean)g_
                && this.isVerified(context, ProstateCancer as Condition));
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
            DataType n_ = ProstateCancerTreatment?.Performed;
            object o_ = FHIRHelpers_4_4_000.Instance.ToValue(context, n_);
            bool p_ = o_ is CqlDateTime;
            if (p_)
            {
                h_ = o_ as CqlDateTime;
            }
            else
            {
                bool q_ = o_ is CqlQuantity;
                if (q_)
                {
                    h_ = o_ as CqlQuantity;
                }
                else
                {
                    bool r_ = o_ is CqlInterval<CqlDateTime>;
                    if (r_)
                    {
                        h_ = o_ as CqlInterval<CqlDateTime>;
                    }
                    else
                    {
                        bool s_ = o_ is CqlInterval<CqlQuantity>;
                        if (s_)
                        {
                            h_ = o_ as CqlInterval<CqlQuantity>;
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

            CqlBoolean m_() {
                Code<EventStatus> t_ = ProstateCancerTreatment?.StatusElement;
                EventStatus? u_ = t_?.Value;
                string v_ = context.Operators.Convert<string>(u_);
                bool? w_ = context.Operators.Equal(v_, "completed");
                return w_;
            }

            return /* CQL 'and' (84:7-85:56) */ ((CqlBoolean)l_
                && m_());
        }

        IEnumerable<Procedure> d_ = context.Operators.Where<Procedure>(b_, c_);

        object e_(Procedure @this) {
            object x_;
            DataType aa_ = @this?.Performed;
            object ab_ = FHIRHelpers_4_4_000.Instance.ToValue(context, aa_);
            bool ac_ = ab_ is CqlDateTime;
            if (ac_)
            {
                x_ = ab_ as CqlDateTime;
            }
            else
            {
                bool ad_ = ab_ is CqlQuantity;
                if (ad_)
                {
                    x_ = ab_ as CqlQuantity;
                }
                else
                {
                    bool ae_ = ab_ is CqlInterval<CqlDateTime>;
                    if (ae_)
                    {
                        x_ = ab_ as CqlInterval<CqlDateTime>;
                    }
                    else
                    {
                        bool af_ = ab_ is CqlInterval<CqlQuantity>;
                        if (af_)
                        {
                            x_ = ab_ as CqlInterval<CqlQuantity>;
                        }
                        else
                        {
                            x_ = null;
                        }
                    }
                }
            }
            CqlInterval<CqlDateTime> y_ = QICoreCommon_4_0_000.Instance.toInterval(context, x_);
            CqlDateTime z_ = context.Operators.Start(y_);
            return z_;
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
                DataType q_ = ProstateCancerStaging?.Effective;
                object r_ = FHIRHelpers_4_4_000.Instance.ToValue(context, q_);
                CqlInterval<CqlDateTime> s_ = QICoreCommon_4_0_000.Instance.toInterval(context, r_);
                CqlDateTime t_ = context.Operators.Start(s_);
                object u_;
                DataType z_ = FirstProstateCancerTreatment?.Performed;
                object aa_ = FHIRHelpers_4_4_000.Instance.ToValue(context, z_);
                bool ab_ = aa_ is CqlDateTime;
                if (ab_)
                {
                    u_ = aa_ as CqlDateTime;
                }
                else
                {
                    bool ac_ = aa_ is CqlQuantity;
                    if (ac_)
                    {
                        u_ = aa_ as CqlQuantity;
                    }
                    else
                    {
                        bool ad_ = aa_ is CqlInterval<CqlDateTime>;
                        if (ad_)
                        {
                            u_ = aa_ as CqlInterval<CqlDateTime>;
                        }
                        else
                        {
                            bool ae_ = aa_ is CqlInterval<CqlQuantity>;
                            if (ae_)
                            {
                                u_ = aa_ as CqlInterval<CqlQuantity>;
                            }
                            else
                            {
                                u_ = null;
                            }
                        }
                    }
                }
                CqlInterval<CqlDateTime> v_ = QICoreCommon_4_0_000.Instance.toInterval(context, u_);
                CqlDateTime w_ = context.Operators.Start(v_);
                bool? x_ = context.Operators.Before(t_, w_, (string)default);

                CqlBoolean y_() {
                    Code<ObservationStatus> af_ = ProstateCancerStaging?.StatusElement;
                    ObservationStatus? ag_ = af_?.Value;
                    string ah_ = context.Operators.Convert<string>(ag_);
                    string[] ai_ = [
                        "final",
                        "amended",
                        "corrected",
                    ];
                    bool? aj_ = context.Operators.In<string>(ah_, (IEnumerable<string>)ai_);
                    return aj_;
                }

                return /* CQL 'and' (121:19-122:81) */ ((CqlBoolean)x_
                    && y_());
            }

            bool? p_ = context.Operators.WhereAny<Procedure>((IEnumerable<Procedure>)n_, o_);
            return p_;
        }

        IEnumerable<Observation> e_ = context.Operators.Where<Observation>(c_, d_);

        object f_(Observation @this) {
            DataType ak_ = @this?.Effective;
            object al_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ak_);
            CqlInterval<CqlDateTime> am_ = QICoreCommon_4_0_000.Instance.toInterval(context, al_);
            CqlDateTime an_ = context.Operators.Start(am_);
            return an_;
        }

        IEnumerable<Observation> g_ = context.Operators.SortBy<Observation>(e_, f_, System.ComponentModel.ListSortDirection.Ascending);
        Observation h_ = context.Operators.Last<Observation>(g_);
        Observation[] i_ = [
            h_,
        ];

        bool? j_(Observation LastProstateCancerStaging) {
            DataType ao_ = LastProstateCancerStaging?.Value;
            object ap_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ao_);
            CqlCode aq_ = this.American_Joint_Committee_on_Cancer_cT1a__qualifier_value_(context);
            CqlConcept ar_ = context.Operators.ConvertCodeToConcept(aq_);
            bool? as_ = context.Operators.Equivalent(ap_ as CqlConcept, ar_);

            CqlBoolean at_() {
                DataType aw_ = LastProstateCancerStaging?.Value;
                object ax_ = FHIRHelpers_4_4_000.Instance.ToValue(context, aw_);
                CqlCode ay_ = this.American_Joint_Committee_on_Cancer_cT1b__qualifier_value_(context);
                CqlConcept az_ = context.Operators.ConvertCodeToConcept(ay_);
                bool? ba_ = context.Operators.Equivalent(ax_ as CqlConcept, az_);
                return ba_;
            }


            CqlBoolean au_() {
                DataType bb_ = LastProstateCancerStaging?.Value;
                object bc_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bb_);
                CqlCode bd_ = this.American_Joint_Committee_on_Cancer_cT1c__qualifier_value_(context);
                CqlConcept be_ = context.Operators.ConvertCodeToConcept(bd_);
                bool? bf_ = context.Operators.Equivalent(bc_ as CqlConcept, be_);
                return bf_;
            }


            CqlBoolean av_() {
                DataType bg_ = LastProstateCancerStaging?.Value;
                object bh_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bg_);
                CqlCode bi_ = this.American_Joint_Committee_on_Cancer_cT2a__qualifier_value_(context);
                CqlConcept bj_ = context.Operators.ConvertCodeToConcept(bi_);
                bool? bk_ = context.Operators.Equivalent(bh_ as CqlConcept, bj_);
                return bk_;
            }

            return /* CQL 'or' (125:5-129:5) */ (/* CQL 'or' (125:13-127:104) */ (/* CQL 'or' (125:13-126:104) */ ((CqlBoolean)as_
                || at_())
                || au_())
                || av_());
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
            Observation l_ = this.Most_Recent_Prostate_Cancer_Staging_Tumor_Size_T1a_to_T2a(context);
            Observation[] m_ = [
                l_,
            ];

            bool? n_(Observation MostRecentProstateCancerStaging) {
                CqlInterval<CqlDateTime> p_;
                DataType v_ = PSATest?.Effective;
                object w_ = FHIRHelpers_4_4_000.Instance.ToValue(context, v_);
                CqlInterval<CqlDateTime> x_ = QICoreCommon_4_0_000.Instance.toInterval(context, w_);
                CqlDateTime y_ = context.Operators.Start(x_);
                if (y_ is null)
                {
                    p_ = default;
                }
                else
                {
                    CqlInterval<CqlDateTime> z_ = context.Operators.Interval(y_, y_, true, true);
                    p_ = z_;
                }
                DataType q_ = MostRecentProstateCancerStaging?.Effective;
                object r_ = FHIRHelpers_4_4_000.Instance.ToValue(context, q_);
                CqlInterval<CqlDateTime> s_ = QICoreCommon_4_0_000.Instance.toInterval(context, r_);
                bool? t_ = context.Operators.Before(p_, s_, (string)default);

                CqlBoolean u_() {
                    Code<ObservationStatus> aa_ = PSATest?.StatusElement;
                    ObservationStatus? ab_ = aa_?.Value;
                    string ac_ = context.Operators.Convert<string>(ab_);
                    string[] ad_ = [
                        "final",
                        "amended",
                        "corrected",
                    ];
                    bool? ae_ = context.Operators.In<string>(ac_, (IEnumerable<string>)ad_);
                    return ae_;
                }

                return /* CQL 'and' (92:19-93:67) */ ((CqlBoolean)t_
                    && u_());
            }

            bool? o_ = context.Operators.WhereAny<Observation>((IEnumerable<Observation>)m_, n_);
            return o_;
        }

        IEnumerable<Observation> d_ = context.Operators.Where<Observation>(b_, c_);

        object e_(Observation @this) {
            DataType af_ = @this?.Effective;
            object ag_ = FHIRHelpers_4_4_000.Instance.ToValue(context, af_);
            CqlInterval<CqlDateTime> ah_ = QICoreCommon_4_0_000.Instance.toInterval(context, ag_);
            CqlDateTime ai_ = context.Operators.Start(ah_);
            return ai_;
        }

        IEnumerable<Observation> f_ = context.Operators.SortBy<Observation>(d_, e_, System.ComponentModel.ListSortDirection.Ascending);
        Observation g_ = context.Operators.Last<Observation>(f_);
        Observation[] h_ = [
            g_,
        ];

        bool? i_(Observation LastPSATest) {
            DataType aj_ = LastPSATest?.Value;
            object ak_ = FHIRHelpers_4_4_000.Instance.ToValue(context, aj_);
            CqlQuantity al_ = context.Operators.Quantity(10m, "ng/mL");
            bool? am_ = context.Operators.Less(ak_ as CqlQuantity, al_);
            return am_;
        }

        IEnumerable<bool?> j_ = context.Operators.SelectDistinct<Observation, bool?>((IEnumerable<Observation>)h_, i_);
        bool? k_ = context.Operators.SingletonFrom<bool?>(j_);
        return k_;
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
            Procedure m_ = this.First_Prostate_Cancer_Treatment_during_day_of_Measurement_Period(context);
            Procedure[] n_ = [
                m_,
            ];

            bool? o_(Procedure FirstProstateCancerTreatment) {
                DataType q_ = GleasonScore?.Effective;
                object r_ = FHIRHelpers_4_4_000.Instance.ToValue(context, q_);
                CqlInterval<CqlDateTime> s_ = QICoreCommon_4_0_000.Instance.toInterval(context, r_);
                CqlDateTime t_ = context.Operators.Start(s_);
                object u_;
                DataType z_ = FirstProstateCancerTreatment?.Performed;
                object aa_ = FHIRHelpers_4_4_000.Instance.ToValue(context, z_);
                bool ab_ = aa_ is CqlDateTime;
                if (ab_)
                {
                    u_ = aa_ as CqlDateTime;
                }
                else
                {
                    bool ac_ = aa_ is CqlQuantity;
                    if (ac_)
                    {
                        u_ = aa_ as CqlQuantity;
                    }
                    else
                    {
                        bool ad_ = aa_ is CqlInterval<CqlDateTime>;
                        if (ad_)
                        {
                            u_ = aa_ as CqlInterval<CqlDateTime>;
                        }
                        else
                        {
                            bool ae_ = aa_ is CqlInterval<CqlQuantity>;
                            if (ae_)
                            {
                                u_ = aa_ as CqlInterval<CqlQuantity>;
                            }
                            else
                            {
                                u_ = null;
                            }
                        }
                    }
                }
                CqlInterval<CqlDateTime> v_ = QICoreCommon_4_0_000.Instance.toInterval(context, u_);
                CqlDateTime w_ = context.Operators.Start(v_);
                bool? x_ = context.Operators.Before(t_, w_, (string)default);

                CqlBoolean y_() {
                    Code<ObservationStatus> af_ = GleasonScore?.StatusElement;
                    ObservationStatus? ag_ = af_?.Value;
                    string ah_ = context.Operators.Convert<string>(ag_);
                    string[] ai_ = [
                        "final",
                        "amended",
                        "corrected",
                    ];
                    bool? aj_ = context.Operators.In<string>(ah_, (IEnumerable<string>)ai_);
                    return aj_;
                }

                return /* CQL 'and' (108:19-109:72) */ ((CqlBoolean)x_
                    && y_());
            }

            bool? p_ = context.Operators.WhereAny<Procedure>((IEnumerable<Procedure>)n_, o_);
            return p_;
        }

        IEnumerable<Observation> e_ = context.Operators.Where<Observation>(c_, d_);

        object f_(Observation @this) {
            DataType ak_ = @this?.Effective;
            object al_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ak_);
            CqlInterval<CqlDateTime> am_ = QICoreCommon_4_0_000.Instance.toInterval(context, al_);
            CqlDateTime an_ = context.Operators.Start(am_);
            return an_;
        }

        IEnumerable<Observation> g_ = context.Operators.SortBy<Observation>(e_, f_, System.ComponentModel.ListSortDirection.Ascending);
        Observation h_ = context.Operators.Last<Observation>(g_);
        Observation[] i_ = [
            h_,
        ];

        bool? j_(Observation LastGleasonScore) {
            DataType ao_ = LastGleasonScore?.Value;
            object ap_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ao_);
            bool? aq_ = context.Operators.LessOrEqual(ap_ as int?, 6);
            return aq_;
        }

        IEnumerable<bool?> k_ = context.Operators.SelectDistinct<Observation, bool?>((IEnumerable<Observation>)i_, j_);
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
        return /* CQL 'and' (49:3-53:42) */ (/* CQL 'and' (49:3-52:44) */ (/* CQL 'and' (49:3-51:79) */ (/* CQL 'and' (49:3-50:86) */ ((CqlBoolean)a_
            && !((bool?)((this.First_Prostate_Cancer_Treatment_during_day_of_Measurement_Period(context)) is null)))
            && !((bool?)((this.Most_Recent_Prostate_Cancer_Staging_Tumor_Size_T1a_to_T2a(context)) is null)))
            && this.Most_Recent_PSA_Test_Result_is_Low(context))
            && this.Most_Recent_Gleason_Score_is_Low(context));
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
                DataType j_ = BoneScan?.Effective;
                object k_ = FHIRHelpers_4_4_000.Instance.ToValue(context, j_);
                CqlInterval<CqlDateTime> l_ = QICoreCommon_4_0_000.Instance.toInterval(context, k_);
                CqlDateTime m_ = context.Operators.Start(l_);
                CqlInterval<CqlDateTime> n_ = QICoreCommon_4_0_000.Instance.prevalenceInterval(context, ActiveProstateCancer as Condition);
                CqlDateTime o_ = context.Operators.Start(n_);
                bool? p_ = context.Operators.After(m_, o_, (string)default);
                return p_;
            }

            bool? i_ = context.Operators.WhereAny<Condition>(g_, h_);
            return i_;
        }

        IEnumerable<Observation> d_ = context.Operators.Where<Observation>(b_, c_);

        bool? e_(Observation BoneScan) {
            DataType q_ = BoneScan?.Effective;
            object r_ = FHIRHelpers_4_4_000.Instance.ToValue(context, q_);
            CqlInterval<CqlDateTime> s_ = QICoreCommon_4_0_000.Instance.toInterval(context, r_);
            CqlDateTime t_ = context.Operators.End(s_);
            CqlInterval<CqlDateTime> u_ = this.Measurement_Period(context);
            bool? v_ = context.Operators.In<CqlDateTime>(t_, u_, "day");

            CqlBoolean w_() {
                Code<ObservationStatus> x_ = BoneScan?.StatusElement;
                ObservationStatus? y_ = x_?.Value;
                string z_ = context.Operators.Convert<string>(y_);
                string[] aa_ = [
                    "final",
                    "amended",
                    "corrected",
                ];
                bool? ab_ = context.Operators.In<string>(z_, (IEnumerable<string>)aa_);
                return ab_;
            }

            return /* CQL 'and' (67:5-68:64) */ ((CqlBoolean)v_
                && w_());
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
        return !b_;
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
            IEnumerable<Condition> g_ = this.Prostate_Cancer_Diagnosis(context);

            bool? h_(Condition ActiveProstateCancer) {
                CqlInterval<CqlDateTime> j_ = QICoreCommon_4_0_000.Instance.prevalenceInterval(context, ProstateCancerPain);
                CqlDateTime k_ = context.Operators.Start(j_);
                CqlInterval<CqlDateTime> l_ = QICoreCommon_4_0_000.Instance.prevalenceInterval(context, ActiveProstateCancer as Condition);
                CqlDateTime m_ = context.Operators.Start(l_);
                bool? n_ = context.Operators.After(k_, m_, (string)default);
                return /* CQL 'and' (78:19-79:47) */ ((CqlBoolean)n_
                    && this.isVerified(context, ProstateCancerPain));
            }

            bool? i_ = context.Operators.WhereAny<Condition>(g_, h_);
            return i_;
        }

        bool? f_ = context.Operators.WhereAny<Condition>(d_, e_);
        return f_;
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
            IEnumerable<Condition> e_ = this.Prostate_Cancer_Diagnosis(context);

            bool? f_(Condition ActiveProstateCancer) {
                object h_;
                DataType o_ = SalvageTherapy?.Performed;
                object p_ = FHIRHelpers_4_4_000.Instance.ToValue(context, o_);
                bool q_ = p_ is CqlDateTime;
                if (q_)
                {
                    h_ = p_ as CqlDateTime;
                }
                else
                {
                    bool r_ = p_ is CqlQuantity;
                    if (r_)
                    {
                        h_ = p_ as CqlQuantity;
                    }
                    else
                    {
                        bool s_ = p_ is CqlInterval<CqlDateTime>;
                        if (s_)
                        {
                            h_ = p_ as CqlInterval<CqlDateTime>;
                        }
                        else
                        {
                            bool t_ = p_ is CqlInterval<CqlQuantity>;
                            if (t_)
                            {
                                h_ = p_ as CqlInterval<CqlQuantity>;
                            }
                            else
                            {
                                h_ = null;
                            }
                        }
                    }
                }
                CqlInterval<CqlDateTime> i_ = QICoreCommon_4_0_000.Instance.toInterval(context, h_);
                CqlDateTime j_ = context.Operators.Start(i_);
                CqlInterval<CqlDateTime> k_ = QICoreCommon_4_0_000.Instance.prevalenceInterval(context, ActiveProstateCancer as Condition);
                CqlDateTime l_ = context.Operators.Start(k_);
                bool? m_ = context.Operators.After(j_, l_, (string)default);

                CqlBoolean n_() {
                    Code<EventStatus> u_ = SalvageTherapy?.StatusElement;
                    EventStatus? v_ = u_?.Value;
                    string w_ = context.Operators.Convert<string>(v_);
                    bool? x_ = context.Operators.Equal(w_, "completed");
                    return x_;
                }

                return /* CQL 'and' (101:19-102:49) */ ((CqlBoolean)m_
                    && n_());
            }

            bool? g_ = context.Operators.WhereAny<Condition>(e_, f_);
            return g_;
        }

        bool? d_ = context.Operators.WhereAny<Procedure>(b_, c_);
        return d_;
    }


    [CqlExpressionDefinition("Has Bone Scan Study Performed with Documented Reason")]
    public bool? Has_Bone_Scan_Study_Performed_with_Documented_Reason(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Has_Bone_Scan_Study_Performed_with_Documented_Reason, Has_Bone_Scan_Study_Performed_with_Documented_Reason_Compute);

    private const long _cacheIndex_Has_Bone_Scan_Study_Performed_with_Documented_Reason = -57594536143353413L;

    private bool? Has_Bone_Scan_Study_Performed_with_Documented_Reason_Compute(CqlContext context)
    {
        IEnumerable<Observation> a_ = this.Bone_Scan_Study_Performed(context);

        bool? b_(Observation BoneScanAfterDiagnosis) {
            DataType d_ = BoneScanAfterDiagnosis?.Value;
            object e_ = FHIRHelpers_4_4_000.Instance.ToValue(context, d_);
            CqlCode f_ = this.Procedure_reason_record__record_artifact_(context);
            CqlConcept g_ = context.Operators.ConvertCodeToConcept(f_);
            bool? h_ = context.Operators.Equivalent(e_ as CqlConcept, g_);
            return h_;
        }

        bool? c_ = context.Operators.WhereAny<Observation>(a_, b_);
        return c_;
    }


    [CqlExpressionDefinition("Denominator Exceptions")]
    public bool? Denominator_Exceptions(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Denominator_Exceptions, Denominator_Exceptions_Compute);

    private const long _cacheIndex_Denominator_Exceptions = -2111890706368566952L;

    private bool? Denominator_Exceptions_Compute(CqlContext context)
    {
        bool? a_ = this.Has_Diagnosis_of_Pain_related_to_Prostate_Cancer(context);
        return /* CQL 'or' (59:3-61:61) */ (/* CQL 'or' (59:3-60:70) */ ((CqlBoolean)a_
            || this.Has_Salvage_Therapy_Performed_after_Prostate_Cancer_Diagnosis(context))
            || this.Has_Bone_Scan_Study_Performed_with_Documented_Reason(context));
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

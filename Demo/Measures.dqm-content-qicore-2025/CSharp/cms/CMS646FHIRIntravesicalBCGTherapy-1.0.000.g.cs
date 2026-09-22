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

[System.CodeDom.Compiler.GeneratedCode(".NET Code Generation", "5.2.4.0")]
[CqlLibrary("CMS646FHIRIntravesicalBCGTherapy", "1.0.000")]
public partial class CMS646FHIRIntravesicalBCGTherapy_1_0_000 : ILibrary, ISingleton<CMS646FHIRIntravesicalBCGTherapy_1_0_000>
{
    #region ValueSets (11)

    [CqlValueSetDefinition("Bacillus Calmette Guerin for Urology Care", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1248.353", valueSetVersion: null)]
    public CqlValueSet Bacillus_Calmette_Guerin_for_Urology_Care(CqlContext _) => _Bacillus_Calmette_Guerin_for_Urology_Care;
    private static readonly CqlValueSet _Bacillus_Calmette_Guerin_for_Urology_Care = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1248.353", null);

    [CqlValueSetDefinition("Bladder Cancer for Urology Care", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1248.354", valueSetVersion: null)]
    public CqlValueSet Bladder_Cancer_for_Urology_Care(CqlContext _) => _Bladder_Cancer_for_Urology_Care;
    private static readonly CqlValueSet _Bladder_Cancer_for_Urology_Care = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1248.354", null);

    [CqlValueSetDefinition("Chemotherapy Agents for Advanced Cancer", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1248.355", valueSetVersion: null)]
    public CqlValueSet Chemotherapy_Agents_for_Advanced_Cancer(CqlContext _) => _Chemotherapy_Agents_for_Advanced_Cancer;
    private static readonly CqlValueSet _Chemotherapy_Agents_for_Advanced_Cancer = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1248.355", null);

    [CqlValueSetDefinition("Cystectomy for Urology Care", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1248.358", valueSetVersion: null)]
    public CqlValueSet Cystectomy_for_Urology_Care(CqlContext _) => _Cystectomy_for_Urology_Care;
    private static readonly CqlValueSet _Cystectomy_for_Urology_Care = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1248.358", null);

    [CqlValueSetDefinition("HIV", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.120.12.1003", valueSetVersion: null)]
    public CqlValueSet HIV(CqlContext _) => _HIV;
    private static readonly CqlValueSet _HIV = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.120.12.1003", null);

    [CqlValueSetDefinition("Immunocompromised Conditions", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1248.363", valueSetVersion: null)]
    public CqlValueSet Immunocompromised_Conditions(CqlContext _) => _Immunocompromised_Conditions;
    private static readonly CqlValueSet _Immunocompromised_Conditions = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1248.363", null);

    [CqlValueSetDefinition("Immunosuppressive Drugs for Urology Care", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1248.364", valueSetVersion: null)]
    public CqlValueSet Immunosuppressive_Drugs_for_Urology_Care(CqlContext _) => _Immunosuppressive_Drugs_for_Urology_Care;
    private static readonly CqlValueSet _Immunosuppressive_Drugs_for_Urology_Care = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1248.364", null);

    [CqlValueSetDefinition("Mixed Histology Urothelial Cell Carcinoma for Urology Care", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1248.365", valueSetVersion: null)]
    public CqlValueSet Mixed_Histology_Urothelial_Cell_Carcinoma_for_Urology_Care(CqlContext _) => _Mixed_Histology_Urothelial_Cell_Carcinoma_for_Urology_Care;
    private static readonly CqlValueSet _Mixed_Histology_Urothelial_Cell_Carcinoma_for_Urology_Care = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1248.365", null);

    [CqlValueSetDefinition("Office Visit", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1001", valueSetVersion: null)]
    public CqlValueSet Office_Visit(CqlContext _) => _Office_Visit;
    private static readonly CqlValueSet _Office_Visit = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1001", null);

    [CqlValueSetDefinition("Tuberculosis for Urology Care", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1248.351", valueSetVersion: null)]
    public CqlValueSet Tuberculosis_for_Urology_Care(CqlContext _) => _Tuberculosis_for_Urology_Care;
    private static readonly CqlValueSet _Tuberculosis_for_Urology_Care = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1248.351", null);

    [CqlValueSetDefinition("Unavailability of Bacillus Calmette Guerin for Urology Care", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1248.369", valueSetVersion: null)]
    public CqlValueSet Unavailability_of_Bacillus_Calmette_Guerin_for_Urology_Care(CqlContext _) => _Unavailability_of_Bacillus_Calmette_Guerin_for_Urology_Care;
    private static readonly CqlValueSet _Unavailability_of_Bacillus_Calmette_Guerin_for_Urology_Care = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1248.369", null);

    #endregion ValueSets

    #region Codes (7)

    [CqlCodeDefinition("American Joint Committee on Cancer cT1 (qualifier value)", codeId: "1228889001", codeSystem: "http://snomed.info/sct")]
    public CqlCode American_Joint_Committee_on_Cancer_cT1__qualifier_value_(CqlContext _) => _American_Joint_Committee_on_Cancer_cT1__qualifier_value_;
    private static readonly CqlCode _American_Joint_Committee_on_Cancer_cT1__qualifier_value_ = new CqlCode("1228889001", "http://snomed.info/sct");

    [CqlCodeDefinition("American Joint Committee on Cancer cTa (qualifier value)", codeId: "1228883000", codeSystem: "http://snomed.info/sct")]
    public CqlCode American_Joint_Committee_on_Cancer_cTa__qualifier_value_(CqlContext _) => _American_Joint_Committee_on_Cancer_cTa__qualifier_value_;
    private static readonly CqlCode _American_Joint_Committee_on_Cancer_cTa__qualifier_value_ = new CqlCode("1228883000", "http://snomed.info/sct");

    [CqlCodeDefinition("American Joint Committee on Cancer cTis (qualifier value)", codeId: "1228884006", codeSystem: "http://snomed.info/sct")]
    public CqlCode American_Joint_Committee_on_Cancer_cTis__qualifier_value_(CqlContext _) => _American_Joint_Committee_on_Cancer_cTis__qualifier_value_;
    private static readonly CqlCode _American_Joint_Committee_on_Cancer_cTis__qualifier_value_ = new CqlCode("1228884006", "http://snomed.info/sct");

    [CqlCodeDefinition("Carcinoma in situ of bladder", codeId: "D09.0", codeSystem: "http://hl7.org/fhir/sid/icd-10-cm")]
    public CqlCode Carcinoma_in_situ_of_bladder(CqlContext _) => _Carcinoma_in_situ_of_bladder;
    private static readonly CqlCode _Carcinoma_in_situ_of_bladder = new CqlCode("D09.0", "http://hl7.org/fhir/sid/icd-10-cm");

    [CqlCodeDefinition("Combined radiotherapy (procedure)", codeId: "169331000", codeSystem: "http://snomed.info/sct")]
    public CqlCode Combined_radiotherapy__procedure_(CqlContext _) => _Combined_radiotherapy__procedure_;
    private static readonly CqlCode _Combined_radiotherapy__procedure_ = new CqlCode("169331000", "http://snomed.info/sct");

    [CqlCodeDefinition("Tumor staging (tumor staging)", codeId: "254292007", codeSystem: "http://snomed.info/sct")]
    public CqlCode Tumor_staging__tumor_staging_(CqlContext _) => _Tumor_staging__tumor_staging_;
    private static readonly CqlCode _Tumor_staging__tumor_staging_ = new CqlCode("254292007", "http://snomed.info/sct");

    [CqlCodeDefinition("virtual", codeId: "VR", codeSystem: "http://terminology.hl7.org/CodeSystem/v3-ActCode")]
    public CqlCode @virtual(CqlContext _) => _virtual;
    private static readonly CqlCode _virtual = new CqlCode("VR", "http://terminology.hl7.org/CodeSystem/v3-ActCode");

    #endregion Codes

    #region CodeSystems (3)

    [CqlCodeSystemDefinition("SNOMEDCT", codeSystemId: "http://snomed.info/sct", codeSystemVersion: null)]
    public CqlCodeSystem SNOMEDCT(CqlContext _) => _SNOMEDCT;
    private static readonly CqlCodeSystem _SNOMEDCT =
      new CqlCodeSystem("http://snomed.info/sct", null, [
          _American_Joint_Committee_on_Cancer_cT1__qualifier_value_,
          _American_Joint_Committee_on_Cancer_cTa__qualifier_value_,
          _American_Joint_Committee_on_Cancer_cTis__qualifier_value_,
          _Combined_radiotherapy__procedure_,
          _Tumor_staging__tumor_staging_]);

    [CqlCodeSystemDefinition("ICD10CM", codeSystemId: "http://hl7.org/fhir/sid/icd-10-cm", codeSystemVersion: null)]
    public CqlCodeSystem ICD10CM(CqlContext _) => _ICD10CM;
    private static readonly CqlCodeSystem _ICD10CM =
      new CqlCodeSystem("http://hl7.org/fhir/sid/icd-10-cm", null, [
          _Carcinoma_in_situ_of_bladder]);

    [CqlCodeSystemDefinition("ActCode", codeSystemId: "http://terminology.hl7.org/CodeSystem/v3-ActCode", codeSystemVersion: null)]
    public CqlCodeSystem ActCode(CqlContext _) => _ActCode;
    private static readonly CqlCodeSystem _ActCode =
      new CqlCodeSystem("http://terminology.hl7.org/CodeSystem/v3-ActCode", null, [
          _virtual]);

    #endregion CodeSystems

    #region Parameters (1)

    [CqlParameterDefinition("Measurement Period")]
    public CqlInterval<CqlDateTime> Measurement_Period(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Measurement_Period, Measurement_Period_Compute);

    private const long _cacheIndex_Measurement_Period = -8463204836362917612L;

    private CqlInterval<CqlDateTime> Measurement_Period_Compute(CqlContext context)
    {
        CqlDateTime a_ = context.Operators.DateTime(2026, 1, 1, 0, 0, 0, 0, 0.0m);
        CqlDateTime b_ = context.Operators.DateTime(2027, 1, 1, 0, 0, 0, 0, 0.0m);
        CqlInterval<CqlDateTime> c_ = context.Operators.Interval(a_, b_, true, false);
        object d_ = context.ResolveParameter("CMS646FHIRIntravesicalBCGTherapy-1.0.000", "Measurement Period", c_);
        return (CqlInterval<CqlDateTime>)d_;
    }


    #endregion Parameters

    #region Functions and Expressions (26)

    [CqlExpressionDefinition("Patient")]
    public Patient Patient(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Patient, Patient_Compute);

    private const long _cacheIndex_Patient = -4290830187024678405L;

    private Patient Patient_Compute(CqlContext context)
    {
        IEnumerable<Patient> a_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-patient"));
        Patient b_ = context.Operators.SingletonFrom<Patient>(a_);
        return b_;
    }


    [CqlFunctionDefinition("getStagingProcedure")]
    public IEnumerable<Procedure> getStagingProcedure(CqlContext context, Observation StagingObservation)
    {
        List<ResourceReference> a_ = StagingObservation?.PartOf;

        Procedure b_(ResourceReference StagingReference) {
            Procedure d_ = this.First_Bladder_Cancer_Staging_Procedure_during_6_Months_Prior_to_Measurement_Period_through_the_First_6_Months_of_Measurement_Period(context);
            Procedure[] e_ = [
                d_,
            ];

            bool? f_(Procedure FirstBladderCancerStagingMP) {
                Id i_ = FirstBladderCancerStagingMP?.IdElement;
                string j_ = i_?.Value;
                FhirString k_ = StagingReference?.ReferenceElement;
                string l_ = k_?.Value;
                string m_ = QICoreCommon_4_0_000.Instance.getId(context, l_);
                bool? n_ = context.Operators.Equal(j_, m_);
                return n_;
            }

            IEnumerable<Procedure> g_ = context.Operators.Where<Procedure>((IEnumerable<Procedure>)e_, f_);
            Procedure h_ = context.Operators.SingletonFrom<Procedure>(g_);
            return h_;
        }

        IEnumerable<Procedure> c_ = context.Operators.SelectDistinct<ResourceReference, Procedure>((IEnumerable<ResourceReference>)a_, b_);
        return c_;
    }


    [CqlFunctionDefinition("isVerified")]
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


    [CqlExpressionDefinition("Bladder Cancer Diagnosis")]
    public IEnumerable<Condition> Bladder_Cancer_Diagnosis(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Bladder_Cancer_Diagnosis, Bladder_Cancer_Diagnosis_Compute);

    private const long _cacheIndex_Bladder_Cancer_Diagnosis = 1627099199367917222L;

    private IEnumerable<Condition> Bladder_Cancer_Diagnosis_Compute(CqlContext context)
    {
        CqlValueSet a_ = this.Bladder_Cancer_for_Urology_Care(context);
        IEnumerable<Condition> b_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-problems-health-concerns"));
        IEnumerable<Condition> c_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-encounter-diagnosis"));
        IEnumerable<Condition> d_ = context.Operators.Union<Condition>(b_ as IEnumerable<Condition>, c_ as IEnumerable<Condition>);

        bool? e_(Condition BladderCancer) {
            CqlInterval<CqlDateTime> g_ = QICoreCommon_4_0_000.Instance.prevalenceInterval(context, BladderCancer);
            CqlDateTime h_ = context.Operators.Start(g_);
            CqlInterval<CqlDateTime> i_ = this.Measurement_Period(context);
            CqlDateTime j_ = context.Operators.End(i_);
            bool? k_ = context.Operators.Before(h_, j_, "day");
            DataType l_ = BladderCancer?.Onset;
            object m_ = FHIRHelpers_4_4_000.Instance.ToValue(context, l_);
            CqlInterval<CqlDateTime> n_ = QICoreCommon_4_0_000.Instance.toInterval(context, m_);
            CqlInterval<CqlDateTime> o_;
            CqlInterval<CqlDateTime> t_ = this.Measurement_Period(context);
            CqlDateTime u_ = context.Operators.End(t_);
            if (u_ is null)
            {
                o_ = default;
            }
            else
            {
                CqlInterval<CqlDateTime> v_ = this.Measurement_Period(context);
                CqlDateTime w_ = context.Operators.End(v_);
                CqlInterval<CqlDateTime> x_ = context.Operators.Interval(w_, w_, true, true);
                o_ = x_;
            }
            bool? p_ = context.Operators.Before(n_, o_, "day");
            bool? q_ = context.Operators.Or(k_, p_);
            bool? r_ = this.isVerified(context, BladderCancer);
            bool? s_ = context.Operators.And(q_, r_);
            return s_;
        }

        IEnumerable<Condition> f_ = context.Operators.Where<Condition>(d_, e_);
        return f_;
    }


    [CqlExpressionDefinition("First Bladder Cancer Staging Procedure")]
    public Procedure First_Bladder_Cancer_Staging_Procedure(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_First_Bladder_Cancer_Staging_Procedure, First_Bladder_Cancer_Staging_Procedure_Compute);

    private const long _cacheIndex_First_Bladder_Cancer_Staging_Procedure = -6479804162207901342L;

    private Procedure First_Bladder_Cancer_Staging_Procedure_Compute(CqlContext context)
    {
        CqlCode a_ = this.Tumor_staging__tumor_staging_(context);
        IEnumerable<CqlCode> b_ = context.Operators.ToList<CqlCode>(a_);
        IEnumerable<Procedure> c_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, default, b_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));

        bool? d_(Procedure BladderCancerStaging) {
            IEnumerable<Condition> k_ = this.Bladder_Cancer_Diagnosis(context);

            bool? l_(Condition BladderCancer) {
                object n_;
                DataType t_ = BladderCancerStaging?.Performed;
                object u_ = FHIRHelpers_4_4_000.Instance.ToValue(context, t_);
                bool v_ = u_ is CqlDateTime;
                if (v_)
                {
                    DataType w_ = BladderCancerStaging?.Performed;
                    object x_ = FHIRHelpers_4_4_000.Instance.ToValue(context, w_);
                    n_ = x_ as CqlDateTime;
                }
                else
                {
                    DataType y_ = BladderCancerStaging?.Performed;
                    object z_ = FHIRHelpers_4_4_000.Instance.ToValue(context, y_);
                    bool aa_ = z_ is CqlQuantity;
                    if (aa_)
                    {
                        DataType ab_ = BladderCancerStaging?.Performed;
                        object ac_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ab_);
                        n_ = ac_ as CqlQuantity;
                    }
                    else
                    {
                        DataType ad_ = BladderCancerStaging?.Performed;
                        object ae_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ad_);
                        bool af_ = ae_ is CqlInterval<CqlDateTime>;
                        if (af_)
                        {
                            DataType ag_ = BladderCancerStaging?.Performed;
                            object ah_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ag_);
                            n_ = ah_ as CqlInterval<CqlDateTime>;
                        }
                        else
                        {
                            DataType ai_ = BladderCancerStaging?.Performed;
                            object aj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ai_);
                            bool ak_ = aj_ is CqlInterval<CqlQuantity>;
                            if (ak_)
                            {
                                DataType al_ = BladderCancerStaging?.Performed;
                                object am_ = FHIRHelpers_4_4_000.Instance.ToValue(context, al_);
                                n_ = am_ as CqlInterval<CqlQuantity>;
                            }
                            else
                            {
                                n_ = null;
                            }
                        }
                    }
                }
                CqlInterval<CqlDateTime> o_ = QICoreCommon_4_0_000.Instance.toInterval(context, n_);
                CqlDateTime p_ = context.Operators.Start(o_);
                CqlInterval<CqlDateTime> q_ = QICoreCommon_4_0_000.Instance.prevalenceInterval(context, BladderCancer);
                CqlDateTime r_ = context.Operators.Start(q_);
                bool? s_ = context.Operators.SameOrBefore(p_, r_, "day");
                return s_;
            }

            bool? m_ = context.Operators.WhereAny<Condition>(k_, l_);
            return m_;
        }

        IEnumerable<Procedure> e_ = context.Operators.Where<Procedure>(c_, d_);

        bool? f_(Procedure BladderCancerStaging) {
            Code<EventStatus> an_ = BladderCancerStaging?.StatusElement;
            EventStatus? ao_ = an_?.Value;
            string ap_ = context.Operators.Convert<string>(ao_);
            bool? aq_ = context.Operators.Equal(ap_, "completed");
            return aq_;
        }

        IEnumerable<Procedure> g_ = context.Operators.Where<Procedure>(e_, f_);

        object h_(Procedure @this) {
            object ar_;
            DataType au_ = @this?.Performed;
            object av_ = FHIRHelpers_4_4_000.Instance.ToValue(context, au_);
            bool aw_ = av_ is CqlDateTime;
            if (aw_)
            {
                DataType ax_ = @this?.Performed;
                object ay_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ax_);
                ar_ = ay_ as CqlDateTime;
            }
            else
            {
                DataType az_ = @this?.Performed;
                object ba_ = FHIRHelpers_4_4_000.Instance.ToValue(context, az_);
                bool bb_ = ba_ is CqlQuantity;
                if (bb_)
                {
                    DataType bc_ = @this?.Performed;
                    object bd_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bc_);
                    ar_ = bd_ as CqlQuantity;
                }
                else
                {
                    DataType be_ = @this?.Performed;
                    object bf_ = FHIRHelpers_4_4_000.Instance.ToValue(context, be_);
                    bool bg_ = bf_ is CqlInterval<CqlDateTime>;
                    if (bg_)
                    {
                        DataType bh_ = @this?.Performed;
                        object bi_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bh_);
                        ar_ = bi_ as CqlInterval<CqlDateTime>;
                    }
                    else
                    {
                        DataType bj_ = @this?.Performed;
                        object bk_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bj_);
                        bool bl_ = bk_ is CqlInterval<CqlQuantity>;
                        if (bl_)
                        {
                            DataType bm_ = @this?.Performed;
                            object bn_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bm_);
                            ar_ = bn_ as CqlInterval<CqlQuantity>;
                        }
                        else
                        {
                            ar_ = null;
                        }
                    }
                }
            }
            CqlInterval<CqlDateTime> as_ = QICoreCommon_4_0_000.Instance.toInterval(context, ar_);
            CqlDateTime at_ = context.Operators.Start(as_);
            return at_;
        }

        IEnumerable<Procedure> i_ = context.Operators.SortBy<Procedure>(g_, h_, System.ComponentModel.ListSortDirection.Ascending);
        Procedure j_ = context.Operators.First<Procedure>(i_);
        return j_;
    }


    [CqlExpressionDefinition("July 1 of Year Prior to the Measurement Period")]
    public CqlDate July_1_of_Year_Prior_to_the_Measurement_Period(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_July_1_of_Year_Prior_to_the_Measurement_Period, July_1_of_Year_Prior_to_the_Measurement_Period_Compute);

    private const long _cacheIndex_July_1_of_Year_Prior_to_the_Measurement_Period = 4355411619980945622L;

    private CqlDate July_1_of_Year_Prior_to_the_Measurement_Period_Compute(CqlContext context)
    {
        CqlInterval<CqlDateTime> a_ = this.Measurement_Period(context);
        CqlDateTime b_ = context.Operators.Start(a_);
        int? c_ = context.Operators.DateTimeComponentFrom(b_, "year");
        int? d_ = context.Operators.Subtract(c_, 1);
        CqlDate e_ = context.Operators.Date(d_, 7, 1);
        return e_;
    }


    [CqlExpressionDefinition("June 30 of the Measurement Period")]
    public CqlDate June_30_of_the_Measurement_Period(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_June_30_of_the_Measurement_Period, June_30_of_the_Measurement_Period_Compute);

    private const long _cacheIndex_June_30_of_the_Measurement_Period = -1046525714915697033L;

    private CqlDate June_30_of_the_Measurement_Period_Compute(CqlContext context)
    {
        CqlInterval<CqlDateTime> a_ = this.Measurement_Period(context);
        CqlDateTime b_ = context.Operators.Start(a_);
        int? c_ = context.Operators.DateTimeComponentFrom(b_, "year");
        CqlDate d_ = context.Operators.Date(c_, 6, 30);
        return d_;
    }


    [CqlExpressionDefinition("First Bladder Cancer Staging Procedure during 6 Months Prior to Measurement Period through the First 6 Months of Measurement Period")]
    public Procedure First_Bladder_Cancer_Staging_Procedure_during_6_Months_Prior_to_Measurement_Period_through_the_First_6_Months_of_Measurement_Period(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_First_Bladder_Cancer_Staging_Procedure_during_6_Months_Prior_to_Measurement_Period_through_the_First_6_Months_of_Measurement_Period, First_Bladder_Cancer_Staging_Procedure_during_6_Months_Prior_to_Measurement_Period_through_the_First_6_Months_of_Measurement_Period_Compute);

    private const long _cacheIndex_First_Bladder_Cancer_Staging_Procedure_during_6_Months_Prior_to_Measurement_Period_through_the_First_6_Months_of_Measurement_Period = 89116089794995532L;

    private Procedure First_Bladder_Cancer_Staging_Procedure_during_6_Months_Prior_to_Measurement_Period_through_the_First_6_Months_of_Measurement_Period_Compute(CqlContext context)
    {
        Procedure a_ = this.First_Bladder_Cancer_Staging_Procedure(context);
        Procedure[] b_ = [
            a_,
        ];

        bool? c_(Procedure FirstBladderCancerStaging) {
            CqlDate f_ = this.July_1_of_Year_Prior_to_the_Measurement_Period(context);
            CqlDateTime g_ = context.Operators.ConvertDateToDateTime(f_);
            CqlDate h_ = this.June_30_of_the_Measurement_Period(context);
            CqlDateTime i_ = context.Operators.ConvertDateToDateTime(h_);
            CqlInterval<CqlDateTime> j_ = context.Operators.Interval(g_, i_, true, true);
            object k_;
            DataType n_ = FirstBladderCancerStaging?.Performed;
            object o_ = FHIRHelpers_4_4_000.Instance.ToValue(context, n_);
            bool p_ = o_ is CqlDateTime;
            if (p_)
            {
                DataType q_ = FirstBladderCancerStaging?.Performed;
                object r_ = FHIRHelpers_4_4_000.Instance.ToValue(context, q_);
                k_ = r_ as CqlDateTime;
            }
            else
            {
                DataType s_ = FirstBladderCancerStaging?.Performed;
                object t_ = FHIRHelpers_4_4_000.Instance.ToValue(context, s_);
                bool u_ = t_ is CqlQuantity;
                if (u_)
                {
                    DataType v_ = FirstBladderCancerStaging?.Performed;
                    object w_ = FHIRHelpers_4_4_000.Instance.ToValue(context, v_);
                    k_ = w_ as CqlQuantity;
                }
                else
                {
                    DataType x_ = FirstBladderCancerStaging?.Performed;
                    object y_ = FHIRHelpers_4_4_000.Instance.ToValue(context, x_);
                    bool z_ = y_ is CqlInterval<CqlDateTime>;
                    if (z_)
                    {
                        DataType aa_ = FirstBladderCancerStaging?.Performed;
                        object ab_ = FHIRHelpers_4_4_000.Instance.ToValue(context, aa_);
                        k_ = ab_ as CqlInterval<CqlDateTime>;
                    }
                    else
                    {
                        DataType ac_ = FirstBladderCancerStaging?.Performed;
                        object ad_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ac_);
                        bool ae_ = ad_ is CqlInterval<CqlQuantity>;
                        if (ae_)
                        {
                            DataType af_ = FirstBladderCancerStaging?.Performed;
                            object ag_ = FHIRHelpers_4_4_000.Instance.ToValue(context, af_);
                            k_ = ag_ as CqlInterval<CqlQuantity>;
                        }
                        else
                        {
                            k_ = null;
                        }
                    }
                }
            }
            CqlInterval<CqlDateTime> l_ = QICoreCommon_4_0_000.Instance.toInterval(context, k_);
            bool? m_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(j_, l_, "day");
            return m_;
        }

        IEnumerable<Procedure> d_ = context.Operators.Where<Procedure>((IEnumerable<Procedure>)b_, c_);
        Procedure e_ = context.Operators.SingletonFrom<Procedure>(d_);
        return e_;
    }


    [CqlExpressionDefinition("Has Most Recent Bladder Cancer Tumor Staging is T1, Tis, Ta HG")]
    public bool? Has_Most_Recent_Bladder_Cancer_Tumor_Staging_is_T1__Tis__Ta_HG(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Has_Most_Recent_Bladder_Cancer_Tumor_Staging_is_T1__Tis__Ta_HG, Has_Most_Recent_Bladder_Cancer_Tumor_Staging_is_T1__Tis__Ta_HG_Compute);

    private const long _cacheIndex_Has_Most_Recent_Bladder_Cancer_Tumor_Staging_is_T1__Tis__Ta_HG = 7659224977212191128L;

    private bool? Has_Most_Recent_Bladder_Cancer_Tumor_Staging_is_T1__Tis__Ta_HG_Compute(CqlContext context)
    {
        IEnumerable<Observation> a_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation-lab"));

        bool? b_(Observation StagingObservation) {
            IEnumerable<Procedure> d_ = this.getStagingProcedure(context, StagingObservation);
            bool? e_ = context.Operators.Not((bool?)(d_ is null));
            DataType f_ = StagingObservation?.Value;
            object g_ = FHIRHelpers_4_4_000.Instance.ToValue(context, f_);
            CqlCode h_ = this.American_Joint_Committee_on_Cancer_cT1__qualifier_value_(context);
            CqlConcept i_ = context.Operators.ConvertCodeToConcept(h_);
            bool? j_ = context.Operators.Equivalent(g_ as CqlConcept, i_);
            CqlCode k_ = this.American_Joint_Committee_on_Cancer_cTis__qualifier_value_(context);
            CqlConcept l_ = context.Operators.ConvertCodeToConcept(k_);
            bool? m_ = context.Operators.Equivalent(g_ as CqlConcept, l_);
            bool? n_ = context.Operators.Or(j_, m_);
            CqlCode o_ = this.American_Joint_Committee_on_Cancer_cTa__qualifier_value_(context);
            CqlConcept p_ = context.Operators.ConvertCodeToConcept(o_);
            bool? q_ = context.Operators.Equivalent(g_ as CqlConcept, p_);
            bool? r_ = context.Operators.Or(n_, q_);
            CqlCode s_ = this.Carcinoma_in_situ_of_bladder(context);
            CqlConcept t_ = context.Operators.ConvertCodeToConcept(s_);
            bool? u_ = context.Operators.Equivalent(g_ as CqlConcept, t_);
            bool? v_ = context.Operators.Or(r_, u_);
            bool? w_ = context.Operators.And(e_, v_);
            Code<ObservationStatus> x_ = StagingObservation?.StatusElement;
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

        bool? c_ = context.Operators.WhereAny<Observation>(a_, b_);
        return c_;
    }


    [CqlExpressionDefinition("Has Qualifying Encounter")]
    public bool? Has_Qualifying_Encounter(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Has_Qualifying_Encounter, Has_Qualifying_Encounter_Compute);

    private const long _cacheIndex_Has_Qualifying_Encounter = 6803347589664215006L;

    private bool? Has_Qualifying_Encounter_Compute(CqlContext context)
    {
        CqlValueSet a_ = this.Office_Visit(context);
        IEnumerable<Encounter> b_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));

        bool? c_(Encounter ValidEncounter) {
            CqlInterval<CqlDateTime> e_ = this.Measurement_Period(context);
            Period f_ = ValidEncounter?.Period;
            CqlInterval<CqlDateTime> g_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, f_);
            bool? h_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(e_, g_, "day");
            Coding i_ = ValidEncounter?.Class;
            CqlCode j_ = FHIRHelpers_4_4_000.Instance.ToCode(context, i_);
            CqlCode k_ = this.@virtual(context);
            bool? l_ = context.Operators.Equivalent(j_, k_);
            bool? m_ = context.Operators.Not(l_);
            bool? n_ = context.Operators.And(h_, m_);
            Code<Encounter.EncounterStatus> o_ = ValidEncounter?.StatusElement;
            Encounter.EncounterStatus? p_ = o_?.Value;
            Code<Encounter.EncounterStatus> q_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(p_);
            bool? r_ = context.Operators.Equal(q_, "finished");
            bool? s_ = context.Operators.And(n_, r_);
            return s_;
        }

        bool? d_ = context.Operators.WhereAny<Encounter>(b_, c_);
        return d_;
    }


    [CqlExpressionDefinition("Initial Population")]
    public bool? Initial_Population(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Initial_Population, Initial_Population_Compute);

    private const long _cacheIndex_Initial_Population = -1514878663221881824L;

    private bool? Initial_Population_Compute(CqlContext context)
    {
        bool? a_ = this.Has_Most_Recent_Bladder_Cancer_Tumor_Staging_is_T1__Tis__Ta_HG(context);
        bool? b_ = this.Has_Qualifying_Encounter(context);
        bool? c_ = context.Operators.And(a_, b_);
        return c_;
    }


    [CqlExpressionDefinition("Denominator")]
    public bool? Denominator(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Denominator, Denominator_Compute);

    private const long _cacheIndex_Denominator = 7894348376586324006L;

    private bool? Denominator_Compute(CqlContext context)
    {
        bool? a_ = this.Initial_Population(context);
        return a_;
    }


    [CqlExpressionDefinition("Acute Tuberculosis Diagnosis")]
    public IEnumerable<Condition> Acute_Tuberculosis_Diagnosis(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Acute_Tuberculosis_Diagnosis, Acute_Tuberculosis_Diagnosis_Compute);

    private const long _cacheIndex_Acute_Tuberculosis_Diagnosis = 2327826037250116643L;

    private IEnumerable<Condition> Acute_Tuberculosis_Diagnosis_Compute(CqlContext context)
    {
        CqlValueSet a_ = this.Tuberculosis_for_Urology_Care(context);
        IEnumerable<Condition> b_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-problems-health-concerns"));
        IEnumerable<Condition> c_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-encounter-diagnosis"));
        IEnumerable<Condition> d_ = context.Operators.Union<Condition>(b_ as IEnumerable<Condition>, c_ as IEnumerable<Condition>);

        bool? e_(Condition ActiveTuberculosis) {
            Procedure i_ = this.First_Bladder_Cancer_Staging_Procedure(context);
            Procedure[] j_ = [
                i_,
            ];

            bool? k_(Procedure FirstBladderCancerStaging) {
                CqlInterval<CqlDateTime> m_ = QICoreCommon_4_0_000.Instance.prevalenceInterval(context, ActiveTuberculosis);
                object n_;
                DataType af_ = FirstBladderCancerStaging?.Performed;
                object ag_ = FHIRHelpers_4_4_000.Instance.ToValue(context, af_);
                bool ah_ = ag_ is CqlDateTime;
                if (ah_)
                {
                    DataType ai_ = FirstBladderCancerStaging?.Performed;
                    object aj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ai_);
                    n_ = aj_ as CqlDateTime;
                }
                else
                {
                    DataType ak_ = FirstBladderCancerStaging?.Performed;
                    object al_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ak_);
                    bool am_ = al_ is CqlQuantity;
                    if (am_)
                    {
                        DataType an_ = FirstBladderCancerStaging?.Performed;
                        object ao_ = FHIRHelpers_4_4_000.Instance.ToValue(context, an_);
                        n_ = ao_ as CqlQuantity;
                    }
                    else
                    {
                        DataType ap_ = FirstBladderCancerStaging?.Performed;
                        object aq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ap_);
                        bool ar_ = aq_ is CqlInterval<CqlDateTime>;
                        if (ar_)
                        {
                            DataType as_ = FirstBladderCancerStaging?.Performed;
                            object at_ = FHIRHelpers_4_4_000.Instance.ToValue(context, as_);
                            n_ = at_ as CqlInterval<CqlDateTime>;
                        }
                        else
                        {
                            DataType au_ = FirstBladderCancerStaging?.Performed;
                            object av_ = FHIRHelpers_4_4_000.Instance.ToValue(context, au_);
                            bool aw_ = av_ is CqlInterval<CqlQuantity>;
                            if (aw_)
                            {
                                DataType ax_ = FirstBladderCancerStaging?.Performed;
                                object ay_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ax_);
                                n_ = ay_ as CqlInterval<CqlQuantity>;
                            }
                            else
                            {
                                n_ = null;
                            }
                        }
                    }
                }
                CqlInterval<CqlDateTime> o_ = QICoreCommon_4_0_000.Instance.toInterval(context, n_);
                bool? p_ = context.Operators.OverlapsAfter(m_, o_, "day");
                DataType q_ = ActiveTuberculosis?.Onset;
                object r_ = FHIRHelpers_4_4_000.Instance.ToValue(context, q_);
                CqlInterval<CqlDateTime> s_ = QICoreCommon_4_0_000.Instance.toInterval(context, r_);
                object t_;
                DataType az_ = FirstBladderCancerStaging?.Performed;
                object ba_ = FHIRHelpers_4_4_000.Instance.ToValue(context, az_);
                bool bb_ = ba_ is CqlDateTime;
                if (bb_)
                {
                    DataType bc_ = FirstBladderCancerStaging?.Performed;
                    object bd_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bc_);
                    t_ = bd_ as CqlDateTime;
                }
                else
                {
                    DataType be_ = FirstBladderCancerStaging?.Performed;
                    object bf_ = FHIRHelpers_4_4_000.Instance.ToValue(context, be_);
                    bool bg_ = bf_ is CqlQuantity;
                    if (bg_)
                    {
                        DataType bh_ = FirstBladderCancerStaging?.Performed;
                        object bi_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bh_);
                        t_ = bi_ as CqlQuantity;
                    }
                    else
                    {
                        DataType bj_ = FirstBladderCancerStaging?.Performed;
                        object bk_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bj_);
                        bool bl_ = bk_ is CqlInterval<CqlDateTime>;
                        if (bl_)
                        {
                            DataType bm_ = FirstBladderCancerStaging?.Performed;
                            object bn_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bm_);
                            t_ = bn_ as CqlInterval<CqlDateTime>;
                        }
                        else
                        {
                            DataType bo_ = FirstBladderCancerStaging?.Performed;
                            object bp_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bo_);
                            bool bq_ = bp_ is CqlInterval<CqlQuantity>;
                            if (bq_)
                            {
                                DataType br_ = FirstBladderCancerStaging?.Performed;
                                object bs_ = FHIRHelpers_4_4_000.Instance.ToValue(context, br_);
                                t_ = bs_ as CqlInterval<CqlQuantity>;
                            }
                            else
                            {
                                t_ = null;
                            }
                        }
                    }
                }
                CqlInterval<CqlDateTime> u_ = QICoreCommon_4_0_000.Instance.toInterval(context, t_);
                bool? v_ = context.Operators.OverlapsAfter(s_, u_, "day");
                DataType w_ = ActiveTuberculosis?.Abatement;
                object x_ = FHIRHelpers_4_4_000.Instance.ToValue(context, w_);
                CqlInterval<CqlDateTime> y_ = QICoreCommon_4_0_000.Instance.toInterval(context, x_);
                object z_;
                DataType bt_ = FirstBladderCancerStaging?.Performed;
                object bu_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bt_);
                bool bv_ = bu_ is CqlDateTime;
                if (bv_)
                {
                    DataType bw_ = FirstBladderCancerStaging?.Performed;
                    object bx_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bw_);
                    z_ = bx_ as CqlDateTime;
                }
                else
                {
                    DataType by_ = FirstBladderCancerStaging?.Performed;
                    object bz_ = FHIRHelpers_4_4_000.Instance.ToValue(context, by_);
                    bool ca_ = bz_ is CqlQuantity;
                    if (ca_)
                    {
                        DataType cb_ = FirstBladderCancerStaging?.Performed;
                        object cc_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cb_);
                        z_ = cc_ as CqlQuantity;
                    }
                    else
                    {
                        DataType cd_ = FirstBladderCancerStaging?.Performed;
                        object ce_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cd_);
                        bool cf_ = ce_ is CqlInterval<CqlDateTime>;
                        if (cf_)
                        {
                            DataType cg_ = FirstBladderCancerStaging?.Performed;
                            object ch_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cg_);
                            z_ = ch_ as CqlInterval<CqlDateTime>;
                        }
                        else
                        {
                            DataType ci_ = FirstBladderCancerStaging?.Performed;
                            object cj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ci_);
                            bool ck_ = cj_ is CqlInterval<CqlQuantity>;
                            if (ck_)
                            {
                                DataType cl_ = FirstBladderCancerStaging?.Performed;
                                object cm_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cl_);
                                z_ = cm_ as CqlInterval<CqlQuantity>;
                            }
                            else
                            {
                                z_ = null;
                            }
                        }
                    }
                }
                CqlInterval<CqlDateTime> aa_ = QICoreCommon_4_0_000.Instance.toInterval(context, z_);
                bool? ab_ = context.Operators.OverlapsAfter(y_, aa_, "day");
                bool? ac_ = context.Operators.Or(ab_, (bool?)(x_ is null));
                bool? ad_ = context.Operators.And(v_, ac_);
                bool? ae_ = context.Operators.Or(p_, ad_);
                return ae_;
            }

            bool? l_ = context.Operators.WhereAny<Procedure>((IEnumerable<Procedure>)j_, k_);
            return l_;
        }

        IEnumerable<Condition> f_ = context.Operators.Where<Condition>(d_, e_);

        bool? g_(Condition ActiveTuberculosis) {
            bool? cn_ = this.isVerified(context, ActiveTuberculosis);
            return cn_;
        }

        IEnumerable<Condition> h_ = context.Operators.Where<Condition>(f_, g_);
        return h_;
    }


    [CqlExpressionDefinition("Immunosuppressive Drugs")]
    public IEnumerable<MedicationRequest> Immunosuppressive_Drugs(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Immunosuppressive_Drugs, Immunosuppressive_Drugs_Compute);

    private const long _cacheIndex_Immunosuppressive_Drugs = -1231276537500245830L;

    private IEnumerable<MedicationRequest> Immunosuppressive_Drugs_Compute(CqlContext context)
    {
        IEnumerable<MedicationRequest> a_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));

        bool? b_(MedicationRequest MR) {
            IEnumerable<Medication> k_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));

            bool? l_(Medication M) {
                Id n_ = M?.IdElement;
                string o_ = n_?.Value;
                DataType p_ = MR?.Medication;
                FhirString r_ = p_ is ResourceReference q_ ? q_.ReferenceElement : null;
                string s_ = r_?.Value;
                IEnumerable<string> t_ = context.Operators.Split(s_, "/");
                string u_ = context.Operators.Last<string>(t_);
                bool? v_ = context.Operators.Equal(o_, u_);
                CodeableConcept w_ = M?.Code;
                CqlConcept x_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, w_);
                CqlValueSet y_ = this.Immunosuppressive_Drugs_for_Urology_Care(context);
                bool? z_ = context.Operators.ConceptInValueSet(x_, y_);
                bool? aa_ = context.Operators.And(v_, z_);
                return aa_;
            }

            bool? m_ = context.Operators.WhereAny<Medication>(k_, l_);
            return m_;
        }

        IEnumerable<MedicationRequest> c_ = context.Operators.Where<MedicationRequest>(a_, b_);
        CqlValueSet d_ = this.Immunosuppressive_Drugs_for_Urology_Care(context);
        IEnumerable<MedicationRequest> e_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, d_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> f_ = context.Operators.Union<MedicationRequest>(c_, e_);

        bool? g_(MedicationRequest ImmunosuppressiveDrugs) {
            Procedure ab_ = this.First_Bladder_Cancer_Staging_Procedure(context);
            Procedure[] ac_ = [
                ab_,
            ];

            bool? ad_(Procedure FirstBladderCancerStaging) {
                List<Dosage> af_ = ImmunosuppressiveDrugs?.DosageInstruction;

                bool? ag_(Dosage @this) {
                    Timing bi_ = @this?.Timing;
                    bool? bj_ = context.Operators.Not((bool?)(bi_ is null));
                    return bj_;
                }


                Timing ah_(Dosage @this) {
                    Timing bk_ = @this?.Timing;
                    return bk_;
                }

                IEnumerable<Timing> ai_ = context.Operators.WhereSelect<Dosage, Timing>((IEnumerable<Dosage>)af_, ag_, ah_);

                CqlDateTime aj_(Timing dosageTiming) {
                    List<FhirDateTime> bl_ = dosageTiming?.EventElement;

                    CqlDateTime bm_(FhirDateTime @this) {
                        CqlDateTime bq_ = context.Operators.Convert<CqlDateTime>(@this);
                        return bq_;
                    }

                    IEnumerable<CqlDateTime> bn_ = context.Operators.Select<FhirDateTime, CqlDateTime>((IEnumerable<FhirDateTime>)bl_, bm_);
                    IEnumerable<CqlDateTime> bo_ = context.Operators.ListSort<CqlDateTime>(bn_, System.ComponentModel.ListSortDirection.Ascending);
                    CqlDateTime bp_ = context.Operators.First<CqlDateTime>(bo_);
                    return bp_;
                }

                IEnumerable<CqlDateTime> ak_ = context.Operators.SelectDistinct<Timing, CqlDateTime>(ai_, aj_);
                IEnumerable<CqlDateTime> al_ = context.Operators.ListSort<CqlDateTime>(ak_, System.ComponentModel.ListSortDirection.Ascending);
                CqlDateTime am_ = context.Operators.First<CqlDateTime>(al_);
                CqlInterval<CqlDateTime> an_ = QICoreCommon_4_0_000.Instance.toInterval(context, am_);

                bool? ao_(Dosage @this) {
                    Timing br_ = @this?.Timing;
                    bool? bs_ = context.Operators.Not((bool?)(br_ is null));
                    return bs_;
                }


                Timing ap_(Dosage @this) {
                    Timing bt_ = @this?.Timing;
                    return bt_;
                }

                IEnumerable<Timing> aq_ = context.Operators.WhereSelect<Dosage, Timing>((IEnumerable<Dosage>)af_, ao_, ap_);

                bool? ar_(Timing @this) {
                    Timing.RepeatComponent bu_ = @this?.Repeat;
                    bool? bv_ = context.Operators.Not((bool?)(bu_ is null));
                    return bv_;
                }


                Timing.RepeatComponent as_(Timing @this) {
                    Timing.RepeatComponent bw_ = @this?.Repeat;
                    return bw_;
                }

                IEnumerable<Timing.RepeatComponent> at_ = context.Operators.WhereSelect<Timing, Timing.RepeatComponent>(aq_, ar_, as_);

                bool? au_(Timing.RepeatComponent @this) {
                    DataType bx_ = @this?.Bounds;
                    object by_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bx_);
                    bool? bz_ = context.Operators.Not((bool?)(by_ is null));
                    return bz_;
                }


                object av_(Timing.RepeatComponent @this) {
                    DataType ca_ = @this?.Bounds;
                    object cb_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ca_);
                    return cb_;
                }

                IEnumerable<object> aw_ = context.Operators.WhereSelect<Timing.RepeatComponent, object>(at_, au_, av_);

                CqlInterval<CqlDateTime> ax_(object DoseTime) {
                    CqlInterval<CqlDateTime> cc_ = QICoreCommon_4_0_000.Instance.toInterval(context, DoseTime);
                    return cc_;
                }

                IEnumerable<CqlInterval<CqlDateTime>> ay_ = context.Operators.SelectDistinct<object, CqlInterval<CqlDateTime>>(aw_, ax_);
                IEnumerable<CqlInterval<CqlDateTime>> az_ = context.Operators.Collapse(ay_, (string)default);

                object ba_(CqlInterval<CqlDateTime> @this) {
                    CqlDateTime cd_ = context.Operators.Start(@this);
                    return cd_;
                }

                IEnumerable<CqlInterval<CqlDateTime>> bb_ = context.Operators.SortBy<CqlInterval<CqlDateTime>>(az_, ba_, System.ComponentModel.ListSortDirection.Ascending);
                CqlInterval<CqlDateTime> bc_ = context.Operators.First<CqlInterval<CqlDateTime>>(bb_);
                CqlDateTime bd_ = context.Operators.Start(an_ ?? bc_);
                object be_;
                DataType ce_ = FirstBladderCancerStaging?.Performed;
                object cf_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ce_);
                bool cg_ = cf_ is CqlDateTime;
                if (cg_)
                {
                    DataType ch_ = FirstBladderCancerStaging?.Performed;
                    object ci_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ch_);
                    be_ = ci_ as CqlDateTime;
                }
                else
                {
                    DataType cj_ = FirstBladderCancerStaging?.Performed;
                    object ck_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cj_);
                    bool cl_ = ck_ is CqlQuantity;
                    if (cl_)
                    {
                        DataType cm_ = FirstBladderCancerStaging?.Performed;
                        object cn_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cm_);
                        be_ = cn_ as CqlQuantity;
                    }
                    else
                    {
                        DataType co_ = FirstBladderCancerStaging?.Performed;
                        object cp_ = FHIRHelpers_4_4_000.Instance.ToValue(context, co_);
                        bool cq_ = cp_ is CqlInterval<CqlDateTime>;
                        if (cq_)
                        {
                            DataType cr_ = FirstBladderCancerStaging?.Performed;
                            object cs_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cr_);
                            be_ = cs_ as CqlInterval<CqlDateTime>;
                        }
                        else
                        {
                            DataType ct_ = FirstBladderCancerStaging?.Performed;
                            object cu_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ct_);
                            bool cv_ = cu_ is CqlInterval<CqlQuantity>;
                            if (cv_)
                            {
                                DataType cw_ = FirstBladderCancerStaging?.Performed;
                                object cx_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cw_);
                                be_ = cx_ as CqlInterval<CqlQuantity>;
                            }
                            else
                            {
                                be_ = null;
                            }
                        }
                    }
                }
                CqlInterval<CqlDateTime> bf_ = QICoreCommon_4_0_000.Instance.toInterval(context, be_);
                CqlDateTime bg_ = context.Operators.Start(bf_);
                bool? bh_ = context.Operators.SameOrBefore(bd_, bg_, "day");
                return bh_;
            }

            bool? ae_ = context.Operators.WhereAny<Procedure>((IEnumerable<Procedure>)ac_, ad_);
            return ae_;
        }

        IEnumerable<MedicationRequest> h_ = context.Operators.Where<MedicationRequest>(f_, g_);

        bool? i_(MedicationRequest ImmunosuppressiveDrugs) {
            Code<MedicationRequest.MedicationrequestStatus> cy_ = ImmunosuppressiveDrugs?.StatusElement;
            MedicationRequest.MedicationrequestStatus? cz_ = cy_?.Value;
            string da_ = context.Operators.Convert<string>(cz_);
            string[] db_ = [
                "active",
                "completed",
            ];
            bool? dc_ = context.Operators.In<string>(da_, (IEnumerable<string>)db_);
            Code<MedicationRequest.MedicationRequestIntent> dd_ = ImmunosuppressiveDrugs?.IntentElement;
            MedicationRequest.MedicationRequestIntent? de_ = dd_?.Value;
            string df_ = context.Operators.Convert<string>(de_);
            bool? dg_ = context.Operators.Equal(df_, "order");
            bool? dh_ = context.Operators.And(dc_, dg_);
            return dh_;
        }

        IEnumerable<MedicationRequest> j_ = context.Operators.Where<MedicationRequest>(h_, i_);
        return j_;
    }


    [CqlExpressionDefinition("Cystectomy Done")]
    public IEnumerable<Procedure> Cystectomy_Done(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Cystectomy_Done, Cystectomy_Done_Compute);

    private const long _cacheIndex_Cystectomy_Done = 4990480937945600756L;

    private IEnumerable<Procedure> Cystectomy_Done_Compute(CqlContext context)
    {
        CqlValueSet a_ = this.Cystectomy_for_Urology_Care(context);
        IEnumerable<Procedure> b_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));

        bool? c_(Procedure Cystectomy) {
            Procedure g_ = this.First_Bladder_Cancer_Staging_Procedure(context);
            Procedure[] h_ = [
                g_,
            ];

            bool? i_(Procedure FirstBladderCancerStaging) {
                object k_;
                DataType ac_ = Cystectomy?.Performed;
                object ad_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ac_);
                bool ae_ = ad_ is CqlDateTime;
                if (ae_)
                {
                    DataType af_ = Cystectomy?.Performed;
                    object ag_ = FHIRHelpers_4_4_000.Instance.ToValue(context, af_);
                    k_ = ag_ as CqlDateTime;
                }
                else
                {
                    DataType ah_ = Cystectomy?.Performed;
                    object ai_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ah_);
                    bool aj_ = ai_ is CqlQuantity;
                    if (aj_)
                    {
                        DataType ak_ = Cystectomy?.Performed;
                        object al_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ak_);
                        k_ = al_ as CqlQuantity;
                    }
                    else
                    {
                        DataType am_ = Cystectomy?.Performed;
                        object an_ = FHIRHelpers_4_4_000.Instance.ToValue(context, am_);
                        bool ao_ = an_ is CqlInterval<CqlDateTime>;
                        if (ao_)
                        {
                            DataType ap_ = Cystectomy?.Performed;
                            object aq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ap_);
                            k_ = aq_ as CqlInterval<CqlDateTime>;
                        }
                        else
                        {
                            DataType ar_ = Cystectomy?.Performed;
                            object as_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ar_);
                            bool at_ = as_ is CqlInterval<CqlQuantity>;
                            if (at_)
                            {
                                DataType au_ = Cystectomy?.Performed;
                                object av_ = FHIRHelpers_4_4_000.Instance.ToValue(context, au_);
                                k_ = av_ as CqlInterval<CqlQuantity>;
                            }
                            else
                            {
                                k_ = null;
                            }
                        }
                    }
                }
                CqlInterval<CqlDateTime> l_ = QICoreCommon_4_0_000.Instance.toInterval(context, k_);
                CqlDateTime m_ = context.Operators.End(l_);
                object n_;
                DataType aw_ = FirstBladderCancerStaging?.Performed;
                object ax_ = FHIRHelpers_4_4_000.Instance.ToValue(context, aw_);
                bool ay_ = ax_ is CqlDateTime;
                if (ay_)
                {
                    DataType az_ = FirstBladderCancerStaging?.Performed;
                    object ba_ = FHIRHelpers_4_4_000.Instance.ToValue(context, az_);
                    n_ = ba_ as CqlDateTime;
                }
                else
                {
                    DataType bb_ = FirstBladderCancerStaging?.Performed;
                    object bc_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bb_);
                    bool bd_ = bc_ is CqlQuantity;
                    if (bd_)
                    {
                        DataType be_ = FirstBladderCancerStaging?.Performed;
                        object bf_ = FHIRHelpers_4_4_000.Instance.ToValue(context, be_);
                        n_ = bf_ as CqlQuantity;
                    }
                    else
                    {
                        DataType bg_ = FirstBladderCancerStaging?.Performed;
                        object bh_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bg_);
                        bool bi_ = bh_ is CqlInterval<CqlDateTime>;
                        if (bi_)
                        {
                            DataType bj_ = FirstBladderCancerStaging?.Performed;
                            object bk_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bj_);
                            n_ = bk_ as CqlInterval<CqlDateTime>;
                        }
                        else
                        {
                            DataType bl_ = FirstBladderCancerStaging?.Performed;
                            object bm_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bl_);
                            bool bn_ = bm_ is CqlInterval<CqlQuantity>;
                            if (bn_)
                            {
                                DataType bo_ = FirstBladderCancerStaging?.Performed;
                                object bp_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bo_);
                                n_ = bp_ as CqlInterval<CqlQuantity>;
                            }
                            else
                            {
                                n_ = null;
                            }
                        }
                    }
                }
                CqlInterval<CqlDateTime> o_ = QICoreCommon_4_0_000.Instance.toInterval(context, n_);
                CqlDateTime p_ = context.Operators.Start(o_);
                CqlQuantity q_ = context.Operators.Quantity(6m, "months");
                CqlDateTime r_ = context.Operators.Subtract(p_, q_);
                object s_;
                DataType bq_ = FirstBladderCancerStaging?.Performed;
                object br_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bq_);
                bool bs_ = br_ is CqlDateTime;
                if (bs_)
                {
                    DataType bt_ = FirstBladderCancerStaging?.Performed;
                    object bu_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bt_);
                    s_ = bu_ as CqlDateTime;
                }
                else
                {
                    DataType bv_ = FirstBladderCancerStaging?.Performed;
                    object bw_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bv_);
                    bool bx_ = bw_ is CqlQuantity;
                    if (bx_)
                    {
                        DataType by_ = FirstBladderCancerStaging?.Performed;
                        object bz_ = FHIRHelpers_4_4_000.Instance.ToValue(context, by_);
                        s_ = bz_ as CqlQuantity;
                    }
                    else
                    {
                        DataType ca_ = FirstBladderCancerStaging?.Performed;
                        object cb_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ca_);
                        bool cc_ = cb_ is CqlInterval<CqlDateTime>;
                        if (cc_)
                        {
                            DataType cd_ = FirstBladderCancerStaging?.Performed;
                            object ce_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cd_);
                            s_ = ce_ as CqlInterval<CqlDateTime>;
                        }
                        else
                        {
                            DataType cf_ = FirstBladderCancerStaging?.Performed;
                            object cg_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cf_);
                            bool ch_ = cg_ is CqlInterval<CqlQuantity>;
                            if (ch_)
                            {
                                DataType ci_ = FirstBladderCancerStaging?.Performed;
                                object cj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ci_);
                                s_ = cj_ as CqlInterval<CqlQuantity>;
                            }
                            else
                            {
                                s_ = null;
                            }
                        }
                    }
                }
                CqlInterval<CqlDateTime> t_ = QICoreCommon_4_0_000.Instance.toInterval(context, s_);
                CqlDateTime u_ = context.Operators.Start(t_);
                CqlInterval<CqlDateTime> v_ = context.Operators.Interval(r_, u_, true, false);
                bool? w_ = context.Operators.In<CqlDateTime>(m_, v_, "day");
                object x_;
                DataType ck_ = FirstBladderCancerStaging?.Performed;
                object cl_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ck_);
                bool cm_ = cl_ is CqlDateTime;
                if (cm_)
                {
                    DataType cn_ = FirstBladderCancerStaging?.Performed;
                    object co_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cn_);
                    x_ = co_ as CqlDateTime;
                }
                else
                {
                    DataType cp_ = FirstBladderCancerStaging?.Performed;
                    object cq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cp_);
                    bool cr_ = cq_ is CqlQuantity;
                    if (cr_)
                    {
                        DataType cs_ = FirstBladderCancerStaging?.Performed;
                        object ct_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cs_);
                        x_ = ct_ as CqlQuantity;
                    }
                    else
                    {
                        DataType cu_ = FirstBladderCancerStaging?.Performed;
                        object cv_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cu_);
                        bool cw_ = cv_ is CqlInterval<CqlDateTime>;
                        if (cw_)
                        {
                            DataType cx_ = FirstBladderCancerStaging?.Performed;
                            object cy_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cx_);
                            x_ = cy_ as CqlInterval<CqlDateTime>;
                        }
                        else
                        {
                            DataType cz_ = FirstBladderCancerStaging?.Performed;
                            object da_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cz_);
                            bool db_ = da_ is CqlInterval<CqlQuantity>;
                            if (db_)
                            {
                                DataType dc_ = FirstBladderCancerStaging?.Performed;
                                object dd_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dc_);
                                x_ = dd_ as CqlInterval<CqlQuantity>;
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
                bool? aa_ = context.Operators.Not((bool?)(z_ is null));
                bool? ab_ = context.Operators.And(w_, aa_);
                return ab_;
            }

            bool? j_ = context.Operators.WhereAny<Procedure>((IEnumerable<Procedure>)h_, i_);
            return j_;
        }

        IEnumerable<Procedure> d_ = context.Operators.Where<Procedure>(b_, c_);

        bool? e_(Procedure Cystectomy) {
            Code<EventStatus> de_ = Cystectomy?.StatusElement;
            EventStatus? df_ = de_?.Value;
            string dg_ = context.Operators.Convert<string>(df_);
            bool? dh_ = context.Operators.Equal(dg_, "completed");
            return dh_;
        }

        IEnumerable<Procedure> f_ = context.Operators.Where<Procedure>(d_, e_);
        return f_;
    }


    [CqlExpressionDefinition("Has Excluding HIV, Immunocompromised Conditions or Mixed Histology Before Staging")]
    public bool? Has_Excluding_HIV__Immunocompromised_Conditions_or_Mixed_Histology_Before_Staging(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Has_Excluding_HIV__Immunocompromised_Conditions_or_Mixed_Histology_Before_Staging, Has_Excluding_HIV__Immunocompromised_Conditions_or_Mixed_Histology_Before_Staging_Compute);

    private const long _cacheIndex_Has_Excluding_HIV__Immunocompromised_Conditions_or_Mixed_Histology_Before_Staging = -2614027900018808318L;

    private bool? Has_Excluding_HIV__Immunocompromised_Conditions_or_Mixed_Histology_Before_Staging_Compute(CqlContext context)
    {
        CqlValueSet a_ = this.HIV(context);
        IEnumerable<Condition> b_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-problems-health-concerns"));
        IEnumerable<Condition> c_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-encounter-diagnosis"));
        IEnumerable<Condition> d_ = context.Operators.Union<Condition>(b_ as IEnumerable<Condition>, c_ as IEnumerable<Condition>);
        CqlValueSet e_ = this.Immunocompromised_Conditions(context);
        IEnumerable<Condition> f_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, e_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-problems-health-concerns"));
        IEnumerable<Condition> g_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, e_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-encounter-diagnosis"));
        IEnumerable<Condition> h_ = context.Operators.Union<Condition>(f_ as IEnumerable<Condition>, g_ as IEnumerable<Condition>);
        IEnumerable<Condition> i_ = context.Operators.Union<Condition>(d_, h_);
        CqlValueSet j_ = this.Mixed_Histology_Urothelial_Cell_Carcinoma_for_Urology_Care(context);
        IEnumerable<Condition> k_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, j_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-problems-health-concerns"));
        IEnumerable<Condition> l_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, j_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-encounter-diagnosis"));
        IEnumerable<Condition> m_ = context.Operators.Union<Condition>(k_ as IEnumerable<Condition>, l_ as IEnumerable<Condition>);
        IEnumerable<Condition> n_ = context.Operators.Union<Condition>(i_, m_);

        bool? o_(Condition ExclusionDiagnosis) {
            Procedure s_ = this.First_Bladder_Cancer_Staging_Procedure(context);
            Procedure[] t_ = [
                s_,
            ];

            bool? u_(Procedure FirstBladderCancerStaging) {
                CqlInterval<CqlDateTime> w_ = QICoreCommon_4_0_000.Instance.prevalenceInterval(context, ExclusionDiagnosis);
                CqlDateTime x_ = context.Operators.Start(w_);
                object y_;
                DataType al_ = FirstBladderCancerStaging?.Performed;
                object am_ = FHIRHelpers_4_4_000.Instance.ToValue(context, al_);
                bool an_ = am_ is CqlDateTime;
                if (an_)
                {
                    DataType ao_ = FirstBladderCancerStaging?.Performed;
                    object ap_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ao_);
                    y_ = ap_ as CqlDateTime;
                }
                else
                {
                    DataType aq_ = FirstBladderCancerStaging?.Performed;
                    object ar_ = FHIRHelpers_4_4_000.Instance.ToValue(context, aq_);
                    bool as_ = ar_ is CqlQuantity;
                    if (as_)
                    {
                        DataType at_ = FirstBladderCancerStaging?.Performed;
                        object au_ = FHIRHelpers_4_4_000.Instance.ToValue(context, at_);
                        y_ = au_ as CqlQuantity;
                    }
                    else
                    {
                        DataType av_ = FirstBladderCancerStaging?.Performed;
                        object aw_ = FHIRHelpers_4_4_000.Instance.ToValue(context, av_);
                        bool ax_ = aw_ is CqlInterval<CqlDateTime>;
                        if (ax_)
                        {
                            DataType ay_ = FirstBladderCancerStaging?.Performed;
                            object az_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ay_);
                            y_ = az_ as CqlInterval<CqlDateTime>;
                        }
                        else
                        {
                            DataType ba_ = FirstBladderCancerStaging?.Performed;
                            object bb_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ba_);
                            bool bc_ = bb_ is CqlInterval<CqlQuantity>;
                            if (bc_)
                            {
                                DataType bd_ = FirstBladderCancerStaging?.Performed;
                                object be_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bd_);
                                y_ = be_ as CqlInterval<CqlQuantity>;
                            }
                            else
                            {
                                y_ = null;
                            }
                        }
                    }
                }
                CqlInterval<CqlDateTime> z_ = QICoreCommon_4_0_000.Instance.toInterval(context, y_);
                CqlDateTime aa_ = context.Operators.Start(z_);
                bool? ab_ = context.Operators.SameOrBefore(x_, aa_, "day");
                DataType ac_ = ExclusionDiagnosis?.Onset;
                object ad_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ac_);
                CqlInterval<CqlDateTime> ae_ = QICoreCommon_4_0_000.Instance.toInterval(context, ad_);
                CqlDateTime af_ = context.Operators.Start(ae_);
                object ag_;
                DataType bf_ = FirstBladderCancerStaging?.Performed;
                object bg_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bf_);
                bool bh_ = bg_ is CqlDateTime;
                if (bh_)
                {
                    DataType bi_ = FirstBladderCancerStaging?.Performed;
                    object bj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bi_);
                    ag_ = bj_ as CqlDateTime;
                }
                else
                {
                    DataType bk_ = FirstBladderCancerStaging?.Performed;
                    object bl_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bk_);
                    bool bm_ = bl_ is CqlQuantity;
                    if (bm_)
                    {
                        DataType bn_ = FirstBladderCancerStaging?.Performed;
                        object bo_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bn_);
                        ag_ = bo_ as CqlQuantity;
                    }
                    else
                    {
                        DataType bp_ = FirstBladderCancerStaging?.Performed;
                        object bq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bp_);
                        bool br_ = bq_ is CqlInterval<CqlDateTime>;
                        if (br_)
                        {
                            DataType bs_ = FirstBladderCancerStaging?.Performed;
                            object bt_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bs_);
                            ag_ = bt_ as CqlInterval<CqlDateTime>;
                        }
                        else
                        {
                            DataType bu_ = FirstBladderCancerStaging?.Performed;
                            object bv_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bu_);
                            bool bw_ = bv_ is CqlInterval<CqlQuantity>;
                            if (bw_)
                            {
                                DataType bx_ = FirstBladderCancerStaging?.Performed;
                                object by_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bx_);
                                ag_ = by_ as CqlInterval<CqlQuantity>;
                            }
                            else
                            {
                                ag_ = null;
                            }
                        }
                    }
                }
                CqlInterval<CqlDateTime> ah_ = QICoreCommon_4_0_000.Instance.toInterval(context, ag_);
                CqlDateTime ai_ = context.Operators.Start(ah_);
                bool? aj_ = context.Operators.SameOrBefore(af_, ai_, "day");
                bool? ak_ = context.Operators.Or(ab_, aj_);
                return ak_;
            }

            bool? v_ = context.Operators.WhereAny<Procedure>((IEnumerable<Procedure>)t_, u_);
            return v_;
        }

        IEnumerable<Condition> p_ = context.Operators.Where<Condition>(n_, o_);

        bool? q_(Condition ExclusionDiagnosis) {
            bool? bz_ = this.isVerified(context, ExclusionDiagnosis);
            return bz_;
        }

        bool? r_ = context.Operators.WhereAny<Condition>(p_, q_);
        return r_;
    }


    [CqlExpressionDefinition("Has Excluding Chemotherapy or Radiotherapy Procedure Before Staging")]
    public bool? Has_Excluding_Chemotherapy_or_Radiotherapy_Procedure_Before_Staging(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Has_Excluding_Chemotherapy_or_Radiotherapy_Procedure_Before_Staging, Has_Excluding_Chemotherapy_or_Radiotherapy_Procedure_Before_Staging_Compute);

    private const long _cacheIndex_Has_Excluding_Chemotherapy_or_Radiotherapy_Procedure_Before_Staging = 52129356822395367L;

    private bool? Has_Excluding_Chemotherapy_or_Radiotherapy_Procedure_Before_Staging_Compute(CqlContext context)
    {
        IEnumerable<MedicationRequest> a_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));

        bool? b_(MedicationRequest MR) {
            IEnumerable<Medication> t_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));

            bool? u_(Medication M) {
                Id w_ = M?.IdElement;
                string x_ = w_?.Value;
                DataType y_ = MR?.Medication;
                FhirString aa_ = y_ is ResourceReference z_ ? z_.ReferenceElement : null;
                string ab_ = aa_?.Value;
                IEnumerable<string> ac_ = context.Operators.Split(ab_, "/");
                string ad_ = context.Operators.Last<string>(ac_);
                bool? ae_ = context.Operators.Equal(x_, ad_);
                CodeableConcept af_ = M?.Code;
                CqlConcept ag_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, af_);
                CqlValueSet ah_ = this.Chemotherapy_Agents_for_Advanced_Cancer(context);
                bool? ai_ = context.Operators.ConceptInValueSet(ag_, ah_);
                bool? aj_ = context.Operators.And(ae_, ai_);
                return aj_;
            }

            bool? v_ = context.Operators.WhereAny<Medication>(t_, u_);
            return v_;
        }

        IEnumerable<MedicationRequest> c_ = context.Operators.Where<MedicationRequest>(a_, b_);
        CqlValueSet d_ = this.Chemotherapy_Agents_for_Advanced_Cancer(context);
        IEnumerable<MedicationRequest> e_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, d_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> f_ = context.Operators.Union<MedicationRequest>(c_, e_);

        bool? g_(MedicationRequest ExclusionMed) {
            Procedure ak_ = this.First_Bladder_Cancer_Staging_Procedure(context);
            Procedure[] al_ = [
                ak_,
            ];

            bool? am_(Procedure FirstBladderCancerStaging) {
                List<Dosage> ao_ = ExclusionMed?.DosageInstruction;

                bool? ap_(Dosage @this) {
                    Timing bu_ = @this?.Timing;
                    bool? bv_ = context.Operators.Not((bool?)(bu_ is null));
                    return bv_;
                }


                Timing aq_(Dosage @this) {
                    Timing bw_ = @this?.Timing;
                    return bw_;
                }

                IEnumerable<Timing> ar_ = context.Operators.WhereSelect<Dosage, Timing>((IEnumerable<Dosage>)ao_, ap_, aq_);

                bool? as_(Timing @this) {
                    Timing.RepeatComponent bx_ = @this?.Repeat;
                    bool? by_ = context.Operators.Not((bool?)(bx_ is null));
                    return by_;
                }


                Timing.RepeatComponent at_(Timing @this) {
                    Timing.RepeatComponent bz_ = @this?.Repeat;
                    return bz_;
                }

                IEnumerable<Timing.RepeatComponent> au_ = context.Operators.WhereSelect<Timing, Timing.RepeatComponent>(ar_, as_, at_);

                bool? av_(Timing.RepeatComponent @this) {
                    DataType ca_ = @this?.Bounds;
                    object cb_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ca_);
                    bool? cc_ = context.Operators.Not((bool?)(cb_ is null));
                    return cc_;
                }


                object aw_(Timing.RepeatComponent @this) {
                    DataType cd_ = @this?.Bounds;
                    object ce_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cd_);
                    return ce_;
                }

                IEnumerable<object> ax_ = context.Operators.WhereSelect<Timing.RepeatComponent, object>(au_, av_, aw_);

                CqlInterval<CqlDateTime> ay_(object DoseTime) {
                    CqlInterval<CqlDateTime> cf_ = QICoreCommon_4_0_000.Instance.toInterval(context, DoseTime);
                    return cf_;
                }

                IEnumerable<CqlInterval<CqlDateTime>> az_ = context.Operators.SelectDistinct<object, CqlInterval<CqlDateTime>>(ax_, ay_);
                IEnumerable<CqlInterval<CqlDateTime>> ba_ = context.Operators.Collapse(az_, (string)default);

                object bb_(CqlInterval<CqlDateTime> @this) {
                    CqlDateTime cg_ = context.Operators.Start(@this);
                    return cg_;
                }

                IEnumerable<CqlInterval<CqlDateTime>> bc_ = context.Operators.SortBy<CqlInterval<CqlDateTime>>(ba_, bb_, System.ComponentModel.ListSortDirection.Ascending);
                CqlInterval<CqlDateTime> bd_ = context.Operators.First<CqlInterval<CqlDateTime>>(bc_);
                CqlDateTime be_ = context.Operators.Start(bd_);
                object bf_;
                DataType ch_ = FirstBladderCancerStaging?.Performed;
                object ci_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ch_);
                bool cj_ = ci_ is CqlDateTime;
                if (cj_)
                {
                    DataType ck_ = FirstBladderCancerStaging?.Performed;
                    object cl_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ck_);
                    bf_ = cl_ as CqlDateTime;
                }
                else
                {
                    DataType cm_ = FirstBladderCancerStaging?.Performed;
                    object cn_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cm_);
                    bool co_ = cn_ is CqlQuantity;
                    if (co_)
                    {
                        DataType cp_ = FirstBladderCancerStaging?.Performed;
                        object cq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cp_);
                        bf_ = cq_ as CqlQuantity;
                    }
                    else
                    {
                        DataType cr_ = FirstBladderCancerStaging?.Performed;
                        object cs_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cr_);
                        bool ct_ = cs_ is CqlInterval<CqlDateTime>;
                        if (ct_)
                        {
                            DataType cu_ = FirstBladderCancerStaging?.Performed;
                            object cv_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cu_);
                            bf_ = cv_ as CqlInterval<CqlDateTime>;
                        }
                        else
                        {
                            DataType cw_ = FirstBladderCancerStaging?.Performed;
                            object cx_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cw_);
                            bool cy_ = cx_ is CqlInterval<CqlQuantity>;
                            if (cy_)
                            {
                                DataType cz_ = FirstBladderCancerStaging?.Performed;
                                object da_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cz_);
                                bf_ = da_ as CqlInterval<CqlQuantity>;
                            }
                            else
                            {
                                bf_ = null;
                            }
                        }
                    }
                }
                CqlInterval<CqlDateTime> bg_ = QICoreCommon_4_0_000.Instance.toInterval(context, bf_);
                CqlDateTime bh_ = context.Operators.Start(bg_);
                CqlQuantity bi_ = context.Operators.Quantity(6m, "months");
                CqlDateTime bj_ = context.Operators.Subtract(bh_, bi_);
                object bk_;
                DataType db_ = FirstBladderCancerStaging?.Performed;
                object dc_ = FHIRHelpers_4_4_000.Instance.ToValue(context, db_);
                bool dd_ = dc_ is CqlDateTime;
                if (dd_)
                {
                    DataType de_ = FirstBladderCancerStaging?.Performed;
                    object df_ = FHIRHelpers_4_4_000.Instance.ToValue(context, de_);
                    bk_ = df_ as CqlDateTime;
                }
                else
                {
                    DataType dg_ = FirstBladderCancerStaging?.Performed;
                    object dh_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dg_);
                    bool di_ = dh_ is CqlQuantity;
                    if (di_)
                    {
                        DataType dj_ = FirstBladderCancerStaging?.Performed;
                        object dk_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dj_);
                        bk_ = dk_ as CqlQuantity;
                    }
                    else
                    {
                        DataType dl_ = FirstBladderCancerStaging?.Performed;
                        object dm_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dl_);
                        bool dn_ = dm_ is CqlInterval<CqlDateTime>;
                        if (dn_)
                        {
                            DataType do_ = FirstBladderCancerStaging?.Performed;
                            object dp_ = FHIRHelpers_4_4_000.Instance.ToValue(context, do_);
                            bk_ = dp_ as CqlInterval<CqlDateTime>;
                        }
                        else
                        {
                            DataType dq_ = FirstBladderCancerStaging?.Performed;
                            object dr_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dq_);
                            bool ds_ = dr_ is CqlInterval<CqlQuantity>;
                            if (ds_)
                            {
                                DataType dt_ = FirstBladderCancerStaging?.Performed;
                                object du_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dt_);
                                bk_ = du_ as CqlInterval<CqlQuantity>;
                            }
                            else
                            {
                                bk_ = null;
                            }
                        }
                    }
                }
                CqlInterval<CqlDateTime> bl_ = QICoreCommon_4_0_000.Instance.toInterval(context, bk_);
                CqlDateTime bm_ = context.Operators.Start(bl_);
                CqlInterval<CqlDateTime> bn_ = context.Operators.Interval(bj_, bm_, true, false);
                bool? bo_ = context.Operators.In<CqlDateTime>(be_, bn_, (string)default);
                object bp_;
                DataType dv_ = FirstBladderCancerStaging?.Performed;
                object dw_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dv_);
                bool dx_ = dw_ is CqlDateTime;
                if (dx_)
                {
                    DataType dy_ = FirstBladderCancerStaging?.Performed;
                    object dz_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dy_);
                    bp_ = dz_ as CqlDateTime;
                }
                else
                {
                    DataType ea_ = FirstBladderCancerStaging?.Performed;
                    object eb_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ea_);
                    bool ec_ = eb_ is CqlQuantity;
                    if (ec_)
                    {
                        DataType ed_ = FirstBladderCancerStaging?.Performed;
                        object ee_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ed_);
                        bp_ = ee_ as CqlQuantity;
                    }
                    else
                    {
                        DataType ef_ = FirstBladderCancerStaging?.Performed;
                        object eg_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ef_);
                        bool eh_ = eg_ is CqlInterval<CqlDateTime>;
                        if (eh_)
                        {
                            DataType ei_ = FirstBladderCancerStaging?.Performed;
                            object ej_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ei_);
                            bp_ = ej_ as CqlInterval<CqlDateTime>;
                        }
                        else
                        {
                            DataType ek_ = FirstBladderCancerStaging?.Performed;
                            object el_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ek_);
                            bool em_ = el_ is CqlInterval<CqlQuantity>;
                            if (em_)
                            {
                                DataType en_ = FirstBladderCancerStaging?.Performed;
                                object eo_ = FHIRHelpers_4_4_000.Instance.ToValue(context, en_);
                                bp_ = eo_ as CqlInterval<CqlQuantity>;
                            }
                            else
                            {
                                bp_ = null;
                            }
                        }
                    }
                }
                CqlInterval<CqlDateTime> bq_ = QICoreCommon_4_0_000.Instance.toInterval(context, bp_);
                CqlDateTime br_ = context.Operators.Start(bq_);
                bool? bs_ = context.Operators.Not((bool?)(br_ is null));
                bool? bt_ = context.Operators.And(bo_, bs_);
                return bt_;
            }

            bool? an_ = context.Operators.WhereAny<Procedure>((IEnumerable<Procedure>)al_, am_);
            return an_;
        }

        IEnumerable<MedicationRequest> h_ = context.Operators.Where<MedicationRequest>(f_, g_);

        bool? i_(MedicationRequest ExclusionMed) {
            Code<MedicationRequest.MedicationrequestStatus> ep_ = ExclusionMed?.StatusElement;
            MedicationRequest.MedicationrequestStatus? eq_ = ep_?.Value;
            string er_ = context.Operators.Convert<string>(eq_);
            string[] es_ = [
                "active",
                "completed",
            ];
            bool? et_ = context.Operators.In<string>(er_, (IEnumerable<string>)es_);
            Code<MedicationRequest.MedicationRequestIntent> eu_ = ExclusionMed?.IntentElement;
            MedicationRequest.MedicationRequestIntent? ev_ = eu_?.Value;
            string ew_ = context.Operators.Convert<string>(ev_);
            bool? ex_ = context.Operators.Equal(ew_, "order");
            bool? ey_ = context.Operators.And(et_, ex_);
            return ey_;
        }

        IEnumerable<MedicationRequest> j_ = context.Operators.Where<MedicationRequest>(h_, i_);
        CqlCode k_ = this.Combined_radiotherapy__procedure_(context);
        IEnumerable<CqlCode> l_ = context.Operators.ToList<CqlCode>(k_);
        IEnumerable<Procedure> m_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, default, l_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));

        bool? n_(Procedure ExclusionProcedure) {
            Procedure ez_ = this.First_Bladder_Cancer_Staging_Procedure(context);
            Procedure[] fa_ = [
                ez_,
            ];

            bool? fb_(Procedure FirstBladderCancerStaging) {
                object fd_;
                DataType fv_ = ExclusionProcedure?.Performed;
                object fw_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fv_);
                bool fx_ = fw_ is CqlDateTime;
                if (fx_)
                {
                    DataType fy_ = ExclusionProcedure?.Performed;
                    object fz_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fy_);
                    fd_ = fz_ as CqlDateTime;
                }
                else
                {
                    DataType ga_ = ExclusionProcedure?.Performed;
                    object gb_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ga_);
                    bool gc_ = gb_ is CqlQuantity;
                    if (gc_)
                    {
                        DataType gd_ = ExclusionProcedure?.Performed;
                        object ge_ = FHIRHelpers_4_4_000.Instance.ToValue(context, gd_);
                        fd_ = ge_ as CqlQuantity;
                    }
                    else
                    {
                        DataType gf_ = ExclusionProcedure?.Performed;
                        object gg_ = FHIRHelpers_4_4_000.Instance.ToValue(context, gf_);
                        bool gh_ = gg_ is CqlInterval<CqlDateTime>;
                        if (gh_)
                        {
                            DataType gi_ = ExclusionProcedure?.Performed;
                            object gj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, gi_);
                            fd_ = gj_ as CqlInterval<CqlDateTime>;
                        }
                        else
                        {
                            DataType gk_ = ExclusionProcedure?.Performed;
                            object gl_ = FHIRHelpers_4_4_000.Instance.ToValue(context, gk_);
                            bool gm_ = gl_ is CqlInterval<CqlQuantity>;
                            if (gm_)
                            {
                                DataType gn_ = ExclusionProcedure?.Performed;
                                object go_ = FHIRHelpers_4_4_000.Instance.ToValue(context, gn_);
                                fd_ = go_ as CqlInterval<CqlQuantity>;
                            }
                            else
                            {
                                fd_ = null;
                            }
                        }
                    }
                }
                CqlInterval<CqlDateTime> fe_ = QICoreCommon_4_0_000.Instance.toInterval(context, fd_);
                CqlDateTime ff_ = context.Operators.Start(fe_);
                object fg_;
                DataType gp_ = FirstBladderCancerStaging?.Performed;
                object gq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, gp_);
                bool gr_ = gq_ is CqlDateTime;
                if (gr_)
                {
                    DataType gs_ = FirstBladderCancerStaging?.Performed;
                    object gt_ = FHIRHelpers_4_4_000.Instance.ToValue(context, gs_);
                    fg_ = gt_ as CqlDateTime;
                }
                else
                {
                    DataType gu_ = FirstBladderCancerStaging?.Performed;
                    object gv_ = FHIRHelpers_4_4_000.Instance.ToValue(context, gu_);
                    bool gw_ = gv_ is CqlQuantity;
                    if (gw_)
                    {
                        DataType gx_ = FirstBladderCancerStaging?.Performed;
                        object gy_ = FHIRHelpers_4_4_000.Instance.ToValue(context, gx_);
                        fg_ = gy_ as CqlQuantity;
                    }
                    else
                    {
                        DataType gz_ = FirstBladderCancerStaging?.Performed;
                        object ha_ = FHIRHelpers_4_4_000.Instance.ToValue(context, gz_);
                        bool hb_ = ha_ is CqlInterval<CqlDateTime>;
                        if (hb_)
                        {
                            DataType hc_ = FirstBladderCancerStaging?.Performed;
                            object hd_ = FHIRHelpers_4_4_000.Instance.ToValue(context, hc_);
                            fg_ = hd_ as CqlInterval<CqlDateTime>;
                        }
                        else
                        {
                            DataType he_ = FirstBladderCancerStaging?.Performed;
                            object hf_ = FHIRHelpers_4_4_000.Instance.ToValue(context, he_);
                            bool hg_ = hf_ is CqlInterval<CqlQuantity>;
                            if (hg_)
                            {
                                DataType hh_ = FirstBladderCancerStaging?.Performed;
                                object hi_ = FHIRHelpers_4_4_000.Instance.ToValue(context, hh_);
                                fg_ = hi_ as CqlInterval<CqlQuantity>;
                            }
                            else
                            {
                                fg_ = null;
                            }
                        }
                    }
                }
                CqlInterval<CqlDateTime> fh_ = QICoreCommon_4_0_000.Instance.toInterval(context, fg_);
                CqlDateTime fi_ = context.Operators.Start(fh_);
                CqlQuantity fj_ = context.Operators.Quantity(6m, "months");
                CqlDateTime fk_ = context.Operators.Subtract(fi_, fj_);
                object fl_;
                DataType hj_ = FirstBladderCancerStaging?.Performed;
                object hk_ = FHIRHelpers_4_4_000.Instance.ToValue(context, hj_);
                bool hl_ = hk_ is CqlDateTime;
                if (hl_)
                {
                    DataType hm_ = FirstBladderCancerStaging?.Performed;
                    object hn_ = FHIRHelpers_4_4_000.Instance.ToValue(context, hm_);
                    fl_ = hn_ as CqlDateTime;
                }
                else
                {
                    DataType ho_ = FirstBladderCancerStaging?.Performed;
                    object hp_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ho_);
                    bool hq_ = hp_ is CqlQuantity;
                    if (hq_)
                    {
                        DataType hr_ = FirstBladderCancerStaging?.Performed;
                        object hs_ = FHIRHelpers_4_4_000.Instance.ToValue(context, hr_);
                        fl_ = hs_ as CqlQuantity;
                    }
                    else
                    {
                        DataType ht_ = FirstBladderCancerStaging?.Performed;
                        object hu_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ht_);
                        bool hv_ = hu_ is CqlInterval<CqlDateTime>;
                        if (hv_)
                        {
                            DataType hw_ = FirstBladderCancerStaging?.Performed;
                            object hx_ = FHIRHelpers_4_4_000.Instance.ToValue(context, hw_);
                            fl_ = hx_ as CqlInterval<CqlDateTime>;
                        }
                        else
                        {
                            DataType hy_ = FirstBladderCancerStaging?.Performed;
                            object hz_ = FHIRHelpers_4_4_000.Instance.ToValue(context, hy_);
                            bool ia_ = hz_ is CqlInterval<CqlQuantity>;
                            if (ia_)
                            {
                                DataType ib_ = FirstBladderCancerStaging?.Performed;
                                object ic_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ib_);
                                fl_ = ic_ as CqlInterval<CqlQuantity>;
                            }
                            else
                            {
                                fl_ = null;
                            }
                        }
                    }
                }
                CqlInterval<CqlDateTime> fm_ = QICoreCommon_4_0_000.Instance.toInterval(context, fl_);
                CqlDateTime fn_ = context.Operators.Start(fm_);
                CqlInterval<CqlDateTime> fo_ = context.Operators.Interval(fk_, fn_, true, false);
                bool? fp_ = context.Operators.In<CqlDateTime>(ff_, fo_, (string)default);
                object fq_;
                DataType id_ = FirstBladderCancerStaging?.Performed;
                object ie_ = FHIRHelpers_4_4_000.Instance.ToValue(context, id_);
                bool if_ = ie_ is CqlDateTime;
                if (if_)
                {
                    DataType ig_ = FirstBladderCancerStaging?.Performed;
                    object ih_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ig_);
                    fq_ = ih_ as CqlDateTime;
                }
                else
                {
                    DataType ii_ = FirstBladderCancerStaging?.Performed;
                    object ij_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ii_);
                    bool ik_ = ij_ is CqlQuantity;
                    if (ik_)
                    {
                        DataType il_ = FirstBladderCancerStaging?.Performed;
                        object im_ = FHIRHelpers_4_4_000.Instance.ToValue(context, il_);
                        fq_ = im_ as CqlQuantity;
                    }
                    else
                    {
                        DataType in_ = FirstBladderCancerStaging?.Performed;
                        object io_ = FHIRHelpers_4_4_000.Instance.ToValue(context, in_);
                        bool ip_ = io_ is CqlInterval<CqlDateTime>;
                        if (ip_)
                        {
                            DataType iq_ = FirstBladderCancerStaging?.Performed;
                            object ir_ = FHIRHelpers_4_4_000.Instance.ToValue(context, iq_);
                            fq_ = ir_ as CqlInterval<CqlDateTime>;
                        }
                        else
                        {
                            DataType is_ = FirstBladderCancerStaging?.Performed;
                            object it_ = FHIRHelpers_4_4_000.Instance.ToValue(context, is_);
                            bool iu_ = it_ is CqlInterval<CqlQuantity>;
                            if (iu_)
                            {
                                DataType iv_ = FirstBladderCancerStaging?.Performed;
                                object iw_ = FHIRHelpers_4_4_000.Instance.ToValue(context, iv_);
                                fq_ = iw_ as CqlInterval<CqlQuantity>;
                            }
                            else
                            {
                                fq_ = null;
                            }
                        }
                    }
                }
                CqlInterval<CqlDateTime> fr_ = QICoreCommon_4_0_000.Instance.toInterval(context, fq_);
                CqlDateTime fs_ = context.Operators.Start(fr_);
                bool? ft_ = context.Operators.Not((bool?)(fs_ is null));
                bool? fu_ = context.Operators.And(fp_, ft_);
                return fu_;
            }

            bool? fc_ = context.Operators.WhereAny<Procedure>((IEnumerable<Procedure>)fa_, fb_);
            return fc_;
        }

        IEnumerable<Procedure> o_ = context.Operators.Where<Procedure>(m_, n_);

        bool? p_(Procedure ExclusionProcedure) {
            Code<EventStatus> ix_ = ExclusionProcedure?.StatusElement;
            EventStatus? iy_ = ix_?.Value;
            string iz_ = context.Operators.Convert<string>(iy_);
            string[] ja_ = [
                "completed",
                "in-progress",
            ];
            bool? jb_ = context.Operators.In<string>(iz_, (IEnumerable<string>)ja_);
            return jb_;
        }

        IEnumerable<Procedure> q_ = context.Operators.Where<Procedure>(o_, p_);
        IEnumerable<object> r_ = context.Operators.Union<object>(j_ as IEnumerable<object>, q_ as IEnumerable<object>);
        bool? s_ = context.Operators.Exists<object>(r_);
        return s_;
    }


    [CqlExpressionDefinition("Denominator Exclusion")]
    public bool? Denominator_Exclusion(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Denominator_Exclusion, Denominator_Exclusion_Compute);

    private const long _cacheIndex_Denominator_Exclusion = -2497759738663303621L;

    private bool? Denominator_Exclusion_Compute(CqlContext context)
    {
        IEnumerable<Condition> a_ = this.Acute_Tuberculosis_Diagnosis(context);
        bool? b_ = context.Operators.Exists<Condition>(a_);
        IEnumerable<MedicationRequest> c_ = this.Immunosuppressive_Drugs(context);
        bool? d_ = context.Operators.Exists<MedicationRequest>(c_);
        bool? e_ = context.Operators.Or(b_, d_);
        IEnumerable<Procedure> f_ = this.Cystectomy_Done(context);
        bool? g_ = context.Operators.Exists<Procedure>(f_);
        bool? h_ = context.Operators.Or(e_, g_);
        bool? i_ = this.Has_Excluding_HIV__Immunocompromised_Conditions_or_Mixed_Histology_Before_Staging(context);
        bool? j_ = context.Operators.Or(h_, i_);
        bool? k_ = this.Has_Excluding_Chemotherapy_or_Radiotherapy_Procedure_Before_Staging(context);
        bool? l_ = context.Operators.Or(j_, k_);
        return l_;
    }


    [CqlExpressionDefinition("BCG Not Available Within 6 Months After Bladder Cancer Staging")]
    public IEnumerable<MedicationAdministration> BCG_Not_Available_Within_6_Months_After_Bladder_Cancer_Staging(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_BCG_Not_Available_Within_6_Months_After_Bladder_Cancer_Staging, BCG_Not_Available_Within_6_Months_After_Bladder_Cancer_Staging_Compute);

    private const long _cacheIndex_BCG_Not_Available_Within_6_Months_After_Bladder_Cancer_Staging = -4719968472254698824L;

    private IEnumerable<MedicationAdministration> BCG_Not_Available_Within_6_Months_After_Bladder_Cancer_Staging_Compute(CqlContext context)
    {
        CqlValueSet a_ = this.Bacillus_Calmette_Guerin_for_Urology_Care(context);
        IEnumerable<MedicationAdministration> b_ = context.Operators.Retrieve<MedicationAdministration>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationadministrationnotdone"));
        IEnumerable<MedicationAdministration> c_ = context.Operators.Union<MedicationAdministration>(b_, b_);

        bool? d_(MedicationAdministration BCGNotGiven) {
            Procedure h_ = this.First_Bladder_Cancer_Staging_Procedure(context);
            Procedure[] i_ = [
                h_,
            ];

            bool? j_(Procedure FirstBladderCancerStaging) {
                List<Extension> l_ = BCGNotGiven?.Extension;

                bool? m_(Extension @this) {
                    FhirUri af_ = @this?.UrlElement;
                    string ag_ = FHIRHelpers_4_4_000.Instance.ToString(context, af_);
                    bool? ah_ = context.Operators.Equal(ag_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-recorded");
                    return ah_;
                }


                object n_(Extension @this) {
                    DataType ai_ = @this?.Value;
                    return ai_ switch
                    {
                        Uuid aj_ => aj_.Value,
                        Oid ak_ => ak_.Value,
                        Markdown al_ => al_.Value,
                        Integer am_ => am_.Value,
                        Instant an_ => context.Operators.Convert<CqlDateTime>(an_.Value),
                        Id ao_ => ao_.Value,
                        Duration ap_ => ap_.ValueElement,
                        Distance aq_ => aq_.ValueElement,
                        FhirDecimal ar_ => ar_.Value,
                        Date as_ => context.Operators.ConvertStringToDate(as_.Value),
                        Count at_ => at_.ValueElement,
                        FhirDateTime au_ => context.Operators.Convert<CqlDateTime>(au_),
                        Time av_ => context.Operators.ConvertStringToTime(av_.Value),
                        Age aw_ => aw_.ValueElement,
                        FhirUrl ax_ => ax_.Value,
                        FhirUri ay_ => ay_.Value,
                        Base64Binary az_ => context.Operators.Convert<string>(az_.Value),
                        FhirBoolean ba_ => ba_.Value,
                        FhirString bb_ => bb_.Value,
                        PositiveInt bc_ => bc_.Value,
                        Code bd_ => bd_.Value,
                        UnsignedInt be_ => be_.Value,
                        Canonical bf_ => bf_.Value,
                        Quantity bg_ => bg_.ValueElement,
                        Identifier bh_ => bh_.ValueElement,
                        Money bi_ => bi_.ValueElement,
                        UsageContext bj_ => bj_.Value,
                        ContactPoint bk_ => bk_.ValueElement,
                        _ => null,
                    };
                }

                IEnumerable<object> o_ = context.Operators.WhereSelect<Extension, object>((IEnumerable<Extension>)l_, m_, n_);
                object p_ = context.Operators.SingletonFrom<object>(o_);
                object q_;
                DataType bl_ = FirstBladderCancerStaging?.Performed;
                object bm_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bl_);
                bool bn_ = bm_ is CqlDateTime;
                if (bn_)
                {
                    DataType bo_ = FirstBladderCancerStaging?.Performed;
                    object bp_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bo_);
                    q_ = bp_ as CqlDateTime;
                }
                else
                {
                    DataType bq_ = FirstBladderCancerStaging?.Performed;
                    object br_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bq_);
                    bool bs_ = br_ is CqlQuantity;
                    if (bs_)
                    {
                        DataType bt_ = FirstBladderCancerStaging?.Performed;
                        object bu_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bt_);
                        q_ = bu_ as CqlQuantity;
                    }
                    else
                    {
                        DataType bv_ = FirstBladderCancerStaging?.Performed;
                        object bw_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bv_);
                        bool bx_ = bw_ is CqlInterval<CqlDateTime>;
                        if (bx_)
                        {
                            DataType by_ = FirstBladderCancerStaging?.Performed;
                            object bz_ = FHIRHelpers_4_4_000.Instance.ToValue(context, by_);
                            q_ = bz_ as CqlInterval<CqlDateTime>;
                        }
                        else
                        {
                            DataType ca_ = FirstBladderCancerStaging?.Performed;
                            object cb_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ca_);
                            bool cc_ = cb_ is CqlInterval<CqlQuantity>;
                            if (cc_)
                            {
                                DataType cd_ = FirstBladderCancerStaging?.Performed;
                                object ce_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cd_);
                                q_ = ce_ as CqlInterval<CqlQuantity>;
                            }
                            else
                            {
                                q_ = null;
                            }
                        }
                    }
                }
                CqlInterval<CqlDateTime> r_ = QICoreCommon_4_0_000.Instance.toInterval(context, q_);
                CqlDateTime s_ = context.Operators.Start(r_);
                object t_;
                DataType cf_ = FirstBladderCancerStaging?.Performed;
                object cg_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cf_);
                bool ch_ = cg_ is CqlDateTime;
                if (ch_)
                {
                    DataType ci_ = FirstBladderCancerStaging?.Performed;
                    object cj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ci_);
                    t_ = cj_ as CqlDateTime;
                }
                else
                {
                    DataType ck_ = FirstBladderCancerStaging?.Performed;
                    object cl_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ck_);
                    bool cm_ = cl_ is CqlQuantity;
                    if (cm_)
                    {
                        DataType cn_ = FirstBladderCancerStaging?.Performed;
                        object co_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cn_);
                        t_ = co_ as CqlQuantity;
                    }
                    else
                    {
                        DataType cp_ = FirstBladderCancerStaging?.Performed;
                        object cq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cp_);
                        bool cr_ = cq_ is CqlInterval<CqlDateTime>;
                        if (cr_)
                        {
                            DataType cs_ = FirstBladderCancerStaging?.Performed;
                            object ct_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cs_);
                            t_ = ct_ as CqlInterval<CqlDateTime>;
                        }
                        else
                        {
                            DataType cu_ = FirstBladderCancerStaging?.Performed;
                            object cv_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cu_);
                            bool cw_ = cv_ is CqlInterval<CqlQuantity>;
                            if (cw_)
                            {
                                DataType cx_ = FirstBladderCancerStaging?.Performed;
                                object cy_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cx_);
                                t_ = cy_ as CqlInterval<CqlQuantity>;
                            }
                            else
                            {
                                t_ = null;
                            }
                        }
                    }
                }
                CqlInterval<CqlDateTime> u_ = QICoreCommon_4_0_000.Instance.toInterval(context, t_);
                CqlDateTime v_ = context.Operators.Start(u_);
                CqlQuantity w_ = context.Operators.Quantity(6m, "months");
                CqlDateTime x_ = context.Operators.Add(v_, w_);
                CqlInterval<CqlDateTime> y_ = context.Operators.Interval(s_, x_, false, true);
                bool? z_ = context.Operators.In<CqlDateTime>((CqlDateTime)p_, y_, "day");
                object aa_;
                DataType cz_ = FirstBladderCancerStaging?.Performed;
                object da_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cz_);
                bool db_ = da_ is CqlDateTime;
                if (db_)
                {
                    DataType dc_ = FirstBladderCancerStaging?.Performed;
                    object dd_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dc_);
                    aa_ = dd_ as CqlDateTime;
                }
                else
                {
                    DataType de_ = FirstBladderCancerStaging?.Performed;
                    object df_ = FHIRHelpers_4_4_000.Instance.ToValue(context, de_);
                    bool dg_ = df_ is CqlQuantity;
                    if (dg_)
                    {
                        DataType dh_ = FirstBladderCancerStaging?.Performed;
                        object di_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dh_);
                        aa_ = di_ as CqlQuantity;
                    }
                    else
                    {
                        DataType dj_ = FirstBladderCancerStaging?.Performed;
                        object dk_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dj_);
                        bool dl_ = dk_ is CqlInterval<CqlDateTime>;
                        if (dl_)
                        {
                            DataType dm_ = FirstBladderCancerStaging?.Performed;
                            object dn_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dm_);
                            aa_ = dn_ as CqlInterval<CqlDateTime>;
                        }
                        else
                        {
                            DataType do_ = FirstBladderCancerStaging?.Performed;
                            object dp_ = FHIRHelpers_4_4_000.Instance.ToValue(context, do_);
                            bool dq_ = dp_ is CqlInterval<CqlQuantity>;
                            if (dq_)
                            {
                                DataType dr_ = FirstBladderCancerStaging?.Performed;
                                object ds_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dr_);
                                aa_ = ds_ as CqlInterval<CqlQuantity>;
                            }
                            else
                            {
                                aa_ = null;
                            }
                        }
                    }
                }
                CqlInterval<CqlDateTime> ab_ = QICoreCommon_4_0_000.Instance.toInterval(context, aa_);
                CqlDateTime ac_ = context.Operators.Start(ab_);
                bool? ad_ = context.Operators.Not((bool?)(ac_ is null));
                bool? ae_ = context.Operators.And(z_, ad_);
                return ae_;
            }

            bool? k_ = context.Operators.WhereAny<Procedure>((IEnumerable<Procedure>)i_, j_);
            return k_;
        }

        IEnumerable<MedicationAdministration> e_ = context.Operators.Where<MedicationAdministration>(c_, d_);

        bool? f_(MedicationAdministration BCGNotGiven) {
            List<CodeableConcept> dt_ = BCGNotGiven?.StatusReason;

            CqlConcept du_(CodeableConcept @this) {
                CqlConcept dy_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);
                return dy_;
            }

            IEnumerable<CqlConcept> dv_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)dt_, du_);
            CqlValueSet dw_ = this.Unavailability_of_Bacillus_Calmette_Guerin_for_Urology_Care(context);
            bool? dx_ = context.Operators.ConceptsInValueSet(dv_, dw_);
            return dx_;
        }

        IEnumerable<MedicationAdministration> g_ = context.Operators.Where<MedicationAdministration>(e_, f_);
        return g_;
    }


    [CqlExpressionDefinition("Denominator Exception")]
    public bool? Denominator_Exception(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Denominator_Exception, Denominator_Exception_Compute);

    private const long _cacheIndex_Denominator_Exception = -8232522769382720446L;

    private bool? Denominator_Exception_Compute(CqlContext context)
    {
        IEnumerable<MedicationAdministration> a_ = this.BCG_Not_Available_Within_6_Months_After_Bladder_Cancer_Staging(context);
        bool? b_ = context.Operators.Exists<MedicationAdministration>(a_);
        return b_;
    }


    [CqlExpressionDefinition("First BCG Administered")]
    public MedicationAdministration First_BCG_Administered(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_First_BCG_Administered, First_BCG_Administered_Compute);

    private const long _cacheIndex_First_BCG_Administered = 5246817831198828715L;

    private MedicationAdministration First_BCG_Administered_Compute(CqlContext context)
    {
        IEnumerable<MedicationAdministration> a_ = context.Operators.Retrieve<MedicationAdministration>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationadministration"));

        bool? b_(MedicationAdministration MR) {
            IEnumerable<Medication> n_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));

            bool? o_(Medication M) {
                Id q_ = M?.IdElement;
                string r_ = q_?.Value;
                DataType s_ = MR?.Medication;
                FhirString u_ = s_ is ResourceReference t_ ? t_.ReferenceElement : null;
                string v_ = u_?.Value;
                IEnumerable<string> w_ = context.Operators.Split(v_, "/");
                string x_ = context.Operators.Last<string>(w_);
                bool? y_ = context.Operators.Equal(r_, x_);
                CodeableConcept z_ = M?.Code;
                CqlConcept aa_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, z_);
                CqlValueSet ab_ = this.Bacillus_Calmette_Guerin_for_Urology_Care(context);
                bool? ac_ = context.Operators.ConceptInValueSet(aa_, ab_);
                bool? ad_ = context.Operators.And(y_, ac_);
                return ad_;
            }

            bool? p_ = context.Operators.WhereAny<Medication>(n_, o_);
            return p_;
        }

        IEnumerable<MedicationAdministration> c_ = context.Operators.Where<MedicationAdministration>(a_, b_);
        CqlValueSet d_ = this.Bacillus_Calmette_Guerin_for_Urology_Care(context);
        IEnumerable<MedicationAdministration> e_ = context.Operators.Retrieve<MedicationAdministration>(new RetrieveParameters(default, d_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationadministration"));
        IEnumerable<MedicationAdministration> f_ = context.Operators.Union<MedicationAdministration>(c_, e_);

        bool? g_(MedicationAdministration BCG) {
            Procedure ae_ = this.First_Bladder_Cancer_Staging_Procedure(context);
            Procedure[] af_ = [
                ae_,
            ];

            bool? ag_(Procedure FirstBladderCancerStaging) {
                DataType ai_ = BCG?.Effective;
                object aj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ai_);
                CqlInterval<CqlDateTime> ak_ = QICoreCommon_4_0_000.Instance.toInterval(context, aj_);
                CqlDateTime al_ = context.Operators.Start(ak_);
                object am_;
                DataType be_ = FirstBladderCancerStaging?.Performed;
                object bf_ = FHIRHelpers_4_4_000.Instance.ToValue(context, be_);
                bool bg_ = bf_ is CqlDateTime;
                if (bg_)
                {
                    DataType bh_ = FirstBladderCancerStaging?.Performed;
                    object bi_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bh_);
                    am_ = bi_ as CqlDateTime;
                }
                else
                {
                    DataType bj_ = FirstBladderCancerStaging?.Performed;
                    object bk_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bj_);
                    bool bl_ = bk_ is CqlQuantity;
                    if (bl_)
                    {
                        DataType bm_ = FirstBladderCancerStaging?.Performed;
                        object bn_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bm_);
                        am_ = bn_ as CqlQuantity;
                    }
                    else
                    {
                        DataType bo_ = FirstBladderCancerStaging?.Performed;
                        object bp_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bo_);
                        bool bq_ = bp_ is CqlInterval<CqlDateTime>;
                        if (bq_)
                        {
                            DataType br_ = FirstBladderCancerStaging?.Performed;
                            object bs_ = FHIRHelpers_4_4_000.Instance.ToValue(context, br_);
                            am_ = bs_ as CqlInterval<CqlDateTime>;
                        }
                        else
                        {
                            DataType bt_ = FirstBladderCancerStaging?.Performed;
                            object bu_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bt_);
                            bool bv_ = bu_ is CqlInterval<CqlQuantity>;
                            if (bv_)
                            {
                                DataType bw_ = FirstBladderCancerStaging?.Performed;
                                object bx_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bw_);
                                am_ = bx_ as CqlInterval<CqlQuantity>;
                            }
                            else
                            {
                                am_ = null;
                            }
                        }
                    }
                }
                CqlInterval<CqlDateTime> an_ = QICoreCommon_4_0_000.Instance.toInterval(context, am_);
                CqlDateTime ao_ = context.Operators.Start(an_);
                object ap_;
                DataType by_ = FirstBladderCancerStaging?.Performed;
                object bz_ = FHIRHelpers_4_4_000.Instance.ToValue(context, by_);
                bool ca_ = bz_ is CqlDateTime;
                if (ca_)
                {
                    DataType cb_ = FirstBladderCancerStaging?.Performed;
                    object cc_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cb_);
                    ap_ = cc_ as CqlDateTime;
                }
                else
                {
                    DataType cd_ = FirstBladderCancerStaging?.Performed;
                    object ce_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cd_);
                    bool cf_ = ce_ is CqlQuantity;
                    if (cf_)
                    {
                        DataType cg_ = FirstBladderCancerStaging?.Performed;
                        object ch_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cg_);
                        ap_ = ch_ as CqlQuantity;
                    }
                    else
                    {
                        DataType ci_ = FirstBladderCancerStaging?.Performed;
                        object cj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ci_);
                        bool ck_ = cj_ is CqlInterval<CqlDateTime>;
                        if (ck_)
                        {
                            DataType cl_ = FirstBladderCancerStaging?.Performed;
                            object cm_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cl_);
                            ap_ = cm_ as CqlInterval<CqlDateTime>;
                        }
                        else
                        {
                            DataType cn_ = FirstBladderCancerStaging?.Performed;
                            object co_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cn_);
                            bool cp_ = co_ is CqlInterval<CqlQuantity>;
                            if (cp_)
                            {
                                DataType cq_ = FirstBladderCancerStaging?.Performed;
                                object cr_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cq_);
                                ap_ = cr_ as CqlInterval<CqlQuantity>;
                            }
                            else
                            {
                                ap_ = null;
                            }
                        }
                    }
                }
                CqlInterval<CqlDateTime> aq_ = QICoreCommon_4_0_000.Instance.toInterval(context, ap_);
                CqlDateTime ar_ = context.Operators.Start(aq_);
                CqlQuantity as_ = context.Operators.Quantity(6m, "months");
                CqlDateTime at_ = context.Operators.Add(ar_, as_);
                CqlInterval<CqlDateTime> au_ = context.Operators.Interval(ao_, at_, false, true);
                bool? av_ = context.Operators.In<CqlDateTime>(al_, au_, "day");
                object aw_;
                DataType cs_ = FirstBladderCancerStaging?.Performed;
                object ct_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cs_);
                bool cu_ = ct_ is CqlDateTime;
                if (cu_)
                {
                    DataType cv_ = FirstBladderCancerStaging?.Performed;
                    object cw_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cv_);
                    aw_ = cw_ as CqlDateTime;
                }
                else
                {
                    DataType cx_ = FirstBladderCancerStaging?.Performed;
                    object cy_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cx_);
                    bool cz_ = cy_ is CqlQuantity;
                    if (cz_)
                    {
                        DataType da_ = FirstBladderCancerStaging?.Performed;
                        object db_ = FHIRHelpers_4_4_000.Instance.ToValue(context, da_);
                        aw_ = db_ as CqlQuantity;
                    }
                    else
                    {
                        DataType dc_ = FirstBladderCancerStaging?.Performed;
                        object dd_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dc_);
                        bool de_ = dd_ is CqlInterval<CqlDateTime>;
                        if (de_)
                        {
                            DataType df_ = FirstBladderCancerStaging?.Performed;
                            object dg_ = FHIRHelpers_4_4_000.Instance.ToValue(context, df_);
                            aw_ = dg_ as CqlInterval<CqlDateTime>;
                        }
                        else
                        {
                            DataType dh_ = FirstBladderCancerStaging?.Performed;
                            object di_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dh_);
                            bool dj_ = di_ is CqlInterval<CqlQuantity>;
                            if (dj_)
                            {
                                DataType dk_ = FirstBladderCancerStaging?.Performed;
                                object dl_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dk_);
                                aw_ = dl_ as CqlInterval<CqlQuantity>;
                            }
                            else
                            {
                                aw_ = null;
                            }
                        }
                    }
                }
                CqlInterval<CqlDateTime> ax_ = QICoreCommon_4_0_000.Instance.toInterval(context, aw_);
                CqlDateTime ay_ = context.Operators.Start(ax_);
                bool? az_ = context.Operators.Not((bool?)(ay_ is null));
                bool? ba_ = context.Operators.And(av_, az_);
                CqlInterval<CqlDateTime> bb_ = this.Measurement_Period(context);
                bool? bc_ = context.Operators.In<CqlDateTime>(al_, bb_, "day");
                bool? bd_ = context.Operators.And(ba_, bc_);
                return bd_;
            }

            bool? ah_ = context.Operators.WhereAny<Procedure>((IEnumerable<Procedure>)af_, ag_);
            return ah_;
        }

        IEnumerable<MedicationAdministration> h_ = context.Operators.Where<MedicationAdministration>(f_, g_);

        bool? i_(MedicationAdministration BCG) {
            Code<MedicationAdministration.MedicationAdministrationStatusCodes> dm_ = BCG?.StatusElement;
            MedicationAdministration.MedicationAdministrationStatusCodes? dn_ = dm_?.Value;
            string do_ = context.Operators.Convert<string>(dn_);
            string[] dp_ = [
                "in-progress",
                "completed",
            ];
            bool? dq_ = context.Operators.In<string>(do_, (IEnumerable<string>)dp_);
            return dq_;
        }

        IEnumerable<MedicationAdministration> j_ = context.Operators.Where<MedicationAdministration>(h_, i_);

        object k_(MedicationAdministration @this) {
            DataType dr_ = @this?.Effective;
            object ds_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dr_);
            CqlInterval<CqlDateTime> dt_ = QICoreCommon_4_0_000.Instance.toInterval(context, ds_);
            CqlDateTime du_ = context.Operators.Start(dt_);
            return du_;
        }

        IEnumerable<MedicationAdministration> l_ = context.Operators.SortBy<MedicationAdministration>(j_, k_, System.ComponentModel.ListSortDirection.Ascending);
        MedicationAdministration m_ = context.Operators.First<MedicationAdministration>(l_);
        return m_;
    }


    [CqlExpressionDefinition("Numerator")]
    public bool? Numerator(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Numerator, Numerator_Compute);

    private const long _cacheIndex_Numerator = -5650740766836730728L;

    private bool? Numerator_Compute(CqlContext context)
    {
        MedicationAdministration a_ = this.First_BCG_Administered(context);
        bool? b_ = context.Operators.Not((bool?)(a_ is null));
        return b_;
    }


    [CqlExpressionDefinition("SDE Ethnicity")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Ethnicity(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_SDE_Ethnicity, SDE_Ethnicity_Compute);

    private const long _cacheIndex_SDE_Ethnicity = -3031213782846199448L;

    private (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Ethnicity_Compute(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? a_ = SupplementalDataElements_5_1_000.Instance.SDE_Ethnicity(context);
        return a_;
    }


    [CqlExpressionDefinition("SDE Payer")]
    public IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> SDE_Payer(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_SDE_Payer, SDE_Payer_Compute);

    private const long _cacheIndex_SDE_Payer = -2765886446978909849L;

    private IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> SDE_Payer_Compute(CqlContext context)
    {
        IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> a_ = SupplementalDataElements_5_1_000.Instance.SDE_Payer(context);
        return a_;
    }


    [CqlExpressionDefinition("SDE Race")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Race(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_SDE_Race, SDE_Race_Compute);

    private const long _cacheIndex_SDE_Race = -2209043468229436943L;

    private (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Race_Compute(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? a_ = SupplementalDataElements_5_1_000.Instance.SDE_Race(context);
        return a_;
    }


    [CqlExpressionDefinition("SDE Sex")]
    public CqlCode SDE_Sex(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_SDE_Sex, SDE_Sex_Compute);

    private const long _cacheIndex_SDE_Sex = -4292175789313964661L;

    private CqlCode SDE_Sex_Compute(CqlContext context)
    {
        CqlCode a_ = SupplementalDataElements_5_1_000.Instance.SDE_Sex(context);
        return a_;
    }


    #endregion Functions and Expressions

    #region Singleton Lifetime Members

    private CMS646FHIRIntravesicalBCGTherapy_1_0_000() {}

    public static CMS646FHIRIntravesicalBCGTherapy_1_0_000 Instance { get; } = new();

    #endregion

    #region ILibrary Implementation

    public string Name => "CMS646FHIRIntravesicalBCGTherapy";
    public string Version => "1.0.000";
    public ILibrary[] Dependencies => [FHIRHelpers_4_4_000.Instance, SupplementalDataElements_5_1_000.Instance, QICoreCommon_4_0_000.Instance];

    #endregion ILibrary Implementation

}

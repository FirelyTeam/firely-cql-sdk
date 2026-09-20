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

[System.CodeDom.Compiler.GeneratedCode(".NET Code Generation", "5.2.3.0")]
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
                string n_ = (M is Resource
                    ? (M as Resource).IdElement
                    : default)?.Value;
                DataType o_ = MR?.Medication;
                object p_ = context.Operators.LateBoundProperty<object>(o_, "reference");
                object q_ = context.Operators.LateBoundProperty<object>(p_, "value");
                IEnumerable<string> r_ = context.Operators.Split((string)q_, "/");
                string s_ = context.Operators.Last<string>(r_);
                bool? t_ = context.Operators.Equal(n_, s_);
                CodeableConcept u_ = M?.Code;
                CqlConcept v_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, u_);
                CqlValueSet w_ = this.Immunosuppressive_Drugs_for_Urology_Care(context);
                bool? x_ = context.Operators.ConceptInValueSet(v_, w_);
                bool? y_ = context.Operators.And(t_, x_);
                return y_;
            }

            bool? m_ = context.Operators.WhereAny<Medication>(k_, l_);
            return m_;
        }

        IEnumerable<MedicationRequest> c_ = context.Operators.Where<MedicationRequest>(a_, b_);
        CqlValueSet d_ = this.Immunosuppressive_Drugs_for_Urology_Care(context);
        IEnumerable<MedicationRequest> e_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, d_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> f_ = context.Operators.Union<MedicationRequest>(c_, e_);

        bool? g_(MedicationRequest ImmunosuppressiveDrugs) {
            Procedure z_ = this.First_Bladder_Cancer_Staging_Procedure(context);
            Procedure[] aa_ = [
                z_,
            ];

            bool? ab_(Procedure FirstBladderCancerStaging) {
                List<Dosage> ad_ = ImmunosuppressiveDrugs?.DosageInstruction;

                bool? ae_(Dosage @this) {
                    Timing bg_ = @this?.Timing;
                    bool? bh_ = context.Operators.Not((bool?)(bg_ is null));
                    return bh_;
                }


                Timing af_(Dosage @this) {
                    Timing bi_ = @this?.Timing;
                    return bi_;
                }

                IEnumerable<Timing> ag_ = context.Operators.WhereSelect<Dosage, Timing>((IEnumerable<Dosage>)ad_, ae_, af_);

                CqlDateTime ah_(Timing dosageTiming) {
                    List<FhirDateTime> bj_ = dosageTiming?.EventElement;

                    string bk_(FhirDateTime @this) {
                        string bq_ = @this?.Value;
                        return bq_;
                    }

                    IEnumerable<string> bl_ = context.Operators.Select<FhirDateTime, string>((IEnumerable<FhirDateTime>)bj_, bk_);

                    CqlDateTime bm_(string @string) {
                        CqlDateTime br_ = context.Operators.ConvertStringToDateTime(@string);
                        return br_;
                    }

                    IEnumerable<CqlDateTime> bn_ = context.Operators.Select<string, CqlDateTime>(bl_, bm_);
                    IEnumerable<CqlDateTime> bo_ = context.Operators.ListSort<CqlDateTime>(bn_, System.ComponentModel.ListSortDirection.Ascending);
                    CqlDateTime bp_ = context.Operators.First<CqlDateTime>(bo_);
                    return bp_;
                }

                IEnumerable<CqlDateTime> ai_ = context.Operators.SelectDistinct<Timing, CqlDateTime>(ag_, ah_);
                IEnumerable<CqlDateTime> aj_ = context.Operators.ListSort<CqlDateTime>(ai_, System.ComponentModel.ListSortDirection.Ascending);
                CqlDateTime ak_ = context.Operators.First<CqlDateTime>(aj_);
                CqlInterval<CqlDateTime> al_ = QICoreCommon_4_0_000.Instance.toInterval(context, ak_);

                bool? am_(Dosage @this) {
                    Timing bs_ = @this?.Timing;
                    bool? bt_ = context.Operators.Not((bool?)(bs_ is null));
                    return bt_;
                }


                Timing an_(Dosage @this) {
                    Timing bu_ = @this?.Timing;
                    return bu_;
                }

                IEnumerable<Timing> ao_ = context.Operators.WhereSelect<Dosage, Timing>((IEnumerable<Dosage>)ad_, am_, an_);

                bool? ap_(Timing @this) {
                    Timing.RepeatComponent bv_ = @this?.Repeat;
                    bool? bw_ = context.Operators.Not((bool?)(bv_ is null));
                    return bw_;
                }


                Timing.RepeatComponent aq_(Timing @this) {
                    Timing.RepeatComponent bx_ = @this?.Repeat;
                    return bx_;
                }

                IEnumerable<Timing.RepeatComponent> ar_ = context.Operators.WhereSelect<Timing, Timing.RepeatComponent>(ao_, ap_, aq_);

                bool? as_(Timing.RepeatComponent @this) {
                    DataType by_ = @this?.Bounds;
                    object bz_ = FHIRHelpers_4_4_000.Instance.ToValue(context, by_);
                    bool? ca_ = context.Operators.Not((bool?)(bz_ is null));
                    return ca_;
                }


                object at_(Timing.RepeatComponent @this) {
                    DataType cb_ = @this?.Bounds;
                    object cc_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cb_);
                    return cc_;
                }

                IEnumerable<object> au_ = context.Operators.WhereSelect<Timing.RepeatComponent, object>(ar_, as_, at_);

                CqlInterval<CqlDateTime> av_(object DoseTime) {
                    CqlInterval<CqlDateTime> cd_ = QICoreCommon_4_0_000.Instance.toInterval(context, DoseTime);
                    return cd_;
                }

                IEnumerable<CqlInterval<CqlDateTime>> aw_ = context.Operators.SelectDistinct<object, CqlInterval<CqlDateTime>>(au_, av_);
                IEnumerable<CqlInterval<CqlDateTime>> ax_ = context.Operators.Collapse(aw_, (string)default);

                object ay_(CqlInterval<CqlDateTime> @this) {
                    CqlDateTime ce_ = context.Operators.Start(@this);
                    return ce_;
                }

                IEnumerable<CqlInterval<CqlDateTime>> az_ = context.Operators.SortBy<CqlInterval<CqlDateTime>>(ax_, ay_, System.ComponentModel.ListSortDirection.Ascending);
                CqlInterval<CqlDateTime> ba_ = context.Operators.First<CqlInterval<CqlDateTime>>(az_);
                CqlDateTime bb_ = context.Operators.Start(al_ ?? ba_);
                object bc_;
                DataType cf_ = FirstBladderCancerStaging?.Performed;
                object cg_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cf_);
                bool ch_ = cg_ is CqlDateTime;
                if (ch_)
                {
                    DataType ci_ = FirstBladderCancerStaging?.Performed;
                    object cj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ci_);
                    bc_ = cj_ as CqlDateTime;
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
                        bc_ = co_ as CqlQuantity;
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
                            bc_ = ct_ as CqlInterval<CqlDateTime>;
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
                                bc_ = cy_ as CqlInterval<CqlQuantity>;
                            }
                            else
                            {
                                bc_ = null;
                            }
                        }
                    }
                }
                CqlInterval<CqlDateTime> bd_ = QICoreCommon_4_0_000.Instance.toInterval(context, bc_);
                CqlDateTime be_ = context.Operators.Start(bd_);
                bool? bf_ = context.Operators.SameOrBefore(bb_, be_, "day");
                return bf_;
            }

            bool? ac_ = context.Operators.WhereAny<Procedure>((IEnumerable<Procedure>)aa_, ab_);
            return ac_;
        }

        IEnumerable<MedicationRequest> h_ = context.Operators.Where<MedicationRequest>(f_, g_);

        bool? i_(MedicationRequest ImmunosuppressiveDrugs) {
            Code<MedicationRequest.MedicationrequestStatus> cz_ = ImmunosuppressiveDrugs?.StatusElement;
            MedicationRequest.MedicationrequestStatus? da_ = cz_?.Value;
            string db_ = context.Operators.Convert<string>(da_);
            string[] dc_ = [
                "active",
                "completed",
            ];
            bool? dd_ = context.Operators.In<string>(db_, (IEnumerable<string>)dc_);
            Code<MedicationRequest.MedicationRequestIntent> de_ = ImmunosuppressiveDrugs?.IntentElement;
            MedicationRequest.MedicationRequestIntent? df_ = de_?.Value;
            string dg_ = context.Operators.Convert<string>(df_);
            bool? dh_ = context.Operators.Equal(dg_, "order");
            bool? di_ = context.Operators.And(dd_, dh_);
            return di_;
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
                string w_ = (M is Resource
                    ? (M as Resource).IdElement
                    : default)?.Value;
                DataType x_ = MR?.Medication;
                object y_ = context.Operators.LateBoundProperty<object>(x_, "reference");
                object z_ = context.Operators.LateBoundProperty<object>(y_, "value");
                IEnumerable<string> aa_ = context.Operators.Split((string)z_, "/");
                string ab_ = context.Operators.Last<string>(aa_);
                bool? ac_ = context.Operators.Equal(w_, ab_);
                CodeableConcept ad_ = M?.Code;
                CqlConcept ae_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, ad_);
                CqlValueSet af_ = this.Chemotherapy_Agents_for_Advanced_Cancer(context);
                bool? ag_ = context.Operators.ConceptInValueSet(ae_, af_);
                bool? ah_ = context.Operators.And(ac_, ag_);
                return ah_;
            }

            bool? v_ = context.Operators.WhereAny<Medication>(t_, u_);
            return v_;
        }

        IEnumerable<MedicationRequest> c_ = context.Operators.Where<MedicationRequest>(a_, b_);
        CqlValueSet d_ = this.Chemotherapy_Agents_for_Advanced_Cancer(context);
        IEnumerable<MedicationRequest> e_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, d_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> f_ = context.Operators.Union<MedicationRequest>(c_, e_);

        bool? g_(MedicationRequest ExclusionMed) {
            Procedure ai_ = this.First_Bladder_Cancer_Staging_Procedure(context);
            Procedure[] aj_ = [
                ai_,
            ];

            bool? ak_(Procedure FirstBladderCancerStaging) {
                List<Dosage> am_ = ExclusionMed?.DosageInstruction;

                bool? an_(Dosage @this) {
                    Timing bs_ = @this?.Timing;
                    bool? bt_ = context.Operators.Not((bool?)(bs_ is null));
                    return bt_;
                }


                Timing ao_(Dosage @this) {
                    Timing bu_ = @this?.Timing;
                    return bu_;
                }

                IEnumerable<Timing> ap_ = context.Operators.WhereSelect<Dosage, Timing>((IEnumerable<Dosage>)am_, an_, ao_);

                bool? aq_(Timing @this) {
                    Timing.RepeatComponent bv_ = @this?.Repeat;
                    bool? bw_ = context.Operators.Not((bool?)(bv_ is null));
                    return bw_;
                }


                Timing.RepeatComponent ar_(Timing @this) {
                    Timing.RepeatComponent bx_ = @this?.Repeat;
                    return bx_;
                }

                IEnumerable<Timing.RepeatComponent> as_ = context.Operators.WhereSelect<Timing, Timing.RepeatComponent>(ap_, aq_, ar_);

                bool? at_(Timing.RepeatComponent @this) {
                    DataType by_ = @this?.Bounds;
                    object bz_ = FHIRHelpers_4_4_000.Instance.ToValue(context, by_);
                    bool? ca_ = context.Operators.Not((bool?)(bz_ is null));
                    return ca_;
                }


                object au_(Timing.RepeatComponent @this) {
                    DataType cb_ = @this?.Bounds;
                    object cc_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cb_);
                    return cc_;
                }

                IEnumerable<object> av_ = context.Operators.WhereSelect<Timing.RepeatComponent, object>(as_, at_, au_);

                CqlInterval<CqlDateTime> aw_(object DoseTime) {
                    CqlInterval<CqlDateTime> cd_ = QICoreCommon_4_0_000.Instance.toInterval(context, DoseTime);
                    return cd_;
                }

                IEnumerable<CqlInterval<CqlDateTime>> ax_ = context.Operators.SelectDistinct<object, CqlInterval<CqlDateTime>>(av_, aw_);
                IEnumerable<CqlInterval<CqlDateTime>> ay_ = context.Operators.Collapse(ax_, (string)default);

                object az_(CqlInterval<CqlDateTime> @this) {
                    CqlDateTime ce_ = context.Operators.Start(@this);
                    return ce_;
                }

                IEnumerable<CqlInterval<CqlDateTime>> ba_ = context.Operators.SortBy<CqlInterval<CqlDateTime>>(ay_, az_, System.ComponentModel.ListSortDirection.Ascending);
                CqlInterval<CqlDateTime> bb_ = context.Operators.First<CqlInterval<CqlDateTime>>(ba_);
                CqlDateTime bc_ = context.Operators.Start(bb_);
                object bd_;
                DataType cf_ = FirstBladderCancerStaging?.Performed;
                object cg_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cf_);
                bool ch_ = cg_ is CqlDateTime;
                if (ch_)
                {
                    DataType ci_ = FirstBladderCancerStaging?.Performed;
                    object cj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ci_);
                    bd_ = cj_ as CqlDateTime;
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
                        bd_ = co_ as CqlQuantity;
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
                            bd_ = ct_ as CqlInterval<CqlDateTime>;
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
                                bd_ = cy_ as CqlInterval<CqlQuantity>;
                            }
                            else
                            {
                                bd_ = null;
                            }
                        }
                    }
                }
                CqlInterval<CqlDateTime> be_ = QICoreCommon_4_0_000.Instance.toInterval(context, bd_);
                CqlDateTime bf_ = context.Operators.Start(be_);
                CqlQuantity bg_ = context.Operators.Quantity(6m, "months");
                CqlDateTime bh_ = context.Operators.Subtract(bf_, bg_);
                object bi_;
                DataType cz_ = FirstBladderCancerStaging?.Performed;
                object da_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cz_);
                bool db_ = da_ is CqlDateTime;
                if (db_)
                {
                    DataType dc_ = FirstBladderCancerStaging?.Performed;
                    object dd_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dc_);
                    bi_ = dd_ as CqlDateTime;
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
                        bi_ = di_ as CqlQuantity;
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
                            bi_ = dn_ as CqlInterval<CqlDateTime>;
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
                                bi_ = ds_ as CqlInterval<CqlQuantity>;
                            }
                            else
                            {
                                bi_ = null;
                            }
                        }
                    }
                }
                CqlInterval<CqlDateTime> bj_ = QICoreCommon_4_0_000.Instance.toInterval(context, bi_);
                CqlDateTime bk_ = context.Operators.Start(bj_);
                CqlInterval<CqlDateTime> bl_ = context.Operators.Interval(bh_, bk_, true, false);
                bool? bm_ = context.Operators.In<CqlDateTime>(bc_, bl_, (string)default);
                object bn_;
                DataType dt_ = FirstBladderCancerStaging?.Performed;
                object du_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dt_);
                bool dv_ = du_ is CqlDateTime;
                if (dv_)
                {
                    DataType dw_ = FirstBladderCancerStaging?.Performed;
                    object dx_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dw_);
                    bn_ = dx_ as CqlDateTime;
                }
                else
                {
                    DataType dy_ = FirstBladderCancerStaging?.Performed;
                    object dz_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dy_);
                    bool ea_ = dz_ is CqlQuantity;
                    if (ea_)
                    {
                        DataType eb_ = FirstBladderCancerStaging?.Performed;
                        object ec_ = FHIRHelpers_4_4_000.Instance.ToValue(context, eb_);
                        bn_ = ec_ as CqlQuantity;
                    }
                    else
                    {
                        DataType ed_ = FirstBladderCancerStaging?.Performed;
                        object ee_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ed_);
                        bool ef_ = ee_ is CqlInterval<CqlDateTime>;
                        if (ef_)
                        {
                            DataType eg_ = FirstBladderCancerStaging?.Performed;
                            object eh_ = FHIRHelpers_4_4_000.Instance.ToValue(context, eg_);
                            bn_ = eh_ as CqlInterval<CqlDateTime>;
                        }
                        else
                        {
                            DataType ei_ = FirstBladderCancerStaging?.Performed;
                            object ej_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ei_);
                            bool ek_ = ej_ is CqlInterval<CqlQuantity>;
                            if (ek_)
                            {
                                DataType el_ = FirstBladderCancerStaging?.Performed;
                                object em_ = FHIRHelpers_4_4_000.Instance.ToValue(context, el_);
                                bn_ = em_ as CqlInterval<CqlQuantity>;
                            }
                            else
                            {
                                bn_ = null;
                            }
                        }
                    }
                }
                CqlInterval<CqlDateTime> bo_ = QICoreCommon_4_0_000.Instance.toInterval(context, bn_);
                CqlDateTime bp_ = context.Operators.Start(bo_);
                bool? bq_ = context.Operators.Not((bool?)(bp_ is null));
                bool? br_ = context.Operators.And(bm_, bq_);
                return br_;
            }

            bool? al_ = context.Operators.WhereAny<Procedure>((IEnumerable<Procedure>)aj_, ak_);
            return al_;
        }

        IEnumerable<MedicationRequest> h_ = context.Operators.Where<MedicationRequest>(f_, g_);

        bool? i_(MedicationRequest ExclusionMed) {
            Code<MedicationRequest.MedicationrequestStatus> en_ = ExclusionMed?.StatusElement;
            MedicationRequest.MedicationrequestStatus? eo_ = en_?.Value;
            string ep_ = context.Operators.Convert<string>(eo_);
            string[] eq_ = [
                "active",
                "completed",
            ];
            bool? er_ = context.Operators.In<string>(ep_, (IEnumerable<string>)eq_);
            Code<MedicationRequest.MedicationRequestIntent> es_ = ExclusionMed?.IntentElement;
            MedicationRequest.MedicationRequestIntent? et_ = es_?.Value;
            string eu_ = context.Operators.Convert<string>(et_);
            bool? ev_ = context.Operators.Equal(eu_, "order");
            bool? ew_ = context.Operators.And(er_, ev_);
            return ew_;
        }

        IEnumerable<MedicationRequest> j_ = context.Operators.Where<MedicationRequest>(h_, i_);
        CqlCode k_ = this.Combined_radiotherapy__procedure_(context);
        IEnumerable<CqlCode> l_ = context.Operators.ToList<CqlCode>(k_);
        IEnumerable<Procedure> m_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, default, l_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));

        bool? n_(Procedure ExclusionProcedure) {
            Procedure ex_ = this.First_Bladder_Cancer_Staging_Procedure(context);
            Procedure[] ey_ = [
                ex_,
            ];

            bool? ez_(Procedure FirstBladderCancerStaging) {
                object fb_;
                DataType ft_ = ExclusionProcedure?.Performed;
                object fu_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ft_);
                bool fv_ = fu_ is CqlDateTime;
                if (fv_)
                {
                    DataType fw_ = ExclusionProcedure?.Performed;
                    object fx_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fw_);
                    fb_ = fx_ as CqlDateTime;
                }
                else
                {
                    DataType fy_ = ExclusionProcedure?.Performed;
                    object fz_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fy_);
                    bool ga_ = fz_ is CqlQuantity;
                    if (ga_)
                    {
                        DataType gb_ = ExclusionProcedure?.Performed;
                        object gc_ = FHIRHelpers_4_4_000.Instance.ToValue(context, gb_);
                        fb_ = gc_ as CqlQuantity;
                    }
                    else
                    {
                        DataType gd_ = ExclusionProcedure?.Performed;
                        object ge_ = FHIRHelpers_4_4_000.Instance.ToValue(context, gd_);
                        bool gf_ = ge_ is CqlInterval<CqlDateTime>;
                        if (gf_)
                        {
                            DataType gg_ = ExclusionProcedure?.Performed;
                            object gh_ = FHIRHelpers_4_4_000.Instance.ToValue(context, gg_);
                            fb_ = gh_ as CqlInterval<CqlDateTime>;
                        }
                        else
                        {
                            DataType gi_ = ExclusionProcedure?.Performed;
                            object gj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, gi_);
                            bool gk_ = gj_ is CqlInterval<CqlQuantity>;
                            if (gk_)
                            {
                                DataType gl_ = ExclusionProcedure?.Performed;
                                object gm_ = FHIRHelpers_4_4_000.Instance.ToValue(context, gl_);
                                fb_ = gm_ as CqlInterval<CqlQuantity>;
                            }
                            else
                            {
                                fb_ = null;
                            }
                        }
                    }
                }
                CqlInterval<CqlDateTime> fc_ = QICoreCommon_4_0_000.Instance.toInterval(context, fb_);
                CqlDateTime fd_ = context.Operators.Start(fc_);
                object fe_;
                DataType gn_ = FirstBladderCancerStaging?.Performed;
                object go_ = FHIRHelpers_4_4_000.Instance.ToValue(context, gn_);
                bool gp_ = go_ is CqlDateTime;
                if (gp_)
                {
                    DataType gq_ = FirstBladderCancerStaging?.Performed;
                    object gr_ = FHIRHelpers_4_4_000.Instance.ToValue(context, gq_);
                    fe_ = gr_ as CqlDateTime;
                }
                else
                {
                    DataType gs_ = FirstBladderCancerStaging?.Performed;
                    object gt_ = FHIRHelpers_4_4_000.Instance.ToValue(context, gs_);
                    bool gu_ = gt_ is CqlQuantity;
                    if (gu_)
                    {
                        DataType gv_ = FirstBladderCancerStaging?.Performed;
                        object gw_ = FHIRHelpers_4_4_000.Instance.ToValue(context, gv_);
                        fe_ = gw_ as CqlQuantity;
                    }
                    else
                    {
                        DataType gx_ = FirstBladderCancerStaging?.Performed;
                        object gy_ = FHIRHelpers_4_4_000.Instance.ToValue(context, gx_);
                        bool gz_ = gy_ is CqlInterval<CqlDateTime>;
                        if (gz_)
                        {
                            DataType ha_ = FirstBladderCancerStaging?.Performed;
                            object hb_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ha_);
                            fe_ = hb_ as CqlInterval<CqlDateTime>;
                        }
                        else
                        {
                            DataType hc_ = FirstBladderCancerStaging?.Performed;
                            object hd_ = FHIRHelpers_4_4_000.Instance.ToValue(context, hc_);
                            bool he_ = hd_ is CqlInterval<CqlQuantity>;
                            if (he_)
                            {
                                DataType hf_ = FirstBladderCancerStaging?.Performed;
                                object hg_ = FHIRHelpers_4_4_000.Instance.ToValue(context, hf_);
                                fe_ = hg_ as CqlInterval<CqlQuantity>;
                            }
                            else
                            {
                                fe_ = null;
                            }
                        }
                    }
                }
                CqlInterval<CqlDateTime> ff_ = QICoreCommon_4_0_000.Instance.toInterval(context, fe_);
                CqlDateTime fg_ = context.Operators.Start(ff_);
                CqlQuantity fh_ = context.Operators.Quantity(6m, "months");
                CqlDateTime fi_ = context.Operators.Subtract(fg_, fh_);
                object fj_;
                DataType hh_ = FirstBladderCancerStaging?.Performed;
                object hi_ = FHIRHelpers_4_4_000.Instance.ToValue(context, hh_);
                bool hj_ = hi_ is CqlDateTime;
                if (hj_)
                {
                    DataType hk_ = FirstBladderCancerStaging?.Performed;
                    object hl_ = FHIRHelpers_4_4_000.Instance.ToValue(context, hk_);
                    fj_ = hl_ as CqlDateTime;
                }
                else
                {
                    DataType hm_ = FirstBladderCancerStaging?.Performed;
                    object hn_ = FHIRHelpers_4_4_000.Instance.ToValue(context, hm_);
                    bool ho_ = hn_ is CqlQuantity;
                    if (ho_)
                    {
                        DataType hp_ = FirstBladderCancerStaging?.Performed;
                        object hq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, hp_);
                        fj_ = hq_ as CqlQuantity;
                    }
                    else
                    {
                        DataType hr_ = FirstBladderCancerStaging?.Performed;
                        object hs_ = FHIRHelpers_4_4_000.Instance.ToValue(context, hr_);
                        bool ht_ = hs_ is CqlInterval<CqlDateTime>;
                        if (ht_)
                        {
                            DataType hu_ = FirstBladderCancerStaging?.Performed;
                            object hv_ = FHIRHelpers_4_4_000.Instance.ToValue(context, hu_);
                            fj_ = hv_ as CqlInterval<CqlDateTime>;
                        }
                        else
                        {
                            DataType hw_ = FirstBladderCancerStaging?.Performed;
                            object hx_ = FHIRHelpers_4_4_000.Instance.ToValue(context, hw_);
                            bool hy_ = hx_ is CqlInterval<CqlQuantity>;
                            if (hy_)
                            {
                                DataType hz_ = FirstBladderCancerStaging?.Performed;
                                object ia_ = FHIRHelpers_4_4_000.Instance.ToValue(context, hz_);
                                fj_ = ia_ as CqlInterval<CqlQuantity>;
                            }
                            else
                            {
                                fj_ = null;
                            }
                        }
                    }
                }
                CqlInterval<CqlDateTime> fk_ = QICoreCommon_4_0_000.Instance.toInterval(context, fj_);
                CqlDateTime fl_ = context.Operators.Start(fk_);
                CqlInterval<CqlDateTime> fm_ = context.Operators.Interval(fi_, fl_, true, false);
                bool? fn_ = context.Operators.In<CqlDateTime>(fd_, fm_, (string)default);
                object fo_;
                DataType ib_ = FirstBladderCancerStaging?.Performed;
                object ic_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ib_);
                bool id_ = ic_ is CqlDateTime;
                if (id_)
                {
                    DataType ie_ = FirstBladderCancerStaging?.Performed;
                    object if_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ie_);
                    fo_ = if_ as CqlDateTime;
                }
                else
                {
                    DataType ig_ = FirstBladderCancerStaging?.Performed;
                    object ih_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ig_);
                    bool ii_ = ih_ is CqlQuantity;
                    if (ii_)
                    {
                        DataType ij_ = FirstBladderCancerStaging?.Performed;
                        object ik_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ij_);
                        fo_ = ik_ as CqlQuantity;
                    }
                    else
                    {
                        DataType il_ = FirstBladderCancerStaging?.Performed;
                        object im_ = FHIRHelpers_4_4_000.Instance.ToValue(context, il_);
                        bool in_ = im_ is CqlInterval<CqlDateTime>;
                        if (in_)
                        {
                            DataType io_ = FirstBladderCancerStaging?.Performed;
                            object ip_ = FHIRHelpers_4_4_000.Instance.ToValue(context, io_);
                            fo_ = ip_ as CqlInterval<CqlDateTime>;
                        }
                        else
                        {
                            DataType iq_ = FirstBladderCancerStaging?.Performed;
                            object ir_ = FHIRHelpers_4_4_000.Instance.ToValue(context, iq_);
                            bool is_ = ir_ is CqlInterval<CqlQuantity>;
                            if (is_)
                            {
                                DataType it_ = FirstBladderCancerStaging?.Performed;
                                object iu_ = FHIRHelpers_4_4_000.Instance.ToValue(context, it_);
                                fo_ = iu_ as CqlInterval<CqlQuantity>;
                            }
                            else
                            {
                                fo_ = null;
                            }
                        }
                    }
                }
                CqlInterval<CqlDateTime> fp_ = QICoreCommon_4_0_000.Instance.toInterval(context, fo_);
                CqlDateTime fq_ = context.Operators.Start(fp_);
                bool? fr_ = context.Operators.Not((bool?)(fq_ is null));
                bool? fs_ = context.Operators.And(fn_, fr_);
                return fs_;
            }

            bool? fa_ = context.Operators.WhereAny<Procedure>((IEnumerable<Procedure>)ey_, ez_);
            return fa_;
        }

        IEnumerable<Procedure> o_ = context.Operators.Where<Procedure>(m_, n_);

        bool? p_(Procedure ExclusionProcedure) {
            Code<EventStatus> iv_ = ExclusionProcedure?.StatusElement;
            EventStatus? iw_ = iv_?.Value;
            string ix_ = context.Operators.Convert<string>(iw_);
            string[] iy_ = [
                "completed",
                "in-progress",
            ];
            bool? iz_ = context.Operators.In<string>(ix_, (IEnumerable<string>)iy_);
            return iz_;
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

                bool? l_(Extension @this) {
                    FhirUri af_ = @this?.UrlElement;
                    string ag_ = FHIRHelpers_4_4_000.Instance.ToString(context, af_);
                    bool? ah_ = context.Operators.Equal(ag_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-recorded");
                    return ah_;
                }


                object m_(Extension @this) {
                    DataType ai_ = @this?.Value;
                    object aj_ = context.Operators.LateBoundProperty<object>(ai_, "value");
                    return aj_;
                }

                IEnumerable<object> n_ = context.Operators.WhereSelect<Extension, object>((IEnumerable<Extension>)(BCGNotGiven is DomainResource
                    ? (BCGNotGiven as DomainResource).Extension
                    : default), l_, m_);
                object o_ = context.Operators.SingletonFrom<object>(n_);
                CqlDateTime p_ = context.Operators.Convert<CqlDateTime>((FhirDateTime)o_);
                object q_;
                DataType ak_ = FirstBladderCancerStaging?.Performed;
                object al_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ak_);
                bool am_ = al_ is CqlDateTime;
                if (am_)
                {
                    DataType an_ = FirstBladderCancerStaging?.Performed;
                    object ao_ = FHIRHelpers_4_4_000.Instance.ToValue(context, an_);
                    q_ = ao_ as CqlDateTime;
                }
                else
                {
                    DataType ap_ = FirstBladderCancerStaging?.Performed;
                    object aq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ap_);
                    bool ar_ = aq_ is CqlQuantity;
                    if (ar_)
                    {
                        DataType as_ = FirstBladderCancerStaging?.Performed;
                        object at_ = FHIRHelpers_4_4_000.Instance.ToValue(context, as_);
                        q_ = at_ as CqlQuantity;
                    }
                    else
                    {
                        DataType au_ = FirstBladderCancerStaging?.Performed;
                        object av_ = FHIRHelpers_4_4_000.Instance.ToValue(context, au_);
                        bool aw_ = av_ is CqlInterval<CqlDateTime>;
                        if (aw_)
                        {
                            DataType ax_ = FirstBladderCancerStaging?.Performed;
                            object ay_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ax_);
                            q_ = ay_ as CqlInterval<CqlDateTime>;
                        }
                        else
                        {
                            DataType az_ = FirstBladderCancerStaging?.Performed;
                            object ba_ = FHIRHelpers_4_4_000.Instance.ToValue(context, az_);
                            bool bb_ = ba_ is CqlInterval<CqlQuantity>;
                            if (bb_)
                            {
                                DataType bc_ = FirstBladderCancerStaging?.Performed;
                                object bd_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bc_);
                                q_ = bd_ as CqlInterval<CqlQuantity>;
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
                DataType be_ = FirstBladderCancerStaging?.Performed;
                object bf_ = FHIRHelpers_4_4_000.Instance.ToValue(context, be_);
                bool bg_ = bf_ is CqlDateTime;
                if (bg_)
                {
                    DataType bh_ = FirstBladderCancerStaging?.Performed;
                    object bi_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bh_);
                    t_ = bi_ as CqlDateTime;
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
                        t_ = bn_ as CqlQuantity;
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
                            t_ = bs_ as CqlInterval<CqlDateTime>;
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
                                t_ = bx_ as CqlInterval<CqlQuantity>;
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
                bool? z_ = context.Operators.In<CqlDateTime>(p_, y_, "day");
                object aa_;
                DataType by_ = FirstBladderCancerStaging?.Performed;
                object bz_ = FHIRHelpers_4_4_000.Instance.ToValue(context, by_);
                bool ca_ = bz_ is CqlDateTime;
                if (ca_)
                {
                    DataType cb_ = FirstBladderCancerStaging?.Performed;
                    object cc_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cb_);
                    aa_ = cc_ as CqlDateTime;
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
                        aa_ = ch_ as CqlQuantity;
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
                            aa_ = cm_ as CqlInterval<CqlDateTime>;
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
                                aa_ = cr_ as CqlInterval<CqlQuantity>;
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
            List<CodeableConcept> cs_ = BCGNotGiven?.StatusReason;

            CqlConcept ct_(CodeableConcept @this) {
                CqlConcept cx_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);
                return cx_;
            }

            IEnumerable<CqlConcept> cu_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)cs_, ct_);
            CqlValueSet cv_ = this.Unavailability_of_Bacillus_Calmette_Guerin_for_Urology_Care(context);
            bool? cw_ = context.Operators.ConceptsInValueSet(cu_, cv_);
            return cw_;
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
                string q_ = (M is Resource
                    ? (M as Resource).IdElement
                    : default)?.Value;
                DataType r_ = MR?.Medication;
                object s_ = context.Operators.LateBoundProperty<object>(r_, "reference");
                object t_ = context.Operators.LateBoundProperty<object>(s_, "value");
                IEnumerable<string> u_ = context.Operators.Split((string)t_, "/");
                string v_ = context.Operators.Last<string>(u_);
                bool? w_ = context.Operators.Equal(q_, v_);
                CodeableConcept x_ = M?.Code;
                CqlConcept y_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, x_);
                CqlValueSet z_ = this.Bacillus_Calmette_Guerin_for_Urology_Care(context);
                bool? aa_ = context.Operators.ConceptInValueSet(y_, z_);
                bool? ab_ = context.Operators.And(w_, aa_);
                return ab_;
            }

            bool? p_ = context.Operators.WhereAny<Medication>(n_, o_);
            return p_;
        }

        IEnumerable<MedicationAdministration> c_ = context.Operators.Where<MedicationAdministration>(a_, b_);
        CqlValueSet d_ = this.Bacillus_Calmette_Guerin_for_Urology_Care(context);
        IEnumerable<MedicationAdministration> e_ = context.Operators.Retrieve<MedicationAdministration>(new RetrieveParameters(default, d_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationadministration"));
        IEnumerable<MedicationAdministration> f_ = context.Operators.Union<MedicationAdministration>(c_, e_);

        bool? g_(MedicationAdministration BCG) {
            Procedure ac_ = this.First_Bladder_Cancer_Staging_Procedure(context);
            Procedure[] ad_ = [
                ac_,
            ];

            bool? ae_(Procedure FirstBladderCancerStaging) {
                DataType ag_ = BCG?.Effective;
                object ah_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ag_);
                CqlInterval<CqlDateTime> ai_ = QICoreCommon_4_0_000.Instance.toInterval(context, ah_);
                CqlDateTime aj_ = context.Operators.Start(ai_);
                object ak_;
                DataType bc_ = FirstBladderCancerStaging?.Performed;
                object bd_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bc_);
                bool be_ = bd_ is CqlDateTime;
                if (be_)
                {
                    DataType bf_ = FirstBladderCancerStaging?.Performed;
                    object bg_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bf_);
                    ak_ = bg_ as CqlDateTime;
                }
                else
                {
                    DataType bh_ = FirstBladderCancerStaging?.Performed;
                    object bi_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bh_);
                    bool bj_ = bi_ is CqlQuantity;
                    if (bj_)
                    {
                        DataType bk_ = FirstBladderCancerStaging?.Performed;
                        object bl_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bk_);
                        ak_ = bl_ as CqlQuantity;
                    }
                    else
                    {
                        DataType bm_ = FirstBladderCancerStaging?.Performed;
                        object bn_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bm_);
                        bool bo_ = bn_ is CqlInterval<CqlDateTime>;
                        if (bo_)
                        {
                            DataType bp_ = FirstBladderCancerStaging?.Performed;
                            object bq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bp_);
                            ak_ = bq_ as CqlInterval<CqlDateTime>;
                        }
                        else
                        {
                            DataType br_ = FirstBladderCancerStaging?.Performed;
                            object bs_ = FHIRHelpers_4_4_000.Instance.ToValue(context, br_);
                            bool bt_ = bs_ is CqlInterval<CqlQuantity>;
                            if (bt_)
                            {
                                DataType bu_ = FirstBladderCancerStaging?.Performed;
                                object bv_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bu_);
                                ak_ = bv_ as CqlInterval<CqlQuantity>;
                            }
                            else
                            {
                                ak_ = null;
                            }
                        }
                    }
                }
                CqlInterval<CqlDateTime> al_ = QICoreCommon_4_0_000.Instance.toInterval(context, ak_);
                CqlDateTime am_ = context.Operators.Start(al_);
                object an_;
                DataType bw_ = FirstBladderCancerStaging?.Performed;
                object bx_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bw_);
                bool by_ = bx_ is CqlDateTime;
                if (by_)
                {
                    DataType bz_ = FirstBladderCancerStaging?.Performed;
                    object ca_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bz_);
                    an_ = ca_ as CqlDateTime;
                }
                else
                {
                    DataType cb_ = FirstBladderCancerStaging?.Performed;
                    object cc_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cb_);
                    bool cd_ = cc_ is CqlQuantity;
                    if (cd_)
                    {
                        DataType ce_ = FirstBladderCancerStaging?.Performed;
                        object cf_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ce_);
                        an_ = cf_ as CqlQuantity;
                    }
                    else
                    {
                        DataType cg_ = FirstBladderCancerStaging?.Performed;
                        object ch_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cg_);
                        bool ci_ = ch_ is CqlInterval<CqlDateTime>;
                        if (ci_)
                        {
                            DataType cj_ = FirstBladderCancerStaging?.Performed;
                            object ck_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cj_);
                            an_ = ck_ as CqlInterval<CqlDateTime>;
                        }
                        else
                        {
                            DataType cl_ = FirstBladderCancerStaging?.Performed;
                            object cm_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cl_);
                            bool cn_ = cm_ is CqlInterval<CqlQuantity>;
                            if (cn_)
                            {
                                DataType co_ = FirstBladderCancerStaging?.Performed;
                                object cp_ = FHIRHelpers_4_4_000.Instance.ToValue(context, co_);
                                an_ = cp_ as CqlInterval<CqlQuantity>;
                            }
                            else
                            {
                                an_ = null;
                            }
                        }
                    }
                }
                CqlInterval<CqlDateTime> ao_ = QICoreCommon_4_0_000.Instance.toInterval(context, an_);
                CqlDateTime ap_ = context.Operators.Start(ao_);
                CqlQuantity aq_ = context.Operators.Quantity(6m, "months");
                CqlDateTime ar_ = context.Operators.Add(ap_, aq_);
                CqlInterval<CqlDateTime> as_ = context.Operators.Interval(am_, ar_, false, true);
                bool? at_ = context.Operators.In<CqlDateTime>(aj_, as_, "day");
                object au_;
                DataType cq_ = FirstBladderCancerStaging?.Performed;
                object cr_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cq_);
                bool cs_ = cr_ is CqlDateTime;
                if (cs_)
                {
                    DataType ct_ = FirstBladderCancerStaging?.Performed;
                    object cu_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ct_);
                    au_ = cu_ as CqlDateTime;
                }
                else
                {
                    DataType cv_ = FirstBladderCancerStaging?.Performed;
                    object cw_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cv_);
                    bool cx_ = cw_ is CqlQuantity;
                    if (cx_)
                    {
                        DataType cy_ = FirstBladderCancerStaging?.Performed;
                        object cz_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cy_);
                        au_ = cz_ as CqlQuantity;
                    }
                    else
                    {
                        DataType da_ = FirstBladderCancerStaging?.Performed;
                        object db_ = FHIRHelpers_4_4_000.Instance.ToValue(context, da_);
                        bool dc_ = db_ is CqlInterval<CqlDateTime>;
                        if (dc_)
                        {
                            DataType dd_ = FirstBladderCancerStaging?.Performed;
                            object de_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dd_);
                            au_ = de_ as CqlInterval<CqlDateTime>;
                        }
                        else
                        {
                            DataType df_ = FirstBladderCancerStaging?.Performed;
                            object dg_ = FHIRHelpers_4_4_000.Instance.ToValue(context, df_);
                            bool dh_ = dg_ is CqlInterval<CqlQuantity>;
                            if (dh_)
                            {
                                DataType di_ = FirstBladderCancerStaging?.Performed;
                                object dj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, di_);
                                au_ = dj_ as CqlInterval<CqlQuantity>;
                            }
                            else
                            {
                                au_ = null;
                            }
                        }
                    }
                }
                CqlInterval<CqlDateTime> av_ = QICoreCommon_4_0_000.Instance.toInterval(context, au_);
                CqlDateTime aw_ = context.Operators.Start(av_);
                bool? ax_ = context.Operators.Not((bool?)(aw_ is null));
                bool? ay_ = context.Operators.And(at_, ax_);
                CqlInterval<CqlDateTime> az_ = this.Measurement_Period(context);
                bool? ba_ = context.Operators.In<CqlDateTime>(aj_, az_, "day");
                bool? bb_ = context.Operators.And(ay_, ba_);
                return bb_;
            }

            bool? af_ = context.Operators.WhereAny<Procedure>((IEnumerable<Procedure>)ad_, ae_);
            return af_;
        }

        IEnumerable<MedicationAdministration> h_ = context.Operators.Where<MedicationAdministration>(f_, g_);

        bool? i_(MedicationAdministration BCG) {
            Code<MedicationAdministration.MedicationAdministrationStatusCodes> dk_ = BCG?.StatusElement;
            MedicationAdministration.MedicationAdministrationStatusCodes? dl_ = dk_?.Value;
            string dm_ = context.Operators.Convert<string>(dl_);
            string[] dn_ = [
                "in-progress",
                "completed",
            ];
            bool? do_ = context.Operators.In<string>(dm_, (IEnumerable<string>)dn_);
            return do_;
        }

        IEnumerable<MedicationAdministration> j_ = context.Operators.Where<MedicationAdministration>(h_, i_);

        object k_(MedicationAdministration @this) {
            DataType dp_ = @this?.Effective;
            object dq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dp_);
            CqlInterval<CqlDateTime> dr_ = QICoreCommon_4_0_000.Instance.toInterval(context, dq_);
            CqlDateTime ds_ = context.Operators.Start(dr_);
            return ds_;
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

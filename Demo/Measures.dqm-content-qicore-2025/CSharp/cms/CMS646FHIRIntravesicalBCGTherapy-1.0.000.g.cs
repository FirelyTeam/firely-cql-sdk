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
        bool? c_ = !((bool?)(b_ is null));
        // CQL 'implies' (216:3-220:3): right operand skipped when left is false
        if (c_ is false)
        {
            return true;
        }
        else
        {
            CqlCode d_ = QICoreCommon_4_0_000.Instance.confirmed(context);
            CqlConcept e_ = context.Operators.ConvertCodeToConcept(d_);
            bool? f_ = context.Operators.Equivalent(b_, e_);
            bool? g_;
            // CQL 'or' (216:54-217:66): right operand skipped when left is true
            if (f_ is true)
            {
                g_ = true;
            }
            else
            {
                CodeableConcept j_ = condition?.VerificationStatus;
                CqlConcept k_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, j_);
                CqlCode l_ = QICoreCommon_4_0_000.Instance.unconfirmed(context);
                CqlConcept m_ = context.Operators.ConvertCodeToConcept(l_);
                bool? n_ = context.Operators.Equivalent(k_, m_);
                g_ = f_ | n_;
            }
            bool? h_;
            // CQL 'or' (216:54-218:66): right operand skipped when left is true
            if (g_ is true)
            {
                h_ = true;
            }
            else
            {
                CodeableConcept o_ = condition?.VerificationStatus;
                CqlConcept p_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, o_);
                CqlCode q_ = QICoreCommon_4_0_000.Instance.provisional(context);
                CqlConcept r_ = context.Operators.ConvertCodeToConcept(q_);
                bool? s_ = context.Operators.Equivalent(p_, r_);
                h_ = g_ | s_;
            }
            bool? i_;
            // CQL 'or' (216:52-220:3): right operand skipped when left is true
            if (h_ is true)
            {
                i_ = true;
            }
            else
            {
                CodeableConcept t_ = condition?.VerificationStatus;
                CqlConcept u_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, t_);
                CqlCode v_ = QICoreCommon_4_0_000.Instance.differential(context);
                CqlConcept w_ = context.Operators.ConvertCodeToConcept(v_);
                bool? x_ = context.Operators.Equivalent(u_, w_);
                i_ = h_ | x_;
            }
            return !c_ | i_;
        }
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
            bool? l_;
            // CQL 'or' (149:11-151:5): right operand skipped when left is true
            if (k_ is true)
            {
                l_ = true;
            }
            else
            {
                DataType m_ = BladderCancer?.Onset;
                object n_ = FHIRHelpers_4_4_000.Instance.ToValue(context, m_);
                CqlInterval<CqlDateTime> o_ = QICoreCommon_4_0_000.Instance.toInterval(context, n_);
                CqlInterval<CqlDateTime> p_;
                CqlInterval<CqlDateTime> r_ = this.Measurement_Period(context);
                CqlDateTime s_ = context.Operators.End(r_);
                if (s_ is null)
                {
                    p_ = default;
                }
                else
                {
                    CqlInterval<CqlDateTime> t_ = this.Measurement_Period(context);
                    CqlDateTime u_ = context.Operators.End(t_);
                    CqlInterval<CqlDateTime> v_ = context.Operators.Interval(u_, u_, true, true);
                    p_ = v_;
                }
                bool? q_ = context.Operators.Before(o_, p_, "day");
                l_ = k_ | q_;
            }
            // CQL 'and' (149:5-152:38): right operand skipped when left is false
            if (l_ is false)
            {
                return false;
            }
            else
            {
                bool? w_ = this.isVerified(context, BladderCancer);
                return l_ & w_;
            }
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
            bool? e_ = !((bool?)(d_ is null));
            bool? f_;
            // CQL 'and' (178:13-183:9): right operand skipped when left is false
            if (e_ is false)
            {
                f_ = false;
            }
            else
            {
                DataType g_ = StagingObservation?.Value;
                object h_ = FHIRHelpers_4_4_000.Instance.ToValue(context, g_);
                CqlCode i_ = this.American_Joint_Committee_on_Cancer_cT1__qualifier_value_(context);
                CqlConcept j_ = context.Operators.ConvertCodeToConcept(i_);
                bool? k_ = context.Operators.Equivalent(h_ as CqlConcept, j_);
                bool? l_;
                // CQL 'or' (179:15-180:112): right operand skipped when left is true
                if (k_ is true)
                {
                    l_ = true;
                }
                else
                {
                    CqlCode o_ = this.American_Joint_Committee_on_Cancer_cTis__qualifier_value_(context);
                    CqlConcept p_ = context.Operators.ConvertCodeToConcept(o_);
                    bool? q_ = context.Operators.Equivalent(h_ as CqlConcept, p_);
                    l_ = k_ | q_;
                }
                bool? m_;
                // CQL 'or' (179:15-181:111): right operand skipped when left is true
                if (l_ is true)
                {
                    m_ = true;
                }
                else
                {
                    CqlCode r_ = this.American_Joint_Committee_on_Cancer_cTa__qualifier_value_(context);
                    CqlConcept s_ = context.Operators.ConvertCodeToConcept(r_);
                    bool? t_ = context.Operators.Equivalent(h_ as CqlConcept, s_);
                    m_ = l_ | t_;
                }
                bool? n_;
                // CQL 'or' (179:13-183:9): right operand skipped when left is true
                if (m_ is true)
                {
                    n_ = true;
                }
                else
                {
                    CqlCode u_ = this.Carcinoma_in_situ_of_bladder(context);
                    CqlConcept v_ = context.Operators.ConvertCodeToConcept(u_);
                    bool? w_ = context.Operators.Equivalent(h_ as CqlConcept, v_);
                    n_ = m_ | w_;
                }
                f_ = e_ & n_;
            }
            // CQL 'and' (178:7-184:76): right operand skipped when left is false
            if (f_ is false)
            {
                return false;
            }
            else
            {
                Code<ObservationStatus> x_ = StagingObservation?.StatusElement;
                ObservationStatus? y_ = x_?.Value;
                string z_ = context.Operators.Convert<string>(y_);
                string[] aa_ = [
                    "final",
                    "amended",
                    "corrected",
                ];
                bool? ab_ = context.Operators.In<string>(z_, (IEnumerable<string>)aa_);
                return f_ & ab_;
            }
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
            bool? i_;
            // CQL 'and' (141:13-142:45): right operand skipped when left is false
            if (h_ is false)
            {
                i_ = false;
            }
            else
            {
                Coding j_ = ValidEncounter?.Class;
                CqlCode k_ = FHIRHelpers_4_4_000.Instance.ToCode(context, j_);
                CqlCode l_ = this.@virtual(context);
                bool? m_ = context.Operators.Equivalent(k_, l_);
                i_ = h_ & !m_;
            }
            // CQL 'and' (141:7-143:46): right operand skipped when left is false
            if (i_ is false)
            {
                return false;
            }
            else
            {
                Code<Encounter.EncounterStatus> n_ = ValidEncounter?.StatusElement;
                Encounter.EncounterStatus? o_ = n_?.Value;
                Code<Encounter.EncounterStatus> p_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(o_);
                bool? q_ = context.Operators.Equal(p_, "finished");
                return i_ & q_;
            }
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
        // CQL 'and' (39:3-40:34): right operand skipped when left is false
        if (a_ is false)
        {
            return false;
        }
        else
        {
            bool? b_ = this.Has_Qualifying_Encounter(context);
            return a_ & b_;
        }
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
                DataType q_ = FirstBladderCancerStaging?.Performed;
                object r_ = FHIRHelpers_4_4_000.Instance.ToValue(context, q_);
                bool s_ = r_ is CqlDateTime;
                if (s_)
                {
                    DataType t_ = FirstBladderCancerStaging?.Performed;
                    object u_ = FHIRHelpers_4_4_000.Instance.ToValue(context, t_);
                    n_ = u_ as CqlDateTime;
                }
                else
                {
                    DataType v_ = FirstBladderCancerStaging?.Performed;
                    object w_ = FHIRHelpers_4_4_000.Instance.ToValue(context, v_);
                    bool x_ = w_ is CqlQuantity;
                    if (x_)
                    {
                        DataType y_ = FirstBladderCancerStaging?.Performed;
                        object z_ = FHIRHelpers_4_4_000.Instance.ToValue(context, y_);
                        n_ = z_ as CqlQuantity;
                    }
                    else
                    {
                        DataType aa_ = FirstBladderCancerStaging?.Performed;
                        object ab_ = FHIRHelpers_4_4_000.Instance.ToValue(context, aa_);
                        bool ac_ = ab_ is CqlInterval<CqlDateTime>;
                        if (ac_)
                        {
                            DataType ad_ = FirstBladderCancerStaging?.Performed;
                            object ae_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ad_);
                            n_ = ae_ as CqlInterval<CqlDateTime>;
                        }
                        else
                        {
                            DataType af_ = FirstBladderCancerStaging?.Performed;
                            object ag_ = FHIRHelpers_4_4_000.Instance.ToValue(context, af_);
                            bool ah_ = ag_ is CqlInterval<CqlQuantity>;
                            if (ah_)
                            {
                                DataType ai_ = FirstBladderCancerStaging?.Performed;
                                object aj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ai_);
                                n_ = aj_ as CqlInterval<CqlQuantity>;
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
                // CQL 'or' (80:17-86:7): right operand skipped when left is true
                if (p_ is true)
                {
                    return true;
                }
                else
                {
                    DataType ak_ = ActiveTuberculosis?.Onset;
                    object al_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ak_);
                    CqlInterval<CqlDateTime> am_ = QICoreCommon_4_0_000.Instance.toInterval(context, al_);
                    object an_;
                    DataType ar_ = FirstBladderCancerStaging?.Performed;
                    object as_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ar_);
                    bool at_ = as_ is CqlDateTime;
                    if (at_)
                    {
                        DataType au_ = FirstBladderCancerStaging?.Performed;
                        object av_ = FHIRHelpers_4_4_000.Instance.ToValue(context, au_);
                        an_ = av_ as CqlDateTime;
                    }
                    else
                    {
                        DataType aw_ = FirstBladderCancerStaging?.Performed;
                        object ax_ = FHIRHelpers_4_4_000.Instance.ToValue(context, aw_);
                        bool ay_ = ax_ is CqlQuantity;
                        if (ay_)
                        {
                            DataType az_ = FirstBladderCancerStaging?.Performed;
                            object ba_ = FHIRHelpers_4_4_000.Instance.ToValue(context, az_);
                            an_ = ba_ as CqlQuantity;
                        }
                        else
                        {
                            DataType bb_ = FirstBladderCancerStaging?.Performed;
                            object bc_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bb_);
                            bool bd_ = bc_ is CqlInterval<CqlDateTime>;
                            if (bd_)
                            {
                                DataType be_ = FirstBladderCancerStaging?.Performed;
                                object bf_ = FHIRHelpers_4_4_000.Instance.ToValue(context, be_);
                                an_ = bf_ as CqlInterval<CqlDateTime>;
                            }
                            else
                            {
                                DataType bg_ = FirstBladderCancerStaging?.Performed;
                                object bh_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bg_);
                                bool bi_ = bh_ is CqlInterval<CqlQuantity>;
                                if (bi_)
                                {
                                    DataType bj_ = FirstBladderCancerStaging?.Performed;
                                    object bk_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bj_);
                                    an_ = bk_ as CqlInterval<CqlQuantity>;
                                }
                                else
                                {
                                    an_ = null;
                                }
                            }
                        }
                    }
                    CqlInterval<CqlDateTime> ao_ = QICoreCommon_4_0_000.Instance.toInterval(context, an_);
                    bool? ap_ = context.Operators.OverlapsAfter(am_, ao_, "day");
                    bool? aq_;
                    // CQL 'and' (81:14-85:11): right operand skipped when left is false
                    if (ap_ is false)
                    {
                        aq_ = false;
                    }
                    else
                    {
                        DataType bl_ = ActiveTuberculosis?.Abatement;
                        object bm_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bl_);
                        CqlInterval<CqlDateTime> bn_ = QICoreCommon_4_0_000.Instance.toInterval(context, bm_);
                        object bo_;
                        DataType bs_ = FirstBladderCancerStaging?.Performed;
                        object bt_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bs_);
                        bool bu_ = bt_ is CqlDateTime;
                        if (bu_)
                        {
                            DataType bv_ = FirstBladderCancerStaging?.Performed;
                            object bw_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bv_);
                            bo_ = bw_ as CqlDateTime;
                        }
                        else
                        {
                            DataType bx_ = FirstBladderCancerStaging?.Performed;
                            object by_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bx_);
                            bool bz_ = by_ is CqlQuantity;
                            if (bz_)
                            {
                                DataType ca_ = FirstBladderCancerStaging?.Performed;
                                object cb_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ca_);
                                bo_ = cb_ as CqlQuantity;
                            }
                            else
                            {
                                DataType cc_ = FirstBladderCancerStaging?.Performed;
                                object cd_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cc_);
                                bool ce_ = cd_ is CqlInterval<CqlDateTime>;
                                if (ce_)
                                {
                                    DataType cf_ = FirstBladderCancerStaging?.Performed;
                                    object cg_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cf_);
                                    bo_ = cg_ as CqlInterval<CqlDateTime>;
                                }
                                else
                                {
                                    DataType ch_ = FirstBladderCancerStaging?.Performed;
                                    object ci_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ch_);
                                    bool cj_ = ci_ is CqlInterval<CqlQuantity>;
                                    if (cj_)
                                    {
                                        DataType ck_ = FirstBladderCancerStaging?.Performed;
                                        object cl_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ck_);
                                        bo_ = cl_ as CqlInterval<CqlQuantity>;
                                    }
                                    else
                                    {
                                        bo_ = null;
                                    }
                                }
                            }
                        }
                        CqlInterval<CqlDateTime> bp_ = QICoreCommon_4_0_000.Instance.toInterval(context, bo_);
                        bool? bq_ = context.Operators.OverlapsAfter(bn_, bp_, "day");
                        bool? br_;
                        // CQL 'or' (82:19-84:15): right operand skipped when left is true
                        if (bq_ is true)
                        {
                            br_ = true;
                        }
                        else
                        {
                            br_ = bq_ | ((bool?)(bm_ is null));
                        }
                        aq_ = ap_ & br_;
                    }
                    return p_ | aq_;
                }
            }

            bool? l_ = context.Operators.WhereAny<Procedure>((IEnumerable<Procedure>)j_, k_);
            return l_;
        }

        IEnumerable<Condition> f_ = context.Operators.Where<Condition>(d_, e_);

        bool? g_(Condition ActiveTuberculosis) {
            bool? cm_ = this.isVerified(context, ActiveTuberculosis);
            return cm_;
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
                object n_ = context.Operators.LateBoundProperty<object>(M, "id.value");
                object o_ = context.Operators.LateBoundProperty<object>(MR, "medication.reference.value");
                IEnumerable<string> p_ = context.Operators.Split((string)o_, "/");
                string q_ = context.Operators.Last<string>(p_);
                bool? r_ = context.Operators.Equal(n_, q_);
                // CQL 'and': right operand skipped when left is false
                if (r_ is false)
                {
                    return false;
                }
                else
                {
                    CodeableConcept s_ = M?.Code;
                    CqlConcept t_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, s_);
                    CqlValueSet u_ = this.Immunosuppressive_Drugs_for_Urology_Care(context);
                    bool? v_ = context.Operators.ConceptInValueSet(t_, u_);
                    return r_ & v_;
                }
            }

            bool? m_ = context.Operators.WhereAny<Medication>(k_, l_);
            return m_;
        }

        IEnumerable<MedicationRequest> c_ = context.Operators.Where<MedicationRequest>(a_, b_);
        CqlValueSet d_ = this.Immunosuppressive_Drugs_for_Urology_Care(context);
        IEnumerable<MedicationRequest> e_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, d_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> f_ = context.Operators.Union<MedicationRequest>(c_, e_);

        bool? g_(MedicationRequest ImmunosuppressiveDrugs) {
            Procedure w_ = this.First_Bladder_Cancer_Staging_Procedure(context);
            Procedure[] x_ = [
                w_,
            ];

            bool? y_(Procedure FirstBladderCancerStaging) {
                List<Dosage> aa_ = ImmunosuppressiveDrugs?.DosageInstruction;

                bool? ab_(Dosage @this) {
                    Timing bd_ = @this?.Timing;
                    return !((bool?)(bd_ is null));
                }


                Timing ac_(Dosage @this) {
                    Timing be_ = @this?.Timing;
                    return be_;
                }

                IEnumerable<Timing> ad_ = context.Operators.WhereSelect<Dosage, Timing>((IEnumerable<Dosage>)aa_, ab_, ac_);

                CqlDateTime ae_(Timing dosageTiming) {
                    List<FhirDateTime> bf_ = dosageTiming?.EventElement;

                    string bg_(FhirDateTime @this) {
                        string bm_ = @this?.Value;
                        return bm_;
                    }

                    IEnumerable<string> bh_ = context.Operators.Select<FhirDateTime, string>((IEnumerable<FhirDateTime>)bf_, bg_);

                    CqlDateTime bi_(string @string) {
                        CqlDateTime bn_ = context.Operators.ConvertStringToDateTime(@string);
                        return bn_;
                    }

                    IEnumerable<CqlDateTime> bj_ = context.Operators.Select<string, CqlDateTime>(bh_, bi_);
                    IEnumerable<CqlDateTime> bk_ = context.Operators.ListSort<CqlDateTime>(bj_, System.ComponentModel.ListSortDirection.Ascending);
                    CqlDateTime bl_ = context.Operators.First<CqlDateTime>(bk_);
                    return bl_;
                }

                IEnumerable<CqlDateTime> af_ = context.Operators.SelectDistinct<Timing, CqlDateTime>(ad_, ae_);
                IEnumerable<CqlDateTime> ag_ = context.Operators.ListSort<CqlDateTime>(af_, System.ComponentModel.ListSortDirection.Ascending);
                CqlDateTime ah_ = context.Operators.First<CqlDateTime>(ag_);
                CqlInterval<CqlDateTime> ai_ = QICoreCommon_4_0_000.Instance.toInterval(context, ah_);

                bool? aj_(Dosage @this) {
                    Timing bo_ = @this?.Timing;
                    return !((bool?)(bo_ is null));
                }


                Timing ak_(Dosage @this) {
                    Timing bp_ = @this?.Timing;
                    return bp_;
                }

                IEnumerable<Timing> al_ = context.Operators.WhereSelect<Dosage, Timing>((IEnumerable<Dosage>)aa_, aj_, ak_);

                bool? am_(Timing @this) {
                    Timing.RepeatComponent bq_ = @this?.Repeat;
                    return !((bool?)(bq_ is null));
                }


                Timing.RepeatComponent an_(Timing @this) {
                    Timing.RepeatComponent br_ = @this?.Repeat;
                    return br_;
                }

                IEnumerable<Timing.RepeatComponent> ao_ = context.Operators.WhereSelect<Timing, Timing.RepeatComponent>(al_, am_, an_);

                bool? ap_(Timing.RepeatComponent @this) {
                    DataType bs_ = @this?.Bounds;
                    object bt_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bs_);
                    return !((bool?)(bt_ is null));
                }


                object aq_(Timing.RepeatComponent @this) {
                    DataType bu_ = @this?.Bounds;
                    object bv_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bu_);
                    return bv_;
                }

                IEnumerable<object> ar_ = context.Operators.WhereSelect<Timing.RepeatComponent, object>(ao_, ap_, aq_);

                CqlInterval<CqlDateTime> as_(object DoseTime) {
                    CqlInterval<CqlDateTime> bw_ = QICoreCommon_4_0_000.Instance.toInterval(context, DoseTime);
                    return bw_;
                }

                IEnumerable<CqlInterval<CqlDateTime>> at_ = context.Operators.SelectDistinct<object, CqlInterval<CqlDateTime>>(ar_, as_);
                IEnumerable<CqlInterval<CqlDateTime>> au_ = context.Operators.Collapse(at_, (string)default);

                object av_(CqlInterval<CqlDateTime> @this) {
                    CqlDateTime bx_ = context.Operators.Start(@this);
                    return bx_;
                }

                IEnumerable<CqlInterval<CqlDateTime>> aw_ = context.Operators.SortBy<CqlInterval<CqlDateTime>>(au_, av_, System.ComponentModel.ListSortDirection.Ascending);
                CqlInterval<CqlDateTime> ax_ = context.Operators.First<CqlInterval<CqlDateTime>>(aw_);
                CqlDateTime ay_ = context.Operators.Start(ai_ ?? ax_);
                object az_;
                DataType by_ = FirstBladderCancerStaging?.Performed;
                object bz_ = FHIRHelpers_4_4_000.Instance.ToValue(context, by_);
                bool ca_ = bz_ is CqlDateTime;
                if (ca_)
                {
                    DataType cb_ = FirstBladderCancerStaging?.Performed;
                    object cc_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cb_);
                    az_ = cc_ as CqlDateTime;
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
                        az_ = ch_ as CqlQuantity;
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
                            az_ = cm_ as CqlInterval<CqlDateTime>;
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
                                az_ = cr_ as CqlInterval<CqlQuantity>;
                            }
                            else
                            {
                                az_ = null;
                            }
                        }
                    }
                }
                CqlInterval<CqlDateTime> ba_ = QICoreCommon_4_0_000.Instance.toInterval(context, az_);
                CqlDateTime bb_ = context.Operators.Start(ba_);
                bool? bc_ = context.Operators.SameOrBefore(ay_, bb_, "day");
                return bc_;
            }

            bool? z_ = context.Operators.WhereAny<Procedure>((IEnumerable<Procedure>)x_, y_);
            return z_;
        }

        IEnumerable<MedicationRequest> h_ = context.Operators.Where<MedicationRequest>(f_, g_);

        bool? i_(MedicationRequest ImmunosuppressiveDrugs) {
            Code<MedicationRequest.MedicationrequestStatus> cs_ = ImmunosuppressiveDrugs?.StatusElement;
            MedicationRequest.MedicationrequestStatus? ct_ = cs_?.Value;
            string cu_ = context.Operators.Convert<string>(ct_);
            string[] cv_ = [
                "active",
                "completed",
            ];
            bool? cw_ = context.Operators.In<string>(cu_, (IEnumerable<string>)cv_);
            // CQL 'and' (212:5-213:49): right operand skipped when left is false
            if (cw_ is false)
            {
                return false;
            }
            else
            {
                Code<MedicationRequest.MedicationRequestIntent> cx_ = ImmunosuppressiveDrugs?.IntentElement;
                MedicationRequest.MedicationRequestIntent? cy_ = cx_?.Value;
                string cz_ = context.Operators.Convert<string>(cy_);
                bool? da_ = context.Operators.Equal(cz_, "order");
                return cw_ & da_;
            }
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
                DataType x_ = Cystectomy?.Performed;
                object y_ = FHIRHelpers_4_4_000.Instance.ToValue(context, x_);
                bool z_ = y_ is CqlDateTime;
                if (z_)
                {
                    DataType aa_ = Cystectomy?.Performed;
                    object ab_ = FHIRHelpers_4_4_000.Instance.ToValue(context, aa_);
                    k_ = ab_ as CqlDateTime;
                }
                else
                {
                    DataType ac_ = Cystectomy?.Performed;
                    object ad_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ac_);
                    bool ae_ = ad_ is CqlQuantity;
                    if (ae_)
                    {
                        DataType af_ = Cystectomy?.Performed;
                        object ag_ = FHIRHelpers_4_4_000.Instance.ToValue(context, af_);
                        k_ = ag_ as CqlQuantity;
                    }
                    else
                    {
                        DataType ah_ = Cystectomy?.Performed;
                        object ai_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ah_);
                        bool aj_ = ai_ is CqlInterval<CqlDateTime>;
                        if (aj_)
                        {
                            DataType ak_ = Cystectomy?.Performed;
                            object al_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ak_);
                            k_ = al_ as CqlInterval<CqlDateTime>;
                        }
                        else
                        {
                            DataType am_ = Cystectomy?.Performed;
                            object an_ = FHIRHelpers_4_4_000.Instance.ToValue(context, am_);
                            bool ao_ = an_ is CqlInterval<CqlQuantity>;
                            if (ao_)
                            {
                                DataType ap_ = Cystectomy?.Performed;
                                object aq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ap_);
                                k_ = aq_ as CqlInterval<CqlQuantity>;
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
                DataType ar_ = FirstBladderCancerStaging?.Performed;
                object as_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ar_);
                bool at_ = as_ is CqlDateTime;
                if (at_)
                {
                    DataType au_ = FirstBladderCancerStaging?.Performed;
                    object av_ = FHIRHelpers_4_4_000.Instance.ToValue(context, au_);
                    n_ = av_ as CqlDateTime;
                }
                else
                {
                    DataType aw_ = FirstBladderCancerStaging?.Performed;
                    object ax_ = FHIRHelpers_4_4_000.Instance.ToValue(context, aw_);
                    bool ay_ = ax_ is CqlQuantity;
                    if (ay_)
                    {
                        DataType az_ = FirstBladderCancerStaging?.Performed;
                        object ba_ = FHIRHelpers_4_4_000.Instance.ToValue(context, az_);
                        n_ = ba_ as CqlQuantity;
                    }
                    else
                    {
                        DataType bb_ = FirstBladderCancerStaging?.Performed;
                        object bc_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bb_);
                        bool bd_ = bc_ is CqlInterval<CqlDateTime>;
                        if (bd_)
                        {
                            DataType be_ = FirstBladderCancerStaging?.Performed;
                            object bf_ = FHIRHelpers_4_4_000.Instance.ToValue(context, be_);
                            n_ = bf_ as CqlInterval<CqlDateTime>;
                        }
                        else
                        {
                            DataType bg_ = FirstBladderCancerStaging?.Performed;
                            object bh_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bg_);
                            bool bi_ = bh_ is CqlInterval<CqlQuantity>;
                            if (bi_)
                            {
                                DataType bj_ = FirstBladderCancerStaging?.Performed;
                                object bk_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bj_);
                                n_ = bk_ as CqlInterval<CqlQuantity>;
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
                DataType bl_ = FirstBladderCancerStaging?.Performed;
                object bm_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bl_);
                bool bn_ = bm_ is CqlDateTime;
                if (bn_)
                {
                    DataType bo_ = FirstBladderCancerStaging?.Performed;
                    object bp_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bo_);
                    s_ = bp_ as CqlDateTime;
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
                        s_ = bu_ as CqlQuantity;
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
                            s_ = bz_ as CqlInterval<CqlDateTime>;
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
                                s_ = ce_ as CqlInterval<CqlQuantity>;
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
                // CQL 'and' (92:17-92:142): right operand skipped when left is false
                if (w_ is false)
                {
                    return false;
                }
                else
                {
                    object cf_;
                    DataType ci_ = FirstBladderCancerStaging?.Performed;
                    object cj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ci_);
                    bool ck_ = cj_ is CqlDateTime;
                    if (ck_)
                    {
                        DataType cl_ = FirstBladderCancerStaging?.Performed;
                        object cm_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cl_);
                        cf_ = cm_ as CqlDateTime;
                    }
                    else
                    {
                        DataType cn_ = FirstBladderCancerStaging?.Performed;
                        object co_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cn_);
                        bool cp_ = co_ is CqlQuantity;
                        if (cp_)
                        {
                            DataType cq_ = FirstBladderCancerStaging?.Performed;
                            object cr_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cq_);
                            cf_ = cr_ as CqlQuantity;
                        }
                        else
                        {
                            DataType cs_ = FirstBladderCancerStaging?.Performed;
                            object ct_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cs_);
                            bool cu_ = ct_ is CqlInterval<CqlDateTime>;
                            if (cu_)
                            {
                                DataType cv_ = FirstBladderCancerStaging?.Performed;
                                object cw_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cv_);
                                cf_ = cw_ as CqlInterval<CqlDateTime>;
                            }
                            else
                            {
                                DataType cx_ = FirstBladderCancerStaging?.Performed;
                                object cy_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cx_);
                                bool cz_ = cy_ is CqlInterval<CqlQuantity>;
                                if (cz_)
                                {
                                    DataType da_ = FirstBladderCancerStaging?.Performed;
                                    object db_ = FHIRHelpers_4_4_000.Instance.ToValue(context, da_);
                                    cf_ = db_ as CqlInterval<CqlQuantity>;
                                }
                                else
                                {
                                    cf_ = null;
                                }
                            }
                        }
                    }
                    CqlInterval<CqlDateTime> cg_ = QICoreCommon_4_0_000.Instance.toInterval(context, cf_);
                    CqlDateTime ch_ = context.Operators.Start(cg_);
                    return w_ & (!((bool?)(ch_ is null)));
                }
            }

            bool? j_ = context.Operators.WhereAny<Procedure>((IEnumerable<Procedure>)h_, i_);
            return j_;
        }

        IEnumerable<Procedure> d_ = context.Operators.Where<Procedure>(b_, c_);

        bool? e_(Procedure Cystectomy) {
            Code<EventStatus> dc_ = Cystectomy?.StatusElement;
            EventStatus? dd_ = dc_?.Value;
            string de_ = context.Operators.Convert<string>(dd_);
            bool? df_ = context.Operators.Equal(de_, "completed");
            return df_;
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
                DataType ac_ = FirstBladderCancerStaging?.Performed;
                object ad_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ac_);
                bool ae_ = ad_ is CqlDateTime;
                if (ae_)
                {
                    DataType af_ = FirstBladderCancerStaging?.Performed;
                    object ag_ = FHIRHelpers_4_4_000.Instance.ToValue(context, af_);
                    y_ = ag_ as CqlDateTime;
                }
                else
                {
                    DataType ah_ = FirstBladderCancerStaging?.Performed;
                    object ai_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ah_);
                    bool aj_ = ai_ is CqlQuantity;
                    if (aj_)
                    {
                        DataType ak_ = FirstBladderCancerStaging?.Performed;
                        object al_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ak_);
                        y_ = al_ as CqlQuantity;
                    }
                    else
                    {
                        DataType am_ = FirstBladderCancerStaging?.Performed;
                        object an_ = FHIRHelpers_4_4_000.Instance.ToValue(context, am_);
                        bool ao_ = an_ is CqlInterval<CqlDateTime>;
                        if (ao_)
                        {
                            DataType ap_ = FirstBladderCancerStaging?.Performed;
                            object aq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ap_);
                            y_ = aq_ as CqlInterval<CqlDateTime>;
                        }
                        else
                        {
                            DataType ar_ = FirstBladderCancerStaging?.Performed;
                            object as_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ar_);
                            bool at_ = as_ is CqlInterval<CqlQuantity>;
                            if (at_)
                            {
                                DataType au_ = FirstBladderCancerStaging?.Performed;
                                object av_ = FHIRHelpers_4_4_000.Instance.ToValue(context, au_);
                                y_ = av_ as CqlInterval<CqlQuantity>;
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
                // CQL 'or' (106:19-108:9): right operand skipped when left is true
                if (ab_ is true)
                {
                    return true;
                }
                else
                {
                    DataType aw_ = ExclusionDiagnosis?.Onset;
                    object ax_ = FHIRHelpers_4_4_000.Instance.ToValue(context, aw_);
                    CqlInterval<CqlDateTime> ay_ = QICoreCommon_4_0_000.Instance.toInterval(context, ax_);
                    CqlDateTime az_ = context.Operators.Start(ay_);
                    object ba_;
                    DataType be_ = FirstBladderCancerStaging?.Performed;
                    object bf_ = FHIRHelpers_4_4_000.Instance.ToValue(context, be_);
                    bool bg_ = bf_ is CqlDateTime;
                    if (bg_)
                    {
                        DataType bh_ = FirstBladderCancerStaging?.Performed;
                        object bi_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bh_);
                        ba_ = bi_ as CqlDateTime;
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
                            ba_ = bn_ as CqlQuantity;
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
                                ba_ = bs_ as CqlInterval<CqlDateTime>;
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
                                    ba_ = bx_ as CqlInterval<CqlQuantity>;
                                }
                                else
                                {
                                    ba_ = null;
                                }
                            }
                        }
                    }
                    CqlInterval<CqlDateTime> bb_ = QICoreCommon_4_0_000.Instance.toInterval(context, ba_);
                    CqlDateTime bc_ = context.Operators.Start(bb_);
                    bool? bd_ = context.Operators.SameOrBefore(az_, bc_, "day");
                    return ab_ | bd_;
                }
            }

            bool? v_ = context.Operators.WhereAny<Procedure>((IEnumerable<Procedure>)t_, u_);
            return v_;
        }

        IEnumerable<Condition> p_ = context.Operators.Where<Condition>(n_, o_);

        bool? q_(Condition ExclusionDiagnosis) {
            bool? by_ = this.isVerified(context, ExclusionDiagnosis);
            return by_;
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
                object w_ = context.Operators.LateBoundProperty<object>(M, "id.value");
                object x_ = context.Operators.LateBoundProperty<object>(MR, "medication.reference.value");
                IEnumerable<string> y_ = context.Operators.Split((string)x_, "/");
                string z_ = context.Operators.Last<string>(y_);
                bool? aa_ = context.Operators.Equal(w_, z_);
                // CQL 'and': right operand skipped when left is false
                if (aa_ is false)
                {
                    return false;
                }
                else
                {
                    CodeableConcept ab_ = M?.Code;
                    CqlConcept ac_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, ab_);
                    CqlValueSet ad_ = this.Chemotherapy_Agents_for_Advanced_Cancer(context);
                    bool? ae_ = context.Operators.ConceptInValueSet(ac_, ad_);
                    return aa_ & ae_;
                }
            }

            bool? v_ = context.Operators.WhereAny<Medication>(t_, u_);
            return v_;
        }

        IEnumerable<MedicationRequest> c_ = context.Operators.Where<MedicationRequest>(a_, b_);
        CqlValueSet d_ = this.Chemotherapy_Agents_for_Advanced_Cancer(context);
        IEnumerable<MedicationRequest> e_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, d_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> f_ = context.Operators.Union<MedicationRequest>(c_, e_);

        bool? g_(MedicationRequest ExclusionMed) {
            Procedure af_ = this.First_Bladder_Cancer_Staging_Procedure(context);
            Procedure[] ag_ = [
                af_,
            ];

            bool? ah_(Procedure FirstBladderCancerStaging) {
                List<Dosage> aj_ = ExclusionMed?.DosageInstruction;

                bool? ak_(Dosage @this) {
                    Timing bk_ = @this?.Timing;
                    return !((bool?)(bk_ is null));
                }


                Timing al_(Dosage @this) {
                    Timing bl_ = @this?.Timing;
                    return bl_;
                }

                IEnumerable<Timing> am_ = context.Operators.WhereSelect<Dosage, Timing>((IEnumerable<Dosage>)aj_, ak_, al_);

                bool? an_(Timing @this) {
                    Timing.RepeatComponent bm_ = @this?.Repeat;
                    return !((bool?)(bm_ is null));
                }


                Timing.RepeatComponent ao_(Timing @this) {
                    Timing.RepeatComponent bn_ = @this?.Repeat;
                    return bn_;
                }

                IEnumerable<Timing.RepeatComponent> ap_ = context.Operators.WhereSelect<Timing, Timing.RepeatComponent>(am_, an_, ao_);

                bool? aq_(Timing.RepeatComponent @this) {
                    DataType bo_ = @this?.Bounds;
                    object bp_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bo_);
                    return !((bool?)(bp_ is null));
                }


                object ar_(Timing.RepeatComponent @this) {
                    DataType bq_ = @this?.Bounds;
                    object br_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bq_);
                    return br_;
                }

                IEnumerable<object> as_ = context.Operators.WhereSelect<Timing.RepeatComponent, object>(ap_, aq_, ar_);

                CqlInterval<CqlDateTime> at_(object DoseTime) {
                    CqlInterval<CqlDateTime> bs_ = QICoreCommon_4_0_000.Instance.toInterval(context, DoseTime);
                    return bs_;
                }

                IEnumerable<CqlInterval<CqlDateTime>> au_ = context.Operators.SelectDistinct<object, CqlInterval<CqlDateTime>>(as_, at_);
                IEnumerable<CqlInterval<CqlDateTime>> av_ = context.Operators.Collapse(au_, (string)default);

                object aw_(CqlInterval<CqlDateTime> @this) {
                    CqlDateTime bt_ = context.Operators.Start(@this);
                    return bt_;
                }

                IEnumerable<CqlInterval<CqlDateTime>> ax_ = context.Operators.SortBy<CqlInterval<CqlDateTime>>(av_, aw_, System.ComponentModel.ListSortDirection.Ascending);
                CqlInterval<CqlDateTime> ay_ = context.Operators.First<CqlInterval<CqlDateTime>>(ax_);
                CqlDateTime az_ = context.Operators.Start(ay_);
                object ba_;
                DataType bu_ = FirstBladderCancerStaging?.Performed;
                object bv_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bu_);
                bool bw_ = bv_ is CqlDateTime;
                if (bw_)
                {
                    DataType bx_ = FirstBladderCancerStaging?.Performed;
                    object by_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bx_);
                    ba_ = by_ as CqlDateTime;
                }
                else
                {
                    DataType bz_ = FirstBladderCancerStaging?.Performed;
                    object ca_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bz_);
                    bool cb_ = ca_ is CqlQuantity;
                    if (cb_)
                    {
                        DataType cc_ = FirstBladderCancerStaging?.Performed;
                        object cd_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cc_);
                        ba_ = cd_ as CqlQuantity;
                    }
                    else
                    {
                        DataType ce_ = FirstBladderCancerStaging?.Performed;
                        object cf_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ce_);
                        bool cg_ = cf_ is CqlInterval<CqlDateTime>;
                        if (cg_)
                        {
                            DataType ch_ = FirstBladderCancerStaging?.Performed;
                            object ci_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ch_);
                            ba_ = ci_ as CqlInterval<CqlDateTime>;
                        }
                        else
                        {
                            DataType cj_ = FirstBladderCancerStaging?.Performed;
                            object ck_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cj_);
                            bool cl_ = ck_ is CqlInterval<CqlQuantity>;
                            if (cl_)
                            {
                                DataType cm_ = FirstBladderCancerStaging?.Performed;
                                object cn_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cm_);
                                ba_ = cn_ as CqlInterval<CqlQuantity>;
                            }
                            else
                            {
                                ba_ = null;
                            }
                        }
                    }
                }
                CqlInterval<CqlDateTime> bb_ = QICoreCommon_4_0_000.Instance.toInterval(context, ba_);
                CqlDateTime bc_ = context.Operators.Start(bb_);
                CqlQuantity bd_ = context.Operators.Quantity(6m, "months");
                CqlDateTime be_ = context.Operators.Subtract(bc_, bd_);
                object bf_;
                DataType co_ = FirstBladderCancerStaging?.Performed;
                object cp_ = FHIRHelpers_4_4_000.Instance.ToValue(context, co_);
                bool cq_ = cp_ is CqlDateTime;
                if (cq_)
                {
                    DataType cr_ = FirstBladderCancerStaging?.Performed;
                    object cs_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cr_);
                    bf_ = cs_ as CqlDateTime;
                }
                else
                {
                    DataType ct_ = FirstBladderCancerStaging?.Performed;
                    object cu_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ct_);
                    bool cv_ = cu_ is CqlQuantity;
                    if (cv_)
                    {
                        DataType cw_ = FirstBladderCancerStaging?.Performed;
                        object cx_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cw_);
                        bf_ = cx_ as CqlQuantity;
                    }
                    else
                    {
                        DataType cy_ = FirstBladderCancerStaging?.Performed;
                        object cz_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cy_);
                        bool da_ = cz_ is CqlInterval<CqlDateTime>;
                        if (da_)
                        {
                            DataType db_ = FirstBladderCancerStaging?.Performed;
                            object dc_ = FHIRHelpers_4_4_000.Instance.ToValue(context, db_);
                            bf_ = dc_ as CqlInterval<CqlDateTime>;
                        }
                        else
                        {
                            DataType dd_ = FirstBladderCancerStaging?.Performed;
                            object de_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dd_);
                            bool df_ = de_ is CqlInterval<CqlQuantity>;
                            if (df_)
                            {
                                DataType dg_ = FirstBladderCancerStaging?.Performed;
                                object dh_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dg_);
                                bf_ = dh_ as CqlInterval<CqlQuantity>;
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
                CqlInterval<CqlDateTime> bi_ = context.Operators.Interval(be_, bh_, true, false);
                bool? bj_ = context.Operators.In<CqlDateTime>(az_, bi_, (string)default);
                // CQL 'and' (120:21-120:123): right operand skipped when left is false
                if (bj_ is false)
                {
                    return false;
                }
                else
                {
                    object di_;
                    DataType dl_ = FirstBladderCancerStaging?.Performed;
                    object dm_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dl_);
                    bool dn_ = dm_ is CqlDateTime;
                    if (dn_)
                    {
                        DataType do_ = FirstBladderCancerStaging?.Performed;
                        object dp_ = FHIRHelpers_4_4_000.Instance.ToValue(context, do_);
                        di_ = dp_ as CqlDateTime;
                    }
                    else
                    {
                        DataType dq_ = FirstBladderCancerStaging?.Performed;
                        object dr_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dq_);
                        bool ds_ = dr_ is CqlQuantity;
                        if (ds_)
                        {
                            DataType dt_ = FirstBladderCancerStaging?.Performed;
                            object du_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dt_);
                            di_ = du_ as CqlQuantity;
                        }
                        else
                        {
                            DataType dv_ = FirstBladderCancerStaging?.Performed;
                            object dw_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dv_);
                            bool dx_ = dw_ is CqlInterval<CqlDateTime>;
                            if (dx_)
                            {
                                DataType dy_ = FirstBladderCancerStaging?.Performed;
                                object dz_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dy_);
                                di_ = dz_ as CqlInterval<CqlDateTime>;
                            }
                            else
                            {
                                DataType ea_ = FirstBladderCancerStaging?.Performed;
                                object eb_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ea_);
                                bool ec_ = eb_ is CqlInterval<CqlQuantity>;
                                if (ec_)
                                {
                                    DataType ed_ = FirstBladderCancerStaging?.Performed;
                                    object ee_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ed_);
                                    di_ = ee_ as CqlInterval<CqlQuantity>;
                                }
                                else
                                {
                                    di_ = null;
                                }
                            }
                        }
                    }
                    CqlInterval<CqlDateTime> dj_ = QICoreCommon_4_0_000.Instance.toInterval(context, di_);
                    CqlDateTime dk_ = context.Operators.Start(dj_);
                    return bj_ & (!((bool?)(dk_ is null)));
                }
            }

            bool? ai_ = context.Operators.WhereAny<Procedure>((IEnumerable<Procedure>)ag_, ah_);
            return ai_;
        }

        IEnumerable<MedicationRequest> h_ = context.Operators.Where<MedicationRequest>(f_, g_);

        bool? i_(MedicationRequest ExclusionMed) {
            Code<MedicationRequest.MedicationrequestStatus> ef_ = ExclusionMed?.StatusElement;
            MedicationRequest.MedicationrequestStatus? eg_ = ef_?.Value;
            string eh_ = context.Operators.Convert<string>(eg_);
            string[] ei_ = [
                "active",
                "completed",
            ];
            bool? ej_ = context.Operators.In<string>(eh_, (IEnumerable<string>)ei_);
            // CQL 'and' (121:9-122:43): right operand skipped when left is false
            if (ej_ is false)
            {
                return false;
            }
            else
            {
                Code<MedicationRequest.MedicationRequestIntent> ek_ = ExclusionMed?.IntentElement;
                MedicationRequest.MedicationRequestIntent? el_ = ek_?.Value;
                string em_ = context.Operators.Convert<string>(el_);
                bool? en_ = context.Operators.Equal(em_, "order");
                return ej_ & en_;
            }
        }

        IEnumerable<MedicationRequest> j_ = context.Operators.Where<MedicationRequest>(h_, i_);
        CqlCode k_ = this.Combined_radiotherapy__procedure_(context);
        IEnumerable<CqlCode> l_ = context.Operators.ToList<CqlCode>(k_);
        IEnumerable<Procedure> m_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, default, l_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));

        bool? n_(Procedure ExclusionProcedure) {
            Procedure eo_ = this.First_Bladder_Cancer_Staging_Procedure(context);
            Procedure[] ep_ = [
                eo_,
            ];

            bool? eq_(Procedure FirstBladderCancerStaging) {
                object es_;
                DataType ff_ = ExclusionProcedure?.Performed;
                object fg_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ff_);
                bool fh_ = fg_ is CqlDateTime;
                if (fh_)
                {
                    DataType fi_ = ExclusionProcedure?.Performed;
                    object fj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fi_);
                    es_ = fj_ as CqlDateTime;
                }
                else
                {
                    DataType fk_ = ExclusionProcedure?.Performed;
                    object fl_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fk_);
                    bool fm_ = fl_ is CqlQuantity;
                    if (fm_)
                    {
                        DataType fn_ = ExclusionProcedure?.Performed;
                        object fo_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fn_);
                        es_ = fo_ as CqlQuantity;
                    }
                    else
                    {
                        DataType fp_ = ExclusionProcedure?.Performed;
                        object fq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fp_);
                        bool fr_ = fq_ is CqlInterval<CqlDateTime>;
                        if (fr_)
                        {
                            DataType fs_ = ExclusionProcedure?.Performed;
                            object ft_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fs_);
                            es_ = ft_ as CqlInterval<CqlDateTime>;
                        }
                        else
                        {
                            DataType fu_ = ExclusionProcedure?.Performed;
                            object fv_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fu_);
                            bool fw_ = fv_ is CqlInterval<CqlQuantity>;
                            if (fw_)
                            {
                                DataType fx_ = ExclusionProcedure?.Performed;
                                object fy_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fx_);
                                es_ = fy_ as CqlInterval<CqlQuantity>;
                            }
                            else
                            {
                                es_ = null;
                            }
                        }
                    }
                }
                CqlInterval<CqlDateTime> et_ = QICoreCommon_4_0_000.Instance.toInterval(context, es_);
                CqlDateTime eu_ = context.Operators.Start(et_);
                object ev_;
                DataType fz_ = FirstBladderCancerStaging?.Performed;
                object ga_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fz_);
                bool gb_ = ga_ is CqlDateTime;
                if (gb_)
                {
                    DataType gc_ = FirstBladderCancerStaging?.Performed;
                    object gd_ = FHIRHelpers_4_4_000.Instance.ToValue(context, gc_);
                    ev_ = gd_ as CqlDateTime;
                }
                else
                {
                    DataType ge_ = FirstBladderCancerStaging?.Performed;
                    object gf_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ge_);
                    bool gg_ = gf_ is CqlQuantity;
                    if (gg_)
                    {
                        DataType gh_ = FirstBladderCancerStaging?.Performed;
                        object gi_ = FHIRHelpers_4_4_000.Instance.ToValue(context, gh_);
                        ev_ = gi_ as CqlQuantity;
                    }
                    else
                    {
                        DataType gj_ = FirstBladderCancerStaging?.Performed;
                        object gk_ = FHIRHelpers_4_4_000.Instance.ToValue(context, gj_);
                        bool gl_ = gk_ is CqlInterval<CqlDateTime>;
                        if (gl_)
                        {
                            DataType gm_ = FirstBladderCancerStaging?.Performed;
                            object gn_ = FHIRHelpers_4_4_000.Instance.ToValue(context, gm_);
                            ev_ = gn_ as CqlInterval<CqlDateTime>;
                        }
                        else
                        {
                            DataType go_ = FirstBladderCancerStaging?.Performed;
                            object gp_ = FHIRHelpers_4_4_000.Instance.ToValue(context, go_);
                            bool gq_ = gp_ is CqlInterval<CqlQuantity>;
                            if (gq_)
                            {
                                DataType gr_ = FirstBladderCancerStaging?.Performed;
                                object gs_ = FHIRHelpers_4_4_000.Instance.ToValue(context, gr_);
                                ev_ = gs_ as CqlInterval<CqlQuantity>;
                            }
                            else
                            {
                                ev_ = null;
                            }
                        }
                    }
                }
                CqlInterval<CqlDateTime> ew_ = QICoreCommon_4_0_000.Instance.toInterval(context, ev_);
                CqlDateTime ex_ = context.Operators.Start(ew_);
                CqlQuantity ey_ = context.Operators.Quantity(6m, "months");
                CqlDateTime ez_ = context.Operators.Subtract(ex_, ey_);
                object fa_;
                DataType gt_ = FirstBladderCancerStaging?.Performed;
                object gu_ = FHIRHelpers_4_4_000.Instance.ToValue(context, gt_);
                bool gv_ = gu_ is CqlDateTime;
                if (gv_)
                {
                    DataType gw_ = FirstBladderCancerStaging?.Performed;
                    object gx_ = FHIRHelpers_4_4_000.Instance.ToValue(context, gw_);
                    fa_ = gx_ as CqlDateTime;
                }
                else
                {
                    DataType gy_ = FirstBladderCancerStaging?.Performed;
                    object gz_ = FHIRHelpers_4_4_000.Instance.ToValue(context, gy_);
                    bool ha_ = gz_ is CqlQuantity;
                    if (ha_)
                    {
                        DataType hb_ = FirstBladderCancerStaging?.Performed;
                        object hc_ = FHIRHelpers_4_4_000.Instance.ToValue(context, hb_);
                        fa_ = hc_ as CqlQuantity;
                    }
                    else
                    {
                        DataType hd_ = FirstBladderCancerStaging?.Performed;
                        object he_ = FHIRHelpers_4_4_000.Instance.ToValue(context, hd_);
                        bool hf_ = he_ is CqlInterval<CqlDateTime>;
                        if (hf_)
                        {
                            DataType hg_ = FirstBladderCancerStaging?.Performed;
                            object hh_ = FHIRHelpers_4_4_000.Instance.ToValue(context, hg_);
                            fa_ = hh_ as CqlInterval<CqlDateTime>;
                        }
                        else
                        {
                            DataType hi_ = FirstBladderCancerStaging?.Performed;
                            object hj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, hi_);
                            bool hk_ = hj_ is CqlInterval<CqlQuantity>;
                            if (hk_)
                            {
                                DataType hl_ = FirstBladderCancerStaging?.Performed;
                                object hm_ = FHIRHelpers_4_4_000.Instance.ToValue(context, hl_);
                                fa_ = hm_ as CqlInterval<CqlQuantity>;
                            }
                            else
                            {
                                fa_ = null;
                            }
                        }
                    }
                }
                CqlInterval<CqlDateTime> fb_ = QICoreCommon_4_0_000.Instance.toInterval(context, fa_);
                CqlDateTime fc_ = context.Operators.Start(fb_);
                CqlInterval<CqlDateTime> fd_ = context.Operators.Interval(ez_, fc_, true, false);
                bool? fe_ = context.Operators.In<CqlDateTime>(eu_, fd_, (string)default);
                // CQL 'and' (126:23-126:147): right operand skipped when left is false
                if (fe_ is false)
                {
                    return false;
                }
                else
                {
                    object hn_;
                    DataType hq_ = FirstBladderCancerStaging?.Performed;
                    object hr_ = FHIRHelpers_4_4_000.Instance.ToValue(context, hq_);
                    bool hs_ = hr_ is CqlDateTime;
                    if (hs_)
                    {
                        DataType ht_ = FirstBladderCancerStaging?.Performed;
                        object hu_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ht_);
                        hn_ = hu_ as CqlDateTime;
                    }
                    else
                    {
                        DataType hv_ = FirstBladderCancerStaging?.Performed;
                        object hw_ = FHIRHelpers_4_4_000.Instance.ToValue(context, hv_);
                        bool hx_ = hw_ is CqlQuantity;
                        if (hx_)
                        {
                            DataType hy_ = FirstBladderCancerStaging?.Performed;
                            object hz_ = FHIRHelpers_4_4_000.Instance.ToValue(context, hy_);
                            hn_ = hz_ as CqlQuantity;
                        }
                        else
                        {
                            DataType ia_ = FirstBladderCancerStaging?.Performed;
                            object ib_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ia_);
                            bool ic_ = ib_ is CqlInterval<CqlDateTime>;
                            if (ic_)
                            {
                                DataType id_ = FirstBladderCancerStaging?.Performed;
                                object ie_ = FHIRHelpers_4_4_000.Instance.ToValue(context, id_);
                                hn_ = ie_ as CqlInterval<CqlDateTime>;
                            }
                            else
                            {
                                DataType if_ = FirstBladderCancerStaging?.Performed;
                                object ig_ = FHIRHelpers_4_4_000.Instance.ToValue(context, if_);
                                bool ih_ = ig_ is CqlInterval<CqlQuantity>;
                                if (ih_)
                                {
                                    DataType ii_ = FirstBladderCancerStaging?.Performed;
                                    object ij_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ii_);
                                    hn_ = ij_ as CqlInterval<CqlQuantity>;
                                }
                                else
                                {
                                    hn_ = null;
                                }
                            }
                        }
                    }
                    CqlInterval<CqlDateTime> ho_ = QICoreCommon_4_0_000.Instance.toInterval(context, hn_);
                    CqlDateTime hp_ = context.Operators.Start(ho_);
                    return fe_ & (!((bool?)(hp_ is null)));
                }
            }

            bool? er_ = context.Operators.WhereAny<Procedure>((IEnumerable<Procedure>)ep_, eq_);
            return er_;
        }

        IEnumerable<Procedure> o_ = context.Operators.Where<Procedure>(m_, n_);

        bool? p_(Procedure ExclusionProcedure) {
            Code<EventStatus> ik_ = ExclusionProcedure?.StatusElement;
            EventStatus? il_ = ik_?.Value;
            string im_ = context.Operators.Convert<string>(il_);
            string[] in_ = [
                "completed",
                "in-progress",
            ];
            bool? io_ = context.Operators.In<string>(im_, (IEnumerable<string>)in_);
            return io_;
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
        bool? c_;
        // CQL 'or' (46:3-47:39): right operand skipped when left is true
        if (b_ is true)
        {
            c_ = true;
        }
        else
        {
            IEnumerable<MedicationRequest> f_ = this.Immunosuppressive_Drugs(context);
            bool? g_ = context.Operators.Exists<MedicationRequest>(f_);
            c_ = b_ | g_;
        }
        bool? d_;
        // CQL 'or' (46:3-48:31): right operand skipped when left is true
        if (c_ is true)
        {
            d_ = true;
        }
        else
        {
            IEnumerable<Procedure> h_ = this.Cystectomy_Done(context);
            bool? i_ = context.Operators.Exists<Procedure>(h_);
            d_ = c_ | i_;
        }
        bool? e_;
        // CQL 'or' (46:3-49:90): right operand skipped when left is true
        if (d_ is true)
        {
            e_ = true;
        }
        else
        {
            bool? j_ = this.Has_Excluding_HIV__Immunocompromised_Conditions_or_Mixed_Histology_Before_Staging(context);
            e_ = d_ | j_;
        }
        // CQL 'or' (46:3-50:76): right operand skipped when left is true
        if (e_ is true)
        {
            return true;
        }
        else
        {
            bool? k_ = this.Has_Excluding_Chemotherapy_or_Radiotherapy_Procedure_Before_Staging(context);
            return e_ | k_;
        }
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
                    FhirUri ab_ = @this?.UrlElement;
                    string ac_ = FHIRHelpers_4_4_000.Instance.ToString(context, ab_);
                    bool? ad_ = context.Operators.Equal(ac_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-recorded");
                    return ad_;
                }


                DataType m_(Extension @this) {
                    DataType ae_ = @this?.Value;
                    return ae_;
                }

                IEnumerable<DataType> n_ = context.Operators.WhereSelect<Extension, DataType>((IEnumerable<Extension>)(BCGNotGiven is DomainResource
                    ? (BCGNotGiven as DomainResource).Extension
                    : default), l_, m_);
                DataType o_ = context.Operators.SingletonFrom<DataType>(n_);
                FhirDateTime p_ = context.Operators.Convert<FhirDateTime>(o_);
                CqlDateTime q_ = context.Operators.Convert<CqlDateTime>(p_);
                object r_;
                DataType af_ = FirstBladderCancerStaging?.Performed;
                object ag_ = FHIRHelpers_4_4_000.Instance.ToValue(context, af_);
                bool ah_ = ag_ is CqlDateTime;
                if (ah_)
                {
                    DataType ai_ = FirstBladderCancerStaging?.Performed;
                    object aj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ai_);
                    r_ = aj_ as CqlDateTime;
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
                        r_ = ao_ as CqlQuantity;
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
                            r_ = at_ as CqlInterval<CqlDateTime>;
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
                                r_ = ay_ as CqlInterval<CqlQuantity>;
                            }
                            else
                            {
                                r_ = null;
                            }
                        }
                    }
                }
                CqlInterval<CqlDateTime> s_ = QICoreCommon_4_0_000.Instance.toInterval(context, r_);
                CqlDateTime t_ = context.Operators.Start(s_);
                object u_;
                DataType az_ = FirstBladderCancerStaging?.Performed;
                object ba_ = FHIRHelpers_4_4_000.Instance.ToValue(context, az_);
                bool bb_ = ba_ is CqlDateTime;
                if (bb_)
                {
                    DataType bc_ = FirstBladderCancerStaging?.Performed;
                    object bd_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bc_);
                    u_ = bd_ as CqlDateTime;
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
                        u_ = bi_ as CqlQuantity;
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
                            u_ = bn_ as CqlInterval<CqlDateTime>;
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
                                u_ = bs_ as CqlInterval<CqlQuantity>;
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
                CqlQuantity x_ = context.Operators.Quantity(6m, "months");
                CqlDateTime y_ = context.Operators.Add(w_, x_);
                CqlInterval<CqlDateTime> z_ = context.Operators.Interval(t_, y_, false, true);
                bool? aa_ = context.Operators.In<CqlDateTime>(q_, z_, "day");
                // CQL 'and' (157:17-157:126): right operand skipped when left is false
                if (aa_ is false)
                {
                    return false;
                }
                else
                {
                    object bt_;
                    DataType bw_ = FirstBladderCancerStaging?.Performed;
                    object bx_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bw_);
                    bool by_ = bx_ is CqlDateTime;
                    if (by_)
                    {
                        DataType bz_ = FirstBladderCancerStaging?.Performed;
                        object ca_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bz_);
                        bt_ = ca_ as CqlDateTime;
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
                            bt_ = cf_ as CqlQuantity;
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
                                bt_ = ck_ as CqlInterval<CqlDateTime>;
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
                                    bt_ = cp_ as CqlInterval<CqlQuantity>;
                                }
                                else
                                {
                                    bt_ = null;
                                }
                            }
                        }
                    }
                    CqlInterval<CqlDateTime> bu_ = QICoreCommon_4_0_000.Instance.toInterval(context, bt_);
                    CqlDateTime bv_ = context.Operators.Start(bu_);
                    return aa_ & (!((bool?)(bv_ is null)));
                }
            }

            bool? k_ = context.Operators.WhereAny<Procedure>((IEnumerable<Procedure>)i_, j_);
            return k_;
        }

        IEnumerable<MedicationAdministration> e_ = context.Operators.Where<MedicationAdministration>(c_, d_);

        bool? f_(MedicationAdministration BCGNotGiven) {
            List<CodeableConcept> cq_ = BCGNotGiven?.StatusReason;

            CqlConcept cr_(CodeableConcept @this) {
                CqlConcept cv_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);
                return cv_;
            }

            IEnumerable<CqlConcept> cs_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)cq_, cr_);
            CqlValueSet ct_ = this.Unavailability_of_Bacillus_Calmette_Guerin_for_Urology_Care(context);
            bool? cu_ = context.Operators.ConceptsInValueSet(cs_, ct_);
            return cu_;
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
                object q_ = context.Operators.LateBoundProperty<object>(M, "id.value");
                object r_ = context.Operators.LateBoundProperty<object>(MR, "medication.reference.value");
                IEnumerable<string> s_ = context.Operators.Split((string)r_, "/");
                string t_ = context.Operators.Last<string>(s_);
                bool? u_ = context.Operators.Equal(q_, t_);
                // CQL 'and': right operand skipped when left is false
                if (u_ is false)
                {
                    return false;
                }
                else
                {
                    CodeableConcept v_ = M?.Code;
                    CqlConcept w_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, v_);
                    CqlValueSet x_ = this.Bacillus_Calmette_Guerin_for_Urology_Care(context);
                    bool? y_ = context.Operators.ConceptInValueSet(w_, x_);
                    return u_ & y_;
                }
            }

            bool? p_ = context.Operators.WhereAny<Medication>(n_, o_);
            return p_;
        }

        IEnumerable<MedicationAdministration> c_ = context.Operators.Where<MedicationAdministration>(a_, b_);
        CqlValueSet d_ = this.Bacillus_Calmette_Guerin_for_Urology_Care(context);
        IEnumerable<MedicationAdministration> e_ = context.Operators.Retrieve<MedicationAdministration>(new RetrieveParameters(default, d_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationadministration"));
        IEnumerable<MedicationAdministration> f_ = context.Operators.Union<MedicationAdministration>(c_, e_);

        bool? g_(MedicationAdministration BCG) {
            Procedure z_ = this.First_Bladder_Cancer_Staging_Procedure(context);
            Procedure[] aa_ = [
                z_,
            ];

            bool? ab_(Procedure FirstBladderCancerStaging) {
                DataType ad_ = BCG?.Effective;
                object ae_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ad_);
                CqlInterval<CqlDateTime> af_ = QICoreCommon_4_0_000.Instance.toInterval(context, ae_);
                CqlDateTime ag_ = context.Operators.Start(af_);
                object ah_;
                DataType as_ = FirstBladderCancerStaging?.Performed;
                object at_ = FHIRHelpers_4_4_000.Instance.ToValue(context, as_);
                bool au_ = at_ is CqlDateTime;
                if (au_)
                {
                    DataType av_ = FirstBladderCancerStaging?.Performed;
                    object aw_ = FHIRHelpers_4_4_000.Instance.ToValue(context, av_);
                    ah_ = aw_ as CqlDateTime;
                }
                else
                {
                    DataType ax_ = FirstBladderCancerStaging?.Performed;
                    object ay_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ax_);
                    bool az_ = ay_ is CqlQuantity;
                    if (az_)
                    {
                        DataType ba_ = FirstBladderCancerStaging?.Performed;
                        object bb_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ba_);
                        ah_ = bb_ as CqlQuantity;
                    }
                    else
                    {
                        DataType bc_ = FirstBladderCancerStaging?.Performed;
                        object bd_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bc_);
                        bool be_ = bd_ is CqlInterval<CqlDateTime>;
                        if (be_)
                        {
                            DataType bf_ = FirstBladderCancerStaging?.Performed;
                            object bg_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bf_);
                            ah_ = bg_ as CqlInterval<CqlDateTime>;
                        }
                        else
                        {
                            DataType bh_ = FirstBladderCancerStaging?.Performed;
                            object bi_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bh_);
                            bool bj_ = bi_ is CqlInterval<CqlQuantity>;
                            if (bj_)
                            {
                                DataType bk_ = FirstBladderCancerStaging?.Performed;
                                object bl_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bk_);
                                ah_ = bl_ as CqlInterval<CqlQuantity>;
                            }
                            else
                            {
                                ah_ = null;
                            }
                        }
                    }
                }
                CqlInterval<CqlDateTime> ai_ = QICoreCommon_4_0_000.Instance.toInterval(context, ah_);
                CqlDateTime aj_ = context.Operators.Start(ai_);
                object ak_;
                DataType bm_ = FirstBladderCancerStaging?.Performed;
                object bn_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bm_);
                bool bo_ = bn_ is CqlDateTime;
                if (bo_)
                {
                    DataType bp_ = FirstBladderCancerStaging?.Performed;
                    object bq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bp_);
                    ak_ = bq_ as CqlDateTime;
                }
                else
                {
                    DataType br_ = FirstBladderCancerStaging?.Performed;
                    object bs_ = FHIRHelpers_4_4_000.Instance.ToValue(context, br_);
                    bool bt_ = bs_ is CqlQuantity;
                    if (bt_)
                    {
                        DataType bu_ = FirstBladderCancerStaging?.Performed;
                        object bv_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bu_);
                        ak_ = bv_ as CqlQuantity;
                    }
                    else
                    {
                        DataType bw_ = FirstBladderCancerStaging?.Performed;
                        object bx_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bw_);
                        bool by_ = bx_ is CqlInterval<CqlDateTime>;
                        if (by_)
                        {
                            DataType bz_ = FirstBladderCancerStaging?.Performed;
                            object ca_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bz_);
                            ak_ = ca_ as CqlInterval<CqlDateTime>;
                        }
                        else
                        {
                            DataType cb_ = FirstBladderCancerStaging?.Performed;
                            object cc_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cb_);
                            bool cd_ = cc_ is CqlInterval<CqlQuantity>;
                            if (cd_)
                            {
                                DataType ce_ = FirstBladderCancerStaging?.Performed;
                                object cf_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ce_);
                                ak_ = cf_ as CqlInterval<CqlQuantity>;
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
                CqlQuantity an_ = context.Operators.Quantity(6m, "months");
                CqlDateTime ao_ = context.Operators.Add(am_, an_);
                CqlInterval<CqlDateTime> ap_ = context.Operators.Interval(aj_, ao_, false, true);
                bool? aq_ = context.Operators.In<CqlDateTime>(ag_, ap_, "day");
                bool? ar_;
                // CQL 'and' (167:19-167:139): right operand skipped when left is false
                if (aq_ is false)
                {
                    ar_ = false;
                }
                else
                {
                    object cg_;
                    DataType cj_ = FirstBladderCancerStaging?.Performed;
                    object ck_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cj_);
                    bool cl_ = ck_ is CqlDateTime;
                    if (cl_)
                    {
                        DataType cm_ = FirstBladderCancerStaging?.Performed;
                        object cn_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cm_);
                        cg_ = cn_ as CqlDateTime;
                    }
                    else
                    {
                        DataType co_ = FirstBladderCancerStaging?.Performed;
                        object cp_ = FHIRHelpers_4_4_000.Instance.ToValue(context, co_);
                        bool cq_ = cp_ is CqlQuantity;
                        if (cq_)
                        {
                            DataType cr_ = FirstBladderCancerStaging?.Performed;
                            object cs_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cr_);
                            cg_ = cs_ as CqlQuantity;
                        }
                        else
                        {
                            DataType ct_ = FirstBladderCancerStaging?.Performed;
                            object cu_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ct_);
                            bool cv_ = cu_ is CqlInterval<CqlDateTime>;
                            if (cv_)
                            {
                                DataType cw_ = FirstBladderCancerStaging?.Performed;
                                object cx_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cw_);
                                cg_ = cx_ as CqlInterval<CqlDateTime>;
                            }
                            else
                            {
                                DataType cy_ = FirstBladderCancerStaging?.Performed;
                                object cz_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cy_);
                                bool da_ = cz_ is CqlInterval<CqlQuantity>;
                                if (da_)
                                {
                                    DataType db_ = FirstBladderCancerStaging?.Performed;
                                    object dc_ = FHIRHelpers_4_4_000.Instance.ToValue(context, db_);
                                    cg_ = dc_ as CqlInterval<CqlQuantity>;
                                }
                                else
                                {
                                    cg_ = null;
                                }
                            }
                        }
                    }
                    CqlInterval<CqlDateTime> ch_ = QICoreCommon_4_0_000.Instance.toInterval(context, cg_);
                    CqlDateTime ci_ = context.Operators.Start(ch_);
                    ar_ = aq_ & (!((bool?)(ci_ is null)));
                }
                // CQL 'and' (167:19-168:82): right operand skipped when left is false
                if (ar_ is false)
                {
                    return false;
                }
                else
                {
                    CqlInterval<CqlDateTime> dd_ = this.Measurement_Period(context);
                    bool? de_ = context.Operators.In<CqlDateTime>(ag_, dd_, "day");
                    return ar_ & de_;
                }
            }

            bool? ac_ = context.Operators.WhereAny<Procedure>((IEnumerable<Procedure>)aa_, ab_);
            return ac_;
        }

        IEnumerable<MedicationAdministration> h_ = context.Operators.Where<MedicationAdministration>(f_, g_);

        bool? i_(MedicationAdministration BCG) {
            Code<MedicationAdministration.MedicationAdministrationStatusCodes> df_ = BCG?.StatusElement;
            MedicationAdministration.MedicationAdministrationStatusCodes? dg_ = df_?.Value;
            string dh_ = context.Operators.Convert<string>(dg_);
            string[] di_ = [
                "in-progress",
                "completed",
            ];
            bool? dj_ = context.Operators.In<string>(dh_, (IEnumerable<string>)di_);
            return dj_;
        }

        IEnumerable<MedicationAdministration> j_ = context.Operators.Where<MedicationAdministration>(h_, i_);

        object k_(MedicationAdministration @this) {
            DataType dk_ = @this?.Effective;
            object dl_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dk_);
            CqlInterval<CqlDateTime> dm_ = QICoreCommon_4_0_000.Instance.toInterval(context, dl_);
            CqlDateTime dn_ = context.Operators.Start(dm_);
            return dn_;
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
        return !((bool?)(a_ is null));
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

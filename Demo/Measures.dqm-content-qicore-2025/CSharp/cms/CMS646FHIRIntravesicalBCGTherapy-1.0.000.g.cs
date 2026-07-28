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
            Procedure e_ = this.First_Bladder_Cancer_Staging_Procedure_during_6_Months_Prior_to_Measurement_Period_through_the_First_6_Months_of_Measurement_Period(context);
            Procedure[] f_ = [
                e_,
            ];

            bool? g_(Procedure FirstBladderCancerStagingMP) {
                Id j_ = FirstBladderCancerStagingMP?.IdElement;
                string k_ = j_?.Value;
                FhirString l_ = StagingReference?.ReferenceElement;
                string m_ = l_?.Value;
                string n_ = QICoreCommon_4_0_000.Instance.getId(context, m_);
                bool? o_ = context.Operators.Equal(k_, n_);
                return o_;
            }

            IEnumerable<Procedure> h_ = context.Operators.Where<Procedure>((IEnumerable<Procedure>)f_, g_);
            Procedure i_ = context.Operators.SingletonFrom<Procedure>(h_);
            return i_;
        }

        IEnumerable<Procedure> c_ = context.Operators.Select<ResourceReference, Procedure>((IEnumerable<ResourceReference>)a_, b_);
        IEnumerable<Procedure> d_ = context.Operators.Distinct<Procedure>(c_);
        return d_;
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

            CqlInterval<CqlDateTime> o_() {

                bool t_() {
                    CqlInterval<CqlDateTime> u_ = this.Measurement_Period(context);
                    CqlDateTime v_ = context.Operators.End(u_);
                    return v_ is null;
                }

                if (t_())
                {
                    return default;
                }
                else
                {
                    CqlInterval<CqlDateTime> w_ = this.Measurement_Period(context);
                    CqlDateTime x_ = context.Operators.End(w_);
                    CqlInterval<CqlDateTime> y_ = context.Operators.Interval(x_, x_, true, true);
                    return y_;
                }
            }

            bool? p_ = context.Operators.Before(n_, o_(), "day");
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

                object o_() {

                    bool u_() {
                        DataType y_ = BladderCancerStaging?.Performed;
                        object z_ = FHIRHelpers_4_4_000.Instance.ToValue(context, y_);
                        bool aa_ = z_ is CqlDateTime;
                        return aa_;
                    }


                    bool v_() {
                        DataType ab_ = BladderCancerStaging?.Performed;
                        object ac_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ab_);
                        bool ad_ = ac_ is CqlQuantity;
                        return ad_;
                    }


                    bool w_() {
                        DataType ae_ = BladderCancerStaging?.Performed;
                        object af_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ae_);
                        bool ag_ = af_ is CqlInterval<CqlDateTime>;
                        return ag_;
                    }


                    bool x_() {
                        DataType ah_ = BladderCancerStaging?.Performed;
                        object ai_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ah_);
                        bool aj_ = ai_ is CqlInterval<CqlQuantity>;
                        return aj_;
                    }

                    if (u_())
                    {
                        DataType ak_ = BladderCancerStaging?.Performed;
                        object al_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ak_);
                        return al_ as CqlDateTime;
                    }
                    else if (v_())
                    {
                        DataType am_ = BladderCancerStaging?.Performed;
                        object an_ = FHIRHelpers_4_4_000.Instance.ToValue(context, am_);
                        return an_ as CqlQuantity;
                    }
                    else if (w_())
                    {
                        DataType ao_ = BladderCancerStaging?.Performed;
                        object ap_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ao_);
                        return ap_ as CqlInterval<CqlDateTime>;
                    }
                    else if (x_())
                    {
                        DataType aq_ = BladderCancerStaging?.Performed;
                        object ar_ = FHIRHelpers_4_4_000.Instance.ToValue(context, aq_);
                        return ar_ as CqlInterval<CqlQuantity>;
                    }
                    else
                    {
                        return null;
                    }
                }

                CqlInterval<CqlDateTime> p_ = QICoreCommon_4_0_000.Instance.toInterval(context, o_());
                CqlDateTime q_ = context.Operators.Start(p_);
                CqlInterval<CqlDateTime> r_ = QICoreCommon_4_0_000.Instance.prevalenceInterval(context, BladderCancer);
                CqlDateTime s_ = context.Operators.Start(r_);
                bool? t_ = context.Operators.SameOrBefore(q_, s_, "day");
                return t_;
            }

            IEnumerable<Condition> m_ = context.Operators.Where<Condition>(k_, l_);
            bool? n_ = context.Operators.Exists<Condition>(m_);
            return n_;
        }

        IEnumerable<Procedure> e_ = context.Operators.Where<Procedure>(c_, d_);

        bool? f_(Procedure BladderCancerStaging) {
            Code<EventStatus> as_ = BladderCancerStaging?.StatusElement;
            EventStatus? at_ = as_?.Value;
            string au_ = context.Operators.Convert<string>(at_);
            bool? av_ = context.Operators.Equal(au_, "completed");
            return av_;
        }

        IEnumerable<Procedure> g_ = context.Operators.Where<Procedure>(e_, f_);

        object h_(Procedure @this) {

            object aw_() {

                bool az_() {
                    DataType bd_ = @this?.Performed;
                    object be_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bd_);
                    bool bf_ = be_ is CqlDateTime;
                    return bf_;
                }


                bool ba_() {
                    DataType bg_ = @this?.Performed;
                    object bh_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bg_);
                    bool bi_ = bh_ is CqlQuantity;
                    return bi_;
                }


                bool bb_() {
                    DataType bj_ = @this?.Performed;
                    object bk_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bj_);
                    bool bl_ = bk_ is CqlInterval<CqlDateTime>;
                    return bl_;
                }


                bool bc_() {
                    DataType bm_ = @this?.Performed;
                    object bn_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bm_);
                    bool bo_ = bn_ is CqlInterval<CqlQuantity>;
                    return bo_;
                }

                if (az_())
                {
                    DataType bp_ = @this?.Performed;
                    object bq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bp_);
                    return bq_ as CqlDateTime;
                }
                else if (ba_())
                {
                    DataType br_ = @this?.Performed;
                    object bs_ = FHIRHelpers_4_4_000.Instance.ToValue(context, br_);
                    return bs_ as CqlQuantity;
                }
                else if (bb_())
                {
                    DataType bt_ = @this?.Performed;
                    object bu_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bt_);
                    return bu_ as CqlInterval<CqlDateTime>;
                }
                else if (bc_())
                {
                    DataType bv_ = @this?.Performed;
                    object bw_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bv_);
                    return bw_ as CqlInterval<CqlQuantity>;
                }
                else
                {
                    return null;
                }
            }

            CqlInterval<CqlDateTime> ax_ = QICoreCommon_4_0_000.Instance.toInterval(context, aw_());
            CqlDateTime ay_ = context.Operators.Start(ax_);
            return ay_;
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

            object k_() {

                bool n_() {
                    DataType r_ = FirstBladderCancerStaging?.Performed;
                    object s_ = FHIRHelpers_4_4_000.Instance.ToValue(context, r_);
                    bool t_ = s_ is CqlDateTime;
                    return t_;
                }


                bool o_() {
                    DataType u_ = FirstBladderCancerStaging?.Performed;
                    object v_ = FHIRHelpers_4_4_000.Instance.ToValue(context, u_);
                    bool w_ = v_ is CqlQuantity;
                    return w_;
                }


                bool p_() {
                    DataType x_ = FirstBladderCancerStaging?.Performed;
                    object y_ = FHIRHelpers_4_4_000.Instance.ToValue(context, x_);
                    bool z_ = y_ is CqlInterval<CqlDateTime>;
                    return z_;
                }


                bool q_() {
                    DataType aa_ = FirstBladderCancerStaging?.Performed;
                    object ab_ = FHIRHelpers_4_4_000.Instance.ToValue(context, aa_);
                    bool ac_ = ab_ is CqlInterval<CqlQuantity>;
                    return ac_;
                }

                if (n_())
                {
                    DataType ad_ = FirstBladderCancerStaging?.Performed;
                    object ae_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ad_);
                    return ae_ as CqlDateTime;
                }
                else if (o_())
                {
                    DataType af_ = FirstBladderCancerStaging?.Performed;
                    object ag_ = FHIRHelpers_4_4_000.Instance.ToValue(context, af_);
                    return ag_ as CqlQuantity;
                }
                else if (p_())
                {
                    DataType ah_ = FirstBladderCancerStaging?.Performed;
                    object ai_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ah_);
                    return ai_ as CqlInterval<CqlDateTime>;
                }
                else if (q_())
                {
                    DataType aj_ = FirstBladderCancerStaging?.Performed;
                    object ak_ = FHIRHelpers_4_4_000.Instance.ToValue(context, aj_);
                    return ak_ as CqlInterval<CqlQuantity>;
                }
                else
                {
                    return null;
                }
            }

            CqlInterval<CqlDateTime> l_ = QICoreCommon_4_0_000.Instance.toInterval(context, k_());
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
            IEnumerable<Procedure> e_ = this.getStagingProcedure(context, StagingObservation);
            bool? f_ = context.Operators.Not((bool?)(e_ is null));
            DataType g_ = StagingObservation?.Value;
            object h_ = FHIRHelpers_4_4_000.Instance.ToValue(context, g_);
            CqlCode i_ = this.American_Joint_Committee_on_Cancer_cT1__qualifier_value_(context);
            CqlConcept j_ = context.Operators.ConvertCodeToConcept(i_);
            bool? k_ = context.Operators.Equivalent(h_ as CqlConcept, j_);
            CqlCode l_ = this.American_Joint_Committee_on_Cancer_cTis__qualifier_value_(context);
            CqlConcept m_ = context.Operators.ConvertCodeToConcept(l_);
            bool? n_ = context.Operators.Equivalent(h_ as CqlConcept, m_);
            bool? o_ = context.Operators.Or(k_, n_);
            CqlCode p_ = this.American_Joint_Committee_on_Cancer_cTa__qualifier_value_(context);
            CqlConcept q_ = context.Operators.ConvertCodeToConcept(p_);
            bool? r_ = context.Operators.Equivalent(h_ as CqlConcept, q_);
            bool? s_ = context.Operators.Or(o_, r_);
            CqlCode t_ = this.Carcinoma_in_situ_of_bladder(context);
            CqlConcept u_ = context.Operators.ConvertCodeToConcept(t_);
            bool? v_ = context.Operators.Equivalent(h_ as CqlConcept, u_);
            bool? w_ = context.Operators.Or(s_, v_);
            bool? x_ = context.Operators.And(f_, w_);
            Code<ObservationStatus> y_ = StagingObservation?.StatusElement;
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

        IEnumerable<Observation> c_ = context.Operators.Where<Observation>(a_, b_);
        bool? d_ = context.Operators.Exists<Observation>(c_);
        return d_;
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
            CqlInterval<CqlDateTime> f_ = this.Measurement_Period(context);
            Period g_ = ValidEncounter?.Period;
            CqlInterval<CqlDateTime> h_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, g_);
            bool? i_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(f_, h_, "day");
            Coding j_ = ValidEncounter?.Class;
            CqlCode k_ = FHIRHelpers_4_4_000.Instance.ToCode(context, j_);
            CqlCode l_ = this.@virtual(context);
            bool? m_ = context.Operators.Equivalent(k_, l_);
            bool? n_ = context.Operators.Not(m_);
            bool? o_ = context.Operators.And(i_, n_);
            Code<Encounter.EncounterStatus> p_ = ValidEncounter?.StatusElement;
            Encounter.EncounterStatus? q_ = p_?.Value;
            Code<Encounter.EncounterStatus> r_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(q_);
            bool? s_ = context.Operators.Equal(r_, "finished");
            bool? t_ = context.Operators.And(o_, s_);
            return t_;
        }

        IEnumerable<Encounter> d_ = context.Operators.Where<Encounter>(b_, c_);
        bool? e_ = context.Operators.Exists<Encounter>(d_);
        return e_;
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
                CqlInterval<CqlDateTime> n_ = QICoreCommon_4_0_000.Instance.prevalenceInterval(context, ActiveTuberculosis);

                object o_() {

                    bool ag_() {
                        DataType ak_ = FirstBladderCancerStaging?.Performed;
                        object al_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ak_);
                        bool am_ = al_ is CqlDateTime;
                        return am_;
                    }


                    bool ah_() {
                        DataType an_ = FirstBladderCancerStaging?.Performed;
                        object ao_ = FHIRHelpers_4_4_000.Instance.ToValue(context, an_);
                        bool ap_ = ao_ is CqlQuantity;
                        return ap_;
                    }


                    bool ai_() {
                        DataType aq_ = FirstBladderCancerStaging?.Performed;
                        object ar_ = FHIRHelpers_4_4_000.Instance.ToValue(context, aq_);
                        bool as_ = ar_ is CqlInterval<CqlDateTime>;
                        return as_;
                    }


                    bool aj_() {
                        DataType at_ = FirstBladderCancerStaging?.Performed;
                        object au_ = FHIRHelpers_4_4_000.Instance.ToValue(context, at_);
                        bool av_ = au_ is CqlInterval<CqlQuantity>;
                        return av_;
                    }

                    if (ag_())
                    {
                        DataType aw_ = FirstBladderCancerStaging?.Performed;
                        object ax_ = FHIRHelpers_4_4_000.Instance.ToValue(context, aw_);
                        return ax_ as CqlDateTime;
                    }
                    else if (ah_())
                    {
                        DataType ay_ = FirstBladderCancerStaging?.Performed;
                        object az_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ay_);
                        return az_ as CqlQuantity;
                    }
                    else if (ai_())
                    {
                        DataType ba_ = FirstBladderCancerStaging?.Performed;
                        object bb_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ba_);
                        return bb_ as CqlInterval<CqlDateTime>;
                    }
                    else if (aj_())
                    {
                        DataType bc_ = FirstBladderCancerStaging?.Performed;
                        object bd_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bc_);
                        return bd_ as CqlInterval<CqlQuantity>;
                    }
                    else
                    {
                        return null;
                    }
                }

                CqlInterval<CqlDateTime> p_ = QICoreCommon_4_0_000.Instance.toInterval(context, o_());
                bool? q_ = context.Operators.OverlapsAfter(n_, p_, "day");
                DataType r_ = ActiveTuberculosis?.Onset;
                object s_ = FHIRHelpers_4_4_000.Instance.ToValue(context, r_);
                CqlInterval<CqlDateTime> t_ = QICoreCommon_4_0_000.Instance.toInterval(context, s_);

                object u_() {

                    bool be_() {
                        DataType bi_ = FirstBladderCancerStaging?.Performed;
                        object bj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bi_);
                        bool bk_ = bj_ is CqlDateTime;
                        return bk_;
                    }


                    bool bf_() {
                        DataType bl_ = FirstBladderCancerStaging?.Performed;
                        object bm_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bl_);
                        bool bn_ = bm_ is CqlQuantity;
                        return bn_;
                    }


                    bool bg_() {
                        DataType bo_ = FirstBladderCancerStaging?.Performed;
                        object bp_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bo_);
                        bool bq_ = bp_ is CqlInterval<CqlDateTime>;
                        return bq_;
                    }


                    bool bh_() {
                        DataType br_ = FirstBladderCancerStaging?.Performed;
                        object bs_ = FHIRHelpers_4_4_000.Instance.ToValue(context, br_);
                        bool bt_ = bs_ is CqlInterval<CqlQuantity>;
                        return bt_;
                    }

                    if (be_())
                    {
                        DataType bu_ = FirstBladderCancerStaging?.Performed;
                        object bv_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bu_);
                        return bv_ as CqlDateTime;
                    }
                    else if (bf_())
                    {
                        DataType bw_ = FirstBladderCancerStaging?.Performed;
                        object bx_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bw_);
                        return bx_ as CqlQuantity;
                    }
                    else if (bg_())
                    {
                        DataType by_ = FirstBladderCancerStaging?.Performed;
                        object bz_ = FHIRHelpers_4_4_000.Instance.ToValue(context, by_);
                        return bz_ as CqlInterval<CqlDateTime>;
                    }
                    else if (bh_())
                    {
                        DataType ca_ = FirstBladderCancerStaging?.Performed;
                        object cb_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ca_);
                        return cb_ as CqlInterval<CqlQuantity>;
                    }
                    else
                    {
                        return null;
                    }
                }

                CqlInterval<CqlDateTime> v_ = QICoreCommon_4_0_000.Instance.toInterval(context, u_());
                bool? w_ = context.Operators.OverlapsAfter(t_, v_, "day");
                DataType x_ = ActiveTuberculosis?.Abatement;
                object y_ = FHIRHelpers_4_4_000.Instance.ToValue(context, x_);
                CqlInterval<CqlDateTime> z_ = QICoreCommon_4_0_000.Instance.toInterval(context, y_);

                object aa_() {

                    bool cc_() {
                        DataType cg_ = FirstBladderCancerStaging?.Performed;
                        object ch_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cg_);
                        bool ci_ = ch_ is CqlDateTime;
                        return ci_;
                    }


                    bool cd_() {
                        DataType cj_ = FirstBladderCancerStaging?.Performed;
                        object ck_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cj_);
                        bool cl_ = ck_ is CqlQuantity;
                        return cl_;
                    }


                    bool ce_() {
                        DataType cm_ = FirstBladderCancerStaging?.Performed;
                        object cn_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cm_);
                        bool co_ = cn_ is CqlInterval<CqlDateTime>;
                        return co_;
                    }


                    bool cf_() {
                        DataType cp_ = FirstBladderCancerStaging?.Performed;
                        object cq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cp_);
                        bool cr_ = cq_ is CqlInterval<CqlQuantity>;
                        return cr_;
                    }

                    if (cc_())
                    {
                        DataType cs_ = FirstBladderCancerStaging?.Performed;
                        object ct_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cs_);
                        return ct_ as CqlDateTime;
                    }
                    else if (cd_())
                    {
                        DataType cu_ = FirstBladderCancerStaging?.Performed;
                        object cv_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cu_);
                        return cv_ as CqlQuantity;
                    }
                    else if (ce_())
                    {
                        DataType cw_ = FirstBladderCancerStaging?.Performed;
                        object cx_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cw_);
                        return cx_ as CqlInterval<CqlDateTime>;
                    }
                    else if (cf_())
                    {
                        DataType cy_ = FirstBladderCancerStaging?.Performed;
                        object cz_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cy_);
                        return cz_ as CqlInterval<CqlQuantity>;
                    }
                    else
                    {
                        return null;
                    }
                }

                CqlInterval<CqlDateTime> ab_ = QICoreCommon_4_0_000.Instance.toInterval(context, aa_());
                bool? ac_ = context.Operators.OverlapsAfter(z_, ab_, "day");
                bool? ad_ = context.Operators.Or(ac_, (bool?)(y_ is null));
                bool? ae_ = context.Operators.And(w_, ad_);
                bool? af_ = context.Operators.Or(q_, ae_);
                return af_;
            }

            IEnumerable<Procedure> l_ = context.Operators.Where<Procedure>((IEnumerable<Procedure>)j_, k_);
            bool? m_ = context.Operators.Exists<Procedure>(l_);
            return m_;
        }

        IEnumerable<Condition> f_ = context.Operators.Where<Condition>(d_, e_);

        bool? g_(Condition ActiveTuberculosis) {
            bool? da_ = this.isVerified(context, ActiveTuberculosis);
            return da_;
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
                object o_ = context.Operators.LateBoundProperty<object>(M, "id.value");
                object p_ = context.Operators.LateBoundProperty<object>(MR, "medication.reference.value");
                IEnumerable<string> q_ = context.Operators.Split((string)p_, "/");
                string r_ = context.Operators.Last<string>(q_);
                bool? s_ = context.Operators.Equal(o_, r_);
                CodeableConcept t_ = M?.Code;
                CqlConcept u_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, t_);
                CqlValueSet v_ = this.Immunosuppressive_Drugs_for_Urology_Care(context);
                bool? w_ = context.Operators.ConceptInValueSet(u_, v_);
                bool? x_ = context.Operators.And(s_, w_);
                return x_;
            }

            IEnumerable<Medication> m_ = context.Operators.Where<Medication>(k_, l_);
            bool? n_ = context.Operators.Exists<Medication>(m_);
            return n_;
        }

        IEnumerable<MedicationRequest> c_ = context.Operators.Where<MedicationRequest>(a_, b_);
        CqlValueSet d_ = this.Immunosuppressive_Drugs_for_Urology_Care(context);
        IEnumerable<MedicationRequest> e_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, d_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> f_ = context.Operators.Union<MedicationRequest>(c_, e_);

        bool? g_(MedicationRequest ImmunosuppressiveDrugs) {
            Procedure y_ = this.First_Bladder_Cancer_Staging_Procedure(context);
            Procedure[] z_ = [
                y_,
            ];

            bool? aa_(Procedure FirstBladderCancerStaging) {
                List<Dosage> ad_ = ImmunosuppressiveDrugs?.DosageInstruction;

                bool? ae_(Dosage @this) {
                    Timing bm_ = @this?.Timing;
                    bool? bn_ = context.Operators.Not((bool?)(bm_ is null));
                    return bn_;
                }

                IEnumerable<Dosage> af_ = context.Operators.Where<Dosage>((IEnumerable<Dosage>)ad_, ae_);

                Timing ag_(Dosage @this) {
                    Timing bo_ = @this?.Timing;
                    return bo_;
                }

                IEnumerable<Timing> ah_ = context.Operators.Select<Dosage, Timing>(af_, ag_);

                CqlDateTime ai_(Timing dosageTiming) {
                    List<FhirDateTime> bp_ = dosageTiming?.EventElement;

                    string bq_(FhirDateTime @this) {
                        string bw_ = @this?.Value;
                        return bw_;
                    }

                    IEnumerable<string> br_ = context.Operators.Select<FhirDateTime, string>((IEnumerable<FhirDateTime>)bp_, bq_);

                    CqlDateTime bs_(string @string) {
                        CqlDateTime bx_ = context.Operators.ConvertStringToDateTime(@string);
                        return bx_;
                    }

                    IEnumerable<CqlDateTime> bt_ = context.Operators.Select<string, CqlDateTime>(br_, bs_);
                    IEnumerable<CqlDateTime> bu_ = context.Operators.ListSort<CqlDateTime>(bt_, System.ComponentModel.ListSortDirection.Ascending);
                    CqlDateTime bv_ = context.Operators.First<CqlDateTime>(bu_);
                    return bv_;
                }

                IEnumerable<CqlDateTime> aj_ = context.Operators.Select<Timing, CqlDateTime>(ah_, ai_);
                IEnumerable<CqlDateTime> ak_ = context.Operators.Distinct<CqlDateTime>(aj_);
                IEnumerable<CqlDateTime> al_ = context.Operators.ListSort<CqlDateTime>(ak_, System.ComponentModel.ListSortDirection.Ascending);
                CqlDateTime am_ = context.Operators.First<CqlDateTime>(al_);
                CqlInterval<CqlDateTime> an_ = QICoreCommon_4_0_000.Instance.toInterval(context, am_);

                bool? ao_(Dosage @this) {
                    Timing by_ = @this?.Timing;
                    bool? bz_ = context.Operators.Not((bool?)(by_ is null));
                    return bz_;
                }

                IEnumerable<Dosage> ap_ = context.Operators.Where<Dosage>((IEnumerable<Dosage>)ad_, ao_);

                Timing aq_(Dosage @this) {
                    Timing ca_ = @this?.Timing;
                    return ca_;
                }

                IEnumerable<Timing> ar_ = context.Operators.Select<Dosage, Timing>(ap_, aq_);

                bool? as_(Timing @this) {
                    Timing.RepeatComponent cb_ = @this?.Repeat;
                    bool? cc_ = context.Operators.Not((bool?)(cb_ is null));
                    return cc_;
                }

                IEnumerable<Timing> at_ = context.Operators.Where<Timing>(ar_, as_);

                Timing.RepeatComponent au_(Timing @this) {
                    Timing.RepeatComponent cd_ = @this?.Repeat;
                    return cd_;
                }

                IEnumerable<Timing.RepeatComponent> av_ = context.Operators.Select<Timing, Timing.RepeatComponent>(at_, au_);

                bool? aw_(Timing.RepeatComponent @this) {
                    DataType ce_ = @this?.Bounds;
                    object cf_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ce_);
                    bool? cg_ = context.Operators.Not((bool?)(cf_ is null));
                    return cg_;
                }

                IEnumerable<Timing.RepeatComponent> ax_ = context.Operators.Where<Timing.RepeatComponent>(av_, aw_);

                object ay_(Timing.RepeatComponent @this) {
                    DataType ch_ = @this?.Bounds;
                    object ci_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ch_);
                    return ci_;
                }

                IEnumerable<object> az_ = context.Operators.Select<Timing.RepeatComponent, object>(ax_, ay_);

                CqlInterval<CqlDateTime> ba_(object DoseTime) {
                    CqlInterval<CqlDateTime> cj_ = QICoreCommon_4_0_000.Instance.toInterval(context, DoseTime);
                    return cj_;
                }

                IEnumerable<CqlInterval<CqlDateTime>> bb_ = context.Operators.Select<object, CqlInterval<CqlDateTime>>(az_, ba_);
                IEnumerable<CqlInterval<CqlDateTime>> bc_ = context.Operators.Distinct<CqlInterval<CqlDateTime>>(bb_);
                IEnumerable<CqlInterval<CqlDateTime>> bd_ = context.Operators.Collapse(bc_, (string)default);

                object be_(CqlInterval<CqlDateTime> @this) {
                    CqlDateTime ck_ = context.Operators.Start(@this);
                    return ck_;
                }

                IEnumerable<CqlInterval<CqlDateTime>> bf_ = context.Operators.SortBy<CqlInterval<CqlDateTime>>(bd_, be_, System.ComponentModel.ListSortDirection.Ascending);
                CqlInterval<CqlDateTime> bg_ = context.Operators.First<CqlInterval<CqlDateTime>>(bf_);
                CqlDateTime bh_ = context.Operators.Start(an_ ?? bg_);

                object bi_() {

                    bool cl_() {
                        DataType cp_ = FirstBladderCancerStaging?.Performed;
                        object cq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cp_);
                        bool cr_ = cq_ is CqlDateTime;
                        return cr_;
                    }


                    bool cm_() {
                        DataType cs_ = FirstBladderCancerStaging?.Performed;
                        object ct_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cs_);
                        bool cu_ = ct_ is CqlQuantity;
                        return cu_;
                    }


                    bool cn_() {
                        DataType cv_ = FirstBladderCancerStaging?.Performed;
                        object cw_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cv_);
                        bool cx_ = cw_ is CqlInterval<CqlDateTime>;
                        return cx_;
                    }


                    bool co_() {
                        DataType cy_ = FirstBladderCancerStaging?.Performed;
                        object cz_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cy_);
                        bool da_ = cz_ is CqlInterval<CqlQuantity>;
                        return da_;
                    }

                    if (cl_())
                    {
                        DataType db_ = FirstBladderCancerStaging?.Performed;
                        object dc_ = FHIRHelpers_4_4_000.Instance.ToValue(context, db_);
                        return dc_ as CqlDateTime;
                    }
                    else if (cm_())
                    {
                        DataType dd_ = FirstBladderCancerStaging?.Performed;
                        object de_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dd_);
                        return de_ as CqlQuantity;
                    }
                    else if (cn_())
                    {
                        DataType df_ = FirstBladderCancerStaging?.Performed;
                        object dg_ = FHIRHelpers_4_4_000.Instance.ToValue(context, df_);
                        return dg_ as CqlInterval<CqlDateTime>;
                    }
                    else if (co_())
                    {
                        DataType dh_ = FirstBladderCancerStaging?.Performed;
                        object di_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dh_);
                        return di_ as CqlInterval<CqlQuantity>;
                    }
                    else
                    {
                        return null;
                    }
                }

                CqlInterval<CqlDateTime> bj_ = QICoreCommon_4_0_000.Instance.toInterval(context, bi_());
                CqlDateTime bk_ = context.Operators.Start(bj_);
                bool? bl_ = context.Operators.SameOrBefore(bh_, bk_, "day");
                return bl_;
            }

            IEnumerable<Procedure> ab_ = context.Operators.Where<Procedure>((IEnumerable<Procedure>)z_, aa_);
            bool? ac_ = context.Operators.Exists<Procedure>(ab_);
            return ac_;
        }

        IEnumerable<MedicationRequest> h_ = context.Operators.Where<MedicationRequest>(f_, g_);

        bool? i_(MedicationRequest ImmunosuppressiveDrugs) {
            Code<MedicationRequest.MedicationrequestStatus> dj_ = ImmunosuppressiveDrugs?.StatusElement;
            MedicationRequest.MedicationrequestStatus? dk_ = dj_?.Value;
            string dl_ = context.Operators.Convert<string>(dk_);
            string[] dm_ = [
                "active",
                "completed",
            ];
            bool? dn_ = context.Operators.In<string>(dl_, (IEnumerable<string>)dm_);
            Code<MedicationRequest.MedicationRequestIntent> do_ = ImmunosuppressiveDrugs?.IntentElement;
            MedicationRequest.MedicationRequestIntent? dp_ = do_?.Value;
            string dq_ = context.Operators.Convert<string>(dp_);
            bool? dr_ = context.Operators.Equal(dq_, "order");
            bool? ds_ = context.Operators.And(dn_, dr_);
            return ds_;
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

                object l_() {

                    bool ad_() {
                        DataType ah_ = Cystectomy?.Performed;
                        object ai_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ah_);
                        bool aj_ = ai_ is CqlDateTime;
                        return aj_;
                    }


                    bool ae_() {
                        DataType ak_ = Cystectomy?.Performed;
                        object al_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ak_);
                        bool am_ = al_ is CqlQuantity;
                        return am_;
                    }


                    bool af_() {
                        DataType an_ = Cystectomy?.Performed;
                        object ao_ = FHIRHelpers_4_4_000.Instance.ToValue(context, an_);
                        bool ap_ = ao_ is CqlInterval<CqlDateTime>;
                        return ap_;
                    }


                    bool ag_() {
                        DataType aq_ = Cystectomy?.Performed;
                        object ar_ = FHIRHelpers_4_4_000.Instance.ToValue(context, aq_);
                        bool as_ = ar_ is CqlInterval<CqlQuantity>;
                        return as_;
                    }

                    if (ad_())
                    {
                        DataType at_ = Cystectomy?.Performed;
                        object au_ = FHIRHelpers_4_4_000.Instance.ToValue(context, at_);
                        return au_ as CqlDateTime;
                    }
                    else if (ae_())
                    {
                        DataType av_ = Cystectomy?.Performed;
                        object aw_ = FHIRHelpers_4_4_000.Instance.ToValue(context, av_);
                        return aw_ as CqlQuantity;
                    }
                    else if (af_())
                    {
                        DataType ax_ = Cystectomy?.Performed;
                        object ay_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ax_);
                        return ay_ as CqlInterval<CqlDateTime>;
                    }
                    else if (ag_())
                    {
                        DataType az_ = Cystectomy?.Performed;
                        object ba_ = FHIRHelpers_4_4_000.Instance.ToValue(context, az_);
                        return ba_ as CqlInterval<CqlQuantity>;
                    }
                    else
                    {
                        return null;
                    }
                }

                CqlInterval<CqlDateTime> m_ = QICoreCommon_4_0_000.Instance.toInterval(context, l_());
                CqlDateTime n_ = context.Operators.End(m_);

                object o_() {

                    bool bb_() {
                        DataType bf_ = FirstBladderCancerStaging?.Performed;
                        object bg_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bf_);
                        bool bh_ = bg_ is CqlDateTime;
                        return bh_;
                    }


                    bool bc_() {
                        DataType bi_ = FirstBladderCancerStaging?.Performed;
                        object bj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bi_);
                        bool bk_ = bj_ is CqlQuantity;
                        return bk_;
                    }


                    bool bd_() {
                        DataType bl_ = FirstBladderCancerStaging?.Performed;
                        object bm_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bl_);
                        bool bn_ = bm_ is CqlInterval<CqlDateTime>;
                        return bn_;
                    }


                    bool be_() {
                        DataType bo_ = FirstBladderCancerStaging?.Performed;
                        object bp_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bo_);
                        bool bq_ = bp_ is CqlInterval<CqlQuantity>;
                        return bq_;
                    }

                    if (bb_())
                    {
                        DataType br_ = FirstBladderCancerStaging?.Performed;
                        object bs_ = FHIRHelpers_4_4_000.Instance.ToValue(context, br_);
                        return bs_ as CqlDateTime;
                    }
                    else if (bc_())
                    {
                        DataType bt_ = FirstBladderCancerStaging?.Performed;
                        object bu_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bt_);
                        return bu_ as CqlQuantity;
                    }
                    else if (bd_())
                    {
                        DataType bv_ = FirstBladderCancerStaging?.Performed;
                        object bw_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bv_);
                        return bw_ as CqlInterval<CqlDateTime>;
                    }
                    else if (be_())
                    {
                        DataType bx_ = FirstBladderCancerStaging?.Performed;
                        object by_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bx_);
                        return by_ as CqlInterval<CqlQuantity>;
                    }
                    else
                    {
                        return null;
                    }
                }

                CqlInterval<CqlDateTime> p_ = QICoreCommon_4_0_000.Instance.toInterval(context, o_());
                CqlDateTime q_ = context.Operators.Start(p_);
                CqlQuantity r_ = context.Operators.Quantity(6m, "months");
                CqlDateTime s_ = context.Operators.Subtract(q_, r_);

                object t_() {

                    bool bz_() {
                        DataType cd_ = FirstBladderCancerStaging?.Performed;
                        object ce_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cd_);
                        bool cf_ = ce_ is CqlDateTime;
                        return cf_;
                    }


                    bool ca_() {
                        DataType cg_ = FirstBladderCancerStaging?.Performed;
                        object ch_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cg_);
                        bool ci_ = ch_ is CqlQuantity;
                        return ci_;
                    }


                    bool cb_() {
                        DataType cj_ = FirstBladderCancerStaging?.Performed;
                        object ck_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cj_);
                        bool cl_ = ck_ is CqlInterval<CqlDateTime>;
                        return cl_;
                    }


                    bool cc_() {
                        DataType cm_ = FirstBladderCancerStaging?.Performed;
                        object cn_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cm_);
                        bool co_ = cn_ is CqlInterval<CqlQuantity>;
                        return co_;
                    }

                    if (bz_())
                    {
                        DataType cp_ = FirstBladderCancerStaging?.Performed;
                        object cq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cp_);
                        return cq_ as CqlDateTime;
                    }
                    else if (ca_())
                    {
                        DataType cr_ = FirstBladderCancerStaging?.Performed;
                        object cs_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cr_);
                        return cs_ as CqlQuantity;
                    }
                    else if (cb_())
                    {
                        DataType ct_ = FirstBladderCancerStaging?.Performed;
                        object cu_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ct_);
                        return cu_ as CqlInterval<CqlDateTime>;
                    }
                    else if (cc_())
                    {
                        DataType cv_ = FirstBladderCancerStaging?.Performed;
                        object cw_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cv_);
                        return cw_ as CqlInterval<CqlQuantity>;
                    }
                    else
                    {
                        return null;
                    }
                }

                CqlInterval<CqlDateTime> u_ = QICoreCommon_4_0_000.Instance.toInterval(context, t_());
                CqlDateTime v_ = context.Operators.Start(u_);
                CqlInterval<CqlDateTime> w_ = context.Operators.Interval(s_, v_, true, false);
                bool? x_ = context.Operators.In<CqlDateTime>(n_, w_, "day");

                object y_() {

                    bool cx_() {
                        DataType db_ = FirstBladderCancerStaging?.Performed;
                        object dc_ = FHIRHelpers_4_4_000.Instance.ToValue(context, db_);
                        bool dd_ = dc_ is CqlDateTime;
                        return dd_;
                    }


                    bool cy_() {
                        DataType de_ = FirstBladderCancerStaging?.Performed;
                        object df_ = FHIRHelpers_4_4_000.Instance.ToValue(context, de_);
                        bool dg_ = df_ is CqlQuantity;
                        return dg_;
                    }


                    bool cz_() {
                        DataType dh_ = FirstBladderCancerStaging?.Performed;
                        object di_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dh_);
                        bool dj_ = di_ is CqlInterval<CqlDateTime>;
                        return dj_;
                    }


                    bool da_() {
                        DataType dk_ = FirstBladderCancerStaging?.Performed;
                        object dl_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dk_);
                        bool dm_ = dl_ is CqlInterval<CqlQuantity>;
                        return dm_;
                    }

                    if (cx_())
                    {
                        DataType dn_ = FirstBladderCancerStaging?.Performed;
                        object do_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dn_);
                        return do_ as CqlDateTime;
                    }
                    else if (cy_())
                    {
                        DataType dp_ = FirstBladderCancerStaging?.Performed;
                        object dq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dp_);
                        return dq_ as CqlQuantity;
                    }
                    else if (cz_())
                    {
                        DataType dr_ = FirstBladderCancerStaging?.Performed;
                        object ds_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dr_);
                        return ds_ as CqlInterval<CqlDateTime>;
                    }
                    else if (da_())
                    {
                        DataType dt_ = FirstBladderCancerStaging?.Performed;
                        object du_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dt_);
                        return du_ as CqlInterval<CqlQuantity>;
                    }
                    else
                    {
                        return null;
                    }
                }

                CqlInterval<CqlDateTime> z_ = QICoreCommon_4_0_000.Instance.toInterval(context, y_());
                CqlDateTime aa_ = context.Operators.Start(z_);
                bool? ab_ = context.Operators.Not((bool?)(aa_ is null));
                bool? ac_ = context.Operators.And(x_, ab_);
                return ac_;
            }

            IEnumerable<Procedure> j_ = context.Operators.Where<Procedure>((IEnumerable<Procedure>)h_, i_);
            bool? k_ = context.Operators.Exists<Procedure>(j_);
            return k_;
        }

        IEnumerable<Procedure> d_ = context.Operators.Where<Procedure>(b_, c_);

        bool? e_(Procedure Cystectomy) {
            Code<EventStatus> dv_ = Cystectomy?.StatusElement;
            EventStatus? dw_ = dv_?.Value;
            string dx_ = context.Operators.Convert<string>(dw_);
            bool? dy_ = context.Operators.Equal(dx_, "completed");
            return dy_;
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
            Procedure t_ = this.First_Bladder_Cancer_Staging_Procedure(context);
            Procedure[] u_ = [
                t_,
            ];

            bool? v_(Procedure FirstBladderCancerStaging) {
                CqlInterval<CqlDateTime> y_ = QICoreCommon_4_0_000.Instance.prevalenceInterval(context, ExclusionDiagnosis);
                CqlDateTime z_ = context.Operators.Start(y_);

                object aa_() {

                    bool an_() {
                        DataType ar_ = FirstBladderCancerStaging?.Performed;
                        object as_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ar_);
                        bool at_ = as_ is CqlDateTime;
                        return at_;
                    }


                    bool ao_() {
                        DataType au_ = FirstBladderCancerStaging?.Performed;
                        object av_ = FHIRHelpers_4_4_000.Instance.ToValue(context, au_);
                        bool aw_ = av_ is CqlQuantity;
                        return aw_;
                    }


                    bool ap_() {
                        DataType ax_ = FirstBladderCancerStaging?.Performed;
                        object ay_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ax_);
                        bool az_ = ay_ is CqlInterval<CqlDateTime>;
                        return az_;
                    }


                    bool aq_() {
                        DataType ba_ = FirstBladderCancerStaging?.Performed;
                        object bb_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ba_);
                        bool bc_ = bb_ is CqlInterval<CqlQuantity>;
                        return bc_;
                    }

                    if (an_())
                    {
                        DataType bd_ = FirstBladderCancerStaging?.Performed;
                        object be_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bd_);
                        return be_ as CqlDateTime;
                    }
                    else if (ao_())
                    {
                        DataType bf_ = FirstBladderCancerStaging?.Performed;
                        object bg_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bf_);
                        return bg_ as CqlQuantity;
                    }
                    else if (ap_())
                    {
                        DataType bh_ = FirstBladderCancerStaging?.Performed;
                        object bi_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bh_);
                        return bi_ as CqlInterval<CqlDateTime>;
                    }
                    else if (aq_())
                    {
                        DataType bj_ = FirstBladderCancerStaging?.Performed;
                        object bk_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bj_);
                        return bk_ as CqlInterval<CqlQuantity>;
                    }
                    else
                    {
                        return null;
                    }
                }

                CqlInterval<CqlDateTime> ab_ = QICoreCommon_4_0_000.Instance.toInterval(context, aa_());
                CqlDateTime ac_ = context.Operators.Start(ab_);
                bool? ad_ = context.Operators.SameOrBefore(z_, ac_, "day");
                DataType ae_ = ExclusionDiagnosis?.Onset;
                object af_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ae_);
                CqlInterval<CqlDateTime> ag_ = QICoreCommon_4_0_000.Instance.toInterval(context, af_);
                CqlDateTime ah_ = context.Operators.Start(ag_);

                object ai_() {

                    bool bl_() {
                        DataType bp_ = FirstBladderCancerStaging?.Performed;
                        object bq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bp_);
                        bool br_ = bq_ is CqlDateTime;
                        return br_;
                    }


                    bool bm_() {
                        DataType bs_ = FirstBladderCancerStaging?.Performed;
                        object bt_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bs_);
                        bool bu_ = bt_ is CqlQuantity;
                        return bu_;
                    }


                    bool bn_() {
                        DataType bv_ = FirstBladderCancerStaging?.Performed;
                        object bw_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bv_);
                        bool bx_ = bw_ is CqlInterval<CqlDateTime>;
                        return bx_;
                    }


                    bool bo_() {
                        DataType by_ = FirstBladderCancerStaging?.Performed;
                        object bz_ = FHIRHelpers_4_4_000.Instance.ToValue(context, by_);
                        bool ca_ = bz_ is CqlInterval<CqlQuantity>;
                        return ca_;
                    }

                    if (bl_())
                    {
                        DataType cb_ = FirstBladderCancerStaging?.Performed;
                        object cc_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cb_);
                        return cc_ as CqlDateTime;
                    }
                    else if (bm_())
                    {
                        DataType cd_ = FirstBladderCancerStaging?.Performed;
                        object ce_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cd_);
                        return ce_ as CqlQuantity;
                    }
                    else if (bn_())
                    {
                        DataType cf_ = FirstBladderCancerStaging?.Performed;
                        object cg_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cf_);
                        return cg_ as CqlInterval<CqlDateTime>;
                    }
                    else if (bo_())
                    {
                        DataType ch_ = FirstBladderCancerStaging?.Performed;
                        object ci_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ch_);
                        return ci_ as CqlInterval<CqlQuantity>;
                    }
                    else
                    {
                        return null;
                    }
                }

                CqlInterval<CqlDateTime> aj_ = QICoreCommon_4_0_000.Instance.toInterval(context, ai_());
                CqlDateTime ak_ = context.Operators.Start(aj_);
                bool? al_ = context.Operators.SameOrBefore(ah_, ak_, "day");
                bool? am_ = context.Operators.Or(ad_, al_);
                return am_;
            }

            IEnumerable<Procedure> w_ = context.Operators.Where<Procedure>((IEnumerable<Procedure>)u_, v_);
            bool? x_ = context.Operators.Exists<Procedure>(w_);
            return x_;
        }

        IEnumerable<Condition> p_ = context.Operators.Where<Condition>(n_, o_);

        bool? q_(Condition ExclusionDiagnosis) {
            bool? cj_ = this.isVerified(context, ExclusionDiagnosis);
            return cj_;
        }

        IEnumerable<Condition> r_ = context.Operators.Where<Condition>(p_, q_);
        bool? s_ = context.Operators.Exists<Condition>(r_);
        return s_;
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
                object x_ = context.Operators.LateBoundProperty<object>(M, "id.value");
                object y_ = context.Operators.LateBoundProperty<object>(MR, "medication.reference.value");
                IEnumerable<string> z_ = context.Operators.Split((string)y_, "/");
                string aa_ = context.Operators.Last<string>(z_);
                bool? ab_ = context.Operators.Equal(x_, aa_);
                CodeableConcept ac_ = M?.Code;
                CqlConcept ad_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, ac_);
                CqlValueSet ae_ = this.Chemotherapy_Agents_for_Advanced_Cancer(context);
                bool? af_ = context.Operators.ConceptInValueSet(ad_, ae_);
                bool? ag_ = context.Operators.And(ab_, af_);
                return ag_;
            }

            IEnumerable<Medication> v_ = context.Operators.Where<Medication>(t_, u_);
            bool? w_ = context.Operators.Exists<Medication>(v_);
            return w_;
        }

        IEnumerable<MedicationRequest> c_ = context.Operators.Where<MedicationRequest>(a_, b_);
        CqlValueSet d_ = this.Chemotherapy_Agents_for_Advanced_Cancer(context);
        IEnumerable<MedicationRequest> e_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, d_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> f_ = context.Operators.Union<MedicationRequest>(c_, e_);

        bool? g_(MedicationRequest ExclusionMed) {
            Procedure ah_ = this.First_Bladder_Cancer_Staging_Procedure(context);
            Procedure[] ai_ = [
                ah_,
            ];

            bool? aj_(Procedure FirstBladderCancerStaging) {
                List<Dosage> am_ = ExclusionMed?.DosageInstruction;

                bool? an_(Dosage @this) {
                    Timing bw_ = @this?.Timing;
                    bool? bx_ = context.Operators.Not((bool?)(bw_ is null));
                    return bx_;
                }

                IEnumerable<Dosage> ao_ = context.Operators.Where<Dosage>((IEnumerable<Dosage>)am_, an_);

                Timing ap_(Dosage @this) {
                    Timing by_ = @this?.Timing;
                    return by_;
                }

                IEnumerable<Timing> aq_ = context.Operators.Select<Dosage, Timing>(ao_, ap_);

                bool? ar_(Timing @this) {
                    Timing.RepeatComponent bz_ = @this?.Repeat;
                    bool? ca_ = context.Operators.Not((bool?)(bz_ is null));
                    return ca_;
                }

                IEnumerable<Timing> as_ = context.Operators.Where<Timing>(aq_, ar_);

                Timing.RepeatComponent at_(Timing @this) {
                    Timing.RepeatComponent cb_ = @this?.Repeat;
                    return cb_;
                }

                IEnumerable<Timing.RepeatComponent> au_ = context.Operators.Select<Timing, Timing.RepeatComponent>(as_, at_);

                bool? av_(Timing.RepeatComponent @this) {
                    DataType cc_ = @this?.Bounds;
                    object cd_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cc_);
                    bool? ce_ = context.Operators.Not((bool?)(cd_ is null));
                    return ce_;
                }

                IEnumerable<Timing.RepeatComponent> aw_ = context.Operators.Where<Timing.RepeatComponent>(au_, av_);

                object ax_(Timing.RepeatComponent @this) {
                    DataType cf_ = @this?.Bounds;
                    object cg_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cf_);
                    return cg_;
                }

                IEnumerable<object> ay_ = context.Operators.Select<Timing.RepeatComponent, object>(aw_, ax_);

                CqlInterval<CqlDateTime> az_(object DoseTime) {
                    CqlInterval<CqlDateTime> ch_ = QICoreCommon_4_0_000.Instance.toInterval(context, DoseTime);
                    return ch_;
                }

                IEnumerable<CqlInterval<CqlDateTime>> ba_ = context.Operators.Select<object, CqlInterval<CqlDateTime>>(ay_, az_);
                IEnumerable<CqlInterval<CqlDateTime>> bb_ = context.Operators.Distinct<CqlInterval<CqlDateTime>>(ba_);
                IEnumerable<CqlInterval<CqlDateTime>> bc_ = context.Operators.Collapse(bb_, (string)default);

                object bd_(CqlInterval<CqlDateTime> @this) {
                    CqlDateTime ci_ = context.Operators.Start(@this);
                    return ci_;
                }

                IEnumerable<CqlInterval<CqlDateTime>> be_ = context.Operators.SortBy<CqlInterval<CqlDateTime>>(bc_, bd_, System.ComponentModel.ListSortDirection.Ascending);
                CqlInterval<CqlDateTime> bf_ = context.Operators.First<CqlInterval<CqlDateTime>>(be_);
                CqlDateTime bg_ = context.Operators.Start(bf_);

                object bh_() {

                    bool cj_() {
                        DataType cn_ = FirstBladderCancerStaging?.Performed;
                        object co_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cn_);
                        bool cp_ = co_ is CqlDateTime;
                        return cp_;
                    }


                    bool ck_() {
                        DataType cq_ = FirstBladderCancerStaging?.Performed;
                        object cr_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cq_);
                        bool cs_ = cr_ is CqlQuantity;
                        return cs_;
                    }


                    bool cl_() {
                        DataType ct_ = FirstBladderCancerStaging?.Performed;
                        object cu_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ct_);
                        bool cv_ = cu_ is CqlInterval<CqlDateTime>;
                        return cv_;
                    }


                    bool cm_() {
                        DataType cw_ = FirstBladderCancerStaging?.Performed;
                        object cx_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cw_);
                        bool cy_ = cx_ is CqlInterval<CqlQuantity>;
                        return cy_;
                    }

                    if (cj_())
                    {
                        DataType cz_ = FirstBladderCancerStaging?.Performed;
                        object da_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cz_);
                        return da_ as CqlDateTime;
                    }
                    else if (ck_())
                    {
                        DataType db_ = FirstBladderCancerStaging?.Performed;
                        object dc_ = FHIRHelpers_4_4_000.Instance.ToValue(context, db_);
                        return dc_ as CqlQuantity;
                    }
                    else if (cl_())
                    {
                        DataType dd_ = FirstBladderCancerStaging?.Performed;
                        object de_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dd_);
                        return de_ as CqlInterval<CqlDateTime>;
                    }
                    else if (cm_())
                    {
                        DataType df_ = FirstBladderCancerStaging?.Performed;
                        object dg_ = FHIRHelpers_4_4_000.Instance.ToValue(context, df_);
                        return dg_ as CqlInterval<CqlQuantity>;
                    }
                    else
                    {
                        return null;
                    }
                }

                CqlInterval<CqlDateTime> bi_ = QICoreCommon_4_0_000.Instance.toInterval(context, bh_());
                CqlDateTime bj_ = context.Operators.Start(bi_);
                CqlQuantity bk_ = context.Operators.Quantity(6m, "months");
                CqlDateTime bl_ = context.Operators.Subtract(bj_, bk_);

                object bm_() {

                    bool dh_() {
                        DataType dl_ = FirstBladderCancerStaging?.Performed;
                        object dm_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dl_);
                        bool dn_ = dm_ is CqlDateTime;
                        return dn_;
                    }


                    bool di_() {
                        DataType do_ = FirstBladderCancerStaging?.Performed;
                        object dp_ = FHIRHelpers_4_4_000.Instance.ToValue(context, do_);
                        bool dq_ = dp_ is CqlQuantity;
                        return dq_;
                    }


                    bool dj_() {
                        DataType dr_ = FirstBladderCancerStaging?.Performed;
                        object ds_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dr_);
                        bool dt_ = ds_ is CqlInterval<CqlDateTime>;
                        return dt_;
                    }


                    bool dk_() {
                        DataType du_ = FirstBladderCancerStaging?.Performed;
                        object dv_ = FHIRHelpers_4_4_000.Instance.ToValue(context, du_);
                        bool dw_ = dv_ is CqlInterval<CqlQuantity>;
                        return dw_;
                    }

                    if (dh_())
                    {
                        DataType dx_ = FirstBladderCancerStaging?.Performed;
                        object dy_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dx_);
                        return dy_ as CqlDateTime;
                    }
                    else if (di_())
                    {
                        DataType dz_ = FirstBladderCancerStaging?.Performed;
                        object ea_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dz_);
                        return ea_ as CqlQuantity;
                    }
                    else if (dj_())
                    {
                        DataType eb_ = FirstBladderCancerStaging?.Performed;
                        object ec_ = FHIRHelpers_4_4_000.Instance.ToValue(context, eb_);
                        return ec_ as CqlInterval<CqlDateTime>;
                    }
                    else if (dk_())
                    {
                        DataType ed_ = FirstBladderCancerStaging?.Performed;
                        object ee_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ed_);
                        return ee_ as CqlInterval<CqlQuantity>;
                    }
                    else
                    {
                        return null;
                    }
                }

                CqlInterval<CqlDateTime> bn_ = QICoreCommon_4_0_000.Instance.toInterval(context, bm_());
                CqlDateTime bo_ = context.Operators.Start(bn_);
                CqlInterval<CqlDateTime> bp_ = context.Operators.Interval(bl_, bo_, true, false);
                bool? bq_ = context.Operators.In<CqlDateTime>(bg_, bp_, (string)default);

                object br_() {

                    bool ef_() {
                        DataType ej_ = FirstBladderCancerStaging?.Performed;
                        object ek_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ej_);
                        bool el_ = ek_ is CqlDateTime;
                        return el_;
                    }


                    bool eg_() {
                        DataType em_ = FirstBladderCancerStaging?.Performed;
                        object en_ = FHIRHelpers_4_4_000.Instance.ToValue(context, em_);
                        bool eo_ = en_ is CqlQuantity;
                        return eo_;
                    }


                    bool eh_() {
                        DataType ep_ = FirstBladderCancerStaging?.Performed;
                        object eq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ep_);
                        bool er_ = eq_ is CqlInterval<CqlDateTime>;
                        return er_;
                    }


                    bool ei_() {
                        DataType es_ = FirstBladderCancerStaging?.Performed;
                        object et_ = FHIRHelpers_4_4_000.Instance.ToValue(context, es_);
                        bool eu_ = et_ is CqlInterval<CqlQuantity>;
                        return eu_;
                    }

                    if (ef_())
                    {
                        DataType ev_ = FirstBladderCancerStaging?.Performed;
                        object ew_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ev_);
                        return ew_ as CqlDateTime;
                    }
                    else if (eg_())
                    {
                        DataType ex_ = FirstBladderCancerStaging?.Performed;
                        object ey_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ex_);
                        return ey_ as CqlQuantity;
                    }
                    else if (eh_())
                    {
                        DataType ez_ = FirstBladderCancerStaging?.Performed;
                        object fa_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ez_);
                        return fa_ as CqlInterval<CqlDateTime>;
                    }
                    else if (ei_())
                    {
                        DataType fb_ = FirstBladderCancerStaging?.Performed;
                        object fc_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fb_);
                        return fc_ as CqlInterval<CqlQuantity>;
                    }
                    else
                    {
                        return null;
                    }
                }

                CqlInterval<CqlDateTime> bs_ = QICoreCommon_4_0_000.Instance.toInterval(context, br_());
                CqlDateTime bt_ = context.Operators.Start(bs_);
                bool? bu_ = context.Operators.Not((bool?)(bt_ is null));
                bool? bv_ = context.Operators.And(bq_, bu_);
                return bv_;
            }

            IEnumerable<Procedure> ak_ = context.Operators.Where<Procedure>((IEnumerable<Procedure>)ai_, aj_);
            bool? al_ = context.Operators.Exists<Procedure>(ak_);
            return al_;
        }

        IEnumerable<MedicationRequest> h_ = context.Operators.Where<MedicationRequest>(f_, g_);

        bool? i_(MedicationRequest ExclusionMed) {
            Code<MedicationRequest.MedicationrequestStatus> fd_ = ExclusionMed?.StatusElement;
            MedicationRequest.MedicationrequestStatus? fe_ = fd_?.Value;
            string ff_ = context.Operators.Convert<string>(fe_);
            string[] fg_ = [
                "active",
                "completed",
            ];
            bool? fh_ = context.Operators.In<string>(ff_, (IEnumerable<string>)fg_);
            Code<MedicationRequest.MedicationRequestIntent> fi_ = ExclusionMed?.IntentElement;
            MedicationRequest.MedicationRequestIntent? fj_ = fi_?.Value;
            string fk_ = context.Operators.Convert<string>(fj_);
            bool? fl_ = context.Operators.Equal(fk_, "order");
            bool? fm_ = context.Operators.And(fh_, fl_);
            return fm_;
        }

        IEnumerable<MedicationRequest> j_ = context.Operators.Where<MedicationRequest>(h_, i_);
        CqlCode k_ = this.Combined_radiotherapy__procedure_(context);
        IEnumerable<CqlCode> l_ = context.Operators.ToList<CqlCode>(k_);
        IEnumerable<Procedure> m_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, default, l_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));

        bool? n_(Procedure ExclusionProcedure) {
            Procedure fn_ = this.First_Bladder_Cancer_Staging_Procedure(context);
            Procedure[] fo_ = [
                fn_,
            ];

            bool? fp_(Procedure FirstBladderCancerStaging) {

                object fs_() {

                    bool gk_() {
                        DataType go_ = ExclusionProcedure?.Performed;
                        object gp_ = FHIRHelpers_4_4_000.Instance.ToValue(context, go_);
                        bool gq_ = gp_ is CqlDateTime;
                        return gq_;
                    }


                    bool gl_() {
                        DataType gr_ = ExclusionProcedure?.Performed;
                        object gs_ = FHIRHelpers_4_4_000.Instance.ToValue(context, gr_);
                        bool gt_ = gs_ is CqlQuantity;
                        return gt_;
                    }


                    bool gm_() {
                        DataType gu_ = ExclusionProcedure?.Performed;
                        object gv_ = FHIRHelpers_4_4_000.Instance.ToValue(context, gu_);
                        bool gw_ = gv_ is CqlInterval<CqlDateTime>;
                        return gw_;
                    }


                    bool gn_() {
                        DataType gx_ = ExclusionProcedure?.Performed;
                        object gy_ = FHIRHelpers_4_4_000.Instance.ToValue(context, gx_);
                        bool gz_ = gy_ is CqlInterval<CqlQuantity>;
                        return gz_;
                    }

                    if (gk_())
                    {
                        DataType ha_ = ExclusionProcedure?.Performed;
                        object hb_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ha_);
                        return hb_ as CqlDateTime;
                    }
                    else if (gl_())
                    {
                        DataType hc_ = ExclusionProcedure?.Performed;
                        object hd_ = FHIRHelpers_4_4_000.Instance.ToValue(context, hc_);
                        return hd_ as CqlQuantity;
                    }
                    else if (gm_())
                    {
                        DataType he_ = ExclusionProcedure?.Performed;
                        object hf_ = FHIRHelpers_4_4_000.Instance.ToValue(context, he_);
                        return hf_ as CqlInterval<CqlDateTime>;
                    }
                    else if (gn_())
                    {
                        DataType hg_ = ExclusionProcedure?.Performed;
                        object hh_ = FHIRHelpers_4_4_000.Instance.ToValue(context, hg_);
                        return hh_ as CqlInterval<CqlQuantity>;
                    }
                    else
                    {
                        return null;
                    }
                }

                CqlInterval<CqlDateTime> ft_ = QICoreCommon_4_0_000.Instance.toInterval(context, fs_());
                CqlDateTime fu_ = context.Operators.Start(ft_);

                object fv_() {

                    bool hi_() {
                        DataType hm_ = FirstBladderCancerStaging?.Performed;
                        object hn_ = FHIRHelpers_4_4_000.Instance.ToValue(context, hm_);
                        bool ho_ = hn_ is CqlDateTime;
                        return ho_;
                    }


                    bool hj_() {
                        DataType hp_ = FirstBladderCancerStaging?.Performed;
                        object hq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, hp_);
                        bool hr_ = hq_ is CqlQuantity;
                        return hr_;
                    }


                    bool hk_() {
                        DataType hs_ = FirstBladderCancerStaging?.Performed;
                        object ht_ = FHIRHelpers_4_4_000.Instance.ToValue(context, hs_);
                        bool hu_ = ht_ is CqlInterval<CqlDateTime>;
                        return hu_;
                    }


                    bool hl_() {
                        DataType hv_ = FirstBladderCancerStaging?.Performed;
                        object hw_ = FHIRHelpers_4_4_000.Instance.ToValue(context, hv_);
                        bool hx_ = hw_ is CqlInterval<CqlQuantity>;
                        return hx_;
                    }

                    if (hi_())
                    {
                        DataType hy_ = FirstBladderCancerStaging?.Performed;
                        object hz_ = FHIRHelpers_4_4_000.Instance.ToValue(context, hy_);
                        return hz_ as CqlDateTime;
                    }
                    else if (hj_())
                    {
                        DataType ia_ = FirstBladderCancerStaging?.Performed;
                        object ib_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ia_);
                        return ib_ as CqlQuantity;
                    }
                    else if (hk_())
                    {
                        DataType ic_ = FirstBladderCancerStaging?.Performed;
                        object id_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ic_);
                        return id_ as CqlInterval<CqlDateTime>;
                    }
                    else if (hl_())
                    {
                        DataType ie_ = FirstBladderCancerStaging?.Performed;
                        object if_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ie_);
                        return if_ as CqlInterval<CqlQuantity>;
                    }
                    else
                    {
                        return null;
                    }
                }

                CqlInterval<CqlDateTime> fw_ = QICoreCommon_4_0_000.Instance.toInterval(context, fv_());
                CqlDateTime fx_ = context.Operators.Start(fw_);
                CqlQuantity fy_ = context.Operators.Quantity(6m, "months");
                CqlDateTime fz_ = context.Operators.Subtract(fx_, fy_);

                object ga_() {

                    bool ig_() {
                        DataType ik_ = FirstBladderCancerStaging?.Performed;
                        object il_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ik_);
                        bool im_ = il_ is CqlDateTime;
                        return im_;
                    }


                    bool ih_() {
                        DataType in_ = FirstBladderCancerStaging?.Performed;
                        object io_ = FHIRHelpers_4_4_000.Instance.ToValue(context, in_);
                        bool ip_ = io_ is CqlQuantity;
                        return ip_;
                    }


                    bool ii_() {
                        DataType iq_ = FirstBladderCancerStaging?.Performed;
                        object ir_ = FHIRHelpers_4_4_000.Instance.ToValue(context, iq_);
                        bool is_ = ir_ is CqlInterval<CqlDateTime>;
                        return is_;
                    }


                    bool ij_() {
                        DataType it_ = FirstBladderCancerStaging?.Performed;
                        object iu_ = FHIRHelpers_4_4_000.Instance.ToValue(context, it_);
                        bool iv_ = iu_ is CqlInterval<CqlQuantity>;
                        return iv_;
                    }

                    if (ig_())
                    {
                        DataType iw_ = FirstBladderCancerStaging?.Performed;
                        object ix_ = FHIRHelpers_4_4_000.Instance.ToValue(context, iw_);
                        return ix_ as CqlDateTime;
                    }
                    else if (ih_())
                    {
                        DataType iy_ = FirstBladderCancerStaging?.Performed;
                        object iz_ = FHIRHelpers_4_4_000.Instance.ToValue(context, iy_);
                        return iz_ as CqlQuantity;
                    }
                    else if (ii_())
                    {
                        DataType ja_ = FirstBladderCancerStaging?.Performed;
                        object jb_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ja_);
                        return jb_ as CqlInterval<CqlDateTime>;
                    }
                    else if (ij_())
                    {
                        DataType jc_ = FirstBladderCancerStaging?.Performed;
                        object jd_ = FHIRHelpers_4_4_000.Instance.ToValue(context, jc_);
                        return jd_ as CqlInterval<CqlQuantity>;
                    }
                    else
                    {
                        return null;
                    }
                }

                CqlInterval<CqlDateTime> gb_ = QICoreCommon_4_0_000.Instance.toInterval(context, ga_());
                CqlDateTime gc_ = context.Operators.Start(gb_);
                CqlInterval<CqlDateTime> gd_ = context.Operators.Interval(fz_, gc_, true, false);
                bool? ge_ = context.Operators.In<CqlDateTime>(fu_, gd_, (string)default);

                object gf_() {

                    bool je_() {
                        DataType ji_ = FirstBladderCancerStaging?.Performed;
                        object jj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ji_);
                        bool jk_ = jj_ is CqlDateTime;
                        return jk_;
                    }


                    bool jf_() {
                        DataType jl_ = FirstBladderCancerStaging?.Performed;
                        object jm_ = FHIRHelpers_4_4_000.Instance.ToValue(context, jl_);
                        bool jn_ = jm_ is CqlQuantity;
                        return jn_;
                    }


                    bool jg_() {
                        DataType jo_ = FirstBladderCancerStaging?.Performed;
                        object jp_ = FHIRHelpers_4_4_000.Instance.ToValue(context, jo_);
                        bool jq_ = jp_ is CqlInterval<CqlDateTime>;
                        return jq_;
                    }


                    bool jh_() {
                        DataType jr_ = FirstBladderCancerStaging?.Performed;
                        object js_ = FHIRHelpers_4_4_000.Instance.ToValue(context, jr_);
                        bool jt_ = js_ is CqlInterval<CqlQuantity>;
                        return jt_;
                    }

                    if (je_())
                    {
                        DataType ju_ = FirstBladderCancerStaging?.Performed;
                        object jv_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ju_);
                        return jv_ as CqlDateTime;
                    }
                    else if (jf_())
                    {
                        DataType jw_ = FirstBladderCancerStaging?.Performed;
                        object jx_ = FHIRHelpers_4_4_000.Instance.ToValue(context, jw_);
                        return jx_ as CqlQuantity;
                    }
                    else if (jg_())
                    {
                        DataType jy_ = FirstBladderCancerStaging?.Performed;
                        object jz_ = FHIRHelpers_4_4_000.Instance.ToValue(context, jy_);
                        return jz_ as CqlInterval<CqlDateTime>;
                    }
                    else if (jh_())
                    {
                        DataType ka_ = FirstBladderCancerStaging?.Performed;
                        object kb_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ka_);
                        return kb_ as CqlInterval<CqlQuantity>;
                    }
                    else
                    {
                        return null;
                    }
                }

                CqlInterval<CqlDateTime> gg_ = QICoreCommon_4_0_000.Instance.toInterval(context, gf_());
                CqlDateTime gh_ = context.Operators.Start(gg_);
                bool? gi_ = context.Operators.Not((bool?)(gh_ is null));
                bool? gj_ = context.Operators.And(ge_, gi_);
                return gj_;
            }

            IEnumerable<Procedure> fq_ = context.Operators.Where<Procedure>((IEnumerable<Procedure>)fo_, fp_);
            bool? fr_ = context.Operators.Exists<Procedure>(fq_);
            return fr_;
        }

        IEnumerable<Procedure> o_ = context.Operators.Where<Procedure>(m_, n_);

        bool? p_(Procedure ExclusionProcedure) {
            Code<EventStatus> kc_ = ExclusionProcedure?.StatusElement;
            EventStatus? kd_ = kc_?.Value;
            string ke_ = context.Operators.Convert<string>(kd_);
            string[] kf_ = [
                "completed",
                "in-progress",
            ];
            bool? kg_ = context.Operators.In<string>(ke_, (IEnumerable<string>)kf_);
            return kg_;
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

                bool? m_(Extension @this) {
                    FhirUri ai_ = @this?.UrlElement;
                    string aj_ = FHIRHelpers_4_4_000.Instance.ToString(context, ai_);
                    bool? ak_ = context.Operators.Equal(aj_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-recorded");
                    return ak_;
                }

                IEnumerable<Extension> n_ = context.Operators.Where<Extension>((IEnumerable<Extension>)(BCGNotGiven is DomainResource
                    ? (BCGNotGiven as DomainResource).Extension
                    : default), m_);

                DataType o_(Extension @this) {
                    DataType al_ = @this?.Value;
                    return al_;
                }

                IEnumerable<DataType> p_ = context.Operators.Select<Extension, DataType>(n_, o_);
                DataType q_ = context.Operators.SingletonFrom<DataType>(p_);
                FhirDateTime r_ = context.Operators.Convert<FhirDateTime>(q_);
                CqlDateTime s_ = context.Operators.Convert<CqlDateTime>(r_);

                object t_() {

                    bool am_() {
                        DataType aq_ = FirstBladderCancerStaging?.Performed;
                        object ar_ = FHIRHelpers_4_4_000.Instance.ToValue(context, aq_);
                        bool as_ = ar_ is CqlDateTime;
                        return as_;
                    }


                    bool an_() {
                        DataType at_ = FirstBladderCancerStaging?.Performed;
                        object au_ = FHIRHelpers_4_4_000.Instance.ToValue(context, at_);
                        bool av_ = au_ is CqlQuantity;
                        return av_;
                    }


                    bool ao_() {
                        DataType aw_ = FirstBladderCancerStaging?.Performed;
                        object ax_ = FHIRHelpers_4_4_000.Instance.ToValue(context, aw_);
                        bool ay_ = ax_ is CqlInterval<CqlDateTime>;
                        return ay_;
                    }


                    bool ap_() {
                        DataType az_ = FirstBladderCancerStaging?.Performed;
                        object ba_ = FHIRHelpers_4_4_000.Instance.ToValue(context, az_);
                        bool bb_ = ba_ is CqlInterval<CqlQuantity>;
                        return bb_;
                    }

                    if (am_())
                    {
                        DataType bc_ = FirstBladderCancerStaging?.Performed;
                        object bd_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bc_);
                        return bd_ as CqlDateTime;
                    }
                    else if (an_())
                    {
                        DataType be_ = FirstBladderCancerStaging?.Performed;
                        object bf_ = FHIRHelpers_4_4_000.Instance.ToValue(context, be_);
                        return bf_ as CqlQuantity;
                    }
                    else if (ao_())
                    {
                        DataType bg_ = FirstBladderCancerStaging?.Performed;
                        object bh_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bg_);
                        return bh_ as CqlInterval<CqlDateTime>;
                    }
                    else if (ap_())
                    {
                        DataType bi_ = FirstBladderCancerStaging?.Performed;
                        object bj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bi_);
                        return bj_ as CqlInterval<CqlQuantity>;
                    }
                    else
                    {
                        return null;
                    }
                }

                CqlInterval<CqlDateTime> u_ = QICoreCommon_4_0_000.Instance.toInterval(context, t_());
                CqlDateTime v_ = context.Operators.Start(u_);

                object w_() {

                    bool bk_() {
                        DataType bo_ = FirstBladderCancerStaging?.Performed;
                        object bp_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bo_);
                        bool bq_ = bp_ is CqlDateTime;
                        return bq_;
                    }


                    bool bl_() {
                        DataType br_ = FirstBladderCancerStaging?.Performed;
                        object bs_ = FHIRHelpers_4_4_000.Instance.ToValue(context, br_);
                        bool bt_ = bs_ is CqlQuantity;
                        return bt_;
                    }


                    bool bm_() {
                        DataType bu_ = FirstBladderCancerStaging?.Performed;
                        object bv_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bu_);
                        bool bw_ = bv_ is CqlInterval<CqlDateTime>;
                        return bw_;
                    }


                    bool bn_() {
                        DataType bx_ = FirstBladderCancerStaging?.Performed;
                        object by_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bx_);
                        bool bz_ = by_ is CqlInterval<CqlQuantity>;
                        return bz_;
                    }

                    if (bk_())
                    {
                        DataType ca_ = FirstBladderCancerStaging?.Performed;
                        object cb_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ca_);
                        return cb_ as CqlDateTime;
                    }
                    else if (bl_())
                    {
                        DataType cc_ = FirstBladderCancerStaging?.Performed;
                        object cd_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cc_);
                        return cd_ as CqlQuantity;
                    }
                    else if (bm_())
                    {
                        DataType ce_ = FirstBladderCancerStaging?.Performed;
                        object cf_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ce_);
                        return cf_ as CqlInterval<CqlDateTime>;
                    }
                    else if (bn_())
                    {
                        DataType cg_ = FirstBladderCancerStaging?.Performed;
                        object ch_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cg_);
                        return ch_ as CqlInterval<CqlQuantity>;
                    }
                    else
                    {
                        return null;
                    }
                }

                CqlInterval<CqlDateTime> x_ = QICoreCommon_4_0_000.Instance.toInterval(context, w_());
                CqlDateTime y_ = context.Operators.Start(x_);
                CqlQuantity z_ = context.Operators.Quantity(6m, "months");
                CqlDateTime aa_ = context.Operators.Add(y_, z_);
                CqlInterval<CqlDateTime> ab_ = context.Operators.Interval(v_, aa_, false, true);
                bool? ac_ = context.Operators.In<CqlDateTime>(s_, ab_, "day");

                object ad_() {

                    bool ci_() {
                        DataType cm_ = FirstBladderCancerStaging?.Performed;
                        object cn_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cm_);
                        bool co_ = cn_ is CqlDateTime;
                        return co_;
                    }


                    bool cj_() {
                        DataType cp_ = FirstBladderCancerStaging?.Performed;
                        object cq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cp_);
                        bool cr_ = cq_ is CqlQuantity;
                        return cr_;
                    }


                    bool ck_() {
                        DataType cs_ = FirstBladderCancerStaging?.Performed;
                        object ct_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cs_);
                        bool cu_ = ct_ is CqlInterval<CqlDateTime>;
                        return cu_;
                    }


                    bool cl_() {
                        DataType cv_ = FirstBladderCancerStaging?.Performed;
                        object cw_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cv_);
                        bool cx_ = cw_ is CqlInterval<CqlQuantity>;
                        return cx_;
                    }

                    if (ci_())
                    {
                        DataType cy_ = FirstBladderCancerStaging?.Performed;
                        object cz_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cy_);
                        return cz_ as CqlDateTime;
                    }
                    else if (cj_())
                    {
                        DataType da_ = FirstBladderCancerStaging?.Performed;
                        object db_ = FHIRHelpers_4_4_000.Instance.ToValue(context, da_);
                        return db_ as CqlQuantity;
                    }
                    else if (ck_())
                    {
                        DataType dc_ = FirstBladderCancerStaging?.Performed;
                        object dd_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dc_);
                        return dd_ as CqlInterval<CqlDateTime>;
                    }
                    else if (cl_())
                    {
                        DataType de_ = FirstBladderCancerStaging?.Performed;
                        object df_ = FHIRHelpers_4_4_000.Instance.ToValue(context, de_);
                        return df_ as CqlInterval<CqlQuantity>;
                    }
                    else
                    {
                        return null;
                    }
                }

                CqlInterval<CqlDateTime> ae_ = QICoreCommon_4_0_000.Instance.toInterval(context, ad_());
                CqlDateTime af_ = context.Operators.Start(ae_);
                bool? ag_ = context.Operators.Not((bool?)(af_ is null));
                bool? ah_ = context.Operators.And(ac_, ag_);
                return ah_;
            }

            IEnumerable<Procedure> k_ = context.Operators.Where<Procedure>((IEnumerable<Procedure>)i_, j_);
            bool? l_ = context.Operators.Exists<Procedure>(k_);
            return l_;
        }

        IEnumerable<MedicationAdministration> e_ = context.Operators.Where<MedicationAdministration>(c_, d_);

        bool? f_(MedicationAdministration BCGNotGiven) {
            List<CodeableConcept> dg_ = BCGNotGiven?.StatusReason;

            CqlConcept dh_(CodeableConcept @this) {
                CqlConcept dl_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);
                return dl_;
            }

            IEnumerable<CqlConcept> di_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)dg_, dh_);
            CqlValueSet dj_ = this.Unavailability_of_Bacillus_Calmette_Guerin_for_Urology_Care(context);
            bool? dk_ = context.Operators.ConceptsInValueSet(di_, dj_);
            return dk_;
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
                object r_ = context.Operators.LateBoundProperty<object>(M, "id.value");
                object s_ = context.Operators.LateBoundProperty<object>(MR, "medication.reference.value");
                IEnumerable<string> t_ = context.Operators.Split((string)s_, "/");
                string u_ = context.Operators.Last<string>(t_);
                bool? v_ = context.Operators.Equal(r_, u_);
                CodeableConcept w_ = M?.Code;
                CqlConcept x_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, w_);
                CqlValueSet y_ = this.Bacillus_Calmette_Guerin_for_Urology_Care(context);
                bool? z_ = context.Operators.ConceptInValueSet(x_, y_);
                bool? aa_ = context.Operators.And(v_, z_);
                return aa_;
            }

            IEnumerable<Medication> p_ = context.Operators.Where<Medication>(n_, o_);
            bool? q_ = context.Operators.Exists<Medication>(p_);
            return q_;
        }

        IEnumerable<MedicationAdministration> c_ = context.Operators.Where<MedicationAdministration>(a_, b_);
        CqlValueSet d_ = this.Bacillus_Calmette_Guerin_for_Urology_Care(context);
        IEnumerable<MedicationAdministration> e_ = context.Operators.Retrieve<MedicationAdministration>(new RetrieveParameters(default, d_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationadministration"));
        IEnumerable<MedicationAdministration> f_ = context.Operators.Union<MedicationAdministration>(c_, e_);

        bool? g_(MedicationAdministration BCG) {
            Procedure ab_ = this.First_Bladder_Cancer_Staging_Procedure(context);
            Procedure[] ac_ = [
                ab_,
            ];

            bool? ad_(Procedure FirstBladderCancerStaging) {
                DataType ag_ = BCG?.Effective;
                object ah_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ag_);
                CqlInterval<CqlDateTime> ai_ = QICoreCommon_4_0_000.Instance.toInterval(context, ah_);
                CqlDateTime aj_ = context.Operators.Start(ai_);

                object ak_() {

                    bool bc_() {
                        DataType bg_ = FirstBladderCancerStaging?.Performed;
                        object bh_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bg_);
                        bool bi_ = bh_ is CqlDateTime;
                        return bi_;
                    }


                    bool bd_() {
                        DataType bj_ = FirstBladderCancerStaging?.Performed;
                        object bk_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bj_);
                        bool bl_ = bk_ is CqlQuantity;
                        return bl_;
                    }


                    bool be_() {
                        DataType bm_ = FirstBladderCancerStaging?.Performed;
                        object bn_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bm_);
                        bool bo_ = bn_ is CqlInterval<CqlDateTime>;
                        return bo_;
                    }


                    bool bf_() {
                        DataType bp_ = FirstBladderCancerStaging?.Performed;
                        object bq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bp_);
                        bool br_ = bq_ is CqlInterval<CqlQuantity>;
                        return br_;
                    }

                    if (bc_())
                    {
                        DataType bs_ = FirstBladderCancerStaging?.Performed;
                        object bt_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bs_);
                        return bt_ as CqlDateTime;
                    }
                    else if (bd_())
                    {
                        DataType bu_ = FirstBladderCancerStaging?.Performed;
                        object bv_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bu_);
                        return bv_ as CqlQuantity;
                    }
                    else if (be_())
                    {
                        DataType bw_ = FirstBladderCancerStaging?.Performed;
                        object bx_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bw_);
                        return bx_ as CqlInterval<CqlDateTime>;
                    }
                    else if (bf_())
                    {
                        DataType by_ = FirstBladderCancerStaging?.Performed;
                        object bz_ = FHIRHelpers_4_4_000.Instance.ToValue(context, by_);
                        return bz_ as CqlInterval<CqlQuantity>;
                    }
                    else
                    {
                        return null;
                    }
                }

                CqlInterval<CqlDateTime> al_ = QICoreCommon_4_0_000.Instance.toInterval(context, ak_());
                CqlDateTime am_ = context.Operators.Start(al_);

                object an_() {

                    bool ca_() {
                        DataType ce_ = FirstBladderCancerStaging?.Performed;
                        object cf_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ce_);
                        bool cg_ = cf_ is CqlDateTime;
                        return cg_;
                    }


                    bool cb_() {
                        DataType ch_ = FirstBladderCancerStaging?.Performed;
                        object ci_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ch_);
                        bool cj_ = ci_ is CqlQuantity;
                        return cj_;
                    }


                    bool cc_() {
                        DataType ck_ = FirstBladderCancerStaging?.Performed;
                        object cl_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ck_);
                        bool cm_ = cl_ is CqlInterval<CqlDateTime>;
                        return cm_;
                    }


                    bool cd_() {
                        DataType cn_ = FirstBladderCancerStaging?.Performed;
                        object co_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cn_);
                        bool cp_ = co_ is CqlInterval<CqlQuantity>;
                        return cp_;
                    }

                    if (ca_())
                    {
                        DataType cq_ = FirstBladderCancerStaging?.Performed;
                        object cr_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cq_);
                        return cr_ as CqlDateTime;
                    }
                    else if (cb_())
                    {
                        DataType cs_ = FirstBladderCancerStaging?.Performed;
                        object ct_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cs_);
                        return ct_ as CqlQuantity;
                    }
                    else if (cc_())
                    {
                        DataType cu_ = FirstBladderCancerStaging?.Performed;
                        object cv_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cu_);
                        return cv_ as CqlInterval<CqlDateTime>;
                    }
                    else if (cd_())
                    {
                        DataType cw_ = FirstBladderCancerStaging?.Performed;
                        object cx_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cw_);
                        return cx_ as CqlInterval<CqlQuantity>;
                    }
                    else
                    {
                        return null;
                    }
                }

                CqlInterval<CqlDateTime> ao_ = QICoreCommon_4_0_000.Instance.toInterval(context, an_());
                CqlDateTime ap_ = context.Operators.Start(ao_);
                CqlQuantity aq_ = context.Operators.Quantity(6m, "months");
                CqlDateTime ar_ = context.Operators.Add(ap_, aq_);
                CqlInterval<CqlDateTime> as_ = context.Operators.Interval(am_, ar_, false, true);
                bool? at_ = context.Operators.In<CqlDateTime>(aj_, as_, "day");

                object au_() {

                    bool cy_() {
                        DataType dc_ = FirstBladderCancerStaging?.Performed;
                        object dd_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dc_);
                        bool de_ = dd_ is CqlDateTime;
                        return de_;
                    }


                    bool cz_() {
                        DataType df_ = FirstBladderCancerStaging?.Performed;
                        object dg_ = FHIRHelpers_4_4_000.Instance.ToValue(context, df_);
                        bool dh_ = dg_ is CqlQuantity;
                        return dh_;
                    }


                    bool da_() {
                        DataType di_ = FirstBladderCancerStaging?.Performed;
                        object dj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, di_);
                        bool dk_ = dj_ is CqlInterval<CqlDateTime>;
                        return dk_;
                    }


                    bool db_() {
                        DataType dl_ = FirstBladderCancerStaging?.Performed;
                        object dm_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dl_);
                        bool dn_ = dm_ is CqlInterval<CqlQuantity>;
                        return dn_;
                    }

                    if (cy_())
                    {
                        DataType do_ = FirstBladderCancerStaging?.Performed;
                        object dp_ = FHIRHelpers_4_4_000.Instance.ToValue(context, do_);
                        return dp_ as CqlDateTime;
                    }
                    else if (cz_())
                    {
                        DataType dq_ = FirstBladderCancerStaging?.Performed;
                        object dr_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dq_);
                        return dr_ as CqlQuantity;
                    }
                    else if (da_())
                    {
                        DataType ds_ = FirstBladderCancerStaging?.Performed;
                        object dt_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ds_);
                        return dt_ as CqlInterval<CqlDateTime>;
                    }
                    else if (db_())
                    {
                        DataType du_ = FirstBladderCancerStaging?.Performed;
                        object dv_ = FHIRHelpers_4_4_000.Instance.ToValue(context, du_);
                        return dv_ as CqlInterval<CqlQuantity>;
                    }
                    else
                    {
                        return null;
                    }
                }

                CqlInterval<CqlDateTime> av_ = QICoreCommon_4_0_000.Instance.toInterval(context, au_());
                CqlDateTime aw_ = context.Operators.Start(av_);
                bool? ax_ = context.Operators.Not((bool?)(aw_ is null));
                bool? ay_ = context.Operators.And(at_, ax_);
                CqlInterval<CqlDateTime> az_ = this.Measurement_Period(context);
                bool? ba_ = context.Operators.In<CqlDateTime>(aj_, az_, "day");
                bool? bb_ = context.Operators.And(ay_, ba_);
                return bb_;
            }

            IEnumerable<Procedure> ae_ = context.Operators.Where<Procedure>((IEnumerable<Procedure>)ac_, ad_);
            bool? af_ = context.Operators.Exists<Procedure>(ae_);
            return af_;
        }

        IEnumerable<MedicationAdministration> h_ = context.Operators.Where<MedicationAdministration>(f_, g_);

        bool? i_(MedicationAdministration BCG) {
            Code<MedicationAdministration.MedicationAdministrationStatusCodes> dw_ = BCG?.StatusElement;
            MedicationAdministration.MedicationAdministrationStatusCodes? dx_ = dw_?.Value;
            string dy_ = context.Operators.Convert<string>(dx_);
            string[] dz_ = [
                "in-progress",
                "completed",
            ];
            bool? ea_ = context.Operators.In<string>(dy_, (IEnumerable<string>)dz_);
            return ea_;
        }

        IEnumerable<MedicationAdministration> j_ = context.Operators.Where<MedicationAdministration>(h_, i_);

        object k_(MedicationAdministration @this) {
            DataType eb_ = @this?.Effective;
            object ec_ = FHIRHelpers_4_4_000.Instance.ToValue(context, eb_);
            CqlInterval<CqlDateTime> ed_ = QICoreCommon_4_0_000.Instance.toInterval(context, ec_);
            CqlDateTime ee_ = context.Operators.Start(ed_);
            return ee_;
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

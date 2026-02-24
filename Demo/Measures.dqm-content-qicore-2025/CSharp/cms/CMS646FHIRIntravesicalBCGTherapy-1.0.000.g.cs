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

[System.CodeDom.Compiler.GeneratedCode(".NET Code Generation", "5.0.0.0")]
[CqlLibrary("CMS646FHIRIntravesicalBCGTherapy", "1.0.000")]
public partial class CMS646FHIRIntravesicalBCGTherapy_1_0_000 : ILibrary, ISingleton<CMS646FHIRIntravesicalBCGTherapy_1_0_000>
{
    #region ValueSets

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

    #region Codes

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

    #region CodeSystems

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

    #region Parameters

    [CqlParameterDefinition("Measurement Period")]
    public CqlInterval<CqlDateTime> Measurement_Period(CqlContext context) =>
        ((ICqlContextInternals)context).GetOrCompute<CqlInterval<CqlDateTime>>(-8463204836362917612L, () => {
            CqlDateTime a_ = context.Operators.DateTime(2026, 1, 1, 0, 0, 0, 0, 0.0m);
            CqlDateTime b_ = context.Operators.DateTime(2027, 1, 1, 0, 0, 0, 0, 0.0m);
            CqlInterval<CqlDateTime> c_ = context.Operators.Interval(a_, b_, true, false);
            object d_ = context.ResolveParameter("CMS646FHIRIntravesicalBCGTherapy-1.0.000", "Measurement Period", c_);
            return (CqlInterval<CqlDateTime>)d_;
        });


    #endregion Parameters

    #region Functions and Expressions

    [CqlExpressionDefinition("Patient")]
    public Patient Patient(CqlContext context) =>
        ((ICqlContextInternals)context).GetOrCompute<Patient>(-4290830187024678405L, () => {
            IEnumerable<Patient> a_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-patient"));
            Patient b_ = context.Operators.SingletonFrom<Patient>(a_);
            return b_;
        });


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


    [CqlExpressionDefinition("Bladder Cancer Diagnosis")]
    public IEnumerable<object> Bladder_Cancer_Diagnosis(CqlContext context) =>
        ((ICqlContextInternals)context).GetOrCompute<IEnumerable<object>>(1627099199367917222L, () => {
            CqlValueSet a_ = this.Bladder_Cancer_for_Urology_Care(context);
            IEnumerable<Condition> b_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-problems-health-concerns"));
            IEnumerable<Condition> d_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-encounter-diagnosis"));
            IEnumerable<object> e_ = context.Operators.Union<object>(b_ as IEnumerable<object>, d_ as IEnumerable<object>);

            bool? f_(object BladderCancer) {
                CqlInterval<CqlDateTime> h_ = QICoreCommon_4_0_000.Instance.prevalenceInterval(context, BladderCancer);
                CqlDateTime i_ = context.Operators.Start(h_);
                CqlInterval<CqlDateTime> j_ = this.Measurement_Period(context);
                CqlDateTime k_ = context.Operators.End(j_);
                bool? l_ = context.Operators.Before(i_, k_, "day");
                object m_ = context.Operators.LateBoundProperty<object>(BladderCancer, "onset");
                object n_ = FHIRHelpers_4_4_000.Instance.ToValue(context, m_);
                CqlInterval<CqlDateTime> o_ = QICoreCommon_4_0_000.Instance.toInterval(context, n_);

                CqlInterval<CqlDateTime> p_() {

                    bool u_() {
                        CqlInterval<CqlDateTime> v_ = this.Measurement_Period(context);
                        CqlDateTime w_ = context.Operators.End(v_);
                        return w_ is null;
                    }

                    if (u_())
                    {
                        return default;
                    }
                    else
                    {
                        CqlInterval<CqlDateTime> x_ = this.Measurement_Period(context);
                        CqlDateTime y_ = context.Operators.End(x_);
                        CqlDateTime aa_ = context.Operators.End(x_);
                        CqlInterval<CqlDateTime> ab_ = context.Operators.Interval(y_, aa_, true, true);
                        return ab_;
                    };
                }

                bool? q_ = context.Operators.Before(o_, p_(), "day");
                bool? r_ = context.Operators.Or(l_, q_);
                bool? s_ = this.isVerified(context, BladderCancer);
                bool? t_ = context.Operators.And(r_, s_);
                return t_;
            }

            IEnumerable<object> g_ = context.Operators.Where<object>(e_, f_);
            return g_;
        });


    [CqlExpressionDefinition("First Bladder Cancer Staging Procedure")]
    public Procedure First_Bladder_Cancer_Staging_Procedure(CqlContext context) =>
        ((ICqlContextInternals)context).GetOrCompute<Procedure>(-6479804162207901342L, () => {
            CqlCode a_ = this.Tumor_staging__tumor_staging_(context);
            IEnumerable<CqlCode> b_ = context.Operators.ToList<CqlCode>(a_);
            IEnumerable<Procedure> c_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, default, b_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));

            IEnumerable<Procedure> d_(Procedure BladderCancerStaging) {
                IEnumerable<object> k_ = this.Bladder_Cancer_Diagnosis(context);

                bool? l_(object BladderCancer) {

                    object p_() {

                        bool v_() {
                            DataType z_ = BladderCancerStaging?.Performed;
                            object aa_ = FHIRHelpers_4_4_000.Instance.ToValue(context, z_);
                            bool ab_ = aa_ is CqlDateTime;
                            return ab_;
                        }


                        bool w_() {
                            DataType ac_ = BladderCancerStaging?.Performed;
                            object ad_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ac_);
                            bool ae_ = ad_ is CqlInterval<CqlDateTime>;
                            return ae_;
                        }


                        bool x_() {
                            DataType af_ = BladderCancerStaging?.Performed;
                            object ag_ = FHIRHelpers_4_4_000.Instance.ToValue(context, af_);
                            bool ah_ = ag_ is CqlQuantity;
                            return ah_;
                        }


                        bool y_() {
                            DataType ai_ = BladderCancerStaging?.Performed;
                            object aj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ai_);
                            bool ak_ = aj_ is CqlInterval<CqlQuantity>;
                            return ak_;
                        }

                        if (v_())
                        {
                            DataType al_ = BladderCancerStaging?.Performed;
                            object am_ = FHIRHelpers_4_4_000.Instance.ToValue(context, al_);
                            return (am_ as CqlDateTime) as object;
                        }
                        else if (w_())
                        {
                            DataType an_ = BladderCancerStaging?.Performed;
                            object ao_ = FHIRHelpers_4_4_000.Instance.ToValue(context, an_);
                            return (ao_ as CqlInterval<CqlDateTime>) as object;
                        }
                        else if (x_())
                        {
                            DataType ap_ = BladderCancerStaging?.Performed;
                            object aq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ap_);
                            return (aq_ as CqlQuantity) as object;
                        }
                        else if (y_())
                        {
                            DataType ar_ = BladderCancerStaging?.Performed;
                            object as_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ar_);
                            return (as_ as CqlInterval<CqlQuantity>) as object;
                        }
                        else
                        {
                            return null;
                        };
                    }

                    CqlInterval<CqlDateTime> q_ = QICoreCommon_4_0_000.Instance.toInterval(context, p_());
                    CqlDateTime r_ = context.Operators.Start(q_);
                    CqlInterval<CqlDateTime> s_ = QICoreCommon_4_0_000.Instance.prevalenceInterval(context, BladderCancer);
                    CqlDateTime t_ = context.Operators.Start(s_);
                    bool? u_ = context.Operators.SameOrBefore(r_, t_, "day");
                    return u_;
                }

                IEnumerable<object> m_ = context.Operators.Where<object>(k_, l_);
                Procedure n_(object BladderCancer) => BladderCancerStaging;
                IEnumerable<Procedure> o_ = context.Operators.Select<object, Procedure>(m_, n_);
                return o_;
            }

            IEnumerable<Procedure> e_ = context.Operators.SelectMany<Procedure, Procedure>(c_, d_);

            bool? f_(Procedure BladderCancerStaging) {
                Code<EventStatus> at_ = BladderCancerStaging?.StatusElement;
                EventStatus? au_ = at_?.Value;
                string av_ = context.Operators.Convert<string>(au_);
                bool? aw_ = context.Operators.Equal(av_, "completed");
                return aw_;
            }

            IEnumerable<Procedure> g_ = context.Operators.Where<Procedure>(e_, f_);

            object h_(Procedure @this) {

                object ax_() {

                    bool ba_() {
                        DataType be_ = @this?.Performed;
                        object bf_ = FHIRHelpers_4_4_000.Instance.ToValue(context, be_);
                        bool bg_ = bf_ is CqlDateTime;
                        return bg_;
                    }


                    bool bb_() {
                        DataType bh_ = @this?.Performed;
                        object bi_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bh_);
                        bool bj_ = bi_ is CqlInterval<CqlDateTime>;
                        return bj_;
                    }


                    bool bc_() {
                        DataType bk_ = @this?.Performed;
                        object bl_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bk_);
                        bool bm_ = bl_ is CqlQuantity;
                        return bm_;
                    }


                    bool bd_() {
                        DataType bn_ = @this?.Performed;
                        object bo_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bn_);
                        bool bp_ = bo_ is CqlInterval<CqlQuantity>;
                        return bp_;
                    }

                    if (ba_())
                    {
                        DataType bq_ = @this?.Performed;
                        object br_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bq_);
                        return (br_ as CqlDateTime) as object;
                    }
                    else if (bb_())
                    {
                        DataType bs_ = @this?.Performed;
                        object bt_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bs_);
                        return (bt_ as CqlInterval<CqlDateTime>) as object;
                    }
                    else if (bc_())
                    {
                        DataType bu_ = @this?.Performed;
                        object bv_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bu_);
                        return (bv_ as CqlQuantity) as object;
                    }
                    else if (bd_())
                    {
                        DataType bw_ = @this?.Performed;
                        object bx_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bw_);
                        return (bx_ as CqlInterval<CqlQuantity>) as object;
                    }
                    else
                    {
                        return null;
                    };
                }

                CqlInterval<CqlDateTime> ay_ = QICoreCommon_4_0_000.Instance.toInterval(context, ax_());
                CqlDateTime az_ = context.Operators.Start(ay_);
                return az_;
            }

            IEnumerable<Procedure> i_ = context.Operators.SortBy<Procedure>(g_, h_, System.ComponentModel.ListSortDirection.Ascending);
            Procedure j_ = context.Operators.First<Procedure>(i_);
            return j_;
        });


    [CqlExpressionDefinition("July 1 of Year Prior to the Measurement Period")]
    public CqlDate July_1_of_Year_Prior_to_the_Measurement_Period(CqlContext context) =>
        ((ICqlContextInternals)context).GetOrCompute<CqlDate>(4355411619980945622L, () => {
            CqlInterval<CqlDateTime> a_ = this.Measurement_Period(context);
            CqlDateTime b_ = context.Operators.Start(a_);
            int? c_ = context.Operators.DateTimeComponentFrom(b_, "year");
            int? d_ = context.Operators.Subtract(c_, 1);
            CqlDate e_ = context.Operators.Date(d_, 7, 1);
            return e_;
        });


    [CqlExpressionDefinition("June 30 of the Measurement Period")]
    public CqlDate June_30_of_the_Measurement_Period(CqlContext context) =>
        ((ICqlContextInternals)context).GetOrCompute<CqlDate>(-1046525714915697033L, () => {
            CqlInterval<CqlDateTime> a_ = this.Measurement_Period(context);
            CqlDateTime b_ = context.Operators.Start(a_);
            int? c_ = context.Operators.DateTimeComponentFrom(b_, "year");
            CqlDate d_ = context.Operators.Date(c_, 6, 30);
            return d_;
        });


    [CqlExpressionDefinition("First Bladder Cancer Staging Procedure during 6 Months Prior to Measurement Period through the First 6 Months of Measurement Period")]
    public Procedure First_Bladder_Cancer_Staging_Procedure_during_6_Months_Prior_to_Measurement_Period_through_the_First_6_Months_of_Measurement_Period(CqlContext context) =>
        ((ICqlContextInternals)context).GetOrCompute<Procedure>(89116089794995532L, () => {
            Procedure a_ = this.First_Bladder_Cancer_Staging_Procedure(context);
            Procedure[] b_ = [
                a_,
            ];

            bool? c_(Procedure FirstBladderCancerStaging) {
                CqlDate f_ = this.July_1_of_Year_Prior_to_the_Measurement_Period(context);
                CqlDate g_ = this.June_30_of_the_Measurement_Period(context);
                CqlInterval<CqlDate> h_ = context.Operators.Interval(f_, g_, true, true);
                CqlDate i_ = h_?.low;
                CqlDateTime j_ = context.Operators.ConvertDateToDateTime(i_);
                CqlInterval<CqlDate> m_ = context.Operators.Interval(f_, g_, true, true);
                CqlDate n_ = m_?.high;
                CqlDateTime o_ = context.Operators.ConvertDateToDateTime(n_);
                CqlInterval<CqlDate> r_ = context.Operators.Interval(f_, g_, true, true);
                bool? s_ = r_?.lowClosed;
                CqlInterval<CqlDate> v_ = context.Operators.Interval(f_, g_, true, true);
                bool? w_ = v_?.highClosed;
                CqlInterval<CqlDateTime> x_ = context.Operators.Interval(j_, o_, s_, w_);

                object y_() {

                    bool ab_() {
                        DataType af_ = FirstBladderCancerStaging?.Performed;
                        object ag_ = FHIRHelpers_4_4_000.Instance.ToValue(context, af_);
                        bool ah_ = ag_ is CqlDateTime;
                        return ah_;
                    }


                    bool ac_() {
                        DataType ai_ = FirstBladderCancerStaging?.Performed;
                        object aj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ai_);
                        bool ak_ = aj_ is CqlInterval<CqlDateTime>;
                        return ak_;
                    }


                    bool ad_() {
                        DataType al_ = FirstBladderCancerStaging?.Performed;
                        object am_ = FHIRHelpers_4_4_000.Instance.ToValue(context, al_);
                        bool an_ = am_ is CqlQuantity;
                        return an_;
                    }


                    bool ae_() {
                        DataType ao_ = FirstBladderCancerStaging?.Performed;
                        object ap_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ao_);
                        bool aq_ = ap_ is CqlInterval<CqlQuantity>;
                        return aq_;
                    }

                    if (ab_())
                    {
                        DataType ar_ = FirstBladderCancerStaging?.Performed;
                        object as_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ar_);
                        return (as_ as CqlDateTime) as object;
                    }
                    else if (ac_())
                    {
                        DataType at_ = FirstBladderCancerStaging?.Performed;
                        object au_ = FHIRHelpers_4_4_000.Instance.ToValue(context, at_);
                        return (au_ as CqlInterval<CqlDateTime>) as object;
                    }
                    else if (ad_())
                    {
                        DataType av_ = FirstBladderCancerStaging?.Performed;
                        object aw_ = FHIRHelpers_4_4_000.Instance.ToValue(context, av_);
                        return (aw_ as CqlQuantity) as object;
                    }
                    else if (ae_())
                    {
                        DataType ax_ = FirstBladderCancerStaging?.Performed;
                        object ay_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ax_);
                        return (ay_ as CqlInterval<CqlQuantity>) as object;
                    }
                    else
                    {
                        return null;
                    };
                }

                CqlInterval<CqlDateTime> z_ = QICoreCommon_4_0_000.Instance.toInterval(context, y_());
                bool? aa_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(x_, z_, "day");
                return aa_;
            }

            IEnumerable<Procedure> d_ = context.Operators.Where<Procedure>((IEnumerable<Procedure>)b_, c_);
            Procedure e_ = context.Operators.SingletonFrom<Procedure>(d_);
            return e_;
        });


    [CqlExpressionDefinition("Has Most Recent Bladder Cancer Tumor Staging is T1, Tis, Ta HG")]
    public bool? Has_Most_Recent_Bladder_Cancer_Tumor_Staging_is_T1__Tis__Ta_HG(CqlContext context) =>
        ((ICqlContextInternals)context).GetOrCompute<bool?>(7659224977212191128L, () => {
            IEnumerable<Observation> a_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation-lab"));

            bool? b_(Observation StagingObservation) {
                IEnumerable<Procedure> e_ = this.getStagingProcedure(context, StagingObservation);
                bool? f_ = context.Operators.Not((bool?)(e_ is null));
                DataType g_ = StagingObservation?.Value;
                object h_ = FHIRHelpers_4_4_000.Instance.ToValue(context, g_);
                CqlCode i_ = this.American_Joint_Committee_on_Cancer_cT1__qualifier_value_(context);
                CqlConcept j_ = context.Operators.ConvertCodeToConcept(i_);
                bool? k_ = context.Operators.Equivalent(h_ as CqlConcept, j_);
                object m_ = FHIRHelpers_4_4_000.Instance.ToValue(context, g_);
                CqlCode n_ = this.American_Joint_Committee_on_Cancer_cTis__qualifier_value_(context);
                CqlConcept o_ = context.Operators.ConvertCodeToConcept(n_);
                bool? p_ = context.Operators.Equivalent(m_ as CqlConcept, o_);
                bool? q_ = context.Operators.Or(k_, p_);
                object s_ = FHIRHelpers_4_4_000.Instance.ToValue(context, g_);
                CqlCode t_ = this.American_Joint_Committee_on_Cancer_cTa__qualifier_value_(context);
                CqlConcept u_ = context.Operators.ConvertCodeToConcept(t_);
                bool? v_ = context.Operators.Equivalent(s_ as CqlConcept, u_);
                bool? w_ = context.Operators.Or(q_, v_);
                object y_ = FHIRHelpers_4_4_000.Instance.ToValue(context, g_);
                CqlCode z_ = this.Carcinoma_in_situ_of_bladder(context);
                CqlConcept aa_ = context.Operators.ConvertCodeToConcept(z_);
                bool? ab_ = context.Operators.Equivalent(y_ as CqlConcept, aa_);
                bool? ac_ = context.Operators.Or(w_, ab_);
                bool? ad_ = context.Operators.And(f_, ac_);
                Code<ObservationStatus> ae_ = StagingObservation?.StatusElement;
                ObservationStatus? af_ = ae_?.Value;
                string ag_ = context.Operators.Convert<string>(af_);
                string[] ah_ = [
                    "final",
                    "amended",
                    "corrected",
                ];
                bool? ai_ = context.Operators.In<string>(ag_, (IEnumerable<string>)ah_);
                bool? aj_ = context.Operators.And(ad_, ai_);
                return aj_;
            }

            IEnumerable<Observation> c_ = context.Operators.Where<Observation>(a_, b_);
            bool? d_ = context.Operators.Exists<Observation>(c_);
            return d_;
        });


    [CqlExpressionDefinition("Has Qualifying Encounter")]
    public bool? Has_Qualifying_Encounter(CqlContext context) =>
        ((ICqlContextInternals)context).GetOrCompute<bool?>(6803347589664215006L, () => {
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
        });


    [CqlExpressionDefinition("Initial Population")]
    public bool? Initial_Population(CqlContext context) =>
        ((ICqlContextInternals)context).GetOrCompute<bool?>(-1514878663221881824L, () => {
            bool? a_ = this.Has_Most_Recent_Bladder_Cancer_Tumor_Staging_is_T1__Tis__Ta_HG(context);
            bool? b_ = this.Has_Qualifying_Encounter(context);
            bool? c_ = context.Operators.And(a_, b_);
            return c_;
        });


    [CqlExpressionDefinition("Denominator")]
    public bool? Denominator(CqlContext context) =>
        ((ICqlContextInternals)context).GetOrCompute<bool?>(7894348376586324006L, () => {
            bool? a_ = this.Initial_Population(context);
            return a_;
        });


    [CqlExpressionDefinition("Acute Tuberculosis Diagnosis")]
    public IEnumerable<object> Acute_Tuberculosis_Diagnosis(CqlContext context) =>
        ((ICqlContextInternals)context).GetOrCompute<IEnumerable<object>>(2327826037250116643L, () => {
            CqlValueSet a_ = this.Tuberculosis_for_Urology_Care(context);
            IEnumerable<Condition> b_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-problems-health-concerns"));
            IEnumerable<Condition> d_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-encounter-diagnosis"));
            IEnumerable<object> e_ = context.Operators.Union<object>(b_ as IEnumerable<object>, d_ as IEnumerable<object>);

            IEnumerable<object> f_(object ActiveTuberculosis) {
                Procedure j_ = this.First_Bladder_Cancer_Staging_Procedure(context);
                Procedure[] k_ = [
                    j_,
                ];

                bool? l_(Procedure FirstBladderCancerStaging) {
                    CqlInterval<CqlDateTime> p_ = QICoreCommon_4_0_000.Instance.prevalenceInterval(context, ActiveTuberculosis);

                    object q_() {

                        bool ak_() {
                            DataType ao_ = FirstBladderCancerStaging?.Performed;
                            object ap_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ao_);
                            bool aq_ = ap_ is CqlDateTime;
                            return aq_;
                        }


                        bool al_() {
                            DataType ar_ = FirstBladderCancerStaging?.Performed;
                            object as_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ar_);
                            bool at_ = as_ is CqlInterval<CqlDateTime>;
                            return at_;
                        }


                        bool am_() {
                            DataType au_ = FirstBladderCancerStaging?.Performed;
                            object av_ = FHIRHelpers_4_4_000.Instance.ToValue(context, au_);
                            bool aw_ = av_ is CqlQuantity;
                            return aw_;
                        }


                        bool an_() {
                            DataType ax_ = FirstBladderCancerStaging?.Performed;
                            object ay_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ax_);
                            bool az_ = ay_ is CqlInterval<CqlQuantity>;
                            return az_;
                        }

                        if (ak_())
                        {
                            DataType ba_ = FirstBladderCancerStaging?.Performed;
                            object bb_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ba_);
                            return (bb_ as CqlDateTime) as object;
                        }
                        else if (al_())
                        {
                            DataType bc_ = FirstBladderCancerStaging?.Performed;
                            object bd_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bc_);
                            return (bd_ as CqlInterval<CqlDateTime>) as object;
                        }
                        else if (am_())
                        {
                            DataType be_ = FirstBladderCancerStaging?.Performed;
                            object bf_ = FHIRHelpers_4_4_000.Instance.ToValue(context, be_);
                            return (bf_ as CqlQuantity) as object;
                        }
                        else if (an_())
                        {
                            DataType bg_ = FirstBladderCancerStaging?.Performed;
                            object bh_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bg_);
                            return (bh_ as CqlInterval<CqlQuantity>) as object;
                        }
                        else
                        {
                            return null;
                        };
                    }

                    CqlInterval<CqlDateTime> r_ = QICoreCommon_4_0_000.Instance.toInterval(context, q_());
                    bool? s_ = context.Operators.OverlapsAfter(p_, r_, "day");
                    object t_ = context.Operators.LateBoundProperty<object>(ActiveTuberculosis, "onset");
                    object u_ = FHIRHelpers_4_4_000.Instance.ToValue(context, t_);
                    CqlInterval<CqlDateTime> v_ = QICoreCommon_4_0_000.Instance.toInterval(context, u_);

                    object w_() {

                        bool bi_() {
                            DataType bm_ = FirstBladderCancerStaging?.Performed;
                            object bn_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bm_);
                            bool bo_ = bn_ is CqlDateTime;
                            return bo_;
                        }


                        bool bj_() {
                            DataType bp_ = FirstBladderCancerStaging?.Performed;
                            object bq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bp_);
                            bool br_ = bq_ is CqlInterval<CqlDateTime>;
                            return br_;
                        }


                        bool bk_() {
                            DataType bs_ = FirstBladderCancerStaging?.Performed;
                            object bt_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bs_);
                            bool bu_ = bt_ is CqlQuantity;
                            return bu_;
                        }


                        bool bl_() {
                            DataType bv_ = FirstBladderCancerStaging?.Performed;
                            object bw_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bv_);
                            bool bx_ = bw_ is CqlInterval<CqlQuantity>;
                            return bx_;
                        }

                        if (bi_())
                        {
                            DataType by_ = FirstBladderCancerStaging?.Performed;
                            object bz_ = FHIRHelpers_4_4_000.Instance.ToValue(context, by_);
                            return (bz_ as CqlDateTime) as object;
                        }
                        else if (bj_())
                        {
                            DataType ca_ = FirstBladderCancerStaging?.Performed;
                            object cb_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ca_);
                            return (cb_ as CqlInterval<CqlDateTime>) as object;
                        }
                        else if (bk_())
                        {
                            DataType cc_ = FirstBladderCancerStaging?.Performed;
                            object cd_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cc_);
                            return (cd_ as CqlQuantity) as object;
                        }
                        else if (bl_())
                        {
                            DataType ce_ = FirstBladderCancerStaging?.Performed;
                            object cf_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ce_);
                            return (cf_ as CqlInterval<CqlQuantity>) as object;
                        }
                        else
                        {
                            return null;
                        };
                    }

                    CqlInterval<CqlDateTime> x_ = QICoreCommon_4_0_000.Instance.toInterval(context, w_());
                    bool? y_ = context.Operators.OverlapsAfter(v_, x_, "day");
                    object z_ = context.Operators.LateBoundProperty<object>(ActiveTuberculosis, "abatement");
                    object aa_ = FHIRHelpers_4_4_000.Instance.ToValue(context, z_);
                    CqlInterval<CqlDateTime> ab_ = QICoreCommon_4_0_000.Instance.toInterval(context, aa_);

                    object ac_() {

                        bool cg_() {
                            DataType ck_ = FirstBladderCancerStaging?.Performed;
                            object cl_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ck_);
                            bool cm_ = cl_ is CqlDateTime;
                            return cm_;
                        }


                        bool ch_() {
                            DataType cn_ = FirstBladderCancerStaging?.Performed;
                            object co_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cn_);
                            bool cp_ = co_ is CqlInterval<CqlDateTime>;
                            return cp_;
                        }


                        bool ci_() {
                            DataType cq_ = FirstBladderCancerStaging?.Performed;
                            object cr_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cq_);
                            bool cs_ = cr_ is CqlQuantity;
                            return cs_;
                        }


                        bool cj_() {
                            DataType ct_ = FirstBladderCancerStaging?.Performed;
                            object cu_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ct_);
                            bool cv_ = cu_ is CqlInterval<CqlQuantity>;
                            return cv_;
                        }

                        if (cg_())
                        {
                            DataType cw_ = FirstBladderCancerStaging?.Performed;
                            object cx_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cw_);
                            return (cx_ as CqlDateTime) as object;
                        }
                        else if (ch_())
                        {
                            DataType cy_ = FirstBladderCancerStaging?.Performed;
                            object cz_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cy_);
                            return (cz_ as CqlInterval<CqlDateTime>) as object;
                        }
                        else if (ci_())
                        {
                            DataType da_ = FirstBladderCancerStaging?.Performed;
                            object db_ = FHIRHelpers_4_4_000.Instance.ToValue(context, da_);
                            return (db_ as CqlQuantity) as object;
                        }
                        else if (cj_())
                        {
                            DataType dc_ = FirstBladderCancerStaging?.Performed;
                            object dd_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dc_);
                            return (dd_ as CqlInterval<CqlQuantity>) as object;
                        }
                        else
                        {
                            return null;
                        };
                    }

                    CqlInterval<CqlDateTime> ad_ = QICoreCommon_4_0_000.Instance.toInterval(context, ac_());
                    bool? ae_ = context.Operators.OverlapsAfter(ab_, ad_, "day");
                    object ag_ = FHIRHelpers_4_4_000.Instance.ToValue(context, z_);
                    bool? ah_ = context.Operators.Or(ae_, (bool?)(ag_ is null));
                    bool? ai_ = context.Operators.And(y_, ah_);
                    bool? aj_ = context.Operators.Or(s_, ai_);
                    return aj_;
                }

                IEnumerable<Procedure> m_ = context.Operators.Where<Procedure>((IEnumerable<Procedure>)k_, l_);
                object n_(Procedure FirstBladderCancerStaging) => ActiveTuberculosis;
                IEnumerable<object> o_ = context.Operators.Select<Procedure, object>(m_, n_);
                return o_;
            }

            IEnumerable<object> g_ = context.Operators.SelectMany<object, object>(e_, f_);

            bool? h_(object ActiveTuberculosis) {
                bool? de_ = this.isVerified(context, ActiveTuberculosis);
                return de_;
            }

            IEnumerable<object> i_ = context.Operators.Where<object>(g_, h_);
            return i_;
        });


    [CqlExpressionDefinition("Immunosuppressive Drugs")]
    public IEnumerable<MedicationRequest> Immunosuppressive_Drugs(CqlContext context) =>
        ((ICqlContextInternals)context).GetOrCompute<IEnumerable<MedicationRequest>>(-1231276537500245830L, () => {
            CqlValueSet a_ = this.Immunosuppressive_Drugs_for_Urology_Care(context);
            IEnumerable<MedicationRequest> b_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
            IEnumerable<MedicationRequest> c_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));

            IEnumerable<MedicationRequest> d_(MedicationRequest MR) {
                IEnumerable<Medication> k_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));

                bool? l_(Medication M) {
                    object p_ = context.Operators.LateBoundProperty<object>(M, "id.value");
                    object q_ = context.Operators.LateBoundProperty<object>(MR, "medication.reference.value");
                    IEnumerable<string> r_ = context.Operators.Split((string)q_, "/");
                    string s_ = context.Operators.Last<string>(r_);
                    bool? t_ = context.Operators.Equal(p_, s_);
                    CodeableConcept u_ = M?.Code;
                    CqlConcept v_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, u_);
                    CqlValueSet w_ = this.Immunosuppressive_Drugs_for_Urology_Care(context);
                    bool? x_ = context.Operators.ConceptInValueSet(v_, w_);
                    bool? y_ = context.Operators.And(t_, x_);
                    return y_;
                }

                IEnumerable<Medication> m_ = context.Operators.Where<Medication>(k_, l_);
                MedicationRequest n_(Medication M) => MR;
                IEnumerable<MedicationRequest> o_ = context.Operators.Select<Medication, MedicationRequest>(m_, n_);
                return o_;
            }

            IEnumerable<MedicationRequest> e_ = context.Operators.SelectMany<MedicationRequest, MedicationRequest>(c_, d_);
            IEnumerable<MedicationRequest> f_ = context.Operators.Union<MedicationRequest>(b_, e_);

            IEnumerable<MedicationRequest> g_(MedicationRequest ImmunosuppressiveDrugs) {
                Procedure z_ = this.First_Bladder_Cancer_Staging_Procedure(context);
                Procedure[] aa_ = [
                    z_,
                ];

                bool? ab_(Procedure FirstBladderCancerStaging) {
                    List<Dosage> af_ = ImmunosuppressiveDrugs?.DosageInstruction;

                    bool? ag_(Dosage @this) {
                        Timing bp_ = @this?.Timing;
                        bool? bq_ = context.Operators.Not((bool?)(bp_ is null));
                        return bq_;
                    }

                    IEnumerable<Dosage> ah_ = context.Operators.Where<Dosage>((IEnumerable<Dosage>)af_, ag_);

                    Timing ai_(Dosage @this) {
                        Timing br_ = @this?.Timing;
                        return br_;
                    }

                    IEnumerable<Timing> aj_ = context.Operators.Select<Dosage, Timing>(ah_, ai_);

                    CqlDateTime ak_(Timing dosageTiming) {
                        List<FhirDateTime> bs_ = dosageTiming?.EventElement;

                        string bt_(FhirDateTime @this) {
                            string bz_ = @this?.Value;
                            return bz_;
                        }

                        IEnumerable<string> bu_ = context.Operators.Select<FhirDateTime, string>((IEnumerable<FhirDateTime>)bs_, bt_);

                        CqlDateTime bv_(string @string) {
                            CqlDateTime ca_ = context.Operators.ConvertStringToDateTime(@string);
                            return ca_;
                        }

                        IEnumerable<CqlDateTime> bw_ = context.Operators.Select<string, CqlDateTime>(bu_, bv_);
                        IEnumerable<CqlDateTime> bx_ = context.Operators.ListSort<CqlDateTime>(bw_, System.ComponentModel.ListSortDirection.Ascending);
                        CqlDateTime by_ = context.Operators.First<CqlDateTime>(bx_);
                        return by_;
                    }

                    IEnumerable<CqlDateTime> al_ = context.Operators.Select<Timing, CqlDateTime>(aj_, ak_);
                    IEnumerable<CqlDateTime> am_ = context.Operators.Distinct<CqlDateTime>(al_);
                    IEnumerable<CqlDateTime> an_ = context.Operators.ListSort<CqlDateTime>(am_, System.ComponentModel.ListSortDirection.Ascending);
                    CqlDateTime ao_ = context.Operators.First<CqlDateTime>(an_);
                    CqlInterval<CqlDateTime> ap_ = QICoreCommon_4_0_000.Instance.toInterval(context, ao_ as object);

                    bool? ar_(Dosage @this) {
                        Timing cb_ = @this?.Timing;
                        bool? cc_ = context.Operators.Not((bool?)(cb_ is null));
                        return cc_;
                    }

                    IEnumerable<Dosage> as_ = context.Operators.Where<Dosage>((IEnumerable<Dosage>)af_, ar_);

                    Timing at_(Dosage @this) {
                        Timing cd_ = @this?.Timing;
                        return cd_;
                    }

                    IEnumerable<Timing> au_ = context.Operators.Select<Dosage, Timing>(as_, at_);

                    bool? av_(Timing @this) {
                        Timing.RepeatComponent ce_ = @this?.Repeat;
                        bool? cf_ = context.Operators.Not((bool?)(ce_ is null));
                        return cf_;
                    }

                    IEnumerable<Timing> aw_ = context.Operators.Where<Timing>(au_, av_);

                    Timing.RepeatComponent ax_(Timing @this) {
                        Timing.RepeatComponent cg_ = @this?.Repeat;
                        return cg_;
                    }

                    IEnumerable<Timing.RepeatComponent> ay_ = context.Operators.Select<Timing, Timing.RepeatComponent>(aw_, ax_);

                    bool? az_(Timing.RepeatComponent @this) {
                        DataType ch_ = @this?.Bounds;
                        object ci_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ch_);
                        bool? cj_ = context.Operators.Not((bool?)(ci_ is null));
                        return cj_;
                    }

                    IEnumerable<Timing.RepeatComponent> ba_ = context.Operators.Where<Timing.RepeatComponent>(ay_, az_);

                    object bb_(Timing.RepeatComponent @this) {
                        DataType ck_ = @this?.Bounds;
                        object cl_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ck_);
                        return cl_;
                    }

                    IEnumerable<object> bc_ = context.Operators.Select<Timing.RepeatComponent, object>(ba_, bb_);

                    CqlInterval<CqlDateTime> bd_(object DoseTime) {
                        CqlInterval<CqlDateTime> cm_ = QICoreCommon_4_0_000.Instance.toInterval(context, DoseTime);
                        return cm_;
                    }

                    IEnumerable<CqlInterval<CqlDateTime>> be_ = context.Operators.Select<object, CqlInterval<CqlDateTime>>(bc_, bd_);
                    IEnumerable<CqlInterval<CqlDateTime>> bf_ = context.Operators.Distinct<CqlInterval<CqlDateTime>>(be_);
                    IEnumerable<CqlInterval<CqlDateTime>> bg_ = context.Operators.Collapse(bf_, (string)default);

                    object bh_(CqlInterval<CqlDateTime> @this) {
                        CqlDateTime cn_ = context.Operators.Start(@this);
                        return cn_;
                    }

                    IEnumerable<CqlInterval<CqlDateTime>> bi_ = context.Operators.SortBy<CqlInterval<CqlDateTime>>(bg_, bh_, System.ComponentModel.ListSortDirection.Ascending);
                    CqlInterval<CqlDateTime> bj_ = context.Operators.First<CqlInterval<CqlDateTime>>(bi_);
                    CqlDateTime bk_ = context.Operators.Start(ap_ ?? bj_);

                    object bl_() {

                        bool co_() {
                            DataType cs_ = FirstBladderCancerStaging?.Performed;
                            object ct_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cs_);
                            bool cu_ = ct_ is CqlDateTime;
                            return cu_;
                        }


                        bool cp_() {
                            DataType cv_ = FirstBladderCancerStaging?.Performed;
                            object cw_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cv_);
                            bool cx_ = cw_ is CqlInterval<CqlDateTime>;
                            return cx_;
                        }


                        bool cq_() {
                            DataType cy_ = FirstBladderCancerStaging?.Performed;
                            object cz_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cy_);
                            bool da_ = cz_ is CqlQuantity;
                            return da_;
                        }


                        bool cr_() {
                            DataType db_ = FirstBladderCancerStaging?.Performed;
                            object dc_ = FHIRHelpers_4_4_000.Instance.ToValue(context, db_);
                            bool dd_ = dc_ is CqlInterval<CqlQuantity>;
                            return dd_;
                        }

                        if (co_())
                        {
                            DataType de_ = FirstBladderCancerStaging?.Performed;
                            object df_ = FHIRHelpers_4_4_000.Instance.ToValue(context, de_);
                            return (df_ as CqlDateTime) as object;
                        }
                        else if (cp_())
                        {
                            DataType dg_ = FirstBladderCancerStaging?.Performed;
                            object dh_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dg_);
                            return (dh_ as CqlInterval<CqlDateTime>) as object;
                        }
                        else if (cq_())
                        {
                            DataType di_ = FirstBladderCancerStaging?.Performed;
                            object dj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, di_);
                            return (dj_ as CqlQuantity) as object;
                        }
                        else if (cr_())
                        {
                            DataType dk_ = FirstBladderCancerStaging?.Performed;
                            object dl_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dk_);
                            return (dl_ as CqlInterval<CqlQuantity>) as object;
                        }
                        else
                        {
                            return null;
                        };
                    }

                    CqlInterval<CqlDateTime> bm_ = QICoreCommon_4_0_000.Instance.toInterval(context, bl_());
                    CqlDateTime bn_ = context.Operators.Start(bm_);
                    bool? bo_ = context.Operators.SameOrBefore(bk_, bn_, "day");
                    return bo_;
                }

                IEnumerable<Procedure> ac_ = context.Operators.Where<Procedure>((IEnumerable<Procedure>)aa_, ab_);
                MedicationRequest ad_(Procedure FirstBladderCancerStaging) => ImmunosuppressiveDrugs;
                IEnumerable<MedicationRequest> ae_ = context.Operators.Select<Procedure, MedicationRequest>(ac_, ad_);
                return ae_;
            }

            IEnumerable<MedicationRequest> h_ = context.Operators.SelectMany<MedicationRequest, MedicationRequest>(f_, g_);

            bool? i_(MedicationRequest ImmunosuppressiveDrugs) {
                Code<MedicationRequest.MedicationrequestStatus> dm_ = ImmunosuppressiveDrugs?.StatusElement;
                MedicationRequest.MedicationrequestStatus? dn_ = dm_?.Value;
                string do_ = context.Operators.Convert<string>(dn_);
                string[] dp_ = [
                    "active",
                    "completed",
                ];
                bool? dq_ = context.Operators.In<string>(do_, (IEnumerable<string>)dp_);
                Code<MedicationRequest.MedicationRequestIntent> dr_ = ImmunosuppressiveDrugs?.IntentElement;
                MedicationRequest.MedicationRequestIntent? ds_ = dr_?.Value;
                string dt_ = context.Operators.Convert<string>(ds_);
                bool? du_ = context.Operators.Equal(dt_, "order");
                bool? dv_ = context.Operators.And(dq_, du_);
                return dv_;
            }

            IEnumerable<MedicationRequest> j_ = context.Operators.Where<MedicationRequest>(h_, i_);
            return j_;
        });


    [CqlExpressionDefinition("Cystectomy Done")]
    public IEnumerable<Procedure> Cystectomy_Done(CqlContext context) =>
        ((ICqlContextInternals)context).GetOrCompute<IEnumerable<Procedure>>(4990480937945600756L, () => {
            CqlValueSet a_ = this.Cystectomy_for_Urology_Care(context);
            IEnumerable<Procedure> b_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));

            IEnumerable<Procedure> c_(Procedure Cystectomy) {
                Procedure g_ = this.First_Bladder_Cancer_Staging_Procedure(context);
                Procedure[] h_ = [
                    g_,
                ];

                bool? i_(Procedure FirstBladderCancerStaging) {

                    object m_() {

                        bool ae_() {
                            DataType ai_ = Cystectomy?.Performed;
                            object aj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ai_);
                            bool ak_ = aj_ is CqlDateTime;
                            return ak_;
                        }


                        bool af_() {
                            DataType al_ = Cystectomy?.Performed;
                            object am_ = FHIRHelpers_4_4_000.Instance.ToValue(context, al_);
                            bool an_ = am_ is CqlInterval<CqlDateTime>;
                            return an_;
                        }


                        bool ag_() {
                            DataType ao_ = Cystectomy?.Performed;
                            object ap_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ao_);
                            bool aq_ = ap_ is CqlQuantity;
                            return aq_;
                        }


                        bool ah_() {
                            DataType ar_ = Cystectomy?.Performed;
                            object as_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ar_);
                            bool at_ = as_ is CqlInterval<CqlQuantity>;
                            return at_;
                        }

                        if (ae_())
                        {
                            DataType au_ = Cystectomy?.Performed;
                            object av_ = FHIRHelpers_4_4_000.Instance.ToValue(context, au_);
                            return (av_ as CqlDateTime) as object;
                        }
                        else if (af_())
                        {
                            DataType aw_ = Cystectomy?.Performed;
                            object ax_ = FHIRHelpers_4_4_000.Instance.ToValue(context, aw_);
                            return (ax_ as CqlInterval<CqlDateTime>) as object;
                        }
                        else if (ag_())
                        {
                            DataType ay_ = Cystectomy?.Performed;
                            object az_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ay_);
                            return (az_ as CqlQuantity) as object;
                        }
                        else if (ah_())
                        {
                            DataType ba_ = Cystectomy?.Performed;
                            object bb_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ba_);
                            return (bb_ as CqlInterval<CqlQuantity>) as object;
                        }
                        else
                        {
                            return null;
                        };
                    }

                    CqlInterval<CqlDateTime> n_ = QICoreCommon_4_0_000.Instance.toInterval(context, m_());
                    CqlDateTime o_ = context.Operators.End(n_);

                    object p_() {

                        bool bc_() {
                            DataType bg_ = FirstBladderCancerStaging?.Performed;
                            object bh_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bg_);
                            bool bi_ = bh_ is CqlDateTime;
                            return bi_;
                        }


                        bool bd_() {
                            DataType bj_ = FirstBladderCancerStaging?.Performed;
                            object bk_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bj_);
                            bool bl_ = bk_ is CqlInterval<CqlDateTime>;
                            return bl_;
                        }


                        bool be_() {
                            DataType bm_ = FirstBladderCancerStaging?.Performed;
                            object bn_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bm_);
                            bool bo_ = bn_ is CqlQuantity;
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
                            return (bt_ as CqlDateTime) as object;
                        }
                        else if (bd_())
                        {
                            DataType bu_ = FirstBladderCancerStaging?.Performed;
                            object bv_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bu_);
                            return (bv_ as CqlInterval<CqlDateTime>) as object;
                        }
                        else if (be_())
                        {
                            DataType bw_ = FirstBladderCancerStaging?.Performed;
                            object bx_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bw_);
                            return (bx_ as CqlQuantity) as object;
                        }
                        else if (bf_())
                        {
                            DataType by_ = FirstBladderCancerStaging?.Performed;
                            object bz_ = FHIRHelpers_4_4_000.Instance.ToValue(context, by_);
                            return (bz_ as CqlInterval<CqlQuantity>) as object;
                        }
                        else
                        {
                            return null;
                        };
                    }

                    CqlInterval<CqlDateTime> q_ = QICoreCommon_4_0_000.Instance.toInterval(context, p_());
                    CqlDateTime r_ = context.Operators.Start(q_);
                    CqlQuantity s_ = context.Operators.Quantity(6m, "months");
                    CqlDateTime t_ = context.Operators.Subtract(r_, s_);

                    object u_() {

                        bool ca_() {
                            DataType ce_ = FirstBladderCancerStaging?.Performed;
                            object cf_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ce_);
                            bool cg_ = cf_ is CqlDateTime;
                            return cg_;
                        }


                        bool cb_() {
                            DataType ch_ = FirstBladderCancerStaging?.Performed;
                            object ci_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ch_);
                            bool cj_ = ci_ is CqlInterval<CqlDateTime>;
                            return cj_;
                        }


                        bool cc_() {
                            DataType ck_ = FirstBladderCancerStaging?.Performed;
                            object cl_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ck_);
                            bool cm_ = cl_ is CqlQuantity;
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
                            return (cr_ as CqlDateTime) as object;
                        }
                        else if (cb_())
                        {
                            DataType cs_ = FirstBladderCancerStaging?.Performed;
                            object ct_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cs_);
                            return (ct_ as CqlInterval<CqlDateTime>) as object;
                        }
                        else if (cc_())
                        {
                            DataType cu_ = FirstBladderCancerStaging?.Performed;
                            object cv_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cu_);
                            return (cv_ as CqlQuantity) as object;
                        }
                        else if (cd_())
                        {
                            DataType cw_ = FirstBladderCancerStaging?.Performed;
                            object cx_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cw_);
                            return (cx_ as CqlInterval<CqlQuantity>) as object;
                        }
                        else
                        {
                            return null;
                        };
                    }

                    CqlInterval<CqlDateTime> v_ = QICoreCommon_4_0_000.Instance.toInterval(context, u_());
                    CqlDateTime w_ = context.Operators.Start(v_);
                    CqlInterval<CqlDateTime> x_ = context.Operators.Interval(t_, w_, true, false);
                    bool? y_ = context.Operators.In<CqlDateTime>(o_, x_, "day");

                    object z_() {

                        bool cy_() {
                            DataType dc_ = FirstBladderCancerStaging?.Performed;
                            object dd_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dc_);
                            bool de_ = dd_ is CqlDateTime;
                            return de_;
                        }


                        bool cz_() {
                            DataType df_ = FirstBladderCancerStaging?.Performed;
                            object dg_ = FHIRHelpers_4_4_000.Instance.ToValue(context, df_);
                            bool dh_ = dg_ is CqlInterval<CqlDateTime>;
                            return dh_;
                        }


                        bool da_() {
                            DataType di_ = FirstBladderCancerStaging?.Performed;
                            object dj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, di_);
                            bool dk_ = dj_ is CqlQuantity;
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
                            return (dp_ as CqlDateTime) as object;
                        }
                        else if (cz_())
                        {
                            DataType dq_ = FirstBladderCancerStaging?.Performed;
                            object dr_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dq_);
                            return (dr_ as CqlInterval<CqlDateTime>) as object;
                        }
                        else if (da_())
                        {
                            DataType ds_ = FirstBladderCancerStaging?.Performed;
                            object dt_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ds_);
                            return (dt_ as CqlQuantity) as object;
                        }
                        else if (db_())
                        {
                            DataType du_ = FirstBladderCancerStaging?.Performed;
                            object dv_ = FHIRHelpers_4_4_000.Instance.ToValue(context, du_);
                            return (dv_ as CqlInterval<CqlQuantity>) as object;
                        }
                        else
                        {
                            return null;
                        };
                    }

                    CqlInterval<CqlDateTime> aa_ = QICoreCommon_4_0_000.Instance.toInterval(context, z_());
                    CqlDateTime ab_ = context.Operators.Start(aa_);
                    bool? ac_ = context.Operators.Not((bool?)(ab_ is null));
                    bool? ad_ = context.Operators.And(y_, ac_);
                    return ad_;
                }

                IEnumerable<Procedure> j_ = context.Operators.Where<Procedure>((IEnumerable<Procedure>)h_, i_);
                Procedure k_(Procedure FirstBladderCancerStaging) => Cystectomy;
                IEnumerable<Procedure> l_ = context.Operators.Select<Procedure, Procedure>(j_, k_);
                return l_;
            }

            IEnumerable<Procedure> d_ = context.Operators.SelectMany<Procedure, Procedure>(b_, c_);

            bool? e_(Procedure Cystectomy) {
                Code<EventStatus> dw_ = Cystectomy?.StatusElement;
                EventStatus? dx_ = dw_?.Value;
                string dy_ = context.Operators.Convert<string>(dx_);
                bool? dz_ = context.Operators.Equal(dy_, "completed");
                return dz_;
            }

            IEnumerable<Procedure> f_ = context.Operators.Where<Procedure>(d_, e_);
            return f_;
        });


    [CqlExpressionDefinition("Has Excluding HIV, Immunocompromised Conditions or Mixed Histology Before Staging")]
    public bool? Has_Excluding_HIV__Immunocompromised_Conditions_or_Mixed_Histology_Before_Staging(CqlContext context) =>
        ((ICqlContextInternals)context).GetOrCompute<bool?>(-2614027900018808318L, () => {
            CqlValueSet a_ = this.HIV(context);
            IEnumerable<Condition> b_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-problems-health-concerns"));
            IEnumerable<Condition> d_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-encounter-diagnosis"));
            IEnumerable<object> e_ = context.Operators.Union<object>(b_ as IEnumerable<object>, d_ as IEnumerable<object>);
            CqlValueSet f_ = this.Immunocompromised_Conditions(context);
            IEnumerable<Condition> g_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, f_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-problems-health-concerns"));
            IEnumerable<Condition> i_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, f_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-encounter-diagnosis"));
            IEnumerable<object> j_ = context.Operators.Union<object>(g_ as IEnumerable<object>, i_ as IEnumerable<object>);
            IEnumerable<object> k_ = context.Operators.Union<object>(e_, j_);
            CqlValueSet l_ = this.Mixed_Histology_Urothelial_Cell_Carcinoma_for_Urology_Care(context);
            IEnumerable<Condition> m_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, l_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-problems-health-concerns"));
            IEnumerable<Condition> o_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, l_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-encounter-diagnosis"));
            IEnumerable<object> p_ = context.Operators.Union<object>(m_ as IEnumerable<object>, o_ as IEnumerable<object>);
            IEnumerable<object> q_ = context.Operators.Union<object>(k_, p_);

            IEnumerable<object> r_(object ExclusionDiagnosis) {
                Procedure w_ = this.First_Bladder_Cancer_Staging_Procedure(context);
                Procedure[] x_ = [
                    w_,
                ];

                bool? y_(Procedure FirstBladderCancerStaging) {
                    CqlInterval<CqlDateTime> ac_ = QICoreCommon_4_0_000.Instance.prevalenceInterval(context, ExclusionDiagnosis);
                    CqlDateTime ad_ = context.Operators.Start(ac_);

                    object ae_() {

                        bool ar_() {
                            DataType av_ = FirstBladderCancerStaging?.Performed;
                            object aw_ = FHIRHelpers_4_4_000.Instance.ToValue(context, av_);
                            bool ax_ = aw_ is CqlDateTime;
                            return ax_;
                        }


                        bool as_() {
                            DataType ay_ = FirstBladderCancerStaging?.Performed;
                            object az_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ay_);
                            bool ba_ = az_ is CqlInterval<CqlDateTime>;
                            return ba_;
                        }


                        bool at_() {
                            DataType bb_ = FirstBladderCancerStaging?.Performed;
                            object bc_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bb_);
                            bool bd_ = bc_ is CqlQuantity;
                            return bd_;
                        }


                        bool au_() {
                            DataType be_ = FirstBladderCancerStaging?.Performed;
                            object bf_ = FHIRHelpers_4_4_000.Instance.ToValue(context, be_);
                            bool bg_ = bf_ is CqlInterval<CqlQuantity>;
                            return bg_;
                        }

                        if (ar_())
                        {
                            DataType bh_ = FirstBladderCancerStaging?.Performed;
                            object bi_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bh_);
                            return (bi_ as CqlDateTime) as object;
                        }
                        else if (as_())
                        {
                            DataType bj_ = FirstBladderCancerStaging?.Performed;
                            object bk_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bj_);
                            return (bk_ as CqlInterval<CqlDateTime>) as object;
                        }
                        else if (at_())
                        {
                            DataType bl_ = FirstBladderCancerStaging?.Performed;
                            object bm_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bl_);
                            return (bm_ as CqlQuantity) as object;
                        }
                        else if (au_())
                        {
                            DataType bn_ = FirstBladderCancerStaging?.Performed;
                            object bo_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bn_);
                            return (bo_ as CqlInterval<CqlQuantity>) as object;
                        }
                        else
                        {
                            return null;
                        };
                    }

                    CqlInterval<CqlDateTime> af_ = QICoreCommon_4_0_000.Instance.toInterval(context, ae_());
                    CqlDateTime ag_ = context.Operators.Start(af_);
                    bool? ah_ = context.Operators.SameOrBefore(ad_, ag_, "day");
                    object ai_ = context.Operators.LateBoundProperty<object>(ExclusionDiagnosis, "onset");
                    object aj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ai_);
                    CqlInterval<CqlDateTime> ak_ = QICoreCommon_4_0_000.Instance.toInterval(context, aj_);
                    CqlDateTime al_ = context.Operators.Start(ak_);

                    object am_() {

                        bool bp_() {
                            DataType bt_ = FirstBladderCancerStaging?.Performed;
                            object bu_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bt_);
                            bool bv_ = bu_ is CqlDateTime;
                            return bv_;
                        }


                        bool bq_() {
                            DataType bw_ = FirstBladderCancerStaging?.Performed;
                            object bx_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bw_);
                            bool by_ = bx_ is CqlInterval<CqlDateTime>;
                            return by_;
                        }


                        bool br_() {
                            DataType bz_ = FirstBladderCancerStaging?.Performed;
                            object ca_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bz_);
                            bool cb_ = ca_ is CqlQuantity;
                            return cb_;
                        }


                        bool bs_() {
                            DataType cc_ = FirstBladderCancerStaging?.Performed;
                            object cd_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cc_);
                            bool ce_ = cd_ is CqlInterval<CqlQuantity>;
                            return ce_;
                        }

                        if (bp_())
                        {
                            DataType cf_ = FirstBladderCancerStaging?.Performed;
                            object cg_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cf_);
                            return (cg_ as CqlDateTime) as object;
                        }
                        else if (bq_())
                        {
                            DataType ch_ = FirstBladderCancerStaging?.Performed;
                            object ci_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ch_);
                            return (ci_ as CqlInterval<CqlDateTime>) as object;
                        }
                        else if (br_())
                        {
                            DataType cj_ = FirstBladderCancerStaging?.Performed;
                            object ck_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cj_);
                            return (ck_ as CqlQuantity) as object;
                        }
                        else if (bs_())
                        {
                            DataType cl_ = FirstBladderCancerStaging?.Performed;
                            object cm_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cl_);
                            return (cm_ as CqlInterval<CqlQuantity>) as object;
                        }
                        else
                        {
                            return null;
                        };
                    }

                    CqlInterval<CqlDateTime> an_ = QICoreCommon_4_0_000.Instance.toInterval(context, am_());
                    CqlDateTime ao_ = context.Operators.Start(an_);
                    bool? ap_ = context.Operators.SameOrBefore(al_, ao_, "day");
                    bool? aq_ = context.Operators.Or(ah_, ap_);
                    return aq_;
                }

                IEnumerable<Procedure> z_ = context.Operators.Where<Procedure>((IEnumerable<Procedure>)x_, y_);
                object aa_(Procedure FirstBladderCancerStaging) => ExclusionDiagnosis;
                IEnumerable<object> ab_ = context.Operators.Select<Procedure, object>(z_, aa_);
                return ab_;
            }

            IEnumerable<object> s_ = context.Operators.SelectMany<object, object>(q_, r_);

            bool? t_(object ExclusionDiagnosis) {
                bool? cn_ = this.isVerified(context, ExclusionDiagnosis);
                return cn_;
            }

            IEnumerable<object> u_ = context.Operators.Where<object>(s_, t_);
            bool? v_ = context.Operators.Exists<object>(u_);
            return v_;
        });


    [CqlExpressionDefinition("Has Excluding Chemotherapy or Radiotherapy Procedure Before Staging")]
    public bool? Has_Excluding_Chemotherapy_or_Radiotherapy_Procedure_Before_Staging(CqlContext context) =>
        ((ICqlContextInternals)context).GetOrCompute<bool?>(52129356822395367L, () => {
            CqlValueSet a_ = this.Chemotherapy_Agents_for_Advanced_Cancer(context);
            IEnumerable<MedicationRequest> b_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
            IEnumerable<MedicationRequest> c_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));

            IEnumerable<MedicationRequest> d_(MedicationRequest MR) {
                IEnumerable<Medication> t_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));

                bool? u_(Medication M) {
                    object y_ = context.Operators.LateBoundProperty<object>(M, "id.value");
                    object z_ = context.Operators.LateBoundProperty<object>(MR, "medication.reference.value");
                    IEnumerable<string> aa_ = context.Operators.Split((string)z_, "/");
                    string ab_ = context.Operators.Last<string>(aa_);
                    bool? ac_ = context.Operators.Equal(y_, ab_);
                    CodeableConcept ad_ = M?.Code;
                    CqlConcept ae_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, ad_);
                    CqlValueSet af_ = this.Chemotherapy_Agents_for_Advanced_Cancer(context);
                    bool? ag_ = context.Operators.ConceptInValueSet(ae_, af_);
                    bool? ah_ = context.Operators.And(ac_, ag_);
                    return ah_;
                }

                IEnumerable<Medication> v_ = context.Operators.Where<Medication>(t_, u_);
                MedicationRequest w_(Medication M) => MR;
                IEnumerable<MedicationRequest> x_ = context.Operators.Select<Medication, MedicationRequest>(v_, w_);
                return x_;
            }

            IEnumerable<MedicationRequest> e_ = context.Operators.SelectMany<MedicationRequest, MedicationRequest>(c_, d_);
            IEnumerable<MedicationRequest> f_ = context.Operators.Union<MedicationRequest>(b_, e_);

            IEnumerable<MedicationRequest> g_(MedicationRequest ExclusionMed) {
                Procedure ai_ = this.First_Bladder_Cancer_Staging_Procedure(context);
                Procedure[] aj_ = [
                    ai_,
                ];

                bool? ak_(Procedure FirstBladderCancerStaging) {
                    List<Dosage> ao_ = ExclusionMed?.DosageInstruction;

                    bool? ap_(Dosage @this) {
                        Timing by_ = @this?.Timing;
                        bool? bz_ = context.Operators.Not((bool?)(by_ is null));
                        return bz_;
                    }

                    IEnumerable<Dosage> aq_ = context.Operators.Where<Dosage>((IEnumerable<Dosage>)ao_, ap_);

                    Timing ar_(Dosage @this) {
                        Timing ca_ = @this?.Timing;
                        return ca_;
                    }

                    IEnumerable<Timing> as_ = context.Operators.Select<Dosage, Timing>(aq_, ar_);

                    bool? at_(Timing @this) {
                        Timing.RepeatComponent cb_ = @this?.Repeat;
                        bool? cc_ = context.Operators.Not((bool?)(cb_ is null));
                        return cc_;
                    }

                    IEnumerable<Timing> au_ = context.Operators.Where<Timing>(as_, at_);

                    Timing.RepeatComponent av_(Timing @this) {
                        Timing.RepeatComponent cd_ = @this?.Repeat;
                        return cd_;
                    }

                    IEnumerable<Timing.RepeatComponent> aw_ = context.Operators.Select<Timing, Timing.RepeatComponent>(au_, av_);

                    bool? ax_(Timing.RepeatComponent @this) {
                        DataType ce_ = @this?.Bounds;
                        object cf_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ce_);
                        bool? cg_ = context.Operators.Not((bool?)(cf_ is null));
                        return cg_;
                    }

                    IEnumerable<Timing.RepeatComponent> ay_ = context.Operators.Where<Timing.RepeatComponent>(aw_, ax_);

                    object az_(Timing.RepeatComponent @this) {
                        DataType ch_ = @this?.Bounds;
                        object ci_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ch_);
                        return ci_;
                    }

                    IEnumerable<object> ba_ = context.Operators.Select<Timing.RepeatComponent, object>(ay_, az_);

                    CqlInterval<CqlDateTime> bb_(object DoseTime) {
                        CqlInterval<CqlDateTime> cj_ = QICoreCommon_4_0_000.Instance.toInterval(context, DoseTime);
                        return cj_;
                    }

                    IEnumerable<CqlInterval<CqlDateTime>> bc_ = context.Operators.Select<object, CqlInterval<CqlDateTime>>(ba_, bb_);
                    IEnumerable<CqlInterval<CqlDateTime>> bd_ = context.Operators.Distinct<CqlInterval<CqlDateTime>>(bc_);
                    IEnumerable<CqlInterval<CqlDateTime>> be_ = context.Operators.Collapse(bd_, (string)default);

                    object bf_(CqlInterval<CqlDateTime> @this) {
                        CqlDateTime ck_ = context.Operators.Start(@this);
                        return ck_;
                    }

                    IEnumerable<CqlInterval<CqlDateTime>> bg_ = context.Operators.SortBy<CqlInterval<CqlDateTime>>(be_, bf_, System.ComponentModel.ListSortDirection.Ascending);
                    CqlInterval<CqlDateTime> bh_ = context.Operators.First<CqlInterval<CqlDateTime>>(bg_);
                    CqlDateTime bi_ = context.Operators.Start(bh_);

                    object bj_() {

                        bool cl_() {
                            DataType cp_ = FirstBladderCancerStaging?.Performed;
                            object cq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cp_);
                            bool cr_ = cq_ is CqlDateTime;
                            return cr_;
                        }


                        bool cm_() {
                            DataType cs_ = FirstBladderCancerStaging?.Performed;
                            object ct_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cs_);
                            bool cu_ = ct_ is CqlInterval<CqlDateTime>;
                            return cu_;
                        }


                        bool cn_() {
                            DataType cv_ = FirstBladderCancerStaging?.Performed;
                            object cw_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cv_);
                            bool cx_ = cw_ is CqlQuantity;
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
                            return (dc_ as CqlDateTime) as object;
                        }
                        else if (cm_())
                        {
                            DataType dd_ = FirstBladderCancerStaging?.Performed;
                            object de_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dd_);
                            return (de_ as CqlInterval<CqlDateTime>) as object;
                        }
                        else if (cn_())
                        {
                            DataType df_ = FirstBladderCancerStaging?.Performed;
                            object dg_ = FHIRHelpers_4_4_000.Instance.ToValue(context, df_);
                            return (dg_ as CqlQuantity) as object;
                        }
                        else if (co_())
                        {
                            DataType dh_ = FirstBladderCancerStaging?.Performed;
                            object di_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dh_);
                            return (di_ as CqlInterval<CqlQuantity>) as object;
                        }
                        else
                        {
                            return null;
                        };
                    }

                    CqlInterval<CqlDateTime> bk_ = QICoreCommon_4_0_000.Instance.toInterval(context, bj_());
                    CqlDateTime bl_ = context.Operators.Start(bk_);
                    CqlQuantity bm_ = context.Operators.Quantity(6m, "months");
                    CqlDateTime bn_ = context.Operators.Subtract(bl_, bm_);

                    object bo_() {

                        bool dj_() {
                            DataType dn_ = FirstBladderCancerStaging?.Performed;
                            object do_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dn_);
                            bool dp_ = do_ is CqlDateTime;
                            return dp_;
                        }


                        bool dk_() {
                            DataType dq_ = FirstBladderCancerStaging?.Performed;
                            object dr_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dq_);
                            bool ds_ = dr_ is CqlInterval<CqlDateTime>;
                            return ds_;
                        }


                        bool dl_() {
                            DataType dt_ = FirstBladderCancerStaging?.Performed;
                            object du_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dt_);
                            bool dv_ = du_ is CqlQuantity;
                            return dv_;
                        }


                        bool dm_() {
                            DataType dw_ = FirstBladderCancerStaging?.Performed;
                            object dx_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dw_);
                            bool dy_ = dx_ is CqlInterval<CqlQuantity>;
                            return dy_;
                        }

                        if (dj_())
                        {
                            DataType dz_ = FirstBladderCancerStaging?.Performed;
                            object ea_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dz_);
                            return (ea_ as CqlDateTime) as object;
                        }
                        else if (dk_())
                        {
                            DataType eb_ = FirstBladderCancerStaging?.Performed;
                            object ec_ = FHIRHelpers_4_4_000.Instance.ToValue(context, eb_);
                            return (ec_ as CqlInterval<CqlDateTime>) as object;
                        }
                        else if (dl_())
                        {
                            DataType ed_ = FirstBladderCancerStaging?.Performed;
                            object ee_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ed_);
                            return (ee_ as CqlQuantity) as object;
                        }
                        else if (dm_())
                        {
                            DataType ef_ = FirstBladderCancerStaging?.Performed;
                            object eg_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ef_);
                            return (eg_ as CqlInterval<CqlQuantity>) as object;
                        }
                        else
                        {
                            return null;
                        };
                    }

                    CqlInterval<CqlDateTime> bp_ = QICoreCommon_4_0_000.Instance.toInterval(context, bo_());
                    CqlDateTime bq_ = context.Operators.Start(bp_);
                    CqlInterval<CqlDateTime> br_ = context.Operators.Interval(bn_, bq_, true, false);
                    bool? bs_ = context.Operators.In<CqlDateTime>(bi_, br_, (string)default);

                    object bt_() {

                        bool eh_() {
                            DataType el_ = FirstBladderCancerStaging?.Performed;
                            object em_ = FHIRHelpers_4_4_000.Instance.ToValue(context, el_);
                            bool en_ = em_ is CqlDateTime;
                            return en_;
                        }


                        bool ei_() {
                            DataType eo_ = FirstBladderCancerStaging?.Performed;
                            object ep_ = FHIRHelpers_4_4_000.Instance.ToValue(context, eo_);
                            bool eq_ = ep_ is CqlInterval<CqlDateTime>;
                            return eq_;
                        }


                        bool ej_() {
                            DataType er_ = FirstBladderCancerStaging?.Performed;
                            object es_ = FHIRHelpers_4_4_000.Instance.ToValue(context, er_);
                            bool et_ = es_ is CqlQuantity;
                            return et_;
                        }


                        bool ek_() {
                            DataType eu_ = FirstBladderCancerStaging?.Performed;
                            object ev_ = FHIRHelpers_4_4_000.Instance.ToValue(context, eu_);
                            bool ew_ = ev_ is CqlInterval<CqlQuantity>;
                            return ew_;
                        }

                        if (eh_())
                        {
                            DataType ex_ = FirstBladderCancerStaging?.Performed;
                            object ey_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ex_);
                            return (ey_ as CqlDateTime) as object;
                        }
                        else if (ei_())
                        {
                            DataType ez_ = FirstBladderCancerStaging?.Performed;
                            object fa_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ez_);
                            return (fa_ as CqlInterval<CqlDateTime>) as object;
                        }
                        else if (ej_())
                        {
                            DataType fb_ = FirstBladderCancerStaging?.Performed;
                            object fc_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fb_);
                            return (fc_ as CqlQuantity) as object;
                        }
                        else if (ek_())
                        {
                            DataType fd_ = FirstBladderCancerStaging?.Performed;
                            object fe_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fd_);
                            return (fe_ as CqlInterval<CqlQuantity>) as object;
                        }
                        else
                        {
                            return null;
                        };
                    }

                    CqlInterval<CqlDateTime> bu_ = QICoreCommon_4_0_000.Instance.toInterval(context, bt_());
                    CqlDateTime bv_ = context.Operators.Start(bu_);
                    bool? bw_ = context.Operators.Not((bool?)(bv_ is null));
                    bool? bx_ = context.Operators.And(bs_, bw_);
                    return bx_;
                }

                IEnumerable<Procedure> al_ = context.Operators.Where<Procedure>((IEnumerable<Procedure>)aj_, ak_);
                MedicationRequest am_(Procedure FirstBladderCancerStaging) => ExclusionMed;
                IEnumerable<MedicationRequest> an_ = context.Operators.Select<Procedure, MedicationRequest>(al_, am_);
                return an_;
            }

            IEnumerable<MedicationRequest> h_ = context.Operators.SelectMany<MedicationRequest, MedicationRequest>(f_, g_);

            bool? i_(MedicationRequest ExclusionMed) {
                Code<MedicationRequest.MedicationrequestStatus> ff_ = ExclusionMed?.StatusElement;
                MedicationRequest.MedicationrequestStatus? fg_ = ff_?.Value;
                string fh_ = context.Operators.Convert<string>(fg_);
                string[] fi_ = [
                    "active",
                    "completed",
                ];
                bool? fj_ = context.Operators.In<string>(fh_, (IEnumerable<string>)fi_);
                Code<MedicationRequest.MedicationRequestIntent> fk_ = ExclusionMed?.IntentElement;
                MedicationRequest.MedicationRequestIntent? fl_ = fk_?.Value;
                string fm_ = context.Operators.Convert<string>(fl_);
                bool? fn_ = context.Operators.Equal(fm_, "order");
                bool? fo_ = context.Operators.And(fj_, fn_);
                return fo_;
            }

            IEnumerable<MedicationRequest> j_ = context.Operators.Where<MedicationRequest>(h_, i_);
            CqlCode k_ = this.Combined_radiotherapy__procedure_(context);
            IEnumerable<CqlCode> l_ = context.Operators.ToList<CqlCode>(k_);
            IEnumerable<Procedure> m_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, default, l_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));

            IEnumerable<Procedure> n_(Procedure ExclusionProcedure) {
                Procedure fp_ = this.First_Bladder_Cancer_Staging_Procedure(context);
                Procedure[] fq_ = [
                    fp_,
                ];

                bool? fr_(Procedure FirstBladderCancerStaging) {

                    object fv_() {

                        bool gn_() {
                            DataType gr_ = ExclusionProcedure?.Performed;
                            object gs_ = FHIRHelpers_4_4_000.Instance.ToValue(context, gr_);
                            bool gt_ = gs_ is CqlDateTime;
                            return gt_;
                        }


                        bool go_() {
                            DataType gu_ = ExclusionProcedure?.Performed;
                            object gv_ = FHIRHelpers_4_4_000.Instance.ToValue(context, gu_);
                            bool gw_ = gv_ is CqlInterval<CqlDateTime>;
                            return gw_;
                        }


                        bool gp_() {
                            DataType gx_ = ExclusionProcedure?.Performed;
                            object gy_ = FHIRHelpers_4_4_000.Instance.ToValue(context, gx_);
                            bool gz_ = gy_ is CqlQuantity;
                            return gz_;
                        }


                        bool gq_() {
                            DataType ha_ = ExclusionProcedure?.Performed;
                            object hb_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ha_);
                            bool hc_ = hb_ is CqlInterval<CqlQuantity>;
                            return hc_;
                        }

                        if (gn_())
                        {
                            DataType hd_ = ExclusionProcedure?.Performed;
                            object he_ = FHIRHelpers_4_4_000.Instance.ToValue(context, hd_);
                            return (he_ as CqlDateTime) as object;
                        }
                        else if (go_())
                        {
                            DataType hf_ = ExclusionProcedure?.Performed;
                            object hg_ = FHIRHelpers_4_4_000.Instance.ToValue(context, hf_);
                            return (hg_ as CqlInterval<CqlDateTime>) as object;
                        }
                        else if (gp_())
                        {
                            DataType hh_ = ExclusionProcedure?.Performed;
                            object hi_ = FHIRHelpers_4_4_000.Instance.ToValue(context, hh_);
                            return (hi_ as CqlQuantity) as object;
                        }
                        else if (gq_())
                        {
                            DataType hj_ = ExclusionProcedure?.Performed;
                            object hk_ = FHIRHelpers_4_4_000.Instance.ToValue(context, hj_);
                            return (hk_ as CqlInterval<CqlQuantity>) as object;
                        }
                        else
                        {
                            return null;
                        };
                    }

                    CqlInterval<CqlDateTime> fw_ = QICoreCommon_4_0_000.Instance.toInterval(context, fv_());
                    CqlDateTime fx_ = context.Operators.Start(fw_);

                    object fy_() {

                        bool hl_() {
                            DataType hp_ = FirstBladderCancerStaging?.Performed;
                            object hq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, hp_);
                            bool hr_ = hq_ is CqlDateTime;
                            return hr_;
                        }


                        bool hm_() {
                            DataType hs_ = FirstBladderCancerStaging?.Performed;
                            object ht_ = FHIRHelpers_4_4_000.Instance.ToValue(context, hs_);
                            bool hu_ = ht_ is CqlInterval<CqlDateTime>;
                            return hu_;
                        }


                        bool hn_() {
                            DataType hv_ = FirstBladderCancerStaging?.Performed;
                            object hw_ = FHIRHelpers_4_4_000.Instance.ToValue(context, hv_);
                            bool hx_ = hw_ is CqlQuantity;
                            return hx_;
                        }


                        bool ho_() {
                            DataType hy_ = FirstBladderCancerStaging?.Performed;
                            object hz_ = FHIRHelpers_4_4_000.Instance.ToValue(context, hy_);
                            bool ia_ = hz_ is CqlInterval<CqlQuantity>;
                            return ia_;
                        }

                        if (hl_())
                        {
                            DataType ib_ = FirstBladderCancerStaging?.Performed;
                            object ic_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ib_);
                            return (ic_ as CqlDateTime) as object;
                        }
                        else if (hm_())
                        {
                            DataType id_ = FirstBladderCancerStaging?.Performed;
                            object ie_ = FHIRHelpers_4_4_000.Instance.ToValue(context, id_);
                            return (ie_ as CqlInterval<CqlDateTime>) as object;
                        }
                        else if (hn_())
                        {
                            DataType if_ = FirstBladderCancerStaging?.Performed;
                            object ig_ = FHIRHelpers_4_4_000.Instance.ToValue(context, if_);
                            return (ig_ as CqlQuantity) as object;
                        }
                        else if (ho_())
                        {
                            DataType ih_ = FirstBladderCancerStaging?.Performed;
                            object ii_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ih_);
                            return (ii_ as CqlInterval<CqlQuantity>) as object;
                        }
                        else
                        {
                            return null;
                        };
                    }

                    CqlInterval<CqlDateTime> fz_ = QICoreCommon_4_0_000.Instance.toInterval(context, fy_());
                    CqlDateTime ga_ = context.Operators.Start(fz_);
                    CqlQuantity gb_ = context.Operators.Quantity(6m, "months");
                    CqlDateTime gc_ = context.Operators.Subtract(ga_, gb_);

                    object gd_() {

                        bool ij_() {
                            DataType in_ = FirstBladderCancerStaging?.Performed;
                            object io_ = FHIRHelpers_4_4_000.Instance.ToValue(context, in_);
                            bool ip_ = io_ is CqlDateTime;
                            return ip_;
                        }


                        bool ik_() {
                            DataType iq_ = FirstBladderCancerStaging?.Performed;
                            object ir_ = FHIRHelpers_4_4_000.Instance.ToValue(context, iq_);
                            bool is_ = ir_ is CqlInterval<CqlDateTime>;
                            return is_;
                        }


                        bool il_() {
                            DataType it_ = FirstBladderCancerStaging?.Performed;
                            object iu_ = FHIRHelpers_4_4_000.Instance.ToValue(context, it_);
                            bool iv_ = iu_ is CqlQuantity;
                            return iv_;
                        }


                        bool im_() {
                            DataType iw_ = FirstBladderCancerStaging?.Performed;
                            object ix_ = FHIRHelpers_4_4_000.Instance.ToValue(context, iw_);
                            bool iy_ = ix_ is CqlInterval<CqlQuantity>;
                            return iy_;
                        }

                        if (ij_())
                        {
                            DataType iz_ = FirstBladderCancerStaging?.Performed;
                            object ja_ = FHIRHelpers_4_4_000.Instance.ToValue(context, iz_);
                            return (ja_ as CqlDateTime) as object;
                        }
                        else if (ik_())
                        {
                            DataType jb_ = FirstBladderCancerStaging?.Performed;
                            object jc_ = FHIRHelpers_4_4_000.Instance.ToValue(context, jb_);
                            return (jc_ as CqlInterval<CqlDateTime>) as object;
                        }
                        else if (il_())
                        {
                            DataType jd_ = FirstBladderCancerStaging?.Performed;
                            object je_ = FHIRHelpers_4_4_000.Instance.ToValue(context, jd_);
                            return (je_ as CqlQuantity) as object;
                        }
                        else if (im_())
                        {
                            DataType jf_ = FirstBladderCancerStaging?.Performed;
                            object jg_ = FHIRHelpers_4_4_000.Instance.ToValue(context, jf_);
                            return (jg_ as CqlInterval<CqlQuantity>) as object;
                        }
                        else
                        {
                            return null;
                        };
                    }

                    CqlInterval<CqlDateTime> ge_ = QICoreCommon_4_0_000.Instance.toInterval(context, gd_());
                    CqlDateTime gf_ = context.Operators.Start(ge_);
                    CqlInterval<CqlDateTime> gg_ = context.Operators.Interval(gc_, gf_, true, false);
                    bool? gh_ = context.Operators.In<CqlDateTime>(fx_, gg_, (string)default);

                    object gi_() {

                        bool jh_() {
                            DataType jl_ = FirstBladderCancerStaging?.Performed;
                            object jm_ = FHIRHelpers_4_4_000.Instance.ToValue(context, jl_);
                            bool jn_ = jm_ is CqlDateTime;
                            return jn_;
                        }


                        bool ji_() {
                            DataType jo_ = FirstBladderCancerStaging?.Performed;
                            object jp_ = FHIRHelpers_4_4_000.Instance.ToValue(context, jo_);
                            bool jq_ = jp_ is CqlInterval<CqlDateTime>;
                            return jq_;
                        }


                        bool jj_() {
                            DataType jr_ = FirstBladderCancerStaging?.Performed;
                            object js_ = FHIRHelpers_4_4_000.Instance.ToValue(context, jr_);
                            bool jt_ = js_ is CqlQuantity;
                            return jt_;
                        }


                        bool jk_() {
                            DataType ju_ = FirstBladderCancerStaging?.Performed;
                            object jv_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ju_);
                            bool jw_ = jv_ is CqlInterval<CqlQuantity>;
                            return jw_;
                        }

                        if (jh_())
                        {
                            DataType jx_ = FirstBladderCancerStaging?.Performed;
                            object jy_ = FHIRHelpers_4_4_000.Instance.ToValue(context, jx_);
                            return (jy_ as CqlDateTime) as object;
                        }
                        else if (ji_())
                        {
                            DataType jz_ = FirstBladderCancerStaging?.Performed;
                            object ka_ = FHIRHelpers_4_4_000.Instance.ToValue(context, jz_);
                            return (ka_ as CqlInterval<CqlDateTime>) as object;
                        }
                        else if (jj_())
                        {
                            DataType kb_ = FirstBladderCancerStaging?.Performed;
                            object kc_ = FHIRHelpers_4_4_000.Instance.ToValue(context, kb_);
                            return (kc_ as CqlQuantity) as object;
                        }
                        else if (jk_())
                        {
                            DataType kd_ = FirstBladderCancerStaging?.Performed;
                            object ke_ = FHIRHelpers_4_4_000.Instance.ToValue(context, kd_);
                            return (ke_ as CqlInterval<CqlQuantity>) as object;
                        }
                        else
                        {
                            return null;
                        };
                    }

                    CqlInterval<CqlDateTime> gj_ = QICoreCommon_4_0_000.Instance.toInterval(context, gi_());
                    CqlDateTime gk_ = context.Operators.Start(gj_);
                    bool? gl_ = context.Operators.Not((bool?)(gk_ is null));
                    bool? gm_ = context.Operators.And(gh_, gl_);
                    return gm_;
                }

                IEnumerable<Procedure> fs_ = context.Operators.Where<Procedure>((IEnumerable<Procedure>)fq_, fr_);
                Procedure ft_(Procedure FirstBladderCancerStaging) => ExclusionProcedure;
                IEnumerable<Procedure> fu_ = context.Operators.Select<Procedure, Procedure>(fs_, ft_);
                return fu_;
            }

            IEnumerable<Procedure> o_ = context.Operators.SelectMany<Procedure, Procedure>(m_, n_);

            bool? p_(Procedure ExclusionProcedure) {
                Code<EventStatus> kf_ = ExclusionProcedure?.StatusElement;
                EventStatus? kg_ = kf_?.Value;
                string kh_ = context.Operators.Convert<string>(kg_);
                string[] ki_ = [
                    "completed",
                    "in-progress",
                ];
                bool? kj_ = context.Operators.In<string>(kh_, (IEnumerable<string>)ki_);
                return kj_;
            }

            IEnumerable<Procedure> q_ = context.Operators.Where<Procedure>(o_, p_);
            IEnumerable<object> r_ = context.Operators.Union<object>(j_ as IEnumerable<object>, q_ as IEnumerable<object>);
            bool? s_ = context.Operators.Exists<object>(r_);
            return s_;
        });


    [CqlExpressionDefinition("Denominator Exclusion")]
    public bool? Denominator_Exclusion(CqlContext context) =>
        ((ICqlContextInternals)context).GetOrCompute<bool?>(-2497759738663303621L, () => {
            IEnumerable<object> a_ = this.Acute_Tuberculosis_Diagnosis(context);
            bool? b_ = context.Operators.Exists<object>(a_);
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
        });


    [CqlExpressionDefinition("BCG Not Available Within 6 Months After Bladder Cancer Staging")]
    public IEnumerable<MedicationAdministration> BCG_Not_Available_Within_6_Months_After_Bladder_Cancer_Staging(CqlContext context) =>
        ((ICqlContextInternals)context).GetOrCompute<IEnumerable<MedicationAdministration>>(-4719968472254698824L, () => {
            CqlValueSet a_ = this.Bacillus_Calmette_Guerin_for_Urology_Care(context);
            IEnumerable<MedicationAdministration> b_ = context.Operators.Retrieve<MedicationAdministration>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationadministrationnotdone"));
            IEnumerable<MedicationAdministration> d_ = context.Operators.Retrieve<MedicationAdministration>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationadministrationnotdone"));
            IEnumerable<MedicationAdministration> e_ = context.Operators.Union<MedicationAdministration>(b_, d_);

            IEnumerable<MedicationAdministration> f_(MedicationAdministration BCGNotGiven) {
                Procedure j_ = this.First_Bladder_Cancer_Staging_Procedure(context);
                Procedure[] k_ = [
                    j_,
                ];

                bool? l_(Procedure FirstBladderCancerStaging) {

                    bool? p_(Extension @this) {
                        FhirUri al_ = @this?.UrlElement;
                        string am_ = FHIRHelpers_4_4_000.Instance.ToString(context, al_);
                        bool? an_ = context.Operators.Equal(am_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-recorded");
                        return an_;
                    }

                    IEnumerable<Extension> q_ = context.Operators.Where<Extension>((IEnumerable<Extension>)(BCGNotGiven is DomainResource
                        ? (BCGNotGiven as DomainResource).Extension
                        : default), p_);

                    DataType r_(Extension @this) {
                        DataType ao_ = @this?.Value;
                        return ao_;
                    }

                    IEnumerable<DataType> s_ = context.Operators.Select<Extension, DataType>(q_, r_);
                    DataType t_ = context.Operators.SingletonFrom<DataType>(s_);
                    FhirDateTime u_ = context.Operators.Convert<FhirDateTime>(t_);
                    CqlDateTime v_ = context.Operators.Convert<CqlDateTime>(u_);

                    object w_() {

                        bool ap_() {
                            DataType at_ = FirstBladderCancerStaging?.Performed;
                            object au_ = FHIRHelpers_4_4_000.Instance.ToValue(context, at_);
                            bool av_ = au_ is CqlDateTime;
                            return av_;
                        }


                        bool aq_() {
                            DataType aw_ = FirstBladderCancerStaging?.Performed;
                            object ax_ = FHIRHelpers_4_4_000.Instance.ToValue(context, aw_);
                            bool ay_ = ax_ is CqlInterval<CqlDateTime>;
                            return ay_;
                        }


                        bool ar_() {
                            DataType az_ = FirstBladderCancerStaging?.Performed;
                            object ba_ = FHIRHelpers_4_4_000.Instance.ToValue(context, az_);
                            bool bb_ = ba_ is CqlQuantity;
                            return bb_;
                        }


                        bool as_() {
                            DataType bc_ = FirstBladderCancerStaging?.Performed;
                            object bd_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bc_);
                            bool be_ = bd_ is CqlInterval<CqlQuantity>;
                            return be_;
                        }

                        if (ap_())
                        {
                            DataType bf_ = FirstBladderCancerStaging?.Performed;
                            object bg_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bf_);
                            return (bg_ as CqlDateTime) as object;
                        }
                        else if (aq_())
                        {
                            DataType bh_ = FirstBladderCancerStaging?.Performed;
                            object bi_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bh_);
                            return (bi_ as CqlInterval<CqlDateTime>) as object;
                        }
                        else if (ar_())
                        {
                            DataType bj_ = FirstBladderCancerStaging?.Performed;
                            object bk_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bj_);
                            return (bk_ as CqlQuantity) as object;
                        }
                        else if (as_())
                        {
                            DataType bl_ = FirstBladderCancerStaging?.Performed;
                            object bm_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bl_);
                            return (bm_ as CqlInterval<CqlQuantity>) as object;
                        }
                        else
                        {
                            return null;
                        };
                    }

                    CqlInterval<CqlDateTime> x_ = QICoreCommon_4_0_000.Instance.toInterval(context, w_());
                    CqlDateTime y_ = context.Operators.Start(x_);

                    object z_() {

                        bool bn_() {
                            DataType br_ = FirstBladderCancerStaging?.Performed;
                            object bs_ = FHIRHelpers_4_4_000.Instance.ToValue(context, br_);
                            bool bt_ = bs_ is CqlDateTime;
                            return bt_;
                        }


                        bool bo_() {
                            DataType bu_ = FirstBladderCancerStaging?.Performed;
                            object bv_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bu_);
                            bool bw_ = bv_ is CqlInterval<CqlDateTime>;
                            return bw_;
                        }


                        bool bp_() {
                            DataType bx_ = FirstBladderCancerStaging?.Performed;
                            object by_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bx_);
                            bool bz_ = by_ is CqlQuantity;
                            return bz_;
                        }


                        bool bq_() {
                            DataType ca_ = FirstBladderCancerStaging?.Performed;
                            object cb_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ca_);
                            bool cc_ = cb_ is CqlInterval<CqlQuantity>;
                            return cc_;
                        }

                        if (bn_())
                        {
                            DataType cd_ = FirstBladderCancerStaging?.Performed;
                            object ce_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cd_);
                            return (ce_ as CqlDateTime) as object;
                        }
                        else if (bo_())
                        {
                            DataType cf_ = FirstBladderCancerStaging?.Performed;
                            object cg_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cf_);
                            return (cg_ as CqlInterval<CqlDateTime>) as object;
                        }
                        else if (bp_())
                        {
                            DataType ch_ = FirstBladderCancerStaging?.Performed;
                            object ci_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ch_);
                            return (ci_ as CqlQuantity) as object;
                        }
                        else if (bq_())
                        {
                            DataType cj_ = FirstBladderCancerStaging?.Performed;
                            object ck_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cj_);
                            return (ck_ as CqlInterval<CqlQuantity>) as object;
                        }
                        else
                        {
                            return null;
                        };
                    }

                    CqlInterval<CqlDateTime> aa_ = QICoreCommon_4_0_000.Instance.toInterval(context, z_());
                    CqlDateTime ab_ = context.Operators.Start(aa_);
                    CqlQuantity ac_ = context.Operators.Quantity(6m, "months");
                    CqlDateTime ad_ = context.Operators.Add(ab_, ac_);
                    CqlInterval<CqlDateTime> ae_ = context.Operators.Interval(y_, ad_, false, true);
                    bool? af_ = context.Operators.In<CqlDateTime>(v_, ae_, "day");

                    object ag_() {

                        bool cl_() {
                            DataType cp_ = FirstBladderCancerStaging?.Performed;
                            object cq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cp_);
                            bool cr_ = cq_ is CqlDateTime;
                            return cr_;
                        }


                        bool cm_() {
                            DataType cs_ = FirstBladderCancerStaging?.Performed;
                            object ct_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cs_);
                            bool cu_ = ct_ is CqlInterval<CqlDateTime>;
                            return cu_;
                        }


                        bool cn_() {
                            DataType cv_ = FirstBladderCancerStaging?.Performed;
                            object cw_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cv_);
                            bool cx_ = cw_ is CqlQuantity;
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
                            return (dc_ as CqlDateTime) as object;
                        }
                        else if (cm_())
                        {
                            DataType dd_ = FirstBladderCancerStaging?.Performed;
                            object de_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dd_);
                            return (de_ as CqlInterval<CqlDateTime>) as object;
                        }
                        else if (cn_())
                        {
                            DataType df_ = FirstBladderCancerStaging?.Performed;
                            object dg_ = FHIRHelpers_4_4_000.Instance.ToValue(context, df_);
                            return (dg_ as CqlQuantity) as object;
                        }
                        else if (co_())
                        {
                            DataType dh_ = FirstBladderCancerStaging?.Performed;
                            object di_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dh_);
                            return (di_ as CqlInterval<CqlQuantity>) as object;
                        }
                        else
                        {
                            return null;
                        };
                    }

                    CqlInterval<CqlDateTime> ah_ = QICoreCommon_4_0_000.Instance.toInterval(context, ag_());
                    CqlDateTime ai_ = context.Operators.Start(ah_);
                    bool? aj_ = context.Operators.Not((bool?)(ai_ is null));
                    bool? ak_ = context.Operators.And(af_, aj_);
                    return ak_;
                }

                IEnumerable<Procedure> m_ = context.Operators.Where<Procedure>((IEnumerable<Procedure>)k_, l_);
                MedicationAdministration n_(Procedure FirstBladderCancerStaging) => BCGNotGiven;
                IEnumerable<MedicationAdministration> o_ = context.Operators.Select<Procedure, MedicationAdministration>(m_, n_);
                return o_;
            }

            IEnumerable<MedicationAdministration> g_ = context.Operators.SelectMany<MedicationAdministration, MedicationAdministration>(e_, f_);

            bool? h_(MedicationAdministration BCGNotGiven) {
                List<CodeableConcept> dj_ = BCGNotGiven?.StatusReason;

                CqlConcept dk_(CodeableConcept @this) {
                    CqlConcept do_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);
                    return do_;
                }

                IEnumerable<CqlConcept> dl_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)dj_, dk_);
                CqlValueSet dm_ = this.Unavailability_of_Bacillus_Calmette_Guerin_for_Urology_Care(context);
                bool? dn_ = context.Operators.ConceptsInValueSet(dl_, dm_);
                return dn_;
            }

            IEnumerable<MedicationAdministration> i_ = context.Operators.Where<MedicationAdministration>(g_, h_);
            return i_;
        });


    [CqlExpressionDefinition("Denominator Exception")]
    public bool? Denominator_Exception(CqlContext context) =>
        ((ICqlContextInternals)context).GetOrCompute<bool?>(-8232522769382720446L, () => {
            IEnumerable<MedicationAdministration> a_ = this.BCG_Not_Available_Within_6_Months_After_Bladder_Cancer_Staging(context);
            bool? b_ = context.Operators.Exists<MedicationAdministration>(a_);
            return b_;
        });


    [CqlExpressionDefinition("First BCG Administered")]
    public MedicationAdministration First_BCG_Administered(CqlContext context) =>
        ((ICqlContextInternals)context).GetOrCompute<MedicationAdministration>(5246817831198828715L, () => {
            CqlValueSet a_ = this.Bacillus_Calmette_Guerin_for_Urology_Care(context);
            IEnumerable<MedicationAdministration> b_ = context.Operators.Retrieve<MedicationAdministration>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationadministration"));
            IEnumerable<MedicationAdministration> c_ = context.Operators.Retrieve<MedicationAdministration>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationadministration"));

            IEnumerable<MedicationAdministration> d_(MedicationAdministration MR) {
                IEnumerable<Medication> n_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));

                bool? o_(Medication M) {
                    object s_ = context.Operators.LateBoundProperty<object>(M, "id.value");
                    object t_ = context.Operators.LateBoundProperty<object>(MR, "medication.reference.value");
                    IEnumerable<string> u_ = context.Operators.Split((string)t_, "/");
                    string v_ = context.Operators.Last<string>(u_);
                    bool? w_ = context.Operators.Equal(s_, v_);
                    CodeableConcept x_ = M?.Code;
                    CqlConcept y_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, x_);
                    CqlValueSet z_ = this.Bacillus_Calmette_Guerin_for_Urology_Care(context);
                    bool? aa_ = context.Operators.ConceptInValueSet(y_, z_);
                    bool? ab_ = context.Operators.And(w_, aa_);
                    return ab_;
                }

                IEnumerable<Medication> p_ = context.Operators.Where<Medication>(n_, o_);
                MedicationAdministration q_(Medication M) => MR;
                IEnumerable<MedicationAdministration> r_ = context.Operators.Select<Medication, MedicationAdministration>(p_, q_);
                return r_;
            }

            IEnumerable<MedicationAdministration> e_ = context.Operators.SelectMany<MedicationAdministration, MedicationAdministration>(c_, d_);
            IEnumerable<MedicationAdministration> f_ = context.Operators.Union<MedicationAdministration>(b_, e_);

            IEnumerable<MedicationAdministration> g_(MedicationAdministration BCG) {
                Procedure ac_ = this.First_Bladder_Cancer_Staging_Procedure(context);
                Procedure[] ad_ = [
                    ac_,
                ];

                bool? ae_(Procedure FirstBladderCancerStaging) {
                    DataType ai_ = BCG?.Effective;
                    object aj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ai_);
                    CqlInterval<CqlDateTime> ak_ = QICoreCommon_4_0_000.Instance.toInterval(context, aj_);
                    CqlDateTime al_ = context.Operators.Start(ak_);

                    object am_() {

                        bool bi_() {
                            DataType bm_ = FirstBladderCancerStaging?.Performed;
                            object bn_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bm_);
                            bool bo_ = bn_ is CqlDateTime;
                            return bo_;
                        }


                        bool bj_() {
                            DataType bp_ = FirstBladderCancerStaging?.Performed;
                            object bq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bp_);
                            bool br_ = bq_ is CqlInterval<CqlDateTime>;
                            return br_;
                        }


                        bool bk_() {
                            DataType bs_ = FirstBladderCancerStaging?.Performed;
                            object bt_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bs_);
                            bool bu_ = bt_ is CqlQuantity;
                            return bu_;
                        }


                        bool bl_() {
                            DataType bv_ = FirstBladderCancerStaging?.Performed;
                            object bw_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bv_);
                            bool bx_ = bw_ is CqlInterval<CqlQuantity>;
                            return bx_;
                        }

                        if (bi_())
                        {
                            DataType by_ = FirstBladderCancerStaging?.Performed;
                            object bz_ = FHIRHelpers_4_4_000.Instance.ToValue(context, by_);
                            return (bz_ as CqlDateTime) as object;
                        }
                        else if (bj_())
                        {
                            DataType ca_ = FirstBladderCancerStaging?.Performed;
                            object cb_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ca_);
                            return (cb_ as CqlInterval<CqlDateTime>) as object;
                        }
                        else if (bk_())
                        {
                            DataType cc_ = FirstBladderCancerStaging?.Performed;
                            object cd_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cc_);
                            return (cd_ as CqlQuantity) as object;
                        }
                        else if (bl_())
                        {
                            DataType ce_ = FirstBladderCancerStaging?.Performed;
                            object cf_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ce_);
                            return (cf_ as CqlInterval<CqlQuantity>) as object;
                        }
                        else
                        {
                            return null;
                        };
                    }

                    CqlInterval<CqlDateTime> an_ = QICoreCommon_4_0_000.Instance.toInterval(context, am_());
                    CqlDateTime ao_ = context.Operators.Start(an_);

                    object ap_() {

                        bool cg_() {
                            DataType ck_ = FirstBladderCancerStaging?.Performed;
                            object cl_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ck_);
                            bool cm_ = cl_ is CqlDateTime;
                            return cm_;
                        }


                        bool ch_() {
                            DataType cn_ = FirstBladderCancerStaging?.Performed;
                            object co_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cn_);
                            bool cp_ = co_ is CqlInterval<CqlDateTime>;
                            return cp_;
                        }


                        bool ci_() {
                            DataType cq_ = FirstBladderCancerStaging?.Performed;
                            object cr_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cq_);
                            bool cs_ = cr_ is CqlQuantity;
                            return cs_;
                        }


                        bool cj_() {
                            DataType ct_ = FirstBladderCancerStaging?.Performed;
                            object cu_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ct_);
                            bool cv_ = cu_ is CqlInterval<CqlQuantity>;
                            return cv_;
                        }

                        if (cg_())
                        {
                            DataType cw_ = FirstBladderCancerStaging?.Performed;
                            object cx_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cw_);
                            return (cx_ as CqlDateTime) as object;
                        }
                        else if (ch_())
                        {
                            DataType cy_ = FirstBladderCancerStaging?.Performed;
                            object cz_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cy_);
                            return (cz_ as CqlInterval<CqlDateTime>) as object;
                        }
                        else if (ci_())
                        {
                            DataType da_ = FirstBladderCancerStaging?.Performed;
                            object db_ = FHIRHelpers_4_4_000.Instance.ToValue(context, da_);
                            return (db_ as CqlQuantity) as object;
                        }
                        else if (cj_())
                        {
                            DataType dc_ = FirstBladderCancerStaging?.Performed;
                            object dd_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dc_);
                            return (dd_ as CqlInterval<CqlQuantity>) as object;
                        }
                        else
                        {
                            return null;
                        };
                    }

                    CqlInterval<CqlDateTime> aq_ = QICoreCommon_4_0_000.Instance.toInterval(context, ap_());
                    CqlDateTime ar_ = context.Operators.Start(aq_);
                    CqlQuantity as_ = context.Operators.Quantity(6m, "months");
                    CqlDateTime at_ = context.Operators.Add(ar_, as_);
                    CqlInterval<CqlDateTime> au_ = context.Operators.Interval(ao_, at_, false, true);
                    bool? av_ = context.Operators.In<CqlDateTime>(al_, au_, "day");

                    object aw_() {

                        bool de_() {
                            DataType di_ = FirstBladderCancerStaging?.Performed;
                            object dj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, di_);
                            bool dk_ = dj_ is CqlDateTime;
                            return dk_;
                        }


                        bool df_() {
                            DataType dl_ = FirstBladderCancerStaging?.Performed;
                            object dm_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dl_);
                            bool dn_ = dm_ is CqlInterval<CqlDateTime>;
                            return dn_;
                        }


                        bool dg_() {
                            DataType do_ = FirstBladderCancerStaging?.Performed;
                            object dp_ = FHIRHelpers_4_4_000.Instance.ToValue(context, do_);
                            bool dq_ = dp_ is CqlQuantity;
                            return dq_;
                        }


                        bool dh_() {
                            DataType dr_ = FirstBladderCancerStaging?.Performed;
                            object ds_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dr_);
                            bool dt_ = ds_ is CqlInterval<CqlQuantity>;
                            return dt_;
                        }

                        if (de_())
                        {
                            DataType du_ = FirstBladderCancerStaging?.Performed;
                            object dv_ = FHIRHelpers_4_4_000.Instance.ToValue(context, du_);
                            return (dv_ as CqlDateTime) as object;
                        }
                        else if (df_())
                        {
                            DataType dw_ = FirstBladderCancerStaging?.Performed;
                            object dx_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dw_);
                            return (dx_ as CqlInterval<CqlDateTime>) as object;
                        }
                        else if (dg_())
                        {
                            DataType dy_ = FirstBladderCancerStaging?.Performed;
                            object dz_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dy_);
                            return (dz_ as CqlQuantity) as object;
                        }
                        else if (dh_())
                        {
                            DataType ea_ = FirstBladderCancerStaging?.Performed;
                            object eb_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ea_);
                            return (eb_ as CqlInterval<CqlQuantity>) as object;
                        }
                        else
                        {
                            return null;
                        };
                    }

                    CqlInterval<CqlDateTime> ax_ = QICoreCommon_4_0_000.Instance.toInterval(context, aw_());
                    CqlDateTime ay_ = context.Operators.Start(ax_);
                    bool? az_ = context.Operators.Not((bool?)(ay_ is null));
                    bool? ba_ = context.Operators.And(av_, az_);
                    object bc_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ai_);
                    CqlInterval<CqlDateTime> bd_ = QICoreCommon_4_0_000.Instance.toInterval(context, bc_);
                    CqlDateTime be_ = context.Operators.Start(bd_);
                    CqlInterval<CqlDateTime> bf_ = this.Measurement_Period(context);
                    bool? bg_ = context.Operators.In<CqlDateTime>(be_, bf_, "day");
                    bool? bh_ = context.Operators.And(ba_, bg_);
                    return bh_;
                }

                IEnumerable<Procedure> af_ = context.Operators.Where<Procedure>((IEnumerable<Procedure>)ad_, ae_);
                MedicationAdministration ag_(Procedure FirstBladderCancerStaging) => BCG;
                IEnumerable<MedicationAdministration> ah_ = context.Operators.Select<Procedure, MedicationAdministration>(af_, ag_);
                return ah_;
            }

            IEnumerable<MedicationAdministration> h_ = context.Operators.SelectMany<MedicationAdministration, MedicationAdministration>(f_, g_);

            bool? i_(MedicationAdministration BCG) {
                Code<MedicationAdministration.MedicationAdministrationStatusCodes> ec_ = BCG?.StatusElement;
                MedicationAdministration.MedicationAdministrationStatusCodes? ed_ = ec_?.Value;
                string ee_ = context.Operators.Convert<string>(ed_);
                string[] ef_ = [
                    "in-progress",
                    "completed",
                ];
                bool? eg_ = context.Operators.In<string>(ee_, (IEnumerable<string>)ef_);
                return eg_;
            }

            IEnumerable<MedicationAdministration> j_ = context.Operators.Where<MedicationAdministration>(h_, i_);

            object k_(MedicationAdministration @this) {
                DataType eh_ = @this?.Effective;
                object ei_ = FHIRHelpers_4_4_000.Instance.ToValue(context, eh_);
                CqlInterval<CqlDateTime> ej_ = QICoreCommon_4_0_000.Instance.toInterval(context, ei_);
                CqlDateTime ek_ = context.Operators.Start(ej_);
                return ek_;
            }

            IEnumerable<MedicationAdministration> l_ = context.Operators.SortBy<MedicationAdministration>(j_, k_, System.ComponentModel.ListSortDirection.Ascending);
            MedicationAdministration m_ = context.Operators.First<MedicationAdministration>(l_);
            return m_;
        });


    [CqlExpressionDefinition("Numerator")]
    public bool? Numerator(CqlContext context) =>
        ((ICqlContextInternals)context).GetOrCompute<bool?>(-5650740766836730728L, () => {
            MedicationAdministration a_ = this.First_BCG_Administered(context);
            bool? b_ = context.Operators.Not((bool?)(a_ is null));
            return b_;
        });


    [CqlExpressionDefinition("SDE Ethnicity")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Ethnicity(CqlContext context) =>
        ((ICqlContextInternals)context).GetOrCompute<(CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)?>(-3031213782846199448L, () => {
            (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? a_ = SupplementalDataElements_5_1_000.Instance.SDE_Ethnicity(context);
            return a_;
        });


    [CqlExpressionDefinition("SDE Payer")]
    public IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> SDE_Payer(CqlContext context) =>
        ((ICqlContextInternals)context).GetOrCompute<IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?>>(-2765886446978909849L, () => {
            IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> a_ = SupplementalDataElements_5_1_000.Instance.SDE_Payer(context);
            return a_;
        });


    [CqlExpressionDefinition("SDE Race")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Race(CqlContext context) =>
        ((ICqlContextInternals)context).GetOrCompute<(CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)?>(-2209043468229436943L, () => {
            (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? a_ = SupplementalDataElements_5_1_000.Instance.SDE_Race(context);
            return a_;
        });


    [CqlExpressionDefinition("SDE Sex")]
    public CqlCode SDE_Sex(CqlContext context) =>
        ((ICqlContextInternals)context).GetOrCompute<CqlCode>(-4292175789313964661L, () => {
            CqlCode a_ = SupplementalDataElements_5_1_000.Instance.SDE_Sex(context);
            return a_;
        });


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

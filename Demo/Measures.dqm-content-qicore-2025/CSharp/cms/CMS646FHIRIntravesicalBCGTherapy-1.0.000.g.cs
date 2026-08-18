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

[System.CodeDom.Compiler.GeneratedCode(".NET Code Generation", "5.3.5.0")]
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
                CqlBoolean n_ = context.Operators.Equal(j_, m_);
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

        CqlBoolean c_() {
            CodeableConcept d_ = condition?.VerificationStatus;
            CqlConcept e_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, d_);
            CqlCode f_ = QICoreCommon_4_0_000.Instance.confirmed(context);
            CqlConcept g_ = context.Operators.ConvertCodeToConcept(f_);
            CqlBoolean h_ = context.Operators.Equivalent(e_, g_);

            CqlBoolean i_() {
                CodeableConcept l_ = condition?.VerificationStatus;
                CqlConcept m_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, l_);
                CqlCode n_ = QICoreCommon_4_0_000.Instance.unconfirmed(context);
                CqlConcept o_ = context.Operators.ConvertCodeToConcept(n_);
                CqlBoolean p_ = context.Operators.Equivalent(m_, o_);
                return p_;
            }


            CqlBoolean j_() {
                CodeableConcept q_ = condition?.VerificationStatus;
                CqlConcept r_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, q_);
                CqlCode s_ = QICoreCommon_4_0_000.Instance.provisional(context);
                CqlConcept t_ = context.Operators.ConvertCodeToConcept(s_);
                CqlBoolean u_ = context.Operators.Equivalent(r_, t_);
                return u_;
            }


            CqlBoolean k_() {
                CodeableConcept v_ = condition?.VerificationStatus;
                CqlConcept w_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, v_);
                CqlCode x_ = QICoreCommon_4_0_000.Instance.differential(context);
                CqlConcept y_ = context.Operators.ConvertCodeToConcept(x_);
                CqlBoolean z_ = context.Operators.Equivalent(w_, y_);
                return z_;
            }

            return h_
                /* CQL 'or' (216:54-217:66) */ || i_()
                /* CQL 'or' (216:54-218:66) */ || j_()
                /* CQL 'or' (216:52-220:3) */ || k_();
        }

        return (CqlBoolean)(!(!((bool?)(b_ is null))))
            /* CQL 'implies' (216:3-220:3) */ || c_();
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
            CqlBoolean k_ = context.Operators.Before(h_, j_, "day");

            CqlBoolean l_() {
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
                    CqlInterval<CqlDateTime> t_ = context.Operators.Interval(s_, s_, true, true);
                    p_ = t_;
                }
                CqlBoolean q_ = context.Operators.Before(o_, p_, "day");
                return q_;
            }

            return (k_
                /* CQL 'or' (149:11-151:5) */ || l_())
                /* CQL 'and' (149:5-152:38) */ && this.isVerified(context, BladderCancer);
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
                    n_ = u_ as CqlDateTime;
                }
                else
                {
                    bool w_ = u_ is CqlQuantity;
                    if (w_)
                    {
                        n_ = u_ as CqlQuantity;
                    }
                    else
                    {
                        bool x_ = u_ is CqlInterval<CqlDateTime>;
                        if (x_)
                        {
                            n_ = u_ as CqlInterval<CqlDateTime>;
                        }
                        else
                        {
                            bool y_ = u_ is CqlInterval<CqlQuantity>;
                            if (y_)
                            {
                                n_ = u_ as CqlInterval<CqlQuantity>;
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
                CqlBoolean s_ = context.Operators.SameOrBefore(p_, r_, "day");
                return s_;
            }

            CqlBoolean m_ = context.Operators.WhereAny<Condition>(k_, l_);
            return m_;
        }

        IEnumerable<Procedure> e_ = context.Operators.Where<Procedure>(c_, d_);

        bool? f_(Procedure BladderCancerStaging) {
            Code<EventStatus> z_ = BladderCancerStaging?.StatusElement;
            EventStatus? aa_ = z_?.Value;
            string ab_ = context.Operators.Convert<string>(aa_);
            CqlBoolean ac_ = context.Operators.Equal(ab_, "completed");
            return ac_;
        }

        IEnumerable<Procedure> g_ = context.Operators.Where<Procedure>(e_, f_);

        object h_(Procedure @this) {
            object ad_;
            DataType ag_ = @this?.Performed;
            object ah_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ag_);
            bool ai_ = ah_ is CqlDateTime;
            if (ai_)
            {
                ad_ = ah_ as CqlDateTime;
            }
            else
            {
                bool aj_ = ah_ is CqlQuantity;
                if (aj_)
                {
                    ad_ = ah_ as CqlQuantity;
                }
                else
                {
                    bool ak_ = ah_ is CqlInterval<CqlDateTime>;
                    if (ak_)
                    {
                        ad_ = ah_ as CqlInterval<CqlDateTime>;
                    }
                    else
                    {
                        bool al_ = ah_ is CqlInterval<CqlQuantity>;
                        if (al_)
                        {
                            ad_ = ah_ as CqlInterval<CqlQuantity>;
                        }
                        else
                        {
                            ad_ = null;
                        }
                    }
                }
            }
            CqlInterval<CqlDateTime> ae_ = QICoreCommon_4_0_000.Instance.toInterval(context, ad_);
            CqlDateTime af_ = context.Operators.Start(ae_);
            return af_;
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
                k_ = o_ as CqlDateTime;
            }
            else
            {
                bool q_ = o_ is CqlQuantity;
                if (q_)
                {
                    k_ = o_ as CqlQuantity;
                }
                else
                {
                    bool r_ = o_ is CqlInterval<CqlDateTime>;
                    if (r_)
                    {
                        k_ = o_ as CqlInterval<CqlDateTime>;
                    }
                    else
                    {
                        bool s_ = o_ is CqlInterval<CqlQuantity>;
                        if (s_)
                        {
                            k_ = o_ as CqlInterval<CqlQuantity>;
                        }
                        else
                        {
                            k_ = null;
                        }
                    }
                }
            }
            CqlInterval<CqlDateTime> l_ = QICoreCommon_4_0_000.Instance.toInterval(context, k_);
            CqlBoolean m_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(j_, l_, "day");
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

            CqlBoolean e_() {
                DataType g_ = StagingObservation?.Value;
                object h_ = FHIRHelpers_4_4_000.Instance.ToValue(context, g_);
                CqlCode i_ = this.American_Joint_Committee_on_Cancer_cT1__qualifier_value_(context);
                CqlConcept j_ = context.Operators.ConvertCodeToConcept(i_);
                CqlBoolean k_ = context.Operators.Equivalent(h_ as CqlConcept, j_);

                CqlBoolean l_() {
                    DataType o_ = StagingObservation?.Value;
                    object p_ = FHIRHelpers_4_4_000.Instance.ToValue(context, o_);
                    CqlCode q_ = this.American_Joint_Committee_on_Cancer_cTis__qualifier_value_(context);
                    CqlConcept r_ = context.Operators.ConvertCodeToConcept(q_);
                    CqlBoolean s_ = context.Operators.Equivalent(p_ as CqlConcept, r_);
                    return s_;
                }


                CqlBoolean m_() {
                    DataType t_ = StagingObservation?.Value;
                    object u_ = FHIRHelpers_4_4_000.Instance.ToValue(context, t_);
                    CqlCode v_ = this.American_Joint_Committee_on_Cancer_cTa__qualifier_value_(context);
                    CqlConcept w_ = context.Operators.ConvertCodeToConcept(v_);
                    CqlBoolean x_ = context.Operators.Equivalent(u_ as CqlConcept, w_);
                    return x_;
                }


                CqlBoolean n_() {
                    DataType y_ = StagingObservation?.Value;
                    object z_ = FHIRHelpers_4_4_000.Instance.ToValue(context, y_);
                    CqlCode aa_ = this.Carcinoma_in_situ_of_bladder(context);
                    CqlConcept ab_ = context.Operators.ConvertCodeToConcept(aa_);
                    CqlBoolean ac_ = context.Operators.Equivalent(z_ as CqlConcept, ab_);
                    return ac_;
                }

                return k_
                    /* CQL 'or' (179:15-180:112) */ || l_()
                    /* CQL 'or' (179:15-181:111) */ || m_()
                    /* CQL 'or' (179:13-183:9) */ || n_();
            }


            CqlBoolean f_() {
                Code<ObservationStatus> ad_ = StagingObservation?.StatusElement;
                ObservationStatus? ae_ = ad_?.Value;
                string af_ = context.Operators.Convert<string>(ae_);
                string[] ag_ = [
                    "final",
                    "amended",
                    "corrected",
                ];
                CqlBoolean ah_ = context.Operators.In<string>(af_, (IEnumerable<string>)ag_);
                return ah_;
            }

            return (CqlBoolean)(!((bool?)(d_ is null)))
                /* CQL 'and' (178:13-183:9) */ && e_()
                /* CQL 'and' (178:7-184:76) */ && f_();
        }

        CqlBoolean c_ = context.Operators.WhereAny<Observation>(a_, b_);
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
            CqlBoolean h_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(e_, g_, "day");

            CqlBoolean i_() {
                Coding k_ = ValidEncounter?.Class;
                CqlCode l_ = FHIRHelpers_4_4_000.Instance.ToCode(context, k_);
                CqlCode m_ = this.@virtual(context);
                CqlBoolean n_ = context.Operators.Equivalent(l_, m_);
                return !n_;
            }


            CqlBoolean j_() {
                Code<Encounter.EncounterStatus> o_ = ValidEncounter?.StatusElement;
                Encounter.EncounterStatus? p_ = o_?.Value;
                Code<Encounter.EncounterStatus> q_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(p_);
                CqlBoolean r_ = context.Operators.Equal(q_, "finished");
                return r_;
            }

            return h_
                /* CQL 'and' (141:13-142:45) */ && i_()
                /* CQL 'and' (141:7-143:46) */ && j_();
        }

        CqlBoolean d_ = context.Operators.WhereAny<Encounter>(b_, c_);
        return d_;
    }


    [CqlExpressionDefinition("Initial Population")]
    public bool? Initial_Population(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Initial_Population, Initial_Population_Compute);

    private const long _cacheIndex_Initial_Population = -1514878663221881824L;

    private bool? Initial_Population_Compute(CqlContext context)
    {
        CqlBoolean a_ = this.Has_Most_Recent_Bladder_Cancer_Tumor_Staging_is_T1__Tis__Ta_HG(context);
        return a_
            /* CQL 'and' (39:3-40:34) */ && this.Has_Qualifying_Encounter(context);
    }


    [CqlExpressionDefinition("Denominator")]
    public bool? Denominator(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Denominator, Denominator_Compute);

    private const long _cacheIndex_Denominator = 7894348376586324006L;

    private bool? Denominator_Compute(CqlContext context)
    {
        CqlBoolean a_ = this.Initial_Population(context);
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
                DataType r_ = FirstBladderCancerStaging?.Performed;
                object s_ = FHIRHelpers_4_4_000.Instance.ToValue(context, r_);
                bool t_ = s_ is CqlDateTime;
                if (t_)
                {
                    n_ = s_ as CqlDateTime;
                }
                else
                {
                    bool u_ = s_ is CqlQuantity;
                    if (u_)
                    {
                        n_ = s_ as CqlQuantity;
                    }
                    else
                    {
                        bool v_ = s_ is CqlInterval<CqlDateTime>;
                        if (v_)
                        {
                            n_ = s_ as CqlInterval<CqlDateTime>;
                        }
                        else
                        {
                            bool w_ = s_ is CqlInterval<CqlQuantity>;
                            if (w_)
                            {
                                n_ = s_ as CqlInterval<CqlQuantity>;
                            }
                            else
                            {
                                n_ = null;
                            }
                        }
                    }
                }
                CqlInterval<CqlDateTime> o_ = QICoreCommon_4_0_000.Instance.toInterval(context, n_);
                CqlBoolean p_ = context.Operators.OverlapsAfter(m_, o_, "day");

                CqlBoolean q_() {
                    DataType x_ = ActiveTuberculosis?.Onset;
                    object y_ = FHIRHelpers_4_4_000.Instance.ToValue(context, x_);
                    CqlInterval<CqlDateTime> z_ = QICoreCommon_4_0_000.Instance.toInterval(context, y_);
                    object aa_;
                    DataType ae_ = FirstBladderCancerStaging?.Performed;
                    object af_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ae_);
                    bool ag_ = af_ is CqlDateTime;
                    if (ag_)
                    {
                        aa_ = af_ as CqlDateTime;
                    }
                    else
                    {
                        bool ah_ = af_ is CqlQuantity;
                        if (ah_)
                        {
                            aa_ = af_ as CqlQuantity;
                        }
                        else
                        {
                            bool ai_ = af_ is CqlInterval<CqlDateTime>;
                            if (ai_)
                            {
                                aa_ = af_ as CqlInterval<CqlDateTime>;
                            }
                            else
                            {
                                bool aj_ = af_ is CqlInterval<CqlQuantity>;
                                if (aj_)
                                {
                                    aa_ = af_ as CqlInterval<CqlQuantity>;
                                }
                                else
                                {
                                    aa_ = null;
                                }
                            }
                        }
                    }
                    CqlInterval<CqlDateTime> ab_ = QICoreCommon_4_0_000.Instance.toInterval(context, aa_);
                    CqlBoolean ac_ = context.Operators.OverlapsAfter(z_, ab_, "day");

                    CqlBoolean ad_() {
                        DataType ak_ = ActiveTuberculosis?.Abatement;
                        object al_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ak_);
                        CqlInterval<CqlDateTime> am_ = QICoreCommon_4_0_000.Instance.toInterval(context, al_);
                        object an_;
                        DataType ar_ = FirstBladderCancerStaging?.Performed;
                        object as_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ar_);
                        bool at_ = as_ is CqlDateTime;
                        if (at_)
                        {
                            an_ = as_ as CqlDateTime;
                        }
                        else
                        {
                            bool au_ = as_ is CqlQuantity;
                            if (au_)
                            {
                                an_ = as_ as CqlQuantity;
                            }
                            else
                            {
                                bool av_ = as_ is CqlInterval<CqlDateTime>;
                                if (av_)
                                {
                                    an_ = as_ as CqlInterval<CqlDateTime>;
                                }
                                else
                                {
                                    bool aw_ = as_ is CqlInterval<CqlQuantity>;
                                    if (aw_)
                                    {
                                        an_ = as_ as CqlInterval<CqlQuantity>;
                                    }
                                    else
                                    {
                                        an_ = null;
                                    }
                                }
                            }
                        }
                        CqlInterval<CqlDateTime> ao_ = QICoreCommon_4_0_000.Instance.toInterval(context, an_);
                        CqlBoolean ap_ = context.Operators.OverlapsAfter(am_, ao_, "day");

                        CqlBoolean aq_() {
                            DataType ax_ = ActiveTuberculosis?.Abatement;
                            object ay_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ax_);
                            return ay_ is null;
                        }

                        return ap_
                            /* CQL 'or' (82:19-84:15) */ || aq_();
                    }

                    return ac_
                        /* CQL 'and' (81:14-85:11) */ && ad_();
                }

                return p_
                    /* CQL 'or' (80:17-86:7) */ || q_();
            }

            CqlBoolean l_ = context.Operators.WhereAny<Procedure>((IEnumerable<Procedure>)j_, k_);
            return l_;
        }

        IEnumerable<Condition> f_ = context.Operators.Where<Condition>(d_, e_);

        bool? g_(Condition ActiveTuberculosis) {
            CqlBoolean az_ = this.isVerified(context, ActiveTuberculosis);
            return az_;
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
                CqlBoolean r_ = context.Operators.Equal(n_, q_);

                CqlBoolean s_() {
                    CodeableConcept t_ = M?.Code;
                    CqlConcept u_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, t_);
                    CqlValueSet v_ = this.Immunosuppressive_Drugs_for_Urology_Care(context);
                    CqlBoolean w_ = context.Operators.ConceptInValueSet(u_, v_);
                    return w_;
                }

                return r_
                    /* CQL 'and' */ && s_();
            }

            CqlBoolean m_ = context.Operators.WhereAny<Medication>(k_, l_);
            return m_;
        }

        IEnumerable<MedicationRequest> c_ = context.Operators.Where<MedicationRequest>(a_, b_);
        CqlValueSet d_ = this.Immunosuppressive_Drugs_for_Urology_Care(context);
        IEnumerable<MedicationRequest> e_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, d_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> f_ = context.Operators.Union<MedicationRequest>(c_, e_);

        bool? g_(MedicationRequest ImmunosuppressiveDrugs) {
            Procedure x_ = this.First_Bladder_Cancer_Staging_Procedure(context);
            Procedure[] y_ = [
                x_,
            ];

            bool? z_(Procedure FirstBladderCancerStaging) {
                List<Dosage> ab_ = ImmunosuppressiveDrugs?.DosageInstruction;

                bool? ac_(Dosage @this) {
                    Timing be_ = @this?.Timing;
                    return !((bool?)(be_ is null));
                }


                Timing ad_(Dosage @this) {
                    Timing bf_ = @this?.Timing;
                    return bf_;
                }

                IEnumerable<Timing> ae_ = context.Operators.WhereSelect<Dosage, Timing>((IEnumerable<Dosage>)ab_, ac_, ad_);

                CqlDateTime af_(Timing dosageTiming) {
                    List<FhirDateTime> bg_ = dosageTiming?.EventElement;

                    string bh_(FhirDateTime @this) {
                        string bn_ = @this?.Value;
                        return bn_;
                    }

                    IEnumerable<string> bi_ = context.Operators.Select<FhirDateTime, string>((IEnumerable<FhirDateTime>)bg_, bh_);

                    CqlDateTime bj_(string @string) {
                        CqlDateTime bo_ = context.Operators.ConvertStringToDateTime(@string);
                        return bo_;
                    }

                    IEnumerable<CqlDateTime> bk_ = context.Operators.Select<string, CqlDateTime>(bi_, bj_);
                    IEnumerable<CqlDateTime> bl_ = context.Operators.ListSort<CqlDateTime>(bk_, System.ComponentModel.ListSortDirection.Ascending);
                    CqlDateTime bm_ = context.Operators.First<CqlDateTime>(bl_);
                    return bm_;
                }

                IEnumerable<CqlDateTime> ag_ = context.Operators.SelectDistinct<Timing, CqlDateTime>(ae_, af_);
                IEnumerable<CqlDateTime> ah_ = context.Operators.ListSort<CqlDateTime>(ag_, System.ComponentModel.ListSortDirection.Ascending);
                CqlDateTime ai_ = context.Operators.First<CqlDateTime>(ah_);
                CqlInterval<CqlDateTime> aj_ = QICoreCommon_4_0_000.Instance.toInterval(context, ai_);

                bool? ak_(Dosage @this) {
                    Timing bp_ = @this?.Timing;
                    return !((bool?)(bp_ is null));
                }


                Timing al_(Dosage @this) {
                    Timing bq_ = @this?.Timing;
                    return bq_;
                }

                IEnumerable<Timing> am_ = context.Operators.WhereSelect<Dosage, Timing>((IEnumerable<Dosage>)ab_, ak_, al_);

                bool? an_(Timing @this) {
                    Timing.RepeatComponent br_ = @this?.Repeat;
                    return !((bool?)(br_ is null));
                }


                Timing.RepeatComponent ao_(Timing @this) {
                    Timing.RepeatComponent bs_ = @this?.Repeat;
                    return bs_;
                }

                IEnumerable<Timing.RepeatComponent> ap_ = context.Operators.WhereSelect<Timing, Timing.RepeatComponent>(am_, an_, ao_);

                bool? aq_(Timing.RepeatComponent @this) {
                    DataType bt_ = @this?.Bounds;
                    object bu_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bt_);
                    return !((bool?)(bu_ is null));
                }


                object ar_(Timing.RepeatComponent @this) {
                    DataType bv_ = @this?.Bounds;
                    object bw_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bv_);
                    return bw_;
                }

                IEnumerable<object> as_ = context.Operators.WhereSelect<Timing.RepeatComponent, object>(ap_, aq_, ar_);

                CqlInterval<CqlDateTime> at_(object DoseTime) {
                    CqlInterval<CqlDateTime> bx_ = QICoreCommon_4_0_000.Instance.toInterval(context, DoseTime);
                    return bx_;
                }

                IEnumerable<CqlInterval<CqlDateTime>> au_ = context.Operators.SelectDistinct<object, CqlInterval<CqlDateTime>>(as_, at_);
                IEnumerable<CqlInterval<CqlDateTime>> av_ = context.Operators.Collapse(au_, (string)default);

                object aw_(CqlInterval<CqlDateTime> @this) {
                    CqlDateTime by_ = context.Operators.Start(@this);
                    return by_;
                }

                IEnumerable<CqlInterval<CqlDateTime>> ax_ = context.Operators.SortBy<CqlInterval<CqlDateTime>>(av_, aw_, System.ComponentModel.ListSortDirection.Ascending);
                CqlInterval<CqlDateTime> ay_ = context.Operators.First<CqlInterval<CqlDateTime>>(ax_);
                CqlDateTime az_ = context.Operators.Start(aj_ ?? ay_);
                object ba_;
                DataType bz_ = FirstBladderCancerStaging?.Performed;
                object ca_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bz_);
                bool cb_ = ca_ is CqlDateTime;
                if (cb_)
                {
                    ba_ = ca_ as CqlDateTime;
                }
                else
                {
                    bool cc_ = ca_ is CqlQuantity;
                    if (cc_)
                    {
                        ba_ = ca_ as CqlQuantity;
                    }
                    else
                    {
                        bool cd_ = ca_ is CqlInterval<CqlDateTime>;
                        if (cd_)
                        {
                            ba_ = ca_ as CqlInterval<CqlDateTime>;
                        }
                        else
                        {
                            bool ce_ = ca_ is CqlInterval<CqlQuantity>;
                            if (ce_)
                            {
                                ba_ = ca_ as CqlInterval<CqlQuantity>;
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
                CqlBoolean bd_ = context.Operators.SameOrBefore(az_, bc_, "day");
                return bd_;
            }

            CqlBoolean aa_ = context.Operators.WhereAny<Procedure>((IEnumerable<Procedure>)y_, z_);
            return aa_;
        }

        IEnumerable<MedicationRequest> h_ = context.Operators.Where<MedicationRequest>(f_, g_);

        bool? i_(MedicationRequest ImmunosuppressiveDrugs) {
            Code<MedicationRequest.MedicationrequestStatus> cf_ = ImmunosuppressiveDrugs?.StatusElement;
            MedicationRequest.MedicationrequestStatus? cg_ = cf_?.Value;
            string ch_ = context.Operators.Convert<string>(cg_);
            string[] ci_ = [
                "active",
                "completed",
            ];
            CqlBoolean cj_ = context.Operators.In<string>(ch_, (IEnumerable<string>)ci_);

            CqlBoolean ck_() {
                Code<MedicationRequest.MedicationRequestIntent> cl_ = ImmunosuppressiveDrugs?.IntentElement;
                MedicationRequest.MedicationRequestIntent? cm_ = cl_?.Value;
                string cn_ = context.Operators.Convert<string>(cm_);
                CqlBoolean co_ = context.Operators.Equal(cn_, "order");
                return co_;
            }

            return cj_
                /* CQL 'and' (212:5-213:49) */ && ck_();
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
                DataType y_ = Cystectomy?.Performed;
                object z_ = FHIRHelpers_4_4_000.Instance.ToValue(context, y_);
                bool aa_ = z_ is CqlDateTime;
                if (aa_)
                {
                    k_ = z_ as CqlDateTime;
                }
                else
                {
                    bool ab_ = z_ is CqlQuantity;
                    if (ab_)
                    {
                        k_ = z_ as CqlQuantity;
                    }
                    else
                    {
                        bool ac_ = z_ is CqlInterval<CqlDateTime>;
                        if (ac_)
                        {
                            k_ = z_ as CqlInterval<CqlDateTime>;
                        }
                        else
                        {
                            bool ad_ = z_ is CqlInterval<CqlQuantity>;
                            if (ad_)
                            {
                                k_ = z_ as CqlInterval<CqlQuantity>;
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
                DataType ae_ = FirstBladderCancerStaging?.Performed;
                object af_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ae_);
                bool ag_ = af_ is CqlDateTime;
                if (ag_)
                {
                    n_ = af_ as CqlDateTime;
                }
                else
                {
                    bool ah_ = af_ is CqlQuantity;
                    if (ah_)
                    {
                        n_ = af_ as CqlQuantity;
                    }
                    else
                    {
                        bool ai_ = af_ is CqlInterval<CqlDateTime>;
                        if (ai_)
                        {
                            n_ = af_ as CqlInterval<CqlDateTime>;
                        }
                        else
                        {
                            bool aj_ = af_ is CqlInterval<CqlQuantity>;
                            if (aj_)
                            {
                                n_ = af_ as CqlInterval<CqlQuantity>;
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
                DataType ak_ = FirstBladderCancerStaging?.Performed;
                object al_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ak_);
                bool am_ = al_ is CqlDateTime;
                if (am_)
                {
                    s_ = al_ as CqlDateTime;
                }
                else
                {
                    bool an_ = al_ is CqlQuantity;
                    if (an_)
                    {
                        s_ = al_ as CqlQuantity;
                    }
                    else
                    {
                        bool ao_ = al_ is CqlInterval<CqlDateTime>;
                        if (ao_)
                        {
                            s_ = al_ as CqlInterval<CqlDateTime>;
                        }
                        else
                        {
                            bool ap_ = al_ is CqlInterval<CqlQuantity>;
                            if (ap_)
                            {
                                s_ = al_ as CqlInterval<CqlQuantity>;
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
                CqlBoolean w_ = context.Operators.In<CqlDateTime>(m_, v_, "day");

                CqlBoolean x_() {
                    object aq_;
                    DataType at_ = FirstBladderCancerStaging?.Performed;
                    object au_ = FHIRHelpers_4_4_000.Instance.ToValue(context, at_);
                    bool av_ = au_ is CqlDateTime;
                    if (av_)
                    {
                        aq_ = au_ as CqlDateTime;
                    }
                    else
                    {
                        bool aw_ = au_ is CqlQuantity;
                        if (aw_)
                        {
                            aq_ = au_ as CqlQuantity;
                        }
                        else
                        {
                            bool ax_ = au_ is CqlInterval<CqlDateTime>;
                            if (ax_)
                            {
                                aq_ = au_ as CqlInterval<CqlDateTime>;
                            }
                            else
                            {
                                bool ay_ = au_ is CqlInterval<CqlQuantity>;
                                if (ay_)
                                {
                                    aq_ = au_ as CqlInterval<CqlQuantity>;
                                }
                                else
                                {
                                    aq_ = null;
                                }
                            }
                        }
                    }
                    CqlInterval<CqlDateTime> ar_ = QICoreCommon_4_0_000.Instance.toInterval(context, aq_);
                    CqlDateTime as_ = context.Operators.Start(ar_);
                    return !((bool?)(as_ is null));
                }

                return w_
                    /* CQL 'and' (92:17-92:142) */ && x_();
            }

            CqlBoolean j_ = context.Operators.WhereAny<Procedure>((IEnumerable<Procedure>)h_, i_);
            return j_;
        }

        IEnumerable<Procedure> d_ = context.Operators.Where<Procedure>(b_, c_);

        bool? e_(Procedure Cystectomy) {
            Code<EventStatus> az_ = Cystectomy?.StatusElement;
            EventStatus? ba_ = az_?.Value;
            string bb_ = context.Operators.Convert<string>(ba_);
            CqlBoolean bc_ = context.Operators.Equal(bb_, "completed");
            return bc_;
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
                DataType ad_ = FirstBladderCancerStaging?.Performed;
                object ae_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ad_);
                bool af_ = ae_ is CqlDateTime;
                if (af_)
                {
                    y_ = ae_ as CqlDateTime;
                }
                else
                {
                    bool ag_ = ae_ is CqlQuantity;
                    if (ag_)
                    {
                        y_ = ae_ as CqlQuantity;
                    }
                    else
                    {
                        bool ah_ = ae_ is CqlInterval<CqlDateTime>;
                        if (ah_)
                        {
                            y_ = ae_ as CqlInterval<CqlDateTime>;
                        }
                        else
                        {
                            bool ai_ = ae_ is CqlInterval<CqlQuantity>;
                            if (ai_)
                            {
                                y_ = ae_ as CqlInterval<CqlQuantity>;
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
                CqlBoolean ab_ = context.Operators.SameOrBefore(x_, aa_, "day");

                CqlBoolean ac_() {
                    DataType aj_ = ExclusionDiagnosis?.Onset;
                    object ak_ = FHIRHelpers_4_4_000.Instance.ToValue(context, aj_);
                    CqlInterval<CqlDateTime> al_ = QICoreCommon_4_0_000.Instance.toInterval(context, ak_);
                    CqlDateTime am_ = context.Operators.Start(al_);
                    object an_;
                    DataType ar_ = FirstBladderCancerStaging?.Performed;
                    object as_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ar_);
                    bool at_ = as_ is CqlDateTime;
                    if (at_)
                    {
                        an_ = as_ as CqlDateTime;
                    }
                    else
                    {
                        bool au_ = as_ is CqlQuantity;
                        if (au_)
                        {
                            an_ = as_ as CqlQuantity;
                        }
                        else
                        {
                            bool av_ = as_ is CqlInterval<CqlDateTime>;
                            if (av_)
                            {
                                an_ = as_ as CqlInterval<CqlDateTime>;
                            }
                            else
                            {
                                bool aw_ = as_ is CqlInterval<CqlQuantity>;
                                if (aw_)
                                {
                                    an_ = as_ as CqlInterval<CqlQuantity>;
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
                    CqlBoolean aq_ = context.Operators.SameOrBefore(am_, ap_, "day");
                    return aq_;
                }

                return ab_
                    /* CQL 'or' (106:19-108:9) */ || ac_();
            }

            CqlBoolean v_ = context.Operators.WhereAny<Procedure>((IEnumerable<Procedure>)t_, u_);
            return v_;
        }

        IEnumerable<Condition> p_ = context.Operators.Where<Condition>(n_, o_);

        bool? q_(Condition ExclusionDiagnosis) {
            CqlBoolean ax_ = this.isVerified(context, ExclusionDiagnosis);
            return ax_;
        }

        CqlBoolean r_ = context.Operators.WhereAny<Condition>(p_, q_);
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
                CqlBoolean aa_ = context.Operators.Equal(w_, z_);

                CqlBoolean ab_() {
                    CodeableConcept ac_ = M?.Code;
                    CqlConcept ad_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, ac_);
                    CqlValueSet ae_ = this.Chemotherapy_Agents_for_Advanced_Cancer(context);
                    CqlBoolean af_ = context.Operators.ConceptInValueSet(ad_, ae_);
                    return af_;
                }

                return aa_
                    /* CQL 'and' */ && ab_();
            }

            CqlBoolean v_ = context.Operators.WhereAny<Medication>(t_, u_);
            return v_;
        }

        IEnumerable<MedicationRequest> c_ = context.Operators.Where<MedicationRequest>(a_, b_);
        CqlValueSet d_ = this.Chemotherapy_Agents_for_Advanced_Cancer(context);
        IEnumerable<MedicationRequest> e_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, d_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> f_ = context.Operators.Union<MedicationRequest>(c_, e_);

        bool? g_(MedicationRequest ExclusionMed) {
            Procedure ag_ = this.First_Bladder_Cancer_Staging_Procedure(context);
            Procedure[] ah_ = [
                ag_,
            ];

            bool? ai_(Procedure FirstBladderCancerStaging) {
                List<Dosage> ak_ = ExclusionMed?.DosageInstruction;

                bool? al_(Dosage @this) {
                    Timing bm_ = @this?.Timing;
                    return !((bool?)(bm_ is null));
                }


                Timing am_(Dosage @this) {
                    Timing bn_ = @this?.Timing;
                    return bn_;
                }

                IEnumerable<Timing> an_ = context.Operators.WhereSelect<Dosage, Timing>((IEnumerable<Dosage>)ak_, al_, am_);

                bool? ao_(Timing @this) {
                    Timing.RepeatComponent bo_ = @this?.Repeat;
                    return !((bool?)(bo_ is null));
                }


                Timing.RepeatComponent ap_(Timing @this) {
                    Timing.RepeatComponent bp_ = @this?.Repeat;
                    return bp_;
                }

                IEnumerable<Timing.RepeatComponent> aq_ = context.Operators.WhereSelect<Timing, Timing.RepeatComponent>(an_, ao_, ap_);

                bool? ar_(Timing.RepeatComponent @this) {
                    DataType bq_ = @this?.Bounds;
                    object br_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bq_);
                    return !((bool?)(br_ is null));
                }


                object as_(Timing.RepeatComponent @this) {
                    DataType bs_ = @this?.Bounds;
                    object bt_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bs_);
                    return bt_;
                }

                IEnumerable<object> at_ = context.Operators.WhereSelect<Timing.RepeatComponent, object>(aq_, ar_, as_);

                CqlInterval<CqlDateTime> au_(object DoseTime) {
                    CqlInterval<CqlDateTime> bu_ = QICoreCommon_4_0_000.Instance.toInterval(context, DoseTime);
                    return bu_;
                }

                IEnumerable<CqlInterval<CqlDateTime>> av_ = context.Operators.SelectDistinct<object, CqlInterval<CqlDateTime>>(at_, au_);
                IEnumerable<CqlInterval<CqlDateTime>> aw_ = context.Operators.Collapse(av_, (string)default);

                object ax_(CqlInterval<CqlDateTime> @this) {
                    CqlDateTime bv_ = context.Operators.Start(@this);
                    return bv_;
                }

                IEnumerable<CqlInterval<CqlDateTime>> ay_ = context.Operators.SortBy<CqlInterval<CqlDateTime>>(aw_, ax_, System.ComponentModel.ListSortDirection.Ascending);
                CqlInterval<CqlDateTime> az_ = context.Operators.First<CqlInterval<CqlDateTime>>(ay_);
                CqlDateTime ba_ = context.Operators.Start(az_);
                object bb_;
                DataType bw_ = FirstBladderCancerStaging?.Performed;
                object bx_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bw_);
                bool by_ = bx_ is CqlDateTime;
                if (by_)
                {
                    bb_ = bx_ as CqlDateTime;
                }
                else
                {
                    bool bz_ = bx_ is CqlQuantity;
                    if (bz_)
                    {
                        bb_ = bx_ as CqlQuantity;
                    }
                    else
                    {
                        bool ca_ = bx_ is CqlInterval<CqlDateTime>;
                        if (ca_)
                        {
                            bb_ = bx_ as CqlInterval<CqlDateTime>;
                        }
                        else
                        {
                            bool cb_ = bx_ is CqlInterval<CqlQuantity>;
                            if (cb_)
                            {
                                bb_ = bx_ as CqlInterval<CqlQuantity>;
                            }
                            else
                            {
                                bb_ = null;
                            }
                        }
                    }
                }
                CqlInterval<CqlDateTime> bc_ = QICoreCommon_4_0_000.Instance.toInterval(context, bb_);
                CqlDateTime bd_ = context.Operators.Start(bc_);
                CqlQuantity be_ = context.Operators.Quantity(6m, "months");
                CqlDateTime bf_ = context.Operators.Subtract(bd_, be_);
                object bg_;
                DataType cc_ = FirstBladderCancerStaging?.Performed;
                object cd_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cc_);
                bool ce_ = cd_ is CqlDateTime;
                if (ce_)
                {
                    bg_ = cd_ as CqlDateTime;
                }
                else
                {
                    bool cf_ = cd_ is CqlQuantity;
                    if (cf_)
                    {
                        bg_ = cd_ as CqlQuantity;
                    }
                    else
                    {
                        bool cg_ = cd_ is CqlInterval<CqlDateTime>;
                        if (cg_)
                        {
                            bg_ = cd_ as CqlInterval<CqlDateTime>;
                        }
                        else
                        {
                            bool ch_ = cd_ is CqlInterval<CqlQuantity>;
                            if (ch_)
                            {
                                bg_ = cd_ as CqlInterval<CqlQuantity>;
                            }
                            else
                            {
                                bg_ = null;
                            }
                        }
                    }
                }
                CqlInterval<CqlDateTime> bh_ = QICoreCommon_4_0_000.Instance.toInterval(context, bg_);
                CqlDateTime bi_ = context.Operators.Start(bh_);
                CqlInterval<CqlDateTime> bj_ = context.Operators.Interval(bf_, bi_, true, false);
                CqlBoolean bk_ = context.Operators.In<CqlDateTime>(ba_, bj_, (string)default);

                CqlBoolean bl_() {
                    object ci_;
                    DataType cl_ = FirstBladderCancerStaging?.Performed;
                    object cm_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cl_);
                    bool cn_ = cm_ is CqlDateTime;
                    if (cn_)
                    {
                        ci_ = cm_ as CqlDateTime;
                    }
                    else
                    {
                        bool co_ = cm_ is CqlQuantity;
                        if (co_)
                        {
                            ci_ = cm_ as CqlQuantity;
                        }
                        else
                        {
                            bool cp_ = cm_ is CqlInterval<CqlDateTime>;
                            if (cp_)
                            {
                                ci_ = cm_ as CqlInterval<CqlDateTime>;
                            }
                            else
                            {
                                bool cq_ = cm_ is CqlInterval<CqlQuantity>;
                                if (cq_)
                                {
                                    ci_ = cm_ as CqlInterval<CqlQuantity>;
                                }
                                else
                                {
                                    ci_ = null;
                                }
                            }
                        }
                    }
                    CqlInterval<CqlDateTime> cj_ = QICoreCommon_4_0_000.Instance.toInterval(context, ci_);
                    CqlDateTime ck_ = context.Operators.Start(cj_);
                    return !((bool?)(ck_ is null));
                }

                return bk_
                    /* CQL 'and' (120:21-120:123) */ && bl_();
            }

            CqlBoolean aj_ = context.Operators.WhereAny<Procedure>((IEnumerable<Procedure>)ah_, ai_);
            return aj_;
        }

        IEnumerable<MedicationRequest> h_ = context.Operators.Where<MedicationRequest>(f_, g_);

        bool? i_(MedicationRequest ExclusionMed) {
            Code<MedicationRequest.MedicationrequestStatus> cr_ = ExclusionMed?.StatusElement;
            MedicationRequest.MedicationrequestStatus? cs_ = cr_?.Value;
            string ct_ = context.Operators.Convert<string>(cs_);
            string[] cu_ = [
                "active",
                "completed",
            ];
            CqlBoolean cv_ = context.Operators.In<string>(ct_, (IEnumerable<string>)cu_);

            CqlBoolean cw_() {
                Code<MedicationRequest.MedicationRequestIntent> cx_ = ExclusionMed?.IntentElement;
                MedicationRequest.MedicationRequestIntent? cy_ = cx_?.Value;
                string cz_ = context.Operators.Convert<string>(cy_);
                CqlBoolean da_ = context.Operators.Equal(cz_, "order");
                return da_;
            }

            return cv_
                /* CQL 'and' (121:9-122:43) */ && cw_();
        }

        IEnumerable<MedicationRequest> j_ = context.Operators.Where<MedicationRequest>(h_, i_);
        CqlCode k_ = this.Combined_radiotherapy__procedure_(context);
        IEnumerable<CqlCode> l_ = context.Operators.ToList<CqlCode>(k_);
        IEnumerable<Procedure> m_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, default, l_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));

        bool? n_(Procedure ExclusionProcedure) {
            Procedure db_ = this.First_Bladder_Cancer_Staging_Procedure(context);
            Procedure[] dc_ = [
                db_,
            ];

            bool? dd_(Procedure FirstBladderCancerStaging) {
                object df_;
                DataType dt_ = ExclusionProcedure?.Performed;
                object du_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dt_);
                bool dv_ = du_ is CqlDateTime;
                if (dv_)
                {
                    df_ = du_ as CqlDateTime;
                }
                else
                {
                    bool dw_ = du_ is CqlQuantity;
                    if (dw_)
                    {
                        df_ = du_ as CqlQuantity;
                    }
                    else
                    {
                        bool dx_ = du_ is CqlInterval<CqlDateTime>;
                        if (dx_)
                        {
                            df_ = du_ as CqlInterval<CqlDateTime>;
                        }
                        else
                        {
                            bool dy_ = du_ is CqlInterval<CqlQuantity>;
                            if (dy_)
                            {
                                df_ = du_ as CqlInterval<CqlQuantity>;
                            }
                            else
                            {
                                df_ = null;
                            }
                        }
                    }
                }
                CqlInterval<CqlDateTime> dg_ = QICoreCommon_4_0_000.Instance.toInterval(context, df_);
                CqlDateTime dh_ = context.Operators.Start(dg_);
                object di_;
                DataType dz_ = FirstBladderCancerStaging?.Performed;
                object ea_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dz_);
                bool eb_ = ea_ is CqlDateTime;
                if (eb_)
                {
                    di_ = ea_ as CqlDateTime;
                }
                else
                {
                    bool ec_ = ea_ is CqlQuantity;
                    if (ec_)
                    {
                        di_ = ea_ as CqlQuantity;
                    }
                    else
                    {
                        bool ed_ = ea_ is CqlInterval<CqlDateTime>;
                        if (ed_)
                        {
                            di_ = ea_ as CqlInterval<CqlDateTime>;
                        }
                        else
                        {
                            bool ee_ = ea_ is CqlInterval<CqlQuantity>;
                            if (ee_)
                            {
                                di_ = ea_ as CqlInterval<CqlQuantity>;
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
                CqlQuantity dl_ = context.Operators.Quantity(6m, "months");
                CqlDateTime dm_ = context.Operators.Subtract(dk_, dl_);
                object dn_;
                DataType ef_ = FirstBladderCancerStaging?.Performed;
                object eg_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ef_);
                bool eh_ = eg_ is CqlDateTime;
                if (eh_)
                {
                    dn_ = eg_ as CqlDateTime;
                }
                else
                {
                    bool ei_ = eg_ is CqlQuantity;
                    if (ei_)
                    {
                        dn_ = eg_ as CqlQuantity;
                    }
                    else
                    {
                        bool ej_ = eg_ is CqlInterval<CqlDateTime>;
                        if (ej_)
                        {
                            dn_ = eg_ as CqlInterval<CqlDateTime>;
                        }
                        else
                        {
                            bool ek_ = eg_ is CqlInterval<CqlQuantity>;
                            if (ek_)
                            {
                                dn_ = eg_ as CqlInterval<CqlQuantity>;
                            }
                            else
                            {
                                dn_ = null;
                            }
                        }
                    }
                }
                CqlInterval<CqlDateTime> do_ = QICoreCommon_4_0_000.Instance.toInterval(context, dn_);
                CqlDateTime dp_ = context.Operators.Start(do_);
                CqlInterval<CqlDateTime> dq_ = context.Operators.Interval(dm_, dp_, true, false);
                CqlBoolean dr_ = context.Operators.In<CqlDateTime>(dh_, dq_, (string)default);

                CqlBoolean ds_() {
                    object el_;
                    DataType eo_ = FirstBladderCancerStaging?.Performed;
                    object ep_ = FHIRHelpers_4_4_000.Instance.ToValue(context, eo_);
                    bool eq_ = ep_ is CqlDateTime;
                    if (eq_)
                    {
                        el_ = ep_ as CqlDateTime;
                    }
                    else
                    {
                        bool er_ = ep_ is CqlQuantity;
                        if (er_)
                        {
                            el_ = ep_ as CqlQuantity;
                        }
                        else
                        {
                            bool es_ = ep_ is CqlInterval<CqlDateTime>;
                            if (es_)
                            {
                                el_ = ep_ as CqlInterval<CqlDateTime>;
                            }
                            else
                            {
                                bool et_ = ep_ is CqlInterval<CqlQuantity>;
                                if (et_)
                                {
                                    el_ = ep_ as CqlInterval<CqlQuantity>;
                                }
                                else
                                {
                                    el_ = null;
                                }
                            }
                        }
                    }
                    CqlInterval<CqlDateTime> em_ = QICoreCommon_4_0_000.Instance.toInterval(context, el_);
                    CqlDateTime en_ = context.Operators.Start(em_);
                    return !((bool?)(en_ is null));
                }

                return dr_
                    /* CQL 'and' (126:23-126:147) */ && ds_();
            }

            CqlBoolean de_ = context.Operators.WhereAny<Procedure>((IEnumerable<Procedure>)dc_, dd_);
            return de_;
        }

        IEnumerable<Procedure> o_ = context.Operators.Where<Procedure>(m_, n_);

        bool? p_(Procedure ExclusionProcedure) {
            Code<EventStatus> eu_ = ExclusionProcedure?.StatusElement;
            EventStatus? ev_ = eu_?.Value;
            string ew_ = context.Operators.Convert<string>(ev_);
            string[] ex_ = [
                "completed",
                "in-progress",
            ];
            CqlBoolean ey_ = context.Operators.In<string>(ew_, (IEnumerable<string>)ex_);
            return ey_;
        }

        IEnumerable<Procedure> q_ = context.Operators.Where<Procedure>(o_, p_);
        IEnumerable<object> r_ = context.Operators.Union<object>(j_ as IEnumerable<object>, q_ as IEnumerable<object>);
        CqlBoolean s_ = context.Operators.Exists<object>(r_);
        return s_;
    }


    [CqlExpressionDefinition("Denominator Exclusion")]
    public bool? Denominator_Exclusion(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Denominator_Exclusion, Denominator_Exclusion_Compute);

    private const long _cacheIndex_Denominator_Exclusion = -2497759738663303621L;

    private bool? Denominator_Exclusion_Compute(CqlContext context)
    {
        IEnumerable<Condition> a_ = this.Acute_Tuberculosis_Diagnosis(context);
        CqlBoolean b_ = context.Operators.Exists<Condition>(a_);

        CqlBoolean c_() {
            IEnumerable<MedicationRequest> e_ = this.Immunosuppressive_Drugs(context);
            CqlBoolean f_ = context.Operators.Exists<MedicationRequest>(e_);
            return f_;
        }


        CqlBoolean d_() {
            IEnumerable<Procedure> g_ = this.Cystectomy_Done(context);
            CqlBoolean h_ = context.Operators.Exists<Procedure>(g_);
            return h_;
        }

        return b_
            /* CQL 'or' (46:3-47:39) */ || c_()
            /* CQL 'or' (46:3-48:31) */ || d_()
            /* CQL 'or' (46:3-49:90) */ || this.Has_Excluding_HIV__Immunocompromised_Conditions_or_Mixed_Histology_Before_Staging(context)
            /* CQL 'or' (46:3-50:76) */ || this.Has_Excluding_Chemotherapy_or_Radiotherapy_Procedure_Before_Staging(context);
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
                    FhirUri ac_ = @this?.UrlElement;
                    string ad_ = FHIRHelpers_4_4_000.Instance.ToString(context, ac_);
                    CqlBoolean ae_ = context.Operators.Equal(ad_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-recorded");
                    return ae_;
                }


                DataType m_(Extension @this) {
                    DataType af_ = @this?.Value;
                    return af_;
                }

                IEnumerable<DataType> n_ = context.Operators.WhereSelect<Extension, DataType>((IEnumerable<Extension>)(BCGNotGiven is DomainResource
                    ? (BCGNotGiven as DomainResource).Extension
                    : default), l_, m_);
                DataType o_ = context.Operators.SingletonFrom<DataType>(n_);
                FhirDateTime p_ = context.Operators.Convert<FhirDateTime>(o_);
                CqlDateTime q_ = context.Operators.Convert<CqlDateTime>(p_);
                object r_;
                DataType ag_ = FirstBladderCancerStaging?.Performed;
                object ah_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ag_);
                bool ai_ = ah_ is CqlDateTime;
                if (ai_)
                {
                    r_ = ah_ as CqlDateTime;
                }
                else
                {
                    bool aj_ = ah_ is CqlQuantity;
                    if (aj_)
                    {
                        r_ = ah_ as CqlQuantity;
                    }
                    else
                    {
                        bool ak_ = ah_ is CqlInterval<CqlDateTime>;
                        if (ak_)
                        {
                            r_ = ah_ as CqlInterval<CqlDateTime>;
                        }
                        else
                        {
                            bool al_ = ah_ is CqlInterval<CqlQuantity>;
                            if (al_)
                            {
                                r_ = ah_ as CqlInterval<CqlQuantity>;
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
                DataType am_ = FirstBladderCancerStaging?.Performed;
                object an_ = FHIRHelpers_4_4_000.Instance.ToValue(context, am_);
                bool ao_ = an_ is CqlDateTime;
                if (ao_)
                {
                    u_ = an_ as CqlDateTime;
                }
                else
                {
                    bool ap_ = an_ is CqlQuantity;
                    if (ap_)
                    {
                        u_ = an_ as CqlQuantity;
                    }
                    else
                    {
                        bool aq_ = an_ is CqlInterval<CqlDateTime>;
                        if (aq_)
                        {
                            u_ = an_ as CqlInterval<CqlDateTime>;
                        }
                        else
                        {
                            bool ar_ = an_ is CqlInterval<CqlQuantity>;
                            if (ar_)
                            {
                                u_ = an_ as CqlInterval<CqlQuantity>;
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
                CqlBoolean aa_ = context.Operators.In<CqlDateTime>(q_, z_, "day");

                CqlBoolean ab_() {
                    object as_;
                    DataType av_ = FirstBladderCancerStaging?.Performed;
                    object aw_ = FHIRHelpers_4_4_000.Instance.ToValue(context, av_);
                    bool ax_ = aw_ is CqlDateTime;
                    if (ax_)
                    {
                        as_ = aw_ as CqlDateTime;
                    }
                    else
                    {
                        bool ay_ = aw_ is CqlQuantity;
                        if (ay_)
                        {
                            as_ = aw_ as CqlQuantity;
                        }
                        else
                        {
                            bool az_ = aw_ is CqlInterval<CqlDateTime>;
                            if (az_)
                            {
                                as_ = aw_ as CqlInterval<CqlDateTime>;
                            }
                            else
                            {
                                bool ba_ = aw_ is CqlInterval<CqlQuantity>;
                                if (ba_)
                                {
                                    as_ = aw_ as CqlInterval<CqlQuantity>;
                                }
                                else
                                {
                                    as_ = null;
                                }
                            }
                        }
                    }
                    CqlInterval<CqlDateTime> at_ = QICoreCommon_4_0_000.Instance.toInterval(context, as_);
                    CqlDateTime au_ = context.Operators.Start(at_);
                    return !((bool?)(au_ is null));
                }

                return aa_
                    /* CQL 'and' (157:17-157:126) */ && ab_();
            }

            CqlBoolean k_ = context.Operators.WhereAny<Procedure>((IEnumerable<Procedure>)i_, j_);
            return k_;
        }

        IEnumerable<MedicationAdministration> e_ = context.Operators.Where<MedicationAdministration>(c_, d_);

        bool? f_(MedicationAdministration BCGNotGiven) {
            List<CodeableConcept> bb_ = BCGNotGiven?.StatusReason;

            CqlConcept bc_(CodeableConcept @this) {
                CqlConcept bg_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);
                return bg_;
            }

            IEnumerable<CqlConcept> bd_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)bb_, bc_);
            CqlValueSet be_ = this.Unavailability_of_Bacillus_Calmette_Guerin_for_Urology_Care(context);
            CqlBoolean bf_ = context.Operators.ConceptsInValueSet(bd_, be_);
            return bf_;
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
        CqlBoolean b_ = context.Operators.Exists<MedicationAdministration>(a_);
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
                CqlBoolean u_ = context.Operators.Equal(q_, t_);

                CqlBoolean v_() {
                    CodeableConcept w_ = M?.Code;
                    CqlConcept x_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, w_);
                    CqlValueSet y_ = this.Bacillus_Calmette_Guerin_for_Urology_Care(context);
                    CqlBoolean z_ = context.Operators.ConceptInValueSet(x_, y_);
                    return z_;
                }

                return u_
                    /* CQL 'and' */ && v_();
            }

            CqlBoolean p_ = context.Operators.WhereAny<Medication>(n_, o_);
            return p_;
        }

        IEnumerable<MedicationAdministration> c_ = context.Operators.Where<MedicationAdministration>(a_, b_);
        CqlValueSet d_ = this.Bacillus_Calmette_Guerin_for_Urology_Care(context);
        IEnumerable<MedicationAdministration> e_ = context.Operators.Retrieve<MedicationAdministration>(new RetrieveParameters(default, d_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationadministration"));
        IEnumerable<MedicationAdministration> f_ = context.Operators.Union<MedicationAdministration>(c_, e_);

        bool? g_(MedicationAdministration BCG) {
            Procedure aa_ = this.First_Bladder_Cancer_Staging_Procedure(context);
            Procedure[] ab_ = [
                aa_,
            ];

            bool? ac_(Procedure FirstBladderCancerStaging) {
                DataType ae_ = BCG?.Effective;
                object af_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ae_);
                CqlInterval<CqlDateTime> ag_ = QICoreCommon_4_0_000.Instance.toInterval(context, af_);
                CqlDateTime ah_ = context.Operators.Start(ag_);
                object ai_;
                DataType au_ = FirstBladderCancerStaging?.Performed;
                object av_ = FHIRHelpers_4_4_000.Instance.ToValue(context, au_);
                bool aw_ = av_ is CqlDateTime;
                if (aw_)
                {
                    ai_ = av_ as CqlDateTime;
                }
                else
                {
                    bool ax_ = av_ is CqlQuantity;
                    if (ax_)
                    {
                        ai_ = av_ as CqlQuantity;
                    }
                    else
                    {
                        bool ay_ = av_ is CqlInterval<CqlDateTime>;
                        if (ay_)
                        {
                            ai_ = av_ as CqlInterval<CqlDateTime>;
                        }
                        else
                        {
                            bool az_ = av_ is CqlInterval<CqlQuantity>;
                            if (az_)
                            {
                                ai_ = av_ as CqlInterval<CqlQuantity>;
                            }
                            else
                            {
                                ai_ = null;
                            }
                        }
                    }
                }
                CqlInterval<CqlDateTime> aj_ = QICoreCommon_4_0_000.Instance.toInterval(context, ai_);
                CqlDateTime ak_ = context.Operators.Start(aj_);
                object al_;
                DataType ba_ = FirstBladderCancerStaging?.Performed;
                object bb_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ba_);
                bool bc_ = bb_ is CqlDateTime;
                if (bc_)
                {
                    al_ = bb_ as CqlDateTime;
                }
                else
                {
                    bool bd_ = bb_ is CqlQuantity;
                    if (bd_)
                    {
                        al_ = bb_ as CqlQuantity;
                    }
                    else
                    {
                        bool be_ = bb_ is CqlInterval<CqlDateTime>;
                        if (be_)
                        {
                            al_ = bb_ as CqlInterval<CqlDateTime>;
                        }
                        else
                        {
                            bool bf_ = bb_ is CqlInterval<CqlQuantity>;
                            if (bf_)
                            {
                                al_ = bb_ as CqlInterval<CqlQuantity>;
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
                CqlQuantity ao_ = context.Operators.Quantity(6m, "months");
                CqlDateTime ap_ = context.Operators.Add(an_, ao_);
                CqlInterval<CqlDateTime> aq_ = context.Operators.Interval(ak_, ap_, false, true);
                CqlBoolean ar_ = context.Operators.In<CqlDateTime>(ah_, aq_, "day");

                CqlBoolean as_() {
                    object bg_;
                    DataType bj_ = FirstBladderCancerStaging?.Performed;
                    object bk_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bj_);
                    bool bl_ = bk_ is CqlDateTime;
                    if (bl_)
                    {
                        bg_ = bk_ as CqlDateTime;
                    }
                    else
                    {
                        bool bm_ = bk_ is CqlQuantity;
                        if (bm_)
                        {
                            bg_ = bk_ as CqlQuantity;
                        }
                        else
                        {
                            bool bn_ = bk_ is CqlInterval<CqlDateTime>;
                            if (bn_)
                            {
                                bg_ = bk_ as CqlInterval<CqlDateTime>;
                            }
                            else
                            {
                                bool bo_ = bk_ is CqlInterval<CqlQuantity>;
                                if (bo_)
                                {
                                    bg_ = bk_ as CqlInterval<CqlQuantity>;
                                }
                                else
                                {
                                    bg_ = null;
                                }
                            }
                        }
                    }
                    CqlInterval<CqlDateTime> bh_ = QICoreCommon_4_0_000.Instance.toInterval(context, bg_);
                    CqlDateTime bi_ = context.Operators.Start(bh_);
                    return !((bool?)(bi_ is null));
                }


                CqlBoolean at_() {
                    DataType bp_ = BCG?.Effective;
                    object bq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bp_);
                    CqlInterval<CqlDateTime> br_ = QICoreCommon_4_0_000.Instance.toInterval(context, bq_);
                    CqlDateTime bs_ = context.Operators.Start(br_);
                    CqlInterval<CqlDateTime> bt_ = this.Measurement_Period(context);
                    CqlBoolean bu_ = context.Operators.In<CqlDateTime>(bs_, bt_, "day");
                    return bu_;
                }

                return ar_
                    /* CQL 'and' (167:19-167:139) */ && as_()
                    /* CQL 'and' (167:19-168:82) */ && at_();
            }

            CqlBoolean ad_ = context.Operators.WhereAny<Procedure>((IEnumerable<Procedure>)ab_, ac_);
            return ad_;
        }

        IEnumerable<MedicationAdministration> h_ = context.Operators.Where<MedicationAdministration>(f_, g_);

        bool? i_(MedicationAdministration BCG) {
            Code<MedicationAdministration.MedicationAdministrationStatusCodes> bv_ = BCG?.StatusElement;
            MedicationAdministration.MedicationAdministrationStatusCodes? bw_ = bv_?.Value;
            string bx_ = context.Operators.Convert<string>(bw_);
            string[] by_ = [
                "in-progress",
                "completed",
            ];
            CqlBoolean bz_ = context.Operators.In<string>(bx_, (IEnumerable<string>)by_);
            return bz_;
        }

        IEnumerable<MedicationAdministration> j_ = context.Operators.Where<MedicationAdministration>(h_, i_);

        object k_(MedicationAdministration @this) {
            DataType ca_ = @this?.Effective;
            object cb_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ca_);
            CqlInterval<CqlDateTime> cc_ = QICoreCommon_4_0_000.Instance.toInterval(context, cb_);
            CqlDateTime cd_ = context.Operators.Start(cc_);
            return cd_;
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

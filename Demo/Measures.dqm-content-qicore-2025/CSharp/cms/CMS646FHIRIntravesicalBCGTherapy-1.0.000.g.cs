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

[System.CodeDom.Compiler.GeneratedCode(".NET Code Generation", "5.3.8.0")]
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
        CqlCode c_ = QICoreCommon_4_0_000.Instance.confirmed(context);
        CqlConcept d_ = context.Operators.ConvertCodeToConcept(c_);
        CqlBoolean e_ = context.Operators.Equivalent(b_, d_);
        CqlCode f_ = QICoreCommon_4_0_000.Instance.unconfirmed(context);
        CqlConcept g_ = context.Operators.ConvertCodeToConcept(f_);
        CqlBoolean h_ = context.Operators.Equivalent(b_, g_);
        CqlBoolean i_ = h_;
        CqlCode j_ = QICoreCommon_4_0_000.Instance.provisional(context);
        CqlConcept k_ = context.Operators.ConvertCodeToConcept(j_);
        CqlBoolean l_ = context.Operators.Equivalent(b_, k_);
        CqlBoolean m_ = l_;
        CqlCode n_ = QICoreCommon_4_0_000.Instance.differential(context);
        CqlConcept o_ = context.Operators.ConvertCodeToConcept(n_);
        CqlBoolean p_ = context.Operators.Equivalent(b_, o_);
        CqlBoolean q_ = p_;
        CqlBoolean r_ = e_
            /* CQL 'or' (216:54-217:66) */ || i_
            /* CQL 'or' (216:54-218:66) */ || m_
            /* CQL 'or' (216:52-220:3) */ || q_;
        return (CqlBoolean)(b_ is null)
            /* CQL 'implies' (216:3-220:3) */ || r_;
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
            DataType l_ = BladderCancer?.Onset;
            object m_ = FHIRHelpers_4_4_000.Instance.ToValue(context, l_);
            CqlInterval<CqlDateTime> n_ = QICoreCommon_4_0_000.Instance.toInterval(context, m_);
            CqlInterval<CqlDateTime> o_;
            if (j_ is null)
            {
                o_ = default;
            }
            else
            {
                CqlInterval<CqlDateTime> r_ = context.Operators.Interval(j_, j_, true, true);
                o_ = r_;
            }
            CqlBoolean p_ = context.Operators.Before(n_, o_, "day");
            CqlBoolean q_ = p_;
            return (k_
                /* CQL 'or' (149:11-151:5) */ || q_)
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
            DataType e_ = StagingObservation?.Value;
            object f_ = FHIRHelpers_4_4_000.Instance.ToValue(context, e_);
            CqlCode g_ = this.American_Joint_Committee_on_Cancer_cT1__qualifier_value_(context);
            CqlConcept h_ = context.Operators.ConvertCodeToConcept(g_);
            CqlBoolean i_ = context.Operators.Equivalent(f_ as CqlConcept, h_);
            CqlCode j_ = this.American_Joint_Committee_on_Cancer_cTis__qualifier_value_(context);
            CqlConcept k_ = context.Operators.ConvertCodeToConcept(j_);
            CqlBoolean l_ = context.Operators.Equivalent(f_ as CqlConcept, k_);
            CqlBoolean m_ = l_;
            CqlCode n_ = this.American_Joint_Committee_on_Cancer_cTa__qualifier_value_(context);
            CqlConcept o_ = context.Operators.ConvertCodeToConcept(n_);
            CqlBoolean p_ = context.Operators.Equivalent(f_ as CqlConcept, o_);
            CqlBoolean q_ = p_;
            CqlCode r_ = this.Carcinoma_in_situ_of_bladder(context);
            CqlConcept s_ = context.Operators.ConvertCodeToConcept(r_);
            CqlBoolean t_ = context.Operators.Equivalent(f_ as CqlConcept, s_);
            CqlBoolean u_ = t_;
            CqlBoolean v_ = i_
                /* CQL 'or' (179:15-180:112) */ || m_
                /* CQL 'or' (179:15-181:111) */ || q_
                /* CQL 'or' (179:13-183:9) */ || u_;
            Code<ObservationStatus> w_ = StagingObservation?.StatusElement;
            ObservationStatus? x_ = w_?.Value;
            string y_ = context.Operators.Convert<string>(x_);
            string[] z_ = [
                "final",
                "amended",
                "corrected",
            ];
            CqlBoolean aa_ = context.Operators.In<string>(y_, (IEnumerable<string>)z_);
            CqlBoolean ab_ = aa_;
            return (CqlBoolean)(d_ is not null)
                /* CQL 'and' (178:13-183:9) */ && v_
                /* CQL 'and' (178:7-184:76) */ && ab_;
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
            Coding i_ = ValidEncounter?.Class;
            CqlCode j_ = FHIRHelpers_4_4_000.Instance.ToCode(context, i_);
            CqlCode k_ = this.@virtual(context);
            CqlBoolean l_ = context.Operators.Equivalent(j_, k_);
            CqlBoolean m_ = (CqlBoolean)!l_;
            Code<Encounter.EncounterStatus> n_ = ValidEncounter?.StatusElement;
            Encounter.EncounterStatus? o_ = n_?.Value;
            Code<Encounter.EncounterStatus> p_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(o_);
            CqlBoolean q_ = context.Operators.Equal(p_, "finished");
            CqlBoolean r_ = q_;
            return h_
                /* CQL 'and' (141:13-142:45) */ && m_
                /* CQL 'and' (141:7-143:46) */ && r_;
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
                DataType af_ = FirstBladderCancerStaging?.Performed;
                object ag_ = FHIRHelpers_4_4_000.Instance.ToValue(context, af_);
                bool ah_ = ag_ is CqlDateTime;
                if (ah_)
                {
                    n_ = ag_ as CqlDateTime;
                }
                else
                {
                    bool ai_ = ag_ is CqlQuantity;
                    if (ai_)
                    {
                        n_ = ag_ as CqlQuantity;
                    }
                    else
                    {
                        bool aj_ = ag_ is CqlInterval<CqlDateTime>;
                        if (aj_)
                        {
                            n_ = ag_ as CqlInterval<CqlDateTime>;
                        }
                        else
                        {
                            bool ak_ = ag_ is CqlInterval<CqlQuantity>;
                            if (ak_)
                            {
                                n_ = ag_ as CqlInterval<CqlQuantity>;
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
                DataType q_ = ActiveTuberculosis?.Onset;
                object r_ = FHIRHelpers_4_4_000.Instance.ToValue(context, q_);
                CqlInterval<CqlDateTime> s_ = QICoreCommon_4_0_000.Instance.toInterval(context, r_);
                object t_;
                DataType al_ = FirstBladderCancerStaging?.Performed;
                object am_ = FHIRHelpers_4_4_000.Instance.ToValue(context, al_);
                bool an_ = am_ is CqlDateTime;
                if (an_)
                {
                    t_ = am_ as CqlDateTime;
                }
                else
                {
                    bool ao_ = am_ is CqlQuantity;
                    if (ao_)
                    {
                        t_ = am_ as CqlQuantity;
                    }
                    else
                    {
                        bool ap_ = am_ is CqlInterval<CqlDateTime>;
                        if (ap_)
                        {
                            t_ = am_ as CqlInterval<CqlDateTime>;
                        }
                        else
                        {
                            bool aq_ = am_ is CqlInterval<CqlQuantity>;
                            if (aq_)
                            {
                                t_ = am_ as CqlInterval<CqlQuantity>;
                            }
                            else
                            {
                                t_ = null;
                            }
                        }
                    }
                }
                CqlInterval<CqlDateTime> u_ = QICoreCommon_4_0_000.Instance.toInterval(context, t_);
                CqlBoolean v_ = context.Operators.OverlapsAfter(s_, u_, "day");
                DataType w_ = ActiveTuberculosis?.Abatement;
                object x_ = FHIRHelpers_4_4_000.Instance.ToValue(context, w_);
                CqlInterval<CqlDateTime> y_ = QICoreCommon_4_0_000.Instance.toInterval(context, x_);
                object z_;
                DataType ar_ = FirstBladderCancerStaging?.Performed;
                object as_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ar_);
                bool at_ = as_ is CqlDateTime;
                if (at_)
                {
                    z_ = as_ as CqlDateTime;
                }
                else
                {
                    bool au_ = as_ is CqlQuantity;
                    if (au_)
                    {
                        z_ = as_ as CqlQuantity;
                    }
                    else
                    {
                        bool av_ = as_ is CqlInterval<CqlDateTime>;
                        if (av_)
                        {
                            z_ = as_ as CqlInterval<CqlDateTime>;
                        }
                        else
                        {
                            bool aw_ = as_ is CqlInterval<CqlQuantity>;
                            if (aw_)
                            {
                                z_ = as_ as CqlInterval<CqlQuantity>;
                            }
                            else
                            {
                                z_ = null;
                            }
                        }
                    }
                }
                CqlInterval<CqlDateTime> aa_ = QICoreCommon_4_0_000.Instance.toInterval(context, z_);
                CqlBoolean ab_ = context.Operators.OverlapsAfter(y_, aa_, "day");
                CqlBoolean ac_ = (CqlBoolean)(x_ is null);
                CqlBoolean ad_ = ab_
                    /* CQL 'or' (82:19-84:15) */ || ac_;
                CqlBoolean ae_ = v_
                    /* CQL 'and' (81:14-85:11) */ && ad_;
                return p_
                    /* CQL 'or' (80:17-86:7) */ || ae_;
            }

            CqlBoolean l_ = context.Operators.WhereAny<Procedure>((IEnumerable<Procedure>)j_, k_);
            return l_;
        }

        IEnumerable<Condition> f_ = context.Operators.Where<Condition>(d_, e_);

        bool? g_(Condition ActiveTuberculosis) {
            CqlBoolean ax_ = this.isVerified(context, ActiveTuberculosis);
            return ax_;
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
                CodeableConcept s_ = M?.Code;
                CqlConcept t_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, s_);
                CqlValueSet u_ = this.Immunosuppressive_Drugs_for_Urology_Care(context);
                CqlBoolean v_ = context.Operators.ConceptInValueSet(t_, u_);
                CqlBoolean w_ = v_;
                return r_
                    /* CQL 'and' */ && w_;
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
                    return be_ is not null;
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
                    return bp_ is not null;
                }


                Timing al_(Dosage @this) {
                    Timing bq_ = @this?.Timing;
                    return bq_;
                }

                IEnumerable<Timing> am_ = context.Operators.WhereSelect<Dosage, Timing>((IEnumerable<Dosage>)ab_, ak_, al_);

                bool? an_(Timing @this) {
                    Timing.RepeatComponent br_ = @this?.Repeat;
                    return br_ is not null;
                }


                Timing.RepeatComponent ao_(Timing @this) {
                    Timing.RepeatComponent bs_ = @this?.Repeat;
                    return bs_;
                }

                IEnumerable<Timing.RepeatComponent> ap_ = context.Operators.WhereSelect<Timing, Timing.RepeatComponent>(am_, an_, ao_);

                bool? aq_(Timing.RepeatComponent @this) {
                    DataType bt_ = @this?.Bounds;
                    object bu_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bt_);
                    return bu_ is not null;
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
            Code<MedicationRequest.MedicationRequestIntent> ck_ = ImmunosuppressiveDrugs?.IntentElement;
            MedicationRequest.MedicationRequestIntent? cl_ = ck_?.Value;
            string cm_ = context.Operators.Convert<string>(cl_);
            CqlBoolean cn_ = context.Operators.Equal(cm_, "order");
            CqlBoolean co_ = cn_;
            return cj_
                /* CQL 'and' (212:5-213:49) */ && co_;
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
                DataType ab_ = Cystectomy?.Performed;
                object ac_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ab_);
                bool ad_ = ac_ is CqlDateTime;
                if (ad_)
                {
                    k_ = ac_ as CqlDateTime;
                }
                else
                {
                    bool ae_ = ac_ is CqlQuantity;
                    if (ae_)
                    {
                        k_ = ac_ as CqlQuantity;
                    }
                    else
                    {
                        bool af_ = ac_ is CqlInterval<CqlDateTime>;
                        if (af_)
                        {
                            k_ = ac_ as CqlInterval<CqlDateTime>;
                        }
                        else
                        {
                            bool ag_ = ac_ is CqlInterval<CqlQuantity>;
                            if (ag_)
                            {
                                k_ = ac_ as CqlInterval<CqlQuantity>;
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
                DataType ah_ = FirstBladderCancerStaging?.Performed;
                object ai_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ah_);
                bool aj_ = ai_ is CqlDateTime;
                if (aj_)
                {
                    n_ = ai_ as CqlDateTime;
                }
                else
                {
                    bool ak_ = ai_ is CqlQuantity;
                    if (ak_)
                    {
                        n_ = ai_ as CqlQuantity;
                    }
                    else
                    {
                        bool al_ = ai_ is CqlInterval<CqlDateTime>;
                        if (al_)
                        {
                            n_ = ai_ as CqlInterval<CqlDateTime>;
                        }
                        else
                        {
                            bool am_ = ai_ is CqlInterval<CqlQuantity>;
                            if (am_)
                            {
                                n_ = ai_ as CqlInterval<CqlQuantity>;
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
                DataType an_ = FirstBladderCancerStaging?.Performed;
                object ao_ = FHIRHelpers_4_4_000.Instance.ToValue(context, an_);
                bool ap_ = ao_ is CqlDateTime;
                if (ap_)
                {
                    s_ = ao_ as CqlDateTime;
                }
                else
                {
                    bool aq_ = ao_ is CqlQuantity;
                    if (aq_)
                    {
                        s_ = ao_ as CqlQuantity;
                    }
                    else
                    {
                        bool ar_ = ao_ is CqlInterval<CqlDateTime>;
                        if (ar_)
                        {
                            s_ = ao_ as CqlInterval<CqlDateTime>;
                        }
                        else
                        {
                            bool as_ = ao_ is CqlInterval<CqlQuantity>;
                            if (as_)
                            {
                                s_ = ao_ as CqlInterval<CqlQuantity>;
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
                object x_;
                DataType at_ = FirstBladderCancerStaging?.Performed;
                object au_ = FHIRHelpers_4_4_000.Instance.ToValue(context, at_);
                bool av_ = au_ is CqlDateTime;
                if (av_)
                {
                    x_ = au_ as CqlDateTime;
                }
                else
                {
                    bool aw_ = au_ is CqlQuantity;
                    if (aw_)
                    {
                        x_ = au_ as CqlQuantity;
                    }
                    else
                    {
                        bool ax_ = au_ is CqlInterval<CqlDateTime>;
                        if (ax_)
                        {
                            x_ = au_ as CqlInterval<CqlDateTime>;
                        }
                        else
                        {
                            bool ay_ = au_ is CqlInterval<CqlQuantity>;
                            if (ay_)
                            {
                                x_ = au_ as CqlInterval<CqlQuantity>;
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
                CqlBoolean aa_ = (CqlBoolean)(z_ is not null);
                return w_
                    /* CQL 'and' (92:17-92:142) */ && aa_;
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
                DataType al_ = FirstBladderCancerStaging?.Performed;
                object am_ = FHIRHelpers_4_4_000.Instance.ToValue(context, al_);
                bool an_ = am_ is CqlDateTime;
                if (an_)
                {
                    y_ = am_ as CqlDateTime;
                }
                else
                {
                    bool ao_ = am_ is CqlQuantity;
                    if (ao_)
                    {
                        y_ = am_ as CqlQuantity;
                    }
                    else
                    {
                        bool ap_ = am_ is CqlInterval<CqlDateTime>;
                        if (ap_)
                        {
                            y_ = am_ as CqlInterval<CqlDateTime>;
                        }
                        else
                        {
                            bool aq_ = am_ is CqlInterval<CqlQuantity>;
                            if (aq_)
                            {
                                y_ = am_ as CqlInterval<CqlQuantity>;
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
                DataType ac_ = ExclusionDiagnosis?.Onset;
                object ad_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ac_);
                CqlInterval<CqlDateTime> ae_ = QICoreCommon_4_0_000.Instance.toInterval(context, ad_);
                CqlDateTime af_ = context.Operators.Start(ae_);
                object ag_;
                DataType ar_ = FirstBladderCancerStaging?.Performed;
                object as_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ar_);
                bool at_ = as_ is CqlDateTime;
                if (at_)
                {
                    ag_ = as_ as CqlDateTime;
                }
                else
                {
                    bool au_ = as_ is CqlQuantity;
                    if (au_)
                    {
                        ag_ = as_ as CqlQuantity;
                    }
                    else
                    {
                        bool av_ = as_ is CqlInterval<CqlDateTime>;
                        if (av_)
                        {
                            ag_ = as_ as CqlInterval<CqlDateTime>;
                        }
                        else
                        {
                            bool aw_ = as_ is CqlInterval<CqlQuantity>;
                            if (aw_)
                            {
                                ag_ = as_ as CqlInterval<CqlQuantity>;
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
                CqlBoolean aj_ = context.Operators.SameOrBefore(af_, ai_, "day");
                CqlBoolean ak_ = aj_;
                return ab_
                    /* CQL 'or' (106:19-108:9) */ || ak_;
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
                CodeableConcept ab_ = M?.Code;
                CqlConcept ac_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, ab_);
                CqlValueSet ad_ = this.Chemotherapy_Agents_for_Advanced_Cancer(context);
                CqlBoolean ae_ = context.Operators.ConceptInValueSet(ac_, ad_);
                CqlBoolean af_ = ae_;
                return aa_
                    /* CQL 'and' */ && af_;
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
                    Timing bp_ = @this?.Timing;
                    return bp_ is not null;
                }


                Timing am_(Dosage @this) {
                    Timing bq_ = @this?.Timing;
                    return bq_;
                }

                IEnumerable<Timing> an_ = context.Operators.WhereSelect<Dosage, Timing>((IEnumerable<Dosage>)ak_, al_, am_);

                bool? ao_(Timing @this) {
                    Timing.RepeatComponent br_ = @this?.Repeat;
                    return br_ is not null;
                }


                Timing.RepeatComponent ap_(Timing @this) {
                    Timing.RepeatComponent bs_ = @this?.Repeat;
                    return bs_;
                }

                IEnumerable<Timing.RepeatComponent> aq_ = context.Operators.WhereSelect<Timing, Timing.RepeatComponent>(an_, ao_, ap_);

                bool? ar_(Timing.RepeatComponent @this) {
                    DataType bt_ = @this?.Bounds;
                    object bu_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bt_);
                    return bu_ is not null;
                }


                object as_(Timing.RepeatComponent @this) {
                    DataType bv_ = @this?.Bounds;
                    object bw_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bv_);
                    return bw_;
                }

                IEnumerable<object> at_ = context.Operators.WhereSelect<Timing.RepeatComponent, object>(aq_, ar_, as_);

                CqlInterval<CqlDateTime> au_(object DoseTime) {
                    CqlInterval<CqlDateTime> bx_ = QICoreCommon_4_0_000.Instance.toInterval(context, DoseTime);
                    return bx_;
                }

                IEnumerable<CqlInterval<CqlDateTime>> av_ = context.Operators.SelectDistinct<object, CqlInterval<CqlDateTime>>(at_, au_);
                IEnumerable<CqlInterval<CqlDateTime>> aw_ = context.Operators.Collapse(av_, (string)default);

                object ax_(CqlInterval<CqlDateTime> @this) {
                    CqlDateTime by_ = context.Operators.Start(@this);
                    return by_;
                }

                IEnumerable<CqlInterval<CqlDateTime>> ay_ = context.Operators.SortBy<CqlInterval<CqlDateTime>>(aw_, ax_, System.ComponentModel.ListSortDirection.Ascending);
                CqlInterval<CqlDateTime> az_ = context.Operators.First<CqlInterval<CqlDateTime>>(ay_);
                CqlDateTime ba_ = context.Operators.Start(az_);
                object bb_;
                DataType bz_ = FirstBladderCancerStaging?.Performed;
                object ca_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bz_);
                bool cb_ = ca_ is CqlDateTime;
                if (cb_)
                {
                    bb_ = ca_ as CqlDateTime;
                }
                else
                {
                    bool cc_ = ca_ is CqlQuantity;
                    if (cc_)
                    {
                        bb_ = ca_ as CqlQuantity;
                    }
                    else
                    {
                        bool cd_ = ca_ is CqlInterval<CqlDateTime>;
                        if (cd_)
                        {
                            bb_ = ca_ as CqlInterval<CqlDateTime>;
                        }
                        else
                        {
                            bool ce_ = ca_ is CqlInterval<CqlQuantity>;
                            if (ce_)
                            {
                                bb_ = ca_ as CqlInterval<CqlQuantity>;
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
                DataType cf_ = FirstBladderCancerStaging?.Performed;
                object cg_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cf_);
                bool ch_ = cg_ is CqlDateTime;
                if (ch_)
                {
                    bg_ = cg_ as CqlDateTime;
                }
                else
                {
                    bool ci_ = cg_ is CqlQuantity;
                    if (ci_)
                    {
                        bg_ = cg_ as CqlQuantity;
                    }
                    else
                    {
                        bool cj_ = cg_ is CqlInterval<CqlDateTime>;
                        if (cj_)
                        {
                            bg_ = cg_ as CqlInterval<CqlDateTime>;
                        }
                        else
                        {
                            bool ck_ = cg_ is CqlInterval<CqlQuantity>;
                            if (ck_)
                            {
                                bg_ = cg_ as CqlInterval<CqlQuantity>;
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
                object bl_;
                DataType cl_ = FirstBladderCancerStaging?.Performed;
                object cm_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cl_);
                bool cn_ = cm_ is CqlDateTime;
                if (cn_)
                {
                    bl_ = cm_ as CqlDateTime;
                }
                else
                {
                    bool co_ = cm_ is CqlQuantity;
                    if (co_)
                    {
                        bl_ = cm_ as CqlQuantity;
                    }
                    else
                    {
                        bool cp_ = cm_ is CqlInterval<CqlDateTime>;
                        if (cp_)
                        {
                            bl_ = cm_ as CqlInterval<CqlDateTime>;
                        }
                        else
                        {
                            bool cq_ = cm_ is CqlInterval<CqlQuantity>;
                            if (cq_)
                            {
                                bl_ = cm_ as CqlInterval<CqlQuantity>;
                            }
                            else
                            {
                                bl_ = null;
                            }
                        }
                    }
                }
                CqlInterval<CqlDateTime> bm_ = QICoreCommon_4_0_000.Instance.toInterval(context, bl_);
                CqlDateTime bn_ = context.Operators.Start(bm_);
                CqlBoolean bo_ = (CqlBoolean)(bn_ is not null);
                return bk_
                    /* CQL 'and' (120:21-120:123) */ && bo_;
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
            Code<MedicationRequest.MedicationRequestIntent> cw_ = ExclusionMed?.IntentElement;
            MedicationRequest.MedicationRequestIntent? cx_ = cw_?.Value;
            string cy_ = context.Operators.Convert<string>(cx_);
            CqlBoolean cz_ = context.Operators.Equal(cy_, "order");
            CqlBoolean da_ = cz_;
            return cv_
                /* CQL 'and' (121:9-122:43) */ && da_;
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
                DataType dw_ = ExclusionProcedure?.Performed;
                object dx_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dw_);
                bool dy_ = dx_ is CqlDateTime;
                if (dy_)
                {
                    df_ = dx_ as CqlDateTime;
                }
                else
                {
                    bool dz_ = dx_ is CqlQuantity;
                    if (dz_)
                    {
                        df_ = dx_ as CqlQuantity;
                    }
                    else
                    {
                        bool ea_ = dx_ is CqlInterval<CqlDateTime>;
                        if (ea_)
                        {
                            df_ = dx_ as CqlInterval<CqlDateTime>;
                        }
                        else
                        {
                            bool eb_ = dx_ is CqlInterval<CqlQuantity>;
                            if (eb_)
                            {
                                df_ = dx_ as CqlInterval<CqlQuantity>;
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
                DataType ec_ = FirstBladderCancerStaging?.Performed;
                object ed_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ec_);
                bool ee_ = ed_ is CqlDateTime;
                if (ee_)
                {
                    di_ = ed_ as CqlDateTime;
                }
                else
                {
                    bool ef_ = ed_ is CqlQuantity;
                    if (ef_)
                    {
                        di_ = ed_ as CqlQuantity;
                    }
                    else
                    {
                        bool eg_ = ed_ is CqlInterval<CqlDateTime>;
                        if (eg_)
                        {
                            di_ = ed_ as CqlInterval<CqlDateTime>;
                        }
                        else
                        {
                            bool eh_ = ed_ is CqlInterval<CqlQuantity>;
                            if (eh_)
                            {
                                di_ = ed_ as CqlInterval<CqlQuantity>;
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
                DataType ei_ = FirstBladderCancerStaging?.Performed;
                object ej_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ei_);
                bool ek_ = ej_ is CqlDateTime;
                if (ek_)
                {
                    dn_ = ej_ as CqlDateTime;
                }
                else
                {
                    bool el_ = ej_ is CqlQuantity;
                    if (el_)
                    {
                        dn_ = ej_ as CqlQuantity;
                    }
                    else
                    {
                        bool em_ = ej_ is CqlInterval<CqlDateTime>;
                        if (em_)
                        {
                            dn_ = ej_ as CqlInterval<CqlDateTime>;
                        }
                        else
                        {
                            bool en_ = ej_ is CqlInterval<CqlQuantity>;
                            if (en_)
                            {
                                dn_ = ej_ as CqlInterval<CqlQuantity>;
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
                object ds_;
                DataType eo_ = FirstBladderCancerStaging?.Performed;
                object ep_ = FHIRHelpers_4_4_000.Instance.ToValue(context, eo_);
                bool eq_ = ep_ is CqlDateTime;
                if (eq_)
                {
                    ds_ = ep_ as CqlDateTime;
                }
                else
                {
                    bool er_ = ep_ is CqlQuantity;
                    if (er_)
                    {
                        ds_ = ep_ as CqlQuantity;
                    }
                    else
                    {
                        bool es_ = ep_ is CqlInterval<CqlDateTime>;
                        if (es_)
                        {
                            ds_ = ep_ as CqlInterval<CqlDateTime>;
                        }
                        else
                        {
                            bool et_ = ep_ is CqlInterval<CqlQuantity>;
                            if (et_)
                            {
                                ds_ = ep_ as CqlInterval<CqlQuantity>;
                            }
                            else
                            {
                                ds_ = null;
                            }
                        }
                    }
                }
                CqlInterval<CqlDateTime> dt_ = QICoreCommon_4_0_000.Instance.toInterval(context, ds_);
                CqlDateTime du_ = context.Operators.Start(dt_);
                CqlBoolean dv_ = (CqlBoolean)(du_ is not null);
                return dr_
                    /* CQL 'and' (126:23-126:147) */ && dv_;
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
        IEnumerable<MedicationRequest> c_ = this.Immunosuppressive_Drugs(context);
        CqlBoolean d_ = context.Operators.Exists<MedicationRequest>(c_);
        CqlBoolean e_ = d_;
        IEnumerable<Procedure> f_ = this.Cystectomy_Done(context);
        CqlBoolean g_ = context.Operators.Exists<Procedure>(f_);
        CqlBoolean h_ = g_;
        return b_
            /* CQL 'or' (46:3-47:39) */ || e_
            /* CQL 'or' (46:3-48:31) */ || h_
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
                    FhirUri af_ = @this?.UrlElement;
                    string ag_ = FHIRHelpers_4_4_000.Instance.ToString(context, af_);
                    CqlBoolean ah_ = context.Operators.Equal(ag_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-recorded");
                    return ah_;
                }


                DataType m_(Extension @this) {
                    DataType ai_ = @this?.Value;
                    return ai_;
                }

                IEnumerable<DataType> n_ = context.Operators.WhereSelect<Extension, DataType>((IEnumerable<Extension>)(BCGNotGiven is DomainResource
                    ? (BCGNotGiven as DomainResource).Extension
                    : default), l_, m_);
                DataType o_ = context.Operators.SingletonFrom<DataType>(n_);
                FhirDateTime p_ = context.Operators.Convert<FhirDateTime>(o_);
                CqlDateTime q_ = context.Operators.Convert<CqlDateTime>(p_);
                object r_;
                DataType aj_ = FirstBladderCancerStaging?.Performed;
                object ak_ = FHIRHelpers_4_4_000.Instance.ToValue(context, aj_);
                bool al_ = ak_ is CqlDateTime;
                if (al_)
                {
                    r_ = ak_ as CqlDateTime;
                }
                else
                {
                    bool am_ = ak_ is CqlQuantity;
                    if (am_)
                    {
                        r_ = ak_ as CqlQuantity;
                    }
                    else
                    {
                        bool an_ = ak_ is CqlInterval<CqlDateTime>;
                        if (an_)
                        {
                            r_ = ak_ as CqlInterval<CqlDateTime>;
                        }
                        else
                        {
                            bool ao_ = ak_ is CqlInterval<CqlQuantity>;
                            if (ao_)
                            {
                                r_ = ak_ as CqlInterval<CqlQuantity>;
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
                DataType ap_ = FirstBladderCancerStaging?.Performed;
                object aq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ap_);
                bool ar_ = aq_ is CqlDateTime;
                if (ar_)
                {
                    u_ = aq_ as CqlDateTime;
                }
                else
                {
                    bool as_ = aq_ is CqlQuantity;
                    if (as_)
                    {
                        u_ = aq_ as CqlQuantity;
                    }
                    else
                    {
                        bool at_ = aq_ is CqlInterval<CqlDateTime>;
                        if (at_)
                        {
                            u_ = aq_ as CqlInterval<CqlDateTime>;
                        }
                        else
                        {
                            bool au_ = aq_ is CqlInterval<CqlQuantity>;
                            if (au_)
                            {
                                u_ = aq_ as CqlInterval<CqlQuantity>;
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
                object ab_;
                DataType av_ = FirstBladderCancerStaging?.Performed;
                object aw_ = FHIRHelpers_4_4_000.Instance.ToValue(context, av_);
                bool ax_ = aw_ is CqlDateTime;
                if (ax_)
                {
                    ab_ = aw_ as CqlDateTime;
                }
                else
                {
                    bool ay_ = aw_ is CqlQuantity;
                    if (ay_)
                    {
                        ab_ = aw_ as CqlQuantity;
                    }
                    else
                    {
                        bool az_ = aw_ is CqlInterval<CqlDateTime>;
                        if (az_)
                        {
                            ab_ = aw_ as CqlInterval<CqlDateTime>;
                        }
                        else
                        {
                            bool ba_ = aw_ is CqlInterval<CqlQuantity>;
                            if (ba_)
                            {
                                ab_ = aw_ as CqlInterval<CqlQuantity>;
                            }
                            else
                            {
                                ab_ = null;
                            }
                        }
                    }
                }
                CqlInterval<CqlDateTime> ac_ = QICoreCommon_4_0_000.Instance.toInterval(context, ab_);
                CqlDateTime ad_ = context.Operators.Start(ac_);
                CqlBoolean ae_ = (CqlBoolean)(ad_ is not null);
                return aa_
                    /* CQL 'and' (157:17-157:126) */ && ae_;
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
                CodeableConcept v_ = M?.Code;
                CqlConcept w_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, v_);
                CqlValueSet x_ = this.Bacillus_Calmette_Guerin_for_Urology_Care(context);
                CqlBoolean y_ = context.Operators.ConceptInValueSet(w_, x_);
                CqlBoolean z_ = y_;
                return u_
                    /* CQL 'and' */ && z_;
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
                DataType az_ = FirstBladderCancerStaging?.Performed;
                object ba_ = FHIRHelpers_4_4_000.Instance.ToValue(context, az_);
                bool bb_ = ba_ is CqlDateTime;
                if (bb_)
                {
                    ai_ = ba_ as CqlDateTime;
                }
                else
                {
                    bool bc_ = ba_ is CqlQuantity;
                    if (bc_)
                    {
                        ai_ = ba_ as CqlQuantity;
                    }
                    else
                    {
                        bool bd_ = ba_ is CqlInterval<CqlDateTime>;
                        if (bd_)
                        {
                            ai_ = ba_ as CqlInterval<CqlDateTime>;
                        }
                        else
                        {
                            bool be_ = ba_ is CqlInterval<CqlQuantity>;
                            if (be_)
                            {
                                ai_ = ba_ as CqlInterval<CqlQuantity>;
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
                DataType bf_ = FirstBladderCancerStaging?.Performed;
                object bg_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bf_);
                bool bh_ = bg_ is CqlDateTime;
                if (bh_)
                {
                    al_ = bg_ as CqlDateTime;
                }
                else
                {
                    bool bi_ = bg_ is CqlQuantity;
                    if (bi_)
                    {
                        al_ = bg_ as CqlQuantity;
                    }
                    else
                    {
                        bool bj_ = bg_ is CqlInterval<CqlDateTime>;
                        if (bj_)
                        {
                            al_ = bg_ as CqlInterval<CqlDateTime>;
                        }
                        else
                        {
                            bool bk_ = bg_ is CqlInterval<CqlQuantity>;
                            if (bk_)
                            {
                                al_ = bg_ as CqlInterval<CqlQuantity>;
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
                object as_;
                DataType bl_ = FirstBladderCancerStaging?.Performed;
                object bm_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bl_);
                bool bn_ = bm_ is CqlDateTime;
                if (bn_)
                {
                    as_ = bm_ as CqlDateTime;
                }
                else
                {
                    bool bo_ = bm_ is CqlQuantity;
                    if (bo_)
                    {
                        as_ = bm_ as CqlQuantity;
                    }
                    else
                    {
                        bool bp_ = bm_ is CqlInterval<CqlDateTime>;
                        if (bp_)
                        {
                            as_ = bm_ as CqlInterval<CqlDateTime>;
                        }
                        else
                        {
                            bool bq_ = bm_ is CqlInterval<CqlQuantity>;
                            if (bq_)
                            {
                                as_ = bm_ as CqlInterval<CqlQuantity>;
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
                CqlBoolean av_ = (CqlBoolean)(au_ is not null);
                CqlInterval<CqlDateTime> aw_ = this.Measurement_Period(context);
                CqlBoolean ax_ = context.Operators.In<CqlDateTime>(ah_, aw_, "day");
                CqlBoolean ay_ = ax_;
                return ar_
                    /* CQL 'and' (167:19-167:139) */ && av_
                    /* CQL 'and' (167:19-168:82) */ && ay_;
            }

            CqlBoolean ad_ = context.Operators.WhereAny<Procedure>((IEnumerable<Procedure>)ab_, ac_);
            return ad_;
        }

        IEnumerable<MedicationAdministration> h_ = context.Operators.Where<MedicationAdministration>(f_, g_);

        bool? i_(MedicationAdministration BCG) {
            Code<MedicationAdministration.MedicationAdministrationStatusCodes> br_ = BCG?.StatusElement;
            MedicationAdministration.MedicationAdministrationStatusCodes? bs_ = br_?.Value;
            string bt_ = context.Operators.Convert<string>(bs_);
            string[] bu_ = [
                "in-progress",
                "completed",
            ];
            CqlBoolean bv_ = context.Operators.In<string>(bt_, (IEnumerable<string>)bu_);
            return bv_;
        }

        IEnumerable<MedicationAdministration> j_ = context.Operators.Where<MedicationAdministration>(h_, i_);

        object k_(MedicationAdministration @this) {
            DataType bw_ = @this?.Effective;
            object bx_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bw_);
            CqlInterval<CqlDateTime> by_ = QICoreCommon_4_0_000.Instance.toInterval(context, bx_);
            CqlDateTime bz_ = context.Operators.Start(by_);
            return bz_;
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
        return a_ is not null;
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

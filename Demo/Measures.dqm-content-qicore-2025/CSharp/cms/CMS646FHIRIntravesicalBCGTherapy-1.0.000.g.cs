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
            if (j_ is null)
            {
                o_ = default;
            }
            else
            {
                CqlInterval<CqlDateTime> t_ = context.Operators.Interval(j_, j_, true, true);
                o_ = t_;
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
                bool? s_ = context.Operators.SameOrBefore(p_, r_, "day");
                return s_;
            }

            bool? m_ = context.Operators.WhereAny<Condition>(k_, l_);
            return m_;
        }

        IEnumerable<Procedure> e_ = context.Operators.Where<Procedure>(c_, d_);

        bool? f_(Procedure BladderCancerStaging) {
            Code<EventStatus> z_ = BladderCancerStaging?.StatusElement;
            EventStatus? aa_ = z_?.Value;
            string ab_ = context.Operators.Convert<string>(aa_);
            bool? ac_ = context.Operators.Equal(ab_, "completed");
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
                bool? p_ = context.Operators.OverlapsAfter(m_, o_, "day");
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
                bool? v_ = context.Operators.OverlapsAfter(s_, u_, "day");
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
            bool? ax_ = this.isVerified(context, ActiveTuberculosis);
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
                Id n_ = M?.IdElement;
                string o_ = n_?.Value;
                FhirString p_;
                DataType z_ = MR?.Medication;
                bool aa_ = z_ is ResourceReference;
                if (aa_)
                {
                    FhirString ab_ = (z_ as ResourceReference)?.ReferenceElement;
                    p_ = ab_;
                }
                else
                {
                    p_ = default;
                }
                string q_ = p_?.Value;
                IEnumerable<string> r_ = context.Operators.Split(q_, "/");
                string s_ = context.Operators.Last<string>(r_);
                bool? t_ = context.Operators.Equal(o_, s_);
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
            Procedure ac_ = this.First_Bladder_Cancer_Staging_Procedure(context);
            Procedure[] ad_ = [
                ac_,
            ];

            bool? ae_(Procedure FirstBladderCancerStaging) {
                List<Dosage> ag_ = ImmunosuppressiveDrugs?.DosageInstruction;

                bool? ah_(Dosage @this) {
                    Timing bj_ = @this?.Timing;
                    bool? bk_ = context.Operators.Not((bool?)(bj_ is null));
                    return bk_;
                }


                Timing ai_(Dosage @this) {
                    Timing bl_ = @this?.Timing;
                    return bl_;
                }

                IEnumerable<Timing> aj_ = context.Operators.WhereSelect<Dosage, Timing>((IEnumerable<Dosage>)ag_, ah_, ai_);

                CqlDateTime ak_(Timing dosageTiming) {
                    List<FhirDateTime> bm_ = dosageTiming?.EventElement;

                    string bn_(FhirDateTime @this) {
                        string bt_ = context.Operators.Convert<string>(@this);
                        return bt_;
                    }

                    IEnumerable<string> bo_ = context.Operators.Select<FhirDateTime, string>((IEnumerable<FhirDateTime>)bm_, bn_);

                    CqlDateTime bp_(string @string) {
                        CqlDateTime bu_ = context.Operators.ConvertStringToDateTime(@string);
                        return bu_;
                    }

                    IEnumerable<CqlDateTime> bq_ = context.Operators.Select<string, CqlDateTime>(bo_, bp_);
                    IEnumerable<CqlDateTime> br_ = context.Operators.ListSort<CqlDateTime>(bq_, System.ComponentModel.ListSortDirection.Ascending);
                    CqlDateTime bs_ = context.Operators.First<CqlDateTime>(br_);
                    return bs_;
                }

                IEnumerable<CqlDateTime> al_ = context.Operators.SelectDistinct<Timing, CqlDateTime>(aj_, ak_);
                IEnumerable<CqlDateTime> am_ = context.Operators.ListSort<CqlDateTime>(al_, System.ComponentModel.ListSortDirection.Ascending);
                CqlDateTime an_ = context.Operators.First<CqlDateTime>(am_);
                CqlInterval<CqlDateTime> ao_ = QICoreCommon_4_0_000.Instance.toInterval(context, an_);

                bool? ap_(Dosage @this) {
                    Timing bv_ = @this?.Timing;
                    bool? bw_ = context.Operators.Not((bool?)(bv_ is null));
                    return bw_;
                }


                Timing aq_(Dosage @this) {
                    Timing bx_ = @this?.Timing;
                    return bx_;
                }

                IEnumerable<Timing> ar_ = context.Operators.WhereSelect<Dosage, Timing>((IEnumerable<Dosage>)ag_, ap_, aq_);

                bool? as_(Timing @this) {
                    Timing.RepeatComponent by_ = @this?.Repeat;
                    bool? bz_ = context.Operators.Not((bool?)(by_ is null));
                    return bz_;
                }


                Timing.RepeatComponent at_(Timing @this) {
                    Timing.RepeatComponent ca_ = @this?.Repeat;
                    return ca_;
                }

                IEnumerable<Timing.RepeatComponent> au_ = context.Operators.WhereSelect<Timing, Timing.RepeatComponent>(ar_, as_, at_);

                bool? av_(Timing.RepeatComponent @this) {
                    DataType cb_ = @this?.Bounds;
                    object cc_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cb_);
                    bool? cd_ = context.Operators.Not((bool?)(cc_ is null));
                    return cd_;
                }


                object aw_(Timing.RepeatComponent @this) {
                    DataType ce_ = @this?.Bounds;
                    object cf_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ce_);
                    return cf_;
                }

                IEnumerable<object> ax_ = context.Operators.WhereSelect<Timing.RepeatComponent, object>(au_, av_, aw_);

                CqlInterval<CqlDateTime> ay_(object DoseTime) {
                    CqlInterval<CqlDateTime> cg_ = QICoreCommon_4_0_000.Instance.toInterval(context, DoseTime);
                    return cg_;
                }

                IEnumerable<CqlInterval<CqlDateTime>> az_ = context.Operators.SelectDistinct<object, CqlInterval<CqlDateTime>>(ax_, ay_);
                IEnumerable<CqlInterval<CqlDateTime>> ba_ = context.Operators.Collapse(az_, (string)default);

                object bb_(CqlInterval<CqlDateTime> @this) {
                    CqlDateTime ch_ = context.Operators.Start(@this);
                    return ch_;
                }

                IEnumerable<CqlInterval<CqlDateTime>> bc_ = context.Operators.SortBy<CqlInterval<CqlDateTime>>(ba_, bb_, System.ComponentModel.ListSortDirection.Ascending);
                CqlInterval<CqlDateTime> bd_ = context.Operators.First<CqlInterval<CqlDateTime>>(bc_);
                CqlDateTime be_ = context.Operators.Start(ao_ ?? bd_);
                object bf_;
                DataType ci_ = FirstBladderCancerStaging?.Performed;
                object cj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ci_);
                bool ck_ = cj_ is CqlDateTime;
                if (ck_)
                {
                    bf_ = cj_ as CqlDateTime;
                }
                else
                {
                    bool cl_ = cj_ is CqlQuantity;
                    if (cl_)
                    {
                        bf_ = cj_ as CqlQuantity;
                    }
                    else
                    {
                        bool cm_ = cj_ is CqlInterval<CqlDateTime>;
                        if (cm_)
                        {
                            bf_ = cj_ as CqlInterval<CqlDateTime>;
                        }
                        else
                        {
                            bool cn_ = cj_ is CqlInterval<CqlQuantity>;
                            if (cn_)
                            {
                                bf_ = cj_ as CqlInterval<CqlQuantity>;
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
                bool? bi_ = context.Operators.SameOrBefore(be_, bh_, "day");
                return bi_;
            }

            bool? af_ = context.Operators.WhereAny<Procedure>((IEnumerable<Procedure>)ad_, ae_);
            return af_;
        }

        IEnumerable<MedicationRequest> h_ = context.Operators.Where<MedicationRequest>(f_, g_);

        bool? i_(MedicationRequest ImmunosuppressiveDrugs) {
            Code<MedicationRequest.MedicationrequestStatus> co_ = ImmunosuppressiveDrugs?.StatusElement;
            MedicationRequest.MedicationrequestStatus? cp_ = co_?.Value;
            string cq_ = context.Operators.Convert<string>(cp_);
            string[] cr_ = [
                "active",
                "completed",
            ];
            bool? cs_ = context.Operators.In<string>(cq_, (IEnumerable<string>)cr_);
            Code<MedicationRequest.MedicationRequestIntent> ct_ = ImmunosuppressiveDrugs?.IntentElement;
            MedicationRequest.MedicationRequestIntent? cu_ = ct_?.Value;
            string cv_ = context.Operators.Convert<string>(cu_);
            bool? cw_ = context.Operators.Equal(cv_, "order");
            bool? cx_ = context.Operators.And(cs_, cw_);
            return cx_;
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
                    k_ = ad_ as CqlDateTime;
                }
                else
                {
                    bool af_ = ad_ is CqlQuantity;
                    if (af_)
                    {
                        k_ = ad_ as CqlQuantity;
                    }
                    else
                    {
                        bool ag_ = ad_ is CqlInterval<CqlDateTime>;
                        if (ag_)
                        {
                            k_ = ad_ as CqlInterval<CqlDateTime>;
                        }
                        else
                        {
                            bool ah_ = ad_ is CqlInterval<CqlQuantity>;
                            if (ah_)
                            {
                                k_ = ad_ as CqlInterval<CqlQuantity>;
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
                DataType ai_ = FirstBladderCancerStaging?.Performed;
                object aj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ai_);
                bool ak_ = aj_ is CqlDateTime;
                if (ak_)
                {
                    n_ = aj_ as CqlDateTime;
                }
                else
                {
                    bool al_ = aj_ is CqlQuantity;
                    if (al_)
                    {
                        n_ = aj_ as CqlQuantity;
                    }
                    else
                    {
                        bool am_ = aj_ is CqlInterval<CqlDateTime>;
                        if (am_)
                        {
                            n_ = aj_ as CqlInterval<CqlDateTime>;
                        }
                        else
                        {
                            bool an_ = aj_ is CqlInterval<CqlQuantity>;
                            if (an_)
                            {
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
                CqlDateTime p_ = context.Operators.Start(o_);
                CqlQuantity q_ = context.Operators.Quantity(6m, "months");
                CqlDateTime r_ = context.Operators.Subtract(p_, q_);
                object s_;
                DataType ao_ = FirstBladderCancerStaging?.Performed;
                object ap_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ao_);
                bool aq_ = ap_ is CqlDateTime;
                if (aq_)
                {
                    s_ = ap_ as CqlDateTime;
                }
                else
                {
                    bool ar_ = ap_ is CqlQuantity;
                    if (ar_)
                    {
                        s_ = ap_ as CqlQuantity;
                    }
                    else
                    {
                        bool as_ = ap_ is CqlInterval<CqlDateTime>;
                        if (as_)
                        {
                            s_ = ap_ as CqlInterval<CqlDateTime>;
                        }
                        else
                        {
                            bool at_ = ap_ is CqlInterval<CqlQuantity>;
                            if (at_)
                            {
                                s_ = ap_ as CqlInterval<CqlQuantity>;
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
                DataType au_ = FirstBladderCancerStaging?.Performed;
                object av_ = FHIRHelpers_4_4_000.Instance.ToValue(context, au_);
                bool aw_ = av_ is CqlDateTime;
                if (aw_)
                {
                    x_ = av_ as CqlDateTime;
                }
                else
                {
                    bool ax_ = av_ is CqlQuantity;
                    if (ax_)
                    {
                        x_ = av_ as CqlQuantity;
                    }
                    else
                    {
                        bool ay_ = av_ is CqlInterval<CqlDateTime>;
                        if (ay_)
                        {
                            x_ = av_ as CqlInterval<CqlDateTime>;
                        }
                        else
                        {
                            bool az_ = av_ is CqlInterval<CqlQuantity>;
                            if (az_)
                            {
                                x_ = av_ as CqlInterval<CqlQuantity>;
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
            Code<EventStatus> ba_ = Cystectomy?.StatusElement;
            EventStatus? bb_ = ba_?.Value;
            string bc_ = context.Operators.Convert<string>(bb_);
            bool? bd_ = context.Operators.Equal(bc_, "completed");
            return bd_;
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
                bool? ab_ = context.Operators.SameOrBefore(x_, aa_, "day");
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
                bool? aj_ = context.Operators.SameOrBefore(af_, ai_, "day");
                bool? ak_ = context.Operators.Or(ab_, aj_);
                return ak_;
            }

            bool? v_ = context.Operators.WhereAny<Procedure>((IEnumerable<Procedure>)t_, u_);
            return v_;
        }

        IEnumerable<Condition> p_ = context.Operators.Where<Condition>(n_, o_);

        bool? q_(Condition ExclusionDiagnosis) {
            bool? ax_ = this.isVerified(context, ExclusionDiagnosis);
            return ax_;
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
                FhirString y_;
                DataType ai_ = MR?.Medication;
                bool aj_ = ai_ is ResourceReference;
                if (aj_)
                {
                    FhirString ak_ = (ai_ as ResourceReference)?.ReferenceElement;
                    y_ = ak_;
                }
                else
                {
                    y_ = default;
                }
                string z_ = y_?.Value;
                IEnumerable<string> aa_ = context.Operators.Split(z_, "/");
                string ab_ = context.Operators.Last<string>(aa_);
                bool? ac_ = context.Operators.Equal(x_, ab_);
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
            Procedure al_ = this.First_Bladder_Cancer_Staging_Procedure(context);
            Procedure[] am_ = [
                al_,
            ];

            bool? an_(Procedure FirstBladderCancerStaging) {
                List<Dosage> ap_ = ExclusionMed?.DosageInstruction;

                bool? aq_(Dosage @this) {
                    Timing bv_ = @this?.Timing;
                    bool? bw_ = context.Operators.Not((bool?)(bv_ is null));
                    return bw_;
                }


                Timing ar_(Dosage @this) {
                    Timing bx_ = @this?.Timing;
                    return bx_;
                }

                IEnumerable<Timing> as_ = context.Operators.WhereSelect<Dosage, Timing>((IEnumerable<Dosage>)ap_, aq_, ar_);

                bool? at_(Timing @this) {
                    Timing.RepeatComponent by_ = @this?.Repeat;
                    bool? bz_ = context.Operators.Not((bool?)(by_ is null));
                    return bz_;
                }


                Timing.RepeatComponent au_(Timing @this) {
                    Timing.RepeatComponent ca_ = @this?.Repeat;
                    return ca_;
                }

                IEnumerable<Timing.RepeatComponent> av_ = context.Operators.WhereSelect<Timing, Timing.RepeatComponent>(as_, at_, au_);

                bool? aw_(Timing.RepeatComponent @this) {
                    DataType cb_ = @this?.Bounds;
                    object cc_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cb_);
                    bool? cd_ = context.Operators.Not((bool?)(cc_ is null));
                    return cd_;
                }


                object ax_(Timing.RepeatComponent @this) {
                    DataType ce_ = @this?.Bounds;
                    object cf_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ce_);
                    return cf_;
                }

                IEnumerable<object> ay_ = context.Operators.WhereSelect<Timing.RepeatComponent, object>(av_, aw_, ax_);

                CqlInterval<CqlDateTime> az_(object DoseTime) {
                    CqlInterval<CqlDateTime> cg_ = QICoreCommon_4_0_000.Instance.toInterval(context, DoseTime);
                    return cg_;
                }

                IEnumerable<CqlInterval<CqlDateTime>> ba_ = context.Operators.SelectDistinct<object, CqlInterval<CqlDateTime>>(ay_, az_);
                IEnumerable<CqlInterval<CqlDateTime>> bb_ = context.Operators.Collapse(ba_, (string)default);

                object bc_(CqlInterval<CqlDateTime> @this) {
                    CqlDateTime ch_ = context.Operators.Start(@this);
                    return ch_;
                }

                IEnumerable<CqlInterval<CqlDateTime>> bd_ = context.Operators.SortBy<CqlInterval<CqlDateTime>>(bb_, bc_, System.ComponentModel.ListSortDirection.Ascending);
                CqlInterval<CqlDateTime> be_ = context.Operators.First<CqlInterval<CqlDateTime>>(bd_);
                CqlDateTime bf_ = context.Operators.Start(be_);
                object bg_;
                DataType ci_ = FirstBladderCancerStaging?.Performed;
                object cj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ci_);
                bool ck_ = cj_ is CqlDateTime;
                if (ck_)
                {
                    bg_ = cj_ as CqlDateTime;
                }
                else
                {
                    bool cl_ = cj_ is CqlQuantity;
                    if (cl_)
                    {
                        bg_ = cj_ as CqlQuantity;
                    }
                    else
                    {
                        bool cm_ = cj_ is CqlInterval<CqlDateTime>;
                        if (cm_)
                        {
                            bg_ = cj_ as CqlInterval<CqlDateTime>;
                        }
                        else
                        {
                            bool cn_ = cj_ is CqlInterval<CqlQuantity>;
                            if (cn_)
                            {
                                bg_ = cj_ as CqlInterval<CqlQuantity>;
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
                CqlQuantity bj_ = context.Operators.Quantity(6m, "months");
                CqlDateTime bk_ = context.Operators.Subtract(bi_, bj_);
                object bl_;
                DataType co_ = FirstBladderCancerStaging?.Performed;
                object cp_ = FHIRHelpers_4_4_000.Instance.ToValue(context, co_);
                bool cq_ = cp_ is CqlDateTime;
                if (cq_)
                {
                    bl_ = cp_ as CqlDateTime;
                }
                else
                {
                    bool cr_ = cp_ is CqlQuantity;
                    if (cr_)
                    {
                        bl_ = cp_ as CqlQuantity;
                    }
                    else
                    {
                        bool cs_ = cp_ is CqlInterval<CqlDateTime>;
                        if (cs_)
                        {
                            bl_ = cp_ as CqlInterval<CqlDateTime>;
                        }
                        else
                        {
                            bool ct_ = cp_ is CqlInterval<CqlQuantity>;
                            if (ct_)
                            {
                                bl_ = cp_ as CqlInterval<CqlQuantity>;
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
                CqlInterval<CqlDateTime> bo_ = context.Operators.Interval(bk_, bn_, true, false);
                bool? bp_ = context.Operators.In<CqlDateTime>(bf_, bo_, (string)default);
                object bq_;
                DataType cu_ = FirstBladderCancerStaging?.Performed;
                object cv_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cu_);
                bool cw_ = cv_ is CqlDateTime;
                if (cw_)
                {
                    bq_ = cv_ as CqlDateTime;
                }
                else
                {
                    bool cx_ = cv_ is CqlQuantity;
                    if (cx_)
                    {
                        bq_ = cv_ as CqlQuantity;
                    }
                    else
                    {
                        bool cy_ = cv_ is CqlInterval<CqlDateTime>;
                        if (cy_)
                        {
                            bq_ = cv_ as CqlInterval<CqlDateTime>;
                        }
                        else
                        {
                            bool cz_ = cv_ is CqlInterval<CqlQuantity>;
                            if (cz_)
                            {
                                bq_ = cv_ as CqlInterval<CqlQuantity>;
                            }
                            else
                            {
                                bq_ = null;
                            }
                        }
                    }
                }
                CqlInterval<CqlDateTime> br_ = QICoreCommon_4_0_000.Instance.toInterval(context, bq_);
                CqlDateTime bs_ = context.Operators.Start(br_);
                bool? bt_ = context.Operators.Not((bool?)(bs_ is null));
                bool? bu_ = context.Operators.And(bp_, bt_);
                return bu_;
            }

            bool? ao_ = context.Operators.WhereAny<Procedure>((IEnumerable<Procedure>)am_, an_);
            return ao_;
        }

        IEnumerable<MedicationRequest> h_ = context.Operators.Where<MedicationRequest>(f_, g_);

        bool? i_(MedicationRequest ExclusionMed) {
            Code<MedicationRequest.MedicationrequestStatus> da_ = ExclusionMed?.StatusElement;
            MedicationRequest.MedicationrequestStatus? db_ = da_?.Value;
            string dc_ = context.Operators.Convert<string>(db_);
            string[] dd_ = [
                "active",
                "completed",
            ];
            bool? de_ = context.Operators.In<string>(dc_, (IEnumerable<string>)dd_);
            Code<MedicationRequest.MedicationRequestIntent> df_ = ExclusionMed?.IntentElement;
            MedicationRequest.MedicationRequestIntent? dg_ = df_?.Value;
            string dh_ = context.Operators.Convert<string>(dg_);
            bool? di_ = context.Operators.Equal(dh_, "order");
            bool? dj_ = context.Operators.And(de_, di_);
            return dj_;
        }

        IEnumerable<MedicationRequest> j_ = context.Operators.Where<MedicationRequest>(h_, i_);
        CqlCode k_ = this.Combined_radiotherapy__procedure_(context);
        IEnumerable<CqlCode> l_ = context.Operators.ToList<CqlCode>(k_);
        IEnumerable<Procedure> m_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, default, l_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));

        bool? n_(Procedure ExclusionProcedure) {
            Procedure dk_ = this.First_Bladder_Cancer_Staging_Procedure(context);
            Procedure[] dl_ = [
                dk_,
            ];

            bool? dm_(Procedure FirstBladderCancerStaging) {
                object do_;
                DataType eg_ = ExclusionProcedure?.Performed;
                object eh_ = FHIRHelpers_4_4_000.Instance.ToValue(context, eg_);
                bool ei_ = eh_ is CqlDateTime;
                if (ei_)
                {
                    do_ = eh_ as CqlDateTime;
                }
                else
                {
                    bool ej_ = eh_ is CqlQuantity;
                    if (ej_)
                    {
                        do_ = eh_ as CqlQuantity;
                    }
                    else
                    {
                        bool ek_ = eh_ is CqlInterval<CqlDateTime>;
                        if (ek_)
                        {
                            do_ = eh_ as CqlInterval<CqlDateTime>;
                        }
                        else
                        {
                            bool el_ = eh_ is CqlInterval<CqlQuantity>;
                            if (el_)
                            {
                                do_ = eh_ as CqlInterval<CqlQuantity>;
                            }
                            else
                            {
                                do_ = null;
                            }
                        }
                    }
                }
                CqlInterval<CqlDateTime> dp_ = QICoreCommon_4_0_000.Instance.toInterval(context, do_);
                CqlDateTime dq_ = context.Operators.Start(dp_);
                object dr_;
                DataType em_ = FirstBladderCancerStaging?.Performed;
                object en_ = FHIRHelpers_4_4_000.Instance.ToValue(context, em_);
                bool eo_ = en_ is CqlDateTime;
                if (eo_)
                {
                    dr_ = en_ as CqlDateTime;
                }
                else
                {
                    bool ep_ = en_ is CqlQuantity;
                    if (ep_)
                    {
                        dr_ = en_ as CqlQuantity;
                    }
                    else
                    {
                        bool eq_ = en_ is CqlInterval<CqlDateTime>;
                        if (eq_)
                        {
                            dr_ = en_ as CqlInterval<CqlDateTime>;
                        }
                        else
                        {
                            bool er_ = en_ is CqlInterval<CqlQuantity>;
                            if (er_)
                            {
                                dr_ = en_ as CqlInterval<CqlQuantity>;
                            }
                            else
                            {
                                dr_ = null;
                            }
                        }
                    }
                }
                CqlInterval<CqlDateTime> ds_ = QICoreCommon_4_0_000.Instance.toInterval(context, dr_);
                CqlDateTime dt_ = context.Operators.Start(ds_);
                CqlQuantity du_ = context.Operators.Quantity(6m, "months");
                CqlDateTime dv_ = context.Operators.Subtract(dt_, du_);
                object dw_;
                DataType es_ = FirstBladderCancerStaging?.Performed;
                object et_ = FHIRHelpers_4_4_000.Instance.ToValue(context, es_);
                bool eu_ = et_ is CqlDateTime;
                if (eu_)
                {
                    dw_ = et_ as CqlDateTime;
                }
                else
                {
                    bool ev_ = et_ is CqlQuantity;
                    if (ev_)
                    {
                        dw_ = et_ as CqlQuantity;
                    }
                    else
                    {
                        bool ew_ = et_ is CqlInterval<CqlDateTime>;
                        if (ew_)
                        {
                            dw_ = et_ as CqlInterval<CqlDateTime>;
                        }
                        else
                        {
                            bool ex_ = et_ is CqlInterval<CqlQuantity>;
                            if (ex_)
                            {
                                dw_ = et_ as CqlInterval<CqlQuantity>;
                            }
                            else
                            {
                                dw_ = null;
                            }
                        }
                    }
                }
                CqlInterval<CqlDateTime> dx_ = QICoreCommon_4_0_000.Instance.toInterval(context, dw_);
                CqlDateTime dy_ = context.Operators.Start(dx_);
                CqlInterval<CqlDateTime> dz_ = context.Operators.Interval(dv_, dy_, true, false);
                bool? ea_ = context.Operators.In<CqlDateTime>(dq_, dz_, (string)default);
                object eb_;
                DataType ey_ = FirstBladderCancerStaging?.Performed;
                object ez_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ey_);
                bool fa_ = ez_ is CqlDateTime;
                if (fa_)
                {
                    eb_ = ez_ as CqlDateTime;
                }
                else
                {
                    bool fb_ = ez_ is CqlQuantity;
                    if (fb_)
                    {
                        eb_ = ez_ as CqlQuantity;
                    }
                    else
                    {
                        bool fc_ = ez_ is CqlInterval<CqlDateTime>;
                        if (fc_)
                        {
                            eb_ = ez_ as CqlInterval<CqlDateTime>;
                        }
                        else
                        {
                            bool fd_ = ez_ is CqlInterval<CqlQuantity>;
                            if (fd_)
                            {
                                eb_ = ez_ as CqlInterval<CqlQuantity>;
                            }
                            else
                            {
                                eb_ = null;
                            }
                        }
                    }
                }
                CqlInterval<CqlDateTime> ec_ = QICoreCommon_4_0_000.Instance.toInterval(context, eb_);
                CqlDateTime ed_ = context.Operators.Start(ec_);
                bool? ee_ = context.Operators.Not((bool?)(ed_ is null));
                bool? ef_ = context.Operators.And(ea_, ee_);
                return ef_;
            }

            bool? dn_ = context.Operators.WhereAny<Procedure>((IEnumerable<Procedure>)dl_, dm_);
            return dn_;
        }

        IEnumerable<Procedure> o_ = context.Operators.Where<Procedure>(m_, n_);

        bool? p_(Procedure ExclusionProcedure) {
            Code<EventStatus> fe_ = ExclusionProcedure?.StatusElement;
            EventStatus? ff_ = fe_?.Value;
            string fg_ = context.Operators.Convert<string>(ff_);
            string[] fh_ = [
                "completed",
                "in-progress",
            ];
            bool? fi_ = context.Operators.In<string>(fg_, (IEnumerable<string>)fh_);
            return fi_;
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
                    FhirUri ag_ = @this?.UrlElement;
                    string ah_ = FHIRHelpers_4_4_000.Instance.ToString(context, ag_);
                    bool? ai_ = context.Operators.Equal(ah_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-recorded");
                    return ai_;
                }


                object n_(Extension @this) {
                    DataType aj_ = @this?.Value;
                    bool ak_ = aj_ is Uuid;
                    if (ak_)
                    {
                        string al_ = (aj_ as Uuid)?.Value;
                        return al_;
                    }
                    else
                    {
                        bool am_ = aj_ is Oid;
                        if (am_)
                        {
                            string an_ = (aj_ as Oid)?.Value;
                            return an_;
                        }
                        else
                        {
                            bool ao_ = aj_ is Markdown;
                            if (ao_)
                            {
                                string ap_ = (aj_ as Markdown)?.Value;
                                return ap_;
                            }
                            else
                            {
                                bool aq_ = aj_ is Integer;
                                if (aq_)
                                {
                                    int? ar_ = (aj_ as Integer)?.Value;
                                    return ar_;
                                }
                                else
                                {
                                    bool as_ = aj_ is Instant;
                                    if (as_)
                                    {
                                        DateTimeOffset? at_ = (aj_ as Instant)?.Value;
                                        return at_;
                                    }
                                    else
                                    {
                                        bool au_ = aj_ is Id;
                                        if (au_)
                                        {
                                            string av_ = (aj_ as Id)?.Value;
                                            return av_;
                                        }
                                        else
                                        {
                                            bool aw_ = aj_ is Duration;
                                            if (aw_)
                                            {
                                                FhirDecimal ax_ = (aj_ as Duration)?.ValueElement;
                                                return ax_;
                                            }
                                            else
                                            {
                                                bool ay_ = aj_ is Distance;
                                                if (ay_)
                                                {
                                                    FhirDecimal az_ = (aj_ as Distance)?.ValueElement;
                                                    return az_;
                                                }
                                                else
                                                {
                                                    bool ba_ = aj_ is FhirDecimal;
                                                    if (ba_)
                                                    {
                                                        decimal? bb_ = (aj_ as FhirDecimal)?.Value;
                                                        return bb_;
                                                    }
                                                    else
                                                    {
                                                        bool bc_ = aj_ is Date;
                                                        if (bc_)
                                                        {
                                                            string bd_ = (aj_ as Date)?.Value;
                                                            return bd_;
                                                        }
                                                        else
                                                        {
                                                            bool be_ = aj_ is Count;
                                                            if (be_)
                                                            {
                                                                FhirDecimal bf_ = (aj_ as Count)?.ValueElement;
                                                                return bf_;
                                                            }
                                                            else
                                                            {
                                                                bool bg_ = aj_ is FhirDateTime;
                                                                if (bg_)
                                                                {
                                                                    string bh_ = context.Operators.Convert<string>(aj_ as FhirDateTime);
                                                                    return bh_;
                                                                }
                                                                else
                                                                {
                                                                    bool bi_ = aj_ is Time;
                                                                    if (bi_)
                                                                    {
                                                                        string bj_ = (aj_ as Time)?.Value;
                                                                        return bj_;
                                                                    }
                                                                    else
                                                                    {
                                                                        bool bk_ = aj_ is Age;
                                                                        if (bk_)
                                                                        {
                                                                            FhirDecimal bl_ = (aj_ as Age)?.ValueElement;
                                                                            return bl_;
                                                                        }
                                                                        else
                                                                        {
                                                                            bool bm_ = aj_ is FhirUrl;
                                                                            if (bm_)
                                                                            {
                                                                                string bn_ = (aj_ as FhirUrl)?.Value;
                                                                                return bn_;
                                                                            }
                                                                            else
                                                                            {
                                                                                bool bo_ = aj_ is FhirUri;
                                                                                if (bo_)
                                                                                {
                                                                                    string bp_ = (aj_ as FhirUri)?.Value;
                                                                                    return bp_;
                                                                                }
                                                                                else
                                                                                {
                                                                                    bool bq_ = aj_ is Base64Binary;
                                                                                    if (bq_)
                                                                                    {
                                                                                        byte[] br_ = (aj_ as Base64Binary)?.Value;
                                                                                        return br_;
                                                                                    }
                                                                                    else
                                                                                    {
                                                                                        bool bs_ = aj_ is FhirBoolean;
                                                                                        if (bs_)
                                                                                        {
                                                                                            bool? bt_ = (aj_ as FhirBoolean)?.Value;
                                                                                            return bt_;
                                                                                        }
                                                                                        else
                                                                                        {
                                                                                            bool bu_ = aj_ is FhirString;
                                                                                            if (bu_)
                                                                                            {
                                                                                                string bv_ = (aj_ as FhirString)?.Value;
                                                                                                return bv_;
                                                                                            }
                                                                                            else
                                                                                            {
                                                                                                bool bw_ = aj_ is PositiveInt;
                                                                                                if (bw_)
                                                                                                {
                                                                                                    int? bx_ = (aj_ as PositiveInt)?.Value;
                                                                                                    return bx_;
                                                                                                }
                                                                                                else
                                                                                                {
                                                                                                    bool by_ = aj_ is Code;
                                                                                                    if (by_)
                                                                                                    {
                                                                                                        string bz_ = (aj_ as Code)?.Value;
                                                                                                        return bz_;
                                                                                                    }
                                                                                                    else
                                                                                                    {
                                                                                                        bool ca_ = aj_ is UnsignedInt;
                                                                                                        if (ca_)
                                                                                                        {
                                                                                                            int? cb_ = (aj_ as UnsignedInt)?.Value;
                                                                                                            return cb_;
                                                                                                        }
                                                                                                        else
                                                                                                        {
                                                                                                            bool cc_ = aj_ is Canonical;
                                                                                                            if (cc_)
                                                                                                            {
                                                                                                                string cd_ = (aj_ as Canonical)?.Value;
                                                                                                                return cd_;
                                                                                                            }
                                                                                                            else
                                                                                                            {
                                                                                                                bool ce_ = aj_ is Quantity;
                                                                                                                if (ce_)
                                                                                                                {
                                                                                                                    FhirDecimal cf_ = (aj_ as Quantity)?.ValueElement;
                                                                                                                    return cf_;
                                                                                                                }
                                                                                                                else
                                                                                                                {
                                                                                                                    bool cg_ = aj_ is Identifier;
                                                                                                                    if (cg_)
                                                                                                                    {
                                                                                                                        FhirString ch_ = (aj_ as Identifier)?.ValueElement;
                                                                                                                        return ch_;
                                                                                                                    }
                                                                                                                    else
                                                                                                                    {
                                                                                                                        bool ci_ = aj_ is Money;
                                                                                                                        if (ci_)
                                                                                                                        {
                                                                                                                            FhirDecimal cj_ = (aj_ as Money)?.ValueElement;
                                                                                                                            return cj_;
                                                                                                                        }
                                                                                                                        else
                                                                                                                        {
                                                                                                                            bool ck_ = aj_ is UsageContext;
                                                                                                                            if (ck_)
                                                                                                                            {
                                                                                                                                DataType cl_ = (aj_ as UsageContext)?.Value;
                                                                                                                                return cl_;
                                                                                                                            }
                                                                                                                            else
                                                                                                                            {
                                                                                                                                bool cm_ = aj_ is ContactPoint;
                                                                                                                                if (cm_)
                                                                                                                                {
                                                                                                                                    FhirString cn_ = (aj_ as ContactPoint)?.ValueElement;
                                                                                                                                    return cn_;
                                                                                                                                }
                                                                                                                                else
                                                                                                                                {
                                                                                                                                    return null;
                                                                                                                                }
                                                                                                                            }
                                                                                                                        }
                                                                                                                    }
                                                                                                                }
                                                                                                            }
                                                                                                        }
                                                                                                    }
                                                                                                }
                                                                                            }
                                                                                        }
                                                                                    }
                                                                                }
                                                                            }
                                                                        }
                                                                    }
                                                                }
                                                            }
                                                        }
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }

                IEnumerable<object> o_ = context.Operators.WhereSelect<Extension, object>((IEnumerable<Extension>)l_, m_, n_);
                object p_ = context.Operators.SingletonFrom<object>(o_);
                CqlDateTime q_ = context.Operators.Convert<CqlDateTime>((FhirDateTime)p_);
                object r_;
                DataType co_ = FirstBladderCancerStaging?.Performed;
                object cp_ = FHIRHelpers_4_4_000.Instance.ToValue(context, co_);
                bool cq_ = cp_ is CqlDateTime;
                if (cq_)
                {
                    r_ = cp_ as CqlDateTime;
                }
                else
                {
                    bool cr_ = cp_ is CqlQuantity;
                    if (cr_)
                    {
                        r_ = cp_ as CqlQuantity;
                    }
                    else
                    {
                        bool cs_ = cp_ is CqlInterval<CqlDateTime>;
                        if (cs_)
                        {
                            r_ = cp_ as CqlInterval<CqlDateTime>;
                        }
                        else
                        {
                            bool ct_ = cp_ is CqlInterval<CqlQuantity>;
                            if (ct_)
                            {
                                r_ = cp_ as CqlInterval<CqlQuantity>;
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
                DataType cu_ = FirstBladderCancerStaging?.Performed;
                object cv_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cu_);
                bool cw_ = cv_ is CqlDateTime;
                if (cw_)
                {
                    u_ = cv_ as CqlDateTime;
                }
                else
                {
                    bool cx_ = cv_ is CqlQuantity;
                    if (cx_)
                    {
                        u_ = cv_ as CqlQuantity;
                    }
                    else
                    {
                        bool cy_ = cv_ is CqlInterval<CqlDateTime>;
                        if (cy_)
                        {
                            u_ = cv_ as CqlInterval<CqlDateTime>;
                        }
                        else
                        {
                            bool cz_ = cv_ is CqlInterval<CqlQuantity>;
                            if (cz_)
                            {
                                u_ = cv_ as CqlInterval<CqlQuantity>;
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
                object ab_;
                DataType da_ = FirstBladderCancerStaging?.Performed;
                object db_ = FHIRHelpers_4_4_000.Instance.ToValue(context, da_);
                bool dc_ = db_ is CqlDateTime;
                if (dc_)
                {
                    ab_ = db_ as CqlDateTime;
                }
                else
                {
                    bool dd_ = db_ is CqlQuantity;
                    if (dd_)
                    {
                        ab_ = db_ as CqlQuantity;
                    }
                    else
                    {
                        bool de_ = db_ is CqlInterval<CqlDateTime>;
                        if (de_)
                        {
                            ab_ = db_ as CqlInterval<CqlDateTime>;
                        }
                        else
                        {
                            bool df_ = db_ is CqlInterval<CqlQuantity>;
                            if (df_)
                            {
                                ab_ = db_ as CqlInterval<CqlQuantity>;
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
                bool? ae_ = context.Operators.Not((bool?)(ad_ is null));
                bool? af_ = context.Operators.And(aa_, ae_);
                return af_;
            }

            bool? k_ = context.Operators.WhereAny<Procedure>((IEnumerable<Procedure>)i_, j_);
            return k_;
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
                Id q_ = M?.IdElement;
                string r_ = q_?.Value;
                FhirString s_;
                DataType ac_ = MR?.Medication;
                bool ad_ = ac_ is ResourceReference;
                if (ad_)
                {
                    FhirString ae_ = (ac_ as ResourceReference)?.ReferenceElement;
                    s_ = ae_;
                }
                else
                {
                    s_ = default;
                }
                string t_ = s_?.Value;
                IEnumerable<string> u_ = context.Operators.Split(t_, "/");
                string v_ = context.Operators.Last<string>(u_);
                bool? w_ = context.Operators.Equal(r_, v_);
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
            Procedure af_ = this.First_Bladder_Cancer_Staging_Procedure(context);
            Procedure[] ag_ = [
                af_,
            ];

            bool? ah_(Procedure FirstBladderCancerStaging) {
                DataType aj_ = BCG?.Effective;
                object ak_ = FHIRHelpers_4_4_000.Instance.ToValue(context, aj_);
                CqlInterval<CqlDateTime> al_ = QICoreCommon_4_0_000.Instance.toInterval(context, ak_);
                CqlDateTime am_ = context.Operators.Start(al_);
                object an_;
                DataType bf_ = FirstBladderCancerStaging?.Performed;
                object bg_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bf_);
                bool bh_ = bg_ is CqlDateTime;
                if (bh_)
                {
                    an_ = bg_ as CqlDateTime;
                }
                else
                {
                    bool bi_ = bg_ is CqlQuantity;
                    if (bi_)
                    {
                        an_ = bg_ as CqlQuantity;
                    }
                    else
                    {
                        bool bj_ = bg_ is CqlInterval<CqlDateTime>;
                        if (bj_)
                        {
                            an_ = bg_ as CqlInterval<CqlDateTime>;
                        }
                        else
                        {
                            bool bk_ = bg_ is CqlInterval<CqlQuantity>;
                            if (bk_)
                            {
                                an_ = bg_ as CqlInterval<CqlQuantity>;
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
                object aq_;
                DataType bl_ = FirstBladderCancerStaging?.Performed;
                object bm_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bl_);
                bool bn_ = bm_ is CqlDateTime;
                if (bn_)
                {
                    aq_ = bm_ as CqlDateTime;
                }
                else
                {
                    bool bo_ = bm_ is CqlQuantity;
                    if (bo_)
                    {
                        aq_ = bm_ as CqlQuantity;
                    }
                    else
                    {
                        bool bp_ = bm_ is CqlInterval<CqlDateTime>;
                        if (bp_)
                        {
                            aq_ = bm_ as CqlInterval<CqlDateTime>;
                        }
                        else
                        {
                            bool bq_ = bm_ is CqlInterval<CqlQuantity>;
                            if (bq_)
                            {
                                aq_ = bm_ as CqlInterval<CqlQuantity>;
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
                CqlQuantity at_ = context.Operators.Quantity(6m, "months");
                CqlDateTime au_ = context.Operators.Add(as_, at_);
                CqlInterval<CqlDateTime> av_ = context.Operators.Interval(ap_, au_, false, true);
                bool? aw_ = context.Operators.In<CqlDateTime>(am_, av_, "day");
                object ax_;
                DataType br_ = FirstBladderCancerStaging?.Performed;
                object bs_ = FHIRHelpers_4_4_000.Instance.ToValue(context, br_);
                bool bt_ = bs_ is CqlDateTime;
                if (bt_)
                {
                    ax_ = bs_ as CqlDateTime;
                }
                else
                {
                    bool bu_ = bs_ is CqlQuantity;
                    if (bu_)
                    {
                        ax_ = bs_ as CqlQuantity;
                    }
                    else
                    {
                        bool bv_ = bs_ is CqlInterval<CqlDateTime>;
                        if (bv_)
                        {
                            ax_ = bs_ as CqlInterval<CqlDateTime>;
                        }
                        else
                        {
                            bool bw_ = bs_ is CqlInterval<CqlQuantity>;
                            if (bw_)
                            {
                                ax_ = bs_ as CqlInterval<CqlQuantity>;
                            }
                            else
                            {
                                ax_ = null;
                            }
                        }
                    }
                }
                CqlInterval<CqlDateTime> ay_ = QICoreCommon_4_0_000.Instance.toInterval(context, ax_);
                CqlDateTime az_ = context.Operators.Start(ay_);
                bool? ba_ = context.Operators.Not((bool?)(az_ is null));
                bool? bb_ = context.Operators.And(aw_, ba_);
                CqlInterval<CqlDateTime> bc_ = this.Measurement_Period(context);
                bool? bd_ = context.Operators.In<CqlDateTime>(am_, bc_, "day");
                bool? be_ = context.Operators.And(bb_, bd_);
                return be_;
            }

            bool? ai_ = context.Operators.WhereAny<Procedure>((IEnumerable<Procedure>)ag_, ah_);
            return ai_;
        }

        IEnumerable<MedicationAdministration> h_ = context.Operators.Where<MedicationAdministration>(f_, g_);

        bool? i_(MedicationAdministration BCG) {
            Code<MedicationAdministration.MedicationAdministrationStatusCodes> bx_ = BCG?.StatusElement;
            MedicationAdministration.MedicationAdministrationStatusCodes? by_ = bx_?.Value;
            string bz_ = context.Operators.Convert<string>(by_);
            string[] ca_ = [
                "in-progress",
                "completed",
            ];
            bool? cb_ = context.Operators.In<string>(bz_, (IEnumerable<string>)ca_);
            return cb_;
        }

        IEnumerable<MedicationAdministration> j_ = context.Operators.Where<MedicationAdministration>(h_, i_);

        object k_(MedicationAdministration @this) {
            DataType cc_ = @this?.Effective;
            object cd_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cc_);
            CqlInterval<CqlDateTime> ce_ = QICoreCommon_4_0_000.Instance.toInterval(context, cd_);
            CqlDateTime cf_ = context.Operators.Start(ce_);
            return cf_;
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

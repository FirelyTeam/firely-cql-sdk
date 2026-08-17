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
[CqlLibrary("CMS986FHIRMalnutritionScore", "1.0.000")]
public partial class CMS986FHIRMalnutritionScore_1_0_000 : ILibrary, ISingleton<CMS986FHIRMalnutritionScore_1_0_000>
{
    #region ValueSets (13)

    [CqlValueSetDefinition("Encounter Inpatient", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.666.5.307", valueSetVersion: null)]
    public CqlValueSet Encounter_Inpatient(CqlContext _) => _Encounter_Inpatient;
    private static readonly CqlValueSet _Encounter_Inpatient = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.666.5.307", null);

    [CqlValueSetDefinition("Hospice Status", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1095.101", valueSetVersion: null)]
    public CqlValueSet Hospice_Status(CqlContext _) => _Hospice_Status;
    private static readonly CqlValueSet _Hospice_Status = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1095.101", null);

    [CqlValueSetDefinition("Hospice Care Referral or Admission", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1116.365", valueSetVersion: null)]
    public CqlValueSet Hospice_Care_Referral_or_Admission(CqlContext _) => _Hospice_Care_Referral_or_Admission;
    private static readonly CqlValueSet _Hospice_Care_Referral_or_Admission = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1116.365", null);

    [CqlValueSetDefinition("Dietitian Referral", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1095.91", valueSetVersion: null)]
    public CqlValueSet Dietitian_Referral(CqlContext _) => _Dietitian_Referral;
    private static readonly CqlValueSet _Dietitian_Referral = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1095.91", null);

    [CqlValueSetDefinition("Malnutrition Diagnosis", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1095.55", valueSetVersion: null)]
    public CqlValueSet Malnutrition_Diagnosis(CqlContext _) => _Malnutrition_Diagnosis;
    private static readonly CqlValueSet _Malnutrition_Diagnosis = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1095.55", null);

    [CqlValueSetDefinition("Malnutrition Risk Screening", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1095.92", valueSetVersion: null)]
    public CqlValueSet Malnutrition_Risk_Screening(CqlContext _) => _Malnutrition_Risk_Screening;
    private static readonly CqlValueSet _Malnutrition_Risk_Screening = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1095.92", null);

    [CqlValueSetDefinition("Malnutrition Screening Finding of At Risk Result", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1095.89", valueSetVersion: null)]
    public CqlValueSet Malnutrition_Screening_Finding_of_At_Risk_Result(CqlContext _) => _Malnutrition_Screening_Finding_of_At_Risk_Result;
    private static readonly CqlValueSet _Malnutrition_Screening_Finding_of_At_Risk_Result = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1095.89", null);

    [CqlValueSetDefinition("Malnutrition Screening Finding of Not At Risk Result", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1095.34", valueSetVersion: null)]
    public CqlValueSet Malnutrition_Screening_Finding_of_Not_At_Risk_Result(CqlContext _) => _Malnutrition_Screening_Finding_of_Not_At_Risk_Result;
    private static readonly CqlValueSet _Malnutrition_Screening_Finding_of_Not_At_Risk_Result = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1095.34", null);

    [CqlValueSetDefinition("Nutrition Assessment", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1095.21", valueSetVersion: null)]
    public CqlValueSet Nutrition_Assessment(CqlContext _) => _Nutrition_Assessment;
    private static readonly CqlValueSet _Nutrition_Assessment = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1095.21", null);

    [CqlValueSetDefinition("Nutrition Assessment Status Finding of Moderately Malnourished", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1095.47", valueSetVersion: null)]
    public CqlValueSet Nutrition_Assessment_Status_Finding_of_Moderately_Malnourished(CqlContext _) => _Nutrition_Assessment_Status_Finding_of_Moderately_Malnourished;
    private static readonly CqlValueSet _Nutrition_Assessment_Status_Finding_of_Moderately_Malnourished = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1095.47", null);

    [CqlValueSetDefinition("Nutrition Assessment Status Finding of Well Nourished or Not Malnourished or Mildly Malnourished", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1095.96", valueSetVersion: null)]
    public CqlValueSet Nutrition_Assessment_Status_Finding_of_Well_Nourished_or_Not_Malnourished_or_Mildly_Malnourished(CqlContext _) => _Nutrition_Assessment_Status_Finding_of_Well_Nourished_or_Not_Malnourished_or_Mildly_Malnourished;
    private static readonly CqlValueSet _Nutrition_Assessment_Status_Finding_of_Well_Nourished_or_Not_Malnourished_or_Mildly_Malnourished = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1095.96", null);

    [CqlValueSetDefinition("Nutrition Assessment Status Finding of Severely Malnourished", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1095.43", valueSetVersion: null)]
    public CqlValueSet Nutrition_Assessment_Status_Finding_of_Severely_Malnourished(CqlContext _) => _Nutrition_Assessment_Status_Finding_of_Severely_Malnourished;
    private static readonly CqlValueSet _Nutrition_Assessment_Status_Finding_of_Severely_Malnourished = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1095.43", null);

    [CqlValueSetDefinition("Nutrition Care Plan", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1095.93", valueSetVersion: null)]
    public CqlValueSet Nutrition_Care_Plan(CqlContext _) => _Nutrition_Care_Plan;
    private static readonly CqlValueSet _Nutrition_Care_Plan = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1095.93", null);

    #endregion ValueSets

    #region Parameters (1)

    [CqlParameterDefinition("Measurement Period")]
    public CqlInterval<CqlDateTime> Measurement_Period(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Measurement_Period, Measurement_Period_Compute);

    private const long _cacheIndex_Measurement_Period = 5584088217374446953L;

    private CqlInterval<CqlDateTime> Measurement_Period_Compute(CqlContext context)
    {
        CqlDateTime a_ = context.Operators.DateTime(2026, 1, 1, 0, 0, 0, 0, 0.0m);
        CqlDateTime b_ = context.Operators.DateTime(2027, 1, 1, 0, 0, 0, 0, 0.0m);
        CqlInterval<CqlDateTime> c_ = context.Operators.Interval(a_, b_, true, false);
        object d_ = context.ResolveParameter("CMS986FHIRMalnutritionScore-1.0.000", "Measurement Period", c_);
        return (CqlInterval<CqlDateTime>)d_;
    }


    #endregion Parameters

    #region Functions and Expressions (35)

    [CqlExpressionDefinition("Patient")]
    public Patient Patient(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Patient, Patient_Compute);

    private const long _cacheIndex_Patient = 6989979488914168588L;

    private Patient Patient_Compute(CqlContext context)
    {
        IEnumerable<Patient> a_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-patient"));
        Patient b_ = context.Operators.SingletonFrom<Patient>(a_);
        return b_;
    }


    [CqlExpressionDefinition("SDE Ethnicity")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Ethnicity(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_SDE_Ethnicity, SDE_Ethnicity_Compute);

    private const long _cacheIndex_SDE_Ethnicity = -148605947143256609L;

    private (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Ethnicity_Compute(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? a_ = SupplementalDataElements_5_1_000.Instance.SDE_Ethnicity(context);
        return a_;
    }


    [CqlExpressionDefinition("SDE Payer Type")]
    public IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> SDE_Payer_Type(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_SDE_Payer_Type, SDE_Payer_Type_Compute);

    private const long _cacheIndex_SDE_Payer_Type = -6146604132247170046L;

    private IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> SDE_Payer_Type_Compute(CqlContext context)
    {
        IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> a_ = SupplementalDataElements_5_1_000.Instance.SDE_Payer(context);
        return a_;
    }


    [CqlExpressionDefinition("SDE Race")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Race(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_SDE_Race, SDE_Race_Compute);

    private const long _cacheIndex_SDE_Race = -4989583145170396544L;

    private (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Race_Compute(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? a_ = SupplementalDataElements_5_1_000.Instance.SDE_Race(context);
        return a_;
    }


    [CqlExpressionDefinition("SDE Sex")]
    public CqlCode SDE_Sex(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_SDE_Sex, SDE_Sex_Compute);

    private const long _cacheIndex_SDE_Sex = 6146617802936438746L;

    private CqlCode SDE_Sex_Compute(CqlContext context)
    {
        CqlCode a_ = SupplementalDataElements_5_1_000.Instance.SDE_Sex(context);
        return a_;
    }


    [CqlExpressionDefinition("Initial Population")]
    public IEnumerable<Encounter> Initial_Population(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Initial_Population, Initial_Population_Compute);

    private const long _cacheIndex_Initial_Population = -7162108857230760093L;

    private IEnumerable<Encounter> Initial_Population_Compute(CqlContext context)
    {
        CqlValueSet a_ = this.Encounter_Inpatient(context);
        IEnumerable<Encounter> b_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));

        bool? c_(Encounter EncounterInpatient) {
            Period e_ = EncounterInpatient?.Period;
            CqlInterval<CqlDateTime> f_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, e_);
            CqlDateTime g_ = context.Operators.End(f_);
            CqlInterval<CqlDateTime> h_ = this.Measurement_Period(context);
            bool? i_ = context.Operators.In<CqlDateTime>(g_, h_, "day");
            bool? j_;
            // CQL 'and' (47:11-48:74): right operand skipped when left is false
            if (i_ is false)
            {
                j_ = false;
            }
            else
            {
                Patient l_ = this.Patient(context);
                Date m_ = l_?.BirthDateElement;
                string n_ = m_?.Value;
                CqlDate o_ = context.Operators.ConvertStringToDate(n_);
                CqlDateTime p_ = context.Operators.Start(f_);
                CqlDate q_ = context.Operators.DateFrom(p_);
                int? r_ = context.Operators.CalculateAgeAt(o_, q_, "year");
                bool? s_ = context.Operators.GreaterOrEqual(r_, 18);
                j_ = i_ & s_;
            }
            bool? k_;
            // CQL 'and' (47:11-49:66): right operand skipped when left is false
            if (j_ is false)
            {
                k_ = false;
            }
            else
            {
                CqlDateTime t_ = context.Operators.Start(f_);
                int? u_ = context.Operators.DurationBetween(t_, g_, "hour");
                bool? v_ = context.Operators.GreaterOrEqual(u_, 24);
                k_ = j_ & v_;
            }
            // CQL 'and' (47:5-50:48): right operand skipped when left is false
            if (k_ is false)
            {
                return false;
            }
            else
            {
                Code<Encounter.EncounterStatus> w_ = EncounterInpatient?.StatusElement;
                Encounter.EncounterStatus? x_ = w_?.Value;
                Code<Encounter.EncounterStatus> y_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(x_);
                bool? z_ = context.Operators.Equal(y_, "finished");
                return k_ & z_;
            }
        }

        IEnumerable<Encounter> d_ = context.Operators.Where<Encounter>(b_, c_);
        return d_;
    }


    [CqlExpressionDefinition("Measure Population")]
    public IEnumerable<Encounter> Measure_Population(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Measure_Population, Measure_Population_Compute);

    private const long _cacheIndex_Measure_Population = -8783856775724922190L;

    private IEnumerable<Encounter> Measure_Population_Compute(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Initial_Population(context);
        return a_;
    }


    [CqlExpressionDefinition("Encounters with Discharge for Hospice Care")]
    public IEnumerable<Encounter> Encounters_with_Discharge_for_Hospice_Care(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Encounters_with_Discharge_for_Hospice_Care, Encounters_with_Discharge_for_Hospice_Care_Compute);

    private const long _cacheIndex_Encounters_with_Discharge_for_Hospice_Care = -3797569175861737006L;

    private IEnumerable<Encounter> Encounters_with_Discharge_for_Hospice_Care_Compute(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Measure_Population(context);

        bool? b_(Encounter QualifyingEncounter) {
            Encounter.HospitalizationComponent d_ = QualifyingEncounter?.Hospitalization;
            CodeableConcept e_ = d_?.DischargeDisposition;
            CqlConcept f_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, e_);
            CqlValueSet g_ = this.Hospice_Care_Referral_or_Admission(context);
            bool? h_ = context.Operators.ConceptInValueSet(f_, g_);
            return h_;
        }

        IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);
        return c_;
    }


    [CqlExpressionDefinition("Intervention Hospice Care")]
    public IEnumerable<CqlDateTime> Intervention_Hospice_Care(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Intervention_Hospice_Care, Intervention_Hospice_Care_Compute);

    private const long _cacheIndex_Intervention_Hospice_Care = 6747077452182961779L;

    private IEnumerable<CqlDateTime> Intervention_Hospice_Care_Compute(CqlContext context)
    {
        CqlValueSet a_ = this.Hospice_Status(context);
        IEnumerable<ServiceRequest> b_ = context.Operators.Retrieve<ServiceRequest>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-servicerequest"));

        bool? c_(ServiceRequest HospiceStatusOrder) {
            Code<RequestStatus> m_ = HospiceStatusOrder?.StatusElement;
            RequestStatus? n_ = m_?.Value;
            Code<RequestStatus> o_ = context.Operators.Convert<Code<RequestStatus>>(n_);
            string p_ = context.Operators.Convert<string>(o_);
            string[] q_ = [
                "active",
                "completed",
                "on-hold",
            ];
            bool? r_ = context.Operators.In<string>(p_, (IEnumerable<string>)q_);
            // CQL 'and' (80:7-81:120): right operand skipped when left is false
            if (r_ is false)
            {
                return false;
            }
            else
            {
                Code<RequestIntent> s_ = HospiceStatusOrder?.IntentElement;
                RequestIntent? t_ = s_?.Value;
                Code<RequestIntent> u_ = context.Operators.Convert<Code<RequestIntent>>(t_);
                string v_ = context.Operators.Convert<string>(u_);
                string[] w_ = [
                    "order",
                    "original-order",
                    "reflex-order",
                    "filler-order",
                    "instance-order",
                ];
                bool? x_ = context.Operators.In<string>(v_, (IEnumerable<string>)w_);
                return r_ & x_;
            }
        }


        CqlDateTime d_(ServiceRequest HospiceStatusOrder) {
            FhirDateTime y_ = HospiceStatusOrder?.AuthoredOnElement;
            CqlDateTime z_ = context.Operators.Convert<CqlDateTime>(y_);
            return z_;
        }

        IEnumerable<CqlDateTime> e_ = context.Operators.WhereSelect<ServiceRequest, CqlDateTime>(b_, c_, d_);
        IEnumerable<CqlDateTime> f_ = context.Operators.Distinct<CqlDateTime>(e_);
        IEnumerable<Procedure> g_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));

        bool? h_(Procedure HospiceStatusPerformed) {
            Code<EventStatus> aa_ = HospiceStatusPerformed?.StatusElement;
            EventStatus? ab_ = aa_?.Value;
            string ac_ = context.Operators.Convert<string>(ab_);
            string[] ad_ = [
                "completed",
                "in-progress",
            ];
            bool? ae_ = context.Operators.In<string>(ac_, (IEnumerable<string>)ad_);
            return ae_;
        }


        CqlDateTime i_(Procedure HospiceStatusPerformed) {
            object af_;
            DataType ai_ = HospiceStatusPerformed?.Performed;
            object aj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ai_);
            bool ak_ = aj_ is CqlDateTime;
            if (ak_)
            {
                DataType al_ = HospiceStatusPerformed?.Performed;
                object am_ = FHIRHelpers_4_4_000.Instance.ToValue(context, al_);
                af_ = am_ as CqlDateTime;
            }
            else
            {
                DataType an_ = HospiceStatusPerformed?.Performed;
                object ao_ = FHIRHelpers_4_4_000.Instance.ToValue(context, an_);
                bool ap_ = ao_ is CqlQuantity;
                if (ap_)
                {
                    DataType aq_ = HospiceStatusPerformed?.Performed;
                    object ar_ = FHIRHelpers_4_4_000.Instance.ToValue(context, aq_);
                    af_ = ar_ as CqlQuantity;
                }
                else
                {
                    DataType as_ = HospiceStatusPerformed?.Performed;
                    object at_ = FHIRHelpers_4_4_000.Instance.ToValue(context, as_);
                    bool au_ = at_ is CqlInterval<CqlDateTime>;
                    if (au_)
                    {
                        DataType av_ = HospiceStatusPerformed?.Performed;
                        object aw_ = FHIRHelpers_4_4_000.Instance.ToValue(context, av_);
                        af_ = aw_ as CqlInterval<CqlDateTime>;
                    }
                    else
                    {
                        DataType ax_ = HospiceStatusPerformed?.Performed;
                        object ay_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ax_);
                        bool az_ = ay_ is CqlInterval<CqlQuantity>;
                        if (az_)
                        {
                            DataType ba_ = HospiceStatusPerformed?.Performed;
                            object bb_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ba_);
                            af_ = bb_ as CqlInterval<CqlQuantity>;
                        }
                        else
                        {
                            af_ = null;
                        }
                    }
                }
            }
            CqlInterval<CqlDateTime> ag_ = QICoreCommon_4_0_000.Instance.toInterval(context, af_);
            CqlDateTime ah_ = context.Operators.Start(ag_);
            return ah_;
        }

        IEnumerable<CqlDateTime> j_ = context.Operators.WhereSelect<Procedure, CqlDateTime>(g_, h_, i_);
        IEnumerable<CqlDateTime> k_ = context.Operators.Distinct<CqlDateTime>(j_);
        IEnumerable<CqlDateTime> l_ = context.Operators.Union<CqlDateTime>(f_, k_);
        return l_;
    }


    [CqlExpressionDefinition("Encounters with Hospice during Eligible Encounter")]
    public IEnumerable<Encounter> Encounters_with_Hospice_during_Eligible_Encounter(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Encounters_with_Hospice_during_Eligible_Encounter, Encounters_with_Hospice_during_Eligible_Encounter_Compute);

    private const long _cacheIndex_Encounters_with_Hospice_during_Eligible_Encounter = 3658264545879597102L;

    private IEnumerable<Encounter> Encounters_with_Hospice_during_Eligible_Encounter_Compute(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Measure_Population(context);

        bool? b_(Encounter QualifyingEncounter) {
            IEnumerable<CqlDateTime> d_ = this.Intervention_Hospice_Care(context);

            bool? e_(CqlDateTime HospiceStatusDate) {
                CqlInterval<CqlDateTime> g_ = CQMCommon_4_1_000.Instance.hospitalizationWithObservation(context, QualifyingEncounter);
                bool? h_ = context.Operators.In<CqlDateTime>(HospiceStatusDate, g_, "day");
                return h_;
            }

            bool? f_ = context.Operators.WhereAny<CqlDateTime>(d_, e_);
            return f_;
        }

        IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);
        return c_;
    }


    [CqlExpressionDefinition("Measure Population Exclusion")]
    public IEnumerable<Encounter> Measure_Population_Exclusion(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Measure_Population_Exclusion, Measure_Population_Exclusion_Compute);

    private const long _cacheIndex_Measure_Population_Exclusion = -1681637017260605467L;

    private IEnumerable<Encounter> Measure_Population_Exclusion_Compute(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Encounters_with_Discharge_for_Hospice_Care(context);
        IEnumerable<Encounter> b_ = this.Encounters_with_Hospice_during_Eligible_Encounter(context);
        IEnumerable<Encounter> c_ = context.Operators.Union<Encounter>(a_, b_);
        return c_;
    }


    [CqlExpressionDefinition("Intervention Dietitian Referral")]
    public IEnumerable<CqlDateTime> Intervention_Dietitian_Referral(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Intervention_Dietitian_Referral, Intervention_Dietitian_Referral_Compute);

    private const long _cacheIndex_Intervention_Dietitian_Referral = -5066876506533589319L;

    private IEnumerable<CqlDateTime> Intervention_Dietitian_Referral_Compute(CqlContext context)
    {
        CqlValueSet a_ = this.Dietitian_Referral(context);
        IEnumerable<ServiceRequest> b_ = context.Operators.Retrieve<ServiceRequest>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-servicerequest"));

        bool? c_(ServiceRequest DietitianReferralOrder) {
            Code<RequestStatus> m_ = DietitianReferralOrder?.StatusElement;
            RequestStatus? n_ = m_?.Value;
            Code<RequestStatus> o_ = context.Operators.Convert<Code<RequestStatus>>(n_);
            string p_ = context.Operators.Convert<string>(o_);
            string[] q_ = [
                "active",
                "completed",
                "on-hold",
            ];
            bool? r_ = context.Operators.In<string>(p_, (IEnumerable<string>)q_);
            // CQL 'and' (115:7-116:124): right operand skipped when left is false
            if (r_ is false)
            {
                return false;
            }
            else
            {
                Code<RequestIntent> s_ = DietitianReferralOrder?.IntentElement;
                RequestIntent? t_ = s_?.Value;
                Code<RequestIntent> u_ = context.Operators.Convert<Code<RequestIntent>>(t_);
                string v_ = context.Operators.Convert<string>(u_);
                string[] w_ = [
                    "order",
                    "original-order",
                    "reflex-order",
                    "filler-order",
                    "instance-order",
                ];
                bool? x_ = context.Operators.In<string>(v_, (IEnumerable<string>)w_);
                return r_ & x_;
            }
        }


        CqlDateTime d_(ServiceRequest DietitianReferralOrder) {
            FhirDateTime y_ = DietitianReferralOrder?.AuthoredOnElement;
            CqlDateTime z_ = context.Operators.Convert<CqlDateTime>(y_);
            return z_;
        }

        IEnumerable<CqlDateTime> e_ = context.Operators.WhereSelect<ServiceRequest, CqlDateTime>(b_, c_, d_);
        IEnumerable<CqlDateTime> f_ = context.Operators.Distinct<CqlDateTime>(e_);
        IEnumerable<Procedure> g_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));

        bool? h_(Procedure DietitianReferralPerformed) {
            Code<EventStatus> aa_ = DietitianReferralPerformed?.StatusElement;
            EventStatus? ab_ = aa_?.Value;
            string ac_ = context.Operators.Convert<string>(ab_);
            string[] ad_ = [
                "completed",
                "in-progress",
            ];
            bool? ae_ = context.Operators.In<string>(ac_, (IEnumerable<string>)ad_);
            return ae_;
        }


        CqlDateTime i_(Procedure DietitianReferralPerformed) {
            object af_;
            DataType ai_ = DietitianReferralPerformed?.Performed;
            object aj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ai_);
            bool ak_ = aj_ is CqlDateTime;
            if (ak_)
            {
                DataType al_ = DietitianReferralPerformed?.Performed;
                object am_ = FHIRHelpers_4_4_000.Instance.ToValue(context, al_);
                af_ = am_ as CqlDateTime;
            }
            else
            {
                DataType an_ = DietitianReferralPerformed?.Performed;
                object ao_ = FHIRHelpers_4_4_000.Instance.ToValue(context, an_);
                bool ap_ = ao_ is CqlQuantity;
                if (ap_)
                {
                    DataType aq_ = DietitianReferralPerformed?.Performed;
                    object ar_ = FHIRHelpers_4_4_000.Instance.ToValue(context, aq_);
                    af_ = ar_ as CqlQuantity;
                }
                else
                {
                    DataType as_ = DietitianReferralPerformed?.Performed;
                    object at_ = FHIRHelpers_4_4_000.Instance.ToValue(context, as_);
                    bool au_ = at_ is CqlInterval<CqlDateTime>;
                    if (au_)
                    {
                        DataType av_ = DietitianReferralPerformed?.Performed;
                        object aw_ = FHIRHelpers_4_4_000.Instance.ToValue(context, av_);
                        af_ = aw_ as CqlInterval<CqlDateTime>;
                    }
                    else
                    {
                        DataType ax_ = DietitianReferralPerformed?.Performed;
                        object ay_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ax_);
                        bool az_ = ay_ is CqlInterval<CqlQuantity>;
                        if (az_)
                        {
                            DataType ba_ = DietitianReferralPerformed?.Performed;
                            object bb_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ba_);
                            af_ = bb_ as CqlInterval<CqlQuantity>;
                        }
                        else
                        {
                            af_ = null;
                        }
                    }
                }
            }
            CqlInterval<CqlDateTime> ag_ = QICoreCommon_4_0_000.Instance.toInterval(context, af_);
            CqlDateTime ah_ = context.Operators.Start(ag_);
            return ah_;
        }

        IEnumerable<CqlDateTime> j_ = context.Operators.WhereSelect<Procedure, CqlDateTime>(g_, h_, i_);
        IEnumerable<CqlDateTime> k_ = context.Operators.Distinct<CqlDateTime>(j_);
        IEnumerable<CqlDateTime> l_ = context.Operators.Union<CqlDateTime>(f_, k_);
        return l_;
    }


    [CqlExpressionDefinition("Encounters with Dietitian Referral")]
    public IEnumerable<Encounter> Encounters_with_Dietitian_Referral(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Encounters_with_Dietitian_Referral, Encounters_with_Dietitian_Referral_Compute);

    private const long _cacheIndex_Encounters_with_Dietitian_Referral = -1502847048600689300L;

    private IEnumerable<Encounter> Encounters_with_Dietitian_Referral_Compute(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Measure_Population(context);

        bool? b_(Encounter QualifyingEncounter) {
            IEnumerable<CqlDateTime> d_ = this.Intervention_Dietitian_Referral(context);

            bool? e_(CqlDateTime DietitianReferralDate) {
                CqlInterval<CqlDateTime> g_ = CQMCommon_4_1_000.Instance.hospitalizationWithObservation(context, QualifyingEncounter);
                bool? h_ = context.Operators.In<CqlDateTime>(DietitianReferralDate, g_, "day");
                return h_;
            }

            bool? f_ = context.Operators.WhereAny<CqlDateTime>(d_, e_);
            return f_;
        }

        IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);
        return c_;
    }


    [CqlExpressionDefinition("Encounters with Malnutrition Risk Screening Not At Risk")]
    public IEnumerable<Encounter> Encounters_with_Malnutrition_Risk_Screening_Not_At_Risk(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Encounters_with_Malnutrition_Risk_Screening_Not_At_Risk, Encounters_with_Malnutrition_Risk_Screening_Not_At_Risk_Compute);

    private const long _cacheIndex_Encounters_with_Malnutrition_Risk_Screening_Not_At_Risk = 9218522296561208176L;

    private IEnumerable<Encounter> Encounters_with_Malnutrition_Risk_Screening_Not_At_Risk_Compute(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Measure_Population(context);

        bool? b_(Encounter QualifyingEncounter) {
            CqlValueSet d_ = this.Malnutrition_Risk_Screening(context);
            IEnumerable<Observation> e_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, d_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation-screening-assessment"));

            bool? f_(Observation MalnutritionRiskScreening) {
                Code<ObservationStatus> h_ = MalnutritionRiskScreening?.StatusElement;
                ObservationStatus? i_ = h_?.Value;
                string j_ = context.Operators.Convert<string>(i_);
                string[] k_ = [
                    "final",
                    "amended",
                    "corrected",
                ];
                bool? l_ = context.Operators.In<string>(j_, (IEnumerable<string>)k_);
                bool? m_;
                // CQL 'and' (140:17-141:124): right operand skipped when left is false
                if (l_ is false)
                {
                    m_ = false;
                }
                else
                {
                    CqlInterval<CqlDateTime> n_ = CQMCommon_4_1_000.Instance.hospitalizationWithObservation(context, QualifyingEncounter);
                    DataType o_ = MalnutritionRiskScreening?.Effective;
                    object p_ = FHIRHelpers_4_4_000.Instance.ToValue(context, o_);
                    CqlInterval<CqlDateTime> q_ = QICoreCommon_4_0_000.Instance.toInterval(context, p_);
                    bool? r_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(n_, q_, (string)default);
                    m_ = l_ & r_;
                }
                // CQL 'and' (140:17-142:116): right operand skipped when left is false
                if (m_ is false)
                {
                    return false;
                }
                else
                {
                    DataType s_ = MalnutritionRiskScreening?.Value;
                    object t_ = FHIRHelpers_4_4_000.Instance.ToValue(context, s_);
                    CqlValueSet u_ = this.Malnutrition_Screening_Finding_of_Not_At_Risk_Result(context);
                    bool? v_ = context.Operators.ConceptInValueSet(t_ as CqlConcept, u_);
                    return m_ & v_;
                }
            }

            bool? g_ = context.Operators.WhereAny<Observation>(e_, f_);
            return g_;
        }

        IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);
        return c_;
    }


    [CqlExpressionDefinition("Encounters with Malnutrition Risk Screening At Risk")]
    public IEnumerable<Encounter> Encounters_with_Malnutrition_Risk_Screening_At_Risk(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Encounters_with_Malnutrition_Risk_Screening_At_Risk, Encounters_with_Malnutrition_Risk_Screening_At_Risk_Compute);

    private const long _cacheIndex_Encounters_with_Malnutrition_Risk_Screening_At_Risk = -1346925088563852433L;

    private IEnumerable<Encounter> Encounters_with_Malnutrition_Risk_Screening_At_Risk_Compute(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Measure_Population(context);

        bool? b_(Encounter QualifyingEncounter) {
            CqlValueSet d_ = this.Malnutrition_Risk_Screening(context);
            IEnumerable<Observation> e_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, d_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation-screening-assessment"));

            bool? f_(Observation MalnutritionRiskScreening) {
                Code<ObservationStatus> h_ = MalnutritionRiskScreening?.StatusElement;
                ObservationStatus? i_ = h_?.Value;
                string j_ = context.Operators.Convert<string>(i_);
                string[] k_ = [
                    "final",
                    "amended",
                    "corrected",
                ];
                bool? l_ = context.Operators.In<string>(j_, (IEnumerable<string>)k_);
                bool? m_;
                // CQL 'and' (151:17-152:124): right operand skipped when left is false
                if (l_ is false)
                {
                    m_ = false;
                }
                else
                {
                    CqlInterval<CqlDateTime> n_ = CQMCommon_4_1_000.Instance.hospitalizationWithObservation(context, QualifyingEncounter);
                    DataType o_ = MalnutritionRiskScreening?.Effective;
                    object p_ = FHIRHelpers_4_4_000.Instance.ToValue(context, o_);
                    CqlInterval<CqlDateTime> q_ = QICoreCommon_4_0_000.Instance.toInterval(context, p_);
                    bool? r_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(n_, q_, (string)default);
                    m_ = l_ & r_;
                }
                // CQL 'and' (151:17-153:112): right operand skipped when left is false
                if (m_ is false)
                {
                    return false;
                }
                else
                {
                    DataType s_ = MalnutritionRiskScreening?.Value;
                    object t_ = FHIRHelpers_4_4_000.Instance.ToValue(context, s_);
                    CqlValueSet u_ = this.Malnutrition_Screening_Finding_of_At_Risk_Result(context);
                    bool? v_ = context.Operators.ConceptInValueSet(t_ as CqlConcept, u_);
                    return m_ & v_;
                }
            }

            bool? g_ = context.Operators.WhereAny<Observation>(e_, f_);
            return g_;
        }

        IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);
        return c_;
    }


    [CqlExpressionDefinition("Encounters with Malnutrition Risk Screening")]
    public IEnumerable<Encounter> Encounters_with_Malnutrition_Risk_Screening(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Encounters_with_Malnutrition_Risk_Screening, Encounters_with_Malnutrition_Risk_Screening_Compute);

    private const long _cacheIndex_Encounters_with_Malnutrition_Risk_Screening = 9202831662767776523L;

    private IEnumerable<Encounter> Encounters_with_Malnutrition_Risk_Screening_Compute(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Encounters_with_Malnutrition_Risk_Screening_Not_At_Risk(context);
        IEnumerable<Encounter> b_ = this.Encounters_with_Malnutrition_Risk_Screening_At_Risk(context);
        IEnumerable<Encounter> c_ = context.Operators.Union<Encounter>(a_, b_);
        return c_;
    }


    [CqlExpressionDefinition("Encounters with Malnutrition Risk Screening or with Dietitian Referral")]
    public IEnumerable<Encounter> Encounters_with_Malnutrition_Risk_Screening_or_with_Dietitian_Referral(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Encounters_with_Malnutrition_Risk_Screening_or_with_Dietitian_Referral, Encounters_with_Malnutrition_Risk_Screening_or_with_Dietitian_Referral_Compute);

    private const long _cacheIndex_Encounters_with_Malnutrition_Risk_Screening_or_with_Dietitian_Referral = -6167490468395476571L;

    private IEnumerable<Encounter> Encounters_with_Malnutrition_Risk_Screening_or_with_Dietitian_Referral_Compute(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Encounters_with_Malnutrition_Risk_Screening(context);
        IEnumerable<Encounter> b_ = this.Encounters_with_Dietitian_Referral(context);
        IEnumerable<Encounter> c_ = context.Operators.Union<Encounter>(a_, b_);
        return c_;
    }


    [CqlExpressionDefinition("Encounters with Malnutrition Not At Risk Screening and without Dietitian Referral")]
    public IEnumerable<Encounter> Encounters_with_Malnutrition_Not_At_Risk_Screening_and_without_Dietitian_Referral(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Encounters_with_Malnutrition_Not_At_Risk_Screening_and_without_Dietitian_Referral, Encounters_with_Malnutrition_Not_At_Risk_Screening_and_without_Dietitian_Referral_Compute);

    private const long _cacheIndex_Encounters_with_Malnutrition_Not_At_Risk_Screening_and_without_Dietitian_Referral = 5264016786480719304L;

    private IEnumerable<Encounter> Encounters_with_Malnutrition_Not_At_Risk_Screening_and_without_Dietitian_Referral_Compute(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Encounters_with_Malnutrition_Risk_Screening_Not_At_Risk(context);
        IEnumerable<Encounter> b_ = this.Encounters_with_Dietitian_Referral(context);
        IEnumerable<Encounter> c_ = context.Operators.Except<Encounter>(a_, b_);
        return c_;
    }


    [CqlExpressionDefinition("Encounters with Malnutrition Risk Screening At Risk or with Dietitian Referral")]
    public IEnumerable<Encounter> Encounters_with_Malnutrition_Risk_Screening_At_Risk_or_with_Dietitian_Referral(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Encounters_with_Malnutrition_Risk_Screening_At_Risk_or_with_Dietitian_Referral, Encounters_with_Malnutrition_Risk_Screening_At_Risk_or_with_Dietitian_Referral_Compute);

    private const long _cacheIndex_Encounters_with_Malnutrition_Risk_Screening_At_Risk_or_with_Dietitian_Referral = 8495605916755909275L;

    private IEnumerable<Encounter> Encounters_with_Malnutrition_Risk_Screening_At_Risk_or_with_Dietitian_Referral_Compute(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Encounters_with_Malnutrition_Risk_Screening_At_Risk(context);
        IEnumerable<Encounter> b_ = this.Encounters_with_Dietitian_Referral(context);
        IEnumerable<Encounter> c_ = context.Operators.Union<Encounter>(a_, b_);
        return c_;
    }


    [CqlFunctionDefinition("Last Nutrition Assessment Day During Encounter")]
    public CqlDateTime Last_Nutrition_Assessment_Day_During_Encounter(CqlContext context, Encounter QualifyingEncounter)
    {
        CqlValueSet a_ = this.Nutrition_Assessment(context);
        IEnumerable<Observation> b_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation-screening-assessment"));

        bool? c_(Observation NutritionAssessment) {
            Code<ObservationStatus> h_ = NutritionAssessment?.StatusElement;
            ObservationStatus? i_ = h_?.Value;
            string j_ = context.Operators.Convert<string>(i_);
            string[] k_ = [
                "final",
                "amended",
                "corrected",
            ];
            bool? l_ = context.Operators.In<string>(j_, (IEnumerable<string>)k_);
            bool? m_;
            // CQL 'and' (184:13-185:114): right operand skipped when left is false
            if (l_ is false)
            {
                m_ = false;
            }
            else
            {
                CqlInterval<CqlDateTime> n_ = CQMCommon_4_1_000.Instance.hospitalizationWithObservation(context, QualifyingEncounter);
                DataType o_ = NutritionAssessment?.Effective;
                object p_ = FHIRHelpers_4_4_000.Instance.ToValue(context, o_);
                CqlInterval<CqlDateTime> q_ = QICoreCommon_4_0_000.Instance.toInterval(context, p_);
                bool? r_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(n_, q_, (string)default);
                m_ = l_ & r_;
            }
            // CQL 'and' (184:7-186:49): right operand skipped when left is false
            if (m_ is false)
            {
                return false;
            }
            else
            {
                DataType s_ = NutritionAssessment?.Value;
                object t_ = FHIRHelpers_4_4_000.Instance.ToValue(context, s_);
                return m_ & (!((bool?)(t_ is null)));
            }
        }


        CqlDateTime d_(Observation NutritionAssessment) {
            object u_;
            DataType w_ = NutritionAssessment?.Effective;
            object x_ = FHIRHelpers_4_4_000.Instance.ToValue(context, w_);
            bool y_ = x_ is CqlDateTime;
            if (y_)
            {
                DataType z_ = NutritionAssessment?.Effective;
                object aa_ = FHIRHelpers_4_4_000.Instance.ToValue(context, z_);
                u_ = aa_ as CqlDateTime;
            }
            else
            {
                DataType ab_ = NutritionAssessment?.Effective;
                object ac_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ab_);
                bool ad_ = ac_ is CqlDateTime;
                if (ad_)
                {
                    DataType ae_ = NutritionAssessment?.Effective;
                    object af_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ae_);
                    u_ = af_ as CqlDateTime;
                }
                else
                {
                    DataType ag_ = NutritionAssessment?.Effective;
                    object ah_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ag_);
                    bool ai_ = ah_ is CqlInterval<CqlDateTime>;
                    if (ai_)
                    {
                        DataType aj_ = NutritionAssessment?.Effective;
                        object ak_ = FHIRHelpers_4_4_000.Instance.ToValue(context, aj_);
                        u_ = ak_ as CqlInterval<CqlDateTime>;
                    }
                    else
                    {
                        u_ = null;
                    }
                }
            }
            CqlDateTime v_ = QICoreCommon_4_0_000.Instance.latest(context, u_);
            return v_;
        }

        IEnumerable<CqlDateTime> e_ = context.Operators.WhereSelect<Observation, CqlDateTime>(b_, c_, d_);
        IEnumerable<CqlDateTime> f_ = context.Operators.Distinct<CqlDateTime>(e_);
        CqlDateTime g_ = context.Operators.Max<CqlDateTime>(f_);
        return g_;
    }


    [CqlExpressionDefinition("Encounter With Most Recent Nutrition Assessment And Identified Status")]
    public IEnumerable<Encounter> Encounter_With_Most_Recent_Nutrition_Assessment_And_Identified_Status(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Encounter_With_Most_Recent_Nutrition_Assessment_And_Identified_Status, Encounter_With_Most_Recent_Nutrition_Assessment_And_Identified_Status_Compute);

    private const long _cacheIndex_Encounter_With_Most_Recent_Nutrition_Assessment_And_Identified_Status = 2491156004312218307L;

    private IEnumerable<Encounter> Encounter_With_Most_Recent_Nutrition_Assessment_And_Identified_Status_Compute(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Encounters_with_Malnutrition_Risk_Screening_At_Risk_or_with_Dietitian_Referral(context);

        bool? b_(Encounter QualifyingEncounter) {
            CqlValueSet d_ = this.Nutrition_Assessment(context);
            IEnumerable<Observation> e_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, d_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation-screening-assessment"));

            bool? f_(Observation NutritionAssessment) {
                Code<ObservationStatus> h_ = NutritionAssessment?.StatusElement;
                ObservationStatus? i_ = h_?.Value;
                string j_ = context.Operators.Convert<string>(i_);
                string[] k_ = [
                    "final",
                    "amended",
                    "corrected",
                ];
                bool? l_ = context.Operators.In<string>(j_, (IEnumerable<string>)k_);
                bool? m_;
                // CQL 'and' (193:19-194:120): right operand skipped when left is false
                if (l_ is false)
                {
                    m_ = false;
                }
                else
                {
                    CqlInterval<CqlDateTime> o_ = CQMCommon_4_1_000.Instance.hospitalizationWithObservation(context, QualifyingEncounter);
                    DataType p_ = NutritionAssessment?.Effective;
                    object q_ = FHIRHelpers_4_4_000.Instance.ToValue(context, p_);
                    CqlInterval<CqlDateTime> r_ = QICoreCommon_4_0_000.Instance.toInterval(context, q_);
                    bool? s_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(o_, r_, (string)default);
                    m_ = l_ & s_;
                }
                bool? n_;
                // CQL 'and' (193:19-198:11): right operand skipped when left is false
                if (m_ is false)
                {
                    n_ = false;
                }
                else
                {
                    DataType t_ = NutritionAssessment?.Value;
                    object u_ = FHIRHelpers_4_4_000.Instance.ToValue(context, t_);
                    CqlValueSet v_ = this.Nutrition_Assessment_Status_Finding_of_Well_Nourished_or_Not_Malnourished_or_Mildly_Malnourished(context);
                    bool? w_ = context.Operators.ConceptInValueSet(u_ as CqlConcept, v_);
                    bool? x_;
                    // CQL 'or' (195:17-196:125): right operand skipped when left is true
                    if (w_ is true)
                    {
                        x_ = true;
                    }
                    else
                    {
                        CqlValueSet z_ = this.Nutrition_Assessment_Status_Finding_of_Moderately_Malnourished(context);
                        bool? aa_ = context.Operators.ConceptInValueSet(u_ as CqlConcept, z_);
                        x_ = w_ | aa_;
                    }
                    bool? y_;
                    // CQL 'or' (195:15-198:11): right operand skipped when left is true
                    if (x_ is true)
                    {
                        y_ = true;
                    }
                    else
                    {
                        CqlValueSet ab_ = this.Nutrition_Assessment_Status_Finding_of_Severely_Malnourished(context);
                        bool? ac_ = context.Operators.ConceptInValueSet(u_ as CqlConcept, ab_);
                        y_ = x_ | ac_;
                    }
                    n_ = m_ & y_;
                }
                // CQL 'and' (193:17-200:7): right operand skipped when left is false
                if (n_ is false)
                {
                    return false;
                }
                else
                {
                    object ad_;
                    DataType ah_ = NutritionAssessment?.Effective;
                    object ai_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ah_);
                    bool aj_ = ai_ is CqlDateTime;
                    if (aj_)
                    {
                        DataType ak_ = NutritionAssessment?.Effective;
                        object al_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ak_);
                        ad_ = al_ as CqlDateTime;
                    }
                    else
                    {
                        DataType am_ = NutritionAssessment?.Effective;
                        object an_ = FHIRHelpers_4_4_000.Instance.ToValue(context, am_);
                        bool ao_ = an_ is CqlDateTime;
                        if (ao_)
                        {
                            DataType ap_ = NutritionAssessment?.Effective;
                            object aq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ap_);
                            ad_ = aq_ as CqlDateTime;
                        }
                        else
                        {
                            DataType ar_ = NutritionAssessment?.Effective;
                            object as_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ar_);
                            bool at_ = as_ is CqlInterval<CqlDateTime>;
                            if (at_)
                            {
                                DataType au_ = NutritionAssessment?.Effective;
                                object av_ = FHIRHelpers_4_4_000.Instance.ToValue(context, au_);
                                ad_ = av_ as CqlInterval<CqlDateTime>;
                            }
                            else
                            {
                                ad_ = null;
                            }
                        }
                    }
                    CqlDateTime ae_ = QICoreCommon_4_0_000.Instance.latest(context, ad_);
                    CqlDateTime af_ = this.Last_Nutrition_Assessment_Day_During_Encounter(context, QualifyingEncounter);
                    bool? ag_ = context.Operators.SameAs(ae_, af_, "day");
                    return n_ & ag_;
                }
            }

            bool? g_ = context.Operators.WhereAny<Observation>(e_, f_);
            return g_;
        }

        IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);
        return c_;
    }


    [CqlExpressionDefinition("Encounter With Most Recent Nutrition Assessment Status of Moderately Or Severely Malnourished")]
    public IEnumerable<Encounter> Encounter_With_Most_Recent_Nutrition_Assessment_Status_of_Moderately_Or_Severely_Malnourished(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Encounter_With_Most_Recent_Nutrition_Assessment_Status_of_Moderately_Or_Severely_Malnourished, Encounter_With_Most_Recent_Nutrition_Assessment_Status_of_Moderately_Or_Severely_Malnourished_Compute);

    private const long _cacheIndex_Encounter_With_Most_Recent_Nutrition_Assessment_Status_of_Moderately_Or_Severely_Malnourished = 3470386145325675084L;

    private IEnumerable<Encounter> Encounter_With_Most_Recent_Nutrition_Assessment_Status_of_Moderately_Or_Severely_Malnourished_Compute(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Measure_Population(context);

        bool? b_(Encounter QualifyingEncounter) {
            CqlValueSet d_ = this.Nutrition_Assessment(context);
            IEnumerable<Observation> e_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, d_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation-screening-assessment"));

            bool? f_(Observation NutritionAssessment) {
                Code<ObservationStatus> h_ = NutritionAssessment?.StatusElement;
                ObservationStatus? i_ = h_?.Value;
                string j_ = context.Operators.Convert<string>(i_);
                string[] k_ = [
                    "final",
                    "amended",
                    "corrected",
                ];
                bool? l_ = context.Operators.In<string>(j_, (IEnumerable<string>)k_);
                bool? m_;
                // CQL 'and' (205:17-206:118): right operand skipped when left is false
                if (l_ is false)
                {
                    m_ = false;
                }
                else
                {
                    CqlInterval<CqlDateTime> o_ = CQMCommon_4_1_000.Instance.hospitalizationWithObservation(context, QualifyingEncounter);
                    DataType p_ = NutritionAssessment?.Effective;
                    object q_ = FHIRHelpers_4_4_000.Instance.ToValue(context, p_);
                    CqlInterval<CqlDateTime> r_ = QICoreCommon_4_0_000.Instance.toInterval(context, q_);
                    bool? s_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(o_, r_, (string)default);
                    m_ = l_ & s_;
                }
                bool? n_;
                // CQL 'and' (205:17-209:9): right operand skipped when left is false
                if (m_ is false)
                {
                    n_ = false;
                }
                else
                {
                    DataType t_ = NutritionAssessment?.Value;
                    object u_ = FHIRHelpers_4_4_000.Instance.ToValue(context, t_);
                    CqlValueSet v_ = this.Nutrition_Assessment_Status_Finding_of_Moderately_Malnourished(context);
                    bool? w_ = context.Operators.ConceptInValueSet(u_ as CqlConcept, v_);
                    bool? x_;
                    // CQL 'or' (207:13-209:9): right operand skipped when left is true
                    if (w_ is true)
                    {
                        x_ = true;
                    }
                    else
                    {
                        CqlValueSet y_ = this.Nutrition_Assessment_Status_Finding_of_Severely_Malnourished(context);
                        bool? z_ = context.Operators.ConceptInValueSet(u_ as CqlConcept, y_);
                        x_ = w_ | z_;
                    }
                    n_ = m_ & x_;
                }
                // CQL 'and' (205:17-210:134): right operand skipped when left is false
                if (n_ is false)
                {
                    return false;
                }
                else
                {
                    object aa_;
                    DataType ae_ = NutritionAssessment?.Effective;
                    object af_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ae_);
                    bool ag_ = af_ is CqlDateTime;
                    if (ag_)
                    {
                        DataType ah_ = NutritionAssessment?.Effective;
                        object ai_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ah_);
                        aa_ = ai_ as CqlDateTime;
                    }
                    else
                    {
                        DataType aj_ = NutritionAssessment?.Effective;
                        object ak_ = FHIRHelpers_4_4_000.Instance.ToValue(context, aj_);
                        bool al_ = ak_ is CqlDateTime;
                        if (al_)
                        {
                            DataType am_ = NutritionAssessment?.Effective;
                            object an_ = FHIRHelpers_4_4_000.Instance.ToValue(context, am_);
                            aa_ = an_ as CqlDateTime;
                        }
                        else
                        {
                            DataType ao_ = NutritionAssessment?.Effective;
                            object ap_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ao_);
                            bool aq_ = ap_ is CqlInterval<CqlDateTime>;
                            if (aq_)
                            {
                                DataType ar_ = NutritionAssessment?.Effective;
                                object as_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ar_);
                                aa_ = as_ as CqlInterval<CqlDateTime>;
                            }
                            else
                            {
                                aa_ = null;
                            }
                        }
                    }
                    CqlDateTime ab_ = QICoreCommon_4_0_000.Instance.latest(context, aa_);
                    CqlDateTime ac_ = this.Last_Nutrition_Assessment_Day_During_Encounter(context, QualifyingEncounter);
                    bool? ad_ = context.Operators.SameAs(ab_, ac_, "day");
                    return n_ & ad_;
                }
            }

            bool? g_ = context.Operators.WhereAny<Observation>(e_, f_);
            return g_;
        }

        IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);
        return c_;
    }


    [CqlExpressionDefinition("Encounter With Most Recent Nutrition Assessment Status of Not or Mildly Malnourished")]
    public IEnumerable<Encounter> Encounter_With_Most_Recent_Nutrition_Assessment_Status_of_Not_or_Mildly_Malnourished(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Encounter_With_Most_Recent_Nutrition_Assessment_Status_of_Not_or_Mildly_Malnourished, Encounter_With_Most_Recent_Nutrition_Assessment_Status_of_Not_or_Mildly_Malnourished_Compute);

    private const long _cacheIndex_Encounter_With_Most_Recent_Nutrition_Assessment_Status_of_Not_or_Mildly_Malnourished = -467060107624116912L;

    private IEnumerable<Encounter> Encounter_With_Most_Recent_Nutrition_Assessment_Status_of_Not_or_Mildly_Malnourished_Compute(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Measure_Population(context);

        bool? b_(Encounter QualifyingEncounter) {
            CqlValueSet d_ = this.Nutrition_Assessment(context);
            IEnumerable<Observation> e_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, d_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation-screening-assessment"));

            bool? f_(Observation NutritionAssessment) {
                Code<ObservationStatus> h_ = NutritionAssessment?.StatusElement;
                ObservationStatus? i_ = h_?.Value;
                string j_ = context.Operators.Convert<string>(i_);
                string[] k_ = [
                    "final",
                    "amended",
                    "corrected",
                ];
                bool? l_ = context.Operators.In<string>(j_, (IEnumerable<string>)k_);
                bool? m_;
                // CQL 'and' (215:19-216:120): right operand skipped when left is false
                if (l_ is false)
                {
                    m_ = false;
                }
                else
                {
                    CqlInterval<CqlDateTime> o_ = CQMCommon_4_1_000.Instance.hospitalizationWithObservation(context, QualifyingEncounter);
                    DataType p_ = NutritionAssessment?.Effective;
                    object q_ = FHIRHelpers_4_4_000.Instance.ToValue(context, p_);
                    CqlInterval<CqlDateTime> r_ = QICoreCommon_4_0_000.Instance.toInterval(context, q_);
                    bool? s_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(o_, r_, (string)default);
                    m_ = l_ & s_;
                }
                bool? n_;
                // CQL 'and' (215:19-217:156): right operand skipped when left is false
                if (m_ is false)
                {
                    n_ = false;
                }
                else
                {
                    DataType t_ = NutritionAssessment?.Value;
                    object u_ = FHIRHelpers_4_4_000.Instance.ToValue(context, t_);
                    CqlValueSet v_ = this.Nutrition_Assessment_Status_Finding_of_Well_Nourished_or_Not_Malnourished_or_Mildly_Malnourished(context);
                    bool? w_ = context.Operators.ConceptInValueSet(u_ as CqlConcept, v_);
                    n_ = m_ & w_;
                }
                // CQL 'and' (215:17-219:7): right operand skipped when left is false
                if (n_ is false)
                {
                    return false;
                }
                else
                {
                    object x_;
                    DataType ab_ = NutritionAssessment?.Effective;
                    object ac_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ab_);
                    bool ad_ = ac_ is CqlDateTime;
                    if (ad_)
                    {
                        DataType ae_ = NutritionAssessment?.Effective;
                        object af_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ae_);
                        x_ = af_ as CqlDateTime;
                    }
                    else
                    {
                        DataType ag_ = NutritionAssessment?.Effective;
                        object ah_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ag_);
                        bool ai_ = ah_ is CqlDateTime;
                        if (ai_)
                        {
                            DataType aj_ = NutritionAssessment?.Effective;
                            object ak_ = FHIRHelpers_4_4_000.Instance.ToValue(context, aj_);
                            x_ = ak_ as CqlDateTime;
                        }
                        else
                        {
                            DataType al_ = NutritionAssessment?.Effective;
                            object am_ = FHIRHelpers_4_4_000.Instance.ToValue(context, al_);
                            bool an_ = am_ is CqlInterval<CqlDateTime>;
                            if (an_)
                            {
                                DataType ao_ = NutritionAssessment?.Effective;
                                object ap_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ao_);
                                x_ = ap_ as CqlInterval<CqlDateTime>;
                            }
                            else
                            {
                                x_ = null;
                            }
                        }
                    }
                    CqlDateTime y_ = QICoreCommon_4_0_000.Instance.latest(context, x_);
                    CqlDateTime z_ = this.Last_Nutrition_Assessment_Day_During_Encounter(context, QualifyingEncounter);
                    bool? aa_ = context.Operators.SameAs(y_, z_, "day");
                    return n_ & aa_;
                }
            }

            bool? g_ = context.Operators.WhereAny<Observation>(e_, f_);
            return g_;
        }

        IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);
        return c_;
    }


    [CqlFunctionDefinition("isVerified")]
    public bool? isVerified(CqlContext context, Condition condition)
    {
        CodeableConcept a_ = condition?.VerificationStatus;
        CqlConcept b_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, a_);
        CqlCode c_ = QICoreCommon_4_0_000.Instance.confirmed(context);
        CqlConcept d_ = context.Operators.ConvertCodeToConcept(c_);
        bool? e_ = context.Operators.Equivalent(b_, d_);
        bool? f_;
        // CQL 'or' (240:54-241:66): right operand skipped when left is true
        if (e_ is true)
        {
            f_ = true;
        }
        else
        {
            CqlCode j_ = QICoreCommon_4_0_000.Instance.unconfirmed(context);
            CqlConcept k_ = context.Operators.ConvertCodeToConcept(j_);
            bool? l_ = context.Operators.Equivalent(b_, k_);
            f_ = e_ | l_;
        }
        bool? g_;
        // CQL 'or' (240:54-242:66): right operand skipped when left is true
        if (f_ is true)
        {
            g_ = true;
        }
        else
        {
            CqlCode m_ = QICoreCommon_4_0_000.Instance.provisional(context);
            CqlConcept n_ = context.Operators.ConvertCodeToConcept(m_);
            bool? o_ = context.Operators.Equivalent(b_, n_);
            g_ = f_ | o_;
        }
        bool? h_;
        // CQL 'or' (240:52-244:3): right operand skipped when left is true
        if (g_ is true)
        {
            h_ = true;
        }
        else
        {
            CqlCode p_ = QICoreCommon_4_0_000.Instance.differential(context);
            CqlConcept q_ = context.Operators.ConvertCodeToConcept(p_);
            bool? r_ = context.Operators.Equivalent(b_, q_);
            h_ = g_ | r_;
        }
        bool? i_ = context.Operators.Implies(!((bool?)(b_ is null)), h_);
        return i_;
    }


    [CqlExpressionDefinition("Has Malnutrition Diagnosis")]
    public IEnumerable<Condition> Has_Malnutrition_Diagnosis(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Has_Malnutrition_Diagnosis, Has_Malnutrition_Diagnosis_Compute);

    private const long _cacheIndex_Has_Malnutrition_Diagnosis = 5295155027843881410L;

    private IEnumerable<Condition> Has_Malnutrition_Diagnosis_Compute(CqlContext context)
    {
        CqlValueSet a_ = this.Malnutrition_Diagnosis(context);
        IEnumerable<Condition> b_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-problems-health-concerns"));

        bool? c_(Condition MalnutritionDiagnosis) {
            CqlInterval<CqlDateTime> e_ = QICoreCommon_4_0_000.Instance.prevalenceInterval(context, MalnutritionDiagnosis as Condition);
            CqlInterval<CqlDateTime> f_ = this.Measurement_Period(context);
            bool? g_ = context.Operators.Overlaps(e_, f_, (string)default);
            // CQL 'and' (231:5-232:46): right operand skipped when left is false
            if (g_ is false)
            {
                return false;
            }
            else
            {
                bool? h_ = this.isVerified(context, MalnutritionDiagnosis as Condition);
                return g_ & h_;
            }
        }

        IEnumerable<Condition> d_ = context.Operators.Where<Condition>(b_, c_);
        return d_;
    }


    [CqlExpressionDefinition("Encounters With Encounter Diagnosis Of Malnutrition Diagnosis")]
    public IEnumerable<Encounter> Encounters_With_Encounter_Diagnosis_Of_Malnutrition_Diagnosis(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Encounters_With_Encounter_Diagnosis_Of_Malnutrition_Diagnosis, Encounters_With_Encounter_Diagnosis_Of_Malnutrition_Diagnosis_Compute);

    private const long _cacheIndex_Encounters_With_Encounter_Diagnosis_Of_Malnutrition_Diagnosis = -7777489324715066466L;

    private IEnumerable<Encounter> Encounters_With_Encounter_Diagnosis_Of_Malnutrition_Diagnosis_Compute(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Measure_Population(context);

        bool? b_(Encounter QualifyingEncounter) {
            List<CodeableConcept> d_ = QualifyingEncounter?.ReasonCode;

            CqlConcept e_(CodeableConcept @this) {
                CqlConcept i_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);
                return i_;
            }

            IEnumerable<CqlConcept> f_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)d_, e_);
            CqlValueSet g_ = this.Malnutrition_Diagnosis(context);
            bool? h_ = context.Operators.ConceptsInValueSet(f_, g_);
            // CQL 'or' (236:5-237:97): right operand skipped when left is true
            if (h_ is true)
            {
                return true;
            }
            else
            {
                IEnumerable<Condition> j_ = CQMCommon_4_1_000.Instance.encounterDiagnosis(context, QualifyingEncounter);
                IEnumerable<Condition> k_ = Status_1_15_000.Instance.verified(context, j_);

                bool? l_(Condition @this) {
                    CodeableConcept p_ = @this?.Code;
                    CqlConcept q_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, p_);
                    return !((bool?)(q_ is null));
                }


                CqlConcept m_(Condition @this) {
                    CodeableConcept r_ = @this?.Code;
                    CqlConcept s_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, r_);
                    return s_;
                }

                IEnumerable<CqlConcept> n_ = context.Operators.WhereSelect<Condition, CqlConcept>(k_, l_, m_);
                bool? o_ = context.Operators.ConceptsInValueSet(n_, g_);
                return h_ | o_;
            }
        }

        IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);
        return c_;
    }


    [CqlExpressionDefinition("Encounters with Malnutrition Diagnosis")]
    public IEnumerable<Encounter> Encounters_with_Malnutrition_Diagnosis(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Encounters_with_Malnutrition_Diagnosis, Encounters_with_Malnutrition_Diagnosis_Compute);

    private const long _cacheIndex_Encounters_with_Malnutrition_Diagnosis = 6975114635827873763L;

    private IEnumerable<Encounter> Encounters_with_Malnutrition_Diagnosis_Compute(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Measure_Population(context);

        bool? b_(Encounter QualifyingEncounter) {
            IEnumerable<Condition> f_ = this.Has_Malnutrition_Diagnosis(context);

            bool? g_(Condition MalnutritionDiagnosis) {
                CqlInterval<CqlDateTime> i_ = QICoreCommon_4_0_000.Instance.prevalenceInterval(context, MalnutritionDiagnosis as Condition);
                CqlInterval<CqlDateTime> j_ = CQMCommon_4_1_000.Instance.hospitalizationWithObservation(context, QualifyingEncounter);
                bool? k_ = context.Operators.Overlaps(i_, j_, "day");
                return k_;
            }

            bool? h_ = context.Operators.WhereAny<Condition>(f_, g_);
            return h_;
        }

        IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);
        IEnumerable<Encounter> d_ = this.Encounters_With_Encounter_Diagnosis_Of_Malnutrition_Diagnosis(context);
        IEnumerable<Encounter> e_ = context.Operators.Union<Encounter>(c_, d_);
        return e_;
    }


    [CqlExpressionDefinition("Encounters with Nutrition Care Plan")]
    public IEnumerable<Encounter> Encounters_with_Nutrition_Care_Plan(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Encounters_with_Nutrition_Care_Plan, Encounters_with_Nutrition_Care_Plan_Compute);

    private const long _cacheIndex_Encounters_with_Nutrition_Care_Plan = -6486910016594734001L;

    private IEnumerable<Encounter> Encounters_with_Nutrition_Care_Plan_Compute(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Measure_Population(context);

        bool? b_(Encounter QualifyingEncounter) {
            CqlValueSet d_ = this.Nutrition_Care_Plan(context);
            IEnumerable<Procedure> e_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, d_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));

            bool? f_(Procedure NutritionCarePlan) {
                Code<EventStatus> h_ = NutritionCarePlan?.StatusElement;
                EventStatus? i_ = h_?.Value;
                string j_ = context.Operators.Convert<string>(i_);
                string[] k_ = [
                    "completed",
                    "in-progress",
                ];
                bool? l_ = context.Operators.In<string>(j_, (IEnumerable<string>)k_);
                // CQL 'and' (249:17-250:114): right operand skipped when left is false
                if (l_ is false)
                {
                    return false;
                }
                else
                {
                    DataType m_ = NutritionCarePlan?.Performed;
                    object n_ = FHIRHelpers_4_4_000.Instance.ToValue(context, m_);
                    CqlDateTime o_ = QICoreCommon_4_0_000.Instance.earliest(context, n_);
                    CqlInterval<CqlDateTime> p_ = CQMCommon_4_1_000.Instance.hospitalizationWithObservation(context, QualifyingEncounter);
                    bool? q_ = context.Operators.In<CqlDateTime>(o_, p_, (string)default);
                    return l_ & q_;
                }
            }

            bool? g_ = context.Operators.WhereAny<Procedure>(e_, f_);
            return g_;
        }

        IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);
        return c_;
    }


    [CqlFunctionDefinition("Measure Observation 1")]
    public int? Measure_Observation_1(CqlContext context, Encounter MalnutritionRiskScreening) =>
    ((context.Operators.Contains<Encounter>(this.Encounters_with_Malnutrition_Risk_Screening_or_with_Dietitian_Referral(context), MalnutritionRiskScreening)) ?? false
        ? 1
        : 0);


    [CqlFunctionDefinition("Measure Observation 2")]
    public int? Measure_Observation_2(CqlContext context, Encounter NutritionAssessment)
    {
        IEnumerable<Encounter> a_ = this.Encounters_with_Malnutrition_Not_At_Risk_Screening_and_without_Dietitian_Referral(context);
        bool? b_ = context.Operators.Contains<Encounter>(a_, NutritionAssessment);
        if (b_ ?? false)
        {
            return 0;
        }
        else
        {
            IEnumerable<Encounter> c_ = this.Encounters_with_Malnutrition_Risk_Screening_At_Risk_or_with_Dietitian_Referral(context);
            bool? d_ = context.Operators.Contains<Encounter>(c_, NutritionAssessment);
            if (d_ ?? false)
            {
                return ((context.Operators.Contains<Encounter>(this.Encounter_With_Most_Recent_Nutrition_Assessment_And_Identified_Status(context), NutritionAssessment)) ?? false
                    ? 1
                    : 0);
            }
            else
            {
                return 0;
            }
        }
    }


    [CqlFunctionDefinition("Measure Observation 3")]
    public int? Measure_Observation_3(CqlContext context, Encounter MalnutritionDiagnosis)
    {
        IEnumerable<Encounter> a_ = this.Encounters_with_Malnutrition_Not_At_Risk_Screening_and_without_Dietitian_Referral(context);
        bool? b_ = context.Operators.Contains<Encounter>(a_, MalnutritionDiagnosis);
        if (b_ ?? false)
        {
            return 0;
        }
        else
        {
            IEnumerable<Encounter> c_ = this.Encounters_with_Malnutrition_Risk_Screening_At_Risk_or_with_Dietitian_Referral(context);
            bool? d_ = context.Operators.Contains<Encounter>(c_, MalnutritionDiagnosis);
            if (d_ ?? false)
            {
                IEnumerable<Encounter> e_ = this.Encounters_with_Malnutrition_Diagnosis(context);
                bool? f_ = context.Operators.Contains<Encounter>(e_, MalnutritionDiagnosis);
                if (f_ ?? false)
                {
                    IEnumerable<Encounter> g_ = this.Encounter_With_Most_Recent_Nutrition_Assessment_Status_of_Not_or_Mildly_Malnourished(context);
                    bool? h_ = context.Operators.Contains<Encounter>(g_, MalnutritionDiagnosis);
                    if (h_ ?? false)
                    {
                        return 0;
                    }
                    else
                    {
                        IEnumerable<Encounter> i_ = this.Encounter_With_Most_Recent_Nutrition_Assessment_Status_of_Moderately_Or_Severely_Malnourished(context);
                        bool? j_ = context.Operators.Contains<Encounter>(i_, MalnutritionDiagnosis);
                        if (j_ ?? false)
                        {
                            return 1;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
                else
                {
                    return 0;
                }
            }
            else
            {
                return 0;
            }
        }
    }


    [CqlFunctionDefinition("Measure Observation 4")]
    public int? Measure_Observation_4(CqlContext context, Encounter NutritionCarePlan)
    {
        IEnumerable<Encounter> a_ = this.Encounters_with_Malnutrition_Not_At_Risk_Screening_and_without_Dietitian_Referral(context);
        bool? b_ = context.Operators.Contains<Encounter>(a_, NutritionCarePlan);
        if (b_ ?? false)
        {
            return 0;
        }
        else
        {
            IEnumerable<Encounter> c_ = this.Encounters_with_Malnutrition_Risk_Screening_At_Risk_or_with_Dietitian_Referral(context);
            bool? d_ = context.Operators.Contains<Encounter>(c_, NutritionCarePlan);
            if (d_ ?? false)
            {
                IEnumerable<Encounter> e_ = this.Encounters_with_Nutrition_Care_Plan(context);
                bool? f_ = context.Operators.Contains<Encounter>(e_, NutritionCarePlan);
                if (f_ ?? false)
                {
                    IEnumerable<Encounter> g_ = this.Encounter_With_Most_Recent_Nutrition_Assessment_Status_of_Not_or_Mildly_Malnourished(context);
                    bool? h_ = context.Operators.Contains<Encounter>(g_, NutritionCarePlan);
                    if (h_ ?? false)
                    {
                        return 0;
                    }
                    else
                    {
                        IEnumerable<Encounter> i_ = this.Encounter_With_Most_Recent_Nutrition_Assessment_Status_of_Moderately_Or_Severely_Malnourished(context);
                        bool? j_ = context.Operators.Contains<Encounter>(i_, NutritionCarePlan);
                        if (j_ ?? false)
                        {
                            return 1;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
                else
                {
                    return 0;
                }
            }
            else
            {
                return 0;
            }
        }
    }


    [CqlFunctionDefinition("Total Malnutrition Care Score Eligible Occurrences")]
    public int? Total_Malnutrition_Care_Score_Eligible_Occurrences(CqlContext context, Encounter QualifyingEncounter)
    {
        IEnumerable<Encounter> a_ = this.Encounters_with_Malnutrition_Risk_Screening_or_with_Dietitian_Referral(context);
        bool? b_ = context.Operators.Contains<Encounter>(a_, QualifyingEncounter);
        bool? c_;
        // CQL 'and' (279:6-280:94): right operand skipped when left is false
        if (b_ is false)
        {
            c_ = false;
        }
        else
        {
            IEnumerable<Encounter> e_ = this.Encounters_with_Malnutrition_Risk_Screening_Not_At_Risk(context);
            bool? f_ = context.Operators.Contains<Encounter>(e_, QualifyingEncounter);
            c_ = b_ & f_;
        }
        bool? d_;
        // CQL 'and' (279:6-281:81): right operand skipped when left is false
        if (c_ is false)
        {
            d_ = false;
        }
        else
        {
            IEnumerable<Encounter> g_ = this.Encounters_with_Dietitian_Referral(context);
            bool? h_ = context.Operators.Contains<Encounter>(g_, QualifyingEncounter);
            d_ = c_ & !h_;
        }
        if (d_ ?? false)
        {
            return 1;
        }
        else
        {
            IEnumerable<Encounter> i_ = this.Encounters_with_Malnutrition_Risk_Screening_or_with_Dietitian_Referral(context);
            bool? j_ = context.Operators.Contains<Encounter>(i_, QualifyingEncounter);
            bool? k_;
            // CQL 'and' (282:15-283:92): right operand skipped when left is false
            if (j_ is false)
            {
                k_ = false;
            }
            else
            {
                IEnumerable<Encounter> o_ = this.Encounters_with_Malnutrition_Risk_Screening_At_Risk(context);
                bool? p_ = context.Operators.Contains<Encounter>(o_, QualifyingEncounter);
                k_ = j_ & p_;
            }
            bool? l_;
            // CQL 'or' (282:13-285:3): right operand skipped when left is true
            if (k_ is true)
            {
                l_ = true;
            }
            else
            {
                IEnumerable<Encounter> q_ = this.Encounters_with_Dietitian_Referral(context);
                bool? r_ = context.Operators.Contains<Encounter>(q_, QualifyingEncounter);
                l_ = k_ | r_;
            }
            bool? m_;
            // CQL 'and' (282:13-286:123): right operand skipped when left is false
            if (l_ is false)
            {
                m_ = false;
            }
            else
            {
                IEnumerable<Encounter> s_ = this.Encounter_With_Most_Recent_Nutrition_Assessment_Status_of_Not_or_Mildly_Malnourished(context);
                bool? t_ = context.Operators.Contains<Encounter>(s_, QualifyingEncounter);
                m_ = l_ & t_;
            }
            bool? n_;
            // CQL 'or' (282:13-287:115): right operand skipped when left is true
            if (m_ is true)
            {
                n_ = true;
            }
            else
            {
                IEnumerable<Encounter> u_ = this.Encounter_With_Most_Recent_Nutrition_Assessment_And_Identified_Status(context);
                bool? v_ = context.Operators.Contains<Encounter>(u_, QualifyingEncounter);
                n_ = m_ | !v_;
            }
            if (n_ ?? false)
            {
                return 2;
            }
            else
            {
                return 4;
            }
        }
    }


    [CqlFunctionDefinition("Measure Observation Total Malnutrition Components Score")]
    public int? Measure_Observation_Total_Malnutrition_Components_Score(CqlContext context, Encounter QualifyingEncounter)
    {
        int? a_ = this.Measure_Observation_1(context, QualifyingEncounter);
        int? b_ = this.Measure_Observation_2(context, QualifyingEncounter);
        int? c_ = this.Measure_Observation_3(context, QualifyingEncounter);
        int? d_ = this.Measure_Observation_4(context, QualifyingEncounter);
        int?[] e_ = [
            a_,
            b_,
            c_,
            d_,
        ];
        int? f_ = context.Operators.Sum((IEnumerable<int?>)e_);
        return f_;
    }


    [CqlFunctionDefinition("Measure Observation Total Malnutrition Care Score as Percentage")]
    public decimal? Measure_Observation_Total_Malnutrition_Care_Score_as_Percentage(CqlContext context, Encounter QualifyingEncounter)
    {
        decimal? a_ = context.Operators.ConvertIntegerToDecimal(100);
        int? b_ = this.Measure_Observation_Total_Malnutrition_Components_Score(context, QualifyingEncounter);
        decimal? c_ = context.Operators.ConvertIntegerToDecimal(b_);
        int? d_ = this.Total_Malnutrition_Care_Score_Eligible_Occurrences(context, QualifyingEncounter);
        decimal? e_ = context.Operators.ConvertIntegerToDecimal(d_);
        decimal? f_ = context.Operators.Divide(c_, e_);
        decimal? g_ = context.Operators.Multiply(a_, f_);
        return g_;
    }


    #endregion Functions and Expressions

    #region Singleton Lifetime Members

    private CMS986FHIRMalnutritionScore_1_0_000() {}

    public static CMS986FHIRMalnutritionScore_1_0_000 Instance { get; } = new();

    #endregion

    #region ILibrary Implementation

    public string Name => "CMS986FHIRMalnutritionScore";
    public string Version => "1.0.000";
    public ILibrary[] Dependencies => [FHIRHelpers_4_4_000.Instance, SupplementalDataElements_5_1_000.Instance, QICoreCommon_4_0_000.Instance, CQMCommon_4_1_000.Instance, Status_1_15_000.Instance];

    #endregion ILibrary Implementation

}

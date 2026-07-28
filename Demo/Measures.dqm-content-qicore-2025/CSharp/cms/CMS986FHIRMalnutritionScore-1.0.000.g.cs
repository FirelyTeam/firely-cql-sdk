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
            Patient j_ = this.Patient(context);
            Date k_ = j_?.BirthDateElement;
            string l_ = k_?.Value;
            CqlDate m_ = context.Operators.ConvertStringToDate(l_);
            CqlDateTime n_ = context.Operators.Start(f_);
            CqlDate o_ = context.Operators.DateFrom(n_);
            int? p_ = context.Operators.CalculateAgeAt(m_, o_, "year");
            bool? q_ = context.Operators.GreaterOrEqual(p_, 18);
            bool? r_ = context.Operators.And(i_, q_);
            int? s_ = context.Operators.DurationBetween(n_, g_, "hour");
            bool? t_ = context.Operators.GreaterOrEqual(s_, 24);
            bool? u_ = context.Operators.And(r_, t_);
            Code<Encounter.EncounterStatus> v_ = EncounterInpatient?.StatusElement;
            Encounter.EncounterStatus? w_ = v_?.Value;
            Code<Encounter.EncounterStatus> x_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(w_);
            bool? y_ = context.Operators.Equal(x_, "finished");
            bool? z_ = context.Operators.And(u_, y_);
            return z_;
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
            Code<RequestStatus> o_ = HospiceStatusOrder?.StatusElement;
            RequestStatus? p_ = o_?.Value;
            Code<RequestStatus> q_ = context.Operators.Convert<Code<RequestStatus>>(p_);
            string r_ = context.Operators.Convert<string>(q_);
            string[] s_ = [
                "active",
                "completed",
                "on-hold",
            ];
            bool? t_ = context.Operators.In<string>(r_, (IEnumerable<string>)s_);
            Code<RequestIntent> u_ = HospiceStatusOrder?.IntentElement;
            RequestIntent? v_ = u_?.Value;
            Code<RequestIntent> w_ = context.Operators.Convert<Code<RequestIntent>>(v_);
            string x_ = context.Operators.Convert<string>(w_);
            string[] y_ = [
                "order",
                "original-order",
                "reflex-order",
                "filler-order",
                "instance-order",
            ];
            bool? z_ = context.Operators.In<string>(x_, (IEnumerable<string>)y_);
            bool? aa_ = context.Operators.And(t_, z_);
            return aa_;
        }

        IEnumerable<ServiceRequest> d_ = context.Operators.Where<ServiceRequest>(b_, c_);

        CqlDateTime e_(ServiceRequest HospiceStatusOrder) {
            FhirDateTime ab_ = HospiceStatusOrder?.AuthoredOnElement;
            CqlDateTime ac_ = context.Operators.Convert<CqlDateTime>(ab_);
            return ac_;
        }

        IEnumerable<CqlDateTime> f_ = context.Operators.Select<ServiceRequest, CqlDateTime>(d_, e_);
        IEnumerable<CqlDateTime> g_ = context.Operators.Distinct<CqlDateTime>(f_);
        IEnumerable<Procedure> h_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));

        bool? i_(Procedure HospiceStatusPerformed) {
            Code<EventStatus> ad_ = HospiceStatusPerformed?.StatusElement;
            EventStatus? ae_ = ad_?.Value;
            string af_ = context.Operators.Convert<string>(ae_);
            string[] ag_ = [
                "completed",
                "in-progress",
            ];
            bool? ah_ = context.Operators.In<string>(af_, (IEnumerable<string>)ag_);
            return ah_;
        }

        IEnumerable<Procedure> j_ = context.Operators.Where<Procedure>(h_, i_);

        CqlDateTime k_(Procedure HospiceStatusPerformed) {

            object ai_() {

                bool al_() {
                    DataType ap_ = HospiceStatusPerformed?.Performed;
                    object aq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ap_);
                    bool ar_ = aq_ is CqlDateTime;
                    return ar_;
                }


                bool am_() {
                    DataType as_ = HospiceStatusPerformed?.Performed;
                    object at_ = FHIRHelpers_4_4_000.Instance.ToValue(context, as_);
                    bool au_ = at_ is CqlQuantity;
                    return au_;
                }


                bool an_() {
                    DataType av_ = HospiceStatusPerformed?.Performed;
                    object aw_ = FHIRHelpers_4_4_000.Instance.ToValue(context, av_);
                    bool ax_ = aw_ is CqlInterval<CqlDateTime>;
                    return ax_;
                }


                bool ao_() {
                    DataType ay_ = HospiceStatusPerformed?.Performed;
                    object az_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ay_);
                    bool ba_ = az_ is CqlInterval<CqlQuantity>;
                    return ba_;
                }

                if (al_())
                {
                    DataType bb_ = HospiceStatusPerformed?.Performed;
                    object bc_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bb_);
                    return bc_ as CqlDateTime;
                }
                else if (am_())
                {
                    DataType bd_ = HospiceStatusPerformed?.Performed;
                    object be_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bd_);
                    return be_ as CqlQuantity;
                }
                else if (an_())
                {
                    DataType bf_ = HospiceStatusPerformed?.Performed;
                    object bg_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bf_);
                    return bg_ as CqlInterval<CqlDateTime>;
                }
                else if (ao_())
                {
                    DataType bh_ = HospiceStatusPerformed?.Performed;
                    object bi_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bh_);
                    return bi_ as CqlInterval<CqlQuantity>;
                }
                else
                {
                    return null;
                }
            }

            CqlInterval<CqlDateTime> aj_ = QICoreCommon_4_0_000.Instance.toInterval(context, ai_());
            CqlDateTime ak_ = context.Operators.Start(aj_);
            return ak_;
        }

        IEnumerable<CqlDateTime> l_ = context.Operators.Select<Procedure, CqlDateTime>(j_, k_);
        IEnumerable<CqlDateTime> m_ = context.Operators.Distinct<CqlDateTime>(l_);
        IEnumerable<CqlDateTime> n_ = context.Operators.Union<CqlDateTime>(g_, m_);
        return n_;
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
                CqlInterval<CqlDateTime> h_ = CQMCommon_4_1_000.Instance.hospitalizationWithObservation(context, QualifyingEncounter);
                bool? i_ = context.Operators.In<CqlDateTime>(HospiceStatusDate, h_, "day");
                return i_;
            }

            IEnumerable<CqlDateTime> f_ = context.Operators.Where<CqlDateTime>(d_, e_);
            bool? g_ = context.Operators.Exists<CqlDateTime>(f_);
            return g_;
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
            Code<RequestStatus> o_ = DietitianReferralOrder?.StatusElement;
            RequestStatus? p_ = o_?.Value;
            Code<RequestStatus> q_ = context.Operators.Convert<Code<RequestStatus>>(p_);
            string r_ = context.Operators.Convert<string>(q_);
            string[] s_ = [
                "active",
                "completed",
                "on-hold",
            ];
            bool? t_ = context.Operators.In<string>(r_, (IEnumerable<string>)s_);
            Code<RequestIntent> u_ = DietitianReferralOrder?.IntentElement;
            RequestIntent? v_ = u_?.Value;
            Code<RequestIntent> w_ = context.Operators.Convert<Code<RequestIntent>>(v_);
            string x_ = context.Operators.Convert<string>(w_);
            string[] y_ = [
                "order",
                "original-order",
                "reflex-order",
                "filler-order",
                "instance-order",
            ];
            bool? z_ = context.Operators.In<string>(x_, (IEnumerable<string>)y_);
            bool? aa_ = context.Operators.And(t_, z_);
            return aa_;
        }

        IEnumerable<ServiceRequest> d_ = context.Operators.Where<ServiceRequest>(b_, c_);

        CqlDateTime e_(ServiceRequest DietitianReferralOrder) {
            FhirDateTime ab_ = DietitianReferralOrder?.AuthoredOnElement;
            CqlDateTime ac_ = context.Operators.Convert<CqlDateTime>(ab_);
            return ac_;
        }

        IEnumerable<CqlDateTime> f_ = context.Operators.Select<ServiceRequest, CqlDateTime>(d_, e_);
        IEnumerable<CqlDateTime> g_ = context.Operators.Distinct<CqlDateTime>(f_);
        IEnumerable<Procedure> h_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));

        bool? i_(Procedure DietitianReferralPerformed) {
            Code<EventStatus> ad_ = DietitianReferralPerformed?.StatusElement;
            EventStatus? ae_ = ad_?.Value;
            string af_ = context.Operators.Convert<string>(ae_);
            string[] ag_ = [
                "completed",
                "in-progress",
            ];
            bool? ah_ = context.Operators.In<string>(af_, (IEnumerable<string>)ag_);
            return ah_;
        }

        IEnumerable<Procedure> j_ = context.Operators.Where<Procedure>(h_, i_);

        CqlDateTime k_(Procedure DietitianReferralPerformed) {

            object ai_() {

                bool al_() {
                    DataType ap_ = DietitianReferralPerformed?.Performed;
                    object aq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ap_);
                    bool ar_ = aq_ is CqlDateTime;
                    return ar_;
                }


                bool am_() {
                    DataType as_ = DietitianReferralPerformed?.Performed;
                    object at_ = FHIRHelpers_4_4_000.Instance.ToValue(context, as_);
                    bool au_ = at_ is CqlQuantity;
                    return au_;
                }


                bool an_() {
                    DataType av_ = DietitianReferralPerformed?.Performed;
                    object aw_ = FHIRHelpers_4_4_000.Instance.ToValue(context, av_);
                    bool ax_ = aw_ is CqlInterval<CqlDateTime>;
                    return ax_;
                }


                bool ao_() {
                    DataType ay_ = DietitianReferralPerformed?.Performed;
                    object az_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ay_);
                    bool ba_ = az_ is CqlInterval<CqlQuantity>;
                    return ba_;
                }

                if (al_())
                {
                    DataType bb_ = DietitianReferralPerformed?.Performed;
                    object bc_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bb_);
                    return bc_ as CqlDateTime;
                }
                else if (am_())
                {
                    DataType bd_ = DietitianReferralPerformed?.Performed;
                    object be_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bd_);
                    return be_ as CqlQuantity;
                }
                else if (an_())
                {
                    DataType bf_ = DietitianReferralPerformed?.Performed;
                    object bg_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bf_);
                    return bg_ as CqlInterval<CqlDateTime>;
                }
                else if (ao_())
                {
                    DataType bh_ = DietitianReferralPerformed?.Performed;
                    object bi_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bh_);
                    return bi_ as CqlInterval<CqlQuantity>;
                }
                else
                {
                    return null;
                }
            }

            CqlInterval<CqlDateTime> aj_ = QICoreCommon_4_0_000.Instance.toInterval(context, ai_());
            CqlDateTime ak_ = context.Operators.Start(aj_);
            return ak_;
        }

        IEnumerable<CqlDateTime> l_ = context.Operators.Select<Procedure, CqlDateTime>(j_, k_);
        IEnumerable<CqlDateTime> m_ = context.Operators.Distinct<CqlDateTime>(l_);
        IEnumerable<CqlDateTime> n_ = context.Operators.Union<CqlDateTime>(g_, m_);
        return n_;
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
                CqlInterval<CqlDateTime> h_ = CQMCommon_4_1_000.Instance.hospitalizationWithObservation(context, QualifyingEncounter);
                bool? i_ = context.Operators.In<CqlDateTime>(DietitianReferralDate, h_, "day");
                return i_;
            }

            IEnumerable<CqlDateTime> f_ = context.Operators.Where<CqlDateTime>(d_, e_);
            bool? g_ = context.Operators.Exists<CqlDateTime>(f_);
            return g_;
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
                Code<ObservationStatus> i_ = MalnutritionRiskScreening?.StatusElement;
                ObservationStatus? j_ = i_?.Value;
                string k_ = context.Operators.Convert<string>(j_);
                string[] l_ = [
                    "final",
                    "amended",
                    "corrected",
                ];
                bool? m_ = context.Operators.In<string>(k_, (IEnumerable<string>)l_);
                CqlInterval<CqlDateTime> n_ = CQMCommon_4_1_000.Instance.hospitalizationWithObservation(context, QualifyingEncounter);
                DataType o_ = MalnutritionRiskScreening?.Effective;
                object p_ = FHIRHelpers_4_4_000.Instance.ToValue(context, o_);
                CqlInterval<CqlDateTime> q_ = QICoreCommon_4_0_000.Instance.toInterval(context, p_);
                bool? r_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(n_, q_, (string)default);
                bool? s_ = context.Operators.And(m_, r_);
                DataType t_ = MalnutritionRiskScreening?.Value;
                object u_ = FHIRHelpers_4_4_000.Instance.ToValue(context, t_);
                CqlValueSet v_ = this.Malnutrition_Screening_Finding_of_Not_At_Risk_Result(context);
                bool? w_ = context.Operators.ConceptInValueSet(u_ as CqlConcept, v_);
                bool? x_ = context.Operators.And(s_, w_);
                return x_;
            }

            IEnumerable<Observation> g_ = context.Operators.Where<Observation>(e_, f_);
            bool? h_ = context.Operators.Exists<Observation>(g_);
            return h_;
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
                Code<ObservationStatus> i_ = MalnutritionRiskScreening?.StatusElement;
                ObservationStatus? j_ = i_?.Value;
                string k_ = context.Operators.Convert<string>(j_);
                string[] l_ = [
                    "final",
                    "amended",
                    "corrected",
                ];
                bool? m_ = context.Operators.In<string>(k_, (IEnumerable<string>)l_);
                CqlInterval<CqlDateTime> n_ = CQMCommon_4_1_000.Instance.hospitalizationWithObservation(context, QualifyingEncounter);
                DataType o_ = MalnutritionRiskScreening?.Effective;
                object p_ = FHIRHelpers_4_4_000.Instance.ToValue(context, o_);
                CqlInterval<CqlDateTime> q_ = QICoreCommon_4_0_000.Instance.toInterval(context, p_);
                bool? r_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(n_, q_, (string)default);
                bool? s_ = context.Operators.And(m_, r_);
                DataType t_ = MalnutritionRiskScreening?.Value;
                object u_ = FHIRHelpers_4_4_000.Instance.ToValue(context, t_);
                CqlValueSet v_ = this.Malnutrition_Screening_Finding_of_At_Risk_Result(context);
                bool? w_ = context.Operators.ConceptInValueSet(u_ as CqlConcept, v_);
                bool? x_ = context.Operators.And(s_, w_);
                return x_;
            }

            IEnumerable<Observation> g_ = context.Operators.Where<Observation>(e_, f_);
            bool? h_ = context.Operators.Exists<Observation>(g_);
            return h_;
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
            Code<ObservationStatus> i_ = NutritionAssessment?.StatusElement;
            ObservationStatus? j_ = i_?.Value;
            string k_ = context.Operators.Convert<string>(j_);
            string[] l_ = [
                "final",
                "amended",
                "corrected",
            ];
            bool? m_ = context.Operators.In<string>(k_, (IEnumerable<string>)l_);
            CqlInterval<CqlDateTime> n_ = CQMCommon_4_1_000.Instance.hospitalizationWithObservation(context, QualifyingEncounter);
            DataType o_ = NutritionAssessment?.Effective;
            object p_ = FHIRHelpers_4_4_000.Instance.ToValue(context, o_);
            CqlInterval<CqlDateTime> q_ = QICoreCommon_4_0_000.Instance.toInterval(context, p_);
            bool? r_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(n_, q_, (string)default);
            bool? s_ = context.Operators.And(m_, r_);
            DataType t_ = NutritionAssessment?.Value;
            object u_ = FHIRHelpers_4_4_000.Instance.ToValue(context, t_);
            bool? v_ = context.Operators.Not((bool?)(u_ is null));
            bool? w_ = context.Operators.And(s_, v_);
            return w_;
        }

        IEnumerable<Observation> d_ = context.Operators.Where<Observation>(b_, c_);

        CqlDateTime e_(Observation NutritionAssessment) {

            object x_() {

                bool z_() {
                    DataType ac_ = NutritionAssessment?.Effective;
                    object ad_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ac_);
                    bool ae_ = ad_ is CqlDateTime;
                    return ae_;
                }


                bool aa_() {
                    DataType af_ = NutritionAssessment?.Effective;
                    object ag_ = FHIRHelpers_4_4_000.Instance.ToValue(context, af_);
                    bool ah_ = ag_ is CqlDateTime;
                    return ah_;
                }


                bool ab_() {
                    DataType ai_ = NutritionAssessment?.Effective;
                    object aj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ai_);
                    bool ak_ = aj_ is CqlInterval<CqlDateTime>;
                    return ak_;
                }

                if (z_())
                {
                    DataType al_ = NutritionAssessment?.Effective;
                    object am_ = FHIRHelpers_4_4_000.Instance.ToValue(context, al_);
                    return am_ as CqlDateTime;
                }
                else if (aa_())
                {
                    DataType an_ = NutritionAssessment?.Effective;
                    object ao_ = FHIRHelpers_4_4_000.Instance.ToValue(context, an_);
                    return ao_ as CqlDateTime;
                }
                else if (ab_())
                {
                    DataType ap_ = NutritionAssessment?.Effective;
                    object aq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ap_);
                    return aq_ as CqlInterval<CqlDateTime>;
                }
                else
                {
                    return null;
                }
            }

            CqlDateTime y_ = QICoreCommon_4_0_000.Instance.latest(context, x_());
            return y_;
        }

        IEnumerable<CqlDateTime> f_ = context.Operators.Select<Observation, CqlDateTime>(d_, e_);
        IEnumerable<CqlDateTime> g_ = context.Operators.Distinct<CqlDateTime>(f_);
        CqlDateTime h_ = context.Operators.Max<CqlDateTime>(g_);
        return h_;
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
                Code<ObservationStatus> i_ = NutritionAssessment?.StatusElement;
                ObservationStatus? j_ = i_?.Value;
                string k_ = context.Operators.Convert<string>(j_);
                string[] l_ = [
                    "final",
                    "amended",
                    "corrected",
                ];
                bool? m_ = context.Operators.In<string>(k_, (IEnumerable<string>)l_);
                CqlInterval<CqlDateTime> n_ = CQMCommon_4_1_000.Instance.hospitalizationWithObservation(context, QualifyingEncounter);
                DataType o_ = NutritionAssessment?.Effective;
                object p_ = FHIRHelpers_4_4_000.Instance.ToValue(context, o_);
                CqlInterval<CqlDateTime> q_ = QICoreCommon_4_0_000.Instance.toInterval(context, p_);
                bool? r_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(n_, q_, (string)default);
                bool? s_ = context.Operators.And(m_, r_);
                DataType t_ = NutritionAssessment?.Value;
                object u_ = FHIRHelpers_4_4_000.Instance.ToValue(context, t_);
                CqlValueSet v_ = this.Nutrition_Assessment_Status_Finding_of_Well_Nourished_or_Not_Malnourished_or_Mildly_Malnourished(context);
                bool? w_ = context.Operators.ConceptInValueSet(u_ as CqlConcept, v_);
                CqlValueSet x_ = this.Nutrition_Assessment_Status_Finding_of_Moderately_Malnourished(context);
                bool? y_ = context.Operators.ConceptInValueSet(u_ as CqlConcept, x_);
                bool? z_ = context.Operators.Or(w_, y_);
                CqlValueSet aa_ = this.Nutrition_Assessment_Status_Finding_of_Severely_Malnourished(context);
                bool? ab_ = context.Operators.ConceptInValueSet(u_ as CqlConcept, aa_);
                bool? ac_ = context.Operators.Or(z_, ab_);
                bool? ad_ = context.Operators.And(s_, ac_);

                object ae_() {

                    bool aj_() {
                        DataType am_ = NutritionAssessment?.Effective;
                        object an_ = FHIRHelpers_4_4_000.Instance.ToValue(context, am_);
                        bool ao_ = an_ is CqlDateTime;
                        return ao_;
                    }


                    bool ak_() {
                        DataType ap_ = NutritionAssessment?.Effective;
                        object aq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ap_);
                        bool ar_ = aq_ is CqlDateTime;
                        return ar_;
                    }


                    bool al_() {
                        DataType as_ = NutritionAssessment?.Effective;
                        object at_ = FHIRHelpers_4_4_000.Instance.ToValue(context, as_);
                        bool au_ = at_ is CqlInterval<CqlDateTime>;
                        return au_;
                    }

                    if (aj_())
                    {
                        DataType av_ = NutritionAssessment?.Effective;
                        object aw_ = FHIRHelpers_4_4_000.Instance.ToValue(context, av_);
                        return aw_ as CqlDateTime;
                    }
                    else if (ak_())
                    {
                        DataType ax_ = NutritionAssessment?.Effective;
                        object ay_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ax_);
                        return ay_ as CqlDateTime;
                    }
                    else if (al_())
                    {
                        DataType az_ = NutritionAssessment?.Effective;
                        object ba_ = FHIRHelpers_4_4_000.Instance.ToValue(context, az_);
                        return ba_ as CqlInterval<CqlDateTime>;
                    }
                    else
                    {
                        return null;
                    }
                }

                CqlDateTime af_ = QICoreCommon_4_0_000.Instance.latest(context, ae_());
                CqlDateTime ag_ = this.Last_Nutrition_Assessment_Day_During_Encounter(context, QualifyingEncounter);
                bool? ah_ = context.Operators.SameAs(af_, ag_, "day");
                bool? ai_ = context.Operators.And(ad_, ah_);
                return ai_;
            }

            IEnumerable<Observation> g_ = context.Operators.Where<Observation>(e_, f_);
            bool? h_ = context.Operators.Exists<Observation>(g_);
            return h_;
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
                Code<ObservationStatus> i_ = NutritionAssessment?.StatusElement;
                ObservationStatus? j_ = i_?.Value;
                string k_ = context.Operators.Convert<string>(j_);
                string[] l_ = [
                    "final",
                    "amended",
                    "corrected",
                ];
                bool? m_ = context.Operators.In<string>(k_, (IEnumerable<string>)l_);
                CqlInterval<CqlDateTime> n_ = CQMCommon_4_1_000.Instance.hospitalizationWithObservation(context, QualifyingEncounter);
                DataType o_ = NutritionAssessment?.Effective;
                object p_ = FHIRHelpers_4_4_000.Instance.ToValue(context, o_);
                CqlInterval<CqlDateTime> q_ = QICoreCommon_4_0_000.Instance.toInterval(context, p_);
                bool? r_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(n_, q_, (string)default);
                bool? s_ = context.Operators.And(m_, r_);
                DataType t_ = NutritionAssessment?.Value;
                object u_ = FHIRHelpers_4_4_000.Instance.ToValue(context, t_);
                CqlValueSet v_ = this.Nutrition_Assessment_Status_Finding_of_Moderately_Malnourished(context);
                bool? w_ = context.Operators.ConceptInValueSet(u_ as CqlConcept, v_);
                CqlValueSet x_ = this.Nutrition_Assessment_Status_Finding_of_Severely_Malnourished(context);
                bool? y_ = context.Operators.ConceptInValueSet(u_ as CqlConcept, x_);
                bool? z_ = context.Operators.Or(w_, y_);
                bool? aa_ = context.Operators.And(s_, z_);

                object ab_() {

                    bool ag_() {
                        DataType aj_ = NutritionAssessment?.Effective;
                        object ak_ = FHIRHelpers_4_4_000.Instance.ToValue(context, aj_);
                        bool al_ = ak_ is CqlDateTime;
                        return al_;
                    }


                    bool ah_() {
                        DataType am_ = NutritionAssessment?.Effective;
                        object an_ = FHIRHelpers_4_4_000.Instance.ToValue(context, am_);
                        bool ao_ = an_ is CqlDateTime;
                        return ao_;
                    }


                    bool ai_() {
                        DataType ap_ = NutritionAssessment?.Effective;
                        object aq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ap_);
                        bool ar_ = aq_ is CqlInterval<CqlDateTime>;
                        return ar_;
                    }

                    if (ag_())
                    {
                        DataType as_ = NutritionAssessment?.Effective;
                        object at_ = FHIRHelpers_4_4_000.Instance.ToValue(context, as_);
                        return at_ as CqlDateTime;
                    }
                    else if (ah_())
                    {
                        DataType au_ = NutritionAssessment?.Effective;
                        object av_ = FHIRHelpers_4_4_000.Instance.ToValue(context, au_);
                        return av_ as CqlDateTime;
                    }
                    else if (ai_())
                    {
                        DataType aw_ = NutritionAssessment?.Effective;
                        object ax_ = FHIRHelpers_4_4_000.Instance.ToValue(context, aw_);
                        return ax_ as CqlInterval<CqlDateTime>;
                    }
                    else
                    {
                        return null;
                    }
                }

                CqlDateTime ac_ = QICoreCommon_4_0_000.Instance.latest(context, ab_());
                CqlDateTime ad_ = this.Last_Nutrition_Assessment_Day_During_Encounter(context, QualifyingEncounter);
                bool? ae_ = context.Operators.SameAs(ac_, ad_, "day");
                bool? af_ = context.Operators.And(aa_, ae_);
                return af_;
            }

            IEnumerable<Observation> g_ = context.Operators.Where<Observation>(e_, f_);
            bool? h_ = context.Operators.Exists<Observation>(g_);
            return h_;
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
                Code<ObservationStatus> i_ = NutritionAssessment?.StatusElement;
                ObservationStatus? j_ = i_?.Value;
                string k_ = context.Operators.Convert<string>(j_);
                string[] l_ = [
                    "final",
                    "amended",
                    "corrected",
                ];
                bool? m_ = context.Operators.In<string>(k_, (IEnumerable<string>)l_);
                CqlInterval<CqlDateTime> n_ = CQMCommon_4_1_000.Instance.hospitalizationWithObservation(context, QualifyingEncounter);
                DataType o_ = NutritionAssessment?.Effective;
                object p_ = FHIRHelpers_4_4_000.Instance.ToValue(context, o_);
                CqlInterval<CqlDateTime> q_ = QICoreCommon_4_0_000.Instance.toInterval(context, p_);
                bool? r_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(n_, q_, (string)default);
                bool? s_ = context.Operators.And(m_, r_);
                DataType t_ = NutritionAssessment?.Value;
                object u_ = FHIRHelpers_4_4_000.Instance.ToValue(context, t_);
                CqlValueSet v_ = this.Nutrition_Assessment_Status_Finding_of_Well_Nourished_or_Not_Malnourished_or_Mildly_Malnourished(context);
                bool? w_ = context.Operators.ConceptInValueSet(u_ as CqlConcept, v_);
                bool? x_ = context.Operators.And(s_, w_);

                object y_() {

                    bool ad_() {
                        DataType ag_ = NutritionAssessment?.Effective;
                        object ah_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ag_);
                        bool ai_ = ah_ is CqlDateTime;
                        return ai_;
                    }


                    bool ae_() {
                        DataType aj_ = NutritionAssessment?.Effective;
                        object ak_ = FHIRHelpers_4_4_000.Instance.ToValue(context, aj_);
                        bool al_ = ak_ is CqlDateTime;
                        return al_;
                    }


                    bool af_() {
                        DataType am_ = NutritionAssessment?.Effective;
                        object an_ = FHIRHelpers_4_4_000.Instance.ToValue(context, am_);
                        bool ao_ = an_ is CqlInterval<CqlDateTime>;
                        return ao_;
                    }

                    if (ad_())
                    {
                        DataType ap_ = NutritionAssessment?.Effective;
                        object aq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ap_);
                        return aq_ as CqlDateTime;
                    }
                    else if (ae_())
                    {
                        DataType ar_ = NutritionAssessment?.Effective;
                        object as_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ar_);
                        return as_ as CqlDateTime;
                    }
                    else if (af_())
                    {
                        DataType at_ = NutritionAssessment?.Effective;
                        object au_ = FHIRHelpers_4_4_000.Instance.ToValue(context, at_);
                        return au_ as CqlInterval<CqlDateTime>;
                    }
                    else
                    {
                        return null;
                    }
                }

                CqlDateTime z_ = QICoreCommon_4_0_000.Instance.latest(context, y_());
                CqlDateTime aa_ = this.Last_Nutrition_Assessment_Day_During_Encounter(context, QualifyingEncounter);
                bool? ab_ = context.Operators.SameAs(z_, aa_, "day");
                bool? ac_ = context.Operators.And(x_, ab_);
                return ac_;
            }

            IEnumerable<Observation> g_ = context.Operators.Where<Observation>(e_, f_);
            bool? h_ = context.Operators.Exists<Observation>(g_);
            return h_;
        }

        IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);
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
            bool? h_ = this.isVerified(context, MalnutritionDiagnosis as Condition);
            bool? i_ = context.Operators.And(g_, h_);
            return i_;
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
                CqlConcept q_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);
                return q_;
            }

            IEnumerable<CqlConcept> f_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)d_, e_);
            CqlValueSet g_ = this.Malnutrition_Diagnosis(context);
            bool? h_ = context.Operators.ConceptsInValueSet(f_, g_);
            IEnumerable<Condition> i_ = CQMCommon_4_1_000.Instance.encounterDiagnosis(context, QualifyingEncounter);
            IEnumerable<Condition> j_ = Status_1_15_000.Instance.verified(context, i_);

            bool? k_(Condition @this) {
                CodeableConcept r_ = @this?.Code;
                CqlConcept s_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, r_);
                bool? t_ = context.Operators.Not((bool?)(s_ is null));
                return t_;
            }

            IEnumerable<Condition> l_ = context.Operators.Where<Condition>(j_, k_);

            CqlConcept m_(Condition @this) {
                CodeableConcept u_ = @this?.Code;
                CqlConcept v_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, u_);
                return v_;
            }

            IEnumerable<CqlConcept> n_ = context.Operators.Select<Condition, CqlConcept>(l_, m_);
            bool? o_ = context.Operators.ConceptsInValueSet(n_, g_);
            bool? p_ = context.Operators.Or(h_, o_);
            return p_;
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
                CqlInterval<CqlDateTime> j_ = QICoreCommon_4_0_000.Instance.prevalenceInterval(context, MalnutritionDiagnosis as Condition);
                CqlInterval<CqlDateTime> k_ = CQMCommon_4_1_000.Instance.hospitalizationWithObservation(context, QualifyingEncounter);
                bool? l_ = context.Operators.Overlaps(j_, k_, "day");
                return l_;
            }

            IEnumerable<Condition> h_ = context.Operators.Where<Condition>(f_, g_);
            bool? i_ = context.Operators.Exists<Condition>(h_);
            return i_;
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
                Code<EventStatus> i_ = NutritionCarePlan?.StatusElement;
                EventStatus? j_ = i_?.Value;
                string k_ = context.Operators.Convert<string>(j_);
                string[] l_ = [
                    "completed",
                    "in-progress",
                ];
                bool? m_ = context.Operators.In<string>(k_, (IEnumerable<string>)l_);
                DataType n_ = NutritionCarePlan?.Performed;
                object o_ = FHIRHelpers_4_4_000.Instance.ToValue(context, n_);
                CqlDateTime p_ = QICoreCommon_4_0_000.Instance.earliest(context, o_);
                CqlInterval<CqlDateTime> q_ = CQMCommon_4_1_000.Instance.hospitalizationWithObservation(context, QualifyingEncounter);
                bool? r_ = context.Operators.In<CqlDateTime>(p_, q_, (string)default);
                bool? s_ = context.Operators.And(m_, r_);
                return s_;
            }

            IEnumerable<Procedure> g_ = context.Operators.Where<Procedure>(e_, f_);
            bool? h_ = context.Operators.Exists<Procedure>(g_);
            return h_;
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

        int? a_() {

            bool b_() {
                IEnumerable<Encounter> d_ = this.Encounters_with_Malnutrition_Not_At_Risk_Screening_and_without_Dietitian_Referral(context);
                bool? e_ = context.Operators.Contains<Encounter>(d_, NutritionAssessment);
                return e_ ?? false;
            }


            bool c_() {
                IEnumerable<Encounter> f_ = this.Encounters_with_Malnutrition_Risk_Screening_At_Risk_or_with_Dietitian_Referral(context);
                bool? g_ = context.Operators.Contains<Encounter>(f_, NutritionAssessment);
                return g_ ?? false;
            }

            if (b_())
            {
                return 0;
            }
            else if (c_())
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

        return a_();
    }


    [CqlFunctionDefinition("Measure Observation 3")]
    public int? Measure_Observation_3(CqlContext context, Encounter MalnutritionDiagnosis)
    {

        int? a_() {

            bool b_() {
                IEnumerable<Encounter> d_ = this.Encounters_with_Malnutrition_Not_At_Risk_Screening_and_without_Dietitian_Referral(context);
                bool? e_ = context.Operators.Contains<Encounter>(d_, MalnutritionDiagnosis);
                return e_ ?? false;
            }


            bool c_() {
                IEnumerable<Encounter> f_ = this.Encounters_with_Malnutrition_Risk_Screening_At_Risk_or_with_Dietitian_Referral(context);
                bool? g_ = context.Operators.Contains<Encounter>(f_, MalnutritionDiagnosis);
                return g_ ?? false;
            }

            if (b_())
            {
                return 0;
            }
            else if (c_())
            {

                int? h_() {

                    bool i_() {
                        IEnumerable<Encounter> j_ = this.Encounters_with_Malnutrition_Diagnosis(context);
                        bool? k_ = context.Operators.Contains<Encounter>(j_, MalnutritionDiagnosis);
                        return k_ ?? false;
                    }

                    if (i_())
                    {

                        int? l_() {

                            bool m_() {
                                IEnumerable<Encounter> o_ = this.Encounter_With_Most_Recent_Nutrition_Assessment_Status_of_Not_or_Mildly_Malnourished(context);
                                bool? p_ = context.Operators.Contains<Encounter>(o_, MalnutritionDiagnosis);
                                return p_ ?? false;
                            }


                            bool n_() {
                                IEnumerable<Encounter> q_ = this.Encounter_With_Most_Recent_Nutrition_Assessment_Status_of_Moderately_Or_Severely_Malnourished(context);
                                bool? r_ = context.Operators.Contains<Encounter>(q_, MalnutritionDiagnosis);
                                return r_ ?? false;
                            }

                            if (m_())
                            {
                                return 0;
                            }
                            else if (n_())
                            {
                                return 1;
                            }
                            else
                            {
                                return 0;
                            }
                        }

                        return l_();
                    }
                    else
                    {
                        return 0;
                    }
                }

                return h_();
            }
            else
            {
                return 0;
            }
        }

        return a_();
    }


    [CqlFunctionDefinition("Measure Observation 4")]
    public int? Measure_Observation_4(CqlContext context, Encounter NutritionCarePlan)
    {

        int? a_() {

            bool b_() {
                IEnumerable<Encounter> d_ = this.Encounters_with_Malnutrition_Not_At_Risk_Screening_and_without_Dietitian_Referral(context);
                bool? e_ = context.Operators.Contains<Encounter>(d_, NutritionCarePlan);
                return e_ ?? false;
            }


            bool c_() {
                IEnumerable<Encounter> f_ = this.Encounters_with_Malnutrition_Risk_Screening_At_Risk_or_with_Dietitian_Referral(context);
                bool? g_ = context.Operators.Contains<Encounter>(f_, NutritionCarePlan);
                return g_ ?? false;
            }

            if (b_())
            {
                return 0;
            }
            else if (c_())
            {

                int? h_() {

                    bool i_() {
                        IEnumerable<Encounter> j_ = this.Encounters_with_Nutrition_Care_Plan(context);
                        bool? k_ = context.Operators.Contains<Encounter>(j_, NutritionCarePlan);
                        return k_ ?? false;
                    }

                    if (i_())
                    {

                        int? l_() {

                            bool m_() {
                                IEnumerable<Encounter> o_ = this.Encounter_With_Most_Recent_Nutrition_Assessment_Status_of_Not_or_Mildly_Malnourished(context);
                                bool? p_ = context.Operators.Contains<Encounter>(o_, NutritionCarePlan);
                                return p_ ?? false;
                            }


                            bool n_() {
                                IEnumerable<Encounter> q_ = this.Encounter_With_Most_Recent_Nutrition_Assessment_Status_of_Moderately_Or_Severely_Malnourished(context);
                                bool? r_ = context.Operators.Contains<Encounter>(q_, NutritionCarePlan);
                                return r_ ?? false;
                            }

                            if (m_())
                            {
                                return 0;
                            }
                            else if (n_())
                            {
                                return 1;
                            }
                            else
                            {
                                return 0;
                            }
                        }

                        return l_();
                    }
                    else
                    {
                        return 0;
                    }
                }

                return h_();
            }
            else
            {
                return 0;
            }
        }

        return a_();
    }


    [CqlFunctionDefinition("Total Malnutrition Care Score Eligible Occurrences")]
    public int? Total_Malnutrition_Care_Score_Eligible_Occurrences(CqlContext context, Encounter QualifyingEncounter)
    {

        int? a_() {

            bool b_() {
                IEnumerable<Encounter> d_ = this.Encounters_with_Malnutrition_Risk_Screening_or_with_Dietitian_Referral(context);
                bool? e_ = context.Operators.Contains<Encounter>(d_, QualifyingEncounter);
                IEnumerable<Encounter> f_ = this.Encounters_with_Malnutrition_Risk_Screening_Not_At_Risk(context);
                bool? g_ = context.Operators.Contains<Encounter>(f_, QualifyingEncounter);
                bool? h_ = context.Operators.And(e_, g_);
                IEnumerable<Encounter> i_ = this.Encounters_with_Dietitian_Referral(context);
                bool? j_ = context.Operators.Contains<Encounter>(i_, QualifyingEncounter);
                bool? k_ = context.Operators.Not(j_);
                bool? l_ = context.Operators.And(h_, k_);
                return l_ ?? false;
            }


            bool c_() {
                IEnumerable<Encounter> m_ = this.Encounters_with_Malnutrition_Risk_Screening_or_with_Dietitian_Referral(context);
                bool? n_ = context.Operators.Contains<Encounter>(m_, QualifyingEncounter);
                IEnumerable<Encounter> o_ = this.Encounters_with_Malnutrition_Risk_Screening_At_Risk(context);
                bool? p_ = context.Operators.Contains<Encounter>(o_, QualifyingEncounter);
                bool? q_ = context.Operators.And(n_, p_);
                IEnumerable<Encounter> r_ = this.Encounters_with_Dietitian_Referral(context);
                bool? s_ = context.Operators.Contains<Encounter>(r_, QualifyingEncounter);
                bool? t_ = context.Operators.Or(q_, s_);
                IEnumerable<Encounter> u_ = this.Encounter_With_Most_Recent_Nutrition_Assessment_Status_of_Not_or_Mildly_Malnourished(context);
                bool? v_ = context.Operators.Contains<Encounter>(u_, QualifyingEncounter);
                bool? w_ = context.Operators.And(t_, v_);
                IEnumerable<Encounter> x_ = this.Encounter_With_Most_Recent_Nutrition_Assessment_And_Identified_Status(context);
                bool? y_ = context.Operators.Contains<Encounter>(x_, QualifyingEncounter);
                bool? z_ = context.Operators.Not(y_);
                bool? aa_ = context.Operators.Or(w_, z_);
                return aa_ ?? false;
            }

            if (b_())
            {
                return 1;
            }
            else if (c_())
            {
                return 2;
            }
            else
            {
                return 4;
            }
        }

        return a_();
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

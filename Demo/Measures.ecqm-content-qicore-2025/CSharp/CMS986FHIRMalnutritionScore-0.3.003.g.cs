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

[System.CodeDom.Compiler.GeneratedCode(".NET Code Generation", "3.1.0.0")]
[CqlLibrary("CMS986FHIRMalnutritionScore", "0.3.003")]
public partial class CMS986FHIRMalnutritionScore_0_3_003 : ILibrary, ISingleton<CMS986FHIRMalnutritionScore_0_3_003>
{
    private CMS986FHIRMalnutritionScore_0_3_003() {}

    public static CMS986FHIRMalnutritionScore_0_3_003 Instance { get; } = new();

    #region ILibrary Implementation

    public string Name => "CMS986FHIRMalnutritionScore";
    public string Version => "0.3.003";
    public ILibrary[] Dependencies => [FHIRHelpers_4_4_000.Instance, SupplementalDataElements_5_1_000.Instance, QICoreCommon_4_0_000.Instance, CQMCommon_4_1_000.Instance];

    #endregion ILibrary Implementation

    #region ValueSets

    [CqlValueSetDefinition("Emergency Department Visit", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.292", valueSetVersion: null)]
    public CqlValueSet Emergency_Department_Visit(CqlContext _) => _Emergency_Department_Visit;
    private static readonly CqlValueSet _Emergency_Department_Visit = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.292", null);

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

    [CqlValueSetDefinition("Observation Services", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1111.143", valueSetVersion: null)]
    public CqlValueSet Observation_Services(CqlContext _) => _Observation_Services;
    private static readonly CqlValueSet _Observation_Services = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1111.143", null);

    #endregion ValueSets

    #region Codes

    [CqlCodeDefinition("Birth date", codeId: "21112-8", codeSystem: "http://loinc.org")]
    public CqlCode Birth_date(CqlContext _) => _Birth_date;
    private static readonly CqlCode _Birth_date = new CqlCode("21112-8", "http://loinc.org");

    #endregion Codes

    #region CodeSystems

    [CqlCodeSystemDefinition("LOINC", codeSystemId: "http://loinc.org", codeSystemVersion: null)]
    public CqlCodeSystem LOINC(CqlContext _) => _LOINC;
    private static readonly CqlCodeSystem _LOINC =
      new CqlCodeSystem("http://loinc.org", null, [
          _Birth_date]);

    [CqlCodeSystemDefinition("SNOMEDCT", codeSystemId: "http://snomed.info/sct", codeSystemVersion: null)]
    public CqlCodeSystem SNOMEDCT(CqlContext _) => _SNOMEDCT;
    private static readonly CqlCodeSystem _SNOMEDCT =
      new CqlCodeSystem("http://snomed.info/sct", null, []);

    [CqlCodeSystemDefinition("ICD10CM", codeSystemId: "http://hl7.org/fhir/sid/icd-10-cm", codeSystemVersion: null)]
    public CqlCodeSystem ICD10CM(CqlContext _) => _ICD10CM;
    private static readonly CqlCodeSystem _ICD10CM =
      new CqlCodeSystem("http://hl7.org/fhir/sid/icd-10-cm", null, []);

    #endregion CodeSystems

    #region Parameters

    [CqlParameterDefinition("Measurement Period")]
    public CqlInterval<CqlDateTime> Measurement_Period(CqlContext context)
    {
        object a_ = context.ResolveParameter("CMS986FHIRMalnutritionScore-0.3.003", "Measurement Period", null);

        return (CqlInterval<CqlDateTime>)a_;
    }


    #endregion Parameters

    #region Functions and Expressions

    [CqlExpressionDefinition("Patient")]
    public Patient Patient(CqlContext context)
    {
        IEnumerable<Patient> a_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-patient"));
        Patient b_ = context.Operators.SingletonFrom<Patient>(a_);

        return b_;
    }


    [CqlExpressionDefinition("SDE Ethnicity")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Ethnicity(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? a_ = SupplementalDataElements_5_1_000.Instance.SDE_Ethnicity(context);

        return a_;
    }


    [CqlExpressionDefinition("SDE Payer Type")]
    public IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> SDE_Payer_Type(CqlContext context)
    {
        IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> a_ = SupplementalDataElements_5_1_000.Instance.SDE_Payer(context);

        return a_;
    }


    [CqlExpressionDefinition("SDE Race")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Race(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? a_ = SupplementalDataElements_5_1_000.Instance.SDE_Race(context);

        return a_;
    }


    [CqlExpressionDefinition("SDE Sex")]
    public CqlCode SDE_Sex(CqlContext context)
    {
        CqlCode a_ = SupplementalDataElements_5_1_000.Instance.SDE_Sex(context);

        return a_;
    }


    [CqlExpressionDefinition("Initial Population")]
    public IEnumerable<Encounter> Initial_Population(CqlContext context)
    {
        CqlValueSet a_ = this.Encounter_Inpatient(context);
        IEnumerable<Encounter> b_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        bool? c_(Encounter EncounterInpatient)
        {
            Period e_ = EncounterInpatient?.Period;
            CqlInterval<CqlDateTime> f_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, e_);
            CqlDateTime g_ = context.Operators.End(f_);
            CqlInterval<CqlDateTime> h_ = this.Measurement_Period(context);
            bool? i_ = context.Operators.In<CqlDateTime>(g_, h_, "day");
            Patient j_ = this.Patient(context);
            Date k_ = j_?.BirthDateElement;
            string l_ = k_?.Value;
            CqlDate m_ = context.Operators.ConvertStringToDate(l_);
            CqlInterval<CqlDateTime> o_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, e_);
            CqlDateTime p_ = context.Operators.Start(o_);
            CqlDate q_ = context.Operators.DateFrom(p_);
            int? r_ = context.Operators.CalculateAgeAt(m_, q_, "year");
            bool? s_ = context.Operators.GreaterOrEqual(r_, 18);
            bool? t_ = context.Operators.And(i_, s_);
            CqlInterval<CqlDateTime> v_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, e_);
            CqlDateTime w_ = context.Operators.Start(v_);
            CqlInterval<CqlDateTime> y_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, e_);
            CqlDateTime z_ = context.Operators.End(y_);
            int? aa_ = context.Operators.DurationBetween(w_, z_, "hour");
            bool? ab_ = context.Operators.GreaterOrEqual(aa_, 24);
            bool? ac_ = context.Operators.And(t_, ab_);
            Code<Encounter.EncounterStatus> ad_ = EncounterInpatient?.StatusElement;
            Encounter.EncounterStatus? ae_ = ad_?.Value;
            Code<Encounter.EncounterStatus> af_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(ae_);
            bool? ag_ = context.Operators.Equal(af_, "finished");
            bool? ah_ = context.Operators.And(ac_, ag_);

            return ah_;
        };
        IEnumerable<Encounter> d_ = context.Operators.Where<Encounter>(b_, c_);

        return d_;
    }


    [CqlExpressionDefinition("Measure Population")]
    public IEnumerable<Encounter> Measure_Population(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Initial_Population(context);

        return a_;
    }


    [CqlExpressionDefinition("Encounter with Discharge for Hospice Care")]
    public IEnumerable<Encounter> Encounter_with_Discharge_for_Hospice_Care(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Measure_Population(context);
        bool? b_(Encounter QualifyingEncounter)
        {
            Encounter.HospitalizationComponent d_ = QualifyingEncounter?.Hospitalization;
            CodeableConcept e_ = d_?.DischargeDisposition;
            CqlConcept f_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, e_);
            CqlValueSet g_ = this.Hospice_Care_Referral_or_Admission(context);
            bool? h_ = context.Operators.ConceptInValueSet(f_, g_);

            return h_;
        };
        IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);

        return c_;
    }


    [CqlExpressionDefinition("Intervention Hospice Care")]
    public IEnumerable<object> Intervention_Hospice_Care(CqlContext context)
    {
        CqlValueSet a_ = this.Hospice_Status(context);
        IEnumerable<ServiceRequest> b_ = context.Operators.Retrieve<ServiceRequest>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-servicerequest"));
        bool? c_(ServiceRequest HospiceStatusOrder)
        {
            Code<RequestStatus> j_ = HospiceStatusOrder?.StatusElement;
            RequestStatus? k_ = j_?.Value;
            Code<RequestStatus> l_ = context.Operators.Convert<Code<RequestStatus>>(k_);
            string m_ = context.Operators.Convert<string>(l_);
            string[] n_ = [
                "active",
                "completed",
                "on-hold",
            ];
            bool? o_ = context.Operators.In<string>(m_, (IEnumerable<string>)n_);
            Code<RequestIntent> p_ = HospiceStatusOrder?.IntentElement;
            RequestIntent? q_ = p_?.Value;
            Code<RequestIntent> r_ = context.Operators.Convert<Code<RequestIntent>>(q_);
            string s_ = context.Operators.Convert<string>(r_);
            string[] t_ = [
                "order",
                "original-order",
                "reflex-order",
                "filler-order",
                "instance-order",
            ];
            bool? u_ = context.Operators.In<string>(s_, (IEnumerable<string>)t_);
            bool? v_ = context.Operators.And(o_, u_);
            FhirBoolean w_ = HospiceStatusOrder?.DoNotPerformElement;
            bool? x_ = w_?.Value;
            bool? y_ = context.Operators.IsTrue(x_);
            bool? z_ = context.Operators.Not(y_);
            bool? aa_ = context.Operators.And(v_, z_);

            return aa_;
        };
        IEnumerable<ServiceRequest> d_ = context.Operators.Where<ServiceRequest>(b_, c_);
        IEnumerable<Procedure> f_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
        bool? g_(Procedure HospiceStatusPerformed)
        {
            Code<EventStatus> ab_ = HospiceStatusPerformed?.StatusElement;
            EventStatus? ac_ = ab_?.Value;
            string ad_ = context.Operators.Convert<string>(ac_);
            string[] ae_ = [
                "completed",
                "in-progress",
            ];
            bool? af_ = context.Operators.In<string>(ad_, (IEnumerable<string>)ae_);

            return af_;
        };
        IEnumerable<Procedure> h_ = context.Operators.Where<Procedure>(f_, g_);
        IEnumerable<object> i_ = context.Operators.Union<object>(d_ as IEnumerable<object>, h_ as IEnumerable<object>);

        return i_;
    }


    [CqlExpressionDefinition("Encounter with Hospice during Eligible Encounter")]
    public IEnumerable<Encounter> Encounter_with_Hospice_during_Eligible_Encounter(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Measure_Population(context);
        IEnumerable<Encounter> b_(Encounter QualifyingEncounter)
        {
            IEnumerable<object> d_ = this.Intervention_Hospice_Care(context);
            bool? e_(object HospiceStatus)
            {
                object i_()
                {
                    bool p_()
                    {
                        object t_ = context.Operators.LateBoundProperty<object>(HospiceStatus, "performed");
                        object u_ = FHIRHelpers_4_4_000.Instance.ToValue(context, t_);
                        bool v_ = u_ is CqlDateTime;

                        return v_;
                    };
                    bool q_()
                    {
                        object w_ = context.Operators.LateBoundProperty<object>(HospiceStatus, "performed");
                        object x_ = FHIRHelpers_4_4_000.Instance.ToValue(context, w_);
                        bool y_ = x_ is CqlInterval<CqlDateTime>;

                        return y_;
                    };
                    bool r_()
                    {
                        object z_ = context.Operators.LateBoundProperty<object>(HospiceStatus, "performed");
                        object aa_ = FHIRHelpers_4_4_000.Instance.ToValue(context, z_);
                        bool ab_ = aa_ is CqlQuantity;

                        return ab_;
                    };
                    bool s_()
                    {
                        object ac_ = context.Operators.LateBoundProperty<object>(HospiceStatus, "performed");
                        object ad_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ac_);
                        bool ae_ = ad_ is CqlInterval<CqlQuantity>;

                        return ae_;
                    };
                    if (p_())
                    {
                        object af_ = context.Operators.LateBoundProperty<object>(HospiceStatus, "performed");
                        object ag_ = FHIRHelpers_4_4_000.Instance.ToValue(context, af_);

                        return (ag_ as CqlDateTime) as object;
                    }
                    else if (q_())
                    {
                        object ah_ = context.Operators.LateBoundProperty<object>(HospiceStatus, "performed");
                        object ai_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ah_);

                        return (ai_ as CqlInterval<CqlDateTime>) as object;
                    }
                    else if (r_())
                    {
                        object aj_ = context.Operators.LateBoundProperty<object>(HospiceStatus, "performed");
                        object ak_ = FHIRHelpers_4_4_000.Instance.ToValue(context, aj_);

                        return (ak_ as CqlQuantity) as object;
                    }
                    else if (s_())
                    {
                        object al_ = context.Operators.LateBoundProperty<object>(HospiceStatus, "performed");
                        object am_ = FHIRHelpers_4_4_000.Instance.ToValue(context, al_);

                        return (am_ as CqlInterval<CqlQuantity>) as object;
                    }
                    else
                    {
                        return null;
                    }
                };
                CqlInterval<CqlDateTime> j_ = QICoreCommon_4_0_000.Instance.toInterval(context, i_());
                CqlDateTime k_ = context.Operators.Start(j_);
                object l_ = context.Operators.LateBoundProperty<object>(HospiceStatus, "authoredOn");
                CqlDateTime m_ = context.Operators.LateBoundProperty<CqlDateTime>(l_, "value");
                CqlInterval<CqlDateTime> n_ = CQMCommon_4_1_000.Instance.hospitalizationWithObservation(context, QualifyingEncounter);
                bool? o_ = context.Operators.In<CqlDateTime>(k_ ?? m_, n_, "day");

                return o_;
            };
            IEnumerable<object> f_ = context.Operators.Where<object>(d_, e_);
            Encounter g_(object HospiceStatus) =>
                QualifyingEncounter;
            IEnumerable<Encounter> h_ = context.Operators.Select<object, Encounter>(f_, g_);

            return h_;
        };
        IEnumerable<Encounter> c_ = context.Operators.SelectMany<Encounter, Encounter>(a_, b_);

        return c_;
    }


    [CqlExpressionDefinition("Measure Population Exclusion")]
    public IEnumerable<Encounter> Measure_Population_Exclusion(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Encounter_with_Discharge_for_Hospice_Care(context);
        IEnumerable<Encounter> b_ = this.Encounter_with_Hospice_during_Eligible_Encounter(context);
        IEnumerable<Encounter> c_ = context.Operators.Union<Encounter>(a_, b_);

        return c_;
    }


    [CqlExpressionDefinition("Intervention Dietitian Referral")]
    public IEnumerable<object> Intervention_Dietitian_Referral(CqlContext context)
    {
        CqlValueSet a_ = this.Dietitian_Referral(context);
        IEnumerable<ServiceRequest> b_ = context.Operators.Retrieve<ServiceRequest>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-servicerequest"));
        bool? c_(ServiceRequest DietitianReferralOrder)
        {
            Code<RequestStatus> j_ = DietitianReferralOrder?.StatusElement;
            RequestStatus? k_ = j_?.Value;
            Code<RequestStatus> l_ = context.Operators.Convert<Code<RequestStatus>>(k_);
            string m_ = context.Operators.Convert<string>(l_);
            string[] n_ = [
                "active",
                "completed",
                "on-hold",
            ];
            bool? o_ = context.Operators.In<string>(m_, (IEnumerable<string>)n_);
            Code<RequestIntent> p_ = DietitianReferralOrder?.IntentElement;
            RequestIntent? q_ = p_?.Value;
            Code<RequestIntent> r_ = context.Operators.Convert<Code<RequestIntent>>(q_);
            string s_ = context.Operators.Convert<string>(r_);
            string[] t_ = [
                "order",
                "original-order",
                "reflex-order",
                "filler-order",
                "instance-order",
            ];
            bool? u_ = context.Operators.In<string>(s_, (IEnumerable<string>)t_);
            bool? v_ = context.Operators.And(o_, u_);
            FhirBoolean w_ = DietitianReferralOrder?.DoNotPerformElement;
            bool? x_ = w_?.Value;
            bool? y_ = context.Operators.IsTrue(x_);
            bool? z_ = context.Operators.Not(y_);
            bool? aa_ = context.Operators.And(v_, z_);

            return aa_;
        };
        IEnumerable<ServiceRequest> d_ = context.Operators.Where<ServiceRequest>(b_, c_);
        IEnumerable<Procedure> f_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
        bool? g_(Procedure DietitianReferralPerformed)
        {
            Code<EventStatus> ab_ = DietitianReferralPerformed?.StatusElement;
            EventStatus? ac_ = ab_?.Value;
            string ad_ = context.Operators.Convert<string>(ac_);
            string[] ae_ = [
                "completed",
                "in-progress",
            ];
            bool? af_ = context.Operators.In<string>(ad_, (IEnumerable<string>)ae_);

            return af_;
        };
        IEnumerable<Procedure> h_ = context.Operators.Where<Procedure>(f_, g_);
        IEnumerable<object> i_ = context.Operators.Union<object>(d_ as IEnumerable<object>, h_ as IEnumerable<object>);

        return i_;
    }


    [CqlExpressionDefinition("Encounter with Dietitian Referral")]
    public IEnumerable<Encounter> Encounter_with_Dietitian_Referral(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Measure_Population(context);
        IEnumerable<Encounter> b_(Encounter QualifyingEncounter)
        {
            IEnumerable<object> d_ = this.Intervention_Dietitian_Referral(context);
            bool? e_(object DietitianReferral)
            {
                object i_()
                {
                    bool p_()
                    {
                        object t_ = context.Operators.LateBoundProperty<object>(DietitianReferral, "performed");
                        object u_ = FHIRHelpers_4_4_000.Instance.ToValue(context, t_);
                        bool v_ = u_ is CqlDateTime;

                        return v_;
                    };
                    bool q_()
                    {
                        object w_ = context.Operators.LateBoundProperty<object>(DietitianReferral, "performed");
                        object x_ = FHIRHelpers_4_4_000.Instance.ToValue(context, w_);
                        bool y_ = x_ is CqlInterval<CqlDateTime>;

                        return y_;
                    };
                    bool r_()
                    {
                        object z_ = context.Operators.LateBoundProperty<object>(DietitianReferral, "performed");
                        object aa_ = FHIRHelpers_4_4_000.Instance.ToValue(context, z_);
                        bool ab_ = aa_ is CqlQuantity;

                        return ab_;
                    };
                    bool s_()
                    {
                        object ac_ = context.Operators.LateBoundProperty<object>(DietitianReferral, "performed");
                        object ad_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ac_);
                        bool ae_ = ad_ is CqlInterval<CqlQuantity>;

                        return ae_;
                    };
                    if (p_())
                    {
                        object af_ = context.Operators.LateBoundProperty<object>(DietitianReferral, "performed");
                        object ag_ = FHIRHelpers_4_4_000.Instance.ToValue(context, af_);

                        return (ag_ as CqlDateTime) as object;
                    }
                    else if (q_())
                    {
                        object ah_ = context.Operators.LateBoundProperty<object>(DietitianReferral, "performed");
                        object ai_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ah_);

                        return (ai_ as CqlInterval<CqlDateTime>) as object;
                    }
                    else if (r_())
                    {
                        object aj_ = context.Operators.LateBoundProperty<object>(DietitianReferral, "performed");
                        object ak_ = FHIRHelpers_4_4_000.Instance.ToValue(context, aj_);

                        return (ak_ as CqlQuantity) as object;
                    }
                    else if (s_())
                    {
                        object al_ = context.Operators.LateBoundProperty<object>(DietitianReferral, "performed");
                        object am_ = FHIRHelpers_4_4_000.Instance.ToValue(context, al_);

                        return (am_ as CqlInterval<CqlQuantity>) as object;
                    }
                    else
                    {
                        return null;
                    }
                };
                CqlInterval<CqlDateTime> j_ = QICoreCommon_4_0_000.Instance.toInterval(context, i_());
                CqlDateTime k_ = context.Operators.Start(j_);
                object l_ = context.Operators.LateBoundProperty<object>(DietitianReferral, "authoredOn");
                CqlDateTime m_ = context.Operators.LateBoundProperty<CqlDateTime>(l_, "value");
                CqlInterval<CqlDateTime> n_ = CQMCommon_4_1_000.Instance.hospitalizationWithObservation(context, QualifyingEncounter);
                bool? o_ = context.Operators.In<CqlDateTime>(k_ ?? m_, n_, "day");

                return o_;
            };
            IEnumerable<object> f_ = context.Operators.Where<object>(d_, e_);
            Encounter g_(object DietitianReferral) =>
                QualifyingEncounter;
            IEnumerable<Encounter> h_ = context.Operators.Select<object, Encounter>(f_, g_);

            return h_;
        };
        IEnumerable<Encounter> c_ = context.Operators.SelectMany<Encounter, Encounter>(a_, b_);

        return c_;
    }


    [CqlExpressionDefinition("Encounter with Malnutrition Risk Screening")]
    public IEnumerable<Encounter> Encounter_with_Malnutrition_Risk_Screening(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Measure_Population(context);
        IEnumerable<Encounter> b_(Encounter QualifyingEncounter)
        {
            CqlValueSet g_ = this.Malnutrition_Risk_Screening(context);
            IEnumerable<Observation> h_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, g_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation-screening-assessment"));
            bool? i_(Observation MalnutritionRiskScreening)
            {
                Code<ObservationStatus> m_ = MalnutritionRiskScreening?.StatusElement;
                ObservationStatus? n_ = m_?.Value;
                string o_ = context.Operators.Convert<string>(n_);
                string[] p_ = [
                    "final",
                    "amended",
                    "corrected",
                ];
                bool? q_ = context.Operators.In<string>(o_, (IEnumerable<string>)p_);
                CqlInterval<CqlDateTime> r_ = CQMCommon_4_1_000.Instance.hospitalizationWithObservation(context, QualifyingEncounter);
                DataType s_ = MalnutritionRiskScreening?.Effective;
                object t_ = FHIRHelpers_4_4_000.Instance.ToValue(context, s_);
                CqlInterval<CqlDateTime> u_ = QICoreCommon_4_0_000.Instance.toInterval(context, t_);
                bool? v_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(r_, u_, default);
                bool? w_ = context.Operators.And(q_, v_);
                DataType x_ = MalnutritionRiskScreening?.Value;
                object y_ = FHIRHelpers_4_4_000.Instance.ToValue(context, x_);
                CqlValueSet z_ = this.Malnutrition_Screening_Finding_of_Not_At_Risk_Result(context);
                bool? aa_ = context.Operators.ConceptInValueSet(y_ as CqlConcept, z_);
                object ac_ = FHIRHelpers_4_4_000.Instance.ToValue(context, x_);
                CqlValueSet ad_ = this.Malnutrition_Screening_Finding_of_At_Risk_Result(context);
                bool? ae_ = context.Operators.ConceptInValueSet(ac_ as CqlConcept, ad_);
                bool? af_ = context.Operators.Or(aa_, ae_);
                bool? ag_ = context.Operators.And(w_, af_);

                return ag_;
            };
            IEnumerable<Observation> j_ = context.Operators.Where<Observation>(h_, i_);
            Encounter k_(Observation MalnutritionRiskScreening) =>
                QualifyingEncounter;
            IEnumerable<Encounter> l_ = context.Operators.Select<Observation, Encounter>(j_, k_);

            return l_;
        };
        IEnumerable<Encounter> c_ = context.Operators.SelectMany<Encounter, Encounter>(a_, b_);
        Encounter d_(Encounter QualifyingEncounter) =>
            QualifyingEncounter;
        IEnumerable<Encounter> e_ = context.Operators.Select<Encounter, Encounter>(c_, d_);
        IEnumerable<Encounter> f_ = context.Operators.Distinct<Encounter>(e_);

        return f_;
    }


    [CqlExpressionDefinition("Encounter with Malnutrition Risk Screening or with Dietitian Referral")]
    public IEnumerable<Encounter> Encounter_with_Malnutrition_Risk_Screening_or_with_Dietitian_Referral(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Measure_Population(context);
        bool? b_(Encounter QualifyingEncounter)
        {
            IEnumerable<Encounter> g_ = this.Encounter_with_Malnutrition_Risk_Screening(context);
            bool? h_ = context.Operators.Contains<Encounter>(g_, QualifyingEncounter);
            IEnumerable<Encounter> i_ = this.Encounter_with_Dietitian_Referral(context);
            bool? j_ = context.Operators.Contains<Encounter>(i_, QualifyingEncounter);
            bool? k_ = context.Operators.Or(h_, j_);

            return k_;
        };
        IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);
        Encounter d_(Encounter QualifyingEncounter) =>
            QualifyingEncounter;
        IEnumerable<Encounter> e_ = context.Operators.Select<Encounter, Encounter>(c_, d_);
        IEnumerable<Encounter> f_ = context.Operators.Distinct<Encounter>(e_);

        return f_;
    }


    [CqlExpressionDefinition("Encounter with Malnutrition Risk Screening Not At Risk")]
    public IEnumerable<Encounter> Encounter_with_Malnutrition_Risk_Screening_Not_At_Risk(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Measure_Population(context);
        IEnumerable<Encounter> b_(Encounter QualifyingEncounter)
        {
            CqlValueSet g_ = this.Malnutrition_Risk_Screening(context);
            IEnumerable<Observation> h_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, g_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation-screening-assessment"));
            bool? i_(Observation MalnutritionRiskScreening)
            {
                Code<ObservationStatus> m_ = MalnutritionRiskScreening?.StatusElement;
                ObservationStatus? n_ = m_?.Value;
                string o_ = context.Operators.Convert<string>(n_);
                string[] p_ = [
                    "final",
                    "amended",
                    "corrected",
                ];
                bool? q_ = context.Operators.In<string>(o_, (IEnumerable<string>)p_);
                CqlInterval<CqlDateTime> r_ = CQMCommon_4_1_000.Instance.hospitalizationWithObservation(context, QualifyingEncounter);
                DataType s_ = MalnutritionRiskScreening?.Effective;
                object t_ = FHIRHelpers_4_4_000.Instance.ToValue(context, s_);
                CqlInterval<CqlDateTime> u_ = QICoreCommon_4_0_000.Instance.toInterval(context, t_);
                bool? v_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(r_, u_, default);
                bool? w_ = context.Operators.And(q_, v_);
                DataType x_ = MalnutritionRiskScreening?.Value;
                object y_ = FHIRHelpers_4_4_000.Instance.ToValue(context, x_);
                CqlValueSet z_ = this.Malnutrition_Screening_Finding_of_Not_At_Risk_Result(context);
                bool? aa_ = context.Operators.ConceptInValueSet(y_ as CqlConcept, z_);
                bool? ab_ = context.Operators.And(w_, aa_);

                return ab_;
            };
            IEnumerable<Observation> j_ = context.Operators.Where<Observation>(h_, i_);
            Encounter k_(Observation MalnutritionRiskScreening) =>
                QualifyingEncounter;
            IEnumerable<Encounter> l_ = context.Operators.Select<Observation, Encounter>(j_, k_);

            return l_;
        };
        IEnumerable<Encounter> c_ = context.Operators.SelectMany<Encounter, Encounter>(a_, b_);
        Encounter d_(Encounter QualifyingEncounter) =>
            QualifyingEncounter;
        IEnumerable<Encounter> e_ = context.Operators.Select<Encounter, Encounter>(c_, d_);
        IEnumerable<Encounter> f_ = context.Operators.Distinct<Encounter>(e_);

        return f_;
    }


    [CqlExpressionDefinition("Encounter with Malnutrition Not At Risk Screening and without Dietitian Referral")]
    public IEnumerable<Encounter> Encounter_with_Malnutrition_Not_At_Risk_Screening_and_without_Dietitian_Referral(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Measure_Population(context);
        bool? b_(Encounter QualifyingEncounter)
        {
            IEnumerable<Encounter> g_ = this.Encounter_with_Malnutrition_Risk_Screening_Not_At_Risk(context);
            bool? h_ = context.Operators.Contains<Encounter>(g_, QualifyingEncounter);
            IEnumerable<Encounter> i_ = this.Encounter_with_Dietitian_Referral(context);
            bool? j_ = context.Operators.Exists<Encounter>(i_);
            bool? k_ = context.Operators.Not(j_);
            bool? l_ = context.Operators.And(h_, k_);

            return l_;
        };
        IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);
        Encounter d_(Encounter QualifyingEncounter) =>
            QualifyingEncounter;
        IEnumerable<Encounter> e_ = context.Operators.Select<Encounter, Encounter>(c_, d_);
        IEnumerable<Encounter> f_ = context.Operators.Distinct<Encounter>(e_);

        return f_;
    }


    [CqlExpressionDefinition("Encounter with Malnutrition Risk Screening At Risk")]
    public IEnumerable<Encounter> Encounter_with_Malnutrition_Risk_Screening_At_Risk(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Measure_Population(context);
        IEnumerable<Encounter> b_(Encounter QualifyingEncounter)
        {
            CqlValueSet g_ = this.Malnutrition_Risk_Screening(context);
            IEnumerable<Observation> h_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, g_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation-screening-assessment"));
            bool? i_(Observation MalnutritionRiskScreening)
            {
                Code<ObservationStatus> m_ = MalnutritionRiskScreening?.StatusElement;
                ObservationStatus? n_ = m_?.Value;
                string o_ = context.Operators.Convert<string>(n_);
                string[] p_ = [
                    "final",
                    "amended",
                    "corrected",
                ];
                bool? q_ = context.Operators.In<string>(o_, (IEnumerable<string>)p_);
                CqlInterval<CqlDateTime> r_ = CQMCommon_4_1_000.Instance.hospitalizationWithObservation(context, QualifyingEncounter);
                DataType s_ = MalnutritionRiskScreening?.Effective;
                object t_ = FHIRHelpers_4_4_000.Instance.ToValue(context, s_);
                CqlInterval<CqlDateTime> u_ = QICoreCommon_4_0_000.Instance.toInterval(context, t_);
                bool? v_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(r_, u_, default);
                bool? w_ = context.Operators.And(q_, v_);
                DataType x_ = MalnutritionRiskScreening?.Value;
                object y_ = FHIRHelpers_4_4_000.Instance.ToValue(context, x_);
                CqlValueSet z_ = this.Malnutrition_Screening_Finding_of_At_Risk_Result(context);
                bool? aa_ = context.Operators.ConceptInValueSet(y_ as CqlConcept, z_);
                bool? ab_ = context.Operators.And(w_, aa_);

                return ab_;
            };
            IEnumerable<Observation> j_ = context.Operators.Where<Observation>(h_, i_);
            Encounter k_(Observation MalnutritionRiskScreening) =>
                QualifyingEncounter;
            IEnumerable<Encounter> l_ = context.Operators.Select<Observation, Encounter>(j_, k_);

            return l_;
        };
        IEnumerable<Encounter> c_ = context.Operators.SelectMany<Encounter, Encounter>(a_, b_);
        Encounter d_(Encounter QualifyingEncounter) =>
            QualifyingEncounter;
        IEnumerable<Encounter> e_ = context.Operators.Select<Encounter, Encounter>(c_, d_);
        IEnumerable<Encounter> f_ = context.Operators.Distinct<Encounter>(e_);

        return f_;
    }


    [CqlExpressionDefinition("Encounter with Malnutrition Risk Screening At Risk or with Dietitian Referral")]
    public IEnumerable<Encounter> Encounter_with_Malnutrition_Risk_Screening_At_Risk_or_with_Dietitian_Referral(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Measure_Population(context);
        bool? b_(Encounter QualifyingEncounter)
        {
            IEnumerable<Encounter> g_ = this.Encounter_with_Malnutrition_Risk_Screening_At_Risk(context);
            bool? h_ = context.Operators.Contains<Encounter>(g_, QualifyingEncounter);
            IEnumerable<Encounter> i_ = this.Encounter_with_Dietitian_Referral(context);
            bool? j_ = context.Operators.Contains<Encounter>(i_, QualifyingEncounter);
            bool? k_ = context.Operators.Or(h_, j_);

            return k_;
        };
        IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);
        Encounter d_(Encounter QualifyingEncounter) =>
            QualifyingEncounter;
        IEnumerable<Encounter> e_ = context.Operators.Select<Encounter, Encounter>(c_, d_);
        IEnumerable<Encounter> f_ = context.Operators.Distinct<Encounter>(e_);

        return f_;
    }


    [CqlFunctionDefinition("Last Nutrition Assessment Day During Encounter")]
    public CqlDateTime Last_Nutrition_Assessment_Day_During_Encounter(CqlContext context, Encounter QualifyingEncounter)
    {
        IEnumerable<(CqlTupleMetadata, string HospEncId, CqlInterval<CqlDateTime> HospitalizationPeriod, CqlConcept NutrAssessCode, string NutrAssessId, object NutrAssessResult, object NutrAssessTimingEff, CqlInterval<CqlDateTime> NutrAssessTimingInt, CqlDateTime NutrAssessTimingLatest)?> a_ = this.Nutrition_Assessment_Performed(context);
        bool? b_((CqlTupleMetadata, string HospEncId, CqlInterval<CqlDateTime> HospitalizationPeriod, CqlConcept NutrAssessCode, string NutrAssessId, object NutrAssessResult, object NutrAssessTimingEff, CqlInterval<CqlDateTime> NutrAssessTimingInt, CqlDateTime NutrAssessTimingLatest)? NutritionAssessmentTuple)
        {
            string i_ = NutritionAssessmentTuple?.HospEncId;
            string j_ = (QualifyingEncounter is Resource
        ? (QualifyingEncounter as Resource).IdElement
        : default)?.Value;
            bool? k_ = context.Operators.Equal(i_, j_);

            return k_;
        };
        IEnumerable<(CqlTupleMetadata, string HospEncId, CqlInterval<CqlDateTime> HospitalizationPeriod, CqlConcept NutrAssessCode, string NutrAssessId, object NutrAssessResult, object NutrAssessTimingEff, CqlInterval<CqlDateTime> NutrAssessTimingInt, CqlDateTime NutrAssessTimingLatest)?> c_ = context.Operators.Where<(CqlTupleMetadata, string HospEncId, CqlInterval<CqlDateTime> HospitalizationPeriod, CqlConcept NutrAssessCode, string NutrAssessId, object NutrAssessResult, object NutrAssessTimingEff, CqlInterval<CqlDateTime> NutrAssessTimingInt, CqlDateTime NutrAssessTimingLatest)?>(a_, b_);
        CqlDateTime d_((CqlTupleMetadata, string HospEncId, CqlInterval<CqlDateTime> HospitalizationPeriod, CqlConcept NutrAssessCode, string NutrAssessId, object NutrAssessResult, object NutrAssessTimingEff, CqlInterval<CqlDateTime> NutrAssessTimingInt, CqlDateTime NutrAssessTimingLatest)? NutritionAssessmentTuple)
        {
            CqlDateTime l_ = NutritionAssessmentTuple?.NutrAssessTimingLatest;

            return l_;
        };
        IEnumerable<CqlDateTime> e_ = context.Operators.Select<(CqlTupleMetadata, string HospEncId, CqlInterval<CqlDateTime> HospitalizationPeriod, CqlConcept NutrAssessCode, string NutrAssessId, object NutrAssessResult, object NutrAssessTimingEff, CqlInterval<CqlDateTime> NutrAssessTimingInt, CqlDateTime NutrAssessTimingLatest)?, CqlDateTime>(c_, d_);
        IEnumerable<CqlDateTime> f_ = context.Operators.Distinct<CqlDateTime>(e_);
        IEnumerable<CqlDateTime> g_ = context.Operators.ListSort<CqlDateTime>(f_, System.ComponentModel.ListSortDirection.Ascending);
        CqlDateTime h_ = context.Operators.Last<CqlDateTime>(g_);

        return h_;
    }


    [CqlExpressionDefinition("Nutrition Assessment Performed")]
    public IEnumerable<(CqlTupleMetadata, string HospEncId, CqlInterval<CqlDateTime> HospitalizationPeriod, CqlConcept NutrAssessCode, string NutrAssessId, object NutrAssessResult, object NutrAssessTimingEff, CqlInterval<CqlDateTime> NutrAssessTimingInt, CqlDateTime NutrAssessTimingLatest)?> Nutrition_Assessment_Performed(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Measure_Population(context);
        CqlValueSet b_ = this.Nutrition_Assessment(context);
        IEnumerable<Observation> c_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, b_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation-screening-assessment"));
        IEnumerable<ValueTuple<Encounter, Observation>> d_ = context.Operators.CrossJoin<Encounter, Observation>(a_, c_);
        (CqlTupleMetadata, Encounter QualifyingEncounter, Observation NutritionAssessment)? e_(ValueTuple<Encounter, Observation> _valueTuple)
        {
            (CqlTupleMetadata, Encounter QualifyingEncounter, Observation NutritionAssessment)? n_ = (CqlTupleMetadata_GFjZJIRJbJMHZiLMbCVCEiHgh, _valueTuple.Item1, _valueTuple.Item2);

            return n_;
        };
        IEnumerable<(CqlTupleMetadata, Encounter QualifyingEncounter, Observation NutritionAssessment)?> f_ = context.Operators.Select<ValueTuple<Encounter, Observation>, (CqlTupleMetadata, Encounter QualifyingEncounter, Observation NutritionAssessment)?>(d_, e_);
        bool? g_((CqlTupleMetadata, Encounter QualifyingEncounter, Observation NutritionAssessment)? tuple_hhhypfjvjujitmizocefugcne)
        {
            CodeableConcept o_ = tuple_hhhypfjvjujitmizocefugcne?.NutritionAssessment?.Code;
            CqlConcept p_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, o_);
            CqlValueSet q_ = this.Nutrition_Assessment(context);
            bool? r_ = context.Operators.ConceptInValueSet(p_ as CqlConcept, q_);
            Code<ObservationStatus> s_ = tuple_hhhypfjvjujitmizocefugcne?.NutritionAssessment?.StatusElement;
            ObservationStatus? t_ = s_?.Value;
            string u_ = context.Operators.Convert<string>(t_);
            string[] v_ = [
                "final",
                "amended",
                "corrected",
            ];
            bool? w_ = context.Operators.In<string>(u_, (IEnumerable<string>)v_);
            bool? x_ = context.Operators.And(r_, w_);
            CqlInterval<CqlDateTime> y_ = CQMCommon_4_1_000.Instance.hospitalizationWithObservation(context, tuple_hhhypfjvjujitmizocefugcne?.QualifyingEncounter);
            DataType z_ = tuple_hhhypfjvjujitmizocefugcne?.NutritionAssessment?.Effective;
            object aa_ = FHIRHelpers_4_4_000.Instance.ToValue(context, z_);
            CqlInterval<CqlDateTime> ab_ = QICoreCommon_4_0_000.Instance.toInterval(context, aa_);
            bool? ac_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(y_, ab_, default);
            bool? ad_ = context.Operators.And(x_, ac_);
            DataType ae_ = tuple_hhhypfjvjujitmizocefugcne?.NutritionAssessment?.Value;
            object af_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ae_);
            bool? ag_ = context.Operators.Not((bool?)(af_ is null));
            bool? ah_ = context.Operators.And(ad_, ag_);

            return ah_;
        };
        IEnumerable<(CqlTupleMetadata, Encounter QualifyingEncounter, Observation NutritionAssessment)?> h_ = context.Operators.Where<(CqlTupleMetadata, Encounter QualifyingEncounter, Observation NutritionAssessment)?>(f_, g_);
        (CqlTupleMetadata, string HospEncId, CqlInterval<CqlDateTime> HospitalizationPeriod, CqlConcept NutrAssessCode, string NutrAssessId, object NutrAssessResult, object NutrAssessTimingEff, CqlInterval<CqlDateTime> NutrAssessTimingInt, CqlDateTime NutrAssessTimingLatest)? i_((CqlTupleMetadata, Encounter QualifyingEncounter, Observation NutritionAssessment)? tuple_hhhypfjvjujitmizocefugcne)
        {
            Id ai_ = tuple_hhhypfjvjujitmizocefugcne?.QualifyingEncounter?.IdElement;
            string aj_ = ai_?.Value;
            CqlInterval<CqlDateTime> ak_ = CQMCommon_4_1_000.Instance.hospitalizationWithObservation(context, tuple_hhhypfjvjujitmizocefugcne?.QualifyingEncounter);
            CodeableConcept al_ = tuple_hhhypfjvjujitmizocefugcne?.NutritionAssessment?.Code;
            CqlConcept am_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, al_);
            Id an_ = tuple_hhhypfjvjujitmizocefugcne?.NutritionAssessment?.IdElement;
            string ao_ = an_?.Value;
            DataType ap_ = tuple_hhhypfjvjujitmizocefugcne?.NutritionAssessment?.Value;
            object aq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ap_);
            DataType ar_ = tuple_hhhypfjvjujitmizocefugcne?.NutritionAssessment?.Effective;
            object as_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ar_);
            object au_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ar_);
            CqlInterval<CqlDateTime> av_ = QICoreCommon_4_0_000.Instance.toInterval(context, au_);
            object aw_()
            {
                bool az_()
                {
                    DataType bc_ = tuple_hhhypfjvjujitmizocefugcne?.NutritionAssessment?.Effective;
                    object bd_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bc_);
                    bool be_ = bd_ is CqlDateTime;

                    return be_;
                };
                bool ba_()
                {
                    DataType bf_ = tuple_hhhypfjvjujitmizocefugcne?.NutritionAssessment?.Effective;
                    object bg_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bf_);
                    bool bh_ = bg_ is CqlInterval<CqlDateTime>;

                    return bh_;
                };
                bool bb_()
                {
                    DataType bi_ = tuple_hhhypfjvjujitmizocefugcne?.NutritionAssessment?.Effective;
                    object bj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bi_);
                    bool bk_ = bj_ is CqlDateTime;

                    return bk_;
                };
                if (az_())
                {
                    DataType bl_ = tuple_hhhypfjvjujitmizocefugcne?.NutritionAssessment?.Effective;
                    object bm_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bl_);

                    return (bm_ as CqlDateTime) as object;
                }
                else if (ba_())
                {
                    DataType bn_ = tuple_hhhypfjvjujitmizocefugcne?.NutritionAssessment?.Effective;
                    object bo_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bn_);

                    return (bo_ as CqlInterval<CqlDateTime>) as object;
                }
                else if (bb_())
                {
                    DataType bp_ = tuple_hhhypfjvjujitmizocefugcne?.NutritionAssessment?.Effective;
                    object bq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bp_);

                    return (bq_ as CqlDateTime) as object;
                }
                else
                {
                    return null;
                }
            };
            CqlDateTime ax_ = QICoreCommon_4_0_000.Instance.latest(context, aw_());
            (CqlTupleMetadata, string HospEncId, CqlInterval<CqlDateTime> HospitalizationPeriod, CqlConcept NutrAssessCode, string NutrAssessId, object NutrAssessResult, object NutrAssessTimingEff, CqlInterval<CqlDateTime> NutrAssessTimingInt, CqlDateTime NutrAssessTimingLatest)? ay_ = (CqlTupleMetadata_DSLMMchJhQZgVcNfhbLBSiBYP, aj_, ak_, am_ as CqlConcept, ao_, aq_, as_, av_, ax_);

            return ay_;
        };
        IEnumerable<(CqlTupleMetadata, string HospEncId, CqlInterval<CqlDateTime> HospitalizationPeriod, CqlConcept NutrAssessCode, string NutrAssessId, object NutrAssessResult, object NutrAssessTimingEff, CqlInterval<CqlDateTime> NutrAssessTimingInt, CqlDateTime NutrAssessTimingLatest)?> j_ = context.Operators.Select<(CqlTupleMetadata, Encounter QualifyingEncounter, Observation NutritionAssessment)?, (CqlTupleMetadata, string HospEncId, CqlInterval<CqlDateTime> HospitalizationPeriod, CqlConcept NutrAssessCode, string NutrAssessId, object NutrAssessResult, object NutrAssessTimingEff, CqlInterval<CqlDateTime> NutrAssessTimingInt, CqlDateTime NutrAssessTimingLatest)?>(h_, i_);
        IEnumerable<(CqlTupleMetadata, string HospEncId, CqlInterval<CqlDateTime> HospitalizationPeriod, CqlConcept NutrAssessCode, string NutrAssessId, object NutrAssessResult, object NutrAssessTimingEff, CqlInterval<CqlDateTime> NutrAssessTimingInt, CqlDateTime NutrAssessTimingLatest)?> k_ = context.Operators.Distinct<(CqlTupleMetadata, string HospEncId, CqlInterval<CqlDateTime> HospitalizationPeriod, CqlConcept NutrAssessCode, string NutrAssessId, object NutrAssessResult, object NutrAssessTimingEff, CqlInterval<CqlDateTime> NutrAssessTimingInt, CqlDateTime NutrAssessTimingLatest)?>(j_);
        object l_((CqlTupleMetadata, string HospEncId, CqlInterval<CqlDateTime> HospitalizationPeriod, CqlConcept NutrAssessCode, string NutrAssessId, object NutrAssessResult, object NutrAssessTimingEff, CqlInterval<CqlDateTime> NutrAssessTimingInt, CqlDateTime NutrAssessTimingLatest)? @this)
        {
            CqlDateTime br_ = @this?.NutrAssessTimingLatest;

            return br_;
        };
        IEnumerable<(CqlTupleMetadata, string HospEncId, CqlInterval<CqlDateTime> HospitalizationPeriod, CqlConcept NutrAssessCode, string NutrAssessId, object NutrAssessResult, object NutrAssessTimingEff, CqlInterval<CqlDateTime> NutrAssessTimingInt, CqlDateTime NutrAssessTimingLatest)?> m_ = context.Operators.SortBy<(CqlTupleMetadata, string HospEncId, CqlInterval<CqlDateTime> HospitalizationPeriod, CqlConcept NutrAssessCode, string NutrAssessId, object NutrAssessResult, object NutrAssessTimingEff, CqlInterval<CqlDateTime> NutrAssessTimingInt, CqlDateTime NutrAssessTimingLatest)?>(k_, l_, System.ComponentModel.ListSortDirection.Ascending);

        return m_;
    }


    [CqlExpressionDefinition("Encounter With Most Recent Nutrition Assessment And Identified Status")]
    public IEnumerable<Encounter> Encounter_With_Most_Recent_Nutrition_Assessment_And_Identified_Status(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Measure_Population(context);
        IEnumerable<Encounter> b_(Encounter QualifyingEncounter)
        {
            CqlValueSet g_ = this.Nutrition_Assessment(context);
            IEnumerable<Observation> h_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, g_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation-screening-assessment"));
            bool? i_(Observation NutritionAssessment)
            {
                Code<ObservationStatus> m_ = NutritionAssessment?.StatusElement;
                ObservationStatus? n_ = m_?.Value;
                string o_ = context.Operators.Convert<string>(n_);
                string[] p_ = [
                    "final",
                    "amended",
                    "corrected",
                ];
                bool? q_ = context.Operators.In<string>(o_, (IEnumerable<string>)p_);
                CqlInterval<CqlDateTime> r_ = CQMCommon_4_1_000.Instance.hospitalizationWithObservation(context, QualifyingEncounter);
                DataType s_ = NutritionAssessment?.Effective;
                object t_ = FHIRHelpers_4_4_000.Instance.ToValue(context, s_);
                CqlInterval<CqlDateTime> u_ = QICoreCommon_4_0_000.Instance.toInterval(context, t_);
                bool? v_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(r_, u_, default);
                bool? w_ = context.Operators.And(q_, v_);
                DataType x_ = NutritionAssessment?.Value;
                object y_ = FHIRHelpers_4_4_000.Instance.ToValue(context, x_);
                CqlValueSet z_ = this.Nutrition_Assessment_Status_Finding_of_Well_Nourished_or_Not_Malnourished_or_Mildly_Malnourished(context);
                bool? aa_ = context.Operators.ConceptInValueSet(y_ as CqlConcept, z_);
                object ac_ = FHIRHelpers_4_4_000.Instance.ToValue(context, x_);
                CqlValueSet ad_ = this.Nutrition_Assessment_Status_Finding_of_Moderately_Malnourished(context);
                bool? ae_ = context.Operators.ConceptInValueSet(ac_ as CqlConcept, ad_);
                bool? af_ = context.Operators.Or(aa_, ae_);
                object ah_ = FHIRHelpers_4_4_000.Instance.ToValue(context, x_);
                CqlValueSet ai_ = this.Nutrition_Assessment_Status_Finding_of_Severely_Malnourished(context);
                bool? aj_ = context.Operators.ConceptInValueSet(ah_ as CqlConcept, ai_);
                bool? ak_ = context.Operators.Or(af_, aj_);
                bool? al_ = context.Operators.And(w_, ak_);
                IEnumerable<Encounter> am_ = this.Encounter_with_Malnutrition_Risk_Screening_At_Risk(context);
                bool? an_ = context.Operators.Exists<Encounter>(am_);
                IEnumerable<Encounter> ao_ = this.Encounter_with_Dietitian_Referral(context);
                bool? ap_ = context.Operators.Exists<Encounter>(ao_);
                bool? aq_ = context.Operators.Or(an_, ap_);
                bool? ar_ = context.Operators.And(al_, aq_);
                object as_()
                {
                    bool ax_()
                    {
                        DataType ba_ = NutritionAssessment?.Effective;
                        object bb_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ba_);
                        bool bc_ = bb_ is CqlDateTime;

                        return bc_;
                    };
                    bool ay_()
                    {
                        DataType bd_ = NutritionAssessment?.Effective;
                        object be_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bd_);
                        bool bf_ = be_ is CqlInterval<CqlDateTime>;

                        return bf_;
                    };
                    bool az_()
                    {
                        DataType bg_ = NutritionAssessment?.Effective;
                        object bh_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bg_);
                        bool bi_ = bh_ is CqlDateTime;

                        return bi_;
                    };
                    if (ax_())
                    {
                        DataType bj_ = NutritionAssessment?.Effective;
                        object bk_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bj_);

                        return (bk_ as CqlDateTime) as object;
                    }
                    else if (ay_())
                    {
                        DataType bl_ = NutritionAssessment?.Effective;
                        object bm_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bl_);

                        return (bm_ as CqlInterval<CqlDateTime>) as object;
                    }
                    else if (az_())
                    {
                        DataType bn_ = NutritionAssessment?.Effective;
                        object bo_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bn_);

                        return (bo_ as CqlDateTime) as object;
                    }
                    else
                    {
                        return null;
                    }
                };
                CqlDateTime at_ = QICoreCommon_4_0_000.Instance.latest(context, as_());
                CqlDateTime au_ = this.Last_Nutrition_Assessment_Day_During_Encounter(context, QualifyingEncounter);
                bool? av_ = context.Operators.SameAs(at_, au_, "day");
                bool? aw_ = context.Operators.And(ar_, av_);

                return aw_;
            };
            IEnumerable<Observation> j_ = context.Operators.Where<Observation>(h_, i_);
            Encounter k_(Observation NutritionAssessment) =>
                QualifyingEncounter;
            IEnumerable<Encounter> l_ = context.Operators.Select<Observation, Encounter>(j_, k_);

            return l_;
        };
        IEnumerable<Encounter> c_ = context.Operators.SelectMany<Encounter, Encounter>(a_, b_);
        Encounter d_(Encounter QualifyingEncounter) =>
            QualifyingEncounter;
        IEnumerable<Encounter> e_ = context.Operators.Select<Encounter, Encounter>(c_, d_);
        IEnumerable<Encounter> f_ = context.Operators.Distinct<Encounter>(e_);

        return f_;
    }


    [CqlExpressionDefinition("Encounter With Most Recent Nutrition Assessment Status of Moderately Or Severely Malnourished")]
    public IEnumerable<Encounter> Encounter_With_Most_Recent_Nutrition_Assessment_Status_of_Moderately_Or_Severely_Malnourished(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Measure_Population(context);
        IEnumerable<Encounter> b_(Encounter QualifyingEncounter)
        {
            CqlValueSet g_ = this.Nutrition_Assessment(context);
            IEnumerable<Observation> h_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, g_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation-screening-assessment"));
            bool? i_(Observation NutritionAssessment)
            {
                Code<ObservationStatus> m_ = NutritionAssessment?.StatusElement;
                ObservationStatus? n_ = m_?.Value;
                string o_ = context.Operators.Convert<string>(n_);
                string[] p_ = [
                    "final",
                    "amended",
                    "corrected",
                ];
                bool? q_ = context.Operators.In<string>(o_, (IEnumerable<string>)p_);
                CqlInterval<CqlDateTime> r_ = CQMCommon_4_1_000.Instance.hospitalizationWithObservation(context, QualifyingEncounter);
                DataType s_ = NutritionAssessment?.Effective;
                object t_ = FHIRHelpers_4_4_000.Instance.ToValue(context, s_);
                CqlInterval<CqlDateTime> u_ = QICoreCommon_4_0_000.Instance.toInterval(context, t_);
                bool? v_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(r_, u_, default);
                bool? w_ = context.Operators.And(q_, v_);
                DataType x_ = NutritionAssessment?.Value;
                object y_ = FHIRHelpers_4_4_000.Instance.ToValue(context, x_);
                CqlValueSet z_ = this.Nutrition_Assessment_Status_Finding_of_Moderately_Malnourished(context);
                bool? aa_ = context.Operators.ConceptInValueSet(y_ as CqlConcept, z_);
                object ac_ = FHIRHelpers_4_4_000.Instance.ToValue(context, x_);
                CqlValueSet ad_ = this.Nutrition_Assessment_Status_Finding_of_Severely_Malnourished(context);
                bool? ae_ = context.Operators.ConceptInValueSet(ac_ as CqlConcept, ad_);
                bool? af_ = context.Operators.Or(aa_, ae_);
                bool? ag_ = context.Operators.And(w_, af_);
                object ah_()
                {
                    bool am_()
                    {
                        DataType ap_ = NutritionAssessment?.Effective;
                        object aq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ap_);
                        bool ar_ = aq_ is CqlDateTime;

                        return ar_;
                    };
                    bool an_()
                    {
                        DataType as_ = NutritionAssessment?.Effective;
                        object at_ = FHIRHelpers_4_4_000.Instance.ToValue(context, as_);
                        bool au_ = at_ is CqlInterval<CqlDateTime>;

                        return au_;
                    };
                    bool ao_()
                    {
                        DataType av_ = NutritionAssessment?.Effective;
                        object aw_ = FHIRHelpers_4_4_000.Instance.ToValue(context, av_);
                        bool ax_ = aw_ is CqlDateTime;

                        return ax_;
                    };
                    if (am_())
                    {
                        DataType ay_ = NutritionAssessment?.Effective;
                        object az_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ay_);

                        return (az_ as CqlDateTime) as object;
                    }
                    else if (an_())
                    {
                        DataType ba_ = NutritionAssessment?.Effective;
                        object bb_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ba_);

                        return (bb_ as CqlInterval<CqlDateTime>) as object;
                    }
                    else if (ao_())
                    {
                        DataType bc_ = NutritionAssessment?.Effective;
                        object bd_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bc_);

                        return (bd_ as CqlDateTime) as object;
                    }
                    else
                    {
                        return null;
                    }
                };
                CqlDateTime ai_ = QICoreCommon_4_0_000.Instance.latest(context, ah_());
                CqlDateTime aj_ = this.Last_Nutrition_Assessment_Day_During_Encounter(context, QualifyingEncounter);
                bool? ak_ = context.Operators.SameAs(ai_, aj_, "day");
                bool? al_ = context.Operators.And(ag_, ak_);

                return al_;
            };
            IEnumerable<Observation> j_ = context.Operators.Where<Observation>(h_, i_);
            Encounter k_(Observation NutritionAssessment) =>
                QualifyingEncounter;
            IEnumerable<Encounter> l_ = context.Operators.Select<Observation, Encounter>(j_, k_);

            return l_;
        };
        IEnumerable<Encounter> c_ = context.Operators.SelectMany<Encounter, Encounter>(a_, b_);
        Encounter d_(Encounter QualifyingEncounter) =>
            QualifyingEncounter;
        IEnumerable<Encounter> e_ = context.Operators.Select<Encounter, Encounter>(c_, d_);
        IEnumerable<Encounter> f_ = context.Operators.Distinct<Encounter>(e_);

        return f_;
    }


    [CqlExpressionDefinition("Encounter With Most Recent Nutrition Assessment Status of Not or Mildly Malnourished")]
    public IEnumerable<Encounter> Encounter_With_Most_Recent_Nutrition_Assessment_Status_of_Not_or_Mildly_Malnourished(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Measure_Population(context);
        IEnumerable<Encounter> b_(Encounter QualifyingEncounter)
        {
            CqlValueSet g_ = this.Nutrition_Assessment(context);
            IEnumerable<Observation> h_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, g_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation-screening-assessment"));
            bool? i_(Observation NutritionAssessment)
            {
                Code<ObservationStatus> m_ = NutritionAssessment?.StatusElement;
                ObservationStatus? n_ = m_?.Value;
                string o_ = context.Operators.Convert<string>(n_);
                string[] p_ = [
                    "final",
                    "amended",
                    "corrected",
                ];
                bool? q_ = context.Operators.In<string>(o_, (IEnumerable<string>)p_);
                CqlInterval<CqlDateTime> r_ = CQMCommon_4_1_000.Instance.hospitalizationWithObservation(context, QualifyingEncounter);
                DataType s_ = NutritionAssessment?.Effective;
                object t_ = FHIRHelpers_4_4_000.Instance.ToValue(context, s_);
                CqlInterval<CqlDateTime> u_ = QICoreCommon_4_0_000.Instance.toInterval(context, t_);
                bool? v_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(r_, u_, default);
                bool? w_ = context.Operators.And(q_, v_);
                DataType x_ = NutritionAssessment?.Value;
                object y_ = FHIRHelpers_4_4_000.Instance.ToValue(context, x_);
                CqlValueSet z_ = this.Nutrition_Assessment_Status_Finding_of_Well_Nourished_or_Not_Malnourished_or_Mildly_Malnourished(context);
                bool? aa_ = context.Operators.ConceptInValueSet(y_ as CqlConcept, z_);
                bool? ab_ = context.Operators.And(w_, aa_);
                object ac_()
                {
                    bool ah_()
                    {
                        DataType ak_ = NutritionAssessment?.Effective;
                        object al_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ak_);
                        bool am_ = al_ is CqlDateTime;

                        return am_;
                    };
                    bool ai_()
                    {
                        DataType an_ = NutritionAssessment?.Effective;
                        object ao_ = FHIRHelpers_4_4_000.Instance.ToValue(context, an_);
                        bool ap_ = ao_ is CqlInterval<CqlDateTime>;

                        return ap_;
                    };
                    bool aj_()
                    {
                        DataType aq_ = NutritionAssessment?.Effective;
                        object ar_ = FHIRHelpers_4_4_000.Instance.ToValue(context, aq_);
                        bool as_ = ar_ is CqlDateTime;

                        return as_;
                    };
                    if (ah_())
                    {
                        DataType at_ = NutritionAssessment?.Effective;
                        object au_ = FHIRHelpers_4_4_000.Instance.ToValue(context, at_);

                        return (au_ as CqlDateTime) as object;
                    }
                    else if (ai_())
                    {
                        DataType av_ = NutritionAssessment?.Effective;
                        object aw_ = FHIRHelpers_4_4_000.Instance.ToValue(context, av_);

                        return (aw_ as CqlInterval<CqlDateTime>) as object;
                    }
                    else if (aj_())
                    {
                        DataType ax_ = NutritionAssessment?.Effective;
                        object ay_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ax_);

                        return (ay_ as CqlDateTime) as object;
                    }
                    else
                    {
                        return null;
                    }
                };
                CqlDateTime ad_ = QICoreCommon_4_0_000.Instance.latest(context, ac_());
                CqlDateTime ae_ = this.Last_Nutrition_Assessment_Day_During_Encounter(context, QualifyingEncounter);
                bool? af_ = context.Operators.SameAs(ad_, ae_, "day");
                bool? ag_ = context.Operators.And(ab_, af_);

                return ag_;
            };
            IEnumerable<Observation> j_ = context.Operators.Where<Observation>(h_, i_);
            Encounter k_(Observation NutritionAssessment) =>
                QualifyingEncounter;
            IEnumerable<Encounter> l_ = context.Operators.Select<Observation, Encounter>(j_, k_);

            return l_;
        };
        IEnumerable<Encounter> c_ = context.Operators.SelectMany<Encounter, Encounter>(a_, b_);
        Encounter d_(Encounter QualifyingEncounter) =>
            QualifyingEncounter;
        IEnumerable<Encounter> e_ = context.Operators.Select<Encounter, Encounter>(c_, d_);
        IEnumerable<Encounter> f_ = context.Operators.Distinct<Encounter>(e_);

        return f_;
    }


    [CqlExpressionDefinition("Has Malnutrition Diagnosis")]
    public IEnumerable<Condition> Has_Malnutrition_Diagnosis(CqlContext context)
    {
        CqlValueSet a_ = this.Malnutrition_Diagnosis(context);
        IEnumerable<Condition> b_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-problems-health-concerns"));
        bool? c_(Condition MalnutritionDiagnosis)
        {
            CqlInterval<CqlDateTime> e_ = QICoreCommon_4_0_000.Instance.prevalenceInterval(context, MalnutritionDiagnosis as object);
            CqlInterval<CqlDateTime> f_ = this.Measurement_Period(context);
            bool? g_ = context.Operators.Overlaps(e_, f_, default);

            return g_;
        };
        IEnumerable<Condition> d_ = context.Operators.Where<Condition>(b_, c_);

        return d_;
    }


    [CqlExpressionDefinition("Encounter With Encounter Diagnosis Of Malnutrition Diagnosis")]
    public IEnumerable<Encounter> Encounter_With_Encounter_Diagnosis_Of_Malnutrition_Diagnosis(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Measure_Population(context);
        bool? b_(Encounter QualifyingEncounter)
        {
            List<CodeableConcept> d_ = QualifyingEncounter?.ReasonCode;
            CqlConcept e_(CodeableConcept @this)
            {
                CqlConcept o_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);

                return o_;
            };
            IEnumerable<CqlConcept> f_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)d_, e_);
            CqlValueSet g_ = this.Malnutrition_Diagnosis(context);
            bool? h_ = context.Operators.ConceptsInValueSet(f_, g_);
            IEnumerable<Condition> j_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, g_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-encounter-diagnosis"));
            bool? k_(Condition EncounterDiagnosis)
            {
                List<ResourceReference> p_ = QualifyingEncounter?.ReasonReference;
                bool? q_ = QICoreCommon_4_0_000.Instance.references(context, (IEnumerable<ResourceReference>)p_, EncounterDiagnosis);

                return q_;
            };
            IEnumerable<Condition> l_ = context.Operators.Where<Condition>(j_, k_);
            bool? m_ = context.Operators.Exists<Condition>(l_);
            bool? n_ = context.Operators.Or(h_, m_);

            return n_;
        };
        IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);

        return c_;
    }


    [CqlExpressionDefinition("Encounter with Malnutrition Diagnosis")]
    public IEnumerable<Encounter> Encounter_with_Malnutrition_Diagnosis(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Measure_Population(context);
        bool? b_(Encounter QualifyingEncounter)
        {
            IEnumerable<Condition> d_ = this.Has_Malnutrition_Diagnosis(context);
            bool? e_(Condition MalnutritionDiagnosis)
            {
                CqlInterval<CqlDateTime> k_ = QICoreCommon_4_0_000.Instance.prevalenceInterval(context, MalnutritionDiagnosis as object);
                CqlInterval<CqlDateTime> l_ = CQMCommon_4_1_000.Instance.hospitalizationWithObservation(context, QualifyingEncounter);
                bool? m_ = context.Operators.Overlaps(k_, l_, "day");

                return m_;
            };
            IEnumerable<Condition> f_ = context.Operators.Where<Condition>(d_, e_);
            bool? g_ = context.Operators.Exists<Condition>(f_);
            IEnumerable<Encounter> h_ = this.Encounter_With_Encounter_Diagnosis_Of_Malnutrition_Diagnosis(context);
            bool? i_ = context.Operators.Exists<Encounter>(h_);
            bool? j_ = context.Operators.Or(g_, i_);

            return j_;
        };
        IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);

        return c_;
    }


    [CqlExpressionDefinition("Encounter with Nutrition Care Plan")]
    public IEnumerable<Encounter> Encounter_with_Nutrition_Care_Plan(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Measure_Population(context);
        IEnumerable<Encounter> b_(Encounter QualifyingEncounter)
        {
            CqlValueSet g_ = this.Nutrition_Care_Plan(context);
            IEnumerable<Procedure> h_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, g_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
            bool? i_(Procedure NutritionCarePlan)
            {
                Code<EventStatus> m_ = NutritionCarePlan?.StatusElement;
                EventStatus? n_ = m_?.Value;
                string o_ = context.Operators.Convert<string>(n_);
                string[] p_ = [
                    "completed",
                    "in-progress",
                ];
                bool? q_ = context.Operators.In<string>(o_, (IEnumerable<string>)p_);
                DataType r_ = NutritionCarePlan?.Performed;
                object s_ = FHIRHelpers_4_4_000.Instance.ToValue(context, r_);
                CqlDateTime t_ = QICoreCommon_4_0_000.Instance.earliest(context, s_ as object);
                CqlInterval<CqlDateTime> u_ = CQMCommon_4_1_000.Instance.hospitalizationWithObservation(context, QualifyingEncounter);
                bool? v_ = context.Operators.In<CqlDateTime>(t_, u_, default);
                bool? w_ = context.Operators.And(q_, v_);

                return w_;
            };
            IEnumerable<Procedure> j_ = context.Operators.Where<Procedure>(h_, i_);
            Encounter k_(Procedure NutritionCarePlan) =>
                QualifyingEncounter;
            IEnumerable<Encounter> l_ = context.Operators.Select<Procedure, Encounter>(j_, k_);

            return l_;
        };
        IEnumerable<Encounter> c_ = context.Operators.SelectMany<Encounter, Encounter>(a_, b_);
        Encounter d_(Encounter QualifyingEncounter) =>
            QualifyingEncounter;
        IEnumerable<Encounter> e_ = context.Operators.Select<Encounter, Encounter>(c_, d_);
        IEnumerable<Encounter> f_ = context.Operators.Distinct<Encounter>(e_);

        return f_;
    }


    [CqlFunctionDefinition("Measure Observation 1")]
    public int? Measure_Observation_1(CqlContext context, Encounter MalnutritionRiskScreening) =>
        ((context.Operators.Contains<Encounter>(this.Encounter_with_Malnutrition_Risk_Screening_or_with_Dietitian_Referral(context), MalnutritionRiskScreening)) ?? false
            ? 1
            : 0);


    [CqlFunctionDefinition("Measure Observation 2")]
    public int? Measure_Observation_2(CqlContext context, Encounter NutritionAssessment)
    {
        int? a_()
        {
            bool b_()
            {
                IEnumerable<Encounter> d_ = this.Encounter_with_Malnutrition_Not_At_Risk_Screening_and_without_Dietitian_Referral(context);
                bool? e_ = context.Operators.Contains<Encounter>(d_, NutritionAssessment);

                return e_ ?? false;
            };
            bool c_()
            {
                IEnumerable<Encounter> f_ = this.Encounter_with_Malnutrition_Risk_Screening_At_Risk_or_with_Dietitian_Referral(context);
                bool? g_ = context.Operators.Contains<Encounter>(f_, NutritionAssessment);

                return g_ ?? false;
            };
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
        };

        return a_();
    }


    [CqlFunctionDefinition("Measure Observation 3")]
    public int? Measure_Observation_3(CqlContext context, Encounter MalnutritionDiagnosis)
    {
        int? a_()
        {
            bool b_()
            {
                IEnumerable<Encounter> d_ = this.Encounter_with_Malnutrition_Not_At_Risk_Screening_and_without_Dietitian_Referral(context);
                bool? e_ = context.Operators.Contains<Encounter>(d_, MalnutritionDiagnosis);

                return e_ ?? false;
            };
            bool c_()
            {
                IEnumerable<Encounter> f_ = this.Encounter_with_Malnutrition_Risk_Screening_At_Risk_or_with_Dietitian_Referral(context);
                bool? g_ = context.Operators.Contains<Encounter>(f_, MalnutritionDiagnosis);

                return g_ ?? false;
            };
            if (b_())
            {
                return 0;
            }
            else if (c_())
            {
                int? h_()
                {
                    bool i_()
                    {
                        IEnumerable<Encounter> j_ = this.Encounter_with_Malnutrition_Diagnosis(context);
                        bool? k_ = context.Operators.Contains<Encounter>(j_, MalnutritionDiagnosis);

                        return k_ ?? false;
                    };
                    if (i_())
                    {
                        int? l_()
                        {
                            bool m_()
                            {
                                IEnumerable<Encounter> o_ = this.Encounter_With_Most_Recent_Nutrition_Assessment_Status_of_Not_or_Mildly_Malnourished(context);
                                bool? p_ = context.Operators.Contains<Encounter>(o_, MalnutritionDiagnosis);

                                return p_ ?? false;
                            };
                            bool n_()
                            {
                                IEnumerable<Encounter> q_ = this.Encounter_With_Most_Recent_Nutrition_Assessment_Status_of_Moderately_Or_Severely_Malnourished(context);
                                bool? r_ = context.Operators.Contains<Encounter>(q_, MalnutritionDiagnosis);

                                return r_ ?? false;
                            };
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
                        };

                        return l_();
                    }
                    else
                    {
                        return 0;
                    }
                };

                return h_();
            }
            else
            {
                return 0;
            }
        };

        return a_();
    }


    [CqlFunctionDefinition("Measure Observation 4")]
    public int? Measure_Observation_4(CqlContext context, Encounter NutritionCarePlan)
    {
        int? a_()
        {
            bool b_()
            {
                IEnumerable<Encounter> d_ = this.Encounter_with_Malnutrition_Not_At_Risk_Screening_and_without_Dietitian_Referral(context);
                bool? e_ = context.Operators.Contains<Encounter>(d_, NutritionCarePlan);

                return e_ ?? false;
            };
            bool c_()
            {
                IEnumerable<Encounter> f_ = this.Encounter_with_Malnutrition_Risk_Screening_At_Risk_or_with_Dietitian_Referral(context);
                bool? g_ = context.Operators.Contains<Encounter>(f_, NutritionCarePlan);

                return g_ ?? false;
            };
            if (b_())
            {
                return 0;
            }
            else if (c_())
            {
                int? h_()
                {
                    bool i_()
                    {
                        IEnumerable<Encounter> j_ = this.Encounter_with_Nutrition_Care_Plan(context);
                        bool? k_ = context.Operators.Contains<Encounter>(j_, NutritionCarePlan);

                        return k_ ?? false;
                    };
                    if (i_())
                    {
                        int? l_()
                        {
                            bool m_()
                            {
                                IEnumerable<Encounter> o_ = this.Encounter_With_Most_Recent_Nutrition_Assessment_Status_of_Not_or_Mildly_Malnourished(context);
                                bool? p_ = context.Operators.Contains<Encounter>(o_, NutritionCarePlan);

                                return p_ ?? false;
                            };
                            bool n_()
                            {
                                IEnumerable<Encounter> q_ = this.Encounter_With_Most_Recent_Nutrition_Assessment_Status_of_Moderately_Or_Severely_Malnourished(context);
                                bool? r_ = context.Operators.Contains<Encounter>(q_, NutritionCarePlan);

                                return r_ ?? false;
                            };
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
                        };

                        return l_();
                    }
                    else
                    {
                        return 0;
                    }
                };

                return h_();
            }
            else
            {
                return 0;
            }
        };

        return a_();
    }


    [CqlFunctionDefinition("Total Malnutrition Care Score Eligible Occurrences")]
    public int? Total_Malnutrition_Care_Score_Eligible_Occurrences(CqlContext context, Encounter QualifyingEncounter)
    {
        int? a_()
        {
            bool b_()
            {
                IEnumerable<Encounter> d_ = this.Encounter_with_Malnutrition_Risk_Screening_or_with_Dietitian_Referral(context);
                bool? e_ = context.Operators.Contains<Encounter>(d_, QualifyingEncounter);
                IEnumerable<Encounter> f_ = this.Encounter_with_Malnutrition_Risk_Screening_Not_At_Risk(context);
                bool? g_ = context.Operators.Contains<Encounter>(f_, QualifyingEncounter);
                bool? h_ = context.Operators.And(e_, g_);
                IEnumerable<Encounter> i_ = this.Encounter_with_Dietitian_Referral(context);
                bool? j_ = context.Operators.Contains<Encounter>(i_, QualifyingEncounter);
                bool? k_ = context.Operators.Not(j_);
                bool? l_ = context.Operators.And(h_, k_);

                return l_ ?? false;
            };
            bool c_()
            {
                IEnumerable<Encounter> m_ = this.Encounter_with_Malnutrition_Risk_Screening_or_with_Dietitian_Referral(context);
                bool? n_ = context.Operators.Contains<Encounter>(m_, QualifyingEncounter);
                IEnumerable<Encounter> o_ = this.Encounter_with_Malnutrition_Risk_Screening_At_Risk(context);
                bool? p_ = context.Operators.Contains<Encounter>(o_, QualifyingEncounter);
                bool? q_ = context.Operators.And(n_, p_);
                IEnumerable<Encounter> r_ = this.Encounter_with_Dietitian_Referral(context);
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
            };
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
        };

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

    #region CqlTupleMetadata Properties

    private static CqlTupleMetadata CqlTupleMetadata_DSLMMchJhQZgVcNfhbLBSiBYP = new(
      [typeof(string), typeof(CqlInterval<CqlDateTime>), typeof(CqlConcept), typeof(string), typeof(object), typeof(object), typeof(CqlInterval<CqlDateTime>), typeof(CqlDateTime)],
      ["HospEncId", "HospitalizationPeriod", "NutrAssessCode", "NutrAssessId", "NutrAssessResult", "NutrAssessTimingEff", "NutrAssessTimingInt", "NutrAssessTimingLatest"]);

    private static CqlTupleMetadata CqlTupleMetadata_GFjZJIRJbJMHZiLMbCVCEiHgh = new(
      [typeof(Encounter), typeof(Observation)],
      ["QualifyingEncounter", "NutritionAssessment"]);

    #endregion CqlTupleMetadata Properties

}

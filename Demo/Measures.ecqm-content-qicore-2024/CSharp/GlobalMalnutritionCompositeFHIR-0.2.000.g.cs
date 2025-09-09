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
[CqlLibrary("GlobalMalnutritionCompositeFHIR", "0.2.000")]
public partial class GlobalMalnutritionCompositeFHIR_0_2_000 : ILibrary, ISingleton<GlobalMalnutritionCompositeFHIR_0_2_000>
{
    private GlobalMalnutritionCompositeFHIR_0_2_000() {}

    public static GlobalMalnutritionCompositeFHIR_0_2_000 Instance { get; } = new();

    #region ILibrary Implementation

    public string Name => "GlobalMalnutritionCompositeFHIR";
    public string Version => "0.2.000";
    public ILibrary[] Dependencies => [FHIRHelpers_4_4_000.Instance, SupplementalDataElements_3_5_000.Instance, QICoreCommon_2_1_000.Instance, CQMCommon_2_2_000.Instance, Status_1_8_000.Instance];

    #endregion ILibrary Implementation

    #region ValueSets

    [CqlValueSetDefinition("Emergency Department Visit", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.292", valueSetVersion: null)]
    public CqlValueSet Emergency_Department_Visit(CqlContext _) => _Emergency_Department_Visit;
    private static readonly CqlValueSet _Emergency_Department_Visit = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.292", null);

    [CqlValueSetDefinition("Encounter Inpatient", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.666.5.307", valueSetVersion: null)]
    public CqlValueSet Encounter_Inpatient(CqlContext _) => _Encounter_Inpatient;
    private static readonly CqlValueSet _Encounter_Inpatient = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.666.5.307", null);

    [CqlValueSetDefinition("Ethnicity", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.114222.4.11.837", valueSetVersion: null)]
    public CqlValueSet Ethnicity(CqlContext _) => _Ethnicity;
    private static readonly CqlValueSet _Ethnicity = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.114222.4.11.837", null);

    [CqlValueSetDefinition("Hospital Dietitian Referral", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1095.91", valueSetVersion: null)]
    public CqlValueSet Hospital_Dietitian_Referral(CqlContext _) => _Hospital_Dietitian_Referral;
    private static readonly CqlValueSet _Hospital_Dietitian_Referral = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1095.91", null);

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

    [CqlValueSetDefinition("ONC Administrative Sex", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1", valueSetVersion: null)]
    public CqlValueSet ONC_Administrative_Sex(CqlContext _) => _ONC_Administrative_Sex;
    private static readonly CqlValueSet _ONC_Administrative_Sex = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1", null);

    [CqlValueSetDefinition("Payer Type", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.114222.4.11.3591", valueSetVersion: null)]
    public CqlValueSet Payer_Type(CqlContext _) => _Payer_Type;
    private static readonly CqlValueSet _Payer_Type = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.114222.4.11.3591", null);

    [CqlValueSetDefinition("Race", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.114222.4.11.836", valueSetVersion: null)]
    public CqlValueSet Race(CqlContext _) => _Race;
    private static readonly CqlValueSet _Race = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.114222.4.11.836", null);

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
        CqlDateTime a_ = context.Operators.DateTime(2025, 1, 1, 0, 0, 0, 0, 0.0m);
        CqlDateTime b_ = context.Operators.DateTime(2025, 12, 31, 23, 59, 59, 999, 0.0m);
        CqlInterval<CqlDateTime> c_ = context.Operators.Interval(a_, b_, true, true);
        object d_ = context.ResolveParameter("GlobalMalnutritionCompositeFHIR-0.2.000", "Measurement Period", c_);

        return (CqlInterval<CqlDateTime>)d_;
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
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? a_ = SupplementalDataElements_3_5_000.Instance.SDE_Ethnicity(context);

        return a_;
    }


    [CqlExpressionDefinition("SDE Payer Type")]
    public IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> SDE_Payer_Type(CqlContext context)
    {
        IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> a_ = SupplementalDataElements_3_5_000.Instance.SDE_Payer(context);

        return a_;
    }


    [CqlExpressionDefinition("SDE Race")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Race(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? a_ = SupplementalDataElements_3_5_000.Instance.SDE_Race(context);

        return a_;
    }


    [CqlExpressionDefinition("SDE Sex")]
    public CqlCode SDE_Sex(CqlContext context)
    {
        CqlCode a_ = SupplementalDataElements_3_5_000.Instance.SDE_Sex(context);

        return a_;
    }


    [CqlExpressionDefinition("Initial Population")]
    public IEnumerable<Encounter> Initial_Population(CqlContext context)
    {
        CqlValueSet a_ = this.Encounter_Inpatient(context);
        IEnumerable<Encounter> b_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        bool? c_(Encounter EncounterInpatient)
        {
            CqlInterval<CqlDateTime> e_ = this.Measurement_Period(context);
            Period f_ = EncounterInpatient?.Period;
            CqlInterval<CqlDateTime> g_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, f_);
            bool? h_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(e_, g_, "day");
            Patient i_ = this.Patient(context);
            Date j_ = i_?.BirthDateElement;
            string k_ = j_?.Value;
            CqlDate l_ = context.Operators.ConvertStringToDate(k_);
            CqlInterval<CqlDateTime> n_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, f_);
            CqlDateTime o_ = context.Operators.Start(n_);
            CqlDate p_ = context.Operators.DateFrom(o_);
            int? q_ = context.Operators.CalculateAgeAt(l_, p_, "year");
            bool? r_ = context.Operators.GreaterOrEqual(q_, 65);
            bool? s_ = context.Operators.And(h_, r_);
            CqlInterval<CqlDateTime> u_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, f_);
            CqlDateTime v_ = context.Operators.Start(u_);
            CqlInterval<CqlDateTime> x_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, f_);
            CqlDateTime y_ = context.Operators.End(x_);
            int? z_ = context.Operators.DurationBetween(v_, y_, "hour");
            bool? aa_ = context.Operators.GreaterOrEqual(z_, 24);
            bool? ab_ = context.Operators.And(s_, aa_);
            Code<Encounter.EncounterStatus> ac_ = EncounterInpatient?.StatusElement;
            Encounter.EncounterStatus? ad_ = ac_?.Value;
            Code<Encounter.EncounterStatus> ae_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(ad_);
            bool? af_ = context.Operators.Equal(ae_, "finished");
            bool? ag_ = context.Operators.And(ab_, af_);

            return ag_;
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


    [CqlExpressionDefinition("Encounter with Hospital Dietitian Referral")]
    public IEnumerable<Encounter> Encounter_with_Hospital_Dietitian_Referral(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Initial_Population(context);
        CqlValueSet b_ = this.Hospital_Dietitian_Referral(context);
        IEnumerable<Procedure> c_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, b_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
        IEnumerable<ValueTuple<Encounter, Procedure>> d_ = context.Operators.CrossJoin<Encounter, Procedure>(a_, c_);
        (CqlTupleMetadata, Encounter QualifyingEncounter, Procedure HospitalDietitianReferral)? e_(ValueTuple<Encounter, Procedure> _valueTuple)
        {
            (CqlTupleMetadata, Encounter QualifyingEncounter, Procedure HospitalDietitianReferral)? l_ = (CqlTupleMetadata_GVQcZJVjNdGAcjPedLaYDjEME, _valueTuple.Item1, _valueTuple.Item2);

            return l_;
        };
        IEnumerable<(CqlTupleMetadata, Encounter QualifyingEncounter, Procedure HospitalDietitianReferral)?> f_ = context.Operators.Select<ValueTuple<Encounter, Procedure>, (CqlTupleMetadata, Encounter QualifyingEncounter, Procedure HospitalDietitianReferral)?>(d_, e_);
        bool? g_((CqlTupleMetadata, Encounter QualifyingEncounter, Procedure HospitalDietitianReferral)? tuple_blodcpfeecjfnodfofhfzlqfa)
        {
            CodeableConcept m_ = tuple_blodcpfeecjfnodfofhfzlqfa?.HospitalDietitianReferral?.Code;
            CqlConcept n_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, m_);
            CqlValueSet o_ = this.Hospital_Dietitian_Referral(context);
            bool? p_ = context.Operators.ConceptInValueSet(n_ as CqlConcept, o_);
            Code<EventStatus> q_ = tuple_blodcpfeecjfnodfofhfzlqfa?.HospitalDietitianReferral?.StatusElement;
            EventStatus? r_ = q_?.Value;
            string s_ = context.Operators.Convert<string>(r_);
            string[] t_ = [
                "active",
                "completed",
                "in-progress",
            ];
            bool? u_ = context.Operators.In<string>(s_, (IEnumerable<string>)t_);
            bool? v_ = context.Operators.And(p_, u_);
            DataType w_ = tuple_blodcpfeecjfnodfofhfzlqfa?.HospitalDietitianReferral?.Performed;
            object x_ = FHIRHelpers_4_4_000.Instance.ToValue(context, w_);
            CqlDateTime y_ = QICoreCommon_2_1_000.Instance.earliest(context, x_);
            CqlInterval<CqlDateTime> z_ = CQMCommon_2_2_000.Instance.hospitalizationWithObservation(context, tuple_blodcpfeecjfnodfofhfzlqfa?.QualifyingEncounter);
            bool? aa_ = context.Operators.In<CqlDateTime>(y_, z_, default);
            bool? ab_ = context.Operators.And(v_, aa_);

            return ab_;
        };
        IEnumerable<(CqlTupleMetadata, Encounter QualifyingEncounter, Procedure HospitalDietitianReferral)?> h_ = context.Operators.Where<(CqlTupleMetadata, Encounter QualifyingEncounter, Procedure HospitalDietitianReferral)?>(f_, g_);
        Encounter i_((CqlTupleMetadata, Encounter QualifyingEncounter, Procedure HospitalDietitianReferral)? tuple_blodcpfeecjfnodfofhfzlqfa) =>
            tuple_blodcpfeecjfnodfofhfzlqfa?.QualifyingEncounter;
        IEnumerable<Encounter> j_ = context.Operators.Select<(CqlTupleMetadata, Encounter QualifyingEncounter, Procedure HospitalDietitianReferral)?, Encounter>(h_, i_);
        IEnumerable<Encounter> k_ = context.Operators.Distinct<Encounter>(j_);

        return k_;
    }


    [CqlExpressionDefinition("Encounter with Malnutrition Risk Screening")]
    public IEnumerable<Encounter> Encounter_with_Malnutrition_Risk_Screening(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Initial_Population(context);
        CqlValueSet b_ = this.Malnutrition_Risk_Screening(context);
        IEnumerable<Observation> c_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, b_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
        IEnumerable<ValueTuple<Encounter, Observation>> d_ = context.Operators.CrossJoin<Encounter, Observation>(a_, c_);
        (CqlTupleMetadata, Encounter QualifyingEncounter, Observation MalnutritionRiskScreening)? e_(ValueTuple<Encounter, Observation> _valueTuple)
        {
            (CqlTupleMetadata, Encounter QualifyingEncounter, Observation MalnutritionRiskScreening)? l_ = (CqlTupleMetadata_XadcRffdjUdMDMjcTIdSXKKS, _valueTuple.Item1, _valueTuple.Item2);

            return l_;
        };
        IEnumerable<(CqlTupleMetadata, Encounter QualifyingEncounter, Observation MalnutritionRiskScreening)?> f_ = context.Operators.Select<ValueTuple<Encounter, Observation>, (CqlTupleMetadata, Encounter QualifyingEncounter, Observation MalnutritionRiskScreening)?>(d_, e_);
        bool? g_((CqlTupleMetadata, Encounter QualifyingEncounter, Observation MalnutritionRiskScreening)? tuple_bejjtwegpxjsnajsodybefddb)
        {
            CodeableConcept m_ = tuple_bejjtwegpxjsnajsodybefddb?.MalnutritionRiskScreening?.Code;
            CqlConcept n_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, m_);
            CqlValueSet o_ = this.Malnutrition_Risk_Screening(context);
            bool? p_ = context.Operators.ConceptInValueSet(n_ as CqlConcept, o_);
            Code<ObservationStatus> q_ = tuple_bejjtwegpxjsnajsodybefddb?.MalnutritionRiskScreening?.StatusElement;
            ObservationStatus? r_ = q_?.Value;
            Code<ObservationStatus> s_ = context.Operators.Convert<Code<ObservationStatus>>(r_);
            string t_ = context.Operators.Convert<string>(s_);
            string[] u_ = [
                "final",
                "amended",
                "corrected",
            ];
            bool? v_ = context.Operators.In<string>(t_, (IEnumerable<string>)u_);
            bool? w_ = context.Operators.And(p_, v_);
            CqlInterval<CqlDateTime> x_ = CQMCommon_2_2_000.Instance.hospitalizationWithObservation(context, tuple_bejjtwegpxjsnajsodybefddb?.QualifyingEncounter);
            DataType y_ = tuple_bejjtwegpxjsnajsodybefddb?.MalnutritionRiskScreening?.Effective;
            object z_ = FHIRHelpers_4_4_000.Instance.ToValue(context, y_);
            CqlInterval<CqlDateTime> aa_ = QICoreCommon_2_1_000.Instance.toInterval(context, z_);
            bool? ab_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(x_, aa_, default);
            bool? ac_ = context.Operators.And(w_, ab_);
            DataType ad_ = tuple_bejjtwegpxjsnajsodybefddb?.MalnutritionRiskScreening?.Value;
            object ae_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ad_);
            CqlValueSet af_ = this.Malnutrition_Screening_Finding_of_Not_At_Risk_Result(context);
            bool? ag_ = context.Operators.ConceptInValueSet(ae_ as CqlConcept, af_);
            object ai_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ad_);
            CqlValueSet aj_ = this.Malnutrition_Screening_Finding_of_At_Risk_Result(context);
            bool? ak_ = context.Operators.ConceptInValueSet(ai_ as CqlConcept, aj_);
            bool? al_ = context.Operators.Or(ag_, ak_);
            bool? am_ = context.Operators.And(ac_, al_);

            return am_;
        };
        IEnumerable<(CqlTupleMetadata, Encounter QualifyingEncounter, Observation MalnutritionRiskScreening)?> h_ = context.Operators.Where<(CqlTupleMetadata, Encounter QualifyingEncounter, Observation MalnutritionRiskScreening)?>(f_, g_);
        Encounter i_((CqlTupleMetadata, Encounter QualifyingEncounter, Observation MalnutritionRiskScreening)? tuple_bejjtwegpxjsnajsodybefddb) =>
            tuple_bejjtwegpxjsnajsodybefddb?.QualifyingEncounter;
        IEnumerable<Encounter> j_ = context.Operators.Select<(CqlTupleMetadata, Encounter QualifyingEncounter, Observation MalnutritionRiskScreening)?, Encounter>(h_, i_);
        IEnumerable<Encounter> k_ = context.Operators.Distinct<Encounter>(j_);

        return k_;
    }


    [CqlExpressionDefinition("Encounter with Malnutrition Risk Screening or with Hospital Dietitian Referral")]
    public IEnumerable<Encounter> Encounter_with_Malnutrition_Risk_Screening_or_with_Hospital_Dietitian_Referral(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Initial_Population(context);
        bool? b_(Encounter QualifyingEncounter)
        {
            IEnumerable<Encounter> g_ = this.Encounter_with_Malnutrition_Risk_Screening(context);
            bool? h_ = context.Operators.Contains<Encounter>(g_, QualifyingEncounter);
            IEnumerable<Encounter> i_ = this.Encounter_with_Hospital_Dietitian_Referral(context);
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
        IEnumerable<Encounter> a_ = this.Initial_Population(context);
        CqlValueSet b_ = this.Malnutrition_Risk_Screening(context);
        IEnumerable<Observation> c_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, b_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
        IEnumerable<ValueTuple<Encounter, Observation>> d_ = context.Operators.CrossJoin<Encounter, Observation>(a_, c_);
        (CqlTupleMetadata, Encounter QualifyingEncounter, Observation MalnutritionRiskScreening)? e_(ValueTuple<Encounter, Observation> _valueTuple)
        {
            (CqlTupleMetadata, Encounter QualifyingEncounter, Observation MalnutritionRiskScreening)? l_ = (CqlTupleMetadata_XadcRffdjUdMDMjcTIdSXKKS, _valueTuple.Item1, _valueTuple.Item2);

            return l_;
        };
        IEnumerable<(CqlTupleMetadata, Encounter QualifyingEncounter, Observation MalnutritionRiskScreening)?> f_ = context.Operators.Select<ValueTuple<Encounter, Observation>, (CqlTupleMetadata, Encounter QualifyingEncounter, Observation MalnutritionRiskScreening)?>(d_, e_);
        bool? g_((CqlTupleMetadata, Encounter QualifyingEncounter, Observation MalnutritionRiskScreening)? tuple_bejjtwegpxjsnajsodybefddb)
        {
            CodeableConcept m_ = tuple_bejjtwegpxjsnajsodybefddb?.MalnutritionRiskScreening?.Code;
            CqlConcept n_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, m_);
            CqlValueSet o_ = this.Malnutrition_Risk_Screening(context);
            bool? p_ = context.Operators.ConceptInValueSet(n_ as CqlConcept, o_);
            Code<ObservationStatus> q_ = tuple_bejjtwegpxjsnajsodybefddb?.MalnutritionRiskScreening?.StatusElement;
            ObservationStatus? r_ = q_?.Value;
            Code<ObservationStatus> s_ = context.Operators.Convert<Code<ObservationStatus>>(r_);
            string t_ = context.Operators.Convert<string>(s_);
            string[] u_ = [
                "final",
                "amended",
                "corrected",
            ];
            bool? v_ = context.Operators.In<string>(t_, (IEnumerable<string>)u_);
            bool? w_ = context.Operators.And(p_, v_);
            CqlInterval<CqlDateTime> x_ = CQMCommon_2_2_000.Instance.hospitalizationWithObservation(context, tuple_bejjtwegpxjsnajsodybefddb?.QualifyingEncounter);
            DataType y_ = tuple_bejjtwegpxjsnajsodybefddb?.MalnutritionRiskScreening?.Effective;
            object z_ = FHIRHelpers_4_4_000.Instance.ToValue(context, y_);
            CqlInterval<CqlDateTime> aa_ = QICoreCommon_2_1_000.Instance.toInterval(context, z_);
            bool? ab_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(x_, aa_, default);
            bool? ac_ = context.Operators.And(w_, ab_);
            DataType ad_ = tuple_bejjtwegpxjsnajsodybefddb?.MalnutritionRiskScreening?.Value;
            object ae_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ad_);
            CqlValueSet af_ = this.Malnutrition_Screening_Finding_of_Not_At_Risk_Result(context);
            bool? ag_ = context.Operators.ConceptInValueSet(ae_ as CqlConcept, af_);
            bool? ah_ = context.Operators.And(ac_, ag_);

            return ah_;
        };
        IEnumerable<(CqlTupleMetadata, Encounter QualifyingEncounter, Observation MalnutritionRiskScreening)?> h_ = context.Operators.Where<(CqlTupleMetadata, Encounter QualifyingEncounter, Observation MalnutritionRiskScreening)?>(f_, g_);
        Encounter i_((CqlTupleMetadata, Encounter QualifyingEncounter, Observation MalnutritionRiskScreening)? tuple_bejjtwegpxjsnajsodybefddb) =>
            tuple_bejjtwegpxjsnajsodybefddb?.QualifyingEncounter;
        IEnumerable<Encounter> j_ = context.Operators.Select<(CqlTupleMetadata, Encounter QualifyingEncounter, Observation MalnutritionRiskScreening)?, Encounter>(h_, i_);
        IEnumerable<Encounter> k_ = context.Operators.Distinct<Encounter>(j_);

        return k_;
    }


    [CqlExpressionDefinition("Encounter with Malnutrition Not At Risk Screening and without Hospital Dietitian Referral")]
    public IEnumerable<Encounter> Encounter_with_Malnutrition_Not_At_Risk_Screening_and_without_Hospital_Dietitian_Referral(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Initial_Population(context);
        bool? b_(Encounter QualifyingEncounter)
        {
            IEnumerable<Encounter> g_ = this.Encounter_with_Malnutrition_Risk_Screening_Not_At_Risk(context);
            bool? h_ = context.Operators.Contains<Encounter>(g_, QualifyingEncounter);
            IEnumerable<Encounter> i_ = this.Encounter_with_Hospital_Dietitian_Referral(context);
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
        IEnumerable<Encounter> a_ = this.Initial_Population(context);
        CqlValueSet b_ = this.Malnutrition_Risk_Screening(context);
        IEnumerable<Observation> c_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, b_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
        IEnumerable<ValueTuple<Encounter, Observation>> d_ = context.Operators.CrossJoin<Encounter, Observation>(a_, c_);
        (CqlTupleMetadata, Encounter QualifyingEncounter, Observation MalnutritionRiskScreening)? e_(ValueTuple<Encounter, Observation> _valueTuple)
        {
            (CqlTupleMetadata, Encounter QualifyingEncounter, Observation MalnutritionRiskScreening)? l_ = (CqlTupleMetadata_XadcRffdjUdMDMjcTIdSXKKS, _valueTuple.Item1, _valueTuple.Item2);

            return l_;
        };
        IEnumerable<(CqlTupleMetadata, Encounter QualifyingEncounter, Observation MalnutritionRiskScreening)?> f_ = context.Operators.Select<ValueTuple<Encounter, Observation>, (CqlTupleMetadata, Encounter QualifyingEncounter, Observation MalnutritionRiskScreening)?>(d_, e_);
        bool? g_((CqlTupleMetadata, Encounter QualifyingEncounter, Observation MalnutritionRiskScreening)? tuple_bejjtwegpxjsnajsodybefddb)
        {
            CodeableConcept m_ = tuple_bejjtwegpxjsnajsodybefddb?.MalnutritionRiskScreening?.Code;
            CqlConcept n_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, m_);
            CqlValueSet o_ = this.Malnutrition_Risk_Screening(context);
            bool? p_ = context.Operators.ConceptInValueSet(n_ as CqlConcept, o_);
            Code<ObservationStatus> q_ = tuple_bejjtwegpxjsnajsodybefddb?.MalnutritionRiskScreening?.StatusElement;
            ObservationStatus? r_ = q_?.Value;
            Code<ObservationStatus> s_ = context.Operators.Convert<Code<ObservationStatus>>(r_);
            string t_ = context.Operators.Convert<string>(s_);
            string[] u_ = [
                "final",
                "amended",
                "corrected",
            ];
            bool? v_ = context.Operators.In<string>(t_, (IEnumerable<string>)u_);
            bool? w_ = context.Operators.And(p_, v_);
            CqlInterval<CqlDateTime> x_ = CQMCommon_2_2_000.Instance.hospitalizationWithObservation(context, tuple_bejjtwegpxjsnajsodybefddb?.QualifyingEncounter);
            DataType y_ = tuple_bejjtwegpxjsnajsodybefddb?.MalnutritionRiskScreening?.Effective;
            object z_ = FHIRHelpers_4_4_000.Instance.ToValue(context, y_);
            CqlInterval<CqlDateTime> aa_ = QICoreCommon_2_1_000.Instance.toInterval(context, z_);
            bool? ab_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(x_, aa_, default);
            bool? ac_ = context.Operators.And(w_, ab_);
            DataType ad_ = tuple_bejjtwegpxjsnajsodybefddb?.MalnutritionRiskScreening?.Value;
            object ae_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ad_);
            CqlValueSet af_ = this.Malnutrition_Screening_Finding_of_At_Risk_Result(context);
            bool? ag_ = context.Operators.ConceptInValueSet(ae_ as CqlConcept, af_);
            bool? ah_ = context.Operators.And(ac_, ag_);

            return ah_;
        };
        IEnumerable<(CqlTupleMetadata, Encounter QualifyingEncounter, Observation MalnutritionRiskScreening)?> h_ = context.Operators.Where<(CqlTupleMetadata, Encounter QualifyingEncounter, Observation MalnutritionRiskScreening)?>(f_, g_);
        Encounter i_((CqlTupleMetadata, Encounter QualifyingEncounter, Observation MalnutritionRiskScreening)? tuple_bejjtwegpxjsnajsodybefddb) =>
            tuple_bejjtwegpxjsnajsodybefddb?.QualifyingEncounter;
        IEnumerable<Encounter> j_ = context.Operators.Select<(CqlTupleMetadata, Encounter QualifyingEncounter, Observation MalnutritionRiskScreening)?, Encounter>(h_, i_);
        IEnumerable<Encounter> k_ = context.Operators.Distinct<Encounter>(j_);

        return k_;
    }


    [CqlExpressionDefinition("Encounter with Malnutrition Risk Screening At Risk or with Hospital Dietitian Referral")]
    public IEnumerable<Encounter> Encounter_with_Malnutrition_Risk_Screening_At_Risk_or_with_Hospital_Dietitian_Referral(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Initial_Population(context);
        bool? b_(Encounter QualifyingEncounter)
        {
            IEnumerable<Encounter> g_ = this.Encounter_with_Malnutrition_Risk_Screening_At_Risk(context);
            bool? h_ = context.Operators.Contains<Encounter>(g_, QualifyingEncounter);
            IEnumerable<Encounter> i_ = this.Encounter_with_Hospital_Dietitian_Referral(context);
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


    [CqlExpressionDefinition("Encounter with Nutrition Assessment and Identified Status")]
    public IEnumerable<Encounter> Encounter_with_Nutrition_Assessment_and_Identified_Status(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Initial_Population(context);
        CqlValueSet b_ = this.Nutrition_Assessment(context);
        IEnumerable<Observation> c_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, b_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
        IEnumerable<ValueTuple<Encounter, Observation>> d_ = context.Operators.CrossJoin<Encounter, Observation>(a_, c_);
        (CqlTupleMetadata, Encounter QualifyingEncounter, Observation NutritionAssessment)? e_(ValueTuple<Encounter, Observation> _valueTuple)
        {
            (CqlTupleMetadata, Encounter QualifyingEncounter, Observation NutritionAssessment)? l_ = (CqlTupleMetadata_GFjZJIRJbJMHZiLMbCVCEiHgh, _valueTuple.Item1, _valueTuple.Item2);

            return l_;
        };
        IEnumerable<(CqlTupleMetadata, Encounter QualifyingEncounter, Observation NutritionAssessment)?> f_ = context.Operators.Select<ValueTuple<Encounter, Observation>, (CqlTupleMetadata, Encounter QualifyingEncounter, Observation NutritionAssessment)?>(d_, e_);
        bool? g_((CqlTupleMetadata, Encounter QualifyingEncounter, Observation NutritionAssessment)? tuple_hhhypfjvjujitmizocefugcne)
        {
            CodeableConcept m_ = tuple_hhhypfjvjujitmizocefugcne?.NutritionAssessment?.Code;
            CqlConcept n_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, m_);
            CqlValueSet o_ = this.Nutrition_Assessment(context);
            bool? p_ = context.Operators.ConceptInValueSet(n_ as CqlConcept, o_);
            Code<ObservationStatus> q_ = tuple_hhhypfjvjujitmizocefugcne?.NutritionAssessment?.StatusElement;
            ObservationStatus? r_ = q_?.Value;
            Code<ObservationStatus> s_ = context.Operators.Convert<Code<ObservationStatus>>(r_);
            string t_ = context.Operators.Convert<string>(s_);
            string[] u_ = [
                "final",
                "amended",
                "corrected",
            ];
            bool? v_ = context.Operators.In<string>(t_, (IEnumerable<string>)u_);
            bool? w_ = context.Operators.And(p_, v_);
            CqlInterval<CqlDateTime> x_ = CQMCommon_2_2_000.Instance.hospitalizationWithObservation(context, tuple_hhhypfjvjujitmizocefugcne?.QualifyingEncounter);
            DataType y_ = tuple_hhhypfjvjujitmizocefugcne?.NutritionAssessment?.Effective;
            object z_ = FHIRHelpers_4_4_000.Instance.ToValue(context, y_);
            CqlInterval<CqlDateTime> aa_ = QICoreCommon_2_1_000.Instance.toInterval(context, z_);
            bool? ab_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(x_, aa_, default);
            bool? ac_ = context.Operators.And(w_, ab_);
            DataType ad_ = tuple_hhhypfjvjujitmizocefugcne?.NutritionAssessment?.Value;
            object ae_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ad_);
            CqlValueSet af_ = this.Nutrition_Assessment_Status_Finding_of_Moderately_Malnourished(context);
            bool? ag_ = context.Operators.ConceptInValueSet(ae_ as CqlConcept, af_);
            object ai_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ad_);
            CqlValueSet aj_ = this.Nutrition_Assessment_Status_Finding_of_Well_Nourished_or_Not_Malnourished_or_Mildly_Malnourished(context);
            bool? ak_ = context.Operators.ConceptInValueSet(ai_ as CqlConcept, aj_);
            bool? al_ = context.Operators.Or(ag_, ak_);
            object an_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ad_);
            CqlValueSet ao_ = this.Nutrition_Assessment_Status_Finding_of_Severely_Malnourished(context);
            bool? ap_ = context.Operators.ConceptInValueSet(an_ as CqlConcept, ao_);
            bool? aq_ = context.Operators.Or(al_, ap_);
            bool? ar_ = context.Operators.And(ac_, aq_);

            return ar_;
        };
        IEnumerable<(CqlTupleMetadata, Encounter QualifyingEncounter, Observation NutritionAssessment)?> h_ = context.Operators.Where<(CqlTupleMetadata, Encounter QualifyingEncounter, Observation NutritionAssessment)?>(f_, g_);
        Encounter i_((CqlTupleMetadata, Encounter QualifyingEncounter, Observation NutritionAssessment)? tuple_hhhypfjvjujitmizocefugcne) =>
            tuple_hhhypfjvjujitmizocefugcne?.QualifyingEncounter;
        IEnumerable<Encounter> j_ = context.Operators.Select<(CqlTupleMetadata, Encounter QualifyingEncounter, Observation NutritionAssessment)?, Encounter>(h_, i_);
        IEnumerable<Encounter> k_ = context.Operators.Distinct<Encounter>(j_);

        return k_;
    }


    [CqlExpressionDefinition("Encounter with Nutrition Assessment Status Moderately Or Severely Malnourished")]
    public IEnumerable<Encounter> Encounter_with_Nutrition_Assessment_Status_Moderately_Or_Severely_Malnourished(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Initial_Population(context);
        CqlValueSet b_ = this.Nutrition_Assessment(context);
        IEnumerable<Observation> c_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, b_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
        IEnumerable<ValueTuple<Encounter, Observation>> d_ = context.Operators.CrossJoin<Encounter, Observation>(a_, c_);
        (CqlTupleMetadata, Encounter QualifyingEncounter, Observation NutritionAssessment)? e_(ValueTuple<Encounter, Observation> _valueTuple)
        {
            (CqlTupleMetadata, Encounter QualifyingEncounter, Observation NutritionAssessment)? l_ = (CqlTupleMetadata_GFjZJIRJbJMHZiLMbCVCEiHgh, _valueTuple.Item1, _valueTuple.Item2);

            return l_;
        };
        IEnumerable<(CqlTupleMetadata, Encounter QualifyingEncounter, Observation NutritionAssessment)?> f_ = context.Operators.Select<ValueTuple<Encounter, Observation>, (CqlTupleMetadata, Encounter QualifyingEncounter, Observation NutritionAssessment)?>(d_, e_);
        bool? g_((CqlTupleMetadata, Encounter QualifyingEncounter, Observation NutritionAssessment)? tuple_hhhypfjvjujitmizocefugcne)
        {
            CodeableConcept m_ = tuple_hhhypfjvjujitmizocefugcne?.NutritionAssessment?.Code;
            CqlConcept n_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, m_);
            CqlValueSet o_ = this.Nutrition_Assessment(context);
            bool? p_ = context.Operators.ConceptInValueSet(n_ as CqlConcept, o_);
            Code<ObservationStatus> q_ = tuple_hhhypfjvjujitmizocefugcne?.NutritionAssessment?.StatusElement;
            ObservationStatus? r_ = q_?.Value;
            Code<ObservationStatus> s_ = context.Operators.Convert<Code<ObservationStatus>>(r_);
            string t_ = context.Operators.Convert<string>(s_);
            string[] u_ = [
                "final",
                "amended",
                "corrected",
            ];
            bool? v_ = context.Operators.In<string>(t_, (IEnumerable<string>)u_);
            bool? w_ = context.Operators.And(p_, v_);
            CqlInterval<CqlDateTime> x_ = CQMCommon_2_2_000.Instance.hospitalizationWithObservation(context, tuple_hhhypfjvjujitmizocefugcne?.QualifyingEncounter);
            DataType y_ = tuple_hhhypfjvjujitmizocefugcne?.NutritionAssessment?.Effective;
            object z_ = FHIRHelpers_4_4_000.Instance.ToValue(context, y_);
            CqlInterval<CqlDateTime> aa_ = QICoreCommon_2_1_000.Instance.toInterval(context, z_);
            bool? ab_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(x_, aa_, default);
            bool? ac_ = context.Operators.And(w_, ab_);
            DataType ad_ = tuple_hhhypfjvjujitmizocefugcne?.NutritionAssessment?.Value;
            object ae_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ad_);
            CqlValueSet af_ = this.Nutrition_Assessment_Status_Finding_of_Moderately_Malnourished(context);
            bool? ag_ = context.Operators.ConceptInValueSet(ae_ as CqlConcept, af_);
            object ai_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ad_);
            CqlValueSet aj_ = this.Nutrition_Assessment_Status_Finding_of_Severely_Malnourished(context);
            bool? ak_ = context.Operators.ConceptInValueSet(ai_ as CqlConcept, aj_);
            bool? al_ = context.Operators.Or(ag_, ak_);
            bool? am_ = context.Operators.And(ac_, al_);

            return am_;
        };
        IEnumerable<(CqlTupleMetadata, Encounter QualifyingEncounter, Observation NutritionAssessment)?> h_ = context.Operators.Where<(CqlTupleMetadata, Encounter QualifyingEncounter, Observation NutritionAssessment)?>(f_, g_);
        Encounter i_((CqlTupleMetadata, Encounter QualifyingEncounter, Observation NutritionAssessment)? tuple_hhhypfjvjujitmizocefugcne) =>
            tuple_hhhypfjvjujitmizocefugcne?.QualifyingEncounter;
        IEnumerable<Encounter> j_ = context.Operators.Select<(CqlTupleMetadata, Encounter QualifyingEncounter, Observation NutritionAssessment)?, Encounter>(h_, i_);
        IEnumerable<Encounter> k_ = context.Operators.Distinct<Encounter>(j_);

        return k_;
    }


    [CqlExpressionDefinition("Encounter with Nutrition Assessment Not or Mildly Malnourished")]
    public IEnumerable<Encounter> Encounter_with_Nutrition_Assessment_Not_or_Mildly_Malnourished(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Initial_Population(context);
        CqlValueSet b_ = this.Nutrition_Assessment(context);
        IEnumerable<Observation> c_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, b_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
        IEnumerable<ValueTuple<Encounter, Observation>> d_ = context.Operators.CrossJoin<Encounter, Observation>(a_, c_);
        (CqlTupleMetadata, Encounter QualifyingEncounter, Observation NutritionAssessment)? e_(ValueTuple<Encounter, Observation> _valueTuple)
        {
            (CqlTupleMetadata, Encounter QualifyingEncounter, Observation NutritionAssessment)? l_ = (CqlTupleMetadata_GFjZJIRJbJMHZiLMbCVCEiHgh, _valueTuple.Item1, _valueTuple.Item2);

            return l_;
        };
        IEnumerable<(CqlTupleMetadata, Encounter QualifyingEncounter, Observation NutritionAssessment)?> f_ = context.Operators.Select<ValueTuple<Encounter, Observation>, (CqlTupleMetadata, Encounter QualifyingEncounter, Observation NutritionAssessment)?>(d_, e_);
        bool? g_((CqlTupleMetadata, Encounter QualifyingEncounter, Observation NutritionAssessment)? tuple_hhhypfjvjujitmizocefugcne)
        {
            CodeableConcept m_ = tuple_hhhypfjvjujitmizocefugcne?.NutritionAssessment?.Code;
            CqlConcept n_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, m_);
            CqlValueSet o_ = this.Nutrition_Assessment(context);
            bool? p_ = context.Operators.ConceptInValueSet(n_ as CqlConcept, o_);
            Code<ObservationStatus> q_ = tuple_hhhypfjvjujitmizocefugcne?.NutritionAssessment?.StatusElement;
            ObservationStatus? r_ = q_?.Value;
            Code<ObservationStatus> s_ = context.Operators.Convert<Code<ObservationStatus>>(r_);
            string t_ = context.Operators.Convert<string>(s_);
            string[] u_ = [
                "final",
                "amended",
                "corrected",
            ];
            bool? v_ = context.Operators.In<string>(t_, (IEnumerable<string>)u_);
            bool? w_ = context.Operators.And(p_, v_);
            CqlInterval<CqlDateTime> x_ = CQMCommon_2_2_000.Instance.hospitalizationWithObservation(context, tuple_hhhypfjvjujitmizocefugcne?.QualifyingEncounter);
            DataType y_ = tuple_hhhypfjvjujitmizocefugcne?.NutritionAssessment?.Effective;
            object z_ = FHIRHelpers_4_4_000.Instance.ToValue(context, y_);
            CqlInterval<CqlDateTime> aa_ = QICoreCommon_2_1_000.Instance.toInterval(context, z_);
            bool? ab_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(x_, aa_, default);
            bool? ac_ = context.Operators.And(w_, ab_);
            DataType ad_ = tuple_hhhypfjvjujitmizocefugcne?.NutritionAssessment?.Value;
            object ae_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ad_);
            CqlValueSet af_ = this.Nutrition_Assessment_Status_Finding_of_Well_Nourished_or_Not_Malnourished_or_Mildly_Malnourished(context);
            bool? ag_ = context.Operators.ConceptInValueSet(ae_ as CqlConcept, af_);
            bool? ah_ = context.Operators.And(ac_, ag_);

            return ah_;
        };
        IEnumerable<(CqlTupleMetadata, Encounter QualifyingEncounter, Observation NutritionAssessment)?> h_ = context.Operators.Where<(CqlTupleMetadata, Encounter QualifyingEncounter, Observation NutritionAssessment)?>(f_, g_);
        Encounter i_((CqlTupleMetadata, Encounter QualifyingEncounter, Observation NutritionAssessment)? tuple_hhhypfjvjujitmizocefugcne) =>
            tuple_hhhypfjvjujitmizocefugcne?.QualifyingEncounter;
        IEnumerable<Encounter> j_ = context.Operators.Select<(CqlTupleMetadata, Encounter QualifyingEncounter, Observation NutritionAssessment)?, Encounter>(h_, i_);
        IEnumerable<Encounter> k_ = context.Operators.Distinct<Encounter>(j_);

        return k_;
    }


    [CqlExpressionDefinition("Encounter with Malnutrition Diagnosis")]
    public IEnumerable<Encounter> Encounter_with_Malnutrition_Diagnosis(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Initial_Population(context);
        CqlValueSet b_ = this.Malnutrition_Diagnosis(context);
        IEnumerable<Condition> c_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, b_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        IEnumerable<ValueTuple<Encounter, Condition>> d_ = context.Operators.CrossJoin<Encounter, Condition>(a_, c_);
        (CqlTupleMetadata, Encounter QualifyingEncounter, Condition MalnutritionDiagnosis)? e_(ValueTuple<Encounter, Condition> _valueTuple)
        {
            (CqlTupleMetadata, Encounter QualifyingEncounter, Condition MalnutritionDiagnosis)? l_ = (CqlTupleMetadata_CTGXhDDGNAgcaKfhTDIBGVLYU, _valueTuple.Item1, _valueTuple.Item2);

            return l_;
        };
        IEnumerable<(CqlTupleMetadata, Encounter QualifyingEncounter, Condition MalnutritionDiagnosis)?> f_ = context.Operators.Select<ValueTuple<Encounter, Condition>, (CqlTupleMetadata, Encounter QualifyingEncounter, Condition MalnutritionDiagnosis)?>(d_, e_);
        bool? g_((CqlTupleMetadata, Encounter QualifyingEncounter, Condition MalnutritionDiagnosis)? tuple_gsigyornrkjgexbhejviwntmn)
        {
            CodeableConcept m_ = tuple_gsigyornrkjgexbhejviwntmn?.MalnutritionDiagnosis?.Code;
            CqlConcept n_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, m_);
            CqlValueSet o_ = this.Malnutrition_Diagnosis(context);
            bool? p_ = context.Operators.ConceptInValueSet(n_ as CqlConcept, o_);
            CqlInterval<CqlDateTime> q_ = QICoreCommon_2_1_000.Instance.prevalenceInterval(context, tuple_gsigyornrkjgexbhejviwntmn?.MalnutritionDiagnosis);
            CqlInterval<CqlDateTime> r_ = CQMCommon_2_2_000.Instance.hospitalizationWithObservation(context, tuple_gsigyornrkjgexbhejviwntmn?.QualifyingEncounter);
            bool? s_ = context.Operators.Overlaps(q_, r_, default);
            bool? t_ = context.Operators.And(p_, s_);

            return t_;
        };
        IEnumerable<(CqlTupleMetadata, Encounter QualifyingEncounter, Condition MalnutritionDiagnosis)?> h_ = context.Operators.Where<(CqlTupleMetadata, Encounter QualifyingEncounter, Condition MalnutritionDiagnosis)?>(f_, g_);
        Encounter i_((CqlTupleMetadata, Encounter QualifyingEncounter, Condition MalnutritionDiagnosis)? tuple_gsigyornrkjgexbhejviwntmn) =>
            tuple_gsigyornrkjgexbhejviwntmn?.QualifyingEncounter;
        IEnumerable<Encounter> j_ = context.Operators.Select<(CqlTupleMetadata, Encounter QualifyingEncounter, Condition MalnutritionDiagnosis)?, Encounter>(h_, i_);
        IEnumerable<Encounter> k_ = context.Operators.Distinct<Encounter>(j_);

        return k_;
    }


    [CqlExpressionDefinition("Encounter with Nutrition Care Plan")]
    public IEnumerable<Encounter> Encounter_with_Nutrition_Care_Plan(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Initial_Population(context);
        CqlValueSet b_ = this.Nutrition_Care_Plan(context);
        IEnumerable<Procedure> c_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, b_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
        IEnumerable<ValueTuple<Encounter, Procedure>> d_ = context.Operators.CrossJoin<Encounter, Procedure>(a_, c_);
        (CqlTupleMetadata, Encounter QualifyingEncounter, Procedure NutritionCarePlan)? e_(ValueTuple<Encounter, Procedure> _valueTuple)
        {
            (CqlTupleMetadata, Encounter QualifyingEncounter, Procedure NutritionCarePlan)? l_ = (CqlTupleMetadata_TVETjQTNGSKUhAIhIbeKTXMI, _valueTuple.Item1, _valueTuple.Item2);

            return l_;
        };
        IEnumerable<(CqlTupleMetadata, Encounter QualifyingEncounter, Procedure NutritionCarePlan)?> f_ = context.Operators.Select<ValueTuple<Encounter, Procedure>, (CqlTupleMetadata, Encounter QualifyingEncounter, Procedure NutritionCarePlan)?>(d_, e_);
        bool? g_((CqlTupleMetadata, Encounter QualifyingEncounter, Procedure NutritionCarePlan)? tuple_igutmwhaufjcwzmijcgjeysm)
        {
            CodeableConcept m_ = tuple_igutmwhaufjcwzmijcgjeysm?.NutritionCarePlan?.Code;
            CqlConcept n_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, m_);
            CqlValueSet o_ = this.Nutrition_Care_Plan(context);
            bool? p_ = context.Operators.ConceptInValueSet(n_ as CqlConcept, o_);
            Code<EventStatus> q_ = tuple_igutmwhaufjcwzmijcgjeysm?.NutritionCarePlan?.StatusElement;
            EventStatus? r_ = q_?.Value;
            string s_ = context.Operators.Convert<string>(r_);
            string[] t_ = [
                "completed",
                "in-progress",
            ];
            bool? u_ = context.Operators.In<string>(s_, (IEnumerable<string>)t_);
            bool? v_ = context.Operators.And(p_, u_);
            DataType w_ = tuple_igutmwhaufjcwzmijcgjeysm?.NutritionCarePlan?.Performed;
            object x_ = FHIRHelpers_4_4_000.Instance.ToValue(context, w_);
            CqlDateTime y_ = QICoreCommon_2_1_000.Instance.earliest(context, x_);
            CqlInterval<CqlDateTime> z_ = CQMCommon_2_2_000.Instance.hospitalizationWithObservation(context, tuple_igutmwhaufjcwzmijcgjeysm?.QualifyingEncounter);
            bool? aa_ = context.Operators.In<CqlDateTime>(y_, z_, default);
            bool? ab_ = context.Operators.And(v_, aa_);

            return ab_;
        };
        IEnumerable<(CqlTupleMetadata, Encounter QualifyingEncounter, Procedure NutritionCarePlan)?> h_ = context.Operators.Where<(CqlTupleMetadata, Encounter QualifyingEncounter, Procedure NutritionCarePlan)?>(f_, g_);
        Encounter i_((CqlTupleMetadata, Encounter QualifyingEncounter, Procedure NutritionCarePlan)? tuple_igutmwhaufjcwzmijcgjeysm) =>
            tuple_igutmwhaufjcwzmijcgjeysm?.QualifyingEncounter;
        IEnumerable<Encounter> j_ = context.Operators.Select<(CqlTupleMetadata, Encounter QualifyingEncounter, Procedure NutritionCarePlan)?, Encounter>(h_, i_);
        IEnumerable<Encounter> k_ = context.Operators.Distinct<Encounter>(j_);

        return k_;
    }


    [CqlFunctionDefinition("Measure Observation 1")]
    public int? Measure_Observation_1(CqlContext context, Encounter MalnutritionRiskScreening) =>
        ((context.Operators.Contains<Encounter>(this.Encounter_with_Malnutrition_Risk_Screening_or_with_Hospital_Dietitian_Referral(context), MalnutritionRiskScreening)) ?? false
            ? 1
            : 0);


    [CqlFunctionDefinition("Measure Observation 2")]
    public int? Measure_Observation_2(CqlContext context, Encounter NutritionAssessment)
    {
        int? a_()
        {
            bool b_()
            {
                IEnumerable<Encounter> d_ = this.Encounter_with_Malnutrition_Not_At_Risk_Screening_and_without_Hospital_Dietitian_Referral(context);
                bool? e_ = context.Operators.Contains<Encounter>(d_, NutritionAssessment);

                return e_ ?? false;
            };
            bool c_()
            {
                IEnumerable<Encounter> f_ = this.Encounter_with_Malnutrition_Risk_Screening_At_Risk_or_with_Hospital_Dietitian_Referral(context);
                bool? g_ = context.Operators.Contains<Encounter>(f_, NutritionAssessment);

                return g_ ?? false;
            };
            if (b_())
            {
                return 0;
            }
            else if (c_())
            {
                return ((context.Operators.Contains<Encounter>(this.Encounter_with_Nutrition_Assessment_and_Identified_Status(context), NutritionAssessment)) ?? false
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
    public int? Measure_Observation_3(CqlContext context, Encounter MalnutritionDiagonsis)
    {
        int? a_()
        {
            bool b_()
            {
                IEnumerable<Encounter> d_ = this.Encounter_with_Malnutrition_Not_At_Risk_Screening_and_without_Hospital_Dietitian_Referral(context);
                bool? e_ = context.Operators.Contains<Encounter>(d_, MalnutritionDiagonsis);

                return e_ ?? false;
            };
            bool c_()
            {
                IEnumerable<Encounter> f_ = this.Encounter_with_Malnutrition_Risk_Screening_At_Risk_or_with_Hospital_Dietitian_Referral(context);
                bool? g_ = context.Operators.Contains<Encounter>(f_, MalnutritionDiagonsis);

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
                        bool? k_ = context.Operators.Contains<Encounter>(j_, MalnutritionDiagonsis);

                        return k_ ?? false;
                    };
                    if (i_())
                    {
                        int? l_()
                        {
                            bool m_()
                            {
                                IEnumerable<Encounter> o_ = this.Encounter_with_Nutrition_Assessment_Not_or_Mildly_Malnourished(context);
                                bool? p_ = context.Operators.Contains<Encounter>(o_, MalnutritionDiagonsis);

                                return p_ ?? false;
                            };
                            bool n_()
                            {
                                IEnumerable<Encounter> q_ = this.Encounter_with_Nutrition_Assessment_Status_Moderately_Or_Severely_Malnourished(context);
                                bool? r_ = context.Operators.Contains<Encounter>(q_, MalnutritionDiagonsis);

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
                IEnumerable<Encounter> d_ = this.Encounter_with_Malnutrition_Not_At_Risk_Screening_and_without_Hospital_Dietitian_Referral(context);
                bool? e_ = context.Operators.Contains<Encounter>(d_, NutritionCarePlan);

                return e_ ?? false;
            };
            bool c_()
            {
                IEnumerable<Encounter> f_ = this.Encounter_with_Malnutrition_Risk_Screening_At_Risk_or_with_Hospital_Dietitian_Referral(context);
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
                                IEnumerable<Encounter> o_ = this.Encounter_with_Nutrition_Assessment_Not_or_Mildly_Malnourished(context);
                                bool? p_ = context.Operators.Contains<Encounter>(o_, NutritionCarePlan);

                                return p_ ?? false;
                            };
                            bool n_()
                            {
                                IEnumerable<Encounter> q_ = this.Encounter_with_Nutrition_Assessment_Status_Moderately_Or_Severely_Malnourished(context);
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


    [CqlFunctionDefinition("Total Malnutrition Composite Score Eligible Occurrences")]
    public int? Total_Malnutrition_Composite_Score_Eligible_Occurrences(CqlContext context, Encounter QualifyingEncounter)
    {
        int? a_()
        {
            bool b_()
            {
                IEnumerable<Encounter> d_ = this.Encounter_with_Malnutrition_Risk_Screening_or_with_Hospital_Dietitian_Referral(context);
                bool? e_ = context.Operators.Contains<Encounter>(d_, QualifyingEncounter);
                IEnumerable<Encounter> f_ = this.Encounter_with_Malnutrition_Risk_Screening_Not_At_Risk(context);
                bool? g_ = context.Operators.Contains<Encounter>(f_, QualifyingEncounter);
                bool? h_ = context.Operators.And(e_, g_);
                IEnumerable<Encounter> i_ = this.Encounter_with_Hospital_Dietitian_Referral(context);
                bool? j_ = context.Operators.Contains<Encounter>(i_, QualifyingEncounter);
                bool? k_ = context.Operators.Not(j_);
                bool? l_ = context.Operators.And(h_, k_);

                return l_ ?? false;
            };
            bool c_()
            {
                IEnumerable<Encounter> m_ = this.Encounter_with_Malnutrition_Risk_Screening_or_with_Hospital_Dietitian_Referral(context);
                bool? n_ = context.Operators.Contains<Encounter>(m_, QualifyingEncounter);
                IEnumerable<Encounter> o_ = this.Encounter_with_Malnutrition_Risk_Screening_At_Risk(context);
                bool? p_ = context.Operators.Contains<Encounter>(o_, QualifyingEncounter);
                bool? q_ = context.Operators.And(n_, p_);
                IEnumerable<Encounter> r_ = this.Encounter_with_Hospital_Dietitian_Referral(context);
                bool? s_ = context.Operators.Contains<Encounter>(r_, QualifyingEncounter);
                bool? t_ = context.Operators.Or(q_, s_);
                IEnumerable<Encounter> u_ = this.Encounter_with_Nutrition_Assessment_Not_or_Mildly_Malnourished(context);
                bool? v_ = context.Operators.Contains<Encounter>(u_, QualifyingEncounter);
                bool? w_ = context.Operators.And(t_, v_);
                IEnumerable<Encounter> x_ = this.Encounter_with_Nutrition_Assessment_and_Identified_Status(context);
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


    [CqlFunctionDefinition("Measure Observation Total Malnutrition Composite Score as Percentage")]
    public decimal? Measure_Observation_Total_Malnutrition_Composite_Score_as_Percentage(CqlContext context, Encounter QualifyingEncounter)
    {
        decimal? a_ = context.Operators.ConvertIntegerToDecimal(100);
        int? b_ = this.Measure_Observation_Total_Malnutrition_Components_Score(context, QualifyingEncounter);
        decimal? c_ = context.Operators.ConvertIntegerToDecimal(b_);
        int? d_ = this.Total_Malnutrition_Composite_Score_Eligible_Occurrences(context, QualifyingEncounter);
        decimal? e_ = context.Operators.ConvertIntegerToDecimal(d_);
        decimal? f_ = context.Operators.Divide(c_, e_);
        decimal? g_ = context.Operators.Multiply(a_, f_);

        return g_;
    }


    #endregion Functions and Expressions

    #region CqlTupleMetadata Properties

    private static CqlTupleMetadata CqlTupleMetadata_CTGXhDDGNAgcaKfhTDIBGVLYU = new(
      [typeof(Encounter), typeof(Condition)],
      ["QualifyingEncounter", "MalnutritionDiagnosis"]);

    private static CqlTupleMetadata CqlTupleMetadata_GFjZJIRJbJMHZiLMbCVCEiHgh = new(
      [typeof(Encounter), typeof(Observation)],
      ["QualifyingEncounter", "NutritionAssessment"]);

    private static CqlTupleMetadata CqlTupleMetadata_GVQcZJVjNdGAcjPedLaYDjEME = new(
      [typeof(Encounter), typeof(Procedure)],
      ["QualifyingEncounter", "HospitalDietitianReferral"]);

    private static CqlTupleMetadata CqlTupleMetadata_TVETjQTNGSKUhAIhIbeKTXMI = new(
      [typeof(Encounter), typeof(Procedure)],
      ["QualifyingEncounter", "NutritionCarePlan"]);

    private static CqlTupleMetadata CqlTupleMetadata_XadcRffdjUdMDMjcTIdSXKKS = new(
      [typeof(Encounter), typeof(Observation)],
      ["QualifyingEncounter", "MalnutritionRiskScreening"]);

    #endregion CqlTupleMetadata Properties

}

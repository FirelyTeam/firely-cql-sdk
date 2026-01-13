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
[CqlLibrary("DiabetesHemoglobinA1cHbA1cPoorControl9FHIR", "0.0.015")]
public partial class DiabetesHemoglobinA1cHbA1cPoorControl9FHIR_0_0_015 : ILibrary, ISingleton<DiabetesHemoglobinA1cHbA1cPoorControl9FHIR_0_0_015>
{
    #region ValueSets

    [CqlValueSetDefinition("Annual Wellness Visit", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1240", valueSetVersion: null)]
    public CqlValueSet Annual_Wellness_Visit(CqlContext _) => _Annual_Wellness_Visit;
    private static readonly CqlValueSet _Annual_Wellness_Visit = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1240", null);

    [CqlValueSetDefinition("Diabetes", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.103.12.1001", valueSetVersion: null)]
    public CqlValueSet Diabetes(CqlContext _) => _Diabetes;
    private static readonly CqlValueSet _Diabetes = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.103.12.1001", null);

    [CqlValueSetDefinition("Discharged to Health Care Facility for Hospice Care", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.207", valueSetVersion: null)]
    public CqlValueSet Discharged_to_Health_Care_Facility_for_Hospice_Care(CqlContext _) => _Discharged_to_Health_Care_Facility_for_Hospice_Care;
    private static readonly CqlValueSet _Discharged_to_Health_Care_Facility_for_Hospice_Care = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.207", null);

    [CqlValueSetDefinition("Discharged to Home for Hospice Care", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.209", valueSetVersion: null)]
    public CqlValueSet Discharged_to_Home_for_Hospice_Care(CqlContext _) => _Discharged_to_Home_for_Hospice_Care;
    private static readonly CqlValueSet _Discharged_to_Home_for_Hospice_Care = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.209", null);

    [CqlValueSetDefinition("Encounter Inpatient", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.666.5.307", valueSetVersion: null)]
    public CqlValueSet Encounter_Inpatient(CqlContext _) => _Encounter_Inpatient;
    private static readonly CqlValueSet _Encounter_Inpatient = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.666.5.307", null);

    [CqlValueSetDefinition("HbA1c Laboratory Test", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.198.12.1013", valueSetVersion: null)]
    public CqlValueSet HbA1c_Laboratory_Test(CqlContext _) => _HbA1c_Laboratory_Test;
    private static readonly CqlValueSet _HbA1c_Laboratory_Test = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.198.12.1013", null);

    [CqlValueSetDefinition("Home Healthcare Services", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1016", valueSetVersion: null)]
    public CqlValueSet Home_Healthcare_Services(CqlContext _) => _Home_Healthcare_Services;
    private static readonly CqlValueSet _Home_Healthcare_Services = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1016", null);

    [CqlValueSetDefinition("Hospice care ambulatory", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1108.15", valueSetVersion: null)]
    public CqlValueSet Hospice_care_ambulatory(CqlContext _) => _Hospice_care_ambulatory;
    private static readonly CqlValueSet _Hospice_care_ambulatory = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1108.15", null);

    [CqlValueSetDefinition("Office Visit", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1001", valueSetVersion: null)]
    public CqlValueSet Office_Visit(CqlContext _) => _Office_Visit;
    private static readonly CqlValueSet _Office_Visit = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1001", null);

    [CqlValueSetDefinition("Preventive Care Services - Established Office Visit, 18 and Up", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1025", valueSetVersion: null)]
    public CqlValueSet Preventive_Care_Services___Established_Office_Visit__18_and_Up(CqlContext _) => _Preventive_Care_Services___Established_Office_Visit__18_and_Up;
    private static readonly CqlValueSet _Preventive_Care_Services___Established_Office_Visit__18_and_Up = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1025", null);

    [CqlValueSetDefinition("Preventive Care Services-Initial Office Visit, 18 and Up", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1023", valueSetVersion: null)]
    public CqlValueSet Preventive_Care_Services_Initial_Office_Visit__18_and_Up(CqlContext _) => _Preventive_Care_Services_Initial_Office_Visit__18_and_Up;
    private static readonly CqlValueSet _Preventive_Care_Services_Initial_Office_Visit__18_and_Up = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1023", null);

    [CqlValueSetDefinition("Telephone Visits", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1080", valueSetVersion: null)]
    public CqlValueSet Telephone_Visits(CqlContext _) => _Telephone_Visits;
    private static readonly CqlValueSet _Telephone_Visits = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1080", null);

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

    #endregion CodeSystems

    #region Parameters

    [CqlParameterDefinition("Measurement Period")]
    public CqlInterval<CqlDateTime> Measurement_Period(CqlContext context) =>
        ((ICqlContextInternals)context).GetOrCompute<CqlInterval<CqlDateTime>>(-4520572191774736726L, () => {
            object a_ = context.ResolveParameter("DiabetesHemoglobinA1cHbA1cPoorControl9FHIR-0.0.015", "Measurement Period", null);
            return (CqlInterval<CqlDateTime>)a_;
        });


    #endregion Parameters

    #region Functions and Expressions

    [CqlExpressionDefinition("Patient")]
    public Patient Patient(CqlContext context) =>
        ((ICqlContextInternals)context).GetOrCompute<Patient>(-96714460827714486L, () => {
            IEnumerable<Patient> a_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/StructureDefinition/Patient"));
            Patient b_ = context.Operators.SingletonFrom<Patient>(a_);
            return b_;
        });


    [CqlExpressionDefinition("SDE Ethnicity")]
    public IEnumerable<Coding> SDE_Ethnicity(CqlContext context) =>
        ((ICqlContextInternals)context).GetOrCompute<IEnumerable<Coding>>(-3210909341707875286L, () => {
            IEnumerable<Coding> a_ = SupplementalDataElementsFHIR4_2_0_000.Instance.SDE_Ethnicity(context);
            return a_;
        });


    [CqlExpressionDefinition("SDE Payer")]
    public IEnumerable<(CqlTupleMetadata, CodeableConcept code, Period period)?> SDE_Payer(CqlContext context) =>
        ((ICqlContextInternals)context).GetOrCompute<IEnumerable<(CqlTupleMetadata, CodeableConcept code, Period period)?>>(6472043097227869305L, () => {
            IEnumerable<(CqlTupleMetadata, CodeableConcept code, Period period)?> a_ = SupplementalDataElementsFHIR4_2_0_000.Instance.SDE_Payer(context);
            return a_;
        });


    [CqlExpressionDefinition("SDE Race")]
    public IEnumerable<Coding> SDE_Race(CqlContext context) =>
        ((ICqlContextInternals)context).GetOrCompute<IEnumerable<Coding>>(1081731389205157072L, () => {
            IEnumerable<Coding> a_ = SupplementalDataElementsFHIR4_2_0_000.Instance.SDE_Race(context);
            return a_;
        });


    [CqlExpressionDefinition("SDE Sex")]
    public CqlCode SDE_Sex(CqlContext context) =>
        ((ICqlContextInternals)context).GetOrCompute<CqlCode>(24160423480485928L, () => {
            CqlCode a_ = SupplementalDataElementsFHIR4_2_0_000.Instance.SDE_Sex(context);
            return a_;
        });


    [CqlExpressionDefinition("Telehealth Services")]
    public IEnumerable<Encounter> Telehealth_Services(CqlContext context) =>
        ((ICqlContextInternals)context).GetOrCompute<IEnumerable<Encounter>>(-7812937394997141013L, () => {
            CqlValueSet a_ = this.Telephone_Visits(context);
            IEnumerable<Encounter> b_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/StructureDefinition/Encounter"));

            bool? c_(Encounter TelehealthEncounter) {
                Code<Encounter.EncounterStatus> e_ = TelehealthEncounter?.StatusElement;
                string f_ = FHIRHelpers_4_0_001.Instance.ToString(context, e_);
                bool? g_ = context.Operators.Equal(f_, "finished");
                CqlInterval<CqlDateTime> h_ = this.Measurement_Period(context);
                Period i_ = TelehealthEncounter?.Period;
                CqlInterval<CqlDateTime> j_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, i_ as object);
                bool? k_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(h_, j_, default);
                bool? l_ = context.Operators.And(g_, k_);
                return l_;
            }

            IEnumerable<Encounter> d_ = context.Operators.Where<Encounter>(b_, c_);
            return d_;
        });


    [CqlExpressionDefinition("Initial Population")]
    public bool? Initial_Population(CqlContext context) =>
        ((ICqlContextInternals)context).GetOrCompute<bool?>(4777067260090291340L, () => {
            Patient a_ = this.Patient(context);
            Date b_ = a_?.BirthDateElement;
            string c_ = b_?.Value;
            CqlDate d_ = context.Operators.ConvertStringToDate(c_);
            CqlInterval<CqlDateTime> e_ = this.Measurement_Period(context);
            CqlDateTime f_ = context.Operators.Start(e_);
            CqlDate g_ = context.Operators.DateFrom(f_);
            int? h_ = context.Operators.CalculateAgeAt(d_, g_, "year");
            CqlInterval<int?> i_ = context.Operators.Interval(18, 75, true, false);
            bool? j_ = context.Operators.In<int?>(h_, i_, default);
            IEnumerable<Encounter> k_ = AdultOutpatientEncountersFHIR4_2_2_000.Instance.Qualifying_Encounters(context);
            IEnumerable<Encounter> l_ = this.Telehealth_Services(context);
            IEnumerable<Encounter> m_ = context.Operators.Union<Encounter>(k_, l_);
            bool? n_ = context.Operators.Exists<Encounter>(m_);
            bool? o_ = context.Operators.And(j_, n_);
            CqlValueSet p_ = this.Diabetes(context);
            IEnumerable<Condition> q_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, p_, default, "http://hl7.org/fhir/StructureDefinition/Condition"));

            bool? r_(Condition Diabetes) {
                CqlInterval<CqlDateTime> v_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Prevalence_Period(context, Diabetes);
                CqlInterval<CqlDateTime> w_ = this.Measurement_Period(context);
                bool? x_ = context.Operators.Overlaps(v_, w_, default);
                return x_;
            }

            IEnumerable<Condition> s_ = context.Operators.Where<Condition>(q_, r_);
            bool? t_ = context.Operators.Exists<Condition>(s_);
            bool? u_ = context.Operators.And(o_, t_);
            return u_;
        });


    [CqlExpressionDefinition("Denominator")]
    public bool? Denominator(CqlContext context) =>
        ((ICqlContextInternals)context).GetOrCompute<bool?>(5966859978094494253L, () => {
            bool? a_ = this.Initial_Population(context);
            return a_;
        });


    [CqlExpressionDefinition("Most Recent HbA1c")]
    public Observation Most_Recent_HbA1c(CqlContext context) =>
        ((ICqlContextInternals)context).GetOrCompute<Observation>(-4567984027037238177L, () => {
            CqlValueSet a_ = this.HbA1c_Laboratory_Test(context);
            IEnumerable<Observation> b_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/StructureDefinition/Observation"));

            bool? c_(Observation RecentHbA1c) {
                Code<ObservationStatus> h_ = RecentHbA1c?.StatusElement;
                string i_ = FHIRHelpers_4_0_001.Instance.ToString(context, h_);
                string[] j_ = [
                    "final",
                    "amended",
                    "corrected",
                ];
                bool? k_ = context.Operators.In<string>(i_, (IEnumerable<string>)j_);
                DataType l_ = RecentHbA1c?.Effective;
                CqlDateTime m_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Latest(context, l_);
                CqlInterval<CqlDateTime> n_ = this.Measurement_Period(context);
                bool? o_ = context.Operators.In<CqlDateTime>(m_, n_, default);
                bool? p_ = context.Operators.And(k_, o_);
                return p_;
            }

            IEnumerable<Observation> d_ = context.Operators.Where<Observation>(b_, c_);

            object e_(Observation @this) {
                DataType q_ = @this?.Effective;
                CqlInterval<CqlDateTime> r_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, q_);
                CqlDateTime s_ = context.Operators.Start(r_);
                return s_;
            }

            IEnumerable<Observation> f_ = context.Operators.SortBy<Observation>(d_, e_, System.ComponentModel.ListSortDirection.Ascending);
            Observation g_ = context.Operators.Last<Observation>(f_);
            return g_;
        });


    [CqlExpressionDefinition("Has Most Recent HbA1c Without Result")]
    public bool? Has_Most_Recent_HbA1c_Without_Result(CqlContext context) =>
        ((ICqlContextInternals)context).GetOrCompute<bool?>(-1347253088235380747L, () => {
            Observation a_ = this.Most_Recent_HbA1c(context);
            bool? b_ = context.Operators.Not((bool?)(a_ is null));
            DataType d_ = a_?.Value;
            bool? e_ = context.Operators.And(b_, (bool?)(d_ is null));
            return e_;
        });


    [CqlExpressionDefinition("Has Most Recent Elevated HbA1c")]
    public bool? Has_Most_Recent_Elevated_HbA1c(CqlContext context) =>
        ((ICqlContextInternals)context).GetOrCompute<bool?>(3997567915707425043L, () => {
            Observation a_ = this.Most_Recent_HbA1c(context);
            DataType b_ = a_?.Value;
            CqlQuantity c_ = FHIRHelpers_4_0_001.Instance.ToQuantity(context, b_ as Quantity);
            CqlQuantity d_ = context.Operators.Quantity(9m, "%");
            bool? e_ = context.Operators.Greater(c_, d_);
            return e_;
        });


    [CqlExpressionDefinition("Has No Record Of HbA1c")]
    public bool? Has_No_Record_Of_HbA1c(CqlContext context) =>
        ((ICqlContextInternals)context).GetOrCompute<bool?>(-862787414718942807L, () => {
            CqlValueSet a_ = this.HbA1c_Laboratory_Test(context);
            IEnumerable<Observation> b_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/StructureDefinition/Observation"));

            bool? c_(Observation NoHbA1c) {
                Code<ObservationStatus> g_ = NoHbA1c?.StatusElement;
                string h_ = FHIRHelpers_4_0_001.Instance.ToString(context, g_);
                string[] i_ = [
                    "final",
                    "amended",
                    "corrected",
                ];
                bool? j_ = context.Operators.In<string>(h_, (IEnumerable<string>)i_);
                DataType k_ = NoHbA1c?.Effective;
                CqlDateTime l_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Latest(context, k_);
                CqlInterval<CqlDateTime> m_ = this.Measurement_Period(context);
                bool? n_ = context.Operators.In<CqlDateTime>(l_, m_, default);
                bool? o_ = context.Operators.And(j_, n_);
                return o_;
            }

            IEnumerable<Observation> d_ = context.Operators.Where<Observation>(b_, c_);
            bool? e_ = context.Operators.Exists<Observation>(d_);
            bool? f_ = context.Operators.Not(e_);
            return f_;
        });


    [CqlExpressionDefinition("Numerator")]
    public bool? Numerator(CqlContext context) =>
        ((ICqlContextInternals)context).GetOrCompute<bool?>(4507231574648418488L, () => {
            bool? a_ = this.Has_Most_Recent_HbA1c_Without_Result(context);
            bool? b_ = this.Has_Most_Recent_Elevated_HbA1c(context);
            bool? c_ = context.Operators.Or(a_, b_);
            bool? d_ = this.Has_No_Record_Of_HbA1c(context);
            bool? e_ = context.Operators.Or(c_, d_);
            return e_;
        });


    [CqlExpressionDefinition("Denominator Exclusions")]
    public bool? Denominator_Exclusions(CqlContext context) =>
        ((ICqlContextInternals)context).GetOrCompute<bool?>(-2165724986521333321L, () => {
            bool? a_ = HospiceFHIR4_2_3_000.Instance.Has_Hospice(context);
            bool? b_ = AdvancedIllnessandFrailtyExclusionECQMFHIR4_5_17_000.Instance.Advanced_Illness_and_Frailty_Exclusion_Not_Including_Over_Age_80(context);
            bool? c_ = context.Operators.Or(a_, b_);
            Patient d_ = this.Patient(context);
            Date e_ = d_?.BirthDateElement;
            string f_ = e_?.Value;
            CqlDate g_ = context.Operators.ConvertStringToDate(f_);
            CqlInterval<CqlDateTime> h_ = this.Measurement_Period(context);
            CqlDateTime i_ = context.Operators.Start(h_);
            CqlDate j_ = context.Operators.DateFrom(i_);
            int? k_ = context.Operators.CalculateAgeAt(g_, j_, "year");
            bool? l_ = context.Operators.GreaterOrEqual(k_, 65);
            bool? m_ = AdvancedIllnessandFrailtyExclusionECQMFHIR4_5_17_000.Instance.Has_Long_Term_Care_Periods_Longer_Than_90_Consecutive_Days(context);
            bool? n_ = context.Operators.And(l_, m_);
            bool? o_ = context.Operators.Or(c_, n_);
            bool? p_ = PalliativeCareFHIR_0_6_000.Instance.Palliative_Care_in_the_Measurement_Period(context);
            bool? q_ = context.Operators.Or(o_, p_);
            return q_;
        });


    #endregion Functions and Expressions

    #region Singleton Lifetime Members

    private DiabetesHemoglobinA1cHbA1cPoorControl9FHIR_0_0_015() {}

    public static DiabetesHemoglobinA1cHbA1cPoorControl9FHIR_0_0_015 Instance { get; } = new();

    #endregion

    #region ILibrary Implementation

    public string Name => "DiabetesHemoglobinA1cHbA1cPoorControl9FHIR";
    public string Version => "0.0.015";
    public ILibrary[] Dependencies => [FHIRHelpers_4_0_001.Instance, SupplementalDataElementsFHIR4_2_0_000.Instance, MATGlobalCommonFunctionsFHIR4_6_1_000.Instance, PalliativeCareFHIR_0_6_000.Instance, AdultOutpatientEncountersFHIR4_2_2_000.Instance, HospiceFHIR4_2_3_000.Instance, AdvancedIllnessandFrailtyExclusionECQMFHIR4_5_17_000.Instance, CumulativeMedicationDurationFHIR4_1_0_000.Instance];

    #endregion ILibrary Implementation

}

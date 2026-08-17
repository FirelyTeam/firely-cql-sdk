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
[CqlLibrary("HybridHWMFHIR", "0.102.005")]
public partial class HybridHWMFHIR_0_102_005 : ILibrary, ISingleton<HybridHWMFHIR_0_102_005>
{
    #region ValueSets (15)

    [CqlValueSetDefinition("Bicarbonate lab test", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1045.139", valueSetVersion: null)]
    public CqlValueSet Bicarbonate_lab_test(CqlContext _) => _Bicarbonate_lab_test;
    private static readonly CqlValueSet _Bicarbonate_lab_test = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1045.139", null);

    [CqlValueSetDefinition("Body temperature", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1045.152", valueSetVersion: null)]
    public CqlValueSet Body_temperature(CqlContext _) => _Body_temperature;
    private static readonly CqlValueSet _Body_temperature = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1045.152", null);

    [CqlValueSetDefinition("Creatinine lab test", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.666.5.2363", valueSetVersion: null)]
    public CqlValueSet Creatinine_lab_test(CqlContext _) => _Creatinine_lab_test;
    private static readonly CqlValueSet _Creatinine_lab_test = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.666.5.2363", null);

    [CqlValueSetDefinition("Emergency Department Visit", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.292", valueSetVersion: null)]
    public CqlValueSet Emergency_Department_Visit(CqlContext _) => _Emergency_Department_Visit;
    private static readonly CqlValueSet _Emergency_Department_Visit = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.292", null);

    [CqlValueSetDefinition("Encounter Inpatient", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.666.5.307", valueSetVersion: null)]
    public CqlValueSet Encounter_Inpatient(CqlContext _) => _Encounter_Inpatient;
    private static readonly CqlValueSet _Encounter_Inpatient = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.666.5.307", null);

    [CqlValueSetDefinition("Ethnicity", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.114222.4.11.837", valueSetVersion: null)]
    public CqlValueSet Ethnicity(CqlContext _) => _Ethnicity;
    private static readonly CqlValueSet _Ethnicity = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.114222.4.11.837", null);

    [CqlValueSetDefinition("Hematocrit lab test", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1045.114", valueSetVersion: null)]
    public CqlValueSet Hematocrit_lab_test(CqlContext _) => _Hematocrit_lab_test;
    private static readonly CqlValueSet _Hematocrit_lab_test = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1045.114", null);

    [CqlValueSetDefinition("Medicare payer", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1104.10", valueSetVersion: null)]
    public CqlValueSet Medicare_payer(CqlContext _) => _Medicare_payer;
    private static readonly CqlValueSet _Medicare_payer = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1104.10", null);

    [CqlValueSetDefinition("Observation Services", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1111.143", valueSetVersion: null)]
    public CqlValueSet Observation_Services(CqlContext _) => _Observation_Services;
    private static readonly CqlValueSet _Observation_Services = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1111.143", null);

    [CqlValueSetDefinition("ONC Administrative Sex", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1", valueSetVersion: null)]
    public CqlValueSet ONC_Administrative_Sex(CqlContext _) => _ONC_Administrative_Sex;
    private static readonly CqlValueSet _ONC_Administrative_Sex = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1", null);

    [CqlValueSetDefinition("Payer", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.114222.4.11.3591", valueSetVersion: null)]
    public CqlValueSet Payer(CqlContext _) => _Payer;
    private static readonly CqlValueSet _Payer = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.114222.4.11.3591", null);

    [CqlValueSetDefinition("Platelet count lab test", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1045.127", valueSetVersion: null)]
    public CqlValueSet Platelet_count_lab_test(CqlContext _) => _Platelet_count_lab_test;
    private static readonly CqlValueSet _Platelet_count_lab_test = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1045.127", null);

    [CqlValueSetDefinition("Race", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.114222.4.11.836", valueSetVersion: null)]
    public CqlValueSet Race(CqlContext _) => _Race;
    private static readonly CqlValueSet _Race = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.114222.4.11.836", null);

    [CqlValueSetDefinition("Sodium lab test", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1045.119", valueSetVersion: null)]
    public CqlValueSet Sodium_lab_test(CqlContext _) => _Sodium_lab_test;
    private static readonly CqlValueSet _Sodium_lab_test = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1045.119", null);

    [CqlValueSetDefinition("White blood cells count lab test", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1045.129", valueSetVersion: null)]
    public CqlValueSet White_blood_cells_count_lab_test(CqlContext _) => _White_blood_cells_count_lab_test;
    private static readonly CqlValueSet _White_blood_cells_count_lab_test = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1045.129", null);

    #endregion ValueSets

    #region Codes (4)

    [CqlCodeDefinition("Birth date", codeId: "21112-8", codeSystem: "http://loinc.org")]
    public CqlCode Birth_date(CqlContext _) => _Birth_date;
    private static readonly CqlCode _Birth_date = new CqlCode("21112-8", "http://loinc.org");

    [CqlCodeDefinition("Heart rate", codeId: "8867-4", codeSystem: "http://loinc.org")]
    public CqlCode Heart_rate(CqlContext _) => _Heart_rate;
    private static readonly CqlCode _Heart_rate = new CqlCode("8867-4", "http://loinc.org");

    [CqlCodeDefinition("Oxygen saturation in Arterial blood by Pulse oximetry", codeId: "59408-5", codeSystem: "http://loinc.org")]
    public CqlCode Oxygen_saturation_in_Arterial_blood_by_Pulse_oximetry(CqlContext _) => _Oxygen_saturation_in_Arterial_blood_by_Pulse_oximetry;
    private static readonly CqlCode _Oxygen_saturation_in_Arterial_blood_by_Pulse_oximetry = new CqlCode("59408-5", "http://loinc.org");

    [CqlCodeDefinition("Systolic blood pressure", codeId: "8480-6", codeSystem: "http://loinc.org")]
    public CqlCode Systolic_blood_pressure(CqlContext _) => _Systolic_blood_pressure;
    private static readonly CqlCode _Systolic_blood_pressure = new CqlCode("8480-6", "http://loinc.org");

    #endregion Codes

    #region CodeSystems (1)

    [CqlCodeSystemDefinition("LOINC:2.69", codeSystemId: "http://loinc.org", codeSystemVersion: "2.69")]
    public CqlCodeSystem LOINC_2_69(CqlContext _) => _LOINC_2_69;
    private static readonly CqlCodeSystem _LOINC_2_69 =
      new CqlCodeSystem("http://loinc.org", "2.69", [
          _Birth_date,
          _Heart_rate,
          _Oxygen_saturation_in_Arterial_blood_by_Pulse_oximetry,
          _Systolic_blood_pressure]);

    #endregion CodeSystems

    #region Parameters (1)

    [CqlParameterDefinition("Measurement Period")]
    public CqlInterval<CqlDateTime> Measurement_Period(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Measurement_Period, Measurement_Period_Compute);

    private const long _cacheIndex_Measurement_Period = 4314633830159632744L;

    private CqlInterval<CqlDateTime> Measurement_Period_Compute(CqlContext context)
    {
        CqlDateTime a_ = context.Operators.DateTime(2019, 1, 1, 0, 0, 0, 0, (decimal?)default);
        CqlDateTime b_ = context.Operators.DateTime(2020, 1, 1, 0, 0, 0, 0, (decimal?)default);
        CqlInterval<CqlDateTime> c_ = context.Operators.Interval(a_, b_, true, false);
        object d_ = context.ResolveParameter("HybridHWMFHIR-0.102.005", "Measurement Period", c_);
        return (CqlInterval<CqlDateTime>)d_;
    }


    #endregion Parameters

    #region Functions and Expressions (16)

    [CqlExpressionDefinition("Patient")]
    public Patient Patient(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Patient, Patient_Compute);

    private const long _cacheIndex_Patient = 8835465476514977773L;

    private Patient Patient_Compute(CqlContext context)
    {
        IEnumerable<Patient> a_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/StructureDefinition/Patient"));
        Patient b_ = context.Operators.SingletonFrom<Patient>(a_);
        return b_;
    }


    [CqlExpressionDefinition("SDE Ethnicity")]
    public IEnumerable<Coding> SDE_Ethnicity(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_SDE_Ethnicity, SDE_Ethnicity_Compute);

    private const long _cacheIndex_SDE_Ethnicity = -3719427445013547250L;

    private IEnumerable<Coding> SDE_Ethnicity_Compute(CqlContext context)
    {
        IEnumerable<Coding> a_ = SupplementalDataElementsFHIR4_2_0_000.Instance.SDE_Ethnicity(context);
        return a_;
    }


    [CqlExpressionDefinition("SDE Payer")]
    public IEnumerable<(CqlTupleMetadata, CodeableConcept code, Period period)?> SDE_Payer(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_SDE_Payer, SDE_Payer_Compute);

    private const long _cacheIndex_SDE_Payer = -1078891839005630701L;

    private IEnumerable<(CqlTupleMetadata, CodeableConcept code, Period period)?> SDE_Payer_Compute(CqlContext context)
    {
        IEnumerable<(CqlTupleMetadata, CodeableConcept code, Period period)?> a_ = SupplementalDataElementsFHIR4_2_0_000.Instance.SDE_Payer(context);
        return a_;
    }


    [CqlExpressionDefinition("SDE Race")]
    public IEnumerable<Coding> SDE_Race(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_SDE_Race, SDE_Race_Compute);

    private const long _cacheIndex_SDE_Race = -8853324457847174004L;

    private IEnumerable<Coding> SDE_Race_Compute(CqlContext context)
    {
        IEnumerable<Coding> a_ = SupplementalDataElementsFHIR4_2_0_000.Instance.SDE_Race(context);
        return a_;
    }


    [CqlExpressionDefinition("SDE Sex")]
    public CqlCode SDE_Sex(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_SDE_Sex, SDE_Sex_Compute);

    private const long _cacheIndex_SDE_Sex = -350822674919256294L;

    private CqlCode SDE_Sex_Compute(CqlContext context)
    {
        CqlCode a_ = SupplementalDataElementsFHIR4_2_0_000.Instance.SDE_Sex(context);
        return a_;
    }


    [CqlFunctionDefinition("LengthInDays")]
    public int? LengthInDays(CqlContext context, CqlInterval<CqlDateTime> Value)
    {
        CqlDateTime a_ = context.Operators.Start(Value);
        CqlDateTime b_ = context.Operators.End(Value);
        int? c_ = context.Operators.DifferenceBetween(a_, b_, "day");
        return c_;
    }


    [CqlExpressionDefinition("Inpatient Encounters")]
    public IEnumerable<Encounter> Inpatient_Encounters(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Inpatient_Encounters, Inpatient_Encounters_Compute);

    private const long _cacheIndex_Inpatient_Encounters = -6021705685551758731L;

    private IEnumerable<Encounter> Inpatient_Encounters_Compute(CqlContext context)
    {
        CqlValueSet a_ = this.Encounter_Inpatient(context);
        IEnumerable<Encounter> b_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/StructureDefinition/Encounter"));
        CqlValueSet c_ = this.Medicare_payer(context);
        IEnumerable<Coverage> d_ = context.Operators.Retrieve<Coverage>(new RetrieveParameters(default, c_, default, "http://hl7.org/fhir/StructureDefinition/Coverage"));
        IEnumerable<ValueTuple<Encounter, Coverage>> e_ = context.Operators.CrossJoin<Encounter, Coverage>(b_, d_);

        (CqlTupleMetadata, Encounter InpatientEncounter, Coverage Payer)? f_(ValueTuple<Encounter, Coverage> _valueTuple) {
            (CqlTupleMetadata, Encounter InpatientEncounter, Coverage Payer)? k_ = (CqlTupleMetadata_EFSKhGUTUCLEXZENTURVLjeND, _valueTuple.Item1, _valueTuple.Item2);
            return k_;
        }


        bool? g_((CqlTupleMetadata, Encounter InpatientEncounter, Coverage Payer)? tuple_efskhgutuclexzenturvljend) {
            Code<Encounter.EncounterStatus> l_ = tuple_efskhgutuclexzenturvljend?.InpatientEncounter?.StatusElement;
            string m_ = FHIRHelpers_4_0_001.Instance.ToString(context, l_);
            bool? n_ = context.Operators.Equal(m_, "finished");

            CqlBoolean o_() {
                CqlInterval<CqlDateTime> r_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.HospitalizationWithObservation(context, tuple_efskhgutuclexzenturvljend?.InpatientEncounter);
                int? s_ = this.LengthInDays(context, r_);
                bool? t_ = context.Operators.Less(s_, 365);
                return t_;
            }


            CqlBoolean p_() {
                Period u_ = tuple_efskhgutuclexzenturvljend?.InpatientEncounter?.Period;
                CqlInterval<CqlDateTime> v_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, u_);
                CqlDateTime w_ = context.Operators.End(v_);
                CqlInterval<CqlDateTime> x_ = this.Measurement_Period(context);
                bool? y_ = context.Operators.In<CqlDateTime>(w_, x_, "day");
                return y_;
            }


            CqlBoolean q_() {
                Patient z_ = this.Patient(context);
                Date aa_ = z_?.BirthDateElement;
                string ab_ = aa_?.Value;
                CqlDate ac_ = context.Operators.ConvertStringToDate(ab_);
                Period ad_ = tuple_efskhgutuclexzenturvljend?.InpatientEncounter?.Period;
                CqlInterval<CqlDateTime> ae_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, ad_);
                CqlDateTime af_ = context.Operators.Start(ae_);
                CqlDate ag_ = context.Operators.DateFrom(af_);
                int? ah_ = context.Operators.CalculateAgeAt(ac_, ag_, "year");
                CqlInterval<int?> ai_ = context.Operators.Interval(65, 94, true, true);
                bool? aj_ = context.Operators.In<int?>(ah_, ai_, (string)default);
                return aj_;
            }

            return (bool?)(/* CQL 'and' (58:101-61:187) */ (/* CQL 'and' (58:107-60:169) */ (/* CQL 'and' (58:107-59:189) */ ((CqlBoolean)n_
                && o_())
                && p_())
                && q_()));
        }

        IEnumerable<(CqlTupleMetadata, Encounter InpatientEncounter, Coverage Payer)?> h_ = context.Operators.SelectWhere<ValueTuple<Encounter, Coverage>, (CqlTupleMetadata, Encounter InpatientEncounter, Coverage Payer)?>(e_, f_, g_);
        Encounter i_((CqlTupleMetadata, Encounter InpatientEncounter, Coverage Payer)? tuple_efskhgutuclexzenturvljend) => tuple_efskhgutuclexzenturvljend?.InpatientEncounter;
        IEnumerable<Encounter> j_ = context.Operators.SelectDistinct<(CqlTupleMetadata, Encounter InpatientEncounter, Coverage Payer)?, Encounter>(h_, i_);
        return j_;
    }


    [CqlExpressionDefinition("Initial Population")]
    public IEnumerable<Encounter> Initial_Population(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Initial_Population, Initial_Population_Compute);

    private const long _cacheIndex_Initial_Population = -269835035246195375L;

    private IEnumerable<Encounter> Initial_Population_Compute(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Inpatient_Encounters(context);
        return a_;
    }


    [CqlFunctionDefinition("FirstPhysicalExamWithEncounterId")]
    public IEnumerable<string> FirstPhysicalExamWithEncounterId(CqlContext context, IEnumerable<Observation> ExamList, string CCDE)
    {
        IEnumerable<Encounter> a_ = this.Inpatient_Encounters(context);

        string b_(Encounter Encounter) {
            string d_ = context.Operators.Concatenate("\r\n", CCDE ?? "");
            string e_ = context.Operators.Concatenate(d_ ?? "", ",");
            Id f_ = Encounter?.IdElement;
            string g_ = FHIRHelpers_4_0_001.Instance.ToString(context, f_);
            string h_ = context.Operators.Concatenate(e_ ?? "", g_ ?? "");
            string i_ = context.Operators.Concatenate(h_ ?? "", " , ");

            bool? j_(Observation Exam) {
                DataType ad_ = Exam?.Effective;
                CqlInterval<CqlDateTime> ae_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, ad_);
                CqlDateTime af_ = context.Operators.Start(ae_);

                CqlBoolean ag_() {
                    DataType ai_ = Exam?.Effective;
                    CqlInterval<CqlDateTime> aj_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, ai_);
                    CqlDateTime ak_ = context.Operators.Start(aj_);
                    Period al_ = Encounter?.Period;
                    CqlInterval<CqlDateTime> am_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, al_);
                    CqlDateTime an_ = context.Operators.Start(am_);
                    CqlQuantity ao_ = context.Operators.Quantity(1440m, "minutes");
                    CqlDateTime ap_ = context.Operators.Subtract(an_, ao_);
                    CqlQuantity aq_ = context.Operators.Quantity(120m, "minutes");
                    CqlDateTime ar_ = context.Operators.Add(an_, aq_);
                    CqlInterval<CqlDateTime> as_ = context.Operators.Interval(ap_, ar_, true, true);
                    bool? at_ = context.Operators.In<CqlDateTime>(ak_, as_, (string)default);
                    return at_;
                }


                CqlBoolean ah_() {
                    Code<ObservationStatus> au_ = Exam?.StatusElement;
                    string av_ = FHIRHelpers_4_0_001.Instance.ToString(context, au_);
                    string[] aw_ = [
                        "final",
                        "amended",
                        "preliminary",
                    ];
                    bool? ax_ = context.Operators.In<string>(av_, (IEnumerable<string>)aw_);
                    return ax_;
                }

                return (bool?)(/* CQL 'and' (120:7-122:32) */ (/* CQL 'and' (120:13-121:60) */ (/* CQL 'and' (120:13-120:232) */ ((CqlBoolean)(!((bool?)(af_ is null)))
                    && ag_())
                    && ah_())
                    && (CqlBoolean)(!((bool?)(Exam?.Value is null)))));
            }

            IEnumerable<Observation> k_ = context.Operators.Where<Observation>(ExamList, j_);

            object l_(Observation @this) {
                DataType ay_ = @this?.Effective;
                CqlInterval<CqlDateTime> az_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, ay_);
                CqlDateTime ba_ = context.Operators.Start(az_);
                return ba_;
            }

            IEnumerable<Observation> m_ = context.Operators.SortBy<Observation>(k_, l_, System.ComponentModel.ListSortDirection.Ascending);
            Observation n_ = context.Operators.First<Observation>(m_);
            DataType o_ = n_?.Value;
            CqlQuantity p_ = FHIRHelpers_4_0_001.Instance.ToQuantity(context, o_ as Quantity);
            string q_ = context.Operators.ConvertQuantityToString(p_);
            string r_ = context.Operators.Concatenate(i_ ?? "", q_ ?? "");
            string s_ = context.Operators.Concatenate(r_ ?? "", ",");

            bool? t_(Observation Exam) {
                DataType bb_ = Exam?.Effective;
                CqlInterval<CqlDateTime> bc_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, bb_);
                CqlDateTime bd_ = context.Operators.Start(bc_);

                CqlBoolean be_() {
                    DataType bg_ = Exam?.Effective;
                    CqlInterval<CqlDateTime> bh_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, bg_);
                    CqlDateTime bi_ = context.Operators.Start(bh_);
                    Period bj_ = Encounter?.Period;
                    CqlInterval<CqlDateTime> bk_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, bj_);
                    CqlDateTime bl_ = context.Operators.Start(bk_);
                    CqlQuantity bm_ = context.Operators.Quantity(1440m, "minutes");
                    CqlDateTime bn_ = context.Operators.Subtract(bl_, bm_);
                    CqlQuantity bo_ = context.Operators.Quantity(120m, "minutes");
                    CqlDateTime bp_ = context.Operators.Add(bl_, bo_);
                    CqlInterval<CqlDateTime> bq_ = context.Operators.Interval(bn_, bp_, true, true);
                    bool? br_ = context.Operators.In<CqlDateTime>(bi_, bq_, (string)default);
                    return br_;
                }


                CqlBoolean bf_() {
                    Code<ObservationStatus> bs_ = Exam?.StatusElement;
                    string bt_ = FHIRHelpers_4_0_001.Instance.ToString(context, bs_);
                    string[] bu_ = [
                        "final",
                        "amended",
                        "preliminary",
                    ];
                    bool? bv_ = context.Operators.In<string>(bt_, (IEnumerable<string>)bu_);
                    return bv_;
                }

                return (bool?)(/* CQL 'and' (120:7-122:32) */ (/* CQL 'and' (120:13-121:60) */ (/* CQL 'and' (120:13-120:232) */ ((CqlBoolean)(!((bool?)(bd_ is null)))
                    && be_())
                    && bf_())
                    && (CqlBoolean)(!((bool?)(Exam?.Value is null)))));
            }

            IEnumerable<Observation> u_ = context.Operators.Where<Observation>(ExamList, t_);

            object v_(Observation @this) {
                DataType bw_ = @this?.Effective;
                CqlInterval<CqlDateTime> bx_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, bw_);
                CqlDateTime by_ = context.Operators.Start(bx_);
                return by_;
            }

            IEnumerable<Observation> w_ = context.Operators.SortBy<Observation>(u_, v_, System.ComponentModel.ListSortDirection.Ascending);
            Observation x_ = context.Operators.First<Observation>(w_);
            DataType y_ = x_?.Effective;
            CqlInterval<CqlDateTime> z_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, y_);
            CqlDateTime aa_ = context.Operators.Start(z_);
            string ab_ = context.Operators.ConvertDateTimeToString(aa_);
            string ac_ = context.Operators.Concatenate(s_ ?? "", ab_ ?? "");
            return ac_;
        }

        IEnumerable<string> c_ = context.Operators.SelectDistinct<Encounter, string>(a_, b_);
        return c_;
    }


    [CqlFunctionDefinition("FirstLabTestWithEncounterId")]
    public IEnumerable<string> FirstLabTestWithEncounterId(CqlContext context, IEnumerable<Observation> LabList, string CCDE)
    {
        IEnumerable<Encounter> a_ = this.Inpatient_Encounters(context);

        string b_(Encounter Encounter) {
            string d_ = context.Operators.Concatenate("\r\n", CCDE ?? "");
            string e_ = context.Operators.Concatenate(d_ ?? "", ",");
            Id f_ = Encounter?.IdElement;
            string g_ = FHIRHelpers_4_0_001.Instance.ToString(context, f_);
            string h_ = context.Operators.Concatenate(e_ ?? "", g_ ?? "");
            string i_ = context.Operators.Concatenate(h_ ?? "", ",");

            bool? j_(Observation Lab) {
                Instant ac_ = Lab?.IssuedElement;

                CqlBoolean ad_() {
                    Instant af_ = Lab?.IssuedElement;
                    CqlDateTime ag_ = FHIRHelpers_4_0_001.Instance.ToDateTime(context, af_);
                    Period ah_ = Encounter?.Period;
                    CqlInterval<CqlDateTime> ai_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, ah_);
                    CqlDateTime aj_ = context.Operators.Start(ai_);
                    CqlQuantity ak_ = context.Operators.Quantity(1440m, "minutes");
                    CqlDateTime al_ = context.Operators.Subtract(aj_, ak_);
                    CqlDateTime am_ = context.Operators.Add(aj_, ak_);
                    CqlInterval<CqlDateTime> an_ = context.Operators.Interval(al_, am_, true, true);
                    bool? ao_ = context.Operators.In<CqlDateTime>(ag_, an_, (string)default);
                    return ao_;
                }


                CqlBoolean ae_() {
                    Code<ObservationStatus> ap_ = Lab?.StatusElement;
                    string aq_ = FHIRHelpers_4_0_001.Instance.ToString(context, ap_);
                    string[] ar_ = [
                        "final",
                        "amended",
                        "preliminary",
                    ];
                    bool? as_ = context.Operators.In<string>(aq_, (IEnumerable<string>)ar_);
                    return as_;
                }

                return (bool?)(/* CQL 'and' (112:7-113:85) */ (/* CQL 'and' (112:13-113:59) */ (/* CQL 'and' (112:13-112:149) */ ((CqlBoolean)(!((bool?)(ac_ is null)))
                    && ad_())
                    && ae_())
                    && (CqlBoolean)(!((bool?)(Lab?.Value is null)))));
            }

            IEnumerable<Observation> k_ = context.Operators.Where<Observation>(LabList, j_);

            object l_(Observation @this) {
                Instant at_ = @this?.IssuedElement;
                return at_;
            }

            IEnumerable<Observation> m_ = context.Operators.SortBy<Observation>(k_, l_, System.ComponentModel.ListSortDirection.Ascending);
            Observation n_ = context.Operators.First<Observation>(m_);
            DataType o_ = n_?.Value;
            CqlQuantity p_ = FHIRHelpers_4_0_001.Instance.ToQuantity(context, o_ as Quantity);
            string q_ = context.Operators.ConvertQuantityToString(p_);
            string r_ = context.Operators.Concatenate(i_ ?? "", q_ ?? "");
            string s_ = context.Operators.Concatenate(r_ ?? "", ",");

            bool? t_(Observation Lab) {
                Instant au_ = Lab?.IssuedElement;

                CqlBoolean av_() {
                    Instant ax_ = Lab?.IssuedElement;
                    CqlDateTime ay_ = FHIRHelpers_4_0_001.Instance.ToDateTime(context, ax_);
                    Period az_ = Encounter?.Period;
                    CqlInterval<CqlDateTime> ba_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, az_);
                    CqlDateTime bb_ = context.Operators.Start(ba_);
                    CqlQuantity bc_ = context.Operators.Quantity(1440m, "minutes");
                    CqlDateTime bd_ = context.Operators.Subtract(bb_, bc_);
                    CqlDateTime be_ = context.Operators.Add(bb_, bc_);
                    CqlInterval<CqlDateTime> bf_ = context.Operators.Interval(bd_, be_, true, true);
                    bool? bg_ = context.Operators.In<CqlDateTime>(ay_, bf_, (string)default);
                    return bg_;
                }


                CqlBoolean aw_() {
                    Code<ObservationStatus> bh_ = Lab?.StatusElement;
                    string bi_ = FHIRHelpers_4_0_001.Instance.ToString(context, bh_);
                    string[] bj_ = [
                        "final",
                        "amended",
                        "preliminary",
                    ];
                    bool? bk_ = context.Operators.In<string>(bi_, (IEnumerable<string>)bj_);
                    return bk_;
                }

                return (bool?)(/* CQL 'and' (112:7-113:85) */ (/* CQL 'and' (112:13-113:59) */ (/* CQL 'and' (112:13-112:149) */ ((CqlBoolean)(!((bool?)(au_ is null)))
                    && av_())
                    && aw_())
                    && (CqlBoolean)(!((bool?)(Lab?.Value is null)))));
            }

            IEnumerable<Observation> u_ = context.Operators.Where<Observation>(LabList, t_);

            object v_(Observation @this) {
                Instant bl_ = @this?.IssuedElement;
                return bl_;
            }

            IEnumerable<Observation> w_ = context.Operators.SortBy<Observation>(u_, v_, System.ComponentModel.ListSortDirection.Ascending);
            Observation x_ = context.Operators.First<Observation>(w_);
            Instant y_ = x_?.IssuedElement;
            CqlDateTime z_ = FHIRHelpers_4_0_001.Instance.ToDateTime(context, y_);
            string aa_ = context.Operators.ConvertDateTimeToString(z_);
            string ab_ = context.Operators.Concatenate(s_ ?? "", aa_ ?? "");
            return ab_;
        }

        IEnumerable<string> c_ = context.Operators.SelectDistinct<Encounter, string>(a_, b_);
        return c_;
    }


    [CqlExpressionDefinition("Results")]
    public IEnumerable<string> Results(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Results, Results_Compute);

    private const long _cacheIndex_Results = -4855238322374877353L;

    private IEnumerable<string> Results_Compute(CqlContext context)
    {
        CqlCode a_ = this.Heart_rate(context);
        IEnumerable<CqlCode> b_ = context.Operators.ToList<CqlCode>(a_);
        IEnumerable<Observation> c_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, b_, "http://hl7.org/fhir/StructureDefinition/Observation"));
        IEnumerable<string> d_ = this.FirstPhysicalExamWithEncounterId(context, c_, "FirstHeartRate");
        CqlCode e_ = this.Systolic_blood_pressure(context);
        IEnumerable<CqlCode> f_ = context.Operators.ToList<CqlCode>(e_);
        IEnumerable<Observation> g_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, f_, "http://hl7.org/fhir/StructureDefinition/Observation"));
        IEnumerable<string> h_ = this.FirstPhysicalExamWithEncounterId(context, g_, "FirstSystolicBP");
        CqlValueSet i_ = this.Body_temperature(context);
        IEnumerable<Observation> j_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, i_, default, "http://hl7.org/fhir/StructureDefinition/Observation"));
        IEnumerable<string> k_ = this.FirstPhysicalExamWithEncounterId(context, j_, "FirstTemperature");
        CqlCode l_ = this.Oxygen_saturation_in_Arterial_blood_by_Pulse_oximetry(context);
        IEnumerable<CqlCode> m_ = context.Operators.ToList<CqlCode>(l_);
        IEnumerable<Observation> n_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, m_, "http://hl7.org/fhir/StructureDefinition/Observation"));
        IEnumerable<string> o_ = this.FirstPhysicalExamWithEncounterId(context, n_, "FirstO2Saturation");
        CqlValueSet p_ = this.Hematocrit_lab_test(context);
        IEnumerable<Observation> q_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, p_, default, "http://hl7.org/fhir/StructureDefinition/Observation"));
        IEnumerable<string> r_ = this.FirstLabTestWithEncounterId(context, q_, "FirstHematocrit");
        CqlValueSet s_ = this.Platelet_count_lab_test(context);
        IEnumerable<Observation> t_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, s_, default, "http://hl7.org/fhir/StructureDefinition/Observation"));
        IEnumerable<string> u_ = this.FirstLabTestWithEncounterId(context, t_, "FirstPlateletCount");
        CqlValueSet v_ = this.White_blood_cells_count_lab_test(context);
        IEnumerable<Observation> w_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, v_, default, "http://hl7.org/fhir/StructureDefinition/Observation"));
        IEnumerable<string> x_ = this.FirstLabTestWithEncounterId(context, w_, "FirstWhiteBloodCell");
        CqlValueSet y_ = this.Sodium_lab_test(context);
        IEnumerable<Observation> z_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, y_, default, "http://hl7.org/fhir/StructureDefinition/Observation"));
        IEnumerable<string> aa_ = this.FirstLabTestWithEncounterId(context, z_, "FirstSodium");
        CqlValueSet ab_ = this.Bicarbonate_lab_test(context);
        IEnumerable<Observation> ac_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, ab_, default, "http://hl7.org/fhir/StructureDefinition/Observation"));
        IEnumerable<string> ad_ = this.FirstLabTestWithEncounterId(context, ac_, "FirstBicarbonate");
        CqlValueSet ae_ = this.Creatinine_lab_test(context);
        IEnumerable<Observation> af_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, ae_, default, "http://hl7.org/fhir/StructureDefinition/Observation"));
        IEnumerable<string> ag_ = this.FirstLabTestWithEncounterId(context, af_, "FirstCreatinine");
        IEnumerable<string>[] ah_ = [
            d_,
            h_,
            k_,
            o_,
            r_,
            u_,
            x_,
            aa_,
            ad_,
            ag_,
        ];
        IEnumerable<string> ai_ = context.Operators.Flatten<string>((IEnumerable<IEnumerable<string>>)ah_);
        return ai_;
    }


    [CqlFunctionDefinition("CalendarAgeInYearsAt")]
    public int? CalendarAgeInYearsAt(CqlContext context, CqlDateTime BirthDateTime, CqlDateTime AsOf)
    {
        CqlDateTime a_ = this.ToDate(context, BirthDateTime);
        CqlDateTime b_ = this.ToDate(context, AsOf);
        int? c_ = context.Operators.DurationBetween(a_, b_, "year");
        return c_;
    }


    [CqlFunctionDefinition("ToDate")]
    public CqlDateTime ToDate(CqlContext context, CqlDateTime Value)
    {
        int? a_ = context.Operators.DateTimeComponentFrom(Value, "year");
        int? b_ = context.Operators.DateTimeComponentFrom(Value, "month");
        int? c_ = context.Operators.DateTimeComponentFrom(Value, "day");
        decimal? d_ = context.Operators.TimezoneOffsetFrom(Value);
        CqlDateTime e_ = context.Operators.DateTime(a_, b_, c_, 0, 0, 0, 0, d_);
        return e_;
    }


    [CqlFunctionDefinition("LengthOfStay")]
    public int? LengthOfStay(CqlContext context, CqlInterval<CqlDateTime> Stay)
    {
        CqlDateTime a_ = context.Operators.Start(Stay);
        CqlDateTime b_ = context.Operators.End(Stay);
        int? c_ = context.Operators.DifferenceBetween(a_, b_, "day");
        return c_;
    }


    [CqlFunctionDefinition("HospitalizationWithObservation")]
    public CqlInterval<CqlDateTime> HospitalizationWithObservation(CqlContext context, Encounter TheEncounter)
    {
        Encounter[] a_ = [
            TheEncounter,
        ];

        CqlInterval<CqlDateTime> b_(Encounter Visit) {
            CqlValueSet e_ = this.Emergency_Department_Visit(context);
            IEnumerable<Encounter> f_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, e_, default, "http://hl7.org/fhir/StructureDefinition/Encounter"));

            bool? g_(Encounter LastED) {
                Period ad_ = LastED?.Period;
                CqlInterval<CqlDateTime> ae_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, ad_);
                CqlDateTime af_ = context.Operators.End(ae_);
                CqlValueSet ag_ = this.Observation_Services(context);
                IEnumerable<Encounter> ah_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, ag_, default, "http://hl7.org/fhir/StructureDefinition/Encounter"));

                bool? ai_(Encounter LastObs) {
                    Period bg_ = LastObs?.Period;
                    CqlInterval<CqlDateTime> bh_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, bg_);
                    CqlDateTime bi_ = context.Operators.End(bh_);
                    Period bj_ = Visit?.Period;
                    CqlInterval<CqlDateTime> bk_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, bj_);
                    CqlDateTime bl_ = context.Operators.Start(bk_);
                    CqlQuantity bm_ = context.Operators.Quantity(1m, "hour");
                    CqlDateTime bn_ = context.Operators.Subtract(bl_, bm_);
                    CqlInterval<CqlDateTime> bo_ = context.Operators.Interval(bn_, bl_, true, true);
                    bool? bp_ = context.Operators.In<CqlDateTime>(bi_, bo_, (string)default);

                    CqlBoolean bq_() {
                        Period br_ = Visit?.Period;
                        CqlInterval<CqlDateTime> bs_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, br_);
                        CqlDateTime bt_ = context.Operators.Start(bs_);
                        return !((bool?)(bt_ is null));
                    }

                    return (bool?)(/* CQL 'and' (96:9-96:83) */ ((CqlBoolean)bp_
                        && bq_()));
                }

                IEnumerable<Encounter> aj_ = context.Operators.Where<Encounter>(ah_, ai_);

                object ak_(Encounter @this) {
                    Period bu_ = @this?.Period;
                    CqlInterval<CqlDateTime> bv_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, bu_);
                    CqlDateTime bw_ = context.Operators.End(bv_);
                    return bw_;
                }

                IEnumerable<Encounter> al_ = context.Operators.SortBy<Encounter>(aj_, ak_, System.ComponentModel.ListSortDirection.Ascending);
                Encounter am_ = context.Operators.Last<Encounter>(al_);
                Period an_ = am_?.Period;
                CqlInterval<CqlDateTime> ao_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, an_);
                CqlDateTime ap_ = context.Operators.Start(ao_);
                Period aq_ = Visit?.Period;
                CqlInterval<CqlDateTime> ar_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, aq_);
                CqlDateTime as_ = context.Operators.Start(ar_);
                CqlQuantity at_ = context.Operators.Quantity(1m, "hour");
                CqlDateTime au_ = context.Operators.Subtract(ap_ ?? as_, at_);

                bool? av_(Encounter LastObs) {
                    Period bx_ = LastObs?.Period;
                    CqlInterval<CqlDateTime> by_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, bx_);
                    CqlDateTime bz_ = context.Operators.End(by_);
                    Period ca_ = Visit?.Period;
                    CqlInterval<CqlDateTime> cb_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, ca_);
                    CqlDateTime cc_ = context.Operators.Start(cb_);
                    CqlQuantity cd_ = context.Operators.Quantity(1m, "hour");
                    CqlDateTime ce_ = context.Operators.Subtract(cc_, cd_);
                    CqlInterval<CqlDateTime> cf_ = context.Operators.Interval(ce_, cc_, true, true);
                    bool? cg_ = context.Operators.In<CqlDateTime>(bz_, cf_, (string)default);

                    CqlBoolean ch_() {
                        Period ci_ = Visit?.Period;
                        CqlInterval<CqlDateTime> cj_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, ci_);
                        CqlDateTime ck_ = context.Operators.Start(cj_);
                        return !((bool?)(ck_ is null));
                    }

                    return (bool?)(/* CQL 'and' (96:9-96:83) */ ((CqlBoolean)cg_
                        && ch_()));
                }

                IEnumerable<Encounter> aw_ = context.Operators.Where<Encounter>(ah_, av_);

                object ax_(Encounter @this) {
                    Period cl_ = @this?.Period;
                    CqlInterval<CqlDateTime> cm_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, cl_);
                    CqlDateTime cn_ = context.Operators.End(cm_);
                    return cn_;
                }

                IEnumerable<Encounter> ay_ = context.Operators.SortBy<Encounter>(aw_, ax_, System.ComponentModel.ListSortDirection.Ascending);
                Encounter az_ = context.Operators.Last<Encounter>(ay_);
                Period ba_ = az_?.Period;
                CqlInterval<CqlDateTime> bb_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, ba_);
                CqlDateTime bc_ = context.Operators.Start(bb_);
                CqlInterval<CqlDateTime> bd_ = context.Operators.Interval(au_, bc_ ?? as_, true, true);
                bool? be_ = context.Operators.In<CqlDateTime>(af_, bd_, (string)default);

                CqlBoolean bf_() {
                    CqlValueSet co_ = this.Observation_Services(context);
                    IEnumerable<Encounter> cp_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, co_, default, "http://hl7.org/fhir/StructureDefinition/Encounter"));

                    bool? cq_(Encounter LastObs) {
                        Period db_ = LastObs?.Period;
                        CqlInterval<CqlDateTime> dc_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, db_);
                        CqlDateTime dd_ = context.Operators.End(dc_);
                        Period de_ = Visit?.Period;
                        CqlInterval<CqlDateTime> df_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, de_);
                        CqlDateTime dg_ = context.Operators.Start(df_);
                        CqlQuantity dh_ = context.Operators.Quantity(1m, "hour");
                        CqlDateTime di_ = context.Operators.Subtract(dg_, dh_);
                        CqlInterval<CqlDateTime> dj_ = context.Operators.Interval(di_, dg_, true, true);
                        bool? dk_ = context.Operators.In<CqlDateTime>(dd_, dj_, (string)default);

                        CqlBoolean dl_() {
                            Period dm_ = Visit?.Period;
                            CqlInterval<CqlDateTime> dn_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, dm_);
                            CqlDateTime do_ = context.Operators.Start(dn_);
                            return !((bool?)(do_ is null));
                        }

                        return (bool?)(/* CQL 'and' (96:9-96:83) */ ((CqlBoolean)dk_
                            && dl_()));
                    }

                    IEnumerable<Encounter> cr_ = context.Operators.Where<Encounter>(cp_, cq_);

                    object cs_(Encounter @this) {
                        Period dp_ = @this?.Period;
                        CqlInterval<CqlDateTime> dq_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, dp_);
                        CqlDateTime dr_ = context.Operators.End(dq_);
                        return dr_;
                    }

                    IEnumerable<Encounter> ct_ = context.Operators.SortBy<Encounter>(cr_, cs_, System.ComponentModel.ListSortDirection.Ascending);
                    Encounter cu_ = context.Operators.Last<Encounter>(ct_);
                    Period cv_ = cu_?.Period;
                    CqlInterval<CqlDateTime> cw_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, cv_);
                    CqlDateTime cx_ = context.Operators.Start(cw_);
                    Period cy_ = Visit?.Period;
                    CqlInterval<CqlDateTime> cz_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, cy_);
                    CqlDateTime da_ = context.Operators.Start(cz_);
                    return !((bool?)((cx_ ?? da_) is null));
                }

                return (bool?)(/* CQL 'and' (101:9-101:71) */ ((CqlBoolean)be_
                    && bf_()));
            }

            IEnumerable<Encounter> h_ = context.Operators.Where<Encounter>(f_, g_);

            object i_(Encounter @this) {
                Period ds_ = @this?.Period;
                CqlInterval<CqlDateTime> dt_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, ds_);
                CqlDateTime du_ = context.Operators.End(dt_);
                return du_;
            }

            IEnumerable<Encounter> j_ = context.Operators.SortBy<Encounter>(h_, i_, System.ComponentModel.ListSortDirection.Ascending);
            Encounter k_ = context.Operators.Last<Encounter>(j_);
            Period l_ = k_?.Period;
            CqlInterval<CqlDateTime> m_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, l_);
            CqlDateTime n_ = context.Operators.Start(m_);
            CqlValueSet o_ = this.Observation_Services(context);
            IEnumerable<Encounter> p_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, o_, default, "http://hl7.org/fhir/StructureDefinition/Encounter"));

            bool? q_(Encounter LastObs) {
                Period dv_ = LastObs?.Period;
                CqlInterval<CqlDateTime> dw_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, dv_);
                CqlDateTime dx_ = context.Operators.End(dw_);
                Period dy_ = Visit?.Period;
                CqlInterval<CqlDateTime> dz_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, dy_);
                CqlDateTime ea_ = context.Operators.Start(dz_);
                CqlQuantity eb_ = context.Operators.Quantity(1m, "hour");
                CqlDateTime ec_ = context.Operators.Subtract(ea_, eb_);
                CqlInterval<CqlDateTime> ed_ = context.Operators.Interval(ec_, ea_, true, true);
                bool? ee_ = context.Operators.In<CqlDateTime>(dx_, ed_, (string)default);

                CqlBoolean ef_() {
                    Period eg_ = Visit?.Period;
                    CqlInterval<CqlDateTime> eh_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, eg_);
                    CqlDateTime ei_ = context.Operators.Start(eh_);
                    return !((bool?)(ei_ is null));
                }

                return (bool?)(/* CQL 'and' (96:9-96:83) */ ((CqlBoolean)ee_
                    && ef_()));
            }

            IEnumerable<Encounter> r_ = context.Operators.Where<Encounter>(p_, q_);

            object s_(Encounter @this) {
                Period ej_ = @this?.Period;
                CqlInterval<CqlDateTime> ek_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, ej_);
                CqlDateTime el_ = context.Operators.End(ek_);
                return el_;
            }

            IEnumerable<Encounter> t_ = context.Operators.SortBy<Encounter>(r_, s_, System.ComponentModel.ListSortDirection.Ascending);
            Encounter u_ = context.Operators.Last<Encounter>(t_);
            Period v_ = u_?.Period;
            CqlInterval<CqlDateTime> w_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, v_);
            CqlDateTime x_ = context.Operators.Start(w_);
            Period y_ = Visit?.Period;
            CqlInterval<CqlDateTime> z_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, y_);
            CqlDateTime aa_ = context.Operators.Start(z_);
            CqlDateTime ab_ = context.Operators.End(z_);
            CqlInterval<CqlDateTime> ac_ = context.Operators.Interval(n_ ?? x_ ?? aa_, ab_, true, true);
            return ac_;
        }

        IEnumerable<CqlInterval<CqlDateTime>> c_ = context.Operators.SelectDistinct<Encounter, CqlInterval<CqlDateTime>>((IEnumerable<Encounter>)a_, b_);
        CqlInterval<CqlDateTime> d_ = context.Operators.SingletonFrom<CqlInterval<CqlDateTime>>(c_);
        return d_;
    }


    [CqlFunctionDefinition("HospitalizationWithObservationLengthofStay")]
    public int? HospitalizationWithObservationLengthofStay(CqlContext context, Encounter Encounter)
    {
        CqlInterval<CqlDateTime> a_ = this.HospitalizationWithObservation(context, Encounter);
        int? b_ = this.LengthInDays(context, a_);
        return b_;
    }


    #endregion Functions and Expressions

    #region Singleton Lifetime Members

    private HybridHWMFHIR_0_102_005() {}

    public static HybridHWMFHIR_0_102_005 Instance { get; } = new();

    #endregion

    #region ILibrary Implementation

    public string Name => "HybridHWMFHIR";
    public string Version => "0.102.005";
    public ILibrary[] Dependencies => [FHIRHelpers_4_0_001.Instance, SupplementalDataElementsFHIR4_2_0_000.Instance, MATGlobalCommonFunctionsFHIR4_6_1_000.Instance];

    #endregion ILibrary Implementation

    #region CqlTupleMetadata Properties

    private static CqlTupleMetadata CqlTupleMetadata_EFSKhGUTUCLEXZENTURVLjeND = new(
       [typeof(Encounter), typeof(Coverage)],
       ["InpatientEncounter", "Payer"]);

    #endregion CqlTupleMetadata Properties

}

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
            bool? o_;
            // CQL 'and' (58:107-59:189): right operand skipped when left is false
            if (n_ is false)
            {
                o_ = false;
            }
            else
            {
                CqlInterval<CqlDateTime> q_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.HospitalizationWithObservation(context, tuple_efskhgutuclexzenturvljend?.InpatientEncounter);
                int? r_ = this.LengthInDays(context, q_);
                bool? s_ = context.Operators.Less(r_, 365);
                o_ = n_ & s_;
            }
            bool? p_;
            // CQL 'and' (58:107-60:169): right operand skipped when left is false
            if (o_ is false)
            {
                p_ = false;
            }
            else
            {
                Period t_ = tuple_efskhgutuclexzenturvljend?.InpatientEncounter?.Period;
                CqlInterval<CqlDateTime> u_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, t_);
                CqlDateTime v_ = context.Operators.End(u_);
                CqlInterval<CqlDateTime> w_ = this.Measurement_Period(context);
                bool? x_ = context.Operators.In<CqlDateTime>(v_, w_, "day");
                p_ = o_ & x_;
            }
            // CQL 'and' (58:101-61:187): right operand skipped when left is false
            if (p_ is false)
            {
                return false;
            }
            else
            {
                Patient y_ = this.Patient(context);
                Date z_ = y_?.BirthDateElement;
                string aa_ = z_?.Value;
                CqlDate ab_ = context.Operators.ConvertStringToDate(aa_);
                Period ac_ = tuple_efskhgutuclexzenturvljend?.InpatientEncounter?.Period;
                CqlInterval<CqlDateTime> ad_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, ac_);
                CqlDateTime ae_ = context.Operators.Start(ad_);
                CqlDate af_ = context.Operators.DateFrom(ae_);
                int? ag_ = context.Operators.CalculateAgeAt(ab_, af_, "year");
                CqlInterval<int?> ah_ = context.Operators.Interval(65, 94, true, true);
                bool? ai_ = context.Operators.In<int?>(ag_, ah_, (string)default);
                return p_ & ai_;
            }
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
                bool? ag_ = !((bool?)(af_ is null));
                bool? ah_;
                // CQL 'and' (120:13-120:232): right operand skipped when left is false
                if (ag_ is false)
                {
                    ah_ = false;
                }
                else
                {
                    Period aj_ = Encounter?.Period;
                    CqlInterval<CqlDateTime> ak_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, aj_);
                    CqlDateTime al_ = context.Operators.Start(ak_);
                    CqlQuantity am_ = context.Operators.Quantity(1440m, "minutes");
                    CqlDateTime an_ = context.Operators.Subtract(al_, am_);
                    CqlQuantity ao_ = context.Operators.Quantity(120m, "minutes");
                    CqlDateTime ap_ = context.Operators.Add(al_, ao_);
                    CqlInterval<CqlDateTime> aq_ = context.Operators.Interval(an_, ap_, true, true);
                    bool? ar_ = context.Operators.In<CqlDateTime>(af_, aq_, (string)default);
                    ah_ = ag_ & ar_;
                }
                bool? ai_;
                // CQL 'and' (120:13-121:60): right operand skipped when left is false
                if (ah_ is false)
                {
                    ai_ = false;
                }
                else
                {
                    Code<ObservationStatus> as_ = Exam?.StatusElement;
                    string at_ = FHIRHelpers_4_0_001.Instance.ToString(context, as_);
                    string[] au_ = [
                        "final",
                        "amended",
                        "preliminary",
                    ];
                    bool? av_ = context.Operators.In<string>(at_, (IEnumerable<string>)au_);
                    ai_ = ah_ & av_;
                }
                // CQL 'and' (120:7-122:32): right operand skipped when left is false
                if (ai_ is false)
                {
                    return false;
                }
                else
                {
                    DataType aw_ = Exam?.Value;
                    return ai_ & (!((bool?)(aw_ is null)));
                }
            }

            IEnumerable<Observation> k_ = context.Operators.Where<Observation>(ExamList, j_);

            object l_(Observation @this) {
                DataType ax_ = @this?.Effective;
                CqlInterval<CqlDateTime> ay_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, ax_);
                CqlDateTime az_ = context.Operators.Start(ay_);
                return az_;
            }

            IEnumerable<Observation> m_ = context.Operators.SortBy<Observation>(k_, l_, System.ComponentModel.ListSortDirection.Ascending);
            Observation n_ = context.Operators.First<Observation>(m_);
            DataType o_ = n_?.Value;
            CqlQuantity p_ = FHIRHelpers_4_0_001.Instance.ToQuantity(context, o_ as Quantity);
            string q_ = context.Operators.ConvertQuantityToString(p_);
            string r_ = context.Operators.Concatenate(i_ ?? "", q_ ?? "");
            string s_ = context.Operators.Concatenate(r_ ?? "", ",");

            bool? t_(Observation Exam) {
                DataType ba_ = Exam?.Effective;
                CqlInterval<CqlDateTime> bb_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, ba_);
                CqlDateTime bc_ = context.Operators.Start(bb_);
                bool? bd_ = !((bool?)(bc_ is null));
                bool? be_;
                // CQL 'and' (120:13-120:232): right operand skipped when left is false
                if (bd_ is false)
                {
                    be_ = false;
                }
                else
                {
                    Period bg_ = Encounter?.Period;
                    CqlInterval<CqlDateTime> bh_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, bg_);
                    CqlDateTime bi_ = context.Operators.Start(bh_);
                    CqlQuantity bj_ = context.Operators.Quantity(1440m, "minutes");
                    CqlDateTime bk_ = context.Operators.Subtract(bi_, bj_);
                    CqlQuantity bl_ = context.Operators.Quantity(120m, "minutes");
                    CqlDateTime bm_ = context.Operators.Add(bi_, bl_);
                    CqlInterval<CqlDateTime> bn_ = context.Operators.Interval(bk_, bm_, true, true);
                    bool? bo_ = context.Operators.In<CqlDateTime>(bc_, bn_, (string)default);
                    be_ = bd_ & bo_;
                }
                bool? bf_;
                // CQL 'and' (120:13-121:60): right operand skipped when left is false
                if (be_ is false)
                {
                    bf_ = false;
                }
                else
                {
                    Code<ObservationStatus> bp_ = Exam?.StatusElement;
                    string bq_ = FHIRHelpers_4_0_001.Instance.ToString(context, bp_);
                    string[] br_ = [
                        "final",
                        "amended",
                        "preliminary",
                    ];
                    bool? bs_ = context.Operators.In<string>(bq_, (IEnumerable<string>)br_);
                    bf_ = be_ & bs_;
                }
                // CQL 'and' (120:7-122:32): right operand skipped when left is false
                if (bf_ is false)
                {
                    return false;
                }
                else
                {
                    DataType bt_ = Exam?.Value;
                    return bf_ & (!((bool?)(bt_ is null)));
                }
            }

            IEnumerable<Observation> u_ = context.Operators.Where<Observation>(ExamList, t_);

            object v_(Observation @this) {
                DataType bu_ = @this?.Effective;
                CqlInterval<CqlDateTime> bv_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, bu_);
                CqlDateTime bw_ = context.Operators.Start(bv_);
                return bw_;
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
                bool? ad_ = !((bool?)(ac_ is null));
                bool? ae_;
                // CQL 'and' (112:13-112:149): right operand skipped when left is false
                if (ad_ is false)
                {
                    ae_ = false;
                }
                else
                {
                    CqlDateTime ag_ = FHIRHelpers_4_0_001.Instance.ToDateTime(context, ac_);
                    Period ah_ = Encounter?.Period;
                    CqlInterval<CqlDateTime> ai_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, ah_);
                    CqlDateTime aj_ = context.Operators.Start(ai_);
                    CqlQuantity ak_ = context.Operators.Quantity(1440m, "minutes");
                    CqlDateTime al_ = context.Operators.Subtract(aj_, ak_);
                    CqlDateTime am_ = context.Operators.Add(aj_, ak_);
                    CqlInterval<CqlDateTime> an_ = context.Operators.Interval(al_, am_, true, true);
                    bool? ao_ = context.Operators.In<CqlDateTime>(ag_, an_, (string)default);
                    ae_ = ad_ & ao_;
                }
                bool? af_;
                // CQL 'and' (112:13-113:59): right operand skipped when left is false
                if (ae_ is false)
                {
                    af_ = false;
                }
                else
                {
                    Code<ObservationStatus> ap_ = Lab?.StatusElement;
                    string aq_ = FHIRHelpers_4_0_001.Instance.ToString(context, ap_);
                    string[] ar_ = [
                        "final",
                        "amended",
                        "preliminary",
                    ];
                    bool? as_ = context.Operators.In<string>(aq_, (IEnumerable<string>)ar_);
                    af_ = ae_ & as_;
                }
                // CQL 'and' (112:7-113:85): right operand skipped when left is false
                if (af_ is false)
                {
                    return false;
                }
                else
                {
                    DataType at_ = Lab?.Value;
                    return af_ & (!((bool?)(at_ is null)));
                }
            }

            IEnumerable<Observation> k_ = context.Operators.Where<Observation>(LabList, j_);

            object l_(Observation @this) {
                Instant au_ = @this?.IssuedElement;
                return au_;
            }

            IEnumerable<Observation> m_ = context.Operators.SortBy<Observation>(k_, l_, System.ComponentModel.ListSortDirection.Ascending);
            Observation n_ = context.Operators.First<Observation>(m_);
            DataType o_ = n_?.Value;
            CqlQuantity p_ = FHIRHelpers_4_0_001.Instance.ToQuantity(context, o_ as Quantity);
            string q_ = context.Operators.ConvertQuantityToString(p_);
            string r_ = context.Operators.Concatenate(i_ ?? "", q_ ?? "");
            string s_ = context.Operators.Concatenate(r_ ?? "", ",");

            bool? t_(Observation Lab) {
                Instant av_ = Lab?.IssuedElement;
                bool? aw_ = !((bool?)(av_ is null));
                bool? ax_;
                // CQL 'and' (112:13-112:149): right operand skipped when left is false
                if (aw_ is false)
                {
                    ax_ = false;
                }
                else
                {
                    CqlDateTime az_ = FHIRHelpers_4_0_001.Instance.ToDateTime(context, av_);
                    Period ba_ = Encounter?.Period;
                    CqlInterval<CqlDateTime> bb_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, ba_);
                    CqlDateTime bc_ = context.Operators.Start(bb_);
                    CqlQuantity bd_ = context.Operators.Quantity(1440m, "minutes");
                    CqlDateTime be_ = context.Operators.Subtract(bc_, bd_);
                    CqlDateTime bf_ = context.Operators.Add(bc_, bd_);
                    CqlInterval<CqlDateTime> bg_ = context.Operators.Interval(be_, bf_, true, true);
                    bool? bh_ = context.Operators.In<CqlDateTime>(az_, bg_, (string)default);
                    ax_ = aw_ & bh_;
                }
                bool? ay_;
                // CQL 'and' (112:13-113:59): right operand skipped when left is false
                if (ax_ is false)
                {
                    ay_ = false;
                }
                else
                {
                    Code<ObservationStatus> bi_ = Lab?.StatusElement;
                    string bj_ = FHIRHelpers_4_0_001.Instance.ToString(context, bi_);
                    string[] bk_ = [
                        "final",
                        "amended",
                        "preliminary",
                    ];
                    bool? bl_ = context.Operators.In<string>(bj_, (IEnumerable<string>)bk_);
                    ay_ = ax_ & bl_;
                }
                // CQL 'and' (112:7-113:85): right operand skipped when left is false
                if (ay_ is false)
                {
                    return false;
                }
                else
                {
                    DataType bm_ = Lab?.Value;
                    return ay_ & (!((bool?)(bm_ is null)));
                }
            }

            IEnumerable<Observation> u_ = context.Operators.Where<Observation>(LabList, t_);

            object v_(Observation @this) {
                Instant bn_ = @this?.IssuedElement;
                return bn_;
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
                    Period bf_ = LastObs?.Period;
                    CqlInterval<CqlDateTime> bg_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, bf_);
                    CqlDateTime bh_ = context.Operators.End(bg_);
                    Period bi_ = Visit?.Period;
                    CqlInterval<CqlDateTime> bj_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, bi_);
                    CqlDateTime bk_ = context.Operators.Start(bj_);
                    CqlQuantity bl_ = context.Operators.Quantity(1m, "hour");
                    CqlDateTime bm_ = context.Operators.Subtract(bk_, bl_);
                    CqlInterval<CqlDateTime> bn_ = context.Operators.Interval(bm_, bk_, true, true);
                    bool? bo_ = context.Operators.In<CqlDateTime>(bh_, bn_, (string)default);
                    // CQL 'and' (96:9-96:83): right operand skipped when left is false
                    if (bo_ is false)
                    {
                        return false;
                    }
                    else
                    {
                        return bo_ & (!((bool?)(bk_ is null)));
                    }
                }

                IEnumerable<Encounter> aj_ = context.Operators.Where<Encounter>(ah_, ai_);

                object ak_(Encounter @this) {
                    Period bp_ = @this?.Period;
                    CqlInterval<CqlDateTime> bq_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, bp_);
                    CqlDateTime br_ = context.Operators.End(bq_);
                    return br_;
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
                    Period bs_ = LastObs?.Period;
                    CqlInterval<CqlDateTime> bt_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, bs_);
                    CqlDateTime bu_ = context.Operators.End(bt_);
                    Period bv_ = Visit?.Period;
                    CqlInterval<CqlDateTime> bw_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, bv_);
                    CqlDateTime bx_ = context.Operators.Start(bw_);
                    CqlQuantity by_ = context.Operators.Quantity(1m, "hour");
                    CqlDateTime bz_ = context.Operators.Subtract(bx_, by_);
                    CqlInterval<CqlDateTime> ca_ = context.Operators.Interval(bz_, bx_, true, true);
                    bool? cb_ = context.Operators.In<CqlDateTime>(bu_, ca_, (string)default);
                    // CQL 'and' (96:9-96:83): right operand skipped when left is false
                    if (cb_ is false)
                    {
                        return false;
                    }
                    else
                    {
                        return cb_ & (!((bool?)(bx_ is null)));
                    }
                }

                IEnumerable<Encounter> aw_ = context.Operators.Where<Encounter>(ah_, av_);

                object ax_(Encounter @this) {
                    Period cc_ = @this?.Period;
                    CqlInterval<CqlDateTime> cd_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, cc_);
                    CqlDateTime ce_ = context.Operators.End(cd_);
                    return ce_;
                }

                IEnumerable<Encounter> ay_ = context.Operators.SortBy<Encounter>(aw_, ax_, System.ComponentModel.ListSortDirection.Ascending);
                Encounter az_ = context.Operators.Last<Encounter>(ay_);
                Period ba_ = az_?.Period;
                CqlInterval<CqlDateTime> bb_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, ba_);
                CqlDateTime bc_ = context.Operators.Start(bb_);
                CqlInterval<CqlDateTime> bd_ = context.Operators.Interval(au_, bc_ ?? as_, true, true);
                bool? be_ = context.Operators.In<CqlDateTime>(af_, bd_, (string)default);
                // CQL 'and' (101:9-101:71): right operand skipped when left is false
                if (be_ is false)
                {
                    return false;
                }
                else
                {

                    bool? cf_(Encounter LastObs) {
                        Period cn_ = LastObs?.Period;
                        CqlInterval<CqlDateTime> co_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, cn_);
                        CqlDateTime cp_ = context.Operators.End(co_);
                        Period cq_ = Visit?.Period;
                        CqlInterval<CqlDateTime> cr_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, cq_);
                        CqlDateTime cs_ = context.Operators.Start(cr_);
                        CqlQuantity ct_ = context.Operators.Quantity(1m, "hour");
                        CqlDateTime cu_ = context.Operators.Subtract(cs_, ct_);
                        CqlInterval<CqlDateTime> cv_ = context.Operators.Interval(cu_, cs_, true, true);
                        bool? cw_ = context.Operators.In<CqlDateTime>(cp_, cv_, (string)default);
                        // CQL 'and' (96:9-96:83): right operand skipped when left is false
                        if (cw_ is false)
                        {
                            return false;
                        }
                        else
                        {
                            return cw_ & (!((bool?)(cs_ is null)));
                        }
                    }

                    IEnumerable<Encounter> cg_ = context.Operators.Where<Encounter>(ah_, cf_);

                    object ch_(Encounter @this) {
                        Period cx_ = @this?.Period;
                        CqlInterval<CqlDateTime> cy_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, cx_);
                        CqlDateTime cz_ = context.Operators.End(cy_);
                        return cz_;
                    }

                    IEnumerable<Encounter> ci_ = context.Operators.SortBy<Encounter>(cg_, ch_, System.ComponentModel.ListSortDirection.Ascending);
                    Encounter cj_ = context.Operators.Last<Encounter>(ci_);
                    Period ck_ = cj_?.Period;
                    CqlInterval<CqlDateTime> cl_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, ck_);
                    CqlDateTime cm_ = context.Operators.Start(cl_);
                    return be_ & (!((bool?)((cm_ ?? as_) is null)));
                }
            }

            IEnumerable<Encounter> h_ = context.Operators.Where<Encounter>(f_, g_);

            object i_(Encounter @this) {
                Period da_ = @this?.Period;
                CqlInterval<CqlDateTime> db_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, da_);
                CqlDateTime dc_ = context.Operators.End(db_);
                return dc_;
            }

            IEnumerable<Encounter> j_ = context.Operators.SortBy<Encounter>(h_, i_, System.ComponentModel.ListSortDirection.Ascending);
            Encounter k_ = context.Operators.Last<Encounter>(j_);
            Period l_ = k_?.Period;
            CqlInterval<CqlDateTime> m_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, l_);
            CqlDateTime n_ = context.Operators.Start(m_);
            CqlValueSet o_ = this.Observation_Services(context);
            IEnumerable<Encounter> p_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, o_, default, "http://hl7.org/fhir/StructureDefinition/Encounter"));

            bool? q_(Encounter LastObs) {
                Period dd_ = LastObs?.Period;
                CqlInterval<CqlDateTime> de_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, dd_);
                CqlDateTime df_ = context.Operators.End(de_);
                Period dg_ = Visit?.Period;
                CqlInterval<CqlDateTime> dh_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, dg_);
                CqlDateTime di_ = context.Operators.Start(dh_);
                CqlQuantity dj_ = context.Operators.Quantity(1m, "hour");
                CqlDateTime dk_ = context.Operators.Subtract(di_, dj_);
                CqlInterval<CqlDateTime> dl_ = context.Operators.Interval(dk_, di_, true, true);
                bool? dm_ = context.Operators.In<CqlDateTime>(df_, dl_, (string)default);
                // CQL 'and' (96:9-96:83): right operand skipped when left is false
                if (dm_ is false)
                {
                    return false;
                }
                else
                {
                    return dm_ & (!((bool?)(di_ is null)));
                }
            }

            IEnumerable<Encounter> r_ = context.Operators.Where<Encounter>(p_, q_);

            object s_(Encounter @this) {
                Period dn_ = @this?.Period;
                CqlInterval<CqlDateTime> do_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, dn_);
                CqlDateTime dp_ = context.Operators.End(do_);
                return dp_;
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

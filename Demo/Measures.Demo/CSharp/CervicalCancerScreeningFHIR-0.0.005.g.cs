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
[CqlLibrary("CervicalCancerScreeningFHIR", "0.0.005")]
public partial class CervicalCancerScreeningFHIR_0_0_005 : ILibrary, ISingleton<CervicalCancerScreeningFHIR_0_0_005>
{
    #region ValueSets (10)

    [CqlValueSetDefinition("Congenital or Acquired Absence of Cervix", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.111.12.1016", valueSetVersion: null)]
    public CqlValueSet Congenital_or_Acquired_Absence_of_Cervix(CqlContext _) => _Congenital_or_Acquired_Absence_of_Cervix;
    private static readonly CqlValueSet _Congenital_or_Acquired_Absence_of_Cervix = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.111.12.1016", null);

    [CqlValueSetDefinition("Home Healthcare Services", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1016", valueSetVersion: null)]
    public CqlValueSet Home_Healthcare_Services(CqlContext _) => _Home_Healthcare_Services;
    private static readonly CqlValueSet _Home_Healthcare_Services = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1016", null);

    [CqlValueSetDefinition("HPV Test", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.110.12.1059", valueSetVersion: null)]
    public CqlValueSet HPV_Test(CqlContext _) => _HPV_Test;
    private static readonly CqlValueSet _HPV_Test = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.110.12.1059", null);

    [CqlValueSetDefinition("Hysterectomy with No Residual Cervix", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.198.12.1014", valueSetVersion: null)]
    public CqlValueSet Hysterectomy_with_No_Residual_Cervix(CqlContext _) => _Hysterectomy_with_No_Residual_Cervix;
    private static readonly CqlValueSet _Hysterectomy_with_No_Residual_Cervix = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.198.12.1014", null);

    [CqlValueSetDefinition("Office Visit", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1001", valueSetVersion: null)]
    public CqlValueSet Office_Visit(CqlContext _) => _Office_Visit;
    private static readonly CqlValueSet _Office_Visit = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1001", null);

    [CqlValueSetDefinition("Online Assessments", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1089", valueSetVersion: null)]
    public CqlValueSet Online_Assessments(CqlContext _) => _Online_Assessments;
    private static readonly CqlValueSet _Online_Assessments = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1089", null);

    [CqlValueSetDefinition("Pap Test", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.108.12.1017", valueSetVersion: null)]
    public CqlValueSet Pap_Test(CqlContext _) => _Pap_Test;
    private static readonly CqlValueSet _Pap_Test = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.108.12.1017", null);

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

    #region Codes (1)

    [CqlCodeDefinition("laboratory", codeId: "laboratory", codeSystem: "http://terminology.hl7.org/CodeSystem/observation-category")]
    public CqlCode laboratory(CqlContext _) => _laboratory;
    private static readonly CqlCode _laboratory = new CqlCode("laboratory", "http://terminology.hl7.org/CodeSystem/observation-category");

    #endregion Codes

    #region CodeSystems (1)

    [CqlCodeSystemDefinition("ObservationCategoryCodes", codeSystemId: "http://terminology.hl7.org/CodeSystem/observation-category", codeSystemVersion: null)]
    public CqlCodeSystem ObservationCategoryCodes(CqlContext _) => _ObservationCategoryCodes;
    private static readonly CqlCodeSystem _ObservationCategoryCodes =
      new CqlCodeSystem("http://terminology.hl7.org/CodeSystem/observation-category", null, [
          _laboratory]);

    #endregion CodeSystems

    #region Parameters (1)

    [CqlParameterDefinition("Measurement Period")]
    public CqlInterval<CqlDateTime> Measurement_Period(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Measurement_Period, Measurement_Period_Compute);

    private const long _cacheIndex_Measurement_Period = 8660301701421196239L;

    private CqlInterval<CqlDateTime> Measurement_Period_Compute(CqlContext context)
    {
        CqlDateTime a_ = context.Operators.DateTime(2019, 1, 1, 0, 0, 0, 0, (decimal?)default);
        CqlDateTime b_ = context.Operators.DateTime(2020, 1, 1, 0, 0, 0, 0, (decimal?)default);
        CqlInterval<CqlDateTime> c_ = context.Operators.Interval(a_, b_, true, false);
        object d_ = context.ResolveParameter("CervicalCancerScreeningFHIR-0.0.005", "Measurement Period", c_);
        return (CqlInterval<CqlDateTime>)d_;
    }


    #endregion Parameters

    #region Functions and Expressions (19)

    [CqlExpressionDefinition("Patient")]
    public Patient Patient(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Patient, Patient_Compute);

    private const long _cacheIndex_Patient = 6460207783038373143L;

    private Patient Patient_Compute(CqlContext context)
    {
        IEnumerable<Patient> a_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/StructureDefinition/Patient"));
        Patient b_ = context.Operators.SingletonFrom<Patient>(a_);
        return b_;
    }


    [CqlExpressionDefinition("SDE Ethnicity")]
    public IEnumerable<Coding> SDE_Ethnicity(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_SDE_Ethnicity, SDE_Ethnicity_Compute);

    private const long _cacheIndex_SDE_Ethnicity = -4228820258741890893L;

    private IEnumerable<Coding> SDE_Ethnicity_Compute(CqlContext context)
    {
        IEnumerable<Coding> a_ = SupplementalDataElementsFHIR4_2_0_000.Instance.SDE_Ethnicity(context);
        return a_;
    }


    [CqlExpressionDefinition("SDE Payer")]
    public IEnumerable<(CqlTupleMetadata, CodeableConcept code, Period period)?> SDE_Payer(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_SDE_Payer, SDE_Payer_Compute);

    private const long _cacheIndex_SDE_Payer = 1584917916709233563L;

    private IEnumerable<(CqlTupleMetadata, CodeableConcept code, Period period)?> SDE_Payer_Compute(CqlContext context)
    {
        IEnumerable<(CqlTupleMetadata, CodeableConcept code, Period period)?> a_ = SupplementalDataElementsFHIR4_2_0_000.Instance.SDE_Payer(context);
        return a_;
    }


    [CqlExpressionDefinition("SDE Race")]
    public IEnumerable<Coding> SDE_Race(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_SDE_Race, SDE_Race_Compute);

    private const long _cacheIndex_SDE_Race = -6862290277348299381L;

    private IEnumerable<Coding> SDE_Race_Compute(CqlContext context)
    {
        IEnumerable<Coding> a_ = SupplementalDataElementsFHIR4_2_0_000.Instance.SDE_Race(context);
        return a_;
    }


    [CqlExpressionDefinition("SDE Sex")]
    public CqlCode SDE_Sex(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_SDE_Sex, SDE_Sex_Compute);

    private const long _cacheIndex_SDE_Sex = 2129325612513154633L;

    private CqlCode SDE_Sex_Compute(CqlContext context)
    {
        CqlCode a_ = SupplementalDataElementsFHIR4_2_0_000.Instance.SDE_Sex(context);
        return a_;
    }


    [CqlExpressionDefinition("Qualifying Encounters")]
    public IEnumerable<Encounter> Qualifying_Encounters(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Qualifying_Encounters, Qualifying_Encounters_Compute);

    private const long _cacheIndex_Qualifying_Encounters = -3765407320961297160L;

    private IEnumerable<Encounter> Qualifying_Encounters_Compute(CqlContext context)
    {
        CqlValueSet a_ = this.Office_Visit(context);
        IEnumerable<Encounter> b_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/StructureDefinition/Encounter"));
        CqlValueSet c_ = this.Preventive_Care_Services___Established_Office_Visit__18_and_Up(context);
        IEnumerable<Encounter> d_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, c_, default, "http://hl7.org/fhir/StructureDefinition/Encounter"));
        IEnumerable<Encounter> e_ = context.Operators.Union<Encounter>(b_, d_);
        CqlValueSet f_ = this.Preventive_Care_Services_Initial_Office_Visit__18_and_Up(context);
        IEnumerable<Encounter> g_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, f_, default, "http://hl7.org/fhir/StructureDefinition/Encounter"));
        CqlValueSet h_ = this.Home_Healthcare_Services(context);
        IEnumerable<Encounter> i_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, h_, default, "http://hl7.org/fhir/StructureDefinition/Encounter"));
        IEnumerable<Encounter> j_ = context.Operators.Union<Encounter>(g_, i_);
        IEnumerable<Encounter> k_ = context.Operators.Union<Encounter>(e_, j_);
        CqlValueSet l_ = this.Telephone_Visits(context);
        IEnumerable<Encounter> m_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, l_, default, "http://hl7.org/fhir/StructureDefinition/Encounter"));
        CqlValueSet n_ = this.Online_Assessments(context);
        IEnumerable<Encounter> o_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, n_, default, "http://hl7.org/fhir/StructureDefinition/Encounter"));
        IEnumerable<Encounter> p_ = context.Operators.Union<Encounter>(m_, o_);
        IEnumerable<Encounter> q_ = context.Operators.Union<Encounter>(k_, p_);

        bool? r_(Encounter ValidEncounter) {
            Code<Encounter.EncounterStatus> t_ = ValidEncounter?.StatusElement;
            string u_ = FHIRHelpers_4_0_001.Instance.ToString(context, t_);
            bool? v_ = context.Operators.Equal(u_, "finished");
            // CQL 'and' (55:15-56:69): right operand skipped when left is false
            if (v_ is false)
            {
                return false;
            }
            else
            {
                CqlInterval<CqlDateTime> w_ = this.Measurement_Period(context);
                Period x_ = ValidEncounter?.Period;
                CqlInterval<CqlDateTime> y_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, x_);
                bool? z_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(w_, y_, (string)default);
                return v_ & z_;
            }
        }

        IEnumerable<Encounter> s_ = context.Operators.Where<Encounter>(q_, r_);
        return s_;
    }


    [CqlExpressionDefinition("Initial Population")]
    public bool? Initial_Population(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Initial_Population, Initial_Population_Compute);

    private const long _cacheIndex_Initial_Population = 5134058747012552026L;

    private bool? Initial_Population_Compute(CqlContext context)
    {
        Patient a_ = this.Patient(context);
        Date b_ = a_?.BirthDateElement;
        string c_ = b_?.Value;
        CqlDate d_ = context.Operators.ConvertStringToDate(c_);
        CqlInterval<CqlDateTime> e_ = this.Measurement_Period(context);
        CqlDateTime f_ = context.Operators.Start(e_);
        CqlDate g_ = context.Operators.DateFrom(f_);
        int? h_ = context.Operators.CalculateAgeAt(d_, g_, "year");
        CqlInterval<int?> i_ = context.Operators.Interval(23, 64, true, false);
        bool? j_ = context.Operators.In<int?>(h_, i_, (string)default);
        bool? k_;
        // CQL 'and' (44:3-45:43): right operand skipped when left is false
        if (j_ is false)
        {
            k_ = false;
        }
        else
        {
            Patient l_ = this.Patient(context);
            Code<AdministrativeGender> m_ = l_?.GenderElement;
            string n_ = FHIRHelpers_4_0_001.Instance.ToString(context, m_);
            bool? o_ = context.Operators.Equal(n_, "female");
            k_ = j_ & o_;
        }
        // CQL 'and' (44:3-46:48): right operand skipped when left is false
        if (k_ is false)
        {
            return false;
        }
        else
        {
            IEnumerable<Encounter> p_ = this.Qualifying_Encounters(context);
            bool? q_ = context.Operators.Exists<Encounter>(p_);
            return k_ & q_;
        }
    }


    [CqlExpressionDefinition("Denominator")]
    public bool? Denominator(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Denominator, Denominator_Compute);

    private const long _cacheIndex_Denominator = 8156524090055450919L;

    private bool? Denominator_Compute(CqlContext context)
    {
        bool? a_ = this.Initial_Population(context);
        return a_;
    }


    [CqlExpressionDefinition("Absence of Cervix")]
    public IEnumerable<object> Absence_of_Cervix(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Absence_of_Cervix, Absence_of_Cervix_Compute);

    private const long _cacheIndex_Absence_of_Cervix = 1980255415960729348L;

    private IEnumerable<object> Absence_of_Cervix_Compute(CqlContext context)
    {
        CqlValueSet a_ = this.Hysterectomy_with_No_Residual_Cervix(context);
        IEnumerable<Procedure> b_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/StructureDefinition/Procedure"));

        bool? c_(Procedure NoCervixProcedure) {
            Code<EventStatus> j_ = NoCervixProcedure?.StatusElement;
            string k_ = FHIRHelpers_4_0_001.Instance.ToString(context, j_);
            bool? l_ = context.Operators.Equal(k_, "completed");
            // CQL 'and' (72:17-74:45): right operand skipped when left is false
            if (l_ is false)
            {
                return false;
            }
            else
            {
                DataType m_ = NoCervixProcedure?.Performed;
                CqlInterval<CqlDateTime> n_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, m_);
                CqlDateTime o_ = context.Operators.End(n_);
                CqlInterval<CqlDateTime> p_ = this.Measurement_Period(context);
                CqlDateTime q_ = context.Operators.End(p_);
                bool? r_ = context.Operators.SameOrBefore(o_, q_, (string)default);
                return l_ & r_;
            }
        }

        IEnumerable<Procedure> d_ = context.Operators.Where<Procedure>(b_, c_);
        CqlValueSet e_ = this.Congenital_or_Acquired_Absence_of_Cervix(context);
        IEnumerable<Condition> f_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, e_, default, "http://hl7.org/fhir/StructureDefinition/Condition"));

        bool? g_(Condition NoCervixDiagnosis) {
            CqlInterval<CqlDateTime> s_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Prevalence_Period(context, NoCervixDiagnosis);
            CqlDateTime t_ = context.Operators.Start(s_);
            CqlInterval<CqlDateTime> u_ = this.Measurement_Period(context);
            CqlDateTime v_ = context.Operators.End(u_);
            bool? w_ = context.Operators.SameOrBefore(t_, v_, (string)default);
            return w_;
        }

        IEnumerable<Condition> h_ = context.Operators.Where<Condition>(f_, g_);
        IEnumerable<object> i_ = context.Operators.Union<object>(d_ as IEnumerable<object>, h_ as IEnumerable<object>);
        return i_;
    }


    [CqlExpressionDefinition("Denominator Exclusions")]
    public bool? Denominator_Exclusions(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Denominator_Exclusions, Denominator_Exclusions_Compute);

    private const long _cacheIndex_Denominator_Exclusions = -8218631691522785080L;

    private bool? Denominator_Exclusions_Compute(CqlContext context)
    {
        bool? a_ = HospiceFHIR4_2_3_000.Instance.Has_Hospice(context);
        bool? b_;
        // CQL 'or' (62:3-63:43): right operand skipped when left is true
        if (a_ is true)
        {
            b_ = true;
        }
        else
        {
            IEnumerable<object> c_ = this.Absence_of_Cervix(context);
            bool? d_ = context.Operators.Exists<object>(c_);
            b_ = a_ | d_;
        }
        // CQL 'or' (62:3-64:75): right operand skipped when left is true
        if (b_ is true)
        {
            return true;
        }
        else
        {
            bool? e_ = PalliativeCareFHIR_0_6_000.Instance.Palliative_Care_in_the_Measurement_Period(context);
            return b_ | e_;
        }
    }


    [CqlExpressionDefinition("Cervical Cytology Within 3 Years")]
    public IEnumerable<Observation> Cervical_Cytology_Within_3_Years(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Cervical_Cytology_Within_3_Years, Cervical_Cytology_Within_3_Years_Compute);

    private const long _cacheIndex_Cervical_Cytology_Within_3_Years = -2656079809272880242L;

    private IEnumerable<Observation> Cervical_Cytology_Within_3_Years_Compute(CqlContext context)
    {
        CqlValueSet a_ = this.Pap_Test(context);
        IEnumerable<Observation> b_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/StructureDefinition/Observation"));

        bool? c_(Observation CervicalCytology) {
            Code<ObservationStatus> e_ = CervicalCytology?.StatusElement;
            string f_ = FHIRHelpers_4_0_001.Instance.ToString(context, e_);
            string[] g_ = [
                "final",
                "amended",
                "corrected",
            ];
            bool? h_ = context.Operators.In<string>(f_, (IEnumerable<string>)g_);
            bool? i_;
            // CQL 'and' (83:11-86:7): right operand skipped when left is false
            if (h_ is false)
            {
                i_ = false;
            }
            else
            {
                List<CodeableConcept> k_ = CervicalCytology?.Category;

                bool? l_(CodeableConcept CervicalCytologyCategory) {
                    CqlCode n_ = this.laboratory(context);
                    CqlConcept o_ = FHIRHelpers_4_0_001.Instance.ToConcept(context, CervicalCytologyCategory);
                    IReadOnlyList<CqlCode> p_ = o_?.codes;
                    bool? q_ = context.Operators.In<CqlCode>(n_, (IEnumerable<CqlCode>)p_);
                    return q_;
                }

                bool? m_ = context.Operators.WhereAny<CodeableConcept>((IEnumerable<CodeableConcept>)k_, l_);
                i_ = h_ & m_;
            }
            bool? j_;
            // CQL 'and' (83:11-87:113): right operand skipped when left is false
            if (i_ is false)
            {
                j_ = false;
            }
            else
            {
                DataType r_ = CervicalCytology?.Effective;
                CqlDateTime s_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Latest(context, r_);
                CqlInterval<CqlDateTime> t_ = this.Measurement_Period(context);
                CqlDateTime u_ = context.Operators.End(t_);
                CqlQuantity v_ = context.Operators.Quantity(3m, "years");
                CqlDateTime w_ = context.Operators.Subtract(u_, v_);
                CqlInterval<CqlDateTime> x_ = context.Operators.Interval(w_, u_, true, true);
                bool? y_ = context.Operators.In<CqlDateTime>(s_, x_, (string)default);
                bool? z_;
                // CQL 'and' (87:11-87:113): right operand skipped when left is false
                if (y_ is false)
                {
                    z_ = false;
                }
                else
                {
                    CqlInterval<CqlDateTime> aa_ = this.Measurement_Period(context);
                    CqlDateTime ab_ = context.Operators.End(aa_);
                    z_ = y_ & (!((bool?)(ab_ is null)));
                }
                j_ = i_ & z_;
            }
            // CQL 'and' (83:5-88:44): right operand skipped when left is false
            if (j_ is false)
            {
                return false;
            }
            else
            {
                DataType ac_ = CervicalCytology?.Value;
                return j_ & (!((bool?)(ac_ is null)));
            }
        }

        IEnumerable<Observation> d_ = context.Operators.Where<Observation>(b_, c_);
        return d_;
    }


    [CqlExpressionDefinition("HPV Test Within 5 Years for Women Age 30 and Older")]
    public IEnumerable<Observation> HPV_Test_Within_5_Years_for_Women_Age_30_and_Older(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_HPV_Test_Within_5_Years_for_Women_Age_30_and_Older, HPV_Test_Within_5_Years_for_Women_Age_30_and_Older_Compute);

    private const long _cacheIndex_HPV_Test_Within_5_Years_for_Women_Age_30_and_Older = 1212710686634371765L;

    private IEnumerable<Observation> HPV_Test_Within_5_Years_for_Women_Age_30_and_Older_Compute(CqlContext context)
    {
        CqlValueSet a_ = this.HPV_Test(context);
        IEnumerable<Observation> b_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/StructureDefinition/Observation"));

        bool? c_(Observation HPVTest) {
            Code<ObservationStatus> e_ = HPVTest?.StatusElement;
            string f_ = FHIRHelpers_4_0_001.Instance.ToString(context, e_);
            string[] g_ = [
                "final",
                "amended",
                "corrected",
            ];
            bool? h_ = context.Operators.In<string>(f_, (IEnumerable<string>)g_);
            bool? i_;
            // CQL 'and' (100:11-103:7): right operand skipped when left is false
            if (h_ is false)
            {
                i_ = false;
            }
            else
            {
                List<CodeableConcept> l_ = HPVTest?.Category;

                bool? m_(CodeableConcept HPVTestCategory) {
                    CqlCode o_ = this.laboratory(context);
                    CqlConcept p_ = FHIRHelpers_4_0_001.Instance.ToConcept(context, HPVTestCategory);
                    IReadOnlyList<CqlCode> q_ = p_?.codes;
                    bool? r_ = context.Operators.In<CqlCode>(o_, (IEnumerable<CqlCode>)q_);
                    return r_;
                }

                bool? n_ = context.Operators.WhereAny<CodeableConcept>((IEnumerable<CodeableConcept>)l_, m_);
                i_ = h_ & n_;
            }
            bool? j_;
            // CQL 'and' (100:11-104:94): right operand skipped when left is false
            if (i_ is false)
            {
                j_ = false;
            }
            else
            {
                Patient s_ = this.Patient(context);
                Date t_ = s_?.BirthDateElement;
                string u_ = t_?.Value;
                CqlDate v_ = context.Operators.ConvertStringToDate(u_);
                DataType w_ = HPVTest?.Effective;
                CqlInterval<CqlDateTime> x_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, w_);
                CqlDateTime y_ = context.Operators.Start(x_);
                CqlDate z_ = context.Operators.DateFrom(y_);
                int? aa_ = context.Operators.CalculateAgeAt(v_, z_, "year");
                bool? ab_ = context.Operators.GreaterOrEqual(aa_, 30);
                j_ = i_ & ab_;
            }
            bool? k_;
            // CQL 'and' (100:11-105:104): right operand skipped when left is false
            if (j_ is false)
            {
                k_ = false;
            }
            else
            {
                DataType ac_ = HPVTest?.Effective;
                CqlDateTime ad_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Latest(context, ac_);
                CqlInterval<CqlDateTime> ae_ = this.Measurement_Period(context);
                CqlDateTime af_ = context.Operators.End(ae_);
                CqlQuantity ag_ = context.Operators.Quantity(5m, "years");
                CqlDateTime ah_ = context.Operators.Subtract(af_, ag_);
                CqlInterval<CqlDateTime> ai_ = context.Operators.Interval(ah_, af_, true, true);
                bool? aj_ = context.Operators.In<CqlDateTime>(ad_, ai_, (string)default);
                bool? ak_;
                // CQL 'and' (105:11-105:104): right operand skipped when left is false
                if (aj_ is false)
                {
                    ak_ = false;
                }
                else
                {
                    CqlInterval<CqlDateTime> al_ = this.Measurement_Period(context);
                    CqlDateTime am_ = context.Operators.End(al_);
                    ak_ = aj_ & (!((bool?)(am_ is null)));
                }
                k_ = j_ & ak_;
            }
            // CQL 'and' (100:5-106:35): right operand skipped when left is false
            if (k_ is false)
            {
                return false;
            }
            else
            {
                DataType an_ = HPVTest?.Value;
                return k_ & (!((bool?)(an_ is null)));
            }
        }

        IEnumerable<Observation> d_ = context.Operators.Where<Observation>(b_, c_);
        return d_;
    }


    [CqlExpressionDefinition("Numerator")]
    public bool? Numerator(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Numerator, Numerator_Compute);

    private const long _cacheIndex_Numerator = -6987695886046933308L;

    private bool? Numerator_Compute(CqlContext context)
    {
        IEnumerable<Observation> a_ = this.Cervical_Cytology_Within_3_Years(context);
        bool? b_ = context.Operators.Exists<Observation>(a_);
        // CQL 'or' (67:3-68:76): right operand skipped when left is true
        if (b_ is true)
        {
            return true;
        }
        else
        {
            IEnumerable<Observation> c_ = this.HPV_Test_Within_5_Years_for_Women_Age_30_and_Older(context);
            bool? d_ = context.Operators.Exists<Observation>(c_);
            return b_ | d_;
        }
    }


    [CqlFunctionDefinition("isComplete")]
    public bool? isComplete(CqlContext context, Observation observation)
    {
        Code<ObservationStatus> a_ = observation?.StatusElement;
        string b_ = FHIRHelpers_4_0_001.Instance.ToString(context, a_);
        string[] c_ = [
            "final",
            "amended",
            "corrected",
        ];
        bool? d_ = context.Operators.In<string>(b_, (IEnumerable<string>)c_);
        return d_;
    }


    [CqlFunctionDefinition("isLaboratoryTest")]
    public bool? isLaboratoryTest(CqlContext context, Observation observation)
    {
        List<CodeableConcept> a_ = observation?.Category;

        bool? b_(CodeableConcept category) {
            CqlCode d_ = this.laboratory(context);
            CqlConcept e_ = FHIRHelpers_4_0_001.Instance.ToConcept(context, category);
            IReadOnlyList<CqlCode> f_ = e_?.codes;
            bool? g_ = context.Operators.In<CqlCode>(d_, (IEnumerable<CqlCode>)f_);
            return g_;
        }

        bool? c_ = context.Operators.WhereAny<CodeableConcept>((IEnumerable<CodeableConcept>)a_, b_);
        return c_;
    }


    [CqlFunctionDefinition("latest")]
    public CqlDateTime latest(CqlContext context, object choice)
    {
        CqlDateTime a_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Latest(context, choice);
        return a_;
    }


    [CqlExpressionDefinition("Cervical Cytology Within 3 Years (2)")]
    public IEnumerable<Observation> Cervical_Cytology_Within_3_Years__2_(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Cervical_Cytology_Within_3_Years__2_, Cervical_Cytology_Within_3_Years__2__Compute);

    private const long _cacheIndex_Cervical_Cytology_Within_3_Years__2_ = -1395539976685561539L;

    private IEnumerable<Observation> Cervical_Cytology_Within_3_Years__2__Compute(CqlContext context)
    {
        CqlValueSet a_ = this.Pap_Test(context);
        IEnumerable<Observation> b_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/StructureDefinition/Observation"));

        bool? c_(Observation CervicalCytology) {
            bool? e_ = this.isComplete(context, CervicalCytology);
            bool? f_;
            // CQL 'and' (93:11-94:45): right operand skipped when left is false
            if (e_ is false)
            {
                f_ = false;
            }
            else
            {
                bool? h_ = this.isLaboratoryTest(context, CervicalCytology);
                f_ = e_ & h_;
            }
            bool? g_;
            // CQL 'and' (93:11-95:102): right operand skipped when left is false
            if (f_ is false)
            {
                g_ = false;
            }
            else
            {
                DataType i_ = CervicalCytology?.Effective;
                CqlDateTime j_ = this.latest(context, i_);
                CqlInterval<CqlDateTime> k_ = this.Measurement_Period(context);
                CqlDateTime l_ = context.Operators.End(k_);
                CqlQuantity m_ = context.Operators.Quantity(3m, "years");
                CqlDateTime n_ = context.Operators.Subtract(l_, m_);
                CqlInterval<CqlDateTime> o_ = context.Operators.Interval(n_, l_, true, true);
                bool? p_ = context.Operators.In<CqlDateTime>(j_, o_, (string)default);
                bool? q_;
                // CQL 'and' (95:11-95:102): right operand skipped when left is false
                if (p_ is false)
                {
                    q_ = false;
                }
                else
                {
                    CqlInterval<CqlDateTime> r_ = this.Measurement_Period(context);
                    CqlDateTime s_ = context.Operators.End(r_);
                    q_ = p_ & (!((bool?)(s_ is null)));
                }
                g_ = f_ & q_;
            }
            // CQL 'and' (93:5-96:44): right operand skipped when left is false
            if (g_ is false)
            {
                return false;
            }
            else
            {
                DataType t_ = CervicalCytology?.Value;
                return g_ & (!((bool?)(t_ is null)));
            }
        }

        IEnumerable<Observation> d_ = context.Operators.Where<Observation>(b_, c_);
        return d_;
    }


    [CqlFunctionDefinition("toInterval")]
    public CqlInterval<CqlDateTime> toInterval(CqlContext context, object choice)
    {
        CqlInterval<CqlDateTime> a_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, choice);
        return a_;
    }


    [CqlExpressionDefinition("HPV Test Within 5 Years for Women Age 30 and Older (2)")]
    public IEnumerable<Observation> HPV_Test_Within_5_Years_for_Women_Age_30_and_Older__2_(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_HPV_Test_Within_5_Years_for_Women_Age_30_and_Older__2_, HPV_Test_Within_5_Years_for_Women_Age_30_and_Older__2__Compute);

    private const long _cacheIndex_HPV_Test_Within_5_Years_for_Women_Age_30_and_Older__2_ = -8527355444227531163L;

    private IEnumerable<Observation> HPV_Test_Within_5_Years_for_Women_Age_30_and_Older__2__Compute(CqlContext context)
    {
        CqlValueSet a_ = this.HPV_Test(context);
        IEnumerable<Observation> b_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/StructureDefinition/Observation"));

        bool? c_(Observation HPVTest) {
            bool? e_ = this.isComplete(context, HPVTest);
            bool? f_;
            // CQL 'and' (110:11-111:36): right operand skipped when left is false
            if (e_ is false)
            {
                f_ = false;
            }
            else
            {
                bool? i_ = this.isLaboratoryTest(context, HPVTest);
                f_ = e_ & i_;
            }
            bool? g_;
            // CQL 'and' (110:11-112:79): right operand skipped when left is false
            if (f_ is false)
            {
                g_ = false;
            }
            else
            {
                Patient j_ = this.Patient(context);
                Date k_ = j_?.BirthDateElement;
                string l_ = k_?.Value;
                CqlDate m_ = context.Operators.ConvertStringToDate(l_);
                DataType n_ = HPVTest?.Effective;
                CqlInterval<CqlDateTime> o_ = this.toInterval(context, n_);
                CqlDateTime p_ = context.Operators.Start(o_);
                CqlDate q_ = context.Operators.DateFrom(p_);
                int? r_ = context.Operators.CalculateAgeAt(m_, q_, "year");
                bool? s_ = context.Operators.GreaterOrEqual(r_, 30);
                g_ = f_ & s_;
            }
            bool? h_;
            // CQL 'and' (110:11-113:93): right operand skipped when left is false
            if (g_ is false)
            {
                h_ = false;
            }
            else
            {
                DataType t_ = HPVTest?.Effective;
                CqlDateTime u_ = this.latest(context, t_);
                CqlInterval<CqlDateTime> v_ = this.Measurement_Period(context);
                CqlDateTime w_ = context.Operators.End(v_);
                CqlQuantity x_ = context.Operators.Quantity(5m, "years");
                CqlDateTime y_ = context.Operators.Subtract(w_, x_);
                CqlInterval<CqlDateTime> z_ = context.Operators.Interval(y_, w_, true, true);
                bool? aa_ = context.Operators.In<CqlDateTime>(u_, z_, (string)default);
                bool? ab_;
                // CQL 'and' (113:11-113:93): right operand skipped when left is false
                if (aa_ is false)
                {
                    ab_ = false;
                }
                else
                {
                    CqlInterval<CqlDateTime> ac_ = this.Measurement_Period(context);
                    CqlDateTime ad_ = context.Operators.End(ac_);
                    ab_ = aa_ & (!((bool?)(ad_ is null)));
                }
                h_ = g_ & ab_;
            }
            // CQL 'and' (110:5-114:35): right operand skipped when left is false
            if (h_ is false)
            {
                return false;
            }
            else
            {
                DataType ae_ = HPVTest?.Value;
                return h_ & (!((bool?)(ae_ is null)));
            }
        }

        IEnumerable<Observation> d_ = context.Operators.Where<Observation>(b_, c_);
        return d_;
    }


    #endregion Functions and Expressions

    #region Singleton Lifetime Members

    private CervicalCancerScreeningFHIR_0_0_005() {}

    public static CervicalCancerScreeningFHIR_0_0_005 Instance { get; } = new();

    #endregion

    #region ILibrary Implementation

    public string Name => "CervicalCancerScreeningFHIR";
    public string Version => "0.0.005";
    public ILibrary[] Dependencies => [FHIRHelpers_4_0_001.Instance, SupplementalDataElementsFHIR4_2_0_000.Instance, MATGlobalCommonFunctionsFHIR4_6_1_000.Instance, HospiceFHIR4_2_3_000.Instance, PalliativeCareFHIR_0_6_000.Instance];

    #endregion ILibrary Implementation

}

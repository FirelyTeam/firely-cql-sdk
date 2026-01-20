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
using Hl7.Cql.Runtime.Internal;
using Hl7.Fhir.Model;
using Range = Hl7.Fhir.Model.Range;
using Task = Hl7.Fhir.Model.Task;

[System.CodeDom.Compiler.GeneratedCode(".NET Code Generation", "6.0.0.0")]
[CqlLibrary("PrimaryCariesPreventionasOfferedbyPCPsincludingDentistsFHIR", "0.0.008")]
public partial class PrimaryCariesPreventionasOfferedbyPCPsincludingDentistsFHIR_0_0_008 : ILibrary, ILibraryInternals, ISingleton<PrimaryCariesPreventionasOfferedbyPCPsincludingDentistsFHIR_0_0_008>
{
    #region ValueSets (9)

    [CqlValueSetDefinition("Clinical Oral Evaluation", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.125.12.1003", valueSetVersion: null)]
    public CqlValueSet Clinical_Oral_Evaluation(CqlContext _) => _Clinical_Oral_Evaluation;
    private static readonly CqlValueSet _Clinical_Oral_Evaluation = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.125.12.1003", null);

    [CqlValueSetDefinition("Fluoride Varnish Application for Children", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.125.12.1002", valueSetVersion: null)]
    public CqlValueSet Fluoride_Varnish_Application_for_Children(CqlContext _) => _Fluoride_Varnish_Application_for_Children;
    private static readonly CqlValueSet _Fluoride_Varnish_Application_for_Children = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.125.12.1002", null);

    [CqlValueSetDefinition("Office Visit", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1001", valueSetVersion: null)]
    public CqlValueSet Office_Visit(CqlContext _) => _Office_Visit;
    private static readonly CqlValueSet _Office_Visit = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1001", null);

    [CqlValueSetDefinition("Online Assessments", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1089", valueSetVersion: null)]
    public CqlValueSet Online_Assessments(CqlContext _) => _Online_Assessments;
    private static readonly CqlValueSet _Online_Assessments = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1089", null);

    [CqlValueSetDefinition("Preventive Care - Established Office Visit, 0 to 17", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1024", valueSetVersion: null)]
    public CqlValueSet Preventive_Care___Established_Office_Visit__0_to_17(CqlContext _) => _Preventive_Care___Established_Office_Visit__0_to_17;
    private static readonly CqlValueSet _Preventive_Care___Established_Office_Visit__0_to_17 = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1024", null);

    [CqlValueSetDefinition("Preventive Care Services - Established Office Visit, 18 and Up", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1025", valueSetVersion: null)]
    public CqlValueSet Preventive_Care_Services___Established_Office_Visit__18_and_Up(CqlContext _) => _Preventive_Care_Services___Established_Office_Visit__18_and_Up;
    private static readonly CqlValueSet _Preventive_Care_Services___Established_Office_Visit__18_and_Up = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1025", null);

    [CqlValueSetDefinition("Preventive Care Services-Initial Office Visit, 18 and Up", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1023", valueSetVersion: null)]
    public CqlValueSet Preventive_Care_Services_Initial_Office_Visit__18_and_Up(CqlContext _) => _Preventive_Care_Services_Initial_Office_Visit__18_and_Up;
    private static readonly CqlValueSet _Preventive_Care_Services_Initial_Office_Visit__18_and_Up = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1023", null);

    [CqlValueSetDefinition("Preventive Care- Initial Office Visit, 0 to 17", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1022", valueSetVersion: null)]
    public CqlValueSet Preventive_Care__Initial_Office_Visit__0_to_17(CqlContext _) => _Preventive_Care__Initial_Office_Visit__0_to_17;
    private static readonly CqlValueSet _Preventive_Care__Initial_Office_Visit__0_to_17 = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1022", null);

    [CqlValueSetDefinition("Telephone Visits", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1080", valueSetVersion: null)]
    public CqlValueSet Telephone_Visits(CqlContext _) => _Telephone_Visits;
    private static readonly CqlValueSet _Telephone_Visits = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1080", null);

    #endregion ValueSets

    #region Codes (1)

    [CqlCodeDefinition("Birth date", codeId: "21112-8", codeSystem: "http://loinc.org")]
    public CqlCode Birth_date(CqlContext _) => _Birth_date;
    private static readonly CqlCode _Birth_date = new CqlCode("21112-8", "http://loinc.org");

    #endregion Codes

    #region CodeSystems (1)

    [CqlCodeSystemDefinition("LOINC", codeSystemId: "http://loinc.org", codeSystemVersion: null)]
    public CqlCodeSystem LOINC(CqlContext _) => _LOINC;
    private static readonly CqlCodeSystem _LOINC =
      new CqlCodeSystem("http://loinc.org", null, [
          _Birth_date]);

    #endregion CodeSystems

    #region Parameters (1)

    [CqlParameterDefinition("Measurement Period")]
    public CqlInterval<CqlDateTime> Measurement_Period(CqlContext context) =>
        ((ICqlContextInternals)context).GetOrCompute<CqlInterval<CqlDateTime>>(
            _cacheIndex_Measurement_Period,
            Measurement_Period_Compute);

    private CqlInterval<CqlDateTime> Measurement_Period_Compute(CqlContext context)
    {
        object a_ = context.ResolveParameter("PrimaryCariesPreventionasOfferedbyPCPsincludingDentistsFHIR-0.0.008", "Measurement Period", null);
        return (CqlInterval<CqlDateTime>)a_;
    }


    #endregion Parameters

    #region Functions and Expressions (13)

    [CqlExpressionDefinition("Patient")]
    public Patient Patient(CqlContext context) =>
        ((ICqlContextInternals)context).GetOrCompute<Patient>(
            _cacheIndex_Patient,
            Patient_Compute);

    private Patient Patient_Compute(CqlContext context)
    {
        IEnumerable<Patient> a_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/StructureDefinition/Patient"));
        Patient b_ = context.Operators.SingletonFrom<Patient>(a_);
        return b_;
    }


    [CqlExpressionDefinition("SDE Ethnicity")]
    public IEnumerable<Coding> SDE_Ethnicity(CqlContext context) =>
        ((ICqlContextInternals)context).GetOrCompute<IEnumerable<Coding>>(
            _cacheIndex_SDE_Ethnicity,
            SDE_Ethnicity_Compute);

    private IEnumerable<Coding> SDE_Ethnicity_Compute(CqlContext context)
    {
        IEnumerable<Coding> a_ = SupplementalDataElementsFHIR4_2_0_000.Instance.SDE_Ethnicity(context);
        return a_;
    }


    [CqlExpressionDefinition("SDE Payer")]
    public IEnumerable<(CqlTupleMetadata, CodeableConcept code, Period period)?> SDE_Payer(CqlContext context) =>
        ((ICqlContextInternals)context).GetOrCompute<IEnumerable<(CqlTupleMetadata, CodeableConcept code, Period period)?>>(
            _cacheIndex_SDE_Payer,
            SDE_Payer_Compute);

    private IEnumerable<(CqlTupleMetadata, CodeableConcept code, Period period)?> SDE_Payer_Compute(CqlContext context)
    {
        IEnumerable<(CqlTupleMetadata, CodeableConcept code, Period period)?> a_ = SupplementalDataElementsFHIR4_2_0_000.Instance.SDE_Payer(context);
        return a_;
    }


    [CqlExpressionDefinition("SDE Race")]
    public IEnumerable<Coding> SDE_Race(CqlContext context) =>
        ((ICqlContextInternals)context).GetOrCompute<IEnumerable<Coding>>(
            _cacheIndex_SDE_Race,
            SDE_Race_Compute);

    private IEnumerable<Coding> SDE_Race_Compute(CqlContext context)
    {
        IEnumerable<Coding> a_ = SupplementalDataElementsFHIR4_2_0_000.Instance.SDE_Race(context);
        return a_;
    }


    [CqlExpressionDefinition("SDE Sex")]
    public CqlCode SDE_Sex(CqlContext context) =>
        ((ICqlContextInternals)context).GetOrCompute<CqlCode>(
            _cacheIndex_SDE_Sex,
            SDE_Sex_Compute);

    private CqlCode SDE_Sex_Compute(CqlContext context)
    {
        CqlCode a_ = SupplementalDataElementsFHIR4_2_0_000.Instance.SDE_Sex(context);
        return a_;
    }


    [CqlExpressionDefinition("Qualifying Encounters")]
    public IEnumerable<Encounter> Qualifying_Encounters(CqlContext context) =>
        ((ICqlContextInternals)context).GetOrCompute<IEnumerable<Encounter>>(
            _cacheIndex_Qualifying_Encounters,
            Qualifying_Encounters_Compute);

    private IEnumerable<Encounter> Qualifying_Encounters_Compute(CqlContext context)
    {
        CqlValueSet a_ = this.Office_Visit(context);
        IEnumerable<Encounter> b_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/StructureDefinition/Encounter"));
        CqlValueSet c_ = this.Preventive_Care___Established_Office_Visit__0_to_17(context);
        IEnumerable<Encounter> d_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, c_, default, "http://hl7.org/fhir/StructureDefinition/Encounter"));
        IEnumerable<Encounter> e_ = context.Operators.Union<Encounter>(b_, d_);
        CqlValueSet f_ = this.Preventive_Care__Initial_Office_Visit__0_to_17(context);
        IEnumerable<Encounter> g_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, f_, default, "http://hl7.org/fhir/StructureDefinition/Encounter"));
        CqlValueSet h_ = this.Preventive_Care_Services___Established_Office_Visit__18_and_Up(context);
        IEnumerable<Encounter> i_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, h_, default, "http://hl7.org/fhir/StructureDefinition/Encounter"));
        IEnumerable<Encounter> j_ = context.Operators.Union<Encounter>(g_, i_);
        IEnumerable<Encounter> k_ = context.Operators.Union<Encounter>(e_, j_);
        CqlValueSet l_ = this.Preventive_Care_Services_Initial_Office_Visit__18_and_Up(context);
        IEnumerable<Encounter> m_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, l_, default, "http://hl7.org/fhir/StructureDefinition/Encounter"));
        CqlValueSet n_ = this.Clinical_Oral_Evaluation(context);
        IEnumerable<Encounter> o_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, n_, default, "http://hl7.org/fhir/StructureDefinition/Encounter"));
        IEnumerable<Encounter> p_ = context.Operators.Union<Encounter>(m_, o_);
        IEnumerable<Encounter> q_ = context.Operators.Union<Encounter>(k_, p_);
        CqlValueSet r_ = this.Telephone_Visits(context);
        IEnumerable<Encounter> s_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, r_, default, "http://hl7.org/fhir/StructureDefinition/Encounter"));
        CqlValueSet t_ = this.Online_Assessments(context);
        IEnumerable<Encounter> u_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, t_, default, "http://hl7.org/fhir/StructureDefinition/Encounter"));
        IEnumerable<Encounter> v_ = context.Operators.Union<Encounter>(s_, u_);
        IEnumerable<Encounter> w_ = context.Operators.Union<Encounter>(q_, v_);

        bool? x_(Encounter ValidEncounter) {
            CqlInterval<CqlDateTime> z_ = this.Measurement_Period(context);
            Period aa_ = ValidEncounter?.Period;
            CqlInterval<CqlDateTime> ab_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, aa_ as object);
            bool? ac_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(z_, ab_, default);
            Code<Encounter.EncounterStatus> ad_ = ValidEncounter?.StatusElement;
            string ae_ = FHIRHelpers_4_0_001.Instance.ToString(context, ad_);
            bool? af_ = context.Operators.Equal(ae_, "finished");
            bool? ag_ = context.Operators.And(ac_, af_);
            return ag_;
        }

        IEnumerable<Encounter> y_ = context.Operators.Where<Encounter>(w_, x_);
        return y_;
    }


    [CqlExpressionDefinition("Initial Population")]
    public bool? Initial_Population(CqlContext context) =>
        ((ICqlContextInternals)context).GetOrCompute<bool?>(
            _cacheIndex_Initial_Population,
            Initial_Population_Compute);

    private bool? Initial_Population_Compute(CqlContext context)
    {
        Patient a_ = this.Patient(context);
        Date b_ = a_?.BirthDateElement;
        string c_ = b_?.Value;
        CqlDate d_ = context.Operators.ConvertStringToDate(c_);
        CqlInterval<CqlDateTime> e_ = this.Measurement_Period(context);
        CqlDateTime f_ = context.Operators.Start(e_);
        CqlDate g_ = context.Operators.DateFrom(f_);
        int? h_ = context.Operators.CalculateAgeAt(d_, g_, "month");
        bool? i_ = context.Operators.GreaterOrEqual(h_, 6);
        Date k_ = a_?.BirthDateElement;
        string l_ = k_?.Value;
        CqlDate m_ = context.Operators.ConvertStringToDate(l_);
        CqlDateTime o_ = context.Operators.Start(e_);
        CqlDate p_ = context.Operators.DateFrom(o_);
        int? q_ = context.Operators.CalculateAgeAt(m_, p_, "year");
        bool? r_ = context.Operators.Less(q_, 20);
        bool? s_ = context.Operators.And(i_, r_);
        IEnumerable<Encounter> t_ = this.Qualifying_Encounters(context);
        bool? u_ = context.Operators.Exists<Encounter>(t_);
        bool? v_ = context.Operators.And(s_, u_);
        return v_;
    }


    [CqlExpressionDefinition("Denominator")]
    public bool? Denominator(CqlContext context) =>
        ((ICqlContextInternals)context).GetOrCompute<bool?>(
            _cacheIndex_Denominator,
            Denominator_Compute);

    private bool? Denominator_Compute(CqlContext context)
    {
        bool? a_ = this.Initial_Population(context);
        return a_;
    }


    [CqlExpressionDefinition("Denominator Exclusions")]
    public bool? Denominator_Exclusions(CqlContext context) =>
        ((ICqlContextInternals)context).GetOrCompute<bool?>(
            _cacheIndex_Denominator_Exclusions,
            Denominator_Exclusions_Compute);

    private bool? Denominator_Exclusions_Compute(CqlContext context)
    {
        bool? a_ = HospiceFHIR4_2_3_000.Instance.Has_Hospice(context);
        return a_;
    }


    [CqlExpressionDefinition("Stratification 1")]
    public bool? Stratification_1(CqlContext context) =>
        ((ICqlContextInternals)context).GetOrCompute<bool?>(
            _cacheIndex_Stratification_1,
            Stratification_1_Compute);

    private bool? Stratification_1_Compute(CqlContext context)
    {
        Patient a_ = this.Patient(context);
        Date b_ = a_?.BirthDateElement;
        string c_ = b_?.Value;
        CqlDate d_ = context.Operators.ConvertStringToDate(c_);
        CqlInterval<CqlDateTime> e_ = this.Measurement_Period(context);
        CqlDateTime f_ = context.Operators.Start(e_);
        CqlDate g_ = context.Operators.DateFrom(f_);
        int? h_ = context.Operators.CalculateAgeAt(d_, g_, "month");
        bool? i_ = context.Operators.GreaterOrEqual(h_, 6);
        Date k_ = a_?.BirthDateElement;
        string l_ = k_?.Value;
        CqlDate m_ = context.Operators.ConvertStringToDate(l_);
        CqlDateTime o_ = context.Operators.Start(e_);
        CqlDate p_ = context.Operators.DateFrom(o_);
        int? q_ = context.Operators.CalculateAgeAt(m_, p_, "year");
        bool? r_ = context.Operators.LessOrEqual(q_, 4);
        bool? s_ = context.Operators.And(i_, r_);
        return s_;
    }


    [CqlExpressionDefinition("Stratification 2")]
    public bool? Stratification_2(CqlContext context) =>
        ((ICqlContextInternals)context).GetOrCompute<bool?>(
            _cacheIndex_Stratification_2,
            Stratification_2_Compute);

    private bool? Stratification_2_Compute(CqlContext context)
    {
        Patient a_ = this.Patient(context);
        Date b_ = a_?.BirthDateElement;
        string c_ = b_?.Value;
        CqlDate d_ = context.Operators.ConvertStringToDate(c_);
        CqlInterval<CqlDateTime> e_ = this.Measurement_Period(context);
        CqlDateTime f_ = context.Operators.Start(e_);
        CqlDate g_ = context.Operators.DateFrom(f_);
        int? h_ = context.Operators.CalculateAgeAt(d_, g_, "year");
        CqlInterval<int?> i_ = context.Operators.Interval(5, 11, true, true);
        bool? j_ = context.Operators.In<int?>(h_, i_, default);
        return j_;
    }


    [CqlExpressionDefinition("Stratification 3")]
    public bool? Stratification_3(CqlContext context) =>
        ((ICqlContextInternals)context).GetOrCompute<bool?>(
            _cacheIndex_Stratification_3,
            Stratification_3_Compute);

    private bool? Stratification_3_Compute(CqlContext context)
    {
        Patient a_ = this.Patient(context);
        Date b_ = a_?.BirthDateElement;
        string c_ = b_?.Value;
        CqlDate d_ = context.Operators.ConvertStringToDate(c_);
        CqlInterval<CqlDateTime> e_ = this.Measurement_Period(context);
        CqlDateTime f_ = context.Operators.Start(e_);
        CqlDate g_ = context.Operators.DateFrom(f_);
        int? h_ = context.Operators.CalculateAgeAt(d_, g_, "year");
        CqlInterval<int?> i_ = context.Operators.Interval(12, 20, true, false);
        bool? j_ = context.Operators.In<int?>(h_, i_, default);
        return j_;
    }


    [CqlExpressionDefinition("Numerator")]
    public bool? Numerator(CqlContext context) =>
        ((ICqlContextInternals)context).GetOrCompute<bool?>(
            _cacheIndex_Numerator,
            Numerator_Compute);

    private bool? Numerator_Compute(CqlContext context)
    {
        CqlValueSet a_ = this.Fluoride_Varnish_Application_for_Children(context);
        IEnumerable<Procedure> b_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/StructureDefinition/Procedure"));

        bool? c_(Procedure FluorideApplication) {
            CqlInterval<CqlDateTime> f_ = this.Measurement_Period(context);
            DataType g_ = FluorideApplication?.Performed;
            CqlInterval<CqlDateTime> h_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, g_);
            bool? i_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(f_, h_, default);
            Code<EventStatus> j_ = FluorideApplication?.StatusElement;
            string k_ = FHIRHelpers_4_0_001.Instance.ToString(context, j_);
            bool? l_ = context.Operators.Equal(k_, "completed");
            bool? m_ = context.Operators.And(i_, l_);
            return m_;
        }

        IEnumerable<Procedure> d_ = context.Operators.Where<Procedure>(b_, c_);
        bool? e_ = context.Operators.Exists<Procedure>(d_);
        return e_;
    }


    #endregion Functions and Expressions

    #region Cache Index Fields (14)

    private int _cacheIndex_Measurement_Period = -1;
    private int _cacheIndex_Patient = -1;
    private int _cacheIndex_SDE_Ethnicity = -1;
    private int _cacheIndex_SDE_Payer = -1;
    private int _cacheIndex_SDE_Race = -1;
    private int _cacheIndex_SDE_Sex = -1;
    private int _cacheIndex_Qualifying_Encounters = -1;
    private int _cacheIndex_Initial_Population = -1;
    private int _cacheIndex_Denominator = -1;
    private int _cacheIndex_Denominator_Exclusions = -1;
    private int _cacheIndex_Stratification_1 = -1;
    private int _cacheIndex_Stratification_2 = -1;
    private int _cacheIndex_Stratification_3 = -1;
    private int _cacheIndex_Numerator = -1;

    #endregion Cache Index Fields

    #region ILibraryInternals Implementation

    bool ILibraryInternals.CacheIndicesInitialized { get; set; }

    int ILibraryInternals.InitializeCacheIndices(CacheIndexInitializer initializer)
    {
        // Skip if already processed
        if (!initializer.MarkAsProcessed(this))
            return 0;

        var count = 0;

        // Process dependencies first (depth-first traversal)
        if (Dependencies is { Length: > 0 })
        {
            foreach (var dependency in Dependencies)
            {
                if (dependency is ILibraryInternals internals)
                {
                    count += internals.InitializeCacheIndices(initializer);
                }
            }
        }

        // Initialize cache indices for this library
        if (_cacheIndex_Measurement_Period != -1)
            throw new InvalidOperationException($"Cache index field '_cacheIndex_Measurement_Period' in library '{{Name}}' version '{{Version}}' is already initialized to {{_cacheIndex_Measurement_Period}}. Cache indices can only be initialized once.");
        _cacheIndex_Measurement_Period = initializer.GetNextIndex();
        count++;

        if (_cacheIndex_Patient != -1)
            throw new InvalidOperationException($"Cache index field '_cacheIndex_Patient' in library '{{Name}}' version '{{Version}}' is already initialized to {{_cacheIndex_Patient}}. Cache indices can only be initialized once.");
        _cacheIndex_Patient = initializer.GetNextIndex();
        count++;

        if (_cacheIndex_SDE_Ethnicity != -1)
            throw new InvalidOperationException($"Cache index field '_cacheIndex_SDE_Ethnicity' in library '{{Name}}' version '{{Version}}' is already initialized to {{_cacheIndex_SDE_Ethnicity}}. Cache indices can only be initialized once.");
        _cacheIndex_SDE_Ethnicity = initializer.GetNextIndex();
        count++;

        if (_cacheIndex_SDE_Payer != -1)
            throw new InvalidOperationException($"Cache index field '_cacheIndex_SDE_Payer' in library '{{Name}}' version '{{Version}}' is already initialized to {{_cacheIndex_SDE_Payer}}. Cache indices can only be initialized once.");
        _cacheIndex_SDE_Payer = initializer.GetNextIndex();
        count++;

        if (_cacheIndex_SDE_Race != -1)
            throw new InvalidOperationException($"Cache index field '_cacheIndex_SDE_Race' in library '{{Name}}' version '{{Version}}' is already initialized to {{_cacheIndex_SDE_Race}}. Cache indices can only be initialized once.");
        _cacheIndex_SDE_Race = initializer.GetNextIndex();
        count++;

        if (_cacheIndex_SDE_Sex != -1)
            throw new InvalidOperationException($"Cache index field '_cacheIndex_SDE_Sex' in library '{{Name}}' version '{{Version}}' is already initialized to {{_cacheIndex_SDE_Sex}}. Cache indices can only be initialized once.");
        _cacheIndex_SDE_Sex = initializer.GetNextIndex();
        count++;

        if (_cacheIndex_Qualifying_Encounters != -1)
            throw new InvalidOperationException($"Cache index field '_cacheIndex_Qualifying_Encounters' in library '{{Name}}' version '{{Version}}' is already initialized to {{_cacheIndex_Qualifying_Encounters}}. Cache indices can only be initialized once.");
        _cacheIndex_Qualifying_Encounters = initializer.GetNextIndex();
        count++;

        if (_cacheIndex_Initial_Population != -1)
            throw new InvalidOperationException($"Cache index field '_cacheIndex_Initial_Population' in library '{{Name}}' version '{{Version}}' is already initialized to {{_cacheIndex_Initial_Population}}. Cache indices can only be initialized once.");
        _cacheIndex_Initial_Population = initializer.GetNextIndex();
        count++;

        if (_cacheIndex_Denominator != -1)
            throw new InvalidOperationException($"Cache index field '_cacheIndex_Denominator' in library '{{Name}}' version '{{Version}}' is already initialized to {{_cacheIndex_Denominator}}. Cache indices can only be initialized once.");
        _cacheIndex_Denominator = initializer.GetNextIndex();
        count++;

        if (_cacheIndex_Denominator_Exclusions != -1)
            throw new InvalidOperationException($"Cache index field '_cacheIndex_Denominator_Exclusions' in library '{{Name}}' version '{{Version}}' is already initialized to {{_cacheIndex_Denominator_Exclusions}}. Cache indices can only be initialized once.");
        _cacheIndex_Denominator_Exclusions = initializer.GetNextIndex();
        count++;

        if (_cacheIndex_Stratification_1 != -1)
            throw new InvalidOperationException($"Cache index field '_cacheIndex_Stratification_1' in library '{{Name}}' version '{{Version}}' is already initialized to {{_cacheIndex_Stratification_1}}. Cache indices can only be initialized once.");
        _cacheIndex_Stratification_1 = initializer.GetNextIndex();
        count++;

        if (_cacheIndex_Stratification_2 != -1)
            throw new InvalidOperationException($"Cache index field '_cacheIndex_Stratification_2' in library '{{Name}}' version '{{Version}}' is already initialized to {{_cacheIndex_Stratification_2}}. Cache indices can only be initialized once.");
        _cacheIndex_Stratification_2 = initializer.GetNextIndex();
        count++;

        if (_cacheIndex_Stratification_3 != -1)
            throw new InvalidOperationException($"Cache index field '_cacheIndex_Stratification_3' in library '{{Name}}' version '{{Version}}' is already initialized to {{_cacheIndex_Stratification_3}}. Cache indices can only be initialized once.");
        _cacheIndex_Stratification_3 = initializer.GetNextIndex();
        count++;

        if (_cacheIndex_Numerator != -1)
            throw new InvalidOperationException($"Cache index field '_cacheIndex_Numerator' in library '{{Name}}' version '{{Version}}' is already initialized to {{_cacheIndex_Numerator}}. Cache indices can only be initialized once.");
        _cacheIndex_Numerator = initializer.GetNextIndex();
        count++;

        return count;
    }

    #endregion ILibraryInternals Implementation

    #region Singleton Lifetime Members

    private PrimaryCariesPreventionasOfferedbyPCPsincludingDentistsFHIR_0_0_008() {}

    public static PrimaryCariesPreventionasOfferedbyPCPsincludingDentistsFHIR_0_0_008 Instance { get; } = new();

    #endregion

    #region ILibrary Implementation

    public string Name => "PrimaryCariesPreventionasOfferedbyPCPsincludingDentistsFHIR";
    public string Version => "0.0.008";
    public ILibrary[] Dependencies => [FHIRHelpers_4_0_001.Instance, SupplementalDataElementsFHIR4_2_0_000.Instance, MATGlobalCommonFunctionsFHIR4_6_1_000.Instance, HospiceFHIR4_2_3_000.Instance];

    #endregion ILibrary Implementation

}

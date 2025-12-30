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
[CqlLibrary("CMS143FHIRPOAGOpticNerveEval", "1.0.000")]
public partial class CMS143FHIRPOAGOpticNerveEval_1_0_000 : ILibrary, ISingleton<CMS143FHIRPOAGOpticNerveEval_1_0_000>
{
    private CMS143FHIRPOAGOpticNerveEval_1_0_000() {}

    public static CMS143FHIRPOAGOpticNerveEval_1_0_000 Instance { get; } = new();

    #region ILibrary Implementation

    public string Name => "CMS143FHIRPOAGOpticNerveEval";
    public string Version => "1.0.000";
    public ILibrary[] Dependencies => [FHIRHelpers_4_4_000.Instance, SupplementalDataElements_5_1_000.Instance, QICoreCommon_4_0_000.Instance];

    #endregion ILibrary Implementation

    #region Nested Type - Cached<T>

    private struct Cached<T>(object CacheVersion, T CachedValue)
    {
        public T GetOrReplace(ICqlContextInternals cqlContext, Func<T> factory)
        {
            var cqlContextCacheVersion = cqlContext.CacheVersion;
            if (cqlContextCacheVersion is null)
            {
                // No caching, clear out previous values
                CacheVersion = null;
                CachedValue = default;
                var value = factory();
                return value;
            }

            if (ReferenceEquals(CacheVersion, cqlContextCacheVersion))
            {
                // Cache hit
                return CachedValue;
            }
            else
            {
                // Cache miss, refresh and store
                var value = factory();
                CachedValue = value;
                CacheVersion = cqlContextCacheVersion;
                return value;
            }
        }
    }

    #endregion

    #region ValueSets

    [CqlValueSetDefinition("Care Services in Long-Term Residential Facility", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1014", valueSetVersion: null)]
    public CqlValueSet Care_Services_in_Long_Term_Residential_Facility(CqlContext _) => _Care_Services_in_Long_Term_Residential_Facility;
    private static readonly CqlValueSet _Care_Services_in_Long_Term_Residential_Facility = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1014", null);

    [CqlValueSetDefinition("Cup to Disc Ratio", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1333", valueSetVersion: null)]
    public CqlValueSet Cup_to_Disc_Ratio(CqlContext _) => _Cup_to_Disc_Ratio;
    private static readonly CqlValueSet _Cup_to_Disc_Ratio = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1333", null);

    [CqlValueSetDefinition("Medical Reason", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1007", valueSetVersion: null)]
    public CqlValueSet Medical_Reason(CqlContext _) => _Medical_Reason;
    private static readonly CqlValueSet _Medical_Reason = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1007", null);

    [CqlValueSetDefinition("Nursing Facility Visit", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1012", valueSetVersion: null)]
    public CqlValueSet Nursing_Facility_Visit(CqlContext _) => _Nursing_Facility_Visit;
    private static readonly CqlValueSet _Nursing_Facility_Visit = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1012", null);

    [CqlValueSetDefinition("Office Visit", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1001", valueSetVersion: null)]
    public CqlValueSet Office_Visit(CqlContext _) => _Office_Visit;
    private static readonly CqlValueSet _Office_Visit = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1001", null);

    [CqlValueSetDefinition("Ophthalmological Services", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1285", valueSetVersion: null)]
    public CqlValueSet Ophthalmological_Services(CqlContext _) => _Ophthalmological_Services;
    private static readonly CqlValueSet _Ophthalmological_Services = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1285", null);

    [CqlValueSetDefinition("Optic Disc Exam for Structural Abnormalities", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1334", valueSetVersion: null)]
    public CqlValueSet Optic_Disc_Exam_for_Structural_Abnormalities(CqlContext _) => _Optic_Disc_Exam_for_Structural_Abnormalities;
    private static readonly CqlValueSet _Optic_Disc_Exam_for_Structural_Abnormalities = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1334", null);

    [CqlValueSetDefinition("Outpatient Consultation", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1008", valueSetVersion: null)]
    public CqlValueSet Outpatient_Consultation(CqlContext _) => _Outpatient_Consultation;
    private static readonly CqlValueSet _Outpatient_Consultation = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1008", null);

    [CqlValueSetDefinition("Primary Open-Angle Glaucoma", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.326", valueSetVersion: null)]
    public CqlValueSet Primary_Open_Angle_Glaucoma(CqlContext _) => _Primary_Open_Angle_Glaucoma;
    private static readonly CqlValueSet _Primary_Open_Angle_Glaucoma = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.326", null);

    #endregion ValueSets

    #region Codes

    [CqlCodeDefinition("virtual", codeId: "VR", codeSystem: "http://terminology.hl7.org/CodeSystem/v3-ActCode")]
    public CqlCode @virtual(CqlContext _) => _virtual;
    private static readonly CqlCode _virtual = new CqlCode("VR", "http://terminology.hl7.org/CodeSystem/v3-ActCode");

    #endregion Codes

    #region CodeSystems

    [CqlCodeSystemDefinition("ActCode", codeSystemId: "http://terminology.hl7.org/CodeSystem/v3-ActCode", codeSystemVersion: null)]
    public CqlCodeSystem ActCode(CqlContext _) => _ActCode;
    private static readonly CqlCodeSystem _ActCode =
      new CqlCodeSystem("http://terminology.hl7.org/CodeSystem/v3-ActCode", null, [
          _virtual]);

    #endregion CodeSystems

    #region Parameters

    private Cached<CqlInterval<CqlDateTime>> _Measurement_Period_Cached = new();

    [CqlParameterDefinition("Measurement Period")]
    public CqlInterval<CqlDateTime> Measurement_Period(CqlContext context) =>
        _Measurement_Period_Cached.GetOrReplace(
            context,
            () =>
            {
                object a_ = context.ResolveParameter("CMS143FHIRPOAGOpticNerveEval-1.0.000", "Measurement Period", null);
                return (CqlInterval<CqlDateTime>)a_;
            });


    #endregion Parameters

    #region Functions and Expressions

    private Cached<Patient> _Patient_Cached = new();

    [CqlExpressionDefinition("Patient")]
    public Patient Patient(CqlContext context) =>
        _Patient_Cached.GetOrReplace(
            context,
            () =>
            {
                IEnumerable<Patient> a_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-patient"));
                Patient b_ = context.Operators.SingletonFrom<Patient>(a_);
                return b_;
            });


    private Cached<(CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)?> _SDE_Ethnicity_Cached = new();

    [CqlExpressionDefinition("SDE Ethnicity")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Ethnicity(CqlContext context) =>
        _SDE_Ethnicity_Cached.GetOrReplace(
            context,
            () =>
            {
                (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? a_ = SupplementalDataElements_5_1_000.Instance.SDE_Ethnicity(context);
                return a_;
            });


    private Cached<IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?>> _SDE_Payer_Cached = new();

    [CqlExpressionDefinition("SDE Payer")]
    public IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> SDE_Payer(CqlContext context) =>
        _SDE_Payer_Cached.GetOrReplace(
            context,
            () =>
            {
                IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> a_ = SupplementalDataElements_5_1_000.Instance.SDE_Payer(context);
                return a_;
            });


    private Cached<(CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)?> _SDE_Race_Cached = new();

    [CqlExpressionDefinition("SDE Race")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Race(CqlContext context) =>
        _SDE_Race_Cached.GetOrReplace(
            context,
            () =>
            {
                (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? a_ = SupplementalDataElements_5_1_000.Instance.SDE_Race(context);
                return a_;
            });


    private Cached<CqlCode> _SDE_Sex_Cached = new();

    [CqlExpressionDefinition("SDE Sex")]
    public CqlCode SDE_Sex(CqlContext context) =>
        _SDE_Sex_Cached.GetOrReplace(
            context,
            () =>
            {
                CqlCode a_ = SupplementalDataElements_5_1_000.Instance.SDE_Sex(context);
                return a_;
            });


    private Cached<IEnumerable<Encounter>> _Qualifying_Encounter_During_Measurement_Period_Cached = new();

    [CqlExpressionDefinition("Qualifying Encounter During Measurement Period")]
    public IEnumerable<Encounter> Qualifying_Encounter_During_Measurement_Period(CqlContext context) =>
        _Qualifying_Encounter_During_Measurement_Period_Cached.GetOrReplace(
            context,
            () =>
            {
                CqlValueSet a_ = this.Office_Visit(context);
                IEnumerable<Encounter> b_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
                CqlValueSet c_ = this.Ophthalmological_Services(context);
                IEnumerable<Encounter> d_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, c_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
                IEnumerable<Encounter> e_ = context.Operators.Union<Encounter>(b_, d_);
                CqlValueSet f_ = this.Outpatient_Consultation(context);
                IEnumerable<Encounter> g_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, f_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
                CqlValueSet h_ = this.Nursing_Facility_Visit(context);
                IEnumerable<Encounter> i_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, h_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
                IEnumerable<Encounter> j_ = context.Operators.Union<Encounter>(g_, i_);
                IEnumerable<Encounter> k_ = context.Operators.Union<Encounter>(e_, j_);
                CqlValueSet l_ = this.Care_Services_in_Long_Term_Residential_Facility(context);
                IEnumerable<Encounter> m_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, l_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
                IEnumerable<Encounter> n_ = context.Operators.Union<Encounter>(k_, m_);
                bool? o_(Encounter QualifyingEncounter)
                {
                    CqlInterval<CqlDateTime> q_ = this.Measurement_Period(context);
                    Period r_ = QualifyingEncounter?.Period;
                    CqlInterval<CqlDateTime> s_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, r_);
                    bool? t_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(q_, s_, "day");
                    Code<Encounter.EncounterStatus> u_ = QualifyingEncounter?.StatusElement;
                    Encounter.EncounterStatus? v_ = u_?.Value;
                    Code<Encounter.EncounterStatus> w_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(v_);
                    bool? x_ = context.Operators.Equal(w_, "finished");
                    bool? y_ = context.Operators.And(t_, x_);
                    Coding z_ = QualifyingEncounter?.Class;
                    CqlCode aa_ = FHIRHelpers_4_4_000.Instance.ToCode(context, z_);
                    CqlCode ab_ = this.@virtual(context);
                    bool? ac_ = context.Operators.Equivalent(aa_, ab_);
                    bool? ad_ = context.Operators.Not(ac_);
                    bool? ae_ = context.Operators.And(y_, ad_);
                    return ae_;
                };
                IEnumerable<Encounter> p_ = context.Operators.Where<Encounter>(n_, o_);
                return p_;
            });


    [CqlFunctionDefinition("isVerified")]
    public bool? isVerified(CqlContext context, object condition)
    {
        object a_ = context.Operators.LateBoundProperty<object>(condition, "verificationStatus");
        CqlConcept b_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, a_ as CodeableConcept);
        bool? c_ = context.Operators.Not((bool?)(b_ is null));
        CqlConcept e_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, a_ as CodeableConcept);
        CqlCode f_ = QICoreCommon_4_0_000.Instance.confirmed(context);
        CqlConcept g_ = context.Operators.ConvertCodeToConcept(f_);
        bool? h_ = context.Operators.Equivalent(e_, g_);
        CqlConcept j_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, a_ as CodeableConcept);
        CqlCode k_ = QICoreCommon_4_0_000.Instance.unconfirmed(context);
        CqlConcept l_ = context.Operators.ConvertCodeToConcept(k_);
        bool? m_ = context.Operators.Equivalent(j_, l_);
        bool? n_ = context.Operators.Or(h_, m_);
        CqlConcept p_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, a_ as CodeableConcept);
        CqlCode q_ = QICoreCommon_4_0_000.Instance.provisional(context);
        CqlConcept r_ = context.Operators.ConvertCodeToConcept(q_);
        bool? s_ = context.Operators.Equivalent(p_, r_);
        bool? t_ = context.Operators.Or(n_, s_);
        CqlConcept v_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, a_ as CodeableConcept);
        CqlCode w_ = QICoreCommon_4_0_000.Instance.differential(context);
        CqlConcept x_ = context.Operators.ConvertCodeToConcept(w_);
        bool? y_ = context.Operators.Equivalent(v_, x_);
        bool? z_ = context.Operators.Or(t_, y_);
        bool? aa_ = context.Operators.Implies(c_, z_);
        return aa_;
    }


    private Cached<IEnumerable<Encounter>> _Primary_Open_Angle_Glaucoma_Encounter_Cached = new();

    [CqlExpressionDefinition("Primary Open Angle Glaucoma Encounter")]
    public IEnumerable<Encounter> Primary_Open_Angle_Glaucoma_Encounter(CqlContext context) =>
        _Primary_Open_Angle_Glaucoma_Encounter_Cached.GetOrReplace(
            context,
            () =>
            {
                IEnumerable<Encounter> a_ = this.Qualifying_Encounter_During_Measurement_Period(context);
                IEnumerable<Encounter> b_(Encounter ValidQualifyingEncounter)
                {
                    CqlValueSet d_ = this.Primary_Open_Angle_Glaucoma(context);
                    IEnumerable<Condition> e_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, d_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-problems-health-concerns"));
                    IEnumerable<Condition> g_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, d_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-encounter-diagnosis"));
                    IEnumerable<object> h_ = context.Operators.Union<object>(e_ as IEnumerable<object>, g_ as IEnumerable<object>);
                    bool? i_(object PrimaryOpenAngleGlaucoma)
                    {
                        CqlInterval<CqlDateTime> m_ = QICoreCommon_4_0_000.Instance.prevalenceInterval(context, PrimaryOpenAngleGlaucoma);
                        Period n_ = ValidQualifyingEncounter?.Period;
                        CqlInterval<CqlDateTime> o_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, n_);
                        bool? p_ = context.Operators.Overlaps(m_, o_, "day");
                        bool? q_ = this.isVerified(context, PrimaryOpenAngleGlaucoma);
                        bool? r_ = context.Operators.And(p_, q_);
                        return r_;
                    };
                    IEnumerable<object> j_ = context.Operators.Where<object>(h_, i_);
                    Encounter k_(object PrimaryOpenAngleGlaucoma) =>
                    ValidQualifyingEncounter;
                    IEnumerable<Encounter> l_ = context.Operators.Select<object, Encounter>(j_, k_);
                    return l_;
                };
                IEnumerable<Encounter> c_ = context.Operators.SelectMany<Encounter, Encounter>(a_, b_);
                return c_;
            });


    private Cached<bool?> _Initial_Population_Cached = new();

    [CqlExpressionDefinition("Initial Population")]
    public bool? Initial_Population(CqlContext context) =>
        _Initial_Population_Cached.GetOrReplace(
            context,
            () =>
            {
                Patient a_ = this.Patient(context);
                Date b_ = a_?.BirthDateElement;
                string c_ = b_?.Value;
                CqlDate d_ = context.Operators.ConvertStringToDate(c_);
                CqlInterval<CqlDateTime> e_ = this.Measurement_Period(context);
                CqlDateTime f_ = context.Operators.Start(e_);
                CqlDate g_ = context.Operators.DateFrom(f_);
                int? h_ = context.Operators.CalculateAgeAt(d_, g_, "year");
                bool? i_ = context.Operators.GreaterOrEqual(h_, 18);
                IEnumerable<Encounter> j_ = this.Primary_Open_Angle_Glaucoma_Encounter(context);
                bool? k_ = context.Operators.Exists<Encounter>(j_);
                bool? l_ = context.Operators.And(i_, k_);
                return l_;
            });


    private Cached<bool?> _Denominator_Cached = new();

    [CqlExpressionDefinition("Denominator")]
    public bool? Denominator(CqlContext context) =>
        _Denominator_Cached.GetOrReplace(
            context,
            () =>
            {
                bool? a_ = this.Initial_Population(context);
                return a_;
            });


    private Cached<IEnumerable<Observation>> _Medical_Reason_for_Not_Performing_Cup_to_Disc_Ratio_Cached = new();

    [CqlExpressionDefinition("Medical Reason for Not Performing Cup to Disc Ratio")]
    public IEnumerable<Observation> Medical_Reason_for_Not_Performing_Cup_to_Disc_Ratio(CqlContext context) =>
        _Medical_Reason_for_Not_Performing_Cup_to_Disc_Ratio_Cached.GetOrReplace(
            context,
            () =>
            {
                CqlValueSet a_ = this.Cup_to_Disc_Ratio(context);
                IEnumerable<Observation> b_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observationcancelled"));
                IEnumerable<Observation> d_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observationcancelled"));
                IEnumerable<Observation> e_ = context.Operators.Union<Observation>(b_, d_);
                IEnumerable<Observation> f_(Observation CupToDiscExamNotPerformed)
                {
                    IEnumerable<Encounter> j_ = this.Primary_Open_Angle_Glaucoma_Encounter(context);
                    bool? k_(Encounter EncounterWithPOAG)
                    {
                        Instant o_ = CupToDiscExamNotPerformed?.IssuedElement;
                        DateTimeOffset? p_ = o_?.Value;
                        CqlDateTime q_ = context.Operators.Convert<CqlDateTime>(p_);
                        Period r_ = EncounterWithPOAG?.Period;
                        CqlInterval<CqlDateTime> s_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, r_);
                        bool? t_ = context.Operators.In<CqlDateTime>(q_, s_, "day");
                        return t_;
                    };
                    IEnumerable<Encounter> l_ = context.Operators.Where<Encounter>(j_, k_);
                    Observation m_(Encounter EncounterWithPOAG) =>
                    CupToDiscExamNotPerformed;
                    IEnumerable<Observation> n_ = context.Operators.Select<Encounter, Observation>(l_, m_);
                    return n_;
                };
                IEnumerable<Observation> g_ = context.Operators.SelectMany<Observation, Observation>(e_, f_);
                bool? h_(Observation CupToDiscExamNotPerformed)
                {
                    bool? u_(Extension @this)
                    {
                        FhirUri ac_ = @this?.UrlElement;
                        FhirString ad_ = context.Operators.Convert<FhirString>(ac_);
                        string ae_ = FHIRHelpers_4_4_000.Instance.ToString(context, ad_);
                        bool? af_ = context.Operators.Equal(ae_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-notDoneReason");
                        return af_;
                    };
                    IEnumerable<Extension> v_ = context.Operators.Where<Extension>((IEnumerable<Extension>)(CupToDiscExamNotPerformed is DomainResource
                        ? (CupToDiscExamNotPerformed as DomainResource).Extension
                        : default), u_);
                    object w_(Extension @this)
                    {
                        DataType ag_ = @this?.Value;
                        return ag_;
                    };
                    IEnumerable<object> x_ = context.Operators.Select<Extension, object>(v_, w_);
                    object y_ = context.Operators.SingletonFrom<object>(x_);
                    CqlConcept z_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, y_ as CodeableConcept);
                    CqlValueSet aa_ = this.Medical_Reason(context);
                    bool? ab_ = context.Operators.ConceptInValueSet(z_, aa_);
                    return ab_;
                };
                IEnumerable<Observation> i_ = context.Operators.Where<Observation>(g_, h_);
                return i_;
            });


    private Cached<IEnumerable<Observation>> _Medical_Reason_for_Not_Performing_Optic_Disc_Exam_Cached = new();

    [CqlExpressionDefinition("Medical Reason for Not Performing Optic Disc Exam")]
    public IEnumerable<Observation> Medical_Reason_for_Not_Performing_Optic_Disc_Exam(CqlContext context) =>
        _Medical_Reason_for_Not_Performing_Optic_Disc_Exam_Cached.GetOrReplace(
            context,
            () =>
            {
                CqlValueSet a_ = this.Optic_Disc_Exam_for_Structural_Abnormalities(context);
                IEnumerable<Observation> b_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observationcancelled"));
                IEnumerable<Observation> d_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observationcancelled"));
                IEnumerable<Observation> e_ = context.Operators.Union<Observation>(b_, d_);
                IEnumerable<Observation> f_(Observation OpticDiscExamNotPerformed)
                {
                    IEnumerable<Encounter> j_ = this.Primary_Open_Angle_Glaucoma_Encounter(context);
                    bool? k_(Encounter EncounterWithPOAG)
                    {
                        Instant o_ = OpticDiscExamNotPerformed?.IssuedElement;
                        DateTimeOffset? p_ = o_?.Value;
                        CqlDateTime q_ = context.Operators.Convert<CqlDateTime>(p_);
                        Period r_ = EncounterWithPOAG?.Period;
                        CqlInterval<CqlDateTime> s_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, r_);
                        bool? t_ = context.Operators.In<CqlDateTime>(q_, s_, "day");
                        return t_;
                    };
                    IEnumerable<Encounter> l_ = context.Operators.Where<Encounter>(j_, k_);
                    Observation m_(Encounter EncounterWithPOAG) =>
                    OpticDiscExamNotPerformed;
                    IEnumerable<Observation> n_ = context.Operators.Select<Encounter, Observation>(l_, m_);
                    return n_;
                };
                IEnumerable<Observation> g_ = context.Operators.SelectMany<Observation, Observation>(e_, f_);
                bool? h_(Observation OpticDiscExamNotPerformed)
                {
                    bool? u_(Extension @this)
                    {
                        FhirUri ac_ = @this?.UrlElement;
                        FhirString ad_ = context.Operators.Convert<FhirString>(ac_);
                        string ae_ = FHIRHelpers_4_4_000.Instance.ToString(context, ad_);
                        bool? af_ = context.Operators.Equal(ae_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-notDoneReason");
                        return af_;
                    };
                    IEnumerable<Extension> v_ = context.Operators.Where<Extension>((IEnumerable<Extension>)(OpticDiscExamNotPerformed is DomainResource
                        ? (OpticDiscExamNotPerformed as DomainResource).Extension
                        : default), u_);
                    object w_(Extension @this)
                    {
                        DataType ag_ = @this?.Value;
                        return ag_;
                    };
                    IEnumerable<object> x_ = context.Operators.Select<Extension, object>(v_, w_);
                    object y_ = context.Operators.SingletonFrom<object>(x_);
                    CqlConcept z_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, y_ as CodeableConcept);
                    CqlValueSet aa_ = this.Medical_Reason(context);
                    bool? ab_ = context.Operators.ConceptInValueSet(z_, aa_);
                    return ab_;
                };
                IEnumerable<Observation> i_ = context.Operators.Where<Observation>(g_, h_);
                return i_;
            });


    private Cached<bool?> _Denominator_Exceptions_Cached = new();

    [CqlExpressionDefinition("Denominator Exceptions")]
    public bool? Denominator_Exceptions(CqlContext context) =>
        _Denominator_Exceptions_Cached.GetOrReplace(
            context,
            () =>
            {
                IEnumerable<Observation> a_ = this.Medical_Reason_for_Not_Performing_Cup_to_Disc_Ratio(context);
                bool? b_ = context.Operators.Exists<Observation>(a_);
                IEnumerable<Observation> c_ = this.Medical_Reason_for_Not_Performing_Optic_Disc_Exam(context);
                bool? d_ = context.Operators.Exists<Observation>(c_);
                bool? e_ = context.Operators.Or(b_, d_);
                return e_;
            });


    private Cached<IEnumerable<Observation>> _Cup_to_Disc_Ratio_Performed_with_Result_Cached = new();

    [CqlExpressionDefinition("Cup to Disc Ratio Performed with Result")]
    public IEnumerable<Observation> Cup_to_Disc_Ratio_Performed_with_Result(CqlContext context) =>
        _Cup_to_Disc_Ratio_Performed_with_Result_Cached.GetOrReplace(
            context,
            () =>
            {
                CqlValueSet a_ = this.Cup_to_Disc_Ratio(context);
                IEnumerable<Observation> b_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation-clinical-result"));
                IEnumerable<Observation> c_(Observation CupToDiscExamPerformed)
                {
                    IEnumerable<Encounter> g_ = this.Primary_Open_Angle_Glaucoma_Encounter(context);
                    bool? h_(Encounter EncounterWithPOAG)
                    {
                        Period l_ = EncounterWithPOAG?.Period;
                        CqlInterval<CqlDateTime> m_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, l_);
                        DataType n_ = CupToDiscExamPerformed?.Effective;
                        object o_ = FHIRHelpers_4_4_000.Instance.ToValue(context, n_);
                        CqlInterval<CqlDateTime> p_ = QICoreCommon_4_0_000.Instance.toInterval(context, o_);
                        bool? q_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(m_, p_, "day");
                        return q_;
                    };
                    IEnumerable<Encounter> i_ = context.Operators.Where<Encounter>(g_, h_);
                    Observation j_(Encounter EncounterWithPOAG) =>
                    CupToDiscExamPerformed;
                    IEnumerable<Observation> k_ = context.Operators.Select<Encounter, Observation>(i_, j_);
                    return k_;
                };
                IEnumerable<Observation> d_ = context.Operators.SelectMany<Observation, Observation>(b_, c_);
                bool? e_(Observation CupToDiscExamPerformed)
                {
                    DataType r_ = CupToDiscExamPerformed?.Value;
                    object s_ = FHIRHelpers_4_4_000.Instance.ToValue(context, r_);
                    bool? t_ = context.Operators.Not((bool?)(s_ is null));
                    Code<ObservationStatus> u_ = CupToDiscExamPerformed?.StatusElement;
                    ObservationStatus? v_ = u_?.Value;
                    string w_ = context.Operators.Convert<string>(v_);
                    string[] x_ = [
                        "final",
                        "amended",
                        "corrected",
                    ];
                    bool? y_ = context.Operators.In<string>(w_, (IEnumerable<string>)x_);
                    bool? z_ = context.Operators.And(t_, y_);
                    return z_;
                };
                IEnumerable<Observation> f_ = context.Operators.Where<Observation>(d_, e_);
                return f_;
            });


    private Cached<IEnumerable<Observation>> _Optic_Disc_Exam_Performed_with_Result_Cached = new();

    [CqlExpressionDefinition("Optic Disc Exam Performed with Result")]
    public IEnumerable<Observation> Optic_Disc_Exam_Performed_with_Result(CqlContext context) =>
        _Optic_Disc_Exam_Performed_with_Result_Cached.GetOrReplace(
            context,
            () =>
            {
                CqlValueSet a_ = this.Optic_Disc_Exam_for_Structural_Abnormalities(context);
                IEnumerable<Observation> b_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation-clinical-result"));
                IEnumerable<Observation> c_(Observation OpticDiscExamPerformed)
                {
                    IEnumerable<Encounter> g_ = this.Primary_Open_Angle_Glaucoma_Encounter(context);
                    bool? h_(Encounter EncounterWithPOAG)
                    {
                        Period l_ = EncounterWithPOAG?.Period;
                        CqlInterval<CqlDateTime> m_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, l_);
                        DataType n_ = OpticDiscExamPerformed?.Effective;
                        object o_ = FHIRHelpers_4_4_000.Instance.ToValue(context, n_);
                        CqlInterval<CqlDateTime> p_ = QICoreCommon_4_0_000.Instance.toInterval(context, o_);
                        bool? q_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(m_, p_, "day");
                        return q_;
                    };
                    IEnumerable<Encounter> i_ = context.Operators.Where<Encounter>(g_, h_);
                    Observation j_(Encounter EncounterWithPOAG) =>
                    OpticDiscExamPerformed;
                    IEnumerable<Observation> k_ = context.Operators.Select<Encounter, Observation>(i_, j_);
                    return k_;
                };
                IEnumerable<Observation> d_ = context.Operators.SelectMany<Observation, Observation>(b_, c_);
                bool? e_(Observation OpticDiscExamPerformed)
                {
                    DataType r_ = OpticDiscExamPerformed?.Value;
                    object s_ = FHIRHelpers_4_4_000.Instance.ToValue(context, r_);
                    bool? t_ = context.Operators.Not((bool?)(s_ is null));
                    Code<ObservationStatus> u_ = OpticDiscExamPerformed?.StatusElement;
                    ObservationStatus? v_ = u_?.Value;
                    string w_ = context.Operators.Convert<string>(v_);
                    string[] x_ = [
                        "final",
                        "amended",
                        "corrected",
                    ];
                    bool? y_ = context.Operators.In<string>(w_, (IEnumerable<string>)x_);
                    bool? z_ = context.Operators.And(t_, y_);
                    return z_;
                };
                IEnumerable<Observation> f_ = context.Operators.Where<Observation>(d_, e_);
                return f_;
            });


    private Cached<bool?> _Numerator_Cached = new();

    [CqlExpressionDefinition("Numerator")]
    public bool? Numerator(CqlContext context) =>
        _Numerator_Cached.GetOrReplace(
            context,
            () =>
            {
                IEnumerable<Observation> a_ = this.Cup_to_Disc_Ratio_Performed_with_Result(context);
                bool? b_ = context.Operators.Exists<Observation>(a_);
                IEnumerable<Observation> c_ = this.Optic_Disc_Exam_Performed_with_Result(context);
                bool? d_ = context.Operators.Exists<Observation>(c_);
                bool? e_ = context.Operators.And(b_, d_);
                return e_;
            });


    #endregion Functions and Expressions

}

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
[CqlLibrary("DocumentationofCurrentMedicationsFHIR", "0.2.000")]
public partial class DocumentationofCurrentMedicationsFHIR_0_2_000 : ILibrary, ISingleton<DocumentationofCurrentMedicationsFHIR_0_2_000>
{
    private DocumentationofCurrentMedicationsFHIR_0_2_000() {}

    public static DocumentationofCurrentMedicationsFHIR_0_2_000 Instance { get; } = new();

    #region ILibrary Implementation

    public string Name => "DocumentationofCurrentMedicationsFHIR";
    public string Version => "0.2.000";
    public ILibrary[] Dependencies => [FHIRHelpers_4_3_000.Instance, QICoreCommon_2_0_000.Instance, SupplementalDataElements_3_4_000.Instance];

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

    [CqlValueSetDefinition("Encounter to Document Medications", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.600.1.1834", valueSetVersion: null)]
    public CqlValueSet Encounter_to_Document_Medications(CqlContext _) => _Encounter_to_Document_Medications;
    private static readonly CqlValueSet _Encounter_to_Document_Medications = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.600.1.1834", null);

    [CqlValueSetDefinition("Medical Reason", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1007", valueSetVersion: null)]
    public CqlValueSet Medical_Reason(CqlContext _) => _Medical_Reason;
    private static readonly CqlValueSet _Medical_Reason = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1007", null);

    #endregion ValueSets

    #region Codes

    [CqlCodeDefinition("Documentation of current medications (procedure)", codeId: "428191000124101", codeSystem: "http://snomed.info/sct")]
    public CqlCode Documentation_of_current_medications__procedure_(CqlContext _) => _Documentation_of_current_medications__procedure_;
    private static readonly CqlCode _Documentation_of_current_medications__procedure_ = new CqlCode("428191000124101", "http://snomed.info/sct");

    #endregion Codes

    #region CodeSystems

    [CqlCodeSystemDefinition("SNOMEDCT", codeSystemId: "http://snomed.info/sct", codeSystemVersion: null)]
    public CqlCodeSystem SNOMEDCT(CqlContext _) => _SNOMEDCT;
    private static readonly CqlCodeSystem _SNOMEDCT =
      new CqlCodeSystem("http://snomed.info/sct", null, [
          _Documentation_of_current_medications__procedure_]);

    #endregion CodeSystems

    #region Parameters

    private Cached<CqlInterval<CqlDateTime>> _Measurement_Period_Cached = new();

    [CqlParameterDefinition("Measurement Period")]
    public CqlInterval<CqlDateTime> Measurement_Period(CqlContext context) =>
        _Measurement_Period_Cached.GetOrReplace(
            context,
            () =>
            {
                CqlDateTime a_ = context.Operators.DateTime(2025, 1, 1, 0, 0, 0, 0, default);
                CqlDateTime b_ = context.Operators.DateTime(2026, 1, 1, 0, 0, 0, 0, default);
                CqlInterval<CqlDateTime> c_ = context.Operators.Interval(a_, b_, true, false);
                object d_ = context.ResolveParameter("DocumentationofCurrentMedicationsFHIR-0.2.000", "Measurement Period", c_);
                return (CqlInterval<CqlDateTime>)d_;
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
                (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? a_ = SupplementalDataElements_3_4_000.Instance.SDE_Ethnicity(context);
                return a_;
            });


    private Cached<IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?>> _SDE_Payer_Cached = new();

    [CqlExpressionDefinition("SDE Payer")]
    public IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> SDE_Payer(CqlContext context) =>
        _SDE_Payer_Cached.GetOrReplace(
            context,
            () =>
            {
                IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> a_ = SupplementalDataElements_3_4_000.Instance.SDE_Payer(context);
                return a_;
            });


    private Cached<(CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)?> _SDE_Race_Cached = new();

    [CqlExpressionDefinition("SDE Race")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Race(CqlContext context) =>
        _SDE_Race_Cached.GetOrReplace(
            context,
            () =>
            {
                (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? a_ = SupplementalDataElements_3_4_000.Instance.SDE_Race(context);
                return a_;
            });


    private Cached<CqlCode> _SDE_Sex_Cached = new();

    [CqlExpressionDefinition("SDE Sex")]
    public CqlCode SDE_Sex(CqlContext context) =>
        _SDE_Sex_Cached.GetOrReplace(
            context,
            () =>
            {
                CqlCode a_ = SupplementalDataElements_3_4_000.Instance.SDE_Sex(context);
                return a_;
            });


    private Cached<IEnumerable<Encounter>> _Qualifying_Encounter_during_day_of_Measurement_Period_Cached = new();

    [CqlExpressionDefinition("Qualifying Encounter during day of Measurement Period")]
    public IEnumerable<Encounter> Qualifying_Encounter_during_day_of_Measurement_Period(CqlContext context) =>
        _Qualifying_Encounter_during_day_of_Measurement_Period_Cached.GetOrReplace(
            context,
            () =>
            {
                CqlValueSet a_ = this.Encounter_to_Document_Medications(context);
                IEnumerable<Encounter> b_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
                bool? c_(Encounter ValidEncounter)
                {
                    Code<Encounter.EncounterStatus> e_ = ValidEncounter?.StatusElement;
                    Encounter.EncounterStatus? f_ = e_?.Value;
                    Code<Encounter.EncounterStatus> g_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(f_);
                    bool? h_ = context.Operators.Equal(g_, "finished");
                    CqlInterval<CqlDateTime> i_ = this.Measurement_Period(context);
                    Period j_ = ValidEncounter?.Period;
                    CqlInterval<CqlDateTime> k_ = FHIRHelpers_4_3_000.Instance.ToInterval(context, j_);
                    bool? l_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(i_, k_, "day");
                    bool? m_ = context.Operators.And(h_, l_);
                    return m_;
                };
                IEnumerable<Encounter> d_ = context.Operators.Where<Encounter>(b_, c_);
                return d_;
            });


    private Cached<IEnumerable<Encounter>> _Initial_Population_Cached = new();

    [CqlExpressionDefinition("Initial Population")]
    public IEnumerable<Encounter> Initial_Population(CqlContext context) =>
        _Initial_Population_Cached.GetOrReplace(
            context,
            () =>
            {
                IEnumerable<Encounter> a_ = this.Qualifying_Encounter_during_day_of_Measurement_Period(context);
                return a_;
            });


    private Cached<IEnumerable<Encounter>> _Denominator_Cached = new();

    [CqlExpressionDefinition("Denominator")]
    public IEnumerable<Encounter> Denominator(CqlContext context) =>
        _Denominator_Cached.GetOrReplace(
            context,
            () =>
            {
                IEnumerable<Encounter> a_ = this.Initial_Population(context);
                return a_;
            });


    private Cached<IEnumerable<Encounter>> _Numerator_Cached = new();

    [CqlExpressionDefinition("Numerator")]
    public IEnumerable<Encounter> Numerator(CqlContext context) =>
        _Numerator_Cached.GetOrReplace(
            context,
            () =>
            {
                IEnumerable<Encounter> a_ = this.Qualifying_Encounter_during_day_of_Measurement_Period(context);
                IEnumerable<Encounter> b_(Encounter QualifyingEncounter)
                {
                    CqlCode d_ = this.Documentation_of_current_medications__procedure_(context);
                    IEnumerable<CqlCode> e_ = context.Operators.ToList<CqlCode>(d_);
                    IEnumerable<Procedure> f_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, default, e_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
                    bool? g_(Procedure MedicationsDocumented)
                    {
                        DataType k_ = MedicationsDocumented?.Performed;
                        object l_ = FHIRHelpers_4_3_000.Instance.ToValue(context, k_);
                        CqlInterval<CqlDateTime> m_ = QICoreCommon_2_0_000.Instance.toInterval(context, l_);
                        CqlDateTime n_ = context.Operators.End(m_);
                        Period o_ = QualifyingEncounter?.Period;
                        CqlInterval<CqlDateTime> p_ = FHIRHelpers_4_3_000.Instance.ToInterval(context, o_);
                        bool? q_ = context.Operators.In<CqlDateTime>(n_, p_, default);
                        Code<EventStatus> r_ = MedicationsDocumented?.StatusElement;
                        EventStatus? s_ = r_?.Value;
                        string t_ = context.Operators.Convert<string>(s_);
                        bool? u_ = context.Operators.Equal(t_, "completed");
                        bool? v_ = context.Operators.And(q_, u_);
                        return v_;
                    };
                    IEnumerable<Procedure> h_ = context.Operators.Where<Procedure>(f_, g_);
                    Encounter i_(Procedure MedicationsDocumented) =>
                    QualifyingEncounter;
                    IEnumerable<Encounter> j_ = context.Operators.Select<Procedure, Encounter>(h_, i_);
                    return j_;
                };
                IEnumerable<Encounter> c_ = context.Operators.SelectMany<Encounter, Encounter>(a_, b_);
                return c_;
            });


    private Cached<IEnumerable<Encounter>> _Denominator_Exceptions_Cached = new();

    [CqlExpressionDefinition("Denominator Exceptions")]
    public IEnumerable<Encounter> Denominator_Exceptions(CqlContext context) =>
        _Denominator_Exceptions_Cached.GetOrReplace(
            context,
            () =>
            {
                IEnumerable<Encounter> a_ = this.Qualifying_Encounter_during_day_of_Measurement_Period(context);
                IEnumerable<Encounter> b_(Encounter QualifyingEncounter)
                {
                    CqlCode d_ = this.Documentation_of_current_medications__procedure_(context);
                    IEnumerable<CqlCode> e_ = context.Operators.ToList<CqlCode>(d_);
                    IEnumerable<Procedure> f_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, default, e_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedurenotdone"));
                    bool? g_(Procedure MedicationsNotDocumented)
                    {
                        bool? k_(Extension @this)
                        {
                            FhirUri af_ = @this?.UrlElement;
                            FhirString ag_ = context.Operators.Convert<FhirString>(af_);
                            string ah_ = FHIRHelpers_4_3_000.Instance.ToString(context, ag_);
                            bool? ai_ = context.Operators.Equal(ah_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-recorded");
                            return ai_;
                        };
                        IEnumerable<Extension> l_ = context.Operators.Where<Extension>((IEnumerable<Extension>)(MedicationsNotDocumented is DomainResource
                            ? (MedicationsNotDocumented as DomainResource).Extension
                            : default), k_);
                        DataType m_(Extension @this)
                        {
                            DataType aj_ = @this?.Value;
                            return aj_;
                        };
                        IEnumerable<DataType> n_ = context.Operators.Select<Extension, DataType>(l_, m_);
                        DataType o_ = context.Operators.SingletonFrom<DataType>(n_);
                        FhirDateTime p_ = context.Operators.Convert<FhirDateTime>(o_);
                        CqlDateTime q_ = context.Operators.Convert<CqlDateTime>(p_);
                        Period r_ = QualifyingEncounter?.Period;
                        CqlInterval<CqlDateTime> s_ = FHIRHelpers_4_3_000.Instance.ToInterval(context, r_);
                        bool? t_ = context.Operators.In<CqlDateTime>(q_, s_, default);
                        Code<EventStatus> u_ = MedicationsNotDocumented?.StatusElement;
                        EventStatus? v_ = u_?.Value;
                        string w_ = context.Operators.Convert<string>(v_);
                        bool? x_ = context.Operators.Equal(w_, "not-done");
                        bool? y_ = context.Operators.And(t_, x_);
                        List<CodeableConcept> z_ = MedicationsNotDocumented?.ReasonCode;
                        CqlConcept aa_(CodeableConcept @this)
                        {
                            CqlConcept ak_ = FHIRHelpers_4_3_000.Instance.ToConcept(context, @this);
                            return ak_;
                        };
                        IEnumerable<CqlConcept> ab_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)z_, aa_);
                        CqlValueSet ac_ = this.Medical_Reason(context);
                        bool? ad_ = context.Operators.ConceptsInValueSet(ab_, ac_);
                        bool? ae_ = context.Operators.And(y_, ad_);
                        return ae_;
                    };
                    IEnumerable<Procedure> h_ = context.Operators.Where<Procedure>(f_, g_);
                    Encounter i_(Procedure MedicationsNotDocumented) =>
                    QualifyingEncounter;
                    IEnumerable<Encounter> j_ = context.Operators.Select<Procedure, Encounter>(h_, i_);
                    return j_;
                };
                IEnumerable<Encounter> c_ = context.Operators.SelectMany<Encounter, Encounter>(a_, b_);
                return c_;
            });


    #endregion Functions and Expressions

}

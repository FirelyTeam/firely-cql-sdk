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
[CqlLibrary("DocumentationofCurrentMedicationsFHIR", "0.2.000")]
public partial class DocumentationofCurrentMedicationsFHIR_0_2_000 : ILibrary, ILibraryInternals, ISingleton<DocumentationofCurrentMedicationsFHIR_0_2_000>
{
    #region ValueSets (2)

    [CqlValueSetDefinition("Encounter to Document Medications", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.600.1.1834", valueSetVersion: null)]
    public CqlValueSet Encounter_to_Document_Medications(CqlContext _) => _Encounter_to_Document_Medications;
    private static readonly CqlValueSet _Encounter_to_Document_Medications = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.600.1.1834", null);

    [CqlValueSetDefinition("Medical Reason", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1007", valueSetVersion: null)]
    public CqlValueSet Medical_Reason(CqlContext _) => _Medical_Reason;
    private static readonly CqlValueSet _Medical_Reason = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1007", null);

    #endregion ValueSets

    #region Codes (1)

    [CqlCodeDefinition("Documentation of current medications (procedure)", codeId: "428191000124101", codeSystem: "http://snomed.info/sct")]
    public CqlCode Documentation_of_current_medications__procedure_(CqlContext _) => _Documentation_of_current_medications__procedure_;
    private static readonly CqlCode _Documentation_of_current_medications__procedure_ = new CqlCode("428191000124101", "http://snomed.info/sct");

    #endregion Codes

    #region CodeSystems (1)

    [CqlCodeSystemDefinition("SNOMEDCT", codeSystemId: "http://snomed.info/sct", codeSystemVersion: null)]
    public CqlCodeSystem SNOMEDCT(CqlContext _) => _SNOMEDCT;
    private static readonly CqlCodeSystem _SNOMEDCT =
      new CqlCodeSystem("http://snomed.info/sct", null, [
          _Documentation_of_current_medications__procedure_]);

    #endregion CodeSystems

    #region Parameters (1)

    [CqlParameterDefinition("Measurement Period")]
    public CqlInterval<CqlDateTime> Measurement_Period(CqlContext context) =>
        _cache?.GetOrCompute(_cacheIndex_Measurement_Period, Measurement_Period_Compute, context) ?? Measurement_Period_Compute(context);

    private CqlInterval<CqlDateTime> Measurement_Period_Compute(CqlContext context)
    {
        CqlDateTime a_ = context.Operators.DateTime(2025, 1, 1, 0, 0, 0, 0, default);
        CqlDateTime b_ = context.Operators.DateTime(2026, 1, 1, 0, 0, 0, 0, default);
        CqlInterval<CqlDateTime> c_ = context.Operators.Interval(a_, b_, true, false);
        object d_ = context.ResolveParameter("DocumentationofCurrentMedicationsFHIR-0.2.000", "Measurement Period", c_);
        return (CqlInterval<CqlDateTime>)d_;
    }


    #endregion Parameters

    #region Functions and Expressions (10)

    [CqlExpressionDefinition("Patient")]
    public Patient Patient(CqlContext context) =>
        _cache?.GetOrCompute(_cacheIndex_Patient, Patient_Compute, context) ?? Patient_Compute(context);

    private Patient Patient_Compute(CqlContext context)
    {
        IEnumerable<Patient> a_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-patient"));
        Patient b_ = context.Operators.SingletonFrom<Patient>(a_);
        return b_;
    }


    [CqlExpressionDefinition("SDE Ethnicity")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Ethnicity(CqlContext context) =>
        _cache?.GetOrCompute(_cacheIndex_SDE_Ethnicity, SDE_Ethnicity_Compute, context) ?? SDE_Ethnicity_Compute(context);

    private (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Ethnicity_Compute(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? a_ = SupplementalDataElements_3_4_000.Instance.SDE_Ethnicity(context);
        return a_;
    }


    [CqlExpressionDefinition("SDE Payer")]
    public IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> SDE_Payer(CqlContext context) =>
        _cache?.GetOrCompute(_cacheIndex_SDE_Payer, SDE_Payer_Compute, context) ?? SDE_Payer_Compute(context);

    private IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> SDE_Payer_Compute(CqlContext context)
    {
        IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> a_ = SupplementalDataElements_3_4_000.Instance.SDE_Payer(context);
        return a_;
    }


    [CqlExpressionDefinition("SDE Race")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Race(CqlContext context) =>
        _cache?.GetOrCompute(_cacheIndex_SDE_Race, SDE_Race_Compute, context) ?? SDE_Race_Compute(context);

    private (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Race_Compute(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? a_ = SupplementalDataElements_3_4_000.Instance.SDE_Race(context);
        return a_;
    }


    [CqlExpressionDefinition("SDE Sex")]
    public CqlCode SDE_Sex(CqlContext context) =>
        _cache?.GetOrCompute(_cacheIndex_SDE_Sex, SDE_Sex_Compute, context) ?? SDE_Sex_Compute(context);

    private CqlCode SDE_Sex_Compute(CqlContext context)
    {
        CqlCode a_ = SupplementalDataElements_3_4_000.Instance.SDE_Sex(context);
        return a_;
    }


    [CqlExpressionDefinition("Qualifying Encounter during day of Measurement Period")]
    public IEnumerable<Encounter> Qualifying_Encounter_during_day_of_Measurement_Period(CqlContext context) =>
        _cache?.GetOrCompute(_cacheIndex_Qualifying_Encounter_during_day_of_Measurement_Period, Qualifying_Encounter_during_day_of_Measurement_Period_Compute, context) ?? Qualifying_Encounter_during_day_of_Measurement_Period_Compute(context);

    private IEnumerable<Encounter> Qualifying_Encounter_during_day_of_Measurement_Period_Compute(CqlContext context)
    {
        CqlValueSet a_ = this.Encounter_to_Document_Medications(context);
        IEnumerable<Encounter> b_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));

        bool? c_(Encounter ValidEncounter) {
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
        }

        IEnumerable<Encounter> d_ = context.Operators.Where<Encounter>(b_, c_);
        return d_;
    }


    [CqlExpressionDefinition("Initial Population")]
    public IEnumerable<Encounter> Initial_Population(CqlContext context) =>
        _cache?.GetOrCompute(_cacheIndex_Initial_Population, Initial_Population_Compute, context) ?? Initial_Population_Compute(context);

    private IEnumerable<Encounter> Initial_Population_Compute(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Qualifying_Encounter_during_day_of_Measurement_Period(context);
        return a_;
    }


    [CqlExpressionDefinition("Denominator")]
    public IEnumerable<Encounter> Denominator(CqlContext context) =>
        _cache?.GetOrCompute(_cacheIndex_Denominator, Denominator_Compute, context) ?? Denominator_Compute(context);

    private IEnumerable<Encounter> Denominator_Compute(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Initial_Population(context);
        return a_;
    }


    [CqlExpressionDefinition("Numerator")]
    public IEnumerable<Encounter> Numerator(CqlContext context) =>
        _cache?.GetOrCompute(_cacheIndex_Numerator, Numerator_Compute, context) ?? Numerator_Compute(context);

    private IEnumerable<Encounter> Numerator_Compute(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Qualifying_Encounter_during_day_of_Measurement_Period(context);

        IEnumerable<Encounter> b_(Encounter QualifyingEncounter) {
            CqlCode d_ = this.Documentation_of_current_medications__procedure_(context);
            IEnumerable<CqlCode> e_ = context.Operators.ToList<CqlCode>(d_);
            IEnumerable<Procedure> f_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, default, e_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));

            bool? g_(Procedure MedicationsDocumented) {
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
            }

            IEnumerable<Procedure> h_ = context.Operators.Where<Procedure>(f_, g_);
            Encounter i_(Procedure MedicationsDocumented) => QualifyingEncounter;
            IEnumerable<Encounter> j_ = context.Operators.Select<Procedure, Encounter>(h_, i_);
            return j_;
        }

        IEnumerable<Encounter> c_ = context.Operators.SelectMany<Encounter, Encounter>(a_, b_);
        return c_;
    }


    [CqlExpressionDefinition("Denominator Exceptions")]
    public IEnumerable<Encounter> Denominator_Exceptions(CqlContext context) =>
        _cache?.GetOrCompute(_cacheIndex_Denominator_Exceptions, Denominator_Exceptions_Compute, context) ?? Denominator_Exceptions_Compute(context);

    private IEnumerable<Encounter> Denominator_Exceptions_Compute(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Qualifying_Encounter_during_day_of_Measurement_Period(context);

        IEnumerable<Encounter> b_(Encounter QualifyingEncounter) {
            CqlCode d_ = this.Documentation_of_current_medications__procedure_(context);
            IEnumerable<CqlCode> e_ = context.Operators.ToList<CqlCode>(d_);
            IEnumerable<Procedure> f_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, default, e_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedurenotdone"));

            bool? g_(Procedure MedicationsNotDocumented) {

                bool? k_(Extension @this) {
                    FhirUri af_ = @this?.UrlElement;
                    string ag_ = FHIRHelpers_4_3_000.Instance.ToString(context, af_);
                    bool? ah_ = context.Operators.Equal(ag_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-recorded");
                    return ah_;
                }

                IEnumerable<Extension> l_ = context.Operators.Where<Extension>((IEnumerable<Extension>)(MedicationsNotDocumented is DomainResource
                    ? (MedicationsNotDocumented as DomainResource).Extension
                    : default), k_);

                DataType m_(Extension @this) {
                    DataType ai_ = @this?.Value;
                    return ai_;
                }

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

                CqlConcept aa_(CodeableConcept @this) {
                    CqlConcept aj_ = FHIRHelpers_4_3_000.Instance.ToConcept(context, @this);
                    return aj_;
                }

                IEnumerable<CqlConcept> ab_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)z_, aa_);
                CqlValueSet ac_ = this.Medical_Reason(context);
                bool? ad_ = context.Operators.ConceptsInValueSet(ab_, ac_);
                bool? ae_ = context.Operators.And(y_, ad_);
                return ae_;
            }

            IEnumerable<Procedure> h_ = context.Operators.Where<Procedure>(f_, g_);
            Encounter i_(Procedure MedicationsNotDocumented) => QualifyingEncounter;
            IEnumerable<Encounter> j_ = context.Operators.Select<Procedure, Encounter>(h_, i_);
            return j_;
        }

        IEnumerable<Encounter> c_ = context.Operators.SelectMany<Encounter, Encounter>(a_, b_);
        return c_;
    }


    #endregion Functions and Expressions

    #region Cache Index Fields (11)

    private int _cacheIndex_Measurement_Period = -1;
    private int _cacheIndex_Patient = -1;
    private int _cacheIndex_SDE_Ethnicity = -1;
    private int _cacheIndex_SDE_Payer = -1;
    private int _cacheIndex_SDE_Race = -1;
    private int _cacheIndex_SDE_Sex = -1;
    private int _cacheIndex_Qualifying_Encounter_during_day_of_Measurement_Period = -1;
    private int _cacheIndex_Initial_Population = -1;
    private int _cacheIndex_Denominator = -1;
    private int _cacheIndex_Numerator = -1;
    private int _cacheIndex_Denominator_Exceptions = -1;

    #endregion Cache Index Fields

    #region ILibraryInternals Implementation

    // Reference to the execution cache instance that initialized this library
    private CqlLibrarySetInvocationCache _cache;

    /// <summary>
    /// Initializes cache indices for this library's cached expressions.
    /// </summary>
    /// <param name="cache">The execution cache instance performing initialization.</param>
    /// <param name="startIndex">The starting index for cache field assignment.</param>
    /// <returns>The number of cache indices initialized (number of cached expressions in this library).</returns>
    int ILibraryInternals.InitializeCacheIndices(
        CqlLibrarySetInvocationCache cache,
        int startIndex)
    {
        // Skip if already initialized by this cache instance (allows re-initialization with different cache)
        if (_cache == cache)
            return 0;

        _cache = cache;

        var index = startIndex;
        _cacheIndex_Measurement_Period = index++;
        _cacheIndex_Patient = index++;
        _cacheIndex_SDE_Ethnicity = index++;
        _cacheIndex_SDE_Payer = index++;
        _cacheIndex_SDE_Race = index++;
        _cacheIndex_SDE_Sex = index++;
        _cacheIndex_Qualifying_Encounter_during_day_of_Measurement_Period = index++;
        _cacheIndex_Initial_Population = index++;
        _cacheIndex_Denominator = index++;
        _cacheIndex_Numerator = index++;
        _cacheIndex_Denominator_Exceptions = index++;
        return index - startIndex;
    }

    #endregion ILibraryInternals Implementation

    #region Singleton Lifetime Members

    private DocumentationofCurrentMedicationsFHIR_0_2_000() {}

    public static DocumentationofCurrentMedicationsFHIR_0_2_000 Instance { get; } = new();

    #endregion

    #region ILibrary Implementation

    public string Name => "DocumentationofCurrentMedicationsFHIR";
    public string Version => "0.2.000";
    public ILibrary[] Dependencies => [FHIRHelpers_4_3_000.Instance, QICoreCommon_2_0_000.Instance, SupplementalDataElements_3_4_000.Instance];

    #endregion ILibrary Implementation

}

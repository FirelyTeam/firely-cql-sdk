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
[CqlLibrary("MultipleResourcesExample", "0.0.1")]
public partial class MultipleResourcesExample_0_0_1 : ILibrary, ISingleton<MultipleResourcesExample_0_0_1>
{
    private MultipleResourcesExample_0_0_1() {}

    public static MultipleResourcesExample_0_0_1 Instance { get; } = new();

    #region ILibrary Implementation

    public string Name => "MultipleResourcesExample";
    public string Version => "0.0.1";
    public ILibrary[] Dependencies => [FHIRHelpers_4_3_000.Instance];

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

    [CqlValueSetDefinition("Lung Cancer", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1116.89", valueSetVersion: null)]
    public CqlValueSet Lung_Cancer(CqlContext _) => _Lung_Cancer;
    private static readonly CqlValueSet _Lung_Cancer = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1116.89", null);

    [CqlValueSetDefinition("Condition Clinical Status", valueSetId: "http://utah.edu/fhir/lcs-cds/ValueSet/conditionclinical", valueSetVersion: null)]
    public CqlValueSet Condition_Clinical_Status(CqlContext _) => _Condition_Clinical_Status;
    private static readonly CqlValueSet _Condition_Clinical_Status = new CqlValueSet("http://utah.edu/fhir/lcs-cds/ValueSet/conditionclinical", null);

    #endregion ValueSets

    #region Codes

    [CqlCodeDefinition("Tobacco Smoking Status", codeId: "72166-2", codeSystem: "http://loinc.org")]
    public CqlCode Tobacco_Smoking_Status(CqlContext _) => _Tobacco_Smoking_Status;
    private static readonly CqlCode _Tobacco_Smoking_Status = new CqlCode("72166-2", "http://loinc.org");

    #endregion Codes

    #region CodeSystems

    [CqlCodeSystemDefinition("LOINC", codeSystemId: "http://loinc.org", codeSystemVersion: null)]
    public CqlCodeSystem LOINC(CqlContext _) => _LOINC;
    private static readonly CqlCodeSystem _LOINC =
      new CqlCodeSystem("http://loinc.org", null, [
          _Tobacco_Smoking_Status]);

    #endregion CodeSystems

    #region Functions and Expressions

    private Cached<Patient> _Patient_Cached = new();

    [CqlExpressionDefinition("Patient")]
    public Patient Patient(CqlContext context) =>
        _Patient_Cached.GetOrReplace(
            context,
            () =>
            {
                IEnumerable<Patient> a_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/StructureDefinition/Patient"));
                Patient b_ = context.Operators.SingletonFrom<Patient>(a_);
                return b_;
            });


    private Cached<IEnumerable<Observation>> _Smoking_status_observation_Cached = new();

    [CqlExpressionDefinition("Smoking status observation")]
    public IEnumerable<Observation> Smoking_status_observation(CqlContext context) =>
        _Smoking_status_observation_Cached.GetOrReplace(
            context,
            () =>
            {
                CqlCode a_ = this.Tobacco_Smoking_Status(context);
                IEnumerable<CqlCode> b_ = context.Operators.ToList<CqlCode>(a_);
                IEnumerable<Observation> c_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, b_, "http://hl7.org/fhir/StructureDefinition/Observation"));
                bool? d_(Observation O)
                {
                    Code<ObservationStatus> f_ = O?.StatusElement;
                    string g_ = FHIRHelpers_4_3_000.Instance.ToString(context, f_);
                    string[] h_ = [
                        "final",
                        "amended",
                    ];
                    bool? i_ = context.Operators.In<string>(g_, (IEnumerable<string>)h_);
                    return i_;
                };
                IEnumerable<Observation> e_ = context.Operators.Where<Observation>(c_, d_);
                return e_;
            });


    private Cached<IEnumerable<Condition>> _Lung_cancer_diagnosis_Cached = new();

    [CqlExpressionDefinition("Lung cancer diagnosis")]
    public IEnumerable<Condition> Lung_cancer_diagnosis(CqlContext context) =>
        _Lung_cancer_diagnosis_Cached.GetOrReplace(
            context,
            () =>
            {
                CqlValueSet a_ = this.Lung_Cancer(context);
                IEnumerable<Condition> b_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/StructureDefinition/Condition"));
                bool? c_(Condition C)
                {
                    CodeableConcept e_ = C?.ClinicalStatus;
                    CqlConcept f_ = FHIRHelpers_4_3_000.Instance.ToConcept(context, e_);
                    CqlValueSet g_ = this.Condition_Clinical_Status(context);
                    bool? h_ = context.Operators.ConceptInValueSet(f_, g_);
                    return h_;
                };
                IEnumerable<Condition> d_ = context.Operators.Where<Condition>(b_, c_);
                return d_;
            });


    #endregion Functions and Expressions

}

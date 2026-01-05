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

[System.CodeDom.Compiler.GeneratedCode(".NET Code Generation", "4.0.0.0")]
[CqlLibrary("ConceptDefTest", "1.0.0")]
public partial class ConceptDefTest_1_0_0 : ILibrary, ISingleton<ConceptDefTest_1_0_0>
{
    #region Codes

    [CqlCodeDefinition("Diabetes Mellitus", codeId: "44054006", codeSystem: "http://snomed.info/sct")]
    public CqlCode Diabetes_Mellitus(CqlContext _) => _Diabetes_Mellitus;
    private static readonly CqlCode _Diabetes_Mellitus = new CqlCode("44054006", "http://snomed.info/sct");

    [CqlCodeDefinition("Hypertension Example", codeId: "38341003", codeSystem: "http://snomed.info/sct")]
    public CqlCode Hypertension_Example(CqlContext _) => _Hypertension_Example;
    private static readonly CqlCode _Hypertension_Example = new CqlCode("38341003", "http://snomed.info/sct");

    [CqlCodeDefinition("Medication Example", codeId: "763158003", codeSystem: "http://snomed.info/sct")]
    public CqlCode Medication_Example(CqlContext _) => _Medication_Example;
    private static readonly CqlCode _Medication_Example = new CqlCode("763158003", "http://snomed.info/sct");

    #endregion Codes

    #region CodeSystems

    [CqlCodeSystemDefinition("SNOMED", codeSystemId: "http://snomed.info/sct", codeSystemVersion: null)]
    public CqlCodeSystem SNOMED(CqlContext _) => _SNOMED;
    private static readonly CqlCodeSystem _SNOMED =
      new CqlCodeSystem("http://snomed.info/sct", null, [
          _Diabetes_Mellitus,
          _Hypertension_Example,
          _Medication_Example]);

    #endregion CodeSystems

    #region Concepts

    [CqlConceptDefinition("Diabetes")]
    public CqlConcept Diabetes(CqlContext _) => _Diabetes;
    private static readonly CqlConcept _Diabetes =
      new CqlConcept([
          _Diabetes_Mellitus],
          null);

    [CqlConceptDefinition("Hypertension")]
    public CqlConcept Hypertension(CqlContext _) => _Hypertension;
    private static readonly CqlConcept _Hypertension =
      new CqlConcept([
          _Hypertension_Example],
          null);

    [CqlConceptDefinition("Medication")]
    public CqlConcept Medication(CqlContext _) => _Medication;
    private static readonly CqlConcept _Medication =
      new CqlConcept([
          _Medication_Example],
          null);

    #endregion Concepts

    #region Functions and Expressions

    private readonly Cached<Patient> _Patient_Cached = new();

    [CqlExpressionDefinition("Patient")]
    public Patient Patient(CqlContext context) =>
        _Patient_Cached.GetOrReplace(
            context,
            () => {
                IEnumerable<Patient> a_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/StructureDefinition/Patient"));
                Patient b_ = context.Operators.SingletonFrom<Patient>(a_);
                return b_;
            });


    #endregion Functions and Expressions

    private ConceptDefTest_1_0_0() {}

    public static ConceptDefTest_1_0_0 Instance { get; } = new();

    #region ILibrary Implementation

    public string Name => "ConceptDefTest";
    public string Version => "1.0.0";
    public ILibrary[] Dependencies => [FHIRHelpers_4_0_1.Instance];

    #endregion ILibrary Implementation

    #region Nested Type - Cached<T>

    private struct Cached<T>(long CacheVersion, T CachedValue)
    {
        public T GetOrReplace(ICqlContextInternals cqlContext, Func<T> factory)
        {
            var cqlContextCacheVersion = cqlContext.CacheVersion;
            if (cqlContextCacheVersion is 0)
            {
                // No caching, clear out previous values
                CacheVersion = 0;
                CachedValue = default;
                var value = factory();
                return value;
            }

            if (CacheVersion == cqlContextCacheVersion)
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

}

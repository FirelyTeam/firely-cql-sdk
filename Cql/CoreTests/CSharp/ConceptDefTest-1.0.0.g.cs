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
[CqlLibrary("ConceptDefTest", "1.0.0")]
public partial class ConceptDefTest_1_0_0 : ILibrary, ILibraryInternals, ISingleton<ConceptDefTest_1_0_0>
{
    #region Codes (3)

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

    #region CodeSystems (1)

    [CqlCodeSystemDefinition("SNOMED", codeSystemId: "http://snomed.info/sct", codeSystemVersion: null)]
    public CqlCodeSystem SNOMED(CqlContext _) => _SNOMED;
    private static readonly CqlCodeSystem _SNOMED =
      new CqlCodeSystem("http://snomed.info/sct", null, [
          _Diabetes_Mellitus,
          _Hypertension_Example,
          _Medication_Example]);

    #endregion CodeSystems

    #region Concepts (3)

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

    #region Functions and Expressions (1)

    [CqlExpressionDefinition("Patient")]
    public Patient Patient(CqlContext context) =>
        _cache?.GetOrCompute(_cacheIndex_Patient, Patient_Compute, context) ?? Patient_Compute(context);

    private Patient Patient_Compute(CqlContext context)
    {
        IEnumerable<Patient> a_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/StructureDefinition/Patient"));
        Patient b_ = context.Operators.SingletonFrom<Patient>(a_);
        return b_;
    }


    #endregion Functions and Expressions

    #region Cache Index Fields (1)

    private int _cacheIndex_Patient = -1;

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
        _cacheIndex_Patient = index++;
        return index - startIndex;
    }

    #endregion ILibraryInternals Implementation

    #region Singleton Lifetime Members

    private ConceptDefTest_1_0_0() {}

    public static ConceptDefTest_1_0_0 Instance { get; } = new();

    #endregion

    #region ILibrary Implementation

    public string Name => "ConceptDefTest";
    public string Version => "1.0.0";
    public ILibrary[] Dependencies => [FHIRHelpers_4_0_1.Instance];

    #endregion ILibrary Implementation

}

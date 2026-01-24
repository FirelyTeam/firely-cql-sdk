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
[CqlLibrary("MeasureExample", "0.0.1")]
public partial class MeasureExample_0_0_1 : ILibrary, ILibraryInternals, ISingleton<MeasureExample_0_0_1>
{
    #region Functions and Expressions (6)

    [CqlExpressionDefinition("Patient")]
    public Patient Patient(CqlContext context) =>
        ((ICqlContextInternals)context).GetOrCompute(_cacheIndex_Patient, Patient_Compute);

    private Patient Patient_Compute(CqlContext context)
    {
        IEnumerable<Patient> a_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/StructureDefinition/Patient"));
        Patient b_ = context.Operators.SingletonFrom<Patient>(a_);
        return b_;
    }


    [CqlExpressionDefinition("Initial population")]
    [CqlTag("measure", "Measure Resource Example")]
    [CqlTag("year", "2024")]
    [CqlTag("domain", "Testing Measures")]
    [CqlTag("group", "1")]
    [CqlTag("group", "2")]
    [CqlTag("population", "initial-population")]
    [CqlTag("description", "Patients in the IP")]
    public bool? Initial_population(CqlContext context) =>
        ((ICqlContextInternals)context).GetOrCompute(_cacheIndex_Initial_population, Initial_population_Compute);

    private bool? Initial_population_Compute(CqlContext context)
    {
        return true;
    }


    [CqlExpressionDefinition("Exclusion")]
    [CqlTag("group", "1")]
    [CqlTag("group", "2")]
    [CqlTag("population", "denominator-exclusion")]
    public bool? Exclusion(CqlContext context) =>
        ((ICqlContextInternals)context).GetOrCompute(_cacheIndex_Exclusion, Exclusion_Compute);

    private bool? Exclusion_Compute(CqlContext context)
    {
        return false;
    }


    [CqlExpressionDefinition("Denominator")]
    [CqlTag("group", "1")]
    [CqlTag("group", "2")]
    [CqlTag("population", "denominator")]
    public bool? Denominator(CqlContext context) =>
        ((ICqlContextInternals)context).GetOrCompute(_cacheIndex_Denominator, Denominator_Compute);

    private bool? Denominator_Compute(CqlContext context)
    {
        bool? a_ = this.Initial_population(context);
        bool? b_ = this.Exclusion(context);
        bool? c_ = context.Operators.Not(b_);
        bool? d_ = context.Operators.And(a_, c_);
        return d_;
    }


    [CqlExpressionDefinition("Numerator 1")]
    [CqlTag("group", "1")]
    [CqlTag("population", "numerator")]
    public bool? Numerator_1(CqlContext context) =>
        ((ICqlContextInternals)context).GetOrCompute(_cacheIndex_Numerator_1, Numerator_1_Compute);

    private bool? Numerator_1_Compute(CqlContext context)
    {
        return true;
    }


    [CqlExpressionDefinition("Numerator 2")]
    [CqlTag("group", "2")]
    [CqlTag("population", "numerator")]
    public bool? Numerator_2(CqlContext context) =>
        ((ICqlContextInternals)context).GetOrCompute(_cacheIndex_Numerator_2, Numerator_2_Compute);

    private bool? Numerator_2_Compute(CqlContext context)
    {
        return false;
    }


    #endregion Functions and Expressions

    #region Cache Index Fields (6)

    private int _cacheIndex_Patient = -1;
    private int _cacheIndex_Initial_population = -1;
    private int _cacheIndex_Exclusion = -1;
    private int _cacheIndex_Denominator = -1;
    private int _cacheIndex_Numerator_1 = -1;
    private int _cacheIndex_Numerator_2 = -1;

    #endregion Cache Index Fields

    #region ILibraryInternals Implementation

    /// <summary>
    /// Initializes cache indices for this library's cached expressions.
    /// </summary>
    /// <param name="libraryInvocationSet">The library invocation set performing initialization.</param>
    /// <param name="startIndex">The starting index for cache field assignment.</param>
    /// <returns>The number of cache indices initialized (number of cached expressions in this library).</returns>
    int ILibraryInternals.InitializeCacheIndices(
        CqlLibraryInvocationSet libraryInvocationSet,
        int startIndex)
    {
        var index = startIndex;
        _cacheIndex_Patient = index++;
        _cacheIndex_Initial_population = index++;
        _cacheIndex_Exclusion = index++;
        _cacheIndex_Denominator = index++;
        _cacheIndex_Numerator_1 = index++;
        _cacheIndex_Numerator_2 = index++;
        return index - startIndex;
    }

    #endregion ILibraryInternals Implementation

    #region Singleton Lifetime Members

    private MeasureExample_0_0_1() {}

    public static MeasureExample_0_0_1 Instance { get; } = new();

    #endregion

    #region ILibrary Implementation

    public string Name => "MeasureExample";
    public string Version => "0.0.1";
    public ILibrary[] Dependencies => [];

    #endregion ILibrary Implementation

}

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

[System.CodeDom.Compiler.GeneratedCode(".NET Code Generation", "5.1.0.0")]
[CqlLibrary("MeasureExample", "0.0.1")]
public partial class MeasureExample_0_0_1 : ILibrary, ISingleton<MeasureExample_0_0_1>
{
    #region Functions and Expressions (6)

    [CqlExpressionDefinition("Patient")]
    public Patient Patient(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Patient, Patient_Compute);

    private static readonly long _cacheIndex_Patient = 573802528633067256L;

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
        context.GetOrCompute(_cacheIndex_Initial_population, Initial_population_Compute);

    private static readonly long _cacheIndex_Initial_population = 3971454504690862483L;

    private bool? Initial_population_Compute(CqlContext context) =>
    true;


    [CqlExpressionDefinition("Exclusion")]
    [CqlTag("group", "1")]
    [CqlTag("group", "2")]
    [CqlTag("population", "denominator-exclusion")]
    public bool? Exclusion(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Exclusion, Exclusion_Compute);

    private static readonly long _cacheIndex_Exclusion = -340095662832327621L;

    private bool? Exclusion_Compute(CqlContext context) =>
    false;


    [CqlExpressionDefinition("Denominator")]
    [CqlTag("group", "1")]
    [CqlTag("group", "2")]
    [CqlTag("population", "denominator")]
    public bool? Denominator(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Denominator, Denominator_Compute);

    private static readonly long _cacheIndex_Denominator = 4268609403665627099L;

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
        context.GetOrCompute(_cacheIndex_Numerator_1, Numerator_1_Compute);

    private static readonly long _cacheIndex_Numerator_1 = -5945716760631093539L;

    private bool? Numerator_1_Compute(CqlContext context) =>
    true;


    [CqlExpressionDefinition("Numerator 2")]
    [CqlTag("group", "2")]
    [CqlTag("population", "numerator")]
    public bool? Numerator_2(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Numerator_2, Numerator_2_Compute);

    private static readonly long _cacheIndex_Numerator_2 = -18372347484029309L;

    private bool? Numerator_2_Compute(CqlContext context) =>
    false;


    #endregion Functions and Expressions

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

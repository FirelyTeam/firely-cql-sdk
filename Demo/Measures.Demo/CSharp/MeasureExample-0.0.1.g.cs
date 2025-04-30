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

[System.CodeDom.Compiler.GeneratedCode(".NET Code Generation", "3.0.0.0")]
[CqlLibrary("MeasureExample", "0.0.1")]
public partial class MeasureExample_0_0_1 : ILibrary, ISingleton<MeasureExample_0_0_1>
{
    private MeasureExample_0_0_1() {}

    public static MeasureExample_0_0_1 Instance { get; } = new();

    #region ILibrary Implementation

    public string Name => "MeasureExample";
    public string Version => "0.0.1";
    public ILibrary[] Dependencies => [];

    #endregion ILibrary Implementation

    #region Expressions

    [CqlExpressionDefinition("Patient")]
    public Patient Patient(CqlContext context)
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
        true;


    [CqlExpressionDefinition("Exclusion")]
    [CqlTag("group", "1")]
    [CqlTag("group", "2")]
    [CqlTag("population", "denominator-exclusion")]
    public bool? Exclusion(CqlContext context) =>
        false;


    [CqlExpressionDefinition("Denominator")]
    [CqlTag("group", "1")]
    [CqlTag("group", "2")]
    [CqlTag("population", "denominator")]
    public bool? Denominator(CqlContext context)
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
        true;


    [CqlExpressionDefinition("Numerator 2")]
    [CqlTag("group", "2")]
    [CqlTag("population", "numerator")]
    public bool? Numerator_2(CqlContext context) =>
        false;


    #endregion Expressions

}

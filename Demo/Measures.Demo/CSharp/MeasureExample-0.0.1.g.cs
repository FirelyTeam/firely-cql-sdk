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

[System.CodeDom.Compiler.GeneratedCode(".NET Code Generation", "2.1.0.0")]
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

    #region Definition Methods

    [CqlDeclaration("Patient")]
    public Patient Patient(CqlContext context)
    {
        IEnumerable<Patient> a_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/StructureDefinition/Patient"));
        Patient b_ = context.Operators.SingletonFrom<Patient>(a_);

        return b_;
    }


    [CqlDeclaration("Initial population")]
    public bool? Initial_population(CqlContext context) =>
        true;


    [CqlDeclaration("Denominator")]
    public bool? Denominator(CqlContext context)
    {
        bool? a_ = this.Initial_population(context);
        bool? b_ = this.Exclusion(context);
        bool? c_ = context.Operators.Not(b_);
        bool? d_ = context.Operators.And(a_, c_);

        return d_;
    }


    [CqlDeclaration("Exclusion")]
    public bool? Exclusion(CqlContext context) =>
        false;


    [CqlDeclaration("Numerator 1")]
    public bool? Numerator_1(CqlContext context) =>
        true;


    [CqlDeclaration("Numerator 2")]
    public bool? Numerator_2(CqlContext context) =>
        false;


    #endregion Definition Methods

}

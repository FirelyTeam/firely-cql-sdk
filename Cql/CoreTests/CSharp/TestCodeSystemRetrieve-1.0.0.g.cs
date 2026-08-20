#nullable enable

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

[System.CodeDom.Compiler.GeneratedCode(".NET Code Generation", "5.3.0.0")]
[CqlLibrary("TestCodeSystemRetrieve", "1.0.0")]
public partial class TestCodeSystemRetrieve_1_0_0 : ILibrary, ISingleton<TestCodeSystemRetrieve_1_0_0>
{
    #region Functions and Expressions (2)

    [CqlExpressionDefinition("Patient")]
    public Patient? Patient(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Patient, Patient_Compute);

    private const long _cacheIndex_Patient = -4766566577409907948L;

    private Patient? Patient_Compute(CqlContext context)
    {
        IEnumerable<Patient?>? a_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/StructureDefinition/Patient"));
        Patient? b_ = context.Operators.SingletonFrom<Patient?>(a_);
        return b_;
    }


    [CqlExpressionDefinition("FulfillTasks")]
    public IEnumerable<Task?>? FulfillTasks(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_FulfillTasks, FulfillTasks_Compute);

    private const long _cacheIndex_FulfillTasks = -5422506565360097072L;

    private IEnumerable<Task?>? FulfillTasks_Compute(CqlContext context)
    {
        CqlCode? a_ = TestCodeSystemInclude_1_0_0.Instance.Fulfill_Task(context);
        IEnumerable<CqlCode?>? b_ = context.Operators.ToList<CqlCode?>(a_);
        IEnumerable<Task?>? c_ = context.Operators.Retrieve<Task>(new RetrieveParameters(default, default, b_, "http://hl7.org/fhir/StructureDefinition/Task"));
        return c_;
    }


    #endregion Functions and Expressions

    #region Singleton Lifetime Members

    private TestCodeSystemRetrieve_1_0_0() {}

    public static TestCodeSystemRetrieve_1_0_0 Instance { get; } = new();

    #endregion

    #region ILibrary Implementation

    public string Name => "TestCodeSystemRetrieve";
    public string Version => "1.0.0";
    public ILibrary[] Dependencies => [TestCodeSystemInclude_1_0_0.Instance];

    #endregion ILibrary Implementation

}

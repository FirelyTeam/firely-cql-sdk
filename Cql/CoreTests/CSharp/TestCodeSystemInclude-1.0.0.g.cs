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

[System.CodeDom.Compiler.GeneratedCode(".NET Code Generation", "5.1.2.0")]
[CqlLibrary("TestCodeSystemInclude", "1.0.0")]
public partial class TestCodeSystemInclude_1_0_0 : ILibrary, ISingleton<TestCodeSystemInclude_1_0_0>
{
    #region Codes (1)

    [CqlCodeDefinition("Fulfill Task", codeId: "fulfill", codeSystem: "http://hl7.org/fhir/CodeSystem/task-code")]
    public CqlCode Fulfill_Task(CqlContext _) => _Fulfill_Task;
    private static readonly CqlCode _Fulfill_Task = new CqlCode("fulfill", "http://hl7.org/fhir/CodeSystem/task-code");

    #endregion Codes

    #region CodeSystems (1)

    [CqlCodeSystemDefinition("TaskCodeSystem", codeSystemId: "http://hl7.org/fhir/CodeSystem/task-code", codeSystemVersion: null)]
    public CqlCodeSystem TaskCodeSystem(CqlContext _) => _TaskCodeSystem;
    private static readonly CqlCodeSystem _TaskCodeSystem =
      new CqlCodeSystem("http://hl7.org/fhir/CodeSystem/task-code", null, [
          _Fulfill_Task]);

    #endregion CodeSystems

    #region Singleton Lifetime Members

    private TestCodeSystemInclude_1_0_0() {}

    public static TestCodeSystemInclude_1_0_0 Instance { get; } = new();

    #endregion

    #region ILibrary Implementation

    public string Name => "TestCodeSystemInclude";
    public string Version => "1.0.0";
    public ILibrary[] Dependencies => [];

    #endregion ILibrary Implementation

}

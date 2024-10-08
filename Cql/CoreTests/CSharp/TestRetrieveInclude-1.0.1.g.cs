using System;
using System.Linq;
using System.Collections.Generic;
using Hl7.Cql.Runtime;
using Hl7.Cql.Primitives;
using Hl7.Cql.Abstractions;
using Hl7.Cql.ValueSets;
using Hl7.Cql.Iso8601;
using System.Reflection;
using Hl7.Fhir.Model;
using Range = Hl7.Fhir.Model.Range;
using Task = Hl7.Fhir.Model.Task;
[System.CodeDom.Compiler.GeneratedCode(".NET Code Generation", "2.0.5.0")]
[CqlLibrary("TestRetrieveInclude", "1.0.1")]
public partial class TestRetrieveInclude_1_0_1 : ILibrary, ISingleton<TestRetrieveInclude_1_0_1>
{
    private TestRetrieveInclude_1_0_1() {}

    public static TestRetrieveInclude_1_0_1 Instance { get; } = new();

    #region Library Members
    public string Name => "TestRetrieveInclude";
    public string Version => "1.0.1";
    public ILibrary Dependencies => []
    #endregion Library Members

    [CqlDeclaration("Female Administrative Sex")]
    [CqlValueSet("2.16.840.1.113883.3.560.100.2")]
	public CqlValueSet Female_Administrative_Sex(CqlContext context) => 
		new CqlValueSet("2.16.840.1.113883.3.560.100.2", default);


    [CqlDeclaration("Other Female Reproductive Conditions")]
    [CqlValueSet("2.16.840.1.113883.3.464.1003.111.12.1006")]
	public CqlValueSet Other_Female_Reproductive_Conditions(CqlContext context) => 
		new CqlValueSet("2.16.840.1.113883.3.464.1003.111.12.1006", default);


    [CqlDeclaration("Genital Herpes")]
    [CqlValueSet("2.16.840.1.113883.3.464.1003.110.12.1049")]
	public CqlValueSet Genital_Herpes(CqlContext context) => 
		new CqlValueSet("2.16.840.1.113883.3.464.1003.110.12.1049", default);


    [CqlDeclaration("Genococcal Infections and Venereal Diseases")]
    [CqlValueSet("2.16.840.1.113883.3.464.1003.112.12.1001")]
	public CqlValueSet Genococcal_Infections_and_Venereal_Diseases(CqlContext context) => 
		new CqlValueSet("2.16.840.1.113883.3.464.1003.112.12.1001", default);


    [CqlDeclaration("Inflammatory Diseases of Female Reproductive Organs")]
    [CqlValueSet("2.16.840.1.113883.3.464.1003.112.12.1004")]
	public CqlValueSet Inflammatory_Diseases_of_Female_Reproductive_Organs(CqlContext context) => 
		new CqlValueSet("2.16.840.1.113883.3.464.1003.112.12.1004", default);


    [CqlDeclaration("Chlamydia")]
    [CqlValueSet("2.16.840.1.113883.3.464.1003.112.12.1003")]
	public CqlValueSet Chlamydia(CqlContext context) => 
		new CqlValueSet("2.16.840.1.113883.3.464.1003.112.12.1003", default);

}

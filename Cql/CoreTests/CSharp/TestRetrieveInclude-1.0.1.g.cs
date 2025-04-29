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
[CqlLibrary("TestRetrieveInclude", "1.0.1")]
public partial class TestRetrieveInclude_1_0_1 : ILibrary, ISingleton<TestRetrieveInclude_1_0_1>
{
    private TestRetrieveInclude_1_0_1() {}

    public static TestRetrieveInclude_1_0_1 Instance { get; } = new();

    #region ILibrary Implementation

    public string Name => "TestRetrieveInclude";
    public string Version => "1.0.1";
    public ILibrary[] Dependencies => [];

    #endregion ILibrary Implementation

    #region ValueSets

    #region ValueSet: Female Administrative Sex
    [CqlValueSetDefinition(
        definitionName: "Female Administrative Sex",
        valueSetId: "2.16.840.1.113883.3.560.100.2",
        valueSetVersion: null)]
    public CqlValueSet Female_Administrative_Sex(CqlContext context) => _Female_Administrative_Sex;

    private static readonly CqlValueSet _Female_Administrative_Sex = new CqlValueSet("2.16.840.1.113883.3.560.100.2", null);
    #endregion

    #region ValueSet: Other Female Reproductive Conditions
    [CqlValueSetDefinition(
        definitionName: "Other Female Reproductive Conditions",
        valueSetId: "2.16.840.1.113883.3.464.1003.111.12.1006",
        valueSetVersion: null)]
    public CqlValueSet Other_Female_Reproductive_Conditions(CqlContext context) => _Other_Female_Reproductive_Conditions;

    private static readonly CqlValueSet _Other_Female_Reproductive_Conditions = new CqlValueSet("2.16.840.1.113883.3.464.1003.111.12.1006", null);
    #endregion

    #region ValueSet: Genital Herpes
    [CqlValueSetDefinition(
        definitionName: "Genital Herpes",
        valueSetId: "2.16.840.1.113883.3.464.1003.110.12.1049",
        valueSetVersion: null)]
    public CqlValueSet Genital_Herpes(CqlContext context) => _Genital_Herpes;

    private static readonly CqlValueSet _Genital_Herpes = new CqlValueSet("2.16.840.1.113883.3.464.1003.110.12.1049", null);
    #endregion

    #region ValueSet: Genococcal Infections and Venereal Diseases
    [CqlValueSetDefinition(
        definitionName: "Genococcal Infections and Venereal Diseases",
        valueSetId: "2.16.840.1.113883.3.464.1003.112.12.1001",
        valueSetVersion: null)]
    public CqlValueSet Genococcal_Infections_and_Venereal_Diseases(CqlContext context) => _Genococcal_Infections_and_Venereal_Diseases;

    private static readonly CqlValueSet _Genococcal_Infections_and_Venereal_Diseases = new CqlValueSet("2.16.840.1.113883.3.464.1003.112.12.1001", null);
    #endregion

    #region ValueSet: Inflammatory Diseases of Female Reproductive Organs
    [CqlValueSetDefinition(
        definitionName: "Inflammatory Diseases of Female Reproductive Organs",
        valueSetId: "2.16.840.1.113883.3.464.1003.112.12.1004",
        valueSetVersion: null)]
    public CqlValueSet Inflammatory_Diseases_of_Female_Reproductive_Organs(CqlContext context) => _Inflammatory_Diseases_of_Female_Reproductive_Organs;

    private static readonly CqlValueSet _Inflammatory_Diseases_of_Female_Reproductive_Organs = new CqlValueSet("2.16.840.1.113883.3.464.1003.112.12.1004", null);
    #endregion

    #region ValueSet: Chlamydia
    [CqlValueSetDefinition(
        definitionName: "Chlamydia",
        valueSetId: "2.16.840.1.113883.3.464.1003.112.12.1003",
        valueSetVersion: null)]
    public CqlValueSet Chlamydia(CqlContext context) => _Chlamydia;

    private static readonly CqlValueSet _Chlamydia = new CqlValueSet("2.16.840.1.113883.3.464.1003.112.12.1003", null);
    #endregion

    #endregion ValueSets

    #region Expressions

    [CqlExpressionDefinition(
        definitionName: "InDemographic")]
    public IEnumerable<Observation> InDemographic(CqlContext context)
    {
        IEnumerable<Observation> gzzzzzx_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/StructureDefinition/Observation"));

        return gzzzzzx_;
    }


    #endregion Expressions

}

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
[System.CodeDom.Compiler.GeneratedCode(".NET Code Generation", "2.0.4.0")]
[CqlLibrary("TestRetrieveInclude", "1.0.1")]
public class TestRetrieveInclude_1_0_1
{


    internal CqlContext context;

    #region Cached values

    internal Lazy<CqlValueSet> __Female_Administrative_Sex;
    internal Lazy<CqlValueSet> __Other_Female_Reproductive_Conditions;
    internal Lazy<CqlValueSet> __Genital_Herpes;
    internal Lazy<CqlValueSet> __Genococcal_Infections_and_Venereal_Diseases;
    internal Lazy<CqlValueSet> __Inflammatory_Diseases_of_Female_Reproductive_Organs;
    internal Lazy<CqlValueSet> __Chlamydia;

    #endregion
    public TestRetrieveInclude_1_0_1(CqlContext context)
    {
        this.context = context ?? throw new ArgumentNullException("context");


        __Female_Administrative_Sex = new Lazy<CqlValueSet>(this.Female_Administrative_Sex_Value);
        __Other_Female_Reproductive_Conditions = new Lazy<CqlValueSet>(this.Other_Female_Reproductive_Conditions_Value);
        __Genital_Herpes = new Lazy<CqlValueSet>(this.Genital_Herpes_Value);
        __Genococcal_Infections_and_Venereal_Diseases = new Lazy<CqlValueSet>(this.Genococcal_Infections_and_Venereal_Diseases_Value);
        __Inflammatory_Diseases_of_Female_Reproductive_Organs = new Lazy<CqlValueSet>(this.Inflammatory_Diseases_of_Female_Reproductive_Organs_Value);
        __Chlamydia = new Lazy<CqlValueSet>(this.Chlamydia_Value);
    }
	private CqlValueSet Female_Administrative_Sex_Value() => 
		new CqlValueSet("2.16.840.1.113883.3.560.100.2", default);

    [CqlDeclaration("Female Administrative Sex")]
    [CqlValueSet("2.16.840.1.113883.3.560.100.2")]
	public CqlValueSet Female_Administrative_Sex() => 
		__Female_Administrative_Sex.Value;

	private CqlValueSet Other_Female_Reproductive_Conditions_Value() => 
		new CqlValueSet("2.16.840.1.113883.3.464.1003.111.12.1006", default);

    [CqlDeclaration("Other Female Reproductive Conditions")]
    [CqlValueSet("2.16.840.1.113883.3.464.1003.111.12.1006")]
	public CqlValueSet Other_Female_Reproductive_Conditions() => 
		__Other_Female_Reproductive_Conditions.Value;

	private CqlValueSet Genital_Herpes_Value() => 
		new CqlValueSet("2.16.840.1.113883.3.464.1003.110.12.1049", default);

    [CqlDeclaration("Genital Herpes")]
    [CqlValueSet("2.16.840.1.113883.3.464.1003.110.12.1049")]
	public CqlValueSet Genital_Herpes() => 
		__Genital_Herpes.Value;

	private CqlValueSet Genococcal_Infections_and_Venereal_Diseases_Value() => 
		new CqlValueSet("2.16.840.1.113883.3.464.1003.112.12.1001", default);

    [CqlDeclaration("Genococcal Infections and Venereal Diseases")]
    [CqlValueSet("2.16.840.1.113883.3.464.1003.112.12.1001")]
	public CqlValueSet Genococcal_Infections_and_Venereal_Diseases() => 
		__Genococcal_Infections_and_Venereal_Diseases.Value;

	private CqlValueSet Inflammatory_Diseases_of_Female_Reproductive_Organs_Value() => 
		new CqlValueSet("2.16.840.1.113883.3.464.1003.112.12.1004", default);

    [CqlDeclaration("Inflammatory Diseases of Female Reproductive Organs")]
    [CqlValueSet("2.16.840.1.113883.3.464.1003.112.12.1004")]
	public CqlValueSet Inflammatory_Diseases_of_Female_Reproductive_Organs() => 
		__Inflammatory_Diseases_of_Female_Reproductive_Organs.Value;

	private CqlValueSet Chlamydia_Value() => 
		new CqlValueSet("2.16.840.1.113883.3.464.1003.112.12.1003", default);

    [CqlDeclaration("Chlamydia")]
    [CqlValueSet("2.16.840.1.113883.3.464.1003.112.12.1003")]
	public CqlValueSet Chlamydia() => 
		__Chlamydia.Value;

}

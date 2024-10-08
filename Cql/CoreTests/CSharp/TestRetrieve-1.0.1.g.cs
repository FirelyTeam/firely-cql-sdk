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
[CqlLibrary("TestRetrieve", "1.0.1")]
public class TestRetrieve_1_0_1
{


    internal CqlContext context;

    #region Cached values

    internal Lazy<CqlValueSet> __HIV;
    internal Lazy<CqlValueSet> __Syphilis;
    internal Lazy<CqlValueSet> __Complications_of_Pregnancy__Childbirth_and_the_Puerperium;
    internal Lazy<CqlValueSet> __Pregnancy_Test;
    internal Lazy<CqlValueSet> __Pap_Test;
    internal Lazy<CqlValueSet> __Lab_Tests_During_Pregnancy;
    internal Lazy<CqlValueSet> __Lab_Tests_for_Sexually_Transmitted_Infections;
    internal Lazy<CqlValueSet> __Chlamydia_Screening;
    internal Lazy<CqlValueSet> __Palliative_Care_Assessment;
    internal Lazy<CqlValueSet> __Palliative_Care_Encounter;
    internal Lazy<CqlValueSet> __Palliative_Care_Intervention;
    internal Lazy<CqlCode> __Encounter_for_palliative_care;
    internal Lazy<CqlCode[]> __ICD_10;
    internal Lazy<object> __MeasurementPeriod;
    internal Lazy<Patient> __Patient;

    #endregion
    public TestRetrieve_1_0_1(CqlContext context)
    {
        this.context = context ?? throw new ArgumentNullException("context");

        FHIRHelpers_4_0_1 = new FHIRHelpers_4_0_1(context);
        TestRetrieveInclude_1_0_1 = new TestRetrieveInclude_1_0_1(context);

        __HIV = new Lazy<CqlValueSet>(this.HIV_Value);
        __Syphilis = new Lazy<CqlValueSet>(this.Syphilis_Value);
        __Complications_of_Pregnancy__Childbirth_and_the_Puerperium = new Lazy<CqlValueSet>(this.Complications_of_Pregnancy__Childbirth_and_the_Puerperium_Value);
        __Pregnancy_Test = new Lazy<CqlValueSet>(this.Pregnancy_Test_Value);
        __Pap_Test = new Lazy<CqlValueSet>(this.Pap_Test_Value);
        __Lab_Tests_During_Pregnancy = new Lazy<CqlValueSet>(this.Lab_Tests_During_Pregnancy_Value);
        __Lab_Tests_for_Sexually_Transmitted_Infections = new Lazy<CqlValueSet>(this.Lab_Tests_for_Sexually_Transmitted_Infections_Value);
        __Chlamydia_Screening = new Lazy<CqlValueSet>(this.Chlamydia_Screening_Value);
        __Palliative_Care_Assessment = new Lazy<CqlValueSet>(this.Palliative_Care_Assessment_Value);
        __Palliative_Care_Encounter = new Lazy<CqlValueSet>(this.Palliative_Care_Encounter_Value);
        __Palliative_Care_Intervention = new Lazy<CqlValueSet>(this.Palliative_Care_Intervention_Value);
        __Encounter_for_palliative_care = new Lazy<CqlCode>(this.Encounter_for_palliative_care_Value);
        __ICD_10 = new Lazy<CqlCode[]>(this.ICD_10_Value);
        __MeasurementPeriod = new Lazy<object>(this.MeasurementPeriod_Value);
        __Patient = new Lazy<Patient>(this.Patient_Value);
    }
    #region Dependencies

    public FHIRHelpers_4_0_1 FHIRHelpers_4_0_1 { get; }
    public TestRetrieveInclude_1_0_1 TestRetrieveInclude_1_0_1 { get; }

    #endregion

	private CqlValueSet HIV_Value() => 
		new CqlValueSet("2.16.840.1.113883.3.464.1003.120.12.1003", default);

    [CqlDeclaration("HIV")]
    [CqlValueSet("2.16.840.1.113883.3.464.1003.120.12.1003")]
	public CqlValueSet HIV() => 
		__HIV.Value;

	private CqlValueSet Syphilis_Value() => 
		new CqlValueSet("2.16.840.1.113883.3.464.1003.112.12.1002", default);

    [CqlDeclaration("Syphilis")]
    [CqlValueSet("2.16.840.1.113883.3.464.1003.112.12.1002")]
	public CqlValueSet Syphilis() => 
		__Syphilis.Value;

	private CqlValueSet Complications_of_Pregnancy__Childbirth_and_the_Puerperium_Value() => 
		new CqlValueSet("2.16.840.1.113883.3.464.1003.111.12.1012", default);

    [CqlDeclaration("Complications of Pregnancy, Childbirth and the Puerperium")]
    [CqlValueSet("2.16.840.1.113883.3.464.1003.111.12.1012")]
	public CqlValueSet Complications_of_Pregnancy__Childbirth_and_the_Puerperium() => 
		__Complications_of_Pregnancy__Childbirth_and_the_Puerperium.Value;

	private CqlValueSet Pregnancy_Test_Value() => 
		new CqlValueSet("2.16.840.1.113883.3.464.1003.111.12.1011", default);

    [CqlDeclaration("Pregnancy Test")]
    [CqlValueSet("2.16.840.1.113883.3.464.1003.111.12.1011")]
	public CqlValueSet Pregnancy_Test() => 
		__Pregnancy_Test.Value;

	private CqlValueSet Pap_Test_Value() => 
		new CqlValueSet("2.16.840.1.113883.3.464.1003.108.12.1017", default);

    [CqlDeclaration("Pap Test")]
    [CqlValueSet("2.16.840.1.113883.3.464.1003.108.12.1017")]
	public CqlValueSet Pap_Test() => 
		__Pap_Test.Value;

	private CqlValueSet Lab_Tests_During_Pregnancy_Value() => 
		new CqlValueSet("2.16.840.1.113883.3.464.1003.111.12.1007", default);

    [CqlDeclaration("Lab Tests During Pregnancy")]
    [CqlValueSet("2.16.840.1.113883.3.464.1003.111.12.1007")]
	public CqlValueSet Lab_Tests_During_Pregnancy() => 
		__Lab_Tests_During_Pregnancy.Value;

	private CqlValueSet Lab_Tests_for_Sexually_Transmitted_Infections_Value() => 
		new CqlValueSet("2.16.840.1.113883.3.464.1003.110.12.1051", default);

    [CqlDeclaration("Lab Tests for Sexually Transmitted Infections")]
    [CqlValueSet("2.16.840.1.113883.3.464.1003.110.12.1051")]
	public CqlValueSet Lab_Tests_for_Sexually_Transmitted_Infections() => 
		__Lab_Tests_for_Sexually_Transmitted_Infections.Value;

	private CqlValueSet Chlamydia_Screening_Value() => 
		new CqlValueSet("2.16.840.1.113883.3.464.1003.110.12.1052", default);

    [CqlDeclaration("Chlamydia Screening")]
    [CqlValueSet("2.16.840.1.113883.3.464.1003.110.12.1052")]
	public CqlValueSet Chlamydia_Screening() => 
		__Chlamydia_Screening.Value;

	private CqlValueSet Palliative_Care_Assessment_Value() => 
		new CqlValueSet("https://www.ncqa.org/fhir/valueset/2.16.840.1.113883.3.464.1004.2225", default);

    [CqlDeclaration("Palliative Care Assessment")]
    [CqlValueSet("https://www.ncqa.org/fhir/valueset/2.16.840.1.113883.3.464.1004.2225")]
	public CqlValueSet Palliative_Care_Assessment() => 
		__Palliative_Care_Assessment.Value;

	private CqlValueSet Palliative_Care_Encounter_Value() => 
		new CqlValueSet("https://www.ncqa.org/fhir/valueset/2.16.840.1.113883.3.464.1004.1450", default);

    [CqlDeclaration("Palliative Care Encounter")]
    [CqlValueSet("https://www.ncqa.org/fhir/valueset/2.16.840.1.113883.3.464.1004.1450")]
	public CqlValueSet Palliative_Care_Encounter() => 
		__Palliative_Care_Encounter.Value;

	private CqlValueSet Palliative_Care_Intervention_Value() => 
		new CqlValueSet("https://www.ncqa.org/fhir/valueset/2.16.840.1.113883.3.464.1004.2224", default);

    [CqlDeclaration("Palliative Care Intervention")]
    [CqlValueSet("https://www.ncqa.org/fhir/valueset/2.16.840.1.113883.3.464.1004.2224")]
	public CqlValueSet Palliative_Care_Intervention() => 
		__Palliative_Care_Intervention.Value;

	private CqlCode Encounter_for_palliative_care_Value() => 
		new CqlCode("Z51.5", "http://hl7.org/fhir/sid/icd-10-cm", default, default);

    [CqlDeclaration("Encounter for palliative care")]
	public CqlCode Encounter_for_palliative_care() => 
		__Encounter_for_palliative_care.Value;

	private CqlCode[] ICD_10_Value()
	{
		CqlCode[] a_ = [
			new CqlCode("Z51.5", "http://hl7.org/fhir/sid/icd-10-cm", default, default),
		];

		return a_;
	}

    [CqlDeclaration("ICD-10")]
	public CqlCode[] ICD_10() => 
		__ICD_10.Value;

	private object MeasurementPeriod_Value()
	{
		CqlDateTime a_ = context.Operators.DateTime(2013, 1, 1, 0, 0, 0, 0, default);
		CqlDateTime b_ = context.Operators.DateTime(2014, 1, 1, 0, 0, 0, 0, default);
		CqlInterval<CqlDateTime> c_ = context.Operators.Interval(a_, b_, true, false);
		object d_ = context.ResolveParameter("TestRetrieve-1.0.1", "MeasurementPeriod", c_);

		return d_;
	}

    [CqlDeclaration("MeasurementPeriod")]
	public object MeasurementPeriod() => 
		__MeasurementPeriod.Value;

	private Patient Patient_Value()
	{
		IEnumerable<Patient> a_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/StructureDefinition/Patient"));
		Patient b_ = context.Operators.SingletonFrom<Patient>(a_);

		return b_;
	}

    [CqlDeclaration("Patient")]
	public Patient Patient() => 
		__Patient.Value;

}

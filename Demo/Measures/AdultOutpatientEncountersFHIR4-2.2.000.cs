using System;
using System.Linq;
using System.Collections.Generic;
using Hl7.Cql.Runtime;
using Hl7.Cql.Primitives;
using Hl7.Cql.Abstractions;
using Hl7.Cql.ValueSets;
using Hl7.Cql.Iso8601;
using Hl7.Fhir.Model;
using Range = Hl7.Fhir.Model.Range;
using Task = Hl7.Fhir.Model.Task;
[System.CodeDom.Compiler.GeneratedCode(".NET Code Generation", "1.0.0.0")]
[CqlLibrary("AdultOutpatientEncountersFHIR4", "2.2.000")]
public class AdultOutpatientEncountersFHIR4_2_2_000
{

    internal CqlContext context;

    #region Cached values

    internal Lazy<CqlValueSet> __Annual_Wellness_Visit;
    internal Lazy<CqlValueSet> __Home_Healthcare_Services;
    internal Lazy<CqlValueSet> __Office_Visit;
    internal Lazy<CqlValueSet> __Preventive_Care_Services___Established_Office_Visit__18_and_Up;
    internal Lazy<CqlValueSet> __Preventive_Care_Services_Initial_Office_Visit__18_and_Up;
    internal Lazy<CqlInterval<CqlDateTime>> __Measurement_Period;
    internal Lazy<Patient> __Patient;
    internal Lazy<IEnumerable<Encounter>> __Qualifying_Encounters;

    #endregion
    public AdultOutpatientEncountersFHIR4_2_2_000(CqlContext context)
    {
        this.context = context ?? throw new ArgumentNullException("context");

        FHIRHelpers_4_0_001 = new FHIRHelpers_4_0_001(context);
        MATGlobalCommonFunctionsFHIR4_6_1_000 = new MATGlobalCommonFunctionsFHIR4_6_1_000(context);

        __Annual_Wellness_Visit = new Lazy<CqlValueSet>(this.Annual_Wellness_Visit_Value(context));
        __Home_Healthcare_Services = new Lazy<CqlValueSet>(this.Home_Healthcare_Services_Value(context));
        __Office_Visit = new Lazy<CqlValueSet>(this.Office_Visit_Value(context));
        __Preventive_Care_Services___Established_Office_Visit__18_and_Up = new Lazy<CqlValueSet>(this.Preventive_Care_Services___Established_Office_Visit__18_and_Up_Value(context));
        __Preventive_Care_Services_Initial_Office_Visit__18_and_Up = new Lazy<CqlValueSet>(this.Preventive_Care_Services_Initial_Office_Visit__18_and_Up_Value(context));
        __Measurement_Period = new Lazy<CqlInterval<CqlDateTime>>(this.Measurement_Period_Value(context));
        __Patient = new Lazy<Patient>(this.Patient_Value(context));
        __Qualifying_Encounters = new Lazy<IEnumerable<Encounter>>(this.Qualifying_Encounters_Value(context));
    }
    #region Dependencies

    public FHIRHelpers_4_0_001 FHIRHelpers_4_0_001 { get; }
    public MATGlobalCommonFunctionsFHIR4_6_1_000 MATGlobalCommonFunctionsFHIR4_6_1_000 { get; }

    #endregion

	private CqlValueSet Annual_Wellness_Visit_Value(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1240", null);

    [CqlDeclaration("Annual Wellness Visit")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1240")]
	public CqlValueSet Annual_Wellness_Visit() => 
		__Annual_Wellness_Visit?.Value;

	private CqlValueSet Home_Healthcare_Services_Value(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1016", null);

    [CqlDeclaration("Home Healthcare Services")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1016")]
	public CqlValueSet Home_Healthcare_Services() => 
		__Home_Healthcare_Services?.Value;

	private CqlValueSet Office_Visit_Value(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1001", null);

    [CqlDeclaration("Office Visit")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1001")]
	public CqlValueSet Office_Visit() => 
		__Office_Visit?.Value;

	private CqlValueSet Preventive_Care_Services___Established_Office_Visit__18_and_Up_Value(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1025", null);

    [CqlDeclaration("Preventive Care Services - Established Office Visit, 18 and Up")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1025")]
	public CqlValueSet Preventive_Care_Services___Established_Office_Visit__18_and_Up() => 
		__Preventive_Care_Services___Established_Office_Visit__18_and_Up?.Value;

	private CqlValueSet Preventive_Care_Services_Initial_Office_Visit__18_and_Up_Value(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1023", null);

    [CqlDeclaration("Preventive Care Services-Initial Office Visit, 18 and Up")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1023")]
	public CqlValueSet Preventive_Care_Services_Initial_Office_Visit__18_and_Up() => 
		__Preventive_Care_Services_Initial_Office_Visit__18_and_Up?.Value;

	private CqlInterval<CqlDateTime> Measurement_Period_Value(CqlContext context)
	{
		var a_ = context.ResolveParameter("AdultOutpatientEncountersFHIR4-2.2.000", "Measurement Period", null);

		return (CqlInterval<CqlDateTime>)a_;
	}

    [CqlDeclaration("Measurement Period")]
	public CqlInterval<CqlDateTime> Measurement_Period() => 
		__Measurement_Period?.Value;

	private Patient Patient_Value(CqlContext context)
	{
		var a_ = context.Operators.RetrieveByValueSet<Patient>(null, null);
		var b_ = context.Operators.SingleOrNull<Patient>(a_);

		return b_;
	}

    [CqlDeclaration("Patient")]
	public Patient Patient() => 
		__Patient?.Value;

	private IEnumerable<Encounter> Qualifying_Encounters_Value(CqlContext context)
	{
		var a_ = this.Office_Visit();
		var b_ = context.Operators.RetrieveByValueSet<Encounter>(a_, null);
		var c_ = this.Annual_Wellness_Visit();
		var d_ = context.Operators.RetrieveByValueSet<Encounter>(c_, null);
		var e_ = context.Operators.ListUnion<Encounter>(b_, d_);
		var f_ = this.Preventive_Care_Services___Established_Office_Visit__18_and_Up();
		var g_ = context.Operators.RetrieveByValueSet<Encounter>(f_, null);
		var h_ = this.Preventive_Care_Services_Initial_Office_Visit__18_and_Up();
		var i_ = context.Operators.RetrieveByValueSet<Encounter>(h_, null);
		var j_ = context.Operators.ListUnion<Encounter>(g_, i_);
		var k_ = context.Operators.ListUnion<Encounter>(e_, j_);
		var l_ = this.Home_Healthcare_Services();
		var m_ = context.Operators.RetrieveByValueSet<Encounter>(l_, null);
		var n_ = context.Operators.ListUnion<Encounter>(k_, m_);
		bool? o_(Encounter ValidEncounter)
		{
			var q_ = context.Operators.Convert<string>(ValidEncounter?.StatusElement);
			var r_ = context.Operators.Equal(q_, "finished");
			var s_ = this.Measurement_Period();
			var t_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Normalize_Interval((ValidEncounter?.Period as object));
			var u_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(s_, t_, null);
			var v_ = context.Operators.And(r_, u_);

			return v_;
		};
		var p_ = context.Operators.WhereOrNull<Encounter>(n_, o_);

		return p_;
	}

    [CqlDeclaration("Qualifying Encounters")]
	public IEnumerable<Encounter> Qualifying_Encounters() => 
		__Qualifying_Encounters?.Value;

}
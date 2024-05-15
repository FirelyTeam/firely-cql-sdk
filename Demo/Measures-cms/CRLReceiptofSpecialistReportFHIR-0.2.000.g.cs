using System;
using Tuples;
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
[System.CodeDom.Compiler.GeneratedCode(".NET Code Generation", "2.0.0.0")]
[CqlLibrary("CRLReceiptofSpecialistReportFHIR", "0.2.000")]
public class CRLReceiptofSpecialistReportFHIR_0_2_000
{


    internal CqlContext context;

    #region Cached values

    internal Lazy<CqlValueSet> __Consultant_Report;
    internal Lazy<CqlValueSet> __Office_Visit;
    internal Lazy<CqlValueSet> __Ophthalmological_Services;
    internal Lazy<CqlValueSet> __Preventive_Care_Services___Established_Office_Visit__18_and_Up;
    internal Lazy<CqlValueSet> __Preventive_Care_Services__Initial_Office_Visit__0_to_17;
    internal Lazy<CqlValueSet> __Preventive_Care_Services_Initial_Office_Visit__18_and_Up;
    internal Lazy<CqlValueSet> __Preventive_Care__Established_Office_Visit__0_to_17;
    internal Lazy<CqlValueSet> __Referral;
    internal Lazy<CqlInterval<CqlDateTime>> __Measurement_Period;
    internal Lazy<Patient> __Patient;
    internal Lazy<bool?> __Has_Encounter_during_Measurement_Period;
    internal Lazy<Tuple_BLEMZbHGbhMbZiIgCJaASVTUS> __First_Referral_during_First_10_Months_of_Measurement_Period;
    internal Lazy<bool?> __Initial_Population;
    internal Lazy<bool?> __Denominator;
    internal Lazy<Tuple_HPcCiDPXQfZTXIORThMLfTQDR> __SDE_Ethnicity;
    internal Lazy<IEnumerable<Tuple_GPRWMPNAYaJRiGDFSTLJOPeIJ>> __SDE_Payer;
    internal Lazy<Tuple_HPcCiDPXQfZTXIORThMLfTQDR> __SDE_Race;
    internal Lazy<CqlCode> __SDE_Sex;
    internal Lazy<bool?> __Referring_Clinician_Receives_Consultant_Report_to_Close_Referral_Loop;
    internal Lazy<bool?> __Numerator;

    #endregion
    public CRLReceiptofSpecialistReportFHIR_0_2_000(CqlContext context)
    {
        this.context = context ?? throw new ArgumentNullException("context");

        FHIRHelpers_4_3_000 = new FHIRHelpers_4_3_000(context);
        SupplementalDataElements_3_4_000 = new SupplementalDataElements_3_4_000(context);
        QICoreCommon_2_0_000 = new QICoreCommon_2_0_000(context);

        __Consultant_Report = new Lazy<CqlValueSet>(this.Consultant_Report_Value);
        __Office_Visit = new Lazy<CqlValueSet>(this.Office_Visit_Value);
        __Ophthalmological_Services = new Lazy<CqlValueSet>(this.Ophthalmological_Services_Value);
        __Preventive_Care_Services___Established_Office_Visit__18_and_Up = new Lazy<CqlValueSet>(this.Preventive_Care_Services___Established_Office_Visit__18_and_Up_Value);
        __Preventive_Care_Services__Initial_Office_Visit__0_to_17 = new Lazy<CqlValueSet>(this.Preventive_Care_Services__Initial_Office_Visit__0_to_17_Value);
        __Preventive_Care_Services_Initial_Office_Visit__18_and_Up = new Lazy<CqlValueSet>(this.Preventive_Care_Services_Initial_Office_Visit__18_and_Up_Value);
        __Preventive_Care__Established_Office_Visit__0_to_17 = new Lazy<CqlValueSet>(this.Preventive_Care__Established_Office_Visit__0_to_17_Value);
        __Referral = new Lazy<CqlValueSet>(this.Referral_Value);
        __Measurement_Period = new Lazy<CqlInterval<CqlDateTime>>(this.Measurement_Period_Value);
        __Patient = new Lazy<Patient>(this.Patient_Value);
        __Has_Encounter_during_Measurement_Period = new Lazy<bool?>(this.Has_Encounter_during_Measurement_Period_Value);
        __First_Referral_during_First_10_Months_of_Measurement_Period = new Lazy<Tuple_BLEMZbHGbhMbZiIgCJaASVTUS>(this.First_Referral_during_First_10_Months_of_Measurement_Period_Value);
        __Initial_Population = new Lazy<bool?>(this.Initial_Population_Value);
        __Denominator = new Lazy<bool?>(this.Denominator_Value);
        __SDE_Ethnicity = new Lazy<Tuple_HPcCiDPXQfZTXIORThMLfTQDR>(this.SDE_Ethnicity_Value);
        __SDE_Payer = new Lazy<IEnumerable<Tuple_GPRWMPNAYaJRiGDFSTLJOPeIJ>>(this.SDE_Payer_Value);
        __SDE_Race = new Lazy<Tuple_HPcCiDPXQfZTXIORThMLfTQDR>(this.SDE_Race_Value);
        __SDE_Sex = new Lazy<CqlCode>(this.SDE_Sex_Value);
        __Referring_Clinician_Receives_Consultant_Report_to_Close_Referral_Loop = new Lazy<bool?>(this.Referring_Clinician_Receives_Consultant_Report_to_Close_Referral_Loop_Value);
        __Numerator = new Lazy<bool?>(this.Numerator_Value);
    }
    #region Dependencies

    public FHIRHelpers_4_3_000 FHIRHelpers_4_3_000 { get; }
    public SupplementalDataElements_3_4_000 SupplementalDataElements_3_4_000 { get; }
    public QICoreCommon_2_0_000 QICoreCommon_2_0_000 { get; }

    #endregion

	private CqlValueSet Consultant_Report_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.121.12.1006", null);

    [CqlDeclaration("Consultant Report")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.121.12.1006")]
	public CqlValueSet Consultant_Report() => 
		__Consultant_Report.Value;

	private CqlValueSet Office_Visit_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1001", null);

    [CqlDeclaration("Office Visit")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1001")]
	public CqlValueSet Office_Visit() => 
		__Office_Visit.Value;

	private CqlValueSet Ophthalmological_Services_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1285", null);

    [CqlDeclaration("Ophthalmological Services")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1285")]
	public CqlValueSet Ophthalmological_Services() => 
		__Ophthalmological_Services.Value;

	private CqlValueSet Preventive_Care_Services___Established_Office_Visit__18_and_Up_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1025", null);

    [CqlDeclaration("Preventive Care Services - Established Office Visit, 18 and Up")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1025")]
	public CqlValueSet Preventive_Care_Services___Established_Office_Visit__18_and_Up() => 
		__Preventive_Care_Services___Established_Office_Visit__18_and_Up.Value;

	private CqlValueSet Preventive_Care_Services__Initial_Office_Visit__0_to_17_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1022", null);

    [CqlDeclaration("Preventive Care Services, Initial Office Visit, 0 to 17")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1022")]
	public CqlValueSet Preventive_Care_Services__Initial_Office_Visit__0_to_17() => 
		__Preventive_Care_Services__Initial_Office_Visit__0_to_17.Value;

	private CqlValueSet Preventive_Care_Services_Initial_Office_Visit__18_and_Up_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1023", null);

    [CqlDeclaration("Preventive Care Services-Initial Office Visit, 18 and Up")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1023")]
	public CqlValueSet Preventive_Care_Services_Initial_Office_Visit__18_and_Up() => 
		__Preventive_Care_Services_Initial_Office_Visit__18_and_Up.Value;

	private CqlValueSet Preventive_Care__Established_Office_Visit__0_to_17_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1024", null);

    [CqlDeclaration("Preventive Care, Established Office Visit, 0 to 17")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1024")]
	public CqlValueSet Preventive_Care__Established_Office_Visit__0_to_17() => 
		__Preventive_Care__Established_Office_Visit__0_to_17.Value;

	private CqlValueSet Referral_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1046", null);

    [CqlDeclaration("Referral")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1046")]
	public CqlValueSet Referral() => 
		__Referral.Value;

	private CqlInterval<CqlDateTime> Measurement_Period_Value()
	{
		var a_ = context.Operators.DateTime(2025, 1, 1, 0, 0, 0, 0, default);
		var b_ = context.Operators.DateTime(2026, 1, 1, 0, 0, 0, 0, default);
		var c_ = context.Operators.Interval(a_, b_, true, false);
		var d_ = context.ResolveParameter("CRLReceiptofSpecialistReportFHIR-0.2.000", "Measurement Period", c_);

		return (CqlInterval<CqlDateTime>)d_;
	}

    [CqlDeclaration("Measurement Period")]
	public CqlInterval<CqlDateTime> Measurement_Period() => 
		__Measurement_Period.Value;

	private Patient Patient_Value()
	{
		var a_ = context.Operators.RetrieveByValueSet<Patient>(null, null);
		var b_ = context.Operators.SingletonFrom<Patient>(a_);

		return b_;
	}

    [CqlDeclaration("Patient")]
	public Patient Patient() => 
		__Patient.Value;

	private bool? Has_Encounter_during_Measurement_Period_Value()
	{
		var a_ = this.Office_Visit();
		var b_ = context.Operators.RetrieveByValueSet<Encounter>(a_, null);
		var c_ = this.Ophthalmological_Services();
		var d_ = context.Operators.RetrieveByValueSet<Encounter>(c_, null);
		var e_ = context.Operators.ListUnion<Encounter>(b_, d_);
		var f_ = this.Preventive_Care_Services___Established_Office_Visit__18_and_Up();
		var g_ = context.Operators.RetrieveByValueSet<Encounter>(f_, null);
		var h_ = this.Preventive_Care_Services__Initial_Office_Visit__0_to_17();
		var i_ = context.Operators.RetrieveByValueSet<Encounter>(h_, null);
		var j_ = context.Operators.ListUnion<Encounter>(g_, i_);
		var k_ = context.Operators.ListUnion<Encounter>(e_, j_);
		var l_ = this.Preventive_Care_Services_Initial_Office_Visit__18_and_Up();
		var m_ = context.Operators.RetrieveByValueSet<Encounter>(l_, null);
		var n_ = this.Preventive_Care__Established_Office_Visit__0_to_17();
		var o_ = context.Operators.RetrieveByValueSet<Encounter>(n_, null);
		var p_ = context.Operators.ListUnion<Encounter>(m_, o_);
		var q_ = context.Operators.ListUnion<Encounter>(k_, p_);
		bool? r_(Encounter Encounter)
		{
			var u_ = Encounter?.StatusElement;
			var v_ = u_?.Value;
			var w_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(v_);
			var x_ = context.Operators.Equal(w_, "finished");
			var y_ = this.Measurement_Period();
			var z_ = Encounter?.Period;
			var aa_ = FHIRHelpers_4_3_000.ToInterval(z_);
			var ab_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(y_, aa_, "day");
			var ac_ = context.Operators.And(x_, ab_);

			return ac_;
		};
		var s_ = context.Operators.Where<Encounter>(q_, r_);
		var t_ = context.Operators.Exists<Encounter>(s_);

		return t_;
	}

    [CqlDeclaration("Has Encounter during Measurement Period")]
	public bool? Has_Encounter_during_Measurement_Period() => 
		__Has_Encounter_during_Measurement_Period.Value;

	private Tuple_BLEMZbHGbhMbZiIgCJaASVTUS First_Referral_during_First_10_Months_of_Measurement_Period_Value()
	{
		var a_ = this.Referral();
		var b_ = context.Operators.RetrieveByValueSet<ServiceRequest>(a_, null);
		bool? c_(ServiceRequest ReferralOrder)
		{
			var j_ = ReferralOrder?.StatusElement;
			var k_ = j_?.Value;
			var l_ = context.Operators.Convert<Code<RequestStatus>>(k_);
			var m_ = context.Operators.Convert<string>(l_);
			var n_ = new string[]
			{
				"active",
				"completed",
			};
			var o_ = context.Operators.In<string>(m_, (n_ as IEnumerable<string>));
			var p_ = ReferralOrder?.IntentElement;
			var q_ = p_?.Value;
			var r_ = context.Operators.Convert<Code<RequestIntent>>(q_);
			var s_ = context.Operators.Equal(r_, "order");
			var t_ = context.Operators.And(o_, s_);
			var u_ = ReferralOrder?.AuthoredOnElement;
			var v_ = context.Operators.Convert<CqlDateTime>(u_);
			var w_ = this.Measurement_Period();
			var x_ = context.Operators.Start(w_);
			var z_ = context.Operators.Start(w_);
			var aa_ = context.Operators.DateTimeComponentFrom(z_, "year");
			var ab_ = context.Operators.Date(aa_, 10, 31);
			var ac_ = context.Operators.ConvertDateToDateTime(ab_);
			var ad_ = context.Operators.Interval(x_, ac_, true, true);
			var ae_ = context.Operators.In<CqlDateTime>(v_, ad_, "day");
			var af_ = context.Operators.And(t_, ae_);

			return af_;
		};
		var d_ = context.Operators.Where<ServiceRequest>(b_, c_);
		Tuple_BLEMZbHGbhMbZiIgCJaASVTUS e_(ServiceRequest ReferralOrder)
		{
			var ag_ = ReferralOrder?.IdElement;
			var ah_ = ag_?.Value;
			var ai_ = ReferralOrder?.AuthoredOnElement;
			var aj_ = context.Operators.Convert<CqlDateTime>(ai_);
			var ak_ = new Tuple_BLEMZbHGbhMbZiIgCJaASVTUS
			{
				ID = ah_,
				AuthorDate = aj_,
			};

			return ak_;
		};
		var f_ = context.Operators.Select<ServiceRequest, Tuple_BLEMZbHGbhMbZiIgCJaASVTUS>(d_, e_);
		object g_(Tuple_BLEMZbHGbhMbZiIgCJaASVTUS @this)
		{
			var al_ = @this?.AuthorDate;

			return al_;
		};
		var h_ = context.Operators.SortBy<Tuple_BLEMZbHGbhMbZiIgCJaASVTUS>(f_, g_, System.ComponentModel.ListSortDirection.Ascending);
		var i_ = context.Operators.First<Tuple_BLEMZbHGbhMbZiIgCJaASVTUS>(h_);

		return i_;
	}

    [CqlDeclaration("First Referral during First 10 Months of Measurement Period")]
	public Tuple_BLEMZbHGbhMbZiIgCJaASVTUS First_Referral_during_First_10_Months_of_Measurement_Period() => 
		__First_Referral_during_First_10_Months_of_Measurement_Period.Value;

	private bool? Initial_Population_Value()
	{
		var a_ = this.Has_Encounter_during_Measurement_Period();
		var b_ = this.First_Referral_during_First_10_Months_of_Measurement_Period();
		var c_ = context.Operators.Not((bool?)(b_ is null));
		var d_ = context.Operators.And(a_, c_);

		return d_;
	}

    [CqlDeclaration("Initial Population")]
	public bool? Initial_Population() => 
		__Initial_Population.Value;

	private bool? Denominator_Value()
	{
		var a_ = this.Initial_Population();

		return a_;
	}

    [CqlDeclaration("Denominator")]
	public bool? Denominator() => 
		__Denominator.Value;

	private Tuple_HPcCiDPXQfZTXIORThMLfTQDR SDE_Ethnicity_Value()
	{
		var a_ = SupplementalDataElements_3_4_000.SDE_Ethnicity();

		return a_;
	}

    [CqlDeclaration("SDE Ethnicity")]
	public Tuple_HPcCiDPXQfZTXIORThMLfTQDR SDE_Ethnicity() => 
		__SDE_Ethnicity.Value;

	private IEnumerable<Tuple_GPRWMPNAYaJRiGDFSTLJOPeIJ> SDE_Payer_Value()
	{
		var a_ = SupplementalDataElements_3_4_000.SDE_Payer();

		return a_;
	}

    [CqlDeclaration("SDE Payer")]
	public IEnumerable<Tuple_GPRWMPNAYaJRiGDFSTLJOPeIJ> SDE_Payer() => 
		__SDE_Payer.Value;

	private Tuple_HPcCiDPXQfZTXIORThMLfTQDR SDE_Race_Value()
	{
		var a_ = SupplementalDataElements_3_4_000.SDE_Race();

		return a_;
	}

    [CqlDeclaration("SDE Race")]
	public Tuple_HPcCiDPXQfZTXIORThMLfTQDR SDE_Race() => 
		__SDE_Race.Value;

	private CqlCode SDE_Sex_Value()
	{
		var a_ = SupplementalDataElements_3_4_000.SDE_Sex();

		return a_;
	}

    [CqlDeclaration("SDE Sex")]
	public CqlCode SDE_Sex() => 
		__SDE_Sex.Value;

    [CqlDeclaration("TaskGetRequestID")]
	public IEnumerable<string> TaskGetRequestID(Task task)
	{
		string a_(ResourceReference Task)
		{
			var c_ = Task?.ReferenceElement;
			var d_ = c_?.Value;
			var e_ = QICoreCommon_2_0_000.GetId(d_);

			return e_;
		};
		var b_ = context.Operators.Select<ResourceReference, string>((IEnumerable<ResourceReference>)task?.BasedOn, a_);

		return b_;
	}

	private bool? Referring_Clinician_Receives_Consultant_Report_to_Close_Referral_Loop_Value()
	{
		var a_ = this.Consultant_Report();
		var b_ = context.Operators.RetrieveByValueSet<Task>(a_, null);
		IEnumerable<Task> c_(Task ConsultantReportObtained)
		{
			var f_ = this.First_Referral_during_First_10_Months_of_Measurement_Period();
			var g_ = new Tuple_BLEMZbHGbhMbZiIgCJaASVTUS[]
			{
				f_,
			};
			bool? h_(Tuple_BLEMZbHGbhMbZiIgCJaASVTUS FirstReferral)
			{
				var l_ = FirstReferral?.ID;
				var m_ = this.TaskGetRequestID(ConsultantReportObtained);
				var n_ = context.Operators.In<string>(l_, m_);
				var o_ = ConsultantReportObtained?.ExecutionPeriod;
				var p_ = FHIRHelpers_4_3_000.ToInterval(o_);
				var q_ = context.Operators.End(p_);
				var r_ = FirstReferral?.AuthorDate;
				var s_ = context.Operators.After(q_, r_, null);
				var t_ = context.Operators.And(n_, s_);
				var u_ = ConsultantReportObtained?.StatusElement;
				var v_ = u_?.Value;
				var w_ = context.Operators.Convert<Code<Task.TaskStatus>>(v_);
				var x_ = context.Operators.Equal(w_, "completed");
				var y_ = context.Operators.And(t_, x_);
				var aa_ = FHIRHelpers_4_3_000.ToInterval(o_);
				var ab_ = context.Operators.End(aa_);
				var ac_ = this.Measurement_Period();
				var ad_ = context.Operators.In<CqlDateTime>(ab_, ac_, "day");
				var ae_ = context.Operators.And(y_, ad_);

				return ae_;
			};
			var i_ = context.Operators.Where<Tuple_BLEMZbHGbhMbZiIgCJaASVTUS>((IEnumerable<Tuple_BLEMZbHGbhMbZiIgCJaASVTUS>)g_, h_);
			Task j_(Tuple_BLEMZbHGbhMbZiIgCJaASVTUS FirstReferral) => 
				ConsultantReportObtained;
			var k_ = context.Operators.Select<Tuple_BLEMZbHGbhMbZiIgCJaASVTUS, Task>(i_, j_);

			return k_;
		};
		var d_ = context.Operators.SelectMany<Task, Task>(b_, c_);
		var e_ = context.Operators.Exists<Task>(d_);

		return e_;
	}

    [CqlDeclaration("Referring Clinician Receives Consultant Report to Close Referral Loop")]
	public bool? Referring_Clinician_Receives_Consultant_Report_to_Close_Referral_Loop() => 
		__Referring_Clinician_Receives_Consultant_Report_to_Close_Referral_Loop.Value;

	private bool? Numerator_Value()
	{
		var a_ = this.Referring_Clinician_Receives_Consultant_Report_to_Close_Referral_Loop();

		return a_;
	}

    [CqlDeclaration("Numerator")]
	public bool? Numerator() => 
		__Numerator.Value;

}

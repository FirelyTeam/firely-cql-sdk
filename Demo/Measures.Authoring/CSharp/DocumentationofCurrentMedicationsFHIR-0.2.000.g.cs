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
[CqlLibrary("DocumentationofCurrentMedicationsFHIR", "0.2.000")]
public class DocumentationofCurrentMedicationsFHIR_0_2_000
{


    internal CqlContext context;

    #region Cached values

    internal Lazy<CqlValueSet> __Encounter_to_Document_Medications;
    internal Lazy<CqlValueSet> __Medical_Reason;
    internal Lazy<CqlCode> __Documentation_of_current_medications__procedure_;
    internal Lazy<CqlCode[]> __SNOMEDCT;
    internal Lazy<CqlInterval<CqlDateTime>> __Measurement_Period;
    internal Lazy<Patient> __Patient;
    internal Lazy<Tuple_HPcCiDPXQfZTXIORThMLfTQDR> __SDE_Ethnicity;
    internal Lazy<IEnumerable<Tuple_GPRWMPNAYaJRiGDFSTLJOPeIJ>> __SDE_Payer;
    internal Lazy<Tuple_HPcCiDPXQfZTXIORThMLfTQDR> __SDE_Race;
    internal Lazy<CqlCode> __SDE_Sex;
    internal Lazy<IEnumerable<Encounter>> __Qualifying_Encounter_during_day_of_Measurement_Period;
    internal Lazy<IEnumerable<Encounter>> __Initial_Population;
    internal Lazy<IEnumerable<Encounter>> __Denominator;
    internal Lazy<IEnumerable<Encounter>> __Numerator;
    internal Lazy<IEnumerable<Encounter>> __Denominator_Exceptions;

    #endregion
    public DocumentationofCurrentMedicationsFHIR_0_2_000(CqlContext context)
    {
        this.context = context ?? throw new ArgumentNullException("context");

        FHIRHelpers_4_3_000 = new FHIRHelpers_4_3_000(context);
        QICoreCommon_2_0_000 = new QICoreCommon_2_0_000(context);
        SupplementalDataElements_3_4_000 = new SupplementalDataElements_3_4_000(context);

        __Encounter_to_Document_Medications = new Lazy<CqlValueSet>(this.Encounter_to_Document_Medications_Value);
        __Medical_Reason = new Lazy<CqlValueSet>(this.Medical_Reason_Value);
        __Documentation_of_current_medications__procedure_ = new Lazy<CqlCode>(this.Documentation_of_current_medications__procedure__Value);
        __SNOMEDCT = new Lazy<CqlCode[]>(this.SNOMEDCT_Value);
        __Measurement_Period = new Lazy<CqlInterval<CqlDateTime>>(this.Measurement_Period_Value);
        __Patient = new Lazy<Patient>(this.Patient_Value);
        __SDE_Ethnicity = new Lazy<Tuple_HPcCiDPXQfZTXIORThMLfTQDR>(this.SDE_Ethnicity_Value);
        __SDE_Payer = new Lazy<IEnumerable<Tuple_GPRWMPNAYaJRiGDFSTLJOPeIJ>>(this.SDE_Payer_Value);
        __SDE_Race = new Lazy<Tuple_HPcCiDPXQfZTXIORThMLfTQDR>(this.SDE_Race_Value);
        __SDE_Sex = new Lazy<CqlCode>(this.SDE_Sex_Value);
        __Qualifying_Encounter_during_day_of_Measurement_Period = new Lazy<IEnumerable<Encounter>>(this.Qualifying_Encounter_during_day_of_Measurement_Period_Value);
        __Initial_Population = new Lazy<IEnumerable<Encounter>>(this.Initial_Population_Value);
        __Denominator = new Lazy<IEnumerable<Encounter>>(this.Denominator_Value);
        __Numerator = new Lazy<IEnumerable<Encounter>>(this.Numerator_Value);
        __Denominator_Exceptions = new Lazy<IEnumerable<Encounter>>(this.Denominator_Exceptions_Value);
    }
    #region Dependencies

    public FHIRHelpers_4_3_000 FHIRHelpers_4_3_000 { get; }
    public QICoreCommon_2_0_000 QICoreCommon_2_0_000 { get; }
    public SupplementalDataElements_3_4_000 SupplementalDataElements_3_4_000 { get; }

    #endregion

	private CqlValueSet Encounter_to_Document_Medications_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.600.1.1834", null);

    [CqlDeclaration("Encounter to Document Medications")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.600.1.1834")]
	public CqlValueSet Encounter_to_Document_Medications() => 
		__Encounter_to_Document_Medications.Value;

	private CqlValueSet Medical_Reason_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1007", null);

    [CqlDeclaration("Medical Reason")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1007")]
	public CqlValueSet Medical_Reason() => 
		__Medical_Reason.Value;

	private CqlCode Documentation_of_current_medications__procedure__Value() => 
		new CqlCode("428191000124101", "http://snomed.info/sct", null, null);

    [CqlDeclaration("Documentation of current medications (procedure)")]
	public CqlCode Documentation_of_current_medications__procedure_() => 
		__Documentation_of_current_medications__procedure_.Value;

	private CqlCode[] SNOMEDCT_Value()
	{
		var a_ = new CqlCode[]
		{
			new CqlCode("428191000124101", "http://snomed.info/sct", null, null),
		};

		return a_;
	}

    [CqlDeclaration("SNOMEDCT")]
	public CqlCode[] SNOMEDCT() => 
		__SNOMEDCT.Value;

	private CqlInterval<CqlDateTime> Measurement_Period_Value()
	{
		var a_ = context.Operators.DateTime(2025, 1, 1, 0, 0, 0, 0, default);
		var b_ = context.Operators.DateTime(2026, 1, 1, 0, 0, 0, 0, default);
		var c_ = context.Operators.Interval(a_, b_, true, false);
		var d_ = context.ResolveParameter("DocumentationofCurrentMedicationsFHIR-0.2.000", "Measurement Period", c_);

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

	private IEnumerable<Encounter> Qualifying_Encounter_during_day_of_Measurement_Period_Value()
	{
		var a_ = this.Encounter_to_Document_Medications();
		var b_ = context.Operators.RetrieveByValueSet<Encounter>(a_, null);
		bool? c_(Encounter ValidEncounter)
		{
			var e_ = ValidEncounter?.StatusElement;
			var f_ = e_?.Value;
			var g_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(f_);
			var h_ = context.Operators.Equal(g_, "finished");
			var i_ = this.Measurement_Period();
			var j_ = ValidEncounter?.Period;
			var k_ = FHIRHelpers_4_3_000.ToInterval(j_);
			var l_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(i_, k_, "day");
			var m_ = context.Operators.And(h_, l_);

			return m_;
		};
		var d_ = context.Operators.Where<Encounter>(b_, c_);

		return d_;
	}

    [CqlDeclaration("Qualifying Encounter during day of Measurement Period")]
	public IEnumerable<Encounter> Qualifying_Encounter_during_day_of_Measurement_Period() => 
		__Qualifying_Encounter_during_day_of_Measurement_Period.Value;

	private IEnumerable<Encounter> Initial_Population_Value()
	{
		var a_ = this.Qualifying_Encounter_during_day_of_Measurement_Period();

		return a_;
	}

    [CqlDeclaration("Initial Population")]
	public IEnumerable<Encounter> Initial_Population() => 
		__Initial_Population.Value;

	private IEnumerable<Encounter> Denominator_Value()
	{
		var a_ = this.Initial_Population();

		return a_;
	}

    [CqlDeclaration("Denominator")]
	public IEnumerable<Encounter> Denominator() => 
		__Denominator.Value;

	private IEnumerable<Encounter> Numerator_Value()
	{
		var a_ = this.Qualifying_Encounter_during_day_of_Measurement_Period();
		IEnumerable<Encounter> b_(Encounter QualifyingEncounter)
		{
			var d_ = this.Documentation_of_current_medications__procedure_();
			var e_ = context.Operators.ToList<CqlCode>(d_);
			var f_ = context.Operators.RetrieveByCodes<Procedure>(e_, null);
			bool? g_(Procedure MedicationsDocumented)
			{
				var k_ = MedicationsDocumented?.Performed;
				var l_ = FHIRHelpers_4_3_000.ToValue(k_);
				var m_ = QICoreCommon_2_0_000.toInterval(l_);
				var n_ = context.Operators.End(m_);
				var o_ = QualifyingEncounter?.Period;
				var p_ = FHIRHelpers_4_3_000.ToInterval(o_);
				var q_ = context.Operators.In<CqlDateTime>(n_, p_, null);
				var r_ = MedicationsDocumented?.StatusElement;
				var s_ = r_?.Value;
				var t_ = context.Operators.Convert<string>(s_);
				var u_ = context.Operators.Equal(t_, "completed");
				var v_ = context.Operators.And(q_, u_);

				return v_;
			};
			var h_ = context.Operators.Where<Procedure>(f_, g_);
			Encounter i_(Procedure MedicationsDocumented) => 
				QualifyingEncounter;
			var j_ = context.Operators.Select<Procedure, Encounter>(h_, i_);

			return j_;
		};
		var c_ = context.Operators.SelectMany<Encounter, Encounter>(a_, b_);

		return c_;
	}

    [CqlDeclaration("Numerator")]
	public IEnumerable<Encounter> Numerator() => 
		__Numerator.Value;

	private IEnumerable<Encounter> Denominator_Exceptions_Value()
	{
		var a_ = this.Qualifying_Encounter_during_day_of_Measurement_Period();
		IEnumerable<Encounter> b_(Encounter QualifyingEncounter)
		{
			var d_ = this.Documentation_of_current_medications__procedure_();
			var e_ = context.Operators.ToList<CqlCode>(d_);
			var f_ = context.Operators.RetrieveByCodes<Procedure>(e_, null);
			bool? g_(Procedure MedicationsNotDocumented)
			{
				bool? k_(Extension @this)
				{
					var ae_ = @this?.Url;
					var af_ = context.Operators.Convert<FhirUri>(ae_);
					var ag_ = FHIRHelpers_4_3_000.ToString(af_);
					var ah_ = context.Operators.Equal(ag_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-recorded");

					return ah_;
				};
				var l_ = context.Operators.Where<Extension>((IEnumerable<Extension>)((MedicationsNotDocumented is DomainResource)
						? ((MedicationsNotDocumented as DomainResource).Extension)
						: null), k_);
				DataType m_(Extension @this)
				{
					var ai_ = @this?.Value;

					return ai_;
				};
				var n_ = context.Operators.Select<Extension, DataType>(l_, m_);
				var o_ = context.Operators.SingletonFrom<DataType>(n_);
				var p_ = context.Operators.Convert<CqlDateTime>(o_);
				var q_ = QualifyingEncounter?.Period;
				var r_ = FHIRHelpers_4_3_000.ToInterval(q_);
				var s_ = context.Operators.In<CqlDateTime>(p_, r_, null);
				var t_ = MedicationsNotDocumented?.StatusElement;
				var u_ = t_?.Value;
				var v_ = context.Operators.Convert<string>(u_);
				var w_ = context.Operators.Equal(v_, "not-done");
				var x_ = context.Operators.And(s_, w_);
				var y_ = MedicationsNotDocumented?.ReasonCode;
				CqlConcept z_(CodeableConcept @this)
				{
					var aj_ = FHIRHelpers_4_3_000.ToConcept(@this);

					return aj_;
				};
				var aa_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)y_, z_);
				var ab_ = this.Medical_Reason();
				var ac_ = context.Operators.ConceptsInValueSet(aa_, ab_);
				var ad_ = context.Operators.And(x_, ac_);

				return ad_;
			};
			var h_ = context.Operators.Where<Procedure>(f_, g_);
			Encounter i_(Procedure MedicationsNotDocumented) => 
				QualifyingEncounter;
			var j_ = context.Operators.Select<Procedure, Encounter>(h_, i_);

			return j_;
		};
		var c_ = context.Operators.SelectMany<Encounter, Encounter>(a_, b_);

		return c_;
	}

    [CqlDeclaration("Denominator Exceptions")]
	public IEnumerable<Encounter> Denominator_Exceptions() => 
		__Denominator_Exceptions.Value;

}

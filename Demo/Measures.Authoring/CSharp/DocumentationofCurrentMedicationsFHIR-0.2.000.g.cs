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
    internal Lazy<(IEnumerable<CqlCode> codes, string display)?> __SDE_Ethnicity;
    internal Lazy<IEnumerable<(CqlConcept code, CqlInterval<CqlDateTime> period)?>> __SDE_Payer;
    internal Lazy<(IEnumerable<CqlCode> codes, string display)?> __SDE_Race;
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
        __SDE_Ethnicity = new Lazy<(IEnumerable<CqlCode> codes, string display)?>(this.SDE_Ethnicity_Value);
        __SDE_Payer = new Lazy<IEnumerable<(CqlConcept code, CqlInterval<CqlDateTime> period)?>>(this.SDE_Payer_Value);
        __SDE_Race = new Lazy<(IEnumerable<CqlCode> codes, string display)?>(this.SDE_Race_Value);
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
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.600.1.1834", default);

    [CqlDeclaration("Encounter to Document Medications")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.600.1.1834")]
	public CqlValueSet Encounter_to_Document_Medications() => 
		__Encounter_to_Document_Medications.Value;

	private CqlValueSet Medical_Reason_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1007", default);

    [CqlDeclaration("Medical Reason")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1007")]
	public CqlValueSet Medical_Reason() => 
		__Medical_Reason.Value;

	private CqlCode Documentation_of_current_medications__procedure__Value() => 
		new CqlCode("428191000124101", "http://snomed.info/sct", default, default);

    [CqlDeclaration("Documentation of current medications (procedure)")]
	public CqlCode Documentation_of_current_medications__procedure_() => 
		__Documentation_of_current_medications__procedure_.Value;

	private CqlCode[] SNOMEDCT_Value()
	{
		CqlCode[] a_ = [
			new CqlCode("428191000124101", "http://snomed.info/sct", default, default),
		];

		return a_;
	}

    [CqlDeclaration("SNOMEDCT")]
	public CqlCode[] SNOMEDCT() => 
		__SNOMEDCT.Value;

	private CqlInterval<CqlDateTime> Measurement_Period_Value()
	{
		CqlDateTime a_ = context.Operators.DateTime(2025, 1, 1, 0, 0, 0, 0, default);
		CqlDateTime b_ = context.Operators.DateTime(2026, 1, 1, 0, 0, 0, 0, default);
		CqlInterval<CqlDateTime> c_ = context.Operators.Interval(a_, b_, true, false);
		object d_ = context.ResolveParameter("DocumentationofCurrentMedicationsFHIR-0.2.000", "Measurement Period", c_);

		return (CqlInterval<CqlDateTime>)d_;
	}

    [CqlDeclaration("Measurement Period")]
	public CqlInterval<CqlDateTime> Measurement_Period() => 
		__Measurement_Period.Value;

	private Patient Patient_Value()
	{
		IEnumerable<Patient> a_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-patient"));
		Patient b_ = context.Operators.SingletonFrom<Patient>(a_);

		return b_;
	}

    [CqlDeclaration("Patient")]
	public Patient Patient() => 
		__Patient.Value;

	private (IEnumerable<CqlCode> codes, string display)? SDE_Ethnicity_Value()
	{
		(IEnumerable<CqlCode> codes, string display)? a_ = SupplementalDataElements_3_4_000.SDE_Ethnicity();

		return a_;
	}

    [CqlDeclaration("SDE Ethnicity")]
	public (IEnumerable<CqlCode> codes, string display)? SDE_Ethnicity() => 
		__SDE_Ethnicity.Value;

	private IEnumerable<(CqlConcept code, CqlInterval<CqlDateTime> period)?> SDE_Payer_Value()
	{
		IEnumerable<(CqlConcept code, CqlInterval<CqlDateTime> period)?> a_ = SupplementalDataElements_3_4_000.SDE_Payer();

		return a_;
	}

    [CqlDeclaration("SDE Payer")]
	public IEnumerable<(CqlConcept code, CqlInterval<CqlDateTime> period)?> SDE_Payer() => 
		__SDE_Payer.Value;

	private (IEnumerable<CqlCode> codes, string display)? SDE_Race_Value()
	{
		(IEnumerable<CqlCode> codes, string display)? a_ = SupplementalDataElements_3_4_000.SDE_Race();

		return a_;
	}

    [CqlDeclaration("SDE Race")]
	public (IEnumerable<CqlCode> codes, string display)? SDE_Race() => 
		__SDE_Race.Value;

	private CqlCode SDE_Sex_Value()
	{
		CqlCode a_ = SupplementalDataElements_3_4_000.SDE_Sex();

		return a_;
	}

    [CqlDeclaration("SDE Sex")]
	public CqlCode SDE_Sex() => 
		__SDE_Sex.Value;

	private IEnumerable<Encounter> Qualifying_Encounter_during_day_of_Measurement_Period_Value()
	{
		CqlValueSet a_ = this.Encounter_to_Document_Medications();
		IEnumerable<Encounter> b_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
		bool? c_(Encounter ValidEncounter)
		{
			Code<Encounter.EncounterStatus> e_ = ValidEncounter?.StatusElement;
			Encounter.EncounterStatus? f_ = e_?.Value;
			Code<Encounter.EncounterStatus> g_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(f_);
			bool? h_ = context.Operators.Equal(g_, "finished");
			CqlInterval<CqlDateTime> i_ = this.Measurement_Period();
			Period j_ = ValidEncounter?.Period;
			CqlInterval<CqlDateTime> k_ = FHIRHelpers_4_3_000.ToInterval(j_);
			bool? l_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(i_, k_, "day");
			bool? m_ = context.Operators.And(h_, l_);

			return m_;
		};
		IEnumerable<Encounter> d_ = context.Operators.Where<Encounter>(b_, c_);

		return d_;
	}

    [CqlDeclaration("Qualifying Encounter during day of Measurement Period")]
	public IEnumerable<Encounter> Qualifying_Encounter_during_day_of_Measurement_Period() => 
		__Qualifying_Encounter_during_day_of_Measurement_Period.Value;

	private IEnumerable<Encounter> Initial_Population_Value()
	{
		IEnumerable<Encounter> a_ = this.Qualifying_Encounter_during_day_of_Measurement_Period();

		return a_;
	}

    [CqlDeclaration("Initial Population")]
	public IEnumerable<Encounter> Initial_Population() => 
		__Initial_Population.Value;

	private IEnumerable<Encounter> Denominator_Value()
	{
		IEnumerable<Encounter> a_ = this.Initial_Population();

		return a_;
	}

    [CqlDeclaration("Denominator")]
	public IEnumerable<Encounter> Denominator() => 
		__Denominator.Value;

	private IEnumerable<Encounter> Numerator_Value()
	{
		IEnumerable<Encounter> a_ = this.Qualifying_Encounter_during_day_of_Measurement_Period();
		IEnumerable<Encounter> b_(Encounter QualifyingEncounter)
		{
			CqlCode d_ = this.Documentation_of_current_medications__procedure_();
			IEnumerable<CqlCode> e_ = context.Operators.ToList<CqlCode>(d_);
			IEnumerable<Procedure> f_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, default, e_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
			bool? g_(Procedure MedicationsDocumented)
			{
				DataType k_ = MedicationsDocumented?.Performed;
				object l_ = FHIRHelpers_4_3_000.ToValue(k_);
				CqlInterval<CqlDateTime> m_ = QICoreCommon_2_0_000.toInterval(l_);
				CqlDateTime n_ = context.Operators.End(m_);
				Period o_ = QualifyingEncounter?.Period;
				CqlInterval<CqlDateTime> p_ = FHIRHelpers_4_3_000.ToInterval(o_);
				bool? q_ = context.Operators.In<CqlDateTime>(n_, p_, default);
				Code<EventStatus> r_ = MedicationsDocumented?.StatusElement;
				EventStatus? s_ = r_?.Value;
				string t_ = context.Operators.Convert<string>(s_);
				bool? u_ = context.Operators.Equal(t_, "completed");
				bool? v_ = context.Operators.And(q_, u_);

				return v_;
			};
			IEnumerable<Procedure> h_ = context.Operators.Where<Procedure>(f_, g_);
			Encounter i_(Procedure MedicationsDocumented) => 
				QualifyingEncounter;
			IEnumerable<Encounter> j_ = context.Operators.Select<Procedure, Encounter>(h_, i_);

			return j_;
		};
		IEnumerable<Encounter> c_ = context.Operators.SelectMany<Encounter, Encounter>(a_, b_);

		return c_;
	}

    [CqlDeclaration("Numerator")]
	public IEnumerable<Encounter> Numerator() => 
		__Numerator.Value;

	private IEnumerable<Encounter> Denominator_Exceptions_Value()
	{
		IEnumerable<Encounter> a_ = this.Qualifying_Encounter_during_day_of_Measurement_Period();
		IEnumerable<Encounter> b_(Encounter QualifyingEncounter)
		{
			CqlCode d_ = this.Documentation_of_current_medications__procedure_();
			IEnumerable<CqlCode> e_ = context.Operators.ToList<CqlCode>(d_);
			IEnumerable<Procedure> f_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, default, e_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedurenotdone"));
			bool? g_(Procedure MedicationsNotDocumented)
			{
				bool? k_(Extension @this)
				{
					string ae_ = @this?.Url;
					FhirString af_ = context.Operators.Convert<FhirString>(ae_);
					string ag_ = FHIRHelpers_4_3_000.ToString(af_);
					bool? ah_ = context.Operators.Equal(ag_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-recorded");

					return ah_;
				};
				IEnumerable<Extension> l_ = context.Operators.Where<Extension>((IEnumerable<Extension>)(MedicationsNotDocumented is DomainResource
						? (MedicationsNotDocumented as DomainResource).Extension
						: default), k_);
				DataType m_(Extension @this)
				{
					DataType ai_ = @this?.Value;

					return ai_;
				};
				IEnumerable<DataType> n_ = context.Operators.Select<Extension, DataType>(l_, m_);
				DataType o_ = context.Operators.SingletonFrom<DataType>(n_);
				CqlDateTime p_ = context.Operators.Convert<CqlDateTime>(o_);
				Period q_ = QualifyingEncounter?.Period;
				CqlInterval<CqlDateTime> r_ = FHIRHelpers_4_3_000.ToInterval(q_);
				bool? s_ = context.Operators.In<CqlDateTime>(p_, r_, default);
				Code<EventStatus> t_ = MedicationsNotDocumented?.StatusElement;
				EventStatus? u_ = t_?.Value;
				string v_ = context.Operators.Convert<string>(u_);
				bool? w_ = context.Operators.Equal(v_, "not-done");
				bool? x_ = context.Operators.And(s_, w_);
				List<CodeableConcept> y_ = MedicationsNotDocumented?.ReasonCode;
				CqlConcept z_(CodeableConcept @this)
				{
					CqlConcept aj_ = FHIRHelpers_4_3_000.ToConcept(@this);

					return aj_;
				};
				IEnumerable<CqlConcept> aa_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)y_, z_);
				CqlValueSet ab_ = this.Medical_Reason();
				bool? ac_ = context.Operators.ConceptsInValueSet(aa_, ab_);
				bool? ad_ = context.Operators.And(x_, ac_);

				return ad_;
			};
			IEnumerable<Procedure> h_ = context.Operators.Where<Procedure>(f_, g_);
			Encounter i_(Procedure MedicationsNotDocumented) => 
				QualifyingEncounter;
			IEnumerable<Encounter> j_ = context.Operators.Select<Procedure, Encounter>(h_, i_);

			return j_;
		};
		IEnumerable<Encounter> c_ = context.Operators.SelectMany<Encounter, Encounter>(a_, b_);

		return c_;
	}

    [CqlDeclaration("Denominator Exceptions")]
	public IEnumerable<Encounter> Denominator_Exceptions() => 
		__Denominator_Exceptions.Value;

}

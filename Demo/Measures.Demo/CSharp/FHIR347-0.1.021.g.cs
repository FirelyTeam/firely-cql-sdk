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
[System.CodeDom.Compiler.GeneratedCode(".NET Code Generation", "2.0.5.0")]
[CqlLibrary("FHIR347", "0.1.021")]
public partial class FHIR347_0_1_021 : ILibrary, ISingleton<FHIR347_0_1_021>
{
    private FHIR347_0_1_021() {}

    public static FHIR347_0_1_021 Instance { get; } = new();

    #region Library Members
    public string Name => "FHIR347";
    public string Version => "0.1.021";
    public ILibrary[] Dependencies => [FHIRHelpers_4_0_001.Instance, SupplementalDataElementsFHIR4_2_0_000.Instance, MATGlobalCommonFunctionsFHIR4_6_1_000.Instance];
    #endregion Library Members

    [CqlDeclaration("Annual Wellness Visit")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1240")]
	public CqlValueSet Annual_Wellness_Visit(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1240", default);


    [CqlDeclaration("Atherosclerosis and Peripheral Arterial Disease")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1047.21")]
	public CqlValueSet Atherosclerosis_and_Peripheral_Arterial_Disease(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1047.21", default);


    [CqlDeclaration("Breastfeeding")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1047.73")]
	public CqlValueSet Breastfeeding(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1047.73", default);


    [CqlDeclaration("CABG Surgeries")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.666.5.694")]
	public CqlValueSet CABG_Surgeries(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.666.5.694", default);


    [CqlDeclaration("CABG, PCI Procedure")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1138.566")]
	public CqlValueSet CABG__PCI_Procedure(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1138.566", default);


    [CqlDeclaration("Carotid Intervention")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.204")]
	public CqlValueSet Carotid_Intervention(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.204", default);


    [CqlDeclaration("Cerebrovascular Disease, Stroke, TIA")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1047.44")]
	public CqlValueSet Cerebrovascular_Disease__Stroke__TIA(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1047.44", default);


    [CqlDeclaration("Diabetes")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.103.12.1001")]
	public CqlValueSet Diabetes(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.103.12.1001", default);


    [CqlDeclaration("End Stage Renal Disease")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.353")]
	public CqlValueSet End_Stage_Renal_Disease(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.353", default);


    [CqlDeclaration("Hepatitis A")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.110.12.1024")]
	public CqlValueSet Hepatitis_A(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.110.12.1024", default);


    [CqlDeclaration("Hepatitis B")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.67.1.101.1.269")]
	public CqlValueSet Hepatitis_B(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.67.1.101.1.269", default);


    [CqlDeclaration("High Intensity Statin Therapy")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1572")]
	public CqlValueSet High_Intensity_Statin_Therapy(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1572", default);


    [CqlDeclaration("Hospice Care Ambulatory")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1584")]
	public CqlValueSet Hospice_Care_Ambulatory(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1584", default);


    [CqlDeclaration("Hypercholesterolemia")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1047.100")]
	public CqlValueSet Hypercholesterolemia(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1047.100", default);


    [CqlDeclaration("Ischemic Heart Disease or Other Related Diagnoses")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1047.46")]
	public CqlValueSet Ischemic_Heart_Disease_or_Other_Related_Diagnoses(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1047.46", default);


    [CqlDeclaration("LDL Cholesterol")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1573")]
	public CqlValueSet LDL_Cholesterol(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1573", default);


    [CqlDeclaration("Liver Disease")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1047.42")]
	public CqlValueSet Liver_Disease(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1047.42", default);


    [CqlDeclaration("Low Intensity Statin Therapy")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1574")]
	public CqlValueSet Low_Intensity_Statin_Therapy(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1574", default);


    [CqlDeclaration("Moderate Intensity Statin Therapy")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1575")]
	public CqlValueSet Moderate_Intensity_Statin_Therapy(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1575", default);


    [CqlDeclaration("Myocardial Infarction")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.403")]
	public CqlValueSet Myocardial_Infarction(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.403", default);


    [CqlDeclaration("Office Visit")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1001")]
	public CqlValueSet Office_Visit(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1001", default);


    [CqlDeclaration("Outpatient Consultation")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1008")]
	public CqlValueSet Outpatient_Consultation(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1008", default);


    [CqlDeclaration("Outpatient Encounters for Preventive Care")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1576")]
	public CqlValueSet Outpatient_Encounters_for_Preventive_Care(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1576", default);


    [CqlDeclaration("Palliative Care Encounter")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.600.1.1575")]
	public CqlValueSet Palliative_Care_Encounter(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.600.1.1575", default);


    [CqlDeclaration("Palliative or Hospice Care")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.600.1.1579")]
	public CqlValueSet Palliative_or_Hospice_Care(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.600.1.1579", default);


    [CqlDeclaration("PCI")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1045.67")]
	public CqlValueSet PCI(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1045.67", default);


    [CqlDeclaration("Pregnancy or Other Related Diagnoses")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.600.1.1623")]
	public CqlValueSet Pregnancy_or_Other_Related_Diagnoses(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.600.1.1623", default);


    [CqlDeclaration("Preventive Care Services - Established Office Visit, 18 and Up")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1025")]
	public CqlValueSet Preventive_Care_Services___Established_Office_Visit__18_and_Up(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1025", default);


    [CqlDeclaration("Preventive Care Services - Other")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1030")]
	public CqlValueSet Preventive_Care_Services___Other(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1030", default);


    [CqlDeclaration("Preventive Care Services-Individual Counseling")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1026")]
	public CqlValueSet Preventive_Care_Services_Individual_Counseling(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1026", default);


    [CqlDeclaration("Preventive Care Services-Initial Office Visit, 18 and Up")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1023")]
	public CqlValueSet Preventive_Care_Services_Initial_Office_Visit__18_and_Up(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1023", default);


    [CqlDeclaration("Rhabdomyolysis")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1047.102")]
	public CqlValueSet Rhabdomyolysis(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1047.102", default);


    [CqlDeclaration("Stable and Unstable Angina")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1047.47")]
	public CqlValueSet Stable_and_Unstable_Angina(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1047.47", default);


    [CqlDeclaration("Statin Allergen")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1110.42")]
	public CqlValueSet Statin_Allergen(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1110.42", default);


    [CqlDeclaration("Statin Associated Muscle Symptoms")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1108.85")]
	public CqlValueSet Statin_Associated_Muscle_Symptoms(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1108.85", default);


    [CqlDeclaration("Encounter for palliative care")]
	public CqlCode Encounter_for_palliative_care(CqlContext context) => 
		new CqlCode("Z51.5", "http://hl7.org/fhir/sid/icd-10-cm", default, default);


    [CqlDeclaration("ICD10CM")]
	public CqlCode[] ICD10CM(CqlContext context)
	{
		CqlCode[] a_ = [
			new CqlCode("Z51.5", "http://hl7.org/fhir/sid/icd-10-cm", default, default),
		];

		return a_;
	}


    [CqlDeclaration("Measurement Period")]
	public CqlInterval<CqlDateTime> Measurement_Period(CqlContext context)
	{
		object a_ = context.ResolveParameter("FHIR347-0.1.021", "Measurement Period", null);

		return (CqlInterval<CqlDateTime>)a_;
	}


    [CqlDeclaration("Patient")]
	public Patient Patient(CqlContext context)
	{
		IEnumerable<Patient> a_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/StructureDefinition/Patient"));
		Patient b_ = context.Operators.SingletonFrom<Patient>(a_);

		return b_;
	}


    [CqlDeclaration("ASCVD Diagnosis or Procedure before End of Measurement Period")]
	public IEnumerable<object> ASCVD_Diagnosis_or_Procedure_before_End_of_Measurement_Period(CqlContext context)
	{
		CqlValueSet a_ = this.Myocardial_Infarction(context);
		IEnumerable<Condition> b_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/StructureDefinition/Condition"));
		CqlValueSet c_ = this.Cerebrovascular_Disease__Stroke__TIA(context);
		IEnumerable<Condition> d_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, c_, default, "http://hl7.org/fhir/StructureDefinition/Condition"));
		IEnumerable<Condition> e_ = context.Operators.Union<Condition>(b_, d_);
		CqlValueSet f_ = this.Atherosclerosis_and_Peripheral_Arterial_Disease(context);
		IEnumerable<Condition> g_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, f_, default, "http://hl7.org/fhir/StructureDefinition/Condition"));
		CqlValueSet h_ = this.Ischemic_Heart_Disease_or_Other_Related_Diagnoses(context);
		IEnumerable<Condition> i_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, h_, default, "http://hl7.org/fhir/StructureDefinition/Condition"));
		IEnumerable<Condition> j_ = context.Operators.Union<Condition>(g_, i_);
		IEnumerable<Condition> k_ = context.Operators.Union<Condition>(e_, j_);
		CqlValueSet l_ = this.Stable_and_Unstable_Angina(context);
		IEnumerable<Condition> m_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, l_, default, "http://hl7.org/fhir/StructureDefinition/Condition"));
		IEnumerable<Condition> n_ = context.Operators.Union<Condition>(k_, m_);
		bool? o_(Condition ASCVDDiagnosis)
		{
			CqlInterval<CqlDateTime> ae_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Prevalence_Period(context, ASCVDDiagnosis);
			CqlDateTime af_ = context.Operators.Start(ae_);
			CqlInterval<CqlDateTime> ag_ = this.Measurement_Period(context);
			CqlDateTime ah_ = context.Operators.End(ag_);
			bool? ai_ = context.Operators.Before(af_, ah_, default);

			return ai_;
		};
		IEnumerable<Condition> p_ = context.Operators.Where<Condition>(n_, o_);
		CqlValueSet q_ = this.PCI(context);
		IEnumerable<Procedure> r_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, q_, default, "http://hl7.org/fhir/StructureDefinition/Procedure"));
		CqlValueSet s_ = this.CABG_Surgeries(context);
		IEnumerable<Procedure> t_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, s_, default, "http://hl7.org/fhir/StructureDefinition/Procedure"));
		IEnumerable<Procedure> u_ = context.Operators.Union<Procedure>(r_, t_);
		CqlValueSet v_ = this.Carotid_Intervention(context);
		IEnumerable<Procedure> w_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, v_, default, "http://hl7.org/fhir/StructureDefinition/Procedure"));
		CqlValueSet x_ = this.CABG__PCI_Procedure(context);
		IEnumerable<Procedure> y_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, x_, default, "http://hl7.org/fhir/StructureDefinition/Procedure"));
		IEnumerable<Procedure> z_ = context.Operators.Union<Procedure>(w_, y_);
		IEnumerable<Procedure> aa_ = context.Operators.Union<Procedure>(u_, z_);
		bool? ab_(Procedure ASCVDProcedure)
		{
			DataType aj_ = ASCVDProcedure?.Performed;
			CqlInterval<CqlDateTime> ak_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, aj_);
			CqlDateTime al_ = context.Operators.Start(ak_);
			CqlInterval<CqlDateTime> am_ = this.Measurement_Period(context);
			CqlDateTime an_ = context.Operators.End(am_);
			bool? ao_ = context.Operators.Before(al_, an_, default);
			Code<EventStatus> ap_ = ASCVDProcedure?.StatusElement;
			string aq_ = FHIRHelpers_4_0_001.Instance.ToString(context, ap_);
			bool? ar_ = context.Operators.Equal(aq_, "completed");
			bool? as_ = context.Operators.And(ao_, ar_);

			return as_;
		};
		IEnumerable<Procedure> ac_ = context.Operators.Where<Procedure>(aa_, ab_);
		IEnumerable<object> ad_ = context.Operators.Union<object>(p_ as IEnumerable<object>, ac_ as IEnumerable<object>);

		return ad_;
	}


    [CqlDeclaration("Qualifying Encounter during Measurement Period")]
	public IEnumerable<Encounter> Qualifying_Encounter_during_Measurement_Period(CqlContext context)
	{
		CqlValueSet a_ = this.Annual_Wellness_Visit(context);
		IEnumerable<Encounter> b_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/StructureDefinition/Encounter"));
		CqlValueSet c_ = this.Office_Visit(context);
		IEnumerable<Encounter> d_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, c_, default, "http://hl7.org/fhir/StructureDefinition/Encounter"));
		IEnumerable<Encounter> e_ = context.Operators.Union<Encounter>(b_, d_);
		CqlValueSet f_ = this.Outpatient_Consultation(context);
		IEnumerable<Encounter> g_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, f_, default, "http://hl7.org/fhir/StructureDefinition/Encounter"));
		CqlValueSet h_ = this.Outpatient_Encounters_for_Preventive_Care(context);
		IEnumerable<Encounter> i_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, h_, default, "http://hl7.org/fhir/StructureDefinition/Encounter"));
		IEnumerable<Encounter> j_ = context.Operators.Union<Encounter>(g_, i_);
		IEnumerable<Encounter> k_ = context.Operators.Union<Encounter>(e_, j_);
		CqlValueSet l_ = this.Preventive_Care_Services___Established_Office_Visit__18_and_Up(context);
		IEnumerable<Encounter> m_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, l_, default, "http://hl7.org/fhir/StructureDefinition/Encounter"));
		CqlValueSet n_ = this.Preventive_Care_Services___Other(context);
		IEnumerable<Encounter> o_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, n_, default, "http://hl7.org/fhir/StructureDefinition/Encounter"));
		IEnumerable<Encounter> p_ = context.Operators.Union<Encounter>(m_, o_);
		IEnumerable<Encounter> q_ = context.Operators.Union<Encounter>(k_, p_);
		CqlValueSet r_ = this.Preventive_Care_Services_Individual_Counseling(context);
		IEnumerable<Encounter> s_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, r_, default, "http://hl7.org/fhir/StructureDefinition/Encounter"));
		CqlValueSet t_ = this.Preventive_Care_Services_Initial_Office_Visit__18_and_Up(context);
		IEnumerable<Encounter> u_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, t_, default, "http://hl7.org/fhir/StructureDefinition/Encounter"));
		IEnumerable<Encounter> v_ = context.Operators.Union<Encounter>(s_, u_);
		IEnumerable<Encounter> w_ = context.Operators.Union<Encounter>(q_, v_);
		bool? x_(Encounter ValidEncounter)
		{
			CqlInterval<CqlDateTime> z_ = this.Measurement_Period(context);
			Period aa_ = ValidEncounter?.Period;
			CqlInterval<CqlDateTime> ab_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, aa_);
			bool? ac_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(z_, ab_, default);
			Code<Encounter.EncounterStatus> ad_ = ValidEncounter?.StatusElement;
			string ae_ = FHIRHelpers_4_0_001.Instance.ToString(context, ad_);
			bool? af_ = context.Operators.Equal(ae_, "finished");
			bool? ag_ = context.Operators.And(ac_, af_);

			return ag_;
		};
		IEnumerable<Encounter> y_ = context.Operators.Where<Encounter>(w_, x_);

		return y_;
	}


    [CqlDeclaration("Initial Population 1")]
	public bool? Initial_Population_1(CqlContext context)
	{
		IEnumerable<object> a_ = this.ASCVD_Diagnosis_or_Procedure_before_End_of_Measurement_Period(context);
		bool? b_ = context.Operators.Exists<object>(a_);
		IEnumerable<Encounter> c_ = this.Qualifying_Encounter_during_Measurement_Period(context);
		bool? d_ = context.Operators.Exists<Encounter>(c_);
		bool? e_ = context.Operators.And(b_, d_);

		return e_;
	}


    [CqlDeclaration("Denominator 1")]
	public bool? Denominator_1(CqlContext context)
	{
		bool? a_ = this.Initial_Population_1(context);

		return a_;
	}


    [CqlDeclaration("Patients Age 20 or Older at Start of Measurement Period")]
	public bool? Patients_Age_20_or_Older_at_Start_of_Measurement_Period(CqlContext context)
	{
		Patient a_ = this.Patient(context);
		Date b_ = a_?.BirthDateElement;
		string c_ = b_?.Value;
		CqlDateTime d_ = context.Operators.ConvertStringToDateTime(c_);
		CqlInterval<CqlDateTime> e_ = this.Measurement_Period(context);
		CqlDateTime f_ = context.Operators.Start(e_);
		int? g_ = context.Operators.CalculateAgeAt(d_, f_, "year");
		bool? h_ = context.Operators.GreaterOrEqual(g_, 20);

		return h_;
	}


    [CqlDeclaration("LDL Result Greater Than or Equal To 190")]
	public IEnumerable<Observation> LDL_Result_Greater_Than_or_Equal_To_190(CqlContext context)
	{
		CqlValueSet a_ = this.LDL_Cholesterol(context);
		IEnumerable<Observation> b_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/StructureDefinition/Observation"));
		bool? c_(Observation LDL)
		{
			DataType e_ = LDL?.Value;
			CqlQuantity f_ = FHIRHelpers_4_0_001.Instance.ToQuantity(context, e_ as Quantity);
			CqlQuantity g_ = context.Operators.Quantity(190m, "mg/dL");
			bool? h_ = context.Operators.GreaterOrEqual(f_, g_);
			DataType i_ = LDL?.Effective;
			CqlInterval<CqlDateTime> j_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, i_);
			CqlDateTime k_ = context.Operators.Start(j_);
			CqlInterval<CqlDateTime> l_ = this.Measurement_Period(context);
			CqlDateTime m_ = context.Operators.End(l_);
			bool? n_ = context.Operators.Before(k_, m_, default);
			bool? o_ = context.Operators.And(h_, n_);
			Code<ObservationStatus> p_ = LDL?.StatusElement;
			string q_ = FHIRHelpers_4_0_001.Instance.ToString(context, p_);
			string[] r_ = [
				"final",
				"amended",
				"corrected",
				"appended",
			];
			bool? s_ = context.Operators.In<string>(q_, r_ as IEnumerable<string>);
			bool? t_ = context.Operators.And(o_, s_);

			return t_;
		};
		IEnumerable<Observation> d_ = context.Operators.Where<Observation>(b_, c_);

		return d_;
	}


    [CqlDeclaration("Hypercholesterolemia Diagnosis")]
	public IEnumerable<Condition> Hypercholesterolemia_Diagnosis(CqlContext context)
	{
		CqlValueSet a_ = this.Hypercholesterolemia(context);
		IEnumerable<Condition> b_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/StructureDefinition/Condition"));
		bool? c_(Condition Hypercholesterolemia)
		{
			CqlInterval<CqlDateTime> e_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Prevalence_Period(context, Hypercholesterolemia);
			CqlDateTime f_ = context.Operators.Start(e_);
			CqlInterval<CqlDateTime> g_ = this.Measurement_Period(context);
			CqlDateTime h_ = context.Operators.End(g_);
			bool? i_ = context.Operators.Before(f_, h_, default);

			return i_;
		};
		IEnumerable<Condition> d_ = context.Operators.Where<Condition>(b_, c_);

		return d_;
	}


    [CqlDeclaration("Patients Age 20 Years and Older with LDL Cholesterol Result Greater than or Equal to 190 or Hypercholesterolemia without ASCVD")]
	public bool? Patients_Age_20_Years_and_Older_with_LDL_Cholesterol_Result_Greater_than_or_Equal_to_190_or_Hypercholesterolemia_without_ASCVD(CqlContext context)
	{
		bool? a_ = this.Patients_Age_20_or_Older_at_Start_of_Measurement_Period(context);
		IEnumerable<Observation> b_ = this.LDL_Result_Greater_Than_or_Equal_To_190(context);
		IEnumerable<Condition> c_ = this.Hypercholesterolemia_Diagnosis(context);
		IEnumerable<object> d_ = context.Operators.Union<object>(b_ as IEnumerable<object>, c_ as IEnumerable<object>);
		bool? e_ = context.Operators.Exists<object>(d_);
		bool? f_ = context.Operators.And(a_, e_);
		IEnumerable<object> g_ = this.ASCVD_Diagnosis_or_Procedure_before_End_of_Measurement_Period(context);
		bool? h_ = context.Operators.Exists<object>(g_);
		bool? i_ = context.Operators.Not(h_);
		bool? j_ = context.Operators.And(f_, i_);

		return j_;
	}


    [CqlDeclaration("Initial Population 2")]
	public bool? Initial_Population_2(CqlContext context)
	{
		bool? a_ = this.Patients_Age_20_Years_and_Older_with_LDL_Cholesterol_Result_Greater_than_or_Equal_to_190_or_Hypercholesterolemia_without_ASCVD(context);
		IEnumerable<Encounter> b_ = this.Qualifying_Encounter_during_Measurement_Period(context);
		bool? c_ = context.Operators.Exists<Encounter>(b_);
		bool? d_ = context.Operators.And(a_, c_);

		return d_;
	}


    [CqlDeclaration("Denominator 2")]
	public bool? Denominator_2(CqlContext context)
	{
		bool? a_ = this.Initial_Population_2(context);

		return a_;
	}


    [CqlDeclaration("Has Diabetes Diagnosis")]
	public bool? Has_Diabetes_Diagnosis(CqlContext context)
	{
		CqlValueSet a_ = this.Diabetes(context);
		IEnumerable<Condition> b_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/StructureDefinition/Condition"));
		bool? c_(Condition Diabetes)
		{
			CqlInterval<CqlDateTime> f_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Prevalence_Period(context, Diabetes);
			CqlInterval<CqlDateTime> g_ = this.Measurement_Period(context);
			bool? h_ = context.Operators.Overlaps(f_, g_, default);

			return h_;
		};
		IEnumerable<Condition> d_ = context.Operators.Where<Condition>(b_, c_);
		bool? e_ = context.Operators.Exists<Condition>(d_);

		return e_;
	}


    [CqlDeclaration("Patients Age 40 to 75 Years with Diabetes without ASCVD or LDL Greater than 190 or Hypercholesterolemia")]
	public bool? Patients_Age_40_to_75_Years_with_Diabetes_without_ASCVD_or_LDL_Greater_than_190_or_Hypercholesterolemia(CqlContext context)
	{
		Patient a_ = this.Patient(context);
		Date b_ = a_?.BirthDateElement;
		string c_ = b_?.Value;
		CqlDateTime d_ = context.Operators.ConvertStringToDateTime(c_);
		CqlInterval<CqlDateTime> e_ = this.Measurement_Period(context);
		CqlDateTime f_ = context.Operators.Start(e_);
		int? g_ = context.Operators.CalculateAgeAt(d_, f_, "year");
		CqlInterval<int?> h_ = context.Operators.Interval(40, 75, true, true);
		bool? i_ = context.Operators.In<int?>(g_, h_, default);
		bool? j_ = this.Has_Diabetes_Diagnosis(context);
		bool? k_ = context.Operators.And(i_, j_);
		IEnumerable<object> l_ = this.ASCVD_Diagnosis_or_Procedure_before_End_of_Measurement_Period(context);
		bool? m_ = context.Operators.Exists<object>(l_);
		bool? n_ = context.Operators.Not(m_);
		bool? o_ = context.Operators.And(k_, n_);
		IEnumerable<Observation> p_ = this.LDL_Result_Greater_Than_or_Equal_To_190(context);
		bool? q_ = context.Operators.Exists<Observation>(p_);
		bool? r_ = context.Operators.Not(q_);
		bool? s_ = context.Operators.And(o_, r_);
		IEnumerable<Condition> t_ = this.Hypercholesterolemia_Diagnosis(context);
		bool? u_ = context.Operators.Exists<Condition>(t_);
		bool? v_ = context.Operators.Not(u_);
		bool? w_ = context.Operators.And(s_, v_);

		return w_;
	}


    [CqlDeclaration("Initial Population 3")]
	public bool? Initial_Population_3(CqlContext context)
	{
		bool? a_ = this.Patients_Age_40_to_75_Years_with_Diabetes_without_ASCVD_or_LDL_Greater_than_190_or_Hypercholesterolemia(context);
		IEnumerable<Encounter> b_ = this.Qualifying_Encounter_during_Measurement_Period(context);
		bool? c_ = context.Operators.Exists<Encounter>(b_);
		bool? d_ = context.Operators.And(a_, c_);

		return d_;
	}


    [CqlDeclaration("Denominator 3")]
	public bool? Denominator_3(CqlContext context)
	{
		bool? a_ = this.Initial_Population_3(context);

		return a_;
	}


    [CqlDeclaration("SDE Ethnicity")]
	public IEnumerable<Coding> SDE_Ethnicity(CqlContext context)
	{
		IEnumerable<Coding> a_ = SupplementalDataElementsFHIR4_2_0_000.Instance.SDE_Ethnicity(context);

		return a_;
	}


    [CqlDeclaration("SDE Payer")]
	public IEnumerable<(CodeableConcept code, Period period)?> SDE_Payer(CqlContext context)
	{
		IEnumerable<(CodeableConcept code, Period period)?> a_ = SupplementalDataElementsFHIR4_2_0_000.Instance.SDE_Payer(context);

		return a_;
	}


    [CqlDeclaration("SDE Race")]
	public IEnumerable<Coding> SDE_Race(CqlContext context)
	{
		IEnumerable<Coding> a_ = SupplementalDataElementsFHIR4_2_0_000.Instance.SDE_Race(context);

		return a_;
	}


    [CqlDeclaration("SDE Sex")]
	public CqlCode SDE_Sex(CqlContext context)
	{
		CqlCode a_ = SupplementalDataElementsFHIR4_2_0_000.Instance.SDE_Sex(context);

		return a_;
	}


    [CqlDeclaration("Has Allergy to Statin")]
	public bool? Has_Allergy_to_Statin(CqlContext context)
	{
		CqlValueSet a_ = this.Statin_Allergen(context);
		IEnumerable<AllergyIntolerance> b_ = context.Operators.Retrieve<AllergyIntolerance>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/StructureDefinition/AllergyIntolerance"));
		bool? c_(AllergyIntolerance StatinAllergy)
		{
			DataType f_ = StatinAllergy?.Onset;
			CqlInterval<CqlDateTime> g_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, f_);
			CqlDateTime h_ = context.Operators.Start(g_);
			CqlInterval<CqlDateTime> i_ = this.Measurement_Period(context);
			CqlDateTime j_ = context.Operators.End(i_);
			bool? k_ = context.Operators.Before(h_, j_, default);

			return k_;
		};
		IEnumerable<AllergyIntolerance> d_ = context.Operators.Where<AllergyIntolerance>(b_, c_);
		bool? e_ = context.Operators.Exists<AllergyIntolerance>(d_);

		return e_;
	}


    [CqlDeclaration("Has Order or Receiving Hospice Care or Palliative Care")]
	public bool? Has_Order_or_Receiving_Hospice_Care_or_Palliative_Care(CqlContext context)
	{
		CqlValueSet a_ = this.Hospice_Care_Ambulatory(context);
		IEnumerable<ServiceRequest> b_ = context.Operators.Retrieve<ServiceRequest>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/StructureDefinition/ServiceRequest"));
		CqlValueSet c_ = this.Palliative_or_Hospice_Care(context);
		IEnumerable<ServiceRequest> d_ = context.Operators.Retrieve<ServiceRequest>(new RetrieveParameters(default, c_, default, "http://hl7.org/fhir/StructureDefinition/ServiceRequest"));
		IEnumerable<ServiceRequest> e_ = context.Operators.Union<ServiceRequest>(b_, d_);
		bool? f_(ServiceRequest PalliativeOrHospiceCareOrder)
		{
			FhirDateTime y_ = PalliativeOrHospiceCareOrder?.AuthoredOnElement;
			CqlDateTime z_ = FHIRHelpers_4_0_001.Instance.ToDateTime(context, y_);
			CqlInterval<CqlDateTime> aa_ = this.Measurement_Period(context);
			CqlDateTime ab_ = context.Operators.End(aa_);
			bool? ac_ = context.Operators.SameOrBefore(z_, ab_, default);
			Code<RequestStatus> ad_ = PalliativeOrHospiceCareOrder?.StatusElement;
			string ae_ = FHIRHelpers_4_0_001.Instance.ToString(context, ad_);
			string[] af_ = [
				"active",
				"on-hold",
				"completed",
			];
			bool? ag_ = context.Operators.In<string>(ae_, af_ as IEnumerable<string>);
			bool? ah_ = context.Operators.And(ac_, ag_);
			Code<RequestIntent> ai_ = PalliativeOrHospiceCareOrder?.IntentElement;
			string aj_ = FHIRHelpers_4_0_001.Instance.ToString(context, ai_);
			bool? ak_ = context.Operators.Equal(aj_, "order");
			bool? al_ = context.Operators.And(ah_, ak_);

			return al_;
		};
		IEnumerable<ServiceRequest> g_ = context.Operators.Where<ServiceRequest>(e_, f_);
		bool? h_ = context.Operators.Exists<ServiceRequest>(g_);
		IEnumerable<Procedure> j_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/StructureDefinition/Procedure"));
		IEnumerable<Procedure> l_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, c_, default, "http://hl7.org/fhir/StructureDefinition/Procedure"));
		IEnumerable<Procedure> m_ = context.Operators.Union<Procedure>(j_, l_);
		bool? n_(Procedure PalliativeOrHospiceCarePerformed)
		{
			DataType am_ = PalliativeOrHospiceCarePerformed?.Performed;
			CqlInterval<CqlDateTime> an_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, am_);
			CqlDateTime ao_ = context.Operators.Start(an_);
			CqlInterval<CqlDateTime> ap_ = this.Measurement_Period(context);
			CqlDateTime aq_ = context.Operators.End(ap_);
			bool? ar_ = context.Operators.SameOrBefore(ao_, aq_, default);
			Code<EventStatus> as_ = PalliativeOrHospiceCarePerformed?.StatusElement;
			string at_ = FHIRHelpers_4_0_001.Instance.ToString(context, as_);
			bool? au_ = context.Operators.Equal(at_, "completed");
			bool? av_ = context.Operators.And(ar_, au_);

			return av_;
		};
		IEnumerable<Procedure> o_ = context.Operators.Where<Procedure>(m_, n_);
		bool? p_ = context.Operators.Exists<Procedure>(o_);
		bool? q_ = context.Operators.Or(h_, p_);
		CqlCode r_ = this.Encounter_for_palliative_care(context);
		IEnumerable<CqlCode> s_ = context.Operators.ToList<CqlCode>(r_);
		IEnumerable<Encounter> t_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, default, s_, "http://hl7.org/fhir/StructureDefinition/Encounter"));
		bool? u_(Encounter PalliativeEncounter)
		{
			Period aw_ = PalliativeEncounter?.Period;
			CqlInterval<CqlDateTime> ax_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, aw_);
			CqlDateTime ay_ = context.Operators.Start(ax_);
			CqlInterval<CqlDateTime> az_ = this.Measurement_Period(context);
			CqlDateTime ba_ = context.Operators.End(az_);
			bool? bb_ = context.Operators.SameOrBefore(ay_, ba_, default);
			Code<Encounter.EncounterStatus> bc_ = PalliativeEncounter?.StatusElement;
			string bd_ = FHIRHelpers_4_0_001.Instance.ToString(context, bc_);
			bool? be_ = context.Operators.Equal(bd_, "finished");
			bool? bf_ = context.Operators.And(bb_, be_);

			return bf_;
		};
		IEnumerable<Encounter> v_ = context.Operators.Where<Encounter>(t_, u_);
		bool? w_ = context.Operators.Exists<Encounter>(v_);
		bool? x_ = context.Operators.Or(q_, w_);

		return x_;
	}


    [CqlDeclaration("Has Hepatitis or Liver Disease Diagnosis")]
	public bool? Has_Hepatitis_or_Liver_Disease_Diagnosis(CqlContext context)
	{
		CqlValueSet a_ = this.Hepatitis_A(context);
		IEnumerable<Condition> b_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/StructureDefinition/Condition"));
		CqlValueSet c_ = this.Hepatitis_B(context);
		IEnumerable<Condition> d_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, c_, default, "http://hl7.org/fhir/StructureDefinition/Condition"));
		IEnumerable<Condition> e_ = context.Operators.Union<Condition>(b_, d_);
		CqlValueSet f_ = this.Liver_Disease(context);
		IEnumerable<Condition> g_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, f_, default, "http://hl7.org/fhir/StructureDefinition/Condition"));
		IEnumerable<Condition> h_ = context.Operators.Union<Condition>(e_, g_);
		bool? i_(Condition HepatitisLiverDisease)
		{
			CqlInterval<CqlDateTime> l_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Prevalence_Period(context, HepatitisLiverDisease);
			CqlInterval<CqlDateTime> m_ = this.Measurement_Period(context);
			bool? n_ = context.Operators.Overlaps(l_, m_, default);

			return n_;
		};
		IEnumerable<Condition> j_ = context.Operators.Where<Condition>(h_, i_);
		bool? k_ = context.Operators.Exists<Condition>(j_);

		return k_;
	}


    [CqlDeclaration("Has Statin Associated Muscle Symptoms")]
	public bool? Has_Statin_Associated_Muscle_Symptoms(CqlContext context)
	{
		CqlValueSet a_ = this.Statin_Associated_Muscle_Symptoms(context);
		IEnumerable<Condition> b_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/StructureDefinition/Condition"));
		bool? c_(Condition StatinMuscleSymptom)
		{
			CqlInterval<CqlDateTime> f_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Prevalence_Period(context, StatinMuscleSymptom);
			CqlDateTime g_ = context.Operators.Start(f_);
			CqlInterval<CqlDateTime> h_ = this.Measurement_Period(context);
			CqlDateTime i_ = context.Operators.End(h_);
			bool? j_ = context.Operators.Before(g_, i_, default);

			return j_;
		};
		IEnumerable<Condition> d_ = context.Operators.Where<Condition>(b_, c_);
		bool? e_ = context.Operators.Exists<Condition>(d_);

		return e_;
	}


    [CqlDeclaration("Has ESRD Diagnosis")]
	public bool? Has_ESRD_Diagnosis(CqlContext context)
	{
		CqlValueSet a_ = this.End_Stage_Renal_Disease(context);
		IEnumerable<Condition> b_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/StructureDefinition/Condition"));
		bool? c_(Condition ESRD)
		{
			CqlInterval<CqlDateTime> f_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Prevalence_Period(context, ESRD);
			CqlInterval<CqlDateTime> g_ = this.Measurement_Period(context);
			bool? h_ = context.Operators.Overlaps(f_, g_, default);

			return h_;
		};
		IEnumerable<Condition> d_ = context.Operators.Where<Condition>(b_, c_);
		bool? e_ = context.Operators.Exists<Condition>(d_);

		return e_;
	}


    [CqlDeclaration("Has Adverse Reaction to Statin")]
	public bool? Has_Adverse_Reaction_to_Statin(CqlContext context)
	{
		CqlValueSet a_ = this.Statin_Allergen(context);
		IEnumerable<AdverseEvent> b_ = context.Operators.Retrieve<AdverseEvent>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/StructureDefinition/AdverseEvent"));
		bool? c_(AdverseEvent StatinReaction)
		{
			FhirDateTime f_ = StatinReaction?.DateElement;
			CqlDateTime g_ = FHIRHelpers_4_0_001.Instance.ToDateTime(context, f_);
			CqlInterval<CqlDateTime> h_ = this.Measurement_Period(context);
			bool? i_ = context.Operators.In<CqlDateTime>(g_, h_, default);

			return i_;
		};
		IEnumerable<AdverseEvent> d_ = context.Operators.Where<AdverseEvent>(b_, c_);
		bool? e_ = context.Operators.Exists<AdverseEvent>(d_);

		return e_;
	}


    [CqlDeclaration("Denominator Exceptions")]
	public bool? Denominator_Exceptions(CqlContext context)
	{
		bool? a_ = this.Has_Allergy_to_Statin(context);
		bool? b_ = this.Has_Order_or_Receiving_Hospice_Care_or_Palliative_Care(context);
		bool? c_ = context.Operators.Or(a_, b_);
		bool? d_ = this.Has_Hepatitis_or_Liver_Disease_Diagnosis(context);
		bool? e_ = context.Operators.Or(c_, d_);
		bool? f_ = this.Has_Statin_Associated_Muscle_Symptoms(context);
		bool? g_ = context.Operators.Or(e_, f_);
		bool? h_ = this.Has_ESRD_Diagnosis(context);
		bool? i_ = context.Operators.Or(g_, h_);
		bool? j_ = this.Has_Adverse_Reaction_to_Statin(context);
		bool? k_ = context.Operators.Or(i_, j_);

		return k_;
	}


    [CqlDeclaration("Denominator Exclusions")]
	public bool? Denominator_Exclusions(CqlContext context)
	{
		CqlValueSet a_ = this.Pregnancy_or_Other_Related_Diagnoses(context);
		IEnumerable<Condition> b_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/StructureDefinition/Condition"));
		CqlValueSet c_ = this.Breastfeeding(context);
		IEnumerable<Condition> d_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, c_, default, "http://hl7.org/fhir/StructureDefinition/Condition"));
		IEnumerable<Condition> e_ = context.Operators.Union<Condition>(b_, d_);
		CqlValueSet f_ = this.Rhabdomyolysis(context);
		IEnumerable<Condition> g_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, f_, default, "http://hl7.org/fhir/StructureDefinition/Condition"));
		IEnumerable<Condition> h_ = context.Operators.Union<Condition>(e_, g_);
		bool? i_(Condition ExclusionDiagnosis)
		{
			CqlInterval<CqlDateTime> l_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Prevalence_Period(context, ExclusionDiagnosis);
			CqlInterval<CqlDateTime> m_ = this.Measurement_Period(context);
			bool? n_ = context.Operators.Overlaps(l_, m_, default);

			return n_;
		};
		IEnumerable<Condition> j_ = context.Operators.Where<Condition>(h_, i_);
		bool? k_ = context.Operators.Exists<Condition>(j_);

		return k_;
	}


    [CqlDeclaration("Statin Therapy Ordered during Measurement Period")]
	public IEnumerable<MedicationRequest> Statin_Therapy_Ordered_during_Measurement_Period(CqlContext context)
	{
		CqlValueSet a_ = this.Low_Intensity_Statin_Therapy(context);
		IEnumerable<MedicationRequest> b_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/StructureDefinition/MedicationRequest"));
		IEnumerable<MedicationRequest> d_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/StructureDefinition/MedicationRequest"));
		IEnumerable<MedicationRequest> e_ = context.Operators.Union<MedicationRequest>(b_, d_);
		CqlValueSet f_ = this.Moderate_Intensity_Statin_Therapy(context);
		IEnumerable<MedicationRequest> g_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, f_, default, "http://hl7.org/fhir/StructureDefinition/MedicationRequest"));
		IEnumerable<MedicationRequest> i_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, f_, default, "http://hl7.org/fhir/StructureDefinition/MedicationRequest"));
		IEnumerable<MedicationRequest> j_ = context.Operators.Union<MedicationRequest>(g_, i_);
		IEnumerable<MedicationRequest> k_ = context.Operators.Union<MedicationRequest>(e_, j_);
		CqlValueSet l_ = this.High_Intensity_Statin_Therapy(context);
		IEnumerable<MedicationRequest> m_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, l_, default, "http://hl7.org/fhir/StructureDefinition/MedicationRequest"));
		IEnumerable<MedicationRequest> o_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, l_, default, "http://hl7.org/fhir/StructureDefinition/MedicationRequest"));
		IEnumerable<MedicationRequest> p_ = context.Operators.Union<MedicationRequest>(m_, o_);
		IEnumerable<MedicationRequest> q_ = context.Operators.Union<MedicationRequest>(k_, p_);
		bool? r_(MedicationRequest StatinOrdered)
		{
			FhirDateTime t_ = StatinOrdered?.AuthoredOnElement;
			CqlDateTime u_ = FHIRHelpers_4_0_001.Instance.ToDateTime(context, t_);
			CqlInterval<CqlDateTime> v_ = this.Measurement_Period(context);
			bool? w_ = context.Operators.In<CqlDateTime>(u_, v_, default);
			Code<MedicationRequest.MedicationrequestStatus> x_ = StatinOrdered?.StatusElement;
			string y_ = FHIRHelpers_4_0_001.Instance.ToString(context, x_);
			string[] z_ = [
				"active",
				"completed",
			];
			bool? aa_ = context.Operators.In<string>(y_, z_ as IEnumerable<string>);
			bool? ab_ = context.Operators.And(w_, aa_);
			Code<MedicationRequest.MedicationRequestIntent> ac_ = StatinOrdered?.IntentElement;
			string ad_ = FHIRHelpers_4_0_001.Instance.ToString(context, ac_);
			bool? ae_ = context.Operators.Equal(ad_, "order");
			bool? af_ = context.Operators.And(ab_, ae_);

			return af_;
		};
		IEnumerable<MedicationRequest> s_ = context.Operators.Where<MedicationRequest>(q_, r_);

		return s_;
	}


    [CqlDeclaration("Prescribed Statin Therapy Any Time during Measurement Period")]
	public IEnumerable<MedicationRequest> Prescribed_Statin_Therapy_Any_Time_during_Measurement_Period(CqlContext context)
	{
		CqlValueSet a_ = this.Low_Intensity_Statin_Therapy(context);
		IEnumerable<MedicationRequest> b_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/StructureDefinition/MedicationRequest"));
		IEnumerable<MedicationRequest> d_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/StructureDefinition/MedicationRequest"));
		IEnumerable<MedicationRequest> e_ = context.Operators.Union<MedicationRequest>(b_, d_);
		CqlValueSet f_ = this.Moderate_Intensity_Statin_Therapy(context);
		IEnumerable<MedicationRequest> g_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, f_, default, "http://hl7.org/fhir/StructureDefinition/MedicationRequest"));
		IEnumerable<MedicationRequest> i_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, f_, default, "http://hl7.org/fhir/StructureDefinition/MedicationRequest"));
		IEnumerable<MedicationRequest> j_ = context.Operators.Union<MedicationRequest>(g_, i_);
		IEnumerable<MedicationRequest> k_ = context.Operators.Union<MedicationRequest>(e_, j_);
		CqlValueSet l_ = this.High_Intensity_Statin_Therapy(context);
		IEnumerable<MedicationRequest> m_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, l_, default, "http://hl7.org/fhir/StructureDefinition/MedicationRequest"));
		IEnumerable<MedicationRequest> o_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, l_, default, "http://hl7.org/fhir/StructureDefinition/MedicationRequest"));
		IEnumerable<MedicationRequest> p_ = context.Operators.Union<MedicationRequest>(m_, o_);
		IEnumerable<MedicationRequest> q_ = context.Operators.Union<MedicationRequest>(k_, p_);
		bool? r_(MedicationRequest ActiveStatin)
		{
			List<Dosage> t_ = ActiveStatin?.DosageInstruction;
			bool? u_(Dosage @this)
			{
				Timing ag_ = @this?.Timing;
				bool? ah_ = context.Operators.Not((bool?)(ag_ is null));

				return ah_;
			};
			IEnumerable<Dosage> v_ = context.Operators.Where<Dosage>((IEnumerable<Dosage>)t_, u_);
			Timing w_(Dosage @this)
			{
				Timing ai_ = @this?.Timing;

				return ai_;
			};
			IEnumerable<Timing> x_ = context.Operators.Select<Dosage, Timing>(v_, w_);
			bool? y_(Timing T)
			{
				object aj_()
				{
					bool an_()
					{
						Timing.RepeatComponent ap_ = T?.Repeat;
						DataType aq_ = ap_?.Bounds;
						bool ar_ = aq_ is Range;

						return ar_;
					};
					bool ao_()
					{
						Timing.RepeatComponent as_ = T?.Repeat;
						DataType at_ = as_?.Bounds;
						bool au_ = at_ is Period;

						return au_;
					};
					if (an_())
					{
						Timing.RepeatComponent av_ = T?.Repeat;
						DataType aw_ = av_?.Bounds;

						return (aw_ as Range) as object;
					}
					else if (ao_())
					{
						Timing.RepeatComponent ax_ = T?.Repeat;
						DataType ay_ = ax_?.Bounds;

						return (ay_ as Period) as object;
					}
					else
					{
						return null;
					}
				};
				CqlInterval<CqlDateTime> ak_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, aj_());
				CqlInterval<CqlDateTime> al_ = this.Measurement_Period(context);
				bool? am_ = context.Operators.Overlaps(ak_, al_, default);

				return am_;
			};
			IEnumerable<Timing> z_ = context.Operators.Where<Timing>(x_, y_);
			bool? aa_ = context.Operators.Exists<Timing>(z_);
			Code<MedicationRequest.MedicationrequestStatus> ab_ = ActiveStatin?.StatusElement;
			string ac_ = FHIRHelpers_4_0_001.Instance.ToString(context, ab_);
			string[] ad_ = [
				"active",
				"completed",
			];
			bool? ae_ = context.Operators.In<string>(ac_, ad_ as IEnumerable<string>);
			bool? af_ = context.Operators.And(aa_, ae_);

			return af_;
		};
		IEnumerable<MedicationRequest> s_ = context.Operators.Where<MedicationRequest>(q_, r_);

		return s_;
	}


    [CqlDeclaration("Numerator")]
	public bool? Numerator(CqlContext context)
	{
		IEnumerable<MedicationRequest> a_ = this.Statin_Therapy_Ordered_during_Measurement_Period(context);
		bool? b_ = context.Operators.Exists<MedicationRequest>(a_);
		IEnumerable<MedicationRequest> c_ = this.Prescribed_Statin_Therapy_Any_Time_during_Measurement_Period(context);
		bool? d_ = context.Operators.Exists<MedicationRequest>(c_);
		bool? e_ = context.Operators.Or(b_, d_);

		return e_;
	}

}

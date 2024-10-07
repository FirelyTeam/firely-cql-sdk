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
[System.CodeDom.Compiler.GeneratedCode(".NET Code Generation", "2.0.4.0")]
[CqlLibrary("AppropriateDXAScansForWomenUnder65FHIR", "0.0.000")]
public partial class AppropriateDXAScansForWomenUnder65FHIR_0_0_000
{
    private AppropriateDXAScansForWomenUnder65FHIR_0_0_000() {}

    public static AppropriateDXAScansForWomenUnder65FHIR_0_0_000 Instance { get; } = new();


    [CqlDeclaration("Amenorrhea")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.1022")]
	public CqlValueSet Amenorrhea(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.1022", default);


    [CqlDeclaration("Ankylosing Spondylitis")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.113.12.1045")]
	public CqlValueSet Ankylosing_Spondylitis(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.113.12.1045", default);


    [CqlDeclaration("Aromatase Inhibitors")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.196.12.1265")]
	public CqlValueSet Aromatase_Inhibitors(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.196.12.1265", default);


    [CqlDeclaration("Bilateral Oophorectomy")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.471")]
	public CqlValueSet Bilateral_Oophorectomy(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.471", default);


    [CqlDeclaration("Bone Marrow Transplant")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.666.5.336")]
	public CqlValueSet Bone_Marrow_Transplant(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.666.5.336", default);


    [CqlDeclaration("Chemotherapy")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.485")]
	public CqlValueSet Chemotherapy(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.485", default);


    [CqlDeclaration("Chronic Liver Disease")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.199.12.1035")]
	public CqlValueSet Chronic_Liver_Disease(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.199.12.1035", default);


    [CqlDeclaration("Chronic Malnutrition")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.199.12.1036")]
	public CqlValueSet Chronic_Malnutrition(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.199.12.1036", default);


    [CqlDeclaration("Cushings Syndrome")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.117.12.1009")]
	public CqlValueSet Cushings_Syndrome(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.117.12.1009", default);


    [CqlDeclaration("DXA (Dual energy Xray Absorptiometry) Scan")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.113.12.1051")]
	public CqlValueSet DXA__Dual_energy_Xray_Absorptiometry__Scan(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.113.12.1051", default);


    [CqlDeclaration("Eating Disorders")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.1039")]
	public CqlValueSet Eating_Disorders(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.1039", default);


    [CqlDeclaration("Ehlers Danlos Syndrome")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.113.12.1047")]
	public CqlValueSet Ehlers_Danlos_Syndrome(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.113.12.1047", default);


    [CqlDeclaration("End Stage Renal Disease")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.353")]
	public CqlValueSet End_Stage_Renal_Disease(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.353", default);


    [CqlDeclaration("Evidence of Bilateral Oophorectomy")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.1048")]
	public CqlValueSet Evidence_of_Bilateral_Oophorectomy(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.1048", default);


    [CqlDeclaration("Gastric Bypass Surgery")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.198.12.1050")]
	public CqlValueSet Gastric_Bypass_Surgery(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.198.12.1050", default);


    [CqlDeclaration("Glucocorticoids (oral only)")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.196.12.1266")]
	public CqlValueSet Glucocorticoids__oral_only_(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.196.12.1266", default);


    [CqlDeclaration("History of hip fracture in parent")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.113.12.1040")]
	public CqlValueSet History_of_hip_fracture_in_parent(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.113.12.1040", default);


    [CqlDeclaration("Hyperparathyroidism")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.117.12.1016")]
	public CqlValueSet Hyperparathyroidism(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.117.12.1016", default);


    [CqlDeclaration("Hyperthyroidism")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.117.12.1015")]
	public CqlValueSet Hyperthyroidism(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.117.12.1015", default);


    [CqlDeclaration("Kidney Transplant")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.109.12.1012")]
	public CqlValueSet Kidney_Transplant(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.109.12.1012", default);


    [CqlDeclaration("Lupus")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.117.12.1010")]
	public CqlValueSet Lupus(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.117.12.1010", default);


    [CqlDeclaration("Major Transplant")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.198.12.1075")]
	public CqlValueSet Major_Transplant(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.198.12.1075", default);


    [CqlDeclaration("Malabsorption Syndromes")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.199.12.1050")]
	public CqlValueSet Malabsorption_Syndromes(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.199.12.1050", default);


    [CqlDeclaration("Marfan's Syndrome")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.113.12.1048")]
	public CqlValueSet Marfans_Syndrome(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.113.12.1048", default);


    [CqlDeclaration("Multiple Myeloma")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.1011")]
	public CqlValueSet Multiple_Myeloma(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.1011", default);


    [CqlDeclaration("Office Visit")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1001")]
	public CqlValueSet Office_Visit(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1001", default);


    [CqlDeclaration("Online Assessments")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1089")]
	public CqlValueSet Online_Assessments(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1089", default);


    [CqlDeclaration("Osteogenesis Imperfecta")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.113.12.1044")]
	public CqlValueSet Osteogenesis_Imperfecta(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.113.12.1044", default);


    [CqlDeclaration("Osteopenia")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.113.12.1049")]
	public CqlValueSet Osteopenia(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.113.12.1049", default);


    [CqlDeclaration("Osteoporosis")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.113.12.1038")]
	public CqlValueSet Osteoporosis(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.113.12.1038", default);


    [CqlDeclaration("Osteoporotic Fractures")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.113.12.1050")]
	public CqlValueSet Osteoporotic_Fractures(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.113.12.1050", default);


    [CqlDeclaration("Outpatient Consultation")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1008")]
	public CqlValueSet Outpatient_Consultation(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1008", default);


    [CqlDeclaration("Premature Menopause")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.1013")]
	public CqlValueSet Premature_Menopause(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.1013", default);


    [CqlDeclaration("Preventive Care Services Established Office Visit, 18 and Up")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1025")]
	public CqlValueSet Preventive_Care_Services_Established_Office_Visit__18_and_Up(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1025", default);


    [CqlDeclaration("Preventive Care Services Initial Office Visit, 18 and Up")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1023")]
	public CqlValueSet Preventive_Care_Services_Initial_Office_Visit__18_and_Up(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1023", default);


    [CqlDeclaration("Psoriatic Arthritis")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.113.12.1046")]
	public CqlValueSet Psoriatic_Arthritis(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.113.12.1046", default);


    [CqlDeclaration("Rheumatoid Arthritis")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.113.12.1005")]
	public CqlValueSet Rheumatoid_Arthritis(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.113.12.1005", default);


    [CqlDeclaration("Telephone Visits")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1080")]
	public CqlValueSet Telephone_Visits(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1080", default);


    [CqlDeclaration("Type 1 Diabetes")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.103.12.1020")]
	public CqlValueSet Type_1_Diabetes(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.103.12.1020", default);


    [CqlDeclaration("Unilateral Oophorectomy Left")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.1028")]
	public CqlValueSet Unilateral_Oophorectomy_Left(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.1028", default);


    [CqlDeclaration("Unilateral Oophorectomy Right")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.1032")]
	public CqlValueSet Unilateral_Oophorectomy_Right(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.1032", default);


    [CqlDeclaration("Unilateral Oophorectomy, Unspecified Laterality")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.1035")]
	public CqlValueSet Unilateral_Oophorectomy__Unspecified_Laterality(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.1035", default);


    [CqlDeclaration("Alcoholic drinks per drinking day - Reported")]
	public CqlCode Alcoholic_drinks_per_drinking_day___Reported(CqlContext context) => 
		new CqlCode("11287-0", "http://loinc.org", default, default);


    [CqlDeclaration("Body mass index (BMI) [Ratio]")]
	public CqlCode Body_mass_index__BMI___Ratio_(CqlContext context) => 
		new CqlCode("39156-5", "http://loinc.org", default, default);


    [CqlDeclaration("Female")]
	public CqlCode Female(CqlContext context) => 
		new CqlCode("F", "http://terminology.hl7.org/CodeSystem/v3-AdministrativeGender", default, default);


    [CqlDeclaration("Left (qualifier value)")]
	public CqlCode Left__qualifier_value_(CqlContext context) => 
		new CqlCode("7771000", "http://snomed.info/sct", default, default);


    [CqlDeclaration("Major osteoporotic fracture 10-year probability [Likelihood] Fracture Risk Assessment")]
	public CqlCode Major_osteoporotic_fracture_10_year_probability__Likelihood__Fracture_Risk_Assessment(CqlContext context) => 
		new CqlCode("90265-0", "http://loinc.org", default, default);


    [CqlDeclaration("Osteoporosis Index of Risk panel")]
	public CqlCode Osteoporosis_Index_of_Risk_panel(CqlContext context) => 
		new CqlCode("98133-2", "http://loinc.org", default, default);


    [CqlDeclaration("Osteoporosis Risk Assessment Instrument")]
	public CqlCode Osteoporosis_Risk_Assessment_Instrument(CqlContext context) => 
		new CqlCode("98139-9", "http://loinc.org", default, default);


    [CqlDeclaration("Osteoporosis Self-Assessment Tool")]
	public CqlCode Osteoporosis_Self_Assessment_Tool(CqlContext context) => 
		new CqlCode("98146-4", "http://loinc.org", default, default);


    [CqlDeclaration("Right (qualifier value)")]
	public CqlCode Right__qualifier_value_(CqlContext context) => 
		new CqlCode("24028007", "http://snomed.info/sct", default, default);


    [CqlDeclaration("Unlisted preventive medicine service")]
	public CqlCode Unlisted_preventive_medicine_service(CqlContext context) => 
		new CqlCode("99429", "http://www.ama-assn.org/go/cpt", default, default);


    [CqlDeclaration("LOINC")]
	public CqlCode[] LOINC(CqlContext context)
	{
		CqlCode[] a_ = [
			new CqlCode("11287-0", "http://loinc.org", default, default),
			new CqlCode("39156-5", "http://loinc.org", default, default),
			new CqlCode("90265-0", "http://loinc.org", default, default),
			new CqlCode("98133-2", "http://loinc.org", default, default),
			new CqlCode("98139-9", "http://loinc.org", default, default),
			new CqlCode("98146-4", "http://loinc.org", default, default),
		];

		return a_;
	}


    [CqlDeclaration("AdministrativeGender")]
	public CqlCode[] AdministrativeGender(CqlContext context)
	{
		CqlCode[] a_ = [
			new CqlCode("F", "http://terminology.hl7.org/CodeSystem/v3-AdministrativeGender", default, default),
		];

		return a_;
	}


    [CqlDeclaration("SNOMEDCT")]
	public CqlCode[] SNOMEDCT(CqlContext context)
	{
		CqlCode[] a_ = [
			new CqlCode("7771000", "http://snomed.info/sct", default, default),
			new CqlCode("24028007", "http://snomed.info/sct", default, default),
		];

		return a_;
	}


    [CqlDeclaration("CPT")]
	public CqlCode[] CPT(CqlContext context)
	{
		CqlCode[] a_ = [
			new CqlCode("99429", "http://www.ama-assn.org/go/cpt", default, default),
		];

		return a_;
	}


    [CqlDeclaration("Measurement Period")]
	public CqlInterval<CqlDateTime> Measurement_Period(CqlContext context)
	{
		CqlDateTime a_ = context.Operators.DateTime(2025, 1, 1, 0, 0, 0, 0, default);
		CqlDateTime b_ = context.Operators.DateTime(2026, 1, 1, 0, 0, 0, 0, default);
		CqlInterval<CqlDateTime> c_ = context.Operators.Interval(a_, b_, true, false);
		object d_ = context.ResolveParameter("AppropriateDXAScansForWomenUnder65FHIR-0.0.000", "Measurement Period", c_);

		return (CqlInterval<CqlDateTime>)d_;
	}


    [CqlDeclaration("Patient")]
	public Patient Patient(CqlContext context)
	{
		IEnumerable<Patient> a_ = context.Operators.RetrieveByValueSet<Patient>(default, default);
		Patient b_ = context.Operators.SingletonFrom<Patient>(a_);

		return b_;
	}


    [CqlDeclaration("SDE Ethnicity")]
	public (IEnumerable<CqlCode> codes, string display)? SDE_Ethnicity(CqlContext context)
	{
		(IEnumerable<CqlCode> codes, string display)? a_ = SupplementalDataElements_3_4_000.Instance.SDE_Ethnicity(context);

		return a_;
	}


    [CqlDeclaration("SDE Payer")]
	public IEnumerable<(CqlConcept code, CqlInterval<CqlDateTime> period)?> SDE_Payer(CqlContext context)
	{
		IEnumerable<(CqlConcept code, CqlInterval<CqlDateTime> period)?> a_ = SupplementalDataElements_3_4_000.Instance.SDE_Payer(context);

		return a_;
	}


    [CqlDeclaration("SDE Race")]
	public (IEnumerable<CqlCode> codes, string display)? SDE_Race(CqlContext context)
	{
		(IEnumerable<CqlCode> codes, string display)? a_ = SupplementalDataElements_3_4_000.Instance.SDE_Race(context);

		return a_;
	}


    [CqlDeclaration("SDE Sex")]
	public CqlCode SDE_Sex(CqlContext context)
	{
		CqlCode a_ = SupplementalDataElements_3_4_000.Instance.SDE_Sex(context);

		return a_;
	}


    [CqlDeclaration("Qualifying Encounter")]
	public IEnumerable<Encounter> Qualifying_Encounter(CqlContext context)
	{
		CqlValueSet a_ = this.Office_Visit(context);
		IEnumerable<Encounter> b_ = context.Operators.RetrieveByValueSet<Encounter>(a_, default);
		CqlValueSet c_ = this.Preventive_Care_Services_Established_Office_Visit__18_and_Up(context);
		IEnumerable<Encounter> d_ = context.Operators.RetrieveByValueSet<Encounter>(c_, default);
		IEnumerable<Encounter> e_ = context.Operators.Union<Encounter>(b_, d_);
		IEnumerable<Encounter> f_ = context.Operators.RetrieveByValueSet<Encounter>(default, default);
		bool? g_(Encounter E)
		{
			List<CodeableConcept> x_ = E?.Type;
			CqlConcept y_(CodeableConcept @this)
			{
				CqlConcept ad_ = FHIRHelpers_4_3_000.Instance.ToConcept(context, @this);

				return ad_;
			};
			IEnumerable<CqlConcept> z_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)x_, y_);
			bool? aa_(CqlConcept T)
			{
				CqlCode ae_ = this.Unlisted_preventive_medicine_service(context);
				CqlConcept af_ = context.Operators.ConvertCodeToConcept(ae_);
				bool? ag_ = context.Operators.Equivalent(T, af_);

				return ag_;
			};
			IEnumerable<CqlConcept> ab_ = context.Operators.Where<CqlConcept>(z_, aa_);
			bool? ac_ = context.Operators.Exists<CqlConcept>(ab_);

			return ac_;
		};
		IEnumerable<Encounter> h_ = context.Operators.Where<Encounter>(f_, g_);
		CqlValueSet i_ = this.Preventive_Care_Services_Initial_Office_Visit__18_and_Up(context);
		IEnumerable<Encounter> j_ = context.Operators.RetrieveByValueSet<Encounter>(i_, default);
		IEnumerable<Encounter> k_ = context.Operators.Union<Encounter>(h_, j_);
		IEnumerable<Encounter> l_ = context.Operators.Union<Encounter>(e_, k_);
		CqlValueSet m_ = this.Outpatient_Consultation(context);
		IEnumerable<Encounter> n_ = context.Operators.RetrieveByValueSet<Encounter>(m_, default);
		CqlValueSet o_ = this.Online_Assessments(context);
		IEnumerable<Encounter> p_ = context.Operators.RetrieveByValueSet<Encounter>(o_, default);
		IEnumerable<Encounter> q_ = context.Operators.Union<Encounter>(n_, p_);
		IEnumerable<Encounter> r_ = context.Operators.Union<Encounter>(l_, q_);
		CqlValueSet s_ = this.Telephone_Visits(context);
		IEnumerable<Encounter> t_ = context.Operators.RetrieveByValueSet<Encounter>(s_, default);
		IEnumerable<Encounter> u_ = context.Operators.Union<Encounter>(r_, t_);
		bool? v_(Encounter ValidEncounters)
		{
			CqlInterval<CqlDateTime> ah_ = this.Measurement_Period(context);
			Period ai_ = ValidEncounters?.Period;
			CqlInterval<CqlDateTime> aj_ = FHIRHelpers_4_3_000.Instance.ToInterval(context, ai_);
			CqlInterval<CqlDateTime> ak_ = QICoreCommon_2_0_000.Instance.ToInterval(context, aj_ as object);
			bool? al_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(ah_, ak_, "day");

			return al_;
		};
		IEnumerable<Encounter> w_ = context.Operators.Where<Encounter>(u_, v_);

		return w_;
	}


    [CqlDeclaration("Initial Population")]
	public bool? Initial_Population(CqlContext context)
	{
		Patient a_ = this.Patient(context);
		Date b_ = a_?.BirthDateElement;
		string c_ = b_?.Value;
		CqlDate d_ = context.Operators.ConvertStringToDate(c_);
		CqlInterval<CqlDateTime> e_ = this.Measurement_Period(context);
		CqlDateTime f_ = context.Operators.Start(e_);
		CqlDate g_ = context.Operators.DateFrom(f_);
		int? h_ = context.Operators.CalculateAgeAt(d_, g_, "year");
		CqlInterval<int?> i_ = context.Operators.Interval(50, 63, true, true);
		bool? j_ = context.Operators.In<int?>(h_, i_, default);
		Code<AdministrativeGender> l_ = a_?.GenderElement;
		AdministrativeGender? m_ = l_?.Value;
		string n_ = context.Operators.Convert<string>(m_);
		bool? o_ = context.Operators.Equal(n_, "female");
		bool? p_ = context.Operators.And(j_, o_);
		IEnumerable<Encounter> q_ = this.Qualifying_Encounter(context);
		bool? r_ = context.Operators.Exists<Encounter>(q_);
		bool? s_ = context.Operators.And(p_, r_);

		return s_;
	}


    [CqlDeclaration("Denominator")]
	public bool? Denominator(CqlContext context)
	{
		bool? a_ = this.Initial_Population(context);

		return a_;
	}


    [CqlDeclaration("First BMI in Measurement Period")]
	public Observation First_BMI_in_Measurement_Period(CqlContext context)
	{
		IEnumerable<Observation> a_ = context.Operators.RetrieveByValueSet<Observation>(default, default);
		IEnumerable<Observation> b_ = Status_1_6_000.Instance.BMI(context, a_);
		bool? c_(Observation BMIRatio)
		{
			CqlInterval<CqlDateTime> h_ = this.Measurement_Period(context);
			DataType i_ = BMIRatio?.Effective;
			object j_ = FHIRHelpers_4_3_000.Instance.ToValue(context, i_);
			CqlInterval<CqlDateTime> k_ = QICoreCommon_2_0_000.Instance.ToInterval(context, j_);
			bool? l_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(h_, k_, default);
			DataType m_ = BMIRatio?.Value;
			CqlQuantity n_ = FHIRHelpers_4_3_000.Instance.ToQuantity(context, m_ as Quantity);
			bool? o_ = context.Operators.Not((bool?)((n_ as CqlQuantity) is null));
			bool? p_ = context.Operators.And(l_, o_);

			return p_;
		};
		IEnumerable<Observation> d_ = context.Operators.Where<Observation>(b_, c_);
		object e_(Observation @this)
		{
			DataType q_ = @this?.Effective;
			object r_ = FHIRHelpers_4_3_000.Instance.ToValue(context, q_);
			CqlInterval<CqlDateTime> s_ = QICoreCommon_2_0_000.Instance.ToInterval(context, r_);
			CqlDateTime t_ = context.Operators.Start(s_);

			return t_;
		};
		IEnumerable<Observation> f_ = context.Operators.SortBy<Observation>(d_, e_, System.ComponentModel.ListSortDirection.Ascending);
		Observation g_ = context.Operators.First<Observation>(f_);

		return g_;
	}


    [CqlDeclaration("First BMI in Measurement Period Less Than or Equal to 20 kg m2")]
	public Observation First_BMI_in_Measurement_Period_Less_Than_or_Equal_to_20_kg_m2(CqlContext context)
	{
		Observation a_ = this.First_BMI_in_Measurement_Period(context);
		Observation[] b_ = [
			a_,
		];
		bool? c_(Observation FirstBMI)
		{
			DataType f_ = FirstBMI?.Value;
			CqlQuantity g_ = FHIRHelpers_4_3_000.Instance.ToQuantity(context, f_ as Quantity);
			CqlQuantity h_ = context.Operators.Quantity(20m, "kg/m2");
			bool? i_ = context.Operators.LessOrEqual(g_ as CqlQuantity, h_);

			return i_;
		};
		IEnumerable<Observation> d_ = context.Operators.Where<Observation>((IEnumerable<Observation>)b_, c_);
		Observation e_ = context.Operators.SingletonFrom<Observation>(d_);

		return e_;
	}


    [CqlDeclaration("First Average Number of Drinks Assessments Indicating More Than Two Per Day")]
	public Observation First_Average_Number_of_Drinks_Assessments_Indicating_More_Than_Two_Per_Day(CqlContext context)
	{
		CqlCode a_ = this.Alcoholic_drinks_per_drinking_day___Reported(context);
		IEnumerable<CqlCode> b_ = context.Operators.ToList<CqlCode>(a_);
		IEnumerable<Observation> c_ = context.Operators.RetrieveByCodes<Observation>(b_, default);
		IEnumerable<Observation> d_ = Status_1_6_000.Instance.Final_Survey_Observation(context, c_);
		bool? e_(Observation AverageDrinks)
		{
			DataType j_ = AverageDrinks?.Effective;
			object k_ = FHIRHelpers_4_3_000.Instance.ToValue(context, j_);
			CqlInterval<CqlDateTime> l_ = QICoreCommon_2_0_000.Instance.ToInterval(context, k_);
			CqlDateTime m_ = context.Operators.Start(l_);
			CqlInterval<CqlDateTime> n_ = this.Measurement_Period(context);
			bool? o_ = context.Operators.In<CqlDateTime>(m_, n_, default);
			DataType p_ = AverageDrinks?.Value;
			object q_ = FHIRHelpers_4_3_000.Instance.ToValue(context, p_);
			CqlQuantity r_ = context.Operators.Quantity(2m, "{drinks}/d");
			bool? s_ = context.Operators.Greater(q_ as CqlQuantity, r_);
			bool? t_ = context.Operators.And(o_, s_);

			return t_;
		};
		IEnumerable<Observation> f_ = context.Operators.Where<Observation>(d_, e_);
		object g_(Observation @this)
		{
			DataType u_ = @this?.Effective;
			object v_ = FHIRHelpers_4_3_000.Instance.ToValue(context, u_);
			CqlInterval<CqlDateTime> w_ = QICoreCommon_2_0_000.Instance.ToInterval(context, v_);
			CqlDateTime x_ = context.Operators.Start(w_);

			return x_;
		};
		IEnumerable<Observation> h_ = context.Operators.SortBy<Observation>(f_, g_, System.ComponentModel.ListSortDirection.Ascending);
		Observation i_ = context.Operators.First<Observation>(h_);

		return i_;
	}


    [CqlDeclaration("Has Risk Factor Active During the Measurement Period")]
	public bool? Has_Risk_Factor_Active_During_the_Measurement_Period(CqlContext context)
	{
		Observation a_ = this.First_BMI_in_Measurement_Period_Less_Than_or_Equal_to_20_kg_m2(context);
		bool? b_ = context.Operators.Not((bool?)(a_ is null));
		Observation c_ = this.First_Average_Number_of_Drinks_Assessments_Indicating_More_Than_Two_Per_Day(context);
		bool? d_ = context.Operators.Not((bool?)(c_ is null));
		bool? e_ = context.Operators.Or(b_, d_);

		return e_;
	}


    [CqlDeclaration("Has Osteoporosis Before Measurement Period")]
	public bool? Has_Osteoporosis_Before_Measurement_Period(CqlContext context)
	{
		CqlValueSet a_ = this.Osteoporosis(context);
		IEnumerable<Condition> b_ = context.Operators.RetrieveByValueSet<Condition>(a_, default);
		bool? c_(Condition OsteoporosisDiagnosis)
		{
			CqlInterval<CqlDateTime> f_ = QICoreCommon_2_0_000.Instance.ToPrevalenceInterval(context, OsteoporosisDiagnosis);
			CqlDateTime g_ = context.Operators.Start(f_);
			CqlInterval<CqlDateTime> h_ = this.Measurement_Period(context);
			CqlDateTime i_ = context.Operators.Start(h_);
			bool? j_ = context.Operators.Before(g_, i_, default);

			return j_;
		};
		IEnumerable<Condition> d_ = context.Operators.Where<Condition>(b_, c_);
		bool? e_ = context.Operators.Exists<Condition>(d_);

		return e_;
	}


    [CqlDeclaration("Has Osteopenia Before Measurement Period")]
	public bool? Has_Osteopenia_Before_Measurement_Period(CqlContext context)
	{
		CqlValueSet a_ = this.Osteopenia(context);
		IEnumerable<Condition> b_ = context.Operators.RetrieveByValueSet<Condition>(a_, default);
		bool? c_(Condition OsteopeniaDiagnosis)
		{
			CqlInterval<CqlDateTime> f_ = QICoreCommon_2_0_000.Instance.ToPrevalenceInterval(context, OsteopeniaDiagnosis);
			CqlDateTime g_ = context.Operators.Start(f_);
			CqlInterval<CqlDateTime> h_ = this.Measurement_Period(context);
			CqlDateTime i_ = context.Operators.Start(h_);
			bool? j_ = context.Operators.Before(g_, i_, default);

			return j_;
		};
		IEnumerable<Condition> d_ = context.Operators.Where<Condition>(b_, c_);
		bool? e_ = context.Operators.Exists<Condition>(d_);

		return e_;
	}


    [CqlDeclaration("Has Risk Factor Any Time in History Prior to Measurement Period")]
	public bool? Has_Risk_Factor_Any_Time_in_History_Prior_to_Measurement_Period(CqlContext context)
	{
		bool? a_ = this.Has_Osteoporosis_Before_Measurement_Period(context);
		bool? b_ = this.Has_Osteopenia_Before_Measurement_Period(context);
		bool? c_ = context.Operators.Or(a_, b_);

		return c_;
	}


    [CqlDeclaration("Parent History of Hip Fracture Assessment")]
	public IEnumerable<Observation> Parent_History_of_Hip_Fracture_Assessment(CqlContext context)
	{
		CqlValueSet a_ = this.History_of_hip_fracture_in_parent(context);
		IEnumerable<Observation> b_ = context.Operators.RetrieveByValueSet<Observation>(a_, default);
		IEnumerable<Observation> c_ = Status_1_6_000.Instance.Final_Survey_Observation(context, b_);
		bool? d_(Observation ParentFractureHistory)
		{
			DataType f_ = ParentFractureHistory?.Effective;
			object g_ = FHIRHelpers_4_3_000.Instance.ToValue(context, f_);
			CqlInterval<CqlDateTime> h_ = QICoreCommon_2_0_000.Instance.ToInterval(context, g_);
			CqlDateTime i_ = context.Operators.Start(h_);
			CqlInterval<CqlDateTime> j_ = this.Measurement_Period(context);
			CqlDateTime k_ = context.Operators.Start(j_);
			bool? l_ = context.Operators.Before(i_, k_, default);

			return l_;
		};
		IEnumerable<Observation> e_ = context.Operators.Where<Observation>(c_, d_);

		return e_;
	}


    [CqlDeclaration("Has Risk Factor Any Time in History Prior to Measurement Period and Do Not Need to be Active During Measurement Period")]
	public bool? Has_Risk_Factor_Any_Time_in_History_Prior_to_Measurement_Period_and_Do_Not_Need_to_be_Active_During_Measurement_Period(CqlContext context)
	{
		CqlValueSet a_ = this.Gastric_Bypass_Surgery(context);
		IEnumerable<Procedure> b_ = context.Operators.RetrieveByValueSet<Procedure>(a_, default);
		IEnumerable<Procedure> c_ = Status_1_6_000.Instance.Completed_Procedure(context, b_);
		bool? d_(Procedure GastricBypass)
		{
			DataType aa_ = GastricBypass?.Performed;
			object ab_ = FHIRHelpers_4_3_000.Instance.ToValue(context, aa_);
			CqlInterval<CqlDateTime> ac_ = QICoreCommon_2_0_000.Instance.ToInterval(context, ab_);
			CqlDateTime ad_ = context.Operators.End(ac_);
			CqlInterval<CqlDateTime> ae_ = this.Measurement_Period(context);
			CqlDateTime af_ = context.Operators.Start(ae_);
			bool? ag_ = context.Operators.Before(ad_, af_, default);

			return ag_;
		};
		IEnumerable<Procedure> e_ = context.Operators.Where<Procedure>(c_, d_);
		CqlValueSet f_ = this.Aromatase_Inhibitors(context);
		IEnumerable<MedicationRequest> g_ = context.Operators.RetrieveByValueSet<MedicationRequest>(f_, default);
		IEnumerable<MedicationRequest> i_ = context.Operators.RetrieveByValueSet<MedicationRequest>(f_, default);
		IEnumerable<MedicationRequest> j_ = context.Operators.Union<MedicationRequest>(g_, i_);
		IEnumerable<MedicationRequest> k_ = Status_1_6_000.Instance.Active_Medication(context, j_);
		bool? l_(MedicationRequest AromataseInhibitorActive)
		{
			CqlInterval<CqlDate> ah_ = CumulativeMedicationDuration_4_0_000.Instance.MedicationRequestPeriod(context, AromataseInhibitorActive);
			CqlDate ai_ = context.Operators.Start(ah_);
			CqlDateTime aj_ = context.Operators.ConvertDateToDateTime(ai_);
			CqlInterval<CqlDateTime> ak_ = this.Measurement_Period(context);
			CqlDateTime al_ = context.Operators.Start(ak_);
			bool? am_ = context.Operators.Before(aj_, al_, default);

			return am_;
		};
		IEnumerable<MedicationRequest> m_ = context.Operators.Where<MedicationRequest>(k_, l_);
		IEnumerable<object> n_ = context.Operators.Union<object>(e_ as IEnumerable<object>, m_ as IEnumerable<object>);
		IEnumerable<MedicationRequest> p_ = context.Operators.RetrieveByValueSet<MedicationRequest>(f_, default);
		IEnumerable<MedicationRequest> r_ = context.Operators.RetrieveByValueSet<MedicationRequest>(f_, default);
		IEnumerable<MedicationRequest> s_ = context.Operators.Union<MedicationRequest>(p_, r_);
		IEnumerable<MedicationRequest> t_ = Status_1_6_000.Instance.Active_or_Completed_Medication_Request(context, s_);
		bool? u_(MedicationRequest AromataseInhibitorOrder)
		{
			FhirDateTime an_ = AromataseInhibitorOrder?.AuthoredOnElement;
			CqlDateTime ao_ = context.Operators.Convert<CqlDateTime>(an_);
			CqlInterval<CqlDateTime> ap_ = QICoreCommon_2_0_000.Instance.ToInterval(context, ao_ as object);
			CqlInterval<CqlDateTime> aq_()
			{
				bool as_()
				{
					CqlInterval<CqlDateTime> at_ = this.Measurement_Period(context);
					CqlDateTime au_ = context.Operators.Start(at_);

					return au_ is null;
				};
				if (as_())
				{
					return default;
				}
				else
				{
					CqlInterval<CqlDateTime> av_ = this.Measurement_Period(context);
					CqlDateTime aw_ = context.Operators.Start(av_);
					CqlDateTime ay_ = context.Operators.Start(av_);
					CqlInterval<CqlDateTime> az_ = context.Operators.Interval(aw_, ay_, true, true);

					return az_;
				}
			};
			bool? ar_ = context.Operators.Before(ap_, aq_(), default);

			return ar_;
		};
		IEnumerable<MedicationRequest> v_ = context.Operators.Where<MedicationRequest>(t_, u_);
		IEnumerable<object> w_ = context.Operators.Union<object>(n_ as IEnumerable<object>, v_ as IEnumerable<object>);
		IEnumerable<Observation> x_ = this.Parent_History_of_Hip_Fracture_Assessment(context);
		IEnumerable<object> y_ = context.Operators.Union<object>(w_ as IEnumerable<object>, x_ as IEnumerable<object>);
		bool? z_ = context.Operators.Exists<object>(y_);

		return z_;
	}


    [CqlDeclaration("Glucocorticoid Active Medication Duration in Days")]
	public int? Glucocorticoid_Active_Medication_Duration_in_Days(CqlContext context)
	{
		CqlValueSet a_ = this.Glucocorticoids__oral_only_(context);
		IEnumerable<MedicationRequest> b_ = context.Operators.RetrieveByValueSet<MedicationRequest>(a_, default);
		IEnumerable<MedicationRequest> d_ = context.Operators.RetrieveByValueSet<MedicationRequest>(a_, default);
		IEnumerable<MedicationRequest> e_ = context.Operators.Union<MedicationRequest>(b_, d_);
		IEnumerable<MedicationRequest> f_ = Status_1_6_000.Instance.Active_Medication(context, e_);
		bool? g_(MedicationRequest OralGlucocorticoid)
		{
			CqlInterval<CqlDate> l_ = CumulativeMedicationDuration_4_0_000.Instance.MedicationRequestPeriod(context, OralGlucocorticoid);
			CqlDate m_ = context.Operators.Start(l_);
			CqlDateTime n_ = context.Operators.ConvertDateToDateTime(m_);
			CqlInterval<CqlDateTime> o_ = this.Measurement_Period(context);
			CqlDateTime p_ = context.Operators.End(o_);
			bool? q_ = context.Operators.Before(n_, p_, default);

			return q_;
		};
		IEnumerable<MedicationRequest> h_ = context.Operators.Where<MedicationRequest>(f_, g_);
		CqlInterval<CqlDate> i_(MedicationRequest Glucocorticoid)
		{
			CqlInterval<CqlDate> r_ = CumulativeMedicationDuration_4_0_000.Instance.MedicationRequestPeriod(context, Glucocorticoid);
			Patient s_ = this.Patient(context);
			Date t_ = s_?.BirthDateElement;
			string u_ = t_?.Value;
			CqlDate v_ = context.Operators.ConvertStringToDate(u_);
			CqlInterval<CqlDateTime> w_ = this.Measurement_Period(context);
			CqlDateTime x_ = context.Operators.End(w_);
			CqlDate y_ = context.Operators.DateFrom(x_);
			CqlInterval<CqlDate> z_ = context.Operators.Interval(v_, y_, true, true);
			CqlInterval<CqlDate> aa_ = context.Operators.Intersect<CqlDate>(r_, z_);

			return aa_;
		};
		IEnumerable<CqlInterval<CqlDate>> j_ = context.Operators.Select<MedicationRequest, CqlInterval<CqlDate>>(h_, i_);
		int? k_ = CumulativeMedicationDuration_4_0_000.Instance.CumulativeDuration(context, j_);

		return k_;
	}


    [CqlDeclaration("Glucocorticoid Active Medication Days")]
	public int? Glucocorticoid_Active_Medication_Days(CqlContext context)
	{
		int? a_ = this.Glucocorticoid_Active_Medication_Duration_in_Days(context);

		return a_;
	}


    [CqlDeclaration("Has 90 or More Active Glucocorticoid Medication Days")]
	public bool? Has_90_or_More_Active_Glucocorticoid_Medication_Days(CqlContext context)
	{
		int? a_ = this.Glucocorticoid_Active_Medication_Days(context);
		bool? b_ = context.Operators.GreaterOrEqual(a_, 90);

		return b_;
	}

	public IEnumerable<Condition> DiagnosisInPatientHistory(CqlContext context, IEnumerable<Condition> Condition)
	{
		bool? a_(Condition Dx)
		{
			CqlInterval<CqlDateTime> c_ = QICoreCommon_2_0_000.Instance.ToPrevalenceInterval(context, Dx);
			CqlDateTime d_ = context.Operators.Start(c_);
			CqlInterval<CqlDateTime> e_ = this.Measurement_Period(context);
			CqlDateTime f_ = context.Operators.End(e_);
			bool? g_ = context.Operators.SameOrBefore(d_, f_, "day");

			return g_;
		};
		IEnumerable<Condition> b_ = context.Operators.Where<Condition>(Condition, a_);

		return b_;
	}

	public IEnumerable<Procedure> ProcedureInPatientHistory(CqlContext context, IEnumerable<Procedure> Procedure)
	{
		IEnumerable<Procedure> a_ = Status_1_6_000.Instance.Completed_Procedure(context, Procedure);
		bool? b_(Procedure Proc)
		{
			DataType d_ = Proc?.Performed;
			object e_ = FHIRHelpers_4_3_000.Instance.ToValue(context, d_);
			CqlInterval<CqlDateTime> f_ = QICoreCommon_2_0_000.Instance.ToInterval(context, e_);
			CqlDateTime g_ = context.Operators.End(f_);
			CqlInterval<CqlDateTime> h_ = this.Measurement_Period(context);
			CqlDateTime i_ = context.Operators.End(h_);
			bool? j_ = context.Operators.SameOrBefore(g_, i_, "day");

			return j_;
		};
		IEnumerable<Procedure> c_ = context.Operators.Where<Procedure>(a_, b_);

		return c_;
	}


    [CqlDeclaration("Has Double or Bilateral Oophorectomy")]
	public bool? Has_Double_or_Bilateral_Oophorectomy(CqlContext context)
	{
		CqlValueSet a_ = this.Bilateral_Oophorectomy(context);
		IEnumerable<Procedure> b_ = context.Operators.RetrieveByValueSet<Procedure>(a_, default);
		IEnumerable<Procedure> c_ = this.ProcedureInPatientHistory(context, b_);
		bool? d_ = context.Operators.Exists<Procedure>(c_);
		CqlValueSet e_ = this.Evidence_of_Bilateral_Oophorectomy(context);
		IEnumerable<Procedure> f_ = context.Operators.RetrieveByValueSet<Procedure>(e_, default);
		IEnumerable<Procedure> g_ = this.ProcedureInPatientHistory(context, f_);
		bool? h_ = context.Operators.Exists<Procedure>(g_);
		bool? i_ = context.Operators.Or(d_, h_);
		CqlValueSet j_ = this.Unilateral_Oophorectomy__Unspecified_Laterality(context);
		IEnumerable<Procedure> k_ = context.Operators.RetrieveByValueSet<Procedure>(j_, default);
		bool? l_(Procedure UnilateralOophorectomy)
		{
			List<CodeableConcept> ad_ = UnilateralOophorectomy?.BodySite;
			CqlConcept ae_(CodeableConcept @this)
			{
				CqlConcept aj_ = FHIRHelpers_4_3_000.Instance.ToConcept(context, @this);

				return aj_;
			};
			IEnumerable<CqlConcept> af_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)ad_, ae_);
			bool? ag_(CqlConcept C)
			{
				CqlCode ak_ = this.Right__qualifier_value_(context);
				CqlConcept al_ = context.Operators.ConvertCodeToConcept(ak_);
				bool? am_ = context.Operators.Equivalent(C, al_);

				return am_;
			};
			IEnumerable<CqlConcept> ah_ = context.Operators.Where<CqlConcept>(af_, ag_);
			bool? ai_ = context.Operators.Exists<CqlConcept>(ah_);

			return ai_;
		};
		IEnumerable<Procedure> m_ = context.Operators.Where<Procedure>(k_, l_);
		CqlValueSet n_ = this.Unilateral_Oophorectomy_Right(context);
		IEnumerable<Procedure> o_ = context.Operators.RetrieveByValueSet<Procedure>(n_, default);
		IEnumerable<Procedure> p_ = context.Operators.Union<Procedure>(m_, o_);
		IEnumerable<Procedure> q_ = this.ProcedureInPatientHistory(context, p_);
		bool? r_ = context.Operators.Exists<Procedure>(q_);
		IEnumerable<Procedure> t_ = context.Operators.RetrieveByValueSet<Procedure>(j_, default);
		bool? u_(Procedure UnilateralOophorectomy)
		{
			List<CodeableConcept> an_ = UnilateralOophorectomy?.BodySite;
			CqlConcept ao_(CodeableConcept @this)
			{
				CqlConcept at_ = FHIRHelpers_4_3_000.Instance.ToConcept(context, @this);

				return at_;
			};
			IEnumerable<CqlConcept> ap_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)an_, ao_);
			bool? aq_(CqlConcept D)
			{
				CqlCode au_ = this.Left__qualifier_value_(context);
				CqlConcept av_ = context.Operators.ConvertCodeToConcept(au_);
				bool? aw_ = context.Operators.Equivalent(D, av_);

				return aw_;
			};
			IEnumerable<CqlConcept> ar_ = context.Operators.Where<CqlConcept>(ap_, aq_);
			bool? as_ = context.Operators.Exists<CqlConcept>(ar_);

			return as_;
		};
		IEnumerable<Procedure> v_ = context.Operators.Where<Procedure>(t_, u_);
		CqlValueSet w_ = this.Unilateral_Oophorectomy_Left(context);
		IEnumerable<Procedure> x_ = context.Operators.RetrieveByValueSet<Procedure>(w_, default);
		IEnumerable<Procedure> y_ = context.Operators.Union<Procedure>(v_, x_);
		IEnumerable<Procedure> z_ = this.ProcedureInPatientHistory(context, y_);
		bool? aa_ = context.Operators.Exists<Procedure>(z_);
		bool? ab_ = context.Operators.And(r_, aa_);
		bool? ac_ = context.Operators.Or(i_, ab_);

		return ac_;
	}


    [CqlDeclaration("Has Organ Transplants")]
	public bool? Has_Organ_Transplants(CqlContext context)
	{
		CqlValueSet a_ = this.Major_Transplant(context);
		IEnumerable<Procedure> b_ = context.Operators.RetrieveByValueSet<Procedure>(a_, default);
		CqlValueSet c_ = this.Kidney_Transplant(context);
		IEnumerable<Procedure> d_ = context.Operators.RetrieveByValueSet<Procedure>(c_, default);
		IEnumerable<Procedure> e_ = context.Operators.Union<Procedure>(b_, d_);
		CqlValueSet f_ = this.Bone_Marrow_Transplant(context);
		IEnumerable<Procedure> g_ = context.Operators.RetrieveByValueSet<Procedure>(f_, default);
		IEnumerable<Procedure> h_ = context.Operators.Union<Procedure>(e_, g_);
		IEnumerable<Procedure> i_ = this.ProcedureInPatientHistory(context, h_);
		bool? j_ = context.Operators.Exists<Procedure>(i_);

		return j_;
	}


    [CqlDeclaration("Has Risk Factor Any Time in History or During Measurement Period")]
	public bool? Has_Risk_Factor_Any_Time_in_History_or_During_Measurement_Period(CqlContext context)
	{
		bool? a_ = this.Has_90_or_More_Active_Glucocorticoid_Medication_Days(context);
		CqlValueSet b_ = this.Osteoporotic_Fractures(context);
		IEnumerable<Condition> c_ = context.Operators.RetrieveByValueSet<Condition>(b_, default);
		CqlValueSet d_ = this.Malabsorption_Syndromes(context);
		IEnumerable<Condition> e_ = context.Operators.RetrieveByValueSet<Condition>(d_, default);
		IEnumerable<Condition> f_ = context.Operators.Union<Condition>(c_, e_);
		CqlValueSet g_ = this.Chronic_Malnutrition(context);
		IEnumerable<Condition> h_ = context.Operators.RetrieveByValueSet<Condition>(g_, default);
		CqlValueSet i_ = this.Chronic_Liver_Disease(context);
		IEnumerable<Condition> j_ = context.Operators.RetrieveByValueSet<Condition>(i_, default);
		IEnumerable<Condition> k_ = context.Operators.Union<Condition>(h_, j_);
		IEnumerable<Condition> l_ = context.Operators.Union<Condition>(f_, k_);
		CqlValueSet m_ = this.Rheumatoid_Arthritis(context);
		IEnumerable<Condition> n_ = context.Operators.RetrieveByValueSet<Condition>(m_, default);
		CqlValueSet o_ = this.Hyperthyroidism(context);
		IEnumerable<Condition> p_ = context.Operators.RetrieveByValueSet<Condition>(o_, default);
		IEnumerable<Condition> q_ = context.Operators.Union<Condition>(n_, p_);
		IEnumerable<Condition> r_ = context.Operators.Union<Condition>(l_, q_);
		CqlValueSet s_ = this.Type_1_Diabetes(context);
		IEnumerable<Condition> t_ = context.Operators.RetrieveByValueSet<Condition>(s_, default);
		CqlValueSet u_ = this.End_Stage_Renal_Disease(context);
		IEnumerable<Condition> v_ = context.Operators.RetrieveByValueSet<Condition>(u_, default);
		IEnumerable<Condition> w_ = context.Operators.Union<Condition>(t_, v_);
		IEnumerable<Condition> x_ = context.Operators.Union<Condition>(r_, w_);
		CqlValueSet y_ = this.Osteogenesis_Imperfecta(context);
		IEnumerable<Condition> z_ = context.Operators.RetrieveByValueSet<Condition>(y_, default);
		CqlValueSet aa_ = this.Ankylosing_Spondylitis(context);
		IEnumerable<Condition> ab_ = context.Operators.RetrieveByValueSet<Condition>(aa_, default);
		IEnumerable<Condition> ac_ = context.Operators.Union<Condition>(z_, ab_);
		IEnumerable<Condition> ad_ = context.Operators.Union<Condition>(x_, ac_);
		CqlValueSet ae_ = this.Psoriatic_Arthritis(context);
		IEnumerable<Condition> af_ = context.Operators.RetrieveByValueSet<Condition>(ae_, default);
		CqlValueSet ag_ = this.Ehlers_Danlos_Syndrome(context);
		IEnumerable<Condition> ah_ = context.Operators.RetrieveByValueSet<Condition>(ag_, default);
		IEnumerable<Condition> ai_ = context.Operators.Union<Condition>(af_, ah_);
		IEnumerable<Condition> aj_ = context.Operators.Union<Condition>(ad_, ai_);
		CqlValueSet ak_ = this.Cushings_Syndrome(context);
		IEnumerable<Condition> al_ = context.Operators.RetrieveByValueSet<Condition>(ak_, default);
		CqlValueSet am_ = this.Hyperparathyroidism(context);
		IEnumerable<Condition> an_ = context.Operators.RetrieveByValueSet<Condition>(am_, default);
		IEnumerable<Condition> ao_ = context.Operators.Union<Condition>(al_, an_);
		IEnumerable<Condition> ap_ = context.Operators.Union<Condition>(aj_, ao_);
		CqlValueSet aq_ = this.Marfans_Syndrome(context);
		IEnumerable<Condition> ar_ = context.Operators.RetrieveByValueSet<Condition>(aq_, default);
		CqlValueSet as_ = this.Lupus(context);
		IEnumerable<Condition> at_ = context.Operators.RetrieveByValueSet<Condition>(as_, default);
		IEnumerable<Condition> au_ = context.Operators.Union<Condition>(ar_, at_);
		IEnumerable<Condition> av_ = context.Operators.Union<Condition>(ap_, au_);
		CqlValueSet aw_ = this.Multiple_Myeloma(context);
		IEnumerable<Condition> ax_ = context.Operators.RetrieveByValueSet<Condition>(aw_, default);
		CqlValueSet ay_ = this.Premature_Menopause(context);
		IEnumerable<Condition> az_ = context.Operators.RetrieveByValueSet<Condition>(ay_, default);
		IEnumerable<Condition> ba_ = context.Operators.Union<Condition>(ax_, az_);
		IEnumerable<Condition> bb_ = context.Operators.Union<Condition>(av_, ba_);
		CqlValueSet bc_ = this.Eating_Disorders(context);
		IEnumerable<Condition> bd_ = context.Operators.RetrieveByValueSet<Condition>(bc_, default);
		CqlValueSet be_ = this.Amenorrhea(context);
		IEnumerable<Condition> bf_ = context.Operators.RetrieveByValueSet<Condition>(be_, default);
		IEnumerable<Condition> bg_ = context.Operators.Union<Condition>(bd_, bf_);
		IEnumerable<Condition> bh_ = context.Operators.Union<Condition>(bb_, bg_);
		IEnumerable<Condition> bi_ = this.DiagnosisInPatientHistory(context, bh_);
		bool? bj_ = context.Operators.Exists<Condition>(bi_);
		bool? bk_ = context.Operators.Or(a_, bj_);
		CqlValueSet bl_ = this.Chemotherapy(context);
		IEnumerable<Procedure> bm_ = context.Operators.RetrieveByValueSet<Procedure>(bl_, default);
		IEnumerable<Procedure> bn_ = this.ProcedureInPatientHistory(context, bm_);
		bool? bo_ = context.Operators.Exists<Procedure>(bn_);
		bool? bp_ = context.Operators.Or(bk_, bo_);
		bool? bq_ = this.Has_Double_or_Bilateral_Oophorectomy(context);
		bool? br_ = context.Operators.Or(bp_, bq_);
		bool? bs_ = this.Has_Organ_Transplants(context);
		bool? bt_ = context.Operators.Or(br_, bs_);

		return bt_;
	}


    [CqlDeclaration("Denominator Exclusions")]
	public bool? Denominator_Exclusions(CqlContext context)
	{
		bool? a_ = this.Has_Risk_Factor_Active_During_the_Measurement_Period(context);
		bool? b_ = this.Has_Risk_Factor_Any_Time_in_History_Prior_to_Measurement_Period(context);
		bool? c_ = context.Operators.Or(a_, b_);
		bool? d_ = this.Has_Risk_Factor_Any_Time_in_History_Prior_to_Measurement_Period_and_Do_Not_Need_to_be_Active_During_Measurement_Period(context);
		bool? e_ = context.Operators.Or(c_, d_);
		bool? f_ = this.Has_Risk_Factor_Any_Time_in_History_or_During_Measurement_Period(context);
		bool? g_ = context.Operators.Or(e_, f_);

		return g_;
	}


    [CqlDeclaration("DXA Scan Order During Measurement Period")]
	public IEnumerable<ServiceRequest> DXA_Scan_Order_During_Measurement_Period(CqlContext context)
	{
		CqlValueSet a_ = this.DXA__Dual_energy_Xray_Absorptiometry__Scan(context);
		IEnumerable<ServiceRequest> b_ = context.Operators.RetrieveByValueSet<ServiceRequest>(a_, default);
		IEnumerable<ServiceRequest> c_ = Status_1_6_000.Instance.Completed_or_Ongoing_Service_Request(context, b_);
		bool? d_(ServiceRequest DXA)
		{
			CqlInterval<CqlDateTime> h_ = this.Measurement_Period(context);
			FhirDateTime i_ = DXA?.AuthoredOnElement;
			CqlDateTime j_ = context.Operators.Convert<CqlDateTime>(i_);
			CqlInterval<CqlDateTime> k_ = QICoreCommon_2_0_000.Instance.ToInterval(context, j_ as object);
			bool? l_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(h_, k_, default);

			return l_;
		};
		IEnumerable<ServiceRequest> e_ = context.Operators.Where<ServiceRequest>(c_, d_);
		object f_(ServiceRequest @this)
		{
			FhirDateTime m_ = @this?.AuthoredOnElement;
			CqlDateTime n_ = context.Operators.Convert<CqlDateTime>(m_);

			return n_;
		};
		IEnumerable<ServiceRequest> g_ = context.Operators.SortBy<ServiceRequest>(e_, f_, System.ComponentModel.ListSortDirection.Ascending);

		return g_;
	}


    [CqlDeclaration("Numerator")]
	public bool? Numerator(CqlContext context)
	{
		IEnumerable<ServiceRequest> a_ = this.DXA_Scan_Order_During_Measurement_Period(context);
		bool? b_ = context.Operators.Exists<ServiceRequest>(a_);

		return b_;
	}


    [CqlDeclaration("Osteoporosis Fracture Risk Assessment Prior to First DXA Scan")]
	public IEnumerable<Observation> Osteoporosis_Fracture_Risk_Assessment_Prior_to_First_DXA_Scan(CqlContext context)
	{
		CqlCode a_ = this.Major_osteoporotic_fracture_10_year_probability__Likelihood__Fracture_Risk_Assessment(context);
		IEnumerable<CqlCode> b_ = context.Operators.ToList<CqlCode>(a_);
		IEnumerable<Observation> c_ = context.Operators.RetrieveByCodes<Observation>(b_, default);
		IEnumerable<Observation> d_ = Status_1_6_000.Instance.Final_Survey_Observation(context, c_);
		bool? e_(Observation FRAX)
		{
			DataType ad_ = FRAX?.Value;
			object ae_ = FHIRHelpers_4_3_000.Instance.ToValue(context, ad_);
			CqlQuantity af_ = context.Operators.Quantity(8.4m, "%");
			bool? ag_ = context.Operators.GreaterOrEqual(ae_ as CqlQuantity, af_);

			return ag_;
		};
		IEnumerable<Observation> f_ = context.Operators.Where<Observation>(d_, e_);
		CqlCode g_ = this.Osteoporosis_Risk_Assessment_Instrument(context);
		IEnumerable<CqlCode> h_ = context.Operators.ToList<CqlCode>(g_);
		IEnumerable<Observation> i_ = context.Operators.RetrieveByCodes<Observation>(h_, default);
		IEnumerable<Observation> j_ = Status_1_6_000.Instance.Final_Survey_Observation(context, i_);
		bool? k_(Observation ORAI)
		{
			DataType ah_ = ORAI?.Value;
			object ai_ = FHIRHelpers_4_3_000.Instance.ToValue(context, ah_);
			bool? aj_ = context.Operators.GreaterOrEqual(ai_ as int?, 9);

			return aj_;
		};
		IEnumerable<Observation> l_ = context.Operators.Where<Observation>(j_, k_);
		IEnumerable<Observation> m_ = context.Operators.Union<Observation>(f_, l_);
		CqlCode n_ = this.Osteoporosis_Index_of_Risk_panel(context);
		IEnumerable<CqlCode> o_ = context.Operators.ToList<CqlCode>(n_);
		IEnumerable<Observation> p_ = context.Operators.RetrieveByCodes<Observation>(o_, default);
		IEnumerable<Observation> q_ = Status_1_6_000.Instance.Final_Survey_Observation(context, p_);
		bool? r_(Observation OSIRIS)
		{
			DataType ak_ = OSIRIS?.Value;
			object al_ = FHIRHelpers_4_3_000.Instance.ToValue(context, ak_);
			CqlQuantity am_ = context.Operators.ConvertDecimalToQuantity(1.0m);
			bool? an_ = context.Operators.Less(al_ as CqlQuantity, am_);

			return an_;
		};
		IEnumerable<Observation> s_ = context.Operators.Where<Observation>(q_, r_);
		CqlCode t_ = this.Osteoporosis_Self_Assessment_Tool(context);
		IEnumerable<CqlCode> u_ = context.Operators.ToList<CqlCode>(t_);
		IEnumerable<Observation> v_ = context.Operators.RetrieveByCodes<Observation>(u_, default);
		IEnumerable<Observation> w_ = Status_1_6_000.Instance.Final_Survey_Observation(context, v_);
		bool? x_(Observation OST)
		{
			DataType ao_ = OST?.Value;
			object ap_ = FHIRHelpers_4_3_000.Instance.ToValue(context, ao_);
			CqlQuantity aq_ = context.Operators.ConvertDecimalToQuantity(2.0m);
			bool? ar_ = context.Operators.Less(ap_ as CqlQuantity, aq_);

			return ar_;
		};
		IEnumerable<Observation> y_ = context.Operators.Where<Observation>(w_, x_);
		IEnumerable<Observation> z_ = context.Operators.Union<Observation>(s_, y_);
		IEnumerable<Observation> aa_ = context.Operators.Union<Observation>(m_, z_);
		bool? ab_(Observation RiskAssessment)
		{
			DataType as_ = RiskAssessment?.Effective;
			object at_ = FHIRHelpers_4_3_000.Instance.ToValue(context, as_);
			CqlInterval<CqlDateTime> au_ = QICoreCommon_2_0_000.Instance.ToInterval(context, at_);
			CqlDateTime av_ = context.Operators.Start(au_);
			IEnumerable<ServiceRequest> aw_ = this.DXA_Scan_Order_During_Measurement_Period(context);
			ServiceRequest ax_ = context.Operators.First<ServiceRequest>(aw_);
			FhirDateTime ay_ = ax_?.AuthoredOnElement;
			CqlDateTime az_ = context.Operators.Convert<CqlDateTime>(ay_);
			bool? ba_ = context.Operators.Before(av_, az_, default);

			return ba_;
		};
		IEnumerable<Observation> ac_ = context.Operators.Where<Observation>(aa_, ab_);

		return ac_;
	}


    [CqlDeclaration("Numerator Exclusion")]
	public bool? Numerator_Exclusion(CqlContext context)
	{
		IEnumerable<Observation> a_ = this.Osteoporosis_Fracture_Risk_Assessment_Prior_to_First_DXA_Scan(context);
		bool? b_ = context.Operators.Exists<Observation>(a_);

		return b_;
	}

	public IEnumerable<Observation> Final_Survey_Observation(CqlContext context, IEnumerable<Observation> Obs)
	{
		bool? a_(Observation O)
		{
			Code<ObservationStatus> c_ = O?.StatusElement;
			ObservationStatus? d_ = c_?.Value;
			Code<ObservationStatus> e_ = context.Operators.Convert<Code<ObservationStatus>>(d_);
			string f_ = context.Operators.Convert<string>(e_);
			string[] g_ = [
				"final",
				"amended",
				"corrected",
			];
			bool? h_ = context.Operators.In<string>(f_, g_ as IEnumerable<string>);
			List<CodeableConcept> i_ = O?.Category;
			CqlConcept j_(CodeableConcept @this)
			{
				CqlConcept n_ = FHIRHelpers_4_3_000.Instance.ToConcept(context, @this);

				return n_;
			};
			IEnumerable<CqlConcept> k_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)i_, j_);
			bool? l_ = context.Operators.Exists<CqlConcept>(k_);
			bool? m_ = context.Operators.And(h_, l_);

			return m_;
		};
		IEnumerable<Observation> b_ = context.Operators.Where<Observation>(Obs, a_);

		return b_;
	}

}

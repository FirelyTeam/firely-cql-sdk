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
[CqlLibrary("AppropriateDXAScansForWomenUnder65FHIR", "0.0.000")]
public class AppropriateDXAScansForWomenUnder65FHIR_0_0_000
{


    internal CqlContext context;

    #region Cached values

    internal Lazy<CqlValueSet> __Amenorrhea;
    internal Lazy<CqlValueSet> __Ankylosing_Spondylitis;
    internal Lazy<CqlValueSet> __Aromatase_Inhibitors;
    internal Lazy<CqlValueSet> __Bilateral_Oophorectomy;
    internal Lazy<CqlValueSet> __Bone_Marrow_Transplant;
    internal Lazy<CqlValueSet> __Chemotherapy;
    internal Lazy<CqlValueSet> __Chronic_Liver_Disease;
    internal Lazy<CqlValueSet> __Chronic_Malnutrition;
    internal Lazy<CqlValueSet> __Cushings_Syndrome;
    internal Lazy<CqlValueSet> __DXA__Dual_energy_Xray_Absorptiometry__Scan;
    internal Lazy<CqlValueSet> __Eating_Disorders;
    internal Lazy<CqlValueSet> __Ehlers_Danlos_Syndrome;
    internal Lazy<CqlValueSet> __End_Stage_Renal_Disease;
    internal Lazy<CqlValueSet> __Evidence_of_Bilateral_Oophorectomy;
    internal Lazy<CqlValueSet> __Gastric_Bypass_Surgery;
    internal Lazy<CqlValueSet> __Glucocorticoids__oral_only_;
    internal Lazy<CqlValueSet> __History_of_hip_fracture_in_parent;
    internal Lazy<CqlValueSet> __Hyperparathyroidism;
    internal Lazy<CqlValueSet> __Hyperthyroidism;
    internal Lazy<CqlValueSet> __Kidney_Transplant;
    internal Lazy<CqlValueSet> __Lupus;
    internal Lazy<CqlValueSet> __Major_Transplant;
    internal Lazy<CqlValueSet> __Malabsorption_Syndromes;
    internal Lazy<CqlValueSet> __Marfans_Syndrome;
    internal Lazy<CqlValueSet> __Multiple_Myeloma;
    internal Lazy<CqlValueSet> __Office_Visit;
    internal Lazy<CqlValueSet> __Online_Assessments;
    internal Lazy<CqlValueSet> __Osteogenesis_Imperfecta;
    internal Lazy<CqlValueSet> __Osteopenia;
    internal Lazy<CqlValueSet> __Osteoporosis;
    internal Lazy<CqlValueSet> __Osteoporotic_Fractures;
    internal Lazy<CqlValueSet> __Outpatient_Consultation;
    internal Lazy<CqlValueSet> __Premature_Menopause;
    internal Lazy<CqlValueSet> __Preventive_Care_Services_Established_Office_Visit__18_and_Up;
    internal Lazy<CqlValueSet> __Preventive_Care_Services_Initial_Office_Visit__18_and_Up;
    internal Lazy<CqlValueSet> __Psoriatic_Arthritis;
    internal Lazy<CqlValueSet> __Rheumatoid_Arthritis;
    internal Lazy<CqlValueSet> __Telephone_Visits;
    internal Lazy<CqlValueSet> __Type_1_Diabetes;
    internal Lazy<CqlValueSet> __Unilateral_Oophorectomy_Left;
    internal Lazy<CqlValueSet> __Unilateral_Oophorectomy_Right;
    internal Lazy<CqlValueSet> __Unilateral_Oophorectomy__Unspecified_Laterality;
    internal Lazy<CqlCode> __Alcoholic_drinks_per_drinking_day___Reported;
    internal Lazy<CqlCode> __Body_mass_index__BMI___Ratio_;
    internal Lazy<CqlCode> __Female;
    internal Lazy<CqlCode> __Left__qualifier_value_;
    internal Lazy<CqlCode> __Major_osteoporotic_fracture_10_year_probability__Likelihood__Fracture_Risk_Assessment;
    internal Lazy<CqlCode> __Osteoporosis_Index_of_Risk_panel;
    internal Lazy<CqlCode> __Osteoporosis_Risk_Assessment_Instrument;
    internal Lazy<CqlCode> __Osteoporosis_Self_Assessment_Tool;
    internal Lazy<CqlCode> __Right__qualifier_value_;
    internal Lazy<CqlCode> __Unlisted_preventive_medicine_service;
    internal Lazy<CqlCode[]> __LOINC;
    internal Lazy<CqlCode[]> __AdministrativeGender;
    internal Lazy<CqlCode[]> __SNOMEDCT;
    internal Lazy<CqlCode[]> __CPT;
    internal Lazy<CqlInterval<CqlDateTime>> __Measurement_Period;
    internal Lazy<Patient> __Patient;
    internal Lazy<Tuple_DMgHTLENEHBHWJISQgKZGZVMB> __SDE_Ethnicity;
    internal Lazy<IEnumerable<Tuple_GDKRbfOIHhLGieQSVDEMIaDPX>> __SDE_Payer;
    internal Lazy<Tuple_DMgHTLENEHBHWJISQgKZGZVMB> __SDE_Race;
    internal Lazy<CqlCode> __SDE_Sex;
    internal Lazy<IEnumerable<Encounter>> __Qualifying_Encounter;
    internal Lazy<bool?> __Initial_Population;
    internal Lazy<bool?> __Denominator;
    internal Lazy<Observation> __First_BMI_in_Measurement_Period;
    internal Lazy<Observation> __First_BMI_in_Measurement_Period_Less_Than_or_Equal_to_20_kg_m2;
    internal Lazy<Observation> __First_Average_Number_of_Drinks_Assessments_Indicating_More_Than_Two_Per_Day;
    internal Lazy<bool?> __Has_Risk_Factor_Active_During_the_Measurement_Period;
    internal Lazy<bool?> __Has_Osteoporosis_Before_Measurement_Period;
    internal Lazy<bool?> __Has_Osteopenia_Before_Measurement_Period;
    internal Lazy<bool?> __Has_Risk_Factor_Any_Time_in_History_Prior_to_Measurement_Period;
    internal Lazy<IEnumerable<Observation>> __Parent_History_of_Hip_Fracture_Assessment;
    internal Lazy<bool?> __Has_Risk_Factor_Any_Time_in_History_Prior_to_Measurement_Period_and_Do_Not_Need_to_be_Active_During_Measurement_Period;
    internal Lazy<int?> __Glucocorticoid_Active_Medication_Duration_in_Days;
    internal Lazy<int?> __Glucocorticoid_Active_Medication_Days;
    internal Lazy<bool?> __Has_90_or_More_Active_Glucocorticoid_Medication_Days;
    internal Lazy<bool?> __Has_Double_or_Bilateral_Oophorectomy;
    internal Lazy<bool?> __Has_Organ_Transplants;
    internal Lazy<bool?> __Has_Risk_Factor_Any_Time_in_History_or_During_Measurement_Period;
    internal Lazy<bool?> __Denominator_Exclusions;
    internal Lazy<IEnumerable<ServiceRequest>> __DXA_Scan_Order_During_Measurement_Period;
    internal Lazy<bool?> __Numerator;
    internal Lazy<IEnumerable<Observation>> __Osteoporosis_Fracture_Risk_Assessment_Prior_to_First_DXA_Scan;
    internal Lazy<bool?> __Numerator_Exclusion;

    #endregion
    public AppropriateDXAScansForWomenUnder65FHIR_0_0_000(CqlContext context)
    {
        this.context = context ?? throw new ArgumentNullException("context");

        FHIRHelpers_4_3_000 = new FHIRHelpers_4_3_000(context);
        SupplementalDataElements_3_4_000 = new SupplementalDataElements_3_4_000(context);
        CQMCommon_2_0_000 = new CQMCommon_2_0_000(context);
        QICoreCommon_2_0_000 = new QICoreCommon_2_0_000(context);
        Status_1_6_000 = new Status_1_6_000(context);
        CumulativeMedicationDuration_4_0_000 = new CumulativeMedicationDuration_4_0_000(context);
        Hospice_6_9_000 = new Hospice_6_9_000(context);

        __Amenorrhea = new Lazy<CqlValueSet>(this.Amenorrhea_Value);
        __Ankylosing_Spondylitis = new Lazy<CqlValueSet>(this.Ankylosing_Spondylitis_Value);
        __Aromatase_Inhibitors = new Lazy<CqlValueSet>(this.Aromatase_Inhibitors_Value);
        __Bilateral_Oophorectomy = new Lazy<CqlValueSet>(this.Bilateral_Oophorectomy_Value);
        __Bone_Marrow_Transplant = new Lazy<CqlValueSet>(this.Bone_Marrow_Transplant_Value);
        __Chemotherapy = new Lazy<CqlValueSet>(this.Chemotherapy_Value);
        __Chronic_Liver_Disease = new Lazy<CqlValueSet>(this.Chronic_Liver_Disease_Value);
        __Chronic_Malnutrition = new Lazy<CqlValueSet>(this.Chronic_Malnutrition_Value);
        __Cushings_Syndrome = new Lazy<CqlValueSet>(this.Cushings_Syndrome_Value);
        __DXA__Dual_energy_Xray_Absorptiometry__Scan = new Lazy<CqlValueSet>(this.DXA__Dual_energy_Xray_Absorptiometry__Scan_Value);
        __Eating_Disorders = new Lazy<CqlValueSet>(this.Eating_Disorders_Value);
        __Ehlers_Danlos_Syndrome = new Lazy<CqlValueSet>(this.Ehlers_Danlos_Syndrome_Value);
        __End_Stage_Renal_Disease = new Lazy<CqlValueSet>(this.End_Stage_Renal_Disease_Value);
        __Evidence_of_Bilateral_Oophorectomy = new Lazy<CqlValueSet>(this.Evidence_of_Bilateral_Oophorectomy_Value);
        __Gastric_Bypass_Surgery = new Lazy<CqlValueSet>(this.Gastric_Bypass_Surgery_Value);
        __Glucocorticoids__oral_only_ = new Lazy<CqlValueSet>(this.Glucocorticoids__oral_only__Value);
        __History_of_hip_fracture_in_parent = new Lazy<CqlValueSet>(this.History_of_hip_fracture_in_parent_Value);
        __Hyperparathyroidism = new Lazy<CqlValueSet>(this.Hyperparathyroidism_Value);
        __Hyperthyroidism = new Lazy<CqlValueSet>(this.Hyperthyroidism_Value);
        __Kidney_Transplant = new Lazy<CqlValueSet>(this.Kidney_Transplant_Value);
        __Lupus = new Lazy<CqlValueSet>(this.Lupus_Value);
        __Major_Transplant = new Lazy<CqlValueSet>(this.Major_Transplant_Value);
        __Malabsorption_Syndromes = new Lazy<CqlValueSet>(this.Malabsorption_Syndromes_Value);
        __Marfans_Syndrome = new Lazy<CqlValueSet>(this.Marfans_Syndrome_Value);
        __Multiple_Myeloma = new Lazy<CqlValueSet>(this.Multiple_Myeloma_Value);
        __Office_Visit = new Lazy<CqlValueSet>(this.Office_Visit_Value);
        __Online_Assessments = new Lazy<CqlValueSet>(this.Online_Assessments_Value);
        __Osteogenesis_Imperfecta = new Lazy<CqlValueSet>(this.Osteogenesis_Imperfecta_Value);
        __Osteopenia = new Lazy<CqlValueSet>(this.Osteopenia_Value);
        __Osteoporosis = new Lazy<CqlValueSet>(this.Osteoporosis_Value);
        __Osteoporotic_Fractures = new Lazy<CqlValueSet>(this.Osteoporotic_Fractures_Value);
        __Outpatient_Consultation = new Lazy<CqlValueSet>(this.Outpatient_Consultation_Value);
        __Premature_Menopause = new Lazy<CqlValueSet>(this.Premature_Menopause_Value);
        __Preventive_Care_Services_Established_Office_Visit__18_and_Up = new Lazy<CqlValueSet>(this.Preventive_Care_Services_Established_Office_Visit__18_and_Up_Value);
        __Preventive_Care_Services_Initial_Office_Visit__18_and_Up = new Lazy<CqlValueSet>(this.Preventive_Care_Services_Initial_Office_Visit__18_and_Up_Value);
        __Psoriatic_Arthritis = new Lazy<CqlValueSet>(this.Psoriatic_Arthritis_Value);
        __Rheumatoid_Arthritis = new Lazy<CqlValueSet>(this.Rheumatoid_Arthritis_Value);
        __Telephone_Visits = new Lazy<CqlValueSet>(this.Telephone_Visits_Value);
        __Type_1_Diabetes = new Lazy<CqlValueSet>(this.Type_1_Diabetes_Value);
        __Unilateral_Oophorectomy_Left = new Lazy<CqlValueSet>(this.Unilateral_Oophorectomy_Left_Value);
        __Unilateral_Oophorectomy_Right = new Lazy<CqlValueSet>(this.Unilateral_Oophorectomy_Right_Value);
        __Unilateral_Oophorectomy__Unspecified_Laterality = new Lazy<CqlValueSet>(this.Unilateral_Oophorectomy__Unspecified_Laterality_Value);
        __Alcoholic_drinks_per_drinking_day___Reported = new Lazy<CqlCode>(this.Alcoholic_drinks_per_drinking_day___Reported_Value);
        __Body_mass_index__BMI___Ratio_ = new Lazy<CqlCode>(this.Body_mass_index__BMI___Ratio__Value);
        __Female = new Lazy<CqlCode>(this.Female_Value);
        __Left__qualifier_value_ = new Lazy<CqlCode>(this.Left__qualifier_value__Value);
        __Major_osteoporotic_fracture_10_year_probability__Likelihood__Fracture_Risk_Assessment = new Lazy<CqlCode>(this.Major_osteoporotic_fracture_10_year_probability__Likelihood__Fracture_Risk_Assessment_Value);
        __Osteoporosis_Index_of_Risk_panel = new Lazy<CqlCode>(this.Osteoporosis_Index_of_Risk_panel_Value);
        __Osteoporosis_Risk_Assessment_Instrument = new Lazy<CqlCode>(this.Osteoporosis_Risk_Assessment_Instrument_Value);
        __Osteoporosis_Self_Assessment_Tool = new Lazy<CqlCode>(this.Osteoporosis_Self_Assessment_Tool_Value);
        __Right__qualifier_value_ = new Lazy<CqlCode>(this.Right__qualifier_value__Value);
        __Unlisted_preventive_medicine_service = new Lazy<CqlCode>(this.Unlisted_preventive_medicine_service_Value);
        __LOINC = new Lazy<CqlCode[]>(this.LOINC_Value);
        __AdministrativeGender = new Lazy<CqlCode[]>(this.AdministrativeGender_Value);
        __SNOMEDCT = new Lazy<CqlCode[]>(this.SNOMEDCT_Value);
        __CPT = new Lazy<CqlCode[]>(this.CPT_Value);
        __Measurement_Period = new Lazy<CqlInterval<CqlDateTime>>(this.Measurement_Period_Value);
        __Patient = new Lazy<Patient>(this.Patient_Value);
        __SDE_Ethnicity = new Lazy<Tuple_DMgHTLENEHBHWJISQgKZGZVMB>(this.SDE_Ethnicity_Value);
        __SDE_Payer = new Lazy<IEnumerable<Tuple_GDKRbfOIHhLGieQSVDEMIaDPX>>(this.SDE_Payer_Value);
        __SDE_Race = new Lazy<Tuple_DMgHTLENEHBHWJISQgKZGZVMB>(this.SDE_Race_Value);
        __SDE_Sex = new Lazy<CqlCode>(this.SDE_Sex_Value);
        __Qualifying_Encounter = new Lazy<IEnumerable<Encounter>>(this.Qualifying_Encounter_Value);
        __Initial_Population = new Lazy<bool?>(this.Initial_Population_Value);
        __Denominator = new Lazy<bool?>(this.Denominator_Value);
        __First_BMI_in_Measurement_Period = new Lazy<Observation>(this.First_BMI_in_Measurement_Period_Value);
        __First_BMI_in_Measurement_Period_Less_Than_or_Equal_to_20_kg_m2 = new Lazy<Observation>(this.First_BMI_in_Measurement_Period_Less_Than_or_Equal_to_20_kg_m2_Value);
        __First_Average_Number_of_Drinks_Assessments_Indicating_More_Than_Two_Per_Day = new Lazy<Observation>(this.First_Average_Number_of_Drinks_Assessments_Indicating_More_Than_Two_Per_Day_Value);
        __Has_Risk_Factor_Active_During_the_Measurement_Period = new Lazy<bool?>(this.Has_Risk_Factor_Active_During_the_Measurement_Period_Value);
        __Has_Osteoporosis_Before_Measurement_Period = new Lazy<bool?>(this.Has_Osteoporosis_Before_Measurement_Period_Value);
        __Has_Osteopenia_Before_Measurement_Period = new Lazy<bool?>(this.Has_Osteopenia_Before_Measurement_Period_Value);
        __Has_Risk_Factor_Any_Time_in_History_Prior_to_Measurement_Period = new Lazy<bool?>(this.Has_Risk_Factor_Any_Time_in_History_Prior_to_Measurement_Period_Value);
        __Parent_History_of_Hip_Fracture_Assessment = new Lazy<IEnumerable<Observation>>(this.Parent_History_of_Hip_Fracture_Assessment_Value);
        __Has_Risk_Factor_Any_Time_in_History_Prior_to_Measurement_Period_and_Do_Not_Need_to_be_Active_During_Measurement_Period = new Lazy<bool?>(this.Has_Risk_Factor_Any_Time_in_History_Prior_to_Measurement_Period_and_Do_Not_Need_to_be_Active_During_Measurement_Period_Value);
        __Glucocorticoid_Active_Medication_Duration_in_Days = new Lazy<int?>(this.Glucocorticoid_Active_Medication_Duration_in_Days_Value);
        __Glucocorticoid_Active_Medication_Days = new Lazy<int?>(this.Glucocorticoid_Active_Medication_Days_Value);
        __Has_90_or_More_Active_Glucocorticoid_Medication_Days = new Lazy<bool?>(this.Has_90_or_More_Active_Glucocorticoid_Medication_Days_Value);
        __Has_Double_or_Bilateral_Oophorectomy = new Lazy<bool?>(this.Has_Double_or_Bilateral_Oophorectomy_Value);
        __Has_Organ_Transplants = new Lazy<bool?>(this.Has_Organ_Transplants_Value);
        __Has_Risk_Factor_Any_Time_in_History_or_During_Measurement_Period = new Lazy<bool?>(this.Has_Risk_Factor_Any_Time_in_History_or_During_Measurement_Period_Value);
        __Denominator_Exclusions = new Lazy<bool?>(this.Denominator_Exclusions_Value);
        __DXA_Scan_Order_During_Measurement_Period = new Lazy<IEnumerable<ServiceRequest>>(this.DXA_Scan_Order_During_Measurement_Period_Value);
        __Numerator = new Lazy<bool?>(this.Numerator_Value);
        __Osteoporosis_Fracture_Risk_Assessment_Prior_to_First_DXA_Scan = new Lazy<IEnumerable<Observation>>(this.Osteoporosis_Fracture_Risk_Assessment_Prior_to_First_DXA_Scan_Value);
        __Numerator_Exclusion = new Lazy<bool?>(this.Numerator_Exclusion_Value);
    }
    #region Dependencies

    public FHIRHelpers_4_3_000 FHIRHelpers_4_3_000 { get; }
    public SupplementalDataElements_3_4_000 SupplementalDataElements_3_4_000 { get; }
    public CQMCommon_2_0_000 CQMCommon_2_0_000 { get; }
    public QICoreCommon_2_0_000 QICoreCommon_2_0_000 { get; }
    public Status_1_6_000 Status_1_6_000 { get; }
    public CumulativeMedicationDuration_4_0_000 CumulativeMedicationDuration_4_0_000 { get; }
    public Hospice_6_9_000 Hospice_6_9_000 { get; }

    #endregion

	private CqlValueSet Amenorrhea_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.1022", null);

    [CqlDeclaration("Amenorrhea")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.1022")]
	public CqlValueSet Amenorrhea() => 
		__Amenorrhea.Value;

	private CqlValueSet Ankylosing_Spondylitis_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.113.12.1045", null);

    [CqlDeclaration("Ankylosing Spondylitis")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.113.12.1045")]
	public CqlValueSet Ankylosing_Spondylitis() => 
		__Ankylosing_Spondylitis.Value;

	private CqlValueSet Aromatase_Inhibitors_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.196.12.1265", null);

    [CqlDeclaration("Aromatase Inhibitors")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.196.12.1265")]
	public CqlValueSet Aromatase_Inhibitors() => 
		__Aromatase_Inhibitors.Value;

	private CqlValueSet Bilateral_Oophorectomy_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.471", null);

    [CqlDeclaration("Bilateral Oophorectomy")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.471")]
	public CqlValueSet Bilateral_Oophorectomy() => 
		__Bilateral_Oophorectomy.Value;

	private CqlValueSet Bone_Marrow_Transplant_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.666.5.336", null);

    [CqlDeclaration("Bone Marrow Transplant")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.666.5.336")]
	public CqlValueSet Bone_Marrow_Transplant() => 
		__Bone_Marrow_Transplant.Value;

	private CqlValueSet Chemotherapy_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.485", null);

    [CqlDeclaration("Chemotherapy")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.485")]
	public CqlValueSet Chemotherapy() => 
		__Chemotherapy.Value;

	private CqlValueSet Chronic_Liver_Disease_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.199.12.1035", null);

    [CqlDeclaration("Chronic Liver Disease")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.199.12.1035")]
	public CqlValueSet Chronic_Liver_Disease() => 
		__Chronic_Liver_Disease.Value;

	private CqlValueSet Chronic_Malnutrition_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.199.12.1036", null);

    [CqlDeclaration("Chronic Malnutrition")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.199.12.1036")]
	public CqlValueSet Chronic_Malnutrition() => 
		__Chronic_Malnutrition.Value;

	private CqlValueSet Cushings_Syndrome_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.117.12.1009", null);

    [CqlDeclaration("Cushings Syndrome")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.117.12.1009")]
	public CqlValueSet Cushings_Syndrome() => 
		__Cushings_Syndrome.Value;

	private CqlValueSet DXA__Dual_energy_Xray_Absorptiometry__Scan_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.113.12.1051", null);

    [CqlDeclaration("DXA (Dual energy Xray Absorptiometry) Scan")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.113.12.1051")]
	public CqlValueSet DXA__Dual_energy_Xray_Absorptiometry__Scan() => 
		__DXA__Dual_energy_Xray_Absorptiometry__Scan.Value;

	private CqlValueSet Eating_Disorders_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.1039", null);

    [CqlDeclaration("Eating Disorders")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.1039")]
	public CqlValueSet Eating_Disorders() => 
		__Eating_Disorders.Value;

	private CqlValueSet Ehlers_Danlos_Syndrome_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.113.12.1047", null);

    [CqlDeclaration("Ehlers Danlos Syndrome")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.113.12.1047")]
	public CqlValueSet Ehlers_Danlos_Syndrome() => 
		__Ehlers_Danlos_Syndrome.Value;

	private CqlValueSet End_Stage_Renal_Disease_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.353", null);

    [CqlDeclaration("End Stage Renal Disease")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.353")]
	public CqlValueSet End_Stage_Renal_Disease() => 
		__End_Stage_Renal_Disease.Value;

	private CqlValueSet Evidence_of_Bilateral_Oophorectomy_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.1048", null);

    [CqlDeclaration("Evidence of Bilateral Oophorectomy")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.1048")]
	public CqlValueSet Evidence_of_Bilateral_Oophorectomy() => 
		__Evidence_of_Bilateral_Oophorectomy.Value;

	private CqlValueSet Gastric_Bypass_Surgery_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.198.12.1050", null);

    [CqlDeclaration("Gastric Bypass Surgery")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.198.12.1050")]
	public CqlValueSet Gastric_Bypass_Surgery() => 
		__Gastric_Bypass_Surgery.Value;

	private CqlValueSet Glucocorticoids__oral_only__Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.196.12.1266", null);

    [CqlDeclaration("Glucocorticoids (oral only)")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.196.12.1266")]
	public CqlValueSet Glucocorticoids__oral_only_() => 
		__Glucocorticoids__oral_only_.Value;

	private CqlValueSet History_of_hip_fracture_in_parent_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.113.12.1040", null);

    [CqlDeclaration("History of hip fracture in parent")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.113.12.1040")]
	public CqlValueSet History_of_hip_fracture_in_parent() => 
		__History_of_hip_fracture_in_parent.Value;

	private CqlValueSet Hyperparathyroidism_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.117.12.1016", null);

    [CqlDeclaration("Hyperparathyroidism")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.117.12.1016")]
	public CqlValueSet Hyperparathyroidism() => 
		__Hyperparathyroidism.Value;

	private CqlValueSet Hyperthyroidism_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.117.12.1015", null);

    [CqlDeclaration("Hyperthyroidism")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.117.12.1015")]
	public CqlValueSet Hyperthyroidism() => 
		__Hyperthyroidism.Value;

	private CqlValueSet Kidney_Transplant_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.109.12.1012", null);

    [CqlDeclaration("Kidney Transplant")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.109.12.1012")]
	public CqlValueSet Kidney_Transplant() => 
		__Kidney_Transplant.Value;

	private CqlValueSet Lupus_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.117.12.1010", null);

    [CqlDeclaration("Lupus")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.117.12.1010")]
	public CqlValueSet Lupus() => 
		__Lupus.Value;

	private CqlValueSet Major_Transplant_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.198.12.1075", null);

    [CqlDeclaration("Major Transplant")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.198.12.1075")]
	public CqlValueSet Major_Transplant() => 
		__Major_Transplant.Value;

	private CqlValueSet Malabsorption_Syndromes_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.199.12.1050", null);

    [CqlDeclaration("Malabsorption Syndromes")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.199.12.1050")]
	public CqlValueSet Malabsorption_Syndromes() => 
		__Malabsorption_Syndromes.Value;

	private CqlValueSet Marfans_Syndrome_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.113.12.1048", null);

    [CqlDeclaration("Marfan's Syndrome")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.113.12.1048")]
	public CqlValueSet Marfans_Syndrome() => 
		__Marfans_Syndrome.Value;

	private CqlValueSet Multiple_Myeloma_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.1011", null);

    [CqlDeclaration("Multiple Myeloma")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.1011")]
	public CqlValueSet Multiple_Myeloma() => 
		__Multiple_Myeloma.Value;

	private CqlValueSet Office_Visit_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1001", null);

    [CqlDeclaration("Office Visit")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1001")]
	public CqlValueSet Office_Visit() => 
		__Office_Visit.Value;

	private CqlValueSet Online_Assessments_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1089", null);

    [CqlDeclaration("Online Assessments")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1089")]
	public CqlValueSet Online_Assessments() => 
		__Online_Assessments.Value;

	private CqlValueSet Osteogenesis_Imperfecta_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.113.12.1044", null);

    [CqlDeclaration("Osteogenesis Imperfecta")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.113.12.1044")]
	public CqlValueSet Osteogenesis_Imperfecta() => 
		__Osteogenesis_Imperfecta.Value;

	private CqlValueSet Osteopenia_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.113.12.1049", null);

    [CqlDeclaration("Osteopenia")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.113.12.1049")]
	public CqlValueSet Osteopenia() => 
		__Osteopenia.Value;

	private CqlValueSet Osteoporosis_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.113.12.1038", null);

    [CqlDeclaration("Osteoporosis")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.113.12.1038")]
	public CqlValueSet Osteoporosis() => 
		__Osteoporosis.Value;

	private CqlValueSet Osteoporotic_Fractures_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.113.12.1050", null);

    [CqlDeclaration("Osteoporotic Fractures")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.113.12.1050")]
	public CqlValueSet Osteoporotic_Fractures() => 
		__Osteoporotic_Fractures.Value;

	private CqlValueSet Outpatient_Consultation_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1008", null);

    [CqlDeclaration("Outpatient Consultation")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1008")]
	public CqlValueSet Outpatient_Consultation() => 
		__Outpatient_Consultation.Value;

	private CqlValueSet Premature_Menopause_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.1013", null);

    [CqlDeclaration("Premature Menopause")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.1013")]
	public CqlValueSet Premature_Menopause() => 
		__Premature_Menopause.Value;

	private CqlValueSet Preventive_Care_Services_Established_Office_Visit__18_and_Up_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1025", null);

    [CqlDeclaration("Preventive Care Services Established Office Visit, 18 and Up")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1025")]
	public CqlValueSet Preventive_Care_Services_Established_Office_Visit__18_and_Up() => 
		__Preventive_Care_Services_Established_Office_Visit__18_and_Up.Value;

	private CqlValueSet Preventive_Care_Services_Initial_Office_Visit__18_and_Up_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1023", null);

    [CqlDeclaration("Preventive Care Services Initial Office Visit, 18 and Up")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1023")]
	public CqlValueSet Preventive_Care_Services_Initial_Office_Visit__18_and_Up() => 
		__Preventive_Care_Services_Initial_Office_Visit__18_and_Up.Value;

	private CqlValueSet Psoriatic_Arthritis_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.113.12.1046", null);

    [CqlDeclaration("Psoriatic Arthritis")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.113.12.1046")]
	public CqlValueSet Psoriatic_Arthritis() => 
		__Psoriatic_Arthritis.Value;

	private CqlValueSet Rheumatoid_Arthritis_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.113.12.1005", null);

    [CqlDeclaration("Rheumatoid Arthritis")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.113.12.1005")]
	public CqlValueSet Rheumatoid_Arthritis() => 
		__Rheumatoid_Arthritis.Value;

	private CqlValueSet Telephone_Visits_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1080", null);

    [CqlDeclaration("Telephone Visits")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1080")]
	public CqlValueSet Telephone_Visits() => 
		__Telephone_Visits.Value;

	private CqlValueSet Type_1_Diabetes_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.103.12.1020", null);

    [CqlDeclaration("Type 1 Diabetes")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.103.12.1020")]
	public CqlValueSet Type_1_Diabetes() => 
		__Type_1_Diabetes.Value;

	private CqlValueSet Unilateral_Oophorectomy_Left_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.1028", null);

    [CqlDeclaration("Unilateral Oophorectomy Left")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.1028")]
	public CqlValueSet Unilateral_Oophorectomy_Left() => 
		__Unilateral_Oophorectomy_Left.Value;

	private CqlValueSet Unilateral_Oophorectomy_Right_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.1032", null);

    [CqlDeclaration("Unilateral Oophorectomy Right")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.1032")]
	public CqlValueSet Unilateral_Oophorectomy_Right() => 
		__Unilateral_Oophorectomy_Right.Value;

	private CqlValueSet Unilateral_Oophorectomy__Unspecified_Laterality_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.1035", null);

    [CqlDeclaration("Unilateral Oophorectomy, Unspecified Laterality")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.1035")]
	public CqlValueSet Unilateral_Oophorectomy__Unspecified_Laterality() => 
		__Unilateral_Oophorectomy__Unspecified_Laterality.Value;

	private CqlCode Alcoholic_drinks_per_drinking_day___Reported_Value() => 
		new CqlCode("11287-0", "http://loinc.org", null, null);

    [CqlDeclaration("Alcoholic drinks per drinking day - Reported")]
	public CqlCode Alcoholic_drinks_per_drinking_day___Reported() => 
		__Alcoholic_drinks_per_drinking_day___Reported.Value;

	private CqlCode Body_mass_index__BMI___Ratio__Value() => 
		new CqlCode("39156-5", "http://loinc.org", null, null);

    [CqlDeclaration("Body mass index (BMI) [Ratio]")]
	public CqlCode Body_mass_index__BMI___Ratio_() => 
		__Body_mass_index__BMI___Ratio_.Value;

	private CqlCode Female_Value() => 
		new CqlCode("F", "http://terminology.hl7.org/CodeSystem/v3-AdministrativeGender", null, null);

    [CqlDeclaration("Female")]
	public CqlCode Female() => 
		__Female.Value;

	private CqlCode Left__qualifier_value__Value() => 
		new CqlCode("7771000", "http://snomed.info/sct", null, null);

    [CqlDeclaration("Left (qualifier value)")]
	public CqlCode Left__qualifier_value_() => 
		__Left__qualifier_value_.Value;

	private CqlCode Major_osteoporotic_fracture_10_year_probability__Likelihood__Fracture_Risk_Assessment_Value() => 
		new CqlCode("90265-0", "http://loinc.org", null, null);

    [CqlDeclaration("Major osteoporotic fracture 10-year probability [Likelihood] Fracture Risk Assessment")]
	public CqlCode Major_osteoporotic_fracture_10_year_probability__Likelihood__Fracture_Risk_Assessment() => 
		__Major_osteoporotic_fracture_10_year_probability__Likelihood__Fracture_Risk_Assessment.Value;

	private CqlCode Osteoporosis_Index_of_Risk_panel_Value() => 
		new CqlCode("98133-2", "http://loinc.org", null, null);

    [CqlDeclaration("Osteoporosis Index of Risk panel")]
	public CqlCode Osteoporosis_Index_of_Risk_panel() => 
		__Osteoporosis_Index_of_Risk_panel.Value;

	private CqlCode Osteoporosis_Risk_Assessment_Instrument_Value() => 
		new CqlCode("98139-9", "http://loinc.org", null, null);

    [CqlDeclaration("Osteoporosis Risk Assessment Instrument")]
	public CqlCode Osteoporosis_Risk_Assessment_Instrument() => 
		__Osteoporosis_Risk_Assessment_Instrument.Value;

	private CqlCode Osteoporosis_Self_Assessment_Tool_Value() => 
		new CqlCode("98146-4", "http://loinc.org", null, null);

    [CqlDeclaration("Osteoporosis Self-Assessment Tool")]
	public CqlCode Osteoporosis_Self_Assessment_Tool() => 
		__Osteoporosis_Self_Assessment_Tool.Value;

	private CqlCode Right__qualifier_value__Value() => 
		new CqlCode("24028007", "http://snomed.info/sct", null, null);

    [CqlDeclaration("Right (qualifier value)")]
	public CqlCode Right__qualifier_value_() => 
		__Right__qualifier_value_.Value;

	private CqlCode Unlisted_preventive_medicine_service_Value() => 
		new CqlCode("99429", "http://www.ama-assn.org/go/cpt", null, null);

    [CqlDeclaration("Unlisted preventive medicine service")]
	public CqlCode Unlisted_preventive_medicine_service() => 
		__Unlisted_preventive_medicine_service.Value;

	private CqlCode[] LOINC_Value()
	{
		CqlCode[] a_ = new CqlCode[]
		{
			new CqlCode("11287-0", "http://loinc.org", null, null),
			new CqlCode("39156-5", "http://loinc.org", null, null),
			new CqlCode("90265-0", "http://loinc.org", null, null),
			new CqlCode("98133-2", "http://loinc.org", null, null),
			new CqlCode("98139-9", "http://loinc.org", null, null),
			new CqlCode("98146-4", "http://loinc.org", null, null),
		};

		return a_;
	}

    [CqlDeclaration("LOINC")]
	public CqlCode[] LOINC() => 
		__LOINC.Value;

	private CqlCode[] AdministrativeGender_Value()
	{
		CqlCode[] a_ = new CqlCode[]
		{
			new CqlCode("F", "http://terminology.hl7.org/CodeSystem/v3-AdministrativeGender", null, null),
		};

		return a_;
	}

    [CqlDeclaration("AdministrativeGender")]
	public CqlCode[] AdministrativeGender() => 
		__AdministrativeGender.Value;

	private CqlCode[] SNOMEDCT_Value()
	{
		CqlCode[] a_ = new CqlCode[]
		{
			new CqlCode("7771000", "http://snomed.info/sct", null, null),
			new CqlCode("24028007", "http://snomed.info/sct", null, null),
		};

		return a_;
	}

    [CqlDeclaration("SNOMEDCT")]
	public CqlCode[] SNOMEDCT() => 
		__SNOMEDCT.Value;

	private CqlCode[] CPT_Value()
	{
		CqlCode[] a_ = new CqlCode[]
		{
			new CqlCode("99429", "http://www.ama-assn.org/go/cpt", null, null),
		};

		return a_;
	}

    [CqlDeclaration("CPT")]
	public CqlCode[] CPT() => 
		__CPT.Value;

	private CqlInterval<CqlDateTime> Measurement_Period_Value()
	{
		CqlDateTime a_ = context.Operators.DateTime(2025, 1, 1, 0, 0, 0, 0, default);
		CqlDateTime b_ = context.Operators.DateTime(2026, 1, 1, 0, 0, 0, 0, default);
		CqlInterval<CqlDateTime> c_ = context.Operators.Interval(a_, b_, true, false);
		object d_ = context.ResolveParameter("AppropriateDXAScansForWomenUnder65FHIR-0.0.000", "Measurement Period", c_);

		return (CqlInterval<CqlDateTime>)d_;
	}

    [CqlDeclaration("Measurement Period")]
	public CqlInterval<CqlDateTime> Measurement_Period() => 
		__Measurement_Period.Value;

	private Patient Patient_Value()
	{
		IEnumerable<Patient> a_ = context.Operators.RetrieveByValueSet<Patient>(null, null);
		Patient b_ = context.Operators.SingletonFrom<Patient>(a_);

		return b_;
	}

    [CqlDeclaration("Patient")]
	public Patient Patient() => 
		__Patient.Value;

	private Tuple_DMgHTLENEHBHWJISQgKZGZVMB SDE_Ethnicity_Value()
	{
		Tuple_DMgHTLENEHBHWJISQgKZGZVMB a_ = SupplementalDataElements_3_4_000.SDE_Ethnicity();

		return a_;
	}

    [CqlDeclaration("SDE Ethnicity")]
	public Tuple_DMgHTLENEHBHWJISQgKZGZVMB SDE_Ethnicity() => 
		__SDE_Ethnicity.Value;

	private IEnumerable<Tuple_GDKRbfOIHhLGieQSVDEMIaDPX> SDE_Payer_Value()
	{
		IEnumerable<Tuple_GDKRbfOIHhLGieQSVDEMIaDPX> a_ = SupplementalDataElements_3_4_000.SDE_Payer();

		return a_;
	}

    [CqlDeclaration("SDE Payer")]
	public IEnumerable<Tuple_GDKRbfOIHhLGieQSVDEMIaDPX> SDE_Payer() => 
		__SDE_Payer.Value;

	private Tuple_DMgHTLENEHBHWJISQgKZGZVMB SDE_Race_Value()
	{
		Tuple_DMgHTLENEHBHWJISQgKZGZVMB a_ = SupplementalDataElements_3_4_000.SDE_Race();

		return a_;
	}

    [CqlDeclaration("SDE Race")]
	public Tuple_DMgHTLENEHBHWJISQgKZGZVMB SDE_Race() => 
		__SDE_Race.Value;

	private CqlCode SDE_Sex_Value()
	{
		CqlCode a_ = SupplementalDataElements_3_4_000.SDE_Sex();

		return a_;
	}

    [CqlDeclaration("SDE Sex")]
	public CqlCode SDE_Sex() => 
		__SDE_Sex.Value;

	private IEnumerable<Encounter> Qualifying_Encounter_Value()
	{
		CqlValueSet a_ = this.Office_Visit();
		IEnumerable<Encounter> b_ = context.Operators.RetrieveByValueSet<Encounter>(a_, null);
		CqlValueSet c_ = this.Preventive_Care_Services_Established_Office_Visit__18_and_Up();
		IEnumerable<Encounter> d_ = context.Operators.RetrieveByValueSet<Encounter>(c_, null);
		IEnumerable<Encounter> e_ = context.Operators.ListUnion<Encounter>(b_, d_);
		IEnumerable<Encounter> f_ = context.Operators.RetrieveByValueSet<Encounter>(null, null);
		bool? g_(Encounter E)
		{
			CqlConcept x_(CodeableConcept @this)
			{
				CqlConcept ac_ = FHIRHelpers_4_3_000.ToConcept(@this);

				return ac_;
			};
			IEnumerable<CqlConcept> y_ = context.Operators.Select<CodeableConcept, CqlConcept>(E?.Type, x_);
			bool? z_(CqlConcept T)
			{
				CqlCode ad_ = this.Unlisted_preventive_medicine_service();
				CqlConcept ae_ = context.Operators.ConvertCodeToConcept(ad_);
				bool? af_ = context.Operators.Equivalent(T, ae_);

				return af_;
			};
			IEnumerable<CqlConcept> aa_ = context.Operators.Where<CqlConcept>(y_, z_);
			bool? ab_ = context.Operators.Exists<CqlConcept>(aa_);

			return ab_;
		};
		IEnumerable<Encounter> h_ = context.Operators.Where<Encounter>(f_, g_);
		CqlValueSet i_ = this.Preventive_Care_Services_Initial_Office_Visit__18_and_Up();
		IEnumerable<Encounter> j_ = context.Operators.RetrieveByValueSet<Encounter>(i_, null);
		IEnumerable<Encounter> k_ = context.Operators.ListUnion<Encounter>(h_, j_);
		IEnumerable<Encounter> l_ = context.Operators.ListUnion<Encounter>(e_, k_);
		CqlValueSet m_ = this.Outpatient_Consultation();
		IEnumerable<Encounter> n_ = context.Operators.RetrieveByValueSet<Encounter>(m_, null);
		CqlValueSet o_ = this.Online_Assessments();
		IEnumerable<Encounter> p_ = context.Operators.RetrieveByValueSet<Encounter>(o_, null);
		IEnumerable<Encounter> q_ = context.Operators.ListUnion<Encounter>(n_, p_);
		IEnumerable<Encounter> r_ = context.Operators.ListUnion<Encounter>(l_, q_);
		CqlValueSet s_ = this.Telephone_Visits();
		IEnumerable<Encounter> t_ = context.Operators.RetrieveByValueSet<Encounter>(s_, null);
		IEnumerable<Encounter> u_ = context.Operators.ListUnion<Encounter>(r_, t_);
		bool? v_(Encounter ValidEncounters)
		{
			CqlInterval<CqlDateTime> ag_ = this.Measurement_Period();
			CqlInterval<CqlDateTime> ah_ = FHIRHelpers_4_3_000.ToInterval(ValidEncounters?.Period);
			CqlInterval<CqlDateTime> ai_ = QICoreCommon_2_0_000.ToInterval((ah_ as object));
			bool? aj_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(ag_, ai_, "day");

			return aj_;
		};
		IEnumerable<Encounter> w_ = context.Operators.Where<Encounter>(u_, v_);

		return w_;
	}

    [CqlDeclaration("Qualifying Encounter")]
	public IEnumerable<Encounter> Qualifying_Encounter() => 
		__Qualifying_Encounter.Value;

	private bool? Initial_Population_Value()
	{
		Patient a_ = this.Patient();
		CqlDate b_ = context.Operators.Convert<CqlDate>(a_?.BirthDateElement?.Value);
		CqlInterval<CqlDateTime> c_ = this.Measurement_Period();
		CqlDateTime d_ = context.Operators.Start(c_);
		CqlDate e_ = context.Operators.DateFrom(d_);
		int? f_ = context.Operators.CalculateAgeAt(b_, e_, "year");
		CqlInterval<int?> g_ = context.Operators.Interval(50, 63, true, true);
		bool? h_ = context.Operators.In<int?>(f_, g_, null);
		string j_ = context.Operators.Convert<string>(a_?.GenderElement?.Value);
		bool? k_ = context.Operators.Equal(j_, "female");
		bool? l_ = context.Operators.And(h_, k_);
		IEnumerable<Encounter> m_ = this.Qualifying_Encounter();
		bool? n_ = context.Operators.Exists<Encounter>(m_);
		bool? o_ = context.Operators.And(l_, n_);

		return o_;
	}

    [CqlDeclaration("Initial Population")]
	public bool? Initial_Population() => 
		__Initial_Population.Value;

	private bool? Denominator_Value()
	{
		bool? a_ = this.Initial_Population();

		return a_;
	}

    [CqlDeclaration("Denominator")]
	public bool? Denominator() => 
		__Denominator.Value;

	private Observation First_BMI_in_Measurement_Period_Value()
	{
		IEnumerable<Observation> a_ = context.Operators.RetrieveByValueSet<Observation>(null, null);
		IEnumerable<Observation> b_ = Status_1_6_000.BMI(a_);
		bool? c_(Observation BMIRatio)
		{
			CqlInterval<CqlDateTime> h_ = this.Measurement_Period();
			object i_ = FHIRHelpers_4_3_000.ToValue(BMIRatio?.Effective);
			CqlInterval<CqlDateTime> j_ = QICoreCommon_2_0_000.ToInterval(i_);
			bool? k_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(h_, j_, null);
			Quantity l_ = context.Operators.Convert<Quantity>(BMIRatio?.Value);
			CqlQuantity m_ = FHIRHelpers_4_3_000.ToQuantity(l_);
			bool? n_ = context.Operators.Not((bool?)(m_ is null));
			bool? o_ = context.Operators.And(k_, n_);

			return o_;
		};
		IEnumerable<Observation> d_ = context.Operators.Where<Observation>(b_, c_);
		object e_(Observation @this)
		{
			object p_ = FHIRHelpers_4_3_000.ToValue(@this?.Effective);
			CqlInterval<CqlDateTime> q_ = QICoreCommon_2_0_000.ToInterval(p_);
			CqlDateTime r_ = context.Operators.Start(q_);

			return r_;
		};
		IEnumerable<Observation> f_ = context.Operators.SortBy<Observation>(d_, e_, System.ComponentModel.ListSortDirection.Ascending);
		Observation g_ = context.Operators.First<Observation>(f_);

		return g_;
	}

    [CqlDeclaration("First BMI in Measurement Period")]
	public Observation First_BMI_in_Measurement_Period() => 
		__First_BMI_in_Measurement_Period.Value;

	private Observation First_BMI_in_Measurement_Period_Less_Than_or_Equal_to_20_kg_m2_Value()
	{
		Observation a_ = this.First_BMI_in_Measurement_Period();
		Observation[] b_ = new Observation[]
		{
			a_,
		};
		bool? c_(Observation FirstBMI)
		{
			Quantity f_ = context.Operators.Convert<Quantity>(FirstBMI?.Value);
			CqlQuantity g_ = FHIRHelpers_4_3_000.ToQuantity(f_);
			CqlQuantity h_ = context.Operators.Quantity(20m, "kg/m2");
			bool? i_ = context.Operators.LessOrEqual(g_, h_);

			return i_;
		};
		IEnumerable<Observation> d_ = context.Operators.Where<Observation>(b_, c_);
		Observation e_ = context.Operators.SingletonFrom<Observation>(d_);

		return e_;
	}

    [CqlDeclaration("First BMI in Measurement Period Less Than or Equal to 20 kg m2")]
	public Observation First_BMI_in_Measurement_Period_Less_Than_or_Equal_to_20_kg_m2() => 
		__First_BMI_in_Measurement_Period_Less_Than_or_Equal_to_20_kg_m2.Value;

	private Observation First_Average_Number_of_Drinks_Assessments_Indicating_More_Than_Two_Per_Day_Value()
	{
		CqlCode a_ = this.Alcoholic_drinks_per_drinking_day___Reported();
		IEnumerable<CqlCode> b_ = context.Operators.ToList<CqlCode>(a_);
		IEnumerable<Observation> c_ = context.Operators.RetrieveByCodes<Observation>(b_, null);
		IEnumerable<Observation> d_ = Status_1_6_000.Final_Survey_Observation(c_);
		bool? e_(Observation AverageDrinks)
		{
			object j_ = FHIRHelpers_4_3_000.ToValue(AverageDrinks?.Effective);
			CqlInterval<CqlDateTime> k_ = QICoreCommon_2_0_000.ToInterval(j_);
			CqlDateTime l_ = context.Operators.Start(k_);
			CqlInterval<CqlDateTime> m_ = this.Measurement_Period();
			bool? n_ = context.Operators.In<CqlDateTime>(l_, m_, null);
			object o_ = FHIRHelpers_4_3_000.ToValue(AverageDrinks?.Value);
			CqlQuantity p_ = context.Operators.Quantity(2m, "{drinks}/d");
			bool? q_ = context.Operators.Greater((o_ as CqlQuantity), p_);
			bool? r_ = context.Operators.And(n_, q_);

			return r_;
		};
		IEnumerable<Observation> f_ = context.Operators.Where<Observation>(d_, e_);
		object g_(Observation @this)
		{
			object s_ = FHIRHelpers_4_3_000.ToValue(@this?.Effective);
			CqlInterval<CqlDateTime> t_ = QICoreCommon_2_0_000.ToInterval(s_);
			CqlDateTime u_ = context.Operators.Start(t_);

			return u_;
		};
		IEnumerable<Observation> h_ = context.Operators.SortBy<Observation>(f_, g_, System.ComponentModel.ListSortDirection.Ascending);
		Observation i_ = context.Operators.First<Observation>(h_);

		return i_;
	}

    [CqlDeclaration("First Average Number of Drinks Assessments Indicating More Than Two Per Day")]
	public Observation First_Average_Number_of_Drinks_Assessments_Indicating_More_Than_Two_Per_Day() => 
		__First_Average_Number_of_Drinks_Assessments_Indicating_More_Than_Two_Per_Day.Value;

	private bool? Has_Risk_Factor_Active_During_the_Measurement_Period_Value()
	{
		Observation a_ = this.First_BMI_in_Measurement_Period_Less_Than_or_Equal_to_20_kg_m2();
		bool? b_ = context.Operators.Not((bool?)(a_ is null));
		Observation c_ = this.First_Average_Number_of_Drinks_Assessments_Indicating_More_Than_Two_Per_Day();
		bool? d_ = context.Operators.Not((bool?)(c_ is null));
		bool? e_ = context.Operators.Or(b_, d_);

		return e_;
	}

    [CqlDeclaration("Has Risk Factor Active During the Measurement Period")]
	public bool? Has_Risk_Factor_Active_During_the_Measurement_Period() => 
		__Has_Risk_Factor_Active_During_the_Measurement_Period.Value;

	private bool? Has_Osteoporosis_Before_Measurement_Period_Value()
	{
		CqlValueSet a_ = this.Osteoporosis();
		IEnumerable<Condition> b_ = context.Operators.RetrieveByValueSet<Condition>(a_, null);
		bool? c_(Condition OsteoporosisDiagnosis)
		{
			CqlInterval<CqlDateTime> f_ = QICoreCommon_2_0_000.ToPrevalenceInterval(OsteoporosisDiagnosis);
			CqlDateTime g_ = context.Operators.Start(f_);
			CqlInterval<CqlDateTime> h_ = this.Measurement_Period();
			CqlDateTime i_ = context.Operators.Start(h_);
			bool? j_ = context.Operators.Before(g_, i_, null);

			return j_;
		};
		IEnumerable<Condition> d_ = context.Operators.Where<Condition>(b_, c_);
		bool? e_ = context.Operators.Exists<Condition>(d_);

		return e_;
	}

    [CqlDeclaration("Has Osteoporosis Before Measurement Period")]
	public bool? Has_Osteoporosis_Before_Measurement_Period() => 
		__Has_Osteoporosis_Before_Measurement_Period.Value;

	private bool? Has_Osteopenia_Before_Measurement_Period_Value()
	{
		CqlValueSet a_ = this.Osteopenia();
		IEnumerable<Condition> b_ = context.Operators.RetrieveByValueSet<Condition>(a_, null);
		bool? c_(Condition OsteopeniaDiagnosis)
		{
			CqlInterval<CqlDateTime> f_ = QICoreCommon_2_0_000.ToPrevalenceInterval(OsteopeniaDiagnosis);
			CqlDateTime g_ = context.Operators.Start(f_);
			CqlInterval<CqlDateTime> h_ = this.Measurement_Period();
			CqlDateTime i_ = context.Operators.Start(h_);
			bool? j_ = context.Operators.Before(g_, i_, null);

			return j_;
		};
		IEnumerable<Condition> d_ = context.Operators.Where<Condition>(b_, c_);
		bool? e_ = context.Operators.Exists<Condition>(d_);

		return e_;
	}

    [CqlDeclaration("Has Osteopenia Before Measurement Period")]
	public bool? Has_Osteopenia_Before_Measurement_Period() => 
		__Has_Osteopenia_Before_Measurement_Period.Value;

	private bool? Has_Risk_Factor_Any_Time_in_History_Prior_to_Measurement_Period_Value()
	{
		bool? a_ = this.Has_Osteoporosis_Before_Measurement_Period();
		bool? b_ = this.Has_Osteopenia_Before_Measurement_Period();
		bool? c_ = context.Operators.Or(a_, b_);

		return c_;
	}

    [CqlDeclaration("Has Risk Factor Any Time in History Prior to Measurement Period")]
	public bool? Has_Risk_Factor_Any_Time_in_History_Prior_to_Measurement_Period() => 
		__Has_Risk_Factor_Any_Time_in_History_Prior_to_Measurement_Period.Value;

	private IEnumerable<Observation> Parent_History_of_Hip_Fracture_Assessment_Value()
	{
		CqlValueSet a_ = this.History_of_hip_fracture_in_parent();
		IEnumerable<Observation> b_ = context.Operators.RetrieveByValueSet<Observation>(a_, null);
		IEnumerable<Observation> c_ = Status_1_6_000.Final_Survey_Observation(b_);
		bool? d_(Observation ParentFractureHistory)
		{
			object f_ = FHIRHelpers_4_3_000.ToValue(ParentFractureHistory?.Effective);
			CqlInterval<CqlDateTime> g_ = QICoreCommon_2_0_000.ToInterval(f_);
			CqlDateTime h_ = context.Operators.Start(g_);
			CqlInterval<CqlDateTime> i_ = this.Measurement_Period();
			CqlDateTime j_ = context.Operators.Start(i_);
			bool? k_ = context.Operators.Before(h_, j_, null);

			return k_;
		};
		IEnumerable<Observation> e_ = context.Operators.Where<Observation>(c_, d_);

		return e_;
	}

    [CqlDeclaration("Parent History of Hip Fracture Assessment")]
	public IEnumerable<Observation> Parent_History_of_Hip_Fracture_Assessment() => 
		__Parent_History_of_Hip_Fracture_Assessment.Value;

	private bool? Has_Risk_Factor_Any_Time_in_History_Prior_to_Measurement_Period_and_Do_Not_Need_to_be_Active_During_Measurement_Period_Value()
	{
		CqlValueSet a_ = this.Gastric_Bypass_Surgery();
		IEnumerable<Procedure> b_ = context.Operators.RetrieveByValueSet<Procedure>(a_, null);
		IEnumerable<Procedure> c_ = Status_1_6_000.Completed_Procedure(b_);
		bool? d_(Procedure GastricBypass)
		{
			object aa_ = FHIRHelpers_4_3_000.ToValue(GastricBypass?.Performed);
			CqlInterval<CqlDateTime> ab_ = QICoreCommon_2_0_000.ToInterval(aa_);
			CqlDateTime ac_ = context.Operators.End(ab_);
			CqlInterval<CqlDateTime> ad_ = this.Measurement_Period();
			CqlDateTime ae_ = context.Operators.Start(ad_);
			bool? af_ = context.Operators.Before(ac_, ae_, null);

			return af_;
		};
		IEnumerable<Procedure> e_ = context.Operators.Where<Procedure>(c_, d_);
		CqlValueSet f_ = this.Aromatase_Inhibitors();
		IEnumerable<MedicationRequest> g_ = context.Operators.RetrieveByValueSet<MedicationRequest>(f_, null);
		IEnumerable<MedicationRequest> i_ = context.Operators.RetrieveByValueSet<MedicationRequest>(f_, null);
		IEnumerable<MedicationRequest> j_ = context.Operators.ListUnion<MedicationRequest>(g_, i_);
		IEnumerable<MedicationRequest> k_ = Status_1_6_000.Active_Medication(j_);
		bool? l_(MedicationRequest AromataseInhibitorActive)
		{
			CqlInterval<CqlDate> ag_ = CumulativeMedicationDuration_4_0_000.MedicationRequestPeriod(AromataseInhibitorActive);
			CqlDate ah_ = context.Operators.Start(ag_);
			CqlDateTime ai_ = context.Operators.ConvertDateToDateTime(ah_);
			CqlInterval<CqlDateTime> aj_ = this.Measurement_Period();
			CqlDateTime ak_ = context.Operators.Start(aj_);
			bool? al_ = context.Operators.Before(ai_, ak_, null);

			return al_;
		};
		IEnumerable<MedicationRequest> m_ = context.Operators.Where<MedicationRequest>(k_, l_);
		IEnumerable<object> n_ = context.Operators.ListUnion<object>((e_ as IEnumerable<object>), (m_ as IEnumerable<object>));
		IEnumerable<MedicationRequest> p_ = context.Operators.RetrieveByValueSet<MedicationRequest>(f_, null);
		IEnumerable<MedicationRequest> r_ = context.Operators.RetrieveByValueSet<MedicationRequest>(f_, null);
		IEnumerable<MedicationRequest> s_ = context.Operators.ListUnion<MedicationRequest>(p_, r_);
		IEnumerable<MedicationRequest> t_ = Status_1_6_000.Active_or_Completed_Medication_Request(s_);
		bool? u_(MedicationRequest AromataseInhibitorOrder)
		{
			CqlDateTime am_ = context.Operators.Convert<CqlDateTime>(AromataseInhibitorOrder?.AuthoredOnElement);
			CqlInterval<CqlDateTime> an_ = QICoreCommon_2_0_000.ToInterval((am_ as object));
			CqlInterval<CqlDateTime> ao_()
			{
				bool aq_()
				{
					CqlInterval<CqlDateTime> ar_ = this.Measurement_Period();
					CqlDateTime as_ = context.Operators.Start(ar_);

					return (as_ is null);
				};
				if (aq_())
				{
					return null;
				}
				else
				{
					CqlInterval<CqlDateTime> at_ = this.Measurement_Period();
					CqlDateTime au_ = context.Operators.Start(at_);
					CqlDateTime aw_ = context.Operators.Start(at_);
					CqlInterval<CqlDateTime> ax_ = context.Operators.Interval(au_, aw_, true, true);

					return ax_;
				};
			};
			bool? ap_ = context.Operators.Before(an_, ao_(), null);

			return ap_;
		};
		IEnumerable<MedicationRequest> v_ = context.Operators.Where<MedicationRequest>(t_, u_);
		IEnumerable<object> w_ = context.Operators.ListUnion<object>(n_, (v_ as IEnumerable<object>));
		IEnumerable<Observation> x_ = this.Parent_History_of_Hip_Fracture_Assessment();
		IEnumerable<object> y_ = context.Operators.ListUnion<object>(w_, (x_ as IEnumerable<object>));
		bool? z_ = context.Operators.Exists<object>(y_);

		return z_;
	}

    [CqlDeclaration("Has Risk Factor Any Time in History Prior to Measurement Period and Do Not Need to be Active During Measurement Period")]
	public bool? Has_Risk_Factor_Any_Time_in_History_Prior_to_Measurement_Period_and_Do_Not_Need_to_be_Active_During_Measurement_Period() => 
		__Has_Risk_Factor_Any_Time_in_History_Prior_to_Measurement_Period_and_Do_Not_Need_to_be_Active_During_Measurement_Period.Value;

	private int? Glucocorticoid_Active_Medication_Duration_in_Days_Value()
	{
		CqlValueSet a_ = this.Glucocorticoids__oral_only_();
		IEnumerable<MedicationRequest> b_ = context.Operators.RetrieveByValueSet<MedicationRequest>(a_, null);
		IEnumerable<MedicationRequest> d_ = context.Operators.RetrieveByValueSet<MedicationRequest>(a_, null);
		IEnumerable<MedicationRequest> e_ = context.Operators.ListUnion<MedicationRequest>(b_, d_);
		IEnumerable<MedicationRequest> f_ = Status_1_6_000.Active_Medication(e_);
		bool? g_(MedicationRequest OralGlucocorticoid)
		{
			CqlInterval<CqlDate> l_ = CumulativeMedicationDuration_4_0_000.MedicationRequestPeriod(OralGlucocorticoid);
			CqlDate m_ = context.Operators.Start(l_);
			CqlDateTime n_ = context.Operators.ConvertDateToDateTime(m_);
			CqlInterval<CqlDateTime> o_ = this.Measurement_Period();
			CqlDateTime p_ = context.Operators.End(o_);
			bool? q_ = context.Operators.Before(n_, p_, null);

			return q_;
		};
		IEnumerable<MedicationRequest> h_ = context.Operators.Where<MedicationRequest>(f_, g_);
		CqlInterval<CqlDate> i_(MedicationRequest Glucocorticoid)
		{
			CqlInterval<CqlDate> r_ = CumulativeMedicationDuration_4_0_000.MedicationRequestPeriod(Glucocorticoid);
			Patient s_ = this.Patient();
			CqlDate t_ = context.Operators.ConvertStringToDate(s_?.BirthDateElement?.Value);
			CqlInterval<CqlDateTime> u_ = this.Measurement_Period();
			CqlDateTime v_ = context.Operators.End(u_);
			CqlDate w_ = context.Operators.DateFrom(v_);
			CqlInterval<CqlDate> x_ = context.Operators.Interval(t_, w_, true, true);
			CqlInterval<CqlDate> y_ = context.Operators.IntervalIntersect<CqlDate>(r_, x_);

			return y_;
		};
		IEnumerable<CqlInterval<CqlDate>> j_ = context.Operators.Select<MedicationRequest, CqlInterval<CqlDate>>(h_, i_);
		int? k_ = CumulativeMedicationDuration_4_0_000.CumulativeDuration(j_);

		return k_;
	}

    [CqlDeclaration("Glucocorticoid Active Medication Duration in Days")]
	public int? Glucocorticoid_Active_Medication_Duration_in_Days() => 
		__Glucocorticoid_Active_Medication_Duration_in_Days.Value;

	private int? Glucocorticoid_Active_Medication_Days_Value()
	{
		int? a_ = this.Glucocorticoid_Active_Medication_Duration_in_Days();

		return a_;
	}

    [CqlDeclaration("Glucocorticoid Active Medication Days")]
	public int? Glucocorticoid_Active_Medication_Days() => 
		__Glucocorticoid_Active_Medication_Days.Value;

	private bool? Has_90_or_More_Active_Glucocorticoid_Medication_Days_Value()
	{
		int? a_ = this.Glucocorticoid_Active_Medication_Days();
		bool? b_ = context.Operators.GreaterOrEqual(a_, 90);

		return b_;
	}

    [CqlDeclaration("Has 90 or More Active Glucocorticoid Medication Days")]
	public bool? Has_90_or_More_Active_Glucocorticoid_Medication_Days() => 
		__Has_90_or_More_Active_Glucocorticoid_Medication_Days.Value;

    [CqlDeclaration("DiagnosisInPatientHistory")]
	public IEnumerable<Condition> DiagnosisInPatientHistory(IEnumerable<Condition> Condition)
	{
		bool? a_(Condition Dx)
		{
			CqlInterval<CqlDateTime> c_ = QICoreCommon_2_0_000.ToPrevalenceInterval(Dx);
			CqlDateTime d_ = context.Operators.Start(c_);
			CqlInterval<CqlDateTime> e_ = this.Measurement_Period();
			CqlDateTime f_ = context.Operators.End(e_);
			bool? g_ = context.Operators.SameOrBefore(d_, f_, "day");

			return g_;
		};
		IEnumerable<Condition> b_ = context.Operators.Where<Condition>(Condition, a_);

		return b_;
	}

    [CqlDeclaration("ProcedureInPatientHistory")]
	public IEnumerable<Procedure> ProcedureInPatientHistory(IEnumerable<Procedure> Procedure)
	{
		IEnumerable<Procedure> a_ = Status_1_6_000.Completed_Procedure(Procedure);
		bool? b_(Procedure Proc)
		{
			object d_ = FHIRHelpers_4_3_000.ToValue(Proc?.Performed);
			CqlInterval<CqlDateTime> e_ = QICoreCommon_2_0_000.ToInterval(d_);
			CqlDateTime f_ = context.Operators.End(e_);
			CqlInterval<CqlDateTime> g_ = this.Measurement_Period();
			CqlDateTime h_ = context.Operators.End(g_);
			bool? i_ = context.Operators.SameOrBefore(f_, h_, "day");

			return i_;
		};
		IEnumerable<Procedure> c_ = context.Operators.Where<Procedure>(a_, b_);

		return c_;
	}

	private bool? Has_Double_or_Bilateral_Oophorectomy_Value()
	{
		CqlValueSet a_ = this.Bilateral_Oophorectomy();
		IEnumerable<Procedure> b_ = context.Operators.RetrieveByValueSet<Procedure>(a_, null);
		IEnumerable<Procedure> c_ = this.ProcedureInPatientHistory(b_);
		bool? d_ = context.Operators.Exists<Procedure>(c_);
		CqlValueSet e_ = this.Evidence_of_Bilateral_Oophorectomy();
		IEnumerable<Procedure> f_ = context.Operators.RetrieveByValueSet<Procedure>(e_, null);
		IEnumerable<Procedure> g_ = this.ProcedureInPatientHistory(f_);
		bool? h_ = context.Operators.Exists<Procedure>(g_);
		bool? i_ = context.Operators.Or(d_, h_);
		CqlValueSet j_ = this.Unilateral_Oophorectomy__Unspecified_Laterality();
		IEnumerable<Procedure> k_ = context.Operators.RetrieveByValueSet<Procedure>(j_, null);
		bool? l_(Procedure UnilateralOophorectomy)
		{
			CqlConcept ad_(CodeableConcept @this)
			{
				CqlConcept ai_ = FHIRHelpers_4_3_000.ToConcept(@this);

				return ai_;
			};
			IEnumerable<CqlConcept> ae_ = context.Operators.Select<CodeableConcept, CqlConcept>(UnilateralOophorectomy?.BodySite, ad_);
			bool? af_(CqlConcept C)
			{
				CqlCode aj_ = this.Right__qualifier_value_();
				CqlConcept ak_ = context.Operators.ConvertCodeToConcept(aj_);
				bool? al_ = context.Operators.Equivalent(C, ak_);

				return al_;
			};
			IEnumerable<CqlConcept> ag_ = context.Operators.Where<CqlConcept>(ae_, af_);
			bool? ah_ = context.Operators.Exists<CqlConcept>(ag_);

			return ah_;
		};
		IEnumerable<Procedure> m_ = context.Operators.Where<Procedure>(k_, l_);
		CqlValueSet n_ = this.Unilateral_Oophorectomy_Right();
		IEnumerable<Procedure> o_ = context.Operators.RetrieveByValueSet<Procedure>(n_, null);
		IEnumerable<Procedure> p_ = context.Operators.ListUnion<Procedure>(m_, o_);
		IEnumerable<Procedure> q_ = this.ProcedureInPatientHistory(p_);
		bool? r_ = context.Operators.Exists<Procedure>(q_);
		IEnumerable<Procedure> t_ = context.Operators.RetrieveByValueSet<Procedure>(j_, null);
		bool? u_(Procedure UnilateralOophorectomy)
		{
			CqlConcept am_(CodeableConcept @this)
			{
				CqlConcept ar_ = FHIRHelpers_4_3_000.ToConcept(@this);

				return ar_;
			};
			IEnumerable<CqlConcept> an_ = context.Operators.Select<CodeableConcept, CqlConcept>(UnilateralOophorectomy?.BodySite, am_);
			bool? ao_(CqlConcept D)
			{
				CqlCode as_ = this.Left__qualifier_value_();
				CqlConcept at_ = context.Operators.ConvertCodeToConcept(as_);
				bool? au_ = context.Operators.Equivalent(D, at_);

				return au_;
			};
			IEnumerable<CqlConcept> ap_ = context.Operators.Where<CqlConcept>(an_, ao_);
			bool? aq_ = context.Operators.Exists<CqlConcept>(ap_);

			return aq_;
		};
		IEnumerable<Procedure> v_ = context.Operators.Where<Procedure>(t_, u_);
		CqlValueSet w_ = this.Unilateral_Oophorectomy_Left();
		IEnumerable<Procedure> x_ = context.Operators.RetrieveByValueSet<Procedure>(w_, null);
		IEnumerable<Procedure> y_ = context.Operators.ListUnion<Procedure>(v_, x_);
		IEnumerable<Procedure> z_ = this.ProcedureInPatientHistory(y_);
		bool? aa_ = context.Operators.Exists<Procedure>(z_);
		bool? ab_ = context.Operators.And(r_, aa_);
		bool? ac_ = context.Operators.Or(i_, ab_);

		return ac_;
	}

    [CqlDeclaration("Has Double or Bilateral Oophorectomy")]
	public bool? Has_Double_or_Bilateral_Oophorectomy() => 
		__Has_Double_or_Bilateral_Oophorectomy.Value;

	private bool? Has_Organ_Transplants_Value()
	{
		CqlValueSet a_ = this.Major_Transplant();
		IEnumerable<Procedure> b_ = context.Operators.RetrieveByValueSet<Procedure>(a_, null);
		CqlValueSet c_ = this.Kidney_Transplant();
		IEnumerable<Procedure> d_ = context.Operators.RetrieveByValueSet<Procedure>(c_, null);
		IEnumerable<Procedure> e_ = context.Operators.ListUnion<Procedure>(b_, d_);
		CqlValueSet f_ = this.Bone_Marrow_Transplant();
		IEnumerable<Procedure> g_ = context.Operators.RetrieveByValueSet<Procedure>(f_, null);
		IEnumerable<Procedure> h_ = context.Operators.ListUnion<Procedure>(e_, g_);
		IEnumerable<Procedure> i_ = this.ProcedureInPatientHistory(h_);
		bool? j_ = context.Operators.Exists<Procedure>(i_);

		return j_;
	}

    [CqlDeclaration("Has Organ Transplants")]
	public bool? Has_Organ_Transplants() => 
		__Has_Organ_Transplants.Value;

	private bool? Has_Risk_Factor_Any_Time_in_History_or_During_Measurement_Period_Value()
	{
		bool? a_ = this.Has_90_or_More_Active_Glucocorticoid_Medication_Days();
		CqlValueSet b_ = this.Osteoporotic_Fractures();
		IEnumerable<Condition> c_ = context.Operators.RetrieveByValueSet<Condition>(b_, null);
		CqlValueSet d_ = this.Malabsorption_Syndromes();
		IEnumerable<Condition> e_ = context.Operators.RetrieveByValueSet<Condition>(d_, null);
		IEnumerable<Condition> f_ = context.Operators.ListUnion<Condition>(c_, e_);
		CqlValueSet g_ = this.Chronic_Malnutrition();
		IEnumerable<Condition> h_ = context.Operators.RetrieveByValueSet<Condition>(g_, null);
		CqlValueSet i_ = this.Chronic_Liver_Disease();
		IEnumerable<Condition> j_ = context.Operators.RetrieveByValueSet<Condition>(i_, null);
		IEnumerable<Condition> k_ = context.Operators.ListUnion<Condition>(h_, j_);
		IEnumerable<Condition> l_ = context.Operators.ListUnion<Condition>(f_, k_);
		CqlValueSet m_ = this.Rheumatoid_Arthritis();
		IEnumerable<Condition> n_ = context.Operators.RetrieveByValueSet<Condition>(m_, null);
		CqlValueSet o_ = this.Hyperthyroidism();
		IEnumerable<Condition> p_ = context.Operators.RetrieveByValueSet<Condition>(o_, null);
		IEnumerable<Condition> q_ = context.Operators.ListUnion<Condition>(n_, p_);
		IEnumerable<Condition> r_ = context.Operators.ListUnion<Condition>(l_, q_);
		CqlValueSet s_ = this.Type_1_Diabetes();
		IEnumerable<Condition> t_ = context.Operators.RetrieveByValueSet<Condition>(s_, null);
		CqlValueSet u_ = this.End_Stage_Renal_Disease();
		IEnumerable<Condition> v_ = context.Operators.RetrieveByValueSet<Condition>(u_, null);
		IEnumerable<Condition> w_ = context.Operators.ListUnion<Condition>(t_, v_);
		IEnumerable<Condition> x_ = context.Operators.ListUnion<Condition>(r_, w_);
		CqlValueSet y_ = this.Osteogenesis_Imperfecta();
		IEnumerable<Condition> z_ = context.Operators.RetrieveByValueSet<Condition>(y_, null);
		CqlValueSet aa_ = this.Ankylosing_Spondylitis();
		IEnumerable<Condition> ab_ = context.Operators.RetrieveByValueSet<Condition>(aa_, null);
		IEnumerable<Condition> ac_ = context.Operators.ListUnion<Condition>(z_, ab_);
		IEnumerable<Condition> ad_ = context.Operators.ListUnion<Condition>(x_, ac_);
		CqlValueSet ae_ = this.Psoriatic_Arthritis();
		IEnumerable<Condition> af_ = context.Operators.RetrieveByValueSet<Condition>(ae_, null);
		CqlValueSet ag_ = this.Ehlers_Danlos_Syndrome();
		IEnumerable<Condition> ah_ = context.Operators.RetrieveByValueSet<Condition>(ag_, null);
		IEnumerable<Condition> ai_ = context.Operators.ListUnion<Condition>(af_, ah_);
		IEnumerable<Condition> aj_ = context.Operators.ListUnion<Condition>(ad_, ai_);
		CqlValueSet ak_ = this.Cushings_Syndrome();
		IEnumerable<Condition> al_ = context.Operators.RetrieveByValueSet<Condition>(ak_, null);
		CqlValueSet am_ = this.Hyperparathyroidism();
		IEnumerable<Condition> an_ = context.Operators.RetrieveByValueSet<Condition>(am_, null);
		IEnumerable<Condition> ao_ = context.Operators.ListUnion<Condition>(al_, an_);
		IEnumerable<Condition> ap_ = context.Operators.ListUnion<Condition>(aj_, ao_);
		CqlValueSet aq_ = this.Marfans_Syndrome();
		IEnumerable<Condition> ar_ = context.Operators.RetrieveByValueSet<Condition>(aq_, null);
		CqlValueSet as_ = this.Lupus();
		IEnumerable<Condition> at_ = context.Operators.RetrieveByValueSet<Condition>(as_, null);
		IEnumerable<Condition> au_ = context.Operators.ListUnion<Condition>(ar_, at_);
		IEnumerable<Condition> av_ = context.Operators.ListUnion<Condition>(ap_, au_);
		CqlValueSet aw_ = this.Multiple_Myeloma();
		IEnumerable<Condition> ax_ = context.Operators.RetrieveByValueSet<Condition>(aw_, null);
		CqlValueSet ay_ = this.Premature_Menopause();
		IEnumerable<Condition> az_ = context.Operators.RetrieveByValueSet<Condition>(ay_, null);
		IEnumerable<Condition> ba_ = context.Operators.ListUnion<Condition>(ax_, az_);
		IEnumerable<Condition> bb_ = context.Operators.ListUnion<Condition>(av_, ba_);
		CqlValueSet bc_ = this.Eating_Disorders();
		IEnumerable<Condition> bd_ = context.Operators.RetrieveByValueSet<Condition>(bc_, null);
		CqlValueSet be_ = this.Amenorrhea();
		IEnumerable<Condition> bf_ = context.Operators.RetrieveByValueSet<Condition>(be_, null);
		IEnumerable<Condition> bg_ = context.Operators.ListUnion<Condition>(bd_, bf_);
		IEnumerable<Condition> bh_ = context.Operators.ListUnion<Condition>(bb_, bg_);
		IEnumerable<Condition> bi_ = this.DiagnosisInPatientHistory(bh_);
		bool? bj_ = context.Operators.Exists<Condition>(bi_);
		bool? bk_ = context.Operators.Or(a_, bj_);
		CqlValueSet bl_ = this.Chemotherapy();
		IEnumerable<Procedure> bm_ = context.Operators.RetrieveByValueSet<Procedure>(bl_, null);
		IEnumerable<Procedure> bn_ = this.ProcedureInPatientHistory(bm_);
		bool? bo_ = context.Operators.Exists<Procedure>(bn_);
		bool? bp_ = context.Operators.Or(bk_, bo_);
		bool? bq_ = this.Has_Double_or_Bilateral_Oophorectomy();
		bool? br_ = context.Operators.Or(bp_, bq_);
		bool? bs_ = this.Has_Organ_Transplants();
		bool? bt_ = context.Operators.Or(br_, bs_);

		return bt_;
	}

    [CqlDeclaration("Has Risk Factor Any Time in History or During Measurement Period")]
	public bool? Has_Risk_Factor_Any_Time_in_History_or_During_Measurement_Period() => 
		__Has_Risk_Factor_Any_Time_in_History_or_During_Measurement_Period.Value;

	private bool? Denominator_Exclusions_Value()
	{
		bool? a_ = this.Has_Risk_Factor_Active_During_the_Measurement_Period();
		bool? b_ = this.Has_Risk_Factor_Any_Time_in_History_Prior_to_Measurement_Period();
		bool? c_ = context.Operators.Or(a_, b_);
		bool? d_ = this.Has_Risk_Factor_Any_Time_in_History_Prior_to_Measurement_Period_and_Do_Not_Need_to_be_Active_During_Measurement_Period();
		bool? e_ = context.Operators.Or(c_, d_);
		bool? f_ = this.Has_Risk_Factor_Any_Time_in_History_or_During_Measurement_Period();
		bool? g_ = context.Operators.Or(e_, f_);

		return g_;
	}

    [CqlDeclaration("Denominator Exclusions")]
	public bool? Denominator_Exclusions() => 
		__Denominator_Exclusions.Value;

	private IEnumerable<ServiceRequest> DXA_Scan_Order_During_Measurement_Period_Value()
	{
		CqlValueSet a_ = this.DXA__Dual_energy_Xray_Absorptiometry__Scan();
		IEnumerable<ServiceRequest> b_ = context.Operators.RetrieveByValueSet<ServiceRequest>(a_, null);
		IEnumerable<ServiceRequest> c_ = Status_1_6_000.Completed_or_Ongoing_Service_Request(b_);
		bool? d_(ServiceRequest DXA)
		{
			CqlInterval<CqlDateTime> h_ = this.Measurement_Period();
			CqlDateTime i_ = context.Operators.Convert<CqlDateTime>(DXA?.AuthoredOnElement);
			CqlInterval<CqlDateTime> j_ = QICoreCommon_2_0_000.ToInterval((i_ as object));
			bool? k_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(h_, j_, null);

			return k_;
		};
		IEnumerable<ServiceRequest> e_ = context.Operators.Where<ServiceRequest>(c_, d_);
		object f_(ServiceRequest @this)
		{
			CqlDateTime l_ = context.Operators.Convert<CqlDateTime>(@this?.AuthoredOnElement);

			return l_;
		};
		IEnumerable<ServiceRequest> g_ = context.Operators.SortBy<ServiceRequest>(e_, f_, System.ComponentModel.ListSortDirection.Ascending);

		return g_;
	}

    [CqlDeclaration("DXA Scan Order During Measurement Period")]
	public IEnumerable<ServiceRequest> DXA_Scan_Order_During_Measurement_Period() => 
		__DXA_Scan_Order_During_Measurement_Period.Value;

	private bool? Numerator_Value()
	{
		IEnumerable<ServiceRequest> a_ = this.DXA_Scan_Order_During_Measurement_Period();
		bool? b_ = context.Operators.Exists<ServiceRequest>(a_);

		return b_;
	}

    [CqlDeclaration("Numerator")]
	public bool? Numerator() => 
		__Numerator.Value;

	private IEnumerable<Observation> Osteoporosis_Fracture_Risk_Assessment_Prior_to_First_DXA_Scan_Value()
	{
		CqlCode a_ = this.Major_osteoporotic_fracture_10_year_probability__Likelihood__Fracture_Risk_Assessment();
		IEnumerable<CqlCode> b_ = context.Operators.ToList<CqlCode>(a_);
		IEnumerable<Observation> c_ = context.Operators.RetrieveByCodes<Observation>(b_, null);
		IEnumerable<Observation> d_ = Status_1_6_000.Final_Survey_Observation(c_);
		bool? e_(Observation FRAX)
		{
			object ad_ = FHIRHelpers_4_3_000.ToValue(FRAX?.Value);
			CqlQuantity ae_ = context.Operators.Quantity(8.4m, "%");
			bool? af_ = context.Operators.GreaterOrEqual((ad_ as CqlQuantity), ae_);

			return af_;
		};
		IEnumerable<Observation> f_ = context.Operators.Where<Observation>(d_, e_);
		CqlCode g_ = this.Osteoporosis_Risk_Assessment_Instrument();
		IEnumerable<CqlCode> h_ = context.Operators.ToList<CqlCode>(g_);
		IEnumerable<Observation> i_ = context.Operators.RetrieveByCodes<Observation>(h_, null);
		IEnumerable<Observation> j_ = Status_1_6_000.Final_Survey_Observation(i_);
		bool? k_(Observation ORAI)
		{
			object ag_ = FHIRHelpers_4_3_000.ToValue(ORAI?.Value);
			bool? ah_ = context.Operators.GreaterOrEqual((int?)ag_, 9);

			return ah_;
		};
		IEnumerable<Observation> l_ = context.Operators.Where<Observation>(j_, k_);
		IEnumerable<Observation> m_ = context.Operators.ListUnion<Observation>(f_, l_);
		CqlCode n_ = this.Osteoporosis_Index_of_Risk_panel();
		IEnumerable<CqlCode> o_ = context.Operators.ToList<CqlCode>(n_);
		IEnumerable<Observation> p_ = context.Operators.RetrieveByCodes<Observation>(o_, null);
		IEnumerable<Observation> q_ = Status_1_6_000.Final_Survey_Observation(p_);
		bool? r_(Observation OSIRIS)
		{
			object ai_ = FHIRHelpers_4_3_000.ToValue(OSIRIS?.Value);
			CqlQuantity aj_ = context.Operators.ConvertDecimalToQuantity(1.0m);
			bool? ak_ = context.Operators.Less((ai_ as CqlQuantity), aj_);

			return ak_;
		};
		IEnumerable<Observation> s_ = context.Operators.Where<Observation>(q_, r_);
		CqlCode t_ = this.Osteoporosis_Self_Assessment_Tool();
		IEnumerable<CqlCode> u_ = context.Operators.ToList<CqlCode>(t_);
		IEnumerable<Observation> v_ = context.Operators.RetrieveByCodes<Observation>(u_, null);
		IEnumerable<Observation> w_ = Status_1_6_000.Final_Survey_Observation(v_);
		bool? x_(Observation OST)
		{
			object al_ = FHIRHelpers_4_3_000.ToValue(OST?.Value);
			CqlQuantity am_ = context.Operators.ConvertDecimalToQuantity(2.0m);
			bool? an_ = context.Operators.Less((al_ as CqlQuantity), am_);

			return an_;
		};
		IEnumerable<Observation> y_ = context.Operators.Where<Observation>(w_, x_);
		IEnumerable<Observation> z_ = context.Operators.ListUnion<Observation>(s_, y_);
		IEnumerable<Observation> aa_ = context.Operators.ListUnion<Observation>(m_, z_);
		bool? ab_(Observation RiskAssessment)
		{
			object ao_ = FHIRHelpers_4_3_000.ToValue(RiskAssessment?.Effective);
			CqlInterval<CqlDateTime> ap_ = QICoreCommon_2_0_000.ToInterval(ao_);
			CqlDateTime aq_ = context.Operators.Start(ap_);
			IEnumerable<ServiceRequest> ar_ = this.DXA_Scan_Order_During_Measurement_Period();
			ServiceRequest as_ = context.Operators.First<ServiceRequest>(ar_);
			CqlDateTime at_ = context.Operators.Convert<CqlDateTime>(as_?.AuthoredOnElement);
			bool? au_ = context.Operators.Before(aq_, at_, null);

			return au_;
		};
		IEnumerable<Observation> ac_ = context.Operators.Where<Observation>(aa_, ab_);

		return ac_;
	}

    [CqlDeclaration("Osteoporosis Fracture Risk Assessment Prior to First DXA Scan")]
	public IEnumerable<Observation> Osteoporosis_Fracture_Risk_Assessment_Prior_to_First_DXA_Scan() => 
		__Osteoporosis_Fracture_Risk_Assessment_Prior_to_First_DXA_Scan.Value;

	private bool? Numerator_Exclusion_Value()
	{
		IEnumerable<Observation> a_ = this.Osteoporosis_Fracture_Risk_Assessment_Prior_to_First_DXA_Scan();
		bool? b_ = context.Operators.Exists<Observation>(a_);

		return b_;
	}

    [CqlDeclaration("Numerator Exclusion")]
	public bool? Numerator_Exclusion() => 
		__Numerator_Exclusion.Value;

    [CqlDeclaration("Final Survey Observation")]
	public IEnumerable<Observation> Final_Survey_Observation(IEnumerable<Observation> Obs)
	{
		bool? a_(Observation O)
		{
			Code<ObservationStatus> c_ = context.Operators.Convert<Code<ObservationStatus>>(O?.StatusElement?.Value);
			string d_ = context.Operators.Convert<string>(c_);
			string[] e_ = new string[]
			{
				"final",
				"amended",
				"corrected",
			};
			bool? f_ = context.Operators.In<string>(d_, (e_ as IEnumerable<string>));
			CqlConcept g_(CodeableConcept @this)
			{
				CqlConcept k_ = FHIRHelpers_4_3_000.ToConcept(@this);

				return k_;
			};
			IEnumerable<CqlConcept> h_ = context.Operators.Select<CodeableConcept, CqlConcept>(O?.Category, g_);
			bool? i_ = context.Operators.Exists<CqlConcept>(h_);
			bool? j_ = context.Operators.And(f_, i_);

			return j_;
		};
		IEnumerable<Observation> b_ = context.Operators.Where<Observation>(Obs, a_);

		return b_;
	}

}

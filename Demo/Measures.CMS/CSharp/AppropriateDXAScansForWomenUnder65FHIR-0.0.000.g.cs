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
    internal Lazy<(IEnumerable<CqlCode> codes, string display)?> __SDE_Ethnicity;
    internal Lazy<IEnumerable<(CqlConcept code, CqlInterval<CqlDateTime> period)?>> __SDE_Payer;
    internal Lazy<(IEnumerable<CqlCode> codes, string display)?> __SDE_Race;
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
        __SDE_Ethnicity = new Lazy<(IEnumerable<CqlCode> codes, string display)?>(this.SDE_Ethnicity_Value);
        __SDE_Payer = new Lazy<IEnumerable<(CqlConcept code, CqlInterval<CqlDateTime> period)?>>(this.SDE_Payer_Value);
        __SDE_Race = new Lazy<(IEnumerable<CqlCode> codes, string display)?>(this.SDE_Race_Value);
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
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.1022", default);

    [CqlDeclaration("Amenorrhea")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.1022")]
	public CqlValueSet Amenorrhea() => 
		__Amenorrhea.Value;

	private CqlValueSet Ankylosing_Spondylitis_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.113.12.1045", default);

    [CqlDeclaration("Ankylosing Spondylitis")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.113.12.1045")]
	public CqlValueSet Ankylosing_Spondylitis() => 
		__Ankylosing_Spondylitis.Value;

	private CqlValueSet Aromatase_Inhibitors_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.196.12.1265", default);

    [CqlDeclaration("Aromatase Inhibitors")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.196.12.1265")]
	public CqlValueSet Aromatase_Inhibitors() => 
		__Aromatase_Inhibitors.Value;

	private CqlValueSet Bilateral_Oophorectomy_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.471", default);

    [CqlDeclaration("Bilateral Oophorectomy")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.471")]
	public CqlValueSet Bilateral_Oophorectomy() => 
		__Bilateral_Oophorectomy.Value;

	private CqlValueSet Bone_Marrow_Transplant_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.666.5.336", default);

    [CqlDeclaration("Bone Marrow Transplant")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.666.5.336")]
	public CqlValueSet Bone_Marrow_Transplant() => 
		__Bone_Marrow_Transplant.Value;

	private CqlValueSet Chemotherapy_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.485", default);

    [CqlDeclaration("Chemotherapy")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.485")]
	public CqlValueSet Chemotherapy() => 
		__Chemotherapy.Value;

	private CqlValueSet Chronic_Liver_Disease_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.199.12.1035", default);

    [CqlDeclaration("Chronic Liver Disease")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.199.12.1035")]
	public CqlValueSet Chronic_Liver_Disease() => 
		__Chronic_Liver_Disease.Value;

	private CqlValueSet Chronic_Malnutrition_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.199.12.1036", default);

    [CqlDeclaration("Chronic Malnutrition")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.199.12.1036")]
	public CqlValueSet Chronic_Malnutrition() => 
		__Chronic_Malnutrition.Value;

	private CqlValueSet Cushings_Syndrome_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.117.12.1009", default);

    [CqlDeclaration("Cushings Syndrome")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.117.12.1009")]
	public CqlValueSet Cushings_Syndrome() => 
		__Cushings_Syndrome.Value;

	private CqlValueSet DXA__Dual_energy_Xray_Absorptiometry__Scan_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.113.12.1051", default);

    [CqlDeclaration("DXA (Dual energy Xray Absorptiometry) Scan")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.113.12.1051")]
	public CqlValueSet DXA__Dual_energy_Xray_Absorptiometry__Scan() => 
		__DXA__Dual_energy_Xray_Absorptiometry__Scan.Value;

	private CqlValueSet Eating_Disorders_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.1039", default);

    [CqlDeclaration("Eating Disorders")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.1039")]
	public CqlValueSet Eating_Disorders() => 
		__Eating_Disorders.Value;

	private CqlValueSet Ehlers_Danlos_Syndrome_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.113.12.1047", default);

    [CqlDeclaration("Ehlers Danlos Syndrome")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.113.12.1047")]
	public CqlValueSet Ehlers_Danlos_Syndrome() => 
		__Ehlers_Danlos_Syndrome.Value;

	private CqlValueSet End_Stage_Renal_Disease_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.353", default);

    [CqlDeclaration("End Stage Renal Disease")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.353")]
	public CqlValueSet End_Stage_Renal_Disease() => 
		__End_Stage_Renal_Disease.Value;

	private CqlValueSet Evidence_of_Bilateral_Oophorectomy_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.1048", default);

    [CqlDeclaration("Evidence of Bilateral Oophorectomy")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.1048")]
	public CqlValueSet Evidence_of_Bilateral_Oophorectomy() => 
		__Evidence_of_Bilateral_Oophorectomy.Value;

	private CqlValueSet Gastric_Bypass_Surgery_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.198.12.1050", default);

    [CqlDeclaration("Gastric Bypass Surgery")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.198.12.1050")]
	public CqlValueSet Gastric_Bypass_Surgery() => 
		__Gastric_Bypass_Surgery.Value;

	private CqlValueSet Glucocorticoids__oral_only__Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.196.12.1266", default);

    [CqlDeclaration("Glucocorticoids (oral only)")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.196.12.1266")]
	public CqlValueSet Glucocorticoids__oral_only_() => 
		__Glucocorticoids__oral_only_.Value;

	private CqlValueSet History_of_hip_fracture_in_parent_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.113.12.1040", default);

    [CqlDeclaration("History of hip fracture in parent")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.113.12.1040")]
	public CqlValueSet History_of_hip_fracture_in_parent() => 
		__History_of_hip_fracture_in_parent.Value;

	private CqlValueSet Hyperparathyroidism_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.117.12.1016", default);

    [CqlDeclaration("Hyperparathyroidism")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.117.12.1016")]
	public CqlValueSet Hyperparathyroidism() => 
		__Hyperparathyroidism.Value;

	private CqlValueSet Hyperthyroidism_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.117.12.1015", default);

    [CqlDeclaration("Hyperthyroidism")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.117.12.1015")]
	public CqlValueSet Hyperthyroidism() => 
		__Hyperthyroidism.Value;

	private CqlValueSet Kidney_Transplant_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.109.12.1012", default);

    [CqlDeclaration("Kidney Transplant")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.109.12.1012")]
	public CqlValueSet Kidney_Transplant() => 
		__Kidney_Transplant.Value;

	private CqlValueSet Lupus_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.117.12.1010", default);

    [CqlDeclaration("Lupus")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.117.12.1010")]
	public CqlValueSet Lupus() => 
		__Lupus.Value;

	private CqlValueSet Major_Transplant_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.198.12.1075", default);

    [CqlDeclaration("Major Transplant")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.198.12.1075")]
	public CqlValueSet Major_Transplant() => 
		__Major_Transplant.Value;

	private CqlValueSet Malabsorption_Syndromes_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.199.12.1050", default);

    [CqlDeclaration("Malabsorption Syndromes")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.199.12.1050")]
	public CqlValueSet Malabsorption_Syndromes() => 
		__Malabsorption_Syndromes.Value;

	private CqlValueSet Marfans_Syndrome_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.113.12.1048", default);

    [CqlDeclaration("Marfan's Syndrome")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.113.12.1048")]
	public CqlValueSet Marfans_Syndrome() => 
		__Marfans_Syndrome.Value;

	private CqlValueSet Multiple_Myeloma_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.1011", default);

    [CqlDeclaration("Multiple Myeloma")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.1011")]
	public CqlValueSet Multiple_Myeloma() => 
		__Multiple_Myeloma.Value;

	private CqlValueSet Office_Visit_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1001", default);

    [CqlDeclaration("Office Visit")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1001")]
	public CqlValueSet Office_Visit() => 
		__Office_Visit.Value;

	private CqlValueSet Online_Assessments_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1089", default);

    [CqlDeclaration("Online Assessments")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1089")]
	public CqlValueSet Online_Assessments() => 
		__Online_Assessments.Value;

	private CqlValueSet Osteogenesis_Imperfecta_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.113.12.1044", default);

    [CqlDeclaration("Osteogenesis Imperfecta")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.113.12.1044")]
	public CqlValueSet Osteogenesis_Imperfecta() => 
		__Osteogenesis_Imperfecta.Value;

	private CqlValueSet Osteopenia_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.113.12.1049", default);

    [CqlDeclaration("Osteopenia")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.113.12.1049")]
	public CqlValueSet Osteopenia() => 
		__Osteopenia.Value;

	private CqlValueSet Osteoporosis_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.113.12.1038", default);

    [CqlDeclaration("Osteoporosis")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.113.12.1038")]
	public CqlValueSet Osteoporosis() => 
		__Osteoporosis.Value;

	private CqlValueSet Osteoporotic_Fractures_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.113.12.1050", default);

    [CqlDeclaration("Osteoporotic Fractures")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.113.12.1050")]
	public CqlValueSet Osteoporotic_Fractures() => 
		__Osteoporotic_Fractures.Value;

	private CqlValueSet Outpatient_Consultation_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1008", default);

    [CqlDeclaration("Outpatient Consultation")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1008")]
	public CqlValueSet Outpatient_Consultation() => 
		__Outpatient_Consultation.Value;

	private CqlValueSet Premature_Menopause_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.1013", default);

    [CqlDeclaration("Premature Menopause")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.1013")]
	public CqlValueSet Premature_Menopause() => 
		__Premature_Menopause.Value;

	private CqlValueSet Preventive_Care_Services_Established_Office_Visit__18_and_Up_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1025", default);

    [CqlDeclaration("Preventive Care Services Established Office Visit, 18 and Up")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1025")]
	public CqlValueSet Preventive_Care_Services_Established_Office_Visit__18_and_Up() => 
		__Preventive_Care_Services_Established_Office_Visit__18_and_Up.Value;

	private CqlValueSet Preventive_Care_Services_Initial_Office_Visit__18_and_Up_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1023", default);

    [CqlDeclaration("Preventive Care Services Initial Office Visit, 18 and Up")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1023")]
	public CqlValueSet Preventive_Care_Services_Initial_Office_Visit__18_and_Up() => 
		__Preventive_Care_Services_Initial_Office_Visit__18_and_Up.Value;

	private CqlValueSet Psoriatic_Arthritis_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.113.12.1046", default);

    [CqlDeclaration("Psoriatic Arthritis")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.113.12.1046")]
	public CqlValueSet Psoriatic_Arthritis() => 
		__Psoriatic_Arthritis.Value;

	private CqlValueSet Rheumatoid_Arthritis_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.113.12.1005", default);

    [CqlDeclaration("Rheumatoid Arthritis")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.113.12.1005")]
	public CqlValueSet Rheumatoid_Arthritis() => 
		__Rheumatoid_Arthritis.Value;

	private CqlValueSet Telephone_Visits_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1080", default);

    [CqlDeclaration("Telephone Visits")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1080")]
	public CqlValueSet Telephone_Visits() => 
		__Telephone_Visits.Value;

	private CqlValueSet Type_1_Diabetes_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.103.12.1020", default);

    [CqlDeclaration("Type 1 Diabetes")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.103.12.1020")]
	public CqlValueSet Type_1_Diabetes() => 
		__Type_1_Diabetes.Value;

	private CqlValueSet Unilateral_Oophorectomy_Left_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.1028", default);

    [CqlDeclaration("Unilateral Oophorectomy Left")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.1028")]
	public CqlValueSet Unilateral_Oophorectomy_Left() => 
		__Unilateral_Oophorectomy_Left.Value;

	private CqlValueSet Unilateral_Oophorectomy_Right_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.1032", default);

    [CqlDeclaration("Unilateral Oophorectomy Right")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.1032")]
	public CqlValueSet Unilateral_Oophorectomy_Right() => 
		__Unilateral_Oophorectomy_Right.Value;

	private CqlValueSet Unilateral_Oophorectomy__Unspecified_Laterality_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.1035", default);

    [CqlDeclaration("Unilateral Oophorectomy, Unspecified Laterality")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.1035")]
	public CqlValueSet Unilateral_Oophorectomy__Unspecified_Laterality() => 
		__Unilateral_Oophorectomy__Unspecified_Laterality.Value;

	private CqlCode Alcoholic_drinks_per_drinking_day___Reported_Value() => 
		new CqlCode("11287-0", "http://loinc.org", default, default);

    [CqlDeclaration("Alcoholic drinks per drinking day - Reported")]
	public CqlCode Alcoholic_drinks_per_drinking_day___Reported() => 
		__Alcoholic_drinks_per_drinking_day___Reported.Value;

	private CqlCode Body_mass_index__BMI___Ratio__Value() => 
		new CqlCode("39156-5", "http://loinc.org", default, default);

    [CqlDeclaration("Body mass index (BMI) [Ratio]")]
	public CqlCode Body_mass_index__BMI___Ratio_() => 
		__Body_mass_index__BMI___Ratio_.Value;

	private CqlCode Female_Value() => 
		new CqlCode("F", "http://terminology.hl7.org/CodeSystem/v3-AdministrativeGender", default, default);

    [CqlDeclaration("Female")]
	public CqlCode Female() => 
		__Female.Value;

	private CqlCode Left__qualifier_value__Value() => 
		new CqlCode("7771000", "http://snomed.info/sct", default, default);

    [CqlDeclaration("Left (qualifier value)")]
	public CqlCode Left__qualifier_value_() => 
		__Left__qualifier_value_.Value;

	private CqlCode Major_osteoporotic_fracture_10_year_probability__Likelihood__Fracture_Risk_Assessment_Value() => 
		new CqlCode("90265-0", "http://loinc.org", default, default);

    [CqlDeclaration("Major osteoporotic fracture 10-year probability [Likelihood] Fracture Risk Assessment")]
	public CqlCode Major_osteoporotic_fracture_10_year_probability__Likelihood__Fracture_Risk_Assessment() => 
		__Major_osteoporotic_fracture_10_year_probability__Likelihood__Fracture_Risk_Assessment.Value;

	private CqlCode Osteoporosis_Index_of_Risk_panel_Value() => 
		new CqlCode("98133-2", "http://loinc.org", default, default);

    [CqlDeclaration("Osteoporosis Index of Risk panel")]
	public CqlCode Osteoporosis_Index_of_Risk_panel() => 
		__Osteoporosis_Index_of_Risk_panel.Value;

	private CqlCode Osteoporosis_Risk_Assessment_Instrument_Value() => 
		new CqlCode("98139-9", "http://loinc.org", default, default);

    [CqlDeclaration("Osteoporosis Risk Assessment Instrument")]
	public CqlCode Osteoporosis_Risk_Assessment_Instrument() => 
		__Osteoporosis_Risk_Assessment_Instrument.Value;

	private CqlCode Osteoporosis_Self_Assessment_Tool_Value() => 
		new CqlCode("98146-4", "http://loinc.org", default, default);

    [CqlDeclaration("Osteoporosis Self-Assessment Tool")]
	public CqlCode Osteoporosis_Self_Assessment_Tool() => 
		__Osteoporosis_Self_Assessment_Tool.Value;

	private CqlCode Right__qualifier_value__Value() => 
		new CqlCode("24028007", "http://snomed.info/sct", default, default);

    [CqlDeclaration("Right (qualifier value)")]
	public CqlCode Right__qualifier_value_() => 
		__Right__qualifier_value_.Value;

	private CqlCode Unlisted_preventive_medicine_service_Value() => 
		new CqlCode("99429", "http://www.ama-assn.org/go/cpt", default, default);

    [CqlDeclaration("Unlisted preventive medicine service")]
	public CqlCode Unlisted_preventive_medicine_service() => 
		__Unlisted_preventive_medicine_service.Value;

	private CqlCode[] LOINC_Value()
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

    [CqlDeclaration("LOINC")]
	public CqlCode[] LOINC() => 
		__LOINC.Value;

	private CqlCode[] AdministrativeGender_Value()
	{
		CqlCode[] a_ = [
			new CqlCode("F", "http://terminology.hl7.org/CodeSystem/v3-AdministrativeGender", default, default),
		];

		return a_;
	}

    [CqlDeclaration("AdministrativeGender")]
	public CqlCode[] AdministrativeGender() => 
		__AdministrativeGender.Value;

	private CqlCode[] SNOMEDCT_Value()
	{
		CqlCode[] a_ = [
			new CqlCode("7771000", "http://snomed.info/sct", default, default),
			new CqlCode("24028007", "http://snomed.info/sct", default, default),
		];

		return a_;
	}

    [CqlDeclaration("SNOMEDCT")]
	public CqlCode[] SNOMEDCT() => 
		__SNOMEDCT.Value;

	private CqlCode[] CPT_Value()
	{
		CqlCode[] a_ = [
			new CqlCode("99429", "http://www.ama-assn.org/go/cpt", default, default),
		];

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
		IEnumerable<Patient> a_ = context.Operators.RetrieveByValueSet<Patient>(default, default);
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

	private IEnumerable<Encounter> Qualifying_Encounter_Value()
	{
		CqlValueSet a_ = this.Office_Visit();
		IEnumerable<Encounter> b_ = context.Operators.RetrieveByValueSet<Encounter>(a_, default);
		CqlValueSet c_ = this.Preventive_Care_Services_Established_Office_Visit__18_and_Up();
		IEnumerable<Encounter> d_ = context.Operators.RetrieveByValueSet<Encounter>(c_, default);
		IEnumerable<Encounter> e_ = context.Operators.Union<Encounter>(b_, d_);
		IEnumerable<Encounter> f_ = context.Operators.RetrieveByValueSet<Encounter>(default, default);
		bool? g_(Encounter E)
		{
			List<CodeableConcept> x_ = E?.Type;
			CqlConcept y_(CodeableConcept @this)
			{
				CqlConcept ad_ = FHIRHelpers_4_3_000.ToConcept(@this);

				return ad_;
			};
			IEnumerable<CqlConcept> z_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)x_, y_);
			bool? aa_(CqlConcept T)
			{
				CqlCode ae_ = this.Unlisted_preventive_medicine_service();
				CqlConcept af_ = context.Operators.ConvertCodeToConcept(ae_);
				bool? ag_ = context.Operators.Equivalent(T, af_);

				return ag_;
			};
			IEnumerable<CqlConcept> ab_ = context.Operators.Where<CqlConcept>(z_, aa_);
			bool? ac_ = context.Operators.Exists<CqlConcept>(ab_);

			return ac_;
		};
		IEnumerable<Encounter> h_ = context.Operators.Where<Encounter>(f_, g_);
		CqlValueSet i_ = this.Preventive_Care_Services_Initial_Office_Visit__18_and_Up();
		IEnumerable<Encounter> j_ = context.Operators.RetrieveByValueSet<Encounter>(i_, default);
		IEnumerable<Encounter> k_ = context.Operators.Union<Encounter>(h_, j_);
		IEnumerable<Encounter> l_ = context.Operators.Union<Encounter>(e_, k_);
		CqlValueSet m_ = this.Outpatient_Consultation();
		IEnumerable<Encounter> n_ = context.Operators.RetrieveByValueSet<Encounter>(m_, default);
		CqlValueSet o_ = this.Online_Assessments();
		IEnumerable<Encounter> p_ = context.Operators.RetrieveByValueSet<Encounter>(o_, default);
		IEnumerable<Encounter> q_ = context.Operators.Union<Encounter>(n_, p_);
		IEnumerable<Encounter> r_ = context.Operators.Union<Encounter>(l_, q_);
		CqlValueSet s_ = this.Telephone_Visits();
		IEnumerable<Encounter> t_ = context.Operators.RetrieveByValueSet<Encounter>(s_, default);
		IEnumerable<Encounter> u_ = context.Operators.Union<Encounter>(r_, t_);
		bool? v_(Encounter ValidEncounters)
		{
			CqlInterval<CqlDateTime> ah_ = this.Measurement_Period();
			Period ai_ = ValidEncounters?.Period;
			CqlInterval<CqlDateTime> aj_ = FHIRHelpers_4_3_000.ToInterval(ai_);
			CqlInterval<CqlDateTime> ak_ = QICoreCommon_2_0_000.ToInterval(aj_ as object);
			bool? al_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(ah_, ak_, "day");

			return al_;
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
		Date b_ = a_?.BirthDateElement;
		string c_ = b_?.Value;
		CqlDate d_ = context.Operators.ConvertStringToDate(c_);
		CqlInterval<CqlDateTime> e_ = this.Measurement_Period();
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
		IEnumerable<Encounter> q_ = this.Qualifying_Encounter();
		bool? r_ = context.Operators.Exists<Encounter>(q_);
		bool? s_ = context.Operators.And(p_, r_);

		return s_;
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
		IEnumerable<Observation> a_ = context.Operators.RetrieveByValueSet<Observation>(default, default);
		IEnumerable<Observation> b_ = Status_1_6_000.BMI(a_);
		bool? c_(Observation BMIRatio)
		{
			CqlInterval<CqlDateTime> h_ = this.Measurement_Period();
			DataType i_ = BMIRatio?.Effective;
			object j_ = FHIRHelpers_4_3_000.ToValue(i_);
			CqlInterval<CqlDateTime> k_ = QICoreCommon_2_0_000.ToInterval(j_);
			bool? l_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(h_, k_, default);
			DataType m_ = BMIRatio?.Value;
			CqlQuantity n_ = FHIRHelpers_4_3_000.ToQuantity(m_ as Quantity);
			bool? o_ = context.Operators.Not((bool?)((n_ as CqlQuantity) is null));
			bool? p_ = context.Operators.And(l_, o_);

			return p_;
		};
		IEnumerable<Observation> d_ = context.Operators.Where<Observation>(b_, c_);
		object e_(Observation @this)
		{
			DataType q_ = @this?.Effective;
			object r_ = FHIRHelpers_4_3_000.ToValue(q_);
			CqlInterval<CqlDateTime> s_ = QICoreCommon_2_0_000.ToInterval(r_);
			CqlDateTime t_ = context.Operators.Start(s_);

			return t_;
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
		Observation[] b_ = [
			a_,
		];
		bool? c_(Observation FirstBMI)
		{
			DataType f_ = FirstBMI?.Value;
			CqlQuantity g_ = FHIRHelpers_4_3_000.ToQuantity(f_ as Quantity);
			CqlQuantity h_ = context.Operators.Quantity(20m, "kg/m2");
			bool? i_ = context.Operators.LessOrEqual(g_ as CqlQuantity, h_);

			return i_;
		};
		IEnumerable<Observation> d_ = context.Operators.Where<Observation>((IEnumerable<Observation>)b_, c_);
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
		IEnumerable<Observation> c_ = context.Operators.RetrieveByCodes<Observation>(b_, default);
		IEnumerable<Observation> d_ = Status_1_6_000.Final_Survey_Observation(c_);
		bool? e_(Observation AverageDrinks)
		{
			DataType j_ = AverageDrinks?.Effective;
			object k_ = FHIRHelpers_4_3_000.ToValue(j_);
			CqlInterval<CqlDateTime> l_ = QICoreCommon_2_0_000.ToInterval(k_);
			CqlDateTime m_ = context.Operators.Start(l_);
			CqlInterval<CqlDateTime> n_ = this.Measurement_Period();
			bool? o_ = context.Operators.In<CqlDateTime>(m_, n_, default);
			DataType p_ = AverageDrinks?.Value;
			object q_ = FHIRHelpers_4_3_000.ToValue(p_);
			CqlQuantity r_ = q_ switch { null => null , CqlQuantity a => a/* , CqlConcept => ???, bool => ???, CqlInterval<CqlQuantity> => ???, CqlRatio => ???, SampledData => ???, CqlTime => ???, CqlDateTime => ???, CqlInterval<CqlDateTime> => ??? */, _ => throw new System.Diagnostics.UnreachableException() };
			CqlQuantity s_ = context.Operators.Quantity(2m, "{drinks}/d");
			bool? t_ = context.Operators.Greater(r_, s_);
			bool? u_ = context.Operators.And(o_, t_);

			return u_;
		};
		IEnumerable<Observation> f_ = context.Operators.Where<Observation>(d_, e_);
		object g_(Observation @this)
		{
			DataType v_ = @this?.Effective;
			object w_ = FHIRHelpers_4_3_000.ToValue(v_);
			CqlInterval<CqlDateTime> x_ = QICoreCommon_2_0_000.ToInterval(w_);
			CqlDateTime y_ = context.Operators.Start(x_);

			return y_;
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
		IEnumerable<Condition> b_ = context.Operators.RetrieveByValueSet<Condition>(a_, default);
		bool? c_(Condition OsteoporosisDiagnosis)
		{
			CqlInterval<CqlDateTime> f_ = QICoreCommon_2_0_000.ToPrevalenceInterval(OsteoporosisDiagnosis);
			CqlDateTime g_ = context.Operators.Start(f_);
			CqlInterval<CqlDateTime> h_ = this.Measurement_Period();
			CqlDateTime i_ = context.Operators.Start(h_);
			bool? j_ = context.Operators.Before(g_, i_, default);

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
		IEnumerable<Condition> b_ = context.Operators.RetrieveByValueSet<Condition>(a_, default);
		bool? c_(Condition OsteopeniaDiagnosis)
		{
			CqlInterval<CqlDateTime> f_ = QICoreCommon_2_0_000.ToPrevalenceInterval(OsteopeniaDiagnosis);
			CqlDateTime g_ = context.Operators.Start(f_);
			CqlInterval<CqlDateTime> h_ = this.Measurement_Period();
			CqlDateTime i_ = context.Operators.Start(h_);
			bool? j_ = context.Operators.Before(g_, i_, default);

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
		IEnumerable<Observation> b_ = context.Operators.RetrieveByValueSet<Observation>(a_, default);
		IEnumerable<Observation> c_ = Status_1_6_000.Final_Survey_Observation(b_);
		bool? d_(Observation ParentFractureHistory)
		{
			DataType f_ = ParentFractureHistory?.Effective;
			object g_ = FHIRHelpers_4_3_000.ToValue(f_);
			CqlInterval<CqlDateTime> h_ = QICoreCommon_2_0_000.ToInterval(g_);
			CqlDateTime i_ = context.Operators.Start(h_);
			CqlInterval<CqlDateTime> j_ = this.Measurement_Period();
			CqlDateTime k_ = context.Operators.Start(j_);
			bool? l_ = context.Operators.Before(i_, k_, default);

			return l_;
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
		IEnumerable<Procedure> b_ = context.Operators.RetrieveByValueSet<Procedure>(a_, default);
		IEnumerable<Procedure> c_ = Status_1_6_000.Completed_Procedure(b_);
		bool? d_(Procedure GastricBypass)
		{
			DataType aa_ = GastricBypass?.Performed;
			object ab_ = FHIRHelpers_4_3_000.ToValue(aa_);
			CqlInterval<CqlDateTime> ac_ = QICoreCommon_2_0_000.ToInterval(ab_);
			CqlDateTime ad_ = context.Operators.End(ac_);
			CqlInterval<CqlDateTime> ae_ = this.Measurement_Period();
			CqlDateTime af_ = context.Operators.Start(ae_);
			bool? ag_ = context.Operators.Before(ad_, af_, default);

			return ag_;
		};
		IEnumerable<Procedure> e_ = context.Operators.Where<Procedure>(c_, d_);
		CqlValueSet f_ = this.Aromatase_Inhibitors();
		IEnumerable<MedicationRequest> g_ = context.Operators.RetrieveByValueSet<MedicationRequest>(f_, default);
		IEnumerable<MedicationRequest> i_ = context.Operators.RetrieveByValueSet<MedicationRequest>(f_, default);
		IEnumerable<MedicationRequest> j_ = context.Operators.Union<MedicationRequest>(g_, i_);
		IEnumerable<MedicationRequest> k_ = Status_1_6_000.Active_Medication(j_);
		bool? l_(MedicationRequest AromataseInhibitorActive)
		{
			CqlInterval<CqlDate> ah_ = CumulativeMedicationDuration_4_0_000.MedicationRequestPeriod(AromataseInhibitorActive);
			CqlDate ai_ = context.Operators.Start(ah_);
			CqlDateTime aj_ = context.Operators.ConvertDateToDateTime(ai_);
			CqlInterval<CqlDateTime> ak_ = this.Measurement_Period();
			CqlDateTime al_ = context.Operators.Start(ak_);
			bool? am_ = context.Operators.Before(aj_, al_, default);

			return am_;
		};
		IEnumerable<MedicationRequest> m_ = context.Operators.Where<MedicationRequest>(k_, l_);
		IEnumerable<object> n_ = context.Operators.Union<object>(e_ as IEnumerable<object>, m_ as IEnumerable<object>);
		IEnumerable<MedicationRequest> p_ = context.Operators.RetrieveByValueSet<MedicationRequest>(f_, default);
		IEnumerable<MedicationRequest> r_ = context.Operators.RetrieveByValueSet<MedicationRequest>(f_, default);
		IEnumerable<MedicationRequest> s_ = context.Operators.Union<MedicationRequest>(p_, r_);
		IEnumerable<MedicationRequest> t_ = Status_1_6_000.Active_or_Completed_Medication_Request(s_);
		bool? u_(MedicationRequest AromataseInhibitorOrder)
		{
			FhirDateTime an_ = AromataseInhibitorOrder?.AuthoredOnElement;
			CqlDateTime ao_ = context.Operators.Convert<CqlDateTime>(an_);
			CqlInterval<CqlDateTime> ap_ = QICoreCommon_2_0_000.ToInterval(ao_ as object);
			CqlInterval<CqlDateTime> aq_()
			{
				bool as_()
				{
					CqlInterval<CqlDateTime> at_ = this.Measurement_Period();
					CqlDateTime au_ = context.Operators.Start(at_);

					return au_ is null;
				};
				if (as_())
				{
					return default;
				}
				else
				{
					CqlInterval<CqlDateTime> av_ = this.Measurement_Period();
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
		IEnumerable<Observation> x_ = this.Parent_History_of_Hip_Fracture_Assessment();
		IEnumerable<object> y_ = context.Operators.Union<object>(w_ as IEnumerable<object>, x_ as IEnumerable<object>);
		bool? z_ = context.Operators.Exists<object>(y_);

		return z_;
	}

    [CqlDeclaration("Has Risk Factor Any Time in History Prior to Measurement Period and Do Not Need to be Active During Measurement Period")]
	public bool? Has_Risk_Factor_Any_Time_in_History_Prior_to_Measurement_Period_and_Do_Not_Need_to_be_Active_During_Measurement_Period() => 
		__Has_Risk_Factor_Any_Time_in_History_Prior_to_Measurement_Period_and_Do_Not_Need_to_be_Active_During_Measurement_Period.Value;

	private int? Glucocorticoid_Active_Medication_Duration_in_Days_Value()
	{
		CqlValueSet a_ = this.Glucocorticoids__oral_only_();
		IEnumerable<MedicationRequest> b_ = context.Operators.RetrieveByValueSet<MedicationRequest>(a_, default);
		IEnumerable<MedicationRequest> d_ = context.Operators.RetrieveByValueSet<MedicationRequest>(a_, default);
		IEnumerable<MedicationRequest> e_ = context.Operators.Union<MedicationRequest>(b_, d_);
		IEnumerable<MedicationRequest> f_ = Status_1_6_000.Active_Medication(e_);
		bool? g_(MedicationRequest OralGlucocorticoid)
		{
			CqlInterval<CqlDate> l_ = CumulativeMedicationDuration_4_0_000.MedicationRequestPeriod(OralGlucocorticoid);
			CqlDate m_ = context.Operators.Start(l_);
			CqlDateTime n_ = context.Operators.ConvertDateToDateTime(m_);
			CqlInterval<CqlDateTime> o_ = this.Measurement_Period();
			CqlDateTime p_ = context.Operators.End(o_);
			bool? q_ = context.Operators.Before(n_, p_, default);

			return q_;
		};
		IEnumerable<MedicationRequest> h_ = context.Operators.Where<MedicationRequest>(f_, g_);
		CqlInterval<CqlDate> i_(MedicationRequest Glucocorticoid)
		{
			CqlInterval<CqlDate> r_ = CumulativeMedicationDuration_4_0_000.MedicationRequestPeriod(Glucocorticoid);
			Patient s_ = this.Patient();
			Date t_ = s_?.BirthDateElement;
			string u_ = t_?.Value;
			CqlDate v_ = context.Operators.ConvertStringToDate(u_);
			CqlInterval<CqlDateTime> w_ = this.Measurement_Period();
			CqlDateTime x_ = context.Operators.End(w_);
			CqlDate y_ = context.Operators.DateFrom(x_);
			CqlInterval<CqlDate> z_ = context.Operators.Interval(v_, y_, true, true);
			CqlInterval<CqlDate> aa_ = context.Operators.Intersect<CqlDate>(r_, z_);

			return aa_;
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
			DataType d_ = Proc?.Performed;
			object e_ = FHIRHelpers_4_3_000.ToValue(d_);
			CqlInterval<CqlDateTime> f_ = QICoreCommon_2_0_000.ToInterval(e_);
			CqlDateTime g_ = context.Operators.End(f_);
			CqlInterval<CqlDateTime> h_ = this.Measurement_Period();
			CqlDateTime i_ = context.Operators.End(h_);
			bool? j_ = context.Operators.SameOrBefore(g_, i_, "day");

			return j_;
		};
		IEnumerable<Procedure> c_ = context.Operators.Where<Procedure>(a_, b_);

		return c_;
	}

	private bool? Has_Double_or_Bilateral_Oophorectomy_Value()
	{
		CqlValueSet a_ = this.Bilateral_Oophorectomy();
		IEnumerable<Procedure> b_ = context.Operators.RetrieveByValueSet<Procedure>(a_, default);
		IEnumerable<Procedure> c_ = this.ProcedureInPatientHistory(b_);
		bool? d_ = context.Operators.Exists<Procedure>(c_);
		CqlValueSet e_ = this.Evidence_of_Bilateral_Oophorectomy();
		IEnumerable<Procedure> f_ = context.Operators.RetrieveByValueSet<Procedure>(e_, default);
		IEnumerable<Procedure> g_ = this.ProcedureInPatientHistory(f_);
		bool? h_ = context.Operators.Exists<Procedure>(g_);
		bool? i_ = context.Operators.Or(d_, h_);
		CqlValueSet j_ = this.Unilateral_Oophorectomy__Unspecified_Laterality();
		IEnumerable<Procedure> k_ = context.Operators.RetrieveByValueSet<Procedure>(j_, default);
		bool? l_(Procedure UnilateralOophorectomy)
		{
			List<CodeableConcept> ad_ = UnilateralOophorectomy?.BodySite;
			CqlConcept ae_(CodeableConcept @this)
			{
				CqlConcept aj_ = FHIRHelpers_4_3_000.ToConcept(@this);

				return aj_;
			};
			IEnumerable<CqlConcept> af_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)ad_, ae_);
			bool? ag_(CqlConcept C)
			{
				CqlCode ak_ = this.Right__qualifier_value_();
				CqlConcept al_ = context.Operators.ConvertCodeToConcept(ak_);
				bool? am_ = context.Operators.Equivalent(C, al_);

				return am_;
			};
			IEnumerable<CqlConcept> ah_ = context.Operators.Where<CqlConcept>(af_, ag_);
			bool? ai_ = context.Operators.Exists<CqlConcept>(ah_);

			return ai_;
		};
		IEnumerable<Procedure> m_ = context.Operators.Where<Procedure>(k_, l_);
		CqlValueSet n_ = this.Unilateral_Oophorectomy_Right();
		IEnumerable<Procedure> o_ = context.Operators.RetrieveByValueSet<Procedure>(n_, default);
		IEnumerable<Procedure> p_ = context.Operators.Union<Procedure>(m_, o_);
		IEnumerable<Procedure> q_ = this.ProcedureInPatientHistory(p_);
		bool? r_ = context.Operators.Exists<Procedure>(q_);
		IEnumerable<Procedure> t_ = context.Operators.RetrieveByValueSet<Procedure>(j_, default);
		bool? u_(Procedure UnilateralOophorectomy)
		{
			List<CodeableConcept> an_ = UnilateralOophorectomy?.BodySite;
			CqlConcept ao_(CodeableConcept @this)
			{
				CqlConcept at_ = FHIRHelpers_4_3_000.ToConcept(@this);

				return at_;
			};
			IEnumerable<CqlConcept> ap_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)an_, ao_);
			bool? aq_(CqlConcept D)
			{
				CqlCode au_ = this.Left__qualifier_value_();
				CqlConcept av_ = context.Operators.ConvertCodeToConcept(au_);
				bool? aw_ = context.Operators.Equivalent(D, av_);

				return aw_;
			};
			IEnumerable<CqlConcept> ar_ = context.Operators.Where<CqlConcept>(ap_, aq_);
			bool? as_ = context.Operators.Exists<CqlConcept>(ar_);

			return as_;
		};
		IEnumerable<Procedure> v_ = context.Operators.Where<Procedure>(t_, u_);
		CqlValueSet w_ = this.Unilateral_Oophorectomy_Left();
		IEnumerable<Procedure> x_ = context.Operators.RetrieveByValueSet<Procedure>(w_, default);
		IEnumerable<Procedure> y_ = context.Operators.Union<Procedure>(v_, x_);
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
		IEnumerable<Procedure> b_ = context.Operators.RetrieveByValueSet<Procedure>(a_, default);
		CqlValueSet c_ = this.Kidney_Transplant();
		IEnumerable<Procedure> d_ = context.Operators.RetrieveByValueSet<Procedure>(c_, default);
		IEnumerable<Procedure> e_ = context.Operators.Union<Procedure>(b_, d_);
		CqlValueSet f_ = this.Bone_Marrow_Transplant();
		IEnumerable<Procedure> g_ = context.Operators.RetrieveByValueSet<Procedure>(f_, default);
		IEnumerable<Procedure> h_ = context.Operators.Union<Procedure>(e_, g_);
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
		IEnumerable<Condition> c_ = context.Operators.RetrieveByValueSet<Condition>(b_, default);
		CqlValueSet d_ = this.Malabsorption_Syndromes();
		IEnumerable<Condition> e_ = context.Operators.RetrieveByValueSet<Condition>(d_, default);
		IEnumerable<Condition> f_ = context.Operators.Union<Condition>(c_, e_);
		CqlValueSet g_ = this.Chronic_Malnutrition();
		IEnumerable<Condition> h_ = context.Operators.RetrieveByValueSet<Condition>(g_, default);
		CqlValueSet i_ = this.Chronic_Liver_Disease();
		IEnumerable<Condition> j_ = context.Operators.RetrieveByValueSet<Condition>(i_, default);
		IEnumerable<Condition> k_ = context.Operators.Union<Condition>(h_, j_);
		IEnumerable<Condition> l_ = context.Operators.Union<Condition>(f_, k_);
		CqlValueSet m_ = this.Rheumatoid_Arthritis();
		IEnumerable<Condition> n_ = context.Operators.RetrieveByValueSet<Condition>(m_, default);
		CqlValueSet o_ = this.Hyperthyroidism();
		IEnumerable<Condition> p_ = context.Operators.RetrieveByValueSet<Condition>(o_, default);
		IEnumerable<Condition> q_ = context.Operators.Union<Condition>(n_, p_);
		IEnumerable<Condition> r_ = context.Operators.Union<Condition>(l_, q_);
		CqlValueSet s_ = this.Type_1_Diabetes();
		IEnumerable<Condition> t_ = context.Operators.RetrieveByValueSet<Condition>(s_, default);
		CqlValueSet u_ = this.End_Stage_Renal_Disease();
		IEnumerable<Condition> v_ = context.Operators.RetrieveByValueSet<Condition>(u_, default);
		IEnumerable<Condition> w_ = context.Operators.Union<Condition>(t_, v_);
		IEnumerable<Condition> x_ = context.Operators.Union<Condition>(r_, w_);
		CqlValueSet y_ = this.Osteogenesis_Imperfecta();
		IEnumerable<Condition> z_ = context.Operators.RetrieveByValueSet<Condition>(y_, default);
		CqlValueSet aa_ = this.Ankylosing_Spondylitis();
		IEnumerable<Condition> ab_ = context.Operators.RetrieveByValueSet<Condition>(aa_, default);
		IEnumerable<Condition> ac_ = context.Operators.Union<Condition>(z_, ab_);
		IEnumerable<Condition> ad_ = context.Operators.Union<Condition>(x_, ac_);
		CqlValueSet ae_ = this.Psoriatic_Arthritis();
		IEnumerable<Condition> af_ = context.Operators.RetrieveByValueSet<Condition>(ae_, default);
		CqlValueSet ag_ = this.Ehlers_Danlos_Syndrome();
		IEnumerable<Condition> ah_ = context.Operators.RetrieveByValueSet<Condition>(ag_, default);
		IEnumerable<Condition> ai_ = context.Operators.Union<Condition>(af_, ah_);
		IEnumerable<Condition> aj_ = context.Operators.Union<Condition>(ad_, ai_);
		CqlValueSet ak_ = this.Cushings_Syndrome();
		IEnumerable<Condition> al_ = context.Operators.RetrieveByValueSet<Condition>(ak_, default);
		CqlValueSet am_ = this.Hyperparathyroidism();
		IEnumerable<Condition> an_ = context.Operators.RetrieveByValueSet<Condition>(am_, default);
		IEnumerable<Condition> ao_ = context.Operators.Union<Condition>(al_, an_);
		IEnumerable<Condition> ap_ = context.Operators.Union<Condition>(aj_, ao_);
		CqlValueSet aq_ = this.Marfans_Syndrome();
		IEnumerable<Condition> ar_ = context.Operators.RetrieveByValueSet<Condition>(aq_, default);
		CqlValueSet as_ = this.Lupus();
		IEnumerable<Condition> at_ = context.Operators.RetrieveByValueSet<Condition>(as_, default);
		IEnumerable<Condition> au_ = context.Operators.Union<Condition>(ar_, at_);
		IEnumerable<Condition> av_ = context.Operators.Union<Condition>(ap_, au_);
		CqlValueSet aw_ = this.Multiple_Myeloma();
		IEnumerable<Condition> ax_ = context.Operators.RetrieveByValueSet<Condition>(aw_, default);
		CqlValueSet ay_ = this.Premature_Menopause();
		IEnumerable<Condition> az_ = context.Operators.RetrieveByValueSet<Condition>(ay_, default);
		IEnumerable<Condition> ba_ = context.Operators.Union<Condition>(ax_, az_);
		IEnumerable<Condition> bb_ = context.Operators.Union<Condition>(av_, ba_);
		CqlValueSet bc_ = this.Eating_Disorders();
		IEnumerable<Condition> bd_ = context.Operators.RetrieveByValueSet<Condition>(bc_, default);
		CqlValueSet be_ = this.Amenorrhea();
		IEnumerable<Condition> bf_ = context.Operators.RetrieveByValueSet<Condition>(be_, default);
		IEnumerable<Condition> bg_ = context.Operators.Union<Condition>(bd_, bf_);
		IEnumerable<Condition> bh_ = context.Operators.Union<Condition>(bb_, bg_);
		IEnumerable<Condition> bi_ = this.DiagnosisInPatientHistory(bh_);
		bool? bj_ = context.Operators.Exists<Condition>(bi_);
		bool? bk_ = context.Operators.Or(a_, bj_);
		CqlValueSet bl_ = this.Chemotherapy();
		IEnumerable<Procedure> bm_ = context.Operators.RetrieveByValueSet<Procedure>(bl_, default);
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
		IEnumerable<ServiceRequest> b_ = context.Operators.RetrieveByValueSet<ServiceRequest>(a_, default);
		IEnumerable<ServiceRequest> c_ = Status_1_6_000.Completed_or_Ongoing_Service_Request(b_);
		bool? d_(ServiceRequest DXA)
		{
			CqlInterval<CqlDateTime> h_ = this.Measurement_Period();
			FhirDateTime i_ = DXA?.AuthoredOnElement;
			CqlDateTime j_ = context.Operators.Convert<CqlDateTime>(i_);
			CqlInterval<CqlDateTime> k_ = QICoreCommon_2_0_000.ToInterval(j_ as object);
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
		IEnumerable<Observation> c_ = context.Operators.RetrieveByCodes<Observation>(b_, default);
		IEnumerable<Observation> d_ = Status_1_6_000.Final_Survey_Observation(c_);
		bool? e_(Observation FRAX)
		{
			DataType ad_ = FRAX?.Value;
			object ae_ = FHIRHelpers_4_3_000.ToValue(ad_);
			CqlQuantity af_ = ae_ switch { null => null , CqlQuantity a => a/* , CqlConcept => ???, bool => ???, CqlInterval<CqlQuantity> => ???, CqlRatio => ???, SampledData => ???, CqlTime => ???, CqlDateTime => ???, CqlInterval<CqlDateTime> => ??? */, _ => throw new System.Diagnostics.UnreachableException() };
			CqlQuantity ag_ = context.Operators.Quantity(8.4m, "%");
			bool? ah_ = context.Operators.GreaterOrEqual(af_, ag_);

			return ah_;
		};
		IEnumerable<Observation> f_ = context.Operators.Where<Observation>(d_, e_);
		CqlCode g_ = this.Osteoporosis_Risk_Assessment_Instrument();
		IEnumerable<CqlCode> h_ = context.Operators.ToList<CqlCode>(g_);
		IEnumerable<Observation> i_ = context.Operators.RetrieveByCodes<Observation>(h_, default);
		IEnumerable<Observation> j_ = Status_1_6_000.Final_Survey_Observation(i_);
		bool? k_(Observation ORAI)
		{
			DataType ai_ = ORAI?.Value;
			object aj_ = FHIRHelpers_4_3_000.ToValue(ai_);
			int? ak_ = aj_ switch { null => null , int b => context.Operators.ConvertStringToInteger(b)/* , CqlQuantity => ???, CqlConcept => ???, CqlInterval<CqlQuantity> => ???, CqlRatio => ???, SampledData => ???, CqlTime => ???, CqlDateTime => ???, CqlInterval<CqlDateTime> => ??? */, _ => throw new System.Diagnostics.UnreachableException() };
			bool? al_ = context.Operators.GreaterOrEqual(ak_, 9);

			return al_;
		};
		IEnumerable<Observation> l_ = context.Operators.Where<Observation>(j_, k_);
		IEnumerable<Observation> m_ = context.Operators.Union<Observation>(f_, l_);
		CqlCode n_ = this.Osteoporosis_Index_of_Risk_panel();
		IEnumerable<CqlCode> o_ = context.Operators.ToList<CqlCode>(n_);
		IEnumerable<Observation> p_ = context.Operators.RetrieveByCodes<Observation>(o_, default);
		IEnumerable<Observation> q_ = Status_1_6_000.Final_Survey_Observation(p_);
		bool? r_(Observation OSIRIS)
		{
			DataType am_ = OSIRIS?.Value;
			object an_ = FHIRHelpers_4_3_000.ToValue(am_);
			CqlQuantity ao_ = an_ switch { null => null , CqlQuantity c => c/* , CqlConcept => ???, bool => ???, CqlInterval<CqlQuantity> => ???, CqlRatio => ???, SampledData => ???, CqlTime => ???, CqlDateTime => ???, CqlInterval<CqlDateTime> => ??? */, _ => throw new System.Diagnostics.UnreachableException() };
			CqlQuantity ap_ = context.Operators.ConvertDecimalToQuantity(1.0m);
			bool? aq_ = context.Operators.Less(ao_, ap_);

			return aq_;
		};
		IEnumerable<Observation> s_ = context.Operators.Where<Observation>(q_, r_);
		CqlCode t_ = this.Osteoporosis_Self_Assessment_Tool();
		IEnumerable<CqlCode> u_ = context.Operators.ToList<CqlCode>(t_);
		IEnumerable<Observation> v_ = context.Operators.RetrieveByCodes<Observation>(u_, default);
		IEnumerable<Observation> w_ = Status_1_6_000.Final_Survey_Observation(v_);
		bool? x_(Observation OST)
		{
			DataType ar_ = OST?.Value;
			object as_ = FHIRHelpers_4_3_000.ToValue(ar_);
			CqlQuantity at_ = as_ switch { null => null , CqlQuantity d => d/* , CqlConcept => ???, bool => ???, CqlInterval<CqlQuantity> => ???, CqlRatio => ???, SampledData => ???, CqlTime => ???, CqlDateTime => ???, CqlInterval<CqlDateTime> => ??? */, _ => throw new System.Diagnostics.UnreachableException() };
			CqlQuantity au_ = context.Operators.ConvertDecimalToQuantity(2.0m);
			bool? av_ = context.Operators.Less(at_, au_);

			return av_;
		};
		IEnumerable<Observation> y_ = context.Operators.Where<Observation>(w_, x_);
		IEnumerable<Observation> z_ = context.Operators.Union<Observation>(s_, y_);
		IEnumerable<Observation> aa_ = context.Operators.Union<Observation>(m_, z_);
		bool? ab_(Observation RiskAssessment)
		{
			DataType aw_ = RiskAssessment?.Effective;
			object ax_ = FHIRHelpers_4_3_000.ToValue(aw_);
			CqlInterval<CqlDateTime> ay_ = QICoreCommon_2_0_000.ToInterval(ax_);
			CqlDateTime az_ = context.Operators.Start(ay_);
			IEnumerable<ServiceRequest> ba_ = this.DXA_Scan_Order_During_Measurement_Period();
			ServiceRequest bb_ = context.Operators.First<ServiceRequest>(ba_);
			FhirDateTime bc_ = bb_?.AuthoredOnElement;
			CqlDateTime bd_ = context.Operators.Convert<CqlDateTime>(bc_);
			bool? be_ = context.Operators.Before(az_, bd_, default);

			return be_;
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
				CqlConcept n_ = FHIRHelpers_4_3_000.ToConcept(@this);

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

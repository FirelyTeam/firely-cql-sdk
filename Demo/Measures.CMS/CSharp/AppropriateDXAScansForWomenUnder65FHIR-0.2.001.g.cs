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

[System.CodeDom.Compiler.GeneratedCode(".NET Code Generation", "3.0.0.0")]
[CqlLibrary("AppropriateDXAScansForWomenUnder65FHIR", "0.2.001")]
public partial class AppropriateDXAScansForWomenUnder65FHIR_0_2_001 : ILibrary, ISingleton<AppropriateDXAScansForWomenUnder65FHIR_0_2_001>
{
    private AppropriateDXAScansForWomenUnder65FHIR_0_2_001() {}

    public static AppropriateDXAScansForWomenUnder65FHIR_0_2_001 Instance { get; } = new();

    #region ILibrary Implementation

    public string Name => "AppropriateDXAScansForWomenUnder65FHIR";
    public string Version => "0.2.001";
    public ILibrary[] Dependencies => [FHIRHelpers_4_4_000.Instance, SupplementalDataElements_3_5_000.Instance, QICoreCommon_2_1_000.Instance, Status_1_8_000.Instance, CumulativeMedicationDuration_4_1_000.Instance, Hospice_6_12_000.Instance];

    #endregion ILibrary Implementation

    #region ValueSets

    [CqlValueSetDefinition("Amenorrhea", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.1022", valueSetVersion: null)]
    public CqlValueSet Amenorrhea(CqlContext _) => _Amenorrhea;
    private static readonly CqlValueSet _Amenorrhea = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.1022", null);

    [CqlValueSetDefinition("Ankylosing Spondylitis", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.113.12.1045", valueSetVersion: null)]
    public CqlValueSet Ankylosing_Spondylitis(CqlContext _) => _Ankylosing_Spondylitis;
    private static readonly CqlValueSet _Ankylosing_Spondylitis = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.113.12.1045", null);

    [CqlValueSetDefinition("Aromatase Inhibitors", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.196.12.1265", valueSetVersion: null)]
    public CqlValueSet Aromatase_Inhibitors(CqlContext _) => _Aromatase_Inhibitors;
    private static readonly CqlValueSet _Aromatase_Inhibitors = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.196.12.1265", null);

    [CqlValueSetDefinition("Bilateral Oophorectomy", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.471", valueSetVersion: null)]
    public CqlValueSet Bilateral_Oophorectomy(CqlContext _) => _Bilateral_Oophorectomy;
    private static readonly CqlValueSet _Bilateral_Oophorectomy = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.471", null);

    [CqlValueSetDefinition("Bone Marrow Transplant", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.666.5.336", valueSetVersion: null)]
    public CqlValueSet Bone_Marrow_Transplant(CqlContext _) => _Bone_Marrow_Transplant;
    private static readonly CqlValueSet _Bone_Marrow_Transplant = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.666.5.336", null);

    [CqlValueSetDefinition("Chemotherapy", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.485", valueSetVersion: null)]
    public CqlValueSet Chemotherapy(CqlContext _) => _Chemotherapy;
    private static readonly CqlValueSet _Chemotherapy = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.485", null);

    [CqlValueSetDefinition("Chronic Liver Disease", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.199.12.1035", valueSetVersion: null)]
    public CqlValueSet Chronic_Liver_Disease(CqlContext _) => _Chronic_Liver_Disease;
    private static readonly CqlValueSet _Chronic_Liver_Disease = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.199.12.1035", null);

    [CqlValueSetDefinition("Chronic Malnutrition", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.199.12.1036", valueSetVersion: null)]
    public CqlValueSet Chronic_Malnutrition(CqlContext _) => _Chronic_Malnutrition;
    private static readonly CqlValueSet _Chronic_Malnutrition = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.199.12.1036", null);

    [CqlValueSetDefinition("Cushings Syndrome", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.117.12.1009", valueSetVersion: null)]
    public CqlValueSet Cushings_Syndrome(CqlContext _) => _Cushings_Syndrome;
    private static readonly CqlValueSet _Cushings_Syndrome = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.117.12.1009", null);

    [CqlValueSetDefinition("DXA (Dual energy Xray Absorptiometry) Scan", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.113.12.1051", valueSetVersion: null)]
    public CqlValueSet DXA__Dual_energy_Xray_Absorptiometry__Scan(CqlContext _) => _DXA__Dual_energy_Xray_Absorptiometry__Scan;
    private static readonly CqlValueSet _DXA__Dual_energy_Xray_Absorptiometry__Scan = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.113.12.1051", null);

    [CqlValueSetDefinition("Eating Disorders", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.1039", valueSetVersion: null)]
    public CqlValueSet Eating_Disorders(CqlContext _) => _Eating_Disorders;
    private static readonly CqlValueSet _Eating_Disorders = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.1039", null);

    [CqlValueSetDefinition("Ehlers Danlos Syndrome", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.113.12.1047", valueSetVersion: null)]
    public CqlValueSet Ehlers_Danlos_Syndrome(CqlContext _) => _Ehlers_Danlos_Syndrome;
    private static readonly CqlValueSet _Ehlers_Danlos_Syndrome = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.113.12.1047", null);

    [CqlValueSetDefinition("End Stage Renal Disease", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.353", valueSetVersion: null)]
    public CqlValueSet End_Stage_Renal_Disease(CqlContext _) => _End_Stage_Renal_Disease;
    private static readonly CqlValueSet _End_Stage_Renal_Disease = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.353", null);

    [CqlValueSetDefinition("Evidence of Bilateral Oophorectomy", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.1048", valueSetVersion: null)]
    public CqlValueSet Evidence_of_Bilateral_Oophorectomy(CqlContext _) => _Evidence_of_Bilateral_Oophorectomy;
    private static readonly CqlValueSet _Evidence_of_Bilateral_Oophorectomy = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.1048", null);

    [CqlValueSetDefinition("Gastric Bypass Surgery", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.198.12.1050", valueSetVersion: null)]
    public CqlValueSet Gastric_Bypass_Surgery(CqlContext _) => _Gastric_Bypass_Surgery;
    private static readonly CqlValueSet _Gastric_Bypass_Surgery = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.198.12.1050", null);

    [CqlValueSetDefinition("Glucocorticoids (oral only)", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.196.12.1266", valueSetVersion: null)]
    public CqlValueSet Glucocorticoids__oral_only_(CqlContext _) => _Glucocorticoids__oral_only_;
    private static readonly CqlValueSet _Glucocorticoids__oral_only_ = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.196.12.1266", null);

    [CqlValueSetDefinition("History of hip fracture in parent", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.113.12.1040", valueSetVersion: null)]
    public CqlValueSet History_of_hip_fracture_in_parent(CqlContext _) => _History_of_hip_fracture_in_parent;
    private static readonly CqlValueSet _History_of_hip_fracture_in_parent = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.113.12.1040", null);

    [CqlValueSetDefinition("Hyperparathyroidism", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.117.12.1016", valueSetVersion: null)]
    public CqlValueSet Hyperparathyroidism(CqlContext _) => _Hyperparathyroidism;
    private static readonly CqlValueSet _Hyperparathyroidism = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.117.12.1016", null);

    [CqlValueSetDefinition("Hyperthyroidism", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.117.12.1015", valueSetVersion: null)]
    public CqlValueSet Hyperthyroidism(CqlContext _) => _Hyperthyroidism;
    private static readonly CqlValueSet _Hyperthyroidism = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.117.12.1015", null);

    [CqlValueSetDefinition("Kidney Transplant", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.109.12.1012", valueSetVersion: null)]
    public CqlValueSet Kidney_Transplant(CqlContext _) => _Kidney_Transplant;
    private static readonly CqlValueSet _Kidney_Transplant = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.109.12.1012", null);

    [CqlValueSetDefinition("Lupus", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.117.12.1010", valueSetVersion: null)]
    public CqlValueSet Lupus(CqlContext _) => _Lupus;
    private static readonly CqlValueSet _Lupus = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.117.12.1010", null);

    [CqlValueSetDefinition("Major Transplant", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.198.12.1075", valueSetVersion: null)]
    public CqlValueSet Major_Transplant(CqlContext _) => _Major_Transplant;
    private static readonly CqlValueSet _Major_Transplant = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.198.12.1075", null);

    [CqlValueSetDefinition("Malabsorption Syndromes", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.199.12.1050", valueSetVersion: null)]
    public CqlValueSet Malabsorption_Syndromes(CqlContext _) => _Malabsorption_Syndromes;
    private static readonly CqlValueSet _Malabsorption_Syndromes = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.199.12.1050", null);

    [CqlValueSetDefinition("Marfan's Syndrome", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.113.12.1048", valueSetVersion: null)]
    public CqlValueSet Marfans_Syndrome(CqlContext _) => _Marfans_Syndrome;
    private static readonly CqlValueSet _Marfans_Syndrome = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.113.12.1048", null);

    [CqlValueSetDefinition("Multiple Myeloma", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.1011", valueSetVersion: null)]
    public CqlValueSet Multiple_Myeloma(CqlContext _) => _Multiple_Myeloma;
    private static readonly CqlValueSet _Multiple_Myeloma = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.1011", null);

    [CqlValueSetDefinition("Office Visit", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1001", valueSetVersion: null)]
    public CqlValueSet Office_Visit(CqlContext _) => _Office_Visit;
    private static readonly CqlValueSet _Office_Visit = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1001", null);

    [CqlValueSetDefinition("Osteogenesis Imperfecta", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.113.12.1044", valueSetVersion: null)]
    public CqlValueSet Osteogenesis_Imperfecta(CqlContext _) => _Osteogenesis_Imperfecta;
    private static readonly CqlValueSet _Osteogenesis_Imperfecta = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.113.12.1044", null);

    [CqlValueSetDefinition("Osteopenia", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.113.12.1049", valueSetVersion: null)]
    public CqlValueSet Osteopenia(CqlContext _) => _Osteopenia;
    private static readonly CqlValueSet _Osteopenia = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.113.12.1049", null);

    [CqlValueSetDefinition("Osteoporosis Without Current Fracture", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.113.12.1038", valueSetVersion: null)]
    public CqlValueSet Osteoporosis_Without_Current_Fracture(CqlContext _) => _Osteoporosis_Without_Current_Fracture;
    private static readonly CqlValueSet _Osteoporosis_Without_Current_Fracture = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.113.12.1038", null);

    [CqlValueSetDefinition("Osteoporosis With Current Fracture", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.113.12.1050", valueSetVersion: null)]
    public CqlValueSet Osteoporosis_With_Current_Fracture(CqlContext _) => _Osteoporosis_With_Current_Fracture;
    private static readonly CqlValueSet _Osteoporosis_With_Current_Fracture = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.113.12.1050", null);

    [CqlValueSetDefinition("Outpatient Consultation", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1008", valueSetVersion: null)]
    public CqlValueSet Outpatient_Consultation(CqlContext _) => _Outpatient_Consultation;
    private static readonly CqlValueSet _Outpatient_Consultation = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1008", null);

    [CqlValueSetDefinition("Premature Menopause", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.1013", valueSetVersion: null)]
    public CqlValueSet Premature_Menopause(CqlContext _) => _Premature_Menopause;
    private static readonly CqlValueSet _Premature_Menopause = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.1013", null);

    [CqlValueSetDefinition("Preventive Care Services Established Office Visit, 18 and Up", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1025", valueSetVersion: null)]
    public CqlValueSet Preventive_Care_Services_Established_Office_Visit__18_and_Up(CqlContext _) => _Preventive_Care_Services_Established_Office_Visit__18_and_Up;
    private static readonly CqlValueSet _Preventive_Care_Services_Established_Office_Visit__18_and_Up = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1025", null);

    [CqlValueSetDefinition("Preventive Care Services Initial Office Visit, 18 and Up", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1023", valueSetVersion: null)]
    public CqlValueSet Preventive_Care_Services_Initial_Office_Visit__18_and_Up(CqlContext _) => _Preventive_Care_Services_Initial_Office_Visit__18_and_Up;
    private static readonly CqlValueSet _Preventive_Care_Services_Initial_Office_Visit__18_and_Up = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1023", null);

    [CqlValueSetDefinition("Psoriatic Arthritis", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.113.12.1046", valueSetVersion: null)]
    public CqlValueSet Psoriatic_Arthritis(CqlContext _) => _Psoriatic_Arthritis;
    private static readonly CqlValueSet _Psoriatic_Arthritis = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.113.12.1046", null);

    [CqlValueSetDefinition("Rheumatoid Arthritis", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.113.12.1005", valueSetVersion: null)]
    public CqlValueSet Rheumatoid_Arthritis(CqlContext _) => _Rheumatoid_Arthritis;
    private static readonly CqlValueSet _Rheumatoid_Arthritis = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.113.12.1005", null);

    [CqlValueSetDefinition("Telephone Visits", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1080", valueSetVersion: null)]
    public CqlValueSet Telephone_Visits(CqlContext _) => _Telephone_Visits;
    private static readonly CqlValueSet _Telephone_Visits = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1080", null);

    [CqlValueSetDefinition("Type 1 Diabetes", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.103.12.1020", valueSetVersion: null)]
    public CqlValueSet Type_1_Diabetes(CqlContext _) => _Type_1_Diabetes;
    private static readonly CqlValueSet _Type_1_Diabetes = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.103.12.1020", null);

    [CqlValueSetDefinition("Unilateral Oophorectomy Left", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.1028", valueSetVersion: null)]
    public CqlValueSet Unilateral_Oophorectomy_Left(CqlContext _) => _Unilateral_Oophorectomy_Left;
    private static readonly CqlValueSet _Unilateral_Oophorectomy_Left = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.1028", null);

    [CqlValueSetDefinition("Unilateral Oophorectomy Right", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.1032", valueSetVersion: null)]
    public CqlValueSet Unilateral_Oophorectomy_Right(CqlContext _) => _Unilateral_Oophorectomy_Right;
    private static readonly CqlValueSet _Unilateral_Oophorectomy_Right = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.1032", null);

    [CqlValueSetDefinition("Unilateral Oophorectomy, Unspecified Laterality", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.1035", valueSetVersion: null)]
    public CqlValueSet Unilateral_Oophorectomy__Unspecified_Laterality(CqlContext _) => _Unilateral_Oophorectomy__Unspecified_Laterality;
    private static readonly CqlValueSet _Unilateral_Oophorectomy__Unspecified_Laterality = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.1035", null);

    [CqlValueSetDefinition("Virtual Encounter", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1089", valueSetVersion: null)]
    public CqlValueSet Virtual_Encounter(CqlContext _) => _Virtual_Encounter;
    private static readonly CqlValueSet _Virtual_Encounter = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1089", null);

    #endregion ValueSets

    #region Codes

    [CqlCodeDefinition("Alcoholic drinks per day", codeId: "74013-4", codeSystem: "http://loinc.org")]
    public CqlCode Alcoholic_drinks_per_day(CqlContext _) => _Alcoholic_drinks_per_day;
    private static readonly CqlCode _Alcoholic_drinks_per_day = new CqlCode("74013-4", "http://loinc.org");

    [CqlCodeDefinition("Body mass index (BMI) [Ratio]", codeId: "39156-5", codeSystem: "http://loinc.org")]
    public CqlCode Body_mass_index__BMI___Ratio_(CqlContext _) => _Body_mass_index__BMI___Ratio_;
    private static readonly CqlCode _Body_mass_index__BMI___Ratio_ = new CqlCode("39156-5", "http://loinc.org");

    [CqlCodeDefinition("Female", codeId: "F", codeSystem: "http://terminology.hl7.org/CodeSystem/v3-AdministrativeGender")]
    public CqlCode Female(CqlContext _) => _Female;
    private static readonly CqlCode _Female = new CqlCode("F", "http://terminology.hl7.org/CodeSystem/v3-AdministrativeGender");

    [CqlCodeDefinition("Left (qualifier value)", codeId: "7771000", codeSystem: "http://snomed.info/sct")]
    public CqlCode Left__qualifier_value_(CqlContext _) => _Left__qualifier_value_;
    private static readonly CqlCode _Left__qualifier_value_ = new CqlCode("7771000", "http://snomed.info/sct");

    [CqlCodeDefinition("Major osteoporotic fracture 10-year probability [Likelihood] Fracture Risk Assessment", codeId: "90265-0", codeSystem: "http://loinc.org")]
    public CqlCode Major_osteoporotic_fracture_10_year_probability__Likelihood__Fracture_Risk_Assessment(CqlContext _) => _Major_osteoporotic_fracture_10_year_probability__Likelihood__Fracture_Risk_Assessment;
    private static readonly CqlCode _Major_osteoporotic_fracture_10_year_probability__Likelihood__Fracture_Risk_Assessment = new CqlCode("90265-0", "http://loinc.org");

    [CqlCodeDefinition("Osteoporosis Index of Risk panel", codeId: "98133-2", codeSystem: "http://loinc.org")]
    public CqlCode Osteoporosis_Index_of_Risk_panel(CqlContext _) => _Osteoporosis_Index_of_Risk_panel;
    private static readonly CqlCode _Osteoporosis_Index_of_Risk_panel = new CqlCode("98133-2", "http://loinc.org");

    [CqlCodeDefinition("Osteoporosis Risk Assessment Instrument", codeId: "98139-9", codeSystem: "http://loinc.org")]
    public CqlCode Osteoporosis_Risk_Assessment_Instrument(CqlContext _) => _Osteoporosis_Risk_Assessment_Instrument;
    private static readonly CqlCode _Osteoporosis_Risk_Assessment_Instrument = new CqlCode("98139-9", "http://loinc.org");

    [CqlCodeDefinition("Osteoporosis Self-Assessment Tool", codeId: "98146-4", codeSystem: "http://loinc.org")]
    public CqlCode Osteoporosis_Self_Assessment_Tool(CqlContext _) => _Osteoporosis_Self_Assessment_Tool;
    private static readonly CqlCode _Osteoporosis_Self_Assessment_Tool = new CqlCode("98146-4", "http://loinc.org");

    [CqlCodeDefinition("Right (qualifier value)", codeId: "24028007", codeSystem: "http://snomed.info/sct")]
    public CqlCode Right__qualifier_value_(CqlContext _) => _Right__qualifier_value_;
    private static readonly CqlCode _Right__qualifier_value_ = new CqlCode("24028007", "http://snomed.info/sct");

    [CqlCodeDefinition("Unlisted preventive medicine service", codeId: "99429", codeSystem: "http://www.ama-assn.org/go/cpt")]
    public CqlCode Unlisted_preventive_medicine_service(CqlContext _) => _Unlisted_preventive_medicine_service;
    private static readonly CqlCode _Unlisted_preventive_medicine_service = new CqlCode("99429", "http://www.ama-assn.org/go/cpt");

    #endregion Codes

    #region CodeSystems

    [CqlCodeSystemDefinition("LOINC")]
    public CqlCodeSystem LOINC(CqlContext _) => _LOINC;
    private static readonly CqlCodeSystem _LOINC =
      new CqlCodeSystem("http://loinc.org", null, [
          _Alcoholic_drinks_per_day,
          _Body_mass_index__BMI___Ratio_,
          _Major_osteoporotic_fracture_10_year_probability__Likelihood__Fracture_Risk_Assessment,
          _Osteoporosis_Index_of_Risk_panel,
          _Osteoporosis_Risk_Assessment_Instrument,
          _Osteoporosis_Self_Assessment_Tool]);

    [CqlCodeSystemDefinition("AdministrativeGender")]
    public CqlCodeSystem AdministrativeGender(CqlContext _) => _AdministrativeGender;
    private static readonly CqlCodeSystem _AdministrativeGender =
      new CqlCodeSystem("http://terminology.hl7.org/CodeSystem/v3-AdministrativeGender", null, [
          _Female]);

    [CqlCodeSystemDefinition("SNOMEDCT")]
    public CqlCodeSystem SNOMEDCT(CqlContext _) => _SNOMEDCT;
    private static readonly CqlCodeSystem _SNOMEDCT =
      new CqlCodeSystem("http://snomed.info/sct", null, [
          _Left__qualifier_value_,
          _Right__qualifier_value_]);

    [CqlCodeSystemDefinition("CPT")]
    public CqlCodeSystem CPT(CqlContext _) => _CPT;
    private static readonly CqlCodeSystem _CPT =
      new CqlCodeSystem("http://www.ama-assn.org/go/cpt", null, [
          _Unlisted_preventive_medicine_service]);

    #endregion CodeSystems

    #region Parameters

    [CqlParameterDefinition("Measurement Period")]
    public CqlInterval<CqlDateTime> Measurement_Period(CqlContext context)
    {
        CqlDateTime uzzzzzzzzzzzzzzv_ = context.Operators.DateTime(2025, 1, 1, 0, 0, 0, 0, 0.0m);
        CqlDateTime uzzzzzzzzzzzzzzw_ = context.Operators.DateTime(2025, 12, 31, 23, 59, 59, 999, 0.0m);
        CqlInterval<CqlDateTime> uzzzzzzzzzzzzzzx_ = context.Operators.Interval(uzzzzzzzzzzzzzzv_, uzzzzzzzzzzzzzzw_, true, true);
        object uzzzzzzzzzzzzzzy_ = context.ResolveParameter("AppropriateDXAScansForWomenUnder65FHIR-0.2.001", "Measurement Period", uzzzzzzzzzzzzzzx_);

        return (CqlInterval<CqlDateTime>)uzzzzzzzzzzzzzzy_;
    }


    #endregion Parameters

    #region Expressions

    [CqlExpressionDefinition("Patient")]
    public Patient Patient(CqlContext context)
    {
        IEnumerable<Patient> uzzzzzzzzzzzzzzz_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-patient"));
        Patient vzzzzzzzzzzzzzza_ = context.Operators.SingletonFrom<Patient>(uzzzzzzzzzzzzzzz_);

        return vzzzzzzzzzzzzzza_;
    }


    [CqlExpressionDefinition("SDE Ethnicity")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Ethnicity(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? vzzzzzzzzzzzzzzb_ = SupplementalDataElements_3_5_000.Instance.SDE_Ethnicity(context);

        return vzzzzzzzzzzzzzzb_;
    }


    [CqlExpressionDefinition("SDE Payer")]
    public IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> SDE_Payer(CqlContext context)
    {
        IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> vzzzzzzzzzzzzzzc_ = SupplementalDataElements_3_5_000.Instance.SDE_Payer(context);

        return vzzzzzzzzzzzzzzc_;
    }


    [CqlExpressionDefinition("SDE Race")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Race(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? vzzzzzzzzzzzzzzd_ = SupplementalDataElements_3_5_000.Instance.SDE_Race(context);

        return vzzzzzzzzzzzzzzd_;
    }


    [CqlExpressionDefinition("SDE Sex")]
    public CqlCode SDE_Sex(CqlContext context)
    {
        CqlCode vzzzzzzzzzzzzzze_ = SupplementalDataElements_3_5_000.Instance.SDE_Sex(context);

        return vzzzzzzzzzzzzzze_;
    }


    [CqlExpressionDefinition("Qualifying Encounter")]
    public IEnumerable<Encounter> Qualifying_Encounter(CqlContext context)
    {
        CqlValueSet vzzzzzzzzzzzzzzf_ = this.Office_Visit(context);
        IEnumerable<Encounter> vzzzzzzzzzzzzzzg_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, vzzzzzzzzzzzzzzf_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        CqlValueSet vzzzzzzzzzzzzzzh_ = this.Preventive_Care_Services_Established_Office_Visit__18_and_Up(context);
        IEnumerable<Encounter> vzzzzzzzzzzzzzzi_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, vzzzzzzzzzzzzzzh_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> vzzzzzzzzzzzzzzj_ = context.Operators.Union<Encounter>(vzzzzzzzzzzzzzzg_, vzzzzzzzzzzzzzzi_);
        IEnumerable<Encounter> vzzzzzzzzzzzzzzk_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        bool? vzzzzzzzzzzzzzzl_(Encounter E)
        {
            List<CodeableConcept> wzzzzzzzzzzzzzzd_ = E?.Type;
            CqlConcept wzzzzzzzzzzzzzze_(CodeableConcept @this)
            {
                CqlConcept wzzzzzzzzzzzzzzj_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);

                return wzzzzzzzzzzzzzzj_;
            };
            IEnumerable<CqlConcept> wzzzzzzzzzzzzzzf_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)wzzzzzzzzzzzzzzd_, wzzzzzzzzzzzzzze_);
            bool? wzzzzzzzzzzzzzzg_(CqlConcept T)
            {
                CqlCode wzzzzzzzzzzzzzzk_ = this.Unlisted_preventive_medicine_service(context);
                CqlConcept wzzzzzzzzzzzzzzl_ = context.Operators.ConvertCodeToConcept(wzzzzzzzzzzzzzzk_);
                bool? wzzzzzzzzzzzzzzm_ = context.Operators.Equivalent(T, wzzzzzzzzzzzzzzl_);

                return wzzzzzzzzzzzzzzm_;
            };
            IEnumerable<CqlConcept> wzzzzzzzzzzzzzzh_ = context.Operators.Where<CqlConcept>(wzzzzzzzzzzzzzzf_, wzzzzzzzzzzzzzzg_);
            bool? wzzzzzzzzzzzzzzi_ = context.Operators.Exists<CqlConcept>(wzzzzzzzzzzzzzzh_);

            return wzzzzzzzzzzzzzzi_;
        };
        IEnumerable<Encounter> vzzzzzzzzzzzzzzm_ = context.Operators.Where<Encounter>(vzzzzzzzzzzzzzzk_, vzzzzzzzzzzzzzzl_);
        CqlValueSet vzzzzzzzzzzzzzzn_ = this.Preventive_Care_Services_Initial_Office_Visit__18_and_Up(context);
        IEnumerable<Encounter> vzzzzzzzzzzzzzzo_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, vzzzzzzzzzzzzzzn_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> vzzzzzzzzzzzzzzp_ = context.Operators.Union<Encounter>(vzzzzzzzzzzzzzzm_, vzzzzzzzzzzzzzzo_);
        IEnumerable<Encounter> vzzzzzzzzzzzzzzq_ = context.Operators.Union<Encounter>(vzzzzzzzzzzzzzzj_, vzzzzzzzzzzzzzzp_);
        CqlValueSet vzzzzzzzzzzzzzzr_ = this.Outpatient_Consultation(context);
        IEnumerable<Encounter> vzzzzzzzzzzzzzzs_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, vzzzzzzzzzzzzzzr_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        CqlValueSet vzzzzzzzzzzzzzzt_ = this.Virtual_Encounter(context);
        IEnumerable<Encounter> vzzzzzzzzzzzzzzu_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, vzzzzzzzzzzzzzzt_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> vzzzzzzzzzzzzzzv_ = context.Operators.Union<Encounter>(vzzzzzzzzzzzzzzs_, vzzzzzzzzzzzzzzu_);
        IEnumerable<Encounter> vzzzzzzzzzzzzzzw_ = context.Operators.Union<Encounter>(vzzzzzzzzzzzzzzq_, vzzzzzzzzzzzzzzv_);
        CqlValueSet vzzzzzzzzzzzzzzx_ = this.Telephone_Visits(context);
        IEnumerable<Encounter> vzzzzzzzzzzzzzzy_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, vzzzzzzzzzzzzzzx_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> vzzzzzzzzzzzzzzz_ = context.Operators.Union<Encounter>(vzzzzzzzzzzzzzzw_, vzzzzzzzzzzzzzzy_);
        IEnumerable<Encounter> wzzzzzzzzzzzzzza_ = Status_1_8_000.Instance.isEncounterPerformed(context, vzzzzzzzzzzzzzzz_);
        bool? wzzzzzzzzzzzzzzb_(Encounter ValidEncounters)
        {
            CqlInterval<CqlDateTime> wzzzzzzzzzzzzzzn_ = this.Measurement_Period(context);
            Period wzzzzzzzzzzzzzzo_ = ValidEncounters?.Period;
            CqlInterval<CqlDateTime> wzzzzzzzzzzzzzzp_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, wzzzzzzzzzzzzzzo_);
            CqlInterval<CqlDateTime> wzzzzzzzzzzzzzzq_ = QICoreCommon_2_1_000.Instance.toInterval(context, wzzzzzzzzzzzzzzp_ as object);
            bool? wzzzzzzzzzzzzzzr_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(wzzzzzzzzzzzzzzn_, wzzzzzzzzzzzzzzq_, "day");

            return wzzzzzzzzzzzzzzr_;
        };
        IEnumerable<Encounter> wzzzzzzzzzzzzzzc_ = context.Operators.Where<Encounter>(wzzzzzzzzzzzzzza_, wzzzzzzzzzzzzzzb_);

        return wzzzzzzzzzzzzzzc_;
    }


    [CqlExpressionDefinition("Initial Population")]
    public bool? Initial_Population(CqlContext context)
    {
        Patient wzzzzzzzzzzzzzzs_ = this.Patient(context);
        Date wzzzzzzzzzzzzzzt_ = wzzzzzzzzzzzzzzs_?.BirthDateElement;
        string wzzzzzzzzzzzzzzu_ = wzzzzzzzzzzzzzzt_?.Value;
        CqlDate wzzzzzzzzzzzzzzv_ = context.Operators.ConvertStringToDate(wzzzzzzzzzzzzzzu_);
        CqlInterval<CqlDateTime> wzzzzzzzzzzzzzzw_ = this.Measurement_Period(context);
        CqlDateTime wzzzzzzzzzzzzzzx_ = context.Operators.Start(wzzzzzzzzzzzzzzw_);
        CqlDate wzzzzzzzzzzzzzzy_ = context.Operators.DateFrom(wzzzzzzzzzzzzzzx_);
        int? wzzzzzzzzzzzzzzz_ = context.Operators.CalculateAgeAt(wzzzzzzzzzzzzzzv_, wzzzzzzzzzzzzzzy_, "year");
        CqlInterval<int?> xzzzzzzzzzzzzzza_ = context.Operators.Interval(50, 63, true, true);
        bool? xzzzzzzzzzzzzzzb_ = context.Operators.In<int?>(wzzzzzzzzzzzzzzz_, xzzzzzzzzzzzzzza_, default);
        Code<AdministrativeGender> xzzzzzzzzzzzzzzd_ = wzzzzzzzzzzzzzzs_?.GenderElement;
        AdministrativeGender? xzzzzzzzzzzzzzze_ = xzzzzzzzzzzzzzzd_?.Value;
        string xzzzzzzzzzzzzzzf_ = context.Operators.Convert<string>(xzzzzzzzzzzzzzze_);
        bool? xzzzzzzzzzzzzzzg_ = context.Operators.Equal(xzzzzzzzzzzzzzzf_, "female");
        bool? xzzzzzzzzzzzzzzh_ = context.Operators.And(xzzzzzzzzzzzzzzb_, xzzzzzzzzzzzzzzg_);
        IEnumerable<Encounter> xzzzzzzzzzzzzzzi_ = this.Qualifying_Encounter(context);
        bool? xzzzzzzzzzzzzzzj_ = context.Operators.Exists<Encounter>(xzzzzzzzzzzzzzzi_);
        bool? xzzzzzzzzzzzzzzk_ = context.Operators.And(xzzzzzzzzzzzzzzh_, xzzzzzzzzzzzzzzj_);

        return xzzzzzzzzzzzzzzk_;
    }


    [CqlExpressionDefinition("Denominator")]
    public bool? Denominator(CqlContext context)
    {
        bool? xzzzzzzzzzzzzzzl_ = this.Initial_Population(context);

        return xzzzzzzzzzzzzzzl_;
    }


    [CqlExpressionDefinition("First BMI in Measurement Period")]
    public Observation First_BMI_in_Measurement_Period(CqlContext context)
    {
        IEnumerable<Observation> xzzzzzzzzzzzzzzm_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/StructureDefinition/bmi"));
        IEnumerable<Observation> xzzzzzzzzzzzzzzn_ = Status_1_8_000.Instance.isObservationBMI(context, xzzzzzzzzzzzzzzm_);
        bool? xzzzzzzzzzzzzzzo_(Observation BMIRatio)
        {
            CqlInterval<CqlDateTime> xzzzzzzzzzzzzzzt_ = this.Measurement_Period(context);
            DataType xzzzzzzzzzzzzzzu_ = BMIRatio?.Effective;
            object xzzzzzzzzzzzzzzv_ = FHIRHelpers_4_4_000.Instance.ToValue(context, xzzzzzzzzzzzzzzu_);
            CqlInterval<CqlDateTime> xzzzzzzzzzzzzzzw_ = QICoreCommon_2_1_000.Instance.toInterval(context, xzzzzzzzzzzzzzzv_);
            bool? xzzzzzzzzzzzzzzx_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(xzzzzzzzzzzzzzzt_, xzzzzzzzzzzzzzzw_, default);
            DataType xzzzzzzzzzzzzzzy_ = BMIRatio?.Value;
            CqlQuantity xzzzzzzzzzzzzzzz_ = FHIRHelpers_4_4_000.Instance.ToQuantity(context, xzzzzzzzzzzzzzzy_ as Quantity);
            bool? yzzzzzzzzzzzzzza_ = context.Operators.Not((bool?)((xzzzzzzzzzzzzzzz_ as CqlQuantity) is null));
            bool? yzzzzzzzzzzzzzzb_ = context.Operators.And(xzzzzzzzzzzzzzzx_, yzzzzzzzzzzzzzza_);

            return yzzzzzzzzzzzzzzb_;
        };
        IEnumerable<Observation> xzzzzzzzzzzzzzzp_ = context.Operators.Where<Observation>(xzzzzzzzzzzzzzzn_, xzzzzzzzzzzzzzzo_);
        object xzzzzzzzzzzzzzzq_(Observation @this)
        {
            DataType yzzzzzzzzzzzzzzc_ = @this?.Effective;
            object yzzzzzzzzzzzzzzd_ = FHIRHelpers_4_4_000.Instance.ToValue(context, yzzzzzzzzzzzzzzc_);
            CqlInterval<CqlDateTime> yzzzzzzzzzzzzzze_ = QICoreCommon_2_1_000.Instance.toInterval(context, yzzzzzzzzzzzzzzd_);
            CqlDateTime yzzzzzzzzzzzzzzf_ = context.Operators.Start(yzzzzzzzzzzzzzze_);

            return yzzzzzzzzzzzzzzf_;
        };
        IEnumerable<Observation> xzzzzzzzzzzzzzzr_ = context.Operators.SortBy<Observation>(xzzzzzzzzzzzzzzp_, xzzzzzzzzzzzzzzq_, System.ComponentModel.ListSortDirection.Ascending);
        Observation xzzzzzzzzzzzzzzs_ = context.Operators.First<Observation>(xzzzzzzzzzzzzzzr_);

        return xzzzzzzzzzzzzzzs_;
    }


    [CqlExpressionDefinition("First BMI in Measurement Period Less Than or Equal to 20 kg m2")]
    public Observation First_BMI_in_Measurement_Period_Less_Than_or_Equal_to_20_kg_m2(CqlContext context)
    {
        Observation yzzzzzzzzzzzzzzg_ = this.First_BMI_in_Measurement_Period(context);
        Observation[] yzzzzzzzzzzzzzzh_ = [
            yzzzzzzzzzzzzzzg_,
        ];
        bool? yzzzzzzzzzzzzzzi_(Observation FirstBMI)
        {
            DataType yzzzzzzzzzzzzzzl_ = FirstBMI?.Value;
            CqlQuantity yzzzzzzzzzzzzzzm_ = FHIRHelpers_4_4_000.Instance.ToQuantity(context, yzzzzzzzzzzzzzzl_ as Quantity);
            CqlQuantity yzzzzzzzzzzzzzzn_ = context.Operators.Quantity(20m, "kg/m2");
            bool? yzzzzzzzzzzzzzzo_ = context.Operators.LessOrEqual(yzzzzzzzzzzzzzzm_ as CqlQuantity, yzzzzzzzzzzzzzzn_);

            return yzzzzzzzzzzzzzzo_;
        };
        IEnumerable<Observation> yzzzzzzzzzzzzzzj_ = context.Operators.Where<Observation>((IEnumerable<Observation>)yzzzzzzzzzzzzzzh_, yzzzzzzzzzzzzzzi_);
        Observation yzzzzzzzzzzzzzzk_ = context.Operators.SingletonFrom<Observation>(yzzzzzzzzzzzzzzj_);

        return yzzzzzzzzzzzzzzk_;
    }


    [CqlExpressionDefinition("First Average Number of Drinks Assessments Indicating More Than Two Per Day")]
    public Observation First_Average_Number_of_Drinks_Assessments_Indicating_More_Than_Two_Per_Day(CqlContext context)
    {
        CqlCode yzzzzzzzzzzzzzzp_ = this.Alcoholic_drinks_per_day(context);
        IEnumerable<CqlCode> yzzzzzzzzzzzzzzq_ = context.Operators.ToList<CqlCode>(yzzzzzzzzzzzzzzp_);
        IEnumerable<Observation> yzzzzzzzzzzzzzzr_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, yzzzzzzzzzzzzzzq_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
        IEnumerable<Observation> yzzzzzzzzzzzzzzs_ = Status_1_8_000.Instance.isAssessmentPerformed(context, yzzzzzzzzzzzzzzr_);
        bool? yzzzzzzzzzzzzzzt_(Observation AverageDrinks)
        {
            DataType yzzzzzzzzzzzzzzy_ = AverageDrinks?.Effective;
            object yzzzzzzzzzzzzzzz_ = FHIRHelpers_4_4_000.Instance.ToValue(context, yzzzzzzzzzzzzzzy_);
            CqlInterval<CqlDateTime> zzzzzzzzzzzzzzza_ = QICoreCommon_2_1_000.Instance.toInterval(context, yzzzzzzzzzzzzzzz_);
            CqlDateTime zzzzzzzzzzzzzzzb_ = context.Operators.Start(zzzzzzzzzzzzzzza_);
            CqlInterval<CqlDateTime> zzzzzzzzzzzzzzzc_ = this.Measurement_Period(context);
            bool? zzzzzzzzzzzzzzzd_ = context.Operators.In<CqlDateTime>(zzzzzzzzzzzzzzzb_, zzzzzzzzzzzzzzzc_, default);
            DataType zzzzzzzzzzzzzzze_ = AverageDrinks?.Value;
            object zzzzzzzzzzzzzzzf_ = FHIRHelpers_4_4_000.Instance.ToValue(context, zzzzzzzzzzzzzzze_);
            CqlQuantity zzzzzzzzzzzzzzzg_ = context.Operators.Quantity(2m, "{drinks}/d");
            bool? zzzzzzzzzzzzzzzh_ = context.Operators.Greater(zzzzzzzzzzzzzzzf_ as CqlQuantity, zzzzzzzzzzzzzzzg_);
            bool? zzzzzzzzzzzzzzzi_ = context.Operators.And(zzzzzzzzzzzzzzzd_, zzzzzzzzzzzzzzzh_);

            return zzzzzzzzzzzzzzzi_;
        };
        IEnumerable<Observation> yzzzzzzzzzzzzzzu_ = context.Operators.Where<Observation>(yzzzzzzzzzzzzzzs_, yzzzzzzzzzzzzzzt_);
        object yzzzzzzzzzzzzzzv_(Observation @this)
        {
            DataType zzzzzzzzzzzzzzzj_ = @this?.Effective;
            object zzzzzzzzzzzzzzzk_ = FHIRHelpers_4_4_000.Instance.ToValue(context, zzzzzzzzzzzzzzzj_);
            CqlInterval<CqlDateTime> zzzzzzzzzzzzzzzl_ = QICoreCommon_2_1_000.Instance.toInterval(context, zzzzzzzzzzzzzzzk_);
            CqlDateTime zzzzzzzzzzzzzzzm_ = context.Operators.Start(zzzzzzzzzzzzzzzl_);

            return zzzzzzzzzzzzzzzm_;
        };
        IEnumerable<Observation> yzzzzzzzzzzzzzzw_ = context.Operators.SortBy<Observation>(yzzzzzzzzzzzzzzu_, yzzzzzzzzzzzzzzv_, System.ComponentModel.ListSortDirection.Ascending);
        Observation yzzzzzzzzzzzzzzx_ = context.Operators.First<Observation>(yzzzzzzzzzzzzzzw_);

        return yzzzzzzzzzzzzzzx_;
    }


    [CqlExpressionDefinition("Has Risk Factor Active During the Measurement Period")]
    public bool? Has_Risk_Factor_Active_During_the_Measurement_Period(CqlContext context)
    {
        Observation zzzzzzzzzzzzzzzn_ = this.First_BMI_in_Measurement_Period_Less_Than_or_Equal_to_20_kg_m2(context);
        bool? zzzzzzzzzzzzzzzo_ = context.Operators.Not((bool?)(zzzzzzzzzzzzzzzn_ is null));
        Observation zzzzzzzzzzzzzzzp_ = this.First_Average_Number_of_Drinks_Assessments_Indicating_More_Than_Two_Per_Day(context);
        bool? zzzzzzzzzzzzzzzq_ = context.Operators.Not((bool?)(zzzzzzzzzzzzzzzp_ is null));
        bool? zzzzzzzzzzzzzzzr_ = context.Operators.Or(zzzzzzzzzzzzzzzo_, zzzzzzzzzzzzzzzq_);

        return zzzzzzzzzzzzzzzr_;
    }


    [CqlExpressionDefinition("Has Risk Factor Any Time in History Prior to Measurement Period")]
    public bool? Has_Risk_Factor_Any_Time_in_History_Prior_to_Measurement_Period(CqlContext context)
    {
        CqlValueSet zzzzzzzzzzzzzzzs_ = this.Osteoporosis_Without_Current_Fracture(context);
        IEnumerable<Condition> zzzzzzzzzzzzzzzt_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, zzzzzzzzzzzzzzzs_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        bool? zzzzzzzzzzzzzzzu_(Condition OsteoporosisDiagnosis)
        {
            CqlInterval<CqlDateTime> bzzzzzzzzzzzzzzzg_ = QICoreCommon_2_1_000.Instance.prevalenceInterval(context, OsteoporosisDiagnosis);
            CqlDateTime bzzzzzzzzzzzzzzzh_ = context.Operators.Start(bzzzzzzzzzzzzzzzg_);
            CqlInterval<CqlDateTime> bzzzzzzzzzzzzzzzi_ = this.Measurement_Period(context);
            CqlDateTime bzzzzzzzzzzzzzzzj_ = context.Operators.Start(bzzzzzzzzzzzzzzzi_);
            bool? bzzzzzzzzzzzzzzzk_ = context.Operators.Before(bzzzzzzzzzzzzzzzh_, bzzzzzzzzzzzzzzzj_, default);

            return bzzzzzzzzzzzzzzzk_;
        };
        IEnumerable<Condition> zzzzzzzzzzzzzzzv_ = context.Operators.Where<Condition>(zzzzzzzzzzzzzzzt_, zzzzzzzzzzzzzzzu_);
        CqlValueSet zzzzzzzzzzzzzzzw_ = this.Osteopenia(context);
        IEnumerable<Condition> zzzzzzzzzzzzzzzx_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, zzzzzzzzzzzzzzzw_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        bool? zzzzzzzzzzzzzzzy_(Condition OsteopeniaDiagnosis)
        {
            CqlInterval<CqlDateTime> bzzzzzzzzzzzzzzzl_ = QICoreCommon_2_1_000.Instance.prevalenceInterval(context, OsteopeniaDiagnosis);
            CqlDateTime bzzzzzzzzzzzzzzzm_ = context.Operators.Start(bzzzzzzzzzzzzzzzl_);
            CqlInterval<CqlDateTime> bzzzzzzzzzzzzzzzn_ = this.Measurement_Period(context);
            CqlDateTime bzzzzzzzzzzzzzzzo_ = context.Operators.Start(bzzzzzzzzzzzzzzzn_);
            bool? bzzzzzzzzzzzzzzzp_ = context.Operators.Before(bzzzzzzzzzzzzzzzm_, bzzzzzzzzzzzzzzzo_, default);

            return bzzzzzzzzzzzzzzzp_;
        };
        IEnumerable<Condition> zzzzzzzzzzzzzzzz_ = context.Operators.Where<Condition>(zzzzzzzzzzzzzzzx_, zzzzzzzzzzzzzzzy_);
        IEnumerable<Condition> azzzzzzzzzzzzzzza_ = context.Operators.Union<Condition>(zzzzzzzzzzzzzzzv_, zzzzzzzzzzzzzzzz_);
        CqlValueSet azzzzzzzzzzzzzzzb_ = this.Gastric_Bypass_Surgery(context);
        IEnumerable<Procedure> azzzzzzzzzzzzzzzc_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, azzzzzzzzzzzzzzzb_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
        IEnumerable<Procedure> azzzzzzzzzzzzzzzd_ = Status_1_8_000.Instance.isProcedurePerformed(context, azzzzzzzzzzzzzzzc_);
        bool? azzzzzzzzzzzzzzze_(Procedure GastricBypass)
        {
            DataType bzzzzzzzzzzzzzzzq_ = GastricBypass?.Performed;
            object bzzzzzzzzzzzzzzzr_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bzzzzzzzzzzzzzzzq_);
            CqlInterval<CqlDateTime> bzzzzzzzzzzzzzzzs_ = QICoreCommon_2_1_000.Instance.toInterval(context, bzzzzzzzzzzzzzzzr_);
            CqlDateTime bzzzzzzzzzzzzzzzt_ = context.Operators.End(bzzzzzzzzzzzzzzzs_);
            CqlInterval<CqlDateTime> bzzzzzzzzzzzzzzzu_ = this.Measurement_Period(context);
            CqlDateTime bzzzzzzzzzzzzzzzv_ = context.Operators.Start(bzzzzzzzzzzzzzzzu_);
            bool? bzzzzzzzzzzzzzzzw_ = context.Operators.Before(bzzzzzzzzzzzzzzzt_, bzzzzzzzzzzzzzzzv_, default);

            return bzzzzzzzzzzzzzzzw_;
        };
        IEnumerable<Procedure> azzzzzzzzzzzzzzzf_ = context.Operators.Where<Procedure>(azzzzzzzzzzzzzzzd_, azzzzzzzzzzzzzzze_);
        CqlValueSet azzzzzzzzzzzzzzzg_ = this.Aromatase_Inhibitors(context);
        IEnumerable<MedicationRequest> azzzzzzzzzzzzzzzh_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, azzzzzzzzzzzzzzzg_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> azzzzzzzzzzzzzzzj_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, azzzzzzzzzzzzzzzg_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> azzzzzzzzzzzzzzzk_ = context.Operators.Union<MedicationRequest>(azzzzzzzzzzzzzzzh_, azzzzzzzzzzzzzzzj_);
        IEnumerable<MedicationRequest> azzzzzzzzzzzzzzzl_ = Status_1_8_000.Instance.isMedicationActive(context, azzzzzzzzzzzzzzzk_);
        bool? azzzzzzzzzzzzzzzm_(MedicationRequest AromataseInhibitorActive)
        {
            CqlInterval<CqlDate> bzzzzzzzzzzzzzzzx_ = CumulativeMedicationDuration_4_1_000.Instance.MedicationRequestPeriod(context, AromataseInhibitorActive);
            CqlDate bzzzzzzzzzzzzzzzy_ = context.Operators.Start(bzzzzzzzzzzzzzzzx_);
            CqlDateTime bzzzzzzzzzzzzzzzz_ = context.Operators.ConvertDateToDateTime(bzzzzzzzzzzzzzzzy_);
            CqlInterval<CqlDateTime> czzzzzzzzzzzzzzza_ = this.Measurement_Period(context);
            CqlDateTime czzzzzzzzzzzzzzzb_ = context.Operators.Start(czzzzzzzzzzzzzzza_);
            bool? czzzzzzzzzzzzzzzc_ = context.Operators.Before(bzzzzzzzzzzzzzzzz_, czzzzzzzzzzzzzzzb_, default);

            return czzzzzzzzzzzzzzzc_;
        };
        IEnumerable<MedicationRequest> azzzzzzzzzzzzzzzn_ = context.Operators.Where<MedicationRequest>(azzzzzzzzzzzzzzzl_, azzzzzzzzzzzzzzzm_);
        IEnumerable<object> azzzzzzzzzzzzzzzo_ = context.Operators.Union<object>(azzzzzzzzzzzzzzzf_ as IEnumerable<object>, azzzzzzzzzzzzzzzn_ as IEnumerable<object>);
        IEnumerable<MedicationRequest> azzzzzzzzzzzzzzzq_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, azzzzzzzzzzzzzzzg_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> azzzzzzzzzzzzzzzs_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, azzzzzzzzzzzzzzzg_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> azzzzzzzzzzzzzzzt_ = context.Operators.Union<MedicationRequest>(azzzzzzzzzzzzzzzq_, azzzzzzzzzzzzzzzs_);
        IEnumerable<MedicationRequest> azzzzzzzzzzzzzzzu_ = Status_1_8_000.Instance.isMedicationOrder(context, azzzzzzzzzzzzzzzt_);
        bool? azzzzzzzzzzzzzzzv_(MedicationRequest AromataseInhibitorOrder)
        {
            FhirDateTime czzzzzzzzzzzzzzzd_ = AromataseInhibitorOrder?.AuthoredOnElement;
            CqlDateTime czzzzzzzzzzzzzzze_ = context.Operators.Convert<CqlDateTime>(czzzzzzzzzzzzzzzd_);
            CqlInterval<CqlDateTime> czzzzzzzzzzzzzzzf_ = QICoreCommon_2_1_000.Instance.toInterval(context, czzzzzzzzzzzzzzze_ as object);
            CqlInterval<CqlDateTime> czzzzzzzzzzzzzzzg_()
            {
                bool czzzzzzzzzzzzzzzi_()
                {
                    CqlInterval<CqlDateTime> czzzzzzzzzzzzzzzj_ = this.Measurement_Period(context);
                    CqlDateTime czzzzzzzzzzzzzzzk_ = context.Operators.Start(czzzzzzzzzzzzzzzj_);

                    return czzzzzzzzzzzzzzzk_ is null;
                };
                if (czzzzzzzzzzzzzzzi_())
                {
                    return default;
                }
                else
                {
                    CqlInterval<CqlDateTime> czzzzzzzzzzzzzzzl_ = this.Measurement_Period(context);
                    CqlDateTime czzzzzzzzzzzzzzzm_ = context.Operators.Start(czzzzzzzzzzzzzzzl_);
                    CqlDateTime czzzzzzzzzzzzzzzo_ = context.Operators.Start(czzzzzzzzzzzzzzzl_);
                    CqlInterval<CqlDateTime> czzzzzzzzzzzzzzzp_ = context.Operators.Interval(czzzzzzzzzzzzzzzm_, czzzzzzzzzzzzzzzo_, true, true);

                    return czzzzzzzzzzzzzzzp_;
                }
            };
            bool? czzzzzzzzzzzzzzzh_ = context.Operators.Before(czzzzzzzzzzzzzzzf_, czzzzzzzzzzzzzzzg_(), default);

            return czzzzzzzzzzzzzzzh_;
        };
        IEnumerable<MedicationRequest> azzzzzzzzzzzzzzzw_ = context.Operators.Where<MedicationRequest>(azzzzzzzzzzzzzzzu_, azzzzzzzzzzzzzzzv_);
        IEnumerable<object> azzzzzzzzzzzzzzzx_ = context.Operators.Union<object>(azzzzzzzzzzzzzzzo_ as IEnumerable<object>, azzzzzzzzzzzzzzzw_ as IEnumerable<object>);
        CqlValueSet azzzzzzzzzzzzzzzy_ = this.History_of_hip_fracture_in_parent(context);
        IEnumerable<Observation> azzzzzzzzzzzzzzzz_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, azzzzzzzzzzzzzzzy_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
        IEnumerable<Observation> bzzzzzzzzzzzzzzza_ = Status_1_8_000.Instance.isAssessmentPerformed(context, azzzzzzzzzzzzzzzz_);
        bool? bzzzzzzzzzzzzzzzb_(Observation ParentFractureHistory)
        {
            DataType czzzzzzzzzzzzzzzq_ = ParentFractureHistory?.Effective;
            object czzzzzzzzzzzzzzzr_ = FHIRHelpers_4_4_000.Instance.ToValue(context, czzzzzzzzzzzzzzzq_);
            CqlInterval<CqlDateTime> czzzzzzzzzzzzzzzs_ = QICoreCommon_2_1_000.Instance.toInterval(context, czzzzzzzzzzzzzzzr_);
            CqlDateTime czzzzzzzzzzzzzzzt_ = context.Operators.Start(czzzzzzzzzzzzzzzs_);
            CqlInterval<CqlDateTime> czzzzzzzzzzzzzzzu_ = this.Measurement_Period(context);
            CqlDateTime czzzzzzzzzzzzzzzv_ = context.Operators.Start(czzzzzzzzzzzzzzzu_);
            bool? czzzzzzzzzzzzzzzw_ = context.Operators.Before(czzzzzzzzzzzzzzzt_, czzzzzzzzzzzzzzzv_, default);

            return czzzzzzzzzzzzzzzw_;
        };
        IEnumerable<Observation> bzzzzzzzzzzzzzzzc_ = context.Operators.Where<Observation>(bzzzzzzzzzzzzzzza_, bzzzzzzzzzzzzzzzb_);
        IEnumerable<object> bzzzzzzzzzzzzzzzd_ = context.Operators.Union<object>(azzzzzzzzzzzzzzzx_ as IEnumerable<object>, bzzzzzzzzzzzzzzzc_ as IEnumerable<object>);
        IEnumerable<object> bzzzzzzzzzzzzzzze_ = context.Operators.Union<object>(azzzzzzzzzzzzzzza_ as IEnumerable<object>, bzzzzzzzzzzzzzzzd_ as IEnumerable<object>);
        bool? bzzzzzzzzzzzzzzzf_ = context.Operators.Exists<object>(bzzzzzzzzzzzzzzze_);

        return bzzzzzzzzzzzzzzzf_;
    }


    [CqlExpressionDefinition("Glucocorticoid Active Medication Days")]
    public int? Glucocorticoid_Active_Medication_Days(CqlContext context)
    {
        CqlValueSet czzzzzzzzzzzzzzzx_ = this.Glucocorticoids__oral_only_(context);
        IEnumerable<MedicationRequest> czzzzzzzzzzzzzzzy_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, czzzzzzzzzzzzzzzx_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> dzzzzzzzzzzzzzzza_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, czzzzzzzzzzzzzzzx_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> dzzzzzzzzzzzzzzzb_ = context.Operators.Union<MedicationRequest>(czzzzzzzzzzzzzzzy_, dzzzzzzzzzzzzzzza_);
        IEnumerable<MedicationRequest> dzzzzzzzzzzzzzzzc_ = Status_1_8_000.Instance.isMedicationActive(context, dzzzzzzzzzzzzzzzb_);
        bool? dzzzzzzzzzzzzzzzd_(MedicationRequest OralGlucocorticoid)
        {
            CqlInterval<CqlDate> dzzzzzzzzzzzzzzzj_ = CumulativeMedicationDuration_4_1_000.Instance.medicationRequestPeriod(context, OralGlucocorticoid);
            CqlDate dzzzzzzzzzzzzzzzk_ = context.Operators.Start(dzzzzzzzzzzzzzzzj_);
            CqlDateTime dzzzzzzzzzzzzzzzl_ = context.Operators.ConvertDateToDateTime(dzzzzzzzzzzzzzzzk_);
            CqlInterval<CqlDateTime> dzzzzzzzzzzzzzzzm_ = this.Measurement_Period(context);
            CqlDateTime dzzzzzzzzzzzzzzzn_ = context.Operators.End(dzzzzzzzzzzzzzzzm_);
            bool? dzzzzzzzzzzzzzzzo_ = context.Operators.Before(dzzzzzzzzzzzzzzzl_, dzzzzzzzzzzzzzzzn_, default);

            return dzzzzzzzzzzzzzzzo_;
        };
        IEnumerable<MedicationRequest> dzzzzzzzzzzzzzzze_ = context.Operators.Where<MedicationRequest>(dzzzzzzzzzzzzzzzc_, dzzzzzzzzzzzzzzzd_);
        CqlInterval<CqlDate> dzzzzzzzzzzzzzzzf_(MedicationRequest Glucocorticoid)
        {
            CqlInterval<CqlDate> dzzzzzzzzzzzzzzzp_ = CumulativeMedicationDuration_4_1_000.Instance.medicationRequestPeriod(context, Glucocorticoid);
            Patient dzzzzzzzzzzzzzzzq_ = this.Patient(context);
            Date dzzzzzzzzzzzzzzzr_ = dzzzzzzzzzzzzzzzq_?.BirthDateElement;
            string dzzzzzzzzzzzzzzzs_ = dzzzzzzzzzzzzzzzr_?.Value;
            CqlDate dzzzzzzzzzzzzzzzt_ = context.Operators.ConvertStringToDate(dzzzzzzzzzzzzzzzs_);
            CqlInterval<CqlDateTime> dzzzzzzzzzzzzzzzu_ = this.Measurement_Period(context);
            CqlDateTime dzzzzzzzzzzzzzzzv_ = context.Operators.End(dzzzzzzzzzzzzzzzu_);
            CqlDate dzzzzzzzzzzzzzzzw_ = context.Operators.DateFrom(dzzzzzzzzzzzzzzzv_);
            CqlInterval<CqlDate> dzzzzzzzzzzzzzzzx_ = context.Operators.Interval(dzzzzzzzzzzzzzzzt_, dzzzzzzzzzzzzzzzw_, true, true);
            CqlInterval<CqlDate> dzzzzzzzzzzzzzzzy_ = context.Operators.Intersect<CqlDate>(dzzzzzzzzzzzzzzzp_, dzzzzzzzzzzzzzzzx_);

            return dzzzzzzzzzzzzzzzy_;
        };
        IEnumerable<CqlInterval<CqlDate>> dzzzzzzzzzzzzzzzg_ = context.Operators.Select<MedicationRequest, CqlInterval<CqlDate>>(dzzzzzzzzzzzzzzze_, dzzzzzzzzzzzzzzzf_);
        IEnumerable<CqlInterval<CqlDate>> dzzzzzzzzzzzzzzzh_ = context.Operators.Distinct<CqlInterval<CqlDate>>(dzzzzzzzzzzzzzzzg_);
        int? dzzzzzzzzzzzzzzzi_ = CumulativeMedicationDuration_4_1_000.Instance.cumulativeDuration(context, dzzzzzzzzzzzzzzzh_);

        return dzzzzzzzzzzzzzzzi_;
    }


    [CqlExpressionDefinition("Has 90 or More Active Glucocorticoid Medication Days")]
    public bool? Has_90_or_More_Active_Glucocorticoid_Medication_Days(CqlContext context)
    {
        int? dzzzzzzzzzzzzzzzz_ = this.Glucocorticoid_Active_Medication_Days(context);
        bool? ezzzzzzzzzzzzzzza_ = context.Operators.GreaterOrEqual(dzzzzzzzzzzzzzzzz_, 90);

        return ezzzzzzzzzzzzzzza_;
    }


    [CqlExpressionDefinition("diagnosisInPatientHistory")]
    public IEnumerable<Condition> diagnosisInPatientHistory(CqlContext context, IEnumerable<Condition> Condition)
    {
        bool? ezzzzzzzzzzzzzzzb_(Condition Dx)
        {
            CqlInterval<CqlDateTime> ezzzzzzzzzzzzzzzd_ = QICoreCommon_2_1_000.Instance.prevalenceInterval(context, Dx);
            CqlDateTime ezzzzzzzzzzzzzzze_ = context.Operators.Start(ezzzzzzzzzzzzzzzd_);
            CqlInterval<CqlDateTime> ezzzzzzzzzzzzzzzf_ = this.Measurement_Period(context);
            CqlDateTime ezzzzzzzzzzzzzzzg_ = context.Operators.End(ezzzzzzzzzzzzzzzf_);
            bool? ezzzzzzzzzzzzzzzh_ = context.Operators.SameOrBefore(ezzzzzzzzzzzzzzze_, ezzzzzzzzzzzzzzzg_, "day");

            return ezzzzzzzzzzzzzzzh_;
        };
        IEnumerable<Condition> ezzzzzzzzzzzzzzzc_ = context.Operators.Where<Condition>(Condition, ezzzzzzzzzzzzzzzb_);

        return ezzzzzzzzzzzzzzzc_;
    }


    [CqlExpressionDefinition("procedureInPatientHistory")]
    public IEnumerable<Procedure> procedureInPatientHistory(CqlContext context, IEnumerable<Procedure> Procedure)
    {
        IEnumerable<Procedure> ezzzzzzzzzzzzzzzi_ = Status_1_8_000.Instance.isProcedurePerformed(context, Procedure);
        bool? ezzzzzzzzzzzzzzzj_(Procedure Proc)
        {
            DataType ezzzzzzzzzzzzzzzl_ = Proc?.Performed;
            object ezzzzzzzzzzzzzzzm_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ezzzzzzzzzzzzzzzl_);
            CqlInterval<CqlDateTime> ezzzzzzzzzzzzzzzn_ = QICoreCommon_2_1_000.Instance.toInterval(context, ezzzzzzzzzzzzzzzm_);
            CqlDateTime ezzzzzzzzzzzzzzzo_ = context.Operators.End(ezzzzzzzzzzzzzzzn_);
            CqlInterval<CqlDateTime> ezzzzzzzzzzzzzzzp_ = this.Measurement_Period(context);
            CqlDateTime ezzzzzzzzzzzzzzzq_ = context.Operators.End(ezzzzzzzzzzzzzzzp_);
            bool? ezzzzzzzzzzzzzzzr_ = context.Operators.SameOrBefore(ezzzzzzzzzzzzzzzo_, ezzzzzzzzzzzzzzzq_, "day");

            return ezzzzzzzzzzzzzzzr_;
        };
        IEnumerable<Procedure> ezzzzzzzzzzzzzzzk_ = context.Operators.Where<Procedure>(ezzzzzzzzzzzzzzzi_, ezzzzzzzzzzzzzzzj_);

        return ezzzzzzzzzzzzzzzk_;
    }


    [CqlExpressionDefinition("Has Double or Bilateral Oophorectomy")]
    public bool? Has_Double_or_Bilateral_Oophorectomy(CqlContext context)
    {
        CqlValueSet ezzzzzzzzzzzzzzzs_ = this.Bilateral_Oophorectomy(context);
        IEnumerable<Procedure> ezzzzzzzzzzzzzzzt_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, ezzzzzzzzzzzzzzzs_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
        IEnumerable<Procedure> ezzzzzzzzzzzzzzzu_ = this.procedureInPatientHistory(context, ezzzzzzzzzzzzzzzt_);
        bool? ezzzzzzzzzzzzzzzv_ = context.Operators.Exists<Procedure>(ezzzzzzzzzzzzzzzu_);
        CqlValueSet ezzzzzzzzzzzzzzzw_ = this.Evidence_of_Bilateral_Oophorectomy(context);
        IEnumerable<Procedure> ezzzzzzzzzzzzzzzx_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, ezzzzzzzzzzzzzzzw_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
        IEnumerable<Procedure> ezzzzzzzzzzzzzzzy_ = this.procedureInPatientHistory(context, ezzzzzzzzzzzzzzzx_);
        bool? ezzzzzzzzzzzzzzzz_ = context.Operators.Exists<Procedure>(ezzzzzzzzzzzzzzzy_);
        bool? fzzzzzzzzzzzzzzza_ = context.Operators.Or(ezzzzzzzzzzzzzzzv_, ezzzzzzzzzzzzzzzz_);
        CqlValueSet fzzzzzzzzzzzzzzzb_ = this.Unilateral_Oophorectomy__Unspecified_Laterality(context);
        IEnumerable<Procedure> fzzzzzzzzzzzzzzzc_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, fzzzzzzzzzzzzzzzb_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
        bool? fzzzzzzzzzzzzzzzd_(Procedure UnilateralOophorectomy)
        {
            List<CodeableConcept> fzzzzzzzzzzzzzzzv_ = UnilateralOophorectomy?.BodySite;
            CqlConcept fzzzzzzzzzzzzzzzw_(CodeableConcept @this)
            {
                CqlConcept gzzzzzzzzzzzzzzzb_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);

                return gzzzzzzzzzzzzzzzb_;
            };
            IEnumerable<CqlConcept> fzzzzzzzzzzzzzzzx_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)fzzzzzzzzzzzzzzzv_, fzzzzzzzzzzzzzzzw_);
            bool? fzzzzzzzzzzzzzzzy_(CqlConcept C)
            {
                CqlCode gzzzzzzzzzzzzzzzc_ = this.Right__qualifier_value_(context);
                CqlConcept gzzzzzzzzzzzzzzzd_ = context.Operators.ConvertCodeToConcept(gzzzzzzzzzzzzzzzc_);
                bool? gzzzzzzzzzzzzzzze_ = context.Operators.Equivalent(C, gzzzzzzzzzzzzzzzd_);

                return gzzzzzzzzzzzzzzze_;
            };
            IEnumerable<CqlConcept> fzzzzzzzzzzzzzzzz_ = context.Operators.Where<CqlConcept>(fzzzzzzzzzzzzzzzx_, fzzzzzzzzzzzzzzzy_);
            bool? gzzzzzzzzzzzzzzza_ = context.Operators.Exists<CqlConcept>(fzzzzzzzzzzzzzzzz_);

            return gzzzzzzzzzzzzzzza_;
        };
        IEnumerable<Procedure> fzzzzzzzzzzzzzzze_ = context.Operators.Where<Procedure>(fzzzzzzzzzzzzzzzc_, fzzzzzzzzzzzzzzzd_);
        CqlValueSet fzzzzzzzzzzzzzzzf_ = this.Unilateral_Oophorectomy_Right(context);
        IEnumerable<Procedure> fzzzzzzzzzzzzzzzg_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, fzzzzzzzzzzzzzzzf_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
        IEnumerable<Procedure> fzzzzzzzzzzzzzzzh_ = context.Operators.Union<Procedure>(fzzzzzzzzzzzzzzze_, fzzzzzzzzzzzzzzzg_);
        IEnumerable<Procedure> fzzzzzzzzzzzzzzzi_ = this.procedureInPatientHistory(context, fzzzzzzzzzzzzzzzh_);
        bool? fzzzzzzzzzzzzzzzj_ = context.Operators.Exists<Procedure>(fzzzzzzzzzzzzzzzi_);
        IEnumerable<Procedure> fzzzzzzzzzzzzzzzl_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, fzzzzzzzzzzzzzzzb_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
        bool? fzzzzzzzzzzzzzzzm_(Procedure UnilateralOophorectomy)
        {
            List<CodeableConcept> gzzzzzzzzzzzzzzzf_ = UnilateralOophorectomy?.BodySite;
            CqlConcept gzzzzzzzzzzzzzzzg_(CodeableConcept @this)
            {
                CqlConcept gzzzzzzzzzzzzzzzl_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);

                return gzzzzzzzzzzzzzzzl_;
            };
            IEnumerable<CqlConcept> gzzzzzzzzzzzzzzzh_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)gzzzzzzzzzzzzzzzf_, gzzzzzzzzzzzzzzzg_);
            bool? gzzzzzzzzzzzzzzzi_(CqlConcept D)
            {
                CqlCode gzzzzzzzzzzzzzzzm_ = this.Left__qualifier_value_(context);
                CqlConcept gzzzzzzzzzzzzzzzn_ = context.Operators.ConvertCodeToConcept(gzzzzzzzzzzzzzzzm_);
                bool? gzzzzzzzzzzzzzzzo_ = context.Operators.Equivalent(D, gzzzzzzzzzzzzzzzn_);

                return gzzzzzzzzzzzzzzzo_;
            };
            IEnumerable<CqlConcept> gzzzzzzzzzzzzzzzj_ = context.Operators.Where<CqlConcept>(gzzzzzzzzzzzzzzzh_, gzzzzzzzzzzzzzzzi_);
            bool? gzzzzzzzzzzzzzzzk_ = context.Operators.Exists<CqlConcept>(gzzzzzzzzzzzzzzzj_);

            return gzzzzzzzzzzzzzzzk_;
        };
        IEnumerable<Procedure> fzzzzzzzzzzzzzzzn_ = context.Operators.Where<Procedure>(fzzzzzzzzzzzzzzzl_, fzzzzzzzzzzzzzzzm_);
        CqlValueSet fzzzzzzzzzzzzzzzo_ = this.Unilateral_Oophorectomy_Left(context);
        IEnumerable<Procedure> fzzzzzzzzzzzzzzzp_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, fzzzzzzzzzzzzzzzo_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
        IEnumerable<Procedure> fzzzzzzzzzzzzzzzq_ = context.Operators.Union<Procedure>(fzzzzzzzzzzzzzzzn_, fzzzzzzzzzzzzzzzp_);
        IEnumerable<Procedure> fzzzzzzzzzzzzzzzr_ = this.procedureInPatientHistory(context, fzzzzzzzzzzzzzzzq_);
        bool? fzzzzzzzzzzzzzzzs_ = context.Operators.Exists<Procedure>(fzzzzzzzzzzzzzzzr_);
        bool? fzzzzzzzzzzzzzzzt_ = context.Operators.And(fzzzzzzzzzzzzzzzj_, fzzzzzzzzzzzzzzzs_);
        bool? fzzzzzzzzzzzzzzzu_ = context.Operators.Or(fzzzzzzzzzzzzzzza_, fzzzzzzzzzzzzzzzt_);

        return fzzzzzzzzzzzzzzzu_;
    }


    [CqlExpressionDefinition("Has Organ Transplants")]
    public bool? Has_Organ_Transplants(CqlContext context)
    {
        CqlValueSet gzzzzzzzzzzzzzzzp_ = this.Major_Transplant(context);
        IEnumerable<Procedure> gzzzzzzzzzzzzzzzq_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, gzzzzzzzzzzzzzzzp_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
        CqlValueSet gzzzzzzzzzzzzzzzr_ = this.Kidney_Transplant(context);
        IEnumerable<Procedure> gzzzzzzzzzzzzzzzs_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, gzzzzzzzzzzzzzzzr_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
        IEnumerable<Procedure> gzzzzzzzzzzzzzzzt_ = context.Operators.Union<Procedure>(gzzzzzzzzzzzzzzzq_, gzzzzzzzzzzzzzzzs_);
        CqlValueSet gzzzzzzzzzzzzzzzu_ = this.Bone_Marrow_Transplant(context);
        IEnumerable<Procedure> gzzzzzzzzzzzzzzzv_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, gzzzzzzzzzzzzzzzu_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
        IEnumerable<Procedure> gzzzzzzzzzzzzzzzw_ = context.Operators.Union<Procedure>(gzzzzzzzzzzzzzzzt_, gzzzzzzzzzzzzzzzv_);
        IEnumerable<Procedure> gzzzzzzzzzzzzzzzx_ = this.procedureInPatientHistory(context, gzzzzzzzzzzzzzzzw_);
        bool? gzzzzzzzzzzzzzzzy_ = context.Operators.Exists<Procedure>(gzzzzzzzzzzzzzzzx_);

        return gzzzzzzzzzzzzzzzy_;
    }


    [CqlExpressionDefinition("Has Risk Factor Any Time in History or During Measurement Period")]
    public bool? Has_Risk_Factor_Any_Time_in_History_or_During_Measurement_Period(CqlContext context)
    {
        bool? gzzzzzzzzzzzzzzzz_ = this.Has_90_or_More_Active_Glucocorticoid_Medication_Days(context);
        CqlValueSet hzzzzzzzzzzzzzzza_ = this.Osteoporosis_With_Current_Fracture(context);
        IEnumerable<Condition> hzzzzzzzzzzzzzzzb_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, hzzzzzzzzzzzzzzza_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        CqlValueSet hzzzzzzzzzzzzzzzc_ = this.Malabsorption_Syndromes(context);
        IEnumerable<Condition> hzzzzzzzzzzzzzzzd_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, hzzzzzzzzzzzzzzzc_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        IEnumerable<Condition> hzzzzzzzzzzzzzzze_ = context.Operators.Union<Condition>(hzzzzzzzzzzzzzzzb_, hzzzzzzzzzzzzzzzd_);
        CqlValueSet hzzzzzzzzzzzzzzzf_ = this.Chronic_Malnutrition(context);
        IEnumerable<Condition> hzzzzzzzzzzzzzzzg_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, hzzzzzzzzzzzzzzzf_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        CqlValueSet hzzzzzzzzzzzzzzzh_ = this.Chronic_Liver_Disease(context);
        IEnumerable<Condition> hzzzzzzzzzzzzzzzi_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, hzzzzzzzzzzzzzzzh_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        IEnumerable<Condition> hzzzzzzzzzzzzzzzj_ = context.Operators.Union<Condition>(hzzzzzzzzzzzzzzzg_, hzzzzzzzzzzzzzzzi_);
        IEnumerable<Condition> hzzzzzzzzzzzzzzzk_ = context.Operators.Union<Condition>(hzzzzzzzzzzzzzzze_, hzzzzzzzzzzzzzzzj_);
        CqlValueSet hzzzzzzzzzzzzzzzl_ = this.Rheumatoid_Arthritis(context);
        IEnumerable<Condition> hzzzzzzzzzzzzzzzm_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, hzzzzzzzzzzzzzzzl_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        CqlValueSet hzzzzzzzzzzzzzzzn_ = this.Hyperthyroidism(context);
        IEnumerable<Condition> hzzzzzzzzzzzzzzzo_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, hzzzzzzzzzzzzzzzn_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        IEnumerable<Condition> hzzzzzzzzzzzzzzzp_ = context.Operators.Union<Condition>(hzzzzzzzzzzzzzzzm_, hzzzzzzzzzzzzzzzo_);
        IEnumerable<Condition> hzzzzzzzzzzzzzzzq_ = context.Operators.Union<Condition>(hzzzzzzzzzzzzzzzk_, hzzzzzzzzzzzzzzzp_);
        CqlValueSet hzzzzzzzzzzzzzzzr_ = this.Type_1_Diabetes(context);
        IEnumerable<Condition> hzzzzzzzzzzzzzzzs_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, hzzzzzzzzzzzzzzzr_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        CqlValueSet hzzzzzzzzzzzzzzzt_ = this.End_Stage_Renal_Disease(context);
        IEnumerable<Condition> hzzzzzzzzzzzzzzzu_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, hzzzzzzzzzzzzzzzt_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        IEnumerable<Condition> hzzzzzzzzzzzzzzzv_ = context.Operators.Union<Condition>(hzzzzzzzzzzzzzzzs_, hzzzzzzzzzzzzzzzu_);
        IEnumerable<Condition> hzzzzzzzzzzzzzzzw_ = context.Operators.Union<Condition>(hzzzzzzzzzzzzzzzq_, hzzzzzzzzzzzzzzzv_);
        CqlValueSet hzzzzzzzzzzzzzzzx_ = this.Osteogenesis_Imperfecta(context);
        IEnumerable<Condition> hzzzzzzzzzzzzzzzy_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, hzzzzzzzzzzzzzzzx_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        CqlValueSet hzzzzzzzzzzzzzzzz_ = this.Ankylosing_Spondylitis(context);
        IEnumerable<Condition> izzzzzzzzzzzzzzza_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, hzzzzzzzzzzzzzzzz_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        IEnumerable<Condition> izzzzzzzzzzzzzzzb_ = context.Operators.Union<Condition>(hzzzzzzzzzzzzzzzy_, izzzzzzzzzzzzzzza_);
        IEnumerable<Condition> izzzzzzzzzzzzzzzc_ = context.Operators.Union<Condition>(hzzzzzzzzzzzzzzzw_, izzzzzzzzzzzzzzzb_);
        CqlValueSet izzzzzzzzzzzzzzzd_ = this.Psoriatic_Arthritis(context);
        IEnumerable<Condition> izzzzzzzzzzzzzzze_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, izzzzzzzzzzzzzzzd_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        CqlValueSet izzzzzzzzzzzzzzzf_ = this.Ehlers_Danlos_Syndrome(context);
        IEnumerable<Condition> izzzzzzzzzzzzzzzg_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, izzzzzzzzzzzzzzzf_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        IEnumerable<Condition> izzzzzzzzzzzzzzzh_ = context.Operators.Union<Condition>(izzzzzzzzzzzzzzze_, izzzzzzzzzzzzzzzg_);
        IEnumerable<Condition> izzzzzzzzzzzzzzzi_ = context.Operators.Union<Condition>(izzzzzzzzzzzzzzzc_, izzzzzzzzzzzzzzzh_);
        CqlValueSet izzzzzzzzzzzzzzzj_ = this.Cushings_Syndrome(context);
        IEnumerable<Condition> izzzzzzzzzzzzzzzk_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, izzzzzzzzzzzzzzzj_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        CqlValueSet izzzzzzzzzzzzzzzl_ = this.Hyperparathyroidism(context);
        IEnumerable<Condition> izzzzzzzzzzzzzzzm_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, izzzzzzzzzzzzzzzl_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        IEnumerable<Condition> izzzzzzzzzzzzzzzn_ = context.Operators.Union<Condition>(izzzzzzzzzzzzzzzk_, izzzzzzzzzzzzzzzm_);
        IEnumerable<Condition> izzzzzzzzzzzzzzzo_ = context.Operators.Union<Condition>(izzzzzzzzzzzzzzzi_, izzzzzzzzzzzzzzzn_);
        CqlValueSet izzzzzzzzzzzzzzzp_ = this.Marfans_Syndrome(context);
        IEnumerable<Condition> izzzzzzzzzzzzzzzq_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, izzzzzzzzzzzzzzzp_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        CqlValueSet izzzzzzzzzzzzzzzr_ = this.Lupus(context);
        IEnumerable<Condition> izzzzzzzzzzzzzzzs_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, izzzzzzzzzzzzzzzr_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        IEnumerable<Condition> izzzzzzzzzzzzzzzt_ = context.Operators.Union<Condition>(izzzzzzzzzzzzzzzq_, izzzzzzzzzzzzzzzs_);
        IEnumerable<Condition> izzzzzzzzzzzzzzzu_ = context.Operators.Union<Condition>(izzzzzzzzzzzzzzzo_, izzzzzzzzzzzzzzzt_);
        CqlValueSet izzzzzzzzzzzzzzzv_ = this.Multiple_Myeloma(context);
        IEnumerable<Condition> izzzzzzzzzzzzzzzw_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, izzzzzzzzzzzzzzzv_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        CqlValueSet izzzzzzzzzzzzzzzx_ = this.Premature_Menopause(context);
        IEnumerable<Condition> izzzzzzzzzzzzzzzy_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, izzzzzzzzzzzzzzzx_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        IEnumerable<Condition> izzzzzzzzzzzzzzzz_ = context.Operators.Union<Condition>(izzzzzzzzzzzzzzzw_, izzzzzzzzzzzzzzzy_);
        IEnumerable<Condition> jzzzzzzzzzzzzzzza_ = context.Operators.Union<Condition>(izzzzzzzzzzzzzzzu_, izzzzzzzzzzzzzzzz_);
        CqlValueSet jzzzzzzzzzzzzzzzb_ = this.Eating_Disorders(context);
        IEnumerable<Condition> jzzzzzzzzzzzzzzzc_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, jzzzzzzzzzzzzzzzb_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        CqlValueSet jzzzzzzzzzzzzzzzd_ = this.Amenorrhea(context);
        IEnumerable<Condition> jzzzzzzzzzzzzzzze_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, jzzzzzzzzzzzzzzzd_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        IEnumerable<Condition> jzzzzzzzzzzzzzzzf_ = context.Operators.Union<Condition>(jzzzzzzzzzzzzzzzc_, jzzzzzzzzzzzzzzze_);
        IEnumerable<Condition> jzzzzzzzzzzzzzzzg_ = context.Operators.Union<Condition>(jzzzzzzzzzzzzzzza_, jzzzzzzzzzzzzzzzf_);
        IEnumerable<Condition> jzzzzzzzzzzzzzzzh_ = this.diagnosisInPatientHistory(context, jzzzzzzzzzzzzzzzg_);
        bool? jzzzzzzzzzzzzzzzi_ = context.Operators.Exists<Condition>(jzzzzzzzzzzzzzzzh_);
        bool? jzzzzzzzzzzzzzzzj_ = context.Operators.Or(gzzzzzzzzzzzzzzzz_, jzzzzzzzzzzzzzzzi_);
        CqlValueSet jzzzzzzzzzzzzzzzk_ = this.Chemotherapy(context);
        IEnumerable<Procedure> jzzzzzzzzzzzzzzzl_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, jzzzzzzzzzzzzzzzk_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
        IEnumerable<Procedure> jzzzzzzzzzzzzzzzm_ = this.procedureInPatientHistory(context, jzzzzzzzzzzzzzzzl_);
        bool? jzzzzzzzzzzzzzzzn_ = context.Operators.Exists<Procedure>(jzzzzzzzzzzzzzzzm_);
        bool? jzzzzzzzzzzzzzzzo_ = context.Operators.Or(jzzzzzzzzzzzzzzzj_, jzzzzzzzzzzzzzzzn_);
        bool? jzzzzzzzzzzzzzzzp_ = this.Has_Double_or_Bilateral_Oophorectomy(context);
        bool? jzzzzzzzzzzzzzzzq_ = context.Operators.Or(jzzzzzzzzzzzzzzzo_, jzzzzzzzzzzzzzzzp_);
        bool? jzzzzzzzzzzzzzzzr_ = this.Has_Organ_Transplants(context);
        bool? jzzzzzzzzzzzzzzzs_ = context.Operators.Or(jzzzzzzzzzzzzzzzq_, jzzzzzzzzzzzzzzzr_);

        return jzzzzzzzzzzzzzzzs_;
    }


    [CqlExpressionDefinition("Denominator Exclusions")]
    public bool? Denominator_Exclusions(CqlContext context)
    {
        bool? jzzzzzzzzzzzzzzzt_ = this.Has_Risk_Factor_Active_During_the_Measurement_Period(context);
        bool? jzzzzzzzzzzzzzzzu_ = this.Has_Risk_Factor_Any_Time_in_History_Prior_to_Measurement_Period(context);
        bool? jzzzzzzzzzzzzzzzv_ = context.Operators.Or(jzzzzzzzzzzzzzzzt_, jzzzzzzzzzzzzzzzu_);
        bool? jzzzzzzzzzzzzzzzw_ = this.Has_Risk_Factor_Any_Time_in_History_or_During_Measurement_Period(context);
        bool? jzzzzzzzzzzzzzzzx_ = context.Operators.Or(jzzzzzzzzzzzzzzzv_, jzzzzzzzzzzzzzzzw_);

        return jzzzzzzzzzzzzzzzx_;
    }


    [CqlExpressionDefinition("DXA Scan Order During Measurement Period")]
    public IEnumerable<ServiceRequest> DXA_Scan_Order_During_Measurement_Period(CqlContext context)
    {
        CqlValueSet jzzzzzzzzzzzzzzzy_ = this.DXA__Dual_energy_Xray_Absorptiometry__Scan(context);
        IEnumerable<ServiceRequest> jzzzzzzzzzzzzzzzz_ = context.Operators.Retrieve<ServiceRequest>(new RetrieveParameters(default, jzzzzzzzzzzzzzzzy_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-servicerequest"));
        IEnumerable<ServiceRequest> kzzzzzzzzzzzzzzza_ = Status_1_8_000.Instance.isDiagnosticStudyOrder(context, jzzzzzzzzzzzzzzzz_);
        bool? kzzzzzzzzzzzzzzzb_(ServiceRequest DXA)
        {
            CqlInterval<CqlDateTime> kzzzzzzzzzzzzzzzf_ = this.Measurement_Period(context);
            FhirDateTime kzzzzzzzzzzzzzzzg_ = DXA?.AuthoredOnElement;
            CqlDateTime kzzzzzzzzzzzzzzzh_ = context.Operators.Convert<CqlDateTime>(kzzzzzzzzzzzzzzzg_);
            CqlInterval<CqlDateTime> kzzzzzzzzzzzzzzzi_ = QICoreCommon_2_1_000.Instance.toInterval(context, kzzzzzzzzzzzzzzzh_ as object);
            bool? kzzzzzzzzzzzzzzzj_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(kzzzzzzzzzzzzzzzf_, kzzzzzzzzzzzzzzzi_, default);

            return kzzzzzzzzzzzzzzzj_;
        };
        IEnumerable<ServiceRequest> kzzzzzzzzzzzzzzzc_ = context.Operators.Where<ServiceRequest>(kzzzzzzzzzzzzzzza_, kzzzzzzzzzzzzzzzb_);
        object kzzzzzzzzzzzzzzzd_(ServiceRequest @this)
        {
            FhirDateTime kzzzzzzzzzzzzzzzk_ = @this?.AuthoredOnElement;
            CqlDateTime kzzzzzzzzzzzzzzzl_ = context.Operators.Convert<CqlDateTime>(kzzzzzzzzzzzzzzzk_);

            return kzzzzzzzzzzzzzzzl_;
        };
        IEnumerable<ServiceRequest> kzzzzzzzzzzzzzzze_ = context.Operators.SortBy<ServiceRequest>(kzzzzzzzzzzzzzzzc_, kzzzzzzzzzzzzzzzd_, System.ComponentModel.ListSortDirection.Ascending);

        return kzzzzzzzzzzzzzzze_;
    }


    [CqlExpressionDefinition("Numerator")]
    public bool? Numerator(CqlContext context)
    {
        IEnumerable<ServiceRequest> kzzzzzzzzzzzzzzzm_ = this.DXA_Scan_Order_During_Measurement_Period(context);
        bool? kzzzzzzzzzzzzzzzn_ = context.Operators.Exists<ServiceRequest>(kzzzzzzzzzzzzzzzm_);

        return kzzzzzzzzzzzzzzzn_;
    }


    [CqlExpressionDefinition("Osteoporosis Fracture Risk Assessment Prior to First DXA Scan")]
    public IEnumerable<Observation> Osteoporosis_Fracture_Risk_Assessment_Prior_to_First_DXA_Scan(CqlContext context)
    {
        CqlCode kzzzzzzzzzzzzzzzo_ = this.Major_osteoporotic_fracture_10_year_probability__Likelihood__Fracture_Risk_Assessment(context);
        IEnumerable<CqlCode> kzzzzzzzzzzzzzzzp_ = context.Operators.ToList<CqlCode>(kzzzzzzzzzzzzzzzo_);
        IEnumerable<Observation> kzzzzzzzzzzzzzzzq_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, kzzzzzzzzzzzzzzzp_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
        IEnumerable<Observation> kzzzzzzzzzzzzzzzr_ = Status_1_8_000.Instance.isAssessmentPerformed(context, kzzzzzzzzzzzzzzzq_);
        bool? kzzzzzzzzzzzzzzzs_(Observation FRAX)
        {
            DataType lzzzzzzzzzzzzzzzr_ = FRAX?.Value;
            object lzzzzzzzzzzzzzzzs_ = FHIRHelpers_4_4_000.Instance.ToValue(context, lzzzzzzzzzzzzzzzr_);
            CqlQuantity lzzzzzzzzzzzzzzzt_ = context.Operators.Quantity(8.4m, "%");
            bool? lzzzzzzzzzzzzzzzu_ = context.Operators.GreaterOrEqual(lzzzzzzzzzzzzzzzs_ as CqlQuantity, lzzzzzzzzzzzzzzzt_);

            return lzzzzzzzzzzzzzzzu_;
        };
        IEnumerable<Observation> kzzzzzzzzzzzzzzzt_ = context.Operators.Where<Observation>(kzzzzzzzzzzzzzzzr_, kzzzzzzzzzzzzzzzs_);
        CqlCode kzzzzzzzzzzzzzzzu_ = this.Osteoporosis_Risk_Assessment_Instrument(context);
        IEnumerable<CqlCode> kzzzzzzzzzzzzzzzv_ = context.Operators.ToList<CqlCode>(kzzzzzzzzzzzzzzzu_);
        IEnumerable<Observation> kzzzzzzzzzzzzzzzw_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, kzzzzzzzzzzzzzzzv_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
        IEnumerable<Observation> kzzzzzzzzzzzzzzzx_ = Status_1_8_000.Instance.isAssessmentPerformed(context, kzzzzzzzzzzzzzzzw_);
        bool? kzzzzzzzzzzzzzzzy_(Observation ORAI)
        {
            DataType lzzzzzzzzzzzzzzzv_ = ORAI?.Value;
            object lzzzzzzzzzzzzzzzw_ = FHIRHelpers_4_4_000.Instance.ToValue(context, lzzzzzzzzzzzzzzzv_);
            bool? lzzzzzzzzzzzzzzzx_ = context.Operators.GreaterOrEqual(lzzzzzzzzzzzzzzzw_ as int?, 9);

            return lzzzzzzzzzzzzzzzx_;
        };
        IEnumerable<Observation> kzzzzzzzzzzzzzzzz_ = context.Operators.Where<Observation>(kzzzzzzzzzzzzzzzx_, kzzzzzzzzzzzzzzzy_);
        IEnumerable<Observation> lzzzzzzzzzzzzzzza_ = context.Operators.Union<Observation>(kzzzzzzzzzzzzzzzt_, kzzzzzzzzzzzzzzzz_);
        CqlCode lzzzzzzzzzzzzzzzb_ = this.Osteoporosis_Index_of_Risk_panel(context);
        IEnumerable<CqlCode> lzzzzzzzzzzzzzzzc_ = context.Operators.ToList<CqlCode>(lzzzzzzzzzzzzzzzb_);
        IEnumerable<Observation> lzzzzzzzzzzzzzzzd_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, lzzzzzzzzzzzzzzzc_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
        IEnumerable<Observation> lzzzzzzzzzzzzzzze_ = Status_1_8_000.Instance.isAssessmentPerformed(context, lzzzzzzzzzzzzzzzd_);
        bool? lzzzzzzzzzzzzzzzf_(Observation OSIRIS)
        {
            DataType lzzzzzzzzzzzzzzzy_ = OSIRIS?.Value;
            object lzzzzzzzzzzzzzzzz_ = FHIRHelpers_4_4_000.Instance.ToValue(context, lzzzzzzzzzzzzzzzy_);
            CqlQuantity mzzzzzzzzzzzzzzza_ = context.Operators.ConvertDecimalToQuantity(1.0m);
            bool? mzzzzzzzzzzzzzzzb_ = context.Operators.Less(lzzzzzzzzzzzzzzzz_ as CqlQuantity, mzzzzzzzzzzzzzzza_);

            return mzzzzzzzzzzzzzzzb_;
        };
        IEnumerable<Observation> lzzzzzzzzzzzzzzzg_ = context.Operators.Where<Observation>(lzzzzzzzzzzzzzzze_, lzzzzzzzzzzzzzzzf_);
        CqlCode lzzzzzzzzzzzzzzzh_ = this.Osteoporosis_Self_Assessment_Tool(context);
        IEnumerable<CqlCode> lzzzzzzzzzzzzzzzi_ = context.Operators.ToList<CqlCode>(lzzzzzzzzzzzzzzzh_);
        IEnumerable<Observation> lzzzzzzzzzzzzzzzj_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, lzzzzzzzzzzzzzzzi_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
        IEnumerable<Observation> lzzzzzzzzzzzzzzzk_ = Status_1_8_000.Instance.isAssessmentPerformed(context, lzzzzzzzzzzzzzzzj_);
        bool? lzzzzzzzzzzzzzzzl_(Observation OST)
        {
            DataType mzzzzzzzzzzzzzzzc_ = OST?.Value;
            object mzzzzzzzzzzzzzzzd_ = FHIRHelpers_4_4_000.Instance.ToValue(context, mzzzzzzzzzzzzzzzc_);
            CqlQuantity mzzzzzzzzzzzzzzze_ = context.Operators.ConvertDecimalToQuantity(2.0m);
            bool? mzzzzzzzzzzzzzzzf_ = context.Operators.Less(mzzzzzzzzzzzzzzzd_ as CqlQuantity, mzzzzzzzzzzzzzzze_);

            return mzzzzzzzzzzzzzzzf_;
        };
        IEnumerable<Observation> lzzzzzzzzzzzzzzzm_ = context.Operators.Where<Observation>(lzzzzzzzzzzzzzzzk_, lzzzzzzzzzzzzzzzl_);
        IEnumerable<Observation> lzzzzzzzzzzzzzzzn_ = context.Operators.Union<Observation>(lzzzzzzzzzzzzzzzg_, lzzzzzzzzzzzzzzzm_);
        IEnumerable<Observation> lzzzzzzzzzzzzzzzo_ = context.Operators.Union<Observation>(lzzzzzzzzzzzzzzza_, lzzzzzzzzzzzzzzzn_);
        bool? lzzzzzzzzzzzzzzzp_(Observation RiskAssessment)
        {
            DataType mzzzzzzzzzzzzzzzg_ = RiskAssessment?.Effective;
            object mzzzzzzzzzzzzzzzh_ = FHIRHelpers_4_4_000.Instance.ToValue(context, mzzzzzzzzzzzzzzzg_);
            CqlInterval<CqlDateTime> mzzzzzzzzzzzzzzzi_ = QICoreCommon_2_1_000.Instance.toInterval(context, mzzzzzzzzzzzzzzzh_);
            CqlDateTime mzzzzzzzzzzzzzzzj_ = context.Operators.Start(mzzzzzzzzzzzzzzzi_);
            IEnumerable<ServiceRequest> mzzzzzzzzzzzzzzzk_ = this.DXA_Scan_Order_During_Measurement_Period(context);
            ServiceRequest mzzzzzzzzzzzzzzzl_ = context.Operators.First<ServiceRequest>(mzzzzzzzzzzzzzzzk_);
            FhirDateTime mzzzzzzzzzzzzzzzm_ = mzzzzzzzzzzzzzzzl_?.AuthoredOnElement;
            CqlDateTime mzzzzzzzzzzzzzzzn_ = context.Operators.Convert<CqlDateTime>(mzzzzzzzzzzzzzzzm_);
            bool? mzzzzzzzzzzzzzzzo_ = context.Operators.Before(mzzzzzzzzzzzzzzzj_, mzzzzzzzzzzzzzzzn_, default);

            return mzzzzzzzzzzzzzzzo_;
        };
        IEnumerable<Observation> lzzzzzzzzzzzzzzzq_ = context.Operators.Where<Observation>(lzzzzzzzzzzzzzzzo_, lzzzzzzzzzzzzzzzp_);

        return lzzzzzzzzzzzzzzzq_;
    }


    [CqlExpressionDefinition("Numerator Exclusion")]
    public bool? Numerator_Exclusion(CqlContext context)
    {
        IEnumerable<Observation> mzzzzzzzzzzzzzzzp_ = this.Osteoporosis_Fracture_Risk_Assessment_Prior_to_First_DXA_Scan(context);
        bool? mzzzzzzzzzzzzzzzq_ = context.Operators.Exists<Observation>(mzzzzzzzzzzzzzzzp_);

        return mzzzzzzzzzzzzzzzq_;
    }


    #endregion Expressions

}

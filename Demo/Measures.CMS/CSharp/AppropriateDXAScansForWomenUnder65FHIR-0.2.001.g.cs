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
    private static readonly CqlCode _Alcoholic_drinks_per_day = new CqlCode("74013-4", "http://loinc.org", default, default);

    [CqlCodeDefinition("Body mass index (BMI) [Ratio]", codeId: "39156-5", codeSystem: "http://loinc.org")]
    public CqlCode Body_mass_index__BMI___Ratio_(CqlContext _) => _Body_mass_index__BMI___Ratio_;
    private static readonly CqlCode _Body_mass_index__BMI___Ratio_ = new CqlCode("39156-5", "http://loinc.org", default, default);

    [CqlCodeDefinition("Female", codeId: "F", codeSystem: "http://terminology.hl7.org/CodeSystem/v3-AdministrativeGender")]
    public CqlCode Female(CqlContext _) => _Female;
    private static readonly CqlCode _Female = new CqlCode("F", "http://terminology.hl7.org/CodeSystem/v3-AdministrativeGender", default, default);

    [CqlCodeDefinition("Left (qualifier value)", codeId: "7771000", codeSystem: "http://snomed.info/sct")]
    public CqlCode Left__qualifier_value_(CqlContext _) => _Left__qualifier_value_;
    private static readonly CqlCode _Left__qualifier_value_ = new CqlCode("7771000", "http://snomed.info/sct", default, default);

    [CqlCodeDefinition("Major osteoporotic fracture 10-year probability [Likelihood] Fracture Risk Assessment", codeId: "90265-0", codeSystem: "http://loinc.org")]
    public CqlCode Major_osteoporotic_fracture_10_year_probability__Likelihood__Fracture_Risk_Assessment(CqlContext _) => _Major_osteoporotic_fracture_10_year_probability__Likelihood__Fracture_Risk_Assessment;
    private static readonly CqlCode _Major_osteoporotic_fracture_10_year_probability__Likelihood__Fracture_Risk_Assessment = new CqlCode("90265-0", "http://loinc.org", default, default);

    [CqlCodeDefinition("Osteoporosis Index of Risk panel", codeId: "98133-2", codeSystem: "http://loinc.org")]
    public CqlCode Osteoporosis_Index_of_Risk_panel(CqlContext _) => _Osteoporosis_Index_of_Risk_panel;
    private static readonly CqlCode _Osteoporosis_Index_of_Risk_panel = new CqlCode("98133-2", "http://loinc.org", default, default);

    [CqlCodeDefinition("Osteoporosis Risk Assessment Instrument", codeId: "98139-9", codeSystem: "http://loinc.org")]
    public CqlCode Osteoporosis_Risk_Assessment_Instrument(CqlContext _) => _Osteoporosis_Risk_Assessment_Instrument;
    private static readonly CqlCode _Osteoporosis_Risk_Assessment_Instrument = new CqlCode("98139-9", "http://loinc.org", default, default);

    [CqlCodeDefinition("Osteoporosis Self-Assessment Tool", codeId: "98146-4", codeSystem: "http://loinc.org")]
    public CqlCode Osteoporosis_Self_Assessment_Tool(CqlContext _) => _Osteoporosis_Self_Assessment_Tool;
    private static readonly CqlCode _Osteoporosis_Self_Assessment_Tool = new CqlCode("98146-4", "http://loinc.org", default, default);

    [CqlCodeDefinition("Right (qualifier value)", codeId: "24028007", codeSystem: "http://snomed.info/sct")]
    public CqlCode Right__qualifier_value_(CqlContext _) => _Right__qualifier_value_;
    private static readonly CqlCode _Right__qualifier_value_ = new CqlCode("24028007", "http://snomed.info/sct", default, default);

    [CqlCodeDefinition("Unlisted preventive medicine service", codeId: "99429", codeSystem: "http://www.ama-assn.org/go/cpt")]
    public CqlCode Unlisted_preventive_medicine_service(CqlContext _) => _Unlisted_preventive_medicine_service;
    private static readonly CqlCode _Unlisted_preventive_medicine_service = new CqlCode("99429", "http://www.ama-assn.org/go/cpt", default, default);

    #endregion Codes

    #region CodeSystems

    [CqlCodeSystemDefinition("LOINC")]
    public CqlCodeSystem LOINC(CqlContext _) => _LOINC;
    private static readonly CqlCodeSystem _LOINC = new CqlCodeSystem();

    [CqlCodeSystemDefinition("AdministrativeGender")]
    public CqlCodeSystem AdministrativeGender(CqlContext _) => _AdministrativeGender;
    private static readonly CqlCodeSystem _AdministrativeGender = new CqlCodeSystem();

    [CqlCodeSystemDefinition("SNOMEDCT")]
    public CqlCodeSystem SNOMEDCT(CqlContext _) => _SNOMEDCT;
    private static readonly CqlCodeSystem _SNOMEDCT = new CqlCodeSystem();

    [CqlCodeSystemDefinition("CPT")]
    public CqlCodeSystem CPT(CqlContext _) => _CPT;
    private static readonly CqlCodeSystem _CPT = new CqlCodeSystem();

    #endregion CodeSystems

    #region Parameters

    [CqlParameterDefinition("Measurement Period")]
    public CqlInterval<CqlDateTime> Measurement_Period(CqlContext context)
    {
        CqlDateTime qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.DateTime(2025, 1, 1, 0, 0, 0, 0, 0.0m);
        CqlDateTime qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.DateTime(2025, 12, 31, 23, 59, 59, 999, 0.0m);
        CqlInterval<CqlDateTime> qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Interval(qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_, qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_, true, true);
        object qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.ResolveParameter("AppropriateDXAScansForWomenUnder65FHIR-0.2.001", "Measurement Period", qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_);

        return (CqlInterval<CqlDateTime>)qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_;
    }


    #endregion Parameters

    #region Expressions

    [CqlExpressionDefinition("Patient")]
    public Patient Patient(CqlContext context)
    {
        IEnumerable<Patient> qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-patient"));
        Patient qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.SingletonFrom<Patient>(qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_);

        return qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_;
    }


    [CqlExpressionDefinition("SDE Ethnicity")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Ethnicity(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = SupplementalDataElements_3_5_000.Instance.SDE_Ethnicity(context);

        return qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_;
    }


    [CqlExpressionDefinition("SDE Payer")]
    public IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> SDE_Payer(CqlContext context)
    {
        IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = SupplementalDataElements_3_5_000.Instance.SDE_Payer(context);

        return qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_;
    }


    [CqlExpressionDefinition("SDE Race")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Race(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = SupplementalDataElements_3_5_000.Instance.SDE_Race(context);

        return rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_;
    }


    [CqlExpressionDefinition("SDE Sex")]
    public CqlCode SDE_Sex(CqlContext context)
    {
        CqlCode rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = SupplementalDataElements_3_5_000.Instance.SDE_Sex(context);

        return rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_;
    }


    [CqlExpressionDefinition("Qualifying Encounter")]
    public IEnumerable<Encounter> Qualifying_Encounter(CqlContext context)
    {
        CqlValueSet rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = this.Office_Visit(context);
        IEnumerable<Encounter> rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        CqlValueSet rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = this.Preventive_Care_Services_Established_Office_Visit__18_and_Up(context);
        IEnumerable<Encounter> rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Union<Encounter>(rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_, rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_);
        IEnumerable<Encounter> rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        bool? rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_(Encounter E)
        {
            List<CodeableConcept> szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = E?.Type;
            CqlConcept szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_(CodeableConcept @this)
            {
                CqlConcept szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);

                return szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_;
            };
            IEnumerable<CqlConcept> szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_, szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_);
            bool? szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_(CqlConcept T)
            {
                CqlCode szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = this.Unlisted_preventive_medicine_service(context);
                CqlConcept szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.ConvertCodeToConcept(szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_);
                bool? szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Equivalent(T, szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_);

                return szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_;
            };
            IEnumerable<CqlConcept> szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.Where<CqlConcept>(szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_, szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_);
            bool? szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Exists<CqlConcept>(szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_);

            return szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_;
        };
        IEnumerable<Encounter> rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Where<Encounter>(rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_, rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_);
        CqlValueSet rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = this.Preventive_Care_Services_Initial_Office_Visit__18_and_Up(context);
        IEnumerable<Encounter> rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Union<Encounter>(rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_, rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_);
        IEnumerable<Encounter> rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Union<Encounter>(rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_, rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_);
        CqlValueSet rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = this.Outpatient_Consultation(context);
        IEnumerable<Encounter> rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        CqlValueSet rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = this.Virtual_Encounter(context);
        IEnumerable<Encounter> rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Union<Encounter>(rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_, rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_);
        IEnumerable<Encounter> rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Union<Encounter>(rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_, rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_);
        CqlValueSet rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = this.Telephone_Visits(context);
        IEnumerable<Encounter> rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Union<Encounter>(rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_, rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_);
        IEnumerable<Encounter> rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = Status_1_8_000.Instance.isEncounterPerformed(context, rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_);
        bool? rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_(Encounter ValidEncounters)
        {
            CqlInterval<CqlDateTime> szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = this.Measurement_Period(context);
            Period szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = ValidEncounters?.Period;
            CqlInterval<CqlDateTime> szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_);
            CqlInterval<CqlDateTime> szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = QICoreCommon_2_1_000.Instance.toInterval(context, szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ as object);
            bool? szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_, szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_, "day");

            return szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_;
        };
        IEnumerable<Encounter> rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Where<Encounter>(rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_, rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_);

        return rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_;
    }


    [CqlExpressionDefinition("Initial Population")]
    public bool? Initial_Population(CqlContext context)
    {
        Patient szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = this.Patient(context);
        Date szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_?.BirthDateElement;
        string szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_?.Value;
        CqlDate szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.ConvertStringToDate(szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_);
        CqlInterval<CqlDateTime> szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = this.Measurement_Period(context);
        CqlDateTime szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Start(szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_);
        CqlDate szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.DateFrom(szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_);
        int? szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.CalculateAgeAt(szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_, szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_, "year");
        CqlInterval<int?> szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Interval(50, 63, true, true);
        bool? szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.In<int?>(szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_, szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_, default);
        Code<AdministrativeGender> tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_?.GenderElement;
        AdministrativeGender? tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_?.Value;
        string tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Convert<string>(tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_);
        bool? tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Equal(tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_, "female");
        bool? tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.And(szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_, tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_);
        IEnumerable<Encounter> tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = this.Qualifying_Encounter(context);
        bool? tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Exists<Encounter>(tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_);
        bool? tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.And(tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_, tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_);

        return tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_;
    }


    [CqlExpressionDefinition("Denominator")]
    public bool? Denominator(CqlContext context)
    {
        bool? tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = this.Initial_Population(context);

        return tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_;
    }


    [CqlExpressionDefinition("First BMI in Measurement Period")]
    public Observation First_BMI_in_Measurement_Period(CqlContext context)
    {
        IEnumerable<Observation> tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/StructureDefinition/bmi"));
        IEnumerable<Observation> tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = Status_1_8_000.Instance.isObservationBMI(context, tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_);
        bool? tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_(Observation BMIRatio)
        {
            CqlInterval<CqlDateTime> tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = this.Measurement_Period(context);
            DataType tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = BMIRatio?.Effective;
            object tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = FHIRHelpers_4_4_000.Instance.ToValue(context, tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_);
            CqlInterval<CqlDateTime> tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = QICoreCommon_2_1_000.Instance.toInterval(context, tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_);
            bool? tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_, tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_, default);
            DataType tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = BMIRatio?.Value;
            CqlQuantity tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = FHIRHelpers_4_4_000.Instance.ToQuantity(context, tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ as Quantity);
            bool? tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Not((bool?)((tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ as CqlQuantity) is null));
            bool? tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.And(tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_, tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_);

            return tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_;
        };
        IEnumerable<Observation> tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Where<Observation>(tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_, tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_);
        object tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_(Observation @this)
        {
            DataType tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = @this?.Effective;
            object uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = FHIRHelpers_4_4_000.Instance.ToValue(context, tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_);
            CqlInterval<CqlDateTime> uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = QICoreCommon_2_1_000.Instance.toInterval(context, uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_);
            CqlDateTime uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Start(uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_);

            return uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_;
        };
        IEnumerable<Observation> tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.SortBy<Observation>(tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_, tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_, System.ComponentModel.ListSortDirection.Ascending);
        Observation tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.First<Observation>(tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_);

        return tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_;
    }


    [CqlExpressionDefinition("First BMI in Measurement Period Less Than or Equal to 20 kg m2")]
    public Observation First_BMI_in_Measurement_Period_Less_Than_or_Equal_to_20_kg_m2(CqlContext context)
    {
        Observation uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = this.First_BMI_in_Measurement_Period(context);
        Observation[] uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = [
            uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_,
        ];
        bool? uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_(Observation FirstBMI)
        {
            DataType uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = FirstBMI?.Value;
            CqlQuantity uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = FHIRHelpers_4_4_000.Instance.ToQuantity(context, uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ as Quantity);
            CqlQuantity uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Quantity(20m, "kg/m2");
            bool? uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.LessOrEqual(uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ as CqlQuantity, uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_);

            return uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_;
        };
        IEnumerable<Observation> uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Where<Observation>((IEnumerable<Observation>)uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_, uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_);
        Observation uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.SingletonFrom<Observation>(uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_);

        return uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_;
    }


    [CqlExpressionDefinition("First Average Number of Drinks Assessments Indicating More Than Two Per Day")]
    public Observation First_Average_Number_of_Drinks_Assessments_Indicating_More_Than_Two_Per_Day(CqlContext context)
    {
        CqlCode uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = this.Alcoholic_drinks_per_day(context);
        IEnumerable<CqlCode> uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.ToList<CqlCode>(uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_);
        IEnumerable<Observation> uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
        IEnumerable<Observation> uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = Status_1_8_000.Instance.isAssessmentPerformed(context, uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_);
        bool? uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_(Observation AverageDrinks)
        {
            DataType uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = AverageDrinks?.Effective;
            object uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = FHIRHelpers_4_4_000.Instance.ToValue(context, uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_);
            CqlInterval<CqlDateTime> uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = QICoreCommon_2_1_000.Instance.toInterval(context, uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_);
            CqlDateTime uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Start(uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_);
            CqlInterval<CqlDateTime> uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = this.Measurement_Period(context);
            bool? vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.In<CqlDateTime>(uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_, uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_, default);
            DataType vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = AverageDrinks?.Value;
            object vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = FHIRHelpers_4_4_000.Instance.ToValue(context, vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_);
            CqlQuantity vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Quantity(2m, "{drinks}/d");
            bool? vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.Greater(vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ as CqlQuantity, vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_);
            bool? vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.And(vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_, vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_);

            return vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_;
        };
        IEnumerable<Observation> uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Where<Observation>(uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_, uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_);
        object uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_(Observation @this)
        {
            DataType vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = @this?.Effective;
            object vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = FHIRHelpers_4_4_000.Instance.ToValue(context, vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_);
            CqlInterval<CqlDateTime> vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = QICoreCommon_2_1_000.Instance.toInterval(context, vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_);
            CqlDateTime vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Start(vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_);

            return vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_;
        };
        IEnumerable<Observation> uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.SortBy<Observation>(uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_, uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_, System.ComponentModel.ListSortDirection.Ascending);
        Observation uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.First<Observation>(uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_);

        return uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_;
    }


    [CqlExpressionDefinition("Has Risk Factor Active During the Measurement Period")]
    public bool? Has_Risk_Factor_Active_During_the_Measurement_Period(CqlContext context)
    {
        Observation vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = this.First_BMI_in_Measurement_Period_Less_Than_or_Equal_to_20_kg_m2(context);
        bool? vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Not((bool?)(vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ is null));
        Observation vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = this.First_Average_Number_of_Drinks_Assessments_Indicating_More_Than_Two_Per_Day(context);
        bool? vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Not((bool?)(vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ is null));
        bool? vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Or(vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_, vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_);

        return vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_;
    }


    [CqlExpressionDefinition("Has Risk Factor Any Time in History Prior to Measurement Period")]
    public bool? Has_Risk_Factor_Any_Time_in_History_Prior_to_Measurement_Period(CqlContext context)
    {
        CqlValueSet vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = this.Osteoporosis_Without_Current_Fracture(context);
        IEnumerable<Condition> vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        bool? vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_(Condition OsteoporosisDiagnosis)
        {
            CqlInterval<CqlDateTime> xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = QICoreCommon_2_1_000.Instance.prevalenceInterval(context, OsteoporosisDiagnosis);
            CqlDateTime xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.Start(xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_);
            CqlInterval<CqlDateTime> xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = this.Measurement_Period(context);
            CqlDateTime xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Start(xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_);
            bool? xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Before(xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_, xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_, default);

            return xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_;
        };
        IEnumerable<Condition> vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Where<Condition>(vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_, vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_);
        CqlValueSet vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = this.Osteopenia(context);
        IEnumerable<Condition> vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        bool? vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_(Condition OsteopeniaDiagnosis)
        {
            CqlInterval<CqlDateTime> xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = QICoreCommon_2_1_000.Instance.prevalenceInterval(context, OsteopeniaDiagnosis);
            CqlDateTime xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Start(xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_);
            CqlInterval<CqlDateTime> xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = this.Measurement_Period(context);
            CqlDateTime xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Start(xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_);
            bool? xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Before(xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_, xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_, default);

            return xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_;
        };
        IEnumerable<Condition> vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Where<Condition>(vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_, vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_);
        IEnumerable<Condition> vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Union<Condition>(vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_, vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_);
        CqlValueSet vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = this.Gastric_Bypass_Surgery(context);
        IEnumerable<Procedure> vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
        IEnumerable<Procedure> wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = Status_1_8_000.Instance.isProcedurePerformed(context, vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_);
        bool? wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_(Procedure GastricBypass)
        {
            DataType xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = GastricBypass?.Performed;
            object xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = FHIRHelpers_4_4_000.Instance.ToValue(context, xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_);
            CqlInterval<CqlDateTime> xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = QICoreCommon_2_1_000.Instance.toInterval(context, xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_);
            CqlDateTime xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.End(xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_);
            CqlInterval<CqlDateTime> xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = this.Measurement_Period(context);
            CqlDateTime xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Start(xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_);
            bool? xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Before(xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_, xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_, default);

            return xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_;
        };
        IEnumerable<Procedure> wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Where<Procedure>(wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_, wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_);
        CqlValueSet wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = this.Aromatase_Inhibitors(context);
        IEnumerable<MedicationRequest> wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Union<MedicationRequest>(wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_, wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_);
        IEnumerable<MedicationRequest> wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = Status_1_8_000.Instance.isMedicationActive(context, wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_);
        bool? wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_(MedicationRequest AromataseInhibitorActive)
        {
            CqlInterval<CqlDate> xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = CumulativeMedicationDuration_4_1_000.Instance.MedicationRequestPeriod(context, AromataseInhibitorActive);
            CqlDate xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Start(xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_);
            CqlDateTime xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.ConvertDateToDateTime(xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_);
            CqlInterval<CqlDateTime> xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = this.Measurement_Period(context);
            CqlDateTime xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Start(xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_);
            bool? xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Before(xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_, xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_, default);

            return xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_;
        };
        IEnumerable<MedicationRequest> wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Where<MedicationRequest>(wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_, wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_);
        IEnumerable<object> wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Union<object>(wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ as IEnumerable<object>, wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ as IEnumerable<object>);
        IEnumerable<MedicationRequest> wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Union<MedicationRequest>(wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_, wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_);
        IEnumerable<MedicationRequest> wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = Status_1_8_000.Instance.isMedicationOrder(context, wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_);
        bool? wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_(MedicationRequest AromataseInhibitorOrder)
        {
            FhirDateTime yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = AromataseInhibitorOrder?.AuthoredOnElement;
            CqlDateTime yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Convert<CqlDateTime>(yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_);
            CqlInterval<CqlDateTime> yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = QICoreCommon_2_1_000.Instance.toInterval(context, yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ as object);
            CqlInterval<CqlDateTime> yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_()
            {
                bool yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_()
                {
                    CqlInterval<CqlDateTime> yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = this.Measurement_Period(context);
                    CqlDateTime yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Start(yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_);

                    return yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ is null;
                };
                if (yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_())
                {
                    return default;
                }
                else
                {
                    CqlInterval<CqlDateTime> yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = this.Measurement_Period(context);
                    CqlDateTime yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Start(yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_);
                    CqlDateTime yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Start(yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_);
                    CqlInterval<CqlDateTime> yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Interval(yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_, yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_, true, true);

                    return yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_;
                }
            };
            bool? yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.Before(yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_, yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_(), default);

            return yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_;
        };
        IEnumerable<MedicationRequest> wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Where<MedicationRequest>(wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_, wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_);
        IEnumerable<object> wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Union<object>(wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ as IEnumerable<object>, wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ as IEnumerable<object>);
        CqlValueSet wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = this.History_of_hip_fracture_in_parent(context);
        IEnumerable<Observation> wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
        IEnumerable<Observation> wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = Status_1_8_000.Instance.isAssessmentPerformed(context, wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_);
        bool? wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_(Observation ParentFractureHistory)
        {
            DataType yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = ParentFractureHistory?.Effective;
            object yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = FHIRHelpers_4_4_000.Instance.ToValue(context, yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_);
            CqlInterval<CqlDateTime> yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = QICoreCommon_2_1_000.Instance.toInterval(context, yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_);
            CqlDateTime yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Start(yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_);
            CqlInterval<CqlDateTime> yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = this.Measurement_Period(context);
            CqlDateTime yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Start(yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_);
            bool? yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Before(yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_, yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_, default);

            return yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_;
        };
        IEnumerable<Observation> wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Where<Observation>(wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_, wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_);
        IEnumerable<object> xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.Union<object>(wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ as IEnumerable<object>, wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ as IEnumerable<object>);
        IEnumerable<object> xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Union<object>(vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ as IEnumerable<object>, xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ as IEnumerable<object>);
        bool? xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Exists<object>(xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_);

        return xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_;
    }


    [CqlExpressionDefinition("Glucocorticoid Active Medication Days")]
    public int? Glucocorticoid_Active_Medication_Days(CqlContext context)
    {
        CqlValueSet yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = this.Glucocorticoids__oral_only_(context);
        IEnumerable<MedicationRequest> yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Union<MedicationRequest>(yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_, yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_);
        IEnumerable<MedicationRequest> yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = Status_1_8_000.Instance.isMedicationActive(context, yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_);
        bool? zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_(MedicationRequest OralGlucocorticoid)
        {
            CqlInterval<CqlDate> zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = CumulativeMedicationDuration_4_1_000.Instance.medicationRequestPeriod(context, OralGlucocorticoid);
            CqlDate zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Start(zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_);
            CqlDateTime zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.ConvertDateToDateTime(zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_);
            CqlInterval<CqlDateTime> zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = this.Measurement_Period(context);
            CqlDateTime zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.End(zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_);
            bool? zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Before(zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_, zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_, default);

            return zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_;
        };
        IEnumerable<MedicationRequest> zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Where<MedicationRequest>(yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_, zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_);
        CqlInterval<CqlDate> zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_(MedicationRequest Glucocorticoid)
        {
            CqlInterval<CqlDate> zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = CumulativeMedicationDuration_4_1_000.Instance.medicationRequestPeriod(context, Glucocorticoid);
            Patient zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = this.Patient(context);
            Date zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_?.BirthDateElement;
            string zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_?.Value;
            CqlDate zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.ConvertStringToDate(zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_);
            CqlInterval<CqlDateTime> zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = this.Measurement_Period(context);
            CqlDateTime zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.End(zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_);
            CqlDate zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.DateFrom(zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_);
            CqlInterval<CqlDate> zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Interval(zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_, zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_, true, true);
            CqlInterval<CqlDate> zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Intersect<CqlDate>(zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_, zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_);

            return zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_;
        };
        IEnumerable<CqlInterval<CqlDate>> zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Select<MedicationRequest, CqlInterval<CqlDate>>(zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_, zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_);
        IEnumerable<CqlInterval<CqlDate>> zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.Distinct<CqlInterval<CqlDate>>(zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_);
        int? zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = CumulativeMedicationDuration_4_1_000.Instance.cumulativeDuration(context, zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_);

        return zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_;
    }


    [CqlExpressionDefinition("Has 90 or More Active Glucocorticoid Medication Days")]
    public bool? Has_90_or_More_Active_Glucocorticoid_Medication_Days(CqlContext context)
    {
        int? zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = this.Glucocorticoid_Active_Medication_Days(context);
        bool? zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.GreaterOrEqual(zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_, 90);

        return zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_;
    }


    [CqlExpressionDefinition("diagnosisInPatientHistory")]
    public IEnumerable<Condition> diagnosisInPatientHistory(CqlContext context, IEnumerable<Condition> Condition)
    {
        bool? zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_(Condition Dx)
        {
            CqlInterval<CqlDateTime> azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = QICoreCommon_2_1_000.Instance.prevalenceInterval(context, Dx);
            CqlDateTime azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Start(azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_);
            CqlInterval<CqlDateTime> azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = this.Measurement_Period(context);
            CqlDateTime azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.End(azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_);
            bool? azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.SameOrBefore(azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_, azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_, "day");

            return azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_;
        };
        IEnumerable<Condition> zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Where<Condition>(Condition, zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_);

        return zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_;
    }


    [CqlExpressionDefinition("procedureInPatientHistory")]
    public IEnumerable<Procedure> procedureInPatientHistory(CqlContext context, IEnumerable<Procedure> Procedure)
    {
        IEnumerable<Procedure> azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = Status_1_8_000.Instance.isProcedurePerformed(context, Procedure);
        bool? azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_(Procedure Proc)
        {
            DataType azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = Proc?.Performed;
            object azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_);
            CqlInterval<CqlDateTime> azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = QICoreCommon_2_1_000.Instance.toInterval(context, azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_);
            CqlDateTime azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.End(azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_);
            CqlInterval<CqlDateTime> azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = this.Measurement_Period(context);
            CqlDateTime azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.End(azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_);
            bool? azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.SameOrBefore(azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_, azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_, "day");

            return azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_;
        };
        IEnumerable<Procedure> azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Where<Procedure>(azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_, azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_);

        return azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_;
    }


    [CqlExpressionDefinition("Has Double or Bilateral Oophorectomy")]
    public bool? Has_Double_or_Bilateral_Oophorectomy(CqlContext context)
    {
        CqlValueSet azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = this.Bilateral_Oophorectomy(context);
        IEnumerable<Procedure> azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
        IEnumerable<Procedure> azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = this.procedureInPatientHistory(context, azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_);
        bool? azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Exists<Procedure>(azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_);
        CqlValueSet azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = this.Evidence_of_Bilateral_Oophorectomy(context);
        IEnumerable<Procedure> azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
        IEnumerable<Procedure> azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = this.procedureInPatientHistory(context, azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_);
        bool? azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Exists<Procedure>(azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_);
        bool? azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Or(azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_, azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_);
        CqlValueSet azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = this.Unilateral_Oophorectomy__Unspecified_Laterality(context);
        IEnumerable<Procedure> azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
        bool? bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_(Procedure UnilateralOophorectomy)
        {
            List<CodeableConcept> bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = UnilateralOophorectomy?.BodySite;
            CqlConcept bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_(CodeableConcept @this)
            {
                CqlConcept bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);

                return bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_;
            };
            IEnumerable<CqlConcept> bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_, bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_);
            bool? bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_(CqlConcept C)
            {
                CqlCode bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = this.Right__qualifier_value_(context);
                CqlConcept czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.ConvertCodeToConcept(bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_);
                bool? czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Equivalent(C, czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_);

                return czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_;
            };
            IEnumerable<CqlConcept> bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Where<CqlConcept>(bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_, bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_);
            bool? bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Exists<CqlConcept>(bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_);

            return bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_;
        };
        IEnumerable<Procedure> bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Where<Procedure>(azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_, bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_);
        CqlValueSet bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = this.Unilateral_Oophorectomy_Right(context);
        IEnumerable<Procedure> bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
        IEnumerable<Procedure> bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.Union<Procedure>(bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_, bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_);
        IEnumerable<Procedure> bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = this.procedureInPatientHistory(context, bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_);
        bool? bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Exists<Procedure>(bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_);
        IEnumerable<Procedure> bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
        bool? bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_(Procedure UnilateralOophorectomy)
        {
            List<CodeableConcept> czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = UnilateralOophorectomy?.BodySite;
            CqlConcept czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_(CodeableConcept @this)
            {
                CqlConcept czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);

                return czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_;
            };
            IEnumerable<CqlConcept> czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_, czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_);
            bool? czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_(CqlConcept D)
            {
                CqlCode czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = this.Left__qualifier_value_(context);
                CqlConcept czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.ConvertCodeToConcept(czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_);
                bool? czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Equivalent(D, czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_);

                return czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_;
            };
            IEnumerable<CqlConcept> czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Where<CqlConcept>(czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_, czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_);
            bool? czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Exists<CqlConcept>(czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_);

            return czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_;
        };
        IEnumerable<Procedure> bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Where<Procedure>(bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_, bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_);
        CqlValueSet bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = this.Unilateral_Oophorectomy_Left(context);
        IEnumerable<Procedure> bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
        IEnumerable<Procedure> bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Union<Procedure>(bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_, bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_);
        IEnumerable<Procedure> bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = this.procedureInPatientHistory(context, bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_);
        bool? bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Exists<Procedure>(bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_);
        bool? bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.And(bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_, bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_);
        bool? bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Or(azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_, bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_);

        return bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_;
    }


    [CqlExpressionDefinition("Has Organ Transplants")]
    public bool? Has_Organ_Transplants(CqlContext context)
    {
        CqlValueSet czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = this.Major_Transplant(context);
        IEnumerable<Procedure> czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
        CqlValueSet czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = this.Kidney_Transplant(context);
        IEnumerable<Procedure> czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
        IEnumerable<Procedure> czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Union<Procedure>(czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_, czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_);
        CqlValueSet czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = this.Bone_Marrow_Transplant(context);
        IEnumerable<Procedure> czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
        IEnumerable<Procedure> czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Union<Procedure>(czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_, czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_);
        IEnumerable<Procedure> czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = this.procedureInPatientHistory(context, czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_);
        bool? czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Exists<Procedure>(czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_);

        return czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_;
    }


    [CqlExpressionDefinition("Has Risk Factor Any Time in History or During Measurement Period")]
    public bool? Has_Risk_Factor_Any_Time_in_History_or_During_Measurement_Period(CqlContext context)
    {
        bool? czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = this.Has_90_or_More_Active_Glucocorticoid_Medication_Days(context);
        CqlValueSet czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = this.Osteoporosis_With_Current_Fracture(context);
        IEnumerable<Condition> czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        CqlValueSet czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = this.Malabsorption_Syndromes(context);
        IEnumerable<Condition> dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        IEnumerable<Condition> dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Union<Condition>(czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_, dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_);
        CqlValueSet dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = this.Chronic_Malnutrition(context);
        IEnumerable<Condition> dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        CqlValueSet dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = this.Chronic_Liver_Disease(context);
        IEnumerable<Condition> dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        IEnumerable<Condition> dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Union<Condition>(dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_, dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_);
        IEnumerable<Condition> dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Union<Condition>(dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_, dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_);
        CqlValueSet dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = this.Rheumatoid_Arthritis(context);
        IEnumerable<Condition> dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        CqlValueSet dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = this.Hyperthyroidism(context);
        IEnumerable<Condition> dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        IEnumerable<Condition> dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Union<Condition>(dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_, dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_);
        IEnumerable<Condition> dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Union<Condition>(dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_, dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_);
        CqlValueSet dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = this.Type_1_Diabetes(context);
        IEnumerable<Condition> dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        CqlValueSet dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = this.End_Stage_Renal_Disease(context);
        IEnumerable<Condition> dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        IEnumerable<Condition> dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Union<Condition>(dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_, dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_);
        IEnumerable<Condition> dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Union<Condition>(dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_, dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_);
        CqlValueSet dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = this.Osteogenesis_Imperfecta(context);
        IEnumerable<Condition> dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        CqlValueSet dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = this.Ankylosing_Spondylitis(context);
        IEnumerable<Condition> dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        IEnumerable<Condition> dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Union<Condition>(dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_, dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_);
        IEnumerable<Condition> dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Union<Condition>(dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_, dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_);
        CqlValueSet ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = this.Psoriatic_Arthritis(context);
        IEnumerable<Condition> ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        CqlValueSet ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = this.Ehlers_Danlos_Syndrome(context);
        IEnumerable<Condition> ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        IEnumerable<Condition> ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.Union<Condition>(ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_, ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_);
        IEnumerable<Condition> ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Union<Condition>(dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_, ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_);
        CqlValueSet ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = this.Cushings_Syndrome(context);
        IEnumerable<Condition> ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        CqlValueSet ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = this.Hyperparathyroidism(context);
        IEnumerable<Condition> ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        IEnumerable<Condition> ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Union<Condition>(ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_, ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_);
        IEnumerable<Condition> ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Union<Condition>(ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_, ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_);
        CqlValueSet ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = this.Marfans_Syndrome(context);
        IEnumerable<Condition> ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        CqlValueSet ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = this.Lupus(context);
        IEnumerable<Condition> ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        IEnumerable<Condition> ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Union<Condition>(ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_, ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_);
        IEnumerable<Condition> ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Union<Condition>(ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_, ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_);
        CqlValueSet ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = this.Multiple_Myeloma(context);
        IEnumerable<Condition> ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        CqlValueSet ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = this.Premature_Menopause(context);
        IEnumerable<Condition> ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        IEnumerable<Condition> ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Union<Condition>(ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_, ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_);
        IEnumerable<Condition> ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Union<Condition>(ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_, ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_);
        CqlValueSet ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = this.Eating_Disorders(context);
        IEnumerable<Condition> ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        CqlValueSet fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = this.Amenorrhea(context);
        IEnumerable<Condition> fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        IEnumerable<Condition> fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Union<Condition>(ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_, fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_);
        IEnumerable<Condition> fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Union<Condition>(ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_, fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_);
        IEnumerable<Condition> fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = this.diagnosisInPatientHistory(context, fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_);
        bool? fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Exists<Condition>(fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_);
        bool? fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Or(czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_, fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_);
        CqlValueSet fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = this.Chemotherapy(context);
        IEnumerable<Procedure> fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
        IEnumerable<Procedure> fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = this.procedureInPatientHistory(context, fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_);
        bool? fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Exists<Procedure>(fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_);
        bool? fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Or(fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_, fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_);
        bool? fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = this.Has_Double_or_Bilateral_Oophorectomy(context);
        bool? fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Or(fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_, fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_);
        bool? fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = this.Has_Organ_Transplants(context);
        bool? fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Or(fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_, fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_);

        return fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_;
    }


    [CqlExpressionDefinition("Denominator Exclusions")]
    public bool? Denominator_Exclusions(CqlContext context)
    {
        bool? fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = this.Has_Risk_Factor_Active_During_the_Measurement_Period(context);
        bool? fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = this.Has_Risk_Factor_Any_Time_in_History_Prior_to_Measurement_Period(context);
        bool? fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Or(fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_, fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_);
        bool? fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = this.Has_Risk_Factor_Any_Time_in_History_or_During_Measurement_Period(context);
        bool? fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Or(fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_, fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_);

        return fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_;
    }


    [CqlExpressionDefinition("DXA Scan Order During Measurement Period")]
    public IEnumerable<ServiceRequest> DXA_Scan_Order_During_Measurement_Period(CqlContext context)
    {
        CqlValueSet fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = this.DXA__Dual_energy_Xray_Absorptiometry__Scan(context);
        IEnumerable<ServiceRequest> fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Retrieve<ServiceRequest>(new RetrieveParameters(default, fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-servicerequest"));
        IEnumerable<ServiceRequest> fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = Status_1_8_000.Instance.isDiagnosticStudyOrder(context, fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_);
        bool? fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_(ServiceRequest DXA)
        {
            CqlInterval<CqlDateTime> gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = this.Measurement_Period(context);
            FhirDateTime gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = DXA?.AuthoredOnElement;
            CqlDateTime gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.Convert<CqlDateTime>(gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_);
            CqlInterval<CqlDateTime> gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = QICoreCommon_2_1_000.Instance.toInterval(context, gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ as object);
            bool? gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_, gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_, default);

            return gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_;
        };
        IEnumerable<ServiceRequest> fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Where<ServiceRequest>(fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_, fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_);
        object gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_(ServiceRequest @this)
        {
            FhirDateTime gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = @this?.AuthoredOnElement;
            CqlDateTime gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Convert<CqlDateTime>(gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_);

            return gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_;
        };
        IEnumerable<ServiceRequest> gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.SortBy<ServiceRequest>(fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_, gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_, System.ComponentModel.ListSortDirection.Ascending);

        return gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_;
    }


    [CqlExpressionDefinition("Numerator")]
    public bool? Numerator(CqlContext context)
    {
        IEnumerable<ServiceRequest> gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = this.DXA_Scan_Order_During_Measurement_Period(context);
        bool? gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Exists<ServiceRequest>(gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_);

        return gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_;
    }


    [CqlExpressionDefinition("Osteoporosis Fracture Risk Assessment Prior to First DXA Scan")]
    public IEnumerable<Observation> Osteoporosis_Fracture_Risk_Assessment_Prior_to_First_DXA_Scan(CqlContext context)
    {
        CqlCode gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = this.Major_osteoporotic_fracture_10_year_probability__Likelihood__Fracture_Risk_Assessment(context);
        IEnumerable<CqlCode> gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.ToList<CqlCode>(gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_);
        IEnumerable<Observation> gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
        IEnumerable<Observation> gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = Status_1_8_000.Instance.isAssessmentPerformed(context, gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_);
        bool? gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_(Observation FRAX)
        {
            DataType hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = FRAX?.Value;
            object hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = FHIRHelpers_4_4_000.Instance.ToValue(context, hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_);
            CqlQuantity hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Quantity(8.4m, "%");
            bool? hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.GreaterOrEqual(hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ as CqlQuantity, hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_);

            return hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_;
        };
        IEnumerable<Observation> gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Where<Observation>(gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_, gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_);
        CqlCode gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = this.Osteoporosis_Risk_Assessment_Instrument(context);
        IEnumerable<CqlCode> gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.ToList<CqlCode>(gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_);
        IEnumerable<Observation> gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
        IEnumerable<Observation> gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = Status_1_8_000.Instance.isAssessmentPerformed(context, gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_);
        bool? gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_(Observation ORAI)
        {
            DataType hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = ORAI?.Value;
            object hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = FHIRHelpers_4_4_000.Instance.ToValue(context, hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_);
            bool? hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.GreaterOrEqual(hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ as int?, 9);

            return hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_;
        };
        IEnumerable<Observation> gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Where<Observation>(gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_, gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_);
        IEnumerable<Observation> gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Union<Observation>(gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_, gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_);
        CqlCode gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = this.Osteoporosis_Index_of_Risk_panel(context);
        IEnumerable<CqlCode> gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.ToList<CqlCode>(gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_);
        IEnumerable<Observation> hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
        IEnumerable<Observation> hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = Status_1_8_000.Instance.isAssessmentPerformed(context, hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_);
        bool? hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_(Observation OSIRIS)
        {
            DataType hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = OSIRIS?.Value;
            object hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = FHIRHelpers_4_4_000.Instance.ToValue(context, hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_);
            CqlQuantity hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.ConvertDecimalToQuantity(1.0m);
            bool? hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Less(hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ as CqlQuantity, hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_);

            return hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_;
        };
        IEnumerable<Observation> hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Where<Observation>(hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_, hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_);
        CqlCode hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = this.Osteoporosis_Self_Assessment_Tool(context);
        IEnumerable<CqlCode> hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.ToList<CqlCode>(hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_);
        IEnumerable<Observation> hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
        IEnumerable<Observation> hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = Status_1_8_000.Instance.isAssessmentPerformed(context, hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_);
        bool? hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_(Observation OST)
        {
            DataType hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = OST?.Value;
            object izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = FHIRHelpers_4_4_000.Instance.ToValue(context, hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_);
            CqlQuantity izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.ConvertDecimalToQuantity(2.0m);
            bool? izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Less(izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ as CqlQuantity, izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_);

            return izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_;
        };
        IEnumerable<Observation> hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Where<Observation>(hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_, hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_);
        IEnumerable<Observation> hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Union<Observation>(hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_, hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_);
        IEnumerable<Observation> hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Union<Observation>(gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_, hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_);
        bool? hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_(Observation RiskAssessment)
        {
            DataType izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = RiskAssessment?.Effective;
            object izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = FHIRHelpers_4_4_000.Instance.ToValue(context, izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_);
            CqlInterval<CqlDateTime> izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = QICoreCommon_2_1_000.Instance.toInterval(context, izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_);
            CqlDateTime izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Start(izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_);
            IEnumerable<ServiceRequest> izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = this.DXA_Scan_Order_During_Measurement_Period(context);
            ServiceRequest izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.First<ServiceRequest>(izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_);
            FhirDateTime izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_?.AuthoredOnElement;
            CqlDateTime izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Convert<CqlDateTime>(izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_);
            bool? izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Before(izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_, izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_, default);

            return izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_;
        };
        IEnumerable<Observation> hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Where<Observation>(hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_, hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_);

        return hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_;
    }


    [CqlExpressionDefinition("Numerator Exclusion")]
    public bool? Numerator_Exclusion(CqlContext context)
    {
        IEnumerable<Observation> izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = this.Osteoporosis_Fracture_Risk_Assessment_Prior_to_First_DXA_Scan(context);
        bool? izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Exists<Observation>(izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_);

        return izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_;
    }


    #endregion Expressions

}

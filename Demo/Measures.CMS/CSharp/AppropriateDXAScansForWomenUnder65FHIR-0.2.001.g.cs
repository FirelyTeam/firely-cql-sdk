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
        CqlDateTime pzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.DateTime(2025, 1, 1, 0, 0, 0, 0, 0.0m);
        CqlDateTime pzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.DateTime(2025, 12, 31, 23, 59, 59, 999, 0.0m);
        CqlInterval<CqlDateTime> pzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.Interval(pzzzzzzzzzzzzzzzzzzzzzc_, pzzzzzzzzzzzzzzzzzzzzzd_, true, true);
        object pzzzzzzzzzzzzzzzzzzzzzf_ = context.ResolveParameter("AppropriateDXAScansForWomenUnder65FHIR-0.2.001", "Measurement Period", pzzzzzzzzzzzzzzzzzzzzze_);

        return (CqlInterval<CqlDateTime>)pzzzzzzzzzzzzzzzzzzzzzf_;
    }


    #endregion Parameters

    #region Expressions

    [CqlExpressionDefinition("Patient")]
    public Patient Patient(CqlContext context)
    {
        IEnumerable<Patient> pzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-patient"));
        Patient pzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.SingletonFrom<Patient>(pzzzzzzzzzzzzzzzzzzzzzg_);

        return pzzzzzzzzzzzzzzzzzzzzzh_;
    }


    [CqlExpressionDefinition("SDE Ethnicity")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Ethnicity(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? pzzzzzzzzzzzzzzzzzzzzzi_ = SupplementalDataElements_3_5_000.Instance.SDE_Ethnicity(context);

        return pzzzzzzzzzzzzzzzzzzzzzi_;
    }


    [CqlExpressionDefinition("SDE Payer")]
    public IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> SDE_Payer(CqlContext context)
    {
        IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> pzzzzzzzzzzzzzzzzzzzzzj_ = SupplementalDataElements_3_5_000.Instance.SDE_Payer(context);

        return pzzzzzzzzzzzzzzzzzzzzzj_;
    }


    [CqlExpressionDefinition("SDE Race")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Race(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? pzzzzzzzzzzzzzzzzzzzzzk_ = SupplementalDataElements_3_5_000.Instance.SDE_Race(context);

        return pzzzzzzzzzzzzzzzzzzzzzk_;
    }


    [CqlExpressionDefinition("SDE Sex")]
    public CqlCode SDE_Sex(CqlContext context)
    {
        CqlCode pzzzzzzzzzzzzzzzzzzzzzl_ = SupplementalDataElements_3_5_000.Instance.SDE_Sex(context);

        return pzzzzzzzzzzzzzzzzzzzzzl_;
    }


    [CqlExpressionDefinition("Qualifying Encounter")]
    public IEnumerable<Encounter> Qualifying_Encounter(CqlContext context)
    {
        CqlValueSet pzzzzzzzzzzzzzzzzzzzzzm_ = this.Office_Visit(context);
        IEnumerable<Encounter> pzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, pzzzzzzzzzzzzzzzzzzzzzm_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        CqlValueSet pzzzzzzzzzzzzzzzzzzzzzo_ = this.Preventive_Care_Services_Established_Office_Visit__18_and_Up(context);
        IEnumerable<Encounter> pzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, pzzzzzzzzzzzzzzzzzzzzzo_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> pzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Union<Encounter>(pzzzzzzzzzzzzzzzzzzzzzn_, pzzzzzzzzzzzzzzzzzzzzzp_);
        IEnumerable<Encounter> pzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        bool? pzzzzzzzzzzzzzzzzzzzzzs_(Encounter E)
        {
            List<CodeableConcept> qzzzzzzzzzzzzzzzzzzzzzk_ = E?.Type;
            CqlConcept qzzzzzzzzzzzzzzzzzzzzzl_(CodeableConcept @this)
            {
                CqlConcept qzzzzzzzzzzzzzzzzzzzzzq_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);

                return qzzzzzzzzzzzzzzzzzzzzzq_;
            };
            IEnumerable<CqlConcept> qzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)qzzzzzzzzzzzzzzzzzzzzzk_, qzzzzzzzzzzzzzzzzzzzzzl_);
            bool? qzzzzzzzzzzzzzzzzzzzzzn_(CqlConcept T)
            {
                CqlCode qzzzzzzzzzzzzzzzzzzzzzr_ = this.Unlisted_preventive_medicine_service(context);
                CqlConcept qzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.ConvertCodeToConcept(qzzzzzzzzzzzzzzzzzzzzzr_);
                bool? qzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Equivalent(T, qzzzzzzzzzzzzzzzzzzzzzs_);

                return qzzzzzzzzzzzzzzzzzzzzzt_;
            };
            IEnumerable<CqlConcept> qzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Where<CqlConcept>(qzzzzzzzzzzzzzzzzzzzzzm_, qzzzzzzzzzzzzzzzzzzzzzn_);
            bool? qzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Exists<CqlConcept>(qzzzzzzzzzzzzzzzzzzzzzo_);

            return qzzzzzzzzzzzzzzzzzzzzzp_;
        };
        IEnumerable<Encounter> pzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Where<Encounter>(pzzzzzzzzzzzzzzzzzzzzzr_, pzzzzzzzzzzzzzzzzzzzzzs_);
        CqlValueSet pzzzzzzzzzzzzzzzzzzzzzu_ = this.Preventive_Care_Services_Initial_Office_Visit__18_and_Up(context);
        IEnumerable<Encounter> pzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, pzzzzzzzzzzzzzzzzzzzzzu_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> pzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Union<Encounter>(pzzzzzzzzzzzzzzzzzzzzzt_, pzzzzzzzzzzzzzzzzzzzzzv_);
        IEnumerable<Encounter> pzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Union<Encounter>(pzzzzzzzzzzzzzzzzzzzzzq_, pzzzzzzzzzzzzzzzzzzzzzw_);
        CqlValueSet pzzzzzzzzzzzzzzzzzzzzzy_ = this.Outpatient_Consultation(context);
        IEnumerable<Encounter> pzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, pzzzzzzzzzzzzzzzzzzzzzy_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        CqlValueSet qzzzzzzzzzzzzzzzzzzzzza_ = this.Virtual_Encounter(context);
        IEnumerable<Encounter> qzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, qzzzzzzzzzzzzzzzzzzzzza_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> qzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Union<Encounter>(pzzzzzzzzzzzzzzzzzzzzzz_, qzzzzzzzzzzzzzzzzzzzzzb_);
        IEnumerable<Encounter> qzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Union<Encounter>(pzzzzzzzzzzzzzzzzzzzzzx_, qzzzzzzzzzzzzzzzzzzzzzc_);
        CqlValueSet qzzzzzzzzzzzzzzzzzzzzze_ = this.Telephone_Visits(context);
        IEnumerable<Encounter> qzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, qzzzzzzzzzzzzzzzzzzzzze_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> qzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Union<Encounter>(qzzzzzzzzzzzzzzzzzzzzzd_, qzzzzzzzzzzzzzzzzzzzzzf_);
        IEnumerable<Encounter> qzzzzzzzzzzzzzzzzzzzzzh_ = Status_1_8_000.Instance.isEncounterPerformed(context, qzzzzzzzzzzzzzzzzzzzzzg_);
        bool? qzzzzzzzzzzzzzzzzzzzzzi_(Encounter ValidEncounters)
        {
            CqlInterval<CqlDateTime> qzzzzzzzzzzzzzzzzzzzzzu_ = this.Measurement_Period(context);
            Period qzzzzzzzzzzzzzzzzzzzzzv_ = ValidEncounters?.Period;
            CqlInterval<CqlDateTime> qzzzzzzzzzzzzzzzzzzzzzw_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, qzzzzzzzzzzzzzzzzzzzzzv_);
            CqlInterval<CqlDateTime> qzzzzzzzzzzzzzzzzzzzzzx_ = QICoreCommon_2_1_000.Instance.toInterval(context, qzzzzzzzzzzzzzzzzzzzzzw_ as object);
            bool? qzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(qzzzzzzzzzzzzzzzzzzzzzu_, qzzzzzzzzzzzzzzzzzzzzzx_, "day");

            return qzzzzzzzzzzzzzzzzzzzzzy_;
        };
        IEnumerable<Encounter> qzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Where<Encounter>(qzzzzzzzzzzzzzzzzzzzzzh_, qzzzzzzzzzzzzzzzzzzzzzi_);

        return qzzzzzzzzzzzzzzzzzzzzzj_;
    }


    [CqlExpressionDefinition("Initial Population")]
    public bool? Initial_Population(CqlContext context)
    {
        Patient qzzzzzzzzzzzzzzzzzzzzzz_ = this.Patient(context);
        Date rzzzzzzzzzzzzzzzzzzzzza_ = qzzzzzzzzzzzzzzzzzzzzzz_?.BirthDateElement;
        string rzzzzzzzzzzzzzzzzzzzzzb_ = rzzzzzzzzzzzzzzzzzzzzza_?.Value;
        CqlDate rzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.ConvertStringToDate(rzzzzzzzzzzzzzzzzzzzzzb_);
        CqlInterval<CqlDateTime> rzzzzzzzzzzzzzzzzzzzzzd_ = this.Measurement_Period(context);
        CqlDateTime rzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.Start(rzzzzzzzzzzzzzzzzzzzzzd_);
        CqlDate rzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.DateFrom(rzzzzzzzzzzzzzzzzzzzzze_);
        int? rzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.CalculateAgeAt(rzzzzzzzzzzzzzzzzzzzzzc_, rzzzzzzzzzzzzzzzzzzzzzf_, "year");
        CqlInterval<int?> rzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Interval(50, 63, true, true);
        bool? rzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.In<int?>(rzzzzzzzzzzzzzzzzzzzzzg_, rzzzzzzzzzzzzzzzzzzzzzh_, default);
        Code<AdministrativeGender> rzzzzzzzzzzzzzzzzzzzzzk_ = qzzzzzzzzzzzzzzzzzzzzzz_?.GenderElement;
        AdministrativeGender? rzzzzzzzzzzzzzzzzzzzzzl_ = rzzzzzzzzzzzzzzzzzzzzzk_?.Value;
        string rzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Convert<string>(rzzzzzzzzzzzzzzzzzzzzzl_);
        bool? rzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Equal(rzzzzzzzzzzzzzzzzzzzzzm_, "female");
        bool? rzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.And(rzzzzzzzzzzzzzzzzzzzzzi_, rzzzzzzzzzzzzzzzzzzzzzn_);
        IEnumerable<Encounter> rzzzzzzzzzzzzzzzzzzzzzp_ = this.Qualifying_Encounter(context);
        bool? rzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Exists<Encounter>(rzzzzzzzzzzzzzzzzzzzzzp_);
        bool? rzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.And(rzzzzzzzzzzzzzzzzzzzzzo_, rzzzzzzzzzzzzzzzzzzzzzq_);

        return rzzzzzzzzzzzzzzzzzzzzzr_;
    }


    [CqlExpressionDefinition("Denominator")]
    public bool? Denominator(CqlContext context)
    {
        bool? rzzzzzzzzzzzzzzzzzzzzzs_ = this.Initial_Population(context);

        return rzzzzzzzzzzzzzzzzzzzzzs_;
    }


    [CqlExpressionDefinition("First BMI in Measurement Period")]
    public Observation First_BMI_in_Measurement_Period(CqlContext context)
    {
        IEnumerable<Observation> rzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/StructureDefinition/bmi"));
        IEnumerable<Observation> rzzzzzzzzzzzzzzzzzzzzzu_ = Status_1_8_000.Instance.isObservationBMI(context, rzzzzzzzzzzzzzzzzzzzzzt_);
        bool? rzzzzzzzzzzzzzzzzzzzzzv_(Observation BMIRatio)
        {
            CqlInterval<CqlDateTime> szzzzzzzzzzzzzzzzzzzzza_ = this.Measurement_Period(context);
            DataType szzzzzzzzzzzzzzzzzzzzzb_ = BMIRatio?.Effective;
            object szzzzzzzzzzzzzzzzzzzzzc_ = FHIRHelpers_4_4_000.Instance.ToValue(context, szzzzzzzzzzzzzzzzzzzzzb_);
            CqlInterval<CqlDateTime> szzzzzzzzzzzzzzzzzzzzzd_ = QICoreCommon_2_1_000.Instance.toInterval(context, szzzzzzzzzzzzzzzzzzzzzc_);
            bool? szzzzzzzzzzzzzzzzzzzzze_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(szzzzzzzzzzzzzzzzzzzzza_, szzzzzzzzzzzzzzzzzzzzzd_, default);
            DataType szzzzzzzzzzzzzzzzzzzzzf_ = BMIRatio?.Value;
            CqlQuantity szzzzzzzzzzzzzzzzzzzzzg_ = FHIRHelpers_4_4_000.Instance.ToQuantity(context, szzzzzzzzzzzzzzzzzzzzzf_ as Quantity);
            bool? szzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Not((bool?)((szzzzzzzzzzzzzzzzzzzzzg_ as CqlQuantity) is null));
            bool? szzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.And(szzzzzzzzzzzzzzzzzzzzze_, szzzzzzzzzzzzzzzzzzzzzh_);

            return szzzzzzzzzzzzzzzzzzzzzi_;
        };
        IEnumerable<Observation> rzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Where<Observation>(rzzzzzzzzzzzzzzzzzzzzzu_, rzzzzzzzzzzzzzzzzzzzzzv_);
        object rzzzzzzzzzzzzzzzzzzzzzx_(Observation @this)
        {
            DataType szzzzzzzzzzzzzzzzzzzzzj_ = @this?.Effective;
            object szzzzzzzzzzzzzzzzzzzzzk_ = FHIRHelpers_4_4_000.Instance.ToValue(context, szzzzzzzzzzzzzzzzzzzzzj_);
            CqlInterval<CqlDateTime> szzzzzzzzzzzzzzzzzzzzzl_ = QICoreCommon_2_1_000.Instance.toInterval(context, szzzzzzzzzzzzzzzzzzzzzk_);
            CqlDateTime szzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Start(szzzzzzzzzzzzzzzzzzzzzl_);

            return szzzzzzzzzzzzzzzzzzzzzm_;
        };
        IEnumerable<Observation> rzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.SortBy<Observation>(rzzzzzzzzzzzzzzzzzzzzzw_, rzzzzzzzzzzzzzzzzzzzzzx_, System.ComponentModel.ListSortDirection.Ascending);
        Observation rzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.First<Observation>(rzzzzzzzzzzzzzzzzzzzzzy_);

        return rzzzzzzzzzzzzzzzzzzzzzz_;
    }


    [CqlExpressionDefinition("First BMI in Measurement Period Less Than or Equal to 20 kg m2")]
    public Observation First_BMI_in_Measurement_Period_Less_Than_or_Equal_to_20_kg_m2(CqlContext context)
    {
        Observation szzzzzzzzzzzzzzzzzzzzzn_ = this.First_BMI_in_Measurement_Period(context);
        Observation[] szzzzzzzzzzzzzzzzzzzzzo_ = [
            szzzzzzzzzzzzzzzzzzzzzn_,
        ];
        bool? szzzzzzzzzzzzzzzzzzzzzp_(Observation FirstBMI)
        {
            DataType szzzzzzzzzzzzzzzzzzzzzs_ = FirstBMI?.Value;
            CqlQuantity szzzzzzzzzzzzzzzzzzzzzt_ = FHIRHelpers_4_4_000.Instance.ToQuantity(context, szzzzzzzzzzzzzzzzzzzzzs_ as Quantity);
            CqlQuantity szzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Quantity(20m, "kg/m2");
            bool? szzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.LessOrEqual(szzzzzzzzzzzzzzzzzzzzzt_ as CqlQuantity, szzzzzzzzzzzzzzzzzzzzzu_);

            return szzzzzzzzzzzzzzzzzzzzzv_;
        };
        IEnumerable<Observation> szzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Where<Observation>((IEnumerable<Observation>)szzzzzzzzzzzzzzzzzzzzzo_, szzzzzzzzzzzzzzzzzzzzzp_);
        Observation szzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.SingletonFrom<Observation>(szzzzzzzzzzzzzzzzzzzzzq_);

        return szzzzzzzzzzzzzzzzzzzzzr_;
    }


    [CqlExpressionDefinition("First Average Number of Drinks Assessments Indicating More Than Two Per Day")]
    public Observation First_Average_Number_of_Drinks_Assessments_Indicating_More_Than_Two_Per_Day(CqlContext context)
    {
        CqlCode szzzzzzzzzzzzzzzzzzzzzw_ = this.Alcoholic_drinks_per_day(context);
        IEnumerable<CqlCode> szzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.ToList<CqlCode>(szzzzzzzzzzzzzzzzzzzzzw_);
        IEnumerable<Observation> szzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, szzzzzzzzzzzzzzzzzzzzzx_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
        IEnumerable<Observation> szzzzzzzzzzzzzzzzzzzzzz_ = Status_1_8_000.Instance.isAssessmentPerformed(context, szzzzzzzzzzzzzzzzzzzzzy_);
        bool? tzzzzzzzzzzzzzzzzzzzzza_(Observation AverageDrinks)
        {
            DataType tzzzzzzzzzzzzzzzzzzzzzf_ = AverageDrinks?.Effective;
            object tzzzzzzzzzzzzzzzzzzzzzg_ = FHIRHelpers_4_4_000.Instance.ToValue(context, tzzzzzzzzzzzzzzzzzzzzzf_);
            CqlInterval<CqlDateTime> tzzzzzzzzzzzzzzzzzzzzzh_ = QICoreCommon_2_1_000.Instance.toInterval(context, tzzzzzzzzzzzzzzzzzzzzzg_);
            CqlDateTime tzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Start(tzzzzzzzzzzzzzzzzzzzzzh_);
            CqlInterval<CqlDateTime> tzzzzzzzzzzzzzzzzzzzzzj_ = this.Measurement_Period(context);
            bool? tzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.In<CqlDateTime>(tzzzzzzzzzzzzzzzzzzzzzi_, tzzzzzzzzzzzzzzzzzzzzzj_, default);
            DataType tzzzzzzzzzzzzzzzzzzzzzl_ = AverageDrinks?.Value;
            object tzzzzzzzzzzzzzzzzzzzzzm_ = FHIRHelpers_4_4_000.Instance.ToValue(context, tzzzzzzzzzzzzzzzzzzzzzl_);
            CqlQuantity tzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Quantity(2m, "{drinks}/d");
            bool? tzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Greater(tzzzzzzzzzzzzzzzzzzzzzm_ as CqlQuantity, tzzzzzzzzzzzzzzzzzzzzzn_);
            bool? tzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.And(tzzzzzzzzzzzzzzzzzzzzzk_, tzzzzzzzzzzzzzzzzzzzzzo_);

            return tzzzzzzzzzzzzzzzzzzzzzp_;
        };
        IEnumerable<Observation> tzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Where<Observation>(szzzzzzzzzzzzzzzzzzzzzz_, tzzzzzzzzzzzzzzzzzzzzza_);
        object tzzzzzzzzzzzzzzzzzzzzzc_(Observation @this)
        {
            DataType tzzzzzzzzzzzzzzzzzzzzzq_ = @this?.Effective;
            object tzzzzzzzzzzzzzzzzzzzzzr_ = FHIRHelpers_4_4_000.Instance.ToValue(context, tzzzzzzzzzzzzzzzzzzzzzq_);
            CqlInterval<CqlDateTime> tzzzzzzzzzzzzzzzzzzzzzs_ = QICoreCommon_2_1_000.Instance.toInterval(context, tzzzzzzzzzzzzzzzzzzzzzr_);
            CqlDateTime tzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Start(tzzzzzzzzzzzzzzzzzzzzzs_);

            return tzzzzzzzzzzzzzzzzzzzzzt_;
        };
        IEnumerable<Observation> tzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.SortBy<Observation>(tzzzzzzzzzzzzzzzzzzzzzb_, tzzzzzzzzzzzzzzzzzzzzzc_, System.ComponentModel.ListSortDirection.Ascending);
        Observation tzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.First<Observation>(tzzzzzzzzzzzzzzzzzzzzzd_);

        return tzzzzzzzzzzzzzzzzzzzzze_;
    }


    [CqlExpressionDefinition("Has Risk Factor Active During the Measurement Period")]
    public bool? Has_Risk_Factor_Active_During_the_Measurement_Period(CqlContext context)
    {
        Observation tzzzzzzzzzzzzzzzzzzzzzu_ = this.First_BMI_in_Measurement_Period_Less_Than_or_Equal_to_20_kg_m2(context);
        bool? tzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Not((bool?)(tzzzzzzzzzzzzzzzzzzzzzu_ is null));
        Observation tzzzzzzzzzzzzzzzzzzzzzw_ = this.First_Average_Number_of_Drinks_Assessments_Indicating_More_Than_Two_Per_Day(context);
        bool? tzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Not((bool?)(tzzzzzzzzzzzzzzzzzzzzzw_ is null));
        bool? tzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Or(tzzzzzzzzzzzzzzzzzzzzzv_, tzzzzzzzzzzzzzzzzzzzzzx_);

        return tzzzzzzzzzzzzzzzzzzzzzy_;
    }


    [CqlExpressionDefinition("Has Risk Factor Any Time in History Prior to Measurement Period")]
    public bool? Has_Risk_Factor_Any_Time_in_History_Prior_to_Measurement_Period(CqlContext context)
    {
        CqlValueSet tzzzzzzzzzzzzzzzzzzzzzz_ = this.Osteoporosis_Without_Current_Fracture(context);
        IEnumerable<Condition> uzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, tzzzzzzzzzzzzzzzzzzzzzz_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        bool? uzzzzzzzzzzzzzzzzzzzzzb_(Condition OsteoporosisDiagnosis)
        {
            CqlInterval<CqlDateTime> vzzzzzzzzzzzzzzzzzzzzzn_ = QICoreCommon_2_1_000.Instance.prevalenceInterval(context, OsteoporosisDiagnosis);
            CqlDateTime vzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Start(vzzzzzzzzzzzzzzzzzzzzzn_);
            CqlInterval<CqlDateTime> vzzzzzzzzzzzzzzzzzzzzzp_ = this.Measurement_Period(context);
            CqlDateTime vzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Start(vzzzzzzzzzzzzzzzzzzzzzp_);
            bool? vzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Before(vzzzzzzzzzzzzzzzzzzzzzo_, vzzzzzzzzzzzzzzzzzzzzzq_, default);

            return vzzzzzzzzzzzzzzzzzzzzzr_;
        };
        IEnumerable<Condition> uzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Where<Condition>(uzzzzzzzzzzzzzzzzzzzzza_, uzzzzzzzzzzzzzzzzzzzzzb_);
        CqlValueSet uzzzzzzzzzzzzzzzzzzzzzd_ = this.Osteopenia(context);
        IEnumerable<Condition> uzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, uzzzzzzzzzzzzzzzzzzzzzd_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        bool? uzzzzzzzzzzzzzzzzzzzzzf_(Condition OsteopeniaDiagnosis)
        {
            CqlInterval<CqlDateTime> vzzzzzzzzzzzzzzzzzzzzzs_ = QICoreCommon_2_1_000.Instance.prevalenceInterval(context, OsteopeniaDiagnosis);
            CqlDateTime vzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Start(vzzzzzzzzzzzzzzzzzzzzzs_);
            CqlInterval<CqlDateTime> vzzzzzzzzzzzzzzzzzzzzzu_ = this.Measurement_Period(context);
            CqlDateTime vzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Start(vzzzzzzzzzzzzzzzzzzzzzu_);
            bool? vzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Before(vzzzzzzzzzzzzzzzzzzzzzt_, vzzzzzzzzzzzzzzzzzzzzzv_, default);

            return vzzzzzzzzzzzzzzzzzzzzzw_;
        };
        IEnumerable<Condition> uzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Where<Condition>(uzzzzzzzzzzzzzzzzzzzzze_, uzzzzzzzzzzzzzzzzzzzzzf_);
        IEnumerable<Condition> uzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Union<Condition>(uzzzzzzzzzzzzzzzzzzzzzc_, uzzzzzzzzzzzzzzzzzzzzzg_);
        CqlValueSet uzzzzzzzzzzzzzzzzzzzzzi_ = this.Gastric_Bypass_Surgery(context);
        IEnumerable<Procedure> uzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, uzzzzzzzzzzzzzzzzzzzzzi_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
        IEnumerable<Procedure> uzzzzzzzzzzzzzzzzzzzzzk_ = Status_1_8_000.Instance.isProcedurePerformed(context, uzzzzzzzzzzzzzzzzzzzzzj_);
        bool? uzzzzzzzzzzzzzzzzzzzzzl_(Procedure GastricBypass)
        {
            DataType vzzzzzzzzzzzzzzzzzzzzzx_ = GastricBypass?.Performed;
            object vzzzzzzzzzzzzzzzzzzzzzy_ = FHIRHelpers_4_4_000.Instance.ToValue(context, vzzzzzzzzzzzzzzzzzzzzzx_);
            CqlInterval<CqlDateTime> vzzzzzzzzzzzzzzzzzzzzzz_ = QICoreCommon_2_1_000.Instance.toInterval(context, vzzzzzzzzzzzzzzzzzzzzzy_);
            CqlDateTime wzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.End(vzzzzzzzzzzzzzzzzzzzzzz_);
            CqlInterval<CqlDateTime> wzzzzzzzzzzzzzzzzzzzzzb_ = this.Measurement_Period(context);
            CqlDateTime wzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Start(wzzzzzzzzzzzzzzzzzzzzzb_);
            bool? wzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Before(wzzzzzzzzzzzzzzzzzzzzza_, wzzzzzzzzzzzzzzzzzzzzzc_, default);

            return wzzzzzzzzzzzzzzzzzzzzzd_;
        };
        IEnumerable<Procedure> uzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Where<Procedure>(uzzzzzzzzzzzzzzzzzzzzzk_, uzzzzzzzzzzzzzzzzzzzzzl_);
        CqlValueSet uzzzzzzzzzzzzzzzzzzzzzn_ = this.Aromatase_Inhibitors(context);
        IEnumerable<MedicationRequest> uzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, uzzzzzzzzzzzzzzzzzzzzzn_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> uzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, uzzzzzzzzzzzzzzzzzzzzzn_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> uzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Union<MedicationRequest>(uzzzzzzzzzzzzzzzzzzzzzo_, uzzzzzzzzzzzzzzzzzzzzzq_);
        IEnumerable<MedicationRequest> uzzzzzzzzzzzzzzzzzzzzzs_ = Status_1_8_000.Instance.isMedicationActive(context, uzzzzzzzzzzzzzzzzzzzzzr_);
        bool? uzzzzzzzzzzzzzzzzzzzzzt_(MedicationRequest AromataseInhibitorActive)
        {
            CqlInterval<CqlDate> wzzzzzzzzzzzzzzzzzzzzze_ = CumulativeMedicationDuration_4_1_000.Instance.MedicationRequestPeriod(context, AromataseInhibitorActive);
            CqlDate wzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Start(wzzzzzzzzzzzzzzzzzzzzze_);
            CqlDateTime wzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.ConvertDateToDateTime(wzzzzzzzzzzzzzzzzzzzzzf_);
            CqlInterval<CqlDateTime> wzzzzzzzzzzzzzzzzzzzzzh_ = this.Measurement_Period(context);
            CqlDateTime wzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Start(wzzzzzzzzzzzzzzzzzzzzzh_);
            bool? wzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Before(wzzzzzzzzzzzzzzzzzzzzzg_, wzzzzzzzzzzzzzzzzzzzzzi_, default);

            return wzzzzzzzzzzzzzzzzzzzzzj_;
        };
        IEnumerable<MedicationRequest> uzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Where<MedicationRequest>(uzzzzzzzzzzzzzzzzzzzzzs_, uzzzzzzzzzzzzzzzzzzzzzt_);
        IEnumerable<object> uzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Union<object>(uzzzzzzzzzzzzzzzzzzzzzm_ as IEnumerable<object>, uzzzzzzzzzzzzzzzzzzzzzu_ as IEnumerable<object>);
        IEnumerable<MedicationRequest> uzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, uzzzzzzzzzzzzzzzzzzzzzn_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> uzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, uzzzzzzzzzzzzzzzzzzzzzn_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> vzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.Union<MedicationRequest>(uzzzzzzzzzzzzzzzzzzzzzx_, uzzzzzzzzzzzzzzzzzzzzzz_);
        IEnumerable<MedicationRequest> vzzzzzzzzzzzzzzzzzzzzzb_ = Status_1_8_000.Instance.isMedicationOrder(context, vzzzzzzzzzzzzzzzzzzzzza_);
        bool? vzzzzzzzzzzzzzzzzzzzzzc_(MedicationRequest AromataseInhibitorOrder)
        {
            FhirDateTime wzzzzzzzzzzzzzzzzzzzzzk_ = AromataseInhibitorOrder?.AuthoredOnElement;
            CqlDateTime wzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Convert<CqlDateTime>(wzzzzzzzzzzzzzzzzzzzzzk_);
            CqlInterval<CqlDateTime> wzzzzzzzzzzzzzzzzzzzzzm_ = QICoreCommon_2_1_000.Instance.toInterval(context, wzzzzzzzzzzzzzzzzzzzzzl_ as object);
            CqlInterval<CqlDateTime> wzzzzzzzzzzzzzzzzzzzzzn_()
            {
                bool wzzzzzzzzzzzzzzzzzzzzzp_()
                {
                    CqlInterval<CqlDateTime> wzzzzzzzzzzzzzzzzzzzzzq_ = this.Measurement_Period(context);
                    CqlDateTime wzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Start(wzzzzzzzzzzzzzzzzzzzzzq_);

                    return wzzzzzzzzzzzzzzzzzzzzzr_ is null;
                };
                if (wzzzzzzzzzzzzzzzzzzzzzp_())
                {
                    return default;
                }
                else
                {
                    CqlInterval<CqlDateTime> wzzzzzzzzzzzzzzzzzzzzzs_ = this.Measurement_Period(context);
                    CqlDateTime wzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Start(wzzzzzzzzzzzzzzzzzzzzzs_);
                    CqlDateTime wzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Start(wzzzzzzzzzzzzzzzzzzzzzs_);
                    CqlInterval<CqlDateTime> wzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Interval(wzzzzzzzzzzzzzzzzzzzzzt_, wzzzzzzzzzzzzzzzzzzzzzv_, true, true);

                    return wzzzzzzzzzzzzzzzzzzzzzw_;
                }
            };
            bool? wzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Before(wzzzzzzzzzzzzzzzzzzzzzm_, wzzzzzzzzzzzzzzzzzzzzzn_(), default);

            return wzzzzzzzzzzzzzzzzzzzzzo_;
        };
        IEnumerable<MedicationRequest> vzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Where<MedicationRequest>(vzzzzzzzzzzzzzzzzzzzzzb_, vzzzzzzzzzzzzzzzzzzzzzc_);
        IEnumerable<object> vzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.Union<object>(uzzzzzzzzzzzzzzzzzzzzzv_ as IEnumerable<object>, vzzzzzzzzzzzzzzzzzzzzzd_ as IEnumerable<object>);
        CqlValueSet vzzzzzzzzzzzzzzzzzzzzzf_ = this.History_of_hip_fracture_in_parent(context);
        IEnumerable<Observation> vzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, vzzzzzzzzzzzzzzzzzzzzzf_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
        IEnumerable<Observation> vzzzzzzzzzzzzzzzzzzzzzh_ = Status_1_8_000.Instance.isAssessmentPerformed(context, vzzzzzzzzzzzzzzzzzzzzzg_);
        bool? vzzzzzzzzzzzzzzzzzzzzzi_(Observation ParentFractureHistory)
        {
            DataType wzzzzzzzzzzzzzzzzzzzzzx_ = ParentFractureHistory?.Effective;
            object wzzzzzzzzzzzzzzzzzzzzzy_ = FHIRHelpers_4_4_000.Instance.ToValue(context, wzzzzzzzzzzzzzzzzzzzzzx_);
            CqlInterval<CqlDateTime> wzzzzzzzzzzzzzzzzzzzzzz_ = QICoreCommon_2_1_000.Instance.toInterval(context, wzzzzzzzzzzzzzzzzzzzzzy_);
            CqlDateTime xzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.Start(wzzzzzzzzzzzzzzzzzzzzzz_);
            CqlInterval<CqlDateTime> xzzzzzzzzzzzzzzzzzzzzzb_ = this.Measurement_Period(context);
            CqlDateTime xzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Start(xzzzzzzzzzzzzzzzzzzzzzb_);
            bool? xzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Before(xzzzzzzzzzzzzzzzzzzzzza_, xzzzzzzzzzzzzzzzzzzzzzc_, default);

            return xzzzzzzzzzzzzzzzzzzzzzd_;
        };
        IEnumerable<Observation> vzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Where<Observation>(vzzzzzzzzzzzzzzzzzzzzzh_, vzzzzzzzzzzzzzzzzzzzzzi_);
        IEnumerable<object> vzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Union<object>(vzzzzzzzzzzzzzzzzzzzzze_ as IEnumerable<object>, vzzzzzzzzzzzzzzzzzzzzzj_ as IEnumerable<object>);
        IEnumerable<object> vzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Union<object>(uzzzzzzzzzzzzzzzzzzzzzh_ as IEnumerable<object>, vzzzzzzzzzzzzzzzzzzzzzk_ as IEnumerable<object>);
        bool? vzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Exists<object>(vzzzzzzzzzzzzzzzzzzzzzl_);

        return vzzzzzzzzzzzzzzzzzzzzzm_;
    }


    [CqlExpressionDefinition("Glucocorticoid Active Medication Days")]
    public int? Glucocorticoid_Active_Medication_Days(CqlContext context)
    {
        CqlValueSet xzzzzzzzzzzzzzzzzzzzzze_ = this.Glucocorticoids__oral_only_(context);
        IEnumerable<MedicationRequest> xzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, xzzzzzzzzzzzzzzzzzzzzze_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> xzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, xzzzzzzzzzzzzzzzzzzzzze_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> xzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Union<MedicationRequest>(xzzzzzzzzzzzzzzzzzzzzzf_, xzzzzzzzzzzzzzzzzzzzzzh_);
        IEnumerable<MedicationRequest> xzzzzzzzzzzzzzzzzzzzzzj_ = Status_1_8_000.Instance.isMedicationActive(context, xzzzzzzzzzzzzzzzzzzzzzi_);
        bool? xzzzzzzzzzzzzzzzzzzzzzk_(MedicationRequest OralGlucocorticoid)
        {
            CqlInterval<CqlDate> xzzzzzzzzzzzzzzzzzzzzzq_ = CumulativeMedicationDuration_4_1_000.Instance.medicationRequestPeriod(context, OralGlucocorticoid);
            CqlDate xzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Start(xzzzzzzzzzzzzzzzzzzzzzq_);
            CqlDateTime xzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.ConvertDateToDateTime(xzzzzzzzzzzzzzzzzzzzzzr_);
            CqlInterval<CqlDateTime> xzzzzzzzzzzzzzzzzzzzzzt_ = this.Measurement_Period(context);
            CqlDateTime xzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.End(xzzzzzzzzzzzzzzzzzzzzzt_);
            bool? xzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Before(xzzzzzzzzzzzzzzzzzzzzzs_, xzzzzzzzzzzzzzzzzzzzzzu_, default);

            return xzzzzzzzzzzzzzzzzzzzzzv_;
        };
        IEnumerable<MedicationRequest> xzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Where<MedicationRequest>(xzzzzzzzzzzzzzzzzzzzzzj_, xzzzzzzzzzzzzzzzzzzzzzk_);
        CqlInterval<CqlDate> xzzzzzzzzzzzzzzzzzzzzzm_(MedicationRequest Glucocorticoid)
        {
            CqlInterval<CqlDate> xzzzzzzzzzzzzzzzzzzzzzw_ = CumulativeMedicationDuration_4_1_000.Instance.medicationRequestPeriod(context, Glucocorticoid);
            Patient xzzzzzzzzzzzzzzzzzzzzzx_ = this.Patient(context);
            Date xzzzzzzzzzzzzzzzzzzzzzy_ = xzzzzzzzzzzzzzzzzzzzzzx_?.BirthDateElement;
            string xzzzzzzzzzzzzzzzzzzzzzz_ = xzzzzzzzzzzzzzzzzzzzzzy_?.Value;
            CqlDate yzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.ConvertStringToDate(xzzzzzzzzzzzzzzzzzzzzzz_);
            CqlInterval<CqlDateTime> yzzzzzzzzzzzzzzzzzzzzzb_ = this.Measurement_Period(context);
            CqlDateTime yzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.End(yzzzzzzzzzzzzzzzzzzzzzb_);
            CqlDate yzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.DateFrom(yzzzzzzzzzzzzzzzzzzzzzc_);
            CqlInterval<CqlDate> yzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.Interval(yzzzzzzzzzzzzzzzzzzzzza_, yzzzzzzzzzzzzzzzzzzzzzd_, true, true);
            CqlInterval<CqlDate> yzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Intersect<CqlDate>(xzzzzzzzzzzzzzzzzzzzzzw_, yzzzzzzzzzzzzzzzzzzzzze_);

            return yzzzzzzzzzzzzzzzzzzzzzf_;
        };
        IEnumerable<CqlInterval<CqlDate>> xzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Select<MedicationRequest, CqlInterval<CqlDate>>(xzzzzzzzzzzzzzzzzzzzzzl_, xzzzzzzzzzzzzzzzzzzzzzm_);
        IEnumerable<CqlInterval<CqlDate>> xzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Distinct<CqlInterval<CqlDate>>(xzzzzzzzzzzzzzzzzzzzzzn_);
        int? xzzzzzzzzzzzzzzzzzzzzzp_ = CumulativeMedicationDuration_4_1_000.Instance.cumulativeDuration(context, xzzzzzzzzzzzzzzzzzzzzzo_);

        return xzzzzzzzzzzzzzzzzzzzzzp_;
    }


    [CqlExpressionDefinition("Has 90 or More Active Glucocorticoid Medication Days")]
    public bool? Has_90_or_More_Active_Glucocorticoid_Medication_Days(CqlContext context)
    {
        int? yzzzzzzzzzzzzzzzzzzzzzg_ = this.Glucocorticoid_Active_Medication_Days(context);
        bool? yzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.GreaterOrEqual(yzzzzzzzzzzzzzzzzzzzzzg_, 90);

        return yzzzzzzzzzzzzzzzzzzzzzh_;
    }


    [CqlExpressionDefinition("diagnosisInPatientHistory")]
    public IEnumerable<Condition> diagnosisInPatientHistory(CqlContext context, IEnumerable<Condition> Condition)
    {
        bool? yzzzzzzzzzzzzzzzzzzzzzi_(Condition Dx)
        {
            CqlInterval<CqlDateTime> yzzzzzzzzzzzzzzzzzzzzzk_ = QICoreCommon_2_1_000.Instance.prevalenceInterval(context, Dx);
            CqlDateTime yzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Start(yzzzzzzzzzzzzzzzzzzzzzk_);
            CqlInterval<CqlDateTime> yzzzzzzzzzzzzzzzzzzzzzm_ = this.Measurement_Period(context);
            CqlDateTime yzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.End(yzzzzzzzzzzzzzzzzzzzzzm_);
            bool? yzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.SameOrBefore(yzzzzzzzzzzzzzzzzzzzzzl_, yzzzzzzzzzzzzzzzzzzzzzn_, "day");

            return yzzzzzzzzzzzzzzzzzzzzzo_;
        };
        IEnumerable<Condition> yzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Where<Condition>(Condition, yzzzzzzzzzzzzzzzzzzzzzi_);

        return yzzzzzzzzzzzzzzzzzzzzzj_;
    }


    [CqlExpressionDefinition("procedureInPatientHistory")]
    public IEnumerable<Procedure> procedureInPatientHistory(CqlContext context, IEnumerable<Procedure> Procedure)
    {
        IEnumerable<Procedure> yzzzzzzzzzzzzzzzzzzzzzp_ = Status_1_8_000.Instance.isProcedurePerformed(context, Procedure);
        bool? yzzzzzzzzzzzzzzzzzzzzzq_(Procedure Proc)
        {
            DataType yzzzzzzzzzzzzzzzzzzzzzs_ = Proc?.Performed;
            object yzzzzzzzzzzzzzzzzzzzzzt_ = FHIRHelpers_4_4_000.Instance.ToValue(context, yzzzzzzzzzzzzzzzzzzzzzs_);
            CqlInterval<CqlDateTime> yzzzzzzzzzzzzzzzzzzzzzu_ = QICoreCommon_2_1_000.Instance.toInterval(context, yzzzzzzzzzzzzzzzzzzzzzt_);
            CqlDateTime yzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.End(yzzzzzzzzzzzzzzzzzzzzzu_);
            CqlInterval<CqlDateTime> yzzzzzzzzzzzzzzzzzzzzzw_ = this.Measurement_Period(context);
            CqlDateTime yzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.End(yzzzzzzzzzzzzzzzzzzzzzw_);
            bool? yzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.SameOrBefore(yzzzzzzzzzzzzzzzzzzzzzv_, yzzzzzzzzzzzzzzzzzzzzzx_, "day");

            return yzzzzzzzzzzzzzzzzzzzzzy_;
        };
        IEnumerable<Procedure> yzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Where<Procedure>(yzzzzzzzzzzzzzzzzzzzzzp_, yzzzzzzzzzzzzzzzzzzzzzq_);

        return yzzzzzzzzzzzzzzzzzzzzzr_;
    }


    [CqlExpressionDefinition("Has Double or Bilateral Oophorectomy")]
    public bool? Has_Double_or_Bilateral_Oophorectomy(CqlContext context)
    {
        CqlValueSet yzzzzzzzzzzzzzzzzzzzzzz_ = this.Bilateral_Oophorectomy(context);
        IEnumerable<Procedure> zzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, yzzzzzzzzzzzzzzzzzzzzzz_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
        IEnumerable<Procedure> zzzzzzzzzzzzzzzzzzzzzzb_ = this.procedureInPatientHistory(context, zzzzzzzzzzzzzzzzzzzzzza_);
        bool? zzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Exists<Procedure>(zzzzzzzzzzzzzzzzzzzzzzb_);
        CqlValueSet zzzzzzzzzzzzzzzzzzzzzzd_ = this.Evidence_of_Bilateral_Oophorectomy(context);
        IEnumerable<Procedure> zzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, zzzzzzzzzzzzzzzzzzzzzzd_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
        IEnumerable<Procedure> zzzzzzzzzzzzzzzzzzzzzzf_ = this.procedureInPatientHistory(context, zzzzzzzzzzzzzzzzzzzzzze_);
        bool? zzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Exists<Procedure>(zzzzzzzzzzzzzzzzzzzzzzf_);
        bool? zzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Or(zzzzzzzzzzzzzzzzzzzzzzc_, zzzzzzzzzzzzzzzzzzzzzzg_);
        CqlValueSet zzzzzzzzzzzzzzzzzzzzzzi_ = this.Unilateral_Oophorectomy__Unspecified_Laterality(context);
        IEnumerable<Procedure> zzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, zzzzzzzzzzzzzzzzzzzzzzi_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
        bool? zzzzzzzzzzzzzzzzzzzzzzk_(Procedure UnilateralOophorectomy)
        {
            List<CodeableConcept> azzzzzzzzzzzzzzzzzzzzzzc_ = UnilateralOophorectomy?.BodySite;
            CqlConcept azzzzzzzzzzzzzzzzzzzzzzd_(CodeableConcept @this)
            {
                CqlConcept azzzzzzzzzzzzzzzzzzzzzzi_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);

                return azzzzzzzzzzzzzzzzzzzzzzi_;
            };
            IEnumerable<CqlConcept> azzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)azzzzzzzzzzzzzzzzzzzzzzc_, azzzzzzzzzzzzzzzzzzzzzzd_);
            bool? azzzzzzzzzzzzzzzzzzzzzzf_(CqlConcept C)
            {
                CqlCode azzzzzzzzzzzzzzzzzzzzzzj_ = this.Right__qualifier_value_(context);
                CqlConcept azzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.ConvertCodeToConcept(azzzzzzzzzzzzzzzzzzzzzzj_);
                bool? azzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Equivalent(C, azzzzzzzzzzzzzzzzzzzzzzk_);

                return azzzzzzzzzzzzzzzzzzzzzzl_;
            };
            IEnumerable<CqlConcept> azzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Where<CqlConcept>(azzzzzzzzzzzzzzzzzzzzzze_, azzzzzzzzzzzzzzzzzzzzzzf_);
            bool? azzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Exists<CqlConcept>(azzzzzzzzzzzzzzzzzzzzzzg_);

            return azzzzzzzzzzzzzzzzzzzzzzh_;
        };
        IEnumerable<Procedure> zzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Where<Procedure>(zzzzzzzzzzzzzzzzzzzzzzj_, zzzzzzzzzzzzzzzzzzzzzzk_);
        CqlValueSet zzzzzzzzzzzzzzzzzzzzzzm_ = this.Unilateral_Oophorectomy_Right(context);
        IEnumerable<Procedure> zzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, zzzzzzzzzzzzzzzzzzzzzzm_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
        IEnumerable<Procedure> zzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Union<Procedure>(zzzzzzzzzzzzzzzzzzzzzzl_, zzzzzzzzzzzzzzzzzzzzzzn_);
        IEnumerable<Procedure> zzzzzzzzzzzzzzzzzzzzzzp_ = this.procedureInPatientHistory(context, zzzzzzzzzzzzzzzzzzzzzzo_);
        bool? zzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Exists<Procedure>(zzzzzzzzzzzzzzzzzzzzzzp_);
        IEnumerable<Procedure> zzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, zzzzzzzzzzzzzzzzzzzzzzi_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
        bool? zzzzzzzzzzzzzzzzzzzzzzt_(Procedure UnilateralOophorectomy)
        {
            List<CodeableConcept> azzzzzzzzzzzzzzzzzzzzzzm_ = UnilateralOophorectomy?.BodySite;
            CqlConcept azzzzzzzzzzzzzzzzzzzzzzn_(CodeableConcept @this)
            {
                CqlConcept azzzzzzzzzzzzzzzzzzzzzzs_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);

                return azzzzzzzzzzzzzzzzzzzzzzs_;
            };
            IEnumerable<CqlConcept> azzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)azzzzzzzzzzzzzzzzzzzzzzm_, azzzzzzzzzzzzzzzzzzzzzzn_);
            bool? azzzzzzzzzzzzzzzzzzzzzzp_(CqlConcept D)
            {
                CqlCode azzzzzzzzzzzzzzzzzzzzzzt_ = this.Left__qualifier_value_(context);
                CqlConcept azzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.ConvertCodeToConcept(azzzzzzzzzzzzzzzzzzzzzzt_);
                bool? azzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Equivalent(D, azzzzzzzzzzzzzzzzzzzzzzu_);

                return azzzzzzzzzzzzzzzzzzzzzzv_;
            };
            IEnumerable<CqlConcept> azzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Where<CqlConcept>(azzzzzzzzzzzzzzzzzzzzzzo_, azzzzzzzzzzzzzzzzzzzzzzp_);
            bool? azzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Exists<CqlConcept>(azzzzzzzzzzzzzzzzzzzzzzq_);

            return azzzzzzzzzzzzzzzzzzzzzzr_;
        };
        IEnumerable<Procedure> zzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Where<Procedure>(zzzzzzzzzzzzzzzzzzzzzzs_, zzzzzzzzzzzzzzzzzzzzzzt_);
        CqlValueSet zzzzzzzzzzzzzzzzzzzzzzv_ = this.Unilateral_Oophorectomy_Left(context);
        IEnumerable<Procedure> zzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, zzzzzzzzzzzzzzzzzzzzzzv_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
        IEnumerable<Procedure> zzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Union<Procedure>(zzzzzzzzzzzzzzzzzzzzzzu_, zzzzzzzzzzzzzzzzzzzzzzw_);
        IEnumerable<Procedure> zzzzzzzzzzzzzzzzzzzzzzy_ = this.procedureInPatientHistory(context, zzzzzzzzzzzzzzzzzzzzzzx_);
        bool? zzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Exists<Procedure>(zzzzzzzzzzzzzzzzzzzzzzy_);
        bool? azzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.And(zzzzzzzzzzzzzzzzzzzzzzq_, zzzzzzzzzzzzzzzzzzzzzzz_);
        bool? azzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Or(zzzzzzzzzzzzzzzzzzzzzzh_, azzzzzzzzzzzzzzzzzzzzzza_);

        return azzzzzzzzzzzzzzzzzzzzzzb_;
    }


    [CqlExpressionDefinition("Has Organ Transplants")]
    public bool? Has_Organ_Transplants(CqlContext context)
    {
        CqlValueSet azzzzzzzzzzzzzzzzzzzzzzw_ = this.Major_Transplant(context);
        IEnumerable<Procedure> azzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, azzzzzzzzzzzzzzzzzzzzzzw_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
        CqlValueSet azzzzzzzzzzzzzzzzzzzzzzy_ = this.Kidney_Transplant(context);
        IEnumerable<Procedure> azzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, azzzzzzzzzzzzzzzzzzzzzzy_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
        IEnumerable<Procedure> bzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.Union<Procedure>(azzzzzzzzzzzzzzzzzzzzzzx_, azzzzzzzzzzzzzzzzzzzzzzz_);
        CqlValueSet bzzzzzzzzzzzzzzzzzzzzzzb_ = this.Bone_Marrow_Transplant(context);
        IEnumerable<Procedure> bzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, bzzzzzzzzzzzzzzzzzzzzzzb_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
        IEnumerable<Procedure> bzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Union<Procedure>(bzzzzzzzzzzzzzzzzzzzzzza_, bzzzzzzzzzzzzzzzzzzzzzzc_);
        IEnumerable<Procedure> bzzzzzzzzzzzzzzzzzzzzzze_ = this.procedureInPatientHistory(context, bzzzzzzzzzzzzzzzzzzzzzzd_);
        bool? bzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Exists<Procedure>(bzzzzzzzzzzzzzzzzzzzzzze_);

        return bzzzzzzzzzzzzzzzzzzzzzzf_;
    }


    [CqlExpressionDefinition("Has Risk Factor Any Time in History or During Measurement Period")]
    public bool? Has_Risk_Factor_Any_Time_in_History_or_During_Measurement_Period(CqlContext context)
    {
        bool? bzzzzzzzzzzzzzzzzzzzzzzg_ = this.Has_90_or_More_Active_Glucocorticoid_Medication_Days(context);
        CqlValueSet bzzzzzzzzzzzzzzzzzzzzzzh_ = this.Osteoporosis_With_Current_Fracture(context);
        IEnumerable<Condition> bzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, bzzzzzzzzzzzzzzzzzzzzzzh_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        CqlValueSet bzzzzzzzzzzzzzzzzzzzzzzj_ = this.Malabsorption_Syndromes(context);
        IEnumerable<Condition> bzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, bzzzzzzzzzzzzzzzzzzzzzzj_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        IEnumerable<Condition> bzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Union<Condition>(bzzzzzzzzzzzzzzzzzzzzzzi_, bzzzzzzzzzzzzzzzzzzzzzzk_);
        CqlValueSet bzzzzzzzzzzzzzzzzzzzzzzm_ = this.Chronic_Malnutrition(context);
        IEnumerable<Condition> bzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, bzzzzzzzzzzzzzzzzzzzzzzm_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        CqlValueSet bzzzzzzzzzzzzzzzzzzzzzzo_ = this.Chronic_Liver_Disease(context);
        IEnumerable<Condition> bzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, bzzzzzzzzzzzzzzzzzzzzzzo_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        IEnumerable<Condition> bzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Union<Condition>(bzzzzzzzzzzzzzzzzzzzzzzn_, bzzzzzzzzzzzzzzzzzzzzzzp_);
        IEnumerable<Condition> bzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Union<Condition>(bzzzzzzzzzzzzzzzzzzzzzzl_, bzzzzzzzzzzzzzzzzzzzzzzq_);
        CqlValueSet bzzzzzzzzzzzzzzzzzzzzzzs_ = this.Rheumatoid_Arthritis(context);
        IEnumerable<Condition> bzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, bzzzzzzzzzzzzzzzzzzzzzzs_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        CqlValueSet bzzzzzzzzzzzzzzzzzzzzzzu_ = this.Hyperthyroidism(context);
        IEnumerable<Condition> bzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, bzzzzzzzzzzzzzzzzzzzzzzu_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        IEnumerable<Condition> bzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Union<Condition>(bzzzzzzzzzzzzzzzzzzzzzzt_, bzzzzzzzzzzzzzzzzzzzzzzv_);
        IEnumerable<Condition> bzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Union<Condition>(bzzzzzzzzzzzzzzzzzzzzzzr_, bzzzzzzzzzzzzzzzzzzzzzzw_);
        CqlValueSet bzzzzzzzzzzzzzzzzzzzzzzy_ = this.Type_1_Diabetes(context);
        IEnumerable<Condition> bzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, bzzzzzzzzzzzzzzzzzzzzzzy_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        CqlValueSet czzzzzzzzzzzzzzzzzzzzzza_ = this.End_Stage_Renal_Disease(context);
        IEnumerable<Condition> czzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, czzzzzzzzzzzzzzzzzzzzzza_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        IEnumerable<Condition> czzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Union<Condition>(bzzzzzzzzzzzzzzzzzzzzzzz_, czzzzzzzzzzzzzzzzzzzzzzb_);
        IEnumerable<Condition> czzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Union<Condition>(bzzzzzzzzzzzzzzzzzzzzzzx_, czzzzzzzzzzzzzzzzzzzzzzc_);
        CqlValueSet czzzzzzzzzzzzzzzzzzzzzze_ = this.Osteogenesis_Imperfecta(context);
        IEnumerable<Condition> czzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, czzzzzzzzzzzzzzzzzzzzzze_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        CqlValueSet czzzzzzzzzzzzzzzzzzzzzzg_ = this.Ankylosing_Spondylitis(context);
        IEnumerable<Condition> czzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, czzzzzzzzzzzzzzzzzzzzzzg_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        IEnumerable<Condition> czzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Union<Condition>(czzzzzzzzzzzzzzzzzzzzzzf_, czzzzzzzzzzzzzzzzzzzzzzh_);
        IEnumerable<Condition> czzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Union<Condition>(czzzzzzzzzzzzzzzzzzzzzzd_, czzzzzzzzzzzzzzzzzzzzzzi_);
        CqlValueSet czzzzzzzzzzzzzzzzzzzzzzk_ = this.Psoriatic_Arthritis(context);
        IEnumerable<Condition> czzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, czzzzzzzzzzzzzzzzzzzzzzk_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        CqlValueSet czzzzzzzzzzzzzzzzzzzzzzm_ = this.Ehlers_Danlos_Syndrome(context);
        IEnumerable<Condition> czzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, czzzzzzzzzzzzzzzzzzzzzzm_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        IEnumerable<Condition> czzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Union<Condition>(czzzzzzzzzzzzzzzzzzzzzzl_, czzzzzzzzzzzzzzzzzzzzzzn_);
        IEnumerable<Condition> czzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Union<Condition>(czzzzzzzzzzzzzzzzzzzzzzj_, czzzzzzzzzzzzzzzzzzzzzzo_);
        CqlValueSet czzzzzzzzzzzzzzzzzzzzzzq_ = this.Cushings_Syndrome(context);
        IEnumerable<Condition> czzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, czzzzzzzzzzzzzzzzzzzzzzq_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        CqlValueSet czzzzzzzzzzzzzzzzzzzzzzs_ = this.Hyperparathyroidism(context);
        IEnumerable<Condition> czzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, czzzzzzzzzzzzzzzzzzzzzzs_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        IEnumerable<Condition> czzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Union<Condition>(czzzzzzzzzzzzzzzzzzzzzzr_, czzzzzzzzzzzzzzzzzzzzzzt_);
        IEnumerable<Condition> czzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Union<Condition>(czzzzzzzzzzzzzzzzzzzzzzp_, czzzzzzzzzzzzzzzzzzzzzzu_);
        CqlValueSet czzzzzzzzzzzzzzzzzzzzzzw_ = this.Marfans_Syndrome(context);
        IEnumerable<Condition> czzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, czzzzzzzzzzzzzzzzzzzzzzw_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        CqlValueSet czzzzzzzzzzzzzzzzzzzzzzy_ = this.Lupus(context);
        IEnumerable<Condition> czzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, czzzzzzzzzzzzzzzzzzzzzzy_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        IEnumerable<Condition> dzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.Union<Condition>(czzzzzzzzzzzzzzzzzzzzzzx_, czzzzzzzzzzzzzzzzzzzzzzz_);
        IEnumerable<Condition> dzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Union<Condition>(czzzzzzzzzzzzzzzzzzzzzzv_, dzzzzzzzzzzzzzzzzzzzzzza_);
        CqlValueSet dzzzzzzzzzzzzzzzzzzzzzzc_ = this.Multiple_Myeloma(context);
        IEnumerable<Condition> dzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, dzzzzzzzzzzzzzzzzzzzzzzc_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        CqlValueSet dzzzzzzzzzzzzzzzzzzzzzze_ = this.Premature_Menopause(context);
        IEnumerable<Condition> dzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, dzzzzzzzzzzzzzzzzzzzzzze_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        IEnumerable<Condition> dzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Union<Condition>(dzzzzzzzzzzzzzzzzzzzzzzd_, dzzzzzzzzzzzzzzzzzzzzzzf_);
        IEnumerable<Condition> dzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Union<Condition>(dzzzzzzzzzzzzzzzzzzzzzzb_, dzzzzzzzzzzzzzzzzzzzzzzg_);
        CqlValueSet dzzzzzzzzzzzzzzzzzzzzzzi_ = this.Eating_Disorders(context);
        IEnumerable<Condition> dzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, dzzzzzzzzzzzzzzzzzzzzzzi_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        CqlValueSet dzzzzzzzzzzzzzzzzzzzzzzk_ = this.Amenorrhea(context);
        IEnumerable<Condition> dzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, dzzzzzzzzzzzzzzzzzzzzzzk_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        IEnumerable<Condition> dzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Union<Condition>(dzzzzzzzzzzzzzzzzzzzzzzj_, dzzzzzzzzzzzzzzzzzzzzzzl_);
        IEnumerable<Condition> dzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Union<Condition>(dzzzzzzzzzzzzzzzzzzzzzzh_, dzzzzzzzzzzzzzzzzzzzzzzm_);
        IEnumerable<Condition> dzzzzzzzzzzzzzzzzzzzzzzo_ = this.diagnosisInPatientHistory(context, dzzzzzzzzzzzzzzzzzzzzzzn_);
        bool? dzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Exists<Condition>(dzzzzzzzzzzzzzzzzzzzzzzo_);
        bool? dzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Or(bzzzzzzzzzzzzzzzzzzzzzzg_, dzzzzzzzzzzzzzzzzzzzzzzp_);
        CqlValueSet dzzzzzzzzzzzzzzzzzzzzzzr_ = this.Chemotherapy(context);
        IEnumerable<Procedure> dzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, dzzzzzzzzzzzzzzzzzzzzzzr_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
        IEnumerable<Procedure> dzzzzzzzzzzzzzzzzzzzzzzt_ = this.procedureInPatientHistory(context, dzzzzzzzzzzzzzzzzzzzzzzs_);
        bool? dzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Exists<Procedure>(dzzzzzzzzzzzzzzzzzzzzzzt_);
        bool? dzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Or(dzzzzzzzzzzzzzzzzzzzzzzq_, dzzzzzzzzzzzzzzzzzzzzzzu_);
        bool? dzzzzzzzzzzzzzzzzzzzzzzw_ = this.Has_Double_or_Bilateral_Oophorectomy(context);
        bool? dzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Or(dzzzzzzzzzzzzzzzzzzzzzzv_, dzzzzzzzzzzzzzzzzzzzzzzw_);
        bool? dzzzzzzzzzzzzzzzzzzzzzzy_ = this.Has_Organ_Transplants(context);
        bool? dzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Or(dzzzzzzzzzzzzzzzzzzzzzzx_, dzzzzzzzzzzzzzzzzzzzzzzy_);

        return dzzzzzzzzzzzzzzzzzzzzzzz_;
    }


    [CqlExpressionDefinition("Denominator Exclusions")]
    public bool? Denominator_Exclusions(CqlContext context)
    {
        bool? ezzzzzzzzzzzzzzzzzzzzzza_ = this.Has_Risk_Factor_Active_During_the_Measurement_Period(context);
        bool? ezzzzzzzzzzzzzzzzzzzzzzb_ = this.Has_Risk_Factor_Any_Time_in_History_Prior_to_Measurement_Period(context);
        bool? ezzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Or(ezzzzzzzzzzzzzzzzzzzzzza_, ezzzzzzzzzzzzzzzzzzzzzzb_);
        bool? ezzzzzzzzzzzzzzzzzzzzzzd_ = this.Has_Risk_Factor_Any_Time_in_History_or_During_Measurement_Period(context);
        bool? ezzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.Or(ezzzzzzzzzzzzzzzzzzzzzzc_, ezzzzzzzzzzzzzzzzzzzzzzd_);

        return ezzzzzzzzzzzzzzzzzzzzzze_;
    }


    [CqlExpressionDefinition("DXA Scan Order During Measurement Period")]
    public IEnumerable<ServiceRequest> DXA_Scan_Order_During_Measurement_Period(CqlContext context)
    {
        CqlValueSet ezzzzzzzzzzzzzzzzzzzzzzf_ = this.DXA__Dual_energy_Xray_Absorptiometry__Scan(context);
        IEnumerable<ServiceRequest> ezzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Retrieve<ServiceRequest>(new RetrieveParameters(default, ezzzzzzzzzzzzzzzzzzzzzzf_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-servicerequest"));
        IEnumerable<ServiceRequest> ezzzzzzzzzzzzzzzzzzzzzzh_ = Status_1_8_000.Instance.isDiagnosticStudyOrder(context, ezzzzzzzzzzzzzzzzzzzzzzg_);
        bool? ezzzzzzzzzzzzzzzzzzzzzzi_(ServiceRequest DXA)
        {
            CqlInterval<CqlDateTime> ezzzzzzzzzzzzzzzzzzzzzzm_ = this.Measurement_Period(context);
            FhirDateTime ezzzzzzzzzzzzzzzzzzzzzzn_ = DXA?.AuthoredOnElement;
            CqlDateTime ezzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Convert<CqlDateTime>(ezzzzzzzzzzzzzzzzzzzzzzn_);
            CqlInterval<CqlDateTime> ezzzzzzzzzzzzzzzzzzzzzzp_ = QICoreCommon_2_1_000.Instance.toInterval(context, ezzzzzzzzzzzzzzzzzzzzzzo_ as object);
            bool? ezzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(ezzzzzzzzzzzzzzzzzzzzzzm_, ezzzzzzzzzzzzzzzzzzzzzzp_, default);

            return ezzzzzzzzzzzzzzzzzzzzzzq_;
        };
        IEnumerable<ServiceRequest> ezzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Where<ServiceRequest>(ezzzzzzzzzzzzzzzzzzzzzzh_, ezzzzzzzzzzzzzzzzzzzzzzi_);
        object ezzzzzzzzzzzzzzzzzzzzzzk_(ServiceRequest @this)
        {
            FhirDateTime ezzzzzzzzzzzzzzzzzzzzzzr_ = @this?.AuthoredOnElement;
            CqlDateTime ezzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Convert<CqlDateTime>(ezzzzzzzzzzzzzzzzzzzzzzr_);

            return ezzzzzzzzzzzzzzzzzzzzzzs_;
        };
        IEnumerable<ServiceRequest> ezzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.SortBy<ServiceRequest>(ezzzzzzzzzzzzzzzzzzzzzzj_, ezzzzzzzzzzzzzzzzzzzzzzk_, System.ComponentModel.ListSortDirection.Ascending);

        return ezzzzzzzzzzzzzzzzzzzzzzl_;
    }


    [CqlExpressionDefinition("Numerator")]
    public bool? Numerator(CqlContext context)
    {
        IEnumerable<ServiceRequest> ezzzzzzzzzzzzzzzzzzzzzzt_ = this.DXA_Scan_Order_During_Measurement_Period(context);
        bool? ezzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Exists<ServiceRequest>(ezzzzzzzzzzzzzzzzzzzzzzt_);

        return ezzzzzzzzzzzzzzzzzzzzzzu_;
    }


    [CqlExpressionDefinition("Osteoporosis Fracture Risk Assessment Prior to First DXA Scan")]
    public IEnumerable<Observation> Osteoporosis_Fracture_Risk_Assessment_Prior_to_First_DXA_Scan(CqlContext context)
    {
        CqlCode ezzzzzzzzzzzzzzzzzzzzzzv_ = this.Major_osteoporotic_fracture_10_year_probability__Likelihood__Fracture_Risk_Assessment(context);
        IEnumerable<CqlCode> ezzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.ToList<CqlCode>(ezzzzzzzzzzzzzzzzzzzzzzv_);
        IEnumerable<Observation> ezzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, ezzzzzzzzzzzzzzzzzzzzzzw_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
        IEnumerable<Observation> ezzzzzzzzzzzzzzzzzzzzzzy_ = Status_1_8_000.Instance.isAssessmentPerformed(context, ezzzzzzzzzzzzzzzzzzzzzzx_);
        bool? ezzzzzzzzzzzzzzzzzzzzzzz_(Observation FRAX)
        {
            DataType fzzzzzzzzzzzzzzzzzzzzzzy_ = FRAX?.Value;
            object fzzzzzzzzzzzzzzzzzzzzzzz_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fzzzzzzzzzzzzzzzzzzzzzzy_);
            CqlQuantity gzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.Quantity(8.4m, "%");
            bool? gzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.GreaterOrEqual(fzzzzzzzzzzzzzzzzzzzzzzz_ as CqlQuantity, gzzzzzzzzzzzzzzzzzzzzzza_);

            return gzzzzzzzzzzzzzzzzzzzzzzb_;
        };
        IEnumerable<Observation> fzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.Where<Observation>(ezzzzzzzzzzzzzzzzzzzzzzy_, ezzzzzzzzzzzzzzzzzzzzzzz_);
        CqlCode fzzzzzzzzzzzzzzzzzzzzzzb_ = this.Osteoporosis_Risk_Assessment_Instrument(context);
        IEnumerable<CqlCode> fzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.ToList<CqlCode>(fzzzzzzzzzzzzzzzzzzzzzzb_);
        IEnumerable<Observation> fzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, fzzzzzzzzzzzzzzzzzzzzzzc_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
        IEnumerable<Observation> fzzzzzzzzzzzzzzzzzzzzzze_ = Status_1_8_000.Instance.isAssessmentPerformed(context, fzzzzzzzzzzzzzzzzzzzzzzd_);
        bool? fzzzzzzzzzzzzzzzzzzzzzzf_(Observation ORAI)
        {
            DataType gzzzzzzzzzzzzzzzzzzzzzzc_ = ORAI?.Value;
            object gzzzzzzzzzzzzzzzzzzzzzzd_ = FHIRHelpers_4_4_000.Instance.ToValue(context, gzzzzzzzzzzzzzzzzzzzzzzc_);
            bool? gzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.GreaterOrEqual(gzzzzzzzzzzzzzzzzzzzzzzd_ as int?, 9);

            return gzzzzzzzzzzzzzzzzzzzzzze_;
        };
        IEnumerable<Observation> fzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Where<Observation>(fzzzzzzzzzzzzzzzzzzzzzze_, fzzzzzzzzzzzzzzzzzzzzzzf_);
        IEnumerable<Observation> fzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Union<Observation>(fzzzzzzzzzzzzzzzzzzzzzza_, fzzzzzzzzzzzzzzzzzzzzzzg_);
        CqlCode fzzzzzzzzzzzzzzzzzzzzzzi_ = this.Osteoporosis_Index_of_Risk_panel(context);
        IEnumerable<CqlCode> fzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.ToList<CqlCode>(fzzzzzzzzzzzzzzzzzzzzzzi_);
        IEnumerable<Observation> fzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, fzzzzzzzzzzzzzzzzzzzzzzj_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
        IEnumerable<Observation> fzzzzzzzzzzzzzzzzzzzzzzl_ = Status_1_8_000.Instance.isAssessmentPerformed(context, fzzzzzzzzzzzzzzzzzzzzzzk_);
        bool? fzzzzzzzzzzzzzzzzzzzzzzm_(Observation OSIRIS)
        {
            DataType gzzzzzzzzzzzzzzzzzzzzzzf_ = OSIRIS?.Value;
            object gzzzzzzzzzzzzzzzzzzzzzzg_ = FHIRHelpers_4_4_000.Instance.ToValue(context, gzzzzzzzzzzzzzzzzzzzzzzf_);
            CqlQuantity gzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.ConvertDecimalToQuantity(1.0m);
            bool? gzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Less(gzzzzzzzzzzzzzzzzzzzzzzg_ as CqlQuantity, gzzzzzzzzzzzzzzzzzzzzzzh_);

            return gzzzzzzzzzzzzzzzzzzzzzzi_;
        };
        IEnumerable<Observation> fzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Where<Observation>(fzzzzzzzzzzzzzzzzzzzzzzl_, fzzzzzzzzzzzzzzzzzzzzzzm_);
        CqlCode fzzzzzzzzzzzzzzzzzzzzzzo_ = this.Osteoporosis_Self_Assessment_Tool(context);
        IEnumerable<CqlCode> fzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.ToList<CqlCode>(fzzzzzzzzzzzzzzzzzzzzzzo_);
        IEnumerable<Observation> fzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, fzzzzzzzzzzzzzzzzzzzzzzp_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
        IEnumerable<Observation> fzzzzzzzzzzzzzzzzzzzzzzr_ = Status_1_8_000.Instance.isAssessmentPerformed(context, fzzzzzzzzzzzzzzzzzzzzzzq_);
        bool? fzzzzzzzzzzzzzzzzzzzzzzs_(Observation OST)
        {
            DataType gzzzzzzzzzzzzzzzzzzzzzzj_ = OST?.Value;
            object gzzzzzzzzzzzzzzzzzzzzzzk_ = FHIRHelpers_4_4_000.Instance.ToValue(context, gzzzzzzzzzzzzzzzzzzzzzzj_);
            CqlQuantity gzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.ConvertDecimalToQuantity(2.0m);
            bool? gzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Less(gzzzzzzzzzzzzzzzzzzzzzzk_ as CqlQuantity, gzzzzzzzzzzzzzzzzzzzzzzl_);

            return gzzzzzzzzzzzzzzzzzzzzzzm_;
        };
        IEnumerable<Observation> fzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Where<Observation>(fzzzzzzzzzzzzzzzzzzzzzzr_, fzzzzzzzzzzzzzzzzzzzzzzs_);
        IEnumerable<Observation> fzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Union<Observation>(fzzzzzzzzzzzzzzzzzzzzzzn_, fzzzzzzzzzzzzzzzzzzzzzzt_);
        IEnumerable<Observation> fzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Union<Observation>(fzzzzzzzzzzzzzzzzzzzzzzh_, fzzzzzzzzzzzzzzzzzzzzzzu_);
        bool? fzzzzzzzzzzzzzzzzzzzzzzw_(Observation RiskAssessment)
        {
            DataType gzzzzzzzzzzzzzzzzzzzzzzn_ = RiskAssessment?.Effective;
            object gzzzzzzzzzzzzzzzzzzzzzzo_ = FHIRHelpers_4_4_000.Instance.ToValue(context, gzzzzzzzzzzzzzzzzzzzzzzn_);
            CqlInterval<CqlDateTime> gzzzzzzzzzzzzzzzzzzzzzzp_ = QICoreCommon_2_1_000.Instance.toInterval(context, gzzzzzzzzzzzzzzzzzzzzzzo_);
            CqlDateTime gzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Start(gzzzzzzzzzzzzzzzzzzzzzzp_);
            IEnumerable<ServiceRequest> gzzzzzzzzzzzzzzzzzzzzzzr_ = this.DXA_Scan_Order_During_Measurement_Period(context);
            ServiceRequest gzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.First<ServiceRequest>(gzzzzzzzzzzzzzzzzzzzzzzr_);
            FhirDateTime gzzzzzzzzzzzzzzzzzzzzzzt_ = gzzzzzzzzzzzzzzzzzzzzzzs_?.AuthoredOnElement;
            CqlDateTime gzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Convert<CqlDateTime>(gzzzzzzzzzzzzzzzzzzzzzzt_);
            bool? gzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Before(gzzzzzzzzzzzzzzzzzzzzzzq_, gzzzzzzzzzzzzzzzzzzzzzzu_, default);

            return gzzzzzzzzzzzzzzzzzzzzzzv_;
        };
        IEnumerable<Observation> fzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Where<Observation>(fzzzzzzzzzzzzzzzzzzzzzzv_, fzzzzzzzzzzzzzzzzzzzzzzw_);

        return fzzzzzzzzzzzzzzzzzzzzzzx_;
    }


    [CqlExpressionDefinition("Numerator Exclusion")]
    public bool? Numerator_Exclusion(CqlContext context)
    {
        IEnumerable<Observation> gzzzzzzzzzzzzzzzzzzzzzzw_ = this.Osteoporosis_Fracture_Risk_Assessment_Prior_to_First_DXA_Scan(context);
        bool? gzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Exists<Observation>(gzzzzzzzzzzzzzzzzzzzzzzw_);

        return gzzzzzzzzzzzzzzzzzzzzzzx_;
    }


    #endregion Expressions

}

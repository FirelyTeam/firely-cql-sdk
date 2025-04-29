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
        CqlDateTime hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.DateTime(2025, 1, 1, 0, 0, 0, 0, 0.0m);
        CqlDateTime hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.DateTime(2025, 12, 31, 23, 59, 59, 999, 0.0m);
        CqlInterval<CqlDateTime> hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Interval(hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_, hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_, true, true);
        object hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.ResolveParameter("AppropriateDXAScansForWomenUnder65FHIR-0.2.001", "Measurement Period", hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_);

        return (CqlInterval<CqlDateTime>)hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_;
    }


    #endregion Parameters

    #region Expressions

    [CqlExpressionDefinition("Patient")]
    public Patient Patient(CqlContext context)
    {
        IEnumerable<Patient> izzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-patient"));
        Patient izzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.SingletonFrom<Patient>(izzzzzzzzzzzzzzzzzzzzzzzzzzzzza_);

        return izzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_;
    }


    [CqlExpressionDefinition("SDE Ethnicity")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Ethnicity(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? izzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = SupplementalDataElements_3_5_000.Instance.SDE_Ethnicity(context);

        return izzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_;
    }


    [CqlExpressionDefinition("SDE Payer")]
    public IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> SDE_Payer(CqlContext context)
    {
        IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> izzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = SupplementalDataElements_3_5_000.Instance.SDE_Payer(context);

        return izzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_;
    }


    [CqlExpressionDefinition("SDE Race")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Race(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? izzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = SupplementalDataElements_3_5_000.Instance.SDE_Race(context);

        return izzzzzzzzzzzzzzzzzzzzzzzzzzzzze_;
    }


    [CqlExpressionDefinition("SDE Sex")]
    public CqlCode SDE_Sex(CqlContext context)
    {
        CqlCode izzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = SupplementalDataElements_3_5_000.Instance.SDE_Sex(context);

        return izzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_;
    }


    [CqlExpressionDefinition("Qualifying Encounter")]
    public IEnumerable<Encounter> Qualifying_Encounter(CqlContext context)
    {
        CqlValueSet izzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = this.Office_Visit(context);
        IEnumerable<Encounter> izzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, izzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        CqlValueSet izzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = this.Preventive_Care_Services_Established_Office_Visit__18_and_Up(context);
        IEnumerable<Encounter> izzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, izzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> izzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Union<Encounter>(izzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_, izzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_);
        IEnumerable<Encounter> izzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        bool? izzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_(Encounter E)
        {
            List<CodeableConcept> jzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = E?.Type;
            CqlConcept jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_(CodeableConcept @this)
            {
                CqlConcept jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);

                return jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_;
            };
            IEnumerable<CqlConcept> jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)jzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_, jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_);
            bool? jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_(CqlConcept T)
            {
                CqlCode jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = this.Unlisted_preventive_medicine_service(context);
                CqlConcept jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.ConvertCodeToConcept(jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_);
                bool? jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Equivalent(T, jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_);

                return jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_;
            };
            IEnumerable<CqlConcept> jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Where<CqlConcept>(jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_, jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_);
            bool? jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Exists<CqlConcept>(jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_);

            return jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_;
        };
        IEnumerable<Encounter> izzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Where<Encounter>(izzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_, izzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_);
        CqlValueSet izzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = this.Preventive_Care_Services_Initial_Office_Visit__18_and_Up(context);
        IEnumerable<Encounter> izzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, izzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> izzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Union<Encounter>(izzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_, izzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_);
        IEnumerable<Encounter> izzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Union<Encounter>(izzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_, izzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_);
        CqlValueSet izzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = this.Outpatient_Consultation(context);
        IEnumerable<Encounter> izzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, izzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        CqlValueSet izzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = this.Virtual_Encounter(context);
        IEnumerable<Encounter> izzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, izzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> izzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Union<Encounter>(izzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_, izzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_);
        IEnumerable<Encounter> izzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Union<Encounter>(izzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_, izzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_);
        CqlValueSet izzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = this.Telephone_Visits(context);
        IEnumerable<Encounter> izzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, izzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> jzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.Union<Encounter>(izzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_, izzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_);
        IEnumerable<Encounter> jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = Status_1_8_000.Instance.isEncounterPerformed(context, jzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_);
        bool? jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_(Encounter ValidEncounters)
        {
            CqlInterval<CqlDateTime> jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = this.Measurement_Period(context);
            Period jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = ValidEncounters?.Period;
            CqlInterval<CqlDateTime> jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_);
            CqlInterval<CqlDateTime> jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = QICoreCommon_2_1_000.Instance.toInterval(context, jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ as object);
            bool? jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_, jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_, "day");

            return jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_;
        };
        IEnumerable<Encounter> jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Where<Encounter>(jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_, jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_);

        return jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_;
    }


    [CqlExpressionDefinition("Initial Population")]
    public bool? Initial_Population(CqlContext context)
    {
        Patient jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = this.Patient(context);
        Date jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_?.BirthDateElement;
        string jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_?.Value;
        CqlDate jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.ConvertStringToDate(jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_);
        CqlInterval<CqlDateTime> jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = this.Measurement_Period(context);
        CqlDateTime jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Start(jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_);
        CqlDate jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.DateFrom(jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_);
        int? kzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.CalculateAgeAt(jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_, jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_, "year");
        CqlInterval<int?> kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Interval(50, 63, true, true);
        bool? kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.In<int?>(kzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_, kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_, default);
        Code<AdministrativeGender> kzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_?.GenderElement;
        AdministrativeGender? kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = kzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_?.Value;
        string kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Convert<string>(kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_);
        bool? kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Equal(kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_, "female");
        bool? kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.And(kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_, kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_);
        IEnumerable<Encounter> kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = this.Qualifying_Encounter(context);
        bool? kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Exists<Encounter>(kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_);
        bool? kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.And(kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_, kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_);

        return kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_;
    }


    [CqlExpressionDefinition("Denominator")]
    public bool? Denominator(CqlContext context)
    {
        bool? kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = this.Initial_Population(context);

        return kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_;
    }


    [CqlExpressionDefinition("First BMI in Measurement Period")]
    public Observation First_BMI_in_Measurement_Period(CqlContext context)
    {
        IEnumerable<Observation> kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/StructureDefinition/bmi"));
        IEnumerable<Observation> kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = Status_1_8_000.Instance.isObservationBMI(context, kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_);
        bool? kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_(Observation BMIRatio)
        {
            CqlInterval<CqlDateTime> kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = this.Measurement_Period(context);
            DataType kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = BMIRatio?.Effective;
            object kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = FHIRHelpers_4_4_000.Instance.ToValue(context, kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_);
            CqlInterval<CqlDateTime> kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = QICoreCommon_2_1_000.Instance.toInterval(context, kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_);
            bool? kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_, kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_, default);
            DataType kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = BMIRatio?.Value;
            CqlQuantity lzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = FHIRHelpers_4_4_000.Instance.ToQuantity(context, kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ as Quantity);
            bool? lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Not((bool?)((lzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ as CqlQuantity) is null));
            bool? lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.And(kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_, lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_);

            return lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_;
        };
        IEnumerable<Observation> kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Where<Observation>(kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_, kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_);
        object kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_(Observation @this)
        {
            DataType lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = @this?.Effective;
            object lzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = FHIRHelpers_4_4_000.Instance.ToValue(context, lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_);
            CqlInterval<CqlDateTime> lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = QICoreCommon_2_1_000.Instance.toInterval(context, lzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_);
            CqlDateTime lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Start(lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_);

            return lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_;
        };
        IEnumerable<Observation> kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.SortBy<Observation>(kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_, kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_, System.ComponentModel.ListSortDirection.Ascending);
        Observation kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.First<Observation>(kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_);

        return kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_;
    }


    [CqlExpressionDefinition("First BMI in Measurement Period Less Than or Equal to 20 kg m2")]
    public Observation First_BMI_in_Measurement_Period_Less_Than_or_Equal_to_20_kg_m2(CqlContext context)
    {
        Observation lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = this.First_BMI_in_Measurement_Period(context);
        Observation[] lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = [
            lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_,
        ];
        bool? lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_(Observation FirstBMI)
        {
            DataType lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = FirstBMI?.Value;
            CqlQuantity lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = FHIRHelpers_4_4_000.Instance.ToQuantity(context, lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ as Quantity);
            CqlQuantity lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Quantity(20m, "kg/m2");
            bool? lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.LessOrEqual(lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ as CqlQuantity, lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_);

            return lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_;
        };
        IEnumerable<Observation> lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Where<Observation>((IEnumerable<Observation>)lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_, lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_);
        Observation lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.SingletonFrom<Observation>(lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_);

        return lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_;
    }


    [CqlExpressionDefinition("First Average Number of Drinks Assessments Indicating More Than Two Per Day")]
    public Observation First_Average_Number_of_Drinks_Assessments_Indicating_More_Than_Two_Per_Day(CqlContext context)
    {
        CqlCode lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = this.Alcoholic_drinks_per_day(context);
        IEnumerable<CqlCode> lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.ToList<CqlCode>(lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_);
        IEnumerable<Observation> lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
        IEnumerable<Observation> lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = Status_1_8_000.Instance.isAssessmentPerformed(context, lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_);
        bool? lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_(Observation AverageDrinks)
        {
            DataType lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = AverageDrinks?.Effective;
            object mzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = FHIRHelpers_4_4_000.Instance.ToValue(context, lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_);
            CqlInterval<CqlDateTime> mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = QICoreCommon_2_1_000.Instance.toInterval(context, mzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_);
            CqlDateTime mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Start(mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_);
            CqlInterval<CqlDateTime> mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = this.Measurement_Period(context);
            bool? mzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.In<CqlDateTime>(mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_, mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_, default);
            DataType mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = AverageDrinks?.Value;
            object mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = FHIRHelpers_4_4_000.Instance.ToValue(context, mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_);
            CqlQuantity mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Quantity(2m, "{drinks}/d");
            bool? mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Greater(mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ as CqlQuantity, mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_);
            bool? mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.And(mzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_, mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_);

            return mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_;
        };
        IEnumerable<Observation> lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Where<Observation>(lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_, lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_);
        object lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_(Observation @this)
        {
            DataType mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = @this?.Effective;
            object mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = FHIRHelpers_4_4_000.Instance.ToValue(context, mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_);
            CqlInterval<CqlDateTime> mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = QICoreCommon_2_1_000.Instance.toInterval(context, mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_);
            CqlDateTime mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Start(mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_);

            return mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_;
        };
        IEnumerable<Observation> lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.SortBy<Observation>(lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_, lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_, System.ComponentModel.ListSortDirection.Ascending);
        Observation lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.First<Observation>(lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_);

        return lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_;
    }


    [CqlExpressionDefinition("Has Risk Factor Active During the Measurement Period")]
    public bool? Has_Risk_Factor_Active_During_the_Measurement_Period(CqlContext context)
    {
        Observation mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = this.First_BMI_in_Measurement_Period_Less_Than_or_Equal_to_20_kg_m2(context);
        bool? mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Not((bool?)(mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ is null));
        Observation mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = this.First_Average_Number_of_Drinks_Assessments_Indicating_More_Than_Two_Per_Day(context);
        bool? mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Not((bool?)(mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ is null));
        bool? mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Or(mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_, mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_);

        return mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_;
    }


    [CqlExpressionDefinition("Has Risk Factor Any Time in History Prior to Measurement Period")]
    public bool? Has_Risk_Factor_Any_Time_in_History_Prior_to_Measurement_Period(CqlContext context)
    {
        CqlValueSet mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = this.Osteoporosis_Without_Current_Fracture(context);
        IEnumerable<Condition> mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        bool? mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_(Condition OsteoporosisDiagnosis)
        {
            CqlInterval<CqlDateTime> ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = QICoreCommon_2_1_000.Instance.prevalenceInterval(context, OsteoporosisDiagnosis);
            CqlDateTime ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Start(ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_);
            CqlInterval<CqlDateTime> ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = this.Measurement_Period(context);
            CqlDateTime ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Start(ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_);
            bool? ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Before(ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_, ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_, default);

            return ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_;
        };
        IEnumerable<Condition> mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Where<Condition>(mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_, mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_);
        CqlValueSet mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = this.Osteopenia(context);
        IEnumerable<Condition> mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        bool? mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_(Condition OsteopeniaDiagnosis)
        {
            CqlInterval<CqlDateTime> ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = QICoreCommon_2_1_000.Instance.prevalenceInterval(context, OsteopeniaDiagnosis);
            CqlDateTime ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Start(ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_);
            CqlInterval<CqlDateTime> ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = this.Measurement_Period(context);
            CqlDateTime ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Start(ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_);
            bool? ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Before(ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_, ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_, default);

            return ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_;
        };
        IEnumerable<Condition> nzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.Where<Condition>(mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_, mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_);
        IEnumerable<Condition> nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Union<Condition>(mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_, nzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_);
        CqlValueSet nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = this.Gastric_Bypass_Surgery(context);
        IEnumerable<Procedure> nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
        IEnumerable<Procedure> nzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = Status_1_8_000.Instance.isProcedurePerformed(context, nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_);
        bool? nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_(Procedure GastricBypass)
        {
            DataType ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = GastricBypass?.Performed;
            object ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_);
            CqlInterval<CqlDateTime> ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = QICoreCommon_2_1_000.Instance.toInterval(context, ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_);
            CqlDateTime ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.End(ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_);
            CqlInterval<CqlDateTime> ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = this.Measurement_Period(context);
            CqlDateTime ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Start(ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_);
            bool? ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Before(ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_, ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_, default);

            return ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_;
        };
        IEnumerable<Procedure> nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Where<Procedure>(nzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_, nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_);
        CqlValueSet nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = this.Aromatase_Inhibitors(context);
        IEnumerable<MedicationRequest> nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Union<MedicationRequest>(nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_, nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_);
        IEnumerable<MedicationRequest> nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = Status_1_8_000.Instance.isMedicationActive(context, nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_);
        bool? nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_(MedicationRequest AromataseInhibitorActive)
        {
            CqlInterval<CqlDate> ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = CumulativeMedicationDuration_4_1_000.Instance.MedicationRequestPeriod(context, AromataseInhibitorActive);
            CqlDate ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Start(ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_);
            CqlDateTime pzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.ConvertDateToDateTime(ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_);
            CqlInterval<CqlDateTime> pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = this.Measurement_Period(context);
            CqlDateTime pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Start(pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_);
            bool? pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Before(pzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_, pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_, default);

            return pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_;
        };
        IEnumerable<MedicationRequest> nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Where<MedicationRequest>(nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_, nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_);
        IEnumerable<object> nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Union<object>(nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ as IEnumerable<object>, nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ as IEnumerable<object>);
        IEnumerable<MedicationRequest> nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Union<MedicationRequest>(nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_, nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_);
        IEnumerable<MedicationRequest> nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = Status_1_8_000.Instance.isMedicationOrder(context, nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_);
        bool? nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_(MedicationRequest AromataseInhibitorOrder)
        {
            FhirDateTime pzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = AromataseInhibitorOrder?.AuthoredOnElement;
            CqlDateTime pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Convert<CqlDateTime>(pzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_);
            CqlInterval<CqlDateTime> pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = QICoreCommon_2_1_000.Instance.toInterval(context, pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ as object);
            CqlInterval<CqlDateTime> pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_()
            {
                bool pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_()
                {
                    CqlInterval<CqlDateTime> pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = this.Measurement_Period(context);
                    CqlDateTime pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Start(pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_);

                    return pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ is null;
                };
                if (pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_())
                {
                    return default;
                }
                else
                {
                    CqlInterval<CqlDateTime> pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = this.Measurement_Period(context);
                    CqlDateTime pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Start(pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_);
                    CqlDateTime pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Start(pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_);
                    CqlInterval<CqlDateTime> pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Interval(pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_, pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_, true, true);

                    return pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_;
                }
            };
            bool? pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Before(pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_, pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_(), default);

            return pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_;
        };
        IEnumerable<MedicationRequest> nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Where<MedicationRequest>(nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_, nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_);
        IEnumerable<object> nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Union<object>(nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ as IEnumerable<object>, nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ as IEnumerable<object>);
        CqlValueSet nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = this.History_of_hip_fracture_in_parent(context);
        IEnumerable<Observation> ozzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
        IEnumerable<Observation> ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = Status_1_8_000.Instance.isAssessmentPerformed(context, ozzzzzzzzzzzzzzzzzzzzzzzzzzzzza_);
        bool? ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_(Observation ParentFractureHistory)
        {
            DataType pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = ParentFractureHistory?.Effective;
            object pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = FHIRHelpers_4_4_000.Instance.ToValue(context, pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_);
            CqlInterval<CqlDateTime> pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = QICoreCommon_2_1_000.Instance.toInterval(context, pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_);
            CqlDateTime pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Start(pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_);
            CqlInterval<CqlDateTime> pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = this.Measurement_Period(context);
            CqlDateTime pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Start(pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_);
            bool? pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Before(pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_, pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_, default);

            return pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_;
        };
        IEnumerable<Observation> ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Where<Observation>(ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_, ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_);
        IEnumerable<object> ozzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.Union<object>(nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ as IEnumerable<object>, ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ as IEnumerable<object>);
        IEnumerable<object> ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Union<object>(nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ as IEnumerable<object>, ozzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ as IEnumerable<object>);
        bool? ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Exists<object>(ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_);

        return ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_;
    }


    [CqlExpressionDefinition("Glucocorticoid Active Medication Days")]
    public int? Glucocorticoid_Active_Medication_Days(CqlContext context)
    {
        CqlValueSet pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = this.Glucocorticoids__oral_only_(context);
        IEnumerable<MedicationRequest> pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Union<MedicationRequest>(pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_, qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_);
        IEnumerable<MedicationRequest> qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = Status_1_8_000.Instance.isMedicationActive(context, qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_);
        bool? qzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_(MedicationRequest OralGlucocorticoid)
        {
            CqlInterval<CqlDate> qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = CumulativeMedicationDuration_4_1_000.Instance.medicationRequestPeriod(context, OralGlucocorticoid);
            CqlDate qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Start(qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_);
            CqlDateTime qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.ConvertDateToDateTime(qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_);
            CqlInterval<CqlDateTime> qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = this.Measurement_Period(context);
            CqlDateTime qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.End(qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_);
            bool? qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Before(qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_, qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_, default);

            return qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_;
        };
        IEnumerable<MedicationRequest> qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Where<MedicationRequest>(qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_, qzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_);
        CqlInterval<CqlDate> qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_(MedicationRequest Glucocorticoid)
        {
            CqlInterval<CqlDate> qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = CumulativeMedicationDuration_4_1_000.Instance.medicationRequestPeriod(context, Glucocorticoid);
            Patient qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = this.Patient(context);
            Date qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_?.BirthDateElement;
            string qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_?.Value;
            CqlDate qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.ConvertStringToDate(qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_);
            CqlInterval<CqlDateTime> qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = this.Measurement_Period(context);
            CqlDateTime qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.End(qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_);
            CqlDate qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.DateFrom(qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_);
            CqlInterval<CqlDate> qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Interval(qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_, qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_, true, true);
            CqlInterval<CqlDate> qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Intersect<CqlDate>(qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_, qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_);

            return qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_;
        };
        IEnumerable<CqlInterval<CqlDate>> qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Select<MedicationRequest, CqlInterval<CqlDate>>(qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_, qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_);
        IEnumerable<CqlInterval<CqlDate>> qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Distinct<CqlInterval<CqlDate>>(qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_);
        int? qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = CumulativeMedicationDuration_4_1_000.Instance.cumulativeDuration(context, qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_);

        return qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_;
    }


    [CqlExpressionDefinition("Has 90 or More Active Glucocorticoid Medication Days")]
    public bool? Has_90_or_More_Active_Glucocorticoid_Medication_Days(CqlContext context)
    {
        int? rzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = this.Glucocorticoid_Active_Medication_Days(context);
        bool? rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.GreaterOrEqual(rzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_, 90);

        return rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_;
    }


    [CqlExpressionDefinition("diagnosisInPatientHistory")]
    public IEnumerable<Condition> diagnosisInPatientHistory(CqlContext context, IEnumerable<Condition> Condition)
    {
        bool? rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_(Condition Dx)
        {
            CqlInterval<CqlDateTime> rzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = QICoreCommon_2_1_000.Instance.prevalenceInterval(context, Dx);
            CqlDateTime rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Start(rzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_);
            CqlInterval<CqlDateTime> rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = this.Measurement_Period(context);
            CqlDateTime rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.End(rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_);
            bool? rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.SameOrBefore(rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_, rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_, "day");

            return rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_;
        };
        IEnumerable<Condition> rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Where<Condition>(Condition, rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_);

        return rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_;
    }


    [CqlExpressionDefinition("procedureInPatientHistory")]
    public IEnumerable<Procedure> procedureInPatientHistory(CqlContext context, IEnumerable<Procedure> Procedure)
    {
        IEnumerable<Procedure> rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = Status_1_8_000.Instance.isProcedurePerformed(context, Procedure);
        bool? rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_(Procedure Proc)
        {
            DataType rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = Proc?.Performed;
            object rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = FHIRHelpers_4_4_000.Instance.ToValue(context, rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_);
            CqlInterval<CqlDateTime> rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = QICoreCommon_2_1_000.Instance.toInterval(context, rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_);
            CqlDateTime rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.End(rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_);
            CqlInterval<CqlDateTime> rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = this.Measurement_Period(context);
            CqlDateTime rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.End(rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_);
            bool? rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.SameOrBefore(rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_, rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_, "day");

            return rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_;
        };
        IEnumerable<Procedure> rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Where<Procedure>(rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_, rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_);

        return rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_;
    }


    [CqlExpressionDefinition("Has Double or Bilateral Oophorectomy")]
    public bool? Has_Double_or_Bilateral_Oophorectomy(CqlContext context)
    {
        CqlValueSet rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = this.Bilateral_Oophorectomy(context);
        IEnumerable<Procedure> rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
        IEnumerable<Procedure> rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = this.procedureInPatientHistory(context, rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_);
        bool? rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Exists<Procedure>(rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_);
        CqlValueSet rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = this.Evidence_of_Bilateral_Oophorectomy(context);
        IEnumerable<Procedure> rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
        IEnumerable<Procedure> rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = this.procedureInPatientHistory(context, rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_);
        bool? szzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.Exists<Procedure>(rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_);
        bool? szzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Or(rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_, szzzzzzzzzzzzzzzzzzzzzzzzzzzzza_);
        CqlValueSet szzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = this.Unilateral_Oophorectomy__Unspecified_Laterality(context);
        IEnumerable<Procedure> szzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, szzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
        bool? szzzzzzzzzzzzzzzzzzzzzzzzzzzzze_(Procedure UnilateralOophorectomy)
        {
            List<CodeableConcept> szzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = UnilateralOophorectomy?.BodySite;
            CqlConcept szzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_(CodeableConcept @this)
            {
                CqlConcept tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);

                return tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_;
            };
            IEnumerable<CqlConcept> szzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)szzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_, szzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_);
            bool? szzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_(CqlConcept C)
            {
                CqlCode tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = this.Right__qualifier_value_(context);
                CqlConcept tzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.ConvertCodeToConcept(tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_);
                bool? tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Equivalent(C, tzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_);

                return tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_;
            };
            IEnumerable<CqlConcept> tzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.Where<CqlConcept>(szzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_, szzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_);
            bool? tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Exists<CqlConcept>(tzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_);

            return tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_;
        };
        IEnumerable<Procedure> szzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Where<Procedure>(szzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_, szzzzzzzzzzzzzzzzzzzzzzzzzzzzze_);
        CqlValueSet szzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = this.Unilateral_Oophorectomy_Right(context);
        IEnumerable<Procedure> szzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, szzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
        IEnumerable<Procedure> szzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Union<Procedure>(szzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_, szzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_);
        IEnumerable<Procedure> szzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = this.procedureInPatientHistory(context, szzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_);
        bool? szzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Exists<Procedure>(szzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_);
        IEnumerable<Procedure> szzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, szzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
        bool? szzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_(Procedure UnilateralOophorectomy)
        {
            List<CodeableConcept> tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = UnilateralOophorectomy?.BodySite;
            CqlConcept tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_(CodeableConcept @this)
            {
                CqlConcept tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);

                return tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_;
            };
            IEnumerable<CqlConcept> tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_, tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_);
            bool? tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_(CqlConcept D)
            {
                CqlCode tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = this.Left__qualifier_value_(context);
                CqlConcept tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.ConvertCodeToConcept(tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_);
                bool? tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Equivalent(D, tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_);

                return tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_;
            };
            IEnumerable<CqlConcept> tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Where<CqlConcept>(tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_, tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_);
            bool? tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Exists<CqlConcept>(tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_);

            return tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_;
        };
        IEnumerable<Procedure> szzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Where<Procedure>(szzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_, szzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_);
        CqlValueSet szzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = this.Unilateral_Oophorectomy_Left(context);
        IEnumerable<Procedure> szzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, szzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
        IEnumerable<Procedure> szzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Union<Procedure>(szzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_, szzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_);
        IEnumerable<Procedure> szzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = this.procedureInPatientHistory(context, szzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_);
        bool? szzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Exists<Procedure>(szzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_);
        bool? szzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.And(szzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_, szzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_);
        bool? szzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Or(szzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_, szzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_);

        return szzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_;
    }


    [CqlExpressionDefinition("Has Organ Transplants")]
    public bool? Has_Organ_Transplants(CqlContext context)
    {
        CqlValueSet tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = this.Major_Transplant(context);
        IEnumerable<Procedure> tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
        CqlValueSet tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = this.Kidney_Transplant(context);
        IEnumerable<Procedure> tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
        IEnumerable<Procedure> tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Union<Procedure>(tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_, tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_);
        CqlValueSet tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = this.Bone_Marrow_Transplant(context);
        IEnumerable<Procedure> tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
        IEnumerable<Procedure> tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Union<Procedure>(tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_, tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_);
        IEnumerable<Procedure> tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = this.procedureInPatientHistory(context, tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_);
        bool? tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Exists<Procedure>(tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_);

        return tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_;
    }


    [CqlExpressionDefinition("Has Risk Factor Any Time in History or During Measurement Period")]
    public bool? Has_Risk_Factor_Any_Time_in_History_or_During_Measurement_Period(CqlContext context)
    {
        bool? uzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = this.Has_90_or_More_Active_Glucocorticoid_Medication_Days(context);
        CqlValueSet uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = this.Osteoporosis_With_Current_Fracture(context);
        IEnumerable<Condition> uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        CqlValueSet uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = this.Malabsorption_Syndromes(context);
        IEnumerable<Condition> uzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        IEnumerable<Condition> uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Union<Condition>(uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_, uzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_);
        CqlValueSet uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = this.Chronic_Malnutrition(context);
        IEnumerable<Condition> uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        CqlValueSet uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = this.Chronic_Liver_Disease(context);
        IEnumerable<Condition> uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        IEnumerable<Condition> uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Union<Condition>(uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_, uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_);
        IEnumerable<Condition> uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Union<Condition>(uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_, uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_);
        CqlValueSet uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = this.Rheumatoid_Arthritis(context);
        IEnumerable<Condition> uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        CqlValueSet uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = this.Hyperthyroidism(context);
        IEnumerable<Condition> uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        IEnumerable<Condition> uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Union<Condition>(uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_, uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_);
        IEnumerable<Condition> uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Union<Condition>(uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_, uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_);
        CqlValueSet uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = this.Type_1_Diabetes(context);
        IEnumerable<Condition> uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        CqlValueSet uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = this.End_Stage_Renal_Disease(context);
        IEnumerable<Condition> uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        IEnumerable<Condition> uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Union<Condition>(uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_, uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_);
        IEnumerable<Condition> uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Union<Condition>(uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_, uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_);
        CqlValueSet uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = this.Osteogenesis_Imperfecta(context);
        IEnumerable<Condition> uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        CqlValueSet vzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = this.Ankylosing_Spondylitis(context);
        IEnumerable<Condition> vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, vzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        IEnumerable<Condition> vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Union<Condition>(uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_, vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_);
        IEnumerable<Condition> vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Union<Condition>(uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_, vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_);
        CqlValueSet vzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = this.Psoriatic_Arthritis(context);
        IEnumerable<Condition> vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, vzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        CqlValueSet vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = this.Ehlers_Danlos_Syndrome(context);
        IEnumerable<Condition> vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        IEnumerable<Condition> vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Union<Condition>(vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_, vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_);
        IEnumerable<Condition> vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Union<Condition>(vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_, vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_);
        CqlValueSet vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = this.Cushings_Syndrome(context);
        IEnumerable<Condition> vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        CqlValueSet vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = this.Hyperparathyroidism(context);
        IEnumerable<Condition> vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        IEnumerable<Condition> vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Union<Condition>(vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_, vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_);
        IEnumerable<Condition> vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Union<Condition>(vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_, vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_);
        CqlValueSet vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = this.Marfans_Syndrome(context);
        IEnumerable<Condition> vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        CqlValueSet vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = this.Lupus(context);
        IEnumerable<Condition> vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        IEnumerable<Condition> vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Union<Condition>(vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_, vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_);
        IEnumerable<Condition> vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Union<Condition>(vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_, vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_);
        CqlValueSet vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = this.Multiple_Myeloma(context);
        IEnumerable<Condition> vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        CqlValueSet vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = this.Premature_Menopause(context);
        IEnumerable<Condition> vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        IEnumerable<Condition> wzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.Union<Condition>(vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_, vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_);
        IEnumerable<Condition> wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Union<Condition>(vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_, wzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_);
        CqlValueSet wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = this.Eating_Disorders(context);
        IEnumerable<Condition> wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        CqlValueSet wzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = this.Amenorrhea(context);
        IEnumerable<Condition> wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, wzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        IEnumerable<Condition> wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Union<Condition>(wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_, wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_);
        IEnumerable<Condition> wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Union<Condition>(wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_, wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_);
        IEnumerable<Condition> wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = this.diagnosisInPatientHistory(context, wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_);
        bool? wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Exists<Condition>(wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_);
        bool? wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Or(uzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_, wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_);
        CqlValueSet wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = this.Chemotherapy(context);
        IEnumerable<Procedure> wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
        IEnumerable<Procedure> wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = this.procedureInPatientHistory(context, wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_);
        bool? wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Exists<Procedure>(wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_);
        bool? wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Or(wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_, wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_);
        bool? wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = this.Has_Double_or_Bilateral_Oophorectomy(context);
        bool? wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Or(wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_, wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_);
        bool? wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = this.Has_Organ_Transplants(context);
        bool? wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Or(wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_, wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_);

        return wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_;
    }


    [CqlExpressionDefinition("Denominator Exclusions")]
    public bool? Denominator_Exclusions(CqlContext context)
    {
        bool? wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = this.Has_Risk_Factor_Active_During_the_Measurement_Period(context);
        bool? wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = this.Has_Risk_Factor_Any_Time_in_History_Prior_to_Measurement_Period(context);
        bool? wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Or(wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_, wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_);
        bool? wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = this.Has_Risk_Factor_Any_Time_in_History_or_During_Measurement_Period(context);
        bool? wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Or(wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_, wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_);

        return wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_;
    }


    [CqlExpressionDefinition("DXA Scan Order During Measurement Period")]
    public IEnumerable<ServiceRequest> DXA_Scan_Order_During_Measurement_Period(CqlContext context)
    {
        CqlValueSet wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = this.DXA__Dual_energy_Xray_Absorptiometry__Scan(context);
        IEnumerable<ServiceRequest> xzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.Retrieve<ServiceRequest>(new RetrieveParameters(default, wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-servicerequest"));
        IEnumerable<ServiceRequest> xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = Status_1_8_000.Instance.isDiagnosticStudyOrder(context, xzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_);
        bool? xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_(ServiceRequest DXA)
        {
            CqlInterval<CqlDateTime> xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = this.Measurement_Period(context);
            FhirDateTime xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = DXA?.AuthoredOnElement;
            CqlDateTime xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Convert<CqlDateTime>(xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_);
            CqlInterval<CqlDateTime> xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = QICoreCommon_2_1_000.Instance.toInterval(context, xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ as object);
            bool? xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_, xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_, default);

            return xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_;
        };
        IEnumerable<ServiceRequest> xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Where<ServiceRequest>(xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_, xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_);
        object xzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_(ServiceRequest @this)
        {
            FhirDateTime xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = @this?.AuthoredOnElement;
            CqlDateTime xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Convert<CqlDateTime>(xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_);

            return xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_;
        };
        IEnumerable<ServiceRequest> xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.SortBy<ServiceRequest>(xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_, xzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_, System.ComponentModel.ListSortDirection.Ascending);

        return xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_;
    }


    [CqlExpressionDefinition("Numerator")]
    public bool? Numerator(CqlContext context)
    {
        IEnumerable<ServiceRequest> xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = this.DXA_Scan_Order_During_Measurement_Period(context);
        bool? xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Exists<ServiceRequest>(xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_);

        return xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_;
    }


    [CqlExpressionDefinition("Osteoporosis Fracture Risk Assessment Prior to First DXA Scan")]
    public IEnumerable<Observation> Osteoporosis_Fracture_Risk_Assessment_Prior_to_First_DXA_Scan(CqlContext context)
    {
        CqlCode xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = this.Major_osteoporotic_fracture_10_year_probability__Likelihood__Fracture_Risk_Assessment(context);
        IEnumerable<CqlCode> xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.ToList<CqlCode>(xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_);
        IEnumerable<Observation> xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
        IEnumerable<Observation> xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = Status_1_8_000.Instance.isAssessmentPerformed(context, xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_);
        bool? xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_(Observation FRAX)
        {
            DataType yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = FRAX?.Value;
            object yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = FHIRHelpers_4_4_000.Instance.ToValue(context, yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_);
            CqlQuantity yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Quantity(8.4m, "%");
            bool? yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.GreaterOrEqual(yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ as CqlQuantity, yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_);

            return yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_;
        };
        IEnumerable<Observation> xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Where<Observation>(xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_, xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_);
        CqlCode xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = this.Osteoporosis_Risk_Assessment_Instrument(context);
        IEnumerable<CqlCode> xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.ToList<CqlCode>(xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_);
        IEnumerable<Observation> xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
        IEnumerable<Observation> xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = Status_1_8_000.Instance.isAssessmentPerformed(context, xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_);
        bool? xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_(Observation ORAI)
        {
            DataType yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = ORAI?.Value;
            object yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = FHIRHelpers_4_4_000.Instance.ToValue(context, yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_);
            bool? yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.GreaterOrEqual(yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ as int?, 9);

            return yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_;
        };
        IEnumerable<Observation> yzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.Where<Observation>(xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_, xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_);
        IEnumerable<Observation> yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Union<Observation>(xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_, yzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_);
        CqlCode yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = this.Osteoporosis_Index_of_Risk_panel(context);
        IEnumerable<CqlCode> yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.ToList<CqlCode>(yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_);
        IEnumerable<Observation> yzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
        IEnumerable<Observation> yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = Status_1_8_000.Instance.isAssessmentPerformed(context, yzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_);
        bool? yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_(Observation OSIRIS)
        {
            DataType yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = OSIRIS?.Value;
            object zzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = FHIRHelpers_4_4_000.Instance.ToValue(context, yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_);
            CqlQuantity zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.ConvertDecimalToQuantity(1.0m);
            bool? zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Less(zzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ as CqlQuantity, zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_);

            return zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_;
        };
        IEnumerable<Observation> yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Where<Observation>(yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_, yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_);
        CqlCode yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = this.Osteoporosis_Self_Assessment_Tool(context);
        IEnumerable<CqlCode> yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.ToList<CqlCode>(yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_);
        IEnumerable<Observation> yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
        IEnumerable<Observation> yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = Status_1_8_000.Instance.isAssessmentPerformed(context, yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_);
        bool? yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_(Observation OST)
        {
            DataType zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = OST?.Value;
            object zzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = FHIRHelpers_4_4_000.Instance.ToValue(context, zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_);
            CqlQuantity zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.ConvertDecimalToQuantity(2.0m);
            bool? zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Less(zzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ as CqlQuantity, zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_);

            return zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_;
        };
        IEnumerable<Observation> yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Where<Observation>(yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_, yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_);
        IEnumerable<Observation> yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Union<Observation>(yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_, yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_);
        IEnumerable<Observation> yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Union<Observation>(yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_, yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_);
        bool? yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_(Observation RiskAssessment)
        {
            DataType zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = RiskAssessment?.Effective;
            object zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = FHIRHelpers_4_4_000.Instance.ToValue(context, zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_);
            CqlInterval<CqlDateTime> zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = QICoreCommon_2_1_000.Instance.toInterval(context, zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_);
            CqlDateTime zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Start(zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_);
            IEnumerable<ServiceRequest> zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = this.DXA_Scan_Order_During_Measurement_Period(context);
            ServiceRequest zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.First<ServiceRequest>(zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_);
            FhirDateTime zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_?.AuthoredOnElement;
            CqlDateTime zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Convert<CqlDateTime>(zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_);
            bool? zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Before(zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_, zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_, default);

            return zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_;
        };
        IEnumerable<Observation> yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Where<Observation>(yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_, yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_);

        return yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_;
    }


    [CqlExpressionDefinition("Numerator Exclusion")]
    public bool? Numerator_Exclusion(CqlContext context)
    {
        IEnumerable<Observation> zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = this.Osteoporosis_Fracture_Risk_Assessment_Prior_to_First_DXA_Scan(context);
        bool? zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Exists<Observation>(zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_);

        return zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_;
    }


    #endregion Expressions

}

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

[System.CodeDom.Compiler.GeneratedCode(".NET Code Generation", "3.1.0.0")]
[CqlLibrary("AppropriateDXAScansForWomenUnder65FHIR", "0.2.001")]
public partial class AppropriateDXAScansForWomenUnder65FHIR_minus_0_2_001 : ILibrary, ISingleton<AppropriateDXAScansForWomenUnder65FHIR_minus_0_2_001>
{
    private AppropriateDXAScansForWomenUnder65FHIR_minus_0_2_001() {}

    public static AppropriateDXAScansForWomenUnder65FHIR_minus_0_2_001 Instance { get; } = new();

    #region ILibrary Implementation

    public string Name => "AppropriateDXAScansForWomenUnder65FHIR";
    public string Version => "0.2.001";
    public ILibrary[] Dependencies => [FHIRHelpers_minus_4_4_000.Instance, SupplementalDataElements_minus_3_5_000.Instance, QICoreCommon_minus_2_1_000.Instance, Status_minus_1_8_000.Instance, CumulativeMedicationDuration_minus_4_1_000.Instance, Hospice_minus_6_12_000.Instance];

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
    public CqlCode Major_osteoporotic_fracture_10_minus_year_probability__Likelihood__Fracture_Risk_Assessment(CqlContext _) => _Major_osteoporotic_fracture_10_minus_year_probability__Likelihood__Fracture_Risk_Assessment;
    private static readonly CqlCode _Major_osteoporotic_fracture_10_minus_year_probability__Likelihood__Fracture_Risk_Assessment = new CqlCode("90265-0", "http://loinc.org");

    [CqlCodeDefinition("Osteoporosis Index of Risk panel", codeId: "98133-2", codeSystem: "http://loinc.org")]
    public CqlCode Osteoporosis_Index_of_Risk_panel(CqlContext _) => _Osteoporosis_Index_of_Risk_panel;
    private static readonly CqlCode _Osteoporosis_Index_of_Risk_panel = new CqlCode("98133-2", "http://loinc.org");

    [CqlCodeDefinition("Osteoporosis Risk Assessment Instrument", codeId: "98139-9", codeSystem: "http://loinc.org")]
    public CqlCode Osteoporosis_Risk_Assessment_Instrument(CqlContext _) => _Osteoporosis_Risk_Assessment_Instrument;
    private static readonly CqlCode _Osteoporosis_Risk_Assessment_Instrument = new CqlCode("98139-9", "http://loinc.org");

    [CqlCodeDefinition("Osteoporosis Self-Assessment Tool", codeId: "98146-4", codeSystem: "http://loinc.org")]
    public CqlCode Osteoporosis_Self_minus_Assessment_Tool(CqlContext _) => _Osteoporosis_Self_minus_Assessment_Tool;
    private static readonly CqlCode _Osteoporosis_Self_minus_Assessment_Tool = new CqlCode("98146-4", "http://loinc.org");

    [CqlCodeDefinition("Right (qualifier value)", codeId: "24028007", codeSystem: "http://snomed.info/sct")]
    public CqlCode Right__qualifier_value_(CqlContext _) => _Right__qualifier_value_;
    private static readonly CqlCode _Right__qualifier_value_ = new CqlCode("24028007", "http://snomed.info/sct");

    [CqlCodeDefinition("Unlisted preventive medicine service", codeId: "99429", codeSystem: "http://www.ama-assn.org/go/cpt")]
    public CqlCode Unlisted_preventive_medicine_service(CqlContext _) => _Unlisted_preventive_medicine_service;
    private static readonly CqlCode _Unlisted_preventive_medicine_service = new CqlCode("99429", "http://www.ama-assn.org/go/cpt");

    #endregion Codes

    #region CodeSystems

    [CqlCodeSystemDefinition("LOINC", codeSystemId: "http://loinc.org", codeSystemVersion: null)]
    public CqlCodeSystem LOINC(CqlContext _) => _LOINC;
    private static readonly CqlCodeSystem _LOINC =
      new CqlCodeSystem("http://loinc.org", null, [
          _Alcoholic_drinks_per_day,
          _Body_mass_index__BMI___Ratio_,
          _Major_osteoporotic_fracture_10_minus_year_probability__Likelihood__Fracture_Risk_Assessment,
          _Osteoporosis_Index_of_Risk_panel,
          _Osteoporosis_Risk_Assessment_Instrument,
          _Osteoporosis_Self_minus_Assessment_Tool]);

    [CqlCodeSystemDefinition("AdministrativeGender", codeSystemId: "http://terminology.hl7.org/CodeSystem/v3-AdministrativeGender", codeSystemVersion: null)]
    public CqlCodeSystem AdministrativeGender(CqlContext _) => _AdministrativeGender;
    private static readonly CqlCodeSystem _AdministrativeGender =
      new CqlCodeSystem("http://terminology.hl7.org/CodeSystem/v3-AdministrativeGender", null, [
          _Female]);

    [CqlCodeSystemDefinition("SNOMEDCT", codeSystemId: "http://snomed.info/sct", codeSystemVersion: null)]
    public CqlCodeSystem SNOMEDCT(CqlContext _) => _SNOMEDCT;
    private static readonly CqlCodeSystem _SNOMEDCT =
      new CqlCodeSystem("http://snomed.info/sct", null, [
          _Left__qualifier_value_,
          _Right__qualifier_value_]);

    [CqlCodeSystemDefinition("CPT", codeSystemId: "http://www.ama-assn.org/go/cpt", codeSystemVersion: null)]
    public CqlCodeSystem CPT(CqlContext _) => _CPT;
    private static readonly CqlCodeSystem _CPT =
      new CqlCodeSystem("http://www.ama-assn.org/go/cpt", null, [
          _Unlisted_preventive_medicine_service]);

    #endregion CodeSystems

    #region Parameters

    [CqlParameterDefinition("Measurement Period")]
    public CqlInterval<CqlDateTime> Measurement_Period(CqlContext context)
    {
        CqlDateTime a_ = context.Operators.DateTime(2025, 1, 1, 0, 0, 0, 0, 0.0m);
        CqlDateTime b_ = context.Operators.DateTime(2025, 12, 31, 23, 59, 59, 999, 0.0m);
        CqlInterval<CqlDateTime> c_ = context.Operators.Interval(a_, b_, true, true);
        object d_ = context.ResolveParameter("AppropriateDXAScansForWomenUnder65FHIR-0.2.001", "Measurement Period", c_);

        return (CqlInterval<CqlDateTime>)d_;
    }


    #endregion Parameters

    #region Functions and Expressions

    [CqlExpressionDefinition("Patient")]
    public Patient Patient(CqlContext context)
    {
        IEnumerable<Patient> a_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-patient"));
        Patient b_ = context.Operators.SingletonFrom<Patient>(a_);

        return b_;
    }


    [CqlExpressionDefinition("SDE Ethnicity")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Ethnicity(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? a_ = SupplementalDataElements_minus_3_5_000.Instance.SDE_Ethnicity(context);

        return a_;
    }


    [CqlExpressionDefinition("SDE Payer")]
    public IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> SDE_Payer(CqlContext context)
    {
        IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> a_ = SupplementalDataElements_minus_3_5_000.Instance.SDE_Payer(context);

        return a_;
    }


    [CqlExpressionDefinition("SDE Race")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Race(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? a_ = SupplementalDataElements_minus_3_5_000.Instance.SDE_Race(context);

        return a_;
    }


    [CqlExpressionDefinition("SDE Sex")]
    public CqlCode SDE_Sex(CqlContext context)
    {
        CqlCode a_ = SupplementalDataElements_minus_3_5_000.Instance.SDE_Sex(context);

        return a_;
    }


    [CqlExpressionDefinition("Qualifying Encounter")]
    public IEnumerable<Encounter> Qualifying_Encounter(CqlContext context)
    {
        CqlValueSet a_ = this.Office_Visit(context);
        IEnumerable<Encounter> b_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        CqlValueSet c_ = this.Preventive_Care_Services_Established_Office_Visit__18_and_Up(context);
        IEnumerable<Encounter> d_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, c_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> e_ = context.Operators.Union<Encounter>(b_, d_);
        IEnumerable<Encounter> f_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        bool? g_(Encounter E)
        {
            List<CodeableConcept> y_ = E?.Type;
            CqlConcept z_(CodeableConcept @this)
            {
                CqlConcept ae_ = FHIRHelpers_minus_4_4_000.Instance.ToConcept(context, @this);

                return ae_;
            };
            IEnumerable<CqlConcept> aa_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)y_, z_);
            bool? ab_(CqlConcept T)
            {
                CqlCode af_ = this.Unlisted_preventive_medicine_service(context);
                CqlConcept ag_ = context.Operators.ConvertCodeToConcept(af_);
                bool? ah_ = context.Operators.Equivalent(T, ag_);

                return ah_;
            };
            IEnumerable<CqlConcept> ac_ = context.Operators.Where<CqlConcept>(aa_, ab_);
            bool? ad_ = context.Operators.Exists<CqlConcept>(ac_);

            return ad_;
        };
        IEnumerable<Encounter> h_ = context.Operators.Where<Encounter>(f_, g_);
        CqlValueSet i_ = this.Preventive_Care_Services_Initial_Office_Visit__18_and_Up(context);
        IEnumerable<Encounter> j_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, i_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> k_ = context.Operators.Union<Encounter>(h_, j_);
        IEnumerable<Encounter> l_ = context.Operators.Union<Encounter>(e_, k_);
        CqlValueSet m_ = this.Outpatient_Consultation(context);
        IEnumerable<Encounter> n_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, m_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        CqlValueSet o_ = this.Virtual_Encounter(context);
        IEnumerable<Encounter> p_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, o_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> q_ = context.Operators.Union<Encounter>(n_, p_);
        IEnumerable<Encounter> r_ = context.Operators.Union<Encounter>(l_, q_);
        CqlValueSet s_ = this.Telephone_Visits(context);
        IEnumerable<Encounter> t_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, s_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> u_ = context.Operators.Union<Encounter>(r_, t_);
        IEnumerable<Encounter> v_ = Status_minus_1_8_000.Instance.isEncounterPerformed(context, u_);
        bool? w_(Encounter ValidEncounters)
        {
            CqlInterval<CqlDateTime> ai_ = this.Measurement_Period(context);
            Period aj_ = ValidEncounters?.Period;
            CqlInterval<CqlDateTime> ak_ = FHIRHelpers_minus_4_4_000.Instance.ToInterval(context, aj_);
            CqlInterval<CqlDateTime> al_ = QICoreCommon_minus_2_1_000.Instance.toInterval(context, ak_ as object);
            bool? am_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(ai_, al_, "day");

            return am_;
        };
        IEnumerable<Encounter> x_ = context.Operators.Where<Encounter>(v_, w_);

        return x_;
    }


    [CqlExpressionDefinition("Initial Population")]
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


    [CqlExpressionDefinition("Denominator")]
    public bool? Denominator(CqlContext context)
    {
        bool? a_ = this.Initial_Population(context);

        return a_;
    }


    [CqlExpressionDefinition("First BMI in Measurement Period")]
    public Observation First_BMI_in_Measurement_Period(CqlContext context)
    {
        IEnumerable<Observation> a_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/StructureDefinition/bmi"));
        IEnumerable<Observation> b_ = Status_minus_1_8_000.Instance.isObservationBMI(context, a_);
        bool? c_(Observation BMIRatio)
        {
            CqlInterval<CqlDateTime> h_ = this.Measurement_Period(context);
            DataType i_ = BMIRatio?.Effective;
            object j_ = FHIRHelpers_minus_4_4_000.Instance.ToValue(context, i_);
            CqlInterval<CqlDateTime> k_ = QICoreCommon_minus_2_1_000.Instance.toInterval(context, j_);
            bool? l_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(h_, k_, default);
            DataType m_ = BMIRatio?.Value;
            CqlQuantity n_ = FHIRHelpers_minus_4_4_000.Instance.ToQuantity(context, m_ as Quantity);
            bool? o_ = context.Operators.Not((bool?)((n_ as CqlQuantity) is null));
            bool? p_ = context.Operators.And(l_, o_);

            return p_;
        };
        IEnumerable<Observation> d_ = context.Operators.Where<Observation>(b_, c_);
        object e_(Observation @this)
        {
            DataType q_ = @this?.Effective;
            object r_ = FHIRHelpers_minus_4_4_000.Instance.ToValue(context, q_);
            CqlInterval<CqlDateTime> s_ = QICoreCommon_minus_2_1_000.Instance.toInterval(context, r_);
            CqlDateTime t_ = context.Operators.Start(s_);

            return t_;
        };
        IEnumerable<Observation> f_ = context.Operators.SortBy<Observation>(d_, e_, System.ComponentModel.ListSortDirection.Ascending);
        Observation g_ = context.Operators.First<Observation>(f_);

        return g_;
    }


    [CqlExpressionDefinition("First BMI in Measurement Period Less Than or Equal to 20 kg m2")]
    public Observation First_BMI_in_Measurement_Period_Less_Than_or_Equal_to_20_kg_m2(CqlContext context)
    {
        Observation a_ = this.First_BMI_in_Measurement_Period(context);
        Observation[] b_ = [
            a_,
        ];
        bool? c_(Observation FirstBMI)
        {
            DataType f_ = FirstBMI?.Value;
            CqlQuantity g_ = FHIRHelpers_minus_4_4_000.Instance.ToQuantity(context, f_ as Quantity);
            CqlQuantity h_ = context.Operators.Quantity(20m, "kg/m2");
            bool? i_ = context.Operators.LessOrEqual(g_ as CqlQuantity, h_);

            return i_;
        };
        IEnumerable<Observation> d_ = context.Operators.Where<Observation>((IEnumerable<Observation>)b_, c_);
        Observation e_ = context.Operators.SingletonFrom<Observation>(d_);

        return e_;
    }


    [CqlExpressionDefinition("First Average Number of Drinks Assessments Indicating More Than Two Per Day")]
    public Observation First_Average_Number_of_Drinks_Assessments_Indicating_More_Than_Two_Per_Day(CqlContext context)
    {
        CqlCode a_ = this.Alcoholic_drinks_per_day(context);
        IEnumerable<CqlCode> b_ = context.Operators.ToList<CqlCode>(a_);
        IEnumerable<Observation> c_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, b_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
        IEnumerable<Observation> d_ = Status_minus_1_8_000.Instance.isAssessmentPerformed(context, c_);
        bool? e_(Observation AverageDrinks)
        {
            DataType j_ = AverageDrinks?.Effective;
            object k_ = FHIRHelpers_minus_4_4_000.Instance.ToValue(context, j_);
            CqlInterval<CqlDateTime> l_ = QICoreCommon_minus_2_1_000.Instance.toInterval(context, k_);
            CqlDateTime m_ = context.Operators.Start(l_);
            CqlInterval<CqlDateTime> n_ = this.Measurement_Period(context);
            bool? o_ = context.Operators.In<CqlDateTime>(m_, n_, default);
            DataType p_ = AverageDrinks?.Value;
            object q_ = FHIRHelpers_minus_4_4_000.Instance.ToValue(context, p_);
            CqlQuantity r_ = context.Operators.Quantity(2m, "{drinks}/d");
            bool? s_ = context.Operators.Greater(q_ as CqlQuantity, r_);
            bool? t_ = context.Operators.And(o_, s_);

            return t_;
        };
        IEnumerable<Observation> f_ = context.Operators.Where<Observation>(d_, e_);
        object g_(Observation @this)
        {
            DataType u_ = @this?.Effective;
            object v_ = FHIRHelpers_minus_4_4_000.Instance.ToValue(context, u_);
            CqlInterval<CqlDateTime> w_ = QICoreCommon_minus_2_1_000.Instance.toInterval(context, v_);
            CqlDateTime x_ = context.Operators.Start(w_);

            return x_;
        };
        IEnumerable<Observation> h_ = context.Operators.SortBy<Observation>(f_, g_, System.ComponentModel.ListSortDirection.Ascending);
        Observation i_ = context.Operators.First<Observation>(h_);

        return i_;
    }


    [CqlExpressionDefinition("Has Risk Factor Active During the Measurement Period")]
    public bool? Has_Risk_Factor_Active_During_the_Measurement_Period(CqlContext context)
    {
        Observation a_ = this.First_BMI_in_Measurement_Period_Less_Than_or_Equal_to_20_kg_m2(context);
        bool? b_ = context.Operators.Not((bool?)(a_ is null));
        Observation c_ = this.First_Average_Number_of_Drinks_Assessments_Indicating_More_Than_Two_Per_Day(context);
        bool? d_ = context.Operators.Not((bool?)(c_ is null));
        bool? e_ = context.Operators.Or(b_, d_);

        return e_;
    }


    [CqlExpressionDefinition("Has Risk Factor Any Time in History Prior to Measurement Period")]
    public bool? Has_Risk_Factor_Any_Time_in_History_Prior_to_Measurement_Period(CqlContext context)
    {
        CqlValueSet a_ = this.Osteoporosis_Without_Current_Fracture(context);
        IEnumerable<Condition> b_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        bool? c_(Condition OsteoporosisDiagnosis)
        {
            CqlInterval<CqlDateTime> aq_ = QICoreCommon_minus_2_1_000.Instance.prevalenceInterval(context, OsteoporosisDiagnosis);
            CqlDateTime ar_ = context.Operators.Start(aq_);
            CqlInterval<CqlDateTime> as_ = this.Measurement_Period(context);
            CqlDateTime at_ = context.Operators.Start(as_);
            bool? au_ = context.Operators.Before(ar_, at_, default);

            return au_;
        };
        IEnumerable<Condition> d_ = context.Operators.Where<Condition>(b_, c_);
        CqlValueSet e_ = this.Osteopenia(context);
        IEnumerable<Condition> f_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, e_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        bool? g_(Condition OsteopeniaDiagnosis)
        {
            CqlInterval<CqlDateTime> av_ = QICoreCommon_minus_2_1_000.Instance.prevalenceInterval(context, OsteopeniaDiagnosis);
            CqlDateTime aw_ = context.Operators.Start(av_);
            CqlInterval<CqlDateTime> ax_ = this.Measurement_Period(context);
            CqlDateTime ay_ = context.Operators.Start(ax_);
            bool? az_ = context.Operators.Before(aw_, ay_, default);

            return az_;
        };
        IEnumerable<Condition> h_ = context.Operators.Where<Condition>(f_, g_);
        IEnumerable<Condition> i_ = context.Operators.Union<Condition>(d_, h_);
        CqlValueSet j_ = this.Gastric_Bypass_Surgery(context);
        IEnumerable<Procedure> k_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, j_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
        IEnumerable<Procedure> l_ = Status_minus_1_8_000.Instance.isProcedurePerformed(context, k_);
        bool? m_(Procedure GastricBypass)
        {
            DataType ba_ = GastricBypass?.Performed;
            object bb_ = FHIRHelpers_minus_4_4_000.Instance.ToValue(context, ba_);
            CqlInterval<CqlDateTime> bc_ = QICoreCommon_minus_2_1_000.Instance.toInterval(context, bb_);
            CqlDateTime bd_ = context.Operators.End(bc_);
            CqlInterval<CqlDateTime> be_ = this.Measurement_Period(context);
            CqlDateTime bf_ = context.Operators.Start(be_);
            bool? bg_ = context.Operators.Before(bd_, bf_, default);

            return bg_;
        };
        IEnumerable<Procedure> n_ = context.Operators.Where<Procedure>(l_, m_);
        CqlValueSet o_ = this.Aromatase_Inhibitors(context);
        IEnumerable<MedicationRequest> p_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, o_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> q_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> r_(MedicationRequest MR)
        {
            IEnumerable<Medication> bh_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));
            bool? bi_(Medication M)
            {
                object bm_ = context.Operators.LateBoundProperty<object>(M, "id.value");
                object bn_ = context.Operators.LateBoundProperty<object>(MR, "medication.reference.value");
                IEnumerable<string> bo_ = context.Operators.Split((string)bn_, "/");
                string bp_ = context.Operators.Last<string>(bo_);
                bool? bq_ = context.Operators.Equal(bm_, bp_);
                CodeableConcept br_ = M?.Code;
                CqlConcept bs_ = FHIRHelpers_minus_4_4_000.Instance.ToConcept(context, br_);
                CqlValueSet bt_ = this.Aromatase_Inhibitors(context);
                bool? bu_ = context.Operators.ConceptInValueSet(bs_, bt_);
                bool? bv_ = context.Operators.And(bq_, bu_);

                return bv_;
            };
            IEnumerable<Medication> bj_ = context.Operators.Where<Medication>(bh_, bi_);
            MedicationRequest bk_(Medication M) =>
                MR;
            IEnumerable<MedicationRequest> bl_ = context.Operators.Select<Medication, MedicationRequest>(bj_, bk_);

            return bl_;
        };
        IEnumerable<MedicationRequest> s_ = context.Operators.SelectMany<MedicationRequest, MedicationRequest>(q_, r_);
        IEnumerable<MedicationRequest> t_ = context.Operators.Union<MedicationRequest>(p_, s_);
        IEnumerable<MedicationRequest> u_ = Status_minus_1_8_000.Instance.isMedicationActive(context, t_);
        bool? v_(MedicationRequest AromataseInhibitorActive)
        {
            CqlInterval<CqlDate> bw_ = CumulativeMedicationDuration_minus_4_1_000.Instance.MedicationRequestPeriod(context, AromataseInhibitorActive);
            CqlDate bx_ = context.Operators.Start(bw_);
            CqlDateTime by_ = context.Operators.ConvertDateToDateTime(bx_);
            CqlInterval<CqlDateTime> bz_ = this.Measurement_Period(context);
            CqlDateTime ca_ = context.Operators.Start(bz_);
            bool? cb_ = context.Operators.Before(by_, ca_, default);

            return cb_;
        };
        IEnumerable<MedicationRequest> w_ = context.Operators.Where<MedicationRequest>(u_, v_);
        IEnumerable<object> x_ = context.Operators.Union<object>(n_ as IEnumerable<object>, w_ as IEnumerable<object>);
        IEnumerable<MedicationRequest> z_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, o_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> ab_(MedicationRequest MR)
        {
            IEnumerable<Medication> cc_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));
            bool? cd_(Medication M)
            {
                object ch_ = context.Operators.LateBoundProperty<object>(M, "id.value");
                object ci_ = context.Operators.LateBoundProperty<object>(MR, "medication.reference.value");
                IEnumerable<string> cj_ = context.Operators.Split((string)ci_, "/");
                string ck_ = context.Operators.Last<string>(cj_);
                bool? cl_ = context.Operators.Equal(ch_, ck_);
                CodeableConcept cm_ = M?.Code;
                CqlConcept cn_ = FHIRHelpers_minus_4_4_000.Instance.ToConcept(context, cm_);
                CqlValueSet co_ = this.Aromatase_Inhibitors(context);
                bool? cp_ = context.Operators.ConceptInValueSet(cn_, co_);
                bool? cq_ = context.Operators.And(cl_, cp_);

                return cq_;
            };
            IEnumerable<Medication> ce_ = context.Operators.Where<Medication>(cc_, cd_);
            MedicationRequest cf_(Medication M) =>
                MR;
            IEnumerable<MedicationRequest> cg_ = context.Operators.Select<Medication, MedicationRequest>(ce_, cf_);

            return cg_;
        };
        IEnumerable<MedicationRequest> ac_ = context.Operators.SelectMany<MedicationRequest, MedicationRequest>(q_, ab_);
        IEnumerable<MedicationRequest> ad_ = context.Operators.Union<MedicationRequest>(z_, ac_);
        IEnumerable<MedicationRequest> ae_ = Status_minus_1_8_000.Instance.isMedicationOrder(context, ad_);
        bool? af_(MedicationRequest AromataseInhibitorOrder)
        {
            FhirDateTime cr_ = AromataseInhibitorOrder?.AuthoredOnElement;
            CqlDateTime cs_ = context.Operators.Convert<CqlDateTime>(cr_);
            CqlInterval<CqlDateTime> ct_ = QICoreCommon_minus_2_1_000.Instance.toInterval(context, cs_ as object);
            CqlInterval<CqlDateTime> cu_()
            {
                bool cw_()
                {
                    CqlInterval<CqlDateTime> cx_ = this.Measurement_Period(context);
                    CqlDateTime cy_ = context.Operators.Start(cx_);

                    return cy_ is null;
                };
                if (cw_())
                {
                    return default;
                }
                else
                {
                    CqlInterval<CqlDateTime> cz_ = this.Measurement_Period(context);
                    CqlDateTime da_ = context.Operators.Start(cz_);
                    CqlDateTime dc_ = context.Operators.Start(cz_);
                    CqlInterval<CqlDateTime> dd_ = context.Operators.Interval(da_, dc_, true, true);

                    return dd_;
                }
            };
            bool? cv_ = context.Operators.Before(ct_, cu_(), default);

            return cv_;
        };
        IEnumerable<MedicationRequest> ag_ = context.Operators.Where<MedicationRequest>(ae_, af_);
        IEnumerable<object> ah_ = context.Operators.Union<object>(x_ as IEnumerable<object>, ag_ as IEnumerable<object>);
        CqlValueSet ai_ = this.History_of_hip_fracture_in_parent(context);
        IEnumerable<Observation> aj_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, ai_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
        IEnumerable<Observation> ak_ = Status_minus_1_8_000.Instance.isAssessmentPerformed(context, aj_);
        bool? al_(Observation ParentFractureHistory)
        {
            DataType de_ = ParentFractureHistory?.Effective;
            object df_ = FHIRHelpers_minus_4_4_000.Instance.ToValue(context, de_);
            CqlInterval<CqlDateTime> dg_ = QICoreCommon_minus_2_1_000.Instance.toInterval(context, df_);
            CqlDateTime dh_ = context.Operators.Start(dg_);
            CqlInterval<CqlDateTime> di_ = this.Measurement_Period(context);
            CqlDateTime dj_ = context.Operators.Start(di_);
            bool? dk_ = context.Operators.Before(dh_, dj_, default);

            return dk_;
        };
        IEnumerable<Observation> am_ = context.Operators.Where<Observation>(ak_, al_);
        IEnumerable<object> an_ = context.Operators.Union<object>(ah_ as IEnumerable<object>, am_ as IEnumerable<object>);
        IEnumerable<object> ao_ = context.Operators.Union<object>(i_ as IEnumerable<object>, an_ as IEnumerable<object>);
        bool? ap_ = context.Operators.Exists<object>(ao_);

        return ap_;
    }


    [CqlExpressionDefinition("Glucocorticoid Active Medication Days")]
    public int? Glucocorticoid_Active_Medication_Days(CqlContext context)
    {
        CqlValueSet a_ = this.Glucocorticoids__oral_only_(context);
        IEnumerable<MedicationRequest> b_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> c_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> d_(MedicationRequest MR)
        {
            IEnumerable<Medication> n_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));
            bool? o_(Medication M)
            {
                object s_ = context.Operators.LateBoundProperty<object>(M, "id.value");
                object t_ = context.Operators.LateBoundProperty<object>(MR, "medication.reference.value");
                IEnumerable<string> u_ = context.Operators.Split((string)t_, "/");
                string v_ = context.Operators.Last<string>(u_);
                bool? w_ = context.Operators.Equal(s_, v_);
                CodeableConcept x_ = M?.Code;
                CqlConcept y_ = FHIRHelpers_minus_4_4_000.Instance.ToConcept(context, x_);
                CqlValueSet z_ = this.Glucocorticoids__oral_only_(context);
                bool? aa_ = context.Operators.ConceptInValueSet(y_, z_);
                bool? ab_ = context.Operators.And(w_, aa_);

                return ab_;
            };
            IEnumerable<Medication> p_ = context.Operators.Where<Medication>(n_, o_);
            MedicationRequest q_(Medication M) =>
                MR;
            IEnumerable<MedicationRequest> r_ = context.Operators.Select<Medication, MedicationRequest>(p_, q_);

            return r_;
        };
        IEnumerable<MedicationRequest> e_ = context.Operators.SelectMany<MedicationRequest, MedicationRequest>(c_, d_);
        IEnumerable<MedicationRequest> f_ = context.Operators.Union<MedicationRequest>(b_, e_);
        IEnumerable<MedicationRequest> g_ = Status_minus_1_8_000.Instance.isMedicationActive(context, f_);
        bool? h_(MedicationRequest OralGlucocorticoid)
        {
            CqlInterval<CqlDate> ac_ = CumulativeMedicationDuration_minus_4_1_000.Instance.medicationRequestPeriod(context, OralGlucocorticoid);
            CqlDate ad_ = context.Operators.Start(ac_);
            CqlDateTime ae_ = context.Operators.ConvertDateToDateTime(ad_);
            CqlInterval<CqlDateTime> af_ = this.Measurement_Period(context);
            CqlDateTime ag_ = context.Operators.End(af_);
            bool? ah_ = context.Operators.Before(ae_, ag_, default);

            return ah_;
        };
        IEnumerable<MedicationRequest> i_ = context.Operators.Where<MedicationRequest>(g_, h_);
        CqlInterval<CqlDate> j_(MedicationRequest Glucocorticoid)
        {
            CqlInterval<CqlDate> ai_ = CumulativeMedicationDuration_minus_4_1_000.Instance.medicationRequestPeriod(context, Glucocorticoid);
            Patient aj_ = this.Patient(context);
            Date ak_ = aj_?.BirthDateElement;
            string al_ = ak_?.Value;
            CqlDate am_ = context.Operators.ConvertStringToDate(al_);
            CqlInterval<CqlDateTime> an_ = this.Measurement_Period(context);
            CqlDateTime ao_ = context.Operators.End(an_);
            CqlDate ap_ = context.Operators.DateFrom(ao_);
            CqlInterval<CqlDate> aq_ = context.Operators.Interval(am_, ap_, true, true);
            CqlInterval<CqlDate> ar_ = context.Operators.Intersect<CqlDate>(ai_, aq_);

            return ar_;
        };
        IEnumerable<CqlInterval<CqlDate>> k_ = context.Operators.Select<MedicationRequest, CqlInterval<CqlDate>>(i_, j_);
        IEnumerable<CqlInterval<CqlDate>> l_ = context.Operators.Distinct<CqlInterval<CqlDate>>(k_);
        int? m_ = CumulativeMedicationDuration_minus_4_1_000.Instance.cumulativeDuration(context, l_);

        return m_;
    }


    [CqlExpressionDefinition("Has 90 or More Active Glucocorticoid Medication Days")]
    public bool? Has_90_or_More_Active_Glucocorticoid_Medication_Days(CqlContext context)
    {
        int? a_ = this.Glucocorticoid_Active_Medication_Days(context);
        bool? b_ = context.Operators.GreaterOrEqual(a_, 90);

        return b_;
    }


    [CqlFunctionDefinition("diagnosisInPatientHistory")]
    public IEnumerable<Condition> diagnosisInPatientHistory(CqlContext context, IEnumerable<Condition> Condition)
    {
        bool? a_(Condition Dx)
        {
            CqlInterval<CqlDateTime> c_ = QICoreCommon_minus_2_1_000.Instance.prevalenceInterval(context, Dx);
            CqlDateTime d_ = context.Operators.Start(c_);
            CqlInterval<CqlDateTime> e_ = this.Measurement_Period(context);
            CqlDateTime f_ = context.Operators.End(e_);
            bool? g_ = context.Operators.SameOrBefore(d_, f_, "day");

            return g_;
        };
        IEnumerable<Condition> b_ = context.Operators.Where<Condition>(Condition, a_);

        return b_;
    }


    [CqlFunctionDefinition("procedureInPatientHistory")]
    public IEnumerable<Procedure> procedureInPatientHistory(CqlContext context, IEnumerable<Procedure> Procedure)
    {
        IEnumerable<Procedure> a_ = Status_minus_1_8_000.Instance.isProcedurePerformed(context, Procedure);
        bool? b_(Procedure Proc)
        {
            DataType d_ = Proc?.Performed;
            object e_ = FHIRHelpers_minus_4_4_000.Instance.ToValue(context, d_);
            CqlInterval<CqlDateTime> f_ = QICoreCommon_minus_2_1_000.Instance.toInterval(context, e_);
            CqlDateTime g_ = context.Operators.End(f_);
            CqlInterval<CqlDateTime> h_ = this.Measurement_Period(context);
            CqlDateTime i_ = context.Operators.End(h_);
            bool? j_ = context.Operators.SameOrBefore(g_, i_, "day");

            return j_;
        };
        IEnumerable<Procedure> c_ = context.Operators.Where<Procedure>(a_, b_);

        return c_;
    }


    [CqlExpressionDefinition("Has Double or Bilateral Oophorectomy")]
    public bool? Has_Double_or_Bilateral_Oophorectomy(CqlContext context)
    {
        CqlValueSet a_ = this.Bilateral_Oophorectomy(context);
        IEnumerable<Procedure> b_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
        IEnumerable<Procedure> c_ = this.procedureInPatientHistory(context, b_);
        bool? d_ = context.Operators.Exists<Procedure>(c_);
        CqlValueSet e_ = this.Evidence_of_Bilateral_Oophorectomy(context);
        IEnumerable<Procedure> f_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, e_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
        IEnumerable<Procedure> g_ = this.procedureInPatientHistory(context, f_);
        bool? h_ = context.Operators.Exists<Procedure>(g_);
        bool? i_ = context.Operators.Or(d_, h_);
        CqlValueSet j_ = this.Unilateral_Oophorectomy__Unspecified_Laterality(context);
        IEnumerable<Procedure> k_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, j_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
        bool? l_(Procedure UnilateralOophorectomy)
        {
            List<CodeableConcept> ad_ = UnilateralOophorectomy?.BodySite;
            CqlConcept ae_(CodeableConcept @this)
            {
                CqlConcept aj_ = FHIRHelpers_minus_4_4_000.Instance.ToConcept(context, @this);

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
        IEnumerable<Procedure> o_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, n_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
        IEnumerable<Procedure> p_ = context.Operators.Union<Procedure>(m_, o_);
        IEnumerable<Procedure> q_ = this.procedureInPatientHistory(context, p_);
        bool? r_ = context.Operators.Exists<Procedure>(q_);
        IEnumerable<Procedure> t_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, j_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
        bool? u_(Procedure UnilateralOophorectomy)
        {
            List<CodeableConcept> an_ = UnilateralOophorectomy?.BodySite;
            CqlConcept ao_(CodeableConcept @this)
            {
                CqlConcept at_ = FHIRHelpers_minus_4_4_000.Instance.ToConcept(context, @this);

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
        IEnumerable<Procedure> x_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, w_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
        IEnumerable<Procedure> y_ = context.Operators.Union<Procedure>(v_, x_);
        IEnumerable<Procedure> z_ = this.procedureInPatientHistory(context, y_);
        bool? aa_ = context.Operators.Exists<Procedure>(z_);
        bool? ab_ = context.Operators.And(r_, aa_);
        bool? ac_ = context.Operators.Or(i_, ab_);

        return ac_;
    }


    [CqlExpressionDefinition("Has Organ Transplants")]
    public bool? Has_Organ_Transplants(CqlContext context)
    {
        CqlValueSet a_ = this.Major_Transplant(context);
        IEnumerable<Procedure> b_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
        CqlValueSet c_ = this.Kidney_Transplant(context);
        IEnumerable<Procedure> d_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, c_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
        IEnumerable<Procedure> e_ = context.Operators.Union<Procedure>(b_, d_);
        CqlValueSet f_ = this.Bone_Marrow_Transplant(context);
        IEnumerable<Procedure> g_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, f_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
        IEnumerable<Procedure> h_ = context.Operators.Union<Procedure>(e_, g_);
        IEnumerable<Procedure> i_ = this.procedureInPatientHistory(context, h_);
        bool? j_ = context.Operators.Exists<Procedure>(i_);

        return j_;
    }


    [CqlExpressionDefinition("Has Risk Factor Any Time in History or During Measurement Period")]
    public bool? Has_Risk_Factor_Any_Time_in_History_or_During_Measurement_Period(CqlContext context)
    {
        bool? a_ = this.Has_90_or_More_Active_Glucocorticoid_Medication_Days(context);
        CqlValueSet b_ = this.Osteoporosis_With_Current_Fracture(context);
        IEnumerable<Condition> c_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, b_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        CqlValueSet d_ = this.Malabsorption_Syndromes(context);
        IEnumerable<Condition> e_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, d_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        IEnumerable<Condition> f_ = context.Operators.Union<Condition>(c_, e_);
        CqlValueSet g_ = this.Chronic_Malnutrition(context);
        IEnumerable<Condition> h_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, g_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        CqlValueSet i_ = this.Chronic_Liver_Disease(context);
        IEnumerable<Condition> j_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, i_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        IEnumerable<Condition> k_ = context.Operators.Union<Condition>(h_, j_);
        IEnumerable<Condition> l_ = context.Operators.Union<Condition>(f_, k_);
        CqlValueSet m_ = this.Rheumatoid_Arthritis(context);
        IEnumerable<Condition> n_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, m_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        CqlValueSet o_ = this.Hyperthyroidism(context);
        IEnumerable<Condition> p_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, o_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        IEnumerable<Condition> q_ = context.Operators.Union<Condition>(n_, p_);
        IEnumerable<Condition> r_ = context.Operators.Union<Condition>(l_, q_);
        CqlValueSet s_ = this.Type_1_Diabetes(context);
        IEnumerable<Condition> t_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, s_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        CqlValueSet u_ = this.End_Stage_Renal_Disease(context);
        IEnumerable<Condition> v_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, u_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        IEnumerable<Condition> w_ = context.Operators.Union<Condition>(t_, v_);
        IEnumerable<Condition> x_ = context.Operators.Union<Condition>(r_, w_);
        CqlValueSet y_ = this.Osteogenesis_Imperfecta(context);
        IEnumerable<Condition> z_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, y_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        CqlValueSet aa_ = this.Ankylosing_Spondylitis(context);
        IEnumerable<Condition> ab_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, aa_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        IEnumerable<Condition> ac_ = context.Operators.Union<Condition>(z_, ab_);
        IEnumerable<Condition> ad_ = context.Operators.Union<Condition>(x_, ac_);
        CqlValueSet ae_ = this.Psoriatic_Arthritis(context);
        IEnumerable<Condition> af_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, ae_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        CqlValueSet ag_ = this.Ehlers_Danlos_Syndrome(context);
        IEnumerable<Condition> ah_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, ag_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        IEnumerable<Condition> ai_ = context.Operators.Union<Condition>(af_, ah_);
        IEnumerable<Condition> aj_ = context.Operators.Union<Condition>(ad_, ai_);
        CqlValueSet ak_ = this.Cushings_Syndrome(context);
        IEnumerable<Condition> al_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, ak_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        CqlValueSet am_ = this.Hyperparathyroidism(context);
        IEnumerable<Condition> an_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, am_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        IEnumerable<Condition> ao_ = context.Operators.Union<Condition>(al_, an_);
        IEnumerable<Condition> ap_ = context.Operators.Union<Condition>(aj_, ao_);
        CqlValueSet aq_ = this.Marfans_Syndrome(context);
        IEnumerable<Condition> ar_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, aq_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        CqlValueSet as_ = this.Lupus(context);
        IEnumerable<Condition> at_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, as_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        IEnumerable<Condition> au_ = context.Operators.Union<Condition>(ar_, at_);
        IEnumerable<Condition> av_ = context.Operators.Union<Condition>(ap_, au_);
        CqlValueSet aw_ = this.Multiple_Myeloma(context);
        IEnumerable<Condition> ax_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, aw_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        CqlValueSet ay_ = this.Premature_Menopause(context);
        IEnumerable<Condition> az_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, ay_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        IEnumerable<Condition> ba_ = context.Operators.Union<Condition>(ax_, az_);
        IEnumerable<Condition> bb_ = context.Operators.Union<Condition>(av_, ba_);
        CqlValueSet bc_ = this.Eating_Disorders(context);
        IEnumerable<Condition> bd_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, bc_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        CqlValueSet be_ = this.Amenorrhea(context);
        IEnumerable<Condition> bf_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, be_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        IEnumerable<Condition> bg_ = context.Operators.Union<Condition>(bd_, bf_);
        IEnumerable<Condition> bh_ = context.Operators.Union<Condition>(bb_, bg_);
        IEnumerable<Condition> bi_ = this.diagnosisInPatientHistory(context, bh_);
        bool? bj_ = context.Operators.Exists<Condition>(bi_);
        bool? bk_ = context.Operators.Or(a_, bj_);
        CqlValueSet bl_ = this.Chemotherapy(context);
        IEnumerable<Procedure> bm_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, bl_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
        IEnumerable<Procedure> bn_ = this.procedureInPatientHistory(context, bm_);
        bool? bo_ = context.Operators.Exists<Procedure>(bn_);
        bool? bp_ = context.Operators.Or(bk_, bo_);
        bool? bq_ = this.Has_Double_or_Bilateral_Oophorectomy(context);
        bool? br_ = context.Operators.Or(bp_, bq_);
        bool? bs_ = this.Has_Organ_Transplants(context);
        bool? bt_ = context.Operators.Or(br_, bs_);

        return bt_;
    }


    [CqlExpressionDefinition("Denominator Exclusions")]
    public bool? Denominator_Exclusions(CqlContext context)
    {
        bool? a_ = this.Has_Risk_Factor_Active_During_the_Measurement_Period(context);
        bool? b_ = this.Has_Risk_Factor_Any_Time_in_History_Prior_to_Measurement_Period(context);
        bool? c_ = context.Operators.Or(a_, b_);
        bool? d_ = this.Has_Risk_Factor_Any_Time_in_History_or_During_Measurement_Period(context);
        bool? e_ = context.Operators.Or(c_, d_);

        return e_;
    }


    [CqlExpressionDefinition("DXA Scan Order During Measurement Period")]
    public IEnumerable<ServiceRequest> DXA_Scan_Order_During_Measurement_Period(CqlContext context)
    {
        CqlValueSet a_ = this.DXA__Dual_energy_Xray_Absorptiometry__Scan(context);
        IEnumerable<ServiceRequest> b_ = context.Operators.Retrieve<ServiceRequest>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-servicerequest"));
        IEnumerable<ServiceRequest> c_ = Status_minus_1_8_000.Instance.isDiagnosticStudyOrder(context, b_);
        bool? d_(ServiceRequest DXA)
        {
            CqlInterval<CqlDateTime> h_ = this.Measurement_Period(context);
            FhirDateTime i_ = DXA?.AuthoredOnElement;
            CqlDateTime j_ = context.Operators.Convert<CqlDateTime>(i_);
            CqlInterval<CqlDateTime> k_ = QICoreCommon_minus_2_1_000.Instance.toInterval(context, j_ as object);
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


    [CqlExpressionDefinition("Numerator")]
    public bool? Numerator(CqlContext context)
    {
        IEnumerable<ServiceRequest> a_ = this.DXA_Scan_Order_During_Measurement_Period(context);
        bool? b_ = context.Operators.Exists<ServiceRequest>(a_);

        return b_;
    }


    [CqlExpressionDefinition("Osteoporosis Fracture Risk Assessment Prior to First DXA Scan")]
    public IEnumerable<Observation> Osteoporosis_Fracture_Risk_Assessment_Prior_to_First_DXA_Scan(CqlContext context)
    {
        CqlCode a_ = this.Major_osteoporotic_fracture_10_minus_year_probability__Likelihood__Fracture_Risk_Assessment(context);
        IEnumerable<CqlCode> b_ = context.Operators.ToList<CqlCode>(a_);
        IEnumerable<Observation> c_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, b_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
        IEnumerable<Observation> d_ = Status_minus_1_8_000.Instance.isAssessmentPerformed(context, c_);
        bool? e_(Observation FRAX)
        {
            DataType ad_ = FRAX?.Value;
            object ae_ = FHIRHelpers_minus_4_4_000.Instance.ToValue(context, ad_);
            CqlQuantity af_ = context.Operators.Quantity(8.4m, "%");
            bool? ag_ = context.Operators.GreaterOrEqual(ae_ as CqlQuantity, af_);

            return ag_;
        };
        IEnumerable<Observation> f_ = context.Operators.Where<Observation>(d_, e_);
        CqlCode g_ = this.Osteoporosis_Risk_Assessment_Instrument(context);
        IEnumerable<CqlCode> h_ = context.Operators.ToList<CqlCode>(g_);
        IEnumerable<Observation> i_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, h_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
        IEnumerable<Observation> j_ = Status_minus_1_8_000.Instance.isAssessmentPerformed(context, i_);
        bool? k_(Observation ORAI)
        {
            DataType ah_ = ORAI?.Value;
            object ai_ = FHIRHelpers_minus_4_4_000.Instance.ToValue(context, ah_);
            bool? aj_ = context.Operators.GreaterOrEqual(ai_ as int?, 9);

            return aj_;
        };
        IEnumerable<Observation> l_ = context.Operators.Where<Observation>(j_, k_);
        IEnumerable<Observation> m_ = context.Operators.Union<Observation>(f_, l_);
        CqlCode n_ = this.Osteoporosis_Index_of_Risk_panel(context);
        IEnumerable<CqlCode> o_ = context.Operators.ToList<CqlCode>(n_);
        IEnumerable<Observation> p_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, o_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
        IEnumerable<Observation> q_ = Status_minus_1_8_000.Instance.isAssessmentPerformed(context, p_);
        bool? r_(Observation OSIRIS)
        {
            DataType ak_ = OSIRIS?.Value;
            object al_ = FHIRHelpers_minus_4_4_000.Instance.ToValue(context, ak_);
            CqlQuantity am_ = context.Operators.ConvertDecimalToQuantity(1.0m);
            bool? an_ = context.Operators.Less(al_ as CqlQuantity, am_);

            return an_;
        };
        IEnumerable<Observation> s_ = context.Operators.Where<Observation>(q_, r_);
        CqlCode t_ = this.Osteoporosis_Self_minus_Assessment_Tool(context);
        IEnumerable<CqlCode> u_ = context.Operators.ToList<CqlCode>(t_);
        IEnumerable<Observation> v_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, u_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
        IEnumerable<Observation> w_ = Status_minus_1_8_000.Instance.isAssessmentPerformed(context, v_);
        bool? x_(Observation OST)
        {
            DataType ao_ = OST?.Value;
            object ap_ = FHIRHelpers_minus_4_4_000.Instance.ToValue(context, ao_);
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
            object at_ = FHIRHelpers_minus_4_4_000.Instance.ToValue(context, as_);
            CqlInterval<CqlDateTime> au_ = QICoreCommon_minus_2_1_000.Instance.toInterval(context, at_);
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


    [CqlExpressionDefinition("Numerator Exclusion")]
    public bool? Numerator_Exclusion(CqlContext context)
    {
        IEnumerable<Observation> a_ = this.Osteoporosis_Fracture_Risk_Assessment_Prior_to_First_DXA_Scan(context);
        bool? b_ = context.Operators.Exists<Observation>(a_);

        return b_;
    }


    #endregion Functions and Expressions

}

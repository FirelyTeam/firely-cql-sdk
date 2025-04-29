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

    #region ValueSet: Amenorrhea
    [CqlValueSetDefinition(
        definitionName: "Amenorrhea",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.1022",
        valueSetVersion: null)]
    public CqlValueSet Amenorrhea(CqlContext context) => _Amenorrhea;

    private static readonly CqlValueSet _Amenorrhea = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.1022", null);
    #endregion

    #region ValueSet: Ankylosing Spondylitis
    [CqlValueSetDefinition(
        definitionName: "Ankylosing Spondylitis",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.113.12.1045",
        valueSetVersion: null)]
    public CqlValueSet Ankylosing_Spondylitis(CqlContext context) => _Ankylosing_Spondylitis;

    private static readonly CqlValueSet _Ankylosing_Spondylitis = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.113.12.1045", null);
    #endregion

    #region ValueSet: Aromatase Inhibitors
    [CqlValueSetDefinition(
        definitionName: "Aromatase Inhibitors",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.196.12.1265",
        valueSetVersion: null)]
    public CqlValueSet Aromatase_Inhibitors(CqlContext context) => _Aromatase_Inhibitors;

    private static readonly CqlValueSet _Aromatase_Inhibitors = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.196.12.1265", null);
    #endregion

    #region ValueSet: Bilateral Oophorectomy
    [CqlValueSetDefinition(
        definitionName: "Bilateral Oophorectomy",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.471",
        valueSetVersion: null)]
    public CqlValueSet Bilateral_Oophorectomy(CqlContext context) => _Bilateral_Oophorectomy;

    private static readonly CqlValueSet _Bilateral_Oophorectomy = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.471", null);
    #endregion

    #region ValueSet: Bone Marrow Transplant
    [CqlValueSetDefinition(
        definitionName: "Bone Marrow Transplant",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.666.5.336",
        valueSetVersion: null)]
    public CqlValueSet Bone_Marrow_Transplant(CqlContext context) => _Bone_Marrow_Transplant;

    private static readonly CqlValueSet _Bone_Marrow_Transplant = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.666.5.336", null);
    #endregion

    #region ValueSet: Chemotherapy
    [CqlValueSetDefinition(
        definitionName: "Chemotherapy",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.485",
        valueSetVersion: null)]
    public CqlValueSet Chemotherapy(CqlContext context) => _Chemotherapy;

    private static readonly CqlValueSet _Chemotherapy = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.485", null);
    #endregion

    #region ValueSet: Chronic Liver Disease
    [CqlValueSetDefinition(
        definitionName: "Chronic Liver Disease",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.199.12.1035",
        valueSetVersion: null)]
    public CqlValueSet Chronic_Liver_Disease(CqlContext context) => _Chronic_Liver_Disease;

    private static readonly CqlValueSet _Chronic_Liver_Disease = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.199.12.1035", null);
    #endregion

    #region ValueSet: Chronic Malnutrition
    [CqlValueSetDefinition(
        definitionName: "Chronic Malnutrition",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.199.12.1036",
        valueSetVersion: null)]
    public CqlValueSet Chronic_Malnutrition(CqlContext context) => _Chronic_Malnutrition;

    private static readonly CqlValueSet _Chronic_Malnutrition = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.199.12.1036", null);
    #endregion

    #region ValueSet: Cushings Syndrome
    [CqlValueSetDefinition(
        definitionName: "Cushings Syndrome",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.117.12.1009",
        valueSetVersion: null)]
    public CqlValueSet Cushings_Syndrome(CqlContext context) => _Cushings_Syndrome;

    private static readonly CqlValueSet _Cushings_Syndrome = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.117.12.1009", null);
    #endregion

    #region ValueSet: DXA (Dual energy Xray Absorptiometry) Scan
    [CqlValueSetDefinition(
        definitionName: "DXA (Dual energy Xray Absorptiometry) Scan",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.113.12.1051",
        valueSetVersion: null)]
    public CqlValueSet DXA__Dual_energy_Xray_Absorptiometry__Scan(CqlContext context) => _DXA__Dual_energy_Xray_Absorptiometry__Scan;

    private static readonly CqlValueSet _DXA__Dual_energy_Xray_Absorptiometry__Scan = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.113.12.1051", null);
    #endregion

    #region ValueSet: Eating Disorders
    [CqlValueSetDefinition(
        definitionName: "Eating Disorders",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.1039",
        valueSetVersion: null)]
    public CqlValueSet Eating_Disorders(CqlContext context) => _Eating_Disorders;

    private static readonly CqlValueSet _Eating_Disorders = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.1039", null);
    #endregion

    #region ValueSet: Ehlers Danlos Syndrome
    [CqlValueSetDefinition(
        definitionName: "Ehlers Danlos Syndrome",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.113.12.1047",
        valueSetVersion: null)]
    public CqlValueSet Ehlers_Danlos_Syndrome(CqlContext context) => _Ehlers_Danlos_Syndrome;

    private static readonly CqlValueSet _Ehlers_Danlos_Syndrome = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.113.12.1047", null);
    #endregion

    #region ValueSet: End Stage Renal Disease
    [CqlValueSetDefinition(
        definitionName: "End Stage Renal Disease",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.353",
        valueSetVersion: null)]
    public CqlValueSet End_Stage_Renal_Disease(CqlContext context) => _End_Stage_Renal_Disease;

    private static readonly CqlValueSet _End_Stage_Renal_Disease = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.353", null);
    #endregion

    #region ValueSet: Evidence of Bilateral Oophorectomy
    [CqlValueSetDefinition(
        definitionName: "Evidence of Bilateral Oophorectomy",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.1048",
        valueSetVersion: null)]
    public CqlValueSet Evidence_of_Bilateral_Oophorectomy(CqlContext context) => _Evidence_of_Bilateral_Oophorectomy;

    private static readonly CqlValueSet _Evidence_of_Bilateral_Oophorectomy = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.1048", null);
    #endregion

    #region ValueSet: Gastric Bypass Surgery
    [CqlValueSetDefinition(
        definitionName: "Gastric Bypass Surgery",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.198.12.1050",
        valueSetVersion: null)]
    public CqlValueSet Gastric_Bypass_Surgery(CqlContext context) => _Gastric_Bypass_Surgery;

    private static readonly CqlValueSet _Gastric_Bypass_Surgery = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.198.12.1050", null);
    #endregion

    #region ValueSet: Glucocorticoids (oral only)
    [CqlValueSetDefinition(
        definitionName: "Glucocorticoids (oral only)",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.196.12.1266",
        valueSetVersion: null)]
    public CqlValueSet Glucocorticoids__oral_only_(CqlContext context) => _Glucocorticoids__oral_only_;

    private static readonly CqlValueSet _Glucocorticoids__oral_only_ = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.196.12.1266", null);
    #endregion

    #region ValueSet: History of hip fracture in parent
    [CqlValueSetDefinition(
        definitionName: "History of hip fracture in parent",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.113.12.1040",
        valueSetVersion: null)]
    public CqlValueSet History_of_hip_fracture_in_parent(CqlContext context) => _History_of_hip_fracture_in_parent;

    private static readonly CqlValueSet _History_of_hip_fracture_in_parent = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.113.12.1040", null);
    #endregion

    #region ValueSet: Hyperparathyroidism
    [CqlValueSetDefinition(
        definitionName: "Hyperparathyroidism",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.117.12.1016",
        valueSetVersion: null)]
    public CqlValueSet Hyperparathyroidism(CqlContext context) => _Hyperparathyroidism;

    private static readonly CqlValueSet _Hyperparathyroidism = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.117.12.1016", null);
    #endregion

    #region ValueSet: Hyperthyroidism
    [CqlValueSetDefinition(
        definitionName: "Hyperthyroidism",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.117.12.1015",
        valueSetVersion: null)]
    public CqlValueSet Hyperthyroidism(CqlContext context) => _Hyperthyroidism;

    private static readonly CqlValueSet _Hyperthyroidism = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.117.12.1015", null);
    #endregion

    #region ValueSet: Kidney Transplant
    [CqlValueSetDefinition(
        definitionName: "Kidney Transplant",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.109.12.1012",
        valueSetVersion: null)]
    public CqlValueSet Kidney_Transplant(CqlContext context) => _Kidney_Transplant;

    private static readonly CqlValueSet _Kidney_Transplant = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.109.12.1012", null);
    #endregion

    #region ValueSet: Lupus
    [CqlValueSetDefinition(
        definitionName: "Lupus",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.117.12.1010",
        valueSetVersion: null)]
    public CqlValueSet Lupus(CqlContext context) => _Lupus;

    private static readonly CqlValueSet _Lupus = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.117.12.1010", null);
    #endregion

    #region ValueSet: Major Transplant
    [CqlValueSetDefinition(
        definitionName: "Major Transplant",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.198.12.1075",
        valueSetVersion: null)]
    public CqlValueSet Major_Transplant(CqlContext context) => _Major_Transplant;

    private static readonly CqlValueSet _Major_Transplant = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.198.12.1075", null);
    #endregion

    #region ValueSet: Malabsorption Syndromes
    [CqlValueSetDefinition(
        definitionName: "Malabsorption Syndromes",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.199.12.1050",
        valueSetVersion: null)]
    public CqlValueSet Malabsorption_Syndromes(CqlContext context) => _Malabsorption_Syndromes;

    private static readonly CqlValueSet _Malabsorption_Syndromes = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.199.12.1050", null);
    #endregion

    #region ValueSet: Marfan's Syndrome
    [CqlValueSetDefinition(
        definitionName: "Marfan's Syndrome",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.113.12.1048",
        valueSetVersion: null)]
    public CqlValueSet Marfans_Syndrome(CqlContext context) => _Marfans_Syndrome;

    private static readonly CqlValueSet _Marfans_Syndrome = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.113.12.1048", null);
    #endregion

    #region ValueSet: Multiple Myeloma
    [CqlValueSetDefinition(
        definitionName: "Multiple Myeloma",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.1011",
        valueSetVersion: null)]
    public CqlValueSet Multiple_Myeloma(CqlContext context) => _Multiple_Myeloma;

    private static readonly CqlValueSet _Multiple_Myeloma = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.1011", null);
    #endregion

    #region ValueSet: Office Visit
    [CqlValueSetDefinition(
        definitionName: "Office Visit",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1001",
        valueSetVersion: null)]
    public CqlValueSet Office_Visit(CqlContext context) => _Office_Visit;

    private static readonly CqlValueSet _Office_Visit = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1001", null);
    #endregion

    #region ValueSet: Osteogenesis Imperfecta
    [CqlValueSetDefinition(
        definitionName: "Osteogenesis Imperfecta",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.113.12.1044",
        valueSetVersion: null)]
    public CqlValueSet Osteogenesis_Imperfecta(CqlContext context) => _Osteogenesis_Imperfecta;

    private static readonly CqlValueSet _Osteogenesis_Imperfecta = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.113.12.1044", null);
    #endregion

    #region ValueSet: Osteopenia
    [CqlValueSetDefinition(
        definitionName: "Osteopenia",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.113.12.1049",
        valueSetVersion: null)]
    public CqlValueSet Osteopenia(CqlContext context) => _Osteopenia;

    private static readonly CqlValueSet _Osteopenia = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.113.12.1049", null);
    #endregion

    #region ValueSet: Osteoporosis Without Current Fracture
    [CqlValueSetDefinition(
        definitionName: "Osteoporosis Without Current Fracture",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.113.12.1038",
        valueSetVersion: null)]
    public CqlValueSet Osteoporosis_Without_Current_Fracture(CqlContext context) => _Osteoporosis_Without_Current_Fracture;

    private static readonly CqlValueSet _Osteoporosis_Without_Current_Fracture = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.113.12.1038", null);
    #endregion

    #region ValueSet: Osteoporosis With Current Fracture
    [CqlValueSetDefinition(
        definitionName: "Osteoporosis With Current Fracture",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.113.12.1050",
        valueSetVersion: null)]
    public CqlValueSet Osteoporosis_With_Current_Fracture(CqlContext context) => _Osteoporosis_With_Current_Fracture;

    private static readonly CqlValueSet _Osteoporosis_With_Current_Fracture = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.113.12.1050", null);
    #endregion

    #region ValueSet: Outpatient Consultation
    [CqlValueSetDefinition(
        definitionName: "Outpatient Consultation",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1008",
        valueSetVersion: null)]
    public CqlValueSet Outpatient_Consultation(CqlContext context) => _Outpatient_Consultation;

    private static readonly CqlValueSet _Outpatient_Consultation = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1008", null);
    #endregion

    #region ValueSet: Premature Menopause
    [CqlValueSetDefinition(
        definitionName: "Premature Menopause",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.1013",
        valueSetVersion: null)]
    public CqlValueSet Premature_Menopause(CqlContext context) => _Premature_Menopause;

    private static readonly CqlValueSet _Premature_Menopause = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.1013", null);
    #endregion

    #region ValueSet: Preventive Care Services Established Office Visit, 18 and Up
    [CqlValueSetDefinition(
        definitionName: "Preventive Care Services Established Office Visit, 18 and Up",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1025",
        valueSetVersion: null)]
    public CqlValueSet Preventive_Care_Services_Established_Office_Visit__18_and_Up(CqlContext context) => _Preventive_Care_Services_Established_Office_Visit__18_and_Up;

    private static readonly CqlValueSet _Preventive_Care_Services_Established_Office_Visit__18_and_Up = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1025", null);
    #endregion

    #region ValueSet: Preventive Care Services Initial Office Visit, 18 and Up
    [CqlValueSetDefinition(
        definitionName: "Preventive Care Services Initial Office Visit, 18 and Up",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1023",
        valueSetVersion: null)]
    public CqlValueSet Preventive_Care_Services_Initial_Office_Visit__18_and_Up(CqlContext context) => _Preventive_Care_Services_Initial_Office_Visit__18_and_Up;

    private static readonly CqlValueSet _Preventive_Care_Services_Initial_Office_Visit__18_and_Up = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1023", null);
    #endregion

    #region ValueSet: Psoriatic Arthritis
    [CqlValueSetDefinition(
        definitionName: "Psoriatic Arthritis",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.113.12.1046",
        valueSetVersion: null)]
    public CqlValueSet Psoriatic_Arthritis(CqlContext context) => _Psoriatic_Arthritis;

    private static readonly CqlValueSet _Psoriatic_Arthritis = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.113.12.1046", null);
    #endregion

    #region ValueSet: Rheumatoid Arthritis
    [CqlValueSetDefinition(
        definitionName: "Rheumatoid Arthritis",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.113.12.1005",
        valueSetVersion: null)]
    public CqlValueSet Rheumatoid_Arthritis(CqlContext context) => _Rheumatoid_Arthritis;

    private static readonly CqlValueSet _Rheumatoid_Arthritis = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.113.12.1005", null);
    #endregion

    #region ValueSet: Telephone Visits
    [CqlValueSetDefinition(
        definitionName: "Telephone Visits",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1080",
        valueSetVersion: null)]
    public CqlValueSet Telephone_Visits(CqlContext context) => _Telephone_Visits;

    private static readonly CqlValueSet _Telephone_Visits = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1080", null);
    #endregion

    #region ValueSet: Type 1 Diabetes
    [CqlValueSetDefinition(
        definitionName: "Type 1 Diabetes",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.103.12.1020",
        valueSetVersion: null)]
    public CqlValueSet Type_1_Diabetes(CqlContext context) => _Type_1_Diabetes;

    private static readonly CqlValueSet _Type_1_Diabetes = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.103.12.1020", null);
    #endregion

    #region ValueSet: Unilateral Oophorectomy Left
    [CqlValueSetDefinition(
        definitionName: "Unilateral Oophorectomy Left",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.1028",
        valueSetVersion: null)]
    public CqlValueSet Unilateral_Oophorectomy_Left(CqlContext context) => _Unilateral_Oophorectomy_Left;

    private static readonly CqlValueSet _Unilateral_Oophorectomy_Left = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.1028", null);
    #endregion

    #region ValueSet: Unilateral Oophorectomy Right
    [CqlValueSetDefinition(
        definitionName: "Unilateral Oophorectomy Right",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.1032",
        valueSetVersion: null)]
    public CqlValueSet Unilateral_Oophorectomy_Right(CqlContext context) => _Unilateral_Oophorectomy_Right;

    private static readonly CqlValueSet _Unilateral_Oophorectomy_Right = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.1032", null);
    #endregion

    #region ValueSet: Unilateral Oophorectomy, Unspecified Laterality
    [CqlValueSetDefinition(
        definitionName: "Unilateral Oophorectomy, Unspecified Laterality",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.1035",
        valueSetVersion: null)]
    public CqlValueSet Unilateral_Oophorectomy__Unspecified_Laterality(CqlContext context) => _Unilateral_Oophorectomy__Unspecified_Laterality;

    private static readonly CqlValueSet _Unilateral_Oophorectomy__Unspecified_Laterality = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.1035", null);
    #endregion

    #region ValueSet: Virtual Encounter
    [CqlValueSetDefinition(
        definitionName: "Virtual Encounter",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1089",
        valueSetVersion: null)]
    public CqlValueSet Virtual_Encounter(CqlContext context) => _Virtual_Encounter;

    private static readonly CqlValueSet _Virtual_Encounter = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1089", null);
    #endregion

    #endregion ValueSets

    #region Codes

    #region Code: Alcoholic drinks per day
    [CqlCodeDefinition(
        definitionName: "Alcoholic drinks per day",
        codeId: "74013-4",
        codeSystem: "http://loinc.org")]
    public CqlCode Alcoholic_drinks_per_day(CqlContext context) => _Alcoholic_drinks_per_day;

    private static readonly CqlCode _Alcoholic_drinks_per_day = new CqlCode("74013-4", "http://loinc.org", default, default);
    #endregion

    #region Code: Body mass index (BMI) [Ratio]
    [CqlCodeDefinition(
        definitionName: "Body mass index (BMI) [Ratio]",
        codeId: "39156-5",
        codeSystem: "http://loinc.org")]
    public CqlCode Body_mass_index__BMI___Ratio_(CqlContext context) => _Body_mass_index__BMI___Ratio_;

    private static readonly CqlCode _Body_mass_index__BMI___Ratio_ = new CqlCode("39156-5", "http://loinc.org", default, default);
    #endregion

    #region Code: Female
    [CqlCodeDefinition(
        definitionName: "Female",
        codeId: "F",
        codeSystem: "http://terminology.hl7.org/CodeSystem/v3-AdministrativeGender")]
    public CqlCode Female(CqlContext context) => _Female;

    private static readonly CqlCode _Female = new CqlCode("F", "http://terminology.hl7.org/CodeSystem/v3-AdministrativeGender", default, default);
    #endregion

    #region Code: Left (qualifier value)
    [CqlCodeDefinition(
        definitionName: "Left (qualifier value)",
        codeId: "7771000",
        codeSystem: "http://snomed.info/sct")]
    public CqlCode Left__qualifier_value_(CqlContext context) => _Left__qualifier_value_;

    private static readonly CqlCode _Left__qualifier_value_ = new CqlCode("7771000", "http://snomed.info/sct", default, default);
    #endregion

    #region Code: Major osteoporotic fracture 10-year probability [Likelihood] Fracture Risk Assessment
    [CqlCodeDefinition(
        definitionName: "Major osteoporotic fracture 10-year probability [Likelihood] Fracture Risk Assessment",
        codeId: "90265-0",
        codeSystem: "http://loinc.org")]
    public CqlCode Major_osteoporotic_fracture_10_year_probability__Likelihood__Fracture_Risk_Assessment(CqlContext context) => _Major_osteoporotic_fracture_10_year_probability__Likelihood__Fracture_Risk_Assessment;

    private static readonly CqlCode _Major_osteoporotic_fracture_10_year_probability__Likelihood__Fracture_Risk_Assessment = new CqlCode("90265-0", "http://loinc.org", default, default);
    #endregion

    #region Code: Osteoporosis Index of Risk panel
    [CqlCodeDefinition(
        definitionName: "Osteoporosis Index of Risk panel",
        codeId: "98133-2",
        codeSystem: "http://loinc.org")]
    public CqlCode Osteoporosis_Index_of_Risk_panel(CqlContext context) => _Osteoporosis_Index_of_Risk_panel;

    private static readonly CqlCode _Osteoporosis_Index_of_Risk_panel = new CqlCode("98133-2", "http://loinc.org", default, default);
    #endregion

    #region Code: Osteoporosis Risk Assessment Instrument
    [CqlCodeDefinition(
        definitionName: "Osteoporosis Risk Assessment Instrument",
        codeId: "98139-9",
        codeSystem: "http://loinc.org")]
    public CqlCode Osteoporosis_Risk_Assessment_Instrument(CqlContext context) => _Osteoporosis_Risk_Assessment_Instrument;

    private static readonly CqlCode _Osteoporosis_Risk_Assessment_Instrument = new CqlCode("98139-9", "http://loinc.org", default, default);
    #endregion

    #region Code: Osteoporosis Self-Assessment Tool
    [CqlCodeDefinition(
        definitionName: "Osteoporosis Self-Assessment Tool",
        codeId: "98146-4",
        codeSystem: "http://loinc.org")]
    public CqlCode Osteoporosis_Self_Assessment_Tool(CqlContext context) => _Osteoporosis_Self_Assessment_Tool;

    private static readonly CqlCode _Osteoporosis_Self_Assessment_Tool = new CqlCode("98146-4", "http://loinc.org", default, default);
    #endregion

    #region Code: Right (qualifier value)
    [CqlCodeDefinition(
        definitionName: "Right (qualifier value)",
        codeId: "24028007",
        codeSystem: "http://snomed.info/sct")]
    public CqlCode Right__qualifier_value_(CqlContext context) => _Right__qualifier_value_;

    private static readonly CqlCode _Right__qualifier_value_ = new CqlCode("24028007", "http://snomed.info/sct", default, default);
    #endregion

    #region Code: Unlisted preventive medicine service
    [CqlCodeDefinition(
        definitionName: "Unlisted preventive medicine service",
        codeId: "99429",
        codeSystem: "http://www.ama-assn.org/go/cpt")]
    public CqlCode Unlisted_preventive_medicine_service(CqlContext context) => _Unlisted_preventive_medicine_service;

    private static readonly CqlCode _Unlisted_preventive_medicine_service = new CqlCode("99429", "http://www.ama-assn.org/go/cpt", default, default);
    #endregion

    #endregion Codes

    #region CodeSystems

    [CqlCodeSystemDefinition(
        definitionName: "LOINC")]
    public CqlCode[] LOINC(CqlContext context)
    {
        CqlCode[] azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = [
            new CqlCode("74013-4", "http://loinc.org", default, default),
            new CqlCode("39156-5", "http://loinc.org", default, default),
            new CqlCode("90265-0", "http://loinc.org", default, default),
            new CqlCode("98133-2", "http://loinc.org", default, default),
            new CqlCode("98139-9", "http://loinc.org", default, default),
            new CqlCode("98146-4", "http://loinc.org", default, default),
        ];

        return azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_;
    }


    [CqlCodeSystemDefinition(
        definitionName: "AdministrativeGender")]
    public CqlCode[] AdministrativeGender(CqlContext context)
    {
        CqlCode[] azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = [
            new CqlCode("F", "http://terminology.hl7.org/CodeSystem/v3-AdministrativeGender", default, default),
        ];

        return azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_;
    }


    [CqlCodeSystemDefinition(
        definitionName: "SNOMEDCT")]
    public CqlCode[] SNOMEDCT(CqlContext context)
    {
        CqlCode[] azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = [
            new CqlCode("7771000", "http://snomed.info/sct", default, default),
            new CqlCode("24028007", "http://snomed.info/sct", default, default),
        ];

        return azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_;
    }


    [CqlCodeSystemDefinition(
        definitionName: "CPT")]
    public CqlCode[] CPT(CqlContext context)
    {
        CqlCode[] azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = [
            new CqlCode("99429", "http://www.ama-assn.org/go/cpt", default, default),
        ];

        return azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_;
    }


    #endregion CodeSystems

    #region Parameters

    [CqlParameterDefinition(
        definitionName: "Measurement Period")]
    public CqlInterval<CqlDateTime> Measurement_Period(CqlContext context)
    {
        CqlDateTime azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.DateTime(2025, 1, 1, 0, 0, 0, 0, 0.0m);
        CqlDateTime azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.DateTime(2025, 12, 31, 23, 59, 59, 999, 0.0m);
        CqlInterval<CqlDateTime> azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Interval(azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_, azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_, true, true);
        object azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.ResolveParameter("AppropriateDXAScansForWomenUnder65FHIR-0.2.001", "Measurement Period", azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_);

        return (CqlInterval<CqlDateTime>)azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_;
    }


    #endregion Parameters

    #region Expressions

    [CqlExpressionDefinition(
        definitionName: "Patient")]
    public Patient Patient(CqlContext context)
    {
        IEnumerable<Patient> azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-patient"));
        Patient azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.SingletonFrom<Patient>(azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_);

        return azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_;
    }


    [CqlExpressionDefinition(
        definitionName: "SDE Ethnicity")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Ethnicity(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = SupplementalDataElements_3_5_000.Instance.SDE_Ethnicity(context);

        return azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_;
    }


    [CqlExpressionDefinition(
        definitionName: "SDE Payer")]
    public IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> SDE_Payer(CqlContext context)
    {
        IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = SupplementalDataElements_3_5_000.Instance.SDE_Payer(context);

        return azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_;
    }


    [CqlExpressionDefinition(
        definitionName: "SDE Race")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Race(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = SupplementalDataElements_3_5_000.Instance.SDE_Race(context);

        return azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_;
    }


    [CqlExpressionDefinition(
        definitionName: "SDE Sex")]
    public CqlCode SDE_Sex(CqlContext context)
    {
        CqlCode azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = SupplementalDataElements_3_5_000.Instance.SDE_Sex(context);

        return azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_;
    }


    [CqlExpressionDefinition(
        definitionName: "Qualifying Encounter")]
    public IEnumerable<Encounter> Qualifying_Encounter(CqlContext context)
    {
        CqlValueSet bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = this.Office_Visit(context);
        IEnumerable<Encounter> bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        CqlValueSet bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = this.Preventive_Care_Services_Established_Office_Visit__18_and_Up(context);
        IEnumerable<Encounter> bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.Union<Encounter>(bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_, bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_);
        IEnumerable<Encounter> bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        bool? bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_(Encounter E)
        {
            List<CodeableConcept> bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = E?.Type;
            CqlConcept bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_(CodeableConcept @this)
            {
                CqlConcept czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);

                return czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_;
            };
            IEnumerable<CqlConcept> czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_, bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_);
            bool? czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_(CqlConcept T)
            {
                CqlCode czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = this.Unlisted_preventive_medicine_service(context);
                CqlConcept czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.ConvertCodeToConcept(czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_);
                bool? czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Equivalent(T, czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_);

                return czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_;
            };
            IEnumerable<CqlConcept> czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Where<CqlConcept>(czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_, czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_);
            bool? czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Exists<CqlConcept>(czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_);

            return czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_;
        };
        IEnumerable<Encounter> bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Where<Encounter>(bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_, bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_);
        CqlValueSet bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = this.Preventive_Care_Services_Initial_Office_Visit__18_and_Up(context);
        IEnumerable<Encounter> bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Union<Encounter>(bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_, bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_);
        IEnumerable<Encounter> bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Union<Encounter>(bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_, bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_);
        CqlValueSet bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = this.Outpatient_Consultation(context);
        IEnumerable<Encounter> bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        CqlValueSet bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = this.Virtual_Encounter(context);
        IEnumerable<Encounter> bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Union<Encounter>(bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_, bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_);
        IEnumerable<Encounter> bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Union<Encounter>(bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_, bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_);
        CqlValueSet bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = this.Telephone_Visits(context);
        IEnumerable<Encounter> bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Union<Encounter>(bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_, bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_);
        IEnumerable<Encounter> bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = Status_1_8_000.Instance.isEncounterPerformed(context, bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_);
        bool? bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_(Encounter ValidEncounters)
        {
            CqlInterval<CqlDateTime> czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = this.Measurement_Period(context);
            Period czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = ValidEncounters?.Period;
            CqlInterval<CqlDateTime> czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_);
            CqlInterval<CqlDateTime> czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = QICoreCommon_2_1_000.Instance.toInterval(context, czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ as object);
            bool? czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_, czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_, "day");

            return czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_;
        };
        IEnumerable<Encounter> bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Where<Encounter>(bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_, bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_);

        return bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_;
    }


    [CqlExpressionDefinition(
        definitionName: "Initial Population")]
    public bool? Initial_Population(CqlContext context)
    {
        Patient czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = this.Patient(context);
        Date czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_?.BirthDateElement;
        string czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_?.Value;
        CqlDate czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.ConvertStringToDate(czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_);
        CqlInterval<CqlDateTime> czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = this.Measurement_Period(context);
        CqlDateTime czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Start(czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_);
        CqlDate czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.DateFrom(czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_);
        int? czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.CalculateAgeAt(czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_, czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_, "year");
        CqlInterval<int?> czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Interval(50, 63, true, true);
        bool? czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.In<int?>(czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_, czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_, default);
        Code<AdministrativeGender> czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_?.GenderElement;
        AdministrativeGender? czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_?.Value;
        string dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.Convert<string>(czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_);
        bool? dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Equal(dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_, "female");
        bool? dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.And(czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_, dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_);
        IEnumerable<Encounter> dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = this.Qualifying_Encounter(context);
        bool? dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.Exists<Encounter>(dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_);
        bool? dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.And(dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_, dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_);

        return dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_;
    }


    [CqlExpressionDefinition(
        definitionName: "Denominator")]
    public bool? Denominator(CqlContext context)
    {
        bool? dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = this.Initial_Population(context);

        return dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_;
    }


    [CqlExpressionDefinition(
        definitionName: "First BMI in Measurement Period")]
    public Observation First_BMI_in_Measurement_Period(CqlContext context)
    {
        IEnumerable<Observation> dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/StructureDefinition/bmi"));
        IEnumerable<Observation> dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = Status_1_8_000.Instance.isObservationBMI(context, dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_);
        bool? dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_(Observation BMIRatio)
        {
            CqlInterval<CqlDateTime> dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = this.Measurement_Period(context);
            DataType dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = BMIRatio?.Effective;
            object dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_);
            CqlInterval<CqlDateTime> dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = QICoreCommon_2_1_000.Instance.toInterval(context, dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_);
            bool? dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_, dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_, default);
            DataType dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = BMIRatio?.Value;
            CqlQuantity dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = FHIRHelpers_4_4_000.Instance.ToQuantity(context, dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ as Quantity);
            bool? dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Not((bool?)((dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ as CqlQuantity) is null));
            bool? dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.And(dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_, dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_);

            return dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_;
        };
        IEnumerable<Observation> dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Where<Observation>(dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_, dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_);
        object dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_(Observation @this)
        {
            DataType dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = @this?.Effective;
            object dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_);
            CqlInterval<CqlDateTime> dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = QICoreCommon_2_1_000.Instance.toInterval(context, dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_);
            CqlDateTime ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.Start(dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_);

            return ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_;
        };
        IEnumerable<Observation> dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.SortBy<Observation>(dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_, dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_, System.ComponentModel.ListSortDirection.Ascending);
        Observation dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.First<Observation>(dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_);

        return dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_;
    }


    [CqlExpressionDefinition(
        definitionName: "First BMI in Measurement Period Less Than or Equal to 20 kg m2")]
    public Observation First_BMI_in_Measurement_Period_Less_Than_or_Equal_to_20_kg_m2(CqlContext context)
    {
        Observation ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = this.First_BMI_in_Measurement_Period(context);
        Observation[] ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = [
            ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_,
        ];
        bool? ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_(Observation FirstBMI)
        {
            DataType ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = FirstBMI?.Value;
            CqlQuantity ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = FHIRHelpers_4_4_000.Instance.ToQuantity(context, ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ as Quantity);
            CqlQuantity ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Quantity(20m, "kg/m2");
            bool? ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.LessOrEqual(ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ as CqlQuantity, ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_);

            return ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_;
        };
        IEnumerable<Observation> ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.Where<Observation>((IEnumerable<Observation>)ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_, ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_);
        Observation ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.SingletonFrom<Observation>(ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_);

        return ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_;
    }


    [CqlExpressionDefinition(
        definitionName: "First Average Number of Drinks Assessments Indicating More Than Two Per Day")]
    public Observation First_Average_Number_of_Drinks_Assessments_Indicating_More_Than_Two_Per_Day(CqlContext context)
    {
        CqlCode ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = this.Alcoholic_drinks_per_day(context);
        IEnumerable<CqlCode> ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.ToList<CqlCode>(ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_);
        IEnumerable<Observation> ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
        IEnumerable<Observation> ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = Status_1_8_000.Instance.isAssessmentPerformed(context, ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_);
        bool? ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_(Observation AverageDrinks)
        {
            DataType ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = AverageDrinks?.Effective;
            object ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_);
            CqlInterval<CqlDateTime> ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = QICoreCommon_2_1_000.Instance.toInterval(context, ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_);
            CqlDateTime ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Start(ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_);
            CqlInterval<CqlDateTime> ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = this.Measurement_Period(context);
            bool? ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.In<CqlDateTime>(ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_, ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_, default);
            DataType ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = AverageDrinks?.Value;
            object fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_);
            CqlQuantity fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Quantity(2m, "{drinks}/d");
            bool? fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Greater(fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ as CqlQuantity, fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_);
            bool? fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.And(ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_, fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_);

            return fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_;
        };
        IEnumerable<Observation> ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Where<Observation>(ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_, ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_);
        object ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_(Observation @this)
        {
            DataType fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = @this?.Effective;
            object fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_);
            CqlInterval<CqlDateTime> fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = QICoreCommon_2_1_000.Instance.toInterval(context, fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_);
            CqlDateTime fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Start(fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_);

            return fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_;
        };
        IEnumerable<Observation> ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.SortBy<Observation>(ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_, ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_, System.ComponentModel.ListSortDirection.Ascending);
        Observation ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.First<Observation>(ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_);

        return ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_;
    }


    [CqlExpressionDefinition(
        definitionName: "Has Risk Factor Active During the Measurement Period")]
    public bool? Has_Risk_Factor_Active_During_the_Measurement_Period(CqlContext context)
    {
        Observation fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = this.First_BMI_in_Measurement_Period_Less_Than_or_Equal_to_20_kg_m2(context);
        bool? fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Not((bool?)(fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ is null));
        Observation fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = this.First_Average_Number_of_Drinks_Assessments_Indicating_More_Than_Two_Per_Day(context);
        bool? fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Not((bool?)(fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ is null));
        bool? fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Or(fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_, fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_);

        return fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_;
    }


    [CqlExpressionDefinition(
        definitionName: "Has Risk Factor Any Time in History Prior to Measurement Period")]
    public bool? Has_Risk_Factor_Any_Time_in_History_Prior_to_Measurement_Period(CqlContext context)
    {
        CqlValueSet fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = this.Osteoporosis_Without_Current_Fracture(context);
        IEnumerable<Condition> fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        bool? fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_(Condition OsteoporosisDiagnosis)
        {
            CqlInterval<CqlDateTime> hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = QICoreCommon_2_1_000.Instance.prevalenceInterval(context, OsteoporosisDiagnosis);
            CqlDateTime hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Start(hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_);
            CqlInterval<CqlDateTime> hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = this.Measurement_Period(context);
            CqlDateTime hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.Start(hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_);
            bool? hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Before(hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_, hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_, default);

            return hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_;
        };
        IEnumerable<Condition> fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Where<Condition>(fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_, fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_);
        CqlValueSet fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = this.Osteopenia(context);
        IEnumerable<Condition> fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        bool? fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_(Condition OsteopeniaDiagnosis)
        {
            CqlInterval<CqlDateTime> hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = QICoreCommon_2_1_000.Instance.prevalenceInterval(context, OsteopeniaDiagnosis);
            CqlDateTime hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Start(hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_);
            CqlInterval<CqlDateTime> hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = this.Measurement_Period(context);
            CqlDateTime hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Start(hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_);
            bool? hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Before(hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_, hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_, default);

            return hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_;
        };
        IEnumerable<Condition> fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Where<Condition>(fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_, fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_);
        IEnumerable<Condition> fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Union<Condition>(fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_, fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_);
        CqlValueSet fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = this.Gastric_Bypass_Surgery(context);
        IEnumerable<Procedure> fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
        IEnumerable<Procedure> fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = Status_1_8_000.Instance.isProcedurePerformed(context, fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_);
        bool? fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_(Procedure GastricBypass)
        {
            DataType hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = GastricBypass?.Performed;
            object hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = FHIRHelpers_4_4_000.Instance.ToValue(context, hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_);
            CqlInterval<CqlDateTime> hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = QICoreCommon_2_1_000.Instance.toInterval(context, hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_);
            CqlDateTime hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.End(hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_);
            CqlInterval<CqlDateTime> hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = this.Measurement_Period(context);
            CqlDateTime hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Start(hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_);
            bool? hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Before(hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_, hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_, default);

            return hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_;
        };
        IEnumerable<Procedure> gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.Where<Procedure>(fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_, fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_);
        CqlValueSet gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = this.Aromatase_Inhibitors(context);
        IEnumerable<MedicationRequest> gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Union<MedicationRequest>(gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_, gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_);
        IEnumerable<MedicationRequest> gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = Status_1_8_000.Instance.isMedicationActive(context, gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_);
        bool? gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_(MedicationRequest AromataseInhibitorActive)
        {
            CqlInterval<CqlDate> hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = CumulativeMedicationDuration_4_1_000.Instance.MedicationRequestPeriod(context, AromataseInhibitorActive);
            CqlDate hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Start(hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_);
            CqlDateTime hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.ConvertDateToDateTime(hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_);
            CqlInterval<CqlDateTime> hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = this.Measurement_Period(context);
            CqlDateTime hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Start(hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_);
            bool? hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Before(hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_, hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_, default);

            return hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_;
        };
        IEnumerable<MedicationRequest> gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Where<MedicationRequest>(gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_, gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_);
        IEnumerable<object> gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Union<object>(gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ as IEnumerable<object>, gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ as IEnumerable<object>);
        IEnumerable<MedicationRequest> gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Union<MedicationRequest>(gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_, gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_);
        IEnumerable<MedicationRequest> gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = Status_1_8_000.Instance.isMedicationOrder(context, gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_);
        bool? gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_(MedicationRequest AromataseInhibitorOrder)
        {
            FhirDateTime hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = AromataseInhibitorOrder?.AuthoredOnElement;
            CqlDateTime hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Convert<CqlDateTime>(hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_);
            CqlInterval<CqlDateTime> izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = QICoreCommon_2_1_000.Instance.toInterval(context, hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ as object);
            CqlInterval<CqlDateTime> izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_()
            {
                bool izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_()
                {
                    CqlInterval<CqlDateTime> izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = this.Measurement_Period(context);
                    CqlDateTime izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Start(izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_);

                    return izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ is null;
                };
                if (izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_())
                {
                    return default;
                }
                else
                {
                    CqlInterval<CqlDateTime> izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = this.Measurement_Period(context);
                    CqlDateTime izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Start(izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_);
                    CqlDateTime izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Start(izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_);
                    CqlInterval<CqlDateTime> izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Interval(izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_, izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_, true, true);

                    return izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_;
                }
            };
            bool? izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Before(izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_, izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_(), default);

            return izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_;
        };
        IEnumerable<MedicationRequest> gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Where<MedicationRequest>(gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_, gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_);
        IEnumerable<object> gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Union<object>(gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ as IEnumerable<object>, gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ as IEnumerable<object>);
        CqlValueSet gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = this.History_of_hip_fracture_in_parent(context);
        IEnumerable<Observation> gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
        IEnumerable<Observation> gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = Status_1_8_000.Instance.isAssessmentPerformed(context, gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_);
        bool? gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_(Observation ParentFractureHistory)
        {
            DataType izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = ParentFractureHistory?.Effective;
            object izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = FHIRHelpers_4_4_000.Instance.ToValue(context, izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_);
            CqlInterval<CqlDateTime> izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = QICoreCommon_2_1_000.Instance.toInterval(context, izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_);
            CqlDateTime izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Start(izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_);
            CqlInterval<CqlDateTime> izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = this.Measurement_Period(context);
            CqlDateTime izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Start(izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_);
            bool? izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Before(izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_, izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_, default);

            return izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_;
        };
        IEnumerable<Observation> gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Where<Observation>(gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_, gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_);
        IEnumerable<object> gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Union<object>(gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ as IEnumerable<object>, gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ as IEnumerable<object>);
        IEnumerable<object> gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Union<object>(fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ as IEnumerable<object>, gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ as IEnumerable<object>);
        bool? hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.Exists<object>(gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_);

        return hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_;
    }


    [CqlExpressionDefinition(
        definitionName: "Glucocorticoid Active Medication Days")]
    public int? Glucocorticoid_Active_Medication_Days(CqlContext context)
    {
        CqlValueSet izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = this.Glucocorticoids__oral_only_(context);
        IEnumerable<MedicationRequest> izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Union<MedicationRequest>(izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_, izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_);
        IEnumerable<MedicationRequest> izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = Status_1_8_000.Instance.isMedicationActive(context, izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_);
        bool? izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_(MedicationRequest OralGlucocorticoid)
        {
            CqlInterval<CqlDate> jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = CumulativeMedicationDuration_4_1_000.Instance.medicationRequestPeriod(context, OralGlucocorticoid);
            CqlDate jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Start(jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_);
            CqlDateTime jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.ConvertDateToDateTime(jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_);
            CqlInterval<CqlDateTime> jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = this.Measurement_Period(context);
            CqlDateTime jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.End(jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_);
            bool? jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Before(jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_, jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_, default);

            return jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_;
        };
        IEnumerable<MedicationRequest> izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Where<MedicationRequest>(izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_, izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_);
        CqlInterval<CqlDate> jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_(MedicationRequest Glucocorticoid)
        {
            CqlInterval<CqlDate> jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = CumulativeMedicationDuration_4_1_000.Instance.medicationRequestPeriod(context, Glucocorticoid);
            Patient jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = this.Patient(context);
            Date jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_?.BirthDateElement;
            string jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_?.Value;
            CqlDate jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.ConvertStringToDate(jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_);
            CqlInterval<CqlDateTime> jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = this.Measurement_Period(context);
            CqlDateTime jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.End(jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_);
            CqlDate jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.DateFrom(jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_);
            CqlInterval<CqlDate> jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Interval(jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_, jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_, true, true);
            CqlInterval<CqlDate> jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Intersect<CqlDate>(jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_, jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_);

            return jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_;
        };
        IEnumerable<CqlInterval<CqlDate>> jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Select<MedicationRequest, CqlInterval<CqlDate>>(izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_, jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_);
        IEnumerable<CqlInterval<CqlDate>> jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Distinct<CqlInterval<CqlDate>>(jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_);
        int? jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = CumulativeMedicationDuration_4_1_000.Instance.cumulativeDuration(context, jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_);

        return jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_;
    }


    [CqlExpressionDefinition(
        definitionName: "Has 90 or More Active Glucocorticoid Medication Days")]
    public bool? Has_90_or_More_Active_Glucocorticoid_Medication_Days(CqlContext context)
    {
        int? jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = this.Glucocorticoid_Active_Medication_Days(context);
        bool? jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.GreaterOrEqual(jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_, 90);

        return jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public IEnumerable<Condition> diagnosisInPatientHistory(CqlContext context, IEnumerable<Condition> Condition)
    {
        bool? jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_(Condition Dx)
        {
            CqlInterval<CqlDateTime> jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = QICoreCommon_2_1_000.Instance.prevalenceInterval(context, Dx);
            CqlDateTime jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Start(jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_);
            CqlInterval<CqlDateTime> kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = this.Measurement_Period(context);
            CqlDateTime kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.End(kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_);
            bool? kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.SameOrBefore(jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_, kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_, "day");

            return kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_;
        };
        IEnumerable<Condition> jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Where<Condition>(Condition, jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_);

        return jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public IEnumerable<Procedure> procedureInPatientHistory(CqlContext context, IEnumerable<Procedure> Procedure)
    {
        IEnumerable<Procedure> kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = Status_1_8_000.Instance.isProcedurePerformed(context, Procedure);
        bool? kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_(Procedure Proc)
        {
            DataType kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = Proc?.Performed;
            object kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = FHIRHelpers_4_4_000.Instance.ToValue(context, kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_);
            CqlInterval<CqlDateTime> kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = QICoreCommon_2_1_000.Instance.toInterval(context, kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_);
            CqlDateTime kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.End(kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_);
            CqlInterval<CqlDateTime> kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = this.Measurement_Period(context);
            CqlDateTime kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.End(kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_);
            bool? kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.SameOrBefore(kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_, kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_, "day");

            return kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_;
        };
        IEnumerable<Procedure> kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Where<Procedure>(kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_, kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_);

        return kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_;
    }


    [CqlExpressionDefinition(
        definitionName: "Has Double or Bilateral Oophorectomy")]
    public bool? Has_Double_or_Bilateral_Oophorectomy(CqlContext context)
    {
        CqlValueSet kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = this.Bilateral_Oophorectomy(context);
        IEnumerable<Procedure> kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
        IEnumerable<Procedure> kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = this.procedureInPatientHistory(context, kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_);
        bool? kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Exists<Procedure>(kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_);
        CqlValueSet kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = this.Evidence_of_Bilateral_Oophorectomy(context);
        IEnumerable<Procedure> kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
        IEnumerable<Procedure> kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = this.procedureInPatientHistory(context, kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_);
        bool? kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Exists<Procedure>(kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_);
        bool? kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Or(kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_, kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_);
        CqlValueSet kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = this.Unilateral_Oophorectomy__Unspecified_Laterality(context);
        IEnumerable<Procedure> kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
        bool? kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_(Procedure UnilateralOophorectomy)
        {
            List<CodeableConcept> lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = UnilateralOophorectomy?.BodySite;
            CqlConcept lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_(CodeableConcept @this)
            {
                CqlConcept lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);

                return lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_;
            };
            IEnumerable<CqlConcept> lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_, lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_);
            bool? lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_(CqlConcept C)
            {
                CqlCode lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = this.Right__qualifier_value_(context);
                CqlConcept lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.ConvertCodeToConcept(lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_);
                bool? lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Equivalent(C, lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_);

                return lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_;
            };
            IEnumerable<CqlConcept> lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Where<CqlConcept>(lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_, lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_);
            bool? lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Exists<CqlConcept>(lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_);

            return lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_;
        };
        IEnumerable<Procedure> kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Where<Procedure>(kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_, kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_);
        CqlValueSet lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = this.Unilateral_Oophorectomy_Right(context);
        IEnumerable<Procedure> lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
        IEnumerable<Procedure> lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Union<Procedure>(kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_, lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_);
        IEnumerable<Procedure> lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = this.procedureInPatientHistory(context, lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_);
        bool? lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.Exists<Procedure>(lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_);
        IEnumerable<Procedure> lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
        bool? lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_(Procedure UnilateralOophorectomy)
        {
            List<CodeableConcept> mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = UnilateralOophorectomy?.BodySite;
            CqlConcept mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_(CodeableConcept @this)
            {
                CqlConcept mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);

                return mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_;
            };
            IEnumerable<CqlConcept> mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_, mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_);
            bool? mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_(CqlConcept D)
            {
                CqlCode mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = this.Left__qualifier_value_(context);
                CqlConcept mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.ConvertCodeToConcept(mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_);
                bool? mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Equivalent(D, mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_);

                return mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_;
            };
            IEnumerable<CqlConcept> mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.Where<CqlConcept>(mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_, mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_);
            bool? mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Exists<CqlConcept>(mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_);

            return mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_;
        };
        IEnumerable<Procedure> lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Where<Procedure>(lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_, lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_);
        CqlValueSet lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = this.Unilateral_Oophorectomy_Left(context);
        IEnumerable<Procedure> lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
        IEnumerable<Procedure> lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Union<Procedure>(lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_, lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_);
        IEnumerable<Procedure> lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = this.procedureInPatientHistory(context, lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_);
        bool? lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Exists<Procedure>(lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_);
        bool? lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.And(lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_, lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_);
        bool? lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Or(kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_, lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_);

        return lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_;
    }


    [CqlExpressionDefinition(
        definitionName: "Has Organ Transplants")]
    public bool? Has_Organ_Transplants(CqlContext context)
    {
        CqlValueSet mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = this.Major_Transplant(context);
        IEnumerable<Procedure> mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
        CqlValueSet mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = this.Kidney_Transplant(context);
        IEnumerable<Procedure> mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
        IEnumerable<Procedure> mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Union<Procedure>(mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_, mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_);
        CqlValueSet mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = this.Bone_Marrow_Transplant(context);
        IEnumerable<Procedure> mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
        IEnumerable<Procedure> mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Union<Procedure>(mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_, mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_);
        IEnumerable<Procedure> mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = this.procedureInPatientHistory(context, mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_);
        bool? mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Exists<Procedure>(mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_);

        return mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_;
    }


    [CqlExpressionDefinition(
        definitionName: "Has Risk Factor Any Time in History or During Measurement Period")]
    public bool? Has_Risk_Factor_Any_Time_in_History_or_During_Measurement_Period(CqlContext context)
    {
        bool? mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = this.Has_90_or_More_Active_Glucocorticoid_Medication_Days(context);
        CqlValueSet mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = this.Osteoporosis_With_Current_Fracture(context);
        IEnumerable<Condition> mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        CqlValueSet mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = this.Malabsorption_Syndromes(context);
        IEnumerable<Condition> mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        IEnumerable<Condition> mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Union<Condition>(mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_, mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_);
        CqlValueSet nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = this.Chronic_Malnutrition(context);
        IEnumerable<Condition> nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        CqlValueSet nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = this.Chronic_Liver_Disease(context);
        IEnumerable<Condition> nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        IEnumerable<Condition> nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.Union<Condition>(nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_, nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_);
        IEnumerable<Condition> nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Union<Condition>(mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_, nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_);
        CqlValueSet nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = this.Rheumatoid_Arthritis(context);
        IEnumerable<Condition> nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        CqlValueSet nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = this.Hyperthyroidism(context);
        IEnumerable<Condition> nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        IEnumerable<Condition> nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Union<Condition>(nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_, nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_);
        IEnumerable<Condition> nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Union<Condition>(nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_, nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_);
        CqlValueSet nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = this.Type_1_Diabetes(context);
        IEnumerable<Condition> nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        CqlValueSet nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = this.End_Stage_Renal_Disease(context);
        IEnumerable<Condition> nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        IEnumerable<Condition> nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Union<Condition>(nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_, nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_);
        IEnumerable<Condition> nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Union<Condition>(nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_, nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_);
        CqlValueSet nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = this.Osteogenesis_Imperfecta(context);
        IEnumerable<Condition> nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        CqlValueSet nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = this.Ankylosing_Spondylitis(context);
        IEnumerable<Condition> nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        IEnumerable<Condition> nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Union<Condition>(nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_, nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_);
        IEnumerable<Condition> nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Union<Condition>(nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_, nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_);
        CqlValueSet nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = this.Psoriatic_Arthritis(context);
        IEnumerable<Condition> nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        CqlValueSet ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = this.Ehlers_Danlos_Syndrome(context);
        IEnumerable<Condition> ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        IEnumerable<Condition> ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Union<Condition>(nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_, ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_);
        IEnumerable<Condition> ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Union<Condition>(nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_, ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_);
        CqlValueSet ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = this.Cushings_Syndrome(context);
        IEnumerable<Condition> ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        CqlValueSet ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = this.Hyperparathyroidism(context);
        IEnumerable<Condition> ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        IEnumerable<Condition> ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Union<Condition>(ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_, ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_);
        IEnumerable<Condition> ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Union<Condition>(ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_, ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_);
        CqlValueSet ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = this.Marfans_Syndrome(context);
        IEnumerable<Condition> ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        CqlValueSet ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = this.Lupus(context);
        IEnumerable<Condition> ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        IEnumerable<Condition> ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Union<Condition>(ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_, ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_);
        IEnumerable<Condition> ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Union<Condition>(ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_, ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_);
        CqlValueSet ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = this.Multiple_Myeloma(context);
        IEnumerable<Condition> ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        CqlValueSet ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = this.Premature_Menopause(context);
        IEnumerable<Condition> ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        IEnumerable<Condition> ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Union<Condition>(ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_, ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_);
        IEnumerable<Condition> ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Union<Condition>(ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_, ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_);
        CqlValueSet ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = this.Eating_Disorders(context);
        IEnumerable<Condition> ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        CqlValueSet ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = this.Amenorrhea(context);
        IEnumerable<Condition> ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        IEnumerable<Condition> pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.Union<Condition>(ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_, ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_);
        IEnumerable<Condition> pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Union<Condition>(ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_, pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_);
        IEnumerable<Condition> pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = this.diagnosisInPatientHistory(context, pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_);
        bool? pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Exists<Condition>(pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_);
        bool? pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.Or(mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_, pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_);
        CqlValueSet pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = this.Chemotherapy(context);
        IEnumerable<Procedure> pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
        IEnumerable<Procedure> pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = this.procedureInPatientHistory(context, pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_);
        bool? pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Exists<Procedure>(pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_);
        bool? pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Or(pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_, pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_);
        bool? pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = this.Has_Double_or_Bilateral_Oophorectomy(context);
        bool? pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Or(pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_, pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_);
        bool? pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = this.Has_Organ_Transplants(context);
        bool? pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Or(pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_, pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_);

        return pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_;
    }


    [CqlExpressionDefinition(
        definitionName: "Denominator Exclusions")]
    public bool? Denominator_Exclusions(CqlContext context)
    {
        bool? pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = this.Has_Risk_Factor_Active_During_the_Measurement_Period(context);
        bool? pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = this.Has_Risk_Factor_Any_Time_in_History_Prior_to_Measurement_Period(context);
        bool? pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Or(pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_, pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_);
        bool? pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = this.Has_Risk_Factor_Any_Time_in_History_or_During_Measurement_Period(context);
        bool? pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Or(pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_, pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_);

        return pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_;
    }


    [CqlExpressionDefinition(
        definitionName: "DXA Scan Order During Measurement Period")]
    public IEnumerable<ServiceRequest> DXA_Scan_Order_During_Measurement_Period(CqlContext context)
    {
        CqlValueSet pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = this.DXA__Dual_energy_Xray_Absorptiometry__Scan(context);
        IEnumerable<ServiceRequest> pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Retrieve<ServiceRequest>(new RetrieveParameters(default, pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-servicerequest"));
        IEnumerable<ServiceRequest> pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = Status_1_8_000.Instance.isDiagnosticStudyOrder(context, pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_);
        bool? pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_(ServiceRequest DXA)
        {
            CqlInterval<CqlDateTime> qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = this.Measurement_Period(context);
            FhirDateTime qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = DXA?.AuthoredOnElement;
            CqlDateTime qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Convert<CqlDateTime>(qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_);
            CqlInterval<CqlDateTime> qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = QICoreCommon_2_1_000.Instance.toInterval(context, qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ as object);
            bool? qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_, qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_, default);

            return qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_;
        };
        IEnumerable<ServiceRequest> pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Where<ServiceRequest>(pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_, pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_);
        object pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_(ServiceRequest @this)
        {
            FhirDateTime qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = @this?.AuthoredOnElement;
            CqlDateTime qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Convert<CqlDateTime>(qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_);

            return qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_;
        };
        IEnumerable<ServiceRequest> pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.SortBy<ServiceRequest>(pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_, pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_, System.ComponentModel.ListSortDirection.Ascending);

        return pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_;
    }


    [CqlExpressionDefinition(
        definitionName: "Numerator")]
    public bool? Numerator(CqlContext context)
    {
        IEnumerable<ServiceRequest> qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = this.DXA_Scan_Order_During_Measurement_Period(context);
        bool? qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Exists<ServiceRequest>(qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_);

        return qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_;
    }


    [CqlExpressionDefinition(
        definitionName: "Osteoporosis Fracture Risk Assessment Prior to First DXA Scan")]
    public IEnumerable<Observation> Osteoporosis_Fracture_Risk_Assessment_Prior_to_First_DXA_Scan(CqlContext context)
    {
        CqlCode qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = this.Major_osteoporotic_fracture_10_year_probability__Likelihood__Fracture_Risk_Assessment(context);
        IEnumerable<CqlCode> qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.ToList<CqlCode>(qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_);
        IEnumerable<Observation> qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
        IEnumerable<Observation> qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = Status_1_8_000.Instance.isAssessmentPerformed(context, qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_);
        bool? qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_(Observation FRAX)
        {
            DataType rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = FRAX?.Value;
            object rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = FHIRHelpers_4_4_000.Instance.ToValue(context, rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_);
            CqlQuantity rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Quantity(8.4m, "%");
            bool? rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.GreaterOrEqual(rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ as CqlQuantity, rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_);

            return rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_;
        };
        IEnumerable<Observation> qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Where<Observation>(qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_, qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_);
        CqlCode qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = this.Osteoporosis_Risk_Assessment_Instrument(context);
        IEnumerable<CqlCode> qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.ToList<CqlCode>(qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_);
        IEnumerable<Observation> qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
        IEnumerable<Observation> qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = Status_1_8_000.Instance.isAssessmentPerformed(context, qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_);
        bool? qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_(Observation ORAI)
        {
            DataType rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = ORAI?.Value;
            object rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = FHIRHelpers_4_4_000.Instance.ToValue(context, rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_);
            bool? rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.GreaterOrEqual(rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ as int?, 9);

            return rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_;
        };
        IEnumerable<Observation> qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Where<Observation>(qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_, qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_);
        IEnumerable<Observation> qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Union<Observation>(qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_, qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_);
        CqlCode qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = this.Osteoporosis_Index_of_Risk_panel(context);
        IEnumerable<CqlCode> qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.ToList<CqlCode>(qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_);
        IEnumerable<Observation> qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
        IEnumerable<Observation> qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = Status_1_8_000.Instance.isAssessmentPerformed(context, qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_);
        bool? rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_(Observation OSIRIS)
        {
            DataType rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = OSIRIS?.Value;
            object rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = FHIRHelpers_4_4_000.Instance.ToValue(context, rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_);
            CqlQuantity rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.ConvertDecimalToQuantity(1.0m);
            bool? rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Less(rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ as CqlQuantity, rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_);

            return rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_;
        };
        IEnumerable<Observation> rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Where<Observation>(qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_, rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_);
        CqlCode rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = this.Osteoporosis_Self_Assessment_Tool(context);
        IEnumerable<CqlCode> rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.ToList<CqlCode>(rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_);
        IEnumerable<Observation> rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
        IEnumerable<Observation> rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = Status_1_8_000.Instance.isAssessmentPerformed(context, rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_);
        bool? rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_(Observation OST)
        {
            DataType rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = OST?.Value;
            object rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = FHIRHelpers_4_4_000.Instance.ToValue(context, rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_);
            CqlQuantity rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.ConvertDecimalToQuantity(2.0m);
            bool? szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.Less(rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ as CqlQuantity, rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_);

            return szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_;
        };
        IEnumerable<Observation> rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Where<Observation>(rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_, rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_);
        IEnumerable<Observation> rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Union<Observation>(rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_, rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_);
        IEnumerable<Observation> rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Union<Observation>(qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_, rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_);
        bool? rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_(Observation RiskAssessment)
        {
            DataType szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = RiskAssessment?.Effective;
            object szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = FHIRHelpers_4_4_000.Instance.ToValue(context, szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_);
            CqlInterval<CqlDateTime> szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = QICoreCommon_2_1_000.Instance.toInterval(context, szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_);
            CqlDateTime szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.Start(szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_);
            IEnumerable<ServiceRequest> szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = this.DXA_Scan_Order_During_Measurement_Period(context);
            ServiceRequest szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.First<ServiceRequest>(szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_);
            FhirDateTime szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_?.AuthoredOnElement;
            CqlDateTime szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Convert<CqlDateTime>(szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_);
            bool? szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Before(szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_, szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_, default);

            return szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_;
        };
        IEnumerable<Observation> rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Where<Observation>(rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_, rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_);

        return rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_;
    }


    [CqlExpressionDefinition(
        definitionName: "Numerator Exclusion")]
    public bool? Numerator_Exclusion(CqlContext context)
    {
        IEnumerable<Observation> szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = this.Osteoporosis_Fracture_Risk_Assessment_Prior_to_First_DXA_Scan(context);
        bool? szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Exists<Observation>(szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_);

        return szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_;
    }


    #endregion Expressions

}

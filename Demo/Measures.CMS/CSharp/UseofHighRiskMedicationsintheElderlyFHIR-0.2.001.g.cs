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
[CqlLibrary("UseofHighRiskMedicationsintheElderlyFHIR", "0.2.001")]
public partial class UseofHighRiskMedicationsintheElderlyFHIR_0_2_001 : ILibrary, ISingleton<UseofHighRiskMedicationsintheElderlyFHIR_0_2_001>
{
    private UseofHighRiskMedicationsintheElderlyFHIR_0_2_001() {}

    public static UseofHighRiskMedicationsintheElderlyFHIR_0_2_001 Instance { get; } = new();

    #region ILibrary Implementation

    public string Name => "UseofHighRiskMedicationsintheElderlyFHIR";
    public string Version => "0.2.001";
    public ILibrary[] Dependencies => [FHIRHelpers_4_4_000.Instance, SupplementalDataElements_3_5_000.Instance, CQMCommon_2_2_000.Instance, Hospice_6_12_000.Instance, PalliativeCare_1_11_000.Instance, CumulativeMedicationDuration_4_1_000.Instance, QICoreCommon_2_1_000.Instance, Status_1_8_000.Instance];

    #endregion ILibrary Implementation

    #region ValueSets

    #region ValueSet: Alcohol Withdrawal
    [CqlValueSetDefinition(
        definitionName: "Alcohol Withdrawal",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.105.12.1209",
        valueSetVersion: null)]
    public CqlValueSet Alcohol_Withdrawal(CqlContext context) => _Alcohol_Withdrawal;

    private static readonly CqlValueSet _Alcohol_Withdrawal = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.105.12.1209", null);
    #endregion

    #region ValueSet: Annual Wellness Visit
    [CqlValueSetDefinition(
        definitionName: "Annual Wellness Visit",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1240",
        valueSetVersion: null)]
    public CqlValueSet Annual_Wellness_Visit(CqlContext context) => _Annual_Wellness_Visit;

    private static readonly CqlValueSet _Annual_Wellness_Visit = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1240", null);
    #endregion

    #region ValueSet: Benzodiazepine Withdrawal
    [CqlValueSetDefinition(
        definitionName: "Benzodiazepine Withdrawal",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.105.12.1208",
        valueSetVersion: null)]
    public CqlValueSet Benzodiazepine_Withdrawal(CqlContext context) => _Benzodiazepine_Withdrawal;

    private static readonly CqlValueSet _Benzodiazepine_Withdrawal = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.105.12.1208", null);
    #endregion

    #region ValueSet: Bipolar Disorder
    [CqlValueSetDefinition(
        definitionName: "Bipolar Disorder",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.67.1.101.1.128",
        valueSetVersion: null)]
    public CqlValueSet Bipolar_Disorder(CqlContext context) => _Bipolar_Disorder;

    private static readonly CqlValueSet _Bipolar_Disorder = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.67.1.101.1.128", null);
    #endregion

    #region ValueSet: Care Services in Long Term Residential Facility
    [CqlValueSetDefinition(
        definitionName: "Care Services in Long Term Residential Facility",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1014",
        valueSetVersion: null)]
    public CqlValueSet Care_Services_in_Long_Term_Residential_Facility(CqlContext context) => _Care_Services_in_Long_Term_Residential_Facility;

    private static readonly CqlValueSet _Care_Services_in_Long_Term_Residential_Facility = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1014", null);
    #endregion

    #region ValueSet: Desiccated Thyroid Medications
    [CqlValueSetDefinition(
        definitionName: "Desiccated Thyroid Medications",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.1060",
        valueSetVersion: null)]
    public CqlValueSet Desiccated_Thyroid_Medications(CqlContext context) => _Desiccated_Thyroid_Medications;

    private static readonly CqlValueSet _Desiccated_Thyroid_Medications = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.1060", null);
    #endregion

    #region ValueSet: Digoxin Medications
    [CqlValueSetDefinition(
        definitionName: "Digoxin Medications",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.1065",
        valueSetVersion: null)]
    public CqlValueSet Digoxin_Medications(CqlContext context) => _Digoxin_Medications;

    private static readonly CqlValueSet _Digoxin_Medications = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.1065", null);
    #endregion

    #region ValueSet: Dipyridamole Medications
    [CqlValueSetDefinition(
        definitionName: "Dipyridamole Medications",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.1051",
        valueSetVersion: null)]
    public CqlValueSet Dipyridamole_Medications(CqlContext context) => _Dipyridamole_Medications;

    private static readonly CqlValueSet _Dipyridamole_Medications = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.1051", null);
    #endregion

    #region ValueSet: Discharge Services Nursing Facility
    [CqlValueSetDefinition(
        definitionName: "Discharge Services Nursing Facility",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1013",
        valueSetVersion: null)]
    public CqlValueSet Discharge_Services_Nursing_Facility(CqlContext context) => _Discharge_Services_Nursing_Facility;

    private static readonly CqlValueSet _Discharge_Services_Nursing_Facility = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1013", null);
    #endregion

    #region ValueSet: Doxepin Medications
    [CqlValueSetDefinition(
        definitionName: "Doxepin Medications",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.1067",
        valueSetVersion: null)]
    public CqlValueSet Doxepin_Medications(CqlContext context) => _Doxepin_Medications;

    private static readonly CqlValueSet _Doxepin_Medications = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.1067", null);
    #endregion

    #region ValueSet: Generalized Anxiety Disorder
    [CqlValueSetDefinition(
        definitionName: "Generalized Anxiety Disorder",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.105.12.1210",
        valueSetVersion: null)]
    public CqlValueSet Generalized_Anxiety_Disorder(CqlContext context) => _Generalized_Anxiety_Disorder;

    private static readonly CqlValueSet _Generalized_Anxiety_Disorder = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.105.12.1210", null);
    #endregion

    #region ValueSet: Guanfacine Medications
    [CqlValueSetDefinition(
        definitionName: "Guanfacine Medications",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.196.11.1252",
        valueSetVersion: null)]
    public CqlValueSet Guanfacine_Medications(CqlContext context) => _Guanfacine_Medications;

    private static readonly CqlValueSet _Guanfacine_Medications = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.196.11.1252", null);
    #endregion

    #region ValueSet: Home Healthcare Services
    [CqlValueSetDefinition(
        definitionName: "Home Healthcare Services",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1016",
        valueSetVersion: null)]
    public CqlValueSet Home_Healthcare_Services(CqlContext context) => _Home_Healthcare_Services;

    private static readonly CqlValueSet _Home_Healthcare_Services = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1016", null);
    #endregion

    #region ValueSet: Megestrol Medications
    [CqlValueSetDefinition(
        definitionName: "Megestrol Medications",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.1247",
        valueSetVersion: null)]
    public CqlValueSet Megestrol_Medications(CqlContext context) => _Megestrol_Medications;

    private static readonly CqlValueSet _Megestrol_Medications = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.1247", null);
    #endregion

    #region ValueSet: Meperidine Medications
    [CqlValueSetDefinition(
        definitionName: "Meperidine Medications",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.1248",
        valueSetVersion: null)]
    public CqlValueSet Meperidine_Medications(CqlContext context) => _Meperidine_Medications;

    private static readonly CqlValueSet _Meperidine_Medications = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.1248", null);
    #endregion

    #region ValueSet: Meprobamate Medications
    [CqlValueSetDefinition(
        definitionName: "Meprobamate Medications",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.1057",
        valueSetVersion: null)]
    public CqlValueSet Meprobamate_Medications(CqlContext context) => _Meprobamate_Medications;

    private static readonly CqlValueSet _Meprobamate_Medications = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.1057", null);
    #endregion

    #region ValueSet: Nifedipine Medications
    [CqlValueSetDefinition(
        definitionName: "Nifedipine Medications",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.1053",
        valueSetVersion: null)]
    public CqlValueSet Nifedipine_Medications(CqlContext context) => _Nifedipine_Medications;

    private static readonly CqlValueSet _Nifedipine_Medications = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.1053", null);
    #endregion

    #region ValueSet: Nursing Facility Visit
    [CqlValueSetDefinition(
        definitionName: "Nursing Facility Visit",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1012",
        valueSetVersion: null)]
    public CqlValueSet Nursing_Facility_Visit(CqlContext context) => _Nursing_Facility_Visit;

    private static readonly CqlValueSet _Nursing_Facility_Visit = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1012", null);
    #endregion

    #region ValueSet: Office Visit
    [CqlValueSetDefinition(
        definitionName: "Office Visit",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1001",
        valueSetVersion: null)]
    public CqlValueSet Office_Visit(CqlContext context) => _Office_Visit;

    private static readonly CqlValueSet _Office_Visit = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1001", null);
    #endregion

    #region ValueSet: Ophthalmological Services
    [CqlValueSetDefinition(
        definitionName: "Ophthalmological Services",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1285",
        valueSetVersion: null)]
    public CqlValueSet Ophthalmological_Services(CqlContext context) => _Ophthalmological_Services;

    private static readonly CqlValueSet _Ophthalmological_Services = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1285", null);
    #endregion

    #region ValueSet: Potentially Harmful Antidepressants for Older Adults
    [CqlValueSetDefinition(
        definitionName: "Potentially Harmful Antidepressants for Older Adults",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.1054",
        valueSetVersion: null)]
    public CqlValueSet Potentially_Harmful_Antidepressants_for_Older_Adults(CqlContext context) => _Potentially_Harmful_Antidepressants_for_Older_Adults;

    private static readonly CqlValueSet _Potentially_Harmful_Antidepressants_for_Older_Adults = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.1054", null);
    #endregion

    #region ValueSet: Potentially Harmful Antihistamines for Older Adults
    [CqlValueSetDefinition(
        definitionName: "Potentially Harmful Antihistamines for Older Adults",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.1043",
        valueSetVersion: null)]
    public CqlValueSet Potentially_Harmful_Antihistamines_for_Older_Adults(CqlContext context) => _Potentially_Harmful_Antihistamines_for_Older_Adults;

    private static readonly CqlValueSet _Potentially_Harmful_Antihistamines_for_Older_Adults = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.1043", null);
    #endregion

    #region ValueSet: Potentially Harmful Antiinfectives for Older Adults
    [CqlValueSetDefinition(
        definitionName: "Potentially Harmful Antiinfectives for Older Adults",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.196.12.1481",
        valueSetVersion: null)]
    public CqlValueSet Potentially_Harmful_Antiinfectives_for_Older_Adults(CqlContext context) => _Potentially_Harmful_Antiinfectives_for_Older_Adults;

    private static readonly CqlValueSet _Potentially_Harmful_Antiinfectives_for_Older_Adults = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.196.12.1481", null);
    #endregion

    #region ValueSet: Potentially Harmful Antiparkinsonian Agents for Older Adults
    [CqlValueSetDefinition(
        definitionName: "Potentially Harmful Antiparkinsonian Agents for Older Adults",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.1049",
        valueSetVersion: null)]
    public CqlValueSet Potentially_Harmful_Antiparkinsonian_Agents_for_Older_Adults(CqlContext context) => _Potentially_Harmful_Antiparkinsonian_Agents_for_Older_Adults;

    private static readonly CqlValueSet _Potentially_Harmful_Antiparkinsonian_Agents_for_Older_Adults = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.1049", null);
    #endregion

    #region ValueSet: Potentially Harmful Antipsychotics for Older Adults
    [CqlValueSetDefinition(
        definitionName: "Potentially Harmful Antipsychotics for Older Adults",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.196.12.1523",
        valueSetVersion: null)]
    public CqlValueSet Potentially_Harmful_Antipsychotics_for_Older_Adults(CqlContext context) => _Potentially_Harmful_Antipsychotics_for_Older_Adults;

    private static readonly CqlValueSet _Potentially_Harmful_Antipsychotics_for_Older_Adults = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.196.12.1523", null);
    #endregion

    #region ValueSet: Potentially Harmful Barbiturates for Older Adults
    [CqlValueSetDefinition(
        definitionName: "Potentially Harmful Barbiturates for Older Adults",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.1055",
        valueSetVersion: null)]
    public CqlValueSet Potentially_Harmful_Barbiturates_for_Older_Adults(CqlContext context) => _Potentially_Harmful_Barbiturates_for_Older_Adults;

    private static readonly CqlValueSet _Potentially_Harmful_Barbiturates_for_Older_Adults = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.1055", null);
    #endregion

    #region ValueSet: Potentially Harmful Benzodiazepines for Older Adults
    [CqlValueSetDefinition(
        definitionName: "Potentially Harmful Benzodiazepines for Older Adults",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.196.12.1522",
        valueSetVersion: null)]
    public CqlValueSet Potentially_Harmful_Benzodiazepines_for_Older_Adults(CqlContext context) => _Potentially_Harmful_Benzodiazepines_for_Older_Adults;

    private static readonly CqlValueSet _Potentially_Harmful_Benzodiazepines_for_Older_Adults = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.196.12.1522", null);
    #endregion

    #region ValueSet: Potentially Harmful Estrogens for Older Adults
    [CqlValueSetDefinition(
        definitionName: "Potentially Harmful Estrogens for Older Adults",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.1058",
        valueSetVersion: null)]
    public CqlValueSet Potentially_Harmful_Estrogens_for_Older_Adults(CqlContext context) => _Potentially_Harmful_Estrogens_for_Older_Adults;

    private static readonly CqlValueSet _Potentially_Harmful_Estrogens_for_Older_Adults = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.1058", null);
    #endregion

    #region ValueSet: Potentially Harmful Gastrointestinal Antispasmodics for Older Adults
    [CqlValueSetDefinition(
        definitionName: "Potentially Harmful Gastrointestinal Antispasmodics for Older Adults",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.1050",
        valueSetVersion: null)]
    public CqlValueSet Potentially_Harmful_Gastrointestinal_Antispasmodics_for_Older_Adults(CqlContext context) => _Potentially_Harmful_Gastrointestinal_Antispasmodics_for_Older_Adults;

    private static readonly CqlValueSet _Potentially_Harmful_Gastrointestinal_Antispasmodics_for_Older_Adults = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.1050", null);
    #endregion

    #region ValueSet: Potentially Harmful Nonbenzodiazepine Hypnotics for Older Adults
    [CqlValueSetDefinition(
        definitionName: "Potentially Harmful Nonbenzodiazepine Hypnotics for Older Adults",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.196.12.1480",
        valueSetVersion: null)]
    public CqlValueSet Potentially_Harmful_Nonbenzodiazepine_Hypnotics_for_Older_Adults(CqlContext context) => _Potentially_Harmful_Nonbenzodiazepine_Hypnotics_for_Older_Adults;

    private static readonly CqlValueSet _Potentially_Harmful_Nonbenzodiazepine_Hypnotics_for_Older_Adults = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.196.12.1480", null);
    #endregion

    #region ValueSet: Potentially Harmful Pain Medications for Older Adults
    [CqlValueSetDefinition(
        definitionName: "Potentially Harmful Pain Medications for Older Adults",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.1063",
        valueSetVersion: null)]
    public CqlValueSet Potentially_Harmful_Pain_Medications_for_Older_Adults(CqlContext context) => _Potentially_Harmful_Pain_Medications_for_Older_Adults;

    private static readonly CqlValueSet _Potentially_Harmful_Pain_Medications_for_Older_Adults = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.1063", null);
    #endregion

    #region ValueSet: Potentially Harmful Skeletal Muscle Relaxants for Older Adults
    [CqlValueSetDefinition(
        definitionName: "Potentially Harmful Skeletal Muscle Relaxants for Older Adults",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.1062",
        valueSetVersion: null)]
    public CqlValueSet Potentially_Harmful_Skeletal_Muscle_Relaxants_for_Older_Adults(CqlContext context) => _Potentially_Harmful_Skeletal_Muscle_Relaxants_for_Older_Adults;

    private static readonly CqlValueSet _Potentially_Harmful_Skeletal_Muscle_Relaxants_for_Older_Adults = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.1062", null);
    #endregion

    #region ValueSet: Potentially Harmful Sulfonylureas for Older Adults
    [CqlValueSetDefinition(
        definitionName: "Potentially Harmful Sulfonylureas for Older Adults",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.1059",
        valueSetVersion: null)]
    public CqlValueSet Potentially_Harmful_Sulfonylureas_for_Older_Adults(CqlContext context) => _Potentially_Harmful_Sulfonylureas_for_Older_Adults;

    private static readonly CqlValueSet _Potentially_Harmful_Sulfonylureas_for_Older_Adults = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.1059", null);
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

    #region ValueSet: REM Sleep Behavior Disorder
    [CqlValueSetDefinition(
        definitionName: "REM Sleep Behavior Disorder",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.105.12.1207",
        valueSetVersion: null)]
    public CqlValueSet REM_Sleep_Behavior_Disorder(CqlContext context) => _REM_Sleep_Behavior_Disorder;

    private static readonly CqlValueSet _REM_Sleep_Behavior_Disorder = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.105.12.1207", null);
    #endregion

    #region ValueSet: Schizophrenia
    [CqlValueSetDefinition(
        definitionName: "Schizophrenia",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.105.12.1205",
        valueSetVersion: null)]
    public CqlValueSet Schizophrenia(CqlContext context) => _Schizophrenia;

    private static readonly CqlValueSet _Schizophrenia = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.105.12.1205", null);
    #endregion

    #region ValueSet: Seizure Disorder
    [CqlValueSetDefinition(
        definitionName: "Seizure Disorder",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.105.12.1206",
        valueSetVersion: null)]
    public CqlValueSet Seizure_Disorder(CqlContext context) => _Seizure_Disorder;

    private static readonly CqlValueSet _Seizure_Disorder = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.105.12.1206", null);
    #endregion

    #region ValueSet: Telephone Visits
    [CqlValueSetDefinition(
        definitionName: "Telephone Visits",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1080",
        valueSetVersion: null)]
    public CqlValueSet Telephone_Visits(CqlContext context) => _Telephone_Visits;

    private static readonly CqlValueSet _Telephone_Visits = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1080", null);
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

    #region Code: 1 ML digoxin 0.1 MG/ML Injection
    [CqlCodeDefinition(
        definitionName: "1 ML digoxin 0.1 MG/ML Injection",
        codeId: "204504",
        codeSystem: "http://www.nlm.nih.gov/research/umls/rxnorm")]
    public CqlCode _1_ML_digoxin_0_1_MG_ML_Injection(CqlContext context) => __1_ML_digoxin_0_1_MG_ML_Injection;

    private static readonly CqlCode __1_ML_digoxin_0_1_MG_ML_Injection = new CqlCode("204504", "http://www.nlm.nih.gov/research/umls/rxnorm", default, default);
    #endregion

    #region Code: 2 ML digoxin 0.25 MG/ML Injection
    [CqlCodeDefinition(
        definitionName: "2 ML digoxin 0.25 MG/ML Injection",
        codeId: "104208",
        codeSystem: "http://www.nlm.nih.gov/research/umls/rxnorm")]
    public CqlCode _2_ML_digoxin_0_25_MG_ML_Injection(CqlContext context) => __2_ML_digoxin_0_25_MG_ML_Injection;

    private static readonly CqlCode __2_ML_digoxin_0_25_MG_ML_Injection = new CqlCode("104208", "http://www.nlm.nih.gov/research/umls/rxnorm", default, default);
    #endregion

    #region Code: digoxin 0.05 MG/ML Oral Solution
    [CqlCodeDefinition(
        definitionName: "digoxin 0.05 MG/ML Oral Solution",
        codeId: "393245",
        codeSystem: "http://www.nlm.nih.gov/research/umls/rxnorm")]
    public CqlCode digoxin_0_05_MG_ML_Oral_Solution(CqlContext context) => _digoxin_0_05_MG_ML_Oral_Solution;

    private static readonly CqlCode _digoxin_0_05_MG_ML_Oral_Solution = new CqlCode("393245", "http://www.nlm.nih.gov/research/umls/rxnorm", default, default);
    #endregion

    #region Code: digoxin 0.0625 MG Oral Tablet
    [CqlCodeDefinition(
        definitionName: "digoxin 0.0625 MG Oral Tablet",
        codeId: "245273",
        codeSystem: "http://www.nlm.nih.gov/research/umls/rxnorm")]
    public CqlCode digoxin_0_0625_MG_Oral_Tablet(CqlContext context) => _digoxin_0_0625_MG_Oral_Tablet;

    private static readonly CqlCode _digoxin_0_0625_MG_Oral_Tablet = new CqlCode("245273", "http://www.nlm.nih.gov/research/umls/rxnorm", default, default);
    #endregion

    #region Code: digoxin 0.125 MG Oral Tablet
    [CqlCodeDefinition(
        definitionName: "digoxin 0.125 MG Oral Tablet",
        codeId: "197604",
        codeSystem: "http://www.nlm.nih.gov/research/umls/rxnorm")]
    public CqlCode digoxin_0_125_MG_Oral_Tablet(CqlContext context) => _digoxin_0_125_MG_Oral_Tablet;

    private static readonly CqlCode _digoxin_0_125_MG_Oral_Tablet = new CqlCode("197604", "http://www.nlm.nih.gov/research/umls/rxnorm", default, default);
    #endregion

    #region Code: digoxin 0.25 MG Oral Tablet
    [CqlCodeDefinition(
        definitionName: "digoxin 0.25 MG Oral Tablet",
        codeId: "197606",
        codeSystem: "http://www.nlm.nih.gov/research/umls/rxnorm")]
    public CqlCode digoxin_0_25_MG_Oral_Tablet(CqlContext context) => _digoxin_0_25_MG_Oral_Tablet;

    private static readonly CqlCode _digoxin_0_25_MG_Oral_Tablet = new CqlCode("197606", "http://www.nlm.nih.gov/research/umls/rxnorm", default, default);
    #endregion

    #region Code: doxepin 10 MG Oral Capsule
    [CqlCodeDefinition(
        definitionName: "doxepin 10 MG Oral Capsule",
        codeId: "1000048",
        codeSystem: "http://www.nlm.nih.gov/research/umls/rxnorm")]
    public CqlCode doxepin_10_MG_Oral_Capsule(CqlContext context) => _doxepin_10_MG_Oral_Capsule;

    private static readonly CqlCode _doxepin_10_MG_Oral_Capsule = new CqlCode("1000048", "http://www.nlm.nih.gov/research/umls/rxnorm", default, default);
    #endregion

    #region Code: doxepin 10 MG/ML Oral Solution
    [CqlCodeDefinition(
        definitionName: "doxepin 10 MG/ML Oral Solution",
        codeId: "1000054",
        codeSystem: "http://www.nlm.nih.gov/research/umls/rxnorm")]
    public CqlCode doxepin_10_MG_ML_Oral_Solution(CqlContext context) => _doxepin_10_MG_ML_Oral_Solution;

    private static readonly CqlCode _doxepin_10_MG_ML_Oral_Solution = new CqlCode("1000054", "http://www.nlm.nih.gov/research/umls/rxnorm", default, default);
    #endregion

    #region Code: doxepin 100 MG Oral Capsule
    [CqlCodeDefinition(
        definitionName: "doxepin 100 MG Oral Capsule",
        codeId: "1000058",
        codeSystem: "http://www.nlm.nih.gov/research/umls/rxnorm")]
    public CqlCode doxepin_100_MG_Oral_Capsule(CqlContext context) => _doxepin_100_MG_Oral_Capsule;

    private static readonly CqlCode _doxepin_100_MG_Oral_Capsule = new CqlCode("1000058", "http://www.nlm.nih.gov/research/umls/rxnorm", default, default);
    #endregion

    #region Code: doxepin 150 MG Oral Capsule
    [CqlCodeDefinition(
        definitionName: "doxepin 150 MG Oral Capsule",
        codeId: "1000064",
        codeSystem: "http://www.nlm.nih.gov/research/umls/rxnorm")]
    public CqlCode doxepin_150_MG_Oral_Capsule(CqlContext context) => _doxepin_150_MG_Oral_Capsule;

    private static readonly CqlCode _doxepin_150_MG_Oral_Capsule = new CqlCode("1000064", "http://www.nlm.nih.gov/research/umls/rxnorm", default, default);
    #endregion

    #region Code: doxepin 25 MG Oral Capsule
    [CqlCodeDefinition(
        definitionName: "doxepin 25 MG Oral Capsule",
        codeId: "1000070",
        codeSystem: "http://www.nlm.nih.gov/research/umls/rxnorm")]
    public CqlCode doxepin_25_MG_Oral_Capsule(CqlContext context) => _doxepin_25_MG_Oral_Capsule;

    private static readonly CqlCode _doxepin_25_MG_Oral_Capsule = new CqlCode("1000070", "http://www.nlm.nih.gov/research/umls/rxnorm", default, default);
    #endregion

    #region Code: doxepin 3 MG Oral Tablet
    [CqlCodeDefinition(
        definitionName: "doxepin 3 MG Oral Tablet",
        codeId: "966787",
        codeSystem: "http://www.nlm.nih.gov/research/umls/rxnorm")]
    public CqlCode doxepin_3_MG_Oral_Tablet(CqlContext context) => _doxepin_3_MG_Oral_Tablet;

    private static readonly CqlCode _doxepin_3_MG_Oral_Tablet = new CqlCode("966787", "http://www.nlm.nih.gov/research/umls/rxnorm", default, default);
    #endregion

    #region Code: doxepin 50 MG Oral Capsule
    [CqlCodeDefinition(
        definitionName: "doxepin 50 MG Oral Capsule",
        codeId: "1000076",
        codeSystem: "http://www.nlm.nih.gov/research/umls/rxnorm")]
    public CqlCode doxepin_50_MG_Oral_Capsule(CqlContext context) => _doxepin_50_MG_Oral_Capsule;

    private static readonly CqlCode _doxepin_50_MG_Oral_Capsule = new CqlCode("1000076", "http://www.nlm.nih.gov/research/umls/rxnorm", default, default);
    #endregion

    #region Code: doxepin 6 MG Oral Tablet
    [CqlCodeDefinition(
        definitionName: "doxepin 6 MG Oral Tablet",
        codeId: "966793",
        codeSystem: "http://www.nlm.nih.gov/research/umls/rxnorm")]
    public CqlCode doxepin_6_MG_Oral_Tablet(CqlContext context) => _doxepin_6_MG_Oral_Tablet;

    private static readonly CqlCode _doxepin_6_MG_Oral_Tablet = new CqlCode("966793", "http://www.nlm.nih.gov/research/umls/rxnorm", default, default);
    #endregion

    #region Code: doxepin 75 MG Oral Capsule
    [CqlCodeDefinition(
        definitionName: "doxepin 75 MG Oral Capsule",
        codeId: "1000097",
        codeSystem: "http://www.nlm.nih.gov/research/umls/rxnorm")]
    public CqlCode doxepin_75_MG_Oral_Capsule(CqlContext context) => _doxepin_75_MG_Oral_Capsule;

    private static readonly CqlCode _doxepin_75_MG_Oral_Capsule = new CqlCode("1000097", "http://www.nlm.nih.gov/research/umls/rxnorm", default, default);
    #endregion

    #region Code: ergoloid mesylates, USP 1 MG Oral Tablet
    [CqlCodeDefinition(
        definitionName: "ergoloid mesylates, USP 1 MG Oral Tablet",
        codeId: "318179",
        codeSystem: "http://www.nlm.nih.gov/research/umls/rxnorm")]
    public CqlCode ergoloid_mesylates__USP_1_MG_Oral_Tablet(CqlContext context) => _ergoloid_mesylates__USP_1_MG_Oral_Tablet;

    private static readonly CqlCode _ergoloid_mesylates__USP_1_MG_Oral_Tablet = new CqlCode("318179", "http://www.nlm.nih.gov/research/umls/rxnorm", default, default);
    #endregion

    #region Code: Office or other outpatient visit for the evaluation and management of an established patient that may not require the presence of a physician or other qualified health care professional
    [CqlCodeDefinition(
        definitionName: "Office or other outpatient visit for the evaluation and management of an established patient that may not require the presence of a physician or other qualified health care professional",
        codeId: "99211",
        codeSystem: "http://www.ama-assn.org/go/cpt")]
    public CqlCode Office_or_other_outpatient_visit_for_the_evaluation_and_management_of_an_established_patient_that_may_not_require_the_presence_of_a_physician_or_other_qualified_health_care_professional(CqlContext context) => _Office_or_other_outpatient_visit_for_the_evaluation_and_management_of_an_established_patient_that_may_not_require_the_presence_of_a_physician_or_other_qualified_health_care_professional;

    private static readonly CqlCode _Office_or_other_outpatient_visit_for_the_evaluation_and_management_of_an_established_patient_that_may_not_require_the_presence_of_a_physician_or_other_qualified_health_care_professional = new CqlCode("99211", "http://www.ama-assn.org/go/cpt", default, default);
    #endregion

    #endregion Codes

    #region CodeSystems

    [CqlCodeSystemDefinition(
        definitionName: "RXNORM")]
    public CqlCode[] RXNORM(CqlContext context)
    {
        CqlCode[] xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = [
            new CqlCode("204504", "http://www.nlm.nih.gov/research/umls/rxnorm", default, default),
            new CqlCode("104208", "http://www.nlm.nih.gov/research/umls/rxnorm", default, default),
            new CqlCode("393245", "http://www.nlm.nih.gov/research/umls/rxnorm", default, default),
            new CqlCode("245273", "http://www.nlm.nih.gov/research/umls/rxnorm", default, default),
            new CqlCode("197604", "http://www.nlm.nih.gov/research/umls/rxnorm", default, default),
            new CqlCode("197606", "http://www.nlm.nih.gov/research/umls/rxnorm", default, default),
            new CqlCode("1000048", "http://www.nlm.nih.gov/research/umls/rxnorm", default, default),
            new CqlCode("1000054", "http://www.nlm.nih.gov/research/umls/rxnorm", default, default),
            new CqlCode("1000058", "http://www.nlm.nih.gov/research/umls/rxnorm", default, default),
            new CqlCode("1000064", "http://www.nlm.nih.gov/research/umls/rxnorm", default, default),
            new CqlCode("1000070", "http://www.nlm.nih.gov/research/umls/rxnorm", default, default),
            new CqlCode("966787", "http://www.nlm.nih.gov/research/umls/rxnorm", default, default),
            new CqlCode("1000076", "http://www.nlm.nih.gov/research/umls/rxnorm", default, default),
            new CqlCode("966793", "http://www.nlm.nih.gov/research/umls/rxnorm", default, default),
            new CqlCode("1000097", "http://www.nlm.nih.gov/research/umls/rxnorm", default, default),
            new CqlCode("318179", "http://www.nlm.nih.gov/research/umls/rxnorm", default, default),
        ];

        return xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_;
    }


    [CqlCodeSystemDefinition(
        definitionName: "CPT")]
    public CqlCode[] CPT(CqlContext context)
    {
        CqlCode[] xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = [
            new CqlCode("99211", "http://www.ama-assn.org/go/cpt", default, default),
        ];

        return xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_;
    }


    #endregion CodeSystems

    #region Parameters

    [CqlParameterDefinition(
        definitionName: "Measurement Period")]
    public CqlInterval<CqlDateTime> Measurement_Period(CqlContext context)
    {
        CqlDateTime xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.DateTime(2025, 1, 1, 0, 0, 0, 0, 0.0m);
        CqlDateTime xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.DateTime(2025, 12, 31, 23, 59, 59, 999, 0.0m);
        CqlInterval<CqlDateTime> xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Interval(xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_, xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_, true, true);
        object xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.ResolveParameter("UseofHighRiskMedicationsintheElderlyFHIR-0.2.001", "Measurement Period", xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_);

        return (CqlInterval<CqlDateTime>)xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_;
    }


    #endregion Parameters

    #region Expressions

    [CqlExpressionDefinition(
        definitionName: "Patient")]
    public Patient Patient(CqlContext context)
    {
        IEnumerable<Patient> xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-patient"));
        Patient yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.SingletonFrom<Patient>(xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_);

        return yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_;
    }


    [CqlExpressionDefinition(
        definitionName: "Qualifying Encounters")]
    public IEnumerable<Encounter> Qualifying_Encounters(CqlContext context)
    {
        CqlValueSet yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = this.Office_Visit(context);
        IEnumerable<Encounter> yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        CqlValueSet yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = this.Ophthalmological_Services(context);
        IEnumerable<Encounter> yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Union<Encounter>(yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_, yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_);
        CqlValueSet yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = this.Preventive_Care_Services_Established_Office_Visit__18_and_Up(context);
        IEnumerable<Encounter> yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        CqlValueSet yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = this.Discharge_Services_Nursing_Facility(context);
        IEnumerable<Encounter> yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Union<Encounter>(yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_, yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_);
        IEnumerable<Encounter> yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Union<Encounter>(yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_, yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_);
        CqlValueSet yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = this.Nursing_Facility_Visit(context);
        IEnumerable<Encounter> yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        CqlValueSet yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = this.Care_Services_in_Long_Term_Residential_Facility(context);
        IEnumerable<Encounter> yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Union<Encounter>(yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_, yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_);
        IEnumerable<Encounter> yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Union<Encounter>(yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_, yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_);
        CqlValueSet yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = this.Preventive_Care_Services_Initial_Office_Visit__18_and_Up(context);
        IEnumerable<Encounter> yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        CqlValueSet yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = this.Annual_Wellness_Visit(context);
        IEnumerable<Encounter> yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Union<Encounter>(yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_, yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_);
        IEnumerable<Encounter> yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Union<Encounter>(yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_, yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_);
        CqlValueSet yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = this.Home_Healthcare_Services(context);
        IEnumerable<Encounter> yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        CqlValueSet zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = this.Telephone_Visits(context);
        IEnumerable<Encounter> zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Union<Encounter>(yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_, zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_);
        IEnumerable<Encounter> zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Union<Encounter>(yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_, zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_);
        CqlValueSet zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = this.Virtual_Encounter(context);
        IEnumerable<Encounter> zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        bool? zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_(Encounter E)
        {
            List<CodeableConcept> zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = E?.Type;
            CqlConcept zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_(CodeableConcept @this)
            {
                CqlConcept zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);

                return zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_;
            };
            IEnumerable<CqlConcept> zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_, zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_);
            bool? zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_(CqlConcept T)
            {
                CqlCode zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = this.Office_or_other_outpatient_visit_for_the_evaluation_and_management_of_an_established_patient_that_may_not_require_the_presence_of_a_physician_or_other_qualified_health_care_professional(context);
                CqlConcept zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.ConvertCodeToConcept(zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_);
                bool? zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Equivalent(T, zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_);

                return zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_;
            };
            IEnumerable<CqlConcept> zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Where<CqlConcept>(zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_, zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_);
            bool? zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Exists<CqlConcept>(zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_);

            return zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_;
        };
        IEnumerable<Encounter> zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Where<Encounter>(zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_, zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_);
        IEnumerable<Encounter> zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Union<Encounter>(zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_, zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_);
        IEnumerable<Encounter> zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Union<Encounter>(zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_, zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_);
        IEnumerable<Encounter> zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = Status_1_8_000.Instance.isEncounterPerformed(context, zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_);
        bool? zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_(Encounter ValidEncounters)
        {
            CqlInterval<CqlDateTime> zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = this.Measurement_Period(context);
            Period zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = ValidEncounters?.Period;
            CqlInterval<CqlDateTime> azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_);
            bool? azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_, azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_, default);

            return azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_;
        };
        IEnumerable<Encounter> zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Where<Encounter>(zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_, zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_);

        return zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_;
    }


    [CqlExpressionDefinition(
        definitionName: "Initial Population")]
    public bool? Initial_Population(CqlContext context)
    {
        Patient azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = this.Patient(context);
        Date azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_?.BirthDateElement;
        string azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_?.Value;
        CqlDate azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.ConvertStringToDate(azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_);
        CqlInterval<CqlDateTime> azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = this.Measurement_Period(context);
        CqlDateTime azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.End(azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_);
        CqlDate azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.DateFrom(azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_);
        int? azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.CalculateAgeAt(azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_, azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_, "year");
        bool? azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.GreaterOrEqual(azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_, 65);
        IEnumerable<Encounter> azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = this.Qualifying_Encounters(context);
        bool? azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Exists<Encounter>(azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_);
        bool? azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.And(azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_, azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_);

        return azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_;
    }


    [CqlExpressionDefinition(
        definitionName: "Denominator")]
    public bool? Denominator(CqlContext context)
    {
        bool? azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = this.Initial_Population(context);

        return azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_;
    }


    [CqlExpressionDefinition(
        definitionName: "Denominator Exclusions")]
    public bool? Denominator_Exclusions(CqlContext context)
    {
        bool? azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = Hospice_6_12_000.Instance.Has_Hospice_Services(context);
        bool? azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = PalliativeCare_1_11_000.Instance.Has_Palliative_Care_in_the_Measurement_Period(context);
        bool? azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Or(azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_, azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_);

        return azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public IEnumerable<MedicationRequest> moreThanOneOrder(CqlContext context, IEnumerable<MedicationRequest> Medication)
    {
        IEnumerable<MedicationRequest> azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = Status_1_8_000.Instance.isMedicationOrder(context, Medication);
        IEnumerable<MedicationRequest> azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_(MedicationRequest OrderMedication1)
        {
            IEnumerable<MedicationRequest> azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = Status_1_8_000.Instance.isMedicationOrder(context, Medication);
            bool? azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_(MedicationRequest OrderMedication2)
            {
                FhirDateTime bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = OrderMedication1?.AuthoredOnElement;
                CqlDateTime bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.Convert<CqlDateTime>(bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_);
                CqlInterval<CqlDateTime> bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = this.Measurement_Period(context);
                bool? bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.In<CqlDateTime>(bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_, bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_, default);
                MedicationRequest.DispenseRequestComponent bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = OrderMedication1?.DispenseRequest;
                UnsignedInt bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_?.NumberOfRepeatsAllowedElement;
                int? bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_?.Value;
                bool? bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.GreaterOrEqual(bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_, 1);
                bool? bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.And(bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_, bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_);
                CqlDateTime bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Convert<CqlDateTime>(bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_);
                CqlDate bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.DateFrom(bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_);
                FhirDateTime bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = OrderMedication2?.AuthoredOnElement;
                CqlDateTime bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Convert<CqlDateTime>(bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_);
                CqlDate bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.DateFrom(bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_);
                bool? bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Equivalent(bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_, bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_);
                bool? bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Not(bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_);
                CqlDateTime bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Convert<CqlDateTime>(bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_);
                bool? bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.In<CqlDateTime>(bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_, bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_, default);
                bool? bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.And(bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_, bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_);
                CqlDateTime czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.Convert<CqlDateTime>(bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_);
                bool? czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.In<CqlDateTime>(czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_, bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_, default);
                bool? czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.And(bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_, czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_);
                bool? czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.Or(bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_, czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_);
                CqlDateTime czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Convert<CqlDateTime>(bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_);
                CqlDate czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.DateFrom(czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_);
                CqlDateTime czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Convert<CqlDateTime>(bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_);
                CqlDate czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.DateFrom(czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_);
                bool? czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Equivalent(czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_, czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_);
                CqlDateTime czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Convert<CqlDateTime>(bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_);
                bool? czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.In<CqlDateTime>(czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_, bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_, default);
                bool? czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.And(czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_, czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_);
                CqlInterval<CqlDate> czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = CumulativeMedicationDuration_4_1_000.Instance.medicationRequestPeriod(context, OrderMedication1);
                CqlDate czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Start(czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_);
                CqlDateTime czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.ConvertDateToDateTime(czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_);
                CqlDate czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.DateFrom(czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_);
                CqlInterval<CqlDate> czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = CumulativeMedicationDuration_4_1_000.Instance.medicationRequestPeriod(context, OrderMedication2);
                CqlDate czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Start(czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_);
                CqlDateTime czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.ConvertDateToDateTime(czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_);
                CqlDate czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.DateFrom(czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_);
                bool? czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Equivalent(czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_, czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_);
                bool? dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.Not(czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_);
                bool? dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.And(czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_, dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_);
                CqlDate dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Start(czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_);
                CqlDateTime dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.ConvertDateToDateTime(dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_);
                bool? dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.In<CqlDateTime>(dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_, bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_, default);
                bool? dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.And(dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_, dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_);
                CqlDate dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Start(czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_);
                CqlDateTime dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.ConvertDateToDateTime(dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_);
                bool? dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.In<CqlDateTime>(dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_, bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_, default);
                bool? dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.And(dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_, dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_);
                bool? dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Or(czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_, dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_);

                return dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_;
            };
            IEnumerable<MedicationRequest> bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.Where<MedicationRequest>(azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_, azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_);
            MedicationRequest bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_(MedicationRequest OrderMedication2) =>
                OrderMedication1;
            IEnumerable<MedicationRequest> bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Select<MedicationRequest, MedicationRequest>(bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_, bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_);

            return bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_;
        };
        IEnumerable<MedicationRequest> azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.SelectMany<MedicationRequest, MedicationRequest>(azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_, azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_);
        MedicationRequest azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_(MedicationRequest OrderMedication1) =>
            OrderMedication1;
        IEnumerable<MedicationRequest> azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Select<MedicationRequest, MedicationRequest>(azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_, azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_);
        IEnumerable<MedicationRequest> azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Distinct<MedicationRequest>(azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_);

        return azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_;
    }


    [CqlExpressionDefinition(
        definitionName: "Same High Risk Medications Ordered on Different Days")]
    public IEnumerable<MedicationRequest> Same_High_Risk_Medications_Ordered_on_Different_Days(CqlContext context)
    {
        CqlValueSet dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = this.Potentially_Harmful_Antihistamines_for_Older_Adults(context);
        IEnumerable<MedicationRequest> dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Union<MedicationRequest>(dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_, dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_);
        IEnumerable<MedicationRequest> dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = this.moreThanOneOrder(context, dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_);
        CqlValueSet dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = this.Potentially_Harmful_Antiparkinsonian_Agents_for_Older_Adults(context);
        IEnumerable<MedicationRequest> dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Union<MedicationRequest>(dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_, dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_);
        IEnumerable<MedicationRequest> ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = this.moreThanOneOrder(context, dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_);
        IEnumerable<MedicationRequest> ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Union<MedicationRequest>(dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_, ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_);
        CqlValueSet ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = this.Potentially_Harmful_Gastrointestinal_Antispasmodics_for_Older_Adults(context);
        IEnumerable<MedicationRequest> ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Union<MedicationRequest>(ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_, ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_);
        IEnumerable<MedicationRequest> ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = this.moreThanOneOrder(context, ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_);
        CqlValueSet ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = this.Dipyridamole_Medications(context);
        IEnumerable<MedicationRequest> ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Union<MedicationRequest>(ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_, ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_);
        IEnumerable<MedicationRequest> ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = this.moreThanOneOrder(context, ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_);
        IEnumerable<MedicationRequest> ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Union<MedicationRequest>(ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_, ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_);
        IEnumerable<MedicationRequest> ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Union<MedicationRequest>(ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_, ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_);
        CqlValueSet ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = this.Guanfacine_Medications(context);
        IEnumerable<MedicationRequest> ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Union<MedicationRequest>(ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_, ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_);
        IEnumerable<MedicationRequest> ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = this.moreThanOneOrder(context, ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_);
        CqlValueSet ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = this.Nifedipine_Medications(context);
        IEnumerable<MedicationRequest> ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.Union<MedicationRequest>(ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_, ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_);
        IEnumerable<MedicationRequest> fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = this.moreThanOneOrder(context, fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_);
        IEnumerable<MedicationRequest> fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Union<MedicationRequest>(ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_, fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_);
        IEnumerable<MedicationRequest> fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Union<MedicationRequest>(ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_, fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_);
        CqlValueSet fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = this.Potentially_Harmful_Antidepressants_for_Older_Adults(context);
        IEnumerable<MedicationRequest> fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Union<MedicationRequest>(fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_, fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_);
        IEnumerable<MedicationRequest> fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = this.moreThanOneOrder(context, fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_);
        CqlValueSet fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = this.Potentially_Harmful_Barbiturates_for_Older_Adults(context);
        IEnumerable<MedicationRequest> fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Union<MedicationRequest>(fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_, fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_);
        IEnumerable<MedicationRequest> fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = this.moreThanOneOrder(context, fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_);
        IEnumerable<MedicationRequest> fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Union<MedicationRequest>(fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_, fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_);
        IEnumerable<MedicationRequest> fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Union<MedicationRequest>(fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_, fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_);
        CqlCode fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = this.ergoloid_mesylates__USP_1_MG_Oral_Tablet(context);
        IEnumerable<CqlCode> fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.ToList<CqlCode>(fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_);
        IEnumerable<MedicationRequest> fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, default, fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<CqlCode> fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.ToList<CqlCode>(fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_);
        IEnumerable<MedicationRequest> fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, default, fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Union<MedicationRequest>(fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_, fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_);
        IEnumerable<MedicationRequest> fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = this.moreThanOneOrder(context, fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_);
        CqlValueSet gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = this.Meprobamate_Medications(context);
        IEnumerable<MedicationRequest> gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.Union<MedicationRequest>(gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_, gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_);
        IEnumerable<MedicationRequest> gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = this.moreThanOneOrder(context, gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_);
        IEnumerable<MedicationRequest> gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Union<MedicationRequest>(fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_, gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_);
        IEnumerable<MedicationRequest> gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Union<MedicationRequest>(fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_, gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_);
        CqlValueSet gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = this.Potentially_Harmful_Estrogens_for_Older_Adults(context);
        IEnumerable<MedicationRequest> gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Union<MedicationRequest>(gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_, gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_);
        IEnumerable<MedicationRequest> gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = this.moreThanOneOrder(context, gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_);
        CqlValueSet gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = this.Potentially_Harmful_Sulfonylureas_for_Older_Adults(context);
        IEnumerable<MedicationRequest> gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Union<MedicationRequest>(gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_, gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_);
        IEnumerable<MedicationRequest> gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = this.moreThanOneOrder(context, gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_);
        IEnumerable<MedicationRequest> gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Union<MedicationRequest>(gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_, gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_);
        IEnumerable<MedicationRequest> gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Union<MedicationRequest>(gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_, gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_);
        CqlValueSet gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = this.Desiccated_Thyroid_Medications(context);
        IEnumerable<MedicationRequest> gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.Union<MedicationRequest>(gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_, gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_);
        IEnumerable<MedicationRequest> hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = this.moreThanOneOrder(context, hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_);
        CqlValueSet hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = this.Potentially_Harmful_Nonbenzodiazepine_Hypnotics_for_Older_Adults(context);
        IEnumerable<MedicationRequest> hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Union<MedicationRequest>(hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_, hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_);
        IEnumerable<MedicationRequest> hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = this.moreThanOneOrder(context, hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_);
        IEnumerable<MedicationRequest> hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Union<MedicationRequest>(hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_, hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_);
        IEnumerable<MedicationRequest> hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Union<MedicationRequest>(gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_, hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_);
        CqlValueSet hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = this.Potentially_Harmful_Skeletal_Muscle_Relaxants_for_Older_Adults(context);
        IEnumerable<MedicationRequest> hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Union<MedicationRequest>(hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_, hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_);
        IEnumerable<MedicationRequest> hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = this.moreThanOneOrder(context, hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_);
        CqlValueSet hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = this.Potentially_Harmful_Pain_Medications_for_Older_Adults(context);
        IEnumerable<MedicationRequest> hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Union<MedicationRequest>(hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_, hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_);
        IEnumerable<MedicationRequest> hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = this.moreThanOneOrder(context, hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_);
        IEnumerable<MedicationRequest> hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Union<MedicationRequest>(hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_, hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_);
        IEnumerable<MedicationRequest> hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Union<MedicationRequest>(hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_, hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_);
        CqlValueSet hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = this.Megestrol_Medications(context);
        IEnumerable<MedicationRequest> hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Union<MedicationRequest>(hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_, izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_);
        IEnumerable<MedicationRequest> izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = this.moreThanOneOrder(context, izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_);
        CqlValueSet izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = this.Meperidine_Medications(context);
        IEnumerable<MedicationRequest> izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Union<MedicationRequest>(izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_, izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_);
        IEnumerable<MedicationRequest> izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = this.moreThanOneOrder(context, izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_);
        IEnumerable<MedicationRequest> izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Union<MedicationRequest>(izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_, izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_);
        IEnumerable<MedicationRequest> izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Union<MedicationRequest>(hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_, izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_);

        return izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public decimal? MedicationRequestPeriodInDays(CqlContext context, MedicationRequest Request)
    {
        MedicationRequest[] izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = [
            Request,
        ];
        decimal? izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_(MedicationRequest R)
        {
            MedicationRequest.DispenseRequestComponent izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = R?.DispenseRequest;
            Duration izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_?.ExpectedSupplyDuration;
            CqlQuantity izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = FHIRHelpers_4_4_000.Instance.ToQuantity(context, izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_);
            CqlQuantity izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.ConvertQuantity(izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_, "d");
            decimal? izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_?.value;
            Quantity izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_?.Quantity;
            CqlQuantity izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = FHIRHelpers_4_4_000.Instance.ToQuantity(context, izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_);
            decimal? izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_?.value;
            List<Dosage> jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = R?.DosageInstruction;
            Dosage jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_);
            List<Dosage.DoseAndRateComponent> jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_?.DoseAndRate;
            Dosage.DoseAndRateComponent jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.SingletonFrom<Dosage.DoseAndRateComponent>((IEnumerable<Dosage.DoseAndRateComponent>)jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_);
            DataType jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_?.Dose;
            object jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = FHIRHelpers_4_4_000.Instance.ToValue(context, jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_);
            CqlQuantity jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.End(jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ as CqlInterval<CqlQuantity>);
            Dosage jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_);
            List<Dosage.DoseAndRateComponent> jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_?.DoseAndRate;
            Dosage.DoseAndRateComponent jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.SingletonFrom<Dosage.DoseAndRateComponent>((IEnumerable<Dosage.DoseAndRateComponent>)jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_);
            DataType jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_?.Dose;
            object jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = FHIRHelpers_4_4_000.Instance.ToValue(context, jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_);
            decimal? jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = (jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ ?? jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ as CqlQuantity)?.value;
            Dosage jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_);
            Timing jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_?.Timing;
            Timing.RepeatComponent jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_?.Repeat;
            PositiveInt jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_?.FrequencyMaxElement;
            int? jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_?.Value;
            Dosage jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_);
            Timing jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_?.Timing;
            Timing.RepeatComponent jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_?.Repeat;
            PositiveInt jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_?.FrequencyElement;
            int? jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_?.Value;
            Dosage kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_);
            Timing kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_?.Timing;
            Timing.RepeatComponent kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_?.Repeat;
            FhirDecimal kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_?.PeriodElement;
            decimal? kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_?.Value;
            Dosage kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_);
            Timing kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_?.Timing;
            Timing.RepeatComponent kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_?.Repeat;
            Code<Timing.UnitsOfTime> kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_?.PeriodUnitElement;
            Timing.UnitsOfTime? kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_?.Value;
            string kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Convert<string>(kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_);
            CqlQuantity kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = CumulativeMedicationDuration_4_1_000.Instance.Quantity(context, kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_, kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_);
            decimal? kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = CumulativeMedicationDuration_4_1_000.Instance.ToDaily(context, jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ ?? jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_, kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_);
            Dosage kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_);
            Timing kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_?.Timing;
            Timing.RepeatComponent kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_?.Repeat;
            List<Time> kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_?.TimeOfDayElement;
            IEnumerable<CqlTime> kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.LateBoundProperty<IEnumerable<CqlTime>>(kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_, "value");
            int? kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Count<CqlTime>(kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_);
            decimal? kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.ConvertIntegerToDecimal(kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_);
            decimal? kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Multiply(jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_, (kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ ?? kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_) ?? 1.0m);
            decimal? kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Divide(izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_, kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_);
            UnsignedInt lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_?.NumberOfRepeatsAllowedElement;
            int? lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_?.Value;
            int? lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Add(1, lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ ?? 0);
            decimal? lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.ConvertIntegerToDecimal(lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_);
            decimal? lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.Multiply(izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ ?? kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_, lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_);

            return lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_;
        };
        IEnumerable<decimal?> izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Select<MedicationRequest, decimal?>((IEnumerable<MedicationRequest>)izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_, izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_);
        IEnumerable<decimal?> izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Distinct<decimal?>(izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_);
        decimal? izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.SingletonFrom<decimal?>(izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_);

        return izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_;
    }


    [CqlExpressionDefinition(
        definitionName: "Two High Risk Medications with Prolonged Duration")]
    public bool? Two_High_Risk_Medications_with_Prolonged_Duration(CqlContext context)
    {
        CqlValueSet lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = this.Potentially_Harmful_Antiinfectives_for_Older_Adults(context);
        IEnumerable<MedicationRequest> lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Union<MedicationRequest>(lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_, lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_);
        IEnumerable<MedicationRequest> lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = this.moreThanOneOrder(context, lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_);
        decimal? lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_(MedicationRequest AntiInfectives)
        {
            decimal? lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = this.MedicationRequestPeriodInDays(context, AntiInfectives);

            return lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_;
        };
        IEnumerable<decimal?> lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Select<MedicationRequest, decimal?>(lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_, lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_);
        decimal? lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Sum(lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_);
        decimal? lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.ConvertIntegerToDecimal(90);
        bool? lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Greater(lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_, lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_);

        return lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public CqlQuantity MedicationStrengthPerUnit(CqlContext context, CqlConcept Strength)
    {
        CqlQuantity lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_()
        {
            bool lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_()
            {
                CqlCode mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = this.digoxin_0_05_MG_ML_Oral_Solution(context);
                CqlConcept mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.ConvertCodeToConcept(mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_);
                bool? mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Equivalent(Strength, mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_);

                return mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ ?? false;
            };
            bool lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_()
            {
                CqlCode mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = this.digoxin_0_0625_MG_Oral_Tablet(context);
                CqlConcept mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.ConvertCodeToConcept(mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_);
                bool? mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Equivalent(Strength, mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_);

                return mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ ?? false;
            };
            bool lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_()
            {
                CqlCode mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = this._1_ML_digoxin_0_1_MG_ML_Injection(context);
                CqlConcept mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.ConvertCodeToConcept(mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_);
                bool? mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Equivalent(Strength, mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_);

                return mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ ?? false;
            };
            bool lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_()
            {
                CqlCode mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = this.digoxin_0_125_MG_Oral_Tablet(context);
                CqlConcept mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.ConvertCodeToConcept(mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_);
                bool? mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Equivalent(Strength, mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_);

                return mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ ?? false;
            };
            bool lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_()
            {
                CqlCode mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = this.digoxin_0_25_MG_Oral_Tablet(context);
                CqlConcept mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.ConvertCodeToConcept(mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_);
                bool? mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Equivalent(Strength, mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_);

                return mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ ?? false;
            };
            bool lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_()
            {
                CqlCode mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = this._2_ML_digoxin_0_25_MG_ML_Injection(context);
                CqlConcept mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.ConvertCodeToConcept(mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_);
                bool? mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Equivalent(Strength, mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_);

                return mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ ?? false;
            };
            bool lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_()
            {
                CqlCode mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = this.doxepin_3_MG_Oral_Tablet(context);
                CqlConcept nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.ConvertCodeToConcept(mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_);
                bool? nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Equivalent(Strength, nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_);

                return nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ ?? false;
            };
            bool lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_()
            {
                CqlCode nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = this.doxepin_6_MG_Oral_Tablet(context);
                CqlConcept nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.ConvertCodeToConcept(nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_);
                bool? nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.Equivalent(Strength, nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_);

                return nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ ?? false;
            };
            bool mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_()
            {
                CqlCode nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = this.doxepin_10_MG_Oral_Capsule(context);
                CqlConcept nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.ConvertCodeToConcept(nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_);
                bool? nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Equivalent(Strength, nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_);

                return nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ ?? false;
            };
            bool mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_()
            {
                CqlCode nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = this.doxepin_10_MG_ML_Oral_Solution(context);
                CqlConcept nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.ConvertCodeToConcept(nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_);
                bool? nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Equivalent(Strength, nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_);

                return nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ ?? false;
            };
            bool mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_()
            {
                CqlCode nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = this.doxepin_25_MG_Oral_Capsule(context);
                CqlConcept nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.ConvertCodeToConcept(nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_);
                bool? nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Equivalent(Strength, nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_);

                return nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ ?? false;
            };
            bool mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_()
            {
                CqlCode nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = this.doxepin_50_MG_Oral_Capsule(context);
                CqlConcept nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.ConvertCodeToConcept(nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_);
                bool? nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Equivalent(Strength, nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_);

                return nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ ?? false;
            };
            bool mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_()
            {
                CqlCode nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = this.doxepin_75_MG_Oral_Capsule(context);
                CqlConcept nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.ConvertCodeToConcept(nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_);
                bool? nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Equivalent(Strength, nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_);

                return nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ ?? false;
            };
            bool mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_()
            {
                CqlCode nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = this.doxepin_100_MG_Oral_Capsule(context);
                CqlConcept nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.ConvertCodeToConcept(nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_);
                bool? nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Equivalent(Strength, nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_);

                return nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ ?? false;
            };
            bool mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_()
            {
                CqlCode nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = this.doxepin_150_MG_Oral_Capsule(context);
                CqlConcept nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.ConvertCodeToConcept(nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_);
                bool? nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Equivalent(Strength, nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_);

                return nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ ?? false;
            };
            if (lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_())
            {
                CqlQuantity ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.Quantity(0.05m, "mg/mL");

                return ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_;
            }
            else if (lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_())
            {
                CqlQuantity ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Quantity(0.0625m, "mg");

                return ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_;
            }
            else if (lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_())
            {
                CqlQuantity ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Quantity(0.1m, "mg/mL");

                return ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_;
            }
            else if (lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_())
            {
                CqlQuantity ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Quantity(0.125m, "mg");

                return ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_;
            }
            else if (lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_())
            {
                CqlQuantity ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.Quantity(0.25m, "mg");

                return ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_;
            }
            else if (lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_())
            {
                CqlQuantity ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Quantity(0.25m, "mg/mL");

                return ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_;
            }
            else if (lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_())
            {
                CqlQuantity ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Quantity(3m, "mg");

                return ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_;
            }
            else if (lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_())
            {
                CqlQuantity ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Quantity(6m, "mg");

                return ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_;
            }
            else if (mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_())
            {
                CqlQuantity ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Quantity(10m, "mg");

                return ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_;
            }
            else if (mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_())
            {
                CqlQuantity ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Quantity(10m, "mg/mL");

                return ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_;
            }
            else if (mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_())
            {
                CqlQuantity ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Quantity(25m, "mg");

                return ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_;
            }
            else if (mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_())
            {
                CqlQuantity ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Quantity(50m, "mg");

                return ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_;
            }
            else if (mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_())
            {
                CqlQuantity ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Quantity(75m, "mg");

                return ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_;
            }
            else if (mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_())
            {
                CqlQuantity ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Quantity(100m, "mg");

                return ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_;
            }
            else if (mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_())
            {
                CqlQuantity ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Quantity(150m, "mg");

                return ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_;
            }
            else
            {
                return default;
            }
        };

        return lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_();
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public CqlQuantity averageDailyDose(CqlContext context, MedicationRequest MedicationRequest)
    {
        MedicationRequest[] ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = [
            MedicationRequest,
        ];
        CqlQuantity ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_(MedicationRequest Order)
        {
            CqlQuantity ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_()
            {
                bool ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_()
                {
                    decimal? ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = this.MedicationRequestPeriodInDays(context, Order);
                    bool? ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Not((bool?)(ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ is null));
                    CqlConcept ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = CQMCommon_2_2_000.Instance.getMedicationCode(context, Order);
                    CqlQuantity ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = this.MedicationStrengthPerUnit(context, ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_);
                    string pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_?.unit;
                    bool? pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Equal(pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_, "mg");
                    CqlQuantity pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = this.MedicationStrengthPerUnit(context, ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_);
                    string pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_?.unit;
                    bool? pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Equal(pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_, "mg/mL");
                    MedicationRequest.DispenseRequestComponent pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = Order?.DispenseRequest;
                    Quantity pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_?.Quantity;
                    CqlQuantity pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = FHIRHelpers_4_4_000.Instance.ToQuantity(context, pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_);
                    string pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_?.unit;
                    bool? pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Equal(pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_, "mL");
                    bool? pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.And(pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_, pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_);
                    bool? pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Or(pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_, pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_);
                    bool? pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.And(ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_, pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_);

                    return pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ ?? false;
                };
                if (ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_())
                {
                    MedicationRequest.DispenseRequestComponent pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = Order?.DispenseRequest;
                    Quantity pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_?.Quantity;
                    CqlQuantity pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = FHIRHelpers_4_4_000.Instance.ToQuantity(context, pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_);
                    CqlConcept pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = CQMCommon_2_2_000.Instance.getMedicationCode(context, Order);
                    CqlQuantity pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = this.MedicationStrengthPerUnit(context, pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_);
                    CqlQuantity pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Multiply(pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_, pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_);
                    decimal? pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = this.MedicationRequestPeriodInDays(context, Order);
                    CqlQuantity pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Divide(pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_, new CqlQuantity(pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_, "d"));

                    return pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_;
                }
                else
                {
                    return default;
                }
            };

            return ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_();
        };
        IEnumerable<CqlQuantity> ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Select<MedicationRequest, CqlQuantity>((IEnumerable<MedicationRequest>)ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_, ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_);
        IEnumerable<CqlQuantity> ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Distinct<CqlQuantity>(ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_);
        CqlQuantity ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.SingletonFrom<CqlQuantity>(ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_);

        return ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_;
    }


    [CqlExpressionDefinition(
        definitionName: "High Risk Medications with Average Daily Dose Criteria")]
    public bool? High_Risk_Medications_with_Average_Daily_Dose_Criteria(CqlContext context)
    {
        CqlValueSet pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = this.Digoxin_Medications(context);
        IEnumerable<MedicationRequest> pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.Union<MedicationRequest>(pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_, pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_);
        IEnumerable<MedicationRequest> qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = this.moreThanOneOrder(context, qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_);
        bool? qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_(MedicationRequest DigoxinOrdered)
        {
            CqlQuantity qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = this.averageDailyDose(context, DigoxinOrdered);
            CqlQuantity qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Quantity(0.125m, "mg/d");
            bool? qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Greater(qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_, qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_);

            return qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_;
        };
        IEnumerable<MedicationRequest> qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Where<MedicationRequest>(qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_, qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_);
        bool? qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.Exists<MedicationRequest>(qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_);
        CqlValueSet qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = this.Doxepin_Medications(context);
        IEnumerable<MedicationRequest> qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Union<MedicationRequest>(qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_, qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_);
        IEnumerable<MedicationRequest> qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = this.moreThanOneOrder(context, qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_);
        bool? qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_(MedicationRequest DoxepinOrdered)
        {
            CqlQuantity qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = this.averageDailyDose(context, DoxepinOrdered);
            CqlQuantity qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Quantity(6m, "mg/d");
            bool? qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Greater(qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_, qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_);

            return qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_;
        };
        IEnumerable<MedicationRequest> qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Where<MedicationRequest>(qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_, qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_);
        bool? qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Exists<MedicationRequest>(qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_);
        bool? qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Or(qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_, qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_);

        return qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_;
    }


    [CqlExpressionDefinition(
        definitionName: "Numerator 1")]
    public bool? Numerator_1(CqlContext context)
    {
        IEnumerable<MedicationRequest> qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = this.Same_High_Risk_Medications_Ordered_on_Different_Days(context);
        bool? qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Exists<MedicationRequest>(qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_);
        bool? qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = this.Two_High_Risk_Medications_with_Prolonged_Duration(context);
        bool? qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Or(qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_, qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_);
        bool? qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = this.High_Risk_Medications_with_Average_Daily_Dose_Criteria(context);
        bool? rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.Or(qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_, qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_);

        return rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_;
    }


    [CqlExpressionDefinition(
        definitionName: "More than One Antipsychotic Order")]
    public bool? More_than_One_Antipsychotic_Order(CqlContext context)
    {
        CqlValueSet rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = this.Potentially_Harmful_Antipsychotics_for_Older_Adults(context);
        IEnumerable<MedicationRequest> rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Union<MedicationRequest>(rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_, rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_);
        IEnumerable<MedicationRequest> rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = this.moreThanOneOrder(context, rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_);
        bool? rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Exists<MedicationRequest>(rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_);

        return rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_;
    }


    [CqlExpressionDefinition(
        definitionName: "Antipsychotic Index Prescription Start Date")]
    public CqlDateTime Antipsychotic_Index_Prescription_Start_Date(CqlContext context)
    {
        CqlValueSet rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = this.Potentially_Harmful_Antipsychotics_for_Older_Adults(context);
        IEnumerable<MedicationRequest> rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Union<MedicationRequest>(rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_, rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_);
        IEnumerable<MedicationRequest> rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = Status_1_8_000.Instance.isMedicationOrder(context, rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_);
        bool? rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_(MedicationRequest AntipsychoticMedication)
        {
            FhirDateTime rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = AntipsychoticMedication?.AuthoredOnElement;
            CqlDateTime rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Convert<CqlDateTime>(rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_);
            CqlInterval<CqlDateTime> rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = this.Measurement_Period(context);
            bool? rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.In<CqlDateTime>(rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_, rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_, default);

            return rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_;
        };
        IEnumerable<MedicationRequest> rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Where<MedicationRequest>(rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_, rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_);
        CqlDateTime rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_(MedicationRequest AntipsychoticMedication)
        {
            FhirDateTime rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = AntipsychoticMedication?.AuthoredOnElement;
            CqlDateTime szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.Convert<CqlDateTime>(rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_);

            return szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_;
        };
        IEnumerable<CqlDateTime> rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Select<MedicationRequest, CqlDateTime>(rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_, rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_);
        IEnumerable<CqlDateTime> rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Distinct<CqlDateTime>(rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_);
        IEnumerable<CqlDateTime> rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.ListSort<CqlDateTime>(rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_, System.ComponentModel.ListSortDirection.Ascending);
        CqlDateTime rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.First<CqlDateTime>(rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_);

        return rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_;
    }


    [CqlExpressionDefinition(
        definitionName: "More than One Benzodiazepine Order")]
    public bool? More_than_One_Benzodiazepine_Order(CqlContext context)
    {
        CqlValueSet szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = this.Potentially_Harmful_Benzodiazepines_for_Older_Adults(context);
        IEnumerable<MedicationRequest> szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Union<MedicationRequest>(szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_, szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_);
        IEnumerable<MedicationRequest> szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = this.moreThanOneOrder(context, szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_);
        bool? szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Exists<MedicationRequest>(szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_);

        return szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_;
    }


    [CqlExpressionDefinition(
        definitionName: "Benzodiazepine Index Prescription Start Date")]
    public CqlDateTime Benzodiazepine_Index_Prescription_Start_Date(CqlContext context)
    {
        CqlValueSet szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = this.Potentially_Harmful_Benzodiazepines_for_Older_Adults(context);
        IEnumerable<MedicationRequest> szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Union<MedicationRequest>(szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_, szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_);
        IEnumerable<MedicationRequest> szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = Status_1_8_000.Instance.isMedicationOrder(context, szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_);
        bool? szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_(MedicationRequest BenzodiazepineMedication)
        {
            FhirDateTime szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = BenzodiazepineMedication?.AuthoredOnElement;
            CqlDateTime szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Convert<CqlDateTime>(szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_);
            CqlInterval<CqlDateTime> szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = this.Measurement_Period(context);
            bool? szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.In<CqlDateTime>(szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_, szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_, default);

            return szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_;
        };
        IEnumerable<MedicationRequest> szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Where<MedicationRequest>(szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_, szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_);
        CqlDateTime szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_(MedicationRequest BenzodiazepineMedication)
        {
            FhirDateTime szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = BenzodiazepineMedication?.AuthoredOnElement;
            CqlDateTime tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.Convert<CqlDateTime>(szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_);

            return tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_;
        };
        IEnumerable<CqlDateTime> szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Select<MedicationRequest, CqlDateTime>(szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_, szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_);
        IEnumerable<CqlDateTime> szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Distinct<CqlDateTime>(szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_);
        IEnumerable<CqlDateTime> szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.ListSort<CqlDateTime>(szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_, System.ComponentModel.ListSortDirection.Ascending);
        CqlDateTime szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.First<CqlDateTime>(szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_);

        return szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_;
    }


    [CqlExpressionDefinition(
        definitionName: "Numerator 2")]
    public bool? Numerator_2(CqlContext context)
    {
        bool? tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = this.More_than_One_Antipsychotic_Order(context);
        CqlValueSet tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = this.Schizophrenia(context);
        IEnumerable<Condition> tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        CqlValueSet tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = this.Bipolar_Disorder(context);
        IEnumerable<Condition> tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        IEnumerable<Condition> tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Union<Condition>(tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_, tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_);
        bool? tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_(Condition AntipsychoticTreatedDiagnoses)
        {
            CqlInterval<CqlDateTime> uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = QICoreCommon_2_1_000.Instance.prevalenceInterval(context, AntipsychoticTreatedDiagnoses);
            CqlInterval<CqlDateTime> uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = this.Measurement_Period(context);
            CqlDateTime uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Start(uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_);
            CqlQuantity uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Quantity(1m, "year");
            CqlDateTime uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Subtract(uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_, uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_);
            CqlDateTime uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = this.Antipsychotic_Index_Prescription_Start_Date(context);
            CqlInterval<CqlDateTime> uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Interval(uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_, uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_, true, true);
            bool? uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Overlaps(uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_, uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_, default);

            return uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_;
        };
        IEnumerable<Condition> tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Where<Condition>(tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_, tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_);
        bool? tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Exists<Condition>(tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_);
        bool? tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Not(tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_);
        bool? tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.And(tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_, tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_);
        bool? tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = this.More_than_One_Benzodiazepine_Order(context);
        CqlValueSet tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = this.Seizure_Disorder(context);
        IEnumerable<Condition> tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        CqlValueSet tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = this.REM_Sleep_Behavior_Disorder(context);
        IEnumerable<Condition> tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        IEnumerable<Condition> tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Union<Condition>(tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_, tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_);
        CqlValueSet tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = this.Benzodiazepine_Withdrawal(context);
        IEnumerable<Condition> tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        CqlValueSet tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = this.Alcohol_Withdrawal(context);
        IEnumerable<Condition> tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        IEnumerable<Condition> tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Union<Condition>(tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_, tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_);
        IEnumerable<Condition> tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Union<Condition>(tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_, tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_);
        CqlValueSet tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = this.Generalized_Anxiety_Disorder(context);
        IEnumerable<Condition> tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        IEnumerable<Condition> uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.Union<Condition>(tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_, tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_);
        bool? uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_(Condition BenzodiazepineTreatedDiagnoses)
        {
            CqlInterval<CqlDateTime> uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = QICoreCommon_2_1_000.Instance.prevalenceInterval(context, BenzodiazepineTreatedDiagnoses);
            CqlInterval<CqlDateTime> uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = this.Measurement_Period(context);
            CqlDateTime uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Start(uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_);
            CqlQuantity uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Quantity(1m, "year");
            CqlDateTime uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Subtract(uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_, uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_);
            CqlDateTime uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = this.Benzodiazepine_Index_Prescription_Start_Date(context);
            CqlInterval<CqlDateTime> uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Interval(uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_, uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_, true, true);
            bool? uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Overlaps(uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_, uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_, default);

            return uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_;
        };
        IEnumerable<Condition> uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Where<Condition>(uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_, uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_);
        bool? uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Exists<Condition>(uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_);
        bool? uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.Not(uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_);
        bool? uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.And(tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_, uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_);
        bool? uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Or(tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_, uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_);

        return uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_;
    }


    [CqlExpressionDefinition(
        definitionName: "Numerator 3")]
    public bool? Numerator_3(CqlContext context)
    {
        bool? uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = this.Numerator_2(context);
        bool? uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = this.Numerator_1(context);
        bool? vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.Not(uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_);
        bool? vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.And(uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_, vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_);
        bool? vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Or(uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_, vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_);

        return vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_;
    }


    [CqlExpressionDefinition(
        definitionName: "SDE Ethnicity")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Ethnicity(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = SupplementalDataElements_3_5_000.Instance.SDE_Ethnicity(context);

        return vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_;
    }


    [CqlExpressionDefinition(
        definitionName: "SDE Payer")]
    public IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> SDE_Payer(CqlContext context)
    {
        IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = SupplementalDataElements_3_5_000.Instance.SDE_Payer(context);

        return vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_;
    }


    [CqlExpressionDefinition(
        definitionName: "SDE Race")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Race(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = SupplementalDataElements_3_5_000.Instance.SDE_Race(context);

        return vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_;
    }


    [CqlExpressionDefinition(
        definitionName: "SDE Sex")]
    public CqlCode SDE_Sex(CqlContext context)
    {
        CqlCode vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = SupplementalDataElements_3_5_000.Instance.SDE_Sex(context);

        return vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_;
    }


    #endregion Expressions

}

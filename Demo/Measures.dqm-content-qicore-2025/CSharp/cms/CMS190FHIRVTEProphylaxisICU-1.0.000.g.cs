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

[System.CodeDom.Compiler.GeneratedCode(".NET Code Generation", "5.3.8.0")]
[CqlLibrary("CMS190FHIRVTEProphylaxisICU", "1.0.000")]
public partial class CMS190FHIRVTEProphylaxisICU_1_0_000 : ILibrary, ISingleton<CMS190FHIRVTEProphylaxisICU_1_0_000>
{
    #region ValueSets (33)

    [CqlValueSetDefinition("Application of Graduated Compression Stockings", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1110.66", valueSetVersion: null)]
    public CqlValueSet Application_of_Graduated_Compression_Stockings(CqlContext _) => _Application_of_Graduated_Compression_Stockings;
    private static readonly CqlValueSet _Application_of_Graduated_Compression_Stockings = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1110.66", null);

    [CqlValueSetDefinition("Application of Intermittent Pneumatic Compression Devices", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1110.65", valueSetVersion: null)]
    public CqlValueSet Application_of_Intermittent_Pneumatic_Compression_Devices(CqlContext _) => _Application_of_Intermittent_Pneumatic_Compression_Devices;
    private static readonly CqlValueSet _Application_of_Intermittent_Pneumatic_Compression_Devices = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1110.65", null);

    [CqlValueSetDefinition("Application of Venous Foot Pumps", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1110.64", valueSetVersion: null)]
    public CqlValueSet Application_of_Venous_Foot_Pumps(CqlContext _) => _Application_of_Venous_Foot_Pumps;
    private static readonly CqlValueSet _Application_of_Venous_Foot_Pumps = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1110.64", null);

    [CqlValueSetDefinition("Atrial Fibrillation or Flutter", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.202", valueSetVersion: null)]
    public CqlValueSet Atrial_Fibrillation_or_Flutter(CqlContext _) => _Atrial_Fibrillation_or_Flutter;
    private static readonly CqlValueSet _Atrial_Fibrillation_or_Flutter = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.202", null);

    [CqlValueSetDefinition("Comfort Measures", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/1.3.6.1.4.1.33895.1.3.0.45", valueSetVersion: null)]
    public CqlValueSet Comfort_Measures(CqlContext _) => _Comfort_Measures;
    private static readonly CqlValueSet _Comfort_Measures = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/1.3.6.1.4.1.33895.1.3.0.45", null);

    [CqlValueSetDefinition("Direct Thrombin Inhibitor", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.205", valueSetVersion: null)]
    public CqlValueSet Direct_Thrombin_Inhibitor(CqlContext _) => _Direct_Thrombin_Inhibitor;
    private static readonly CqlValueSet _Direct_Thrombin_Inhibitor = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.205", null);

    [CqlValueSetDefinition("General or Neuraxial Anesthesia", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.666.5.1743", valueSetVersion: null)]
    public CqlValueSet General_or_Neuraxial_Anesthesia(CqlContext _) => _General_or_Neuraxial_Anesthesia;
    private static readonly CqlValueSet _General_or_Neuraxial_Anesthesia = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.666.5.1743", null);

    [CqlValueSetDefinition("General Surgery", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.255", valueSetVersion: null)]
    public CqlValueSet General_Surgery(CqlContext _) => _General_Surgery;
    private static readonly CqlValueSet _General_Surgery = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.255", null);

    [CqlValueSetDefinition("Glycoprotein IIb IIIa Inhibitors", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1045.41", valueSetVersion: null)]
    public CqlValueSet Glycoprotein_IIb_IIIa_Inhibitors(CqlContext _) => _Glycoprotein_IIb_IIIa_Inhibitors;
    private static readonly CqlValueSet _Glycoprotein_IIb_IIIa_Inhibitors = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1045.41", null);

    [CqlValueSetDefinition("Graduated compression stockings", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.256", valueSetVersion: null)]
    public CqlValueSet Graduated_compression_stockings(CqlContext _) => _Graduated_compression_stockings;
    private static readonly CqlValueSet _Graduated_compression_stockings = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.256", null);

    [CqlValueSetDefinition("Gynecological Surgery", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.257", valueSetVersion: null)]
    public CqlValueSet Gynecological_Surgery(CqlContext _) => _Gynecological_Surgery;
    private static readonly CqlValueSet _Gynecological_Surgery = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.257", null);

    [CqlValueSetDefinition("Hip Fracture Surgery", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.258", valueSetVersion: null)]
    public CqlValueSet Hip_Fracture_Surgery(CqlContext _) => _Hip_Fracture_Surgery;
    private static readonly CqlValueSet _Hip_Fracture_Surgery = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.258", null);

    [CqlValueSetDefinition("Hip Replacement Surgery", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.259", valueSetVersion: null)]
    public CqlValueSet Hip_Replacement_Surgery(CqlContext _) => _Hip_Replacement_Surgery;
    private static readonly CqlValueSet _Hip_Replacement_Surgery = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.259", null);

    [CqlValueSetDefinition("Injectable Factor Xa Inhibitor for VTE Prophylaxis", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.211", valueSetVersion: null)]
    public CqlValueSet Injectable_Factor_Xa_Inhibitor_for_VTE_Prophylaxis(CqlContext _) => _Injectable_Factor_Xa_Inhibitor_for_VTE_Prophylaxis;
    private static readonly CqlValueSet _Injectable_Factor_Xa_Inhibitor_for_VTE_Prophylaxis = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.211", null);

    [CqlValueSetDefinition("INR", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.213", valueSetVersion: null)]
    public CqlValueSet INR(CqlContext _) => _INR;
    private static readonly CqlValueSet _INR = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.213", null);

    [CqlValueSetDefinition("Intensive Care Unit", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1029.206", valueSetVersion: null)]
    public CqlValueSet Intensive_Care_Unit(CqlContext _) => _Intensive_Care_Unit;
    private static readonly CqlValueSet _Intensive_Care_Unit = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1029.206", null);

    [CqlValueSetDefinition("Intermittent pneumatic compression devices", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.214", valueSetVersion: null)]
    public CqlValueSet Intermittent_pneumatic_compression_devices(CqlContext _) => _Intermittent_pneumatic_compression_devices;
    private static readonly CqlValueSet _Intermittent_pneumatic_compression_devices = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.214", null);

    [CqlValueSetDefinition("Intracranial Neurosurgery", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.260", valueSetVersion: null)]
    public CqlValueSet Intracranial_Neurosurgery(CqlContext _) => _Intracranial_Neurosurgery;
    private static readonly CqlValueSet _Intracranial_Neurosurgery = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.260", null);

    [CqlValueSetDefinition("Intravenous route", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.222", valueSetVersion: null)]
    public CqlValueSet Intravenous_route(CqlContext _) => _Intravenous_route;
    private static readonly CqlValueSet _Intravenous_route = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.222", null);

    [CqlValueSetDefinition("Knee Replacement Surgery", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.261", valueSetVersion: null)]
    public CqlValueSet Knee_Replacement_Surgery(CqlContext _) => _Knee_Replacement_Surgery;
    private static readonly CqlValueSet _Knee_Replacement_Surgery = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.261", null);

    [CqlValueSetDefinition("Low Dose Unfractionated Heparin for VTE Prophylaxis", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1045.39", valueSetVersion: null)]
    public CqlValueSet Low_Dose_Unfractionated_Heparin_for_VTE_Prophylaxis(CqlContext _) => _Low_Dose_Unfractionated_Heparin_for_VTE_Prophylaxis;
    private static readonly CqlValueSet _Low_Dose_Unfractionated_Heparin_for_VTE_Prophylaxis = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1045.39", null);

    [CqlValueSetDefinition("Low Molecular Weight Heparin for VTE Prophylaxis", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.219", valueSetVersion: null)]
    public CqlValueSet Low_Molecular_Weight_Heparin_for_VTE_Prophylaxis(CqlContext _) => _Low_Molecular_Weight_Heparin_for_VTE_Prophylaxis;
    private static readonly CqlValueSet _Low_Molecular_Weight_Heparin_for_VTE_Prophylaxis = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.219", null);

    [CqlValueSetDefinition("Low Risk", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.400", valueSetVersion: null)]
    public CqlValueSet Low_Risk(CqlContext _) => _Low_Risk;
    private static readonly CqlValueSet _Low_Risk = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.400", null);

    [CqlValueSetDefinition("Medical Reason For Not Providing Treatment", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.473", valueSetVersion: null)]
    public CqlValueSet Medical_Reason_For_Not_Providing_Treatment(CqlContext _) => _Medical_Reason_For_Not_Providing_Treatment;
    private static readonly CqlValueSet _Medical_Reason_For_Not_Providing_Treatment = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.473", null);

    [CqlValueSetDefinition("Oral Factor Xa Inhibitor for VTE Prophylaxis or VTE Treatment", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.134", valueSetVersion: null)]
    public CqlValueSet Oral_Factor_Xa_Inhibitor_for_VTE_Prophylaxis_or_VTE_Treatment(CqlContext _) => _Oral_Factor_Xa_Inhibitor_for_VTE_Prophylaxis_or_VTE_Treatment;
    private static readonly CqlValueSet _Oral_Factor_Xa_Inhibitor_for_VTE_Prophylaxis_or_VTE_Treatment = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.134", null);

    [CqlValueSetDefinition("Patient Refusal", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.93", valueSetVersion: null)]
    public CqlValueSet Patient_Refusal(CqlContext _) => _Patient_Refusal;
    private static readonly CqlValueSet _Patient_Refusal = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.93", null);

    [CqlValueSetDefinition("Rivaroxaban for VTE Prophylaxis", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1110.50", valueSetVersion: null)]
    public CqlValueSet Rivaroxaban_for_VTE_Prophylaxis(CqlContext _) => _Rivaroxaban_for_VTE_Prophylaxis;
    private static readonly CqlValueSet _Rivaroxaban_for_VTE_Prophylaxis = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1110.50", null);

    [CqlValueSetDefinition("Subcutaneous route", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.223", valueSetVersion: null)]
    public CqlValueSet Subcutaneous_route(CqlContext _) => _Subcutaneous_route;
    private static readonly CqlValueSet _Subcutaneous_route = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.223", null);

    [CqlValueSetDefinition("Unfractionated Heparin", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.218", valueSetVersion: null)]
    public CqlValueSet Unfractionated_Heparin(CqlContext _) => _Unfractionated_Heparin;
    private static readonly CqlValueSet _Unfractionated_Heparin = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.218", null);

    [CqlValueSetDefinition("Urological Surgery", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.272", valueSetVersion: null)]
    public CqlValueSet Urological_Surgery(CqlContext _) => _Urological_Surgery;
    private static readonly CqlValueSet _Urological_Surgery = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.272", null);

    [CqlValueSetDefinition("Venous foot pumps", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.230", valueSetVersion: null)]
    public CqlValueSet Venous_foot_pumps(CqlContext _) => _Venous_foot_pumps;
    private static readonly CqlValueSet _Venous_foot_pumps = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.230", null);

    [CqlValueSetDefinition("Venous Thromboembolism", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.279", valueSetVersion: null)]
    public CqlValueSet Venous_Thromboembolism(CqlContext _) => _Venous_Thromboembolism;
    private static readonly CqlValueSet _Venous_Thromboembolism = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.279", null);

    [CqlValueSetDefinition("Warfarin", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.232", valueSetVersion: null)]
    public CqlValueSet Warfarin(CqlContext _) => _Warfarin;
    private static readonly CqlValueSet _Warfarin = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.232", null);

    #endregion ValueSets

    #region Codes (1)

    [CqlCodeDefinition("Risk for venous thromboembolism", codeId: "72136-5", codeSystem: "http://loinc.org")]
    public CqlCode Risk_for_venous_thromboembolism(CqlContext _) => _Risk_for_venous_thromboembolism;
    private static readonly CqlCode _Risk_for_venous_thromboembolism = new CqlCode("72136-5", "http://loinc.org");

    #endregion Codes

    #region CodeSystems (1)

    [CqlCodeSystemDefinition("LOINC", codeSystemId: "http://loinc.org", codeSystemVersion: null)]
    public CqlCodeSystem LOINC(CqlContext _) => _LOINC;
    private static readonly CqlCodeSystem _LOINC =
      new CqlCodeSystem("http://loinc.org", null, [
          _Risk_for_venous_thromboembolism]);

    #endregion CodeSystems

    #region Parameters (1)

    [CqlParameterDefinition("Measurement Period")]
    public CqlInterval<CqlDateTime> Measurement_Period(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Measurement_Period, Measurement_Period_Compute);

    private const long _cacheIndex_Measurement_Period = 7870025686749396082L;

    private CqlInterval<CqlDateTime> Measurement_Period_Compute(CqlContext context)
    {
        CqlDateTime a_ = context.Operators.DateTime(2026, 1, 1, 0, 0, 0, 0, 0.0m);
        CqlDateTime b_ = context.Operators.DateTime(2027, 1, 1, 0, 0, 0, 0, 0.0m);
        CqlInterval<CqlDateTime> c_ = context.Operators.Interval(a_, b_, true, false);
        object d_ = context.ResolveParameter("CMS190FHIRVTEProphylaxisICU-1.0.000", "Measurement Period", c_);
        return (CqlInterval<CqlDateTime>)d_;
    }


    #endregion Parameters

    #region Functions and Expressions (39)

    [CqlExpressionDefinition("Patient")]
    public Patient Patient(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Patient, Patient_Compute);

    private const long _cacheIndex_Patient = -8381044723386834253L;

    private Patient Patient_Compute(CqlContext context)
    {
        IEnumerable<Patient> a_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-patient"));
        Patient b_ = context.Operators.SingletonFrom<Patient>(a_);
        return b_;
    }


    [CqlExpressionDefinition("SDE Ethnicity")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Ethnicity(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_SDE_Ethnicity, SDE_Ethnicity_Compute);

    private const long _cacheIndex_SDE_Ethnicity = -687536208727671516L;

    private (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Ethnicity_Compute(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? a_ = SupplementalDataElements_5_1_000.Instance.SDE_Ethnicity(context);
        return a_;
    }


    [CqlExpressionDefinition("SDE Payer")]
    public IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> SDE_Payer(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_SDE_Payer, SDE_Payer_Compute);

    private const long _cacheIndex_SDE_Payer = -2376313611401093698L;

    private IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> SDE_Payer_Compute(CqlContext context)
    {
        IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> a_ = SupplementalDataElements_5_1_000.Instance.SDE_Payer(context);
        return a_;
    }


    [CqlExpressionDefinition("SDE Race")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Race(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_SDE_Race, SDE_Race_Compute);

    private const long _cacheIndex_SDE_Race = 3085645595513219099L;

    private (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Race_Compute(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? a_ = SupplementalDataElements_5_1_000.Instance.SDE_Race(context);
        return a_;
    }


    [CqlExpressionDefinition("SDE Sex")]
    public CqlCode SDE_Sex(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_SDE_Sex, SDE_Sex_Compute);

    private const long _cacheIndex_SDE_Sex = 1692989190251153544L;

    private CqlCode SDE_Sex_Compute(CqlContext context)
    {
        CqlCode a_ = SupplementalDataElements_5_1_000.Instance.SDE_Sex(context);
        return a_;
    }


    [CqlExpressionDefinition("Initial Population")]
    public IEnumerable<Encounter> Initial_Population(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Initial_Population, Initial_Population_Compute);

    private const long _cacheIndex_Initial_Population = -3499344969537595747L;

    private IEnumerable<Encounter> Initial_Population_Compute(CqlContext context)
    {
        IEnumerable<Encounter> a_ = VTE_8_18_000.Instance.Encounter_With_Age_Range_And_Without_VTE_Diagnosis_Or_Obstetrical_Conditions(context);
        return a_;
    }


    [CqlExpressionDefinition("Encounter With ICU Location")]
    public IEnumerable<Encounter> Encounter_With_ICU_Location(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Encounter_With_ICU_Location, Encounter_With_ICU_Location_Compute);

    private const long _cacheIndex_Encounter_With_ICU_Location = 371126867746494352L;

    private IEnumerable<Encounter> Encounter_With_ICU_Location_Compute(CqlContext context)
    {
        IEnumerable<Encounter> a_ = VTE_8_18_000.Instance.Encounter_With_Age_Range_And_Without_VTE_Diagnosis_Or_Obstetrical_Conditions(context);

        bool? b_(Encounter QualifyingEncounter) {
            List<Encounter.LocationComponent> d_ = QualifyingEncounter?.Location;

            bool? e_(Encounter.LocationComponent Location) {
                ResourceReference g_ = Location?.Location;
                Location h_ = CQMCommon_4_1_000.Instance.getLocation(context, g_);
                List<CodeableConcept> i_ = h_?.Type;

                CqlConcept j_(CodeableConcept @this) {
                    CqlConcept t_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);
                    return t_;
                }

                IEnumerable<CqlConcept> k_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)i_, j_);
                CqlValueSet l_ = this.Intensive_Care_Unit(context);
                CqlBoolean m_ = context.Operators.ConceptsInValueSet(k_, l_);
                Period n_ = QualifyingEncounter?.Period;
                CqlInterval<CqlDateTime> o_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, n_);
                Period p_ = Location?.Period;
                CqlInterval<CqlDateTime> q_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, p_);
                CqlBoolean r_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(o_, q_, (string)default);
                CqlBoolean s_ = r_;
                return m_
                    /* CQL 'and' (76:9-77:63) */ && s_;
            }

            CqlBoolean f_ = context.Operators.WhereAny<Encounter.LocationComponent>((IEnumerable<Encounter.LocationComponent>)d_, e_);
            return f_;
        }

        IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);
        return c_;
    }


    [CqlExpressionDefinition("Denominator")]
    public IEnumerable<Encounter> Denominator(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Denominator, Denominator_Compute);

    private const long _cacheIndex_Denominator = -7189294931962670376L;

    private IEnumerable<Encounter> Denominator_Compute(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Encounter_With_ICU_Location(context);
        return a_;
    }


    [CqlExpressionDefinition("Encounter With ICU Location And Encounter Less Than 2 Days")]
    public IEnumerable<Encounter> Encounter_With_ICU_Location_And_Encounter_Less_Than_2_Days(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Encounter_With_ICU_Location_And_Encounter_Less_Than_2_Days, Encounter_With_ICU_Location_And_Encounter_Less_Than_2_Days_Compute);

    private const long _cacheIndex_Encounter_With_ICU_Location_And_Encounter_Less_Than_2_Days = 1062799540167415327L;

    private IEnumerable<Encounter> Encounter_With_ICU_Location_And_Encounter_Less_Than_2_Days_Compute(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Encounter_With_ICU_Location(context);

        bool? b_(Encounter QualifyingEncounterICU) {
            Period d_ = QualifyingEncounterICU?.Period;
            CqlInterval<CqlDateTime> e_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, d_);
            int? f_ = CQMCommon_4_1_000.Instance.lengthInDays(context, e_);
            CqlBoolean g_ = context.Operators.Less(f_, 2);
            return g_;
        }

        IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);
        return c_;
    }


    [CqlExpressionDefinition("Encounter With First ICU Stay With Principal Procedure Of Selected Surgery")]
    public IEnumerable<Encounter> Encounter_With_First_ICU_Stay_With_Principal_Procedure_Of_Selected_Surgery(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Encounter_With_First_ICU_Stay_With_Principal_Procedure_Of_Selected_Surgery, Encounter_With_First_ICU_Stay_With_Principal_Procedure_Of_Selected_Surgery_Compute);

    private const long _cacheIndex_Encounter_With_First_ICU_Stay_With_Principal_Procedure_Of_Selected_Surgery = -731136435907162858L;

    private IEnumerable<Encounter> Encounter_With_First_ICU_Stay_With_Principal_Procedure_Of_Selected_Surgery_Compute(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Encounter_With_ICU_Location(context);

        bool? b_(Encounter QualifyingEncounterICU) {
            CqlValueSet d_ = this.General_Surgery(context);
            CqlBoolean e_ = VTE_8_18_000.Instance.hasPrincipalProcedureOf(context, QualifyingEncounterICU, d_);
            CqlValueSet f_ = this.Gynecological_Surgery(context);
            CqlBoolean g_ = VTE_8_18_000.Instance.hasPrincipalProcedureOf(context, QualifyingEncounterICU, f_);
            CqlBoolean h_ = g_;
            CqlValueSet i_ = this.Hip_Fracture_Surgery(context);
            CqlBoolean j_ = VTE_8_18_000.Instance.hasPrincipalProcedureOf(context, QualifyingEncounterICU, i_);
            CqlBoolean k_ = j_;
            CqlValueSet l_ = this.Hip_Replacement_Surgery(context);
            CqlBoolean m_ = VTE_8_18_000.Instance.hasPrincipalProcedureOf(context, QualifyingEncounterICU, l_);
            CqlBoolean n_ = m_;
            CqlValueSet o_ = this.Intracranial_Neurosurgery(context);
            CqlBoolean p_ = VTE_8_18_000.Instance.hasPrincipalProcedureOf(context, QualifyingEncounterICU, o_);
            CqlBoolean q_ = p_;
            CqlValueSet r_ = this.Knee_Replacement_Surgery(context);
            CqlBoolean s_ = VTE_8_18_000.Instance.hasPrincipalProcedureOf(context, QualifyingEncounterICU, r_);
            CqlBoolean t_ = s_;
            CqlValueSet u_ = this.Urological_Surgery(context);
            CqlBoolean v_ = VTE_8_18_000.Instance.hasPrincipalProcedureOf(context, QualifyingEncounterICU, u_);
            CqlBoolean w_ = v_;
            return e_
                /* CQL 'or' (92:11-93:83) */ || h_
                /* CQL 'or' (92:11-94:82) */ || k_
                /* CQL 'or' (92:11-95:85) */ || n_
                /* CQL 'or' (92:11-96:87) */ || q_
                /* CQL 'or' (92:11-97:86) */ || t_
                /* CQL 'or' (92:5-98:80) */ || w_;
        }

        IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);
        return c_;
    }


    [CqlExpressionDefinition("Intervention Comfort Measures")]
    public IEnumerable<object> Intervention_Comfort_Measures(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Intervention_Comfort_Measures, Intervention_Comfort_Measures_Compute);

    private const long _cacheIndex_Intervention_Comfort_Measures = 1032271806106644618L;

    private IEnumerable<object> Intervention_Comfort_Measures_Compute(CqlContext context)
    {
        CqlValueSet a_ = this.Comfort_Measures(context);
        IEnumerable<ServiceRequest> b_ = context.Operators.Retrieve<ServiceRequest>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-servicerequest"));

        bool? c_(ServiceRequest InterventionRequest) {
            Code<RequestIntent> i_ = InterventionRequest?.IntentElement;
            RequestIntent? j_ = i_?.Value;
            Code<RequestIntent> k_ = context.Operators.Convert<Code<RequestIntent>>(j_);
            string l_ = context.Operators.Convert<string>(k_);
            string[] m_ = [
                "order",
                "original-order",
                "reflex-order",
                "filler-order",
                "instance-order",
            ];
            CqlBoolean n_ = context.Operators.In<string>(l_, (IEnumerable<string>)m_);
            Code<RequestStatus> o_ = InterventionRequest?.StatusElement;
            RequestStatus? p_ = o_?.Value;
            Code<RequestStatus> q_ = context.Operators.Convert<Code<RequestStatus>>(p_);
            string r_ = context.Operators.Convert<string>(q_);
            string[] s_ = [
                "active",
                "completed",
            ];
            CqlBoolean t_ = context.Operators.In<string>(r_, (IEnumerable<string>)s_);
            CqlBoolean u_ = t_;
            return n_
                /* CQL 'and' (107:7-108:67) */ && u_;
        }

        IEnumerable<ServiceRequest> d_ = context.Operators.Where<ServiceRequest>(b_, c_);
        IEnumerable<Procedure> e_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));

        bool? f_(Procedure InterventionPerformed) {
            Code<EventStatus> v_ = InterventionPerformed?.StatusElement;
            EventStatus? w_ = v_?.Value;
            string x_ = context.Operators.Convert<string>(w_);
            string[] y_ = [
                "completed",
                "in-progress",
            ];
            CqlBoolean z_ = context.Operators.In<string>(x_, (IEnumerable<string>)y_);
            return z_;
        }

        IEnumerable<Procedure> g_ = context.Operators.Where<Procedure>(e_, f_);
        IEnumerable<object> h_ = context.Operators.Union<object>(d_ as IEnumerable<object>, g_ as IEnumerable<object>);
        return h_;
    }


    [CqlFunctionDefinition("fromDayOfStartOfHospitalizationToDayAfterFirstICU")]
    public CqlInterval<CqlDate> fromDayOfStartOfHospitalizationToDayAfterFirstICU(CqlContext context, Encounter Encounter)
    {
        CqlInterval<CqlDateTime> a_ = CQMCommon_4_1_000.Instance.hospitalizationWithObservation(context, Encounter);
        CqlDateTime b_ = context.Operators.Start(a_);
        CqlDate c_ = context.Operators.DateFrom(b_);
        CqlDateTime d_ = this.startOfFirstICU(context, Encounter);
        CqlDate e_ = context.Operators.DateFrom(d_);
        CqlQuantity f_ = context.Operators.Quantity(1m, "day");
        CqlDate g_ = context.Operators.Add(e_, f_);
        CqlInterval<CqlDate> h_ = context.Operators.Interval(c_, g_, true, true);
        return h_;
    }


    [CqlFunctionDefinition("startOfFirstICU")]
    public CqlDateTime startOfFirstICU(CqlContext context, Encounter Encounter)
    {
        Encounter.LocationComponent a_ = CQMCommon_4_1_000.Instance.firstInpatientIntensiveCareUnit(context, Encounter);
        Period b_ = a_?.Period;
        CqlInterval<CqlDateTime> c_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, b_);
        CqlDateTime d_ = context.Operators.Start(c_);
        return d_;
    }


    [CqlExpressionDefinition("Encounter With Intervention Comfort Measures From Day Of Start Of Hospitalization To Day After First ICU Stay")]
    public IEnumerable<Encounter> Encounter_With_Intervention_Comfort_Measures_From_Day_Of_Start_Of_Hospitalization_To_Day_After_First_ICU_Stay(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Encounter_With_Intervention_Comfort_Measures_From_Day_Of_Start_Of_Hospitalization_To_Day_After_First_ICU_Stay, Encounter_With_Intervention_Comfort_Measures_From_Day_Of_Start_Of_Hospitalization_To_Day_After_First_ICU_Stay_Compute);

    private const long _cacheIndex_Encounter_With_Intervention_Comfort_Measures_From_Day_Of_Start_Of_Hospitalization_To_Day_After_First_ICU_Stay = 5957004299354428122L;

    private IEnumerable<Encounter> Encounter_With_Intervention_Comfort_Measures_From_Day_Of_Start_Of_Hospitalization_To_Day_After_First_ICU_Stay_Compute(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Encounter_With_ICU_Location(context);

        bool? b_(Encounter QualifyingEncounterICU) {
            IEnumerable<object> d_ = this.Intervention_Comfort_Measures(context);

            bool? e_(object ComfortMeasure) {
                object g_;
                object u_ = context.Operators.LateBoundProperty<object>(ComfortMeasure, "performed");
                object v_ = FHIRHelpers_4_4_000.Instance.ToValue(context, u_);
                bool w_ = v_ is CqlDateTime;
                if (w_)
                {
                    g_ = v_ as CqlDateTime;
                }
                else
                {
                    bool x_ = v_ is CqlQuantity;
                    if (x_)
                    {
                        g_ = v_ as CqlQuantity;
                    }
                    else
                    {
                        bool y_ = v_ is CqlInterval<CqlDateTime>;
                        if (y_)
                        {
                            g_ = v_ as CqlInterval<CqlDateTime>;
                        }
                        else
                        {
                            bool z_ = v_ is CqlInterval<CqlQuantity>;
                            if (z_)
                            {
                                g_ = v_ as CqlInterval<CqlQuantity>;
                            }
                            else
                            {
                                g_ = null;
                            }
                        }
                    }
                }
                CqlInterval<CqlDateTime> h_ = QICoreCommon_4_0_000.Instance.toInterval(context, g_);
                CqlDateTime i_ = context.Operators.Start(h_);
                object j_ = context.Operators.LateBoundProperty<object>(ComfortMeasure, "authoredOn");
                CqlDateTime k_ = context.Operators.LateBoundProperty<CqlDateTime>(j_, "value");
                CqlInterval<CqlDate> l_ = this.fromDayOfStartOfHospitalizationToDayAfterFirstICU(context, QualifyingEncounterICU);
                CqlDate m_ = l_?.low;
                CqlDateTime n_ = context.Operators.ConvertDateToDateTime(m_);
                CqlDate o_ = l_?.high;
                CqlDateTime p_ = context.Operators.ConvertDateToDateTime(o_);
                CqlBoolean q_ = l_?.lowClosed;
                CqlBoolean r_ = l_?.highClosed;
                CqlInterval<CqlDateTime> s_ = context.Operators.Interval(n_, p_, q_, r_);
                CqlBoolean t_ = context.Operators.In<CqlDateTime>(i_ ?? k_, s_, "day");
                return t_;
            }

            CqlBoolean f_ = context.Operators.WhereAny<object>(d_, e_);
            return f_;
        }

        IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);
        return c_;
    }


    [CqlExpressionDefinition("Encounter With Intervention Comfort Measures On Day Of Or Day After Procedure")]
    public IEnumerable<Encounter> Encounter_With_Intervention_Comfort_Measures_On_Day_Of_Or_Day_After_Procedure(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Encounter_With_Intervention_Comfort_Measures_On_Day_Of_Or_Day_After_Procedure, Encounter_With_Intervention_Comfort_Measures_On_Day_Of_Or_Day_After_Procedure_Compute);

    private const long _cacheIndex_Encounter_With_Intervention_Comfort_Measures_On_Day_Of_Or_Day_After_Procedure = 1770084755055533059L;

    private IEnumerable<Encounter> Encounter_With_Intervention_Comfort_Measures_On_Day_Of_Or_Day_After_Procedure_Compute(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Encounter_With_ICU_Location(context);
        CqlValueSet b_ = this.General_or_Neuraxial_Anesthesia(context);
        IEnumerable<Procedure> c_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, b_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
        IEnumerable<object> d_ = this.Intervention_Comfort_Measures(context);
        IEnumerable<ValueTuple<Encounter, Procedure, object>> e_ = context.Operators.CrossJoin<Encounter, Procedure, object>(a_, c_, d_);

        (CqlTupleMetadata, Encounter QualifyingEncounterICU, Procedure AnesthesiaProcedure, object ComfortMeasure)? f_(ValueTuple<Encounter, Procedure, object> _valueTuple) {
            (CqlTupleMetadata, Encounter QualifyingEncounterICU, Procedure AnesthesiaProcedure, object ComfortMeasure)? k_ = (CqlTupleMetadata_ENTiROQhSLFcBRSgSOZVGLLAP, _valueTuple.Item1, _valueTuple.Item2, _valueTuple.Item3);
            return k_;
        }


        bool? g_((CqlTupleMetadata, Encounter QualifyingEncounterICU, Procedure AnesthesiaProcedure, object ComfortMeasure)? tuple_gdefgctjcxpzbyfpuogejrgou) {
            Code<EventStatus> l_ = tuple_gdefgctjcxpzbyfpuogejrgou?.AnesthesiaProcedure?.StatusElement;
            EventStatus? m_ = l_?.Value;
            string n_ = context.Operators.Convert<string>(m_);
            CqlBoolean o_ = context.Operators.Equal(n_, "completed");
            object p_;
            DataType bb_ = tuple_gdefgctjcxpzbyfpuogejrgou?.AnesthesiaProcedure?.Performed;
            object bc_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bb_);
            bool bd_ = bc_ is CqlDateTime;
            if (bd_)
            {
                p_ = bc_ as CqlDateTime;
            }
            else
            {
                bool be_ = bc_ is CqlQuantity;
                if (be_)
                {
                    p_ = bc_ as CqlQuantity;
                }
                else
                {
                    bool bf_ = bc_ is CqlInterval<CqlDateTime>;
                    if (bf_)
                    {
                        p_ = bc_ as CqlInterval<CqlDateTime>;
                    }
                    else
                    {
                        bool bg_ = bc_ is CqlInterval<CqlQuantity>;
                        if (bg_)
                        {
                            p_ = bc_ as CqlInterval<CqlQuantity>;
                        }
                        else
                        {
                            p_ = null;
                        }
                    }
                }
            }
            CqlInterval<CqlDateTime> q_ = QICoreCommon_4_0_000.Instance.toInterval(context, p_);
            CqlDateTime r_ = context.Operators.End(q_);
            CqlDateTime s_ = this.startOfFirstICU(context, tuple_gdefgctjcxpzbyfpuogejrgou?.QualifyingEncounterICU);
            CqlQuantity t_ = context.Operators.Quantity(1m, "day");
            CqlDateTime u_ = context.Operators.Add(s_, t_);
            CqlBoolean v_ = context.Operators.SameAs(r_, u_, "day");
            CqlBoolean w_ = v_;
            object x_;
            object bh_ = context.Operators.LateBoundProperty<object>(tuple_gdefgctjcxpzbyfpuogejrgou?.ComfortMeasure, "performed");
            object bi_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bh_);
            bool bj_ = bi_ is CqlDateTime;
            if (bj_)
            {
                x_ = bi_ as CqlDateTime;
            }
            else
            {
                bool bk_ = bi_ is CqlQuantity;
                if (bk_)
                {
                    x_ = bi_ as CqlQuantity;
                }
                else
                {
                    bool bl_ = bi_ is CqlInterval<CqlDateTime>;
                    if (bl_)
                    {
                        x_ = bi_ as CqlInterval<CqlDateTime>;
                    }
                    else
                    {
                        bool bm_ = bi_ is CqlInterval<CqlQuantity>;
                        if (bm_)
                        {
                            x_ = bi_ as CqlInterval<CqlQuantity>;
                        }
                        else
                        {
                            x_ = null;
                        }
                    }
                }
            }
            CqlInterval<CqlDateTime> y_ = QICoreCommon_4_0_000.Instance.toInterval(context, x_);
            CqlDateTime z_ = context.Operators.Start(y_);
            object aa_ = context.Operators.LateBoundProperty<object>(tuple_gdefgctjcxpzbyfpuogejrgou?.ComfortMeasure, "authoredOn");
            CqlDateTime ab_ = context.Operators.LateBoundProperty<CqlDateTime>(aa_, "value");
            object ac_;
            DataType bn_ = tuple_gdefgctjcxpzbyfpuogejrgou?.AnesthesiaProcedure?.Performed;
            object bo_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bn_);
            bool bp_ = bo_ is CqlDateTime;
            if (bp_)
            {
                ac_ = bo_ as CqlDateTime;
            }
            else
            {
                bool bq_ = bo_ is CqlQuantity;
                if (bq_)
                {
                    ac_ = bo_ as CqlQuantity;
                }
                else
                {
                    bool br_ = bo_ is CqlInterval<CqlDateTime>;
                    if (br_)
                    {
                        ac_ = bo_ as CqlInterval<CqlDateTime>;
                    }
                    else
                    {
                        bool bs_ = bo_ is CqlInterval<CqlQuantity>;
                        if (bs_)
                        {
                            ac_ = bo_ as CqlInterval<CqlQuantity>;
                        }
                        else
                        {
                            ac_ = null;
                        }
                    }
                }
            }
            CqlInterval<CqlDateTime> ad_ = QICoreCommon_4_0_000.Instance.toInterval(context, ac_);
            CqlDateTime ae_ = context.Operators.End(ad_);
            CqlInterval<CqlDate> af_ = TJCOverall_8_25_000.Instance.calendarDayOfOrDayAfter(context, ae_);
            CqlDate ag_ = af_?.low;
            CqlDateTime ah_ = context.Operators.ConvertDateToDateTime(ag_);
            object ai_;
            DataType bt_ = tuple_gdefgctjcxpzbyfpuogejrgou?.AnesthesiaProcedure?.Performed;
            object bu_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bt_);
            bool bv_ = bu_ is CqlDateTime;
            if (bv_)
            {
                ai_ = bu_ as CqlDateTime;
            }
            else
            {
                bool bw_ = bu_ is CqlQuantity;
                if (bw_)
                {
                    ai_ = bu_ as CqlQuantity;
                }
                else
                {
                    bool bx_ = bu_ is CqlInterval<CqlDateTime>;
                    if (bx_)
                    {
                        ai_ = bu_ as CqlInterval<CqlDateTime>;
                    }
                    else
                    {
                        bool by_ = bu_ is CqlInterval<CqlQuantity>;
                        if (by_)
                        {
                            ai_ = bu_ as CqlInterval<CqlQuantity>;
                        }
                        else
                        {
                            ai_ = null;
                        }
                    }
                }
            }
            CqlInterval<CqlDateTime> aj_ = QICoreCommon_4_0_000.Instance.toInterval(context, ai_);
            CqlDateTime ak_ = context.Operators.End(aj_);
            CqlInterval<CqlDate> al_ = TJCOverall_8_25_000.Instance.calendarDayOfOrDayAfter(context, ak_);
            CqlDate am_ = al_?.high;
            CqlDateTime an_ = context.Operators.ConvertDateToDateTime(am_);
            object ao_;
            DataType bz_ = tuple_gdefgctjcxpzbyfpuogejrgou?.AnesthesiaProcedure?.Performed;
            object ca_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bz_);
            bool cb_ = ca_ is CqlDateTime;
            if (cb_)
            {
                ao_ = ca_ as CqlDateTime;
            }
            else
            {
                bool cc_ = ca_ is CqlQuantity;
                if (cc_)
                {
                    ao_ = ca_ as CqlQuantity;
                }
                else
                {
                    bool cd_ = ca_ is CqlInterval<CqlDateTime>;
                    if (cd_)
                    {
                        ao_ = ca_ as CqlInterval<CqlDateTime>;
                    }
                    else
                    {
                        bool ce_ = ca_ is CqlInterval<CqlQuantity>;
                        if (ce_)
                        {
                            ao_ = ca_ as CqlInterval<CqlQuantity>;
                        }
                        else
                        {
                            ao_ = null;
                        }
                    }
                }
            }
            CqlInterval<CqlDateTime> ap_ = QICoreCommon_4_0_000.Instance.toInterval(context, ao_);
            CqlDateTime aq_ = context.Operators.End(ap_);
            CqlInterval<CqlDate> ar_ = TJCOverall_8_25_000.Instance.calendarDayOfOrDayAfter(context, aq_);
            CqlBoolean as_ = ar_?.lowClosed;
            object at_;
            DataType cf_ = tuple_gdefgctjcxpzbyfpuogejrgou?.AnesthesiaProcedure?.Performed;
            object cg_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cf_);
            bool ch_ = cg_ is CqlDateTime;
            if (ch_)
            {
                at_ = cg_ as CqlDateTime;
            }
            else
            {
                bool ci_ = cg_ is CqlQuantity;
                if (ci_)
                {
                    at_ = cg_ as CqlQuantity;
                }
                else
                {
                    bool cj_ = cg_ is CqlInterval<CqlDateTime>;
                    if (cj_)
                    {
                        at_ = cg_ as CqlInterval<CqlDateTime>;
                    }
                    else
                    {
                        bool ck_ = cg_ is CqlInterval<CqlQuantity>;
                        if (ck_)
                        {
                            at_ = cg_ as CqlInterval<CqlQuantity>;
                        }
                        else
                        {
                            at_ = null;
                        }
                    }
                }
            }
            CqlInterval<CqlDateTime> au_ = QICoreCommon_4_0_000.Instance.toInterval(context, at_);
            CqlDateTime av_ = context.Operators.End(au_);
            CqlInterval<CqlDate> aw_ = TJCOverall_8_25_000.Instance.calendarDayOfOrDayAfter(context, av_);
            CqlBoolean ax_ = aw_?.highClosed;
            CqlInterval<CqlDateTime> ay_ = context.Operators.Interval(ah_, an_, as_, ax_);
            CqlBoolean az_ = context.Operators.In<CqlDateTime>(z_ ?? ab_, ay_, "day");
            CqlBoolean ba_ = az_;
            return o_
                /* CQL 'and' (119:11-120:121) */ && w_
                /* CQL 'and' (119:5-121:191) */ && ba_;
        }

        IEnumerable<(CqlTupleMetadata, Encounter QualifyingEncounterICU, Procedure AnesthesiaProcedure, object ComfortMeasure)?> h_ = context.Operators.SelectWhere<ValueTuple<Encounter, Procedure, object>, (CqlTupleMetadata, Encounter QualifyingEncounterICU, Procedure AnesthesiaProcedure, object ComfortMeasure)?>(e_, f_, g_);
        Encounter i_((CqlTupleMetadata, Encounter QualifyingEncounterICU, Procedure AnesthesiaProcedure, object ComfortMeasure)? tuple_gdefgctjcxpzbyfpuogejrgou) => tuple_gdefgctjcxpzbyfpuogejrgou?.QualifyingEncounterICU;
        IEnumerable<Encounter> j_ = context.Operators.SelectDistinct<(CqlTupleMetadata, Encounter QualifyingEncounterICU, Procedure AnesthesiaProcedure, object ComfortMeasure)?, Encounter>(h_, i_);
        return j_;
    }


    [CqlExpressionDefinition("Denominator Exclusions")]
    public IEnumerable<Encounter> Denominator_Exclusions(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Denominator_Exclusions, Denominator_Exclusions_Compute);

    private const long _cacheIndex_Denominator_Exclusions = 7905144851696203612L;

    private IEnumerable<Encounter> Denominator_Exclusions_Compute(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Encounter_With_ICU_Location_And_Encounter_Less_Than_2_Days(context);
        IEnumerable<Encounter> b_ = this.Encounter_With_First_ICU_Stay_With_Principal_Procedure_Of_Selected_Surgery(context);
        IEnumerable<Encounter> c_ = context.Operators.Union<Encounter>(a_, b_);
        IEnumerable<Encounter> d_ = this.Encounter_With_Intervention_Comfort_Measures_From_Day_Of_Start_Of_Hospitalization_To_Day_After_First_ICU_Stay(context);
        IEnumerable<Encounter> e_ = this.Encounter_With_Intervention_Comfort_Measures_On_Day_Of_Or_Day_After_Procedure(context);
        IEnumerable<Encounter> f_ = context.Operators.Union<Encounter>(d_, e_);
        IEnumerable<Encounter> g_ = context.Operators.Union<Encounter>(c_, f_);
        return g_;
    }


    [CqlExpressionDefinition("Pharmacological Or Mechanical VTE Prophylaxis Received")]
    public IEnumerable<object> Pharmacological_Or_Mechanical_VTE_Prophylaxis_Received(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Pharmacological_Or_Mechanical_VTE_Prophylaxis_Received, Pharmacological_Or_Mechanical_VTE_Prophylaxis_Received_Compute);

    private const long _cacheIndex_Pharmacological_Or_Mechanical_VTE_Prophylaxis_Received = 7233685934987223083L;

    private IEnumerable<object> Pharmacological_Or_Mechanical_VTE_Prophylaxis_Received_Compute(CqlContext context)
    {
        IEnumerable<MedicationAdministration> a_ = context.Operators.Retrieve<MedicationAdministration>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationadministration"));

        bool? b_(MedicationAdministration MR) {
            IEnumerable<Medication> az_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));

            bool? ba_(Medication M) {
                object bc_ = context.Operators.LateBoundProperty<object>(M, "id.value");
                object bd_ = context.Operators.LateBoundProperty<object>(MR, "medication.reference.value");
                IEnumerable<string> be_ = context.Operators.Split((string)bd_, "/");
                string bf_ = context.Operators.Last<string>(be_);
                CqlBoolean bg_ = context.Operators.Equal(bc_, bf_);
                CodeableConcept bh_ = M?.Code;
                CqlConcept bi_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, bh_);
                CqlValueSet bj_ = this.Low_Dose_Unfractionated_Heparin_for_VTE_Prophylaxis(context);
                CqlBoolean bk_ = context.Operators.ConceptInValueSet(bi_, bj_);
                CqlBoolean bl_ = bk_;
                return bg_
                    /* CQL 'and' */ && bl_;
            }

            CqlBoolean bb_ = context.Operators.WhereAny<Medication>(az_, ba_);
            return bb_;
        }

        IEnumerable<MedicationAdministration> c_ = context.Operators.Where<MedicationAdministration>(a_, b_);
        CqlValueSet d_ = this.Low_Dose_Unfractionated_Heparin_for_VTE_Prophylaxis(context);
        IEnumerable<MedicationAdministration> e_ = context.Operators.Retrieve<MedicationAdministration>(new RetrieveParameters(default, d_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationadministration"));
        IEnumerable<MedicationAdministration> f_ = context.Operators.Union<MedicationAdministration>(c_, e_);

        bool? g_(MedicationAdministration VTEMedication) {
            Code<MedicationAdministration.MedicationAdministrationStatusCodes> bm_ = VTEMedication?.StatusElement;
            MedicationAdministration.MedicationAdministrationStatusCodes? bn_ = bm_?.Value;
            string bo_ = context.Operators.Convert<string>(bn_);
            CqlBoolean bp_ = context.Operators.Equal(bo_, "completed");
            MedicationAdministration.DosageComponent bq_ = VTEMedication?.Dosage;
            CodeableConcept br_ = bq_?.Route;
            CqlConcept bs_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, br_);
            CqlValueSet bt_ = this.Subcutaneous_route(context);
            CqlBoolean bu_ = context.Operators.ConceptInValueSet(bs_, bt_);
            CqlBoolean bv_ = bu_;
            return bp_
                /* CQL 'and' (137:7-138:62) */ && bv_;
        }

        IEnumerable<MedicationAdministration> h_ = context.Operators.Where<MedicationAdministration>(f_, g_);

        bool? i_(MedicationAdministration MR) {
            IEnumerable<Medication> bw_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));

            bool? bx_(Medication M) {
                object bz_ = context.Operators.LateBoundProperty<object>(M, "id.value");
                object ca_ = context.Operators.LateBoundProperty<object>(MR, "medication.reference.value");
                IEnumerable<string> cb_ = context.Operators.Split((string)ca_, "/");
                string cc_ = context.Operators.Last<string>(cb_);
                CqlBoolean cd_ = context.Operators.Equal(bz_, cc_);
                CodeableConcept ce_ = M?.Code;
                CqlConcept cf_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, ce_);
                CqlValueSet cg_ = this.Low_Molecular_Weight_Heparin_for_VTE_Prophylaxis(context);
                CqlBoolean ch_ = context.Operators.ConceptInValueSet(cf_, cg_);
                CqlBoolean ci_ = ch_;
                return cd_
                    /* CQL 'and' */ && ci_;
            }

            CqlBoolean by_ = context.Operators.WhereAny<Medication>(bw_, bx_);
            return by_;
        }

        IEnumerable<MedicationAdministration> j_ = context.Operators.Where<MedicationAdministration>(a_, i_);
        CqlValueSet k_ = this.Low_Molecular_Weight_Heparin_for_VTE_Prophylaxis(context);
        IEnumerable<MedicationAdministration> l_ = context.Operators.Retrieve<MedicationAdministration>(new RetrieveParameters(default, k_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationadministration"));
        IEnumerable<MedicationAdministration> m_ = context.Operators.Union<MedicationAdministration>(j_, l_);

        bool? n_(MedicationAdministration LMWH) {
            Code<MedicationAdministration.MedicationAdministrationStatusCodes> cj_ = LMWH?.StatusElement;
            MedicationAdministration.MedicationAdministrationStatusCodes? ck_ = cj_?.Value;
            string cl_ = context.Operators.Convert<string>(ck_);
            CqlBoolean cm_ = context.Operators.Equal(cl_, "completed");
            return cm_;
        }

        IEnumerable<MedicationAdministration> o_ = context.Operators.Where<MedicationAdministration>(m_, n_);
        IEnumerable<MedicationAdministration> p_ = context.Operators.Union<MedicationAdministration>(h_, o_);

        bool? q_(MedicationAdministration MR) {
            IEnumerable<Medication> cn_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));

            bool? co_(Medication M) {
                object cq_ = context.Operators.LateBoundProperty<object>(M, "id.value");
                object cr_ = context.Operators.LateBoundProperty<object>(MR, "medication.reference.value");
                IEnumerable<string> cs_ = context.Operators.Split((string)cr_, "/");
                string ct_ = context.Operators.Last<string>(cs_);
                CqlBoolean cu_ = context.Operators.Equal(cq_, ct_);
                CodeableConcept cv_ = M?.Code;
                CqlConcept cw_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, cv_);
                CqlValueSet cx_ = this.Injectable_Factor_Xa_Inhibitor_for_VTE_Prophylaxis(context);
                CqlBoolean cy_ = context.Operators.ConceptInValueSet(cw_, cx_);
                CqlBoolean cz_ = cy_;
                return cu_
                    /* CQL 'and' */ && cz_;
            }

            CqlBoolean cp_ = context.Operators.WhereAny<Medication>(cn_, co_);
            return cp_;
        }

        IEnumerable<MedicationAdministration> r_ = context.Operators.Where<MedicationAdministration>(a_, q_);
        CqlValueSet s_ = this.Injectable_Factor_Xa_Inhibitor_for_VTE_Prophylaxis(context);
        IEnumerable<MedicationAdministration> t_ = context.Operators.Retrieve<MedicationAdministration>(new RetrieveParameters(default, s_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationadministration"));
        IEnumerable<MedicationAdministration> u_ = context.Operators.Union<MedicationAdministration>(r_, t_);

        bool? v_(MedicationAdministration FactorXa) {
            Code<MedicationAdministration.MedicationAdministrationStatusCodes> da_ = FactorXa?.StatusElement;
            MedicationAdministration.MedicationAdministrationStatusCodes? db_ = da_?.Value;
            string dc_ = context.Operators.Convert<string>(db_);
            CqlBoolean dd_ = context.Operators.Equal(dc_, "completed");
            return dd_;
        }

        IEnumerable<MedicationAdministration> w_ = context.Operators.Where<MedicationAdministration>(u_, v_);

        bool? x_(MedicationAdministration MR) {
            IEnumerable<Medication> de_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));

            bool? df_(Medication M) {
                object dh_ = context.Operators.LateBoundProperty<object>(M, "id.value");
                object di_ = context.Operators.LateBoundProperty<object>(MR, "medication.reference.value");
                IEnumerable<string> dj_ = context.Operators.Split((string)di_, "/");
                string dk_ = context.Operators.Last<string>(dj_);
                CqlBoolean dl_ = context.Operators.Equal(dh_, dk_);
                CodeableConcept dm_ = M?.Code;
                CqlConcept dn_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, dm_);
                CqlValueSet do_ = this.Warfarin(context);
                CqlBoolean dp_ = context.Operators.ConceptInValueSet(dn_, do_);
                CqlBoolean dq_ = dp_;
                return dl_
                    /* CQL 'and' */ && dq_;
            }

            CqlBoolean dg_ = context.Operators.WhereAny<Medication>(de_, df_);
            return dg_;
        }

        IEnumerable<MedicationAdministration> y_ = context.Operators.Where<MedicationAdministration>(a_, x_);
        CqlValueSet z_ = this.Warfarin(context);
        IEnumerable<MedicationAdministration> aa_ = context.Operators.Retrieve<MedicationAdministration>(new RetrieveParameters(default, z_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationadministration"));
        IEnumerable<MedicationAdministration> ab_ = context.Operators.Union<MedicationAdministration>(y_, aa_);

        bool? ac_(MedicationAdministration WarfarinAdm) {
            Code<MedicationAdministration.MedicationAdministrationStatusCodes> dr_ = WarfarinAdm?.StatusElement;
            MedicationAdministration.MedicationAdministrationStatusCodes? ds_ = dr_?.Value;
            string dt_ = context.Operators.Convert<string>(ds_);
            CqlBoolean du_ = context.Operators.Equal(dt_, "completed");
            return du_;
        }

        IEnumerable<MedicationAdministration> ad_ = context.Operators.Where<MedicationAdministration>(ab_, ac_);
        IEnumerable<MedicationAdministration> ae_ = context.Operators.Union<MedicationAdministration>(w_, ad_);
        IEnumerable<MedicationAdministration> af_ = context.Operators.Union<MedicationAdministration>(p_, ae_);

        bool? ag_(MedicationAdministration MR) {
            IEnumerable<Medication> dv_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));

            bool? dw_(Medication M) {
                object dy_ = context.Operators.LateBoundProperty<object>(M, "id.value");
                object dz_ = context.Operators.LateBoundProperty<object>(MR, "medication.reference.value");
                IEnumerable<string> ea_ = context.Operators.Split((string)dz_, "/");
                string eb_ = context.Operators.Last<string>(ea_);
                CqlBoolean ec_ = context.Operators.Equal(dy_, eb_);
                CodeableConcept ed_ = M?.Code;
                CqlConcept ee_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, ed_);
                CqlValueSet ef_ = this.Rivaroxaban_for_VTE_Prophylaxis(context);
                CqlBoolean eg_ = context.Operators.ConceptInValueSet(ee_, ef_);
                CqlBoolean eh_ = eg_;
                return ec_
                    /* CQL 'and' */ && eh_;
            }

            CqlBoolean dx_ = context.Operators.WhereAny<Medication>(dv_, dw_);
            return dx_;
        }

        IEnumerable<MedicationAdministration> ah_ = context.Operators.Where<MedicationAdministration>(a_, ag_);
        CqlValueSet ai_ = this.Rivaroxaban_for_VTE_Prophylaxis(context);
        IEnumerable<MedicationAdministration> aj_ = context.Operators.Retrieve<MedicationAdministration>(new RetrieveParameters(default, ai_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationadministration"));
        IEnumerable<MedicationAdministration> ak_ = context.Operators.Union<MedicationAdministration>(ah_, aj_);

        bool? al_(MedicationAdministration Rivaroxaban) {
            Code<MedicationAdministration.MedicationAdministrationStatusCodes> ei_ = Rivaroxaban?.StatusElement;
            MedicationAdministration.MedicationAdministrationStatusCodes? ej_ = ei_?.Value;
            string ek_ = context.Operators.Convert<string>(ej_);
            CqlBoolean el_ = context.Operators.Equal(ek_, "completed");
            return el_;
        }

        IEnumerable<MedicationAdministration> am_ = context.Operators.Where<MedicationAdministration>(ak_, al_);
        CqlValueSet an_ = this.Application_of_Intermittent_Pneumatic_Compression_Devices(context);
        IEnumerable<Procedure> ao_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, an_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
        CqlValueSet ap_ = this.Application_of_Venous_Foot_Pumps(context);
        IEnumerable<Procedure> aq_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, ap_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
        IEnumerable<Procedure> ar_ = context.Operators.Union<Procedure>(ao_, aq_);
        CqlValueSet as_ = this.Application_of_Graduated_Compression_Stockings(context);
        IEnumerable<Procedure> at_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, as_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
        IEnumerable<Procedure> au_ = context.Operators.Union<Procedure>(ar_, at_);

        bool? av_(Procedure DeviceApplied) {
            Code<EventStatus> em_ = DeviceApplied?.StatusElement;
            EventStatus? en_ = em_?.Value;
            string eo_ = context.Operators.Convert<string>(en_);
            CqlBoolean ep_ = context.Operators.Equal(eo_, "completed");
            return ep_;
        }

        IEnumerable<Procedure> aw_ = context.Operators.Where<Procedure>(au_, av_);
        IEnumerable<object> ax_ = context.Operators.Union<object>(am_ as IEnumerable<object>, aw_ as IEnumerable<object>);
        IEnumerable<object> ay_ = context.Operators.Union<object>(af_ as IEnumerable<object>, ax_ as IEnumerable<object>);
        return ay_;
    }


    [CqlExpressionDefinition("Encounter With VTE Prophylaxis Received On Day Of Or Day After First ICU Stay Or Procedure")]
    public IEnumerable<Encounter> Encounter_With_VTE_Prophylaxis_Received_On_Day_Of_Or_Day_After_First_ICU_Stay_Or_Procedure(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Encounter_With_VTE_Prophylaxis_Received_On_Day_Of_Or_Day_After_First_ICU_Stay_Or_Procedure, Encounter_With_VTE_Prophylaxis_Received_On_Day_Of_Or_Day_After_First_ICU_Stay_Or_Procedure_Compute);

    private const long _cacheIndex_Encounter_With_VTE_Prophylaxis_Received_On_Day_Of_Or_Day_After_First_ICU_Stay_Or_Procedure = -7598193577679081823L;

    private IEnumerable<Encounter> Encounter_With_VTE_Prophylaxis_Received_On_Day_Of_Or_Day_After_First_ICU_Stay_Or_Procedure_Compute(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Encounter_With_ICU_Location(context);

        bool? b_(Encounter QualifyingEncounterICU) {
            IEnumerable<object> n_ = this.Pharmacological_Or_Mechanical_VTE_Prophylaxis_Received(context);

            bool? o_(object VTEProphylaxis) {
                object q_ = context.Operators.LateBoundProperty<object>(VTEProphylaxis, "effective");
                object r_ = FHIRHelpers_4_4_000.Instance.ToValue(context, q_);
                CqlInterval<CqlDateTime> s_ = QICoreCommon_4_0_000.Instance.toInterval(context, r_);
                object t_;
                object ag_ = context.Operators.LateBoundProperty<object>(VTEProphylaxis, "performed");
                object ah_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ag_);
                bool ai_ = ah_ is CqlDateTime;
                if (ai_)
                {
                    t_ = ah_ as CqlDateTime;
                }
                else
                {
                    bool aj_ = ah_ is CqlQuantity;
                    if (aj_)
                    {
                        t_ = ah_ as CqlQuantity;
                    }
                    else
                    {
                        bool ak_ = ah_ is CqlInterval<CqlDateTime>;
                        if (ak_)
                        {
                            t_ = ah_ as CqlInterval<CqlDateTime>;
                        }
                        else
                        {
                            bool al_ = ah_ is CqlInterval<CqlQuantity>;
                            if (al_)
                            {
                                t_ = ah_ as CqlInterval<CqlQuantity>;
                            }
                            else
                            {
                                t_ = null;
                            }
                        }
                    }
                }
                CqlInterval<CqlDateTime> u_ = QICoreCommon_4_0_000.Instance.toInterval(context, t_);
                CqlDateTime v_ = context.Operators.Start(s_ ?? u_);
                CqlDateTime w_ = this.startOfFirstICU(context, QualifyingEncounterICU);
                CqlInterval<CqlDate> x_ = TJCOverall_8_25_000.Instance.calendarDayOfOrDayAfter(context, w_);
                CqlDate y_ = x_?.low;
                CqlDateTime z_ = context.Operators.ConvertDateToDateTime(y_);
                CqlDate aa_ = x_?.high;
                CqlDateTime ab_ = context.Operators.ConvertDateToDateTime(aa_);
                CqlBoolean ac_ = x_?.lowClosed;
                CqlBoolean ad_ = x_?.highClosed;
                CqlInterval<CqlDateTime> ae_ = context.Operators.Interval(z_, ab_, ac_, ad_);
                CqlBoolean af_ = context.Operators.In<CqlDateTime>(v_, ae_, "day");
                return af_;
            }

            CqlBoolean p_ = context.Operators.WhereAny<object>(n_, o_);
            return p_;
        }

        IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);
        CqlValueSet d_ = this.General_or_Neuraxial_Anesthesia(context);
        IEnumerable<Procedure> e_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, d_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
        IEnumerable<object> f_ = this.Pharmacological_Or_Mechanical_VTE_Prophylaxis_Received(context);
        IEnumerable<ValueTuple<Encounter, Procedure, object>> g_ = context.Operators.CrossJoin<Encounter, Procedure, object>(a_, e_, f_);

        (CqlTupleMetadata, Encounter QualifyingEncounterICU, Procedure AnesthesiaProcedure, object VTEProphylaxis)? h_(ValueTuple<Encounter, Procedure, object> _valueTuple) {
            (CqlTupleMetadata, Encounter QualifyingEncounterICU, Procedure AnesthesiaProcedure, object VTEProphylaxis)? am_ = (CqlTupleMetadata_CGYAgYdKXUHcFINAPjMZNihh, _valueTuple.Item1, _valueTuple.Item2, _valueTuple.Item3);
            return am_;
        }


        bool? i_((CqlTupleMetadata, Encounter QualifyingEncounterICU, Procedure AnesthesiaProcedure, object VTEProphylaxis)? tuple_drnlhywkgwmzdeyzybtiilbhf) {
            Code<EventStatus> an_ = tuple_drnlhywkgwmzdeyzybtiilbhf?.AnesthesiaProcedure?.StatusElement;
            EventStatus? ao_ = an_?.Value;
            string ap_ = context.Operators.Convert<string>(ao_);
            CqlBoolean aq_ = context.Operators.Equal(ap_, "completed");
            object ar_;
            DataType ce_ = tuple_drnlhywkgwmzdeyzybtiilbhf?.AnesthesiaProcedure?.Performed;
            object cf_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ce_);
            bool cg_ = cf_ is CqlDateTime;
            if (cg_)
            {
                ar_ = cf_ as CqlDateTime;
            }
            else
            {
                bool ch_ = cf_ is CqlQuantity;
                if (ch_)
                {
                    ar_ = cf_ as CqlQuantity;
                }
                else
                {
                    bool ci_ = cf_ is CqlInterval<CqlDateTime>;
                    if (ci_)
                    {
                        ar_ = cf_ as CqlInterval<CqlDateTime>;
                    }
                    else
                    {
                        bool cj_ = cf_ is CqlInterval<CqlQuantity>;
                        if (cj_)
                        {
                            ar_ = cf_ as CqlInterval<CqlQuantity>;
                        }
                        else
                        {
                            ar_ = null;
                        }
                    }
                }
            }
            CqlInterval<CqlDateTime> as_ = QICoreCommon_4_0_000.Instance.toInterval(context, ar_);
            CqlDateTime at_ = context.Operators.End(as_);
            CqlDateTime au_ = this.startOfFirstICU(context, tuple_drnlhywkgwmzdeyzybtiilbhf?.QualifyingEncounterICU);
            CqlQuantity av_ = context.Operators.Quantity(1m, "day");
            CqlDateTime aw_ = context.Operators.Add(au_, av_);
            CqlBoolean ax_ = context.Operators.SameAs(at_, aw_, "day");
            CqlBoolean ay_ = ax_;
            object az_ = context.Operators.LateBoundProperty<object>(tuple_drnlhywkgwmzdeyzybtiilbhf?.VTEProphylaxis, "effective");
            object ba_ = FHIRHelpers_4_4_000.Instance.ToValue(context, az_);
            CqlInterval<CqlDateTime> bb_ = QICoreCommon_4_0_000.Instance.toInterval(context, ba_);
            object bc_;
            object ck_ = context.Operators.LateBoundProperty<object>(tuple_drnlhywkgwmzdeyzybtiilbhf?.VTEProphylaxis, "performed");
            object cl_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ck_);
            bool cm_ = cl_ is CqlDateTime;
            if (cm_)
            {
                bc_ = cl_ as CqlDateTime;
            }
            else
            {
                bool cn_ = cl_ is CqlQuantity;
                if (cn_)
                {
                    bc_ = cl_ as CqlQuantity;
                }
                else
                {
                    bool co_ = cl_ is CqlInterval<CqlDateTime>;
                    if (co_)
                    {
                        bc_ = cl_ as CqlInterval<CqlDateTime>;
                    }
                    else
                    {
                        bool cp_ = cl_ is CqlInterval<CqlQuantity>;
                        if (cp_)
                        {
                            bc_ = cl_ as CqlInterval<CqlQuantity>;
                        }
                        else
                        {
                            bc_ = null;
                        }
                    }
                }
            }
            CqlInterval<CqlDateTime> bd_ = QICoreCommon_4_0_000.Instance.toInterval(context, bc_);
            CqlDateTime be_ = context.Operators.Start(bb_ ?? bd_);
            object bf_;
            DataType cq_ = tuple_drnlhywkgwmzdeyzybtiilbhf?.AnesthesiaProcedure?.Performed;
            object cr_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cq_);
            bool cs_ = cr_ is CqlDateTime;
            if (cs_)
            {
                bf_ = cr_ as CqlDateTime;
            }
            else
            {
                bool ct_ = cr_ is CqlQuantity;
                if (ct_)
                {
                    bf_ = cr_ as CqlQuantity;
                }
                else
                {
                    bool cu_ = cr_ is CqlInterval<CqlDateTime>;
                    if (cu_)
                    {
                        bf_ = cr_ as CqlInterval<CqlDateTime>;
                    }
                    else
                    {
                        bool cv_ = cr_ is CqlInterval<CqlQuantity>;
                        if (cv_)
                        {
                            bf_ = cr_ as CqlInterval<CqlQuantity>;
                        }
                        else
                        {
                            bf_ = null;
                        }
                    }
                }
            }
            CqlInterval<CqlDateTime> bg_ = QICoreCommon_4_0_000.Instance.toInterval(context, bf_);
            CqlDateTime bh_ = context.Operators.End(bg_);
            CqlInterval<CqlDate> bi_ = TJCOverall_8_25_000.Instance.calendarDayOfOrDayAfter(context, bh_);
            CqlDate bj_ = bi_?.low;
            CqlDateTime bk_ = context.Operators.ConvertDateToDateTime(bj_);
            object bl_;
            DataType cw_ = tuple_drnlhywkgwmzdeyzybtiilbhf?.AnesthesiaProcedure?.Performed;
            object cx_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cw_);
            bool cy_ = cx_ is CqlDateTime;
            if (cy_)
            {
                bl_ = cx_ as CqlDateTime;
            }
            else
            {
                bool cz_ = cx_ is CqlQuantity;
                if (cz_)
                {
                    bl_ = cx_ as CqlQuantity;
                }
                else
                {
                    bool da_ = cx_ is CqlInterval<CqlDateTime>;
                    if (da_)
                    {
                        bl_ = cx_ as CqlInterval<CqlDateTime>;
                    }
                    else
                    {
                        bool db_ = cx_ is CqlInterval<CqlQuantity>;
                        if (db_)
                        {
                            bl_ = cx_ as CqlInterval<CqlQuantity>;
                        }
                        else
                        {
                            bl_ = null;
                        }
                    }
                }
            }
            CqlInterval<CqlDateTime> bm_ = QICoreCommon_4_0_000.Instance.toInterval(context, bl_);
            CqlDateTime bn_ = context.Operators.End(bm_);
            CqlInterval<CqlDate> bo_ = TJCOverall_8_25_000.Instance.calendarDayOfOrDayAfter(context, bn_);
            CqlDate bp_ = bo_?.high;
            CqlDateTime bq_ = context.Operators.ConvertDateToDateTime(bp_);
            object br_;
            DataType dc_ = tuple_drnlhywkgwmzdeyzybtiilbhf?.AnesthesiaProcedure?.Performed;
            object dd_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dc_);
            bool de_ = dd_ is CqlDateTime;
            if (de_)
            {
                br_ = dd_ as CqlDateTime;
            }
            else
            {
                bool df_ = dd_ is CqlQuantity;
                if (df_)
                {
                    br_ = dd_ as CqlQuantity;
                }
                else
                {
                    bool dg_ = dd_ is CqlInterval<CqlDateTime>;
                    if (dg_)
                    {
                        br_ = dd_ as CqlInterval<CqlDateTime>;
                    }
                    else
                    {
                        bool dh_ = dd_ is CqlInterval<CqlQuantity>;
                        if (dh_)
                        {
                            br_ = dd_ as CqlInterval<CqlQuantity>;
                        }
                        else
                        {
                            br_ = null;
                        }
                    }
                }
            }
            CqlInterval<CqlDateTime> bs_ = QICoreCommon_4_0_000.Instance.toInterval(context, br_);
            CqlDateTime bt_ = context.Operators.End(bs_);
            CqlInterval<CqlDate> bu_ = TJCOverall_8_25_000.Instance.calendarDayOfOrDayAfter(context, bt_);
            CqlBoolean bv_ = bu_?.lowClosed;
            object bw_;
            DataType di_ = tuple_drnlhywkgwmzdeyzybtiilbhf?.AnesthesiaProcedure?.Performed;
            object dj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, di_);
            bool dk_ = dj_ is CqlDateTime;
            if (dk_)
            {
                bw_ = dj_ as CqlDateTime;
            }
            else
            {
                bool dl_ = dj_ is CqlQuantity;
                if (dl_)
                {
                    bw_ = dj_ as CqlQuantity;
                }
                else
                {
                    bool dm_ = dj_ is CqlInterval<CqlDateTime>;
                    if (dm_)
                    {
                        bw_ = dj_ as CqlInterval<CqlDateTime>;
                    }
                    else
                    {
                        bool dn_ = dj_ is CqlInterval<CqlQuantity>;
                        if (dn_)
                        {
                            bw_ = dj_ as CqlInterval<CqlQuantity>;
                        }
                        else
                        {
                            bw_ = null;
                        }
                    }
                }
            }
            CqlInterval<CqlDateTime> bx_ = QICoreCommon_4_0_000.Instance.toInterval(context, bw_);
            CqlDateTime by_ = context.Operators.End(bx_);
            CqlInterval<CqlDate> bz_ = TJCOverall_8_25_000.Instance.calendarDayOfOrDayAfter(context, by_);
            CqlBoolean ca_ = bz_?.highClosed;
            CqlInterval<CqlDateTime> cb_ = context.Operators.Interval(bk_, bq_, bv_, ca_);
            CqlBoolean cc_ = context.Operators.In<CqlDateTime>(be_, cb_, "day");
            CqlBoolean cd_ = cc_;
            return aq_
                /* CQL 'and' (167:15-168:125) */ && ay_
                /* CQL 'and' (167:9-169:207) */ && cd_;
        }

        IEnumerable<(CqlTupleMetadata, Encounter QualifyingEncounterICU, Procedure AnesthesiaProcedure, object VTEProphylaxis)?> j_ = context.Operators.SelectWhere<ValueTuple<Encounter, Procedure, object>, (CqlTupleMetadata, Encounter QualifyingEncounterICU, Procedure AnesthesiaProcedure, object VTEProphylaxis)?>(g_, h_, i_);
        Encounter k_((CqlTupleMetadata, Encounter QualifyingEncounterICU, Procedure AnesthesiaProcedure, object VTEProphylaxis)? tuple_drnlhywkgwmzdeyzybtiilbhf) => tuple_drnlhywkgwmzdeyzybtiilbhf?.QualifyingEncounterICU;
        IEnumerable<Encounter> l_ = context.Operators.SelectDistinct<(CqlTupleMetadata, Encounter QualifyingEncounterICU, Procedure AnesthesiaProcedure, object VTEProphylaxis)?, Encounter>(j_, k_);
        IEnumerable<Encounter> m_ = context.Operators.Union<Encounter>(c_, l_);
        return m_;
    }


    [CqlExpressionDefinition("Encounter With Medication Oral Factor Xa Inhibitor Administered On Day Of Or Day After First ICU Stay Or Procedure")]
    public IEnumerable<Encounter> Encounter_With_Medication_Oral_Factor_Xa_Inhibitor_Administered_On_Day_Of_Or_Day_After_First_ICU_Stay_Or_Procedure(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Encounter_With_Medication_Oral_Factor_Xa_Inhibitor_Administered_On_Day_Of_Or_Day_After_First_ICU_Stay_Or_Procedure, Encounter_With_Medication_Oral_Factor_Xa_Inhibitor_Administered_On_Day_Of_Or_Day_After_First_ICU_Stay_Or_Procedure_Compute);

    private const long _cacheIndex_Encounter_With_Medication_Oral_Factor_Xa_Inhibitor_Administered_On_Day_Of_Or_Day_After_First_ICU_Stay_Or_Procedure = 1433532295141068796L;

    private IEnumerable<Encounter> Encounter_With_Medication_Oral_Factor_Xa_Inhibitor_Administered_On_Day_Of_Or_Day_After_First_ICU_Stay_Or_Procedure_Compute(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Encounter_With_ICU_Location(context);

        bool? b_(Encounter QualifyingEncounterICU) {
            IEnumerable<MedicationAdministration> s_ = context.Operators.Retrieve<MedicationAdministration>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationadministration"));

            bool? t_(MedicationAdministration MR) {
                IEnumerable<Medication> aa_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));

                bool? ab_(Medication M) {
                    object ad_ = context.Operators.LateBoundProperty<object>(M, "id.value");
                    object ae_ = context.Operators.LateBoundProperty<object>(MR, "medication.reference.value");
                    IEnumerable<string> af_ = context.Operators.Split((string)ae_, "/");
                    string ag_ = context.Operators.Last<string>(af_);
                    CqlBoolean ah_ = context.Operators.Equal(ad_, ag_);
                    CodeableConcept ai_ = M?.Code;
                    CqlConcept aj_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, ai_);
                    CqlValueSet ak_ = this.Oral_Factor_Xa_Inhibitor_for_VTE_Prophylaxis_or_VTE_Treatment(context);
                    CqlBoolean al_ = context.Operators.ConceptInValueSet(aj_, ak_);
                    CqlBoolean am_ = al_;
                    return ah_
                        /* CQL 'and' */ && am_;
                }

                CqlBoolean ac_ = context.Operators.WhereAny<Medication>(aa_, ab_);
                return ac_;
            }

            IEnumerable<MedicationAdministration> u_ = context.Operators.Where<MedicationAdministration>(s_, t_);
            CqlValueSet v_ = this.Oral_Factor_Xa_Inhibitor_for_VTE_Prophylaxis_or_VTE_Treatment(context);
            IEnumerable<MedicationAdministration> w_ = context.Operators.Retrieve<MedicationAdministration>(new RetrieveParameters(default, v_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationadministration"));
            IEnumerable<MedicationAdministration> x_ = context.Operators.Union<MedicationAdministration>(u_, w_);

            bool? y_(MedicationAdministration FactorXaMedication) {
                Code<MedicationAdministration.MedicationAdministrationStatusCodes> an_ = FactorXaMedication?.StatusElement;
                MedicationAdministration.MedicationAdministrationStatusCodes? ao_ = an_?.Value;
                string ap_ = context.Operators.Convert<string>(ao_);
                CqlBoolean aq_ = context.Operators.Equal(ap_, "completed");
                DataType ar_ = FactorXaMedication?.Effective;
                object as_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ar_);
                CqlInterval<CqlDateTime> at_ = QICoreCommon_4_0_000.Instance.toInterval(context, as_);
                CqlDateTime au_ = context.Operators.Start(at_);
                CqlDateTime av_ = this.startOfFirstICU(context, QualifyingEncounterICU);
                CqlInterval<CqlDate> aw_ = TJCOverall_8_25_000.Instance.calendarDayOfOrDayAfter(context, av_);
                CqlDate ax_ = aw_?.low;
                CqlDateTime ay_ = context.Operators.ConvertDateToDateTime(ax_);
                CqlDate az_ = aw_?.high;
                CqlDateTime ba_ = context.Operators.ConvertDateToDateTime(az_);
                CqlBoolean bb_ = aw_?.lowClosed;
                CqlBoolean bc_ = aw_?.highClosed;
                CqlInterval<CqlDateTime> bd_ = context.Operators.Interval(ay_, ba_, bb_, bc_);
                CqlBoolean be_ = context.Operators.In<CqlDateTime>(au_, bd_, "day");
                CqlBoolean bf_ = be_;
                return aq_
                    /* CQL 'and' (176:19-177:149) */ && bf_;
            }

            CqlBoolean z_ = context.Operators.WhereAny<MedicationAdministration>(x_, y_);
            return z_;
        }

        IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);
        CqlValueSet d_ = this.General_or_Neuraxial_Anesthesia(context);
        IEnumerable<Procedure> e_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, d_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
        IEnumerable<MedicationAdministration> f_ = context.Operators.Retrieve<MedicationAdministration>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationadministration"));

        bool? g_(MedicationAdministration MR) {
            IEnumerable<Medication> bg_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));

            bool? bh_(Medication M) {
                object bj_ = context.Operators.LateBoundProperty<object>(M, "id.value");
                object bk_ = context.Operators.LateBoundProperty<object>(MR, "medication.reference.value");
                IEnumerable<string> bl_ = context.Operators.Split((string)bk_, "/");
                string bm_ = context.Operators.Last<string>(bl_);
                CqlBoolean bn_ = context.Operators.Equal(bj_, bm_);
                CodeableConcept bo_ = M?.Code;
                CqlConcept bp_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, bo_);
                CqlValueSet bq_ = this.Oral_Factor_Xa_Inhibitor_for_VTE_Prophylaxis_or_VTE_Treatment(context);
                CqlBoolean br_ = context.Operators.ConceptInValueSet(bp_, bq_);
                CqlBoolean bs_ = br_;
                return bn_
                    /* CQL 'and' */ && bs_;
            }

            CqlBoolean bi_ = context.Operators.WhereAny<Medication>(bg_, bh_);
            return bi_;
        }

        IEnumerable<MedicationAdministration> h_ = context.Operators.Where<MedicationAdministration>(f_, g_);
        CqlValueSet i_ = this.Oral_Factor_Xa_Inhibitor_for_VTE_Prophylaxis_or_VTE_Treatment(context);
        IEnumerable<MedicationAdministration> j_ = context.Operators.Retrieve<MedicationAdministration>(new RetrieveParameters(default, i_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationadministration"));
        IEnumerable<MedicationAdministration> k_ = context.Operators.Union<MedicationAdministration>(h_, j_);
        IEnumerable<ValueTuple<Encounter, Procedure, MedicationAdministration>> l_ = context.Operators.CrossJoin<Encounter, Procedure, MedicationAdministration>(a_, e_, k_);

        (CqlTupleMetadata, Encounter QualifyingEncounterICU, Procedure AnesthesiaProcedure, MedicationAdministration FactorXaMedication)? m_(ValueTuple<Encounter, Procedure, MedicationAdministration> _valueTuple) {
            (CqlTupleMetadata, Encounter QualifyingEncounterICU, Procedure AnesthesiaProcedure, MedicationAdministration FactorXaMedication)? bt_ = (CqlTupleMetadata_IGcdIOTLGJfibgSLNOGSFRVB, _valueTuple.Item1, _valueTuple.Item2, _valueTuple.Item3);
            return bt_;
        }


        bool? n_((CqlTupleMetadata, Encounter QualifyingEncounterICU, Procedure AnesthesiaProcedure, MedicationAdministration FactorXaMedication)? tuple_elrfucfgncrbdgahdtkitiyzu) {
            Code<MedicationAdministration.MedicationAdministrationStatusCodes> bu_ = tuple_elrfucfgncrbdgahdtkitiyzu?.FactorXaMedication?.StatusElement;
            MedicationAdministration.MedicationAdministrationStatusCodes? bv_ = bu_?.Value;
            string bw_ = context.Operators.Convert<string>(bv_);
            CqlBoolean bx_ = context.Operators.Equal(bw_, "completed");
            Code<EventStatus> by_ = tuple_elrfucfgncrbdgahdtkitiyzu?.AnesthesiaProcedure?.StatusElement;
            EventStatus? bz_ = by_?.Value;
            string ca_ = context.Operators.Convert<string>(bz_);
            CqlBoolean cb_ = context.Operators.Equal(ca_, "completed");
            CqlBoolean cc_ = cb_;
            object cd_;
            DataType do_ = tuple_elrfucfgncrbdgahdtkitiyzu?.AnesthesiaProcedure?.Performed;
            object dp_ = FHIRHelpers_4_4_000.Instance.ToValue(context, do_);
            bool dq_ = dp_ is CqlDateTime;
            if (dq_)
            {
                cd_ = dp_ as CqlDateTime;
            }
            else
            {
                bool dr_ = dp_ is CqlQuantity;
                if (dr_)
                {
                    cd_ = dp_ as CqlQuantity;
                }
                else
                {
                    bool ds_ = dp_ is CqlInterval<CqlDateTime>;
                    if (ds_)
                    {
                        cd_ = dp_ as CqlInterval<CqlDateTime>;
                    }
                    else
                    {
                        bool dt_ = dp_ is CqlInterval<CqlQuantity>;
                        if (dt_)
                        {
                            cd_ = dp_ as CqlInterval<CqlQuantity>;
                        }
                        else
                        {
                            cd_ = null;
                        }
                    }
                }
            }
            CqlInterval<CqlDateTime> ce_ = QICoreCommon_4_0_000.Instance.toInterval(context, cd_);
            CqlDateTime cf_ = context.Operators.End(ce_);
            CqlDateTime cg_ = this.startOfFirstICU(context, tuple_elrfucfgncrbdgahdtkitiyzu?.QualifyingEncounterICU);
            CqlQuantity ch_ = context.Operators.Quantity(1m, "day");
            CqlDateTime ci_ = context.Operators.Add(cg_, ch_);
            CqlBoolean cj_ = context.Operators.SameAs(cf_, ci_, "day");
            CqlBoolean ck_ = cj_;
            DataType cl_ = tuple_elrfucfgncrbdgahdtkitiyzu?.FactorXaMedication?.Effective;
            object cm_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cl_);
            CqlInterval<CqlDateTime> cn_ = QICoreCommon_4_0_000.Instance.toInterval(context, cm_);
            CqlDateTime co_ = context.Operators.Start(cn_);
            object cp_;
            DataType du_ = tuple_elrfucfgncrbdgahdtkitiyzu?.AnesthesiaProcedure?.Performed;
            object dv_ = FHIRHelpers_4_4_000.Instance.ToValue(context, du_);
            bool dw_ = dv_ is CqlDateTime;
            if (dw_)
            {
                cp_ = dv_ as CqlDateTime;
            }
            else
            {
                bool dx_ = dv_ is CqlQuantity;
                if (dx_)
                {
                    cp_ = dv_ as CqlQuantity;
                }
                else
                {
                    bool dy_ = dv_ is CqlInterval<CqlDateTime>;
                    if (dy_)
                    {
                        cp_ = dv_ as CqlInterval<CqlDateTime>;
                    }
                    else
                    {
                        bool dz_ = dv_ is CqlInterval<CqlQuantity>;
                        if (dz_)
                        {
                            cp_ = dv_ as CqlInterval<CqlQuantity>;
                        }
                        else
                        {
                            cp_ = null;
                        }
                    }
                }
            }
            CqlInterval<CqlDateTime> cq_ = QICoreCommon_4_0_000.Instance.toInterval(context, cp_);
            CqlDateTime cr_ = context.Operators.End(cq_);
            CqlInterval<CqlDate> cs_ = TJCOverall_8_25_000.Instance.calendarDayOfOrDayAfter(context, cr_);
            CqlDate ct_ = cs_?.low;
            CqlDateTime cu_ = context.Operators.ConvertDateToDateTime(ct_);
            object cv_;
            DataType ea_ = tuple_elrfucfgncrbdgahdtkitiyzu?.AnesthesiaProcedure?.Performed;
            object eb_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ea_);
            bool ec_ = eb_ is CqlDateTime;
            if (ec_)
            {
                cv_ = eb_ as CqlDateTime;
            }
            else
            {
                bool ed_ = eb_ is CqlQuantity;
                if (ed_)
                {
                    cv_ = eb_ as CqlQuantity;
                }
                else
                {
                    bool ee_ = eb_ is CqlInterval<CqlDateTime>;
                    if (ee_)
                    {
                        cv_ = eb_ as CqlInterval<CqlDateTime>;
                    }
                    else
                    {
                        bool ef_ = eb_ is CqlInterval<CqlQuantity>;
                        if (ef_)
                        {
                            cv_ = eb_ as CqlInterval<CqlQuantity>;
                        }
                        else
                        {
                            cv_ = null;
                        }
                    }
                }
            }
            CqlInterval<CqlDateTime> cw_ = QICoreCommon_4_0_000.Instance.toInterval(context, cv_);
            CqlDateTime cx_ = context.Operators.End(cw_);
            CqlInterval<CqlDate> cy_ = TJCOverall_8_25_000.Instance.calendarDayOfOrDayAfter(context, cx_);
            CqlDate cz_ = cy_?.high;
            CqlDateTime da_ = context.Operators.ConvertDateToDateTime(cz_);
            object db_;
            DataType eg_ = tuple_elrfucfgncrbdgahdtkitiyzu?.AnesthesiaProcedure?.Performed;
            object eh_ = FHIRHelpers_4_4_000.Instance.ToValue(context, eg_);
            bool ei_ = eh_ is CqlDateTime;
            if (ei_)
            {
                db_ = eh_ as CqlDateTime;
            }
            else
            {
                bool ej_ = eh_ is CqlQuantity;
                if (ej_)
                {
                    db_ = eh_ as CqlQuantity;
                }
                else
                {
                    bool ek_ = eh_ is CqlInterval<CqlDateTime>;
                    if (ek_)
                    {
                        db_ = eh_ as CqlInterval<CqlDateTime>;
                    }
                    else
                    {
                        bool el_ = eh_ is CqlInterval<CqlQuantity>;
                        if (el_)
                        {
                            db_ = eh_ as CqlInterval<CqlQuantity>;
                        }
                        else
                        {
                            db_ = null;
                        }
                    }
                }
            }
            CqlInterval<CqlDateTime> dc_ = QICoreCommon_4_0_000.Instance.toInterval(context, db_);
            CqlDateTime dd_ = context.Operators.End(dc_);
            CqlInterval<CqlDate> de_ = TJCOverall_8_25_000.Instance.calendarDayOfOrDayAfter(context, dd_);
            CqlBoolean df_ = de_?.lowClosed;
            object dg_;
            DataType em_ = tuple_elrfucfgncrbdgahdtkitiyzu?.AnesthesiaProcedure?.Performed;
            object en_ = FHIRHelpers_4_4_000.Instance.ToValue(context, em_);
            bool eo_ = en_ is CqlDateTime;
            if (eo_)
            {
                dg_ = en_ as CqlDateTime;
            }
            else
            {
                bool ep_ = en_ is CqlQuantity;
                if (ep_)
                {
                    dg_ = en_ as CqlQuantity;
                }
                else
                {
                    bool eq_ = en_ is CqlInterval<CqlDateTime>;
                    if (eq_)
                    {
                        dg_ = en_ as CqlInterval<CqlDateTime>;
                    }
                    else
                    {
                        bool er_ = en_ is CqlInterval<CqlQuantity>;
                        if (er_)
                        {
                            dg_ = en_ as CqlInterval<CqlQuantity>;
                        }
                        else
                        {
                            dg_ = null;
                        }
                    }
                }
            }
            CqlInterval<CqlDateTime> dh_ = QICoreCommon_4_0_000.Instance.toInterval(context, dg_);
            CqlDateTime di_ = context.Operators.End(dh_);
            CqlInterval<CqlDate> dj_ = TJCOverall_8_25_000.Instance.calendarDayOfOrDayAfter(context, di_);
            CqlBoolean dk_ = dj_?.highClosed;
            CqlInterval<CqlDateTime> dl_ = context.Operators.Interval(cu_, da_, df_, dk_);
            CqlBoolean dm_ = context.Operators.In<CqlDateTime>(co_, dl_, "day");
            CqlBoolean dn_ = dm_;
            return bx_
                /* CQL 'and' (183:15-184:54) */ && cc_
                /* CQL 'and' (183:15-185:125) */ && ck_
                /* CQL 'and' (183:9-186:162) */ && dn_;
        }

        IEnumerable<(CqlTupleMetadata, Encounter QualifyingEncounterICU, Procedure AnesthesiaProcedure, MedicationAdministration FactorXaMedication)?> o_ = context.Operators.SelectWhere<ValueTuple<Encounter, Procedure, MedicationAdministration>, (CqlTupleMetadata, Encounter QualifyingEncounterICU, Procedure AnesthesiaProcedure, MedicationAdministration FactorXaMedication)?>(l_, m_, n_);
        Encounter p_((CqlTupleMetadata, Encounter QualifyingEncounterICU, Procedure AnesthesiaProcedure, MedicationAdministration FactorXaMedication)? tuple_elrfucfgncrbdgahdtkitiyzu) => tuple_elrfucfgncrbdgahdtkitiyzu?.QualifyingEncounterICU;
        IEnumerable<Encounter> q_ = context.Operators.SelectDistinct<(CqlTupleMetadata, Encounter QualifyingEncounterICU, Procedure AnesthesiaProcedure, MedicationAdministration FactorXaMedication)?, Encounter>(o_, p_);
        IEnumerable<Encounter> r_ = context.Operators.Union<Encounter>(c_, q_);
        return r_;
    }


    [CqlExpressionDefinition("Encounter With Prior Or Present Diagnosis Of Atrial Fibrillation Or Prior Diagnosis Of VTE")]
    public IEnumerable<Encounter> Encounter_With_Prior_Or_Present_Diagnosis_Of_Atrial_Fibrillation_Or_Prior_Diagnosis_Of_VTE(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Encounter_With_Prior_Or_Present_Diagnosis_Of_Atrial_Fibrillation_Or_Prior_Diagnosis_Of_VTE, Encounter_With_Prior_Or_Present_Diagnosis_Of_Atrial_Fibrillation_Or_Prior_Diagnosis_Of_VTE_Compute);

    private const long _cacheIndex_Encounter_With_Prior_Or_Present_Diagnosis_Of_Atrial_Fibrillation_Or_Prior_Diagnosis_Of_VTE = 955367419207387258L;

    private IEnumerable<Encounter> Encounter_With_Prior_Or_Present_Diagnosis_Of_Atrial_Fibrillation_Or_Prior_Diagnosis_Of_VTE_Compute(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Encounter_With_ICU_Location(context);

        bool? b_(Encounter QualifyingEncounterICU) {
            CqlValueSet j_ = this.Atrial_Fibrillation_or_Flutter(context);
            IEnumerable<Condition> k_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, j_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-problems-health-concerns"));

            bool? l_(Condition AtrialFibrillation) {
                CodeableConcept n_ = AtrialFibrillation?.VerificationStatus;
                CqlConcept o_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, n_);
                CqlCode p_ = QICoreCommon_4_0_000.Instance.refuted(context);
                CqlConcept q_ = context.Operators.ConvertCodeToConcept(p_);
                CqlBoolean r_ = context.Operators.Equivalent(o_, q_);
                CqlCode s_ = QICoreCommon_4_0_000.Instance.entered_in_error(context);
                CqlConcept t_ = context.Operators.ConvertCodeToConcept(s_);
                CqlBoolean u_ = context.Operators.Equivalent(o_, t_);
                CqlBoolean v_ = (CqlBoolean)!u_;
                DataType w_ = AtrialFibrillation?.Onset;
                object x_ = FHIRHelpers_4_4_000.Instance.ToValue(context, w_);
                CqlInterval<CqlDateTime> y_ = QICoreCommon_4_0_000.Instance.toInterval(context, x_);
                CqlDateTime z_ = context.Operators.Start(y_);
                Period aa_ = QualifyingEncounterICU?.Period;
                CqlInterval<CqlDateTime> ab_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, aa_);
                CqlDateTime ac_ = context.Operators.End(ab_);
                CqlBoolean ad_ = context.Operators.SameOrBefore(z_, ac_, (string)default);
                CqlBoolean ae_ = ad_;
                CqlBoolean af_ = (CqlBoolean)!r_
                    /* CQL 'and' (193:77-195:9) */ && v_
                    /* CQL 'and' (193:77-196:110) */ && ae_;
                return (CqlBoolean)(o_ is null)
                    /* CQL 'implies' (193:19-196:110) */ || af_;
            }

            CqlBoolean m_ = context.Operators.WhereAny<Condition>(k_, l_);
            return m_;
        }

        IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);

        bool? d_(Encounter QualifyingEncounterICU) {
            CqlValueSet ag_ = this.Atrial_Fibrillation_or_Flutter(context);
            CqlBoolean ah_ = VTE_8_18_000.Instance.hasEncDiagnosisOf(context, QualifyingEncounterICU, ag_);
            return ah_;
        }

        IEnumerable<Encounter> e_ = context.Operators.Where<Encounter>(a_, d_);
        IEnumerable<Encounter> f_ = context.Operators.Union<Encounter>(c_, e_);

        bool? g_(Encounter QualifyingEncounterICU) {
            CqlValueSet ai_ = this.Venous_Thromboembolism(context);
            IEnumerable<Condition> aj_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, ai_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-problems-health-concerns"));

            bool? ak_(Condition VTEDiagnosis) {
                CodeableConcept am_ = VTEDiagnosis?.ClinicalStatus;
                CqlConcept an_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, am_);
                CqlCode ao_ = QICoreCommon_4_0_000.Instance.inactive(context);
                CqlConcept ap_ = context.Operators.ConvertCodeToConcept(ao_);
                CqlBoolean aq_ = context.Operators.Equivalent(an_, ap_);
                CqlCode ar_ = QICoreCommon_4_0_000.Instance.remission(context);
                CqlConcept as_ = context.Operators.ConvertCodeToConcept(ar_);
                CqlBoolean at_ = context.Operators.Equivalent(an_, as_);
                CqlBoolean au_ = at_;
                CqlCode av_ = QICoreCommon_4_0_000.Instance.resolved(context);
                CqlConcept aw_ = context.Operators.ConvertCodeToConcept(av_);
                CqlBoolean ax_ = context.Operators.Equivalent(an_, aw_);
                CqlBoolean ay_ = ax_;
                CodeableConcept az_ = VTEDiagnosis?.VerificationStatus;
                CqlConcept ba_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, az_);
                CqlBoolean bb_ = (CqlBoolean)(ba_ is not null);
                CqlCode bc_ = QICoreCommon_4_0_000.Instance.refuted(context);
                CqlConcept bd_ = context.Operators.ConvertCodeToConcept(bc_);
                CqlBoolean be_ = context.Operators.Equivalent(ba_, bd_);
                CqlCode bf_ = QICoreCommon_4_0_000.Instance.entered_in_error(context);
                CqlConcept bg_ = context.Operators.ConvertCodeToConcept(bf_);
                CqlBoolean bh_ = context.Operators.Equivalent(ba_, bg_);
                CqlBoolean bi_ = (CqlBoolean)!bh_;
                DataType bj_ = VTEDiagnosis?.Onset;
                object bk_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bj_);
                CqlInterval<CqlDateTime> bl_ = QICoreCommon_4_0_000.Instance.toInterval(context, bk_);
                CqlInterval<CqlDateTime> bm_;
                Period bq_ = QualifyingEncounterICU?.Period;
                CqlInterval<CqlDateTime> br_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, bq_);
                CqlDateTime bs_ = context.Operators.Start(br_);
                if (bs_ is null)
                {
                    bm_ = default;
                }
                else
                {
                    CqlInterval<CqlDateTime> bt_ = context.Operators.Interval(bs_, bs_, true, true);
                    bm_ = bt_;
                }
                CqlBoolean bn_ = context.Operators.Before(bl_, bm_, (string)default);
                CqlBoolean bo_ = bn_;
                CqlBoolean bp_ = (CqlBoolean)!be_
                    /* CQL 'and' (207:69-209:11) */ && bi_
                    /* CQL 'and' (207:69-210:95) */ && bo_;
                return (CqlBoolean)(!((bool?)((aq_
                    /* CQL 'or' (203:23-204:71) */ || au_
                    /* CQL 'or' (203:21-206:11) */ || ay_)
                    /* CQL 'and' (203:21-207:59) */ && bb_)))
                    /* CQL 'implies' (203:21-210:95) */ || bp_;
            }

            CqlBoolean al_ = context.Operators.WhereAny<Condition>(aj_, ak_);
            return al_;
        }

        IEnumerable<Encounter> h_ = context.Operators.Where<Encounter>(a_, g_);
        IEnumerable<Encounter> i_ = context.Operators.Union<Encounter>(f_, h_);
        return i_;
    }


    [CqlExpressionDefinition("Encounter With Prior Or Present Procedure Of Hip Or Knee Replacement Surgery")]
    public IEnumerable<Encounter> Encounter_With_Prior_Or_Present_Procedure_Of_Hip_Or_Knee_Replacement_Surgery(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Encounter_With_Prior_Or_Present_Procedure_Of_Hip_Or_Knee_Replacement_Surgery, Encounter_With_Prior_Or_Present_Procedure_Of_Hip_Or_Knee_Replacement_Surgery_Compute);

    private const long _cacheIndex_Encounter_With_Prior_Or_Present_Procedure_Of_Hip_Or_Knee_Replacement_Surgery = 7135932585124611427L;

    private IEnumerable<Encounter> Encounter_With_Prior_Or_Present_Procedure_Of_Hip_Or_Knee_Replacement_Surgery_Compute(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Encounter_With_ICU_Location(context);

        bool? b_(Encounter QualifyingEncounterICU) {
            CqlValueSet d_ = this.Hip_Replacement_Surgery(context);
            IEnumerable<Procedure> e_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, d_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
            CqlValueSet f_ = this.Knee_Replacement_Surgery(context);
            IEnumerable<Procedure> g_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, f_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
            IEnumerable<Procedure> h_ = context.Operators.Union<Procedure>(e_, g_);

            bool? i_(Procedure HipKneeProcedure) {
                Code<EventStatus> k_ = HipKneeProcedure?.StatusElement;
                EventStatus? l_ = k_?.Value;
                string m_ = context.Operators.Convert<string>(l_);
                CqlBoolean n_ = context.Operators.Equal(m_, "completed");
                object o_;
                DataType w_ = HipKneeProcedure?.Performed;
                object x_ = FHIRHelpers_4_4_000.Instance.ToValue(context, w_);
                bool y_ = x_ is CqlDateTime;
                if (y_)
                {
                    o_ = x_ as CqlDateTime;
                }
                else
                {
                    bool z_ = x_ is CqlQuantity;
                    if (z_)
                    {
                        o_ = x_ as CqlQuantity;
                    }
                    else
                    {
                        bool aa_ = x_ is CqlInterval<CqlDateTime>;
                        if (aa_)
                        {
                            o_ = x_ as CqlInterval<CqlDateTime>;
                        }
                        else
                        {
                            bool ab_ = x_ is CqlInterval<CqlQuantity>;
                            if (ab_)
                            {
                                o_ = x_ as CqlInterval<CqlQuantity>;
                            }
                            else
                            {
                                o_ = null;
                            }
                        }
                    }
                }
                CqlInterval<CqlDateTime> p_ = QICoreCommon_4_0_000.Instance.toInterval(context, o_);
                CqlDateTime q_ = context.Operators.Start(p_);
                Period r_ = QualifyingEncounterICU?.Period;
                CqlInterval<CqlDateTime> s_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, r_);
                CqlDateTime t_ = context.Operators.End(s_);
                CqlBoolean u_ = context.Operators.SameOrBefore(q_, t_, (string)default);
                CqlBoolean v_ = u_;
                return n_
                    /* CQL 'and' (217:17-218:110) */ && v_;
            }

            CqlBoolean j_ = context.Operators.WhereAny<Procedure>(h_, i_);
            return j_;
        }

        IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);
        return c_;
    }


    [CqlExpressionDefinition("Low Risk Indicator For VTE")]
    public IEnumerable<(CqlTupleMetadata, string id, CqlDateTime LowRiskDatetime)?> Low_Risk_Indicator_For_VTE(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Low_Risk_Indicator_For_VTE, Low_Risk_Indicator_For_VTE_Compute);

    private const long _cacheIndex_Low_Risk_Indicator_For_VTE = -1820126284718976250L;

    private IEnumerable<(CqlTupleMetadata, string id, CqlDateTime LowRiskDatetime)?> Low_Risk_Indicator_For_VTE_Compute(CqlContext context)
    {
        CqlCode a_ = this.Risk_for_venous_thromboembolism(context);
        IEnumerable<CqlCode> b_ = context.Operators.ToList<CqlCode>(a_);
        IEnumerable<Observation> c_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, b_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-simple-observation"));

        bool? d_(Observation VTERiskAssessment) {
            DataType an_ = VTERiskAssessment?.Value;
            object ao_ = FHIRHelpers_4_4_000.Instance.ToValue(context, an_);
            CqlValueSet ap_ = this.Low_Risk(context);
            CqlBoolean aq_ = context.Operators.ConceptInValueSet(ao_ as CqlConcept, ap_);
            Code<ObservationStatus> ar_ = VTERiskAssessment?.StatusElement;
            ObservationStatus? as_ = ar_?.Value;
            string at_ = context.Operators.Convert<string>(as_);
            string[] au_ = [
                "final",
                "amended",
                "corrected",
            ];
            CqlBoolean av_ = context.Operators.In<string>(at_, (IEnumerable<string>)au_);
            CqlBoolean aw_ = av_;
            return aq_
                /* CQL 'and' (226:7-227:75) */ && aw_;
        }


        (CqlTupleMetadata, string id, CqlDateTime LowRiskDatetime)? e_(Observation VTERiskAssessment) {
            Id ax_ = VTERiskAssessment?.IdElement;
            string ay_ = ax_?.Value;
            object az_;
            DataType bc_ = VTERiskAssessment?.Effective;
            object bd_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bc_);
            bool be_ = bd_ is CqlDateTime;
            if (be_)
            {
                az_ = bd_ as CqlDateTime;
            }
            else
            {
                if (be_)
                {
                    az_ = bd_ as CqlDateTime;
                }
                else
                {
                    bool bf_ = bd_ is CqlInterval<CqlDateTime>;
                    if (bf_)
                    {
                        az_ = bd_ as CqlInterval<CqlDateTime>;
                    }
                    else
                    {
                        az_ = null;
                    }
                }
            }
            CqlDateTime ba_ = QICoreCommon_4_0_000.Instance.earliest(context, az_);
            (CqlTupleMetadata, string id, CqlDateTime LowRiskDatetime)? bb_ = (CqlTupleMetadata_DMAfXNhTfZDWOGdfEceXbfaSJ, ay_, ba_);
            return bb_;
        }

        IEnumerable<(CqlTupleMetadata, string id, CqlDateTime LowRiskDatetime)?> f_ = context.Operators.WhereSelect<Observation, (CqlTupleMetadata, string id, CqlDateTime LowRiskDatetime)?>(c_, d_, e_);
        IEnumerable<(CqlTupleMetadata, string id, CqlDateTime LowRiskDatetime)?> g_ = context.Operators.Distinct<(CqlTupleMetadata, string id, CqlDateTime LowRiskDatetime)?>(f_);
        CqlValueSet h_ = this.INR(context);
        IEnumerable<Observation> i_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, h_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation-lab"));

        bool? j_(Observation INRLabTest) {
            DataType bg_ = INRLabTest?.Value;
            object bh_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bg_);
            CqlQuantity bi_ = context.Operators.ConvertDecimalToQuantity(3.0m);
            CqlBoolean bj_ = context.Operators.Greater(bh_ as CqlQuantity, bi_);
            Code<ObservationStatus> bk_ = INRLabTest?.StatusElement;
            ObservationStatus? bl_ = bk_?.Value;
            string bm_ = context.Operators.Convert<string>(bl_);
            string[] bn_ = [
                "final",
                "amended",
                "corrected",
            ];
            CqlBoolean bo_ = context.Operators.In<string>(bm_, (IEnumerable<string>)bn_);
            CqlBoolean bp_ = bo_;
            return bj_
                /* CQL 'and' (234:9-235:70) */ && bp_;
        }


        (CqlTupleMetadata, string id, CqlDateTime LowRiskDatetime)? k_(Observation INRLabTest) {
            Id bq_ = INRLabTest?.IdElement;
            string br_ = bq_?.Value;
            Instant bs_ = INRLabTest?.IssuedElement;
            DateTimeOffset? bt_ = bs_?.Value;
            CqlDateTime bu_ = context.Operators.Convert<CqlDateTime>(bt_);
            (CqlTupleMetadata, string id, CqlDateTime LowRiskDatetime)? bv_ = (CqlTupleMetadata_DMAfXNhTfZDWOGdfEceXbfaSJ, br_, bu_);
            return bv_;
        }

        IEnumerable<(CqlTupleMetadata, string id, CqlDateTime LowRiskDatetime)?> l_ = context.Operators.WhereSelect<Observation, (CqlTupleMetadata, string id, CqlDateTime LowRiskDatetime)?>(i_, j_, k_);
        IEnumerable<(CqlTupleMetadata, string id, CqlDateTime LowRiskDatetime)?> m_ = context.Operators.Distinct<(CqlTupleMetadata, string id, CqlDateTime LowRiskDatetime)?>(l_);
        IEnumerable<(CqlTupleMetadata, string id, CqlDateTime LowRiskDatetime)?> n_ = context.Operators.Union<(CqlTupleMetadata, string id, CqlDateTime LowRiskDatetime)?>(g_, m_);
        IEnumerable<MedicationAdministration> o_ = context.Operators.Retrieve<MedicationAdministration>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationadministration"));

        bool? p_(MedicationAdministration MR) {
            IEnumerable<Medication> bw_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));

            bool? bx_(Medication M) {
                object bz_ = context.Operators.LateBoundProperty<object>(M, "id.value");
                object ca_ = context.Operators.LateBoundProperty<object>(MR, "medication.reference.value");
                IEnumerable<string> cb_ = context.Operators.Split((string)ca_, "/");
                string cc_ = context.Operators.Last<string>(cb_);
                CqlBoolean cd_ = context.Operators.Equal(bz_, cc_);
                CodeableConcept ce_ = M?.Code;
                CqlConcept cf_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, ce_);
                CqlValueSet cg_ = this.Unfractionated_Heparin(context);
                CqlBoolean ch_ = context.Operators.ConceptInValueSet(cf_, cg_);
                CqlBoolean ci_ = ch_;
                return cd_
                    /* CQL 'and' */ && ci_;
            }

            CqlBoolean by_ = context.Operators.WhereAny<Medication>(bw_, bx_);
            return by_;
        }

        IEnumerable<MedicationAdministration> q_ = context.Operators.Where<MedicationAdministration>(o_, p_);
        CqlValueSet r_ = this.Unfractionated_Heparin(context);
        IEnumerable<MedicationAdministration> s_ = context.Operators.Retrieve<MedicationAdministration>(new RetrieveParameters(default, r_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationadministration"));
        IEnumerable<MedicationAdministration> t_ = context.Operators.Union<MedicationAdministration>(q_, s_);

        bool? u_(MedicationAdministration UnfractionatedHeparin) {
            MedicationAdministration.DosageComponent cj_ = UnfractionatedHeparin?.Dosage;
            CodeableConcept ck_ = cj_?.Route;
            CqlConcept cl_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, ck_);
            CqlValueSet cm_ = this.Intravenous_route(context);
            CqlBoolean cn_ = context.Operators.ConceptInValueSet(cl_, cm_);
            return cn_;
        }

        IEnumerable<MedicationAdministration> v_ = context.Operators.Where<MedicationAdministration>(t_, u_);

        bool? w_(MedicationAdministration MR) {
            IEnumerable<Medication> co_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));

            bool? cp_(Medication M) {
                object cr_ = context.Operators.LateBoundProperty<object>(M, "id.value");
                object cs_ = context.Operators.LateBoundProperty<object>(MR, "medication.reference.value");
                IEnumerable<string> ct_ = context.Operators.Split((string)cs_, "/");
                string cu_ = context.Operators.Last<string>(ct_);
                CqlBoolean cv_ = context.Operators.Equal(cr_, cu_);
                CodeableConcept cw_ = M?.Code;
                CqlConcept cx_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, cw_);
                CqlValueSet cy_ = this.Direct_Thrombin_Inhibitor(context);
                CqlBoolean cz_ = context.Operators.ConceptInValueSet(cx_, cy_);
                CqlBoolean da_ = cz_;
                return cv_
                    /* CQL 'and' */ && da_;
            }

            CqlBoolean cq_ = context.Operators.WhereAny<Medication>(co_, cp_);
            return cq_;
        }

        IEnumerable<MedicationAdministration> x_ = context.Operators.Where<MedicationAdministration>(o_, w_);
        CqlValueSet y_ = this.Direct_Thrombin_Inhibitor(context);
        IEnumerable<MedicationAdministration> z_ = context.Operators.Retrieve<MedicationAdministration>(new RetrieveParameters(default, y_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationadministration"));
        IEnumerable<MedicationAdministration> aa_ = context.Operators.Union<MedicationAdministration>(x_, z_);
        IEnumerable<MedicationAdministration> ab_ = context.Operators.Union<MedicationAdministration>(v_, aa_);

        bool? ac_(MedicationAdministration MR) {
            IEnumerable<Medication> db_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));

            bool? dc_(Medication M) {
                object de_ = context.Operators.LateBoundProperty<object>(M, "id.value");
                object df_ = context.Operators.LateBoundProperty<object>(MR, "medication.reference.value");
                IEnumerable<string> dg_ = context.Operators.Split((string)df_, "/");
                string dh_ = context.Operators.Last<string>(dg_);
                CqlBoolean di_ = context.Operators.Equal(de_, dh_);
                CodeableConcept dj_ = M?.Code;
                CqlConcept dk_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, dj_);
                CqlValueSet dl_ = this.Glycoprotein_IIb_IIIa_Inhibitors(context);
                CqlBoolean dm_ = context.Operators.ConceptInValueSet(dk_, dl_);
                CqlBoolean dn_ = dm_;
                return di_
                    /* CQL 'and' */ && dn_;
            }

            CqlBoolean dd_ = context.Operators.WhereAny<Medication>(db_, dc_);
            return dd_;
        }

        IEnumerable<MedicationAdministration> ad_ = context.Operators.Where<MedicationAdministration>(o_, ac_);
        CqlValueSet ae_ = this.Glycoprotein_IIb_IIIa_Inhibitors(context);
        IEnumerable<MedicationAdministration> af_ = context.Operators.Retrieve<MedicationAdministration>(new RetrieveParameters(default, ae_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationadministration"));
        IEnumerable<MedicationAdministration> ag_ = context.Operators.Union<MedicationAdministration>(ad_, af_);
        IEnumerable<MedicationAdministration> ah_ = context.Operators.Union<MedicationAdministration>(ab_, ag_);

        bool? ai_(MedicationAdministration AnticoagulantMedication) {
            Code<MedicationAdministration.MedicationAdministrationStatusCodes> do_ = AnticoagulantMedication?.StatusElement;
            MedicationAdministration.MedicationAdministrationStatusCodes? dp_ = do_?.Value;
            string dq_ = context.Operators.Convert<string>(dp_);
            CqlBoolean dr_ = context.Operators.Equal(dq_, "completed");
            return dr_;
        }


        (CqlTupleMetadata, string id, CqlDateTime LowRiskDatetime)? aj_(MedicationAdministration AnticoagulantMedication) {
            Id ds_ = AnticoagulantMedication?.IdElement;
            string dt_ = ds_?.Value;
            DataType du_ = AnticoagulantMedication?.Effective;
            object dv_ = FHIRHelpers_4_4_000.Instance.ToValue(context, du_);
            CqlInterval<CqlDateTime> dw_ = QICoreCommon_4_0_000.Instance.toInterval(context, dv_);
            CqlDateTime dx_ = context.Operators.Start(dw_);
            (CqlTupleMetadata, string id, CqlDateTime LowRiskDatetime)? dy_ = (CqlTupleMetadata_DMAfXNhTfZDWOGdfEceXbfaSJ, dt_, dx_);
            return dy_;
        }

        IEnumerable<(CqlTupleMetadata, string id, CqlDateTime LowRiskDatetime)?> ak_ = context.Operators.WhereSelect<MedicationAdministration, (CqlTupleMetadata, string id, CqlDateTime LowRiskDatetime)?>(ah_, ai_, aj_);
        IEnumerable<(CqlTupleMetadata, string id, CqlDateTime LowRiskDatetime)?> al_ = context.Operators.Distinct<(CqlTupleMetadata, string id, CqlDateTime LowRiskDatetime)?>(ak_);
        IEnumerable<(CqlTupleMetadata, string id, CqlDateTime LowRiskDatetime)?> am_ = context.Operators.Union<(CqlTupleMetadata, string id, CqlDateTime LowRiskDatetime)?>(n_, al_);
        return am_;
    }


    [CqlExpressionDefinition("Low Risk For VTE Or Anticoagulant Administered From Day Of Start Of Hospitalization To Day After First ICU Stay")]
    public IEnumerable<Encounter> Low_Risk_For_VTE_Or_Anticoagulant_Administered_From_Day_Of_Start_Of_Hospitalization_To_Day_After_First_ICU_Stay(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Low_Risk_For_VTE_Or_Anticoagulant_Administered_From_Day_Of_Start_Of_Hospitalization_To_Day_After_First_ICU_Stay, Low_Risk_For_VTE_Or_Anticoagulant_Administered_From_Day_Of_Start_Of_Hospitalization_To_Day_After_First_ICU_Stay_Compute);

    private const long _cacheIndex_Low_Risk_For_VTE_Or_Anticoagulant_Administered_From_Day_Of_Start_Of_Hospitalization_To_Day_After_First_ICU_Stay = -524851788773972608L;

    private IEnumerable<Encounter> Low_Risk_For_VTE_Or_Anticoagulant_Administered_From_Day_Of_Start_Of_Hospitalization_To_Day_After_First_ICU_Stay_Compute(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Encounter_With_ICU_Location(context);

        bool? b_(Encounter QualifyingEncounterICU) {
            IEnumerable<(CqlTupleMetadata, string id, CqlDateTime LowRiskDatetime)?> d_ = this.Low_Risk_Indicator_For_VTE(context);

            bool? e_((CqlTupleMetadata, string id, CqlDateTime LowRiskDatetime)? LowRiskForVTE) {
                CqlDateTime g_ = LowRiskForVTE?.LowRiskDatetime;
                CqlInterval<CqlDate> h_ = this.fromDayOfStartOfHospitalizationToDayAfterFirstICU(context, QualifyingEncounterICU);
                CqlDate i_ = h_?.low;
                CqlDateTime j_ = context.Operators.ConvertDateToDateTime(i_);
                CqlDate k_ = h_?.high;
                CqlDateTime l_ = context.Operators.ConvertDateToDateTime(k_);
                CqlBoolean m_ = h_?.lowClosed;
                CqlBoolean n_ = h_?.highClosed;
                CqlInterval<CqlDateTime> o_ = context.Operators.Interval(j_, l_, m_, n_);
                CqlBoolean p_ = context.Operators.In<CqlDateTime>(g_, o_, "day");
                return p_;
            }

            CqlBoolean f_ = context.Operators.WhereAny<(CqlTupleMetadata, string id, CqlDateTime LowRiskDatetime)?>(d_, e_);
            return f_;
        }

        IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);
        return c_;
    }


    [CqlExpressionDefinition("Low Risk For VTE Or Anticoagulant Administered On Day Of Or Day After Procedure")]
    public IEnumerable<Encounter> Low_Risk_For_VTE_Or_Anticoagulant_Administered_On_Day_Of_Or_Day_After_Procedure(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Low_Risk_For_VTE_Or_Anticoagulant_Administered_On_Day_Of_Or_Day_After_Procedure, Low_Risk_For_VTE_Or_Anticoagulant_Administered_On_Day_Of_Or_Day_After_Procedure_Compute);

    private const long _cacheIndex_Low_Risk_For_VTE_Or_Anticoagulant_Administered_On_Day_Of_Or_Day_After_Procedure = 8956935782520090314L;

    private IEnumerable<Encounter> Low_Risk_For_VTE_Or_Anticoagulant_Administered_On_Day_Of_Or_Day_After_Procedure_Compute(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Encounter_With_ICU_Location(context);
        CqlValueSet b_ = this.General_or_Neuraxial_Anesthesia(context);
        IEnumerable<Procedure> c_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, b_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
        IEnumerable<(CqlTupleMetadata, string id, CqlDateTime LowRiskDatetime)?> d_ = this.Low_Risk_Indicator_For_VTE(context);
        IEnumerable<ValueTuple<Encounter, Procedure, (CqlTupleMetadata, string id, CqlDateTime LowRiskDatetime)?>> e_ = context.Operators.CrossJoin<Encounter, Procedure, (CqlTupleMetadata, string id, CqlDateTime LowRiskDatetime)?>(a_, c_, d_);

        (CqlTupleMetadata, Encounter QualifyingEncounterICU, Procedure AnesthesiaProcedure, (CqlTupleMetadata, string id, CqlDateTime LowRiskDatetime)? LowRiskForVTE)? f_(ValueTuple<Encounter, Procedure, (CqlTupleMetadata, string id, CqlDateTime LowRiskDatetime)?> _valueTuple) {
            (CqlTupleMetadata, Encounter QualifyingEncounterICU, Procedure AnesthesiaProcedure, (CqlTupleMetadata, string id, CqlDateTime LowRiskDatetime)? LowRiskForVTE)? k_ = (CqlTupleMetadata_FFALfPBajSdbcUiIgEjZKRHOP, _valueTuple.Item1, _valueTuple.Item2, _valueTuple.Item3);
            return k_;
        }


        bool? g_((CqlTupleMetadata, Encounter QualifyingEncounterICU, Procedure AnesthesiaProcedure, (CqlTupleMetadata, string id, CqlDateTime LowRiskDatetime)? LowRiskForVTE)? tuple_cchfidtccovheihiyjcdnfkbm) {
            Code<EventStatus> l_ = tuple_cchfidtccovheihiyjcdnfkbm?.AnesthesiaProcedure?.StatusElement;
            EventStatus? m_ = l_?.Value;
            string n_ = context.Operators.Convert<string>(m_);
            CqlBoolean o_ = context.Operators.Equal(n_, "completed");
            object p_;
            DataType ax_ = tuple_cchfidtccovheihiyjcdnfkbm?.AnesthesiaProcedure?.Performed;
            object ay_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ax_);
            bool az_ = ay_ is CqlDateTime;
            if (az_)
            {
                p_ = ay_ as CqlDateTime;
            }
            else
            {
                bool ba_ = ay_ is CqlQuantity;
                if (ba_)
                {
                    p_ = ay_ as CqlQuantity;
                }
                else
                {
                    bool bb_ = ay_ is CqlInterval<CqlDateTime>;
                    if (bb_)
                    {
                        p_ = ay_ as CqlInterval<CqlDateTime>;
                    }
                    else
                    {
                        bool bc_ = ay_ is CqlInterval<CqlQuantity>;
                        if (bc_)
                        {
                            p_ = ay_ as CqlInterval<CqlQuantity>;
                        }
                        else
                        {
                            p_ = null;
                        }
                    }
                }
            }
            CqlInterval<CqlDateTime> q_ = QICoreCommon_4_0_000.Instance.toInterval(context, p_);
            CqlDateTime r_ = context.Operators.End(q_);
            CqlDateTime s_ = this.startOfFirstICU(context, tuple_cchfidtccovheihiyjcdnfkbm?.QualifyingEncounterICU);
            CqlQuantity t_ = context.Operators.Quantity(1m, "day");
            CqlDateTime u_ = context.Operators.Add(s_, t_);
            CqlBoolean v_ = context.Operators.SameAs(r_, u_, "day");
            CqlBoolean w_ = v_;
            CqlDateTime x_ = tuple_cchfidtccovheihiyjcdnfkbm?.LowRiskForVTE?.LowRiskDatetime;
            object y_;
            DataType bd_ = tuple_cchfidtccovheihiyjcdnfkbm?.AnesthesiaProcedure?.Performed;
            object be_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bd_);
            bool bf_ = be_ is CqlDateTime;
            if (bf_)
            {
                y_ = be_ as CqlDateTime;
            }
            else
            {
                bool bg_ = be_ is CqlQuantity;
                if (bg_)
                {
                    y_ = be_ as CqlQuantity;
                }
                else
                {
                    bool bh_ = be_ is CqlInterval<CqlDateTime>;
                    if (bh_)
                    {
                        y_ = be_ as CqlInterval<CqlDateTime>;
                    }
                    else
                    {
                        bool bi_ = be_ is CqlInterval<CqlQuantity>;
                        if (bi_)
                        {
                            y_ = be_ as CqlInterval<CqlQuantity>;
                        }
                        else
                        {
                            y_ = null;
                        }
                    }
                }
            }
            CqlInterval<CqlDateTime> z_ = QICoreCommon_4_0_000.Instance.toInterval(context, y_);
            CqlDateTime aa_ = context.Operators.End(z_);
            CqlInterval<CqlDate> ab_ = TJCOverall_8_25_000.Instance.calendarDayOfOrDayAfter(context, aa_);
            CqlDate ac_ = ab_?.low;
            CqlDateTime ad_ = context.Operators.ConvertDateToDateTime(ac_);
            object ae_;
            DataType bj_ = tuple_cchfidtccovheihiyjcdnfkbm?.AnesthesiaProcedure?.Performed;
            object bk_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bj_);
            bool bl_ = bk_ is CqlDateTime;
            if (bl_)
            {
                ae_ = bk_ as CqlDateTime;
            }
            else
            {
                bool bm_ = bk_ is CqlQuantity;
                if (bm_)
                {
                    ae_ = bk_ as CqlQuantity;
                }
                else
                {
                    bool bn_ = bk_ is CqlInterval<CqlDateTime>;
                    if (bn_)
                    {
                        ae_ = bk_ as CqlInterval<CqlDateTime>;
                    }
                    else
                    {
                        bool bo_ = bk_ is CqlInterval<CqlQuantity>;
                        if (bo_)
                        {
                            ae_ = bk_ as CqlInterval<CqlQuantity>;
                        }
                        else
                        {
                            ae_ = null;
                        }
                    }
                }
            }
            CqlInterval<CqlDateTime> af_ = QICoreCommon_4_0_000.Instance.toInterval(context, ae_);
            CqlDateTime ag_ = context.Operators.End(af_);
            CqlInterval<CqlDate> ah_ = TJCOverall_8_25_000.Instance.calendarDayOfOrDayAfter(context, ag_);
            CqlDate ai_ = ah_?.high;
            CqlDateTime aj_ = context.Operators.ConvertDateToDateTime(ai_);
            object ak_;
            DataType bp_ = tuple_cchfidtccovheihiyjcdnfkbm?.AnesthesiaProcedure?.Performed;
            object bq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bp_);
            bool br_ = bq_ is CqlDateTime;
            if (br_)
            {
                ak_ = bq_ as CqlDateTime;
            }
            else
            {
                bool bs_ = bq_ is CqlQuantity;
                if (bs_)
                {
                    ak_ = bq_ as CqlQuantity;
                }
                else
                {
                    bool bt_ = bq_ is CqlInterval<CqlDateTime>;
                    if (bt_)
                    {
                        ak_ = bq_ as CqlInterval<CqlDateTime>;
                    }
                    else
                    {
                        bool bu_ = bq_ is CqlInterval<CqlQuantity>;
                        if (bu_)
                        {
                            ak_ = bq_ as CqlInterval<CqlQuantity>;
                        }
                        else
                        {
                            ak_ = null;
                        }
                    }
                }
            }
            CqlInterval<CqlDateTime> al_ = QICoreCommon_4_0_000.Instance.toInterval(context, ak_);
            CqlDateTime am_ = context.Operators.End(al_);
            CqlInterval<CqlDate> an_ = TJCOverall_8_25_000.Instance.calendarDayOfOrDayAfter(context, am_);
            CqlBoolean ao_ = an_?.lowClosed;
            object ap_;
            DataType bv_ = tuple_cchfidtccovheihiyjcdnfkbm?.AnesthesiaProcedure?.Performed;
            object bw_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bv_);
            bool bx_ = bw_ is CqlDateTime;
            if (bx_)
            {
                ap_ = bw_ as CqlDateTime;
            }
            else
            {
                bool by_ = bw_ is CqlQuantity;
                if (by_)
                {
                    ap_ = bw_ as CqlQuantity;
                }
                else
                {
                    bool bz_ = bw_ is CqlInterval<CqlDateTime>;
                    if (bz_)
                    {
                        ap_ = bw_ as CqlInterval<CqlDateTime>;
                    }
                    else
                    {
                        bool ca_ = bw_ is CqlInterval<CqlQuantity>;
                        if (ca_)
                        {
                            ap_ = bw_ as CqlInterval<CqlQuantity>;
                        }
                        else
                        {
                            ap_ = null;
                        }
                    }
                }
            }
            CqlInterval<CqlDateTime> aq_ = QICoreCommon_4_0_000.Instance.toInterval(context, ap_);
            CqlDateTime ar_ = context.Operators.End(aq_);
            CqlInterval<CqlDate> as_ = TJCOverall_8_25_000.Instance.calendarDayOfOrDayAfter(context, ar_);
            CqlBoolean at_ = as_?.highClosed;
            CqlInterval<CqlDateTime> au_ = context.Operators.Interval(ad_, aj_, ao_, at_);
            CqlBoolean av_ = context.Operators.In<CqlDateTime>(x_, au_, "day");
            CqlBoolean aw_ = av_;
            return o_
                /* CQL 'and' (263:11-264:121) */ && w_
                /* CQL 'and' (263:5-265:137) */ && aw_;
        }

        IEnumerable<(CqlTupleMetadata, Encounter QualifyingEncounterICU, Procedure AnesthesiaProcedure, (CqlTupleMetadata, string id, CqlDateTime LowRiskDatetime)? LowRiskForVTE)?> h_ = context.Operators.SelectWhere<ValueTuple<Encounter, Procedure, (CqlTupleMetadata, string id, CqlDateTime LowRiskDatetime)?>, (CqlTupleMetadata, Encounter QualifyingEncounterICU, Procedure AnesthesiaProcedure, (CqlTupleMetadata, string id, CqlDateTime LowRiskDatetime)? LowRiskForVTE)?>(e_, f_, g_);
        Encounter i_((CqlTupleMetadata, Encounter QualifyingEncounterICU, Procedure AnesthesiaProcedure, (CqlTupleMetadata, string id, CqlDateTime LowRiskDatetime)? LowRiskForVTE)? tuple_cchfidtccovheihiyjcdnfkbm) => tuple_cchfidtccovheihiyjcdnfkbm?.QualifyingEncounterICU;
        IEnumerable<Encounter> j_ = context.Operators.SelectDistinct<(CqlTupleMetadata, Encounter QualifyingEncounterICU, Procedure AnesthesiaProcedure, (CqlTupleMetadata, string id, CqlDateTime LowRiskDatetime)? LowRiskForVTE)?, Encounter>(h_, i_);
        return j_;
    }


    [CqlExpressionDefinition("Encounter With Low Risk For VTE Or Anticoagulant Administered")]
    public IEnumerable<Encounter> Encounter_With_Low_Risk_For_VTE_Or_Anticoagulant_Administered(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Encounter_With_Low_Risk_For_VTE_Or_Anticoagulant_Administered, Encounter_With_Low_Risk_For_VTE_Or_Anticoagulant_Administered_Compute);

    private const long _cacheIndex_Encounter_With_Low_Risk_For_VTE_Or_Anticoagulant_Administered = 3531303220745361013L;

    private IEnumerable<Encounter> Encounter_With_Low_Risk_For_VTE_Or_Anticoagulant_Administered_Compute(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Low_Risk_For_VTE_Or_Anticoagulant_Administered_From_Day_Of_Start_Of_Hospitalization_To_Day_After_First_ICU_Stay(context);
        IEnumerable<Encounter> b_ = this.Low_Risk_For_VTE_Or_Anticoagulant_Administered_On_Day_Of_Or_Day_After_Procedure(context);
        IEnumerable<Encounter> c_ = context.Operators.Union<Encounter>(a_, b_);
        return c_;
    }


    [CqlExpressionDefinition("No VTE Prophylaxis Medication Administered Or Ordered")]
    public IEnumerable<(CqlTupleMetadata, string id, IEnumerable<CqlConcept> medicationStatusReason, CqlDateTime authoredOn)?> No_VTE_Prophylaxis_Medication_Administered_Or_Ordered(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_No_VTE_Prophylaxis_Medication_Administered_Or_Ordered, No_VTE_Prophylaxis_Medication_Administered_Or_Ordered_Compute);

    private const long _cacheIndex_No_VTE_Prophylaxis_Medication_Administered_Or_Ordered = -7403318724715238893L;

    private IEnumerable<(CqlTupleMetadata, string id, IEnumerable<CqlConcept> medicationStatusReason, CqlDateTime authoredOn)?> No_VTE_Prophylaxis_Medication_Administered_Or_Ordered_Compute(CqlContext context)
    {
        CqlValueSet a_ = this.Low_Dose_Unfractionated_Heparin_for_VTE_Prophylaxis(context);
        IEnumerable<MedicationAdministration> b_ = context.Operators.Retrieve<MedicationAdministration>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationadministrationnotdone"));
        IEnumerable<MedicationAdministration> c_ = context.Operators.Union<MedicationAdministration>(b_, b_);
        CqlValueSet d_ = this.Low_Molecular_Weight_Heparin_for_VTE_Prophylaxis(context);
        IEnumerable<MedicationAdministration> e_ = context.Operators.Retrieve<MedicationAdministration>(new RetrieveParameters(default, d_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationadministrationnotdone"));
        IEnumerable<MedicationAdministration> f_ = context.Operators.Union<MedicationAdministration>(e_, e_);
        IEnumerable<MedicationAdministration> g_ = context.Operators.Union<MedicationAdministration>(c_, f_);
        CqlValueSet h_ = this.Injectable_Factor_Xa_Inhibitor_for_VTE_Prophylaxis(context);
        IEnumerable<MedicationAdministration> i_ = context.Operators.Retrieve<MedicationAdministration>(new RetrieveParameters(default, h_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationadministrationnotdone"));
        IEnumerable<MedicationAdministration> j_ = context.Operators.Union<MedicationAdministration>(i_, i_);
        IEnumerable<MedicationAdministration> k_ = context.Operators.Union<MedicationAdministration>(g_, j_);
        CqlValueSet l_ = this.Warfarin(context);
        IEnumerable<MedicationAdministration> m_ = context.Operators.Retrieve<MedicationAdministration>(new RetrieveParameters(default, l_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationadministrationnotdone"));
        IEnumerable<MedicationAdministration> n_ = context.Operators.Union<MedicationAdministration>(m_, m_);
        IEnumerable<MedicationAdministration> o_ = context.Operators.Union<MedicationAdministration>(k_, n_);
        CqlValueSet p_ = this.Rivaroxaban_for_VTE_Prophylaxis(context);
        IEnumerable<MedicationAdministration> q_ = context.Operators.Retrieve<MedicationAdministration>(new RetrieveParameters(default, p_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationadministrationnotdone"));
        IEnumerable<MedicationAdministration> r_ = context.Operators.Union<MedicationAdministration>(q_, q_);
        IEnumerable<MedicationAdministration> s_ = context.Operators.Union<MedicationAdministration>(o_, r_);

        (CqlTupleMetadata, string id, IEnumerable<CqlConcept> medicationStatusReason, FhirDateTime authoredOn)? t_(MedicationAdministration NoMedicationAdm) {
            Id bx_ = NoMedicationAdm?.IdElement;
            string by_ = bx_?.Value;
            List<CodeableConcept> bz_ = NoMedicationAdm?.StatusReason;

            CqlConcept ca_(CodeableConcept @this) {
                CqlConcept ci_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);
                return ci_;
            }

            IEnumerable<CqlConcept> cb_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)bz_, ca_);

            bool? cc_(Extension @this) {
                FhirUri cj_ = @this?.UrlElement;
                string ck_ = FHIRHelpers_4_4_000.Instance.ToString(context, cj_);
                CqlBoolean cl_ = context.Operators.Equal(ck_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-recorded");
                return cl_;
            }


            DataType cd_(Extension @this) {
                DataType cm_ = @this?.Value;
                return cm_;
            }

            IEnumerable<DataType> ce_ = context.Operators.WhereSelect<Extension, DataType>((IEnumerable<Extension>)(NoMedicationAdm is DomainResource
                ? (NoMedicationAdm as DomainResource).Extension
                : default), cc_, cd_);
            DataType cf_ = context.Operators.SingletonFrom<DataType>(ce_);
            FhirDateTime cg_ = context.Operators.Convert<FhirDateTime>(cf_);
            (CqlTupleMetadata, string id, IEnumerable<CqlConcept> medicationStatusReason, FhirDateTime authoredOn)? ch_ = (CqlTupleMetadata_EBcSahXYZdeFjUUbgULReCZAe, by_, cb_, cg_);
            return ch_;
        }

        IEnumerable<(CqlTupleMetadata, string id, IEnumerable<CqlConcept> medicationStatusReason, FhirDateTime authoredOn)?> u_ = context.Operators.SelectDistinct<MedicationAdministration, (CqlTupleMetadata, string id, IEnumerable<CqlConcept> medicationStatusReason, FhirDateTime authoredOn)?>(s_, t_);

        (CqlTupleMetadata, string id, IEnumerable<CqlConcept> medicationStatusReason, CqlDateTime authoredOn)? v_((CqlTupleMetadata, string id, IEnumerable<CqlConcept> medicationStatusReason, FhirDateTime authoredOn)? tuple_cumbjbeguchwelldvxijceahs) {
            if (tuple_cumbjbeguchwelldvxijceahs is null)
            {
                return default;
            }
            else
            {
                CqlDateTime cn_ = context.Operators.Convert<CqlDateTime>(tuple_cumbjbeguchwelldvxijceahs?.authoredOn);
                (CqlTupleMetadata, string id, IEnumerable<CqlConcept> medicationStatusReason, CqlDateTime authoredOn)? co_ = (CqlTupleMetadata_CNeQfiIHcQEUBjZNVZiOLfdeP, tuple_cumbjbeguchwelldvxijceahs?.id, tuple_cumbjbeguchwelldvxijceahs?.medicationStatusReason, cn_);
                return co_;
            }
        }

        IEnumerable<(CqlTupleMetadata, string id, IEnumerable<CqlConcept> medicationStatusReason, CqlDateTime authoredOn)?> w_ = context.Operators.Select<(CqlTupleMetadata, string id, IEnumerable<CqlConcept> medicationStatusReason, FhirDateTime authoredOn)?, (CqlTupleMetadata, string id, IEnumerable<CqlConcept> medicationStatusReason, CqlDateTime authoredOn)?>(u_, v_);
        IEnumerable<MedicationRequest> x_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationnotrequested"));
        IEnumerable<MedicationRequest> y_ = context.Operators.Union<MedicationRequest>(x_, x_);
        IEnumerable<MedicationRequest> z_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, d_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationnotrequested"));
        IEnumerable<MedicationRequest> aa_ = context.Operators.Union<MedicationRequest>(z_, z_);
        IEnumerable<MedicationRequest> ab_ = context.Operators.Union<MedicationRequest>(y_, aa_);
        IEnumerable<MedicationRequest> ac_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, h_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationnotrequested"));
        IEnumerable<MedicationRequest> ad_ = context.Operators.Union<MedicationRequest>(ac_, ac_);
        IEnumerable<MedicationRequest> ae_ = context.Operators.Union<MedicationRequest>(ab_, ad_);
        IEnumerable<MedicationRequest> af_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, l_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationnotrequested"));
        IEnumerable<MedicationRequest> ag_ = context.Operators.Union<MedicationRequest>(af_, af_);
        IEnumerable<MedicationRequest> ah_ = context.Operators.Union<MedicationRequest>(ae_, ag_);
        IEnumerable<MedicationRequest> ai_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, p_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationnotrequested"));
        IEnumerable<MedicationRequest> aj_ = context.Operators.Union<MedicationRequest>(ai_, ai_);
        IEnumerable<MedicationRequest> ak_ = context.Operators.Union<MedicationRequest>(ah_, aj_);

        bool? al_(MedicationRequest NoMedicationOrder) {
            Code<MedicationRequest.MedicationRequestIntent> cp_ = NoMedicationOrder?.IntentElement;
            MedicationRequest.MedicationRequestIntent? cq_ = cp_?.Value;
            string cr_ = context.Operators.Convert<string>(cq_);
            string[] cs_ = [
                "order",
                "original-order",
                "reflex-order",
                "filler-order",
                "instance-order",
            ];
            CqlBoolean ct_ = context.Operators.In<string>(cr_, (IEnumerable<string>)cs_);
            Code<MedicationRequest.MedicationrequestStatus> cu_ = NoMedicationOrder?.StatusElement;
            MedicationRequest.MedicationrequestStatus? cv_ = cu_?.Value;
            string cw_ = context.Operators.Convert<string>(cv_);
            string[] cx_ = [
                "active",
                "completed",
            ];
            CqlBoolean cy_ = context.Operators.In<string>(cw_, (IEnumerable<string>)cx_);
            CqlBoolean cz_ = cy_;
            return ct_
                /* CQL 'and' (299:9-300:67) */ && cz_;
        }


        (CqlTupleMetadata, string id, IEnumerable<CqlConcept> medicationStatusReason, CqlDateTime authoredOn)? am_(MedicationRequest NoMedicationOrder) {
            Id da_ = NoMedicationOrder?.IdElement;
            string db_ = da_?.Value;
            List<CodeableConcept> dc_ = NoMedicationOrder?.ReasonCode;

            CqlConcept dd_(CodeableConcept @this) {
                CqlConcept di_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);
                return di_;
            }

            IEnumerable<CqlConcept> de_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)dc_, dd_);
            FhirDateTime df_ = NoMedicationOrder?.AuthoredOnElement;
            CqlDateTime dg_ = context.Operators.Convert<CqlDateTime>(df_);
            (CqlTupleMetadata, string id, IEnumerable<CqlConcept> medicationStatusReason, CqlDateTime authoredOn)? dh_ = (CqlTupleMetadata_CNeQfiIHcQEUBjZNVZiOLfdeP, db_, de_, dg_);
            return dh_;
        }

        IEnumerable<(CqlTupleMetadata, string id, IEnumerable<CqlConcept> medicationStatusReason, CqlDateTime authoredOn)?> an_ = context.Operators.WhereSelect<MedicationRequest, (CqlTupleMetadata, string id, IEnumerable<CqlConcept> medicationStatusReason, CqlDateTime authoredOn)?>(ak_, al_, am_);
        IEnumerable<(CqlTupleMetadata, string id, IEnumerable<CqlConcept> medicationStatusReason, CqlDateTime authoredOn)?> ao_ = context.Operators.Distinct<(CqlTupleMetadata, string id, IEnumerable<CqlConcept> medicationStatusReason, CqlDateTime authoredOn)?>(an_);
        IEnumerable<(CqlTupleMetadata, string id, IEnumerable<CqlConcept> medicationStatusReason, CqlDateTime authoredOn)?> ap_ = context.Operators.Union<(CqlTupleMetadata, string id, IEnumerable<CqlConcept> medicationStatusReason, CqlDateTime authoredOn)?>(w_, ao_);
        IEnumerable<MedicationRequest> aq_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));

        bool? ar_(MedicationRequest MR) {
            IEnumerable<Medication> dj_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));

            bool? dk_(Medication M) {
                object dm_ = context.Operators.LateBoundProperty<object>(M, "id.value");
                object dn_ = context.Operators.LateBoundProperty<object>(MR, "medication.reference.value");
                IEnumerable<string> do_ = context.Operators.Split((string)dn_, "/");
                string dp_ = context.Operators.Last<string>(do_);
                CqlBoolean dq_ = context.Operators.Equal(dm_, dp_);
                CodeableConcept dr_ = M?.Code;
                CqlConcept ds_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, dr_);
                CqlValueSet dt_ = this.Low_Dose_Unfractionated_Heparin_for_VTE_Prophylaxis(context);
                CqlBoolean du_ = context.Operators.ConceptInValueSet(ds_, dt_);
                CqlBoolean dv_ = du_;
                return dq_
                    /* CQL 'and' */ && dv_;
            }

            CqlBoolean dl_ = context.Operators.WhereAny<Medication>(dj_, dk_);
            return dl_;
        }

        IEnumerable<MedicationRequest> as_ = context.Operators.Where<MedicationRequest>(aq_, ar_);
        IEnumerable<MedicationRequest> at_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> au_ = context.Operators.Union<MedicationRequest>(as_, at_);

        bool? av_(MedicationRequest MR) {
            IEnumerable<Medication> dw_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));

            bool? dx_(Medication M) {
                object dz_ = context.Operators.LateBoundProperty<object>(M, "id.value");
                object ea_ = context.Operators.LateBoundProperty<object>(MR, "medication.reference.value");
                IEnumerable<string> eb_ = context.Operators.Split((string)ea_, "/");
                string ec_ = context.Operators.Last<string>(eb_);
                CqlBoolean ed_ = context.Operators.Equal(dz_, ec_);
                CodeableConcept ee_ = M?.Code;
                CqlConcept ef_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, ee_);
                CqlValueSet eg_ = this.Low_Molecular_Weight_Heparin_for_VTE_Prophylaxis(context);
                CqlBoolean eh_ = context.Operators.ConceptInValueSet(ef_, eg_);
                CqlBoolean ei_ = eh_;
                return ed_
                    /* CQL 'and' */ && ei_;
            }

            CqlBoolean dy_ = context.Operators.WhereAny<Medication>(dw_, dx_);
            return dy_;
        }

        IEnumerable<MedicationRequest> aw_ = context.Operators.Where<MedicationRequest>(aq_, av_);
        IEnumerable<MedicationRequest> ax_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, d_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> ay_ = context.Operators.Union<MedicationRequest>(aw_, ax_);
        IEnumerable<MedicationRequest> az_ = context.Operators.Union<MedicationRequest>(au_, ay_);

        bool? ba_(MedicationRequest MR) {
            IEnumerable<Medication> ej_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));

            bool? ek_(Medication M) {
                object em_ = context.Operators.LateBoundProperty<object>(M, "id.value");
                object en_ = context.Operators.LateBoundProperty<object>(MR, "medication.reference.value");
                IEnumerable<string> eo_ = context.Operators.Split((string)en_, "/");
                string ep_ = context.Operators.Last<string>(eo_);
                CqlBoolean eq_ = context.Operators.Equal(em_, ep_);
                CodeableConcept er_ = M?.Code;
                CqlConcept es_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, er_);
                CqlValueSet et_ = this.Injectable_Factor_Xa_Inhibitor_for_VTE_Prophylaxis(context);
                CqlBoolean eu_ = context.Operators.ConceptInValueSet(es_, et_);
                CqlBoolean ev_ = eu_;
                return eq_
                    /* CQL 'and' */ && ev_;
            }

            CqlBoolean el_ = context.Operators.WhereAny<Medication>(ej_, ek_);
            return el_;
        }

        IEnumerable<MedicationRequest> bb_ = context.Operators.Where<MedicationRequest>(aq_, ba_);
        IEnumerable<MedicationRequest> bc_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, h_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> bd_ = context.Operators.Union<MedicationRequest>(bb_, bc_);
        IEnumerable<MedicationRequest> be_ = context.Operators.Union<MedicationRequest>(az_, bd_);

        bool? bf_(MedicationRequest MR) {
            IEnumerable<Medication> ew_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));

            bool? ex_(Medication M) {
                object ez_ = context.Operators.LateBoundProperty<object>(M, "id.value");
                object fa_ = context.Operators.LateBoundProperty<object>(MR, "medication.reference.value");
                IEnumerable<string> fb_ = context.Operators.Split((string)fa_, "/");
                string fc_ = context.Operators.Last<string>(fb_);
                CqlBoolean fd_ = context.Operators.Equal(ez_, fc_);
                CodeableConcept fe_ = M?.Code;
                CqlConcept ff_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, fe_);
                CqlValueSet fg_ = this.Warfarin(context);
                CqlBoolean fh_ = context.Operators.ConceptInValueSet(ff_, fg_);
                CqlBoolean fi_ = fh_;
                return fd_
                    /* CQL 'and' */ && fi_;
            }

            CqlBoolean ey_ = context.Operators.WhereAny<Medication>(ew_, ex_);
            return ey_;
        }

        IEnumerable<MedicationRequest> bg_ = context.Operators.Where<MedicationRequest>(aq_, bf_);
        IEnumerable<MedicationRequest> bh_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, l_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> bi_ = context.Operators.Union<MedicationRequest>(bg_, bh_);
        IEnumerable<MedicationRequest> bj_ = context.Operators.Union<MedicationRequest>(be_, bi_);

        bool? bk_(MedicationRequest MR) {
            IEnumerable<Medication> fj_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));

            bool? fk_(Medication M) {
                object fm_ = context.Operators.LateBoundProperty<object>(M, "id.value");
                object fn_ = context.Operators.LateBoundProperty<object>(MR, "medication.reference.value");
                IEnumerable<string> fo_ = context.Operators.Split((string)fn_, "/");
                string fp_ = context.Operators.Last<string>(fo_);
                CqlBoolean fq_ = context.Operators.Equal(fm_, fp_);
                CodeableConcept fr_ = M?.Code;
                CqlConcept fs_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, fr_);
                CqlValueSet ft_ = this.Rivaroxaban_for_VTE_Prophylaxis(context);
                CqlBoolean fu_ = context.Operators.ConceptInValueSet(fs_, ft_);
                CqlBoolean fv_ = fu_;
                return fq_
                    /* CQL 'and' */ && fv_;
            }

            CqlBoolean fl_ = context.Operators.WhereAny<Medication>(fj_, fk_);
            return fl_;
        }

        IEnumerable<MedicationRequest> bl_ = context.Operators.Where<MedicationRequest>(aq_, bk_);
        IEnumerable<MedicationRequest> bm_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, p_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> bn_ = context.Operators.Union<MedicationRequest>(bl_, bm_);
        IEnumerable<MedicationRequest> bo_ = context.Operators.Union<MedicationRequest>(bj_, bn_);
        IEnumerable<Task> bp_ = context.Operators.Retrieve<Task>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-taskrejected"));
        IEnumerable<ValueTuple<MedicationRequest, Task>> bq_ = context.Operators.CrossJoin<MedicationRequest, Task>(bo_, bp_);

        (CqlTupleMetadata, MedicationRequest MedicationOrderReject, Task T)? br_(ValueTuple<MedicationRequest, Task> _valueTuple) {
            (CqlTupleMetadata, MedicationRequest MedicationOrderReject, Task T)? fw_ = (CqlTupleMetadata_IIUQMBcJhJBPgdDOLHaTTRUE, _valueTuple.Item1, _valueTuple.Item2);
            return fw_;
        }


        bool? bs_((CqlTupleMetadata, MedicationRequest MedicationOrderReject, Task T)? tuple_iiuqmbcjhjbpgddolhattrue) {
            ResourceReference fx_ = tuple_iiuqmbcjhjbpgddolhattrue?.T?.Focus;
            CqlBoolean fy_ = QICoreCommon_4_0_000.Instance.references(context, fx_, tuple_iiuqmbcjhjbpgddolhattrue?.MedicationOrderReject);
            CodeableConcept fz_ = tuple_iiuqmbcjhjbpgddolhattrue?.T?.Code;
            CqlConcept ga_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, fz_);
            CqlCode gb_ = QICoreCommon_4_0_000.Instance.Fulfill(context);
            CqlConcept gc_ = context.Operators.ConvertCodeToConcept(gb_);
            CqlBoolean gd_ = context.Operators.Equivalent(ga_, gc_);
            CqlBoolean ge_ = gd_;
            Code<MedicationRequest.MedicationrequestStatus> gf_ = tuple_iiuqmbcjhjbpgddolhattrue?.MedicationOrderReject?.StatusElement;
            MedicationRequest.MedicationrequestStatus? gg_ = gf_?.Value;
            string gh_ = context.Operators.Convert<string>(gg_);
            CqlBoolean gi_ = context.Operators.Equal(gh_, "active");
            CqlBoolean gj_ = gi_;
            return fy_
                /* CQL 'and' (314:15-315:45) */ && ge_
                /* CQL 'and' (314:9-316:53) */ && gj_;
        }

        IEnumerable<(CqlTupleMetadata, MedicationRequest MedicationOrderReject, Task T)?> bt_ = context.Operators.SelectWhere<ValueTuple<MedicationRequest, Task>, (CqlTupleMetadata, MedicationRequest MedicationOrderReject, Task T)?>(bq_, br_, bs_);

        (CqlTupleMetadata, string id, IEnumerable<CqlConcept> medicationStatusReason, CqlDateTime authoredOn)? bu_((CqlTupleMetadata, MedicationRequest MedicationOrderReject, Task T)? tuple_iiuqmbcjhjbpgddolhattrue) {
            Id gk_ = tuple_iiuqmbcjhjbpgddolhattrue?.MedicationOrderReject?.IdElement;
            string gl_ = gk_?.Value;
            CodeableConcept gm_ = tuple_iiuqmbcjhjbpgddolhattrue?.T?.StatusReason;
            CqlConcept gn_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, gm_);
            CqlConcept[] go_ = [
                gn_,
            ];
            FhirDateTime gp_ = tuple_iiuqmbcjhjbpgddolhattrue?.MedicationOrderReject?.AuthoredOnElement;
            CqlDateTime gq_ = context.Operators.Convert<CqlDateTime>(gp_);
            (CqlTupleMetadata, string id, IEnumerable<CqlConcept> medicationStatusReason, CqlDateTime authoredOn)? gr_ = (CqlTupleMetadata_CNeQfiIHcQEUBjZNVZiOLfdeP, gl_, (IEnumerable<CqlConcept>)go_, gq_);
            return gr_;
        }

        IEnumerable<(CqlTupleMetadata, string id, IEnumerable<CqlConcept> medicationStatusReason, CqlDateTime authoredOn)?> bv_ = context.Operators.SelectDistinct<(CqlTupleMetadata, MedicationRequest MedicationOrderReject, Task T)?, (CqlTupleMetadata, string id, IEnumerable<CqlConcept> medicationStatusReason, CqlDateTime authoredOn)?>(bt_, bu_);
        IEnumerable<(CqlTupleMetadata, string id, IEnumerable<CqlConcept> medicationStatusReason, CqlDateTime authoredOn)?> bw_ = context.Operators.Union<(CqlTupleMetadata, string id, IEnumerable<CqlConcept> medicationStatusReason, CqlDateTime authoredOn)?>(ap_, bv_);
        return bw_;
    }


    [CqlExpressionDefinition("No VTE Prophylaxis Medication Due To Medical Reason From Day Of Start Of Hospitalization To Day After First ICU Stay")]
    public IEnumerable<Encounter> No_VTE_Prophylaxis_Medication_Due_To_Medical_Reason_From_Day_Of_Start_Of_Hospitalization_To_Day_After_First_ICU_Stay(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_No_VTE_Prophylaxis_Medication_Due_To_Medical_Reason_From_Day_Of_Start_Of_Hospitalization_To_Day_After_First_ICU_Stay, No_VTE_Prophylaxis_Medication_Due_To_Medical_Reason_From_Day_Of_Start_Of_Hospitalization_To_Day_After_First_ICU_Stay_Compute);

    private const long _cacheIndex_No_VTE_Prophylaxis_Medication_Due_To_Medical_Reason_From_Day_Of_Start_Of_Hospitalization_To_Day_After_First_ICU_Stay = 5449834474205910518L;

    private IEnumerable<Encounter> No_VTE_Prophylaxis_Medication_Due_To_Medical_Reason_From_Day_Of_Start_Of_Hospitalization_To_Day_After_First_ICU_Stay_Compute(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Encounter_With_ICU_Location(context);

        bool? b_(Encounter QualifyingEncounterICU) {
            IEnumerable<(CqlTupleMetadata, string id, IEnumerable<CqlConcept> medicationStatusReason, CqlDateTime authoredOn)?> d_ = this.No_VTE_Prophylaxis_Medication_Administered_Or_Ordered(context);

            bool? e_((CqlTupleMetadata, string id, IEnumerable<CqlConcept> medicationStatusReason, CqlDateTime authoredOn)? NoVTEMedication) {
                IEnumerable<CqlConcept> g_ = NoVTEMedication?.medicationStatusReason;
                CqlValueSet h_ = this.Medical_Reason_For_Not_Providing_Treatment(context);
                CqlBoolean i_ = context.Operators.ConceptsInValueSet(g_, h_);
                CqlDateTime j_ = NoVTEMedication?.authoredOn;
                CqlInterval<CqlDate> k_ = this.fromDayOfStartOfHospitalizationToDayAfterFirstICU(context, QualifyingEncounterICU);
                CqlDate l_ = k_?.low;
                CqlDateTime m_ = context.Operators.ConvertDateToDateTime(l_);
                CqlDate n_ = k_?.high;
                CqlDateTime o_ = context.Operators.ConvertDateToDateTime(n_);
                CqlBoolean p_ = k_?.lowClosed;
                CqlBoolean q_ = k_?.highClosed;
                CqlInterval<CqlDateTime> r_ = context.Operators.Interval(m_, o_, p_, q_);
                CqlBoolean s_ = context.Operators.In<CqlDateTime>(j_, r_, "day");
                CqlBoolean t_ = s_;
                return i_
                    /* CQL 'and' (279:17-280:129) */ && t_;
            }

            CqlBoolean f_ = context.Operators.WhereAny<(CqlTupleMetadata, string id, IEnumerable<CqlConcept> medicationStatusReason, CqlDateTime authoredOn)?>(d_, e_);
            return f_;
        }

        IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);
        return c_;
    }


    [CqlExpressionDefinition("No Mechanical VTE Prophylaxis Performed Or Ordered")]
    public IEnumerable<(CqlTupleMetadata, string id, CqlConcept requestStatusReason, CqlDateTime authoredOn)?> No_Mechanical_VTE_Prophylaxis_Performed_Or_Ordered(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_No_Mechanical_VTE_Prophylaxis_Performed_Or_Ordered, No_Mechanical_VTE_Prophylaxis_Performed_Or_Ordered_Compute);

    private const long _cacheIndex_No_Mechanical_VTE_Prophylaxis_Performed_Or_Ordered = 7261304629549391579L;

    private IEnumerable<(CqlTupleMetadata, string id, CqlConcept requestStatusReason, CqlDateTime authoredOn)?> No_Mechanical_VTE_Prophylaxis_Performed_Or_Ordered_Compute(CqlContext context)
    {
        CqlValueSet a_ = this.Venous_foot_pumps(context);
        IEnumerable<ServiceRequest> b_ = context.Operators.Retrieve<ServiceRequest>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-servicenotrequested"));
        IEnumerable<ServiceRequest> c_ = context.Operators.Union<ServiceRequest>(b_, b_);
        CqlValueSet d_ = this.Intermittent_pneumatic_compression_devices(context);
        IEnumerable<ServiceRequest> e_ = context.Operators.Retrieve<ServiceRequest>(new RetrieveParameters(default, d_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-servicenotrequested"));
        IEnumerable<ServiceRequest> f_ = context.Operators.Union<ServiceRequest>(e_, e_);
        IEnumerable<ServiceRequest> g_ = context.Operators.Union<ServiceRequest>(c_, f_);
        CqlValueSet h_ = this.Graduated_compression_stockings(context);
        IEnumerable<ServiceRequest> i_ = context.Operators.Retrieve<ServiceRequest>(new RetrieveParameters(default, h_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-servicenotrequested"));
        IEnumerable<ServiceRequest> j_ = context.Operators.Union<ServiceRequest>(i_, i_);
        IEnumerable<ServiceRequest> k_ = context.Operators.Union<ServiceRequest>(g_, j_);

        bool? l_(ServiceRequest DeviceNotOrder) {
            Code<RequestIntent> au_ = DeviceNotOrder?.IntentElement;
            RequestIntent? av_ = au_?.Value;
            Code<RequestIntent> aw_ = context.Operators.Convert<Code<RequestIntent>>(av_);
            string ax_ = context.Operators.Convert<string>(aw_);
            string[] ay_ = [
                "order",
                "original-order",
                "reflex-order",
                "filler-order",
                "instance-order",
            ];
            CqlBoolean az_ = context.Operators.In<string>(ax_, (IEnumerable<string>)ay_);
            return az_;
        }


        (CqlTupleMetadata, string id, CodeableConcept requestStatusReason, CqlDateTime authoredOn)? m_(ServiceRequest DeviceNotOrder) {
            Id ba_ = DeviceNotOrder?.IdElement;
            string bb_ = ba_?.Value;

            bool? bc_(Extension @this) {
                FhirUri bl_ = @this?.UrlElement;
                string bm_ = FHIRHelpers_4_4_000.Instance.ToString(context, bl_);
                CqlBoolean bn_ = context.Operators.Equal(bm_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-doNotPerformReason");
                return bn_;
            }


            object bd_(Extension @this) {
                DataType bo_ = @this?.Value;
                return bo_;
            }

            IEnumerable<object> be_ = context.Operators.WhereSelect<Extension, object>((IEnumerable<Extension>)(DeviceNotOrder is DomainResource
                ? (DeviceNotOrder as DomainResource).Extension
                : default), bc_, bd_);
            object bf_ = context.Operators.SingletonFrom<object>(be_);
            CqlConcept bg_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, bf_ as CodeableConcept);
            CodeableConcept bh_ = context.Operators.Convert<CodeableConcept>(bg_);
            FhirDateTime bi_ = DeviceNotOrder?.AuthoredOnElement;
            CqlDateTime bj_ = context.Operators.Convert<CqlDateTime>(bi_);
            (CqlTupleMetadata, string id, CodeableConcept requestStatusReason, CqlDateTime authoredOn)? bk_ = (CqlTupleMetadata_FVDRPQjOQgYIDhWKHCNhOHceF, bb_, bh_, bj_);
            return bk_;
        }

        IEnumerable<(CqlTupleMetadata, string id, CodeableConcept requestStatusReason, CqlDateTime authoredOn)?> n_ = context.Operators.WhereSelect<ServiceRequest, (CqlTupleMetadata, string id, CodeableConcept requestStatusReason, CqlDateTime authoredOn)?>(k_, l_, m_);
        IEnumerable<(CqlTupleMetadata, string id, CodeableConcept requestStatusReason, CqlDateTime authoredOn)?> o_ = context.Operators.Distinct<(CqlTupleMetadata, string id, CodeableConcept requestStatusReason, CqlDateTime authoredOn)?>(n_);

        (CqlTupleMetadata, string id, CqlConcept requestStatusReason, CqlDateTime authoredOn)? p_((CqlTupleMetadata, string id, CodeableConcept requestStatusReason, CqlDateTime authoredOn)? tuple_gnbatbigxtpdibanunzcndfbr) {
            if (tuple_gnbatbigxtpdibanunzcndfbr is null)
            {
                return default;
            }
            else
            {
                CqlConcept bp_ = context.Operators.Convert<CqlConcept>(tuple_gnbatbigxtpdibanunzcndfbr?.requestStatusReason);
                (CqlTupleMetadata, string id, CqlConcept requestStatusReason, CqlDateTime authoredOn)? bq_ = (CqlTupleMetadata_DheTAGNHbFgKVJGaRbPLJVjKH, tuple_gnbatbigxtpdibanunzcndfbr?.id, bp_, tuple_gnbatbigxtpdibanunzcndfbr?.authoredOn);
                return bq_;
            }
        }

        IEnumerable<(CqlTupleMetadata, string id, CqlConcept requestStatusReason, CqlDateTime authoredOn)?> q_ = context.Operators.Select<(CqlTupleMetadata, string id, CodeableConcept requestStatusReason, CqlDateTime authoredOn)?, (CqlTupleMetadata, string id, CqlConcept requestStatusReason, CqlDateTime authoredOn)?>(o_, p_);
        IEnumerable<ServiceRequest> r_ = context.Operators.Retrieve<ServiceRequest>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-servicerequest"));
        IEnumerable<ServiceRequest> s_ = context.Operators.Retrieve<ServiceRequest>(new RetrieveParameters(default, d_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-servicerequest"));
        IEnumerable<ServiceRequest> t_ = context.Operators.Union<ServiceRequest>(r_, s_);
        IEnumerable<ServiceRequest> u_ = context.Operators.Retrieve<ServiceRequest>(new RetrieveParameters(default, h_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-servicerequest"));
        IEnumerable<ServiceRequest> v_ = context.Operators.Union<ServiceRequest>(t_, u_);
        IEnumerable<Task> w_ = context.Operators.Retrieve<Task>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-taskrejected"));
        IEnumerable<ValueTuple<ServiceRequest, Task>> x_ = context.Operators.CrossJoin<ServiceRequest, Task>(v_, w_);

        (CqlTupleMetadata, ServiceRequest DeviceOrderReject, Task T)? y_(ValueTuple<ServiceRequest, Task> _valueTuple) {
            (CqlTupleMetadata, ServiceRequest DeviceOrderReject, Task T)? br_ = (CqlTupleMetadata_YYIDPXBNjhOGFRJKYRBMGChb, _valueTuple.Item1, _valueTuple.Item2);
            return br_;
        }


        bool? z_((CqlTupleMetadata, ServiceRequest DeviceOrderReject, Task T)? tuple_yyidpxbnjhogfrjkyrbmgchb) {
            Code<RequestIntent> bs_ = tuple_yyidpxbnjhogfrjkyrbmgchb?.DeviceOrderReject?.IntentElement;
            RequestIntent? bt_ = bs_?.Value;
            Code<RequestIntent> bu_ = context.Operators.Convert<Code<RequestIntent>>(bt_);
            string bv_ = context.Operators.Convert<string>(bu_);
            string[] bw_ = [
                "order",
                "original-order",
                "reflex-order",
                "filler-order",
                "instance-order",
            ];
            CqlBoolean bx_ = context.Operators.In<string>(bv_, (IEnumerable<string>)bw_);
            Code<RequestStatus> by_ = tuple_yyidpxbnjhogfrjkyrbmgchb?.DeviceOrderReject?.StatusElement;
            RequestStatus? bz_ = by_?.Value;
            Code<RequestStatus> ca_ = context.Operators.Convert<Code<RequestStatus>>(bz_);
            CqlBoolean cb_ = context.Operators.Equal(ca_, "active");
            CqlBoolean cc_ = cb_;
            ResourceReference cd_ = tuple_yyidpxbnjhogfrjkyrbmgchb?.T?.Focus;
            CqlBoolean ce_ = QICoreCommon_4_0_000.Instance.references(context, cd_, tuple_yyidpxbnjhogfrjkyrbmgchb?.DeviceOrderReject);
            CqlBoolean cf_ = ce_;
            CodeableConcept cg_ = tuple_yyidpxbnjhogfrjkyrbmgchb?.T?.Code;
            CqlConcept ch_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, cg_);
            CqlCode ci_ = QICoreCommon_4_0_000.Instance.Fulfill(context);
            CqlConcept cj_ = context.Operators.ConvertCodeToConcept(ci_);
            CqlBoolean ck_ = context.Operators.Equivalent(ch_, cj_);
            CqlBoolean cl_ = ck_;
            return bx_
                /* CQL 'and' (346:15-347:49) */ && cc_
                /* CQL 'and' (346:15-348:54) */ && cf_
                /* CQL 'and' (346:9-349:45) */ && cl_;
        }

        IEnumerable<(CqlTupleMetadata, ServiceRequest DeviceOrderReject, Task T)?> aa_ = context.Operators.SelectWhere<ValueTuple<ServiceRequest, Task>, (CqlTupleMetadata, ServiceRequest DeviceOrderReject, Task T)?>(x_, y_, z_);

        (CqlTupleMetadata, string id, CqlConcept requestStatusReason, CqlDateTime authoredOn)? ab_((CqlTupleMetadata, ServiceRequest DeviceOrderReject, Task T)? tuple_yyidpxbnjhogfrjkyrbmgchb) {
            Id cm_ = tuple_yyidpxbnjhogfrjkyrbmgchb?.DeviceOrderReject?.IdElement;
            string cn_ = cm_?.Value;
            CodeableConcept co_ = tuple_yyidpxbnjhogfrjkyrbmgchb?.T?.StatusReason;
            CqlConcept cp_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, co_);
            FhirDateTime cq_ = tuple_yyidpxbnjhogfrjkyrbmgchb?.DeviceOrderReject?.AuthoredOnElement;
            CqlDateTime cr_ = context.Operators.Convert<CqlDateTime>(cq_);
            (CqlTupleMetadata, string id, CqlConcept requestStatusReason, CqlDateTime authoredOn)? cs_ = (CqlTupleMetadata_DheTAGNHbFgKVJGaRbPLJVjKH, cn_, cp_, cr_);
            return cs_;
        }

        IEnumerable<(CqlTupleMetadata, string id, CqlConcept requestStatusReason, CqlDateTime authoredOn)?> ac_ = context.Operators.SelectDistinct<(CqlTupleMetadata, ServiceRequest DeviceOrderReject, Task T)?, (CqlTupleMetadata, string id, CqlConcept requestStatusReason, CqlDateTime authoredOn)?>(aa_, ab_);
        IEnumerable<(CqlTupleMetadata, string id, CqlConcept requestStatusReason, CqlDateTime authoredOn)?> ad_ = context.Operators.Union<(CqlTupleMetadata, string id, CqlConcept requestStatusReason, CqlDateTime authoredOn)?>(q_, ac_);
        CqlValueSet ae_ = this.Application_of_Intermittent_Pneumatic_Compression_Devices(context);
        IEnumerable<Procedure> af_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, ae_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedurenotdone"));
        IEnumerable<Procedure> ag_ = context.Operators.Union<Procedure>(af_, af_);
        CqlValueSet ah_ = this.Application_of_Venous_Foot_Pumps(context);
        IEnumerable<Procedure> ai_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, ah_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedurenotdone"));
        IEnumerable<Procedure> aj_ = context.Operators.Union<Procedure>(ai_, ai_);
        IEnumerable<Procedure> ak_ = context.Operators.Union<Procedure>(ag_, aj_);
        CqlValueSet al_ = this.Application_of_Graduated_Compression_Stockings(context);
        IEnumerable<Procedure> am_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, al_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedurenotdone"));
        IEnumerable<Procedure> an_ = context.Operators.Union<Procedure>(am_, am_);
        IEnumerable<Procedure> ao_ = context.Operators.Union<Procedure>(ak_, an_);

        (CqlTupleMetadata, string id, CqlConcept requestStatusReason, FhirDateTime authoredOn)? ap_(Procedure DeviceNotApplied) {
            Id ct_ = DeviceNotApplied?.IdElement;
            string cu_ = ct_?.Value;
            CodeableConcept cv_ = DeviceNotApplied?.StatusReason;
            CqlConcept cw_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, cv_);

            bool? cx_(Extension @this) {
                FhirUri dd_ = @this?.UrlElement;
                string de_ = FHIRHelpers_4_4_000.Instance.ToString(context, dd_);
                CqlBoolean df_ = context.Operators.Equal(de_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-recorded");
                return df_;
            }


            DataType cy_(Extension @this) {
                DataType dg_ = @this?.Value;
                return dg_;
            }

            IEnumerable<DataType> cz_ = context.Operators.WhereSelect<Extension, DataType>((IEnumerable<Extension>)(DeviceNotApplied is DomainResource
                ? (DeviceNotApplied as DomainResource).Extension
                : default), cx_, cy_);
            DataType da_ = context.Operators.SingletonFrom<DataType>(cz_);
            FhirDateTime db_ = context.Operators.Convert<FhirDateTime>(da_);
            (CqlTupleMetadata, string id, CqlConcept requestStatusReason, FhirDateTime authoredOn)? dc_ = (CqlTupleMetadata_DPXDaXjPQUNAIiZCCbGhNdDMi, cu_, cw_, db_);
            return dc_;
        }

        IEnumerable<(CqlTupleMetadata, string id, CqlConcept requestStatusReason, FhirDateTime authoredOn)?> aq_ = context.Operators.SelectDistinct<Procedure, (CqlTupleMetadata, string id, CqlConcept requestStatusReason, FhirDateTime authoredOn)?>(ao_, ap_);

        (CqlTupleMetadata, string id, CqlConcept requestStatusReason, CqlDateTime authoredOn)? ar_((CqlTupleMetadata, string id, CqlConcept requestStatusReason, FhirDateTime authoredOn)? tuple_fcgxmnobtfvlcbqjjfugxtftk) {
            if (tuple_fcgxmnobtfvlcbqjjfugxtftk is null)
            {
                return default;
            }
            else
            {
                CqlDateTime dh_ = context.Operators.Convert<CqlDateTime>(tuple_fcgxmnobtfvlcbqjjfugxtftk?.authoredOn);
                (CqlTupleMetadata, string id, CqlConcept requestStatusReason, CqlDateTime authoredOn)? di_ = (CqlTupleMetadata_DheTAGNHbFgKVJGaRbPLJVjKH, tuple_fcgxmnobtfvlcbqjjfugxtftk?.id, tuple_fcgxmnobtfvlcbqjjfugxtftk?.requestStatusReason, dh_);
                return di_;
            }
        }

        IEnumerable<(CqlTupleMetadata, string id, CqlConcept requestStatusReason, CqlDateTime authoredOn)?> as_ = context.Operators.Select<(CqlTupleMetadata, string id, CqlConcept requestStatusReason, FhirDateTime authoredOn)?, (CqlTupleMetadata, string id, CqlConcept requestStatusReason, CqlDateTime authoredOn)?>(aq_, ar_);
        IEnumerable<(CqlTupleMetadata, string id, CqlConcept requestStatusReason, CqlDateTime authoredOn)?> at_ = context.Operators.Union<(CqlTupleMetadata, string id, CqlConcept requestStatusReason, CqlDateTime authoredOn)?>(ad_, as_);
        return at_;
    }


    [CqlExpressionDefinition("No Mechanical VTE Prophylaxis Due To Medical Reason From Day Of Start Of Hospitalization To Day After First ICU Stay")]
    public IEnumerable<Encounter> No_Mechanical_VTE_Prophylaxis_Due_To_Medical_Reason_From_Day_Of_Start_Of_Hospitalization_To_Day_After_First_ICU_Stay(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_No_Mechanical_VTE_Prophylaxis_Due_To_Medical_Reason_From_Day_Of_Start_Of_Hospitalization_To_Day_After_First_ICU_Stay, No_Mechanical_VTE_Prophylaxis_Due_To_Medical_Reason_From_Day_Of_Start_Of_Hospitalization_To_Day_After_First_ICU_Stay_Compute);

    private const long _cacheIndex_No_Mechanical_VTE_Prophylaxis_Due_To_Medical_Reason_From_Day_Of_Start_Of_Hospitalization_To_Day_After_First_ICU_Stay = -985782402085122985L;

    private IEnumerable<Encounter> No_Mechanical_VTE_Prophylaxis_Due_To_Medical_Reason_From_Day_Of_Start_Of_Hospitalization_To_Day_After_First_ICU_Stay_Compute(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Encounter_With_ICU_Location(context);

        bool? b_(Encounter QualifyingEncounterICU) {
            IEnumerable<(CqlTupleMetadata, string id, CqlConcept requestStatusReason, CqlDateTime authoredOn)?> d_ = this.No_Mechanical_VTE_Prophylaxis_Performed_Or_Ordered(context);

            bool? e_((CqlTupleMetadata, string id, CqlConcept requestStatusReason, CqlDateTime authoredOn)? NoVTEDevice) {
                CqlConcept g_ = NoVTEDevice?.requestStatusReason;
                CqlValueSet h_ = this.Medical_Reason_For_Not_Providing_Treatment(context);
                CqlBoolean i_ = context.Operators.ConceptInValueSet(g_, h_);
                CqlDateTime j_ = NoVTEDevice?.authoredOn;
                CqlInterval<CqlDate> k_ = this.fromDayOfStartOfHospitalizationToDayAfterFirstICU(context, QualifyingEncounterICU);
                CqlDate l_ = k_?.low;
                CqlDateTime m_ = context.Operators.ConvertDateToDateTime(l_);
                CqlDate n_ = k_?.high;
                CqlDateTime o_ = context.Operators.ConvertDateToDateTime(n_);
                CqlBoolean p_ = k_?.lowClosed;
                CqlBoolean q_ = k_?.highClosed;
                CqlInterval<CqlDateTime> r_ = context.Operators.Interval(m_, o_, p_, q_);
                CqlBoolean s_ = context.Operators.In<CqlDateTime>(j_, r_, "day");
                CqlBoolean t_ = s_;
                return i_
                    /* CQL 'and' (327:17-328:125) */ && t_;
            }

            CqlBoolean f_ = context.Operators.WhereAny<(CqlTupleMetadata, string id, CqlConcept requestStatusReason, CqlDateTime authoredOn)?>(d_, e_);
            return f_;
        }

        IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);
        return c_;
    }


    [CqlExpressionDefinition("No VTE Prophylaxis Medication Due To Medical Reason On Day Of Or Day After Procedure")]
    public IEnumerable<Encounter> No_VTE_Prophylaxis_Medication_Due_To_Medical_Reason_On_Day_Of_Or_Day_After_Procedure(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_No_VTE_Prophylaxis_Medication_Due_To_Medical_Reason_On_Day_Of_Or_Day_After_Procedure, No_VTE_Prophylaxis_Medication_Due_To_Medical_Reason_On_Day_Of_Or_Day_After_Procedure_Compute);

    private const long _cacheIndex_No_VTE_Prophylaxis_Medication_Due_To_Medical_Reason_On_Day_Of_Or_Day_After_Procedure = 3680283336268144863L;

    private IEnumerable<Encounter> No_VTE_Prophylaxis_Medication_Due_To_Medical_Reason_On_Day_Of_Or_Day_After_Procedure_Compute(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Encounter_With_ICU_Location(context);
        CqlValueSet b_ = this.General_or_Neuraxial_Anesthesia(context);
        IEnumerable<Procedure> c_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, b_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
        IEnumerable<(CqlTupleMetadata, string id, IEnumerable<CqlConcept> medicationStatusReason, CqlDateTime authoredOn)?> d_ = this.No_VTE_Prophylaxis_Medication_Administered_Or_Ordered(context);
        IEnumerable<ValueTuple<Encounter, Procedure, (CqlTupleMetadata, string id, IEnumerable<CqlConcept> medicationStatusReason, CqlDateTime authoredOn)?>> e_ = context.Operators.CrossJoin<Encounter, Procedure, (CqlTupleMetadata, string id, IEnumerable<CqlConcept> medicationStatusReason, CqlDateTime authoredOn)?>(a_, c_, d_);

        (CqlTupleMetadata, Encounter QualifyingEncounterICU, Procedure AnesthesiaProcedure, (CqlTupleMetadata, string id, IEnumerable<CqlConcept> medicationStatusReason, CqlDateTime authoredOn)? NoVTEMedication)? f_(ValueTuple<Encounter, Procedure, (CqlTupleMetadata, string id, IEnumerable<CqlConcept> medicationStatusReason, CqlDateTime authoredOn)?> _valueTuple) {
            (CqlTupleMetadata, Encounter QualifyingEncounterICU, Procedure AnesthesiaProcedure, (CqlTupleMetadata, string id, IEnumerable<CqlConcept> medicationStatusReason, CqlDateTime authoredOn)? NoVTEMedication)? k_ = (CqlTupleMetadata_HLCXTKCfUejcHSahcUNeWcYFC, _valueTuple.Item1, _valueTuple.Item2, _valueTuple.Item3);
            return k_;
        }


        bool? g_((CqlTupleMetadata, Encounter QualifyingEncounterICU, Procedure AnesthesiaProcedure, (CqlTupleMetadata, string id, IEnumerable<CqlConcept> medicationStatusReason, CqlDateTime authoredOn)? NoVTEMedication)? tuple_fpgtpszgoyfdaobujrgcsedde) {
            IEnumerable<CqlConcept> l_ = tuple_fpgtpszgoyfdaobujrgcsedde?.NoVTEMedication?.medicationStatusReason;
            CqlValueSet m_ = this.Medical_Reason_For_Not_Providing_Treatment(context);
            CqlBoolean n_ = context.Operators.ConceptsInValueSet(l_, m_);
            Code<EventStatus> o_ = tuple_fpgtpszgoyfdaobujrgcsedde?.AnesthesiaProcedure?.StatusElement;
            EventStatus? p_ = o_?.Value;
            string q_ = context.Operators.Convert<string>(p_);
            CqlBoolean r_ = context.Operators.Equal(q_, "completed");
            CqlBoolean s_ = r_;
            object t_;
            DataType bb_ = tuple_fpgtpszgoyfdaobujrgcsedde?.AnesthesiaProcedure?.Performed;
            object bc_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bb_);
            bool bd_ = bc_ is CqlDateTime;
            if (bd_)
            {
                t_ = bc_ as CqlDateTime;
            }
            else
            {
                bool be_ = bc_ is CqlQuantity;
                if (be_)
                {
                    t_ = bc_ as CqlQuantity;
                }
                else
                {
                    bool bf_ = bc_ is CqlInterval<CqlDateTime>;
                    if (bf_)
                    {
                        t_ = bc_ as CqlInterval<CqlDateTime>;
                    }
                    else
                    {
                        bool bg_ = bc_ is CqlInterval<CqlQuantity>;
                        if (bg_)
                        {
                            t_ = bc_ as CqlInterval<CqlQuantity>;
                        }
                        else
                        {
                            t_ = null;
                        }
                    }
                }
            }
            CqlInterval<CqlDateTime> u_ = QICoreCommon_4_0_000.Instance.toInterval(context, t_);
            CqlDateTime v_ = context.Operators.End(u_);
            CqlDateTime w_ = this.startOfFirstICU(context, tuple_fpgtpszgoyfdaobujrgcsedde?.QualifyingEncounterICU);
            CqlQuantity x_ = context.Operators.Quantity(1m, "day");
            CqlDateTime y_ = context.Operators.Add(w_, x_);
            CqlBoolean z_ = context.Operators.SameAs(v_, y_, "day");
            CqlBoolean aa_ = z_;
            CqlDateTime ab_ = tuple_fpgtpszgoyfdaobujrgcsedde?.NoVTEMedication?.authoredOn;
            object ac_;
            DataType bh_ = tuple_fpgtpszgoyfdaobujrgcsedde?.AnesthesiaProcedure?.Performed;
            object bi_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bh_);
            bool bj_ = bi_ is CqlDateTime;
            if (bj_)
            {
                ac_ = bi_ as CqlDateTime;
            }
            else
            {
                bool bk_ = bi_ is CqlQuantity;
                if (bk_)
                {
                    ac_ = bi_ as CqlQuantity;
                }
                else
                {
                    bool bl_ = bi_ is CqlInterval<CqlDateTime>;
                    if (bl_)
                    {
                        ac_ = bi_ as CqlInterval<CqlDateTime>;
                    }
                    else
                    {
                        bool bm_ = bi_ is CqlInterval<CqlQuantity>;
                        if (bm_)
                        {
                            ac_ = bi_ as CqlInterval<CqlQuantity>;
                        }
                        else
                        {
                            ac_ = null;
                        }
                    }
                }
            }
            CqlInterval<CqlDateTime> ad_ = QICoreCommon_4_0_000.Instance.toInterval(context, ac_);
            CqlDateTime ae_ = context.Operators.End(ad_);
            CqlInterval<CqlDate> af_ = TJCOverall_8_25_000.Instance.calendarDayOfOrDayAfter(context, ae_);
            CqlDate ag_ = af_?.low;
            CqlDateTime ah_ = context.Operators.ConvertDateToDateTime(ag_);
            object ai_;
            DataType bn_ = tuple_fpgtpszgoyfdaobujrgcsedde?.AnesthesiaProcedure?.Performed;
            object bo_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bn_);
            bool bp_ = bo_ is CqlDateTime;
            if (bp_)
            {
                ai_ = bo_ as CqlDateTime;
            }
            else
            {
                bool bq_ = bo_ is CqlQuantity;
                if (bq_)
                {
                    ai_ = bo_ as CqlQuantity;
                }
                else
                {
                    bool br_ = bo_ is CqlInterval<CqlDateTime>;
                    if (br_)
                    {
                        ai_ = bo_ as CqlInterval<CqlDateTime>;
                    }
                    else
                    {
                        bool bs_ = bo_ is CqlInterval<CqlQuantity>;
                        if (bs_)
                        {
                            ai_ = bo_ as CqlInterval<CqlQuantity>;
                        }
                        else
                        {
                            ai_ = null;
                        }
                    }
                }
            }
            CqlInterval<CqlDateTime> aj_ = QICoreCommon_4_0_000.Instance.toInterval(context, ai_);
            CqlDateTime ak_ = context.Operators.End(aj_);
            CqlInterval<CqlDate> al_ = TJCOverall_8_25_000.Instance.calendarDayOfOrDayAfter(context, ak_);
            CqlDate am_ = al_?.high;
            CqlDateTime an_ = context.Operators.ConvertDateToDateTime(am_);
            object ao_;
            DataType bt_ = tuple_fpgtpszgoyfdaobujrgcsedde?.AnesthesiaProcedure?.Performed;
            object bu_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bt_);
            bool bv_ = bu_ is CqlDateTime;
            if (bv_)
            {
                ao_ = bu_ as CqlDateTime;
            }
            else
            {
                bool bw_ = bu_ is CqlQuantity;
                if (bw_)
                {
                    ao_ = bu_ as CqlQuantity;
                }
                else
                {
                    bool bx_ = bu_ is CqlInterval<CqlDateTime>;
                    if (bx_)
                    {
                        ao_ = bu_ as CqlInterval<CqlDateTime>;
                    }
                    else
                    {
                        bool by_ = bu_ is CqlInterval<CqlQuantity>;
                        if (by_)
                        {
                            ao_ = bu_ as CqlInterval<CqlQuantity>;
                        }
                        else
                        {
                            ao_ = null;
                        }
                    }
                }
            }
            CqlInterval<CqlDateTime> ap_ = QICoreCommon_4_0_000.Instance.toInterval(context, ao_);
            CqlDateTime aq_ = context.Operators.End(ap_);
            CqlInterval<CqlDate> ar_ = TJCOverall_8_25_000.Instance.calendarDayOfOrDayAfter(context, aq_);
            CqlBoolean as_ = ar_?.lowClosed;
            object at_;
            DataType bz_ = tuple_fpgtpszgoyfdaobujrgcsedde?.AnesthesiaProcedure?.Performed;
            object ca_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bz_);
            bool cb_ = ca_ is CqlDateTime;
            if (cb_)
            {
                at_ = ca_ as CqlDateTime;
            }
            else
            {
                bool cc_ = ca_ is CqlQuantity;
                if (cc_)
                {
                    at_ = ca_ as CqlQuantity;
                }
                else
                {
                    bool cd_ = ca_ is CqlInterval<CqlDateTime>;
                    if (cd_)
                    {
                        at_ = ca_ as CqlInterval<CqlDateTime>;
                    }
                    else
                    {
                        bool ce_ = ca_ is CqlInterval<CqlQuantity>;
                        if (ce_)
                        {
                            at_ = ca_ as CqlInterval<CqlQuantity>;
                        }
                        else
                        {
                            at_ = null;
                        }
                    }
                }
            }
            CqlInterval<CqlDateTime> au_ = QICoreCommon_4_0_000.Instance.toInterval(context, at_);
            CqlDateTime av_ = context.Operators.End(au_);
            CqlInterval<CqlDate> aw_ = TJCOverall_8_25_000.Instance.calendarDayOfOrDayAfter(context, av_);
            CqlBoolean ax_ = aw_?.highClosed;
            CqlInterval<CqlDateTime> ay_ = context.Operators.Interval(ah_, an_, as_, ax_);
            CqlBoolean az_ = context.Operators.In<CqlDateTime>(ab_, ay_, "day");
            CqlBoolean ba_ = az_;
            return n_
                /* CQL 'and' (372:11-373:50) */ && s_
                /* CQL 'and' (372:11-374:121) */ && aa_
                /* CQL 'and' (372:5-375:134) */ && ba_;
        }

        IEnumerable<(CqlTupleMetadata, Encounter QualifyingEncounterICU, Procedure AnesthesiaProcedure, (CqlTupleMetadata, string id, IEnumerable<CqlConcept> medicationStatusReason, CqlDateTime authoredOn)? NoVTEMedication)?> h_ = context.Operators.SelectWhere<ValueTuple<Encounter, Procedure, (CqlTupleMetadata, string id, IEnumerable<CqlConcept> medicationStatusReason, CqlDateTime authoredOn)?>, (CqlTupleMetadata, Encounter QualifyingEncounterICU, Procedure AnesthesiaProcedure, (CqlTupleMetadata, string id, IEnumerable<CqlConcept> medicationStatusReason, CqlDateTime authoredOn)? NoVTEMedication)?>(e_, f_, g_);
        Encounter i_((CqlTupleMetadata, Encounter QualifyingEncounterICU, Procedure AnesthesiaProcedure, (CqlTupleMetadata, string id, IEnumerable<CqlConcept> medicationStatusReason, CqlDateTime authoredOn)? NoVTEMedication)? tuple_fpgtpszgoyfdaobujrgcsedde) => tuple_fpgtpszgoyfdaobujrgcsedde?.QualifyingEncounterICU;
        IEnumerable<Encounter> j_ = context.Operators.SelectDistinct<(CqlTupleMetadata, Encounter QualifyingEncounterICU, Procedure AnesthesiaProcedure, (CqlTupleMetadata, string id, IEnumerable<CqlConcept> medicationStatusReason, CqlDateTime authoredOn)? NoVTEMedication)?, Encounter>(h_, i_);
        return j_;
    }


    [CqlExpressionDefinition("No Mechanical VTE Prophylaxis Due To Medical Reason On Day Of Or Day After Procedure")]
    public IEnumerable<Encounter> No_Mechanical_VTE_Prophylaxis_Due_To_Medical_Reason_On_Day_Of_Or_Day_After_Procedure(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_No_Mechanical_VTE_Prophylaxis_Due_To_Medical_Reason_On_Day_Of_Or_Day_After_Procedure, No_Mechanical_VTE_Prophylaxis_Due_To_Medical_Reason_On_Day_Of_Or_Day_After_Procedure_Compute);

    private const long _cacheIndex_No_Mechanical_VTE_Prophylaxis_Due_To_Medical_Reason_On_Day_Of_Or_Day_After_Procedure = -6270123653132032094L;

    private IEnumerable<Encounter> No_Mechanical_VTE_Prophylaxis_Due_To_Medical_Reason_On_Day_Of_Or_Day_After_Procedure_Compute(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Encounter_With_ICU_Location(context);
        CqlValueSet b_ = this.General_or_Neuraxial_Anesthesia(context);
        IEnumerable<Procedure> c_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, b_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
        IEnumerable<(CqlTupleMetadata, string id, CqlConcept requestStatusReason, CqlDateTime authoredOn)?> d_ = this.No_Mechanical_VTE_Prophylaxis_Performed_Or_Ordered(context);
        IEnumerable<ValueTuple<Encounter, Procedure, (CqlTupleMetadata, string id, CqlConcept requestStatusReason, CqlDateTime authoredOn)?>> e_ = context.Operators.CrossJoin<Encounter, Procedure, (CqlTupleMetadata, string id, CqlConcept requestStatusReason, CqlDateTime authoredOn)?>(a_, c_, d_);

        (CqlTupleMetadata, Encounter QualifyingEncounterICU, Procedure AnesthesiaProcedure, (CqlTupleMetadata, string id, CqlConcept requestStatusReason, CqlDateTime authoredOn)? NoVTEDevice)? f_(ValueTuple<Encounter, Procedure, (CqlTupleMetadata, string id, CqlConcept requestStatusReason, CqlDateTime authoredOn)?> _valueTuple) {
            (CqlTupleMetadata, Encounter QualifyingEncounterICU, Procedure AnesthesiaProcedure, (CqlTupleMetadata, string id, CqlConcept requestStatusReason, CqlDateTime authoredOn)? NoVTEDevice)? k_ = (CqlTupleMetadata_ifVVXcOGTAXRRBdEBOYOhXCQ, _valueTuple.Item1, _valueTuple.Item2, _valueTuple.Item3);
            return k_;
        }


        bool? g_((CqlTupleMetadata, Encounter QualifyingEncounterICU, Procedure AnesthesiaProcedure, (CqlTupleMetadata, string id, CqlConcept requestStatusReason, CqlDateTime authoredOn)? NoVTEDevice)? tuple_fnrkedfurymcjidjkbtaenork) {
            CqlConcept l_ = tuple_fnrkedfurymcjidjkbtaenork?.NoVTEDevice?.requestStatusReason;
            CqlValueSet m_ = this.Medical_Reason_For_Not_Providing_Treatment(context);
            CqlBoolean n_ = context.Operators.ConceptInValueSet(l_, m_);
            Code<EventStatus> o_ = tuple_fnrkedfurymcjidjkbtaenork?.AnesthesiaProcedure?.StatusElement;
            EventStatus? p_ = o_?.Value;
            string q_ = context.Operators.Convert<string>(p_);
            CqlBoolean r_ = context.Operators.Equal(q_, "completed");
            CqlBoolean s_ = r_;
            object t_;
            DataType bb_ = tuple_fnrkedfurymcjidjkbtaenork?.AnesthesiaProcedure?.Performed;
            object bc_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bb_);
            bool bd_ = bc_ is CqlDateTime;
            if (bd_)
            {
                t_ = bc_ as CqlDateTime;
            }
            else
            {
                bool be_ = bc_ is CqlQuantity;
                if (be_)
                {
                    t_ = bc_ as CqlQuantity;
                }
                else
                {
                    bool bf_ = bc_ is CqlInterval<CqlDateTime>;
                    if (bf_)
                    {
                        t_ = bc_ as CqlInterval<CqlDateTime>;
                    }
                    else
                    {
                        bool bg_ = bc_ is CqlInterval<CqlQuantity>;
                        if (bg_)
                        {
                            t_ = bc_ as CqlInterval<CqlQuantity>;
                        }
                        else
                        {
                            t_ = null;
                        }
                    }
                }
            }
            CqlInterval<CqlDateTime> u_ = QICoreCommon_4_0_000.Instance.toInterval(context, t_);
            CqlDateTime v_ = context.Operators.End(u_);
            CqlDateTime w_ = this.startOfFirstICU(context, tuple_fnrkedfurymcjidjkbtaenork?.QualifyingEncounterICU);
            CqlQuantity x_ = context.Operators.Quantity(1m, "day");
            CqlDateTime y_ = context.Operators.Add(w_, x_);
            CqlBoolean z_ = context.Operators.SameAs(v_, y_, "day");
            CqlBoolean aa_ = z_;
            CqlDateTime ab_ = tuple_fnrkedfurymcjidjkbtaenork?.NoVTEDevice?.authoredOn;
            object ac_;
            DataType bh_ = tuple_fnrkedfurymcjidjkbtaenork?.AnesthesiaProcedure?.Performed;
            object bi_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bh_);
            bool bj_ = bi_ is CqlDateTime;
            if (bj_)
            {
                ac_ = bi_ as CqlDateTime;
            }
            else
            {
                bool bk_ = bi_ is CqlQuantity;
                if (bk_)
                {
                    ac_ = bi_ as CqlQuantity;
                }
                else
                {
                    bool bl_ = bi_ is CqlInterval<CqlDateTime>;
                    if (bl_)
                    {
                        ac_ = bi_ as CqlInterval<CqlDateTime>;
                    }
                    else
                    {
                        bool bm_ = bi_ is CqlInterval<CqlQuantity>;
                        if (bm_)
                        {
                            ac_ = bi_ as CqlInterval<CqlQuantity>;
                        }
                        else
                        {
                            ac_ = null;
                        }
                    }
                }
            }
            CqlInterval<CqlDateTime> ad_ = QICoreCommon_4_0_000.Instance.toInterval(context, ac_);
            CqlDateTime ae_ = context.Operators.End(ad_);
            CqlInterval<CqlDate> af_ = TJCOverall_8_25_000.Instance.calendarDayOfOrDayAfter(context, ae_);
            CqlDate ag_ = af_?.low;
            CqlDateTime ah_ = context.Operators.ConvertDateToDateTime(ag_);
            object ai_;
            DataType bn_ = tuple_fnrkedfurymcjidjkbtaenork?.AnesthesiaProcedure?.Performed;
            object bo_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bn_);
            bool bp_ = bo_ is CqlDateTime;
            if (bp_)
            {
                ai_ = bo_ as CqlDateTime;
            }
            else
            {
                bool bq_ = bo_ is CqlQuantity;
                if (bq_)
                {
                    ai_ = bo_ as CqlQuantity;
                }
                else
                {
                    bool br_ = bo_ is CqlInterval<CqlDateTime>;
                    if (br_)
                    {
                        ai_ = bo_ as CqlInterval<CqlDateTime>;
                    }
                    else
                    {
                        bool bs_ = bo_ is CqlInterval<CqlQuantity>;
                        if (bs_)
                        {
                            ai_ = bo_ as CqlInterval<CqlQuantity>;
                        }
                        else
                        {
                            ai_ = null;
                        }
                    }
                }
            }
            CqlInterval<CqlDateTime> aj_ = QICoreCommon_4_0_000.Instance.toInterval(context, ai_);
            CqlDateTime ak_ = context.Operators.End(aj_);
            CqlInterval<CqlDate> al_ = TJCOverall_8_25_000.Instance.calendarDayOfOrDayAfter(context, ak_);
            CqlDate am_ = al_?.high;
            CqlDateTime an_ = context.Operators.ConvertDateToDateTime(am_);
            object ao_;
            DataType bt_ = tuple_fnrkedfurymcjidjkbtaenork?.AnesthesiaProcedure?.Performed;
            object bu_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bt_);
            bool bv_ = bu_ is CqlDateTime;
            if (bv_)
            {
                ao_ = bu_ as CqlDateTime;
            }
            else
            {
                bool bw_ = bu_ is CqlQuantity;
                if (bw_)
                {
                    ao_ = bu_ as CqlQuantity;
                }
                else
                {
                    bool bx_ = bu_ is CqlInterval<CqlDateTime>;
                    if (bx_)
                    {
                        ao_ = bu_ as CqlInterval<CqlDateTime>;
                    }
                    else
                    {
                        bool by_ = bu_ is CqlInterval<CqlQuantity>;
                        if (by_)
                        {
                            ao_ = bu_ as CqlInterval<CqlQuantity>;
                        }
                        else
                        {
                            ao_ = null;
                        }
                    }
                }
            }
            CqlInterval<CqlDateTime> ap_ = QICoreCommon_4_0_000.Instance.toInterval(context, ao_);
            CqlDateTime aq_ = context.Operators.End(ap_);
            CqlInterval<CqlDate> ar_ = TJCOverall_8_25_000.Instance.calendarDayOfOrDayAfter(context, aq_);
            CqlBoolean as_ = ar_?.lowClosed;
            object at_;
            DataType bz_ = tuple_fnrkedfurymcjidjkbtaenork?.AnesthesiaProcedure?.Performed;
            object ca_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bz_);
            bool cb_ = ca_ is CqlDateTime;
            if (cb_)
            {
                at_ = ca_ as CqlDateTime;
            }
            else
            {
                bool cc_ = ca_ is CqlQuantity;
                if (cc_)
                {
                    at_ = ca_ as CqlQuantity;
                }
                else
                {
                    bool cd_ = ca_ is CqlInterval<CqlDateTime>;
                    if (cd_)
                    {
                        at_ = ca_ as CqlInterval<CqlDateTime>;
                    }
                    else
                    {
                        bool ce_ = ca_ is CqlInterval<CqlQuantity>;
                        if (ce_)
                        {
                            at_ = ca_ as CqlInterval<CqlQuantity>;
                        }
                        else
                        {
                            at_ = null;
                        }
                    }
                }
            }
            CqlInterval<CqlDateTime> au_ = QICoreCommon_4_0_000.Instance.toInterval(context, at_);
            CqlDateTime av_ = context.Operators.End(au_);
            CqlInterval<CqlDate> aw_ = TJCOverall_8_25_000.Instance.calendarDayOfOrDayAfter(context, av_);
            CqlBoolean ax_ = aw_?.highClosed;
            CqlInterval<CqlDateTime> ay_ = context.Operators.Interval(ah_, an_, as_, ax_);
            CqlBoolean az_ = context.Operators.In<CqlDateTime>(ab_, ay_, "day");
            CqlBoolean ba_ = az_;
            return n_
                /* CQL 'and' (383:11-384:50) */ && s_
                /* CQL 'and' (383:11-385:121) */ && aa_
                /* CQL 'and' (383:5-386:130) */ && ba_;
        }

        IEnumerable<(CqlTupleMetadata, Encounter QualifyingEncounterICU, Procedure AnesthesiaProcedure, (CqlTupleMetadata, string id, CqlConcept requestStatusReason, CqlDateTime authoredOn)? NoVTEDevice)?> h_ = context.Operators.SelectWhere<ValueTuple<Encounter, Procedure, (CqlTupleMetadata, string id, CqlConcept requestStatusReason, CqlDateTime authoredOn)?>, (CqlTupleMetadata, Encounter QualifyingEncounterICU, Procedure AnesthesiaProcedure, (CqlTupleMetadata, string id, CqlConcept requestStatusReason, CqlDateTime authoredOn)? NoVTEDevice)?>(e_, f_, g_);
        Encounter i_((CqlTupleMetadata, Encounter QualifyingEncounterICU, Procedure AnesthesiaProcedure, (CqlTupleMetadata, string id, CqlConcept requestStatusReason, CqlDateTime authoredOn)? NoVTEDevice)? tuple_fnrkedfurymcjidjkbtaenork) => tuple_fnrkedfurymcjidjkbtaenork?.QualifyingEncounterICU;
        IEnumerable<Encounter> j_ = context.Operators.SelectDistinct<(CqlTupleMetadata, Encounter QualifyingEncounterICU, Procedure AnesthesiaProcedure, (CqlTupleMetadata, string id, CqlConcept requestStatusReason, CqlDateTime authoredOn)? NoVTEDevice)?, Encounter>(h_, i_);
        return j_;
    }


    [CqlExpressionDefinition("Encounter With No VTE Prophylaxis Due To Medical Reason")]
    public IEnumerable<Encounter> Encounter_With_No_VTE_Prophylaxis_Due_To_Medical_Reason(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Encounter_With_No_VTE_Prophylaxis_Due_To_Medical_Reason, Encounter_With_No_VTE_Prophylaxis_Due_To_Medical_Reason_Compute);

    private const long _cacheIndex_Encounter_With_No_VTE_Prophylaxis_Due_To_Medical_Reason = 6327046106447182309L;

    private IEnumerable<Encounter> Encounter_With_No_VTE_Prophylaxis_Due_To_Medical_Reason_Compute(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.No_VTE_Prophylaxis_Medication_Due_To_Medical_Reason_From_Day_Of_Start_Of_Hospitalization_To_Day_After_First_ICU_Stay(context);
        IEnumerable<Encounter> b_ = this.No_Mechanical_VTE_Prophylaxis_Due_To_Medical_Reason_From_Day_Of_Start_Of_Hospitalization_To_Day_After_First_ICU_Stay(context);
        IEnumerable<Encounter> c_ = context.Operators.Intersect<Encounter>(a_, b_);
        IEnumerable<Encounter> d_ = this.No_VTE_Prophylaxis_Medication_Due_To_Medical_Reason_On_Day_Of_Or_Day_After_Procedure(context);
        IEnumerable<Encounter> e_ = this.No_Mechanical_VTE_Prophylaxis_Due_To_Medical_Reason_On_Day_Of_Or_Day_After_Procedure(context);
        IEnumerable<Encounter> f_ = context.Operators.Intersect<Encounter>(d_, e_);
        IEnumerable<Encounter> g_ = context.Operators.Union<Encounter>(c_, f_);
        return g_;
    }


    [CqlExpressionDefinition("No Mechanical or Pharmacological VTE Prophylaxis Due To Patient Refusal")]
    public IEnumerable<object> No_Mechanical_or_Pharmacological_VTE_Prophylaxis_Due_To_Patient_Refusal(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_No_Mechanical_or_Pharmacological_VTE_Prophylaxis_Due_To_Patient_Refusal, No_Mechanical_or_Pharmacological_VTE_Prophylaxis_Due_To_Patient_Refusal_Compute);

    private const long _cacheIndex_No_Mechanical_or_Pharmacological_VTE_Prophylaxis_Due_To_Patient_Refusal = -634581821554015913L;

    private IEnumerable<object> No_Mechanical_or_Pharmacological_VTE_Prophylaxis_Due_To_Patient_Refusal_Compute(CqlContext context)
    {
        IEnumerable<(CqlTupleMetadata, string id, IEnumerable<CqlConcept> medicationStatusReason, CqlDateTime authoredOn)?> a_ = this.No_VTE_Prophylaxis_Medication_Administered_Or_Ordered(context);

        bool? b_((CqlTupleMetadata, string id, IEnumerable<CqlConcept> medicationStatusReason, CqlDateTime authoredOn)? NoVTEMedication) {
            IEnumerable<CqlConcept> j_ = NoVTEMedication?.medicationStatusReason;
            CqlValueSet k_ = this.Patient_Refusal(context);
            CqlBoolean l_ = context.Operators.ConceptsInValueSet(j_, k_);
            return l_;
        }

        object c_((CqlTupleMetadata, string id, IEnumerable<CqlConcept> medicationStatusReason, CqlDateTime authoredOn)? tuple_eodcxckcyhgehinqchjlrjuqw) => tuple_eodcxckcyhgehinqchjlrjuqw;
        IEnumerable<object> d_ = context.Operators.WhereSelect<(CqlTupleMetadata, string id, IEnumerable<CqlConcept> medicationStatusReason, CqlDateTime authoredOn)?, object>(a_, b_, c_);
        IEnumerable<(CqlTupleMetadata, string id, CqlConcept requestStatusReason, CqlDateTime authoredOn)?> e_ = this.No_Mechanical_VTE_Prophylaxis_Performed_Or_Ordered(context);

        bool? f_((CqlTupleMetadata, string id, CqlConcept requestStatusReason, CqlDateTime authoredOn)? NoVTEDevice) {
            CqlConcept m_ = NoVTEDevice?.requestStatusReason;
            CqlValueSet n_ = this.Patient_Refusal(context);
            CqlBoolean o_ = context.Operators.ConceptInValueSet(m_, n_);
            return o_;
        }

        object g_((CqlTupleMetadata, string id, CqlConcept requestStatusReason, CqlDateTime authoredOn)? tuple_dahzgfwmlihdcaesamjofzbqi) => tuple_dahzgfwmlihdcaesamjofzbqi;
        IEnumerable<object> h_ = context.Operators.WhereSelect<(CqlTupleMetadata, string id, CqlConcept requestStatusReason, CqlDateTime authoredOn)?, object>(e_, f_, g_);
        IEnumerable<object> i_ = context.Operators.Union<object>(d_, h_);
        return i_;
    }


    [CqlExpressionDefinition("No VTE Prophylaxis Due To Patient Refusal From Day Of Start Of Hospitalization To Day After First ICU Stay")]
    public IEnumerable<Encounter> No_VTE_Prophylaxis_Due_To_Patient_Refusal_From_Day_Of_Start_Of_Hospitalization_To_Day_After_First_ICU_Stay(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_No_VTE_Prophylaxis_Due_To_Patient_Refusal_From_Day_Of_Start_Of_Hospitalization_To_Day_After_First_ICU_Stay, No_VTE_Prophylaxis_Due_To_Patient_Refusal_From_Day_Of_Start_Of_Hospitalization_To_Day_After_First_ICU_Stay_Compute);

    private const long _cacheIndex_No_VTE_Prophylaxis_Due_To_Patient_Refusal_From_Day_Of_Start_Of_Hospitalization_To_Day_After_First_ICU_Stay = 1167693690454486814L;

    private IEnumerable<Encounter> No_VTE_Prophylaxis_Due_To_Patient_Refusal_From_Day_Of_Start_Of_Hospitalization_To_Day_After_First_ICU_Stay_Compute(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Encounter_With_ICU_Location(context);

        bool? b_(Encounter QualifyingEncounterICU) {
            IEnumerable<object> d_ = this.No_Mechanical_or_Pharmacological_VTE_Prophylaxis_Due_To_Patient_Refusal(context);

            bool? e_(object PatientRefusal) {
                CqlDateTime g_ = context.Operators.LateBoundProperty<CqlDateTime>(PatientRefusal, "authoredOn");
                CqlInterval<CqlDate> h_ = this.fromDayOfStartOfHospitalizationToDayAfterFirstICU(context, QualifyingEncounterICU);
                CqlDate i_ = h_?.low;
                CqlDateTime j_ = context.Operators.ConvertDateToDateTime(i_);
                CqlDate k_ = h_?.high;
                CqlDateTime l_ = context.Operators.ConvertDateToDateTime(k_);
                CqlBoolean m_ = h_?.lowClosed;
                CqlBoolean n_ = h_?.highClosed;
                CqlInterval<CqlDateTime> o_ = context.Operators.Interval(j_, l_, m_, n_);
                CqlBoolean p_ = context.Operators.In<CqlDateTime>(g_, o_, "day");
                return p_;
            }

            CqlBoolean f_ = context.Operators.WhereAny<object>(d_, e_);
            return f_;
        }

        IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);
        return c_;
    }


    [CqlExpressionDefinition("No VTE Prophylaxis Due To Patient Refusal On Day Of Or Day After Procedure")]
    public IEnumerable<Encounter> No_VTE_Prophylaxis_Due_To_Patient_Refusal_On_Day_Of_Or_Day_After_Procedure(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_No_VTE_Prophylaxis_Due_To_Patient_Refusal_On_Day_Of_Or_Day_After_Procedure, No_VTE_Prophylaxis_Due_To_Patient_Refusal_On_Day_Of_Or_Day_After_Procedure_Compute);

    private const long _cacheIndex_No_VTE_Prophylaxis_Due_To_Patient_Refusal_On_Day_Of_Or_Day_After_Procedure = 2814312995884451492L;

    private IEnumerable<Encounter> No_VTE_Prophylaxis_Due_To_Patient_Refusal_On_Day_Of_Or_Day_After_Procedure_Compute(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Encounter_With_ICU_Location(context);
        CqlValueSet b_ = this.General_or_Neuraxial_Anesthesia(context);
        IEnumerable<Procedure> c_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, b_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
        IEnumerable<object> d_ = this.No_Mechanical_or_Pharmacological_VTE_Prophylaxis_Due_To_Patient_Refusal(context);
        IEnumerable<ValueTuple<Encounter, Procedure, object>> e_ = context.Operators.CrossJoin<Encounter, Procedure, object>(a_, c_, d_);

        (CqlTupleMetadata, Encounter QualifyingEncounterICU, Procedure AnesthesiaProcedure, object PatientRefusal)? f_(ValueTuple<Encounter, Procedure, object> _valueTuple) {
            (CqlTupleMetadata, Encounter QualifyingEncounterICU, Procedure AnesthesiaProcedure, object PatientRefusal)? k_ = (CqlTupleMetadata_MYMdRYUDSjLaJAMGKSYBKOjf, _valueTuple.Item1, _valueTuple.Item2, _valueTuple.Item3);
            return k_;
        }


        bool? g_((CqlTupleMetadata, Encounter QualifyingEncounterICU, Procedure AnesthesiaProcedure, object PatientRefusal)? tuple_bvgardhyjgbgfxidntuflexa) {
            Code<EventStatus> l_ = tuple_bvgardhyjgbgfxidntuflexa?.AnesthesiaProcedure?.StatusElement;
            EventStatus? m_ = l_?.Value;
            string n_ = context.Operators.Convert<string>(m_);
            CqlBoolean o_ = context.Operators.Equal(n_, "completed");
            object p_;
            DataType ax_ = tuple_bvgardhyjgbgfxidntuflexa?.AnesthesiaProcedure?.Performed;
            object ay_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ax_);
            bool az_ = ay_ is CqlDateTime;
            if (az_)
            {
                p_ = ay_ as CqlDateTime;
            }
            else
            {
                bool ba_ = ay_ is CqlQuantity;
                if (ba_)
                {
                    p_ = ay_ as CqlQuantity;
                }
                else
                {
                    bool bb_ = ay_ is CqlInterval<CqlDateTime>;
                    if (bb_)
                    {
                        p_ = ay_ as CqlInterval<CqlDateTime>;
                    }
                    else
                    {
                        bool bc_ = ay_ is CqlInterval<CqlQuantity>;
                        if (bc_)
                        {
                            p_ = ay_ as CqlInterval<CqlQuantity>;
                        }
                        else
                        {
                            p_ = null;
                        }
                    }
                }
            }
            CqlInterval<CqlDateTime> q_ = QICoreCommon_4_0_000.Instance.toInterval(context, p_);
            CqlDateTime r_ = context.Operators.End(q_);
            CqlDateTime s_ = this.startOfFirstICU(context, tuple_bvgardhyjgbgfxidntuflexa?.QualifyingEncounterICU);
            CqlQuantity t_ = context.Operators.Quantity(1m, "day");
            CqlDateTime u_ = context.Operators.Add(s_, t_);
            CqlBoolean v_ = context.Operators.SameAs(r_, u_, "day");
            CqlBoolean w_ = v_;
            CqlDateTime x_ = context.Operators.LateBoundProperty<CqlDateTime>(tuple_bvgardhyjgbgfxidntuflexa?.PatientRefusal, "authoredOn");
            object y_;
            DataType bd_ = tuple_bvgardhyjgbgfxidntuflexa?.AnesthesiaProcedure?.Performed;
            object be_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bd_);
            bool bf_ = be_ is CqlDateTime;
            if (bf_)
            {
                y_ = be_ as CqlDateTime;
            }
            else
            {
                bool bg_ = be_ is CqlQuantity;
                if (bg_)
                {
                    y_ = be_ as CqlQuantity;
                }
                else
                {
                    bool bh_ = be_ is CqlInterval<CqlDateTime>;
                    if (bh_)
                    {
                        y_ = be_ as CqlInterval<CqlDateTime>;
                    }
                    else
                    {
                        bool bi_ = be_ is CqlInterval<CqlQuantity>;
                        if (bi_)
                        {
                            y_ = be_ as CqlInterval<CqlQuantity>;
                        }
                        else
                        {
                            y_ = null;
                        }
                    }
                }
            }
            CqlInterval<CqlDateTime> z_ = QICoreCommon_4_0_000.Instance.toInterval(context, y_);
            CqlDateTime aa_ = context.Operators.End(z_);
            CqlInterval<CqlDate> ab_ = TJCOverall_8_25_000.Instance.calendarDayOfOrDayAfter(context, aa_);
            CqlDate ac_ = ab_?.low;
            CqlDateTime ad_ = context.Operators.ConvertDateToDateTime(ac_);
            object ae_;
            DataType bj_ = tuple_bvgardhyjgbgfxidntuflexa?.AnesthesiaProcedure?.Performed;
            object bk_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bj_);
            bool bl_ = bk_ is CqlDateTime;
            if (bl_)
            {
                ae_ = bk_ as CqlDateTime;
            }
            else
            {
                bool bm_ = bk_ is CqlQuantity;
                if (bm_)
                {
                    ae_ = bk_ as CqlQuantity;
                }
                else
                {
                    bool bn_ = bk_ is CqlInterval<CqlDateTime>;
                    if (bn_)
                    {
                        ae_ = bk_ as CqlInterval<CqlDateTime>;
                    }
                    else
                    {
                        bool bo_ = bk_ is CqlInterval<CqlQuantity>;
                        if (bo_)
                        {
                            ae_ = bk_ as CqlInterval<CqlQuantity>;
                        }
                        else
                        {
                            ae_ = null;
                        }
                    }
                }
            }
            CqlInterval<CqlDateTime> af_ = QICoreCommon_4_0_000.Instance.toInterval(context, ae_);
            CqlDateTime ag_ = context.Operators.End(af_);
            CqlInterval<CqlDate> ah_ = TJCOverall_8_25_000.Instance.calendarDayOfOrDayAfter(context, ag_);
            CqlDate ai_ = ah_?.high;
            CqlDateTime aj_ = context.Operators.ConvertDateToDateTime(ai_);
            object ak_;
            DataType bp_ = tuple_bvgardhyjgbgfxidntuflexa?.AnesthesiaProcedure?.Performed;
            object bq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bp_);
            bool br_ = bq_ is CqlDateTime;
            if (br_)
            {
                ak_ = bq_ as CqlDateTime;
            }
            else
            {
                bool bs_ = bq_ is CqlQuantity;
                if (bs_)
                {
                    ak_ = bq_ as CqlQuantity;
                }
                else
                {
                    bool bt_ = bq_ is CqlInterval<CqlDateTime>;
                    if (bt_)
                    {
                        ak_ = bq_ as CqlInterval<CqlDateTime>;
                    }
                    else
                    {
                        bool bu_ = bq_ is CqlInterval<CqlQuantity>;
                        if (bu_)
                        {
                            ak_ = bq_ as CqlInterval<CqlQuantity>;
                        }
                        else
                        {
                            ak_ = null;
                        }
                    }
                }
            }
            CqlInterval<CqlDateTime> al_ = QICoreCommon_4_0_000.Instance.toInterval(context, ak_);
            CqlDateTime am_ = context.Operators.End(al_);
            CqlInterval<CqlDate> an_ = TJCOverall_8_25_000.Instance.calendarDayOfOrDayAfter(context, am_);
            CqlBoolean ao_ = an_?.lowClosed;
            object ap_;
            DataType bv_ = tuple_bvgardhyjgbgfxidntuflexa?.AnesthesiaProcedure?.Performed;
            object bw_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bv_);
            bool bx_ = bw_ is CqlDateTime;
            if (bx_)
            {
                ap_ = bw_ as CqlDateTime;
            }
            else
            {
                bool by_ = bw_ is CqlQuantity;
                if (by_)
                {
                    ap_ = bw_ as CqlQuantity;
                }
                else
                {
                    bool bz_ = bw_ is CqlInterval<CqlDateTime>;
                    if (bz_)
                    {
                        ap_ = bw_ as CqlInterval<CqlDateTime>;
                    }
                    else
                    {
                        bool ca_ = bw_ is CqlInterval<CqlQuantity>;
                        if (ca_)
                        {
                            ap_ = bw_ as CqlInterval<CqlQuantity>;
                        }
                        else
                        {
                            ap_ = null;
                        }
                    }
                }
            }
            CqlInterval<CqlDateTime> aq_ = QICoreCommon_4_0_000.Instance.toInterval(context, ap_);
            CqlDateTime ar_ = context.Operators.End(aq_);
            CqlInterval<CqlDate> as_ = TJCOverall_8_25_000.Instance.calendarDayOfOrDayAfter(context, ar_);
            CqlBoolean at_ = as_?.highClosed;
            CqlInterval<CqlDateTime> au_ = context.Operators.Interval(ad_, aj_, ao_, at_);
            CqlBoolean av_ = context.Operators.In<CqlDateTime>(x_, au_, "day");
            CqlBoolean aw_ = av_;
            return o_
                /* CQL 'and' (403:11-404:121) */ && w_
                /* CQL 'and' (403:5-405:133) */ && aw_;
        }

        IEnumerable<(CqlTupleMetadata, Encounter QualifyingEncounterICU, Procedure AnesthesiaProcedure, object PatientRefusal)?> h_ = context.Operators.SelectWhere<ValueTuple<Encounter, Procedure, object>, (CqlTupleMetadata, Encounter QualifyingEncounterICU, Procedure AnesthesiaProcedure, object PatientRefusal)?>(e_, f_, g_);
        Encounter i_((CqlTupleMetadata, Encounter QualifyingEncounterICU, Procedure AnesthesiaProcedure, object PatientRefusal)? tuple_bvgardhyjgbgfxidntuflexa) => tuple_bvgardhyjgbgfxidntuflexa?.QualifyingEncounterICU;
        IEnumerable<Encounter> j_ = context.Operators.SelectDistinct<(CqlTupleMetadata, Encounter QualifyingEncounterICU, Procedure AnesthesiaProcedure, object PatientRefusal)?, Encounter>(h_, i_);
        return j_;
    }


    [CqlExpressionDefinition("Encounter With No VTE Prophylaxis Due To Patient Refusal")]
    public IEnumerable<Encounter> Encounter_With_No_VTE_Prophylaxis_Due_To_Patient_Refusal(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Encounter_With_No_VTE_Prophylaxis_Due_To_Patient_Refusal, Encounter_With_No_VTE_Prophylaxis_Due_To_Patient_Refusal_Compute);

    private const long _cacheIndex_Encounter_With_No_VTE_Prophylaxis_Due_To_Patient_Refusal = 1346118254877873034L;

    private IEnumerable<Encounter> Encounter_With_No_VTE_Prophylaxis_Due_To_Patient_Refusal_Compute(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.No_VTE_Prophylaxis_Due_To_Patient_Refusal_From_Day_Of_Start_Of_Hospitalization_To_Day_After_First_ICU_Stay(context);
        IEnumerable<Encounter> b_ = this.No_VTE_Prophylaxis_Due_To_Patient_Refusal_On_Day_Of_Or_Day_After_Procedure(context);
        IEnumerable<Encounter> c_ = context.Operators.Union<Encounter>(a_, b_);
        return c_;
    }


    [CqlExpressionDefinition("Numerator")]
    public IEnumerable<Encounter> Numerator(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Numerator, Numerator_Compute);

    private const long _cacheIndex_Numerator = 8975053094299183331L;

    private IEnumerable<Encounter> Numerator_Compute(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Encounter_With_VTE_Prophylaxis_Received_On_Day_Of_Or_Day_After_First_ICU_Stay_Or_Procedure(context);
        IEnumerable<Encounter> b_ = this.Encounter_With_Medication_Oral_Factor_Xa_Inhibitor_Administered_On_Day_Of_Or_Day_After_First_ICU_Stay_Or_Procedure(context);
        IEnumerable<Encounter> c_ = this.Encounter_With_Prior_Or_Present_Diagnosis_Of_Atrial_Fibrillation_Or_Prior_Diagnosis_Of_VTE(context);
        IEnumerable<Encounter> d_ = this.Encounter_With_Prior_Or_Present_Procedure_Of_Hip_Or_Knee_Replacement_Surgery(context);
        IEnumerable<Encounter> e_ = context.Operators.Union<Encounter>(c_, d_);
        IEnumerable<Encounter> f_ = context.Operators.Intersect<Encounter>(b_, e_);
        IEnumerable<Encounter> g_ = context.Operators.Union<Encounter>(a_, f_);
        IEnumerable<Encounter> h_ = this.Encounter_With_Low_Risk_For_VTE_Or_Anticoagulant_Administered(context);
        IEnumerable<Encounter> i_ = this.Encounter_With_No_VTE_Prophylaxis_Due_To_Medical_Reason(context);
        IEnumerable<Encounter> j_ = context.Operators.Union<Encounter>(h_, i_);
        IEnumerable<Encounter> k_ = context.Operators.Union<Encounter>(g_, j_);
        IEnumerable<Encounter> l_ = this.Encounter_With_No_VTE_Prophylaxis_Due_To_Patient_Refusal(context);
        IEnumerable<Encounter> m_ = context.Operators.Union<Encounter>(k_, l_);
        return m_;
    }


    [CqlExpressionDefinition("Encounter With First ICU Location Stay Less Than 1 Day")]
    public IEnumerable<Encounter> Encounter_With_First_ICU_Location_Stay_Less_Than_1_Day(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Encounter_With_First_ICU_Location_Stay_Less_Than_1_Day, Encounter_With_First_ICU_Location_Stay_Less_Than_1_Day_Compute);

    private const long _cacheIndex_Encounter_With_First_ICU_Location_Stay_Less_Than_1_Day = -8844356103065477170L;

    private IEnumerable<Encounter> Encounter_With_First_ICU_Location_Stay_Less_Than_1_Day_Compute(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Encounter_With_ICU_Location(context);

        bool? b_(Encounter QualifyingEncounterICU) {
            Encounter.LocationComponent d_ = CQMCommon_4_1_000.Instance.firstInpatientIntensiveCareUnit(context, QualifyingEncounterICU);
            Period e_ = d_?.Period;
            CqlInterval<CqlDateTime> f_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, e_);
            int? g_ = CQMCommon_4_1_000.Instance.lengthInDays(context, f_);
            CqlBoolean h_ = context.Operators.Less(g_, 1);
            return h_;
        }

        IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);
        return c_;
    }


    [CqlExpressionDefinition("Denominator Exceptions")]
    public IEnumerable<Encounter> Denominator_Exceptions(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Denominator_Exceptions, Denominator_Exceptions_Compute);

    private const long _cacheIndex_Denominator_Exceptions = 999209627364677950L;

    private IEnumerable<Encounter> Denominator_Exceptions_Compute(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Encounter_With_First_ICU_Location_Stay_Less_Than_1_Day(context);
        return a_;
    }


    #endregion Functions and Expressions

    #region Singleton Lifetime Members

    private CMS190FHIRVTEProphylaxisICU_1_0_000() {}

    public static CMS190FHIRVTEProphylaxisICU_1_0_000 Instance { get; } = new();

    #endregion

    #region ILibrary Implementation

    public string Name => "CMS190FHIRVTEProphylaxisICU";
    public string Version => "1.0.000";
    public ILibrary[] Dependencies => [CQMCommon_4_1_000.Instance, QICoreCommon_4_0_000.Instance, FHIRHelpers_4_4_000.Instance, SupplementalDataElements_5_1_000.Instance, TJCOverall_8_25_000.Instance, VTE_8_18_000.Instance];

    #endregion ILibrary Implementation

    #region CqlTupleMetadata Properties

    private static CqlTupleMetadata CqlTupleMetadata_CGYAgYdKXUHcFINAPjMZNihh = new(
       [typeof(Encounter), typeof(Procedure), typeof(object)],
       ["QualifyingEncounterICU", "AnesthesiaProcedure", "VTEProphylaxis"]);

    private static CqlTupleMetadata CqlTupleMetadata_CNeQfiIHcQEUBjZNVZiOLfdeP = new(
       [typeof(string), typeof(IEnumerable<CqlConcept>), typeof(CqlDateTime)],
       ["id", "medicationStatusReason", "authoredOn"]);

    private static CqlTupleMetadata CqlTupleMetadata_DheTAGNHbFgKVJGaRbPLJVjKH = new(
       [typeof(string), typeof(CqlConcept), typeof(CqlDateTime)],
       ["id", "requestStatusReason", "authoredOn"]);

    private static CqlTupleMetadata CqlTupleMetadata_DMAfXNhTfZDWOGdfEceXbfaSJ = new(
       [typeof(string), typeof(CqlDateTime)],
       ["id", "LowRiskDatetime"]);

    private static CqlTupleMetadata CqlTupleMetadata_DPXDaXjPQUNAIiZCCbGhNdDMi = new(
       [typeof(string), typeof(CqlConcept), typeof(FhirDateTime)],
       ["id", "requestStatusReason", "authoredOn"]);

    private static CqlTupleMetadata CqlTupleMetadata_EBcSahXYZdeFjUUbgULReCZAe = new(
       [typeof(string), typeof(IEnumerable<CqlConcept>), typeof(FhirDateTime)],
       ["id", "medicationStatusReason", "authoredOn"]);

    private static CqlTupleMetadata CqlTupleMetadata_ENTiROQhSLFcBRSgSOZVGLLAP = new(
       [typeof(Encounter), typeof(Procedure), typeof(object)],
       ["QualifyingEncounterICU", "AnesthesiaProcedure", "ComfortMeasure"]);

    private static CqlTupleMetadata CqlTupleMetadata_FFALfPBajSdbcUiIgEjZKRHOP = new(
       [typeof(Encounter), typeof(Procedure), typeof((CqlTupleMetadata, string id, CqlDateTime LowRiskDatetime)?)],
       ["QualifyingEncounterICU", "AnesthesiaProcedure", "LowRiskForVTE"]);

    private static CqlTupleMetadata CqlTupleMetadata_FVDRPQjOQgYIDhWKHCNhOHceF = new(
       [typeof(string), typeof(CodeableConcept), typeof(CqlDateTime)],
       ["id", "requestStatusReason", "authoredOn"]);

    private static CqlTupleMetadata CqlTupleMetadata_HLCXTKCfUejcHSahcUNeWcYFC = new(
       [typeof(Encounter), typeof(Procedure), typeof((CqlTupleMetadata, string id, IEnumerable<CqlConcept> medicationStatusReason, CqlDateTime authoredOn)?)],
       ["QualifyingEncounterICU", "AnesthesiaProcedure", "NoVTEMedication"]);

    private static CqlTupleMetadata CqlTupleMetadata_ifVVXcOGTAXRRBdEBOYOhXCQ = new(
       [typeof(Encounter), typeof(Procedure), typeof((CqlTupleMetadata, string id, CqlConcept requestStatusReason, CqlDateTime authoredOn)?)],
       ["QualifyingEncounterICU", "AnesthesiaProcedure", "NoVTEDevice"]);

    private static CqlTupleMetadata CqlTupleMetadata_IGcdIOTLGJfibgSLNOGSFRVB = new(
       [typeof(Encounter), typeof(Procedure), typeof(MedicationAdministration)],
       ["QualifyingEncounterICU", "AnesthesiaProcedure", "FactorXaMedication"]);

    private static CqlTupleMetadata CqlTupleMetadata_IIUQMBcJhJBPgdDOLHaTTRUE = new(
       [typeof(MedicationRequest), typeof(Task)],
       ["MedicationOrderReject", "T"]);

    private static CqlTupleMetadata CqlTupleMetadata_MYMdRYUDSjLaJAMGKSYBKOjf = new(
       [typeof(Encounter), typeof(Procedure), typeof(object)],
       ["QualifyingEncounterICU", "AnesthesiaProcedure", "PatientRefusal"]);

    private static CqlTupleMetadata CqlTupleMetadata_YYIDPXBNjhOGFRJKYRBMGChb = new(
       [typeof(ServiceRequest), typeof(Task)],
       ["DeviceOrderReject", "T"]);

    #endregion CqlTupleMetadata Properties

}

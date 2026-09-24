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

[System.CodeDom.Compiler.GeneratedCode(".NET Code Generation", "5.2.3.0")]
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
                bool? m_ = context.Operators.ConceptsInValueSet(k_, l_);
                Period n_ = QualifyingEncounter?.Period;
                CqlInterval<CqlDateTime> o_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, n_);
                Period p_ = Location?.Period;
                CqlInterval<CqlDateTime> q_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, p_);
                bool? r_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(o_, q_, (string)default);
                bool? s_ = context.Operators.And(m_, r_);
                return s_;
            }

            bool? f_ = context.Operators.WhereAny<Encounter.LocationComponent>((IEnumerable<Encounter.LocationComponent>)d_, e_);
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
            bool? g_ = context.Operators.Less(f_, 2);
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
            bool? e_ = VTE_8_18_000.Instance.hasPrincipalProcedureOf(context, QualifyingEncounterICU, d_);
            CqlValueSet f_ = this.Gynecological_Surgery(context);
            bool? g_ = VTE_8_18_000.Instance.hasPrincipalProcedureOf(context, QualifyingEncounterICU, f_);
            bool? h_ = context.Operators.Or(e_, g_);
            CqlValueSet i_ = this.Hip_Fracture_Surgery(context);
            bool? j_ = VTE_8_18_000.Instance.hasPrincipalProcedureOf(context, QualifyingEncounterICU, i_);
            bool? k_ = context.Operators.Or(h_, j_);
            CqlValueSet l_ = this.Hip_Replacement_Surgery(context);
            bool? m_ = VTE_8_18_000.Instance.hasPrincipalProcedureOf(context, QualifyingEncounterICU, l_);
            bool? n_ = context.Operators.Or(k_, m_);
            CqlValueSet o_ = this.Intracranial_Neurosurgery(context);
            bool? p_ = VTE_8_18_000.Instance.hasPrincipalProcedureOf(context, QualifyingEncounterICU, o_);
            bool? q_ = context.Operators.Or(n_, p_);
            CqlValueSet r_ = this.Knee_Replacement_Surgery(context);
            bool? s_ = VTE_8_18_000.Instance.hasPrincipalProcedureOf(context, QualifyingEncounterICU, r_);
            bool? t_ = context.Operators.Or(q_, s_);
            CqlValueSet u_ = this.Urological_Surgery(context);
            bool? v_ = VTE_8_18_000.Instance.hasPrincipalProcedureOf(context, QualifyingEncounterICU, u_);
            bool? w_ = context.Operators.Or(t_, v_);
            return w_;
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
            bool? n_ = context.Operators.In<string>(l_, (IEnumerable<string>)m_);
            Code<RequestStatus> o_ = InterventionRequest?.StatusElement;
            RequestStatus? p_ = o_?.Value;
            Code<RequestStatus> q_ = context.Operators.Convert<Code<RequestStatus>>(p_);
            string r_ = context.Operators.Convert<string>(q_);
            string[] s_ = [
                "active",
                "completed",
            ];
            bool? t_ = context.Operators.In<string>(r_, (IEnumerable<string>)s_);
            bool? u_ = context.Operators.And(n_, t_);
            return u_;
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
            bool? z_ = context.Operators.In<string>(x_, (IEnumerable<string>)y_);
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
                    object x_ = context.Operators.LateBoundProperty<object>(ComfortMeasure, "performed");
                    object y_ = FHIRHelpers_4_4_000.Instance.ToValue(context, x_);
                    g_ = y_ as CqlDateTime;
                }
                else
                {
                    object z_ = context.Operators.LateBoundProperty<object>(ComfortMeasure, "performed");
                    object aa_ = FHIRHelpers_4_4_000.Instance.ToValue(context, z_);
                    bool ab_ = aa_ is CqlQuantity;
                    if (ab_)
                    {
                        object ac_ = context.Operators.LateBoundProperty<object>(ComfortMeasure, "performed");
                        object ad_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ac_);
                        g_ = ad_ as CqlQuantity;
                    }
                    else
                    {
                        object ae_ = context.Operators.LateBoundProperty<object>(ComfortMeasure, "performed");
                        object af_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ae_);
                        bool ag_ = af_ is CqlInterval<CqlDateTime>;
                        if (ag_)
                        {
                            object ah_ = context.Operators.LateBoundProperty<object>(ComfortMeasure, "performed");
                            object ai_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ah_);
                            g_ = ai_ as CqlInterval<CqlDateTime>;
                        }
                        else
                        {
                            object aj_ = context.Operators.LateBoundProperty<object>(ComfortMeasure, "performed");
                            object ak_ = FHIRHelpers_4_4_000.Instance.ToValue(context, aj_);
                            bool al_ = ak_ is CqlInterval<CqlQuantity>;
                            if (al_)
                            {
                                object am_ = context.Operators.LateBoundProperty<object>(ComfortMeasure, "performed");
                                object an_ = FHIRHelpers_4_4_000.Instance.ToValue(context, am_);
                                g_ = an_ as CqlInterval<CqlQuantity>;
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
                bool? q_ = l_?.lowClosed;
                bool? r_ = l_?.highClosed;
                CqlInterval<CqlDateTime> s_ = context.Operators.Interval(n_, p_, q_, r_);
                bool? t_ = context.Operators.In<CqlDateTime>(i_ ?? k_, s_, "day");
                return t_;
            }

            bool? f_ = context.Operators.WhereAny<object>(d_, e_);
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
            bool? o_ = context.Operators.Equal(n_, "completed");
            object p_;
            DataType bb_ = tuple_gdefgctjcxpzbyfpuogejrgou?.AnesthesiaProcedure?.Performed;
            object bc_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bb_);
            bool bd_ = bc_ is CqlDateTime;
            if (bd_)
            {
                DataType be_ = tuple_gdefgctjcxpzbyfpuogejrgou?.AnesthesiaProcedure?.Performed;
                object bf_ = FHIRHelpers_4_4_000.Instance.ToValue(context, be_);
                p_ = bf_ as CqlDateTime;
            }
            else
            {
                DataType bg_ = tuple_gdefgctjcxpzbyfpuogejrgou?.AnesthesiaProcedure?.Performed;
                object bh_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bg_);
                bool bi_ = bh_ is CqlQuantity;
                if (bi_)
                {
                    DataType bj_ = tuple_gdefgctjcxpzbyfpuogejrgou?.AnesthesiaProcedure?.Performed;
                    object bk_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bj_);
                    p_ = bk_ as CqlQuantity;
                }
                else
                {
                    DataType bl_ = tuple_gdefgctjcxpzbyfpuogejrgou?.AnesthesiaProcedure?.Performed;
                    object bm_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bl_);
                    bool bn_ = bm_ is CqlInterval<CqlDateTime>;
                    if (bn_)
                    {
                        DataType bo_ = tuple_gdefgctjcxpzbyfpuogejrgou?.AnesthesiaProcedure?.Performed;
                        object bp_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bo_);
                        p_ = bp_ as CqlInterval<CqlDateTime>;
                    }
                    else
                    {
                        DataType bq_ = tuple_gdefgctjcxpzbyfpuogejrgou?.AnesthesiaProcedure?.Performed;
                        object br_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bq_);
                        bool bs_ = br_ is CqlInterval<CqlQuantity>;
                        if (bs_)
                        {
                            DataType bt_ = tuple_gdefgctjcxpzbyfpuogejrgou?.AnesthesiaProcedure?.Performed;
                            object bu_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bt_);
                            p_ = bu_ as CqlInterval<CqlQuantity>;
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
            bool? v_ = context.Operators.SameAs(r_, u_, "day");
            bool? w_ = context.Operators.And(o_, v_);
            object x_;
            object bv_ = context.Operators.LateBoundProperty<object>(tuple_gdefgctjcxpzbyfpuogejrgou?.ComfortMeasure, "performed");
            object bw_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bv_);
            bool bx_ = bw_ is CqlDateTime;
            if (bx_)
            {
                object by_ = context.Operators.LateBoundProperty<object>(tuple_gdefgctjcxpzbyfpuogejrgou?.ComfortMeasure, "performed");
                object bz_ = FHIRHelpers_4_4_000.Instance.ToValue(context, by_);
                x_ = bz_ as CqlDateTime;
            }
            else
            {
                object ca_ = context.Operators.LateBoundProperty<object>(tuple_gdefgctjcxpzbyfpuogejrgou?.ComfortMeasure, "performed");
                object cb_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ca_);
                bool cc_ = cb_ is CqlQuantity;
                if (cc_)
                {
                    object cd_ = context.Operators.LateBoundProperty<object>(tuple_gdefgctjcxpzbyfpuogejrgou?.ComfortMeasure, "performed");
                    object ce_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cd_);
                    x_ = ce_ as CqlQuantity;
                }
                else
                {
                    object cf_ = context.Operators.LateBoundProperty<object>(tuple_gdefgctjcxpzbyfpuogejrgou?.ComfortMeasure, "performed");
                    object cg_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cf_);
                    bool ch_ = cg_ is CqlInterval<CqlDateTime>;
                    if (ch_)
                    {
                        object ci_ = context.Operators.LateBoundProperty<object>(tuple_gdefgctjcxpzbyfpuogejrgou?.ComfortMeasure, "performed");
                        object cj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ci_);
                        x_ = cj_ as CqlInterval<CqlDateTime>;
                    }
                    else
                    {
                        object ck_ = context.Operators.LateBoundProperty<object>(tuple_gdefgctjcxpzbyfpuogejrgou?.ComfortMeasure, "performed");
                        object cl_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ck_);
                        bool cm_ = cl_ is CqlInterval<CqlQuantity>;
                        if (cm_)
                        {
                            object cn_ = context.Operators.LateBoundProperty<object>(tuple_gdefgctjcxpzbyfpuogejrgou?.ComfortMeasure, "performed");
                            object co_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cn_);
                            x_ = co_ as CqlInterval<CqlQuantity>;
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
            DataType cp_ = tuple_gdefgctjcxpzbyfpuogejrgou?.AnesthesiaProcedure?.Performed;
            object cq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cp_);
            bool cr_ = cq_ is CqlDateTime;
            if (cr_)
            {
                DataType cs_ = tuple_gdefgctjcxpzbyfpuogejrgou?.AnesthesiaProcedure?.Performed;
                object ct_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cs_);
                ac_ = ct_ as CqlDateTime;
            }
            else
            {
                DataType cu_ = tuple_gdefgctjcxpzbyfpuogejrgou?.AnesthesiaProcedure?.Performed;
                object cv_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cu_);
                bool cw_ = cv_ is CqlQuantity;
                if (cw_)
                {
                    DataType cx_ = tuple_gdefgctjcxpzbyfpuogejrgou?.AnesthesiaProcedure?.Performed;
                    object cy_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cx_);
                    ac_ = cy_ as CqlQuantity;
                }
                else
                {
                    DataType cz_ = tuple_gdefgctjcxpzbyfpuogejrgou?.AnesthesiaProcedure?.Performed;
                    object da_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cz_);
                    bool db_ = da_ is CqlInterval<CqlDateTime>;
                    if (db_)
                    {
                        DataType dc_ = tuple_gdefgctjcxpzbyfpuogejrgou?.AnesthesiaProcedure?.Performed;
                        object dd_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dc_);
                        ac_ = dd_ as CqlInterval<CqlDateTime>;
                    }
                    else
                    {
                        DataType de_ = tuple_gdefgctjcxpzbyfpuogejrgou?.AnesthesiaProcedure?.Performed;
                        object df_ = FHIRHelpers_4_4_000.Instance.ToValue(context, de_);
                        bool dg_ = df_ is CqlInterval<CqlQuantity>;
                        if (dg_)
                        {
                            DataType dh_ = tuple_gdefgctjcxpzbyfpuogejrgou?.AnesthesiaProcedure?.Performed;
                            object di_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dh_);
                            ac_ = di_ as CqlInterval<CqlQuantity>;
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
            DataType dj_ = tuple_gdefgctjcxpzbyfpuogejrgou?.AnesthesiaProcedure?.Performed;
            object dk_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dj_);
            bool dl_ = dk_ is CqlDateTime;
            if (dl_)
            {
                DataType dm_ = tuple_gdefgctjcxpzbyfpuogejrgou?.AnesthesiaProcedure?.Performed;
                object dn_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dm_);
                ai_ = dn_ as CqlDateTime;
            }
            else
            {
                DataType do_ = tuple_gdefgctjcxpzbyfpuogejrgou?.AnesthesiaProcedure?.Performed;
                object dp_ = FHIRHelpers_4_4_000.Instance.ToValue(context, do_);
                bool dq_ = dp_ is CqlQuantity;
                if (dq_)
                {
                    DataType dr_ = tuple_gdefgctjcxpzbyfpuogejrgou?.AnesthesiaProcedure?.Performed;
                    object ds_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dr_);
                    ai_ = ds_ as CqlQuantity;
                }
                else
                {
                    DataType dt_ = tuple_gdefgctjcxpzbyfpuogejrgou?.AnesthesiaProcedure?.Performed;
                    object du_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dt_);
                    bool dv_ = du_ is CqlInterval<CqlDateTime>;
                    if (dv_)
                    {
                        DataType dw_ = tuple_gdefgctjcxpzbyfpuogejrgou?.AnesthesiaProcedure?.Performed;
                        object dx_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dw_);
                        ai_ = dx_ as CqlInterval<CqlDateTime>;
                    }
                    else
                    {
                        DataType dy_ = tuple_gdefgctjcxpzbyfpuogejrgou?.AnesthesiaProcedure?.Performed;
                        object dz_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dy_);
                        bool ea_ = dz_ is CqlInterval<CqlQuantity>;
                        if (ea_)
                        {
                            DataType eb_ = tuple_gdefgctjcxpzbyfpuogejrgou?.AnesthesiaProcedure?.Performed;
                            object ec_ = FHIRHelpers_4_4_000.Instance.ToValue(context, eb_);
                            ai_ = ec_ as CqlInterval<CqlQuantity>;
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
            DataType ed_ = tuple_gdefgctjcxpzbyfpuogejrgou?.AnesthesiaProcedure?.Performed;
            object ee_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ed_);
            bool ef_ = ee_ is CqlDateTime;
            if (ef_)
            {
                DataType eg_ = tuple_gdefgctjcxpzbyfpuogejrgou?.AnesthesiaProcedure?.Performed;
                object eh_ = FHIRHelpers_4_4_000.Instance.ToValue(context, eg_);
                ao_ = eh_ as CqlDateTime;
            }
            else
            {
                DataType ei_ = tuple_gdefgctjcxpzbyfpuogejrgou?.AnesthesiaProcedure?.Performed;
                object ej_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ei_);
                bool ek_ = ej_ is CqlQuantity;
                if (ek_)
                {
                    DataType el_ = tuple_gdefgctjcxpzbyfpuogejrgou?.AnesthesiaProcedure?.Performed;
                    object em_ = FHIRHelpers_4_4_000.Instance.ToValue(context, el_);
                    ao_ = em_ as CqlQuantity;
                }
                else
                {
                    DataType en_ = tuple_gdefgctjcxpzbyfpuogejrgou?.AnesthesiaProcedure?.Performed;
                    object eo_ = FHIRHelpers_4_4_000.Instance.ToValue(context, en_);
                    bool ep_ = eo_ is CqlInterval<CqlDateTime>;
                    if (ep_)
                    {
                        DataType eq_ = tuple_gdefgctjcxpzbyfpuogejrgou?.AnesthesiaProcedure?.Performed;
                        object er_ = FHIRHelpers_4_4_000.Instance.ToValue(context, eq_);
                        ao_ = er_ as CqlInterval<CqlDateTime>;
                    }
                    else
                    {
                        DataType es_ = tuple_gdefgctjcxpzbyfpuogejrgou?.AnesthesiaProcedure?.Performed;
                        object et_ = FHIRHelpers_4_4_000.Instance.ToValue(context, es_);
                        bool eu_ = et_ is CqlInterval<CqlQuantity>;
                        if (eu_)
                        {
                            DataType ev_ = tuple_gdefgctjcxpzbyfpuogejrgou?.AnesthesiaProcedure?.Performed;
                            object ew_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ev_);
                            ao_ = ew_ as CqlInterval<CqlQuantity>;
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
            bool? as_ = ar_?.lowClosed;
            object at_;
            DataType ex_ = tuple_gdefgctjcxpzbyfpuogejrgou?.AnesthesiaProcedure?.Performed;
            object ey_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ex_);
            bool ez_ = ey_ is CqlDateTime;
            if (ez_)
            {
                DataType fa_ = tuple_gdefgctjcxpzbyfpuogejrgou?.AnesthesiaProcedure?.Performed;
                object fb_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fa_);
                at_ = fb_ as CqlDateTime;
            }
            else
            {
                DataType fc_ = tuple_gdefgctjcxpzbyfpuogejrgou?.AnesthesiaProcedure?.Performed;
                object fd_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fc_);
                bool fe_ = fd_ is CqlQuantity;
                if (fe_)
                {
                    DataType ff_ = tuple_gdefgctjcxpzbyfpuogejrgou?.AnesthesiaProcedure?.Performed;
                    object fg_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ff_);
                    at_ = fg_ as CqlQuantity;
                }
                else
                {
                    DataType fh_ = tuple_gdefgctjcxpzbyfpuogejrgou?.AnesthesiaProcedure?.Performed;
                    object fi_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fh_);
                    bool fj_ = fi_ is CqlInterval<CqlDateTime>;
                    if (fj_)
                    {
                        DataType fk_ = tuple_gdefgctjcxpzbyfpuogejrgou?.AnesthesiaProcedure?.Performed;
                        object fl_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fk_);
                        at_ = fl_ as CqlInterval<CqlDateTime>;
                    }
                    else
                    {
                        DataType fm_ = tuple_gdefgctjcxpzbyfpuogejrgou?.AnesthesiaProcedure?.Performed;
                        object fn_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fm_);
                        bool fo_ = fn_ is CqlInterval<CqlQuantity>;
                        if (fo_)
                        {
                            DataType fp_ = tuple_gdefgctjcxpzbyfpuogejrgou?.AnesthesiaProcedure?.Performed;
                            object fq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fp_);
                            at_ = fq_ as CqlInterval<CqlQuantity>;
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
            bool? ax_ = aw_?.highClosed;
            CqlInterval<CqlDateTime> ay_ = context.Operators.Interval(ah_, an_, as_, ax_);
            bool? az_ = context.Operators.In<CqlDateTime>(z_ ?? ab_, ay_, "day");
            bool? ba_ = context.Operators.And(w_, az_);
            return ba_;
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
                string bc_ = (M is Resource
                    ? (M as Resource).IdElement
                    : default)?.Value;
                DataType bd_ = MR?.Medication;
                object be_ = context.Operators.LateBoundProperty<object>(bd_, "reference");
                object bf_ = context.Operators.LateBoundProperty<object>(be_, "value");
                IEnumerable<string> bg_ = context.Operators.Split((string)bf_, "/");
                string bh_ = context.Operators.Last<string>(bg_);
                bool? bi_ = context.Operators.Equal(bc_, bh_);
                CodeableConcept bj_ = M?.Code;
                CqlConcept bk_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, bj_);
                CqlValueSet bl_ = this.Low_Dose_Unfractionated_Heparin_for_VTE_Prophylaxis(context);
                bool? bm_ = context.Operators.ConceptInValueSet(bk_, bl_);
                bool? bn_ = context.Operators.And(bi_, bm_);
                return bn_;
            }

            bool? bb_ = context.Operators.WhereAny<Medication>(az_, ba_);
            return bb_;
        }

        IEnumerable<MedicationAdministration> c_ = context.Operators.Where<MedicationAdministration>(a_, b_);
        CqlValueSet d_ = this.Low_Dose_Unfractionated_Heparin_for_VTE_Prophylaxis(context);
        IEnumerable<MedicationAdministration> e_ = context.Operators.Retrieve<MedicationAdministration>(new RetrieveParameters(default, d_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationadministration"));
        IEnumerable<MedicationAdministration> f_ = context.Operators.Union<MedicationAdministration>(c_, e_);

        bool? g_(MedicationAdministration VTEMedication) {
            Code<MedicationAdministration.MedicationAdministrationStatusCodes> bo_ = VTEMedication?.StatusElement;
            MedicationAdministration.MedicationAdministrationStatusCodes? bp_ = bo_?.Value;
            string bq_ = context.Operators.Convert<string>(bp_);
            bool? br_ = context.Operators.Equal(bq_, "completed");
            MedicationAdministration.DosageComponent bs_ = VTEMedication?.Dosage;
            CodeableConcept bt_ = bs_?.Route;
            CqlConcept bu_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, bt_);
            CqlValueSet bv_ = this.Subcutaneous_route(context);
            bool? bw_ = context.Operators.ConceptInValueSet(bu_, bv_);
            bool? bx_ = context.Operators.And(br_, bw_);
            return bx_;
        }

        IEnumerable<MedicationAdministration> h_ = context.Operators.Where<MedicationAdministration>(f_, g_);

        bool? i_(MedicationAdministration MR) {
            IEnumerable<Medication> by_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));

            bool? bz_(Medication M) {
                string cb_ = (M is Resource
                    ? (M as Resource).IdElement
                    : default)?.Value;
                DataType cc_ = MR?.Medication;
                object cd_ = context.Operators.LateBoundProperty<object>(cc_, "reference");
                object ce_ = context.Operators.LateBoundProperty<object>(cd_, "value");
                IEnumerable<string> cf_ = context.Operators.Split((string)ce_, "/");
                string cg_ = context.Operators.Last<string>(cf_);
                bool? ch_ = context.Operators.Equal(cb_, cg_);
                CodeableConcept ci_ = M?.Code;
                CqlConcept cj_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, ci_);
                CqlValueSet ck_ = this.Low_Molecular_Weight_Heparin_for_VTE_Prophylaxis(context);
                bool? cl_ = context.Operators.ConceptInValueSet(cj_, ck_);
                bool? cm_ = context.Operators.And(ch_, cl_);
                return cm_;
            }

            bool? ca_ = context.Operators.WhereAny<Medication>(by_, bz_);
            return ca_;
        }

        IEnumerable<MedicationAdministration> j_ = context.Operators.Where<MedicationAdministration>(a_, i_);
        CqlValueSet k_ = this.Low_Molecular_Weight_Heparin_for_VTE_Prophylaxis(context);
        IEnumerable<MedicationAdministration> l_ = context.Operators.Retrieve<MedicationAdministration>(new RetrieveParameters(default, k_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationadministration"));
        IEnumerable<MedicationAdministration> m_ = context.Operators.Union<MedicationAdministration>(j_, l_);

        bool? n_(MedicationAdministration LMWH) {
            Code<MedicationAdministration.MedicationAdministrationStatusCodes> cn_ = LMWH?.StatusElement;
            MedicationAdministration.MedicationAdministrationStatusCodes? co_ = cn_?.Value;
            string cp_ = context.Operators.Convert<string>(co_);
            bool? cq_ = context.Operators.Equal(cp_, "completed");
            return cq_;
        }

        IEnumerable<MedicationAdministration> o_ = context.Operators.Where<MedicationAdministration>(m_, n_);
        IEnumerable<MedicationAdministration> p_ = context.Operators.Union<MedicationAdministration>(h_, o_);

        bool? q_(MedicationAdministration MR) {
            IEnumerable<Medication> cr_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));

            bool? cs_(Medication M) {
                string cu_ = (M is Resource
                    ? (M as Resource).IdElement
                    : default)?.Value;
                DataType cv_ = MR?.Medication;
                object cw_ = context.Operators.LateBoundProperty<object>(cv_, "reference");
                object cx_ = context.Operators.LateBoundProperty<object>(cw_, "value");
                IEnumerable<string> cy_ = context.Operators.Split((string)cx_, "/");
                string cz_ = context.Operators.Last<string>(cy_);
                bool? da_ = context.Operators.Equal(cu_, cz_);
                CodeableConcept db_ = M?.Code;
                CqlConcept dc_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, db_);
                CqlValueSet dd_ = this.Injectable_Factor_Xa_Inhibitor_for_VTE_Prophylaxis(context);
                bool? de_ = context.Operators.ConceptInValueSet(dc_, dd_);
                bool? df_ = context.Operators.And(da_, de_);
                return df_;
            }

            bool? ct_ = context.Operators.WhereAny<Medication>(cr_, cs_);
            return ct_;
        }

        IEnumerable<MedicationAdministration> r_ = context.Operators.Where<MedicationAdministration>(a_, q_);
        CqlValueSet s_ = this.Injectable_Factor_Xa_Inhibitor_for_VTE_Prophylaxis(context);
        IEnumerable<MedicationAdministration> t_ = context.Operators.Retrieve<MedicationAdministration>(new RetrieveParameters(default, s_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationadministration"));
        IEnumerable<MedicationAdministration> u_ = context.Operators.Union<MedicationAdministration>(r_, t_);

        bool? v_(MedicationAdministration FactorXa) {
            Code<MedicationAdministration.MedicationAdministrationStatusCodes> dg_ = FactorXa?.StatusElement;
            MedicationAdministration.MedicationAdministrationStatusCodes? dh_ = dg_?.Value;
            string di_ = context.Operators.Convert<string>(dh_);
            bool? dj_ = context.Operators.Equal(di_, "completed");
            return dj_;
        }

        IEnumerable<MedicationAdministration> w_ = context.Operators.Where<MedicationAdministration>(u_, v_);

        bool? x_(MedicationAdministration MR) {
            IEnumerable<Medication> dk_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));

            bool? dl_(Medication M) {
                string dn_ = (M is Resource
                    ? (M as Resource).IdElement
                    : default)?.Value;
                DataType do_ = MR?.Medication;
                object dp_ = context.Operators.LateBoundProperty<object>(do_, "reference");
                object dq_ = context.Operators.LateBoundProperty<object>(dp_, "value");
                IEnumerable<string> dr_ = context.Operators.Split((string)dq_, "/");
                string ds_ = context.Operators.Last<string>(dr_);
                bool? dt_ = context.Operators.Equal(dn_, ds_);
                CodeableConcept du_ = M?.Code;
                CqlConcept dv_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, du_);
                CqlValueSet dw_ = this.Warfarin(context);
                bool? dx_ = context.Operators.ConceptInValueSet(dv_, dw_);
                bool? dy_ = context.Operators.And(dt_, dx_);
                return dy_;
            }

            bool? dm_ = context.Operators.WhereAny<Medication>(dk_, dl_);
            return dm_;
        }

        IEnumerable<MedicationAdministration> y_ = context.Operators.Where<MedicationAdministration>(a_, x_);
        CqlValueSet z_ = this.Warfarin(context);
        IEnumerable<MedicationAdministration> aa_ = context.Operators.Retrieve<MedicationAdministration>(new RetrieveParameters(default, z_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationadministration"));
        IEnumerable<MedicationAdministration> ab_ = context.Operators.Union<MedicationAdministration>(y_, aa_);

        bool? ac_(MedicationAdministration WarfarinAdm) {
            Code<MedicationAdministration.MedicationAdministrationStatusCodes> dz_ = WarfarinAdm?.StatusElement;
            MedicationAdministration.MedicationAdministrationStatusCodes? ea_ = dz_?.Value;
            string eb_ = context.Operators.Convert<string>(ea_);
            bool? ec_ = context.Operators.Equal(eb_, "completed");
            return ec_;
        }

        IEnumerable<MedicationAdministration> ad_ = context.Operators.Where<MedicationAdministration>(ab_, ac_);
        IEnumerable<MedicationAdministration> ae_ = context.Operators.Union<MedicationAdministration>(w_, ad_);
        IEnumerable<MedicationAdministration> af_ = context.Operators.Union<MedicationAdministration>(p_, ae_);

        bool? ag_(MedicationAdministration MR) {
            IEnumerable<Medication> ed_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));

            bool? ee_(Medication M) {
                string eg_ = (M is Resource
                    ? (M as Resource).IdElement
                    : default)?.Value;
                DataType eh_ = MR?.Medication;
                object ei_ = context.Operators.LateBoundProperty<object>(eh_, "reference");
                object ej_ = context.Operators.LateBoundProperty<object>(ei_, "value");
                IEnumerable<string> ek_ = context.Operators.Split((string)ej_, "/");
                string el_ = context.Operators.Last<string>(ek_);
                bool? em_ = context.Operators.Equal(eg_, el_);
                CodeableConcept en_ = M?.Code;
                CqlConcept eo_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, en_);
                CqlValueSet ep_ = this.Rivaroxaban_for_VTE_Prophylaxis(context);
                bool? eq_ = context.Operators.ConceptInValueSet(eo_, ep_);
                bool? er_ = context.Operators.And(em_, eq_);
                return er_;
            }

            bool? ef_ = context.Operators.WhereAny<Medication>(ed_, ee_);
            return ef_;
        }

        IEnumerable<MedicationAdministration> ah_ = context.Operators.Where<MedicationAdministration>(a_, ag_);
        CqlValueSet ai_ = this.Rivaroxaban_for_VTE_Prophylaxis(context);
        IEnumerable<MedicationAdministration> aj_ = context.Operators.Retrieve<MedicationAdministration>(new RetrieveParameters(default, ai_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationadministration"));
        IEnumerable<MedicationAdministration> ak_ = context.Operators.Union<MedicationAdministration>(ah_, aj_);

        bool? al_(MedicationAdministration Rivaroxaban) {
            Code<MedicationAdministration.MedicationAdministrationStatusCodes> es_ = Rivaroxaban?.StatusElement;
            MedicationAdministration.MedicationAdministrationStatusCodes? et_ = es_?.Value;
            string eu_ = context.Operators.Convert<string>(et_);
            bool? ev_ = context.Operators.Equal(eu_, "completed");
            return ev_;
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
            Code<EventStatus> ew_ = DeviceApplied?.StatusElement;
            EventStatus? ex_ = ew_?.Value;
            string ey_ = context.Operators.Convert<string>(ex_);
            bool? ez_ = context.Operators.Equal(ey_, "completed");
            return ez_;
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
                    object aj_ = context.Operators.LateBoundProperty<object>(VTEProphylaxis, "performed");
                    object ak_ = FHIRHelpers_4_4_000.Instance.ToValue(context, aj_);
                    t_ = ak_ as CqlDateTime;
                }
                else
                {
                    object al_ = context.Operators.LateBoundProperty<object>(VTEProphylaxis, "performed");
                    object am_ = FHIRHelpers_4_4_000.Instance.ToValue(context, al_);
                    bool an_ = am_ is CqlQuantity;
                    if (an_)
                    {
                        object ao_ = context.Operators.LateBoundProperty<object>(VTEProphylaxis, "performed");
                        object ap_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ao_);
                        t_ = ap_ as CqlQuantity;
                    }
                    else
                    {
                        object aq_ = context.Operators.LateBoundProperty<object>(VTEProphylaxis, "performed");
                        object ar_ = FHIRHelpers_4_4_000.Instance.ToValue(context, aq_);
                        bool as_ = ar_ is CqlInterval<CqlDateTime>;
                        if (as_)
                        {
                            object at_ = context.Operators.LateBoundProperty<object>(VTEProphylaxis, "performed");
                            object au_ = FHIRHelpers_4_4_000.Instance.ToValue(context, at_);
                            t_ = au_ as CqlInterval<CqlDateTime>;
                        }
                        else
                        {
                            object av_ = context.Operators.LateBoundProperty<object>(VTEProphylaxis, "performed");
                            object aw_ = FHIRHelpers_4_4_000.Instance.ToValue(context, av_);
                            bool ax_ = aw_ is CqlInterval<CqlQuantity>;
                            if (ax_)
                            {
                                object ay_ = context.Operators.LateBoundProperty<object>(VTEProphylaxis, "performed");
                                object az_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ay_);
                                t_ = az_ as CqlInterval<CqlQuantity>;
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
                bool? ac_ = x_?.lowClosed;
                bool? ad_ = x_?.highClosed;
                CqlInterval<CqlDateTime> ae_ = context.Operators.Interval(z_, ab_, ac_, ad_);
                bool? af_ = context.Operators.In<CqlDateTime>(v_, ae_, "day");
                return af_;
            }

            bool? p_ = context.Operators.WhereAny<object>(n_, o_);
            return p_;
        }

        IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);
        CqlValueSet d_ = this.General_or_Neuraxial_Anesthesia(context);
        IEnumerable<Procedure> e_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, d_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
        IEnumerable<object> f_ = this.Pharmacological_Or_Mechanical_VTE_Prophylaxis_Received(context);
        IEnumerable<ValueTuple<Encounter, Procedure, object>> g_ = context.Operators.CrossJoin<Encounter, Procedure, object>(a_, e_, f_);

        (CqlTupleMetadata, Encounter QualifyingEncounterICU, Procedure AnesthesiaProcedure, object VTEProphylaxis)? h_(ValueTuple<Encounter, Procedure, object> _valueTuple) {
            (CqlTupleMetadata, Encounter QualifyingEncounterICU, Procedure AnesthesiaProcedure, object VTEProphylaxis)? ba_ = (CqlTupleMetadata_CGYAgYdKXUHcFINAPjMZNihh, _valueTuple.Item1, _valueTuple.Item2, _valueTuple.Item3);
            return ba_;
        }


        bool? i_((CqlTupleMetadata, Encounter QualifyingEncounterICU, Procedure AnesthesiaProcedure, object VTEProphylaxis)? tuple_drnlhywkgwmzdeyzybtiilbhf) {
            Code<EventStatus> bb_ = tuple_drnlhywkgwmzdeyzybtiilbhf?.AnesthesiaProcedure?.StatusElement;
            EventStatus? bc_ = bb_?.Value;
            string bd_ = context.Operators.Convert<string>(bc_);
            bool? be_ = context.Operators.Equal(bd_, "completed");
            object bf_;
            DataType cs_ = tuple_drnlhywkgwmzdeyzybtiilbhf?.AnesthesiaProcedure?.Performed;
            object ct_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cs_);
            bool cu_ = ct_ is CqlDateTime;
            if (cu_)
            {
                DataType cv_ = tuple_drnlhywkgwmzdeyzybtiilbhf?.AnesthesiaProcedure?.Performed;
                object cw_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cv_);
                bf_ = cw_ as CqlDateTime;
            }
            else
            {
                DataType cx_ = tuple_drnlhywkgwmzdeyzybtiilbhf?.AnesthesiaProcedure?.Performed;
                object cy_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cx_);
                bool cz_ = cy_ is CqlQuantity;
                if (cz_)
                {
                    DataType da_ = tuple_drnlhywkgwmzdeyzybtiilbhf?.AnesthesiaProcedure?.Performed;
                    object db_ = FHIRHelpers_4_4_000.Instance.ToValue(context, da_);
                    bf_ = db_ as CqlQuantity;
                }
                else
                {
                    DataType dc_ = tuple_drnlhywkgwmzdeyzybtiilbhf?.AnesthesiaProcedure?.Performed;
                    object dd_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dc_);
                    bool de_ = dd_ is CqlInterval<CqlDateTime>;
                    if (de_)
                    {
                        DataType df_ = tuple_drnlhywkgwmzdeyzybtiilbhf?.AnesthesiaProcedure?.Performed;
                        object dg_ = FHIRHelpers_4_4_000.Instance.ToValue(context, df_);
                        bf_ = dg_ as CqlInterval<CqlDateTime>;
                    }
                    else
                    {
                        DataType dh_ = tuple_drnlhywkgwmzdeyzybtiilbhf?.AnesthesiaProcedure?.Performed;
                        object di_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dh_);
                        bool dj_ = di_ is CqlInterval<CqlQuantity>;
                        if (dj_)
                        {
                            DataType dk_ = tuple_drnlhywkgwmzdeyzybtiilbhf?.AnesthesiaProcedure?.Performed;
                            object dl_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dk_);
                            bf_ = dl_ as CqlInterval<CqlQuantity>;
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
            CqlDateTime bi_ = this.startOfFirstICU(context, tuple_drnlhywkgwmzdeyzybtiilbhf?.QualifyingEncounterICU);
            CqlQuantity bj_ = context.Operators.Quantity(1m, "day");
            CqlDateTime bk_ = context.Operators.Add(bi_, bj_);
            bool? bl_ = context.Operators.SameAs(bh_, bk_, "day");
            bool? bm_ = context.Operators.And(be_, bl_);
            object bn_ = context.Operators.LateBoundProperty<object>(tuple_drnlhywkgwmzdeyzybtiilbhf?.VTEProphylaxis, "effective");
            object bo_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bn_);
            CqlInterval<CqlDateTime> bp_ = QICoreCommon_4_0_000.Instance.toInterval(context, bo_);
            object bq_;
            object dm_ = context.Operators.LateBoundProperty<object>(tuple_drnlhywkgwmzdeyzybtiilbhf?.VTEProphylaxis, "performed");
            object dn_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dm_);
            bool do_ = dn_ is CqlDateTime;
            if (do_)
            {
                object dp_ = context.Operators.LateBoundProperty<object>(tuple_drnlhywkgwmzdeyzybtiilbhf?.VTEProphylaxis, "performed");
                object dq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dp_);
                bq_ = dq_ as CqlDateTime;
            }
            else
            {
                object dr_ = context.Operators.LateBoundProperty<object>(tuple_drnlhywkgwmzdeyzybtiilbhf?.VTEProphylaxis, "performed");
                object ds_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dr_);
                bool dt_ = ds_ is CqlQuantity;
                if (dt_)
                {
                    object du_ = context.Operators.LateBoundProperty<object>(tuple_drnlhywkgwmzdeyzybtiilbhf?.VTEProphylaxis, "performed");
                    object dv_ = FHIRHelpers_4_4_000.Instance.ToValue(context, du_);
                    bq_ = dv_ as CqlQuantity;
                }
                else
                {
                    object dw_ = context.Operators.LateBoundProperty<object>(tuple_drnlhywkgwmzdeyzybtiilbhf?.VTEProphylaxis, "performed");
                    object dx_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dw_);
                    bool dy_ = dx_ is CqlInterval<CqlDateTime>;
                    if (dy_)
                    {
                        object dz_ = context.Operators.LateBoundProperty<object>(tuple_drnlhywkgwmzdeyzybtiilbhf?.VTEProphylaxis, "performed");
                        object ea_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dz_);
                        bq_ = ea_ as CqlInterval<CqlDateTime>;
                    }
                    else
                    {
                        object eb_ = context.Operators.LateBoundProperty<object>(tuple_drnlhywkgwmzdeyzybtiilbhf?.VTEProphylaxis, "performed");
                        object ec_ = FHIRHelpers_4_4_000.Instance.ToValue(context, eb_);
                        bool ed_ = ec_ is CqlInterval<CqlQuantity>;
                        if (ed_)
                        {
                            object ee_ = context.Operators.LateBoundProperty<object>(tuple_drnlhywkgwmzdeyzybtiilbhf?.VTEProphylaxis, "performed");
                            object ef_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ee_);
                            bq_ = ef_ as CqlInterval<CqlQuantity>;
                        }
                        else
                        {
                            bq_ = null;
                        }
                    }
                }
            }
            CqlInterval<CqlDateTime> br_ = QICoreCommon_4_0_000.Instance.toInterval(context, bq_);
            CqlDateTime bs_ = context.Operators.Start(bp_ ?? br_);
            object bt_;
            DataType eg_ = tuple_drnlhywkgwmzdeyzybtiilbhf?.AnesthesiaProcedure?.Performed;
            object eh_ = FHIRHelpers_4_4_000.Instance.ToValue(context, eg_);
            bool ei_ = eh_ is CqlDateTime;
            if (ei_)
            {
                DataType ej_ = tuple_drnlhywkgwmzdeyzybtiilbhf?.AnesthesiaProcedure?.Performed;
                object ek_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ej_);
                bt_ = ek_ as CqlDateTime;
            }
            else
            {
                DataType el_ = tuple_drnlhywkgwmzdeyzybtiilbhf?.AnesthesiaProcedure?.Performed;
                object em_ = FHIRHelpers_4_4_000.Instance.ToValue(context, el_);
                bool en_ = em_ is CqlQuantity;
                if (en_)
                {
                    DataType eo_ = tuple_drnlhywkgwmzdeyzybtiilbhf?.AnesthesiaProcedure?.Performed;
                    object ep_ = FHIRHelpers_4_4_000.Instance.ToValue(context, eo_);
                    bt_ = ep_ as CqlQuantity;
                }
                else
                {
                    DataType eq_ = tuple_drnlhywkgwmzdeyzybtiilbhf?.AnesthesiaProcedure?.Performed;
                    object er_ = FHIRHelpers_4_4_000.Instance.ToValue(context, eq_);
                    bool es_ = er_ is CqlInterval<CqlDateTime>;
                    if (es_)
                    {
                        DataType et_ = tuple_drnlhywkgwmzdeyzybtiilbhf?.AnesthesiaProcedure?.Performed;
                        object eu_ = FHIRHelpers_4_4_000.Instance.ToValue(context, et_);
                        bt_ = eu_ as CqlInterval<CqlDateTime>;
                    }
                    else
                    {
                        DataType ev_ = tuple_drnlhywkgwmzdeyzybtiilbhf?.AnesthesiaProcedure?.Performed;
                        object ew_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ev_);
                        bool ex_ = ew_ is CqlInterval<CqlQuantity>;
                        if (ex_)
                        {
                            DataType ey_ = tuple_drnlhywkgwmzdeyzybtiilbhf?.AnesthesiaProcedure?.Performed;
                            object ez_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ey_);
                            bt_ = ez_ as CqlInterval<CqlQuantity>;
                        }
                        else
                        {
                            bt_ = null;
                        }
                    }
                }
            }
            CqlInterval<CqlDateTime> bu_ = QICoreCommon_4_0_000.Instance.toInterval(context, bt_);
            CqlDateTime bv_ = context.Operators.End(bu_);
            CqlInterval<CqlDate> bw_ = TJCOverall_8_25_000.Instance.calendarDayOfOrDayAfter(context, bv_);
            CqlDate bx_ = bw_?.low;
            CqlDateTime by_ = context.Operators.ConvertDateToDateTime(bx_);
            object bz_;
            DataType fa_ = tuple_drnlhywkgwmzdeyzybtiilbhf?.AnesthesiaProcedure?.Performed;
            object fb_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fa_);
            bool fc_ = fb_ is CqlDateTime;
            if (fc_)
            {
                DataType fd_ = tuple_drnlhywkgwmzdeyzybtiilbhf?.AnesthesiaProcedure?.Performed;
                object fe_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fd_);
                bz_ = fe_ as CqlDateTime;
            }
            else
            {
                DataType ff_ = tuple_drnlhywkgwmzdeyzybtiilbhf?.AnesthesiaProcedure?.Performed;
                object fg_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ff_);
                bool fh_ = fg_ is CqlQuantity;
                if (fh_)
                {
                    DataType fi_ = tuple_drnlhywkgwmzdeyzybtiilbhf?.AnesthesiaProcedure?.Performed;
                    object fj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fi_);
                    bz_ = fj_ as CqlQuantity;
                }
                else
                {
                    DataType fk_ = tuple_drnlhywkgwmzdeyzybtiilbhf?.AnesthesiaProcedure?.Performed;
                    object fl_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fk_);
                    bool fm_ = fl_ is CqlInterval<CqlDateTime>;
                    if (fm_)
                    {
                        DataType fn_ = tuple_drnlhywkgwmzdeyzybtiilbhf?.AnesthesiaProcedure?.Performed;
                        object fo_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fn_);
                        bz_ = fo_ as CqlInterval<CqlDateTime>;
                    }
                    else
                    {
                        DataType fp_ = tuple_drnlhywkgwmzdeyzybtiilbhf?.AnesthesiaProcedure?.Performed;
                        object fq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fp_);
                        bool fr_ = fq_ is CqlInterval<CqlQuantity>;
                        if (fr_)
                        {
                            DataType fs_ = tuple_drnlhywkgwmzdeyzybtiilbhf?.AnesthesiaProcedure?.Performed;
                            object ft_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fs_);
                            bz_ = ft_ as CqlInterval<CqlQuantity>;
                        }
                        else
                        {
                            bz_ = null;
                        }
                    }
                }
            }
            CqlInterval<CqlDateTime> ca_ = QICoreCommon_4_0_000.Instance.toInterval(context, bz_);
            CqlDateTime cb_ = context.Operators.End(ca_);
            CqlInterval<CqlDate> cc_ = TJCOverall_8_25_000.Instance.calendarDayOfOrDayAfter(context, cb_);
            CqlDate cd_ = cc_?.high;
            CqlDateTime ce_ = context.Operators.ConvertDateToDateTime(cd_);
            object cf_;
            DataType fu_ = tuple_drnlhywkgwmzdeyzybtiilbhf?.AnesthesiaProcedure?.Performed;
            object fv_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fu_);
            bool fw_ = fv_ is CqlDateTime;
            if (fw_)
            {
                DataType fx_ = tuple_drnlhywkgwmzdeyzybtiilbhf?.AnesthesiaProcedure?.Performed;
                object fy_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fx_);
                cf_ = fy_ as CqlDateTime;
            }
            else
            {
                DataType fz_ = tuple_drnlhywkgwmzdeyzybtiilbhf?.AnesthesiaProcedure?.Performed;
                object ga_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fz_);
                bool gb_ = ga_ is CqlQuantity;
                if (gb_)
                {
                    DataType gc_ = tuple_drnlhywkgwmzdeyzybtiilbhf?.AnesthesiaProcedure?.Performed;
                    object gd_ = FHIRHelpers_4_4_000.Instance.ToValue(context, gc_);
                    cf_ = gd_ as CqlQuantity;
                }
                else
                {
                    DataType ge_ = tuple_drnlhywkgwmzdeyzybtiilbhf?.AnesthesiaProcedure?.Performed;
                    object gf_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ge_);
                    bool gg_ = gf_ is CqlInterval<CqlDateTime>;
                    if (gg_)
                    {
                        DataType gh_ = tuple_drnlhywkgwmzdeyzybtiilbhf?.AnesthesiaProcedure?.Performed;
                        object gi_ = FHIRHelpers_4_4_000.Instance.ToValue(context, gh_);
                        cf_ = gi_ as CqlInterval<CqlDateTime>;
                    }
                    else
                    {
                        DataType gj_ = tuple_drnlhywkgwmzdeyzybtiilbhf?.AnesthesiaProcedure?.Performed;
                        object gk_ = FHIRHelpers_4_4_000.Instance.ToValue(context, gj_);
                        bool gl_ = gk_ is CqlInterval<CqlQuantity>;
                        if (gl_)
                        {
                            DataType gm_ = tuple_drnlhywkgwmzdeyzybtiilbhf?.AnesthesiaProcedure?.Performed;
                            object gn_ = FHIRHelpers_4_4_000.Instance.ToValue(context, gm_);
                            cf_ = gn_ as CqlInterval<CqlQuantity>;
                        }
                        else
                        {
                            cf_ = null;
                        }
                    }
                }
            }
            CqlInterval<CqlDateTime> cg_ = QICoreCommon_4_0_000.Instance.toInterval(context, cf_);
            CqlDateTime ch_ = context.Operators.End(cg_);
            CqlInterval<CqlDate> ci_ = TJCOverall_8_25_000.Instance.calendarDayOfOrDayAfter(context, ch_);
            bool? cj_ = ci_?.lowClosed;
            object ck_;
            DataType go_ = tuple_drnlhywkgwmzdeyzybtiilbhf?.AnesthesiaProcedure?.Performed;
            object gp_ = FHIRHelpers_4_4_000.Instance.ToValue(context, go_);
            bool gq_ = gp_ is CqlDateTime;
            if (gq_)
            {
                DataType gr_ = tuple_drnlhywkgwmzdeyzybtiilbhf?.AnesthesiaProcedure?.Performed;
                object gs_ = FHIRHelpers_4_4_000.Instance.ToValue(context, gr_);
                ck_ = gs_ as CqlDateTime;
            }
            else
            {
                DataType gt_ = tuple_drnlhywkgwmzdeyzybtiilbhf?.AnesthesiaProcedure?.Performed;
                object gu_ = FHIRHelpers_4_4_000.Instance.ToValue(context, gt_);
                bool gv_ = gu_ is CqlQuantity;
                if (gv_)
                {
                    DataType gw_ = tuple_drnlhywkgwmzdeyzybtiilbhf?.AnesthesiaProcedure?.Performed;
                    object gx_ = FHIRHelpers_4_4_000.Instance.ToValue(context, gw_);
                    ck_ = gx_ as CqlQuantity;
                }
                else
                {
                    DataType gy_ = tuple_drnlhywkgwmzdeyzybtiilbhf?.AnesthesiaProcedure?.Performed;
                    object gz_ = FHIRHelpers_4_4_000.Instance.ToValue(context, gy_);
                    bool ha_ = gz_ is CqlInterval<CqlDateTime>;
                    if (ha_)
                    {
                        DataType hb_ = tuple_drnlhywkgwmzdeyzybtiilbhf?.AnesthesiaProcedure?.Performed;
                        object hc_ = FHIRHelpers_4_4_000.Instance.ToValue(context, hb_);
                        ck_ = hc_ as CqlInterval<CqlDateTime>;
                    }
                    else
                    {
                        DataType hd_ = tuple_drnlhywkgwmzdeyzybtiilbhf?.AnesthesiaProcedure?.Performed;
                        object he_ = FHIRHelpers_4_4_000.Instance.ToValue(context, hd_);
                        bool hf_ = he_ is CqlInterval<CqlQuantity>;
                        if (hf_)
                        {
                            DataType hg_ = tuple_drnlhywkgwmzdeyzybtiilbhf?.AnesthesiaProcedure?.Performed;
                            object hh_ = FHIRHelpers_4_4_000.Instance.ToValue(context, hg_);
                            ck_ = hh_ as CqlInterval<CqlQuantity>;
                        }
                        else
                        {
                            ck_ = null;
                        }
                    }
                }
            }
            CqlInterval<CqlDateTime> cl_ = QICoreCommon_4_0_000.Instance.toInterval(context, ck_);
            CqlDateTime cm_ = context.Operators.End(cl_);
            CqlInterval<CqlDate> cn_ = TJCOverall_8_25_000.Instance.calendarDayOfOrDayAfter(context, cm_);
            bool? co_ = cn_?.highClosed;
            CqlInterval<CqlDateTime> cp_ = context.Operators.Interval(by_, ce_, cj_, co_);
            bool? cq_ = context.Operators.In<CqlDateTime>(bs_, cp_, "day");
            bool? cr_ = context.Operators.And(bm_, cq_);
            return cr_;
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
                    string ad_ = (M is Resource
                        ? (M as Resource).IdElement
                        : default)?.Value;
                    DataType ae_ = MR?.Medication;
                    object af_ = context.Operators.LateBoundProperty<object>(ae_, "reference");
                    object ag_ = context.Operators.LateBoundProperty<object>(af_, "value");
                    IEnumerable<string> ah_ = context.Operators.Split((string)ag_, "/");
                    string ai_ = context.Operators.Last<string>(ah_);
                    bool? aj_ = context.Operators.Equal(ad_, ai_);
                    CodeableConcept ak_ = M?.Code;
                    CqlConcept al_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, ak_);
                    CqlValueSet am_ = this.Oral_Factor_Xa_Inhibitor_for_VTE_Prophylaxis_or_VTE_Treatment(context);
                    bool? an_ = context.Operators.ConceptInValueSet(al_, am_);
                    bool? ao_ = context.Operators.And(aj_, an_);
                    return ao_;
                }

                bool? ac_ = context.Operators.WhereAny<Medication>(aa_, ab_);
                return ac_;
            }

            IEnumerable<MedicationAdministration> u_ = context.Operators.Where<MedicationAdministration>(s_, t_);
            CqlValueSet v_ = this.Oral_Factor_Xa_Inhibitor_for_VTE_Prophylaxis_or_VTE_Treatment(context);
            IEnumerable<MedicationAdministration> w_ = context.Operators.Retrieve<MedicationAdministration>(new RetrieveParameters(default, v_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationadministration"));
            IEnumerable<MedicationAdministration> x_ = context.Operators.Union<MedicationAdministration>(u_, w_);

            bool? y_(MedicationAdministration FactorXaMedication) {
                Code<MedicationAdministration.MedicationAdministrationStatusCodes> ap_ = FactorXaMedication?.StatusElement;
                MedicationAdministration.MedicationAdministrationStatusCodes? aq_ = ap_?.Value;
                string ar_ = context.Operators.Convert<string>(aq_);
                bool? as_ = context.Operators.Equal(ar_, "completed");
                DataType at_ = FactorXaMedication?.Effective;
                object au_ = FHIRHelpers_4_4_000.Instance.ToValue(context, at_);
                CqlInterval<CqlDateTime> av_ = QICoreCommon_4_0_000.Instance.toInterval(context, au_);
                CqlDateTime aw_ = context.Operators.Start(av_);
                CqlDateTime ax_ = this.startOfFirstICU(context, QualifyingEncounterICU);
                CqlInterval<CqlDate> ay_ = TJCOverall_8_25_000.Instance.calendarDayOfOrDayAfter(context, ax_);
                CqlDate az_ = ay_?.low;
                CqlDateTime ba_ = context.Operators.ConvertDateToDateTime(az_);
                CqlDate bb_ = ay_?.high;
                CqlDateTime bc_ = context.Operators.ConvertDateToDateTime(bb_);
                bool? bd_ = ay_?.lowClosed;
                bool? be_ = ay_?.highClosed;
                CqlInterval<CqlDateTime> bf_ = context.Operators.Interval(ba_, bc_, bd_, be_);
                bool? bg_ = context.Operators.In<CqlDateTime>(aw_, bf_, "day");
                bool? bh_ = context.Operators.And(as_, bg_);
                return bh_;
            }

            bool? z_ = context.Operators.WhereAny<MedicationAdministration>(x_, y_);
            return z_;
        }

        IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);
        CqlValueSet d_ = this.General_or_Neuraxial_Anesthesia(context);
        IEnumerable<Procedure> e_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, d_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
        IEnumerable<MedicationAdministration> f_ = context.Operators.Retrieve<MedicationAdministration>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationadministration"));

        bool? g_(MedicationAdministration MR) {
            IEnumerable<Medication> bi_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));

            bool? bj_(Medication M) {
                string bl_ = (M is Resource
                    ? (M as Resource).IdElement
                    : default)?.Value;
                DataType bm_ = MR?.Medication;
                object bn_ = context.Operators.LateBoundProperty<object>(bm_, "reference");
                object bo_ = context.Operators.LateBoundProperty<object>(bn_, "value");
                IEnumerable<string> bp_ = context.Operators.Split((string)bo_, "/");
                string bq_ = context.Operators.Last<string>(bp_);
                bool? br_ = context.Operators.Equal(bl_, bq_);
                CodeableConcept bs_ = M?.Code;
                CqlConcept bt_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, bs_);
                CqlValueSet bu_ = this.Oral_Factor_Xa_Inhibitor_for_VTE_Prophylaxis_or_VTE_Treatment(context);
                bool? bv_ = context.Operators.ConceptInValueSet(bt_, bu_);
                bool? bw_ = context.Operators.And(br_, bv_);
                return bw_;
            }

            bool? bk_ = context.Operators.WhereAny<Medication>(bi_, bj_);
            return bk_;
        }

        IEnumerable<MedicationAdministration> h_ = context.Operators.Where<MedicationAdministration>(f_, g_);
        CqlValueSet i_ = this.Oral_Factor_Xa_Inhibitor_for_VTE_Prophylaxis_or_VTE_Treatment(context);
        IEnumerable<MedicationAdministration> j_ = context.Operators.Retrieve<MedicationAdministration>(new RetrieveParameters(default, i_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationadministration"));
        IEnumerable<MedicationAdministration> k_ = context.Operators.Union<MedicationAdministration>(h_, j_);
        IEnumerable<ValueTuple<Encounter, Procedure, MedicationAdministration>> l_ = context.Operators.CrossJoin<Encounter, Procedure, MedicationAdministration>(a_, e_, k_);

        (CqlTupleMetadata, Encounter QualifyingEncounterICU, Procedure AnesthesiaProcedure, MedicationAdministration FactorXaMedication)? m_(ValueTuple<Encounter, Procedure, MedicationAdministration> _valueTuple) {
            (CqlTupleMetadata, Encounter QualifyingEncounterICU, Procedure AnesthesiaProcedure, MedicationAdministration FactorXaMedication)? bx_ = (CqlTupleMetadata_IGcdIOTLGJfibgSLNOGSFRVB, _valueTuple.Item1, _valueTuple.Item2, _valueTuple.Item3);
            return bx_;
        }


        bool? n_((CqlTupleMetadata, Encounter QualifyingEncounterICU, Procedure AnesthesiaProcedure, MedicationAdministration FactorXaMedication)? tuple_elrfucfgncrbdgahdtkitiyzu) {
            Code<MedicationAdministration.MedicationAdministrationStatusCodes> by_ = tuple_elrfucfgncrbdgahdtkitiyzu?.FactorXaMedication?.StatusElement;
            MedicationAdministration.MedicationAdministrationStatusCodes? bz_ = by_?.Value;
            string ca_ = context.Operators.Convert<string>(bz_);
            bool? cb_ = context.Operators.Equal(ca_, "completed");
            Code<EventStatus> cc_ = tuple_elrfucfgncrbdgahdtkitiyzu?.AnesthesiaProcedure?.StatusElement;
            EventStatus? cd_ = cc_?.Value;
            string ce_ = context.Operators.Convert<string>(cd_);
            bool? cf_ = context.Operators.Equal(ce_, "completed");
            bool? cg_ = context.Operators.And(cb_, cf_);
            object ch_;
            DataType ds_ = tuple_elrfucfgncrbdgahdtkitiyzu?.AnesthesiaProcedure?.Performed;
            object dt_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ds_);
            bool du_ = dt_ is CqlDateTime;
            if (du_)
            {
                DataType dv_ = tuple_elrfucfgncrbdgahdtkitiyzu?.AnesthesiaProcedure?.Performed;
                object dw_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dv_);
                ch_ = dw_ as CqlDateTime;
            }
            else
            {
                DataType dx_ = tuple_elrfucfgncrbdgahdtkitiyzu?.AnesthesiaProcedure?.Performed;
                object dy_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dx_);
                bool dz_ = dy_ is CqlQuantity;
                if (dz_)
                {
                    DataType ea_ = tuple_elrfucfgncrbdgahdtkitiyzu?.AnesthesiaProcedure?.Performed;
                    object eb_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ea_);
                    ch_ = eb_ as CqlQuantity;
                }
                else
                {
                    DataType ec_ = tuple_elrfucfgncrbdgahdtkitiyzu?.AnesthesiaProcedure?.Performed;
                    object ed_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ec_);
                    bool ee_ = ed_ is CqlInterval<CqlDateTime>;
                    if (ee_)
                    {
                        DataType ef_ = tuple_elrfucfgncrbdgahdtkitiyzu?.AnesthesiaProcedure?.Performed;
                        object eg_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ef_);
                        ch_ = eg_ as CqlInterval<CqlDateTime>;
                    }
                    else
                    {
                        DataType eh_ = tuple_elrfucfgncrbdgahdtkitiyzu?.AnesthesiaProcedure?.Performed;
                        object ei_ = FHIRHelpers_4_4_000.Instance.ToValue(context, eh_);
                        bool ej_ = ei_ is CqlInterval<CqlQuantity>;
                        if (ej_)
                        {
                            DataType ek_ = tuple_elrfucfgncrbdgahdtkitiyzu?.AnesthesiaProcedure?.Performed;
                            object el_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ek_);
                            ch_ = el_ as CqlInterval<CqlQuantity>;
                        }
                        else
                        {
                            ch_ = null;
                        }
                    }
                }
            }
            CqlInterval<CqlDateTime> ci_ = QICoreCommon_4_0_000.Instance.toInterval(context, ch_);
            CqlDateTime cj_ = context.Operators.End(ci_);
            CqlDateTime ck_ = this.startOfFirstICU(context, tuple_elrfucfgncrbdgahdtkitiyzu?.QualifyingEncounterICU);
            CqlQuantity cl_ = context.Operators.Quantity(1m, "day");
            CqlDateTime cm_ = context.Operators.Add(ck_, cl_);
            bool? cn_ = context.Operators.SameAs(cj_, cm_, "day");
            bool? co_ = context.Operators.And(cg_, cn_);
            DataType cp_ = tuple_elrfucfgncrbdgahdtkitiyzu?.FactorXaMedication?.Effective;
            object cq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cp_);
            CqlInterval<CqlDateTime> cr_ = QICoreCommon_4_0_000.Instance.toInterval(context, cq_);
            CqlDateTime cs_ = context.Operators.Start(cr_);
            object ct_;
            DataType em_ = tuple_elrfucfgncrbdgahdtkitiyzu?.AnesthesiaProcedure?.Performed;
            object en_ = FHIRHelpers_4_4_000.Instance.ToValue(context, em_);
            bool eo_ = en_ is CqlDateTime;
            if (eo_)
            {
                DataType ep_ = tuple_elrfucfgncrbdgahdtkitiyzu?.AnesthesiaProcedure?.Performed;
                object eq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ep_);
                ct_ = eq_ as CqlDateTime;
            }
            else
            {
                DataType er_ = tuple_elrfucfgncrbdgahdtkitiyzu?.AnesthesiaProcedure?.Performed;
                object es_ = FHIRHelpers_4_4_000.Instance.ToValue(context, er_);
                bool et_ = es_ is CqlQuantity;
                if (et_)
                {
                    DataType eu_ = tuple_elrfucfgncrbdgahdtkitiyzu?.AnesthesiaProcedure?.Performed;
                    object ev_ = FHIRHelpers_4_4_000.Instance.ToValue(context, eu_);
                    ct_ = ev_ as CqlQuantity;
                }
                else
                {
                    DataType ew_ = tuple_elrfucfgncrbdgahdtkitiyzu?.AnesthesiaProcedure?.Performed;
                    object ex_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ew_);
                    bool ey_ = ex_ is CqlInterval<CqlDateTime>;
                    if (ey_)
                    {
                        DataType ez_ = tuple_elrfucfgncrbdgahdtkitiyzu?.AnesthesiaProcedure?.Performed;
                        object fa_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ez_);
                        ct_ = fa_ as CqlInterval<CqlDateTime>;
                    }
                    else
                    {
                        DataType fb_ = tuple_elrfucfgncrbdgahdtkitiyzu?.AnesthesiaProcedure?.Performed;
                        object fc_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fb_);
                        bool fd_ = fc_ is CqlInterval<CqlQuantity>;
                        if (fd_)
                        {
                            DataType fe_ = tuple_elrfucfgncrbdgahdtkitiyzu?.AnesthesiaProcedure?.Performed;
                            object ff_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fe_);
                            ct_ = ff_ as CqlInterval<CqlQuantity>;
                        }
                        else
                        {
                            ct_ = null;
                        }
                    }
                }
            }
            CqlInterval<CqlDateTime> cu_ = QICoreCommon_4_0_000.Instance.toInterval(context, ct_);
            CqlDateTime cv_ = context.Operators.End(cu_);
            CqlInterval<CqlDate> cw_ = TJCOverall_8_25_000.Instance.calendarDayOfOrDayAfter(context, cv_);
            CqlDate cx_ = cw_?.low;
            CqlDateTime cy_ = context.Operators.ConvertDateToDateTime(cx_);
            object cz_;
            DataType fg_ = tuple_elrfucfgncrbdgahdtkitiyzu?.AnesthesiaProcedure?.Performed;
            object fh_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fg_);
            bool fi_ = fh_ is CqlDateTime;
            if (fi_)
            {
                DataType fj_ = tuple_elrfucfgncrbdgahdtkitiyzu?.AnesthesiaProcedure?.Performed;
                object fk_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fj_);
                cz_ = fk_ as CqlDateTime;
            }
            else
            {
                DataType fl_ = tuple_elrfucfgncrbdgahdtkitiyzu?.AnesthesiaProcedure?.Performed;
                object fm_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fl_);
                bool fn_ = fm_ is CqlQuantity;
                if (fn_)
                {
                    DataType fo_ = tuple_elrfucfgncrbdgahdtkitiyzu?.AnesthesiaProcedure?.Performed;
                    object fp_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fo_);
                    cz_ = fp_ as CqlQuantity;
                }
                else
                {
                    DataType fq_ = tuple_elrfucfgncrbdgahdtkitiyzu?.AnesthesiaProcedure?.Performed;
                    object fr_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fq_);
                    bool fs_ = fr_ is CqlInterval<CqlDateTime>;
                    if (fs_)
                    {
                        DataType ft_ = tuple_elrfucfgncrbdgahdtkitiyzu?.AnesthesiaProcedure?.Performed;
                        object fu_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ft_);
                        cz_ = fu_ as CqlInterval<CqlDateTime>;
                    }
                    else
                    {
                        DataType fv_ = tuple_elrfucfgncrbdgahdtkitiyzu?.AnesthesiaProcedure?.Performed;
                        object fw_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fv_);
                        bool fx_ = fw_ is CqlInterval<CqlQuantity>;
                        if (fx_)
                        {
                            DataType fy_ = tuple_elrfucfgncrbdgahdtkitiyzu?.AnesthesiaProcedure?.Performed;
                            object fz_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fy_);
                            cz_ = fz_ as CqlInterval<CqlQuantity>;
                        }
                        else
                        {
                            cz_ = null;
                        }
                    }
                }
            }
            CqlInterval<CqlDateTime> da_ = QICoreCommon_4_0_000.Instance.toInterval(context, cz_);
            CqlDateTime db_ = context.Operators.End(da_);
            CqlInterval<CqlDate> dc_ = TJCOverall_8_25_000.Instance.calendarDayOfOrDayAfter(context, db_);
            CqlDate dd_ = dc_?.high;
            CqlDateTime de_ = context.Operators.ConvertDateToDateTime(dd_);
            object df_;
            DataType ga_ = tuple_elrfucfgncrbdgahdtkitiyzu?.AnesthesiaProcedure?.Performed;
            object gb_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ga_);
            bool gc_ = gb_ is CqlDateTime;
            if (gc_)
            {
                DataType gd_ = tuple_elrfucfgncrbdgahdtkitiyzu?.AnesthesiaProcedure?.Performed;
                object ge_ = FHIRHelpers_4_4_000.Instance.ToValue(context, gd_);
                df_ = ge_ as CqlDateTime;
            }
            else
            {
                DataType gf_ = tuple_elrfucfgncrbdgahdtkitiyzu?.AnesthesiaProcedure?.Performed;
                object gg_ = FHIRHelpers_4_4_000.Instance.ToValue(context, gf_);
                bool gh_ = gg_ is CqlQuantity;
                if (gh_)
                {
                    DataType gi_ = tuple_elrfucfgncrbdgahdtkitiyzu?.AnesthesiaProcedure?.Performed;
                    object gj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, gi_);
                    df_ = gj_ as CqlQuantity;
                }
                else
                {
                    DataType gk_ = tuple_elrfucfgncrbdgahdtkitiyzu?.AnesthesiaProcedure?.Performed;
                    object gl_ = FHIRHelpers_4_4_000.Instance.ToValue(context, gk_);
                    bool gm_ = gl_ is CqlInterval<CqlDateTime>;
                    if (gm_)
                    {
                        DataType gn_ = tuple_elrfucfgncrbdgahdtkitiyzu?.AnesthesiaProcedure?.Performed;
                        object go_ = FHIRHelpers_4_4_000.Instance.ToValue(context, gn_);
                        df_ = go_ as CqlInterval<CqlDateTime>;
                    }
                    else
                    {
                        DataType gp_ = tuple_elrfucfgncrbdgahdtkitiyzu?.AnesthesiaProcedure?.Performed;
                        object gq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, gp_);
                        bool gr_ = gq_ is CqlInterval<CqlQuantity>;
                        if (gr_)
                        {
                            DataType gs_ = tuple_elrfucfgncrbdgahdtkitiyzu?.AnesthesiaProcedure?.Performed;
                            object gt_ = FHIRHelpers_4_4_000.Instance.ToValue(context, gs_);
                            df_ = gt_ as CqlInterval<CqlQuantity>;
                        }
                        else
                        {
                            df_ = null;
                        }
                    }
                }
            }
            CqlInterval<CqlDateTime> dg_ = QICoreCommon_4_0_000.Instance.toInterval(context, df_);
            CqlDateTime dh_ = context.Operators.End(dg_);
            CqlInterval<CqlDate> di_ = TJCOverall_8_25_000.Instance.calendarDayOfOrDayAfter(context, dh_);
            bool? dj_ = di_?.lowClosed;
            object dk_;
            DataType gu_ = tuple_elrfucfgncrbdgahdtkitiyzu?.AnesthesiaProcedure?.Performed;
            object gv_ = FHIRHelpers_4_4_000.Instance.ToValue(context, gu_);
            bool gw_ = gv_ is CqlDateTime;
            if (gw_)
            {
                DataType gx_ = tuple_elrfucfgncrbdgahdtkitiyzu?.AnesthesiaProcedure?.Performed;
                object gy_ = FHIRHelpers_4_4_000.Instance.ToValue(context, gx_);
                dk_ = gy_ as CqlDateTime;
            }
            else
            {
                DataType gz_ = tuple_elrfucfgncrbdgahdtkitiyzu?.AnesthesiaProcedure?.Performed;
                object ha_ = FHIRHelpers_4_4_000.Instance.ToValue(context, gz_);
                bool hb_ = ha_ is CqlQuantity;
                if (hb_)
                {
                    DataType hc_ = tuple_elrfucfgncrbdgahdtkitiyzu?.AnesthesiaProcedure?.Performed;
                    object hd_ = FHIRHelpers_4_4_000.Instance.ToValue(context, hc_);
                    dk_ = hd_ as CqlQuantity;
                }
                else
                {
                    DataType he_ = tuple_elrfucfgncrbdgahdtkitiyzu?.AnesthesiaProcedure?.Performed;
                    object hf_ = FHIRHelpers_4_4_000.Instance.ToValue(context, he_);
                    bool hg_ = hf_ is CqlInterval<CqlDateTime>;
                    if (hg_)
                    {
                        DataType hh_ = tuple_elrfucfgncrbdgahdtkitiyzu?.AnesthesiaProcedure?.Performed;
                        object hi_ = FHIRHelpers_4_4_000.Instance.ToValue(context, hh_);
                        dk_ = hi_ as CqlInterval<CqlDateTime>;
                    }
                    else
                    {
                        DataType hj_ = tuple_elrfucfgncrbdgahdtkitiyzu?.AnesthesiaProcedure?.Performed;
                        object hk_ = FHIRHelpers_4_4_000.Instance.ToValue(context, hj_);
                        bool hl_ = hk_ is CqlInterval<CqlQuantity>;
                        if (hl_)
                        {
                            DataType hm_ = tuple_elrfucfgncrbdgahdtkitiyzu?.AnesthesiaProcedure?.Performed;
                            object hn_ = FHIRHelpers_4_4_000.Instance.ToValue(context, hm_);
                            dk_ = hn_ as CqlInterval<CqlQuantity>;
                        }
                        else
                        {
                            dk_ = null;
                        }
                    }
                }
            }
            CqlInterval<CqlDateTime> dl_ = QICoreCommon_4_0_000.Instance.toInterval(context, dk_);
            CqlDateTime dm_ = context.Operators.End(dl_);
            CqlInterval<CqlDate> dn_ = TJCOverall_8_25_000.Instance.calendarDayOfOrDayAfter(context, dm_);
            bool? do_ = dn_?.highClosed;
            CqlInterval<CqlDateTime> dp_ = context.Operators.Interval(cy_, de_, dj_, do_);
            bool? dq_ = context.Operators.In<CqlDateTime>(cs_, dp_, "day");
            bool? dr_ = context.Operators.And(co_, dq_);
            return dr_;
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
                bool? p_ = context.Operators.Not((bool?)(o_ is null));
                CqlCode q_ = QICoreCommon_4_0_000.Instance.refuted(context);
                CqlConcept r_ = context.Operators.ConvertCodeToConcept(q_);
                bool? s_ = context.Operators.Equivalent(o_, r_);
                bool? t_ = context.Operators.Not(s_);
                CqlCode u_ = QICoreCommon_4_0_000.Instance.entered_in_error(context);
                CqlConcept v_ = context.Operators.ConvertCodeToConcept(u_);
                bool? w_ = context.Operators.Equivalent(o_, v_);
                bool? x_ = context.Operators.Not(w_);
                bool? y_ = context.Operators.And(t_, x_);
                DataType z_ = AtrialFibrillation?.Onset;
                object aa_ = FHIRHelpers_4_4_000.Instance.ToValue(context, z_);
                CqlInterval<CqlDateTime> ab_ = QICoreCommon_4_0_000.Instance.toInterval(context, aa_);
                CqlDateTime ac_ = context.Operators.Start(ab_);
                Period ad_ = QualifyingEncounterICU?.Period;
                CqlInterval<CqlDateTime> ae_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ad_);
                CqlDateTime af_ = context.Operators.End(ae_);
                bool? ag_ = context.Operators.SameOrBefore(ac_, af_, (string)default);
                bool? ah_ = context.Operators.And(y_, ag_);
                bool? ai_ = context.Operators.Implies(p_, ah_);
                return ai_;
            }

            bool? m_ = context.Operators.WhereAny<Condition>(k_, l_);
            return m_;
        }

        IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);

        bool? d_(Encounter QualifyingEncounterICU) {
            CqlValueSet aj_ = this.Atrial_Fibrillation_or_Flutter(context);
            bool? ak_ = VTE_8_18_000.Instance.hasEncDiagnosisOf(context, QualifyingEncounterICU, aj_);
            return ak_;
        }

        IEnumerable<Encounter> e_ = context.Operators.Where<Encounter>(a_, d_);
        IEnumerable<Encounter> f_ = context.Operators.Union<Encounter>(c_, e_);

        bool? g_(Encounter QualifyingEncounterICU) {
            CqlValueSet al_ = this.Venous_Thromboembolism(context);
            IEnumerable<Condition> am_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, al_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-problems-health-concerns"));

            bool? an_(Condition VTEDiagnosis) {
                CodeableConcept ap_ = VTEDiagnosis?.ClinicalStatus;
                CqlConcept aq_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, ap_);
                CqlCode ar_ = QICoreCommon_4_0_000.Instance.inactive(context);
                CqlConcept as_ = context.Operators.ConvertCodeToConcept(ar_);
                bool? at_ = context.Operators.Equivalent(aq_, as_);
                CqlCode au_ = QICoreCommon_4_0_000.Instance.remission(context);
                CqlConcept av_ = context.Operators.ConvertCodeToConcept(au_);
                bool? aw_ = context.Operators.Equivalent(aq_, av_);
                bool? ax_ = context.Operators.Or(at_, aw_);
                CqlCode ay_ = QICoreCommon_4_0_000.Instance.resolved(context);
                CqlConcept az_ = context.Operators.ConvertCodeToConcept(ay_);
                bool? ba_ = context.Operators.Equivalent(aq_, az_);
                bool? bb_ = context.Operators.Or(ax_, ba_);
                CodeableConcept bc_ = VTEDiagnosis?.VerificationStatus;
                CqlConcept bd_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, bc_);
                bool? be_ = context.Operators.Not((bool?)(bd_ is null));
                bool? bf_ = context.Operators.And(bb_, be_);
                CqlCode bg_ = QICoreCommon_4_0_000.Instance.refuted(context);
                CqlConcept bh_ = context.Operators.ConvertCodeToConcept(bg_);
                bool? bi_ = context.Operators.Equivalent(bd_, bh_);
                bool? bj_ = context.Operators.Not(bi_);
                CqlCode bk_ = QICoreCommon_4_0_000.Instance.entered_in_error(context);
                CqlConcept bl_ = context.Operators.ConvertCodeToConcept(bk_);
                bool? bm_ = context.Operators.Equivalent(bd_, bl_);
                bool? bn_ = context.Operators.Not(bm_);
                bool? bo_ = context.Operators.And(bj_, bn_);
                DataType bp_ = VTEDiagnosis?.Onset;
                object bq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bp_);
                CqlInterval<CqlDateTime> br_ = QICoreCommon_4_0_000.Instance.toInterval(context, bq_);
                CqlInterval<CqlDateTime> bs_;
                Period bw_ = QualifyingEncounterICU?.Period;
                CqlInterval<CqlDateTime> bx_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, bw_);
                CqlDateTime by_ = context.Operators.Start(bx_);
                if (by_ is null)
                {
                    bs_ = default;
                }
                else
                {
                    Period bz_ = QualifyingEncounterICU?.Period;
                    CqlInterval<CqlDateTime> ca_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, bz_);
                    CqlDateTime cb_ = context.Operators.Start(ca_);
                    CqlInterval<CqlDateTime> cc_ = context.Operators.Interval(cb_, cb_, true, true);
                    bs_ = cc_;
                }
                bool? bt_ = context.Operators.Before(br_, bs_, (string)default);
                bool? bu_ = context.Operators.And(bo_, bt_);
                bool? bv_ = context.Operators.Implies(bf_, bu_);
                return bv_;
            }

            bool? ao_ = context.Operators.WhereAny<Condition>(am_, an_);
            return ao_;
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
                bool? n_ = context.Operators.Equal(m_, "completed");
                object o_;
                DataType w_ = HipKneeProcedure?.Performed;
                object x_ = FHIRHelpers_4_4_000.Instance.ToValue(context, w_);
                bool y_ = x_ is CqlDateTime;
                if (y_)
                {
                    DataType z_ = HipKneeProcedure?.Performed;
                    object aa_ = FHIRHelpers_4_4_000.Instance.ToValue(context, z_);
                    o_ = aa_ as CqlDateTime;
                }
                else
                {
                    DataType ab_ = HipKneeProcedure?.Performed;
                    object ac_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ab_);
                    bool ad_ = ac_ is CqlQuantity;
                    if (ad_)
                    {
                        DataType ae_ = HipKneeProcedure?.Performed;
                        object af_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ae_);
                        o_ = af_ as CqlQuantity;
                    }
                    else
                    {
                        DataType ag_ = HipKneeProcedure?.Performed;
                        object ah_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ag_);
                        bool ai_ = ah_ is CqlInterval<CqlDateTime>;
                        if (ai_)
                        {
                            DataType aj_ = HipKneeProcedure?.Performed;
                            object ak_ = FHIRHelpers_4_4_000.Instance.ToValue(context, aj_);
                            o_ = ak_ as CqlInterval<CqlDateTime>;
                        }
                        else
                        {
                            DataType al_ = HipKneeProcedure?.Performed;
                            object am_ = FHIRHelpers_4_4_000.Instance.ToValue(context, al_);
                            bool an_ = am_ is CqlInterval<CqlQuantity>;
                            if (an_)
                            {
                                DataType ao_ = HipKneeProcedure?.Performed;
                                object ap_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ao_);
                                o_ = ap_ as CqlInterval<CqlQuantity>;
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
                bool? u_ = context.Operators.SameOrBefore(q_, t_, (string)default);
                bool? v_ = context.Operators.And(n_, u_);
                return v_;
            }

            bool? j_ = context.Operators.WhereAny<Procedure>(h_, i_);
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
            bool? aq_ = context.Operators.ConceptInValueSet(ao_ as CqlConcept, ap_);
            Code<ObservationStatus> ar_ = VTERiskAssessment?.StatusElement;
            ObservationStatus? as_ = ar_?.Value;
            string at_ = context.Operators.Convert<string>(as_);
            string[] au_ = [
                "final",
                "amended",
                "corrected",
            ];
            bool? av_ = context.Operators.In<string>(at_, (IEnumerable<string>)au_);
            bool? aw_ = context.Operators.And(aq_, av_);
            return aw_;
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
                DataType bf_ = VTERiskAssessment?.Effective;
                object bg_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bf_);
                az_ = bg_ as CqlDateTime;
            }
            else
            {
                DataType bh_ = VTERiskAssessment?.Effective;
                object bi_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bh_);
                bool bj_ = bi_ is CqlDateTime;
                if (bj_)
                {
                    DataType bk_ = VTERiskAssessment?.Effective;
                    object bl_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bk_);
                    az_ = bl_ as CqlDateTime;
                }
                else
                {
                    DataType bm_ = VTERiskAssessment?.Effective;
                    object bn_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bm_);
                    bool bo_ = bn_ is CqlInterval<CqlDateTime>;
                    if (bo_)
                    {
                        DataType bp_ = VTERiskAssessment?.Effective;
                        object bq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bp_);
                        az_ = bq_ as CqlInterval<CqlDateTime>;
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
            DataType br_ = INRLabTest?.Value;
            object bs_ = FHIRHelpers_4_4_000.Instance.ToValue(context, br_);
            CqlQuantity bt_ = context.Operators.ConvertDecimalToQuantity(3.0m);
            bool? bu_ = context.Operators.Greater(bs_ as CqlQuantity, bt_);
            Code<ObservationStatus> bv_ = INRLabTest?.StatusElement;
            ObservationStatus? bw_ = bv_?.Value;
            string bx_ = context.Operators.Convert<string>(bw_);
            string[] by_ = [
                "final",
                "amended",
                "corrected",
            ];
            bool? bz_ = context.Operators.In<string>(bx_, (IEnumerable<string>)by_);
            bool? ca_ = context.Operators.And(bu_, bz_);
            return ca_;
        }


        (CqlTupleMetadata, string id, CqlDateTime LowRiskDatetime)? k_(Observation INRLabTest) {
            Id cb_ = INRLabTest?.IdElement;
            string cc_ = cb_?.Value;
            Instant cd_ = INRLabTest?.IssuedElement;
            DateTimeOffset? ce_ = cd_?.Value;
            CqlDateTime cf_ = context.Operators.Convert<CqlDateTime>(ce_);
            (CqlTupleMetadata, string id, CqlDateTime LowRiskDatetime)? cg_ = (CqlTupleMetadata_DMAfXNhTfZDWOGdfEceXbfaSJ, cc_, cf_);
            return cg_;
        }

        IEnumerable<(CqlTupleMetadata, string id, CqlDateTime LowRiskDatetime)?> l_ = context.Operators.WhereSelect<Observation, (CqlTupleMetadata, string id, CqlDateTime LowRiskDatetime)?>(i_, j_, k_);
        IEnumerable<(CqlTupleMetadata, string id, CqlDateTime LowRiskDatetime)?> m_ = context.Operators.Distinct<(CqlTupleMetadata, string id, CqlDateTime LowRiskDatetime)?>(l_);
        IEnumerable<(CqlTupleMetadata, string id, CqlDateTime LowRiskDatetime)?> n_ = context.Operators.Union<(CqlTupleMetadata, string id, CqlDateTime LowRiskDatetime)?>(g_, m_);
        IEnumerable<MedicationAdministration> o_ = context.Operators.Retrieve<MedicationAdministration>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationadministration"));

        bool? p_(MedicationAdministration MR) {
            IEnumerable<Medication> ch_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));

            bool? ci_(Medication M) {
                string ck_ = (M is Resource
                    ? (M as Resource).IdElement
                    : default)?.Value;
                DataType cl_ = MR?.Medication;
                object cm_ = context.Operators.LateBoundProperty<object>(cl_, "reference");
                object cn_ = context.Operators.LateBoundProperty<object>(cm_, "value");
                IEnumerable<string> co_ = context.Operators.Split((string)cn_, "/");
                string cp_ = context.Operators.Last<string>(co_);
                bool? cq_ = context.Operators.Equal(ck_, cp_);
                CodeableConcept cr_ = M?.Code;
                CqlConcept cs_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, cr_);
                CqlValueSet ct_ = this.Unfractionated_Heparin(context);
                bool? cu_ = context.Operators.ConceptInValueSet(cs_, ct_);
                bool? cv_ = context.Operators.And(cq_, cu_);
                return cv_;
            }

            bool? cj_ = context.Operators.WhereAny<Medication>(ch_, ci_);
            return cj_;
        }

        IEnumerable<MedicationAdministration> q_ = context.Operators.Where<MedicationAdministration>(o_, p_);
        CqlValueSet r_ = this.Unfractionated_Heparin(context);
        IEnumerable<MedicationAdministration> s_ = context.Operators.Retrieve<MedicationAdministration>(new RetrieveParameters(default, r_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationadministration"));
        IEnumerable<MedicationAdministration> t_ = context.Operators.Union<MedicationAdministration>(q_, s_);

        bool? u_(MedicationAdministration UnfractionatedHeparin) {
            MedicationAdministration.DosageComponent cw_ = UnfractionatedHeparin?.Dosage;
            CodeableConcept cx_ = cw_?.Route;
            CqlConcept cy_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, cx_);
            CqlValueSet cz_ = this.Intravenous_route(context);
            bool? da_ = context.Operators.ConceptInValueSet(cy_, cz_);
            return da_;
        }

        IEnumerable<MedicationAdministration> v_ = context.Operators.Where<MedicationAdministration>(t_, u_);

        bool? w_(MedicationAdministration MR) {
            IEnumerable<Medication> db_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));

            bool? dc_(Medication M) {
                string de_ = (M is Resource
                    ? (M as Resource).IdElement
                    : default)?.Value;
                DataType df_ = MR?.Medication;
                object dg_ = context.Operators.LateBoundProperty<object>(df_, "reference");
                object dh_ = context.Operators.LateBoundProperty<object>(dg_, "value");
                IEnumerable<string> di_ = context.Operators.Split((string)dh_, "/");
                string dj_ = context.Operators.Last<string>(di_);
                bool? dk_ = context.Operators.Equal(de_, dj_);
                CodeableConcept dl_ = M?.Code;
                CqlConcept dm_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, dl_);
                CqlValueSet dn_ = this.Direct_Thrombin_Inhibitor(context);
                bool? do_ = context.Operators.ConceptInValueSet(dm_, dn_);
                bool? dp_ = context.Operators.And(dk_, do_);
                return dp_;
            }

            bool? dd_ = context.Operators.WhereAny<Medication>(db_, dc_);
            return dd_;
        }

        IEnumerable<MedicationAdministration> x_ = context.Operators.Where<MedicationAdministration>(o_, w_);
        CqlValueSet y_ = this.Direct_Thrombin_Inhibitor(context);
        IEnumerable<MedicationAdministration> z_ = context.Operators.Retrieve<MedicationAdministration>(new RetrieveParameters(default, y_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationadministration"));
        IEnumerable<MedicationAdministration> aa_ = context.Operators.Union<MedicationAdministration>(x_, z_);
        IEnumerable<MedicationAdministration> ab_ = context.Operators.Union<MedicationAdministration>(v_, aa_);

        bool? ac_(MedicationAdministration MR) {
            IEnumerable<Medication> dq_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));

            bool? dr_(Medication M) {
                string dt_ = (M is Resource
                    ? (M as Resource).IdElement
                    : default)?.Value;
                DataType du_ = MR?.Medication;
                object dv_ = context.Operators.LateBoundProperty<object>(du_, "reference");
                object dw_ = context.Operators.LateBoundProperty<object>(dv_, "value");
                IEnumerable<string> dx_ = context.Operators.Split((string)dw_, "/");
                string dy_ = context.Operators.Last<string>(dx_);
                bool? dz_ = context.Operators.Equal(dt_, dy_);
                CodeableConcept ea_ = M?.Code;
                CqlConcept eb_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, ea_);
                CqlValueSet ec_ = this.Glycoprotein_IIb_IIIa_Inhibitors(context);
                bool? ed_ = context.Operators.ConceptInValueSet(eb_, ec_);
                bool? ee_ = context.Operators.And(dz_, ed_);
                return ee_;
            }

            bool? ds_ = context.Operators.WhereAny<Medication>(dq_, dr_);
            return ds_;
        }

        IEnumerable<MedicationAdministration> ad_ = context.Operators.Where<MedicationAdministration>(o_, ac_);
        CqlValueSet ae_ = this.Glycoprotein_IIb_IIIa_Inhibitors(context);
        IEnumerable<MedicationAdministration> af_ = context.Operators.Retrieve<MedicationAdministration>(new RetrieveParameters(default, ae_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationadministration"));
        IEnumerable<MedicationAdministration> ag_ = context.Operators.Union<MedicationAdministration>(ad_, af_);
        IEnumerable<MedicationAdministration> ah_ = context.Operators.Union<MedicationAdministration>(ab_, ag_);

        bool? ai_(MedicationAdministration AnticoagulantMedication) {
            Code<MedicationAdministration.MedicationAdministrationStatusCodes> ef_ = AnticoagulantMedication?.StatusElement;
            MedicationAdministration.MedicationAdministrationStatusCodes? eg_ = ef_?.Value;
            string eh_ = context.Operators.Convert<string>(eg_);
            bool? ei_ = context.Operators.Equal(eh_, "completed");
            return ei_;
        }


        (CqlTupleMetadata, string id, CqlDateTime LowRiskDatetime)? aj_(MedicationAdministration AnticoagulantMedication) {
            Id ej_ = AnticoagulantMedication?.IdElement;
            string ek_ = ej_?.Value;
            DataType el_ = AnticoagulantMedication?.Effective;
            object em_ = FHIRHelpers_4_4_000.Instance.ToValue(context, el_);
            CqlInterval<CqlDateTime> en_ = QICoreCommon_4_0_000.Instance.toInterval(context, em_);
            CqlDateTime eo_ = context.Operators.Start(en_);
            (CqlTupleMetadata, string id, CqlDateTime LowRiskDatetime)? ep_ = (CqlTupleMetadata_DMAfXNhTfZDWOGdfEceXbfaSJ, ek_, eo_);
            return ep_;
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
                bool? m_ = h_?.lowClosed;
                bool? n_ = h_?.highClosed;
                CqlInterval<CqlDateTime> o_ = context.Operators.Interval(j_, l_, m_, n_);
                bool? p_ = context.Operators.In<CqlDateTime>(g_, o_, "day");
                return p_;
            }

            bool? f_ = context.Operators.WhereAny<(CqlTupleMetadata, string id, CqlDateTime LowRiskDatetime)?>(d_, e_);
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
            bool? o_ = context.Operators.Equal(n_, "completed");
            object p_;
            DataType ax_ = tuple_cchfidtccovheihiyjcdnfkbm?.AnesthesiaProcedure?.Performed;
            object ay_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ax_);
            bool az_ = ay_ is CqlDateTime;
            if (az_)
            {
                DataType ba_ = tuple_cchfidtccovheihiyjcdnfkbm?.AnesthesiaProcedure?.Performed;
                object bb_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ba_);
                p_ = bb_ as CqlDateTime;
            }
            else
            {
                DataType bc_ = tuple_cchfidtccovheihiyjcdnfkbm?.AnesthesiaProcedure?.Performed;
                object bd_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bc_);
                bool be_ = bd_ is CqlQuantity;
                if (be_)
                {
                    DataType bf_ = tuple_cchfidtccovheihiyjcdnfkbm?.AnesthesiaProcedure?.Performed;
                    object bg_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bf_);
                    p_ = bg_ as CqlQuantity;
                }
                else
                {
                    DataType bh_ = tuple_cchfidtccovheihiyjcdnfkbm?.AnesthesiaProcedure?.Performed;
                    object bi_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bh_);
                    bool bj_ = bi_ is CqlInterval<CqlDateTime>;
                    if (bj_)
                    {
                        DataType bk_ = tuple_cchfidtccovheihiyjcdnfkbm?.AnesthesiaProcedure?.Performed;
                        object bl_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bk_);
                        p_ = bl_ as CqlInterval<CqlDateTime>;
                    }
                    else
                    {
                        DataType bm_ = tuple_cchfidtccovheihiyjcdnfkbm?.AnesthesiaProcedure?.Performed;
                        object bn_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bm_);
                        bool bo_ = bn_ is CqlInterval<CqlQuantity>;
                        if (bo_)
                        {
                            DataType bp_ = tuple_cchfidtccovheihiyjcdnfkbm?.AnesthesiaProcedure?.Performed;
                            object bq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bp_);
                            p_ = bq_ as CqlInterval<CqlQuantity>;
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
            bool? v_ = context.Operators.SameAs(r_, u_, "day");
            bool? w_ = context.Operators.And(o_, v_);
            CqlDateTime x_ = tuple_cchfidtccovheihiyjcdnfkbm?.LowRiskForVTE?.LowRiskDatetime;
            object y_;
            DataType br_ = tuple_cchfidtccovheihiyjcdnfkbm?.AnesthesiaProcedure?.Performed;
            object bs_ = FHIRHelpers_4_4_000.Instance.ToValue(context, br_);
            bool bt_ = bs_ is CqlDateTime;
            if (bt_)
            {
                DataType bu_ = tuple_cchfidtccovheihiyjcdnfkbm?.AnesthesiaProcedure?.Performed;
                object bv_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bu_);
                y_ = bv_ as CqlDateTime;
            }
            else
            {
                DataType bw_ = tuple_cchfidtccovheihiyjcdnfkbm?.AnesthesiaProcedure?.Performed;
                object bx_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bw_);
                bool by_ = bx_ is CqlQuantity;
                if (by_)
                {
                    DataType bz_ = tuple_cchfidtccovheihiyjcdnfkbm?.AnesthesiaProcedure?.Performed;
                    object ca_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bz_);
                    y_ = ca_ as CqlQuantity;
                }
                else
                {
                    DataType cb_ = tuple_cchfidtccovheihiyjcdnfkbm?.AnesthesiaProcedure?.Performed;
                    object cc_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cb_);
                    bool cd_ = cc_ is CqlInterval<CqlDateTime>;
                    if (cd_)
                    {
                        DataType ce_ = tuple_cchfidtccovheihiyjcdnfkbm?.AnesthesiaProcedure?.Performed;
                        object cf_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ce_);
                        y_ = cf_ as CqlInterval<CqlDateTime>;
                    }
                    else
                    {
                        DataType cg_ = tuple_cchfidtccovheihiyjcdnfkbm?.AnesthesiaProcedure?.Performed;
                        object ch_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cg_);
                        bool ci_ = ch_ is CqlInterval<CqlQuantity>;
                        if (ci_)
                        {
                            DataType cj_ = tuple_cchfidtccovheihiyjcdnfkbm?.AnesthesiaProcedure?.Performed;
                            object ck_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cj_);
                            y_ = ck_ as CqlInterval<CqlQuantity>;
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
            DataType cl_ = tuple_cchfidtccovheihiyjcdnfkbm?.AnesthesiaProcedure?.Performed;
            object cm_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cl_);
            bool cn_ = cm_ is CqlDateTime;
            if (cn_)
            {
                DataType co_ = tuple_cchfidtccovheihiyjcdnfkbm?.AnesthesiaProcedure?.Performed;
                object cp_ = FHIRHelpers_4_4_000.Instance.ToValue(context, co_);
                ae_ = cp_ as CqlDateTime;
            }
            else
            {
                DataType cq_ = tuple_cchfidtccovheihiyjcdnfkbm?.AnesthesiaProcedure?.Performed;
                object cr_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cq_);
                bool cs_ = cr_ is CqlQuantity;
                if (cs_)
                {
                    DataType ct_ = tuple_cchfidtccovheihiyjcdnfkbm?.AnesthesiaProcedure?.Performed;
                    object cu_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ct_);
                    ae_ = cu_ as CqlQuantity;
                }
                else
                {
                    DataType cv_ = tuple_cchfidtccovheihiyjcdnfkbm?.AnesthesiaProcedure?.Performed;
                    object cw_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cv_);
                    bool cx_ = cw_ is CqlInterval<CqlDateTime>;
                    if (cx_)
                    {
                        DataType cy_ = tuple_cchfidtccovheihiyjcdnfkbm?.AnesthesiaProcedure?.Performed;
                        object cz_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cy_);
                        ae_ = cz_ as CqlInterval<CqlDateTime>;
                    }
                    else
                    {
                        DataType da_ = tuple_cchfidtccovheihiyjcdnfkbm?.AnesthesiaProcedure?.Performed;
                        object db_ = FHIRHelpers_4_4_000.Instance.ToValue(context, da_);
                        bool dc_ = db_ is CqlInterval<CqlQuantity>;
                        if (dc_)
                        {
                            DataType dd_ = tuple_cchfidtccovheihiyjcdnfkbm?.AnesthesiaProcedure?.Performed;
                            object de_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dd_);
                            ae_ = de_ as CqlInterval<CqlQuantity>;
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
            DataType df_ = tuple_cchfidtccovheihiyjcdnfkbm?.AnesthesiaProcedure?.Performed;
            object dg_ = FHIRHelpers_4_4_000.Instance.ToValue(context, df_);
            bool dh_ = dg_ is CqlDateTime;
            if (dh_)
            {
                DataType di_ = tuple_cchfidtccovheihiyjcdnfkbm?.AnesthesiaProcedure?.Performed;
                object dj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, di_);
                ak_ = dj_ as CqlDateTime;
            }
            else
            {
                DataType dk_ = tuple_cchfidtccovheihiyjcdnfkbm?.AnesthesiaProcedure?.Performed;
                object dl_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dk_);
                bool dm_ = dl_ is CqlQuantity;
                if (dm_)
                {
                    DataType dn_ = tuple_cchfidtccovheihiyjcdnfkbm?.AnesthesiaProcedure?.Performed;
                    object do_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dn_);
                    ak_ = do_ as CqlQuantity;
                }
                else
                {
                    DataType dp_ = tuple_cchfidtccovheihiyjcdnfkbm?.AnesthesiaProcedure?.Performed;
                    object dq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dp_);
                    bool dr_ = dq_ is CqlInterval<CqlDateTime>;
                    if (dr_)
                    {
                        DataType ds_ = tuple_cchfidtccovheihiyjcdnfkbm?.AnesthesiaProcedure?.Performed;
                        object dt_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ds_);
                        ak_ = dt_ as CqlInterval<CqlDateTime>;
                    }
                    else
                    {
                        DataType du_ = tuple_cchfidtccovheihiyjcdnfkbm?.AnesthesiaProcedure?.Performed;
                        object dv_ = FHIRHelpers_4_4_000.Instance.ToValue(context, du_);
                        bool dw_ = dv_ is CqlInterval<CqlQuantity>;
                        if (dw_)
                        {
                            DataType dx_ = tuple_cchfidtccovheihiyjcdnfkbm?.AnesthesiaProcedure?.Performed;
                            object dy_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dx_);
                            ak_ = dy_ as CqlInterval<CqlQuantity>;
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
            bool? ao_ = an_?.lowClosed;
            object ap_;
            DataType dz_ = tuple_cchfidtccovheihiyjcdnfkbm?.AnesthesiaProcedure?.Performed;
            object ea_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dz_);
            bool eb_ = ea_ is CqlDateTime;
            if (eb_)
            {
                DataType ec_ = tuple_cchfidtccovheihiyjcdnfkbm?.AnesthesiaProcedure?.Performed;
                object ed_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ec_);
                ap_ = ed_ as CqlDateTime;
            }
            else
            {
                DataType ee_ = tuple_cchfidtccovheihiyjcdnfkbm?.AnesthesiaProcedure?.Performed;
                object ef_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ee_);
                bool eg_ = ef_ is CqlQuantity;
                if (eg_)
                {
                    DataType eh_ = tuple_cchfidtccovheihiyjcdnfkbm?.AnesthesiaProcedure?.Performed;
                    object ei_ = FHIRHelpers_4_4_000.Instance.ToValue(context, eh_);
                    ap_ = ei_ as CqlQuantity;
                }
                else
                {
                    DataType ej_ = tuple_cchfidtccovheihiyjcdnfkbm?.AnesthesiaProcedure?.Performed;
                    object ek_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ej_);
                    bool el_ = ek_ is CqlInterval<CqlDateTime>;
                    if (el_)
                    {
                        DataType em_ = tuple_cchfidtccovheihiyjcdnfkbm?.AnesthesiaProcedure?.Performed;
                        object en_ = FHIRHelpers_4_4_000.Instance.ToValue(context, em_);
                        ap_ = en_ as CqlInterval<CqlDateTime>;
                    }
                    else
                    {
                        DataType eo_ = tuple_cchfidtccovheihiyjcdnfkbm?.AnesthesiaProcedure?.Performed;
                        object ep_ = FHIRHelpers_4_4_000.Instance.ToValue(context, eo_);
                        bool eq_ = ep_ is CqlInterval<CqlQuantity>;
                        if (eq_)
                        {
                            DataType er_ = tuple_cchfidtccovheihiyjcdnfkbm?.AnesthesiaProcedure?.Performed;
                            object es_ = FHIRHelpers_4_4_000.Instance.ToValue(context, er_);
                            ap_ = es_ as CqlInterval<CqlQuantity>;
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
            bool? at_ = as_?.highClosed;
            CqlInterval<CqlDateTime> au_ = context.Operators.Interval(ad_, aj_, ao_, at_);
            bool? av_ = context.Operators.In<CqlDateTime>(x_, au_, "day");
            bool? aw_ = context.Operators.And(w_, av_);
            return aw_;
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
                CqlConcept ch_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);
                return ch_;
            }

            IEnumerable<CqlConcept> cb_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)bz_, ca_);

            bool? cc_(Extension @this) {
                FhirUri ci_ = @this?.UrlElement;
                string cj_ = FHIRHelpers_4_4_000.Instance.ToString(context, ci_);
                bool? ck_ = context.Operators.Equal(cj_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-recorded");
                return ck_;
            }


            object cd_(Extension @this) {
                DataType cl_ = @this?.Value;
                object cm_ = context.Operators.LateBoundProperty<object>(cl_, "value");
                return cm_;
            }

            IEnumerable<object> ce_ = context.Operators.WhereSelect<Extension, object>((IEnumerable<Extension>)(NoMedicationAdm is DomainResource
                ? (NoMedicationAdm as DomainResource).Extension
                : default), cc_, cd_);
            object cf_ = context.Operators.SingletonFrom<object>(ce_);
            (CqlTupleMetadata, string id, IEnumerable<CqlConcept> medicationStatusReason, FhirDateTime authoredOn)? cg_ = (CqlTupleMetadata_EBcSahXYZdeFjUUbgULReCZAe, by_, cb_, (FhirDateTime)cf_);
            return cg_;
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
            bool? ct_ = context.Operators.In<string>(cr_, (IEnumerable<string>)cs_);
            Code<MedicationRequest.MedicationrequestStatus> cu_ = NoMedicationOrder?.StatusElement;
            MedicationRequest.MedicationrequestStatus? cv_ = cu_?.Value;
            string cw_ = context.Operators.Convert<string>(cv_);
            string[] cx_ = [
                "active",
                "completed",
            ];
            bool? cy_ = context.Operators.In<string>(cw_, (IEnumerable<string>)cx_);
            bool? cz_ = context.Operators.And(ct_, cy_);
            return cz_;
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
                string dm_ = (M is Resource
                    ? (M as Resource).IdElement
                    : default)?.Value;
                DataType dn_ = MR?.Medication;
                object do_ = context.Operators.LateBoundProperty<object>(dn_, "reference");
                object dp_ = context.Operators.LateBoundProperty<object>(do_, "value");
                IEnumerable<string> dq_ = context.Operators.Split((string)dp_, "/");
                string dr_ = context.Operators.Last<string>(dq_);
                bool? ds_ = context.Operators.Equal(dm_, dr_);
                CodeableConcept dt_ = M?.Code;
                CqlConcept du_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, dt_);
                CqlValueSet dv_ = this.Low_Dose_Unfractionated_Heparin_for_VTE_Prophylaxis(context);
                bool? dw_ = context.Operators.ConceptInValueSet(du_, dv_);
                bool? dx_ = context.Operators.And(ds_, dw_);
                return dx_;
            }

            bool? dl_ = context.Operators.WhereAny<Medication>(dj_, dk_);
            return dl_;
        }

        IEnumerable<MedicationRequest> as_ = context.Operators.Where<MedicationRequest>(aq_, ar_);
        IEnumerable<MedicationRequest> at_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> au_ = context.Operators.Union<MedicationRequest>(as_, at_);

        bool? av_(MedicationRequest MR) {
            IEnumerable<Medication> dy_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));

            bool? dz_(Medication M) {
                string eb_ = (M is Resource
                    ? (M as Resource).IdElement
                    : default)?.Value;
                DataType ec_ = MR?.Medication;
                object ed_ = context.Operators.LateBoundProperty<object>(ec_, "reference");
                object ee_ = context.Operators.LateBoundProperty<object>(ed_, "value");
                IEnumerable<string> ef_ = context.Operators.Split((string)ee_, "/");
                string eg_ = context.Operators.Last<string>(ef_);
                bool? eh_ = context.Operators.Equal(eb_, eg_);
                CodeableConcept ei_ = M?.Code;
                CqlConcept ej_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, ei_);
                CqlValueSet ek_ = this.Low_Molecular_Weight_Heparin_for_VTE_Prophylaxis(context);
                bool? el_ = context.Operators.ConceptInValueSet(ej_, ek_);
                bool? em_ = context.Operators.And(eh_, el_);
                return em_;
            }

            bool? ea_ = context.Operators.WhereAny<Medication>(dy_, dz_);
            return ea_;
        }

        IEnumerable<MedicationRequest> aw_ = context.Operators.Where<MedicationRequest>(aq_, av_);
        IEnumerable<MedicationRequest> ax_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, d_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> ay_ = context.Operators.Union<MedicationRequest>(aw_, ax_);
        IEnumerable<MedicationRequest> az_ = context.Operators.Union<MedicationRequest>(au_, ay_);

        bool? ba_(MedicationRequest MR) {
            IEnumerable<Medication> en_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));

            bool? eo_(Medication M) {
                string eq_ = (M is Resource
                    ? (M as Resource).IdElement
                    : default)?.Value;
                DataType er_ = MR?.Medication;
                object es_ = context.Operators.LateBoundProperty<object>(er_, "reference");
                object et_ = context.Operators.LateBoundProperty<object>(es_, "value");
                IEnumerable<string> eu_ = context.Operators.Split((string)et_, "/");
                string ev_ = context.Operators.Last<string>(eu_);
                bool? ew_ = context.Operators.Equal(eq_, ev_);
                CodeableConcept ex_ = M?.Code;
                CqlConcept ey_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, ex_);
                CqlValueSet ez_ = this.Injectable_Factor_Xa_Inhibitor_for_VTE_Prophylaxis(context);
                bool? fa_ = context.Operators.ConceptInValueSet(ey_, ez_);
                bool? fb_ = context.Operators.And(ew_, fa_);
                return fb_;
            }

            bool? ep_ = context.Operators.WhereAny<Medication>(en_, eo_);
            return ep_;
        }

        IEnumerable<MedicationRequest> bb_ = context.Operators.Where<MedicationRequest>(aq_, ba_);
        IEnumerable<MedicationRequest> bc_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, h_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> bd_ = context.Operators.Union<MedicationRequest>(bb_, bc_);
        IEnumerable<MedicationRequest> be_ = context.Operators.Union<MedicationRequest>(az_, bd_);

        bool? bf_(MedicationRequest MR) {
            IEnumerable<Medication> fc_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));

            bool? fd_(Medication M) {
                string ff_ = (M is Resource
                    ? (M as Resource).IdElement
                    : default)?.Value;
                DataType fg_ = MR?.Medication;
                object fh_ = context.Operators.LateBoundProperty<object>(fg_, "reference");
                object fi_ = context.Operators.LateBoundProperty<object>(fh_, "value");
                IEnumerable<string> fj_ = context.Operators.Split((string)fi_, "/");
                string fk_ = context.Operators.Last<string>(fj_);
                bool? fl_ = context.Operators.Equal(ff_, fk_);
                CodeableConcept fm_ = M?.Code;
                CqlConcept fn_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, fm_);
                CqlValueSet fo_ = this.Warfarin(context);
                bool? fp_ = context.Operators.ConceptInValueSet(fn_, fo_);
                bool? fq_ = context.Operators.And(fl_, fp_);
                return fq_;
            }

            bool? fe_ = context.Operators.WhereAny<Medication>(fc_, fd_);
            return fe_;
        }

        IEnumerable<MedicationRequest> bg_ = context.Operators.Where<MedicationRequest>(aq_, bf_);
        IEnumerable<MedicationRequest> bh_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, l_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> bi_ = context.Operators.Union<MedicationRequest>(bg_, bh_);
        IEnumerable<MedicationRequest> bj_ = context.Operators.Union<MedicationRequest>(be_, bi_);

        bool? bk_(MedicationRequest MR) {
            IEnumerable<Medication> fr_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));

            bool? fs_(Medication M) {
                string fu_ = (M is Resource
                    ? (M as Resource).IdElement
                    : default)?.Value;
                DataType fv_ = MR?.Medication;
                object fw_ = context.Operators.LateBoundProperty<object>(fv_, "reference");
                object fx_ = context.Operators.LateBoundProperty<object>(fw_, "value");
                IEnumerable<string> fy_ = context.Operators.Split((string)fx_, "/");
                string fz_ = context.Operators.Last<string>(fy_);
                bool? ga_ = context.Operators.Equal(fu_, fz_);
                CodeableConcept gb_ = M?.Code;
                CqlConcept gc_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, gb_);
                CqlValueSet gd_ = this.Rivaroxaban_for_VTE_Prophylaxis(context);
                bool? ge_ = context.Operators.ConceptInValueSet(gc_, gd_);
                bool? gf_ = context.Operators.And(ga_, ge_);
                return gf_;
            }

            bool? ft_ = context.Operators.WhereAny<Medication>(fr_, fs_);
            return ft_;
        }

        IEnumerable<MedicationRequest> bl_ = context.Operators.Where<MedicationRequest>(aq_, bk_);
        IEnumerable<MedicationRequest> bm_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, p_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> bn_ = context.Operators.Union<MedicationRequest>(bl_, bm_);
        IEnumerable<MedicationRequest> bo_ = context.Operators.Union<MedicationRequest>(bj_, bn_);
        IEnumerable<Task> bp_ = context.Operators.Retrieve<Task>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-taskrejected"));
        IEnumerable<ValueTuple<MedicationRequest, Task>> bq_ = context.Operators.CrossJoin<MedicationRequest, Task>(bo_, bp_);

        (CqlTupleMetadata, MedicationRequest MedicationOrderReject, Task T)? br_(ValueTuple<MedicationRequest, Task> _valueTuple) {
            (CqlTupleMetadata, MedicationRequest MedicationOrderReject, Task T)? gg_ = (CqlTupleMetadata_IIUQMBcJhJBPgdDOLHaTTRUE, _valueTuple.Item1, _valueTuple.Item2);
            return gg_;
        }


        bool? bs_((CqlTupleMetadata, MedicationRequest MedicationOrderReject, Task T)? tuple_iiuqmbcjhjbpgddolhattrue) {
            ResourceReference gh_ = tuple_iiuqmbcjhjbpgddolhattrue?.T?.Focus;
            bool? gi_ = QICoreCommon_4_0_000.Instance.references(context, gh_, tuple_iiuqmbcjhjbpgddolhattrue?.MedicationOrderReject);
            CodeableConcept gj_ = tuple_iiuqmbcjhjbpgddolhattrue?.T?.Code;
            CqlConcept gk_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, gj_);
            CqlCode gl_ = QICoreCommon_4_0_000.Instance.Fulfill(context);
            CqlConcept gm_ = context.Operators.ConvertCodeToConcept(gl_);
            bool? gn_ = context.Operators.Equivalent(gk_, gm_);
            bool? go_ = context.Operators.And(gi_, gn_);
            Code<MedicationRequest.MedicationrequestStatus> gp_ = tuple_iiuqmbcjhjbpgddolhattrue?.MedicationOrderReject?.StatusElement;
            MedicationRequest.MedicationrequestStatus? gq_ = gp_?.Value;
            string gr_ = context.Operators.Convert<string>(gq_);
            bool? gs_ = context.Operators.Equal(gr_, "active");
            bool? gt_ = context.Operators.And(go_, gs_);
            return gt_;
        }

        IEnumerable<(CqlTupleMetadata, MedicationRequest MedicationOrderReject, Task T)?> bt_ = context.Operators.SelectWhere<ValueTuple<MedicationRequest, Task>, (CqlTupleMetadata, MedicationRequest MedicationOrderReject, Task T)?>(bq_, br_, bs_);

        (CqlTupleMetadata, string id, IEnumerable<CqlConcept> medicationStatusReason, CqlDateTime authoredOn)? bu_((CqlTupleMetadata, MedicationRequest MedicationOrderReject, Task T)? tuple_iiuqmbcjhjbpgddolhattrue) {
            Id gu_ = tuple_iiuqmbcjhjbpgddolhattrue?.MedicationOrderReject?.IdElement;
            string gv_ = gu_?.Value;
            CodeableConcept gw_ = tuple_iiuqmbcjhjbpgddolhattrue?.T?.StatusReason;
            CqlConcept gx_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, gw_);
            CqlConcept[] gy_ = [
                gx_,
            ];
            FhirDateTime gz_ = tuple_iiuqmbcjhjbpgddolhattrue?.MedicationOrderReject?.AuthoredOnElement;
            CqlDateTime ha_ = context.Operators.Convert<CqlDateTime>(gz_);
            (CqlTupleMetadata, string id, IEnumerable<CqlConcept> medicationStatusReason, CqlDateTime authoredOn)? hb_ = (CqlTupleMetadata_CNeQfiIHcQEUBjZNVZiOLfdeP, gv_, (IEnumerable<CqlConcept>)gy_, ha_);
            return hb_;
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
                bool? i_ = context.Operators.ConceptsInValueSet(g_, h_);
                CqlDateTime j_ = NoVTEMedication?.authoredOn;
                CqlInterval<CqlDate> k_ = this.fromDayOfStartOfHospitalizationToDayAfterFirstICU(context, QualifyingEncounterICU);
                CqlDate l_ = k_?.low;
                CqlDateTime m_ = context.Operators.ConvertDateToDateTime(l_);
                CqlDate n_ = k_?.high;
                CqlDateTime o_ = context.Operators.ConvertDateToDateTime(n_);
                bool? p_ = k_?.lowClosed;
                bool? q_ = k_?.highClosed;
                CqlInterval<CqlDateTime> r_ = context.Operators.Interval(m_, o_, p_, q_);
                bool? s_ = context.Operators.In<CqlDateTime>(j_, r_, "day");
                bool? t_ = context.Operators.And(i_, s_);
                return t_;
            }

            bool? f_ = context.Operators.WhereAny<(CqlTupleMetadata, string id, IEnumerable<CqlConcept> medicationStatusReason, CqlDateTime authoredOn)?>(d_, e_);
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
            bool? az_ = context.Operators.In<string>(ax_, (IEnumerable<string>)ay_);
            return az_;
        }


        (CqlTupleMetadata, string id, CodeableConcept requestStatusReason, CqlDateTime authoredOn)? m_(ServiceRequest DeviceNotOrder) {
            Id ba_ = DeviceNotOrder?.IdElement;
            string bb_ = ba_?.Value;

            bool? bc_(Extension @this) {
                FhirUri bl_ = @this?.UrlElement;
                string bm_ = FHIRHelpers_4_4_000.Instance.ToString(context, bl_);
                bool? bn_ = context.Operators.Equal(bm_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-doNotPerformReason");
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
            bool? bx_ = context.Operators.In<string>(bv_, (IEnumerable<string>)bw_);
            Code<RequestStatus> by_ = tuple_yyidpxbnjhogfrjkyrbmgchb?.DeviceOrderReject?.StatusElement;
            RequestStatus? bz_ = by_?.Value;
            Code<RequestStatus> ca_ = context.Operators.Convert<Code<RequestStatus>>(bz_);
            bool? cb_ = context.Operators.Equal(ca_, "active");
            bool? cc_ = context.Operators.And(bx_, cb_);
            ResourceReference cd_ = tuple_yyidpxbnjhogfrjkyrbmgchb?.T?.Focus;
            bool? ce_ = QICoreCommon_4_0_000.Instance.references(context, cd_, tuple_yyidpxbnjhogfrjkyrbmgchb?.DeviceOrderReject);
            bool? cf_ = context.Operators.And(cc_, ce_);
            CodeableConcept cg_ = tuple_yyidpxbnjhogfrjkyrbmgchb?.T?.Code;
            CqlConcept ch_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, cg_);
            CqlCode ci_ = QICoreCommon_4_0_000.Instance.Fulfill(context);
            CqlConcept cj_ = context.Operators.ConvertCodeToConcept(ci_);
            bool? ck_ = context.Operators.Equivalent(ch_, cj_);
            bool? cl_ = context.Operators.And(cf_, ck_);
            return cl_;
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
                FhirUri dc_ = @this?.UrlElement;
                string dd_ = FHIRHelpers_4_4_000.Instance.ToString(context, dc_);
                bool? de_ = context.Operators.Equal(dd_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-recorded");
                return de_;
            }


            object cy_(Extension @this) {
                DataType df_ = @this?.Value;
                object dg_ = context.Operators.LateBoundProperty<object>(df_, "value");
                return dg_;
            }

            IEnumerable<object> cz_ = context.Operators.WhereSelect<Extension, object>((IEnumerable<Extension>)(DeviceNotApplied is DomainResource
                ? (DeviceNotApplied as DomainResource).Extension
                : default), cx_, cy_);
            object da_ = context.Operators.SingletonFrom<object>(cz_);
            (CqlTupleMetadata, string id, CqlConcept requestStatusReason, FhirDateTime authoredOn)? db_ = (CqlTupleMetadata_DPXDaXjPQUNAIiZCCbGhNdDMi, cu_, cw_, (FhirDateTime)da_);
            return db_;
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
                bool? i_ = context.Operators.ConceptInValueSet(g_, h_);
                CqlDateTime j_ = NoVTEDevice?.authoredOn;
                CqlInterval<CqlDate> k_ = this.fromDayOfStartOfHospitalizationToDayAfterFirstICU(context, QualifyingEncounterICU);
                CqlDate l_ = k_?.low;
                CqlDateTime m_ = context.Operators.ConvertDateToDateTime(l_);
                CqlDate n_ = k_?.high;
                CqlDateTime o_ = context.Operators.ConvertDateToDateTime(n_);
                bool? p_ = k_?.lowClosed;
                bool? q_ = k_?.highClosed;
                CqlInterval<CqlDateTime> r_ = context.Operators.Interval(m_, o_, p_, q_);
                bool? s_ = context.Operators.In<CqlDateTime>(j_, r_, "day");
                bool? t_ = context.Operators.And(i_, s_);
                return t_;
            }

            bool? f_ = context.Operators.WhereAny<(CqlTupleMetadata, string id, CqlConcept requestStatusReason, CqlDateTime authoredOn)?>(d_, e_);
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
            bool? n_ = context.Operators.ConceptsInValueSet(l_, m_);
            Code<EventStatus> o_ = tuple_fpgtpszgoyfdaobujrgcsedde?.AnesthesiaProcedure?.StatusElement;
            EventStatus? p_ = o_?.Value;
            string q_ = context.Operators.Convert<string>(p_);
            bool? r_ = context.Operators.Equal(q_, "completed");
            bool? s_ = context.Operators.And(n_, r_);
            object t_;
            DataType bb_ = tuple_fpgtpszgoyfdaobujrgcsedde?.AnesthesiaProcedure?.Performed;
            object bc_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bb_);
            bool bd_ = bc_ is CqlDateTime;
            if (bd_)
            {
                DataType be_ = tuple_fpgtpszgoyfdaobujrgcsedde?.AnesthesiaProcedure?.Performed;
                object bf_ = FHIRHelpers_4_4_000.Instance.ToValue(context, be_);
                t_ = bf_ as CqlDateTime;
            }
            else
            {
                DataType bg_ = tuple_fpgtpszgoyfdaobujrgcsedde?.AnesthesiaProcedure?.Performed;
                object bh_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bg_);
                bool bi_ = bh_ is CqlQuantity;
                if (bi_)
                {
                    DataType bj_ = tuple_fpgtpszgoyfdaobujrgcsedde?.AnesthesiaProcedure?.Performed;
                    object bk_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bj_);
                    t_ = bk_ as CqlQuantity;
                }
                else
                {
                    DataType bl_ = tuple_fpgtpszgoyfdaobujrgcsedde?.AnesthesiaProcedure?.Performed;
                    object bm_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bl_);
                    bool bn_ = bm_ is CqlInterval<CqlDateTime>;
                    if (bn_)
                    {
                        DataType bo_ = tuple_fpgtpszgoyfdaobujrgcsedde?.AnesthesiaProcedure?.Performed;
                        object bp_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bo_);
                        t_ = bp_ as CqlInterval<CqlDateTime>;
                    }
                    else
                    {
                        DataType bq_ = tuple_fpgtpszgoyfdaobujrgcsedde?.AnesthesiaProcedure?.Performed;
                        object br_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bq_);
                        bool bs_ = br_ is CqlInterval<CqlQuantity>;
                        if (bs_)
                        {
                            DataType bt_ = tuple_fpgtpszgoyfdaobujrgcsedde?.AnesthesiaProcedure?.Performed;
                            object bu_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bt_);
                            t_ = bu_ as CqlInterval<CqlQuantity>;
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
            bool? z_ = context.Operators.SameAs(v_, y_, "day");
            bool? aa_ = context.Operators.And(s_, z_);
            CqlDateTime ab_ = tuple_fpgtpszgoyfdaobujrgcsedde?.NoVTEMedication?.authoredOn;
            object ac_;
            DataType bv_ = tuple_fpgtpszgoyfdaobujrgcsedde?.AnesthesiaProcedure?.Performed;
            object bw_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bv_);
            bool bx_ = bw_ is CqlDateTime;
            if (bx_)
            {
                DataType by_ = tuple_fpgtpszgoyfdaobujrgcsedde?.AnesthesiaProcedure?.Performed;
                object bz_ = FHIRHelpers_4_4_000.Instance.ToValue(context, by_);
                ac_ = bz_ as CqlDateTime;
            }
            else
            {
                DataType ca_ = tuple_fpgtpszgoyfdaobujrgcsedde?.AnesthesiaProcedure?.Performed;
                object cb_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ca_);
                bool cc_ = cb_ is CqlQuantity;
                if (cc_)
                {
                    DataType cd_ = tuple_fpgtpszgoyfdaobujrgcsedde?.AnesthesiaProcedure?.Performed;
                    object ce_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cd_);
                    ac_ = ce_ as CqlQuantity;
                }
                else
                {
                    DataType cf_ = tuple_fpgtpszgoyfdaobujrgcsedde?.AnesthesiaProcedure?.Performed;
                    object cg_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cf_);
                    bool ch_ = cg_ is CqlInterval<CqlDateTime>;
                    if (ch_)
                    {
                        DataType ci_ = tuple_fpgtpszgoyfdaobujrgcsedde?.AnesthesiaProcedure?.Performed;
                        object cj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ci_);
                        ac_ = cj_ as CqlInterval<CqlDateTime>;
                    }
                    else
                    {
                        DataType ck_ = tuple_fpgtpszgoyfdaobujrgcsedde?.AnesthesiaProcedure?.Performed;
                        object cl_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ck_);
                        bool cm_ = cl_ is CqlInterval<CqlQuantity>;
                        if (cm_)
                        {
                            DataType cn_ = tuple_fpgtpszgoyfdaobujrgcsedde?.AnesthesiaProcedure?.Performed;
                            object co_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cn_);
                            ac_ = co_ as CqlInterval<CqlQuantity>;
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
            DataType cp_ = tuple_fpgtpszgoyfdaobujrgcsedde?.AnesthesiaProcedure?.Performed;
            object cq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cp_);
            bool cr_ = cq_ is CqlDateTime;
            if (cr_)
            {
                DataType cs_ = tuple_fpgtpszgoyfdaobujrgcsedde?.AnesthesiaProcedure?.Performed;
                object ct_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cs_);
                ai_ = ct_ as CqlDateTime;
            }
            else
            {
                DataType cu_ = tuple_fpgtpszgoyfdaobujrgcsedde?.AnesthesiaProcedure?.Performed;
                object cv_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cu_);
                bool cw_ = cv_ is CqlQuantity;
                if (cw_)
                {
                    DataType cx_ = tuple_fpgtpszgoyfdaobujrgcsedde?.AnesthesiaProcedure?.Performed;
                    object cy_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cx_);
                    ai_ = cy_ as CqlQuantity;
                }
                else
                {
                    DataType cz_ = tuple_fpgtpszgoyfdaobujrgcsedde?.AnesthesiaProcedure?.Performed;
                    object da_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cz_);
                    bool db_ = da_ is CqlInterval<CqlDateTime>;
                    if (db_)
                    {
                        DataType dc_ = tuple_fpgtpszgoyfdaobujrgcsedde?.AnesthesiaProcedure?.Performed;
                        object dd_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dc_);
                        ai_ = dd_ as CqlInterval<CqlDateTime>;
                    }
                    else
                    {
                        DataType de_ = tuple_fpgtpszgoyfdaobujrgcsedde?.AnesthesiaProcedure?.Performed;
                        object df_ = FHIRHelpers_4_4_000.Instance.ToValue(context, de_);
                        bool dg_ = df_ is CqlInterval<CqlQuantity>;
                        if (dg_)
                        {
                            DataType dh_ = tuple_fpgtpszgoyfdaobujrgcsedde?.AnesthesiaProcedure?.Performed;
                            object di_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dh_);
                            ai_ = di_ as CqlInterval<CqlQuantity>;
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
            DataType dj_ = tuple_fpgtpszgoyfdaobujrgcsedde?.AnesthesiaProcedure?.Performed;
            object dk_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dj_);
            bool dl_ = dk_ is CqlDateTime;
            if (dl_)
            {
                DataType dm_ = tuple_fpgtpszgoyfdaobujrgcsedde?.AnesthesiaProcedure?.Performed;
                object dn_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dm_);
                ao_ = dn_ as CqlDateTime;
            }
            else
            {
                DataType do_ = tuple_fpgtpszgoyfdaobujrgcsedde?.AnesthesiaProcedure?.Performed;
                object dp_ = FHIRHelpers_4_4_000.Instance.ToValue(context, do_);
                bool dq_ = dp_ is CqlQuantity;
                if (dq_)
                {
                    DataType dr_ = tuple_fpgtpszgoyfdaobujrgcsedde?.AnesthesiaProcedure?.Performed;
                    object ds_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dr_);
                    ao_ = ds_ as CqlQuantity;
                }
                else
                {
                    DataType dt_ = tuple_fpgtpszgoyfdaobujrgcsedde?.AnesthesiaProcedure?.Performed;
                    object du_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dt_);
                    bool dv_ = du_ is CqlInterval<CqlDateTime>;
                    if (dv_)
                    {
                        DataType dw_ = tuple_fpgtpszgoyfdaobujrgcsedde?.AnesthesiaProcedure?.Performed;
                        object dx_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dw_);
                        ao_ = dx_ as CqlInterval<CqlDateTime>;
                    }
                    else
                    {
                        DataType dy_ = tuple_fpgtpszgoyfdaobujrgcsedde?.AnesthesiaProcedure?.Performed;
                        object dz_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dy_);
                        bool ea_ = dz_ is CqlInterval<CqlQuantity>;
                        if (ea_)
                        {
                            DataType eb_ = tuple_fpgtpszgoyfdaobujrgcsedde?.AnesthesiaProcedure?.Performed;
                            object ec_ = FHIRHelpers_4_4_000.Instance.ToValue(context, eb_);
                            ao_ = ec_ as CqlInterval<CqlQuantity>;
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
            bool? as_ = ar_?.lowClosed;
            object at_;
            DataType ed_ = tuple_fpgtpszgoyfdaobujrgcsedde?.AnesthesiaProcedure?.Performed;
            object ee_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ed_);
            bool ef_ = ee_ is CqlDateTime;
            if (ef_)
            {
                DataType eg_ = tuple_fpgtpszgoyfdaobujrgcsedde?.AnesthesiaProcedure?.Performed;
                object eh_ = FHIRHelpers_4_4_000.Instance.ToValue(context, eg_);
                at_ = eh_ as CqlDateTime;
            }
            else
            {
                DataType ei_ = tuple_fpgtpszgoyfdaobujrgcsedde?.AnesthesiaProcedure?.Performed;
                object ej_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ei_);
                bool ek_ = ej_ is CqlQuantity;
                if (ek_)
                {
                    DataType el_ = tuple_fpgtpszgoyfdaobujrgcsedde?.AnesthesiaProcedure?.Performed;
                    object em_ = FHIRHelpers_4_4_000.Instance.ToValue(context, el_);
                    at_ = em_ as CqlQuantity;
                }
                else
                {
                    DataType en_ = tuple_fpgtpszgoyfdaobujrgcsedde?.AnesthesiaProcedure?.Performed;
                    object eo_ = FHIRHelpers_4_4_000.Instance.ToValue(context, en_);
                    bool ep_ = eo_ is CqlInterval<CqlDateTime>;
                    if (ep_)
                    {
                        DataType eq_ = tuple_fpgtpszgoyfdaobujrgcsedde?.AnesthesiaProcedure?.Performed;
                        object er_ = FHIRHelpers_4_4_000.Instance.ToValue(context, eq_);
                        at_ = er_ as CqlInterval<CqlDateTime>;
                    }
                    else
                    {
                        DataType es_ = tuple_fpgtpszgoyfdaobujrgcsedde?.AnesthesiaProcedure?.Performed;
                        object et_ = FHIRHelpers_4_4_000.Instance.ToValue(context, es_);
                        bool eu_ = et_ is CqlInterval<CqlQuantity>;
                        if (eu_)
                        {
                            DataType ev_ = tuple_fpgtpszgoyfdaobujrgcsedde?.AnesthesiaProcedure?.Performed;
                            object ew_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ev_);
                            at_ = ew_ as CqlInterval<CqlQuantity>;
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
            bool? ax_ = aw_?.highClosed;
            CqlInterval<CqlDateTime> ay_ = context.Operators.Interval(ah_, an_, as_, ax_);
            bool? az_ = context.Operators.In<CqlDateTime>(ab_, ay_, "day");
            bool? ba_ = context.Operators.And(aa_, az_);
            return ba_;
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
            bool? n_ = context.Operators.ConceptInValueSet(l_, m_);
            Code<EventStatus> o_ = tuple_fnrkedfurymcjidjkbtaenork?.AnesthesiaProcedure?.StatusElement;
            EventStatus? p_ = o_?.Value;
            string q_ = context.Operators.Convert<string>(p_);
            bool? r_ = context.Operators.Equal(q_, "completed");
            bool? s_ = context.Operators.And(n_, r_);
            object t_;
            DataType bb_ = tuple_fnrkedfurymcjidjkbtaenork?.AnesthesiaProcedure?.Performed;
            object bc_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bb_);
            bool bd_ = bc_ is CqlDateTime;
            if (bd_)
            {
                DataType be_ = tuple_fnrkedfurymcjidjkbtaenork?.AnesthesiaProcedure?.Performed;
                object bf_ = FHIRHelpers_4_4_000.Instance.ToValue(context, be_);
                t_ = bf_ as CqlDateTime;
            }
            else
            {
                DataType bg_ = tuple_fnrkedfurymcjidjkbtaenork?.AnesthesiaProcedure?.Performed;
                object bh_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bg_);
                bool bi_ = bh_ is CqlQuantity;
                if (bi_)
                {
                    DataType bj_ = tuple_fnrkedfurymcjidjkbtaenork?.AnesthesiaProcedure?.Performed;
                    object bk_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bj_);
                    t_ = bk_ as CqlQuantity;
                }
                else
                {
                    DataType bl_ = tuple_fnrkedfurymcjidjkbtaenork?.AnesthesiaProcedure?.Performed;
                    object bm_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bl_);
                    bool bn_ = bm_ is CqlInterval<CqlDateTime>;
                    if (bn_)
                    {
                        DataType bo_ = tuple_fnrkedfurymcjidjkbtaenork?.AnesthesiaProcedure?.Performed;
                        object bp_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bo_);
                        t_ = bp_ as CqlInterval<CqlDateTime>;
                    }
                    else
                    {
                        DataType bq_ = tuple_fnrkedfurymcjidjkbtaenork?.AnesthesiaProcedure?.Performed;
                        object br_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bq_);
                        bool bs_ = br_ is CqlInterval<CqlQuantity>;
                        if (bs_)
                        {
                            DataType bt_ = tuple_fnrkedfurymcjidjkbtaenork?.AnesthesiaProcedure?.Performed;
                            object bu_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bt_);
                            t_ = bu_ as CqlInterval<CqlQuantity>;
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
            bool? z_ = context.Operators.SameAs(v_, y_, "day");
            bool? aa_ = context.Operators.And(s_, z_);
            CqlDateTime ab_ = tuple_fnrkedfurymcjidjkbtaenork?.NoVTEDevice?.authoredOn;
            object ac_;
            DataType bv_ = tuple_fnrkedfurymcjidjkbtaenork?.AnesthesiaProcedure?.Performed;
            object bw_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bv_);
            bool bx_ = bw_ is CqlDateTime;
            if (bx_)
            {
                DataType by_ = tuple_fnrkedfurymcjidjkbtaenork?.AnesthesiaProcedure?.Performed;
                object bz_ = FHIRHelpers_4_4_000.Instance.ToValue(context, by_);
                ac_ = bz_ as CqlDateTime;
            }
            else
            {
                DataType ca_ = tuple_fnrkedfurymcjidjkbtaenork?.AnesthesiaProcedure?.Performed;
                object cb_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ca_);
                bool cc_ = cb_ is CqlQuantity;
                if (cc_)
                {
                    DataType cd_ = tuple_fnrkedfurymcjidjkbtaenork?.AnesthesiaProcedure?.Performed;
                    object ce_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cd_);
                    ac_ = ce_ as CqlQuantity;
                }
                else
                {
                    DataType cf_ = tuple_fnrkedfurymcjidjkbtaenork?.AnesthesiaProcedure?.Performed;
                    object cg_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cf_);
                    bool ch_ = cg_ is CqlInterval<CqlDateTime>;
                    if (ch_)
                    {
                        DataType ci_ = tuple_fnrkedfurymcjidjkbtaenork?.AnesthesiaProcedure?.Performed;
                        object cj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ci_);
                        ac_ = cj_ as CqlInterval<CqlDateTime>;
                    }
                    else
                    {
                        DataType ck_ = tuple_fnrkedfurymcjidjkbtaenork?.AnesthesiaProcedure?.Performed;
                        object cl_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ck_);
                        bool cm_ = cl_ is CqlInterval<CqlQuantity>;
                        if (cm_)
                        {
                            DataType cn_ = tuple_fnrkedfurymcjidjkbtaenork?.AnesthesiaProcedure?.Performed;
                            object co_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cn_);
                            ac_ = co_ as CqlInterval<CqlQuantity>;
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
            DataType cp_ = tuple_fnrkedfurymcjidjkbtaenork?.AnesthesiaProcedure?.Performed;
            object cq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cp_);
            bool cr_ = cq_ is CqlDateTime;
            if (cr_)
            {
                DataType cs_ = tuple_fnrkedfurymcjidjkbtaenork?.AnesthesiaProcedure?.Performed;
                object ct_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cs_);
                ai_ = ct_ as CqlDateTime;
            }
            else
            {
                DataType cu_ = tuple_fnrkedfurymcjidjkbtaenork?.AnesthesiaProcedure?.Performed;
                object cv_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cu_);
                bool cw_ = cv_ is CqlQuantity;
                if (cw_)
                {
                    DataType cx_ = tuple_fnrkedfurymcjidjkbtaenork?.AnesthesiaProcedure?.Performed;
                    object cy_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cx_);
                    ai_ = cy_ as CqlQuantity;
                }
                else
                {
                    DataType cz_ = tuple_fnrkedfurymcjidjkbtaenork?.AnesthesiaProcedure?.Performed;
                    object da_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cz_);
                    bool db_ = da_ is CqlInterval<CqlDateTime>;
                    if (db_)
                    {
                        DataType dc_ = tuple_fnrkedfurymcjidjkbtaenork?.AnesthesiaProcedure?.Performed;
                        object dd_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dc_);
                        ai_ = dd_ as CqlInterval<CqlDateTime>;
                    }
                    else
                    {
                        DataType de_ = tuple_fnrkedfurymcjidjkbtaenork?.AnesthesiaProcedure?.Performed;
                        object df_ = FHIRHelpers_4_4_000.Instance.ToValue(context, de_);
                        bool dg_ = df_ is CqlInterval<CqlQuantity>;
                        if (dg_)
                        {
                            DataType dh_ = tuple_fnrkedfurymcjidjkbtaenork?.AnesthesiaProcedure?.Performed;
                            object di_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dh_);
                            ai_ = di_ as CqlInterval<CqlQuantity>;
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
            DataType dj_ = tuple_fnrkedfurymcjidjkbtaenork?.AnesthesiaProcedure?.Performed;
            object dk_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dj_);
            bool dl_ = dk_ is CqlDateTime;
            if (dl_)
            {
                DataType dm_ = tuple_fnrkedfurymcjidjkbtaenork?.AnesthesiaProcedure?.Performed;
                object dn_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dm_);
                ao_ = dn_ as CqlDateTime;
            }
            else
            {
                DataType do_ = tuple_fnrkedfurymcjidjkbtaenork?.AnesthesiaProcedure?.Performed;
                object dp_ = FHIRHelpers_4_4_000.Instance.ToValue(context, do_);
                bool dq_ = dp_ is CqlQuantity;
                if (dq_)
                {
                    DataType dr_ = tuple_fnrkedfurymcjidjkbtaenork?.AnesthesiaProcedure?.Performed;
                    object ds_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dr_);
                    ao_ = ds_ as CqlQuantity;
                }
                else
                {
                    DataType dt_ = tuple_fnrkedfurymcjidjkbtaenork?.AnesthesiaProcedure?.Performed;
                    object du_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dt_);
                    bool dv_ = du_ is CqlInterval<CqlDateTime>;
                    if (dv_)
                    {
                        DataType dw_ = tuple_fnrkedfurymcjidjkbtaenork?.AnesthesiaProcedure?.Performed;
                        object dx_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dw_);
                        ao_ = dx_ as CqlInterval<CqlDateTime>;
                    }
                    else
                    {
                        DataType dy_ = tuple_fnrkedfurymcjidjkbtaenork?.AnesthesiaProcedure?.Performed;
                        object dz_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dy_);
                        bool ea_ = dz_ is CqlInterval<CqlQuantity>;
                        if (ea_)
                        {
                            DataType eb_ = tuple_fnrkedfurymcjidjkbtaenork?.AnesthesiaProcedure?.Performed;
                            object ec_ = FHIRHelpers_4_4_000.Instance.ToValue(context, eb_);
                            ao_ = ec_ as CqlInterval<CqlQuantity>;
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
            bool? as_ = ar_?.lowClosed;
            object at_;
            DataType ed_ = tuple_fnrkedfurymcjidjkbtaenork?.AnesthesiaProcedure?.Performed;
            object ee_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ed_);
            bool ef_ = ee_ is CqlDateTime;
            if (ef_)
            {
                DataType eg_ = tuple_fnrkedfurymcjidjkbtaenork?.AnesthesiaProcedure?.Performed;
                object eh_ = FHIRHelpers_4_4_000.Instance.ToValue(context, eg_);
                at_ = eh_ as CqlDateTime;
            }
            else
            {
                DataType ei_ = tuple_fnrkedfurymcjidjkbtaenork?.AnesthesiaProcedure?.Performed;
                object ej_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ei_);
                bool ek_ = ej_ is CqlQuantity;
                if (ek_)
                {
                    DataType el_ = tuple_fnrkedfurymcjidjkbtaenork?.AnesthesiaProcedure?.Performed;
                    object em_ = FHIRHelpers_4_4_000.Instance.ToValue(context, el_);
                    at_ = em_ as CqlQuantity;
                }
                else
                {
                    DataType en_ = tuple_fnrkedfurymcjidjkbtaenork?.AnesthesiaProcedure?.Performed;
                    object eo_ = FHIRHelpers_4_4_000.Instance.ToValue(context, en_);
                    bool ep_ = eo_ is CqlInterval<CqlDateTime>;
                    if (ep_)
                    {
                        DataType eq_ = tuple_fnrkedfurymcjidjkbtaenork?.AnesthesiaProcedure?.Performed;
                        object er_ = FHIRHelpers_4_4_000.Instance.ToValue(context, eq_);
                        at_ = er_ as CqlInterval<CqlDateTime>;
                    }
                    else
                    {
                        DataType es_ = tuple_fnrkedfurymcjidjkbtaenork?.AnesthesiaProcedure?.Performed;
                        object et_ = FHIRHelpers_4_4_000.Instance.ToValue(context, es_);
                        bool eu_ = et_ is CqlInterval<CqlQuantity>;
                        if (eu_)
                        {
                            DataType ev_ = tuple_fnrkedfurymcjidjkbtaenork?.AnesthesiaProcedure?.Performed;
                            object ew_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ev_);
                            at_ = ew_ as CqlInterval<CqlQuantity>;
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
            bool? ax_ = aw_?.highClosed;
            CqlInterval<CqlDateTime> ay_ = context.Operators.Interval(ah_, an_, as_, ax_);
            bool? az_ = context.Operators.In<CqlDateTime>(ab_, ay_, "day");
            bool? ba_ = context.Operators.And(aa_, az_);
            return ba_;
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
            bool? l_ = context.Operators.ConceptsInValueSet(j_, k_);
            return l_;
        }

        object c_((CqlTupleMetadata, string id, IEnumerable<CqlConcept> medicationStatusReason, CqlDateTime authoredOn)? tuple_eodcxckcyhgehinqchjlrjuqw) => tuple_eodcxckcyhgehinqchjlrjuqw;
        IEnumerable<object> d_ = context.Operators.WhereSelect<(CqlTupleMetadata, string id, IEnumerable<CqlConcept> medicationStatusReason, CqlDateTime authoredOn)?, object>(a_, b_, c_);
        IEnumerable<(CqlTupleMetadata, string id, CqlConcept requestStatusReason, CqlDateTime authoredOn)?> e_ = this.No_Mechanical_VTE_Prophylaxis_Performed_Or_Ordered(context);

        bool? f_((CqlTupleMetadata, string id, CqlConcept requestStatusReason, CqlDateTime authoredOn)? NoVTEDevice) {
            CqlConcept m_ = NoVTEDevice?.requestStatusReason;
            CqlValueSet n_ = this.Patient_Refusal(context);
            bool? o_ = context.Operators.ConceptInValueSet(m_, n_);
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
                bool? m_ = h_?.lowClosed;
                bool? n_ = h_?.highClosed;
                CqlInterval<CqlDateTime> o_ = context.Operators.Interval(j_, l_, m_, n_);
                bool? p_ = context.Operators.In<CqlDateTime>(g_, o_, "day");
                return p_;
            }

            bool? f_ = context.Operators.WhereAny<object>(d_, e_);
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
            bool? o_ = context.Operators.Equal(n_, "completed");
            object p_;
            DataType ax_ = tuple_bvgardhyjgbgfxidntuflexa?.AnesthesiaProcedure?.Performed;
            object ay_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ax_);
            bool az_ = ay_ is CqlDateTime;
            if (az_)
            {
                DataType ba_ = tuple_bvgardhyjgbgfxidntuflexa?.AnesthesiaProcedure?.Performed;
                object bb_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ba_);
                p_ = bb_ as CqlDateTime;
            }
            else
            {
                DataType bc_ = tuple_bvgardhyjgbgfxidntuflexa?.AnesthesiaProcedure?.Performed;
                object bd_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bc_);
                bool be_ = bd_ is CqlQuantity;
                if (be_)
                {
                    DataType bf_ = tuple_bvgardhyjgbgfxidntuflexa?.AnesthesiaProcedure?.Performed;
                    object bg_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bf_);
                    p_ = bg_ as CqlQuantity;
                }
                else
                {
                    DataType bh_ = tuple_bvgardhyjgbgfxidntuflexa?.AnesthesiaProcedure?.Performed;
                    object bi_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bh_);
                    bool bj_ = bi_ is CqlInterval<CqlDateTime>;
                    if (bj_)
                    {
                        DataType bk_ = tuple_bvgardhyjgbgfxidntuflexa?.AnesthesiaProcedure?.Performed;
                        object bl_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bk_);
                        p_ = bl_ as CqlInterval<CqlDateTime>;
                    }
                    else
                    {
                        DataType bm_ = tuple_bvgardhyjgbgfxidntuflexa?.AnesthesiaProcedure?.Performed;
                        object bn_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bm_);
                        bool bo_ = bn_ is CqlInterval<CqlQuantity>;
                        if (bo_)
                        {
                            DataType bp_ = tuple_bvgardhyjgbgfxidntuflexa?.AnesthesiaProcedure?.Performed;
                            object bq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bp_);
                            p_ = bq_ as CqlInterval<CqlQuantity>;
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
            bool? v_ = context.Operators.SameAs(r_, u_, "day");
            bool? w_ = context.Operators.And(o_, v_);
            CqlDateTime x_ = context.Operators.LateBoundProperty<CqlDateTime>(tuple_bvgardhyjgbgfxidntuflexa?.PatientRefusal, "authoredOn");
            object y_;
            DataType br_ = tuple_bvgardhyjgbgfxidntuflexa?.AnesthesiaProcedure?.Performed;
            object bs_ = FHIRHelpers_4_4_000.Instance.ToValue(context, br_);
            bool bt_ = bs_ is CqlDateTime;
            if (bt_)
            {
                DataType bu_ = tuple_bvgardhyjgbgfxidntuflexa?.AnesthesiaProcedure?.Performed;
                object bv_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bu_);
                y_ = bv_ as CqlDateTime;
            }
            else
            {
                DataType bw_ = tuple_bvgardhyjgbgfxidntuflexa?.AnesthesiaProcedure?.Performed;
                object bx_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bw_);
                bool by_ = bx_ is CqlQuantity;
                if (by_)
                {
                    DataType bz_ = tuple_bvgardhyjgbgfxidntuflexa?.AnesthesiaProcedure?.Performed;
                    object ca_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bz_);
                    y_ = ca_ as CqlQuantity;
                }
                else
                {
                    DataType cb_ = tuple_bvgardhyjgbgfxidntuflexa?.AnesthesiaProcedure?.Performed;
                    object cc_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cb_);
                    bool cd_ = cc_ is CqlInterval<CqlDateTime>;
                    if (cd_)
                    {
                        DataType ce_ = tuple_bvgardhyjgbgfxidntuflexa?.AnesthesiaProcedure?.Performed;
                        object cf_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ce_);
                        y_ = cf_ as CqlInterval<CqlDateTime>;
                    }
                    else
                    {
                        DataType cg_ = tuple_bvgardhyjgbgfxidntuflexa?.AnesthesiaProcedure?.Performed;
                        object ch_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cg_);
                        bool ci_ = ch_ is CqlInterval<CqlQuantity>;
                        if (ci_)
                        {
                            DataType cj_ = tuple_bvgardhyjgbgfxidntuflexa?.AnesthesiaProcedure?.Performed;
                            object ck_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cj_);
                            y_ = ck_ as CqlInterval<CqlQuantity>;
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
            DataType cl_ = tuple_bvgardhyjgbgfxidntuflexa?.AnesthesiaProcedure?.Performed;
            object cm_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cl_);
            bool cn_ = cm_ is CqlDateTime;
            if (cn_)
            {
                DataType co_ = tuple_bvgardhyjgbgfxidntuflexa?.AnesthesiaProcedure?.Performed;
                object cp_ = FHIRHelpers_4_4_000.Instance.ToValue(context, co_);
                ae_ = cp_ as CqlDateTime;
            }
            else
            {
                DataType cq_ = tuple_bvgardhyjgbgfxidntuflexa?.AnesthesiaProcedure?.Performed;
                object cr_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cq_);
                bool cs_ = cr_ is CqlQuantity;
                if (cs_)
                {
                    DataType ct_ = tuple_bvgardhyjgbgfxidntuflexa?.AnesthesiaProcedure?.Performed;
                    object cu_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ct_);
                    ae_ = cu_ as CqlQuantity;
                }
                else
                {
                    DataType cv_ = tuple_bvgardhyjgbgfxidntuflexa?.AnesthesiaProcedure?.Performed;
                    object cw_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cv_);
                    bool cx_ = cw_ is CqlInterval<CqlDateTime>;
                    if (cx_)
                    {
                        DataType cy_ = tuple_bvgardhyjgbgfxidntuflexa?.AnesthesiaProcedure?.Performed;
                        object cz_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cy_);
                        ae_ = cz_ as CqlInterval<CqlDateTime>;
                    }
                    else
                    {
                        DataType da_ = tuple_bvgardhyjgbgfxidntuflexa?.AnesthesiaProcedure?.Performed;
                        object db_ = FHIRHelpers_4_4_000.Instance.ToValue(context, da_);
                        bool dc_ = db_ is CqlInterval<CqlQuantity>;
                        if (dc_)
                        {
                            DataType dd_ = tuple_bvgardhyjgbgfxidntuflexa?.AnesthesiaProcedure?.Performed;
                            object de_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dd_);
                            ae_ = de_ as CqlInterval<CqlQuantity>;
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
            DataType df_ = tuple_bvgardhyjgbgfxidntuflexa?.AnesthesiaProcedure?.Performed;
            object dg_ = FHIRHelpers_4_4_000.Instance.ToValue(context, df_);
            bool dh_ = dg_ is CqlDateTime;
            if (dh_)
            {
                DataType di_ = tuple_bvgardhyjgbgfxidntuflexa?.AnesthesiaProcedure?.Performed;
                object dj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, di_);
                ak_ = dj_ as CqlDateTime;
            }
            else
            {
                DataType dk_ = tuple_bvgardhyjgbgfxidntuflexa?.AnesthesiaProcedure?.Performed;
                object dl_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dk_);
                bool dm_ = dl_ is CqlQuantity;
                if (dm_)
                {
                    DataType dn_ = tuple_bvgardhyjgbgfxidntuflexa?.AnesthesiaProcedure?.Performed;
                    object do_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dn_);
                    ak_ = do_ as CqlQuantity;
                }
                else
                {
                    DataType dp_ = tuple_bvgardhyjgbgfxidntuflexa?.AnesthesiaProcedure?.Performed;
                    object dq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dp_);
                    bool dr_ = dq_ is CqlInterval<CqlDateTime>;
                    if (dr_)
                    {
                        DataType ds_ = tuple_bvgardhyjgbgfxidntuflexa?.AnesthesiaProcedure?.Performed;
                        object dt_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ds_);
                        ak_ = dt_ as CqlInterval<CqlDateTime>;
                    }
                    else
                    {
                        DataType du_ = tuple_bvgardhyjgbgfxidntuflexa?.AnesthesiaProcedure?.Performed;
                        object dv_ = FHIRHelpers_4_4_000.Instance.ToValue(context, du_);
                        bool dw_ = dv_ is CqlInterval<CqlQuantity>;
                        if (dw_)
                        {
                            DataType dx_ = tuple_bvgardhyjgbgfxidntuflexa?.AnesthesiaProcedure?.Performed;
                            object dy_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dx_);
                            ak_ = dy_ as CqlInterval<CqlQuantity>;
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
            bool? ao_ = an_?.lowClosed;
            object ap_;
            DataType dz_ = tuple_bvgardhyjgbgfxidntuflexa?.AnesthesiaProcedure?.Performed;
            object ea_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dz_);
            bool eb_ = ea_ is CqlDateTime;
            if (eb_)
            {
                DataType ec_ = tuple_bvgardhyjgbgfxidntuflexa?.AnesthesiaProcedure?.Performed;
                object ed_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ec_);
                ap_ = ed_ as CqlDateTime;
            }
            else
            {
                DataType ee_ = tuple_bvgardhyjgbgfxidntuflexa?.AnesthesiaProcedure?.Performed;
                object ef_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ee_);
                bool eg_ = ef_ is CqlQuantity;
                if (eg_)
                {
                    DataType eh_ = tuple_bvgardhyjgbgfxidntuflexa?.AnesthesiaProcedure?.Performed;
                    object ei_ = FHIRHelpers_4_4_000.Instance.ToValue(context, eh_);
                    ap_ = ei_ as CqlQuantity;
                }
                else
                {
                    DataType ej_ = tuple_bvgardhyjgbgfxidntuflexa?.AnesthesiaProcedure?.Performed;
                    object ek_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ej_);
                    bool el_ = ek_ is CqlInterval<CqlDateTime>;
                    if (el_)
                    {
                        DataType em_ = tuple_bvgardhyjgbgfxidntuflexa?.AnesthesiaProcedure?.Performed;
                        object en_ = FHIRHelpers_4_4_000.Instance.ToValue(context, em_);
                        ap_ = en_ as CqlInterval<CqlDateTime>;
                    }
                    else
                    {
                        DataType eo_ = tuple_bvgardhyjgbgfxidntuflexa?.AnesthesiaProcedure?.Performed;
                        object ep_ = FHIRHelpers_4_4_000.Instance.ToValue(context, eo_);
                        bool eq_ = ep_ is CqlInterval<CqlQuantity>;
                        if (eq_)
                        {
                            DataType er_ = tuple_bvgardhyjgbgfxidntuflexa?.AnesthesiaProcedure?.Performed;
                            object es_ = FHIRHelpers_4_4_000.Instance.ToValue(context, er_);
                            ap_ = es_ as CqlInterval<CqlQuantity>;
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
            bool? at_ = as_?.highClosed;
            CqlInterval<CqlDateTime> au_ = context.Operators.Interval(ad_, aj_, ao_, at_);
            bool? av_ = context.Operators.In<CqlDateTime>(x_, au_, "day");
            bool? aw_ = context.Operators.And(w_, av_);
            return aw_;
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
            bool? h_ = context.Operators.Less(g_, 1);
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

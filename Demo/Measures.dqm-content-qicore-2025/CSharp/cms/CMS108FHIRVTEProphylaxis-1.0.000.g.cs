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

[System.CodeDom.Compiler.GeneratedCode(".NET Code Generation", "5.1.2.0")]
[CqlLibrary("CMS108FHIRVTEProphylaxis", "1.0.000")]
public partial class CMS108FHIRVTEProphylaxis_1_0_000 : ILibrary, ISingleton<CMS108FHIRVTEProphylaxis_1_0_000>
{
    #region ValueSets (36)

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

    [CqlValueSetDefinition("Hemorrhagic Stroke", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.212", valueSetVersion: null)]
    public CqlValueSet Hemorrhagic_Stroke(CqlContext _) => _Hemorrhagic_Stroke;
    private static readonly CqlValueSet _Hemorrhagic_Stroke = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.212", null);

    [CqlValueSetDefinition("Ischemic Stroke", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.247", valueSetVersion: null)]
    public CqlValueSet Ischemic_Stroke(CqlContext _) => _Ischemic_Stroke;
    private static readonly CqlValueSet _Ischemic_Stroke = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.247", null);

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

    [CqlValueSetDefinition("Mental Health Diagnoses", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.105.12.1004", valueSetVersion: null)]
    public CqlValueSet Mental_Health_Diagnoses(CqlContext _) => _Mental_Health_Diagnoses;
    private static readonly CqlValueSet _Mental_Health_Diagnoses = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.105.12.1004", null);

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

    private const long _cacheIndex_Measurement_Period = 7070766927492640047L;

    private CqlInterval<CqlDateTime> Measurement_Period_Compute(CqlContext context)
    {
        CqlDateTime a_ = context.Operators.DateTime(2026, 1, 1, 0, 0, 0, 0, 0.0m);
        CqlDateTime b_ = context.Operators.DateTime(2027, 1, 1, 0, 0, 0, 0, 0.0m);
        CqlInterval<CqlDateTime> c_ = context.Operators.Interval(a_, b_, true, false);
        object d_ = context.ResolveParameter("CMS108FHIRVTEProphylaxis-1.0.000", "Measurement Period", c_);
        return (CqlInterval<CqlDateTime>)d_;
    }


    #endregion Parameters

    #region Functions and Expressions (37)

    [CqlExpressionDefinition("Patient")]
    public Patient Patient(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Patient, Patient_Compute);

    private const long _cacheIndex_Patient = 4264490794319927351L;

    private Patient Patient_Compute(CqlContext context)
    {
        IEnumerable<Patient> a_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-patient"));
        Patient b_ = context.Operators.SingletonFrom<Patient>(a_);
        return b_;
    }


    [CqlExpressionDefinition("SDE Ethnicity")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Ethnicity(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_SDE_Ethnicity, SDE_Ethnicity_Compute);

    private const long _cacheIndex_SDE_Ethnicity = -337742740881814516L;

    private (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Ethnicity_Compute(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? a_ = SupplementalDataElements_5_1_000.Instance.SDE_Ethnicity(context);
        return a_;
    }


    [CqlExpressionDefinition("SDE Payer")]
    public IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> SDE_Payer(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_SDE_Payer, SDE_Payer_Compute);

    private const long _cacheIndex_SDE_Payer = -3212221336950252820L;

    private IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> SDE_Payer_Compute(CqlContext context)
    {
        IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> a_ = SupplementalDataElements_5_1_000.Instance.SDE_Payer(context);
        return a_;
    }


    [CqlExpressionDefinition("SDE Race")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Race(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_SDE_Race, SDE_Race_Compute);

    private const long _cacheIndex_SDE_Race = -5184337777828667700L;

    private (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Race_Compute(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? a_ = SupplementalDataElements_5_1_000.Instance.SDE_Race(context);
        return a_;
    }


    [CqlExpressionDefinition("SDE Sex")]
    public CqlCode SDE_Sex(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_SDE_Sex, SDE_Sex_Compute);

    private const long _cacheIndex_SDE_Sex = 3190728662276422975L;

    private CqlCode SDE_Sex_Compute(CqlContext context)
    {
        CqlCode a_ = SupplementalDataElements_5_1_000.Instance.SDE_Sex(context);
        return a_;
    }


    [CqlExpressionDefinition("Initial Population")]
    public IEnumerable<Encounter> Initial_Population(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Initial_Population, Initial_Population_Compute);

    private const long _cacheIndex_Initial_Population = -1008556507936808832L;

    private IEnumerable<Encounter> Initial_Population_Compute(CqlContext context)
    {
        IEnumerable<Encounter> a_ = VTE_8_18_000.Instance.Encounter_With_Age_Range_And_Without_VTE_Diagnosis_Or_Obstetrical_Conditions(context);
        return a_;
    }


    [CqlExpressionDefinition("Denominator")]
    public IEnumerable<Encounter> Denominator(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Denominator, Denominator_Compute);

    private const long _cacheIndex_Denominator = 3513083825423842151L;

    private IEnumerable<Encounter> Denominator_Compute(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Initial_Population(context);
        return a_;
    }


    [CqlExpressionDefinition("Encounter Less Than 2 Days")]
    public IEnumerable<Encounter> Encounter_Less_Than_2_Days(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Encounter_Less_Than_2_Days, Encounter_Less_Than_2_Days_Compute);

    private const long _cacheIndex_Encounter_Less_Than_2_Days = 7099236196673702084L;

    private IEnumerable<Encounter> Encounter_Less_Than_2_Days_Compute(CqlContext context)
    {
        IEnumerable<Encounter> a_ = VTE_8_18_000.Instance.Encounter_With_Age_Range_And_Without_VTE_Diagnosis_Or_Obstetrical_Conditions(context);

        bool? b_(Encounter QualifyingEncounter) {
            Period d_ = QualifyingEncounter?.Period;
            CqlInterval<CqlDateTime> e_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, d_);
            int? f_ = CQMCommon_4_1_000.Instance.lengthInDays(context, e_);
            bool? g_ = context.Operators.Less(f_, 2);
            return g_;
        }

        IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);
        return c_;
    }


    [CqlExpressionDefinition("Encounter With ICU Location Stay 1 Day Or More")]
    public IEnumerable<Encounter> Encounter_With_ICU_Location_Stay_1_Day_Or_More(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Encounter_With_ICU_Location_Stay_1_Day_Or_More, Encounter_With_ICU_Location_Stay_1_Day_Or_More_Compute);

    private const long _cacheIndex_Encounter_With_ICU_Location_Stay_1_Day_Or_More = 7251097217384440570L;

    private IEnumerable<Encounter> Encounter_With_ICU_Location_Stay_1_Day_Or_More_Compute(CqlContext context)
    {
        IEnumerable<Encounter> a_ = VTE_8_18_000.Instance.Encounter_With_Age_Range_And_Without_VTE_Diagnosis_Or_Obstetrical_Conditions(context);

        bool? b_(Encounter QualifyingEncounter) {
            List<Encounter.LocationComponent> d_ = QualifyingEncounter?.Location;

            bool? e_(Encounter.LocationComponent Location) {
                ResourceReference h_ = Location?.Location;
                Location i_ = CQMCommon_4_1_000.Instance.getLocation(context, h_);
                List<CodeableConcept> j_ = i_?.Type;

                CqlConcept k_(CodeableConcept @this) {
                    CqlConcept al_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);
                    return al_;
                }

                IEnumerable<CqlConcept> l_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)j_, k_);
                CqlValueSet m_ = this.Intensive_Care_Unit(context);
                bool? n_ = context.Operators.ConceptsInValueSet(l_, m_);
                Period o_ = Location?.Period;
                CqlInterval<CqlDateTime> p_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, o_);
                int? q_ = CQMCommon_4_1_000.Instance.lengthInDays(context, p_);
                bool? r_ = context.Operators.GreaterOrEqual(q_, 1);
                bool? s_ = context.Operators.And(n_, r_);
                CqlInterval<CqlDateTime> u_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, o_);
                CqlDateTime v_ = context.Operators.Start(u_);
                Period w_ = QualifyingEncounter?.Period;
                CqlInterval<CqlDateTime> x_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, w_);
                CqlDateTime y_ = context.Operators.Start(x_);
                bool? z_ = context.Operators.SameOrAfter(v_, y_, (string)default);
                bool? aa_ = context.Operators.And(s_, z_);
                CqlInterval<CqlDateTime> ac_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, o_);
                CqlDateTime ad_ = context.Operators.Start(ac_);
                CqlDate ae_ = context.Operators.DateFrom(ad_);
                CqlInterval<CqlDateTime> ag_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, w_);
                CqlDateTime ah_ = context.Operators.Start(ag_);
                CqlInterval<CqlDate> ai_ = TJCOverall_8_25_000.Instance.calendarDayOfOrDayAfter(context, ah_);
                bool? aj_ = context.Operators.In<CqlDate>(ae_, ai_, (string)default);
                bool? ak_ = context.Operators.And(aa_, aj_);
                return ak_;
            }

            IEnumerable<Encounter.LocationComponent> f_ = context.Operators.Where<Encounter.LocationComponent>((IEnumerable<Encounter.LocationComponent>)d_, e_);
            bool? g_ = context.Operators.Exists<Encounter.LocationComponent>(f_);
            return g_;
        }

        IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);
        return c_;
    }


    [CqlExpressionDefinition("Encounter With Principal Diagnosis Of Mental Disorder Or Stroke")]
    public IEnumerable<Encounter> Encounter_With_Principal_Diagnosis_Of_Mental_Disorder_Or_Stroke(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Encounter_With_Principal_Diagnosis_Of_Mental_Disorder_Or_Stroke, Encounter_With_Principal_Diagnosis_Of_Mental_Disorder_Or_Stroke_Compute);

    private const long _cacheIndex_Encounter_With_Principal_Diagnosis_Of_Mental_Disorder_Or_Stroke = 196183338489527540L;

    private IEnumerable<Encounter> Encounter_With_Principal_Diagnosis_Of_Mental_Disorder_Or_Stroke_Compute(CqlContext context)
    {
        IEnumerable<Encounter> a_ = VTE_8_18_000.Instance.Encounter_With_Age_Range_And_Without_VTE_Diagnosis_Or_Obstetrical_Conditions(context);

        bool? b_(Encounter QualifyingEncounter) {
            CqlValueSet d_ = this.Mental_Health_Diagnoses(context);
            bool? e_ = CQMCommon_4_1_000.Instance.hasPrincipalDiagnosisOf(context, QualifyingEncounter, d_);
            CqlValueSet f_ = this.Hemorrhagic_Stroke(context);
            bool? g_ = CQMCommon_4_1_000.Instance.hasPrincipalDiagnosisOf(context, QualifyingEncounter, f_);
            bool? h_ = context.Operators.Or(e_, g_);
            CqlValueSet i_ = this.Ischemic_Stroke(context);
            bool? j_ = CQMCommon_4_1_000.Instance.hasPrincipalDiagnosisOf(context, QualifyingEncounter, i_);
            bool? k_ = context.Operators.Or(h_, j_);
            return k_;
        }

        IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);
        return c_;
    }


    [CqlExpressionDefinition("Encounter With Principal Procedure Of Selected Surgery")]
    public IEnumerable<Encounter> Encounter_With_Principal_Procedure_Of_Selected_Surgery(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Encounter_With_Principal_Procedure_Of_Selected_Surgery, Encounter_With_Principal_Procedure_Of_Selected_Surgery_Compute);

    private const long _cacheIndex_Encounter_With_Principal_Procedure_Of_Selected_Surgery = 754137602343374177L;

    private IEnumerable<Encounter> Encounter_With_Principal_Procedure_Of_Selected_Surgery_Compute(CqlContext context)
    {
        IEnumerable<Encounter> a_ = VTE_8_18_000.Instance.Encounter_With_Age_Range_And_Without_VTE_Diagnosis_Or_Obstetrical_Conditions(context);

        bool? b_(Encounter QualifyingEncounter) {
            CqlValueSet d_ = this.General_Surgery(context);
            bool? e_ = VTE_8_18_000.Instance.hasPrincipalProcedureOf(context, QualifyingEncounter, d_);
            CqlValueSet f_ = this.Gynecological_Surgery(context);
            bool? g_ = VTE_8_18_000.Instance.hasPrincipalProcedureOf(context, QualifyingEncounter, f_);
            bool? h_ = context.Operators.Or(e_, g_);
            CqlValueSet i_ = this.Hip_Fracture_Surgery(context);
            bool? j_ = VTE_8_18_000.Instance.hasPrincipalProcedureOf(context, QualifyingEncounter, i_);
            bool? k_ = context.Operators.Or(h_, j_);
            CqlValueSet l_ = this.Hip_Replacement_Surgery(context);
            bool? m_ = VTE_8_18_000.Instance.hasPrincipalProcedureOf(context, QualifyingEncounter, l_);
            bool? n_ = context.Operators.Or(k_, m_);
            CqlValueSet o_ = this.Intracranial_Neurosurgery(context);
            bool? p_ = VTE_8_18_000.Instance.hasPrincipalProcedureOf(context, QualifyingEncounter, o_);
            bool? q_ = context.Operators.Or(n_, p_);
            CqlValueSet r_ = this.Knee_Replacement_Surgery(context);
            bool? s_ = VTE_8_18_000.Instance.hasPrincipalProcedureOf(context, QualifyingEncounter, r_);
            bool? t_ = context.Operators.Or(q_, s_);
            CqlValueSet u_ = this.Urological_Surgery(context);
            bool? v_ = VTE_8_18_000.Instance.hasPrincipalProcedureOf(context, QualifyingEncounter, u_);
            bool? w_ = context.Operators.Or(t_, v_);
            return w_;
        }

        IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);
        return c_;
    }


    [CqlExpressionDefinition("Intervention Comfort Measures")]
    public IEnumerable<object> Intervention_Comfort_Measures(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Intervention_Comfort_Measures, Intervention_Comfort_Measures_Compute);

    private const long _cacheIndex_Intervention_Comfort_Measures = -2923150894793032190L;

    private IEnumerable<object> Intervention_Comfort_Measures_Compute(CqlContext context)
    {
        CqlValueSet a_ = this.Comfort_Measures(context);
        IEnumerable<ServiceRequest> b_ = context.Operators.Retrieve<ServiceRequest>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-servicerequest"));

        bool? c_(ServiceRequest InterventionRequest) {
            Code<RequestIntent> j_ = InterventionRequest?.IntentElement;
            RequestIntent? k_ = j_?.Value;
            Code<RequestIntent> l_ = context.Operators.Convert<Code<RequestIntent>>(k_);
            string m_ = context.Operators.Convert<string>(l_);
            string[] n_ = [
                "order",
                "original-order",
                "reflex-order",
                "filler-order",
                "instance-order",
            ];
            bool? o_ = context.Operators.In<string>(m_, (IEnumerable<string>)n_);
            Code<RequestStatus> p_ = InterventionRequest?.StatusElement;
            RequestStatus? q_ = p_?.Value;
            Code<RequestStatus> r_ = context.Operators.Convert<Code<RequestStatus>>(q_);
            string s_ = context.Operators.Convert<string>(r_);
            string[] t_ = [
                "active",
                "completed",
            ];
            bool? u_ = context.Operators.In<string>(s_, (IEnumerable<string>)t_);
            bool? v_ = context.Operators.And(o_, u_);
            return v_;
        }

        IEnumerable<ServiceRequest> d_ = context.Operators.Where<ServiceRequest>(b_, c_);
        IEnumerable<Procedure> f_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));

        bool? g_(Procedure InterventionPerformed) {
            Code<EventStatus> w_ = InterventionPerformed?.StatusElement;
            EventStatus? x_ = w_?.Value;
            string y_ = context.Operators.Convert<string>(x_);
            string[] z_ = [
                "completed",
                "in-progress",
            ];
            bool? aa_ = context.Operators.In<string>(y_, (IEnumerable<string>)z_);
            return aa_;
        }

        IEnumerable<Procedure> h_ = context.Operators.Where<Procedure>(f_, g_);
        IEnumerable<object> i_ = context.Operators.Union<object>(d_ as IEnumerable<object>, h_ as IEnumerable<object>);
        return i_;
    }


    [CqlFunctionDefinition("fromDayOfStartOfHospitalizationToDayAfterAdmission")]
    public CqlInterval<CqlDate> fromDayOfStartOfHospitalizationToDayAfterAdmission(CqlContext context, Encounter Encounter)
    {
        CqlInterval<CqlDateTime> a_ = CQMCommon_4_1_000.Instance.hospitalizationWithObservation(context, Encounter);
        CqlDateTime b_ = context.Operators.Start(a_);
        CqlDate c_ = context.Operators.DateFrom(b_);
        Period d_ = Encounter?.Period;
        CqlInterval<CqlDateTime> e_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, d_);
        CqlDateTime f_ = context.Operators.Start(e_);
        CqlDate g_ = context.Operators.DateFrom(f_);
        CqlQuantity h_ = context.Operators.Quantity(1m, "days");
        CqlDate i_ = context.Operators.Add(g_, h_);
        CqlInterval<CqlDate> j_ = context.Operators.Interval(c_, i_, true, true);
        return j_;
    }


    [CqlExpressionDefinition("Encounter With Intervention Comfort Measures From Day Of Start Of Hospitalization To Day After Admission")]
    public IEnumerable<Encounter> Encounter_With_Intervention_Comfort_Measures_From_Day_Of_Start_Of_Hospitalization_To_Day_After_Admission(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Encounter_With_Intervention_Comfort_Measures_From_Day_Of_Start_Of_Hospitalization_To_Day_After_Admission, Encounter_With_Intervention_Comfort_Measures_From_Day_Of_Start_Of_Hospitalization_To_Day_After_Admission_Compute);

    private const long _cacheIndex_Encounter_With_Intervention_Comfort_Measures_From_Day_Of_Start_Of_Hospitalization_To_Day_After_Admission = 3074250299650757214L;

    private IEnumerable<Encounter> Encounter_With_Intervention_Comfort_Measures_From_Day_Of_Start_Of_Hospitalization_To_Day_After_Admission_Compute(CqlContext context)
    {
        IEnumerable<Encounter> a_ = VTE_8_18_000.Instance.Encounter_With_Age_Range_And_Without_VTE_Diagnosis_Or_Obstetrical_Conditions(context);

        bool? b_(Encounter QualifyingEncounter) {
            IEnumerable<object> d_ = this.Intervention_Comfort_Measures(context);

            bool? e_(object ComfortMeasure) {

                object h_() {

                    bool y_() {
                        object ac_ = context.Operators.LateBoundProperty<object>(ComfortMeasure, "performed");
                        object ad_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ac_);
                        bool ae_ = ad_ is CqlDateTime;
                        return ae_;
                    }


                    bool z_() {
                        object af_ = context.Operators.LateBoundProperty<object>(ComfortMeasure, "performed");
                        object ag_ = FHIRHelpers_4_4_000.Instance.ToValue(context, af_);
                        bool ah_ = ag_ is CqlInterval<CqlDateTime>;
                        return ah_;
                    }


                    bool aa_() {
                        object ai_ = context.Operators.LateBoundProperty<object>(ComfortMeasure, "performed");
                        object aj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ai_);
                        bool ak_ = aj_ is CqlQuantity;
                        return ak_;
                    }


                    bool ab_() {
                        object al_ = context.Operators.LateBoundProperty<object>(ComfortMeasure, "performed");
                        object am_ = FHIRHelpers_4_4_000.Instance.ToValue(context, al_);
                        bool an_ = am_ is CqlInterval<CqlQuantity>;
                        return an_;
                    }

                    if (y_())
                    {
                        object ao_ = context.Operators.LateBoundProperty<object>(ComfortMeasure, "performed");
                        object ap_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ao_);
                        return (ap_ as CqlDateTime) as object;
                    }
                    else if (z_())
                    {
                        object aq_ = context.Operators.LateBoundProperty<object>(ComfortMeasure, "performed");
                        object ar_ = FHIRHelpers_4_4_000.Instance.ToValue(context, aq_);
                        return (ar_ as CqlInterval<CqlDateTime>) as object;
                    }
                    else if (aa_())
                    {
                        object as_ = context.Operators.LateBoundProperty<object>(ComfortMeasure, "performed");
                        object at_ = FHIRHelpers_4_4_000.Instance.ToValue(context, as_);
                        return (at_ as CqlQuantity) as object;
                    }
                    else if (ab_())
                    {
                        object au_ = context.Operators.LateBoundProperty<object>(ComfortMeasure, "performed");
                        object av_ = FHIRHelpers_4_4_000.Instance.ToValue(context, au_);
                        return (av_ as CqlInterval<CqlQuantity>) as object;
                    }
                    else
                    {
                        return null;
                    };
                }

                CqlInterval<CqlDateTime> i_ = QICoreCommon_4_0_000.Instance.toInterval(context, h_());
                CqlDateTime j_ = context.Operators.Start(i_);
                object k_ = context.Operators.LateBoundProperty<object>(ComfortMeasure, "authoredOn");
                CqlDateTime l_ = context.Operators.LateBoundProperty<CqlDateTime>(k_, "value");
                CqlInterval<CqlDate> m_ = this.fromDayOfStartOfHospitalizationToDayAfterAdmission(context, QualifyingEncounter);
                CqlDate n_ = m_?.low;
                CqlDateTime o_ = context.Operators.ConvertDateToDateTime(n_);
                CqlDate q_ = m_?.high;
                CqlDateTime r_ = context.Operators.ConvertDateToDateTime(q_);
                bool? t_ = m_?.lowClosed;
                bool? v_ = m_?.highClosed;
                CqlInterval<CqlDateTime> w_ = context.Operators.Interval(o_, r_, t_, v_);
                bool? x_ = context.Operators.In<CqlDateTime>(j_ ?? l_, w_, "day");
                return x_;
            }

            IEnumerable<object> f_ = context.Operators.Where<object>(d_, e_);
            bool? g_ = context.Operators.Exists<object>(f_);
            return g_;
        }

        IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);
        return c_;
    }


    [CqlExpressionDefinition("Encounter With Intervention Comfort Measures On Day Of Or Day After Procedure")]
    public IEnumerable<Encounter> Encounter_With_Intervention_Comfort_Measures_On_Day_Of_Or_Day_After_Procedure(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Encounter_With_Intervention_Comfort_Measures_On_Day_Of_Or_Day_After_Procedure, Encounter_With_Intervention_Comfort_Measures_On_Day_Of_Or_Day_After_Procedure_Compute);

    private const long _cacheIndex_Encounter_With_Intervention_Comfort_Measures_On_Day_Of_Or_Day_After_Procedure = 3668449953604409540L;

    private IEnumerable<Encounter> Encounter_With_Intervention_Comfort_Measures_On_Day_Of_Or_Day_After_Procedure_Compute(CqlContext context)
    {
        IEnumerable<Encounter> a_ = VTE_8_18_000.Instance.Encounter_With_Age_Range_And_Without_VTE_Diagnosis_Or_Obstetrical_Conditions(context);
        CqlValueSet b_ = this.General_or_Neuraxial_Anesthesia(context);
        IEnumerable<Procedure> c_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, b_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
        IEnumerable<object> d_ = this.Intervention_Comfort_Measures(context);
        IEnumerable<ValueTuple<Encounter, Procedure, object>> e_ = context.Operators.CrossJoin<Encounter, Procedure, object>(a_, c_, d_);

        (CqlTupleMetadata, Encounter QualifyingEncounter, Procedure AnesthesiaProcedure, object ComfortMeasure)? f_(ValueTuple<Encounter, Procedure, object> _valueTuple) {
            (CqlTupleMetadata, Encounter QualifyingEncounter, Procedure AnesthesiaProcedure, object ComfortMeasure)? m_ = (CqlTupleMetadata_BgZKHMDEKXWfPTIRTZCcXPUFU, _valueTuple.Item1, _valueTuple.Item2, _valueTuple.Item3);
            return m_;
        }

        IEnumerable<(CqlTupleMetadata, Encounter QualifyingEncounter, Procedure AnesthesiaProcedure, object ComfortMeasure)?> g_ = context.Operators.Select<ValueTuple<Encounter, Procedure, object>, (CqlTupleMetadata, Encounter QualifyingEncounter, Procedure AnesthesiaProcedure, object ComfortMeasure)?>(e_, f_);

        bool? h_((CqlTupleMetadata, Encounter QualifyingEncounter, Procedure AnesthesiaProcedure, object ComfortMeasure)? tuple_hbjscqgbuhismoaytymvucjfi) {
            Code<EventStatus> n_ = tuple_hbjscqgbuhismoaytymvucjfi?.AnesthesiaProcedure?.StatusElement;
            EventStatus? o_ = n_?.Value;
            string p_ = context.Operators.Convert<string>(o_);
            bool? q_ = context.Operators.Equal(p_, "completed");

            object r_() {

                bool bf_() {
                    DataType bj_ = tuple_hbjscqgbuhismoaytymvucjfi?.AnesthesiaProcedure?.Performed;
                    object bk_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bj_);
                    bool bl_ = bk_ is CqlDateTime;
                    return bl_;
                }


                bool bg_() {
                    DataType bm_ = tuple_hbjscqgbuhismoaytymvucjfi?.AnesthesiaProcedure?.Performed;
                    object bn_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bm_);
                    bool bo_ = bn_ is CqlInterval<CqlDateTime>;
                    return bo_;
                }


                bool bh_() {
                    DataType bp_ = tuple_hbjscqgbuhismoaytymvucjfi?.AnesthesiaProcedure?.Performed;
                    object bq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bp_);
                    bool br_ = bq_ is CqlQuantity;
                    return br_;
                }


                bool bi_() {
                    DataType bs_ = tuple_hbjscqgbuhismoaytymvucjfi?.AnesthesiaProcedure?.Performed;
                    object bt_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bs_);
                    bool bu_ = bt_ is CqlInterval<CqlQuantity>;
                    return bu_;
                }

                if (bf_())
                {
                    DataType bv_ = tuple_hbjscqgbuhismoaytymvucjfi?.AnesthesiaProcedure?.Performed;
                    object bw_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bv_);
                    return (bw_ as CqlDateTime) as object;
                }
                else if (bg_())
                {
                    DataType bx_ = tuple_hbjscqgbuhismoaytymvucjfi?.AnesthesiaProcedure?.Performed;
                    object by_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bx_);
                    return (by_ as CqlInterval<CqlDateTime>) as object;
                }
                else if (bh_())
                {
                    DataType bz_ = tuple_hbjscqgbuhismoaytymvucjfi?.AnesthesiaProcedure?.Performed;
                    object ca_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bz_);
                    return (ca_ as CqlQuantity) as object;
                }
                else if (bi_())
                {
                    DataType cb_ = tuple_hbjscqgbuhismoaytymvucjfi?.AnesthesiaProcedure?.Performed;
                    object cc_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cb_);
                    return (cc_ as CqlInterval<CqlQuantity>) as object;
                }
                else
                {
                    return null;
                };
            }

            CqlInterval<CqlDateTime> s_ = QICoreCommon_4_0_000.Instance.toInterval(context, r_());
            CqlDateTime t_ = context.Operators.End(s_);
            Period u_ = tuple_hbjscqgbuhismoaytymvucjfi?.QualifyingEncounter?.Period;
            CqlInterval<CqlDateTime> v_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, u_);
            CqlDateTime w_ = context.Operators.Start(v_);
            CqlQuantity x_ = context.Operators.Quantity(1m, "day");
            CqlDateTime y_ = context.Operators.Add(w_, x_);
            bool? z_ = context.Operators.SameAs(t_, y_, "day");
            bool? aa_ = context.Operators.And(q_, z_);

            object ab_() {

                bool cd_() {
                    object ch_ = context.Operators.LateBoundProperty<object>(tuple_hbjscqgbuhismoaytymvucjfi?.ComfortMeasure, "performed");
                    object ci_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ch_);
                    bool cj_ = ci_ is CqlDateTime;
                    return cj_;
                }


                bool ce_() {
                    object ck_ = context.Operators.LateBoundProperty<object>(tuple_hbjscqgbuhismoaytymvucjfi?.ComfortMeasure, "performed");
                    object cl_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ck_);
                    bool cm_ = cl_ is CqlInterval<CqlDateTime>;
                    return cm_;
                }


                bool cf_() {
                    object cn_ = context.Operators.LateBoundProperty<object>(tuple_hbjscqgbuhismoaytymvucjfi?.ComfortMeasure, "performed");
                    object co_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cn_);
                    bool cp_ = co_ is CqlQuantity;
                    return cp_;
                }


                bool cg_() {
                    object cq_ = context.Operators.LateBoundProperty<object>(tuple_hbjscqgbuhismoaytymvucjfi?.ComfortMeasure, "performed");
                    object cr_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cq_);
                    bool cs_ = cr_ is CqlInterval<CqlQuantity>;
                    return cs_;
                }

                if (cd_())
                {
                    object ct_ = context.Operators.LateBoundProperty<object>(tuple_hbjscqgbuhismoaytymvucjfi?.ComfortMeasure, "performed");
                    object cu_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ct_);
                    return (cu_ as CqlDateTime) as object;
                }
                else if (ce_())
                {
                    object cv_ = context.Operators.LateBoundProperty<object>(tuple_hbjscqgbuhismoaytymvucjfi?.ComfortMeasure, "performed");
                    object cw_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cv_);
                    return (cw_ as CqlInterval<CqlDateTime>) as object;
                }
                else if (cf_())
                {
                    object cx_ = context.Operators.LateBoundProperty<object>(tuple_hbjscqgbuhismoaytymvucjfi?.ComfortMeasure, "performed");
                    object cy_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cx_);
                    return (cy_ as CqlQuantity) as object;
                }
                else if (cg_())
                {
                    object cz_ = context.Operators.LateBoundProperty<object>(tuple_hbjscqgbuhismoaytymvucjfi?.ComfortMeasure, "performed");
                    object da_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cz_);
                    return (da_ as CqlInterval<CqlQuantity>) as object;
                }
                else
                {
                    return null;
                };
            }

            CqlInterval<CqlDateTime> ac_ = QICoreCommon_4_0_000.Instance.toInterval(context, ab_());
            CqlDateTime ad_ = context.Operators.Start(ac_);
            object ae_ = context.Operators.LateBoundProperty<object>(tuple_hbjscqgbuhismoaytymvucjfi?.ComfortMeasure, "authoredOn");
            CqlDateTime af_ = context.Operators.LateBoundProperty<CqlDateTime>(ae_, "value");

            object ag_() {

                bool db_() {
                    DataType df_ = tuple_hbjscqgbuhismoaytymvucjfi?.AnesthesiaProcedure?.Performed;
                    object dg_ = FHIRHelpers_4_4_000.Instance.ToValue(context, df_);
                    bool dh_ = dg_ is CqlDateTime;
                    return dh_;
                }


                bool dc_() {
                    DataType di_ = tuple_hbjscqgbuhismoaytymvucjfi?.AnesthesiaProcedure?.Performed;
                    object dj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, di_);
                    bool dk_ = dj_ is CqlInterval<CqlDateTime>;
                    return dk_;
                }


                bool dd_() {
                    DataType dl_ = tuple_hbjscqgbuhismoaytymvucjfi?.AnesthesiaProcedure?.Performed;
                    object dm_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dl_);
                    bool dn_ = dm_ is CqlQuantity;
                    return dn_;
                }


                bool de_() {
                    DataType do_ = tuple_hbjscqgbuhismoaytymvucjfi?.AnesthesiaProcedure?.Performed;
                    object dp_ = FHIRHelpers_4_4_000.Instance.ToValue(context, do_);
                    bool dq_ = dp_ is CqlInterval<CqlQuantity>;
                    return dq_;
                }

                if (db_())
                {
                    DataType dr_ = tuple_hbjscqgbuhismoaytymvucjfi?.AnesthesiaProcedure?.Performed;
                    object ds_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dr_);
                    return (ds_ as CqlDateTime) as object;
                }
                else if (dc_())
                {
                    DataType dt_ = tuple_hbjscqgbuhismoaytymvucjfi?.AnesthesiaProcedure?.Performed;
                    object du_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dt_);
                    return (du_ as CqlInterval<CqlDateTime>) as object;
                }
                else if (dd_())
                {
                    DataType dv_ = tuple_hbjscqgbuhismoaytymvucjfi?.AnesthesiaProcedure?.Performed;
                    object dw_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dv_);
                    return (dw_ as CqlQuantity) as object;
                }
                else if (de_())
                {
                    DataType dx_ = tuple_hbjscqgbuhismoaytymvucjfi?.AnesthesiaProcedure?.Performed;
                    object dy_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dx_);
                    return (dy_ as CqlInterval<CqlQuantity>) as object;
                }
                else
                {
                    return null;
                };
            }

            CqlInterval<CqlDateTime> ah_ = QICoreCommon_4_0_000.Instance.toInterval(context, ag_());
            CqlDateTime ai_ = context.Operators.End(ah_);
            CqlInterval<CqlDate> aj_ = TJCOverall_8_25_000.Instance.calendarDayOfOrDayAfter(context, ai_);
            CqlDate ak_ = aj_?.low;
            CqlDateTime al_ = context.Operators.ConvertDateToDateTime(ak_);

            object am_() {

                bool dz_() {
                    DataType ed_ = tuple_hbjscqgbuhismoaytymvucjfi?.AnesthesiaProcedure?.Performed;
                    object ee_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ed_);
                    bool ef_ = ee_ is CqlDateTime;
                    return ef_;
                }


                bool ea_() {
                    DataType eg_ = tuple_hbjscqgbuhismoaytymvucjfi?.AnesthesiaProcedure?.Performed;
                    object eh_ = FHIRHelpers_4_4_000.Instance.ToValue(context, eg_);
                    bool ei_ = eh_ is CqlInterval<CqlDateTime>;
                    return ei_;
                }


                bool eb_() {
                    DataType ej_ = tuple_hbjscqgbuhismoaytymvucjfi?.AnesthesiaProcedure?.Performed;
                    object ek_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ej_);
                    bool el_ = ek_ is CqlQuantity;
                    return el_;
                }


                bool ec_() {
                    DataType em_ = tuple_hbjscqgbuhismoaytymvucjfi?.AnesthesiaProcedure?.Performed;
                    object en_ = FHIRHelpers_4_4_000.Instance.ToValue(context, em_);
                    bool eo_ = en_ is CqlInterval<CqlQuantity>;
                    return eo_;
                }

                if (dz_())
                {
                    DataType ep_ = tuple_hbjscqgbuhismoaytymvucjfi?.AnesthesiaProcedure?.Performed;
                    object eq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ep_);
                    return (eq_ as CqlDateTime) as object;
                }
                else if (ea_())
                {
                    DataType er_ = tuple_hbjscqgbuhismoaytymvucjfi?.AnesthesiaProcedure?.Performed;
                    object es_ = FHIRHelpers_4_4_000.Instance.ToValue(context, er_);
                    return (es_ as CqlInterval<CqlDateTime>) as object;
                }
                else if (eb_())
                {
                    DataType et_ = tuple_hbjscqgbuhismoaytymvucjfi?.AnesthesiaProcedure?.Performed;
                    object eu_ = FHIRHelpers_4_4_000.Instance.ToValue(context, et_);
                    return (eu_ as CqlQuantity) as object;
                }
                else if (ec_())
                {
                    DataType ev_ = tuple_hbjscqgbuhismoaytymvucjfi?.AnesthesiaProcedure?.Performed;
                    object ew_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ev_);
                    return (ew_ as CqlInterval<CqlQuantity>) as object;
                }
                else
                {
                    return null;
                };
            }

            CqlInterval<CqlDateTime> an_ = QICoreCommon_4_0_000.Instance.toInterval(context, am_());
            CqlDateTime ao_ = context.Operators.End(an_);
            CqlInterval<CqlDate> ap_ = TJCOverall_8_25_000.Instance.calendarDayOfOrDayAfter(context, ao_);
            CqlDate aq_ = ap_?.high;
            CqlDateTime ar_ = context.Operators.ConvertDateToDateTime(aq_);

            object as_() {

                bool ex_() {
                    DataType fb_ = tuple_hbjscqgbuhismoaytymvucjfi?.AnesthesiaProcedure?.Performed;
                    object fc_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fb_);
                    bool fd_ = fc_ is CqlDateTime;
                    return fd_;
                }


                bool ey_() {
                    DataType fe_ = tuple_hbjscqgbuhismoaytymvucjfi?.AnesthesiaProcedure?.Performed;
                    object ff_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fe_);
                    bool fg_ = ff_ is CqlInterval<CqlDateTime>;
                    return fg_;
                }


                bool ez_() {
                    DataType fh_ = tuple_hbjscqgbuhismoaytymvucjfi?.AnesthesiaProcedure?.Performed;
                    object fi_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fh_);
                    bool fj_ = fi_ is CqlQuantity;
                    return fj_;
                }


                bool fa_() {
                    DataType fk_ = tuple_hbjscqgbuhismoaytymvucjfi?.AnesthesiaProcedure?.Performed;
                    object fl_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fk_);
                    bool fm_ = fl_ is CqlInterval<CqlQuantity>;
                    return fm_;
                }

                if (ex_())
                {
                    DataType fn_ = tuple_hbjscqgbuhismoaytymvucjfi?.AnesthesiaProcedure?.Performed;
                    object fo_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fn_);
                    return (fo_ as CqlDateTime) as object;
                }
                else if (ey_())
                {
                    DataType fp_ = tuple_hbjscqgbuhismoaytymvucjfi?.AnesthesiaProcedure?.Performed;
                    object fq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fp_);
                    return (fq_ as CqlInterval<CqlDateTime>) as object;
                }
                else if (ez_())
                {
                    DataType fr_ = tuple_hbjscqgbuhismoaytymvucjfi?.AnesthesiaProcedure?.Performed;
                    object fs_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fr_);
                    return (fs_ as CqlQuantity) as object;
                }
                else if (fa_())
                {
                    DataType ft_ = tuple_hbjscqgbuhismoaytymvucjfi?.AnesthesiaProcedure?.Performed;
                    object fu_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ft_);
                    return (fu_ as CqlInterval<CqlQuantity>) as object;
                }
                else
                {
                    return null;
                };
            }

            CqlInterval<CqlDateTime> at_ = QICoreCommon_4_0_000.Instance.toInterval(context, as_());
            CqlDateTime au_ = context.Operators.End(at_);
            CqlInterval<CqlDate> av_ = TJCOverall_8_25_000.Instance.calendarDayOfOrDayAfter(context, au_);
            bool? aw_ = av_?.lowClosed;

            object ax_() {

                bool fv_() {
                    DataType fz_ = tuple_hbjscqgbuhismoaytymvucjfi?.AnesthesiaProcedure?.Performed;
                    object ga_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fz_);
                    bool gb_ = ga_ is CqlDateTime;
                    return gb_;
                }


                bool fw_() {
                    DataType gc_ = tuple_hbjscqgbuhismoaytymvucjfi?.AnesthesiaProcedure?.Performed;
                    object gd_ = FHIRHelpers_4_4_000.Instance.ToValue(context, gc_);
                    bool ge_ = gd_ is CqlInterval<CqlDateTime>;
                    return ge_;
                }


                bool fx_() {
                    DataType gf_ = tuple_hbjscqgbuhismoaytymvucjfi?.AnesthesiaProcedure?.Performed;
                    object gg_ = FHIRHelpers_4_4_000.Instance.ToValue(context, gf_);
                    bool gh_ = gg_ is CqlQuantity;
                    return gh_;
                }


                bool fy_() {
                    DataType gi_ = tuple_hbjscqgbuhismoaytymvucjfi?.AnesthesiaProcedure?.Performed;
                    object gj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, gi_);
                    bool gk_ = gj_ is CqlInterval<CqlQuantity>;
                    return gk_;
                }

                if (fv_())
                {
                    DataType gl_ = tuple_hbjscqgbuhismoaytymvucjfi?.AnesthesiaProcedure?.Performed;
                    object gm_ = FHIRHelpers_4_4_000.Instance.ToValue(context, gl_);
                    return (gm_ as CqlDateTime) as object;
                }
                else if (fw_())
                {
                    DataType gn_ = tuple_hbjscqgbuhismoaytymvucjfi?.AnesthesiaProcedure?.Performed;
                    object go_ = FHIRHelpers_4_4_000.Instance.ToValue(context, gn_);
                    return (go_ as CqlInterval<CqlDateTime>) as object;
                }
                else if (fx_())
                {
                    DataType gp_ = tuple_hbjscqgbuhismoaytymvucjfi?.AnesthesiaProcedure?.Performed;
                    object gq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, gp_);
                    return (gq_ as CqlQuantity) as object;
                }
                else if (fy_())
                {
                    DataType gr_ = tuple_hbjscqgbuhismoaytymvucjfi?.AnesthesiaProcedure?.Performed;
                    object gs_ = FHIRHelpers_4_4_000.Instance.ToValue(context, gr_);
                    return (gs_ as CqlInterval<CqlQuantity>) as object;
                }
                else
                {
                    return null;
                };
            }

            CqlInterval<CqlDateTime> ay_ = QICoreCommon_4_0_000.Instance.toInterval(context, ax_());
            CqlDateTime az_ = context.Operators.End(ay_);
            CqlInterval<CqlDate> ba_ = TJCOverall_8_25_000.Instance.calendarDayOfOrDayAfter(context, az_);
            bool? bb_ = ba_?.highClosed;
            CqlInterval<CqlDateTime> bc_ = context.Operators.Interval(al_, ar_, aw_, bb_);
            bool? bd_ = context.Operators.In<CqlDateTime>(ad_ ?? af_, bc_, "day");
            bool? be_ = context.Operators.And(aa_, bd_);
            return be_;
        }

        IEnumerable<(CqlTupleMetadata, Encounter QualifyingEncounter, Procedure AnesthesiaProcedure, object ComfortMeasure)?> i_ = context.Operators.Where<(CqlTupleMetadata, Encounter QualifyingEncounter, Procedure AnesthesiaProcedure, object ComfortMeasure)?>(g_, h_);
        Encounter j_((CqlTupleMetadata, Encounter QualifyingEncounter, Procedure AnesthesiaProcedure, object ComfortMeasure)? tuple_hbjscqgbuhismoaytymvucjfi) => tuple_hbjscqgbuhismoaytymvucjfi?.QualifyingEncounter;
        IEnumerable<Encounter> k_ = context.Operators.Select<(CqlTupleMetadata, Encounter QualifyingEncounter, Procedure AnesthesiaProcedure, object ComfortMeasure)?, Encounter>(i_, j_);
        IEnumerable<Encounter> l_ = context.Operators.Distinct<Encounter>(k_);
        return l_;
    }


    [CqlExpressionDefinition("Denominator Exclusions")]
    public IEnumerable<Encounter> Denominator_Exclusions(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Denominator_Exclusions, Denominator_Exclusions_Compute);

    private const long _cacheIndex_Denominator_Exclusions = 4990593561667227735L;

    private IEnumerable<Encounter> Denominator_Exclusions_Compute(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Encounter_Less_Than_2_Days(context);
        IEnumerable<Encounter> b_ = this.Encounter_With_ICU_Location_Stay_1_Day_Or_More(context);
        IEnumerable<Encounter> c_ = context.Operators.Union<Encounter>(a_, b_);
        IEnumerable<Encounter> d_ = this.Encounter_With_Principal_Diagnosis_Of_Mental_Disorder_Or_Stroke(context);
        IEnumerable<Encounter> e_ = this.Encounter_With_Principal_Procedure_Of_Selected_Surgery(context);
        IEnumerable<Encounter> f_ = context.Operators.Union<Encounter>(d_, e_);
        IEnumerable<Encounter> g_ = context.Operators.Union<Encounter>(c_, f_);
        IEnumerable<Encounter> h_ = this.Encounter_With_Intervention_Comfort_Measures_From_Day_Of_Start_Of_Hospitalization_To_Day_After_Admission(context);
        IEnumerable<Encounter> i_ = this.Encounter_With_Intervention_Comfort_Measures_On_Day_Of_Or_Day_After_Procedure(context);
        IEnumerable<Encounter> j_ = context.Operators.Union<Encounter>(h_, i_);
        IEnumerable<Encounter> k_ = context.Operators.Union<Encounter>(g_, j_);
        return k_;
    }


    [CqlExpressionDefinition("Pharmacological or Mechanical VTE Prophylaxis Received")]
    public IEnumerable<object> Pharmacological_or_Mechanical_VTE_Prophylaxis_Received(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Pharmacological_or_Mechanical_VTE_Prophylaxis_Received, Pharmacological_or_Mechanical_VTE_Prophylaxis_Received_Compute);

    private const long _cacheIndex_Pharmacological_or_Mechanical_VTE_Prophylaxis_Received = -337146172657748164L;

    private IEnumerable<object> Pharmacological_or_Mechanical_VTE_Prophylaxis_Received_Compute(CqlContext context)
    {
        CqlValueSet a_ = this.Low_Dose_Unfractionated_Heparin_for_VTE_Prophylaxis(context);
        IEnumerable<MedicationAdministration> b_ = context.Operators.Retrieve<MedicationAdministration>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationadministration"));
        IEnumerable<MedicationAdministration> c_ = context.Operators.Retrieve<MedicationAdministration>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationadministration"));

        bool? d_(MedicationAdministration MR) {
            IEnumerable<Medication> bd_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));

            bool? be_(Medication M) {
                object bh_ = context.Operators.LateBoundProperty<object>(M, "id.value");
                object bi_ = context.Operators.LateBoundProperty<object>(MR, "medication.reference.value");
                IEnumerable<string> bj_ = context.Operators.Split((string)bi_, "/");
                string bk_ = context.Operators.Last<string>(bj_);
                bool? bl_ = context.Operators.Equal(bh_, bk_);
                CodeableConcept bm_ = M?.Code;
                CqlConcept bn_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, bm_);
                CqlValueSet bo_ = this.Low_Dose_Unfractionated_Heparin_for_VTE_Prophylaxis(context);
                bool? bp_ = context.Operators.ConceptInValueSet(bn_, bo_);
                bool? bq_ = context.Operators.And(bl_, bp_);
                return bq_;
            }

            IEnumerable<Medication> bf_ = context.Operators.Where<Medication>(bd_, be_);
            bool? bg_ = context.Operators.Exists<Medication>(bf_);
            return bg_;
        }

        IEnumerable<MedicationAdministration> e_ = context.Operators.Where<MedicationAdministration>(c_, d_);
        IEnumerable<MedicationAdministration> f_ = context.Operators.Union<MedicationAdministration>(b_, e_);

        bool? g_(MedicationAdministration VTEMedication) {
            Code<MedicationAdministration.MedicationAdministrationStatusCodes> br_ = VTEMedication?.StatusElement;
            MedicationAdministration.MedicationAdministrationStatusCodes? bs_ = br_?.Value;
            string bt_ = context.Operators.Convert<string>(bs_);
            bool? bu_ = context.Operators.Equal(bt_, "completed");
            MedicationAdministration.DosageComponent bv_ = VTEMedication?.Dosage;
            CodeableConcept bw_ = bv_?.Route;
            CqlConcept bx_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, bw_);
            CqlValueSet by_ = this.Subcutaneous_route(context);
            bool? bz_ = context.Operators.ConceptInValueSet(bx_, by_);
            bool? ca_ = context.Operators.And(bu_, bz_);
            return ca_;
        }

        IEnumerable<MedicationAdministration> h_ = context.Operators.Where<MedicationAdministration>(f_, g_);
        CqlValueSet i_ = this.Low_Molecular_Weight_Heparin_for_VTE_Prophylaxis(context);
        IEnumerable<MedicationAdministration> j_ = context.Operators.Retrieve<MedicationAdministration>(new RetrieveParameters(default, i_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationadministration"));

        bool? l_(MedicationAdministration MR) {
            IEnumerable<Medication> cb_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));

            bool? cc_(Medication M) {
                object cf_ = context.Operators.LateBoundProperty<object>(M, "id.value");
                object cg_ = context.Operators.LateBoundProperty<object>(MR, "medication.reference.value");
                IEnumerable<string> ch_ = context.Operators.Split((string)cg_, "/");
                string ci_ = context.Operators.Last<string>(ch_);
                bool? cj_ = context.Operators.Equal(cf_, ci_);
                CodeableConcept ck_ = M?.Code;
                CqlConcept cl_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, ck_);
                CqlValueSet cm_ = this.Low_Molecular_Weight_Heparin_for_VTE_Prophylaxis(context);
                bool? cn_ = context.Operators.ConceptInValueSet(cl_, cm_);
                bool? co_ = context.Operators.And(cj_, cn_);
                return co_;
            }

            IEnumerable<Medication> cd_ = context.Operators.Where<Medication>(cb_, cc_);
            bool? ce_ = context.Operators.Exists<Medication>(cd_);
            return ce_;
        }

        IEnumerable<MedicationAdministration> m_ = context.Operators.Where<MedicationAdministration>(c_, l_);
        IEnumerable<MedicationAdministration> n_ = context.Operators.Union<MedicationAdministration>(j_, m_);

        bool? o_(MedicationAdministration LMWH) {
            Code<MedicationAdministration.MedicationAdministrationStatusCodes> cp_ = LMWH?.StatusElement;
            MedicationAdministration.MedicationAdministrationStatusCodes? cq_ = cp_?.Value;
            string cr_ = context.Operators.Convert<string>(cq_);
            bool? cs_ = context.Operators.Equal(cr_, "completed");
            return cs_;
        }

        IEnumerable<MedicationAdministration> p_ = context.Operators.Where<MedicationAdministration>(n_, o_);
        IEnumerable<MedicationAdministration> q_ = context.Operators.Union<MedicationAdministration>(h_, p_);
        CqlValueSet r_ = this.Injectable_Factor_Xa_Inhibitor_for_VTE_Prophylaxis(context);
        IEnumerable<MedicationAdministration> s_ = context.Operators.Retrieve<MedicationAdministration>(new RetrieveParameters(default, r_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationadministration"));

        bool? u_(MedicationAdministration MR) {
            IEnumerable<Medication> ct_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));

            bool? cu_(Medication M) {
                object cx_ = context.Operators.LateBoundProperty<object>(M, "id.value");
                object cy_ = context.Operators.LateBoundProperty<object>(MR, "medication.reference.value");
                IEnumerable<string> cz_ = context.Operators.Split((string)cy_, "/");
                string da_ = context.Operators.Last<string>(cz_);
                bool? db_ = context.Operators.Equal(cx_, da_);
                CodeableConcept dc_ = M?.Code;
                CqlConcept dd_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, dc_);
                CqlValueSet de_ = this.Injectable_Factor_Xa_Inhibitor_for_VTE_Prophylaxis(context);
                bool? df_ = context.Operators.ConceptInValueSet(dd_, de_);
                bool? dg_ = context.Operators.And(db_, df_);
                return dg_;
            }

            IEnumerable<Medication> cv_ = context.Operators.Where<Medication>(ct_, cu_);
            bool? cw_ = context.Operators.Exists<Medication>(cv_);
            return cw_;
        }

        IEnumerable<MedicationAdministration> v_ = context.Operators.Where<MedicationAdministration>(c_, u_);
        IEnumerable<MedicationAdministration> w_ = context.Operators.Union<MedicationAdministration>(s_, v_);

        bool? x_(MedicationAdministration FactorXa) {
            Code<MedicationAdministration.MedicationAdministrationStatusCodes> dh_ = FactorXa?.StatusElement;
            MedicationAdministration.MedicationAdministrationStatusCodes? di_ = dh_?.Value;
            string dj_ = context.Operators.Convert<string>(di_);
            bool? dk_ = context.Operators.Equal(dj_, "completed");
            return dk_;
        }

        IEnumerable<MedicationAdministration> y_ = context.Operators.Where<MedicationAdministration>(w_, x_);
        CqlValueSet z_ = this.Warfarin(context);
        IEnumerable<MedicationAdministration> aa_ = context.Operators.Retrieve<MedicationAdministration>(new RetrieveParameters(default, z_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationadministration"));

        bool? ac_(MedicationAdministration MR) {
            IEnumerable<Medication> dl_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));

            bool? dm_(Medication M) {
                object dp_ = context.Operators.LateBoundProperty<object>(M, "id.value");
                object dq_ = context.Operators.LateBoundProperty<object>(MR, "medication.reference.value");
                IEnumerable<string> dr_ = context.Operators.Split((string)dq_, "/");
                string ds_ = context.Operators.Last<string>(dr_);
                bool? dt_ = context.Operators.Equal(dp_, ds_);
                CodeableConcept du_ = M?.Code;
                CqlConcept dv_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, du_);
                CqlValueSet dw_ = this.Warfarin(context);
                bool? dx_ = context.Operators.ConceptInValueSet(dv_, dw_);
                bool? dy_ = context.Operators.And(dt_, dx_);
                return dy_;
            }

            IEnumerable<Medication> dn_ = context.Operators.Where<Medication>(dl_, dm_);
            bool? do_ = context.Operators.Exists<Medication>(dn_);
            return do_;
        }

        IEnumerable<MedicationAdministration> ad_ = context.Operators.Where<MedicationAdministration>(c_, ac_);
        IEnumerable<MedicationAdministration> ae_ = context.Operators.Union<MedicationAdministration>(aa_, ad_);

        bool? af_(MedicationAdministration WarfarinAdm) {
            Code<MedicationAdministration.MedicationAdministrationStatusCodes> dz_ = WarfarinAdm?.StatusElement;
            MedicationAdministration.MedicationAdministrationStatusCodes? ea_ = dz_?.Value;
            string eb_ = context.Operators.Convert<string>(ea_);
            bool? ec_ = context.Operators.Equal(eb_, "completed");
            return ec_;
        }

        IEnumerable<MedicationAdministration> ag_ = context.Operators.Where<MedicationAdministration>(ae_, af_);
        IEnumerable<MedicationAdministration> ah_ = context.Operators.Union<MedicationAdministration>(y_, ag_);
        IEnumerable<MedicationAdministration> ai_ = context.Operators.Union<MedicationAdministration>(q_, ah_);
        CqlValueSet aj_ = this.Rivaroxaban_for_VTE_Prophylaxis(context);
        IEnumerable<MedicationAdministration> ak_ = context.Operators.Retrieve<MedicationAdministration>(new RetrieveParameters(default, aj_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationadministration"));

        bool? am_(MedicationAdministration MR) {
            IEnumerable<Medication> ed_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));

            bool? ee_(Medication M) {
                object eh_ = context.Operators.LateBoundProperty<object>(M, "id.value");
                object ei_ = context.Operators.LateBoundProperty<object>(MR, "medication.reference.value");
                IEnumerable<string> ej_ = context.Operators.Split((string)ei_, "/");
                string ek_ = context.Operators.Last<string>(ej_);
                bool? el_ = context.Operators.Equal(eh_, ek_);
                CodeableConcept em_ = M?.Code;
                CqlConcept en_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, em_);
                CqlValueSet eo_ = this.Rivaroxaban_for_VTE_Prophylaxis(context);
                bool? ep_ = context.Operators.ConceptInValueSet(en_, eo_);
                bool? eq_ = context.Operators.And(el_, ep_);
                return eq_;
            }

            IEnumerable<Medication> ef_ = context.Operators.Where<Medication>(ed_, ee_);
            bool? eg_ = context.Operators.Exists<Medication>(ef_);
            return eg_;
        }

        IEnumerable<MedicationAdministration> an_ = context.Operators.Where<MedicationAdministration>(c_, am_);
        IEnumerable<MedicationAdministration> ao_ = context.Operators.Union<MedicationAdministration>(ak_, an_);

        bool? ap_(MedicationAdministration Rivaroxaban) {
            Code<MedicationAdministration.MedicationAdministrationStatusCodes> er_ = Rivaroxaban?.StatusElement;
            MedicationAdministration.MedicationAdministrationStatusCodes? es_ = er_?.Value;
            string et_ = context.Operators.Convert<string>(es_);
            bool? eu_ = context.Operators.Equal(et_, "completed");
            return eu_;
        }

        IEnumerable<MedicationAdministration> aq_ = context.Operators.Where<MedicationAdministration>(ao_, ap_);
        CqlValueSet ar_ = this.Application_of_Intermittent_Pneumatic_Compression_Devices(context);
        IEnumerable<Procedure> as_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, ar_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
        CqlValueSet at_ = this.Application_of_Venous_Foot_Pumps(context);
        IEnumerable<Procedure> au_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, at_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
        IEnumerable<Procedure> av_ = context.Operators.Union<Procedure>(as_, au_);
        CqlValueSet aw_ = this.Application_of_Graduated_Compression_Stockings(context);
        IEnumerable<Procedure> ax_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, aw_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
        IEnumerable<Procedure> ay_ = context.Operators.Union<Procedure>(av_, ax_);

        bool? az_(Procedure DeviceApplied) {
            Code<EventStatus> ev_ = DeviceApplied?.StatusElement;
            EventStatus? ew_ = ev_?.Value;
            string ex_ = context.Operators.Convert<string>(ew_);
            bool? ey_ = context.Operators.Equal(ex_, "completed");
            return ey_;
        }

        IEnumerable<Procedure> ba_ = context.Operators.Where<Procedure>(ay_, az_);
        IEnumerable<object> bb_ = context.Operators.Union<object>(aq_ as IEnumerable<object>, ba_ as IEnumerable<object>);
        IEnumerable<object> bc_ = context.Operators.Union<object>(ai_ as IEnumerable<object>, bb_ as IEnumerable<object>);
        return bc_;
    }


    [CqlExpressionDefinition("Encounter With VTE Prophylaxis Received From Day Of Start Of Hospitalization To Day After Admission Or Procedure")]
    public IEnumerable<Encounter> Encounter_With_VTE_Prophylaxis_Received_From_Day_Of_Start_Of_Hospitalization_To_Day_After_Admission_Or_Procedure(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Encounter_With_VTE_Prophylaxis_Received_From_Day_Of_Start_Of_Hospitalization_To_Day_After_Admission_Or_Procedure, Encounter_With_VTE_Prophylaxis_Received_From_Day_Of_Start_Of_Hospitalization_To_Day_After_Admission_Or_Procedure_Compute);

    private const long _cacheIndex_Encounter_With_VTE_Prophylaxis_Received_From_Day_Of_Start_Of_Hospitalization_To_Day_After_Admission_Or_Procedure = 7620879229938405847L;

    private IEnumerable<Encounter> Encounter_With_VTE_Prophylaxis_Received_From_Day_Of_Start_Of_Hospitalization_To_Day_After_Admission_Or_Procedure_Compute(CqlContext context)
    {
        IEnumerable<Encounter> a_ = VTE_8_18_000.Instance.Encounter_With_Age_Range_And_Without_VTE_Diagnosis_Or_Obstetrical_Conditions(context);
        IEnumerable<object> b_ = this.Pharmacological_or_Mechanical_VTE_Prophylaxis_Received(context);
        IEnumerable<ValueTuple<Encounter, object>> c_ = context.Operators.CrossJoin<Encounter, object>(a_, b_);

        (CqlTupleMetadata, Encounter QualifyingEncounter, object VTEProphylaxis)? d_(ValueTuple<Encounter, object> _valueTuple) {
            (CqlTupleMetadata, Encounter QualifyingEncounter, object VTEProphylaxis)? x_ = (CqlTupleMetadata_DQDJDfNDAVfLFYEjYSBYIhgSj, _valueTuple.Item1, _valueTuple.Item2);
            return x_;
        }

        IEnumerable<(CqlTupleMetadata, Encounter QualifyingEncounter, object VTEProphylaxis)?> e_ = context.Operators.Select<ValueTuple<Encounter, object>, (CqlTupleMetadata, Encounter QualifyingEncounter, object VTEProphylaxis)?>(c_, d_);

        bool? f_((CqlTupleMetadata, Encounter QualifyingEncounter, object VTEProphylaxis)? tuple_dqdjdfndavflfyejysbyihgsj) {
            object y_ = context.Operators.LateBoundProperty<object>(tuple_dqdjdfndavflfyejysbyihgsj?.VTEProphylaxis, "effective");
            object z_ = FHIRHelpers_4_4_000.Instance.ToValue(context, y_);
            CqlInterval<CqlDateTime> aa_ = QICoreCommon_4_0_000.Instance.toInterval(context, z_);

            object ab_() {

                bool aq_() {
                    object au_ = context.Operators.LateBoundProperty<object>(tuple_dqdjdfndavflfyejysbyihgsj?.VTEProphylaxis, "performed");
                    object av_ = FHIRHelpers_4_4_000.Instance.ToValue(context, au_);
                    bool aw_ = av_ is CqlDateTime;
                    return aw_;
                }


                bool ar_() {
                    object ax_ = context.Operators.LateBoundProperty<object>(tuple_dqdjdfndavflfyejysbyihgsj?.VTEProphylaxis, "performed");
                    object ay_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ax_);
                    bool az_ = ay_ is CqlInterval<CqlDateTime>;
                    return az_;
                }


                bool as_() {
                    object ba_ = context.Operators.LateBoundProperty<object>(tuple_dqdjdfndavflfyejysbyihgsj?.VTEProphylaxis, "performed");
                    object bb_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ba_);
                    bool bc_ = bb_ is CqlQuantity;
                    return bc_;
                }


                bool at_() {
                    object bd_ = context.Operators.LateBoundProperty<object>(tuple_dqdjdfndavflfyejysbyihgsj?.VTEProphylaxis, "performed");
                    object be_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bd_);
                    bool bf_ = be_ is CqlInterval<CqlQuantity>;
                    return bf_;
                }

                if (aq_())
                {
                    object bg_ = context.Operators.LateBoundProperty<object>(tuple_dqdjdfndavflfyejysbyihgsj?.VTEProphylaxis, "performed");
                    object bh_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bg_);
                    return (bh_ as CqlDateTime) as object;
                }
                else if (ar_())
                {
                    object bi_ = context.Operators.LateBoundProperty<object>(tuple_dqdjdfndavflfyejysbyihgsj?.VTEProphylaxis, "performed");
                    object bj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bi_);
                    return (bj_ as CqlInterval<CqlDateTime>) as object;
                }
                else if (as_())
                {
                    object bk_ = context.Operators.LateBoundProperty<object>(tuple_dqdjdfndavflfyejysbyihgsj?.VTEProphylaxis, "performed");
                    object bl_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bk_);
                    return (bl_ as CqlQuantity) as object;
                }
                else if (at_())
                {
                    object bm_ = context.Operators.LateBoundProperty<object>(tuple_dqdjdfndavflfyejysbyihgsj?.VTEProphylaxis, "performed");
                    object bn_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bm_);
                    return (bn_ as CqlInterval<CqlQuantity>) as object;
                }
                else
                {
                    return null;
                };
            }

            CqlInterval<CqlDateTime> ac_ = QICoreCommon_4_0_000.Instance.toInterval(context, ab_());
            CqlDateTime ad_ = context.Operators.Start(aa_ ?? ac_);
            CqlInterval<CqlDate> ae_ = this.fromDayOfStartOfHospitalizationToDayAfterAdmission(context, tuple_dqdjdfndavflfyejysbyihgsj?.QualifyingEncounter);
            CqlDate af_ = ae_?.low;
            CqlDateTime ag_ = context.Operators.ConvertDateToDateTime(af_);
            CqlDate ai_ = ae_?.high;
            CqlDateTime aj_ = context.Operators.ConvertDateToDateTime(ai_);
            bool? al_ = ae_?.lowClosed;
            bool? an_ = ae_?.highClosed;
            CqlInterval<CqlDateTime> ao_ = context.Operators.Interval(ag_, aj_, al_, an_);
            bool? ap_ = context.Operators.In<CqlDateTime>(ad_, ao_, "day");
            return ap_;
        }

        IEnumerable<(CqlTupleMetadata, Encounter QualifyingEncounter, object VTEProphylaxis)?> g_ = context.Operators.Where<(CqlTupleMetadata, Encounter QualifyingEncounter, object VTEProphylaxis)?>(e_, f_);
        Encounter h_((CqlTupleMetadata, Encounter QualifyingEncounter, object VTEProphylaxis)? tuple_dqdjdfndavflfyejysbyihgsj) => tuple_dqdjdfndavflfyejysbyihgsj?.QualifyingEncounter;
        IEnumerable<Encounter> i_ = context.Operators.Select<(CqlTupleMetadata, Encounter QualifyingEncounter, object VTEProphylaxis)?, Encounter>(g_, h_);
        IEnumerable<Encounter> j_ = context.Operators.Distinct<Encounter>(i_);
        CqlValueSet l_ = this.General_or_Neuraxial_Anesthesia(context);
        IEnumerable<Procedure> m_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, l_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
        IEnumerable<ValueTuple<Encounter, Procedure, object>> o_ = context.Operators.CrossJoin<Encounter, Procedure, object>(a_, m_, b_);

        (CqlTupleMetadata, Encounter QualifyingEncounter, Procedure AnesthesiaProcedure, object VTEProphylaxis)? p_(ValueTuple<Encounter, Procedure, object> _valueTuple) {
            (CqlTupleMetadata, Encounter QualifyingEncounter, Procedure AnesthesiaProcedure, object VTEProphylaxis)? bo_ = (CqlTupleMetadata_CfSFUFiTWJJfiZASQhERUdATP, _valueTuple.Item1, _valueTuple.Item2, _valueTuple.Item3);
            return bo_;
        }

        IEnumerable<(CqlTupleMetadata, Encounter QualifyingEncounter, Procedure AnesthesiaProcedure, object VTEProphylaxis)?> q_ = context.Operators.Select<ValueTuple<Encounter, Procedure, object>, (CqlTupleMetadata, Encounter QualifyingEncounter, Procedure AnesthesiaProcedure, object VTEProphylaxis)?>(o_, p_);

        bool? r_((CqlTupleMetadata, Encounter QualifyingEncounter, Procedure AnesthesiaProcedure, object VTEProphylaxis)? tuple_bnvctjfzpousixdcefwhciwq) {
            Code<EventStatus> bp_ = tuple_bnvctjfzpousixdcefwhciwq?.AnesthesiaProcedure?.StatusElement;
            EventStatus? bq_ = bp_?.Value;
            string br_ = context.Operators.Convert<string>(bq_);
            bool? bs_ = context.Operators.Equal(br_, "completed");

            object bt_() {

                bool di_() {
                    DataType dm_ = tuple_bnvctjfzpousixdcefwhciwq?.AnesthesiaProcedure?.Performed;
                    object dn_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dm_);
                    bool do_ = dn_ is CqlDateTime;
                    return do_;
                }


                bool dj_() {
                    DataType dp_ = tuple_bnvctjfzpousixdcefwhciwq?.AnesthesiaProcedure?.Performed;
                    object dq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dp_);
                    bool dr_ = dq_ is CqlInterval<CqlDateTime>;
                    return dr_;
                }


                bool dk_() {
                    DataType ds_ = tuple_bnvctjfzpousixdcefwhciwq?.AnesthesiaProcedure?.Performed;
                    object dt_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ds_);
                    bool du_ = dt_ is CqlQuantity;
                    return du_;
                }


                bool dl_() {
                    DataType dv_ = tuple_bnvctjfzpousixdcefwhciwq?.AnesthesiaProcedure?.Performed;
                    object dw_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dv_);
                    bool dx_ = dw_ is CqlInterval<CqlQuantity>;
                    return dx_;
                }

                if (di_())
                {
                    DataType dy_ = tuple_bnvctjfzpousixdcefwhciwq?.AnesthesiaProcedure?.Performed;
                    object dz_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dy_);
                    return (dz_ as CqlDateTime) as object;
                }
                else if (dj_())
                {
                    DataType ea_ = tuple_bnvctjfzpousixdcefwhciwq?.AnesthesiaProcedure?.Performed;
                    object eb_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ea_);
                    return (eb_ as CqlInterval<CqlDateTime>) as object;
                }
                else if (dk_())
                {
                    DataType ec_ = tuple_bnvctjfzpousixdcefwhciwq?.AnesthesiaProcedure?.Performed;
                    object ed_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ec_);
                    return (ed_ as CqlQuantity) as object;
                }
                else if (dl_())
                {
                    DataType ee_ = tuple_bnvctjfzpousixdcefwhciwq?.AnesthesiaProcedure?.Performed;
                    object ef_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ee_);
                    return (ef_ as CqlInterval<CqlQuantity>) as object;
                }
                else
                {
                    return null;
                };
            }

            CqlInterval<CqlDateTime> bu_ = QICoreCommon_4_0_000.Instance.toInterval(context, bt_());
            CqlDateTime bv_ = context.Operators.End(bu_);
            Period bw_ = tuple_bnvctjfzpousixdcefwhciwq?.QualifyingEncounter?.Period;
            CqlInterval<CqlDateTime> bx_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, bw_);
            CqlDateTime by_ = context.Operators.Start(bx_);
            CqlQuantity bz_ = context.Operators.Quantity(1m, "day");
            CqlDateTime ca_ = context.Operators.Add(by_, bz_);
            bool? cb_ = context.Operators.SameAs(bv_, ca_, "day");
            bool? cc_ = context.Operators.And(bs_, cb_);
            object cd_ = context.Operators.LateBoundProperty<object>(tuple_bnvctjfzpousixdcefwhciwq?.VTEProphylaxis, "effective");
            object ce_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cd_);
            CqlInterval<CqlDateTime> cf_ = QICoreCommon_4_0_000.Instance.toInterval(context, ce_);

            object cg_() {

                bool eg_() {
                    object ek_ = context.Operators.LateBoundProperty<object>(tuple_bnvctjfzpousixdcefwhciwq?.VTEProphylaxis, "performed");
                    object el_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ek_);
                    bool em_ = el_ is CqlDateTime;
                    return em_;
                }


                bool eh_() {
                    object en_ = context.Operators.LateBoundProperty<object>(tuple_bnvctjfzpousixdcefwhciwq?.VTEProphylaxis, "performed");
                    object eo_ = FHIRHelpers_4_4_000.Instance.ToValue(context, en_);
                    bool ep_ = eo_ is CqlInterval<CqlDateTime>;
                    return ep_;
                }


                bool ei_() {
                    object eq_ = context.Operators.LateBoundProperty<object>(tuple_bnvctjfzpousixdcefwhciwq?.VTEProphylaxis, "performed");
                    object er_ = FHIRHelpers_4_4_000.Instance.ToValue(context, eq_);
                    bool es_ = er_ is CqlQuantity;
                    return es_;
                }


                bool ej_() {
                    object et_ = context.Operators.LateBoundProperty<object>(tuple_bnvctjfzpousixdcefwhciwq?.VTEProphylaxis, "performed");
                    object eu_ = FHIRHelpers_4_4_000.Instance.ToValue(context, et_);
                    bool ev_ = eu_ is CqlInterval<CqlQuantity>;
                    return ev_;
                }

                if (eg_())
                {
                    object ew_ = context.Operators.LateBoundProperty<object>(tuple_bnvctjfzpousixdcefwhciwq?.VTEProphylaxis, "performed");
                    object ex_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ew_);
                    return (ex_ as CqlDateTime) as object;
                }
                else if (eh_())
                {
                    object ey_ = context.Operators.LateBoundProperty<object>(tuple_bnvctjfzpousixdcefwhciwq?.VTEProphylaxis, "performed");
                    object ez_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ey_);
                    return (ez_ as CqlInterval<CqlDateTime>) as object;
                }
                else if (ei_())
                {
                    object fa_ = context.Operators.LateBoundProperty<object>(tuple_bnvctjfzpousixdcefwhciwq?.VTEProphylaxis, "performed");
                    object fb_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fa_);
                    return (fb_ as CqlQuantity) as object;
                }
                else if (ej_())
                {
                    object fc_ = context.Operators.LateBoundProperty<object>(tuple_bnvctjfzpousixdcefwhciwq?.VTEProphylaxis, "performed");
                    object fd_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fc_);
                    return (fd_ as CqlInterval<CqlQuantity>) as object;
                }
                else
                {
                    return null;
                };
            }

            CqlInterval<CqlDateTime> ch_ = QICoreCommon_4_0_000.Instance.toInterval(context, cg_());
            CqlDateTime ci_ = context.Operators.Start(cf_ ?? ch_);

            object cj_() {

                bool fe_() {
                    DataType fi_ = tuple_bnvctjfzpousixdcefwhciwq?.AnesthesiaProcedure?.Performed;
                    object fj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fi_);
                    bool fk_ = fj_ is CqlDateTime;
                    return fk_;
                }


                bool ff_() {
                    DataType fl_ = tuple_bnvctjfzpousixdcefwhciwq?.AnesthesiaProcedure?.Performed;
                    object fm_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fl_);
                    bool fn_ = fm_ is CqlInterval<CqlDateTime>;
                    return fn_;
                }


                bool fg_() {
                    DataType fo_ = tuple_bnvctjfzpousixdcefwhciwq?.AnesthesiaProcedure?.Performed;
                    object fp_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fo_);
                    bool fq_ = fp_ is CqlQuantity;
                    return fq_;
                }


                bool fh_() {
                    DataType fr_ = tuple_bnvctjfzpousixdcefwhciwq?.AnesthesiaProcedure?.Performed;
                    object fs_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fr_);
                    bool ft_ = fs_ is CqlInterval<CqlQuantity>;
                    return ft_;
                }

                if (fe_())
                {
                    DataType fu_ = tuple_bnvctjfzpousixdcefwhciwq?.AnesthesiaProcedure?.Performed;
                    object fv_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fu_);
                    return (fv_ as CqlDateTime) as object;
                }
                else if (ff_())
                {
                    DataType fw_ = tuple_bnvctjfzpousixdcefwhciwq?.AnesthesiaProcedure?.Performed;
                    object fx_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fw_);
                    return (fx_ as CqlInterval<CqlDateTime>) as object;
                }
                else if (fg_())
                {
                    DataType fy_ = tuple_bnvctjfzpousixdcefwhciwq?.AnesthesiaProcedure?.Performed;
                    object fz_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fy_);
                    return (fz_ as CqlQuantity) as object;
                }
                else if (fh_())
                {
                    DataType ga_ = tuple_bnvctjfzpousixdcefwhciwq?.AnesthesiaProcedure?.Performed;
                    object gb_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ga_);
                    return (gb_ as CqlInterval<CqlQuantity>) as object;
                }
                else
                {
                    return null;
                };
            }

            CqlInterval<CqlDateTime> ck_ = QICoreCommon_4_0_000.Instance.toInterval(context, cj_());
            CqlDateTime cl_ = context.Operators.End(ck_);
            CqlInterval<CqlDate> cm_ = TJCOverall_8_25_000.Instance.calendarDayOfOrDayAfter(context, cl_);
            CqlDate cn_ = cm_?.low;
            CqlDateTime co_ = context.Operators.ConvertDateToDateTime(cn_);

            object cp_() {

                bool gc_() {
                    DataType gg_ = tuple_bnvctjfzpousixdcefwhciwq?.AnesthesiaProcedure?.Performed;
                    object gh_ = FHIRHelpers_4_4_000.Instance.ToValue(context, gg_);
                    bool gi_ = gh_ is CqlDateTime;
                    return gi_;
                }


                bool gd_() {
                    DataType gj_ = tuple_bnvctjfzpousixdcefwhciwq?.AnesthesiaProcedure?.Performed;
                    object gk_ = FHIRHelpers_4_4_000.Instance.ToValue(context, gj_);
                    bool gl_ = gk_ is CqlInterval<CqlDateTime>;
                    return gl_;
                }


                bool ge_() {
                    DataType gm_ = tuple_bnvctjfzpousixdcefwhciwq?.AnesthesiaProcedure?.Performed;
                    object gn_ = FHIRHelpers_4_4_000.Instance.ToValue(context, gm_);
                    bool go_ = gn_ is CqlQuantity;
                    return go_;
                }


                bool gf_() {
                    DataType gp_ = tuple_bnvctjfzpousixdcefwhciwq?.AnesthesiaProcedure?.Performed;
                    object gq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, gp_);
                    bool gr_ = gq_ is CqlInterval<CqlQuantity>;
                    return gr_;
                }

                if (gc_())
                {
                    DataType gs_ = tuple_bnvctjfzpousixdcefwhciwq?.AnesthesiaProcedure?.Performed;
                    object gt_ = FHIRHelpers_4_4_000.Instance.ToValue(context, gs_);
                    return (gt_ as CqlDateTime) as object;
                }
                else if (gd_())
                {
                    DataType gu_ = tuple_bnvctjfzpousixdcefwhciwq?.AnesthesiaProcedure?.Performed;
                    object gv_ = FHIRHelpers_4_4_000.Instance.ToValue(context, gu_);
                    return (gv_ as CqlInterval<CqlDateTime>) as object;
                }
                else if (ge_())
                {
                    DataType gw_ = tuple_bnvctjfzpousixdcefwhciwq?.AnesthesiaProcedure?.Performed;
                    object gx_ = FHIRHelpers_4_4_000.Instance.ToValue(context, gw_);
                    return (gx_ as CqlQuantity) as object;
                }
                else if (gf_())
                {
                    DataType gy_ = tuple_bnvctjfzpousixdcefwhciwq?.AnesthesiaProcedure?.Performed;
                    object gz_ = FHIRHelpers_4_4_000.Instance.ToValue(context, gy_);
                    return (gz_ as CqlInterval<CqlQuantity>) as object;
                }
                else
                {
                    return null;
                };
            }

            CqlInterval<CqlDateTime> cq_ = QICoreCommon_4_0_000.Instance.toInterval(context, cp_());
            CqlDateTime cr_ = context.Operators.End(cq_);
            CqlInterval<CqlDate> cs_ = TJCOverall_8_25_000.Instance.calendarDayOfOrDayAfter(context, cr_);
            CqlDate ct_ = cs_?.high;
            CqlDateTime cu_ = context.Operators.ConvertDateToDateTime(ct_);

            object cv_() {

                bool ha_() {
                    DataType he_ = tuple_bnvctjfzpousixdcefwhciwq?.AnesthesiaProcedure?.Performed;
                    object hf_ = FHIRHelpers_4_4_000.Instance.ToValue(context, he_);
                    bool hg_ = hf_ is CqlDateTime;
                    return hg_;
                }


                bool hb_() {
                    DataType hh_ = tuple_bnvctjfzpousixdcefwhciwq?.AnesthesiaProcedure?.Performed;
                    object hi_ = FHIRHelpers_4_4_000.Instance.ToValue(context, hh_);
                    bool hj_ = hi_ is CqlInterval<CqlDateTime>;
                    return hj_;
                }


                bool hc_() {
                    DataType hk_ = tuple_bnvctjfzpousixdcefwhciwq?.AnesthesiaProcedure?.Performed;
                    object hl_ = FHIRHelpers_4_4_000.Instance.ToValue(context, hk_);
                    bool hm_ = hl_ is CqlQuantity;
                    return hm_;
                }


                bool hd_() {
                    DataType hn_ = tuple_bnvctjfzpousixdcefwhciwq?.AnesthesiaProcedure?.Performed;
                    object ho_ = FHIRHelpers_4_4_000.Instance.ToValue(context, hn_);
                    bool hp_ = ho_ is CqlInterval<CqlQuantity>;
                    return hp_;
                }

                if (ha_())
                {
                    DataType hq_ = tuple_bnvctjfzpousixdcefwhciwq?.AnesthesiaProcedure?.Performed;
                    object hr_ = FHIRHelpers_4_4_000.Instance.ToValue(context, hq_);
                    return (hr_ as CqlDateTime) as object;
                }
                else if (hb_())
                {
                    DataType hs_ = tuple_bnvctjfzpousixdcefwhciwq?.AnesthesiaProcedure?.Performed;
                    object ht_ = FHIRHelpers_4_4_000.Instance.ToValue(context, hs_);
                    return (ht_ as CqlInterval<CqlDateTime>) as object;
                }
                else if (hc_())
                {
                    DataType hu_ = tuple_bnvctjfzpousixdcefwhciwq?.AnesthesiaProcedure?.Performed;
                    object hv_ = FHIRHelpers_4_4_000.Instance.ToValue(context, hu_);
                    return (hv_ as CqlQuantity) as object;
                }
                else if (hd_())
                {
                    DataType hw_ = tuple_bnvctjfzpousixdcefwhciwq?.AnesthesiaProcedure?.Performed;
                    object hx_ = FHIRHelpers_4_4_000.Instance.ToValue(context, hw_);
                    return (hx_ as CqlInterval<CqlQuantity>) as object;
                }
                else
                {
                    return null;
                };
            }

            CqlInterval<CqlDateTime> cw_ = QICoreCommon_4_0_000.Instance.toInterval(context, cv_());
            CqlDateTime cx_ = context.Operators.End(cw_);
            CqlInterval<CqlDate> cy_ = TJCOverall_8_25_000.Instance.calendarDayOfOrDayAfter(context, cx_);
            bool? cz_ = cy_?.lowClosed;

            object da_() {

                bool hy_() {
                    DataType ic_ = tuple_bnvctjfzpousixdcefwhciwq?.AnesthesiaProcedure?.Performed;
                    object id_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ic_);
                    bool ie_ = id_ is CqlDateTime;
                    return ie_;
                }


                bool hz_() {
                    DataType if_ = tuple_bnvctjfzpousixdcefwhciwq?.AnesthesiaProcedure?.Performed;
                    object ig_ = FHIRHelpers_4_4_000.Instance.ToValue(context, if_);
                    bool ih_ = ig_ is CqlInterval<CqlDateTime>;
                    return ih_;
                }


                bool ia_() {
                    DataType ii_ = tuple_bnvctjfzpousixdcefwhciwq?.AnesthesiaProcedure?.Performed;
                    object ij_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ii_);
                    bool ik_ = ij_ is CqlQuantity;
                    return ik_;
                }


                bool ib_() {
                    DataType il_ = tuple_bnvctjfzpousixdcefwhciwq?.AnesthesiaProcedure?.Performed;
                    object im_ = FHIRHelpers_4_4_000.Instance.ToValue(context, il_);
                    bool in_ = im_ is CqlInterval<CqlQuantity>;
                    return in_;
                }

                if (hy_())
                {
                    DataType io_ = tuple_bnvctjfzpousixdcefwhciwq?.AnesthesiaProcedure?.Performed;
                    object ip_ = FHIRHelpers_4_4_000.Instance.ToValue(context, io_);
                    return (ip_ as CqlDateTime) as object;
                }
                else if (hz_())
                {
                    DataType iq_ = tuple_bnvctjfzpousixdcefwhciwq?.AnesthesiaProcedure?.Performed;
                    object ir_ = FHIRHelpers_4_4_000.Instance.ToValue(context, iq_);
                    return (ir_ as CqlInterval<CqlDateTime>) as object;
                }
                else if (ia_())
                {
                    DataType is_ = tuple_bnvctjfzpousixdcefwhciwq?.AnesthesiaProcedure?.Performed;
                    object it_ = FHIRHelpers_4_4_000.Instance.ToValue(context, is_);
                    return (it_ as CqlQuantity) as object;
                }
                else if (ib_())
                {
                    DataType iu_ = tuple_bnvctjfzpousixdcefwhciwq?.AnesthesiaProcedure?.Performed;
                    object iv_ = FHIRHelpers_4_4_000.Instance.ToValue(context, iu_);
                    return (iv_ as CqlInterval<CqlQuantity>) as object;
                }
                else
                {
                    return null;
                };
            }

            CqlInterval<CqlDateTime> db_ = QICoreCommon_4_0_000.Instance.toInterval(context, da_());
            CqlDateTime dc_ = context.Operators.End(db_);
            CqlInterval<CqlDate> dd_ = TJCOverall_8_25_000.Instance.calendarDayOfOrDayAfter(context, dc_);
            bool? de_ = dd_?.highClosed;
            CqlInterval<CqlDateTime> df_ = context.Operators.Interval(co_, cu_, cz_, de_);
            bool? dg_ = context.Operators.In<CqlDateTime>(ci_, df_, "day");
            bool? dh_ = context.Operators.And(cc_, dg_);
            return dh_;
        }

        IEnumerable<(CqlTupleMetadata, Encounter QualifyingEncounter, Procedure AnesthesiaProcedure, object VTEProphylaxis)?> s_ = context.Operators.Where<(CqlTupleMetadata, Encounter QualifyingEncounter, Procedure AnesthesiaProcedure, object VTEProphylaxis)?>(q_, r_);
        Encounter t_((CqlTupleMetadata, Encounter QualifyingEncounter, Procedure AnesthesiaProcedure, object VTEProphylaxis)? tuple_bnvctjfzpousixdcefwhciwq) => tuple_bnvctjfzpousixdcefwhciwq?.QualifyingEncounter;
        IEnumerable<Encounter> u_ = context.Operators.Select<(CqlTupleMetadata, Encounter QualifyingEncounter, Procedure AnesthesiaProcedure, object VTEProphylaxis)?, Encounter>(s_, t_);
        IEnumerable<Encounter> v_ = context.Operators.Distinct<Encounter>(u_);
        IEnumerable<Encounter> w_ = context.Operators.Union<Encounter>(j_, v_);
        return w_;
    }


    [CqlExpressionDefinition("Encounter With Medication Oral Factor Xa Inhibitor Administered On Day Of Or Day After Admission Or Procedure")]
    public IEnumerable<Encounter> Encounter_With_Medication_Oral_Factor_Xa_Inhibitor_Administered_On_Day_Of_Or_Day_After_Admission_Or_Procedure(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Encounter_With_Medication_Oral_Factor_Xa_Inhibitor_Administered_On_Day_Of_Or_Day_After_Admission_Or_Procedure, Encounter_With_Medication_Oral_Factor_Xa_Inhibitor_Administered_On_Day_Of_Or_Day_After_Admission_Or_Procedure_Compute);

    private const long _cacheIndex_Encounter_With_Medication_Oral_Factor_Xa_Inhibitor_Administered_On_Day_Of_Or_Day_After_Admission_Or_Procedure = 3422895210558274894L;

    private IEnumerable<Encounter> Encounter_With_Medication_Oral_Factor_Xa_Inhibitor_Administered_On_Day_Of_Or_Day_After_Admission_Or_Procedure_Compute(CqlContext context)
    {
        IEnumerable<Encounter> a_ = VTE_8_18_000.Instance.Encounter_With_Age_Range_And_Without_VTE_Diagnosis_Or_Obstetrical_Conditions(context);
        CqlValueSet b_ = this.Oral_Factor_Xa_Inhibitor_for_VTE_Prophylaxis_or_VTE_Treatment(context);
        IEnumerable<MedicationAdministration> c_ = context.Operators.Retrieve<MedicationAdministration>(new RetrieveParameters(default, b_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationadministration"));
        IEnumerable<MedicationAdministration> d_ = context.Operators.Retrieve<MedicationAdministration>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationadministration"));

        bool? e_(MedicationAdministration MR) {
            IEnumerable<Medication> ah_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));

            bool? ai_(Medication M) {
                object al_ = context.Operators.LateBoundProperty<object>(M, "id.value");
                object am_ = context.Operators.LateBoundProperty<object>(MR, "medication.reference.value");
                IEnumerable<string> an_ = context.Operators.Split((string)am_, "/");
                string ao_ = context.Operators.Last<string>(an_);
                bool? ap_ = context.Operators.Equal(al_, ao_);
                CodeableConcept aq_ = M?.Code;
                CqlConcept ar_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, aq_);
                CqlValueSet as_ = this.Oral_Factor_Xa_Inhibitor_for_VTE_Prophylaxis_or_VTE_Treatment(context);
                bool? at_ = context.Operators.ConceptInValueSet(ar_, as_);
                bool? au_ = context.Operators.And(ap_, at_);
                return au_;
            }

            IEnumerable<Medication> aj_ = context.Operators.Where<Medication>(ah_, ai_);
            bool? ak_ = context.Operators.Exists<Medication>(aj_);
            return ak_;
        }

        IEnumerable<MedicationAdministration> f_ = context.Operators.Where<MedicationAdministration>(d_, e_);
        IEnumerable<MedicationAdministration> g_ = context.Operators.Union<MedicationAdministration>(c_, f_);
        IEnumerable<ValueTuple<Encounter, MedicationAdministration>> h_ = context.Operators.CrossJoin<Encounter, MedicationAdministration>(a_, g_);

        (CqlTupleMetadata, Encounter QualifyingEncounter, MedicationAdministration FactorXaMedication)? i_(ValueTuple<Encounter, MedicationAdministration> _valueTuple) {
            (CqlTupleMetadata, Encounter QualifyingEncounter, MedicationAdministration FactorXaMedication)? av_ = (CqlTupleMetadata_EBRQeiSMaTgecHVEbVOIMZEcb, _valueTuple.Item1, _valueTuple.Item2);
            return av_;
        }

        IEnumerable<(CqlTupleMetadata, Encounter QualifyingEncounter, MedicationAdministration FactorXaMedication)?> j_ = context.Operators.Select<ValueTuple<Encounter, MedicationAdministration>, (CqlTupleMetadata, Encounter QualifyingEncounter, MedicationAdministration FactorXaMedication)?>(h_, i_);

        bool? k_((CqlTupleMetadata, Encounter QualifyingEncounter, MedicationAdministration FactorXaMedication)? tuple_cdbvhiekdcojzrccbhjghhgeo) {
            Code<MedicationAdministration.MedicationAdministrationStatusCodes> aw_ = tuple_cdbvhiekdcojzrccbhjghhgeo?.FactorXaMedication?.StatusElement;
            MedicationAdministration.MedicationAdministrationStatusCodes? ax_ = aw_?.Value;
            string ay_ = context.Operators.Convert<string>(ax_);
            bool? az_ = context.Operators.Equal(ay_, "completed");
            DataType ba_ = tuple_cdbvhiekdcojzrccbhjghhgeo?.FactorXaMedication?.Effective;
            object bb_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ba_);
            CqlInterval<CqlDateTime> bc_ = QICoreCommon_4_0_000.Instance.toInterval(context, bb_);
            CqlDateTime bd_ = context.Operators.Start(bc_);
            Period be_ = tuple_cdbvhiekdcojzrccbhjghhgeo?.QualifyingEncounter?.Period;
            CqlInterval<CqlDateTime> bf_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, be_);
            CqlDateTime bg_ = context.Operators.Start(bf_);
            CqlInterval<CqlDate> bh_ = TJCOverall_8_25_000.Instance.calendarDayOfOrDayAfter(context, bg_);
            CqlDate bi_ = bh_?.low;
            CqlDateTime bj_ = context.Operators.ConvertDateToDateTime(bi_);
            CqlInterval<CqlDateTime> bl_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, be_);
            CqlDateTime bm_ = context.Operators.Start(bl_);
            CqlInterval<CqlDate> bn_ = TJCOverall_8_25_000.Instance.calendarDayOfOrDayAfter(context, bm_);
            CqlDate bo_ = bn_?.high;
            CqlDateTime bp_ = context.Operators.ConvertDateToDateTime(bo_);
            CqlInterval<CqlDateTime> br_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, be_);
            CqlDateTime bs_ = context.Operators.Start(br_);
            CqlInterval<CqlDate> bt_ = TJCOverall_8_25_000.Instance.calendarDayOfOrDayAfter(context, bs_);
            bool? bu_ = bt_?.lowClosed;
            CqlInterval<CqlDateTime> bw_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, be_);
            CqlDateTime bx_ = context.Operators.Start(bw_);
            CqlInterval<CqlDate> by_ = TJCOverall_8_25_000.Instance.calendarDayOfOrDayAfter(context, bx_);
            bool? bz_ = by_?.highClosed;
            CqlInterval<CqlDateTime> ca_ = context.Operators.Interval(bj_, bp_, bu_, bz_);
            bool? cb_ = context.Operators.In<CqlDateTime>(bd_, ca_, "day");
            bool? cc_ = context.Operators.And(az_, cb_);
            return cc_;
        }

        IEnumerable<(CqlTupleMetadata, Encounter QualifyingEncounter, MedicationAdministration FactorXaMedication)?> l_ = context.Operators.Where<(CqlTupleMetadata, Encounter QualifyingEncounter, MedicationAdministration FactorXaMedication)?>(j_, k_);
        Encounter m_((CqlTupleMetadata, Encounter QualifyingEncounter, MedicationAdministration FactorXaMedication)? tuple_cdbvhiekdcojzrccbhjghhgeo) => tuple_cdbvhiekdcojzrccbhjghhgeo?.QualifyingEncounter;
        IEnumerable<Encounter> n_ = context.Operators.Select<(CqlTupleMetadata, Encounter QualifyingEncounter, MedicationAdministration FactorXaMedication)?, Encounter>(l_, m_);
        IEnumerable<Encounter> o_ = context.Operators.Distinct<Encounter>(n_);
        CqlValueSet q_ = this.General_or_Neuraxial_Anesthesia(context);
        IEnumerable<Procedure> r_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, q_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
        IEnumerable<MedicationAdministration> t_ = context.Operators.Retrieve<MedicationAdministration>(new RetrieveParameters(default, b_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationadministration"));

        bool? v_(MedicationAdministration MR) {
            IEnumerable<Medication> cd_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));

            bool? ce_(Medication M) {
                object ch_ = context.Operators.LateBoundProperty<object>(M, "id.value");
                object ci_ = context.Operators.LateBoundProperty<object>(MR, "medication.reference.value");
                IEnumerable<string> cj_ = context.Operators.Split((string)ci_, "/");
                string ck_ = context.Operators.Last<string>(cj_);
                bool? cl_ = context.Operators.Equal(ch_, ck_);
                CodeableConcept cm_ = M?.Code;
                CqlConcept cn_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, cm_);
                CqlValueSet co_ = this.Oral_Factor_Xa_Inhibitor_for_VTE_Prophylaxis_or_VTE_Treatment(context);
                bool? cp_ = context.Operators.ConceptInValueSet(cn_, co_);
                bool? cq_ = context.Operators.And(cl_, cp_);
                return cq_;
            }

            IEnumerable<Medication> cf_ = context.Operators.Where<Medication>(cd_, ce_);
            bool? cg_ = context.Operators.Exists<Medication>(cf_);
            return cg_;
        }

        IEnumerable<MedicationAdministration> w_ = context.Operators.Where<MedicationAdministration>(d_, v_);
        IEnumerable<MedicationAdministration> x_ = context.Operators.Union<MedicationAdministration>(t_, w_);
        IEnumerable<ValueTuple<Encounter, Procedure, MedicationAdministration>> y_ = context.Operators.CrossJoin<Encounter, Procedure, MedicationAdministration>(a_, r_, x_);

        (CqlTupleMetadata, Encounter QualifyingEncounter, Procedure AnesthesiaProcedure, MedicationAdministration FactorXaMedication)? z_(ValueTuple<Encounter, Procedure, MedicationAdministration> _valueTuple) {
            (CqlTupleMetadata, Encounter QualifyingEncounter, Procedure AnesthesiaProcedure, MedicationAdministration FactorXaMedication)? cr_ = (CqlTupleMetadata_CdgLdDFHNTDXFGGVTOMXhQZR, _valueTuple.Item1, _valueTuple.Item2, _valueTuple.Item3);
            return cr_;
        }

        IEnumerable<(CqlTupleMetadata, Encounter QualifyingEncounter, Procedure AnesthesiaProcedure, MedicationAdministration FactorXaMedication)?> aa_ = context.Operators.Select<ValueTuple<Encounter, Procedure, MedicationAdministration>, (CqlTupleMetadata, Encounter QualifyingEncounter, Procedure AnesthesiaProcedure, MedicationAdministration FactorXaMedication)?>(y_, z_);

        bool? ab_((CqlTupleMetadata, Encounter QualifyingEncounter, Procedure AnesthesiaProcedure, MedicationAdministration FactorXaMedication)? tuple_dejnabiogwrwyxienqokgepgj) {
            Code<MedicationAdministration.MedicationAdministrationStatusCodes> cs_ = tuple_dejnabiogwrwyxienqokgepgj?.FactorXaMedication?.StatusElement;
            MedicationAdministration.MedicationAdministrationStatusCodes? ct_ = cs_?.Value;
            string cu_ = context.Operators.Convert<string>(ct_);
            bool? cv_ = context.Operators.Equal(cu_, "completed");
            Code<EventStatus> cw_ = tuple_dejnabiogwrwyxienqokgepgj?.AnesthesiaProcedure?.StatusElement;
            EventStatus? cx_ = cw_?.Value;
            string cy_ = context.Operators.Convert<string>(cx_);
            bool? cz_ = context.Operators.Equal(cy_, "completed");
            bool? da_ = context.Operators.And(cv_, cz_);

            object db_() {

                bool eo_() {
                    DataType es_ = tuple_dejnabiogwrwyxienqokgepgj?.AnesthesiaProcedure?.Performed;
                    object et_ = FHIRHelpers_4_4_000.Instance.ToValue(context, es_);
                    bool eu_ = et_ is CqlDateTime;
                    return eu_;
                }


                bool ep_() {
                    DataType ev_ = tuple_dejnabiogwrwyxienqokgepgj?.AnesthesiaProcedure?.Performed;
                    object ew_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ev_);
                    bool ex_ = ew_ is CqlInterval<CqlDateTime>;
                    return ex_;
                }


                bool eq_() {
                    DataType ey_ = tuple_dejnabiogwrwyxienqokgepgj?.AnesthesiaProcedure?.Performed;
                    object ez_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ey_);
                    bool fa_ = ez_ is CqlQuantity;
                    return fa_;
                }


                bool er_() {
                    DataType fb_ = tuple_dejnabiogwrwyxienqokgepgj?.AnesthesiaProcedure?.Performed;
                    object fc_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fb_);
                    bool fd_ = fc_ is CqlInterval<CqlQuantity>;
                    return fd_;
                }

                if (eo_())
                {
                    DataType fe_ = tuple_dejnabiogwrwyxienqokgepgj?.AnesthesiaProcedure?.Performed;
                    object ff_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fe_);
                    return (ff_ as CqlDateTime) as object;
                }
                else if (ep_())
                {
                    DataType fg_ = tuple_dejnabiogwrwyxienqokgepgj?.AnesthesiaProcedure?.Performed;
                    object fh_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fg_);
                    return (fh_ as CqlInterval<CqlDateTime>) as object;
                }
                else if (eq_())
                {
                    DataType fi_ = tuple_dejnabiogwrwyxienqokgepgj?.AnesthesiaProcedure?.Performed;
                    object fj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fi_);
                    return (fj_ as CqlQuantity) as object;
                }
                else if (er_())
                {
                    DataType fk_ = tuple_dejnabiogwrwyxienqokgepgj?.AnesthesiaProcedure?.Performed;
                    object fl_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fk_);
                    return (fl_ as CqlInterval<CqlQuantity>) as object;
                }
                else
                {
                    return null;
                };
            }

            CqlInterval<CqlDateTime> dc_ = QICoreCommon_4_0_000.Instance.toInterval(context, db_());
            CqlDateTime dd_ = context.Operators.End(dc_);
            Period de_ = tuple_dejnabiogwrwyxienqokgepgj?.QualifyingEncounter?.Period;
            CqlInterval<CqlDateTime> df_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, de_);
            CqlDateTime dg_ = context.Operators.Start(df_);
            CqlQuantity dh_ = context.Operators.Quantity(1m, "day");
            CqlDateTime di_ = context.Operators.Add(dg_, dh_);
            bool? dj_ = context.Operators.SameAs(dd_, di_, "day");
            bool? dk_ = context.Operators.And(da_, dj_);
            DataType dl_ = tuple_dejnabiogwrwyxienqokgepgj?.FactorXaMedication?.Effective;
            object dm_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dl_);
            CqlInterval<CqlDateTime> dn_ = QICoreCommon_4_0_000.Instance.toInterval(context, dm_);
            CqlDateTime do_ = context.Operators.Start(dn_);

            object dp_() {

                bool fm_() {
                    DataType fq_ = tuple_dejnabiogwrwyxienqokgepgj?.AnesthesiaProcedure?.Performed;
                    object fr_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fq_);
                    bool fs_ = fr_ is CqlDateTime;
                    return fs_;
                }


                bool fn_() {
                    DataType ft_ = tuple_dejnabiogwrwyxienqokgepgj?.AnesthesiaProcedure?.Performed;
                    object fu_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ft_);
                    bool fv_ = fu_ is CqlInterval<CqlDateTime>;
                    return fv_;
                }


                bool fo_() {
                    DataType fw_ = tuple_dejnabiogwrwyxienqokgepgj?.AnesthesiaProcedure?.Performed;
                    object fx_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fw_);
                    bool fy_ = fx_ is CqlQuantity;
                    return fy_;
                }


                bool fp_() {
                    DataType fz_ = tuple_dejnabiogwrwyxienqokgepgj?.AnesthesiaProcedure?.Performed;
                    object ga_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fz_);
                    bool gb_ = ga_ is CqlInterval<CqlQuantity>;
                    return gb_;
                }

                if (fm_())
                {
                    DataType gc_ = tuple_dejnabiogwrwyxienqokgepgj?.AnesthesiaProcedure?.Performed;
                    object gd_ = FHIRHelpers_4_4_000.Instance.ToValue(context, gc_);
                    return (gd_ as CqlDateTime) as object;
                }
                else if (fn_())
                {
                    DataType ge_ = tuple_dejnabiogwrwyxienqokgepgj?.AnesthesiaProcedure?.Performed;
                    object gf_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ge_);
                    return (gf_ as CqlInterval<CqlDateTime>) as object;
                }
                else if (fo_())
                {
                    DataType gg_ = tuple_dejnabiogwrwyxienqokgepgj?.AnesthesiaProcedure?.Performed;
                    object gh_ = FHIRHelpers_4_4_000.Instance.ToValue(context, gg_);
                    return (gh_ as CqlQuantity) as object;
                }
                else if (fp_())
                {
                    DataType gi_ = tuple_dejnabiogwrwyxienqokgepgj?.AnesthesiaProcedure?.Performed;
                    object gj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, gi_);
                    return (gj_ as CqlInterval<CqlQuantity>) as object;
                }
                else
                {
                    return null;
                };
            }

            CqlInterval<CqlDateTime> dq_ = QICoreCommon_4_0_000.Instance.toInterval(context, dp_());
            CqlDateTime dr_ = context.Operators.End(dq_);
            CqlInterval<CqlDate> ds_ = TJCOverall_8_25_000.Instance.calendarDayOfOrDayAfter(context, dr_);
            CqlDate dt_ = ds_?.low;
            CqlDateTime du_ = context.Operators.ConvertDateToDateTime(dt_);

            object dv_() {

                bool gk_() {
                    DataType go_ = tuple_dejnabiogwrwyxienqokgepgj?.AnesthesiaProcedure?.Performed;
                    object gp_ = FHIRHelpers_4_4_000.Instance.ToValue(context, go_);
                    bool gq_ = gp_ is CqlDateTime;
                    return gq_;
                }


                bool gl_() {
                    DataType gr_ = tuple_dejnabiogwrwyxienqokgepgj?.AnesthesiaProcedure?.Performed;
                    object gs_ = FHIRHelpers_4_4_000.Instance.ToValue(context, gr_);
                    bool gt_ = gs_ is CqlInterval<CqlDateTime>;
                    return gt_;
                }


                bool gm_() {
                    DataType gu_ = tuple_dejnabiogwrwyxienqokgepgj?.AnesthesiaProcedure?.Performed;
                    object gv_ = FHIRHelpers_4_4_000.Instance.ToValue(context, gu_);
                    bool gw_ = gv_ is CqlQuantity;
                    return gw_;
                }


                bool gn_() {
                    DataType gx_ = tuple_dejnabiogwrwyxienqokgepgj?.AnesthesiaProcedure?.Performed;
                    object gy_ = FHIRHelpers_4_4_000.Instance.ToValue(context, gx_);
                    bool gz_ = gy_ is CqlInterval<CqlQuantity>;
                    return gz_;
                }

                if (gk_())
                {
                    DataType ha_ = tuple_dejnabiogwrwyxienqokgepgj?.AnesthesiaProcedure?.Performed;
                    object hb_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ha_);
                    return (hb_ as CqlDateTime) as object;
                }
                else if (gl_())
                {
                    DataType hc_ = tuple_dejnabiogwrwyxienqokgepgj?.AnesthesiaProcedure?.Performed;
                    object hd_ = FHIRHelpers_4_4_000.Instance.ToValue(context, hc_);
                    return (hd_ as CqlInterval<CqlDateTime>) as object;
                }
                else if (gm_())
                {
                    DataType he_ = tuple_dejnabiogwrwyxienqokgepgj?.AnesthesiaProcedure?.Performed;
                    object hf_ = FHIRHelpers_4_4_000.Instance.ToValue(context, he_);
                    return (hf_ as CqlQuantity) as object;
                }
                else if (gn_())
                {
                    DataType hg_ = tuple_dejnabiogwrwyxienqokgepgj?.AnesthesiaProcedure?.Performed;
                    object hh_ = FHIRHelpers_4_4_000.Instance.ToValue(context, hg_);
                    return (hh_ as CqlInterval<CqlQuantity>) as object;
                }
                else
                {
                    return null;
                };
            }

            CqlInterval<CqlDateTime> dw_ = QICoreCommon_4_0_000.Instance.toInterval(context, dv_());
            CqlDateTime dx_ = context.Operators.End(dw_);
            CqlInterval<CqlDate> dy_ = TJCOverall_8_25_000.Instance.calendarDayOfOrDayAfter(context, dx_);
            CqlDate dz_ = dy_?.high;
            CqlDateTime ea_ = context.Operators.ConvertDateToDateTime(dz_);

            object eb_() {

                bool hi_() {
                    DataType hm_ = tuple_dejnabiogwrwyxienqokgepgj?.AnesthesiaProcedure?.Performed;
                    object hn_ = FHIRHelpers_4_4_000.Instance.ToValue(context, hm_);
                    bool ho_ = hn_ is CqlDateTime;
                    return ho_;
                }


                bool hj_() {
                    DataType hp_ = tuple_dejnabiogwrwyxienqokgepgj?.AnesthesiaProcedure?.Performed;
                    object hq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, hp_);
                    bool hr_ = hq_ is CqlInterval<CqlDateTime>;
                    return hr_;
                }


                bool hk_() {
                    DataType hs_ = tuple_dejnabiogwrwyxienqokgepgj?.AnesthesiaProcedure?.Performed;
                    object ht_ = FHIRHelpers_4_4_000.Instance.ToValue(context, hs_);
                    bool hu_ = ht_ is CqlQuantity;
                    return hu_;
                }


                bool hl_() {
                    DataType hv_ = tuple_dejnabiogwrwyxienqokgepgj?.AnesthesiaProcedure?.Performed;
                    object hw_ = FHIRHelpers_4_4_000.Instance.ToValue(context, hv_);
                    bool hx_ = hw_ is CqlInterval<CqlQuantity>;
                    return hx_;
                }

                if (hi_())
                {
                    DataType hy_ = tuple_dejnabiogwrwyxienqokgepgj?.AnesthesiaProcedure?.Performed;
                    object hz_ = FHIRHelpers_4_4_000.Instance.ToValue(context, hy_);
                    return (hz_ as CqlDateTime) as object;
                }
                else if (hj_())
                {
                    DataType ia_ = tuple_dejnabiogwrwyxienqokgepgj?.AnesthesiaProcedure?.Performed;
                    object ib_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ia_);
                    return (ib_ as CqlInterval<CqlDateTime>) as object;
                }
                else if (hk_())
                {
                    DataType ic_ = tuple_dejnabiogwrwyxienqokgepgj?.AnesthesiaProcedure?.Performed;
                    object id_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ic_);
                    return (id_ as CqlQuantity) as object;
                }
                else if (hl_())
                {
                    DataType ie_ = tuple_dejnabiogwrwyxienqokgepgj?.AnesthesiaProcedure?.Performed;
                    object if_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ie_);
                    return (if_ as CqlInterval<CqlQuantity>) as object;
                }
                else
                {
                    return null;
                };
            }

            CqlInterval<CqlDateTime> ec_ = QICoreCommon_4_0_000.Instance.toInterval(context, eb_());
            CqlDateTime ed_ = context.Operators.End(ec_);
            CqlInterval<CqlDate> ee_ = TJCOverall_8_25_000.Instance.calendarDayOfOrDayAfter(context, ed_);
            bool? ef_ = ee_?.lowClosed;

            object eg_() {

                bool ig_() {
                    DataType ik_ = tuple_dejnabiogwrwyxienqokgepgj?.AnesthesiaProcedure?.Performed;
                    object il_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ik_);
                    bool im_ = il_ is CqlDateTime;
                    return im_;
                }


                bool ih_() {
                    DataType in_ = tuple_dejnabiogwrwyxienqokgepgj?.AnesthesiaProcedure?.Performed;
                    object io_ = FHIRHelpers_4_4_000.Instance.ToValue(context, in_);
                    bool ip_ = io_ is CqlInterval<CqlDateTime>;
                    return ip_;
                }


                bool ii_() {
                    DataType iq_ = tuple_dejnabiogwrwyxienqokgepgj?.AnesthesiaProcedure?.Performed;
                    object ir_ = FHIRHelpers_4_4_000.Instance.ToValue(context, iq_);
                    bool is_ = ir_ is CqlQuantity;
                    return is_;
                }


                bool ij_() {
                    DataType it_ = tuple_dejnabiogwrwyxienqokgepgj?.AnesthesiaProcedure?.Performed;
                    object iu_ = FHIRHelpers_4_4_000.Instance.ToValue(context, it_);
                    bool iv_ = iu_ is CqlInterval<CqlQuantity>;
                    return iv_;
                }

                if (ig_())
                {
                    DataType iw_ = tuple_dejnabiogwrwyxienqokgepgj?.AnesthesiaProcedure?.Performed;
                    object ix_ = FHIRHelpers_4_4_000.Instance.ToValue(context, iw_);
                    return (ix_ as CqlDateTime) as object;
                }
                else if (ih_())
                {
                    DataType iy_ = tuple_dejnabiogwrwyxienqokgepgj?.AnesthesiaProcedure?.Performed;
                    object iz_ = FHIRHelpers_4_4_000.Instance.ToValue(context, iy_);
                    return (iz_ as CqlInterval<CqlDateTime>) as object;
                }
                else if (ii_())
                {
                    DataType ja_ = tuple_dejnabiogwrwyxienqokgepgj?.AnesthesiaProcedure?.Performed;
                    object jb_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ja_);
                    return (jb_ as CqlQuantity) as object;
                }
                else if (ij_())
                {
                    DataType jc_ = tuple_dejnabiogwrwyxienqokgepgj?.AnesthesiaProcedure?.Performed;
                    object jd_ = FHIRHelpers_4_4_000.Instance.ToValue(context, jc_);
                    return (jd_ as CqlInterval<CqlQuantity>) as object;
                }
                else
                {
                    return null;
                };
            }

            CqlInterval<CqlDateTime> eh_ = QICoreCommon_4_0_000.Instance.toInterval(context, eg_());
            CqlDateTime ei_ = context.Operators.End(eh_);
            CqlInterval<CqlDate> ej_ = TJCOverall_8_25_000.Instance.calendarDayOfOrDayAfter(context, ei_);
            bool? ek_ = ej_?.highClosed;
            CqlInterval<CqlDateTime> el_ = context.Operators.Interval(du_, ea_, ef_, ek_);
            bool? em_ = context.Operators.In<CqlDateTime>(do_, el_, "day");
            bool? en_ = context.Operators.And(dk_, em_);
            return en_;
        }

        IEnumerable<(CqlTupleMetadata, Encounter QualifyingEncounter, Procedure AnesthesiaProcedure, MedicationAdministration FactorXaMedication)?> ac_ = context.Operators.Where<(CqlTupleMetadata, Encounter QualifyingEncounter, Procedure AnesthesiaProcedure, MedicationAdministration FactorXaMedication)?>(aa_, ab_);
        Encounter ad_((CqlTupleMetadata, Encounter QualifyingEncounter, Procedure AnesthesiaProcedure, MedicationAdministration FactorXaMedication)? tuple_dejnabiogwrwyxienqokgepgj) => tuple_dejnabiogwrwyxienqokgepgj?.QualifyingEncounter;
        IEnumerable<Encounter> ae_ = context.Operators.Select<(CqlTupleMetadata, Encounter QualifyingEncounter, Procedure AnesthesiaProcedure, MedicationAdministration FactorXaMedication)?, Encounter>(ac_, ad_);
        IEnumerable<Encounter> af_ = context.Operators.Distinct<Encounter>(ae_);
        IEnumerable<Encounter> ag_ = context.Operators.Union<Encounter>(o_, af_);
        return ag_;
    }


    [CqlExpressionDefinition("Encounter With Prior Or Present Diagnosis Of Atrial Fibrillation Or Prior Diagnosis Of VTE")]
    public IEnumerable<Encounter> Encounter_With_Prior_Or_Present_Diagnosis_Of_Atrial_Fibrillation_Or_Prior_Diagnosis_Of_VTE(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Encounter_With_Prior_Or_Present_Diagnosis_Of_Atrial_Fibrillation_Or_Prior_Diagnosis_Of_VTE, Encounter_With_Prior_Or_Present_Diagnosis_Of_Atrial_Fibrillation_Or_Prior_Diagnosis_Of_VTE_Compute);

    private const long _cacheIndex_Encounter_With_Prior_Or_Present_Diagnosis_Of_Atrial_Fibrillation_Or_Prior_Diagnosis_Of_VTE = -6120398887152395383L;

    private IEnumerable<Encounter> Encounter_With_Prior_Or_Present_Diagnosis_Of_Atrial_Fibrillation_Or_Prior_Diagnosis_Of_VTE_Compute(CqlContext context)
    {
        IEnumerable<Encounter> a_ = VTE_8_18_000.Instance.Encounter_With_Age_Range_And_Without_VTE_Diagnosis_Or_Obstetrical_Conditions(context);

        bool? b_(Encounter QualifyingEncounter) {
            CqlValueSet l_ = this.Atrial_Fibrillation_or_Flutter(context);
            IEnumerable<Condition> m_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, l_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-problems-health-concerns"));

            bool? n_(Condition AtrialFibrillation) {
                CodeableConcept q_ = AtrialFibrillation?.VerificationStatus;
                CqlConcept r_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, q_);
                bool? s_ = context.Operators.Not((bool?)(r_ is null));
                CqlConcept u_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, q_);
                CqlCode v_ = QICoreCommon_4_0_000.Instance.refuted(context);
                CqlConcept w_ = context.Operators.ConvertCodeToConcept(v_);
                bool? x_ = context.Operators.Equivalent(u_, w_);
                bool? y_ = context.Operators.Not(x_);
                CqlConcept aa_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, q_);
                CqlCode ab_ = QICoreCommon_4_0_000.Instance.entered_in_error(context);
                CqlConcept ac_ = context.Operators.ConvertCodeToConcept(ab_);
                bool? ad_ = context.Operators.Equivalent(aa_, ac_);
                bool? ae_ = context.Operators.Not(ad_);
                bool? af_ = context.Operators.And(y_, ae_);
                DataType ag_ = AtrialFibrillation?.Onset;
                object ah_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ag_);
                CqlInterval<CqlDateTime> ai_ = QICoreCommon_4_0_000.Instance.toInterval(context, ah_);
                CqlDateTime aj_ = context.Operators.Start(ai_);
                Period ak_ = QualifyingEncounter?.Period;
                CqlInterval<CqlDateTime> al_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ak_);
                CqlDateTime am_ = context.Operators.End(al_);
                bool? an_ = context.Operators.SameOrBefore(aj_, am_, (string)default);
                bool? ao_ = context.Operators.And(af_, an_);
                bool? ap_ = context.Operators.Implies(s_, ao_);
                return ap_;
            }

            IEnumerable<Condition> o_ = context.Operators.Where<Condition>(m_, n_);
            bool? p_ = context.Operators.Exists<Condition>(o_);
            return p_;
        }

        IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);

        bool? e_(Encounter QualifyingEncounter) {
            CqlValueSet aq_ = this.Atrial_Fibrillation_or_Flutter(context);
            bool? ar_ = VTE_8_18_000.Instance.hasEncDiagnosisOf(context, QualifyingEncounter, aq_);
            return ar_;
        }

        IEnumerable<Encounter> f_ = context.Operators.Where<Encounter>(a_, e_);
        IEnumerable<Encounter> g_ = context.Operators.Union<Encounter>(c_, f_);

        bool? i_(Encounter QualifyingEncounter) {
            CqlValueSet as_ = this.Venous_Thromboembolism(context);
            IEnumerable<Condition> at_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, as_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-problems-health-concerns"));

            bool? au_(Condition VTEDiagnosis) {
                CodeableConcept ax_ = VTEDiagnosis?.ClinicalStatus;
                CqlConcept ay_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, ax_);
                CqlCode az_ = QICoreCommon_4_0_000.Instance.inactive(context);
                CqlConcept ba_ = context.Operators.ConvertCodeToConcept(az_);
                bool? bb_ = context.Operators.Equivalent(ay_, ba_);
                CqlConcept bd_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, ax_);
                CqlCode be_ = QICoreCommon_4_0_000.Instance.remission(context);
                CqlConcept bf_ = context.Operators.ConvertCodeToConcept(be_);
                bool? bg_ = context.Operators.Equivalent(bd_, bf_);
                bool? bh_ = context.Operators.Or(bb_, bg_);
                CqlConcept bj_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, ax_);
                CqlCode bk_ = QICoreCommon_4_0_000.Instance.resolved(context);
                CqlConcept bl_ = context.Operators.ConvertCodeToConcept(bk_);
                bool? bm_ = context.Operators.Equivalent(bj_, bl_);
                bool? bn_ = context.Operators.Or(bh_, bm_);
                CodeableConcept bo_ = VTEDiagnosis?.VerificationStatus;
                CqlConcept bp_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, bo_);
                bool? bq_ = context.Operators.Not((bool?)(bp_ is null));
                bool? br_ = context.Operators.And(bn_, bq_);
                CqlConcept bt_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, bo_);
                CqlCode bu_ = QICoreCommon_4_0_000.Instance.refuted(context);
                CqlConcept bv_ = context.Operators.ConvertCodeToConcept(bu_);
                bool? bw_ = context.Operators.Equivalent(bt_, bv_);
                bool? bx_ = context.Operators.Not(bw_);
                CqlConcept bz_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, bo_);
                CqlCode ca_ = QICoreCommon_4_0_000.Instance.entered_in_error(context);
                CqlConcept cb_ = context.Operators.ConvertCodeToConcept(ca_);
                bool? cc_ = context.Operators.Equivalent(bz_, cb_);
                bool? cd_ = context.Operators.Not(cc_);
                bool? ce_ = context.Operators.And(bx_, cd_);
                DataType cf_ = VTEDiagnosis?.Onset;
                object cg_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cf_);
                CqlInterval<CqlDateTime> ch_ = QICoreCommon_4_0_000.Instance.toInterval(context, cg_);

                CqlInterval<CqlDateTime> ci_() {

                    bool cm_() {
                        Period cn_ = QualifyingEncounter?.Period;
                        CqlInterval<CqlDateTime> co_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, cn_);
                        CqlDateTime cp_ = context.Operators.Start(co_);
                        return cp_ is null;
                    }

                    if (cm_())
                    {
                        return default;
                    }
                    else
                    {
                        Period cq_ = QualifyingEncounter?.Period;
                        CqlInterval<CqlDateTime> cr_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, cq_);
                        CqlDateTime cs_ = context.Operators.Start(cr_);
                        CqlInterval<CqlDateTime> cu_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, cq_);
                        CqlDateTime cv_ = context.Operators.Start(cu_);
                        CqlInterval<CqlDateTime> cw_ = context.Operators.Interval(cs_, cv_, true, true);
                        return cw_;
                    };
                }

                bool? cj_ = context.Operators.Before(ch_, ci_(), (string)default);
                bool? ck_ = context.Operators.And(ce_, cj_);
                bool? cl_ = context.Operators.Implies(br_, ck_);
                return cl_;
            }

            IEnumerable<Condition> av_ = context.Operators.Where<Condition>(at_, au_);
            bool? aw_ = context.Operators.Exists<Condition>(av_);
            return aw_;
        }

        IEnumerable<Encounter> j_ = context.Operators.Where<Encounter>(a_, i_);
        IEnumerable<Encounter> k_ = context.Operators.Union<Encounter>(g_, j_);
        return k_;
    }


    [CqlExpressionDefinition("Encounter With Prior Or Present Procedure Of Hip Or Knee Replacement Surgery")]
    public IEnumerable<Encounter> Encounter_With_Prior_Or_Present_Procedure_Of_Hip_Or_Knee_Replacement_Surgery(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Encounter_With_Prior_Or_Present_Procedure_Of_Hip_Or_Knee_Replacement_Surgery, Encounter_With_Prior_Or_Present_Procedure_Of_Hip_Or_Knee_Replacement_Surgery_Compute);

    private const long _cacheIndex_Encounter_With_Prior_Or_Present_Procedure_Of_Hip_Or_Knee_Replacement_Surgery = -7986423794810552467L;

    private IEnumerable<Encounter> Encounter_With_Prior_Or_Present_Procedure_Of_Hip_Or_Knee_Replacement_Surgery_Compute(CqlContext context)
    {
        IEnumerable<Encounter> a_ = VTE_8_18_000.Instance.Encounter_With_Age_Range_And_Without_VTE_Diagnosis_Or_Obstetrical_Conditions(context);

        bool? b_(Encounter QualifyingEncounter) {
            CqlValueSet d_ = this.Hip_Replacement_Surgery(context);
            IEnumerable<Procedure> e_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, d_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
            CqlValueSet f_ = this.Knee_Replacement_Surgery(context);
            IEnumerable<Procedure> g_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, f_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
            IEnumerable<Procedure> h_ = context.Operators.Union<Procedure>(e_, g_);

            bool? i_(Procedure HipKneeProcedure) {
                Code<EventStatus> l_ = HipKneeProcedure?.StatusElement;
                EventStatus? m_ = l_?.Value;
                string n_ = context.Operators.Convert<string>(m_);
                bool? o_ = context.Operators.Equal(n_, "completed");

                object p_() {

                    bool x_() {
                        DataType ab_ = HipKneeProcedure?.Performed;
                        object ac_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ab_);
                        bool ad_ = ac_ is CqlDateTime;
                        return ad_;
                    }


                    bool y_() {
                        DataType ae_ = HipKneeProcedure?.Performed;
                        object af_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ae_);
                        bool ag_ = af_ is CqlInterval<CqlDateTime>;
                        return ag_;
                    }


                    bool z_() {
                        DataType ah_ = HipKneeProcedure?.Performed;
                        object ai_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ah_);
                        bool aj_ = ai_ is CqlQuantity;
                        return aj_;
                    }


                    bool aa_() {
                        DataType ak_ = HipKneeProcedure?.Performed;
                        object al_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ak_);
                        bool am_ = al_ is CqlInterval<CqlQuantity>;
                        return am_;
                    }

                    if (x_())
                    {
                        DataType an_ = HipKneeProcedure?.Performed;
                        object ao_ = FHIRHelpers_4_4_000.Instance.ToValue(context, an_);
                        return (ao_ as CqlDateTime) as object;
                    }
                    else if (y_())
                    {
                        DataType ap_ = HipKneeProcedure?.Performed;
                        object aq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ap_);
                        return (aq_ as CqlInterval<CqlDateTime>) as object;
                    }
                    else if (z_())
                    {
                        DataType ar_ = HipKneeProcedure?.Performed;
                        object as_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ar_);
                        return (as_ as CqlQuantity) as object;
                    }
                    else if (aa_())
                    {
                        DataType at_ = HipKneeProcedure?.Performed;
                        object au_ = FHIRHelpers_4_4_000.Instance.ToValue(context, at_);
                        return (au_ as CqlInterval<CqlQuantity>) as object;
                    }
                    else
                    {
                        return null;
                    };
                }

                CqlInterval<CqlDateTime> q_ = QICoreCommon_4_0_000.Instance.toInterval(context, p_());
                CqlDateTime r_ = context.Operators.Start(q_);
                Period s_ = QualifyingEncounter?.Period;
                CqlInterval<CqlDateTime> t_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, s_);
                CqlDateTime u_ = context.Operators.End(t_);
                bool? v_ = context.Operators.SameOrBefore(r_, u_, (string)default);
                bool? w_ = context.Operators.And(o_, v_);
                return w_;
            }

            IEnumerable<Procedure> j_ = context.Operators.Where<Procedure>(h_, i_);
            bool? k_ = context.Operators.Exists<Procedure>(j_);
            return k_;
        }

        IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);
        return c_;
    }


    [CqlExpressionDefinition("Low Risk Indicator For VTE")]
    public IEnumerable<(CqlTupleMetadata, string id, CqlDateTime LowRiskDatetime)?> Low_Risk_Indicator_For_VTE(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Low_Risk_Indicator_For_VTE, Low_Risk_Indicator_For_VTE_Compute);

    private const long _cacheIndex_Low_Risk_Indicator_For_VTE = 7432212982012444353L;

    private IEnumerable<(CqlTupleMetadata, string id, CqlDateTime LowRiskDatetime)?> Low_Risk_Indicator_For_VTE_Compute(CqlContext context)
    {
        CqlCode a_ = this.Risk_for_venous_thromboembolism(context);
        IEnumerable<CqlCode> b_ = context.Operators.ToList<CqlCode>(a_);
        IEnumerable<Observation> c_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, b_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-simple-observation"));

        bool? d_(Observation VTERiskAssessment) {
            DataType as_ = VTERiskAssessment?.Value;
            object at_ = FHIRHelpers_4_4_000.Instance.ToValue(context, as_);
            CqlValueSet au_ = this.Low_Risk(context);
            bool? av_ = context.Operators.ConceptInValueSet(at_ as CqlConcept, au_);
            Code<ObservationStatus> aw_ = VTERiskAssessment?.StatusElement;
            ObservationStatus? ax_ = aw_?.Value;
            string ay_ = context.Operators.Convert<string>(ax_);
            string[] az_ = [
                "final",
                "amended",
                "corrected",
            ];
            bool? ba_ = context.Operators.In<string>(ay_, (IEnumerable<string>)az_);
            bool? bb_ = context.Operators.And(av_, ba_);
            return bb_;
        }

        IEnumerable<Observation> e_ = context.Operators.Where<Observation>(c_, d_);

        (CqlTupleMetadata, string id, CqlDateTime LowRiskDatetime)? f_(Observation VTERiskAssessment) {
            Id bc_ = VTERiskAssessment?.IdElement;
            string bd_ = bc_?.Value;

            object be_() {

                bool bh_() {
                    DataType bk_ = VTERiskAssessment?.Effective;
                    object bl_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bk_);
                    bool bm_ = bl_ is CqlDateTime;
                    return bm_;
                }


                bool bi_() {
                    DataType bn_ = VTERiskAssessment?.Effective;
                    object bo_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bn_);
                    bool bp_ = bo_ is CqlInterval<CqlDateTime>;
                    return bp_;
                }


                bool bj_() {
                    DataType bq_ = VTERiskAssessment?.Effective;
                    object br_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bq_);
                    bool bs_ = br_ is CqlDateTime;
                    return bs_;
                }

                if (bh_())
                {
                    DataType bt_ = VTERiskAssessment?.Effective;
                    object bu_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bt_);
                    return (bu_ as CqlDateTime) as object;
                }
                else if (bi_())
                {
                    DataType bv_ = VTERiskAssessment?.Effective;
                    object bw_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bv_);
                    return (bw_ as CqlInterval<CqlDateTime>) as object;
                }
                else if (bj_())
                {
                    DataType bx_ = VTERiskAssessment?.Effective;
                    object by_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bx_);
                    return (by_ as CqlDateTime) as object;
                }
                else
                {
                    return null;
                };
            }

            CqlDateTime bf_ = QICoreCommon_4_0_000.Instance.earliest(context, be_());
            (CqlTupleMetadata, string id, CqlDateTime LowRiskDatetime)? bg_ = (CqlTupleMetadata_DMAfXNhTfZDWOGdfEceXbfaSJ, bd_, bf_);
            return bg_;
        }

        IEnumerable<(CqlTupleMetadata, string id, CqlDateTime LowRiskDatetime)?> g_ = context.Operators.Select<Observation, (CqlTupleMetadata, string id, CqlDateTime LowRiskDatetime)?>(e_, f_);
        IEnumerable<(CqlTupleMetadata, string id, CqlDateTime LowRiskDatetime)?> h_ = context.Operators.Distinct<(CqlTupleMetadata, string id, CqlDateTime LowRiskDatetime)?>(g_);
        CqlValueSet i_ = this.INR(context);
        IEnumerable<Observation> j_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, i_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation-lab"));

        bool? k_(Observation INRLabTest) {
            DataType bz_ = INRLabTest?.Value;
            object ca_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bz_);
            CqlQuantity cb_ = context.Operators.ConvertDecimalToQuantity(3.0m);
            bool? cc_ = context.Operators.Greater(ca_ as CqlQuantity, cb_);
            Code<ObservationStatus> cd_ = INRLabTest?.StatusElement;
            ObservationStatus? ce_ = cd_?.Value;
            string cf_ = context.Operators.Convert<string>(ce_);
            string[] cg_ = [
                "final",
                "amended",
                "corrected",
            ];
            bool? ch_ = context.Operators.In<string>(cf_, (IEnumerable<string>)cg_);
            bool? ci_ = context.Operators.And(cc_, ch_);
            return ci_;
        }

        IEnumerable<Observation> l_ = context.Operators.Where<Observation>(j_, k_);

        (CqlTupleMetadata, string id, CqlDateTime LowRiskDatetime)? m_(Observation INRLabTest) {
            Id cj_ = INRLabTest?.IdElement;
            string ck_ = cj_?.Value;
            Instant cl_ = INRLabTest?.IssuedElement;
            DateTimeOffset? cm_ = cl_?.Value;
            CqlDateTime cn_ = context.Operators.Convert<CqlDateTime>(cm_);
            (CqlTupleMetadata, string id, CqlDateTime LowRiskDatetime)? co_ = (CqlTupleMetadata_DMAfXNhTfZDWOGdfEceXbfaSJ, ck_, cn_);
            return co_;
        }

        IEnumerable<(CqlTupleMetadata, string id, CqlDateTime LowRiskDatetime)?> n_ = context.Operators.Select<Observation, (CqlTupleMetadata, string id, CqlDateTime LowRiskDatetime)?>(l_, m_);
        IEnumerable<(CqlTupleMetadata, string id, CqlDateTime LowRiskDatetime)?> o_ = context.Operators.Distinct<(CqlTupleMetadata, string id, CqlDateTime LowRiskDatetime)?>(n_);
        IEnumerable<(CqlTupleMetadata, string id, CqlDateTime LowRiskDatetime)?> p_ = context.Operators.Union<(CqlTupleMetadata, string id, CqlDateTime LowRiskDatetime)?>(h_, o_);
        CqlValueSet q_ = this.Unfractionated_Heparin(context);
        IEnumerable<MedicationAdministration> r_ = context.Operators.Retrieve<MedicationAdministration>(new RetrieveParameters(default, q_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationadministration"));
        IEnumerable<MedicationAdministration> s_ = context.Operators.Retrieve<MedicationAdministration>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationadministration"));

        bool? t_(MedicationAdministration MR) {
            IEnumerable<Medication> cp_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));

            bool? cq_(Medication M) {
                object ct_ = context.Operators.LateBoundProperty<object>(M, "id.value");
                object cu_ = context.Operators.LateBoundProperty<object>(MR, "medication.reference.value");
                IEnumerable<string> cv_ = context.Operators.Split((string)cu_, "/");
                string cw_ = context.Operators.Last<string>(cv_);
                bool? cx_ = context.Operators.Equal(ct_, cw_);
                CodeableConcept cy_ = M?.Code;
                CqlConcept cz_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, cy_);
                CqlValueSet da_ = this.Unfractionated_Heparin(context);
                bool? db_ = context.Operators.ConceptInValueSet(cz_, da_);
                bool? dc_ = context.Operators.And(cx_, db_);
                return dc_;
            }

            IEnumerable<Medication> cr_ = context.Operators.Where<Medication>(cp_, cq_);
            bool? cs_ = context.Operators.Exists<Medication>(cr_);
            return cs_;
        }

        IEnumerable<MedicationAdministration> u_ = context.Operators.Where<MedicationAdministration>(s_, t_);
        IEnumerable<MedicationAdministration> v_ = context.Operators.Union<MedicationAdministration>(r_, u_);

        bool? w_(MedicationAdministration UnfractionatedHeparin) {
            MedicationAdministration.DosageComponent dd_ = UnfractionatedHeparin?.Dosage;
            CodeableConcept de_ = dd_?.Route;
            CqlConcept df_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, de_);
            CqlValueSet dg_ = this.Intravenous_route(context);
            bool? dh_ = context.Operators.ConceptInValueSet(df_, dg_);
            return dh_;
        }

        IEnumerable<MedicationAdministration> x_ = context.Operators.Where<MedicationAdministration>(v_, w_);
        CqlValueSet y_ = this.Direct_Thrombin_Inhibitor(context);
        IEnumerable<MedicationAdministration> z_ = context.Operators.Retrieve<MedicationAdministration>(new RetrieveParameters(default, y_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationadministration"));

        bool? ab_(MedicationAdministration MR) {
            IEnumerable<Medication> di_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));

            bool? dj_(Medication M) {
                object dm_ = context.Operators.LateBoundProperty<object>(M, "id.value");
                object dn_ = context.Operators.LateBoundProperty<object>(MR, "medication.reference.value");
                IEnumerable<string> do_ = context.Operators.Split((string)dn_, "/");
                string dp_ = context.Operators.Last<string>(do_);
                bool? dq_ = context.Operators.Equal(dm_, dp_);
                CodeableConcept dr_ = M?.Code;
                CqlConcept ds_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, dr_);
                CqlValueSet dt_ = this.Direct_Thrombin_Inhibitor(context);
                bool? du_ = context.Operators.ConceptInValueSet(ds_, dt_);
                bool? dv_ = context.Operators.And(dq_, du_);
                return dv_;
            }

            IEnumerable<Medication> dk_ = context.Operators.Where<Medication>(di_, dj_);
            bool? dl_ = context.Operators.Exists<Medication>(dk_);
            return dl_;
        }

        IEnumerable<MedicationAdministration> ac_ = context.Operators.Where<MedicationAdministration>(s_, ab_);
        IEnumerable<MedicationAdministration> ad_ = context.Operators.Union<MedicationAdministration>(z_, ac_);
        IEnumerable<MedicationAdministration> ae_ = context.Operators.Union<MedicationAdministration>(x_, ad_);
        CqlValueSet af_ = this.Glycoprotein_IIb_IIIa_Inhibitors(context);
        IEnumerable<MedicationAdministration> ag_ = context.Operators.Retrieve<MedicationAdministration>(new RetrieveParameters(default, af_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationadministration"));

        bool? ai_(MedicationAdministration MR) {
            IEnumerable<Medication> dw_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));

            bool? dx_(Medication M) {
                object ea_ = context.Operators.LateBoundProperty<object>(M, "id.value");
                object eb_ = context.Operators.LateBoundProperty<object>(MR, "medication.reference.value");
                IEnumerable<string> ec_ = context.Operators.Split((string)eb_, "/");
                string ed_ = context.Operators.Last<string>(ec_);
                bool? ee_ = context.Operators.Equal(ea_, ed_);
                CodeableConcept ef_ = M?.Code;
                CqlConcept eg_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, ef_);
                CqlValueSet eh_ = this.Glycoprotein_IIb_IIIa_Inhibitors(context);
                bool? ei_ = context.Operators.ConceptInValueSet(eg_, eh_);
                bool? ej_ = context.Operators.And(ee_, ei_);
                return ej_;
            }

            IEnumerable<Medication> dy_ = context.Operators.Where<Medication>(dw_, dx_);
            bool? dz_ = context.Operators.Exists<Medication>(dy_);
            return dz_;
        }

        IEnumerable<MedicationAdministration> aj_ = context.Operators.Where<MedicationAdministration>(s_, ai_);
        IEnumerable<MedicationAdministration> ak_ = context.Operators.Union<MedicationAdministration>(ag_, aj_);
        IEnumerable<MedicationAdministration> al_ = context.Operators.Union<MedicationAdministration>(ae_, ak_);

        bool? am_(MedicationAdministration AnticoagulantMedication) {
            Code<MedicationAdministration.MedicationAdministrationStatusCodes> ek_ = AnticoagulantMedication?.StatusElement;
            MedicationAdministration.MedicationAdministrationStatusCodes? el_ = ek_?.Value;
            string em_ = context.Operators.Convert<string>(el_);
            bool? en_ = context.Operators.Equal(em_, "completed");
            return en_;
        }

        IEnumerable<MedicationAdministration> an_ = context.Operators.Where<MedicationAdministration>(al_, am_);

        (CqlTupleMetadata, string id, CqlDateTime LowRiskDatetime)? ao_(MedicationAdministration AnticoagulantMedication) {
            Id eo_ = AnticoagulantMedication?.IdElement;
            string ep_ = eo_?.Value;
            DataType eq_ = AnticoagulantMedication?.Effective;
            object er_ = FHIRHelpers_4_4_000.Instance.ToValue(context, eq_);
            CqlInterval<CqlDateTime> es_ = QICoreCommon_4_0_000.Instance.toInterval(context, er_);
            CqlDateTime et_ = context.Operators.Start(es_);
            (CqlTupleMetadata, string id, CqlDateTime LowRiskDatetime)? eu_ = (CqlTupleMetadata_DMAfXNhTfZDWOGdfEceXbfaSJ, ep_, et_);
            return eu_;
        }

        IEnumerable<(CqlTupleMetadata, string id, CqlDateTime LowRiskDatetime)?> ap_ = context.Operators.Select<MedicationAdministration, (CqlTupleMetadata, string id, CqlDateTime LowRiskDatetime)?>(an_, ao_);
        IEnumerable<(CqlTupleMetadata, string id, CqlDateTime LowRiskDatetime)?> aq_ = context.Operators.Distinct<(CqlTupleMetadata, string id, CqlDateTime LowRiskDatetime)?>(ap_);
        IEnumerable<(CqlTupleMetadata, string id, CqlDateTime LowRiskDatetime)?> ar_ = context.Operators.Union<(CqlTupleMetadata, string id, CqlDateTime LowRiskDatetime)?>(p_, aq_);
        return ar_;
    }


    [CqlExpressionDefinition("Low Risk For VTE Or Anticoagulant Administered From Day Of Start Of Hospitalization To Day After Admission")]
    public IEnumerable<Encounter> Low_Risk_For_VTE_Or_Anticoagulant_Administered_From_Day_Of_Start_Of_Hospitalization_To_Day_After_Admission(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Low_Risk_For_VTE_Or_Anticoagulant_Administered_From_Day_Of_Start_Of_Hospitalization_To_Day_After_Admission, Low_Risk_For_VTE_Or_Anticoagulant_Administered_From_Day_Of_Start_Of_Hospitalization_To_Day_After_Admission_Compute);

    private const long _cacheIndex_Low_Risk_For_VTE_Or_Anticoagulant_Administered_From_Day_Of_Start_Of_Hospitalization_To_Day_After_Admission = -1276415537838813909L;

    private IEnumerable<Encounter> Low_Risk_For_VTE_Or_Anticoagulant_Administered_From_Day_Of_Start_Of_Hospitalization_To_Day_After_Admission_Compute(CqlContext context)
    {
        IEnumerable<Encounter> a_ = VTE_8_18_000.Instance.Encounter_With_Age_Range_And_Without_VTE_Diagnosis_Or_Obstetrical_Conditions(context);

        bool? b_(Encounter QualifyingEncounter) {
            IEnumerable<(CqlTupleMetadata, string id, CqlDateTime LowRiskDatetime)?> d_ = this.Low_Risk_Indicator_For_VTE(context);

            bool? e_((CqlTupleMetadata, string id, CqlDateTime LowRiskDatetime)? LowRiskForVTE) {
                CqlDateTime h_ = LowRiskForVTE?.LowRiskDatetime;
                CqlInterval<CqlDate> i_ = this.fromDayOfStartOfHospitalizationToDayAfterAdmission(context, QualifyingEncounter);
                CqlDate j_ = i_?.low;
                CqlDateTime k_ = context.Operators.ConvertDateToDateTime(j_);
                CqlDate m_ = i_?.high;
                CqlDateTime n_ = context.Operators.ConvertDateToDateTime(m_);
                bool? p_ = i_?.lowClosed;
                bool? r_ = i_?.highClosed;
                CqlInterval<CqlDateTime> s_ = context.Operators.Interval(k_, n_, p_, r_);
                bool? t_ = context.Operators.In<CqlDateTime>(h_, s_, "day");
                return t_;
            }

            IEnumerable<(CqlTupleMetadata, string id, CqlDateTime LowRiskDatetime)?> f_ = context.Operators.Where<(CqlTupleMetadata, string id, CqlDateTime LowRiskDatetime)?>(d_, e_);
            bool? g_ = context.Operators.Exists<(CqlTupleMetadata, string id, CqlDateTime LowRiskDatetime)?>(f_);
            return g_;
        }

        IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);
        return c_;
    }


    [CqlExpressionDefinition("Low Risk For VTE Or Anticoagulant Administered On Day Of Or Day After Procedure")]
    public IEnumerable<Encounter> Low_Risk_For_VTE_Or_Anticoagulant_Administered_On_Day_Of_Or_Day_After_Procedure(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Low_Risk_For_VTE_Or_Anticoagulant_Administered_On_Day_Of_Or_Day_After_Procedure, Low_Risk_For_VTE_Or_Anticoagulant_Administered_On_Day_Of_Or_Day_After_Procedure_Compute);

    private const long _cacheIndex_Low_Risk_For_VTE_Or_Anticoagulant_Administered_On_Day_Of_Or_Day_After_Procedure = -7257647458643896672L;

    private IEnumerable<Encounter> Low_Risk_For_VTE_Or_Anticoagulant_Administered_On_Day_Of_Or_Day_After_Procedure_Compute(CqlContext context)
    {
        IEnumerable<Encounter> a_ = VTE_8_18_000.Instance.Encounter_With_Age_Range_And_Without_VTE_Diagnosis_Or_Obstetrical_Conditions(context);
        CqlValueSet b_ = this.General_or_Neuraxial_Anesthesia(context);
        IEnumerable<Procedure> c_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, b_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
        IEnumerable<(CqlTupleMetadata, string id, CqlDateTime LowRiskDatetime)?> d_ = this.Low_Risk_Indicator_For_VTE(context);
        IEnumerable<ValueTuple<Encounter, Procedure, (CqlTupleMetadata, string id, CqlDateTime LowRiskDatetime)?>> e_ = context.Operators.CrossJoin<Encounter, Procedure, (CqlTupleMetadata, string id, CqlDateTime LowRiskDatetime)?>(a_, c_, d_);

        (CqlTupleMetadata, Encounter QualifyingEncounter, Procedure AnesthesiaProcedure, (CqlTupleMetadata, string id, CqlDateTime LowRiskDatetime)? LowRiskForVTE)? f_(ValueTuple<Encounter, Procedure, (CqlTupleMetadata, string id, CqlDateTime LowRiskDatetime)?> _valueTuple) {
            (CqlTupleMetadata, Encounter QualifyingEncounter, Procedure AnesthesiaProcedure, (CqlTupleMetadata, string id, CqlDateTime LowRiskDatetime)? LowRiskForVTE)? m_ = (CqlTupleMetadata_EXZJZNMEfWVgYEZWEbGcSARAD, _valueTuple.Item1, _valueTuple.Item2, _valueTuple.Item3);
            return m_;
        }

        IEnumerable<(CqlTupleMetadata, Encounter QualifyingEncounter, Procedure AnesthesiaProcedure, (CqlTupleMetadata, string id, CqlDateTime LowRiskDatetime)? LowRiskForVTE)?> g_ = context.Operators.Select<ValueTuple<Encounter, Procedure, (CqlTupleMetadata, string id, CqlDateTime LowRiskDatetime)?>, (CqlTupleMetadata, Encounter QualifyingEncounter, Procedure AnesthesiaProcedure, (CqlTupleMetadata, string id, CqlDateTime LowRiskDatetime)? LowRiskForVTE)?>(e_, f_);

        bool? h_((CqlTupleMetadata, Encounter QualifyingEncounter, Procedure AnesthesiaProcedure, (CqlTupleMetadata, string id, CqlDateTime LowRiskDatetime)? LowRiskForVTE)? tuple_gwhjghwetinfdseedvamgjivv) {
            Code<EventStatus> n_ = tuple_gwhjghwetinfdseedvamgjivv?.AnesthesiaProcedure?.StatusElement;
            EventStatus? o_ = n_?.Value;
            string p_ = context.Operators.Convert<string>(o_);
            bool? q_ = context.Operators.Equal(p_, "completed");

            object r_() {

                bool bb_() {
                    DataType bf_ = tuple_gwhjghwetinfdseedvamgjivv?.AnesthesiaProcedure?.Performed;
                    object bg_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bf_);
                    bool bh_ = bg_ is CqlDateTime;
                    return bh_;
                }


                bool bc_() {
                    DataType bi_ = tuple_gwhjghwetinfdseedvamgjivv?.AnesthesiaProcedure?.Performed;
                    object bj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bi_);
                    bool bk_ = bj_ is CqlInterval<CqlDateTime>;
                    return bk_;
                }


                bool bd_() {
                    DataType bl_ = tuple_gwhjghwetinfdseedvamgjivv?.AnesthesiaProcedure?.Performed;
                    object bm_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bl_);
                    bool bn_ = bm_ is CqlQuantity;
                    return bn_;
                }


                bool be_() {
                    DataType bo_ = tuple_gwhjghwetinfdseedvamgjivv?.AnesthesiaProcedure?.Performed;
                    object bp_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bo_);
                    bool bq_ = bp_ is CqlInterval<CqlQuantity>;
                    return bq_;
                }

                if (bb_())
                {
                    DataType br_ = tuple_gwhjghwetinfdseedvamgjivv?.AnesthesiaProcedure?.Performed;
                    object bs_ = FHIRHelpers_4_4_000.Instance.ToValue(context, br_);
                    return (bs_ as CqlDateTime) as object;
                }
                else if (bc_())
                {
                    DataType bt_ = tuple_gwhjghwetinfdseedvamgjivv?.AnesthesiaProcedure?.Performed;
                    object bu_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bt_);
                    return (bu_ as CqlInterval<CqlDateTime>) as object;
                }
                else if (bd_())
                {
                    DataType bv_ = tuple_gwhjghwetinfdseedvamgjivv?.AnesthesiaProcedure?.Performed;
                    object bw_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bv_);
                    return (bw_ as CqlQuantity) as object;
                }
                else if (be_())
                {
                    DataType bx_ = tuple_gwhjghwetinfdseedvamgjivv?.AnesthesiaProcedure?.Performed;
                    object by_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bx_);
                    return (by_ as CqlInterval<CqlQuantity>) as object;
                }
                else
                {
                    return null;
                };
            }

            CqlInterval<CqlDateTime> s_ = QICoreCommon_4_0_000.Instance.toInterval(context, r_());
            CqlDateTime t_ = context.Operators.End(s_);
            Period u_ = tuple_gwhjghwetinfdseedvamgjivv?.QualifyingEncounter?.Period;
            CqlInterval<CqlDateTime> v_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, u_);
            CqlDateTime w_ = context.Operators.Start(v_);
            CqlQuantity x_ = context.Operators.Quantity(1m, "day");
            CqlDateTime y_ = context.Operators.Add(w_, x_);
            bool? z_ = context.Operators.SameAs(t_, y_, "day");
            bool? aa_ = context.Operators.And(q_, z_);
            CqlDateTime ab_ = tuple_gwhjghwetinfdseedvamgjivv?.LowRiskForVTE?.LowRiskDatetime;

            object ac_() {

                bool bz_() {
                    DataType cd_ = tuple_gwhjghwetinfdseedvamgjivv?.AnesthesiaProcedure?.Performed;
                    object ce_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cd_);
                    bool cf_ = ce_ is CqlDateTime;
                    return cf_;
                }


                bool ca_() {
                    DataType cg_ = tuple_gwhjghwetinfdseedvamgjivv?.AnesthesiaProcedure?.Performed;
                    object ch_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cg_);
                    bool ci_ = ch_ is CqlInterval<CqlDateTime>;
                    return ci_;
                }


                bool cb_() {
                    DataType cj_ = tuple_gwhjghwetinfdseedvamgjivv?.AnesthesiaProcedure?.Performed;
                    object ck_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cj_);
                    bool cl_ = ck_ is CqlQuantity;
                    return cl_;
                }


                bool cc_() {
                    DataType cm_ = tuple_gwhjghwetinfdseedvamgjivv?.AnesthesiaProcedure?.Performed;
                    object cn_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cm_);
                    bool co_ = cn_ is CqlInterval<CqlQuantity>;
                    return co_;
                }

                if (bz_())
                {
                    DataType cp_ = tuple_gwhjghwetinfdseedvamgjivv?.AnesthesiaProcedure?.Performed;
                    object cq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cp_);
                    return (cq_ as CqlDateTime) as object;
                }
                else if (ca_())
                {
                    DataType cr_ = tuple_gwhjghwetinfdseedvamgjivv?.AnesthesiaProcedure?.Performed;
                    object cs_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cr_);
                    return (cs_ as CqlInterval<CqlDateTime>) as object;
                }
                else if (cb_())
                {
                    DataType ct_ = tuple_gwhjghwetinfdseedvamgjivv?.AnesthesiaProcedure?.Performed;
                    object cu_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ct_);
                    return (cu_ as CqlQuantity) as object;
                }
                else if (cc_())
                {
                    DataType cv_ = tuple_gwhjghwetinfdseedvamgjivv?.AnesthesiaProcedure?.Performed;
                    object cw_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cv_);
                    return (cw_ as CqlInterval<CqlQuantity>) as object;
                }
                else
                {
                    return null;
                };
            }

            CqlInterval<CqlDateTime> ad_ = QICoreCommon_4_0_000.Instance.toInterval(context, ac_());
            CqlDateTime ae_ = context.Operators.End(ad_);
            CqlInterval<CqlDate> af_ = TJCOverall_8_25_000.Instance.calendarDayOfOrDayAfter(context, ae_);
            CqlDate ag_ = af_?.low;
            CqlDateTime ah_ = context.Operators.ConvertDateToDateTime(ag_);

            object ai_() {

                bool cx_() {
                    DataType db_ = tuple_gwhjghwetinfdseedvamgjivv?.AnesthesiaProcedure?.Performed;
                    object dc_ = FHIRHelpers_4_4_000.Instance.ToValue(context, db_);
                    bool dd_ = dc_ is CqlDateTime;
                    return dd_;
                }


                bool cy_() {
                    DataType de_ = tuple_gwhjghwetinfdseedvamgjivv?.AnesthesiaProcedure?.Performed;
                    object df_ = FHIRHelpers_4_4_000.Instance.ToValue(context, de_);
                    bool dg_ = df_ is CqlInterval<CqlDateTime>;
                    return dg_;
                }


                bool cz_() {
                    DataType dh_ = tuple_gwhjghwetinfdseedvamgjivv?.AnesthesiaProcedure?.Performed;
                    object di_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dh_);
                    bool dj_ = di_ is CqlQuantity;
                    return dj_;
                }


                bool da_() {
                    DataType dk_ = tuple_gwhjghwetinfdseedvamgjivv?.AnesthesiaProcedure?.Performed;
                    object dl_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dk_);
                    bool dm_ = dl_ is CqlInterval<CqlQuantity>;
                    return dm_;
                }

                if (cx_())
                {
                    DataType dn_ = tuple_gwhjghwetinfdseedvamgjivv?.AnesthesiaProcedure?.Performed;
                    object do_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dn_);
                    return (do_ as CqlDateTime) as object;
                }
                else if (cy_())
                {
                    DataType dp_ = tuple_gwhjghwetinfdseedvamgjivv?.AnesthesiaProcedure?.Performed;
                    object dq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dp_);
                    return (dq_ as CqlInterval<CqlDateTime>) as object;
                }
                else if (cz_())
                {
                    DataType dr_ = tuple_gwhjghwetinfdseedvamgjivv?.AnesthesiaProcedure?.Performed;
                    object ds_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dr_);
                    return (ds_ as CqlQuantity) as object;
                }
                else if (da_())
                {
                    DataType dt_ = tuple_gwhjghwetinfdseedvamgjivv?.AnesthesiaProcedure?.Performed;
                    object du_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dt_);
                    return (du_ as CqlInterval<CqlQuantity>) as object;
                }
                else
                {
                    return null;
                };
            }

            CqlInterval<CqlDateTime> aj_ = QICoreCommon_4_0_000.Instance.toInterval(context, ai_());
            CqlDateTime ak_ = context.Operators.End(aj_);
            CqlInterval<CqlDate> al_ = TJCOverall_8_25_000.Instance.calendarDayOfOrDayAfter(context, ak_);
            CqlDate am_ = al_?.high;
            CqlDateTime an_ = context.Operators.ConvertDateToDateTime(am_);

            object ao_() {

                bool dv_() {
                    DataType dz_ = tuple_gwhjghwetinfdseedvamgjivv?.AnesthesiaProcedure?.Performed;
                    object ea_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dz_);
                    bool eb_ = ea_ is CqlDateTime;
                    return eb_;
                }


                bool dw_() {
                    DataType ec_ = tuple_gwhjghwetinfdseedvamgjivv?.AnesthesiaProcedure?.Performed;
                    object ed_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ec_);
                    bool ee_ = ed_ is CqlInterval<CqlDateTime>;
                    return ee_;
                }


                bool dx_() {
                    DataType ef_ = tuple_gwhjghwetinfdseedvamgjivv?.AnesthesiaProcedure?.Performed;
                    object eg_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ef_);
                    bool eh_ = eg_ is CqlQuantity;
                    return eh_;
                }


                bool dy_() {
                    DataType ei_ = tuple_gwhjghwetinfdseedvamgjivv?.AnesthesiaProcedure?.Performed;
                    object ej_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ei_);
                    bool ek_ = ej_ is CqlInterval<CqlQuantity>;
                    return ek_;
                }

                if (dv_())
                {
                    DataType el_ = tuple_gwhjghwetinfdseedvamgjivv?.AnesthesiaProcedure?.Performed;
                    object em_ = FHIRHelpers_4_4_000.Instance.ToValue(context, el_);
                    return (em_ as CqlDateTime) as object;
                }
                else if (dw_())
                {
                    DataType en_ = tuple_gwhjghwetinfdseedvamgjivv?.AnesthesiaProcedure?.Performed;
                    object eo_ = FHIRHelpers_4_4_000.Instance.ToValue(context, en_);
                    return (eo_ as CqlInterval<CqlDateTime>) as object;
                }
                else if (dx_())
                {
                    DataType ep_ = tuple_gwhjghwetinfdseedvamgjivv?.AnesthesiaProcedure?.Performed;
                    object eq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ep_);
                    return (eq_ as CqlQuantity) as object;
                }
                else if (dy_())
                {
                    DataType er_ = tuple_gwhjghwetinfdseedvamgjivv?.AnesthesiaProcedure?.Performed;
                    object es_ = FHIRHelpers_4_4_000.Instance.ToValue(context, er_);
                    return (es_ as CqlInterval<CqlQuantity>) as object;
                }
                else
                {
                    return null;
                };
            }

            CqlInterval<CqlDateTime> ap_ = QICoreCommon_4_0_000.Instance.toInterval(context, ao_());
            CqlDateTime aq_ = context.Operators.End(ap_);
            CqlInterval<CqlDate> ar_ = TJCOverall_8_25_000.Instance.calendarDayOfOrDayAfter(context, aq_);
            bool? as_ = ar_?.lowClosed;

            object at_() {

                bool et_() {
                    DataType ex_ = tuple_gwhjghwetinfdseedvamgjivv?.AnesthesiaProcedure?.Performed;
                    object ey_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ex_);
                    bool ez_ = ey_ is CqlDateTime;
                    return ez_;
                }


                bool eu_() {
                    DataType fa_ = tuple_gwhjghwetinfdseedvamgjivv?.AnesthesiaProcedure?.Performed;
                    object fb_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fa_);
                    bool fc_ = fb_ is CqlInterval<CqlDateTime>;
                    return fc_;
                }


                bool ev_() {
                    DataType fd_ = tuple_gwhjghwetinfdseedvamgjivv?.AnesthesiaProcedure?.Performed;
                    object fe_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fd_);
                    bool ff_ = fe_ is CqlQuantity;
                    return ff_;
                }


                bool ew_() {
                    DataType fg_ = tuple_gwhjghwetinfdseedvamgjivv?.AnesthesiaProcedure?.Performed;
                    object fh_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fg_);
                    bool fi_ = fh_ is CqlInterval<CqlQuantity>;
                    return fi_;
                }

                if (et_())
                {
                    DataType fj_ = tuple_gwhjghwetinfdseedvamgjivv?.AnesthesiaProcedure?.Performed;
                    object fk_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fj_);
                    return (fk_ as CqlDateTime) as object;
                }
                else if (eu_())
                {
                    DataType fl_ = tuple_gwhjghwetinfdseedvamgjivv?.AnesthesiaProcedure?.Performed;
                    object fm_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fl_);
                    return (fm_ as CqlInterval<CqlDateTime>) as object;
                }
                else if (ev_())
                {
                    DataType fn_ = tuple_gwhjghwetinfdseedvamgjivv?.AnesthesiaProcedure?.Performed;
                    object fo_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fn_);
                    return (fo_ as CqlQuantity) as object;
                }
                else if (ew_())
                {
                    DataType fp_ = tuple_gwhjghwetinfdseedvamgjivv?.AnesthesiaProcedure?.Performed;
                    object fq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fp_);
                    return (fq_ as CqlInterval<CqlQuantity>) as object;
                }
                else
                {
                    return null;
                };
            }

            CqlInterval<CqlDateTime> au_ = QICoreCommon_4_0_000.Instance.toInterval(context, at_());
            CqlDateTime av_ = context.Operators.End(au_);
            CqlInterval<CqlDate> aw_ = TJCOverall_8_25_000.Instance.calendarDayOfOrDayAfter(context, av_);
            bool? ax_ = aw_?.highClosed;
            CqlInterval<CqlDateTime> ay_ = context.Operators.Interval(ah_, an_, as_, ax_);
            bool? az_ = context.Operators.In<CqlDateTime>(ab_, ay_, "day");
            bool? ba_ = context.Operators.And(aa_, az_);
            return ba_;
        }

        IEnumerable<(CqlTupleMetadata, Encounter QualifyingEncounter, Procedure AnesthesiaProcedure, (CqlTupleMetadata, string id, CqlDateTime LowRiskDatetime)? LowRiskForVTE)?> i_ = context.Operators.Where<(CqlTupleMetadata, Encounter QualifyingEncounter, Procedure AnesthesiaProcedure, (CqlTupleMetadata, string id, CqlDateTime LowRiskDatetime)? LowRiskForVTE)?>(g_, h_);
        Encounter j_((CqlTupleMetadata, Encounter QualifyingEncounter, Procedure AnesthesiaProcedure, (CqlTupleMetadata, string id, CqlDateTime LowRiskDatetime)? LowRiskForVTE)? tuple_gwhjghwetinfdseedvamgjivv) => tuple_gwhjghwetinfdseedvamgjivv?.QualifyingEncounter;
        IEnumerable<Encounter> k_ = context.Operators.Select<(CqlTupleMetadata, Encounter QualifyingEncounter, Procedure AnesthesiaProcedure, (CqlTupleMetadata, string id, CqlDateTime LowRiskDatetime)? LowRiskForVTE)?, Encounter>(i_, j_);
        IEnumerable<Encounter> l_ = context.Operators.Distinct<Encounter>(k_);
        return l_;
    }


    [CqlExpressionDefinition("Encounter With Low Risk For VTE Or Anticoagulant Administered")]
    public IEnumerable<Encounter> Encounter_With_Low_Risk_For_VTE_Or_Anticoagulant_Administered(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Encounter_With_Low_Risk_For_VTE_Or_Anticoagulant_Administered, Encounter_With_Low_Risk_For_VTE_Or_Anticoagulant_Administered_Compute);

    private const long _cacheIndex_Encounter_With_Low_Risk_For_VTE_Or_Anticoagulant_Administered = -2696940728686299074L;

    private IEnumerable<Encounter> Encounter_With_Low_Risk_For_VTE_Or_Anticoagulant_Administered_Compute(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Low_Risk_For_VTE_Or_Anticoagulant_Administered_From_Day_Of_Start_Of_Hospitalization_To_Day_After_Admission(context);
        IEnumerable<Encounter> b_ = this.Low_Risk_For_VTE_Or_Anticoagulant_Administered_On_Day_Of_Or_Day_After_Procedure(context);
        IEnumerable<Encounter> c_ = context.Operators.Union<Encounter>(a_, b_);
        return c_;
    }


    [CqlExpressionDefinition("No VTE Prophylaxis Medication Administered Or Ordered")]
    public IEnumerable<(CqlTupleMetadata, string id, IEnumerable<CqlConcept> medicationStatusReason, CqlDateTime authoredOn)?> No_VTE_Prophylaxis_Medication_Administered_Or_Ordered(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_No_VTE_Prophylaxis_Medication_Administered_Or_Ordered, No_VTE_Prophylaxis_Medication_Administered_Or_Ordered_Compute);

    private const long _cacheIndex_No_VTE_Prophylaxis_Medication_Administered_Or_Ordered = 8768742085925212938L;

    private IEnumerable<(CqlTupleMetadata, string id, IEnumerable<CqlConcept> medicationStatusReason, CqlDateTime authoredOn)?> No_VTE_Prophylaxis_Medication_Administered_Or_Ordered_Compute(CqlContext context)
    {
        CqlValueSet a_ = this.Low_Dose_Unfractionated_Heparin_for_VTE_Prophylaxis(context);
        IEnumerable<MedicationAdministration> b_ = context.Operators.Retrieve<MedicationAdministration>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationadministrationnotdone"));
        IEnumerable<MedicationAdministration> d_ = context.Operators.Retrieve<MedicationAdministration>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationadministrationnotdone"));
        IEnumerable<MedicationAdministration> e_ = context.Operators.Union<MedicationAdministration>(b_, d_);
        CqlValueSet f_ = this.Low_Molecular_Weight_Heparin_for_VTE_Prophylaxis(context);
        IEnumerable<MedicationAdministration> g_ = context.Operators.Retrieve<MedicationAdministration>(new RetrieveParameters(default, f_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationadministrationnotdone"));
        IEnumerable<MedicationAdministration> i_ = context.Operators.Retrieve<MedicationAdministration>(new RetrieveParameters(default, f_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationadministrationnotdone"));
        IEnumerable<MedicationAdministration> j_ = context.Operators.Union<MedicationAdministration>(g_, i_);
        IEnumerable<MedicationAdministration> k_ = context.Operators.Union<MedicationAdministration>(e_, j_);
        CqlValueSet l_ = this.Injectable_Factor_Xa_Inhibitor_for_VTE_Prophylaxis(context);
        IEnumerable<MedicationAdministration> m_ = context.Operators.Retrieve<MedicationAdministration>(new RetrieveParameters(default, l_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationadministrationnotdone"));
        IEnumerable<MedicationAdministration> o_ = context.Operators.Retrieve<MedicationAdministration>(new RetrieveParameters(default, l_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationadministrationnotdone"));
        IEnumerable<MedicationAdministration> p_ = context.Operators.Union<MedicationAdministration>(m_, o_);
        IEnumerable<MedicationAdministration> q_ = context.Operators.Union<MedicationAdministration>(k_, p_);
        CqlValueSet r_ = this.Warfarin(context);
        IEnumerable<MedicationAdministration> s_ = context.Operators.Retrieve<MedicationAdministration>(new RetrieveParameters(default, r_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationadministrationnotdone"));
        IEnumerable<MedicationAdministration> u_ = context.Operators.Retrieve<MedicationAdministration>(new RetrieveParameters(default, r_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationadministrationnotdone"));
        IEnumerable<MedicationAdministration> v_ = context.Operators.Union<MedicationAdministration>(s_, u_);
        IEnumerable<MedicationAdministration> w_ = context.Operators.Union<MedicationAdministration>(q_, v_);
        CqlValueSet x_ = this.Rivaroxaban_for_VTE_Prophylaxis(context);
        IEnumerable<MedicationAdministration> y_ = context.Operators.Retrieve<MedicationAdministration>(new RetrieveParameters(default, x_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationadministrationnotdone"));
        IEnumerable<MedicationAdministration> aa_ = context.Operators.Retrieve<MedicationAdministration>(new RetrieveParameters(default, x_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationadministrationnotdone"));
        IEnumerable<MedicationAdministration> ab_ = context.Operators.Union<MedicationAdministration>(y_, aa_);
        IEnumerable<MedicationAdministration> ac_ = context.Operators.Union<MedicationAdministration>(w_, ab_);

        (CqlTupleMetadata, string id, IEnumerable<CqlConcept> medicationStatusReason, FhirDateTime authoredOn)? ad_(MedicationAdministration NoMedicationAdm) {
            Id dj_ = NoMedicationAdm?.IdElement;
            string dk_ = dj_?.Value;
            List<CodeableConcept> dl_ = NoMedicationAdm?.StatusReason;

            CqlConcept dm_(CodeableConcept @this) {
                CqlConcept dv_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);
                return dv_;
            }

            IEnumerable<CqlConcept> dn_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)dl_, dm_);

            bool? do_(Extension @this) {
                FhirUri dw_ = @this?.UrlElement;
                string dx_ = FHIRHelpers_4_4_000.Instance.ToString(context, dw_);
                bool? dy_ = context.Operators.Equal(dx_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-recorded");
                return dy_;
            }

            IEnumerable<Extension> dp_ = context.Operators.Where<Extension>((IEnumerable<Extension>)(NoMedicationAdm is DomainResource
                ? (NoMedicationAdm as DomainResource).Extension
                : default), do_);

            DataType dq_(Extension @this) {
                DataType dz_ = @this?.Value;
                return dz_;
            }

            IEnumerable<DataType> dr_ = context.Operators.Select<Extension, DataType>(dp_, dq_);
            DataType ds_ = context.Operators.SingletonFrom<DataType>(dr_);
            FhirDateTime dt_ = context.Operators.Convert<FhirDateTime>(ds_);
            (CqlTupleMetadata, string id, IEnumerable<CqlConcept> medicationStatusReason, FhirDateTime authoredOn)? du_ = (CqlTupleMetadata_EBcSahXYZdeFjUUbgULReCZAe, dk_, dn_, dt_);
            return du_;
        }

        IEnumerable<(CqlTupleMetadata, string id, IEnumerable<CqlConcept> medicationStatusReason, FhirDateTime authoredOn)?> ae_ = context.Operators.Select<MedicationAdministration, (CqlTupleMetadata, string id, IEnumerable<CqlConcept> medicationStatusReason, FhirDateTime authoredOn)?>(ac_, ad_);
        IEnumerable<(CqlTupleMetadata, string id, IEnumerable<CqlConcept> medicationStatusReason, FhirDateTime authoredOn)?> af_ = context.Operators.Distinct<(CqlTupleMetadata, string id, IEnumerable<CqlConcept> medicationStatusReason, FhirDateTime authoredOn)?>(ae_);
        IEnumerable<MedicationRequest> ah_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationnotrequested"));
        IEnumerable<MedicationRequest> aj_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationnotrequested"));
        IEnumerable<MedicationRequest> ak_ = context.Operators.Union<MedicationRequest>(ah_, aj_);
        IEnumerable<MedicationRequest> am_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, f_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationnotrequested"));
        IEnumerable<MedicationRequest> ao_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, f_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationnotrequested"));
        IEnumerable<MedicationRequest> ap_ = context.Operators.Union<MedicationRequest>(am_, ao_);
        IEnumerable<MedicationRequest> aq_ = context.Operators.Union<MedicationRequest>(ak_, ap_);
        IEnumerable<MedicationRequest> as_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, l_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationnotrequested"));
        IEnumerable<MedicationRequest> au_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, l_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationnotrequested"));
        IEnumerable<MedicationRequest> av_ = context.Operators.Union<MedicationRequest>(as_, au_);
        IEnumerable<MedicationRequest> aw_ = context.Operators.Union<MedicationRequest>(aq_, av_);
        IEnumerable<MedicationRequest> ay_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, r_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationnotrequested"));
        IEnumerable<MedicationRequest> ba_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, r_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationnotrequested"));
        IEnumerable<MedicationRequest> bb_ = context.Operators.Union<MedicationRequest>(ay_, ba_);
        IEnumerable<MedicationRequest> bc_ = context.Operators.Union<MedicationRequest>(aw_, bb_);
        IEnumerable<MedicationRequest> be_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, x_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationnotrequested"));
        IEnumerable<MedicationRequest> bg_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, x_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationnotrequested"));
        IEnumerable<MedicationRequest> bh_ = context.Operators.Union<MedicationRequest>(be_, bg_);
        IEnumerable<MedicationRequest> bi_ = context.Operators.Union<MedicationRequest>(bc_, bh_);

        bool? bj_(MedicationRequest NoMedicationOrder) {
            Code<MedicationRequest.MedicationRequestIntent> ea_ = NoMedicationOrder?.IntentElement;
            MedicationRequest.MedicationRequestIntent? eb_ = ea_?.Value;
            string ec_ = context.Operators.Convert<string>(eb_);
            string[] ed_ = [
                "order",
                "original-order",
                "reflex-order",
                "filler-order",
                "instance-order",
            ];
            bool? ee_ = context.Operators.In<string>(ec_, (IEnumerable<string>)ed_);
            Code<MedicationRequest.MedicationrequestStatus> ef_ = NoMedicationOrder?.StatusElement;
            MedicationRequest.MedicationrequestStatus? eg_ = ef_?.Value;
            string eh_ = context.Operators.Convert<string>(eg_);
            string[] ei_ = [
                "active",
                "completed",
            ];
            bool? ej_ = context.Operators.In<string>(eh_, (IEnumerable<string>)ei_);
            bool? ek_ = context.Operators.And(ee_, ej_);
            return ek_;
        }

        IEnumerable<MedicationRequest> bk_ = context.Operators.Where<MedicationRequest>(bi_, bj_);

        (CqlTupleMetadata, string id, IEnumerable<CqlConcept> medicationStatusReason, CqlDateTime authoredOn)? bl_(MedicationRequest NoMedicationOrder) {
            Id el_ = NoMedicationOrder?.IdElement;
            string em_ = el_?.Value;
            List<CodeableConcept> en_ = NoMedicationOrder?.ReasonCode;

            CqlConcept eo_(CodeableConcept @this) {
                CqlConcept et_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);
                return et_;
            }

            IEnumerable<CqlConcept> ep_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)en_, eo_);
            FhirDateTime eq_ = NoMedicationOrder?.AuthoredOnElement;
            CqlDateTime er_ = context.Operators.Convert<CqlDateTime>(eq_);
            (CqlTupleMetadata, string id, IEnumerable<CqlConcept> medicationStatusReason, CqlDateTime authoredOn)? es_ = (CqlTupleMetadata_CNeQfiIHcQEUBjZNVZiOLfdeP, em_, ep_, er_);
            return es_;
        }

        IEnumerable<(CqlTupleMetadata, string id, IEnumerable<CqlConcept> medicationStatusReason, CqlDateTime authoredOn)?> bm_ = context.Operators.Select<MedicationRequest, (CqlTupleMetadata, string id, IEnumerable<CqlConcept> medicationStatusReason, CqlDateTime authoredOn)?>(bk_, bl_);
        IEnumerable<(CqlTupleMetadata, string id, IEnumerable<CqlConcept> medicationStatusReason, CqlDateTime authoredOn)?> bn_ = context.Operators.Distinct<(CqlTupleMetadata, string id, IEnumerable<CqlConcept> medicationStatusReason, CqlDateTime authoredOn)?>(bm_);
        IEnumerable<object> bo_ = context.Operators.Union<object>(af_ as IEnumerable<object>, bn_ as IEnumerable<object>);
        (CqlTupleMetadata, string id, IEnumerable<CqlConcept> medicationStatusReason, CqlDateTime authoredOn)? bp_(object @object) => ((CqlTupleMetadata, string id, IEnumerable<CqlConcept> medicationStatusReason, CqlDateTime authoredOn)?)@object;
        IEnumerable<(CqlTupleMetadata, string id, IEnumerable<CqlConcept> medicationStatusReason, CqlDateTime authoredOn)?> bq_ = context.Operators.Select<object, (CqlTupleMetadata, string id, IEnumerable<CqlConcept> medicationStatusReason, CqlDateTime authoredOn)?>(bo_, bp_);
        IEnumerable<MedicationRequest> bs_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> bt_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));

        bool? bu_(MedicationRequest MR) {
            IEnumerable<Medication> eu_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));

            bool? ev_(Medication M) {
                object ey_ = context.Operators.LateBoundProperty<object>(M, "id.value");
                object ez_ = context.Operators.LateBoundProperty<object>(MR, "medication.reference.value");
                IEnumerable<string> fa_ = context.Operators.Split((string)ez_, "/");
                string fb_ = context.Operators.Last<string>(fa_);
                bool? fc_ = context.Operators.Equal(ey_, fb_);
                CodeableConcept fd_ = M?.Code;
                CqlConcept fe_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, fd_);
                CqlValueSet ff_ = this.Low_Dose_Unfractionated_Heparin_for_VTE_Prophylaxis(context);
                bool? fg_ = context.Operators.ConceptInValueSet(fe_, ff_);
                bool? fh_ = context.Operators.And(fc_, fg_);
                return fh_;
            }

            IEnumerable<Medication> ew_ = context.Operators.Where<Medication>(eu_, ev_);
            bool? ex_ = context.Operators.Exists<Medication>(ew_);
            return ex_;
        }

        IEnumerable<MedicationRequest> bv_ = context.Operators.Where<MedicationRequest>(bt_, bu_);
        IEnumerable<MedicationRequest> bw_ = context.Operators.Union<MedicationRequest>(bs_, bv_);
        IEnumerable<MedicationRequest> by_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, f_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));

        bool? ca_(MedicationRequest MR) {
            IEnumerable<Medication> fi_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));

            bool? fj_(Medication M) {
                object fm_ = context.Operators.LateBoundProperty<object>(M, "id.value");
                object fn_ = context.Operators.LateBoundProperty<object>(MR, "medication.reference.value");
                IEnumerable<string> fo_ = context.Operators.Split((string)fn_, "/");
                string fp_ = context.Operators.Last<string>(fo_);
                bool? fq_ = context.Operators.Equal(fm_, fp_);
                CodeableConcept fr_ = M?.Code;
                CqlConcept fs_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, fr_);
                CqlValueSet ft_ = this.Low_Molecular_Weight_Heparin_for_VTE_Prophylaxis(context);
                bool? fu_ = context.Operators.ConceptInValueSet(fs_, ft_);
                bool? fv_ = context.Operators.And(fq_, fu_);
                return fv_;
            }

            IEnumerable<Medication> fk_ = context.Operators.Where<Medication>(fi_, fj_);
            bool? fl_ = context.Operators.Exists<Medication>(fk_);
            return fl_;
        }

        IEnumerable<MedicationRequest> cb_ = context.Operators.Where<MedicationRequest>(bt_, ca_);
        IEnumerable<MedicationRequest> cc_ = context.Operators.Union<MedicationRequest>(by_, cb_);
        IEnumerable<MedicationRequest> cd_ = context.Operators.Union<MedicationRequest>(bw_, cc_);
        IEnumerable<MedicationRequest> cf_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, l_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));

        bool? ch_(MedicationRequest MR) {
            IEnumerable<Medication> fw_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));

            bool? fx_(Medication M) {
                object ga_ = context.Operators.LateBoundProperty<object>(M, "id.value");
                object gb_ = context.Operators.LateBoundProperty<object>(MR, "medication.reference.value");
                IEnumerable<string> gc_ = context.Operators.Split((string)gb_, "/");
                string gd_ = context.Operators.Last<string>(gc_);
                bool? ge_ = context.Operators.Equal(ga_, gd_);
                CodeableConcept gf_ = M?.Code;
                CqlConcept gg_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, gf_);
                CqlValueSet gh_ = this.Injectable_Factor_Xa_Inhibitor_for_VTE_Prophylaxis(context);
                bool? gi_ = context.Operators.ConceptInValueSet(gg_, gh_);
                bool? gj_ = context.Operators.And(ge_, gi_);
                return gj_;
            }

            IEnumerable<Medication> fy_ = context.Operators.Where<Medication>(fw_, fx_);
            bool? fz_ = context.Operators.Exists<Medication>(fy_);
            return fz_;
        }

        IEnumerable<MedicationRequest> ci_ = context.Operators.Where<MedicationRequest>(bt_, ch_);
        IEnumerable<MedicationRequest> cj_ = context.Operators.Union<MedicationRequest>(cf_, ci_);
        IEnumerable<MedicationRequest> ck_ = context.Operators.Union<MedicationRequest>(cd_, cj_);
        IEnumerable<MedicationRequest> cm_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, r_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));

        bool? co_(MedicationRequest MR) {
            IEnumerable<Medication> gk_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));

            bool? gl_(Medication M) {
                object go_ = context.Operators.LateBoundProperty<object>(M, "id.value");
                object gp_ = context.Operators.LateBoundProperty<object>(MR, "medication.reference.value");
                IEnumerable<string> gq_ = context.Operators.Split((string)gp_, "/");
                string gr_ = context.Operators.Last<string>(gq_);
                bool? gs_ = context.Operators.Equal(go_, gr_);
                CodeableConcept gt_ = M?.Code;
                CqlConcept gu_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, gt_);
                CqlValueSet gv_ = this.Warfarin(context);
                bool? gw_ = context.Operators.ConceptInValueSet(gu_, gv_);
                bool? gx_ = context.Operators.And(gs_, gw_);
                return gx_;
            }

            IEnumerable<Medication> gm_ = context.Operators.Where<Medication>(gk_, gl_);
            bool? gn_ = context.Operators.Exists<Medication>(gm_);
            return gn_;
        }

        IEnumerable<MedicationRequest> cp_ = context.Operators.Where<MedicationRequest>(bt_, co_);
        IEnumerable<MedicationRequest> cq_ = context.Operators.Union<MedicationRequest>(cm_, cp_);
        IEnumerable<MedicationRequest> cr_ = context.Operators.Union<MedicationRequest>(ck_, cq_);
        IEnumerable<MedicationRequest> ct_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, x_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));

        bool? cv_(MedicationRequest MR) {
            IEnumerable<Medication> gy_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));

            bool? gz_(Medication M) {
                object hc_ = context.Operators.LateBoundProperty<object>(M, "id.value");
                object hd_ = context.Operators.LateBoundProperty<object>(MR, "medication.reference.value");
                IEnumerable<string> he_ = context.Operators.Split((string)hd_, "/");
                string hf_ = context.Operators.Last<string>(he_);
                bool? hg_ = context.Operators.Equal(hc_, hf_);
                CodeableConcept hh_ = M?.Code;
                CqlConcept hi_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, hh_);
                CqlValueSet hj_ = this.Rivaroxaban_for_VTE_Prophylaxis(context);
                bool? hk_ = context.Operators.ConceptInValueSet(hi_, hj_);
                bool? hl_ = context.Operators.And(hg_, hk_);
                return hl_;
            }

            IEnumerable<Medication> ha_ = context.Operators.Where<Medication>(gy_, gz_);
            bool? hb_ = context.Operators.Exists<Medication>(ha_);
            return hb_;
        }

        IEnumerable<MedicationRequest> cw_ = context.Operators.Where<MedicationRequest>(bt_, cv_);
        IEnumerable<MedicationRequest> cx_ = context.Operators.Union<MedicationRequest>(ct_, cw_);
        IEnumerable<MedicationRequest> cy_ = context.Operators.Union<MedicationRequest>(cr_, cx_);
        IEnumerable<Task> cz_ = context.Operators.Retrieve<Task>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-taskrejected"));
        IEnumerable<ValueTuple<MedicationRequest, Task>> da_ = context.Operators.CrossJoin<MedicationRequest, Task>(cy_, cz_);

        (CqlTupleMetadata, MedicationRequest MedicationOrderReject, Task T)? db_(ValueTuple<MedicationRequest, Task> _valueTuple) {
            (CqlTupleMetadata, MedicationRequest MedicationOrderReject, Task T)? hm_ = (CqlTupleMetadata_IIUQMBcJhJBPgdDOLHaTTRUE, _valueTuple.Item1, _valueTuple.Item2);
            return hm_;
        }

        IEnumerable<(CqlTupleMetadata, MedicationRequest MedicationOrderReject, Task T)?> dc_ = context.Operators.Select<ValueTuple<MedicationRequest, Task>, (CqlTupleMetadata, MedicationRequest MedicationOrderReject, Task T)?>(da_, db_);

        bool? dd_((CqlTupleMetadata, MedicationRequest MedicationOrderReject, Task T)? tuple_iiuqmbcjhjbpgddolhattrue) {
            ResourceReference hn_ = tuple_iiuqmbcjhjbpgddolhattrue?.T?.Focus;
            bool? ho_ = QICoreCommon_4_0_000.Instance.references(context, hn_, tuple_iiuqmbcjhjbpgddolhattrue?.MedicationOrderReject);
            CodeableConcept hp_ = tuple_iiuqmbcjhjbpgddolhattrue?.T?.Code;
            CqlConcept hq_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, hp_);
            CqlCode hr_ = QICoreCommon_4_0_000.Instance.Fulfill(context);
            CqlConcept hs_ = context.Operators.ConvertCodeToConcept(hr_);
            bool? ht_ = context.Operators.Equivalent(hq_, hs_);
            bool? hu_ = context.Operators.And(ho_, ht_);
            Code<MedicationRequest.MedicationrequestStatus> hv_ = tuple_iiuqmbcjhjbpgddolhattrue?.MedicationOrderReject?.StatusElement;
            MedicationRequest.MedicationrequestStatus? hw_ = hv_?.Value;
            string hx_ = context.Operators.Convert<string>(hw_);
            bool? hy_ = context.Operators.Equal(hx_, "active");
            bool? hz_ = context.Operators.And(hu_, hy_);
            return hz_;
        }

        IEnumerable<(CqlTupleMetadata, MedicationRequest MedicationOrderReject, Task T)?> de_ = context.Operators.Where<(CqlTupleMetadata, MedicationRequest MedicationOrderReject, Task T)?>(dc_, dd_);

        (CqlTupleMetadata, string id, IEnumerable<CqlConcept> medicationStatusReason, CqlDateTime authoredOn)? df_((CqlTupleMetadata, MedicationRequest MedicationOrderReject, Task T)? tuple_iiuqmbcjhjbpgddolhattrue) {
            Id ia_ = tuple_iiuqmbcjhjbpgddolhattrue?.MedicationOrderReject?.IdElement;
            string ib_ = ia_?.Value;
            CodeableConcept ic_ = tuple_iiuqmbcjhjbpgddolhattrue?.T?.StatusReason;
            CqlConcept id_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, ic_);
            CqlConcept[] ie_ = [
                id_,
            ];
            FhirDateTime if_ = tuple_iiuqmbcjhjbpgddolhattrue?.MedicationOrderReject?.AuthoredOnElement;
            CqlDateTime ig_ = context.Operators.Convert<CqlDateTime>(if_);
            (CqlTupleMetadata, string id, IEnumerable<CqlConcept> medicationStatusReason, CqlDateTime authoredOn)? ih_ = (CqlTupleMetadata_CNeQfiIHcQEUBjZNVZiOLfdeP, ib_, (IEnumerable<CqlConcept>)ie_, ig_);
            return ih_;
        }

        IEnumerable<(CqlTupleMetadata, string id, IEnumerable<CqlConcept> medicationStatusReason, CqlDateTime authoredOn)?> dg_ = context.Operators.Select<(CqlTupleMetadata, MedicationRequest MedicationOrderReject, Task T)?, (CqlTupleMetadata, string id, IEnumerable<CqlConcept> medicationStatusReason, CqlDateTime authoredOn)?>(de_, df_);
        IEnumerable<(CqlTupleMetadata, string id, IEnumerable<CqlConcept> medicationStatusReason, CqlDateTime authoredOn)?> dh_ = context.Operators.Distinct<(CqlTupleMetadata, string id, IEnumerable<CqlConcept> medicationStatusReason, CqlDateTime authoredOn)?>(dg_);
        IEnumerable<(CqlTupleMetadata, string id, IEnumerable<CqlConcept> medicationStatusReason, CqlDateTime authoredOn)?> di_ = context.Operators.Union<(CqlTupleMetadata, string id, IEnumerable<CqlConcept> medicationStatusReason, CqlDateTime authoredOn)?>(bq_, dh_);
        return di_;
    }


    [CqlExpressionDefinition("No VTE Prophylaxis Medication Due To Medical Reason From Day Of Start Of Hospitalization To Day After Admission")]
    public IEnumerable<Encounter> No_VTE_Prophylaxis_Medication_Due_To_Medical_Reason_From_Day_Of_Start_Of_Hospitalization_To_Day_After_Admission(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_No_VTE_Prophylaxis_Medication_Due_To_Medical_Reason_From_Day_Of_Start_Of_Hospitalization_To_Day_After_Admission, No_VTE_Prophylaxis_Medication_Due_To_Medical_Reason_From_Day_Of_Start_Of_Hospitalization_To_Day_After_Admission_Compute);

    private const long _cacheIndex_No_VTE_Prophylaxis_Medication_Due_To_Medical_Reason_From_Day_Of_Start_Of_Hospitalization_To_Day_After_Admission = 3917757434461578764L;

    private IEnumerable<Encounter> No_VTE_Prophylaxis_Medication_Due_To_Medical_Reason_From_Day_Of_Start_Of_Hospitalization_To_Day_After_Admission_Compute(CqlContext context)
    {
        IEnumerable<Encounter> a_ = VTE_8_18_000.Instance.Encounter_With_Age_Range_And_Without_VTE_Diagnosis_Or_Obstetrical_Conditions(context);

        bool? b_(Encounter QualifyingEncounter) {
            IEnumerable<(CqlTupleMetadata, string id, IEnumerable<CqlConcept> medicationStatusReason, CqlDateTime authoredOn)?> d_ = this.No_VTE_Prophylaxis_Medication_Administered_Or_Ordered(context);

            bool? e_((CqlTupleMetadata, string id, IEnumerable<CqlConcept> medicationStatusReason, CqlDateTime authoredOn)? NoVTEMedication) {
                IEnumerable<CqlConcept> h_ = NoVTEMedication?.medicationStatusReason;
                CqlValueSet i_ = this.Medical_Reason_For_Not_Providing_Treatment(context);
                bool? j_ = context.Operators.ConceptsInValueSet(h_, i_);
                CqlDateTime k_ = NoVTEMedication?.authoredOn;
                CqlInterval<CqlDate> l_ = this.fromDayOfStartOfHospitalizationToDayAfterAdmission(context, QualifyingEncounter);
                CqlDate m_ = l_?.low;
                CqlDateTime n_ = context.Operators.ConvertDateToDateTime(m_);
                CqlDate p_ = l_?.high;
                CqlDateTime q_ = context.Operators.ConvertDateToDateTime(p_);
                bool? s_ = l_?.lowClosed;
                bool? u_ = l_?.highClosed;
                CqlInterval<CqlDateTime> v_ = context.Operators.Interval(n_, q_, s_, u_);
                bool? w_ = context.Operators.In<CqlDateTime>(k_, v_, "day");
                bool? x_ = context.Operators.And(j_, w_);
                return x_;
            }

            IEnumerable<(CqlTupleMetadata, string id, IEnumerable<CqlConcept> medicationStatusReason, CqlDateTime authoredOn)?> f_ = context.Operators.Where<(CqlTupleMetadata, string id, IEnumerable<CqlConcept> medicationStatusReason, CqlDateTime authoredOn)?>(d_, e_);
            bool? g_ = context.Operators.Exists<(CqlTupleMetadata, string id, IEnumerable<CqlConcept> medicationStatusReason, CqlDateTime authoredOn)?>(f_);
            return g_;
        }

        IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);
        return c_;
    }


    [CqlExpressionDefinition("No Mechanical VTE Prophylaxis Performed Or Ordered")]
    public IEnumerable<(CqlTupleMetadata, string id, CqlConcept requestStatusReason, CqlDateTime authoredOn)?> No_Mechanical_VTE_Prophylaxis_Performed_Or_Ordered(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_No_Mechanical_VTE_Prophylaxis_Performed_Or_Ordered, No_Mechanical_VTE_Prophylaxis_Performed_Or_Ordered_Compute);

    private const long _cacheIndex_No_Mechanical_VTE_Prophylaxis_Performed_Or_Ordered = -865003797626466093L;

    private IEnumerable<(CqlTupleMetadata, string id, CqlConcept requestStatusReason, CqlDateTime authoredOn)?> No_Mechanical_VTE_Prophylaxis_Performed_Or_Ordered_Compute(CqlContext context)
    {
        CqlValueSet a_ = this.Venous_foot_pumps(context);
        IEnumerable<ServiceRequest> b_ = context.Operators.Retrieve<ServiceRequest>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-servicenotrequested"));
        IEnumerable<ServiceRequest> d_ = context.Operators.Retrieve<ServiceRequest>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-servicenotrequested"));
        IEnumerable<ServiceRequest> e_ = context.Operators.Union<ServiceRequest>(b_, d_);
        CqlValueSet f_ = this.Intermittent_pneumatic_compression_devices(context);
        IEnumerable<ServiceRequest> g_ = context.Operators.Retrieve<ServiceRequest>(new RetrieveParameters(default, f_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-servicenotrequested"));
        IEnumerable<ServiceRequest> i_ = context.Operators.Retrieve<ServiceRequest>(new RetrieveParameters(default, f_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-servicenotrequested"));
        IEnumerable<ServiceRequest> j_ = context.Operators.Union<ServiceRequest>(g_, i_);
        IEnumerable<ServiceRequest> k_ = context.Operators.Union<ServiceRequest>(e_, j_);
        CqlValueSet l_ = this.Graduated_compression_stockings(context);
        IEnumerable<ServiceRequest> m_ = context.Operators.Retrieve<ServiceRequest>(new RetrieveParameters(default, l_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-servicenotrequested"));
        IEnumerable<ServiceRequest> o_ = context.Operators.Retrieve<ServiceRequest>(new RetrieveParameters(default, l_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-servicenotrequested"));
        IEnumerable<ServiceRequest> p_ = context.Operators.Union<ServiceRequest>(m_, o_);
        IEnumerable<ServiceRequest> q_ = context.Operators.Union<ServiceRequest>(k_, p_);

        bool? r_(ServiceRequest DeviceNotOrder) {
            Code<RequestIntent> bn_ = DeviceNotOrder?.IntentElement;
            RequestIntent? bo_ = bn_?.Value;
            Code<RequestIntent> bp_ = context.Operators.Convert<Code<RequestIntent>>(bo_);
            string bq_ = context.Operators.Convert<string>(bp_);
            string[] br_ = [
                "order",
                "original-order",
                "reflex-order",
                "filler-order",
                "instance-order",
            ];
            bool? bs_ = context.Operators.In<string>(bq_, (IEnumerable<string>)br_);
            return bs_;
        }

        IEnumerable<ServiceRequest> s_ = context.Operators.Where<ServiceRequest>(q_, r_);

        (CqlTupleMetadata, string id, CodeableConcept requestStatusReason, CqlDateTime authoredOn)? t_(ServiceRequest DeviceNotOrder) {
            Id bt_ = DeviceNotOrder?.IdElement;
            string bu_ = bt_?.Value;

            bool? bv_(Extension @this) {
                FhirUri cf_ = @this?.UrlElement;
                string cg_ = FHIRHelpers_4_4_000.Instance.ToString(context, cf_);
                bool? ch_ = context.Operators.Equal(cg_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-doNotPerformReason");
                return ch_;
            }

            IEnumerable<Extension> bw_ = context.Operators.Where<Extension>((IEnumerable<Extension>)(DeviceNotOrder is DomainResource
                ? (DeviceNotOrder as DomainResource).Extension
                : default), bv_);

            object bx_(Extension @this) {
                DataType ci_ = @this?.Value;
                return ci_;
            }

            IEnumerable<object> by_ = context.Operators.Select<Extension, object>(bw_, bx_);
            object bz_ = context.Operators.SingletonFrom<object>(by_);
            CqlConcept ca_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, bz_ as CodeableConcept);
            CodeableConcept cb_ = context.Operators.Convert<CodeableConcept>(ca_);
            FhirDateTime cc_ = DeviceNotOrder?.AuthoredOnElement;
            CqlDateTime cd_ = context.Operators.Convert<CqlDateTime>(cc_);
            (CqlTupleMetadata, string id, CodeableConcept requestStatusReason, CqlDateTime authoredOn)? ce_ = (CqlTupleMetadata_FVDRPQjOQgYIDhWKHCNhOHceF, bu_, cb_, cd_);
            return ce_;
        }

        IEnumerable<(CqlTupleMetadata, string id, CodeableConcept requestStatusReason, CqlDateTime authoredOn)?> u_ = context.Operators.Select<ServiceRequest, (CqlTupleMetadata, string id, CodeableConcept requestStatusReason, CqlDateTime authoredOn)?>(s_, t_);
        IEnumerable<(CqlTupleMetadata, string id, CodeableConcept requestStatusReason, CqlDateTime authoredOn)?> v_ = context.Operators.Distinct<(CqlTupleMetadata, string id, CodeableConcept requestStatusReason, CqlDateTime authoredOn)?>(u_);
        IEnumerable<ServiceRequest> x_ = context.Operators.Retrieve<ServiceRequest>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-servicerequest"));
        IEnumerable<ServiceRequest> z_ = context.Operators.Retrieve<ServiceRequest>(new RetrieveParameters(default, f_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-servicerequest"));
        IEnumerable<ServiceRequest> aa_ = context.Operators.Union<ServiceRequest>(x_, z_);
        IEnumerable<ServiceRequest> ac_ = context.Operators.Retrieve<ServiceRequest>(new RetrieveParameters(default, l_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-servicerequest"));
        IEnumerable<ServiceRequest> ad_ = context.Operators.Union<ServiceRequest>(aa_, ac_);
        IEnumerable<Task> ae_ = context.Operators.Retrieve<Task>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-taskrejected"));
        IEnumerable<ValueTuple<ServiceRequest, Task>> af_ = context.Operators.CrossJoin<ServiceRequest, Task>(ad_, ae_);

        (CqlTupleMetadata, ServiceRequest DeviceOrderReject, Task T)? ag_(ValueTuple<ServiceRequest, Task> _valueTuple) {
            (CqlTupleMetadata, ServiceRequest DeviceOrderReject, Task T)? cj_ = (CqlTupleMetadata_YYIDPXBNjhOGFRJKYRBMGChb, _valueTuple.Item1, _valueTuple.Item2);
            return cj_;
        }

        IEnumerable<(CqlTupleMetadata, ServiceRequest DeviceOrderReject, Task T)?> ah_ = context.Operators.Select<ValueTuple<ServiceRequest, Task>, (CqlTupleMetadata, ServiceRequest DeviceOrderReject, Task T)?>(af_, ag_);

        bool? ai_((CqlTupleMetadata, ServiceRequest DeviceOrderReject, Task T)? tuple_yyidpxbnjhogfrjkyrbmgchb) {
            Code<RequestIntent> ck_ = tuple_yyidpxbnjhogfrjkyrbmgchb?.DeviceOrderReject?.IntentElement;
            RequestIntent? cl_ = ck_?.Value;
            Code<RequestIntent> cm_ = context.Operators.Convert<Code<RequestIntent>>(cl_);
            string cn_ = context.Operators.Convert<string>(cm_);
            string[] co_ = [
                "order",
                "original-order",
                "reflex-order",
                "filler-order",
                "instance-order",
            ];
            bool? cp_ = context.Operators.In<string>(cn_, (IEnumerable<string>)co_);
            Code<RequestStatus> cq_ = tuple_yyidpxbnjhogfrjkyrbmgchb?.DeviceOrderReject?.StatusElement;
            RequestStatus? cr_ = cq_?.Value;
            Code<RequestStatus> cs_ = context.Operators.Convert<Code<RequestStatus>>(cr_);
            bool? ct_ = context.Operators.Equal(cs_, "active");
            bool? cu_ = context.Operators.And(cp_, ct_);
            ResourceReference cv_ = tuple_yyidpxbnjhogfrjkyrbmgchb?.T?.Focus;
            bool? cw_ = QICoreCommon_4_0_000.Instance.references(context, cv_, tuple_yyidpxbnjhogfrjkyrbmgchb?.DeviceOrderReject);
            bool? cx_ = context.Operators.And(cu_, cw_);
            CodeableConcept cy_ = tuple_yyidpxbnjhogfrjkyrbmgchb?.T?.Code;
            CqlConcept cz_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, cy_);
            CqlCode da_ = QICoreCommon_4_0_000.Instance.Fulfill(context);
            CqlConcept db_ = context.Operators.ConvertCodeToConcept(da_);
            bool? dc_ = context.Operators.Equivalent(cz_, db_);
            bool? dd_ = context.Operators.And(cx_, dc_);
            return dd_;
        }

        IEnumerable<(CqlTupleMetadata, ServiceRequest DeviceOrderReject, Task T)?> aj_ = context.Operators.Where<(CqlTupleMetadata, ServiceRequest DeviceOrderReject, Task T)?>(ah_, ai_);

        (CqlTupleMetadata, string id, CqlConcept requestStatusReason, CqlDateTime authoredOn)? ak_((CqlTupleMetadata, ServiceRequest DeviceOrderReject, Task T)? tuple_yyidpxbnjhogfrjkyrbmgchb) {
            Id de_ = tuple_yyidpxbnjhogfrjkyrbmgchb?.DeviceOrderReject?.IdElement;
            string df_ = de_?.Value;
            CodeableConcept dg_ = tuple_yyidpxbnjhogfrjkyrbmgchb?.T?.StatusReason;
            CqlConcept dh_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, dg_);
            FhirDateTime di_ = tuple_yyidpxbnjhogfrjkyrbmgchb?.DeviceOrderReject?.AuthoredOnElement;
            CqlDateTime dj_ = context.Operators.Convert<CqlDateTime>(di_);
            (CqlTupleMetadata, string id, CqlConcept requestStatusReason, CqlDateTime authoredOn)? dk_ = (CqlTupleMetadata_DheTAGNHbFgKVJGaRbPLJVjKH, df_, dh_, dj_);
            return dk_;
        }

        IEnumerable<(CqlTupleMetadata, string id, CqlConcept requestStatusReason, CqlDateTime authoredOn)?> al_ = context.Operators.Select<(CqlTupleMetadata, ServiceRequest DeviceOrderReject, Task T)?, (CqlTupleMetadata, string id, CqlConcept requestStatusReason, CqlDateTime authoredOn)?>(aj_, ak_);
        IEnumerable<(CqlTupleMetadata, string id, CqlConcept requestStatusReason, CqlDateTime authoredOn)?> am_ = context.Operators.Distinct<(CqlTupleMetadata, string id, CqlConcept requestStatusReason, CqlDateTime authoredOn)?>(al_);
        IEnumerable<object> an_ = context.Operators.Union<object>(v_ as IEnumerable<object>, am_ as IEnumerable<object>);
        (CqlTupleMetadata, string id, CqlConcept requestStatusReason, CqlDateTime authoredOn)? ao_(object @object) => ((CqlTupleMetadata, string id, CqlConcept requestStatusReason, CqlDateTime authoredOn)?)@object;
        IEnumerable<(CqlTupleMetadata, string id, CqlConcept requestStatusReason, CqlDateTime authoredOn)?> ap_ = context.Operators.Select<object, (CqlTupleMetadata, string id, CqlConcept requestStatusReason, CqlDateTime authoredOn)?>(an_, ao_);
        CqlValueSet aq_ = this.Application_of_Intermittent_Pneumatic_Compression_Devices(context);
        IEnumerable<Procedure> ar_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, aq_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedurenotdone"));
        IEnumerable<Procedure> at_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, aq_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedurenotdone"));
        IEnumerable<Procedure> au_ = context.Operators.Union<Procedure>(ar_, at_);
        CqlValueSet av_ = this.Application_of_Venous_Foot_Pumps(context);
        IEnumerable<Procedure> aw_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, av_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedurenotdone"));
        IEnumerable<Procedure> ay_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, av_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedurenotdone"));
        IEnumerable<Procedure> az_ = context.Operators.Union<Procedure>(aw_, ay_);
        IEnumerable<Procedure> ba_ = context.Operators.Union<Procedure>(au_, az_);
        CqlValueSet bb_ = this.Application_of_Graduated_Compression_Stockings(context);
        IEnumerable<Procedure> bc_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, bb_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedurenotdone"));
        IEnumerable<Procedure> be_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, bb_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedurenotdone"));
        IEnumerable<Procedure> bf_ = context.Operators.Union<Procedure>(bc_, be_);
        IEnumerable<Procedure> bg_ = context.Operators.Union<Procedure>(ba_, bf_);

        (CqlTupleMetadata, string id, CqlConcept requestStatusReason, FhirDateTime authoredOn)? bh_(Procedure DeviceNotApplied) {
            Id dl_ = DeviceNotApplied?.IdElement;
            string dm_ = dl_?.Value;
            CodeableConcept dn_ = DeviceNotApplied?.StatusReason;
            CqlConcept do_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, dn_);

            bool? dp_(Extension @this) {
                FhirUri dw_ = @this?.UrlElement;
                string dx_ = FHIRHelpers_4_4_000.Instance.ToString(context, dw_);
                bool? dy_ = context.Operators.Equal(dx_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-recorded");
                return dy_;
            }

            IEnumerable<Extension> dq_ = context.Operators.Where<Extension>((IEnumerable<Extension>)(DeviceNotApplied is DomainResource
                ? (DeviceNotApplied as DomainResource).Extension
                : default), dp_);

            DataType dr_(Extension @this) {
                DataType dz_ = @this?.Value;
                return dz_;
            }

            IEnumerable<DataType> ds_ = context.Operators.Select<Extension, DataType>(dq_, dr_);
            DataType dt_ = context.Operators.SingletonFrom<DataType>(ds_);
            FhirDateTime du_ = context.Operators.Convert<FhirDateTime>(dt_);
            (CqlTupleMetadata, string id, CqlConcept requestStatusReason, FhirDateTime authoredOn)? dv_ = (CqlTupleMetadata_DPXDaXjPQUNAIiZCCbGhNdDMi, dm_, do_, du_);
            return dv_;
        }

        IEnumerable<(CqlTupleMetadata, string id, CqlConcept requestStatusReason, FhirDateTime authoredOn)?> bi_ = context.Operators.Select<Procedure, (CqlTupleMetadata, string id, CqlConcept requestStatusReason, FhirDateTime authoredOn)?>(bg_, bh_);
        IEnumerable<(CqlTupleMetadata, string id, CqlConcept requestStatusReason, FhirDateTime authoredOn)?> bj_ = context.Operators.Distinct<(CqlTupleMetadata, string id, CqlConcept requestStatusReason, FhirDateTime authoredOn)?>(bi_);
        IEnumerable<object> bk_ = context.Operators.Union<object>(ap_ as IEnumerable<object>, bj_ as IEnumerable<object>);
        IEnumerable<(CqlTupleMetadata, string id, CqlConcept requestStatusReason, CqlDateTime authoredOn)?> bm_ = context.Operators.Select<object, (CqlTupleMetadata, string id, CqlConcept requestStatusReason, CqlDateTime authoredOn)?>(bk_, ao_);
        return bm_;
    }


    [CqlExpressionDefinition("No Mechanical VTE Prophylaxis Due To Medical Reason From Day Of Start Of Hospitalization To Day After Admission")]
    public IEnumerable<Encounter> No_Mechanical_VTE_Prophylaxis_Due_To_Medical_Reason_From_Day_Of_Start_Of_Hospitalization_To_Day_After_Admission(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_No_Mechanical_VTE_Prophylaxis_Due_To_Medical_Reason_From_Day_Of_Start_Of_Hospitalization_To_Day_After_Admission, No_Mechanical_VTE_Prophylaxis_Due_To_Medical_Reason_From_Day_Of_Start_Of_Hospitalization_To_Day_After_Admission_Compute);

    private const long _cacheIndex_No_Mechanical_VTE_Prophylaxis_Due_To_Medical_Reason_From_Day_Of_Start_Of_Hospitalization_To_Day_After_Admission = 5040437268030859533L;

    private IEnumerable<Encounter> No_Mechanical_VTE_Prophylaxis_Due_To_Medical_Reason_From_Day_Of_Start_Of_Hospitalization_To_Day_After_Admission_Compute(CqlContext context)
    {
        IEnumerable<Encounter> a_ = VTE_8_18_000.Instance.Encounter_With_Age_Range_And_Without_VTE_Diagnosis_Or_Obstetrical_Conditions(context);

        bool? b_(Encounter QualifyingEncounter) {
            IEnumerable<(CqlTupleMetadata, string id, CqlConcept requestStatusReason, CqlDateTime authoredOn)?> d_ = this.No_Mechanical_VTE_Prophylaxis_Performed_Or_Ordered(context);

            bool? e_((CqlTupleMetadata, string id, CqlConcept requestStatusReason, CqlDateTime authoredOn)? NoVTEDevice) {
                CqlConcept h_ = NoVTEDevice?.requestStatusReason;
                CqlValueSet i_ = this.Medical_Reason_For_Not_Providing_Treatment(context);
                bool? j_ = context.Operators.ConceptInValueSet(h_, i_);
                CqlDateTime k_ = NoVTEDevice?.authoredOn;
                CqlInterval<CqlDate> l_ = this.fromDayOfStartOfHospitalizationToDayAfterAdmission(context, QualifyingEncounter);
                CqlDate m_ = l_?.low;
                CqlDateTime n_ = context.Operators.ConvertDateToDateTime(m_);
                CqlDate p_ = l_?.high;
                CqlDateTime q_ = context.Operators.ConvertDateToDateTime(p_);
                bool? s_ = l_?.lowClosed;
                bool? u_ = l_?.highClosed;
                CqlInterval<CqlDateTime> v_ = context.Operators.Interval(n_, q_, s_, u_);
                bool? w_ = context.Operators.In<CqlDateTime>(k_, v_, "day");
                bool? x_ = context.Operators.And(j_, w_);
                return x_;
            }

            IEnumerable<(CqlTupleMetadata, string id, CqlConcept requestStatusReason, CqlDateTime authoredOn)?> f_ = context.Operators.Where<(CqlTupleMetadata, string id, CqlConcept requestStatusReason, CqlDateTime authoredOn)?>(d_, e_);
            bool? g_ = context.Operators.Exists<(CqlTupleMetadata, string id, CqlConcept requestStatusReason, CqlDateTime authoredOn)?>(f_);
            return g_;
        }

        IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);
        return c_;
    }


    [CqlExpressionDefinition("No VTE Prophylaxis Medication Due To Medical Reason On Day Of Or Day After Procedure")]
    public IEnumerable<Encounter> No_VTE_Prophylaxis_Medication_Due_To_Medical_Reason_On_Day_Of_Or_Day_After_Procedure(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_No_VTE_Prophylaxis_Medication_Due_To_Medical_Reason_On_Day_Of_Or_Day_After_Procedure, No_VTE_Prophylaxis_Medication_Due_To_Medical_Reason_On_Day_Of_Or_Day_After_Procedure_Compute);

    private const long _cacheIndex_No_VTE_Prophylaxis_Medication_Due_To_Medical_Reason_On_Day_Of_Or_Day_After_Procedure = 4328598489171831529L;

    private IEnumerable<Encounter> No_VTE_Prophylaxis_Medication_Due_To_Medical_Reason_On_Day_Of_Or_Day_After_Procedure_Compute(CqlContext context)
    {
        IEnumerable<Encounter> a_ = VTE_8_18_000.Instance.Encounter_With_Age_Range_And_Without_VTE_Diagnosis_Or_Obstetrical_Conditions(context);
        CqlValueSet b_ = this.General_or_Neuraxial_Anesthesia(context);
        IEnumerable<Procedure> c_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, b_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
        IEnumerable<(CqlTupleMetadata, string id, IEnumerable<CqlConcept> medicationStatusReason, CqlDateTime authoredOn)?> d_ = this.No_VTE_Prophylaxis_Medication_Administered_Or_Ordered(context);
        IEnumerable<ValueTuple<Encounter, Procedure, (CqlTupleMetadata, string id, IEnumerable<CqlConcept> medicationStatusReason, CqlDateTime authoredOn)?>> e_ = context.Operators.CrossJoin<Encounter, Procedure, (CqlTupleMetadata, string id, IEnumerable<CqlConcept> medicationStatusReason, CqlDateTime authoredOn)?>(a_, c_, d_);

        (CqlTupleMetadata, Encounter QualifyingEncounter, Procedure AnesthesiaProcedure, (CqlTupleMetadata, string id, IEnumerable<CqlConcept> medicationStatusReason, CqlDateTime authoredOn)? NoVTEMedication)? f_(ValueTuple<Encounter, Procedure, (CqlTupleMetadata, string id, IEnumerable<CqlConcept> medicationStatusReason, CqlDateTime authoredOn)?> _valueTuple) {
            (CqlTupleMetadata, Encounter QualifyingEncounter, Procedure AnesthesiaProcedure, (CqlTupleMetadata, string id, IEnumerable<CqlConcept> medicationStatusReason, CqlDateTime authoredOn)? NoVTEMedication)? m_ = (CqlTupleMetadata_CUUMXUZWiBObPgSAjXGJDhdYW, _valueTuple.Item1, _valueTuple.Item2, _valueTuple.Item3);
            return m_;
        }

        IEnumerable<(CqlTupleMetadata, Encounter QualifyingEncounter, Procedure AnesthesiaProcedure, (CqlTupleMetadata, string id, IEnumerable<CqlConcept> medicationStatusReason, CqlDateTime authoredOn)? NoVTEMedication)?> g_ = context.Operators.Select<ValueTuple<Encounter, Procedure, (CqlTupleMetadata, string id, IEnumerable<CqlConcept> medicationStatusReason, CqlDateTime authoredOn)?>, (CqlTupleMetadata, Encounter QualifyingEncounter, Procedure AnesthesiaProcedure, (CqlTupleMetadata, string id, IEnumerable<CqlConcept> medicationStatusReason, CqlDateTime authoredOn)? NoVTEMedication)?>(e_, f_);

        bool? h_((CqlTupleMetadata, Encounter QualifyingEncounter, Procedure AnesthesiaProcedure, (CqlTupleMetadata, string id, IEnumerable<CqlConcept> medicationStatusReason, CqlDateTime authoredOn)? NoVTEMedication)? tuple_chjebychscdthhbpzggacmwxe) {
            IEnumerable<CqlConcept> n_ = tuple_chjebychscdthhbpzggacmwxe?.NoVTEMedication?.medicationStatusReason;
            CqlValueSet o_ = this.Medical_Reason_For_Not_Providing_Treatment(context);
            bool? p_ = context.Operators.ConceptsInValueSet(n_, o_);
            Code<EventStatus> q_ = tuple_chjebychscdthhbpzggacmwxe?.AnesthesiaProcedure?.StatusElement;
            EventStatus? r_ = q_?.Value;
            string s_ = context.Operators.Convert<string>(r_);
            bool? t_ = context.Operators.Equal(s_, "completed");
            bool? u_ = context.Operators.And(p_, t_);

            object v_() {

                bool bf_() {
                    DataType bj_ = tuple_chjebychscdthhbpzggacmwxe?.AnesthesiaProcedure?.Performed;
                    object bk_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bj_);
                    bool bl_ = bk_ is CqlDateTime;
                    return bl_;
                }


                bool bg_() {
                    DataType bm_ = tuple_chjebychscdthhbpzggacmwxe?.AnesthesiaProcedure?.Performed;
                    object bn_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bm_);
                    bool bo_ = bn_ is CqlInterval<CqlDateTime>;
                    return bo_;
                }


                bool bh_() {
                    DataType bp_ = tuple_chjebychscdthhbpzggacmwxe?.AnesthesiaProcedure?.Performed;
                    object bq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bp_);
                    bool br_ = bq_ is CqlQuantity;
                    return br_;
                }


                bool bi_() {
                    DataType bs_ = tuple_chjebychscdthhbpzggacmwxe?.AnesthesiaProcedure?.Performed;
                    object bt_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bs_);
                    bool bu_ = bt_ is CqlInterval<CqlQuantity>;
                    return bu_;
                }

                if (bf_())
                {
                    DataType bv_ = tuple_chjebychscdthhbpzggacmwxe?.AnesthesiaProcedure?.Performed;
                    object bw_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bv_);
                    return (bw_ as CqlDateTime) as object;
                }
                else if (bg_())
                {
                    DataType bx_ = tuple_chjebychscdthhbpzggacmwxe?.AnesthesiaProcedure?.Performed;
                    object by_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bx_);
                    return (by_ as CqlInterval<CqlDateTime>) as object;
                }
                else if (bh_())
                {
                    DataType bz_ = tuple_chjebychscdthhbpzggacmwxe?.AnesthesiaProcedure?.Performed;
                    object ca_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bz_);
                    return (ca_ as CqlQuantity) as object;
                }
                else if (bi_())
                {
                    DataType cb_ = tuple_chjebychscdthhbpzggacmwxe?.AnesthesiaProcedure?.Performed;
                    object cc_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cb_);
                    return (cc_ as CqlInterval<CqlQuantity>) as object;
                }
                else
                {
                    return null;
                };
            }

            CqlInterval<CqlDateTime> w_ = QICoreCommon_4_0_000.Instance.toInterval(context, v_());
            CqlDateTime x_ = context.Operators.End(w_);
            Period y_ = tuple_chjebychscdthhbpzggacmwxe?.QualifyingEncounter?.Period;
            CqlInterval<CqlDateTime> z_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, y_);
            CqlDateTime aa_ = context.Operators.Start(z_);
            CqlQuantity ab_ = context.Operators.Quantity(1m, "day");
            CqlDateTime ac_ = context.Operators.Add(aa_, ab_);
            bool? ad_ = context.Operators.SameAs(x_, ac_, "day");
            bool? ae_ = context.Operators.And(u_, ad_);
            CqlDateTime af_ = tuple_chjebychscdthhbpzggacmwxe?.NoVTEMedication?.authoredOn;

            object ag_() {

                bool cd_() {
                    DataType ch_ = tuple_chjebychscdthhbpzggacmwxe?.AnesthesiaProcedure?.Performed;
                    object ci_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ch_);
                    bool cj_ = ci_ is CqlDateTime;
                    return cj_;
                }


                bool ce_() {
                    DataType ck_ = tuple_chjebychscdthhbpzggacmwxe?.AnesthesiaProcedure?.Performed;
                    object cl_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ck_);
                    bool cm_ = cl_ is CqlInterval<CqlDateTime>;
                    return cm_;
                }


                bool cf_() {
                    DataType cn_ = tuple_chjebychscdthhbpzggacmwxe?.AnesthesiaProcedure?.Performed;
                    object co_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cn_);
                    bool cp_ = co_ is CqlQuantity;
                    return cp_;
                }


                bool cg_() {
                    DataType cq_ = tuple_chjebychscdthhbpzggacmwxe?.AnesthesiaProcedure?.Performed;
                    object cr_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cq_);
                    bool cs_ = cr_ is CqlInterval<CqlQuantity>;
                    return cs_;
                }

                if (cd_())
                {
                    DataType ct_ = tuple_chjebychscdthhbpzggacmwxe?.AnesthesiaProcedure?.Performed;
                    object cu_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ct_);
                    return (cu_ as CqlDateTime) as object;
                }
                else if (ce_())
                {
                    DataType cv_ = tuple_chjebychscdthhbpzggacmwxe?.AnesthesiaProcedure?.Performed;
                    object cw_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cv_);
                    return (cw_ as CqlInterval<CqlDateTime>) as object;
                }
                else if (cf_())
                {
                    DataType cx_ = tuple_chjebychscdthhbpzggacmwxe?.AnesthesiaProcedure?.Performed;
                    object cy_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cx_);
                    return (cy_ as CqlQuantity) as object;
                }
                else if (cg_())
                {
                    DataType cz_ = tuple_chjebychscdthhbpzggacmwxe?.AnesthesiaProcedure?.Performed;
                    object da_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cz_);
                    return (da_ as CqlInterval<CqlQuantity>) as object;
                }
                else
                {
                    return null;
                };
            }

            CqlInterval<CqlDateTime> ah_ = QICoreCommon_4_0_000.Instance.toInterval(context, ag_());
            CqlDateTime ai_ = context.Operators.End(ah_);
            CqlInterval<CqlDate> aj_ = TJCOverall_8_25_000.Instance.calendarDayOfOrDayAfter(context, ai_);
            CqlDate ak_ = aj_?.low;
            CqlDateTime al_ = context.Operators.ConvertDateToDateTime(ak_);

            object am_() {

                bool db_() {
                    DataType df_ = tuple_chjebychscdthhbpzggacmwxe?.AnesthesiaProcedure?.Performed;
                    object dg_ = FHIRHelpers_4_4_000.Instance.ToValue(context, df_);
                    bool dh_ = dg_ is CqlDateTime;
                    return dh_;
                }


                bool dc_() {
                    DataType di_ = tuple_chjebychscdthhbpzggacmwxe?.AnesthesiaProcedure?.Performed;
                    object dj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, di_);
                    bool dk_ = dj_ is CqlInterval<CqlDateTime>;
                    return dk_;
                }


                bool dd_() {
                    DataType dl_ = tuple_chjebychscdthhbpzggacmwxe?.AnesthesiaProcedure?.Performed;
                    object dm_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dl_);
                    bool dn_ = dm_ is CqlQuantity;
                    return dn_;
                }


                bool de_() {
                    DataType do_ = tuple_chjebychscdthhbpzggacmwxe?.AnesthesiaProcedure?.Performed;
                    object dp_ = FHIRHelpers_4_4_000.Instance.ToValue(context, do_);
                    bool dq_ = dp_ is CqlInterval<CqlQuantity>;
                    return dq_;
                }

                if (db_())
                {
                    DataType dr_ = tuple_chjebychscdthhbpzggacmwxe?.AnesthesiaProcedure?.Performed;
                    object ds_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dr_);
                    return (ds_ as CqlDateTime) as object;
                }
                else if (dc_())
                {
                    DataType dt_ = tuple_chjebychscdthhbpzggacmwxe?.AnesthesiaProcedure?.Performed;
                    object du_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dt_);
                    return (du_ as CqlInterval<CqlDateTime>) as object;
                }
                else if (dd_())
                {
                    DataType dv_ = tuple_chjebychscdthhbpzggacmwxe?.AnesthesiaProcedure?.Performed;
                    object dw_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dv_);
                    return (dw_ as CqlQuantity) as object;
                }
                else if (de_())
                {
                    DataType dx_ = tuple_chjebychscdthhbpzggacmwxe?.AnesthesiaProcedure?.Performed;
                    object dy_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dx_);
                    return (dy_ as CqlInterval<CqlQuantity>) as object;
                }
                else
                {
                    return null;
                };
            }

            CqlInterval<CqlDateTime> an_ = QICoreCommon_4_0_000.Instance.toInterval(context, am_());
            CqlDateTime ao_ = context.Operators.End(an_);
            CqlInterval<CqlDate> ap_ = TJCOverall_8_25_000.Instance.calendarDayOfOrDayAfter(context, ao_);
            CqlDate aq_ = ap_?.high;
            CqlDateTime ar_ = context.Operators.ConvertDateToDateTime(aq_);

            object as_() {

                bool dz_() {
                    DataType ed_ = tuple_chjebychscdthhbpzggacmwxe?.AnesthesiaProcedure?.Performed;
                    object ee_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ed_);
                    bool ef_ = ee_ is CqlDateTime;
                    return ef_;
                }


                bool ea_() {
                    DataType eg_ = tuple_chjebychscdthhbpzggacmwxe?.AnesthesiaProcedure?.Performed;
                    object eh_ = FHIRHelpers_4_4_000.Instance.ToValue(context, eg_);
                    bool ei_ = eh_ is CqlInterval<CqlDateTime>;
                    return ei_;
                }


                bool eb_() {
                    DataType ej_ = tuple_chjebychscdthhbpzggacmwxe?.AnesthesiaProcedure?.Performed;
                    object ek_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ej_);
                    bool el_ = ek_ is CqlQuantity;
                    return el_;
                }


                bool ec_() {
                    DataType em_ = tuple_chjebychscdthhbpzggacmwxe?.AnesthesiaProcedure?.Performed;
                    object en_ = FHIRHelpers_4_4_000.Instance.ToValue(context, em_);
                    bool eo_ = en_ is CqlInterval<CqlQuantity>;
                    return eo_;
                }

                if (dz_())
                {
                    DataType ep_ = tuple_chjebychscdthhbpzggacmwxe?.AnesthesiaProcedure?.Performed;
                    object eq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ep_);
                    return (eq_ as CqlDateTime) as object;
                }
                else if (ea_())
                {
                    DataType er_ = tuple_chjebychscdthhbpzggacmwxe?.AnesthesiaProcedure?.Performed;
                    object es_ = FHIRHelpers_4_4_000.Instance.ToValue(context, er_);
                    return (es_ as CqlInterval<CqlDateTime>) as object;
                }
                else if (eb_())
                {
                    DataType et_ = tuple_chjebychscdthhbpzggacmwxe?.AnesthesiaProcedure?.Performed;
                    object eu_ = FHIRHelpers_4_4_000.Instance.ToValue(context, et_);
                    return (eu_ as CqlQuantity) as object;
                }
                else if (ec_())
                {
                    DataType ev_ = tuple_chjebychscdthhbpzggacmwxe?.AnesthesiaProcedure?.Performed;
                    object ew_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ev_);
                    return (ew_ as CqlInterval<CqlQuantity>) as object;
                }
                else
                {
                    return null;
                };
            }

            CqlInterval<CqlDateTime> at_ = QICoreCommon_4_0_000.Instance.toInterval(context, as_());
            CqlDateTime au_ = context.Operators.End(at_);
            CqlInterval<CqlDate> av_ = TJCOverall_8_25_000.Instance.calendarDayOfOrDayAfter(context, au_);
            bool? aw_ = av_?.lowClosed;

            object ax_() {

                bool ex_() {
                    DataType fb_ = tuple_chjebychscdthhbpzggacmwxe?.AnesthesiaProcedure?.Performed;
                    object fc_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fb_);
                    bool fd_ = fc_ is CqlDateTime;
                    return fd_;
                }


                bool ey_() {
                    DataType fe_ = tuple_chjebychscdthhbpzggacmwxe?.AnesthesiaProcedure?.Performed;
                    object ff_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fe_);
                    bool fg_ = ff_ is CqlInterval<CqlDateTime>;
                    return fg_;
                }


                bool ez_() {
                    DataType fh_ = tuple_chjebychscdthhbpzggacmwxe?.AnesthesiaProcedure?.Performed;
                    object fi_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fh_);
                    bool fj_ = fi_ is CqlQuantity;
                    return fj_;
                }


                bool fa_() {
                    DataType fk_ = tuple_chjebychscdthhbpzggacmwxe?.AnesthesiaProcedure?.Performed;
                    object fl_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fk_);
                    bool fm_ = fl_ is CqlInterval<CqlQuantity>;
                    return fm_;
                }

                if (ex_())
                {
                    DataType fn_ = tuple_chjebychscdthhbpzggacmwxe?.AnesthesiaProcedure?.Performed;
                    object fo_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fn_);
                    return (fo_ as CqlDateTime) as object;
                }
                else if (ey_())
                {
                    DataType fp_ = tuple_chjebychscdthhbpzggacmwxe?.AnesthesiaProcedure?.Performed;
                    object fq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fp_);
                    return (fq_ as CqlInterval<CqlDateTime>) as object;
                }
                else if (ez_())
                {
                    DataType fr_ = tuple_chjebychscdthhbpzggacmwxe?.AnesthesiaProcedure?.Performed;
                    object fs_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fr_);
                    return (fs_ as CqlQuantity) as object;
                }
                else if (fa_())
                {
                    DataType ft_ = tuple_chjebychscdthhbpzggacmwxe?.AnesthesiaProcedure?.Performed;
                    object fu_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ft_);
                    return (fu_ as CqlInterval<CqlQuantity>) as object;
                }
                else
                {
                    return null;
                };
            }

            CqlInterval<CqlDateTime> ay_ = QICoreCommon_4_0_000.Instance.toInterval(context, ax_());
            CqlDateTime az_ = context.Operators.End(ay_);
            CqlInterval<CqlDate> ba_ = TJCOverall_8_25_000.Instance.calendarDayOfOrDayAfter(context, az_);
            bool? bb_ = ba_?.highClosed;
            CqlInterval<CqlDateTime> bc_ = context.Operators.Interval(al_, ar_, aw_, bb_);
            bool? bd_ = context.Operators.In<CqlDateTime>(af_, bc_, "day");
            bool? be_ = context.Operators.And(ae_, bd_);
            return be_;
        }

        IEnumerable<(CqlTupleMetadata, Encounter QualifyingEncounter, Procedure AnesthesiaProcedure, (CqlTupleMetadata, string id, IEnumerable<CqlConcept> medicationStatusReason, CqlDateTime authoredOn)? NoVTEMedication)?> i_ = context.Operators.Where<(CqlTupleMetadata, Encounter QualifyingEncounter, Procedure AnesthesiaProcedure, (CqlTupleMetadata, string id, IEnumerable<CqlConcept> medicationStatusReason, CqlDateTime authoredOn)? NoVTEMedication)?>(g_, h_);
        Encounter j_((CqlTupleMetadata, Encounter QualifyingEncounter, Procedure AnesthesiaProcedure, (CqlTupleMetadata, string id, IEnumerable<CqlConcept> medicationStatusReason, CqlDateTime authoredOn)? NoVTEMedication)? tuple_chjebychscdthhbpzggacmwxe) => tuple_chjebychscdthhbpzggacmwxe?.QualifyingEncounter;
        IEnumerable<Encounter> k_ = context.Operators.Select<(CqlTupleMetadata, Encounter QualifyingEncounter, Procedure AnesthesiaProcedure, (CqlTupleMetadata, string id, IEnumerable<CqlConcept> medicationStatusReason, CqlDateTime authoredOn)? NoVTEMedication)?, Encounter>(i_, j_);
        IEnumerable<Encounter> l_ = context.Operators.Distinct<Encounter>(k_);
        return l_;
    }


    [CqlExpressionDefinition("No Mechanical VTE Prophylaxis Due To Medical Reason On Day Of Or Day After Procedure")]
    public IEnumerable<Encounter> No_Mechanical_VTE_Prophylaxis_Due_To_Medical_Reason_On_Day_Of_Or_Day_After_Procedure(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_No_Mechanical_VTE_Prophylaxis_Due_To_Medical_Reason_On_Day_Of_Or_Day_After_Procedure, No_Mechanical_VTE_Prophylaxis_Due_To_Medical_Reason_On_Day_Of_Or_Day_After_Procedure_Compute);

    private const long _cacheIndex_No_Mechanical_VTE_Prophylaxis_Due_To_Medical_Reason_On_Day_Of_Or_Day_After_Procedure = 9122492611972872732L;

    private IEnumerable<Encounter> No_Mechanical_VTE_Prophylaxis_Due_To_Medical_Reason_On_Day_Of_Or_Day_After_Procedure_Compute(CqlContext context)
    {
        IEnumerable<Encounter> a_ = VTE_8_18_000.Instance.Encounter_With_Age_Range_And_Without_VTE_Diagnosis_Or_Obstetrical_Conditions(context);
        CqlValueSet b_ = this.General_or_Neuraxial_Anesthesia(context);
        IEnumerable<Procedure> c_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, b_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
        IEnumerable<(CqlTupleMetadata, string id, CqlConcept requestStatusReason, CqlDateTime authoredOn)?> d_ = this.No_Mechanical_VTE_Prophylaxis_Performed_Or_Ordered(context);
        IEnumerable<ValueTuple<Encounter, Procedure, (CqlTupleMetadata, string id, CqlConcept requestStatusReason, CqlDateTime authoredOn)?>> e_ = context.Operators.CrossJoin<Encounter, Procedure, (CqlTupleMetadata, string id, CqlConcept requestStatusReason, CqlDateTime authoredOn)?>(a_, c_, d_);

        (CqlTupleMetadata, Encounter QualifyingEncounter, Procedure AnesthesiaProcedure, (CqlTupleMetadata, string id, CqlConcept requestStatusReason, CqlDateTime authoredOn)? NoVTEDevice)? f_(ValueTuple<Encounter, Procedure, (CqlTupleMetadata, string id, CqlConcept requestStatusReason, CqlDateTime authoredOn)?> _valueTuple) {
            (CqlTupleMetadata, Encounter QualifyingEncounter, Procedure AnesthesiaProcedure, (CqlTupleMetadata, string id, CqlConcept requestStatusReason, CqlDateTime authoredOn)? NoVTEDevice)? m_ = (CqlTupleMetadata_FNWjhIAKXiLTDJAYchhKVfDAc, _valueTuple.Item1, _valueTuple.Item2, _valueTuple.Item3);
            return m_;
        }

        IEnumerable<(CqlTupleMetadata, Encounter QualifyingEncounter, Procedure AnesthesiaProcedure, (CqlTupleMetadata, string id, CqlConcept requestStatusReason, CqlDateTime authoredOn)? NoVTEDevice)?> g_ = context.Operators.Select<ValueTuple<Encounter, Procedure, (CqlTupleMetadata, string id, CqlConcept requestStatusReason, CqlDateTime authoredOn)?>, (CqlTupleMetadata, Encounter QualifyingEncounter, Procedure AnesthesiaProcedure, (CqlTupleMetadata, string id, CqlConcept requestStatusReason, CqlDateTime authoredOn)? NoVTEDevice)?>(e_, f_);

        bool? h_((CqlTupleMetadata, Encounter QualifyingEncounter, Procedure AnesthesiaProcedure, (CqlTupleMetadata, string id, CqlConcept requestStatusReason, CqlDateTime authoredOn)? NoVTEDevice)? tuple_cadhcldckpqwmtcazwxfnkhgc) {
            CqlConcept n_ = tuple_cadhcldckpqwmtcazwxfnkhgc?.NoVTEDevice?.requestStatusReason;
            CqlValueSet o_ = this.Medical_Reason_For_Not_Providing_Treatment(context);
            bool? p_ = context.Operators.ConceptInValueSet(n_, o_);
            Code<EventStatus> q_ = tuple_cadhcldckpqwmtcazwxfnkhgc?.AnesthesiaProcedure?.StatusElement;
            EventStatus? r_ = q_?.Value;
            string s_ = context.Operators.Convert<string>(r_);
            bool? t_ = context.Operators.Equal(s_, "completed");
            bool? u_ = context.Operators.And(p_, t_);

            object v_() {

                bool bf_() {
                    DataType bj_ = tuple_cadhcldckpqwmtcazwxfnkhgc?.AnesthesiaProcedure?.Performed;
                    object bk_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bj_);
                    bool bl_ = bk_ is CqlDateTime;
                    return bl_;
                }


                bool bg_() {
                    DataType bm_ = tuple_cadhcldckpqwmtcazwxfnkhgc?.AnesthesiaProcedure?.Performed;
                    object bn_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bm_);
                    bool bo_ = bn_ is CqlInterval<CqlDateTime>;
                    return bo_;
                }


                bool bh_() {
                    DataType bp_ = tuple_cadhcldckpqwmtcazwxfnkhgc?.AnesthesiaProcedure?.Performed;
                    object bq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bp_);
                    bool br_ = bq_ is CqlQuantity;
                    return br_;
                }


                bool bi_() {
                    DataType bs_ = tuple_cadhcldckpqwmtcazwxfnkhgc?.AnesthesiaProcedure?.Performed;
                    object bt_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bs_);
                    bool bu_ = bt_ is CqlInterval<CqlQuantity>;
                    return bu_;
                }

                if (bf_())
                {
                    DataType bv_ = tuple_cadhcldckpqwmtcazwxfnkhgc?.AnesthesiaProcedure?.Performed;
                    object bw_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bv_);
                    return (bw_ as CqlDateTime) as object;
                }
                else if (bg_())
                {
                    DataType bx_ = tuple_cadhcldckpqwmtcazwxfnkhgc?.AnesthesiaProcedure?.Performed;
                    object by_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bx_);
                    return (by_ as CqlInterval<CqlDateTime>) as object;
                }
                else if (bh_())
                {
                    DataType bz_ = tuple_cadhcldckpqwmtcazwxfnkhgc?.AnesthesiaProcedure?.Performed;
                    object ca_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bz_);
                    return (ca_ as CqlQuantity) as object;
                }
                else if (bi_())
                {
                    DataType cb_ = tuple_cadhcldckpqwmtcazwxfnkhgc?.AnesthesiaProcedure?.Performed;
                    object cc_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cb_);
                    return (cc_ as CqlInterval<CqlQuantity>) as object;
                }
                else
                {
                    return null;
                };
            }

            CqlInterval<CqlDateTime> w_ = QICoreCommon_4_0_000.Instance.toInterval(context, v_());
            CqlDateTime x_ = context.Operators.End(w_);
            Period y_ = tuple_cadhcldckpqwmtcazwxfnkhgc?.QualifyingEncounter?.Period;
            CqlInterval<CqlDateTime> z_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, y_);
            CqlDateTime aa_ = context.Operators.Start(z_);
            CqlQuantity ab_ = context.Operators.Quantity(1m, "day");
            CqlDateTime ac_ = context.Operators.Add(aa_, ab_);
            bool? ad_ = context.Operators.SameAs(x_, ac_, "day");
            bool? ae_ = context.Operators.And(u_, ad_);
            CqlDateTime af_ = tuple_cadhcldckpqwmtcazwxfnkhgc?.NoVTEDevice?.authoredOn;

            object ag_() {

                bool cd_() {
                    DataType ch_ = tuple_cadhcldckpqwmtcazwxfnkhgc?.AnesthesiaProcedure?.Performed;
                    object ci_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ch_);
                    bool cj_ = ci_ is CqlDateTime;
                    return cj_;
                }


                bool ce_() {
                    DataType ck_ = tuple_cadhcldckpqwmtcazwxfnkhgc?.AnesthesiaProcedure?.Performed;
                    object cl_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ck_);
                    bool cm_ = cl_ is CqlInterval<CqlDateTime>;
                    return cm_;
                }


                bool cf_() {
                    DataType cn_ = tuple_cadhcldckpqwmtcazwxfnkhgc?.AnesthesiaProcedure?.Performed;
                    object co_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cn_);
                    bool cp_ = co_ is CqlQuantity;
                    return cp_;
                }


                bool cg_() {
                    DataType cq_ = tuple_cadhcldckpqwmtcazwxfnkhgc?.AnesthesiaProcedure?.Performed;
                    object cr_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cq_);
                    bool cs_ = cr_ is CqlInterval<CqlQuantity>;
                    return cs_;
                }

                if (cd_())
                {
                    DataType ct_ = tuple_cadhcldckpqwmtcazwxfnkhgc?.AnesthesiaProcedure?.Performed;
                    object cu_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ct_);
                    return (cu_ as CqlDateTime) as object;
                }
                else if (ce_())
                {
                    DataType cv_ = tuple_cadhcldckpqwmtcazwxfnkhgc?.AnesthesiaProcedure?.Performed;
                    object cw_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cv_);
                    return (cw_ as CqlInterval<CqlDateTime>) as object;
                }
                else if (cf_())
                {
                    DataType cx_ = tuple_cadhcldckpqwmtcazwxfnkhgc?.AnesthesiaProcedure?.Performed;
                    object cy_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cx_);
                    return (cy_ as CqlQuantity) as object;
                }
                else if (cg_())
                {
                    DataType cz_ = tuple_cadhcldckpqwmtcazwxfnkhgc?.AnesthesiaProcedure?.Performed;
                    object da_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cz_);
                    return (da_ as CqlInterval<CqlQuantity>) as object;
                }
                else
                {
                    return null;
                };
            }

            CqlInterval<CqlDateTime> ah_ = QICoreCommon_4_0_000.Instance.toInterval(context, ag_());
            CqlDateTime ai_ = context.Operators.End(ah_);
            CqlInterval<CqlDate> aj_ = TJCOverall_8_25_000.Instance.calendarDayOfOrDayAfter(context, ai_);
            CqlDate ak_ = aj_?.low;
            CqlDateTime al_ = context.Operators.ConvertDateToDateTime(ak_);

            object am_() {

                bool db_() {
                    DataType df_ = tuple_cadhcldckpqwmtcazwxfnkhgc?.AnesthesiaProcedure?.Performed;
                    object dg_ = FHIRHelpers_4_4_000.Instance.ToValue(context, df_);
                    bool dh_ = dg_ is CqlDateTime;
                    return dh_;
                }


                bool dc_() {
                    DataType di_ = tuple_cadhcldckpqwmtcazwxfnkhgc?.AnesthesiaProcedure?.Performed;
                    object dj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, di_);
                    bool dk_ = dj_ is CqlInterval<CqlDateTime>;
                    return dk_;
                }


                bool dd_() {
                    DataType dl_ = tuple_cadhcldckpqwmtcazwxfnkhgc?.AnesthesiaProcedure?.Performed;
                    object dm_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dl_);
                    bool dn_ = dm_ is CqlQuantity;
                    return dn_;
                }


                bool de_() {
                    DataType do_ = tuple_cadhcldckpqwmtcazwxfnkhgc?.AnesthesiaProcedure?.Performed;
                    object dp_ = FHIRHelpers_4_4_000.Instance.ToValue(context, do_);
                    bool dq_ = dp_ is CqlInterval<CqlQuantity>;
                    return dq_;
                }

                if (db_())
                {
                    DataType dr_ = tuple_cadhcldckpqwmtcazwxfnkhgc?.AnesthesiaProcedure?.Performed;
                    object ds_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dr_);
                    return (ds_ as CqlDateTime) as object;
                }
                else if (dc_())
                {
                    DataType dt_ = tuple_cadhcldckpqwmtcazwxfnkhgc?.AnesthesiaProcedure?.Performed;
                    object du_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dt_);
                    return (du_ as CqlInterval<CqlDateTime>) as object;
                }
                else if (dd_())
                {
                    DataType dv_ = tuple_cadhcldckpqwmtcazwxfnkhgc?.AnesthesiaProcedure?.Performed;
                    object dw_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dv_);
                    return (dw_ as CqlQuantity) as object;
                }
                else if (de_())
                {
                    DataType dx_ = tuple_cadhcldckpqwmtcazwxfnkhgc?.AnesthesiaProcedure?.Performed;
                    object dy_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dx_);
                    return (dy_ as CqlInterval<CqlQuantity>) as object;
                }
                else
                {
                    return null;
                };
            }

            CqlInterval<CqlDateTime> an_ = QICoreCommon_4_0_000.Instance.toInterval(context, am_());
            CqlDateTime ao_ = context.Operators.End(an_);
            CqlInterval<CqlDate> ap_ = TJCOverall_8_25_000.Instance.calendarDayOfOrDayAfter(context, ao_);
            CqlDate aq_ = ap_?.high;
            CqlDateTime ar_ = context.Operators.ConvertDateToDateTime(aq_);

            object as_() {

                bool dz_() {
                    DataType ed_ = tuple_cadhcldckpqwmtcazwxfnkhgc?.AnesthesiaProcedure?.Performed;
                    object ee_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ed_);
                    bool ef_ = ee_ is CqlDateTime;
                    return ef_;
                }


                bool ea_() {
                    DataType eg_ = tuple_cadhcldckpqwmtcazwxfnkhgc?.AnesthesiaProcedure?.Performed;
                    object eh_ = FHIRHelpers_4_4_000.Instance.ToValue(context, eg_);
                    bool ei_ = eh_ is CqlInterval<CqlDateTime>;
                    return ei_;
                }


                bool eb_() {
                    DataType ej_ = tuple_cadhcldckpqwmtcazwxfnkhgc?.AnesthesiaProcedure?.Performed;
                    object ek_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ej_);
                    bool el_ = ek_ is CqlQuantity;
                    return el_;
                }


                bool ec_() {
                    DataType em_ = tuple_cadhcldckpqwmtcazwxfnkhgc?.AnesthesiaProcedure?.Performed;
                    object en_ = FHIRHelpers_4_4_000.Instance.ToValue(context, em_);
                    bool eo_ = en_ is CqlInterval<CqlQuantity>;
                    return eo_;
                }

                if (dz_())
                {
                    DataType ep_ = tuple_cadhcldckpqwmtcazwxfnkhgc?.AnesthesiaProcedure?.Performed;
                    object eq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ep_);
                    return (eq_ as CqlDateTime) as object;
                }
                else if (ea_())
                {
                    DataType er_ = tuple_cadhcldckpqwmtcazwxfnkhgc?.AnesthesiaProcedure?.Performed;
                    object es_ = FHIRHelpers_4_4_000.Instance.ToValue(context, er_);
                    return (es_ as CqlInterval<CqlDateTime>) as object;
                }
                else if (eb_())
                {
                    DataType et_ = tuple_cadhcldckpqwmtcazwxfnkhgc?.AnesthesiaProcedure?.Performed;
                    object eu_ = FHIRHelpers_4_4_000.Instance.ToValue(context, et_);
                    return (eu_ as CqlQuantity) as object;
                }
                else if (ec_())
                {
                    DataType ev_ = tuple_cadhcldckpqwmtcazwxfnkhgc?.AnesthesiaProcedure?.Performed;
                    object ew_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ev_);
                    return (ew_ as CqlInterval<CqlQuantity>) as object;
                }
                else
                {
                    return null;
                };
            }

            CqlInterval<CqlDateTime> at_ = QICoreCommon_4_0_000.Instance.toInterval(context, as_());
            CqlDateTime au_ = context.Operators.End(at_);
            CqlInterval<CqlDate> av_ = TJCOverall_8_25_000.Instance.calendarDayOfOrDayAfter(context, au_);
            bool? aw_ = av_?.lowClosed;

            object ax_() {

                bool ex_() {
                    DataType fb_ = tuple_cadhcldckpqwmtcazwxfnkhgc?.AnesthesiaProcedure?.Performed;
                    object fc_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fb_);
                    bool fd_ = fc_ is CqlDateTime;
                    return fd_;
                }


                bool ey_() {
                    DataType fe_ = tuple_cadhcldckpqwmtcazwxfnkhgc?.AnesthesiaProcedure?.Performed;
                    object ff_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fe_);
                    bool fg_ = ff_ is CqlInterval<CqlDateTime>;
                    return fg_;
                }


                bool ez_() {
                    DataType fh_ = tuple_cadhcldckpqwmtcazwxfnkhgc?.AnesthesiaProcedure?.Performed;
                    object fi_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fh_);
                    bool fj_ = fi_ is CqlQuantity;
                    return fj_;
                }


                bool fa_() {
                    DataType fk_ = tuple_cadhcldckpqwmtcazwxfnkhgc?.AnesthesiaProcedure?.Performed;
                    object fl_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fk_);
                    bool fm_ = fl_ is CqlInterval<CqlQuantity>;
                    return fm_;
                }

                if (ex_())
                {
                    DataType fn_ = tuple_cadhcldckpqwmtcazwxfnkhgc?.AnesthesiaProcedure?.Performed;
                    object fo_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fn_);
                    return (fo_ as CqlDateTime) as object;
                }
                else if (ey_())
                {
                    DataType fp_ = tuple_cadhcldckpqwmtcazwxfnkhgc?.AnesthesiaProcedure?.Performed;
                    object fq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fp_);
                    return (fq_ as CqlInterval<CqlDateTime>) as object;
                }
                else if (ez_())
                {
                    DataType fr_ = tuple_cadhcldckpqwmtcazwxfnkhgc?.AnesthesiaProcedure?.Performed;
                    object fs_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fr_);
                    return (fs_ as CqlQuantity) as object;
                }
                else if (fa_())
                {
                    DataType ft_ = tuple_cadhcldckpqwmtcazwxfnkhgc?.AnesthesiaProcedure?.Performed;
                    object fu_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ft_);
                    return (fu_ as CqlInterval<CqlQuantity>) as object;
                }
                else
                {
                    return null;
                };
            }

            CqlInterval<CqlDateTime> ay_ = QICoreCommon_4_0_000.Instance.toInterval(context, ax_());
            CqlDateTime az_ = context.Operators.End(ay_);
            CqlInterval<CqlDate> ba_ = TJCOverall_8_25_000.Instance.calendarDayOfOrDayAfter(context, az_);
            bool? bb_ = ba_?.highClosed;
            CqlInterval<CqlDateTime> bc_ = context.Operators.Interval(al_, ar_, aw_, bb_);
            bool? bd_ = context.Operators.In<CqlDateTime>(af_, bc_, "day");
            bool? be_ = context.Operators.And(ae_, bd_);
            return be_;
        }

        IEnumerable<(CqlTupleMetadata, Encounter QualifyingEncounter, Procedure AnesthesiaProcedure, (CqlTupleMetadata, string id, CqlConcept requestStatusReason, CqlDateTime authoredOn)? NoVTEDevice)?> i_ = context.Operators.Where<(CqlTupleMetadata, Encounter QualifyingEncounter, Procedure AnesthesiaProcedure, (CqlTupleMetadata, string id, CqlConcept requestStatusReason, CqlDateTime authoredOn)? NoVTEDevice)?>(g_, h_);
        Encounter j_((CqlTupleMetadata, Encounter QualifyingEncounter, Procedure AnesthesiaProcedure, (CqlTupleMetadata, string id, CqlConcept requestStatusReason, CqlDateTime authoredOn)? NoVTEDevice)? tuple_cadhcldckpqwmtcazwxfnkhgc) => tuple_cadhcldckpqwmtcazwxfnkhgc?.QualifyingEncounter;
        IEnumerable<Encounter> k_ = context.Operators.Select<(CqlTupleMetadata, Encounter QualifyingEncounter, Procedure AnesthesiaProcedure, (CqlTupleMetadata, string id, CqlConcept requestStatusReason, CqlDateTime authoredOn)? NoVTEDevice)?, Encounter>(i_, j_);
        IEnumerable<Encounter> l_ = context.Operators.Distinct<Encounter>(k_);
        return l_;
    }


    [CqlExpressionDefinition("Encounter With No VTE Prophylaxis Due To Medical Reason")]
    public IEnumerable<Encounter> Encounter_With_No_VTE_Prophylaxis_Due_To_Medical_Reason(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Encounter_With_No_VTE_Prophylaxis_Due_To_Medical_Reason, Encounter_With_No_VTE_Prophylaxis_Due_To_Medical_Reason_Compute);

    private const long _cacheIndex_Encounter_With_No_VTE_Prophylaxis_Due_To_Medical_Reason = 5299751816536655779L;

    private IEnumerable<Encounter> Encounter_With_No_VTE_Prophylaxis_Due_To_Medical_Reason_Compute(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.No_VTE_Prophylaxis_Medication_Due_To_Medical_Reason_From_Day_Of_Start_Of_Hospitalization_To_Day_After_Admission(context);
        IEnumerable<Encounter> b_ = this.No_Mechanical_VTE_Prophylaxis_Due_To_Medical_Reason_From_Day_Of_Start_Of_Hospitalization_To_Day_After_Admission(context);
        IEnumerable<Encounter> c_ = context.Operators.Intersect<Encounter>(a_, b_);
        IEnumerable<Encounter> d_ = this.No_VTE_Prophylaxis_Medication_Due_To_Medical_Reason_On_Day_Of_Or_Day_After_Procedure(context);
        IEnumerable<Encounter> e_ = this.No_Mechanical_VTE_Prophylaxis_Due_To_Medical_Reason_On_Day_Of_Or_Day_After_Procedure(context);
        IEnumerable<Encounter> f_ = context.Operators.Intersect<Encounter>(d_, e_);
        IEnumerable<Encounter> g_ = context.Operators.Union<Encounter>(c_, f_);
        return g_;
    }


    [CqlExpressionDefinition("No Mechanical Or Pharmacological VTE Prophylaxis Due To Patient Refusal")]
    public IEnumerable<object> No_Mechanical_Or_Pharmacological_VTE_Prophylaxis_Due_To_Patient_Refusal(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_No_Mechanical_Or_Pharmacological_VTE_Prophylaxis_Due_To_Patient_Refusal, No_Mechanical_Or_Pharmacological_VTE_Prophylaxis_Due_To_Patient_Refusal_Compute);

    private const long _cacheIndex_No_Mechanical_Or_Pharmacological_VTE_Prophylaxis_Due_To_Patient_Refusal = -1208625367494253294L;

    private IEnumerable<object> No_Mechanical_Or_Pharmacological_VTE_Prophylaxis_Due_To_Patient_Refusal_Compute(CqlContext context)
    {
        IEnumerable<(CqlTupleMetadata, string id, IEnumerable<CqlConcept> medicationStatusReason, CqlDateTime authoredOn)?> a_ = this.No_VTE_Prophylaxis_Medication_Administered_Or_Ordered(context);

        bool? b_((CqlTupleMetadata, string id, IEnumerable<CqlConcept> medicationStatusReason, CqlDateTime authoredOn)? NoVTEMedication) {
            IEnumerable<CqlConcept> h_ = NoVTEMedication?.medicationStatusReason;

            bool? i_(CqlConcept MedRsn) {
                CqlValueSet l_ = this.Patient_Refusal(context);
                bool? m_ = context.Operators.ConceptInValueSet(MedRsn, l_);
                return m_;
            }

            IEnumerable<CqlConcept> j_ = context.Operators.Where<CqlConcept>(h_, i_);
            bool? k_ = context.Operators.Exists<CqlConcept>(j_);
            return k_;
        }

        IEnumerable<(CqlTupleMetadata, string id, IEnumerable<CqlConcept> medicationStatusReason, CqlDateTime authoredOn)?> c_ = context.Operators.Where<(CqlTupleMetadata, string id, IEnumerable<CqlConcept> medicationStatusReason, CqlDateTime authoredOn)?>(a_, b_);
        IEnumerable<(CqlTupleMetadata, string id, CqlConcept requestStatusReason, CqlDateTime authoredOn)?> d_ = this.No_Mechanical_VTE_Prophylaxis_Performed_Or_Ordered(context);

        bool? e_((CqlTupleMetadata, string id, CqlConcept requestStatusReason, CqlDateTime authoredOn)? NoVTEDevice) {
            CqlConcept n_ = NoVTEDevice?.requestStatusReason;
            CqlValueSet o_ = this.Patient_Refusal(context);
            bool? p_ = context.Operators.ConceptInValueSet(n_, o_);
            return p_;
        }

        IEnumerable<(CqlTupleMetadata, string id, CqlConcept requestStatusReason, CqlDateTime authoredOn)?> f_ = context.Operators.Where<(CqlTupleMetadata, string id, CqlConcept requestStatusReason, CqlDateTime authoredOn)?>(d_, e_);
        IEnumerable<object> g_ = context.Operators.Union<object>(c_ as IEnumerable<object>, f_ as IEnumerable<object>);
        return g_;
    }


    [CqlExpressionDefinition("No VTE Prophylaxis Due To Patient Refusal From Day Of Start Of Hospitalization To Day After Admission")]
    public IEnumerable<Encounter> No_VTE_Prophylaxis_Due_To_Patient_Refusal_From_Day_Of_Start_Of_Hospitalization_To_Day_After_Admission(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_No_VTE_Prophylaxis_Due_To_Patient_Refusal_From_Day_Of_Start_Of_Hospitalization_To_Day_After_Admission, No_VTE_Prophylaxis_Due_To_Patient_Refusal_From_Day_Of_Start_Of_Hospitalization_To_Day_After_Admission_Compute);

    private const long _cacheIndex_No_VTE_Prophylaxis_Due_To_Patient_Refusal_From_Day_Of_Start_Of_Hospitalization_To_Day_After_Admission = -971453516603949919L;

    private IEnumerable<Encounter> No_VTE_Prophylaxis_Due_To_Patient_Refusal_From_Day_Of_Start_Of_Hospitalization_To_Day_After_Admission_Compute(CqlContext context)
    {
        IEnumerable<Encounter> a_ = VTE_8_18_000.Instance.Encounter_With_Age_Range_And_Without_VTE_Diagnosis_Or_Obstetrical_Conditions(context);

        bool? b_(Encounter QualifyingEncounter) {
            IEnumerable<object> d_ = this.No_Mechanical_Or_Pharmacological_VTE_Prophylaxis_Due_To_Patient_Refusal(context);

            bool? e_(object PatientRefusal) {
                CqlDateTime h_ = context.Operators.LateBoundProperty<CqlDateTime>(PatientRefusal, "authoredOn");
                CqlInterval<CqlDate> i_ = this.fromDayOfStartOfHospitalizationToDayAfterAdmission(context, QualifyingEncounter);
                CqlDate j_ = i_?.low;
                CqlDateTime k_ = context.Operators.ConvertDateToDateTime(j_);
                CqlDate m_ = i_?.high;
                CqlDateTime n_ = context.Operators.ConvertDateToDateTime(m_);
                bool? p_ = i_?.lowClosed;
                bool? r_ = i_?.highClosed;
                CqlInterval<CqlDateTime> s_ = context.Operators.Interval(k_, n_, p_, r_);
                bool? t_ = context.Operators.In<CqlDateTime>(h_, s_, "day");
                return t_;
            }

            IEnumerable<object> f_ = context.Operators.Where<object>(d_, e_);
            bool? g_ = context.Operators.Exists<object>(f_);
            return g_;
        }

        IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);
        return c_;
    }


    [CqlExpressionDefinition("No VTE Prophylaxis Due To Patient Refusal On Day Of Or Day After Procedure")]
    public IEnumerable<Encounter> No_VTE_Prophylaxis_Due_To_Patient_Refusal_On_Day_Of_Or_Day_After_Procedure(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_No_VTE_Prophylaxis_Due_To_Patient_Refusal_On_Day_Of_Or_Day_After_Procedure, No_VTE_Prophylaxis_Due_To_Patient_Refusal_On_Day_Of_Or_Day_After_Procedure_Compute);

    private const long _cacheIndex_No_VTE_Prophylaxis_Due_To_Patient_Refusal_On_Day_Of_Or_Day_After_Procedure = 98430516828796694L;

    private IEnumerable<Encounter> No_VTE_Prophylaxis_Due_To_Patient_Refusal_On_Day_Of_Or_Day_After_Procedure_Compute(CqlContext context)
    {
        IEnumerable<Encounter> a_ = VTE_8_18_000.Instance.Encounter_With_Age_Range_And_Without_VTE_Diagnosis_Or_Obstetrical_Conditions(context);
        CqlValueSet b_ = this.General_or_Neuraxial_Anesthesia(context);
        IEnumerable<Procedure> c_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, b_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
        IEnumerable<object> d_ = this.No_Mechanical_Or_Pharmacological_VTE_Prophylaxis_Due_To_Patient_Refusal(context);
        IEnumerable<ValueTuple<Encounter, Procedure, object>> e_ = context.Operators.CrossJoin<Encounter, Procedure, object>(a_, c_, d_);

        (CqlTupleMetadata, Encounter QualifyingEncounter, Procedure AnesthesiaProcedure, object PatientRefusal)? f_(ValueTuple<Encounter, Procedure, object> _valueTuple) {
            (CqlTupleMetadata, Encounter QualifyingEncounter, Procedure AnesthesiaProcedure, object PatientRefusal)? m_ = (CqlTupleMetadata_EPgUKHFGKDiGHBcZKVcEFWgbe, _valueTuple.Item1, _valueTuple.Item2, _valueTuple.Item3);
            return m_;
        }

        IEnumerable<(CqlTupleMetadata, Encounter QualifyingEncounter, Procedure AnesthesiaProcedure, object PatientRefusal)?> g_ = context.Operators.Select<ValueTuple<Encounter, Procedure, object>, (CqlTupleMetadata, Encounter QualifyingEncounter, Procedure AnesthesiaProcedure, object PatientRefusal)?>(e_, f_);

        bool? h_((CqlTupleMetadata, Encounter QualifyingEncounter, Procedure AnesthesiaProcedure, object PatientRefusal)? tuple_fpeghttqsjgusnbabduddbjbh) {
            Code<EventStatus> n_ = tuple_fpeghttqsjgusnbabduddbjbh?.AnesthesiaProcedure?.StatusElement;
            EventStatus? o_ = n_?.Value;
            string p_ = context.Operators.Convert<string>(o_);
            bool? q_ = context.Operators.Equal(p_, "completed");

            object r_() {

                bool bb_() {
                    DataType bf_ = tuple_fpeghttqsjgusnbabduddbjbh?.AnesthesiaProcedure?.Performed;
                    object bg_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bf_);
                    bool bh_ = bg_ is CqlDateTime;
                    return bh_;
                }


                bool bc_() {
                    DataType bi_ = tuple_fpeghttqsjgusnbabduddbjbh?.AnesthesiaProcedure?.Performed;
                    object bj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bi_);
                    bool bk_ = bj_ is CqlInterval<CqlDateTime>;
                    return bk_;
                }


                bool bd_() {
                    DataType bl_ = tuple_fpeghttqsjgusnbabduddbjbh?.AnesthesiaProcedure?.Performed;
                    object bm_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bl_);
                    bool bn_ = bm_ is CqlQuantity;
                    return bn_;
                }


                bool be_() {
                    DataType bo_ = tuple_fpeghttqsjgusnbabduddbjbh?.AnesthesiaProcedure?.Performed;
                    object bp_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bo_);
                    bool bq_ = bp_ is CqlInterval<CqlQuantity>;
                    return bq_;
                }

                if (bb_())
                {
                    DataType br_ = tuple_fpeghttqsjgusnbabduddbjbh?.AnesthesiaProcedure?.Performed;
                    object bs_ = FHIRHelpers_4_4_000.Instance.ToValue(context, br_);
                    return (bs_ as CqlDateTime) as object;
                }
                else if (bc_())
                {
                    DataType bt_ = tuple_fpeghttqsjgusnbabduddbjbh?.AnesthesiaProcedure?.Performed;
                    object bu_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bt_);
                    return (bu_ as CqlInterval<CqlDateTime>) as object;
                }
                else if (bd_())
                {
                    DataType bv_ = tuple_fpeghttqsjgusnbabduddbjbh?.AnesthesiaProcedure?.Performed;
                    object bw_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bv_);
                    return (bw_ as CqlQuantity) as object;
                }
                else if (be_())
                {
                    DataType bx_ = tuple_fpeghttqsjgusnbabduddbjbh?.AnesthesiaProcedure?.Performed;
                    object by_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bx_);
                    return (by_ as CqlInterval<CqlQuantity>) as object;
                }
                else
                {
                    return null;
                };
            }

            CqlInterval<CqlDateTime> s_ = QICoreCommon_4_0_000.Instance.toInterval(context, r_());
            CqlDateTime t_ = context.Operators.End(s_);
            Period u_ = tuple_fpeghttqsjgusnbabduddbjbh?.QualifyingEncounter?.Period;
            CqlInterval<CqlDateTime> v_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, u_);
            CqlDateTime w_ = context.Operators.Start(v_);
            CqlQuantity x_ = context.Operators.Quantity(1m, "day");
            CqlDateTime y_ = context.Operators.Add(w_, x_);
            bool? z_ = context.Operators.SameAs(t_, y_, "day");
            bool? aa_ = context.Operators.And(q_, z_);
            CqlDateTime ab_ = context.Operators.LateBoundProperty<CqlDateTime>(tuple_fpeghttqsjgusnbabduddbjbh?.PatientRefusal, "authoredOn");

            object ac_() {

                bool bz_() {
                    DataType cd_ = tuple_fpeghttqsjgusnbabduddbjbh?.AnesthesiaProcedure?.Performed;
                    object ce_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cd_);
                    bool cf_ = ce_ is CqlDateTime;
                    return cf_;
                }


                bool ca_() {
                    DataType cg_ = tuple_fpeghttqsjgusnbabduddbjbh?.AnesthesiaProcedure?.Performed;
                    object ch_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cg_);
                    bool ci_ = ch_ is CqlInterval<CqlDateTime>;
                    return ci_;
                }


                bool cb_() {
                    DataType cj_ = tuple_fpeghttqsjgusnbabduddbjbh?.AnesthesiaProcedure?.Performed;
                    object ck_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cj_);
                    bool cl_ = ck_ is CqlQuantity;
                    return cl_;
                }


                bool cc_() {
                    DataType cm_ = tuple_fpeghttqsjgusnbabduddbjbh?.AnesthesiaProcedure?.Performed;
                    object cn_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cm_);
                    bool co_ = cn_ is CqlInterval<CqlQuantity>;
                    return co_;
                }

                if (bz_())
                {
                    DataType cp_ = tuple_fpeghttqsjgusnbabduddbjbh?.AnesthesiaProcedure?.Performed;
                    object cq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cp_);
                    return (cq_ as CqlDateTime) as object;
                }
                else if (ca_())
                {
                    DataType cr_ = tuple_fpeghttqsjgusnbabduddbjbh?.AnesthesiaProcedure?.Performed;
                    object cs_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cr_);
                    return (cs_ as CqlInterval<CqlDateTime>) as object;
                }
                else if (cb_())
                {
                    DataType ct_ = tuple_fpeghttqsjgusnbabduddbjbh?.AnesthesiaProcedure?.Performed;
                    object cu_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ct_);
                    return (cu_ as CqlQuantity) as object;
                }
                else if (cc_())
                {
                    DataType cv_ = tuple_fpeghttqsjgusnbabduddbjbh?.AnesthesiaProcedure?.Performed;
                    object cw_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cv_);
                    return (cw_ as CqlInterval<CqlQuantity>) as object;
                }
                else
                {
                    return null;
                };
            }

            CqlInterval<CqlDateTime> ad_ = QICoreCommon_4_0_000.Instance.toInterval(context, ac_());
            CqlDateTime ae_ = context.Operators.End(ad_);
            CqlInterval<CqlDate> af_ = TJCOverall_8_25_000.Instance.calendarDayOfOrDayAfter(context, ae_);
            CqlDate ag_ = af_?.low;
            CqlDateTime ah_ = context.Operators.ConvertDateToDateTime(ag_);

            object ai_() {

                bool cx_() {
                    DataType db_ = tuple_fpeghttqsjgusnbabduddbjbh?.AnesthesiaProcedure?.Performed;
                    object dc_ = FHIRHelpers_4_4_000.Instance.ToValue(context, db_);
                    bool dd_ = dc_ is CqlDateTime;
                    return dd_;
                }


                bool cy_() {
                    DataType de_ = tuple_fpeghttqsjgusnbabduddbjbh?.AnesthesiaProcedure?.Performed;
                    object df_ = FHIRHelpers_4_4_000.Instance.ToValue(context, de_);
                    bool dg_ = df_ is CqlInterval<CqlDateTime>;
                    return dg_;
                }


                bool cz_() {
                    DataType dh_ = tuple_fpeghttqsjgusnbabduddbjbh?.AnesthesiaProcedure?.Performed;
                    object di_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dh_);
                    bool dj_ = di_ is CqlQuantity;
                    return dj_;
                }


                bool da_() {
                    DataType dk_ = tuple_fpeghttqsjgusnbabduddbjbh?.AnesthesiaProcedure?.Performed;
                    object dl_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dk_);
                    bool dm_ = dl_ is CqlInterval<CqlQuantity>;
                    return dm_;
                }

                if (cx_())
                {
                    DataType dn_ = tuple_fpeghttqsjgusnbabduddbjbh?.AnesthesiaProcedure?.Performed;
                    object do_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dn_);
                    return (do_ as CqlDateTime) as object;
                }
                else if (cy_())
                {
                    DataType dp_ = tuple_fpeghttqsjgusnbabduddbjbh?.AnesthesiaProcedure?.Performed;
                    object dq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dp_);
                    return (dq_ as CqlInterval<CqlDateTime>) as object;
                }
                else if (cz_())
                {
                    DataType dr_ = tuple_fpeghttqsjgusnbabduddbjbh?.AnesthesiaProcedure?.Performed;
                    object ds_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dr_);
                    return (ds_ as CqlQuantity) as object;
                }
                else if (da_())
                {
                    DataType dt_ = tuple_fpeghttqsjgusnbabduddbjbh?.AnesthesiaProcedure?.Performed;
                    object du_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dt_);
                    return (du_ as CqlInterval<CqlQuantity>) as object;
                }
                else
                {
                    return null;
                };
            }

            CqlInterval<CqlDateTime> aj_ = QICoreCommon_4_0_000.Instance.toInterval(context, ai_());
            CqlDateTime ak_ = context.Operators.End(aj_);
            CqlInterval<CqlDate> al_ = TJCOverall_8_25_000.Instance.calendarDayOfOrDayAfter(context, ak_);
            CqlDate am_ = al_?.high;
            CqlDateTime an_ = context.Operators.ConvertDateToDateTime(am_);

            object ao_() {

                bool dv_() {
                    DataType dz_ = tuple_fpeghttqsjgusnbabduddbjbh?.AnesthesiaProcedure?.Performed;
                    object ea_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dz_);
                    bool eb_ = ea_ is CqlDateTime;
                    return eb_;
                }


                bool dw_() {
                    DataType ec_ = tuple_fpeghttqsjgusnbabduddbjbh?.AnesthesiaProcedure?.Performed;
                    object ed_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ec_);
                    bool ee_ = ed_ is CqlInterval<CqlDateTime>;
                    return ee_;
                }


                bool dx_() {
                    DataType ef_ = tuple_fpeghttqsjgusnbabduddbjbh?.AnesthesiaProcedure?.Performed;
                    object eg_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ef_);
                    bool eh_ = eg_ is CqlQuantity;
                    return eh_;
                }


                bool dy_() {
                    DataType ei_ = tuple_fpeghttqsjgusnbabduddbjbh?.AnesthesiaProcedure?.Performed;
                    object ej_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ei_);
                    bool ek_ = ej_ is CqlInterval<CqlQuantity>;
                    return ek_;
                }

                if (dv_())
                {
                    DataType el_ = tuple_fpeghttqsjgusnbabduddbjbh?.AnesthesiaProcedure?.Performed;
                    object em_ = FHIRHelpers_4_4_000.Instance.ToValue(context, el_);
                    return (em_ as CqlDateTime) as object;
                }
                else if (dw_())
                {
                    DataType en_ = tuple_fpeghttqsjgusnbabduddbjbh?.AnesthesiaProcedure?.Performed;
                    object eo_ = FHIRHelpers_4_4_000.Instance.ToValue(context, en_);
                    return (eo_ as CqlInterval<CqlDateTime>) as object;
                }
                else if (dx_())
                {
                    DataType ep_ = tuple_fpeghttqsjgusnbabduddbjbh?.AnesthesiaProcedure?.Performed;
                    object eq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ep_);
                    return (eq_ as CqlQuantity) as object;
                }
                else if (dy_())
                {
                    DataType er_ = tuple_fpeghttqsjgusnbabduddbjbh?.AnesthesiaProcedure?.Performed;
                    object es_ = FHIRHelpers_4_4_000.Instance.ToValue(context, er_);
                    return (es_ as CqlInterval<CqlQuantity>) as object;
                }
                else
                {
                    return null;
                };
            }

            CqlInterval<CqlDateTime> ap_ = QICoreCommon_4_0_000.Instance.toInterval(context, ao_());
            CqlDateTime aq_ = context.Operators.End(ap_);
            CqlInterval<CqlDate> ar_ = TJCOverall_8_25_000.Instance.calendarDayOfOrDayAfter(context, aq_);
            bool? as_ = ar_?.lowClosed;

            object at_() {

                bool et_() {
                    DataType ex_ = tuple_fpeghttqsjgusnbabduddbjbh?.AnesthesiaProcedure?.Performed;
                    object ey_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ex_);
                    bool ez_ = ey_ is CqlDateTime;
                    return ez_;
                }


                bool eu_() {
                    DataType fa_ = tuple_fpeghttqsjgusnbabduddbjbh?.AnesthesiaProcedure?.Performed;
                    object fb_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fa_);
                    bool fc_ = fb_ is CqlInterval<CqlDateTime>;
                    return fc_;
                }


                bool ev_() {
                    DataType fd_ = tuple_fpeghttqsjgusnbabduddbjbh?.AnesthesiaProcedure?.Performed;
                    object fe_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fd_);
                    bool ff_ = fe_ is CqlQuantity;
                    return ff_;
                }


                bool ew_() {
                    DataType fg_ = tuple_fpeghttqsjgusnbabduddbjbh?.AnesthesiaProcedure?.Performed;
                    object fh_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fg_);
                    bool fi_ = fh_ is CqlInterval<CqlQuantity>;
                    return fi_;
                }

                if (et_())
                {
                    DataType fj_ = tuple_fpeghttqsjgusnbabduddbjbh?.AnesthesiaProcedure?.Performed;
                    object fk_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fj_);
                    return (fk_ as CqlDateTime) as object;
                }
                else if (eu_())
                {
                    DataType fl_ = tuple_fpeghttqsjgusnbabduddbjbh?.AnesthesiaProcedure?.Performed;
                    object fm_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fl_);
                    return (fm_ as CqlInterval<CqlDateTime>) as object;
                }
                else if (ev_())
                {
                    DataType fn_ = tuple_fpeghttqsjgusnbabduddbjbh?.AnesthesiaProcedure?.Performed;
                    object fo_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fn_);
                    return (fo_ as CqlQuantity) as object;
                }
                else if (ew_())
                {
                    DataType fp_ = tuple_fpeghttqsjgusnbabduddbjbh?.AnesthesiaProcedure?.Performed;
                    object fq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fp_);
                    return (fq_ as CqlInterval<CqlQuantity>) as object;
                }
                else
                {
                    return null;
                };
            }

            CqlInterval<CqlDateTime> au_ = QICoreCommon_4_0_000.Instance.toInterval(context, at_());
            CqlDateTime av_ = context.Operators.End(au_);
            CqlInterval<CqlDate> aw_ = TJCOverall_8_25_000.Instance.calendarDayOfOrDayAfter(context, av_);
            bool? ax_ = aw_?.highClosed;
            CqlInterval<CqlDateTime> ay_ = context.Operators.Interval(ah_, an_, as_, ax_);
            bool? az_ = context.Operators.In<CqlDateTime>(ab_, ay_, "day");
            bool? ba_ = context.Operators.And(aa_, az_);
            return ba_;
        }

        IEnumerable<(CqlTupleMetadata, Encounter QualifyingEncounter, Procedure AnesthesiaProcedure, object PatientRefusal)?> i_ = context.Operators.Where<(CqlTupleMetadata, Encounter QualifyingEncounter, Procedure AnesthesiaProcedure, object PatientRefusal)?>(g_, h_);
        Encounter j_((CqlTupleMetadata, Encounter QualifyingEncounter, Procedure AnesthesiaProcedure, object PatientRefusal)? tuple_fpeghttqsjgusnbabduddbjbh) => tuple_fpeghttqsjgusnbabduddbjbh?.QualifyingEncounter;
        IEnumerable<Encounter> k_ = context.Operators.Select<(CqlTupleMetadata, Encounter QualifyingEncounter, Procedure AnesthesiaProcedure, object PatientRefusal)?, Encounter>(i_, j_);
        IEnumerable<Encounter> l_ = context.Operators.Distinct<Encounter>(k_);
        return l_;
    }


    [CqlExpressionDefinition("Encounter With No VTE Prophylaxis Due To Patient Refusal")]
    public IEnumerable<Encounter> Encounter_With_No_VTE_Prophylaxis_Due_To_Patient_Refusal(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Encounter_With_No_VTE_Prophylaxis_Due_To_Patient_Refusal, Encounter_With_No_VTE_Prophylaxis_Due_To_Patient_Refusal_Compute);

    private const long _cacheIndex_Encounter_With_No_VTE_Prophylaxis_Due_To_Patient_Refusal = -3835470181507784630L;

    private IEnumerable<Encounter> Encounter_With_No_VTE_Prophylaxis_Due_To_Patient_Refusal_Compute(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.No_VTE_Prophylaxis_Due_To_Patient_Refusal_From_Day_Of_Start_Of_Hospitalization_To_Day_After_Admission(context);
        IEnumerable<Encounter> b_ = this.No_VTE_Prophylaxis_Due_To_Patient_Refusal_On_Day_Of_Or_Day_After_Procedure(context);
        IEnumerable<Encounter> c_ = context.Operators.Union<Encounter>(a_, b_);
        return c_;
    }


    [CqlExpressionDefinition("Numerator")]
    public IEnumerable<Encounter> Numerator(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Numerator, Numerator_Compute);

    private const long _cacheIndex_Numerator = -5524035549190864910L;

    private IEnumerable<Encounter> Numerator_Compute(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Encounter_With_VTE_Prophylaxis_Received_From_Day_Of_Start_Of_Hospitalization_To_Day_After_Admission_Or_Procedure(context);
        IEnumerable<Encounter> b_ = this.Encounter_With_Medication_Oral_Factor_Xa_Inhibitor_Administered_On_Day_Of_Or_Day_After_Admission_Or_Procedure(context);
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


    #endregion Functions and Expressions

    #region Singleton Lifetime Members

    private CMS108FHIRVTEProphylaxis_1_0_000() {}

    public static CMS108FHIRVTEProphylaxis_1_0_000 Instance { get; } = new();

    #endregion

    #region ILibrary Implementation

    public string Name => "CMS108FHIRVTEProphylaxis";
    public string Version => "1.0.000";
    public ILibrary[] Dependencies => [CQMCommon_4_1_000.Instance, QICoreCommon_4_0_000.Instance, FHIRHelpers_4_4_000.Instance, SupplementalDataElements_5_1_000.Instance, TJCOverall_8_25_000.Instance, VTE_8_18_000.Instance];

    #endregion ILibrary Implementation

    #region CqlTupleMetadata Properties

    private static CqlTupleMetadata CqlTupleMetadata_BgZKHMDEKXWfPTIRTZCcXPUFU = new(
       [typeof(Encounter), typeof(Procedure), typeof(object)],
       ["QualifyingEncounter", "AnesthesiaProcedure", "ComfortMeasure"]);

    private static CqlTupleMetadata CqlTupleMetadata_CdgLdDFHNTDXFGGVTOMXhQZR = new(
       [typeof(Encounter), typeof(Procedure), typeof(MedicationAdministration)],
       ["QualifyingEncounter", "AnesthesiaProcedure", "FactorXaMedication"]);

    private static CqlTupleMetadata CqlTupleMetadata_CfSFUFiTWJJfiZASQhERUdATP = new(
       [typeof(Encounter), typeof(Procedure), typeof(object)],
       ["QualifyingEncounter", "AnesthesiaProcedure", "VTEProphylaxis"]);

    private static CqlTupleMetadata CqlTupleMetadata_CNeQfiIHcQEUBjZNVZiOLfdeP = new(
       [typeof(string), typeof(IEnumerable<CqlConcept>), typeof(CqlDateTime)],
       ["id", "medicationStatusReason", "authoredOn"]);

    private static CqlTupleMetadata CqlTupleMetadata_CUUMXUZWiBObPgSAjXGJDhdYW = new(
       [typeof(Encounter), typeof(Procedure), typeof((CqlTupleMetadata, string id, IEnumerable<CqlConcept> medicationStatusReason, CqlDateTime authoredOn)?)],
       ["QualifyingEncounter", "AnesthesiaProcedure", "NoVTEMedication"]);

    private static CqlTupleMetadata CqlTupleMetadata_DheTAGNHbFgKVJGaRbPLJVjKH = new(
       [typeof(string), typeof(CqlConcept), typeof(CqlDateTime)],
       ["id", "requestStatusReason", "authoredOn"]);

    private static CqlTupleMetadata CqlTupleMetadata_DMAfXNhTfZDWOGdfEceXbfaSJ = new(
       [typeof(string), typeof(CqlDateTime)],
       ["id", "LowRiskDatetime"]);

    private static CqlTupleMetadata CqlTupleMetadata_DPXDaXjPQUNAIiZCCbGhNdDMi = new(
       [typeof(string), typeof(CqlConcept), typeof(FhirDateTime)],
       ["id", "requestStatusReason", "authoredOn"]);

    private static CqlTupleMetadata CqlTupleMetadata_DQDJDfNDAVfLFYEjYSBYIhgSj = new(
       [typeof(Encounter), typeof(object)],
       ["QualifyingEncounter", "VTEProphylaxis"]);

    private static CqlTupleMetadata CqlTupleMetadata_EBcSahXYZdeFjUUbgULReCZAe = new(
       [typeof(string), typeof(IEnumerable<CqlConcept>), typeof(FhirDateTime)],
       ["id", "medicationStatusReason", "authoredOn"]);

    private static CqlTupleMetadata CqlTupleMetadata_EBRQeiSMaTgecHVEbVOIMZEcb = new(
       [typeof(Encounter), typeof(MedicationAdministration)],
       ["QualifyingEncounter", "FactorXaMedication"]);

    private static CqlTupleMetadata CqlTupleMetadata_EPgUKHFGKDiGHBcZKVcEFWgbe = new(
       [typeof(Encounter), typeof(Procedure), typeof(object)],
       ["QualifyingEncounter", "AnesthesiaProcedure", "PatientRefusal"]);

    private static CqlTupleMetadata CqlTupleMetadata_EXZJZNMEfWVgYEZWEbGcSARAD = new(
       [typeof(Encounter), typeof(Procedure), typeof((CqlTupleMetadata, string id, CqlDateTime LowRiskDatetime)?)],
       ["QualifyingEncounter", "AnesthesiaProcedure", "LowRiskForVTE"]);

    private static CqlTupleMetadata CqlTupleMetadata_FNWjhIAKXiLTDJAYchhKVfDAc = new(
       [typeof(Encounter), typeof(Procedure), typeof((CqlTupleMetadata, string id, CqlConcept requestStatusReason, CqlDateTime authoredOn)?)],
       ["QualifyingEncounter", "AnesthesiaProcedure", "NoVTEDevice"]);

    private static CqlTupleMetadata CqlTupleMetadata_FVDRPQjOQgYIDhWKHCNhOHceF = new(
       [typeof(string), typeof(CodeableConcept), typeof(CqlDateTime)],
       ["id", "requestStatusReason", "authoredOn"]);

    private static CqlTupleMetadata CqlTupleMetadata_IIUQMBcJhJBPgdDOLHaTTRUE = new(
       [typeof(MedicationRequest), typeof(Task)],
       ["MedicationOrderReject", "T"]);

    private static CqlTupleMetadata CqlTupleMetadata_YYIDPXBNjhOGFRJKYRBMGChb = new(
       [typeof(ServiceRequest), typeof(Task)],
       ["DeviceOrderReject", "T"]);

    #endregion CqlTupleMetadata Properties

}

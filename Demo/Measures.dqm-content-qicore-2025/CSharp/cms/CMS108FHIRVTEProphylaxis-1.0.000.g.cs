#nullable enable annotations

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

[System.CodeDom.Compiler.GeneratedCode(".NET Code Generation", "5.3.0.0")]
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
    public CqlInterval<CqlDateTime?>? Measurement_Period(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Measurement_Period, Measurement_Period_Compute);

    private const long _cacheIndex_Measurement_Period = 7070766927492640047L;

    private CqlInterval<CqlDateTime?>? Measurement_Period_Compute(CqlContext context)
    {
        CqlDateTime? a_ = context.Operators.DateTime(2026, 1, 1, 0, 0, 0, 0, 0.0m);
        CqlDateTime? b_ = context.Operators.DateTime(2027, 1, 1, 0, 0, 0, 0, 0.0m);
        CqlInterval<CqlDateTime?>? c_ = context.Operators.Interval(a_, b_, true, false);
        object? d_ = context.ResolveParameter("CMS108FHIRVTEProphylaxis-1.0.000", "Measurement Period", c_);
        return (CqlInterval<CqlDateTime?>?)d_;
    }


    #endregion Parameters

    #region Functions and Expressions (37)

    [CqlExpressionDefinition("Patient")]
    public Patient? Patient(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Patient, Patient_Compute);

    private const long _cacheIndex_Patient = 4264490794319927351L;

    private Patient? Patient_Compute(CqlContext context)
    {
        IEnumerable<Patient?>? a_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-patient"));
        Patient? b_ = context.Operators.SingletonFrom<Patient?>(a_);
        return b_;
    }


    [CqlExpressionDefinition("SDE Ethnicity")]
    public (CqlTupleMetadata, IEnumerable<CqlCode?>? codes, string? display)? SDE_Ethnicity(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_SDE_Ethnicity, SDE_Ethnicity_Compute);

    private const long _cacheIndex_SDE_Ethnicity = -337742740881814516L;

    private (CqlTupleMetadata, IEnumerable<CqlCode?>? codes, string? display)? SDE_Ethnicity_Compute(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode?>? codes, string? display)? a_ = SupplementalDataElements_5_1_000.Instance.SDE_Ethnicity(context);
        return a_;
    }


    [CqlExpressionDefinition("SDE Payer")]
    public IEnumerable<(CqlTupleMetadata, CqlConcept? code, CqlInterval<CqlDateTime?>? period)?>? SDE_Payer(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_SDE_Payer, SDE_Payer_Compute);

    private const long _cacheIndex_SDE_Payer = -3212221336950252820L;

    private IEnumerable<(CqlTupleMetadata, CqlConcept? code, CqlInterval<CqlDateTime?>? period)?>? SDE_Payer_Compute(CqlContext context)
    {
        IEnumerable<(CqlTupleMetadata, CqlConcept? code, CqlInterval<CqlDateTime?>? period)?>? a_ = SupplementalDataElements_5_1_000.Instance.SDE_Payer(context);
        return a_;
    }


    [CqlExpressionDefinition("SDE Race")]
    public (CqlTupleMetadata, IEnumerable<CqlCode?>? codes, string? display)? SDE_Race(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_SDE_Race, SDE_Race_Compute);

    private const long _cacheIndex_SDE_Race = -5184337777828667700L;

    private (CqlTupleMetadata, IEnumerable<CqlCode?>? codes, string? display)? SDE_Race_Compute(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode?>? codes, string? display)? a_ = SupplementalDataElements_5_1_000.Instance.SDE_Race(context);
        return a_;
    }


    [CqlExpressionDefinition("SDE Sex")]
    public CqlCode? SDE_Sex(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_SDE_Sex, SDE_Sex_Compute);

    private const long _cacheIndex_SDE_Sex = 3190728662276422975L;

    private CqlCode? SDE_Sex_Compute(CqlContext context)
    {
        CqlCode? a_ = SupplementalDataElements_5_1_000.Instance.SDE_Sex(context);
        return a_;
    }


    [CqlExpressionDefinition("Initial Population")]
    public IEnumerable<Encounter?>? Initial_Population(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Initial_Population, Initial_Population_Compute);

    private const long _cacheIndex_Initial_Population = -1008556507936808832L;

    private IEnumerable<Encounter?>? Initial_Population_Compute(CqlContext context)
    {
        IEnumerable<Encounter?>? a_ = VTE_8_18_000.Instance.Encounter_With_Age_Range_And_Without_VTE_Diagnosis_Or_Obstetrical_Conditions(context);
        return a_;
    }


    [CqlExpressionDefinition("Denominator")]
    public IEnumerable<Encounter?>? Denominator(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Denominator, Denominator_Compute);

    private const long _cacheIndex_Denominator = 3513083825423842151L;

    private IEnumerable<Encounter?>? Denominator_Compute(CqlContext context)
    {
        IEnumerable<Encounter?>? a_ = this.Initial_Population(context);
        return a_;
    }


    [CqlExpressionDefinition("Encounter Less Than 2 Days")]
    public IEnumerable<Encounter?>? Encounter_Less_Than_2_Days(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Encounter_Less_Than_2_Days, Encounter_Less_Than_2_Days_Compute);

    private const long _cacheIndex_Encounter_Less_Than_2_Days = 7099236196673702084L;

    private IEnumerable<Encounter?>? Encounter_Less_Than_2_Days_Compute(CqlContext context)
    {
        IEnumerable<Encounter?>? a_ = VTE_8_18_000.Instance.Encounter_With_Age_Range_And_Without_VTE_Diagnosis_Or_Obstetrical_Conditions(context);

        bool? b_(Encounter? QualifyingEncounter) {
            Period? d_ = QualifyingEncounter?.Period;
            CqlInterval<CqlDateTime?>? e_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, d_);
            int? f_ = CQMCommon_4_1_000.Instance.lengthInDays(context, e_);
            bool? g_ = context.Operators.Less(f_, 2);
            return g_;
        }

        IEnumerable<Encounter?>? c_ = context.Operators.Where<Encounter?>(a_, b_);
        return c_;
    }


    [CqlExpressionDefinition("Encounter With ICU Location Stay 1 Day Or More")]
    public IEnumerable<Encounter?>? Encounter_With_ICU_Location_Stay_1_Day_Or_More(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Encounter_With_ICU_Location_Stay_1_Day_Or_More, Encounter_With_ICU_Location_Stay_1_Day_Or_More_Compute);

    private const long _cacheIndex_Encounter_With_ICU_Location_Stay_1_Day_Or_More = 7251097217384440570L;

    private IEnumerable<Encounter?>? Encounter_With_ICU_Location_Stay_1_Day_Or_More_Compute(CqlContext context)
    {
        IEnumerable<Encounter?>? a_ = VTE_8_18_000.Instance.Encounter_With_Age_Range_And_Without_VTE_Diagnosis_Or_Obstetrical_Conditions(context);

        bool? b_(Encounter? QualifyingEncounter) {
            List<Encounter.LocationComponent>? d_ = QualifyingEncounter?.Location;

            bool? e_(Encounter.LocationComponent? Location) {
                ResourceReference? g_ = Location?.Location;
                Location? h_ = CQMCommon_4_1_000.Instance.getLocation(context, g_);
                List<CodeableConcept>? i_ = h_?.Type;

                CqlConcept? j_(CodeableConcept? @this) {
                    CqlConcept? ac_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);
                    return ac_;
                }

                IEnumerable<CqlConcept?>? k_ = context.Operators.Select<CodeableConcept?, CqlConcept?>((IEnumerable<CodeableConcept?>?)i_, j_);
                CqlValueSet? l_ = this.Intensive_Care_Unit(context);
                bool? m_ = context.Operators.ConceptsInValueSet(k_, l_);
                Period? n_ = Location?.Period;
                CqlInterval<CqlDateTime?>? o_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, n_);
                int? p_ = CQMCommon_4_1_000.Instance.lengthInDays(context, o_);
                bool? q_ = context.Operators.GreaterOrEqual(p_, 1);
                bool? r_ = context.Operators.And(m_, q_);
                CqlDateTime? s_ = context.Operators.Start(o_);
                Period? t_ = QualifyingEncounter?.Period;
                CqlInterval<CqlDateTime?>? u_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, t_);
                CqlDateTime? v_ = context.Operators.Start(u_);
                bool? w_ = context.Operators.SameOrAfter(s_, v_, (string?)default);
                bool? x_ = context.Operators.And(r_, w_);
                CqlDate? y_ = context.Operators.DateFrom(s_);
                CqlInterval<CqlDate?>? z_ = TJCOverall_8_25_000.Instance.calendarDayOfOrDayAfter(context, v_);
                bool? aa_ = context.Operators.In<CqlDate?>(y_, z_, (string?)default);
                bool? ab_ = context.Operators.And(x_, aa_);
                return ab_;
            }

            bool? f_ = context.Operators.WhereAny<Encounter.LocationComponent?>((IEnumerable<Encounter.LocationComponent?>?)d_, e_);
            return f_;
        }

        IEnumerable<Encounter?>? c_ = context.Operators.Where<Encounter?>(a_, b_);
        return c_;
    }


    [CqlExpressionDefinition("Encounter With Principal Diagnosis Of Mental Disorder Or Stroke")]
    public IEnumerable<Encounter?>? Encounter_With_Principal_Diagnosis_Of_Mental_Disorder_Or_Stroke(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Encounter_With_Principal_Diagnosis_Of_Mental_Disorder_Or_Stroke, Encounter_With_Principal_Diagnosis_Of_Mental_Disorder_Or_Stroke_Compute);

    private const long _cacheIndex_Encounter_With_Principal_Diagnosis_Of_Mental_Disorder_Or_Stroke = 196183338489527540L;

    private IEnumerable<Encounter?>? Encounter_With_Principal_Diagnosis_Of_Mental_Disorder_Or_Stroke_Compute(CqlContext context)
    {
        IEnumerable<Encounter?>? a_ = VTE_8_18_000.Instance.Encounter_With_Age_Range_And_Without_VTE_Diagnosis_Or_Obstetrical_Conditions(context);

        bool? b_(Encounter? QualifyingEncounter) {
            CqlValueSet? d_ = this.Mental_Health_Diagnoses(context);
            bool? e_ = CQMCommon_4_1_000.Instance.hasPrincipalDiagnosisOf(context, QualifyingEncounter, d_);
            CqlValueSet? f_ = this.Hemorrhagic_Stroke(context);
            bool? g_ = CQMCommon_4_1_000.Instance.hasPrincipalDiagnosisOf(context, QualifyingEncounter, f_);
            bool? h_ = context.Operators.Or(e_, g_);
            CqlValueSet? i_ = this.Ischemic_Stroke(context);
            bool? j_ = CQMCommon_4_1_000.Instance.hasPrincipalDiagnosisOf(context, QualifyingEncounter, i_);
            bool? k_ = context.Operators.Or(h_, j_);
            return k_;
        }

        IEnumerable<Encounter?>? c_ = context.Operators.Where<Encounter?>(a_, b_);
        return c_;
    }


    [CqlExpressionDefinition("Encounter With Principal Procedure Of Selected Surgery")]
    public IEnumerable<Encounter?>? Encounter_With_Principal_Procedure_Of_Selected_Surgery(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Encounter_With_Principal_Procedure_Of_Selected_Surgery, Encounter_With_Principal_Procedure_Of_Selected_Surgery_Compute);

    private const long _cacheIndex_Encounter_With_Principal_Procedure_Of_Selected_Surgery = 754137602343374177L;

    private IEnumerable<Encounter?>? Encounter_With_Principal_Procedure_Of_Selected_Surgery_Compute(CqlContext context)
    {
        IEnumerable<Encounter?>? a_ = VTE_8_18_000.Instance.Encounter_With_Age_Range_And_Without_VTE_Diagnosis_Or_Obstetrical_Conditions(context);

        bool? b_(Encounter? QualifyingEncounter) {
            CqlValueSet? d_ = this.General_Surgery(context);
            bool? e_ = VTE_8_18_000.Instance.hasPrincipalProcedureOf(context, QualifyingEncounter, d_);
            CqlValueSet? f_ = this.Gynecological_Surgery(context);
            bool? g_ = VTE_8_18_000.Instance.hasPrincipalProcedureOf(context, QualifyingEncounter, f_);
            bool? h_ = context.Operators.Or(e_, g_);
            CqlValueSet? i_ = this.Hip_Fracture_Surgery(context);
            bool? j_ = VTE_8_18_000.Instance.hasPrincipalProcedureOf(context, QualifyingEncounter, i_);
            bool? k_ = context.Operators.Or(h_, j_);
            CqlValueSet? l_ = this.Hip_Replacement_Surgery(context);
            bool? m_ = VTE_8_18_000.Instance.hasPrincipalProcedureOf(context, QualifyingEncounter, l_);
            bool? n_ = context.Operators.Or(k_, m_);
            CqlValueSet? o_ = this.Intracranial_Neurosurgery(context);
            bool? p_ = VTE_8_18_000.Instance.hasPrincipalProcedureOf(context, QualifyingEncounter, o_);
            bool? q_ = context.Operators.Or(n_, p_);
            CqlValueSet? r_ = this.Knee_Replacement_Surgery(context);
            bool? s_ = VTE_8_18_000.Instance.hasPrincipalProcedureOf(context, QualifyingEncounter, r_);
            bool? t_ = context.Operators.Or(q_, s_);
            CqlValueSet? u_ = this.Urological_Surgery(context);
            bool? v_ = VTE_8_18_000.Instance.hasPrincipalProcedureOf(context, QualifyingEncounter, u_);
            bool? w_ = context.Operators.Or(t_, v_);
            return w_;
        }

        IEnumerable<Encounter?>? c_ = context.Operators.Where<Encounter?>(a_, b_);
        return c_;
    }


    [CqlExpressionDefinition("Intervention Comfort Measures")]
    public IEnumerable<object?>? Intervention_Comfort_Measures(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Intervention_Comfort_Measures, Intervention_Comfort_Measures_Compute);

    private const long _cacheIndex_Intervention_Comfort_Measures = -2923150894793032190L;

    private IEnumerable<object?>? Intervention_Comfort_Measures_Compute(CqlContext context)
    {
        CqlValueSet? a_ = this.Comfort_Measures(context);
        IEnumerable<ServiceRequest?>? b_ = context.Operators.Retrieve<ServiceRequest>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-servicerequest"));

        bool? c_(ServiceRequest? InterventionRequest) {
            Code<RequestIntent>? i_ = InterventionRequest?.IntentElement;
            RequestIntent? j_ = i_?.Value;
            Code<RequestIntent>? k_ = context.Operators.Convert<Code<RequestIntent>?>(j_);
            string? l_ = context.Operators.Convert<string?>(k_);
            string?[]? m_ = [
                "order",
                "original-order",
                "reflex-order",
                "filler-order",
                "instance-order",
            ];
            bool? n_ = context.Operators.In<string?>(l_, (IEnumerable<string?>?)m_);
            Code<RequestStatus>? o_ = InterventionRequest?.StatusElement;
            RequestStatus? p_ = o_?.Value;
            Code<RequestStatus>? q_ = context.Operators.Convert<Code<RequestStatus>?>(p_);
            string? r_ = context.Operators.Convert<string?>(q_);
            string?[]? s_ = [
                "active",
                "completed",
            ];
            bool? t_ = context.Operators.In<string?>(r_, (IEnumerable<string?>?)s_);
            bool? u_ = context.Operators.And(n_, t_);
            return u_;
        }

        IEnumerable<ServiceRequest?>? d_ = context.Operators.Where<ServiceRequest?>(b_, c_);
        IEnumerable<Procedure?>? e_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));

        bool? f_(Procedure? InterventionPerformed) {
            Code<EventStatus>? v_ = InterventionPerformed?.StatusElement;
            EventStatus? w_ = v_?.Value;
            string? x_ = context.Operators.Convert<string?>(w_);
            string?[]? y_ = [
                "completed",
                "in-progress",
            ];
            bool? z_ = context.Operators.In<string?>(x_, (IEnumerable<string?>?)y_);
            return z_;
        }

        IEnumerable<Procedure?>? g_ = context.Operators.Where<Procedure?>(e_, f_);
        IEnumerable<object?>? h_ = context.Operators.Union<object?>(d_ as IEnumerable<object?>, g_ as IEnumerable<object?>);
        return h_;
    }


    [CqlFunctionDefinition("fromDayOfStartOfHospitalizationToDayAfterAdmission")]
    public CqlInterval<CqlDate?>? fromDayOfStartOfHospitalizationToDayAfterAdmission(CqlContext context, Encounter? Encounter)
    {
        CqlInterval<CqlDateTime?>? a_ = CQMCommon_4_1_000.Instance.hospitalizationWithObservation(context, Encounter);
        CqlDateTime? b_ = context.Operators.Start(a_);
        CqlDate? c_ = context.Operators.DateFrom(b_);
        Period? d_ = Encounter?.Period;
        CqlInterval<CqlDateTime?>? e_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, d_);
        CqlDateTime? f_ = context.Operators.Start(e_);
        CqlDate? g_ = context.Operators.DateFrom(f_);
        CqlQuantity? h_ = context.Operators.Quantity(1m, "days");
        CqlDate? i_ = context.Operators.Add(g_, h_);
        CqlInterval<CqlDate?>? j_ = context.Operators.Interval(c_, i_, true, true);
        return j_;
    }


    [CqlExpressionDefinition("Encounter With Intervention Comfort Measures From Day Of Start Of Hospitalization To Day After Admission")]
    public IEnumerable<Encounter?>? Encounter_With_Intervention_Comfort_Measures_From_Day_Of_Start_Of_Hospitalization_To_Day_After_Admission(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Encounter_With_Intervention_Comfort_Measures_From_Day_Of_Start_Of_Hospitalization_To_Day_After_Admission, Encounter_With_Intervention_Comfort_Measures_From_Day_Of_Start_Of_Hospitalization_To_Day_After_Admission_Compute);

    private const long _cacheIndex_Encounter_With_Intervention_Comfort_Measures_From_Day_Of_Start_Of_Hospitalization_To_Day_After_Admission = 3074250299650757214L;

    private IEnumerable<Encounter?>? Encounter_With_Intervention_Comfort_Measures_From_Day_Of_Start_Of_Hospitalization_To_Day_After_Admission_Compute(CqlContext context)
    {
        IEnumerable<Encounter?>? a_ = VTE_8_18_000.Instance.Encounter_With_Age_Range_And_Without_VTE_Diagnosis_Or_Obstetrical_Conditions(context);

        bool? b_(Encounter? QualifyingEncounter) {
            IEnumerable<object?>? d_ = this.Intervention_Comfort_Measures(context);

            bool? e_(object? ComfortMeasure) {
                object? g_;
                object? u_ = context.Operators.LateBoundProperty<object?>(ComfortMeasure, "performed");
                object? v_ = FHIRHelpers_4_4_000.Instance.ToValue(context, u_);
                bool w_ = v_ is CqlDateTime;
                if (w_)
                {
                    object? x_ = context.Operators.LateBoundProperty<object?>(ComfortMeasure, "performed");
                    object? y_ = FHIRHelpers_4_4_000.Instance.ToValue(context, x_);
                    g_ = y_ as CqlDateTime;
                }
                else
                {
                    object? z_ = context.Operators.LateBoundProperty<object?>(ComfortMeasure, "performed");
                    object? aa_ = FHIRHelpers_4_4_000.Instance.ToValue(context, z_);
                    bool ab_ = aa_ is CqlQuantity;
                    if (ab_)
                    {
                        object? ac_ = context.Operators.LateBoundProperty<object?>(ComfortMeasure, "performed");
                        object? ad_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ac_);
                        g_ = ad_ as CqlQuantity;
                    }
                    else
                    {
                        object? ae_ = context.Operators.LateBoundProperty<object?>(ComfortMeasure, "performed");
                        object? af_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ae_);
                        bool ag_ = af_ is CqlInterval<CqlDateTime>;
                        if (ag_)
                        {
                            object? ah_ = context.Operators.LateBoundProperty<object?>(ComfortMeasure, "performed");
                            object? ai_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ah_);
                            g_ = ai_ as CqlInterval<CqlDateTime?>;
                        }
                        else
                        {
                            object? aj_ = context.Operators.LateBoundProperty<object?>(ComfortMeasure, "performed");
                            object? ak_ = FHIRHelpers_4_4_000.Instance.ToValue(context, aj_);
                            bool al_ = ak_ is CqlInterval<CqlQuantity>;
                            if (al_)
                            {
                                object? am_ = context.Operators.LateBoundProperty<object?>(ComfortMeasure, "performed");
                                object? an_ = FHIRHelpers_4_4_000.Instance.ToValue(context, am_);
                                g_ = an_ as CqlInterval<CqlQuantity?>;
                            }
                            else
                            {
                                g_ = null;
                            }
                        }
                    }
                }
                CqlInterval<CqlDateTime?>? h_ = QICoreCommon_4_0_000.Instance.toInterval(context, g_);
                CqlDateTime? i_ = context.Operators.Start(h_);
                object? j_ = context.Operators.LateBoundProperty<object?>(ComfortMeasure, "authoredOn");
                CqlDateTime? k_ = context.Operators.LateBoundProperty<CqlDateTime?>(j_, "value");
                CqlInterval<CqlDate?>? l_ = this.fromDayOfStartOfHospitalizationToDayAfterAdmission(context, QualifyingEncounter);
                CqlDate? m_ = l_?.low;
                CqlDateTime? n_ = context.Operators.ConvertDateToDateTime(m_);
                CqlDate? o_ = l_?.high;
                CqlDateTime? p_ = context.Operators.ConvertDateToDateTime(o_);
                bool? q_ = l_?.lowClosed;
                bool? r_ = l_?.highClosed;
                CqlInterval<CqlDateTime?>? s_ = context.Operators.Interval(n_, p_, q_, r_);
                bool? t_ = context.Operators.In<CqlDateTime?>(i_ ?? k_, s_, "day");
                return t_;
            }

            bool? f_ = context.Operators.WhereAny<object?>(d_, e_);
            return f_;
        }

        IEnumerable<Encounter?>? c_ = context.Operators.Where<Encounter?>(a_, b_);
        return c_;
    }


    [CqlExpressionDefinition("Encounter With Intervention Comfort Measures On Day Of Or Day After Procedure")]
    public IEnumerable<Encounter?>? Encounter_With_Intervention_Comfort_Measures_On_Day_Of_Or_Day_After_Procedure(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Encounter_With_Intervention_Comfort_Measures_On_Day_Of_Or_Day_After_Procedure, Encounter_With_Intervention_Comfort_Measures_On_Day_Of_Or_Day_After_Procedure_Compute);

    private const long _cacheIndex_Encounter_With_Intervention_Comfort_Measures_On_Day_Of_Or_Day_After_Procedure = 3668449953604409540L;

    private IEnumerable<Encounter?>? Encounter_With_Intervention_Comfort_Measures_On_Day_Of_Or_Day_After_Procedure_Compute(CqlContext context)
    {
        IEnumerable<Encounter?>? a_ = VTE_8_18_000.Instance.Encounter_With_Age_Range_And_Without_VTE_Diagnosis_Or_Obstetrical_Conditions(context);
        CqlValueSet? b_ = this.General_or_Neuraxial_Anesthesia(context);
        IEnumerable<Procedure?>? c_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, b_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
        IEnumerable<object?>? d_ = this.Intervention_Comfort_Measures(context);
        IEnumerable<ValueTuple<Encounter?, Procedure?, object?>>? e_ = context.Operators.CrossJoin<Encounter?, Procedure?, object?>(a_, c_, d_);

        (CqlTupleMetadata, Encounter? QualifyingEncounter, Procedure? AnesthesiaProcedure, object? ComfortMeasure)? f_(ValueTuple<Encounter?, Procedure?, object?> _valueTuple) {
            (CqlTupleMetadata, Encounter? QualifyingEncounter, Procedure? AnesthesiaProcedure, object? ComfortMeasure)? k_ = (CqlTupleMetadata_BgZKHMDEKXWfPTIRTZCcXPUFU, _valueTuple.Item1, _valueTuple.Item2, _valueTuple.Item3);
            return k_;
        }


        bool? g_((CqlTupleMetadata, Encounter? QualifyingEncounter, Procedure? AnesthesiaProcedure, object? ComfortMeasure)? tuple_hbjscqgbuhismoaytymvucjfi) {
            Code<EventStatus>? l_ = tuple_hbjscqgbuhismoaytymvucjfi?.AnesthesiaProcedure?.StatusElement;
            EventStatus? m_ = l_?.Value;
            string? n_ = context.Operators.Convert<string?>(m_);
            bool? o_ = context.Operators.Equal(n_, "completed");
            object? p_;
            DataType? bd_ = tuple_hbjscqgbuhismoaytymvucjfi?.AnesthesiaProcedure?.Performed;
            object? be_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bd_);
            bool bf_ = be_ is CqlDateTime;
            if (bf_)
            {
                DataType? bg_ = tuple_hbjscqgbuhismoaytymvucjfi?.AnesthesiaProcedure?.Performed;
                object? bh_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bg_);
                p_ = bh_ as CqlDateTime;
            }
            else
            {
                DataType? bi_ = tuple_hbjscqgbuhismoaytymvucjfi?.AnesthesiaProcedure?.Performed;
                object? bj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bi_);
                bool bk_ = bj_ is CqlQuantity;
                if (bk_)
                {
                    DataType? bl_ = tuple_hbjscqgbuhismoaytymvucjfi?.AnesthesiaProcedure?.Performed;
                    object? bm_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bl_);
                    p_ = bm_ as CqlQuantity;
                }
                else
                {
                    DataType? bn_ = tuple_hbjscqgbuhismoaytymvucjfi?.AnesthesiaProcedure?.Performed;
                    object? bo_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bn_);
                    bool bp_ = bo_ is CqlInterval<CqlDateTime>;
                    if (bp_)
                    {
                        DataType? bq_ = tuple_hbjscqgbuhismoaytymvucjfi?.AnesthesiaProcedure?.Performed;
                        object? br_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bq_);
                        p_ = br_ as CqlInterval<CqlDateTime?>;
                    }
                    else
                    {
                        DataType? bs_ = tuple_hbjscqgbuhismoaytymvucjfi?.AnesthesiaProcedure?.Performed;
                        object? bt_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bs_);
                        bool bu_ = bt_ is CqlInterval<CqlQuantity>;
                        if (bu_)
                        {
                            DataType? bv_ = tuple_hbjscqgbuhismoaytymvucjfi?.AnesthesiaProcedure?.Performed;
                            object? bw_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bv_);
                            p_ = bw_ as CqlInterval<CqlQuantity?>;
                        }
                        else
                        {
                            p_ = null;
                        }
                    }
                }
            }
            CqlInterval<CqlDateTime?>? q_ = QICoreCommon_4_0_000.Instance.toInterval(context, p_);
            CqlDateTime? r_ = context.Operators.End(q_);
            Period? s_ = tuple_hbjscqgbuhismoaytymvucjfi?.QualifyingEncounter?.Period;
            CqlInterval<CqlDateTime?>? t_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, s_);
            CqlDateTime? u_ = context.Operators.Start(t_);
            CqlQuantity? v_ = context.Operators.Quantity(1m, "day");
            CqlDateTime? w_ = context.Operators.Add(u_, v_);
            bool? x_ = context.Operators.SameAs(r_, w_, "day");
            bool? y_ = context.Operators.And(o_, x_);
            object? z_;
            object? bx_ = context.Operators.LateBoundProperty<object?>(tuple_hbjscqgbuhismoaytymvucjfi?.ComfortMeasure, "performed");
            object? by_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bx_);
            bool bz_ = by_ is CqlDateTime;
            if (bz_)
            {
                object? ca_ = context.Operators.LateBoundProperty<object?>(tuple_hbjscqgbuhismoaytymvucjfi?.ComfortMeasure, "performed");
                object? cb_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ca_);
                z_ = cb_ as CqlDateTime;
            }
            else
            {
                object? cc_ = context.Operators.LateBoundProperty<object?>(tuple_hbjscqgbuhismoaytymvucjfi?.ComfortMeasure, "performed");
                object? cd_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cc_);
                bool ce_ = cd_ is CqlQuantity;
                if (ce_)
                {
                    object? cf_ = context.Operators.LateBoundProperty<object?>(tuple_hbjscqgbuhismoaytymvucjfi?.ComfortMeasure, "performed");
                    object? cg_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cf_);
                    z_ = cg_ as CqlQuantity;
                }
                else
                {
                    object? ch_ = context.Operators.LateBoundProperty<object?>(tuple_hbjscqgbuhismoaytymvucjfi?.ComfortMeasure, "performed");
                    object? ci_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ch_);
                    bool cj_ = ci_ is CqlInterval<CqlDateTime>;
                    if (cj_)
                    {
                        object? ck_ = context.Operators.LateBoundProperty<object?>(tuple_hbjscqgbuhismoaytymvucjfi?.ComfortMeasure, "performed");
                        object? cl_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ck_);
                        z_ = cl_ as CqlInterval<CqlDateTime?>;
                    }
                    else
                    {
                        object? cm_ = context.Operators.LateBoundProperty<object?>(tuple_hbjscqgbuhismoaytymvucjfi?.ComfortMeasure, "performed");
                        object? cn_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cm_);
                        bool co_ = cn_ is CqlInterval<CqlQuantity>;
                        if (co_)
                        {
                            object? cp_ = context.Operators.LateBoundProperty<object?>(tuple_hbjscqgbuhismoaytymvucjfi?.ComfortMeasure, "performed");
                            object? cq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cp_);
                            z_ = cq_ as CqlInterval<CqlQuantity?>;
                        }
                        else
                        {
                            z_ = null;
                        }
                    }
                }
            }
            CqlInterval<CqlDateTime?>? aa_ = QICoreCommon_4_0_000.Instance.toInterval(context, z_);
            CqlDateTime? ab_ = context.Operators.Start(aa_);
            object? ac_ = context.Operators.LateBoundProperty<object?>(tuple_hbjscqgbuhismoaytymvucjfi?.ComfortMeasure, "authoredOn");
            CqlDateTime? ad_ = context.Operators.LateBoundProperty<CqlDateTime?>(ac_, "value");
            object? ae_;
            DataType? cr_ = tuple_hbjscqgbuhismoaytymvucjfi?.AnesthesiaProcedure?.Performed;
            object? cs_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cr_);
            bool ct_ = cs_ is CqlDateTime;
            if (ct_)
            {
                DataType? cu_ = tuple_hbjscqgbuhismoaytymvucjfi?.AnesthesiaProcedure?.Performed;
                object? cv_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cu_);
                ae_ = cv_ as CqlDateTime;
            }
            else
            {
                DataType? cw_ = tuple_hbjscqgbuhismoaytymvucjfi?.AnesthesiaProcedure?.Performed;
                object? cx_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cw_);
                bool cy_ = cx_ is CqlQuantity;
                if (cy_)
                {
                    DataType? cz_ = tuple_hbjscqgbuhismoaytymvucjfi?.AnesthesiaProcedure?.Performed;
                    object? da_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cz_);
                    ae_ = da_ as CqlQuantity;
                }
                else
                {
                    DataType? db_ = tuple_hbjscqgbuhismoaytymvucjfi?.AnesthesiaProcedure?.Performed;
                    object? dc_ = FHIRHelpers_4_4_000.Instance.ToValue(context, db_);
                    bool dd_ = dc_ is CqlInterval<CqlDateTime>;
                    if (dd_)
                    {
                        DataType? de_ = tuple_hbjscqgbuhismoaytymvucjfi?.AnesthesiaProcedure?.Performed;
                        object? df_ = FHIRHelpers_4_4_000.Instance.ToValue(context, de_);
                        ae_ = df_ as CqlInterval<CqlDateTime?>;
                    }
                    else
                    {
                        DataType? dg_ = tuple_hbjscqgbuhismoaytymvucjfi?.AnesthesiaProcedure?.Performed;
                        object? dh_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dg_);
                        bool di_ = dh_ is CqlInterval<CqlQuantity>;
                        if (di_)
                        {
                            DataType? dj_ = tuple_hbjscqgbuhismoaytymvucjfi?.AnesthesiaProcedure?.Performed;
                            object? dk_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dj_);
                            ae_ = dk_ as CqlInterval<CqlQuantity?>;
                        }
                        else
                        {
                            ae_ = null;
                        }
                    }
                }
            }
            CqlInterval<CqlDateTime?>? af_ = QICoreCommon_4_0_000.Instance.toInterval(context, ae_);
            CqlDateTime? ag_ = context.Operators.End(af_);
            CqlInterval<CqlDate?>? ah_ = TJCOverall_8_25_000.Instance.calendarDayOfOrDayAfter(context, ag_);
            CqlDate? ai_ = ah_?.low;
            CqlDateTime? aj_ = context.Operators.ConvertDateToDateTime(ai_);
            object? ak_;
            DataType? dl_ = tuple_hbjscqgbuhismoaytymvucjfi?.AnesthesiaProcedure?.Performed;
            object? dm_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dl_);
            bool dn_ = dm_ is CqlDateTime;
            if (dn_)
            {
                DataType? do_ = tuple_hbjscqgbuhismoaytymvucjfi?.AnesthesiaProcedure?.Performed;
                object? dp_ = FHIRHelpers_4_4_000.Instance.ToValue(context, do_);
                ak_ = dp_ as CqlDateTime;
            }
            else
            {
                DataType? dq_ = tuple_hbjscqgbuhismoaytymvucjfi?.AnesthesiaProcedure?.Performed;
                object? dr_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dq_);
                bool ds_ = dr_ is CqlQuantity;
                if (ds_)
                {
                    DataType? dt_ = tuple_hbjscqgbuhismoaytymvucjfi?.AnesthesiaProcedure?.Performed;
                    object? du_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dt_);
                    ak_ = du_ as CqlQuantity;
                }
                else
                {
                    DataType? dv_ = tuple_hbjscqgbuhismoaytymvucjfi?.AnesthesiaProcedure?.Performed;
                    object? dw_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dv_);
                    bool dx_ = dw_ is CqlInterval<CqlDateTime>;
                    if (dx_)
                    {
                        DataType? dy_ = tuple_hbjscqgbuhismoaytymvucjfi?.AnesthesiaProcedure?.Performed;
                        object? dz_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dy_);
                        ak_ = dz_ as CqlInterval<CqlDateTime?>;
                    }
                    else
                    {
                        DataType? ea_ = tuple_hbjscqgbuhismoaytymvucjfi?.AnesthesiaProcedure?.Performed;
                        object? eb_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ea_);
                        bool ec_ = eb_ is CqlInterval<CqlQuantity>;
                        if (ec_)
                        {
                            DataType? ed_ = tuple_hbjscqgbuhismoaytymvucjfi?.AnesthesiaProcedure?.Performed;
                            object? ee_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ed_);
                            ak_ = ee_ as CqlInterval<CqlQuantity?>;
                        }
                        else
                        {
                            ak_ = null;
                        }
                    }
                }
            }
            CqlInterval<CqlDateTime?>? al_ = QICoreCommon_4_0_000.Instance.toInterval(context, ak_);
            CqlDateTime? am_ = context.Operators.End(al_);
            CqlInterval<CqlDate?>? an_ = TJCOverall_8_25_000.Instance.calendarDayOfOrDayAfter(context, am_);
            CqlDate? ao_ = an_?.high;
            CqlDateTime? ap_ = context.Operators.ConvertDateToDateTime(ao_);
            object? aq_;
            DataType? ef_ = tuple_hbjscqgbuhismoaytymvucjfi?.AnesthesiaProcedure?.Performed;
            object? eg_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ef_);
            bool eh_ = eg_ is CqlDateTime;
            if (eh_)
            {
                DataType? ei_ = tuple_hbjscqgbuhismoaytymvucjfi?.AnesthesiaProcedure?.Performed;
                object? ej_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ei_);
                aq_ = ej_ as CqlDateTime;
            }
            else
            {
                DataType? ek_ = tuple_hbjscqgbuhismoaytymvucjfi?.AnesthesiaProcedure?.Performed;
                object? el_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ek_);
                bool em_ = el_ is CqlQuantity;
                if (em_)
                {
                    DataType? en_ = tuple_hbjscqgbuhismoaytymvucjfi?.AnesthesiaProcedure?.Performed;
                    object? eo_ = FHIRHelpers_4_4_000.Instance.ToValue(context, en_);
                    aq_ = eo_ as CqlQuantity;
                }
                else
                {
                    DataType? ep_ = tuple_hbjscqgbuhismoaytymvucjfi?.AnesthesiaProcedure?.Performed;
                    object? eq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ep_);
                    bool er_ = eq_ is CqlInterval<CqlDateTime>;
                    if (er_)
                    {
                        DataType? es_ = tuple_hbjscqgbuhismoaytymvucjfi?.AnesthesiaProcedure?.Performed;
                        object? et_ = FHIRHelpers_4_4_000.Instance.ToValue(context, es_);
                        aq_ = et_ as CqlInterval<CqlDateTime?>;
                    }
                    else
                    {
                        DataType? eu_ = tuple_hbjscqgbuhismoaytymvucjfi?.AnesthesiaProcedure?.Performed;
                        object? ev_ = FHIRHelpers_4_4_000.Instance.ToValue(context, eu_);
                        bool ew_ = ev_ is CqlInterval<CqlQuantity>;
                        if (ew_)
                        {
                            DataType? ex_ = tuple_hbjscqgbuhismoaytymvucjfi?.AnesthesiaProcedure?.Performed;
                            object? ey_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ex_);
                            aq_ = ey_ as CqlInterval<CqlQuantity?>;
                        }
                        else
                        {
                            aq_ = null;
                        }
                    }
                }
            }
            CqlInterval<CqlDateTime?>? ar_ = QICoreCommon_4_0_000.Instance.toInterval(context, aq_);
            CqlDateTime? as_ = context.Operators.End(ar_);
            CqlInterval<CqlDate?>? at_ = TJCOverall_8_25_000.Instance.calendarDayOfOrDayAfter(context, as_);
            bool? au_ = at_?.lowClosed;
            object? av_;
            DataType? ez_ = tuple_hbjscqgbuhismoaytymvucjfi?.AnesthesiaProcedure?.Performed;
            object? fa_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ez_);
            bool fb_ = fa_ is CqlDateTime;
            if (fb_)
            {
                DataType? fc_ = tuple_hbjscqgbuhismoaytymvucjfi?.AnesthesiaProcedure?.Performed;
                object? fd_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fc_);
                av_ = fd_ as CqlDateTime;
            }
            else
            {
                DataType? fe_ = tuple_hbjscqgbuhismoaytymvucjfi?.AnesthesiaProcedure?.Performed;
                object? ff_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fe_);
                bool fg_ = ff_ is CqlQuantity;
                if (fg_)
                {
                    DataType? fh_ = tuple_hbjscqgbuhismoaytymvucjfi?.AnesthesiaProcedure?.Performed;
                    object? fi_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fh_);
                    av_ = fi_ as CqlQuantity;
                }
                else
                {
                    DataType? fj_ = tuple_hbjscqgbuhismoaytymvucjfi?.AnesthesiaProcedure?.Performed;
                    object? fk_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fj_);
                    bool fl_ = fk_ is CqlInterval<CqlDateTime>;
                    if (fl_)
                    {
                        DataType? fm_ = tuple_hbjscqgbuhismoaytymvucjfi?.AnesthesiaProcedure?.Performed;
                        object? fn_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fm_);
                        av_ = fn_ as CqlInterval<CqlDateTime?>;
                    }
                    else
                    {
                        DataType? fo_ = tuple_hbjscqgbuhismoaytymvucjfi?.AnesthesiaProcedure?.Performed;
                        object? fp_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fo_);
                        bool fq_ = fp_ is CqlInterval<CqlQuantity>;
                        if (fq_)
                        {
                            DataType? fr_ = tuple_hbjscqgbuhismoaytymvucjfi?.AnesthesiaProcedure?.Performed;
                            object? fs_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fr_);
                            av_ = fs_ as CqlInterval<CqlQuantity?>;
                        }
                        else
                        {
                            av_ = null;
                        }
                    }
                }
            }
            CqlInterval<CqlDateTime?>? aw_ = QICoreCommon_4_0_000.Instance.toInterval(context, av_);
            CqlDateTime? ax_ = context.Operators.End(aw_);
            CqlInterval<CqlDate?>? ay_ = TJCOverall_8_25_000.Instance.calendarDayOfOrDayAfter(context, ax_);
            bool? az_ = ay_?.highClosed;
            CqlInterval<CqlDateTime?>? ba_ = context.Operators.Interval(aj_, ap_, au_, az_);
            bool? bb_ = context.Operators.In<CqlDateTime?>(ab_ ?? ad_, ba_, "day");
            bool? bc_ = context.Operators.And(y_, bb_);
            return bc_;
        }

        IEnumerable<(CqlTupleMetadata, Encounter? QualifyingEncounter, Procedure? AnesthesiaProcedure, object? ComfortMeasure)?>? h_ = context.Operators.SelectWhere<ValueTuple<Encounter?, Procedure?, object?>, (CqlTupleMetadata, Encounter? QualifyingEncounter, Procedure? AnesthesiaProcedure, object? ComfortMeasure)?>(e_, f_, g_);
        Encounter? i_((CqlTupleMetadata, Encounter? QualifyingEncounter, Procedure? AnesthesiaProcedure, object? ComfortMeasure)? tuple_hbjscqgbuhismoaytymvucjfi) => tuple_hbjscqgbuhismoaytymvucjfi?.QualifyingEncounter;
        IEnumerable<Encounter?>? j_ = context.Operators.SelectDistinct<(CqlTupleMetadata, Encounter? QualifyingEncounter, Procedure? AnesthesiaProcedure, object? ComfortMeasure)?, Encounter?>(h_, i_);
        return j_;
    }


    [CqlExpressionDefinition("Denominator Exclusions")]
    public IEnumerable<Encounter?>? Denominator_Exclusions(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Denominator_Exclusions, Denominator_Exclusions_Compute);

    private const long _cacheIndex_Denominator_Exclusions = 4990593561667227735L;

    private IEnumerable<Encounter?>? Denominator_Exclusions_Compute(CqlContext context)
    {
        IEnumerable<Encounter?>? a_ = this.Encounter_Less_Than_2_Days(context);
        IEnumerable<Encounter?>? b_ = this.Encounter_With_ICU_Location_Stay_1_Day_Or_More(context);
        IEnumerable<Encounter?>? c_ = context.Operators.Union<Encounter?>(a_, b_);
        IEnumerable<Encounter?>? d_ = this.Encounter_With_Principal_Diagnosis_Of_Mental_Disorder_Or_Stroke(context);
        IEnumerable<Encounter?>? e_ = this.Encounter_With_Principal_Procedure_Of_Selected_Surgery(context);
        IEnumerable<Encounter?>? f_ = context.Operators.Union<Encounter?>(d_, e_);
        IEnumerable<Encounter?>? g_ = context.Operators.Union<Encounter?>(c_, f_);
        IEnumerable<Encounter?>? h_ = this.Encounter_With_Intervention_Comfort_Measures_From_Day_Of_Start_Of_Hospitalization_To_Day_After_Admission(context);
        IEnumerable<Encounter?>? i_ = this.Encounter_With_Intervention_Comfort_Measures_On_Day_Of_Or_Day_After_Procedure(context);
        IEnumerable<Encounter?>? j_ = context.Operators.Union<Encounter?>(h_, i_);
        IEnumerable<Encounter?>? k_ = context.Operators.Union<Encounter?>(g_, j_);
        return k_;
    }


    [CqlExpressionDefinition("Pharmacological or Mechanical VTE Prophylaxis Received")]
    public IEnumerable<object?>? Pharmacological_or_Mechanical_VTE_Prophylaxis_Received(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Pharmacological_or_Mechanical_VTE_Prophylaxis_Received, Pharmacological_or_Mechanical_VTE_Prophylaxis_Received_Compute);

    private const long _cacheIndex_Pharmacological_or_Mechanical_VTE_Prophylaxis_Received = -337146172657748164L;

    private IEnumerable<object?>? Pharmacological_or_Mechanical_VTE_Prophylaxis_Received_Compute(CqlContext context)
    {
        IEnumerable<MedicationAdministration?>? a_ = context.Operators.Retrieve<MedicationAdministration>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationadministration"));

        bool? b_(MedicationAdministration? MR) {
            IEnumerable<Medication?>? az_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));

            bool? ba_(Medication? M) {
                object? bc_ = context.Operators.LateBoundProperty<object?>(M, "id.value");
                object? bd_ = context.Operators.LateBoundProperty<object?>(MR, "medication.reference.value");
                IEnumerable<string?>? be_ = context.Operators.Split((string?)bd_, "/");
                string? bf_ = context.Operators.Last<string?>(be_);
                bool? bg_ = context.Operators.Equal(bc_, bf_);
                CodeableConcept? bh_ = M?.Code;
                CqlConcept? bi_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, bh_);
                CqlValueSet? bj_ = this.Low_Dose_Unfractionated_Heparin_for_VTE_Prophylaxis(context);
                bool? bk_ = context.Operators.ConceptInValueSet(bi_, bj_);
                bool? bl_ = context.Operators.And(bg_, bk_);
                return bl_;
            }

            bool? bb_ = context.Operators.WhereAny<Medication?>(az_, ba_);
            return bb_;
        }

        IEnumerable<MedicationAdministration?>? c_ = context.Operators.Where<MedicationAdministration?>(a_, b_);
        CqlValueSet? d_ = this.Low_Dose_Unfractionated_Heparin_for_VTE_Prophylaxis(context);
        IEnumerable<MedicationAdministration?>? e_ = context.Operators.Retrieve<MedicationAdministration>(new RetrieveParameters(default, d_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationadministration"));
        IEnumerable<MedicationAdministration?>? f_ = context.Operators.Union<MedicationAdministration?>(c_, e_);

        bool? g_(MedicationAdministration? VTEMedication) {
            Code<MedicationAdministration.MedicationAdministrationStatusCodes>? bm_ = VTEMedication?.StatusElement;
            MedicationAdministration.MedicationAdministrationStatusCodes? bn_ = bm_?.Value;
            string? bo_ = context.Operators.Convert<string?>(bn_);
            bool? bp_ = context.Operators.Equal(bo_, "completed");
            MedicationAdministration.DosageComponent? bq_ = VTEMedication?.Dosage;
            CodeableConcept? br_ = bq_?.Route;
            CqlConcept? bs_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, br_);
            CqlValueSet? bt_ = this.Subcutaneous_route(context);
            bool? bu_ = context.Operators.ConceptInValueSet(bs_, bt_);
            bool? bv_ = context.Operators.And(bp_, bu_);
            return bv_;
        }

        IEnumerable<MedicationAdministration?>? h_ = context.Operators.Where<MedicationAdministration?>(f_, g_);

        bool? i_(MedicationAdministration? MR) {
            IEnumerable<Medication?>? bw_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));

            bool? bx_(Medication? M) {
                object? bz_ = context.Operators.LateBoundProperty<object?>(M, "id.value");
                object? ca_ = context.Operators.LateBoundProperty<object?>(MR, "medication.reference.value");
                IEnumerable<string?>? cb_ = context.Operators.Split((string?)ca_, "/");
                string? cc_ = context.Operators.Last<string?>(cb_);
                bool? cd_ = context.Operators.Equal(bz_, cc_);
                CodeableConcept? ce_ = M?.Code;
                CqlConcept? cf_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, ce_);
                CqlValueSet? cg_ = this.Low_Molecular_Weight_Heparin_for_VTE_Prophylaxis(context);
                bool? ch_ = context.Operators.ConceptInValueSet(cf_, cg_);
                bool? ci_ = context.Operators.And(cd_, ch_);
                return ci_;
            }

            bool? by_ = context.Operators.WhereAny<Medication?>(bw_, bx_);
            return by_;
        }

        IEnumerable<MedicationAdministration?>? j_ = context.Operators.Where<MedicationAdministration?>(a_, i_);
        CqlValueSet? k_ = this.Low_Molecular_Weight_Heparin_for_VTE_Prophylaxis(context);
        IEnumerable<MedicationAdministration?>? l_ = context.Operators.Retrieve<MedicationAdministration>(new RetrieveParameters(default, k_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationadministration"));
        IEnumerable<MedicationAdministration?>? m_ = context.Operators.Union<MedicationAdministration?>(j_, l_);

        bool? n_(MedicationAdministration? LMWH) {
            Code<MedicationAdministration.MedicationAdministrationStatusCodes>? cj_ = LMWH?.StatusElement;
            MedicationAdministration.MedicationAdministrationStatusCodes? ck_ = cj_?.Value;
            string? cl_ = context.Operators.Convert<string?>(ck_);
            bool? cm_ = context.Operators.Equal(cl_, "completed");
            return cm_;
        }

        IEnumerable<MedicationAdministration?>? o_ = context.Operators.Where<MedicationAdministration?>(m_, n_);
        IEnumerable<MedicationAdministration?>? p_ = context.Operators.Union<MedicationAdministration?>(h_, o_);

        bool? q_(MedicationAdministration? MR) {
            IEnumerable<Medication?>? cn_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));

            bool? co_(Medication? M) {
                object? cq_ = context.Operators.LateBoundProperty<object?>(M, "id.value");
                object? cr_ = context.Operators.LateBoundProperty<object?>(MR, "medication.reference.value");
                IEnumerable<string?>? cs_ = context.Operators.Split((string?)cr_, "/");
                string? ct_ = context.Operators.Last<string?>(cs_);
                bool? cu_ = context.Operators.Equal(cq_, ct_);
                CodeableConcept? cv_ = M?.Code;
                CqlConcept? cw_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, cv_);
                CqlValueSet? cx_ = this.Injectable_Factor_Xa_Inhibitor_for_VTE_Prophylaxis(context);
                bool? cy_ = context.Operators.ConceptInValueSet(cw_, cx_);
                bool? cz_ = context.Operators.And(cu_, cy_);
                return cz_;
            }

            bool? cp_ = context.Operators.WhereAny<Medication?>(cn_, co_);
            return cp_;
        }

        IEnumerable<MedicationAdministration?>? r_ = context.Operators.Where<MedicationAdministration?>(a_, q_);
        CqlValueSet? s_ = this.Injectable_Factor_Xa_Inhibitor_for_VTE_Prophylaxis(context);
        IEnumerable<MedicationAdministration?>? t_ = context.Operators.Retrieve<MedicationAdministration>(new RetrieveParameters(default, s_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationadministration"));
        IEnumerable<MedicationAdministration?>? u_ = context.Operators.Union<MedicationAdministration?>(r_, t_);

        bool? v_(MedicationAdministration? FactorXa) {
            Code<MedicationAdministration.MedicationAdministrationStatusCodes>? da_ = FactorXa?.StatusElement;
            MedicationAdministration.MedicationAdministrationStatusCodes? db_ = da_?.Value;
            string? dc_ = context.Operators.Convert<string?>(db_);
            bool? dd_ = context.Operators.Equal(dc_, "completed");
            return dd_;
        }

        IEnumerable<MedicationAdministration?>? w_ = context.Operators.Where<MedicationAdministration?>(u_, v_);

        bool? x_(MedicationAdministration? MR) {
            IEnumerable<Medication?>? de_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));

            bool? df_(Medication? M) {
                object? dh_ = context.Operators.LateBoundProperty<object?>(M, "id.value");
                object? di_ = context.Operators.LateBoundProperty<object?>(MR, "medication.reference.value");
                IEnumerable<string?>? dj_ = context.Operators.Split((string?)di_, "/");
                string? dk_ = context.Operators.Last<string?>(dj_);
                bool? dl_ = context.Operators.Equal(dh_, dk_);
                CodeableConcept? dm_ = M?.Code;
                CqlConcept? dn_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, dm_);
                CqlValueSet? do_ = this.Warfarin(context);
                bool? dp_ = context.Operators.ConceptInValueSet(dn_, do_);
                bool? dq_ = context.Operators.And(dl_, dp_);
                return dq_;
            }

            bool? dg_ = context.Operators.WhereAny<Medication?>(de_, df_);
            return dg_;
        }

        IEnumerable<MedicationAdministration?>? y_ = context.Operators.Where<MedicationAdministration?>(a_, x_);
        CqlValueSet? z_ = this.Warfarin(context);
        IEnumerable<MedicationAdministration?>? aa_ = context.Operators.Retrieve<MedicationAdministration>(new RetrieveParameters(default, z_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationadministration"));
        IEnumerable<MedicationAdministration?>? ab_ = context.Operators.Union<MedicationAdministration?>(y_, aa_);

        bool? ac_(MedicationAdministration? WarfarinAdm) {
            Code<MedicationAdministration.MedicationAdministrationStatusCodes>? dr_ = WarfarinAdm?.StatusElement;
            MedicationAdministration.MedicationAdministrationStatusCodes? ds_ = dr_?.Value;
            string? dt_ = context.Operators.Convert<string?>(ds_);
            bool? du_ = context.Operators.Equal(dt_, "completed");
            return du_;
        }

        IEnumerable<MedicationAdministration?>? ad_ = context.Operators.Where<MedicationAdministration?>(ab_, ac_);
        IEnumerable<MedicationAdministration?>? ae_ = context.Operators.Union<MedicationAdministration?>(w_, ad_);
        IEnumerable<MedicationAdministration?>? af_ = context.Operators.Union<MedicationAdministration?>(p_, ae_);

        bool? ag_(MedicationAdministration? MR) {
            IEnumerable<Medication?>? dv_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));

            bool? dw_(Medication? M) {
                object? dy_ = context.Operators.LateBoundProperty<object?>(M, "id.value");
                object? dz_ = context.Operators.LateBoundProperty<object?>(MR, "medication.reference.value");
                IEnumerable<string?>? ea_ = context.Operators.Split((string?)dz_, "/");
                string? eb_ = context.Operators.Last<string?>(ea_);
                bool? ec_ = context.Operators.Equal(dy_, eb_);
                CodeableConcept? ed_ = M?.Code;
                CqlConcept? ee_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, ed_);
                CqlValueSet? ef_ = this.Rivaroxaban_for_VTE_Prophylaxis(context);
                bool? eg_ = context.Operators.ConceptInValueSet(ee_, ef_);
                bool? eh_ = context.Operators.And(ec_, eg_);
                return eh_;
            }

            bool? dx_ = context.Operators.WhereAny<Medication?>(dv_, dw_);
            return dx_;
        }

        IEnumerable<MedicationAdministration?>? ah_ = context.Operators.Where<MedicationAdministration?>(a_, ag_);
        CqlValueSet? ai_ = this.Rivaroxaban_for_VTE_Prophylaxis(context);
        IEnumerable<MedicationAdministration?>? aj_ = context.Operators.Retrieve<MedicationAdministration>(new RetrieveParameters(default, ai_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationadministration"));
        IEnumerable<MedicationAdministration?>? ak_ = context.Operators.Union<MedicationAdministration?>(ah_, aj_);

        bool? al_(MedicationAdministration? Rivaroxaban) {
            Code<MedicationAdministration.MedicationAdministrationStatusCodes>? ei_ = Rivaroxaban?.StatusElement;
            MedicationAdministration.MedicationAdministrationStatusCodes? ej_ = ei_?.Value;
            string? ek_ = context.Operators.Convert<string?>(ej_);
            bool? el_ = context.Operators.Equal(ek_, "completed");
            return el_;
        }

        IEnumerable<MedicationAdministration?>? am_ = context.Operators.Where<MedicationAdministration?>(ak_, al_);
        CqlValueSet? an_ = this.Application_of_Intermittent_Pneumatic_Compression_Devices(context);
        IEnumerable<Procedure?>? ao_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, an_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
        CqlValueSet? ap_ = this.Application_of_Venous_Foot_Pumps(context);
        IEnumerable<Procedure?>? aq_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, ap_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
        IEnumerable<Procedure?>? ar_ = context.Operators.Union<Procedure?>(ao_, aq_);
        CqlValueSet? as_ = this.Application_of_Graduated_Compression_Stockings(context);
        IEnumerable<Procedure?>? at_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, as_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
        IEnumerable<Procedure?>? au_ = context.Operators.Union<Procedure?>(ar_, at_);

        bool? av_(Procedure? DeviceApplied) {
            Code<EventStatus>? em_ = DeviceApplied?.StatusElement;
            EventStatus? en_ = em_?.Value;
            string? eo_ = context.Operators.Convert<string?>(en_);
            bool? ep_ = context.Operators.Equal(eo_, "completed");
            return ep_;
        }

        IEnumerable<Procedure?>? aw_ = context.Operators.Where<Procedure?>(au_, av_);
        IEnumerable<object?>? ax_ = context.Operators.Union<object?>(am_ as IEnumerable<object?>, aw_ as IEnumerable<object?>);
        IEnumerable<object?>? ay_ = context.Operators.Union<object?>(af_ as IEnumerable<object?>, ax_ as IEnumerable<object?>);
        return ay_;
    }


    [CqlExpressionDefinition("Encounter With VTE Prophylaxis Received From Day Of Start Of Hospitalization To Day After Admission Or Procedure")]
    public IEnumerable<Encounter?>? Encounter_With_VTE_Prophylaxis_Received_From_Day_Of_Start_Of_Hospitalization_To_Day_After_Admission_Or_Procedure(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Encounter_With_VTE_Prophylaxis_Received_From_Day_Of_Start_Of_Hospitalization_To_Day_After_Admission_Or_Procedure, Encounter_With_VTE_Prophylaxis_Received_From_Day_Of_Start_Of_Hospitalization_To_Day_After_Admission_Or_Procedure_Compute);

    private const long _cacheIndex_Encounter_With_VTE_Prophylaxis_Received_From_Day_Of_Start_Of_Hospitalization_To_Day_After_Admission_Or_Procedure = 7620879229938405847L;

    private IEnumerable<Encounter?>? Encounter_With_VTE_Prophylaxis_Received_From_Day_Of_Start_Of_Hospitalization_To_Day_After_Admission_Or_Procedure_Compute(CqlContext context)
    {
        IEnumerable<Encounter?>? a_ = VTE_8_18_000.Instance.Encounter_With_Age_Range_And_Without_VTE_Diagnosis_Or_Obstetrical_Conditions(context);
        IEnumerable<object?>? b_ = this.Pharmacological_or_Mechanical_VTE_Prophylaxis_Received(context);
        IEnumerable<ValueTuple<Encounter?, object?>>? c_ = context.Operators.CrossJoin<Encounter?, object?>(a_, b_);

        (CqlTupleMetadata, Encounter? QualifyingEncounter, object? VTEProphylaxis)? d_(ValueTuple<Encounter?, object?> _valueTuple) {
            (CqlTupleMetadata, Encounter? QualifyingEncounter, object? VTEProphylaxis)? r_ = (CqlTupleMetadata_DQDJDfNDAVfLFYEjYSBYIhgSj, _valueTuple.Item1, _valueTuple.Item2);
            return r_;
        }


        bool? e_((CqlTupleMetadata, Encounter? QualifyingEncounter, object? VTEProphylaxis)? tuple_dqdjdfndavflfyejysbyihgsj) {
            object? s_ = context.Operators.LateBoundProperty<object?>(tuple_dqdjdfndavflfyejysbyihgsj?.VTEProphylaxis, "effective");
            object? t_ = FHIRHelpers_4_4_000.Instance.ToValue(context, s_);
            CqlInterval<CqlDateTime?>? u_ = QICoreCommon_4_0_000.Instance.toInterval(context, t_);
            object? v_;
            object? ah_ = context.Operators.LateBoundProperty<object?>(tuple_dqdjdfndavflfyejysbyihgsj?.VTEProphylaxis, "performed");
            object? ai_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ah_);
            bool aj_ = ai_ is CqlDateTime;
            if (aj_)
            {
                object? ak_ = context.Operators.LateBoundProperty<object?>(tuple_dqdjdfndavflfyejysbyihgsj?.VTEProphylaxis, "performed");
                object? al_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ak_);
                v_ = al_ as CqlDateTime;
            }
            else
            {
                object? am_ = context.Operators.LateBoundProperty<object?>(tuple_dqdjdfndavflfyejysbyihgsj?.VTEProphylaxis, "performed");
                object? an_ = FHIRHelpers_4_4_000.Instance.ToValue(context, am_);
                bool ao_ = an_ is CqlQuantity;
                if (ao_)
                {
                    object? ap_ = context.Operators.LateBoundProperty<object?>(tuple_dqdjdfndavflfyejysbyihgsj?.VTEProphylaxis, "performed");
                    object? aq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ap_);
                    v_ = aq_ as CqlQuantity;
                }
                else
                {
                    object? ar_ = context.Operators.LateBoundProperty<object?>(tuple_dqdjdfndavflfyejysbyihgsj?.VTEProphylaxis, "performed");
                    object? as_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ar_);
                    bool at_ = as_ is CqlInterval<CqlDateTime>;
                    if (at_)
                    {
                        object? au_ = context.Operators.LateBoundProperty<object?>(tuple_dqdjdfndavflfyejysbyihgsj?.VTEProphylaxis, "performed");
                        object? av_ = FHIRHelpers_4_4_000.Instance.ToValue(context, au_);
                        v_ = av_ as CqlInterval<CqlDateTime?>;
                    }
                    else
                    {
                        object? aw_ = context.Operators.LateBoundProperty<object?>(tuple_dqdjdfndavflfyejysbyihgsj?.VTEProphylaxis, "performed");
                        object? ax_ = FHIRHelpers_4_4_000.Instance.ToValue(context, aw_);
                        bool ay_ = ax_ is CqlInterval<CqlQuantity>;
                        if (ay_)
                        {
                            object? az_ = context.Operators.LateBoundProperty<object?>(tuple_dqdjdfndavflfyejysbyihgsj?.VTEProphylaxis, "performed");
                            object? ba_ = FHIRHelpers_4_4_000.Instance.ToValue(context, az_);
                            v_ = ba_ as CqlInterval<CqlQuantity?>;
                        }
                        else
                        {
                            v_ = null;
                        }
                    }
                }
            }
            CqlInterval<CqlDateTime?>? w_ = QICoreCommon_4_0_000.Instance.toInterval(context, v_);
            CqlDateTime? x_ = context.Operators.Start(u_ ?? w_);
            CqlInterval<CqlDate?>? y_ = this.fromDayOfStartOfHospitalizationToDayAfterAdmission(context, tuple_dqdjdfndavflfyejysbyihgsj?.QualifyingEncounter);
            CqlDate? z_ = y_?.low;
            CqlDateTime? aa_ = context.Operators.ConvertDateToDateTime(z_);
            CqlDate? ab_ = y_?.high;
            CqlDateTime? ac_ = context.Operators.ConvertDateToDateTime(ab_);
            bool? ad_ = y_?.lowClosed;
            bool? ae_ = y_?.highClosed;
            CqlInterval<CqlDateTime?>? af_ = context.Operators.Interval(aa_, ac_, ad_, ae_);
            bool? ag_ = context.Operators.In<CqlDateTime?>(x_, af_, "day");
            return ag_;
        }

        IEnumerable<(CqlTupleMetadata, Encounter? QualifyingEncounter, object? VTEProphylaxis)?>? f_ = context.Operators.SelectWhere<ValueTuple<Encounter?, object?>, (CqlTupleMetadata, Encounter? QualifyingEncounter, object? VTEProphylaxis)?>(c_, d_, e_);
        Encounter? g_((CqlTupleMetadata, Encounter? QualifyingEncounter, object? VTEProphylaxis)? tuple_dqdjdfndavflfyejysbyihgsj) => tuple_dqdjdfndavflfyejysbyihgsj?.QualifyingEncounter;
        IEnumerable<Encounter?>? h_ = context.Operators.SelectDistinct<(CqlTupleMetadata, Encounter? QualifyingEncounter, object? VTEProphylaxis)?, Encounter?>(f_, g_);
        CqlValueSet? i_ = this.General_or_Neuraxial_Anesthesia(context);
        IEnumerable<Procedure?>? j_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, i_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
        IEnumerable<ValueTuple<Encounter?, Procedure?, object?>>? k_ = context.Operators.CrossJoin<Encounter?, Procedure?, object?>(a_, j_, b_);

        (CqlTupleMetadata, Encounter? QualifyingEncounter, Procedure? AnesthesiaProcedure, object? VTEProphylaxis)? l_(ValueTuple<Encounter?, Procedure?, object?> _valueTuple) {
            (CqlTupleMetadata, Encounter? QualifyingEncounter, Procedure? AnesthesiaProcedure, object? VTEProphylaxis)? bb_ = (CqlTupleMetadata_CfSFUFiTWJJfiZASQhERUdATP, _valueTuple.Item1, _valueTuple.Item2, _valueTuple.Item3);
            return bb_;
        }


        bool? m_((CqlTupleMetadata, Encounter? QualifyingEncounter, Procedure? AnesthesiaProcedure, object? VTEProphylaxis)? tuple_bnvctjfzpousixdcefwhciwq) {
            Code<EventStatus>? bc_ = tuple_bnvctjfzpousixdcefwhciwq?.AnesthesiaProcedure?.StatusElement;
            EventStatus? bd_ = bc_?.Value;
            string? be_ = context.Operators.Convert<string?>(bd_);
            bool? bf_ = context.Operators.Equal(be_, "completed");
            object? bg_;
            DataType? cv_ = tuple_bnvctjfzpousixdcefwhciwq?.AnesthesiaProcedure?.Performed;
            object? cw_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cv_);
            bool cx_ = cw_ is CqlDateTime;
            if (cx_)
            {
                DataType? cy_ = tuple_bnvctjfzpousixdcefwhciwq?.AnesthesiaProcedure?.Performed;
                object? cz_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cy_);
                bg_ = cz_ as CqlDateTime;
            }
            else
            {
                DataType? da_ = tuple_bnvctjfzpousixdcefwhciwq?.AnesthesiaProcedure?.Performed;
                object? db_ = FHIRHelpers_4_4_000.Instance.ToValue(context, da_);
                bool dc_ = db_ is CqlQuantity;
                if (dc_)
                {
                    DataType? dd_ = tuple_bnvctjfzpousixdcefwhciwq?.AnesthesiaProcedure?.Performed;
                    object? de_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dd_);
                    bg_ = de_ as CqlQuantity;
                }
                else
                {
                    DataType? df_ = tuple_bnvctjfzpousixdcefwhciwq?.AnesthesiaProcedure?.Performed;
                    object? dg_ = FHIRHelpers_4_4_000.Instance.ToValue(context, df_);
                    bool dh_ = dg_ is CqlInterval<CqlDateTime>;
                    if (dh_)
                    {
                        DataType? di_ = tuple_bnvctjfzpousixdcefwhciwq?.AnesthesiaProcedure?.Performed;
                        object? dj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, di_);
                        bg_ = dj_ as CqlInterval<CqlDateTime?>;
                    }
                    else
                    {
                        DataType? dk_ = tuple_bnvctjfzpousixdcefwhciwq?.AnesthesiaProcedure?.Performed;
                        object? dl_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dk_);
                        bool dm_ = dl_ is CqlInterval<CqlQuantity>;
                        if (dm_)
                        {
                            DataType? dn_ = tuple_bnvctjfzpousixdcefwhciwq?.AnesthesiaProcedure?.Performed;
                            object? do_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dn_);
                            bg_ = do_ as CqlInterval<CqlQuantity?>;
                        }
                        else
                        {
                            bg_ = null;
                        }
                    }
                }
            }
            CqlInterval<CqlDateTime?>? bh_ = QICoreCommon_4_0_000.Instance.toInterval(context, bg_);
            CqlDateTime? bi_ = context.Operators.End(bh_);
            Period? bj_ = tuple_bnvctjfzpousixdcefwhciwq?.QualifyingEncounter?.Period;
            CqlInterval<CqlDateTime?>? bk_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, bj_);
            CqlDateTime? bl_ = context.Operators.Start(bk_);
            CqlQuantity? bm_ = context.Operators.Quantity(1m, "day");
            CqlDateTime? bn_ = context.Operators.Add(bl_, bm_);
            bool? bo_ = context.Operators.SameAs(bi_, bn_, "day");
            bool? bp_ = context.Operators.And(bf_, bo_);
            object? bq_ = context.Operators.LateBoundProperty<object?>(tuple_bnvctjfzpousixdcefwhciwq?.VTEProphylaxis, "effective");
            object? br_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bq_);
            CqlInterval<CqlDateTime?>? bs_ = QICoreCommon_4_0_000.Instance.toInterval(context, br_);
            object? bt_;
            object? dp_ = context.Operators.LateBoundProperty<object?>(tuple_bnvctjfzpousixdcefwhciwq?.VTEProphylaxis, "performed");
            object? dq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dp_);
            bool dr_ = dq_ is CqlDateTime;
            if (dr_)
            {
                object? ds_ = context.Operators.LateBoundProperty<object?>(tuple_bnvctjfzpousixdcefwhciwq?.VTEProphylaxis, "performed");
                object? dt_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ds_);
                bt_ = dt_ as CqlDateTime;
            }
            else
            {
                object? du_ = context.Operators.LateBoundProperty<object?>(tuple_bnvctjfzpousixdcefwhciwq?.VTEProphylaxis, "performed");
                object? dv_ = FHIRHelpers_4_4_000.Instance.ToValue(context, du_);
                bool dw_ = dv_ is CqlQuantity;
                if (dw_)
                {
                    object? dx_ = context.Operators.LateBoundProperty<object?>(tuple_bnvctjfzpousixdcefwhciwq?.VTEProphylaxis, "performed");
                    object? dy_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dx_);
                    bt_ = dy_ as CqlQuantity;
                }
                else
                {
                    object? dz_ = context.Operators.LateBoundProperty<object?>(tuple_bnvctjfzpousixdcefwhciwq?.VTEProphylaxis, "performed");
                    object? ea_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dz_);
                    bool eb_ = ea_ is CqlInterval<CqlDateTime>;
                    if (eb_)
                    {
                        object? ec_ = context.Operators.LateBoundProperty<object?>(tuple_bnvctjfzpousixdcefwhciwq?.VTEProphylaxis, "performed");
                        object? ed_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ec_);
                        bt_ = ed_ as CqlInterval<CqlDateTime?>;
                    }
                    else
                    {
                        object? ee_ = context.Operators.LateBoundProperty<object?>(tuple_bnvctjfzpousixdcefwhciwq?.VTEProphylaxis, "performed");
                        object? ef_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ee_);
                        bool eg_ = ef_ is CqlInterval<CqlQuantity>;
                        if (eg_)
                        {
                            object? eh_ = context.Operators.LateBoundProperty<object?>(tuple_bnvctjfzpousixdcefwhciwq?.VTEProphylaxis, "performed");
                            object? ei_ = FHIRHelpers_4_4_000.Instance.ToValue(context, eh_);
                            bt_ = ei_ as CqlInterval<CqlQuantity?>;
                        }
                        else
                        {
                            bt_ = null;
                        }
                    }
                }
            }
            CqlInterval<CqlDateTime?>? bu_ = QICoreCommon_4_0_000.Instance.toInterval(context, bt_);
            CqlDateTime? bv_ = context.Operators.Start(bs_ ?? bu_);
            object? bw_;
            DataType? ej_ = tuple_bnvctjfzpousixdcefwhciwq?.AnesthesiaProcedure?.Performed;
            object? ek_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ej_);
            bool el_ = ek_ is CqlDateTime;
            if (el_)
            {
                DataType? em_ = tuple_bnvctjfzpousixdcefwhciwq?.AnesthesiaProcedure?.Performed;
                object? en_ = FHIRHelpers_4_4_000.Instance.ToValue(context, em_);
                bw_ = en_ as CqlDateTime;
            }
            else
            {
                DataType? eo_ = tuple_bnvctjfzpousixdcefwhciwq?.AnesthesiaProcedure?.Performed;
                object? ep_ = FHIRHelpers_4_4_000.Instance.ToValue(context, eo_);
                bool eq_ = ep_ is CqlQuantity;
                if (eq_)
                {
                    DataType? er_ = tuple_bnvctjfzpousixdcefwhciwq?.AnesthesiaProcedure?.Performed;
                    object? es_ = FHIRHelpers_4_4_000.Instance.ToValue(context, er_);
                    bw_ = es_ as CqlQuantity;
                }
                else
                {
                    DataType? et_ = tuple_bnvctjfzpousixdcefwhciwq?.AnesthesiaProcedure?.Performed;
                    object? eu_ = FHIRHelpers_4_4_000.Instance.ToValue(context, et_);
                    bool ev_ = eu_ is CqlInterval<CqlDateTime>;
                    if (ev_)
                    {
                        DataType? ew_ = tuple_bnvctjfzpousixdcefwhciwq?.AnesthesiaProcedure?.Performed;
                        object? ex_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ew_);
                        bw_ = ex_ as CqlInterval<CqlDateTime?>;
                    }
                    else
                    {
                        DataType? ey_ = tuple_bnvctjfzpousixdcefwhciwq?.AnesthesiaProcedure?.Performed;
                        object? ez_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ey_);
                        bool fa_ = ez_ is CqlInterval<CqlQuantity>;
                        if (fa_)
                        {
                            DataType? fb_ = tuple_bnvctjfzpousixdcefwhciwq?.AnesthesiaProcedure?.Performed;
                            object? fc_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fb_);
                            bw_ = fc_ as CqlInterval<CqlQuantity?>;
                        }
                        else
                        {
                            bw_ = null;
                        }
                    }
                }
            }
            CqlInterval<CqlDateTime?>? bx_ = QICoreCommon_4_0_000.Instance.toInterval(context, bw_);
            CqlDateTime? by_ = context.Operators.End(bx_);
            CqlInterval<CqlDate?>? bz_ = TJCOverall_8_25_000.Instance.calendarDayOfOrDayAfter(context, by_);
            CqlDate? ca_ = bz_?.low;
            CqlDateTime? cb_ = context.Operators.ConvertDateToDateTime(ca_);
            object? cc_;
            DataType? fd_ = tuple_bnvctjfzpousixdcefwhciwq?.AnesthesiaProcedure?.Performed;
            object? fe_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fd_);
            bool ff_ = fe_ is CqlDateTime;
            if (ff_)
            {
                DataType? fg_ = tuple_bnvctjfzpousixdcefwhciwq?.AnesthesiaProcedure?.Performed;
                object? fh_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fg_);
                cc_ = fh_ as CqlDateTime;
            }
            else
            {
                DataType? fi_ = tuple_bnvctjfzpousixdcefwhciwq?.AnesthesiaProcedure?.Performed;
                object? fj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fi_);
                bool fk_ = fj_ is CqlQuantity;
                if (fk_)
                {
                    DataType? fl_ = tuple_bnvctjfzpousixdcefwhciwq?.AnesthesiaProcedure?.Performed;
                    object? fm_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fl_);
                    cc_ = fm_ as CqlQuantity;
                }
                else
                {
                    DataType? fn_ = tuple_bnvctjfzpousixdcefwhciwq?.AnesthesiaProcedure?.Performed;
                    object? fo_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fn_);
                    bool fp_ = fo_ is CqlInterval<CqlDateTime>;
                    if (fp_)
                    {
                        DataType? fq_ = tuple_bnvctjfzpousixdcefwhciwq?.AnesthesiaProcedure?.Performed;
                        object? fr_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fq_);
                        cc_ = fr_ as CqlInterval<CqlDateTime?>;
                    }
                    else
                    {
                        DataType? fs_ = tuple_bnvctjfzpousixdcefwhciwq?.AnesthesiaProcedure?.Performed;
                        object? ft_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fs_);
                        bool fu_ = ft_ is CqlInterval<CqlQuantity>;
                        if (fu_)
                        {
                            DataType? fv_ = tuple_bnvctjfzpousixdcefwhciwq?.AnesthesiaProcedure?.Performed;
                            object? fw_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fv_);
                            cc_ = fw_ as CqlInterval<CqlQuantity?>;
                        }
                        else
                        {
                            cc_ = null;
                        }
                    }
                }
            }
            CqlInterval<CqlDateTime?>? cd_ = QICoreCommon_4_0_000.Instance.toInterval(context, cc_);
            CqlDateTime? ce_ = context.Operators.End(cd_);
            CqlInterval<CqlDate?>? cf_ = TJCOverall_8_25_000.Instance.calendarDayOfOrDayAfter(context, ce_);
            CqlDate? cg_ = cf_?.high;
            CqlDateTime? ch_ = context.Operators.ConvertDateToDateTime(cg_);
            object? ci_;
            DataType? fx_ = tuple_bnvctjfzpousixdcefwhciwq?.AnesthesiaProcedure?.Performed;
            object? fy_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fx_);
            bool fz_ = fy_ is CqlDateTime;
            if (fz_)
            {
                DataType? ga_ = tuple_bnvctjfzpousixdcefwhciwq?.AnesthesiaProcedure?.Performed;
                object? gb_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ga_);
                ci_ = gb_ as CqlDateTime;
            }
            else
            {
                DataType? gc_ = tuple_bnvctjfzpousixdcefwhciwq?.AnesthesiaProcedure?.Performed;
                object? gd_ = FHIRHelpers_4_4_000.Instance.ToValue(context, gc_);
                bool ge_ = gd_ is CqlQuantity;
                if (ge_)
                {
                    DataType? gf_ = tuple_bnvctjfzpousixdcefwhciwq?.AnesthesiaProcedure?.Performed;
                    object? gg_ = FHIRHelpers_4_4_000.Instance.ToValue(context, gf_);
                    ci_ = gg_ as CqlQuantity;
                }
                else
                {
                    DataType? gh_ = tuple_bnvctjfzpousixdcefwhciwq?.AnesthesiaProcedure?.Performed;
                    object? gi_ = FHIRHelpers_4_4_000.Instance.ToValue(context, gh_);
                    bool gj_ = gi_ is CqlInterval<CqlDateTime>;
                    if (gj_)
                    {
                        DataType? gk_ = tuple_bnvctjfzpousixdcefwhciwq?.AnesthesiaProcedure?.Performed;
                        object? gl_ = FHIRHelpers_4_4_000.Instance.ToValue(context, gk_);
                        ci_ = gl_ as CqlInterval<CqlDateTime?>;
                    }
                    else
                    {
                        DataType? gm_ = tuple_bnvctjfzpousixdcefwhciwq?.AnesthesiaProcedure?.Performed;
                        object? gn_ = FHIRHelpers_4_4_000.Instance.ToValue(context, gm_);
                        bool go_ = gn_ is CqlInterval<CqlQuantity>;
                        if (go_)
                        {
                            DataType? gp_ = tuple_bnvctjfzpousixdcefwhciwq?.AnesthesiaProcedure?.Performed;
                            object? gq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, gp_);
                            ci_ = gq_ as CqlInterval<CqlQuantity?>;
                        }
                        else
                        {
                            ci_ = null;
                        }
                    }
                }
            }
            CqlInterval<CqlDateTime?>? cj_ = QICoreCommon_4_0_000.Instance.toInterval(context, ci_);
            CqlDateTime? ck_ = context.Operators.End(cj_);
            CqlInterval<CqlDate?>? cl_ = TJCOverall_8_25_000.Instance.calendarDayOfOrDayAfter(context, ck_);
            bool? cm_ = cl_?.lowClosed;
            object? cn_;
            DataType? gr_ = tuple_bnvctjfzpousixdcefwhciwq?.AnesthesiaProcedure?.Performed;
            object? gs_ = FHIRHelpers_4_4_000.Instance.ToValue(context, gr_);
            bool gt_ = gs_ is CqlDateTime;
            if (gt_)
            {
                DataType? gu_ = tuple_bnvctjfzpousixdcefwhciwq?.AnesthesiaProcedure?.Performed;
                object? gv_ = FHIRHelpers_4_4_000.Instance.ToValue(context, gu_);
                cn_ = gv_ as CqlDateTime;
            }
            else
            {
                DataType? gw_ = tuple_bnvctjfzpousixdcefwhciwq?.AnesthesiaProcedure?.Performed;
                object? gx_ = FHIRHelpers_4_4_000.Instance.ToValue(context, gw_);
                bool gy_ = gx_ is CqlQuantity;
                if (gy_)
                {
                    DataType? gz_ = tuple_bnvctjfzpousixdcefwhciwq?.AnesthesiaProcedure?.Performed;
                    object? ha_ = FHIRHelpers_4_4_000.Instance.ToValue(context, gz_);
                    cn_ = ha_ as CqlQuantity;
                }
                else
                {
                    DataType? hb_ = tuple_bnvctjfzpousixdcefwhciwq?.AnesthesiaProcedure?.Performed;
                    object? hc_ = FHIRHelpers_4_4_000.Instance.ToValue(context, hb_);
                    bool hd_ = hc_ is CqlInterval<CqlDateTime>;
                    if (hd_)
                    {
                        DataType? he_ = tuple_bnvctjfzpousixdcefwhciwq?.AnesthesiaProcedure?.Performed;
                        object? hf_ = FHIRHelpers_4_4_000.Instance.ToValue(context, he_);
                        cn_ = hf_ as CqlInterval<CqlDateTime?>;
                    }
                    else
                    {
                        DataType? hg_ = tuple_bnvctjfzpousixdcefwhciwq?.AnesthesiaProcedure?.Performed;
                        object? hh_ = FHIRHelpers_4_4_000.Instance.ToValue(context, hg_);
                        bool hi_ = hh_ is CqlInterval<CqlQuantity>;
                        if (hi_)
                        {
                            DataType? hj_ = tuple_bnvctjfzpousixdcefwhciwq?.AnesthesiaProcedure?.Performed;
                            object? hk_ = FHIRHelpers_4_4_000.Instance.ToValue(context, hj_);
                            cn_ = hk_ as CqlInterval<CqlQuantity?>;
                        }
                        else
                        {
                            cn_ = null;
                        }
                    }
                }
            }
            CqlInterval<CqlDateTime?>? co_ = QICoreCommon_4_0_000.Instance.toInterval(context, cn_);
            CqlDateTime? cp_ = context.Operators.End(co_);
            CqlInterval<CqlDate?>? cq_ = TJCOverall_8_25_000.Instance.calendarDayOfOrDayAfter(context, cp_);
            bool? cr_ = cq_?.highClosed;
            CqlInterval<CqlDateTime?>? cs_ = context.Operators.Interval(cb_, ch_, cm_, cr_);
            bool? ct_ = context.Operators.In<CqlDateTime?>(bv_, cs_, "day");
            bool? cu_ = context.Operators.And(bp_, ct_);
            return cu_;
        }

        IEnumerable<(CqlTupleMetadata, Encounter? QualifyingEncounter, Procedure? AnesthesiaProcedure, object? VTEProphylaxis)?>? n_ = context.Operators.SelectWhere<ValueTuple<Encounter?, Procedure?, object?>, (CqlTupleMetadata, Encounter? QualifyingEncounter, Procedure? AnesthesiaProcedure, object? VTEProphylaxis)?>(k_, l_, m_);
        Encounter? o_((CqlTupleMetadata, Encounter? QualifyingEncounter, Procedure? AnesthesiaProcedure, object? VTEProphylaxis)? tuple_bnvctjfzpousixdcefwhciwq) => tuple_bnvctjfzpousixdcefwhciwq?.QualifyingEncounter;
        IEnumerable<Encounter?>? p_ = context.Operators.SelectDistinct<(CqlTupleMetadata, Encounter? QualifyingEncounter, Procedure? AnesthesiaProcedure, object? VTEProphylaxis)?, Encounter?>(n_, o_);
        IEnumerable<Encounter?>? q_ = context.Operators.Union<Encounter?>(h_, p_);
        return q_;
    }


    [CqlExpressionDefinition("Encounter With Medication Oral Factor Xa Inhibitor Administered On Day Of Or Day After Admission Or Procedure")]
    public IEnumerable<Encounter?>? Encounter_With_Medication_Oral_Factor_Xa_Inhibitor_Administered_On_Day_Of_Or_Day_After_Admission_Or_Procedure(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Encounter_With_Medication_Oral_Factor_Xa_Inhibitor_Administered_On_Day_Of_Or_Day_After_Admission_Or_Procedure, Encounter_With_Medication_Oral_Factor_Xa_Inhibitor_Administered_On_Day_Of_Or_Day_After_Admission_Or_Procedure_Compute);

    private const long _cacheIndex_Encounter_With_Medication_Oral_Factor_Xa_Inhibitor_Administered_On_Day_Of_Or_Day_After_Admission_Or_Procedure = 3422895210558274894L;

    private IEnumerable<Encounter?>? Encounter_With_Medication_Oral_Factor_Xa_Inhibitor_Administered_On_Day_Of_Or_Day_After_Admission_Or_Procedure_Compute(CqlContext context)
    {
        IEnumerable<Encounter?>? a_ = VTE_8_18_000.Instance.Encounter_With_Age_Range_And_Without_VTE_Diagnosis_Or_Obstetrical_Conditions(context);
        IEnumerable<MedicationAdministration?>? b_ = context.Operators.Retrieve<MedicationAdministration>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationadministration"));

        bool? c_(MedicationAdministration? MR) {
            IEnumerable<Medication?>? z_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));

            bool? aa_(Medication? M) {
                object? ac_ = context.Operators.LateBoundProperty<object?>(M, "id.value");
                object? ad_ = context.Operators.LateBoundProperty<object?>(MR, "medication.reference.value");
                IEnumerable<string?>? ae_ = context.Operators.Split((string?)ad_, "/");
                string? af_ = context.Operators.Last<string?>(ae_);
                bool? ag_ = context.Operators.Equal(ac_, af_);
                CodeableConcept? ah_ = M?.Code;
                CqlConcept? ai_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, ah_);
                CqlValueSet? aj_ = this.Oral_Factor_Xa_Inhibitor_for_VTE_Prophylaxis_or_VTE_Treatment(context);
                bool? ak_ = context.Operators.ConceptInValueSet(ai_, aj_);
                bool? al_ = context.Operators.And(ag_, ak_);
                return al_;
            }

            bool? ab_ = context.Operators.WhereAny<Medication?>(z_, aa_);
            return ab_;
        }

        IEnumerable<MedicationAdministration?>? d_ = context.Operators.Where<MedicationAdministration?>(b_, c_);
        CqlValueSet? e_ = this.Oral_Factor_Xa_Inhibitor_for_VTE_Prophylaxis_or_VTE_Treatment(context);
        IEnumerable<MedicationAdministration?>? f_ = context.Operators.Retrieve<MedicationAdministration>(new RetrieveParameters(default, e_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationadministration"));
        IEnumerable<MedicationAdministration?>? g_ = context.Operators.Union<MedicationAdministration?>(d_, f_);
        IEnumerable<ValueTuple<Encounter?, MedicationAdministration?>>? h_ = context.Operators.CrossJoin<Encounter?, MedicationAdministration?>(a_, g_);

        (CqlTupleMetadata, Encounter? QualifyingEncounter, MedicationAdministration? FactorXaMedication)? i_(ValueTuple<Encounter?, MedicationAdministration?> _valueTuple) {
            (CqlTupleMetadata, Encounter? QualifyingEncounter, MedicationAdministration? FactorXaMedication)? am_ = (CqlTupleMetadata_EBRQeiSMaTgecHVEbVOIMZEcb, _valueTuple.Item1, _valueTuple.Item2);
            return am_;
        }


        bool? j_((CqlTupleMetadata, Encounter? QualifyingEncounter, MedicationAdministration? FactorXaMedication)? tuple_cdbvhiekdcojzrccbhjghhgeo) {
            Code<MedicationAdministration.MedicationAdministrationStatusCodes>? an_ = tuple_cdbvhiekdcojzrccbhjghhgeo?.FactorXaMedication?.StatusElement;
            MedicationAdministration.MedicationAdministrationStatusCodes? ao_ = an_?.Value;
            string? ap_ = context.Operators.Convert<string?>(ao_);
            bool? aq_ = context.Operators.Equal(ap_, "completed");
            DataType? ar_ = tuple_cdbvhiekdcojzrccbhjghhgeo?.FactorXaMedication?.Effective;
            object? as_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ar_);
            CqlInterval<CqlDateTime?>? at_ = QICoreCommon_4_0_000.Instance.toInterval(context, as_);
            CqlDateTime? au_ = context.Operators.Start(at_);
            Period? av_ = tuple_cdbvhiekdcojzrccbhjghhgeo?.QualifyingEncounter?.Period;
            CqlInterval<CqlDateTime?>? aw_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, av_);
            CqlDateTime? ax_ = context.Operators.Start(aw_);
            CqlInterval<CqlDate?>? ay_ = TJCOverall_8_25_000.Instance.calendarDayOfOrDayAfter(context, ax_);
            CqlDate? az_ = ay_?.low;
            CqlDateTime? ba_ = context.Operators.ConvertDateToDateTime(az_);
            CqlDate? bb_ = ay_?.high;
            CqlDateTime? bc_ = context.Operators.ConvertDateToDateTime(bb_);
            bool? bd_ = ay_?.lowClosed;
            bool? be_ = ay_?.highClosed;
            CqlInterval<CqlDateTime?>? bf_ = context.Operators.Interval(ba_, bc_, bd_, be_);
            bool? bg_ = context.Operators.In<CqlDateTime?>(au_, bf_, "day");
            bool? bh_ = context.Operators.And(aq_, bg_);
            return bh_;
        }

        IEnumerable<(CqlTupleMetadata, Encounter? QualifyingEncounter, MedicationAdministration? FactorXaMedication)?>? k_ = context.Operators.SelectWhere<ValueTuple<Encounter?, MedicationAdministration?>, (CqlTupleMetadata, Encounter? QualifyingEncounter, MedicationAdministration? FactorXaMedication)?>(h_, i_, j_);
        Encounter? l_((CqlTupleMetadata, Encounter? QualifyingEncounter, MedicationAdministration? FactorXaMedication)? tuple_cdbvhiekdcojzrccbhjghhgeo) => tuple_cdbvhiekdcojzrccbhjghhgeo?.QualifyingEncounter;
        IEnumerable<Encounter?>? m_ = context.Operators.SelectDistinct<(CqlTupleMetadata, Encounter? QualifyingEncounter, MedicationAdministration? FactorXaMedication)?, Encounter?>(k_, l_);
        CqlValueSet? n_ = this.General_or_Neuraxial_Anesthesia(context);
        IEnumerable<Procedure?>? o_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, n_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));

        bool? p_(MedicationAdministration? MR) {
            IEnumerable<Medication?>? bi_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));

            bool? bj_(Medication? M) {
                object? bl_ = context.Operators.LateBoundProperty<object?>(M, "id.value");
                object? bm_ = context.Operators.LateBoundProperty<object?>(MR, "medication.reference.value");
                IEnumerable<string?>? bn_ = context.Operators.Split((string?)bm_, "/");
                string? bo_ = context.Operators.Last<string?>(bn_);
                bool? bp_ = context.Operators.Equal(bl_, bo_);
                CodeableConcept? bq_ = M?.Code;
                CqlConcept? br_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, bq_);
                CqlValueSet? bs_ = this.Oral_Factor_Xa_Inhibitor_for_VTE_Prophylaxis_or_VTE_Treatment(context);
                bool? bt_ = context.Operators.ConceptInValueSet(br_, bs_);
                bool? bu_ = context.Operators.And(bp_, bt_);
                return bu_;
            }

            bool? bk_ = context.Operators.WhereAny<Medication?>(bi_, bj_);
            return bk_;
        }

        IEnumerable<MedicationAdministration?>? q_ = context.Operators.Where<MedicationAdministration?>(b_, p_);
        IEnumerable<MedicationAdministration?>? r_ = context.Operators.Union<MedicationAdministration?>(q_, f_);
        IEnumerable<ValueTuple<Encounter?, Procedure?, MedicationAdministration?>>? s_ = context.Operators.CrossJoin<Encounter?, Procedure?, MedicationAdministration?>(a_, o_, r_);

        (CqlTupleMetadata, Encounter? QualifyingEncounter, Procedure? AnesthesiaProcedure, MedicationAdministration? FactorXaMedication)? t_(ValueTuple<Encounter?, Procedure?, MedicationAdministration?> _valueTuple) {
            (CqlTupleMetadata, Encounter? QualifyingEncounter, Procedure? AnesthesiaProcedure, MedicationAdministration? FactorXaMedication)? bv_ = (CqlTupleMetadata_CdgLdDFHNTDXFGGVTOMXhQZR, _valueTuple.Item1, _valueTuple.Item2, _valueTuple.Item3);
            return bv_;
        }


        bool? u_((CqlTupleMetadata, Encounter? QualifyingEncounter, Procedure? AnesthesiaProcedure, MedicationAdministration? FactorXaMedication)? tuple_dejnabiogwrwyxienqokgepgj) {
            Code<MedicationAdministration.MedicationAdministrationStatusCodes>? bw_ = tuple_dejnabiogwrwyxienqokgepgj?.FactorXaMedication?.StatusElement;
            MedicationAdministration.MedicationAdministrationStatusCodes? bx_ = bw_?.Value;
            string? by_ = context.Operators.Convert<string?>(bx_);
            bool? bz_ = context.Operators.Equal(by_, "completed");
            Code<EventStatus>? ca_ = tuple_dejnabiogwrwyxienqokgepgj?.AnesthesiaProcedure?.StatusElement;
            EventStatus? cb_ = ca_?.Value;
            string? cc_ = context.Operators.Convert<string?>(cb_);
            bool? cd_ = context.Operators.Equal(cc_, "completed");
            bool? ce_ = context.Operators.And(bz_, cd_);
            object? cf_;
            DataType? ds_ = tuple_dejnabiogwrwyxienqokgepgj?.AnesthesiaProcedure?.Performed;
            object? dt_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ds_);
            bool du_ = dt_ is CqlDateTime;
            if (du_)
            {
                DataType? dv_ = tuple_dejnabiogwrwyxienqokgepgj?.AnesthesiaProcedure?.Performed;
                object? dw_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dv_);
                cf_ = dw_ as CqlDateTime;
            }
            else
            {
                DataType? dx_ = tuple_dejnabiogwrwyxienqokgepgj?.AnesthesiaProcedure?.Performed;
                object? dy_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dx_);
                bool dz_ = dy_ is CqlQuantity;
                if (dz_)
                {
                    DataType? ea_ = tuple_dejnabiogwrwyxienqokgepgj?.AnesthesiaProcedure?.Performed;
                    object? eb_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ea_);
                    cf_ = eb_ as CqlQuantity;
                }
                else
                {
                    DataType? ec_ = tuple_dejnabiogwrwyxienqokgepgj?.AnesthesiaProcedure?.Performed;
                    object? ed_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ec_);
                    bool ee_ = ed_ is CqlInterval<CqlDateTime>;
                    if (ee_)
                    {
                        DataType? ef_ = tuple_dejnabiogwrwyxienqokgepgj?.AnesthesiaProcedure?.Performed;
                        object? eg_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ef_);
                        cf_ = eg_ as CqlInterval<CqlDateTime?>;
                    }
                    else
                    {
                        DataType? eh_ = tuple_dejnabiogwrwyxienqokgepgj?.AnesthesiaProcedure?.Performed;
                        object? ei_ = FHIRHelpers_4_4_000.Instance.ToValue(context, eh_);
                        bool ej_ = ei_ is CqlInterval<CqlQuantity>;
                        if (ej_)
                        {
                            DataType? ek_ = tuple_dejnabiogwrwyxienqokgepgj?.AnesthesiaProcedure?.Performed;
                            object? el_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ek_);
                            cf_ = el_ as CqlInterval<CqlQuantity?>;
                        }
                        else
                        {
                            cf_ = null;
                        }
                    }
                }
            }
            CqlInterval<CqlDateTime?>? cg_ = QICoreCommon_4_0_000.Instance.toInterval(context, cf_);
            CqlDateTime? ch_ = context.Operators.End(cg_);
            Period? ci_ = tuple_dejnabiogwrwyxienqokgepgj?.QualifyingEncounter?.Period;
            CqlInterval<CqlDateTime?>? cj_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ci_);
            CqlDateTime? ck_ = context.Operators.Start(cj_);
            CqlQuantity? cl_ = context.Operators.Quantity(1m, "day");
            CqlDateTime? cm_ = context.Operators.Add(ck_, cl_);
            bool? cn_ = context.Operators.SameAs(ch_, cm_, "day");
            bool? co_ = context.Operators.And(ce_, cn_);
            DataType? cp_ = tuple_dejnabiogwrwyxienqokgepgj?.FactorXaMedication?.Effective;
            object? cq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cp_);
            CqlInterval<CqlDateTime?>? cr_ = QICoreCommon_4_0_000.Instance.toInterval(context, cq_);
            CqlDateTime? cs_ = context.Operators.Start(cr_);
            object? ct_;
            DataType? em_ = tuple_dejnabiogwrwyxienqokgepgj?.AnesthesiaProcedure?.Performed;
            object? en_ = FHIRHelpers_4_4_000.Instance.ToValue(context, em_);
            bool eo_ = en_ is CqlDateTime;
            if (eo_)
            {
                DataType? ep_ = tuple_dejnabiogwrwyxienqokgepgj?.AnesthesiaProcedure?.Performed;
                object? eq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ep_);
                ct_ = eq_ as CqlDateTime;
            }
            else
            {
                DataType? er_ = tuple_dejnabiogwrwyxienqokgepgj?.AnesthesiaProcedure?.Performed;
                object? es_ = FHIRHelpers_4_4_000.Instance.ToValue(context, er_);
                bool et_ = es_ is CqlQuantity;
                if (et_)
                {
                    DataType? eu_ = tuple_dejnabiogwrwyxienqokgepgj?.AnesthesiaProcedure?.Performed;
                    object? ev_ = FHIRHelpers_4_4_000.Instance.ToValue(context, eu_);
                    ct_ = ev_ as CqlQuantity;
                }
                else
                {
                    DataType? ew_ = tuple_dejnabiogwrwyxienqokgepgj?.AnesthesiaProcedure?.Performed;
                    object? ex_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ew_);
                    bool ey_ = ex_ is CqlInterval<CqlDateTime>;
                    if (ey_)
                    {
                        DataType? ez_ = tuple_dejnabiogwrwyxienqokgepgj?.AnesthesiaProcedure?.Performed;
                        object? fa_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ez_);
                        ct_ = fa_ as CqlInterval<CqlDateTime?>;
                    }
                    else
                    {
                        DataType? fb_ = tuple_dejnabiogwrwyxienqokgepgj?.AnesthesiaProcedure?.Performed;
                        object? fc_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fb_);
                        bool fd_ = fc_ is CqlInterval<CqlQuantity>;
                        if (fd_)
                        {
                            DataType? fe_ = tuple_dejnabiogwrwyxienqokgepgj?.AnesthesiaProcedure?.Performed;
                            object? ff_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fe_);
                            ct_ = ff_ as CqlInterval<CqlQuantity?>;
                        }
                        else
                        {
                            ct_ = null;
                        }
                    }
                }
            }
            CqlInterval<CqlDateTime?>? cu_ = QICoreCommon_4_0_000.Instance.toInterval(context, ct_);
            CqlDateTime? cv_ = context.Operators.End(cu_);
            CqlInterval<CqlDate?>? cw_ = TJCOverall_8_25_000.Instance.calendarDayOfOrDayAfter(context, cv_);
            CqlDate? cx_ = cw_?.low;
            CqlDateTime? cy_ = context.Operators.ConvertDateToDateTime(cx_);
            object? cz_;
            DataType? fg_ = tuple_dejnabiogwrwyxienqokgepgj?.AnesthesiaProcedure?.Performed;
            object? fh_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fg_);
            bool fi_ = fh_ is CqlDateTime;
            if (fi_)
            {
                DataType? fj_ = tuple_dejnabiogwrwyxienqokgepgj?.AnesthesiaProcedure?.Performed;
                object? fk_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fj_);
                cz_ = fk_ as CqlDateTime;
            }
            else
            {
                DataType? fl_ = tuple_dejnabiogwrwyxienqokgepgj?.AnesthesiaProcedure?.Performed;
                object? fm_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fl_);
                bool fn_ = fm_ is CqlQuantity;
                if (fn_)
                {
                    DataType? fo_ = tuple_dejnabiogwrwyxienqokgepgj?.AnesthesiaProcedure?.Performed;
                    object? fp_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fo_);
                    cz_ = fp_ as CqlQuantity;
                }
                else
                {
                    DataType? fq_ = tuple_dejnabiogwrwyxienqokgepgj?.AnesthesiaProcedure?.Performed;
                    object? fr_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fq_);
                    bool fs_ = fr_ is CqlInterval<CqlDateTime>;
                    if (fs_)
                    {
                        DataType? ft_ = tuple_dejnabiogwrwyxienqokgepgj?.AnesthesiaProcedure?.Performed;
                        object? fu_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ft_);
                        cz_ = fu_ as CqlInterval<CqlDateTime?>;
                    }
                    else
                    {
                        DataType? fv_ = tuple_dejnabiogwrwyxienqokgepgj?.AnesthesiaProcedure?.Performed;
                        object? fw_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fv_);
                        bool fx_ = fw_ is CqlInterval<CqlQuantity>;
                        if (fx_)
                        {
                            DataType? fy_ = tuple_dejnabiogwrwyxienqokgepgj?.AnesthesiaProcedure?.Performed;
                            object? fz_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fy_);
                            cz_ = fz_ as CqlInterval<CqlQuantity?>;
                        }
                        else
                        {
                            cz_ = null;
                        }
                    }
                }
            }
            CqlInterval<CqlDateTime?>? da_ = QICoreCommon_4_0_000.Instance.toInterval(context, cz_);
            CqlDateTime? db_ = context.Operators.End(da_);
            CqlInterval<CqlDate?>? dc_ = TJCOverall_8_25_000.Instance.calendarDayOfOrDayAfter(context, db_);
            CqlDate? dd_ = dc_?.high;
            CqlDateTime? de_ = context.Operators.ConvertDateToDateTime(dd_);
            object? df_;
            DataType? ga_ = tuple_dejnabiogwrwyxienqokgepgj?.AnesthesiaProcedure?.Performed;
            object? gb_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ga_);
            bool gc_ = gb_ is CqlDateTime;
            if (gc_)
            {
                DataType? gd_ = tuple_dejnabiogwrwyxienqokgepgj?.AnesthesiaProcedure?.Performed;
                object? ge_ = FHIRHelpers_4_4_000.Instance.ToValue(context, gd_);
                df_ = ge_ as CqlDateTime;
            }
            else
            {
                DataType? gf_ = tuple_dejnabiogwrwyxienqokgepgj?.AnesthesiaProcedure?.Performed;
                object? gg_ = FHIRHelpers_4_4_000.Instance.ToValue(context, gf_);
                bool gh_ = gg_ is CqlQuantity;
                if (gh_)
                {
                    DataType? gi_ = tuple_dejnabiogwrwyxienqokgepgj?.AnesthesiaProcedure?.Performed;
                    object? gj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, gi_);
                    df_ = gj_ as CqlQuantity;
                }
                else
                {
                    DataType? gk_ = tuple_dejnabiogwrwyxienqokgepgj?.AnesthesiaProcedure?.Performed;
                    object? gl_ = FHIRHelpers_4_4_000.Instance.ToValue(context, gk_);
                    bool gm_ = gl_ is CqlInterval<CqlDateTime>;
                    if (gm_)
                    {
                        DataType? gn_ = tuple_dejnabiogwrwyxienqokgepgj?.AnesthesiaProcedure?.Performed;
                        object? go_ = FHIRHelpers_4_4_000.Instance.ToValue(context, gn_);
                        df_ = go_ as CqlInterval<CqlDateTime?>;
                    }
                    else
                    {
                        DataType? gp_ = tuple_dejnabiogwrwyxienqokgepgj?.AnesthesiaProcedure?.Performed;
                        object? gq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, gp_);
                        bool gr_ = gq_ is CqlInterval<CqlQuantity>;
                        if (gr_)
                        {
                            DataType? gs_ = tuple_dejnabiogwrwyxienqokgepgj?.AnesthesiaProcedure?.Performed;
                            object? gt_ = FHIRHelpers_4_4_000.Instance.ToValue(context, gs_);
                            df_ = gt_ as CqlInterval<CqlQuantity?>;
                        }
                        else
                        {
                            df_ = null;
                        }
                    }
                }
            }
            CqlInterval<CqlDateTime?>? dg_ = QICoreCommon_4_0_000.Instance.toInterval(context, df_);
            CqlDateTime? dh_ = context.Operators.End(dg_);
            CqlInterval<CqlDate?>? di_ = TJCOverall_8_25_000.Instance.calendarDayOfOrDayAfter(context, dh_);
            bool? dj_ = di_?.lowClosed;
            object? dk_;
            DataType? gu_ = tuple_dejnabiogwrwyxienqokgepgj?.AnesthesiaProcedure?.Performed;
            object? gv_ = FHIRHelpers_4_4_000.Instance.ToValue(context, gu_);
            bool gw_ = gv_ is CqlDateTime;
            if (gw_)
            {
                DataType? gx_ = tuple_dejnabiogwrwyxienqokgepgj?.AnesthesiaProcedure?.Performed;
                object? gy_ = FHIRHelpers_4_4_000.Instance.ToValue(context, gx_);
                dk_ = gy_ as CqlDateTime;
            }
            else
            {
                DataType? gz_ = tuple_dejnabiogwrwyxienqokgepgj?.AnesthesiaProcedure?.Performed;
                object? ha_ = FHIRHelpers_4_4_000.Instance.ToValue(context, gz_);
                bool hb_ = ha_ is CqlQuantity;
                if (hb_)
                {
                    DataType? hc_ = tuple_dejnabiogwrwyxienqokgepgj?.AnesthesiaProcedure?.Performed;
                    object? hd_ = FHIRHelpers_4_4_000.Instance.ToValue(context, hc_);
                    dk_ = hd_ as CqlQuantity;
                }
                else
                {
                    DataType? he_ = tuple_dejnabiogwrwyxienqokgepgj?.AnesthesiaProcedure?.Performed;
                    object? hf_ = FHIRHelpers_4_4_000.Instance.ToValue(context, he_);
                    bool hg_ = hf_ is CqlInterval<CqlDateTime>;
                    if (hg_)
                    {
                        DataType? hh_ = tuple_dejnabiogwrwyxienqokgepgj?.AnesthesiaProcedure?.Performed;
                        object? hi_ = FHIRHelpers_4_4_000.Instance.ToValue(context, hh_);
                        dk_ = hi_ as CqlInterval<CqlDateTime?>;
                    }
                    else
                    {
                        DataType? hj_ = tuple_dejnabiogwrwyxienqokgepgj?.AnesthesiaProcedure?.Performed;
                        object? hk_ = FHIRHelpers_4_4_000.Instance.ToValue(context, hj_);
                        bool hl_ = hk_ is CqlInterval<CqlQuantity>;
                        if (hl_)
                        {
                            DataType? hm_ = tuple_dejnabiogwrwyxienqokgepgj?.AnesthesiaProcedure?.Performed;
                            object? hn_ = FHIRHelpers_4_4_000.Instance.ToValue(context, hm_);
                            dk_ = hn_ as CqlInterval<CqlQuantity?>;
                        }
                        else
                        {
                            dk_ = null;
                        }
                    }
                }
            }
            CqlInterval<CqlDateTime?>? dl_ = QICoreCommon_4_0_000.Instance.toInterval(context, dk_);
            CqlDateTime? dm_ = context.Operators.End(dl_);
            CqlInterval<CqlDate?>? dn_ = TJCOverall_8_25_000.Instance.calendarDayOfOrDayAfter(context, dm_);
            bool? do_ = dn_?.highClosed;
            CqlInterval<CqlDateTime?>? dp_ = context.Operators.Interval(cy_, de_, dj_, do_);
            bool? dq_ = context.Operators.In<CqlDateTime?>(cs_, dp_, "day");
            bool? dr_ = context.Operators.And(co_, dq_);
            return dr_;
        }

        IEnumerable<(CqlTupleMetadata, Encounter? QualifyingEncounter, Procedure? AnesthesiaProcedure, MedicationAdministration? FactorXaMedication)?>? v_ = context.Operators.SelectWhere<ValueTuple<Encounter?, Procedure?, MedicationAdministration?>, (CqlTupleMetadata, Encounter? QualifyingEncounter, Procedure? AnesthesiaProcedure, MedicationAdministration? FactorXaMedication)?>(s_, t_, u_);
        Encounter? w_((CqlTupleMetadata, Encounter? QualifyingEncounter, Procedure? AnesthesiaProcedure, MedicationAdministration? FactorXaMedication)? tuple_dejnabiogwrwyxienqokgepgj) => tuple_dejnabiogwrwyxienqokgepgj?.QualifyingEncounter;
        IEnumerable<Encounter?>? x_ = context.Operators.SelectDistinct<(CqlTupleMetadata, Encounter? QualifyingEncounter, Procedure? AnesthesiaProcedure, MedicationAdministration? FactorXaMedication)?, Encounter?>(v_, w_);
        IEnumerable<Encounter?>? y_ = context.Operators.Union<Encounter?>(m_, x_);
        return y_;
    }


    [CqlExpressionDefinition("Encounter With Prior Or Present Diagnosis Of Atrial Fibrillation Or Prior Diagnosis Of VTE")]
    public IEnumerable<Encounter?>? Encounter_With_Prior_Or_Present_Diagnosis_Of_Atrial_Fibrillation_Or_Prior_Diagnosis_Of_VTE(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Encounter_With_Prior_Or_Present_Diagnosis_Of_Atrial_Fibrillation_Or_Prior_Diagnosis_Of_VTE, Encounter_With_Prior_Or_Present_Diagnosis_Of_Atrial_Fibrillation_Or_Prior_Diagnosis_Of_VTE_Compute);

    private const long _cacheIndex_Encounter_With_Prior_Or_Present_Diagnosis_Of_Atrial_Fibrillation_Or_Prior_Diagnosis_Of_VTE = -6120398887152395383L;

    private IEnumerable<Encounter?>? Encounter_With_Prior_Or_Present_Diagnosis_Of_Atrial_Fibrillation_Or_Prior_Diagnosis_Of_VTE_Compute(CqlContext context)
    {
        IEnumerable<Encounter?>? a_ = VTE_8_18_000.Instance.Encounter_With_Age_Range_And_Without_VTE_Diagnosis_Or_Obstetrical_Conditions(context);

        bool? b_(Encounter? QualifyingEncounter) {
            CqlValueSet? j_ = this.Atrial_Fibrillation_or_Flutter(context);
            IEnumerable<Condition?>? k_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, j_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-problems-health-concerns"));

            bool? l_(Condition? AtrialFibrillation) {
                CodeableConcept? n_ = AtrialFibrillation?.VerificationStatus;
                CqlConcept? o_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, n_);
                bool? p_ = context.Operators.Not((bool?)(o_ is null));
                CqlCode? q_ = QICoreCommon_4_0_000.Instance.refuted(context);
                CqlConcept? r_ = context.Operators.ConvertCodeToConcept(q_);
                bool? s_ = context.Operators.Equivalent(o_, r_);
                bool? t_ = context.Operators.Not(s_);
                CqlCode? u_ = QICoreCommon_4_0_000.Instance.entered_in_error(context);
                CqlConcept? v_ = context.Operators.ConvertCodeToConcept(u_);
                bool? w_ = context.Operators.Equivalent(o_, v_);
                bool? x_ = context.Operators.Not(w_);
                bool? y_ = context.Operators.And(t_, x_);
                DataType? z_ = AtrialFibrillation?.Onset;
                object? aa_ = FHIRHelpers_4_4_000.Instance.ToValue(context, z_);
                CqlInterval<CqlDateTime?>? ab_ = QICoreCommon_4_0_000.Instance.toInterval(context, aa_);
                CqlDateTime? ac_ = context.Operators.Start(ab_);
                Period? ad_ = QualifyingEncounter?.Period;
                CqlInterval<CqlDateTime?>? ae_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ad_);
                CqlDateTime? af_ = context.Operators.End(ae_);
                bool? ag_ = context.Operators.SameOrBefore(ac_, af_, (string?)default);
                bool? ah_ = context.Operators.And(y_, ag_);
                bool? ai_ = context.Operators.Implies(p_, ah_);
                return ai_;
            }

            bool? m_ = context.Operators.WhereAny<Condition?>(k_, l_);
            return m_;
        }

        IEnumerable<Encounter?>? c_ = context.Operators.Where<Encounter?>(a_, b_);

        bool? d_(Encounter? QualifyingEncounter) {
            CqlValueSet? aj_ = this.Atrial_Fibrillation_or_Flutter(context);
            bool? ak_ = VTE_8_18_000.Instance.hasEncDiagnosisOf(context, QualifyingEncounter, aj_);
            return ak_;
        }

        IEnumerable<Encounter?>? e_ = context.Operators.Where<Encounter?>(a_, d_);
        IEnumerable<Encounter?>? f_ = context.Operators.Union<Encounter?>(c_, e_);

        bool? g_(Encounter? QualifyingEncounter) {
            CqlValueSet? al_ = this.Venous_Thromboembolism(context);
            IEnumerable<Condition?>? am_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, al_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-problems-health-concerns"));

            bool? an_(Condition? VTEDiagnosis) {
                CodeableConcept? ap_ = VTEDiagnosis?.ClinicalStatus;
                CqlConcept? aq_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, ap_);
                CqlCode? ar_ = QICoreCommon_4_0_000.Instance.inactive(context);
                CqlConcept? as_ = context.Operators.ConvertCodeToConcept(ar_);
                bool? at_ = context.Operators.Equivalent(aq_, as_);
                CqlCode? au_ = QICoreCommon_4_0_000.Instance.remission(context);
                CqlConcept? av_ = context.Operators.ConvertCodeToConcept(au_);
                bool? aw_ = context.Operators.Equivalent(aq_, av_);
                bool? ax_ = context.Operators.Or(at_, aw_);
                CqlCode? ay_ = QICoreCommon_4_0_000.Instance.resolved(context);
                CqlConcept? az_ = context.Operators.ConvertCodeToConcept(ay_);
                bool? ba_ = context.Operators.Equivalent(aq_, az_);
                bool? bb_ = context.Operators.Or(ax_, ba_);
                CodeableConcept? bc_ = VTEDiagnosis?.VerificationStatus;
                CqlConcept? bd_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, bc_);
                bool? be_ = context.Operators.Not((bool?)(bd_ is null));
                bool? bf_ = context.Operators.And(bb_, be_);
                CqlCode? bg_ = QICoreCommon_4_0_000.Instance.refuted(context);
                CqlConcept? bh_ = context.Operators.ConvertCodeToConcept(bg_);
                bool? bi_ = context.Operators.Equivalent(bd_, bh_);
                bool? bj_ = context.Operators.Not(bi_);
                CqlCode? bk_ = QICoreCommon_4_0_000.Instance.entered_in_error(context);
                CqlConcept? bl_ = context.Operators.ConvertCodeToConcept(bk_);
                bool? bm_ = context.Operators.Equivalent(bd_, bl_);
                bool? bn_ = context.Operators.Not(bm_);
                bool? bo_ = context.Operators.And(bj_, bn_);
                DataType? bp_ = VTEDiagnosis?.Onset;
                object? bq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bp_);
                CqlInterval<CqlDateTime?>? br_ = QICoreCommon_4_0_000.Instance.toInterval(context, bq_);
                CqlInterval<CqlDateTime>? bs_;
                Period? bw_ = QualifyingEncounter?.Period;
                CqlInterval<CqlDateTime?>? bx_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, bw_);
                CqlDateTime? by_ = context.Operators.Start(bx_);
                if (by_ is null)
                {
                    bs_ = default;
                }
                else
                {
                    Period? bz_ = QualifyingEncounter?.Period;
                    CqlInterval<CqlDateTime?>? ca_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, bz_);
                    CqlDateTime? cb_ = context.Operators.Start(ca_);
                    CqlInterval<CqlDateTime?>? cc_ = context.Operators.Interval(cb_, cb_, true, true);
                    bs_ = cc_;
                }
                bool? bt_ = context.Operators.Before(br_, bs_, (string?)default);
                bool? bu_ = context.Operators.And(bo_, bt_);
                bool? bv_ = context.Operators.Implies(bf_, bu_);
                return bv_;
            }

            bool? ao_ = context.Operators.WhereAny<Condition?>(am_, an_);
            return ao_;
        }

        IEnumerable<Encounter?>? h_ = context.Operators.Where<Encounter?>(a_, g_);
        IEnumerable<Encounter?>? i_ = context.Operators.Union<Encounter?>(f_, h_);
        return i_;
    }


    [CqlExpressionDefinition("Encounter With Prior Or Present Procedure Of Hip Or Knee Replacement Surgery")]
    public IEnumerable<Encounter?>? Encounter_With_Prior_Or_Present_Procedure_Of_Hip_Or_Knee_Replacement_Surgery(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Encounter_With_Prior_Or_Present_Procedure_Of_Hip_Or_Knee_Replacement_Surgery, Encounter_With_Prior_Or_Present_Procedure_Of_Hip_Or_Knee_Replacement_Surgery_Compute);

    private const long _cacheIndex_Encounter_With_Prior_Or_Present_Procedure_Of_Hip_Or_Knee_Replacement_Surgery = -7986423794810552467L;

    private IEnumerable<Encounter?>? Encounter_With_Prior_Or_Present_Procedure_Of_Hip_Or_Knee_Replacement_Surgery_Compute(CqlContext context)
    {
        IEnumerable<Encounter?>? a_ = VTE_8_18_000.Instance.Encounter_With_Age_Range_And_Without_VTE_Diagnosis_Or_Obstetrical_Conditions(context);

        bool? b_(Encounter? QualifyingEncounter) {
            CqlValueSet? d_ = this.Hip_Replacement_Surgery(context);
            IEnumerable<Procedure?>? e_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, d_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
            CqlValueSet? f_ = this.Knee_Replacement_Surgery(context);
            IEnumerable<Procedure?>? g_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, f_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
            IEnumerable<Procedure?>? h_ = context.Operators.Union<Procedure?>(e_, g_);

            bool? i_(Procedure? HipKneeProcedure) {
                Code<EventStatus>? k_ = HipKneeProcedure?.StatusElement;
                EventStatus? l_ = k_?.Value;
                string? m_ = context.Operators.Convert<string?>(l_);
                bool? n_ = context.Operators.Equal(m_, "completed");
                object? o_;
                DataType? w_ = HipKneeProcedure?.Performed;
                object? x_ = FHIRHelpers_4_4_000.Instance.ToValue(context, w_);
                bool y_ = x_ is CqlDateTime;
                if (y_)
                {
                    DataType? z_ = HipKneeProcedure?.Performed;
                    object? aa_ = FHIRHelpers_4_4_000.Instance.ToValue(context, z_);
                    o_ = aa_ as CqlDateTime;
                }
                else
                {
                    DataType? ab_ = HipKneeProcedure?.Performed;
                    object? ac_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ab_);
                    bool ad_ = ac_ is CqlQuantity;
                    if (ad_)
                    {
                        DataType? ae_ = HipKneeProcedure?.Performed;
                        object? af_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ae_);
                        o_ = af_ as CqlQuantity;
                    }
                    else
                    {
                        DataType? ag_ = HipKneeProcedure?.Performed;
                        object? ah_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ag_);
                        bool ai_ = ah_ is CqlInterval<CqlDateTime>;
                        if (ai_)
                        {
                            DataType? aj_ = HipKneeProcedure?.Performed;
                            object? ak_ = FHIRHelpers_4_4_000.Instance.ToValue(context, aj_);
                            o_ = ak_ as CqlInterval<CqlDateTime?>;
                        }
                        else
                        {
                            DataType? al_ = HipKneeProcedure?.Performed;
                            object? am_ = FHIRHelpers_4_4_000.Instance.ToValue(context, al_);
                            bool an_ = am_ is CqlInterval<CqlQuantity>;
                            if (an_)
                            {
                                DataType? ao_ = HipKneeProcedure?.Performed;
                                object? ap_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ao_);
                                o_ = ap_ as CqlInterval<CqlQuantity?>;
                            }
                            else
                            {
                                o_ = null;
                            }
                        }
                    }
                }
                CqlInterval<CqlDateTime?>? p_ = QICoreCommon_4_0_000.Instance.toInterval(context, o_);
                CqlDateTime? q_ = context.Operators.Start(p_);
                Period? r_ = QualifyingEncounter?.Period;
                CqlInterval<CqlDateTime?>? s_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, r_);
                CqlDateTime? t_ = context.Operators.End(s_);
                bool? u_ = context.Operators.SameOrBefore(q_, t_, (string?)default);
                bool? v_ = context.Operators.And(n_, u_);
                return v_;
            }

            bool? j_ = context.Operators.WhereAny<Procedure?>(h_, i_);
            return j_;
        }

        IEnumerable<Encounter?>? c_ = context.Operators.Where<Encounter?>(a_, b_);
        return c_;
    }


    [CqlExpressionDefinition("Low Risk Indicator For VTE")]
    public IEnumerable<(CqlTupleMetadata, string? id, CqlDateTime? LowRiskDatetime)?>? Low_Risk_Indicator_For_VTE(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Low_Risk_Indicator_For_VTE, Low_Risk_Indicator_For_VTE_Compute);

    private const long _cacheIndex_Low_Risk_Indicator_For_VTE = 7432212982012444353L;

    private IEnumerable<(CqlTupleMetadata, string? id, CqlDateTime? LowRiskDatetime)?>? Low_Risk_Indicator_For_VTE_Compute(CqlContext context)
    {
        CqlCode? a_ = this.Risk_for_venous_thromboembolism(context);
        IEnumerable<CqlCode?>? b_ = context.Operators.ToList<CqlCode?>(a_);
        IEnumerable<Observation?>? c_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, b_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-simple-observation"));

        bool? d_(Observation? VTERiskAssessment) {
            DataType? an_ = VTERiskAssessment?.Value;
            object? ao_ = FHIRHelpers_4_4_000.Instance.ToValue(context, an_);
            CqlValueSet? ap_ = this.Low_Risk(context);
            bool? aq_ = context.Operators.ConceptInValueSet(ao_ as CqlConcept, ap_);
            Code<ObservationStatus>? ar_ = VTERiskAssessment?.StatusElement;
            ObservationStatus? as_ = ar_?.Value;
            string? at_ = context.Operators.Convert<string?>(as_);
            string?[]? au_ = [
                "final",
                "amended",
                "corrected",
            ];
            bool? av_ = context.Operators.In<string?>(at_, (IEnumerable<string?>?)au_);
            bool? aw_ = context.Operators.And(aq_, av_);
            return aw_;
        }


        (CqlTupleMetadata, string? id, CqlDateTime? LowRiskDatetime)? e_(Observation? VTERiskAssessment) {
            Id? ax_ = VTERiskAssessment?.IdElement;
            string? ay_ = ax_?.Value;
            object? az_;
            DataType? bc_ = VTERiskAssessment?.Effective;
            object? bd_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bc_);
            bool be_ = bd_ is CqlDateTime;
            if (be_)
            {
                DataType? bf_ = VTERiskAssessment?.Effective;
                object? bg_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bf_);
                az_ = bg_ as CqlDateTime;
            }
            else
            {
                DataType? bh_ = VTERiskAssessment?.Effective;
                object? bi_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bh_);
                bool bj_ = bi_ is CqlDateTime;
                if (bj_)
                {
                    DataType? bk_ = VTERiskAssessment?.Effective;
                    object? bl_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bk_);
                    az_ = bl_ as CqlDateTime;
                }
                else
                {
                    DataType? bm_ = VTERiskAssessment?.Effective;
                    object? bn_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bm_);
                    bool bo_ = bn_ is CqlInterval<CqlDateTime>;
                    if (bo_)
                    {
                        DataType? bp_ = VTERiskAssessment?.Effective;
                        object? bq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bp_);
                        az_ = bq_ as CqlInterval<CqlDateTime?>;
                    }
                    else
                    {
                        az_ = null;
                    }
                }
            }
            CqlDateTime? ba_ = QICoreCommon_4_0_000.Instance.earliest(context, az_);
            (CqlTupleMetadata, string? id, CqlDateTime? LowRiskDatetime)? bb_ = (CqlTupleMetadata_DMAfXNhTfZDWOGdfEceXbfaSJ, ay_, ba_);
            return bb_;
        }

        IEnumerable<(CqlTupleMetadata, string? id, CqlDateTime? LowRiskDatetime)?>? f_ = context.Operators.WhereSelect<Observation?, (CqlTupleMetadata, string? id, CqlDateTime? LowRiskDatetime)?>(c_, d_, e_);
        IEnumerable<(CqlTupleMetadata, string? id, CqlDateTime? LowRiskDatetime)?>? g_ = context.Operators.Distinct<(CqlTupleMetadata, string? id, CqlDateTime? LowRiskDatetime)?>(f_);
        CqlValueSet? h_ = this.INR(context);
        IEnumerable<Observation?>? i_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, h_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation-lab"));

        bool? j_(Observation? INRLabTest) {
            DataType? br_ = INRLabTest?.Value;
            object? bs_ = FHIRHelpers_4_4_000.Instance.ToValue(context, br_);
            CqlQuantity? bt_ = context.Operators.ConvertDecimalToQuantity(3.0m);
            bool? bu_ = context.Operators.Greater(bs_ as CqlQuantity, bt_);
            Code<ObservationStatus>? bv_ = INRLabTest?.StatusElement;
            ObservationStatus? bw_ = bv_?.Value;
            string? bx_ = context.Operators.Convert<string?>(bw_);
            string?[]? by_ = [
                "final",
                "amended",
                "corrected",
            ];
            bool? bz_ = context.Operators.In<string?>(bx_, (IEnumerable<string?>?)by_);
            bool? ca_ = context.Operators.And(bu_, bz_);
            return ca_;
        }


        (CqlTupleMetadata, string? id, CqlDateTime? LowRiskDatetime)? k_(Observation? INRLabTest) {
            Id? cb_ = INRLabTest?.IdElement;
            string? cc_ = cb_?.Value;
            Instant? cd_ = INRLabTest?.IssuedElement;
            DateTimeOffset? ce_ = cd_?.Value;
            CqlDateTime? cf_ = context.Operators.Convert<CqlDateTime?>(ce_);
            (CqlTupleMetadata, string? id, CqlDateTime? LowRiskDatetime)? cg_ = (CqlTupleMetadata_DMAfXNhTfZDWOGdfEceXbfaSJ, cc_, cf_);
            return cg_;
        }

        IEnumerable<(CqlTupleMetadata, string? id, CqlDateTime? LowRiskDatetime)?>? l_ = context.Operators.WhereSelect<Observation?, (CqlTupleMetadata, string? id, CqlDateTime? LowRiskDatetime)?>(i_, j_, k_);
        IEnumerable<(CqlTupleMetadata, string? id, CqlDateTime? LowRiskDatetime)?>? m_ = context.Operators.Distinct<(CqlTupleMetadata, string? id, CqlDateTime? LowRiskDatetime)?>(l_);
        IEnumerable<(CqlTupleMetadata, string? id, CqlDateTime? LowRiskDatetime)?>? n_ = context.Operators.Union<(CqlTupleMetadata, string? id, CqlDateTime? LowRiskDatetime)?>(g_, m_);
        IEnumerable<MedicationAdministration?>? o_ = context.Operators.Retrieve<MedicationAdministration>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationadministration"));

        bool? p_(MedicationAdministration? MR) {
            IEnumerable<Medication?>? ch_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));

            bool? ci_(Medication? M) {
                object? ck_ = context.Operators.LateBoundProperty<object?>(M, "id.value");
                object? cl_ = context.Operators.LateBoundProperty<object?>(MR, "medication.reference.value");
                IEnumerable<string?>? cm_ = context.Operators.Split((string?)cl_, "/");
                string? cn_ = context.Operators.Last<string?>(cm_);
                bool? co_ = context.Operators.Equal(ck_, cn_);
                CodeableConcept? cp_ = M?.Code;
                CqlConcept? cq_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, cp_);
                CqlValueSet? cr_ = this.Unfractionated_Heparin(context);
                bool? cs_ = context.Operators.ConceptInValueSet(cq_, cr_);
                bool? ct_ = context.Operators.And(co_, cs_);
                return ct_;
            }

            bool? cj_ = context.Operators.WhereAny<Medication?>(ch_, ci_);
            return cj_;
        }

        IEnumerable<MedicationAdministration?>? q_ = context.Operators.Where<MedicationAdministration?>(o_, p_);
        CqlValueSet? r_ = this.Unfractionated_Heparin(context);
        IEnumerable<MedicationAdministration?>? s_ = context.Operators.Retrieve<MedicationAdministration>(new RetrieveParameters(default, r_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationadministration"));
        IEnumerable<MedicationAdministration?>? t_ = context.Operators.Union<MedicationAdministration?>(q_, s_);

        bool? u_(MedicationAdministration? UnfractionatedHeparin) {
            MedicationAdministration.DosageComponent? cu_ = UnfractionatedHeparin?.Dosage;
            CodeableConcept? cv_ = cu_?.Route;
            CqlConcept? cw_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, cv_);
            CqlValueSet? cx_ = this.Intravenous_route(context);
            bool? cy_ = context.Operators.ConceptInValueSet(cw_, cx_);
            return cy_;
        }

        IEnumerable<MedicationAdministration?>? v_ = context.Operators.Where<MedicationAdministration?>(t_, u_);

        bool? w_(MedicationAdministration? MR) {
            IEnumerable<Medication?>? cz_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));

            bool? da_(Medication? M) {
                object? dc_ = context.Operators.LateBoundProperty<object?>(M, "id.value");
                object? dd_ = context.Operators.LateBoundProperty<object?>(MR, "medication.reference.value");
                IEnumerable<string?>? de_ = context.Operators.Split((string?)dd_, "/");
                string? df_ = context.Operators.Last<string?>(de_);
                bool? dg_ = context.Operators.Equal(dc_, df_);
                CodeableConcept? dh_ = M?.Code;
                CqlConcept? di_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, dh_);
                CqlValueSet? dj_ = this.Direct_Thrombin_Inhibitor(context);
                bool? dk_ = context.Operators.ConceptInValueSet(di_, dj_);
                bool? dl_ = context.Operators.And(dg_, dk_);
                return dl_;
            }

            bool? db_ = context.Operators.WhereAny<Medication?>(cz_, da_);
            return db_;
        }

        IEnumerable<MedicationAdministration?>? x_ = context.Operators.Where<MedicationAdministration?>(o_, w_);
        CqlValueSet? y_ = this.Direct_Thrombin_Inhibitor(context);
        IEnumerable<MedicationAdministration?>? z_ = context.Operators.Retrieve<MedicationAdministration>(new RetrieveParameters(default, y_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationadministration"));
        IEnumerable<MedicationAdministration?>? aa_ = context.Operators.Union<MedicationAdministration?>(x_, z_);
        IEnumerable<MedicationAdministration?>? ab_ = context.Operators.Union<MedicationAdministration?>(v_, aa_);

        bool? ac_(MedicationAdministration? MR) {
            IEnumerable<Medication?>? dm_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));

            bool? dn_(Medication? M) {
                object? dp_ = context.Operators.LateBoundProperty<object?>(M, "id.value");
                object? dq_ = context.Operators.LateBoundProperty<object?>(MR, "medication.reference.value");
                IEnumerable<string?>? dr_ = context.Operators.Split((string?)dq_, "/");
                string? ds_ = context.Operators.Last<string?>(dr_);
                bool? dt_ = context.Operators.Equal(dp_, ds_);
                CodeableConcept? du_ = M?.Code;
                CqlConcept? dv_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, du_);
                CqlValueSet? dw_ = this.Glycoprotein_IIb_IIIa_Inhibitors(context);
                bool? dx_ = context.Operators.ConceptInValueSet(dv_, dw_);
                bool? dy_ = context.Operators.And(dt_, dx_);
                return dy_;
            }

            bool? do_ = context.Operators.WhereAny<Medication?>(dm_, dn_);
            return do_;
        }

        IEnumerable<MedicationAdministration?>? ad_ = context.Operators.Where<MedicationAdministration?>(o_, ac_);
        CqlValueSet? ae_ = this.Glycoprotein_IIb_IIIa_Inhibitors(context);
        IEnumerable<MedicationAdministration?>? af_ = context.Operators.Retrieve<MedicationAdministration>(new RetrieveParameters(default, ae_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationadministration"));
        IEnumerable<MedicationAdministration?>? ag_ = context.Operators.Union<MedicationAdministration?>(ad_, af_);
        IEnumerable<MedicationAdministration?>? ah_ = context.Operators.Union<MedicationAdministration?>(ab_, ag_);

        bool? ai_(MedicationAdministration? AnticoagulantMedication) {
            Code<MedicationAdministration.MedicationAdministrationStatusCodes>? dz_ = AnticoagulantMedication?.StatusElement;
            MedicationAdministration.MedicationAdministrationStatusCodes? ea_ = dz_?.Value;
            string? eb_ = context.Operators.Convert<string?>(ea_);
            bool? ec_ = context.Operators.Equal(eb_, "completed");
            return ec_;
        }


        (CqlTupleMetadata, string? id, CqlDateTime? LowRiskDatetime)? aj_(MedicationAdministration? AnticoagulantMedication) {
            Id? ed_ = AnticoagulantMedication?.IdElement;
            string? ee_ = ed_?.Value;
            DataType? ef_ = AnticoagulantMedication?.Effective;
            object? eg_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ef_);
            CqlInterval<CqlDateTime?>? eh_ = QICoreCommon_4_0_000.Instance.toInterval(context, eg_);
            CqlDateTime? ei_ = context.Operators.Start(eh_);
            (CqlTupleMetadata, string? id, CqlDateTime? LowRiskDatetime)? ej_ = (CqlTupleMetadata_DMAfXNhTfZDWOGdfEceXbfaSJ, ee_, ei_);
            return ej_;
        }

        IEnumerable<(CqlTupleMetadata, string? id, CqlDateTime? LowRiskDatetime)?>? ak_ = context.Operators.WhereSelect<MedicationAdministration?, (CqlTupleMetadata, string? id, CqlDateTime? LowRiskDatetime)?>(ah_, ai_, aj_);
        IEnumerable<(CqlTupleMetadata, string? id, CqlDateTime? LowRiskDatetime)?>? al_ = context.Operators.Distinct<(CqlTupleMetadata, string? id, CqlDateTime? LowRiskDatetime)?>(ak_);
        IEnumerable<(CqlTupleMetadata, string? id, CqlDateTime? LowRiskDatetime)?>? am_ = context.Operators.Union<(CqlTupleMetadata, string? id, CqlDateTime? LowRiskDatetime)?>(n_, al_);
        return am_;
    }


    [CqlExpressionDefinition("Low Risk For VTE Or Anticoagulant Administered From Day Of Start Of Hospitalization To Day After Admission")]
    public IEnumerable<Encounter?>? Low_Risk_For_VTE_Or_Anticoagulant_Administered_From_Day_Of_Start_Of_Hospitalization_To_Day_After_Admission(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Low_Risk_For_VTE_Or_Anticoagulant_Administered_From_Day_Of_Start_Of_Hospitalization_To_Day_After_Admission, Low_Risk_For_VTE_Or_Anticoagulant_Administered_From_Day_Of_Start_Of_Hospitalization_To_Day_After_Admission_Compute);

    private const long _cacheIndex_Low_Risk_For_VTE_Or_Anticoagulant_Administered_From_Day_Of_Start_Of_Hospitalization_To_Day_After_Admission = -1276415537838813909L;

    private IEnumerable<Encounter?>? Low_Risk_For_VTE_Or_Anticoagulant_Administered_From_Day_Of_Start_Of_Hospitalization_To_Day_After_Admission_Compute(CqlContext context)
    {
        IEnumerable<Encounter?>? a_ = VTE_8_18_000.Instance.Encounter_With_Age_Range_And_Without_VTE_Diagnosis_Or_Obstetrical_Conditions(context);

        bool? b_(Encounter? QualifyingEncounter) {
            IEnumerable<(CqlTupleMetadata, string? id, CqlDateTime? LowRiskDatetime)?>? d_ = this.Low_Risk_Indicator_For_VTE(context);

            bool? e_((CqlTupleMetadata, string? id, CqlDateTime? LowRiskDatetime)? LowRiskForVTE) {
                CqlDateTime? g_ = LowRiskForVTE?.LowRiskDatetime;
                CqlInterval<CqlDate?>? h_ = this.fromDayOfStartOfHospitalizationToDayAfterAdmission(context, QualifyingEncounter);
                CqlDate? i_ = h_?.low;
                CqlDateTime? j_ = context.Operators.ConvertDateToDateTime(i_);
                CqlDate? k_ = h_?.high;
                CqlDateTime? l_ = context.Operators.ConvertDateToDateTime(k_);
                bool? m_ = h_?.lowClosed;
                bool? n_ = h_?.highClosed;
                CqlInterval<CqlDateTime?>? o_ = context.Operators.Interval(j_, l_, m_, n_);
                bool? p_ = context.Operators.In<CqlDateTime?>(g_, o_, "day");
                return p_;
            }

            bool? f_ = context.Operators.WhereAny<(CqlTupleMetadata, string? id, CqlDateTime? LowRiskDatetime)?>(d_, e_);
            return f_;
        }

        IEnumerable<Encounter?>? c_ = context.Operators.Where<Encounter?>(a_, b_);
        return c_;
    }


    [CqlExpressionDefinition("Low Risk For VTE Or Anticoagulant Administered On Day Of Or Day After Procedure")]
    public IEnumerable<Encounter?>? Low_Risk_For_VTE_Or_Anticoagulant_Administered_On_Day_Of_Or_Day_After_Procedure(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Low_Risk_For_VTE_Or_Anticoagulant_Administered_On_Day_Of_Or_Day_After_Procedure, Low_Risk_For_VTE_Or_Anticoagulant_Administered_On_Day_Of_Or_Day_After_Procedure_Compute);

    private const long _cacheIndex_Low_Risk_For_VTE_Or_Anticoagulant_Administered_On_Day_Of_Or_Day_After_Procedure = -7257647458643896672L;

    private IEnumerable<Encounter?>? Low_Risk_For_VTE_Or_Anticoagulant_Administered_On_Day_Of_Or_Day_After_Procedure_Compute(CqlContext context)
    {
        IEnumerable<Encounter?>? a_ = VTE_8_18_000.Instance.Encounter_With_Age_Range_And_Without_VTE_Diagnosis_Or_Obstetrical_Conditions(context);
        CqlValueSet? b_ = this.General_or_Neuraxial_Anesthesia(context);
        IEnumerable<Procedure?>? c_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, b_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
        IEnumerable<(CqlTupleMetadata, string? id, CqlDateTime? LowRiskDatetime)?>? d_ = this.Low_Risk_Indicator_For_VTE(context);
        IEnumerable<ValueTuple<Encounter?, Procedure?, (CqlTupleMetadata, string? id, CqlDateTime? LowRiskDatetime)?>>? e_ = context.Operators.CrossJoin<Encounter?, Procedure?, (CqlTupleMetadata, string? id, CqlDateTime? LowRiskDatetime)?>(a_, c_, d_);

        (CqlTupleMetadata, Encounter? QualifyingEncounter, Procedure? AnesthesiaProcedure, (CqlTupleMetadata, string? id, CqlDateTime? LowRiskDatetime)? LowRiskForVTE)? f_(ValueTuple<Encounter?, Procedure?, (CqlTupleMetadata, string? id, CqlDateTime? LowRiskDatetime)?> _valueTuple) {
            (CqlTupleMetadata, Encounter? QualifyingEncounter, Procedure? AnesthesiaProcedure, (CqlTupleMetadata, string? id, CqlDateTime? LowRiskDatetime)? LowRiskForVTE)? k_ = (CqlTupleMetadata_EXZJZNMEfWVgYEZWEbGcSARAD, _valueTuple.Item1, _valueTuple.Item2, _valueTuple.Item3);
            return k_;
        }


        bool? g_((CqlTupleMetadata, Encounter? QualifyingEncounter, Procedure? AnesthesiaProcedure, (CqlTupleMetadata, string? id, CqlDateTime? LowRiskDatetime)? LowRiskForVTE)? tuple_gwhjghwetinfdseedvamgjivv) {
            Code<EventStatus>? l_ = tuple_gwhjghwetinfdseedvamgjivv?.AnesthesiaProcedure?.StatusElement;
            EventStatus? m_ = l_?.Value;
            string? n_ = context.Operators.Convert<string?>(m_);
            bool? o_ = context.Operators.Equal(n_, "completed");
            object? p_;
            DataType? az_ = tuple_gwhjghwetinfdseedvamgjivv?.AnesthesiaProcedure?.Performed;
            object? ba_ = FHIRHelpers_4_4_000.Instance.ToValue(context, az_);
            bool bb_ = ba_ is CqlDateTime;
            if (bb_)
            {
                DataType? bc_ = tuple_gwhjghwetinfdseedvamgjivv?.AnesthesiaProcedure?.Performed;
                object? bd_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bc_);
                p_ = bd_ as CqlDateTime;
            }
            else
            {
                DataType? be_ = tuple_gwhjghwetinfdseedvamgjivv?.AnesthesiaProcedure?.Performed;
                object? bf_ = FHIRHelpers_4_4_000.Instance.ToValue(context, be_);
                bool bg_ = bf_ is CqlQuantity;
                if (bg_)
                {
                    DataType? bh_ = tuple_gwhjghwetinfdseedvamgjivv?.AnesthesiaProcedure?.Performed;
                    object? bi_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bh_);
                    p_ = bi_ as CqlQuantity;
                }
                else
                {
                    DataType? bj_ = tuple_gwhjghwetinfdseedvamgjivv?.AnesthesiaProcedure?.Performed;
                    object? bk_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bj_);
                    bool bl_ = bk_ is CqlInterval<CqlDateTime>;
                    if (bl_)
                    {
                        DataType? bm_ = tuple_gwhjghwetinfdseedvamgjivv?.AnesthesiaProcedure?.Performed;
                        object? bn_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bm_);
                        p_ = bn_ as CqlInterval<CqlDateTime?>;
                    }
                    else
                    {
                        DataType? bo_ = tuple_gwhjghwetinfdseedvamgjivv?.AnesthesiaProcedure?.Performed;
                        object? bp_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bo_);
                        bool bq_ = bp_ is CqlInterval<CqlQuantity>;
                        if (bq_)
                        {
                            DataType? br_ = tuple_gwhjghwetinfdseedvamgjivv?.AnesthesiaProcedure?.Performed;
                            object? bs_ = FHIRHelpers_4_4_000.Instance.ToValue(context, br_);
                            p_ = bs_ as CqlInterval<CqlQuantity?>;
                        }
                        else
                        {
                            p_ = null;
                        }
                    }
                }
            }
            CqlInterval<CqlDateTime?>? q_ = QICoreCommon_4_0_000.Instance.toInterval(context, p_);
            CqlDateTime? r_ = context.Operators.End(q_);
            Period? s_ = tuple_gwhjghwetinfdseedvamgjivv?.QualifyingEncounter?.Period;
            CqlInterval<CqlDateTime?>? t_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, s_);
            CqlDateTime? u_ = context.Operators.Start(t_);
            CqlQuantity? v_ = context.Operators.Quantity(1m, "day");
            CqlDateTime? w_ = context.Operators.Add(u_, v_);
            bool? x_ = context.Operators.SameAs(r_, w_, "day");
            bool? y_ = context.Operators.And(o_, x_);
            CqlDateTime? z_ = tuple_gwhjghwetinfdseedvamgjivv?.LowRiskForVTE?.LowRiskDatetime;
            object? aa_;
            DataType? bt_ = tuple_gwhjghwetinfdseedvamgjivv?.AnesthesiaProcedure?.Performed;
            object? bu_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bt_);
            bool bv_ = bu_ is CqlDateTime;
            if (bv_)
            {
                DataType? bw_ = tuple_gwhjghwetinfdseedvamgjivv?.AnesthesiaProcedure?.Performed;
                object? bx_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bw_);
                aa_ = bx_ as CqlDateTime;
            }
            else
            {
                DataType? by_ = tuple_gwhjghwetinfdseedvamgjivv?.AnesthesiaProcedure?.Performed;
                object? bz_ = FHIRHelpers_4_4_000.Instance.ToValue(context, by_);
                bool ca_ = bz_ is CqlQuantity;
                if (ca_)
                {
                    DataType? cb_ = tuple_gwhjghwetinfdseedvamgjivv?.AnesthesiaProcedure?.Performed;
                    object? cc_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cb_);
                    aa_ = cc_ as CqlQuantity;
                }
                else
                {
                    DataType? cd_ = tuple_gwhjghwetinfdseedvamgjivv?.AnesthesiaProcedure?.Performed;
                    object? ce_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cd_);
                    bool cf_ = ce_ is CqlInterval<CqlDateTime>;
                    if (cf_)
                    {
                        DataType? cg_ = tuple_gwhjghwetinfdseedvamgjivv?.AnesthesiaProcedure?.Performed;
                        object? ch_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cg_);
                        aa_ = ch_ as CqlInterval<CqlDateTime?>;
                    }
                    else
                    {
                        DataType? ci_ = tuple_gwhjghwetinfdseedvamgjivv?.AnesthesiaProcedure?.Performed;
                        object? cj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ci_);
                        bool ck_ = cj_ is CqlInterval<CqlQuantity>;
                        if (ck_)
                        {
                            DataType? cl_ = tuple_gwhjghwetinfdseedvamgjivv?.AnesthesiaProcedure?.Performed;
                            object? cm_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cl_);
                            aa_ = cm_ as CqlInterval<CqlQuantity?>;
                        }
                        else
                        {
                            aa_ = null;
                        }
                    }
                }
            }
            CqlInterval<CqlDateTime?>? ab_ = QICoreCommon_4_0_000.Instance.toInterval(context, aa_);
            CqlDateTime? ac_ = context.Operators.End(ab_);
            CqlInterval<CqlDate?>? ad_ = TJCOverall_8_25_000.Instance.calendarDayOfOrDayAfter(context, ac_);
            CqlDate? ae_ = ad_?.low;
            CqlDateTime? af_ = context.Operators.ConvertDateToDateTime(ae_);
            object? ag_;
            DataType? cn_ = tuple_gwhjghwetinfdseedvamgjivv?.AnesthesiaProcedure?.Performed;
            object? co_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cn_);
            bool cp_ = co_ is CqlDateTime;
            if (cp_)
            {
                DataType? cq_ = tuple_gwhjghwetinfdseedvamgjivv?.AnesthesiaProcedure?.Performed;
                object? cr_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cq_);
                ag_ = cr_ as CqlDateTime;
            }
            else
            {
                DataType? cs_ = tuple_gwhjghwetinfdseedvamgjivv?.AnesthesiaProcedure?.Performed;
                object? ct_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cs_);
                bool cu_ = ct_ is CqlQuantity;
                if (cu_)
                {
                    DataType? cv_ = tuple_gwhjghwetinfdseedvamgjivv?.AnesthesiaProcedure?.Performed;
                    object? cw_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cv_);
                    ag_ = cw_ as CqlQuantity;
                }
                else
                {
                    DataType? cx_ = tuple_gwhjghwetinfdseedvamgjivv?.AnesthesiaProcedure?.Performed;
                    object? cy_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cx_);
                    bool cz_ = cy_ is CqlInterval<CqlDateTime>;
                    if (cz_)
                    {
                        DataType? da_ = tuple_gwhjghwetinfdseedvamgjivv?.AnesthesiaProcedure?.Performed;
                        object? db_ = FHIRHelpers_4_4_000.Instance.ToValue(context, da_);
                        ag_ = db_ as CqlInterval<CqlDateTime?>;
                    }
                    else
                    {
                        DataType? dc_ = tuple_gwhjghwetinfdseedvamgjivv?.AnesthesiaProcedure?.Performed;
                        object? dd_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dc_);
                        bool de_ = dd_ is CqlInterval<CqlQuantity>;
                        if (de_)
                        {
                            DataType? df_ = tuple_gwhjghwetinfdseedvamgjivv?.AnesthesiaProcedure?.Performed;
                            object? dg_ = FHIRHelpers_4_4_000.Instance.ToValue(context, df_);
                            ag_ = dg_ as CqlInterval<CqlQuantity?>;
                        }
                        else
                        {
                            ag_ = null;
                        }
                    }
                }
            }
            CqlInterval<CqlDateTime?>? ah_ = QICoreCommon_4_0_000.Instance.toInterval(context, ag_);
            CqlDateTime? ai_ = context.Operators.End(ah_);
            CqlInterval<CqlDate?>? aj_ = TJCOverall_8_25_000.Instance.calendarDayOfOrDayAfter(context, ai_);
            CqlDate? ak_ = aj_?.high;
            CqlDateTime? al_ = context.Operators.ConvertDateToDateTime(ak_);
            object? am_;
            DataType? dh_ = tuple_gwhjghwetinfdseedvamgjivv?.AnesthesiaProcedure?.Performed;
            object? di_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dh_);
            bool dj_ = di_ is CqlDateTime;
            if (dj_)
            {
                DataType? dk_ = tuple_gwhjghwetinfdseedvamgjivv?.AnesthesiaProcedure?.Performed;
                object? dl_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dk_);
                am_ = dl_ as CqlDateTime;
            }
            else
            {
                DataType? dm_ = tuple_gwhjghwetinfdseedvamgjivv?.AnesthesiaProcedure?.Performed;
                object? dn_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dm_);
                bool do_ = dn_ is CqlQuantity;
                if (do_)
                {
                    DataType? dp_ = tuple_gwhjghwetinfdseedvamgjivv?.AnesthesiaProcedure?.Performed;
                    object? dq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dp_);
                    am_ = dq_ as CqlQuantity;
                }
                else
                {
                    DataType? dr_ = tuple_gwhjghwetinfdseedvamgjivv?.AnesthesiaProcedure?.Performed;
                    object? ds_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dr_);
                    bool dt_ = ds_ is CqlInterval<CqlDateTime>;
                    if (dt_)
                    {
                        DataType? du_ = tuple_gwhjghwetinfdseedvamgjivv?.AnesthesiaProcedure?.Performed;
                        object? dv_ = FHIRHelpers_4_4_000.Instance.ToValue(context, du_);
                        am_ = dv_ as CqlInterval<CqlDateTime?>;
                    }
                    else
                    {
                        DataType? dw_ = tuple_gwhjghwetinfdseedvamgjivv?.AnesthesiaProcedure?.Performed;
                        object? dx_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dw_);
                        bool dy_ = dx_ is CqlInterval<CqlQuantity>;
                        if (dy_)
                        {
                            DataType? dz_ = tuple_gwhjghwetinfdseedvamgjivv?.AnesthesiaProcedure?.Performed;
                            object? ea_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dz_);
                            am_ = ea_ as CqlInterval<CqlQuantity?>;
                        }
                        else
                        {
                            am_ = null;
                        }
                    }
                }
            }
            CqlInterval<CqlDateTime?>? an_ = QICoreCommon_4_0_000.Instance.toInterval(context, am_);
            CqlDateTime? ao_ = context.Operators.End(an_);
            CqlInterval<CqlDate?>? ap_ = TJCOverall_8_25_000.Instance.calendarDayOfOrDayAfter(context, ao_);
            bool? aq_ = ap_?.lowClosed;
            object? ar_;
            DataType? eb_ = tuple_gwhjghwetinfdseedvamgjivv?.AnesthesiaProcedure?.Performed;
            object? ec_ = FHIRHelpers_4_4_000.Instance.ToValue(context, eb_);
            bool ed_ = ec_ is CqlDateTime;
            if (ed_)
            {
                DataType? ee_ = tuple_gwhjghwetinfdseedvamgjivv?.AnesthesiaProcedure?.Performed;
                object? ef_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ee_);
                ar_ = ef_ as CqlDateTime;
            }
            else
            {
                DataType? eg_ = tuple_gwhjghwetinfdseedvamgjivv?.AnesthesiaProcedure?.Performed;
                object? eh_ = FHIRHelpers_4_4_000.Instance.ToValue(context, eg_);
                bool ei_ = eh_ is CqlQuantity;
                if (ei_)
                {
                    DataType? ej_ = tuple_gwhjghwetinfdseedvamgjivv?.AnesthesiaProcedure?.Performed;
                    object? ek_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ej_);
                    ar_ = ek_ as CqlQuantity;
                }
                else
                {
                    DataType? el_ = tuple_gwhjghwetinfdseedvamgjivv?.AnesthesiaProcedure?.Performed;
                    object? em_ = FHIRHelpers_4_4_000.Instance.ToValue(context, el_);
                    bool en_ = em_ is CqlInterval<CqlDateTime>;
                    if (en_)
                    {
                        DataType? eo_ = tuple_gwhjghwetinfdseedvamgjivv?.AnesthesiaProcedure?.Performed;
                        object? ep_ = FHIRHelpers_4_4_000.Instance.ToValue(context, eo_);
                        ar_ = ep_ as CqlInterval<CqlDateTime?>;
                    }
                    else
                    {
                        DataType? eq_ = tuple_gwhjghwetinfdseedvamgjivv?.AnesthesiaProcedure?.Performed;
                        object? er_ = FHIRHelpers_4_4_000.Instance.ToValue(context, eq_);
                        bool es_ = er_ is CqlInterval<CqlQuantity>;
                        if (es_)
                        {
                            DataType? et_ = tuple_gwhjghwetinfdseedvamgjivv?.AnesthesiaProcedure?.Performed;
                            object? eu_ = FHIRHelpers_4_4_000.Instance.ToValue(context, et_);
                            ar_ = eu_ as CqlInterval<CqlQuantity?>;
                        }
                        else
                        {
                            ar_ = null;
                        }
                    }
                }
            }
            CqlInterval<CqlDateTime?>? as_ = QICoreCommon_4_0_000.Instance.toInterval(context, ar_);
            CqlDateTime? at_ = context.Operators.End(as_);
            CqlInterval<CqlDate?>? au_ = TJCOverall_8_25_000.Instance.calendarDayOfOrDayAfter(context, at_);
            bool? av_ = au_?.highClosed;
            CqlInterval<CqlDateTime?>? aw_ = context.Operators.Interval(af_, al_, aq_, av_);
            bool? ax_ = context.Operators.In<CqlDateTime?>(z_, aw_, "day");
            bool? ay_ = context.Operators.And(y_, ax_);
            return ay_;
        }

        IEnumerable<(CqlTupleMetadata, Encounter? QualifyingEncounter, Procedure? AnesthesiaProcedure, (CqlTupleMetadata, string? id, CqlDateTime? LowRiskDatetime)? LowRiskForVTE)?>? h_ = context.Operators.SelectWhere<ValueTuple<Encounter?, Procedure?, (CqlTupleMetadata, string? id, CqlDateTime? LowRiskDatetime)?>, (CqlTupleMetadata, Encounter? QualifyingEncounter, Procedure? AnesthesiaProcedure, (CqlTupleMetadata, string? id, CqlDateTime? LowRiskDatetime)? LowRiskForVTE)?>(e_, f_, g_);
        Encounter? i_((CqlTupleMetadata, Encounter? QualifyingEncounter, Procedure? AnesthesiaProcedure, (CqlTupleMetadata, string? id, CqlDateTime? LowRiskDatetime)? LowRiskForVTE)? tuple_gwhjghwetinfdseedvamgjivv) => tuple_gwhjghwetinfdseedvamgjivv?.QualifyingEncounter;
        IEnumerable<Encounter?>? j_ = context.Operators.SelectDistinct<(CqlTupleMetadata, Encounter? QualifyingEncounter, Procedure? AnesthesiaProcedure, (CqlTupleMetadata, string? id, CqlDateTime? LowRiskDatetime)? LowRiskForVTE)?, Encounter?>(h_, i_);
        return j_;
    }


    [CqlExpressionDefinition("Encounter With Low Risk For VTE Or Anticoagulant Administered")]
    public IEnumerable<Encounter?>? Encounter_With_Low_Risk_For_VTE_Or_Anticoagulant_Administered(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Encounter_With_Low_Risk_For_VTE_Or_Anticoagulant_Administered, Encounter_With_Low_Risk_For_VTE_Or_Anticoagulant_Administered_Compute);

    private const long _cacheIndex_Encounter_With_Low_Risk_For_VTE_Or_Anticoagulant_Administered = -2696940728686299074L;

    private IEnumerable<Encounter?>? Encounter_With_Low_Risk_For_VTE_Or_Anticoagulant_Administered_Compute(CqlContext context)
    {
        IEnumerable<Encounter?>? a_ = this.Low_Risk_For_VTE_Or_Anticoagulant_Administered_From_Day_Of_Start_Of_Hospitalization_To_Day_After_Admission(context);
        IEnumerable<Encounter?>? b_ = this.Low_Risk_For_VTE_Or_Anticoagulant_Administered_On_Day_Of_Or_Day_After_Procedure(context);
        IEnumerable<Encounter?>? c_ = context.Operators.Union<Encounter?>(a_, b_);
        return c_;
    }


    [CqlExpressionDefinition("No VTE Prophylaxis Medication Administered Or Ordered")]
    public IEnumerable<(CqlTupleMetadata, string? id, IEnumerable<CqlConcept?>? medicationStatusReason, CqlDateTime? authoredOn)?>? No_VTE_Prophylaxis_Medication_Administered_Or_Ordered(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_No_VTE_Prophylaxis_Medication_Administered_Or_Ordered, No_VTE_Prophylaxis_Medication_Administered_Or_Ordered_Compute);

    private const long _cacheIndex_No_VTE_Prophylaxis_Medication_Administered_Or_Ordered = 8768742085925212938L;

    private IEnumerable<(CqlTupleMetadata, string? id, IEnumerable<CqlConcept?>? medicationStatusReason, CqlDateTime? authoredOn)?>? No_VTE_Prophylaxis_Medication_Administered_Or_Ordered_Compute(CqlContext context)
    {
        CqlValueSet? a_ = this.Low_Dose_Unfractionated_Heparin_for_VTE_Prophylaxis(context);
        IEnumerable<MedicationAdministration?>? b_ = context.Operators.Retrieve<MedicationAdministration>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationadministrationnotdone"));
        IEnumerable<MedicationAdministration?>? c_ = context.Operators.Union<MedicationAdministration?>(b_, b_);
        CqlValueSet? d_ = this.Low_Molecular_Weight_Heparin_for_VTE_Prophylaxis(context);
        IEnumerable<MedicationAdministration?>? e_ = context.Operators.Retrieve<MedicationAdministration>(new RetrieveParameters(default, d_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationadministrationnotdone"));
        IEnumerable<MedicationAdministration?>? f_ = context.Operators.Union<MedicationAdministration?>(e_, e_);
        IEnumerable<MedicationAdministration?>? g_ = context.Operators.Union<MedicationAdministration?>(c_, f_);
        CqlValueSet? h_ = this.Injectable_Factor_Xa_Inhibitor_for_VTE_Prophylaxis(context);
        IEnumerable<MedicationAdministration?>? i_ = context.Operators.Retrieve<MedicationAdministration>(new RetrieveParameters(default, h_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationadministrationnotdone"));
        IEnumerable<MedicationAdministration?>? j_ = context.Operators.Union<MedicationAdministration?>(i_, i_);
        IEnumerable<MedicationAdministration?>? k_ = context.Operators.Union<MedicationAdministration?>(g_, j_);
        CqlValueSet? l_ = this.Warfarin(context);
        IEnumerable<MedicationAdministration?>? m_ = context.Operators.Retrieve<MedicationAdministration>(new RetrieveParameters(default, l_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationadministrationnotdone"));
        IEnumerable<MedicationAdministration?>? n_ = context.Operators.Union<MedicationAdministration?>(m_, m_);
        IEnumerable<MedicationAdministration?>? o_ = context.Operators.Union<MedicationAdministration?>(k_, n_);
        CqlValueSet? p_ = this.Rivaroxaban_for_VTE_Prophylaxis(context);
        IEnumerable<MedicationAdministration?>? q_ = context.Operators.Retrieve<MedicationAdministration>(new RetrieveParameters(default, p_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationadministrationnotdone"));
        IEnumerable<MedicationAdministration?>? r_ = context.Operators.Union<MedicationAdministration?>(q_, q_);
        IEnumerable<MedicationAdministration?>? s_ = context.Operators.Union<MedicationAdministration?>(o_, r_);

        (CqlTupleMetadata, string? id, IEnumerable<CqlConcept?>? medicationStatusReason, FhirDateTime? authoredOn)? t_(MedicationAdministration? NoMedicationAdm) {
            Id? bx_ = NoMedicationAdm?.IdElement;
            string? by_ = bx_?.Value;
            List<CodeableConcept>? bz_ = NoMedicationAdm?.StatusReason;

            CqlConcept? ca_(CodeableConcept? @this) {
                CqlConcept? ci_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);
                return ci_;
            }

            IEnumerable<CqlConcept?>? cb_ = context.Operators.Select<CodeableConcept?, CqlConcept?>((IEnumerable<CodeableConcept?>?)bz_, ca_);

            bool? cc_(Extension? @this) {
                FhirUri? cj_ = @this?.UrlElement;
                string? ck_ = FHIRHelpers_4_4_000.Instance.ToString(context, cj_);
                bool? cl_ = context.Operators.Equal(ck_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-recorded");
                return cl_;
            }


            DataType? cd_(Extension? @this) {
                DataType? cm_ = @this?.Value;
                return cm_;
            }

            IEnumerable<DataType?>? ce_ = context.Operators.WhereSelect<Extension?, DataType?>((IEnumerable<Extension?>?)(NoMedicationAdm is DomainResource
                ? (NoMedicationAdm as DomainResource).Extension
                : default), cc_, cd_);
            DataType? cf_ = context.Operators.SingletonFrom<DataType?>(ce_);
            FhirDateTime? cg_ = context.Operators.Convert<FhirDateTime?>(cf_);
            (CqlTupleMetadata, string? id, IEnumerable<CqlConcept?>? medicationStatusReason, FhirDateTime? authoredOn)? ch_ = (CqlTupleMetadata_EBcSahXYZdeFjUUbgULReCZAe, by_, cb_, cg_);
            return ch_;
        }

        IEnumerable<(CqlTupleMetadata, string? id, IEnumerable<CqlConcept?>? medicationStatusReason, FhirDateTime? authoredOn)?>? u_ = context.Operators.SelectDistinct<MedicationAdministration?, (CqlTupleMetadata, string? id, IEnumerable<CqlConcept?>? medicationStatusReason, FhirDateTime? authoredOn)?>(s_, t_);

        (CqlTupleMetadata, string? id, IEnumerable<CqlConcept?>? medicationStatusReason, CqlDateTime? authoredOn)? v_((CqlTupleMetadata, string? id, IEnumerable<CqlConcept?>? medicationStatusReason, FhirDateTime? authoredOn)? tuple_cumbjbeguchwelldvxijceahs) {
            if (tuple_cumbjbeguchwelldvxijceahs is null)
            {
                return default;
            }
            else
            {
                CqlDateTime? cn_ = context.Operators.Convert<CqlDateTime?>(tuple_cumbjbeguchwelldvxijceahs?.authoredOn);
                (CqlTupleMetadata, string? id, IEnumerable<CqlConcept?>? medicationStatusReason, CqlDateTime? authoredOn)? co_ = (CqlTupleMetadata_CNeQfiIHcQEUBjZNVZiOLfdeP, tuple_cumbjbeguchwelldvxijceahs?.id, tuple_cumbjbeguchwelldvxijceahs?.medicationStatusReason, cn_);
                return co_;
            }
        }

        IEnumerable<(CqlTupleMetadata, string? id, IEnumerable<CqlConcept?>? medicationStatusReason, CqlDateTime? authoredOn)?>? w_ = context.Operators.Select<(CqlTupleMetadata, string? id, IEnumerable<CqlConcept?>? medicationStatusReason, FhirDateTime? authoredOn)?, (CqlTupleMetadata, string? id, IEnumerable<CqlConcept?>? medicationStatusReason, CqlDateTime? authoredOn)?>(u_, v_);
        IEnumerable<MedicationRequest?>? x_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationnotrequested"));
        IEnumerable<MedicationRequest?>? y_ = context.Operators.Union<MedicationRequest?>(x_, x_);
        IEnumerable<MedicationRequest?>? z_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, d_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationnotrequested"));
        IEnumerable<MedicationRequest?>? aa_ = context.Operators.Union<MedicationRequest?>(z_, z_);
        IEnumerable<MedicationRequest?>? ab_ = context.Operators.Union<MedicationRequest?>(y_, aa_);
        IEnumerable<MedicationRequest?>? ac_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, h_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationnotrequested"));
        IEnumerable<MedicationRequest?>? ad_ = context.Operators.Union<MedicationRequest?>(ac_, ac_);
        IEnumerable<MedicationRequest?>? ae_ = context.Operators.Union<MedicationRequest?>(ab_, ad_);
        IEnumerable<MedicationRequest?>? af_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, l_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationnotrequested"));
        IEnumerable<MedicationRequest?>? ag_ = context.Operators.Union<MedicationRequest?>(af_, af_);
        IEnumerable<MedicationRequest?>? ah_ = context.Operators.Union<MedicationRequest?>(ae_, ag_);
        IEnumerable<MedicationRequest?>? ai_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, p_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationnotrequested"));
        IEnumerable<MedicationRequest?>? aj_ = context.Operators.Union<MedicationRequest?>(ai_, ai_);
        IEnumerable<MedicationRequest?>? ak_ = context.Operators.Union<MedicationRequest?>(ah_, aj_);

        bool? al_(MedicationRequest? NoMedicationOrder) {
            Code<MedicationRequest.MedicationRequestIntent>? cp_ = NoMedicationOrder?.IntentElement;
            MedicationRequest.MedicationRequestIntent? cq_ = cp_?.Value;
            string? cr_ = context.Operators.Convert<string?>(cq_);
            string?[]? cs_ = [
                "order",
                "original-order",
                "reflex-order",
                "filler-order",
                "instance-order",
            ];
            bool? ct_ = context.Operators.In<string?>(cr_, (IEnumerable<string?>?)cs_);
            Code<MedicationRequest.MedicationrequestStatus>? cu_ = NoMedicationOrder?.StatusElement;
            MedicationRequest.MedicationrequestStatus? cv_ = cu_?.Value;
            string? cw_ = context.Operators.Convert<string?>(cv_);
            string?[]? cx_ = [
                "active",
                "completed",
            ];
            bool? cy_ = context.Operators.In<string?>(cw_, (IEnumerable<string?>?)cx_);
            bool? cz_ = context.Operators.And(ct_, cy_);
            return cz_;
        }


        (CqlTupleMetadata, string? id, IEnumerable<CqlConcept?>? medicationStatusReason, CqlDateTime? authoredOn)? am_(MedicationRequest? NoMedicationOrder) {
            Id? da_ = NoMedicationOrder?.IdElement;
            string? db_ = da_?.Value;
            List<CodeableConcept>? dc_ = NoMedicationOrder?.ReasonCode;

            CqlConcept? dd_(CodeableConcept? @this) {
                CqlConcept? di_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);
                return di_;
            }

            IEnumerable<CqlConcept?>? de_ = context.Operators.Select<CodeableConcept?, CqlConcept?>((IEnumerable<CodeableConcept?>?)dc_, dd_);
            FhirDateTime? df_ = NoMedicationOrder?.AuthoredOnElement;
            CqlDateTime? dg_ = context.Operators.Convert<CqlDateTime?>(df_);
            (CqlTupleMetadata, string? id, IEnumerable<CqlConcept?>? medicationStatusReason, CqlDateTime? authoredOn)? dh_ = (CqlTupleMetadata_CNeQfiIHcQEUBjZNVZiOLfdeP, db_, de_, dg_);
            return dh_;
        }

        IEnumerable<(CqlTupleMetadata, string? id, IEnumerable<CqlConcept?>? medicationStatusReason, CqlDateTime? authoredOn)?>? an_ = context.Operators.WhereSelect<MedicationRequest?, (CqlTupleMetadata, string? id, IEnumerable<CqlConcept?>? medicationStatusReason, CqlDateTime? authoredOn)?>(ak_, al_, am_);
        IEnumerable<(CqlTupleMetadata, string? id, IEnumerable<CqlConcept?>? medicationStatusReason, CqlDateTime? authoredOn)?>? ao_ = context.Operators.Distinct<(CqlTupleMetadata, string? id, IEnumerable<CqlConcept?>? medicationStatusReason, CqlDateTime? authoredOn)?>(an_);
        IEnumerable<(CqlTupleMetadata, string? id, IEnumerable<CqlConcept?>? medicationStatusReason, CqlDateTime? authoredOn)?>? ap_ = context.Operators.Union<(CqlTupleMetadata, string? id, IEnumerable<CqlConcept?>? medicationStatusReason, CqlDateTime? authoredOn)?>(w_, ao_);
        IEnumerable<MedicationRequest?>? aq_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));

        bool? ar_(MedicationRequest? MR) {
            IEnumerable<Medication?>? dj_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));

            bool? dk_(Medication? M) {
                object? dm_ = context.Operators.LateBoundProperty<object?>(M, "id.value");
                object? dn_ = context.Operators.LateBoundProperty<object?>(MR, "medication.reference.value");
                IEnumerable<string?>? do_ = context.Operators.Split((string?)dn_, "/");
                string? dp_ = context.Operators.Last<string?>(do_);
                bool? dq_ = context.Operators.Equal(dm_, dp_);
                CodeableConcept? dr_ = M?.Code;
                CqlConcept? ds_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, dr_);
                CqlValueSet? dt_ = this.Low_Dose_Unfractionated_Heparin_for_VTE_Prophylaxis(context);
                bool? du_ = context.Operators.ConceptInValueSet(ds_, dt_);
                bool? dv_ = context.Operators.And(dq_, du_);
                return dv_;
            }

            bool? dl_ = context.Operators.WhereAny<Medication?>(dj_, dk_);
            return dl_;
        }

        IEnumerable<MedicationRequest?>? as_ = context.Operators.Where<MedicationRequest?>(aq_, ar_);
        IEnumerable<MedicationRequest?>? at_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest?>? au_ = context.Operators.Union<MedicationRequest?>(as_, at_);

        bool? av_(MedicationRequest? MR) {
            IEnumerable<Medication?>? dw_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));

            bool? dx_(Medication? M) {
                object? dz_ = context.Operators.LateBoundProperty<object?>(M, "id.value");
                object? ea_ = context.Operators.LateBoundProperty<object?>(MR, "medication.reference.value");
                IEnumerable<string?>? eb_ = context.Operators.Split((string?)ea_, "/");
                string? ec_ = context.Operators.Last<string?>(eb_);
                bool? ed_ = context.Operators.Equal(dz_, ec_);
                CodeableConcept? ee_ = M?.Code;
                CqlConcept? ef_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, ee_);
                CqlValueSet? eg_ = this.Low_Molecular_Weight_Heparin_for_VTE_Prophylaxis(context);
                bool? eh_ = context.Operators.ConceptInValueSet(ef_, eg_);
                bool? ei_ = context.Operators.And(ed_, eh_);
                return ei_;
            }

            bool? dy_ = context.Operators.WhereAny<Medication?>(dw_, dx_);
            return dy_;
        }

        IEnumerable<MedicationRequest?>? aw_ = context.Operators.Where<MedicationRequest?>(aq_, av_);
        IEnumerable<MedicationRequest?>? ax_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, d_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest?>? ay_ = context.Operators.Union<MedicationRequest?>(aw_, ax_);
        IEnumerable<MedicationRequest?>? az_ = context.Operators.Union<MedicationRequest?>(au_, ay_);

        bool? ba_(MedicationRequest? MR) {
            IEnumerable<Medication?>? ej_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));

            bool? ek_(Medication? M) {
                object? em_ = context.Operators.LateBoundProperty<object?>(M, "id.value");
                object? en_ = context.Operators.LateBoundProperty<object?>(MR, "medication.reference.value");
                IEnumerable<string?>? eo_ = context.Operators.Split((string?)en_, "/");
                string? ep_ = context.Operators.Last<string?>(eo_);
                bool? eq_ = context.Operators.Equal(em_, ep_);
                CodeableConcept? er_ = M?.Code;
                CqlConcept? es_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, er_);
                CqlValueSet? et_ = this.Injectable_Factor_Xa_Inhibitor_for_VTE_Prophylaxis(context);
                bool? eu_ = context.Operators.ConceptInValueSet(es_, et_);
                bool? ev_ = context.Operators.And(eq_, eu_);
                return ev_;
            }

            bool? el_ = context.Operators.WhereAny<Medication?>(ej_, ek_);
            return el_;
        }

        IEnumerable<MedicationRequest?>? bb_ = context.Operators.Where<MedicationRequest?>(aq_, ba_);
        IEnumerable<MedicationRequest?>? bc_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, h_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest?>? bd_ = context.Operators.Union<MedicationRequest?>(bb_, bc_);
        IEnumerable<MedicationRequest?>? be_ = context.Operators.Union<MedicationRequest?>(az_, bd_);

        bool? bf_(MedicationRequest? MR) {
            IEnumerable<Medication?>? ew_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));

            bool? ex_(Medication? M) {
                object? ez_ = context.Operators.LateBoundProperty<object?>(M, "id.value");
                object? fa_ = context.Operators.LateBoundProperty<object?>(MR, "medication.reference.value");
                IEnumerable<string?>? fb_ = context.Operators.Split((string?)fa_, "/");
                string? fc_ = context.Operators.Last<string?>(fb_);
                bool? fd_ = context.Operators.Equal(ez_, fc_);
                CodeableConcept? fe_ = M?.Code;
                CqlConcept? ff_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, fe_);
                CqlValueSet? fg_ = this.Warfarin(context);
                bool? fh_ = context.Operators.ConceptInValueSet(ff_, fg_);
                bool? fi_ = context.Operators.And(fd_, fh_);
                return fi_;
            }

            bool? ey_ = context.Operators.WhereAny<Medication?>(ew_, ex_);
            return ey_;
        }

        IEnumerable<MedicationRequest?>? bg_ = context.Operators.Where<MedicationRequest?>(aq_, bf_);
        IEnumerable<MedicationRequest?>? bh_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, l_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest?>? bi_ = context.Operators.Union<MedicationRequest?>(bg_, bh_);
        IEnumerable<MedicationRequest?>? bj_ = context.Operators.Union<MedicationRequest?>(be_, bi_);

        bool? bk_(MedicationRequest? MR) {
            IEnumerable<Medication?>? fj_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));

            bool? fk_(Medication? M) {
                object? fm_ = context.Operators.LateBoundProperty<object?>(M, "id.value");
                object? fn_ = context.Operators.LateBoundProperty<object?>(MR, "medication.reference.value");
                IEnumerable<string?>? fo_ = context.Operators.Split((string?)fn_, "/");
                string? fp_ = context.Operators.Last<string?>(fo_);
                bool? fq_ = context.Operators.Equal(fm_, fp_);
                CodeableConcept? fr_ = M?.Code;
                CqlConcept? fs_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, fr_);
                CqlValueSet? ft_ = this.Rivaroxaban_for_VTE_Prophylaxis(context);
                bool? fu_ = context.Operators.ConceptInValueSet(fs_, ft_);
                bool? fv_ = context.Operators.And(fq_, fu_);
                return fv_;
            }

            bool? fl_ = context.Operators.WhereAny<Medication?>(fj_, fk_);
            return fl_;
        }

        IEnumerable<MedicationRequest?>? bl_ = context.Operators.Where<MedicationRequest?>(aq_, bk_);
        IEnumerable<MedicationRequest?>? bm_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, p_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest?>? bn_ = context.Operators.Union<MedicationRequest?>(bl_, bm_);
        IEnumerable<MedicationRequest?>? bo_ = context.Operators.Union<MedicationRequest?>(bj_, bn_);
        IEnumerable<Task?>? bp_ = context.Operators.Retrieve<Task>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-taskrejected"));
        IEnumerable<ValueTuple<MedicationRequest?, Task?>>? bq_ = context.Operators.CrossJoin<MedicationRequest?, Task?>(bo_, bp_);

        (CqlTupleMetadata, MedicationRequest? MedicationOrderReject, Task? T)? br_(ValueTuple<MedicationRequest?, Task?> _valueTuple) {
            (CqlTupleMetadata, MedicationRequest? MedicationOrderReject, Task? T)? fw_ = (CqlTupleMetadata_IIUQMBcJhJBPgdDOLHaTTRUE, _valueTuple.Item1, _valueTuple.Item2);
            return fw_;
        }


        bool? bs_((CqlTupleMetadata, MedicationRequest? MedicationOrderReject, Task? T)? tuple_iiuqmbcjhjbpgddolhattrue) {
            ResourceReference? fx_ = tuple_iiuqmbcjhjbpgddolhattrue?.T?.Focus;
            bool? fy_ = QICoreCommon_4_0_000.Instance.references(context, fx_, tuple_iiuqmbcjhjbpgddolhattrue?.MedicationOrderReject);
            CodeableConcept? fz_ = tuple_iiuqmbcjhjbpgddolhattrue?.T?.Code;
            CqlConcept? ga_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, fz_);
            CqlCode? gb_ = QICoreCommon_4_0_000.Instance.Fulfill(context);
            CqlConcept? gc_ = context.Operators.ConvertCodeToConcept(gb_);
            bool? gd_ = context.Operators.Equivalent(ga_, gc_);
            bool? ge_ = context.Operators.And(fy_, gd_);
            Code<MedicationRequest.MedicationrequestStatus>? gf_ = tuple_iiuqmbcjhjbpgddolhattrue?.MedicationOrderReject?.StatusElement;
            MedicationRequest.MedicationrequestStatus? gg_ = gf_?.Value;
            string? gh_ = context.Operators.Convert<string?>(gg_);
            bool? gi_ = context.Operators.Equal(gh_, "active");
            bool? gj_ = context.Operators.And(ge_, gi_);
            return gj_;
        }

        IEnumerable<(CqlTupleMetadata, MedicationRequest? MedicationOrderReject, Task? T)?>? bt_ = context.Operators.SelectWhere<ValueTuple<MedicationRequest?, Task?>, (CqlTupleMetadata, MedicationRequest? MedicationOrderReject, Task? T)?>(bq_, br_, bs_);

        (CqlTupleMetadata, string? id, IEnumerable<CqlConcept?>? medicationStatusReason, CqlDateTime? authoredOn)? bu_((CqlTupleMetadata, MedicationRequest? MedicationOrderReject, Task? T)? tuple_iiuqmbcjhjbpgddolhattrue) {
            Id? gk_ = tuple_iiuqmbcjhjbpgddolhattrue?.MedicationOrderReject?.IdElement;
            string? gl_ = gk_?.Value;
            CodeableConcept? gm_ = tuple_iiuqmbcjhjbpgddolhattrue?.T?.StatusReason;
            CqlConcept? gn_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, gm_);
            CqlConcept?[]? go_ = [
                gn_,
            ];
            FhirDateTime? gp_ = tuple_iiuqmbcjhjbpgddolhattrue?.MedicationOrderReject?.AuthoredOnElement;
            CqlDateTime? gq_ = context.Operators.Convert<CqlDateTime?>(gp_);
            (CqlTupleMetadata, string? id, IEnumerable<CqlConcept?>? medicationStatusReason, CqlDateTime? authoredOn)? gr_ = (CqlTupleMetadata_CNeQfiIHcQEUBjZNVZiOLfdeP, gl_, (IEnumerable<CqlConcept?>?)go_, gq_);
            return gr_;
        }

        IEnumerable<(CqlTupleMetadata, string? id, IEnumerable<CqlConcept?>? medicationStatusReason, CqlDateTime? authoredOn)?>? bv_ = context.Operators.SelectDistinct<(CqlTupleMetadata, MedicationRequest? MedicationOrderReject, Task? T)?, (CqlTupleMetadata, string? id, IEnumerable<CqlConcept?>? medicationStatusReason, CqlDateTime? authoredOn)?>(bt_, bu_);
        IEnumerable<(CqlTupleMetadata, string? id, IEnumerable<CqlConcept?>? medicationStatusReason, CqlDateTime? authoredOn)?>? bw_ = context.Operators.Union<(CqlTupleMetadata, string? id, IEnumerable<CqlConcept?>? medicationStatusReason, CqlDateTime? authoredOn)?>(ap_, bv_);
        return bw_;
    }


    [CqlExpressionDefinition("No VTE Prophylaxis Medication Due To Medical Reason From Day Of Start Of Hospitalization To Day After Admission")]
    public IEnumerable<Encounter?>? No_VTE_Prophylaxis_Medication_Due_To_Medical_Reason_From_Day_Of_Start_Of_Hospitalization_To_Day_After_Admission(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_No_VTE_Prophylaxis_Medication_Due_To_Medical_Reason_From_Day_Of_Start_Of_Hospitalization_To_Day_After_Admission, No_VTE_Prophylaxis_Medication_Due_To_Medical_Reason_From_Day_Of_Start_Of_Hospitalization_To_Day_After_Admission_Compute);

    private const long _cacheIndex_No_VTE_Prophylaxis_Medication_Due_To_Medical_Reason_From_Day_Of_Start_Of_Hospitalization_To_Day_After_Admission = 3917757434461578764L;

    private IEnumerable<Encounter?>? No_VTE_Prophylaxis_Medication_Due_To_Medical_Reason_From_Day_Of_Start_Of_Hospitalization_To_Day_After_Admission_Compute(CqlContext context)
    {
        IEnumerable<Encounter?>? a_ = VTE_8_18_000.Instance.Encounter_With_Age_Range_And_Without_VTE_Diagnosis_Or_Obstetrical_Conditions(context);

        bool? b_(Encounter? QualifyingEncounter) {
            IEnumerable<(CqlTupleMetadata, string? id, IEnumerable<CqlConcept?>? medicationStatusReason, CqlDateTime? authoredOn)?>? d_ = this.No_VTE_Prophylaxis_Medication_Administered_Or_Ordered(context);

            bool? e_((CqlTupleMetadata, string? id, IEnumerable<CqlConcept?>? medicationStatusReason, CqlDateTime? authoredOn)? NoVTEMedication) {
                IEnumerable<CqlConcept>? g_ = NoVTEMedication?.medicationStatusReason;
                CqlValueSet? h_ = this.Medical_Reason_For_Not_Providing_Treatment(context);
                bool? i_ = context.Operators.ConceptsInValueSet(g_, h_);
                CqlDateTime? j_ = NoVTEMedication?.authoredOn;
                CqlInterval<CqlDate?>? k_ = this.fromDayOfStartOfHospitalizationToDayAfterAdmission(context, QualifyingEncounter);
                CqlDate? l_ = k_?.low;
                CqlDateTime? m_ = context.Operators.ConvertDateToDateTime(l_);
                CqlDate? n_ = k_?.high;
                CqlDateTime? o_ = context.Operators.ConvertDateToDateTime(n_);
                bool? p_ = k_?.lowClosed;
                bool? q_ = k_?.highClosed;
                CqlInterval<CqlDateTime?>? r_ = context.Operators.Interval(m_, o_, p_, q_);
                bool? s_ = context.Operators.In<CqlDateTime?>(j_, r_, "day");
                bool? t_ = context.Operators.And(i_, s_);
                return t_;
            }

            bool? f_ = context.Operators.WhereAny<(CqlTupleMetadata, string? id, IEnumerable<CqlConcept?>? medicationStatusReason, CqlDateTime? authoredOn)?>(d_, e_);
            return f_;
        }

        IEnumerable<Encounter?>? c_ = context.Operators.Where<Encounter?>(a_, b_);
        return c_;
    }


    [CqlExpressionDefinition("No Mechanical VTE Prophylaxis Performed Or Ordered")]
    public IEnumerable<(CqlTupleMetadata, string? id, CqlConcept? requestStatusReason, CqlDateTime? authoredOn)?>? No_Mechanical_VTE_Prophylaxis_Performed_Or_Ordered(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_No_Mechanical_VTE_Prophylaxis_Performed_Or_Ordered, No_Mechanical_VTE_Prophylaxis_Performed_Or_Ordered_Compute);

    private const long _cacheIndex_No_Mechanical_VTE_Prophylaxis_Performed_Or_Ordered = -865003797626466093L;

    private IEnumerable<(CqlTupleMetadata, string? id, CqlConcept? requestStatusReason, CqlDateTime? authoredOn)?>? No_Mechanical_VTE_Prophylaxis_Performed_Or_Ordered_Compute(CqlContext context)
    {
        CqlValueSet? a_ = this.Venous_foot_pumps(context);
        IEnumerable<ServiceRequest?>? b_ = context.Operators.Retrieve<ServiceRequest>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-servicenotrequested"));
        IEnumerable<ServiceRequest?>? c_ = context.Operators.Union<ServiceRequest?>(b_, b_);
        CqlValueSet? d_ = this.Intermittent_pneumatic_compression_devices(context);
        IEnumerable<ServiceRequest?>? e_ = context.Operators.Retrieve<ServiceRequest>(new RetrieveParameters(default, d_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-servicenotrequested"));
        IEnumerable<ServiceRequest?>? f_ = context.Operators.Union<ServiceRequest?>(e_, e_);
        IEnumerable<ServiceRequest?>? g_ = context.Operators.Union<ServiceRequest?>(c_, f_);
        CqlValueSet? h_ = this.Graduated_compression_stockings(context);
        IEnumerable<ServiceRequest?>? i_ = context.Operators.Retrieve<ServiceRequest>(new RetrieveParameters(default, h_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-servicenotrequested"));
        IEnumerable<ServiceRequest?>? j_ = context.Operators.Union<ServiceRequest?>(i_, i_);
        IEnumerable<ServiceRequest?>? k_ = context.Operators.Union<ServiceRequest?>(g_, j_);

        bool? l_(ServiceRequest? DeviceNotOrder) {
            Code<RequestIntent>? au_ = DeviceNotOrder?.IntentElement;
            RequestIntent? av_ = au_?.Value;
            Code<RequestIntent>? aw_ = context.Operators.Convert<Code<RequestIntent>?>(av_);
            string? ax_ = context.Operators.Convert<string?>(aw_);
            string?[]? ay_ = [
                "order",
                "original-order",
                "reflex-order",
                "filler-order",
                "instance-order",
            ];
            bool? az_ = context.Operators.In<string?>(ax_, (IEnumerable<string?>?)ay_);
            return az_;
        }


        (CqlTupleMetadata, string? id, CodeableConcept? requestStatusReason, CqlDateTime? authoredOn)? m_(ServiceRequest? DeviceNotOrder) {
            Id? ba_ = DeviceNotOrder?.IdElement;
            string? bb_ = ba_?.Value;

            bool? bc_(Extension? @this) {
                FhirUri? bl_ = @this?.UrlElement;
                string? bm_ = FHIRHelpers_4_4_000.Instance.ToString(context, bl_);
                bool? bn_ = context.Operators.Equal(bm_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-doNotPerformReason");
                return bn_;
            }


            object bd_(Extension? @this) {
                DataType? bo_ = @this?.Value;
                return bo_!;
            }

            IEnumerable<object?>? be_ = context.Operators.WhereSelect<Extension?, object?>((IEnumerable<Extension?>?)(DeviceNotOrder is DomainResource
                ? (DeviceNotOrder as DomainResource).Extension
                : default), bc_, bd_);
            object? bf_ = context.Operators.SingletonFrom<object?>(be_);
            CqlConcept? bg_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, bf_ as CodeableConcept);
            CodeableConcept? bh_ = context.Operators.Convert<CodeableConcept?>(bg_);
            FhirDateTime? bi_ = DeviceNotOrder?.AuthoredOnElement;
            CqlDateTime? bj_ = context.Operators.Convert<CqlDateTime?>(bi_);
            (CqlTupleMetadata, string? id, CodeableConcept? requestStatusReason, CqlDateTime? authoredOn)? bk_ = (CqlTupleMetadata_FVDRPQjOQgYIDhWKHCNhOHceF, bb_, bh_, bj_);
            return bk_;
        }

        IEnumerable<(CqlTupleMetadata, string? id, CodeableConcept? requestStatusReason, CqlDateTime? authoredOn)?>? n_ = context.Operators.WhereSelect<ServiceRequest?, (CqlTupleMetadata, string? id, CodeableConcept? requestStatusReason, CqlDateTime? authoredOn)?>(k_, l_, m_);
        IEnumerable<(CqlTupleMetadata, string? id, CodeableConcept? requestStatusReason, CqlDateTime? authoredOn)?>? o_ = context.Operators.Distinct<(CqlTupleMetadata, string? id, CodeableConcept? requestStatusReason, CqlDateTime? authoredOn)?>(n_);

        (CqlTupleMetadata, string? id, CqlConcept? requestStatusReason, CqlDateTime? authoredOn)? p_((CqlTupleMetadata, string? id, CodeableConcept? requestStatusReason, CqlDateTime? authoredOn)? tuple_gnbatbigxtpdibanunzcndfbr) {
            if (tuple_gnbatbigxtpdibanunzcndfbr is null)
            {
                return default;
            }
            else
            {
                CqlConcept? bp_ = context.Operators.Convert<CqlConcept?>(tuple_gnbatbigxtpdibanunzcndfbr?.requestStatusReason);
                (CqlTupleMetadata, string? id, CqlConcept? requestStatusReason, CqlDateTime? authoredOn)? bq_ = (CqlTupleMetadata_DheTAGNHbFgKVJGaRbPLJVjKH, tuple_gnbatbigxtpdibanunzcndfbr?.id, bp_, tuple_gnbatbigxtpdibanunzcndfbr?.authoredOn);
                return bq_;
            }
        }

        IEnumerable<(CqlTupleMetadata, string? id, CqlConcept? requestStatusReason, CqlDateTime? authoredOn)?>? q_ = context.Operators.Select<(CqlTupleMetadata, string? id, CodeableConcept? requestStatusReason, CqlDateTime? authoredOn)?, (CqlTupleMetadata, string? id, CqlConcept? requestStatusReason, CqlDateTime? authoredOn)?>(o_, p_);
        IEnumerable<ServiceRequest?>? r_ = context.Operators.Retrieve<ServiceRequest>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-servicerequest"));
        IEnumerable<ServiceRequest?>? s_ = context.Operators.Retrieve<ServiceRequest>(new RetrieveParameters(default, d_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-servicerequest"));
        IEnumerable<ServiceRequest?>? t_ = context.Operators.Union<ServiceRequest?>(r_, s_);
        IEnumerable<ServiceRequest?>? u_ = context.Operators.Retrieve<ServiceRequest>(new RetrieveParameters(default, h_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-servicerequest"));
        IEnumerable<ServiceRequest?>? v_ = context.Operators.Union<ServiceRequest?>(t_, u_);
        IEnumerable<Task?>? w_ = context.Operators.Retrieve<Task>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-taskrejected"));
        IEnumerable<ValueTuple<ServiceRequest?, Task?>>? x_ = context.Operators.CrossJoin<ServiceRequest?, Task?>(v_, w_);

        (CqlTupleMetadata, ServiceRequest? DeviceOrderReject, Task? T)? y_(ValueTuple<ServiceRequest?, Task?> _valueTuple) {
            (CqlTupleMetadata, ServiceRequest? DeviceOrderReject, Task? T)? br_ = (CqlTupleMetadata_YYIDPXBNjhOGFRJKYRBMGChb, _valueTuple.Item1, _valueTuple.Item2);
            return br_;
        }


        bool? z_((CqlTupleMetadata, ServiceRequest? DeviceOrderReject, Task? T)? tuple_yyidpxbnjhogfrjkyrbmgchb) {
            Code<RequestIntent>? bs_ = tuple_yyidpxbnjhogfrjkyrbmgchb?.DeviceOrderReject?.IntentElement;
            RequestIntent? bt_ = bs_?.Value;
            Code<RequestIntent>? bu_ = context.Operators.Convert<Code<RequestIntent>?>(bt_);
            string? bv_ = context.Operators.Convert<string?>(bu_);
            string?[]? bw_ = [
                "order",
                "original-order",
                "reflex-order",
                "filler-order",
                "instance-order",
            ];
            bool? bx_ = context.Operators.In<string?>(bv_, (IEnumerable<string?>?)bw_);
            Code<RequestStatus>? by_ = tuple_yyidpxbnjhogfrjkyrbmgchb?.DeviceOrderReject?.StatusElement;
            RequestStatus? bz_ = by_?.Value;
            Code<RequestStatus>? ca_ = context.Operators.Convert<Code<RequestStatus>?>(bz_);
            bool? cb_ = context.Operators.Equal(ca_, "active");
            bool? cc_ = context.Operators.And(bx_, cb_);
            ResourceReference? cd_ = tuple_yyidpxbnjhogfrjkyrbmgchb?.T?.Focus;
            bool? ce_ = QICoreCommon_4_0_000.Instance.references(context, cd_, tuple_yyidpxbnjhogfrjkyrbmgchb?.DeviceOrderReject);
            bool? cf_ = context.Operators.And(cc_, ce_);
            CodeableConcept? cg_ = tuple_yyidpxbnjhogfrjkyrbmgchb?.T?.Code;
            CqlConcept? ch_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, cg_);
            CqlCode? ci_ = QICoreCommon_4_0_000.Instance.Fulfill(context);
            CqlConcept? cj_ = context.Operators.ConvertCodeToConcept(ci_);
            bool? ck_ = context.Operators.Equivalent(ch_, cj_);
            bool? cl_ = context.Operators.And(cf_, ck_);
            return cl_;
        }

        IEnumerable<(CqlTupleMetadata, ServiceRequest? DeviceOrderReject, Task? T)?>? aa_ = context.Operators.SelectWhere<ValueTuple<ServiceRequest?, Task?>, (CqlTupleMetadata, ServiceRequest? DeviceOrderReject, Task? T)?>(x_, y_, z_);

        (CqlTupleMetadata, string? id, CqlConcept? requestStatusReason, CqlDateTime? authoredOn)? ab_((CqlTupleMetadata, ServiceRequest? DeviceOrderReject, Task? T)? tuple_yyidpxbnjhogfrjkyrbmgchb) {
            Id? cm_ = tuple_yyidpxbnjhogfrjkyrbmgchb?.DeviceOrderReject?.IdElement;
            string? cn_ = cm_?.Value;
            CodeableConcept? co_ = tuple_yyidpxbnjhogfrjkyrbmgchb?.T?.StatusReason;
            CqlConcept? cp_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, co_);
            FhirDateTime? cq_ = tuple_yyidpxbnjhogfrjkyrbmgchb?.DeviceOrderReject?.AuthoredOnElement;
            CqlDateTime? cr_ = context.Operators.Convert<CqlDateTime?>(cq_);
            (CqlTupleMetadata, string? id, CqlConcept? requestStatusReason, CqlDateTime? authoredOn)? cs_ = (CqlTupleMetadata_DheTAGNHbFgKVJGaRbPLJVjKH, cn_, cp_, cr_);
            return cs_;
        }

        IEnumerable<(CqlTupleMetadata, string? id, CqlConcept? requestStatusReason, CqlDateTime? authoredOn)?>? ac_ = context.Operators.SelectDistinct<(CqlTupleMetadata, ServiceRequest? DeviceOrderReject, Task? T)?, (CqlTupleMetadata, string? id, CqlConcept? requestStatusReason, CqlDateTime? authoredOn)?>(aa_, ab_);
        IEnumerable<(CqlTupleMetadata, string? id, CqlConcept? requestStatusReason, CqlDateTime? authoredOn)?>? ad_ = context.Operators.Union<(CqlTupleMetadata, string? id, CqlConcept? requestStatusReason, CqlDateTime? authoredOn)?>(q_, ac_);
        CqlValueSet? ae_ = this.Application_of_Intermittent_Pneumatic_Compression_Devices(context);
        IEnumerable<Procedure?>? af_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, ae_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedurenotdone"));
        IEnumerable<Procedure?>? ag_ = context.Operators.Union<Procedure?>(af_, af_);
        CqlValueSet? ah_ = this.Application_of_Venous_Foot_Pumps(context);
        IEnumerable<Procedure?>? ai_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, ah_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedurenotdone"));
        IEnumerable<Procedure?>? aj_ = context.Operators.Union<Procedure?>(ai_, ai_);
        IEnumerable<Procedure?>? ak_ = context.Operators.Union<Procedure?>(ag_, aj_);
        CqlValueSet? al_ = this.Application_of_Graduated_Compression_Stockings(context);
        IEnumerable<Procedure?>? am_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, al_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedurenotdone"));
        IEnumerable<Procedure?>? an_ = context.Operators.Union<Procedure?>(am_, am_);
        IEnumerable<Procedure?>? ao_ = context.Operators.Union<Procedure?>(ak_, an_);

        (CqlTupleMetadata, string? id, CqlConcept? requestStatusReason, FhirDateTime? authoredOn)? ap_(Procedure? DeviceNotApplied) {
            Id? ct_ = DeviceNotApplied?.IdElement;
            string? cu_ = ct_?.Value;
            CodeableConcept? cv_ = DeviceNotApplied?.StatusReason;
            CqlConcept? cw_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, cv_);

            bool? cx_(Extension? @this) {
                FhirUri? dd_ = @this?.UrlElement;
                string? de_ = FHIRHelpers_4_4_000.Instance.ToString(context, dd_);
                bool? df_ = context.Operators.Equal(de_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-recorded");
                return df_;
            }


            DataType? cy_(Extension? @this) {
                DataType? dg_ = @this?.Value;
                return dg_;
            }

            IEnumerable<DataType?>? cz_ = context.Operators.WhereSelect<Extension?, DataType?>((IEnumerable<Extension?>?)(DeviceNotApplied is DomainResource
                ? (DeviceNotApplied as DomainResource).Extension
                : default), cx_, cy_);
            DataType? da_ = context.Operators.SingletonFrom<DataType?>(cz_);
            FhirDateTime? db_ = context.Operators.Convert<FhirDateTime?>(da_);
            (CqlTupleMetadata, string? id, CqlConcept? requestStatusReason, FhirDateTime? authoredOn)? dc_ = (CqlTupleMetadata_DPXDaXjPQUNAIiZCCbGhNdDMi, cu_, cw_, db_);
            return dc_;
        }

        IEnumerable<(CqlTupleMetadata, string? id, CqlConcept? requestStatusReason, FhirDateTime? authoredOn)?>? aq_ = context.Operators.SelectDistinct<Procedure?, (CqlTupleMetadata, string? id, CqlConcept? requestStatusReason, FhirDateTime? authoredOn)?>(ao_, ap_);

        (CqlTupleMetadata, string? id, CqlConcept? requestStatusReason, CqlDateTime? authoredOn)? ar_((CqlTupleMetadata, string? id, CqlConcept? requestStatusReason, FhirDateTime? authoredOn)? tuple_fcgxmnobtfvlcbqjjfugxtftk) {
            if (tuple_fcgxmnobtfvlcbqjjfugxtftk is null)
            {
                return default;
            }
            else
            {
                CqlDateTime? dh_ = context.Operators.Convert<CqlDateTime?>(tuple_fcgxmnobtfvlcbqjjfugxtftk?.authoredOn);
                (CqlTupleMetadata, string? id, CqlConcept? requestStatusReason, CqlDateTime? authoredOn)? di_ = (CqlTupleMetadata_DheTAGNHbFgKVJGaRbPLJVjKH, tuple_fcgxmnobtfvlcbqjjfugxtftk?.id, tuple_fcgxmnobtfvlcbqjjfugxtftk?.requestStatusReason, dh_);
                return di_;
            }
        }

        IEnumerable<(CqlTupleMetadata, string? id, CqlConcept? requestStatusReason, CqlDateTime? authoredOn)?>? as_ = context.Operators.Select<(CqlTupleMetadata, string? id, CqlConcept? requestStatusReason, FhirDateTime? authoredOn)?, (CqlTupleMetadata, string? id, CqlConcept? requestStatusReason, CqlDateTime? authoredOn)?>(aq_, ar_);
        IEnumerable<(CqlTupleMetadata, string? id, CqlConcept? requestStatusReason, CqlDateTime? authoredOn)?>? at_ = context.Operators.Union<(CqlTupleMetadata, string? id, CqlConcept? requestStatusReason, CqlDateTime? authoredOn)?>(ad_, as_);
        return at_;
    }


    [CqlExpressionDefinition("No Mechanical VTE Prophylaxis Due To Medical Reason From Day Of Start Of Hospitalization To Day After Admission")]
    public IEnumerable<Encounter?>? No_Mechanical_VTE_Prophylaxis_Due_To_Medical_Reason_From_Day_Of_Start_Of_Hospitalization_To_Day_After_Admission(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_No_Mechanical_VTE_Prophylaxis_Due_To_Medical_Reason_From_Day_Of_Start_Of_Hospitalization_To_Day_After_Admission, No_Mechanical_VTE_Prophylaxis_Due_To_Medical_Reason_From_Day_Of_Start_Of_Hospitalization_To_Day_After_Admission_Compute);

    private const long _cacheIndex_No_Mechanical_VTE_Prophylaxis_Due_To_Medical_Reason_From_Day_Of_Start_Of_Hospitalization_To_Day_After_Admission = 5040437268030859533L;

    private IEnumerable<Encounter?>? No_Mechanical_VTE_Prophylaxis_Due_To_Medical_Reason_From_Day_Of_Start_Of_Hospitalization_To_Day_After_Admission_Compute(CqlContext context)
    {
        IEnumerable<Encounter?>? a_ = VTE_8_18_000.Instance.Encounter_With_Age_Range_And_Without_VTE_Diagnosis_Or_Obstetrical_Conditions(context);

        bool? b_(Encounter? QualifyingEncounter) {
            IEnumerable<(CqlTupleMetadata, string? id, CqlConcept? requestStatusReason, CqlDateTime? authoredOn)?>? d_ = this.No_Mechanical_VTE_Prophylaxis_Performed_Or_Ordered(context);

            bool? e_((CqlTupleMetadata, string? id, CqlConcept? requestStatusReason, CqlDateTime? authoredOn)? NoVTEDevice) {
                CqlConcept? g_ = NoVTEDevice?.requestStatusReason;
                CqlValueSet? h_ = this.Medical_Reason_For_Not_Providing_Treatment(context);
                bool? i_ = context.Operators.ConceptInValueSet(g_, h_);
                CqlDateTime? j_ = NoVTEDevice?.authoredOn;
                CqlInterval<CqlDate?>? k_ = this.fromDayOfStartOfHospitalizationToDayAfterAdmission(context, QualifyingEncounter);
                CqlDate? l_ = k_?.low;
                CqlDateTime? m_ = context.Operators.ConvertDateToDateTime(l_);
                CqlDate? n_ = k_?.high;
                CqlDateTime? o_ = context.Operators.ConvertDateToDateTime(n_);
                bool? p_ = k_?.lowClosed;
                bool? q_ = k_?.highClosed;
                CqlInterval<CqlDateTime?>? r_ = context.Operators.Interval(m_, o_, p_, q_);
                bool? s_ = context.Operators.In<CqlDateTime?>(j_, r_, "day");
                bool? t_ = context.Operators.And(i_, s_);
                return t_;
            }

            bool? f_ = context.Operators.WhereAny<(CqlTupleMetadata, string? id, CqlConcept? requestStatusReason, CqlDateTime? authoredOn)?>(d_, e_);
            return f_;
        }

        IEnumerable<Encounter?>? c_ = context.Operators.Where<Encounter?>(a_, b_);
        return c_;
    }


    [CqlExpressionDefinition("No VTE Prophylaxis Medication Due To Medical Reason On Day Of Or Day After Procedure")]
    public IEnumerable<Encounter?>? No_VTE_Prophylaxis_Medication_Due_To_Medical_Reason_On_Day_Of_Or_Day_After_Procedure(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_No_VTE_Prophylaxis_Medication_Due_To_Medical_Reason_On_Day_Of_Or_Day_After_Procedure, No_VTE_Prophylaxis_Medication_Due_To_Medical_Reason_On_Day_Of_Or_Day_After_Procedure_Compute);

    private const long _cacheIndex_No_VTE_Prophylaxis_Medication_Due_To_Medical_Reason_On_Day_Of_Or_Day_After_Procedure = 4328598489171831529L;

    private IEnumerable<Encounter?>? No_VTE_Prophylaxis_Medication_Due_To_Medical_Reason_On_Day_Of_Or_Day_After_Procedure_Compute(CqlContext context)
    {
        IEnumerable<Encounter?>? a_ = VTE_8_18_000.Instance.Encounter_With_Age_Range_And_Without_VTE_Diagnosis_Or_Obstetrical_Conditions(context);
        CqlValueSet? b_ = this.General_or_Neuraxial_Anesthesia(context);
        IEnumerable<Procedure?>? c_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, b_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
        IEnumerable<(CqlTupleMetadata, string? id, IEnumerable<CqlConcept?>? medicationStatusReason, CqlDateTime? authoredOn)?>? d_ = this.No_VTE_Prophylaxis_Medication_Administered_Or_Ordered(context);
        IEnumerable<ValueTuple<Encounter?, Procedure?, (CqlTupleMetadata, string? id, IEnumerable<CqlConcept?>? medicationStatusReason, CqlDateTime? authoredOn)?>>? e_ = context.Operators.CrossJoin<Encounter?, Procedure?, (CqlTupleMetadata, string? id, IEnumerable<CqlConcept?>? medicationStatusReason, CqlDateTime? authoredOn)?>(a_, c_, d_);

        (CqlTupleMetadata, Encounter? QualifyingEncounter, Procedure? AnesthesiaProcedure, (CqlTupleMetadata, string? id, IEnumerable<CqlConcept?>? medicationStatusReason, CqlDateTime? authoredOn)? NoVTEMedication)? f_(ValueTuple<Encounter?, Procedure?, (CqlTupleMetadata, string? id, IEnumerable<CqlConcept?>? medicationStatusReason, CqlDateTime? authoredOn)?> _valueTuple) {
            (CqlTupleMetadata, Encounter? QualifyingEncounter, Procedure? AnesthesiaProcedure, (CqlTupleMetadata, string? id, IEnumerable<CqlConcept?>? medicationStatusReason, CqlDateTime? authoredOn)? NoVTEMedication)? k_ = (CqlTupleMetadata_CUUMXUZWiBObPgSAjXGJDhdYW, _valueTuple.Item1, _valueTuple.Item2, _valueTuple.Item3);
            return k_;
        }


        bool? g_((CqlTupleMetadata, Encounter? QualifyingEncounter, Procedure? AnesthesiaProcedure, (CqlTupleMetadata, string? id, IEnumerable<CqlConcept?>? medicationStatusReason, CqlDateTime? authoredOn)? NoVTEMedication)? tuple_chjebychscdthhbpzggacmwxe) {
            IEnumerable<CqlConcept>? l_ = tuple_chjebychscdthhbpzggacmwxe?.NoVTEMedication?.medicationStatusReason;
            CqlValueSet? m_ = this.Medical_Reason_For_Not_Providing_Treatment(context);
            bool? n_ = context.Operators.ConceptsInValueSet(l_, m_);
            Code<EventStatus>? o_ = tuple_chjebychscdthhbpzggacmwxe?.AnesthesiaProcedure?.StatusElement;
            EventStatus? p_ = o_?.Value;
            string? q_ = context.Operators.Convert<string?>(p_);
            bool? r_ = context.Operators.Equal(q_, "completed");
            bool? s_ = context.Operators.And(n_, r_);
            object? t_;
            DataType? bd_ = tuple_chjebychscdthhbpzggacmwxe?.AnesthesiaProcedure?.Performed;
            object? be_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bd_);
            bool bf_ = be_ is CqlDateTime;
            if (bf_)
            {
                DataType? bg_ = tuple_chjebychscdthhbpzggacmwxe?.AnesthesiaProcedure?.Performed;
                object? bh_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bg_);
                t_ = bh_ as CqlDateTime;
            }
            else
            {
                DataType? bi_ = tuple_chjebychscdthhbpzggacmwxe?.AnesthesiaProcedure?.Performed;
                object? bj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bi_);
                bool bk_ = bj_ is CqlQuantity;
                if (bk_)
                {
                    DataType? bl_ = tuple_chjebychscdthhbpzggacmwxe?.AnesthesiaProcedure?.Performed;
                    object? bm_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bl_);
                    t_ = bm_ as CqlQuantity;
                }
                else
                {
                    DataType? bn_ = tuple_chjebychscdthhbpzggacmwxe?.AnesthesiaProcedure?.Performed;
                    object? bo_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bn_);
                    bool bp_ = bo_ is CqlInterval<CqlDateTime>;
                    if (bp_)
                    {
                        DataType? bq_ = tuple_chjebychscdthhbpzggacmwxe?.AnesthesiaProcedure?.Performed;
                        object? br_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bq_);
                        t_ = br_ as CqlInterval<CqlDateTime?>;
                    }
                    else
                    {
                        DataType? bs_ = tuple_chjebychscdthhbpzggacmwxe?.AnesthesiaProcedure?.Performed;
                        object? bt_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bs_);
                        bool bu_ = bt_ is CqlInterval<CqlQuantity>;
                        if (bu_)
                        {
                            DataType? bv_ = tuple_chjebychscdthhbpzggacmwxe?.AnesthesiaProcedure?.Performed;
                            object? bw_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bv_);
                            t_ = bw_ as CqlInterval<CqlQuantity?>;
                        }
                        else
                        {
                            t_ = null;
                        }
                    }
                }
            }
            CqlInterval<CqlDateTime?>? u_ = QICoreCommon_4_0_000.Instance.toInterval(context, t_);
            CqlDateTime? v_ = context.Operators.End(u_);
            Period? w_ = tuple_chjebychscdthhbpzggacmwxe?.QualifyingEncounter?.Period;
            CqlInterval<CqlDateTime?>? x_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, w_);
            CqlDateTime? y_ = context.Operators.Start(x_);
            CqlQuantity? z_ = context.Operators.Quantity(1m, "day");
            CqlDateTime? aa_ = context.Operators.Add(y_, z_);
            bool? ab_ = context.Operators.SameAs(v_, aa_, "day");
            bool? ac_ = context.Operators.And(s_, ab_);
            CqlDateTime? ad_ = tuple_chjebychscdthhbpzggacmwxe?.NoVTEMedication?.authoredOn;
            object? ae_;
            DataType? bx_ = tuple_chjebychscdthhbpzggacmwxe?.AnesthesiaProcedure?.Performed;
            object? by_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bx_);
            bool bz_ = by_ is CqlDateTime;
            if (bz_)
            {
                DataType? ca_ = tuple_chjebychscdthhbpzggacmwxe?.AnesthesiaProcedure?.Performed;
                object? cb_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ca_);
                ae_ = cb_ as CqlDateTime;
            }
            else
            {
                DataType? cc_ = tuple_chjebychscdthhbpzggacmwxe?.AnesthesiaProcedure?.Performed;
                object? cd_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cc_);
                bool ce_ = cd_ is CqlQuantity;
                if (ce_)
                {
                    DataType? cf_ = tuple_chjebychscdthhbpzggacmwxe?.AnesthesiaProcedure?.Performed;
                    object? cg_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cf_);
                    ae_ = cg_ as CqlQuantity;
                }
                else
                {
                    DataType? ch_ = tuple_chjebychscdthhbpzggacmwxe?.AnesthesiaProcedure?.Performed;
                    object? ci_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ch_);
                    bool cj_ = ci_ is CqlInterval<CqlDateTime>;
                    if (cj_)
                    {
                        DataType? ck_ = tuple_chjebychscdthhbpzggacmwxe?.AnesthesiaProcedure?.Performed;
                        object? cl_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ck_);
                        ae_ = cl_ as CqlInterval<CqlDateTime?>;
                    }
                    else
                    {
                        DataType? cm_ = tuple_chjebychscdthhbpzggacmwxe?.AnesthesiaProcedure?.Performed;
                        object? cn_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cm_);
                        bool co_ = cn_ is CqlInterval<CqlQuantity>;
                        if (co_)
                        {
                            DataType? cp_ = tuple_chjebychscdthhbpzggacmwxe?.AnesthesiaProcedure?.Performed;
                            object? cq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cp_);
                            ae_ = cq_ as CqlInterval<CqlQuantity?>;
                        }
                        else
                        {
                            ae_ = null;
                        }
                    }
                }
            }
            CqlInterval<CqlDateTime?>? af_ = QICoreCommon_4_0_000.Instance.toInterval(context, ae_);
            CqlDateTime? ag_ = context.Operators.End(af_);
            CqlInterval<CqlDate?>? ah_ = TJCOverall_8_25_000.Instance.calendarDayOfOrDayAfter(context, ag_);
            CqlDate? ai_ = ah_?.low;
            CqlDateTime? aj_ = context.Operators.ConvertDateToDateTime(ai_);
            object? ak_;
            DataType? cr_ = tuple_chjebychscdthhbpzggacmwxe?.AnesthesiaProcedure?.Performed;
            object? cs_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cr_);
            bool ct_ = cs_ is CqlDateTime;
            if (ct_)
            {
                DataType? cu_ = tuple_chjebychscdthhbpzggacmwxe?.AnesthesiaProcedure?.Performed;
                object? cv_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cu_);
                ak_ = cv_ as CqlDateTime;
            }
            else
            {
                DataType? cw_ = tuple_chjebychscdthhbpzggacmwxe?.AnesthesiaProcedure?.Performed;
                object? cx_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cw_);
                bool cy_ = cx_ is CqlQuantity;
                if (cy_)
                {
                    DataType? cz_ = tuple_chjebychscdthhbpzggacmwxe?.AnesthesiaProcedure?.Performed;
                    object? da_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cz_);
                    ak_ = da_ as CqlQuantity;
                }
                else
                {
                    DataType? db_ = tuple_chjebychscdthhbpzggacmwxe?.AnesthesiaProcedure?.Performed;
                    object? dc_ = FHIRHelpers_4_4_000.Instance.ToValue(context, db_);
                    bool dd_ = dc_ is CqlInterval<CqlDateTime>;
                    if (dd_)
                    {
                        DataType? de_ = tuple_chjebychscdthhbpzggacmwxe?.AnesthesiaProcedure?.Performed;
                        object? df_ = FHIRHelpers_4_4_000.Instance.ToValue(context, de_);
                        ak_ = df_ as CqlInterval<CqlDateTime?>;
                    }
                    else
                    {
                        DataType? dg_ = tuple_chjebychscdthhbpzggacmwxe?.AnesthesiaProcedure?.Performed;
                        object? dh_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dg_);
                        bool di_ = dh_ is CqlInterval<CqlQuantity>;
                        if (di_)
                        {
                            DataType? dj_ = tuple_chjebychscdthhbpzggacmwxe?.AnesthesiaProcedure?.Performed;
                            object? dk_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dj_);
                            ak_ = dk_ as CqlInterval<CqlQuantity?>;
                        }
                        else
                        {
                            ak_ = null;
                        }
                    }
                }
            }
            CqlInterval<CqlDateTime?>? al_ = QICoreCommon_4_0_000.Instance.toInterval(context, ak_);
            CqlDateTime? am_ = context.Operators.End(al_);
            CqlInterval<CqlDate?>? an_ = TJCOverall_8_25_000.Instance.calendarDayOfOrDayAfter(context, am_);
            CqlDate? ao_ = an_?.high;
            CqlDateTime? ap_ = context.Operators.ConvertDateToDateTime(ao_);
            object? aq_;
            DataType? dl_ = tuple_chjebychscdthhbpzggacmwxe?.AnesthesiaProcedure?.Performed;
            object? dm_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dl_);
            bool dn_ = dm_ is CqlDateTime;
            if (dn_)
            {
                DataType? do_ = tuple_chjebychscdthhbpzggacmwxe?.AnesthesiaProcedure?.Performed;
                object? dp_ = FHIRHelpers_4_4_000.Instance.ToValue(context, do_);
                aq_ = dp_ as CqlDateTime;
            }
            else
            {
                DataType? dq_ = tuple_chjebychscdthhbpzggacmwxe?.AnesthesiaProcedure?.Performed;
                object? dr_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dq_);
                bool ds_ = dr_ is CqlQuantity;
                if (ds_)
                {
                    DataType? dt_ = tuple_chjebychscdthhbpzggacmwxe?.AnesthesiaProcedure?.Performed;
                    object? du_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dt_);
                    aq_ = du_ as CqlQuantity;
                }
                else
                {
                    DataType? dv_ = tuple_chjebychscdthhbpzggacmwxe?.AnesthesiaProcedure?.Performed;
                    object? dw_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dv_);
                    bool dx_ = dw_ is CqlInterval<CqlDateTime>;
                    if (dx_)
                    {
                        DataType? dy_ = tuple_chjebychscdthhbpzggacmwxe?.AnesthesiaProcedure?.Performed;
                        object? dz_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dy_);
                        aq_ = dz_ as CqlInterval<CqlDateTime?>;
                    }
                    else
                    {
                        DataType? ea_ = tuple_chjebychscdthhbpzggacmwxe?.AnesthesiaProcedure?.Performed;
                        object? eb_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ea_);
                        bool ec_ = eb_ is CqlInterval<CqlQuantity>;
                        if (ec_)
                        {
                            DataType? ed_ = tuple_chjebychscdthhbpzggacmwxe?.AnesthesiaProcedure?.Performed;
                            object? ee_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ed_);
                            aq_ = ee_ as CqlInterval<CqlQuantity?>;
                        }
                        else
                        {
                            aq_ = null;
                        }
                    }
                }
            }
            CqlInterval<CqlDateTime?>? ar_ = QICoreCommon_4_0_000.Instance.toInterval(context, aq_);
            CqlDateTime? as_ = context.Operators.End(ar_);
            CqlInterval<CqlDate?>? at_ = TJCOverall_8_25_000.Instance.calendarDayOfOrDayAfter(context, as_);
            bool? au_ = at_?.lowClosed;
            object? av_;
            DataType? ef_ = tuple_chjebychscdthhbpzggacmwxe?.AnesthesiaProcedure?.Performed;
            object? eg_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ef_);
            bool eh_ = eg_ is CqlDateTime;
            if (eh_)
            {
                DataType? ei_ = tuple_chjebychscdthhbpzggacmwxe?.AnesthesiaProcedure?.Performed;
                object? ej_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ei_);
                av_ = ej_ as CqlDateTime;
            }
            else
            {
                DataType? ek_ = tuple_chjebychscdthhbpzggacmwxe?.AnesthesiaProcedure?.Performed;
                object? el_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ek_);
                bool em_ = el_ is CqlQuantity;
                if (em_)
                {
                    DataType? en_ = tuple_chjebychscdthhbpzggacmwxe?.AnesthesiaProcedure?.Performed;
                    object? eo_ = FHIRHelpers_4_4_000.Instance.ToValue(context, en_);
                    av_ = eo_ as CqlQuantity;
                }
                else
                {
                    DataType? ep_ = tuple_chjebychscdthhbpzggacmwxe?.AnesthesiaProcedure?.Performed;
                    object? eq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ep_);
                    bool er_ = eq_ is CqlInterval<CqlDateTime>;
                    if (er_)
                    {
                        DataType? es_ = tuple_chjebychscdthhbpzggacmwxe?.AnesthesiaProcedure?.Performed;
                        object? et_ = FHIRHelpers_4_4_000.Instance.ToValue(context, es_);
                        av_ = et_ as CqlInterval<CqlDateTime?>;
                    }
                    else
                    {
                        DataType? eu_ = tuple_chjebychscdthhbpzggacmwxe?.AnesthesiaProcedure?.Performed;
                        object? ev_ = FHIRHelpers_4_4_000.Instance.ToValue(context, eu_);
                        bool ew_ = ev_ is CqlInterval<CqlQuantity>;
                        if (ew_)
                        {
                            DataType? ex_ = tuple_chjebychscdthhbpzggacmwxe?.AnesthesiaProcedure?.Performed;
                            object? ey_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ex_);
                            av_ = ey_ as CqlInterval<CqlQuantity?>;
                        }
                        else
                        {
                            av_ = null;
                        }
                    }
                }
            }
            CqlInterval<CqlDateTime?>? aw_ = QICoreCommon_4_0_000.Instance.toInterval(context, av_);
            CqlDateTime? ax_ = context.Operators.End(aw_);
            CqlInterval<CqlDate?>? ay_ = TJCOverall_8_25_000.Instance.calendarDayOfOrDayAfter(context, ax_);
            bool? az_ = ay_?.highClosed;
            CqlInterval<CqlDateTime?>? ba_ = context.Operators.Interval(aj_, ap_, au_, az_);
            bool? bb_ = context.Operators.In<CqlDateTime?>(ad_, ba_, "day");
            bool? bc_ = context.Operators.And(ac_, bb_);
            return bc_;
        }

        IEnumerable<(CqlTupleMetadata, Encounter? QualifyingEncounter, Procedure? AnesthesiaProcedure, (CqlTupleMetadata, string? id, IEnumerable<CqlConcept?>? medicationStatusReason, CqlDateTime? authoredOn)? NoVTEMedication)?>? h_ = context.Operators.SelectWhere<ValueTuple<Encounter?, Procedure?, (CqlTupleMetadata, string? id, IEnumerable<CqlConcept?>? medicationStatusReason, CqlDateTime? authoredOn)?>, (CqlTupleMetadata, Encounter? QualifyingEncounter, Procedure? AnesthesiaProcedure, (CqlTupleMetadata, string? id, IEnumerable<CqlConcept?>? medicationStatusReason, CqlDateTime? authoredOn)? NoVTEMedication)?>(e_, f_, g_);
        Encounter? i_((CqlTupleMetadata, Encounter? QualifyingEncounter, Procedure? AnesthesiaProcedure, (CqlTupleMetadata, string? id, IEnumerable<CqlConcept?>? medicationStatusReason, CqlDateTime? authoredOn)? NoVTEMedication)? tuple_chjebychscdthhbpzggacmwxe) => tuple_chjebychscdthhbpzggacmwxe?.QualifyingEncounter;
        IEnumerable<Encounter?>? j_ = context.Operators.SelectDistinct<(CqlTupleMetadata, Encounter? QualifyingEncounter, Procedure? AnesthesiaProcedure, (CqlTupleMetadata, string? id, IEnumerable<CqlConcept?>? medicationStatusReason, CqlDateTime? authoredOn)? NoVTEMedication)?, Encounter?>(h_, i_);
        return j_;
    }


    [CqlExpressionDefinition("No Mechanical VTE Prophylaxis Due To Medical Reason On Day Of Or Day After Procedure")]
    public IEnumerable<Encounter?>? No_Mechanical_VTE_Prophylaxis_Due_To_Medical_Reason_On_Day_Of_Or_Day_After_Procedure(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_No_Mechanical_VTE_Prophylaxis_Due_To_Medical_Reason_On_Day_Of_Or_Day_After_Procedure, No_Mechanical_VTE_Prophylaxis_Due_To_Medical_Reason_On_Day_Of_Or_Day_After_Procedure_Compute);

    private const long _cacheIndex_No_Mechanical_VTE_Prophylaxis_Due_To_Medical_Reason_On_Day_Of_Or_Day_After_Procedure = 9122492611972872732L;

    private IEnumerable<Encounter?>? No_Mechanical_VTE_Prophylaxis_Due_To_Medical_Reason_On_Day_Of_Or_Day_After_Procedure_Compute(CqlContext context)
    {
        IEnumerable<Encounter?>? a_ = VTE_8_18_000.Instance.Encounter_With_Age_Range_And_Without_VTE_Diagnosis_Or_Obstetrical_Conditions(context);
        CqlValueSet? b_ = this.General_or_Neuraxial_Anesthesia(context);
        IEnumerable<Procedure?>? c_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, b_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
        IEnumerable<(CqlTupleMetadata, string? id, CqlConcept? requestStatusReason, CqlDateTime? authoredOn)?>? d_ = this.No_Mechanical_VTE_Prophylaxis_Performed_Or_Ordered(context);
        IEnumerable<ValueTuple<Encounter?, Procedure?, (CqlTupleMetadata, string? id, CqlConcept? requestStatusReason, CqlDateTime? authoredOn)?>>? e_ = context.Operators.CrossJoin<Encounter?, Procedure?, (CqlTupleMetadata, string? id, CqlConcept? requestStatusReason, CqlDateTime? authoredOn)?>(a_, c_, d_);

        (CqlTupleMetadata, Encounter? QualifyingEncounter, Procedure? AnesthesiaProcedure, (CqlTupleMetadata, string? id, CqlConcept? requestStatusReason, CqlDateTime? authoredOn)? NoVTEDevice)? f_(ValueTuple<Encounter?, Procedure?, (CqlTupleMetadata, string? id, CqlConcept? requestStatusReason, CqlDateTime? authoredOn)?> _valueTuple) {
            (CqlTupleMetadata, Encounter? QualifyingEncounter, Procedure? AnesthesiaProcedure, (CqlTupleMetadata, string? id, CqlConcept? requestStatusReason, CqlDateTime? authoredOn)? NoVTEDevice)? k_ = (CqlTupleMetadata_FNWjhIAKXiLTDJAYchhKVfDAc, _valueTuple.Item1, _valueTuple.Item2, _valueTuple.Item3);
            return k_;
        }


        bool? g_((CqlTupleMetadata, Encounter? QualifyingEncounter, Procedure? AnesthesiaProcedure, (CqlTupleMetadata, string? id, CqlConcept? requestStatusReason, CqlDateTime? authoredOn)? NoVTEDevice)? tuple_cadhcldckpqwmtcazwxfnkhgc) {
            CqlConcept? l_ = tuple_cadhcldckpqwmtcazwxfnkhgc?.NoVTEDevice?.requestStatusReason;
            CqlValueSet? m_ = this.Medical_Reason_For_Not_Providing_Treatment(context);
            bool? n_ = context.Operators.ConceptInValueSet(l_, m_);
            Code<EventStatus>? o_ = tuple_cadhcldckpqwmtcazwxfnkhgc?.AnesthesiaProcedure?.StatusElement;
            EventStatus? p_ = o_?.Value;
            string? q_ = context.Operators.Convert<string?>(p_);
            bool? r_ = context.Operators.Equal(q_, "completed");
            bool? s_ = context.Operators.And(n_, r_);
            object? t_;
            DataType? bd_ = tuple_cadhcldckpqwmtcazwxfnkhgc?.AnesthesiaProcedure?.Performed;
            object? be_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bd_);
            bool bf_ = be_ is CqlDateTime;
            if (bf_)
            {
                DataType? bg_ = tuple_cadhcldckpqwmtcazwxfnkhgc?.AnesthesiaProcedure?.Performed;
                object? bh_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bg_);
                t_ = bh_ as CqlDateTime;
            }
            else
            {
                DataType? bi_ = tuple_cadhcldckpqwmtcazwxfnkhgc?.AnesthesiaProcedure?.Performed;
                object? bj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bi_);
                bool bk_ = bj_ is CqlQuantity;
                if (bk_)
                {
                    DataType? bl_ = tuple_cadhcldckpqwmtcazwxfnkhgc?.AnesthesiaProcedure?.Performed;
                    object? bm_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bl_);
                    t_ = bm_ as CqlQuantity;
                }
                else
                {
                    DataType? bn_ = tuple_cadhcldckpqwmtcazwxfnkhgc?.AnesthesiaProcedure?.Performed;
                    object? bo_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bn_);
                    bool bp_ = bo_ is CqlInterval<CqlDateTime>;
                    if (bp_)
                    {
                        DataType? bq_ = tuple_cadhcldckpqwmtcazwxfnkhgc?.AnesthesiaProcedure?.Performed;
                        object? br_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bq_);
                        t_ = br_ as CqlInterval<CqlDateTime?>;
                    }
                    else
                    {
                        DataType? bs_ = tuple_cadhcldckpqwmtcazwxfnkhgc?.AnesthesiaProcedure?.Performed;
                        object? bt_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bs_);
                        bool bu_ = bt_ is CqlInterval<CqlQuantity>;
                        if (bu_)
                        {
                            DataType? bv_ = tuple_cadhcldckpqwmtcazwxfnkhgc?.AnesthesiaProcedure?.Performed;
                            object? bw_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bv_);
                            t_ = bw_ as CqlInterval<CqlQuantity?>;
                        }
                        else
                        {
                            t_ = null;
                        }
                    }
                }
            }
            CqlInterval<CqlDateTime?>? u_ = QICoreCommon_4_0_000.Instance.toInterval(context, t_);
            CqlDateTime? v_ = context.Operators.End(u_);
            Period? w_ = tuple_cadhcldckpqwmtcazwxfnkhgc?.QualifyingEncounter?.Period;
            CqlInterval<CqlDateTime?>? x_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, w_);
            CqlDateTime? y_ = context.Operators.Start(x_);
            CqlQuantity? z_ = context.Operators.Quantity(1m, "day");
            CqlDateTime? aa_ = context.Operators.Add(y_, z_);
            bool? ab_ = context.Operators.SameAs(v_, aa_, "day");
            bool? ac_ = context.Operators.And(s_, ab_);
            CqlDateTime? ad_ = tuple_cadhcldckpqwmtcazwxfnkhgc?.NoVTEDevice?.authoredOn;
            object? ae_;
            DataType? bx_ = tuple_cadhcldckpqwmtcazwxfnkhgc?.AnesthesiaProcedure?.Performed;
            object? by_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bx_);
            bool bz_ = by_ is CqlDateTime;
            if (bz_)
            {
                DataType? ca_ = tuple_cadhcldckpqwmtcazwxfnkhgc?.AnesthesiaProcedure?.Performed;
                object? cb_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ca_);
                ae_ = cb_ as CqlDateTime;
            }
            else
            {
                DataType? cc_ = tuple_cadhcldckpqwmtcazwxfnkhgc?.AnesthesiaProcedure?.Performed;
                object? cd_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cc_);
                bool ce_ = cd_ is CqlQuantity;
                if (ce_)
                {
                    DataType? cf_ = tuple_cadhcldckpqwmtcazwxfnkhgc?.AnesthesiaProcedure?.Performed;
                    object? cg_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cf_);
                    ae_ = cg_ as CqlQuantity;
                }
                else
                {
                    DataType? ch_ = tuple_cadhcldckpqwmtcazwxfnkhgc?.AnesthesiaProcedure?.Performed;
                    object? ci_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ch_);
                    bool cj_ = ci_ is CqlInterval<CqlDateTime>;
                    if (cj_)
                    {
                        DataType? ck_ = tuple_cadhcldckpqwmtcazwxfnkhgc?.AnesthesiaProcedure?.Performed;
                        object? cl_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ck_);
                        ae_ = cl_ as CqlInterval<CqlDateTime?>;
                    }
                    else
                    {
                        DataType? cm_ = tuple_cadhcldckpqwmtcazwxfnkhgc?.AnesthesiaProcedure?.Performed;
                        object? cn_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cm_);
                        bool co_ = cn_ is CqlInterval<CqlQuantity>;
                        if (co_)
                        {
                            DataType? cp_ = tuple_cadhcldckpqwmtcazwxfnkhgc?.AnesthesiaProcedure?.Performed;
                            object? cq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cp_);
                            ae_ = cq_ as CqlInterval<CqlQuantity?>;
                        }
                        else
                        {
                            ae_ = null;
                        }
                    }
                }
            }
            CqlInterval<CqlDateTime?>? af_ = QICoreCommon_4_0_000.Instance.toInterval(context, ae_);
            CqlDateTime? ag_ = context.Operators.End(af_);
            CqlInterval<CqlDate?>? ah_ = TJCOverall_8_25_000.Instance.calendarDayOfOrDayAfter(context, ag_);
            CqlDate? ai_ = ah_?.low;
            CqlDateTime? aj_ = context.Operators.ConvertDateToDateTime(ai_);
            object? ak_;
            DataType? cr_ = tuple_cadhcldckpqwmtcazwxfnkhgc?.AnesthesiaProcedure?.Performed;
            object? cs_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cr_);
            bool ct_ = cs_ is CqlDateTime;
            if (ct_)
            {
                DataType? cu_ = tuple_cadhcldckpqwmtcazwxfnkhgc?.AnesthesiaProcedure?.Performed;
                object? cv_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cu_);
                ak_ = cv_ as CqlDateTime;
            }
            else
            {
                DataType? cw_ = tuple_cadhcldckpqwmtcazwxfnkhgc?.AnesthesiaProcedure?.Performed;
                object? cx_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cw_);
                bool cy_ = cx_ is CqlQuantity;
                if (cy_)
                {
                    DataType? cz_ = tuple_cadhcldckpqwmtcazwxfnkhgc?.AnesthesiaProcedure?.Performed;
                    object? da_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cz_);
                    ak_ = da_ as CqlQuantity;
                }
                else
                {
                    DataType? db_ = tuple_cadhcldckpqwmtcazwxfnkhgc?.AnesthesiaProcedure?.Performed;
                    object? dc_ = FHIRHelpers_4_4_000.Instance.ToValue(context, db_);
                    bool dd_ = dc_ is CqlInterval<CqlDateTime>;
                    if (dd_)
                    {
                        DataType? de_ = tuple_cadhcldckpqwmtcazwxfnkhgc?.AnesthesiaProcedure?.Performed;
                        object? df_ = FHIRHelpers_4_4_000.Instance.ToValue(context, de_);
                        ak_ = df_ as CqlInterval<CqlDateTime?>;
                    }
                    else
                    {
                        DataType? dg_ = tuple_cadhcldckpqwmtcazwxfnkhgc?.AnesthesiaProcedure?.Performed;
                        object? dh_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dg_);
                        bool di_ = dh_ is CqlInterval<CqlQuantity>;
                        if (di_)
                        {
                            DataType? dj_ = tuple_cadhcldckpqwmtcazwxfnkhgc?.AnesthesiaProcedure?.Performed;
                            object? dk_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dj_);
                            ak_ = dk_ as CqlInterval<CqlQuantity?>;
                        }
                        else
                        {
                            ak_ = null;
                        }
                    }
                }
            }
            CqlInterval<CqlDateTime?>? al_ = QICoreCommon_4_0_000.Instance.toInterval(context, ak_);
            CqlDateTime? am_ = context.Operators.End(al_);
            CqlInterval<CqlDate?>? an_ = TJCOverall_8_25_000.Instance.calendarDayOfOrDayAfter(context, am_);
            CqlDate? ao_ = an_?.high;
            CqlDateTime? ap_ = context.Operators.ConvertDateToDateTime(ao_);
            object? aq_;
            DataType? dl_ = tuple_cadhcldckpqwmtcazwxfnkhgc?.AnesthesiaProcedure?.Performed;
            object? dm_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dl_);
            bool dn_ = dm_ is CqlDateTime;
            if (dn_)
            {
                DataType? do_ = tuple_cadhcldckpqwmtcazwxfnkhgc?.AnesthesiaProcedure?.Performed;
                object? dp_ = FHIRHelpers_4_4_000.Instance.ToValue(context, do_);
                aq_ = dp_ as CqlDateTime;
            }
            else
            {
                DataType? dq_ = tuple_cadhcldckpqwmtcazwxfnkhgc?.AnesthesiaProcedure?.Performed;
                object? dr_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dq_);
                bool ds_ = dr_ is CqlQuantity;
                if (ds_)
                {
                    DataType? dt_ = tuple_cadhcldckpqwmtcazwxfnkhgc?.AnesthesiaProcedure?.Performed;
                    object? du_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dt_);
                    aq_ = du_ as CqlQuantity;
                }
                else
                {
                    DataType? dv_ = tuple_cadhcldckpqwmtcazwxfnkhgc?.AnesthesiaProcedure?.Performed;
                    object? dw_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dv_);
                    bool dx_ = dw_ is CqlInterval<CqlDateTime>;
                    if (dx_)
                    {
                        DataType? dy_ = tuple_cadhcldckpqwmtcazwxfnkhgc?.AnesthesiaProcedure?.Performed;
                        object? dz_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dy_);
                        aq_ = dz_ as CqlInterval<CqlDateTime?>;
                    }
                    else
                    {
                        DataType? ea_ = tuple_cadhcldckpqwmtcazwxfnkhgc?.AnesthesiaProcedure?.Performed;
                        object? eb_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ea_);
                        bool ec_ = eb_ is CqlInterval<CqlQuantity>;
                        if (ec_)
                        {
                            DataType? ed_ = tuple_cadhcldckpqwmtcazwxfnkhgc?.AnesthesiaProcedure?.Performed;
                            object? ee_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ed_);
                            aq_ = ee_ as CqlInterval<CqlQuantity?>;
                        }
                        else
                        {
                            aq_ = null;
                        }
                    }
                }
            }
            CqlInterval<CqlDateTime?>? ar_ = QICoreCommon_4_0_000.Instance.toInterval(context, aq_);
            CqlDateTime? as_ = context.Operators.End(ar_);
            CqlInterval<CqlDate?>? at_ = TJCOverall_8_25_000.Instance.calendarDayOfOrDayAfter(context, as_);
            bool? au_ = at_?.lowClosed;
            object? av_;
            DataType? ef_ = tuple_cadhcldckpqwmtcazwxfnkhgc?.AnesthesiaProcedure?.Performed;
            object? eg_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ef_);
            bool eh_ = eg_ is CqlDateTime;
            if (eh_)
            {
                DataType? ei_ = tuple_cadhcldckpqwmtcazwxfnkhgc?.AnesthesiaProcedure?.Performed;
                object? ej_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ei_);
                av_ = ej_ as CqlDateTime;
            }
            else
            {
                DataType? ek_ = tuple_cadhcldckpqwmtcazwxfnkhgc?.AnesthesiaProcedure?.Performed;
                object? el_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ek_);
                bool em_ = el_ is CqlQuantity;
                if (em_)
                {
                    DataType? en_ = tuple_cadhcldckpqwmtcazwxfnkhgc?.AnesthesiaProcedure?.Performed;
                    object? eo_ = FHIRHelpers_4_4_000.Instance.ToValue(context, en_);
                    av_ = eo_ as CqlQuantity;
                }
                else
                {
                    DataType? ep_ = tuple_cadhcldckpqwmtcazwxfnkhgc?.AnesthesiaProcedure?.Performed;
                    object? eq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ep_);
                    bool er_ = eq_ is CqlInterval<CqlDateTime>;
                    if (er_)
                    {
                        DataType? es_ = tuple_cadhcldckpqwmtcazwxfnkhgc?.AnesthesiaProcedure?.Performed;
                        object? et_ = FHIRHelpers_4_4_000.Instance.ToValue(context, es_);
                        av_ = et_ as CqlInterval<CqlDateTime?>;
                    }
                    else
                    {
                        DataType? eu_ = tuple_cadhcldckpqwmtcazwxfnkhgc?.AnesthesiaProcedure?.Performed;
                        object? ev_ = FHIRHelpers_4_4_000.Instance.ToValue(context, eu_);
                        bool ew_ = ev_ is CqlInterval<CqlQuantity>;
                        if (ew_)
                        {
                            DataType? ex_ = tuple_cadhcldckpqwmtcazwxfnkhgc?.AnesthesiaProcedure?.Performed;
                            object? ey_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ex_);
                            av_ = ey_ as CqlInterval<CqlQuantity?>;
                        }
                        else
                        {
                            av_ = null;
                        }
                    }
                }
            }
            CqlInterval<CqlDateTime?>? aw_ = QICoreCommon_4_0_000.Instance.toInterval(context, av_);
            CqlDateTime? ax_ = context.Operators.End(aw_);
            CqlInterval<CqlDate?>? ay_ = TJCOverall_8_25_000.Instance.calendarDayOfOrDayAfter(context, ax_);
            bool? az_ = ay_?.highClosed;
            CqlInterval<CqlDateTime?>? ba_ = context.Operators.Interval(aj_, ap_, au_, az_);
            bool? bb_ = context.Operators.In<CqlDateTime?>(ad_, ba_, "day");
            bool? bc_ = context.Operators.And(ac_, bb_);
            return bc_;
        }

        IEnumerable<(CqlTupleMetadata, Encounter? QualifyingEncounter, Procedure? AnesthesiaProcedure, (CqlTupleMetadata, string? id, CqlConcept? requestStatusReason, CqlDateTime? authoredOn)? NoVTEDevice)?>? h_ = context.Operators.SelectWhere<ValueTuple<Encounter?, Procedure?, (CqlTupleMetadata, string? id, CqlConcept? requestStatusReason, CqlDateTime? authoredOn)?>, (CqlTupleMetadata, Encounter? QualifyingEncounter, Procedure? AnesthesiaProcedure, (CqlTupleMetadata, string? id, CqlConcept? requestStatusReason, CqlDateTime? authoredOn)? NoVTEDevice)?>(e_, f_, g_);
        Encounter? i_((CqlTupleMetadata, Encounter? QualifyingEncounter, Procedure? AnesthesiaProcedure, (CqlTupleMetadata, string? id, CqlConcept? requestStatusReason, CqlDateTime? authoredOn)? NoVTEDevice)? tuple_cadhcldckpqwmtcazwxfnkhgc) => tuple_cadhcldckpqwmtcazwxfnkhgc?.QualifyingEncounter;
        IEnumerable<Encounter?>? j_ = context.Operators.SelectDistinct<(CqlTupleMetadata, Encounter? QualifyingEncounter, Procedure? AnesthesiaProcedure, (CqlTupleMetadata, string? id, CqlConcept? requestStatusReason, CqlDateTime? authoredOn)? NoVTEDevice)?, Encounter?>(h_, i_);
        return j_;
    }


    [CqlExpressionDefinition("Encounter With No VTE Prophylaxis Due To Medical Reason")]
    public IEnumerable<Encounter?>? Encounter_With_No_VTE_Prophylaxis_Due_To_Medical_Reason(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Encounter_With_No_VTE_Prophylaxis_Due_To_Medical_Reason, Encounter_With_No_VTE_Prophylaxis_Due_To_Medical_Reason_Compute);

    private const long _cacheIndex_Encounter_With_No_VTE_Prophylaxis_Due_To_Medical_Reason = 5299751816536655779L;

    private IEnumerable<Encounter?>? Encounter_With_No_VTE_Prophylaxis_Due_To_Medical_Reason_Compute(CqlContext context)
    {
        IEnumerable<Encounter?>? a_ = this.No_VTE_Prophylaxis_Medication_Due_To_Medical_Reason_From_Day_Of_Start_Of_Hospitalization_To_Day_After_Admission(context);
        IEnumerable<Encounter?>? b_ = this.No_Mechanical_VTE_Prophylaxis_Due_To_Medical_Reason_From_Day_Of_Start_Of_Hospitalization_To_Day_After_Admission(context);
        IEnumerable<Encounter?>? c_ = context.Operators.Intersect<Encounter?>(a_, b_);
        IEnumerable<Encounter?>? d_ = this.No_VTE_Prophylaxis_Medication_Due_To_Medical_Reason_On_Day_Of_Or_Day_After_Procedure(context);
        IEnumerable<Encounter?>? e_ = this.No_Mechanical_VTE_Prophylaxis_Due_To_Medical_Reason_On_Day_Of_Or_Day_After_Procedure(context);
        IEnumerable<Encounter?>? f_ = context.Operators.Intersect<Encounter?>(d_, e_);
        IEnumerable<Encounter?>? g_ = context.Operators.Union<Encounter?>(c_, f_);
        return g_;
    }


    [CqlExpressionDefinition("No Mechanical Or Pharmacological VTE Prophylaxis Due To Patient Refusal")]
    public IEnumerable<object?>? No_Mechanical_Or_Pharmacological_VTE_Prophylaxis_Due_To_Patient_Refusal(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_No_Mechanical_Or_Pharmacological_VTE_Prophylaxis_Due_To_Patient_Refusal, No_Mechanical_Or_Pharmacological_VTE_Prophylaxis_Due_To_Patient_Refusal_Compute);

    private const long _cacheIndex_No_Mechanical_Or_Pharmacological_VTE_Prophylaxis_Due_To_Patient_Refusal = -1208625367494253294L;

    private IEnumerable<object?>? No_Mechanical_Or_Pharmacological_VTE_Prophylaxis_Due_To_Patient_Refusal_Compute(CqlContext context)
    {
        IEnumerable<(CqlTupleMetadata, string? id, IEnumerable<CqlConcept?>? medicationStatusReason, CqlDateTime? authoredOn)?>? a_ = this.No_VTE_Prophylaxis_Medication_Administered_Or_Ordered(context);

        bool? b_((CqlTupleMetadata, string? id, IEnumerable<CqlConcept?>? medicationStatusReason, CqlDateTime? authoredOn)? NoVTEMedication) {
            IEnumerable<CqlConcept>? j_ = NoVTEMedication?.medicationStatusReason;

            bool? k_(CqlConcept? MedRsn) {
                CqlValueSet? m_ = this.Patient_Refusal(context);
                bool? n_ = context.Operators.ConceptInValueSet(MedRsn, m_);
                return n_;
            }

            bool? l_ = context.Operators.WhereAny<CqlConcept?>(j_, k_);
            return l_;
        }

        object c_((CqlTupleMetadata, string? id, IEnumerable<CqlConcept?>? medicationStatusReason, CqlDateTime? authoredOn)? tuple_eodcxckcyhgehinqchjlrjuqw) => tuple_eodcxckcyhgehinqchjlrjuqw!;
        IEnumerable<object?>? d_ = context.Operators.WhereSelect<(CqlTupleMetadata, string? id, IEnumerable<CqlConcept?>? medicationStatusReason, CqlDateTime? authoredOn)?, object?>(a_, b_, c_);
        IEnumerable<(CqlTupleMetadata, string? id, CqlConcept? requestStatusReason, CqlDateTime? authoredOn)?>? e_ = this.No_Mechanical_VTE_Prophylaxis_Performed_Or_Ordered(context);

        bool? f_((CqlTupleMetadata, string? id, CqlConcept? requestStatusReason, CqlDateTime? authoredOn)? NoVTEDevice) {
            CqlConcept? o_ = NoVTEDevice?.requestStatusReason;
            CqlValueSet? p_ = this.Patient_Refusal(context);
            bool? q_ = context.Operators.ConceptInValueSet(o_, p_);
            return q_;
        }

        object g_((CqlTupleMetadata, string? id, CqlConcept? requestStatusReason, CqlDateTime? authoredOn)? tuple_dahzgfwmlihdcaesamjofzbqi) => tuple_dahzgfwmlihdcaesamjofzbqi!;
        IEnumerable<object?>? h_ = context.Operators.WhereSelect<(CqlTupleMetadata, string? id, CqlConcept? requestStatusReason, CqlDateTime? authoredOn)?, object?>(e_, f_, g_);
        IEnumerable<object?>? i_ = context.Operators.Union<object?>(d_, h_);
        return i_;
    }


    [CqlExpressionDefinition("No VTE Prophylaxis Due To Patient Refusal From Day Of Start Of Hospitalization To Day After Admission")]
    public IEnumerable<Encounter?>? No_VTE_Prophylaxis_Due_To_Patient_Refusal_From_Day_Of_Start_Of_Hospitalization_To_Day_After_Admission(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_No_VTE_Prophylaxis_Due_To_Patient_Refusal_From_Day_Of_Start_Of_Hospitalization_To_Day_After_Admission, No_VTE_Prophylaxis_Due_To_Patient_Refusal_From_Day_Of_Start_Of_Hospitalization_To_Day_After_Admission_Compute);

    private const long _cacheIndex_No_VTE_Prophylaxis_Due_To_Patient_Refusal_From_Day_Of_Start_Of_Hospitalization_To_Day_After_Admission = -971453516603949919L;

    private IEnumerable<Encounter?>? No_VTE_Prophylaxis_Due_To_Patient_Refusal_From_Day_Of_Start_Of_Hospitalization_To_Day_After_Admission_Compute(CqlContext context)
    {
        IEnumerable<Encounter?>? a_ = VTE_8_18_000.Instance.Encounter_With_Age_Range_And_Without_VTE_Diagnosis_Or_Obstetrical_Conditions(context);

        bool? b_(Encounter? QualifyingEncounter) {
            IEnumerable<object?>? d_ = this.No_Mechanical_Or_Pharmacological_VTE_Prophylaxis_Due_To_Patient_Refusal(context);

            bool? e_(object? PatientRefusal) {
                CqlDateTime? g_ = context.Operators.LateBoundProperty<CqlDateTime?>(PatientRefusal, "authoredOn");
                CqlInterval<CqlDate?>? h_ = this.fromDayOfStartOfHospitalizationToDayAfterAdmission(context, QualifyingEncounter);
                CqlDate? i_ = h_?.low;
                CqlDateTime? j_ = context.Operators.ConvertDateToDateTime(i_);
                CqlDate? k_ = h_?.high;
                CqlDateTime? l_ = context.Operators.ConvertDateToDateTime(k_);
                bool? m_ = h_?.lowClosed;
                bool? n_ = h_?.highClosed;
                CqlInterval<CqlDateTime?>? o_ = context.Operators.Interval(j_, l_, m_, n_);
                bool? p_ = context.Operators.In<CqlDateTime?>(g_, o_, "day");
                return p_;
            }

            bool? f_ = context.Operators.WhereAny<object?>(d_, e_);
            return f_;
        }

        IEnumerable<Encounter?>? c_ = context.Operators.Where<Encounter?>(a_, b_);
        return c_;
    }


    [CqlExpressionDefinition("No VTE Prophylaxis Due To Patient Refusal On Day Of Or Day After Procedure")]
    public IEnumerable<Encounter?>? No_VTE_Prophylaxis_Due_To_Patient_Refusal_On_Day_Of_Or_Day_After_Procedure(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_No_VTE_Prophylaxis_Due_To_Patient_Refusal_On_Day_Of_Or_Day_After_Procedure, No_VTE_Prophylaxis_Due_To_Patient_Refusal_On_Day_Of_Or_Day_After_Procedure_Compute);

    private const long _cacheIndex_No_VTE_Prophylaxis_Due_To_Patient_Refusal_On_Day_Of_Or_Day_After_Procedure = 98430516828796694L;

    private IEnumerable<Encounter?>? No_VTE_Prophylaxis_Due_To_Patient_Refusal_On_Day_Of_Or_Day_After_Procedure_Compute(CqlContext context)
    {
        IEnumerable<Encounter?>? a_ = VTE_8_18_000.Instance.Encounter_With_Age_Range_And_Without_VTE_Diagnosis_Or_Obstetrical_Conditions(context);
        CqlValueSet? b_ = this.General_or_Neuraxial_Anesthesia(context);
        IEnumerable<Procedure?>? c_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, b_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
        IEnumerable<object?>? d_ = this.No_Mechanical_Or_Pharmacological_VTE_Prophylaxis_Due_To_Patient_Refusal(context);
        IEnumerable<ValueTuple<Encounter?, Procedure?, object?>>? e_ = context.Operators.CrossJoin<Encounter?, Procedure?, object?>(a_, c_, d_);

        (CqlTupleMetadata, Encounter? QualifyingEncounter, Procedure? AnesthesiaProcedure, object? PatientRefusal)? f_(ValueTuple<Encounter?, Procedure?, object?> _valueTuple) {
            (CqlTupleMetadata, Encounter? QualifyingEncounter, Procedure? AnesthesiaProcedure, object? PatientRefusal)? k_ = (CqlTupleMetadata_EPgUKHFGKDiGHBcZKVcEFWgbe, _valueTuple.Item1, _valueTuple.Item2, _valueTuple.Item3);
            return k_;
        }


        bool? g_((CqlTupleMetadata, Encounter? QualifyingEncounter, Procedure? AnesthesiaProcedure, object? PatientRefusal)? tuple_fpeghttqsjgusnbabduddbjbh) {
            Code<EventStatus>? l_ = tuple_fpeghttqsjgusnbabduddbjbh?.AnesthesiaProcedure?.StatusElement;
            EventStatus? m_ = l_?.Value;
            string? n_ = context.Operators.Convert<string?>(m_);
            bool? o_ = context.Operators.Equal(n_, "completed");
            object? p_;
            DataType? az_ = tuple_fpeghttqsjgusnbabduddbjbh?.AnesthesiaProcedure?.Performed;
            object? ba_ = FHIRHelpers_4_4_000.Instance.ToValue(context, az_);
            bool bb_ = ba_ is CqlDateTime;
            if (bb_)
            {
                DataType? bc_ = tuple_fpeghttqsjgusnbabduddbjbh?.AnesthesiaProcedure?.Performed;
                object? bd_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bc_);
                p_ = bd_ as CqlDateTime;
            }
            else
            {
                DataType? be_ = tuple_fpeghttqsjgusnbabduddbjbh?.AnesthesiaProcedure?.Performed;
                object? bf_ = FHIRHelpers_4_4_000.Instance.ToValue(context, be_);
                bool bg_ = bf_ is CqlQuantity;
                if (bg_)
                {
                    DataType? bh_ = tuple_fpeghttqsjgusnbabduddbjbh?.AnesthesiaProcedure?.Performed;
                    object? bi_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bh_);
                    p_ = bi_ as CqlQuantity;
                }
                else
                {
                    DataType? bj_ = tuple_fpeghttqsjgusnbabduddbjbh?.AnesthesiaProcedure?.Performed;
                    object? bk_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bj_);
                    bool bl_ = bk_ is CqlInterval<CqlDateTime>;
                    if (bl_)
                    {
                        DataType? bm_ = tuple_fpeghttqsjgusnbabduddbjbh?.AnesthesiaProcedure?.Performed;
                        object? bn_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bm_);
                        p_ = bn_ as CqlInterval<CqlDateTime?>;
                    }
                    else
                    {
                        DataType? bo_ = tuple_fpeghttqsjgusnbabduddbjbh?.AnesthesiaProcedure?.Performed;
                        object? bp_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bo_);
                        bool bq_ = bp_ is CqlInterval<CqlQuantity>;
                        if (bq_)
                        {
                            DataType? br_ = tuple_fpeghttqsjgusnbabduddbjbh?.AnesthesiaProcedure?.Performed;
                            object? bs_ = FHIRHelpers_4_4_000.Instance.ToValue(context, br_);
                            p_ = bs_ as CqlInterval<CqlQuantity?>;
                        }
                        else
                        {
                            p_ = null;
                        }
                    }
                }
            }
            CqlInterval<CqlDateTime?>? q_ = QICoreCommon_4_0_000.Instance.toInterval(context, p_);
            CqlDateTime? r_ = context.Operators.End(q_);
            Period? s_ = tuple_fpeghttqsjgusnbabduddbjbh?.QualifyingEncounter?.Period;
            CqlInterval<CqlDateTime?>? t_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, s_);
            CqlDateTime? u_ = context.Operators.Start(t_);
            CqlQuantity? v_ = context.Operators.Quantity(1m, "day");
            CqlDateTime? w_ = context.Operators.Add(u_, v_);
            bool? x_ = context.Operators.SameAs(r_, w_, "day");
            bool? y_ = context.Operators.And(o_, x_);
            CqlDateTime? z_ = context.Operators.LateBoundProperty<CqlDateTime?>(tuple_fpeghttqsjgusnbabduddbjbh?.PatientRefusal, "authoredOn");
            object? aa_;
            DataType? bt_ = tuple_fpeghttqsjgusnbabduddbjbh?.AnesthesiaProcedure?.Performed;
            object? bu_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bt_);
            bool bv_ = bu_ is CqlDateTime;
            if (bv_)
            {
                DataType? bw_ = tuple_fpeghttqsjgusnbabduddbjbh?.AnesthesiaProcedure?.Performed;
                object? bx_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bw_);
                aa_ = bx_ as CqlDateTime;
            }
            else
            {
                DataType? by_ = tuple_fpeghttqsjgusnbabduddbjbh?.AnesthesiaProcedure?.Performed;
                object? bz_ = FHIRHelpers_4_4_000.Instance.ToValue(context, by_);
                bool ca_ = bz_ is CqlQuantity;
                if (ca_)
                {
                    DataType? cb_ = tuple_fpeghttqsjgusnbabduddbjbh?.AnesthesiaProcedure?.Performed;
                    object? cc_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cb_);
                    aa_ = cc_ as CqlQuantity;
                }
                else
                {
                    DataType? cd_ = tuple_fpeghttqsjgusnbabduddbjbh?.AnesthesiaProcedure?.Performed;
                    object? ce_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cd_);
                    bool cf_ = ce_ is CqlInterval<CqlDateTime>;
                    if (cf_)
                    {
                        DataType? cg_ = tuple_fpeghttqsjgusnbabduddbjbh?.AnesthesiaProcedure?.Performed;
                        object? ch_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cg_);
                        aa_ = ch_ as CqlInterval<CqlDateTime?>;
                    }
                    else
                    {
                        DataType? ci_ = tuple_fpeghttqsjgusnbabduddbjbh?.AnesthesiaProcedure?.Performed;
                        object? cj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ci_);
                        bool ck_ = cj_ is CqlInterval<CqlQuantity>;
                        if (ck_)
                        {
                            DataType? cl_ = tuple_fpeghttqsjgusnbabduddbjbh?.AnesthesiaProcedure?.Performed;
                            object? cm_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cl_);
                            aa_ = cm_ as CqlInterval<CqlQuantity?>;
                        }
                        else
                        {
                            aa_ = null;
                        }
                    }
                }
            }
            CqlInterval<CqlDateTime?>? ab_ = QICoreCommon_4_0_000.Instance.toInterval(context, aa_);
            CqlDateTime? ac_ = context.Operators.End(ab_);
            CqlInterval<CqlDate?>? ad_ = TJCOverall_8_25_000.Instance.calendarDayOfOrDayAfter(context, ac_);
            CqlDate? ae_ = ad_?.low;
            CqlDateTime? af_ = context.Operators.ConvertDateToDateTime(ae_);
            object? ag_;
            DataType? cn_ = tuple_fpeghttqsjgusnbabduddbjbh?.AnesthesiaProcedure?.Performed;
            object? co_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cn_);
            bool cp_ = co_ is CqlDateTime;
            if (cp_)
            {
                DataType? cq_ = tuple_fpeghttqsjgusnbabduddbjbh?.AnesthesiaProcedure?.Performed;
                object? cr_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cq_);
                ag_ = cr_ as CqlDateTime;
            }
            else
            {
                DataType? cs_ = tuple_fpeghttqsjgusnbabduddbjbh?.AnesthesiaProcedure?.Performed;
                object? ct_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cs_);
                bool cu_ = ct_ is CqlQuantity;
                if (cu_)
                {
                    DataType? cv_ = tuple_fpeghttqsjgusnbabduddbjbh?.AnesthesiaProcedure?.Performed;
                    object? cw_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cv_);
                    ag_ = cw_ as CqlQuantity;
                }
                else
                {
                    DataType? cx_ = tuple_fpeghttqsjgusnbabduddbjbh?.AnesthesiaProcedure?.Performed;
                    object? cy_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cx_);
                    bool cz_ = cy_ is CqlInterval<CqlDateTime>;
                    if (cz_)
                    {
                        DataType? da_ = tuple_fpeghttqsjgusnbabduddbjbh?.AnesthesiaProcedure?.Performed;
                        object? db_ = FHIRHelpers_4_4_000.Instance.ToValue(context, da_);
                        ag_ = db_ as CqlInterval<CqlDateTime?>;
                    }
                    else
                    {
                        DataType? dc_ = tuple_fpeghttqsjgusnbabduddbjbh?.AnesthesiaProcedure?.Performed;
                        object? dd_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dc_);
                        bool de_ = dd_ is CqlInterval<CqlQuantity>;
                        if (de_)
                        {
                            DataType? df_ = tuple_fpeghttqsjgusnbabduddbjbh?.AnesthesiaProcedure?.Performed;
                            object? dg_ = FHIRHelpers_4_4_000.Instance.ToValue(context, df_);
                            ag_ = dg_ as CqlInterval<CqlQuantity?>;
                        }
                        else
                        {
                            ag_ = null;
                        }
                    }
                }
            }
            CqlInterval<CqlDateTime?>? ah_ = QICoreCommon_4_0_000.Instance.toInterval(context, ag_);
            CqlDateTime? ai_ = context.Operators.End(ah_);
            CqlInterval<CqlDate?>? aj_ = TJCOverall_8_25_000.Instance.calendarDayOfOrDayAfter(context, ai_);
            CqlDate? ak_ = aj_?.high;
            CqlDateTime? al_ = context.Operators.ConvertDateToDateTime(ak_);
            object? am_;
            DataType? dh_ = tuple_fpeghttqsjgusnbabduddbjbh?.AnesthesiaProcedure?.Performed;
            object? di_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dh_);
            bool dj_ = di_ is CqlDateTime;
            if (dj_)
            {
                DataType? dk_ = tuple_fpeghttqsjgusnbabduddbjbh?.AnesthesiaProcedure?.Performed;
                object? dl_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dk_);
                am_ = dl_ as CqlDateTime;
            }
            else
            {
                DataType? dm_ = tuple_fpeghttqsjgusnbabduddbjbh?.AnesthesiaProcedure?.Performed;
                object? dn_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dm_);
                bool do_ = dn_ is CqlQuantity;
                if (do_)
                {
                    DataType? dp_ = tuple_fpeghttqsjgusnbabduddbjbh?.AnesthesiaProcedure?.Performed;
                    object? dq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dp_);
                    am_ = dq_ as CqlQuantity;
                }
                else
                {
                    DataType? dr_ = tuple_fpeghttqsjgusnbabduddbjbh?.AnesthesiaProcedure?.Performed;
                    object? ds_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dr_);
                    bool dt_ = ds_ is CqlInterval<CqlDateTime>;
                    if (dt_)
                    {
                        DataType? du_ = tuple_fpeghttqsjgusnbabduddbjbh?.AnesthesiaProcedure?.Performed;
                        object? dv_ = FHIRHelpers_4_4_000.Instance.ToValue(context, du_);
                        am_ = dv_ as CqlInterval<CqlDateTime?>;
                    }
                    else
                    {
                        DataType? dw_ = tuple_fpeghttqsjgusnbabduddbjbh?.AnesthesiaProcedure?.Performed;
                        object? dx_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dw_);
                        bool dy_ = dx_ is CqlInterval<CqlQuantity>;
                        if (dy_)
                        {
                            DataType? dz_ = tuple_fpeghttqsjgusnbabduddbjbh?.AnesthesiaProcedure?.Performed;
                            object? ea_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dz_);
                            am_ = ea_ as CqlInterval<CqlQuantity?>;
                        }
                        else
                        {
                            am_ = null;
                        }
                    }
                }
            }
            CqlInterval<CqlDateTime?>? an_ = QICoreCommon_4_0_000.Instance.toInterval(context, am_);
            CqlDateTime? ao_ = context.Operators.End(an_);
            CqlInterval<CqlDate?>? ap_ = TJCOverall_8_25_000.Instance.calendarDayOfOrDayAfter(context, ao_);
            bool? aq_ = ap_?.lowClosed;
            object? ar_;
            DataType? eb_ = tuple_fpeghttqsjgusnbabduddbjbh?.AnesthesiaProcedure?.Performed;
            object? ec_ = FHIRHelpers_4_4_000.Instance.ToValue(context, eb_);
            bool ed_ = ec_ is CqlDateTime;
            if (ed_)
            {
                DataType? ee_ = tuple_fpeghttqsjgusnbabduddbjbh?.AnesthesiaProcedure?.Performed;
                object? ef_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ee_);
                ar_ = ef_ as CqlDateTime;
            }
            else
            {
                DataType? eg_ = tuple_fpeghttqsjgusnbabduddbjbh?.AnesthesiaProcedure?.Performed;
                object? eh_ = FHIRHelpers_4_4_000.Instance.ToValue(context, eg_);
                bool ei_ = eh_ is CqlQuantity;
                if (ei_)
                {
                    DataType? ej_ = tuple_fpeghttqsjgusnbabduddbjbh?.AnesthesiaProcedure?.Performed;
                    object? ek_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ej_);
                    ar_ = ek_ as CqlQuantity;
                }
                else
                {
                    DataType? el_ = tuple_fpeghttqsjgusnbabduddbjbh?.AnesthesiaProcedure?.Performed;
                    object? em_ = FHIRHelpers_4_4_000.Instance.ToValue(context, el_);
                    bool en_ = em_ is CqlInterval<CqlDateTime>;
                    if (en_)
                    {
                        DataType? eo_ = tuple_fpeghttqsjgusnbabduddbjbh?.AnesthesiaProcedure?.Performed;
                        object? ep_ = FHIRHelpers_4_4_000.Instance.ToValue(context, eo_);
                        ar_ = ep_ as CqlInterval<CqlDateTime?>;
                    }
                    else
                    {
                        DataType? eq_ = tuple_fpeghttqsjgusnbabduddbjbh?.AnesthesiaProcedure?.Performed;
                        object? er_ = FHIRHelpers_4_4_000.Instance.ToValue(context, eq_);
                        bool es_ = er_ is CqlInterval<CqlQuantity>;
                        if (es_)
                        {
                            DataType? et_ = tuple_fpeghttqsjgusnbabduddbjbh?.AnesthesiaProcedure?.Performed;
                            object? eu_ = FHIRHelpers_4_4_000.Instance.ToValue(context, et_);
                            ar_ = eu_ as CqlInterval<CqlQuantity?>;
                        }
                        else
                        {
                            ar_ = null;
                        }
                    }
                }
            }
            CqlInterval<CqlDateTime?>? as_ = QICoreCommon_4_0_000.Instance.toInterval(context, ar_);
            CqlDateTime? at_ = context.Operators.End(as_);
            CqlInterval<CqlDate?>? au_ = TJCOverall_8_25_000.Instance.calendarDayOfOrDayAfter(context, at_);
            bool? av_ = au_?.highClosed;
            CqlInterval<CqlDateTime?>? aw_ = context.Operators.Interval(af_, al_, aq_, av_);
            bool? ax_ = context.Operators.In<CqlDateTime?>(z_, aw_, "day");
            bool? ay_ = context.Operators.And(y_, ax_);
            return ay_;
        }

        IEnumerable<(CqlTupleMetadata, Encounter? QualifyingEncounter, Procedure? AnesthesiaProcedure, object? PatientRefusal)?>? h_ = context.Operators.SelectWhere<ValueTuple<Encounter?, Procedure?, object?>, (CqlTupleMetadata, Encounter? QualifyingEncounter, Procedure? AnesthesiaProcedure, object? PatientRefusal)?>(e_, f_, g_);
        Encounter? i_((CqlTupleMetadata, Encounter? QualifyingEncounter, Procedure? AnesthesiaProcedure, object? PatientRefusal)? tuple_fpeghttqsjgusnbabduddbjbh) => tuple_fpeghttqsjgusnbabduddbjbh?.QualifyingEncounter;
        IEnumerable<Encounter?>? j_ = context.Operators.SelectDistinct<(CqlTupleMetadata, Encounter? QualifyingEncounter, Procedure? AnesthesiaProcedure, object? PatientRefusal)?, Encounter?>(h_, i_);
        return j_;
    }


    [CqlExpressionDefinition("Encounter With No VTE Prophylaxis Due To Patient Refusal")]
    public IEnumerable<Encounter?>? Encounter_With_No_VTE_Prophylaxis_Due_To_Patient_Refusal(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Encounter_With_No_VTE_Prophylaxis_Due_To_Patient_Refusal, Encounter_With_No_VTE_Prophylaxis_Due_To_Patient_Refusal_Compute);

    private const long _cacheIndex_Encounter_With_No_VTE_Prophylaxis_Due_To_Patient_Refusal = -3835470181507784630L;

    private IEnumerable<Encounter?>? Encounter_With_No_VTE_Prophylaxis_Due_To_Patient_Refusal_Compute(CqlContext context)
    {
        IEnumerable<Encounter?>? a_ = this.No_VTE_Prophylaxis_Due_To_Patient_Refusal_From_Day_Of_Start_Of_Hospitalization_To_Day_After_Admission(context);
        IEnumerable<Encounter?>? b_ = this.No_VTE_Prophylaxis_Due_To_Patient_Refusal_On_Day_Of_Or_Day_After_Procedure(context);
        IEnumerable<Encounter?>? c_ = context.Operators.Union<Encounter?>(a_, b_);
        return c_;
    }


    [CqlExpressionDefinition("Numerator")]
    public IEnumerable<Encounter?>? Numerator(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Numerator, Numerator_Compute);

    private const long _cacheIndex_Numerator = -5524035549190864910L;

    private IEnumerable<Encounter?>? Numerator_Compute(CqlContext context)
    {
        IEnumerable<Encounter?>? a_ = this.Encounter_With_VTE_Prophylaxis_Received_From_Day_Of_Start_Of_Hospitalization_To_Day_After_Admission_Or_Procedure(context);
        IEnumerable<Encounter?>? b_ = this.Encounter_With_Medication_Oral_Factor_Xa_Inhibitor_Administered_On_Day_Of_Or_Day_After_Admission_Or_Procedure(context);
        IEnumerable<Encounter?>? c_ = this.Encounter_With_Prior_Or_Present_Diagnosis_Of_Atrial_Fibrillation_Or_Prior_Diagnosis_Of_VTE(context);
        IEnumerable<Encounter?>? d_ = this.Encounter_With_Prior_Or_Present_Procedure_Of_Hip_Or_Knee_Replacement_Surgery(context);
        IEnumerable<Encounter?>? e_ = context.Operators.Union<Encounter?>(c_, d_);
        IEnumerable<Encounter?>? f_ = context.Operators.Intersect<Encounter?>(b_, e_);
        IEnumerable<Encounter?>? g_ = context.Operators.Union<Encounter?>(a_, f_);
        IEnumerable<Encounter?>? h_ = this.Encounter_With_Low_Risk_For_VTE_Or_Anticoagulant_Administered(context);
        IEnumerable<Encounter?>? i_ = this.Encounter_With_No_VTE_Prophylaxis_Due_To_Medical_Reason(context);
        IEnumerable<Encounter?>? j_ = context.Operators.Union<Encounter?>(h_, i_);
        IEnumerable<Encounter?>? k_ = context.Operators.Union<Encounter?>(g_, j_);
        IEnumerable<Encounter?>? l_ = this.Encounter_With_No_VTE_Prophylaxis_Due_To_Patient_Refusal(context);
        IEnumerable<Encounter?>? m_ = context.Operators.Union<Encounter?>(k_, l_);
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

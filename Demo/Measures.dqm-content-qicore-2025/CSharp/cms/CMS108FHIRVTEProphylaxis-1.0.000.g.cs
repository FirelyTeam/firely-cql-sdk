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

[System.CodeDom.Compiler.GeneratedCode(".NET Code Generation", "5.1.5.0")]
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
                    CqlConcept ad_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);
                    return ad_;
                }

                IEnumerable<CqlConcept> l_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)j_, k_);
                CqlValueSet m_ = this.Intensive_Care_Unit(context);
                bool? n_ = context.Operators.ConceptsInValueSet(l_, m_);
                Period o_ = Location?.Period;
                CqlInterval<CqlDateTime> p_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, o_);
                int? q_ = CQMCommon_4_1_000.Instance.lengthInDays(context, p_);
                bool? r_ = context.Operators.GreaterOrEqual(q_, 1);
                bool? s_ = context.Operators.And(n_, r_);
                CqlDateTime t_ = context.Operators.Start(p_);
                Period u_ = QualifyingEncounter?.Period;
                CqlInterval<CqlDateTime> v_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, u_);
                CqlDateTime w_ = context.Operators.Start(v_);
                bool? x_ = context.Operators.SameOrAfter(t_, w_, (string)default);
                bool? y_ = context.Operators.And(s_, x_);
                CqlDate z_ = context.Operators.DateFrom(t_);
                CqlInterval<CqlDate> aa_ = TJCOverall_8_25_000.Instance.calendarDayOfOrDayAfter(context, w_);
                bool? ab_ = context.Operators.In<CqlDate>(z_, aa_, (string)default);
                bool? ac_ = context.Operators.And(y_, ab_);
                return ac_;
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
                object h_;
                object v_ = context.Operators.LateBoundProperty<object>(ComfortMeasure, "performed");
                object w_ = FHIRHelpers_4_4_000.Instance.ToValue(context, v_);
                bool x_ = w_ is CqlDateTime;
                if (x_)
                {
                    object y_ = context.Operators.LateBoundProperty<object>(ComfortMeasure, "performed");
                    object z_ = FHIRHelpers_4_4_000.Instance.ToValue(context, y_);
                    h_ = z_ as CqlDateTime;
                }
                else
                {
                    object aa_ = context.Operators.LateBoundProperty<object>(ComfortMeasure, "performed");
                    object ab_ = FHIRHelpers_4_4_000.Instance.ToValue(context, aa_);
                    bool ac_ = ab_ is CqlInterval<CqlDateTime>;
                    if (ac_)
                    {
                        object ad_ = context.Operators.LateBoundProperty<object>(ComfortMeasure, "performed");
                        object ae_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ad_);
                        h_ = ae_ as CqlInterval<CqlDateTime>;
                    }
                    else
                    {
                        object af_ = context.Operators.LateBoundProperty<object>(ComfortMeasure, "performed");
                        object ag_ = FHIRHelpers_4_4_000.Instance.ToValue(context, af_);
                        bool ah_ = ag_ is CqlQuantity;
                        if (ah_)
                        {
                            object ai_ = context.Operators.LateBoundProperty<object>(ComfortMeasure, "performed");
                            object aj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ai_);
                            h_ = aj_ as CqlQuantity;
                        }
                        else
                        {
                            object ak_ = context.Operators.LateBoundProperty<object>(ComfortMeasure, "performed");
                            object al_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ak_);
                            bool am_ = al_ is CqlInterval<CqlQuantity>;
                            if (am_)
                            {
                                object an_ = context.Operators.LateBoundProperty<object>(ComfortMeasure, "performed");
                                object ao_ = FHIRHelpers_4_4_000.Instance.ToValue(context, an_);
                                h_ = ao_ as CqlInterval<CqlQuantity>;
                            }
                            else
                            {
                                h_ = null;
                            }
                        }
                    }
                }
                CqlInterval<CqlDateTime> i_ = QICoreCommon_4_0_000.Instance.toInterval(context, h_);
                CqlDateTime j_ = context.Operators.Start(i_);
                object k_ = context.Operators.LateBoundProperty<object>(ComfortMeasure, "authoredOn");
                CqlDateTime l_ = context.Operators.LateBoundProperty<CqlDateTime>(k_, "value");
                CqlInterval<CqlDate> m_ = this.fromDayOfStartOfHospitalizationToDayAfterAdmission(context, QualifyingEncounter);
                CqlDate n_ = m_?.low;
                CqlDateTime o_ = context.Operators.ConvertDateToDateTime(n_);
                CqlDate p_ = m_?.high;
                CqlDateTime q_ = context.Operators.ConvertDateToDateTime(p_);
                bool? r_ = m_?.lowClosed;
                bool? s_ = m_?.highClosed;
                CqlInterval<CqlDateTime> t_ = context.Operators.Interval(o_, q_, r_, s_);
                bool? u_ = context.Operators.In<CqlDateTime>(j_ ?? l_, t_, "day");
                return u_;
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
            object r_;
            DataType bf_ = tuple_hbjscqgbuhismoaytymvucjfi?.AnesthesiaProcedure?.Performed;
            object bg_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bf_);
            bool bh_ = bg_ is CqlDateTime;
            if (bh_)
            {
                DataType bi_ = tuple_hbjscqgbuhismoaytymvucjfi?.AnesthesiaProcedure?.Performed;
                object bj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bi_);
                r_ = bj_ as CqlDateTime;
            }
            else
            {
                DataType bk_ = tuple_hbjscqgbuhismoaytymvucjfi?.AnesthesiaProcedure?.Performed;
                object bl_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bk_);
                bool bm_ = bl_ is CqlInterval<CqlDateTime>;
                if (bm_)
                {
                    DataType bn_ = tuple_hbjscqgbuhismoaytymvucjfi?.AnesthesiaProcedure?.Performed;
                    object bo_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bn_);
                    r_ = bo_ as CqlInterval<CqlDateTime>;
                }
                else
                {
                    DataType bp_ = tuple_hbjscqgbuhismoaytymvucjfi?.AnesthesiaProcedure?.Performed;
                    object bq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bp_);
                    bool br_ = bq_ is CqlQuantity;
                    if (br_)
                    {
                        DataType bs_ = tuple_hbjscqgbuhismoaytymvucjfi?.AnesthesiaProcedure?.Performed;
                        object bt_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bs_);
                        r_ = bt_ as CqlQuantity;
                    }
                    else
                    {
                        DataType bu_ = tuple_hbjscqgbuhismoaytymvucjfi?.AnesthesiaProcedure?.Performed;
                        object bv_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bu_);
                        bool bw_ = bv_ is CqlInterval<CqlQuantity>;
                        if (bw_)
                        {
                            DataType bx_ = tuple_hbjscqgbuhismoaytymvucjfi?.AnesthesiaProcedure?.Performed;
                            object by_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bx_);
                            r_ = by_ as CqlInterval<CqlQuantity>;
                        }
                        else
                        {
                            r_ = null;
                        }
                    }
                }
            }
            CqlInterval<CqlDateTime> s_ = QICoreCommon_4_0_000.Instance.toInterval(context, r_);
            CqlDateTime t_ = context.Operators.End(s_);
            Period u_ = tuple_hbjscqgbuhismoaytymvucjfi?.QualifyingEncounter?.Period;
            CqlInterval<CqlDateTime> v_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, u_);
            CqlDateTime w_ = context.Operators.Start(v_);
            CqlQuantity x_ = context.Operators.Quantity(1m, "day");
            CqlDateTime y_ = context.Operators.Add(w_, x_);
            bool? z_ = context.Operators.SameAs(t_, y_, "day");
            bool? aa_ = context.Operators.And(q_, z_);
            object ab_;
            object bz_ = context.Operators.LateBoundProperty<object>(tuple_hbjscqgbuhismoaytymvucjfi?.ComfortMeasure, "performed");
            object ca_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bz_);
            bool cb_ = ca_ is CqlDateTime;
            if (cb_)
            {
                object cc_ = context.Operators.LateBoundProperty<object>(tuple_hbjscqgbuhismoaytymvucjfi?.ComfortMeasure, "performed");
                object cd_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cc_);
                ab_ = cd_ as CqlDateTime;
            }
            else
            {
                object ce_ = context.Operators.LateBoundProperty<object>(tuple_hbjscqgbuhismoaytymvucjfi?.ComfortMeasure, "performed");
                object cf_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ce_);
                bool cg_ = cf_ is CqlInterval<CqlDateTime>;
                if (cg_)
                {
                    object ch_ = context.Operators.LateBoundProperty<object>(tuple_hbjscqgbuhismoaytymvucjfi?.ComfortMeasure, "performed");
                    object ci_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ch_);
                    ab_ = ci_ as CqlInterval<CqlDateTime>;
                }
                else
                {
                    object cj_ = context.Operators.LateBoundProperty<object>(tuple_hbjscqgbuhismoaytymvucjfi?.ComfortMeasure, "performed");
                    object ck_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cj_);
                    bool cl_ = ck_ is CqlQuantity;
                    if (cl_)
                    {
                        object cm_ = context.Operators.LateBoundProperty<object>(tuple_hbjscqgbuhismoaytymvucjfi?.ComfortMeasure, "performed");
                        object cn_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cm_);
                        ab_ = cn_ as CqlQuantity;
                    }
                    else
                    {
                        object co_ = context.Operators.LateBoundProperty<object>(tuple_hbjscqgbuhismoaytymvucjfi?.ComfortMeasure, "performed");
                        object cp_ = FHIRHelpers_4_4_000.Instance.ToValue(context, co_);
                        bool cq_ = cp_ is CqlInterval<CqlQuantity>;
                        if (cq_)
                        {
                            object cr_ = context.Operators.LateBoundProperty<object>(tuple_hbjscqgbuhismoaytymvucjfi?.ComfortMeasure, "performed");
                            object cs_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cr_);
                            ab_ = cs_ as CqlInterval<CqlQuantity>;
                        }
                        else
                        {
                            ab_ = null;
                        }
                    }
                }
            }
            CqlInterval<CqlDateTime> ac_ = QICoreCommon_4_0_000.Instance.toInterval(context, ab_);
            CqlDateTime ad_ = context.Operators.Start(ac_);
            object ae_ = context.Operators.LateBoundProperty<object>(tuple_hbjscqgbuhismoaytymvucjfi?.ComfortMeasure, "authoredOn");
            CqlDateTime af_ = context.Operators.LateBoundProperty<CqlDateTime>(ae_, "value");
            object ag_;
            DataType ct_ = tuple_hbjscqgbuhismoaytymvucjfi?.AnesthesiaProcedure?.Performed;
            object cu_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ct_);
            bool cv_ = cu_ is CqlDateTime;
            if (cv_)
            {
                DataType cw_ = tuple_hbjscqgbuhismoaytymvucjfi?.AnesthesiaProcedure?.Performed;
                object cx_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cw_);
                ag_ = cx_ as CqlDateTime;
            }
            else
            {
                DataType cy_ = tuple_hbjscqgbuhismoaytymvucjfi?.AnesthesiaProcedure?.Performed;
                object cz_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cy_);
                bool da_ = cz_ is CqlInterval<CqlDateTime>;
                if (da_)
                {
                    DataType db_ = tuple_hbjscqgbuhismoaytymvucjfi?.AnesthesiaProcedure?.Performed;
                    object dc_ = FHIRHelpers_4_4_000.Instance.ToValue(context, db_);
                    ag_ = dc_ as CqlInterval<CqlDateTime>;
                }
                else
                {
                    DataType dd_ = tuple_hbjscqgbuhismoaytymvucjfi?.AnesthesiaProcedure?.Performed;
                    object de_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dd_);
                    bool df_ = de_ is CqlQuantity;
                    if (df_)
                    {
                        DataType dg_ = tuple_hbjscqgbuhismoaytymvucjfi?.AnesthesiaProcedure?.Performed;
                        object dh_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dg_);
                        ag_ = dh_ as CqlQuantity;
                    }
                    else
                    {
                        DataType di_ = tuple_hbjscqgbuhismoaytymvucjfi?.AnesthesiaProcedure?.Performed;
                        object dj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, di_);
                        bool dk_ = dj_ is CqlInterval<CqlQuantity>;
                        if (dk_)
                        {
                            DataType dl_ = tuple_hbjscqgbuhismoaytymvucjfi?.AnesthesiaProcedure?.Performed;
                            object dm_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dl_);
                            ag_ = dm_ as CqlInterval<CqlQuantity>;
                        }
                        else
                        {
                            ag_ = null;
                        }
                    }
                }
            }
            CqlInterval<CqlDateTime> ah_ = QICoreCommon_4_0_000.Instance.toInterval(context, ag_);
            CqlDateTime ai_ = context.Operators.End(ah_);
            CqlInterval<CqlDate> aj_ = TJCOverall_8_25_000.Instance.calendarDayOfOrDayAfter(context, ai_);
            CqlDate ak_ = aj_?.low;
            CqlDateTime al_ = context.Operators.ConvertDateToDateTime(ak_);
            object am_;
            DataType dn_ = tuple_hbjscqgbuhismoaytymvucjfi?.AnesthesiaProcedure?.Performed;
            object do_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dn_);
            bool dp_ = do_ is CqlDateTime;
            if (dp_)
            {
                DataType dq_ = tuple_hbjscqgbuhismoaytymvucjfi?.AnesthesiaProcedure?.Performed;
                object dr_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dq_);
                am_ = dr_ as CqlDateTime;
            }
            else
            {
                DataType ds_ = tuple_hbjscqgbuhismoaytymvucjfi?.AnesthesiaProcedure?.Performed;
                object dt_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ds_);
                bool du_ = dt_ is CqlInterval<CqlDateTime>;
                if (du_)
                {
                    DataType dv_ = tuple_hbjscqgbuhismoaytymvucjfi?.AnesthesiaProcedure?.Performed;
                    object dw_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dv_);
                    am_ = dw_ as CqlInterval<CqlDateTime>;
                }
                else
                {
                    DataType dx_ = tuple_hbjscqgbuhismoaytymvucjfi?.AnesthesiaProcedure?.Performed;
                    object dy_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dx_);
                    bool dz_ = dy_ is CqlQuantity;
                    if (dz_)
                    {
                        DataType ea_ = tuple_hbjscqgbuhismoaytymvucjfi?.AnesthesiaProcedure?.Performed;
                        object eb_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ea_);
                        am_ = eb_ as CqlQuantity;
                    }
                    else
                    {
                        DataType ec_ = tuple_hbjscqgbuhismoaytymvucjfi?.AnesthesiaProcedure?.Performed;
                        object ed_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ec_);
                        bool ee_ = ed_ is CqlInterval<CqlQuantity>;
                        if (ee_)
                        {
                            DataType ef_ = tuple_hbjscqgbuhismoaytymvucjfi?.AnesthesiaProcedure?.Performed;
                            object eg_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ef_);
                            am_ = eg_ as CqlInterval<CqlQuantity>;
                        }
                        else
                        {
                            am_ = null;
                        }
                    }
                }
            }
            CqlInterval<CqlDateTime> an_ = QICoreCommon_4_0_000.Instance.toInterval(context, am_);
            CqlDateTime ao_ = context.Operators.End(an_);
            CqlInterval<CqlDate> ap_ = TJCOverall_8_25_000.Instance.calendarDayOfOrDayAfter(context, ao_);
            CqlDate aq_ = ap_?.high;
            CqlDateTime ar_ = context.Operators.ConvertDateToDateTime(aq_);
            object as_;
            DataType eh_ = tuple_hbjscqgbuhismoaytymvucjfi?.AnesthesiaProcedure?.Performed;
            object ei_ = FHIRHelpers_4_4_000.Instance.ToValue(context, eh_);
            bool ej_ = ei_ is CqlDateTime;
            if (ej_)
            {
                DataType ek_ = tuple_hbjscqgbuhismoaytymvucjfi?.AnesthesiaProcedure?.Performed;
                object el_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ek_);
                as_ = el_ as CqlDateTime;
            }
            else
            {
                DataType em_ = tuple_hbjscqgbuhismoaytymvucjfi?.AnesthesiaProcedure?.Performed;
                object en_ = FHIRHelpers_4_4_000.Instance.ToValue(context, em_);
                bool eo_ = en_ is CqlInterval<CqlDateTime>;
                if (eo_)
                {
                    DataType ep_ = tuple_hbjscqgbuhismoaytymvucjfi?.AnesthesiaProcedure?.Performed;
                    object eq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ep_);
                    as_ = eq_ as CqlInterval<CqlDateTime>;
                }
                else
                {
                    DataType er_ = tuple_hbjscqgbuhismoaytymvucjfi?.AnesthesiaProcedure?.Performed;
                    object es_ = FHIRHelpers_4_4_000.Instance.ToValue(context, er_);
                    bool et_ = es_ is CqlQuantity;
                    if (et_)
                    {
                        DataType eu_ = tuple_hbjscqgbuhismoaytymvucjfi?.AnesthesiaProcedure?.Performed;
                        object ev_ = FHIRHelpers_4_4_000.Instance.ToValue(context, eu_);
                        as_ = ev_ as CqlQuantity;
                    }
                    else
                    {
                        DataType ew_ = tuple_hbjscqgbuhismoaytymvucjfi?.AnesthesiaProcedure?.Performed;
                        object ex_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ew_);
                        bool ey_ = ex_ is CqlInterval<CqlQuantity>;
                        if (ey_)
                        {
                            DataType ez_ = tuple_hbjscqgbuhismoaytymvucjfi?.AnesthesiaProcedure?.Performed;
                            object fa_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ez_);
                            as_ = fa_ as CqlInterval<CqlQuantity>;
                        }
                        else
                        {
                            as_ = null;
                        }
                    }
                }
            }
            CqlInterval<CqlDateTime> at_ = QICoreCommon_4_0_000.Instance.toInterval(context, as_);
            CqlDateTime au_ = context.Operators.End(at_);
            CqlInterval<CqlDate> av_ = TJCOverall_8_25_000.Instance.calendarDayOfOrDayAfter(context, au_);
            bool? aw_ = av_?.lowClosed;
            object ax_;
            DataType fb_ = tuple_hbjscqgbuhismoaytymvucjfi?.AnesthesiaProcedure?.Performed;
            object fc_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fb_);
            bool fd_ = fc_ is CqlDateTime;
            if (fd_)
            {
                DataType fe_ = tuple_hbjscqgbuhismoaytymvucjfi?.AnesthesiaProcedure?.Performed;
                object ff_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fe_);
                ax_ = ff_ as CqlDateTime;
            }
            else
            {
                DataType fg_ = tuple_hbjscqgbuhismoaytymvucjfi?.AnesthesiaProcedure?.Performed;
                object fh_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fg_);
                bool fi_ = fh_ is CqlInterval<CqlDateTime>;
                if (fi_)
                {
                    DataType fj_ = tuple_hbjscqgbuhismoaytymvucjfi?.AnesthesiaProcedure?.Performed;
                    object fk_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fj_);
                    ax_ = fk_ as CqlInterval<CqlDateTime>;
                }
                else
                {
                    DataType fl_ = tuple_hbjscqgbuhismoaytymvucjfi?.AnesthesiaProcedure?.Performed;
                    object fm_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fl_);
                    bool fn_ = fm_ is CqlQuantity;
                    if (fn_)
                    {
                        DataType fo_ = tuple_hbjscqgbuhismoaytymvucjfi?.AnesthesiaProcedure?.Performed;
                        object fp_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fo_);
                        ax_ = fp_ as CqlQuantity;
                    }
                    else
                    {
                        DataType fq_ = tuple_hbjscqgbuhismoaytymvucjfi?.AnesthesiaProcedure?.Performed;
                        object fr_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fq_);
                        bool fs_ = fr_ is CqlInterval<CqlQuantity>;
                        if (fs_)
                        {
                            DataType ft_ = tuple_hbjscqgbuhismoaytymvucjfi?.AnesthesiaProcedure?.Performed;
                            object fu_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ft_);
                            ax_ = fu_ as CqlInterval<CqlQuantity>;
                        }
                        else
                        {
                            ax_ = null;
                        }
                    }
                }
            }
            CqlInterval<CqlDateTime> ay_ = QICoreCommon_4_0_000.Instance.toInterval(context, ax_);
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
            IEnumerable<Medication> az_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));

            bool? ba_(Medication M) {
                object bd_ = context.Operators.LateBoundProperty<object>(M, "id.value");
                object be_ = context.Operators.LateBoundProperty<object>(MR, "medication.reference.value");
                IEnumerable<string> bf_ = context.Operators.Split((string)be_, "/");
                string bg_ = context.Operators.Last<string>(bf_);
                bool? bh_ = context.Operators.Equal(bd_, bg_);
                CodeableConcept bi_ = M?.Code;
                CqlConcept bj_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, bi_);
                CqlValueSet bk_ = this.Low_Dose_Unfractionated_Heparin_for_VTE_Prophylaxis(context);
                bool? bl_ = context.Operators.ConceptInValueSet(bj_, bk_);
                bool? bm_ = context.Operators.And(bh_, bl_);
                return bm_;
            }

            IEnumerable<Medication> bb_ = context.Operators.Where<Medication>(az_, ba_);
            bool? bc_ = context.Operators.Exists<Medication>(bb_);
            return bc_;
        }

        IEnumerable<MedicationAdministration> e_ = context.Operators.Where<MedicationAdministration>(c_, d_);
        IEnumerable<MedicationAdministration> f_ = context.Operators.Union<MedicationAdministration>(b_, e_);

        bool? g_(MedicationAdministration VTEMedication) {
            Code<MedicationAdministration.MedicationAdministrationStatusCodes> bn_ = VTEMedication?.StatusElement;
            MedicationAdministration.MedicationAdministrationStatusCodes? bo_ = bn_?.Value;
            string bp_ = context.Operators.Convert<string>(bo_);
            bool? bq_ = context.Operators.Equal(bp_, "completed");
            MedicationAdministration.DosageComponent br_ = VTEMedication?.Dosage;
            CodeableConcept bs_ = br_?.Route;
            CqlConcept bt_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, bs_);
            CqlValueSet bu_ = this.Subcutaneous_route(context);
            bool? bv_ = context.Operators.ConceptInValueSet(bt_, bu_);
            bool? bw_ = context.Operators.And(bq_, bv_);
            return bw_;
        }

        IEnumerable<MedicationAdministration> h_ = context.Operators.Where<MedicationAdministration>(f_, g_);
        CqlValueSet i_ = this.Low_Molecular_Weight_Heparin_for_VTE_Prophylaxis(context);
        IEnumerable<MedicationAdministration> j_ = context.Operators.Retrieve<MedicationAdministration>(new RetrieveParameters(default, i_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationadministration"));

        bool? k_(MedicationAdministration MR) {
            IEnumerable<Medication> bx_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));

            bool? by_(Medication M) {
                object cb_ = context.Operators.LateBoundProperty<object>(M, "id.value");
                object cc_ = context.Operators.LateBoundProperty<object>(MR, "medication.reference.value");
                IEnumerable<string> cd_ = context.Operators.Split((string)cc_, "/");
                string ce_ = context.Operators.Last<string>(cd_);
                bool? cf_ = context.Operators.Equal(cb_, ce_);
                CodeableConcept cg_ = M?.Code;
                CqlConcept ch_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, cg_);
                CqlValueSet ci_ = this.Low_Molecular_Weight_Heparin_for_VTE_Prophylaxis(context);
                bool? cj_ = context.Operators.ConceptInValueSet(ch_, ci_);
                bool? ck_ = context.Operators.And(cf_, cj_);
                return ck_;
            }

            IEnumerable<Medication> bz_ = context.Operators.Where<Medication>(bx_, by_);
            bool? ca_ = context.Operators.Exists<Medication>(bz_);
            return ca_;
        }

        IEnumerable<MedicationAdministration> l_ = context.Operators.Where<MedicationAdministration>(c_, k_);
        IEnumerable<MedicationAdministration> m_ = context.Operators.Union<MedicationAdministration>(j_, l_);

        bool? n_(MedicationAdministration LMWH) {
            Code<MedicationAdministration.MedicationAdministrationStatusCodes> cl_ = LMWH?.StatusElement;
            MedicationAdministration.MedicationAdministrationStatusCodes? cm_ = cl_?.Value;
            string cn_ = context.Operators.Convert<string>(cm_);
            bool? co_ = context.Operators.Equal(cn_, "completed");
            return co_;
        }

        IEnumerable<MedicationAdministration> o_ = context.Operators.Where<MedicationAdministration>(m_, n_);
        IEnumerable<MedicationAdministration> p_ = context.Operators.Union<MedicationAdministration>(h_, o_);
        CqlValueSet q_ = this.Injectable_Factor_Xa_Inhibitor_for_VTE_Prophylaxis(context);
        IEnumerable<MedicationAdministration> r_ = context.Operators.Retrieve<MedicationAdministration>(new RetrieveParameters(default, q_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationadministration"));

        bool? s_(MedicationAdministration MR) {
            IEnumerable<Medication> cp_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));

            bool? cq_(Medication M) {
                object ct_ = context.Operators.LateBoundProperty<object>(M, "id.value");
                object cu_ = context.Operators.LateBoundProperty<object>(MR, "medication.reference.value");
                IEnumerable<string> cv_ = context.Operators.Split((string)cu_, "/");
                string cw_ = context.Operators.Last<string>(cv_);
                bool? cx_ = context.Operators.Equal(ct_, cw_);
                CodeableConcept cy_ = M?.Code;
                CqlConcept cz_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, cy_);
                CqlValueSet da_ = this.Injectable_Factor_Xa_Inhibitor_for_VTE_Prophylaxis(context);
                bool? db_ = context.Operators.ConceptInValueSet(cz_, da_);
                bool? dc_ = context.Operators.And(cx_, db_);
                return dc_;
            }

            IEnumerable<Medication> cr_ = context.Operators.Where<Medication>(cp_, cq_);
            bool? cs_ = context.Operators.Exists<Medication>(cr_);
            return cs_;
        }

        IEnumerable<MedicationAdministration> t_ = context.Operators.Where<MedicationAdministration>(c_, s_);
        IEnumerable<MedicationAdministration> u_ = context.Operators.Union<MedicationAdministration>(r_, t_);

        bool? v_(MedicationAdministration FactorXa) {
            Code<MedicationAdministration.MedicationAdministrationStatusCodes> dd_ = FactorXa?.StatusElement;
            MedicationAdministration.MedicationAdministrationStatusCodes? de_ = dd_?.Value;
            string df_ = context.Operators.Convert<string>(de_);
            bool? dg_ = context.Operators.Equal(df_, "completed");
            return dg_;
        }

        IEnumerable<MedicationAdministration> w_ = context.Operators.Where<MedicationAdministration>(u_, v_);
        CqlValueSet x_ = this.Warfarin(context);
        IEnumerable<MedicationAdministration> y_ = context.Operators.Retrieve<MedicationAdministration>(new RetrieveParameters(default, x_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationadministration"));

        bool? z_(MedicationAdministration MR) {
            IEnumerable<Medication> dh_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));

            bool? di_(Medication M) {
                object dl_ = context.Operators.LateBoundProperty<object>(M, "id.value");
                object dm_ = context.Operators.LateBoundProperty<object>(MR, "medication.reference.value");
                IEnumerable<string> dn_ = context.Operators.Split((string)dm_, "/");
                string do_ = context.Operators.Last<string>(dn_);
                bool? dp_ = context.Operators.Equal(dl_, do_);
                CodeableConcept dq_ = M?.Code;
                CqlConcept dr_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, dq_);
                CqlValueSet ds_ = this.Warfarin(context);
                bool? dt_ = context.Operators.ConceptInValueSet(dr_, ds_);
                bool? du_ = context.Operators.And(dp_, dt_);
                return du_;
            }

            IEnumerable<Medication> dj_ = context.Operators.Where<Medication>(dh_, di_);
            bool? dk_ = context.Operators.Exists<Medication>(dj_);
            return dk_;
        }

        IEnumerable<MedicationAdministration> aa_ = context.Operators.Where<MedicationAdministration>(c_, z_);
        IEnumerable<MedicationAdministration> ab_ = context.Operators.Union<MedicationAdministration>(y_, aa_);

        bool? ac_(MedicationAdministration WarfarinAdm) {
            Code<MedicationAdministration.MedicationAdministrationStatusCodes> dv_ = WarfarinAdm?.StatusElement;
            MedicationAdministration.MedicationAdministrationStatusCodes? dw_ = dv_?.Value;
            string dx_ = context.Operators.Convert<string>(dw_);
            bool? dy_ = context.Operators.Equal(dx_, "completed");
            return dy_;
        }

        IEnumerable<MedicationAdministration> ad_ = context.Operators.Where<MedicationAdministration>(ab_, ac_);
        IEnumerable<MedicationAdministration> ae_ = context.Operators.Union<MedicationAdministration>(w_, ad_);
        IEnumerable<MedicationAdministration> af_ = context.Operators.Union<MedicationAdministration>(p_, ae_);
        CqlValueSet ag_ = this.Rivaroxaban_for_VTE_Prophylaxis(context);
        IEnumerable<MedicationAdministration> ah_ = context.Operators.Retrieve<MedicationAdministration>(new RetrieveParameters(default, ag_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationadministration"));

        bool? ai_(MedicationAdministration MR) {
            IEnumerable<Medication> dz_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));

            bool? ea_(Medication M) {
                object ed_ = context.Operators.LateBoundProperty<object>(M, "id.value");
                object ee_ = context.Operators.LateBoundProperty<object>(MR, "medication.reference.value");
                IEnumerable<string> ef_ = context.Operators.Split((string)ee_, "/");
                string eg_ = context.Operators.Last<string>(ef_);
                bool? eh_ = context.Operators.Equal(ed_, eg_);
                CodeableConcept ei_ = M?.Code;
                CqlConcept ej_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, ei_);
                CqlValueSet ek_ = this.Rivaroxaban_for_VTE_Prophylaxis(context);
                bool? el_ = context.Operators.ConceptInValueSet(ej_, ek_);
                bool? em_ = context.Operators.And(eh_, el_);
                return em_;
            }

            IEnumerable<Medication> eb_ = context.Operators.Where<Medication>(dz_, ea_);
            bool? ec_ = context.Operators.Exists<Medication>(eb_);
            return ec_;
        }

        IEnumerable<MedicationAdministration> aj_ = context.Operators.Where<MedicationAdministration>(c_, ai_);
        IEnumerable<MedicationAdministration> ak_ = context.Operators.Union<MedicationAdministration>(ah_, aj_);

        bool? al_(MedicationAdministration Rivaroxaban) {
            Code<MedicationAdministration.MedicationAdministrationStatusCodes> en_ = Rivaroxaban?.StatusElement;
            MedicationAdministration.MedicationAdministrationStatusCodes? eo_ = en_?.Value;
            string ep_ = context.Operators.Convert<string>(eo_);
            bool? eq_ = context.Operators.Equal(ep_, "completed");
            return eq_;
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
            Code<EventStatus> er_ = DeviceApplied?.StatusElement;
            EventStatus? es_ = er_?.Value;
            string et_ = context.Operators.Convert<string>(es_);
            bool? eu_ = context.Operators.Equal(et_, "completed");
            return eu_;
        }

        IEnumerable<Procedure> aw_ = context.Operators.Where<Procedure>(au_, av_);
        IEnumerable<object> ax_ = context.Operators.Union<object>(am_ as IEnumerable<object>, aw_ as IEnumerable<object>);
        IEnumerable<object> ay_ = context.Operators.Union<object>(af_ as IEnumerable<object>, ax_ as IEnumerable<object>);
        return ay_;
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
            (CqlTupleMetadata, Encounter QualifyingEncounter, object VTEProphylaxis)? v_ = (CqlTupleMetadata_DQDJDfNDAVfLFYEjYSBYIhgSj, _valueTuple.Item1, _valueTuple.Item2);
            return v_;
        }

        IEnumerable<(CqlTupleMetadata, Encounter QualifyingEncounter, object VTEProphylaxis)?> e_ = context.Operators.Select<ValueTuple<Encounter, object>, (CqlTupleMetadata, Encounter QualifyingEncounter, object VTEProphylaxis)?>(c_, d_);

        bool? f_((CqlTupleMetadata, Encounter QualifyingEncounter, object VTEProphylaxis)? tuple_dqdjdfndavflfyejysbyihgsj) {
            object w_ = context.Operators.LateBoundProperty<object>(tuple_dqdjdfndavflfyejysbyihgsj?.VTEProphylaxis, "effective");
            object x_ = FHIRHelpers_4_4_000.Instance.ToValue(context, w_);
            CqlInterval<CqlDateTime> y_ = QICoreCommon_4_0_000.Instance.toInterval(context, x_);
            object z_;
            object al_ = context.Operators.LateBoundProperty<object>(tuple_dqdjdfndavflfyejysbyihgsj?.VTEProphylaxis, "performed");
            object am_ = FHIRHelpers_4_4_000.Instance.ToValue(context, al_);
            bool an_ = am_ is CqlDateTime;
            if (an_)
            {
                object ao_ = context.Operators.LateBoundProperty<object>(tuple_dqdjdfndavflfyejysbyihgsj?.VTEProphylaxis, "performed");
                object ap_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ao_);
                z_ = ap_ as CqlDateTime;
            }
            else
            {
                object aq_ = context.Operators.LateBoundProperty<object>(tuple_dqdjdfndavflfyejysbyihgsj?.VTEProphylaxis, "performed");
                object ar_ = FHIRHelpers_4_4_000.Instance.ToValue(context, aq_);
                bool as_ = ar_ is CqlInterval<CqlDateTime>;
                if (as_)
                {
                    object at_ = context.Operators.LateBoundProperty<object>(tuple_dqdjdfndavflfyejysbyihgsj?.VTEProphylaxis, "performed");
                    object au_ = FHIRHelpers_4_4_000.Instance.ToValue(context, at_);
                    z_ = au_ as CqlInterval<CqlDateTime>;
                }
                else
                {
                    object av_ = context.Operators.LateBoundProperty<object>(tuple_dqdjdfndavflfyejysbyihgsj?.VTEProphylaxis, "performed");
                    object aw_ = FHIRHelpers_4_4_000.Instance.ToValue(context, av_);
                    bool ax_ = aw_ is CqlQuantity;
                    if (ax_)
                    {
                        object ay_ = context.Operators.LateBoundProperty<object>(tuple_dqdjdfndavflfyejysbyihgsj?.VTEProphylaxis, "performed");
                        object az_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ay_);
                        z_ = az_ as CqlQuantity;
                    }
                    else
                    {
                        object ba_ = context.Operators.LateBoundProperty<object>(tuple_dqdjdfndavflfyejysbyihgsj?.VTEProphylaxis, "performed");
                        object bb_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ba_);
                        bool bc_ = bb_ is CqlInterval<CqlQuantity>;
                        if (bc_)
                        {
                            object bd_ = context.Operators.LateBoundProperty<object>(tuple_dqdjdfndavflfyejysbyihgsj?.VTEProphylaxis, "performed");
                            object be_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bd_);
                            z_ = be_ as CqlInterval<CqlQuantity>;
                        }
                        else
                        {
                            z_ = null;
                        }
                    }
                }
            }
            CqlInterval<CqlDateTime> aa_ = QICoreCommon_4_0_000.Instance.toInterval(context, z_);
            CqlDateTime ab_ = context.Operators.Start(y_ ?? aa_);
            CqlInterval<CqlDate> ac_ = this.fromDayOfStartOfHospitalizationToDayAfterAdmission(context, tuple_dqdjdfndavflfyejysbyihgsj?.QualifyingEncounter);
            CqlDate ad_ = ac_?.low;
            CqlDateTime ae_ = context.Operators.ConvertDateToDateTime(ad_);
            CqlDate af_ = ac_?.high;
            CqlDateTime ag_ = context.Operators.ConvertDateToDateTime(af_);
            bool? ah_ = ac_?.lowClosed;
            bool? ai_ = ac_?.highClosed;
            CqlInterval<CqlDateTime> aj_ = context.Operators.Interval(ae_, ag_, ah_, ai_);
            bool? ak_ = context.Operators.In<CqlDateTime>(ab_, aj_, "day");
            return ak_;
        }

        IEnumerable<(CqlTupleMetadata, Encounter QualifyingEncounter, object VTEProphylaxis)?> g_ = context.Operators.Where<(CqlTupleMetadata, Encounter QualifyingEncounter, object VTEProphylaxis)?>(e_, f_);
        Encounter h_((CqlTupleMetadata, Encounter QualifyingEncounter, object VTEProphylaxis)? tuple_dqdjdfndavflfyejysbyihgsj) => tuple_dqdjdfndavflfyejysbyihgsj?.QualifyingEncounter;
        IEnumerable<Encounter> i_ = context.Operators.Select<(CqlTupleMetadata, Encounter QualifyingEncounter, object VTEProphylaxis)?, Encounter>(g_, h_);
        IEnumerable<Encounter> j_ = context.Operators.Distinct<Encounter>(i_);
        CqlValueSet k_ = this.General_or_Neuraxial_Anesthesia(context);
        IEnumerable<Procedure> l_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, k_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
        IEnumerable<ValueTuple<Encounter, Procedure, object>> m_ = context.Operators.CrossJoin<Encounter, Procedure, object>(a_, l_, b_);

        (CqlTupleMetadata, Encounter QualifyingEncounter, Procedure AnesthesiaProcedure, object VTEProphylaxis)? n_(ValueTuple<Encounter, Procedure, object> _valueTuple) {
            (CqlTupleMetadata, Encounter QualifyingEncounter, Procedure AnesthesiaProcedure, object VTEProphylaxis)? bf_ = (CqlTupleMetadata_CfSFUFiTWJJfiZASQhERUdATP, _valueTuple.Item1, _valueTuple.Item2, _valueTuple.Item3);
            return bf_;
        }

        IEnumerable<(CqlTupleMetadata, Encounter QualifyingEncounter, Procedure AnesthesiaProcedure, object VTEProphylaxis)?> o_ = context.Operators.Select<ValueTuple<Encounter, Procedure, object>, (CqlTupleMetadata, Encounter QualifyingEncounter, Procedure AnesthesiaProcedure, object VTEProphylaxis)?>(m_, n_);

        bool? p_((CqlTupleMetadata, Encounter QualifyingEncounter, Procedure AnesthesiaProcedure, object VTEProphylaxis)? tuple_bnvctjfzpousixdcefwhciwq) {
            Code<EventStatus> bg_ = tuple_bnvctjfzpousixdcefwhciwq?.AnesthesiaProcedure?.StatusElement;
            EventStatus? bh_ = bg_?.Value;
            string bi_ = context.Operators.Convert<string>(bh_);
            bool? bj_ = context.Operators.Equal(bi_, "completed");
            object bk_;
            DataType cz_ = tuple_bnvctjfzpousixdcefwhciwq?.AnesthesiaProcedure?.Performed;
            object da_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cz_);
            bool db_ = da_ is CqlDateTime;
            if (db_)
            {
                DataType dc_ = tuple_bnvctjfzpousixdcefwhciwq?.AnesthesiaProcedure?.Performed;
                object dd_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dc_);
                bk_ = dd_ as CqlDateTime;
            }
            else
            {
                DataType de_ = tuple_bnvctjfzpousixdcefwhciwq?.AnesthesiaProcedure?.Performed;
                object df_ = FHIRHelpers_4_4_000.Instance.ToValue(context, de_);
                bool dg_ = df_ is CqlInterval<CqlDateTime>;
                if (dg_)
                {
                    DataType dh_ = tuple_bnvctjfzpousixdcefwhciwq?.AnesthesiaProcedure?.Performed;
                    object di_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dh_);
                    bk_ = di_ as CqlInterval<CqlDateTime>;
                }
                else
                {
                    DataType dj_ = tuple_bnvctjfzpousixdcefwhciwq?.AnesthesiaProcedure?.Performed;
                    object dk_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dj_);
                    bool dl_ = dk_ is CqlQuantity;
                    if (dl_)
                    {
                        DataType dm_ = tuple_bnvctjfzpousixdcefwhciwq?.AnesthesiaProcedure?.Performed;
                        object dn_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dm_);
                        bk_ = dn_ as CqlQuantity;
                    }
                    else
                    {
                        DataType do_ = tuple_bnvctjfzpousixdcefwhciwq?.AnesthesiaProcedure?.Performed;
                        object dp_ = FHIRHelpers_4_4_000.Instance.ToValue(context, do_);
                        bool dq_ = dp_ is CqlInterval<CqlQuantity>;
                        if (dq_)
                        {
                            DataType dr_ = tuple_bnvctjfzpousixdcefwhciwq?.AnesthesiaProcedure?.Performed;
                            object ds_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dr_);
                            bk_ = ds_ as CqlInterval<CqlQuantity>;
                        }
                        else
                        {
                            bk_ = null;
                        }
                    }
                }
            }
            CqlInterval<CqlDateTime> bl_ = QICoreCommon_4_0_000.Instance.toInterval(context, bk_);
            CqlDateTime bm_ = context.Operators.End(bl_);
            Period bn_ = tuple_bnvctjfzpousixdcefwhciwq?.QualifyingEncounter?.Period;
            CqlInterval<CqlDateTime> bo_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, bn_);
            CqlDateTime bp_ = context.Operators.Start(bo_);
            CqlQuantity bq_ = context.Operators.Quantity(1m, "day");
            CqlDateTime br_ = context.Operators.Add(bp_, bq_);
            bool? bs_ = context.Operators.SameAs(bm_, br_, "day");
            bool? bt_ = context.Operators.And(bj_, bs_);
            object bu_ = context.Operators.LateBoundProperty<object>(tuple_bnvctjfzpousixdcefwhciwq?.VTEProphylaxis, "effective");
            object bv_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bu_);
            CqlInterval<CqlDateTime> bw_ = QICoreCommon_4_0_000.Instance.toInterval(context, bv_);
            object bx_;
            object dt_ = context.Operators.LateBoundProperty<object>(tuple_bnvctjfzpousixdcefwhciwq?.VTEProphylaxis, "performed");
            object du_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dt_);
            bool dv_ = du_ is CqlDateTime;
            if (dv_)
            {
                object dw_ = context.Operators.LateBoundProperty<object>(tuple_bnvctjfzpousixdcefwhciwq?.VTEProphylaxis, "performed");
                object dx_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dw_);
                bx_ = dx_ as CqlDateTime;
            }
            else
            {
                object dy_ = context.Operators.LateBoundProperty<object>(tuple_bnvctjfzpousixdcefwhciwq?.VTEProphylaxis, "performed");
                object dz_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dy_);
                bool ea_ = dz_ is CqlInterval<CqlDateTime>;
                if (ea_)
                {
                    object eb_ = context.Operators.LateBoundProperty<object>(tuple_bnvctjfzpousixdcefwhciwq?.VTEProphylaxis, "performed");
                    object ec_ = FHIRHelpers_4_4_000.Instance.ToValue(context, eb_);
                    bx_ = ec_ as CqlInterval<CqlDateTime>;
                }
                else
                {
                    object ed_ = context.Operators.LateBoundProperty<object>(tuple_bnvctjfzpousixdcefwhciwq?.VTEProphylaxis, "performed");
                    object ee_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ed_);
                    bool ef_ = ee_ is CqlQuantity;
                    if (ef_)
                    {
                        object eg_ = context.Operators.LateBoundProperty<object>(tuple_bnvctjfzpousixdcefwhciwq?.VTEProphylaxis, "performed");
                        object eh_ = FHIRHelpers_4_4_000.Instance.ToValue(context, eg_);
                        bx_ = eh_ as CqlQuantity;
                    }
                    else
                    {
                        object ei_ = context.Operators.LateBoundProperty<object>(tuple_bnvctjfzpousixdcefwhciwq?.VTEProphylaxis, "performed");
                        object ej_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ei_);
                        bool ek_ = ej_ is CqlInterval<CqlQuantity>;
                        if (ek_)
                        {
                            object el_ = context.Operators.LateBoundProperty<object>(tuple_bnvctjfzpousixdcefwhciwq?.VTEProphylaxis, "performed");
                            object em_ = FHIRHelpers_4_4_000.Instance.ToValue(context, el_);
                            bx_ = em_ as CqlInterval<CqlQuantity>;
                        }
                        else
                        {
                            bx_ = null;
                        }
                    }
                }
            }
            CqlInterval<CqlDateTime> by_ = QICoreCommon_4_0_000.Instance.toInterval(context, bx_);
            CqlDateTime bz_ = context.Operators.Start(bw_ ?? by_);
            object ca_;
            DataType en_ = tuple_bnvctjfzpousixdcefwhciwq?.AnesthesiaProcedure?.Performed;
            object eo_ = FHIRHelpers_4_4_000.Instance.ToValue(context, en_);
            bool ep_ = eo_ is CqlDateTime;
            if (ep_)
            {
                DataType eq_ = tuple_bnvctjfzpousixdcefwhciwq?.AnesthesiaProcedure?.Performed;
                object er_ = FHIRHelpers_4_4_000.Instance.ToValue(context, eq_);
                ca_ = er_ as CqlDateTime;
            }
            else
            {
                DataType es_ = tuple_bnvctjfzpousixdcefwhciwq?.AnesthesiaProcedure?.Performed;
                object et_ = FHIRHelpers_4_4_000.Instance.ToValue(context, es_);
                bool eu_ = et_ is CqlInterval<CqlDateTime>;
                if (eu_)
                {
                    DataType ev_ = tuple_bnvctjfzpousixdcefwhciwq?.AnesthesiaProcedure?.Performed;
                    object ew_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ev_);
                    ca_ = ew_ as CqlInterval<CqlDateTime>;
                }
                else
                {
                    DataType ex_ = tuple_bnvctjfzpousixdcefwhciwq?.AnesthesiaProcedure?.Performed;
                    object ey_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ex_);
                    bool ez_ = ey_ is CqlQuantity;
                    if (ez_)
                    {
                        DataType fa_ = tuple_bnvctjfzpousixdcefwhciwq?.AnesthesiaProcedure?.Performed;
                        object fb_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fa_);
                        ca_ = fb_ as CqlQuantity;
                    }
                    else
                    {
                        DataType fc_ = tuple_bnvctjfzpousixdcefwhciwq?.AnesthesiaProcedure?.Performed;
                        object fd_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fc_);
                        bool fe_ = fd_ is CqlInterval<CqlQuantity>;
                        if (fe_)
                        {
                            DataType ff_ = tuple_bnvctjfzpousixdcefwhciwq?.AnesthesiaProcedure?.Performed;
                            object fg_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ff_);
                            ca_ = fg_ as CqlInterval<CqlQuantity>;
                        }
                        else
                        {
                            ca_ = null;
                        }
                    }
                }
            }
            CqlInterval<CqlDateTime> cb_ = QICoreCommon_4_0_000.Instance.toInterval(context, ca_);
            CqlDateTime cc_ = context.Operators.End(cb_);
            CqlInterval<CqlDate> cd_ = TJCOverall_8_25_000.Instance.calendarDayOfOrDayAfter(context, cc_);
            CqlDate ce_ = cd_?.low;
            CqlDateTime cf_ = context.Operators.ConvertDateToDateTime(ce_);
            object cg_;
            DataType fh_ = tuple_bnvctjfzpousixdcefwhciwq?.AnesthesiaProcedure?.Performed;
            object fi_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fh_);
            bool fj_ = fi_ is CqlDateTime;
            if (fj_)
            {
                DataType fk_ = tuple_bnvctjfzpousixdcefwhciwq?.AnesthesiaProcedure?.Performed;
                object fl_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fk_);
                cg_ = fl_ as CqlDateTime;
            }
            else
            {
                DataType fm_ = tuple_bnvctjfzpousixdcefwhciwq?.AnesthesiaProcedure?.Performed;
                object fn_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fm_);
                bool fo_ = fn_ is CqlInterval<CqlDateTime>;
                if (fo_)
                {
                    DataType fp_ = tuple_bnvctjfzpousixdcefwhciwq?.AnesthesiaProcedure?.Performed;
                    object fq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fp_);
                    cg_ = fq_ as CqlInterval<CqlDateTime>;
                }
                else
                {
                    DataType fr_ = tuple_bnvctjfzpousixdcefwhciwq?.AnesthesiaProcedure?.Performed;
                    object fs_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fr_);
                    bool ft_ = fs_ is CqlQuantity;
                    if (ft_)
                    {
                        DataType fu_ = tuple_bnvctjfzpousixdcefwhciwq?.AnesthesiaProcedure?.Performed;
                        object fv_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fu_);
                        cg_ = fv_ as CqlQuantity;
                    }
                    else
                    {
                        DataType fw_ = tuple_bnvctjfzpousixdcefwhciwq?.AnesthesiaProcedure?.Performed;
                        object fx_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fw_);
                        bool fy_ = fx_ is CqlInterval<CqlQuantity>;
                        if (fy_)
                        {
                            DataType fz_ = tuple_bnvctjfzpousixdcefwhciwq?.AnesthesiaProcedure?.Performed;
                            object ga_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fz_);
                            cg_ = ga_ as CqlInterval<CqlQuantity>;
                        }
                        else
                        {
                            cg_ = null;
                        }
                    }
                }
            }
            CqlInterval<CqlDateTime> ch_ = QICoreCommon_4_0_000.Instance.toInterval(context, cg_);
            CqlDateTime ci_ = context.Operators.End(ch_);
            CqlInterval<CqlDate> cj_ = TJCOverall_8_25_000.Instance.calendarDayOfOrDayAfter(context, ci_);
            CqlDate ck_ = cj_?.high;
            CqlDateTime cl_ = context.Operators.ConvertDateToDateTime(ck_);
            object cm_;
            DataType gb_ = tuple_bnvctjfzpousixdcefwhciwq?.AnesthesiaProcedure?.Performed;
            object gc_ = FHIRHelpers_4_4_000.Instance.ToValue(context, gb_);
            bool gd_ = gc_ is CqlDateTime;
            if (gd_)
            {
                DataType ge_ = tuple_bnvctjfzpousixdcefwhciwq?.AnesthesiaProcedure?.Performed;
                object gf_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ge_);
                cm_ = gf_ as CqlDateTime;
            }
            else
            {
                DataType gg_ = tuple_bnvctjfzpousixdcefwhciwq?.AnesthesiaProcedure?.Performed;
                object gh_ = FHIRHelpers_4_4_000.Instance.ToValue(context, gg_);
                bool gi_ = gh_ is CqlInterval<CqlDateTime>;
                if (gi_)
                {
                    DataType gj_ = tuple_bnvctjfzpousixdcefwhciwq?.AnesthesiaProcedure?.Performed;
                    object gk_ = FHIRHelpers_4_4_000.Instance.ToValue(context, gj_);
                    cm_ = gk_ as CqlInterval<CqlDateTime>;
                }
                else
                {
                    DataType gl_ = tuple_bnvctjfzpousixdcefwhciwq?.AnesthesiaProcedure?.Performed;
                    object gm_ = FHIRHelpers_4_4_000.Instance.ToValue(context, gl_);
                    bool gn_ = gm_ is CqlQuantity;
                    if (gn_)
                    {
                        DataType go_ = tuple_bnvctjfzpousixdcefwhciwq?.AnesthesiaProcedure?.Performed;
                        object gp_ = FHIRHelpers_4_4_000.Instance.ToValue(context, go_);
                        cm_ = gp_ as CqlQuantity;
                    }
                    else
                    {
                        DataType gq_ = tuple_bnvctjfzpousixdcefwhciwq?.AnesthesiaProcedure?.Performed;
                        object gr_ = FHIRHelpers_4_4_000.Instance.ToValue(context, gq_);
                        bool gs_ = gr_ is CqlInterval<CqlQuantity>;
                        if (gs_)
                        {
                            DataType gt_ = tuple_bnvctjfzpousixdcefwhciwq?.AnesthesiaProcedure?.Performed;
                            object gu_ = FHIRHelpers_4_4_000.Instance.ToValue(context, gt_);
                            cm_ = gu_ as CqlInterval<CqlQuantity>;
                        }
                        else
                        {
                            cm_ = null;
                        }
                    }
                }
            }
            CqlInterval<CqlDateTime> cn_ = QICoreCommon_4_0_000.Instance.toInterval(context, cm_);
            CqlDateTime co_ = context.Operators.End(cn_);
            CqlInterval<CqlDate> cp_ = TJCOverall_8_25_000.Instance.calendarDayOfOrDayAfter(context, co_);
            bool? cq_ = cp_?.lowClosed;
            object cr_;
            DataType gv_ = tuple_bnvctjfzpousixdcefwhciwq?.AnesthesiaProcedure?.Performed;
            object gw_ = FHIRHelpers_4_4_000.Instance.ToValue(context, gv_);
            bool gx_ = gw_ is CqlDateTime;
            if (gx_)
            {
                DataType gy_ = tuple_bnvctjfzpousixdcefwhciwq?.AnesthesiaProcedure?.Performed;
                object gz_ = FHIRHelpers_4_4_000.Instance.ToValue(context, gy_);
                cr_ = gz_ as CqlDateTime;
            }
            else
            {
                DataType ha_ = tuple_bnvctjfzpousixdcefwhciwq?.AnesthesiaProcedure?.Performed;
                object hb_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ha_);
                bool hc_ = hb_ is CqlInterval<CqlDateTime>;
                if (hc_)
                {
                    DataType hd_ = tuple_bnvctjfzpousixdcefwhciwq?.AnesthesiaProcedure?.Performed;
                    object he_ = FHIRHelpers_4_4_000.Instance.ToValue(context, hd_);
                    cr_ = he_ as CqlInterval<CqlDateTime>;
                }
                else
                {
                    DataType hf_ = tuple_bnvctjfzpousixdcefwhciwq?.AnesthesiaProcedure?.Performed;
                    object hg_ = FHIRHelpers_4_4_000.Instance.ToValue(context, hf_);
                    bool hh_ = hg_ is CqlQuantity;
                    if (hh_)
                    {
                        DataType hi_ = tuple_bnvctjfzpousixdcefwhciwq?.AnesthesiaProcedure?.Performed;
                        object hj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, hi_);
                        cr_ = hj_ as CqlQuantity;
                    }
                    else
                    {
                        DataType hk_ = tuple_bnvctjfzpousixdcefwhciwq?.AnesthesiaProcedure?.Performed;
                        object hl_ = FHIRHelpers_4_4_000.Instance.ToValue(context, hk_);
                        bool hm_ = hl_ is CqlInterval<CqlQuantity>;
                        if (hm_)
                        {
                            DataType hn_ = tuple_bnvctjfzpousixdcefwhciwq?.AnesthesiaProcedure?.Performed;
                            object ho_ = FHIRHelpers_4_4_000.Instance.ToValue(context, hn_);
                            cr_ = ho_ as CqlInterval<CqlQuantity>;
                        }
                        else
                        {
                            cr_ = null;
                        }
                    }
                }
            }
            CqlInterval<CqlDateTime> cs_ = QICoreCommon_4_0_000.Instance.toInterval(context, cr_);
            CqlDateTime ct_ = context.Operators.End(cs_);
            CqlInterval<CqlDate> cu_ = TJCOverall_8_25_000.Instance.calendarDayOfOrDayAfter(context, ct_);
            bool? cv_ = cu_?.highClosed;
            CqlInterval<CqlDateTime> cw_ = context.Operators.Interval(cf_, cl_, cq_, cv_);
            bool? cx_ = context.Operators.In<CqlDateTime>(bz_, cw_, "day");
            bool? cy_ = context.Operators.And(bt_, cx_);
            return cy_;
        }

        IEnumerable<(CqlTupleMetadata, Encounter QualifyingEncounter, Procedure AnesthesiaProcedure, object VTEProphylaxis)?> q_ = context.Operators.Where<(CqlTupleMetadata, Encounter QualifyingEncounter, Procedure AnesthesiaProcedure, object VTEProphylaxis)?>(o_, p_);
        Encounter r_((CqlTupleMetadata, Encounter QualifyingEncounter, Procedure AnesthesiaProcedure, object VTEProphylaxis)? tuple_bnvctjfzpousixdcefwhciwq) => tuple_bnvctjfzpousixdcefwhciwq?.QualifyingEncounter;
        IEnumerable<Encounter> s_ = context.Operators.Select<(CqlTupleMetadata, Encounter QualifyingEncounter, Procedure AnesthesiaProcedure, object VTEProphylaxis)?, Encounter>(q_, r_);
        IEnumerable<Encounter> t_ = context.Operators.Distinct<Encounter>(s_);
        IEnumerable<Encounter> u_ = context.Operators.Union<Encounter>(j_, t_);
        return u_;
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
            IEnumerable<Medication> ad_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));

            bool? ae_(Medication M) {
                object ah_ = context.Operators.LateBoundProperty<object>(M, "id.value");
                object ai_ = context.Operators.LateBoundProperty<object>(MR, "medication.reference.value");
                IEnumerable<string> aj_ = context.Operators.Split((string)ai_, "/");
                string ak_ = context.Operators.Last<string>(aj_);
                bool? al_ = context.Operators.Equal(ah_, ak_);
                CodeableConcept am_ = M?.Code;
                CqlConcept an_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, am_);
                CqlValueSet ao_ = this.Oral_Factor_Xa_Inhibitor_for_VTE_Prophylaxis_or_VTE_Treatment(context);
                bool? ap_ = context.Operators.ConceptInValueSet(an_, ao_);
                bool? aq_ = context.Operators.And(al_, ap_);
                return aq_;
            }

            IEnumerable<Medication> af_ = context.Operators.Where<Medication>(ad_, ae_);
            bool? ag_ = context.Operators.Exists<Medication>(af_);
            return ag_;
        }

        IEnumerable<MedicationAdministration> f_ = context.Operators.Where<MedicationAdministration>(d_, e_);
        IEnumerable<MedicationAdministration> g_ = context.Operators.Union<MedicationAdministration>(c_, f_);
        IEnumerable<ValueTuple<Encounter, MedicationAdministration>> h_ = context.Operators.CrossJoin<Encounter, MedicationAdministration>(a_, g_);

        (CqlTupleMetadata, Encounter QualifyingEncounter, MedicationAdministration FactorXaMedication)? i_(ValueTuple<Encounter, MedicationAdministration> _valueTuple) {
            (CqlTupleMetadata, Encounter QualifyingEncounter, MedicationAdministration FactorXaMedication)? ar_ = (CqlTupleMetadata_EBRQeiSMaTgecHVEbVOIMZEcb, _valueTuple.Item1, _valueTuple.Item2);
            return ar_;
        }

        IEnumerable<(CqlTupleMetadata, Encounter QualifyingEncounter, MedicationAdministration FactorXaMedication)?> j_ = context.Operators.Select<ValueTuple<Encounter, MedicationAdministration>, (CqlTupleMetadata, Encounter QualifyingEncounter, MedicationAdministration FactorXaMedication)?>(h_, i_);

        bool? k_((CqlTupleMetadata, Encounter QualifyingEncounter, MedicationAdministration FactorXaMedication)? tuple_cdbvhiekdcojzrccbhjghhgeo) {
            Code<MedicationAdministration.MedicationAdministrationStatusCodes> as_ = tuple_cdbvhiekdcojzrccbhjghhgeo?.FactorXaMedication?.StatusElement;
            MedicationAdministration.MedicationAdministrationStatusCodes? at_ = as_?.Value;
            string au_ = context.Operators.Convert<string>(at_);
            bool? av_ = context.Operators.Equal(au_, "completed");
            DataType aw_ = tuple_cdbvhiekdcojzrccbhjghhgeo?.FactorXaMedication?.Effective;
            object ax_ = FHIRHelpers_4_4_000.Instance.ToValue(context, aw_);
            CqlInterval<CqlDateTime> ay_ = QICoreCommon_4_0_000.Instance.toInterval(context, ax_);
            CqlDateTime az_ = context.Operators.Start(ay_);
            Period ba_ = tuple_cdbvhiekdcojzrccbhjghhgeo?.QualifyingEncounter?.Period;
            CqlInterval<CqlDateTime> bb_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ba_);
            CqlDateTime bc_ = context.Operators.Start(bb_);
            CqlInterval<CqlDate> bd_ = TJCOverall_8_25_000.Instance.calendarDayOfOrDayAfter(context, bc_);
            CqlDate be_ = bd_?.low;
            CqlDateTime bf_ = context.Operators.ConvertDateToDateTime(be_);
            CqlDate bg_ = bd_?.high;
            CqlDateTime bh_ = context.Operators.ConvertDateToDateTime(bg_);
            bool? bi_ = bd_?.lowClosed;
            bool? bj_ = bd_?.highClosed;
            CqlInterval<CqlDateTime> bk_ = context.Operators.Interval(bf_, bh_, bi_, bj_);
            bool? bl_ = context.Operators.In<CqlDateTime>(az_, bk_, "day");
            bool? bm_ = context.Operators.And(av_, bl_);
            return bm_;
        }

        IEnumerable<(CqlTupleMetadata, Encounter QualifyingEncounter, MedicationAdministration FactorXaMedication)?> l_ = context.Operators.Where<(CqlTupleMetadata, Encounter QualifyingEncounter, MedicationAdministration FactorXaMedication)?>(j_, k_);
        Encounter m_((CqlTupleMetadata, Encounter QualifyingEncounter, MedicationAdministration FactorXaMedication)? tuple_cdbvhiekdcojzrccbhjghhgeo) => tuple_cdbvhiekdcojzrccbhjghhgeo?.QualifyingEncounter;
        IEnumerable<Encounter> n_ = context.Operators.Select<(CqlTupleMetadata, Encounter QualifyingEncounter, MedicationAdministration FactorXaMedication)?, Encounter>(l_, m_);
        IEnumerable<Encounter> o_ = context.Operators.Distinct<Encounter>(n_);
        CqlValueSet p_ = this.General_or_Neuraxial_Anesthesia(context);
        IEnumerable<Procedure> q_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, p_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));

        bool? r_(MedicationAdministration MR) {
            IEnumerable<Medication> bn_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));

            bool? bo_(Medication M) {
                object br_ = context.Operators.LateBoundProperty<object>(M, "id.value");
                object bs_ = context.Operators.LateBoundProperty<object>(MR, "medication.reference.value");
                IEnumerable<string> bt_ = context.Operators.Split((string)bs_, "/");
                string bu_ = context.Operators.Last<string>(bt_);
                bool? bv_ = context.Operators.Equal(br_, bu_);
                CodeableConcept bw_ = M?.Code;
                CqlConcept bx_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, bw_);
                CqlValueSet by_ = this.Oral_Factor_Xa_Inhibitor_for_VTE_Prophylaxis_or_VTE_Treatment(context);
                bool? bz_ = context.Operators.ConceptInValueSet(bx_, by_);
                bool? ca_ = context.Operators.And(bv_, bz_);
                return ca_;
            }

            IEnumerable<Medication> bp_ = context.Operators.Where<Medication>(bn_, bo_);
            bool? bq_ = context.Operators.Exists<Medication>(bp_);
            return bq_;
        }

        IEnumerable<MedicationAdministration> s_ = context.Operators.Where<MedicationAdministration>(d_, r_);
        IEnumerable<MedicationAdministration> t_ = context.Operators.Union<MedicationAdministration>(c_, s_);
        IEnumerable<ValueTuple<Encounter, Procedure, MedicationAdministration>> u_ = context.Operators.CrossJoin<Encounter, Procedure, MedicationAdministration>(a_, q_, t_);

        (CqlTupleMetadata, Encounter QualifyingEncounter, Procedure AnesthesiaProcedure, MedicationAdministration FactorXaMedication)? v_(ValueTuple<Encounter, Procedure, MedicationAdministration> _valueTuple) {
            (CqlTupleMetadata, Encounter QualifyingEncounter, Procedure AnesthesiaProcedure, MedicationAdministration FactorXaMedication)? cb_ = (CqlTupleMetadata_CdgLdDFHNTDXFGGVTOMXhQZR, _valueTuple.Item1, _valueTuple.Item2, _valueTuple.Item3);
            return cb_;
        }

        IEnumerable<(CqlTupleMetadata, Encounter QualifyingEncounter, Procedure AnesthesiaProcedure, MedicationAdministration FactorXaMedication)?> w_ = context.Operators.Select<ValueTuple<Encounter, Procedure, MedicationAdministration>, (CqlTupleMetadata, Encounter QualifyingEncounter, Procedure AnesthesiaProcedure, MedicationAdministration FactorXaMedication)?>(u_, v_);

        bool? x_((CqlTupleMetadata, Encounter QualifyingEncounter, Procedure AnesthesiaProcedure, MedicationAdministration FactorXaMedication)? tuple_dejnabiogwrwyxienqokgepgj) {
            Code<MedicationAdministration.MedicationAdministrationStatusCodes> cc_ = tuple_dejnabiogwrwyxienqokgepgj?.FactorXaMedication?.StatusElement;
            MedicationAdministration.MedicationAdministrationStatusCodes? cd_ = cc_?.Value;
            string ce_ = context.Operators.Convert<string>(cd_);
            bool? cf_ = context.Operators.Equal(ce_, "completed");
            Code<EventStatus> cg_ = tuple_dejnabiogwrwyxienqokgepgj?.AnesthesiaProcedure?.StatusElement;
            EventStatus? ch_ = cg_?.Value;
            string ci_ = context.Operators.Convert<string>(ch_);
            bool? cj_ = context.Operators.Equal(ci_, "completed");
            bool? ck_ = context.Operators.And(cf_, cj_);
            object cl_;
            DataType dy_ = tuple_dejnabiogwrwyxienqokgepgj?.AnesthesiaProcedure?.Performed;
            object dz_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dy_);
            bool ea_ = dz_ is CqlDateTime;
            if (ea_)
            {
                DataType eb_ = tuple_dejnabiogwrwyxienqokgepgj?.AnesthesiaProcedure?.Performed;
                object ec_ = FHIRHelpers_4_4_000.Instance.ToValue(context, eb_);
                cl_ = ec_ as CqlDateTime;
            }
            else
            {
                DataType ed_ = tuple_dejnabiogwrwyxienqokgepgj?.AnesthesiaProcedure?.Performed;
                object ee_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ed_);
                bool ef_ = ee_ is CqlInterval<CqlDateTime>;
                if (ef_)
                {
                    DataType eg_ = tuple_dejnabiogwrwyxienqokgepgj?.AnesthesiaProcedure?.Performed;
                    object eh_ = FHIRHelpers_4_4_000.Instance.ToValue(context, eg_);
                    cl_ = eh_ as CqlInterval<CqlDateTime>;
                }
                else
                {
                    DataType ei_ = tuple_dejnabiogwrwyxienqokgepgj?.AnesthesiaProcedure?.Performed;
                    object ej_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ei_);
                    bool ek_ = ej_ is CqlQuantity;
                    if (ek_)
                    {
                        DataType el_ = tuple_dejnabiogwrwyxienqokgepgj?.AnesthesiaProcedure?.Performed;
                        object em_ = FHIRHelpers_4_4_000.Instance.ToValue(context, el_);
                        cl_ = em_ as CqlQuantity;
                    }
                    else
                    {
                        DataType en_ = tuple_dejnabiogwrwyxienqokgepgj?.AnesthesiaProcedure?.Performed;
                        object eo_ = FHIRHelpers_4_4_000.Instance.ToValue(context, en_);
                        bool ep_ = eo_ is CqlInterval<CqlQuantity>;
                        if (ep_)
                        {
                            DataType eq_ = tuple_dejnabiogwrwyxienqokgepgj?.AnesthesiaProcedure?.Performed;
                            object er_ = FHIRHelpers_4_4_000.Instance.ToValue(context, eq_);
                            cl_ = er_ as CqlInterval<CqlQuantity>;
                        }
                        else
                        {
                            cl_ = null;
                        }
                    }
                }
            }
            CqlInterval<CqlDateTime> cm_ = QICoreCommon_4_0_000.Instance.toInterval(context, cl_);
            CqlDateTime cn_ = context.Operators.End(cm_);
            Period co_ = tuple_dejnabiogwrwyxienqokgepgj?.QualifyingEncounter?.Period;
            CqlInterval<CqlDateTime> cp_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, co_);
            CqlDateTime cq_ = context.Operators.Start(cp_);
            CqlQuantity cr_ = context.Operators.Quantity(1m, "day");
            CqlDateTime cs_ = context.Operators.Add(cq_, cr_);
            bool? ct_ = context.Operators.SameAs(cn_, cs_, "day");
            bool? cu_ = context.Operators.And(ck_, ct_);
            DataType cv_ = tuple_dejnabiogwrwyxienqokgepgj?.FactorXaMedication?.Effective;
            object cw_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cv_);
            CqlInterval<CqlDateTime> cx_ = QICoreCommon_4_0_000.Instance.toInterval(context, cw_);
            CqlDateTime cy_ = context.Operators.Start(cx_);
            object cz_;
            DataType es_ = tuple_dejnabiogwrwyxienqokgepgj?.AnesthesiaProcedure?.Performed;
            object et_ = FHIRHelpers_4_4_000.Instance.ToValue(context, es_);
            bool eu_ = et_ is CqlDateTime;
            if (eu_)
            {
                DataType ev_ = tuple_dejnabiogwrwyxienqokgepgj?.AnesthesiaProcedure?.Performed;
                object ew_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ev_);
                cz_ = ew_ as CqlDateTime;
            }
            else
            {
                DataType ex_ = tuple_dejnabiogwrwyxienqokgepgj?.AnesthesiaProcedure?.Performed;
                object ey_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ex_);
                bool ez_ = ey_ is CqlInterval<CqlDateTime>;
                if (ez_)
                {
                    DataType fa_ = tuple_dejnabiogwrwyxienqokgepgj?.AnesthesiaProcedure?.Performed;
                    object fb_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fa_);
                    cz_ = fb_ as CqlInterval<CqlDateTime>;
                }
                else
                {
                    DataType fc_ = tuple_dejnabiogwrwyxienqokgepgj?.AnesthesiaProcedure?.Performed;
                    object fd_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fc_);
                    bool fe_ = fd_ is CqlQuantity;
                    if (fe_)
                    {
                        DataType ff_ = tuple_dejnabiogwrwyxienqokgepgj?.AnesthesiaProcedure?.Performed;
                        object fg_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ff_);
                        cz_ = fg_ as CqlQuantity;
                    }
                    else
                    {
                        DataType fh_ = tuple_dejnabiogwrwyxienqokgepgj?.AnesthesiaProcedure?.Performed;
                        object fi_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fh_);
                        bool fj_ = fi_ is CqlInterval<CqlQuantity>;
                        if (fj_)
                        {
                            DataType fk_ = tuple_dejnabiogwrwyxienqokgepgj?.AnesthesiaProcedure?.Performed;
                            object fl_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fk_);
                            cz_ = fl_ as CqlInterval<CqlQuantity>;
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
            CqlDate dd_ = dc_?.low;
            CqlDateTime de_ = context.Operators.ConvertDateToDateTime(dd_);
            object df_;
            DataType fm_ = tuple_dejnabiogwrwyxienqokgepgj?.AnesthesiaProcedure?.Performed;
            object fn_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fm_);
            bool fo_ = fn_ is CqlDateTime;
            if (fo_)
            {
                DataType fp_ = tuple_dejnabiogwrwyxienqokgepgj?.AnesthesiaProcedure?.Performed;
                object fq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fp_);
                df_ = fq_ as CqlDateTime;
            }
            else
            {
                DataType fr_ = tuple_dejnabiogwrwyxienqokgepgj?.AnesthesiaProcedure?.Performed;
                object fs_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fr_);
                bool ft_ = fs_ is CqlInterval<CqlDateTime>;
                if (ft_)
                {
                    DataType fu_ = tuple_dejnabiogwrwyxienqokgepgj?.AnesthesiaProcedure?.Performed;
                    object fv_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fu_);
                    df_ = fv_ as CqlInterval<CqlDateTime>;
                }
                else
                {
                    DataType fw_ = tuple_dejnabiogwrwyxienqokgepgj?.AnesthesiaProcedure?.Performed;
                    object fx_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fw_);
                    bool fy_ = fx_ is CqlQuantity;
                    if (fy_)
                    {
                        DataType fz_ = tuple_dejnabiogwrwyxienqokgepgj?.AnesthesiaProcedure?.Performed;
                        object ga_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fz_);
                        df_ = ga_ as CqlQuantity;
                    }
                    else
                    {
                        DataType gb_ = tuple_dejnabiogwrwyxienqokgepgj?.AnesthesiaProcedure?.Performed;
                        object gc_ = FHIRHelpers_4_4_000.Instance.ToValue(context, gb_);
                        bool gd_ = gc_ is CqlInterval<CqlQuantity>;
                        if (gd_)
                        {
                            DataType ge_ = tuple_dejnabiogwrwyxienqokgepgj?.AnesthesiaProcedure?.Performed;
                            object gf_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ge_);
                            df_ = gf_ as CqlInterval<CqlQuantity>;
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
            CqlDate dj_ = di_?.high;
            CqlDateTime dk_ = context.Operators.ConvertDateToDateTime(dj_);
            object dl_;
            DataType gg_ = tuple_dejnabiogwrwyxienqokgepgj?.AnesthesiaProcedure?.Performed;
            object gh_ = FHIRHelpers_4_4_000.Instance.ToValue(context, gg_);
            bool gi_ = gh_ is CqlDateTime;
            if (gi_)
            {
                DataType gj_ = tuple_dejnabiogwrwyxienqokgepgj?.AnesthesiaProcedure?.Performed;
                object gk_ = FHIRHelpers_4_4_000.Instance.ToValue(context, gj_);
                dl_ = gk_ as CqlDateTime;
            }
            else
            {
                DataType gl_ = tuple_dejnabiogwrwyxienqokgepgj?.AnesthesiaProcedure?.Performed;
                object gm_ = FHIRHelpers_4_4_000.Instance.ToValue(context, gl_);
                bool gn_ = gm_ is CqlInterval<CqlDateTime>;
                if (gn_)
                {
                    DataType go_ = tuple_dejnabiogwrwyxienqokgepgj?.AnesthesiaProcedure?.Performed;
                    object gp_ = FHIRHelpers_4_4_000.Instance.ToValue(context, go_);
                    dl_ = gp_ as CqlInterval<CqlDateTime>;
                }
                else
                {
                    DataType gq_ = tuple_dejnabiogwrwyxienqokgepgj?.AnesthesiaProcedure?.Performed;
                    object gr_ = FHIRHelpers_4_4_000.Instance.ToValue(context, gq_);
                    bool gs_ = gr_ is CqlQuantity;
                    if (gs_)
                    {
                        DataType gt_ = tuple_dejnabiogwrwyxienqokgepgj?.AnesthesiaProcedure?.Performed;
                        object gu_ = FHIRHelpers_4_4_000.Instance.ToValue(context, gt_);
                        dl_ = gu_ as CqlQuantity;
                    }
                    else
                    {
                        DataType gv_ = tuple_dejnabiogwrwyxienqokgepgj?.AnesthesiaProcedure?.Performed;
                        object gw_ = FHIRHelpers_4_4_000.Instance.ToValue(context, gv_);
                        bool gx_ = gw_ is CqlInterval<CqlQuantity>;
                        if (gx_)
                        {
                            DataType gy_ = tuple_dejnabiogwrwyxienqokgepgj?.AnesthesiaProcedure?.Performed;
                            object gz_ = FHIRHelpers_4_4_000.Instance.ToValue(context, gy_);
                            dl_ = gz_ as CqlInterval<CqlQuantity>;
                        }
                        else
                        {
                            dl_ = null;
                        }
                    }
                }
            }
            CqlInterval<CqlDateTime> dm_ = QICoreCommon_4_0_000.Instance.toInterval(context, dl_);
            CqlDateTime dn_ = context.Operators.End(dm_);
            CqlInterval<CqlDate> do_ = TJCOverall_8_25_000.Instance.calendarDayOfOrDayAfter(context, dn_);
            bool? dp_ = do_?.lowClosed;
            object dq_;
            DataType ha_ = tuple_dejnabiogwrwyxienqokgepgj?.AnesthesiaProcedure?.Performed;
            object hb_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ha_);
            bool hc_ = hb_ is CqlDateTime;
            if (hc_)
            {
                DataType hd_ = tuple_dejnabiogwrwyxienqokgepgj?.AnesthesiaProcedure?.Performed;
                object he_ = FHIRHelpers_4_4_000.Instance.ToValue(context, hd_);
                dq_ = he_ as CqlDateTime;
            }
            else
            {
                DataType hf_ = tuple_dejnabiogwrwyxienqokgepgj?.AnesthesiaProcedure?.Performed;
                object hg_ = FHIRHelpers_4_4_000.Instance.ToValue(context, hf_);
                bool hh_ = hg_ is CqlInterval<CqlDateTime>;
                if (hh_)
                {
                    DataType hi_ = tuple_dejnabiogwrwyxienqokgepgj?.AnesthesiaProcedure?.Performed;
                    object hj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, hi_);
                    dq_ = hj_ as CqlInterval<CqlDateTime>;
                }
                else
                {
                    DataType hk_ = tuple_dejnabiogwrwyxienqokgepgj?.AnesthesiaProcedure?.Performed;
                    object hl_ = FHIRHelpers_4_4_000.Instance.ToValue(context, hk_);
                    bool hm_ = hl_ is CqlQuantity;
                    if (hm_)
                    {
                        DataType hn_ = tuple_dejnabiogwrwyxienqokgepgj?.AnesthesiaProcedure?.Performed;
                        object ho_ = FHIRHelpers_4_4_000.Instance.ToValue(context, hn_);
                        dq_ = ho_ as CqlQuantity;
                    }
                    else
                    {
                        DataType hp_ = tuple_dejnabiogwrwyxienqokgepgj?.AnesthesiaProcedure?.Performed;
                        object hq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, hp_);
                        bool hr_ = hq_ is CqlInterval<CqlQuantity>;
                        if (hr_)
                        {
                            DataType hs_ = tuple_dejnabiogwrwyxienqokgepgj?.AnesthesiaProcedure?.Performed;
                            object ht_ = FHIRHelpers_4_4_000.Instance.ToValue(context, hs_);
                            dq_ = ht_ as CqlInterval<CqlQuantity>;
                        }
                        else
                        {
                            dq_ = null;
                        }
                    }
                }
            }
            CqlInterval<CqlDateTime> dr_ = QICoreCommon_4_0_000.Instance.toInterval(context, dq_);
            CqlDateTime ds_ = context.Operators.End(dr_);
            CqlInterval<CqlDate> dt_ = TJCOverall_8_25_000.Instance.calendarDayOfOrDayAfter(context, ds_);
            bool? du_ = dt_?.highClosed;
            CqlInterval<CqlDateTime> dv_ = context.Operators.Interval(de_, dk_, dp_, du_);
            bool? dw_ = context.Operators.In<CqlDateTime>(cy_, dv_, "day");
            bool? dx_ = context.Operators.And(cu_, dw_);
            return dx_;
        }

        IEnumerable<(CqlTupleMetadata, Encounter QualifyingEncounter, Procedure AnesthesiaProcedure, MedicationAdministration FactorXaMedication)?> y_ = context.Operators.Where<(CqlTupleMetadata, Encounter QualifyingEncounter, Procedure AnesthesiaProcedure, MedicationAdministration FactorXaMedication)?>(w_, x_);
        Encounter z_((CqlTupleMetadata, Encounter QualifyingEncounter, Procedure AnesthesiaProcedure, MedicationAdministration FactorXaMedication)? tuple_dejnabiogwrwyxienqokgepgj) => tuple_dejnabiogwrwyxienqokgepgj?.QualifyingEncounter;
        IEnumerable<Encounter> aa_ = context.Operators.Select<(CqlTupleMetadata, Encounter QualifyingEncounter, Procedure AnesthesiaProcedure, MedicationAdministration FactorXaMedication)?, Encounter>(y_, z_);
        IEnumerable<Encounter> ab_ = context.Operators.Distinct<Encounter>(aa_);
        IEnumerable<Encounter> ac_ = context.Operators.Union<Encounter>(o_, ab_);
        return ac_;
    }


    [CqlExpressionDefinition("Encounter With Prior Or Present Diagnosis Of Atrial Fibrillation Or Prior Diagnosis Of VTE")]
    public IEnumerable<Encounter> Encounter_With_Prior_Or_Present_Diagnosis_Of_Atrial_Fibrillation_Or_Prior_Diagnosis_Of_VTE(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Encounter_With_Prior_Or_Present_Diagnosis_Of_Atrial_Fibrillation_Or_Prior_Diagnosis_Of_VTE, Encounter_With_Prior_Or_Present_Diagnosis_Of_Atrial_Fibrillation_Or_Prior_Diagnosis_Of_VTE_Compute);

    private const long _cacheIndex_Encounter_With_Prior_Or_Present_Diagnosis_Of_Atrial_Fibrillation_Or_Prior_Diagnosis_Of_VTE = -6120398887152395383L;

    private IEnumerable<Encounter> Encounter_With_Prior_Or_Present_Diagnosis_Of_Atrial_Fibrillation_Or_Prior_Diagnosis_Of_VTE_Compute(CqlContext context)
    {
        IEnumerable<Encounter> a_ = VTE_8_18_000.Instance.Encounter_With_Age_Range_And_Without_VTE_Diagnosis_Or_Obstetrical_Conditions(context);

        bool? b_(Encounter QualifyingEncounter) {
            CqlValueSet j_ = this.Atrial_Fibrillation_or_Flutter(context);
            IEnumerable<Condition> k_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, j_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-problems-health-concerns"));

            bool? l_(Condition AtrialFibrillation) {
                CodeableConcept o_ = AtrialFibrillation?.VerificationStatus;
                CqlConcept p_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, o_);
                bool? q_ = context.Operators.Not((bool?)(p_ is null));
                CqlCode r_ = QICoreCommon_4_0_000.Instance.refuted(context);
                CqlConcept s_ = context.Operators.ConvertCodeToConcept(r_);
                bool? t_ = context.Operators.Equivalent(p_, s_);
                bool? u_ = context.Operators.Not(t_);
                CqlCode v_ = QICoreCommon_4_0_000.Instance.entered_in_error(context);
                CqlConcept w_ = context.Operators.ConvertCodeToConcept(v_);
                bool? x_ = context.Operators.Equivalent(p_, w_);
                bool? y_ = context.Operators.Not(x_);
                bool? z_ = context.Operators.And(u_, y_);
                DataType aa_ = AtrialFibrillation?.Onset;
                object ab_ = FHIRHelpers_4_4_000.Instance.ToValue(context, aa_);
                CqlInterval<CqlDateTime> ac_ = QICoreCommon_4_0_000.Instance.toInterval(context, ab_);
                CqlDateTime ad_ = context.Operators.Start(ac_);
                Period ae_ = QualifyingEncounter?.Period;
                CqlInterval<CqlDateTime> af_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ae_);
                CqlDateTime ag_ = context.Operators.End(af_);
                bool? ah_ = context.Operators.SameOrBefore(ad_, ag_, (string)default);
                bool? ai_ = context.Operators.And(z_, ah_);
                bool? aj_ = context.Operators.Implies(q_, ai_);
                return aj_;
            }

            IEnumerable<Condition> m_ = context.Operators.Where<Condition>(k_, l_);
            bool? n_ = context.Operators.Exists<Condition>(m_);
            return n_;
        }

        IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);

        bool? d_(Encounter QualifyingEncounter) {
            CqlValueSet ak_ = this.Atrial_Fibrillation_or_Flutter(context);
            bool? al_ = VTE_8_18_000.Instance.hasEncDiagnosisOf(context, QualifyingEncounter, ak_);
            return al_;
        }

        IEnumerable<Encounter> e_ = context.Operators.Where<Encounter>(a_, d_);
        IEnumerable<Encounter> f_ = context.Operators.Union<Encounter>(c_, e_);

        bool? g_(Encounter QualifyingEncounter) {
            CqlValueSet am_ = this.Venous_Thromboembolism(context);
            IEnumerable<Condition> an_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, am_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-problems-health-concerns"));

            bool? ao_(Condition VTEDiagnosis) {
                CodeableConcept ar_ = VTEDiagnosis?.ClinicalStatus;
                CqlConcept as_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, ar_);
                CqlCode at_ = QICoreCommon_4_0_000.Instance.inactive(context);
                CqlConcept au_ = context.Operators.ConvertCodeToConcept(at_);
                bool? av_ = context.Operators.Equivalent(as_, au_);
                CqlCode aw_ = QICoreCommon_4_0_000.Instance.remission(context);
                CqlConcept ax_ = context.Operators.ConvertCodeToConcept(aw_);
                bool? ay_ = context.Operators.Equivalent(as_, ax_);
                bool? az_ = context.Operators.Or(av_, ay_);
                CqlCode ba_ = QICoreCommon_4_0_000.Instance.resolved(context);
                CqlConcept bb_ = context.Operators.ConvertCodeToConcept(ba_);
                bool? bc_ = context.Operators.Equivalent(as_, bb_);
                bool? bd_ = context.Operators.Or(az_, bc_);
                CodeableConcept be_ = VTEDiagnosis?.VerificationStatus;
                CqlConcept bf_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, be_);
                bool? bg_ = context.Operators.Not((bool?)(bf_ is null));
                bool? bh_ = context.Operators.And(bd_, bg_);
                CqlCode bi_ = QICoreCommon_4_0_000.Instance.refuted(context);
                CqlConcept bj_ = context.Operators.ConvertCodeToConcept(bi_);
                bool? bk_ = context.Operators.Equivalent(bf_, bj_);
                bool? bl_ = context.Operators.Not(bk_);
                CqlCode bm_ = QICoreCommon_4_0_000.Instance.entered_in_error(context);
                CqlConcept bn_ = context.Operators.ConvertCodeToConcept(bm_);
                bool? bo_ = context.Operators.Equivalent(bf_, bn_);
                bool? bp_ = context.Operators.Not(bo_);
                bool? bq_ = context.Operators.And(bl_, bp_);
                DataType br_ = VTEDiagnosis?.Onset;
                object bs_ = FHIRHelpers_4_4_000.Instance.ToValue(context, br_);
                CqlInterval<CqlDateTime> bt_ = QICoreCommon_4_0_000.Instance.toInterval(context, bs_);
                CqlInterval<CqlDateTime> bu_;
                Period by_ = QualifyingEncounter?.Period;
                CqlInterval<CqlDateTime> bz_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, by_);
                CqlDateTime ca_ = context.Operators.Start(bz_);
                if (ca_ is null)
                {
                    bu_ = default;
                }
                else
                {
                    Period cb_ = QualifyingEncounter?.Period;
                    CqlInterval<CqlDateTime> cc_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, cb_);
                    CqlDateTime cd_ = context.Operators.Start(cc_);
                    CqlInterval<CqlDateTime> ce_ = context.Operators.Interval(cd_, cd_, true, true);
                    bu_ = ce_;
                }
                bool? bv_ = context.Operators.Before(bt_, bu_, (string)default);
                bool? bw_ = context.Operators.And(bq_, bv_);
                bool? bx_ = context.Operators.Implies(bh_, bw_);
                return bx_;
            }

            IEnumerable<Condition> ap_ = context.Operators.Where<Condition>(an_, ao_);
            bool? aq_ = context.Operators.Exists<Condition>(ap_);
            return aq_;
        }

        IEnumerable<Encounter> h_ = context.Operators.Where<Encounter>(a_, g_);
        IEnumerable<Encounter> i_ = context.Operators.Union<Encounter>(f_, h_);
        return i_;
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
                object p_;
                DataType x_ = HipKneeProcedure?.Performed;
                object y_ = FHIRHelpers_4_4_000.Instance.ToValue(context, x_);
                bool z_ = y_ is CqlDateTime;
                if (z_)
                {
                    DataType aa_ = HipKneeProcedure?.Performed;
                    object ab_ = FHIRHelpers_4_4_000.Instance.ToValue(context, aa_);
                    p_ = ab_ as CqlDateTime;
                }
                else
                {
                    DataType ac_ = HipKneeProcedure?.Performed;
                    object ad_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ac_);
                    bool ae_ = ad_ is CqlInterval<CqlDateTime>;
                    if (ae_)
                    {
                        DataType af_ = HipKneeProcedure?.Performed;
                        object ag_ = FHIRHelpers_4_4_000.Instance.ToValue(context, af_);
                        p_ = ag_ as CqlInterval<CqlDateTime>;
                    }
                    else
                    {
                        DataType ah_ = HipKneeProcedure?.Performed;
                        object ai_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ah_);
                        bool aj_ = ai_ is CqlQuantity;
                        if (aj_)
                        {
                            DataType ak_ = HipKneeProcedure?.Performed;
                            object al_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ak_);
                            p_ = al_ as CqlQuantity;
                        }
                        else
                        {
                            DataType am_ = HipKneeProcedure?.Performed;
                            object an_ = FHIRHelpers_4_4_000.Instance.ToValue(context, am_);
                            bool ao_ = an_ is CqlInterval<CqlQuantity>;
                            if (ao_)
                            {
                                DataType ap_ = HipKneeProcedure?.Performed;
                                object aq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ap_);
                                p_ = aq_ as CqlInterval<CqlQuantity>;
                            }
                            else
                            {
                                p_ = null;
                            }
                        }
                    }
                }
                CqlInterval<CqlDateTime> q_ = QICoreCommon_4_0_000.Instance.toInterval(context, p_);
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
            DataType aq_ = VTERiskAssessment?.Value;
            object ar_ = FHIRHelpers_4_4_000.Instance.ToValue(context, aq_);
            CqlValueSet as_ = this.Low_Risk(context);
            bool? at_ = context.Operators.ConceptInValueSet(ar_ as CqlConcept, as_);
            Code<ObservationStatus> au_ = VTERiskAssessment?.StatusElement;
            ObservationStatus? av_ = au_?.Value;
            string aw_ = context.Operators.Convert<string>(av_);
            string[] ax_ = [
                "final",
                "amended",
                "corrected",
            ];
            bool? ay_ = context.Operators.In<string>(aw_, (IEnumerable<string>)ax_);
            bool? az_ = context.Operators.And(at_, ay_);
            return az_;
        }

        IEnumerable<Observation> e_ = context.Operators.Where<Observation>(c_, d_);

        (CqlTupleMetadata, string id, CqlDateTime LowRiskDatetime)? f_(Observation VTERiskAssessment) {
            Id ba_ = VTERiskAssessment?.IdElement;
            string bb_ = ba_?.Value;
            object bc_;
            DataType bf_ = VTERiskAssessment?.Effective;
            object bg_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bf_);
            bool bh_ = bg_ is CqlDateTime;
            if (bh_)
            {
                DataType bi_ = VTERiskAssessment?.Effective;
                object bj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bi_);
                bc_ = bj_ as CqlDateTime;
            }
            else
            {
                DataType bk_ = VTERiskAssessment?.Effective;
                object bl_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bk_);
                bool bm_ = bl_ is CqlInterval<CqlDateTime>;
                if (bm_)
                {
                    DataType bn_ = VTERiskAssessment?.Effective;
                    object bo_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bn_);
                    bc_ = bo_ as CqlInterval<CqlDateTime>;
                }
                else
                {
                    DataType bp_ = VTERiskAssessment?.Effective;
                    object bq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bp_);
                    bool br_ = bq_ is CqlDateTime;
                    if (br_)
                    {
                        DataType bs_ = VTERiskAssessment?.Effective;
                        object bt_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bs_);
                        bc_ = bt_ as CqlDateTime;
                    }
                    else
                    {
                        bc_ = null;
                    }
                }
            }
            CqlDateTime bd_ = QICoreCommon_4_0_000.Instance.earliest(context, bc_);
            (CqlTupleMetadata, string id, CqlDateTime LowRiskDatetime)? be_ = (CqlTupleMetadata_DMAfXNhTfZDWOGdfEceXbfaSJ, bb_, bd_);
            return be_;
        }

        IEnumerable<(CqlTupleMetadata, string id, CqlDateTime LowRiskDatetime)?> g_ = context.Operators.Select<Observation, (CqlTupleMetadata, string id, CqlDateTime LowRiskDatetime)?>(e_, f_);
        IEnumerable<(CqlTupleMetadata, string id, CqlDateTime LowRiskDatetime)?> h_ = context.Operators.Distinct<(CqlTupleMetadata, string id, CqlDateTime LowRiskDatetime)?>(g_);
        CqlValueSet i_ = this.INR(context);
        IEnumerable<Observation> j_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, i_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation-lab"));

        bool? k_(Observation INRLabTest) {
            DataType bu_ = INRLabTest?.Value;
            object bv_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bu_);
            CqlQuantity bw_ = context.Operators.ConvertDecimalToQuantity(3.0m);
            bool? bx_ = context.Operators.Greater(bv_ as CqlQuantity, bw_);
            Code<ObservationStatus> by_ = INRLabTest?.StatusElement;
            ObservationStatus? bz_ = by_?.Value;
            string ca_ = context.Operators.Convert<string>(bz_);
            string[] cb_ = [
                "final",
                "amended",
                "corrected",
            ];
            bool? cc_ = context.Operators.In<string>(ca_, (IEnumerable<string>)cb_);
            bool? cd_ = context.Operators.And(bx_, cc_);
            return cd_;
        }

        IEnumerable<Observation> l_ = context.Operators.Where<Observation>(j_, k_);

        (CqlTupleMetadata, string id, CqlDateTime LowRiskDatetime)? m_(Observation INRLabTest) {
            Id ce_ = INRLabTest?.IdElement;
            string cf_ = ce_?.Value;
            Instant cg_ = INRLabTest?.IssuedElement;
            DateTimeOffset? ch_ = cg_?.Value;
            CqlDateTime ci_ = context.Operators.Convert<CqlDateTime>(ch_);
            (CqlTupleMetadata, string id, CqlDateTime LowRiskDatetime)? cj_ = (CqlTupleMetadata_DMAfXNhTfZDWOGdfEceXbfaSJ, cf_, ci_);
            return cj_;
        }

        IEnumerable<(CqlTupleMetadata, string id, CqlDateTime LowRiskDatetime)?> n_ = context.Operators.Select<Observation, (CqlTupleMetadata, string id, CqlDateTime LowRiskDatetime)?>(l_, m_);
        IEnumerable<(CqlTupleMetadata, string id, CqlDateTime LowRiskDatetime)?> o_ = context.Operators.Distinct<(CqlTupleMetadata, string id, CqlDateTime LowRiskDatetime)?>(n_);
        IEnumerable<(CqlTupleMetadata, string id, CqlDateTime LowRiskDatetime)?> p_ = context.Operators.Union<(CqlTupleMetadata, string id, CqlDateTime LowRiskDatetime)?>(h_, o_);
        CqlValueSet q_ = this.Unfractionated_Heparin(context);
        IEnumerable<MedicationAdministration> r_ = context.Operators.Retrieve<MedicationAdministration>(new RetrieveParameters(default, q_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationadministration"));
        IEnumerable<MedicationAdministration> s_ = context.Operators.Retrieve<MedicationAdministration>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationadministration"));

        bool? t_(MedicationAdministration MR) {
            IEnumerable<Medication> ck_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));

            bool? cl_(Medication M) {
                object co_ = context.Operators.LateBoundProperty<object>(M, "id.value");
                object cp_ = context.Operators.LateBoundProperty<object>(MR, "medication.reference.value");
                IEnumerable<string> cq_ = context.Operators.Split((string)cp_, "/");
                string cr_ = context.Operators.Last<string>(cq_);
                bool? cs_ = context.Operators.Equal(co_, cr_);
                CodeableConcept ct_ = M?.Code;
                CqlConcept cu_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, ct_);
                CqlValueSet cv_ = this.Unfractionated_Heparin(context);
                bool? cw_ = context.Operators.ConceptInValueSet(cu_, cv_);
                bool? cx_ = context.Operators.And(cs_, cw_);
                return cx_;
            }

            IEnumerable<Medication> cm_ = context.Operators.Where<Medication>(ck_, cl_);
            bool? cn_ = context.Operators.Exists<Medication>(cm_);
            return cn_;
        }

        IEnumerable<MedicationAdministration> u_ = context.Operators.Where<MedicationAdministration>(s_, t_);
        IEnumerable<MedicationAdministration> v_ = context.Operators.Union<MedicationAdministration>(r_, u_);

        bool? w_(MedicationAdministration UnfractionatedHeparin) {
            MedicationAdministration.DosageComponent cy_ = UnfractionatedHeparin?.Dosage;
            CodeableConcept cz_ = cy_?.Route;
            CqlConcept da_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, cz_);
            CqlValueSet db_ = this.Intravenous_route(context);
            bool? dc_ = context.Operators.ConceptInValueSet(da_, db_);
            return dc_;
        }

        IEnumerable<MedicationAdministration> x_ = context.Operators.Where<MedicationAdministration>(v_, w_);
        CqlValueSet y_ = this.Direct_Thrombin_Inhibitor(context);
        IEnumerable<MedicationAdministration> z_ = context.Operators.Retrieve<MedicationAdministration>(new RetrieveParameters(default, y_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationadministration"));

        bool? aa_(MedicationAdministration MR) {
            IEnumerable<Medication> dd_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));

            bool? de_(Medication M) {
                object dh_ = context.Operators.LateBoundProperty<object>(M, "id.value");
                object di_ = context.Operators.LateBoundProperty<object>(MR, "medication.reference.value");
                IEnumerable<string> dj_ = context.Operators.Split((string)di_, "/");
                string dk_ = context.Operators.Last<string>(dj_);
                bool? dl_ = context.Operators.Equal(dh_, dk_);
                CodeableConcept dm_ = M?.Code;
                CqlConcept dn_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, dm_);
                CqlValueSet do_ = this.Direct_Thrombin_Inhibitor(context);
                bool? dp_ = context.Operators.ConceptInValueSet(dn_, do_);
                bool? dq_ = context.Operators.And(dl_, dp_);
                return dq_;
            }

            IEnumerable<Medication> df_ = context.Operators.Where<Medication>(dd_, de_);
            bool? dg_ = context.Operators.Exists<Medication>(df_);
            return dg_;
        }

        IEnumerable<MedicationAdministration> ab_ = context.Operators.Where<MedicationAdministration>(s_, aa_);
        IEnumerable<MedicationAdministration> ac_ = context.Operators.Union<MedicationAdministration>(z_, ab_);
        IEnumerable<MedicationAdministration> ad_ = context.Operators.Union<MedicationAdministration>(x_, ac_);
        CqlValueSet ae_ = this.Glycoprotein_IIb_IIIa_Inhibitors(context);
        IEnumerable<MedicationAdministration> af_ = context.Operators.Retrieve<MedicationAdministration>(new RetrieveParameters(default, ae_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationadministration"));

        bool? ag_(MedicationAdministration MR) {
            IEnumerable<Medication> dr_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));

            bool? ds_(Medication M) {
                object dv_ = context.Operators.LateBoundProperty<object>(M, "id.value");
                object dw_ = context.Operators.LateBoundProperty<object>(MR, "medication.reference.value");
                IEnumerable<string> dx_ = context.Operators.Split((string)dw_, "/");
                string dy_ = context.Operators.Last<string>(dx_);
                bool? dz_ = context.Operators.Equal(dv_, dy_);
                CodeableConcept ea_ = M?.Code;
                CqlConcept eb_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, ea_);
                CqlValueSet ec_ = this.Glycoprotein_IIb_IIIa_Inhibitors(context);
                bool? ed_ = context.Operators.ConceptInValueSet(eb_, ec_);
                bool? ee_ = context.Operators.And(dz_, ed_);
                return ee_;
            }

            IEnumerable<Medication> dt_ = context.Operators.Where<Medication>(dr_, ds_);
            bool? du_ = context.Operators.Exists<Medication>(dt_);
            return du_;
        }

        IEnumerable<MedicationAdministration> ah_ = context.Operators.Where<MedicationAdministration>(s_, ag_);
        IEnumerable<MedicationAdministration> ai_ = context.Operators.Union<MedicationAdministration>(af_, ah_);
        IEnumerable<MedicationAdministration> aj_ = context.Operators.Union<MedicationAdministration>(ad_, ai_);

        bool? ak_(MedicationAdministration AnticoagulantMedication) {
            Code<MedicationAdministration.MedicationAdministrationStatusCodes> ef_ = AnticoagulantMedication?.StatusElement;
            MedicationAdministration.MedicationAdministrationStatusCodes? eg_ = ef_?.Value;
            string eh_ = context.Operators.Convert<string>(eg_);
            bool? ei_ = context.Operators.Equal(eh_, "completed");
            return ei_;
        }

        IEnumerable<MedicationAdministration> al_ = context.Operators.Where<MedicationAdministration>(aj_, ak_);

        (CqlTupleMetadata, string id, CqlDateTime LowRiskDatetime)? am_(MedicationAdministration AnticoagulantMedication) {
            Id ej_ = AnticoagulantMedication?.IdElement;
            string ek_ = ej_?.Value;
            DataType el_ = AnticoagulantMedication?.Effective;
            object em_ = FHIRHelpers_4_4_000.Instance.ToValue(context, el_);
            CqlInterval<CqlDateTime> en_ = QICoreCommon_4_0_000.Instance.toInterval(context, em_);
            CqlDateTime eo_ = context.Operators.Start(en_);
            (CqlTupleMetadata, string id, CqlDateTime LowRiskDatetime)? ep_ = (CqlTupleMetadata_DMAfXNhTfZDWOGdfEceXbfaSJ, ek_, eo_);
            return ep_;
        }

        IEnumerable<(CqlTupleMetadata, string id, CqlDateTime LowRiskDatetime)?> an_ = context.Operators.Select<MedicationAdministration, (CqlTupleMetadata, string id, CqlDateTime LowRiskDatetime)?>(al_, am_);
        IEnumerable<(CqlTupleMetadata, string id, CqlDateTime LowRiskDatetime)?> ao_ = context.Operators.Distinct<(CqlTupleMetadata, string id, CqlDateTime LowRiskDatetime)?>(an_);
        IEnumerable<(CqlTupleMetadata, string id, CqlDateTime LowRiskDatetime)?> ap_ = context.Operators.Union<(CqlTupleMetadata, string id, CqlDateTime LowRiskDatetime)?>(p_, ao_);
        return ap_;
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
                CqlDate l_ = i_?.high;
                CqlDateTime m_ = context.Operators.ConvertDateToDateTime(l_);
                bool? n_ = i_?.lowClosed;
                bool? o_ = i_?.highClosed;
                CqlInterval<CqlDateTime> p_ = context.Operators.Interval(k_, m_, n_, o_);
                bool? q_ = context.Operators.In<CqlDateTime>(h_, p_, "day");
                return q_;
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
            object r_;
            DataType bb_ = tuple_gwhjghwetinfdseedvamgjivv?.AnesthesiaProcedure?.Performed;
            object bc_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bb_);
            bool bd_ = bc_ is CqlDateTime;
            if (bd_)
            {
                DataType be_ = tuple_gwhjghwetinfdseedvamgjivv?.AnesthesiaProcedure?.Performed;
                object bf_ = FHIRHelpers_4_4_000.Instance.ToValue(context, be_);
                r_ = bf_ as CqlDateTime;
            }
            else
            {
                DataType bg_ = tuple_gwhjghwetinfdseedvamgjivv?.AnesthesiaProcedure?.Performed;
                object bh_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bg_);
                bool bi_ = bh_ is CqlInterval<CqlDateTime>;
                if (bi_)
                {
                    DataType bj_ = tuple_gwhjghwetinfdseedvamgjivv?.AnesthesiaProcedure?.Performed;
                    object bk_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bj_);
                    r_ = bk_ as CqlInterval<CqlDateTime>;
                }
                else
                {
                    DataType bl_ = tuple_gwhjghwetinfdseedvamgjivv?.AnesthesiaProcedure?.Performed;
                    object bm_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bl_);
                    bool bn_ = bm_ is CqlQuantity;
                    if (bn_)
                    {
                        DataType bo_ = tuple_gwhjghwetinfdseedvamgjivv?.AnesthesiaProcedure?.Performed;
                        object bp_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bo_);
                        r_ = bp_ as CqlQuantity;
                    }
                    else
                    {
                        DataType bq_ = tuple_gwhjghwetinfdseedvamgjivv?.AnesthesiaProcedure?.Performed;
                        object br_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bq_);
                        bool bs_ = br_ is CqlInterval<CqlQuantity>;
                        if (bs_)
                        {
                            DataType bt_ = tuple_gwhjghwetinfdseedvamgjivv?.AnesthesiaProcedure?.Performed;
                            object bu_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bt_);
                            r_ = bu_ as CqlInterval<CqlQuantity>;
                        }
                        else
                        {
                            r_ = null;
                        }
                    }
                }
            }
            CqlInterval<CqlDateTime> s_ = QICoreCommon_4_0_000.Instance.toInterval(context, r_);
            CqlDateTime t_ = context.Operators.End(s_);
            Period u_ = tuple_gwhjghwetinfdseedvamgjivv?.QualifyingEncounter?.Period;
            CqlInterval<CqlDateTime> v_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, u_);
            CqlDateTime w_ = context.Operators.Start(v_);
            CqlQuantity x_ = context.Operators.Quantity(1m, "day");
            CqlDateTime y_ = context.Operators.Add(w_, x_);
            bool? z_ = context.Operators.SameAs(t_, y_, "day");
            bool? aa_ = context.Operators.And(q_, z_);
            CqlDateTime ab_ = tuple_gwhjghwetinfdseedvamgjivv?.LowRiskForVTE?.LowRiskDatetime;
            object ac_;
            DataType bv_ = tuple_gwhjghwetinfdseedvamgjivv?.AnesthesiaProcedure?.Performed;
            object bw_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bv_);
            bool bx_ = bw_ is CqlDateTime;
            if (bx_)
            {
                DataType by_ = tuple_gwhjghwetinfdseedvamgjivv?.AnesthesiaProcedure?.Performed;
                object bz_ = FHIRHelpers_4_4_000.Instance.ToValue(context, by_);
                ac_ = bz_ as CqlDateTime;
            }
            else
            {
                DataType ca_ = tuple_gwhjghwetinfdseedvamgjivv?.AnesthesiaProcedure?.Performed;
                object cb_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ca_);
                bool cc_ = cb_ is CqlInterval<CqlDateTime>;
                if (cc_)
                {
                    DataType cd_ = tuple_gwhjghwetinfdseedvamgjivv?.AnesthesiaProcedure?.Performed;
                    object ce_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cd_);
                    ac_ = ce_ as CqlInterval<CqlDateTime>;
                }
                else
                {
                    DataType cf_ = tuple_gwhjghwetinfdseedvamgjivv?.AnesthesiaProcedure?.Performed;
                    object cg_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cf_);
                    bool ch_ = cg_ is CqlQuantity;
                    if (ch_)
                    {
                        DataType ci_ = tuple_gwhjghwetinfdseedvamgjivv?.AnesthesiaProcedure?.Performed;
                        object cj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ci_);
                        ac_ = cj_ as CqlQuantity;
                    }
                    else
                    {
                        DataType ck_ = tuple_gwhjghwetinfdseedvamgjivv?.AnesthesiaProcedure?.Performed;
                        object cl_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ck_);
                        bool cm_ = cl_ is CqlInterval<CqlQuantity>;
                        if (cm_)
                        {
                            DataType cn_ = tuple_gwhjghwetinfdseedvamgjivv?.AnesthesiaProcedure?.Performed;
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
            DataType cp_ = tuple_gwhjghwetinfdseedvamgjivv?.AnesthesiaProcedure?.Performed;
            object cq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cp_);
            bool cr_ = cq_ is CqlDateTime;
            if (cr_)
            {
                DataType cs_ = tuple_gwhjghwetinfdseedvamgjivv?.AnesthesiaProcedure?.Performed;
                object ct_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cs_);
                ai_ = ct_ as CqlDateTime;
            }
            else
            {
                DataType cu_ = tuple_gwhjghwetinfdseedvamgjivv?.AnesthesiaProcedure?.Performed;
                object cv_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cu_);
                bool cw_ = cv_ is CqlInterval<CqlDateTime>;
                if (cw_)
                {
                    DataType cx_ = tuple_gwhjghwetinfdseedvamgjivv?.AnesthesiaProcedure?.Performed;
                    object cy_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cx_);
                    ai_ = cy_ as CqlInterval<CqlDateTime>;
                }
                else
                {
                    DataType cz_ = tuple_gwhjghwetinfdseedvamgjivv?.AnesthesiaProcedure?.Performed;
                    object da_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cz_);
                    bool db_ = da_ is CqlQuantity;
                    if (db_)
                    {
                        DataType dc_ = tuple_gwhjghwetinfdseedvamgjivv?.AnesthesiaProcedure?.Performed;
                        object dd_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dc_);
                        ai_ = dd_ as CqlQuantity;
                    }
                    else
                    {
                        DataType de_ = tuple_gwhjghwetinfdseedvamgjivv?.AnesthesiaProcedure?.Performed;
                        object df_ = FHIRHelpers_4_4_000.Instance.ToValue(context, de_);
                        bool dg_ = df_ is CqlInterval<CqlQuantity>;
                        if (dg_)
                        {
                            DataType dh_ = tuple_gwhjghwetinfdseedvamgjivv?.AnesthesiaProcedure?.Performed;
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
            DataType dj_ = tuple_gwhjghwetinfdseedvamgjivv?.AnesthesiaProcedure?.Performed;
            object dk_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dj_);
            bool dl_ = dk_ is CqlDateTime;
            if (dl_)
            {
                DataType dm_ = tuple_gwhjghwetinfdseedvamgjivv?.AnesthesiaProcedure?.Performed;
                object dn_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dm_);
                ao_ = dn_ as CqlDateTime;
            }
            else
            {
                DataType do_ = tuple_gwhjghwetinfdseedvamgjivv?.AnesthesiaProcedure?.Performed;
                object dp_ = FHIRHelpers_4_4_000.Instance.ToValue(context, do_);
                bool dq_ = dp_ is CqlInterval<CqlDateTime>;
                if (dq_)
                {
                    DataType dr_ = tuple_gwhjghwetinfdseedvamgjivv?.AnesthesiaProcedure?.Performed;
                    object ds_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dr_);
                    ao_ = ds_ as CqlInterval<CqlDateTime>;
                }
                else
                {
                    DataType dt_ = tuple_gwhjghwetinfdseedvamgjivv?.AnesthesiaProcedure?.Performed;
                    object du_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dt_);
                    bool dv_ = du_ is CqlQuantity;
                    if (dv_)
                    {
                        DataType dw_ = tuple_gwhjghwetinfdseedvamgjivv?.AnesthesiaProcedure?.Performed;
                        object dx_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dw_);
                        ao_ = dx_ as CqlQuantity;
                    }
                    else
                    {
                        DataType dy_ = tuple_gwhjghwetinfdseedvamgjivv?.AnesthesiaProcedure?.Performed;
                        object dz_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dy_);
                        bool ea_ = dz_ is CqlInterval<CqlQuantity>;
                        if (ea_)
                        {
                            DataType eb_ = tuple_gwhjghwetinfdseedvamgjivv?.AnesthesiaProcedure?.Performed;
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
            DataType ed_ = tuple_gwhjghwetinfdseedvamgjivv?.AnesthesiaProcedure?.Performed;
            object ee_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ed_);
            bool ef_ = ee_ is CqlDateTime;
            if (ef_)
            {
                DataType eg_ = tuple_gwhjghwetinfdseedvamgjivv?.AnesthesiaProcedure?.Performed;
                object eh_ = FHIRHelpers_4_4_000.Instance.ToValue(context, eg_);
                at_ = eh_ as CqlDateTime;
            }
            else
            {
                DataType ei_ = tuple_gwhjghwetinfdseedvamgjivv?.AnesthesiaProcedure?.Performed;
                object ej_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ei_);
                bool ek_ = ej_ is CqlInterval<CqlDateTime>;
                if (ek_)
                {
                    DataType el_ = tuple_gwhjghwetinfdseedvamgjivv?.AnesthesiaProcedure?.Performed;
                    object em_ = FHIRHelpers_4_4_000.Instance.ToValue(context, el_);
                    at_ = em_ as CqlInterval<CqlDateTime>;
                }
                else
                {
                    DataType en_ = tuple_gwhjghwetinfdseedvamgjivv?.AnesthesiaProcedure?.Performed;
                    object eo_ = FHIRHelpers_4_4_000.Instance.ToValue(context, en_);
                    bool ep_ = eo_ is CqlQuantity;
                    if (ep_)
                    {
                        DataType eq_ = tuple_gwhjghwetinfdseedvamgjivv?.AnesthesiaProcedure?.Performed;
                        object er_ = FHIRHelpers_4_4_000.Instance.ToValue(context, eq_);
                        at_ = er_ as CqlQuantity;
                    }
                    else
                    {
                        DataType es_ = tuple_gwhjghwetinfdseedvamgjivv?.AnesthesiaProcedure?.Performed;
                        object et_ = FHIRHelpers_4_4_000.Instance.ToValue(context, es_);
                        bool eu_ = et_ is CqlInterval<CqlQuantity>;
                        if (eu_)
                        {
                            DataType ev_ = tuple_gwhjghwetinfdseedvamgjivv?.AnesthesiaProcedure?.Performed;
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
            Id cb_ = NoMedicationAdm?.IdElement;
            string cc_ = cb_?.Value;
            List<CodeableConcept> cd_ = NoMedicationAdm?.StatusReason;

            CqlConcept ce_(CodeableConcept @this) {
                CqlConcept cn_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);
                return cn_;
            }

            IEnumerable<CqlConcept> cf_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)cd_, ce_);

            bool? cg_(Extension @this) {
                FhirUri co_ = @this?.UrlElement;
                string cp_ = FHIRHelpers_4_4_000.Instance.ToString(context, co_);
                bool? cq_ = context.Operators.Equal(cp_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-recorded");
                return cq_;
            }

            IEnumerable<Extension> ch_ = context.Operators.Where<Extension>((IEnumerable<Extension>)(NoMedicationAdm is DomainResource
                ? (NoMedicationAdm as DomainResource).Extension
                : default), cg_);

            DataType ci_(Extension @this) {
                DataType cr_ = @this?.Value;
                return cr_;
            }

            IEnumerable<DataType> cj_ = context.Operators.Select<Extension, DataType>(ch_, ci_);
            DataType ck_ = context.Operators.SingletonFrom<DataType>(cj_);
            FhirDateTime cl_ = context.Operators.Convert<FhirDateTime>(ck_);
            (CqlTupleMetadata, string id, IEnumerable<CqlConcept> medicationStatusReason, FhirDateTime authoredOn)? cm_ = (CqlTupleMetadata_EBcSahXYZdeFjUUbgULReCZAe, cc_, cf_, cl_);
            return cm_;
        }

        IEnumerable<(CqlTupleMetadata, string id, IEnumerable<CqlConcept> medicationStatusReason, FhirDateTime authoredOn)?> u_ = context.Operators.Select<MedicationAdministration, (CqlTupleMetadata, string id, IEnumerable<CqlConcept> medicationStatusReason, FhirDateTime authoredOn)?>(s_, t_);
        IEnumerable<(CqlTupleMetadata, string id, IEnumerable<CqlConcept> medicationStatusReason, FhirDateTime authoredOn)?> v_ = context.Operators.Distinct<(CqlTupleMetadata, string id, IEnumerable<CqlConcept> medicationStatusReason, FhirDateTime authoredOn)?>(u_);
        IEnumerable<MedicationRequest> w_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationnotrequested"));
        IEnumerable<MedicationRequest> x_ = context.Operators.Union<MedicationRequest>(w_, w_);
        IEnumerable<MedicationRequest> y_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, d_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationnotrequested"));
        IEnumerable<MedicationRequest> z_ = context.Operators.Union<MedicationRequest>(y_, y_);
        IEnumerable<MedicationRequest> aa_ = context.Operators.Union<MedicationRequest>(x_, z_);
        IEnumerable<MedicationRequest> ab_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, h_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationnotrequested"));
        IEnumerable<MedicationRequest> ac_ = context.Operators.Union<MedicationRequest>(ab_, ab_);
        IEnumerable<MedicationRequest> ad_ = context.Operators.Union<MedicationRequest>(aa_, ac_);
        IEnumerable<MedicationRequest> ae_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, l_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationnotrequested"));
        IEnumerable<MedicationRequest> af_ = context.Operators.Union<MedicationRequest>(ae_, ae_);
        IEnumerable<MedicationRequest> ag_ = context.Operators.Union<MedicationRequest>(ad_, af_);
        IEnumerable<MedicationRequest> ah_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, p_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationnotrequested"));
        IEnumerable<MedicationRequest> ai_ = context.Operators.Union<MedicationRequest>(ah_, ah_);
        IEnumerable<MedicationRequest> aj_ = context.Operators.Union<MedicationRequest>(ag_, ai_);

        bool? ak_(MedicationRequest NoMedicationOrder) {
            Code<MedicationRequest.MedicationRequestIntent> cs_ = NoMedicationOrder?.IntentElement;
            MedicationRequest.MedicationRequestIntent? ct_ = cs_?.Value;
            string cu_ = context.Operators.Convert<string>(ct_);
            string[] cv_ = [
                "order",
                "original-order",
                "reflex-order",
                "filler-order",
                "instance-order",
            ];
            bool? cw_ = context.Operators.In<string>(cu_, (IEnumerable<string>)cv_);
            Code<MedicationRequest.MedicationrequestStatus> cx_ = NoMedicationOrder?.StatusElement;
            MedicationRequest.MedicationrequestStatus? cy_ = cx_?.Value;
            string cz_ = context.Operators.Convert<string>(cy_);
            string[] da_ = [
                "active",
                "completed",
            ];
            bool? db_ = context.Operators.In<string>(cz_, (IEnumerable<string>)da_);
            bool? dc_ = context.Operators.And(cw_, db_);
            return dc_;
        }

        IEnumerable<MedicationRequest> al_ = context.Operators.Where<MedicationRequest>(aj_, ak_);

        (CqlTupleMetadata, string id, IEnumerable<CqlConcept> medicationStatusReason, CqlDateTime authoredOn)? am_(MedicationRequest NoMedicationOrder) {
            Id dd_ = NoMedicationOrder?.IdElement;
            string de_ = dd_?.Value;
            List<CodeableConcept> df_ = NoMedicationOrder?.ReasonCode;

            CqlConcept dg_(CodeableConcept @this) {
                CqlConcept dl_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);
                return dl_;
            }

            IEnumerable<CqlConcept> dh_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)df_, dg_);
            FhirDateTime di_ = NoMedicationOrder?.AuthoredOnElement;
            CqlDateTime dj_ = context.Operators.Convert<CqlDateTime>(di_);
            (CqlTupleMetadata, string id, IEnumerable<CqlConcept> medicationStatusReason, CqlDateTime authoredOn)? dk_ = (CqlTupleMetadata_CNeQfiIHcQEUBjZNVZiOLfdeP, de_, dh_, dj_);
            return dk_;
        }

        IEnumerable<(CqlTupleMetadata, string id, IEnumerable<CqlConcept> medicationStatusReason, CqlDateTime authoredOn)?> an_ = context.Operators.Select<MedicationRequest, (CqlTupleMetadata, string id, IEnumerable<CqlConcept> medicationStatusReason, CqlDateTime authoredOn)?>(al_, am_);
        IEnumerable<(CqlTupleMetadata, string id, IEnumerable<CqlConcept> medicationStatusReason, CqlDateTime authoredOn)?> ao_ = context.Operators.Distinct<(CqlTupleMetadata, string id, IEnumerable<CqlConcept> medicationStatusReason, CqlDateTime authoredOn)?>(an_);
        IEnumerable<object> ap_ = context.Operators.Union<object>(v_ as IEnumerable<object>, ao_ as IEnumerable<object>);
        (CqlTupleMetadata, string id, IEnumerable<CqlConcept> medicationStatusReason, CqlDateTime authoredOn)? aq_(object @object) => ((CqlTupleMetadata, string id, IEnumerable<CqlConcept> medicationStatusReason, CqlDateTime authoredOn)?)@object;
        IEnumerable<(CqlTupleMetadata, string id, IEnumerable<CqlConcept> medicationStatusReason, CqlDateTime authoredOn)?> ar_ = context.Operators.Select<object, (CqlTupleMetadata, string id, IEnumerable<CqlConcept> medicationStatusReason, CqlDateTime authoredOn)?>(ap_, aq_);
        IEnumerable<MedicationRequest> as_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> at_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));

        bool? au_(MedicationRequest MR) {
            IEnumerable<Medication> dm_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));

            bool? dn_(Medication M) {
                object dq_ = context.Operators.LateBoundProperty<object>(M, "id.value");
                object dr_ = context.Operators.LateBoundProperty<object>(MR, "medication.reference.value");
                IEnumerable<string> ds_ = context.Operators.Split((string)dr_, "/");
                string dt_ = context.Operators.Last<string>(ds_);
                bool? du_ = context.Operators.Equal(dq_, dt_);
                CodeableConcept dv_ = M?.Code;
                CqlConcept dw_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, dv_);
                CqlValueSet dx_ = this.Low_Dose_Unfractionated_Heparin_for_VTE_Prophylaxis(context);
                bool? dy_ = context.Operators.ConceptInValueSet(dw_, dx_);
                bool? dz_ = context.Operators.And(du_, dy_);
                return dz_;
            }

            IEnumerable<Medication> do_ = context.Operators.Where<Medication>(dm_, dn_);
            bool? dp_ = context.Operators.Exists<Medication>(do_);
            return dp_;
        }

        IEnumerable<MedicationRequest> av_ = context.Operators.Where<MedicationRequest>(at_, au_);
        IEnumerable<MedicationRequest> aw_ = context.Operators.Union<MedicationRequest>(as_, av_);
        IEnumerable<MedicationRequest> ax_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, d_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));

        bool? ay_(MedicationRequest MR) {
            IEnumerable<Medication> ea_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));

            bool? eb_(Medication M) {
                object ee_ = context.Operators.LateBoundProperty<object>(M, "id.value");
                object ef_ = context.Operators.LateBoundProperty<object>(MR, "medication.reference.value");
                IEnumerable<string> eg_ = context.Operators.Split((string)ef_, "/");
                string eh_ = context.Operators.Last<string>(eg_);
                bool? ei_ = context.Operators.Equal(ee_, eh_);
                CodeableConcept ej_ = M?.Code;
                CqlConcept ek_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, ej_);
                CqlValueSet el_ = this.Low_Molecular_Weight_Heparin_for_VTE_Prophylaxis(context);
                bool? em_ = context.Operators.ConceptInValueSet(ek_, el_);
                bool? en_ = context.Operators.And(ei_, em_);
                return en_;
            }

            IEnumerable<Medication> ec_ = context.Operators.Where<Medication>(ea_, eb_);
            bool? ed_ = context.Operators.Exists<Medication>(ec_);
            return ed_;
        }

        IEnumerable<MedicationRequest> az_ = context.Operators.Where<MedicationRequest>(at_, ay_);
        IEnumerable<MedicationRequest> ba_ = context.Operators.Union<MedicationRequest>(ax_, az_);
        IEnumerable<MedicationRequest> bb_ = context.Operators.Union<MedicationRequest>(aw_, ba_);
        IEnumerable<MedicationRequest> bc_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, h_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));

        bool? bd_(MedicationRequest MR) {
            IEnumerable<Medication> eo_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));

            bool? ep_(Medication M) {
                object es_ = context.Operators.LateBoundProperty<object>(M, "id.value");
                object et_ = context.Operators.LateBoundProperty<object>(MR, "medication.reference.value");
                IEnumerable<string> eu_ = context.Operators.Split((string)et_, "/");
                string ev_ = context.Operators.Last<string>(eu_);
                bool? ew_ = context.Operators.Equal(es_, ev_);
                CodeableConcept ex_ = M?.Code;
                CqlConcept ey_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, ex_);
                CqlValueSet ez_ = this.Injectable_Factor_Xa_Inhibitor_for_VTE_Prophylaxis(context);
                bool? fa_ = context.Operators.ConceptInValueSet(ey_, ez_);
                bool? fb_ = context.Operators.And(ew_, fa_);
                return fb_;
            }

            IEnumerable<Medication> eq_ = context.Operators.Where<Medication>(eo_, ep_);
            bool? er_ = context.Operators.Exists<Medication>(eq_);
            return er_;
        }

        IEnumerable<MedicationRequest> be_ = context.Operators.Where<MedicationRequest>(at_, bd_);
        IEnumerable<MedicationRequest> bf_ = context.Operators.Union<MedicationRequest>(bc_, be_);
        IEnumerable<MedicationRequest> bg_ = context.Operators.Union<MedicationRequest>(bb_, bf_);
        IEnumerable<MedicationRequest> bh_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, l_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));

        bool? bi_(MedicationRequest MR) {
            IEnumerable<Medication> fc_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));

            bool? fd_(Medication M) {
                object fg_ = context.Operators.LateBoundProperty<object>(M, "id.value");
                object fh_ = context.Operators.LateBoundProperty<object>(MR, "medication.reference.value");
                IEnumerable<string> fi_ = context.Operators.Split((string)fh_, "/");
                string fj_ = context.Operators.Last<string>(fi_);
                bool? fk_ = context.Operators.Equal(fg_, fj_);
                CodeableConcept fl_ = M?.Code;
                CqlConcept fm_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, fl_);
                CqlValueSet fn_ = this.Warfarin(context);
                bool? fo_ = context.Operators.ConceptInValueSet(fm_, fn_);
                bool? fp_ = context.Operators.And(fk_, fo_);
                return fp_;
            }

            IEnumerable<Medication> fe_ = context.Operators.Where<Medication>(fc_, fd_);
            bool? ff_ = context.Operators.Exists<Medication>(fe_);
            return ff_;
        }

        IEnumerable<MedicationRequest> bj_ = context.Operators.Where<MedicationRequest>(at_, bi_);
        IEnumerable<MedicationRequest> bk_ = context.Operators.Union<MedicationRequest>(bh_, bj_);
        IEnumerable<MedicationRequest> bl_ = context.Operators.Union<MedicationRequest>(bg_, bk_);
        IEnumerable<MedicationRequest> bm_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, p_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));

        bool? bn_(MedicationRequest MR) {
            IEnumerable<Medication> fq_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));

            bool? fr_(Medication M) {
                object fu_ = context.Operators.LateBoundProperty<object>(M, "id.value");
                object fv_ = context.Operators.LateBoundProperty<object>(MR, "medication.reference.value");
                IEnumerable<string> fw_ = context.Operators.Split((string)fv_, "/");
                string fx_ = context.Operators.Last<string>(fw_);
                bool? fy_ = context.Operators.Equal(fu_, fx_);
                CodeableConcept fz_ = M?.Code;
                CqlConcept ga_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, fz_);
                CqlValueSet gb_ = this.Rivaroxaban_for_VTE_Prophylaxis(context);
                bool? gc_ = context.Operators.ConceptInValueSet(ga_, gb_);
                bool? gd_ = context.Operators.And(fy_, gc_);
                return gd_;
            }

            IEnumerable<Medication> fs_ = context.Operators.Where<Medication>(fq_, fr_);
            bool? ft_ = context.Operators.Exists<Medication>(fs_);
            return ft_;
        }

        IEnumerable<MedicationRequest> bo_ = context.Operators.Where<MedicationRequest>(at_, bn_);
        IEnumerable<MedicationRequest> bp_ = context.Operators.Union<MedicationRequest>(bm_, bo_);
        IEnumerable<MedicationRequest> bq_ = context.Operators.Union<MedicationRequest>(bl_, bp_);
        IEnumerable<Task> br_ = context.Operators.Retrieve<Task>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-taskrejected"));
        IEnumerable<ValueTuple<MedicationRequest, Task>> bs_ = context.Operators.CrossJoin<MedicationRequest, Task>(bq_, br_);

        (CqlTupleMetadata, MedicationRequest MedicationOrderReject, Task T)? bt_(ValueTuple<MedicationRequest, Task> _valueTuple) {
            (CqlTupleMetadata, MedicationRequest MedicationOrderReject, Task T)? ge_ = (CqlTupleMetadata_IIUQMBcJhJBPgdDOLHaTTRUE, _valueTuple.Item1, _valueTuple.Item2);
            return ge_;
        }

        IEnumerable<(CqlTupleMetadata, MedicationRequest MedicationOrderReject, Task T)?> bu_ = context.Operators.Select<ValueTuple<MedicationRequest, Task>, (CqlTupleMetadata, MedicationRequest MedicationOrderReject, Task T)?>(bs_, bt_);

        bool? bv_((CqlTupleMetadata, MedicationRequest MedicationOrderReject, Task T)? tuple_iiuqmbcjhjbpgddolhattrue) {
            ResourceReference gf_ = tuple_iiuqmbcjhjbpgddolhattrue?.T?.Focus;
            bool? gg_ = QICoreCommon_4_0_000.Instance.references(context, gf_, tuple_iiuqmbcjhjbpgddolhattrue?.MedicationOrderReject);
            CodeableConcept gh_ = tuple_iiuqmbcjhjbpgddolhattrue?.T?.Code;
            CqlConcept gi_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, gh_);
            CqlCode gj_ = QICoreCommon_4_0_000.Instance.Fulfill(context);
            CqlConcept gk_ = context.Operators.ConvertCodeToConcept(gj_);
            bool? gl_ = context.Operators.Equivalent(gi_, gk_);
            bool? gm_ = context.Operators.And(gg_, gl_);
            Code<MedicationRequest.MedicationrequestStatus> gn_ = tuple_iiuqmbcjhjbpgddolhattrue?.MedicationOrderReject?.StatusElement;
            MedicationRequest.MedicationrequestStatus? go_ = gn_?.Value;
            string gp_ = context.Operators.Convert<string>(go_);
            bool? gq_ = context.Operators.Equal(gp_, "active");
            bool? gr_ = context.Operators.And(gm_, gq_);
            return gr_;
        }

        IEnumerable<(CqlTupleMetadata, MedicationRequest MedicationOrderReject, Task T)?> bw_ = context.Operators.Where<(CqlTupleMetadata, MedicationRequest MedicationOrderReject, Task T)?>(bu_, bv_);

        (CqlTupleMetadata, string id, IEnumerable<CqlConcept> medicationStatusReason, CqlDateTime authoredOn)? bx_((CqlTupleMetadata, MedicationRequest MedicationOrderReject, Task T)? tuple_iiuqmbcjhjbpgddolhattrue) {
            Id gs_ = tuple_iiuqmbcjhjbpgddolhattrue?.MedicationOrderReject?.IdElement;
            string gt_ = gs_?.Value;
            CodeableConcept gu_ = tuple_iiuqmbcjhjbpgddolhattrue?.T?.StatusReason;
            CqlConcept gv_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, gu_);
            CqlConcept[] gw_ = [
                gv_,
            ];
            FhirDateTime gx_ = tuple_iiuqmbcjhjbpgddolhattrue?.MedicationOrderReject?.AuthoredOnElement;
            CqlDateTime gy_ = context.Operators.Convert<CqlDateTime>(gx_);
            (CqlTupleMetadata, string id, IEnumerable<CqlConcept> medicationStatusReason, CqlDateTime authoredOn)? gz_ = (CqlTupleMetadata_CNeQfiIHcQEUBjZNVZiOLfdeP, gt_, (IEnumerable<CqlConcept>)gw_, gy_);
            return gz_;
        }

        IEnumerable<(CqlTupleMetadata, string id, IEnumerable<CqlConcept> medicationStatusReason, CqlDateTime authoredOn)?> by_ = context.Operators.Select<(CqlTupleMetadata, MedicationRequest MedicationOrderReject, Task T)?, (CqlTupleMetadata, string id, IEnumerable<CqlConcept> medicationStatusReason, CqlDateTime authoredOn)?>(bw_, bx_);
        IEnumerable<(CqlTupleMetadata, string id, IEnumerable<CqlConcept> medicationStatusReason, CqlDateTime authoredOn)?> bz_ = context.Operators.Distinct<(CqlTupleMetadata, string id, IEnumerable<CqlConcept> medicationStatusReason, CqlDateTime authoredOn)?>(by_);
        IEnumerable<(CqlTupleMetadata, string id, IEnumerable<CqlConcept> medicationStatusReason, CqlDateTime authoredOn)?> ca_ = context.Operators.Union<(CqlTupleMetadata, string id, IEnumerable<CqlConcept> medicationStatusReason, CqlDateTime authoredOn)?>(ar_, bz_);
        return ca_;
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
                CqlDate o_ = l_?.high;
                CqlDateTime p_ = context.Operators.ConvertDateToDateTime(o_);
                bool? q_ = l_?.lowClosed;
                bool? r_ = l_?.highClosed;
                CqlInterval<CqlDateTime> s_ = context.Operators.Interval(n_, p_, q_, r_);
                bool? t_ = context.Operators.In<CqlDateTime>(k_, s_, "day");
                bool? u_ = context.Operators.And(j_, t_);
                return u_;
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
            Code<RequestIntent> ay_ = DeviceNotOrder?.IntentElement;
            RequestIntent? az_ = ay_?.Value;
            Code<RequestIntent> ba_ = context.Operators.Convert<Code<RequestIntent>>(az_);
            string bb_ = context.Operators.Convert<string>(ba_);
            string[] bc_ = [
                "order",
                "original-order",
                "reflex-order",
                "filler-order",
                "instance-order",
            ];
            bool? bd_ = context.Operators.In<string>(bb_, (IEnumerable<string>)bc_);
            return bd_;
        }

        IEnumerable<ServiceRequest> m_ = context.Operators.Where<ServiceRequest>(k_, l_);

        (CqlTupleMetadata, string id, CodeableConcept requestStatusReason, CqlDateTime authoredOn)? n_(ServiceRequest DeviceNotOrder) {
            Id be_ = DeviceNotOrder?.IdElement;
            string bf_ = be_?.Value;

            bool? bg_(Extension @this) {
                FhirUri bq_ = @this?.UrlElement;
                string br_ = FHIRHelpers_4_4_000.Instance.ToString(context, bq_);
                bool? bs_ = context.Operators.Equal(br_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-doNotPerformReason");
                return bs_;
            }

            IEnumerable<Extension> bh_ = context.Operators.Where<Extension>((IEnumerable<Extension>)(DeviceNotOrder is DomainResource
                ? (DeviceNotOrder as DomainResource).Extension
                : default), bg_);

            object bi_(Extension @this) {
                DataType bt_ = @this?.Value;
                return bt_;
            }

            IEnumerable<object> bj_ = context.Operators.Select<Extension, object>(bh_, bi_);
            object bk_ = context.Operators.SingletonFrom<object>(bj_);
            CqlConcept bl_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, bk_ as CodeableConcept);
            CodeableConcept bm_ = context.Operators.Convert<CodeableConcept>(bl_);
            FhirDateTime bn_ = DeviceNotOrder?.AuthoredOnElement;
            CqlDateTime bo_ = context.Operators.Convert<CqlDateTime>(bn_);
            (CqlTupleMetadata, string id, CodeableConcept requestStatusReason, CqlDateTime authoredOn)? bp_ = (CqlTupleMetadata_FVDRPQjOQgYIDhWKHCNhOHceF, bf_, bm_, bo_);
            return bp_;
        }

        IEnumerable<(CqlTupleMetadata, string id, CodeableConcept requestStatusReason, CqlDateTime authoredOn)?> o_ = context.Operators.Select<ServiceRequest, (CqlTupleMetadata, string id, CodeableConcept requestStatusReason, CqlDateTime authoredOn)?>(m_, n_);
        IEnumerable<(CqlTupleMetadata, string id, CodeableConcept requestStatusReason, CqlDateTime authoredOn)?> p_ = context.Operators.Distinct<(CqlTupleMetadata, string id, CodeableConcept requestStatusReason, CqlDateTime authoredOn)?>(o_);
        IEnumerable<ServiceRequest> q_ = context.Operators.Retrieve<ServiceRequest>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-servicerequest"));
        IEnumerable<ServiceRequest> r_ = context.Operators.Retrieve<ServiceRequest>(new RetrieveParameters(default, d_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-servicerequest"));
        IEnumerable<ServiceRequest> s_ = context.Operators.Union<ServiceRequest>(q_, r_);
        IEnumerable<ServiceRequest> t_ = context.Operators.Retrieve<ServiceRequest>(new RetrieveParameters(default, h_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-servicerequest"));
        IEnumerable<ServiceRequest> u_ = context.Operators.Union<ServiceRequest>(s_, t_);
        IEnumerable<Task> v_ = context.Operators.Retrieve<Task>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-taskrejected"));
        IEnumerable<ValueTuple<ServiceRequest, Task>> w_ = context.Operators.CrossJoin<ServiceRequest, Task>(u_, v_);

        (CqlTupleMetadata, ServiceRequest DeviceOrderReject, Task T)? x_(ValueTuple<ServiceRequest, Task> _valueTuple) {
            (CqlTupleMetadata, ServiceRequest DeviceOrderReject, Task T)? bu_ = (CqlTupleMetadata_YYIDPXBNjhOGFRJKYRBMGChb, _valueTuple.Item1, _valueTuple.Item2);
            return bu_;
        }

        IEnumerable<(CqlTupleMetadata, ServiceRequest DeviceOrderReject, Task T)?> y_ = context.Operators.Select<ValueTuple<ServiceRequest, Task>, (CqlTupleMetadata, ServiceRequest DeviceOrderReject, Task T)?>(w_, x_);

        bool? z_((CqlTupleMetadata, ServiceRequest DeviceOrderReject, Task T)? tuple_yyidpxbnjhogfrjkyrbmgchb) {
            Code<RequestIntent> bv_ = tuple_yyidpxbnjhogfrjkyrbmgchb?.DeviceOrderReject?.IntentElement;
            RequestIntent? bw_ = bv_?.Value;
            Code<RequestIntent> bx_ = context.Operators.Convert<Code<RequestIntent>>(bw_);
            string by_ = context.Operators.Convert<string>(bx_);
            string[] bz_ = [
                "order",
                "original-order",
                "reflex-order",
                "filler-order",
                "instance-order",
            ];
            bool? ca_ = context.Operators.In<string>(by_, (IEnumerable<string>)bz_);
            Code<RequestStatus> cb_ = tuple_yyidpxbnjhogfrjkyrbmgchb?.DeviceOrderReject?.StatusElement;
            RequestStatus? cc_ = cb_?.Value;
            Code<RequestStatus> cd_ = context.Operators.Convert<Code<RequestStatus>>(cc_);
            bool? ce_ = context.Operators.Equal(cd_, "active");
            bool? cf_ = context.Operators.And(ca_, ce_);
            ResourceReference cg_ = tuple_yyidpxbnjhogfrjkyrbmgchb?.T?.Focus;
            bool? ch_ = QICoreCommon_4_0_000.Instance.references(context, cg_, tuple_yyidpxbnjhogfrjkyrbmgchb?.DeviceOrderReject);
            bool? ci_ = context.Operators.And(cf_, ch_);
            CodeableConcept cj_ = tuple_yyidpxbnjhogfrjkyrbmgchb?.T?.Code;
            CqlConcept ck_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, cj_);
            CqlCode cl_ = QICoreCommon_4_0_000.Instance.Fulfill(context);
            CqlConcept cm_ = context.Operators.ConvertCodeToConcept(cl_);
            bool? cn_ = context.Operators.Equivalent(ck_, cm_);
            bool? co_ = context.Operators.And(ci_, cn_);
            return co_;
        }

        IEnumerable<(CqlTupleMetadata, ServiceRequest DeviceOrderReject, Task T)?> aa_ = context.Operators.Where<(CqlTupleMetadata, ServiceRequest DeviceOrderReject, Task T)?>(y_, z_);

        (CqlTupleMetadata, string id, CqlConcept requestStatusReason, CqlDateTime authoredOn)? ab_((CqlTupleMetadata, ServiceRequest DeviceOrderReject, Task T)? tuple_yyidpxbnjhogfrjkyrbmgchb) {
            Id cp_ = tuple_yyidpxbnjhogfrjkyrbmgchb?.DeviceOrderReject?.IdElement;
            string cq_ = cp_?.Value;
            CodeableConcept cr_ = tuple_yyidpxbnjhogfrjkyrbmgchb?.T?.StatusReason;
            CqlConcept cs_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, cr_);
            FhirDateTime ct_ = tuple_yyidpxbnjhogfrjkyrbmgchb?.DeviceOrderReject?.AuthoredOnElement;
            CqlDateTime cu_ = context.Operators.Convert<CqlDateTime>(ct_);
            (CqlTupleMetadata, string id, CqlConcept requestStatusReason, CqlDateTime authoredOn)? cv_ = (CqlTupleMetadata_DheTAGNHbFgKVJGaRbPLJVjKH, cq_, cs_, cu_);
            return cv_;
        }

        IEnumerable<(CqlTupleMetadata, string id, CqlConcept requestStatusReason, CqlDateTime authoredOn)?> ac_ = context.Operators.Select<(CqlTupleMetadata, ServiceRequest DeviceOrderReject, Task T)?, (CqlTupleMetadata, string id, CqlConcept requestStatusReason, CqlDateTime authoredOn)?>(aa_, ab_);
        IEnumerable<(CqlTupleMetadata, string id, CqlConcept requestStatusReason, CqlDateTime authoredOn)?> ad_ = context.Operators.Distinct<(CqlTupleMetadata, string id, CqlConcept requestStatusReason, CqlDateTime authoredOn)?>(ac_);
        IEnumerable<object> ae_ = context.Operators.Union<object>(p_ as IEnumerable<object>, ad_ as IEnumerable<object>);
        (CqlTupleMetadata, string id, CqlConcept requestStatusReason, CqlDateTime authoredOn)? af_(object @object) => ((CqlTupleMetadata, string id, CqlConcept requestStatusReason, CqlDateTime authoredOn)?)@object;
        IEnumerable<(CqlTupleMetadata, string id, CqlConcept requestStatusReason, CqlDateTime authoredOn)?> ag_ = context.Operators.Select<object, (CqlTupleMetadata, string id, CqlConcept requestStatusReason, CqlDateTime authoredOn)?>(ae_, af_);
        CqlValueSet ah_ = this.Application_of_Intermittent_Pneumatic_Compression_Devices(context);
        IEnumerable<Procedure> ai_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, ah_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedurenotdone"));
        IEnumerable<Procedure> aj_ = context.Operators.Union<Procedure>(ai_, ai_);
        CqlValueSet ak_ = this.Application_of_Venous_Foot_Pumps(context);
        IEnumerable<Procedure> al_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, ak_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedurenotdone"));
        IEnumerable<Procedure> am_ = context.Operators.Union<Procedure>(al_, al_);
        IEnumerable<Procedure> an_ = context.Operators.Union<Procedure>(aj_, am_);
        CqlValueSet ao_ = this.Application_of_Graduated_Compression_Stockings(context);
        IEnumerable<Procedure> ap_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, ao_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedurenotdone"));
        IEnumerable<Procedure> aq_ = context.Operators.Union<Procedure>(ap_, ap_);
        IEnumerable<Procedure> ar_ = context.Operators.Union<Procedure>(an_, aq_);

        (CqlTupleMetadata, string id, CqlConcept requestStatusReason, FhirDateTime authoredOn)? as_(Procedure DeviceNotApplied) {
            Id cw_ = DeviceNotApplied?.IdElement;
            string cx_ = cw_?.Value;
            CodeableConcept cy_ = DeviceNotApplied?.StatusReason;
            CqlConcept cz_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, cy_);

            bool? da_(Extension @this) {
                FhirUri dh_ = @this?.UrlElement;
                string di_ = FHIRHelpers_4_4_000.Instance.ToString(context, dh_);
                bool? dj_ = context.Operators.Equal(di_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-recorded");
                return dj_;
            }

            IEnumerable<Extension> db_ = context.Operators.Where<Extension>((IEnumerable<Extension>)(DeviceNotApplied is DomainResource
                ? (DeviceNotApplied as DomainResource).Extension
                : default), da_);

            DataType dc_(Extension @this) {
                DataType dk_ = @this?.Value;
                return dk_;
            }

            IEnumerable<DataType> dd_ = context.Operators.Select<Extension, DataType>(db_, dc_);
            DataType de_ = context.Operators.SingletonFrom<DataType>(dd_);
            FhirDateTime df_ = context.Operators.Convert<FhirDateTime>(de_);
            (CqlTupleMetadata, string id, CqlConcept requestStatusReason, FhirDateTime authoredOn)? dg_ = (CqlTupleMetadata_DPXDaXjPQUNAIiZCCbGhNdDMi, cx_, cz_, df_);
            return dg_;
        }

        IEnumerable<(CqlTupleMetadata, string id, CqlConcept requestStatusReason, FhirDateTime authoredOn)?> at_ = context.Operators.Select<Procedure, (CqlTupleMetadata, string id, CqlConcept requestStatusReason, FhirDateTime authoredOn)?>(ar_, as_);
        IEnumerable<(CqlTupleMetadata, string id, CqlConcept requestStatusReason, FhirDateTime authoredOn)?> au_ = context.Operators.Distinct<(CqlTupleMetadata, string id, CqlConcept requestStatusReason, FhirDateTime authoredOn)?>(at_);
        IEnumerable<object> av_ = context.Operators.Union<object>(ag_ as IEnumerable<object>, au_ as IEnumerable<object>);
        (CqlTupleMetadata, string id, CqlConcept requestStatusReason, CqlDateTime authoredOn)? aw_(object @object) => ((CqlTupleMetadata, string id, CqlConcept requestStatusReason, CqlDateTime authoredOn)?)@object;
        IEnumerable<(CqlTupleMetadata, string id, CqlConcept requestStatusReason, CqlDateTime authoredOn)?> ax_ = context.Operators.Select<object, (CqlTupleMetadata, string id, CqlConcept requestStatusReason, CqlDateTime authoredOn)?>(av_, aw_);
        return ax_;
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
                CqlDate o_ = l_?.high;
                CqlDateTime p_ = context.Operators.ConvertDateToDateTime(o_);
                bool? q_ = l_?.lowClosed;
                bool? r_ = l_?.highClosed;
                CqlInterval<CqlDateTime> s_ = context.Operators.Interval(n_, p_, q_, r_);
                bool? t_ = context.Operators.In<CqlDateTime>(k_, s_, "day");
                bool? u_ = context.Operators.And(j_, t_);
                return u_;
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
            object v_;
            DataType bf_ = tuple_chjebychscdthhbpzggacmwxe?.AnesthesiaProcedure?.Performed;
            object bg_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bf_);
            bool bh_ = bg_ is CqlDateTime;
            if (bh_)
            {
                DataType bi_ = tuple_chjebychscdthhbpzggacmwxe?.AnesthesiaProcedure?.Performed;
                object bj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bi_);
                v_ = bj_ as CqlDateTime;
            }
            else
            {
                DataType bk_ = tuple_chjebychscdthhbpzggacmwxe?.AnesthesiaProcedure?.Performed;
                object bl_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bk_);
                bool bm_ = bl_ is CqlInterval<CqlDateTime>;
                if (bm_)
                {
                    DataType bn_ = tuple_chjebychscdthhbpzggacmwxe?.AnesthesiaProcedure?.Performed;
                    object bo_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bn_);
                    v_ = bo_ as CqlInterval<CqlDateTime>;
                }
                else
                {
                    DataType bp_ = tuple_chjebychscdthhbpzggacmwxe?.AnesthesiaProcedure?.Performed;
                    object bq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bp_);
                    bool br_ = bq_ is CqlQuantity;
                    if (br_)
                    {
                        DataType bs_ = tuple_chjebychscdthhbpzggacmwxe?.AnesthesiaProcedure?.Performed;
                        object bt_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bs_);
                        v_ = bt_ as CqlQuantity;
                    }
                    else
                    {
                        DataType bu_ = tuple_chjebychscdthhbpzggacmwxe?.AnesthesiaProcedure?.Performed;
                        object bv_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bu_);
                        bool bw_ = bv_ is CqlInterval<CqlQuantity>;
                        if (bw_)
                        {
                            DataType bx_ = tuple_chjebychscdthhbpzggacmwxe?.AnesthesiaProcedure?.Performed;
                            object by_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bx_);
                            v_ = by_ as CqlInterval<CqlQuantity>;
                        }
                        else
                        {
                            v_ = null;
                        }
                    }
                }
            }
            CqlInterval<CqlDateTime> w_ = QICoreCommon_4_0_000.Instance.toInterval(context, v_);
            CqlDateTime x_ = context.Operators.End(w_);
            Period y_ = tuple_chjebychscdthhbpzggacmwxe?.QualifyingEncounter?.Period;
            CqlInterval<CqlDateTime> z_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, y_);
            CqlDateTime aa_ = context.Operators.Start(z_);
            CqlQuantity ab_ = context.Operators.Quantity(1m, "day");
            CqlDateTime ac_ = context.Operators.Add(aa_, ab_);
            bool? ad_ = context.Operators.SameAs(x_, ac_, "day");
            bool? ae_ = context.Operators.And(u_, ad_);
            CqlDateTime af_ = tuple_chjebychscdthhbpzggacmwxe?.NoVTEMedication?.authoredOn;
            object ag_;
            DataType bz_ = tuple_chjebychscdthhbpzggacmwxe?.AnesthesiaProcedure?.Performed;
            object ca_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bz_);
            bool cb_ = ca_ is CqlDateTime;
            if (cb_)
            {
                DataType cc_ = tuple_chjebychscdthhbpzggacmwxe?.AnesthesiaProcedure?.Performed;
                object cd_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cc_);
                ag_ = cd_ as CqlDateTime;
            }
            else
            {
                DataType ce_ = tuple_chjebychscdthhbpzggacmwxe?.AnesthesiaProcedure?.Performed;
                object cf_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ce_);
                bool cg_ = cf_ is CqlInterval<CqlDateTime>;
                if (cg_)
                {
                    DataType ch_ = tuple_chjebychscdthhbpzggacmwxe?.AnesthesiaProcedure?.Performed;
                    object ci_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ch_);
                    ag_ = ci_ as CqlInterval<CqlDateTime>;
                }
                else
                {
                    DataType cj_ = tuple_chjebychscdthhbpzggacmwxe?.AnesthesiaProcedure?.Performed;
                    object ck_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cj_);
                    bool cl_ = ck_ is CqlQuantity;
                    if (cl_)
                    {
                        DataType cm_ = tuple_chjebychscdthhbpzggacmwxe?.AnesthesiaProcedure?.Performed;
                        object cn_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cm_);
                        ag_ = cn_ as CqlQuantity;
                    }
                    else
                    {
                        DataType co_ = tuple_chjebychscdthhbpzggacmwxe?.AnesthesiaProcedure?.Performed;
                        object cp_ = FHIRHelpers_4_4_000.Instance.ToValue(context, co_);
                        bool cq_ = cp_ is CqlInterval<CqlQuantity>;
                        if (cq_)
                        {
                            DataType cr_ = tuple_chjebychscdthhbpzggacmwxe?.AnesthesiaProcedure?.Performed;
                            object cs_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cr_);
                            ag_ = cs_ as CqlInterval<CqlQuantity>;
                        }
                        else
                        {
                            ag_ = null;
                        }
                    }
                }
            }
            CqlInterval<CqlDateTime> ah_ = QICoreCommon_4_0_000.Instance.toInterval(context, ag_);
            CqlDateTime ai_ = context.Operators.End(ah_);
            CqlInterval<CqlDate> aj_ = TJCOverall_8_25_000.Instance.calendarDayOfOrDayAfter(context, ai_);
            CqlDate ak_ = aj_?.low;
            CqlDateTime al_ = context.Operators.ConvertDateToDateTime(ak_);
            object am_;
            DataType ct_ = tuple_chjebychscdthhbpzggacmwxe?.AnesthesiaProcedure?.Performed;
            object cu_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ct_);
            bool cv_ = cu_ is CqlDateTime;
            if (cv_)
            {
                DataType cw_ = tuple_chjebychscdthhbpzggacmwxe?.AnesthesiaProcedure?.Performed;
                object cx_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cw_);
                am_ = cx_ as CqlDateTime;
            }
            else
            {
                DataType cy_ = tuple_chjebychscdthhbpzggacmwxe?.AnesthesiaProcedure?.Performed;
                object cz_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cy_);
                bool da_ = cz_ is CqlInterval<CqlDateTime>;
                if (da_)
                {
                    DataType db_ = tuple_chjebychscdthhbpzggacmwxe?.AnesthesiaProcedure?.Performed;
                    object dc_ = FHIRHelpers_4_4_000.Instance.ToValue(context, db_);
                    am_ = dc_ as CqlInterval<CqlDateTime>;
                }
                else
                {
                    DataType dd_ = tuple_chjebychscdthhbpzggacmwxe?.AnesthesiaProcedure?.Performed;
                    object de_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dd_);
                    bool df_ = de_ is CqlQuantity;
                    if (df_)
                    {
                        DataType dg_ = tuple_chjebychscdthhbpzggacmwxe?.AnesthesiaProcedure?.Performed;
                        object dh_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dg_);
                        am_ = dh_ as CqlQuantity;
                    }
                    else
                    {
                        DataType di_ = tuple_chjebychscdthhbpzggacmwxe?.AnesthesiaProcedure?.Performed;
                        object dj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, di_);
                        bool dk_ = dj_ is CqlInterval<CqlQuantity>;
                        if (dk_)
                        {
                            DataType dl_ = tuple_chjebychscdthhbpzggacmwxe?.AnesthesiaProcedure?.Performed;
                            object dm_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dl_);
                            am_ = dm_ as CqlInterval<CqlQuantity>;
                        }
                        else
                        {
                            am_ = null;
                        }
                    }
                }
            }
            CqlInterval<CqlDateTime> an_ = QICoreCommon_4_0_000.Instance.toInterval(context, am_);
            CqlDateTime ao_ = context.Operators.End(an_);
            CqlInterval<CqlDate> ap_ = TJCOverall_8_25_000.Instance.calendarDayOfOrDayAfter(context, ao_);
            CqlDate aq_ = ap_?.high;
            CqlDateTime ar_ = context.Operators.ConvertDateToDateTime(aq_);
            object as_;
            DataType dn_ = tuple_chjebychscdthhbpzggacmwxe?.AnesthesiaProcedure?.Performed;
            object do_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dn_);
            bool dp_ = do_ is CqlDateTime;
            if (dp_)
            {
                DataType dq_ = tuple_chjebychscdthhbpzggacmwxe?.AnesthesiaProcedure?.Performed;
                object dr_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dq_);
                as_ = dr_ as CqlDateTime;
            }
            else
            {
                DataType ds_ = tuple_chjebychscdthhbpzggacmwxe?.AnesthesiaProcedure?.Performed;
                object dt_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ds_);
                bool du_ = dt_ is CqlInterval<CqlDateTime>;
                if (du_)
                {
                    DataType dv_ = tuple_chjebychscdthhbpzggacmwxe?.AnesthesiaProcedure?.Performed;
                    object dw_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dv_);
                    as_ = dw_ as CqlInterval<CqlDateTime>;
                }
                else
                {
                    DataType dx_ = tuple_chjebychscdthhbpzggacmwxe?.AnesthesiaProcedure?.Performed;
                    object dy_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dx_);
                    bool dz_ = dy_ is CqlQuantity;
                    if (dz_)
                    {
                        DataType ea_ = tuple_chjebychscdthhbpzggacmwxe?.AnesthesiaProcedure?.Performed;
                        object eb_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ea_);
                        as_ = eb_ as CqlQuantity;
                    }
                    else
                    {
                        DataType ec_ = tuple_chjebychscdthhbpzggacmwxe?.AnesthesiaProcedure?.Performed;
                        object ed_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ec_);
                        bool ee_ = ed_ is CqlInterval<CqlQuantity>;
                        if (ee_)
                        {
                            DataType ef_ = tuple_chjebychscdthhbpzggacmwxe?.AnesthesiaProcedure?.Performed;
                            object eg_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ef_);
                            as_ = eg_ as CqlInterval<CqlQuantity>;
                        }
                        else
                        {
                            as_ = null;
                        }
                    }
                }
            }
            CqlInterval<CqlDateTime> at_ = QICoreCommon_4_0_000.Instance.toInterval(context, as_);
            CqlDateTime au_ = context.Operators.End(at_);
            CqlInterval<CqlDate> av_ = TJCOverall_8_25_000.Instance.calendarDayOfOrDayAfter(context, au_);
            bool? aw_ = av_?.lowClosed;
            object ax_;
            DataType eh_ = tuple_chjebychscdthhbpzggacmwxe?.AnesthesiaProcedure?.Performed;
            object ei_ = FHIRHelpers_4_4_000.Instance.ToValue(context, eh_);
            bool ej_ = ei_ is CqlDateTime;
            if (ej_)
            {
                DataType ek_ = tuple_chjebychscdthhbpzggacmwxe?.AnesthesiaProcedure?.Performed;
                object el_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ek_);
                ax_ = el_ as CqlDateTime;
            }
            else
            {
                DataType em_ = tuple_chjebychscdthhbpzggacmwxe?.AnesthesiaProcedure?.Performed;
                object en_ = FHIRHelpers_4_4_000.Instance.ToValue(context, em_);
                bool eo_ = en_ is CqlInterval<CqlDateTime>;
                if (eo_)
                {
                    DataType ep_ = tuple_chjebychscdthhbpzggacmwxe?.AnesthesiaProcedure?.Performed;
                    object eq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ep_);
                    ax_ = eq_ as CqlInterval<CqlDateTime>;
                }
                else
                {
                    DataType er_ = tuple_chjebychscdthhbpzggacmwxe?.AnesthesiaProcedure?.Performed;
                    object es_ = FHIRHelpers_4_4_000.Instance.ToValue(context, er_);
                    bool et_ = es_ is CqlQuantity;
                    if (et_)
                    {
                        DataType eu_ = tuple_chjebychscdthhbpzggacmwxe?.AnesthesiaProcedure?.Performed;
                        object ev_ = FHIRHelpers_4_4_000.Instance.ToValue(context, eu_);
                        ax_ = ev_ as CqlQuantity;
                    }
                    else
                    {
                        DataType ew_ = tuple_chjebychscdthhbpzggacmwxe?.AnesthesiaProcedure?.Performed;
                        object ex_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ew_);
                        bool ey_ = ex_ is CqlInterval<CqlQuantity>;
                        if (ey_)
                        {
                            DataType ez_ = tuple_chjebychscdthhbpzggacmwxe?.AnesthesiaProcedure?.Performed;
                            object fa_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ez_);
                            ax_ = fa_ as CqlInterval<CqlQuantity>;
                        }
                        else
                        {
                            ax_ = null;
                        }
                    }
                }
            }
            CqlInterval<CqlDateTime> ay_ = QICoreCommon_4_0_000.Instance.toInterval(context, ax_);
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
            object v_;
            DataType bf_ = tuple_cadhcldckpqwmtcazwxfnkhgc?.AnesthesiaProcedure?.Performed;
            object bg_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bf_);
            bool bh_ = bg_ is CqlDateTime;
            if (bh_)
            {
                DataType bi_ = tuple_cadhcldckpqwmtcazwxfnkhgc?.AnesthesiaProcedure?.Performed;
                object bj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bi_);
                v_ = bj_ as CqlDateTime;
            }
            else
            {
                DataType bk_ = tuple_cadhcldckpqwmtcazwxfnkhgc?.AnesthesiaProcedure?.Performed;
                object bl_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bk_);
                bool bm_ = bl_ is CqlInterval<CqlDateTime>;
                if (bm_)
                {
                    DataType bn_ = tuple_cadhcldckpqwmtcazwxfnkhgc?.AnesthesiaProcedure?.Performed;
                    object bo_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bn_);
                    v_ = bo_ as CqlInterval<CqlDateTime>;
                }
                else
                {
                    DataType bp_ = tuple_cadhcldckpqwmtcazwxfnkhgc?.AnesthesiaProcedure?.Performed;
                    object bq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bp_);
                    bool br_ = bq_ is CqlQuantity;
                    if (br_)
                    {
                        DataType bs_ = tuple_cadhcldckpqwmtcazwxfnkhgc?.AnesthesiaProcedure?.Performed;
                        object bt_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bs_);
                        v_ = bt_ as CqlQuantity;
                    }
                    else
                    {
                        DataType bu_ = tuple_cadhcldckpqwmtcazwxfnkhgc?.AnesthesiaProcedure?.Performed;
                        object bv_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bu_);
                        bool bw_ = bv_ is CqlInterval<CqlQuantity>;
                        if (bw_)
                        {
                            DataType bx_ = tuple_cadhcldckpqwmtcazwxfnkhgc?.AnesthesiaProcedure?.Performed;
                            object by_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bx_);
                            v_ = by_ as CqlInterval<CqlQuantity>;
                        }
                        else
                        {
                            v_ = null;
                        }
                    }
                }
            }
            CqlInterval<CqlDateTime> w_ = QICoreCommon_4_0_000.Instance.toInterval(context, v_);
            CqlDateTime x_ = context.Operators.End(w_);
            Period y_ = tuple_cadhcldckpqwmtcazwxfnkhgc?.QualifyingEncounter?.Period;
            CqlInterval<CqlDateTime> z_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, y_);
            CqlDateTime aa_ = context.Operators.Start(z_);
            CqlQuantity ab_ = context.Operators.Quantity(1m, "day");
            CqlDateTime ac_ = context.Operators.Add(aa_, ab_);
            bool? ad_ = context.Operators.SameAs(x_, ac_, "day");
            bool? ae_ = context.Operators.And(u_, ad_);
            CqlDateTime af_ = tuple_cadhcldckpqwmtcazwxfnkhgc?.NoVTEDevice?.authoredOn;
            object ag_;
            DataType bz_ = tuple_cadhcldckpqwmtcazwxfnkhgc?.AnesthesiaProcedure?.Performed;
            object ca_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bz_);
            bool cb_ = ca_ is CqlDateTime;
            if (cb_)
            {
                DataType cc_ = tuple_cadhcldckpqwmtcazwxfnkhgc?.AnesthesiaProcedure?.Performed;
                object cd_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cc_);
                ag_ = cd_ as CqlDateTime;
            }
            else
            {
                DataType ce_ = tuple_cadhcldckpqwmtcazwxfnkhgc?.AnesthesiaProcedure?.Performed;
                object cf_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ce_);
                bool cg_ = cf_ is CqlInterval<CqlDateTime>;
                if (cg_)
                {
                    DataType ch_ = tuple_cadhcldckpqwmtcazwxfnkhgc?.AnesthesiaProcedure?.Performed;
                    object ci_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ch_);
                    ag_ = ci_ as CqlInterval<CqlDateTime>;
                }
                else
                {
                    DataType cj_ = tuple_cadhcldckpqwmtcazwxfnkhgc?.AnesthesiaProcedure?.Performed;
                    object ck_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cj_);
                    bool cl_ = ck_ is CqlQuantity;
                    if (cl_)
                    {
                        DataType cm_ = tuple_cadhcldckpqwmtcazwxfnkhgc?.AnesthesiaProcedure?.Performed;
                        object cn_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cm_);
                        ag_ = cn_ as CqlQuantity;
                    }
                    else
                    {
                        DataType co_ = tuple_cadhcldckpqwmtcazwxfnkhgc?.AnesthesiaProcedure?.Performed;
                        object cp_ = FHIRHelpers_4_4_000.Instance.ToValue(context, co_);
                        bool cq_ = cp_ is CqlInterval<CqlQuantity>;
                        if (cq_)
                        {
                            DataType cr_ = tuple_cadhcldckpqwmtcazwxfnkhgc?.AnesthesiaProcedure?.Performed;
                            object cs_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cr_);
                            ag_ = cs_ as CqlInterval<CqlQuantity>;
                        }
                        else
                        {
                            ag_ = null;
                        }
                    }
                }
            }
            CqlInterval<CqlDateTime> ah_ = QICoreCommon_4_0_000.Instance.toInterval(context, ag_);
            CqlDateTime ai_ = context.Operators.End(ah_);
            CqlInterval<CqlDate> aj_ = TJCOverall_8_25_000.Instance.calendarDayOfOrDayAfter(context, ai_);
            CqlDate ak_ = aj_?.low;
            CqlDateTime al_ = context.Operators.ConvertDateToDateTime(ak_);
            object am_;
            DataType ct_ = tuple_cadhcldckpqwmtcazwxfnkhgc?.AnesthesiaProcedure?.Performed;
            object cu_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ct_);
            bool cv_ = cu_ is CqlDateTime;
            if (cv_)
            {
                DataType cw_ = tuple_cadhcldckpqwmtcazwxfnkhgc?.AnesthesiaProcedure?.Performed;
                object cx_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cw_);
                am_ = cx_ as CqlDateTime;
            }
            else
            {
                DataType cy_ = tuple_cadhcldckpqwmtcazwxfnkhgc?.AnesthesiaProcedure?.Performed;
                object cz_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cy_);
                bool da_ = cz_ is CqlInterval<CqlDateTime>;
                if (da_)
                {
                    DataType db_ = tuple_cadhcldckpqwmtcazwxfnkhgc?.AnesthesiaProcedure?.Performed;
                    object dc_ = FHIRHelpers_4_4_000.Instance.ToValue(context, db_);
                    am_ = dc_ as CqlInterval<CqlDateTime>;
                }
                else
                {
                    DataType dd_ = tuple_cadhcldckpqwmtcazwxfnkhgc?.AnesthesiaProcedure?.Performed;
                    object de_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dd_);
                    bool df_ = de_ is CqlQuantity;
                    if (df_)
                    {
                        DataType dg_ = tuple_cadhcldckpqwmtcazwxfnkhgc?.AnesthesiaProcedure?.Performed;
                        object dh_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dg_);
                        am_ = dh_ as CqlQuantity;
                    }
                    else
                    {
                        DataType di_ = tuple_cadhcldckpqwmtcazwxfnkhgc?.AnesthesiaProcedure?.Performed;
                        object dj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, di_);
                        bool dk_ = dj_ is CqlInterval<CqlQuantity>;
                        if (dk_)
                        {
                            DataType dl_ = tuple_cadhcldckpqwmtcazwxfnkhgc?.AnesthesiaProcedure?.Performed;
                            object dm_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dl_);
                            am_ = dm_ as CqlInterval<CqlQuantity>;
                        }
                        else
                        {
                            am_ = null;
                        }
                    }
                }
            }
            CqlInterval<CqlDateTime> an_ = QICoreCommon_4_0_000.Instance.toInterval(context, am_);
            CqlDateTime ao_ = context.Operators.End(an_);
            CqlInterval<CqlDate> ap_ = TJCOverall_8_25_000.Instance.calendarDayOfOrDayAfter(context, ao_);
            CqlDate aq_ = ap_?.high;
            CqlDateTime ar_ = context.Operators.ConvertDateToDateTime(aq_);
            object as_;
            DataType dn_ = tuple_cadhcldckpqwmtcazwxfnkhgc?.AnesthesiaProcedure?.Performed;
            object do_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dn_);
            bool dp_ = do_ is CqlDateTime;
            if (dp_)
            {
                DataType dq_ = tuple_cadhcldckpqwmtcazwxfnkhgc?.AnesthesiaProcedure?.Performed;
                object dr_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dq_);
                as_ = dr_ as CqlDateTime;
            }
            else
            {
                DataType ds_ = tuple_cadhcldckpqwmtcazwxfnkhgc?.AnesthesiaProcedure?.Performed;
                object dt_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ds_);
                bool du_ = dt_ is CqlInterval<CqlDateTime>;
                if (du_)
                {
                    DataType dv_ = tuple_cadhcldckpqwmtcazwxfnkhgc?.AnesthesiaProcedure?.Performed;
                    object dw_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dv_);
                    as_ = dw_ as CqlInterval<CqlDateTime>;
                }
                else
                {
                    DataType dx_ = tuple_cadhcldckpqwmtcazwxfnkhgc?.AnesthesiaProcedure?.Performed;
                    object dy_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dx_);
                    bool dz_ = dy_ is CqlQuantity;
                    if (dz_)
                    {
                        DataType ea_ = tuple_cadhcldckpqwmtcazwxfnkhgc?.AnesthesiaProcedure?.Performed;
                        object eb_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ea_);
                        as_ = eb_ as CqlQuantity;
                    }
                    else
                    {
                        DataType ec_ = tuple_cadhcldckpqwmtcazwxfnkhgc?.AnesthesiaProcedure?.Performed;
                        object ed_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ec_);
                        bool ee_ = ed_ is CqlInterval<CqlQuantity>;
                        if (ee_)
                        {
                            DataType ef_ = tuple_cadhcldckpqwmtcazwxfnkhgc?.AnesthesiaProcedure?.Performed;
                            object eg_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ef_);
                            as_ = eg_ as CqlInterval<CqlQuantity>;
                        }
                        else
                        {
                            as_ = null;
                        }
                    }
                }
            }
            CqlInterval<CqlDateTime> at_ = QICoreCommon_4_0_000.Instance.toInterval(context, as_);
            CqlDateTime au_ = context.Operators.End(at_);
            CqlInterval<CqlDate> av_ = TJCOverall_8_25_000.Instance.calendarDayOfOrDayAfter(context, au_);
            bool? aw_ = av_?.lowClosed;
            object ax_;
            DataType eh_ = tuple_cadhcldckpqwmtcazwxfnkhgc?.AnesthesiaProcedure?.Performed;
            object ei_ = FHIRHelpers_4_4_000.Instance.ToValue(context, eh_);
            bool ej_ = ei_ is CqlDateTime;
            if (ej_)
            {
                DataType ek_ = tuple_cadhcldckpqwmtcazwxfnkhgc?.AnesthesiaProcedure?.Performed;
                object el_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ek_);
                ax_ = el_ as CqlDateTime;
            }
            else
            {
                DataType em_ = tuple_cadhcldckpqwmtcazwxfnkhgc?.AnesthesiaProcedure?.Performed;
                object en_ = FHIRHelpers_4_4_000.Instance.ToValue(context, em_);
                bool eo_ = en_ is CqlInterval<CqlDateTime>;
                if (eo_)
                {
                    DataType ep_ = tuple_cadhcldckpqwmtcazwxfnkhgc?.AnesthesiaProcedure?.Performed;
                    object eq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ep_);
                    ax_ = eq_ as CqlInterval<CqlDateTime>;
                }
                else
                {
                    DataType er_ = tuple_cadhcldckpqwmtcazwxfnkhgc?.AnesthesiaProcedure?.Performed;
                    object es_ = FHIRHelpers_4_4_000.Instance.ToValue(context, er_);
                    bool et_ = es_ is CqlQuantity;
                    if (et_)
                    {
                        DataType eu_ = tuple_cadhcldckpqwmtcazwxfnkhgc?.AnesthesiaProcedure?.Performed;
                        object ev_ = FHIRHelpers_4_4_000.Instance.ToValue(context, eu_);
                        ax_ = ev_ as CqlQuantity;
                    }
                    else
                    {
                        DataType ew_ = tuple_cadhcldckpqwmtcazwxfnkhgc?.AnesthesiaProcedure?.Performed;
                        object ex_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ew_);
                        bool ey_ = ex_ is CqlInterval<CqlQuantity>;
                        if (ey_)
                        {
                            DataType ez_ = tuple_cadhcldckpqwmtcazwxfnkhgc?.AnesthesiaProcedure?.Performed;
                            object fa_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ez_);
                            ax_ = fa_ as CqlInterval<CqlQuantity>;
                        }
                        else
                        {
                            ax_ = null;
                        }
                    }
                }
            }
            CqlInterval<CqlDateTime> ay_ = QICoreCommon_4_0_000.Instance.toInterval(context, ax_);
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
                CqlDate l_ = i_?.high;
                CqlDateTime m_ = context.Operators.ConvertDateToDateTime(l_);
                bool? n_ = i_?.lowClosed;
                bool? o_ = i_?.highClosed;
                CqlInterval<CqlDateTime> p_ = context.Operators.Interval(k_, m_, n_, o_);
                bool? q_ = context.Operators.In<CqlDateTime>(h_, p_, "day");
                return q_;
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
            object r_;
            DataType bb_ = tuple_fpeghttqsjgusnbabduddbjbh?.AnesthesiaProcedure?.Performed;
            object bc_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bb_);
            bool bd_ = bc_ is CqlDateTime;
            if (bd_)
            {
                DataType be_ = tuple_fpeghttqsjgusnbabduddbjbh?.AnesthesiaProcedure?.Performed;
                object bf_ = FHIRHelpers_4_4_000.Instance.ToValue(context, be_);
                r_ = bf_ as CqlDateTime;
            }
            else
            {
                DataType bg_ = tuple_fpeghttqsjgusnbabduddbjbh?.AnesthesiaProcedure?.Performed;
                object bh_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bg_);
                bool bi_ = bh_ is CqlInterval<CqlDateTime>;
                if (bi_)
                {
                    DataType bj_ = tuple_fpeghttqsjgusnbabduddbjbh?.AnesthesiaProcedure?.Performed;
                    object bk_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bj_);
                    r_ = bk_ as CqlInterval<CqlDateTime>;
                }
                else
                {
                    DataType bl_ = tuple_fpeghttqsjgusnbabduddbjbh?.AnesthesiaProcedure?.Performed;
                    object bm_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bl_);
                    bool bn_ = bm_ is CqlQuantity;
                    if (bn_)
                    {
                        DataType bo_ = tuple_fpeghttqsjgusnbabduddbjbh?.AnesthesiaProcedure?.Performed;
                        object bp_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bo_);
                        r_ = bp_ as CqlQuantity;
                    }
                    else
                    {
                        DataType bq_ = tuple_fpeghttqsjgusnbabduddbjbh?.AnesthesiaProcedure?.Performed;
                        object br_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bq_);
                        bool bs_ = br_ is CqlInterval<CqlQuantity>;
                        if (bs_)
                        {
                            DataType bt_ = tuple_fpeghttqsjgusnbabduddbjbh?.AnesthesiaProcedure?.Performed;
                            object bu_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bt_);
                            r_ = bu_ as CqlInterval<CqlQuantity>;
                        }
                        else
                        {
                            r_ = null;
                        }
                    }
                }
            }
            CqlInterval<CqlDateTime> s_ = QICoreCommon_4_0_000.Instance.toInterval(context, r_);
            CqlDateTime t_ = context.Operators.End(s_);
            Period u_ = tuple_fpeghttqsjgusnbabduddbjbh?.QualifyingEncounter?.Period;
            CqlInterval<CqlDateTime> v_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, u_);
            CqlDateTime w_ = context.Operators.Start(v_);
            CqlQuantity x_ = context.Operators.Quantity(1m, "day");
            CqlDateTime y_ = context.Operators.Add(w_, x_);
            bool? z_ = context.Operators.SameAs(t_, y_, "day");
            bool? aa_ = context.Operators.And(q_, z_);
            CqlDateTime ab_ = context.Operators.LateBoundProperty<CqlDateTime>(tuple_fpeghttqsjgusnbabduddbjbh?.PatientRefusal, "authoredOn");
            object ac_;
            DataType bv_ = tuple_fpeghttqsjgusnbabduddbjbh?.AnesthesiaProcedure?.Performed;
            object bw_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bv_);
            bool bx_ = bw_ is CqlDateTime;
            if (bx_)
            {
                DataType by_ = tuple_fpeghttqsjgusnbabduddbjbh?.AnesthesiaProcedure?.Performed;
                object bz_ = FHIRHelpers_4_4_000.Instance.ToValue(context, by_);
                ac_ = bz_ as CqlDateTime;
            }
            else
            {
                DataType ca_ = tuple_fpeghttqsjgusnbabduddbjbh?.AnesthesiaProcedure?.Performed;
                object cb_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ca_);
                bool cc_ = cb_ is CqlInterval<CqlDateTime>;
                if (cc_)
                {
                    DataType cd_ = tuple_fpeghttqsjgusnbabduddbjbh?.AnesthesiaProcedure?.Performed;
                    object ce_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cd_);
                    ac_ = ce_ as CqlInterval<CqlDateTime>;
                }
                else
                {
                    DataType cf_ = tuple_fpeghttqsjgusnbabduddbjbh?.AnesthesiaProcedure?.Performed;
                    object cg_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cf_);
                    bool ch_ = cg_ is CqlQuantity;
                    if (ch_)
                    {
                        DataType ci_ = tuple_fpeghttqsjgusnbabduddbjbh?.AnesthesiaProcedure?.Performed;
                        object cj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ci_);
                        ac_ = cj_ as CqlQuantity;
                    }
                    else
                    {
                        DataType ck_ = tuple_fpeghttqsjgusnbabduddbjbh?.AnesthesiaProcedure?.Performed;
                        object cl_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ck_);
                        bool cm_ = cl_ is CqlInterval<CqlQuantity>;
                        if (cm_)
                        {
                            DataType cn_ = tuple_fpeghttqsjgusnbabduddbjbh?.AnesthesiaProcedure?.Performed;
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
            DataType cp_ = tuple_fpeghttqsjgusnbabduddbjbh?.AnesthesiaProcedure?.Performed;
            object cq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cp_);
            bool cr_ = cq_ is CqlDateTime;
            if (cr_)
            {
                DataType cs_ = tuple_fpeghttqsjgusnbabduddbjbh?.AnesthesiaProcedure?.Performed;
                object ct_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cs_);
                ai_ = ct_ as CqlDateTime;
            }
            else
            {
                DataType cu_ = tuple_fpeghttqsjgusnbabduddbjbh?.AnesthesiaProcedure?.Performed;
                object cv_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cu_);
                bool cw_ = cv_ is CqlInterval<CqlDateTime>;
                if (cw_)
                {
                    DataType cx_ = tuple_fpeghttqsjgusnbabduddbjbh?.AnesthesiaProcedure?.Performed;
                    object cy_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cx_);
                    ai_ = cy_ as CqlInterval<CqlDateTime>;
                }
                else
                {
                    DataType cz_ = tuple_fpeghttqsjgusnbabduddbjbh?.AnesthesiaProcedure?.Performed;
                    object da_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cz_);
                    bool db_ = da_ is CqlQuantity;
                    if (db_)
                    {
                        DataType dc_ = tuple_fpeghttqsjgusnbabduddbjbh?.AnesthesiaProcedure?.Performed;
                        object dd_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dc_);
                        ai_ = dd_ as CqlQuantity;
                    }
                    else
                    {
                        DataType de_ = tuple_fpeghttqsjgusnbabduddbjbh?.AnesthesiaProcedure?.Performed;
                        object df_ = FHIRHelpers_4_4_000.Instance.ToValue(context, de_);
                        bool dg_ = df_ is CqlInterval<CqlQuantity>;
                        if (dg_)
                        {
                            DataType dh_ = tuple_fpeghttqsjgusnbabduddbjbh?.AnesthesiaProcedure?.Performed;
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
            DataType dj_ = tuple_fpeghttqsjgusnbabduddbjbh?.AnesthesiaProcedure?.Performed;
            object dk_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dj_);
            bool dl_ = dk_ is CqlDateTime;
            if (dl_)
            {
                DataType dm_ = tuple_fpeghttqsjgusnbabduddbjbh?.AnesthesiaProcedure?.Performed;
                object dn_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dm_);
                ao_ = dn_ as CqlDateTime;
            }
            else
            {
                DataType do_ = tuple_fpeghttqsjgusnbabduddbjbh?.AnesthesiaProcedure?.Performed;
                object dp_ = FHIRHelpers_4_4_000.Instance.ToValue(context, do_);
                bool dq_ = dp_ is CqlInterval<CqlDateTime>;
                if (dq_)
                {
                    DataType dr_ = tuple_fpeghttqsjgusnbabduddbjbh?.AnesthesiaProcedure?.Performed;
                    object ds_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dr_);
                    ao_ = ds_ as CqlInterval<CqlDateTime>;
                }
                else
                {
                    DataType dt_ = tuple_fpeghttqsjgusnbabduddbjbh?.AnesthesiaProcedure?.Performed;
                    object du_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dt_);
                    bool dv_ = du_ is CqlQuantity;
                    if (dv_)
                    {
                        DataType dw_ = tuple_fpeghttqsjgusnbabduddbjbh?.AnesthesiaProcedure?.Performed;
                        object dx_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dw_);
                        ao_ = dx_ as CqlQuantity;
                    }
                    else
                    {
                        DataType dy_ = tuple_fpeghttqsjgusnbabduddbjbh?.AnesthesiaProcedure?.Performed;
                        object dz_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dy_);
                        bool ea_ = dz_ is CqlInterval<CqlQuantity>;
                        if (ea_)
                        {
                            DataType eb_ = tuple_fpeghttqsjgusnbabduddbjbh?.AnesthesiaProcedure?.Performed;
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
            DataType ed_ = tuple_fpeghttqsjgusnbabduddbjbh?.AnesthesiaProcedure?.Performed;
            object ee_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ed_);
            bool ef_ = ee_ is CqlDateTime;
            if (ef_)
            {
                DataType eg_ = tuple_fpeghttqsjgusnbabduddbjbh?.AnesthesiaProcedure?.Performed;
                object eh_ = FHIRHelpers_4_4_000.Instance.ToValue(context, eg_);
                at_ = eh_ as CqlDateTime;
            }
            else
            {
                DataType ei_ = tuple_fpeghttqsjgusnbabduddbjbh?.AnesthesiaProcedure?.Performed;
                object ej_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ei_);
                bool ek_ = ej_ is CqlInterval<CqlDateTime>;
                if (ek_)
                {
                    DataType el_ = tuple_fpeghttqsjgusnbabduddbjbh?.AnesthesiaProcedure?.Performed;
                    object em_ = FHIRHelpers_4_4_000.Instance.ToValue(context, el_);
                    at_ = em_ as CqlInterval<CqlDateTime>;
                }
                else
                {
                    DataType en_ = tuple_fpeghttqsjgusnbabduddbjbh?.AnesthesiaProcedure?.Performed;
                    object eo_ = FHIRHelpers_4_4_000.Instance.ToValue(context, en_);
                    bool ep_ = eo_ is CqlQuantity;
                    if (ep_)
                    {
                        DataType eq_ = tuple_fpeghttqsjgusnbabduddbjbh?.AnesthesiaProcedure?.Performed;
                        object er_ = FHIRHelpers_4_4_000.Instance.ToValue(context, eq_);
                        at_ = er_ as CqlQuantity;
                    }
                    else
                    {
                        DataType es_ = tuple_fpeghttqsjgusnbabduddbjbh?.AnesthesiaProcedure?.Performed;
                        object et_ = FHIRHelpers_4_4_000.Instance.ToValue(context, es_);
                        bool eu_ = et_ is CqlInterval<CqlQuantity>;
                        if (eu_)
                        {
                            DataType ev_ = tuple_fpeghttqsjgusnbabduddbjbh?.AnesthesiaProcedure?.Performed;
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

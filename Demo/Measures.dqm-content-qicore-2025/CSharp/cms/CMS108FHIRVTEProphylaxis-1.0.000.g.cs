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

[System.CodeDom.Compiler.GeneratedCode(".NET Code Generation", "5.2.4.0")]
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
                ResourceReference g_ = Location?.Location;
                Location h_ = CQMCommon_4_1_000.Instance.getLocation(context, g_);
                List<CodeableConcept> i_ = h_?.Type;

                CqlConcept j_(CodeableConcept @this) {
                    CqlConcept ac_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);
                    return ac_;
                }

                IEnumerable<CqlConcept> k_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)i_, j_);
                CqlValueSet l_ = this.Intensive_Care_Unit(context);
                bool? m_ = context.Operators.ConceptsInValueSet(k_, l_);
                Period n_ = Location?.Period;
                CqlInterval<CqlDateTime> o_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, n_);
                int? p_ = CQMCommon_4_1_000.Instance.lengthInDays(context, o_);
                bool? q_ = context.Operators.GreaterOrEqual(p_, 1);
                bool? r_ = context.Operators.And(m_, q_);
                CqlDateTime s_ = context.Operators.Start(o_);
                Period t_ = QualifyingEncounter?.Period;
                CqlInterval<CqlDateTime> u_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, t_);
                CqlDateTime v_ = context.Operators.Start(u_);
                bool? w_ = context.Operators.SameOrAfter(s_, v_, (string)default);
                bool? x_ = context.Operators.And(r_, w_);
                CqlDate y_ = context.Operators.DateFrom(s_);
                CqlInterval<CqlDate> z_ = TJCOverall_8_25_000.Instance.calendarDayOfOrDayAfter(context, v_);
                bool? aa_ = context.Operators.In<CqlDate>(y_, z_, (string)default);
                bool? ab_ = context.Operators.And(x_, aa_);
                return ab_;
            }

            bool? f_ = context.Operators.WhereAny<Encounter.LocationComponent>((IEnumerable<Encounter.LocationComponent>)d_, e_);
            return f_;
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
                object g_;
                object u_;
                if (ComfortMeasure is Procedure)
                {
                    DataType x_ = (ComfortMeasure as Procedure)?.Performed;
                    u_ = x_;
                }
                else
                {
                    u_ = null;
                }
                object v_ = FHIRHelpers_4_4_000.Instance.ToValue(context, u_);
                bool w_ = v_ is CqlDateTime;
                if (w_)
                {
                    object y_;
                    if (ComfortMeasure is Procedure)
                    {
                        DataType aa_ = (ComfortMeasure as Procedure)?.Performed;
                        y_ = aa_;
                    }
                    else
                    {
                        y_ = null;
                    }
                    object z_ = FHIRHelpers_4_4_000.Instance.ToValue(context, y_);
                    g_ = z_ as CqlDateTime;
                }
                else
                {
                    object ab_;
                    if (ComfortMeasure is Procedure)
                    {
                        DataType ae_ = (ComfortMeasure as Procedure)?.Performed;
                        ab_ = ae_;
                    }
                    else
                    {
                        ab_ = null;
                    }
                    object ac_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ab_);
                    bool ad_ = ac_ is CqlQuantity;
                    if (ad_)
                    {
                        object af_;
                        if (ComfortMeasure is Procedure)
                        {
                            DataType ah_ = (ComfortMeasure as Procedure)?.Performed;
                            af_ = ah_;
                        }
                        else
                        {
                            af_ = null;
                        }
                        object ag_ = FHIRHelpers_4_4_000.Instance.ToValue(context, af_);
                        g_ = ag_ as CqlQuantity;
                    }
                    else
                    {
                        object ai_;
                        if (ComfortMeasure is Procedure)
                        {
                            DataType al_ = (ComfortMeasure as Procedure)?.Performed;
                            ai_ = al_;
                        }
                        else
                        {
                            ai_ = null;
                        }
                        object aj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ai_);
                        bool ak_ = aj_ is CqlInterval<CqlDateTime>;
                        if (ak_)
                        {
                            object am_;
                            if (ComfortMeasure is Procedure)
                            {
                                DataType ao_ = (ComfortMeasure as Procedure)?.Performed;
                                am_ = ao_;
                            }
                            else
                            {
                                am_ = null;
                            }
                            object an_ = FHIRHelpers_4_4_000.Instance.ToValue(context, am_);
                            g_ = an_ as CqlInterval<CqlDateTime>;
                        }
                        else
                        {
                            object ap_;
                            if (ComfortMeasure is Procedure)
                            {
                                DataType as_ = (ComfortMeasure as Procedure)?.Performed;
                                ap_ = as_;
                            }
                            else
                            {
                                ap_ = null;
                            }
                            object aq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ap_);
                            bool ar_ = aq_ is CqlInterval<CqlQuantity>;
                            if (ar_)
                            {
                                object at_;
                                if (ComfortMeasure is Procedure)
                                {
                                    DataType av_ = (ComfortMeasure as Procedure)?.Performed;
                                    at_ = av_;
                                }
                                else
                                {
                                    at_ = null;
                                }
                                object au_ = FHIRHelpers_4_4_000.Instance.ToValue(context, at_);
                                g_ = au_ as CqlInterval<CqlQuantity>;
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
                FhirDateTime j_;
                if (ComfortMeasure is ServiceRequest)
                {
                    FhirDateTime aw_ = (ComfortMeasure as ServiceRequest)?.AuthoredOnElement;
                    j_ = aw_;
                }
                else
                {
                    j_ = default;
                }
                CqlDateTime k_ = context.Operators.Convert<CqlDateTime>(j_);
                CqlInterval<CqlDate> l_ = this.fromDayOfStartOfHospitalizationToDayAfterAdmission(context, QualifyingEncounter);
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

    private const long _cacheIndex_Encounter_With_Intervention_Comfort_Measures_On_Day_Of_Or_Day_After_Procedure = 3668449953604409540L;

    private IEnumerable<Encounter> Encounter_With_Intervention_Comfort_Measures_On_Day_Of_Or_Day_After_Procedure_Compute(CqlContext context)
    {
        IEnumerable<Encounter> a_ = VTE_8_18_000.Instance.Encounter_With_Age_Range_And_Without_VTE_Diagnosis_Or_Obstetrical_Conditions(context);
        CqlValueSet b_ = this.General_or_Neuraxial_Anesthesia(context);
        IEnumerable<Procedure> c_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, b_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
        IEnumerable<object> d_ = this.Intervention_Comfort_Measures(context);
        IEnumerable<ValueTuple<Encounter, Procedure, object>> e_ = context.Operators.CrossJoin<Encounter, Procedure, object>(a_, c_, d_);

        (CqlTupleMetadata, Encounter QualifyingEncounter, Procedure AnesthesiaProcedure, object ComfortMeasure)? f_(ValueTuple<Encounter, Procedure, object> _valueTuple) {
            (CqlTupleMetadata, Encounter QualifyingEncounter, Procedure AnesthesiaProcedure, object ComfortMeasure)? k_ = (CqlTupleMetadata_BgZKHMDEKXWfPTIRTZCcXPUFU, _valueTuple.Item1, _valueTuple.Item2, _valueTuple.Item3);
            return k_;
        }


        bool? g_((CqlTupleMetadata, Encounter QualifyingEncounter, Procedure AnesthesiaProcedure, object ComfortMeasure)? tuple_hbjscqgbuhismoaytymvucjfi) {
            Code<EventStatus> l_ = tuple_hbjscqgbuhismoaytymvucjfi?.AnesthesiaProcedure?.StatusElement;
            EventStatus? m_ = l_?.Value;
            string n_ = context.Operators.Convert<string>(m_);
            bool? o_ = context.Operators.Equal(n_, "completed");
            object p_;
            DataType bd_ = tuple_hbjscqgbuhismoaytymvucjfi?.AnesthesiaProcedure?.Performed;
            object be_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bd_);
            bool bf_ = be_ is CqlDateTime;
            if (bf_)
            {
                p_ = be_ as CqlDateTime;
            }
            else
            {
                bool bg_ = be_ is CqlQuantity;
                if (bg_)
                {
                    p_ = be_ as CqlQuantity;
                }
                else
                {
                    bool bh_ = be_ is CqlInterval<CqlDateTime>;
                    if (bh_)
                    {
                        p_ = be_ as CqlInterval<CqlDateTime>;
                    }
                    else
                    {
                        bool bi_ = be_ is CqlInterval<CqlQuantity>;
                        if (bi_)
                        {
                            p_ = be_ as CqlInterval<CqlQuantity>;
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
            Period s_ = tuple_hbjscqgbuhismoaytymvucjfi?.QualifyingEncounter?.Period;
            CqlInterval<CqlDateTime> t_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, s_);
            CqlDateTime u_ = context.Operators.Start(t_);
            CqlQuantity v_ = context.Operators.Quantity(1m, "day");
            CqlDateTime w_ = context.Operators.Add(u_, v_);
            bool? x_ = context.Operators.SameAs(r_, w_, "day");
            bool? y_ = context.Operators.And(o_, x_);
            object z_;
            object bj_;
            if (tuple_hbjscqgbuhismoaytymvucjfi?.ComfortMeasure is Procedure)
            {
                DataType bm_ = (tuple_hbjscqgbuhismoaytymvucjfi?.ComfortMeasure as Procedure)?.Performed;
                bj_ = bm_;
            }
            else
            {
                bj_ = null;
            }
            object bk_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bj_);
            bool bl_ = bk_ is CqlDateTime;
            if (bl_)
            {
                object bn_;
                if (tuple_hbjscqgbuhismoaytymvucjfi?.ComfortMeasure is Procedure)
                {
                    DataType bp_ = (tuple_hbjscqgbuhismoaytymvucjfi?.ComfortMeasure as Procedure)?.Performed;
                    bn_ = bp_;
                }
                else
                {
                    bn_ = null;
                }
                object bo_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bn_);
                z_ = bo_ as CqlDateTime;
            }
            else
            {
                object bq_;
                if (tuple_hbjscqgbuhismoaytymvucjfi?.ComfortMeasure is Procedure)
                {
                    DataType bt_ = (tuple_hbjscqgbuhismoaytymvucjfi?.ComfortMeasure as Procedure)?.Performed;
                    bq_ = bt_;
                }
                else
                {
                    bq_ = null;
                }
                object br_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bq_);
                bool bs_ = br_ is CqlQuantity;
                if (bs_)
                {
                    object bu_;
                    if (tuple_hbjscqgbuhismoaytymvucjfi?.ComfortMeasure is Procedure)
                    {
                        DataType bw_ = (tuple_hbjscqgbuhismoaytymvucjfi?.ComfortMeasure as Procedure)?.Performed;
                        bu_ = bw_;
                    }
                    else
                    {
                        bu_ = null;
                    }
                    object bv_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bu_);
                    z_ = bv_ as CqlQuantity;
                }
                else
                {
                    object bx_;
                    if (tuple_hbjscqgbuhismoaytymvucjfi?.ComfortMeasure is Procedure)
                    {
                        DataType ca_ = (tuple_hbjscqgbuhismoaytymvucjfi?.ComfortMeasure as Procedure)?.Performed;
                        bx_ = ca_;
                    }
                    else
                    {
                        bx_ = null;
                    }
                    object by_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bx_);
                    bool bz_ = by_ is CqlInterval<CqlDateTime>;
                    if (bz_)
                    {
                        object cb_;
                        if (tuple_hbjscqgbuhismoaytymvucjfi?.ComfortMeasure is Procedure)
                        {
                            DataType cd_ = (tuple_hbjscqgbuhismoaytymvucjfi?.ComfortMeasure as Procedure)?.Performed;
                            cb_ = cd_;
                        }
                        else
                        {
                            cb_ = null;
                        }
                        object cc_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cb_);
                        z_ = cc_ as CqlInterval<CqlDateTime>;
                    }
                    else
                    {
                        object ce_;
                        if (tuple_hbjscqgbuhismoaytymvucjfi?.ComfortMeasure is Procedure)
                        {
                            DataType ch_ = (tuple_hbjscqgbuhismoaytymvucjfi?.ComfortMeasure as Procedure)?.Performed;
                            ce_ = ch_;
                        }
                        else
                        {
                            ce_ = null;
                        }
                        object cf_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ce_);
                        bool cg_ = cf_ is CqlInterval<CqlQuantity>;
                        if (cg_)
                        {
                            object ci_;
                            if (tuple_hbjscqgbuhismoaytymvucjfi?.ComfortMeasure is Procedure)
                            {
                                DataType ck_ = (tuple_hbjscqgbuhismoaytymvucjfi?.ComfortMeasure as Procedure)?.Performed;
                                ci_ = ck_;
                            }
                            else
                            {
                                ci_ = null;
                            }
                            object cj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ci_);
                            z_ = cj_ as CqlInterval<CqlQuantity>;
                        }
                        else
                        {
                            z_ = null;
                        }
                    }
                }
            }
            CqlInterval<CqlDateTime> aa_ = QICoreCommon_4_0_000.Instance.toInterval(context, z_);
            CqlDateTime ab_ = context.Operators.Start(aa_);
            FhirDateTime ac_;
            if (tuple_hbjscqgbuhismoaytymvucjfi?.ComfortMeasure is ServiceRequest)
            {
                FhirDateTime cl_ = (tuple_hbjscqgbuhismoaytymvucjfi?.ComfortMeasure as ServiceRequest)?.AuthoredOnElement;
                ac_ = cl_;
            }
            else
            {
                ac_ = default;
            }
            CqlDateTime ad_ = context.Operators.Convert<CqlDateTime>(ac_);
            object ae_;
            DataType cm_ = tuple_hbjscqgbuhismoaytymvucjfi?.AnesthesiaProcedure?.Performed;
            object cn_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cm_);
            bool co_ = cn_ is CqlDateTime;
            if (co_)
            {
                ae_ = cn_ as CqlDateTime;
            }
            else
            {
                bool cp_ = cn_ is CqlQuantity;
                if (cp_)
                {
                    ae_ = cn_ as CqlQuantity;
                }
                else
                {
                    bool cq_ = cn_ is CqlInterval<CqlDateTime>;
                    if (cq_)
                    {
                        ae_ = cn_ as CqlInterval<CqlDateTime>;
                    }
                    else
                    {
                        bool cr_ = cn_ is CqlInterval<CqlQuantity>;
                        if (cr_)
                        {
                            ae_ = cn_ as CqlInterval<CqlQuantity>;
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
            CqlDate ai_ = ah_?.low;
            CqlDateTime aj_ = context.Operators.ConvertDateToDateTime(ai_);
            object ak_;
            DataType cs_ = tuple_hbjscqgbuhismoaytymvucjfi?.AnesthesiaProcedure?.Performed;
            object ct_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cs_);
            bool cu_ = ct_ is CqlDateTime;
            if (cu_)
            {
                ak_ = ct_ as CqlDateTime;
            }
            else
            {
                bool cv_ = ct_ is CqlQuantity;
                if (cv_)
                {
                    ak_ = ct_ as CqlQuantity;
                }
                else
                {
                    bool cw_ = ct_ is CqlInterval<CqlDateTime>;
                    if (cw_)
                    {
                        ak_ = ct_ as CqlInterval<CqlDateTime>;
                    }
                    else
                    {
                        bool cx_ = ct_ is CqlInterval<CqlQuantity>;
                        if (cx_)
                        {
                            ak_ = ct_ as CqlInterval<CqlQuantity>;
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
            CqlDate ao_ = an_?.high;
            CqlDateTime ap_ = context.Operators.ConvertDateToDateTime(ao_);
            object aq_;
            DataType cy_ = tuple_hbjscqgbuhismoaytymvucjfi?.AnesthesiaProcedure?.Performed;
            object cz_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cy_);
            bool da_ = cz_ is CqlDateTime;
            if (da_)
            {
                aq_ = cz_ as CqlDateTime;
            }
            else
            {
                bool db_ = cz_ is CqlQuantity;
                if (db_)
                {
                    aq_ = cz_ as CqlQuantity;
                }
                else
                {
                    bool dc_ = cz_ is CqlInterval<CqlDateTime>;
                    if (dc_)
                    {
                        aq_ = cz_ as CqlInterval<CqlDateTime>;
                    }
                    else
                    {
                        bool dd_ = cz_ is CqlInterval<CqlQuantity>;
                        if (dd_)
                        {
                            aq_ = cz_ as CqlInterval<CqlQuantity>;
                        }
                        else
                        {
                            aq_ = null;
                        }
                    }
                }
            }
            CqlInterval<CqlDateTime> ar_ = QICoreCommon_4_0_000.Instance.toInterval(context, aq_);
            CqlDateTime as_ = context.Operators.End(ar_);
            CqlInterval<CqlDate> at_ = TJCOverall_8_25_000.Instance.calendarDayOfOrDayAfter(context, as_);
            bool? au_ = at_?.lowClosed;
            object av_;
            DataType de_ = tuple_hbjscqgbuhismoaytymvucjfi?.AnesthesiaProcedure?.Performed;
            object df_ = FHIRHelpers_4_4_000.Instance.ToValue(context, de_);
            bool dg_ = df_ is CqlDateTime;
            if (dg_)
            {
                av_ = df_ as CqlDateTime;
            }
            else
            {
                bool dh_ = df_ is CqlQuantity;
                if (dh_)
                {
                    av_ = df_ as CqlQuantity;
                }
                else
                {
                    bool di_ = df_ is CqlInterval<CqlDateTime>;
                    if (di_)
                    {
                        av_ = df_ as CqlInterval<CqlDateTime>;
                    }
                    else
                    {
                        bool dj_ = df_ is CqlInterval<CqlQuantity>;
                        if (dj_)
                        {
                            av_ = df_ as CqlInterval<CqlQuantity>;
                        }
                        else
                        {
                            av_ = null;
                        }
                    }
                }
            }
            CqlInterval<CqlDateTime> aw_ = QICoreCommon_4_0_000.Instance.toInterval(context, av_);
            CqlDateTime ax_ = context.Operators.End(aw_);
            CqlInterval<CqlDate> ay_ = TJCOverall_8_25_000.Instance.calendarDayOfOrDayAfter(context, ax_);
            bool? az_ = ay_?.highClosed;
            CqlInterval<CqlDateTime> ba_ = context.Operators.Interval(aj_, ap_, au_, az_);
            bool? bb_ = context.Operators.In<CqlDateTime>(ab_ ?? ad_, ba_, "day");
            bool? bc_ = context.Operators.And(y_, bb_);
            return bc_;
        }

        IEnumerable<(CqlTupleMetadata, Encounter QualifyingEncounter, Procedure AnesthesiaProcedure, object ComfortMeasure)?> h_ = context.Operators.SelectWhere<ValueTuple<Encounter, Procedure, object>, (CqlTupleMetadata, Encounter QualifyingEncounter, Procedure AnesthesiaProcedure, object ComfortMeasure)?>(e_, f_, g_);
        Encounter i_((CqlTupleMetadata, Encounter QualifyingEncounter, Procedure AnesthesiaProcedure, object ComfortMeasure)? tuple_hbjscqgbuhismoaytymvucjfi) => tuple_hbjscqgbuhismoaytymvucjfi?.QualifyingEncounter;
        IEnumerable<Encounter> j_ = context.Operators.SelectDistinct<(CqlTupleMetadata, Encounter QualifyingEncounter, Procedure AnesthesiaProcedure, object ComfortMeasure)?, Encounter>(h_, i_);
        return j_;
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
        IEnumerable<MedicationAdministration> a_ = context.Operators.Retrieve<MedicationAdministration>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationadministration"));

        bool? b_(MedicationAdministration MR) {
            IEnumerable<Medication> az_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));

            bool? ba_(Medication M) {
                Id bc_ = M?.IdElement;
                string bd_ = bc_?.Value;
                FhirString be_;
                DataType bo_ = MR?.Medication;
                bool bp_ = bo_ is ResourceReference;
                if (bp_)
                {
                    FhirString bq_ = (bo_ as ResourceReference)?.ReferenceElement;
                    be_ = bq_;
                }
                else
                {
                    be_ = default;
                }
                string bf_ = be_?.Value;
                IEnumerable<string> bg_ = context.Operators.Split(bf_, "/");
                string bh_ = context.Operators.Last<string>(bg_);
                bool? bi_ = context.Operators.Equal(bd_, bh_);
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

        bool? i_(MedicationAdministration MR) {
            IEnumerable<Medication> cb_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));

            bool? cc_(Medication M) {
                Id ce_ = M?.IdElement;
                string cf_ = ce_?.Value;
                FhirString cg_;
                DataType cq_ = MR?.Medication;
                bool cr_ = cq_ is ResourceReference;
                if (cr_)
                {
                    FhirString cs_ = (cq_ as ResourceReference)?.ReferenceElement;
                    cg_ = cs_;
                }
                else
                {
                    cg_ = default;
                }
                string ch_ = cg_?.Value;
                IEnumerable<string> ci_ = context.Operators.Split(ch_, "/");
                string cj_ = context.Operators.Last<string>(ci_);
                bool? ck_ = context.Operators.Equal(cf_, cj_);
                CodeableConcept cl_ = M?.Code;
                CqlConcept cm_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, cl_);
                CqlValueSet cn_ = this.Low_Molecular_Weight_Heparin_for_VTE_Prophylaxis(context);
                bool? co_ = context.Operators.ConceptInValueSet(cm_, cn_);
                bool? cp_ = context.Operators.And(ck_, co_);
                return cp_;
            }

            bool? cd_ = context.Operators.WhereAny<Medication>(cb_, cc_);
            return cd_;
        }

        IEnumerable<MedicationAdministration> j_ = context.Operators.Where<MedicationAdministration>(a_, i_);
        CqlValueSet k_ = this.Low_Molecular_Weight_Heparin_for_VTE_Prophylaxis(context);
        IEnumerable<MedicationAdministration> l_ = context.Operators.Retrieve<MedicationAdministration>(new RetrieveParameters(default, k_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationadministration"));
        IEnumerable<MedicationAdministration> m_ = context.Operators.Union<MedicationAdministration>(j_, l_);

        bool? n_(MedicationAdministration LMWH) {
            Code<MedicationAdministration.MedicationAdministrationStatusCodes> ct_ = LMWH?.StatusElement;
            MedicationAdministration.MedicationAdministrationStatusCodes? cu_ = ct_?.Value;
            string cv_ = context.Operators.Convert<string>(cu_);
            bool? cw_ = context.Operators.Equal(cv_, "completed");
            return cw_;
        }

        IEnumerable<MedicationAdministration> o_ = context.Operators.Where<MedicationAdministration>(m_, n_);
        IEnumerable<MedicationAdministration> p_ = context.Operators.Union<MedicationAdministration>(h_, o_);

        bool? q_(MedicationAdministration MR) {
            IEnumerable<Medication> cx_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));

            bool? cy_(Medication M) {
                Id da_ = M?.IdElement;
                string db_ = da_?.Value;
                FhirString dc_;
                DataType dm_ = MR?.Medication;
                bool dn_ = dm_ is ResourceReference;
                if (dn_)
                {
                    FhirString do_ = (dm_ as ResourceReference)?.ReferenceElement;
                    dc_ = do_;
                }
                else
                {
                    dc_ = default;
                }
                string dd_ = dc_?.Value;
                IEnumerable<string> de_ = context.Operators.Split(dd_, "/");
                string df_ = context.Operators.Last<string>(de_);
                bool? dg_ = context.Operators.Equal(db_, df_);
                CodeableConcept dh_ = M?.Code;
                CqlConcept di_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, dh_);
                CqlValueSet dj_ = this.Injectable_Factor_Xa_Inhibitor_for_VTE_Prophylaxis(context);
                bool? dk_ = context.Operators.ConceptInValueSet(di_, dj_);
                bool? dl_ = context.Operators.And(dg_, dk_);
                return dl_;
            }

            bool? cz_ = context.Operators.WhereAny<Medication>(cx_, cy_);
            return cz_;
        }

        IEnumerable<MedicationAdministration> r_ = context.Operators.Where<MedicationAdministration>(a_, q_);
        CqlValueSet s_ = this.Injectable_Factor_Xa_Inhibitor_for_VTE_Prophylaxis(context);
        IEnumerable<MedicationAdministration> t_ = context.Operators.Retrieve<MedicationAdministration>(new RetrieveParameters(default, s_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationadministration"));
        IEnumerable<MedicationAdministration> u_ = context.Operators.Union<MedicationAdministration>(r_, t_);

        bool? v_(MedicationAdministration FactorXa) {
            Code<MedicationAdministration.MedicationAdministrationStatusCodes> dp_ = FactorXa?.StatusElement;
            MedicationAdministration.MedicationAdministrationStatusCodes? dq_ = dp_?.Value;
            string dr_ = context.Operators.Convert<string>(dq_);
            bool? ds_ = context.Operators.Equal(dr_, "completed");
            return ds_;
        }

        IEnumerable<MedicationAdministration> w_ = context.Operators.Where<MedicationAdministration>(u_, v_);

        bool? x_(MedicationAdministration MR) {
            IEnumerable<Medication> dt_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));

            bool? du_(Medication M) {
                Id dw_ = M?.IdElement;
                string dx_ = dw_?.Value;
                FhirString dy_;
                DataType ei_ = MR?.Medication;
                bool ej_ = ei_ is ResourceReference;
                if (ej_)
                {
                    FhirString ek_ = (ei_ as ResourceReference)?.ReferenceElement;
                    dy_ = ek_;
                }
                else
                {
                    dy_ = default;
                }
                string dz_ = dy_?.Value;
                IEnumerable<string> ea_ = context.Operators.Split(dz_, "/");
                string eb_ = context.Operators.Last<string>(ea_);
                bool? ec_ = context.Operators.Equal(dx_, eb_);
                CodeableConcept ed_ = M?.Code;
                CqlConcept ee_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, ed_);
                CqlValueSet ef_ = this.Warfarin(context);
                bool? eg_ = context.Operators.ConceptInValueSet(ee_, ef_);
                bool? eh_ = context.Operators.And(ec_, eg_);
                return eh_;
            }

            bool? dv_ = context.Operators.WhereAny<Medication>(dt_, du_);
            return dv_;
        }

        IEnumerable<MedicationAdministration> y_ = context.Operators.Where<MedicationAdministration>(a_, x_);
        CqlValueSet z_ = this.Warfarin(context);
        IEnumerable<MedicationAdministration> aa_ = context.Operators.Retrieve<MedicationAdministration>(new RetrieveParameters(default, z_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationadministration"));
        IEnumerable<MedicationAdministration> ab_ = context.Operators.Union<MedicationAdministration>(y_, aa_);

        bool? ac_(MedicationAdministration WarfarinAdm) {
            Code<MedicationAdministration.MedicationAdministrationStatusCodes> el_ = WarfarinAdm?.StatusElement;
            MedicationAdministration.MedicationAdministrationStatusCodes? em_ = el_?.Value;
            string en_ = context.Operators.Convert<string>(em_);
            bool? eo_ = context.Operators.Equal(en_, "completed");
            return eo_;
        }

        IEnumerable<MedicationAdministration> ad_ = context.Operators.Where<MedicationAdministration>(ab_, ac_);
        IEnumerable<MedicationAdministration> ae_ = context.Operators.Union<MedicationAdministration>(w_, ad_);
        IEnumerable<MedicationAdministration> af_ = context.Operators.Union<MedicationAdministration>(p_, ae_);

        bool? ag_(MedicationAdministration MR) {
            IEnumerable<Medication> ep_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));

            bool? eq_(Medication M) {
                Id es_ = M?.IdElement;
                string et_ = es_?.Value;
                FhirString eu_;
                DataType fe_ = MR?.Medication;
                bool ff_ = fe_ is ResourceReference;
                if (ff_)
                {
                    FhirString fg_ = (fe_ as ResourceReference)?.ReferenceElement;
                    eu_ = fg_;
                }
                else
                {
                    eu_ = default;
                }
                string ev_ = eu_?.Value;
                IEnumerable<string> ew_ = context.Operators.Split(ev_, "/");
                string ex_ = context.Operators.Last<string>(ew_);
                bool? ey_ = context.Operators.Equal(et_, ex_);
                CodeableConcept ez_ = M?.Code;
                CqlConcept fa_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, ez_);
                CqlValueSet fb_ = this.Rivaroxaban_for_VTE_Prophylaxis(context);
                bool? fc_ = context.Operators.ConceptInValueSet(fa_, fb_);
                bool? fd_ = context.Operators.And(ey_, fc_);
                return fd_;
            }

            bool? er_ = context.Operators.WhereAny<Medication>(ep_, eq_);
            return er_;
        }

        IEnumerable<MedicationAdministration> ah_ = context.Operators.Where<MedicationAdministration>(a_, ag_);
        CqlValueSet ai_ = this.Rivaroxaban_for_VTE_Prophylaxis(context);
        IEnumerable<MedicationAdministration> aj_ = context.Operators.Retrieve<MedicationAdministration>(new RetrieveParameters(default, ai_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationadministration"));
        IEnumerable<MedicationAdministration> ak_ = context.Operators.Union<MedicationAdministration>(ah_, aj_);

        bool? al_(MedicationAdministration Rivaroxaban) {
            Code<MedicationAdministration.MedicationAdministrationStatusCodes> fh_ = Rivaroxaban?.StatusElement;
            MedicationAdministration.MedicationAdministrationStatusCodes? fi_ = fh_?.Value;
            string fj_ = context.Operators.Convert<string>(fi_);
            bool? fk_ = context.Operators.Equal(fj_, "completed");
            return fk_;
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
            Code<EventStatus> fl_ = DeviceApplied?.StatusElement;
            EventStatus? fm_ = fl_?.Value;
            string fn_ = context.Operators.Convert<string>(fm_);
            bool? fo_ = context.Operators.Equal(fn_, "completed");
            return fo_;
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
            (CqlTupleMetadata, Encounter QualifyingEncounter, object VTEProphylaxis)? r_ = (CqlTupleMetadata_DQDJDfNDAVfLFYEjYSBYIhgSj, _valueTuple.Item1, _valueTuple.Item2);
            return r_;
        }


        bool? e_((CqlTupleMetadata, Encounter QualifyingEncounter, object VTEProphylaxis)? tuple_dqdjdfndavflfyejysbyihgsj) {
            object s_;
            if (tuple_dqdjdfndavflfyejysbyihgsj?.VTEProphylaxis is MedicationAdministration)
            {
                DataType ah_ = (tuple_dqdjdfndavflfyejysbyihgsj?.VTEProphylaxis as MedicationAdministration)?.Effective;
                s_ = ah_;
            }
            else
            {
                s_ = null;
            }
            object t_ = FHIRHelpers_4_4_000.Instance.ToValue(context, s_);
            CqlInterval<CqlDateTime> u_ = QICoreCommon_4_0_000.Instance.toInterval(context, t_);
            object v_;
            object ai_;
            if (tuple_dqdjdfndavflfyejysbyihgsj?.VTEProphylaxis is Procedure)
            {
                DataType al_ = (tuple_dqdjdfndavflfyejysbyihgsj?.VTEProphylaxis as Procedure)?.Performed;
                ai_ = al_;
            }
            else
            {
                ai_ = null;
            }
            object aj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ai_);
            bool ak_ = aj_ is CqlDateTime;
            if (ak_)
            {
                object am_;
                if (tuple_dqdjdfndavflfyejysbyihgsj?.VTEProphylaxis is Procedure)
                {
                    DataType ao_ = (tuple_dqdjdfndavflfyejysbyihgsj?.VTEProphylaxis as Procedure)?.Performed;
                    am_ = ao_;
                }
                else
                {
                    am_ = null;
                }
                object an_ = FHIRHelpers_4_4_000.Instance.ToValue(context, am_);
                v_ = an_ as CqlDateTime;
            }
            else
            {
                object ap_;
                if (tuple_dqdjdfndavflfyejysbyihgsj?.VTEProphylaxis is Procedure)
                {
                    DataType as_ = (tuple_dqdjdfndavflfyejysbyihgsj?.VTEProphylaxis as Procedure)?.Performed;
                    ap_ = as_;
                }
                else
                {
                    ap_ = null;
                }
                object aq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ap_);
                bool ar_ = aq_ is CqlQuantity;
                if (ar_)
                {
                    object at_;
                    if (tuple_dqdjdfndavflfyejysbyihgsj?.VTEProphylaxis is Procedure)
                    {
                        DataType av_ = (tuple_dqdjdfndavflfyejysbyihgsj?.VTEProphylaxis as Procedure)?.Performed;
                        at_ = av_;
                    }
                    else
                    {
                        at_ = null;
                    }
                    object au_ = FHIRHelpers_4_4_000.Instance.ToValue(context, at_);
                    v_ = au_ as CqlQuantity;
                }
                else
                {
                    object aw_;
                    if (tuple_dqdjdfndavflfyejysbyihgsj?.VTEProphylaxis is Procedure)
                    {
                        DataType az_ = (tuple_dqdjdfndavflfyejysbyihgsj?.VTEProphylaxis as Procedure)?.Performed;
                        aw_ = az_;
                    }
                    else
                    {
                        aw_ = null;
                    }
                    object ax_ = FHIRHelpers_4_4_000.Instance.ToValue(context, aw_);
                    bool ay_ = ax_ is CqlInterval<CqlDateTime>;
                    if (ay_)
                    {
                        object ba_;
                        if (tuple_dqdjdfndavflfyejysbyihgsj?.VTEProphylaxis is Procedure)
                        {
                            DataType bc_ = (tuple_dqdjdfndavflfyejysbyihgsj?.VTEProphylaxis as Procedure)?.Performed;
                            ba_ = bc_;
                        }
                        else
                        {
                            ba_ = null;
                        }
                        object bb_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ba_);
                        v_ = bb_ as CqlInterval<CqlDateTime>;
                    }
                    else
                    {
                        object bd_;
                        if (tuple_dqdjdfndavflfyejysbyihgsj?.VTEProphylaxis is Procedure)
                        {
                            DataType bg_ = (tuple_dqdjdfndavflfyejysbyihgsj?.VTEProphylaxis as Procedure)?.Performed;
                            bd_ = bg_;
                        }
                        else
                        {
                            bd_ = null;
                        }
                        object be_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bd_);
                        bool bf_ = be_ is CqlInterval<CqlQuantity>;
                        if (bf_)
                        {
                            object bh_;
                            if (tuple_dqdjdfndavflfyejysbyihgsj?.VTEProphylaxis is Procedure)
                            {
                                DataType bj_ = (tuple_dqdjdfndavflfyejysbyihgsj?.VTEProphylaxis as Procedure)?.Performed;
                                bh_ = bj_;
                            }
                            else
                            {
                                bh_ = null;
                            }
                            object bi_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bh_);
                            v_ = bi_ as CqlInterval<CqlQuantity>;
                        }
                        else
                        {
                            v_ = null;
                        }
                    }
                }
            }
            CqlInterval<CqlDateTime> w_ = QICoreCommon_4_0_000.Instance.toInterval(context, v_);
            CqlDateTime x_ = context.Operators.Start(u_ ?? w_);
            CqlInterval<CqlDate> y_ = this.fromDayOfStartOfHospitalizationToDayAfterAdmission(context, tuple_dqdjdfndavflfyejysbyihgsj?.QualifyingEncounter);
            CqlDate z_ = y_?.low;
            CqlDateTime aa_ = context.Operators.ConvertDateToDateTime(z_);
            CqlDate ab_ = y_?.high;
            CqlDateTime ac_ = context.Operators.ConvertDateToDateTime(ab_);
            bool? ad_ = y_?.lowClosed;
            bool? ae_ = y_?.highClosed;
            CqlInterval<CqlDateTime> af_ = context.Operators.Interval(aa_, ac_, ad_, ae_);
            bool? ag_ = context.Operators.In<CqlDateTime>(x_, af_, "day");
            return ag_;
        }

        IEnumerable<(CqlTupleMetadata, Encounter QualifyingEncounter, object VTEProphylaxis)?> f_ = context.Operators.SelectWhere<ValueTuple<Encounter, object>, (CqlTupleMetadata, Encounter QualifyingEncounter, object VTEProphylaxis)?>(c_, d_, e_);
        Encounter g_((CqlTupleMetadata, Encounter QualifyingEncounter, object VTEProphylaxis)? tuple_dqdjdfndavflfyejysbyihgsj) => tuple_dqdjdfndavflfyejysbyihgsj?.QualifyingEncounter;
        IEnumerable<Encounter> h_ = context.Operators.SelectDistinct<(CqlTupleMetadata, Encounter QualifyingEncounter, object VTEProphylaxis)?, Encounter>(f_, g_);
        CqlValueSet i_ = this.General_or_Neuraxial_Anesthesia(context);
        IEnumerable<Procedure> j_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, i_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
        IEnumerable<ValueTuple<Encounter, Procedure, object>> k_ = context.Operators.CrossJoin<Encounter, Procedure, object>(a_, j_, b_);

        (CqlTupleMetadata, Encounter QualifyingEncounter, Procedure AnesthesiaProcedure, object VTEProphylaxis)? l_(ValueTuple<Encounter, Procedure, object> _valueTuple) {
            (CqlTupleMetadata, Encounter QualifyingEncounter, Procedure AnesthesiaProcedure, object VTEProphylaxis)? bk_ = (CqlTupleMetadata_CfSFUFiTWJJfiZASQhERUdATP, _valueTuple.Item1, _valueTuple.Item2, _valueTuple.Item3);
            return bk_;
        }


        bool? m_((CqlTupleMetadata, Encounter QualifyingEncounter, Procedure AnesthesiaProcedure, object VTEProphylaxis)? tuple_bnvctjfzpousixdcefwhciwq) {
            Code<EventStatus> bl_ = tuple_bnvctjfzpousixdcefwhciwq?.AnesthesiaProcedure?.StatusElement;
            EventStatus? bm_ = bl_?.Value;
            string bn_ = context.Operators.Convert<string>(bm_);
            bool? bo_ = context.Operators.Equal(bn_, "completed");
            object bp_;
            DataType de_ = tuple_bnvctjfzpousixdcefwhciwq?.AnesthesiaProcedure?.Performed;
            object df_ = FHIRHelpers_4_4_000.Instance.ToValue(context, de_);
            bool dg_ = df_ is CqlDateTime;
            if (dg_)
            {
                bp_ = df_ as CqlDateTime;
            }
            else
            {
                bool dh_ = df_ is CqlQuantity;
                if (dh_)
                {
                    bp_ = df_ as CqlQuantity;
                }
                else
                {
                    bool di_ = df_ is CqlInterval<CqlDateTime>;
                    if (di_)
                    {
                        bp_ = df_ as CqlInterval<CqlDateTime>;
                    }
                    else
                    {
                        bool dj_ = df_ is CqlInterval<CqlQuantity>;
                        if (dj_)
                        {
                            bp_ = df_ as CqlInterval<CqlQuantity>;
                        }
                        else
                        {
                            bp_ = null;
                        }
                    }
                }
            }
            CqlInterval<CqlDateTime> bq_ = QICoreCommon_4_0_000.Instance.toInterval(context, bp_);
            CqlDateTime br_ = context.Operators.End(bq_);
            Period bs_ = tuple_bnvctjfzpousixdcefwhciwq?.QualifyingEncounter?.Period;
            CqlInterval<CqlDateTime> bt_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, bs_);
            CqlDateTime bu_ = context.Operators.Start(bt_);
            CqlQuantity bv_ = context.Operators.Quantity(1m, "day");
            CqlDateTime bw_ = context.Operators.Add(bu_, bv_);
            bool? bx_ = context.Operators.SameAs(br_, bw_, "day");
            bool? by_ = context.Operators.And(bo_, bx_);
            object bz_;
            if (tuple_bnvctjfzpousixdcefwhciwq?.VTEProphylaxis is MedicationAdministration)
            {
                DataType dk_ = (tuple_bnvctjfzpousixdcefwhciwq?.VTEProphylaxis as MedicationAdministration)?.Effective;
                bz_ = dk_;
            }
            else
            {
                bz_ = null;
            }
            object ca_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bz_);
            CqlInterval<CqlDateTime> cb_ = QICoreCommon_4_0_000.Instance.toInterval(context, ca_);
            object cc_;
            object dl_;
            if (tuple_bnvctjfzpousixdcefwhciwq?.VTEProphylaxis is Procedure)
            {
                DataType do_ = (tuple_bnvctjfzpousixdcefwhciwq?.VTEProphylaxis as Procedure)?.Performed;
                dl_ = do_;
            }
            else
            {
                dl_ = null;
            }
            object dm_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dl_);
            bool dn_ = dm_ is CqlDateTime;
            if (dn_)
            {
                object dp_;
                if (tuple_bnvctjfzpousixdcefwhciwq?.VTEProphylaxis is Procedure)
                {
                    DataType dr_ = (tuple_bnvctjfzpousixdcefwhciwq?.VTEProphylaxis as Procedure)?.Performed;
                    dp_ = dr_;
                }
                else
                {
                    dp_ = null;
                }
                object dq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dp_);
                cc_ = dq_ as CqlDateTime;
            }
            else
            {
                object ds_;
                if (tuple_bnvctjfzpousixdcefwhciwq?.VTEProphylaxis is Procedure)
                {
                    DataType dv_ = (tuple_bnvctjfzpousixdcefwhciwq?.VTEProphylaxis as Procedure)?.Performed;
                    ds_ = dv_;
                }
                else
                {
                    ds_ = null;
                }
                object dt_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ds_);
                bool du_ = dt_ is CqlQuantity;
                if (du_)
                {
                    object dw_;
                    if (tuple_bnvctjfzpousixdcefwhciwq?.VTEProphylaxis is Procedure)
                    {
                        DataType dy_ = (tuple_bnvctjfzpousixdcefwhciwq?.VTEProphylaxis as Procedure)?.Performed;
                        dw_ = dy_;
                    }
                    else
                    {
                        dw_ = null;
                    }
                    object dx_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dw_);
                    cc_ = dx_ as CqlQuantity;
                }
                else
                {
                    object dz_;
                    if (tuple_bnvctjfzpousixdcefwhciwq?.VTEProphylaxis is Procedure)
                    {
                        DataType ec_ = (tuple_bnvctjfzpousixdcefwhciwq?.VTEProphylaxis as Procedure)?.Performed;
                        dz_ = ec_;
                    }
                    else
                    {
                        dz_ = null;
                    }
                    object ea_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dz_);
                    bool eb_ = ea_ is CqlInterval<CqlDateTime>;
                    if (eb_)
                    {
                        object ed_;
                        if (tuple_bnvctjfzpousixdcefwhciwq?.VTEProphylaxis is Procedure)
                        {
                            DataType ef_ = (tuple_bnvctjfzpousixdcefwhciwq?.VTEProphylaxis as Procedure)?.Performed;
                            ed_ = ef_;
                        }
                        else
                        {
                            ed_ = null;
                        }
                        object ee_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ed_);
                        cc_ = ee_ as CqlInterval<CqlDateTime>;
                    }
                    else
                    {
                        object eg_;
                        if (tuple_bnvctjfzpousixdcefwhciwq?.VTEProphylaxis is Procedure)
                        {
                            DataType ej_ = (tuple_bnvctjfzpousixdcefwhciwq?.VTEProphylaxis as Procedure)?.Performed;
                            eg_ = ej_;
                        }
                        else
                        {
                            eg_ = null;
                        }
                        object eh_ = FHIRHelpers_4_4_000.Instance.ToValue(context, eg_);
                        bool ei_ = eh_ is CqlInterval<CqlQuantity>;
                        if (ei_)
                        {
                            object ek_;
                            if (tuple_bnvctjfzpousixdcefwhciwq?.VTEProphylaxis is Procedure)
                            {
                                DataType em_ = (tuple_bnvctjfzpousixdcefwhciwq?.VTEProphylaxis as Procedure)?.Performed;
                                ek_ = em_;
                            }
                            else
                            {
                                ek_ = null;
                            }
                            object el_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ek_);
                            cc_ = el_ as CqlInterval<CqlQuantity>;
                        }
                        else
                        {
                            cc_ = null;
                        }
                    }
                }
            }
            CqlInterval<CqlDateTime> cd_ = QICoreCommon_4_0_000.Instance.toInterval(context, cc_);
            CqlDateTime ce_ = context.Operators.Start(cb_ ?? cd_);
            object cf_;
            DataType en_ = tuple_bnvctjfzpousixdcefwhciwq?.AnesthesiaProcedure?.Performed;
            object eo_ = FHIRHelpers_4_4_000.Instance.ToValue(context, en_);
            bool ep_ = eo_ is CqlDateTime;
            if (ep_)
            {
                cf_ = eo_ as CqlDateTime;
            }
            else
            {
                bool eq_ = eo_ is CqlQuantity;
                if (eq_)
                {
                    cf_ = eo_ as CqlQuantity;
                }
                else
                {
                    bool er_ = eo_ is CqlInterval<CqlDateTime>;
                    if (er_)
                    {
                        cf_ = eo_ as CqlInterval<CqlDateTime>;
                    }
                    else
                    {
                        bool es_ = eo_ is CqlInterval<CqlQuantity>;
                        if (es_)
                        {
                            cf_ = eo_ as CqlInterval<CqlQuantity>;
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
            CqlDate cj_ = ci_?.low;
            CqlDateTime ck_ = context.Operators.ConvertDateToDateTime(cj_);
            object cl_;
            DataType et_ = tuple_bnvctjfzpousixdcefwhciwq?.AnesthesiaProcedure?.Performed;
            object eu_ = FHIRHelpers_4_4_000.Instance.ToValue(context, et_);
            bool ev_ = eu_ is CqlDateTime;
            if (ev_)
            {
                cl_ = eu_ as CqlDateTime;
            }
            else
            {
                bool ew_ = eu_ is CqlQuantity;
                if (ew_)
                {
                    cl_ = eu_ as CqlQuantity;
                }
                else
                {
                    bool ex_ = eu_ is CqlInterval<CqlDateTime>;
                    if (ex_)
                    {
                        cl_ = eu_ as CqlInterval<CqlDateTime>;
                    }
                    else
                    {
                        bool ey_ = eu_ is CqlInterval<CqlQuantity>;
                        if (ey_)
                        {
                            cl_ = eu_ as CqlInterval<CqlQuantity>;
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
            CqlInterval<CqlDate> co_ = TJCOverall_8_25_000.Instance.calendarDayOfOrDayAfter(context, cn_);
            CqlDate cp_ = co_?.high;
            CqlDateTime cq_ = context.Operators.ConvertDateToDateTime(cp_);
            object cr_;
            DataType ez_ = tuple_bnvctjfzpousixdcefwhciwq?.AnesthesiaProcedure?.Performed;
            object fa_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ez_);
            bool fb_ = fa_ is CqlDateTime;
            if (fb_)
            {
                cr_ = fa_ as CqlDateTime;
            }
            else
            {
                bool fc_ = fa_ is CqlQuantity;
                if (fc_)
                {
                    cr_ = fa_ as CqlQuantity;
                }
                else
                {
                    bool fd_ = fa_ is CqlInterval<CqlDateTime>;
                    if (fd_)
                    {
                        cr_ = fa_ as CqlInterval<CqlDateTime>;
                    }
                    else
                    {
                        bool fe_ = fa_ is CqlInterval<CqlQuantity>;
                        if (fe_)
                        {
                            cr_ = fa_ as CqlInterval<CqlQuantity>;
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
            bool? cv_ = cu_?.lowClosed;
            object cw_;
            DataType ff_ = tuple_bnvctjfzpousixdcefwhciwq?.AnesthesiaProcedure?.Performed;
            object fg_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ff_);
            bool fh_ = fg_ is CqlDateTime;
            if (fh_)
            {
                cw_ = fg_ as CqlDateTime;
            }
            else
            {
                bool fi_ = fg_ is CqlQuantity;
                if (fi_)
                {
                    cw_ = fg_ as CqlQuantity;
                }
                else
                {
                    bool fj_ = fg_ is CqlInterval<CqlDateTime>;
                    if (fj_)
                    {
                        cw_ = fg_ as CqlInterval<CqlDateTime>;
                    }
                    else
                    {
                        bool fk_ = fg_ is CqlInterval<CqlQuantity>;
                        if (fk_)
                        {
                            cw_ = fg_ as CqlInterval<CqlQuantity>;
                        }
                        else
                        {
                            cw_ = null;
                        }
                    }
                }
            }
            CqlInterval<CqlDateTime> cx_ = QICoreCommon_4_0_000.Instance.toInterval(context, cw_);
            CqlDateTime cy_ = context.Operators.End(cx_);
            CqlInterval<CqlDate> cz_ = TJCOverall_8_25_000.Instance.calendarDayOfOrDayAfter(context, cy_);
            bool? da_ = cz_?.highClosed;
            CqlInterval<CqlDateTime> db_ = context.Operators.Interval(ck_, cq_, cv_, da_);
            bool? dc_ = context.Operators.In<CqlDateTime>(ce_, db_, "day");
            bool? dd_ = context.Operators.And(by_, dc_);
            return dd_;
        }

        IEnumerable<(CqlTupleMetadata, Encounter QualifyingEncounter, Procedure AnesthesiaProcedure, object VTEProphylaxis)?> n_ = context.Operators.SelectWhere<ValueTuple<Encounter, Procedure, object>, (CqlTupleMetadata, Encounter QualifyingEncounter, Procedure AnesthesiaProcedure, object VTEProphylaxis)?>(k_, l_, m_);
        Encounter o_((CqlTupleMetadata, Encounter QualifyingEncounter, Procedure AnesthesiaProcedure, object VTEProphylaxis)? tuple_bnvctjfzpousixdcefwhciwq) => tuple_bnvctjfzpousixdcefwhciwq?.QualifyingEncounter;
        IEnumerable<Encounter> p_ = context.Operators.SelectDistinct<(CqlTupleMetadata, Encounter QualifyingEncounter, Procedure AnesthesiaProcedure, object VTEProphylaxis)?, Encounter>(n_, o_);
        IEnumerable<Encounter> q_ = context.Operators.Union<Encounter>(h_, p_);
        return q_;
    }


    [CqlExpressionDefinition("Encounter With Medication Oral Factor Xa Inhibitor Administered On Day Of Or Day After Admission Or Procedure")]
    public IEnumerable<Encounter> Encounter_With_Medication_Oral_Factor_Xa_Inhibitor_Administered_On_Day_Of_Or_Day_After_Admission_Or_Procedure(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Encounter_With_Medication_Oral_Factor_Xa_Inhibitor_Administered_On_Day_Of_Or_Day_After_Admission_Or_Procedure, Encounter_With_Medication_Oral_Factor_Xa_Inhibitor_Administered_On_Day_Of_Or_Day_After_Admission_Or_Procedure_Compute);

    private const long _cacheIndex_Encounter_With_Medication_Oral_Factor_Xa_Inhibitor_Administered_On_Day_Of_Or_Day_After_Admission_Or_Procedure = 3422895210558274894L;

    private IEnumerable<Encounter> Encounter_With_Medication_Oral_Factor_Xa_Inhibitor_Administered_On_Day_Of_Or_Day_After_Admission_Or_Procedure_Compute(CqlContext context)
    {
        IEnumerable<Encounter> a_ = VTE_8_18_000.Instance.Encounter_With_Age_Range_And_Without_VTE_Diagnosis_Or_Obstetrical_Conditions(context);
        IEnumerable<MedicationAdministration> b_ = context.Operators.Retrieve<MedicationAdministration>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationadministration"));

        bool? c_(MedicationAdministration MR) {
            IEnumerable<Medication> z_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));

            bool? aa_(Medication M) {
                Id ac_ = M?.IdElement;
                string ad_ = ac_?.Value;
                FhirString ae_;
                DataType ao_ = MR?.Medication;
                bool ap_ = ao_ is ResourceReference;
                if (ap_)
                {
                    FhirString aq_ = (ao_ as ResourceReference)?.ReferenceElement;
                    ae_ = aq_;
                }
                else
                {
                    ae_ = default;
                }
                string af_ = ae_?.Value;
                IEnumerable<string> ag_ = context.Operators.Split(af_, "/");
                string ah_ = context.Operators.Last<string>(ag_);
                bool? ai_ = context.Operators.Equal(ad_, ah_);
                CodeableConcept aj_ = M?.Code;
                CqlConcept ak_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, aj_);
                CqlValueSet al_ = this.Oral_Factor_Xa_Inhibitor_for_VTE_Prophylaxis_or_VTE_Treatment(context);
                bool? am_ = context.Operators.ConceptInValueSet(ak_, al_);
                bool? an_ = context.Operators.And(ai_, am_);
                return an_;
            }

            bool? ab_ = context.Operators.WhereAny<Medication>(z_, aa_);
            return ab_;
        }

        IEnumerable<MedicationAdministration> d_ = context.Operators.Where<MedicationAdministration>(b_, c_);
        CqlValueSet e_ = this.Oral_Factor_Xa_Inhibitor_for_VTE_Prophylaxis_or_VTE_Treatment(context);
        IEnumerable<MedicationAdministration> f_ = context.Operators.Retrieve<MedicationAdministration>(new RetrieveParameters(default, e_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationadministration"));
        IEnumerable<MedicationAdministration> g_ = context.Operators.Union<MedicationAdministration>(d_, f_);
        IEnumerable<ValueTuple<Encounter, MedicationAdministration>> h_ = context.Operators.CrossJoin<Encounter, MedicationAdministration>(a_, g_);

        (CqlTupleMetadata, Encounter QualifyingEncounter, MedicationAdministration FactorXaMedication)? i_(ValueTuple<Encounter, MedicationAdministration> _valueTuple) {
            (CqlTupleMetadata, Encounter QualifyingEncounter, MedicationAdministration FactorXaMedication)? ar_ = (CqlTupleMetadata_EBRQeiSMaTgecHVEbVOIMZEcb, _valueTuple.Item1, _valueTuple.Item2);
            return ar_;
        }


        bool? j_((CqlTupleMetadata, Encounter QualifyingEncounter, MedicationAdministration FactorXaMedication)? tuple_cdbvhiekdcojzrccbhjghhgeo) {
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

        IEnumerable<(CqlTupleMetadata, Encounter QualifyingEncounter, MedicationAdministration FactorXaMedication)?> k_ = context.Operators.SelectWhere<ValueTuple<Encounter, MedicationAdministration>, (CqlTupleMetadata, Encounter QualifyingEncounter, MedicationAdministration FactorXaMedication)?>(h_, i_, j_);
        Encounter l_((CqlTupleMetadata, Encounter QualifyingEncounter, MedicationAdministration FactorXaMedication)? tuple_cdbvhiekdcojzrccbhjghhgeo) => tuple_cdbvhiekdcojzrccbhjghhgeo?.QualifyingEncounter;
        IEnumerable<Encounter> m_ = context.Operators.SelectDistinct<(CqlTupleMetadata, Encounter QualifyingEncounter, MedicationAdministration FactorXaMedication)?, Encounter>(k_, l_);
        CqlValueSet n_ = this.General_or_Neuraxial_Anesthesia(context);
        IEnumerable<Procedure> o_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, n_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));

        bool? p_(MedicationAdministration MR) {
            IEnumerable<Medication> bn_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));

            bool? bo_(Medication M) {
                Id bq_ = M?.IdElement;
                string br_ = bq_?.Value;
                FhirString bs_;
                DataType cc_ = MR?.Medication;
                bool cd_ = cc_ is ResourceReference;
                if (cd_)
                {
                    FhirString ce_ = (cc_ as ResourceReference)?.ReferenceElement;
                    bs_ = ce_;
                }
                else
                {
                    bs_ = default;
                }
                string bt_ = bs_?.Value;
                IEnumerable<string> bu_ = context.Operators.Split(bt_, "/");
                string bv_ = context.Operators.Last<string>(bu_);
                bool? bw_ = context.Operators.Equal(br_, bv_);
                CodeableConcept bx_ = M?.Code;
                CqlConcept by_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, bx_);
                CqlValueSet bz_ = this.Oral_Factor_Xa_Inhibitor_for_VTE_Prophylaxis_or_VTE_Treatment(context);
                bool? ca_ = context.Operators.ConceptInValueSet(by_, bz_);
                bool? cb_ = context.Operators.And(bw_, ca_);
                return cb_;
            }

            bool? bp_ = context.Operators.WhereAny<Medication>(bn_, bo_);
            return bp_;
        }

        IEnumerable<MedicationAdministration> q_ = context.Operators.Where<MedicationAdministration>(b_, p_);
        IEnumerable<MedicationAdministration> r_ = context.Operators.Union<MedicationAdministration>(q_, f_);
        IEnumerable<ValueTuple<Encounter, Procedure, MedicationAdministration>> s_ = context.Operators.CrossJoin<Encounter, Procedure, MedicationAdministration>(a_, o_, r_);

        (CqlTupleMetadata, Encounter QualifyingEncounter, Procedure AnesthesiaProcedure, MedicationAdministration FactorXaMedication)? t_(ValueTuple<Encounter, Procedure, MedicationAdministration> _valueTuple) {
            (CqlTupleMetadata, Encounter QualifyingEncounter, Procedure AnesthesiaProcedure, MedicationAdministration FactorXaMedication)? cf_ = (CqlTupleMetadata_CdgLdDFHNTDXFGGVTOMXhQZR, _valueTuple.Item1, _valueTuple.Item2, _valueTuple.Item3);
            return cf_;
        }


        bool? u_((CqlTupleMetadata, Encounter QualifyingEncounter, Procedure AnesthesiaProcedure, MedicationAdministration FactorXaMedication)? tuple_dejnabiogwrwyxienqokgepgj) {
            Code<MedicationAdministration.MedicationAdministrationStatusCodes> cg_ = tuple_dejnabiogwrwyxienqokgepgj?.FactorXaMedication?.StatusElement;
            MedicationAdministration.MedicationAdministrationStatusCodes? ch_ = cg_?.Value;
            string ci_ = context.Operators.Convert<string>(ch_);
            bool? cj_ = context.Operators.Equal(ci_, "completed");
            Code<EventStatus> ck_ = tuple_dejnabiogwrwyxienqokgepgj?.AnesthesiaProcedure?.StatusElement;
            EventStatus? cl_ = ck_?.Value;
            string cm_ = context.Operators.Convert<string>(cl_);
            bool? cn_ = context.Operators.Equal(cm_, "completed");
            bool? co_ = context.Operators.And(cj_, cn_);
            object cp_;
            DataType ec_ = tuple_dejnabiogwrwyxienqokgepgj?.AnesthesiaProcedure?.Performed;
            object ed_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ec_);
            bool ee_ = ed_ is CqlDateTime;
            if (ee_)
            {
                cp_ = ed_ as CqlDateTime;
            }
            else
            {
                bool ef_ = ed_ is CqlQuantity;
                if (ef_)
                {
                    cp_ = ed_ as CqlQuantity;
                }
                else
                {
                    bool eg_ = ed_ is CqlInterval<CqlDateTime>;
                    if (eg_)
                    {
                        cp_ = ed_ as CqlInterval<CqlDateTime>;
                    }
                    else
                    {
                        bool eh_ = ed_ is CqlInterval<CqlQuantity>;
                        if (eh_)
                        {
                            cp_ = ed_ as CqlInterval<CqlQuantity>;
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
            Period cs_ = tuple_dejnabiogwrwyxienqokgepgj?.QualifyingEncounter?.Period;
            CqlInterval<CqlDateTime> ct_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, cs_);
            CqlDateTime cu_ = context.Operators.Start(ct_);
            CqlQuantity cv_ = context.Operators.Quantity(1m, "day");
            CqlDateTime cw_ = context.Operators.Add(cu_, cv_);
            bool? cx_ = context.Operators.SameAs(cr_, cw_, "day");
            bool? cy_ = context.Operators.And(co_, cx_);
            DataType cz_ = tuple_dejnabiogwrwyxienqokgepgj?.FactorXaMedication?.Effective;
            object da_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cz_);
            CqlInterval<CqlDateTime> db_ = QICoreCommon_4_0_000.Instance.toInterval(context, da_);
            CqlDateTime dc_ = context.Operators.Start(db_);
            object dd_;
            DataType ei_ = tuple_dejnabiogwrwyxienqokgepgj?.AnesthesiaProcedure?.Performed;
            object ej_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ei_);
            bool ek_ = ej_ is CqlDateTime;
            if (ek_)
            {
                dd_ = ej_ as CqlDateTime;
            }
            else
            {
                bool el_ = ej_ is CqlQuantity;
                if (el_)
                {
                    dd_ = ej_ as CqlQuantity;
                }
                else
                {
                    bool em_ = ej_ is CqlInterval<CqlDateTime>;
                    if (em_)
                    {
                        dd_ = ej_ as CqlInterval<CqlDateTime>;
                    }
                    else
                    {
                        bool en_ = ej_ is CqlInterval<CqlQuantity>;
                        if (en_)
                        {
                            dd_ = ej_ as CqlInterval<CqlQuantity>;
                        }
                        else
                        {
                            dd_ = null;
                        }
                    }
                }
            }
            CqlInterval<CqlDateTime> de_ = QICoreCommon_4_0_000.Instance.toInterval(context, dd_);
            CqlDateTime df_ = context.Operators.End(de_);
            CqlInterval<CqlDate> dg_ = TJCOverall_8_25_000.Instance.calendarDayOfOrDayAfter(context, df_);
            CqlDate dh_ = dg_?.low;
            CqlDateTime di_ = context.Operators.ConvertDateToDateTime(dh_);
            object dj_;
            DataType eo_ = tuple_dejnabiogwrwyxienqokgepgj?.AnesthesiaProcedure?.Performed;
            object ep_ = FHIRHelpers_4_4_000.Instance.ToValue(context, eo_);
            bool eq_ = ep_ is CqlDateTime;
            if (eq_)
            {
                dj_ = ep_ as CqlDateTime;
            }
            else
            {
                bool er_ = ep_ is CqlQuantity;
                if (er_)
                {
                    dj_ = ep_ as CqlQuantity;
                }
                else
                {
                    bool es_ = ep_ is CqlInterval<CqlDateTime>;
                    if (es_)
                    {
                        dj_ = ep_ as CqlInterval<CqlDateTime>;
                    }
                    else
                    {
                        bool et_ = ep_ is CqlInterval<CqlQuantity>;
                        if (et_)
                        {
                            dj_ = ep_ as CqlInterval<CqlQuantity>;
                        }
                        else
                        {
                            dj_ = null;
                        }
                    }
                }
            }
            CqlInterval<CqlDateTime> dk_ = QICoreCommon_4_0_000.Instance.toInterval(context, dj_);
            CqlDateTime dl_ = context.Operators.End(dk_);
            CqlInterval<CqlDate> dm_ = TJCOverall_8_25_000.Instance.calendarDayOfOrDayAfter(context, dl_);
            CqlDate dn_ = dm_?.high;
            CqlDateTime do_ = context.Operators.ConvertDateToDateTime(dn_);
            object dp_;
            DataType eu_ = tuple_dejnabiogwrwyxienqokgepgj?.AnesthesiaProcedure?.Performed;
            object ev_ = FHIRHelpers_4_4_000.Instance.ToValue(context, eu_);
            bool ew_ = ev_ is CqlDateTime;
            if (ew_)
            {
                dp_ = ev_ as CqlDateTime;
            }
            else
            {
                bool ex_ = ev_ is CqlQuantity;
                if (ex_)
                {
                    dp_ = ev_ as CqlQuantity;
                }
                else
                {
                    bool ey_ = ev_ is CqlInterval<CqlDateTime>;
                    if (ey_)
                    {
                        dp_ = ev_ as CqlInterval<CqlDateTime>;
                    }
                    else
                    {
                        bool ez_ = ev_ is CqlInterval<CqlQuantity>;
                        if (ez_)
                        {
                            dp_ = ev_ as CqlInterval<CqlQuantity>;
                        }
                        else
                        {
                            dp_ = null;
                        }
                    }
                }
            }
            CqlInterval<CqlDateTime> dq_ = QICoreCommon_4_0_000.Instance.toInterval(context, dp_);
            CqlDateTime dr_ = context.Operators.End(dq_);
            CqlInterval<CqlDate> ds_ = TJCOverall_8_25_000.Instance.calendarDayOfOrDayAfter(context, dr_);
            bool? dt_ = ds_?.lowClosed;
            object du_;
            DataType fa_ = tuple_dejnabiogwrwyxienqokgepgj?.AnesthesiaProcedure?.Performed;
            object fb_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fa_);
            bool fc_ = fb_ is CqlDateTime;
            if (fc_)
            {
                du_ = fb_ as CqlDateTime;
            }
            else
            {
                bool fd_ = fb_ is CqlQuantity;
                if (fd_)
                {
                    du_ = fb_ as CqlQuantity;
                }
                else
                {
                    bool fe_ = fb_ is CqlInterval<CqlDateTime>;
                    if (fe_)
                    {
                        du_ = fb_ as CqlInterval<CqlDateTime>;
                    }
                    else
                    {
                        bool ff_ = fb_ is CqlInterval<CqlQuantity>;
                        if (ff_)
                        {
                            du_ = fb_ as CqlInterval<CqlQuantity>;
                        }
                        else
                        {
                            du_ = null;
                        }
                    }
                }
            }
            CqlInterval<CqlDateTime> dv_ = QICoreCommon_4_0_000.Instance.toInterval(context, du_);
            CqlDateTime dw_ = context.Operators.End(dv_);
            CqlInterval<CqlDate> dx_ = TJCOverall_8_25_000.Instance.calendarDayOfOrDayAfter(context, dw_);
            bool? dy_ = dx_?.highClosed;
            CqlInterval<CqlDateTime> dz_ = context.Operators.Interval(di_, do_, dt_, dy_);
            bool? ea_ = context.Operators.In<CqlDateTime>(dc_, dz_, "day");
            bool? eb_ = context.Operators.And(cy_, ea_);
            return eb_;
        }

        IEnumerable<(CqlTupleMetadata, Encounter QualifyingEncounter, Procedure AnesthesiaProcedure, MedicationAdministration FactorXaMedication)?> v_ = context.Operators.SelectWhere<ValueTuple<Encounter, Procedure, MedicationAdministration>, (CqlTupleMetadata, Encounter QualifyingEncounter, Procedure AnesthesiaProcedure, MedicationAdministration FactorXaMedication)?>(s_, t_, u_);
        Encounter w_((CqlTupleMetadata, Encounter QualifyingEncounter, Procedure AnesthesiaProcedure, MedicationAdministration FactorXaMedication)? tuple_dejnabiogwrwyxienqokgepgj) => tuple_dejnabiogwrwyxienqokgepgj?.QualifyingEncounter;
        IEnumerable<Encounter> x_ = context.Operators.SelectDistinct<(CqlTupleMetadata, Encounter QualifyingEncounter, Procedure AnesthesiaProcedure, MedicationAdministration FactorXaMedication)?, Encounter>(v_, w_);
        IEnumerable<Encounter> y_ = context.Operators.Union<Encounter>(m_, x_);
        return y_;
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
                Period ad_ = QualifyingEncounter?.Period;
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

        bool? d_(Encounter QualifyingEncounter) {
            CqlValueSet aj_ = this.Atrial_Fibrillation_or_Flutter(context);
            bool? ak_ = VTE_8_18_000.Instance.hasEncDiagnosisOf(context, QualifyingEncounter, aj_);
            return ak_;
        }

        IEnumerable<Encounter> e_ = context.Operators.Where<Encounter>(a_, d_);
        IEnumerable<Encounter> f_ = context.Operators.Union<Encounter>(c_, e_);

        bool? g_(Encounter QualifyingEncounter) {
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
                Period bw_ = QualifyingEncounter?.Period;
                CqlInterval<CqlDateTime> bx_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, bw_);
                CqlDateTime by_ = context.Operators.Start(bx_);
                if (by_ is null)
                {
                    bs_ = default;
                }
                else
                {
                    CqlInterval<CqlDateTime> bz_ = context.Operators.Interval(by_, by_, true, true);
                    bs_ = bz_;
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
                Period r_ = QualifyingEncounter?.Period;
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

    private const long _cacheIndex_Low_Risk_Indicator_For_VTE = 7432212982012444353L;

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
            bool? bj_ = context.Operators.Greater(bh_ as CqlQuantity, bi_);
            Code<ObservationStatus> bk_ = INRLabTest?.StatusElement;
            ObservationStatus? bl_ = bk_?.Value;
            string bm_ = context.Operators.Convert<string>(bl_);
            string[] bn_ = [
                "final",
                "amended",
                "corrected",
            ];
            bool? bo_ = context.Operators.In<string>(bm_, (IEnumerable<string>)bn_);
            bool? bp_ = context.Operators.And(bj_, bo_);
            return bp_;
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
                Id bz_ = M?.IdElement;
                string ca_ = bz_?.Value;
                FhirString cb_;
                DataType cl_ = MR?.Medication;
                bool cm_ = cl_ is ResourceReference;
                if (cm_)
                {
                    FhirString cn_ = (cl_ as ResourceReference)?.ReferenceElement;
                    cb_ = cn_;
                }
                else
                {
                    cb_ = default;
                }
                string cc_ = cb_?.Value;
                IEnumerable<string> cd_ = context.Operators.Split(cc_, "/");
                string ce_ = context.Operators.Last<string>(cd_);
                bool? cf_ = context.Operators.Equal(ca_, ce_);
                CodeableConcept cg_ = M?.Code;
                CqlConcept ch_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, cg_);
                CqlValueSet ci_ = this.Unfractionated_Heparin(context);
                bool? cj_ = context.Operators.ConceptInValueSet(ch_, ci_);
                bool? ck_ = context.Operators.And(cf_, cj_);
                return ck_;
            }

            bool? by_ = context.Operators.WhereAny<Medication>(bw_, bx_);
            return by_;
        }

        IEnumerable<MedicationAdministration> q_ = context.Operators.Where<MedicationAdministration>(o_, p_);
        CqlValueSet r_ = this.Unfractionated_Heparin(context);
        IEnumerable<MedicationAdministration> s_ = context.Operators.Retrieve<MedicationAdministration>(new RetrieveParameters(default, r_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationadministration"));
        IEnumerable<MedicationAdministration> t_ = context.Operators.Union<MedicationAdministration>(q_, s_);

        bool? u_(MedicationAdministration UnfractionatedHeparin) {
            MedicationAdministration.DosageComponent co_ = UnfractionatedHeparin?.Dosage;
            CodeableConcept cp_ = co_?.Route;
            CqlConcept cq_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, cp_);
            CqlValueSet cr_ = this.Intravenous_route(context);
            bool? cs_ = context.Operators.ConceptInValueSet(cq_, cr_);
            return cs_;
        }

        IEnumerable<MedicationAdministration> v_ = context.Operators.Where<MedicationAdministration>(t_, u_);

        bool? w_(MedicationAdministration MR) {
            IEnumerable<Medication> ct_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));

            bool? cu_(Medication M) {
                Id cw_ = M?.IdElement;
                string cx_ = cw_?.Value;
                FhirString cy_;
                DataType di_ = MR?.Medication;
                bool dj_ = di_ is ResourceReference;
                if (dj_)
                {
                    FhirString dk_ = (di_ as ResourceReference)?.ReferenceElement;
                    cy_ = dk_;
                }
                else
                {
                    cy_ = default;
                }
                string cz_ = cy_?.Value;
                IEnumerable<string> da_ = context.Operators.Split(cz_, "/");
                string db_ = context.Operators.Last<string>(da_);
                bool? dc_ = context.Operators.Equal(cx_, db_);
                CodeableConcept dd_ = M?.Code;
                CqlConcept de_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, dd_);
                CqlValueSet df_ = this.Direct_Thrombin_Inhibitor(context);
                bool? dg_ = context.Operators.ConceptInValueSet(de_, df_);
                bool? dh_ = context.Operators.And(dc_, dg_);
                return dh_;
            }

            bool? cv_ = context.Operators.WhereAny<Medication>(ct_, cu_);
            return cv_;
        }

        IEnumerable<MedicationAdministration> x_ = context.Operators.Where<MedicationAdministration>(o_, w_);
        CqlValueSet y_ = this.Direct_Thrombin_Inhibitor(context);
        IEnumerable<MedicationAdministration> z_ = context.Operators.Retrieve<MedicationAdministration>(new RetrieveParameters(default, y_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationadministration"));
        IEnumerable<MedicationAdministration> aa_ = context.Operators.Union<MedicationAdministration>(x_, z_);
        IEnumerable<MedicationAdministration> ab_ = context.Operators.Union<MedicationAdministration>(v_, aa_);

        bool? ac_(MedicationAdministration MR) {
            IEnumerable<Medication> dl_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));

            bool? dm_(Medication M) {
                Id do_ = M?.IdElement;
                string dp_ = do_?.Value;
                FhirString dq_;
                DataType ea_ = MR?.Medication;
                bool eb_ = ea_ is ResourceReference;
                if (eb_)
                {
                    FhirString ec_ = (ea_ as ResourceReference)?.ReferenceElement;
                    dq_ = ec_;
                }
                else
                {
                    dq_ = default;
                }
                string dr_ = dq_?.Value;
                IEnumerable<string> ds_ = context.Operators.Split(dr_, "/");
                string dt_ = context.Operators.Last<string>(ds_);
                bool? du_ = context.Operators.Equal(dp_, dt_);
                CodeableConcept dv_ = M?.Code;
                CqlConcept dw_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, dv_);
                CqlValueSet dx_ = this.Glycoprotein_IIb_IIIa_Inhibitors(context);
                bool? dy_ = context.Operators.ConceptInValueSet(dw_, dx_);
                bool? dz_ = context.Operators.And(du_, dy_);
                return dz_;
            }

            bool? dn_ = context.Operators.WhereAny<Medication>(dl_, dm_);
            return dn_;
        }

        IEnumerable<MedicationAdministration> ad_ = context.Operators.Where<MedicationAdministration>(o_, ac_);
        CqlValueSet ae_ = this.Glycoprotein_IIb_IIIa_Inhibitors(context);
        IEnumerable<MedicationAdministration> af_ = context.Operators.Retrieve<MedicationAdministration>(new RetrieveParameters(default, ae_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationadministration"));
        IEnumerable<MedicationAdministration> ag_ = context.Operators.Union<MedicationAdministration>(ad_, af_);
        IEnumerable<MedicationAdministration> ah_ = context.Operators.Union<MedicationAdministration>(ab_, ag_);

        bool? ai_(MedicationAdministration AnticoagulantMedication) {
            Code<MedicationAdministration.MedicationAdministrationStatusCodes> ed_ = AnticoagulantMedication?.StatusElement;
            MedicationAdministration.MedicationAdministrationStatusCodes? ee_ = ed_?.Value;
            string ef_ = context.Operators.Convert<string>(ee_);
            bool? eg_ = context.Operators.Equal(ef_, "completed");
            return eg_;
        }


        (CqlTupleMetadata, string id, CqlDateTime LowRiskDatetime)? aj_(MedicationAdministration AnticoagulantMedication) {
            Id eh_ = AnticoagulantMedication?.IdElement;
            string ei_ = eh_?.Value;
            DataType ej_ = AnticoagulantMedication?.Effective;
            object ek_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ej_);
            CqlInterval<CqlDateTime> el_ = QICoreCommon_4_0_000.Instance.toInterval(context, ek_);
            CqlDateTime em_ = context.Operators.Start(el_);
            (CqlTupleMetadata, string id, CqlDateTime LowRiskDatetime)? en_ = (CqlTupleMetadata_DMAfXNhTfZDWOGdfEceXbfaSJ, ei_, em_);
            return en_;
        }

        IEnumerable<(CqlTupleMetadata, string id, CqlDateTime LowRiskDatetime)?> ak_ = context.Operators.WhereSelect<MedicationAdministration, (CqlTupleMetadata, string id, CqlDateTime LowRiskDatetime)?>(ah_, ai_, aj_);
        IEnumerable<(CqlTupleMetadata, string id, CqlDateTime LowRiskDatetime)?> al_ = context.Operators.Distinct<(CqlTupleMetadata, string id, CqlDateTime LowRiskDatetime)?>(ak_);
        IEnumerable<(CqlTupleMetadata, string id, CqlDateTime LowRiskDatetime)?> am_ = context.Operators.Union<(CqlTupleMetadata, string id, CqlDateTime LowRiskDatetime)?>(n_, al_);
        return am_;
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
                CqlDateTime g_ = LowRiskForVTE?.LowRiskDatetime;
                CqlInterval<CqlDate> h_ = this.fromDayOfStartOfHospitalizationToDayAfterAdmission(context, QualifyingEncounter);
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

    private const long _cacheIndex_Low_Risk_For_VTE_Or_Anticoagulant_Administered_On_Day_Of_Or_Day_After_Procedure = -7257647458643896672L;

    private IEnumerable<Encounter> Low_Risk_For_VTE_Or_Anticoagulant_Administered_On_Day_Of_Or_Day_After_Procedure_Compute(CqlContext context)
    {
        IEnumerable<Encounter> a_ = VTE_8_18_000.Instance.Encounter_With_Age_Range_And_Without_VTE_Diagnosis_Or_Obstetrical_Conditions(context);
        CqlValueSet b_ = this.General_or_Neuraxial_Anesthesia(context);
        IEnumerable<Procedure> c_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, b_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
        IEnumerable<(CqlTupleMetadata, string id, CqlDateTime LowRiskDatetime)?> d_ = this.Low_Risk_Indicator_For_VTE(context);
        IEnumerable<ValueTuple<Encounter, Procedure, (CqlTupleMetadata, string id, CqlDateTime LowRiskDatetime)?>> e_ = context.Operators.CrossJoin<Encounter, Procedure, (CqlTupleMetadata, string id, CqlDateTime LowRiskDatetime)?>(a_, c_, d_);

        (CqlTupleMetadata, Encounter QualifyingEncounter, Procedure AnesthesiaProcedure, (CqlTupleMetadata, string id, CqlDateTime LowRiskDatetime)? LowRiskForVTE)? f_(ValueTuple<Encounter, Procedure, (CqlTupleMetadata, string id, CqlDateTime LowRiskDatetime)?> _valueTuple) {
            (CqlTupleMetadata, Encounter QualifyingEncounter, Procedure AnesthesiaProcedure, (CqlTupleMetadata, string id, CqlDateTime LowRiskDatetime)? LowRiskForVTE)? k_ = (CqlTupleMetadata_EXZJZNMEfWVgYEZWEbGcSARAD, _valueTuple.Item1, _valueTuple.Item2, _valueTuple.Item3);
            return k_;
        }


        bool? g_((CqlTupleMetadata, Encounter QualifyingEncounter, Procedure AnesthesiaProcedure, (CqlTupleMetadata, string id, CqlDateTime LowRiskDatetime)? LowRiskForVTE)? tuple_gwhjghwetinfdseedvamgjivv) {
            Code<EventStatus> l_ = tuple_gwhjghwetinfdseedvamgjivv?.AnesthesiaProcedure?.StatusElement;
            EventStatus? m_ = l_?.Value;
            string n_ = context.Operators.Convert<string>(m_);
            bool? o_ = context.Operators.Equal(n_, "completed");
            object p_;
            DataType az_ = tuple_gwhjghwetinfdseedvamgjivv?.AnesthesiaProcedure?.Performed;
            object ba_ = FHIRHelpers_4_4_000.Instance.ToValue(context, az_);
            bool bb_ = ba_ is CqlDateTime;
            if (bb_)
            {
                p_ = ba_ as CqlDateTime;
            }
            else
            {
                bool bc_ = ba_ is CqlQuantity;
                if (bc_)
                {
                    p_ = ba_ as CqlQuantity;
                }
                else
                {
                    bool bd_ = ba_ is CqlInterval<CqlDateTime>;
                    if (bd_)
                    {
                        p_ = ba_ as CqlInterval<CqlDateTime>;
                    }
                    else
                    {
                        bool be_ = ba_ is CqlInterval<CqlQuantity>;
                        if (be_)
                        {
                            p_ = ba_ as CqlInterval<CqlQuantity>;
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
            Period s_ = tuple_gwhjghwetinfdseedvamgjivv?.QualifyingEncounter?.Period;
            CqlInterval<CqlDateTime> t_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, s_);
            CqlDateTime u_ = context.Operators.Start(t_);
            CqlQuantity v_ = context.Operators.Quantity(1m, "day");
            CqlDateTime w_ = context.Operators.Add(u_, v_);
            bool? x_ = context.Operators.SameAs(r_, w_, "day");
            bool? y_ = context.Operators.And(o_, x_);
            CqlDateTime z_ = tuple_gwhjghwetinfdseedvamgjivv?.LowRiskForVTE?.LowRiskDatetime;
            object aa_;
            DataType bf_ = tuple_gwhjghwetinfdseedvamgjivv?.AnesthesiaProcedure?.Performed;
            object bg_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bf_);
            bool bh_ = bg_ is CqlDateTime;
            if (bh_)
            {
                aa_ = bg_ as CqlDateTime;
            }
            else
            {
                bool bi_ = bg_ is CqlQuantity;
                if (bi_)
                {
                    aa_ = bg_ as CqlQuantity;
                }
                else
                {
                    bool bj_ = bg_ is CqlInterval<CqlDateTime>;
                    if (bj_)
                    {
                        aa_ = bg_ as CqlInterval<CqlDateTime>;
                    }
                    else
                    {
                        bool bk_ = bg_ is CqlInterval<CqlQuantity>;
                        if (bk_)
                        {
                            aa_ = bg_ as CqlInterval<CqlQuantity>;
                        }
                        else
                        {
                            aa_ = null;
                        }
                    }
                }
            }
            CqlInterval<CqlDateTime> ab_ = QICoreCommon_4_0_000.Instance.toInterval(context, aa_);
            CqlDateTime ac_ = context.Operators.End(ab_);
            CqlInterval<CqlDate> ad_ = TJCOverall_8_25_000.Instance.calendarDayOfOrDayAfter(context, ac_);
            CqlDate ae_ = ad_?.low;
            CqlDateTime af_ = context.Operators.ConvertDateToDateTime(ae_);
            object ag_;
            DataType bl_ = tuple_gwhjghwetinfdseedvamgjivv?.AnesthesiaProcedure?.Performed;
            object bm_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bl_);
            bool bn_ = bm_ is CqlDateTime;
            if (bn_)
            {
                ag_ = bm_ as CqlDateTime;
            }
            else
            {
                bool bo_ = bm_ is CqlQuantity;
                if (bo_)
                {
                    ag_ = bm_ as CqlQuantity;
                }
                else
                {
                    bool bp_ = bm_ is CqlInterval<CqlDateTime>;
                    if (bp_)
                    {
                        ag_ = bm_ as CqlInterval<CqlDateTime>;
                    }
                    else
                    {
                        bool bq_ = bm_ is CqlInterval<CqlQuantity>;
                        if (bq_)
                        {
                            ag_ = bm_ as CqlInterval<CqlQuantity>;
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
            CqlDate ak_ = aj_?.high;
            CqlDateTime al_ = context.Operators.ConvertDateToDateTime(ak_);
            object am_;
            DataType br_ = tuple_gwhjghwetinfdseedvamgjivv?.AnesthesiaProcedure?.Performed;
            object bs_ = FHIRHelpers_4_4_000.Instance.ToValue(context, br_);
            bool bt_ = bs_ is CqlDateTime;
            if (bt_)
            {
                am_ = bs_ as CqlDateTime;
            }
            else
            {
                bool bu_ = bs_ is CqlQuantity;
                if (bu_)
                {
                    am_ = bs_ as CqlQuantity;
                }
                else
                {
                    bool bv_ = bs_ is CqlInterval<CqlDateTime>;
                    if (bv_)
                    {
                        am_ = bs_ as CqlInterval<CqlDateTime>;
                    }
                    else
                    {
                        bool bw_ = bs_ is CqlInterval<CqlQuantity>;
                        if (bw_)
                        {
                            am_ = bs_ as CqlInterval<CqlQuantity>;
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
            bool? aq_ = ap_?.lowClosed;
            object ar_;
            DataType bx_ = tuple_gwhjghwetinfdseedvamgjivv?.AnesthesiaProcedure?.Performed;
            object by_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bx_);
            bool bz_ = by_ is CqlDateTime;
            if (bz_)
            {
                ar_ = by_ as CqlDateTime;
            }
            else
            {
                bool ca_ = by_ is CqlQuantity;
                if (ca_)
                {
                    ar_ = by_ as CqlQuantity;
                }
                else
                {
                    bool cb_ = by_ is CqlInterval<CqlDateTime>;
                    if (cb_)
                    {
                        ar_ = by_ as CqlInterval<CqlDateTime>;
                    }
                    else
                    {
                        bool cc_ = by_ is CqlInterval<CqlQuantity>;
                        if (cc_)
                        {
                            ar_ = by_ as CqlInterval<CqlQuantity>;
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
            CqlInterval<CqlDate> au_ = TJCOverall_8_25_000.Instance.calendarDayOfOrDayAfter(context, at_);
            bool? av_ = au_?.highClosed;
            CqlInterval<CqlDateTime> aw_ = context.Operators.Interval(af_, al_, aq_, av_);
            bool? ax_ = context.Operators.In<CqlDateTime>(z_, aw_, "day");
            bool? ay_ = context.Operators.And(y_, ax_);
            return ay_;
        }

        IEnumerable<(CqlTupleMetadata, Encounter QualifyingEncounter, Procedure AnesthesiaProcedure, (CqlTupleMetadata, string id, CqlDateTime LowRiskDatetime)? LowRiskForVTE)?> h_ = context.Operators.SelectWhere<ValueTuple<Encounter, Procedure, (CqlTupleMetadata, string id, CqlDateTime LowRiskDatetime)?>, (CqlTupleMetadata, Encounter QualifyingEncounter, Procedure AnesthesiaProcedure, (CqlTupleMetadata, string id, CqlDateTime LowRiskDatetime)? LowRiskForVTE)?>(e_, f_, g_);
        Encounter i_((CqlTupleMetadata, Encounter QualifyingEncounter, Procedure AnesthesiaProcedure, (CqlTupleMetadata, string id, CqlDateTime LowRiskDatetime)? LowRiskForVTE)? tuple_gwhjghwetinfdseedvamgjivv) => tuple_gwhjghwetinfdseedvamgjivv?.QualifyingEncounter;
        IEnumerable<Encounter> j_ = context.Operators.SelectDistinct<(CqlTupleMetadata, Encounter QualifyingEncounter, Procedure AnesthesiaProcedure, (CqlTupleMetadata, string id, CqlDateTime LowRiskDatetime)? LowRiskForVTE)?, Encounter>(h_, i_);
        return j_;
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
            Id bx_ = NoMedicationAdm?.IdElement;
            string by_ = bx_?.Value;
            List<CodeableConcept> bz_ = NoMedicationAdm?.StatusReason;

            CqlConcept ca_(CodeableConcept @this) {
                CqlConcept ci_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);
                return ci_;
            }

            IEnumerable<CqlConcept> cb_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)bz_, ca_);
            List<Extension> cc_ = NoMedicationAdm?.Extension;

            bool? cd_(Extension @this) {
                FhirUri cj_ = @this?.UrlElement;
                string ck_ = FHIRHelpers_4_4_000.Instance.ToString(context, cj_);
                bool? cl_ = context.Operators.Equal(ck_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-recorded");
                return cl_;
            }


            object ce_(Extension @this) {
                DataType cm_ = @this?.Value;
                bool cn_ = cm_ is Uuid;
                if (cn_)
                {
                    string co_ = (cm_ as Uuid)?.Value;
                    return co_;
                }
                else
                {
                    bool cp_ = cm_ is Oid;
                    if (cp_)
                    {
                        string cq_ = (cm_ as Oid)?.Value;
                        return cq_;
                    }
                    else
                    {
                        bool cr_ = cm_ is Markdown;
                        if (cr_)
                        {
                            string cs_ = (cm_ as Markdown)?.Value;
                            return cs_;
                        }
                        else
                        {
                            bool ct_ = cm_ is Integer;
                            if (ct_)
                            {
                                int? cu_ = (cm_ as Integer)?.Value;
                                return cu_;
                            }
                            else
                            {
                                bool cv_ = cm_ is Instant;
                                if (cv_)
                                {
                                    DateTimeOffset? cw_ = (cm_ as Instant)?.Value;
                                    return cw_;
                                }
                                else
                                {
                                    bool cx_ = cm_ is Id;
                                    if (cx_)
                                    {
                                        string cy_ = (cm_ as Id)?.Value;
                                        return cy_;
                                    }
                                    else
                                    {
                                        bool cz_ = cm_ is Duration;
                                        if (cz_)
                                        {
                                            FhirDecimal da_ = (cm_ as Duration)?.ValueElement;
                                            return da_;
                                        }
                                        else
                                        {
                                            bool db_ = cm_ is Distance;
                                            if (db_)
                                            {
                                                FhirDecimal dc_ = (cm_ as Distance)?.ValueElement;
                                                return dc_;
                                            }
                                            else
                                            {
                                                bool dd_ = cm_ is FhirDecimal;
                                                if (dd_)
                                                {
                                                    decimal? de_ = (cm_ as FhirDecimal)?.Value;
                                                    return de_;
                                                }
                                                else
                                                {
                                                    bool df_ = cm_ is Date;
                                                    if (df_)
                                                    {
                                                        string dg_ = (cm_ as Date)?.Value;
                                                        return dg_;
                                                    }
                                                    else
                                                    {
                                                        bool dh_ = cm_ is Count;
                                                        if (dh_)
                                                        {
                                                            FhirDecimal di_ = (cm_ as Count)?.ValueElement;
                                                            return di_;
                                                        }
                                                        else
                                                        {
                                                            bool dj_ = cm_ is FhirDateTime;
                                                            if (dj_)
                                                            {
                                                                string dk_ = context.Operators.Convert<string>(cm_ as FhirDateTime);
                                                                return dk_;
                                                            }
                                                            else
                                                            {
                                                                bool dl_ = cm_ is Time;
                                                                if (dl_)
                                                                {
                                                                    string dm_ = (cm_ as Time)?.Value;
                                                                    return dm_;
                                                                }
                                                                else
                                                                {
                                                                    bool dn_ = cm_ is Age;
                                                                    if (dn_)
                                                                    {
                                                                        FhirDecimal do_ = (cm_ as Age)?.ValueElement;
                                                                        return do_;
                                                                    }
                                                                    else
                                                                    {
                                                                        bool dp_ = cm_ is FhirUrl;
                                                                        if (dp_)
                                                                        {
                                                                            string dq_ = (cm_ as FhirUrl)?.Value;
                                                                            return dq_;
                                                                        }
                                                                        else
                                                                        {
                                                                            bool dr_ = cm_ is FhirUri;
                                                                            if (dr_)
                                                                            {
                                                                                string ds_ = (cm_ as FhirUri)?.Value;
                                                                                return ds_;
                                                                            }
                                                                            else
                                                                            {
                                                                                bool dt_ = cm_ is Base64Binary;
                                                                                if (dt_)
                                                                                {
                                                                                    byte[] du_ = (cm_ as Base64Binary)?.Value;
                                                                                    return du_;
                                                                                }
                                                                                else
                                                                                {
                                                                                    bool dv_ = cm_ is FhirBoolean;
                                                                                    if (dv_)
                                                                                    {
                                                                                        bool? dw_ = (cm_ as FhirBoolean)?.Value;
                                                                                        return dw_;
                                                                                    }
                                                                                    else
                                                                                    {
                                                                                        bool dx_ = cm_ is FhirString;
                                                                                        if (dx_)
                                                                                        {
                                                                                            string dy_ = (cm_ as FhirString)?.Value;
                                                                                            return dy_;
                                                                                        }
                                                                                        else
                                                                                        {
                                                                                            bool dz_ = cm_ is PositiveInt;
                                                                                            if (dz_)
                                                                                            {
                                                                                                int? ea_ = (cm_ as PositiveInt)?.Value;
                                                                                                return ea_;
                                                                                            }
                                                                                            else
                                                                                            {
                                                                                                bool eb_ = cm_ is Code;
                                                                                                if (eb_)
                                                                                                {
                                                                                                    string ec_ = (cm_ as Code)?.Value;
                                                                                                    return ec_;
                                                                                                }
                                                                                                else
                                                                                                {
                                                                                                    bool ed_ = cm_ is UnsignedInt;
                                                                                                    if (ed_)
                                                                                                    {
                                                                                                        int? ee_ = (cm_ as UnsignedInt)?.Value;
                                                                                                        return ee_;
                                                                                                    }
                                                                                                    else
                                                                                                    {
                                                                                                        bool ef_ = cm_ is Canonical;
                                                                                                        if (ef_)
                                                                                                        {
                                                                                                            string eg_ = (cm_ as Canonical)?.Value;
                                                                                                            return eg_;
                                                                                                        }
                                                                                                        else
                                                                                                        {
                                                                                                            bool eh_ = cm_ is Quantity;
                                                                                                            if (eh_)
                                                                                                            {
                                                                                                                FhirDecimal ei_ = (cm_ as Quantity)?.ValueElement;
                                                                                                                return ei_;
                                                                                                            }
                                                                                                            else
                                                                                                            {
                                                                                                                bool ej_ = cm_ is Identifier;
                                                                                                                if (ej_)
                                                                                                                {
                                                                                                                    FhirString ek_ = (cm_ as Identifier)?.ValueElement;
                                                                                                                    return ek_;
                                                                                                                }
                                                                                                                else
                                                                                                                {
                                                                                                                    bool el_ = cm_ is Money;
                                                                                                                    if (el_)
                                                                                                                    {
                                                                                                                        FhirDecimal em_ = (cm_ as Money)?.ValueElement;
                                                                                                                        return em_;
                                                                                                                    }
                                                                                                                    else
                                                                                                                    {
                                                                                                                        bool en_ = cm_ is UsageContext;
                                                                                                                        if (en_)
                                                                                                                        {
                                                                                                                            DataType eo_ = (cm_ as UsageContext)?.Value;
                                                                                                                            return eo_;
                                                                                                                        }
                                                                                                                        else
                                                                                                                        {
                                                                                                                            bool ep_ = cm_ is ContactPoint;
                                                                                                                            if (ep_)
                                                                                                                            {
                                                                                                                                FhirString eq_ = (cm_ as ContactPoint)?.ValueElement;
                                                                                                                                return eq_;
                                                                                                                            }
                                                                                                                            else
                                                                                                                            {
                                                                                                                                return null;
                                                                                                                            }
                                                                                                                        }
                                                                                                                    }
                                                                                                                }
                                                                                                            }
                                                                                                        }
                                                                                                    }
                                                                                                }
                                                                                            }
                                                                                        }
                                                                                    }
                                                                                }
                                                                            }
                                                                        }
                                                                    }
                                                                }
                                                            }
                                                        }
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }

            IEnumerable<object> cf_ = context.Operators.WhereSelect<Extension, object>((IEnumerable<Extension>)cc_, cd_, ce_);
            object cg_ = context.Operators.SingletonFrom<object>(cf_);
            (CqlTupleMetadata, string id, IEnumerable<CqlConcept> medicationStatusReason, FhirDateTime authoredOn)? ch_ = (CqlTupleMetadata_EBcSahXYZdeFjUUbgULReCZAe, by_, cb_, (FhirDateTime)cg_);
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
                CqlDateTime er_ = context.Operators.Convert<CqlDateTime>(tuple_cumbjbeguchwelldvxijceahs?.authoredOn);
                (CqlTupleMetadata, string id, IEnumerable<CqlConcept> medicationStatusReason, CqlDateTime authoredOn)? es_ = (CqlTupleMetadata_CNeQfiIHcQEUBjZNVZiOLfdeP, tuple_cumbjbeguchwelldvxijceahs?.id, tuple_cumbjbeguchwelldvxijceahs?.medicationStatusReason, er_);
                return es_;
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
            Code<MedicationRequest.MedicationRequestIntent> et_ = NoMedicationOrder?.IntentElement;
            MedicationRequest.MedicationRequestIntent? eu_ = et_?.Value;
            string ev_ = context.Operators.Convert<string>(eu_);
            string[] ew_ = [
                "order",
                "original-order",
                "reflex-order",
                "filler-order",
                "instance-order",
            ];
            bool? ex_ = context.Operators.In<string>(ev_, (IEnumerable<string>)ew_);
            Code<MedicationRequest.MedicationrequestStatus> ey_ = NoMedicationOrder?.StatusElement;
            MedicationRequest.MedicationrequestStatus? ez_ = ey_?.Value;
            string fa_ = context.Operators.Convert<string>(ez_);
            string[] fb_ = [
                "active",
                "completed",
            ];
            bool? fc_ = context.Operators.In<string>(fa_, (IEnumerable<string>)fb_);
            bool? fd_ = context.Operators.And(ex_, fc_);
            return fd_;
        }


        (CqlTupleMetadata, string id, IEnumerable<CqlConcept> medicationStatusReason, CqlDateTime authoredOn)? am_(MedicationRequest NoMedicationOrder) {
            Id fe_ = NoMedicationOrder?.IdElement;
            string ff_ = fe_?.Value;
            List<CodeableConcept> fg_ = NoMedicationOrder?.ReasonCode;

            CqlConcept fh_(CodeableConcept @this) {
                CqlConcept fm_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);
                return fm_;
            }

            IEnumerable<CqlConcept> fi_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)fg_, fh_);
            FhirDateTime fj_ = NoMedicationOrder?.AuthoredOnElement;
            CqlDateTime fk_ = context.Operators.Convert<CqlDateTime>(fj_);
            (CqlTupleMetadata, string id, IEnumerable<CqlConcept> medicationStatusReason, CqlDateTime authoredOn)? fl_ = (CqlTupleMetadata_CNeQfiIHcQEUBjZNVZiOLfdeP, ff_, fi_, fk_);
            return fl_;
        }

        IEnumerable<(CqlTupleMetadata, string id, IEnumerable<CqlConcept> medicationStatusReason, CqlDateTime authoredOn)?> an_ = context.Operators.WhereSelect<MedicationRequest, (CqlTupleMetadata, string id, IEnumerable<CqlConcept> medicationStatusReason, CqlDateTime authoredOn)?>(ak_, al_, am_);
        IEnumerable<(CqlTupleMetadata, string id, IEnumerable<CqlConcept> medicationStatusReason, CqlDateTime authoredOn)?> ao_ = context.Operators.Distinct<(CqlTupleMetadata, string id, IEnumerable<CqlConcept> medicationStatusReason, CqlDateTime authoredOn)?>(an_);
        IEnumerable<(CqlTupleMetadata, string id, IEnumerable<CqlConcept> medicationStatusReason, CqlDateTime authoredOn)?> ap_ = context.Operators.Union<(CqlTupleMetadata, string id, IEnumerable<CqlConcept> medicationStatusReason, CqlDateTime authoredOn)?>(w_, ao_);
        IEnumerable<MedicationRequest> aq_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));

        bool? ar_(MedicationRequest MR) {
            IEnumerable<Medication> fn_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));

            bool? fo_(Medication M) {
                Id fq_ = M?.IdElement;
                string fr_ = fq_?.Value;
                FhirString fs_;
                DataType gc_ = MR?.Medication;
                bool gd_ = gc_ is ResourceReference;
                if (gd_)
                {
                    FhirString ge_ = (gc_ as ResourceReference)?.ReferenceElement;
                    fs_ = ge_;
                }
                else
                {
                    fs_ = default;
                }
                string ft_ = fs_?.Value;
                IEnumerable<string> fu_ = context.Operators.Split(ft_, "/");
                string fv_ = context.Operators.Last<string>(fu_);
                bool? fw_ = context.Operators.Equal(fr_, fv_);
                CodeableConcept fx_ = M?.Code;
                CqlConcept fy_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, fx_);
                CqlValueSet fz_ = this.Low_Dose_Unfractionated_Heparin_for_VTE_Prophylaxis(context);
                bool? ga_ = context.Operators.ConceptInValueSet(fy_, fz_);
                bool? gb_ = context.Operators.And(fw_, ga_);
                return gb_;
            }

            bool? fp_ = context.Operators.WhereAny<Medication>(fn_, fo_);
            return fp_;
        }

        IEnumerable<MedicationRequest> as_ = context.Operators.Where<MedicationRequest>(aq_, ar_);
        IEnumerable<MedicationRequest> at_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> au_ = context.Operators.Union<MedicationRequest>(as_, at_);

        bool? av_(MedicationRequest MR) {
            IEnumerable<Medication> gf_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));

            bool? gg_(Medication M) {
                Id gi_ = M?.IdElement;
                string gj_ = gi_?.Value;
                FhirString gk_;
                DataType gu_ = MR?.Medication;
                bool gv_ = gu_ is ResourceReference;
                if (gv_)
                {
                    FhirString gw_ = (gu_ as ResourceReference)?.ReferenceElement;
                    gk_ = gw_;
                }
                else
                {
                    gk_ = default;
                }
                string gl_ = gk_?.Value;
                IEnumerable<string> gm_ = context.Operators.Split(gl_, "/");
                string gn_ = context.Operators.Last<string>(gm_);
                bool? go_ = context.Operators.Equal(gj_, gn_);
                CodeableConcept gp_ = M?.Code;
                CqlConcept gq_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, gp_);
                CqlValueSet gr_ = this.Low_Molecular_Weight_Heparin_for_VTE_Prophylaxis(context);
                bool? gs_ = context.Operators.ConceptInValueSet(gq_, gr_);
                bool? gt_ = context.Operators.And(go_, gs_);
                return gt_;
            }

            bool? gh_ = context.Operators.WhereAny<Medication>(gf_, gg_);
            return gh_;
        }

        IEnumerable<MedicationRequest> aw_ = context.Operators.Where<MedicationRequest>(aq_, av_);
        IEnumerable<MedicationRequest> ax_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, d_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> ay_ = context.Operators.Union<MedicationRequest>(aw_, ax_);
        IEnumerable<MedicationRequest> az_ = context.Operators.Union<MedicationRequest>(au_, ay_);

        bool? ba_(MedicationRequest MR) {
            IEnumerable<Medication> gx_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));

            bool? gy_(Medication M) {
                Id ha_ = M?.IdElement;
                string hb_ = ha_?.Value;
                FhirString hc_;
                DataType hm_ = MR?.Medication;
                bool hn_ = hm_ is ResourceReference;
                if (hn_)
                {
                    FhirString ho_ = (hm_ as ResourceReference)?.ReferenceElement;
                    hc_ = ho_;
                }
                else
                {
                    hc_ = default;
                }
                string hd_ = hc_?.Value;
                IEnumerable<string> he_ = context.Operators.Split(hd_, "/");
                string hf_ = context.Operators.Last<string>(he_);
                bool? hg_ = context.Operators.Equal(hb_, hf_);
                CodeableConcept hh_ = M?.Code;
                CqlConcept hi_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, hh_);
                CqlValueSet hj_ = this.Injectable_Factor_Xa_Inhibitor_for_VTE_Prophylaxis(context);
                bool? hk_ = context.Operators.ConceptInValueSet(hi_, hj_);
                bool? hl_ = context.Operators.And(hg_, hk_);
                return hl_;
            }

            bool? gz_ = context.Operators.WhereAny<Medication>(gx_, gy_);
            return gz_;
        }

        IEnumerable<MedicationRequest> bb_ = context.Operators.Where<MedicationRequest>(aq_, ba_);
        IEnumerable<MedicationRequest> bc_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, h_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> bd_ = context.Operators.Union<MedicationRequest>(bb_, bc_);
        IEnumerable<MedicationRequest> be_ = context.Operators.Union<MedicationRequest>(az_, bd_);

        bool? bf_(MedicationRequest MR) {
            IEnumerable<Medication> hp_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));

            bool? hq_(Medication M) {
                Id hs_ = M?.IdElement;
                string ht_ = hs_?.Value;
                FhirString hu_;
                DataType ie_ = MR?.Medication;
                bool if_ = ie_ is ResourceReference;
                if (if_)
                {
                    FhirString ig_ = (ie_ as ResourceReference)?.ReferenceElement;
                    hu_ = ig_;
                }
                else
                {
                    hu_ = default;
                }
                string hv_ = hu_?.Value;
                IEnumerable<string> hw_ = context.Operators.Split(hv_, "/");
                string hx_ = context.Operators.Last<string>(hw_);
                bool? hy_ = context.Operators.Equal(ht_, hx_);
                CodeableConcept hz_ = M?.Code;
                CqlConcept ia_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, hz_);
                CqlValueSet ib_ = this.Warfarin(context);
                bool? ic_ = context.Operators.ConceptInValueSet(ia_, ib_);
                bool? id_ = context.Operators.And(hy_, ic_);
                return id_;
            }

            bool? hr_ = context.Operators.WhereAny<Medication>(hp_, hq_);
            return hr_;
        }

        IEnumerable<MedicationRequest> bg_ = context.Operators.Where<MedicationRequest>(aq_, bf_);
        IEnumerable<MedicationRequest> bh_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, l_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> bi_ = context.Operators.Union<MedicationRequest>(bg_, bh_);
        IEnumerable<MedicationRequest> bj_ = context.Operators.Union<MedicationRequest>(be_, bi_);

        bool? bk_(MedicationRequest MR) {
            IEnumerable<Medication> ih_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));

            bool? ii_(Medication M) {
                Id ik_ = M?.IdElement;
                string il_ = ik_?.Value;
                FhirString im_;
                DataType iw_ = MR?.Medication;
                bool ix_ = iw_ is ResourceReference;
                if (ix_)
                {
                    FhirString iy_ = (iw_ as ResourceReference)?.ReferenceElement;
                    im_ = iy_;
                }
                else
                {
                    im_ = default;
                }
                string in_ = im_?.Value;
                IEnumerable<string> io_ = context.Operators.Split(in_, "/");
                string ip_ = context.Operators.Last<string>(io_);
                bool? iq_ = context.Operators.Equal(il_, ip_);
                CodeableConcept ir_ = M?.Code;
                CqlConcept is_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, ir_);
                CqlValueSet it_ = this.Rivaroxaban_for_VTE_Prophylaxis(context);
                bool? iu_ = context.Operators.ConceptInValueSet(is_, it_);
                bool? iv_ = context.Operators.And(iq_, iu_);
                return iv_;
            }

            bool? ij_ = context.Operators.WhereAny<Medication>(ih_, ii_);
            return ij_;
        }

        IEnumerable<MedicationRequest> bl_ = context.Operators.Where<MedicationRequest>(aq_, bk_);
        IEnumerable<MedicationRequest> bm_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, p_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> bn_ = context.Operators.Union<MedicationRequest>(bl_, bm_);
        IEnumerable<MedicationRequest> bo_ = context.Operators.Union<MedicationRequest>(bj_, bn_);
        IEnumerable<Task> bp_ = context.Operators.Retrieve<Task>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-taskrejected"));
        IEnumerable<ValueTuple<MedicationRequest, Task>> bq_ = context.Operators.CrossJoin<MedicationRequest, Task>(bo_, bp_);

        (CqlTupleMetadata, MedicationRequest MedicationOrderReject, Task T)? br_(ValueTuple<MedicationRequest, Task> _valueTuple) {
            (CqlTupleMetadata, MedicationRequest MedicationOrderReject, Task T)? iz_ = (CqlTupleMetadata_IIUQMBcJhJBPgdDOLHaTTRUE, _valueTuple.Item1, _valueTuple.Item2);
            return iz_;
        }


        bool? bs_((CqlTupleMetadata, MedicationRequest MedicationOrderReject, Task T)? tuple_iiuqmbcjhjbpgddolhattrue) {
            ResourceReference ja_ = tuple_iiuqmbcjhjbpgddolhattrue?.T?.Focus;
            bool? jb_ = QICoreCommon_4_0_000.Instance.references(context, ja_, tuple_iiuqmbcjhjbpgddolhattrue?.MedicationOrderReject);
            CodeableConcept jc_ = tuple_iiuqmbcjhjbpgddolhattrue?.T?.Code;
            CqlConcept jd_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, jc_);
            CqlCode je_ = QICoreCommon_4_0_000.Instance.Fulfill(context);
            CqlConcept jf_ = context.Operators.ConvertCodeToConcept(je_);
            bool? jg_ = context.Operators.Equivalent(jd_, jf_);
            bool? jh_ = context.Operators.And(jb_, jg_);
            Code<MedicationRequest.MedicationrequestStatus> ji_ = tuple_iiuqmbcjhjbpgddolhattrue?.MedicationOrderReject?.StatusElement;
            MedicationRequest.MedicationrequestStatus? jj_ = ji_?.Value;
            string jk_ = context.Operators.Convert<string>(jj_);
            bool? jl_ = context.Operators.Equal(jk_, "active");
            bool? jm_ = context.Operators.And(jh_, jl_);
            return jm_;
        }

        IEnumerable<(CqlTupleMetadata, MedicationRequest MedicationOrderReject, Task T)?> bt_ = context.Operators.SelectWhere<ValueTuple<MedicationRequest, Task>, (CqlTupleMetadata, MedicationRequest MedicationOrderReject, Task T)?>(bq_, br_, bs_);

        (CqlTupleMetadata, string id, IEnumerable<CqlConcept> medicationStatusReason, CqlDateTime authoredOn)? bu_((CqlTupleMetadata, MedicationRequest MedicationOrderReject, Task T)? tuple_iiuqmbcjhjbpgddolhattrue) {
            Id jn_ = tuple_iiuqmbcjhjbpgddolhattrue?.MedicationOrderReject?.IdElement;
            string jo_ = jn_?.Value;
            CodeableConcept jp_ = tuple_iiuqmbcjhjbpgddolhattrue?.T?.StatusReason;
            CqlConcept jq_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, jp_);
            CqlConcept[] jr_ = [
                jq_,
            ];
            FhirDateTime js_ = tuple_iiuqmbcjhjbpgddolhattrue?.MedicationOrderReject?.AuthoredOnElement;
            CqlDateTime jt_ = context.Operators.Convert<CqlDateTime>(js_);
            (CqlTupleMetadata, string id, IEnumerable<CqlConcept> medicationStatusReason, CqlDateTime authoredOn)? ju_ = (CqlTupleMetadata_CNeQfiIHcQEUBjZNVZiOLfdeP, jo_, (IEnumerable<CqlConcept>)jr_, jt_);
            return ju_;
        }

        IEnumerable<(CqlTupleMetadata, string id, IEnumerable<CqlConcept> medicationStatusReason, CqlDateTime authoredOn)?> bv_ = context.Operators.SelectDistinct<(CqlTupleMetadata, MedicationRequest MedicationOrderReject, Task T)?, (CqlTupleMetadata, string id, IEnumerable<CqlConcept> medicationStatusReason, CqlDateTime authoredOn)?>(bt_, bu_);
        IEnumerable<(CqlTupleMetadata, string id, IEnumerable<CqlConcept> medicationStatusReason, CqlDateTime authoredOn)?> bw_ = context.Operators.Union<(CqlTupleMetadata, string id, IEnumerable<CqlConcept> medicationStatusReason, CqlDateTime authoredOn)?>(ap_, bv_);
        return bw_;
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
                IEnumerable<CqlConcept> g_ = NoVTEMedication?.medicationStatusReason;
                CqlValueSet h_ = this.Medical_Reason_For_Not_Providing_Treatment(context);
                bool? i_ = context.Operators.ConceptsInValueSet(g_, h_);
                CqlDateTime j_ = NoVTEMedication?.authoredOn;
                CqlInterval<CqlDate> k_ = this.fromDayOfStartOfHospitalizationToDayAfterAdmission(context, QualifyingEncounter);
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
            List<Extension> bc_ = DeviceNotOrder?.Extension;

            bool? bd_(Extension @this) {
                FhirUri bm_ = @this?.UrlElement;
                string bn_ = FHIRHelpers_4_4_000.Instance.ToString(context, bm_);
                bool? bo_ = context.Operators.Equal(bn_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-doNotPerformReason");
                return bo_;
            }


            object be_(Extension @this) {
                DataType bp_ = @this?.Value;
                return bp_;
            }

            IEnumerable<object> bf_ = context.Operators.WhereSelect<Extension, object>((IEnumerable<Extension>)bc_, bd_, be_);
            object bg_ = context.Operators.SingletonFrom<object>(bf_);
            CqlConcept bh_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, bg_ as CodeableConcept);
            CodeableConcept bi_ = context.Operators.Convert<CodeableConcept>(bh_);
            FhirDateTime bj_ = DeviceNotOrder?.AuthoredOnElement;
            CqlDateTime bk_ = context.Operators.Convert<CqlDateTime>(bj_);
            (CqlTupleMetadata, string id, CodeableConcept requestStatusReason, CqlDateTime authoredOn)? bl_ = (CqlTupleMetadata_FVDRPQjOQgYIDhWKHCNhOHceF, bb_, bi_, bk_);
            return bl_;
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
                CqlConcept bq_ = context.Operators.Convert<CqlConcept>(tuple_gnbatbigxtpdibanunzcndfbr?.requestStatusReason);
                (CqlTupleMetadata, string id, CqlConcept requestStatusReason, CqlDateTime authoredOn)? br_ = (CqlTupleMetadata_DheTAGNHbFgKVJGaRbPLJVjKH, tuple_gnbatbigxtpdibanunzcndfbr?.id, bq_, tuple_gnbatbigxtpdibanunzcndfbr?.authoredOn);
                return br_;
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
            (CqlTupleMetadata, ServiceRequest DeviceOrderReject, Task T)? bs_ = (CqlTupleMetadata_YYIDPXBNjhOGFRJKYRBMGChb, _valueTuple.Item1, _valueTuple.Item2);
            return bs_;
        }


        bool? z_((CqlTupleMetadata, ServiceRequest DeviceOrderReject, Task T)? tuple_yyidpxbnjhogfrjkyrbmgchb) {
            Code<RequestIntent> bt_ = tuple_yyidpxbnjhogfrjkyrbmgchb?.DeviceOrderReject?.IntentElement;
            RequestIntent? bu_ = bt_?.Value;
            Code<RequestIntent> bv_ = context.Operators.Convert<Code<RequestIntent>>(bu_);
            string bw_ = context.Operators.Convert<string>(bv_);
            string[] bx_ = [
                "order",
                "original-order",
                "reflex-order",
                "filler-order",
                "instance-order",
            ];
            bool? by_ = context.Operators.In<string>(bw_, (IEnumerable<string>)bx_);
            Code<RequestStatus> bz_ = tuple_yyidpxbnjhogfrjkyrbmgchb?.DeviceOrderReject?.StatusElement;
            RequestStatus? ca_ = bz_?.Value;
            Code<RequestStatus> cb_ = context.Operators.Convert<Code<RequestStatus>>(ca_);
            bool? cc_ = context.Operators.Equal(cb_, "active");
            bool? cd_ = context.Operators.And(by_, cc_);
            ResourceReference ce_ = tuple_yyidpxbnjhogfrjkyrbmgchb?.T?.Focus;
            bool? cf_ = QICoreCommon_4_0_000.Instance.references(context, ce_, tuple_yyidpxbnjhogfrjkyrbmgchb?.DeviceOrderReject);
            bool? cg_ = context.Operators.And(cd_, cf_);
            CodeableConcept ch_ = tuple_yyidpxbnjhogfrjkyrbmgchb?.T?.Code;
            CqlConcept ci_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, ch_);
            CqlCode cj_ = QICoreCommon_4_0_000.Instance.Fulfill(context);
            CqlConcept ck_ = context.Operators.ConvertCodeToConcept(cj_);
            bool? cl_ = context.Operators.Equivalent(ci_, ck_);
            bool? cm_ = context.Operators.And(cg_, cl_);
            return cm_;
        }

        IEnumerable<(CqlTupleMetadata, ServiceRequest DeviceOrderReject, Task T)?> aa_ = context.Operators.SelectWhere<ValueTuple<ServiceRequest, Task>, (CqlTupleMetadata, ServiceRequest DeviceOrderReject, Task T)?>(x_, y_, z_);

        (CqlTupleMetadata, string id, CqlConcept requestStatusReason, CqlDateTime authoredOn)? ab_((CqlTupleMetadata, ServiceRequest DeviceOrderReject, Task T)? tuple_yyidpxbnjhogfrjkyrbmgchb) {
            Id cn_ = tuple_yyidpxbnjhogfrjkyrbmgchb?.DeviceOrderReject?.IdElement;
            string co_ = cn_?.Value;
            CodeableConcept cp_ = tuple_yyidpxbnjhogfrjkyrbmgchb?.T?.StatusReason;
            CqlConcept cq_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, cp_);
            FhirDateTime cr_ = tuple_yyidpxbnjhogfrjkyrbmgchb?.DeviceOrderReject?.AuthoredOnElement;
            CqlDateTime cs_ = context.Operators.Convert<CqlDateTime>(cr_);
            (CqlTupleMetadata, string id, CqlConcept requestStatusReason, CqlDateTime authoredOn)? ct_ = (CqlTupleMetadata_DheTAGNHbFgKVJGaRbPLJVjKH, co_, cq_, cs_);
            return ct_;
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
            Id cu_ = DeviceNotApplied?.IdElement;
            string cv_ = cu_?.Value;
            CodeableConcept cw_ = DeviceNotApplied?.StatusReason;
            CqlConcept cx_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, cw_);
            List<Extension> cy_ = DeviceNotApplied?.Extension;

            bool? cz_(Extension @this) {
                FhirUri de_ = @this?.UrlElement;
                string df_ = FHIRHelpers_4_4_000.Instance.ToString(context, de_);
                bool? dg_ = context.Operators.Equal(df_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-recorded");
                return dg_;
            }


            object da_(Extension @this) {
                DataType dh_ = @this?.Value;
                bool di_ = dh_ is Uuid;
                if (di_)
                {
                    string dj_ = (dh_ as Uuid)?.Value;
                    return dj_;
                }
                else
                {
                    bool dk_ = dh_ is Oid;
                    if (dk_)
                    {
                        string dl_ = (dh_ as Oid)?.Value;
                        return dl_;
                    }
                    else
                    {
                        bool dm_ = dh_ is Markdown;
                        if (dm_)
                        {
                            string dn_ = (dh_ as Markdown)?.Value;
                            return dn_;
                        }
                        else
                        {
                            bool do_ = dh_ is Integer;
                            if (do_)
                            {
                                int? dp_ = (dh_ as Integer)?.Value;
                                return dp_;
                            }
                            else
                            {
                                bool dq_ = dh_ is Instant;
                                if (dq_)
                                {
                                    DateTimeOffset? dr_ = (dh_ as Instant)?.Value;
                                    return dr_;
                                }
                                else
                                {
                                    bool ds_ = dh_ is Id;
                                    if (ds_)
                                    {
                                        string dt_ = (dh_ as Id)?.Value;
                                        return dt_;
                                    }
                                    else
                                    {
                                        bool du_ = dh_ is Duration;
                                        if (du_)
                                        {
                                            FhirDecimal dv_ = (dh_ as Duration)?.ValueElement;
                                            return dv_;
                                        }
                                        else
                                        {
                                            bool dw_ = dh_ is Distance;
                                            if (dw_)
                                            {
                                                FhirDecimal dx_ = (dh_ as Distance)?.ValueElement;
                                                return dx_;
                                            }
                                            else
                                            {
                                                bool dy_ = dh_ is FhirDecimal;
                                                if (dy_)
                                                {
                                                    decimal? dz_ = (dh_ as FhirDecimal)?.Value;
                                                    return dz_;
                                                }
                                                else
                                                {
                                                    bool ea_ = dh_ is Date;
                                                    if (ea_)
                                                    {
                                                        string eb_ = (dh_ as Date)?.Value;
                                                        return eb_;
                                                    }
                                                    else
                                                    {
                                                        bool ec_ = dh_ is Count;
                                                        if (ec_)
                                                        {
                                                            FhirDecimal ed_ = (dh_ as Count)?.ValueElement;
                                                            return ed_;
                                                        }
                                                        else
                                                        {
                                                            bool ee_ = dh_ is FhirDateTime;
                                                            if (ee_)
                                                            {
                                                                string ef_ = context.Operators.Convert<string>(dh_ as FhirDateTime);
                                                                return ef_;
                                                            }
                                                            else
                                                            {
                                                                bool eg_ = dh_ is Time;
                                                                if (eg_)
                                                                {
                                                                    string eh_ = (dh_ as Time)?.Value;
                                                                    return eh_;
                                                                }
                                                                else
                                                                {
                                                                    bool ei_ = dh_ is Age;
                                                                    if (ei_)
                                                                    {
                                                                        FhirDecimal ej_ = (dh_ as Age)?.ValueElement;
                                                                        return ej_;
                                                                    }
                                                                    else
                                                                    {
                                                                        bool ek_ = dh_ is FhirUrl;
                                                                        if (ek_)
                                                                        {
                                                                            string el_ = (dh_ as FhirUrl)?.Value;
                                                                            return el_;
                                                                        }
                                                                        else
                                                                        {
                                                                            bool em_ = dh_ is FhirUri;
                                                                            if (em_)
                                                                            {
                                                                                string en_ = (dh_ as FhirUri)?.Value;
                                                                                return en_;
                                                                            }
                                                                            else
                                                                            {
                                                                                bool eo_ = dh_ is Base64Binary;
                                                                                if (eo_)
                                                                                {
                                                                                    byte[] ep_ = (dh_ as Base64Binary)?.Value;
                                                                                    return ep_;
                                                                                }
                                                                                else
                                                                                {
                                                                                    bool eq_ = dh_ is FhirBoolean;
                                                                                    if (eq_)
                                                                                    {
                                                                                        bool? er_ = (dh_ as FhirBoolean)?.Value;
                                                                                        return er_;
                                                                                    }
                                                                                    else
                                                                                    {
                                                                                        bool es_ = dh_ is FhirString;
                                                                                        if (es_)
                                                                                        {
                                                                                            string et_ = (dh_ as FhirString)?.Value;
                                                                                            return et_;
                                                                                        }
                                                                                        else
                                                                                        {
                                                                                            bool eu_ = dh_ is PositiveInt;
                                                                                            if (eu_)
                                                                                            {
                                                                                                int? ev_ = (dh_ as PositiveInt)?.Value;
                                                                                                return ev_;
                                                                                            }
                                                                                            else
                                                                                            {
                                                                                                bool ew_ = dh_ is Code;
                                                                                                if (ew_)
                                                                                                {
                                                                                                    string ex_ = (dh_ as Code)?.Value;
                                                                                                    return ex_;
                                                                                                }
                                                                                                else
                                                                                                {
                                                                                                    bool ey_ = dh_ is UnsignedInt;
                                                                                                    if (ey_)
                                                                                                    {
                                                                                                        int? ez_ = (dh_ as UnsignedInt)?.Value;
                                                                                                        return ez_;
                                                                                                    }
                                                                                                    else
                                                                                                    {
                                                                                                        bool fa_ = dh_ is Canonical;
                                                                                                        if (fa_)
                                                                                                        {
                                                                                                            string fb_ = (dh_ as Canonical)?.Value;
                                                                                                            return fb_;
                                                                                                        }
                                                                                                        else
                                                                                                        {
                                                                                                            bool fc_ = dh_ is Quantity;
                                                                                                            if (fc_)
                                                                                                            {
                                                                                                                FhirDecimal fd_ = (dh_ as Quantity)?.ValueElement;
                                                                                                                return fd_;
                                                                                                            }
                                                                                                            else
                                                                                                            {
                                                                                                                bool fe_ = dh_ is Identifier;
                                                                                                                if (fe_)
                                                                                                                {
                                                                                                                    FhirString ff_ = (dh_ as Identifier)?.ValueElement;
                                                                                                                    return ff_;
                                                                                                                }
                                                                                                                else
                                                                                                                {
                                                                                                                    bool fg_ = dh_ is Money;
                                                                                                                    if (fg_)
                                                                                                                    {
                                                                                                                        FhirDecimal fh_ = (dh_ as Money)?.ValueElement;
                                                                                                                        return fh_;
                                                                                                                    }
                                                                                                                    else
                                                                                                                    {
                                                                                                                        bool fi_ = dh_ is UsageContext;
                                                                                                                        if (fi_)
                                                                                                                        {
                                                                                                                            DataType fj_ = (dh_ as UsageContext)?.Value;
                                                                                                                            return fj_;
                                                                                                                        }
                                                                                                                        else
                                                                                                                        {
                                                                                                                            bool fk_ = dh_ is ContactPoint;
                                                                                                                            if (fk_)
                                                                                                                            {
                                                                                                                                FhirString fl_ = (dh_ as ContactPoint)?.ValueElement;
                                                                                                                                return fl_;
                                                                                                                            }
                                                                                                                            else
                                                                                                                            {
                                                                                                                                return null;
                                                                                                                            }
                                                                                                                        }
                                                                                                                    }
                                                                                                                }
                                                                                                            }
                                                                                                        }
                                                                                                    }
                                                                                                }
                                                                                            }
                                                                                        }
                                                                                    }
                                                                                }
                                                                            }
                                                                        }
                                                                    }
                                                                }
                                                            }
                                                        }
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }

            IEnumerable<object> db_ = context.Operators.WhereSelect<Extension, object>((IEnumerable<Extension>)cy_, cz_, da_);
            object dc_ = context.Operators.SingletonFrom<object>(db_);
            (CqlTupleMetadata, string id, CqlConcept requestStatusReason, FhirDateTime authoredOn)? dd_ = (CqlTupleMetadata_DPXDaXjPQUNAIiZCCbGhNdDMi, cv_, cx_, (FhirDateTime)dc_);
            return dd_;
        }

        IEnumerable<(CqlTupleMetadata, string id, CqlConcept requestStatusReason, FhirDateTime authoredOn)?> aq_ = context.Operators.SelectDistinct<Procedure, (CqlTupleMetadata, string id, CqlConcept requestStatusReason, FhirDateTime authoredOn)?>(ao_, ap_);

        (CqlTupleMetadata, string id, CqlConcept requestStatusReason, CqlDateTime authoredOn)? ar_((CqlTupleMetadata, string id, CqlConcept requestStatusReason, FhirDateTime authoredOn)? tuple_fcgxmnobtfvlcbqjjfugxtftk) {
            if (tuple_fcgxmnobtfvlcbqjjfugxtftk is null)
            {
                return default;
            }
            else
            {
                CqlDateTime fm_ = context.Operators.Convert<CqlDateTime>(tuple_fcgxmnobtfvlcbqjjfugxtftk?.authoredOn);
                (CqlTupleMetadata, string id, CqlConcept requestStatusReason, CqlDateTime authoredOn)? fn_ = (CqlTupleMetadata_DheTAGNHbFgKVJGaRbPLJVjKH, tuple_fcgxmnobtfvlcbqjjfugxtftk?.id, tuple_fcgxmnobtfvlcbqjjfugxtftk?.requestStatusReason, fm_);
                return fn_;
            }
        }

        IEnumerable<(CqlTupleMetadata, string id, CqlConcept requestStatusReason, CqlDateTime authoredOn)?> as_ = context.Operators.Select<(CqlTupleMetadata, string id, CqlConcept requestStatusReason, FhirDateTime authoredOn)?, (CqlTupleMetadata, string id, CqlConcept requestStatusReason, CqlDateTime authoredOn)?>(aq_, ar_);
        IEnumerable<(CqlTupleMetadata, string id, CqlConcept requestStatusReason, CqlDateTime authoredOn)?> at_ = context.Operators.Union<(CqlTupleMetadata, string id, CqlConcept requestStatusReason, CqlDateTime authoredOn)?>(ad_, as_);
        return at_;
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
                CqlConcept g_ = NoVTEDevice?.requestStatusReason;
                CqlValueSet h_ = this.Medical_Reason_For_Not_Providing_Treatment(context);
                bool? i_ = context.Operators.ConceptInValueSet(g_, h_);
                CqlDateTime j_ = NoVTEDevice?.authoredOn;
                CqlInterval<CqlDate> k_ = this.fromDayOfStartOfHospitalizationToDayAfterAdmission(context, QualifyingEncounter);
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

    private const long _cacheIndex_No_VTE_Prophylaxis_Medication_Due_To_Medical_Reason_On_Day_Of_Or_Day_After_Procedure = 4328598489171831529L;

    private IEnumerable<Encounter> No_VTE_Prophylaxis_Medication_Due_To_Medical_Reason_On_Day_Of_Or_Day_After_Procedure_Compute(CqlContext context)
    {
        IEnumerable<Encounter> a_ = VTE_8_18_000.Instance.Encounter_With_Age_Range_And_Without_VTE_Diagnosis_Or_Obstetrical_Conditions(context);
        CqlValueSet b_ = this.General_or_Neuraxial_Anesthesia(context);
        IEnumerable<Procedure> c_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, b_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
        IEnumerable<(CqlTupleMetadata, string id, IEnumerable<CqlConcept> medicationStatusReason, CqlDateTime authoredOn)?> d_ = this.No_VTE_Prophylaxis_Medication_Administered_Or_Ordered(context);
        IEnumerable<ValueTuple<Encounter, Procedure, (CqlTupleMetadata, string id, IEnumerable<CqlConcept> medicationStatusReason, CqlDateTime authoredOn)?>> e_ = context.Operators.CrossJoin<Encounter, Procedure, (CqlTupleMetadata, string id, IEnumerable<CqlConcept> medicationStatusReason, CqlDateTime authoredOn)?>(a_, c_, d_);

        (CqlTupleMetadata, Encounter QualifyingEncounter, Procedure AnesthesiaProcedure, (CqlTupleMetadata, string id, IEnumerable<CqlConcept> medicationStatusReason, CqlDateTime authoredOn)? NoVTEMedication)? f_(ValueTuple<Encounter, Procedure, (CqlTupleMetadata, string id, IEnumerable<CqlConcept> medicationStatusReason, CqlDateTime authoredOn)?> _valueTuple) {
            (CqlTupleMetadata, Encounter QualifyingEncounter, Procedure AnesthesiaProcedure, (CqlTupleMetadata, string id, IEnumerable<CqlConcept> medicationStatusReason, CqlDateTime authoredOn)? NoVTEMedication)? k_ = (CqlTupleMetadata_CUUMXUZWiBObPgSAjXGJDhdYW, _valueTuple.Item1, _valueTuple.Item2, _valueTuple.Item3);
            return k_;
        }


        bool? g_((CqlTupleMetadata, Encounter QualifyingEncounter, Procedure AnesthesiaProcedure, (CqlTupleMetadata, string id, IEnumerable<CqlConcept> medicationStatusReason, CqlDateTime authoredOn)? NoVTEMedication)? tuple_chjebychscdthhbpzggacmwxe) {
            IEnumerable<CqlConcept> l_ = tuple_chjebychscdthhbpzggacmwxe?.NoVTEMedication?.medicationStatusReason;
            CqlValueSet m_ = this.Medical_Reason_For_Not_Providing_Treatment(context);
            bool? n_ = context.Operators.ConceptsInValueSet(l_, m_);
            Code<EventStatus> o_ = tuple_chjebychscdthhbpzggacmwxe?.AnesthesiaProcedure?.StatusElement;
            EventStatus? p_ = o_?.Value;
            string q_ = context.Operators.Convert<string>(p_);
            bool? r_ = context.Operators.Equal(q_, "completed");
            bool? s_ = context.Operators.And(n_, r_);
            object t_;
            DataType bd_ = tuple_chjebychscdthhbpzggacmwxe?.AnesthesiaProcedure?.Performed;
            object be_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bd_);
            bool bf_ = be_ is CqlDateTime;
            if (bf_)
            {
                t_ = be_ as CqlDateTime;
            }
            else
            {
                bool bg_ = be_ is CqlQuantity;
                if (bg_)
                {
                    t_ = be_ as CqlQuantity;
                }
                else
                {
                    bool bh_ = be_ is CqlInterval<CqlDateTime>;
                    if (bh_)
                    {
                        t_ = be_ as CqlInterval<CqlDateTime>;
                    }
                    else
                    {
                        bool bi_ = be_ is CqlInterval<CqlQuantity>;
                        if (bi_)
                        {
                            t_ = be_ as CqlInterval<CqlQuantity>;
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
            Period w_ = tuple_chjebychscdthhbpzggacmwxe?.QualifyingEncounter?.Period;
            CqlInterval<CqlDateTime> x_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, w_);
            CqlDateTime y_ = context.Operators.Start(x_);
            CqlQuantity z_ = context.Operators.Quantity(1m, "day");
            CqlDateTime aa_ = context.Operators.Add(y_, z_);
            bool? ab_ = context.Operators.SameAs(v_, aa_, "day");
            bool? ac_ = context.Operators.And(s_, ab_);
            CqlDateTime ad_ = tuple_chjebychscdthhbpzggacmwxe?.NoVTEMedication?.authoredOn;
            object ae_;
            DataType bj_ = tuple_chjebychscdthhbpzggacmwxe?.AnesthesiaProcedure?.Performed;
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
            CqlDate ai_ = ah_?.low;
            CqlDateTime aj_ = context.Operators.ConvertDateToDateTime(ai_);
            object ak_;
            DataType bp_ = tuple_chjebychscdthhbpzggacmwxe?.AnesthesiaProcedure?.Performed;
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
            CqlDate ao_ = an_?.high;
            CqlDateTime ap_ = context.Operators.ConvertDateToDateTime(ao_);
            object aq_;
            DataType bv_ = tuple_chjebychscdthhbpzggacmwxe?.AnesthesiaProcedure?.Performed;
            object bw_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bv_);
            bool bx_ = bw_ is CqlDateTime;
            if (bx_)
            {
                aq_ = bw_ as CqlDateTime;
            }
            else
            {
                bool by_ = bw_ is CqlQuantity;
                if (by_)
                {
                    aq_ = bw_ as CqlQuantity;
                }
                else
                {
                    bool bz_ = bw_ is CqlInterval<CqlDateTime>;
                    if (bz_)
                    {
                        aq_ = bw_ as CqlInterval<CqlDateTime>;
                    }
                    else
                    {
                        bool ca_ = bw_ is CqlInterval<CqlQuantity>;
                        if (ca_)
                        {
                            aq_ = bw_ as CqlInterval<CqlQuantity>;
                        }
                        else
                        {
                            aq_ = null;
                        }
                    }
                }
            }
            CqlInterval<CqlDateTime> ar_ = QICoreCommon_4_0_000.Instance.toInterval(context, aq_);
            CqlDateTime as_ = context.Operators.End(ar_);
            CqlInterval<CqlDate> at_ = TJCOverall_8_25_000.Instance.calendarDayOfOrDayAfter(context, as_);
            bool? au_ = at_?.lowClosed;
            object av_;
            DataType cb_ = tuple_chjebychscdthhbpzggacmwxe?.AnesthesiaProcedure?.Performed;
            object cc_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cb_);
            bool cd_ = cc_ is CqlDateTime;
            if (cd_)
            {
                av_ = cc_ as CqlDateTime;
            }
            else
            {
                bool ce_ = cc_ is CqlQuantity;
                if (ce_)
                {
                    av_ = cc_ as CqlQuantity;
                }
                else
                {
                    bool cf_ = cc_ is CqlInterval<CqlDateTime>;
                    if (cf_)
                    {
                        av_ = cc_ as CqlInterval<CqlDateTime>;
                    }
                    else
                    {
                        bool cg_ = cc_ is CqlInterval<CqlQuantity>;
                        if (cg_)
                        {
                            av_ = cc_ as CqlInterval<CqlQuantity>;
                        }
                        else
                        {
                            av_ = null;
                        }
                    }
                }
            }
            CqlInterval<CqlDateTime> aw_ = QICoreCommon_4_0_000.Instance.toInterval(context, av_);
            CqlDateTime ax_ = context.Operators.End(aw_);
            CqlInterval<CqlDate> ay_ = TJCOverall_8_25_000.Instance.calendarDayOfOrDayAfter(context, ax_);
            bool? az_ = ay_?.highClosed;
            CqlInterval<CqlDateTime> ba_ = context.Operators.Interval(aj_, ap_, au_, az_);
            bool? bb_ = context.Operators.In<CqlDateTime>(ad_, ba_, "day");
            bool? bc_ = context.Operators.And(ac_, bb_);
            return bc_;
        }

        IEnumerable<(CqlTupleMetadata, Encounter QualifyingEncounter, Procedure AnesthesiaProcedure, (CqlTupleMetadata, string id, IEnumerable<CqlConcept> medicationStatusReason, CqlDateTime authoredOn)? NoVTEMedication)?> h_ = context.Operators.SelectWhere<ValueTuple<Encounter, Procedure, (CqlTupleMetadata, string id, IEnumerable<CqlConcept> medicationStatusReason, CqlDateTime authoredOn)?>, (CqlTupleMetadata, Encounter QualifyingEncounter, Procedure AnesthesiaProcedure, (CqlTupleMetadata, string id, IEnumerable<CqlConcept> medicationStatusReason, CqlDateTime authoredOn)? NoVTEMedication)?>(e_, f_, g_);
        Encounter i_((CqlTupleMetadata, Encounter QualifyingEncounter, Procedure AnesthesiaProcedure, (CqlTupleMetadata, string id, IEnumerable<CqlConcept> medicationStatusReason, CqlDateTime authoredOn)? NoVTEMedication)? tuple_chjebychscdthhbpzggacmwxe) => tuple_chjebychscdthhbpzggacmwxe?.QualifyingEncounter;
        IEnumerable<Encounter> j_ = context.Operators.SelectDistinct<(CqlTupleMetadata, Encounter QualifyingEncounter, Procedure AnesthesiaProcedure, (CqlTupleMetadata, string id, IEnumerable<CqlConcept> medicationStatusReason, CqlDateTime authoredOn)? NoVTEMedication)?, Encounter>(h_, i_);
        return j_;
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
            (CqlTupleMetadata, Encounter QualifyingEncounter, Procedure AnesthesiaProcedure, (CqlTupleMetadata, string id, CqlConcept requestStatusReason, CqlDateTime authoredOn)? NoVTEDevice)? k_ = (CqlTupleMetadata_FNWjhIAKXiLTDJAYchhKVfDAc, _valueTuple.Item1, _valueTuple.Item2, _valueTuple.Item3);
            return k_;
        }


        bool? g_((CqlTupleMetadata, Encounter QualifyingEncounter, Procedure AnesthesiaProcedure, (CqlTupleMetadata, string id, CqlConcept requestStatusReason, CqlDateTime authoredOn)? NoVTEDevice)? tuple_cadhcldckpqwmtcazwxfnkhgc) {
            CqlConcept l_ = tuple_cadhcldckpqwmtcazwxfnkhgc?.NoVTEDevice?.requestStatusReason;
            CqlValueSet m_ = this.Medical_Reason_For_Not_Providing_Treatment(context);
            bool? n_ = context.Operators.ConceptInValueSet(l_, m_);
            Code<EventStatus> o_ = tuple_cadhcldckpqwmtcazwxfnkhgc?.AnesthesiaProcedure?.StatusElement;
            EventStatus? p_ = o_?.Value;
            string q_ = context.Operators.Convert<string>(p_);
            bool? r_ = context.Operators.Equal(q_, "completed");
            bool? s_ = context.Operators.And(n_, r_);
            object t_;
            DataType bd_ = tuple_cadhcldckpqwmtcazwxfnkhgc?.AnesthesiaProcedure?.Performed;
            object be_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bd_);
            bool bf_ = be_ is CqlDateTime;
            if (bf_)
            {
                t_ = be_ as CqlDateTime;
            }
            else
            {
                bool bg_ = be_ is CqlQuantity;
                if (bg_)
                {
                    t_ = be_ as CqlQuantity;
                }
                else
                {
                    bool bh_ = be_ is CqlInterval<CqlDateTime>;
                    if (bh_)
                    {
                        t_ = be_ as CqlInterval<CqlDateTime>;
                    }
                    else
                    {
                        bool bi_ = be_ is CqlInterval<CqlQuantity>;
                        if (bi_)
                        {
                            t_ = be_ as CqlInterval<CqlQuantity>;
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
            Period w_ = tuple_cadhcldckpqwmtcazwxfnkhgc?.QualifyingEncounter?.Period;
            CqlInterval<CqlDateTime> x_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, w_);
            CqlDateTime y_ = context.Operators.Start(x_);
            CqlQuantity z_ = context.Operators.Quantity(1m, "day");
            CqlDateTime aa_ = context.Operators.Add(y_, z_);
            bool? ab_ = context.Operators.SameAs(v_, aa_, "day");
            bool? ac_ = context.Operators.And(s_, ab_);
            CqlDateTime ad_ = tuple_cadhcldckpqwmtcazwxfnkhgc?.NoVTEDevice?.authoredOn;
            object ae_;
            DataType bj_ = tuple_cadhcldckpqwmtcazwxfnkhgc?.AnesthesiaProcedure?.Performed;
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
            CqlDate ai_ = ah_?.low;
            CqlDateTime aj_ = context.Operators.ConvertDateToDateTime(ai_);
            object ak_;
            DataType bp_ = tuple_cadhcldckpqwmtcazwxfnkhgc?.AnesthesiaProcedure?.Performed;
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
            CqlDate ao_ = an_?.high;
            CqlDateTime ap_ = context.Operators.ConvertDateToDateTime(ao_);
            object aq_;
            DataType bv_ = tuple_cadhcldckpqwmtcazwxfnkhgc?.AnesthesiaProcedure?.Performed;
            object bw_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bv_);
            bool bx_ = bw_ is CqlDateTime;
            if (bx_)
            {
                aq_ = bw_ as CqlDateTime;
            }
            else
            {
                bool by_ = bw_ is CqlQuantity;
                if (by_)
                {
                    aq_ = bw_ as CqlQuantity;
                }
                else
                {
                    bool bz_ = bw_ is CqlInterval<CqlDateTime>;
                    if (bz_)
                    {
                        aq_ = bw_ as CqlInterval<CqlDateTime>;
                    }
                    else
                    {
                        bool ca_ = bw_ is CqlInterval<CqlQuantity>;
                        if (ca_)
                        {
                            aq_ = bw_ as CqlInterval<CqlQuantity>;
                        }
                        else
                        {
                            aq_ = null;
                        }
                    }
                }
            }
            CqlInterval<CqlDateTime> ar_ = QICoreCommon_4_0_000.Instance.toInterval(context, aq_);
            CqlDateTime as_ = context.Operators.End(ar_);
            CqlInterval<CqlDate> at_ = TJCOverall_8_25_000.Instance.calendarDayOfOrDayAfter(context, as_);
            bool? au_ = at_?.lowClosed;
            object av_;
            DataType cb_ = tuple_cadhcldckpqwmtcazwxfnkhgc?.AnesthesiaProcedure?.Performed;
            object cc_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cb_);
            bool cd_ = cc_ is CqlDateTime;
            if (cd_)
            {
                av_ = cc_ as CqlDateTime;
            }
            else
            {
                bool ce_ = cc_ is CqlQuantity;
                if (ce_)
                {
                    av_ = cc_ as CqlQuantity;
                }
                else
                {
                    bool cf_ = cc_ is CqlInterval<CqlDateTime>;
                    if (cf_)
                    {
                        av_ = cc_ as CqlInterval<CqlDateTime>;
                    }
                    else
                    {
                        bool cg_ = cc_ is CqlInterval<CqlQuantity>;
                        if (cg_)
                        {
                            av_ = cc_ as CqlInterval<CqlQuantity>;
                        }
                        else
                        {
                            av_ = null;
                        }
                    }
                }
            }
            CqlInterval<CqlDateTime> aw_ = QICoreCommon_4_0_000.Instance.toInterval(context, av_);
            CqlDateTime ax_ = context.Operators.End(aw_);
            CqlInterval<CqlDate> ay_ = TJCOverall_8_25_000.Instance.calendarDayOfOrDayAfter(context, ax_);
            bool? az_ = ay_?.highClosed;
            CqlInterval<CqlDateTime> ba_ = context.Operators.Interval(aj_, ap_, au_, az_);
            bool? bb_ = context.Operators.In<CqlDateTime>(ad_, ba_, "day");
            bool? bc_ = context.Operators.And(ac_, bb_);
            return bc_;
        }

        IEnumerable<(CqlTupleMetadata, Encounter QualifyingEncounter, Procedure AnesthesiaProcedure, (CqlTupleMetadata, string id, CqlConcept requestStatusReason, CqlDateTime authoredOn)? NoVTEDevice)?> h_ = context.Operators.SelectWhere<ValueTuple<Encounter, Procedure, (CqlTupleMetadata, string id, CqlConcept requestStatusReason, CqlDateTime authoredOn)?>, (CqlTupleMetadata, Encounter QualifyingEncounter, Procedure AnesthesiaProcedure, (CqlTupleMetadata, string id, CqlConcept requestStatusReason, CqlDateTime authoredOn)? NoVTEDevice)?>(e_, f_, g_);
        Encounter i_((CqlTupleMetadata, Encounter QualifyingEncounter, Procedure AnesthesiaProcedure, (CqlTupleMetadata, string id, CqlConcept requestStatusReason, CqlDateTime authoredOn)? NoVTEDevice)? tuple_cadhcldckpqwmtcazwxfnkhgc) => tuple_cadhcldckpqwmtcazwxfnkhgc?.QualifyingEncounter;
        IEnumerable<Encounter> j_ = context.Operators.SelectDistinct<(CqlTupleMetadata, Encounter QualifyingEncounter, Procedure AnesthesiaProcedure, (CqlTupleMetadata, string id, CqlConcept requestStatusReason, CqlDateTime authoredOn)? NoVTEDevice)?, Encounter>(h_, i_);
        return j_;
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
            IEnumerable<CqlConcept> j_ = NoVTEMedication?.medicationStatusReason;

            bool? k_(CqlConcept MedRsn) {
                CqlValueSet m_ = this.Patient_Refusal(context);
                bool? n_ = context.Operators.ConceptInValueSet(MedRsn, m_);
                return n_;
            }

            bool? l_ = context.Operators.WhereAny<CqlConcept>(j_, k_);
            return l_;
        }

        object c_((CqlTupleMetadata, string id, IEnumerable<CqlConcept> medicationStatusReason, CqlDateTime authoredOn)? tuple_eodcxckcyhgehinqchjlrjuqw) => tuple_eodcxckcyhgehinqchjlrjuqw;
        IEnumerable<object> d_ = context.Operators.WhereSelect<(CqlTupleMetadata, string id, IEnumerable<CqlConcept> medicationStatusReason, CqlDateTime authoredOn)?, object>(a_, b_, c_);
        IEnumerable<(CqlTupleMetadata, string id, CqlConcept requestStatusReason, CqlDateTime authoredOn)?> e_ = this.No_Mechanical_VTE_Prophylaxis_Performed_Or_Ordered(context);

        bool? f_((CqlTupleMetadata, string id, CqlConcept requestStatusReason, CqlDateTime authoredOn)? NoVTEDevice) {
            CqlConcept o_ = NoVTEDevice?.requestStatusReason;
            CqlValueSet p_ = this.Patient_Refusal(context);
            bool? q_ = context.Operators.ConceptInValueSet(o_, p_);
            return q_;
        }

        object g_((CqlTupleMetadata, string id, CqlConcept requestStatusReason, CqlDateTime authoredOn)? tuple_dahzgfwmlihdcaesamjofzbqi) => tuple_dahzgfwmlihdcaesamjofzbqi;
        IEnumerable<object> h_ = context.Operators.WhereSelect<(CqlTupleMetadata, string id, CqlConcept requestStatusReason, CqlDateTime authoredOn)?, object>(e_, f_, g_);
        IEnumerable<object> i_ = context.Operators.Union<object>(d_, h_);
        return i_;
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
                CqlDateTime g_;
                if (PatientRefusal is ValueTuple<CqlTupleMetadata, string, IEnumerable<CqlConcept>, CqlDateTime>)
                {
                    CqlDateTime q_ = (PatientRefusal as (CqlTupleMetadata, string id, IEnumerable<CqlConcept> medicationStatusReason, CqlDateTime authoredOn)?)?.authoredOn;
                    g_ = q_;
                }
                else if (PatientRefusal is ValueTuple<CqlTupleMetadata, string, CqlConcept, CqlDateTime>)
                {
                    CqlDateTime r_ = (PatientRefusal as (CqlTupleMetadata, string id, CqlConcept requestStatusReason, CqlDateTime authoredOn)?)?.authoredOn;
                    g_ = r_;
                }
                else
                {
                    g_ = default;
                }
                CqlInterval<CqlDate> h_ = this.fromDayOfStartOfHospitalizationToDayAfterAdmission(context, QualifyingEncounter);
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

    private const long _cacheIndex_No_VTE_Prophylaxis_Due_To_Patient_Refusal_On_Day_Of_Or_Day_After_Procedure = 98430516828796694L;

    private IEnumerable<Encounter> No_VTE_Prophylaxis_Due_To_Patient_Refusal_On_Day_Of_Or_Day_After_Procedure_Compute(CqlContext context)
    {
        IEnumerable<Encounter> a_ = VTE_8_18_000.Instance.Encounter_With_Age_Range_And_Without_VTE_Diagnosis_Or_Obstetrical_Conditions(context);
        CqlValueSet b_ = this.General_or_Neuraxial_Anesthesia(context);
        IEnumerable<Procedure> c_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, b_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
        IEnumerable<object> d_ = this.No_Mechanical_Or_Pharmacological_VTE_Prophylaxis_Due_To_Patient_Refusal(context);
        IEnumerable<ValueTuple<Encounter, Procedure, object>> e_ = context.Operators.CrossJoin<Encounter, Procedure, object>(a_, c_, d_);

        (CqlTupleMetadata, Encounter QualifyingEncounter, Procedure AnesthesiaProcedure, object PatientRefusal)? f_(ValueTuple<Encounter, Procedure, object> _valueTuple) {
            (CqlTupleMetadata, Encounter QualifyingEncounter, Procedure AnesthesiaProcedure, object PatientRefusal)? k_ = (CqlTupleMetadata_EPgUKHFGKDiGHBcZKVcEFWgbe, _valueTuple.Item1, _valueTuple.Item2, _valueTuple.Item3);
            return k_;
        }


        bool? g_((CqlTupleMetadata, Encounter QualifyingEncounter, Procedure AnesthesiaProcedure, object PatientRefusal)? tuple_fpeghttqsjgusnbabduddbjbh) {
            Code<EventStatus> l_ = tuple_fpeghttqsjgusnbabduddbjbh?.AnesthesiaProcedure?.StatusElement;
            EventStatus? m_ = l_?.Value;
            string n_ = context.Operators.Convert<string>(m_);
            bool? o_ = context.Operators.Equal(n_, "completed");
            object p_;
            DataType az_ = tuple_fpeghttqsjgusnbabduddbjbh?.AnesthesiaProcedure?.Performed;
            object ba_ = FHIRHelpers_4_4_000.Instance.ToValue(context, az_);
            bool bb_ = ba_ is CqlDateTime;
            if (bb_)
            {
                p_ = ba_ as CqlDateTime;
            }
            else
            {
                bool bc_ = ba_ is CqlQuantity;
                if (bc_)
                {
                    p_ = ba_ as CqlQuantity;
                }
                else
                {
                    bool bd_ = ba_ is CqlInterval<CqlDateTime>;
                    if (bd_)
                    {
                        p_ = ba_ as CqlInterval<CqlDateTime>;
                    }
                    else
                    {
                        bool be_ = ba_ is CqlInterval<CqlQuantity>;
                        if (be_)
                        {
                            p_ = ba_ as CqlInterval<CqlQuantity>;
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
            Period s_ = tuple_fpeghttqsjgusnbabduddbjbh?.QualifyingEncounter?.Period;
            CqlInterval<CqlDateTime> t_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, s_);
            CqlDateTime u_ = context.Operators.Start(t_);
            CqlQuantity v_ = context.Operators.Quantity(1m, "day");
            CqlDateTime w_ = context.Operators.Add(u_, v_);
            bool? x_ = context.Operators.SameAs(r_, w_, "day");
            bool? y_ = context.Operators.And(o_, x_);
            CqlDateTime z_;
            if (tuple_fpeghttqsjgusnbabduddbjbh?.PatientRefusal is ValueTuple<CqlTupleMetadata, string, IEnumerable<CqlConcept>, CqlDateTime>)
            {
                CqlDateTime bf_ = (tuple_fpeghttqsjgusnbabduddbjbh?.PatientRefusal as (CqlTupleMetadata, string id, IEnumerable<CqlConcept> medicationStatusReason, CqlDateTime authoredOn)?)?.authoredOn;
                z_ = bf_;
            }
            else if (tuple_fpeghttqsjgusnbabduddbjbh?.PatientRefusal is ValueTuple<CqlTupleMetadata, string, CqlConcept, CqlDateTime>)
            {
                CqlDateTime bg_ = (tuple_fpeghttqsjgusnbabduddbjbh?.PatientRefusal as (CqlTupleMetadata, string id, CqlConcept requestStatusReason, CqlDateTime authoredOn)?)?.authoredOn;
                z_ = bg_;
            }
            else
            {
                z_ = default;
            }
            object aa_;
            DataType bh_ = tuple_fpeghttqsjgusnbabduddbjbh?.AnesthesiaProcedure?.Performed;
            object bi_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bh_);
            bool bj_ = bi_ is CqlDateTime;
            if (bj_)
            {
                aa_ = bi_ as CqlDateTime;
            }
            else
            {
                bool bk_ = bi_ is CqlQuantity;
                if (bk_)
                {
                    aa_ = bi_ as CqlQuantity;
                }
                else
                {
                    bool bl_ = bi_ is CqlInterval<CqlDateTime>;
                    if (bl_)
                    {
                        aa_ = bi_ as CqlInterval<CqlDateTime>;
                    }
                    else
                    {
                        bool bm_ = bi_ is CqlInterval<CqlQuantity>;
                        if (bm_)
                        {
                            aa_ = bi_ as CqlInterval<CqlQuantity>;
                        }
                        else
                        {
                            aa_ = null;
                        }
                    }
                }
            }
            CqlInterval<CqlDateTime> ab_ = QICoreCommon_4_0_000.Instance.toInterval(context, aa_);
            CqlDateTime ac_ = context.Operators.End(ab_);
            CqlInterval<CqlDate> ad_ = TJCOverall_8_25_000.Instance.calendarDayOfOrDayAfter(context, ac_);
            CqlDate ae_ = ad_?.low;
            CqlDateTime af_ = context.Operators.ConvertDateToDateTime(ae_);
            object ag_;
            DataType bn_ = tuple_fpeghttqsjgusnbabduddbjbh?.AnesthesiaProcedure?.Performed;
            object bo_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bn_);
            bool bp_ = bo_ is CqlDateTime;
            if (bp_)
            {
                ag_ = bo_ as CqlDateTime;
            }
            else
            {
                bool bq_ = bo_ is CqlQuantity;
                if (bq_)
                {
                    ag_ = bo_ as CqlQuantity;
                }
                else
                {
                    bool br_ = bo_ is CqlInterval<CqlDateTime>;
                    if (br_)
                    {
                        ag_ = bo_ as CqlInterval<CqlDateTime>;
                    }
                    else
                    {
                        bool bs_ = bo_ is CqlInterval<CqlQuantity>;
                        if (bs_)
                        {
                            ag_ = bo_ as CqlInterval<CqlQuantity>;
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
            CqlDate ak_ = aj_?.high;
            CqlDateTime al_ = context.Operators.ConvertDateToDateTime(ak_);
            object am_;
            DataType bt_ = tuple_fpeghttqsjgusnbabduddbjbh?.AnesthesiaProcedure?.Performed;
            object bu_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bt_);
            bool bv_ = bu_ is CqlDateTime;
            if (bv_)
            {
                am_ = bu_ as CqlDateTime;
            }
            else
            {
                bool bw_ = bu_ is CqlQuantity;
                if (bw_)
                {
                    am_ = bu_ as CqlQuantity;
                }
                else
                {
                    bool bx_ = bu_ is CqlInterval<CqlDateTime>;
                    if (bx_)
                    {
                        am_ = bu_ as CqlInterval<CqlDateTime>;
                    }
                    else
                    {
                        bool by_ = bu_ is CqlInterval<CqlQuantity>;
                        if (by_)
                        {
                            am_ = bu_ as CqlInterval<CqlQuantity>;
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
            bool? aq_ = ap_?.lowClosed;
            object ar_;
            DataType bz_ = tuple_fpeghttqsjgusnbabduddbjbh?.AnesthesiaProcedure?.Performed;
            object ca_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bz_);
            bool cb_ = ca_ is CqlDateTime;
            if (cb_)
            {
                ar_ = ca_ as CqlDateTime;
            }
            else
            {
                bool cc_ = ca_ is CqlQuantity;
                if (cc_)
                {
                    ar_ = ca_ as CqlQuantity;
                }
                else
                {
                    bool cd_ = ca_ is CqlInterval<CqlDateTime>;
                    if (cd_)
                    {
                        ar_ = ca_ as CqlInterval<CqlDateTime>;
                    }
                    else
                    {
                        bool ce_ = ca_ is CqlInterval<CqlQuantity>;
                        if (ce_)
                        {
                            ar_ = ca_ as CqlInterval<CqlQuantity>;
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
            CqlInterval<CqlDate> au_ = TJCOverall_8_25_000.Instance.calendarDayOfOrDayAfter(context, at_);
            bool? av_ = au_?.highClosed;
            CqlInterval<CqlDateTime> aw_ = context.Operators.Interval(af_, al_, aq_, av_);
            bool? ax_ = context.Operators.In<CqlDateTime>(z_, aw_, "day");
            bool? ay_ = context.Operators.And(y_, ax_);
            return ay_;
        }

        IEnumerable<(CqlTupleMetadata, Encounter QualifyingEncounter, Procedure AnesthesiaProcedure, object PatientRefusal)?> h_ = context.Operators.SelectWhere<ValueTuple<Encounter, Procedure, object>, (CqlTupleMetadata, Encounter QualifyingEncounter, Procedure AnesthesiaProcedure, object PatientRefusal)?>(e_, f_, g_);
        Encounter i_((CqlTupleMetadata, Encounter QualifyingEncounter, Procedure AnesthesiaProcedure, object PatientRefusal)? tuple_fpeghttqsjgusnbabduddbjbh) => tuple_fpeghttqsjgusnbabduddbjbh?.QualifyingEncounter;
        IEnumerable<Encounter> j_ = context.Operators.SelectDistinct<(CqlTupleMetadata, Encounter QualifyingEncounter, Procedure AnesthesiaProcedure, object PatientRefusal)?, Encounter>(h_, i_);
        return j_;
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

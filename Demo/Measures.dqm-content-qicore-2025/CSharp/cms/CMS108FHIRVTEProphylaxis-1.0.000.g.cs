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
                object w_ = ComfortMeasure is Procedure v_ ? v_.Performed : null;
                object x_ = FHIRHelpers_4_4_000.Instance.ToValue(context, w_);
                bool y_ = x_ is CqlDateTime;
                if (y_)
                {
                    object aa_ = ComfortMeasure is Procedure z_ ? z_.Performed : null;
                    object ab_ = FHIRHelpers_4_4_000.Instance.ToValue(context, aa_);
                    g_ = ab_ as CqlDateTime;
                }
                else
                {
                    object ad_ = ComfortMeasure is Procedure ac_ ? ac_.Performed : null;
                    object ae_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ad_);
                    bool af_ = ae_ is CqlQuantity;
                    if (af_)
                    {
                        object ah_ = ComfortMeasure is Procedure ag_ ? ag_.Performed : null;
                        object ai_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ah_);
                        g_ = ai_ as CqlQuantity;
                    }
                    else
                    {
                        object ak_ = ComfortMeasure is Procedure aj_ ? aj_.Performed : null;
                        object al_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ak_);
                        bool am_ = al_ is CqlInterval<CqlDateTime>;
                        if (am_)
                        {
                            object ao_ = ComfortMeasure is Procedure an_ ? an_.Performed : null;
                            object ap_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ao_);
                            g_ = ap_ as CqlInterval<CqlDateTime>;
                        }
                        else
                        {
                            object ar_ = ComfortMeasure is Procedure aq_ ? aq_.Performed : null;
                            object as_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ar_);
                            bool at_ = as_ is CqlInterval<CqlQuantity>;
                            if (at_)
                            {
                                object av_ = ComfortMeasure is Procedure au_ ? au_.Performed : null;
                                object aw_ = FHIRHelpers_4_4_000.Instance.ToValue(context, av_);
                                g_ = aw_ as CqlInterval<CqlQuantity>;
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
                FhirDateTime k_ = ComfortMeasure is ServiceRequest j_ ? j_.AuthoredOnElement : null;
                CqlDateTime l_ = context.Operators.Convert<CqlDateTime>(k_);
                CqlInterval<CqlDate> m_ = this.fromDayOfStartOfHospitalizationToDayAfterAdmission(context, QualifyingEncounter);
                CqlDate n_ = m_?.low;
                CqlDateTime o_ = context.Operators.ConvertDateToDateTime(n_);
                CqlDate p_ = m_?.high;
                CqlDateTime q_ = context.Operators.ConvertDateToDateTime(p_);
                bool? r_ = m_?.lowClosed;
                bool? s_ = m_?.highClosed;
                CqlInterval<CqlDateTime> t_ = context.Operators.Interval(o_, q_, r_, s_);
                bool? u_ = context.Operators.In<CqlDateTime>(i_ ?? l_, t_, "day");
                return u_;
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
            DataType bf_ = tuple_hbjscqgbuhismoaytymvucjfi?.AnesthesiaProcedure?.Performed;
            object bg_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bf_);
            bool bh_ = bg_ is CqlDateTime;
            if (bh_)
            {
                DataType bi_ = tuple_hbjscqgbuhismoaytymvucjfi?.AnesthesiaProcedure?.Performed;
                object bj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bi_);
                p_ = bj_ as CqlDateTime;
            }
            else
            {
                DataType bk_ = tuple_hbjscqgbuhismoaytymvucjfi?.AnesthesiaProcedure?.Performed;
                object bl_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bk_);
                bool bm_ = bl_ is CqlQuantity;
                if (bm_)
                {
                    DataType bn_ = tuple_hbjscqgbuhismoaytymvucjfi?.AnesthesiaProcedure?.Performed;
                    object bo_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bn_);
                    p_ = bo_ as CqlQuantity;
                }
                else
                {
                    DataType bp_ = tuple_hbjscqgbuhismoaytymvucjfi?.AnesthesiaProcedure?.Performed;
                    object bq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bp_);
                    bool br_ = bq_ is CqlInterval<CqlDateTime>;
                    if (br_)
                    {
                        DataType bs_ = tuple_hbjscqgbuhismoaytymvucjfi?.AnesthesiaProcedure?.Performed;
                        object bt_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bs_);
                        p_ = bt_ as CqlInterval<CqlDateTime>;
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
                            p_ = by_ as CqlInterval<CqlQuantity>;
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
            object bz_ = tuple_hbjscqgbuhismoaytymvucjfi?.ComfortMeasure;
            object cb_ = bz_ is Procedure ca_ ? ca_.Performed : null;
            object cc_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cb_);
            bool cd_ = cc_ is CqlDateTime;
            if (cd_)
            {
                object ce_ = tuple_hbjscqgbuhismoaytymvucjfi?.ComfortMeasure;
                object cg_ = ce_ is Procedure cf_ ? cf_.Performed : null;
                object ch_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cg_);
                z_ = ch_ as CqlDateTime;
            }
            else
            {
                object ci_ = tuple_hbjscqgbuhismoaytymvucjfi?.ComfortMeasure;
                object ck_ = ci_ is Procedure cj_ ? cj_.Performed : null;
                object cl_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ck_);
                bool cm_ = cl_ is CqlQuantity;
                if (cm_)
                {
                    object cn_ = tuple_hbjscqgbuhismoaytymvucjfi?.ComfortMeasure;
                    object cp_ = cn_ is Procedure co_ ? co_.Performed : null;
                    object cq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cp_);
                    z_ = cq_ as CqlQuantity;
                }
                else
                {
                    object cr_ = tuple_hbjscqgbuhismoaytymvucjfi?.ComfortMeasure;
                    object ct_ = cr_ is Procedure cs_ ? cs_.Performed : null;
                    object cu_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ct_);
                    bool cv_ = cu_ is CqlInterval<CqlDateTime>;
                    if (cv_)
                    {
                        object cw_ = tuple_hbjscqgbuhismoaytymvucjfi?.ComfortMeasure;
                        object cy_ = cw_ is Procedure cx_ ? cx_.Performed : null;
                        object cz_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cy_);
                        z_ = cz_ as CqlInterval<CqlDateTime>;
                    }
                    else
                    {
                        object da_ = tuple_hbjscqgbuhismoaytymvucjfi?.ComfortMeasure;
                        object dc_ = da_ is Procedure db_ ? db_.Performed : null;
                        object dd_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dc_);
                        bool de_ = dd_ is CqlInterval<CqlQuantity>;
                        if (de_)
                        {
                            object df_ = tuple_hbjscqgbuhismoaytymvucjfi?.ComfortMeasure;
                            object dh_ = df_ is Procedure dg_ ? dg_.Performed : null;
                            object di_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dh_);
                            z_ = di_ as CqlInterval<CqlQuantity>;
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
            object ac_ = tuple_hbjscqgbuhismoaytymvucjfi?.ComfortMeasure;
            FhirDateTime ae_ = ac_ is ServiceRequest ad_ ? ad_.AuthoredOnElement : null;
            CqlDateTime af_ = context.Operators.Convert<CqlDateTime>(ae_);
            object ag_;
            DataType dj_ = tuple_hbjscqgbuhismoaytymvucjfi?.AnesthesiaProcedure?.Performed;
            object dk_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dj_);
            bool dl_ = dk_ is CqlDateTime;
            if (dl_)
            {
                DataType dm_ = tuple_hbjscqgbuhismoaytymvucjfi?.AnesthesiaProcedure?.Performed;
                object dn_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dm_);
                ag_ = dn_ as CqlDateTime;
            }
            else
            {
                DataType do_ = tuple_hbjscqgbuhismoaytymvucjfi?.AnesthesiaProcedure?.Performed;
                object dp_ = FHIRHelpers_4_4_000.Instance.ToValue(context, do_);
                bool dq_ = dp_ is CqlQuantity;
                if (dq_)
                {
                    DataType dr_ = tuple_hbjscqgbuhismoaytymvucjfi?.AnesthesiaProcedure?.Performed;
                    object ds_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dr_);
                    ag_ = ds_ as CqlQuantity;
                }
                else
                {
                    DataType dt_ = tuple_hbjscqgbuhismoaytymvucjfi?.AnesthesiaProcedure?.Performed;
                    object du_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dt_);
                    bool dv_ = du_ is CqlInterval<CqlDateTime>;
                    if (dv_)
                    {
                        DataType dw_ = tuple_hbjscqgbuhismoaytymvucjfi?.AnesthesiaProcedure?.Performed;
                        object dx_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dw_);
                        ag_ = dx_ as CqlInterval<CqlDateTime>;
                    }
                    else
                    {
                        DataType dy_ = tuple_hbjscqgbuhismoaytymvucjfi?.AnesthesiaProcedure?.Performed;
                        object dz_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dy_);
                        bool ea_ = dz_ is CqlInterval<CqlQuantity>;
                        if (ea_)
                        {
                            DataType eb_ = tuple_hbjscqgbuhismoaytymvucjfi?.AnesthesiaProcedure?.Performed;
                            object ec_ = FHIRHelpers_4_4_000.Instance.ToValue(context, eb_);
                            ag_ = ec_ as CqlInterval<CqlQuantity>;
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
            DataType ed_ = tuple_hbjscqgbuhismoaytymvucjfi?.AnesthesiaProcedure?.Performed;
            object ee_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ed_);
            bool ef_ = ee_ is CqlDateTime;
            if (ef_)
            {
                DataType eg_ = tuple_hbjscqgbuhismoaytymvucjfi?.AnesthesiaProcedure?.Performed;
                object eh_ = FHIRHelpers_4_4_000.Instance.ToValue(context, eg_);
                am_ = eh_ as CqlDateTime;
            }
            else
            {
                DataType ei_ = tuple_hbjscqgbuhismoaytymvucjfi?.AnesthesiaProcedure?.Performed;
                object ej_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ei_);
                bool ek_ = ej_ is CqlQuantity;
                if (ek_)
                {
                    DataType el_ = tuple_hbjscqgbuhismoaytymvucjfi?.AnesthesiaProcedure?.Performed;
                    object em_ = FHIRHelpers_4_4_000.Instance.ToValue(context, el_);
                    am_ = em_ as CqlQuantity;
                }
                else
                {
                    DataType en_ = tuple_hbjscqgbuhismoaytymvucjfi?.AnesthesiaProcedure?.Performed;
                    object eo_ = FHIRHelpers_4_4_000.Instance.ToValue(context, en_);
                    bool ep_ = eo_ is CqlInterval<CqlDateTime>;
                    if (ep_)
                    {
                        DataType eq_ = tuple_hbjscqgbuhismoaytymvucjfi?.AnesthesiaProcedure?.Performed;
                        object er_ = FHIRHelpers_4_4_000.Instance.ToValue(context, eq_);
                        am_ = er_ as CqlInterval<CqlDateTime>;
                    }
                    else
                    {
                        DataType es_ = tuple_hbjscqgbuhismoaytymvucjfi?.AnesthesiaProcedure?.Performed;
                        object et_ = FHIRHelpers_4_4_000.Instance.ToValue(context, es_);
                        bool eu_ = et_ is CqlInterval<CqlQuantity>;
                        if (eu_)
                        {
                            DataType ev_ = tuple_hbjscqgbuhismoaytymvucjfi?.AnesthesiaProcedure?.Performed;
                            object ew_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ev_);
                            am_ = ew_ as CqlInterval<CqlQuantity>;
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
            DataType ex_ = tuple_hbjscqgbuhismoaytymvucjfi?.AnesthesiaProcedure?.Performed;
            object ey_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ex_);
            bool ez_ = ey_ is CqlDateTime;
            if (ez_)
            {
                DataType fa_ = tuple_hbjscqgbuhismoaytymvucjfi?.AnesthesiaProcedure?.Performed;
                object fb_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fa_);
                as_ = fb_ as CqlDateTime;
            }
            else
            {
                DataType fc_ = tuple_hbjscqgbuhismoaytymvucjfi?.AnesthesiaProcedure?.Performed;
                object fd_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fc_);
                bool fe_ = fd_ is CqlQuantity;
                if (fe_)
                {
                    DataType ff_ = tuple_hbjscqgbuhismoaytymvucjfi?.AnesthesiaProcedure?.Performed;
                    object fg_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ff_);
                    as_ = fg_ as CqlQuantity;
                }
                else
                {
                    DataType fh_ = tuple_hbjscqgbuhismoaytymvucjfi?.AnesthesiaProcedure?.Performed;
                    object fi_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fh_);
                    bool fj_ = fi_ is CqlInterval<CqlDateTime>;
                    if (fj_)
                    {
                        DataType fk_ = tuple_hbjscqgbuhismoaytymvucjfi?.AnesthesiaProcedure?.Performed;
                        object fl_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fk_);
                        as_ = fl_ as CqlInterval<CqlDateTime>;
                    }
                    else
                    {
                        DataType fm_ = tuple_hbjscqgbuhismoaytymvucjfi?.AnesthesiaProcedure?.Performed;
                        object fn_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fm_);
                        bool fo_ = fn_ is CqlInterval<CqlQuantity>;
                        if (fo_)
                        {
                            DataType fp_ = tuple_hbjscqgbuhismoaytymvucjfi?.AnesthesiaProcedure?.Performed;
                            object fq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fp_);
                            as_ = fq_ as CqlInterval<CqlQuantity>;
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
            DataType fr_ = tuple_hbjscqgbuhismoaytymvucjfi?.AnesthesiaProcedure?.Performed;
            object fs_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fr_);
            bool ft_ = fs_ is CqlDateTime;
            if (ft_)
            {
                DataType fu_ = tuple_hbjscqgbuhismoaytymvucjfi?.AnesthesiaProcedure?.Performed;
                object fv_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fu_);
                ax_ = fv_ as CqlDateTime;
            }
            else
            {
                DataType fw_ = tuple_hbjscqgbuhismoaytymvucjfi?.AnesthesiaProcedure?.Performed;
                object fx_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fw_);
                bool fy_ = fx_ is CqlQuantity;
                if (fy_)
                {
                    DataType fz_ = tuple_hbjscqgbuhismoaytymvucjfi?.AnesthesiaProcedure?.Performed;
                    object ga_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fz_);
                    ax_ = ga_ as CqlQuantity;
                }
                else
                {
                    DataType gb_ = tuple_hbjscqgbuhismoaytymvucjfi?.AnesthesiaProcedure?.Performed;
                    object gc_ = FHIRHelpers_4_4_000.Instance.ToValue(context, gb_);
                    bool gd_ = gc_ is CqlInterval<CqlDateTime>;
                    if (gd_)
                    {
                        DataType ge_ = tuple_hbjscqgbuhismoaytymvucjfi?.AnesthesiaProcedure?.Performed;
                        object gf_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ge_);
                        ax_ = gf_ as CqlInterval<CqlDateTime>;
                    }
                    else
                    {
                        DataType gg_ = tuple_hbjscqgbuhismoaytymvucjfi?.AnesthesiaProcedure?.Performed;
                        object gh_ = FHIRHelpers_4_4_000.Instance.ToValue(context, gg_);
                        bool gi_ = gh_ is CqlInterval<CqlQuantity>;
                        if (gi_)
                        {
                            DataType gj_ = tuple_hbjscqgbuhismoaytymvucjfi?.AnesthesiaProcedure?.Performed;
                            object gk_ = FHIRHelpers_4_4_000.Instance.ToValue(context, gj_);
                            ax_ = gk_ as CqlInterval<CqlQuantity>;
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
            bool? bd_ = context.Operators.In<CqlDateTime>(ab_ ?? af_, bc_, "day");
            bool? be_ = context.Operators.And(y_, bd_);
            return be_;
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
                DataType be_ = MR?.Medication;
                FhirString bg_ = be_ is ResourceReference bf_ ? bf_.ReferenceElement : null;
                string bh_ = bg_?.Value;
                IEnumerable<string> bi_ = context.Operators.Split(bh_, "/");
                string bj_ = context.Operators.Last<string>(bi_);
                bool? bk_ = context.Operators.Equal(bd_, bj_);
                CodeableConcept bl_ = M?.Code;
                CqlConcept bm_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, bl_);
                CqlValueSet bn_ = this.Low_Dose_Unfractionated_Heparin_for_VTE_Prophylaxis(context);
                bool? bo_ = context.Operators.ConceptInValueSet(bm_, bn_);
                bool? bp_ = context.Operators.And(bk_, bo_);
                return bp_;
            }

            bool? bb_ = context.Operators.WhereAny<Medication>(az_, ba_);
            return bb_;
        }

        IEnumerable<MedicationAdministration> c_ = context.Operators.Where<MedicationAdministration>(a_, b_);
        CqlValueSet d_ = this.Low_Dose_Unfractionated_Heparin_for_VTE_Prophylaxis(context);
        IEnumerable<MedicationAdministration> e_ = context.Operators.Retrieve<MedicationAdministration>(new RetrieveParameters(default, d_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationadministration"));
        IEnumerable<MedicationAdministration> f_ = context.Operators.Union<MedicationAdministration>(c_, e_);

        bool? g_(MedicationAdministration VTEMedication) {
            Code<MedicationAdministration.MedicationAdministrationStatusCodes> bq_ = VTEMedication?.StatusElement;
            MedicationAdministration.MedicationAdministrationStatusCodes? br_ = bq_?.Value;
            string bs_ = context.Operators.Convert<string>(br_);
            bool? bt_ = context.Operators.Equal(bs_, "completed");
            MedicationAdministration.DosageComponent bu_ = VTEMedication?.Dosage;
            CodeableConcept bv_ = bu_?.Route;
            CqlConcept bw_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, bv_);
            CqlValueSet bx_ = this.Subcutaneous_route(context);
            bool? by_ = context.Operators.ConceptInValueSet(bw_, bx_);
            bool? bz_ = context.Operators.And(bt_, by_);
            return bz_;
        }

        IEnumerable<MedicationAdministration> h_ = context.Operators.Where<MedicationAdministration>(f_, g_);

        bool? i_(MedicationAdministration MR) {
            IEnumerable<Medication> ca_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));

            bool? cb_(Medication M) {
                Id cd_ = M?.IdElement;
                string ce_ = cd_?.Value;
                DataType cf_ = MR?.Medication;
                FhirString ch_ = cf_ is ResourceReference cg_ ? cg_.ReferenceElement : null;
                string ci_ = ch_?.Value;
                IEnumerable<string> cj_ = context.Operators.Split(ci_, "/");
                string ck_ = context.Operators.Last<string>(cj_);
                bool? cl_ = context.Operators.Equal(ce_, ck_);
                CodeableConcept cm_ = M?.Code;
                CqlConcept cn_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, cm_);
                CqlValueSet co_ = this.Low_Molecular_Weight_Heparin_for_VTE_Prophylaxis(context);
                bool? cp_ = context.Operators.ConceptInValueSet(cn_, co_);
                bool? cq_ = context.Operators.And(cl_, cp_);
                return cq_;
            }

            bool? cc_ = context.Operators.WhereAny<Medication>(ca_, cb_);
            return cc_;
        }

        IEnumerable<MedicationAdministration> j_ = context.Operators.Where<MedicationAdministration>(a_, i_);
        CqlValueSet k_ = this.Low_Molecular_Weight_Heparin_for_VTE_Prophylaxis(context);
        IEnumerable<MedicationAdministration> l_ = context.Operators.Retrieve<MedicationAdministration>(new RetrieveParameters(default, k_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationadministration"));
        IEnumerable<MedicationAdministration> m_ = context.Operators.Union<MedicationAdministration>(j_, l_);

        bool? n_(MedicationAdministration LMWH) {
            Code<MedicationAdministration.MedicationAdministrationStatusCodes> cr_ = LMWH?.StatusElement;
            MedicationAdministration.MedicationAdministrationStatusCodes? cs_ = cr_?.Value;
            string ct_ = context.Operators.Convert<string>(cs_);
            bool? cu_ = context.Operators.Equal(ct_, "completed");
            return cu_;
        }

        IEnumerable<MedicationAdministration> o_ = context.Operators.Where<MedicationAdministration>(m_, n_);
        IEnumerable<MedicationAdministration> p_ = context.Operators.Union<MedicationAdministration>(h_, o_);

        bool? q_(MedicationAdministration MR) {
            IEnumerable<Medication> cv_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));

            bool? cw_(Medication M) {
                Id cy_ = M?.IdElement;
                string cz_ = cy_?.Value;
                DataType da_ = MR?.Medication;
                FhirString dc_ = da_ is ResourceReference db_ ? db_.ReferenceElement : null;
                string dd_ = dc_?.Value;
                IEnumerable<string> de_ = context.Operators.Split(dd_, "/");
                string df_ = context.Operators.Last<string>(de_);
                bool? dg_ = context.Operators.Equal(cz_, df_);
                CodeableConcept dh_ = M?.Code;
                CqlConcept di_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, dh_);
                CqlValueSet dj_ = this.Injectable_Factor_Xa_Inhibitor_for_VTE_Prophylaxis(context);
                bool? dk_ = context.Operators.ConceptInValueSet(di_, dj_);
                bool? dl_ = context.Operators.And(dg_, dk_);
                return dl_;
            }

            bool? cx_ = context.Operators.WhereAny<Medication>(cv_, cw_);
            return cx_;
        }

        IEnumerable<MedicationAdministration> r_ = context.Operators.Where<MedicationAdministration>(a_, q_);
        CqlValueSet s_ = this.Injectable_Factor_Xa_Inhibitor_for_VTE_Prophylaxis(context);
        IEnumerable<MedicationAdministration> t_ = context.Operators.Retrieve<MedicationAdministration>(new RetrieveParameters(default, s_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationadministration"));
        IEnumerable<MedicationAdministration> u_ = context.Operators.Union<MedicationAdministration>(r_, t_);

        bool? v_(MedicationAdministration FactorXa) {
            Code<MedicationAdministration.MedicationAdministrationStatusCodes> dm_ = FactorXa?.StatusElement;
            MedicationAdministration.MedicationAdministrationStatusCodes? dn_ = dm_?.Value;
            string do_ = context.Operators.Convert<string>(dn_);
            bool? dp_ = context.Operators.Equal(do_, "completed");
            return dp_;
        }

        IEnumerable<MedicationAdministration> w_ = context.Operators.Where<MedicationAdministration>(u_, v_);

        bool? x_(MedicationAdministration MR) {
            IEnumerable<Medication> dq_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));

            bool? dr_(Medication M) {
                Id dt_ = M?.IdElement;
                string du_ = dt_?.Value;
                DataType dv_ = MR?.Medication;
                FhirString dx_ = dv_ is ResourceReference dw_ ? dw_.ReferenceElement : null;
                string dy_ = dx_?.Value;
                IEnumerable<string> dz_ = context.Operators.Split(dy_, "/");
                string ea_ = context.Operators.Last<string>(dz_);
                bool? eb_ = context.Operators.Equal(du_, ea_);
                CodeableConcept ec_ = M?.Code;
                CqlConcept ed_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, ec_);
                CqlValueSet ee_ = this.Warfarin(context);
                bool? ef_ = context.Operators.ConceptInValueSet(ed_, ee_);
                bool? eg_ = context.Operators.And(eb_, ef_);
                return eg_;
            }

            bool? ds_ = context.Operators.WhereAny<Medication>(dq_, dr_);
            return ds_;
        }

        IEnumerable<MedicationAdministration> y_ = context.Operators.Where<MedicationAdministration>(a_, x_);
        CqlValueSet z_ = this.Warfarin(context);
        IEnumerable<MedicationAdministration> aa_ = context.Operators.Retrieve<MedicationAdministration>(new RetrieveParameters(default, z_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationadministration"));
        IEnumerable<MedicationAdministration> ab_ = context.Operators.Union<MedicationAdministration>(y_, aa_);

        bool? ac_(MedicationAdministration WarfarinAdm) {
            Code<MedicationAdministration.MedicationAdministrationStatusCodes> eh_ = WarfarinAdm?.StatusElement;
            MedicationAdministration.MedicationAdministrationStatusCodes? ei_ = eh_?.Value;
            string ej_ = context.Operators.Convert<string>(ei_);
            bool? ek_ = context.Operators.Equal(ej_, "completed");
            return ek_;
        }

        IEnumerable<MedicationAdministration> ad_ = context.Operators.Where<MedicationAdministration>(ab_, ac_);
        IEnumerable<MedicationAdministration> ae_ = context.Operators.Union<MedicationAdministration>(w_, ad_);
        IEnumerable<MedicationAdministration> af_ = context.Operators.Union<MedicationAdministration>(p_, ae_);

        bool? ag_(MedicationAdministration MR) {
            IEnumerable<Medication> el_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));

            bool? em_(Medication M) {
                Id eo_ = M?.IdElement;
                string ep_ = eo_?.Value;
                DataType eq_ = MR?.Medication;
                FhirString es_ = eq_ is ResourceReference er_ ? er_.ReferenceElement : null;
                string et_ = es_?.Value;
                IEnumerable<string> eu_ = context.Operators.Split(et_, "/");
                string ev_ = context.Operators.Last<string>(eu_);
                bool? ew_ = context.Operators.Equal(ep_, ev_);
                CodeableConcept ex_ = M?.Code;
                CqlConcept ey_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, ex_);
                CqlValueSet ez_ = this.Rivaroxaban_for_VTE_Prophylaxis(context);
                bool? fa_ = context.Operators.ConceptInValueSet(ey_, ez_);
                bool? fb_ = context.Operators.And(ew_, fa_);
                return fb_;
            }

            bool? en_ = context.Operators.WhereAny<Medication>(el_, em_);
            return en_;
        }

        IEnumerable<MedicationAdministration> ah_ = context.Operators.Where<MedicationAdministration>(a_, ag_);
        CqlValueSet ai_ = this.Rivaroxaban_for_VTE_Prophylaxis(context);
        IEnumerable<MedicationAdministration> aj_ = context.Operators.Retrieve<MedicationAdministration>(new RetrieveParameters(default, ai_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationadministration"));
        IEnumerable<MedicationAdministration> ak_ = context.Operators.Union<MedicationAdministration>(ah_, aj_);

        bool? al_(MedicationAdministration Rivaroxaban) {
            Code<MedicationAdministration.MedicationAdministrationStatusCodes> fc_ = Rivaroxaban?.StatusElement;
            MedicationAdministration.MedicationAdministrationStatusCodes? fd_ = fc_?.Value;
            string fe_ = context.Operators.Convert<string>(fd_);
            bool? ff_ = context.Operators.Equal(fe_, "completed");
            return ff_;
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
            Code<EventStatus> fg_ = DeviceApplied?.StatusElement;
            EventStatus? fh_ = fg_?.Value;
            string fi_ = context.Operators.Convert<string>(fh_);
            bool? fj_ = context.Operators.Equal(fi_, "completed");
            return fj_;
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
            object s_ = tuple_dqdjdfndavflfyejysbyihgsj?.VTEProphylaxis;
            object u_ = s_ is MedicationAdministration t_ ? t_.Effective : null;
            object v_ = FHIRHelpers_4_4_000.Instance.ToValue(context, u_);
            CqlInterval<CqlDateTime> w_ = QICoreCommon_4_0_000.Instance.toInterval(context, v_);
            object x_;
            object aj_ = tuple_dqdjdfndavflfyejysbyihgsj?.VTEProphylaxis;
            object al_ = aj_ is Procedure ak_ ? ak_.Performed : null;
            object am_ = FHIRHelpers_4_4_000.Instance.ToValue(context, al_);
            bool an_ = am_ is CqlDateTime;
            if (an_)
            {
                object ao_ = tuple_dqdjdfndavflfyejysbyihgsj?.VTEProphylaxis;
                object aq_ = ao_ is Procedure ap_ ? ap_.Performed : null;
                object ar_ = FHIRHelpers_4_4_000.Instance.ToValue(context, aq_);
                x_ = ar_ as CqlDateTime;
            }
            else
            {
                object as_ = tuple_dqdjdfndavflfyejysbyihgsj?.VTEProphylaxis;
                object au_ = as_ is Procedure at_ ? at_.Performed : null;
                object av_ = FHIRHelpers_4_4_000.Instance.ToValue(context, au_);
                bool aw_ = av_ is CqlQuantity;
                if (aw_)
                {
                    object ax_ = tuple_dqdjdfndavflfyejysbyihgsj?.VTEProphylaxis;
                    object az_ = ax_ is Procedure ay_ ? ay_.Performed : null;
                    object ba_ = FHIRHelpers_4_4_000.Instance.ToValue(context, az_);
                    x_ = ba_ as CqlQuantity;
                }
                else
                {
                    object bb_ = tuple_dqdjdfndavflfyejysbyihgsj?.VTEProphylaxis;
                    object bd_ = bb_ is Procedure bc_ ? bc_.Performed : null;
                    object be_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bd_);
                    bool bf_ = be_ is CqlInterval<CqlDateTime>;
                    if (bf_)
                    {
                        object bg_ = tuple_dqdjdfndavflfyejysbyihgsj?.VTEProphylaxis;
                        object bi_ = bg_ is Procedure bh_ ? bh_.Performed : null;
                        object bj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bi_);
                        x_ = bj_ as CqlInterval<CqlDateTime>;
                    }
                    else
                    {
                        object bk_ = tuple_dqdjdfndavflfyejysbyihgsj?.VTEProphylaxis;
                        object bm_ = bk_ is Procedure bl_ ? bl_.Performed : null;
                        object bn_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bm_);
                        bool bo_ = bn_ is CqlInterval<CqlQuantity>;
                        if (bo_)
                        {
                            object bp_ = tuple_dqdjdfndavflfyejysbyihgsj?.VTEProphylaxis;
                            object br_ = bp_ is Procedure bq_ ? bq_.Performed : null;
                            object bs_ = FHIRHelpers_4_4_000.Instance.ToValue(context, br_);
                            x_ = bs_ as CqlInterval<CqlQuantity>;
                        }
                        else
                        {
                            x_ = null;
                        }
                    }
                }
            }
            CqlInterval<CqlDateTime> y_ = QICoreCommon_4_0_000.Instance.toInterval(context, x_);
            CqlDateTime z_ = context.Operators.Start(w_ ?? y_);
            CqlInterval<CqlDate> aa_ = this.fromDayOfStartOfHospitalizationToDayAfterAdmission(context, tuple_dqdjdfndavflfyejysbyihgsj?.QualifyingEncounter);
            CqlDate ab_ = aa_?.low;
            CqlDateTime ac_ = context.Operators.ConvertDateToDateTime(ab_);
            CqlDate ad_ = aa_?.high;
            CqlDateTime ae_ = context.Operators.ConvertDateToDateTime(ad_);
            bool? af_ = aa_?.lowClosed;
            bool? ag_ = aa_?.highClosed;
            CqlInterval<CqlDateTime> ah_ = context.Operators.Interval(ac_, ae_, af_, ag_);
            bool? ai_ = context.Operators.In<CqlDateTime>(z_, ah_, "day");
            return ai_;
        }

        IEnumerable<(CqlTupleMetadata, Encounter QualifyingEncounter, object VTEProphylaxis)?> f_ = context.Operators.SelectWhere<ValueTuple<Encounter, object>, (CqlTupleMetadata, Encounter QualifyingEncounter, object VTEProphylaxis)?>(c_, d_, e_);
        Encounter g_((CqlTupleMetadata, Encounter QualifyingEncounter, object VTEProphylaxis)? tuple_dqdjdfndavflfyejysbyihgsj) => tuple_dqdjdfndavflfyejysbyihgsj?.QualifyingEncounter;
        IEnumerable<Encounter> h_ = context.Operators.SelectDistinct<(CqlTupleMetadata, Encounter QualifyingEncounter, object VTEProphylaxis)?, Encounter>(f_, g_);
        CqlValueSet i_ = this.General_or_Neuraxial_Anesthesia(context);
        IEnumerable<Procedure> j_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, i_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
        IEnumerable<ValueTuple<Encounter, Procedure, object>> k_ = context.Operators.CrossJoin<Encounter, Procedure, object>(a_, j_, b_);

        (CqlTupleMetadata, Encounter QualifyingEncounter, Procedure AnesthesiaProcedure, object VTEProphylaxis)? l_(ValueTuple<Encounter, Procedure, object> _valueTuple) {
            (CqlTupleMetadata, Encounter QualifyingEncounter, Procedure AnesthesiaProcedure, object VTEProphylaxis)? bt_ = (CqlTupleMetadata_CfSFUFiTWJJfiZASQhERUdATP, _valueTuple.Item1, _valueTuple.Item2, _valueTuple.Item3);
            return bt_;
        }


        bool? m_((CqlTupleMetadata, Encounter QualifyingEncounter, Procedure AnesthesiaProcedure, object VTEProphylaxis)? tuple_bnvctjfzpousixdcefwhciwq) {
            Code<EventStatus> bu_ = tuple_bnvctjfzpousixdcefwhciwq?.AnesthesiaProcedure?.StatusElement;
            EventStatus? bv_ = bu_?.Value;
            string bw_ = context.Operators.Convert<string>(bv_);
            bool? bx_ = context.Operators.Equal(bw_, "completed");
            object by_;
            DataType dp_ = tuple_bnvctjfzpousixdcefwhciwq?.AnesthesiaProcedure?.Performed;
            object dq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dp_);
            bool dr_ = dq_ is CqlDateTime;
            if (dr_)
            {
                DataType ds_ = tuple_bnvctjfzpousixdcefwhciwq?.AnesthesiaProcedure?.Performed;
                object dt_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ds_);
                by_ = dt_ as CqlDateTime;
            }
            else
            {
                DataType du_ = tuple_bnvctjfzpousixdcefwhciwq?.AnesthesiaProcedure?.Performed;
                object dv_ = FHIRHelpers_4_4_000.Instance.ToValue(context, du_);
                bool dw_ = dv_ is CqlQuantity;
                if (dw_)
                {
                    DataType dx_ = tuple_bnvctjfzpousixdcefwhciwq?.AnesthesiaProcedure?.Performed;
                    object dy_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dx_);
                    by_ = dy_ as CqlQuantity;
                }
                else
                {
                    DataType dz_ = tuple_bnvctjfzpousixdcefwhciwq?.AnesthesiaProcedure?.Performed;
                    object ea_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dz_);
                    bool eb_ = ea_ is CqlInterval<CqlDateTime>;
                    if (eb_)
                    {
                        DataType ec_ = tuple_bnvctjfzpousixdcefwhciwq?.AnesthesiaProcedure?.Performed;
                        object ed_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ec_);
                        by_ = ed_ as CqlInterval<CqlDateTime>;
                    }
                    else
                    {
                        DataType ee_ = tuple_bnvctjfzpousixdcefwhciwq?.AnesthesiaProcedure?.Performed;
                        object ef_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ee_);
                        bool eg_ = ef_ is CqlInterval<CqlQuantity>;
                        if (eg_)
                        {
                            DataType eh_ = tuple_bnvctjfzpousixdcefwhciwq?.AnesthesiaProcedure?.Performed;
                            object ei_ = FHIRHelpers_4_4_000.Instance.ToValue(context, eh_);
                            by_ = ei_ as CqlInterval<CqlQuantity>;
                        }
                        else
                        {
                            by_ = null;
                        }
                    }
                }
            }
            CqlInterval<CqlDateTime> bz_ = QICoreCommon_4_0_000.Instance.toInterval(context, by_);
            CqlDateTime ca_ = context.Operators.End(bz_);
            Period cb_ = tuple_bnvctjfzpousixdcefwhciwq?.QualifyingEncounter?.Period;
            CqlInterval<CqlDateTime> cc_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, cb_);
            CqlDateTime cd_ = context.Operators.Start(cc_);
            CqlQuantity ce_ = context.Operators.Quantity(1m, "day");
            CqlDateTime cf_ = context.Operators.Add(cd_, ce_);
            bool? cg_ = context.Operators.SameAs(ca_, cf_, "day");
            bool? ch_ = context.Operators.And(bx_, cg_);
            object ci_ = tuple_bnvctjfzpousixdcefwhciwq?.VTEProphylaxis;
            object ck_ = ci_ is MedicationAdministration cj_ ? cj_.Effective : null;
            object cl_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ck_);
            CqlInterval<CqlDateTime> cm_ = QICoreCommon_4_0_000.Instance.toInterval(context, cl_);
            object cn_;
            object ej_ = tuple_bnvctjfzpousixdcefwhciwq?.VTEProphylaxis;
            object el_ = ej_ is Procedure ek_ ? ek_.Performed : null;
            object em_ = FHIRHelpers_4_4_000.Instance.ToValue(context, el_);
            bool en_ = em_ is CqlDateTime;
            if (en_)
            {
                object eo_ = tuple_bnvctjfzpousixdcefwhciwq?.VTEProphylaxis;
                object eq_ = eo_ is Procedure ep_ ? ep_.Performed : null;
                object er_ = FHIRHelpers_4_4_000.Instance.ToValue(context, eq_);
                cn_ = er_ as CqlDateTime;
            }
            else
            {
                object es_ = tuple_bnvctjfzpousixdcefwhciwq?.VTEProphylaxis;
                object eu_ = es_ is Procedure et_ ? et_.Performed : null;
                object ev_ = FHIRHelpers_4_4_000.Instance.ToValue(context, eu_);
                bool ew_ = ev_ is CqlQuantity;
                if (ew_)
                {
                    object ex_ = tuple_bnvctjfzpousixdcefwhciwq?.VTEProphylaxis;
                    object ez_ = ex_ is Procedure ey_ ? ey_.Performed : null;
                    object fa_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ez_);
                    cn_ = fa_ as CqlQuantity;
                }
                else
                {
                    object fb_ = tuple_bnvctjfzpousixdcefwhciwq?.VTEProphylaxis;
                    object fd_ = fb_ is Procedure fc_ ? fc_.Performed : null;
                    object fe_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fd_);
                    bool ff_ = fe_ is CqlInterval<CqlDateTime>;
                    if (ff_)
                    {
                        object fg_ = tuple_bnvctjfzpousixdcefwhciwq?.VTEProphylaxis;
                        object fi_ = fg_ is Procedure fh_ ? fh_.Performed : null;
                        object fj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fi_);
                        cn_ = fj_ as CqlInterval<CqlDateTime>;
                    }
                    else
                    {
                        object fk_ = tuple_bnvctjfzpousixdcefwhciwq?.VTEProphylaxis;
                        object fm_ = fk_ is Procedure fl_ ? fl_.Performed : null;
                        object fn_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fm_);
                        bool fo_ = fn_ is CqlInterval<CqlQuantity>;
                        if (fo_)
                        {
                            object fp_ = tuple_bnvctjfzpousixdcefwhciwq?.VTEProphylaxis;
                            object fr_ = fp_ is Procedure fq_ ? fq_.Performed : null;
                            object fs_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fr_);
                            cn_ = fs_ as CqlInterval<CqlQuantity>;
                        }
                        else
                        {
                            cn_ = null;
                        }
                    }
                }
            }
            CqlInterval<CqlDateTime> co_ = QICoreCommon_4_0_000.Instance.toInterval(context, cn_);
            CqlDateTime cp_ = context.Operators.Start(cm_ ?? co_);
            object cq_;
            DataType ft_ = tuple_bnvctjfzpousixdcefwhciwq?.AnesthesiaProcedure?.Performed;
            object fu_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ft_);
            bool fv_ = fu_ is CqlDateTime;
            if (fv_)
            {
                DataType fw_ = tuple_bnvctjfzpousixdcefwhciwq?.AnesthesiaProcedure?.Performed;
                object fx_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fw_);
                cq_ = fx_ as CqlDateTime;
            }
            else
            {
                DataType fy_ = tuple_bnvctjfzpousixdcefwhciwq?.AnesthesiaProcedure?.Performed;
                object fz_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fy_);
                bool ga_ = fz_ is CqlQuantity;
                if (ga_)
                {
                    DataType gb_ = tuple_bnvctjfzpousixdcefwhciwq?.AnesthesiaProcedure?.Performed;
                    object gc_ = FHIRHelpers_4_4_000.Instance.ToValue(context, gb_);
                    cq_ = gc_ as CqlQuantity;
                }
                else
                {
                    DataType gd_ = tuple_bnvctjfzpousixdcefwhciwq?.AnesthesiaProcedure?.Performed;
                    object ge_ = FHIRHelpers_4_4_000.Instance.ToValue(context, gd_);
                    bool gf_ = ge_ is CqlInterval<CqlDateTime>;
                    if (gf_)
                    {
                        DataType gg_ = tuple_bnvctjfzpousixdcefwhciwq?.AnesthesiaProcedure?.Performed;
                        object gh_ = FHIRHelpers_4_4_000.Instance.ToValue(context, gg_);
                        cq_ = gh_ as CqlInterval<CqlDateTime>;
                    }
                    else
                    {
                        DataType gi_ = tuple_bnvctjfzpousixdcefwhciwq?.AnesthesiaProcedure?.Performed;
                        object gj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, gi_);
                        bool gk_ = gj_ is CqlInterval<CqlQuantity>;
                        if (gk_)
                        {
                            DataType gl_ = tuple_bnvctjfzpousixdcefwhciwq?.AnesthesiaProcedure?.Performed;
                            object gm_ = FHIRHelpers_4_4_000.Instance.ToValue(context, gl_);
                            cq_ = gm_ as CqlInterval<CqlQuantity>;
                        }
                        else
                        {
                            cq_ = null;
                        }
                    }
                }
            }
            CqlInterval<CqlDateTime> cr_ = QICoreCommon_4_0_000.Instance.toInterval(context, cq_);
            CqlDateTime cs_ = context.Operators.End(cr_);
            CqlInterval<CqlDate> ct_ = TJCOverall_8_25_000.Instance.calendarDayOfOrDayAfter(context, cs_);
            CqlDate cu_ = ct_?.low;
            CqlDateTime cv_ = context.Operators.ConvertDateToDateTime(cu_);
            object cw_;
            DataType gn_ = tuple_bnvctjfzpousixdcefwhciwq?.AnesthesiaProcedure?.Performed;
            object go_ = FHIRHelpers_4_4_000.Instance.ToValue(context, gn_);
            bool gp_ = go_ is CqlDateTime;
            if (gp_)
            {
                DataType gq_ = tuple_bnvctjfzpousixdcefwhciwq?.AnesthesiaProcedure?.Performed;
                object gr_ = FHIRHelpers_4_4_000.Instance.ToValue(context, gq_);
                cw_ = gr_ as CqlDateTime;
            }
            else
            {
                DataType gs_ = tuple_bnvctjfzpousixdcefwhciwq?.AnesthesiaProcedure?.Performed;
                object gt_ = FHIRHelpers_4_4_000.Instance.ToValue(context, gs_);
                bool gu_ = gt_ is CqlQuantity;
                if (gu_)
                {
                    DataType gv_ = tuple_bnvctjfzpousixdcefwhciwq?.AnesthesiaProcedure?.Performed;
                    object gw_ = FHIRHelpers_4_4_000.Instance.ToValue(context, gv_);
                    cw_ = gw_ as CqlQuantity;
                }
                else
                {
                    DataType gx_ = tuple_bnvctjfzpousixdcefwhciwq?.AnesthesiaProcedure?.Performed;
                    object gy_ = FHIRHelpers_4_4_000.Instance.ToValue(context, gx_);
                    bool gz_ = gy_ is CqlInterval<CqlDateTime>;
                    if (gz_)
                    {
                        DataType ha_ = tuple_bnvctjfzpousixdcefwhciwq?.AnesthesiaProcedure?.Performed;
                        object hb_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ha_);
                        cw_ = hb_ as CqlInterval<CqlDateTime>;
                    }
                    else
                    {
                        DataType hc_ = tuple_bnvctjfzpousixdcefwhciwq?.AnesthesiaProcedure?.Performed;
                        object hd_ = FHIRHelpers_4_4_000.Instance.ToValue(context, hc_);
                        bool he_ = hd_ is CqlInterval<CqlQuantity>;
                        if (he_)
                        {
                            DataType hf_ = tuple_bnvctjfzpousixdcefwhciwq?.AnesthesiaProcedure?.Performed;
                            object hg_ = FHIRHelpers_4_4_000.Instance.ToValue(context, hf_);
                            cw_ = hg_ as CqlInterval<CqlQuantity>;
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
            CqlDate da_ = cz_?.high;
            CqlDateTime db_ = context.Operators.ConvertDateToDateTime(da_);
            object dc_;
            DataType hh_ = tuple_bnvctjfzpousixdcefwhciwq?.AnesthesiaProcedure?.Performed;
            object hi_ = FHIRHelpers_4_4_000.Instance.ToValue(context, hh_);
            bool hj_ = hi_ is CqlDateTime;
            if (hj_)
            {
                DataType hk_ = tuple_bnvctjfzpousixdcefwhciwq?.AnesthesiaProcedure?.Performed;
                object hl_ = FHIRHelpers_4_4_000.Instance.ToValue(context, hk_);
                dc_ = hl_ as CqlDateTime;
            }
            else
            {
                DataType hm_ = tuple_bnvctjfzpousixdcefwhciwq?.AnesthesiaProcedure?.Performed;
                object hn_ = FHIRHelpers_4_4_000.Instance.ToValue(context, hm_);
                bool ho_ = hn_ is CqlQuantity;
                if (ho_)
                {
                    DataType hp_ = tuple_bnvctjfzpousixdcefwhciwq?.AnesthesiaProcedure?.Performed;
                    object hq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, hp_);
                    dc_ = hq_ as CqlQuantity;
                }
                else
                {
                    DataType hr_ = tuple_bnvctjfzpousixdcefwhciwq?.AnesthesiaProcedure?.Performed;
                    object hs_ = FHIRHelpers_4_4_000.Instance.ToValue(context, hr_);
                    bool ht_ = hs_ is CqlInterval<CqlDateTime>;
                    if (ht_)
                    {
                        DataType hu_ = tuple_bnvctjfzpousixdcefwhciwq?.AnesthesiaProcedure?.Performed;
                        object hv_ = FHIRHelpers_4_4_000.Instance.ToValue(context, hu_);
                        dc_ = hv_ as CqlInterval<CqlDateTime>;
                    }
                    else
                    {
                        DataType hw_ = tuple_bnvctjfzpousixdcefwhciwq?.AnesthesiaProcedure?.Performed;
                        object hx_ = FHIRHelpers_4_4_000.Instance.ToValue(context, hw_);
                        bool hy_ = hx_ is CqlInterval<CqlQuantity>;
                        if (hy_)
                        {
                            DataType hz_ = tuple_bnvctjfzpousixdcefwhciwq?.AnesthesiaProcedure?.Performed;
                            object ia_ = FHIRHelpers_4_4_000.Instance.ToValue(context, hz_);
                            dc_ = ia_ as CqlInterval<CqlQuantity>;
                        }
                        else
                        {
                            dc_ = null;
                        }
                    }
                }
            }
            CqlInterval<CqlDateTime> dd_ = QICoreCommon_4_0_000.Instance.toInterval(context, dc_);
            CqlDateTime de_ = context.Operators.End(dd_);
            CqlInterval<CqlDate> df_ = TJCOverall_8_25_000.Instance.calendarDayOfOrDayAfter(context, de_);
            bool? dg_ = df_?.lowClosed;
            object dh_;
            DataType ib_ = tuple_bnvctjfzpousixdcefwhciwq?.AnesthesiaProcedure?.Performed;
            object ic_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ib_);
            bool id_ = ic_ is CqlDateTime;
            if (id_)
            {
                DataType ie_ = tuple_bnvctjfzpousixdcefwhciwq?.AnesthesiaProcedure?.Performed;
                object if_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ie_);
                dh_ = if_ as CqlDateTime;
            }
            else
            {
                DataType ig_ = tuple_bnvctjfzpousixdcefwhciwq?.AnesthesiaProcedure?.Performed;
                object ih_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ig_);
                bool ii_ = ih_ is CqlQuantity;
                if (ii_)
                {
                    DataType ij_ = tuple_bnvctjfzpousixdcefwhciwq?.AnesthesiaProcedure?.Performed;
                    object ik_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ij_);
                    dh_ = ik_ as CqlQuantity;
                }
                else
                {
                    DataType il_ = tuple_bnvctjfzpousixdcefwhciwq?.AnesthesiaProcedure?.Performed;
                    object im_ = FHIRHelpers_4_4_000.Instance.ToValue(context, il_);
                    bool in_ = im_ is CqlInterval<CqlDateTime>;
                    if (in_)
                    {
                        DataType io_ = tuple_bnvctjfzpousixdcefwhciwq?.AnesthesiaProcedure?.Performed;
                        object ip_ = FHIRHelpers_4_4_000.Instance.ToValue(context, io_);
                        dh_ = ip_ as CqlInterval<CqlDateTime>;
                    }
                    else
                    {
                        DataType iq_ = tuple_bnvctjfzpousixdcefwhciwq?.AnesthesiaProcedure?.Performed;
                        object ir_ = FHIRHelpers_4_4_000.Instance.ToValue(context, iq_);
                        bool is_ = ir_ is CqlInterval<CqlQuantity>;
                        if (is_)
                        {
                            DataType it_ = tuple_bnvctjfzpousixdcefwhciwq?.AnesthesiaProcedure?.Performed;
                            object iu_ = FHIRHelpers_4_4_000.Instance.ToValue(context, it_);
                            dh_ = iu_ as CqlInterval<CqlQuantity>;
                        }
                        else
                        {
                            dh_ = null;
                        }
                    }
                }
            }
            CqlInterval<CqlDateTime> di_ = QICoreCommon_4_0_000.Instance.toInterval(context, dh_);
            CqlDateTime dj_ = context.Operators.End(di_);
            CqlInterval<CqlDate> dk_ = TJCOverall_8_25_000.Instance.calendarDayOfOrDayAfter(context, dj_);
            bool? dl_ = dk_?.highClosed;
            CqlInterval<CqlDateTime> dm_ = context.Operators.Interval(cv_, db_, dg_, dl_);
            bool? dn_ = context.Operators.In<CqlDateTime>(cp_, dm_, "day");
            bool? do_ = context.Operators.And(ch_, dn_);
            return do_;
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
                DataType ae_ = MR?.Medication;
                FhirString ag_ = ae_ is ResourceReference af_ ? af_.ReferenceElement : null;
                string ah_ = ag_?.Value;
                IEnumerable<string> ai_ = context.Operators.Split(ah_, "/");
                string aj_ = context.Operators.Last<string>(ai_);
                bool? ak_ = context.Operators.Equal(ad_, aj_);
                CodeableConcept al_ = M?.Code;
                CqlConcept am_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, al_);
                CqlValueSet an_ = this.Oral_Factor_Xa_Inhibitor_for_VTE_Prophylaxis_or_VTE_Treatment(context);
                bool? ao_ = context.Operators.ConceptInValueSet(am_, an_);
                bool? ap_ = context.Operators.And(ak_, ao_);
                return ap_;
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
            (CqlTupleMetadata, Encounter QualifyingEncounter, MedicationAdministration FactorXaMedication)? aq_ = (CqlTupleMetadata_EBRQeiSMaTgecHVEbVOIMZEcb, _valueTuple.Item1, _valueTuple.Item2);
            return aq_;
        }


        bool? j_((CqlTupleMetadata, Encounter QualifyingEncounter, MedicationAdministration FactorXaMedication)? tuple_cdbvhiekdcojzrccbhjghhgeo) {
            Code<MedicationAdministration.MedicationAdministrationStatusCodes> ar_ = tuple_cdbvhiekdcojzrccbhjghhgeo?.FactorXaMedication?.StatusElement;
            MedicationAdministration.MedicationAdministrationStatusCodes? as_ = ar_?.Value;
            string at_ = context.Operators.Convert<string>(as_);
            bool? au_ = context.Operators.Equal(at_, "completed");
            DataType av_ = tuple_cdbvhiekdcojzrccbhjghhgeo?.FactorXaMedication?.Effective;
            object aw_ = FHIRHelpers_4_4_000.Instance.ToValue(context, av_);
            CqlInterval<CqlDateTime> ax_ = QICoreCommon_4_0_000.Instance.toInterval(context, aw_);
            CqlDateTime ay_ = context.Operators.Start(ax_);
            Period az_ = tuple_cdbvhiekdcojzrccbhjghhgeo?.QualifyingEncounter?.Period;
            CqlInterval<CqlDateTime> ba_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, az_);
            CqlDateTime bb_ = context.Operators.Start(ba_);
            CqlInterval<CqlDate> bc_ = TJCOverall_8_25_000.Instance.calendarDayOfOrDayAfter(context, bb_);
            CqlDate bd_ = bc_?.low;
            CqlDateTime be_ = context.Operators.ConvertDateToDateTime(bd_);
            CqlDate bf_ = bc_?.high;
            CqlDateTime bg_ = context.Operators.ConvertDateToDateTime(bf_);
            bool? bh_ = bc_?.lowClosed;
            bool? bi_ = bc_?.highClosed;
            CqlInterval<CqlDateTime> bj_ = context.Operators.Interval(be_, bg_, bh_, bi_);
            bool? bk_ = context.Operators.In<CqlDateTime>(ay_, bj_, "day");
            bool? bl_ = context.Operators.And(au_, bk_);
            return bl_;
        }

        IEnumerable<(CqlTupleMetadata, Encounter QualifyingEncounter, MedicationAdministration FactorXaMedication)?> k_ = context.Operators.SelectWhere<ValueTuple<Encounter, MedicationAdministration>, (CqlTupleMetadata, Encounter QualifyingEncounter, MedicationAdministration FactorXaMedication)?>(h_, i_, j_);
        Encounter l_((CqlTupleMetadata, Encounter QualifyingEncounter, MedicationAdministration FactorXaMedication)? tuple_cdbvhiekdcojzrccbhjghhgeo) => tuple_cdbvhiekdcojzrccbhjghhgeo?.QualifyingEncounter;
        IEnumerable<Encounter> m_ = context.Operators.SelectDistinct<(CqlTupleMetadata, Encounter QualifyingEncounter, MedicationAdministration FactorXaMedication)?, Encounter>(k_, l_);
        CqlValueSet n_ = this.General_or_Neuraxial_Anesthesia(context);
        IEnumerable<Procedure> o_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, n_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));

        bool? p_(MedicationAdministration MR) {
            IEnumerable<Medication> bm_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));

            bool? bn_(Medication M) {
                Id bp_ = M?.IdElement;
                string bq_ = bp_?.Value;
                DataType br_ = MR?.Medication;
                FhirString bt_ = br_ is ResourceReference bs_ ? bs_.ReferenceElement : null;
                string bu_ = bt_?.Value;
                IEnumerable<string> bv_ = context.Operators.Split(bu_, "/");
                string bw_ = context.Operators.Last<string>(bv_);
                bool? bx_ = context.Operators.Equal(bq_, bw_);
                CodeableConcept by_ = M?.Code;
                CqlConcept bz_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, by_);
                CqlValueSet ca_ = this.Oral_Factor_Xa_Inhibitor_for_VTE_Prophylaxis_or_VTE_Treatment(context);
                bool? cb_ = context.Operators.ConceptInValueSet(bz_, ca_);
                bool? cc_ = context.Operators.And(bx_, cb_);
                return cc_;
            }

            bool? bo_ = context.Operators.WhereAny<Medication>(bm_, bn_);
            return bo_;
        }

        IEnumerable<MedicationAdministration> q_ = context.Operators.Where<MedicationAdministration>(b_, p_);
        IEnumerable<MedicationAdministration> r_ = context.Operators.Union<MedicationAdministration>(q_, f_);
        IEnumerable<ValueTuple<Encounter, Procedure, MedicationAdministration>> s_ = context.Operators.CrossJoin<Encounter, Procedure, MedicationAdministration>(a_, o_, r_);

        (CqlTupleMetadata, Encounter QualifyingEncounter, Procedure AnesthesiaProcedure, MedicationAdministration FactorXaMedication)? t_(ValueTuple<Encounter, Procedure, MedicationAdministration> _valueTuple) {
            (CqlTupleMetadata, Encounter QualifyingEncounter, Procedure AnesthesiaProcedure, MedicationAdministration FactorXaMedication)? cd_ = (CqlTupleMetadata_CdgLdDFHNTDXFGGVTOMXhQZR, _valueTuple.Item1, _valueTuple.Item2, _valueTuple.Item3);
            return cd_;
        }


        bool? u_((CqlTupleMetadata, Encounter QualifyingEncounter, Procedure AnesthesiaProcedure, MedicationAdministration FactorXaMedication)? tuple_dejnabiogwrwyxienqokgepgj) {
            Code<MedicationAdministration.MedicationAdministrationStatusCodes> ce_ = tuple_dejnabiogwrwyxienqokgepgj?.FactorXaMedication?.StatusElement;
            MedicationAdministration.MedicationAdministrationStatusCodes? cf_ = ce_?.Value;
            string cg_ = context.Operators.Convert<string>(cf_);
            bool? ch_ = context.Operators.Equal(cg_, "completed");
            Code<EventStatus> ci_ = tuple_dejnabiogwrwyxienqokgepgj?.AnesthesiaProcedure?.StatusElement;
            EventStatus? cj_ = ci_?.Value;
            string ck_ = context.Operators.Convert<string>(cj_);
            bool? cl_ = context.Operators.Equal(ck_, "completed");
            bool? cm_ = context.Operators.And(ch_, cl_);
            object cn_;
            DataType ea_ = tuple_dejnabiogwrwyxienqokgepgj?.AnesthesiaProcedure?.Performed;
            object eb_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ea_);
            bool ec_ = eb_ is CqlDateTime;
            if (ec_)
            {
                DataType ed_ = tuple_dejnabiogwrwyxienqokgepgj?.AnesthesiaProcedure?.Performed;
                object ee_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ed_);
                cn_ = ee_ as CqlDateTime;
            }
            else
            {
                DataType ef_ = tuple_dejnabiogwrwyxienqokgepgj?.AnesthesiaProcedure?.Performed;
                object eg_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ef_);
                bool eh_ = eg_ is CqlQuantity;
                if (eh_)
                {
                    DataType ei_ = tuple_dejnabiogwrwyxienqokgepgj?.AnesthesiaProcedure?.Performed;
                    object ej_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ei_);
                    cn_ = ej_ as CqlQuantity;
                }
                else
                {
                    DataType ek_ = tuple_dejnabiogwrwyxienqokgepgj?.AnesthesiaProcedure?.Performed;
                    object el_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ek_);
                    bool em_ = el_ is CqlInterval<CqlDateTime>;
                    if (em_)
                    {
                        DataType en_ = tuple_dejnabiogwrwyxienqokgepgj?.AnesthesiaProcedure?.Performed;
                        object eo_ = FHIRHelpers_4_4_000.Instance.ToValue(context, en_);
                        cn_ = eo_ as CqlInterval<CqlDateTime>;
                    }
                    else
                    {
                        DataType ep_ = tuple_dejnabiogwrwyxienqokgepgj?.AnesthesiaProcedure?.Performed;
                        object eq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ep_);
                        bool er_ = eq_ is CqlInterval<CqlQuantity>;
                        if (er_)
                        {
                            DataType es_ = tuple_dejnabiogwrwyxienqokgepgj?.AnesthesiaProcedure?.Performed;
                            object et_ = FHIRHelpers_4_4_000.Instance.ToValue(context, es_);
                            cn_ = et_ as CqlInterval<CqlQuantity>;
                        }
                        else
                        {
                            cn_ = null;
                        }
                    }
                }
            }
            CqlInterval<CqlDateTime> co_ = QICoreCommon_4_0_000.Instance.toInterval(context, cn_);
            CqlDateTime cp_ = context.Operators.End(co_);
            Period cq_ = tuple_dejnabiogwrwyxienqokgepgj?.QualifyingEncounter?.Period;
            CqlInterval<CqlDateTime> cr_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, cq_);
            CqlDateTime cs_ = context.Operators.Start(cr_);
            CqlQuantity ct_ = context.Operators.Quantity(1m, "day");
            CqlDateTime cu_ = context.Operators.Add(cs_, ct_);
            bool? cv_ = context.Operators.SameAs(cp_, cu_, "day");
            bool? cw_ = context.Operators.And(cm_, cv_);
            DataType cx_ = tuple_dejnabiogwrwyxienqokgepgj?.FactorXaMedication?.Effective;
            object cy_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cx_);
            CqlInterval<CqlDateTime> cz_ = QICoreCommon_4_0_000.Instance.toInterval(context, cy_);
            CqlDateTime da_ = context.Operators.Start(cz_);
            object db_;
            DataType eu_ = tuple_dejnabiogwrwyxienqokgepgj?.AnesthesiaProcedure?.Performed;
            object ev_ = FHIRHelpers_4_4_000.Instance.ToValue(context, eu_);
            bool ew_ = ev_ is CqlDateTime;
            if (ew_)
            {
                DataType ex_ = tuple_dejnabiogwrwyxienqokgepgj?.AnesthesiaProcedure?.Performed;
                object ey_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ex_);
                db_ = ey_ as CqlDateTime;
            }
            else
            {
                DataType ez_ = tuple_dejnabiogwrwyxienqokgepgj?.AnesthesiaProcedure?.Performed;
                object fa_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ez_);
                bool fb_ = fa_ is CqlQuantity;
                if (fb_)
                {
                    DataType fc_ = tuple_dejnabiogwrwyxienqokgepgj?.AnesthesiaProcedure?.Performed;
                    object fd_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fc_);
                    db_ = fd_ as CqlQuantity;
                }
                else
                {
                    DataType fe_ = tuple_dejnabiogwrwyxienqokgepgj?.AnesthesiaProcedure?.Performed;
                    object ff_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fe_);
                    bool fg_ = ff_ is CqlInterval<CqlDateTime>;
                    if (fg_)
                    {
                        DataType fh_ = tuple_dejnabiogwrwyxienqokgepgj?.AnesthesiaProcedure?.Performed;
                        object fi_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fh_);
                        db_ = fi_ as CqlInterval<CqlDateTime>;
                    }
                    else
                    {
                        DataType fj_ = tuple_dejnabiogwrwyxienqokgepgj?.AnesthesiaProcedure?.Performed;
                        object fk_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fj_);
                        bool fl_ = fk_ is CqlInterval<CqlQuantity>;
                        if (fl_)
                        {
                            DataType fm_ = tuple_dejnabiogwrwyxienqokgepgj?.AnesthesiaProcedure?.Performed;
                            object fn_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fm_);
                            db_ = fn_ as CqlInterval<CqlQuantity>;
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
            CqlDate df_ = de_?.low;
            CqlDateTime dg_ = context.Operators.ConvertDateToDateTime(df_);
            object dh_;
            DataType fo_ = tuple_dejnabiogwrwyxienqokgepgj?.AnesthesiaProcedure?.Performed;
            object fp_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fo_);
            bool fq_ = fp_ is CqlDateTime;
            if (fq_)
            {
                DataType fr_ = tuple_dejnabiogwrwyxienqokgepgj?.AnesthesiaProcedure?.Performed;
                object fs_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fr_);
                dh_ = fs_ as CqlDateTime;
            }
            else
            {
                DataType ft_ = tuple_dejnabiogwrwyxienqokgepgj?.AnesthesiaProcedure?.Performed;
                object fu_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ft_);
                bool fv_ = fu_ is CqlQuantity;
                if (fv_)
                {
                    DataType fw_ = tuple_dejnabiogwrwyxienqokgepgj?.AnesthesiaProcedure?.Performed;
                    object fx_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fw_);
                    dh_ = fx_ as CqlQuantity;
                }
                else
                {
                    DataType fy_ = tuple_dejnabiogwrwyxienqokgepgj?.AnesthesiaProcedure?.Performed;
                    object fz_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fy_);
                    bool ga_ = fz_ is CqlInterval<CqlDateTime>;
                    if (ga_)
                    {
                        DataType gb_ = tuple_dejnabiogwrwyxienqokgepgj?.AnesthesiaProcedure?.Performed;
                        object gc_ = FHIRHelpers_4_4_000.Instance.ToValue(context, gb_);
                        dh_ = gc_ as CqlInterval<CqlDateTime>;
                    }
                    else
                    {
                        DataType gd_ = tuple_dejnabiogwrwyxienqokgepgj?.AnesthesiaProcedure?.Performed;
                        object ge_ = FHIRHelpers_4_4_000.Instance.ToValue(context, gd_);
                        bool gf_ = ge_ is CqlInterval<CqlQuantity>;
                        if (gf_)
                        {
                            DataType gg_ = tuple_dejnabiogwrwyxienqokgepgj?.AnesthesiaProcedure?.Performed;
                            object gh_ = FHIRHelpers_4_4_000.Instance.ToValue(context, gg_);
                            dh_ = gh_ as CqlInterval<CqlQuantity>;
                        }
                        else
                        {
                            dh_ = null;
                        }
                    }
                }
            }
            CqlInterval<CqlDateTime> di_ = QICoreCommon_4_0_000.Instance.toInterval(context, dh_);
            CqlDateTime dj_ = context.Operators.End(di_);
            CqlInterval<CqlDate> dk_ = TJCOverall_8_25_000.Instance.calendarDayOfOrDayAfter(context, dj_);
            CqlDate dl_ = dk_?.high;
            CqlDateTime dm_ = context.Operators.ConvertDateToDateTime(dl_);
            object dn_;
            DataType gi_ = tuple_dejnabiogwrwyxienqokgepgj?.AnesthesiaProcedure?.Performed;
            object gj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, gi_);
            bool gk_ = gj_ is CqlDateTime;
            if (gk_)
            {
                DataType gl_ = tuple_dejnabiogwrwyxienqokgepgj?.AnesthesiaProcedure?.Performed;
                object gm_ = FHIRHelpers_4_4_000.Instance.ToValue(context, gl_);
                dn_ = gm_ as CqlDateTime;
            }
            else
            {
                DataType gn_ = tuple_dejnabiogwrwyxienqokgepgj?.AnesthesiaProcedure?.Performed;
                object go_ = FHIRHelpers_4_4_000.Instance.ToValue(context, gn_);
                bool gp_ = go_ is CqlQuantity;
                if (gp_)
                {
                    DataType gq_ = tuple_dejnabiogwrwyxienqokgepgj?.AnesthesiaProcedure?.Performed;
                    object gr_ = FHIRHelpers_4_4_000.Instance.ToValue(context, gq_);
                    dn_ = gr_ as CqlQuantity;
                }
                else
                {
                    DataType gs_ = tuple_dejnabiogwrwyxienqokgepgj?.AnesthesiaProcedure?.Performed;
                    object gt_ = FHIRHelpers_4_4_000.Instance.ToValue(context, gs_);
                    bool gu_ = gt_ is CqlInterval<CqlDateTime>;
                    if (gu_)
                    {
                        DataType gv_ = tuple_dejnabiogwrwyxienqokgepgj?.AnesthesiaProcedure?.Performed;
                        object gw_ = FHIRHelpers_4_4_000.Instance.ToValue(context, gv_);
                        dn_ = gw_ as CqlInterval<CqlDateTime>;
                    }
                    else
                    {
                        DataType gx_ = tuple_dejnabiogwrwyxienqokgepgj?.AnesthesiaProcedure?.Performed;
                        object gy_ = FHIRHelpers_4_4_000.Instance.ToValue(context, gx_);
                        bool gz_ = gy_ is CqlInterval<CqlQuantity>;
                        if (gz_)
                        {
                            DataType ha_ = tuple_dejnabiogwrwyxienqokgepgj?.AnesthesiaProcedure?.Performed;
                            object hb_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ha_);
                            dn_ = hb_ as CqlInterval<CqlQuantity>;
                        }
                        else
                        {
                            dn_ = null;
                        }
                    }
                }
            }
            CqlInterval<CqlDateTime> do_ = QICoreCommon_4_0_000.Instance.toInterval(context, dn_);
            CqlDateTime dp_ = context.Operators.End(do_);
            CqlInterval<CqlDate> dq_ = TJCOverall_8_25_000.Instance.calendarDayOfOrDayAfter(context, dp_);
            bool? dr_ = dq_?.lowClosed;
            object ds_;
            DataType hc_ = tuple_dejnabiogwrwyxienqokgepgj?.AnesthesiaProcedure?.Performed;
            object hd_ = FHIRHelpers_4_4_000.Instance.ToValue(context, hc_);
            bool he_ = hd_ is CqlDateTime;
            if (he_)
            {
                DataType hf_ = tuple_dejnabiogwrwyxienqokgepgj?.AnesthesiaProcedure?.Performed;
                object hg_ = FHIRHelpers_4_4_000.Instance.ToValue(context, hf_);
                ds_ = hg_ as CqlDateTime;
            }
            else
            {
                DataType hh_ = tuple_dejnabiogwrwyxienqokgepgj?.AnesthesiaProcedure?.Performed;
                object hi_ = FHIRHelpers_4_4_000.Instance.ToValue(context, hh_);
                bool hj_ = hi_ is CqlQuantity;
                if (hj_)
                {
                    DataType hk_ = tuple_dejnabiogwrwyxienqokgepgj?.AnesthesiaProcedure?.Performed;
                    object hl_ = FHIRHelpers_4_4_000.Instance.ToValue(context, hk_);
                    ds_ = hl_ as CqlQuantity;
                }
                else
                {
                    DataType hm_ = tuple_dejnabiogwrwyxienqokgepgj?.AnesthesiaProcedure?.Performed;
                    object hn_ = FHIRHelpers_4_4_000.Instance.ToValue(context, hm_);
                    bool ho_ = hn_ is CqlInterval<CqlDateTime>;
                    if (ho_)
                    {
                        DataType hp_ = tuple_dejnabiogwrwyxienqokgepgj?.AnesthesiaProcedure?.Performed;
                        object hq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, hp_);
                        ds_ = hq_ as CqlInterval<CqlDateTime>;
                    }
                    else
                    {
                        DataType hr_ = tuple_dejnabiogwrwyxienqokgepgj?.AnesthesiaProcedure?.Performed;
                        object hs_ = FHIRHelpers_4_4_000.Instance.ToValue(context, hr_);
                        bool ht_ = hs_ is CqlInterval<CqlQuantity>;
                        if (ht_)
                        {
                            DataType hu_ = tuple_dejnabiogwrwyxienqokgepgj?.AnesthesiaProcedure?.Performed;
                            object hv_ = FHIRHelpers_4_4_000.Instance.ToValue(context, hu_);
                            ds_ = hv_ as CqlInterval<CqlQuantity>;
                        }
                        else
                        {
                            ds_ = null;
                        }
                    }
                }
            }
            CqlInterval<CqlDateTime> dt_ = QICoreCommon_4_0_000.Instance.toInterval(context, ds_);
            CqlDateTime du_ = context.Operators.End(dt_);
            CqlInterval<CqlDate> dv_ = TJCOverall_8_25_000.Instance.calendarDayOfOrDayAfter(context, du_);
            bool? dw_ = dv_?.highClosed;
            CqlInterval<CqlDateTime> dx_ = context.Operators.Interval(dg_, dm_, dr_, dw_);
            bool? dy_ = context.Operators.In<CqlDateTime>(da_, dx_, "day");
            bool? dz_ = context.Operators.And(cw_, dy_);
            return dz_;
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
                    Period bz_ = QualifyingEncounter?.Period;
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
                Id ck_ = M?.IdElement;
                string cl_ = ck_?.Value;
                DataType cm_ = MR?.Medication;
                FhirString co_ = cm_ is ResourceReference cn_ ? cn_.ReferenceElement : null;
                string cp_ = co_?.Value;
                IEnumerable<string> cq_ = context.Operators.Split(cp_, "/");
                string cr_ = context.Operators.Last<string>(cq_);
                bool? cs_ = context.Operators.Equal(cl_, cr_);
                CodeableConcept ct_ = M?.Code;
                CqlConcept cu_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, ct_);
                CqlValueSet cv_ = this.Unfractionated_Heparin(context);
                bool? cw_ = context.Operators.ConceptInValueSet(cu_, cv_);
                bool? cx_ = context.Operators.And(cs_, cw_);
                return cx_;
            }

            bool? cj_ = context.Operators.WhereAny<Medication>(ch_, ci_);
            return cj_;
        }

        IEnumerable<MedicationAdministration> q_ = context.Operators.Where<MedicationAdministration>(o_, p_);
        CqlValueSet r_ = this.Unfractionated_Heparin(context);
        IEnumerable<MedicationAdministration> s_ = context.Operators.Retrieve<MedicationAdministration>(new RetrieveParameters(default, r_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationadministration"));
        IEnumerable<MedicationAdministration> t_ = context.Operators.Union<MedicationAdministration>(q_, s_);

        bool? u_(MedicationAdministration UnfractionatedHeparin) {
            MedicationAdministration.DosageComponent cy_ = UnfractionatedHeparin?.Dosage;
            CodeableConcept cz_ = cy_?.Route;
            CqlConcept da_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, cz_);
            CqlValueSet db_ = this.Intravenous_route(context);
            bool? dc_ = context.Operators.ConceptInValueSet(da_, db_);
            return dc_;
        }

        IEnumerable<MedicationAdministration> v_ = context.Operators.Where<MedicationAdministration>(t_, u_);

        bool? w_(MedicationAdministration MR) {
            IEnumerable<Medication> dd_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));

            bool? de_(Medication M) {
                Id dg_ = M?.IdElement;
                string dh_ = dg_?.Value;
                DataType di_ = MR?.Medication;
                FhirString dk_ = di_ is ResourceReference dj_ ? dj_.ReferenceElement : null;
                string dl_ = dk_?.Value;
                IEnumerable<string> dm_ = context.Operators.Split(dl_, "/");
                string dn_ = context.Operators.Last<string>(dm_);
                bool? do_ = context.Operators.Equal(dh_, dn_);
                CodeableConcept dp_ = M?.Code;
                CqlConcept dq_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, dp_);
                CqlValueSet dr_ = this.Direct_Thrombin_Inhibitor(context);
                bool? ds_ = context.Operators.ConceptInValueSet(dq_, dr_);
                bool? dt_ = context.Operators.And(do_, ds_);
                return dt_;
            }

            bool? df_ = context.Operators.WhereAny<Medication>(dd_, de_);
            return df_;
        }

        IEnumerable<MedicationAdministration> x_ = context.Operators.Where<MedicationAdministration>(o_, w_);
        CqlValueSet y_ = this.Direct_Thrombin_Inhibitor(context);
        IEnumerable<MedicationAdministration> z_ = context.Operators.Retrieve<MedicationAdministration>(new RetrieveParameters(default, y_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationadministration"));
        IEnumerable<MedicationAdministration> aa_ = context.Operators.Union<MedicationAdministration>(x_, z_);
        IEnumerable<MedicationAdministration> ab_ = context.Operators.Union<MedicationAdministration>(v_, aa_);

        bool? ac_(MedicationAdministration MR) {
            IEnumerable<Medication> du_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));

            bool? dv_(Medication M) {
                Id dx_ = M?.IdElement;
                string dy_ = dx_?.Value;
                DataType dz_ = MR?.Medication;
                FhirString eb_ = dz_ is ResourceReference ea_ ? ea_.ReferenceElement : null;
                string ec_ = eb_?.Value;
                IEnumerable<string> ed_ = context.Operators.Split(ec_, "/");
                string ee_ = context.Operators.Last<string>(ed_);
                bool? ef_ = context.Operators.Equal(dy_, ee_);
                CodeableConcept eg_ = M?.Code;
                CqlConcept eh_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, eg_);
                CqlValueSet ei_ = this.Glycoprotein_IIb_IIIa_Inhibitors(context);
                bool? ej_ = context.Operators.ConceptInValueSet(eh_, ei_);
                bool? ek_ = context.Operators.And(ef_, ej_);
                return ek_;
            }

            bool? dw_ = context.Operators.WhereAny<Medication>(du_, dv_);
            return dw_;
        }

        IEnumerable<MedicationAdministration> ad_ = context.Operators.Where<MedicationAdministration>(o_, ac_);
        CqlValueSet ae_ = this.Glycoprotein_IIb_IIIa_Inhibitors(context);
        IEnumerable<MedicationAdministration> af_ = context.Operators.Retrieve<MedicationAdministration>(new RetrieveParameters(default, ae_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationadministration"));
        IEnumerable<MedicationAdministration> ag_ = context.Operators.Union<MedicationAdministration>(ad_, af_);
        IEnumerable<MedicationAdministration> ah_ = context.Operators.Union<MedicationAdministration>(ab_, ag_);

        bool? ai_(MedicationAdministration AnticoagulantMedication) {
            Code<MedicationAdministration.MedicationAdministrationStatusCodes> el_ = AnticoagulantMedication?.StatusElement;
            MedicationAdministration.MedicationAdministrationStatusCodes? em_ = el_?.Value;
            string en_ = context.Operators.Convert<string>(em_);
            bool? eo_ = context.Operators.Equal(en_, "completed");
            return eo_;
        }


        (CqlTupleMetadata, string id, CqlDateTime LowRiskDatetime)? aj_(MedicationAdministration AnticoagulantMedication) {
            Id ep_ = AnticoagulantMedication?.IdElement;
            string eq_ = ep_?.Value;
            DataType er_ = AnticoagulantMedication?.Effective;
            object es_ = FHIRHelpers_4_4_000.Instance.ToValue(context, er_);
            CqlInterval<CqlDateTime> et_ = QICoreCommon_4_0_000.Instance.toInterval(context, es_);
            CqlDateTime eu_ = context.Operators.Start(et_);
            (CqlTupleMetadata, string id, CqlDateTime LowRiskDatetime)? ev_ = (CqlTupleMetadata_DMAfXNhTfZDWOGdfEceXbfaSJ, eq_, eu_);
            return ev_;
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
                DataType bc_ = tuple_gwhjghwetinfdseedvamgjivv?.AnesthesiaProcedure?.Performed;
                object bd_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bc_);
                p_ = bd_ as CqlDateTime;
            }
            else
            {
                DataType be_ = tuple_gwhjghwetinfdseedvamgjivv?.AnesthesiaProcedure?.Performed;
                object bf_ = FHIRHelpers_4_4_000.Instance.ToValue(context, be_);
                bool bg_ = bf_ is CqlQuantity;
                if (bg_)
                {
                    DataType bh_ = tuple_gwhjghwetinfdseedvamgjivv?.AnesthesiaProcedure?.Performed;
                    object bi_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bh_);
                    p_ = bi_ as CqlQuantity;
                }
                else
                {
                    DataType bj_ = tuple_gwhjghwetinfdseedvamgjivv?.AnesthesiaProcedure?.Performed;
                    object bk_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bj_);
                    bool bl_ = bk_ is CqlInterval<CqlDateTime>;
                    if (bl_)
                    {
                        DataType bm_ = tuple_gwhjghwetinfdseedvamgjivv?.AnesthesiaProcedure?.Performed;
                        object bn_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bm_);
                        p_ = bn_ as CqlInterval<CqlDateTime>;
                    }
                    else
                    {
                        DataType bo_ = tuple_gwhjghwetinfdseedvamgjivv?.AnesthesiaProcedure?.Performed;
                        object bp_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bo_);
                        bool bq_ = bp_ is CqlInterval<CqlQuantity>;
                        if (bq_)
                        {
                            DataType br_ = tuple_gwhjghwetinfdseedvamgjivv?.AnesthesiaProcedure?.Performed;
                            object bs_ = FHIRHelpers_4_4_000.Instance.ToValue(context, br_);
                            p_ = bs_ as CqlInterval<CqlQuantity>;
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
            DataType bt_ = tuple_gwhjghwetinfdseedvamgjivv?.AnesthesiaProcedure?.Performed;
            object bu_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bt_);
            bool bv_ = bu_ is CqlDateTime;
            if (bv_)
            {
                DataType bw_ = tuple_gwhjghwetinfdseedvamgjivv?.AnesthesiaProcedure?.Performed;
                object bx_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bw_);
                aa_ = bx_ as CqlDateTime;
            }
            else
            {
                DataType by_ = tuple_gwhjghwetinfdseedvamgjivv?.AnesthesiaProcedure?.Performed;
                object bz_ = FHIRHelpers_4_4_000.Instance.ToValue(context, by_);
                bool ca_ = bz_ is CqlQuantity;
                if (ca_)
                {
                    DataType cb_ = tuple_gwhjghwetinfdseedvamgjivv?.AnesthesiaProcedure?.Performed;
                    object cc_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cb_);
                    aa_ = cc_ as CqlQuantity;
                }
                else
                {
                    DataType cd_ = tuple_gwhjghwetinfdseedvamgjivv?.AnesthesiaProcedure?.Performed;
                    object ce_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cd_);
                    bool cf_ = ce_ is CqlInterval<CqlDateTime>;
                    if (cf_)
                    {
                        DataType cg_ = tuple_gwhjghwetinfdseedvamgjivv?.AnesthesiaProcedure?.Performed;
                        object ch_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cg_);
                        aa_ = ch_ as CqlInterval<CqlDateTime>;
                    }
                    else
                    {
                        DataType ci_ = tuple_gwhjghwetinfdseedvamgjivv?.AnesthesiaProcedure?.Performed;
                        object cj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ci_);
                        bool ck_ = cj_ is CqlInterval<CqlQuantity>;
                        if (ck_)
                        {
                            DataType cl_ = tuple_gwhjghwetinfdseedvamgjivv?.AnesthesiaProcedure?.Performed;
                            object cm_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cl_);
                            aa_ = cm_ as CqlInterval<CqlQuantity>;
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
            DataType cn_ = tuple_gwhjghwetinfdseedvamgjivv?.AnesthesiaProcedure?.Performed;
            object co_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cn_);
            bool cp_ = co_ is CqlDateTime;
            if (cp_)
            {
                DataType cq_ = tuple_gwhjghwetinfdseedvamgjivv?.AnesthesiaProcedure?.Performed;
                object cr_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cq_);
                ag_ = cr_ as CqlDateTime;
            }
            else
            {
                DataType cs_ = tuple_gwhjghwetinfdseedvamgjivv?.AnesthesiaProcedure?.Performed;
                object ct_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cs_);
                bool cu_ = ct_ is CqlQuantity;
                if (cu_)
                {
                    DataType cv_ = tuple_gwhjghwetinfdseedvamgjivv?.AnesthesiaProcedure?.Performed;
                    object cw_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cv_);
                    ag_ = cw_ as CqlQuantity;
                }
                else
                {
                    DataType cx_ = tuple_gwhjghwetinfdseedvamgjivv?.AnesthesiaProcedure?.Performed;
                    object cy_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cx_);
                    bool cz_ = cy_ is CqlInterval<CqlDateTime>;
                    if (cz_)
                    {
                        DataType da_ = tuple_gwhjghwetinfdseedvamgjivv?.AnesthesiaProcedure?.Performed;
                        object db_ = FHIRHelpers_4_4_000.Instance.ToValue(context, da_);
                        ag_ = db_ as CqlInterval<CqlDateTime>;
                    }
                    else
                    {
                        DataType dc_ = tuple_gwhjghwetinfdseedvamgjivv?.AnesthesiaProcedure?.Performed;
                        object dd_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dc_);
                        bool de_ = dd_ is CqlInterval<CqlQuantity>;
                        if (de_)
                        {
                            DataType df_ = tuple_gwhjghwetinfdseedvamgjivv?.AnesthesiaProcedure?.Performed;
                            object dg_ = FHIRHelpers_4_4_000.Instance.ToValue(context, df_);
                            ag_ = dg_ as CqlInterval<CqlQuantity>;
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
            DataType dh_ = tuple_gwhjghwetinfdseedvamgjivv?.AnesthesiaProcedure?.Performed;
            object di_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dh_);
            bool dj_ = di_ is CqlDateTime;
            if (dj_)
            {
                DataType dk_ = tuple_gwhjghwetinfdseedvamgjivv?.AnesthesiaProcedure?.Performed;
                object dl_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dk_);
                am_ = dl_ as CqlDateTime;
            }
            else
            {
                DataType dm_ = tuple_gwhjghwetinfdseedvamgjivv?.AnesthesiaProcedure?.Performed;
                object dn_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dm_);
                bool do_ = dn_ is CqlQuantity;
                if (do_)
                {
                    DataType dp_ = tuple_gwhjghwetinfdseedvamgjivv?.AnesthesiaProcedure?.Performed;
                    object dq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dp_);
                    am_ = dq_ as CqlQuantity;
                }
                else
                {
                    DataType dr_ = tuple_gwhjghwetinfdseedvamgjivv?.AnesthesiaProcedure?.Performed;
                    object ds_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dr_);
                    bool dt_ = ds_ is CqlInterval<CqlDateTime>;
                    if (dt_)
                    {
                        DataType du_ = tuple_gwhjghwetinfdseedvamgjivv?.AnesthesiaProcedure?.Performed;
                        object dv_ = FHIRHelpers_4_4_000.Instance.ToValue(context, du_);
                        am_ = dv_ as CqlInterval<CqlDateTime>;
                    }
                    else
                    {
                        DataType dw_ = tuple_gwhjghwetinfdseedvamgjivv?.AnesthesiaProcedure?.Performed;
                        object dx_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dw_);
                        bool dy_ = dx_ is CqlInterval<CqlQuantity>;
                        if (dy_)
                        {
                            DataType dz_ = tuple_gwhjghwetinfdseedvamgjivv?.AnesthesiaProcedure?.Performed;
                            object ea_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dz_);
                            am_ = ea_ as CqlInterval<CqlQuantity>;
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
            DataType eb_ = tuple_gwhjghwetinfdseedvamgjivv?.AnesthesiaProcedure?.Performed;
            object ec_ = FHIRHelpers_4_4_000.Instance.ToValue(context, eb_);
            bool ed_ = ec_ is CqlDateTime;
            if (ed_)
            {
                DataType ee_ = tuple_gwhjghwetinfdseedvamgjivv?.AnesthesiaProcedure?.Performed;
                object ef_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ee_);
                ar_ = ef_ as CqlDateTime;
            }
            else
            {
                DataType eg_ = tuple_gwhjghwetinfdseedvamgjivv?.AnesthesiaProcedure?.Performed;
                object eh_ = FHIRHelpers_4_4_000.Instance.ToValue(context, eg_);
                bool ei_ = eh_ is CqlQuantity;
                if (ei_)
                {
                    DataType ej_ = tuple_gwhjghwetinfdseedvamgjivv?.AnesthesiaProcedure?.Performed;
                    object ek_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ej_);
                    ar_ = ek_ as CqlQuantity;
                }
                else
                {
                    DataType el_ = tuple_gwhjghwetinfdseedvamgjivv?.AnesthesiaProcedure?.Performed;
                    object em_ = FHIRHelpers_4_4_000.Instance.ToValue(context, el_);
                    bool en_ = em_ is CqlInterval<CqlDateTime>;
                    if (en_)
                    {
                        DataType eo_ = tuple_gwhjghwetinfdseedvamgjivv?.AnesthesiaProcedure?.Performed;
                        object ep_ = FHIRHelpers_4_4_000.Instance.ToValue(context, eo_);
                        ar_ = ep_ as CqlInterval<CqlDateTime>;
                    }
                    else
                    {
                        DataType eq_ = tuple_gwhjghwetinfdseedvamgjivv?.AnesthesiaProcedure?.Performed;
                        object er_ = FHIRHelpers_4_4_000.Instance.ToValue(context, eq_);
                        bool es_ = er_ is CqlInterval<CqlQuantity>;
                        if (es_)
                        {
                            DataType et_ = tuple_gwhjghwetinfdseedvamgjivv?.AnesthesiaProcedure?.Performed;
                            object eu_ = FHIRHelpers_4_4_000.Instance.ToValue(context, et_);
                            ar_ = eu_ as CqlInterval<CqlQuantity>;
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

        (CqlTupleMetadata, string id, IEnumerable<CqlConcept> medicationStatusReason, CqlDateTime authoredOn)? t_(MedicationAdministration NoMedicationAdm) {
            Id bv_ = NoMedicationAdm?.IdElement;
            string bw_ = bv_?.Value;
            List<CodeableConcept> bx_ = NoMedicationAdm?.StatusReason;

            CqlConcept by_(CodeableConcept @this) {
                CqlConcept cg_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);
                return cg_;
            }

            IEnumerable<CqlConcept> bz_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)bx_, by_);
            List<Extension> ca_ = NoMedicationAdm?.Extension;

            bool? cb_(Extension @this) {
                FhirUri ch_ = @this?.UrlElement;
                string ci_ = FHIRHelpers_4_4_000.Instance.ToString(context, ch_);
                bool? cj_ = context.Operators.Equal(ci_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-recorded");
                return cj_;
            }


            object cc_(Extension @this) {
                DataType ck_ = @this?.Value;
                return ck_ switch
                {
                    Instant cl_ => context.Operators.Convert<CqlDateTime>(cl_.Value),
                    FhirDecimal cm_ => cm_.Value,
                    Date cn_ => context.Operators.ConvertStringToDate(cn_.Value),
                    FhirDateTime co_ => context.Operators.Convert<CqlDateTime>(co_),
                    Time cp_ => context.Operators.ConvertStringToTime(cp_.Value),
                    Base64Binary cq_ => context.Operators.Convert<string>(cq_.Value),
                    FhirBoolean cr_ => cr_.Value,
                    IValue<int?> cs_ => cs_.Value,
                    IValue<string> ct_ => ct_.Value,
                    Quantity cu_ => cu_.ValueElement,
                    Identifier cv_ => cv_.ValueElement,
                    Money cw_ => cw_.ValueElement,
                    UsageContext cx_ => cx_.Value,
                    ContactPoint cy_ => cy_.ValueElement,
                    _ => null,
                };
            }

            IEnumerable<object> cd_ = context.Operators.WhereSelect<Extension, object>((IEnumerable<Extension>)ca_, cb_, cc_);
            object ce_ = context.Operators.SingletonFrom<object>(cd_);
            (CqlTupleMetadata, string id, IEnumerable<CqlConcept> medicationStatusReason, CqlDateTime authoredOn)? cf_ = (CqlTupleMetadata_CNeQfiIHcQEUBjZNVZiOLfdeP, bw_, bz_, (CqlDateTime)ce_);
            return cf_;
        }

        IEnumerable<(CqlTupleMetadata, string id, IEnumerable<CqlConcept> medicationStatusReason, CqlDateTime authoredOn)?> u_ = context.Operators.SelectDistinct<MedicationAdministration, (CqlTupleMetadata, string id, IEnumerable<CqlConcept> medicationStatusReason, CqlDateTime authoredOn)?>(s_, t_);
        IEnumerable<MedicationRequest> v_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationnotrequested"));
        IEnumerable<MedicationRequest> w_ = context.Operators.Union<MedicationRequest>(v_, v_);
        IEnumerable<MedicationRequest> x_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, d_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationnotrequested"));
        IEnumerable<MedicationRequest> y_ = context.Operators.Union<MedicationRequest>(x_, x_);
        IEnumerable<MedicationRequest> z_ = context.Operators.Union<MedicationRequest>(w_, y_);
        IEnumerable<MedicationRequest> aa_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, h_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationnotrequested"));
        IEnumerable<MedicationRequest> ab_ = context.Operators.Union<MedicationRequest>(aa_, aa_);
        IEnumerable<MedicationRequest> ac_ = context.Operators.Union<MedicationRequest>(z_, ab_);
        IEnumerable<MedicationRequest> ad_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, l_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationnotrequested"));
        IEnumerable<MedicationRequest> ae_ = context.Operators.Union<MedicationRequest>(ad_, ad_);
        IEnumerable<MedicationRequest> af_ = context.Operators.Union<MedicationRequest>(ac_, ae_);
        IEnumerable<MedicationRequest> ag_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, p_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationnotrequested"));
        IEnumerable<MedicationRequest> ah_ = context.Operators.Union<MedicationRequest>(ag_, ag_);
        IEnumerable<MedicationRequest> ai_ = context.Operators.Union<MedicationRequest>(af_, ah_);

        bool? aj_(MedicationRequest NoMedicationOrder) {
            Code<MedicationRequest.MedicationRequestIntent> cz_ = NoMedicationOrder?.IntentElement;
            MedicationRequest.MedicationRequestIntent? da_ = cz_?.Value;
            string db_ = context.Operators.Convert<string>(da_);
            string[] dc_ = [
                "order",
                "original-order",
                "reflex-order",
                "filler-order",
                "instance-order",
            ];
            bool? dd_ = context.Operators.In<string>(db_, (IEnumerable<string>)dc_);
            Code<MedicationRequest.MedicationrequestStatus> de_ = NoMedicationOrder?.StatusElement;
            MedicationRequest.MedicationrequestStatus? df_ = de_?.Value;
            string dg_ = context.Operators.Convert<string>(df_);
            string[] dh_ = [
                "active",
                "completed",
            ];
            bool? di_ = context.Operators.In<string>(dg_, (IEnumerable<string>)dh_);
            bool? dj_ = context.Operators.And(dd_, di_);
            return dj_;
        }


        (CqlTupleMetadata, string id, IEnumerable<CqlConcept> medicationStatusReason, CqlDateTime authoredOn)? ak_(MedicationRequest NoMedicationOrder) {
            Id dk_ = NoMedicationOrder?.IdElement;
            string dl_ = dk_?.Value;
            List<CodeableConcept> dm_ = NoMedicationOrder?.ReasonCode;

            CqlConcept dn_(CodeableConcept @this) {
                CqlConcept ds_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);
                return ds_;
            }

            IEnumerable<CqlConcept> do_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)dm_, dn_);
            FhirDateTime dp_ = NoMedicationOrder?.AuthoredOnElement;
            CqlDateTime dq_ = context.Operators.Convert<CqlDateTime>(dp_);
            (CqlTupleMetadata, string id, IEnumerable<CqlConcept> medicationStatusReason, CqlDateTime authoredOn)? dr_ = (CqlTupleMetadata_CNeQfiIHcQEUBjZNVZiOLfdeP, dl_, do_, dq_);
            return dr_;
        }

        IEnumerable<(CqlTupleMetadata, string id, IEnumerable<CqlConcept> medicationStatusReason, CqlDateTime authoredOn)?> al_ = context.Operators.WhereSelect<MedicationRequest, (CqlTupleMetadata, string id, IEnumerable<CqlConcept> medicationStatusReason, CqlDateTime authoredOn)?>(ai_, aj_, ak_);
        IEnumerable<(CqlTupleMetadata, string id, IEnumerable<CqlConcept> medicationStatusReason, CqlDateTime authoredOn)?> am_ = context.Operators.Distinct<(CqlTupleMetadata, string id, IEnumerable<CqlConcept> medicationStatusReason, CqlDateTime authoredOn)?>(al_);
        IEnumerable<(CqlTupleMetadata, string id, IEnumerable<CqlConcept> medicationStatusReason, CqlDateTime authoredOn)?> an_ = context.Operators.Union<(CqlTupleMetadata, string id, IEnumerable<CqlConcept> medicationStatusReason, CqlDateTime authoredOn)?>(u_, am_);
        IEnumerable<MedicationRequest> ao_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));

        bool? ap_(MedicationRequest MR) {
            IEnumerable<Medication> dt_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));

            bool? du_(Medication M) {
                Id dw_ = M?.IdElement;
                string dx_ = dw_?.Value;
                DataType dy_ = MR?.Medication;
                FhirString ea_ = dy_ is ResourceReference dz_ ? dz_.ReferenceElement : null;
                string eb_ = ea_?.Value;
                IEnumerable<string> ec_ = context.Operators.Split(eb_, "/");
                string ed_ = context.Operators.Last<string>(ec_);
                bool? ee_ = context.Operators.Equal(dx_, ed_);
                CodeableConcept ef_ = M?.Code;
                CqlConcept eg_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, ef_);
                CqlValueSet eh_ = this.Low_Dose_Unfractionated_Heparin_for_VTE_Prophylaxis(context);
                bool? ei_ = context.Operators.ConceptInValueSet(eg_, eh_);
                bool? ej_ = context.Operators.And(ee_, ei_);
                return ej_;
            }

            bool? dv_ = context.Operators.WhereAny<Medication>(dt_, du_);
            return dv_;
        }

        IEnumerable<MedicationRequest> aq_ = context.Operators.Where<MedicationRequest>(ao_, ap_);
        IEnumerable<MedicationRequest> ar_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> as_ = context.Operators.Union<MedicationRequest>(aq_, ar_);

        bool? at_(MedicationRequest MR) {
            IEnumerable<Medication> ek_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));

            bool? el_(Medication M) {
                Id en_ = M?.IdElement;
                string eo_ = en_?.Value;
                DataType ep_ = MR?.Medication;
                FhirString er_ = ep_ is ResourceReference eq_ ? eq_.ReferenceElement : null;
                string es_ = er_?.Value;
                IEnumerable<string> et_ = context.Operators.Split(es_, "/");
                string eu_ = context.Operators.Last<string>(et_);
                bool? ev_ = context.Operators.Equal(eo_, eu_);
                CodeableConcept ew_ = M?.Code;
                CqlConcept ex_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, ew_);
                CqlValueSet ey_ = this.Low_Molecular_Weight_Heparin_for_VTE_Prophylaxis(context);
                bool? ez_ = context.Operators.ConceptInValueSet(ex_, ey_);
                bool? fa_ = context.Operators.And(ev_, ez_);
                return fa_;
            }

            bool? em_ = context.Operators.WhereAny<Medication>(ek_, el_);
            return em_;
        }

        IEnumerable<MedicationRequest> au_ = context.Operators.Where<MedicationRequest>(ao_, at_);
        IEnumerable<MedicationRequest> av_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, d_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> aw_ = context.Operators.Union<MedicationRequest>(au_, av_);
        IEnumerable<MedicationRequest> ax_ = context.Operators.Union<MedicationRequest>(as_, aw_);

        bool? ay_(MedicationRequest MR) {
            IEnumerable<Medication> fb_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));

            bool? fc_(Medication M) {
                Id fe_ = M?.IdElement;
                string ff_ = fe_?.Value;
                DataType fg_ = MR?.Medication;
                FhirString fi_ = fg_ is ResourceReference fh_ ? fh_.ReferenceElement : null;
                string fj_ = fi_?.Value;
                IEnumerable<string> fk_ = context.Operators.Split(fj_, "/");
                string fl_ = context.Operators.Last<string>(fk_);
                bool? fm_ = context.Operators.Equal(ff_, fl_);
                CodeableConcept fn_ = M?.Code;
                CqlConcept fo_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, fn_);
                CqlValueSet fp_ = this.Injectable_Factor_Xa_Inhibitor_for_VTE_Prophylaxis(context);
                bool? fq_ = context.Operators.ConceptInValueSet(fo_, fp_);
                bool? fr_ = context.Operators.And(fm_, fq_);
                return fr_;
            }

            bool? fd_ = context.Operators.WhereAny<Medication>(fb_, fc_);
            return fd_;
        }

        IEnumerable<MedicationRequest> az_ = context.Operators.Where<MedicationRequest>(ao_, ay_);
        IEnumerable<MedicationRequest> ba_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, h_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> bb_ = context.Operators.Union<MedicationRequest>(az_, ba_);
        IEnumerable<MedicationRequest> bc_ = context.Operators.Union<MedicationRequest>(ax_, bb_);

        bool? bd_(MedicationRequest MR) {
            IEnumerable<Medication> fs_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));

            bool? ft_(Medication M) {
                Id fv_ = M?.IdElement;
                string fw_ = fv_?.Value;
                DataType fx_ = MR?.Medication;
                FhirString fz_ = fx_ is ResourceReference fy_ ? fy_.ReferenceElement : null;
                string ga_ = fz_?.Value;
                IEnumerable<string> gb_ = context.Operators.Split(ga_, "/");
                string gc_ = context.Operators.Last<string>(gb_);
                bool? gd_ = context.Operators.Equal(fw_, gc_);
                CodeableConcept ge_ = M?.Code;
                CqlConcept gf_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, ge_);
                CqlValueSet gg_ = this.Warfarin(context);
                bool? gh_ = context.Operators.ConceptInValueSet(gf_, gg_);
                bool? gi_ = context.Operators.And(gd_, gh_);
                return gi_;
            }

            bool? fu_ = context.Operators.WhereAny<Medication>(fs_, ft_);
            return fu_;
        }

        IEnumerable<MedicationRequest> be_ = context.Operators.Where<MedicationRequest>(ao_, bd_);
        IEnumerable<MedicationRequest> bf_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, l_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> bg_ = context.Operators.Union<MedicationRequest>(be_, bf_);
        IEnumerable<MedicationRequest> bh_ = context.Operators.Union<MedicationRequest>(bc_, bg_);

        bool? bi_(MedicationRequest MR) {
            IEnumerable<Medication> gj_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));

            bool? gk_(Medication M) {
                Id gm_ = M?.IdElement;
                string gn_ = gm_?.Value;
                DataType go_ = MR?.Medication;
                FhirString gq_ = go_ is ResourceReference gp_ ? gp_.ReferenceElement : null;
                string gr_ = gq_?.Value;
                IEnumerable<string> gs_ = context.Operators.Split(gr_, "/");
                string gt_ = context.Operators.Last<string>(gs_);
                bool? gu_ = context.Operators.Equal(gn_, gt_);
                CodeableConcept gv_ = M?.Code;
                CqlConcept gw_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, gv_);
                CqlValueSet gx_ = this.Rivaroxaban_for_VTE_Prophylaxis(context);
                bool? gy_ = context.Operators.ConceptInValueSet(gw_, gx_);
                bool? gz_ = context.Operators.And(gu_, gy_);
                return gz_;
            }

            bool? gl_ = context.Operators.WhereAny<Medication>(gj_, gk_);
            return gl_;
        }

        IEnumerable<MedicationRequest> bj_ = context.Operators.Where<MedicationRequest>(ao_, bi_);
        IEnumerable<MedicationRequest> bk_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, p_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> bl_ = context.Operators.Union<MedicationRequest>(bj_, bk_);
        IEnumerable<MedicationRequest> bm_ = context.Operators.Union<MedicationRequest>(bh_, bl_);
        IEnumerable<Task> bn_ = context.Operators.Retrieve<Task>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-taskrejected"));
        IEnumerable<ValueTuple<MedicationRequest, Task>> bo_ = context.Operators.CrossJoin<MedicationRequest, Task>(bm_, bn_);

        (CqlTupleMetadata, MedicationRequest MedicationOrderReject, Task T)? bp_(ValueTuple<MedicationRequest, Task> _valueTuple) {
            (CqlTupleMetadata, MedicationRequest MedicationOrderReject, Task T)? ha_ = (CqlTupleMetadata_IIUQMBcJhJBPgdDOLHaTTRUE, _valueTuple.Item1, _valueTuple.Item2);
            return ha_;
        }


        bool? bq_((CqlTupleMetadata, MedicationRequest MedicationOrderReject, Task T)? tuple_iiuqmbcjhjbpgddolhattrue) {
            ResourceReference hb_ = tuple_iiuqmbcjhjbpgddolhattrue?.T?.Focus;
            bool? hc_ = QICoreCommon_4_0_000.Instance.references(context, hb_, tuple_iiuqmbcjhjbpgddolhattrue?.MedicationOrderReject);
            CodeableConcept hd_ = tuple_iiuqmbcjhjbpgddolhattrue?.T?.Code;
            CqlConcept he_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, hd_);
            CqlCode hf_ = QICoreCommon_4_0_000.Instance.Fulfill(context);
            CqlConcept hg_ = context.Operators.ConvertCodeToConcept(hf_);
            bool? hh_ = context.Operators.Equivalent(he_, hg_);
            bool? hi_ = context.Operators.And(hc_, hh_);
            Code<MedicationRequest.MedicationrequestStatus> hj_ = tuple_iiuqmbcjhjbpgddolhattrue?.MedicationOrderReject?.StatusElement;
            MedicationRequest.MedicationrequestStatus? hk_ = hj_?.Value;
            string hl_ = context.Operators.Convert<string>(hk_);
            bool? hm_ = context.Operators.Equal(hl_, "active");
            bool? hn_ = context.Operators.And(hi_, hm_);
            return hn_;
        }

        IEnumerable<(CqlTupleMetadata, MedicationRequest MedicationOrderReject, Task T)?> br_ = context.Operators.SelectWhere<ValueTuple<MedicationRequest, Task>, (CqlTupleMetadata, MedicationRequest MedicationOrderReject, Task T)?>(bo_, bp_, bq_);

        (CqlTupleMetadata, string id, IEnumerable<CqlConcept> medicationStatusReason, CqlDateTime authoredOn)? bs_((CqlTupleMetadata, MedicationRequest MedicationOrderReject, Task T)? tuple_iiuqmbcjhjbpgddolhattrue) {
            Id ho_ = tuple_iiuqmbcjhjbpgddolhattrue?.MedicationOrderReject?.IdElement;
            string hp_ = ho_?.Value;
            CodeableConcept hq_ = tuple_iiuqmbcjhjbpgddolhattrue?.T?.StatusReason;
            CqlConcept hr_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, hq_);
            CqlConcept[] hs_ = [
                hr_,
            ];
            FhirDateTime ht_ = tuple_iiuqmbcjhjbpgddolhattrue?.MedicationOrderReject?.AuthoredOnElement;
            CqlDateTime hu_ = context.Operators.Convert<CqlDateTime>(ht_);
            (CqlTupleMetadata, string id, IEnumerable<CqlConcept> medicationStatusReason, CqlDateTime authoredOn)? hv_ = (CqlTupleMetadata_CNeQfiIHcQEUBjZNVZiOLfdeP, hp_, (IEnumerable<CqlConcept>)hs_, hu_);
            return hv_;
        }

        IEnumerable<(CqlTupleMetadata, string id, IEnumerable<CqlConcept> medicationStatusReason, CqlDateTime authoredOn)?> bt_ = context.Operators.SelectDistinct<(CqlTupleMetadata, MedicationRequest MedicationOrderReject, Task T)?, (CqlTupleMetadata, string id, IEnumerable<CqlConcept> medicationStatusReason, CqlDateTime authoredOn)?>(br_, bs_);
        IEnumerable<(CqlTupleMetadata, string id, IEnumerable<CqlConcept> medicationStatusReason, CqlDateTime authoredOn)?> bu_ = context.Operators.Union<(CqlTupleMetadata, string id, IEnumerable<CqlConcept> medicationStatusReason, CqlDateTime authoredOn)?>(an_, bt_);
        return bu_;
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
            Code<RequestIntent> as_ = DeviceNotOrder?.IntentElement;
            RequestIntent? at_ = as_?.Value;
            Code<RequestIntent> au_ = context.Operators.Convert<Code<RequestIntent>>(at_);
            string av_ = context.Operators.Convert<string>(au_);
            string[] aw_ = [
                "order",
                "original-order",
                "reflex-order",
                "filler-order",
                "instance-order",
            ];
            bool? ax_ = context.Operators.In<string>(av_, (IEnumerable<string>)aw_);
            return ax_;
        }


        (CqlTupleMetadata, string id, CodeableConcept requestStatusReason, CqlDateTime authoredOn)? m_(ServiceRequest DeviceNotOrder) {
            Id ay_ = DeviceNotOrder?.IdElement;
            string az_ = ay_?.Value;
            List<Extension> ba_ = DeviceNotOrder?.Extension;

            bool? bb_(Extension @this) {
                FhirUri bk_ = @this?.UrlElement;
                string bl_ = FHIRHelpers_4_4_000.Instance.ToString(context, bk_);
                bool? bm_ = context.Operators.Equal(bl_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-doNotPerformReason");
                return bm_;
            }


            object bc_(Extension @this) {
                DataType bn_ = @this?.Value;
                return bn_;
            }

            IEnumerable<object> bd_ = context.Operators.WhereSelect<Extension, object>((IEnumerable<Extension>)ba_, bb_, bc_);
            object be_ = context.Operators.SingletonFrom<object>(bd_);
            CqlConcept bf_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, be_ as CodeableConcept);
            CodeableConcept bg_ = context.Operators.Convert<CodeableConcept>(bf_);
            FhirDateTime bh_ = DeviceNotOrder?.AuthoredOnElement;
            CqlDateTime bi_ = context.Operators.Convert<CqlDateTime>(bh_);
            (CqlTupleMetadata, string id, CodeableConcept requestStatusReason, CqlDateTime authoredOn)? bj_ = (CqlTupleMetadata_FVDRPQjOQgYIDhWKHCNhOHceF, az_, bg_, bi_);
            return bj_;
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
                CqlConcept bo_ = context.Operators.Convert<CqlConcept>(tuple_gnbatbigxtpdibanunzcndfbr?.requestStatusReason);
                (CqlTupleMetadata, string id, CqlConcept requestStatusReason, CqlDateTime authoredOn)? bp_ = (CqlTupleMetadata_DheTAGNHbFgKVJGaRbPLJVjKH, tuple_gnbatbigxtpdibanunzcndfbr?.id, bo_, tuple_gnbatbigxtpdibanunzcndfbr?.authoredOn);
                return bp_;
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
            (CqlTupleMetadata, ServiceRequest DeviceOrderReject, Task T)? bq_ = (CqlTupleMetadata_YYIDPXBNjhOGFRJKYRBMGChb, _valueTuple.Item1, _valueTuple.Item2);
            return bq_;
        }


        bool? z_((CqlTupleMetadata, ServiceRequest DeviceOrderReject, Task T)? tuple_yyidpxbnjhogfrjkyrbmgchb) {
            Code<RequestIntent> br_ = tuple_yyidpxbnjhogfrjkyrbmgchb?.DeviceOrderReject?.IntentElement;
            RequestIntent? bs_ = br_?.Value;
            Code<RequestIntent> bt_ = context.Operators.Convert<Code<RequestIntent>>(bs_);
            string bu_ = context.Operators.Convert<string>(bt_);
            string[] bv_ = [
                "order",
                "original-order",
                "reflex-order",
                "filler-order",
                "instance-order",
            ];
            bool? bw_ = context.Operators.In<string>(bu_, (IEnumerable<string>)bv_);
            Code<RequestStatus> bx_ = tuple_yyidpxbnjhogfrjkyrbmgchb?.DeviceOrderReject?.StatusElement;
            RequestStatus? by_ = bx_?.Value;
            Code<RequestStatus> bz_ = context.Operators.Convert<Code<RequestStatus>>(by_);
            bool? ca_ = context.Operators.Equal(bz_, "active");
            bool? cb_ = context.Operators.And(bw_, ca_);
            ResourceReference cc_ = tuple_yyidpxbnjhogfrjkyrbmgchb?.T?.Focus;
            bool? cd_ = QICoreCommon_4_0_000.Instance.references(context, cc_, tuple_yyidpxbnjhogfrjkyrbmgchb?.DeviceOrderReject);
            bool? ce_ = context.Operators.And(cb_, cd_);
            CodeableConcept cf_ = tuple_yyidpxbnjhogfrjkyrbmgchb?.T?.Code;
            CqlConcept cg_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, cf_);
            CqlCode ch_ = QICoreCommon_4_0_000.Instance.Fulfill(context);
            CqlConcept ci_ = context.Operators.ConvertCodeToConcept(ch_);
            bool? cj_ = context.Operators.Equivalent(cg_, ci_);
            bool? ck_ = context.Operators.And(ce_, cj_);
            return ck_;
        }

        IEnumerable<(CqlTupleMetadata, ServiceRequest DeviceOrderReject, Task T)?> aa_ = context.Operators.SelectWhere<ValueTuple<ServiceRequest, Task>, (CqlTupleMetadata, ServiceRequest DeviceOrderReject, Task T)?>(x_, y_, z_);

        (CqlTupleMetadata, string id, CqlConcept requestStatusReason, CqlDateTime authoredOn)? ab_((CqlTupleMetadata, ServiceRequest DeviceOrderReject, Task T)? tuple_yyidpxbnjhogfrjkyrbmgchb) {
            Id cl_ = tuple_yyidpxbnjhogfrjkyrbmgchb?.DeviceOrderReject?.IdElement;
            string cm_ = cl_?.Value;
            CodeableConcept cn_ = tuple_yyidpxbnjhogfrjkyrbmgchb?.T?.StatusReason;
            CqlConcept co_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, cn_);
            FhirDateTime cp_ = tuple_yyidpxbnjhogfrjkyrbmgchb?.DeviceOrderReject?.AuthoredOnElement;
            CqlDateTime cq_ = context.Operators.Convert<CqlDateTime>(cp_);
            (CqlTupleMetadata, string id, CqlConcept requestStatusReason, CqlDateTime authoredOn)? cr_ = (CqlTupleMetadata_DheTAGNHbFgKVJGaRbPLJVjKH, cm_, co_, cq_);
            return cr_;
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

        (CqlTupleMetadata, string id, CqlConcept requestStatusReason, CqlDateTime authoredOn)? ap_(Procedure DeviceNotApplied) {
            Id cs_ = DeviceNotApplied?.IdElement;
            string ct_ = cs_?.Value;
            CodeableConcept cu_ = DeviceNotApplied?.StatusReason;
            CqlConcept cv_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, cu_);
            List<Extension> cw_ = DeviceNotApplied?.Extension;

            bool? cx_(Extension @this) {
                FhirUri dc_ = @this?.UrlElement;
                string dd_ = FHIRHelpers_4_4_000.Instance.ToString(context, dc_);
                bool? de_ = context.Operators.Equal(dd_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-recorded");
                return de_;
            }


            object cy_(Extension @this) {
                DataType df_ = @this?.Value;
                return df_ switch
                {
                    Instant dg_ => context.Operators.Convert<CqlDateTime>(dg_.Value),
                    FhirDecimal dh_ => dh_.Value,
                    Date di_ => context.Operators.ConvertStringToDate(di_.Value),
                    FhirDateTime dj_ => context.Operators.Convert<CqlDateTime>(dj_),
                    Time dk_ => context.Operators.ConvertStringToTime(dk_.Value),
                    Base64Binary dl_ => context.Operators.Convert<string>(dl_.Value),
                    FhirBoolean dm_ => dm_.Value,
                    IValue<int?> dn_ => dn_.Value,
                    IValue<string> do_ => do_.Value,
                    Quantity dp_ => dp_.ValueElement,
                    Identifier dq_ => dq_.ValueElement,
                    Money dr_ => dr_.ValueElement,
                    UsageContext ds_ => ds_.Value,
                    ContactPoint dt_ => dt_.ValueElement,
                    _ => null,
                };
            }

            IEnumerable<object> cz_ = context.Operators.WhereSelect<Extension, object>((IEnumerable<Extension>)cw_, cx_, cy_);
            object da_ = context.Operators.SingletonFrom<object>(cz_);
            (CqlTupleMetadata, string id, CqlConcept requestStatusReason, CqlDateTime authoredOn)? db_ = (CqlTupleMetadata_DheTAGNHbFgKVJGaRbPLJVjKH, ct_, cv_, (CqlDateTime)da_);
            return db_;
        }

        IEnumerable<(CqlTupleMetadata, string id, CqlConcept requestStatusReason, CqlDateTime authoredOn)?> aq_ = context.Operators.SelectDistinct<Procedure, (CqlTupleMetadata, string id, CqlConcept requestStatusReason, CqlDateTime authoredOn)?>(ao_, ap_);
        IEnumerable<(CqlTupleMetadata, string id, CqlConcept requestStatusReason, CqlDateTime authoredOn)?> ar_ = context.Operators.Union<(CqlTupleMetadata, string id, CqlConcept requestStatusReason, CqlDateTime authoredOn)?>(ad_, aq_);
        return ar_;
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
                DataType bg_ = tuple_chjebychscdthhbpzggacmwxe?.AnesthesiaProcedure?.Performed;
                object bh_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bg_);
                t_ = bh_ as CqlDateTime;
            }
            else
            {
                DataType bi_ = tuple_chjebychscdthhbpzggacmwxe?.AnesthesiaProcedure?.Performed;
                object bj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bi_);
                bool bk_ = bj_ is CqlQuantity;
                if (bk_)
                {
                    DataType bl_ = tuple_chjebychscdthhbpzggacmwxe?.AnesthesiaProcedure?.Performed;
                    object bm_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bl_);
                    t_ = bm_ as CqlQuantity;
                }
                else
                {
                    DataType bn_ = tuple_chjebychscdthhbpzggacmwxe?.AnesthesiaProcedure?.Performed;
                    object bo_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bn_);
                    bool bp_ = bo_ is CqlInterval<CqlDateTime>;
                    if (bp_)
                    {
                        DataType bq_ = tuple_chjebychscdthhbpzggacmwxe?.AnesthesiaProcedure?.Performed;
                        object br_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bq_);
                        t_ = br_ as CqlInterval<CqlDateTime>;
                    }
                    else
                    {
                        DataType bs_ = tuple_chjebychscdthhbpzggacmwxe?.AnesthesiaProcedure?.Performed;
                        object bt_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bs_);
                        bool bu_ = bt_ is CqlInterval<CqlQuantity>;
                        if (bu_)
                        {
                            DataType bv_ = tuple_chjebychscdthhbpzggacmwxe?.AnesthesiaProcedure?.Performed;
                            object bw_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bv_);
                            t_ = bw_ as CqlInterval<CqlQuantity>;
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
            DataType bx_ = tuple_chjebychscdthhbpzggacmwxe?.AnesthesiaProcedure?.Performed;
            object by_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bx_);
            bool bz_ = by_ is CqlDateTime;
            if (bz_)
            {
                DataType ca_ = tuple_chjebychscdthhbpzggacmwxe?.AnesthesiaProcedure?.Performed;
                object cb_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ca_);
                ae_ = cb_ as CqlDateTime;
            }
            else
            {
                DataType cc_ = tuple_chjebychscdthhbpzggacmwxe?.AnesthesiaProcedure?.Performed;
                object cd_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cc_);
                bool ce_ = cd_ is CqlQuantity;
                if (ce_)
                {
                    DataType cf_ = tuple_chjebychscdthhbpzggacmwxe?.AnesthesiaProcedure?.Performed;
                    object cg_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cf_);
                    ae_ = cg_ as CqlQuantity;
                }
                else
                {
                    DataType ch_ = tuple_chjebychscdthhbpzggacmwxe?.AnesthesiaProcedure?.Performed;
                    object ci_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ch_);
                    bool cj_ = ci_ is CqlInterval<CqlDateTime>;
                    if (cj_)
                    {
                        DataType ck_ = tuple_chjebychscdthhbpzggacmwxe?.AnesthesiaProcedure?.Performed;
                        object cl_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ck_);
                        ae_ = cl_ as CqlInterval<CqlDateTime>;
                    }
                    else
                    {
                        DataType cm_ = tuple_chjebychscdthhbpzggacmwxe?.AnesthesiaProcedure?.Performed;
                        object cn_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cm_);
                        bool co_ = cn_ is CqlInterval<CqlQuantity>;
                        if (co_)
                        {
                            DataType cp_ = tuple_chjebychscdthhbpzggacmwxe?.AnesthesiaProcedure?.Performed;
                            object cq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cp_);
                            ae_ = cq_ as CqlInterval<CqlQuantity>;
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
            DataType cr_ = tuple_chjebychscdthhbpzggacmwxe?.AnesthesiaProcedure?.Performed;
            object cs_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cr_);
            bool ct_ = cs_ is CqlDateTime;
            if (ct_)
            {
                DataType cu_ = tuple_chjebychscdthhbpzggacmwxe?.AnesthesiaProcedure?.Performed;
                object cv_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cu_);
                ak_ = cv_ as CqlDateTime;
            }
            else
            {
                DataType cw_ = tuple_chjebychscdthhbpzggacmwxe?.AnesthesiaProcedure?.Performed;
                object cx_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cw_);
                bool cy_ = cx_ is CqlQuantity;
                if (cy_)
                {
                    DataType cz_ = tuple_chjebychscdthhbpzggacmwxe?.AnesthesiaProcedure?.Performed;
                    object da_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cz_);
                    ak_ = da_ as CqlQuantity;
                }
                else
                {
                    DataType db_ = tuple_chjebychscdthhbpzggacmwxe?.AnesthesiaProcedure?.Performed;
                    object dc_ = FHIRHelpers_4_4_000.Instance.ToValue(context, db_);
                    bool dd_ = dc_ is CqlInterval<CqlDateTime>;
                    if (dd_)
                    {
                        DataType de_ = tuple_chjebychscdthhbpzggacmwxe?.AnesthesiaProcedure?.Performed;
                        object df_ = FHIRHelpers_4_4_000.Instance.ToValue(context, de_);
                        ak_ = df_ as CqlInterval<CqlDateTime>;
                    }
                    else
                    {
                        DataType dg_ = tuple_chjebychscdthhbpzggacmwxe?.AnesthesiaProcedure?.Performed;
                        object dh_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dg_);
                        bool di_ = dh_ is CqlInterval<CqlQuantity>;
                        if (di_)
                        {
                            DataType dj_ = tuple_chjebychscdthhbpzggacmwxe?.AnesthesiaProcedure?.Performed;
                            object dk_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dj_);
                            ak_ = dk_ as CqlInterval<CqlQuantity>;
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
            DataType dl_ = tuple_chjebychscdthhbpzggacmwxe?.AnesthesiaProcedure?.Performed;
            object dm_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dl_);
            bool dn_ = dm_ is CqlDateTime;
            if (dn_)
            {
                DataType do_ = tuple_chjebychscdthhbpzggacmwxe?.AnesthesiaProcedure?.Performed;
                object dp_ = FHIRHelpers_4_4_000.Instance.ToValue(context, do_);
                aq_ = dp_ as CqlDateTime;
            }
            else
            {
                DataType dq_ = tuple_chjebychscdthhbpzggacmwxe?.AnesthesiaProcedure?.Performed;
                object dr_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dq_);
                bool ds_ = dr_ is CqlQuantity;
                if (ds_)
                {
                    DataType dt_ = tuple_chjebychscdthhbpzggacmwxe?.AnesthesiaProcedure?.Performed;
                    object du_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dt_);
                    aq_ = du_ as CqlQuantity;
                }
                else
                {
                    DataType dv_ = tuple_chjebychscdthhbpzggacmwxe?.AnesthesiaProcedure?.Performed;
                    object dw_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dv_);
                    bool dx_ = dw_ is CqlInterval<CqlDateTime>;
                    if (dx_)
                    {
                        DataType dy_ = tuple_chjebychscdthhbpzggacmwxe?.AnesthesiaProcedure?.Performed;
                        object dz_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dy_);
                        aq_ = dz_ as CqlInterval<CqlDateTime>;
                    }
                    else
                    {
                        DataType ea_ = tuple_chjebychscdthhbpzggacmwxe?.AnesthesiaProcedure?.Performed;
                        object eb_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ea_);
                        bool ec_ = eb_ is CqlInterval<CqlQuantity>;
                        if (ec_)
                        {
                            DataType ed_ = tuple_chjebychscdthhbpzggacmwxe?.AnesthesiaProcedure?.Performed;
                            object ee_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ed_);
                            aq_ = ee_ as CqlInterval<CqlQuantity>;
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
            DataType ef_ = tuple_chjebychscdthhbpzggacmwxe?.AnesthesiaProcedure?.Performed;
            object eg_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ef_);
            bool eh_ = eg_ is CqlDateTime;
            if (eh_)
            {
                DataType ei_ = tuple_chjebychscdthhbpzggacmwxe?.AnesthesiaProcedure?.Performed;
                object ej_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ei_);
                av_ = ej_ as CqlDateTime;
            }
            else
            {
                DataType ek_ = tuple_chjebychscdthhbpzggacmwxe?.AnesthesiaProcedure?.Performed;
                object el_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ek_);
                bool em_ = el_ is CqlQuantity;
                if (em_)
                {
                    DataType en_ = tuple_chjebychscdthhbpzggacmwxe?.AnesthesiaProcedure?.Performed;
                    object eo_ = FHIRHelpers_4_4_000.Instance.ToValue(context, en_);
                    av_ = eo_ as CqlQuantity;
                }
                else
                {
                    DataType ep_ = tuple_chjebychscdthhbpzggacmwxe?.AnesthesiaProcedure?.Performed;
                    object eq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ep_);
                    bool er_ = eq_ is CqlInterval<CqlDateTime>;
                    if (er_)
                    {
                        DataType es_ = tuple_chjebychscdthhbpzggacmwxe?.AnesthesiaProcedure?.Performed;
                        object et_ = FHIRHelpers_4_4_000.Instance.ToValue(context, es_);
                        av_ = et_ as CqlInterval<CqlDateTime>;
                    }
                    else
                    {
                        DataType eu_ = tuple_chjebychscdthhbpzggacmwxe?.AnesthesiaProcedure?.Performed;
                        object ev_ = FHIRHelpers_4_4_000.Instance.ToValue(context, eu_);
                        bool ew_ = ev_ is CqlInterval<CqlQuantity>;
                        if (ew_)
                        {
                            DataType ex_ = tuple_chjebychscdthhbpzggacmwxe?.AnesthesiaProcedure?.Performed;
                            object ey_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ex_);
                            av_ = ey_ as CqlInterval<CqlQuantity>;
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
                DataType bg_ = tuple_cadhcldckpqwmtcazwxfnkhgc?.AnesthesiaProcedure?.Performed;
                object bh_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bg_);
                t_ = bh_ as CqlDateTime;
            }
            else
            {
                DataType bi_ = tuple_cadhcldckpqwmtcazwxfnkhgc?.AnesthesiaProcedure?.Performed;
                object bj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bi_);
                bool bk_ = bj_ is CqlQuantity;
                if (bk_)
                {
                    DataType bl_ = tuple_cadhcldckpqwmtcazwxfnkhgc?.AnesthesiaProcedure?.Performed;
                    object bm_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bl_);
                    t_ = bm_ as CqlQuantity;
                }
                else
                {
                    DataType bn_ = tuple_cadhcldckpqwmtcazwxfnkhgc?.AnesthesiaProcedure?.Performed;
                    object bo_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bn_);
                    bool bp_ = bo_ is CqlInterval<CqlDateTime>;
                    if (bp_)
                    {
                        DataType bq_ = tuple_cadhcldckpqwmtcazwxfnkhgc?.AnesthesiaProcedure?.Performed;
                        object br_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bq_);
                        t_ = br_ as CqlInterval<CqlDateTime>;
                    }
                    else
                    {
                        DataType bs_ = tuple_cadhcldckpqwmtcazwxfnkhgc?.AnesthesiaProcedure?.Performed;
                        object bt_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bs_);
                        bool bu_ = bt_ is CqlInterval<CqlQuantity>;
                        if (bu_)
                        {
                            DataType bv_ = tuple_cadhcldckpqwmtcazwxfnkhgc?.AnesthesiaProcedure?.Performed;
                            object bw_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bv_);
                            t_ = bw_ as CqlInterval<CqlQuantity>;
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
            DataType bx_ = tuple_cadhcldckpqwmtcazwxfnkhgc?.AnesthesiaProcedure?.Performed;
            object by_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bx_);
            bool bz_ = by_ is CqlDateTime;
            if (bz_)
            {
                DataType ca_ = tuple_cadhcldckpqwmtcazwxfnkhgc?.AnesthesiaProcedure?.Performed;
                object cb_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ca_);
                ae_ = cb_ as CqlDateTime;
            }
            else
            {
                DataType cc_ = tuple_cadhcldckpqwmtcazwxfnkhgc?.AnesthesiaProcedure?.Performed;
                object cd_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cc_);
                bool ce_ = cd_ is CqlQuantity;
                if (ce_)
                {
                    DataType cf_ = tuple_cadhcldckpqwmtcazwxfnkhgc?.AnesthesiaProcedure?.Performed;
                    object cg_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cf_);
                    ae_ = cg_ as CqlQuantity;
                }
                else
                {
                    DataType ch_ = tuple_cadhcldckpqwmtcazwxfnkhgc?.AnesthesiaProcedure?.Performed;
                    object ci_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ch_);
                    bool cj_ = ci_ is CqlInterval<CqlDateTime>;
                    if (cj_)
                    {
                        DataType ck_ = tuple_cadhcldckpqwmtcazwxfnkhgc?.AnesthesiaProcedure?.Performed;
                        object cl_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ck_);
                        ae_ = cl_ as CqlInterval<CqlDateTime>;
                    }
                    else
                    {
                        DataType cm_ = tuple_cadhcldckpqwmtcazwxfnkhgc?.AnesthesiaProcedure?.Performed;
                        object cn_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cm_);
                        bool co_ = cn_ is CqlInterval<CqlQuantity>;
                        if (co_)
                        {
                            DataType cp_ = tuple_cadhcldckpqwmtcazwxfnkhgc?.AnesthesiaProcedure?.Performed;
                            object cq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cp_);
                            ae_ = cq_ as CqlInterval<CqlQuantity>;
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
            DataType cr_ = tuple_cadhcldckpqwmtcazwxfnkhgc?.AnesthesiaProcedure?.Performed;
            object cs_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cr_);
            bool ct_ = cs_ is CqlDateTime;
            if (ct_)
            {
                DataType cu_ = tuple_cadhcldckpqwmtcazwxfnkhgc?.AnesthesiaProcedure?.Performed;
                object cv_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cu_);
                ak_ = cv_ as CqlDateTime;
            }
            else
            {
                DataType cw_ = tuple_cadhcldckpqwmtcazwxfnkhgc?.AnesthesiaProcedure?.Performed;
                object cx_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cw_);
                bool cy_ = cx_ is CqlQuantity;
                if (cy_)
                {
                    DataType cz_ = tuple_cadhcldckpqwmtcazwxfnkhgc?.AnesthesiaProcedure?.Performed;
                    object da_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cz_);
                    ak_ = da_ as CqlQuantity;
                }
                else
                {
                    DataType db_ = tuple_cadhcldckpqwmtcazwxfnkhgc?.AnesthesiaProcedure?.Performed;
                    object dc_ = FHIRHelpers_4_4_000.Instance.ToValue(context, db_);
                    bool dd_ = dc_ is CqlInterval<CqlDateTime>;
                    if (dd_)
                    {
                        DataType de_ = tuple_cadhcldckpqwmtcazwxfnkhgc?.AnesthesiaProcedure?.Performed;
                        object df_ = FHIRHelpers_4_4_000.Instance.ToValue(context, de_);
                        ak_ = df_ as CqlInterval<CqlDateTime>;
                    }
                    else
                    {
                        DataType dg_ = tuple_cadhcldckpqwmtcazwxfnkhgc?.AnesthesiaProcedure?.Performed;
                        object dh_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dg_);
                        bool di_ = dh_ is CqlInterval<CqlQuantity>;
                        if (di_)
                        {
                            DataType dj_ = tuple_cadhcldckpqwmtcazwxfnkhgc?.AnesthesiaProcedure?.Performed;
                            object dk_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dj_);
                            ak_ = dk_ as CqlInterval<CqlQuantity>;
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
            DataType dl_ = tuple_cadhcldckpqwmtcazwxfnkhgc?.AnesthesiaProcedure?.Performed;
            object dm_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dl_);
            bool dn_ = dm_ is CqlDateTime;
            if (dn_)
            {
                DataType do_ = tuple_cadhcldckpqwmtcazwxfnkhgc?.AnesthesiaProcedure?.Performed;
                object dp_ = FHIRHelpers_4_4_000.Instance.ToValue(context, do_);
                aq_ = dp_ as CqlDateTime;
            }
            else
            {
                DataType dq_ = tuple_cadhcldckpqwmtcazwxfnkhgc?.AnesthesiaProcedure?.Performed;
                object dr_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dq_);
                bool ds_ = dr_ is CqlQuantity;
                if (ds_)
                {
                    DataType dt_ = tuple_cadhcldckpqwmtcazwxfnkhgc?.AnesthesiaProcedure?.Performed;
                    object du_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dt_);
                    aq_ = du_ as CqlQuantity;
                }
                else
                {
                    DataType dv_ = tuple_cadhcldckpqwmtcazwxfnkhgc?.AnesthesiaProcedure?.Performed;
                    object dw_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dv_);
                    bool dx_ = dw_ is CqlInterval<CqlDateTime>;
                    if (dx_)
                    {
                        DataType dy_ = tuple_cadhcldckpqwmtcazwxfnkhgc?.AnesthesiaProcedure?.Performed;
                        object dz_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dy_);
                        aq_ = dz_ as CqlInterval<CqlDateTime>;
                    }
                    else
                    {
                        DataType ea_ = tuple_cadhcldckpqwmtcazwxfnkhgc?.AnesthesiaProcedure?.Performed;
                        object eb_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ea_);
                        bool ec_ = eb_ is CqlInterval<CqlQuantity>;
                        if (ec_)
                        {
                            DataType ed_ = tuple_cadhcldckpqwmtcazwxfnkhgc?.AnesthesiaProcedure?.Performed;
                            object ee_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ed_);
                            aq_ = ee_ as CqlInterval<CqlQuantity>;
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
            DataType ef_ = tuple_cadhcldckpqwmtcazwxfnkhgc?.AnesthesiaProcedure?.Performed;
            object eg_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ef_);
            bool eh_ = eg_ is CqlDateTime;
            if (eh_)
            {
                DataType ei_ = tuple_cadhcldckpqwmtcazwxfnkhgc?.AnesthesiaProcedure?.Performed;
                object ej_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ei_);
                av_ = ej_ as CqlDateTime;
            }
            else
            {
                DataType ek_ = tuple_cadhcldckpqwmtcazwxfnkhgc?.AnesthesiaProcedure?.Performed;
                object el_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ek_);
                bool em_ = el_ is CqlQuantity;
                if (em_)
                {
                    DataType en_ = tuple_cadhcldckpqwmtcazwxfnkhgc?.AnesthesiaProcedure?.Performed;
                    object eo_ = FHIRHelpers_4_4_000.Instance.ToValue(context, en_);
                    av_ = eo_ as CqlQuantity;
                }
                else
                {
                    DataType ep_ = tuple_cadhcldckpqwmtcazwxfnkhgc?.AnesthesiaProcedure?.Performed;
                    object eq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ep_);
                    bool er_ = eq_ is CqlInterval<CqlDateTime>;
                    if (er_)
                    {
                        DataType es_ = tuple_cadhcldckpqwmtcazwxfnkhgc?.AnesthesiaProcedure?.Performed;
                        object et_ = FHIRHelpers_4_4_000.Instance.ToValue(context, es_);
                        av_ = et_ as CqlInterval<CqlDateTime>;
                    }
                    else
                    {
                        DataType eu_ = tuple_cadhcldckpqwmtcazwxfnkhgc?.AnesthesiaProcedure?.Performed;
                        object ev_ = FHIRHelpers_4_4_000.Instance.ToValue(context, eu_);
                        bool ew_ = ev_ is CqlInterval<CqlQuantity>;
                        if (ew_)
                        {
                            DataType ex_ = tuple_cadhcldckpqwmtcazwxfnkhgc?.AnesthesiaProcedure?.Performed;
                            object ey_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ex_);
                            av_ = ey_ as CqlInterval<CqlQuantity>;
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
                CqlDateTime g_ = PatientRefusal switch
                {
                    ValueTuple<CqlTupleMetadata, string, IEnumerable<CqlConcept>, CqlDateTime> => (((CqlTupleMetadata, string id, IEnumerable<CqlConcept> medicationStatusReason, CqlDateTime authoredOn)?)PatientRefusal)?.authoredOn,
                    ValueTuple<CqlTupleMetadata, string, CqlConcept, CqlDateTime> => (((CqlTupleMetadata, string id, CqlConcept requestStatusReason, CqlDateTime authoredOn)?)PatientRefusal)?.authoredOn,
                    _ => null,
                };
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
            DataType ba_ = tuple_fpeghttqsjgusnbabduddbjbh?.AnesthesiaProcedure?.Performed;
            object bb_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ba_);
            bool bc_ = bb_ is CqlDateTime;
            if (bc_)
            {
                DataType bd_ = tuple_fpeghttqsjgusnbabduddbjbh?.AnesthesiaProcedure?.Performed;
                object be_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bd_);
                p_ = be_ as CqlDateTime;
            }
            else
            {
                DataType bf_ = tuple_fpeghttqsjgusnbabduddbjbh?.AnesthesiaProcedure?.Performed;
                object bg_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bf_);
                bool bh_ = bg_ is CqlQuantity;
                if (bh_)
                {
                    DataType bi_ = tuple_fpeghttqsjgusnbabduddbjbh?.AnesthesiaProcedure?.Performed;
                    object bj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bi_);
                    p_ = bj_ as CqlQuantity;
                }
                else
                {
                    DataType bk_ = tuple_fpeghttqsjgusnbabduddbjbh?.AnesthesiaProcedure?.Performed;
                    object bl_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bk_);
                    bool bm_ = bl_ is CqlInterval<CqlDateTime>;
                    if (bm_)
                    {
                        DataType bn_ = tuple_fpeghttqsjgusnbabduddbjbh?.AnesthesiaProcedure?.Performed;
                        object bo_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bn_);
                        p_ = bo_ as CqlInterval<CqlDateTime>;
                    }
                    else
                    {
                        DataType bp_ = tuple_fpeghttqsjgusnbabduddbjbh?.AnesthesiaProcedure?.Performed;
                        object bq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bp_);
                        bool br_ = bq_ is CqlInterval<CqlQuantity>;
                        if (br_)
                        {
                            DataType bs_ = tuple_fpeghttqsjgusnbabduddbjbh?.AnesthesiaProcedure?.Performed;
                            object bt_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bs_);
                            p_ = bt_ as CqlInterval<CqlQuantity>;
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
            object z_ = tuple_fpeghttqsjgusnbabduddbjbh?.PatientRefusal;
            CqlDateTime aa_ = z_ switch
            {
                ValueTuple<CqlTupleMetadata, string, IEnumerable<CqlConcept>, CqlDateTime> => (((CqlTupleMetadata, string id, IEnumerable<CqlConcept> medicationStatusReason, CqlDateTime authoredOn)?)z_)?.authoredOn,
                ValueTuple<CqlTupleMetadata, string, CqlConcept, CqlDateTime> => (((CqlTupleMetadata, string id, CqlConcept requestStatusReason, CqlDateTime authoredOn)?)z_)?.authoredOn,
                _ => null,
            };
            object ab_;
            DataType bu_ = tuple_fpeghttqsjgusnbabduddbjbh?.AnesthesiaProcedure?.Performed;
            object bv_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bu_);
            bool bw_ = bv_ is CqlDateTime;
            if (bw_)
            {
                DataType bx_ = tuple_fpeghttqsjgusnbabduddbjbh?.AnesthesiaProcedure?.Performed;
                object by_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bx_);
                ab_ = by_ as CqlDateTime;
            }
            else
            {
                DataType bz_ = tuple_fpeghttqsjgusnbabduddbjbh?.AnesthesiaProcedure?.Performed;
                object ca_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bz_);
                bool cb_ = ca_ is CqlQuantity;
                if (cb_)
                {
                    DataType cc_ = tuple_fpeghttqsjgusnbabduddbjbh?.AnesthesiaProcedure?.Performed;
                    object cd_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cc_);
                    ab_ = cd_ as CqlQuantity;
                }
                else
                {
                    DataType ce_ = tuple_fpeghttqsjgusnbabduddbjbh?.AnesthesiaProcedure?.Performed;
                    object cf_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ce_);
                    bool cg_ = cf_ is CqlInterval<CqlDateTime>;
                    if (cg_)
                    {
                        DataType ch_ = tuple_fpeghttqsjgusnbabduddbjbh?.AnesthesiaProcedure?.Performed;
                        object ci_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ch_);
                        ab_ = ci_ as CqlInterval<CqlDateTime>;
                    }
                    else
                    {
                        DataType cj_ = tuple_fpeghttqsjgusnbabduddbjbh?.AnesthesiaProcedure?.Performed;
                        object ck_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cj_);
                        bool cl_ = ck_ is CqlInterval<CqlQuantity>;
                        if (cl_)
                        {
                            DataType cm_ = tuple_fpeghttqsjgusnbabduddbjbh?.AnesthesiaProcedure?.Performed;
                            object cn_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cm_);
                            ab_ = cn_ as CqlInterval<CqlQuantity>;
                        }
                        else
                        {
                            ab_ = null;
                        }
                    }
                }
            }
            CqlInterval<CqlDateTime> ac_ = QICoreCommon_4_0_000.Instance.toInterval(context, ab_);
            CqlDateTime ad_ = context.Operators.End(ac_);
            CqlInterval<CqlDate> ae_ = TJCOverall_8_25_000.Instance.calendarDayOfOrDayAfter(context, ad_);
            CqlDate af_ = ae_?.low;
            CqlDateTime ag_ = context.Operators.ConvertDateToDateTime(af_);
            object ah_;
            DataType co_ = tuple_fpeghttqsjgusnbabduddbjbh?.AnesthesiaProcedure?.Performed;
            object cp_ = FHIRHelpers_4_4_000.Instance.ToValue(context, co_);
            bool cq_ = cp_ is CqlDateTime;
            if (cq_)
            {
                DataType cr_ = tuple_fpeghttqsjgusnbabduddbjbh?.AnesthesiaProcedure?.Performed;
                object cs_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cr_);
                ah_ = cs_ as CqlDateTime;
            }
            else
            {
                DataType ct_ = tuple_fpeghttqsjgusnbabduddbjbh?.AnesthesiaProcedure?.Performed;
                object cu_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ct_);
                bool cv_ = cu_ is CqlQuantity;
                if (cv_)
                {
                    DataType cw_ = tuple_fpeghttqsjgusnbabduddbjbh?.AnesthesiaProcedure?.Performed;
                    object cx_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cw_);
                    ah_ = cx_ as CqlQuantity;
                }
                else
                {
                    DataType cy_ = tuple_fpeghttqsjgusnbabduddbjbh?.AnesthesiaProcedure?.Performed;
                    object cz_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cy_);
                    bool da_ = cz_ is CqlInterval<CqlDateTime>;
                    if (da_)
                    {
                        DataType db_ = tuple_fpeghttqsjgusnbabduddbjbh?.AnesthesiaProcedure?.Performed;
                        object dc_ = FHIRHelpers_4_4_000.Instance.ToValue(context, db_);
                        ah_ = dc_ as CqlInterval<CqlDateTime>;
                    }
                    else
                    {
                        DataType dd_ = tuple_fpeghttqsjgusnbabduddbjbh?.AnesthesiaProcedure?.Performed;
                        object de_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dd_);
                        bool df_ = de_ is CqlInterval<CqlQuantity>;
                        if (df_)
                        {
                            DataType dg_ = tuple_fpeghttqsjgusnbabduddbjbh?.AnesthesiaProcedure?.Performed;
                            object dh_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dg_);
                            ah_ = dh_ as CqlInterval<CqlQuantity>;
                        }
                        else
                        {
                            ah_ = null;
                        }
                    }
                }
            }
            CqlInterval<CqlDateTime> ai_ = QICoreCommon_4_0_000.Instance.toInterval(context, ah_);
            CqlDateTime aj_ = context.Operators.End(ai_);
            CqlInterval<CqlDate> ak_ = TJCOverall_8_25_000.Instance.calendarDayOfOrDayAfter(context, aj_);
            CqlDate al_ = ak_?.high;
            CqlDateTime am_ = context.Operators.ConvertDateToDateTime(al_);
            object an_;
            DataType di_ = tuple_fpeghttqsjgusnbabduddbjbh?.AnesthesiaProcedure?.Performed;
            object dj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, di_);
            bool dk_ = dj_ is CqlDateTime;
            if (dk_)
            {
                DataType dl_ = tuple_fpeghttqsjgusnbabduddbjbh?.AnesthesiaProcedure?.Performed;
                object dm_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dl_);
                an_ = dm_ as CqlDateTime;
            }
            else
            {
                DataType dn_ = tuple_fpeghttqsjgusnbabduddbjbh?.AnesthesiaProcedure?.Performed;
                object do_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dn_);
                bool dp_ = do_ is CqlQuantity;
                if (dp_)
                {
                    DataType dq_ = tuple_fpeghttqsjgusnbabduddbjbh?.AnesthesiaProcedure?.Performed;
                    object dr_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dq_);
                    an_ = dr_ as CqlQuantity;
                }
                else
                {
                    DataType ds_ = tuple_fpeghttqsjgusnbabduddbjbh?.AnesthesiaProcedure?.Performed;
                    object dt_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ds_);
                    bool du_ = dt_ is CqlInterval<CqlDateTime>;
                    if (du_)
                    {
                        DataType dv_ = tuple_fpeghttqsjgusnbabduddbjbh?.AnesthesiaProcedure?.Performed;
                        object dw_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dv_);
                        an_ = dw_ as CqlInterval<CqlDateTime>;
                    }
                    else
                    {
                        DataType dx_ = tuple_fpeghttqsjgusnbabduddbjbh?.AnesthesiaProcedure?.Performed;
                        object dy_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dx_);
                        bool dz_ = dy_ is CqlInterval<CqlQuantity>;
                        if (dz_)
                        {
                            DataType ea_ = tuple_fpeghttqsjgusnbabduddbjbh?.AnesthesiaProcedure?.Performed;
                            object eb_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ea_);
                            an_ = eb_ as CqlInterval<CqlQuantity>;
                        }
                        else
                        {
                            an_ = null;
                        }
                    }
                }
            }
            CqlInterval<CqlDateTime> ao_ = QICoreCommon_4_0_000.Instance.toInterval(context, an_);
            CqlDateTime ap_ = context.Operators.End(ao_);
            CqlInterval<CqlDate> aq_ = TJCOverall_8_25_000.Instance.calendarDayOfOrDayAfter(context, ap_);
            bool? ar_ = aq_?.lowClosed;
            object as_;
            DataType ec_ = tuple_fpeghttqsjgusnbabduddbjbh?.AnesthesiaProcedure?.Performed;
            object ed_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ec_);
            bool ee_ = ed_ is CqlDateTime;
            if (ee_)
            {
                DataType ef_ = tuple_fpeghttqsjgusnbabduddbjbh?.AnesthesiaProcedure?.Performed;
                object eg_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ef_);
                as_ = eg_ as CqlDateTime;
            }
            else
            {
                DataType eh_ = tuple_fpeghttqsjgusnbabduddbjbh?.AnesthesiaProcedure?.Performed;
                object ei_ = FHIRHelpers_4_4_000.Instance.ToValue(context, eh_);
                bool ej_ = ei_ is CqlQuantity;
                if (ej_)
                {
                    DataType ek_ = tuple_fpeghttqsjgusnbabduddbjbh?.AnesthesiaProcedure?.Performed;
                    object el_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ek_);
                    as_ = el_ as CqlQuantity;
                }
                else
                {
                    DataType em_ = tuple_fpeghttqsjgusnbabduddbjbh?.AnesthesiaProcedure?.Performed;
                    object en_ = FHIRHelpers_4_4_000.Instance.ToValue(context, em_);
                    bool eo_ = en_ is CqlInterval<CqlDateTime>;
                    if (eo_)
                    {
                        DataType ep_ = tuple_fpeghttqsjgusnbabduddbjbh?.AnesthesiaProcedure?.Performed;
                        object eq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ep_);
                        as_ = eq_ as CqlInterval<CqlDateTime>;
                    }
                    else
                    {
                        DataType er_ = tuple_fpeghttqsjgusnbabduddbjbh?.AnesthesiaProcedure?.Performed;
                        object es_ = FHIRHelpers_4_4_000.Instance.ToValue(context, er_);
                        bool et_ = es_ is CqlInterval<CqlQuantity>;
                        if (et_)
                        {
                            DataType eu_ = tuple_fpeghttqsjgusnbabduddbjbh?.AnesthesiaProcedure?.Performed;
                            object ev_ = FHIRHelpers_4_4_000.Instance.ToValue(context, eu_);
                            as_ = ev_ as CqlInterval<CqlQuantity>;
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
            bool? aw_ = av_?.highClosed;
            CqlInterval<CqlDateTime> ax_ = context.Operators.Interval(ag_, am_, ar_, aw_);
            bool? ay_ = context.Operators.In<CqlDateTime>(aa_, ax_, "day");
            bool? az_ = context.Operators.And(y_, ay_);
            return az_;
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

    private static CqlTupleMetadata CqlTupleMetadata_DQDJDfNDAVfLFYEjYSBYIhgSj = new(
       [typeof(Encounter), typeof(object)],
       ["QualifyingEncounter", "VTEProphylaxis"]);

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

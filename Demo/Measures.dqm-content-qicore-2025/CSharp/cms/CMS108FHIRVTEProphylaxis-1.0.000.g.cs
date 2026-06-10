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

[System.CodeDom.Compiler.GeneratedCode(".NET Code Generation", "5.1.0.0")]
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

        IEnumerable<Encounter> b_(Encounter QualifyingEncounter) {
            IEnumerable<object> d_ = this.Intervention_Comfort_Measures(context);

            bool? e_(object ComfortMeasure) {

                object i_() {

                    bool z_() {
                        object ad_ = context.Operators.LateBoundProperty<object>(ComfortMeasure, "performed");
                        object ae_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ad_);
                        bool af_ = ae_ is CqlDateTime;
                        return af_;
                    }


                    bool aa_() {
                        object ag_ = context.Operators.LateBoundProperty<object>(ComfortMeasure, "performed");
                        object ah_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ag_);
                        bool ai_ = ah_ is CqlInterval<CqlDateTime>;
                        return ai_;
                    }


                    bool ab_() {
                        object aj_ = context.Operators.LateBoundProperty<object>(ComfortMeasure, "performed");
                        object ak_ = FHIRHelpers_4_4_000.Instance.ToValue(context, aj_);
                        bool al_ = ak_ is CqlQuantity;
                        return al_;
                    }


                    bool ac_() {
                        object am_ = context.Operators.LateBoundProperty<object>(ComfortMeasure, "performed");
                        object an_ = FHIRHelpers_4_4_000.Instance.ToValue(context, am_);
                        bool ao_ = an_ is CqlInterval<CqlQuantity>;
                        return ao_;
                    }

                    if (z_())
                    {
                        object ap_ = context.Operators.LateBoundProperty<object>(ComfortMeasure, "performed");
                        object aq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ap_);
                        return (aq_ as CqlDateTime) as object;
                    }
                    else if (aa_())
                    {
                        object ar_ = context.Operators.LateBoundProperty<object>(ComfortMeasure, "performed");
                        object as_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ar_);
                        return (as_ as CqlInterval<CqlDateTime>) as object;
                    }
                    else if (ab_())
                    {
                        object at_ = context.Operators.LateBoundProperty<object>(ComfortMeasure, "performed");
                        object au_ = FHIRHelpers_4_4_000.Instance.ToValue(context, at_);
                        return (au_ as CqlQuantity) as object;
                    }
                    else if (ac_())
                    {
                        object av_ = context.Operators.LateBoundProperty<object>(ComfortMeasure, "performed");
                        object aw_ = FHIRHelpers_4_4_000.Instance.ToValue(context, av_);
                        return (aw_ as CqlInterval<CqlQuantity>) as object;
                    }
                    else
                    {
                        return null;
                    };
                }

                CqlInterval<CqlDateTime> j_ = QICoreCommon_4_0_000.Instance.toInterval(context, i_());
                CqlDateTime k_ = context.Operators.Start(j_);
                object l_ = context.Operators.LateBoundProperty<object>(ComfortMeasure, "authoredOn");
                CqlDateTime m_ = context.Operators.LateBoundProperty<CqlDateTime>(l_, "value");
                CqlInterval<CqlDate> n_ = this.fromDayOfStartOfHospitalizationToDayAfterAdmission(context, QualifyingEncounter);
                CqlDate o_ = n_?.low;
                CqlDateTime p_ = context.Operators.ConvertDateToDateTime(o_);
                CqlDate r_ = n_?.high;
                CqlDateTime s_ = context.Operators.ConvertDateToDateTime(r_);
                bool? u_ = n_?.lowClosed;
                bool? w_ = n_?.highClosed;
                CqlInterval<CqlDateTime> x_ = context.Operators.Interval(p_, s_, u_, w_);
                bool? y_ = context.Operators.In<CqlDateTime>(k_ ?? m_, x_, "day");
                return y_;
            }

            IEnumerable<object> f_ = context.Operators.Where<object>(d_, e_);
            Encounter g_(object ComfortMeasure) => QualifyingEncounter;
            IEnumerable<Encounter> h_ = context.Operators.Select<object, Encounter>(f_, g_);
            return h_;
        }

        IEnumerable<Encounter> c_ = context.Operators.SelectMany<Encounter, Encounter>(a_, b_);
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

        IEnumerable<MedicationAdministration> d_(MedicationAdministration MR) {
            IEnumerable<Medication> bd_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));

            bool? be_(Medication M) {
                object bi_ = context.Operators.LateBoundProperty<object>(M, "id.value");
                object bj_ = context.Operators.LateBoundProperty<object>(MR, "medication.reference.value");
                IEnumerable<string> bk_ = context.Operators.Split((string)bj_, "/");
                string bl_ = context.Operators.Last<string>(bk_);
                bool? bm_ = context.Operators.Equal(bi_, bl_);
                CodeableConcept bn_ = M?.Code;
                CqlConcept bo_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, bn_);
                CqlValueSet bp_ = this.Low_Dose_Unfractionated_Heparin_for_VTE_Prophylaxis(context);
                bool? bq_ = context.Operators.ConceptInValueSet(bo_, bp_);
                bool? br_ = context.Operators.And(bm_, bq_);
                return br_;
            }

            IEnumerable<Medication> bf_ = context.Operators.Where<Medication>(bd_, be_);
            MedicationAdministration bg_(Medication M) => MR;
            IEnumerable<MedicationAdministration> bh_ = context.Operators.Select<Medication, MedicationAdministration>(bf_, bg_);
            return bh_;
        }

        IEnumerable<MedicationAdministration> e_ = context.Operators.SelectMany<MedicationAdministration, MedicationAdministration>(c_, d_);
        IEnumerable<MedicationAdministration> f_ = context.Operators.Union<MedicationAdministration>(b_, e_);

        bool? g_(MedicationAdministration VTEMedication) {
            Code<MedicationAdministration.MedicationAdministrationStatusCodes> bs_ = VTEMedication?.StatusElement;
            MedicationAdministration.MedicationAdministrationStatusCodes? bt_ = bs_?.Value;
            string bu_ = context.Operators.Convert<string>(bt_);
            bool? bv_ = context.Operators.Equal(bu_, "completed");
            MedicationAdministration.DosageComponent bw_ = VTEMedication?.Dosage;
            CodeableConcept bx_ = bw_?.Route;
            CqlConcept by_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, bx_);
            CqlValueSet bz_ = this.Subcutaneous_route(context);
            bool? ca_ = context.Operators.ConceptInValueSet(by_, bz_);
            bool? cb_ = context.Operators.And(bv_, ca_);
            return cb_;
        }

        IEnumerable<MedicationAdministration> h_ = context.Operators.Where<MedicationAdministration>(f_, g_);
        CqlValueSet i_ = this.Low_Molecular_Weight_Heparin_for_VTE_Prophylaxis(context);
        IEnumerable<MedicationAdministration> j_ = context.Operators.Retrieve<MedicationAdministration>(new RetrieveParameters(default, i_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationadministration"));

        IEnumerable<MedicationAdministration> l_(MedicationAdministration MR) {
            IEnumerable<Medication> cc_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));

            bool? cd_(Medication M) {
                object ch_ = context.Operators.LateBoundProperty<object>(M, "id.value");
                object ci_ = context.Operators.LateBoundProperty<object>(MR, "medication.reference.value");
                IEnumerable<string> cj_ = context.Operators.Split((string)ci_, "/");
                string ck_ = context.Operators.Last<string>(cj_);
                bool? cl_ = context.Operators.Equal(ch_, ck_);
                CodeableConcept cm_ = M?.Code;
                CqlConcept cn_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, cm_);
                CqlValueSet co_ = this.Low_Molecular_Weight_Heparin_for_VTE_Prophylaxis(context);
                bool? cp_ = context.Operators.ConceptInValueSet(cn_, co_);
                bool? cq_ = context.Operators.And(cl_, cp_);
                return cq_;
            }

            IEnumerable<Medication> ce_ = context.Operators.Where<Medication>(cc_, cd_);
            MedicationAdministration cf_(Medication M) => MR;
            IEnumerable<MedicationAdministration> cg_ = context.Operators.Select<Medication, MedicationAdministration>(ce_, cf_);
            return cg_;
        }

        IEnumerable<MedicationAdministration> m_ = context.Operators.SelectMany<MedicationAdministration, MedicationAdministration>(c_, l_);
        IEnumerable<MedicationAdministration> n_ = context.Operators.Union<MedicationAdministration>(j_, m_);

        bool? o_(MedicationAdministration LMWH) {
            Code<MedicationAdministration.MedicationAdministrationStatusCodes> cr_ = LMWH?.StatusElement;
            MedicationAdministration.MedicationAdministrationStatusCodes? cs_ = cr_?.Value;
            string ct_ = context.Operators.Convert<string>(cs_);
            bool? cu_ = context.Operators.Equal(ct_, "completed");
            return cu_;
        }

        IEnumerable<MedicationAdministration> p_ = context.Operators.Where<MedicationAdministration>(n_, o_);
        IEnumerable<MedicationAdministration> q_ = context.Operators.Union<MedicationAdministration>(h_, p_);
        CqlValueSet r_ = this.Injectable_Factor_Xa_Inhibitor_for_VTE_Prophylaxis(context);
        IEnumerable<MedicationAdministration> s_ = context.Operators.Retrieve<MedicationAdministration>(new RetrieveParameters(default, r_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationadministration"));

        IEnumerable<MedicationAdministration> u_(MedicationAdministration MR) {
            IEnumerable<Medication> cv_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));

            bool? cw_(Medication M) {
                object da_ = context.Operators.LateBoundProperty<object>(M, "id.value");
                object db_ = context.Operators.LateBoundProperty<object>(MR, "medication.reference.value");
                IEnumerable<string> dc_ = context.Operators.Split((string)db_, "/");
                string dd_ = context.Operators.Last<string>(dc_);
                bool? de_ = context.Operators.Equal(da_, dd_);
                CodeableConcept df_ = M?.Code;
                CqlConcept dg_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, df_);
                CqlValueSet dh_ = this.Injectable_Factor_Xa_Inhibitor_for_VTE_Prophylaxis(context);
                bool? di_ = context.Operators.ConceptInValueSet(dg_, dh_);
                bool? dj_ = context.Operators.And(de_, di_);
                return dj_;
            }

            IEnumerable<Medication> cx_ = context.Operators.Where<Medication>(cv_, cw_);
            MedicationAdministration cy_(Medication M) => MR;
            IEnumerable<MedicationAdministration> cz_ = context.Operators.Select<Medication, MedicationAdministration>(cx_, cy_);
            return cz_;
        }

        IEnumerable<MedicationAdministration> v_ = context.Operators.SelectMany<MedicationAdministration, MedicationAdministration>(c_, u_);
        IEnumerable<MedicationAdministration> w_ = context.Operators.Union<MedicationAdministration>(s_, v_);

        bool? x_(MedicationAdministration FactorXa) {
            Code<MedicationAdministration.MedicationAdministrationStatusCodes> dk_ = FactorXa?.StatusElement;
            MedicationAdministration.MedicationAdministrationStatusCodes? dl_ = dk_?.Value;
            string dm_ = context.Operators.Convert<string>(dl_);
            bool? dn_ = context.Operators.Equal(dm_, "completed");
            return dn_;
        }

        IEnumerable<MedicationAdministration> y_ = context.Operators.Where<MedicationAdministration>(w_, x_);
        CqlValueSet z_ = this.Warfarin(context);
        IEnumerable<MedicationAdministration> aa_ = context.Operators.Retrieve<MedicationAdministration>(new RetrieveParameters(default, z_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationadministration"));

        IEnumerable<MedicationAdministration> ac_(MedicationAdministration MR) {
            IEnumerable<Medication> do_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));

            bool? dp_(Medication M) {
                object dt_ = context.Operators.LateBoundProperty<object>(M, "id.value");
                object du_ = context.Operators.LateBoundProperty<object>(MR, "medication.reference.value");
                IEnumerable<string> dv_ = context.Operators.Split((string)du_, "/");
                string dw_ = context.Operators.Last<string>(dv_);
                bool? dx_ = context.Operators.Equal(dt_, dw_);
                CodeableConcept dy_ = M?.Code;
                CqlConcept dz_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, dy_);
                CqlValueSet ea_ = this.Warfarin(context);
                bool? eb_ = context.Operators.ConceptInValueSet(dz_, ea_);
                bool? ec_ = context.Operators.And(dx_, eb_);
                return ec_;
            }

            IEnumerable<Medication> dq_ = context.Operators.Where<Medication>(do_, dp_);
            MedicationAdministration dr_(Medication M) => MR;
            IEnumerable<MedicationAdministration> ds_ = context.Operators.Select<Medication, MedicationAdministration>(dq_, dr_);
            return ds_;
        }

        IEnumerable<MedicationAdministration> ad_ = context.Operators.SelectMany<MedicationAdministration, MedicationAdministration>(c_, ac_);
        IEnumerable<MedicationAdministration> ae_ = context.Operators.Union<MedicationAdministration>(aa_, ad_);

        bool? af_(MedicationAdministration WarfarinAdm) {
            Code<MedicationAdministration.MedicationAdministrationStatusCodes> ed_ = WarfarinAdm?.StatusElement;
            MedicationAdministration.MedicationAdministrationStatusCodes? ee_ = ed_?.Value;
            string ef_ = context.Operators.Convert<string>(ee_);
            bool? eg_ = context.Operators.Equal(ef_, "completed");
            return eg_;
        }

        IEnumerable<MedicationAdministration> ag_ = context.Operators.Where<MedicationAdministration>(ae_, af_);
        IEnumerable<MedicationAdministration> ah_ = context.Operators.Union<MedicationAdministration>(y_, ag_);
        IEnumerable<MedicationAdministration> ai_ = context.Operators.Union<MedicationAdministration>(q_, ah_);
        CqlValueSet aj_ = this.Rivaroxaban_for_VTE_Prophylaxis(context);
        IEnumerable<MedicationAdministration> ak_ = context.Operators.Retrieve<MedicationAdministration>(new RetrieveParameters(default, aj_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationadministration"));

        IEnumerable<MedicationAdministration> am_(MedicationAdministration MR) {
            IEnumerable<Medication> eh_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));

            bool? ei_(Medication M) {
                object em_ = context.Operators.LateBoundProperty<object>(M, "id.value");
                object en_ = context.Operators.LateBoundProperty<object>(MR, "medication.reference.value");
                IEnumerable<string> eo_ = context.Operators.Split((string)en_, "/");
                string ep_ = context.Operators.Last<string>(eo_);
                bool? eq_ = context.Operators.Equal(em_, ep_);
                CodeableConcept er_ = M?.Code;
                CqlConcept es_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, er_);
                CqlValueSet et_ = this.Rivaroxaban_for_VTE_Prophylaxis(context);
                bool? eu_ = context.Operators.ConceptInValueSet(es_, et_);
                bool? ev_ = context.Operators.And(eq_, eu_);
                return ev_;
            }

            IEnumerable<Medication> ej_ = context.Operators.Where<Medication>(eh_, ei_);
            MedicationAdministration ek_(Medication M) => MR;
            IEnumerable<MedicationAdministration> el_ = context.Operators.Select<Medication, MedicationAdministration>(ej_, ek_);
            return el_;
        }

        IEnumerable<MedicationAdministration> an_ = context.Operators.SelectMany<MedicationAdministration, MedicationAdministration>(c_, am_);
        IEnumerable<MedicationAdministration> ao_ = context.Operators.Union<MedicationAdministration>(ak_, an_);

        bool? ap_(MedicationAdministration Rivaroxaban) {
            Code<MedicationAdministration.MedicationAdministrationStatusCodes> ew_ = Rivaroxaban?.StatusElement;
            MedicationAdministration.MedicationAdministrationStatusCodes? ex_ = ew_?.Value;
            string ey_ = context.Operators.Convert<string>(ex_);
            bool? ez_ = context.Operators.Equal(ey_, "completed");
            return ez_;
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
            Code<EventStatus> fa_ = DeviceApplied?.StatusElement;
            EventStatus? fb_ = fa_?.Value;
            string fc_ = context.Operators.Convert<string>(fb_);
            bool? fd_ = context.Operators.Equal(fc_, "completed");
            return fd_;
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

        IEnumerable<MedicationAdministration> e_(MedicationAdministration MR) {
            IEnumerable<Medication> ah_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));

            bool? ai_(Medication M) {
                object am_ = context.Operators.LateBoundProperty<object>(M, "id.value");
                object an_ = context.Operators.LateBoundProperty<object>(MR, "medication.reference.value");
                IEnumerable<string> ao_ = context.Operators.Split((string)an_, "/");
                string ap_ = context.Operators.Last<string>(ao_);
                bool? aq_ = context.Operators.Equal(am_, ap_);
                CodeableConcept ar_ = M?.Code;
                CqlConcept as_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, ar_);
                CqlValueSet at_ = this.Oral_Factor_Xa_Inhibitor_for_VTE_Prophylaxis_or_VTE_Treatment(context);
                bool? au_ = context.Operators.ConceptInValueSet(as_, at_);
                bool? av_ = context.Operators.And(aq_, au_);
                return av_;
            }

            IEnumerable<Medication> aj_ = context.Operators.Where<Medication>(ah_, ai_);
            MedicationAdministration ak_(Medication M) => MR;
            IEnumerable<MedicationAdministration> al_ = context.Operators.Select<Medication, MedicationAdministration>(aj_, ak_);
            return al_;
        }

        IEnumerable<MedicationAdministration> f_ = context.Operators.SelectMany<MedicationAdministration, MedicationAdministration>(d_, e_);
        IEnumerable<MedicationAdministration> g_ = context.Operators.Union<MedicationAdministration>(c_, f_);
        IEnumerable<ValueTuple<Encounter, MedicationAdministration>> h_ = context.Operators.CrossJoin<Encounter, MedicationAdministration>(a_, g_);

        (CqlTupleMetadata, Encounter QualifyingEncounter, MedicationAdministration FactorXaMedication)? i_(ValueTuple<Encounter, MedicationAdministration> _valueTuple) {
            (CqlTupleMetadata, Encounter QualifyingEncounter, MedicationAdministration FactorXaMedication)? aw_ = (CqlTupleMetadata_EBRQeiSMaTgecHVEbVOIMZEcb, _valueTuple.Item1, _valueTuple.Item2);
            return aw_;
        }

        IEnumerable<(CqlTupleMetadata, Encounter QualifyingEncounter, MedicationAdministration FactorXaMedication)?> j_ = context.Operators.Select<ValueTuple<Encounter, MedicationAdministration>, (CqlTupleMetadata, Encounter QualifyingEncounter, MedicationAdministration FactorXaMedication)?>(h_, i_);

        bool? k_((CqlTupleMetadata, Encounter QualifyingEncounter, MedicationAdministration FactorXaMedication)? tuple_cdbvhiekdcojzrccbhjghhgeo) {
            Code<MedicationAdministration.MedicationAdministrationStatusCodes> ax_ = tuple_cdbvhiekdcojzrccbhjghhgeo?.FactorXaMedication?.StatusElement;
            MedicationAdministration.MedicationAdministrationStatusCodes? ay_ = ax_?.Value;
            string az_ = context.Operators.Convert<string>(ay_);
            bool? ba_ = context.Operators.Equal(az_, "completed");
            DataType bb_ = tuple_cdbvhiekdcojzrccbhjghhgeo?.FactorXaMedication?.Effective;
            object bc_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bb_);
            CqlInterval<CqlDateTime> bd_ = QICoreCommon_4_0_000.Instance.toInterval(context, bc_);
            CqlDateTime be_ = context.Operators.Start(bd_);
            Period bf_ = tuple_cdbvhiekdcojzrccbhjghhgeo?.QualifyingEncounter?.Period;
            CqlInterval<CqlDateTime> bg_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, bf_);
            CqlDateTime bh_ = context.Operators.Start(bg_);
            CqlInterval<CqlDate> bi_ = TJCOverall_8_25_000.Instance.calendarDayOfOrDayAfter(context, bh_);
            CqlDate bj_ = bi_?.low;
            CqlDateTime bk_ = context.Operators.ConvertDateToDateTime(bj_);
            CqlInterval<CqlDateTime> bm_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, bf_);
            CqlDateTime bn_ = context.Operators.Start(bm_);
            CqlInterval<CqlDate> bo_ = TJCOverall_8_25_000.Instance.calendarDayOfOrDayAfter(context, bn_);
            CqlDate bp_ = bo_?.high;
            CqlDateTime bq_ = context.Operators.ConvertDateToDateTime(bp_);
            CqlInterval<CqlDateTime> bs_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, bf_);
            CqlDateTime bt_ = context.Operators.Start(bs_);
            CqlInterval<CqlDate> bu_ = TJCOverall_8_25_000.Instance.calendarDayOfOrDayAfter(context, bt_);
            bool? bv_ = bu_?.lowClosed;
            CqlInterval<CqlDateTime> bx_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, bf_);
            CqlDateTime by_ = context.Operators.Start(bx_);
            CqlInterval<CqlDate> bz_ = TJCOverall_8_25_000.Instance.calendarDayOfOrDayAfter(context, by_);
            bool? ca_ = bz_?.highClosed;
            CqlInterval<CqlDateTime> cb_ = context.Operators.Interval(bk_, bq_, bv_, ca_);
            bool? cc_ = context.Operators.In<CqlDateTime>(be_, cb_, "day");
            bool? cd_ = context.Operators.And(ba_, cc_);
            return cd_;
        }

        IEnumerable<(CqlTupleMetadata, Encounter QualifyingEncounter, MedicationAdministration FactorXaMedication)?> l_ = context.Operators.Where<(CqlTupleMetadata, Encounter QualifyingEncounter, MedicationAdministration FactorXaMedication)?>(j_, k_);
        Encounter m_((CqlTupleMetadata, Encounter QualifyingEncounter, MedicationAdministration FactorXaMedication)? tuple_cdbvhiekdcojzrccbhjghhgeo) => tuple_cdbvhiekdcojzrccbhjghhgeo?.QualifyingEncounter;
        IEnumerable<Encounter> n_ = context.Operators.Select<(CqlTupleMetadata, Encounter QualifyingEncounter, MedicationAdministration FactorXaMedication)?, Encounter>(l_, m_);
        IEnumerable<Encounter> o_ = context.Operators.Distinct<Encounter>(n_);
        CqlValueSet q_ = this.General_or_Neuraxial_Anesthesia(context);
        IEnumerable<Procedure> r_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, q_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
        IEnumerable<MedicationAdministration> t_ = context.Operators.Retrieve<MedicationAdministration>(new RetrieveParameters(default, b_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationadministration"));

        IEnumerable<MedicationAdministration> v_(MedicationAdministration MR) {
            IEnumerable<Medication> ce_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));

            bool? cf_(Medication M) {
                object cj_ = context.Operators.LateBoundProperty<object>(M, "id.value");
                object ck_ = context.Operators.LateBoundProperty<object>(MR, "medication.reference.value");
                IEnumerable<string> cl_ = context.Operators.Split((string)ck_, "/");
                string cm_ = context.Operators.Last<string>(cl_);
                bool? cn_ = context.Operators.Equal(cj_, cm_);
                CodeableConcept co_ = M?.Code;
                CqlConcept cp_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, co_);
                CqlValueSet cq_ = this.Oral_Factor_Xa_Inhibitor_for_VTE_Prophylaxis_or_VTE_Treatment(context);
                bool? cr_ = context.Operators.ConceptInValueSet(cp_, cq_);
                bool? cs_ = context.Operators.And(cn_, cr_);
                return cs_;
            }

            IEnumerable<Medication> cg_ = context.Operators.Where<Medication>(ce_, cf_);
            MedicationAdministration ch_(Medication M) => MR;
            IEnumerable<MedicationAdministration> ci_ = context.Operators.Select<Medication, MedicationAdministration>(cg_, ch_);
            return ci_;
        }

        IEnumerable<MedicationAdministration> w_ = context.Operators.SelectMany<MedicationAdministration, MedicationAdministration>(d_, v_);
        IEnumerable<MedicationAdministration> x_ = context.Operators.Union<MedicationAdministration>(t_, w_);
        IEnumerable<ValueTuple<Encounter, Procedure, MedicationAdministration>> y_ = context.Operators.CrossJoin<Encounter, Procedure, MedicationAdministration>(a_, r_, x_);

        (CqlTupleMetadata, Encounter QualifyingEncounter, Procedure AnesthesiaProcedure, MedicationAdministration FactorXaMedication)? z_(ValueTuple<Encounter, Procedure, MedicationAdministration> _valueTuple) {
            (CqlTupleMetadata, Encounter QualifyingEncounter, Procedure AnesthesiaProcedure, MedicationAdministration FactorXaMedication)? ct_ = (CqlTupleMetadata_CdgLdDFHNTDXFGGVTOMXhQZR, _valueTuple.Item1, _valueTuple.Item2, _valueTuple.Item3);
            return ct_;
        }

        IEnumerable<(CqlTupleMetadata, Encounter QualifyingEncounter, Procedure AnesthesiaProcedure, MedicationAdministration FactorXaMedication)?> aa_ = context.Operators.Select<ValueTuple<Encounter, Procedure, MedicationAdministration>, (CqlTupleMetadata, Encounter QualifyingEncounter, Procedure AnesthesiaProcedure, MedicationAdministration FactorXaMedication)?>(y_, z_);

        bool? ab_((CqlTupleMetadata, Encounter QualifyingEncounter, Procedure AnesthesiaProcedure, MedicationAdministration FactorXaMedication)? tuple_dejnabiogwrwyxienqokgepgj) {
            Code<MedicationAdministration.MedicationAdministrationStatusCodes> cu_ = tuple_dejnabiogwrwyxienqokgepgj?.FactorXaMedication?.StatusElement;
            MedicationAdministration.MedicationAdministrationStatusCodes? cv_ = cu_?.Value;
            string cw_ = context.Operators.Convert<string>(cv_);
            bool? cx_ = context.Operators.Equal(cw_, "completed");
            Code<EventStatus> cy_ = tuple_dejnabiogwrwyxienqokgepgj?.AnesthesiaProcedure?.StatusElement;
            EventStatus? cz_ = cy_?.Value;
            string da_ = context.Operators.Convert<string>(cz_);
            bool? db_ = context.Operators.Equal(da_, "completed");
            bool? dc_ = context.Operators.And(cx_, db_);

            object dd_() {

                bool eq_() {
                    DataType eu_ = tuple_dejnabiogwrwyxienqokgepgj?.AnesthesiaProcedure?.Performed;
                    object ev_ = FHIRHelpers_4_4_000.Instance.ToValue(context, eu_);
                    bool ew_ = ev_ is CqlDateTime;
                    return ew_;
                }


                bool er_() {
                    DataType ex_ = tuple_dejnabiogwrwyxienqokgepgj?.AnesthesiaProcedure?.Performed;
                    object ey_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ex_);
                    bool ez_ = ey_ is CqlInterval<CqlDateTime>;
                    return ez_;
                }


                bool es_() {
                    DataType fa_ = tuple_dejnabiogwrwyxienqokgepgj?.AnesthesiaProcedure?.Performed;
                    object fb_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fa_);
                    bool fc_ = fb_ is CqlQuantity;
                    return fc_;
                }


                bool et_() {
                    DataType fd_ = tuple_dejnabiogwrwyxienqokgepgj?.AnesthesiaProcedure?.Performed;
                    object fe_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fd_);
                    bool ff_ = fe_ is CqlInterval<CqlQuantity>;
                    return ff_;
                }

                if (eq_())
                {
                    DataType fg_ = tuple_dejnabiogwrwyxienqokgepgj?.AnesthesiaProcedure?.Performed;
                    object fh_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fg_);
                    return (fh_ as CqlDateTime) as object;
                }
                else if (er_())
                {
                    DataType fi_ = tuple_dejnabiogwrwyxienqokgepgj?.AnesthesiaProcedure?.Performed;
                    object fj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fi_);
                    return (fj_ as CqlInterval<CqlDateTime>) as object;
                }
                else if (es_())
                {
                    DataType fk_ = tuple_dejnabiogwrwyxienqokgepgj?.AnesthesiaProcedure?.Performed;
                    object fl_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fk_);
                    return (fl_ as CqlQuantity) as object;
                }
                else if (et_())
                {
                    DataType fm_ = tuple_dejnabiogwrwyxienqokgepgj?.AnesthesiaProcedure?.Performed;
                    object fn_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fm_);
                    return (fn_ as CqlInterval<CqlQuantity>) as object;
                }
                else
                {
                    return null;
                };
            }

            CqlInterval<CqlDateTime> de_ = QICoreCommon_4_0_000.Instance.toInterval(context, dd_());
            CqlDateTime df_ = context.Operators.End(de_);
            Period dg_ = tuple_dejnabiogwrwyxienqokgepgj?.QualifyingEncounter?.Period;
            CqlInterval<CqlDateTime> dh_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, dg_);
            CqlDateTime di_ = context.Operators.Start(dh_);
            CqlQuantity dj_ = context.Operators.Quantity(1m, "day");
            CqlDateTime dk_ = context.Operators.Add(di_, dj_);
            bool? dl_ = context.Operators.SameAs(df_, dk_, "day");
            bool? dm_ = context.Operators.And(dc_, dl_);
            DataType dn_ = tuple_dejnabiogwrwyxienqokgepgj?.FactorXaMedication?.Effective;
            object do_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dn_);
            CqlInterval<CqlDateTime> dp_ = QICoreCommon_4_0_000.Instance.toInterval(context, do_);
            CqlDateTime dq_ = context.Operators.Start(dp_);

            object dr_() {

                bool fo_() {
                    DataType fs_ = tuple_dejnabiogwrwyxienqokgepgj?.AnesthesiaProcedure?.Performed;
                    object ft_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fs_);
                    bool fu_ = ft_ is CqlDateTime;
                    return fu_;
                }


                bool fp_() {
                    DataType fv_ = tuple_dejnabiogwrwyxienqokgepgj?.AnesthesiaProcedure?.Performed;
                    object fw_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fv_);
                    bool fx_ = fw_ is CqlInterval<CqlDateTime>;
                    return fx_;
                }


                bool fq_() {
                    DataType fy_ = tuple_dejnabiogwrwyxienqokgepgj?.AnesthesiaProcedure?.Performed;
                    object fz_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fy_);
                    bool ga_ = fz_ is CqlQuantity;
                    return ga_;
                }


                bool fr_() {
                    DataType gb_ = tuple_dejnabiogwrwyxienqokgepgj?.AnesthesiaProcedure?.Performed;
                    object gc_ = FHIRHelpers_4_4_000.Instance.ToValue(context, gb_);
                    bool gd_ = gc_ is CqlInterval<CqlQuantity>;
                    return gd_;
                }

                if (fo_())
                {
                    DataType ge_ = tuple_dejnabiogwrwyxienqokgepgj?.AnesthesiaProcedure?.Performed;
                    object gf_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ge_);
                    return (gf_ as CqlDateTime) as object;
                }
                else if (fp_())
                {
                    DataType gg_ = tuple_dejnabiogwrwyxienqokgepgj?.AnesthesiaProcedure?.Performed;
                    object gh_ = FHIRHelpers_4_4_000.Instance.ToValue(context, gg_);
                    return (gh_ as CqlInterval<CqlDateTime>) as object;
                }
                else if (fq_())
                {
                    DataType gi_ = tuple_dejnabiogwrwyxienqokgepgj?.AnesthesiaProcedure?.Performed;
                    object gj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, gi_);
                    return (gj_ as CqlQuantity) as object;
                }
                else if (fr_())
                {
                    DataType gk_ = tuple_dejnabiogwrwyxienqokgepgj?.AnesthesiaProcedure?.Performed;
                    object gl_ = FHIRHelpers_4_4_000.Instance.ToValue(context, gk_);
                    return (gl_ as CqlInterval<CqlQuantity>) as object;
                }
                else
                {
                    return null;
                };
            }

            CqlInterval<CqlDateTime> ds_ = QICoreCommon_4_0_000.Instance.toInterval(context, dr_());
            CqlDateTime dt_ = context.Operators.End(ds_);
            CqlInterval<CqlDate> du_ = TJCOverall_8_25_000.Instance.calendarDayOfOrDayAfter(context, dt_);
            CqlDate dv_ = du_?.low;
            CqlDateTime dw_ = context.Operators.ConvertDateToDateTime(dv_);

            object dx_() {

                bool gm_() {
                    DataType gq_ = tuple_dejnabiogwrwyxienqokgepgj?.AnesthesiaProcedure?.Performed;
                    object gr_ = FHIRHelpers_4_4_000.Instance.ToValue(context, gq_);
                    bool gs_ = gr_ is CqlDateTime;
                    return gs_;
                }


                bool gn_() {
                    DataType gt_ = tuple_dejnabiogwrwyxienqokgepgj?.AnesthesiaProcedure?.Performed;
                    object gu_ = FHIRHelpers_4_4_000.Instance.ToValue(context, gt_);
                    bool gv_ = gu_ is CqlInterval<CqlDateTime>;
                    return gv_;
                }


                bool go_() {
                    DataType gw_ = tuple_dejnabiogwrwyxienqokgepgj?.AnesthesiaProcedure?.Performed;
                    object gx_ = FHIRHelpers_4_4_000.Instance.ToValue(context, gw_);
                    bool gy_ = gx_ is CqlQuantity;
                    return gy_;
                }


                bool gp_() {
                    DataType gz_ = tuple_dejnabiogwrwyxienqokgepgj?.AnesthesiaProcedure?.Performed;
                    object ha_ = FHIRHelpers_4_4_000.Instance.ToValue(context, gz_);
                    bool hb_ = ha_ is CqlInterval<CqlQuantity>;
                    return hb_;
                }

                if (gm_())
                {
                    DataType hc_ = tuple_dejnabiogwrwyxienqokgepgj?.AnesthesiaProcedure?.Performed;
                    object hd_ = FHIRHelpers_4_4_000.Instance.ToValue(context, hc_);
                    return (hd_ as CqlDateTime) as object;
                }
                else if (gn_())
                {
                    DataType he_ = tuple_dejnabiogwrwyxienqokgepgj?.AnesthesiaProcedure?.Performed;
                    object hf_ = FHIRHelpers_4_4_000.Instance.ToValue(context, he_);
                    return (hf_ as CqlInterval<CqlDateTime>) as object;
                }
                else if (go_())
                {
                    DataType hg_ = tuple_dejnabiogwrwyxienqokgepgj?.AnesthesiaProcedure?.Performed;
                    object hh_ = FHIRHelpers_4_4_000.Instance.ToValue(context, hg_);
                    return (hh_ as CqlQuantity) as object;
                }
                else if (gp_())
                {
                    DataType hi_ = tuple_dejnabiogwrwyxienqokgepgj?.AnesthesiaProcedure?.Performed;
                    object hj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, hi_);
                    return (hj_ as CqlInterval<CqlQuantity>) as object;
                }
                else
                {
                    return null;
                };
            }

            CqlInterval<CqlDateTime> dy_ = QICoreCommon_4_0_000.Instance.toInterval(context, dx_());
            CqlDateTime dz_ = context.Operators.End(dy_);
            CqlInterval<CqlDate> ea_ = TJCOverall_8_25_000.Instance.calendarDayOfOrDayAfter(context, dz_);
            CqlDate eb_ = ea_?.high;
            CqlDateTime ec_ = context.Operators.ConvertDateToDateTime(eb_);

            object ed_() {

                bool hk_() {
                    DataType ho_ = tuple_dejnabiogwrwyxienqokgepgj?.AnesthesiaProcedure?.Performed;
                    object hp_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ho_);
                    bool hq_ = hp_ is CqlDateTime;
                    return hq_;
                }


                bool hl_() {
                    DataType hr_ = tuple_dejnabiogwrwyxienqokgepgj?.AnesthesiaProcedure?.Performed;
                    object hs_ = FHIRHelpers_4_4_000.Instance.ToValue(context, hr_);
                    bool ht_ = hs_ is CqlInterval<CqlDateTime>;
                    return ht_;
                }


                bool hm_() {
                    DataType hu_ = tuple_dejnabiogwrwyxienqokgepgj?.AnesthesiaProcedure?.Performed;
                    object hv_ = FHIRHelpers_4_4_000.Instance.ToValue(context, hu_);
                    bool hw_ = hv_ is CqlQuantity;
                    return hw_;
                }


                bool hn_() {
                    DataType hx_ = tuple_dejnabiogwrwyxienqokgepgj?.AnesthesiaProcedure?.Performed;
                    object hy_ = FHIRHelpers_4_4_000.Instance.ToValue(context, hx_);
                    bool hz_ = hy_ is CqlInterval<CqlQuantity>;
                    return hz_;
                }

                if (hk_())
                {
                    DataType ia_ = tuple_dejnabiogwrwyxienqokgepgj?.AnesthesiaProcedure?.Performed;
                    object ib_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ia_);
                    return (ib_ as CqlDateTime) as object;
                }
                else if (hl_())
                {
                    DataType ic_ = tuple_dejnabiogwrwyxienqokgepgj?.AnesthesiaProcedure?.Performed;
                    object id_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ic_);
                    return (id_ as CqlInterval<CqlDateTime>) as object;
                }
                else if (hm_())
                {
                    DataType ie_ = tuple_dejnabiogwrwyxienqokgepgj?.AnesthesiaProcedure?.Performed;
                    object if_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ie_);
                    return (if_ as CqlQuantity) as object;
                }
                else if (hn_())
                {
                    DataType ig_ = tuple_dejnabiogwrwyxienqokgepgj?.AnesthesiaProcedure?.Performed;
                    object ih_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ig_);
                    return (ih_ as CqlInterval<CqlQuantity>) as object;
                }
                else
                {
                    return null;
                };
            }

            CqlInterval<CqlDateTime> ee_ = QICoreCommon_4_0_000.Instance.toInterval(context, ed_());
            CqlDateTime ef_ = context.Operators.End(ee_);
            CqlInterval<CqlDate> eg_ = TJCOverall_8_25_000.Instance.calendarDayOfOrDayAfter(context, ef_);
            bool? eh_ = eg_?.lowClosed;

            object ei_() {

                bool ii_() {
                    DataType im_ = tuple_dejnabiogwrwyxienqokgepgj?.AnesthesiaProcedure?.Performed;
                    object in_ = FHIRHelpers_4_4_000.Instance.ToValue(context, im_);
                    bool io_ = in_ is CqlDateTime;
                    return io_;
                }


                bool ij_() {
                    DataType ip_ = tuple_dejnabiogwrwyxienqokgepgj?.AnesthesiaProcedure?.Performed;
                    object iq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ip_);
                    bool ir_ = iq_ is CqlInterval<CqlDateTime>;
                    return ir_;
                }


                bool ik_() {
                    DataType is_ = tuple_dejnabiogwrwyxienqokgepgj?.AnesthesiaProcedure?.Performed;
                    object it_ = FHIRHelpers_4_4_000.Instance.ToValue(context, is_);
                    bool iu_ = it_ is CqlQuantity;
                    return iu_;
                }


                bool il_() {
                    DataType iv_ = tuple_dejnabiogwrwyxienqokgepgj?.AnesthesiaProcedure?.Performed;
                    object iw_ = FHIRHelpers_4_4_000.Instance.ToValue(context, iv_);
                    bool ix_ = iw_ is CqlInterval<CqlQuantity>;
                    return ix_;
                }

                if (ii_())
                {
                    DataType iy_ = tuple_dejnabiogwrwyxienqokgepgj?.AnesthesiaProcedure?.Performed;
                    object iz_ = FHIRHelpers_4_4_000.Instance.ToValue(context, iy_);
                    return (iz_ as CqlDateTime) as object;
                }
                else if (ij_())
                {
                    DataType ja_ = tuple_dejnabiogwrwyxienqokgepgj?.AnesthesiaProcedure?.Performed;
                    object jb_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ja_);
                    return (jb_ as CqlInterval<CqlDateTime>) as object;
                }
                else if (ik_())
                {
                    DataType jc_ = tuple_dejnabiogwrwyxienqokgepgj?.AnesthesiaProcedure?.Performed;
                    object jd_ = FHIRHelpers_4_4_000.Instance.ToValue(context, jc_);
                    return (jd_ as CqlQuantity) as object;
                }
                else if (il_())
                {
                    DataType je_ = tuple_dejnabiogwrwyxienqokgepgj?.AnesthesiaProcedure?.Performed;
                    object jf_ = FHIRHelpers_4_4_000.Instance.ToValue(context, je_);
                    return (jf_ as CqlInterval<CqlQuantity>) as object;
                }
                else
                {
                    return null;
                };
            }

            CqlInterval<CqlDateTime> ej_ = QICoreCommon_4_0_000.Instance.toInterval(context, ei_());
            CqlDateTime ek_ = context.Operators.End(ej_);
            CqlInterval<CqlDate> el_ = TJCOverall_8_25_000.Instance.calendarDayOfOrDayAfter(context, ek_);
            bool? em_ = el_?.highClosed;
            CqlInterval<CqlDateTime> en_ = context.Operators.Interval(dw_, ec_, eh_, em_);
            bool? eo_ = context.Operators.In<CqlDateTime>(dq_, en_, "day");
            bool? ep_ = context.Operators.And(dm_, eo_);
            return ep_;
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

        IEnumerable<Encounter> b_(Encounter QualifyingEncounter) {
            CqlValueSet l_ = this.Atrial_Fibrillation_or_Flutter(context);
            IEnumerable<Condition> m_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, l_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-problems-health-concerns"));

            bool? n_(Condition AtrialFibrillation) {
                CodeableConcept r_ = AtrialFibrillation?.VerificationStatus;
                CqlConcept s_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, r_);
                bool? t_ = context.Operators.Not((bool?)(s_ is null));
                CqlConcept v_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, r_);
                CqlCode w_ = QICoreCommon_4_0_000.Instance.refuted(context);
                CqlConcept x_ = context.Operators.ConvertCodeToConcept(w_);
                bool? y_ = context.Operators.Equivalent(v_, x_);
                bool? z_ = context.Operators.Not(y_);
                CqlConcept ab_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, r_);
                CqlCode ac_ = QICoreCommon_4_0_000.Instance.entered_in_error(context);
                CqlConcept ad_ = context.Operators.ConvertCodeToConcept(ac_);
                bool? ae_ = context.Operators.Equivalent(ab_, ad_);
                bool? af_ = context.Operators.Not(ae_);
                bool? ag_ = context.Operators.And(z_, af_);
                DataType ah_ = AtrialFibrillation?.Onset;
                object ai_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ah_);
                CqlInterval<CqlDateTime> aj_ = QICoreCommon_4_0_000.Instance.toInterval(context, ai_);
                CqlDateTime ak_ = context.Operators.Start(aj_);
                Period al_ = QualifyingEncounter?.Period;
                CqlInterval<CqlDateTime> am_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, al_);
                CqlDateTime an_ = context.Operators.End(am_);
                bool? ao_ = context.Operators.SameOrBefore(ak_, an_, (string)default);
                bool? ap_ = context.Operators.And(ag_, ao_);
                bool? aq_ = context.Operators.Implies(t_, ap_);
                return aq_;
            }

            IEnumerable<Condition> o_ = context.Operators.Where<Condition>(m_, n_);
            Encounter p_(Condition AtrialFibrillation) => QualifyingEncounter;
            IEnumerable<Encounter> q_ = context.Operators.Select<Condition, Encounter>(o_, p_);
            return q_;
        }

        IEnumerable<Encounter> c_ = context.Operators.SelectMany<Encounter, Encounter>(a_, b_);

        bool? e_(Encounter QualifyingEncounter) {
            CqlValueSet ar_ = this.Atrial_Fibrillation_or_Flutter(context);
            bool? as_ = VTE_8_18_000.Instance.hasEncDiagnosisOf(context, QualifyingEncounter, ar_);
            return as_;
        }

        IEnumerable<Encounter> f_ = context.Operators.Where<Encounter>(a_, e_);
        IEnumerable<Encounter> g_ = context.Operators.Union<Encounter>(c_, f_);

        IEnumerable<Encounter> i_(Encounter QualifyingEncounter) {
            CqlValueSet at_ = this.Venous_Thromboembolism(context);
            IEnumerable<Condition> au_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, at_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-problems-health-concerns"));

            bool? av_(Condition VTEDiagnosis) {
                CodeableConcept az_ = VTEDiagnosis?.ClinicalStatus;
                CqlConcept ba_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, az_);
                CqlCode bb_ = QICoreCommon_4_0_000.Instance.inactive(context);
                CqlConcept bc_ = context.Operators.ConvertCodeToConcept(bb_);
                bool? bd_ = context.Operators.Equivalent(ba_, bc_);
                CqlConcept bf_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, az_);
                CqlCode bg_ = QICoreCommon_4_0_000.Instance.remission(context);
                CqlConcept bh_ = context.Operators.ConvertCodeToConcept(bg_);
                bool? bi_ = context.Operators.Equivalent(bf_, bh_);
                bool? bj_ = context.Operators.Or(bd_, bi_);
                CqlConcept bl_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, az_);
                CqlCode bm_ = QICoreCommon_4_0_000.Instance.resolved(context);
                CqlConcept bn_ = context.Operators.ConvertCodeToConcept(bm_);
                bool? bo_ = context.Operators.Equivalent(bl_, bn_);
                bool? bp_ = context.Operators.Or(bj_, bo_);
                CodeableConcept bq_ = VTEDiagnosis?.VerificationStatus;
                CqlConcept br_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, bq_);
                bool? bs_ = context.Operators.Not((bool?)(br_ is null));
                bool? bt_ = context.Operators.And(bp_, bs_);
                CqlConcept bv_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, bq_);
                CqlCode bw_ = QICoreCommon_4_0_000.Instance.refuted(context);
                CqlConcept bx_ = context.Operators.ConvertCodeToConcept(bw_);
                bool? by_ = context.Operators.Equivalent(bv_, bx_);
                bool? bz_ = context.Operators.Not(by_);
                CqlConcept cb_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, bq_);
                CqlCode cc_ = QICoreCommon_4_0_000.Instance.entered_in_error(context);
                CqlConcept cd_ = context.Operators.ConvertCodeToConcept(cc_);
                bool? ce_ = context.Operators.Equivalent(cb_, cd_);
                bool? cf_ = context.Operators.Not(ce_);
                bool? cg_ = context.Operators.And(bz_, cf_);
                DataType ch_ = VTEDiagnosis?.Onset;
                object ci_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ch_);
                CqlInterval<CqlDateTime> cj_ = QICoreCommon_4_0_000.Instance.toInterval(context, ci_);

                CqlInterval<CqlDateTime> ck_() {

                    bool co_() {
                        Period cp_ = QualifyingEncounter?.Period;
                        CqlInterval<CqlDateTime> cq_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, cp_);
                        CqlDateTime cr_ = context.Operators.Start(cq_);
                        return cr_ is null;
                    }

                    if (co_())
                    {
                        return default;
                    }
                    else
                    {
                        Period cs_ = QualifyingEncounter?.Period;
                        CqlInterval<CqlDateTime> ct_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, cs_);
                        CqlDateTime cu_ = context.Operators.Start(ct_);
                        CqlInterval<CqlDateTime> cw_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, cs_);
                        CqlDateTime cx_ = context.Operators.Start(cw_);
                        CqlInterval<CqlDateTime> cy_ = context.Operators.Interval(cu_, cx_, true, true);
                        return cy_;
                    };
                }

                bool? cl_ = context.Operators.Before(cj_, ck_(), (string)default);
                bool? cm_ = context.Operators.And(cg_, cl_);
                bool? cn_ = context.Operators.Implies(bt_, cm_);
                return cn_;
            }

            IEnumerable<Condition> aw_ = context.Operators.Where<Condition>(au_, av_);
            Encounter ax_(Condition VTEDiagnosis) => QualifyingEncounter;
            IEnumerable<Encounter> ay_ = context.Operators.Select<Condition, Encounter>(aw_, ax_);
            return ay_;
        }

        IEnumerable<Encounter> j_ = context.Operators.SelectMany<Encounter, Encounter>(a_, i_);
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

        IEnumerable<Encounter> b_(Encounter QualifyingEncounter) {
            CqlValueSet d_ = this.Hip_Replacement_Surgery(context);
            IEnumerable<Procedure> e_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, d_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
            CqlValueSet f_ = this.Knee_Replacement_Surgery(context);
            IEnumerable<Procedure> g_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, f_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
            IEnumerable<Procedure> h_ = context.Operators.Union<Procedure>(e_, g_);

            bool? i_(Procedure HipKneeProcedure) {
                Code<EventStatus> m_ = HipKneeProcedure?.StatusElement;
                EventStatus? n_ = m_?.Value;
                string o_ = context.Operators.Convert<string>(n_);
                bool? p_ = context.Operators.Equal(o_, "completed");

                object q_() {

                    bool y_() {
                        DataType ac_ = HipKneeProcedure?.Performed;
                        object ad_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ac_);
                        bool ae_ = ad_ is CqlDateTime;
                        return ae_;
                    }


                    bool z_() {
                        DataType af_ = HipKneeProcedure?.Performed;
                        object ag_ = FHIRHelpers_4_4_000.Instance.ToValue(context, af_);
                        bool ah_ = ag_ is CqlInterval<CqlDateTime>;
                        return ah_;
                    }


                    bool aa_() {
                        DataType ai_ = HipKneeProcedure?.Performed;
                        object aj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ai_);
                        bool ak_ = aj_ is CqlQuantity;
                        return ak_;
                    }


                    bool ab_() {
                        DataType al_ = HipKneeProcedure?.Performed;
                        object am_ = FHIRHelpers_4_4_000.Instance.ToValue(context, al_);
                        bool an_ = am_ is CqlInterval<CqlQuantity>;
                        return an_;
                    }

                    if (y_())
                    {
                        DataType ao_ = HipKneeProcedure?.Performed;
                        object ap_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ao_);
                        return (ap_ as CqlDateTime) as object;
                    }
                    else if (z_())
                    {
                        DataType aq_ = HipKneeProcedure?.Performed;
                        object ar_ = FHIRHelpers_4_4_000.Instance.ToValue(context, aq_);
                        return (ar_ as CqlInterval<CqlDateTime>) as object;
                    }
                    else if (aa_())
                    {
                        DataType as_ = HipKneeProcedure?.Performed;
                        object at_ = FHIRHelpers_4_4_000.Instance.ToValue(context, as_);
                        return (at_ as CqlQuantity) as object;
                    }
                    else if (ab_())
                    {
                        DataType au_ = HipKneeProcedure?.Performed;
                        object av_ = FHIRHelpers_4_4_000.Instance.ToValue(context, au_);
                        return (av_ as CqlInterval<CqlQuantity>) as object;
                    }
                    else
                    {
                        return null;
                    };
                }

                CqlInterval<CqlDateTime> r_ = QICoreCommon_4_0_000.Instance.toInterval(context, q_());
                CqlDateTime s_ = context.Operators.Start(r_);
                Period t_ = QualifyingEncounter?.Period;
                CqlInterval<CqlDateTime> u_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, t_);
                CqlDateTime v_ = context.Operators.End(u_);
                bool? w_ = context.Operators.SameOrBefore(s_, v_, (string)default);
                bool? x_ = context.Operators.And(p_, w_);
                return x_;
            }

            IEnumerable<Procedure> j_ = context.Operators.Where<Procedure>(h_, i_);
            Encounter k_(Procedure HipKneeProcedure) => QualifyingEncounter;
            IEnumerable<Encounter> l_ = context.Operators.Select<Procedure, Encounter>(j_, k_);
            return l_;
        }

        IEnumerable<Encounter> c_ = context.Operators.SelectMany<Encounter, Encounter>(a_, b_);
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

        IEnumerable<MedicationAdministration> t_(MedicationAdministration MR) {
            IEnumerable<Medication> cp_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));

            bool? cq_(Medication M) {
                object cu_ = context.Operators.LateBoundProperty<object>(M, "id.value");
                object cv_ = context.Operators.LateBoundProperty<object>(MR, "medication.reference.value");
                IEnumerable<string> cw_ = context.Operators.Split((string)cv_, "/");
                string cx_ = context.Operators.Last<string>(cw_);
                bool? cy_ = context.Operators.Equal(cu_, cx_);
                CodeableConcept cz_ = M?.Code;
                CqlConcept da_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, cz_);
                CqlValueSet db_ = this.Unfractionated_Heparin(context);
                bool? dc_ = context.Operators.ConceptInValueSet(da_, db_);
                bool? dd_ = context.Operators.And(cy_, dc_);
                return dd_;
            }

            IEnumerable<Medication> cr_ = context.Operators.Where<Medication>(cp_, cq_);
            MedicationAdministration cs_(Medication M) => MR;
            IEnumerable<MedicationAdministration> ct_ = context.Operators.Select<Medication, MedicationAdministration>(cr_, cs_);
            return ct_;
        }

        IEnumerable<MedicationAdministration> u_ = context.Operators.SelectMany<MedicationAdministration, MedicationAdministration>(s_, t_);
        IEnumerable<MedicationAdministration> v_ = context.Operators.Union<MedicationAdministration>(r_, u_);

        bool? w_(MedicationAdministration UnfractionatedHeparin) {
            MedicationAdministration.DosageComponent de_ = UnfractionatedHeparin?.Dosage;
            CodeableConcept df_ = de_?.Route;
            CqlConcept dg_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, df_);
            CqlValueSet dh_ = this.Intravenous_route(context);
            bool? di_ = context.Operators.ConceptInValueSet(dg_, dh_);
            return di_;
        }

        IEnumerable<MedicationAdministration> x_ = context.Operators.Where<MedicationAdministration>(v_, w_);
        CqlValueSet y_ = this.Direct_Thrombin_Inhibitor(context);
        IEnumerable<MedicationAdministration> z_ = context.Operators.Retrieve<MedicationAdministration>(new RetrieveParameters(default, y_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationadministration"));

        IEnumerable<MedicationAdministration> ab_(MedicationAdministration MR) {
            IEnumerable<Medication> dj_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));

            bool? dk_(Medication M) {
                object do_ = context.Operators.LateBoundProperty<object>(M, "id.value");
                object dp_ = context.Operators.LateBoundProperty<object>(MR, "medication.reference.value");
                IEnumerable<string> dq_ = context.Operators.Split((string)dp_, "/");
                string dr_ = context.Operators.Last<string>(dq_);
                bool? ds_ = context.Operators.Equal(do_, dr_);
                CodeableConcept dt_ = M?.Code;
                CqlConcept du_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, dt_);
                CqlValueSet dv_ = this.Direct_Thrombin_Inhibitor(context);
                bool? dw_ = context.Operators.ConceptInValueSet(du_, dv_);
                bool? dx_ = context.Operators.And(ds_, dw_);
                return dx_;
            }

            IEnumerable<Medication> dl_ = context.Operators.Where<Medication>(dj_, dk_);
            MedicationAdministration dm_(Medication M) => MR;
            IEnumerable<MedicationAdministration> dn_ = context.Operators.Select<Medication, MedicationAdministration>(dl_, dm_);
            return dn_;
        }

        IEnumerable<MedicationAdministration> ac_ = context.Operators.SelectMany<MedicationAdministration, MedicationAdministration>(s_, ab_);
        IEnumerable<MedicationAdministration> ad_ = context.Operators.Union<MedicationAdministration>(z_, ac_);
        IEnumerable<MedicationAdministration> ae_ = context.Operators.Union<MedicationAdministration>(x_, ad_);
        CqlValueSet af_ = this.Glycoprotein_IIb_IIIa_Inhibitors(context);
        IEnumerable<MedicationAdministration> ag_ = context.Operators.Retrieve<MedicationAdministration>(new RetrieveParameters(default, af_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationadministration"));

        IEnumerable<MedicationAdministration> ai_(MedicationAdministration MR) {
            IEnumerable<Medication> dy_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));

            bool? dz_(Medication M) {
                object ed_ = context.Operators.LateBoundProperty<object>(M, "id.value");
                object ee_ = context.Operators.LateBoundProperty<object>(MR, "medication.reference.value");
                IEnumerable<string> ef_ = context.Operators.Split((string)ee_, "/");
                string eg_ = context.Operators.Last<string>(ef_);
                bool? eh_ = context.Operators.Equal(ed_, eg_);
                CodeableConcept ei_ = M?.Code;
                CqlConcept ej_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, ei_);
                CqlValueSet ek_ = this.Glycoprotein_IIb_IIIa_Inhibitors(context);
                bool? el_ = context.Operators.ConceptInValueSet(ej_, ek_);
                bool? em_ = context.Operators.And(eh_, el_);
                return em_;
            }

            IEnumerable<Medication> ea_ = context.Operators.Where<Medication>(dy_, dz_);
            MedicationAdministration eb_(Medication M) => MR;
            IEnumerable<MedicationAdministration> ec_ = context.Operators.Select<Medication, MedicationAdministration>(ea_, eb_);
            return ec_;
        }

        IEnumerable<MedicationAdministration> aj_ = context.Operators.SelectMany<MedicationAdministration, MedicationAdministration>(s_, ai_);
        IEnumerable<MedicationAdministration> ak_ = context.Operators.Union<MedicationAdministration>(ag_, aj_);
        IEnumerable<MedicationAdministration> al_ = context.Operators.Union<MedicationAdministration>(ae_, ak_);

        bool? am_(MedicationAdministration AnticoagulantMedication) {
            Code<MedicationAdministration.MedicationAdministrationStatusCodes> en_ = AnticoagulantMedication?.StatusElement;
            MedicationAdministration.MedicationAdministrationStatusCodes? eo_ = en_?.Value;
            string ep_ = context.Operators.Convert<string>(eo_);
            bool? eq_ = context.Operators.Equal(ep_, "completed");
            return eq_;
        }

        IEnumerable<MedicationAdministration> an_ = context.Operators.Where<MedicationAdministration>(al_, am_);

        (CqlTupleMetadata, string id, CqlDateTime LowRiskDatetime)? ao_(MedicationAdministration AnticoagulantMedication) {
            Id er_ = AnticoagulantMedication?.IdElement;
            string es_ = er_?.Value;
            DataType et_ = AnticoagulantMedication?.Effective;
            object eu_ = FHIRHelpers_4_4_000.Instance.ToValue(context, et_);
            CqlInterval<CqlDateTime> ev_ = QICoreCommon_4_0_000.Instance.toInterval(context, eu_);
            CqlDateTime ew_ = context.Operators.Start(ev_);
            (CqlTupleMetadata, string id, CqlDateTime LowRiskDatetime)? ex_ = (CqlTupleMetadata_DMAfXNhTfZDWOGdfEceXbfaSJ, es_, ew_);
            return ex_;
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

        IEnumerable<Encounter> b_(Encounter QualifyingEncounter) {
            IEnumerable<(CqlTupleMetadata, string id, CqlDateTime LowRiskDatetime)?> d_ = this.Low_Risk_Indicator_For_VTE(context);

            bool? e_((CqlTupleMetadata, string id, CqlDateTime LowRiskDatetime)? LowRiskForVTE) {
                CqlDateTime i_ = LowRiskForVTE?.LowRiskDatetime;
                CqlInterval<CqlDate> j_ = this.fromDayOfStartOfHospitalizationToDayAfterAdmission(context, QualifyingEncounter);
                CqlDate k_ = j_?.low;
                CqlDateTime l_ = context.Operators.ConvertDateToDateTime(k_);
                CqlDate n_ = j_?.high;
                CqlDateTime o_ = context.Operators.ConvertDateToDateTime(n_);
                bool? q_ = j_?.lowClosed;
                bool? s_ = j_?.highClosed;
                CqlInterval<CqlDateTime> t_ = context.Operators.Interval(l_, o_, q_, s_);
                bool? u_ = context.Operators.In<CqlDateTime>(i_, t_, "day");
                return u_;
            }

            IEnumerable<(CqlTupleMetadata, string id, CqlDateTime LowRiskDatetime)?> f_ = context.Operators.Where<(CqlTupleMetadata, string id, CqlDateTime LowRiskDatetime)?>(d_, e_);
            Encounter g_((CqlTupleMetadata, string id, CqlDateTime LowRiskDatetime)? LowRiskForVTE) => QualifyingEncounter;
            IEnumerable<Encounter> h_ = context.Operators.Select<(CqlTupleMetadata, string id, CqlDateTime LowRiskDatetime)?, Encounter>(f_, g_);
            return h_;
        }

        IEnumerable<Encounter> c_ = context.Operators.SelectMany<Encounter, Encounter>(a_, b_);
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

        IEnumerable<MedicationRequest> bu_(MedicationRequest MR) {
            IEnumerable<Medication> eu_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));

            bool? ev_(Medication M) {
                object ez_ = context.Operators.LateBoundProperty<object>(M, "id.value");
                object fa_ = context.Operators.LateBoundProperty<object>(MR, "medication.reference.value");
                IEnumerable<string> fb_ = context.Operators.Split((string)fa_, "/");
                string fc_ = context.Operators.Last<string>(fb_);
                bool? fd_ = context.Operators.Equal(ez_, fc_);
                CodeableConcept fe_ = M?.Code;
                CqlConcept ff_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, fe_);
                CqlValueSet fg_ = this.Low_Dose_Unfractionated_Heparin_for_VTE_Prophylaxis(context);
                bool? fh_ = context.Operators.ConceptInValueSet(ff_, fg_);
                bool? fi_ = context.Operators.And(fd_, fh_);
                return fi_;
            }

            IEnumerable<Medication> ew_ = context.Operators.Where<Medication>(eu_, ev_);
            MedicationRequest ex_(Medication M) => MR;
            IEnumerable<MedicationRequest> ey_ = context.Operators.Select<Medication, MedicationRequest>(ew_, ex_);
            return ey_;
        }

        IEnumerable<MedicationRequest> bv_ = context.Operators.SelectMany<MedicationRequest, MedicationRequest>(bt_, bu_);
        IEnumerable<MedicationRequest> bw_ = context.Operators.Union<MedicationRequest>(bs_, bv_);
        IEnumerable<MedicationRequest> by_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, f_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));

        IEnumerable<MedicationRequest> ca_(MedicationRequest MR) {
            IEnumerable<Medication> fj_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));

            bool? fk_(Medication M) {
                object fo_ = context.Operators.LateBoundProperty<object>(M, "id.value");
                object fp_ = context.Operators.LateBoundProperty<object>(MR, "medication.reference.value");
                IEnumerable<string> fq_ = context.Operators.Split((string)fp_, "/");
                string fr_ = context.Operators.Last<string>(fq_);
                bool? fs_ = context.Operators.Equal(fo_, fr_);
                CodeableConcept ft_ = M?.Code;
                CqlConcept fu_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, ft_);
                CqlValueSet fv_ = this.Low_Molecular_Weight_Heparin_for_VTE_Prophylaxis(context);
                bool? fw_ = context.Operators.ConceptInValueSet(fu_, fv_);
                bool? fx_ = context.Operators.And(fs_, fw_);
                return fx_;
            }

            IEnumerable<Medication> fl_ = context.Operators.Where<Medication>(fj_, fk_);
            MedicationRequest fm_(Medication M) => MR;
            IEnumerable<MedicationRequest> fn_ = context.Operators.Select<Medication, MedicationRequest>(fl_, fm_);
            return fn_;
        }

        IEnumerable<MedicationRequest> cb_ = context.Operators.SelectMany<MedicationRequest, MedicationRequest>(bt_, ca_);
        IEnumerable<MedicationRequest> cc_ = context.Operators.Union<MedicationRequest>(by_, cb_);
        IEnumerable<MedicationRequest> cd_ = context.Operators.Union<MedicationRequest>(bw_, cc_);
        IEnumerable<MedicationRequest> cf_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, l_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));

        IEnumerable<MedicationRequest> ch_(MedicationRequest MR) {
            IEnumerable<Medication> fy_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));

            bool? fz_(Medication M) {
                object gd_ = context.Operators.LateBoundProperty<object>(M, "id.value");
                object ge_ = context.Operators.LateBoundProperty<object>(MR, "medication.reference.value");
                IEnumerable<string> gf_ = context.Operators.Split((string)ge_, "/");
                string gg_ = context.Operators.Last<string>(gf_);
                bool? gh_ = context.Operators.Equal(gd_, gg_);
                CodeableConcept gi_ = M?.Code;
                CqlConcept gj_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, gi_);
                CqlValueSet gk_ = this.Injectable_Factor_Xa_Inhibitor_for_VTE_Prophylaxis(context);
                bool? gl_ = context.Operators.ConceptInValueSet(gj_, gk_);
                bool? gm_ = context.Operators.And(gh_, gl_);
                return gm_;
            }

            IEnumerable<Medication> ga_ = context.Operators.Where<Medication>(fy_, fz_);
            MedicationRequest gb_(Medication M) => MR;
            IEnumerable<MedicationRequest> gc_ = context.Operators.Select<Medication, MedicationRequest>(ga_, gb_);
            return gc_;
        }

        IEnumerable<MedicationRequest> ci_ = context.Operators.SelectMany<MedicationRequest, MedicationRequest>(bt_, ch_);
        IEnumerable<MedicationRequest> cj_ = context.Operators.Union<MedicationRequest>(cf_, ci_);
        IEnumerable<MedicationRequest> ck_ = context.Operators.Union<MedicationRequest>(cd_, cj_);
        IEnumerable<MedicationRequest> cm_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, r_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));

        IEnumerable<MedicationRequest> co_(MedicationRequest MR) {
            IEnumerable<Medication> gn_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));

            bool? go_(Medication M) {
                object gs_ = context.Operators.LateBoundProperty<object>(M, "id.value");
                object gt_ = context.Operators.LateBoundProperty<object>(MR, "medication.reference.value");
                IEnumerable<string> gu_ = context.Operators.Split((string)gt_, "/");
                string gv_ = context.Operators.Last<string>(gu_);
                bool? gw_ = context.Operators.Equal(gs_, gv_);
                CodeableConcept gx_ = M?.Code;
                CqlConcept gy_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, gx_);
                CqlValueSet gz_ = this.Warfarin(context);
                bool? ha_ = context.Operators.ConceptInValueSet(gy_, gz_);
                bool? hb_ = context.Operators.And(gw_, ha_);
                return hb_;
            }

            IEnumerable<Medication> gp_ = context.Operators.Where<Medication>(gn_, go_);
            MedicationRequest gq_(Medication M) => MR;
            IEnumerable<MedicationRequest> gr_ = context.Operators.Select<Medication, MedicationRequest>(gp_, gq_);
            return gr_;
        }

        IEnumerable<MedicationRequest> cp_ = context.Operators.SelectMany<MedicationRequest, MedicationRequest>(bt_, co_);
        IEnumerable<MedicationRequest> cq_ = context.Operators.Union<MedicationRequest>(cm_, cp_);
        IEnumerable<MedicationRequest> cr_ = context.Operators.Union<MedicationRequest>(ck_, cq_);
        IEnumerable<MedicationRequest> ct_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, x_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));

        IEnumerable<MedicationRequest> cv_(MedicationRequest MR) {
            IEnumerable<Medication> hc_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));

            bool? hd_(Medication M) {
                object hh_ = context.Operators.LateBoundProperty<object>(M, "id.value");
                object hi_ = context.Operators.LateBoundProperty<object>(MR, "medication.reference.value");
                IEnumerable<string> hj_ = context.Operators.Split((string)hi_, "/");
                string hk_ = context.Operators.Last<string>(hj_);
                bool? hl_ = context.Operators.Equal(hh_, hk_);
                CodeableConcept hm_ = M?.Code;
                CqlConcept hn_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, hm_);
                CqlValueSet ho_ = this.Rivaroxaban_for_VTE_Prophylaxis(context);
                bool? hp_ = context.Operators.ConceptInValueSet(hn_, ho_);
                bool? hq_ = context.Operators.And(hl_, hp_);
                return hq_;
            }

            IEnumerable<Medication> he_ = context.Operators.Where<Medication>(hc_, hd_);
            MedicationRequest hf_(Medication M) => MR;
            IEnumerable<MedicationRequest> hg_ = context.Operators.Select<Medication, MedicationRequest>(he_, hf_);
            return hg_;
        }

        IEnumerable<MedicationRequest> cw_ = context.Operators.SelectMany<MedicationRequest, MedicationRequest>(bt_, cv_);
        IEnumerable<MedicationRequest> cx_ = context.Operators.Union<MedicationRequest>(ct_, cw_);
        IEnumerable<MedicationRequest> cy_ = context.Operators.Union<MedicationRequest>(cr_, cx_);
        IEnumerable<Task> cz_ = context.Operators.Retrieve<Task>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-taskrejected"));
        IEnumerable<ValueTuple<MedicationRequest, Task>> da_ = context.Operators.CrossJoin<MedicationRequest, Task>(cy_, cz_);

        (CqlTupleMetadata, MedicationRequest MedicationOrderReject, Task T)? db_(ValueTuple<MedicationRequest, Task> _valueTuple) {
            (CqlTupleMetadata, MedicationRequest MedicationOrderReject, Task T)? hr_ = (CqlTupleMetadata_IIUQMBcJhJBPgdDOLHaTTRUE, _valueTuple.Item1, _valueTuple.Item2);
            return hr_;
        }

        IEnumerable<(CqlTupleMetadata, MedicationRequest MedicationOrderReject, Task T)?> dc_ = context.Operators.Select<ValueTuple<MedicationRequest, Task>, (CqlTupleMetadata, MedicationRequest MedicationOrderReject, Task T)?>(da_, db_);

        bool? dd_((CqlTupleMetadata, MedicationRequest MedicationOrderReject, Task T)? tuple_iiuqmbcjhjbpgddolhattrue) {
            ResourceReference hs_ = tuple_iiuqmbcjhjbpgddolhattrue?.T?.Focus;
            bool? ht_ = QICoreCommon_4_0_000.Instance.references(context, hs_, tuple_iiuqmbcjhjbpgddolhattrue?.MedicationOrderReject);
            CodeableConcept hu_ = tuple_iiuqmbcjhjbpgddolhattrue?.T?.Code;
            CqlConcept hv_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, hu_);
            CqlCode hw_ = QICoreCommon_4_0_000.Instance.Fulfill(context);
            CqlConcept hx_ = context.Operators.ConvertCodeToConcept(hw_);
            bool? hy_ = context.Operators.Equivalent(hv_, hx_);
            bool? hz_ = context.Operators.And(ht_, hy_);
            Code<MedicationRequest.MedicationrequestStatus> ia_ = tuple_iiuqmbcjhjbpgddolhattrue?.MedicationOrderReject?.StatusElement;
            MedicationRequest.MedicationrequestStatus? ib_ = ia_?.Value;
            string ic_ = context.Operators.Convert<string>(ib_);
            bool? id_ = context.Operators.Equal(ic_, "active");
            bool? ie_ = context.Operators.And(hz_, id_);
            return ie_;
        }

        IEnumerable<(CqlTupleMetadata, MedicationRequest MedicationOrderReject, Task T)?> de_ = context.Operators.Where<(CqlTupleMetadata, MedicationRequest MedicationOrderReject, Task T)?>(dc_, dd_);

        (CqlTupleMetadata, string id, IEnumerable<CqlConcept> medicationStatusReason, CqlDateTime authoredOn)? df_((CqlTupleMetadata, MedicationRequest MedicationOrderReject, Task T)? tuple_iiuqmbcjhjbpgddolhattrue) {
            Id if_ = tuple_iiuqmbcjhjbpgddolhattrue?.MedicationOrderReject?.IdElement;
            string ig_ = if_?.Value;
            CodeableConcept ih_ = tuple_iiuqmbcjhjbpgddolhattrue?.T?.StatusReason;
            CqlConcept ii_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, ih_);
            CqlConcept[] ij_ = [
                ii_,
            ];
            FhirDateTime ik_ = tuple_iiuqmbcjhjbpgddolhattrue?.MedicationOrderReject?.AuthoredOnElement;
            CqlDateTime il_ = context.Operators.Convert<CqlDateTime>(ik_);
            (CqlTupleMetadata, string id, IEnumerable<CqlConcept> medicationStatusReason, CqlDateTime authoredOn)? im_ = (CqlTupleMetadata_CNeQfiIHcQEUBjZNVZiOLfdeP, ig_, (IEnumerable<CqlConcept>)ij_, il_);
            return im_;
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

        IEnumerable<Encounter> b_(Encounter QualifyingEncounter) {
            IEnumerable<(CqlTupleMetadata, string id, IEnumerable<CqlConcept> medicationStatusReason, CqlDateTime authoredOn)?> d_ = this.No_VTE_Prophylaxis_Medication_Administered_Or_Ordered(context);

            bool? e_((CqlTupleMetadata, string id, IEnumerable<CqlConcept> medicationStatusReason, CqlDateTime authoredOn)? NoVTEMedication) {
                IEnumerable<CqlConcept> i_ = NoVTEMedication?.medicationStatusReason;
                CqlValueSet j_ = this.Medical_Reason_For_Not_Providing_Treatment(context);
                bool? k_ = context.Operators.ConceptsInValueSet(i_, j_);
                CqlDateTime l_ = NoVTEMedication?.authoredOn;
                CqlInterval<CqlDate> m_ = this.fromDayOfStartOfHospitalizationToDayAfterAdmission(context, QualifyingEncounter);
                CqlDate n_ = m_?.low;
                CqlDateTime o_ = context.Operators.ConvertDateToDateTime(n_);
                CqlDate q_ = m_?.high;
                CqlDateTime r_ = context.Operators.ConvertDateToDateTime(q_);
                bool? t_ = m_?.lowClosed;
                bool? v_ = m_?.highClosed;
                CqlInterval<CqlDateTime> w_ = context.Operators.Interval(o_, r_, t_, v_);
                bool? x_ = context.Operators.In<CqlDateTime>(l_, w_, "day");
                bool? y_ = context.Operators.And(k_, x_);
                return y_;
            }

            IEnumerable<(CqlTupleMetadata, string id, IEnumerable<CqlConcept> medicationStatusReason, CqlDateTime authoredOn)?> f_ = context.Operators.Where<(CqlTupleMetadata, string id, IEnumerable<CqlConcept> medicationStatusReason, CqlDateTime authoredOn)?>(d_, e_);
            Encounter g_((CqlTupleMetadata, string id, IEnumerable<CqlConcept> medicationStatusReason, CqlDateTime authoredOn)? NoVTEMedication) => QualifyingEncounter;
            IEnumerable<Encounter> h_ = context.Operators.Select<(CqlTupleMetadata, string id, IEnumerable<CqlConcept> medicationStatusReason, CqlDateTime authoredOn)?, Encounter>(f_, g_);
            return h_;
        }

        IEnumerable<Encounter> c_ = context.Operators.SelectMany<Encounter, Encounter>(a_, b_);
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

        IEnumerable<Encounter> b_(Encounter QualifyingEncounter) {
            IEnumerable<(CqlTupleMetadata, string id, CqlConcept requestStatusReason, CqlDateTime authoredOn)?> d_ = this.No_Mechanical_VTE_Prophylaxis_Performed_Or_Ordered(context);

            bool? e_((CqlTupleMetadata, string id, CqlConcept requestStatusReason, CqlDateTime authoredOn)? NoVTEDevice) {
                CqlConcept i_ = NoVTEDevice?.requestStatusReason;
                CqlValueSet j_ = this.Medical_Reason_For_Not_Providing_Treatment(context);
                bool? k_ = context.Operators.ConceptInValueSet(i_, j_);
                CqlDateTime l_ = NoVTEDevice?.authoredOn;
                CqlInterval<CqlDate> m_ = this.fromDayOfStartOfHospitalizationToDayAfterAdmission(context, QualifyingEncounter);
                CqlDate n_ = m_?.low;
                CqlDateTime o_ = context.Operators.ConvertDateToDateTime(n_);
                CqlDate q_ = m_?.high;
                CqlDateTime r_ = context.Operators.ConvertDateToDateTime(q_);
                bool? t_ = m_?.lowClosed;
                bool? v_ = m_?.highClosed;
                CqlInterval<CqlDateTime> w_ = context.Operators.Interval(o_, r_, t_, v_);
                bool? x_ = context.Operators.In<CqlDateTime>(l_, w_, "day");
                bool? y_ = context.Operators.And(k_, x_);
                return y_;
            }

            IEnumerable<(CqlTupleMetadata, string id, CqlConcept requestStatusReason, CqlDateTime authoredOn)?> f_ = context.Operators.Where<(CqlTupleMetadata, string id, CqlConcept requestStatusReason, CqlDateTime authoredOn)?>(d_, e_);
            Encounter g_((CqlTupleMetadata, string id, CqlConcept requestStatusReason, CqlDateTime authoredOn)? NoVTEDevice) => QualifyingEncounter;
            IEnumerable<Encounter> h_ = context.Operators.Select<(CqlTupleMetadata, string id, CqlConcept requestStatusReason, CqlDateTime authoredOn)?, Encounter>(f_, g_);
            return h_;
        }

        IEnumerable<Encounter> c_ = context.Operators.SelectMany<Encounter, Encounter>(a_, b_);
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

        IEnumerable<Encounter> b_(Encounter QualifyingEncounter) {
            IEnumerable<object> d_ = this.No_Mechanical_Or_Pharmacological_VTE_Prophylaxis_Due_To_Patient_Refusal(context);

            bool? e_(object PatientRefusal) {
                CqlDateTime i_ = context.Operators.LateBoundProperty<CqlDateTime>(PatientRefusal, "authoredOn");
                CqlInterval<CqlDate> j_ = this.fromDayOfStartOfHospitalizationToDayAfterAdmission(context, QualifyingEncounter);
                CqlDate k_ = j_?.low;
                CqlDateTime l_ = context.Operators.ConvertDateToDateTime(k_);
                CqlDate n_ = j_?.high;
                CqlDateTime o_ = context.Operators.ConvertDateToDateTime(n_);
                bool? q_ = j_?.lowClosed;
                bool? s_ = j_?.highClosed;
                CqlInterval<CqlDateTime> t_ = context.Operators.Interval(l_, o_, q_, s_);
                bool? u_ = context.Operators.In<CqlDateTime>(i_, t_, "day");
                return u_;
            }

            IEnumerable<object> f_ = context.Operators.Where<object>(d_, e_);
            Encounter g_(object PatientRefusal) => QualifyingEncounter;
            IEnumerable<Encounter> h_ = context.Operators.Select<object, Encounter>(f_, g_);
            return h_;
        }

        IEnumerable<Encounter> c_ = context.Operators.SelectMany<Encounter, Encounter>(a_, b_);
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

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
                    CqlConcept q_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);
                    return q_;
                }

                IEnumerable<CqlConcept> k_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)i_, j_);
                CqlValueSet l_ = this.Intensive_Care_Unit(context);
                bool? m_ = context.Operators.ConceptsInValueSet(k_, l_);

                bool? n_() {
                    Period r_ = Location?.Period;
                    CqlInterval<CqlDateTime> s_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, r_);
                    int? t_ = CQMCommon_4_1_000.Instance.lengthInDays(context, s_);
                    bool? u_ = context.Operators.GreaterOrEqual(t_, 1);
                    return (bool?)((CqlBoolean)u_);
                }


                bool? o_() {
                    Period v_ = Location?.Period;
                    CqlInterval<CqlDateTime> w_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, v_);
                    CqlDateTime x_ = context.Operators.Start(w_);
                    Period y_ = QualifyingEncounter?.Period;
                    CqlInterval<CqlDateTime> z_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, y_);
                    CqlDateTime aa_ = context.Operators.Start(z_);
                    bool? ab_ = context.Operators.SameOrAfter(x_, aa_, (string)default);
                    return (bool?)((CqlBoolean)ab_);
                }


                bool? p_() {
                    Period ac_ = Location?.Period;
                    CqlInterval<CqlDateTime> ad_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ac_);
                    CqlDateTime ae_ = context.Operators.Start(ad_);
                    CqlDate af_ = context.Operators.DateFrom(ae_);
                    Period ag_ = QualifyingEncounter?.Period;
                    CqlInterval<CqlDateTime> ah_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ag_);
                    CqlDateTime ai_ = context.Operators.Start(ah_);
                    CqlInterval<CqlDate> aj_ = TJCOverall_8_25_000.Instance.calendarDayOfOrDayAfter(context, ai_);
                    bool? ak_ = context.Operators.In<CqlDate>(af_, aj_, (string)default);
                    return (bool?)((CqlBoolean)ak_);
                }

                return (bool?)(/* CQL 'and' (91:9-94:127) */ (/* CQL 'and' (91:15-93:84) */ (/* CQL 'and' (91:15-92:51) */ ((CqlBoolean)m_
                    && (CqlBoolean)n_())
                    && (CqlBoolean)o_())
                    && (CqlBoolean)p_()));
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

            bool? f_() {
                CqlValueSet h_ = this.Hemorrhagic_Stroke(context);
                bool? i_ = CQMCommon_4_1_000.Instance.hasPrincipalDiagnosisOf(context, QualifyingEncounter, h_);
                return (bool?)((CqlBoolean)i_);
            }


            bool? g_() {
                CqlValueSet j_ = this.Ischemic_Stroke(context);
                bool? k_ = CQMCommon_4_1_000.Instance.hasPrincipalDiagnosisOf(context, QualifyingEncounter, j_);
                return (bool?)((CqlBoolean)k_);
            }

            return (bool?)(/* CQL 'or' (99:5-101:74) */ (/* CQL 'or' (99:11-100:77) */ ((CqlBoolean)e_
                || (CqlBoolean)f_())
                || (CqlBoolean)g_()));
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

            bool? f_() {
                CqlValueSet l_ = this.Gynecological_Surgery(context);
                bool? m_ = VTE_8_18_000.Instance.hasPrincipalProcedureOf(context, QualifyingEncounter, l_);
                return (bool?)((CqlBoolean)m_);
            }


            bool? g_() {
                CqlValueSet n_ = this.Hip_Fracture_Surgery(context);
                bool? o_ = VTE_8_18_000.Instance.hasPrincipalProcedureOf(context, QualifyingEncounter, n_);
                return (bool?)((CqlBoolean)o_);
            }


            bool? h_() {
                CqlValueSet p_ = this.Hip_Replacement_Surgery(context);
                bool? q_ = VTE_8_18_000.Instance.hasPrincipalProcedureOf(context, QualifyingEncounter, p_);
                return (bool?)((CqlBoolean)q_);
            }


            bool? i_() {
                CqlValueSet r_ = this.Intracranial_Neurosurgery(context);
                bool? s_ = VTE_8_18_000.Instance.hasPrincipalProcedureOf(context, QualifyingEncounter, r_);
                return (bool?)((CqlBoolean)s_);
            }


            bool? j_() {
                CqlValueSet t_ = this.Knee_Replacement_Surgery(context);
                bool? u_ = VTE_8_18_000.Instance.hasPrincipalProcedureOf(context, QualifyingEncounter, t_);
                return (bool?)((CqlBoolean)u_);
            }


            bool? k_() {
                CqlValueSet v_ = this.Urological_Surgery(context);
                bool? w_ = VTE_8_18_000.Instance.hasPrincipalProcedureOf(context, QualifyingEncounter, v_);
                return (bool?)((CqlBoolean)w_);
            }

            return (bool?)(/* CQL 'or' (105:5-111:77) */ (/* CQL 'or' (105:11-110:83) */ (/* CQL 'or' (105:11-109:84) */ (/* CQL 'or' (105:11-108:82) */ (/* CQL 'or' (105:11-107:79) */ (/* CQL 'or' (105:11-106:80) */ ((CqlBoolean)e_
                || (CqlBoolean)f_())
                || (CqlBoolean)g_())
                || (CqlBoolean)h_())
                || (CqlBoolean)i_())
                || (CqlBoolean)j_())
                || (CqlBoolean)k_()));
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

            bool? o_() {
                Code<RequestStatus> p_ = InterventionRequest?.StatusElement;
                RequestStatus? q_ = p_?.Value;
                Code<RequestStatus> r_ = context.Operators.Convert<Code<RequestStatus>>(q_);
                string s_ = context.Operators.Convert<string>(r_);
                string[] t_ = [
                    "active",
                    "completed",
                ];
                bool? u_ = context.Operators.In<string>(s_, (IEnumerable<string>)t_);
                return (bool?)((CqlBoolean)u_);
            }

            return (bool?)(/* CQL 'and' (115:7-116:67) */ ((CqlBoolean)n_
                && (CqlBoolean)o_()));
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

            bool? p_() {
                object r_;
                DataType aa_ = tuple_hbjscqgbuhismoaytymvucjfi?.AnesthesiaProcedure?.Performed;
                object ab_ = FHIRHelpers_4_4_000.Instance.ToValue(context, aa_);
                bool ac_ = ab_ is CqlDateTime;
                if (ac_)
                {
                    r_ = ab_ as CqlDateTime;
                }
                else
                {
                    bool ad_ = ab_ is CqlQuantity;
                    if (ad_)
                    {
                        r_ = ab_ as CqlQuantity;
                    }
                    else
                    {
                        bool ae_ = ab_ is CqlInterval<CqlDateTime>;
                        if (ae_)
                        {
                            r_ = ab_ as CqlInterval<CqlDateTime>;
                        }
                        else
                        {
                            bool af_ = ab_ is CqlInterval<CqlQuantity>;
                            if (af_)
                            {
                                r_ = ab_ as CqlInterval<CqlQuantity>;
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
                return (bool?)((CqlBoolean)z_);
            }


            bool? q_() {
                object ag_;
                object bj_ = context.Operators.LateBoundProperty<object>(tuple_hbjscqgbuhismoaytymvucjfi?.ComfortMeasure, "performed");
                object bk_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bj_);
                bool bl_ = bk_ is CqlDateTime;
                if (bl_)
                {
                    ag_ = bk_ as CqlDateTime;
                }
                else
                {
                    bool bm_ = bk_ is CqlQuantity;
                    if (bm_)
                    {
                        ag_ = bk_ as CqlQuantity;
                    }
                    else
                    {
                        bool bn_ = bk_ is CqlInterval<CqlDateTime>;
                        if (bn_)
                        {
                            ag_ = bk_ as CqlInterval<CqlDateTime>;
                        }
                        else
                        {
                            bool bo_ = bk_ is CqlInterval<CqlQuantity>;
                            if (bo_)
                            {
                                ag_ = bk_ as CqlInterval<CqlQuantity>;
                            }
                            else
                            {
                                ag_ = null;
                            }
                        }
                    }
                }
                CqlInterval<CqlDateTime> ah_ = QICoreCommon_4_0_000.Instance.toInterval(context, ag_);
                CqlDateTime ai_ = context.Operators.Start(ah_);
                object aj_ = context.Operators.LateBoundProperty<object>(tuple_hbjscqgbuhismoaytymvucjfi?.ComfortMeasure, "authoredOn");
                CqlDateTime ak_ = context.Operators.LateBoundProperty<CqlDateTime>(aj_, "value");
                object al_;
                DataType bp_ = tuple_hbjscqgbuhismoaytymvucjfi?.AnesthesiaProcedure?.Performed;
                object bq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bp_);
                bool br_ = bq_ is CqlDateTime;
                if (br_)
                {
                    al_ = bq_ as CqlDateTime;
                }
                else
                {
                    bool bs_ = bq_ is CqlQuantity;
                    if (bs_)
                    {
                        al_ = bq_ as CqlQuantity;
                    }
                    else
                    {
                        bool bt_ = bq_ is CqlInterval<CqlDateTime>;
                        if (bt_)
                        {
                            al_ = bq_ as CqlInterval<CqlDateTime>;
                        }
                        else
                        {
                            bool bu_ = bq_ is CqlInterval<CqlQuantity>;
                            if (bu_)
                            {
                                al_ = bq_ as CqlInterval<CqlQuantity>;
                            }
                            else
                            {
                                al_ = null;
                            }
                        }
                    }
                }
                CqlInterval<CqlDateTime> am_ = QICoreCommon_4_0_000.Instance.toInterval(context, al_);
                CqlDateTime an_ = context.Operators.End(am_);
                CqlInterval<CqlDate> ao_ = TJCOverall_8_25_000.Instance.calendarDayOfOrDayAfter(context, an_);
                CqlDate ap_ = ao_?.low;
                CqlDateTime aq_ = context.Operators.ConvertDateToDateTime(ap_);
                object ar_;
                DataType bv_ = tuple_hbjscqgbuhismoaytymvucjfi?.AnesthesiaProcedure?.Performed;
                object bw_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bv_);
                bool bx_ = bw_ is CqlDateTime;
                if (bx_)
                {
                    ar_ = bw_ as CqlDateTime;
                }
                else
                {
                    bool by_ = bw_ is CqlQuantity;
                    if (by_)
                    {
                        ar_ = bw_ as CqlQuantity;
                    }
                    else
                    {
                        bool bz_ = bw_ is CqlInterval<CqlDateTime>;
                        if (bz_)
                        {
                            ar_ = bw_ as CqlInterval<CqlDateTime>;
                        }
                        else
                        {
                            bool ca_ = bw_ is CqlInterval<CqlQuantity>;
                            if (ca_)
                            {
                                ar_ = bw_ as CqlInterval<CqlQuantity>;
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
                CqlDate av_ = au_?.high;
                CqlDateTime aw_ = context.Operators.ConvertDateToDateTime(av_);
                object ax_;
                DataType cb_ = tuple_hbjscqgbuhismoaytymvucjfi?.AnesthesiaProcedure?.Performed;
                object cc_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cb_);
                bool cd_ = cc_ is CqlDateTime;
                if (cd_)
                {
                    ax_ = cc_ as CqlDateTime;
                }
                else
                {
                    bool ce_ = cc_ is CqlQuantity;
                    if (ce_)
                    {
                        ax_ = cc_ as CqlQuantity;
                    }
                    else
                    {
                        bool cf_ = cc_ is CqlInterval<CqlDateTime>;
                        if (cf_)
                        {
                            ax_ = cc_ as CqlInterval<CqlDateTime>;
                        }
                        else
                        {
                            bool cg_ = cc_ is CqlInterval<CqlQuantity>;
                            if (cg_)
                            {
                                ax_ = cc_ as CqlInterval<CqlQuantity>;
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
                bool? bb_ = ba_?.lowClosed;
                object bc_;
                DataType ch_ = tuple_hbjscqgbuhismoaytymvucjfi?.AnesthesiaProcedure?.Performed;
                object ci_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ch_);
                bool cj_ = ci_ is CqlDateTime;
                if (cj_)
                {
                    bc_ = ci_ as CqlDateTime;
                }
                else
                {
                    bool ck_ = ci_ is CqlQuantity;
                    if (ck_)
                    {
                        bc_ = ci_ as CqlQuantity;
                    }
                    else
                    {
                        bool cl_ = ci_ is CqlInterval<CqlDateTime>;
                        if (cl_)
                        {
                            bc_ = ci_ as CqlInterval<CqlDateTime>;
                        }
                        else
                        {
                            bool cm_ = ci_ is CqlInterval<CqlQuantity>;
                            if (cm_)
                            {
                                bc_ = ci_ as CqlInterval<CqlQuantity>;
                            }
                            else
                            {
                                bc_ = null;
                            }
                        }
                    }
                }
                CqlInterval<CqlDateTime> bd_ = QICoreCommon_4_0_000.Instance.toInterval(context, bc_);
                CqlDateTime be_ = context.Operators.End(bd_);
                CqlInterval<CqlDate> bf_ = TJCOverall_8_25_000.Instance.calendarDayOfOrDayAfter(context, be_);
                bool? bg_ = bf_?.highClosed;
                CqlInterval<CqlDateTime> bh_ = context.Operators.Interval(aq_, aw_, bb_, bg_);
                bool? bi_ = context.Operators.In<CqlDateTime>(ai_ ?? ak_, bh_, "day");
                return (bool?)((CqlBoolean)bi_);
            }

            return (bool?)(/* CQL 'and' (127:5-129:191) */ (/* CQL 'and' (127:11-128:114) */ ((CqlBoolean)o_
                && (CqlBoolean)p_())
                && (CqlBoolean)q_()));
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
                object bc_ = context.Operators.LateBoundProperty<object>(M, "id.value");
                object bd_ = context.Operators.LateBoundProperty<object>(MR, "medication.reference.value");
                IEnumerable<string> be_ = context.Operators.Split((string)bd_, "/");
                string bf_ = context.Operators.Last<string>(be_);
                bool? bg_ = context.Operators.Equal(bc_, bf_);

                bool? bh_() {
                    CodeableConcept bi_ = M?.Code;
                    CqlConcept bj_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, bi_);
                    CqlValueSet bk_ = this.Low_Dose_Unfractionated_Heparin_for_VTE_Prophylaxis(context);
                    bool? bl_ = context.Operators.ConceptInValueSet(bj_, bk_);
                    return (bool?)((CqlBoolean)bl_);
                }

                return (bool?)(/* CQL 'and' */ ((CqlBoolean)bg_
                    && (CqlBoolean)bh_()));
            }

            bool? bb_ = context.Operators.WhereAny<Medication>(az_, ba_);
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
            bool? bp_ = context.Operators.Equal(bo_, "completed");

            bool? bq_() {
                MedicationAdministration.DosageComponent br_ = VTEMedication?.Dosage;
                CodeableConcept bs_ = br_?.Route;
                CqlConcept bt_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, bs_);
                CqlValueSet bu_ = this.Subcutaneous_route(context);
                bool? bv_ = context.Operators.ConceptInValueSet(bt_, bu_);
                return (bool?)((CqlBoolean)bv_);
            }

            return (bool?)(/* CQL 'and' (150:7-151:62) */ ((CqlBoolean)bp_
                && (CqlBoolean)bq_()));
        }

        IEnumerable<MedicationAdministration> h_ = context.Operators.Where<MedicationAdministration>(f_, g_);

        bool? i_(MedicationAdministration MR) {
            IEnumerable<Medication> bw_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));

            bool? bx_(Medication M) {
                object bz_ = context.Operators.LateBoundProperty<object>(M, "id.value");
                object ca_ = context.Operators.LateBoundProperty<object>(MR, "medication.reference.value");
                IEnumerable<string> cb_ = context.Operators.Split((string)ca_, "/");
                string cc_ = context.Operators.Last<string>(cb_);
                bool? cd_ = context.Operators.Equal(bz_, cc_);

                bool? ce_() {
                    CodeableConcept cf_ = M?.Code;
                    CqlConcept cg_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, cf_);
                    CqlValueSet ch_ = this.Low_Molecular_Weight_Heparin_for_VTE_Prophylaxis(context);
                    bool? ci_ = context.Operators.ConceptInValueSet(cg_, ch_);
                    return (bool?)((CqlBoolean)ci_);
                }

                return (bool?)(/* CQL 'and' */ ((CqlBoolean)cd_
                    && (CqlBoolean)ce_()));
            }

            bool? by_ = context.Operators.WhereAny<Medication>(bw_, bx_);
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
            bool? cm_ = context.Operators.Equal(cl_, "completed");
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
                bool? cu_ = context.Operators.Equal(cq_, ct_);

                bool? cv_() {
                    CodeableConcept cw_ = M?.Code;
                    CqlConcept cx_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, cw_);
                    CqlValueSet cy_ = this.Injectable_Factor_Xa_Inhibitor_for_VTE_Prophylaxis(context);
                    bool? cz_ = context.Operators.ConceptInValueSet(cx_, cy_);
                    return (bool?)((CqlBoolean)cz_);
                }

                return (bool?)(/* CQL 'and' */ ((CqlBoolean)cu_
                    && (CqlBoolean)cv_()));
            }

            bool? cp_ = context.Operators.WhereAny<Medication>(cn_, co_);
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
            bool? dd_ = context.Operators.Equal(dc_, "completed");
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
                bool? dl_ = context.Operators.Equal(dh_, dk_);

                bool? dm_() {
                    CodeableConcept dn_ = M?.Code;
                    CqlConcept do_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, dn_);
                    CqlValueSet dp_ = this.Warfarin(context);
                    bool? dq_ = context.Operators.ConceptInValueSet(do_, dp_);
                    return (bool?)((CqlBoolean)dq_);
                }

                return (bool?)(/* CQL 'and' */ ((CqlBoolean)dl_
                    && (CqlBoolean)dm_()));
            }

            bool? dg_ = context.Operators.WhereAny<Medication>(de_, df_);
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
            bool? du_ = context.Operators.Equal(dt_, "completed");
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
                bool? ec_ = context.Operators.Equal(dy_, eb_);

                bool? ed_() {
                    CodeableConcept ee_ = M?.Code;
                    CqlConcept ef_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, ee_);
                    CqlValueSet eg_ = this.Rivaroxaban_for_VTE_Prophylaxis(context);
                    bool? eh_ = context.Operators.ConceptInValueSet(ef_, eg_);
                    return (bool?)((CqlBoolean)eh_);
                }

                return (bool?)(/* CQL 'and' */ ((CqlBoolean)ec_
                    && (CqlBoolean)ed_()));
            }

            bool? dx_ = context.Operators.WhereAny<Medication>(dv_, dw_);
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
            bool? el_ = context.Operators.Equal(ek_, "completed");
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
            bool? ep_ = context.Operators.Equal(eo_, "completed");
            return ep_;
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
            object s_ = context.Operators.LateBoundProperty<object>(tuple_dqdjdfndavflfyejysbyihgsj?.VTEProphylaxis, "effective");
            object t_ = FHIRHelpers_4_4_000.Instance.ToValue(context, s_);
            CqlInterval<CqlDateTime> u_ = QICoreCommon_4_0_000.Instance.toInterval(context, t_);
            object v_;
            object ah_ = context.Operators.LateBoundProperty<object>(tuple_dqdjdfndavflfyejysbyihgsj?.VTEProphylaxis, "performed");
            object ai_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ah_);
            bool aj_ = ai_ is CqlDateTime;
            if (aj_)
            {
                v_ = ai_ as CqlDateTime;
            }
            else
            {
                bool ak_ = ai_ is CqlQuantity;
                if (ak_)
                {
                    v_ = ai_ as CqlQuantity;
                }
                else
                {
                    bool al_ = ai_ is CqlInterval<CqlDateTime>;
                    if (al_)
                    {
                        v_ = ai_ as CqlInterval<CqlDateTime>;
                    }
                    else
                    {
                        bool am_ = ai_ is CqlInterval<CqlQuantity>;
                        if (am_)
                        {
                            v_ = ai_ as CqlInterval<CqlQuantity>;
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
            (CqlTupleMetadata, Encounter QualifyingEncounter, Procedure AnesthesiaProcedure, object VTEProphylaxis)? an_ = (CqlTupleMetadata_CfSFUFiTWJJfiZASQhERUdATP, _valueTuple.Item1, _valueTuple.Item2, _valueTuple.Item3);
            return an_;
        }


        bool? m_((CqlTupleMetadata, Encounter QualifyingEncounter, Procedure AnesthesiaProcedure, object VTEProphylaxis)? tuple_bnvctjfzpousixdcefwhciwq) {
            Code<EventStatus> ao_ = tuple_bnvctjfzpousixdcefwhciwq?.AnesthesiaProcedure?.StatusElement;
            EventStatus? ap_ = ao_?.Value;
            string aq_ = context.Operators.Convert<string>(ap_);
            bool? ar_ = context.Operators.Equal(aq_, "completed");

            bool? as_() {
                object au_;
                DataType bd_ = tuple_bnvctjfzpousixdcefwhciwq?.AnesthesiaProcedure?.Performed;
                object be_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bd_);
                bool bf_ = be_ is CqlDateTime;
                if (bf_)
                {
                    au_ = be_ as CqlDateTime;
                }
                else
                {
                    bool bg_ = be_ is CqlQuantity;
                    if (bg_)
                    {
                        au_ = be_ as CqlQuantity;
                    }
                    else
                    {
                        bool bh_ = be_ is CqlInterval<CqlDateTime>;
                        if (bh_)
                        {
                            au_ = be_ as CqlInterval<CqlDateTime>;
                        }
                        else
                        {
                            bool bi_ = be_ is CqlInterval<CqlQuantity>;
                            if (bi_)
                            {
                                au_ = be_ as CqlInterval<CqlQuantity>;
                            }
                            else
                            {
                                au_ = null;
                            }
                        }
                    }
                }
                CqlInterval<CqlDateTime> av_ = QICoreCommon_4_0_000.Instance.toInterval(context, au_);
                CqlDateTime aw_ = context.Operators.End(av_);
                Period ax_ = tuple_bnvctjfzpousixdcefwhciwq?.QualifyingEncounter?.Period;
                CqlInterval<CqlDateTime> ay_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ax_);
                CqlDateTime az_ = context.Operators.Start(ay_);
                CqlQuantity ba_ = context.Operators.Quantity(1m, "day");
                CqlDateTime bb_ = context.Operators.Add(az_, ba_);
                bool? bc_ = context.Operators.SameAs(aw_, bb_, "day");
                return (bool?)((CqlBoolean)bc_);
            }


            bool? at_() {
                object bj_ = context.Operators.LateBoundProperty<object>(tuple_bnvctjfzpousixdcefwhciwq?.VTEProphylaxis, "effective");
                object bk_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bj_);
                CqlInterval<CqlDateTime> bl_ = QICoreCommon_4_0_000.Instance.toInterval(context, bk_);
                object bm_;
                object cn_ = context.Operators.LateBoundProperty<object>(tuple_bnvctjfzpousixdcefwhciwq?.VTEProphylaxis, "performed");
                object co_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cn_);
                bool cp_ = co_ is CqlDateTime;
                if (cp_)
                {
                    bm_ = co_ as CqlDateTime;
                }
                else
                {
                    bool cq_ = co_ is CqlQuantity;
                    if (cq_)
                    {
                        bm_ = co_ as CqlQuantity;
                    }
                    else
                    {
                        bool cr_ = co_ is CqlInterval<CqlDateTime>;
                        if (cr_)
                        {
                            bm_ = co_ as CqlInterval<CqlDateTime>;
                        }
                        else
                        {
                            bool cs_ = co_ is CqlInterval<CqlQuantity>;
                            if (cs_)
                            {
                                bm_ = co_ as CqlInterval<CqlQuantity>;
                            }
                            else
                            {
                                bm_ = null;
                            }
                        }
                    }
                }
                CqlInterval<CqlDateTime> bn_ = QICoreCommon_4_0_000.Instance.toInterval(context, bm_);
                CqlDateTime bo_ = context.Operators.Start(bl_ ?? bn_);
                object bp_;
                DataType ct_ = tuple_bnvctjfzpousixdcefwhciwq?.AnesthesiaProcedure?.Performed;
                object cu_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ct_);
                bool cv_ = cu_ is CqlDateTime;
                if (cv_)
                {
                    bp_ = cu_ as CqlDateTime;
                }
                else
                {
                    bool cw_ = cu_ is CqlQuantity;
                    if (cw_)
                    {
                        bp_ = cu_ as CqlQuantity;
                    }
                    else
                    {
                        bool cx_ = cu_ is CqlInterval<CqlDateTime>;
                        if (cx_)
                        {
                            bp_ = cu_ as CqlInterval<CqlDateTime>;
                        }
                        else
                        {
                            bool cy_ = cu_ is CqlInterval<CqlQuantity>;
                            if (cy_)
                            {
                                bp_ = cu_ as CqlInterval<CqlQuantity>;
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
                CqlInterval<CqlDate> bs_ = TJCOverall_8_25_000.Instance.calendarDayOfOrDayAfter(context, br_);
                CqlDate bt_ = bs_?.low;
                CqlDateTime bu_ = context.Operators.ConvertDateToDateTime(bt_);
                object bv_;
                DataType cz_ = tuple_bnvctjfzpousixdcefwhciwq?.AnesthesiaProcedure?.Performed;
                object da_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cz_);
                bool db_ = da_ is CqlDateTime;
                if (db_)
                {
                    bv_ = da_ as CqlDateTime;
                }
                else
                {
                    bool dc_ = da_ is CqlQuantity;
                    if (dc_)
                    {
                        bv_ = da_ as CqlQuantity;
                    }
                    else
                    {
                        bool dd_ = da_ is CqlInterval<CqlDateTime>;
                        if (dd_)
                        {
                            bv_ = da_ as CqlInterval<CqlDateTime>;
                        }
                        else
                        {
                            bool de_ = da_ is CqlInterval<CqlQuantity>;
                            if (de_)
                            {
                                bv_ = da_ as CqlInterval<CqlQuantity>;
                            }
                            else
                            {
                                bv_ = null;
                            }
                        }
                    }
                }
                CqlInterval<CqlDateTime> bw_ = QICoreCommon_4_0_000.Instance.toInterval(context, bv_);
                CqlDateTime bx_ = context.Operators.End(bw_);
                CqlInterval<CqlDate> by_ = TJCOverall_8_25_000.Instance.calendarDayOfOrDayAfter(context, bx_);
                CqlDate bz_ = by_?.high;
                CqlDateTime ca_ = context.Operators.ConvertDateToDateTime(bz_);
                object cb_;
                DataType df_ = tuple_bnvctjfzpousixdcefwhciwq?.AnesthesiaProcedure?.Performed;
                object dg_ = FHIRHelpers_4_4_000.Instance.ToValue(context, df_);
                bool dh_ = dg_ is CqlDateTime;
                if (dh_)
                {
                    cb_ = dg_ as CqlDateTime;
                }
                else
                {
                    bool di_ = dg_ is CqlQuantity;
                    if (di_)
                    {
                        cb_ = dg_ as CqlQuantity;
                    }
                    else
                    {
                        bool dj_ = dg_ is CqlInterval<CqlDateTime>;
                        if (dj_)
                        {
                            cb_ = dg_ as CqlInterval<CqlDateTime>;
                        }
                        else
                        {
                            bool dk_ = dg_ is CqlInterval<CqlQuantity>;
                            if (dk_)
                            {
                                cb_ = dg_ as CqlInterval<CqlQuantity>;
                            }
                            else
                            {
                                cb_ = null;
                            }
                        }
                    }
                }
                CqlInterval<CqlDateTime> cc_ = QICoreCommon_4_0_000.Instance.toInterval(context, cb_);
                CqlDateTime cd_ = context.Operators.End(cc_);
                CqlInterval<CqlDate> ce_ = TJCOverall_8_25_000.Instance.calendarDayOfOrDayAfter(context, cd_);
                bool? cf_ = ce_?.lowClosed;
                object cg_;
                DataType dl_ = tuple_bnvctjfzpousixdcefwhciwq?.AnesthesiaProcedure?.Performed;
                object dm_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dl_);
                bool dn_ = dm_ is CqlDateTime;
                if (dn_)
                {
                    cg_ = dm_ as CqlDateTime;
                }
                else
                {
                    bool do_ = dm_ is CqlQuantity;
                    if (do_)
                    {
                        cg_ = dm_ as CqlQuantity;
                    }
                    else
                    {
                        bool dp_ = dm_ is CqlInterval<CqlDateTime>;
                        if (dp_)
                        {
                            cg_ = dm_ as CqlInterval<CqlDateTime>;
                        }
                        else
                        {
                            bool dq_ = dm_ is CqlInterval<CqlQuantity>;
                            if (dq_)
                            {
                                cg_ = dm_ as CqlInterval<CqlQuantity>;
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
                bool? ck_ = cj_?.highClosed;
                CqlInterval<CqlDateTime> cl_ = context.Operators.Interval(bu_, ca_, cf_, ck_);
                bool? cm_ = context.Operators.In<CqlDateTime>(bo_, cl_, "day");
                return (bool?)((CqlBoolean)cm_);
            }

            return (bool?)(/* CQL 'and' (182:9-184:205) */ (/* CQL 'and' (182:15-183:118) */ ((CqlBoolean)ar_
                && (CqlBoolean)as_())
                && (CqlBoolean)at_()));
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
                object ac_ = context.Operators.LateBoundProperty<object>(M, "id.value");
                object ad_ = context.Operators.LateBoundProperty<object>(MR, "medication.reference.value");
                IEnumerable<string> ae_ = context.Operators.Split((string)ad_, "/");
                string af_ = context.Operators.Last<string>(ae_);
                bool? ag_ = context.Operators.Equal(ac_, af_);

                bool? ah_() {
                    CodeableConcept ai_ = M?.Code;
                    CqlConcept aj_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, ai_);
                    CqlValueSet ak_ = this.Oral_Factor_Xa_Inhibitor_for_VTE_Prophylaxis_or_VTE_Treatment(context);
                    bool? al_ = context.Operators.ConceptInValueSet(aj_, ak_);
                    return (bool?)((CqlBoolean)al_);
                }

                return (bool?)(/* CQL 'and' */ ((CqlBoolean)ag_
                    && (CqlBoolean)ah_()));
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
            (CqlTupleMetadata, Encounter QualifyingEncounter, MedicationAdministration FactorXaMedication)? am_ = (CqlTupleMetadata_EBRQeiSMaTgecHVEbVOIMZEcb, _valueTuple.Item1, _valueTuple.Item2);
            return am_;
        }


        bool? j_((CqlTupleMetadata, Encounter QualifyingEncounter, MedicationAdministration FactorXaMedication)? tuple_cdbvhiekdcojzrccbhjghhgeo) {
            Code<MedicationAdministration.MedicationAdministrationStatusCodes> an_ = tuple_cdbvhiekdcojzrccbhjghhgeo?.FactorXaMedication?.StatusElement;
            MedicationAdministration.MedicationAdministrationStatusCodes? ao_ = an_?.Value;
            string ap_ = context.Operators.Convert<string>(ao_);
            bool? aq_ = context.Operators.Equal(ap_, "completed");

            bool? ar_() {
                DataType as_ = tuple_cdbvhiekdcojzrccbhjghhgeo?.FactorXaMedication?.Effective;
                object at_ = FHIRHelpers_4_4_000.Instance.ToValue(context, as_);
                CqlInterval<CqlDateTime> au_ = QICoreCommon_4_0_000.Instance.toInterval(context, at_);
                CqlDateTime av_ = context.Operators.Start(au_);
                Period aw_ = tuple_cdbvhiekdcojzrccbhjghhgeo?.QualifyingEncounter?.Period;
                CqlInterval<CqlDateTime> ax_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, aw_);
                CqlDateTime ay_ = context.Operators.Start(ax_);
                CqlInterval<CqlDate> az_ = TJCOverall_8_25_000.Instance.calendarDayOfOrDayAfter(context, ay_);
                CqlDate ba_ = az_?.low;
                CqlDateTime bb_ = context.Operators.ConvertDateToDateTime(ba_);
                CqlDate bc_ = az_?.high;
                CqlDateTime bd_ = context.Operators.ConvertDateToDateTime(bc_);
                bool? be_ = az_?.lowClosed;
                bool? bf_ = az_?.highClosed;
                CqlInterval<CqlDateTime> bg_ = context.Operators.Interval(bb_, bd_, be_, bf_);
                bool? bh_ = context.Operators.In<CqlDateTime>(av_, bg_, "day");
                return (bool?)((CqlBoolean)bh_);
            }

            return (bool?)(/* CQL 'and' (192:7-193:144) */ ((CqlBoolean)aq_
                && (CqlBoolean)ar_()));
        }

        IEnumerable<(CqlTupleMetadata, Encounter QualifyingEncounter, MedicationAdministration FactorXaMedication)?> k_ = context.Operators.SelectWhere<ValueTuple<Encounter, MedicationAdministration>, (CqlTupleMetadata, Encounter QualifyingEncounter, MedicationAdministration FactorXaMedication)?>(h_, i_, j_);
        Encounter l_((CqlTupleMetadata, Encounter QualifyingEncounter, MedicationAdministration FactorXaMedication)? tuple_cdbvhiekdcojzrccbhjghhgeo) => tuple_cdbvhiekdcojzrccbhjghhgeo?.QualifyingEncounter;
        IEnumerable<Encounter> m_ = context.Operators.SelectDistinct<(CqlTupleMetadata, Encounter QualifyingEncounter, MedicationAdministration FactorXaMedication)?, Encounter>(k_, l_);
        CqlValueSet n_ = this.General_or_Neuraxial_Anesthesia(context);
        IEnumerable<Procedure> o_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, n_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));

        bool? p_(MedicationAdministration MR) {
            IEnumerable<Medication> bi_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));

            bool? bj_(Medication M) {
                object bl_ = context.Operators.LateBoundProperty<object>(M, "id.value");
                object bm_ = context.Operators.LateBoundProperty<object>(MR, "medication.reference.value");
                IEnumerable<string> bn_ = context.Operators.Split((string)bm_, "/");
                string bo_ = context.Operators.Last<string>(bn_);
                bool? bp_ = context.Operators.Equal(bl_, bo_);

                bool? bq_() {
                    CodeableConcept br_ = M?.Code;
                    CqlConcept bs_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, br_);
                    CqlValueSet bt_ = this.Oral_Factor_Xa_Inhibitor_for_VTE_Prophylaxis_or_VTE_Treatment(context);
                    bool? bu_ = context.Operators.ConceptInValueSet(bs_, bt_);
                    return (bool?)((CqlBoolean)bu_);
                }

                return (bool?)(/* CQL 'and' */ ((CqlBoolean)bp_
                    && (CqlBoolean)bq_()));
            }

            bool? bk_ = context.Operators.WhereAny<Medication>(bi_, bj_);
            return bk_;
        }

        IEnumerable<MedicationAdministration> q_ = context.Operators.Where<MedicationAdministration>(b_, p_);
        IEnumerable<MedicationAdministration> r_ = context.Operators.Union<MedicationAdministration>(q_, f_);
        IEnumerable<ValueTuple<Encounter, Procedure, MedicationAdministration>> s_ = context.Operators.CrossJoin<Encounter, Procedure, MedicationAdministration>(a_, o_, r_);

        (CqlTupleMetadata, Encounter QualifyingEncounter, Procedure AnesthesiaProcedure, MedicationAdministration FactorXaMedication)? t_(ValueTuple<Encounter, Procedure, MedicationAdministration> _valueTuple) {
            (CqlTupleMetadata, Encounter QualifyingEncounter, Procedure AnesthesiaProcedure, MedicationAdministration FactorXaMedication)? bv_ = (CqlTupleMetadata_CdgLdDFHNTDXFGGVTOMXhQZR, _valueTuple.Item1, _valueTuple.Item2, _valueTuple.Item3);
            return bv_;
        }


        bool? u_((CqlTupleMetadata, Encounter QualifyingEncounter, Procedure AnesthesiaProcedure, MedicationAdministration FactorXaMedication)? tuple_dejnabiogwrwyxienqokgepgj) {
            Code<MedicationAdministration.MedicationAdministrationStatusCodes> bw_ = tuple_dejnabiogwrwyxienqokgepgj?.FactorXaMedication?.StatusElement;
            MedicationAdministration.MedicationAdministrationStatusCodes? bx_ = bw_?.Value;
            string by_ = context.Operators.Convert<string>(bx_);
            bool? bz_ = context.Operators.Equal(by_, "completed");

            bool? ca_() {
                Code<EventStatus> cd_ = tuple_dejnabiogwrwyxienqokgepgj?.AnesthesiaProcedure?.StatusElement;
                EventStatus? ce_ = cd_?.Value;
                string cf_ = context.Operators.Convert<string>(ce_);
                bool? cg_ = context.Operators.Equal(cf_, "completed");
                return (bool?)((CqlBoolean)cg_);
            }


            bool? cb_() {
                object ch_;
                DataType cq_ = tuple_dejnabiogwrwyxienqokgepgj?.AnesthesiaProcedure?.Performed;
                object cr_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cq_);
                bool cs_ = cr_ is CqlDateTime;
                if (cs_)
                {
                    ch_ = cr_ as CqlDateTime;
                }
                else
                {
                    bool ct_ = cr_ is CqlQuantity;
                    if (ct_)
                    {
                        ch_ = cr_ as CqlQuantity;
                    }
                    else
                    {
                        bool cu_ = cr_ is CqlInterval<CqlDateTime>;
                        if (cu_)
                        {
                            ch_ = cr_ as CqlInterval<CqlDateTime>;
                        }
                        else
                        {
                            bool cv_ = cr_ is CqlInterval<CqlQuantity>;
                            if (cv_)
                            {
                                ch_ = cr_ as CqlInterval<CqlQuantity>;
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
                Period ck_ = tuple_dejnabiogwrwyxienqokgepgj?.QualifyingEncounter?.Period;
                CqlInterval<CqlDateTime> cl_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ck_);
                CqlDateTime cm_ = context.Operators.Start(cl_);
                CqlQuantity cn_ = context.Operators.Quantity(1m, "day");
                CqlDateTime co_ = context.Operators.Add(cm_, cn_);
                bool? cp_ = context.Operators.SameAs(cj_, co_, "day");
                return (bool?)((CqlBoolean)cp_);
            }


            bool? cc_() {
                DataType cw_ = tuple_dejnabiogwrwyxienqokgepgj?.FactorXaMedication?.Effective;
                object cx_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cw_);
                CqlInterval<CqlDateTime> cy_ = QICoreCommon_4_0_000.Instance.toInterval(context, cx_);
                CqlDateTime cz_ = context.Operators.Start(cy_);
                object da_;
                DataType dy_ = tuple_dejnabiogwrwyxienqokgepgj?.AnesthesiaProcedure?.Performed;
                object dz_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dy_);
                bool ea_ = dz_ is CqlDateTime;
                if (ea_)
                {
                    da_ = dz_ as CqlDateTime;
                }
                else
                {
                    bool eb_ = dz_ is CqlQuantity;
                    if (eb_)
                    {
                        da_ = dz_ as CqlQuantity;
                    }
                    else
                    {
                        bool ec_ = dz_ is CqlInterval<CqlDateTime>;
                        if (ec_)
                        {
                            da_ = dz_ as CqlInterval<CqlDateTime>;
                        }
                        else
                        {
                            bool ed_ = dz_ is CqlInterval<CqlQuantity>;
                            if (ed_)
                            {
                                da_ = dz_ as CqlInterval<CqlQuantity>;
                            }
                            else
                            {
                                da_ = null;
                            }
                        }
                    }
                }
                CqlInterval<CqlDateTime> db_ = QICoreCommon_4_0_000.Instance.toInterval(context, da_);
                CqlDateTime dc_ = context.Operators.End(db_);
                CqlInterval<CqlDate> dd_ = TJCOverall_8_25_000.Instance.calendarDayOfOrDayAfter(context, dc_);
                CqlDate de_ = dd_?.low;
                CqlDateTime df_ = context.Operators.ConvertDateToDateTime(de_);
                object dg_;
                DataType ee_ = tuple_dejnabiogwrwyxienqokgepgj?.AnesthesiaProcedure?.Performed;
                object ef_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ee_);
                bool eg_ = ef_ is CqlDateTime;
                if (eg_)
                {
                    dg_ = ef_ as CqlDateTime;
                }
                else
                {
                    bool eh_ = ef_ is CqlQuantity;
                    if (eh_)
                    {
                        dg_ = ef_ as CqlQuantity;
                    }
                    else
                    {
                        bool ei_ = ef_ is CqlInterval<CqlDateTime>;
                        if (ei_)
                        {
                            dg_ = ef_ as CqlInterval<CqlDateTime>;
                        }
                        else
                        {
                            bool ej_ = ef_ is CqlInterval<CqlQuantity>;
                            if (ej_)
                            {
                                dg_ = ef_ as CqlInterval<CqlQuantity>;
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
                CqlDate dk_ = dj_?.high;
                CqlDateTime dl_ = context.Operators.ConvertDateToDateTime(dk_);
                object dm_;
                DataType ek_ = tuple_dejnabiogwrwyxienqokgepgj?.AnesthesiaProcedure?.Performed;
                object el_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ek_);
                bool em_ = el_ is CqlDateTime;
                if (em_)
                {
                    dm_ = el_ as CqlDateTime;
                }
                else
                {
                    bool en_ = el_ is CqlQuantity;
                    if (en_)
                    {
                        dm_ = el_ as CqlQuantity;
                    }
                    else
                    {
                        bool eo_ = el_ is CqlInterval<CqlDateTime>;
                        if (eo_)
                        {
                            dm_ = el_ as CqlInterval<CqlDateTime>;
                        }
                        else
                        {
                            bool ep_ = el_ is CqlInterval<CqlQuantity>;
                            if (ep_)
                            {
                                dm_ = el_ as CqlInterval<CqlQuantity>;
                            }
                            else
                            {
                                dm_ = null;
                            }
                        }
                    }
                }
                CqlInterval<CqlDateTime> dn_ = QICoreCommon_4_0_000.Instance.toInterval(context, dm_);
                CqlDateTime do_ = context.Operators.End(dn_);
                CqlInterval<CqlDate> dp_ = TJCOverall_8_25_000.Instance.calendarDayOfOrDayAfter(context, do_);
                bool? dq_ = dp_?.lowClosed;
                object dr_;
                DataType eq_ = tuple_dejnabiogwrwyxienqokgepgj?.AnesthesiaProcedure?.Performed;
                object er_ = FHIRHelpers_4_4_000.Instance.ToValue(context, eq_);
                bool es_ = er_ is CqlDateTime;
                if (es_)
                {
                    dr_ = er_ as CqlDateTime;
                }
                else
                {
                    bool et_ = er_ is CqlQuantity;
                    if (et_)
                    {
                        dr_ = er_ as CqlQuantity;
                    }
                    else
                    {
                        bool eu_ = er_ is CqlInterval<CqlDateTime>;
                        if (eu_)
                        {
                            dr_ = er_ as CqlInterval<CqlDateTime>;
                        }
                        else
                        {
                            bool ev_ = er_ is CqlInterval<CqlQuantity>;
                            if (ev_)
                            {
                                dr_ = er_ as CqlInterval<CqlQuantity>;
                            }
                            else
                            {
                                dr_ = null;
                            }
                        }
                    }
                }
                CqlInterval<CqlDateTime> ds_ = QICoreCommon_4_0_000.Instance.toInterval(context, dr_);
                CqlDateTime dt_ = context.Operators.End(ds_);
                CqlInterval<CqlDate> du_ = TJCOverall_8_25_000.Instance.calendarDayOfOrDayAfter(context, dt_);
                bool? dv_ = du_?.highClosed;
                CqlInterval<CqlDateTime> dw_ = context.Operators.Interval(df_, dl_, dq_, dv_);
                bool? dx_ = context.Operators.In<CqlDateTime>(cz_, dw_, "day");
                return (bool?)((CqlBoolean)dx_);
            }

            return (bool?)(/* CQL 'and' (200:9-203:162) */ (/* CQL 'and' (200:15-202:118) */ (/* CQL 'and' (200:15-201:54) */ ((CqlBoolean)bz_
                && (CqlBoolean)ca_())
                && (CqlBoolean)cb_())
                && (CqlBoolean)cc_()));
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

                bool? p_() {
                    CodeableConcept q_ = AtrialFibrillation?.VerificationStatus;
                    CqlConcept r_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, q_);
                    CqlCode s_ = QICoreCommon_4_0_000.Instance.refuted(context);
                    CqlConcept t_ = context.Operators.ConvertCodeToConcept(s_);
                    bool? u_ = context.Operators.Equivalent(r_, t_);

                    bool? v_() {
                        CodeableConcept x_ = AtrialFibrillation?.VerificationStatus;
                        CqlConcept y_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, x_);
                        CqlCode z_ = QICoreCommon_4_0_000.Instance.entered_in_error(context);
                        CqlConcept aa_ = context.Operators.ConvertCodeToConcept(z_);
                        bool? ab_ = context.Operators.Equivalent(y_, aa_);
                        return (bool?)((CqlBoolean)!ab_);
                    }


                    bool? w_() {
                        DataType ac_ = AtrialFibrillation?.Onset;
                        object ad_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ac_);
                        CqlInterval<CqlDateTime> ae_ = QICoreCommon_4_0_000.Instance.toInterval(context, ad_);
                        CqlDateTime af_ = context.Operators.Start(ae_);
                        Period ag_ = QualifyingEncounter?.Period;
                        CqlInterval<CqlDateTime> ah_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ag_);
                        CqlDateTime ai_ = context.Operators.End(ah_);
                        bool? aj_ = context.Operators.SameOrBefore(af_, ai_, (string)default);
                        return (bool?)((CqlBoolean)aj_);
                    }

                    return (bool?)(/* CQL 'and' (210:77-213:107) */ (/* CQL 'and' (210:77-212:9) */ ((CqlBoolean)!u_
                        && (CqlBoolean)v_())
                        && (CqlBoolean)w_()));
                }

                return (bool?)(/* CQL 'implies' (210:19-213:107) */ ((CqlBoolean)(!(!((bool?)(o_ is null))))
                    || (CqlBoolean)p_()));
            }

            bool? m_ = context.Operators.WhereAny<Condition>(k_, l_);
            return m_;
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
                CodeableConcept aq_ = VTEDiagnosis?.ClinicalStatus;
                CqlConcept ar_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, aq_);
                CqlCode as_ = QICoreCommon_4_0_000.Instance.inactive(context);
                CqlConcept at_ = context.Operators.ConvertCodeToConcept(as_);
                bool? au_ = context.Operators.Equivalent(ar_, at_);

                bool? av_() {
                    CodeableConcept az_ = VTEDiagnosis?.ClinicalStatus;
                    CqlConcept ba_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, az_);
                    CqlCode bb_ = QICoreCommon_4_0_000.Instance.remission(context);
                    CqlConcept bc_ = context.Operators.ConvertCodeToConcept(bb_);
                    bool? bd_ = context.Operators.Equivalent(ba_, bc_);
                    return (bool?)((CqlBoolean)bd_);
                }


                bool? aw_() {
                    CodeableConcept be_ = VTEDiagnosis?.ClinicalStatus;
                    CqlConcept bf_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, be_);
                    CqlCode bg_ = QICoreCommon_4_0_000.Instance.resolved(context);
                    CqlConcept bh_ = context.Operators.ConvertCodeToConcept(bg_);
                    bool? bi_ = context.Operators.Equivalent(bf_, bh_);
                    return (bool?)((CqlBoolean)bi_);
                }


                bool? ax_() {
                    CodeableConcept bj_ = VTEDiagnosis?.VerificationStatus;
                    CqlConcept bk_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, bj_);
                    return (bool?)((CqlBoolean)(!((bool?)(bk_ is null))));
                }


                bool? ay_() {
                    CodeableConcept bl_ = VTEDiagnosis?.VerificationStatus;
                    CqlConcept bm_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, bl_);
                    CqlCode bn_ = QICoreCommon_4_0_000.Instance.refuted(context);
                    CqlConcept bo_ = context.Operators.ConvertCodeToConcept(bn_);
                    bool? bp_ = context.Operators.Equivalent(bm_, bo_);

                    bool? bq_() {
                        CodeableConcept bs_ = VTEDiagnosis?.VerificationStatus;
                        CqlConcept bt_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, bs_);
                        CqlCode bu_ = QICoreCommon_4_0_000.Instance.entered_in_error(context);
                        CqlConcept bv_ = context.Operators.ConvertCodeToConcept(bu_);
                        bool? bw_ = context.Operators.Equivalent(bt_, bv_);
                        return (bool?)((CqlBoolean)!bw_);
                    }


                    bool? br_() {
                        DataType bx_ = VTEDiagnosis?.Onset;
                        object by_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bx_);
                        CqlInterval<CqlDateTime> bz_ = QICoreCommon_4_0_000.Instance.toInterval(context, by_);
                        CqlInterval<CqlDateTime> ca_;
                        Period cc_ = QualifyingEncounter?.Period;
                        CqlInterval<CqlDateTime> cd_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, cc_);
                        CqlDateTime ce_ = context.Operators.Start(cd_);
                        if (ce_ is null)
                        {
                            ca_ = default;
                        }
                        else
                        {
                            CqlInterval<CqlDateTime> cf_ = context.Operators.Interval(ce_, ce_, true, true);
                            ca_ = cf_;
                        }
                        bool? cb_ = context.Operators.Before(bz_, ca_, (string)default);
                        return (bool?)((CqlBoolean)cb_);
                    }

                    return (bool?)(/* CQL 'and' (224:69-227:92) */ (/* CQL 'and' (224:69-226:11) */ ((CqlBoolean)!bp_
                        && (CqlBoolean)bq_())
                        && (CqlBoolean)br_()));
                }

                return (bool?)(/* CQL 'implies' (220:21-227:92) */ ((CqlBoolean)(!((bool?)(/* CQL 'and' (220:21-224:59) */ (/* CQL 'or' (220:21-223:11) */ (/* CQL 'or' (220:23-221:71) */ ((CqlBoolean)au_
                    || (CqlBoolean)av_())
                    || (CqlBoolean)aw_())
                    && (CqlBoolean)ax_()))))
                    || (CqlBoolean)ay_()));
            }

            bool? ap_ = context.Operators.WhereAny<Condition>(an_, ao_);
            return ap_;
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

                bool? o_() {
                    object p_;
                    DataType w_ = HipKneeProcedure?.Performed;
                    object x_ = FHIRHelpers_4_4_000.Instance.ToValue(context, w_);
                    bool y_ = x_ is CqlDateTime;
                    if (y_)
                    {
                        p_ = x_ as CqlDateTime;
                    }
                    else
                    {
                        bool z_ = x_ is CqlQuantity;
                        if (z_)
                        {
                            p_ = x_ as CqlQuantity;
                        }
                        else
                        {
                            bool aa_ = x_ is CqlInterval<CqlDateTime>;
                            if (aa_)
                            {
                                p_ = x_ as CqlInterval<CqlDateTime>;
                            }
                            else
                            {
                                bool ab_ = x_ is CqlInterval<CqlQuantity>;
                                if (ab_)
                                {
                                    p_ = x_ as CqlInterval<CqlQuantity>;
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
                    return (bool?)((CqlBoolean)v_);
                }

                return (bool?)(/* CQL 'and' (234:17-235:107) */ ((CqlBoolean)n_
                    && (CqlBoolean)o_()));
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

            bool? ar_() {
                Code<ObservationStatus> as_ = VTERiskAssessment?.StatusElement;
                ObservationStatus? at_ = as_?.Value;
                string au_ = context.Operators.Convert<string>(at_);
                string[] av_ = [
                    "final",
                    "amended",
                    "corrected",
                ];
                bool? aw_ = context.Operators.In<string>(au_, (IEnumerable<string>)av_);
                return (bool?)((CqlBoolean)aw_);
            }

            return (bool?)(/* CQL 'and' (243:7-244:75) */ ((CqlBoolean)aq_
                && (CqlBoolean)ar_()));
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

            bool? bk_() {
                Code<ObservationStatus> bl_ = INRLabTest?.StatusElement;
                ObservationStatus? bm_ = bl_?.Value;
                string bn_ = context.Operators.Convert<string>(bm_);
                string[] bo_ = [
                    "final",
                    "amended",
                    "corrected",
                ];
                bool? bp_ = context.Operators.In<string>(bn_, (IEnumerable<string>)bo_);
                return (bool?)((CqlBoolean)bp_);
            }

            return (bool?)(/* CQL 'and' (251:9-252:70) */ ((CqlBoolean)bj_
                && (CqlBoolean)bk_()));
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
                bool? cd_ = context.Operators.Equal(bz_, cc_);

                bool? ce_() {
                    CodeableConcept cf_ = M?.Code;
                    CqlConcept cg_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, cf_);
                    CqlValueSet ch_ = this.Unfractionated_Heparin(context);
                    bool? ci_ = context.Operators.ConceptInValueSet(cg_, ch_);
                    return (bool?)((CqlBoolean)ci_);
                }

                return (bool?)(/* CQL 'and' */ ((CqlBoolean)cd_
                    && (CqlBoolean)ce_()));
            }

            bool? by_ = context.Operators.WhereAny<Medication>(bw_, bx_);
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
            bool? cn_ = context.Operators.ConceptInValueSet(cl_, cm_);
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
                bool? cv_ = context.Operators.Equal(cr_, cu_);

                bool? cw_() {
                    CodeableConcept cx_ = M?.Code;
                    CqlConcept cy_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, cx_);
                    CqlValueSet cz_ = this.Direct_Thrombin_Inhibitor(context);
                    bool? da_ = context.Operators.ConceptInValueSet(cy_, cz_);
                    return (bool?)((CqlBoolean)da_);
                }

                return (bool?)(/* CQL 'and' */ ((CqlBoolean)cv_
                    && (CqlBoolean)cw_()));
            }

            bool? cq_ = context.Operators.WhereAny<Medication>(co_, cp_);
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
                bool? di_ = context.Operators.Equal(de_, dh_);

                bool? dj_() {
                    CodeableConcept dk_ = M?.Code;
                    CqlConcept dl_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, dk_);
                    CqlValueSet dm_ = this.Glycoprotein_IIb_IIIa_Inhibitors(context);
                    bool? dn_ = context.Operators.ConceptInValueSet(dl_, dm_);
                    return (bool?)((CqlBoolean)dn_);
                }

                return (bool?)(/* CQL 'and' */ ((CqlBoolean)di_
                    && (CqlBoolean)dj_()));
            }

            bool? dd_ = context.Operators.WhereAny<Medication>(db_, dc_);
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
            bool? dr_ = context.Operators.Equal(dq_, "completed");
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

            bool? p_() {
                object r_;
                DataType aa_ = tuple_gwhjghwetinfdseedvamgjivv?.AnesthesiaProcedure?.Performed;
                object ab_ = FHIRHelpers_4_4_000.Instance.ToValue(context, aa_);
                bool ac_ = ab_ is CqlDateTime;
                if (ac_)
                {
                    r_ = ab_ as CqlDateTime;
                }
                else
                {
                    bool ad_ = ab_ is CqlQuantity;
                    if (ad_)
                    {
                        r_ = ab_ as CqlQuantity;
                    }
                    else
                    {
                        bool ae_ = ab_ is CqlInterval<CqlDateTime>;
                        if (ae_)
                        {
                            r_ = ab_ as CqlInterval<CqlDateTime>;
                        }
                        else
                        {
                            bool af_ = ab_ is CqlInterval<CqlQuantity>;
                            if (af_)
                            {
                                r_ = ab_ as CqlInterval<CqlQuantity>;
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
                return (bool?)((CqlBoolean)z_);
            }


            bool? q_() {
                CqlDateTime ag_ = tuple_gwhjghwetinfdseedvamgjivv?.LowRiskForVTE?.LowRiskDatetime;
                object ah_;
                DataType bf_ = tuple_gwhjghwetinfdseedvamgjivv?.AnesthesiaProcedure?.Performed;
                object bg_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bf_);
                bool bh_ = bg_ is CqlDateTime;
                if (bh_)
                {
                    ah_ = bg_ as CqlDateTime;
                }
                else
                {
                    bool bi_ = bg_ is CqlQuantity;
                    if (bi_)
                    {
                        ah_ = bg_ as CqlQuantity;
                    }
                    else
                    {
                        bool bj_ = bg_ is CqlInterval<CqlDateTime>;
                        if (bj_)
                        {
                            ah_ = bg_ as CqlInterval<CqlDateTime>;
                        }
                        else
                        {
                            bool bk_ = bg_ is CqlInterval<CqlQuantity>;
                            if (bk_)
                            {
                                ah_ = bg_ as CqlInterval<CqlQuantity>;
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
                CqlDate al_ = ak_?.low;
                CqlDateTime am_ = context.Operators.ConvertDateToDateTime(al_);
                object an_;
                DataType bl_ = tuple_gwhjghwetinfdseedvamgjivv?.AnesthesiaProcedure?.Performed;
                object bm_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bl_);
                bool bn_ = bm_ is CqlDateTime;
                if (bn_)
                {
                    an_ = bm_ as CqlDateTime;
                }
                else
                {
                    bool bo_ = bm_ is CqlQuantity;
                    if (bo_)
                    {
                        an_ = bm_ as CqlQuantity;
                    }
                    else
                    {
                        bool bp_ = bm_ is CqlInterval<CqlDateTime>;
                        if (bp_)
                        {
                            an_ = bm_ as CqlInterval<CqlDateTime>;
                        }
                        else
                        {
                            bool bq_ = bm_ is CqlInterval<CqlQuantity>;
                            if (bq_)
                            {
                                an_ = bm_ as CqlInterval<CqlQuantity>;
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
                CqlDate ar_ = aq_?.high;
                CqlDateTime as_ = context.Operators.ConvertDateToDateTime(ar_);
                object at_;
                DataType br_ = tuple_gwhjghwetinfdseedvamgjivv?.AnesthesiaProcedure?.Performed;
                object bs_ = FHIRHelpers_4_4_000.Instance.ToValue(context, br_);
                bool bt_ = bs_ is CqlDateTime;
                if (bt_)
                {
                    at_ = bs_ as CqlDateTime;
                }
                else
                {
                    bool bu_ = bs_ is CqlQuantity;
                    if (bu_)
                    {
                        at_ = bs_ as CqlQuantity;
                    }
                    else
                    {
                        bool bv_ = bs_ is CqlInterval<CqlDateTime>;
                        if (bv_)
                        {
                            at_ = bs_ as CqlInterval<CqlDateTime>;
                        }
                        else
                        {
                            bool bw_ = bs_ is CqlInterval<CqlQuantity>;
                            if (bw_)
                            {
                                at_ = bs_ as CqlInterval<CqlQuantity>;
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
                bool? ax_ = aw_?.lowClosed;
                object ay_;
                DataType bx_ = tuple_gwhjghwetinfdseedvamgjivv?.AnesthesiaProcedure?.Performed;
                object by_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bx_);
                bool bz_ = by_ is CqlDateTime;
                if (bz_)
                {
                    ay_ = by_ as CqlDateTime;
                }
                else
                {
                    bool ca_ = by_ is CqlQuantity;
                    if (ca_)
                    {
                        ay_ = by_ as CqlQuantity;
                    }
                    else
                    {
                        bool cb_ = by_ is CqlInterval<CqlDateTime>;
                        if (cb_)
                        {
                            ay_ = by_ as CqlInterval<CqlDateTime>;
                        }
                        else
                        {
                            bool cc_ = by_ is CqlInterval<CqlQuantity>;
                            if (cc_)
                            {
                                ay_ = by_ as CqlInterval<CqlQuantity>;
                            }
                            else
                            {
                                ay_ = null;
                            }
                        }
                    }
                }
                CqlInterval<CqlDateTime> az_ = QICoreCommon_4_0_000.Instance.toInterval(context, ay_);
                CqlDateTime ba_ = context.Operators.End(az_);
                CqlInterval<CqlDate> bb_ = TJCOverall_8_25_000.Instance.calendarDayOfOrDayAfter(context, ba_);
                bool? bc_ = bb_?.highClosed;
                CqlInterval<CqlDateTime> bd_ = context.Operators.Interval(am_, as_, ax_, bc_);
                bool? be_ = context.Operators.In<CqlDateTime>(ag_, bd_, "day");
                return (bool?)((CqlBoolean)be_);
            }

            return (bool?)(/* CQL 'and' (280:5-282:137) */ (/* CQL 'and' (280:11-281:114) */ ((CqlBoolean)o_
                && (CqlBoolean)p_())
                && (CqlBoolean)q_()));
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

            bool? cc_(Extension @this) {
                FhirUri cj_ = @this?.UrlElement;
                string ck_ = FHIRHelpers_4_4_000.Instance.ToString(context, cj_);
                bool? cl_ = context.Operators.Equal(ck_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-recorded");
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
            bool? ct_ = context.Operators.In<string>(cr_, (IEnumerable<string>)cs_);

            bool? cu_() {
                Code<MedicationRequest.MedicationrequestStatus> cv_ = NoMedicationOrder?.StatusElement;
                MedicationRequest.MedicationrequestStatus? cw_ = cv_?.Value;
                string cx_ = context.Operators.Convert<string>(cw_);
                string[] cy_ = [
                    "active",
                    "completed",
                ];
                bool? cz_ = context.Operators.In<string>(cx_, (IEnumerable<string>)cy_);
                return (bool?)((CqlBoolean)cz_);
            }

            return (bool?)(/* CQL 'and' (327:9-328:67) */ ((CqlBoolean)ct_
                && (CqlBoolean)cu_()));
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
                bool? dq_ = context.Operators.Equal(dm_, dp_);

                bool? dr_() {
                    CodeableConcept ds_ = M?.Code;
                    CqlConcept dt_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, ds_);
                    CqlValueSet du_ = this.Low_Dose_Unfractionated_Heparin_for_VTE_Prophylaxis(context);
                    bool? dv_ = context.Operators.ConceptInValueSet(dt_, du_);
                    return (bool?)((CqlBoolean)dv_);
                }

                return (bool?)(/* CQL 'and' */ ((CqlBoolean)dq_
                    && (CqlBoolean)dr_()));
            }

            bool? dl_ = context.Operators.WhereAny<Medication>(dj_, dk_);
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
                bool? ed_ = context.Operators.Equal(dz_, ec_);

                bool? ee_() {
                    CodeableConcept ef_ = M?.Code;
                    CqlConcept eg_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, ef_);
                    CqlValueSet eh_ = this.Low_Molecular_Weight_Heparin_for_VTE_Prophylaxis(context);
                    bool? ei_ = context.Operators.ConceptInValueSet(eg_, eh_);
                    return (bool?)((CqlBoolean)ei_);
                }

                return (bool?)(/* CQL 'and' */ ((CqlBoolean)ed_
                    && (CqlBoolean)ee_()));
            }

            bool? dy_ = context.Operators.WhereAny<Medication>(dw_, dx_);
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
                bool? eq_ = context.Operators.Equal(em_, ep_);

                bool? er_() {
                    CodeableConcept es_ = M?.Code;
                    CqlConcept et_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, es_);
                    CqlValueSet eu_ = this.Injectable_Factor_Xa_Inhibitor_for_VTE_Prophylaxis(context);
                    bool? ev_ = context.Operators.ConceptInValueSet(et_, eu_);
                    return (bool?)((CqlBoolean)ev_);
                }

                return (bool?)(/* CQL 'and' */ ((CqlBoolean)eq_
                    && (CqlBoolean)er_()));
            }

            bool? el_ = context.Operators.WhereAny<Medication>(ej_, ek_);
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
                bool? fd_ = context.Operators.Equal(ez_, fc_);

                bool? fe_() {
                    CodeableConcept ff_ = M?.Code;
                    CqlConcept fg_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, ff_);
                    CqlValueSet fh_ = this.Warfarin(context);
                    bool? fi_ = context.Operators.ConceptInValueSet(fg_, fh_);
                    return (bool?)((CqlBoolean)fi_);
                }

                return (bool?)(/* CQL 'and' */ ((CqlBoolean)fd_
                    && (CqlBoolean)fe_()));
            }

            bool? ey_ = context.Operators.WhereAny<Medication>(ew_, ex_);
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
                bool? fq_ = context.Operators.Equal(fm_, fp_);

                bool? fr_() {
                    CodeableConcept fs_ = M?.Code;
                    CqlConcept ft_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, fs_);
                    CqlValueSet fu_ = this.Rivaroxaban_for_VTE_Prophylaxis(context);
                    bool? fv_ = context.Operators.ConceptInValueSet(ft_, fu_);
                    return (bool?)((CqlBoolean)fv_);
                }

                return (bool?)(/* CQL 'and' */ ((CqlBoolean)fq_
                    && (CqlBoolean)fr_()));
            }

            bool? fl_ = context.Operators.WhereAny<Medication>(fj_, fk_);
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
            bool? fy_ = QICoreCommon_4_0_000.Instance.references(context, fx_, tuple_iiuqmbcjhjbpgddolhattrue?.MedicationOrderReject);

            bool? fz_() {
                CodeableConcept gb_ = tuple_iiuqmbcjhjbpgddolhattrue?.T?.Code;
                CqlConcept gc_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, gb_);
                CqlCode gd_ = QICoreCommon_4_0_000.Instance.Fulfill(context);
                CqlConcept ge_ = context.Operators.ConvertCodeToConcept(gd_);
                bool? gf_ = context.Operators.Equivalent(gc_, ge_);
                return (bool?)((CqlBoolean)gf_);
            }


            bool? ga_() {
                Code<MedicationRequest.MedicationrequestStatus> gg_ = tuple_iiuqmbcjhjbpgddolhattrue?.MedicationOrderReject?.StatusElement;
                MedicationRequest.MedicationrequestStatus? gh_ = gg_?.Value;
                string gi_ = context.Operators.Convert<string>(gh_);
                bool? gj_ = context.Operators.Equal(gi_, "active");
                return (bool?)((CqlBoolean)gj_);
            }

            return (bool?)(/* CQL 'and' (342:9-344:53) */ (/* CQL 'and' (342:15-343:45) */ ((CqlBoolean)fy_
                && (CqlBoolean)fz_())
                && (CqlBoolean)ga_()));
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

                bool? j_() {
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
                    return (bool?)((CqlBoolean)t_);
                }

                return (bool?)(/* CQL 'and' (296:17-297:127) */ ((CqlBoolean)i_
                    && (CqlBoolean)j_()));
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

            bool? by_() {
                Code<RequestStatus> cb_ = tuple_yyidpxbnjhogfrjkyrbmgchb?.DeviceOrderReject?.StatusElement;
                RequestStatus? cc_ = cb_?.Value;
                Code<RequestStatus> cd_ = context.Operators.Convert<Code<RequestStatus>>(cc_);
                bool? ce_ = context.Operators.Equal(cd_, "active");
                return (bool?)((CqlBoolean)ce_);
            }


            bool? bz_() {
                ResourceReference cf_ = tuple_yyidpxbnjhogfrjkyrbmgchb?.T?.Focus;
                bool? cg_ = QICoreCommon_4_0_000.Instance.references(context, cf_, tuple_yyidpxbnjhogfrjkyrbmgchb?.DeviceOrderReject);
                return (bool?)((CqlBoolean)cg_);
            }


            bool? ca_() {
                CodeableConcept ch_ = tuple_yyidpxbnjhogfrjkyrbmgchb?.T?.Code;
                CqlConcept ci_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, ch_);
                CqlCode cj_ = QICoreCommon_4_0_000.Instance.Fulfill(context);
                CqlConcept ck_ = context.Operators.ConvertCodeToConcept(cj_);
                bool? cl_ = context.Operators.Equivalent(ci_, ck_);
                return (bool?)((CqlBoolean)cl_);
            }

            return (bool?)(/* CQL 'and' (385:9-388:45) */ (/* CQL 'and' (385:15-387:54) */ (/* CQL 'and' (385:15-386:49) */ ((CqlBoolean)bx_
                && (CqlBoolean)by_())
                && (CqlBoolean)bz_())
                && (CqlBoolean)ca_()));
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
                bool? df_ = context.Operators.Equal(de_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-recorded");
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

                bool? j_() {
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
                    return (bool?)((CqlBoolean)t_);
                }

                return (bool?)(/* CQL 'and' (355:17-356:123) */ ((CqlBoolean)i_
                    && (CqlBoolean)j_()));
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

            bool? o_() {
                Code<EventStatus> r_ = tuple_chjebychscdthhbpzggacmwxe?.AnesthesiaProcedure?.StatusElement;
                EventStatus? s_ = r_?.Value;
                string t_ = context.Operators.Convert<string>(s_);
                bool? u_ = context.Operators.Equal(t_, "completed");
                return (bool?)((CqlBoolean)u_);
            }


            bool? p_() {
                object v_;
                DataType ae_ = tuple_chjebychscdthhbpzggacmwxe?.AnesthesiaProcedure?.Performed;
                object af_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ae_);
                bool ag_ = af_ is CqlDateTime;
                if (ag_)
                {
                    v_ = af_ as CqlDateTime;
                }
                else
                {
                    bool ah_ = af_ is CqlQuantity;
                    if (ah_)
                    {
                        v_ = af_ as CqlQuantity;
                    }
                    else
                    {
                        bool ai_ = af_ is CqlInterval<CqlDateTime>;
                        if (ai_)
                        {
                            v_ = af_ as CqlInterval<CqlDateTime>;
                        }
                        else
                        {
                            bool aj_ = af_ is CqlInterval<CqlQuantity>;
                            if (aj_)
                            {
                                v_ = af_ as CqlInterval<CqlQuantity>;
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
                return (bool?)((CqlBoolean)ad_);
            }


            bool? q_() {
                CqlDateTime ak_ = tuple_chjebychscdthhbpzggacmwxe?.NoVTEMedication?.authoredOn;
                object al_;
                DataType bj_ = tuple_chjebychscdthhbpzggacmwxe?.AnesthesiaProcedure?.Performed;
                object bk_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bj_);
                bool bl_ = bk_ is CqlDateTime;
                if (bl_)
                {
                    al_ = bk_ as CqlDateTime;
                }
                else
                {
                    bool bm_ = bk_ is CqlQuantity;
                    if (bm_)
                    {
                        al_ = bk_ as CqlQuantity;
                    }
                    else
                    {
                        bool bn_ = bk_ is CqlInterval<CqlDateTime>;
                        if (bn_)
                        {
                            al_ = bk_ as CqlInterval<CqlDateTime>;
                        }
                        else
                        {
                            bool bo_ = bk_ is CqlInterval<CqlQuantity>;
                            if (bo_)
                            {
                                al_ = bk_ as CqlInterval<CqlQuantity>;
                            }
                            else
                            {
                                al_ = null;
                            }
                        }
                    }
                }
                CqlInterval<CqlDateTime> am_ = QICoreCommon_4_0_000.Instance.toInterval(context, al_);
                CqlDateTime an_ = context.Operators.End(am_);
                CqlInterval<CqlDate> ao_ = TJCOverall_8_25_000.Instance.calendarDayOfOrDayAfter(context, an_);
                CqlDate ap_ = ao_?.low;
                CqlDateTime aq_ = context.Operators.ConvertDateToDateTime(ap_);
                object ar_;
                DataType bp_ = tuple_chjebychscdthhbpzggacmwxe?.AnesthesiaProcedure?.Performed;
                object bq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bp_);
                bool br_ = bq_ is CqlDateTime;
                if (br_)
                {
                    ar_ = bq_ as CqlDateTime;
                }
                else
                {
                    bool bs_ = bq_ is CqlQuantity;
                    if (bs_)
                    {
                        ar_ = bq_ as CqlQuantity;
                    }
                    else
                    {
                        bool bt_ = bq_ is CqlInterval<CqlDateTime>;
                        if (bt_)
                        {
                            ar_ = bq_ as CqlInterval<CqlDateTime>;
                        }
                        else
                        {
                            bool bu_ = bq_ is CqlInterval<CqlQuantity>;
                            if (bu_)
                            {
                                ar_ = bq_ as CqlInterval<CqlQuantity>;
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
                CqlDate av_ = au_?.high;
                CqlDateTime aw_ = context.Operators.ConvertDateToDateTime(av_);
                object ax_;
                DataType bv_ = tuple_chjebychscdthhbpzggacmwxe?.AnesthesiaProcedure?.Performed;
                object bw_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bv_);
                bool bx_ = bw_ is CqlDateTime;
                if (bx_)
                {
                    ax_ = bw_ as CqlDateTime;
                }
                else
                {
                    bool by_ = bw_ is CqlQuantity;
                    if (by_)
                    {
                        ax_ = bw_ as CqlQuantity;
                    }
                    else
                    {
                        bool bz_ = bw_ is CqlInterval<CqlDateTime>;
                        if (bz_)
                        {
                            ax_ = bw_ as CqlInterval<CqlDateTime>;
                        }
                        else
                        {
                            bool ca_ = bw_ is CqlInterval<CqlQuantity>;
                            if (ca_)
                            {
                                ax_ = bw_ as CqlInterval<CqlQuantity>;
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
                bool? bb_ = ba_?.lowClosed;
                object bc_;
                DataType cb_ = tuple_chjebychscdthhbpzggacmwxe?.AnesthesiaProcedure?.Performed;
                object cc_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cb_);
                bool cd_ = cc_ is CqlDateTime;
                if (cd_)
                {
                    bc_ = cc_ as CqlDateTime;
                }
                else
                {
                    bool ce_ = cc_ is CqlQuantity;
                    if (ce_)
                    {
                        bc_ = cc_ as CqlQuantity;
                    }
                    else
                    {
                        bool cf_ = cc_ is CqlInterval<CqlDateTime>;
                        if (cf_)
                        {
                            bc_ = cc_ as CqlInterval<CqlDateTime>;
                        }
                        else
                        {
                            bool cg_ = cc_ is CqlInterval<CqlQuantity>;
                            if (cg_)
                            {
                                bc_ = cc_ as CqlInterval<CqlQuantity>;
                            }
                            else
                            {
                                bc_ = null;
                            }
                        }
                    }
                }
                CqlInterval<CqlDateTime> bd_ = QICoreCommon_4_0_000.Instance.toInterval(context, bc_);
                CqlDateTime be_ = context.Operators.End(bd_);
                CqlInterval<CqlDate> bf_ = TJCOverall_8_25_000.Instance.calendarDayOfOrDayAfter(context, be_);
                bool? bg_ = bf_?.highClosed;
                CqlInterval<CqlDateTime> bh_ = context.Operators.Interval(aq_, aw_, bb_, bg_);
                bool? bi_ = context.Operators.In<CqlDateTime>(ak_, bh_, "day");
                return (bool?)((CqlBoolean)bi_);
            }

            return (bool?)(/* CQL 'and' (304:5-307:134) */ (/* CQL 'and' (304:11-306:114) */ (/* CQL 'and' (304:11-305:50) */ ((CqlBoolean)n_
                && (CqlBoolean)o_())
                && (CqlBoolean)p_())
                && (CqlBoolean)q_()));
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

            bool? o_() {
                Code<EventStatus> r_ = tuple_cadhcldckpqwmtcazwxfnkhgc?.AnesthesiaProcedure?.StatusElement;
                EventStatus? s_ = r_?.Value;
                string t_ = context.Operators.Convert<string>(s_);
                bool? u_ = context.Operators.Equal(t_, "completed");
                return (bool?)((CqlBoolean)u_);
            }


            bool? p_() {
                object v_;
                DataType ae_ = tuple_cadhcldckpqwmtcazwxfnkhgc?.AnesthesiaProcedure?.Performed;
                object af_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ae_);
                bool ag_ = af_ is CqlDateTime;
                if (ag_)
                {
                    v_ = af_ as CqlDateTime;
                }
                else
                {
                    bool ah_ = af_ is CqlQuantity;
                    if (ah_)
                    {
                        v_ = af_ as CqlQuantity;
                    }
                    else
                    {
                        bool ai_ = af_ is CqlInterval<CqlDateTime>;
                        if (ai_)
                        {
                            v_ = af_ as CqlInterval<CqlDateTime>;
                        }
                        else
                        {
                            bool aj_ = af_ is CqlInterval<CqlQuantity>;
                            if (aj_)
                            {
                                v_ = af_ as CqlInterval<CqlQuantity>;
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
                return (bool?)((CqlBoolean)ad_);
            }


            bool? q_() {
                CqlDateTime ak_ = tuple_cadhcldckpqwmtcazwxfnkhgc?.NoVTEDevice?.authoredOn;
                object al_;
                DataType bj_ = tuple_cadhcldckpqwmtcazwxfnkhgc?.AnesthesiaProcedure?.Performed;
                object bk_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bj_);
                bool bl_ = bk_ is CqlDateTime;
                if (bl_)
                {
                    al_ = bk_ as CqlDateTime;
                }
                else
                {
                    bool bm_ = bk_ is CqlQuantity;
                    if (bm_)
                    {
                        al_ = bk_ as CqlQuantity;
                    }
                    else
                    {
                        bool bn_ = bk_ is CqlInterval<CqlDateTime>;
                        if (bn_)
                        {
                            al_ = bk_ as CqlInterval<CqlDateTime>;
                        }
                        else
                        {
                            bool bo_ = bk_ is CqlInterval<CqlQuantity>;
                            if (bo_)
                            {
                                al_ = bk_ as CqlInterval<CqlQuantity>;
                            }
                            else
                            {
                                al_ = null;
                            }
                        }
                    }
                }
                CqlInterval<CqlDateTime> am_ = QICoreCommon_4_0_000.Instance.toInterval(context, al_);
                CqlDateTime an_ = context.Operators.End(am_);
                CqlInterval<CqlDate> ao_ = TJCOverall_8_25_000.Instance.calendarDayOfOrDayAfter(context, an_);
                CqlDate ap_ = ao_?.low;
                CqlDateTime aq_ = context.Operators.ConvertDateToDateTime(ap_);
                object ar_;
                DataType bp_ = tuple_cadhcldckpqwmtcazwxfnkhgc?.AnesthesiaProcedure?.Performed;
                object bq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bp_);
                bool br_ = bq_ is CqlDateTime;
                if (br_)
                {
                    ar_ = bq_ as CqlDateTime;
                }
                else
                {
                    bool bs_ = bq_ is CqlQuantity;
                    if (bs_)
                    {
                        ar_ = bq_ as CqlQuantity;
                    }
                    else
                    {
                        bool bt_ = bq_ is CqlInterval<CqlDateTime>;
                        if (bt_)
                        {
                            ar_ = bq_ as CqlInterval<CqlDateTime>;
                        }
                        else
                        {
                            bool bu_ = bq_ is CqlInterval<CqlQuantity>;
                            if (bu_)
                            {
                                ar_ = bq_ as CqlInterval<CqlQuantity>;
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
                CqlDate av_ = au_?.high;
                CqlDateTime aw_ = context.Operators.ConvertDateToDateTime(av_);
                object ax_;
                DataType bv_ = tuple_cadhcldckpqwmtcazwxfnkhgc?.AnesthesiaProcedure?.Performed;
                object bw_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bv_);
                bool bx_ = bw_ is CqlDateTime;
                if (bx_)
                {
                    ax_ = bw_ as CqlDateTime;
                }
                else
                {
                    bool by_ = bw_ is CqlQuantity;
                    if (by_)
                    {
                        ax_ = bw_ as CqlQuantity;
                    }
                    else
                    {
                        bool bz_ = bw_ is CqlInterval<CqlDateTime>;
                        if (bz_)
                        {
                            ax_ = bw_ as CqlInterval<CqlDateTime>;
                        }
                        else
                        {
                            bool ca_ = bw_ is CqlInterval<CqlQuantity>;
                            if (ca_)
                            {
                                ax_ = bw_ as CqlInterval<CqlQuantity>;
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
                bool? bb_ = ba_?.lowClosed;
                object bc_;
                DataType cb_ = tuple_cadhcldckpqwmtcazwxfnkhgc?.AnesthesiaProcedure?.Performed;
                object cc_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cb_);
                bool cd_ = cc_ is CqlDateTime;
                if (cd_)
                {
                    bc_ = cc_ as CqlDateTime;
                }
                else
                {
                    bool ce_ = cc_ is CqlQuantity;
                    if (ce_)
                    {
                        bc_ = cc_ as CqlQuantity;
                    }
                    else
                    {
                        bool cf_ = cc_ is CqlInterval<CqlDateTime>;
                        if (cf_)
                        {
                            bc_ = cc_ as CqlInterval<CqlDateTime>;
                        }
                        else
                        {
                            bool cg_ = cc_ is CqlInterval<CqlQuantity>;
                            if (cg_)
                            {
                                bc_ = cc_ as CqlInterval<CqlQuantity>;
                            }
                            else
                            {
                                bc_ = null;
                            }
                        }
                    }
                }
                CqlInterval<CqlDateTime> bd_ = QICoreCommon_4_0_000.Instance.toInterval(context, bc_);
                CqlDateTime be_ = context.Operators.End(bd_);
                CqlInterval<CqlDate> bf_ = TJCOverall_8_25_000.Instance.calendarDayOfOrDayAfter(context, be_);
                bool? bg_ = bf_?.highClosed;
                CqlInterval<CqlDateTime> bh_ = context.Operators.Interval(aq_, aw_, bb_, bg_);
                bool? bi_ = context.Operators.In<CqlDateTime>(ak_, bh_, "day");
                return (bool?)((CqlBoolean)bi_);
            }

            return (bool?)(/* CQL 'and' (363:5-366:130) */ (/* CQL 'and' (363:11-365:114) */ (/* CQL 'and' (363:11-364:50) */ ((CqlBoolean)n_
                && (CqlBoolean)o_())
                && (CqlBoolean)p_())
                && (CqlBoolean)q_()));
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
                CqlDateTime g_ = context.Operators.LateBoundProperty<CqlDateTime>(PatientRefusal, "authoredOn");
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

            bool? p_() {
                object r_;
                DataType aa_ = tuple_fpeghttqsjgusnbabduddbjbh?.AnesthesiaProcedure?.Performed;
                object ab_ = FHIRHelpers_4_4_000.Instance.ToValue(context, aa_);
                bool ac_ = ab_ is CqlDateTime;
                if (ac_)
                {
                    r_ = ab_ as CqlDateTime;
                }
                else
                {
                    bool ad_ = ab_ is CqlQuantity;
                    if (ad_)
                    {
                        r_ = ab_ as CqlQuantity;
                    }
                    else
                    {
                        bool ae_ = ab_ is CqlInterval<CqlDateTime>;
                        if (ae_)
                        {
                            r_ = ab_ as CqlInterval<CqlDateTime>;
                        }
                        else
                        {
                            bool af_ = ab_ is CqlInterval<CqlQuantity>;
                            if (af_)
                            {
                                r_ = ab_ as CqlInterval<CqlQuantity>;
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
                return (bool?)((CqlBoolean)z_);
            }


            bool? q_() {
                CqlDateTime ag_ = context.Operators.LateBoundProperty<CqlDateTime>(tuple_fpeghttqsjgusnbabduddbjbh?.PatientRefusal, "authoredOn");
                object ah_;
                DataType bf_ = tuple_fpeghttqsjgusnbabduddbjbh?.AnesthesiaProcedure?.Performed;
                object bg_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bf_);
                bool bh_ = bg_ is CqlDateTime;
                if (bh_)
                {
                    ah_ = bg_ as CqlDateTime;
                }
                else
                {
                    bool bi_ = bg_ is CqlQuantity;
                    if (bi_)
                    {
                        ah_ = bg_ as CqlQuantity;
                    }
                    else
                    {
                        bool bj_ = bg_ is CqlInterval<CqlDateTime>;
                        if (bj_)
                        {
                            ah_ = bg_ as CqlInterval<CqlDateTime>;
                        }
                        else
                        {
                            bool bk_ = bg_ is CqlInterval<CqlQuantity>;
                            if (bk_)
                            {
                                ah_ = bg_ as CqlInterval<CqlQuantity>;
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
                CqlDate al_ = ak_?.low;
                CqlDateTime am_ = context.Operators.ConvertDateToDateTime(al_);
                object an_;
                DataType bl_ = tuple_fpeghttqsjgusnbabduddbjbh?.AnesthesiaProcedure?.Performed;
                object bm_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bl_);
                bool bn_ = bm_ is CqlDateTime;
                if (bn_)
                {
                    an_ = bm_ as CqlDateTime;
                }
                else
                {
                    bool bo_ = bm_ is CqlQuantity;
                    if (bo_)
                    {
                        an_ = bm_ as CqlQuantity;
                    }
                    else
                    {
                        bool bp_ = bm_ is CqlInterval<CqlDateTime>;
                        if (bp_)
                        {
                            an_ = bm_ as CqlInterval<CqlDateTime>;
                        }
                        else
                        {
                            bool bq_ = bm_ is CqlInterval<CqlQuantity>;
                            if (bq_)
                            {
                                an_ = bm_ as CqlInterval<CqlQuantity>;
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
                CqlDate ar_ = aq_?.high;
                CqlDateTime as_ = context.Operators.ConvertDateToDateTime(ar_);
                object at_;
                DataType br_ = tuple_fpeghttqsjgusnbabduddbjbh?.AnesthesiaProcedure?.Performed;
                object bs_ = FHIRHelpers_4_4_000.Instance.ToValue(context, br_);
                bool bt_ = bs_ is CqlDateTime;
                if (bt_)
                {
                    at_ = bs_ as CqlDateTime;
                }
                else
                {
                    bool bu_ = bs_ is CqlQuantity;
                    if (bu_)
                    {
                        at_ = bs_ as CqlQuantity;
                    }
                    else
                    {
                        bool bv_ = bs_ is CqlInterval<CqlDateTime>;
                        if (bv_)
                        {
                            at_ = bs_ as CqlInterval<CqlDateTime>;
                        }
                        else
                        {
                            bool bw_ = bs_ is CqlInterval<CqlQuantity>;
                            if (bw_)
                            {
                                at_ = bs_ as CqlInterval<CqlQuantity>;
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
                bool? ax_ = aw_?.lowClosed;
                object ay_;
                DataType bx_ = tuple_fpeghttqsjgusnbabduddbjbh?.AnesthesiaProcedure?.Performed;
                object by_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bx_);
                bool bz_ = by_ is CqlDateTime;
                if (bz_)
                {
                    ay_ = by_ as CqlDateTime;
                }
                else
                {
                    bool ca_ = by_ is CqlQuantity;
                    if (ca_)
                    {
                        ay_ = by_ as CqlQuantity;
                    }
                    else
                    {
                        bool cb_ = by_ is CqlInterval<CqlDateTime>;
                        if (cb_)
                        {
                            ay_ = by_ as CqlInterval<CqlDateTime>;
                        }
                        else
                        {
                            bool cc_ = by_ is CqlInterval<CqlQuantity>;
                            if (cc_)
                            {
                                ay_ = by_ as CqlInterval<CqlQuantity>;
                            }
                            else
                            {
                                ay_ = null;
                            }
                        }
                    }
                }
                CqlInterval<CqlDateTime> az_ = QICoreCommon_4_0_000.Instance.toInterval(context, ay_);
                CqlDateTime ba_ = context.Operators.End(az_);
                CqlInterval<CqlDate> bb_ = TJCOverall_8_25_000.Instance.calendarDayOfOrDayAfter(context, ba_);
                bool? bc_ = bb_?.highClosed;
                CqlInterval<CqlDateTime> bd_ = context.Operators.Interval(am_, as_, ax_, bc_);
                bool? be_ = context.Operators.In<CqlDateTime>(ag_, bd_, "day");
                return (bool?)((CqlBoolean)be_);
            }

            return (bool?)(/* CQL 'and' (429:5-431:133) */ (/* CQL 'and' (429:11-430:114) */ ((CqlBoolean)o_
                && (CqlBoolean)p_())
                && (CqlBoolean)q_()));
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

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
                    CqlConcept n_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);
                    return n_;
                }

                IEnumerable<CqlConcept> k_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)i_, j_);
                CqlValueSet l_ = this.Intensive_Care_Unit(context);
                bool? m_ = context.Operators.ConceptsInValueSet(k_, l_);
                // CQL 'and' (76:9-77:63): right operand skipped when left is false
                if (m_ is false)
                {
                    return false;
                }
                else
                {
                    Period o_ = QualifyingEncounter?.Period;
                    CqlInterval<CqlDateTime> p_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, o_);
                    Period q_ = Location?.Period;
                    CqlInterval<CqlDateTime> r_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, q_);
                    bool? s_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(p_, r_, (string)default);
                    return m_ & s_;
                }
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
            bool? f_;
            // CQL 'or' (92:11-93:83): right operand skipped when left is true
            if (e_ is true)
            {
                f_ = true;
            }
            else
            {
                CqlValueSet k_ = this.Gynecological_Surgery(context);
                bool? l_ = VTE_8_18_000.Instance.hasPrincipalProcedureOf(context, QualifyingEncounterICU, k_);
                f_ = e_ | l_;
            }
            bool? g_;
            // CQL 'or' (92:11-94:82): right operand skipped when left is true
            if (f_ is true)
            {
                g_ = true;
            }
            else
            {
                CqlValueSet m_ = this.Hip_Fracture_Surgery(context);
                bool? n_ = VTE_8_18_000.Instance.hasPrincipalProcedureOf(context, QualifyingEncounterICU, m_);
                g_ = f_ | n_;
            }
            bool? h_;
            // CQL 'or' (92:11-95:85): right operand skipped when left is true
            if (g_ is true)
            {
                h_ = true;
            }
            else
            {
                CqlValueSet o_ = this.Hip_Replacement_Surgery(context);
                bool? p_ = VTE_8_18_000.Instance.hasPrincipalProcedureOf(context, QualifyingEncounterICU, o_);
                h_ = g_ | p_;
            }
            bool? i_;
            // CQL 'or' (92:11-96:87): right operand skipped when left is true
            if (h_ is true)
            {
                i_ = true;
            }
            else
            {
                CqlValueSet q_ = this.Intracranial_Neurosurgery(context);
                bool? r_ = VTE_8_18_000.Instance.hasPrincipalProcedureOf(context, QualifyingEncounterICU, q_);
                i_ = h_ | r_;
            }
            bool? j_;
            // CQL 'or' (92:11-97:86): right operand skipped when left is true
            if (i_ is true)
            {
                j_ = true;
            }
            else
            {
                CqlValueSet s_ = this.Knee_Replacement_Surgery(context);
                bool? t_ = VTE_8_18_000.Instance.hasPrincipalProcedureOf(context, QualifyingEncounterICU, s_);
                j_ = i_ | t_;
            }
            // CQL 'or' (92:5-98:80): right operand skipped when left is true
            if (j_ is true)
            {
                return true;
            }
            else
            {
                CqlValueSet u_ = this.Urological_Surgery(context);
                bool? v_ = VTE_8_18_000.Instance.hasPrincipalProcedureOf(context, QualifyingEncounterICU, u_);
                return j_ | v_;
            }
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
            // CQL 'and' (107:7-108:67): right operand skipped when left is false
            if (n_ is false)
            {
                return false;
            }
            else
            {
                Code<RequestStatus> o_ = InterventionRequest?.StatusElement;
                RequestStatus? p_ = o_?.Value;
                Code<RequestStatus> q_ = context.Operators.Convert<Code<RequestStatus>>(p_);
                string r_ = context.Operators.Convert<string>(q_);
                string[] s_ = [
                    "active",
                    "completed",
                ];
                bool? t_ = context.Operators.In<string>(r_, (IEnumerable<string>)s_);
                return n_ & t_;
            }
        }

        IEnumerable<ServiceRequest> d_ = context.Operators.Where<ServiceRequest>(b_, c_);
        IEnumerable<Procedure> e_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));

        bool? f_(Procedure InterventionPerformed) {
            Code<EventStatus> u_ = InterventionPerformed?.StatusElement;
            EventStatus? v_ = u_?.Value;
            string w_ = context.Operators.Convert<string>(v_);
            string[] x_ = [
                "completed",
                "in-progress",
            ];
            bool? y_ = context.Operators.In<string>(w_, (IEnumerable<string>)x_);
            return y_;
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
            bool? p_;
            // CQL 'and' (119:11-120:121): right operand skipped when left is false
            if (o_ is false)
            {
                p_ = false;
            }
            else
            {
                object q_;
                DataType x_ = tuple_gdefgctjcxpzbyfpuogejrgou?.AnesthesiaProcedure?.Performed;
                object y_ = FHIRHelpers_4_4_000.Instance.ToValue(context, x_);
                bool z_ = y_ is CqlDateTime;
                if (z_)
                {
                    q_ = y_ as CqlDateTime;
                }
                else
                {
                    bool aa_ = y_ is CqlQuantity;
                    if (aa_)
                    {
                        q_ = y_ as CqlQuantity;
                    }
                    else
                    {
                        bool ab_ = y_ is CqlInterval<CqlDateTime>;
                        if (ab_)
                        {
                            q_ = y_ as CqlInterval<CqlDateTime>;
                        }
                        else
                        {
                            bool ac_ = y_ is CqlInterval<CqlQuantity>;
                            if (ac_)
                            {
                                q_ = y_ as CqlInterval<CqlQuantity>;
                            }
                            else
                            {
                                q_ = null;
                            }
                        }
                    }
                }
                CqlInterval<CqlDateTime> r_ = QICoreCommon_4_0_000.Instance.toInterval(context, q_);
                CqlDateTime s_ = context.Operators.End(r_);
                CqlDateTime t_ = this.startOfFirstICU(context, tuple_gdefgctjcxpzbyfpuogejrgou?.QualifyingEncounterICU);
                CqlQuantity u_ = context.Operators.Quantity(1m, "day");
                CqlDateTime v_ = context.Operators.Add(t_, u_);
                bool? w_ = context.Operators.SameAs(s_, v_, "day");
                p_ = o_ & w_;
            }
            // CQL 'and' (119:5-121:191): right operand skipped when left is false
            if (p_ is false)
            {
                return false;
            }
            else
            {
                object ad_;
                object bg_ = context.Operators.LateBoundProperty<object>(tuple_gdefgctjcxpzbyfpuogejrgou?.ComfortMeasure, "performed");
                object bh_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bg_);
                bool bi_ = bh_ is CqlDateTime;
                if (bi_)
                {
                    ad_ = bh_ as CqlDateTime;
                }
                else
                {
                    bool bj_ = bh_ is CqlQuantity;
                    if (bj_)
                    {
                        ad_ = bh_ as CqlQuantity;
                    }
                    else
                    {
                        bool bk_ = bh_ is CqlInterval<CqlDateTime>;
                        if (bk_)
                        {
                            ad_ = bh_ as CqlInterval<CqlDateTime>;
                        }
                        else
                        {
                            bool bl_ = bh_ is CqlInterval<CqlQuantity>;
                            if (bl_)
                            {
                                ad_ = bh_ as CqlInterval<CqlQuantity>;
                            }
                            else
                            {
                                ad_ = null;
                            }
                        }
                    }
                }
                CqlInterval<CqlDateTime> ae_ = QICoreCommon_4_0_000.Instance.toInterval(context, ad_);
                CqlDateTime af_ = context.Operators.Start(ae_);
                object ag_ = context.Operators.LateBoundProperty<object>(tuple_gdefgctjcxpzbyfpuogejrgou?.ComfortMeasure, "authoredOn");
                CqlDateTime ah_ = context.Operators.LateBoundProperty<CqlDateTime>(ag_, "value");
                object ai_;
                DataType bm_ = tuple_gdefgctjcxpzbyfpuogejrgou?.AnesthesiaProcedure?.Performed;
                object bn_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bm_);
                bool bo_ = bn_ is CqlDateTime;
                if (bo_)
                {
                    ai_ = bn_ as CqlDateTime;
                }
                else
                {
                    bool bp_ = bn_ is CqlQuantity;
                    if (bp_)
                    {
                        ai_ = bn_ as CqlQuantity;
                    }
                    else
                    {
                        bool bq_ = bn_ is CqlInterval<CqlDateTime>;
                        if (bq_)
                        {
                            ai_ = bn_ as CqlInterval<CqlDateTime>;
                        }
                        else
                        {
                            bool br_ = bn_ is CqlInterval<CqlQuantity>;
                            if (br_)
                            {
                                ai_ = bn_ as CqlInterval<CqlQuantity>;
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
                CqlDate am_ = al_?.low;
                CqlDateTime an_ = context.Operators.ConvertDateToDateTime(am_);
                object ao_;
                DataType bs_ = tuple_gdefgctjcxpzbyfpuogejrgou?.AnesthesiaProcedure?.Performed;
                object bt_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bs_);
                bool bu_ = bt_ is CqlDateTime;
                if (bu_)
                {
                    ao_ = bt_ as CqlDateTime;
                }
                else
                {
                    bool bv_ = bt_ is CqlQuantity;
                    if (bv_)
                    {
                        ao_ = bt_ as CqlQuantity;
                    }
                    else
                    {
                        bool bw_ = bt_ is CqlInterval<CqlDateTime>;
                        if (bw_)
                        {
                            ao_ = bt_ as CqlInterval<CqlDateTime>;
                        }
                        else
                        {
                            bool bx_ = bt_ is CqlInterval<CqlQuantity>;
                            if (bx_)
                            {
                                ao_ = bt_ as CqlInterval<CqlQuantity>;
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
                CqlDate as_ = ar_?.high;
                CqlDateTime at_ = context.Operators.ConvertDateToDateTime(as_);
                object au_;
                DataType by_ = tuple_gdefgctjcxpzbyfpuogejrgou?.AnesthesiaProcedure?.Performed;
                object bz_ = FHIRHelpers_4_4_000.Instance.ToValue(context, by_);
                bool ca_ = bz_ is CqlDateTime;
                if (ca_)
                {
                    au_ = bz_ as CqlDateTime;
                }
                else
                {
                    bool cb_ = bz_ is CqlQuantity;
                    if (cb_)
                    {
                        au_ = bz_ as CqlQuantity;
                    }
                    else
                    {
                        bool cc_ = bz_ is CqlInterval<CqlDateTime>;
                        if (cc_)
                        {
                            au_ = bz_ as CqlInterval<CqlDateTime>;
                        }
                        else
                        {
                            bool cd_ = bz_ is CqlInterval<CqlQuantity>;
                            if (cd_)
                            {
                                au_ = bz_ as CqlInterval<CqlQuantity>;
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
                CqlInterval<CqlDate> ax_ = TJCOverall_8_25_000.Instance.calendarDayOfOrDayAfter(context, aw_);
                bool? ay_ = ax_?.lowClosed;
                object az_;
                DataType ce_ = tuple_gdefgctjcxpzbyfpuogejrgou?.AnesthesiaProcedure?.Performed;
                object cf_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ce_);
                bool cg_ = cf_ is CqlDateTime;
                if (cg_)
                {
                    az_ = cf_ as CqlDateTime;
                }
                else
                {
                    bool ch_ = cf_ is CqlQuantity;
                    if (ch_)
                    {
                        az_ = cf_ as CqlQuantity;
                    }
                    else
                    {
                        bool ci_ = cf_ is CqlInterval<CqlDateTime>;
                        if (ci_)
                        {
                            az_ = cf_ as CqlInterval<CqlDateTime>;
                        }
                        else
                        {
                            bool cj_ = cf_ is CqlInterval<CqlQuantity>;
                            if (cj_)
                            {
                                az_ = cf_ as CqlInterval<CqlQuantity>;
                            }
                            else
                            {
                                az_ = null;
                            }
                        }
                    }
                }
                CqlInterval<CqlDateTime> ba_ = QICoreCommon_4_0_000.Instance.toInterval(context, az_);
                CqlDateTime bb_ = context.Operators.End(ba_);
                CqlInterval<CqlDate> bc_ = TJCOverall_8_25_000.Instance.calendarDayOfOrDayAfter(context, bb_);
                bool? bd_ = bc_?.highClosed;
                CqlInterval<CqlDateTime> be_ = context.Operators.Interval(an_, at_, ay_, bd_);
                bool? bf_ = context.Operators.In<CqlDateTime>(af_ ?? ah_, be_, "day");
                return p_ & bf_;
            }
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
                bool? bg_ = context.Operators.Equal(bc_, bf_);
                // CQL 'and': right operand skipped when left is false
                if (bg_ is false)
                {
                    return false;
                }
                else
                {
                    CodeableConcept bh_ = M?.Code;
                    CqlConcept bi_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, bh_);
                    CqlValueSet bj_ = this.Low_Dose_Unfractionated_Heparin_for_VTE_Prophylaxis(context);
                    bool? bk_ = context.Operators.ConceptInValueSet(bi_, bj_);
                    return bg_ & bk_;
                }
            }

            bool? bb_ = context.Operators.WhereAny<Medication>(az_, ba_);
            return bb_;
        }

        IEnumerable<MedicationAdministration> c_ = context.Operators.Where<MedicationAdministration>(a_, b_);
        CqlValueSet d_ = this.Low_Dose_Unfractionated_Heparin_for_VTE_Prophylaxis(context);
        IEnumerable<MedicationAdministration> e_ = context.Operators.Retrieve<MedicationAdministration>(new RetrieveParameters(default, d_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationadministration"));
        IEnumerable<MedicationAdministration> f_ = context.Operators.Union<MedicationAdministration>(c_, e_);

        bool? g_(MedicationAdministration VTEMedication) {
            Code<MedicationAdministration.MedicationAdministrationStatusCodes> bl_ = VTEMedication?.StatusElement;
            MedicationAdministration.MedicationAdministrationStatusCodes? bm_ = bl_?.Value;
            string bn_ = context.Operators.Convert<string>(bm_);
            bool? bo_ = context.Operators.Equal(bn_, "completed");
            // CQL 'and' (137:7-138:62): right operand skipped when left is false
            if (bo_ is false)
            {
                return false;
            }
            else
            {
                MedicationAdministration.DosageComponent bp_ = VTEMedication?.Dosage;
                CodeableConcept bq_ = bp_?.Route;
                CqlConcept br_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, bq_);
                CqlValueSet bs_ = this.Subcutaneous_route(context);
                bool? bt_ = context.Operators.ConceptInValueSet(br_, bs_);
                return bo_ & bt_;
            }
        }

        IEnumerable<MedicationAdministration> h_ = context.Operators.Where<MedicationAdministration>(f_, g_);

        bool? i_(MedicationAdministration MR) {
            IEnumerable<Medication> bu_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));

            bool? bv_(Medication M) {
                object bx_ = context.Operators.LateBoundProperty<object>(M, "id.value");
                object by_ = context.Operators.LateBoundProperty<object>(MR, "medication.reference.value");
                IEnumerable<string> bz_ = context.Operators.Split((string)by_, "/");
                string ca_ = context.Operators.Last<string>(bz_);
                bool? cb_ = context.Operators.Equal(bx_, ca_);
                // CQL 'and': right operand skipped when left is false
                if (cb_ is false)
                {
                    return false;
                }
                else
                {
                    CodeableConcept cc_ = M?.Code;
                    CqlConcept cd_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, cc_);
                    CqlValueSet ce_ = this.Low_Molecular_Weight_Heparin_for_VTE_Prophylaxis(context);
                    bool? cf_ = context.Operators.ConceptInValueSet(cd_, ce_);
                    return cb_ & cf_;
                }
            }

            bool? bw_ = context.Operators.WhereAny<Medication>(bu_, bv_);
            return bw_;
        }

        IEnumerable<MedicationAdministration> j_ = context.Operators.Where<MedicationAdministration>(a_, i_);
        CqlValueSet k_ = this.Low_Molecular_Weight_Heparin_for_VTE_Prophylaxis(context);
        IEnumerable<MedicationAdministration> l_ = context.Operators.Retrieve<MedicationAdministration>(new RetrieveParameters(default, k_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationadministration"));
        IEnumerable<MedicationAdministration> m_ = context.Operators.Union<MedicationAdministration>(j_, l_);

        bool? n_(MedicationAdministration LMWH) {
            Code<MedicationAdministration.MedicationAdministrationStatusCodes> cg_ = LMWH?.StatusElement;
            MedicationAdministration.MedicationAdministrationStatusCodes? ch_ = cg_?.Value;
            string ci_ = context.Operators.Convert<string>(ch_);
            bool? cj_ = context.Operators.Equal(ci_, "completed");
            return cj_;
        }

        IEnumerable<MedicationAdministration> o_ = context.Operators.Where<MedicationAdministration>(m_, n_);
        IEnumerable<MedicationAdministration> p_ = context.Operators.Union<MedicationAdministration>(h_, o_);

        bool? q_(MedicationAdministration MR) {
            IEnumerable<Medication> ck_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));

            bool? cl_(Medication M) {
                object cn_ = context.Operators.LateBoundProperty<object>(M, "id.value");
                object co_ = context.Operators.LateBoundProperty<object>(MR, "medication.reference.value");
                IEnumerable<string> cp_ = context.Operators.Split((string)co_, "/");
                string cq_ = context.Operators.Last<string>(cp_);
                bool? cr_ = context.Operators.Equal(cn_, cq_);
                // CQL 'and': right operand skipped when left is false
                if (cr_ is false)
                {
                    return false;
                }
                else
                {
                    CodeableConcept cs_ = M?.Code;
                    CqlConcept ct_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, cs_);
                    CqlValueSet cu_ = this.Injectable_Factor_Xa_Inhibitor_for_VTE_Prophylaxis(context);
                    bool? cv_ = context.Operators.ConceptInValueSet(ct_, cu_);
                    return cr_ & cv_;
                }
            }

            bool? cm_ = context.Operators.WhereAny<Medication>(ck_, cl_);
            return cm_;
        }

        IEnumerable<MedicationAdministration> r_ = context.Operators.Where<MedicationAdministration>(a_, q_);
        CqlValueSet s_ = this.Injectable_Factor_Xa_Inhibitor_for_VTE_Prophylaxis(context);
        IEnumerable<MedicationAdministration> t_ = context.Operators.Retrieve<MedicationAdministration>(new RetrieveParameters(default, s_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationadministration"));
        IEnumerable<MedicationAdministration> u_ = context.Operators.Union<MedicationAdministration>(r_, t_);

        bool? v_(MedicationAdministration FactorXa) {
            Code<MedicationAdministration.MedicationAdministrationStatusCodes> cw_ = FactorXa?.StatusElement;
            MedicationAdministration.MedicationAdministrationStatusCodes? cx_ = cw_?.Value;
            string cy_ = context.Operators.Convert<string>(cx_);
            bool? cz_ = context.Operators.Equal(cy_, "completed");
            return cz_;
        }

        IEnumerable<MedicationAdministration> w_ = context.Operators.Where<MedicationAdministration>(u_, v_);

        bool? x_(MedicationAdministration MR) {
            IEnumerable<Medication> da_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));

            bool? db_(Medication M) {
                object dd_ = context.Operators.LateBoundProperty<object>(M, "id.value");
                object de_ = context.Operators.LateBoundProperty<object>(MR, "medication.reference.value");
                IEnumerable<string> df_ = context.Operators.Split((string)de_, "/");
                string dg_ = context.Operators.Last<string>(df_);
                bool? dh_ = context.Operators.Equal(dd_, dg_);
                // CQL 'and': right operand skipped when left is false
                if (dh_ is false)
                {
                    return false;
                }
                else
                {
                    CodeableConcept di_ = M?.Code;
                    CqlConcept dj_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, di_);
                    CqlValueSet dk_ = this.Warfarin(context);
                    bool? dl_ = context.Operators.ConceptInValueSet(dj_, dk_);
                    return dh_ & dl_;
                }
            }

            bool? dc_ = context.Operators.WhereAny<Medication>(da_, db_);
            return dc_;
        }

        IEnumerable<MedicationAdministration> y_ = context.Operators.Where<MedicationAdministration>(a_, x_);
        CqlValueSet z_ = this.Warfarin(context);
        IEnumerable<MedicationAdministration> aa_ = context.Operators.Retrieve<MedicationAdministration>(new RetrieveParameters(default, z_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationadministration"));
        IEnumerable<MedicationAdministration> ab_ = context.Operators.Union<MedicationAdministration>(y_, aa_);

        bool? ac_(MedicationAdministration WarfarinAdm) {
            Code<MedicationAdministration.MedicationAdministrationStatusCodes> dm_ = WarfarinAdm?.StatusElement;
            MedicationAdministration.MedicationAdministrationStatusCodes? dn_ = dm_?.Value;
            string do_ = context.Operators.Convert<string>(dn_);
            bool? dp_ = context.Operators.Equal(do_, "completed");
            return dp_;
        }

        IEnumerable<MedicationAdministration> ad_ = context.Operators.Where<MedicationAdministration>(ab_, ac_);
        IEnumerable<MedicationAdministration> ae_ = context.Operators.Union<MedicationAdministration>(w_, ad_);
        IEnumerable<MedicationAdministration> af_ = context.Operators.Union<MedicationAdministration>(p_, ae_);

        bool? ag_(MedicationAdministration MR) {
            IEnumerable<Medication> dq_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));

            bool? dr_(Medication M) {
                object dt_ = context.Operators.LateBoundProperty<object>(M, "id.value");
                object du_ = context.Operators.LateBoundProperty<object>(MR, "medication.reference.value");
                IEnumerable<string> dv_ = context.Operators.Split((string)du_, "/");
                string dw_ = context.Operators.Last<string>(dv_);
                bool? dx_ = context.Operators.Equal(dt_, dw_);
                // CQL 'and': right operand skipped when left is false
                if (dx_ is false)
                {
                    return false;
                }
                else
                {
                    CodeableConcept dy_ = M?.Code;
                    CqlConcept dz_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, dy_);
                    CqlValueSet ea_ = this.Rivaroxaban_for_VTE_Prophylaxis(context);
                    bool? eb_ = context.Operators.ConceptInValueSet(dz_, ea_);
                    return dx_ & eb_;
                }
            }

            bool? ds_ = context.Operators.WhereAny<Medication>(dq_, dr_);
            return ds_;
        }

        IEnumerable<MedicationAdministration> ah_ = context.Operators.Where<MedicationAdministration>(a_, ag_);
        CqlValueSet ai_ = this.Rivaroxaban_for_VTE_Prophylaxis(context);
        IEnumerable<MedicationAdministration> aj_ = context.Operators.Retrieve<MedicationAdministration>(new RetrieveParameters(default, ai_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationadministration"));
        IEnumerable<MedicationAdministration> ak_ = context.Operators.Union<MedicationAdministration>(ah_, aj_);

        bool? al_(MedicationAdministration Rivaroxaban) {
            Code<MedicationAdministration.MedicationAdministrationStatusCodes> ec_ = Rivaroxaban?.StatusElement;
            MedicationAdministration.MedicationAdministrationStatusCodes? ed_ = ec_?.Value;
            string ee_ = context.Operators.Convert<string>(ed_);
            bool? ef_ = context.Operators.Equal(ee_, "completed");
            return ef_;
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
            Code<EventStatus> eg_ = DeviceApplied?.StatusElement;
            EventStatus? eh_ = eg_?.Value;
            string ei_ = context.Operators.Convert<string>(eh_);
            bool? ej_ = context.Operators.Equal(ei_, "completed");
            return ej_;
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
            (CqlTupleMetadata, Encounter QualifyingEncounterICU, Procedure AnesthesiaProcedure, object VTEProphylaxis)? am_ = (CqlTupleMetadata_CGYAgYdKXUHcFINAPjMZNihh, _valueTuple.Item1, _valueTuple.Item2, _valueTuple.Item3);
            return am_;
        }


        bool? i_((CqlTupleMetadata, Encounter QualifyingEncounterICU, Procedure AnesthesiaProcedure, object VTEProphylaxis)? tuple_drnlhywkgwmzdeyzybtiilbhf) {
            Code<EventStatus> an_ = tuple_drnlhywkgwmzdeyzybtiilbhf?.AnesthesiaProcedure?.StatusElement;
            EventStatus? ao_ = an_?.Value;
            string ap_ = context.Operators.Convert<string>(ao_);
            bool? aq_ = context.Operators.Equal(ap_, "completed");
            bool? ar_;
            // CQL 'and' (167:15-168:125): right operand skipped when left is false
            if (aq_ is false)
            {
                ar_ = false;
            }
            else
            {
                object as_;
                DataType az_ = tuple_drnlhywkgwmzdeyzybtiilbhf?.AnesthesiaProcedure?.Performed;
                object ba_ = FHIRHelpers_4_4_000.Instance.ToValue(context, az_);
                bool bb_ = ba_ is CqlDateTime;
                if (bb_)
                {
                    as_ = ba_ as CqlDateTime;
                }
                else
                {
                    bool bc_ = ba_ is CqlQuantity;
                    if (bc_)
                    {
                        as_ = ba_ as CqlQuantity;
                    }
                    else
                    {
                        bool bd_ = ba_ is CqlInterval<CqlDateTime>;
                        if (bd_)
                        {
                            as_ = ba_ as CqlInterval<CqlDateTime>;
                        }
                        else
                        {
                            bool be_ = ba_ is CqlInterval<CqlQuantity>;
                            if (be_)
                            {
                                as_ = ba_ as CqlInterval<CqlQuantity>;
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
                CqlDateTime av_ = this.startOfFirstICU(context, tuple_drnlhywkgwmzdeyzybtiilbhf?.QualifyingEncounterICU);
                CqlQuantity aw_ = context.Operators.Quantity(1m, "day");
                CqlDateTime ax_ = context.Operators.Add(av_, aw_);
                bool? ay_ = context.Operators.SameAs(au_, ax_, "day");
                ar_ = aq_ & ay_;
            }
            // CQL 'and' (167:9-169:207): right operand skipped when left is false
            if (ar_ is false)
            {
                return false;
            }
            else
            {
                object bf_ = context.Operators.LateBoundProperty<object>(tuple_drnlhywkgwmzdeyzybtiilbhf?.VTEProphylaxis, "effective");
                object bg_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bf_);
                CqlInterval<CqlDateTime> bh_ = QICoreCommon_4_0_000.Instance.toInterval(context, bg_);
                object bi_;
                object cj_ = context.Operators.LateBoundProperty<object>(tuple_drnlhywkgwmzdeyzybtiilbhf?.VTEProphylaxis, "performed");
                object ck_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cj_);
                bool cl_ = ck_ is CqlDateTime;
                if (cl_)
                {
                    bi_ = ck_ as CqlDateTime;
                }
                else
                {
                    bool cm_ = ck_ is CqlQuantity;
                    if (cm_)
                    {
                        bi_ = ck_ as CqlQuantity;
                    }
                    else
                    {
                        bool cn_ = ck_ is CqlInterval<CqlDateTime>;
                        if (cn_)
                        {
                            bi_ = ck_ as CqlInterval<CqlDateTime>;
                        }
                        else
                        {
                            bool co_ = ck_ is CqlInterval<CqlQuantity>;
                            if (co_)
                            {
                                bi_ = ck_ as CqlInterval<CqlQuantity>;
                            }
                            else
                            {
                                bi_ = null;
                            }
                        }
                    }
                }
                CqlInterval<CqlDateTime> bj_ = QICoreCommon_4_0_000.Instance.toInterval(context, bi_);
                CqlDateTime bk_ = context.Operators.Start(bh_ ?? bj_);
                object bl_;
                DataType cp_ = tuple_drnlhywkgwmzdeyzybtiilbhf?.AnesthesiaProcedure?.Performed;
                object cq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cp_);
                bool cr_ = cq_ is CqlDateTime;
                if (cr_)
                {
                    bl_ = cq_ as CqlDateTime;
                }
                else
                {
                    bool cs_ = cq_ is CqlQuantity;
                    if (cs_)
                    {
                        bl_ = cq_ as CqlQuantity;
                    }
                    else
                    {
                        bool ct_ = cq_ is CqlInterval<CqlDateTime>;
                        if (ct_)
                        {
                            bl_ = cq_ as CqlInterval<CqlDateTime>;
                        }
                        else
                        {
                            bool cu_ = cq_ is CqlInterval<CqlQuantity>;
                            if (cu_)
                            {
                                bl_ = cq_ as CqlInterval<CqlQuantity>;
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
                CqlDate bp_ = bo_?.low;
                CqlDateTime bq_ = context.Operators.ConvertDateToDateTime(bp_);
                object br_;
                DataType cv_ = tuple_drnlhywkgwmzdeyzybtiilbhf?.AnesthesiaProcedure?.Performed;
                object cw_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cv_);
                bool cx_ = cw_ is CqlDateTime;
                if (cx_)
                {
                    br_ = cw_ as CqlDateTime;
                }
                else
                {
                    bool cy_ = cw_ is CqlQuantity;
                    if (cy_)
                    {
                        br_ = cw_ as CqlQuantity;
                    }
                    else
                    {
                        bool cz_ = cw_ is CqlInterval<CqlDateTime>;
                        if (cz_)
                        {
                            br_ = cw_ as CqlInterval<CqlDateTime>;
                        }
                        else
                        {
                            bool da_ = cw_ is CqlInterval<CqlQuantity>;
                            if (da_)
                            {
                                br_ = cw_ as CqlInterval<CqlQuantity>;
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
                CqlDate bv_ = bu_?.high;
                CqlDateTime bw_ = context.Operators.ConvertDateToDateTime(bv_);
                object bx_;
                DataType db_ = tuple_drnlhywkgwmzdeyzybtiilbhf?.AnesthesiaProcedure?.Performed;
                object dc_ = FHIRHelpers_4_4_000.Instance.ToValue(context, db_);
                bool dd_ = dc_ is CqlDateTime;
                if (dd_)
                {
                    bx_ = dc_ as CqlDateTime;
                }
                else
                {
                    bool de_ = dc_ is CqlQuantity;
                    if (de_)
                    {
                        bx_ = dc_ as CqlQuantity;
                    }
                    else
                    {
                        bool df_ = dc_ is CqlInterval<CqlDateTime>;
                        if (df_)
                        {
                            bx_ = dc_ as CqlInterval<CqlDateTime>;
                        }
                        else
                        {
                            bool dg_ = dc_ is CqlInterval<CqlQuantity>;
                            if (dg_)
                            {
                                bx_ = dc_ as CqlInterval<CqlQuantity>;
                            }
                            else
                            {
                                bx_ = null;
                            }
                        }
                    }
                }
                CqlInterval<CqlDateTime> by_ = QICoreCommon_4_0_000.Instance.toInterval(context, bx_);
                CqlDateTime bz_ = context.Operators.End(by_);
                CqlInterval<CqlDate> ca_ = TJCOverall_8_25_000.Instance.calendarDayOfOrDayAfter(context, bz_);
                bool? cb_ = ca_?.lowClosed;
                object cc_;
                DataType dh_ = tuple_drnlhywkgwmzdeyzybtiilbhf?.AnesthesiaProcedure?.Performed;
                object di_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dh_);
                bool dj_ = di_ is CqlDateTime;
                if (dj_)
                {
                    cc_ = di_ as CqlDateTime;
                }
                else
                {
                    bool dk_ = di_ is CqlQuantity;
                    if (dk_)
                    {
                        cc_ = di_ as CqlQuantity;
                    }
                    else
                    {
                        bool dl_ = di_ is CqlInterval<CqlDateTime>;
                        if (dl_)
                        {
                            cc_ = di_ as CqlInterval<CqlDateTime>;
                        }
                        else
                        {
                            bool dm_ = di_ is CqlInterval<CqlQuantity>;
                            if (dm_)
                            {
                                cc_ = di_ as CqlInterval<CqlQuantity>;
                            }
                            else
                            {
                                cc_ = null;
                            }
                        }
                    }
                }
                CqlInterval<CqlDateTime> cd_ = QICoreCommon_4_0_000.Instance.toInterval(context, cc_);
                CqlDateTime ce_ = context.Operators.End(cd_);
                CqlInterval<CqlDate> cf_ = TJCOverall_8_25_000.Instance.calendarDayOfOrDayAfter(context, ce_);
                bool? cg_ = cf_?.highClosed;
                CqlInterval<CqlDateTime> ch_ = context.Operators.Interval(bq_, bw_, cb_, cg_);
                bool? ci_ = context.Operators.In<CqlDateTime>(bk_, ch_, "day");
                return ar_ & ci_;
            }
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
                    bool? ah_ = context.Operators.Equal(ad_, ag_);
                    // CQL 'and': right operand skipped when left is false
                    if (ah_ is false)
                    {
                        return false;
                    }
                    else
                    {
                        CodeableConcept ai_ = M?.Code;
                        CqlConcept aj_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, ai_);
                        CqlValueSet ak_ = this.Oral_Factor_Xa_Inhibitor_for_VTE_Prophylaxis_or_VTE_Treatment(context);
                        bool? al_ = context.Operators.ConceptInValueSet(aj_, ak_);
                        return ah_ & al_;
                    }
                }

                bool? ac_ = context.Operators.WhereAny<Medication>(aa_, ab_);
                return ac_;
            }

            IEnumerable<MedicationAdministration> u_ = context.Operators.Where<MedicationAdministration>(s_, t_);
            CqlValueSet v_ = this.Oral_Factor_Xa_Inhibitor_for_VTE_Prophylaxis_or_VTE_Treatment(context);
            IEnumerable<MedicationAdministration> w_ = context.Operators.Retrieve<MedicationAdministration>(new RetrieveParameters(default, v_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationadministration"));
            IEnumerable<MedicationAdministration> x_ = context.Operators.Union<MedicationAdministration>(u_, w_);

            bool? y_(MedicationAdministration FactorXaMedication) {
                Code<MedicationAdministration.MedicationAdministrationStatusCodes> am_ = FactorXaMedication?.StatusElement;
                MedicationAdministration.MedicationAdministrationStatusCodes? an_ = am_?.Value;
                string ao_ = context.Operators.Convert<string>(an_);
                bool? ap_ = context.Operators.Equal(ao_, "completed");
                // CQL 'and' (176:19-177:149): right operand skipped when left is false
                if (ap_ is false)
                {
                    return false;
                }
                else
                {
                    DataType aq_ = FactorXaMedication?.Effective;
                    object ar_ = FHIRHelpers_4_4_000.Instance.ToValue(context, aq_);
                    CqlInterval<CqlDateTime> as_ = QICoreCommon_4_0_000.Instance.toInterval(context, ar_);
                    CqlDateTime at_ = context.Operators.Start(as_);
                    CqlDateTime au_ = this.startOfFirstICU(context, QualifyingEncounterICU);
                    CqlInterval<CqlDate> av_ = TJCOverall_8_25_000.Instance.calendarDayOfOrDayAfter(context, au_);
                    CqlDate aw_ = av_?.low;
                    CqlDateTime ax_ = context.Operators.ConvertDateToDateTime(aw_);
                    CqlDate ay_ = av_?.high;
                    CqlDateTime az_ = context.Operators.ConvertDateToDateTime(ay_);
                    bool? ba_ = av_?.lowClosed;
                    bool? bb_ = av_?.highClosed;
                    CqlInterval<CqlDateTime> bc_ = context.Operators.Interval(ax_, az_, ba_, bb_);
                    bool? bd_ = context.Operators.In<CqlDateTime>(at_, bc_, "day");
                    return ap_ & bd_;
                }
            }

            bool? z_ = context.Operators.WhereAny<MedicationAdministration>(x_, y_);
            return z_;
        }

        IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);
        CqlValueSet d_ = this.General_or_Neuraxial_Anesthesia(context);
        IEnumerable<Procedure> e_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, d_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
        IEnumerable<MedicationAdministration> f_ = context.Operators.Retrieve<MedicationAdministration>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationadministration"));

        bool? g_(MedicationAdministration MR) {
            IEnumerable<Medication> be_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));

            bool? bf_(Medication M) {
                object bh_ = context.Operators.LateBoundProperty<object>(M, "id.value");
                object bi_ = context.Operators.LateBoundProperty<object>(MR, "medication.reference.value");
                IEnumerable<string> bj_ = context.Operators.Split((string)bi_, "/");
                string bk_ = context.Operators.Last<string>(bj_);
                bool? bl_ = context.Operators.Equal(bh_, bk_);
                // CQL 'and': right operand skipped when left is false
                if (bl_ is false)
                {
                    return false;
                }
                else
                {
                    CodeableConcept bm_ = M?.Code;
                    CqlConcept bn_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, bm_);
                    CqlValueSet bo_ = this.Oral_Factor_Xa_Inhibitor_for_VTE_Prophylaxis_or_VTE_Treatment(context);
                    bool? bp_ = context.Operators.ConceptInValueSet(bn_, bo_);
                    return bl_ & bp_;
                }
            }

            bool? bg_ = context.Operators.WhereAny<Medication>(be_, bf_);
            return bg_;
        }

        IEnumerable<MedicationAdministration> h_ = context.Operators.Where<MedicationAdministration>(f_, g_);
        CqlValueSet i_ = this.Oral_Factor_Xa_Inhibitor_for_VTE_Prophylaxis_or_VTE_Treatment(context);
        IEnumerable<MedicationAdministration> j_ = context.Operators.Retrieve<MedicationAdministration>(new RetrieveParameters(default, i_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationadministration"));
        IEnumerable<MedicationAdministration> k_ = context.Operators.Union<MedicationAdministration>(h_, j_);
        IEnumerable<ValueTuple<Encounter, Procedure, MedicationAdministration>> l_ = context.Operators.CrossJoin<Encounter, Procedure, MedicationAdministration>(a_, e_, k_);

        (CqlTupleMetadata, Encounter QualifyingEncounterICU, Procedure AnesthesiaProcedure, MedicationAdministration FactorXaMedication)? m_(ValueTuple<Encounter, Procedure, MedicationAdministration> _valueTuple) {
            (CqlTupleMetadata, Encounter QualifyingEncounterICU, Procedure AnesthesiaProcedure, MedicationAdministration FactorXaMedication)? bq_ = (CqlTupleMetadata_IGcdIOTLGJfibgSLNOGSFRVB, _valueTuple.Item1, _valueTuple.Item2, _valueTuple.Item3);
            return bq_;
        }


        bool? n_((CqlTupleMetadata, Encounter QualifyingEncounterICU, Procedure AnesthesiaProcedure, MedicationAdministration FactorXaMedication)? tuple_elrfucfgncrbdgahdtkitiyzu) {
            Code<MedicationAdministration.MedicationAdministrationStatusCodes> br_ = tuple_elrfucfgncrbdgahdtkitiyzu?.FactorXaMedication?.StatusElement;
            MedicationAdministration.MedicationAdministrationStatusCodes? bs_ = br_?.Value;
            string bt_ = context.Operators.Convert<string>(bs_);
            bool? bu_ = context.Operators.Equal(bt_, "completed");
            bool? bv_;
            // CQL 'and' (183:15-184:54): right operand skipped when left is false
            if (bu_ is false)
            {
                bv_ = false;
            }
            else
            {
                Code<EventStatus> bx_ = tuple_elrfucfgncrbdgahdtkitiyzu?.AnesthesiaProcedure?.StatusElement;
                EventStatus? by_ = bx_?.Value;
                string bz_ = context.Operators.Convert<string>(by_);
                bool? ca_ = context.Operators.Equal(bz_, "completed");
                bv_ = bu_ & ca_;
            }
            bool? bw_;
            // CQL 'and' (183:15-185:125): right operand skipped when left is false
            if (bv_ is false)
            {
                bw_ = false;
            }
            else
            {
                object cb_;
                DataType ci_ = tuple_elrfucfgncrbdgahdtkitiyzu?.AnesthesiaProcedure?.Performed;
                object cj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ci_);
                bool ck_ = cj_ is CqlDateTime;
                if (ck_)
                {
                    cb_ = cj_ as CqlDateTime;
                }
                else
                {
                    bool cl_ = cj_ is CqlQuantity;
                    if (cl_)
                    {
                        cb_ = cj_ as CqlQuantity;
                    }
                    else
                    {
                        bool cm_ = cj_ is CqlInterval<CqlDateTime>;
                        if (cm_)
                        {
                            cb_ = cj_ as CqlInterval<CqlDateTime>;
                        }
                        else
                        {
                            bool cn_ = cj_ is CqlInterval<CqlQuantity>;
                            if (cn_)
                            {
                                cb_ = cj_ as CqlInterval<CqlQuantity>;
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
                CqlDateTime ce_ = this.startOfFirstICU(context, tuple_elrfucfgncrbdgahdtkitiyzu?.QualifyingEncounterICU);
                CqlQuantity cf_ = context.Operators.Quantity(1m, "day");
                CqlDateTime cg_ = context.Operators.Add(ce_, cf_);
                bool? ch_ = context.Operators.SameAs(cd_, cg_, "day");
                bw_ = bv_ & ch_;
            }
            // CQL 'and' (183:9-186:162): right operand skipped when left is false
            if (bw_ is false)
            {
                return false;
            }
            else
            {
                DataType co_ = tuple_elrfucfgncrbdgahdtkitiyzu?.FactorXaMedication?.Effective;
                object cp_ = FHIRHelpers_4_4_000.Instance.ToValue(context, co_);
                CqlInterval<CqlDateTime> cq_ = QICoreCommon_4_0_000.Instance.toInterval(context, cp_);
                CqlDateTime cr_ = context.Operators.Start(cq_);
                object cs_;
                DataType dq_ = tuple_elrfucfgncrbdgahdtkitiyzu?.AnesthesiaProcedure?.Performed;
                object dr_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dq_);
                bool ds_ = dr_ is CqlDateTime;
                if (ds_)
                {
                    cs_ = dr_ as CqlDateTime;
                }
                else
                {
                    bool dt_ = dr_ is CqlQuantity;
                    if (dt_)
                    {
                        cs_ = dr_ as CqlQuantity;
                    }
                    else
                    {
                        bool du_ = dr_ is CqlInterval<CqlDateTime>;
                        if (du_)
                        {
                            cs_ = dr_ as CqlInterval<CqlDateTime>;
                        }
                        else
                        {
                            bool dv_ = dr_ is CqlInterval<CqlQuantity>;
                            if (dv_)
                            {
                                cs_ = dr_ as CqlInterval<CqlQuantity>;
                            }
                            else
                            {
                                cs_ = null;
                            }
                        }
                    }
                }
                CqlInterval<CqlDateTime> ct_ = QICoreCommon_4_0_000.Instance.toInterval(context, cs_);
                CqlDateTime cu_ = context.Operators.End(ct_);
                CqlInterval<CqlDate> cv_ = TJCOverall_8_25_000.Instance.calendarDayOfOrDayAfter(context, cu_);
                CqlDate cw_ = cv_?.low;
                CqlDateTime cx_ = context.Operators.ConvertDateToDateTime(cw_);
                object cy_;
                DataType dw_ = tuple_elrfucfgncrbdgahdtkitiyzu?.AnesthesiaProcedure?.Performed;
                object dx_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dw_);
                bool dy_ = dx_ is CqlDateTime;
                if (dy_)
                {
                    cy_ = dx_ as CqlDateTime;
                }
                else
                {
                    bool dz_ = dx_ is CqlQuantity;
                    if (dz_)
                    {
                        cy_ = dx_ as CqlQuantity;
                    }
                    else
                    {
                        bool ea_ = dx_ is CqlInterval<CqlDateTime>;
                        if (ea_)
                        {
                            cy_ = dx_ as CqlInterval<CqlDateTime>;
                        }
                        else
                        {
                            bool eb_ = dx_ is CqlInterval<CqlQuantity>;
                            if (eb_)
                            {
                                cy_ = dx_ as CqlInterval<CqlQuantity>;
                            }
                            else
                            {
                                cy_ = null;
                            }
                        }
                    }
                }
                CqlInterval<CqlDateTime> cz_ = QICoreCommon_4_0_000.Instance.toInterval(context, cy_);
                CqlDateTime da_ = context.Operators.End(cz_);
                CqlInterval<CqlDate> db_ = TJCOverall_8_25_000.Instance.calendarDayOfOrDayAfter(context, da_);
                CqlDate dc_ = db_?.high;
                CqlDateTime dd_ = context.Operators.ConvertDateToDateTime(dc_);
                object de_;
                DataType ec_ = tuple_elrfucfgncrbdgahdtkitiyzu?.AnesthesiaProcedure?.Performed;
                object ed_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ec_);
                bool ee_ = ed_ is CqlDateTime;
                if (ee_)
                {
                    de_ = ed_ as CqlDateTime;
                }
                else
                {
                    bool ef_ = ed_ is CqlQuantity;
                    if (ef_)
                    {
                        de_ = ed_ as CqlQuantity;
                    }
                    else
                    {
                        bool eg_ = ed_ is CqlInterval<CqlDateTime>;
                        if (eg_)
                        {
                            de_ = ed_ as CqlInterval<CqlDateTime>;
                        }
                        else
                        {
                            bool eh_ = ed_ is CqlInterval<CqlQuantity>;
                            if (eh_)
                            {
                                de_ = ed_ as CqlInterval<CqlQuantity>;
                            }
                            else
                            {
                                de_ = null;
                            }
                        }
                    }
                }
                CqlInterval<CqlDateTime> df_ = QICoreCommon_4_0_000.Instance.toInterval(context, de_);
                CqlDateTime dg_ = context.Operators.End(df_);
                CqlInterval<CqlDate> dh_ = TJCOverall_8_25_000.Instance.calendarDayOfOrDayAfter(context, dg_);
                bool? di_ = dh_?.lowClosed;
                object dj_;
                DataType ei_ = tuple_elrfucfgncrbdgahdtkitiyzu?.AnesthesiaProcedure?.Performed;
                object ej_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ei_);
                bool ek_ = ej_ is CqlDateTime;
                if (ek_)
                {
                    dj_ = ej_ as CqlDateTime;
                }
                else
                {
                    bool el_ = ej_ is CqlQuantity;
                    if (el_)
                    {
                        dj_ = ej_ as CqlQuantity;
                    }
                    else
                    {
                        bool em_ = ej_ is CqlInterval<CqlDateTime>;
                        if (em_)
                        {
                            dj_ = ej_ as CqlInterval<CqlDateTime>;
                        }
                        else
                        {
                            bool en_ = ej_ is CqlInterval<CqlQuantity>;
                            if (en_)
                            {
                                dj_ = ej_ as CqlInterval<CqlQuantity>;
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
                bool? dn_ = dm_?.highClosed;
                CqlInterval<CqlDateTime> do_ = context.Operators.Interval(cx_, dd_, di_, dn_);
                bool? dp_ = context.Operators.In<CqlDateTime>(cr_, do_, "day");
                return bw_ & dp_;
            }
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
                bool? p_ = !((bool?)(o_ is null));
                // CQL 'implies' (193:19-196:110): right operand skipped when left is false
                if (p_ is false)
                {
                    return true;
                }
                else
                {
                    CqlCode q_ = QICoreCommon_4_0_000.Instance.refuted(context);
                    CqlConcept r_ = context.Operators.ConvertCodeToConcept(q_);
                    bool? s_ = context.Operators.Equivalent(o_, r_);
                    bool? t_ = !s_;
                    bool? u_;
                    // CQL 'and' (193:77-195:9): right operand skipped when left is false
                    if (t_ is false)
                    {
                        u_ = false;
                    }
                    else
                    {
                        CqlCode w_ = QICoreCommon_4_0_000.Instance.entered_in_error(context);
                        CqlConcept x_ = context.Operators.ConvertCodeToConcept(w_);
                        bool? y_ = context.Operators.Equivalent(o_, x_);
                        u_ = t_ & !y_;
                    }
                    bool? v_;
                    // CQL 'and' (193:77-196:110): right operand skipped when left is false
                    if (u_ is false)
                    {
                        v_ = false;
                    }
                    else
                    {
                        DataType z_ = AtrialFibrillation?.Onset;
                        object aa_ = FHIRHelpers_4_4_000.Instance.ToValue(context, z_);
                        CqlInterval<CqlDateTime> ab_ = QICoreCommon_4_0_000.Instance.toInterval(context, aa_);
                        CqlDateTime ac_ = context.Operators.Start(ab_);
                        Period ad_ = QualifyingEncounterICU?.Period;
                        CqlInterval<CqlDateTime> ae_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ad_);
                        CqlDateTime af_ = context.Operators.End(ae_);
                        bool? ag_ = context.Operators.SameOrBefore(ac_, af_, (string)default);
                        v_ = u_ & ag_;
                    }
                    return !p_ | v_;
                }
            }

            bool? m_ = context.Operators.WhereAny<Condition>(k_, l_);
            return m_;
        }

        IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);

        bool? d_(Encounter QualifyingEncounterICU) {
            CqlValueSet ah_ = this.Atrial_Fibrillation_or_Flutter(context);
            bool? ai_ = VTE_8_18_000.Instance.hasEncDiagnosisOf(context, QualifyingEncounterICU, ah_);
            return ai_;
        }

        IEnumerable<Encounter> e_ = context.Operators.Where<Encounter>(a_, d_);
        IEnumerable<Encounter> f_ = context.Operators.Union<Encounter>(c_, e_);

        bool? g_(Encounter QualifyingEncounterICU) {
            CqlValueSet aj_ = this.Venous_Thromboembolism(context);
            IEnumerable<Condition> ak_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, aj_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-problems-health-concerns"));

            bool? al_(Condition VTEDiagnosis) {
                CodeableConcept an_ = VTEDiagnosis?.ClinicalStatus;
                CqlConcept ao_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, an_);
                CqlCode ap_ = QICoreCommon_4_0_000.Instance.inactive(context);
                CqlConcept aq_ = context.Operators.ConvertCodeToConcept(ap_);
                bool? ar_ = context.Operators.Equivalent(ao_, aq_);
                bool? as_;
                // CQL 'or' (203:23-204:71): right operand skipped when left is true
                if (ar_ is true)
                {
                    as_ = true;
                }
                else
                {
                    CqlCode av_ = QICoreCommon_4_0_000.Instance.remission(context);
                    CqlConcept aw_ = context.Operators.ConvertCodeToConcept(av_);
                    bool? ax_ = context.Operators.Equivalent(ao_, aw_);
                    as_ = ar_ | ax_;
                }
                bool? at_;
                // CQL 'or' (203:21-206:11): right operand skipped when left is true
                if (as_ is true)
                {
                    at_ = true;
                }
                else
                {
                    CqlCode ay_ = QICoreCommon_4_0_000.Instance.resolved(context);
                    CqlConcept az_ = context.Operators.ConvertCodeToConcept(ay_);
                    bool? ba_ = context.Operators.Equivalent(ao_, az_);
                    at_ = as_ | ba_;
                }
                bool? au_;
                // CQL 'and' (203:21-207:59): right operand skipped when left is false
                if (at_ is false)
                {
                    au_ = false;
                }
                else
                {
                    CodeableConcept bb_ = VTEDiagnosis?.VerificationStatus;
                    CqlConcept bc_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, bb_);
                    au_ = at_ & (!((bool?)(bc_ is null)));
                }
                // CQL 'implies' (203:21-210:95): right operand skipped when left is false
                if (au_ is false)
                {
                    return true;
                }
                else
                {
                    CodeableConcept bd_ = VTEDiagnosis?.VerificationStatus;
                    CqlConcept be_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, bd_);
                    CqlCode bf_ = QICoreCommon_4_0_000.Instance.refuted(context);
                    CqlConcept bg_ = context.Operators.ConvertCodeToConcept(bf_);
                    bool? bh_ = context.Operators.Equivalent(be_, bg_);
                    bool? bi_ = !bh_;
                    bool? bj_;
                    // CQL 'and' (207:69-209:11): right operand skipped when left is false
                    if (bi_ is false)
                    {
                        bj_ = false;
                    }
                    else
                    {
                        CqlCode bl_ = QICoreCommon_4_0_000.Instance.entered_in_error(context);
                        CqlConcept bm_ = context.Operators.ConvertCodeToConcept(bl_);
                        bool? bn_ = context.Operators.Equivalent(be_, bm_);
                        bj_ = bi_ & !bn_;
                    }
                    bool? bk_;
                    // CQL 'and' (207:69-210:95): right operand skipped when left is false
                    if (bj_ is false)
                    {
                        bk_ = false;
                    }
                    else
                    {
                        DataType bo_ = VTEDiagnosis?.Onset;
                        object bp_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bo_);
                        CqlInterval<CqlDateTime> bq_ = QICoreCommon_4_0_000.Instance.toInterval(context, bp_);
                        CqlInterval<CqlDateTime> br_;
                        Period bt_ = QualifyingEncounterICU?.Period;
                        CqlInterval<CqlDateTime> bu_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, bt_);
                        CqlDateTime bv_ = context.Operators.Start(bu_);
                        if (bv_ is null)
                        {
                            br_ = default;
                        }
                        else
                        {
                            CqlInterval<CqlDateTime> bw_ = context.Operators.Interval(bv_, bv_, true, true);
                            br_ = bw_;
                        }
                        bool? bs_ = context.Operators.Before(bq_, br_, (string)default);
                        bk_ = bj_ & bs_;
                    }
                    return !au_ | bk_;
                }
            }

            bool? am_ = context.Operators.WhereAny<Condition>(ak_, al_);
            return am_;
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
                // CQL 'and' (217:17-218:110): right operand skipped when left is false
                if (n_ is false)
                {
                    return false;
                }
                else
                {
                    object o_;
                    DataType v_ = HipKneeProcedure?.Performed;
                    object w_ = FHIRHelpers_4_4_000.Instance.ToValue(context, v_);
                    bool x_ = w_ is CqlDateTime;
                    if (x_)
                    {
                        o_ = w_ as CqlDateTime;
                    }
                    else
                    {
                        bool y_ = w_ is CqlQuantity;
                        if (y_)
                        {
                            o_ = w_ as CqlQuantity;
                        }
                        else
                        {
                            bool z_ = w_ is CqlInterval<CqlDateTime>;
                            if (z_)
                            {
                                o_ = w_ as CqlInterval<CqlDateTime>;
                            }
                            else
                            {
                                bool aa_ = w_ is CqlInterval<CqlQuantity>;
                                if (aa_)
                                {
                                    o_ = w_ as CqlInterval<CqlQuantity>;
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
                    return n_ & u_;
                }
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
            // CQL 'and' (226:7-227:75): right operand skipped when left is false
            if (aq_ is false)
            {
                return false;
            }
            else
            {
                Code<ObservationStatus> ar_ = VTERiskAssessment?.StatusElement;
                ObservationStatus? as_ = ar_?.Value;
                string at_ = context.Operators.Convert<string>(as_);
                string[] au_ = [
                    "final",
                    "amended",
                    "corrected",
                ];
                bool? av_ = context.Operators.In<string>(at_, (IEnumerable<string>)au_);
                return aq_ & av_;
            }
        }


        (CqlTupleMetadata, string id, CqlDateTime LowRiskDatetime)? e_(Observation VTERiskAssessment) {
            Id aw_ = VTERiskAssessment?.IdElement;
            string ax_ = aw_?.Value;
            object ay_;
            DataType bb_ = VTERiskAssessment?.Effective;
            object bc_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bb_);
            bool bd_ = bc_ is CqlDateTime;
            if (bd_)
            {
                ay_ = bc_ as CqlDateTime;
            }
            else
            {
                if (bd_)
                {
                    ay_ = bc_ as CqlDateTime;
                }
                else
                {
                    bool be_ = bc_ is CqlInterval<CqlDateTime>;
                    if (be_)
                    {
                        ay_ = bc_ as CqlInterval<CqlDateTime>;
                    }
                    else
                    {
                        ay_ = null;
                    }
                }
            }
            CqlDateTime az_ = QICoreCommon_4_0_000.Instance.earliest(context, ay_);
            (CqlTupleMetadata, string id, CqlDateTime LowRiskDatetime)? ba_ = (CqlTupleMetadata_DMAfXNhTfZDWOGdfEceXbfaSJ, ax_, az_);
            return ba_;
        }

        IEnumerable<(CqlTupleMetadata, string id, CqlDateTime LowRiskDatetime)?> f_ = context.Operators.WhereSelect<Observation, (CqlTupleMetadata, string id, CqlDateTime LowRiskDatetime)?>(c_, d_, e_);
        IEnumerable<(CqlTupleMetadata, string id, CqlDateTime LowRiskDatetime)?> g_ = context.Operators.Distinct<(CqlTupleMetadata, string id, CqlDateTime LowRiskDatetime)?>(f_);
        CqlValueSet h_ = this.INR(context);
        IEnumerable<Observation> i_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, h_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation-lab"));

        bool? j_(Observation INRLabTest) {
            DataType bf_ = INRLabTest?.Value;
            object bg_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bf_);
            CqlQuantity bh_ = context.Operators.ConvertDecimalToQuantity(3.0m);
            bool? bi_ = context.Operators.Greater(bg_ as CqlQuantity, bh_);
            // CQL 'and' (234:9-235:70): right operand skipped when left is false
            if (bi_ is false)
            {
                return false;
            }
            else
            {
                Code<ObservationStatus> bj_ = INRLabTest?.StatusElement;
                ObservationStatus? bk_ = bj_?.Value;
                string bl_ = context.Operators.Convert<string>(bk_);
                string[] bm_ = [
                    "final",
                    "amended",
                    "corrected",
                ];
                bool? bn_ = context.Operators.In<string>(bl_, (IEnumerable<string>)bm_);
                return bi_ & bn_;
            }
        }


        (CqlTupleMetadata, string id, CqlDateTime LowRiskDatetime)? k_(Observation INRLabTest) {
            Id bo_ = INRLabTest?.IdElement;
            string bp_ = bo_?.Value;
            Instant bq_ = INRLabTest?.IssuedElement;
            DateTimeOffset? br_ = bq_?.Value;
            CqlDateTime bs_ = context.Operators.Convert<CqlDateTime>(br_);
            (CqlTupleMetadata, string id, CqlDateTime LowRiskDatetime)? bt_ = (CqlTupleMetadata_DMAfXNhTfZDWOGdfEceXbfaSJ, bp_, bs_);
            return bt_;
        }

        IEnumerable<(CqlTupleMetadata, string id, CqlDateTime LowRiskDatetime)?> l_ = context.Operators.WhereSelect<Observation, (CqlTupleMetadata, string id, CqlDateTime LowRiskDatetime)?>(i_, j_, k_);
        IEnumerable<(CqlTupleMetadata, string id, CqlDateTime LowRiskDatetime)?> m_ = context.Operators.Distinct<(CqlTupleMetadata, string id, CqlDateTime LowRiskDatetime)?>(l_);
        IEnumerable<(CqlTupleMetadata, string id, CqlDateTime LowRiskDatetime)?> n_ = context.Operators.Union<(CqlTupleMetadata, string id, CqlDateTime LowRiskDatetime)?>(g_, m_);
        IEnumerable<MedicationAdministration> o_ = context.Operators.Retrieve<MedicationAdministration>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationadministration"));

        bool? p_(MedicationAdministration MR) {
            IEnumerable<Medication> bu_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));

            bool? bv_(Medication M) {
                object bx_ = context.Operators.LateBoundProperty<object>(M, "id.value");
                object by_ = context.Operators.LateBoundProperty<object>(MR, "medication.reference.value");
                IEnumerable<string> bz_ = context.Operators.Split((string)by_, "/");
                string ca_ = context.Operators.Last<string>(bz_);
                bool? cb_ = context.Operators.Equal(bx_, ca_);
                // CQL 'and': right operand skipped when left is false
                if (cb_ is false)
                {
                    return false;
                }
                else
                {
                    CodeableConcept cc_ = M?.Code;
                    CqlConcept cd_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, cc_);
                    CqlValueSet ce_ = this.Unfractionated_Heparin(context);
                    bool? cf_ = context.Operators.ConceptInValueSet(cd_, ce_);
                    return cb_ & cf_;
                }
            }

            bool? bw_ = context.Operators.WhereAny<Medication>(bu_, bv_);
            return bw_;
        }

        IEnumerable<MedicationAdministration> q_ = context.Operators.Where<MedicationAdministration>(o_, p_);
        CqlValueSet r_ = this.Unfractionated_Heparin(context);
        IEnumerable<MedicationAdministration> s_ = context.Operators.Retrieve<MedicationAdministration>(new RetrieveParameters(default, r_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationadministration"));
        IEnumerable<MedicationAdministration> t_ = context.Operators.Union<MedicationAdministration>(q_, s_);

        bool? u_(MedicationAdministration UnfractionatedHeparin) {
            MedicationAdministration.DosageComponent cg_ = UnfractionatedHeparin?.Dosage;
            CodeableConcept ch_ = cg_?.Route;
            CqlConcept ci_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, ch_);
            CqlValueSet cj_ = this.Intravenous_route(context);
            bool? ck_ = context.Operators.ConceptInValueSet(ci_, cj_);
            return ck_;
        }

        IEnumerable<MedicationAdministration> v_ = context.Operators.Where<MedicationAdministration>(t_, u_);

        bool? w_(MedicationAdministration MR) {
            IEnumerable<Medication> cl_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));

            bool? cm_(Medication M) {
                object co_ = context.Operators.LateBoundProperty<object>(M, "id.value");
                object cp_ = context.Operators.LateBoundProperty<object>(MR, "medication.reference.value");
                IEnumerable<string> cq_ = context.Operators.Split((string)cp_, "/");
                string cr_ = context.Operators.Last<string>(cq_);
                bool? cs_ = context.Operators.Equal(co_, cr_);
                // CQL 'and': right operand skipped when left is false
                if (cs_ is false)
                {
                    return false;
                }
                else
                {
                    CodeableConcept ct_ = M?.Code;
                    CqlConcept cu_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, ct_);
                    CqlValueSet cv_ = this.Direct_Thrombin_Inhibitor(context);
                    bool? cw_ = context.Operators.ConceptInValueSet(cu_, cv_);
                    return cs_ & cw_;
                }
            }

            bool? cn_ = context.Operators.WhereAny<Medication>(cl_, cm_);
            return cn_;
        }

        IEnumerable<MedicationAdministration> x_ = context.Operators.Where<MedicationAdministration>(o_, w_);
        CqlValueSet y_ = this.Direct_Thrombin_Inhibitor(context);
        IEnumerable<MedicationAdministration> z_ = context.Operators.Retrieve<MedicationAdministration>(new RetrieveParameters(default, y_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationadministration"));
        IEnumerable<MedicationAdministration> aa_ = context.Operators.Union<MedicationAdministration>(x_, z_);
        IEnumerable<MedicationAdministration> ab_ = context.Operators.Union<MedicationAdministration>(v_, aa_);

        bool? ac_(MedicationAdministration MR) {
            IEnumerable<Medication> cx_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));

            bool? cy_(Medication M) {
                object da_ = context.Operators.LateBoundProperty<object>(M, "id.value");
                object db_ = context.Operators.LateBoundProperty<object>(MR, "medication.reference.value");
                IEnumerable<string> dc_ = context.Operators.Split((string)db_, "/");
                string dd_ = context.Operators.Last<string>(dc_);
                bool? de_ = context.Operators.Equal(da_, dd_);
                // CQL 'and': right operand skipped when left is false
                if (de_ is false)
                {
                    return false;
                }
                else
                {
                    CodeableConcept df_ = M?.Code;
                    CqlConcept dg_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, df_);
                    CqlValueSet dh_ = this.Glycoprotein_IIb_IIIa_Inhibitors(context);
                    bool? di_ = context.Operators.ConceptInValueSet(dg_, dh_);
                    return de_ & di_;
                }
            }

            bool? cz_ = context.Operators.WhereAny<Medication>(cx_, cy_);
            return cz_;
        }

        IEnumerable<MedicationAdministration> ad_ = context.Operators.Where<MedicationAdministration>(o_, ac_);
        CqlValueSet ae_ = this.Glycoprotein_IIb_IIIa_Inhibitors(context);
        IEnumerable<MedicationAdministration> af_ = context.Operators.Retrieve<MedicationAdministration>(new RetrieveParameters(default, ae_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationadministration"));
        IEnumerable<MedicationAdministration> ag_ = context.Operators.Union<MedicationAdministration>(ad_, af_);
        IEnumerable<MedicationAdministration> ah_ = context.Operators.Union<MedicationAdministration>(ab_, ag_);

        bool? ai_(MedicationAdministration AnticoagulantMedication) {
            Code<MedicationAdministration.MedicationAdministrationStatusCodes> dj_ = AnticoagulantMedication?.StatusElement;
            MedicationAdministration.MedicationAdministrationStatusCodes? dk_ = dj_?.Value;
            string dl_ = context.Operators.Convert<string>(dk_);
            bool? dm_ = context.Operators.Equal(dl_, "completed");
            return dm_;
        }


        (CqlTupleMetadata, string id, CqlDateTime LowRiskDatetime)? aj_(MedicationAdministration AnticoagulantMedication) {
            Id dn_ = AnticoagulantMedication?.IdElement;
            string do_ = dn_?.Value;
            DataType dp_ = AnticoagulantMedication?.Effective;
            object dq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dp_);
            CqlInterval<CqlDateTime> dr_ = QICoreCommon_4_0_000.Instance.toInterval(context, dq_);
            CqlDateTime ds_ = context.Operators.Start(dr_);
            (CqlTupleMetadata, string id, CqlDateTime LowRiskDatetime)? dt_ = (CqlTupleMetadata_DMAfXNhTfZDWOGdfEceXbfaSJ, do_, ds_);
            return dt_;
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
            bool? p_;
            // CQL 'and' (263:11-264:121): right operand skipped when left is false
            if (o_ is false)
            {
                p_ = false;
            }
            else
            {
                object q_;
                DataType x_ = tuple_cchfidtccovheihiyjcdnfkbm?.AnesthesiaProcedure?.Performed;
                object y_ = FHIRHelpers_4_4_000.Instance.ToValue(context, x_);
                bool z_ = y_ is CqlDateTime;
                if (z_)
                {
                    q_ = y_ as CqlDateTime;
                }
                else
                {
                    bool aa_ = y_ is CqlQuantity;
                    if (aa_)
                    {
                        q_ = y_ as CqlQuantity;
                    }
                    else
                    {
                        bool ab_ = y_ is CqlInterval<CqlDateTime>;
                        if (ab_)
                        {
                            q_ = y_ as CqlInterval<CqlDateTime>;
                        }
                        else
                        {
                            bool ac_ = y_ is CqlInterval<CqlQuantity>;
                            if (ac_)
                            {
                                q_ = y_ as CqlInterval<CqlQuantity>;
                            }
                            else
                            {
                                q_ = null;
                            }
                        }
                    }
                }
                CqlInterval<CqlDateTime> r_ = QICoreCommon_4_0_000.Instance.toInterval(context, q_);
                CqlDateTime s_ = context.Operators.End(r_);
                CqlDateTime t_ = this.startOfFirstICU(context, tuple_cchfidtccovheihiyjcdnfkbm?.QualifyingEncounterICU);
                CqlQuantity u_ = context.Operators.Quantity(1m, "day");
                CqlDateTime v_ = context.Operators.Add(t_, u_);
                bool? w_ = context.Operators.SameAs(s_, v_, "day");
                p_ = o_ & w_;
            }
            // CQL 'and' (263:5-265:137): right operand skipped when left is false
            if (p_ is false)
            {
                return false;
            }
            else
            {
                CqlDateTime ad_ = tuple_cchfidtccovheihiyjcdnfkbm?.LowRiskForVTE?.LowRiskDatetime;
                object ae_;
                DataType bc_ = tuple_cchfidtccovheihiyjcdnfkbm?.AnesthesiaProcedure?.Performed;
                object bd_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bc_);
                bool be_ = bd_ is CqlDateTime;
                if (be_)
                {
                    ae_ = bd_ as CqlDateTime;
                }
                else
                {
                    bool bf_ = bd_ is CqlQuantity;
                    if (bf_)
                    {
                        ae_ = bd_ as CqlQuantity;
                    }
                    else
                    {
                        bool bg_ = bd_ is CqlInterval<CqlDateTime>;
                        if (bg_)
                        {
                            ae_ = bd_ as CqlInterval<CqlDateTime>;
                        }
                        else
                        {
                            bool bh_ = bd_ is CqlInterval<CqlQuantity>;
                            if (bh_)
                            {
                                ae_ = bd_ as CqlInterval<CqlQuantity>;
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
                DataType bi_ = tuple_cchfidtccovheihiyjcdnfkbm?.AnesthesiaProcedure?.Performed;
                object bj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bi_);
                bool bk_ = bj_ is CqlDateTime;
                if (bk_)
                {
                    ak_ = bj_ as CqlDateTime;
                }
                else
                {
                    bool bl_ = bj_ is CqlQuantity;
                    if (bl_)
                    {
                        ak_ = bj_ as CqlQuantity;
                    }
                    else
                    {
                        bool bm_ = bj_ is CqlInterval<CqlDateTime>;
                        if (bm_)
                        {
                            ak_ = bj_ as CqlInterval<CqlDateTime>;
                        }
                        else
                        {
                            bool bn_ = bj_ is CqlInterval<CqlQuantity>;
                            if (bn_)
                            {
                                ak_ = bj_ as CqlInterval<CqlQuantity>;
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
                DataType bo_ = tuple_cchfidtccovheihiyjcdnfkbm?.AnesthesiaProcedure?.Performed;
                object bp_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bo_);
                bool bq_ = bp_ is CqlDateTime;
                if (bq_)
                {
                    aq_ = bp_ as CqlDateTime;
                }
                else
                {
                    bool br_ = bp_ is CqlQuantity;
                    if (br_)
                    {
                        aq_ = bp_ as CqlQuantity;
                    }
                    else
                    {
                        bool bs_ = bp_ is CqlInterval<CqlDateTime>;
                        if (bs_)
                        {
                            aq_ = bp_ as CqlInterval<CqlDateTime>;
                        }
                        else
                        {
                            bool bt_ = bp_ is CqlInterval<CqlQuantity>;
                            if (bt_)
                            {
                                aq_ = bp_ as CqlInterval<CqlQuantity>;
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
                DataType bu_ = tuple_cchfidtccovheihiyjcdnfkbm?.AnesthesiaProcedure?.Performed;
                object bv_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bu_);
                bool bw_ = bv_ is CqlDateTime;
                if (bw_)
                {
                    av_ = bv_ as CqlDateTime;
                }
                else
                {
                    bool bx_ = bv_ is CqlQuantity;
                    if (bx_)
                    {
                        av_ = bv_ as CqlQuantity;
                    }
                    else
                    {
                        bool by_ = bv_ is CqlInterval<CqlDateTime>;
                        if (by_)
                        {
                            av_ = bv_ as CqlInterval<CqlDateTime>;
                        }
                        else
                        {
                            bool bz_ = bv_ is CqlInterval<CqlQuantity>;
                            if (bz_)
                            {
                                av_ = bv_ as CqlInterval<CqlQuantity>;
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
                return p_ & bb_;
            }
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
            // CQL 'and' (299:9-300:67): right operand skipped when left is false
            if (ct_ is false)
            {
                return false;
            }
            else
            {
                Code<MedicationRequest.MedicationrequestStatus> cu_ = NoMedicationOrder?.StatusElement;
                MedicationRequest.MedicationrequestStatus? cv_ = cu_?.Value;
                string cw_ = context.Operators.Convert<string>(cv_);
                string[] cx_ = [
                    "active",
                    "completed",
                ];
                bool? cy_ = context.Operators.In<string>(cw_, (IEnumerable<string>)cx_);
                return ct_ & cy_;
            }
        }


        (CqlTupleMetadata, string id, IEnumerable<CqlConcept> medicationStatusReason, CqlDateTime authoredOn)? am_(MedicationRequest NoMedicationOrder) {
            Id cz_ = NoMedicationOrder?.IdElement;
            string da_ = cz_?.Value;
            List<CodeableConcept> db_ = NoMedicationOrder?.ReasonCode;

            CqlConcept dc_(CodeableConcept @this) {
                CqlConcept dh_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);
                return dh_;
            }

            IEnumerable<CqlConcept> dd_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)db_, dc_);
            FhirDateTime de_ = NoMedicationOrder?.AuthoredOnElement;
            CqlDateTime df_ = context.Operators.Convert<CqlDateTime>(de_);
            (CqlTupleMetadata, string id, IEnumerable<CqlConcept> medicationStatusReason, CqlDateTime authoredOn)? dg_ = (CqlTupleMetadata_CNeQfiIHcQEUBjZNVZiOLfdeP, da_, dd_, df_);
            return dg_;
        }

        IEnumerable<(CqlTupleMetadata, string id, IEnumerable<CqlConcept> medicationStatusReason, CqlDateTime authoredOn)?> an_ = context.Operators.WhereSelect<MedicationRequest, (CqlTupleMetadata, string id, IEnumerable<CqlConcept> medicationStatusReason, CqlDateTime authoredOn)?>(ak_, al_, am_);
        IEnumerable<(CqlTupleMetadata, string id, IEnumerable<CqlConcept> medicationStatusReason, CqlDateTime authoredOn)?> ao_ = context.Operators.Distinct<(CqlTupleMetadata, string id, IEnumerable<CqlConcept> medicationStatusReason, CqlDateTime authoredOn)?>(an_);
        IEnumerable<(CqlTupleMetadata, string id, IEnumerable<CqlConcept> medicationStatusReason, CqlDateTime authoredOn)?> ap_ = context.Operators.Union<(CqlTupleMetadata, string id, IEnumerable<CqlConcept> medicationStatusReason, CqlDateTime authoredOn)?>(w_, ao_);
        IEnumerable<MedicationRequest> aq_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));

        bool? ar_(MedicationRequest MR) {
            IEnumerable<Medication> di_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));

            bool? dj_(Medication M) {
                object dl_ = context.Operators.LateBoundProperty<object>(M, "id.value");
                object dm_ = context.Operators.LateBoundProperty<object>(MR, "medication.reference.value");
                IEnumerable<string> dn_ = context.Operators.Split((string)dm_, "/");
                string do_ = context.Operators.Last<string>(dn_);
                bool? dp_ = context.Operators.Equal(dl_, do_);
                // CQL 'and': right operand skipped when left is false
                if (dp_ is false)
                {
                    return false;
                }
                else
                {
                    CodeableConcept dq_ = M?.Code;
                    CqlConcept dr_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, dq_);
                    CqlValueSet ds_ = this.Low_Dose_Unfractionated_Heparin_for_VTE_Prophylaxis(context);
                    bool? dt_ = context.Operators.ConceptInValueSet(dr_, ds_);
                    return dp_ & dt_;
                }
            }

            bool? dk_ = context.Operators.WhereAny<Medication>(di_, dj_);
            return dk_;
        }

        IEnumerable<MedicationRequest> as_ = context.Operators.Where<MedicationRequest>(aq_, ar_);
        IEnumerable<MedicationRequest> at_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> au_ = context.Operators.Union<MedicationRequest>(as_, at_);

        bool? av_(MedicationRequest MR) {
            IEnumerable<Medication> du_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));

            bool? dv_(Medication M) {
                object dx_ = context.Operators.LateBoundProperty<object>(M, "id.value");
                object dy_ = context.Operators.LateBoundProperty<object>(MR, "medication.reference.value");
                IEnumerable<string> dz_ = context.Operators.Split((string)dy_, "/");
                string ea_ = context.Operators.Last<string>(dz_);
                bool? eb_ = context.Operators.Equal(dx_, ea_);
                // CQL 'and': right operand skipped when left is false
                if (eb_ is false)
                {
                    return false;
                }
                else
                {
                    CodeableConcept ec_ = M?.Code;
                    CqlConcept ed_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, ec_);
                    CqlValueSet ee_ = this.Low_Molecular_Weight_Heparin_for_VTE_Prophylaxis(context);
                    bool? ef_ = context.Operators.ConceptInValueSet(ed_, ee_);
                    return eb_ & ef_;
                }
            }

            bool? dw_ = context.Operators.WhereAny<Medication>(du_, dv_);
            return dw_;
        }

        IEnumerable<MedicationRequest> aw_ = context.Operators.Where<MedicationRequest>(aq_, av_);
        IEnumerable<MedicationRequest> ax_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, d_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> ay_ = context.Operators.Union<MedicationRequest>(aw_, ax_);
        IEnumerable<MedicationRequest> az_ = context.Operators.Union<MedicationRequest>(au_, ay_);

        bool? ba_(MedicationRequest MR) {
            IEnumerable<Medication> eg_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));

            bool? eh_(Medication M) {
                object ej_ = context.Operators.LateBoundProperty<object>(M, "id.value");
                object ek_ = context.Operators.LateBoundProperty<object>(MR, "medication.reference.value");
                IEnumerable<string> el_ = context.Operators.Split((string)ek_, "/");
                string em_ = context.Operators.Last<string>(el_);
                bool? en_ = context.Operators.Equal(ej_, em_);
                // CQL 'and': right operand skipped when left is false
                if (en_ is false)
                {
                    return false;
                }
                else
                {
                    CodeableConcept eo_ = M?.Code;
                    CqlConcept ep_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, eo_);
                    CqlValueSet eq_ = this.Injectable_Factor_Xa_Inhibitor_for_VTE_Prophylaxis(context);
                    bool? er_ = context.Operators.ConceptInValueSet(ep_, eq_);
                    return en_ & er_;
                }
            }

            bool? ei_ = context.Operators.WhereAny<Medication>(eg_, eh_);
            return ei_;
        }

        IEnumerable<MedicationRequest> bb_ = context.Operators.Where<MedicationRequest>(aq_, ba_);
        IEnumerable<MedicationRequest> bc_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, h_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> bd_ = context.Operators.Union<MedicationRequest>(bb_, bc_);
        IEnumerable<MedicationRequest> be_ = context.Operators.Union<MedicationRequest>(az_, bd_);

        bool? bf_(MedicationRequest MR) {
            IEnumerable<Medication> es_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));

            bool? et_(Medication M) {
                object ev_ = context.Operators.LateBoundProperty<object>(M, "id.value");
                object ew_ = context.Operators.LateBoundProperty<object>(MR, "medication.reference.value");
                IEnumerable<string> ex_ = context.Operators.Split((string)ew_, "/");
                string ey_ = context.Operators.Last<string>(ex_);
                bool? ez_ = context.Operators.Equal(ev_, ey_);
                // CQL 'and': right operand skipped when left is false
                if (ez_ is false)
                {
                    return false;
                }
                else
                {
                    CodeableConcept fa_ = M?.Code;
                    CqlConcept fb_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, fa_);
                    CqlValueSet fc_ = this.Warfarin(context);
                    bool? fd_ = context.Operators.ConceptInValueSet(fb_, fc_);
                    return ez_ & fd_;
                }
            }

            bool? eu_ = context.Operators.WhereAny<Medication>(es_, et_);
            return eu_;
        }

        IEnumerable<MedicationRequest> bg_ = context.Operators.Where<MedicationRequest>(aq_, bf_);
        IEnumerable<MedicationRequest> bh_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, l_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> bi_ = context.Operators.Union<MedicationRequest>(bg_, bh_);
        IEnumerable<MedicationRequest> bj_ = context.Operators.Union<MedicationRequest>(be_, bi_);

        bool? bk_(MedicationRequest MR) {
            IEnumerable<Medication> fe_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));

            bool? ff_(Medication M) {
                object fh_ = context.Operators.LateBoundProperty<object>(M, "id.value");
                object fi_ = context.Operators.LateBoundProperty<object>(MR, "medication.reference.value");
                IEnumerable<string> fj_ = context.Operators.Split((string)fi_, "/");
                string fk_ = context.Operators.Last<string>(fj_);
                bool? fl_ = context.Operators.Equal(fh_, fk_);
                // CQL 'and': right operand skipped when left is false
                if (fl_ is false)
                {
                    return false;
                }
                else
                {
                    CodeableConcept fm_ = M?.Code;
                    CqlConcept fn_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, fm_);
                    CqlValueSet fo_ = this.Rivaroxaban_for_VTE_Prophylaxis(context);
                    bool? fp_ = context.Operators.ConceptInValueSet(fn_, fo_);
                    return fl_ & fp_;
                }
            }

            bool? fg_ = context.Operators.WhereAny<Medication>(fe_, ff_);
            return fg_;
        }

        IEnumerable<MedicationRequest> bl_ = context.Operators.Where<MedicationRequest>(aq_, bk_);
        IEnumerable<MedicationRequest> bm_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, p_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> bn_ = context.Operators.Union<MedicationRequest>(bl_, bm_);
        IEnumerable<MedicationRequest> bo_ = context.Operators.Union<MedicationRequest>(bj_, bn_);
        IEnumerable<Task> bp_ = context.Operators.Retrieve<Task>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-taskrejected"));
        IEnumerable<ValueTuple<MedicationRequest, Task>> bq_ = context.Operators.CrossJoin<MedicationRequest, Task>(bo_, bp_);

        (CqlTupleMetadata, MedicationRequest MedicationOrderReject, Task T)? br_(ValueTuple<MedicationRequest, Task> _valueTuple) {
            (CqlTupleMetadata, MedicationRequest MedicationOrderReject, Task T)? fq_ = (CqlTupleMetadata_IIUQMBcJhJBPgdDOLHaTTRUE, _valueTuple.Item1, _valueTuple.Item2);
            return fq_;
        }


        bool? bs_((CqlTupleMetadata, MedicationRequest MedicationOrderReject, Task T)? tuple_iiuqmbcjhjbpgddolhattrue) {
            ResourceReference fr_ = tuple_iiuqmbcjhjbpgddolhattrue?.T?.Focus;
            bool? fs_ = QICoreCommon_4_0_000.Instance.references(context, fr_, tuple_iiuqmbcjhjbpgddolhattrue?.MedicationOrderReject);
            bool? ft_;
            // CQL 'and' (314:15-315:45): right operand skipped when left is false
            if (fs_ is false)
            {
                ft_ = false;
            }
            else
            {
                CodeableConcept fu_ = tuple_iiuqmbcjhjbpgddolhattrue?.T?.Code;
                CqlConcept fv_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, fu_);
                CqlCode fw_ = QICoreCommon_4_0_000.Instance.Fulfill(context);
                CqlConcept fx_ = context.Operators.ConvertCodeToConcept(fw_);
                bool? fy_ = context.Operators.Equivalent(fv_, fx_);
                ft_ = fs_ & fy_;
            }
            // CQL 'and' (314:9-316:53): right operand skipped when left is false
            if (ft_ is false)
            {
                return false;
            }
            else
            {
                Code<MedicationRequest.MedicationrequestStatus> fz_ = tuple_iiuqmbcjhjbpgddolhattrue?.MedicationOrderReject?.StatusElement;
                MedicationRequest.MedicationrequestStatus? ga_ = fz_?.Value;
                string gb_ = context.Operators.Convert<string>(ga_);
                bool? gc_ = context.Operators.Equal(gb_, "active");
                return ft_ & gc_;
            }
        }

        IEnumerable<(CqlTupleMetadata, MedicationRequest MedicationOrderReject, Task T)?> bt_ = context.Operators.SelectWhere<ValueTuple<MedicationRequest, Task>, (CqlTupleMetadata, MedicationRequest MedicationOrderReject, Task T)?>(bq_, br_, bs_);

        (CqlTupleMetadata, string id, IEnumerable<CqlConcept> medicationStatusReason, CqlDateTime authoredOn)? bu_((CqlTupleMetadata, MedicationRequest MedicationOrderReject, Task T)? tuple_iiuqmbcjhjbpgddolhattrue) {
            Id gd_ = tuple_iiuqmbcjhjbpgddolhattrue?.MedicationOrderReject?.IdElement;
            string ge_ = gd_?.Value;
            CodeableConcept gf_ = tuple_iiuqmbcjhjbpgddolhattrue?.T?.StatusReason;
            CqlConcept gg_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, gf_);
            CqlConcept[] gh_ = [
                gg_,
            ];
            FhirDateTime gi_ = tuple_iiuqmbcjhjbpgddolhattrue?.MedicationOrderReject?.AuthoredOnElement;
            CqlDateTime gj_ = context.Operators.Convert<CqlDateTime>(gi_);
            (CqlTupleMetadata, string id, IEnumerable<CqlConcept> medicationStatusReason, CqlDateTime authoredOn)? gk_ = (CqlTupleMetadata_CNeQfiIHcQEUBjZNVZiOLfdeP, ge_, (IEnumerable<CqlConcept>)gh_, gj_);
            return gk_;
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
                // CQL 'and' (279:17-280:129): right operand skipped when left is false
                if (i_ is false)
                {
                    return false;
                }
                else
                {
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
                    return i_ & s_;
                }
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
            bool? by_;
            // CQL 'and' (346:15-347:49): right operand skipped when left is false
            if (bx_ is false)
            {
                by_ = false;
            }
            else
            {
                Code<RequestStatus> ca_ = tuple_yyidpxbnjhogfrjkyrbmgchb?.DeviceOrderReject?.StatusElement;
                RequestStatus? cb_ = ca_?.Value;
                Code<RequestStatus> cc_ = context.Operators.Convert<Code<RequestStatus>>(cb_);
                bool? cd_ = context.Operators.Equal(cc_, "active");
                by_ = bx_ & cd_;
            }
            bool? bz_;
            // CQL 'and' (346:15-348:54): right operand skipped when left is false
            if (by_ is false)
            {
                bz_ = false;
            }
            else
            {
                ResourceReference ce_ = tuple_yyidpxbnjhogfrjkyrbmgchb?.T?.Focus;
                bool? cf_ = QICoreCommon_4_0_000.Instance.references(context, ce_, tuple_yyidpxbnjhogfrjkyrbmgchb?.DeviceOrderReject);
                bz_ = by_ & cf_;
            }
            // CQL 'and' (346:9-349:45): right operand skipped when left is false
            if (bz_ is false)
            {
                return false;
            }
            else
            {
                CodeableConcept cg_ = tuple_yyidpxbnjhogfrjkyrbmgchb?.T?.Code;
                CqlConcept ch_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, cg_);
                CqlCode ci_ = QICoreCommon_4_0_000.Instance.Fulfill(context);
                CqlConcept cj_ = context.Operators.ConvertCodeToConcept(ci_);
                bool? ck_ = context.Operators.Equivalent(ch_, cj_);
                return bz_ & ck_;
            }
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

        (CqlTupleMetadata, string id, CqlConcept requestStatusReason, FhirDateTime authoredOn)? ap_(Procedure DeviceNotApplied) {
            Id cs_ = DeviceNotApplied?.IdElement;
            string ct_ = cs_?.Value;
            CodeableConcept cu_ = DeviceNotApplied?.StatusReason;
            CqlConcept cv_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, cu_);

            bool? cw_(Extension @this) {
                FhirUri dc_ = @this?.UrlElement;
                string dd_ = FHIRHelpers_4_4_000.Instance.ToString(context, dc_);
                bool? de_ = context.Operators.Equal(dd_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-recorded");
                return de_;
            }


            DataType cx_(Extension @this) {
                DataType df_ = @this?.Value;
                return df_;
            }

            IEnumerable<DataType> cy_ = context.Operators.WhereSelect<Extension, DataType>((IEnumerable<Extension>)(DeviceNotApplied is DomainResource
                ? (DeviceNotApplied as DomainResource).Extension
                : default), cw_, cx_);
            DataType cz_ = context.Operators.SingletonFrom<DataType>(cy_);
            FhirDateTime da_ = context.Operators.Convert<FhirDateTime>(cz_);
            (CqlTupleMetadata, string id, CqlConcept requestStatusReason, FhirDateTime authoredOn)? db_ = (CqlTupleMetadata_DPXDaXjPQUNAIiZCCbGhNdDMi, ct_, cv_, da_);
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
                CqlDateTime dg_ = context.Operators.Convert<CqlDateTime>(tuple_fcgxmnobtfvlcbqjjfugxtftk?.authoredOn);
                (CqlTupleMetadata, string id, CqlConcept requestStatusReason, CqlDateTime authoredOn)? dh_ = (CqlTupleMetadata_DheTAGNHbFgKVJGaRbPLJVjKH, tuple_fcgxmnobtfvlcbqjjfugxtftk?.id, tuple_fcgxmnobtfvlcbqjjfugxtftk?.requestStatusReason, dg_);
                return dh_;
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
                // CQL 'and' (327:17-328:125): right operand skipped when left is false
                if (i_ is false)
                {
                    return false;
                }
                else
                {
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
                    return i_ & s_;
                }
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
            bool? o_;
            // CQL 'and' (372:11-373:50): right operand skipped when left is false
            if (n_ is false)
            {
                o_ = false;
            }
            else
            {
                Code<EventStatus> q_ = tuple_fpgtpszgoyfdaobujrgcsedde?.AnesthesiaProcedure?.StatusElement;
                EventStatus? r_ = q_?.Value;
                string s_ = context.Operators.Convert<string>(r_);
                bool? t_ = context.Operators.Equal(s_, "completed");
                o_ = n_ & t_;
            }
            bool? p_;
            // CQL 'and' (372:11-374:121): right operand skipped when left is false
            if (o_ is false)
            {
                p_ = false;
            }
            else
            {
                object u_;
                DataType ab_ = tuple_fpgtpszgoyfdaobujrgcsedde?.AnesthesiaProcedure?.Performed;
                object ac_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ab_);
                bool ad_ = ac_ is CqlDateTime;
                if (ad_)
                {
                    u_ = ac_ as CqlDateTime;
                }
                else
                {
                    bool ae_ = ac_ is CqlQuantity;
                    if (ae_)
                    {
                        u_ = ac_ as CqlQuantity;
                    }
                    else
                    {
                        bool af_ = ac_ is CqlInterval<CqlDateTime>;
                        if (af_)
                        {
                            u_ = ac_ as CqlInterval<CqlDateTime>;
                        }
                        else
                        {
                            bool ag_ = ac_ is CqlInterval<CqlQuantity>;
                            if (ag_)
                            {
                                u_ = ac_ as CqlInterval<CqlQuantity>;
                            }
                            else
                            {
                                u_ = null;
                            }
                        }
                    }
                }
                CqlInterval<CqlDateTime> v_ = QICoreCommon_4_0_000.Instance.toInterval(context, u_);
                CqlDateTime w_ = context.Operators.End(v_);
                CqlDateTime x_ = this.startOfFirstICU(context, tuple_fpgtpszgoyfdaobujrgcsedde?.QualifyingEncounterICU);
                CqlQuantity y_ = context.Operators.Quantity(1m, "day");
                CqlDateTime z_ = context.Operators.Add(x_, y_);
                bool? aa_ = context.Operators.SameAs(w_, z_, "day");
                p_ = o_ & aa_;
            }
            // CQL 'and' (372:5-375:134): right operand skipped when left is false
            if (p_ is false)
            {
                return false;
            }
            else
            {
                CqlDateTime ah_ = tuple_fpgtpszgoyfdaobujrgcsedde?.NoVTEMedication?.authoredOn;
                object ai_;
                DataType bg_ = tuple_fpgtpszgoyfdaobujrgcsedde?.AnesthesiaProcedure?.Performed;
                object bh_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bg_);
                bool bi_ = bh_ is CqlDateTime;
                if (bi_)
                {
                    ai_ = bh_ as CqlDateTime;
                }
                else
                {
                    bool bj_ = bh_ is CqlQuantity;
                    if (bj_)
                    {
                        ai_ = bh_ as CqlQuantity;
                    }
                    else
                    {
                        bool bk_ = bh_ is CqlInterval<CqlDateTime>;
                        if (bk_)
                        {
                            ai_ = bh_ as CqlInterval<CqlDateTime>;
                        }
                        else
                        {
                            bool bl_ = bh_ is CqlInterval<CqlQuantity>;
                            if (bl_)
                            {
                                ai_ = bh_ as CqlInterval<CqlQuantity>;
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
                CqlDate am_ = al_?.low;
                CqlDateTime an_ = context.Operators.ConvertDateToDateTime(am_);
                object ao_;
                DataType bm_ = tuple_fpgtpszgoyfdaobujrgcsedde?.AnesthesiaProcedure?.Performed;
                object bn_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bm_);
                bool bo_ = bn_ is CqlDateTime;
                if (bo_)
                {
                    ao_ = bn_ as CqlDateTime;
                }
                else
                {
                    bool bp_ = bn_ is CqlQuantity;
                    if (bp_)
                    {
                        ao_ = bn_ as CqlQuantity;
                    }
                    else
                    {
                        bool bq_ = bn_ is CqlInterval<CqlDateTime>;
                        if (bq_)
                        {
                            ao_ = bn_ as CqlInterval<CqlDateTime>;
                        }
                        else
                        {
                            bool br_ = bn_ is CqlInterval<CqlQuantity>;
                            if (br_)
                            {
                                ao_ = bn_ as CqlInterval<CqlQuantity>;
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
                CqlDate as_ = ar_?.high;
                CqlDateTime at_ = context.Operators.ConvertDateToDateTime(as_);
                object au_;
                DataType bs_ = tuple_fpgtpszgoyfdaobujrgcsedde?.AnesthesiaProcedure?.Performed;
                object bt_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bs_);
                bool bu_ = bt_ is CqlDateTime;
                if (bu_)
                {
                    au_ = bt_ as CqlDateTime;
                }
                else
                {
                    bool bv_ = bt_ is CqlQuantity;
                    if (bv_)
                    {
                        au_ = bt_ as CqlQuantity;
                    }
                    else
                    {
                        bool bw_ = bt_ is CqlInterval<CqlDateTime>;
                        if (bw_)
                        {
                            au_ = bt_ as CqlInterval<CqlDateTime>;
                        }
                        else
                        {
                            bool bx_ = bt_ is CqlInterval<CqlQuantity>;
                            if (bx_)
                            {
                                au_ = bt_ as CqlInterval<CqlQuantity>;
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
                CqlInterval<CqlDate> ax_ = TJCOverall_8_25_000.Instance.calendarDayOfOrDayAfter(context, aw_);
                bool? ay_ = ax_?.lowClosed;
                object az_;
                DataType by_ = tuple_fpgtpszgoyfdaobujrgcsedde?.AnesthesiaProcedure?.Performed;
                object bz_ = FHIRHelpers_4_4_000.Instance.ToValue(context, by_);
                bool ca_ = bz_ is CqlDateTime;
                if (ca_)
                {
                    az_ = bz_ as CqlDateTime;
                }
                else
                {
                    bool cb_ = bz_ is CqlQuantity;
                    if (cb_)
                    {
                        az_ = bz_ as CqlQuantity;
                    }
                    else
                    {
                        bool cc_ = bz_ is CqlInterval<CqlDateTime>;
                        if (cc_)
                        {
                            az_ = bz_ as CqlInterval<CqlDateTime>;
                        }
                        else
                        {
                            bool cd_ = bz_ is CqlInterval<CqlQuantity>;
                            if (cd_)
                            {
                                az_ = bz_ as CqlInterval<CqlQuantity>;
                            }
                            else
                            {
                                az_ = null;
                            }
                        }
                    }
                }
                CqlInterval<CqlDateTime> ba_ = QICoreCommon_4_0_000.Instance.toInterval(context, az_);
                CqlDateTime bb_ = context.Operators.End(ba_);
                CqlInterval<CqlDate> bc_ = TJCOverall_8_25_000.Instance.calendarDayOfOrDayAfter(context, bb_);
                bool? bd_ = bc_?.highClosed;
                CqlInterval<CqlDateTime> be_ = context.Operators.Interval(an_, at_, ay_, bd_);
                bool? bf_ = context.Operators.In<CqlDateTime>(ah_, be_, "day");
                return p_ & bf_;
            }
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
            bool? o_;
            // CQL 'and' (383:11-384:50): right operand skipped when left is false
            if (n_ is false)
            {
                o_ = false;
            }
            else
            {
                Code<EventStatus> q_ = tuple_fnrkedfurymcjidjkbtaenork?.AnesthesiaProcedure?.StatusElement;
                EventStatus? r_ = q_?.Value;
                string s_ = context.Operators.Convert<string>(r_);
                bool? t_ = context.Operators.Equal(s_, "completed");
                o_ = n_ & t_;
            }
            bool? p_;
            // CQL 'and' (383:11-385:121): right operand skipped when left is false
            if (o_ is false)
            {
                p_ = false;
            }
            else
            {
                object u_;
                DataType ab_ = tuple_fnrkedfurymcjidjkbtaenork?.AnesthesiaProcedure?.Performed;
                object ac_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ab_);
                bool ad_ = ac_ is CqlDateTime;
                if (ad_)
                {
                    u_ = ac_ as CqlDateTime;
                }
                else
                {
                    bool ae_ = ac_ is CqlQuantity;
                    if (ae_)
                    {
                        u_ = ac_ as CqlQuantity;
                    }
                    else
                    {
                        bool af_ = ac_ is CqlInterval<CqlDateTime>;
                        if (af_)
                        {
                            u_ = ac_ as CqlInterval<CqlDateTime>;
                        }
                        else
                        {
                            bool ag_ = ac_ is CqlInterval<CqlQuantity>;
                            if (ag_)
                            {
                                u_ = ac_ as CqlInterval<CqlQuantity>;
                            }
                            else
                            {
                                u_ = null;
                            }
                        }
                    }
                }
                CqlInterval<CqlDateTime> v_ = QICoreCommon_4_0_000.Instance.toInterval(context, u_);
                CqlDateTime w_ = context.Operators.End(v_);
                CqlDateTime x_ = this.startOfFirstICU(context, tuple_fnrkedfurymcjidjkbtaenork?.QualifyingEncounterICU);
                CqlQuantity y_ = context.Operators.Quantity(1m, "day");
                CqlDateTime z_ = context.Operators.Add(x_, y_);
                bool? aa_ = context.Operators.SameAs(w_, z_, "day");
                p_ = o_ & aa_;
            }
            // CQL 'and' (383:5-386:130): right operand skipped when left is false
            if (p_ is false)
            {
                return false;
            }
            else
            {
                CqlDateTime ah_ = tuple_fnrkedfurymcjidjkbtaenork?.NoVTEDevice?.authoredOn;
                object ai_;
                DataType bg_ = tuple_fnrkedfurymcjidjkbtaenork?.AnesthesiaProcedure?.Performed;
                object bh_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bg_);
                bool bi_ = bh_ is CqlDateTime;
                if (bi_)
                {
                    ai_ = bh_ as CqlDateTime;
                }
                else
                {
                    bool bj_ = bh_ is CqlQuantity;
                    if (bj_)
                    {
                        ai_ = bh_ as CqlQuantity;
                    }
                    else
                    {
                        bool bk_ = bh_ is CqlInterval<CqlDateTime>;
                        if (bk_)
                        {
                            ai_ = bh_ as CqlInterval<CqlDateTime>;
                        }
                        else
                        {
                            bool bl_ = bh_ is CqlInterval<CqlQuantity>;
                            if (bl_)
                            {
                                ai_ = bh_ as CqlInterval<CqlQuantity>;
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
                CqlDate am_ = al_?.low;
                CqlDateTime an_ = context.Operators.ConvertDateToDateTime(am_);
                object ao_;
                DataType bm_ = tuple_fnrkedfurymcjidjkbtaenork?.AnesthesiaProcedure?.Performed;
                object bn_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bm_);
                bool bo_ = bn_ is CqlDateTime;
                if (bo_)
                {
                    ao_ = bn_ as CqlDateTime;
                }
                else
                {
                    bool bp_ = bn_ is CqlQuantity;
                    if (bp_)
                    {
                        ao_ = bn_ as CqlQuantity;
                    }
                    else
                    {
                        bool bq_ = bn_ is CqlInterval<CqlDateTime>;
                        if (bq_)
                        {
                            ao_ = bn_ as CqlInterval<CqlDateTime>;
                        }
                        else
                        {
                            bool br_ = bn_ is CqlInterval<CqlQuantity>;
                            if (br_)
                            {
                                ao_ = bn_ as CqlInterval<CqlQuantity>;
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
                CqlDate as_ = ar_?.high;
                CqlDateTime at_ = context.Operators.ConvertDateToDateTime(as_);
                object au_;
                DataType bs_ = tuple_fnrkedfurymcjidjkbtaenork?.AnesthesiaProcedure?.Performed;
                object bt_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bs_);
                bool bu_ = bt_ is CqlDateTime;
                if (bu_)
                {
                    au_ = bt_ as CqlDateTime;
                }
                else
                {
                    bool bv_ = bt_ is CqlQuantity;
                    if (bv_)
                    {
                        au_ = bt_ as CqlQuantity;
                    }
                    else
                    {
                        bool bw_ = bt_ is CqlInterval<CqlDateTime>;
                        if (bw_)
                        {
                            au_ = bt_ as CqlInterval<CqlDateTime>;
                        }
                        else
                        {
                            bool bx_ = bt_ is CqlInterval<CqlQuantity>;
                            if (bx_)
                            {
                                au_ = bt_ as CqlInterval<CqlQuantity>;
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
                CqlInterval<CqlDate> ax_ = TJCOverall_8_25_000.Instance.calendarDayOfOrDayAfter(context, aw_);
                bool? ay_ = ax_?.lowClosed;
                object az_;
                DataType by_ = tuple_fnrkedfurymcjidjkbtaenork?.AnesthesiaProcedure?.Performed;
                object bz_ = FHIRHelpers_4_4_000.Instance.ToValue(context, by_);
                bool ca_ = bz_ is CqlDateTime;
                if (ca_)
                {
                    az_ = bz_ as CqlDateTime;
                }
                else
                {
                    bool cb_ = bz_ is CqlQuantity;
                    if (cb_)
                    {
                        az_ = bz_ as CqlQuantity;
                    }
                    else
                    {
                        bool cc_ = bz_ is CqlInterval<CqlDateTime>;
                        if (cc_)
                        {
                            az_ = bz_ as CqlInterval<CqlDateTime>;
                        }
                        else
                        {
                            bool cd_ = bz_ is CqlInterval<CqlQuantity>;
                            if (cd_)
                            {
                                az_ = bz_ as CqlInterval<CqlQuantity>;
                            }
                            else
                            {
                                az_ = null;
                            }
                        }
                    }
                }
                CqlInterval<CqlDateTime> ba_ = QICoreCommon_4_0_000.Instance.toInterval(context, az_);
                CqlDateTime bb_ = context.Operators.End(ba_);
                CqlInterval<CqlDate> bc_ = TJCOverall_8_25_000.Instance.calendarDayOfOrDayAfter(context, bb_);
                bool? bd_ = bc_?.highClosed;
                CqlInterval<CqlDateTime> be_ = context.Operators.Interval(an_, at_, ay_, bd_);
                bool? bf_ = context.Operators.In<CqlDateTime>(ah_, be_, "day");
                return p_ & bf_;
            }
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
            bool? p_;
            // CQL 'and' (403:11-404:121): right operand skipped when left is false
            if (o_ is false)
            {
                p_ = false;
            }
            else
            {
                object q_;
                DataType x_ = tuple_bvgardhyjgbgfxidntuflexa?.AnesthesiaProcedure?.Performed;
                object y_ = FHIRHelpers_4_4_000.Instance.ToValue(context, x_);
                bool z_ = y_ is CqlDateTime;
                if (z_)
                {
                    q_ = y_ as CqlDateTime;
                }
                else
                {
                    bool aa_ = y_ is CqlQuantity;
                    if (aa_)
                    {
                        q_ = y_ as CqlQuantity;
                    }
                    else
                    {
                        bool ab_ = y_ is CqlInterval<CqlDateTime>;
                        if (ab_)
                        {
                            q_ = y_ as CqlInterval<CqlDateTime>;
                        }
                        else
                        {
                            bool ac_ = y_ is CqlInterval<CqlQuantity>;
                            if (ac_)
                            {
                                q_ = y_ as CqlInterval<CqlQuantity>;
                            }
                            else
                            {
                                q_ = null;
                            }
                        }
                    }
                }
                CqlInterval<CqlDateTime> r_ = QICoreCommon_4_0_000.Instance.toInterval(context, q_);
                CqlDateTime s_ = context.Operators.End(r_);
                CqlDateTime t_ = this.startOfFirstICU(context, tuple_bvgardhyjgbgfxidntuflexa?.QualifyingEncounterICU);
                CqlQuantity u_ = context.Operators.Quantity(1m, "day");
                CqlDateTime v_ = context.Operators.Add(t_, u_);
                bool? w_ = context.Operators.SameAs(s_, v_, "day");
                p_ = o_ & w_;
            }
            // CQL 'and' (403:5-405:133): right operand skipped when left is false
            if (p_ is false)
            {
                return false;
            }
            else
            {
                CqlDateTime ad_ = context.Operators.LateBoundProperty<CqlDateTime>(tuple_bvgardhyjgbgfxidntuflexa?.PatientRefusal, "authoredOn");
                object ae_;
                DataType bc_ = tuple_bvgardhyjgbgfxidntuflexa?.AnesthesiaProcedure?.Performed;
                object bd_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bc_);
                bool be_ = bd_ is CqlDateTime;
                if (be_)
                {
                    ae_ = bd_ as CqlDateTime;
                }
                else
                {
                    bool bf_ = bd_ is CqlQuantity;
                    if (bf_)
                    {
                        ae_ = bd_ as CqlQuantity;
                    }
                    else
                    {
                        bool bg_ = bd_ is CqlInterval<CqlDateTime>;
                        if (bg_)
                        {
                            ae_ = bd_ as CqlInterval<CqlDateTime>;
                        }
                        else
                        {
                            bool bh_ = bd_ is CqlInterval<CqlQuantity>;
                            if (bh_)
                            {
                                ae_ = bd_ as CqlInterval<CqlQuantity>;
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
                DataType bi_ = tuple_bvgardhyjgbgfxidntuflexa?.AnesthesiaProcedure?.Performed;
                object bj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bi_);
                bool bk_ = bj_ is CqlDateTime;
                if (bk_)
                {
                    ak_ = bj_ as CqlDateTime;
                }
                else
                {
                    bool bl_ = bj_ is CqlQuantity;
                    if (bl_)
                    {
                        ak_ = bj_ as CqlQuantity;
                    }
                    else
                    {
                        bool bm_ = bj_ is CqlInterval<CqlDateTime>;
                        if (bm_)
                        {
                            ak_ = bj_ as CqlInterval<CqlDateTime>;
                        }
                        else
                        {
                            bool bn_ = bj_ is CqlInterval<CqlQuantity>;
                            if (bn_)
                            {
                                ak_ = bj_ as CqlInterval<CqlQuantity>;
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
                DataType bo_ = tuple_bvgardhyjgbgfxidntuflexa?.AnesthesiaProcedure?.Performed;
                object bp_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bo_);
                bool bq_ = bp_ is CqlDateTime;
                if (bq_)
                {
                    aq_ = bp_ as CqlDateTime;
                }
                else
                {
                    bool br_ = bp_ is CqlQuantity;
                    if (br_)
                    {
                        aq_ = bp_ as CqlQuantity;
                    }
                    else
                    {
                        bool bs_ = bp_ is CqlInterval<CqlDateTime>;
                        if (bs_)
                        {
                            aq_ = bp_ as CqlInterval<CqlDateTime>;
                        }
                        else
                        {
                            bool bt_ = bp_ is CqlInterval<CqlQuantity>;
                            if (bt_)
                            {
                                aq_ = bp_ as CqlInterval<CqlQuantity>;
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
                DataType bu_ = tuple_bvgardhyjgbgfxidntuflexa?.AnesthesiaProcedure?.Performed;
                object bv_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bu_);
                bool bw_ = bv_ is CqlDateTime;
                if (bw_)
                {
                    av_ = bv_ as CqlDateTime;
                }
                else
                {
                    bool bx_ = bv_ is CqlQuantity;
                    if (bx_)
                    {
                        av_ = bv_ as CqlQuantity;
                    }
                    else
                    {
                        bool by_ = bv_ is CqlInterval<CqlDateTime>;
                        if (by_)
                        {
                            av_ = bv_ as CqlInterval<CqlDateTime>;
                        }
                        else
                        {
                            bool bz_ = bv_ is CqlInterval<CqlQuantity>;
                            if (bz_)
                            {
                                av_ = bv_ as CqlInterval<CqlQuantity>;
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
                return p_ & bb_;
            }
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

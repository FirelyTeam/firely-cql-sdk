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
                ResourceReference h_ = Location?.Location;
                Location i_ = CQMCommon_4_1_000.Instance.getLocation(context, h_);
                List<CodeableConcept> j_ = i_?.Type;

                CqlConcept k_(CodeableConcept @this) {
                    CqlConcept u_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);
                    return u_;
                }

                IEnumerable<CqlConcept> l_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)j_, k_);
                CqlValueSet m_ = this.Intensive_Care_Unit(context);
                bool? n_ = context.Operators.ConceptsInValueSet(l_, m_);
                Period o_ = QualifyingEncounter?.Period;
                CqlInterval<CqlDateTime> p_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, o_);
                Period q_ = Location?.Period;
                CqlInterval<CqlDateTime> r_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, q_);
                bool? s_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(p_, r_, (string)default);
                bool? t_ = context.Operators.And(n_, s_);
                return t_;
            }

            IEnumerable<Encounter.LocationComponent> f_ = context.Operators.Where<Encounter.LocationComponent>((IEnumerable<Encounter.LocationComponent>)d_, e_);
            bool? g_ = context.Operators.Exists<Encounter.LocationComponent>(f_);
            return g_;
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

        IEnumerable<Encounter> b_(Encounter QualifyingEncounterICU) {
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
                CqlInterval<CqlDate> n_ = this.fromDayOfStartOfHospitalizationToDayAfterFirstICU(context, QualifyingEncounterICU);
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
            Encounter g_(object ComfortMeasure) => QualifyingEncounterICU;
            IEnumerable<Encounter> h_ = context.Operators.Select<object, Encounter>(f_, g_);
            return h_;
        }

        IEnumerable<Encounter> c_ = context.Operators.SelectMany<Encounter, Encounter>(a_, b_);
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
            (CqlTupleMetadata, Encounter QualifyingEncounterICU, Procedure AnesthesiaProcedure, object ComfortMeasure)? m_ = (CqlTupleMetadata_ENTiROQhSLFcBRSgSOZVGLLAP, _valueTuple.Item1, _valueTuple.Item2, _valueTuple.Item3);
            return m_;
        }

        IEnumerable<(CqlTupleMetadata, Encounter QualifyingEncounterICU, Procedure AnesthesiaProcedure, object ComfortMeasure)?> g_ = context.Operators.Select<ValueTuple<Encounter, Procedure, object>, (CqlTupleMetadata, Encounter QualifyingEncounterICU, Procedure AnesthesiaProcedure, object ComfortMeasure)?>(e_, f_);

        bool? h_((CqlTupleMetadata, Encounter QualifyingEncounterICU, Procedure AnesthesiaProcedure, object ComfortMeasure)? tuple_gdefgctjcxpzbyfpuogejrgou) {
            Code<EventStatus> n_ = tuple_gdefgctjcxpzbyfpuogejrgou?.AnesthesiaProcedure?.StatusElement;
            EventStatus? o_ = n_?.Value;
            string p_ = context.Operators.Convert<string>(o_);
            bool? q_ = context.Operators.Equal(p_, "completed");

            object r_() {

                bool bd_() {
                    DataType bh_ = tuple_gdefgctjcxpzbyfpuogejrgou?.AnesthesiaProcedure?.Performed;
                    object bi_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bh_);
                    bool bj_ = bi_ is CqlDateTime;
                    return bj_;
                }


                bool be_() {
                    DataType bk_ = tuple_gdefgctjcxpzbyfpuogejrgou?.AnesthesiaProcedure?.Performed;
                    object bl_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bk_);
                    bool bm_ = bl_ is CqlInterval<CqlDateTime>;
                    return bm_;
                }


                bool bf_() {
                    DataType bn_ = tuple_gdefgctjcxpzbyfpuogejrgou?.AnesthesiaProcedure?.Performed;
                    object bo_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bn_);
                    bool bp_ = bo_ is CqlQuantity;
                    return bp_;
                }


                bool bg_() {
                    DataType bq_ = tuple_gdefgctjcxpzbyfpuogejrgou?.AnesthesiaProcedure?.Performed;
                    object br_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bq_);
                    bool bs_ = br_ is CqlInterval<CqlQuantity>;
                    return bs_;
                }

                if (bd_())
                {
                    DataType bt_ = tuple_gdefgctjcxpzbyfpuogejrgou?.AnesthesiaProcedure?.Performed;
                    object bu_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bt_);
                    return (bu_ as CqlDateTime) as object;
                }
                else if (be_())
                {
                    DataType bv_ = tuple_gdefgctjcxpzbyfpuogejrgou?.AnesthesiaProcedure?.Performed;
                    object bw_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bv_);
                    return (bw_ as CqlInterval<CqlDateTime>) as object;
                }
                else if (bf_())
                {
                    DataType bx_ = tuple_gdefgctjcxpzbyfpuogejrgou?.AnesthesiaProcedure?.Performed;
                    object by_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bx_);
                    return (by_ as CqlQuantity) as object;
                }
                else if (bg_())
                {
                    DataType bz_ = tuple_gdefgctjcxpzbyfpuogejrgou?.AnesthesiaProcedure?.Performed;
                    object ca_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bz_);
                    return (ca_ as CqlInterval<CqlQuantity>) as object;
                }
                else
                {
                    return null;
                };
            }

            CqlInterval<CqlDateTime> s_ = QICoreCommon_4_0_000.Instance.toInterval(context, r_());
            CqlDateTime t_ = context.Operators.End(s_);
            CqlDateTime u_ = this.startOfFirstICU(context, tuple_gdefgctjcxpzbyfpuogejrgou?.QualifyingEncounterICU);
            CqlQuantity v_ = context.Operators.Quantity(1m, "day");
            CqlDateTime w_ = context.Operators.Add(u_, v_);
            bool? x_ = context.Operators.SameAs(t_, w_, "day");
            bool? y_ = context.Operators.And(q_, x_);

            object z_() {

                bool cb_() {
                    object cf_ = context.Operators.LateBoundProperty<object>(tuple_gdefgctjcxpzbyfpuogejrgou?.ComfortMeasure, "performed");
                    object cg_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cf_);
                    bool ch_ = cg_ is CqlDateTime;
                    return ch_;
                }


                bool cc_() {
                    object ci_ = context.Operators.LateBoundProperty<object>(tuple_gdefgctjcxpzbyfpuogejrgou?.ComfortMeasure, "performed");
                    object cj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ci_);
                    bool ck_ = cj_ is CqlInterval<CqlDateTime>;
                    return ck_;
                }


                bool cd_() {
                    object cl_ = context.Operators.LateBoundProperty<object>(tuple_gdefgctjcxpzbyfpuogejrgou?.ComfortMeasure, "performed");
                    object cm_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cl_);
                    bool cn_ = cm_ is CqlQuantity;
                    return cn_;
                }


                bool ce_() {
                    object co_ = context.Operators.LateBoundProperty<object>(tuple_gdefgctjcxpzbyfpuogejrgou?.ComfortMeasure, "performed");
                    object cp_ = FHIRHelpers_4_4_000.Instance.ToValue(context, co_);
                    bool cq_ = cp_ is CqlInterval<CqlQuantity>;
                    return cq_;
                }

                if (cb_())
                {
                    object cr_ = context.Operators.LateBoundProperty<object>(tuple_gdefgctjcxpzbyfpuogejrgou?.ComfortMeasure, "performed");
                    object cs_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cr_);
                    return (cs_ as CqlDateTime) as object;
                }
                else if (cc_())
                {
                    object ct_ = context.Operators.LateBoundProperty<object>(tuple_gdefgctjcxpzbyfpuogejrgou?.ComfortMeasure, "performed");
                    object cu_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ct_);
                    return (cu_ as CqlInterval<CqlDateTime>) as object;
                }
                else if (cd_())
                {
                    object cv_ = context.Operators.LateBoundProperty<object>(tuple_gdefgctjcxpzbyfpuogejrgou?.ComfortMeasure, "performed");
                    object cw_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cv_);
                    return (cw_ as CqlQuantity) as object;
                }
                else if (ce_())
                {
                    object cx_ = context.Operators.LateBoundProperty<object>(tuple_gdefgctjcxpzbyfpuogejrgou?.ComfortMeasure, "performed");
                    object cy_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cx_);
                    return (cy_ as CqlInterval<CqlQuantity>) as object;
                }
                else
                {
                    return null;
                };
            }

            CqlInterval<CqlDateTime> aa_ = QICoreCommon_4_0_000.Instance.toInterval(context, z_());
            CqlDateTime ab_ = context.Operators.Start(aa_);
            object ac_ = context.Operators.LateBoundProperty<object>(tuple_gdefgctjcxpzbyfpuogejrgou?.ComfortMeasure, "authoredOn");
            CqlDateTime ad_ = context.Operators.LateBoundProperty<CqlDateTime>(ac_, "value");

            object ae_() {

                bool cz_() {
                    DataType dd_ = tuple_gdefgctjcxpzbyfpuogejrgou?.AnesthesiaProcedure?.Performed;
                    object de_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dd_);
                    bool df_ = de_ is CqlDateTime;
                    return df_;
                }


                bool da_() {
                    DataType dg_ = tuple_gdefgctjcxpzbyfpuogejrgou?.AnesthesiaProcedure?.Performed;
                    object dh_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dg_);
                    bool di_ = dh_ is CqlInterval<CqlDateTime>;
                    return di_;
                }


                bool db_() {
                    DataType dj_ = tuple_gdefgctjcxpzbyfpuogejrgou?.AnesthesiaProcedure?.Performed;
                    object dk_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dj_);
                    bool dl_ = dk_ is CqlQuantity;
                    return dl_;
                }


                bool dc_() {
                    DataType dm_ = tuple_gdefgctjcxpzbyfpuogejrgou?.AnesthesiaProcedure?.Performed;
                    object dn_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dm_);
                    bool do_ = dn_ is CqlInterval<CqlQuantity>;
                    return do_;
                }

                if (cz_())
                {
                    DataType dp_ = tuple_gdefgctjcxpzbyfpuogejrgou?.AnesthesiaProcedure?.Performed;
                    object dq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dp_);
                    return (dq_ as CqlDateTime) as object;
                }
                else if (da_())
                {
                    DataType dr_ = tuple_gdefgctjcxpzbyfpuogejrgou?.AnesthesiaProcedure?.Performed;
                    object ds_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dr_);
                    return (ds_ as CqlInterval<CqlDateTime>) as object;
                }
                else if (db_())
                {
                    DataType dt_ = tuple_gdefgctjcxpzbyfpuogejrgou?.AnesthesiaProcedure?.Performed;
                    object du_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dt_);
                    return (du_ as CqlQuantity) as object;
                }
                else if (dc_())
                {
                    DataType dv_ = tuple_gdefgctjcxpzbyfpuogejrgou?.AnesthesiaProcedure?.Performed;
                    object dw_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dv_);
                    return (dw_ as CqlInterval<CqlQuantity>) as object;
                }
                else
                {
                    return null;
                };
            }

            CqlInterval<CqlDateTime> af_ = QICoreCommon_4_0_000.Instance.toInterval(context, ae_());
            CqlDateTime ag_ = context.Operators.End(af_);
            CqlInterval<CqlDate> ah_ = TJCOverall_8_25_000.Instance.calendarDayOfOrDayAfter(context, ag_);
            CqlDate ai_ = ah_?.low;
            CqlDateTime aj_ = context.Operators.ConvertDateToDateTime(ai_);

            object ak_() {

                bool dx_() {
                    DataType eb_ = tuple_gdefgctjcxpzbyfpuogejrgou?.AnesthesiaProcedure?.Performed;
                    object ec_ = FHIRHelpers_4_4_000.Instance.ToValue(context, eb_);
                    bool ed_ = ec_ is CqlDateTime;
                    return ed_;
                }


                bool dy_() {
                    DataType ee_ = tuple_gdefgctjcxpzbyfpuogejrgou?.AnesthesiaProcedure?.Performed;
                    object ef_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ee_);
                    bool eg_ = ef_ is CqlInterval<CqlDateTime>;
                    return eg_;
                }


                bool dz_() {
                    DataType eh_ = tuple_gdefgctjcxpzbyfpuogejrgou?.AnesthesiaProcedure?.Performed;
                    object ei_ = FHIRHelpers_4_4_000.Instance.ToValue(context, eh_);
                    bool ej_ = ei_ is CqlQuantity;
                    return ej_;
                }


                bool ea_() {
                    DataType ek_ = tuple_gdefgctjcxpzbyfpuogejrgou?.AnesthesiaProcedure?.Performed;
                    object el_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ek_);
                    bool em_ = el_ is CqlInterval<CqlQuantity>;
                    return em_;
                }

                if (dx_())
                {
                    DataType en_ = tuple_gdefgctjcxpzbyfpuogejrgou?.AnesthesiaProcedure?.Performed;
                    object eo_ = FHIRHelpers_4_4_000.Instance.ToValue(context, en_);
                    return (eo_ as CqlDateTime) as object;
                }
                else if (dy_())
                {
                    DataType ep_ = tuple_gdefgctjcxpzbyfpuogejrgou?.AnesthesiaProcedure?.Performed;
                    object eq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ep_);
                    return (eq_ as CqlInterval<CqlDateTime>) as object;
                }
                else if (dz_())
                {
                    DataType er_ = tuple_gdefgctjcxpzbyfpuogejrgou?.AnesthesiaProcedure?.Performed;
                    object es_ = FHIRHelpers_4_4_000.Instance.ToValue(context, er_);
                    return (es_ as CqlQuantity) as object;
                }
                else if (ea_())
                {
                    DataType et_ = tuple_gdefgctjcxpzbyfpuogejrgou?.AnesthesiaProcedure?.Performed;
                    object eu_ = FHIRHelpers_4_4_000.Instance.ToValue(context, et_);
                    return (eu_ as CqlInterval<CqlQuantity>) as object;
                }
                else
                {
                    return null;
                };
            }

            CqlInterval<CqlDateTime> al_ = QICoreCommon_4_0_000.Instance.toInterval(context, ak_());
            CqlDateTime am_ = context.Operators.End(al_);
            CqlInterval<CqlDate> an_ = TJCOverall_8_25_000.Instance.calendarDayOfOrDayAfter(context, am_);
            CqlDate ao_ = an_?.high;
            CqlDateTime ap_ = context.Operators.ConvertDateToDateTime(ao_);

            object aq_() {

                bool ev_() {
                    DataType ez_ = tuple_gdefgctjcxpzbyfpuogejrgou?.AnesthesiaProcedure?.Performed;
                    object fa_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ez_);
                    bool fb_ = fa_ is CqlDateTime;
                    return fb_;
                }


                bool ew_() {
                    DataType fc_ = tuple_gdefgctjcxpzbyfpuogejrgou?.AnesthesiaProcedure?.Performed;
                    object fd_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fc_);
                    bool fe_ = fd_ is CqlInterval<CqlDateTime>;
                    return fe_;
                }


                bool ex_() {
                    DataType ff_ = tuple_gdefgctjcxpzbyfpuogejrgou?.AnesthesiaProcedure?.Performed;
                    object fg_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ff_);
                    bool fh_ = fg_ is CqlQuantity;
                    return fh_;
                }


                bool ey_() {
                    DataType fi_ = tuple_gdefgctjcxpzbyfpuogejrgou?.AnesthesiaProcedure?.Performed;
                    object fj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fi_);
                    bool fk_ = fj_ is CqlInterval<CqlQuantity>;
                    return fk_;
                }

                if (ev_())
                {
                    DataType fl_ = tuple_gdefgctjcxpzbyfpuogejrgou?.AnesthesiaProcedure?.Performed;
                    object fm_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fl_);
                    return (fm_ as CqlDateTime) as object;
                }
                else if (ew_())
                {
                    DataType fn_ = tuple_gdefgctjcxpzbyfpuogejrgou?.AnesthesiaProcedure?.Performed;
                    object fo_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fn_);
                    return (fo_ as CqlInterval<CqlDateTime>) as object;
                }
                else if (ex_())
                {
                    DataType fp_ = tuple_gdefgctjcxpzbyfpuogejrgou?.AnesthesiaProcedure?.Performed;
                    object fq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fp_);
                    return (fq_ as CqlQuantity) as object;
                }
                else if (ey_())
                {
                    DataType fr_ = tuple_gdefgctjcxpzbyfpuogejrgou?.AnesthesiaProcedure?.Performed;
                    object fs_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fr_);
                    return (fs_ as CqlInterval<CqlQuantity>) as object;
                }
                else
                {
                    return null;
                };
            }

            CqlInterval<CqlDateTime> ar_ = QICoreCommon_4_0_000.Instance.toInterval(context, aq_());
            CqlDateTime as_ = context.Operators.End(ar_);
            CqlInterval<CqlDate> at_ = TJCOverall_8_25_000.Instance.calendarDayOfOrDayAfter(context, as_);
            bool? au_ = at_?.lowClosed;

            object av_() {

                bool ft_() {
                    DataType fx_ = tuple_gdefgctjcxpzbyfpuogejrgou?.AnesthesiaProcedure?.Performed;
                    object fy_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fx_);
                    bool fz_ = fy_ is CqlDateTime;
                    return fz_;
                }


                bool fu_() {
                    DataType ga_ = tuple_gdefgctjcxpzbyfpuogejrgou?.AnesthesiaProcedure?.Performed;
                    object gb_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ga_);
                    bool gc_ = gb_ is CqlInterval<CqlDateTime>;
                    return gc_;
                }


                bool fv_() {
                    DataType gd_ = tuple_gdefgctjcxpzbyfpuogejrgou?.AnesthesiaProcedure?.Performed;
                    object ge_ = FHIRHelpers_4_4_000.Instance.ToValue(context, gd_);
                    bool gf_ = ge_ is CqlQuantity;
                    return gf_;
                }


                bool fw_() {
                    DataType gg_ = tuple_gdefgctjcxpzbyfpuogejrgou?.AnesthesiaProcedure?.Performed;
                    object gh_ = FHIRHelpers_4_4_000.Instance.ToValue(context, gg_);
                    bool gi_ = gh_ is CqlInterval<CqlQuantity>;
                    return gi_;
                }

                if (ft_())
                {
                    DataType gj_ = tuple_gdefgctjcxpzbyfpuogejrgou?.AnesthesiaProcedure?.Performed;
                    object gk_ = FHIRHelpers_4_4_000.Instance.ToValue(context, gj_);
                    return (gk_ as CqlDateTime) as object;
                }
                else if (fu_())
                {
                    DataType gl_ = tuple_gdefgctjcxpzbyfpuogejrgou?.AnesthesiaProcedure?.Performed;
                    object gm_ = FHIRHelpers_4_4_000.Instance.ToValue(context, gl_);
                    return (gm_ as CqlInterval<CqlDateTime>) as object;
                }
                else if (fv_())
                {
                    DataType gn_ = tuple_gdefgctjcxpzbyfpuogejrgou?.AnesthesiaProcedure?.Performed;
                    object go_ = FHIRHelpers_4_4_000.Instance.ToValue(context, gn_);
                    return (go_ as CqlQuantity) as object;
                }
                else if (fw_())
                {
                    DataType gp_ = tuple_gdefgctjcxpzbyfpuogejrgou?.AnesthesiaProcedure?.Performed;
                    object gq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, gp_);
                    return (gq_ as CqlInterval<CqlQuantity>) as object;
                }
                else
                {
                    return null;
                };
            }

            CqlInterval<CqlDateTime> aw_ = QICoreCommon_4_0_000.Instance.toInterval(context, av_());
            CqlDateTime ax_ = context.Operators.End(aw_);
            CqlInterval<CqlDate> ay_ = TJCOverall_8_25_000.Instance.calendarDayOfOrDayAfter(context, ax_);
            bool? az_ = ay_?.highClosed;
            CqlInterval<CqlDateTime> ba_ = context.Operators.Interval(aj_, ap_, au_, az_);
            bool? bb_ = context.Operators.In<CqlDateTime>(ab_ ?? ad_, ba_, "day");
            bool? bc_ = context.Operators.And(y_, bb_);
            return bc_;
        }

        IEnumerable<(CqlTupleMetadata, Encounter QualifyingEncounterICU, Procedure AnesthesiaProcedure, object ComfortMeasure)?> i_ = context.Operators.Where<(CqlTupleMetadata, Encounter QualifyingEncounterICU, Procedure AnesthesiaProcedure, object ComfortMeasure)?>(g_, h_);
        Encounter j_((CqlTupleMetadata, Encounter QualifyingEncounterICU, Procedure AnesthesiaProcedure, object ComfortMeasure)? tuple_gdefgctjcxpzbyfpuogejrgou) => tuple_gdefgctjcxpzbyfpuogejrgou?.QualifyingEncounterICU;
        IEnumerable<Encounter> k_ = context.Operators.Select<(CqlTupleMetadata, Encounter QualifyingEncounterICU, Procedure AnesthesiaProcedure, object ComfortMeasure)?, Encounter>(i_, j_);
        IEnumerable<Encounter> l_ = context.Operators.Distinct<Encounter>(k_);
        return l_;
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


    [CqlExpressionDefinition("Encounter With VTE Prophylaxis Received On Day Of Or Day After First ICU Stay Or Procedure")]
    public IEnumerable<Encounter> Encounter_With_VTE_Prophylaxis_Received_On_Day_Of_Or_Day_After_First_ICU_Stay_Or_Procedure(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Encounter_With_VTE_Prophylaxis_Received_On_Day_Of_Or_Day_After_First_ICU_Stay_Or_Procedure, Encounter_With_VTE_Prophylaxis_Received_On_Day_Of_Or_Day_After_First_ICU_Stay_Or_Procedure_Compute);

    private const long _cacheIndex_Encounter_With_VTE_Prophylaxis_Received_On_Day_Of_Or_Day_After_First_ICU_Stay_Or_Procedure = -7598193577679081823L;

    private IEnumerable<Encounter> Encounter_With_VTE_Prophylaxis_Received_On_Day_Of_Or_Day_After_First_ICU_Stay_Or_Procedure_Compute(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Encounter_With_ICU_Location(context);

        IEnumerable<Encounter> b_(Encounter QualifyingEncounterICU) {
            IEnumerable<object> q_ = this.Pharmacological_Or_Mechanical_VTE_Prophylaxis_Received(context);

            bool? r_(object VTEProphylaxis) {
                object v_ = context.Operators.LateBoundProperty<object>(VTEProphylaxis, "effective");
                object w_ = FHIRHelpers_4_4_000.Instance.ToValue(context, v_);
                CqlInterval<CqlDateTime> x_ = QICoreCommon_4_0_000.Instance.toInterval(context, w_);

                object y_() {

                    bool ar_() {
                        object av_ = context.Operators.LateBoundProperty<object>(VTEProphylaxis, "performed");
                        object aw_ = FHIRHelpers_4_4_000.Instance.ToValue(context, av_);
                        bool ax_ = aw_ is CqlDateTime;
                        return ax_;
                    }


                    bool as_() {
                        object ay_ = context.Operators.LateBoundProperty<object>(VTEProphylaxis, "performed");
                        object az_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ay_);
                        bool ba_ = az_ is CqlInterval<CqlDateTime>;
                        return ba_;
                    }


                    bool at_() {
                        object bb_ = context.Operators.LateBoundProperty<object>(VTEProphylaxis, "performed");
                        object bc_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bb_);
                        bool bd_ = bc_ is CqlQuantity;
                        return bd_;
                    }


                    bool au_() {
                        object be_ = context.Operators.LateBoundProperty<object>(VTEProphylaxis, "performed");
                        object bf_ = FHIRHelpers_4_4_000.Instance.ToValue(context, be_);
                        bool bg_ = bf_ is CqlInterval<CqlQuantity>;
                        return bg_;
                    }

                    if (ar_())
                    {
                        object bh_ = context.Operators.LateBoundProperty<object>(VTEProphylaxis, "performed");
                        object bi_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bh_);
                        return (bi_ as CqlDateTime) as object;
                    }
                    else if (as_())
                    {
                        object bj_ = context.Operators.LateBoundProperty<object>(VTEProphylaxis, "performed");
                        object bk_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bj_);
                        return (bk_ as CqlInterval<CqlDateTime>) as object;
                    }
                    else if (at_())
                    {
                        object bl_ = context.Operators.LateBoundProperty<object>(VTEProphylaxis, "performed");
                        object bm_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bl_);
                        return (bm_ as CqlQuantity) as object;
                    }
                    else if (au_())
                    {
                        object bn_ = context.Operators.LateBoundProperty<object>(VTEProphylaxis, "performed");
                        object bo_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bn_);
                        return (bo_ as CqlInterval<CqlQuantity>) as object;
                    }
                    else
                    {
                        return null;
                    };
                }

                CqlInterval<CqlDateTime> z_ = QICoreCommon_4_0_000.Instance.toInterval(context, y_());
                CqlDateTime aa_ = context.Operators.Start(x_ ?? z_);
                CqlDateTime ab_ = this.startOfFirstICU(context, QualifyingEncounterICU);
                CqlInterval<CqlDate> ac_ = TJCOverall_8_25_000.Instance.calendarDayOfOrDayAfter(context, ab_);
                CqlDate ad_ = ac_?.low;
                CqlDateTime ae_ = context.Operators.ConvertDateToDateTime(ad_);
                CqlInterval<CqlDate> ag_ = TJCOverall_8_25_000.Instance.calendarDayOfOrDayAfter(context, ab_);
                CqlDate ah_ = ag_?.high;
                CqlDateTime ai_ = context.Operators.ConvertDateToDateTime(ah_);
                CqlInterval<CqlDate> ak_ = TJCOverall_8_25_000.Instance.calendarDayOfOrDayAfter(context, ab_);
                bool? al_ = ak_?.lowClosed;
                CqlInterval<CqlDate> an_ = TJCOverall_8_25_000.Instance.calendarDayOfOrDayAfter(context, ab_);
                bool? ao_ = an_?.highClosed;
                CqlInterval<CqlDateTime> ap_ = context.Operators.Interval(ae_, ai_, al_, ao_);
                bool? aq_ = context.Operators.In<CqlDateTime>(aa_, ap_, "day");
                return aq_;
            }

            IEnumerable<object> s_ = context.Operators.Where<object>(q_, r_);
            Encounter t_(object VTEProphylaxis) => QualifyingEncounterICU;
            IEnumerable<Encounter> u_ = context.Operators.Select<object, Encounter>(s_, t_);
            return u_;
        }

        IEnumerable<Encounter> c_ = context.Operators.SelectMany<Encounter, Encounter>(a_, b_);
        CqlValueSet e_ = this.General_or_Neuraxial_Anesthesia(context);
        IEnumerable<Procedure> f_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, e_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
        IEnumerable<object> g_ = this.Pharmacological_Or_Mechanical_VTE_Prophylaxis_Received(context);
        IEnumerable<ValueTuple<Encounter, Procedure, object>> h_ = context.Operators.CrossJoin<Encounter, Procedure, object>(a_, f_, g_);

        (CqlTupleMetadata, Encounter QualifyingEncounterICU, Procedure AnesthesiaProcedure, object VTEProphylaxis)? i_(ValueTuple<Encounter, Procedure, object> _valueTuple) {
            (CqlTupleMetadata, Encounter QualifyingEncounterICU, Procedure AnesthesiaProcedure, object VTEProphylaxis)? bp_ = (CqlTupleMetadata_CGYAgYdKXUHcFINAPjMZNihh, _valueTuple.Item1, _valueTuple.Item2, _valueTuple.Item3);
            return bp_;
        }

        IEnumerable<(CqlTupleMetadata, Encounter QualifyingEncounterICU, Procedure AnesthesiaProcedure, object VTEProphylaxis)?> j_ = context.Operators.Select<ValueTuple<Encounter, Procedure, object>, (CqlTupleMetadata, Encounter QualifyingEncounterICU, Procedure AnesthesiaProcedure, object VTEProphylaxis)?>(h_, i_);

        bool? k_((CqlTupleMetadata, Encounter QualifyingEncounterICU, Procedure AnesthesiaProcedure, object VTEProphylaxis)? tuple_drnlhywkgwmzdeyzybtiilbhf) {
            Code<EventStatus> bq_ = tuple_drnlhywkgwmzdeyzybtiilbhf?.AnesthesiaProcedure?.StatusElement;
            EventStatus? br_ = bq_?.Value;
            string bs_ = context.Operators.Convert<string>(br_);
            bool? bt_ = context.Operators.Equal(bs_, "completed");

            object bu_() {

                bool dh_() {
                    DataType dl_ = tuple_drnlhywkgwmzdeyzybtiilbhf?.AnesthesiaProcedure?.Performed;
                    object dm_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dl_);
                    bool dn_ = dm_ is CqlDateTime;
                    return dn_;
                }


                bool di_() {
                    DataType do_ = tuple_drnlhywkgwmzdeyzybtiilbhf?.AnesthesiaProcedure?.Performed;
                    object dp_ = FHIRHelpers_4_4_000.Instance.ToValue(context, do_);
                    bool dq_ = dp_ is CqlInterval<CqlDateTime>;
                    return dq_;
                }


                bool dj_() {
                    DataType dr_ = tuple_drnlhywkgwmzdeyzybtiilbhf?.AnesthesiaProcedure?.Performed;
                    object ds_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dr_);
                    bool dt_ = ds_ is CqlQuantity;
                    return dt_;
                }


                bool dk_() {
                    DataType du_ = tuple_drnlhywkgwmzdeyzybtiilbhf?.AnesthesiaProcedure?.Performed;
                    object dv_ = FHIRHelpers_4_4_000.Instance.ToValue(context, du_);
                    bool dw_ = dv_ is CqlInterval<CqlQuantity>;
                    return dw_;
                }

                if (dh_())
                {
                    DataType dx_ = tuple_drnlhywkgwmzdeyzybtiilbhf?.AnesthesiaProcedure?.Performed;
                    object dy_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dx_);
                    return (dy_ as CqlDateTime) as object;
                }
                else if (di_())
                {
                    DataType dz_ = tuple_drnlhywkgwmzdeyzybtiilbhf?.AnesthesiaProcedure?.Performed;
                    object ea_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dz_);
                    return (ea_ as CqlInterval<CqlDateTime>) as object;
                }
                else if (dj_())
                {
                    DataType eb_ = tuple_drnlhywkgwmzdeyzybtiilbhf?.AnesthesiaProcedure?.Performed;
                    object ec_ = FHIRHelpers_4_4_000.Instance.ToValue(context, eb_);
                    return (ec_ as CqlQuantity) as object;
                }
                else if (dk_())
                {
                    DataType ed_ = tuple_drnlhywkgwmzdeyzybtiilbhf?.AnesthesiaProcedure?.Performed;
                    object ee_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ed_);
                    return (ee_ as CqlInterval<CqlQuantity>) as object;
                }
                else
                {
                    return null;
                };
            }

            CqlInterval<CqlDateTime> bv_ = QICoreCommon_4_0_000.Instance.toInterval(context, bu_());
            CqlDateTime bw_ = context.Operators.End(bv_);
            CqlDateTime bx_ = this.startOfFirstICU(context, tuple_drnlhywkgwmzdeyzybtiilbhf?.QualifyingEncounterICU);
            CqlQuantity by_ = context.Operators.Quantity(1m, "day");
            CqlDateTime bz_ = context.Operators.Add(bx_, by_);
            bool? ca_ = context.Operators.SameAs(bw_, bz_, "day");
            bool? cb_ = context.Operators.And(bt_, ca_);
            object cc_ = context.Operators.LateBoundProperty<object>(tuple_drnlhywkgwmzdeyzybtiilbhf?.VTEProphylaxis, "effective");
            object cd_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cc_);
            CqlInterval<CqlDateTime> ce_ = QICoreCommon_4_0_000.Instance.toInterval(context, cd_);

            object cf_() {

                bool ef_() {
                    object ej_ = context.Operators.LateBoundProperty<object>(tuple_drnlhywkgwmzdeyzybtiilbhf?.VTEProphylaxis, "performed");
                    object ek_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ej_);
                    bool el_ = ek_ is CqlDateTime;
                    return el_;
                }


                bool eg_() {
                    object em_ = context.Operators.LateBoundProperty<object>(tuple_drnlhywkgwmzdeyzybtiilbhf?.VTEProphylaxis, "performed");
                    object en_ = FHIRHelpers_4_4_000.Instance.ToValue(context, em_);
                    bool eo_ = en_ is CqlInterval<CqlDateTime>;
                    return eo_;
                }


                bool eh_() {
                    object ep_ = context.Operators.LateBoundProperty<object>(tuple_drnlhywkgwmzdeyzybtiilbhf?.VTEProphylaxis, "performed");
                    object eq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ep_);
                    bool er_ = eq_ is CqlQuantity;
                    return er_;
                }


                bool ei_() {
                    object es_ = context.Operators.LateBoundProperty<object>(tuple_drnlhywkgwmzdeyzybtiilbhf?.VTEProphylaxis, "performed");
                    object et_ = FHIRHelpers_4_4_000.Instance.ToValue(context, es_);
                    bool eu_ = et_ is CqlInterval<CqlQuantity>;
                    return eu_;
                }

                if (ef_())
                {
                    object ev_ = context.Operators.LateBoundProperty<object>(tuple_drnlhywkgwmzdeyzybtiilbhf?.VTEProphylaxis, "performed");
                    object ew_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ev_);
                    return (ew_ as CqlDateTime) as object;
                }
                else if (eg_())
                {
                    object ex_ = context.Operators.LateBoundProperty<object>(tuple_drnlhywkgwmzdeyzybtiilbhf?.VTEProphylaxis, "performed");
                    object ey_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ex_);
                    return (ey_ as CqlInterval<CqlDateTime>) as object;
                }
                else if (eh_())
                {
                    object ez_ = context.Operators.LateBoundProperty<object>(tuple_drnlhywkgwmzdeyzybtiilbhf?.VTEProphylaxis, "performed");
                    object fa_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ez_);
                    return (fa_ as CqlQuantity) as object;
                }
                else if (ei_())
                {
                    object fb_ = context.Operators.LateBoundProperty<object>(tuple_drnlhywkgwmzdeyzybtiilbhf?.VTEProphylaxis, "performed");
                    object fc_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fb_);
                    return (fc_ as CqlInterval<CqlQuantity>) as object;
                }
                else
                {
                    return null;
                };
            }

            CqlInterval<CqlDateTime> cg_ = QICoreCommon_4_0_000.Instance.toInterval(context, cf_());
            CqlDateTime ch_ = context.Operators.Start(ce_ ?? cg_);

            object ci_() {

                bool fd_() {
                    DataType fh_ = tuple_drnlhywkgwmzdeyzybtiilbhf?.AnesthesiaProcedure?.Performed;
                    object fi_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fh_);
                    bool fj_ = fi_ is CqlDateTime;
                    return fj_;
                }


                bool fe_() {
                    DataType fk_ = tuple_drnlhywkgwmzdeyzybtiilbhf?.AnesthesiaProcedure?.Performed;
                    object fl_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fk_);
                    bool fm_ = fl_ is CqlInterval<CqlDateTime>;
                    return fm_;
                }


                bool ff_() {
                    DataType fn_ = tuple_drnlhywkgwmzdeyzybtiilbhf?.AnesthesiaProcedure?.Performed;
                    object fo_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fn_);
                    bool fp_ = fo_ is CqlQuantity;
                    return fp_;
                }


                bool fg_() {
                    DataType fq_ = tuple_drnlhywkgwmzdeyzybtiilbhf?.AnesthesiaProcedure?.Performed;
                    object fr_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fq_);
                    bool fs_ = fr_ is CqlInterval<CqlQuantity>;
                    return fs_;
                }

                if (fd_())
                {
                    DataType ft_ = tuple_drnlhywkgwmzdeyzybtiilbhf?.AnesthesiaProcedure?.Performed;
                    object fu_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ft_);
                    return (fu_ as CqlDateTime) as object;
                }
                else if (fe_())
                {
                    DataType fv_ = tuple_drnlhywkgwmzdeyzybtiilbhf?.AnesthesiaProcedure?.Performed;
                    object fw_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fv_);
                    return (fw_ as CqlInterval<CqlDateTime>) as object;
                }
                else if (ff_())
                {
                    DataType fx_ = tuple_drnlhywkgwmzdeyzybtiilbhf?.AnesthesiaProcedure?.Performed;
                    object fy_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fx_);
                    return (fy_ as CqlQuantity) as object;
                }
                else if (fg_())
                {
                    DataType fz_ = tuple_drnlhywkgwmzdeyzybtiilbhf?.AnesthesiaProcedure?.Performed;
                    object ga_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fz_);
                    return (ga_ as CqlInterval<CqlQuantity>) as object;
                }
                else
                {
                    return null;
                };
            }

            CqlInterval<CqlDateTime> cj_ = QICoreCommon_4_0_000.Instance.toInterval(context, ci_());
            CqlDateTime ck_ = context.Operators.End(cj_);
            CqlInterval<CqlDate> cl_ = TJCOverall_8_25_000.Instance.calendarDayOfOrDayAfter(context, ck_);
            CqlDate cm_ = cl_?.low;
            CqlDateTime cn_ = context.Operators.ConvertDateToDateTime(cm_);

            object co_() {

                bool gb_() {
                    DataType gf_ = tuple_drnlhywkgwmzdeyzybtiilbhf?.AnesthesiaProcedure?.Performed;
                    object gg_ = FHIRHelpers_4_4_000.Instance.ToValue(context, gf_);
                    bool gh_ = gg_ is CqlDateTime;
                    return gh_;
                }


                bool gc_() {
                    DataType gi_ = tuple_drnlhywkgwmzdeyzybtiilbhf?.AnesthesiaProcedure?.Performed;
                    object gj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, gi_);
                    bool gk_ = gj_ is CqlInterval<CqlDateTime>;
                    return gk_;
                }


                bool gd_() {
                    DataType gl_ = tuple_drnlhywkgwmzdeyzybtiilbhf?.AnesthesiaProcedure?.Performed;
                    object gm_ = FHIRHelpers_4_4_000.Instance.ToValue(context, gl_);
                    bool gn_ = gm_ is CqlQuantity;
                    return gn_;
                }


                bool ge_() {
                    DataType go_ = tuple_drnlhywkgwmzdeyzybtiilbhf?.AnesthesiaProcedure?.Performed;
                    object gp_ = FHIRHelpers_4_4_000.Instance.ToValue(context, go_);
                    bool gq_ = gp_ is CqlInterval<CqlQuantity>;
                    return gq_;
                }

                if (gb_())
                {
                    DataType gr_ = tuple_drnlhywkgwmzdeyzybtiilbhf?.AnesthesiaProcedure?.Performed;
                    object gs_ = FHIRHelpers_4_4_000.Instance.ToValue(context, gr_);
                    return (gs_ as CqlDateTime) as object;
                }
                else if (gc_())
                {
                    DataType gt_ = tuple_drnlhywkgwmzdeyzybtiilbhf?.AnesthesiaProcedure?.Performed;
                    object gu_ = FHIRHelpers_4_4_000.Instance.ToValue(context, gt_);
                    return (gu_ as CqlInterval<CqlDateTime>) as object;
                }
                else if (gd_())
                {
                    DataType gv_ = tuple_drnlhywkgwmzdeyzybtiilbhf?.AnesthesiaProcedure?.Performed;
                    object gw_ = FHIRHelpers_4_4_000.Instance.ToValue(context, gv_);
                    return (gw_ as CqlQuantity) as object;
                }
                else if (ge_())
                {
                    DataType gx_ = tuple_drnlhywkgwmzdeyzybtiilbhf?.AnesthesiaProcedure?.Performed;
                    object gy_ = FHIRHelpers_4_4_000.Instance.ToValue(context, gx_);
                    return (gy_ as CqlInterval<CqlQuantity>) as object;
                }
                else
                {
                    return null;
                };
            }

            CqlInterval<CqlDateTime> cp_ = QICoreCommon_4_0_000.Instance.toInterval(context, co_());
            CqlDateTime cq_ = context.Operators.End(cp_);
            CqlInterval<CqlDate> cr_ = TJCOverall_8_25_000.Instance.calendarDayOfOrDayAfter(context, cq_);
            CqlDate cs_ = cr_?.high;
            CqlDateTime ct_ = context.Operators.ConvertDateToDateTime(cs_);

            object cu_() {

                bool gz_() {
                    DataType hd_ = tuple_drnlhywkgwmzdeyzybtiilbhf?.AnesthesiaProcedure?.Performed;
                    object he_ = FHIRHelpers_4_4_000.Instance.ToValue(context, hd_);
                    bool hf_ = he_ is CqlDateTime;
                    return hf_;
                }


                bool ha_() {
                    DataType hg_ = tuple_drnlhywkgwmzdeyzybtiilbhf?.AnesthesiaProcedure?.Performed;
                    object hh_ = FHIRHelpers_4_4_000.Instance.ToValue(context, hg_);
                    bool hi_ = hh_ is CqlInterval<CqlDateTime>;
                    return hi_;
                }


                bool hb_() {
                    DataType hj_ = tuple_drnlhywkgwmzdeyzybtiilbhf?.AnesthesiaProcedure?.Performed;
                    object hk_ = FHIRHelpers_4_4_000.Instance.ToValue(context, hj_);
                    bool hl_ = hk_ is CqlQuantity;
                    return hl_;
                }


                bool hc_() {
                    DataType hm_ = tuple_drnlhywkgwmzdeyzybtiilbhf?.AnesthesiaProcedure?.Performed;
                    object hn_ = FHIRHelpers_4_4_000.Instance.ToValue(context, hm_);
                    bool ho_ = hn_ is CqlInterval<CqlQuantity>;
                    return ho_;
                }

                if (gz_())
                {
                    DataType hp_ = tuple_drnlhywkgwmzdeyzybtiilbhf?.AnesthesiaProcedure?.Performed;
                    object hq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, hp_);
                    return (hq_ as CqlDateTime) as object;
                }
                else if (ha_())
                {
                    DataType hr_ = tuple_drnlhywkgwmzdeyzybtiilbhf?.AnesthesiaProcedure?.Performed;
                    object hs_ = FHIRHelpers_4_4_000.Instance.ToValue(context, hr_);
                    return (hs_ as CqlInterval<CqlDateTime>) as object;
                }
                else if (hb_())
                {
                    DataType ht_ = tuple_drnlhywkgwmzdeyzybtiilbhf?.AnesthesiaProcedure?.Performed;
                    object hu_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ht_);
                    return (hu_ as CqlQuantity) as object;
                }
                else if (hc_())
                {
                    DataType hv_ = tuple_drnlhywkgwmzdeyzybtiilbhf?.AnesthesiaProcedure?.Performed;
                    object hw_ = FHIRHelpers_4_4_000.Instance.ToValue(context, hv_);
                    return (hw_ as CqlInterval<CqlQuantity>) as object;
                }
                else
                {
                    return null;
                };
            }

            CqlInterval<CqlDateTime> cv_ = QICoreCommon_4_0_000.Instance.toInterval(context, cu_());
            CqlDateTime cw_ = context.Operators.End(cv_);
            CqlInterval<CqlDate> cx_ = TJCOverall_8_25_000.Instance.calendarDayOfOrDayAfter(context, cw_);
            bool? cy_ = cx_?.lowClosed;

            object cz_() {

                bool hx_() {
                    DataType ib_ = tuple_drnlhywkgwmzdeyzybtiilbhf?.AnesthesiaProcedure?.Performed;
                    object ic_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ib_);
                    bool id_ = ic_ is CqlDateTime;
                    return id_;
                }


                bool hy_() {
                    DataType ie_ = tuple_drnlhywkgwmzdeyzybtiilbhf?.AnesthesiaProcedure?.Performed;
                    object if_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ie_);
                    bool ig_ = if_ is CqlInterval<CqlDateTime>;
                    return ig_;
                }


                bool hz_() {
                    DataType ih_ = tuple_drnlhywkgwmzdeyzybtiilbhf?.AnesthesiaProcedure?.Performed;
                    object ii_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ih_);
                    bool ij_ = ii_ is CqlQuantity;
                    return ij_;
                }


                bool ia_() {
                    DataType ik_ = tuple_drnlhywkgwmzdeyzybtiilbhf?.AnesthesiaProcedure?.Performed;
                    object il_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ik_);
                    bool im_ = il_ is CqlInterval<CqlQuantity>;
                    return im_;
                }

                if (hx_())
                {
                    DataType in_ = tuple_drnlhywkgwmzdeyzybtiilbhf?.AnesthesiaProcedure?.Performed;
                    object io_ = FHIRHelpers_4_4_000.Instance.ToValue(context, in_);
                    return (io_ as CqlDateTime) as object;
                }
                else if (hy_())
                {
                    DataType ip_ = tuple_drnlhywkgwmzdeyzybtiilbhf?.AnesthesiaProcedure?.Performed;
                    object iq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ip_);
                    return (iq_ as CqlInterval<CqlDateTime>) as object;
                }
                else if (hz_())
                {
                    DataType ir_ = tuple_drnlhywkgwmzdeyzybtiilbhf?.AnesthesiaProcedure?.Performed;
                    object is_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ir_);
                    return (is_ as CqlQuantity) as object;
                }
                else if (ia_())
                {
                    DataType it_ = tuple_drnlhywkgwmzdeyzybtiilbhf?.AnesthesiaProcedure?.Performed;
                    object iu_ = FHIRHelpers_4_4_000.Instance.ToValue(context, it_);
                    return (iu_ as CqlInterval<CqlQuantity>) as object;
                }
                else
                {
                    return null;
                };
            }

            CqlInterval<CqlDateTime> da_ = QICoreCommon_4_0_000.Instance.toInterval(context, cz_());
            CqlDateTime db_ = context.Operators.End(da_);
            CqlInterval<CqlDate> dc_ = TJCOverall_8_25_000.Instance.calendarDayOfOrDayAfter(context, db_);
            bool? dd_ = dc_?.highClosed;
            CqlInterval<CqlDateTime> de_ = context.Operators.Interval(cn_, ct_, cy_, dd_);
            bool? df_ = context.Operators.In<CqlDateTime>(ch_, de_, "day");
            bool? dg_ = context.Operators.And(cb_, df_);
            return dg_;
        }

        IEnumerable<(CqlTupleMetadata, Encounter QualifyingEncounterICU, Procedure AnesthesiaProcedure, object VTEProphylaxis)?> l_ = context.Operators.Where<(CqlTupleMetadata, Encounter QualifyingEncounterICU, Procedure AnesthesiaProcedure, object VTEProphylaxis)?>(j_, k_);
        Encounter m_((CqlTupleMetadata, Encounter QualifyingEncounterICU, Procedure AnesthesiaProcedure, object VTEProphylaxis)? tuple_drnlhywkgwmzdeyzybtiilbhf) => tuple_drnlhywkgwmzdeyzybtiilbhf?.QualifyingEncounterICU;
        IEnumerable<Encounter> n_ = context.Operators.Select<(CqlTupleMetadata, Encounter QualifyingEncounterICU, Procedure AnesthesiaProcedure, object VTEProphylaxis)?, Encounter>(l_, m_);
        IEnumerable<Encounter> o_ = context.Operators.Distinct<Encounter>(n_);
        IEnumerable<Encounter> p_ = context.Operators.Union<Encounter>(c_, o_);
        return p_;
    }


    [CqlExpressionDefinition("Encounter With Medication Oral Factor Xa Inhibitor Administered On Day Of Or Day After First ICU Stay Or Procedure")]
    public IEnumerable<Encounter> Encounter_With_Medication_Oral_Factor_Xa_Inhibitor_Administered_On_Day_Of_Or_Day_After_First_ICU_Stay_Or_Procedure(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Encounter_With_Medication_Oral_Factor_Xa_Inhibitor_Administered_On_Day_Of_Or_Day_After_First_ICU_Stay_Or_Procedure, Encounter_With_Medication_Oral_Factor_Xa_Inhibitor_Administered_On_Day_Of_Or_Day_After_First_ICU_Stay_Or_Procedure_Compute);

    private const long _cacheIndex_Encounter_With_Medication_Oral_Factor_Xa_Inhibitor_Administered_On_Day_Of_Or_Day_After_First_ICU_Stay_Or_Procedure = 1433532295141068796L;

    private IEnumerable<Encounter> Encounter_With_Medication_Oral_Factor_Xa_Inhibitor_Administered_On_Day_Of_Or_Day_After_First_ICU_Stay_Or_Procedure_Compute(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Encounter_With_ICU_Location(context);

        IEnumerable<Encounter> b_(Encounter QualifyingEncounterICU) {
            CqlValueSet v_ = this.Oral_Factor_Xa_Inhibitor_for_VTE_Prophylaxis_or_VTE_Treatment(context);
            IEnumerable<MedicationAdministration> w_ = context.Operators.Retrieve<MedicationAdministration>(new RetrieveParameters(default, v_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationadministration"));
            IEnumerable<MedicationAdministration> x_ = context.Operators.Retrieve<MedicationAdministration>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationadministration"));

            IEnumerable<MedicationAdministration> y_(MedicationAdministration MR) {
                IEnumerable<Medication> af_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));

                bool? ag_(Medication M) {
                    object ak_ = context.Operators.LateBoundProperty<object>(M, "id.value");
                    object al_ = context.Operators.LateBoundProperty<object>(MR, "medication.reference.value");
                    IEnumerable<string> am_ = context.Operators.Split((string)al_, "/");
                    string an_ = context.Operators.Last<string>(am_);
                    bool? ao_ = context.Operators.Equal(ak_, an_);
                    CodeableConcept ap_ = M?.Code;
                    CqlConcept aq_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, ap_);
                    CqlValueSet ar_ = this.Oral_Factor_Xa_Inhibitor_for_VTE_Prophylaxis_or_VTE_Treatment(context);
                    bool? as_ = context.Operators.ConceptInValueSet(aq_, ar_);
                    bool? at_ = context.Operators.And(ao_, as_);
                    return at_;
                }

                IEnumerable<Medication> ah_ = context.Operators.Where<Medication>(af_, ag_);
                MedicationAdministration ai_(Medication M) => MR;
                IEnumerable<MedicationAdministration> aj_ = context.Operators.Select<Medication, MedicationAdministration>(ah_, ai_);
                return aj_;
            }

            IEnumerable<MedicationAdministration> z_ = context.Operators.SelectMany<MedicationAdministration, MedicationAdministration>(x_, y_);
            IEnumerable<MedicationAdministration> aa_ = context.Operators.Union<MedicationAdministration>(w_, z_);

            bool? ab_(MedicationAdministration FactorXaMedication) {
                Code<MedicationAdministration.MedicationAdministrationStatusCodes> au_ = FactorXaMedication?.StatusElement;
                MedicationAdministration.MedicationAdministrationStatusCodes? av_ = au_?.Value;
                string aw_ = context.Operators.Convert<string>(av_);
                bool? ax_ = context.Operators.Equal(aw_, "completed");
                DataType ay_ = FactorXaMedication?.Effective;
                object az_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ay_);
                CqlInterval<CqlDateTime> ba_ = QICoreCommon_4_0_000.Instance.toInterval(context, az_);
                CqlDateTime bb_ = context.Operators.Start(ba_);
                CqlDateTime bc_ = this.startOfFirstICU(context, QualifyingEncounterICU);
                CqlInterval<CqlDate> bd_ = TJCOverall_8_25_000.Instance.calendarDayOfOrDayAfter(context, bc_);
                CqlDate be_ = bd_?.low;
                CqlDateTime bf_ = context.Operators.ConvertDateToDateTime(be_);
                CqlInterval<CqlDate> bh_ = TJCOverall_8_25_000.Instance.calendarDayOfOrDayAfter(context, bc_);
                CqlDate bi_ = bh_?.high;
                CqlDateTime bj_ = context.Operators.ConvertDateToDateTime(bi_);
                CqlInterval<CqlDate> bl_ = TJCOverall_8_25_000.Instance.calendarDayOfOrDayAfter(context, bc_);
                bool? bm_ = bl_?.lowClosed;
                CqlInterval<CqlDate> bo_ = TJCOverall_8_25_000.Instance.calendarDayOfOrDayAfter(context, bc_);
                bool? bp_ = bo_?.highClosed;
                CqlInterval<CqlDateTime> bq_ = context.Operators.Interval(bf_, bj_, bm_, bp_);
                bool? br_ = context.Operators.In<CqlDateTime>(bb_, bq_, "day");
                bool? bs_ = context.Operators.And(ax_, br_);
                return bs_;
            }

            IEnumerable<MedicationAdministration> ac_ = context.Operators.Where<MedicationAdministration>(aa_, ab_);
            Encounter ad_(MedicationAdministration FactorXaMedication) => QualifyingEncounterICU;
            IEnumerable<Encounter> ae_ = context.Operators.Select<MedicationAdministration, Encounter>(ac_, ad_);
            return ae_;
        }

        IEnumerable<Encounter> c_ = context.Operators.SelectMany<Encounter, Encounter>(a_, b_);
        CqlValueSet e_ = this.General_or_Neuraxial_Anesthesia(context);
        IEnumerable<Procedure> f_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, e_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
        CqlValueSet g_ = this.Oral_Factor_Xa_Inhibitor_for_VTE_Prophylaxis_or_VTE_Treatment(context);
        IEnumerable<MedicationAdministration> h_ = context.Operators.Retrieve<MedicationAdministration>(new RetrieveParameters(default, g_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationadministration"));
        IEnumerable<MedicationAdministration> i_ = context.Operators.Retrieve<MedicationAdministration>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationadministration"));

        IEnumerable<MedicationAdministration> j_(MedicationAdministration MR) {
            IEnumerable<Medication> bt_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));

            bool? bu_(Medication M) {
                object by_ = context.Operators.LateBoundProperty<object>(M, "id.value");
                object bz_ = context.Operators.LateBoundProperty<object>(MR, "medication.reference.value");
                IEnumerable<string> ca_ = context.Operators.Split((string)bz_, "/");
                string cb_ = context.Operators.Last<string>(ca_);
                bool? cc_ = context.Operators.Equal(by_, cb_);
                CodeableConcept cd_ = M?.Code;
                CqlConcept ce_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, cd_);
                CqlValueSet cf_ = this.Oral_Factor_Xa_Inhibitor_for_VTE_Prophylaxis_or_VTE_Treatment(context);
                bool? cg_ = context.Operators.ConceptInValueSet(ce_, cf_);
                bool? ch_ = context.Operators.And(cc_, cg_);
                return ch_;
            }

            IEnumerable<Medication> bv_ = context.Operators.Where<Medication>(bt_, bu_);
            MedicationAdministration bw_(Medication M) => MR;
            IEnumerable<MedicationAdministration> bx_ = context.Operators.Select<Medication, MedicationAdministration>(bv_, bw_);
            return bx_;
        }

        IEnumerable<MedicationAdministration> k_ = context.Operators.SelectMany<MedicationAdministration, MedicationAdministration>(i_, j_);
        IEnumerable<MedicationAdministration> l_ = context.Operators.Union<MedicationAdministration>(h_, k_);
        IEnumerable<ValueTuple<Encounter, Procedure, MedicationAdministration>> m_ = context.Operators.CrossJoin<Encounter, Procedure, MedicationAdministration>(a_, f_, l_);

        (CqlTupleMetadata, Encounter QualifyingEncounterICU, Procedure AnesthesiaProcedure, MedicationAdministration FactorXaMedication)? n_(ValueTuple<Encounter, Procedure, MedicationAdministration> _valueTuple) {
            (CqlTupleMetadata, Encounter QualifyingEncounterICU, Procedure AnesthesiaProcedure, MedicationAdministration FactorXaMedication)? ci_ = (CqlTupleMetadata_IGcdIOTLGJfibgSLNOGSFRVB, _valueTuple.Item1, _valueTuple.Item2, _valueTuple.Item3);
            return ci_;
        }

        IEnumerable<(CqlTupleMetadata, Encounter QualifyingEncounterICU, Procedure AnesthesiaProcedure, MedicationAdministration FactorXaMedication)?> o_ = context.Operators.Select<ValueTuple<Encounter, Procedure, MedicationAdministration>, (CqlTupleMetadata, Encounter QualifyingEncounterICU, Procedure AnesthesiaProcedure, MedicationAdministration FactorXaMedication)?>(m_, n_);

        bool? p_((CqlTupleMetadata, Encounter QualifyingEncounterICU, Procedure AnesthesiaProcedure, MedicationAdministration FactorXaMedication)? tuple_elrfucfgncrbdgahdtkitiyzu) {
            Code<MedicationAdministration.MedicationAdministrationStatusCodes> cj_ = tuple_elrfucfgncrbdgahdtkitiyzu?.FactorXaMedication?.StatusElement;
            MedicationAdministration.MedicationAdministrationStatusCodes? ck_ = cj_?.Value;
            string cl_ = context.Operators.Convert<string>(ck_);
            bool? cm_ = context.Operators.Equal(cl_, "completed");
            Code<EventStatus> cn_ = tuple_elrfucfgncrbdgahdtkitiyzu?.AnesthesiaProcedure?.StatusElement;
            EventStatus? co_ = cn_?.Value;
            string cp_ = context.Operators.Convert<string>(co_);
            bool? cq_ = context.Operators.Equal(cp_, "completed");
            bool? cr_ = context.Operators.And(cm_, cq_);

            object cs_() {

                bool ed_() {
                    DataType eh_ = tuple_elrfucfgncrbdgahdtkitiyzu?.AnesthesiaProcedure?.Performed;
                    object ei_ = FHIRHelpers_4_4_000.Instance.ToValue(context, eh_);
                    bool ej_ = ei_ is CqlDateTime;
                    return ej_;
                }


                bool ee_() {
                    DataType ek_ = tuple_elrfucfgncrbdgahdtkitiyzu?.AnesthesiaProcedure?.Performed;
                    object el_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ek_);
                    bool em_ = el_ is CqlInterval<CqlDateTime>;
                    return em_;
                }


                bool ef_() {
                    DataType en_ = tuple_elrfucfgncrbdgahdtkitiyzu?.AnesthesiaProcedure?.Performed;
                    object eo_ = FHIRHelpers_4_4_000.Instance.ToValue(context, en_);
                    bool ep_ = eo_ is CqlQuantity;
                    return ep_;
                }


                bool eg_() {
                    DataType eq_ = tuple_elrfucfgncrbdgahdtkitiyzu?.AnesthesiaProcedure?.Performed;
                    object er_ = FHIRHelpers_4_4_000.Instance.ToValue(context, eq_);
                    bool es_ = er_ is CqlInterval<CqlQuantity>;
                    return es_;
                }

                if (ed_())
                {
                    DataType et_ = tuple_elrfucfgncrbdgahdtkitiyzu?.AnesthesiaProcedure?.Performed;
                    object eu_ = FHIRHelpers_4_4_000.Instance.ToValue(context, et_);
                    return (eu_ as CqlDateTime) as object;
                }
                else if (ee_())
                {
                    DataType ev_ = tuple_elrfucfgncrbdgahdtkitiyzu?.AnesthesiaProcedure?.Performed;
                    object ew_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ev_);
                    return (ew_ as CqlInterval<CqlDateTime>) as object;
                }
                else if (ef_())
                {
                    DataType ex_ = tuple_elrfucfgncrbdgahdtkitiyzu?.AnesthesiaProcedure?.Performed;
                    object ey_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ex_);
                    return (ey_ as CqlQuantity) as object;
                }
                else if (eg_())
                {
                    DataType ez_ = tuple_elrfucfgncrbdgahdtkitiyzu?.AnesthesiaProcedure?.Performed;
                    object fa_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ez_);
                    return (fa_ as CqlInterval<CqlQuantity>) as object;
                }
                else
                {
                    return null;
                };
            }

            CqlInterval<CqlDateTime> ct_ = QICoreCommon_4_0_000.Instance.toInterval(context, cs_());
            CqlDateTime cu_ = context.Operators.End(ct_);
            CqlDateTime cv_ = this.startOfFirstICU(context, tuple_elrfucfgncrbdgahdtkitiyzu?.QualifyingEncounterICU);
            CqlQuantity cw_ = context.Operators.Quantity(1m, "day");
            CqlDateTime cx_ = context.Operators.Add(cv_, cw_);
            bool? cy_ = context.Operators.SameAs(cu_, cx_, "day");
            bool? cz_ = context.Operators.And(cr_, cy_);
            DataType da_ = tuple_elrfucfgncrbdgahdtkitiyzu?.FactorXaMedication?.Effective;
            object db_ = FHIRHelpers_4_4_000.Instance.ToValue(context, da_);
            CqlInterval<CqlDateTime> dc_ = QICoreCommon_4_0_000.Instance.toInterval(context, db_);
            CqlDateTime dd_ = context.Operators.Start(dc_);

            object de_() {

                bool fb_() {
                    DataType ff_ = tuple_elrfucfgncrbdgahdtkitiyzu?.AnesthesiaProcedure?.Performed;
                    object fg_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ff_);
                    bool fh_ = fg_ is CqlDateTime;
                    return fh_;
                }


                bool fc_() {
                    DataType fi_ = tuple_elrfucfgncrbdgahdtkitiyzu?.AnesthesiaProcedure?.Performed;
                    object fj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fi_);
                    bool fk_ = fj_ is CqlInterval<CqlDateTime>;
                    return fk_;
                }


                bool fd_() {
                    DataType fl_ = tuple_elrfucfgncrbdgahdtkitiyzu?.AnesthesiaProcedure?.Performed;
                    object fm_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fl_);
                    bool fn_ = fm_ is CqlQuantity;
                    return fn_;
                }


                bool fe_() {
                    DataType fo_ = tuple_elrfucfgncrbdgahdtkitiyzu?.AnesthesiaProcedure?.Performed;
                    object fp_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fo_);
                    bool fq_ = fp_ is CqlInterval<CqlQuantity>;
                    return fq_;
                }

                if (fb_())
                {
                    DataType fr_ = tuple_elrfucfgncrbdgahdtkitiyzu?.AnesthesiaProcedure?.Performed;
                    object fs_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fr_);
                    return (fs_ as CqlDateTime) as object;
                }
                else if (fc_())
                {
                    DataType ft_ = tuple_elrfucfgncrbdgahdtkitiyzu?.AnesthesiaProcedure?.Performed;
                    object fu_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ft_);
                    return (fu_ as CqlInterval<CqlDateTime>) as object;
                }
                else if (fd_())
                {
                    DataType fv_ = tuple_elrfucfgncrbdgahdtkitiyzu?.AnesthesiaProcedure?.Performed;
                    object fw_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fv_);
                    return (fw_ as CqlQuantity) as object;
                }
                else if (fe_())
                {
                    DataType fx_ = tuple_elrfucfgncrbdgahdtkitiyzu?.AnesthesiaProcedure?.Performed;
                    object fy_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fx_);
                    return (fy_ as CqlInterval<CqlQuantity>) as object;
                }
                else
                {
                    return null;
                };
            }

            CqlInterval<CqlDateTime> df_ = QICoreCommon_4_0_000.Instance.toInterval(context, de_());
            CqlDateTime dg_ = context.Operators.End(df_);
            CqlInterval<CqlDate> dh_ = TJCOverall_8_25_000.Instance.calendarDayOfOrDayAfter(context, dg_);
            CqlDate di_ = dh_?.low;
            CqlDateTime dj_ = context.Operators.ConvertDateToDateTime(di_);

            object dk_() {

                bool fz_() {
                    DataType gd_ = tuple_elrfucfgncrbdgahdtkitiyzu?.AnesthesiaProcedure?.Performed;
                    object ge_ = FHIRHelpers_4_4_000.Instance.ToValue(context, gd_);
                    bool gf_ = ge_ is CqlDateTime;
                    return gf_;
                }


                bool ga_() {
                    DataType gg_ = tuple_elrfucfgncrbdgahdtkitiyzu?.AnesthesiaProcedure?.Performed;
                    object gh_ = FHIRHelpers_4_4_000.Instance.ToValue(context, gg_);
                    bool gi_ = gh_ is CqlInterval<CqlDateTime>;
                    return gi_;
                }


                bool gb_() {
                    DataType gj_ = tuple_elrfucfgncrbdgahdtkitiyzu?.AnesthesiaProcedure?.Performed;
                    object gk_ = FHIRHelpers_4_4_000.Instance.ToValue(context, gj_);
                    bool gl_ = gk_ is CqlQuantity;
                    return gl_;
                }


                bool gc_() {
                    DataType gm_ = tuple_elrfucfgncrbdgahdtkitiyzu?.AnesthesiaProcedure?.Performed;
                    object gn_ = FHIRHelpers_4_4_000.Instance.ToValue(context, gm_);
                    bool go_ = gn_ is CqlInterval<CqlQuantity>;
                    return go_;
                }

                if (fz_())
                {
                    DataType gp_ = tuple_elrfucfgncrbdgahdtkitiyzu?.AnesthesiaProcedure?.Performed;
                    object gq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, gp_);
                    return (gq_ as CqlDateTime) as object;
                }
                else if (ga_())
                {
                    DataType gr_ = tuple_elrfucfgncrbdgahdtkitiyzu?.AnesthesiaProcedure?.Performed;
                    object gs_ = FHIRHelpers_4_4_000.Instance.ToValue(context, gr_);
                    return (gs_ as CqlInterval<CqlDateTime>) as object;
                }
                else if (gb_())
                {
                    DataType gt_ = tuple_elrfucfgncrbdgahdtkitiyzu?.AnesthesiaProcedure?.Performed;
                    object gu_ = FHIRHelpers_4_4_000.Instance.ToValue(context, gt_);
                    return (gu_ as CqlQuantity) as object;
                }
                else if (gc_())
                {
                    DataType gv_ = tuple_elrfucfgncrbdgahdtkitiyzu?.AnesthesiaProcedure?.Performed;
                    object gw_ = FHIRHelpers_4_4_000.Instance.ToValue(context, gv_);
                    return (gw_ as CqlInterval<CqlQuantity>) as object;
                }
                else
                {
                    return null;
                };
            }

            CqlInterval<CqlDateTime> dl_ = QICoreCommon_4_0_000.Instance.toInterval(context, dk_());
            CqlDateTime dm_ = context.Operators.End(dl_);
            CqlInterval<CqlDate> dn_ = TJCOverall_8_25_000.Instance.calendarDayOfOrDayAfter(context, dm_);
            CqlDate do_ = dn_?.high;
            CqlDateTime dp_ = context.Operators.ConvertDateToDateTime(do_);

            object dq_() {

                bool gx_() {
                    DataType hb_ = tuple_elrfucfgncrbdgahdtkitiyzu?.AnesthesiaProcedure?.Performed;
                    object hc_ = FHIRHelpers_4_4_000.Instance.ToValue(context, hb_);
                    bool hd_ = hc_ is CqlDateTime;
                    return hd_;
                }


                bool gy_() {
                    DataType he_ = tuple_elrfucfgncrbdgahdtkitiyzu?.AnesthesiaProcedure?.Performed;
                    object hf_ = FHIRHelpers_4_4_000.Instance.ToValue(context, he_);
                    bool hg_ = hf_ is CqlInterval<CqlDateTime>;
                    return hg_;
                }


                bool gz_() {
                    DataType hh_ = tuple_elrfucfgncrbdgahdtkitiyzu?.AnesthesiaProcedure?.Performed;
                    object hi_ = FHIRHelpers_4_4_000.Instance.ToValue(context, hh_);
                    bool hj_ = hi_ is CqlQuantity;
                    return hj_;
                }


                bool ha_() {
                    DataType hk_ = tuple_elrfucfgncrbdgahdtkitiyzu?.AnesthesiaProcedure?.Performed;
                    object hl_ = FHIRHelpers_4_4_000.Instance.ToValue(context, hk_);
                    bool hm_ = hl_ is CqlInterval<CqlQuantity>;
                    return hm_;
                }

                if (gx_())
                {
                    DataType hn_ = tuple_elrfucfgncrbdgahdtkitiyzu?.AnesthesiaProcedure?.Performed;
                    object ho_ = FHIRHelpers_4_4_000.Instance.ToValue(context, hn_);
                    return (ho_ as CqlDateTime) as object;
                }
                else if (gy_())
                {
                    DataType hp_ = tuple_elrfucfgncrbdgahdtkitiyzu?.AnesthesiaProcedure?.Performed;
                    object hq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, hp_);
                    return (hq_ as CqlInterval<CqlDateTime>) as object;
                }
                else if (gz_())
                {
                    DataType hr_ = tuple_elrfucfgncrbdgahdtkitiyzu?.AnesthesiaProcedure?.Performed;
                    object hs_ = FHIRHelpers_4_4_000.Instance.ToValue(context, hr_);
                    return (hs_ as CqlQuantity) as object;
                }
                else if (ha_())
                {
                    DataType ht_ = tuple_elrfucfgncrbdgahdtkitiyzu?.AnesthesiaProcedure?.Performed;
                    object hu_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ht_);
                    return (hu_ as CqlInterval<CqlQuantity>) as object;
                }
                else
                {
                    return null;
                };
            }

            CqlInterval<CqlDateTime> dr_ = QICoreCommon_4_0_000.Instance.toInterval(context, dq_());
            CqlDateTime ds_ = context.Operators.End(dr_);
            CqlInterval<CqlDate> dt_ = TJCOverall_8_25_000.Instance.calendarDayOfOrDayAfter(context, ds_);
            bool? du_ = dt_?.lowClosed;

            object dv_() {

                bool hv_() {
                    DataType hz_ = tuple_elrfucfgncrbdgahdtkitiyzu?.AnesthesiaProcedure?.Performed;
                    object ia_ = FHIRHelpers_4_4_000.Instance.ToValue(context, hz_);
                    bool ib_ = ia_ is CqlDateTime;
                    return ib_;
                }


                bool hw_() {
                    DataType ic_ = tuple_elrfucfgncrbdgahdtkitiyzu?.AnesthesiaProcedure?.Performed;
                    object id_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ic_);
                    bool ie_ = id_ is CqlInterval<CqlDateTime>;
                    return ie_;
                }


                bool hx_() {
                    DataType if_ = tuple_elrfucfgncrbdgahdtkitiyzu?.AnesthesiaProcedure?.Performed;
                    object ig_ = FHIRHelpers_4_4_000.Instance.ToValue(context, if_);
                    bool ih_ = ig_ is CqlQuantity;
                    return ih_;
                }


                bool hy_() {
                    DataType ii_ = tuple_elrfucfgncrbdgahdtkitiyzu?.AnesthesiaProcedure?.Performed;
                    object ij_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ii_);
                    bool ik_ = ij_ is CqlInterval<CqlQuantity>;
                    return ik_;
                }

                if (hv_())
                {
                    DataType il_ = tuple_elrfucfgncrbdgahdtkitiyzu?.AnesthesiaProcedure?.Performed;
                    object im_ = FHIRHelpers_4_4_000.Instance.ToValue(context, il_);
                    return (im_ as CqlDateTime) as object;
                }
                else if (hw_())
                {
                    DataType in_ = tuple_elrfucfgncrbdgahdtkitiyzu?.AnesthesiaProcedure?.Performed;
                    object io_ = FHIRHelpers_4_4_000.Instance.ToValue(context, in_);
                    return (io_ as CqlInterval<CqlDateTime>) as object;
                }
                else if (hx_())
                {
                    DataType ip_ = tuple_elrfucfgncrbdgahdtkitiyzu?.AnesthesiaProcedure?.Performed;
                    object iq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ip_);
                    return (iq_ as CqlQuantity) as object;
                }
                else if (hy_())
                {
                    DataType ir_ = tuple_elrfucfgncrbdgahdtkitiyzu?.AnesthesiaProcedure?.Performed;
                    object is_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ir_);
                    return (is_ as CqlInterval<CqlQuantity>) as object;
                }
                else
                {
                    return null;
                };
            }

            CqlInterval<CqlDateTime> dw_ = QICoreCommon_4_0_000.Instance.toInterval(context, dv_());
            CqlDateTime dx_ = context.Operators.End(dw_);
            CqlInterval<CqlDate> dy_ = TJCOverall_8_25_000.Instance.calendarDayOfOrDayAfter(context, dx_);
            bool? dz_ = dy_?.highClosed;
            CqlInterval<CqlDateTime> ea_ = context.Operators.Interval(dj_, dp_, du_, dz_);
            bool? eb_ = context.Operators.In<CqlDateTime>(dd_, ea_, "day");
            bool? ec_ = context.Operators.And(cz_, eb_);
            return ec_;
        }

        IEnumerable<(CqlTupleMetadata, Encounter QualifyingEncounterICU, Procedure AnesthesiaProcedure, MedicationAdministration FactorXaMedication)?> q_ = context.Operators.Where<(CqlTupleMetadata, Encounter QualifyingEncounterICU, Procedure AnesthesiaProcedure, MedicationAdministration FactorXaMedication)?>(o_, p_);
        Encounter r_((CqlTupleMetadata, Encounter QualifyingEncounterICU, Procedure AnesthesiaProcedure, MedicationAdministration FactorXaMedication)? tuple_elrfucfgncrbdgahdtkitiyzu) => tuple_elrfucfgncrbdgahdtkitiyzu?.QualifyingEncounterICU;
        IEnumerable<Encounter> s_ = context.Operators.Select<(CqlTupleMetadata, Encounter QualifyingEncounterICU, Procedure AnesthesiaProcedure, MedicationAdministration FactorXaMedication)?, Encounter>(q_, r_);
        IEnumerable<Encounter> t_ = context.Operators.Distinct<Encounter>(s_);
        IEnumerable<Encounter> u_ = context.Operators.Union<Encounter>(c_, t_);
        return u_;
    }


    [CqlExpressionDefinition("Encounter With Prior Or Present Diagnosis Of Atrial Fibrillation Or Prior Diagnosis Of VTE")]
    public IEnumerable<Encounter> Encounter_With_Prior_Or_Present_Diagnosis_Of_Atrial_Fibrillation_Or_Prior_Diagnosis_Of_VTE(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Encounter_With_Prior_Or_Present_Diagnosis_Of_Atrial_Fibrillation_Or_Prior_Diagnosis_Of_VTE, Encounter_With_Prior_Or_Present_Diagnosis_Of_Atrial_Fibrillation_Or_Prior_Diagnosis_Of_VTE_Compute);

    private const long _cacheIndex_Encounter_With_Prior_Or_Present_Diagnosis_Of_Atrial_Fibrillation_Or_Prior_Diagnosis_Of_VTE = 955367419207387258L;

    private IEnumerable<Encounter> Encounter_With_Prior_Or_Present_Diagnosis_Of_Atrial_Fibrillation_Or_Prior_Diagnosis_Of_VTE_Compute(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Encounter_With_ICU_Location(context);

        IEnumerable<Encounter> b_(Encounter QualifyingEncounterICU) {
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
                Period al_ = QualifyingEncounterICU?.Period;
                CqlInterval<CqlDateTime> am_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, al_);
                CqlDateTime an_ = context.Operators.End(am_);
                bool? ao_ = context.Operators.SameOrBefore(ak_, an_, (string)default);
                bool? ap_ = context.Operators.And(ag_, ao_);
                bool? aq_ = context.Operators.Implies(t_, ap_);
                return aq_;
            }

            IEnumerable<Condition> o_ = context.Operators.Where<Condition>(m_, n_);
            Encounter p_(Condition AtrialFibrillation) => QualifyingEncounterICU;
            IEnumerable<Encounter> q_ = context.Operators.Select<Condition, Encounter>(o_, p_);
            return q_;
        }

        IEnumerable<Encounter> c_ = context.Operators.SelectMany<Encounter, Encounter>(a_, b_);

        bool? e_(Encounter QualifyingEncounterICU) {
            CqlValueSet ar_ = this.Atrial_Fibrillation_or_Flutter(context);
            bool? as_ = VTE_8_18_000.Instance.hasEncDiagnosisOf(context, QualifyingEncounterICU, ar_);
            return as_;
        }

        IEnumerable<Encounter> f_ = context.Operators.Where<Encounter>(a_, e_);
        IEnumerable<Encounter> g_ = context.Operators.Union<Encounter>(c_, f_);

        IEnumerable<Encounter> i_(Encounter QualifyingEncounterICU) {
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
                        Period cp_ = QualifyingEncounterICU?.Period;
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
                        Period cs_ = QualifyingEncounterICU?.Period;
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
            Encounter ax_(Condition VTEDiagnosis) => QualifyingEncounterICU;
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

    private const long _cacheIndex_Encounter_With_Prior_Or_Present_Procedure_Of_Hip_Or_Knee_Replacement_Surgery = 7135932585124611427L;

    private IEnumerable<Encounter> Encounter_With_Prior_Or_Present_Procedure_Of_Hip_Or_Knee_Replacement_Surgery_Compute(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Encounter_With_ICU_Location(context);

        IEnumerable<Encounter> b_(Encounter QualifyingEncounterICU) {
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
                Period t_ = QualifyingEncounterICU?.Period;
                CqlInterval<CqlDateTime> u_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, t_);
                CqlDateTime v_ = context.Operators.End(u_);
                bool? w_ = context.Operators.SameOrBefore(s_, v_, (string)default);
                bool? x_ = context.Operators.And(p_, w_);
                return x_;
            }

            IEnumerable<Procedure> j_ = context.Operators.Where<Procedure>(h_, i_);
            Encounter k_(Procedure HipKneeProcedure) => QualifyingEncounterICU;
            IEnumerable<Encounter> l_ = context.Operators.Select<Procedure, Encounter>(j_, k_);
            return l_;
        }

        IEnumerable<Encounter> c_ = context.Operators.SelectMany<Encounter, Encounter>(a_, b_);
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


    [CqlExpressionDefinition("Low Risk For VTE Or Anticoagulant Administered From Day Of Start Of Hospitalization To Day After First ICU Stay")]
    public IEnumerable<Encounter> Low_Risk_For_VTE_Or_Anticoagulant_Administered_From_Day_Of_Start_Of_Hospitalization_To_Day_After_First_ICU_Stay(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Low_Risk_For_VTE_Or_Anticoagulant_Administered_From_Day_Of_Start_Of_Hospitalization_To_Day_After_First_ICU_Stay, Low_Risk_For_VTE_Or_Anticoagulant_Administered_From_Day_Of_Start_Of_Hospitalization_To_Day_After_First_ICU_Stay_Compute);

    private const long _cacheIndex_Low_Risk_For_VTE_Or_Anticoagulant_Administered_From_Day_Of_Start_Of_Hospitalization_To_Day_After_First_ICU_Stay = -524851788773972608L;

    private IEnumerable<Encounter> Low_Risk_For_VTE_Or_Anticoagulant_Administered_From_Day_Of_Start_Of_Hospitalization_To_Day_After_First_ICU_Stay_Compute(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Encounter_With_ICU_Location(context);

        IEnumerable<Encounter> b_(Encounter QualifyingEncounterICU) {
            IEnumerable<(CqlTupleMetadata, string id, CqlDateTime LowRiskDatetime)?> d_ = this.Low_Risk_Indicator_For_VTE(context);

            bool? e_((CqlTupleMetadata, string id, CqlDateTime LowRiskDatetime)? LowRiskForVTE) {
                CqlDateTime i_ = LowRiskForVTE?.LowRiskDatetime;
                CqlInterval<CqlDate> j_ = this.fromDayOfStartOfHospitalizationToDayAfterFirstICU(context, QualifyingEncounterICU);
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
            Encounter g_((CqlTupleMetadata, string id, CqlDateTime LowRiskDatetime)? LowRiskForVTE) => QualifyingEncounterICU;
            IEnumerable<Encounter> h_ = context.Operators.Select<(CqlTupleMetadata, string id, CqlDateTime LowRiskDatetime)?, Encounter>(f_, g_);
            return h_;
        }

        IEnumerable<Encounter> c_ = context.Operators.SelectMany<Encounter, Encounter>(a_, b_);
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
            (CqlTupleMetadata, Encounter QualifyingEncounterICU, Procedure AnesthesiaProcedure, (CqlTupleMetadata, string id, CqlDateTime LowRiskDatetime)? LowRiskForVTE)? m_ = (CqlTupleMetadata_FFALfPBajSdbcUiIgEjZKRHOP, _valueTuple.Item1, _valueTuple.Item2, _valueTuple.Item3);
            return m_;
        }

        IEnumerable<(CqlTupleMetadata, Encounter QualifyingEncounterICU, Procedure AnesthesiaProcedure, (CqlTupleMetadata, string id, CqlDateTime LowRiskDatetime)? LowRiskForVTE)?> g_ = context.Operators.Select<ValueTuple<Encounter, Procedure, (CqlTupleMetadata, string id, CqlDateTime LowRiskDatetime)?>, (CqlTupleMetadata, Encounter QualifyingEncounterICU, Procedure AnesthesiaProcedure, (CqlTupleMetadata, string id, CqlDateTime LowRiskDatetime)? LowRiskForVTE)?>(e_, f_);

        bool? h_((CqlTupleMetadata, Encounter QualifyingEncounterICU, Procedure AnesthesiaProcedure, (CqlTupleMetadata, string id, CqlDateTime LowRiskDatetime)? LowRiskForVTE)? tuple_cchfidtccovheihiyjcdnfkbm) {
            Code<EventStatus> n_ = tuple_cchfidtccovheihiyjcdnfkbm?.AnesthesiaProcedure?.StatusElement;
            EventStatus? o_ = n_?.Value;
            string p_ = context.Operators.Convert<string>(o_);
            bool? q_ = context.Operators.Equal(p_, "completed");

            object r_() {

                bool az_() {
                    DataType bd_ = tuple_cchfidtccovheihiyjcdnfkbm?.AnesthesiaProcedure?.Performed;
                    object be_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bd_);
                    bool bf_ = be_ is CqlDateTime;
                    return bf_;
                }


                bool ba_() {
                    DataType bg_ = tuple_cchfidtccovheihiyjcdnfkbm?.AnesthesiaProcedure?.Performed;
                    object bh_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bg_);
                    bool bi_ = bh_ is CqlInterval<CqlDateTime>;
                    return bi_;
                }


                bool bb_() {
                    DataType bj_ = tuple_cchfidtccovheihiyjcdnfkbm?.AnesthesiaProcedure?.Performed;
                    object bk_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bj_);
                    bool bl_ = bk_ is CqlQuantity;
                    return bl_;
                }


                bool bc_() {
                    DataType bm_ = tuple_cchfidtccovheihiyjcdnfkbm?.AnesthesiaProcedure?.Performed;
                    object bn_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bm_);
                    bool bo_ = bn_ is CqlInterval<CqlQuantity>;
                    return bo_;
                }

                if (az_())
                {
                    DataType bp_ = tuple_cchfidtccovheihiyjcdnfkbm?.AnesthesiaProcedure?.Performed;
                    object bq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bp_);
                    return (bq_ as CqlDateTime) as object;
                }
                else if (ba_())
                {
                    DataType br_ = tuple_cchfidtccovheihiyjcdnfkbm?.AnesthesiaProcedure?.Performed;
                    object bs_ = FHIRHelpers_4_4_000.Instance.ToValue(context, br_);
                    return (bs_ as CqlInterval<CqlDateTime>) as object;
                }
                else if (bb_())
                {
                    DataType bt_ = tuple_cchfidtccovheihiyjcdnfkbm?.AnesthesiaProcedure?.Performed;
                    object bu_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bt_);
                    return (bu_ as CqlQuantity) as object;
                }
                else if (bc_())
                {
                    DataType bv_ = tuple_cchfidtccovheihiyjcdnfkbm?.AnesthesiaProcedure?.Performed;
                    object bw_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bv_);
                    return (bw_ as CqlInterval<CqlQuantity>) as object;
                }
                else
                {
                    return null;
                };
            }

            CqlInterval<CqlDateTime> s_ = QICoreCommon_4_0_000.Instance.toInterval(context, r_());
            CqlDateTime t_ = context.Operators.End(s_);
            CqlDateTime u_ = this.startOfFirstICU(context, tuple_cchfidtccovheihiyjcdnfkbm?.QualifyingEncounterICU);
            CqlQuantity v_ = context.Operators.Quantity(1m, "day");
            CqlDateTime w_ = context.Operators.Add(u_, v_);
            bool? x_ = context.Operators.SameAs(t_, w_, "day");
            bool? y_ = context.Operators.And(q_, x_);
            CqlDateTime z_ = tuple_cchfidtccovheihiyjcdnfkbm?.LowRiskForVTE?.LowRiskDatetime;

            object aa_() {

                bool bx_() {
                    DataType cb_ = tuple_cchfidtccovheihiyjcdnfkbm?.AnesthesiaProcedure?.Performed;
                    object cc_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cb_);
                    bool cd_ = cc_ is CqlDateTime;
                    return cd_;
                }


                bool by_() {
                    DataType ce_ = tuple_cchfidtccovheihiyjcdnfkbm?.AnesthesiaProcedure?.Performed;
                    object cf_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ce_);
                    bool cg_ = cf_ is CqlInterval<CqlDateTime>;
                    return cg_;
                }


                bool bz_() {
                    DataType ch_ = tuple_cchfidtccovheihiyjcdnfkbm?.AnesthesiaProcedure?.Performed;
                    object ci_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ch_);
                    bool cj_ = ci_ is CqlQuantity;
                    return cj_;
                }


                bool ca_() {
                    DataType ck_ = tuple_cchfidtccovheihiyjcdnfkbm?.AnesthesiaProcedure?.Performed;
                    object cl_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ck_);
                    bool cm_ = cl_ is CqlInterval<CqlQuantity>;
                    return cm_;
                }

                if (bx_())
                {
                    DataType cn_ = tuple_cchfidtccovheihiyjcdnfkbm?.AnesthesiaProcedure?.Performed;
                    object co_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cn_);
                    return (co_ as CqlDateTime) as object;
                }
                else if (by_())
                {
                    DataType cp_ = tuple_cchfidtccovheihiyjcdnfkbm?.AnesthesiaProcedure?.Performed;
                    object cq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cp_);
                    return (cq_ as CqlInterval<CqlDateTime>) as object;
                }
                else if (bz_())
                {
                    DataType cr_ = tuple_cchfidtccovheihiyjcdnfkbm?.AnesthesiaProcedure?.Performed;
                    object cs_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cr_);
                    return (cs_ as CqlQuantity) as object;
                }
                else if (ca_())
                {
                    DataType ct_ = tuple_cchfidtccovheihiyjcdnfkbm?.AnesthesiaProcedure?.Performed;
                    object cu_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ct_);
                    return (cu_ as CqlInterval<CqlQuantity>) as object;
                }
                else
                {
                    return null;
                };
            }

            CqlInterval<CqlDateTime> ab_ = QICoreCommon_4_0_000.Instance.toInterval(context, aa_());
            CqlDateTime ac_ = context.Operators.End(ab_);
            CqlInterval<CqlDate> ad_ = TJCOverall_8_25_000.Instance.calendarDayOfOrDayAfter(context, ac_);
            CqlDate ae_ = ad_?.low;
            CqlDateTime af_ = context.Operators.ConvertDateToDateTime(ae_);

            object ag_() {

                bool cv_() {
                    DataType cz_ = tuple_cchfidtccovheihiyjcdnfkbm?.AnesthesiaProcedure?.Performed;
                    object da_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cz_);
                    bool db_ = da_ is CqlDateTime;
                    return db_;
                }


                bool cw_() {
                    DataType dc_ = tuple_cchfidtccovheihiyjcdnfkbm?.AnesthesiaProcedure?.Performed;
                    object dd_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dc_);
                    bool de_ = dd_ is CqlInterval<CqlDateTime>;
                    return de_;
                }


                bool cx_() {
                    DataType df_ = tuple_cchfidtccovheihiyjcdnfkbm?.AnesthesiaProcedure?.Performed;
                    object dg_ = FHIRHelpers_4_4_000.Instance.ToValue(context, df_);
                    bool dh_ = dg_ is CqlQuantity;
                    return dh_;
                }


                bool cy_() {
                    DataType di_ = tuple_cchfidtccovheihiyjcdnfkbm?.AnesthesiaProcedure?.Performed;
                    object dj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, di_);
                    bool dk_ = dj_ is CqlInterval<CqlQuantity>;
                    return dk_;
                }

                if (cv_())
                {
                    DataType dl_ = tuple_cchfidtccovheihiyjcdnfkbm?.AnesthesiaProcedure?.Performed;
                    object dm_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dl_);
                    return (dm_ as CqlDateTime) as object;
                }
                else if (cw_())
                {
                    DataType dn_ = tuple_cchfidtccovheihiyjcdnfkbm?.AnesthesiaProcedure?.Performed;
                    object do_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dn_);
                    return (do_ as CqlInterval<CqlDateTime>) as object;
                }
                else if (cx_())
                {
                    DataType dp_ = tuple_cchfidtccovheihiyjcdnfkbm?.AnesthesiaProcedure?.Performed;
                    object dq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dp_);
                    return (dq_ as CqlQuantity) as object;
                }
                else if (cy_())
                {
                    DataType dr_ = tuple_cchfidtccovheihiyjcdnfkbm?.AnesthesiaProcedure?.Performed;
                    object ds_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dr_);
                    return (ds_ as CqlInterval<CqlQuantity>) as object;
                }
                else
                {
                    return null;
                };
            }

            CqlInterval<CqlDateTime> ah_ = QICoreCommon_4_0_000.Instance.toInterval(context, ag_());
            CqlDateTime ai_ = context.Operators.End(ah_);
            CqlInterval<CqlDate> aj_ = TJCOverall_8_25_000.Instance.calendarDayOfOrDayAfter(context, ai_);
            CqlDate ak_ = aj_?.high;
            CqlDateTime al_ = context.Operators.ConvertDateToDateTime(ak_);

            object am_() {

                bool dt_() {
                    DataType dx_ = tuple_cchfidtccovheihiyjcdnfkbm?.AnesthesiaProcedure?.Performed;
                    object dy_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dx_);
                    bool dz_ = dy_ is CqlDateTime;
                    return dz_;
                }


                bool du_() {
                    DataType ea_ = tuple_cchfidtccovheihiyjcdnfkbm?.AnesthesiaProcedure?.Performed;
                    object eb_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ea_);
                    bool ec_ = eb_ is CqlInterval<CqlDateTime>;
                    return ec_;
                }


                bool dv_() {
                    DataType ed_ = tuple_cchfidtccovheihiyjcdnfkbm?.AnesthesiaProcedure?.Performed;
                    object ee_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ed_);
                    bool ef_ = ee_ is CqlQuantity;
                    return ef_;
                }


                bool dw_() {
                    DataType eg_ = tuple_cchfidtccovheihiyjcdnfkbm?.AnesthesiaProcedure?.Performed;
                    object eh_ = FHIRHelpers_4_4_000.Instance.ToValue(context, eg_);
                    bool ei_ = eh_ is CqlInterval<CqlQuantity>;
                    return ei_;
                }

                if (dt_())
                {
                    DataType ej_ = tuple_cchfidtccovheihiyjcdnfkbm?.AnesthesiaProcedure?.Performed;
                    object ek_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ej_);
                    return (ek_ as CqlDateTime) as object;
                }
                else if (du_())
                {
                    DataType el_ = tuple_cchfidtccovheihiyjcdnfkbm?.AnesthesiaProcedure?.Performed;
                    object em_ = FHIRHelpers_4_4_000.Instance.ToValue(context, el_);
                    return (em_ as CqlInterval<CqlDateTime>) as object;
                }
                else if (dv_())
                {
                    DataType en_ = tuple_cchfidtccovheihiyjcdnfkbm?.AnesthesiaProcedure?.Performed;
                    object eo_ = FHIRHelpers_4_4_000.Instance.ToValue(context, en_);
                    return (eo_ as CqlQuantity) as object;
                }
                else if (dw_())
                {
                    DataType ep_ = tuple_cchfidtccovheihiyjcdnfkbm?.AnesthesiaProcedure?.Performed;
                    object eq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ep_);
                    return (eq_ as CqlInterval<CqlQuantity>) as object;
                }
                else
                {
                    return null;
                };
            }

            CqlInterval<CqlDateTime> an_ = QICoreCommon_4_0_000.Instance.toInterval(context, am_());
            CqlDateTime ao_ = context.Operators.End(an_);
            CqlInterval<CqlDate> ap_ = TJCOverall_8_25_000.Instance.calendarDayOfOrDayAfter(context, ao_);
            bool? aq_ = ap_?.lowClosed;

            object ar_() {

                bool er_() {
                    DataType ev_ = tuple_cchfidtccovheihiyjcdnfkbm?.AnesthesiaProcedure?.Performed;
                    object ew_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ev_);
                    bool ex_ = ew_ is CqlDateTime;
                    return ex_;
                }


                bool es_() {
                    DataType ey_ = tuple_cchfidtccovheihiyjcdnfkbm?.AnesthesiaProcedure?.Performed;
                    object ez_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ey_);
                    bool fa_ = ez_ is CqlInterval<CqlDateTime>;
                    return fa_;
                }


                bool et_() {
                    DataType fb_ = tuple_cchfidtccovheihiyjcdnfkbm?.AnesthesiaProcedure?.Performed;
                    object fc_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fb_);
                    bool fd_ = fc_ is CqlQuantity;
                    return fd_;
                }


                bool eu_() {
                    DataType fe_ = tuple_cchfidtccovheihiyjcdnfkbm?.AnesthesiaProcedure?.Performed;
                    object ff_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fe_);
                    bool fg_ = ff_ is CqlInterval<CqlQuantity>;
                    return fg_;
                }

                if (er_())
                {
                    DataType fh_ = tuple_cchfidtccovheihiyjcdnfkbm?.AnesthesiaProcedure?.Performed;
                    object fi_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fh_);
                    return (fi_ as CqlDateTime) as object;
                }
                else if (es_())
                {
                    DataType fj_ = tuple_cchfidtccovheihiyjcdnfkbm?.AnesthesiaProcedure?.Performed;
                    object fk_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fj_);
                    return (fk_ as CqlInterval<CqlDateTime>) as object;
                }
                else if (et_())
                {
                    DataType fl_ = tuple_cchfidtccovheihiyjcdnfkbm?.AnesthesiaProcedure?.Performed;
                    object fm_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fl_);
                    return (fm_ as CqlQuantity) as object;
                }
                else if (eu_())
                {
                    DataType fn_ = tuple_cchfidtccovheihiyjcdnfkbm?.AnesthesiaProcedure?.Performed;
                    object fo_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fn_);
                    return (fo_ as CqlInterval<CqlQuantity>) as object;
                }
                else
                {
                    return null;
                };
            }

            CqlInterval<CqlDateTime> as_ = QICoreCommon_4_0_000.Instance.toInterval(context, ar_());
            CqlDateTime at_ = context.Operators.End(as_);
            CqlInterval<CqlDate> au_ = TJCOverall_8_25_000.Instance.calendarDayOfOrDayAfter(context, at_);
            bool? av_ = au_?.highClosed;
            CqlInterval<CqlDateTime> aw_ = context.Operators.Interval(af_, al_, aq_, av_);
            bool? ax_ = context.Operators.In<CqlDateTime>(z_, aw_, "day");
            bool? ay_ = context.Operators.And(y_, ax_);
            return ay_;
        }

        IEnumerable<(CqlTupleMetadata, Encounter QualifyingEncounterICU, Procedure AnesthesiaProcedure, (CqlTupleMetadata, string id, CqlDateTime LowRiskDatetime)? LowRiskForVTE)?> i_ = context.Operators.Where<(CqlTupleMetadata, Encounter QualifyingEncounterICU, Procedure AnesthesiaProcedure, (CqlTupleMetadata, string id, CqlDateTime LowRiskDatetime)? LowRiskForVTE)?>(g_, h_);
        Encounter j_((CqlTupleMetadata, Encounter QualifyingEncounterICU, Procedure AnesthesiaProcedure, (CqlTupleMetadata, string id, CqlDateTime LowRiskDatetime)? LowRiskForVTE)? tuple_cchfidtccovheihiyjcdnfkbm) => tuple_cchfidtccovheihiyjcdnfkbm?.QualifyingEncounterICU;
        IEnumerable<Encounter> k_ = context.Operators.Select<(CqlTupleMetadata, Encounter QualifyingEncounterICU, Procedure AnesthesiaProcedure, (CqlTupleMetadata, string id, CqlDateTime LowRiskDatetime)? LowRiskForVTE)?, Encounter>(i_, j_);
        IEnumerable<Encounter> l_ = context.Operators.Distinct<Encounter>(k_);
        return l_;
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


    [CqlExpressionDefinition("No VTE Prophylaxis Medication Due To Medical Reason From Day Of Start Of Hospitalization To Day After First ICU Stay")]
    public IEnumerable<Encounter> No_VTE_Prophylaxis_Medication_Due_To_Medical_Reason_From_Day_Of_Start_Of_Hospitalization_To_Day_After_First_ICU_Stay(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_No_VTE_Prophylaxis_Medication_Due_To_Medical_Reason_From_Day_Of_Start_Of_Hospitalization_To_Day_After_First_ICU_Stay, No_VTE_Prophylaxis_Medication_Due_To_Medical_Reason_From_Day_Of_Start_Of_Hospitalization_To_Day_After_First_ICU_Stay_Compute);

    private const long _cacheIndex_No_VTE_Prophylaxis_Medication_Due_To_Medical_Reason_From_Day_Of_Start_Of_Hospitalization_To_Day_After_First_ICU_Stay = 5449834474205910518L;

    private IEnumerable<Encounter> No_VTE_Prophylaxis_Medication_Due_To_Medical_Reason_From_Day_Of_Start_Of_Hospitalization_To_Day_After_First_ICU_Stay_Compute(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Encounter_With_ICU_Location(context);

        IEnumerable<Encounter> b_(Encounter QualifyingEncounterICU) {
            IEnumerable<(CqlTupleMetadata, string id, IEnumerable<CqlConcept> medicationStatusReason, CqlDateTime authoredOn)?> d_ = this.No_VTE_Prophylaxis_Medication_Administered_Or_Ordered(context);

            bool? e_((CqlTupleMetadata, string id, IEnumerable<CqlConcept> medicationStatusReason, CqlDateTime authoredOn)? NoVTEMedication) {
                IEnumerable<CqlConcept> i_ = NoVTEMedication?.medicationStatusReason;
                CqlValueSet j_ = this.Medical_Reason_For_Not_Providing_Treatment(context);
                bool? k_ = context.Operators.ConceptsInValueSet(i_, j_);
                CqlDateTime l_ = NoVTEMedication?.authoredOn;
                CqlInterval<CqlDate> m_ = this.fromDayOfStartOfHospitalizationToDayAfterFirstICU(context, QualifyingEncounterICU);
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
            Encounter g_((CqlTupleMetadata, string id, IEnumerable<CqlConcept> medicationStatusReason, CqlDateTime authoredOn)? NoVTEMedication) => QualifyingEncounterICU;
            IEnumerable<Encounter> h_ = context.Operators.Select<(CqlTupleMetadata, string id, IEnumerable<CqlConcept> medicationStatusReason, CqlDateTime authoredOn)?, Encounter>(f_, g_);
            return h_;
        }

        IEnumerable<Encounter> c_ = context.Operators.SelectMany<Encounter, Encounter>(a_, b_);
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


    [CqlExpressionDefinition("No Mechanical VTE Prophylaxis Due To Medical Reason From Day Of Start Of Hospitalization To Day After First ICU Stay")]
    public IEnumerable<Encounter> No_Mechanical_VTE_Prophylaxis_Due_To_Medical_Reason_From_Day_Of_Start_Of_Hospitalization_To_Day_After_First_ICU_Stay(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_No_Mechanical_VTE_Prophylaxis_Due_To_Medical_Reason_From_Day_Of_Start_Of_Hospitalization_To_Day_After_First_ICU_Stay, No_Mechanical_VTE_Prophylaxis_Due_To_Medical_Reason_From_Day_Of_Start_Of_Hospitalization_To_Day_After_First_ICU_Stay_Compute);

    private const long _cacheIndex_No_Mechanical_VTE_Prophylaxis_Due_To_Medical_Reason_From_Day_Of_Start_Of_Hospitalization_To_Day_After_First_ICU_Stay = -985782402085122985L;

    private IEnumerable<Encounter> No_Mechanical_VTE_Prophylaxis_Due_To_Medical_Reason_From_Day_Of_Start_Of_Hospitalization_To_Day_After_First_ICU_Stay_Compute(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Encounter_With_ICU_Location(context);

        IEnumerable<Encounter> b_(Encounter QualifyingEncounterICU) {
            IEnumerable<(CqlTupleMetadata, string id, CqlConcept requestStatusReason, CqlDateTime authoredOn)?> d_ = this.No_Mechanical_VTE_Prophylaxis_Performed_Or_Ordered(context);

            bool? e_((CqlTupleMetadata, string id, CqlConcept requestStatusReason, CqlDateTime authoredOn)? NoVTEDevice) {
                CqlConcept i_ = NoVTEDevice?.requestStatusReason;
                CqlValueSet j_ = this.Medical_Reason_For_Not_Providing_Treatment(context);
                bool? k_ = context.Operators.ConceptInValueSet(i_, j_);
                CqlDateTime l_ = NoVTEDevice?.authoredOn;
                CqlInterval<CqlDate> m_ = this.fromDayOfStartOfHospitalizationToDayAfterFirstICU(context, QualifyingEncounterICU);
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
            Encounter g_((CqlTupleMetadata, string id, CqlConcept requestStatusReason, CqlDateTime authoredOn)? NoVTEDevice) => QualifyingEncounterICU;
            IEnumerable<Encounter> h_ = context.Operators.Select<(CqlTupleMetadata, string id, CqlConcept requestStatusReason, CqlDateTime authoredOn)?, Encounter>(f_, g_);
            return h_;
        }

        IEnumerable<Encounter> c_ = context.Operators.SelectMany<Encounter, Encounter>(a_, b_);
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
            (CqlTupleMetadata, Encounter QualifyingEncounterICU, Procedure AnesthesiaProcedure, (CqlTupleMetadata, string id, IEnumerable<CqlConcept> medicationStatusReason, CqlDateTime authoredOn)? NoVTEMedication)? m_ = (CqlTupleMetadata_HLCXTKCfUejcHSahcUNeWcYFC, _valueTuple.Item1, _valueTuple.Item2, _valueTuple.Item3);
            return m_;
        }

        IEnumerable<(CqlTupleMetadata, Encounter QualifyingEncounterICU, Procedure AnesthesiaProcedure, (CqlTupleMetadata, string id, IEnumerable<CqlConcept> medicationStatusReason, CqlDateTime authoredOn)? NoVTEMedication)?> g_ = context.Operators.Select<ValueTuple<Encounter, Procedure, (CqlTupleMetadata, string id, IEnumerable<CqlConcept> medicationStatusReason, CqlDateTime authoredOn)?>, (CqlTupleMetadata, Encounter QualifyingEncounterICU, Procedure AnesthesiaProcedure, (CqlTupleMetadata, string id, IEnumerable<CqlConcept> medicationStatusReason, CqlDateTime authoredOn)? NoVTEMedication)?>(e_, f_);

        bool? h_((CqlTupleMetadata, Encounter QualifyingEncounterICU, Procedure AnesthesiaProcedure, (CqlTupleMetadata, string id, IEnumerable<CqlConcept> medicationStatusReason, CqlDateTime authoredOn)? NoVTEMedication)? tuple_fpgtpszgoyfdaobujrgcsedde) {
            IEnumerable<CqlConcept> n_ = tuple_fpgtpszgoyfdaobujrgcsedde?.NoVTEMedication?.medicationStatusReason;
            CqlValueSet o_ = this.Medical_Reason_For_Not_Providing_Treatment(context);
            bool? p_ = context.Operators.ConceptsInValueSet(n_, o_);
            Code<EventStatus> q_ = tuple_fpgtpszgoyfdaobujrgcsedde?.AnesthesiaProcedure?.StatusElement;
            EventStatus? r_ = q_?.Value;
            string s_ = context.Operators.Convert<string>(r_);
            bool? t_ = context.Operators.Equal(s_, "completed");
            bool? u_ = context.Operators.And(p_, t_);

            object v_() {

                bool bd_() {
                    DataType bh_ = tuple_fpgtpszgoyfdaobujrgcsedde?.AnesthesiaProcedure?.Performed;
                    object bi_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bh_);
                    bool bj_ = bi_ is CqlDateTime;
                    return bj_;
                }


                bool be_() {
                    DataType bk_ = tuple_fpgtpszgoyfdaobujrgcsedde?.AnesthesiaProcedure?.Performed;
                    object bl_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bk_);
                    bool bm_ = bl_ is CqlInterval<CqlDateTime>;
                    return bm_;
                }


                bool bf_() {
                    DataType bn_ = tuple_fpgtpszgoyfdaobujrgcsedde?.AnesthesiaProcedure?.Performed;
                    object bo_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bn_);
                    bool bp_ = bo_ is CqlQuantity;
                    return bp_;
                }


                bool bg_() {
                    DataType bq_ = tuple_fpgtpszgoyfdaobujrgcsedde?.AnesthesiaProcedure?.Performed;
                    object br_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bq_);
                    bool bs_ = br_ is CqlInterval<CqlQuantity>;
                    return bs_;
                }

                if (bd_())
                {
                    DataType bt_ = tuple_fpgtpszgoyfdaobujrgcsedde?.AnesthesiaProcedure?.Performed;
                    object bu_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bt_);
                    return (bu_ as CqlDateTime) as object;
                }
                else if (be_())
                {
                    DataType bv_ = tuple_fpgtpszgoyfdaobujrgcsedde?.AnesthesiaProcedure?.Performed;
                    object bw_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bv_);
                    return (bw_ as CqlInterval<CqlDateTime>) as object;
                }
                else if (bf_())
                {
                    DataType bx_ = tuple_fpgtpszgoyfdaobujrgcsedde?.AnesthesiaProcedure?.Performed;
                    object by_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bx_);
                    return (by_ as CqlQuantity) as object;
                }
                else if (bg_())
                {
                    DataType bz_ = tuple_fpgtpszgoyfdaobujrgcsedde?.AnesthesiaProcedure?.Performed;
                    object ca_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bz_);
                    return (ca_ as CqlInterval<CqlQuantity>) as object;
                }
                else
                {
                    return null;
                };
            }

            CqlInterval<CqlDateTime> w_ = QICoreCommon_4_0_000.Instance.toInterval(context, v_());
            CqlDateTime x_ = context.Operators.End(w_);
            CqlDateTime y_ = this.startOfFirstICU(context, tuple_fpgtpszgoyfdaobujrgcsedde?.QualifyingEncounterICU);
            CqlQuantity z_ = context.Operators.Quantity(1m, "day");
            CqlDateTime aa_ = context.Operators.Add(y_, z_);
            bool? ab_ = context.Operators.SameAs(x_, aa_, "day");
            bool? ac_ = context.Operators.And(u_, ab_);
            CqlDateTime ad_ = tuple_fpgtpszgoyfdaobujrgcsedde?.NoVTEMedication?.authoredOn;

            object ae_() {

                bool cb_() {
                    DataType cf_ = tuple_fpgtpszgoyfdaobujrgcsedde?.AnesthesiaProcedure?.Performed;
                    object cg_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cf_);
                    bool ch_ = cg_ is CqlDateTime;
                    return ch_;
                }


                bool cc_() {
                    DataType ci_ = tuple_fpgtpszgoyfdaobujrgcsedde?.AnesthesiaProcedure?.Performed;
                    object cj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ci_);
                    bool ck_ = cj_ is CqlInterval<CqlDateTime>;
                    return ck_;
                }


                bool cd_() {
                    DataType cl_ = tuple_fpgtpszgoyfdaobujrgcsedde?.AnesthesiaProcedure?.Performed;
                    object cm_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cl_);
                    bool cn_ = cm_ is CqlQuantity;
                    return cn_;
                }


                bool ce_() {
                    DataType co_ = tuple_fpgtpszgoyfdaobujrgcsedde?.AnesthesiaProcedure?.Performed;
                    object cp_ = FHIRHelpers_4_4_000.Instance.ToValue(context, co_);
                    bool cq_ = cp_ is CqlInterval<CqlQuantity>;
                    return cq_;
                }

                if (cb_())
                {
                    DataType cr_ = tuple_fpgtpszgoyfdaobujrgcsedde?.AnesthesiaProcedure?.Performed;
                    object cs_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cr_);
                    return (cs_ as CqlDateTime) as object;
                }
                else if (cc_())
                {
                    DataType ct_ = tuple_fpgtpszgoyfdaobujrgcsedde?.AnesthesiaProcedure?.Performed;
                    object cu_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ct_);
                    return (cu_ as CqlInterval<CqlDateTime>) as object;
                }
                else if (cd_())
                {
                    DataType cv_ = tuple_fpgtpszgoyfdaobujrgcsedde?.AnesthesiaProcedure?.Performed;
                    object cw_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cv_);
                    return (cw_ as CqlQuantity) as object;
                }
                else if (ce_())
                {
                    DataType cx_ = tuple_fpgtpszgoyfdaobujrgcsedde?.AnesthesiaProcedure?.Performed;
                    object cy_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cx_);
                    return (cy_ as CqlInterval<CqlQuantity>) as object;
                }
                else
                {
                    return null;
                };
            }

            CqlInterval<CqlDateTime> af_ = QICoreCommon_4_0_000.Instance.toInterval(context, ae_());
            CqlDateTime ag_ = context.Operators.End(af_);
            CqlInterval<CqlDate> ah_ = TJCOverall_8_25_000.Instance.calendarDayOfOrDayAfter(context, ag_);
            CqlDate ai_ = ah_?.low;
            CqlDateTime aj_ = context.Operators.ConvertDateToDateTime(ai_);

            object ak_() {

                bool cz_() {
                    DataType dd_ = tuple_fpgtpszgoyfdaobujrgcsedde?.AnesthesiaProcedure?.Performed;
                    object de_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dd_);
                    bool df_ = de_ is CqlDateTime;
                    return df_;
                }


                bool da_() {
                    DataType dg_ = tuple_fpgtpszgoyfdaobujrgcsedde?.AnesthesiaProcedure?.Performed;
                    object dh_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dg_);
                    bool di_ = dh_ is CqlInterval<CqlDateTime>;
                    return di_;
                }


                bool db_() {
                    DataType dj_ = tuple_fpgtpszgoyfdaobujrgcsedde?.AnesthesiaProcedure?.Performed;
                    object dk_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dj_);
                    bool dl_ = dk_ is CqlQuantity;
                    return dl_;
                }


                bool dc_() {
                    DataType dm_ = tuple_fpgtpszgoyfdaobujrgcsedde?.AnesthesiaProcedure?.Performed;
                    object dn_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dm_);
                    bool do_ = dn_ is CqlInterval<CqlQuantity>;
                    return do_;
                }

                if (cz_())
                {
                    DataType dp_ = tuple_fpgtpszgoyfdaobujrgcsedde?.AnesthesiaProcedure?.Performed;
                    object dq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dp_);
                    return (dq_ as CqlDateTime) as object;
                }
                else if (da_())
                {
                    DataType dr_ = tuple_fpgtpszgoyfdaobujrgcsedde?.AnesthesiaProcedure?.Performed;
                    object ds_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dr_);
                    return (ds_ as CqlInterval<CqlDateTime>) as object;
                }
                else if (db_())
                {
                    DataType dt_ = tuple_fpgtpszgoyfdaobujrgcsedde?.AnesthesiaProcedure?.Performed;
                    object du_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dt_);
                    return (du_ as CqlQuantity) as object;
                }
                else if (dc_())
                {
                    DataType dv_ = tuple_fpgtpszgoyfdaobujrgcsedde?.AnesthesiaProcedure?.Performed;
                    object dw_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dv_);
                    return (dw_ as CqlInterval<CqlQuantity>) as object;
                }
                else
                {
                    return null;
                };
            }

            CqlInterval<CqlDateTime> al_ = QICoreCommon_4_0_000.Instance.toInterval(context, ak_());
            CqlDateTime am_ = context.Operators.End(al_);
            CqlInterval<CqlDate> an_ = TJCOverall_8_25_000.Instance.calendarDayOfOrDayAfter(context, am_);
            CqlDate ao_ = an_?.high;
            CqlDateTime ap_ = context.Operators.ConvertDateToDateTime(ao_);

            object aq_() {

                bool dx_() {
                    DataType eb_ = tuple_fpgtpszgoyfdaobujrgcsedde?.AnesthesiaProcedure?.Performed;
                    object ec_ = FHIRHelpers_4_4_000.Instance.ToValue(context, eb_);
                    bool ed_ = ec_ is CqlDateTime;
                    return ed_;
                }


                bool dy_() {
                    DataType ee_ = tuple_fpgtpszgoyfdaobujrgcsedde?.AnesthesiaProcedure?.Performed;
                    object ef_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ee_);
                    bool eg_ = ef_ is CqlInterval<CqlDateTime>;
                    return eg_;
                }


                bool dz_() {
                    DataType eh_ = tuple_fpgtpszgoyfdaobujrgcsedde?.AnesthesiaProcedure?.Performed;
                    object ei_ = FHIRHelpers_4_4_000.Instance.ToValue(context, eh_);
                    bool ej_ = ei_ is CqlQuantity;
                    return ej_;
                }


                bool ea_() {
                    DataType ek_ = tuple_fpgtpszgoyfdaobujrgcsedde?.AnesthesiaProcedure?.Performed;
                    object el_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ek_);
                    bool em_ = el_ is CqlInterval<CqlQuantity>;
                    return em_;
                }

                if (dx_())
                {
                    DataType en_ = tuple_fpgtpszgoyfdaobujrgcsedde?.AnesthesiaProcedure?.Performed;
                    object eo_ = FHIRHelpers_4_4_000.Instance.ToValue(context, en_);
                    return (eo_ as CqlDateTime) as object;
                }
                else if (dy_())
                {
                    DataType ep_ = tuple_fpgtpszgoyfdaobujrgcsedde?.AnesthesiaProcedure?.Performed;
                    object eq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ep_);
                    return (eq_ as CqlInterval<CqlDateTime>) as object;
                }
                else if (dz_())
                {
                    DataType er_ = tuple_fpgtpszgoyfdaobujrgcsedde?.AnesthesiaProcedure?.Performed;
                    object es_ = FHIRHelpers_4_4_000.Instance.ToValue(context, er_);
                    return (es_ as CqlQuantity) as object;
                }
                else if (ea_())
                {
                    DataType et_ = tuple_fpgtpszgoyfdaobujrgcsedde?.AnesthesiaProcedure?.Performed;
                    object eu_ = FHIRHelpers_4_4_000.Instance.ToValue(context, et_);
                    return (eu_ as CqlInterval<CqlQuantity>) as object;
                }
                else
                {
                    return null;
                };
            }

            CqlInterval<CqlDateTime> ar_ = QICoreCommon_4_0_000.Instance.toInterval(context, aq_());
            CqlDateTime as_ = context.Operators.End(ar_);
            CqlInterval<CqlDate> at_ = TJCOverall_8_25_000.Instance.calendarDayOfOrDayAfter(context, as_);
            bool? au_ = at_?.lowClosed;

            object av_() {

                bool ev_() {
                    DataType ez_ = tuple_fpgtpszgoyfdaobujrgcsedde?.AnesthesiaProcedure?.Performed;
                    object fa_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ez_);
                    bool fb_ = fa_ is CqlDateTime;
                    return fb_;
                }


                bool ew_() {
                    DataType fc_ = tuple_fpgtpszgoyfdaobujrgcsedde?.AnesthesiaProcedure?.Performed;
                    object fd_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fc_);
                    bool fe_ = fd_ is CqlInterval<CqlDateTime>;
                    return fe_;
                }


                bool ex_() {
                    DataType ff_ = tuple_fpgtpszgoyfdaobujrgcsedde?.AnesthesiaProcedure?.Performed;
                    object fg_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ff_);
                    bool fh_ = fg_ is CqlQuantity;
                    return fh_;
                }


                bool ey_() {
                    DataType fi_ = tuple_fpgtpszgoyfdaobujrgcsedde?.AnesthesiaProcedure?.Performed;
                    object fj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fi_);
                    bool fk_ = fj_ is CqlInterval<CqlQuantity>;
                    return fk_;
                }

                if (ev_())
                {
                    DataType fl_ = tuple_fpgtpszgoyfdaobujrgcsedde?.AnesthesiaProcedure?.Performed;
                    object fm_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fl_);
                    return (fm_ as CqlDateTime) as object;
                }
                else if (ew_())
                {
                    DataType fn_ = tuple_fpgtpszgoyfdaobujrgcsedde?.AnesthesiaProcedure?.Performed;
                    object fo_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fn_);
                    return (fo_ as CqlInterval<CqlDateTime>) as object;
                }
                else if (ex_())
                {
                    DataType fp_ = tuple_fpgtpszgoyfdaobujrgcsedde?.AnesthesiaProcedure?.Performed;
                    object fq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fp_);
                    return (fq_ as CqlQuantity) as object;
                }
                else if (ey_())
                {
                    DataType fr_ = tuple_fpgtpszgoyfdaobujrgcsedde?.AnesthesiaProcedure?.Performed;
                    object fs_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fr_);
                    return (fs_ as CqlInterval<CqlQuantity>) as object;
                }
                else
                {
                    return null;
                };
            }

            CqlInterval<CqlDateTime> aw_ = QICoreCommon_4_0_000.Instance.toInterval(context, av_());
            CqlDateTime ax_ = context.Operators.End(aw_);
            CqlInterval<CqlDate> ay_ = TJCOverall_8_25_000.Instance.calendarDayOfOrDayAfter(context, ax_);
            bool? az_ = ay_?.highClosed;
            CqlInterval<CqlDateTime> ba_ = context.Operators.Interval(aj_, ap_, au_, az_);
            bool? bb_ = context.Operators.In<CqlDateTime>(ad_, ba_, "day");
            bool? bc_ = context.Operators.And(ac_, bb_);
            return bc_;
        }

        IEnumerable<(CqlTupleMetadata, Encounter QualifyingEncounterICU, Procedure AnesthesiaProcedure, (CqlTupleMetadata, string id, IEnumerable<CqlConcept> medicationStatusReason, CqlDateTime authoredOn)? NoVTEMedication)?> i_ = context.Operators.Where<(CqlTupleMetadata, Encounter QualifyingEncounterICU, Procedure AnesthesiaProcedure, (CqlTupleMetadata, string id, IEnumerable<CqlConcept> medicationStatusReason, CqlDateTime authoredOn)? NoVTEMedication)?>(g_, h_);
        Encounter j_((CqlTupleMetadata, Encounter QualifyingEncounterICU, Procedure AnesthesiaProcedure, (CqlTupleMetadata, string id, IEnumerable<CqlConcept> medicationStatusReason, CqlDateTime authoredOn)? NoVTEMedication)? tuple_fpgtpszgoyfdaobujrgcsedde) => tuple_fpgtpszgoyfdaobujrgcsedde?.QualifyingEncounterICU;
        IEnumerable<Encounter> k_ = context.Operators.Select<(CqlTupleMetadata, Encounter QualifyingEncounterICU, Procedure AnesthesiaProcedure, (CqlTupleMetadata, string id, IEnumerable<CqlConcept> medicationStatusReason, CqlDateTime authoredOn)? NoVTEMedication)?, Encounter>(i_, j_);
        IEnumerable<Encounter> l_ = context.Operators.Distinct<Encounter>(k_);
        return l_;
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
            (CqlTupleMetadata, Encounter QualifyingEncounterICU, Procedure AnesthesiaProcedure, (CqlTupleMetadata, string id, CqlConcept requestStatusReason, CqlDateTime authoredOn)? NoVTEDevice)? m_ = (CqlTupleMetadata_ifVVXcOGTAXRRBdEBOYOhXCQ, _valueTuple.Item1, _valueTuple.Item2, _valueTuple.Item3);
            return m_;
        }

        IEnumerable<(CqlTupleMetadata, Encounter QualifyingEncounterICU, Procedure AnesthesiaProcedure, (CqlTupleMetadata, string id, CqlConcept requestStatusReason, CqlDateTime authoredOn)? NoVTEDevice)?> g_ = context.Operators.Select<ValueTuple<Encounter, Procedure, (CqlTupleMetadata, string id, CqlConcept requestStatusReason, CqlDateTime authoredOn)?>, (CqlTupleMetadata, Encounter QualifyingEncounterICU, Procedure AnesthesiaProcedure, (CqlTupleMetadata, string id, CqlConcept requestStatusReason, CqlDateTime authoredOn)? NoVTEDevice)?>(e_, f_);

        bool? h_((CqlTupleMetadata, Encounter QualifyingEncounterICU, Procedure AnesthesiaProcedure, (CqlTupleMetadata, string id, CqlConcept requestStatusReason, CqlDateTime authoredOn)? NoVTEDevice)? tuple_fnrkedfurymcjidjkbtaenork) {
            CqlConcept n_ = tuple_fnrkedfurymcjidjkbtaenork?.NoVTEDevice?.requestStatusReason;
            CqlValueSet o_ = this.Medical_Reason_For_Not_Providing_Treatment(context);
            bool? p_ = context.Operators.ConceptInValueSet(n_, o_);
            Code<EventStatus> q_ = tuple_fnrkedfurymcjidjkbtaenork?.AnesthesiaProcedure?.StatusElement;
            EventStatus? r_ = q_?.Value;
            string s_ = context.Operators.Convert<string>(r_);
            bool? t_ = context.Operators.Equal(s_, "completed");
            bool? u_ = context.Operators.And(p_, t_);

            object v_() {

                bool bd_() {
                    DataType bh_ = tuple_fnrkedfurymcjidjkbtaenork?.AnesthesiaProcedure?.Performed;
                    object bi_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bh_);
                    bool bj_ = bi_ is CqlDateTime;
                    return bj_;
                }


                bool be_() {
                    DataType bk_ = tuple_fnrkedfurymcjidjkbtaenork?.AnesthesiaProcedure?.Performed;
                    object bl_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bk_);
                    bool bm_ = bl_ is CqlInterval<CqlDateTime>;
                    return bm_;
                }


                bool bf_() {
                    DataType bn_ = tuple_fnrkedfurymcjidjkbtaenork?.AnesthesiaProcedure?.Performed;
                    object bo_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bn_);
                    bool bp_ = bo_ is CqlQuantity;
                    return bp_;
                }


                bool bg_() {
                    DataType bq_ = tuple_fnrkedfurymcjidjkbtaenork?.AnesthesiaProcedure?.Performed;
                    object br_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bq_);
                    bool bs_ = br_ is CqlInterval<CqlQuantity>;
                    return bs_;
                }

                if (bd_())
                {
                    DataType bt_ = tuple_fnrkedfurymcjidjkbtaenork?.AnesthesiaProcedure?.Performed;
                    object bu_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bt_);
                    return (bu_ as CqlDateTime) as object;
                }
                else if (be_())
                {
                    DataType bv_ = tuple_fnrkedfurymcjidjkbtaenork?.AnesthesiaProcedure?.Performed;
                    object bw_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bv_);
                    return (bw_ as CqlInterval<CqlDateTime>) as object;
                }
                else if (bf_())
                {
                    DataType bx_ = tuple_fnrkedfurymcjidjkbtaenork?.AnesthesiaProcedure?.Performed;
                    object by_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bx_);
                    return (by_ as CqlQuantity) as object;
                }
                else if (bg_())
                {
                    DataType bz_ = tuple_fnrkedfurymcjidjkbtaenork?.AnesthesiaProcedure?.Performed;
                    object ca_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bz_);
                    return (ca_ as CqlInterval<CqlQuantity>) as object;
                }
                else
                {
                    return null;
                };
            }

            CqlInterval<CqlDateTime> w_ = QICoreCommon_4_0_000.Instance.toInterval(context, v_());
            CqlDateTime x_ = context.Operators.End(w_);
            CqlDateTime y_ = this.startOfFirstICU(context, tuple_fnrkedfurymcjidjkbtaenork?.QualifyingEncounterICU);
            CqlQuantity z_ = context.Operators.Quantity(1m, "day");
            CqlDateTime aa_ = context.Operators.Add(y_, z_);
            bool? ab_ = context.Operators.SameAs(x_, aa_, "day");
            bool? ac_ = context.Operators.And(u_, ab_);
            CqlDateTime ad_ = tuple_fnrkedfurymcjidjkbtaenork?.NoVTEDevice?.authoredOn;

            object ae_() {

                bool cb_() {
                    DataType cf_ = tuple_fnrkedfurymcjidjkbtaenork?.AnesthesiaProcedure?.Performed;
                    object cg_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cf_);
                    bool ch_ = cg_ is CqlDateTime;
                    return ch_;
                }


                bool cc_() {
                    DataType ci_ = tuple_fnrkedfurymcjidjkbtaenork?.AnesthesiaProcedure?.Performed;
                    object cj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ci_);
                    bool ck_ = cj_ is CqlInterval<CqlDateTime>;
                    return ck_;
                }


                bool cd_() {
                    DataType cl_ = tuple_fnrkedfurymcjidjkbtaenork?.AnesthesiaProcedure?.Performed;
                    object cm_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cl_);
                    bool cn_ = cm_ is CqlQuantity;
                    return cn_;
                }


                bool ce_() {
                    DataType co_ = tuple_fnrkedfurymcjidjkbtaenork?.AnesthesiaProcedure?.Performed;
                    object cp_ = FHIRHelpers_4_4_000.Instance.ToValue(context, co_);
                    bool cq_ = cp_ is CqlInterval<CqlQuantity>;
                    return cq_;
                }

                if (cb_())
                {
                    DataType cr_ = tuple_fnrkedfurymcjidjkbtaenork?.AnesthesiaProcedure?.Performed;
                    object cs_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cr_);
                    return (cs_ as CqlDateTime) as object;
                }
                else if (cc_())
                {
                    DataType ct_ = tuple_fnrkedfurymcjidjkbtaenork?.AnesthesiaProcedure?.Performed;
                    object cu_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ct_);
                    return (cu_ as CqlInterval<CqlDateTime>) as object;
                }
                else if (cd_())
                {
                    DataType cv_ = tuple_fnrkedfurymcjidjkbtaenork?.AnesthesiaProcedure?.Performed;
                    object cw_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cv_);
                    return (cw_ as CqlQuantity) as object;
                }
                else if (ce_())
                {
                    DataType cx_ = tuple_fnrkedfurymcjidjkbtaenork?.AnesthesiaProcedure?.Performed;
                    object cy_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cx_);
                    return (cy_ as CqlInterval<CqlQuantity>) as object;
                }
                else
                {
                    return null;
                };
            }

            CqlInterval<CqlDateTime> af_ = QICoreCommon_4_0_000.Instance.toInterval(context, ae_());
            CqlDateTime ag_ = context.Operators.End(af_);
            CqlInterval<CqlDate> ah_ = TJCOverall_8_25_000.Instance.calendarDayOfOrDayAfter(context, ag_);
            CqlDate ai_ = ah_?.low;
            CqlDateTime aj_ = context.Operators.ConvertDateToDateTime(ai_);

            object ak_() {

                bool cz_() {
                    DataType dd_ = tuple_fnrkedfurymcjidjkbtaenork?.AnesthesiaProcedure?.Performed;
                    object de_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dd_);
                    bool df_ = de_ is CqlDateTime;
                    return df_;
                }


                bool da_() {
                    DataType dg_ = tuple_fnrkedfurymcjidjkbtaenork?.AnesthesiaProcedure?.Performed;
                    object dh_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dg_);
                    bool di_ = dh_ is CqlInterval<CqlDateTime>;
                    return di_;
                }


                bool db_() {
                    DataType dj_ = tuple_fnrkedfurymcjidjkbtaenork?.AnesthesiaProcedure?.Performed;
                    object dk_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dj_);
                    bool dl_ = dk_ is CqlQuantity;
                    return dl_;
                }


                bool dc_() {
                    DataType dm_ = tuple_fnrkedfurymcjidjkbtaenork?.AnesthesiaProcedure?.Performed;
                    object dn_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dm_);
                    bool do_ = dn_ is CqlInterval<CqlQuantity>;
                    return do_;
                }

                if (cz_())
                {
                    DataType dp_ = tuple_fnrkedfurymcjidjkbtaenork?.AnesthesiaProcedure?.Performed;
                    object dq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dp_);
                    return (dq_ as CqlDateTime) as object;
                }
                else if (da_())
                {
                    DataType dr_ = tuple_fnrkedfurymcjidjkbtaenork?.AnesthesiaProcedure?.Performed;
                    object ds_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dr_);
                    return (ds_ as CqlInterval<CqlDateTime>) as object;
                }
                else if (db_())
                {
                    DataType dt_ = tuple_fnrkedfurymcjidjkbtaenork?.AnesthesiaProcedure?.Performed;
                    object du_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dt_);
                    return (du_ as CqlQuantity) as object;
                }
                else if (dc_())
                {
                    DataType dv_ = tuple_fnrkedfurymcjidjkbtaenork?.AnesthesiaProcedure?.Performed;
                    object dw_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dv_);
                    return (dw_ as CqlInterval<CqlQuantity>) as object;
                }
                else
                {
                    return null;
                };
            }

            CqlInterval<CqlDateTime> al_ = QICoreCommon_4_0_000.Instance.toInterval(context, ak_());
            CqlDateTime am_ = context.Operators.End(al_);
            CqlInterval<CqlDate> an_ = TJCOverall_8_25_000.Instance.calendarDayOfOrDayAfter(context, am_);
            CqlDate ao_ = an_?.high;
            CqlDateTime ap_ = context.Operators.ConvertDateToDateTime(ao_);

            object aq_() {

                bool dx_() {
                    DataType eb_ = tuple_fnrkedfurymcjidjkbtaenork?.AnesthesiaProcedure?.Performed;
                    object ec_ = FHIRHelpers_4_4_000.Instance.ToValue(context, eb_);
                    bool ed_ = ec_ is CqlDateTime;
                    return ed_;
                }


                bool dy_() {
                    DataType ee_ = tuple_fnrkedfurymcjidjkbtaenork?.AnesthesiaProcedure?.Performed;
                    object ef_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ee_);
                    bool eg_ = ef_ is CqlInterval<CqlDateTime>;
                    return eg_;
                }


                bool dz_() {
                    DataType eh_ = tuple_fnrkedfurymcjidjkbtaenork?.AnesthesiaProcedure?.Performed;
                    object ei_ = FHIRHelpers_4_4_000.Instance.ToValue(context, eh_);
                    bool ej_ = ei_ is CqlQuantity;
                    return ej_;
                }


                bool ea_() {
                    DataType ek_ = tuple_fnrkedfurymcjidjkbtaenork?.AnesthesiaProcedure?.Performed;
                    object el_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ek_);
                    bool em_ = el_ is CqlInterval<CqlQuantity>;
                    return em_;
                }

                if (dx_())
                {
                    DataType en_ = tuple_fnrkedfurymcjidjkbtaenork?.AnesthesiaProcedure?.Performed;
                    object eo_ = FHIRHelpers_4_4_000.Instance.ToValue(context, en_);
                    return (eo_ as CqlDateTime) as object;
                }
                else if (dy_())
                {
                    DataType ep_ = tuple_fnrkedfurymcjidjkbtaenork?.AnesthesiaProcedure?.Performed;
                    object eq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ep_);
                    return (eq_ as CqlInterval<CqlDateTime>) as object;
                }
                else if (dz_())
                {
                    DataType er_ = tuple_fnrkedfurymcjidjkbtaenork?.AnesthesiaProcedure?.Performed;
                    object es_ = FHIRHelpers_4_4_000.Instance.ToValue(context, er_);
                    return (es_ as CqlQuantity) as object;
                }
                else if (ea_())
                {
                    DataType et_ = tuple_fnrkedfurymcjidjkbtaenork?.AnesthesiaProcedure?.Performed;
                    object eu_ = FHIRHelpers_4_4_000.Instance.ToValue(context, et_);
                    return (eu_ as CqlInterval<CqlQuantity>) as object;
                }
                else
                {
                    return null;
                };
            }

            CqlInterval<CqlDateTime> ar_ = QICoreCommon_4_0_000.Instance.toInterval(context, aq_());
            CqlDateTime as_ = context.Operators.End(ar_);
            CqlInterval<CqlDate> at_ = TJCOverall_8_25_000.Instance.calendarDayOfOrDayAfter(context, as_);
            bool? au_ = at_?.lowClosed;

            object av_() {

                bool ev_() {
                    DataType ez_ = tuple_fnrkedfurymcjidjkbtaenork?.AnesthesiaProcedure?.Performed;
                    object fa_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ez_);
                    bool fb_ = fa_ is CqlDateTime;
                    return fb_;
                }


                bool ew_() {
                    DataType fc_ = tuple_fnrkedfurymcjidjkbtaenork?.AnesthesiaProcedure?.Performed;
                    object fd_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fc_);
                    bool fe_ = fd_ is CqlInterval<CqlDateTime>;
                    return fe_;
                }


                bool ex_() {
                    DataType ff_ = tuple_fnrkedfurymcjidjkbtaenork?.AnesthesiaProcedure?.Performed;
                    object fg_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ff_);
                    bool fh_ = fg_ is CqlQuantity;
                    return fh_;
                }


                bool ey_() {
                    DataType fi_ = tuple_fnrkedfurymcjidjkbtaenork?.AnesthesiaProcedure?.Performed;
                    object fj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fi_);
                    bool fk_ = fj_ is CqlInterval<CqlQuantity>;
                    return fk_;
                }

                if (ev_())
                {
                    DataType fl_ = tuple_fnrkedfurymcjidjkbtaenork?.AnesthesiaProcedure?.Performed;
                    object fm_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fl_);
                    return (fm_ as CqlDateTime) as object;
                }
                else if (ew_())
                {
                    DataType fn_ = tuple_fnrkedfurymcjidjkbtaenork?.AnesthesiaProcedure?.Performed;
                    object fo_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fn_);
                    return (fo_ as CqlInterval<CqlDateTime>) as object;
                }
                else if (ex_())
                {
                    DataType fp_ = tuple_fnrkedfurymcjidjkbtaenork?.AnesthesiaProcedure?.Performed;
                    object fq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fp_);
                    return (fq_ as CqlQuantity) as object;
                }
                else if (ey_())
                {
                    DataType fr_ = tuple_fnrkedfurymcjidjkbtaenork?.AnesthesiaProcedure?.Performed;
                    object fs_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fr_);
                    return (fs_ as CqlInterval<CqlQuantity>) as object;
                }
                else
                {
                    return null;
                };
            }

            CqlInterval<CqlDateTime> aw_ = QICoreCommon_4_0_000.Instance.toInterval(context, av_());
            CqlDateTime ax_ = context.Operators.End(aw_);
            CqlInterval<CqlDate> ay_ = TJCOverall_8_25_000.Instance.calendarDayOfOrDayAfter(context, ax_);
            bool? az_ = ay_?.highClosed;
            CqlInterval<CqlDateTime> ba_ = context.Operators.Interval(aj_, ap_, au_, az_);
            bool? bb_ = context.Operators.In<CqlDateTime>(ad_, ba_, "day");
            bool? bc_ = context.Operators.And(ac_, bb_);
            return bc_;
        }

        IEnumerable<(CqlTupleMetadata, Encounter QualifyingEncounterICU, Procedure AnesthesiaProcedure, (CqlTupleMetadata, string id, CqlConcept requestStatusReason, CqlDateTime authoredOn)? NoVTEDevice)?> i_ = context.Operators.Where<(CqlTupleMetadata, Encounter QualifyingEncounterICU, Procedure AnesthesiaProcedure, (CqlTupleMetadata, string id, CqlConcept requestStatusReason, CqlDateTime authoredOn)? NoVTEDevice)?>(g_, h_);
        Encounter j_((CqlTupleMetadata, Encounter QualifyingEncounterICU, Procedure AnesthesiaProcedure, (CqlTupleMetadata, string id, CqlConcept requestStatusReason, CqlDateTime authoredOn)? NoVTEDevice)? tuple_fnrkedfurymcjidjkbtaenork) => tuple_fnrkedfurymcjidjkbtaenork?.QualifyingEncounterICU;
        IEnumerable<Encounter> k_ = context.Operators.Select<(CqlTupleMetadata, Encounter QualifyingEncounterICU, Procedure AnesthesiaProcedure, (CqlTupleMetadata, string id, CqlConcept requestStatusReason, CqlDateTime authoredOn)? NoVTEDevice)?, Encounter>(i_, j_);
        IEnumerable<Encounter> l_ = context.Operators.Distinct<Encounter>(k_);
        return l_;
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
            IEnumerable<CqlConcept> h_ = NoVTEMedication?.medicationStatusReason;
            CqlValueSet i_ = this.Patient_Refusal(context);
            bool? j_ = context.Operators.ConceptsInValueSet(h_, i_);
            return j_;
        }

        IEnumerable<(CqlTupleMetadata, string id, IEnumerable<CqlConcept> medicationStatusReason, CqlDateTime authoredOn)?> c_ = context.Operators.Where<(CqlTupleMetadata, string id, IEnumerable<CqlConcept> medicationStatusReason, CqlDateTime authoredOn)?>(a_, b_);
        IEnumerable<(CqlTupleMetadata, string id, CqlConcept requestStatusReason, CqlDateTime authoredOn)?> d_ = this.No_Mechanical_VTE_Prophylaxis_Performed_Or_Ordered(context);

        bool? e_((CqlTupleMetadata, string id, CqlConcept requestStatusReason, CqlDateTime authoredOn)? NoVTEDevice) {
            CqlConcept k_ = NoVTEDevice?.requestStatusReason;
            CqlValueSet l_ = this.Patient_Refusal(context);
            bool? m_ = context.Operators.ConceptInValueSet(k_, l_);
            return m_;
        }

        IEnumerable<(CqlTupleMetadata, string id, CqlConcept requestStatusReason, CqlDateTime authoredOn)?> f_ = context.Operators.Where<(CqlTupleMetadata, string id, CqlConcept requestStatusReason, CqlDateTime authoredOn)?>(d_, e_);
        IEnumerable<object> g_ = context.Operators.Union<object>(c_ as IEnumerable<object>, f_ as IEnumerable<object>);
        return g_;
    }


    [CqlExpressionDefinition("No VTE Prophylaxis Due To Patient Refusal From Day Of Start Of Hospitalization To Day After First ICU Stay")]
    public IEnumerable<Encounter> No_VTE_Prophylaxis_Due_To_Patient_Refusal_From_Day_Of_Start_Of_Hospitalization_To_Day_After_First_ICU_Stay(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_No_VTE_Prophylaxis_Due_To_Patient_Refusal_From_Day_Of_Start_Of_Hospitalization_To_Day_After_First_ICU_Stay, No_VTE_Prophylaxis_Due_To_Patient_Refusal_From_Day_Of_Start_Of_Hospitalization_To_Day_After_First_ICU_Stay_Compute);

    private const long _cacheIndex_No_VTE_Prophylaxis_Due_To_Patient_Refusal_From_Day_Of_Start_Of_Hospitalization_To_Day_After_First_ICU_Stay = 1167693690454486814L;

    private IEnumerable<Encounter> No_VTE_Prophylaxis_Due_To_Patient_Refusal_From_Day_Of_Start_Of_Hospitalization_To_Day_After_First_ICU_Stay_Compute(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Encounter_With_ICU_Location(context);

        IEnumerable<Encounter> b_(Encounter QualifyingEncounterICU) {
            IEnumerable<object> d_ = this.No_Mechanical_or_Pharmacological_VTE_Prophylaxis_Due_To_Patient_Refusal(context);

            bool? e_(object PatientRefusal) {
                CqlDateTime i_ = context.Operators.LateBoundProperty<CqlDateTime>(PatientRefusal, "authoredOn");
                CqlInterval<CqlDate> j_ = this.fromDayOfStartOfHospitalizationToDayAfterFirstICU(context, QualifyingEncounterICU);
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
            Encounter g_(object PatientRefusal) => QualifyingEncounterICU;
            IEnumerable<Encounter> h_ = context.Operators.Select<object, Encounter>(f_, g_);
            return h_;
        }

        IEnumerable<Encounter> c_ = context.Operators.SelectMany<Encounter, Encounter>(a_, b_);
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
            (CqlTupleMetadata, Encounter QualifyingEncounterICU, Procedure AnesthesiaProcedure, object PatientRefusal)? m_ = (CqlTupleMetadata_MYMdRYUDSjLaJAMGKSYBKOjf, _valueTuple.Item1, _valueTuple.Item2, _valueTuple.Item3);
            return m_;
        }

        IEnumerable<(CqlTupleMetadata, Encounter QualifyingEncounterICU, Procedure AnesthesiaProcedure, object PatientRefusal)?> g_ = context.Operators.Select<ValueTuple<Encounter, Procedure, object>, (CqlTupleMetadata, Encounter QualifyingEncounterICU, Procedure AnesthesiaProcedure, object PatientRefusal)?>(e_, f_);

        bool? h_((CqlTupleMetadata, Encounter QualifyingEncounterICU, Procedure AnesthesiaProcedure, object PatientRefusal)? tuple_bvgardhyjgbgfxidntuflexa) {
            Code<EventStatus> n_ = tuple_bvgardhyjgbgfxidntuflexa?.AnesthesiaProcedure?.StatusElement;
            EventStatus? o_ = n_?.Value;
            string p_ = context.Operators.Convert<string>(o_);
            bool? q_ = context.Operators.Equal(p_, "completed");

            object r_() {

                bool az_() {
                    DataType bd_ = tuple_bvgardhyjgbgfxidntuflexa?.AnesthesiaProcedure?.Performed;
                    object be_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bd_);
                    bool bf_ = be_ is CqlDateTime;
                    return bf_;
                }


                bool ba_() {
                    DataType bg_ = tuple_bvgardhyjgbgfxidntuflexa?.AnesthesiaProcedure?.Performed;
                    object bh_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bg_);
                    bool bi_ = bh_ is CqlInterval<CqlDateTime>;
                    return bi_;
                }


                bool bb_() {
                    DataType bj_ = tuple_bvgardhyjgbgfxidntuflexa?.AnesthesiaProcedure?.Performed;
                    object bk_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bj_);
                    bool bl_ = bk_ is CqlQuantity;
                    return bl_;
                }


                bool bc_() {
                    DataType bm_ = tuple_bvgardhyjgbgfxidntuflexa?.AnesthesiaProcedure?.Performed;
                    object bn_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bm_);
                    bool bo_ = bn_ is CqlInterval<CqlQuantity>;
                    return bo_;
                }

                if (az_())
                {
                    DataType bp_ = tuple_bvgardhyjgbgfxidntuflexa?.AnesthesiaProcedure?.Performed;
                    object bq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bp_);
                    return (bq_ as CqlDateTime) as object;
                }
                else if (ba_())
                {
                    DataType br_ = tuple_bvgardhyjgbgfxidntuflexa?.AnesthesiaProcedure?.Performed;
                    object bs_ = FHIRHelpers_4_4_000.Instance.ToValue(context, br_);
                    return (bs_ as CqlInterval<CqlDateTime>) as object;
                }
                else if (bb_())
                {
                    DataType bt_ = tuple_bvgardhyjgbgfxidntuflexa?.AnesthesiaProcedure?.Performed;
                    object bu_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bt_);
                    return (bu_ as CqlQuantity) as object;
                }
                else if (bc_())
                {
                    DataType bv_ = tuple_bvgardhyjgbgfxidntuflexa?.AnesthesiaProcedure?.Performed;
                    object bw_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bv_);
                    return (bw_ as CqlInterval<CqlQuantity>) as object;
                }
                else
                {
                    return null;
                };
            }

            CqlInterval<CqlDateTime> s_ = QICoreCommon_4_0_000.Instance.toInterval(context, r_());
            CqlDateTime t_ = context.Operators.End(s_);
            CqlDateTime u_ = this.startOfFirstICU(context, tuple_bvgardhyjgbgfxidntuflexa?.QualifyingEncounterICU);
            CqlQuantity v_ = context.Operators.Quantity(1m, "day");
            CqlDateTime w_ = context.Operators.Add(u_, v_);
            bool? x_ = context.Operators.SameAs(t_, w_, "day");
            bool? y_ = context.Operators.And(q_, x_);
            CqlDateTime z_ = context.Operators.LateBoundProperty<CqlDateTime>(tuple_bvgardhyjgbgfxidntuflexa?.PatientRefusal, "authoredOn");

            object aa_() {

                bool bx_() {
                    DataType cb_ = tuple_bvgardhyjgbgfxidntuflexa?.AnesthesiaProcedure?.Performed;
                    object cc_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cb_);
                    bool cd_ = cc_ is CqlDateTime;
                    return cd_;
                }


                bool by_() {
                    DataType ce_ = tuple_bvgardhyjgbgfxidntuflexa?.AnesthesiaProcedure?.Performed;
                    object cf_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ce_);
                    bool cg_ = cf_ is CqlInterval<CqlDateTime>;
                    return cg_;
                }


                bool bz_() {
                    DataType ch_ = tuple_bvgardhyjgbgfxidntuflexa?.AnesthesiaProcedure?.Performed;
                    object ci_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ch_);
                    bool cj_ = ci_ is CqlQuantity;
                    return cj_;
                }


                bool ca_() {
                    DataType ck_ = tuple_bvgardhyjgbgfxidntuflexa?.AnesthesiaProcedure?.Performed;
                    object cl_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ck_);
                    bool cm_ = cl_ is CqlInterval<CqlQuantity>;
                    return cm_;
                }

                if (bx_())
                {
                    DataType cn_ = tuple_bvgardhyjgbgfxidntuflexa?.AnesthesiaProcedure?.Performed;
                    object co_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cn_);
                    return (co_ as CqlDateTime) as object;
                }
                else if (by_())
                {
                    DataType cp_ = tuple_bvgardhyjgbgfxidntuflexa?.AnesthesiaProcedure?.Performed;
                    object cq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cp_);
                    return (cq_ as CqlInterval<CqlDateTime>) as object;
                }
                else if (bz_())
                {
                    DataType cr_ = tuple_bvgardhyjgbgfxidntuflexa?.AnesthesiaProcedure?.Performed;
                    object cs_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cr_);
                    return (cs_ as CqlQuantity) as object;
                }
                else if (ca_())
                {
                    DataType ct_ = tuple_bvgardhyjgbgfxidntuflexa?.AnesthesiaProcedure?.Performed;
                    object cu_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ct_);
                    return (cu_ as CqlInterval<CqlQuantity>) as object;
                }
                else
                {
                    return null;
                };
            }

            CqlInterval<CqlDateTime> ab_ = QICoreCommon_4_0_000.Instance.toInterval(context, aa_());
            CqlDateTime ac_ = context.Operators.End(ab_);
            CqlInterval<CqlDate> ad_ = TJCOverall_8_25_000.Instance.calendarDayOfOrDayAfter(context, ac_);
            CqlDate ae_ = ad_?.low;
            CqlDateTime af_ = context.Operators.ConvertDateToDateTime(ae_);

            object ag_() {

                bool cv_() {
                    DataType cz_ = tuple_bvgardhyjgbgfxidntuflexa?.AnesthesiaProcedure?.Performed;
                    object da_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cz_);
                    bool db_ = da_ is CqlDateTime;
                    return db_;
                }


                bool cw_() {
                    DataType dc_ = tuple_bvgardhyjgbgfxidntuflexa?.AnesthesiaProcedure?.Performed;
                    object dd_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dc_);
                    bool de_ = dd_ is CqlInterval<CqlDateTime>;
                    return de_;
                }


                bool cx_() {
                    DataType df_ = tuple_bvgardhyjgbgfxidntuflexa?.AnesthesiaProcedure?.Performed;
                    object dg_ = FHIRHelpers_4_4_000.Instance.ToValue(context, df_);
                    bool dh_ = dg_ is CqlQuantity;
                    return dh_;
                }


                bool cy_() {
                    DataType di_ = tuple_bvgardhyjgbgfxidntuflexa?.AnesthesiaProcedure?.Performed;
                    object dj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, di_);
                    bool dk_ = dj_ is CqlInterval<CqlQuantity>;
                    return dk_;
                }

                if (cv_())
                {
                    DataType dl_ = tuple_bvgardhyjgbgfxidntuflexa?.AnesthesiaProcedure?.Performed;
                    object dm_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dl_);
                    return (dm_ as CqlDateTime) as object;
                }
                else if (cw_())
                {
                    DataType dn_ = tuple_bvgardhyjgbgfxidntuflexa?.AnesthesiaProcedure?.Performed;
                    object do_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dn_);
                    return (do_ as CqlInterval<CqlDateTime>) as object;
                }
                else if (cx_())
                {
                    DataType dp_ = tuple_bvgardhyjgbgfxidntuflexa?.AnesthesiaProcedure?.Performed;
                    object dq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dp_);
                    return (dq_ as CqlQuantity) as object;
                }
                else if (cy_())
                {
                    DataType dr_ = tuple_bvgardhyjgbgfxidntuflexa?.AnesthesiaProcedure?.Performed;
                    object ds_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dr_);
                    return (ds_ as CqlInterval<CqlQuantity>) as object;
                }
                else
                {
                    return null;
                };
            }

            CqlInterval<CqlDateTime> ah_ = QICoreCommon_4_0_000.Instance.toInterval(context, ag_());
            CqlDateTime ai_ = context.Operators.End(ah_);
            CqlInterval<CqlDate> aj_ = TJCOverall_8_25_000.Instance.calendarDayOfOrDayAfter(context, ai_);
            CqlDate ak_ = aj_?.high;
            CqlDateTime al_ = context.Operators.ConvertDateToDateTime(ak_);

            object am_() {

                bool dt_() {
                    DataType dx_ = tuple_bvgardhyjgbgfxidntuflexa?.AnesthesiaProcedure?.Performed;
                    object dy_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dx_);
                    bool dz_ = dy_ is CqlDateTime;
                    return dz_;
                }


                bool du_() {
                    DataType ea_ = tuple_bvgardhyjgbgfxidntuflexa?.AnesthesiaProcedure?.Performed;
                    object eb_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ea_);
                    bool ec_ = eb_ is CqlInterval<CqlDateTime>;
                    return ec_;
                }


                bool dv_() {
                    DataType ed_ = tuple_bvgardhyjgbgfxidntuflexa?.AnesthesiaProcedure?.Performed;
                    object ee_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ed_);
                    bool ef_ = ee_ is CqlQuantity;
                    return ef_;
                }


                bool dw_() {
                    DataType eg_ = tuple_bvgardhyjgbgfxidntuflexa?.AnesthesiaProcedure?.Performed;
                    object eh_ = FHIRHelpers_4_4_000.Instance.ToValue(context, eg_);
                    bool ei_ = eh_ is CqlInterval<CqlQuantity>;
                    return ei_;
                }

                if (dt_())
                {
                    DataType ej_ = tuple_bvgardhyjgbgfxidntuflexa?.AnesthesiaProcedure?.Performed;
                    object ek_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ej_);
                    return (ek_ as CqlDateTime) as object;
                }
                else if (du_())
                {
                    DataType el_ = tuple_bvgardhyjgbgfxidntuflexa?.AnesthesiaProcedure?.Performed;
                    object em_ = FHIRHelpers_4_4_000.Instance.ToValue(context, el_);
                    return (em_ as CqlInterval<CqlDateTime>) as object;
                }
                else if (dv_())
                {
                    DataType en_ = tuple_bvgardhyjgbgfxidntuflexa?.AnesthesiaProcedure?.Performed;
                    object eo_ = FHIRHelpers_4_4_000.Instance.ToValue(context, en_);
                    return (eo_ as CqlQuantity) as object;
                }
                else if (dw_())
                {
                    DataType ep_ = tuple_bvgardhyjgbgfxidntuflexa?.AnesthesiaProcedure?.Performed;
                    object eq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ep_);
                    return (eq_ as CqlInterval<CqlQuantity>) as object;
                }
                else
                {
                    return null;
                };
            }

            CqlInterval<CqlDateTime> an_ = QICoreCommon_4_0_000.Instance.toInterval(context, am_());
            CqlDateTime ao_ = context.Operators.End(an_);
            CqlInterval<CqlDate> ap_ = TJCOverall_8_25_000.Instance.calendarDayOfOrDayAfter(context, ao_);
            bool? aq_ = ap_?.lowClosed;

            object ar_() {

                bool er_() {
                    DataType ev_ = tuple_bvgardhyjgbgfxidntuflexa?.AnesthesiaProcedure?.Performed;
                    object ew_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ev_);
                    bool ex_ = ew_ is CqlDateTime;
                    return ex_;
                }


                bool es_() {
                    DataType ey_ = tuple_bvgardhyjgbgfxidntuflexa?.AnesthesiaProcedure?.Performed;
                    object ez_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ey_);
                    bool fa_ = ez_ is CqlInterval<CqlDateTime>;
                    return fa_;
                }


                bool et_() {
                    DataType fb_ = tuple_bvgardhyjgbgfxidntuflexa?.AnesthesiaProcedure?.Performed;
                    object fc_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fb_);
                    bool fd_ = fc_ is CqlQuantity;
                    return fd_;
                }


                bool eu_() {
                    DataType fe_ = tuple_bvgardhyjgbgfxidntuflexa?.AnesthesiaProcedure?.Performed;
                    object ff_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fe_);
                    bool fg_ = ff_ is CqlInterval<CqlQuantity>;
                    return fg_;
                }

                if (er_())
                {
                    DataType fh_ = tuple_bvgardhyjgbgfxidntuflexa?.AnesthesiaProcedure?.Performed;
                    object fi_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fh_);
                    return (fi_ as CqlDateTime) as object;
                }
                else if (es_())
                {
                    DataType fj_ = tuple_bvgardhyjgbgfxidntuflexa?.AnesthesiaProcedure?.Performed;
                    object fk_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fj_);
                    return (fk_ as CqlInterval<CqlDateTime>) as object;
                }
                else if (et_())
                {
                    DataType fl_ = tuple_bvgardhyjgbgfxidntuflexa?.AnesthesiaProcedure?.Performed;
                    object fm_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fl_);
                    return (fm_ as CqlQuantity) as object;
                }
                else if (eu_())
                {
                    DataType fn_ = tuple_bvgardhyjgbgfxidntuflexa?.AnesthesiaProcedure?.Performed;
                    object fo_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fn_);
                    return (fo_ as CqlInterval<CqlQuantity>) as object;
                }
                else
                {
                    return null;
                };
            }

            CqlInterval<CqlDateTime> as_ = QICoreCommon_4_0_000.Instance.toInterval(context, ar_());
            CqlDateTime at_ = context.Operators.End(as_);
            CqlInterval<CqlDate> au_ = TJCOverall_8_25_000.Instance.calendarDayOfOrDayAfter(context, at_);
            bool? av_ = au_?.highClosed;
            CqlInterval<CqlDateTime> aw_ = context.Operators.Interval(af_, al_, aq_, av_);
            bool? ax_ = context.Operators.In<CqlDateTime>(z_, aw_, "day");
            bool? ay_ = context.Operators.And(y_, ax_);
            return ay_;
        }

        IEnumerable<(CqlTupleMetadata, Encounter QualifyingEncounterICU, Procedure AnesthesiaProcedure, object PatientRefusal)?> i_ = context.Operators.Where<(CqlTupleMetadata, Encounter QualifyingEncounterICU, Procedure AnesthesiaProcedure, object PatientRefusal)?>(g_, h_);
        Encounter j_((CqlTupleMetadata, Encounter QualifyingEncounterICU, Procedure AnesthesiaProcedure, object PatientRefusal)? tuple_bvgardhyjgbgfxidntuflexa) => tuple_bvgardhyjgbgfxidntuflexa?.QualifyingEncounterICU;
        IEnumerable<Encounter> k_ = context.Operators.Select<(CqlTupleMetadata, Encounter QualifyingEncounterICU, Procedure AnesthesiaProcedure, object PatientRefusal)?, Encounter>(i_, j_);
        IEnumerable<Encounter> l_ = context.Operators.Distinct<Encounter>(k_);
        return l_;
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

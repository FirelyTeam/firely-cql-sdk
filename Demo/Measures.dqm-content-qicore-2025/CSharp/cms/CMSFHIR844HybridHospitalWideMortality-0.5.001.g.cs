#nullable enable

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
[CqlLibrary("CMSFHIR844HybridHospitalWideMortality", "0.5.001")]
public partial class CMSFHIR844HybridHospitalWideMortality_0_5_001 : ILibrary, ISingleton<CMSFHIR844HybridHospitalWideMortality_0_5_001>
{
    #region ValueSets (13)

    [CqlValueSetDefinition("Bicarbonate lab test", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1045.139", valueSetVersion: null)]
    public CqlValueSet Bicarbonate_lab_test(CqlContext _) => _Bicarbonate_lab_test;
    private static readonly CqlValueSet _Bicarbonate_lab_test = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1045.139", null);

    [CqlValueSetDefinition("Creatinine lab test", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.666.5.2363", valueSetVersion: null)]
    public CqlValueSet Creatinine_lab_test(CqlContext _) => _Creatinine_lab_test;
    private static readonly CqlValueSet _Creatinine_lab_test = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.666.5.2363", null);

    [CqlValueSetDefinition("Emergency Department Visit", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.292", valueSetVersion: null)]
    public CqlValueSet Emergency_Department_Visit(CqlContext _) => _Emergency_Department_Visit;
    private static readonly CqlValueSet _Emergency_Department_Visit = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.292", null);

    [CqlValueSetDefinition("Encounter Inpatient", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.666.5.307", valueSetVersion: null)]
    public CqlValueSet Encounter_Inpatient(CqlContext _) => _Encounter_Inpatient;
    private static readonly CqlValueSet _Encounter_Inpatient = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.666.5.307", null);

    [CqlValueSetDefinition("Hematocrit lab test", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1045.114", valueSetVersion: null)]
    public CqlValueSet Hematocrit_lab_test(CqlContext _) => _Hematocrit_lab_test;
    private static readonly CqlValueSet _Hematocrit_lab_test = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1045.114", null);

    [CqlValueSetDefinition("Medicare Advantage payer", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1104.12", valueSetVersion: null)]
    public CqlValueSet Medicare_Advantage_payer(CqlContext _) => _Medicare_Advantage_payer;
    private static readonly CqlValueSet _Medicare_Advantage_payer = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1104.12", null);

    [CqlValueSetDefinition("Medicare FFS payer", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1104.10", valueSetVersion: null)]
    public CqlValueSet Medicare_FFS_payer(CqlContext _) => _Medicare_FFS_payer;
    private static readonly CqlValueSet _Medicare_FFS_payer = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1104.10", null);

    [CqlValueSetDefinition("Non Invasive Oxygen Therapy by Nasal Cannula or Mask", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1248.209", valueSetVersion: null)]
    public CqlValueSet Non_Invasive_Oxygen_Therapy_by_Nasal_Cannula_or_Mask(CqlContext _) => _Non_Invasive_Oxygen_Therapy_by_Nasal_Cannula_or_Mask;
    private static readonly CqlValueSet _Non_Invasive_Oxygen_Therapy_by_Nasal_Cannula_or_Mask = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1248.209", null);

    [CqlValueSetDefinition("Non Invasive Oxygen Therapy Device Codes", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1170.57", valueSetVersion: null)]
    public CqlValueSet Non_Invasive_Oxygen_Therapy_Device_Codes(CqlContext _) => _Non_Invasive_Oxygen_Therapy_Device_Codes;
    private static readonly CqlValueSet _Non_Invasive_Oxygen_Therapy_Device_Codes = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1170.57", null);

    [CqlValueSetDefinition("Oxygen Saturation by Pulse Oximetry", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1045.151", valueSetVersion: null)]
    public CqlValueSet Oxygen_Saturation_by_Pulse_Oximetry(CqlContext _) => _Oxygen_Saturation_by_Pulse_Oximetry;
    private static readonly CqlValueSet _Oxygen_Saturation_by_Pulse_Oximetry = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1045.151", null);

    [CqlValueSetDefinition("Platelet count lab test", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1045.127", valueSetVersion: null)]
    public CqlValueSet Platelet_count_lab_test(CqlContext _) => _Platelet_count_lab_test;
    private static readonly CqlValueSet _Platelet_count_lab_test = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1045.127", null);

    [CqlValueSetDefinition("Sodium lab test", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1045.119", valueSetVersion: null)]
    public CqlValueSet Sodium_lab_test(CqlContext _) => _Sodium_lab_test;
    private static readonly CqlValueSet _Sodium_lab_test = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1045.119", null);

    [CqlValueSetDefinition("White blood cells count lab test", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1045.129", valueSetVersion: null)]
    public CqlValueSet White_blood_cells_count_lab_test(CqlContext _) => _White_blood_cells_count_lab_test;
    private static readonly CqlValueSet _White_blood_cells_count_lab_test = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1045.129", null);

    #endregion ValueSets

    #region Codes (1)

    [CqlCodeDefinition("Systolic blood pressure", codeId: "8480-6", codeSystem: "http://loinc.org")]
    public CqlCode Systolic_blood_pressure(CqlContext _) => _Systolic_blood_pressure;
    private static readonly CqlCode _Systolic_blood_pressure = new CqlCode("8480-6", "http://loinc.org");

    #endregion Codes

    #region CodeSystems (1)

    [CqlCodeSystemDefinition("LOINC", codeSystemId: "http://loinc.org", codeSystemVersion: null)]
    public CqlCodeSystem LOINC(CqlContext _) => _LOINC;
    private static readonly CqlCodeSystem _LOINC =
      new CqlCodeSystem("http://loinc.org", null, [
          _Systolic_blood_pressure]);

    #endregion CodeSystems

    #region Parameters (1)

    [CqlParameterDefinition("Measurement Period")]
    public CqlInterval<CqlDateTime?>? Measurement_Period(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Measurement_Period, Measurement_Period_Compute);

    private const long _cacheIndex_Measurement_Period = 8194214586127820629L;

    private CqlInterval<CqlDateTime?>? Measurement_Period_Compute(CqlContext context)
    {
        CqlDateTime? a_ = context.Operators.DateTime(2026, 1, 1, 0, 0, 0, 0, 0.0m);
        CqlDateTime? b_ = context.Operators.DateTime(2027, 1, 1, 0, 0, 0, 0, 0.0m);
        CqlInterval<CqlDateTime?>? c_ = context.Operators.Interval(a_, b_, true, false);
        object? d_ = context.ResolveParameter("CMSFHIR844HybridHospitalWideMortality-0.5.001"!, ("Measurement Period")!, c_);
        return (CqlInterval<CqlDateTime?>?)d_;
    }


    #endregion Parameters

    #region Functions and Expressions (18)

    [CqlExpressionDefinition("Patient")]
    public Patient? Patient(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Patient, Patient_Compute);

    private const long _cacheIndex_Patient = -7320496347043068873L;

    private Patient? Patient_Compute(CqlContext context)
    {
        IEnumerable<Patient?>? a_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-patient"));
        Patient? b_ = context.Operators.SingletonFrom<Patient?>(a_);
        return b_;
    }


    [CqlExpressionDefinition("Inpatient Encounters")]
    public IEnumerable<Encounter?>? Inpatient_Encounters(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Inpatient_Encounters, Inpatient_Encounters_Compute);

    private const long _cacheIndex_Inpatient_Encounters = -8287851696712078710L;

    private IEnumerable<Encounter?>? Inpatient_Encounters_Compute(CqlContext context)
    {
        CqlValueSet? a_ = this.Encounter_Inpatient(context);
        IEnumerable<Encounter?>? b_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));

        bool? c_(Encounter? EncounterInpatient) {
            CqlValueSet? e_ = this.Medicare_FFS_payer(context);
            IEnumerable<Coverage?>? f_ = context.Operators.Retrieve<Coverage>(new RetrieveParameters(default, e_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-coverage"));
            CqlValueSet? g_ = this.Medicare_Advantage_payer(context);
            IEnumerable<Coverage?>? h_ = context.Operators.Retrieve<Coverage>(new RetrieveParameters(default, g_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-coverage"));
            IEnumerable<Coverage?>? i_ = context.Operators.Union<Coverage?>(f_, h_);

            bool? j_(Coverage? MedicarePayer) {
                CqlInterval<CqlDateTime?>? l_ = CQMCommon_4_1_000.Instance.hospitalizationWithObservationAndOutpatientSurgeryService(context, EncounterInpatient);
                int? m_ = CQMCommon_4_1_000.Instance.lengthInDays(context, l_);
                bool? n_ = context.Operators.Less(m_, 365);
                Code<Encounter.EncounterStatus>? o_ = EncounterInpatient?.StatusElement;
                Encounter.EncounterStatus? p_ = o_?.Value;
                Code<Encounter.EncounterStatus>? q_ = context.Operators.Convert<Code<Encounter.EncounterStatus>?>(p_);
                bool? r_ = context.Operators.Equal(q_, "finished");
                bool? s_ = context.Operators.And(n_, r_);
                Patient? t_ = this.Patient(context);
                Date? u_ = t_?.BirthDateElement;
                string? v_ = u_?.Value;
                CqlDate? w_ = context.Operators.ConvertStringToDate(v_);
                Period? x_ = EncounterInpatient?.Period;
                CqlInterval<CqlDateTime?>? y_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, x_);
                CqlDateTime? z_ = context.Operators.Start(y_);
                CqlDate? aa_ = context.Operators.DateFrom(z_);
                int? ab_ = context.Operators.CalculateAgeAt(w_, aa_, "year");
                CqlInterval<int?>? ac_ = context.Operators.Interval(65, 94, true, true);
                bool? ad_ = context.Operators.In<int?>(ab_, ac_, (string?)default);
                bool? ae_ = context.Operators.And(s_, ad_);
                CqlDateTime? af_ = context.Operators.End(y_);
                CqlInterval<CqlDateTime?>? ag_ = this.Measurement_Period(context);
                bool? ah_ = context.Operators.In<CqlDateTime?>(af_, ag_, "day");
                bool? ai_ = context.Operators.And(ae_, ah_);
                return ai_;
            }

            bool? k_ = context.Operators.WhereAny<Coverage?>(i_, j_);
            return k_;
        }

        IEnumerable<Encounter?>? d_ = context.Operators.Where<Encounter?>(b_, c_);
        return d_;
    }


    [CqlExpressionDefinition("Initial Population")]
    public IEnumerable<Encounter?>? Initial_Population(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Initial_Population, Initial_Population_Compute);

    private const long _cacheIndex_Initial_Population = -3847774137403444691L;

    private IEnumerable<Encounter?>? Initial_Population_Compute(CqlContext context)
    {
        IEnumerable<Encounter?>? a_ = this.Inpatient_Encounters(context);
        return a_;
    }


    [CqlExpressionDefinition("SDE Encounter With First Body Temperature")]
    public IEnumerable<(CqlTupleMetadata, string? EncounterId, CqlQuantity? FirstTemperatureResult, CqlDateTime? Timing)?>? SDE_Encounter_With_First_Body_Temperature(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_SDE_Encounter_With_First_Body_Temperature, SDE_Encounter_With_First_Body_Temperature_Compute);

    private const long _cacheIndex_SDE_Encounter_With_First_Body_Temperature = -7526006116561995512L;

    private IEnumerable<(CqlTupleMetadata, string? EncounterId, CqlQuantity? FirstTemperatureResult, CqlDateTime? Timing)?>? SDE_Encounter_With_First_Body_Temperature_Compute(CqlContext context)
    {
        IEnumerable<Encounter?>? a_ = this.Inpatient_Encounters(context);

        (CqlTupleMetadata, string? EncounterId, CqlQuantity? FirstTemperatureResult, CqlDateTime? Timing)? b_(Encounter? EncounterInpatient) {
            Id? d_ = EncounterInpatient?.IdElement;
            string? e_ = d_?.Value;
            IEnumerable<Observation?>? f_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/core/StructureDefinition/us-core-body-temperature"));

            bool? g_(Observation? Temperature) {
                DataType? w_ = Temperature?.Effective;
                object? x_ = FHIRHelpers_4_4_000.Instance.ToValue(context, w_);
                CqlDateTime? y_ = QICoreCommon_4_0_000.Instance.earliest(context, x_);
                CqlInterval<CqlDateTime?>? z_ = CQMCommon_4_1_000.Instance.hospitalizationWithObservationAndOutpatientSurgeryService(context, EncounterInpatient);
                bool? aa_ = context.Operators.In<CqlDateTime?>(y_, z_, (string?)default);
                Code<ObservationStatus>? ab_ = Temperature?.StatusElement;
                ObservationStatus? ac_ = ab_?.Value;
                string? ad_ = context.Operators.Convert<string?>(ac_);
                string?[]? ae_ = [
                    "final",
                    "amended",
                    "corrected",
                ];
                bool? af_ = context.Operators.In<string?>(ad_, (IEnumerable<string?>?)ae_);
                bool? ag_ = context.Operators.And(aa_, af_);
                DataType? ah_ = Temperature?.Value;
                CqlQuantity? ai_ = FHIRHelpers_4_4_000.Instance.ToQuantity(context, ah_ as Quantity);
                bool? aj_ = context.Operators.Not((bool?)(ai_ is null));
                bool? ak_ = context.Operators.And(ag_, aj_);
                return ak_;
            }

            IEnumerable<Observation?>? h_ = context.Operators.Where<Observation?>(f_, g_);

            object i_(Observation? @this) {
                DataType? al_ = @this?.Effective;
                object? am_ = FHIRHelpers_4_4_000.Instance.ToValue(context, al_);
                CqlDateTime? an_ = QICoreCommon_4_0_000.Instance.earliest(context, am_);
                return an_!;
            }

            IEnumerable<Observation?>? j_ = context.Operators.SortBy<Observation?>(h_, i_, System.ComponentModel.ListSortDirection.Ascending);
            Observation? k_ = context.Operators.First<Observation?>(j_!);
            DataType? l_ = k_?.Value;
            CqlQuantity? m_ = FHIRHelpers_4_4_000.Instance.ToQuantity(context, l_ as Quantity);

            bool? n_(Observation? Temperature) {
                DataType? ao_ = Temperature?.Effective;
                object? ap_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ao_);
                CqlDateTime? aq_ = QICoreCommon_4_0_000.Instance.earliest(context, ap_);
                CqlInterval<CqlDateTime?>? ar_ = CQMCommon_4_1_000.Instance.hospitalizationWithObservationAndOutpatientSurgeryService(context, EncounterInpatient);
                bool? as_ = context.Operators.In<CqlDateTime?>(aq_, ar_, (string?)default);
                Code<ObservationStatus>? at_ = Temperature?.StatusElement;
                ObservationStatus? au_ = at_?.Value;
                string? av_ = context.Operators.Convert<string?>(au_);
                string?[]? aw_ = [
                    "final",
                    "amended",
                    "corrected",
                ];
                bool? ax_ = context.Operators.In<string?>(av_, (IEnumerable<string?>?)aw_);
                bool? ay_ = context.Operators.And(as_, ax_);
                DataType? az_ = Temperature?.Value;
                CqlQuantity? ba_ = FHIRHelpers_4_4_000.Instance.ToQuantity(context, az_ as Quantity);
                bool? bb_ = context.Operators.Not((bool?)(ba_ is null));
                bool? bc_ = context.Operators.And(ay_, bb_);
                return bc_;
            }

            IEnumerable<Observation?>? o_ = context.Operators.Where<Observation?>(f_, n_);

            object p_(Observation? @this) {
                DataType? bd_ = @this?.Effective;
                object? be_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bd_);
                CqlDateTime? bf_ = QICoreCommon_4_0_000.Instance.earliest(context, be_);
                return bf_!;
            }

            IEnumerable<Observation?>? q_ = context.Operators.SortBy<Observation?>(o_, p_, System.ComponentModel.ListSortDirection.Ascending);
            Observation? r_ = context.Operators.First<Observation?>(q_!);
            DataType? s_ = r_?.Effective;
            object? t_ = FHIRHelpers_4_4_000.Instance.ToValue(context, s_);
            CqlDateTime? u_ = QICoreCommon_4_0_000.Instance.earliest(context, t_);
            (CqlTupleMetadata, string? EncounterId, CqlQuantity? FirstTemperatureResult, CqlDateTime? Timing)? v_ = (CqlTupleMetadata_GIbILVAdXLLNYBgcQIEiUiKaK, e_, m_ as CqlQuantity, u_);
            return v_;
        }

        IEnumerable<(CqlTupleMetadata, string? EncounterId, CqlQuantity? FirstTemperatureResult, CqlDateTime? Timing)?>? c_ = context.Operators.SelectDistinct<Encounter?, (CqlTupleMetadata, string? EncounterId, CqlQuantity? FirstTemperatureResult, CqlDateTime? Timing)?>(a_, b_);
        return c_;
    }


    [CqlExpressionDefinition("SDE Encounter With First Heart Rate")]
    public IEnumerable<(CqlTupleMetadata, string? EncounterId, CqlQuantity? FirstHeartRateResult, CqlDateTime? Timing)?>? SDE_Encounter_With_First_Heart_Rate(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_SDE_Encounter_With_First_Heart_Rate, SDE_Encounter_With_First_Heart_Rate_Compute);

    private const long _cacheIndex_SDE_Encounter_With_First_Heart_Rate = 139345589104903829L;

    private IEnumerable<(CqlTupleMetadata, string? EncounterId, CqlQuantity? FirstHeartRateResult, CqlDateTime? Timing)?>? SDE_Encounter_With_First_Heart_Rate_Compute(CqlContext context)
    {
        IEnumerable<Encounter?>? a_ = this.Inpatient_Encounters(context);

        (CqlTupleMetadata, string? EncounterId, CqlQuantity? FirstHeartRateResult, CqlDateTime? Timing)? b_(Encounter? EncounterInpatient) {
            Id? d_ = EncounterInpatient?.IdElement;
            string? e_ = d_?.Value;
            IEnumerable<Observation?>? f_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/core/StructureDefinition/us-core-heart-rate"));

            bool? g_(Observation? HeartRate) {
                DataType? w_ = HeartRate?.Effective;
                object? x_ = FHIRHelpers_4_4_000.Instance.ToValue(context, w_);
                CqlDateTime? y_ = QICoreCommon_4_0_000.Instance.earliest(context, x_);
                CqlInterval<CqlDateTime?>? z_ = CQMCommon_4_1_000.Instance.hospitalizationWithObservationAndOutpatientSurgeryService(context, EncounterInpatient);
                bool? aa_ = context.Operators.In<CqlDateTime?>(y_, z_, (string?)default);
                Code<ObservationStatus>? ab_ = HeartRate?.StatusElement;
                ObservationStatus? ac_ = ab_?.Value;
                string? ad_ = context.Operators.Convert<string?>(ac_);
                string?[]? ae_ = [
                    "final",
                    "amended",
                    "corrected",
                ];
                bool? af_ = context.Operators.In<string?>(ad_, (IEnumerable<string?>?)ae_);
                bool? ag_ = context.Operators.And(aa_, af_);
                DataType? ah_ = HeartRate?.Value;
                CqlQuantity? ai_ = FHIRHelpers_4_4_000.Instance.ToQuantity(context, ah_ as Quantity);
                bool? aj_ = context.Operators.Not((bool?)(ai_ is null));
                bool? ak_ = context.Operators.And(ag_, aj_);
                return ak_;
            }

            IEnumerable<Observation?>? h_ = context.Operators.Where<Observation?>(f_, g_);

            object i_(Observation? @this) {
                DataType? al_ = @this?.Effective;
                object? am_ = FHIRHelpers_4_4_000.Instance.ToValue(context, al_);
                CqlDateTime? an_ = QICoreCommon_4_0_000.Instance.earliest(context, am_);
                return an_!;
            }

            IEnumerable<Observation?>? j_ = context.Operators.SortBy<Observation?>(h_, i_, System.ComponentModel.ListSortDirection.Ascending);
            Observation? k_ = context.Operators.First<Observation?>(j_!);
            DataType? l_ = k_?.Value;
            CqlQuantity? m_ = FHIRHelpers_4_4_000.Instance.ToQuantity(context, l_ as Quantity);

            bool? n_(Observation? HeartRate) {
                DataType? ao_ = HeartRate?.Effective;
                object? ap_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ao_);
                CqlDateTime? aq_ = QICoreCommon_4_0_000.Instance.earliest(context, ap_);
                CqlInterval<CqlDateTime?>? ar_ = CQMCommon_4_1_000.Instance.hospitalizationWithObservationAndOutpatientSurgeryService(context, EncounterInpatient);
                bool? as_ = context.Operators.In<CqlDateTime?>(aq_, ar_, (string?)default);
                Code<ObservationStatus>? at_ = HeartRate?.StatusElement;
                ObservationStatus? au_ = at_?.Value;
                string? av_ = context.Operators.Convert<string?>(au_);
                string?[]? aw_ = [
                    "final",
                    "amended",
                    "corrected",
                ];
                bool? ax_ = context.Operators.In<string?>(av_, (IEnumerable<string?>?)aw_);
                bool? ay_ = context.Operators.And(as_, ax_);
                DataType? az_ = HeartRate?.Value;
                CqlQuantity? ba_ = FHIRHelpers_4_4_000.Instance.ToQuantity(context, az_ as Quantity);
                bool? bb_ = context.Operators.Not((bool?)(ba_ is null));
                bool? bc_ = context.Operators.And(ay_, bb_);
                return bc_;
            }

            IEnumerable<Observation?>? o_ = context.Operators.Where<Observation?>(f_, n_);

            object p_(Observation? @this) {
                DataType? bd_ = @this?.Effective;
                object? be_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bd_);
                CqlDateTime? bf_ = QICoreCommon_4_0_000.Instance.earliest(context, be_);
                return bf_!;
            }

            IEnumerable<Observation?>? q_ = context.Operators.SortBy<Observation?>(o_, p_, System.ComponentModel.ListSortDirection.Ascending);
            Observation? r_ = context.Operators.First<Observation?>(q_!);
            DataType? s_ = r_?.Effective;
            object? t_ = FHIRHelpers_4_4_000.Instance.ToValue(context, s_);
            CqlDateTime? u_ = QICoreCommon_4_0_000.Instance.earliest(context, t_);
            (CqlTupleMetadata, string? EncounterId, CqlQuantity? FirstHeartRateResult, CqlDateTime? Timing)? v_ = (CqlTupleMetadata_DhbJAfCiKIAGYKTjJXYGSKECQ, e_, m_ as CqlQuantity, u_);
            return v_;
        }

        IEnumerable<(CqlTupleMetadata, string? EncounterId, CqlQuantity? FirstHeartRateResult, CqlDateTime? Timing)?>? c_ = context.Operators.SelectDistinct<Encounter?, (CqlTupleMetadata, string? EncounterId, CqlQuantity? FirstHeartRateResult, CqlDateTime? Timing)?>(a_, b_);
        return c_;
    }


    [CqlExpressionDefinition("SDE Encounter With First Oxygen Saturation")]
    public IEnumerable<(CqlTupleMetadata, string? EncounterId, CqlQuantity? FirstOxygenSatResult, CqlDateTime? Timing)?>? SDE_Encounter_With_First_Oxygen_Saturation(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_SDE_Encounter_With_First_Oxygen_Saturation, SDE_Encounter_With_First_Oxygen_Saturation_Compute);

    private const long _cacheIndex_SDE_Encounter_With_First_Oxygen_Saturation = -8371025803682788439L;

    private IEnumerable<(CqlTupleMetadata, string? EncounterId, CqlQuantity? FirstOxygenSatResult, CqlDateTime? Timing)?>? SDE_Encounter_With_First_Oxygen_Saturation_Compute(CqlContext context)
    {
        IEnumerable<Encounter?>? a_ = this.Inpatient_Encounters(context);

        (CqlTupleMetadata, string? EncounterId, CqlQuantity? FirstOxygenSatResult, CqlDateTime? Timing)? b_(Encounter? EncounterInpatient) {
            Id? d_ = EncounterInpatient?.IdElement;
            string? e_ = d_?.Value;
            CqlValueSet? f_ = this.Oxygen_Saturation_by_Pulse_Oximetry(context);
            IEnumerable<Observation?>? g_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, f_, default, "http://hl7.org/fhir/us/core/StructureDefinition/us-core-pulse-oximetry"));

            bool? h_(Observation? O2Saturation) {
                DataType? x_ = O2Saturation?.Effective;
                object? y_ = FHIRHelpers_4_4_000.Instance.ToValue(context, x_);
                CqlDateTime? z_ = QICoreCommon_4_0_000.Instance.earliest(context, y_);
                CqlInterval<CqlDateTime?>? aa_ = CQMCommon_4_1_000.Instance.hospitalizationWithObservationAndOutpatientSurgeryService(context, EncounterInpatient);
                bool? ab_ = context.Operators.In<CqlDateTime?>(z_, aa_, (string?)default);
                Code<ObservationStatus>? ac_ = O2Saturation?.StatusElement;
                ObservationStatus? ad_ = ac_?.Value;
                string? ae_ = context.Operators.Convert<string?>(ad_);
                string?[]? af_ = [
                    "final",
                    "amended",
                    "corrected",
                ];
                bool? ag_ = context.Operators.In<string?>(ae_, (IEnumerable<string?>?)af_);
                bool? ah_ = context.Operators.And(ab_, ag_);
                DataType? ai_ = O2Saturation?.Value;
                CqlQuantity? aj_ = FHIRHelpers_4_4_000.Instance.ToQuantity(context, ai_ as Quantity);
                bool? ak_ = context.Operators.Not((bool?)(aj_ is null));
                bool? al_ = context.Operators.And(ah_, ak_);
                return al_;
            }

            IEnumerable<Observation?>? i_ = context.Operators.Where<Observation?>(g_, h_);

            object j_(Observation? @this) {
                DataType? am_ = @this?.Effective;
                object? an_ = FHIRHelpers_4_4_000.Instance.ToValue(context, am_);
                CqlDateTime? ao_ = QICoreCommon_4_0_000.Instance.earliest(context, an_);
                return ao_!;
            }

            IEnumerable<Observation?>? k_ = context.Operators.SortBy<Observation?>(i_, j_, System.ComponentModel.ListSortDirection.Ascending);
            Observation? l_ = context.Operators.First<Observation?>(k_!);
            DataType? m_ = l_?.Value;
            CqlQuantity? n_ = FHIRHelpers_4_4_000.Instance.ToQuantity(context, m_ as Quantity);

            bool? o_(Observation? O2Saturation) {
                DataType? ap_ = O2Saturation?.Effective;
                object? aq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ap_);
                CqlDateTime? ar_ = QICoreCommon_4_0_000.Instance.earliest(context, aq_);
                CqlInterval<CqlDateTime?>? as_ = CQMCommon_4_1_000.Instance.hospitalizationWithObservationAndOutpatientSurgeryService(context, EncounterInpatient);
                bool? at_ = context.Operators.In<CqlDateTime?>(ar_, as_, (string?)default);
                Code<ObservationStatus>? au_ = O2Saturation?.StatusElement;
                ObservationStatus? av_ = au_?.Value;
                string? aw_ = context.Operators.Convert<string?>(av_);
                string?[]? ax_ = [
                    "final",
                    "amended",
                    "corrected",
                ];
                bool? ay_ = context.Operators.In<string?>(aw_, (IEnumerable<string?>?)ax_);
                bool? az_ = context.Operators.And(at_, ay_);
                DataType? ba_ = O2Saturation?.Value;
                CqlQuantity? bb_ = FHIRHelpers_4_4_000.Instance.ToQuantity(context, ba_ as Quantity);
                bool? bc_ = context.Operators.Not((bool?)(bb_ is null));
                bool? bd_ = context.Operators.And(az_, bc_);
                return bd_;
            }

            IEnumerable<Observation?>? p_ = context.Operators.Where<Observation?>(g_, o_);

            object q_(Observation? @this) {
                DataType? be_ = @this?.Effective;
                object? bf_ = FHIRHelpers_4_4_000.Instance.ToValue(context, be_);
                CqlDateTime? bg_ = QICoreCommon_4_0_000.Instance.earliest(context, bf_);
                return bg_!;
            }

            IEnumerable<Observation?>? r_ = context.Operators.SortBy<Observation?>(p_, q_, System.ComponentModel.ListSortDirection.Ascending);
            Observation? s_ = context.Operators.First<Observation?>(r_!);
            DataType? t_ = s_?.Effective;
            object? u_ = FHIRHelpers_4_4_000.Instance.ToValue(context, t_);
            CqlDateTime? v_ = QICoreCommon_4_0_000.Instance.earliest(context, u_);
            (CqlTupleMetadata, string? EncounterId, CqlQuantity? FirstOxygenSatResult, CqlDateTime? Timing)? w_ = (CqlTupleMetadata_FdREYEdHOZIcMCNYCRFJYJReA, e_, n_ as CqlQuantity, v_);
            return w_;
        }

        IEnumerable<(CqlTupleMetadata, string? EncounterId, CqlQuantity? FirstOxygenSatResult, CqlDateTime? Timing)?>? c_ = context.Operators.SelectDistinct<Encounter?, (CqlTupleMetadata, string? EncounterId, CqlQuantity? FirstOxygenSatResult, CqlDateTime? Timing)?>(a_, b_);
        return c_;
    }


    [CqlExpressionDefinition("SDE Encounter With First Systolic Blood Pressure")]
    public IEnumerable<(CqlTupleMetadata, string? EncounterId, IEnumerable<CqlQuantity?>? FirstSBPResult, CqlDateTime? Timing)?>? SDE_Encounter_With_First_Systolic_Blood_Pressure(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_SDE_Encounter_With_First_Systolic_Blood_Pressure, SDE_Encounter_With_First_Systolic_Blood_Pressure_Compute);

    private const long _cacheIndex_SDE_Encounter_With_First_Systolic_Blood_Pressure = -3207799827161922512L;

    private IEnumerable<(CqlTupleMetadata, string? EncounterId, IEnumerable<CqlQuantity?>? FirstSBPResult, CqlDateTime? Timing)?>? SDE_Encounter_With_First_Systolic_Blood_Pressure_Compute(CqlContext context)
    {
        IEnumerable<Encounter?>? a_ = this.Inpatient_Encounters(context);

        (CqlTupleMetadata, string? EncounterId, IEnumerable<CqlQuantity?>? FirstSBPResult, CqlDateTime? Timing)? b_(Encounter? EncounterInpatient) {
            Id? d_ = EncounterInpatient?.IdElement;
            string? e_ = d_?.Value;
            IEnumerable<Observation?>? f_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/core/StructureDefinition/us-core-blood-pressure"));

            bool? g_(Observation? BP) {
                DataType? z_ = BP?.Effective;
                object? aa_ = FHIRHelpers_4_4_000.Instance.ToValue(context, z_);
                CqlDateTime? ab_ = QICoreCommon_4_0_000.Instance.earliest(context, aa_);
                CqlInterval<CqlDateTime?>? ac_ = CQMCommon_4_1_000.Instance.hospitalizationWithObservationAndOutpatientSurgeryService(context, EncounterInpatient);
                bool? ad_ = context.Operators.In<CqlDateTime?>(ab_, ac_, (string?)default);
                Code<ObservationStatus>? ae_ = BP?.StatusElement;
                ObservationStatus? af_ = ae_?.Value;
                string? ag_ = context.Operators.Convert<string?>(af_);
                string?[]? ah_ = [
                    "final",
                    "amended",
                    "corrected",
                ];
                bool? ai_ = context.Operators.In<string?>(ag_, (IEnumerable<string?>?)ah_);
                bool? aj_ = context.Operators.And(ad_, ai_);
                List<Observation.ComponentComponent>? ak_ = BP?.Component;

                bool? al_(Observation.ComponentComponent? @this) {
                    DataType? aq_ = @this?.Value;
                    object? ar_ = FHIRHelpers_4_4_000.Instance.ToValue(context, aq_);
                    bool? as_ = context.Operators.Not((bool?)(ar_ is null));
                    return as_;
                }


                object am_(Observation.ComponentComponent? @this) {
                    DataType? at_ = @this?.Value;
                    object? au_ = FHIRHelpers_4_4_000.Instance.ToValue(context, at_);
                    return au_!;
                }

                IEnumerable<object?>? an_ = context.Operators.WhereSelect<Observation.ComponentComponent?, object?>((IEnumerable<Observation.ComponentComponent?>?)ak_, al_, am_);
                bool? ao_ = context.Operators.Not((bool?)(an_ is null));
                bool? ap_ = context.Operators.And(aj_, ao_);
                return ap_;
            }

            IEnumerable<Observation?>? h_ = context.Operators.Where<Observation?>(f_, g_);

            object i_(Observation? @this) {
                DataType? av_ = @this?.Effective;
                object? aw_ = FHIRHelpers_4_4_000.Instance.ToValue(context, av_);
                CqlDateTime? ax_ = QICoreCommon_4_0_000.Instance.earliest(context, aw_);
                return ax_!;
            }

            IEnumerable<Observation?>? j_ = context.Operators.SortBy<Observation?>(h_, i_, System.ComponentModel.ListSortDirection.Ascending);
            Observation? k_ = context.Operators.First<Observation?>(j_!);
            List<Observation.ComponentComponent>? l_ = k_?.Component;

            bool? m_(Observation.ComponentComponent? C) {
                CodeableConcept? ay_ = C?.Code;
                CqlConcept? az_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, ay_);
                CqlCode? ba_ = this.Systolic_blood_pressure(context);
                CqlConcept? bb_ = context.Operators.ConvertCodeToConcept(ba_);
                bool? bc_ = context.Operators.Equivalent(az_, bb_);
                return bc_;
            }


            CqlQuantity? n_(Observation.ComponentComponent? C) {
                DataType? bd_ = C?.Value;
                object? be_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bd_);
                return be_ as CqlQuantity;
            }

            IEnumerable<CqlQuantity?>? o_ = context.Operators.WhereSelect<Observation.ComponentComponent?, CqlQuantity?>((IEnumerable<Observation.ComponentComponent?>?)l_, m_, n_);
            IEnumerable<CqlQuantity?>? p_ = context.Operators.Distinct<CqlQuantity?>(o_!);

            bool? q_(Observation? BP) {
                DataType? bf_ = BP?.Effective;
                object? bg_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bf_);
                CqlDateTime? bh_ = QICoreCommon_4_0_000.Instance.earliest(context, bg_);
                CqlInterval<CqlDateTime?>? bi_ = CQMCommon_4_1_000.Instance.hospitalizationWithObservationAndOutpatientSurgeryService(context, EncounterInpatient);
                bool? bj_ = context.Operators.In<CqlDateTime?>(bh_, bi_, (string?)default);
                Code<ObservationStatus>? bk_ = BP?.StatusElement;
                ObservationStatus? bl_ = bk_?.Value;
                string? bm_ = context.Operators.Convert<string?>(bl_);
                string?[]? bn_ = [
                    "final",
                    "amended",
                    "corrected",
                ];
                bool? bo_ = context.Operators.In<string?>(bm_, (IEnumerable<string?>?)bn_);
                bool? bp_ = context.Operators.And(bj_, bo_);
                List<Observation.ComponentComponent>? bq_ = BP?.Component;

                bool? br_(Observation.ComponentComponent? @this) {
                    DataType? bw_ = @this?.Value;
                    object? bx_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bw_);
                    bool? by_ = context.Operators.Not((bool?)(bx_ is null));
                    return by_;
                }


                object bs_(Observation.ComponentComponent? @this) {
                    DataType? bz_ = @this?.Value;
                    object? ca_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bz_);
                    return ca_!;
                }

                IEnumerable<object?>? bt_ = context.Operators.WhereSelect<Observation.ComponentComponent?, object?>((IEnumerable<Observation.ComponentComponent?>?)bq_, br_, bs_);
                bool? bu_ = context.Operators.Not((bool?)(bt_ is null));
                bool? bv_ = context.Operators.And(bp_, bu_);
                return bv_;
            }

            IEnumerable<Observation?>? r_ = context.Operators.Where<Observation?>(f_, q_);

            object s_(Observation? @this) {
                DataType? cb_ = @this?.Effective;
                object? cc_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cb_);
                CqlDateTime? cd_ = QICoreCommon_4_0_000.Instance.earliest(context, cc_);
                return cd_!;
            }

            IEnumerable<Observation?>? t_ = context.Operators.SortBy<Observation?>(r_, s_, System.ComponentModel.ListSortDirection.Ascending);
            Observation? u_ = context.Operators.First<Observation?>(t_!);
            DataType? v_ = u_?.Effective;
            object? w_ = FHIRHelpers_4_4_000.Instance.ToValue(context, v_);
            CqlDateTime? x_ = QICoreCommon_4_0_000.Instance.earliest(context, w_);
            (CqlTupleMetadata, string? EncounterId, IEnumerable<CqlQuantity?>? FirstSBPResult, CqlDateTime? Timing)? y_ = (CqlTupleMetadata_FjSKXeIESORPNbRGajibMfUaK, e_, p_, x_);
            return y_;
        }

        IEnumerable<(CqlTupleMetadata, string? EncounterId, IEnumerable<CqlQuantity?>? FirstSBPResult, CqlDateTime? Timing)?>? c_ = context.Operators.SelectDistinct<Encounter?, (CqlTupleMetadata, string? EncounterId, IEnumerable<CqlQuantity?>? FirstSBPResult, CqlDateTime? Timing)?>(a_, b_);
        return c_;
    }


    [CqlExpressionDefinition("SDE Encounter With First Bicarbonate Lab Test")]
    public IEnumerable<(CqlTupleMetadata, string? EncounterId, CqlQuantity? FirstBicarbonateResult, CqlDateTime? Timing)?>? SDE_Encounter_With_First_Bicarbonate_Lab_Test(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_SDE_Encounter_With_First_Bicarbonate_Lab_Test, SDE_Encounter_With_First_Bicarbonate_Lab_Test_Compute);

    private const long _cacheIndex_SDE_Encounter_With_First_Bicarbonate_Lab_Test = -5916718293760283523L;

    private IEnumerable<(CqlTupleMetadata, string? EncounterId, CqlQuantity? FirstBicarbonateResult, CqlDateTime? Timing)?>? SDE_Encounter_With_First_Bicarbonate_Lab_Test_Compute(CqlContext context)
    {
        IEnumerable<Encounter?>? a_ = this.Inpatient_Encounters(context);

        (CqlTupleMetadata, string? EncounterId, CqlQuantity? FirstBicarbonateResult, CqlDateTime? Timing)? b_(Encounter? EncounterInpatient) {
            Id? d_ = EncounterInpatient?.IdElement;
            string? e_ = d_?.Value;
            CqlValueSet? f_ = this.Bicarbonate_lab_test(context);
            IEnumerable<Observation?>? g_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, f_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation-lab"));

            bool? h_(Observation? BicarbonateLab) {
                object? x_;
                DataType? al_ = BicarbonateLab?.Effective;
                object? am_ = FHIRHelpers_4_4_000.Instance.ToValue(context, al_);
                bool an_ = am_ is CqlDateTime;
                if (an_)
                {
                    DataType? ao_ = BicarbonateLab?.Effective;
                    object? ap_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ao_);
                    x_ = ap_ as CqlDateTime;
                }
                else
                {
                    DataType? aq_ = BicarbonateLab?.Effective;
                    object? ar_ = FHIRHelpers_4_4_000.Instance.ToValue(context, aq_);
                    bool as_ = ar_ is CqlDateTime;
                    if (as_)
                    {
                        DataType? at_ = BicarbonateLab?.Effective;
                        object? au_ = FHIRHelpers_4_4_000.Instance.ToValue(context, at_);
                        x_ = au_ as CqlDateTime;
                    }
                    else
                    {
                        DataType? av_ = BicarbonateLab?.Effective;
                        object? aw_ = FHIRHelpers_4_4_000.Instance.ToValue(context, av_);
                        bool ax_ = aw_ is CqlInterval<CqlDateTime>;
                        if (ax_)
                        {
                            DataType? ay_ = BicarbonateLab?.Effective;
                            object? az_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ay_);
                            x_ = az_ as CqlInterval<CqlDateTime?>;
                        }
                        else
                        {
                            x_ = null;
                        }
                    }
                }
                CqlDateTime? y_ = QICoreCommon_4_0_000.Instance.earliest(context, x_);
                CqlInterval<CqlDateTime?>? z_ = CQMCommon_4_1_000.Instance.hospitalizationWithObservationAndOutpatientSurgeryService(context, EncounterInpatient);
                bool? aa_ = context.Operators.In<CqlDateTime?>(y_, z_, (string?)default);
                Code<ObservationStatus>? ab_ = BicarbonateLab?.StatusElement;
                ObservationStatus? ac_ = ab_?.Value;
                string? ad_ = context.Operators.Convert<string?>(ac_);
                string?[]? ae_ = [
                    "final",
                    "amended",
                    "corrected",
                ];
                bool? af_ = context.Operators.In<string?>(ad_, (IEnumerable<string?>?)ae_);
                bool? ag_ = context.Operators.And(aa_, af_);
                DataType? ah_ = BicarbonateLab?.Value;
                object? ai_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ah_);
                bool? aj_ = context.Operators.Not((bool?)(ai_ is null));
                bool? ak_ = context.Operators.And(ag_, aj_);
                return ak_;
            }

            IEnumerable<Observation?>? i_ = context.Operators.Where<Observation?>(g_, h_);

            object j_(Observation? @this) {
                Instant? ba_ = @this?.IssuedElement;
                DateTimeOffset? bb_ = ba_?.Value;
                CqlDateTime? bc_ = context.Operators.Convert<CqlDateTime?>(bb_);
                CqlDateTime? bd_ = QICoreCommon_4_0_000.Instance.earliest(context, bc_);
                return bd_!;
            }

            IEnumerable<Observation?>? k_ = context.Operators.SortBy<Observation?>(i_, j_, System.ComponentModel.ListSortDirection.Ascending);
            Observation? l_ = context.Operators.First<Observation?>(k_!);
            DataType? m_ = l_?.Value;
            object? n_ = FHIRHelpers_4_4_000.Instance.ToValue(context, m_);

            bool? o_(Observation? BicarbonateLab) {
                object? be_;
                DataType? bs_ = BicarbonateLab?.Effective;
                object? bt_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bs_);
                bool bu_ = bt_ is CqlDateTime;
                if (bu_)
                {
                    DataType? bv_ = BicarbonateLab?.Effective;
                    object? bw_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bv_);
                    be_ = bw_ as CqlDateTime;
                }
                else
                {
                    DataType? bx_ = BicarbonateLab?.Effective;
                    object? by_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bx_);
                    bool bz_ = by_ is CqlDateTime;
                    if (bz_)
                    {
                        DataType? ca_ = BicarbonateLab?.Effective;
                        object? cb_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ca_);
                        be_ = cb_ as CqlDateTime;
                    }
                    else
                    {
                        DataType? cc_ = BicarbonateLab?.Effective;
                        object? cd_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cc_);
                        bool ce_ = cd_ is CqlInterval<CqlDateTime>;
                        if (ce_)
                        {
                            DataType? cf_ = BicarbonateLab?.Effective;
                            object? cg_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cf_);
                            be_ = cg_ as CqlInterval<CqlDateTime?>;
                        }
                        else
                        {
                            be_ = null;
                        }
                    }
                }
                CqlDateTime? bf_ = QICoreCommon_4_0_000.Instance.earliest(context, be_);
                CqlInterval<CqlDateTime?>? bg_ = CQMCommon_4_1_000.Instance.hospitalizationWithObservationAndOutpatientSurgeryService(context, EncounterInpatient);
                bool? bh_ = context.Operators.In<CqlDateTime?>(bf_, bg_, (string?)default);
                Code<ObservationStatus>? bi_ = BicarbonateLab?.StatusElement;
                ObservationStatus? bj_ = bi_?.Value;
                string? bk_ = context.Operators.Convert<string?>(bj_);
                string?[]? bl_ = [
                    "final",
                    "amended",
                    "corrected",
                ];
                bool? bm_ = context.Operators.In<string?>(bk_, (IEnumerable<string?>?)bl_);
                bool? bn_ = context.Operators.And(bh_, bm_);
                DataType? bo_ = BicarbonateLab?.Value;
                object? bp_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bo_);
                bool? bq_ = context.Operators.Not((bool?)(bp_ is null));
                bool? br_ = context.Operators.And(bn_, bq_);
                return br_;
            }

            IEnumerable<Observation?>? p_ = context.Operators.Where<Observation?>(g_, o_);

            object q_(Observation? @this) {
                Instant? ch_ = @this?.IssuedElement;
                DateTimeOffset? ci_ = ch_?.Value;
                CqlDateTime? cj_ = context.Operators.Convert<CqlDateTime?>(ci_);
                CqlDateTime? ck_ = QICoreCommon_4_0_000.Instance.earliest(context, cj_);
                return ck_!;
            }

            IEnumerable<Observation?>? r_ = context.Operators.SortBy<Observation?>(p_, q_, System.ComponentModel.ListSortDirection.Ascending);
            Observation? s_ = context.Operators.First<Observation?>(r_!);
            Instant? t_ = s_?.IssuedElement;
            DateTimeOffset? u_ = t_?.Value;
            CqlDateTime? v_ = context.Operators.Convert<CqlDateTime?>(u_);
            (CqlTupleMetadata, string? EncounterId, CqlQuantity? FirstBicarbonateResult, CqlDateTime? Timing)? w_ = (CqlTupleMetadata_GbUHPXXHScejjXWhcHJFQQifQ, e_, n_ as CqlQuantity, v_);
            return w_;
        }

        IEnumerable<(CqlTupleMetadata, string? EncounterId, CqlQuantity? FirstBicarbonateResult, CqlDateTime? Timing)?>? c_ = context.Operators.SelectDistinct<Encounter?, (CqlTupleMetadata, string? EncounterId, CqlQuantity? FirstBicarbonateResult, CqlDateTime? Timing)?>(a_, b_);
        return c_;
    }


    [CqlExpressionDefinition("SDE Encounter With First Creatinine Lab Test")]
    public IEnumerable<(CqlTupleMetadata, string? EncounterId, CqlQuantity? FirstCreatinineResult, CqlDateTime? Timing)?>? SDE_Encounter_With_First_Creatinine_Lab_Test(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_SDE_Encounter_With_First_Creatinine_Lab_Test, SDE_Encounter_With_First_Creatinine_Lab_Test_Compute);

    private const long _cacheIndex_SDE_Encounter_With_First_Creatinine_Lab_Test = -5779842121506852161L;

    private IEnumerable<(CqlTupleMetadata, string? EncounterId, CqlQuantity? FirstCreatinineResult, CqlDateTime? Timing)?>? SDE_Encounter_With_First_Creatinine_Lab_Test_Compute(CqlContext context)
    {
        IEnumerable<Encounter?>? a_ = this.Inpatient_Encounters(context);

        (CqlTupleMetadata, string? EncounterId, CqlQuantity? FirstCreatinineResult, CqlDateTime? Timing)? b_(Encounter? EncounterInpatient) {
            Id? d_ = EncounterInpatient?.IdElement;
            string? e_ = d_?.Value;
            CqlValueSet? f_ = this.Creatinine_lab_test(context);
            IEnumerable<Observation?>? g_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, f_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation-lab"));

            bool? h_(Observation? CreatinineLab) {
                object? x_;
                DataType? al_ = CreatinineLab?.Effective;
                object? am_ = FHIRHelpers_4_4_000.Instance.ToValue(context, al_);
                bool an_ = am_ is CqlDateTime;
                if (an_)
                {
                    DataType? ao_ = CreatinineLab?.Effective;
                    object? ap_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ao_);
                    x_ = ap_ as CqlDateTime;
                }
                else
                {
                    DataType? aq_ = CreatinineLab?.Effective;
                    object? ar_ = FHIRHelpers_4_4_000.Instance.ToValue(context, aq_);
                    bool as_ = ar_ is CqlDateTime;
                    if (as_)
                    {
                        DataType? at_ = CreatinineLab?.Effective;
                        object? au_ = FHIRHelpers_4_4_000.Instance.ToValue(context, at_);
                        x_ = au_ as CqlDateTime;
                    }
                    else
                    {
                        DataType? av_ = CreatinineLab?.Effective;
                        object? aw_ = FHIRHelpers_4_4_000.Instance.ToValue(context, av_);
                        bool ax_ = aw_ is CqlInterval<CqlDateTime>;
                        if (ax_)
                        {
                            DataType? ay_ = CreatinineLab?.Effective;
                            object? az_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ay_);
                            x_ = az_ as CqlInterval<CqlDateTime?>;
                        }
                        else
                        {
                            x_ = null;
                        }
                    }
                }
                CqlDateTime? y_ = QICoreCommon_4_0_000.Instance.earliest(context, x_);
                CqlInterval<CqlDateTime?>? z_ = CQMCommon_4_1_000.Instance.hospitalizationWithObservationAndOutpatientSurgeryService(context, EncounterInpatient);
                bool? aa_ = context.Operators.In<CqlDateTime?>(y_, z_, (string?)default);
                Code<ObservationStatus>? ab_ = CreatinineLab?.StatusElement;
                ObservationStatus? ac_ = ab_?.Value;
                string? ad_ = context.Operators.Convert<string?>(ac_);
                string?[]? ae_ = [
                    "final",
                    "amended",
                    "corrected",
                ];
                bool? af_ = context.Operators.In<string?>(ad_, (IEnumerable<string?>?)ae_);
                bool? ag_ = context.Operators.And(aa_, af_);
                DataType? ah_ = CreatinineLab?.Value;
                object? ai_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ah_);
                bool? aj_ = context.Operators.Not((bool?)(ai_ is null));
                bool? ak_ = context.Operators.And(ag_, aj_);
                return ak_;
            }

            IEnumerable<Observation?>? i_ = context.Operators.Where<Observation?>(g_, h_);

            object j_(Observation? @this) {
                Instant? ba_ = @this?.IssuedElement;
                DateTimeOffset? bb_ = ba_?.Value;
                CqlDateTime? bc_ = context.Operators.Convert<CqlDateTime?>(bb_);
                CqlDateTime? bd_ = QICoreCommon_4_0_000.Instance.earliest(context, bc_);
                return bd_!;
            }

            IEnumerable<Observation?>? k_ = context.Operators.SortBy<Observation?>(i_, j_, System.ComponentModel.ListSortDirection.Ascending);
            Observation? l_ = context.Operators.First<Observation?>(k_!);
            DataType? m_ = l_?.Value;
            object? n_ = FHIRHelpers_4_4_000.Instance.ToValue(context, m_);

            bool? o_(Observation? CreatinineLab) {
                object? be_;
                DataType? bs_ = CreatinineLab?.Effective;
                object? bt_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bs_);
                bool bu_ = bt_ is CqlDateTime;
                if (bu_)
                {
                    DataType? bv_ = CreatinineLab?.Effective;
                    object? bw_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bv_);
                    be_ = bw_ as CqlDateTime;
                }
                else
                {
                    DataType? bx_ = CreatinineLab?.Effective;
                    object? by_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bx_);
                    bool bz_ = by_ is CqlDateTime;
                    if (bz_)
                    {
                        DataType? ca_ = CreatinineLab?.Effective;
                        object? cb_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ca_);
                        be_ = cb_ as CqlDateTime;
                    }
                    else
                    {
                        DataType? cc_ = CreatinineLab?.Effective;
                        object? cd_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cc_);
                        bool ce_ = cd_ is CqlInterval<CqlDateTime>;
                        if (ce_)
                        {
                            DataType? cf_ = CreatinineLab?.Effective;
                            object? cg_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cf_);
                            be_ = cg_ as CqlInterval<CqlDateTime?>;
                        }
                        else
                        {
                            be_ = null;
                        }
                    }
                }
                CqlDateTime? bf_ = QICoreCommon_4_0_000.Instance.earliest(context, be_);
                CqlInterval<CqlDateTime?>? bg_ = CQMCommon_4_1_000.Instance.hospitalizationWithObservationAndOutpatientSurgeryService(context, EncounterInpatient);
                bool? bh_ = context.Operators.In<CqlDateTime?>(bf_, bg_, (string?)default);
                Code<ObservationStatus>? bi_ = CreatinineLab?.StatusElement;
                ObservationStatus? bj_ = bi_?.Value;
                string? bk_ = context.Operators.Convert<string?>(bj_);
                string?[]? bl_ = [
                    "final",
                    "amended",
                    "corrected",
                ];
                bool? bm_ = context.Operators.In<string?>(bk_, (IEnumerable<string?>?)bl_);
                bool? bn_ = context.Operators.And(bh_, bm_);
                DataType? bo_ = CreatinineLab?.Value;
                object? bp_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bo_);
                bool? bq_ = context.Operators.Not((bool?)(bp_ is null));
                bool? br_ = context.Operators.And(bn_, bq_);
                return br_;
            }

            IEnumerable<Observation?>? p_ = context.Operators.Where<Observation?>(g_, o_);

            object q_(Observation? @this) {
                Instant? ch_ = @this?.IssuedElement;
                DateTimeOffset? ci_ = ch_?.Value;
                CqlDateTime? cj_ = context.Operators.Convert<CqlDateTime?>(ci_);
                CqlDateTime? ck_ = QICoreCommon_4_0_000.Instance.earliest(context, cj_);
                return ck_!;
            }

            IEnumerable<Observation?>? r_ = context.Operators.SortBy<Observation?>(p_, q_, System.ComponentModel.ListSortDirection.Ascending);
            Observation? s_ = context.Operators.First<Observation?>(r_!);
            Instant? t_ = s_?.IssuedElement;
            DateTimeOffset? u_ = t_?.Value;
            CqlDateTime? v_ = context.Operators.Convert<CqlDateTime?>(u_);
            (CqlTupleMetadata, string? EncounterId, CqlQuantity? FirstCreatinineResult, CqlDateTime? Timing)? w_ = (CqlTupleMetadata_FETECNQPQREfGRgPYWhOWgeWA, e_, n_ as CqlQuantity, v_);
            return w_;
        }

        IEnumerable<(CqlTupleMetadata, string? EncounterId, CqlQuantity? FirstCreatinineResult, CqlDateTime? Timing)?>? c_ = context.Operators.SelectDistinct<Encounter?, (CqlTupleMetadata, string? EncounterId, CqlQuantity? FirstCreatinineResult, CqlDateTime? Timing)?>(a_, b_);
        return c_;
    }


    [CqlExpressionDefinition("SDE Encounter With First Hematocrit Lab Test")]
    public IEnumerable<(CqlTupleMetadata, string? EncounterId, CqlQuantity? FirstHematocritResult, CqlDateTime? Timing)?>? SDE_Encounter_With_First_Hematocrit_Lab_Test(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_SDE_Encounter_With_First_Hematocrit_Lab_Test, SDE_Encounter_With_First_Hematocrit_Lab_Test_Compute);

    private const long _cacheIndex_SDE_Encounter_With_First_Hematocrit_Lab_Test = -6738782626327138842L;

    private IEnumerable<(CqlTupleMetadata, string? EncounterId, CqlQuantity? FirstHematocritResult, CqlDateTime? Timing)?>? SDE_Encounter_With_First_Hematocrit_Lab_Test_Compute(CqlContext context)
    {
        IEnumerable<Encounter?>? a_ = this.Inpatient_Encounters(context);

        (CqlTupleMetadata, string? EncounterId, CqlQuantity? FirstHematocritResult, CqlDateTime? Timing)? b_(Encounter? EncounterInpatient) {
            Id? d_ = EncounterInpatient?.IdElement;
            string? e_ = d_?.Value;
            CqlValueSet? f_ = this.Hematocrit_lab_test(context);
            IEnumerable<Observation?>? g_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, f_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation-lab"));

            bool? h_(Observation? HematocritLab) {
                object? x_;
                DataType? al_ = HematocritLab?.Effective;
                object? am_ = FHIRHelpers_4_4_000.Instance.ToValue(context, al_);
                bool an_ = am_ is CqlDateTime;
                if (an_)
                {
                    DataType? ao_ = HematocritLab?.Effective;
                    object? ap_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ao_);
                    x_ = ap_ as CqlDateTime;
                }
                else
                {
                    DataType? aq_ = HematocritLab?.Effective;
                    object? ar_ = FHIRHelpers_4_4_000.Instance.ToValue(context, aq_);
                    bool as_ = ar_ is CqlDateTime;
                    if (as_)
                    {
                        DataType? at_ = HematocritLab?.Effective;
                        object? au_ = FHIRHelpers_4_4_000.Instance.ToValue(context, at_);
                        x_ = au_ as CqlDateTime;
                    }
                    else
                    {
                        DataType? av_ = HematocritLab?.Effective;
                        object? aw_ = FHIRHelpers_4_4_000.Instance.ToValue(context, av_);
                        bool ax_ = aw_ is CqlInterval<CqlDateTime>;
                        if (ax_)
                        {
                            DataType? ay_ = HematocritLab?.Effective;
                            object? az_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ay_);
                            x_ = az_ as CqlInterval<CqlDateTime?>;
                        }
                        else
                        {
                            x_ = null;
                        }
                    }
                }
                CqlDateTime? y_ = QICoreCommon_4_0_000.Instance.earliest(context, x_);
                CqlInterval<CqlDateTime?>? z_ = CQMCommon_4_1_000.Instance.hospitalizationWithObservationAndOutpatientSurgeryService(context, EncounterInpatient);
                bool? aa_ = context.Operators.In<CqlDateTime?>(y_, z_, (string?)default);
                Code<ObservationStatus>? ab_ = HematocritLab?.StatusElement;
                ObservationStatus? ac_ = ab_?.Value;
                string? ad_ = context.Operators.Convert<string?>(ac_);
                string?[]? ae_ = [
                    "final",
                    "amended",
                    "corrected",
                ];
                bool? af_ = context.Operators.In<string?>(ad_, (IEnumerable<string?>?)ae_);
                bool? ag_ = context.Operators.And(aa_, af_);
                DataType? ah_ = HematocritLab?.Value;
                object? ai_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ah_);
                bool? aj_ = context.Operators.Not((bool?)(ai_ is null));
                bool? ak_ = context.Operators.And(ag_, aj_);
                return ak_;
            }

            IEnumerable<Observation?>? i_ = context.Operators.Where<Observation?>(g_, h_);

            object j_(Observation? @this) {
                Instant? ba_ = @this?.IssuedElement;
                DateTimeOffset? bb_ = ba_?.Value;
                CqlDateTime? bc_ = context.Operators.Convert<CqlDateTime?>(bb_);
                CqlDateTime? bd_ = QICoreCommon_4_0_000.Instance.earliest(context, bc_);
                return bd_!;
            }

            IEnumerable<Observation?>? k_ = context.Operators.SortBy<Observation?>(i_, j_, System.ComponentModel.ListSortDirection.Ascending);
            Observation? l_ = context.Operators.First<Observation?>(k_!);
            DataType? m_ = l_?.Value;
            object? n_ = FHIRHelpers_4_4_000.Instance.ToValue(context, m_);

            bool? o_(Observation? HematocritLab) {
                object? be_;
                DataType? bs_ = HematocritLab?.Effective;
                object? bt_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bs_);
                bool bu_ = bt_ is CqlDateTime;
                if (bu_)
                {
                    DataType? bv_ = HematocritLab?.Effective;
                    object? bw_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bv_);
                    be_ = bw_ as CqlDateTime;
                }
                else
                {
                    DataType? bx_ = HematocritLab?.Effective;
                    object? by_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bx_);
                    bool bz_ = by_ is CqlDateTime;
                    if (bz_)
                    {
                        DataType? ca_ = HematocritLab?.Effective;
                        object? cb_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ca_);
                        be_ = cb_ as CqlDateTime;
                    }
                    else
                    {
                        DataType? cc_ = HematocritLab?.Effective;
                        object? cd_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cc_);
                        bool ce_ = cd_ is CqlInterval<CqlDateTime>;
                        if (ce_)
                        {
                            DataType? cf_ = HematocritLab?.Effective;
                            object? cg_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cf_);
                            be_ = cg_ as CqlInterval<CqlDateTime?>;
                        }
                        else
                        {
                            be_ = null;
                        }
                    }
                }
                CqlDateTime? bf_ = QICoreCommon_4_0_000.Instance.earliest(context, be_);
                CqlInterval<CqlDateTime?>? bg_ = CQMCommon_4_1_000.Instance.hospitalizationWithObservationAndOutpatientSurgeryService(context, EncounterInpatient);
                bool? bh_ = context.Operators.In<CqlDateTime?>(bf_, bg_, (string?)default);
                Code<ObservationStatus>? bi_ = HematocritLab?.StatusElement;
                ObservationStatus? bj_ = bi_?.Value;
                string? bk_ = context.Operators.Convert<string?>(bj_);
                string?[]? bl_ = [
                    "final",
                    "amended",
                    "corrected",
                ];
                bool? bm_ = context.Operators.In<string?>(bk_, (IEnumerable<string?>?)bl_);
                bool? bn_ = context.Operators.And(bh_, bm_);
                DataType? bo_ = HematocritLab?.Value;
                object? bp_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bo_);
                bool? bq_ = context.Operators.Not((bool?)(bp_ is null));
                bool? br_ = context.Operators.And(bn_, bq_);
                return br_;
            }

            IEnumerable<Observation?>? p_ = context.Operators.Where<Observation?>(g_, o_);

            object q_(Observation? @this) {
                Instant? ch_ = @this?.IssuedElement;
                DateTimeOffset? ci_ = ch_?.Value;
                CqlDateTime? cj_ = context.Operators.Convert<CqlDateTime?>(ci_);
                CqlDateTime? ck_ = QICoreCommon_4_0_000.Instance.earliest(context, cj_);
                return ck_!;
            }

            IEnumerable<Observation?>? r_ = context.Operators.SortBy<Observation?>(p_, q_, System.ComponentModel.ListSortDirection.Ascending);
            Observation? s_ = context.Operators.First<Observation?>(r_!);
            Instant? t_ = s_?.IssuedElement;
            DateTimeOffset? u_ = t_?.Value;
            CqlDateTime? v_ = context.Operators.Convert<CqlDateTime?>(u_);
            (CqlTupleMetadata, string? EncounterId, CqlQuantity? FirstHematocritResult, CqlDateTime? Timing)? w_ = (CqlTupleMetadata_DIHdhbAJeJTdiAVUAELUHRNdS, e_, n_ as CqlQuantity, v_);
            return w_;
        }

        IEnumerable<(CqlTupleMetadata, string? EncounterId, CqlQuantity? FirstHematocritResult, CqlDateTime? Timing)?>? c_ = context.Operators.SelectDistinct<Encounter?, (CqlTupleMetadata, string? EncounterId, CqlQuantity? FirstHematocritResult, CqlDateTime? Timing)?>(a_, b_);
        return c_;
    }


    [CqlExpressionDefinition("SDE Encounter With First Platelet Lab Test")]
    public IEnumerable<(CqlTupleMetadata, string? EncounterId, CqlQuantity? FirstPlateletResult, CqlDateTime? Timing)?>? SDE_Encounter_With_First_Platelet_Lab_Test(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_SDE_Encounter_With_First_Platelet_Lab_Test, SDE_Encounter_With_First_Platelet_Lab_Test_Compute);

    private const long _cacheIndex_SDE_Encounter_With_First_Platelet_Lab_Test = -354840183162715779L;

    private IEnumerable<(CqlTupleMetadata, string? EncounterId, CqlQuantity? FirstPlateletResult, CqlDateTime? Timing)?>? SDE_Encounter_With_First_Platelet_Lab_Test_Compute(CqlContext context)
    {
        IEnumerable<Encounter?>? a_ = this.Inpatient_Encounters(context);

        (CqlTupleMetadata, string? EncounterId, CqlQuantity? FirstPlateletResult, CqlDateTime? Timing)? b_(Encounter? EncounterInpatient) {
            Id? d_ = EncounterInpatient?.IdElement;
            string? e_ = d_?.Value;
            CqlValueSet? f_ = this.Platelet_count_lab_test(context);
            IEnumerable<Observation?>? g_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, f_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation-lab"));

            bool? h_(Observation? PlateletLab) {
                object? x_;
                DataType? al_ = PlateletLab?.Effective;
                object? am_ = FHIRHelpers_4_4_000.Instance.ToValue(context, al_);
                bool an_ = am_ is CqlDateTime;
                if (an_)
                {
                    DataType? ao_ = PlateletLab?.Effective;
                    object? ap_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ao_);
                    x_ = ap_ as CqlDateTime;
                }
                else
                {
                    DataType? aq_ = PlateletLab?.Effective;
                    object? ar_ = FHIRHelpers_4_4_000.Instance.ToValue(context, aq_);
                    bool as_ = ar_ is CqlDateTime;
                    if (as_)
                    {
                        DataType? at_ = PlateletLab?.Effective;
                        object? au_ = FHIRHelpers_4_4_000.Instance.ToValue(context, at_);
                        x_ = au_ as CqlDateTime;
                    }
                    else
                    {
                        DataType? av_ = PlateletLab?.Effective;
                        object? aw_ = FHIRHelpers_4_4_000.Instance.ToValue(context, av_);
                        bool ax_ = aw_ is CqlInterval<CqlDateTime>;
                        if (ax_)
                        {
                            DataType? ay_ = PlateletLab?.Effective;
                            object? az_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ay_);
                            x_ = az_ as CqlInterval<CqlDateTime?>;
                        }
                        else
                        {
                            x_ = null;
                        }
                    }
                }
                CqlDateTime? y_ = QICoreCommon_4_0_000.Instance.earliest(context, x_);
                CqlInterval<CqlDateTime?>? z_ = CQMCommon_4_1_000.Instance.hospitalizationWithObservationAndOutpatientSurgeryService(context, EncounterInpatient);
                bool? aa_ = context.Operators.In<CqlDateTime?>(y_, z_, (string?)default);
                Code<ObservationStatus>? ab_ = PlateletLab?.StatusElement;
                ObservationStatus? ac_ = ab_?.Value;
                string? ad_ = context.Operators.Convert<string?>(ac_);
                string?[]? ae_ = [
                    "final",
                    "amended",
                    "corrected",
                ];
                bool? af_ = context.Operators.In<string?>(ad_, (IEnumerable<string?>?)ae_);
                bool? ag_ = context.Operators.And(aa_, af_);
                DataType? ah_ = PlateletLab?.Value;
                object? ai_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ah_);
                bool? aj_ = context.Operators.Not((bool?)(ai_ is null));
                bool? ak_ = context.Operators.And(ag_, aj_);
                return ak_;
            }

            IEnumerable<Observation?>? i_ = context.Operators.Where<Observation?>(g_, h_);

            object j_(Observation? @this) {
                Instant? ba_ = @this?.IssuedElement;
                DateTimeOffset? bb_ = ba_?.Value;
                CqlDateTime? bc_ = context.Operators.Convert<CqlDateTime?>(bb_);
                CqlDateTime? bd_ = QICoreCommon_4_0_000.Instance.earliest(context, bc_);
                return bd_!;
            }

            IEnumerable<Observation?>? k_ = context.Operators.SortBy<Observation?>(i_, j_, System.ComponentModel.ListSortDirection.Ascending);
            Observation? l_ = context.Operators.First<Observation?>(k_!);
            DataType? m_ = l_?.Value;
            object? n_ = FHIRHelpers_4_4_000.Instance.ToValue(context, m_);

            bool? o_(Observation? PlateletLab) {
                object? be_;
                DataType? bs_ = PlateletLab?.Effective;
                object? bt_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bs_);
                bool bu_ = bt_ is CqlDateTime;
                if (bu_)
                {
                    DataType? bv_ = PlateletLab?.Effective;
                    object? bw_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bv_);
                    be_ = bw_ as CqlDateTime;
                }
                else
                {
                    DataType? bx_ = PlateletLab?.Effective;
                    object? by_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bx_);
                    bool bz_ = by_ is CqlDateTime;
                    if (bz_)
                    {
                        DataType? ca_ = PlateletLab?.Effective;
                        object? cb_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ca_);
                        be_ = cb_ as CqlDateTime;
                    }
                    else
                    {
                        DataType? cc_ = PlateletLab?.Effective;
                        object? cd_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cc_);
                        bool ce_ = cd_ is CqlInterval<CqlDateTime>;
                        if (ce_)
                        {
                            DataType? cf_ = PlateletLab?.Effective;
                            object? cg_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cf_);
                            be_ = cg_ as CqlInterval<CqlDateTime?>;
                        }
                        else
                        {
                            be_ = null;
                        }
                    }
                }
                CqlDateTime? bf_ = QICoreCommon_4_0_000.Instance.earliest(context, be_);
                CqlInterval<CqlDateTime?>? bg_ = CQMCommon_4_1_000.Instance.hospitalizationWithObservationAndOutpatientSurgeryService(context, EncounterInpatient);
                bool? bh_ = context.Operators.In<CqlDateTime?>(bf_, bg_, (string?)default);
                Code<ObservationStatus>? bi_ = PlateletLab?.StatusElement;
                ObservationStatus? bj_ = bi_?.Value;
                string? bk_ = context.Operators.Convert<string?>(bj_);
                string?[]? bl_ = [
                    "final",
                    "amended",
                    "corrected",
                ];
                bool? bm_ = context.Operators.In<string?>(bk_, (IEnumerable<string?>?)bl_);
                bool? bn_ = context.Operators.And(bh_, bm_);
                DataType? bo_ = PlateletLab?.Value;
                object? bp_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bo_);
                bool? bq_ = context.Operators.Not((bool?)(bp_ is null));
                bool? br_ = context.Operators.And(bn_, bq_);
                return br_;
            }

            IEnumerable<Observation?>? p_ = context.Operators.Where<Observation?>(g_, o_);

            object q_(Observation? @this) {
                Instant? ch_ = @this?.IssuedElement;
                DateTimeOffset? ci_ = ch_?.Value;
                CqlDateTime? cj_ = context.Operators.Convert<CqlDateTime?>(ci_);
                CqlDateTime? ck_ = QICoreCommon_4_0_000.Instance.earliest(context, cj_);
                return ck_!;
            }

            IEnumerable<Observation?>? r_ = context.Operators.SortBy<Observation?>(p_, q_, System.ComponentModel.ListSortDirection.Ascending);
            Observation? s_ = context.Operators.First<Observation?>(r_!);
            Instant? t_ = s_?.IssuedElement;
            DateTimeOffset? u_ = t_?.Value;
            CqlDateTime? v_ = context.Operators.Convert<CqlDateTime?>(u_);
            (CqlTupleMetadata, string? EncounterId, CqlQuantity? FirstPlateletResult, CqlDateTime? Timing)? w_ = (CqlTupleMetadata_DAUcYHQZcDKbIfORJOEZBDgIh, e_, n_ as CqlQuantity, v_);
            return w_;
        }

        IEnumerable<(CqlTupleMetadata, string? EncounterId, CqlQuantity? FirstPlateletResult, CqlDateTime? Timing)?>? c_ = context.Operators.SelectDistinct<Encounter?, (CqlTupleMetadata, string? EncounterId, CqlQuantity? FirstPlateletResult, CqlDateTime? Timing)?>(a_, b_);
        return c_;
    }


    [CqlExpressionDefinition("SDE Encounter With First Sodium Lab Test")]
    public IEnumerable<(CqlTupleMetadata, string? EncounterId, CqlQuantity? FirstSodiumResult, CqlDateTime? Timing)?>? SDE_Encounter_With_First_Sodium_Lab_Test(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_SDE_Encounter_With_First_Sodium_Lab_Test, SDE_Encounter_With_First_Sodium_Lab_Test_Compute);

    private const long _cacheIndex_SDE_Encounter_With_First_Sodium_Lab_Test = 1704795996816869661L;

    private IEnumerable<(CqlTupleMetadata, string? EncounterId, CqlQuantity? FirstSodiumResult, CqlDateTime? Timing)?>? SDE_Encounter_With_First_Sodium_Lab_Test_Compute(CqlContext context)
    {
        IEnumerable<Encounter?>? a_ = this.Inpatient_Encounters(context);

        (CqlTupleMetadata, string? EncounterId, CqlQuantity? FirstSodiumResult, CqlDateTime? Timing)? b_(Encounter? EncounterInpatient) {
            Id? d_ = EncounterInpatient?.IdElement;
            string? e_ = d_?.Value;
            CqlValueSet? f_ = this.Sodium_lab_test(context);
            IEnumerable<Observation?>? g_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, f_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation-lab"));

            bool? h_(Observation? SodiumLab) {
                object? x_;
                DataType? al_ = SodiumLab?.Effective;
                object? am_ = FHIRHelpers_4_4_000.Instance.ToValue(context, al_);
                bool an_ = am_ is CqlDateTime;
                if (an_)
                {
                    DataType? ao_ = SodiumLab?.Effective;
                    object? ap_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ao_);
                    x_ = ap_ as CqlDateTime;
                }
                else
                {
                    DataType? aq_ = SodiumLab?.Effective;
                    object? ar_ = FHIRHelpers_4_4_000.Instance.ToValue(context, aq_);
                    bool as_ = ar_ is CqlDateTime;
                    if (as_)
                    {
                        DataType? at_ = SodiumLab?.Effective;
                        object? au_ = FHIRHelpers_4_4_000.Instance.ToValue(context, at_);
                        x_ = au_ as CqlDateTime;
                    }
                    else
                    {
                        DataType? av_ = SodiumLab?.Effective;
                        object? aw_ = FHIRHelpers_4_4_000.Instance.ToValue(context, av_);
                        bool ax_ = aw_ is CqlInterval<CqlDateTime>;
                        if (ax_)
                        {
                            DataType? ay_ = SodiumLab?.Effective;
                            object? az_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ay_);
                            x_ = az_ as CqlInterval<CqlDateTime?>;
                        }
                        else
                        {
                            x_ = null;
                        }
                    }
                }
                CqlDateTime? y_ = QICoreCommon_4_0_000.Instance.earliest(context, x_);
                CqlInterval<CqlDateTime?>? z_ = CQMCommon_4_1_000.Instance.hospitalizationWithObservationAndOutpatientSurgeryService(context, EncounterInpatient);
                bool? aa_ = context.Operators.In<CqlDateTime?>(y_, z_, (string?)default);
                Code<ObservationStatus>? ab_ = SodiumLab?.StatusElement;
                ObservationStatus? ac_ = ab_?.Value;
                string? ad_ = context.Operators.Convert<string?>(ac_);
                string?[]? ae_ = [
                    "final",
                    "amended",
                    "corrected",
                ];
                bool? af_ = context.Operators.In<string?>(ad_, (IEnumerable<string?>?)ae_);
                bool? ag_ = context.Operators.And(aa_, af_);
                DataType? ah_ = SodiumLab?.Value;
                object? ai_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ah_);
                bool? aj_ = context.Operators.Not((bool?)(ai_ is null));
                bool? ak_ = context.Operators.And(ag_, aj_);
                return ak_;
            }

            IEnumerable<Observation?>? i_ = context.Operators.Where<Observation?>(g_, h_);

            object j_(Observation? @this) {
                Instant? ba_ = @this?.IssuedElement;
                DateTimeOffset? bb_ = ba_?.Value;
                CqlDateTime? bc_ = context.Operators.Convert<CqlDateTime?>(bb_);
                CqlDateTime? bd_ = QICoreCommon_4_0_000.Instance.earliest(context, bc_);
                return bd_!;
            }

            IEnumerable<Observation?>? k_ = context.Operators.SortBy<Observation?>(i_, j_, System.ComponentModel.ListSortDirection.Ascending);
            Observation? l_ = context.Operators.First<Observation?>(k_!);
            DataType? m_ = l_?.Value;
            object? n_ = FHIRHelpers_4_4_000.Instance.ToValue(context, m_);

            bool? o_(Observation? SodiumLab) {
                object? be_;
                DataType? bs_ = SodiumLab?.Effective;
                object? bt_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bs_);
                bool bu_ = bt_ is CqlDateTime;
                if (bu_)
                {
                    DataType? bv_ = SodiumLab?.Effective;
                    object? bw_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bv_);
                    be_ = bw_ as CqlDateTime;
                }
                else
                {
                    DataType? bx_ = SodiumLab?.Effective;
                    object? by_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bx_);
                    bool bz_ = by_ is CqlDateTime;
                    if (bz_)
                    {
                        DataType? ca_ = SodiumLab?.Effective;
                        object? cb_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ca_);
                        be_ = cb_ as CqlDateTime;
                    }
                    else
                    {
                        DataType? cc_ = SodiumLab?.Effective;
                        object? cd_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cc_);
                        bool ce_ = cd_ is CqlInterval<CqlDateTime>;
                        if (ce_)
                        {
                            DataType? cf_ = SodiumLab?.Effective;
                            object? cg_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cf_);
                            be_ = cg_ as CqlInterval<CqlDateTime?>;
                        }
                        else
                        {
                            be_ = null;
                        }
                    }
                }
                CqlDateTime? bf_ = QICoreCommon_4_0_000.Instance.earliest(context, be_);
                CqlInterval<CqlDateTime?>? bg_ = CQMCommon_4_1_000.Instance.hospitalizationWithObservationAndOutpatientSurgeryService(context, EncounterInpatient);
                bool? bh_ = context.Operators.In<CqlDateTime?>(bf_, bg_, (string?)default);
                Code<ObservationStatus>? bi_ = SodiumLab?.StatusElement;
                ObservationStatus? bj_ = bi_?.Value;
                string? bk_ = context.Operators.Convert<string?>(bj_);
                string?[]? bl_ = [
                    "final",
                    "amended",
                    "corrected",
                ];
                bool? bm_ = context.Operators.In<string?>(bk_, (IEnumerable<string?>?)bl_);
                bool? bn_ = context.Operators.And(bh_, bm_);
                DataType? bo_ = SodiumLab?.Value;
                object? bp_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bo_);
                bool? bq_ = context.Operators.Not((bool?)(bp_ is null));
                bool? br_ = context.Operators.And(bn_, bq_);
                return br_;
            }

            IEnumerable<Observation?>? p_ = context.Operators.Where<Observation?>(g_, o_);

            object q_(Observation? @this) {
                Instant? ch_ = @this?.IssuedElement;
                DateTimeOffset? ci_ = ch_?.Value;
                CqlDateTime? cj_ = context.Operators.Convert<CqlDateTime?>(ci_);
                CqlDateTime? ck_ = QICoreCommon_4_0_000.Instance.earliest(context, cj_);
                return ck_!;
            }

            IEnumerable<Observation?>? r_ = context.Operators.SortBy<Observation?>(p_, q_, System.ComponentModel.ListSortDirection.Ascending);
            Observation? s_ = context.Operators.First<Observation?>(r_!);
            Instant? t_ = s_?.IssuedElement;
            DateTimeOffset? u_ = t_?.Value;
            CqlDateTime? v_ = context.Operators.Convert<CqlDateTime?>(u_);
            (CqlTupleMetadata, string? EncounterId, CqlQuantity? FirstSodiumResult, CqlDateTime? Timing)? w_ = (CqlTupleMetadata_GKGeLARADLGJcNcZaDhdCREMa, e_, n_ as CqlQuantity, v_);
            return w_;
        }

        IEnumerable<(CqlTupleMetadata, string? EncounterId, CqlQuantity? FirstSodiumResult, CqlDateTime? Timing)?>? c_ = context.Operators.SelectDistinct<Encounter?, (CqlTupleMetadata, string? EncounterId, CqlQuantity? FirstSodiumResult, CqlDateTime? Timing)?>(a_, b_);
        return c_;
    }


    [CqlExpressionDefinition("SDE Encounter With First White Blood Cells Lab Test")]
    public IEnumerable<(CqlTupleMetadata, string? EncounterId, CqlQuantity? FirstWhiteBloodCellResult, CqlDateTime? Timing)?>? SDE_Encounter_With_First_White_Blood_Cells_Lab_Test(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_SDE_Encounter_With_First_White_Blood_Cells_Lab_Test, SDE_Encounter_With_First_White_Blood_Cells_Lab_Test_Compute);

    private const long _cacheIndex_SDE_Encounter_With_First_White_Blood_Cells_Lab_Test = -5465861473556378136L;

    private IEnumerable<(CqlTupleMetadata, string? EncounterId, CqlQuantity? FirstWhiteBloodCellResult, CqlDateTime? Timing)?>? SDE_Encounter_With_First_White_Blood_Cells_Lab_Test_Compute(CqlContext context)
    {
        IEnumerable<Encounter?>? a_ = this.Inpatient_Encounters(context);

        (CqlTupleMetadata, string? EncounterId, CqlQuantity? FirstWhiteBloodCellResult, CqlDateTime? Timing)? b_(Encounter? EncounterInpatient) {
            Id? d_ = EncounterInpatient?.IdElement;
            string? e_ = d_?.Value;
            CqlValueSet? f_ = this.White_blood_cells_count_lab_test(context);
            IEnumerable<Observation?>? g_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, f_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation-lab"));

            bool? h_(Observation? WhiteBloodCellLab) {
                object? x_;
                DataType? al_ = WhiteBloodCellLab?.Effective;
                object? am_ = FHIRHelpers_4_4_000.Instance.ToValue(context, al_);
                bool an_ = am_ is CqlDateTime;
                if (an_)
                {
                    DataType? ao_ = WhiteBloodCellLab?.Effective;
                    object? ap_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ao_);
                    x_ = ap_ as CqlDateTime;
                }
                else
                {
                    DataType? aq_ = WhiteBloodCellLab?.Effective;
                    object? ar_ = FHIRHelpers_4_4_000.Instance.ToValue(context, aq_);
                    bool as_ = ar_ is CqlDateTime;
                    if (as_)
                    {
                        DataType? at_ = WhiteBloodCellLab?.Effective;
                        object? au_ = FHIRHelpers_4_4_000.Instance.ToValue(context, at_);
                        x_ = au_ as CqlDateTime;
                    }
                    else
                    {
                        DataType? av_ = WhiteBloodCellLab?.Effective;
                        object? aw_ = FHIRHelpers_4_4_000.Instance.ToValue(context, av_);
                        bool ax_ = aw_ is CqlInterval<CqlDateTime>;
                        if (ax_)
                        {
                            DataType? ay_ = WhiteBloodCellLab?.Effective;
                            object? az_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ay_);
                            x_ = az_ as CqlInterval<CqlDateTime?>;
                        }
                        else
                        {
                            x_ = null;
                        }
                    }
                }
                CqlDateTime? y_ = QICoreCommon_4_0_000.Instance.earliest(context, x_);
                CqlInterval<CqlDateTime?>? z_ = CQMCommon_4_1_000.Instance.hospitalizationWithObservationAndOutpatientSurgeryService(context, EncounterInpatient);
                bool? aa_ = context.Operators.In<CqlDateTime?>(y_, z_, (string?)default);
                Code<ObservationStatus>? ab_ = WhiteBloodCellLab?.StatusElement;
                ObservationStatus? ac_ = ab_?.Value;
                string? ad_ = context.Operators.Convert<string?>(ac_);
                string?[]? ae_ = [
                    "final",
                    "amended",
                    "corrected",
                ];
                bool? af_ = context.Operators.In<string?>(ad_, (IEnumerable<string?>?)ae_);
                bool? ag_ = context.Operators.And(aa_, af_);
                DataType? ah_ = WhiteBloodCellLab?.Value;
                object? ai_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ah_);
                bool? aj_ = context.Operators.Not((bool?)(ai_ is null));
                bool? ak_ = context.Operators.And(ag_, aj_);
                return ak_;
            }

            IEnumerable<Observation?>? i_ = context.Operators.Where<Observation?>(g_, h_);

            object j_(Observation? @this) {
                Instant? ba_ = @this?.IssuedElement;
                DateTimeOffset? bb_ = ba_?.Value;
                CqlDateTime? bc_ = context.Operators.Convert<CqlDateTime?>(bb_);
                CqlDateTime? bd_ = QICoreCommon_4_0_000.Instance.earliest(context, bc_);
                return bd_!;
            }

            IEnumerable<Observation?>? k_ = context.Operators.SortBy<Observation?>(i_, j_, System.ComponentModel.ListSortDirection.Ascending);
            Observation? l_ = context.Operators.First<Observation?>(k_!);
            DataType? m_ = l_?.Value;
            object? n_ = FHIRHelpers_4_4_000.Instance.ToValue(context, m_);

            bool? o_(Observation? WhiteBloodCellLab) {
                object? be_;
                DataType? bs_ = WhiteBloodCellLab?.Effective;
                object? bt_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bs_);
                bool bu_ = bt_ is CqlDateTime;
                if (bu_)
                {
                    DataType? bv_ = WhiteBloodCellLab?.Effective;
                    object? bw_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bv_);
                    be_ = bw_ as CqlDateTime;
                }
                else
                {
                    DataType? bx_ = WhiteBloodCellLab?.Effective;
                    object? by_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bx_);
                    bool bz_ = by_ is CqlDateTime;
                    if (bz_)
                    {
                        DataType? ca_ = WhiteBloodCellLab?.Effective;
                        object? cb_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ca_);
                        be_ = cb_ as CqlDateTime;
                    }
                    else
                    {
                        DataType? cc_ = WhiteBloodCellLab?.Effective;
                        object? cd_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cc_);
                        bool ce_ = cd_ is CqlInterval<CqlDateTime>;
                        if (ce_)
                        {
                            DataType? cf_ = WhiteBloodCellLab?.Effective;
                            object? cg_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cf_);
                            be_ = cg_ as CqlInterval<CqlDateTime?>;
                        }
                        else
                        {
                            be_ = null;
                        }
                    }
                }
                CqlDateTime? bf_ = QICoreCommon_4_0_000.Instance.earliest(context, be_);
                CqlInterval<CqlDateTime?>? bg_ = CQMCommon_4_1_000.Instance.hospitalizationWithObservationAndOutpatientSurgeryService(context, EncounterInpatient);
                bool? bh_ = context.Operators.In<CqlDateTime?>(bf_, bg_, (string?)default);
                Code<ObservationStatus>? bi_ = WhiteBloodCellLab?.StatusElement;
                ObservationStatus? bj_ = bi_?.Value;
                string? bk_ = context.Operators.Convert<string?>(bj_);
                string?[]? bl_ = [
                    "final",
                    "amended",
                    "corrected",
                ];
                bool? bm_ = context.Operators.In<string?>(bk_, (IEnumerable<string?>?)bl_);
                bool? bn_ = context.Operators.And(bh_, bm_);
                DataType? bo_ = WhiteBloodCellLab?.Value;
                object? bp_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bo_);
                bool? bq_ = context.Operators.Not((bool?)(bp_ is null));
                bool? br_ = context.Operators.And(bn_, bq_);
                return br_;
            }

            IEnumerable<Observation?>? p_ = context.Operators.Where<Observation?>(g_, o_);

            object q_(Observation? @this) {
                Instant? ch_ = @this?.IssuedElement;
                DateTimeOffset? ci_ = ch_?.Value;
                CqlDateTime? cj_ = context.Operators.Convert<CqlDateTime?>(ci_);
                CqlDateTime? ck_ = QICoreCommon_4_0_000.Instance.earliest(context, cj_);
                return ck_!;
            }

            IEnumerable<Observation?>? r_ = context.Operators.SortBy<Observation?>(p_, q_, System.ComponentModel.ListSortDirection.Ascending);
            Observation? s_ = context.Operators.First<Observation?>(r_!);
            Instant? t_ = s_?.IssuedElement;
            DateTimeOffset? u_ = t_?.Value;
            CqlDateTime? v_ = context.Operators.Convert<CqlDateTime?>(u_);
            (CqlTupleMetadata, string? EncounterId, CqlQuantity? FirstWhiteBloodCellResult, CqlDateTime? Timing)? w_ = (CqlTupleMetadata_ChVYCdXDGgVcFTCCUefXMbCHX, e_, n_ as CqlQuantity, v_);
            return w_;
        }

        IEnumerable<(CqlTupleMetadata, string? EncounterId, CqlQuantity? FirstWhiteBloodCellResult, CqlDateTime? Timing)?>? c_ = context.Operators.SelectDistinct<Encounter?, (CqlTupleMetadata, string? EncounterId, CqlQuantity? FirstWhiteBloodCellResult, CqlDateTime? Timing)?>(a_, b_);
        return c_;
    }


    [CqlExpressionDefinition("SDE Encounter With Oxygen 60 Minutes Or Less Prior To ED Admission Or During ED")]
    public IEnumerable<Encounter?>? SDE_Encounter_With_Oxygen_60_Minutes_Or_Less_Prior_To_ED_Admission_Or_During_ED(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_SDE_Encounter_With_Oxygen_60_Minutes_Or_Less_Prior_To_ED_Admission_Or_During_ED, SDE_Encounter_With_Oxygen_60_Minutes_Or_Less_Prior_To_ED_Admission_Or_During_ED_Compute);

    private const long _cacheIndex_SDE_Encounter_With_Oxygen_60_Minutes_Or_Less_Prior_To_ED_Admission_Or_During_ED = 3300392010812223033L;

    private IEnumerable<Encounter?>? SDE_Encounter_With_Oxygen_60_Minutes_Or_Less_Prior_To_ED_Admission_Or_During_ED_Compute(CqlContext context)
    {
        IEnumerable<Encounter?>? a_ = this.Initial_Population(context);

        bool? b_(Encounter? EncounterInpatient) {
            CqlValueSet? d_ = this.Non_Invasive_Oxygen_Therapy_by_Nasal_Cannula_or_Mask(context);
            IEnumerable<ServiceRequest?>? e_ = context.Operators.Retrieve<ServiceRequest>(new RetrieveParameters(default, d_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-servicerequest"));
            CqlValueSet? f_ = this.Non_Invasive_Oxygen_Therapy_Device_Codes(context);
            IEnumerable<ServiceRequest?>? g_ = context.Operators.Retrieve<ServiceRequest>(new RetrieveParameters(default, f_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-servicerequest"));
            IEnumerable<ServiceRequest?>? h_ = context.Operators.Union<ServiceRequest?>(e_, g_);

            bool? i_(ServiceRequest? OxygenTherapyOrder) {
                FhirDateTime? u_ = OxygenTherapyOrder?.AuthoredOnElement;
                CqlDateTime? v_ = context.Operators.Convert<CqlDateTime?>(u_);
                Encounter? w_ = CQMCommon_4_1_000.Instance.edVisit(context, EncounterInpatient);
                Period? x_ = w_?.Period;
                CqlInterval<CqlDateTime?>? y_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, x_);
                bool? z_ = context.Operators.In<CqlDateTime?>(v_, y_, (string?)default);
                CqlDateTime? aa_ = context.Operators.Start(y_);
                CqlQuantity? ab_ = context.Operators.Quantity(60m, "minutes");
                CqlDateTime? ac_ = context.Operators.Subtract(aa_, ab_);
                CqlInterval<CqlDateTime?>? ad_ = context.Operators.Interval(ac_, aa_, true, true);
                bool? ae_ = context.Operators.In<CqlDateTime?>(v_, ad_, (string?)default);
                bool? af_ = context.Operators.Not((bool?)(aa_ is null));
                bool? ag_ = context.Operators.And(ae_, af_);
                bool? ah_ = context.Operators.Or(z_, ag_);
                Code<RequestStatus>? ai_ = OxygenTherapyOrder?.StatusElement;
                RequestStatus? aj_ = ai_?.Value;
                Code<RequestStatus>? ak_ = context.Operators.Convert<Code<RequestStatus>?>(aj_);
                string? al_ = context.Operators.Convert<string?>(ak_);
                string?[]? am_ = [
                    "active",
                    "completed",
                ];
                bool? an_ = context.Operators.In<string?>(al_, (IEnumerable<string?>?)am_);
                bool? ao_ = context.Operators.And(ah_, an_);
                Code<RequestIntent>? ap_ = OxygenTherapyOrder?.IntentElement;
                RequestIntent? aq_ = ap_?.Value;
                Code<RequestIntent>? ar_ = context.Operators.Convert<Code<RequestIntent>?>(aq_);
                bool? as_ = context.Operators.Equal(ar_, "order");
                bool? at_ = context.Operators.And(ao_, as_);
                return at_;
            }


            (CqlTupleMetadata, string? EncounterId, Code<RequestStatus>? OrderStatus, CqlDateTime? OrderTiming)? j_(ServiceRequest? OxygenTherapyOrder) {
                Id? au_ = EncounterInpatient?.IdElement;
                string? av_ = au_?.Value;
                Code<RequestStatus>? aw_ = OxygenTherapyOrder?.StatusElement;
                RequestStatus? ax_ = aw_?.Value;
                Code<RequestStatus>? ay_ = context.Operators.Convert<Code<RequestStatus>?>(ax_);
                FhirDateTime? az_ = OxygenTherapyOrder?.AuthoredOnElement;
                CqlDateTime? ba_ = context.Operators.Convert<CqlDateTime?>(az_);
                (CqlTupleMetadata, string? EncounterId, Code<RequestStatus>? OrderStatus, CqlDateTime? OrderTiming)? bb_ = (CqlTupleMetadata_BTRiFTXPQGKeiLWUSieghMWCU, av_, ay_, ba_);
                return bb_;
            }

            IEnumerable<(CqlTupleMetadata, string? EncounterId, Code<RequestStatus>? OrderStatus, CqlDateTime? OrderTiming)?>? k_ = context.Operators.WhereSelect<ServiceRequest?, (CqlTupleMetadata, string? EncounterId, Code<RequestStatus>? OrderStatus, CqlDateTime? OrderTiming)?>(h_, i_, j_);
            IEnumerable<(CqlTupleMetadata, string? EncounterId, Code<RequestStatus>? OrderStatus, CqlDateTime? OrderTiming)?>? l_ = context.Operators.Distinct<(CqlTupleMetadata, string? EncounterId, Code<RequestStatus>? OrderStatus, CqlDateTime? OrderTiming)?>(k_!);
            bool? m_ = context.Operators.Exists<(CqlTupleMetadata, string? EncounterId, Code<RequestStatus>? OrderStatus, CqlDateTime? OrderTiming)?>(l_!);
            IEnumerable<Procedure?>? n_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, d_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));

            bool? o_(Procedure? OxygenAdminInterv) {
                object? bc_;
                DataType? bz_ = OxygenAdminInterv?.Performed;
                object? ca_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bz_);
                bool cb_ = ca_ is CqlDateTime;
                if (cb_)
                {
                    DataType? cc_ = OxygenAdminInterv?.Performed;
                    object? cd_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cc_);
                    bc_ = cd_ as CqlDateTime;
                }
                else
                {
                    DataType? ce_ = OxygenAdminInterv?.Performed;
                    object? cf_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ce_);
                    bool cg_ = cf_ is CqlQuantity;
                    if (cg_)
                    {
                        DataType? ch_ = OxygenAdminInterv?.Performed;
                        object? ci_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ch_);
                        bc_ = ci_ as CqlQuantity;
                    }
                    else
                    {
                        DataType? cj_ = OxygenAdminInterv?.Performed;
                        object? ck_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cj_);
                        bool cl_ = ck_ is CqlInterval<CqlDateTime>;
                        if (cl_)
                        {
                            DataType? cm_ = OxygenAdminInterv?.Performed;
                            object? cn_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cm_);
                            bc_ = cn_ as CqlInterval<CqlDateTime?>;
                        }
                        else
                        {
                            DataType? co_ = OxygenAdminInterv?.Performed;
                            object? cp_ = FHIRHelpers_4_4_000.Instance.ToValue(context, co_);
                            bool cq_ = cp_ is CqlInterval<CqlQuantity>;
                            if (cq_)
                            {
                                DataType? cr_ = OxygenAdminInterv?.Performed;
                                object? cs_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cr_);
                                bc_ = cs_ as CqlInterval<CqlQuantity?>;
                            }
                            else
                            {
                                bc_ = null;
                            }
                        }
                    }
                }
                CqlInterval<CqlDateTime?>? bd_ = QICoreCommon_4_0_000.Instance.toInterval(context, bc_);
                CqlDateTime? be_ = context.Operators.Start(bd_);
                Encounter? bf_ = CQMCommon_4_1_000.Instance.edVisit(context, EncounterInpatient);
                Period? bg_ = bf_?.Period;
                CqlInterval<CqlDateTime?>? bh_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, bg_);
                bool? bi_ = context.Operators.In<CqlDateTime?>(be_, bh_, (string?)default);
                object? bj_;
                DataType? ct_ = OxygenAdminInterv?.Performed;
                object? cu_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ct_);
                bool cv_ = cu_ is CqlDateTime;
                if (cv_)
                {
                    DataType? cw_ = OxygenAdminInterv?.Performed;
                    object? cx_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cw_);
                    bj_ = cx_ as CqlDateTime;
                }
                else
                {
                    DataType? cy_ = OxygenAdminInterv?.Performed;
                    object? cz_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cy_);
                    bool da_ = cz_ is CqlQuantity;
                    if (da_)
                    {
                        DataType? db_ = OxygenAdminInterv?.Performed;
                        object? dc_ = FHIRHelpers_4_4_000.Instance.ToValue(context, db_);
                        bj_ = dc_ as CqlQuantity;
                    }
                    else
                    {
                        DataType? dd_ = OxygenAdminInterv?.Performed;
                        object? de_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dd_);
                        bool df_ = de_ is CqlInterval<CqlDateTime>;
                        if (df_)
                        {
                            DataType? dg_ = OxygenAdminInterv?.Performed;
                            object? dh_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dg_);
                            bj_ = dh_ as CqlInterval<CqlDateTime?>;
                        }
                        else
                        {
                            DataType? di_ = OxygenAdminInterv?.Performed;
                            object? dj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, di_);
                            bool dk_ = dj_ is CqlInterval<CqlQuantity>;
                            if (dk_)
                            {
                                DataType? dl_ = OxygenAdminInterv?.Performed;
                                object? dm_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dl_);
                                bj_ = dm_ as CqlInterval<CqlQuantity?>;
                            }
                            else
                            {
                                bj_ = null;
                            }
                        }
                    }
                }
                CqlInterval<CqlDateTime?>? bk_ = QICoreCommon_4_0_000.Instance.toInterval(context, bj_);
                CqlDateTime? bl_ = context.Operators.End(bk_);
                CqlDateTime? bm_ = context.Operators.Start(bh_);
                CqlQuantity? bn_ = context.Operators.Quantity(60m, "minutes");
                CqlDateTime? bo_ = context.Operators.Subtract(bm_, bn_);
                CqlInterval<CqlDateTime?>? bp_ = context.Operators.Interval(bo_, bm_, true, true);
                bool? bq_ = context.Operators.In<CqlDateTime?>(bl_, bp_, (string?)default);
                bool? br_ = context.Operators.Not((bool?)(bm_ is null));
                bool? bs_ = context.Operators.And(bq_, br_);
                bool? bt_ = context.Operators.Or(bi_, bs_);
                Code<EventStatus>? bu_ = OxygenAdminInterv?.StatusElement;
                EventStatus? bv_ = bu_?.Value;
                string? bw_ = context.Operators.Convert<string?>(bv_);
                bool? bx_ = context.Operators.Equal(bw_, "completed");
                bool? by_ = context.Operators.And(bt_, bx_);
                return by_;
            }


            (CqlTupleMetadata, string? EncounterId, CqlInterval<CqlDateTime?>? EDEncounterTiming, string? PerformedStatus, CqlInterval<CqlDateTime?>? PerformedTiming)? p_(Procedure? OxygenAdminInterv) {
                Id? dn_ = EncounterInpatient?.IdElement;
                string? do_ = dn_?.Value;
                Encounter? dp_ = CQMCommon_4_1_000.Instance.edVisit(context, EncounterInpatient);
                Period? dq_ = dp_?.Period;
                CqlInterval<CqlDateTime?>? dr_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, dq_);
                Code<EventStatus>? ds_ = OxygenAdminInterv?.StatusElement;
                EventStatus? dt_ = ds_?.Value;
                string? du_ = context.Operators.Convert<string?>(dt_);
                object? dv_;
                DataType? dy_ = OxygenAdminInterv?.Performed;
                object? dz_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dy_);
                bool ea_ = dz_ is CqlDateTime;
                if (ea_)
                {
                    DataType? eb_ = OxygenAdminInterv?.Performed;
                    object? ec_ = FHIRHelpers_4_4_000.Instance.ToValue(context, eb_);
                    dv_ = ec_ as CqlDateTime;
                }
                else
                {
                    DataType? ed_ = OxygenAdminInterv?.Performed;
                    object? ee_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ed_);
                    bool ef_ = ee_ is CqlQuantity;
                    if (ef_)
                    {
                        DataType? eg_ = OxygenAdminInterv?.Performed;
                        object? eh_ = FHIRHelpers_4_4_000.Instance.ToValue(context, eg_);
                        dv_ = eh_ as CqlQuantity;
                    }
                    else
                    {
                        DataType? ei_ = OxygenAdminInterv?.Performed;
                        object? ej_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ei_);
                        bool ek_ = ej_ is CqlInterval<CqlDateTime>;
                        if (ek_)
                        {
                            DataType? el_ = OxygenAdminInterv?.Performed;
                            object? em_ = FHIRHelpers_4_4_000.Instance.ToValue(context, el_);
                            dv_ = em_ as CqlInterval<CqlDateTime?>;
                        }
                        else
                        {
                            DataType? en_ = OxygenAdminInterv?.Performed;
                            object? eo_ = FHIRHelpers_4_4_000.Instance.ToValue(context, en_);
                            bool ep_ = eo_ is CqlInterval<CqlQuantity>;
                            if (ep_)
                            {
                                DataType? eq_ = OxygenAdminInterv?.Performed;
                                object? er_ = FHIRHelpers_4_4_000.Instance.ToValue(context, eq_);
                                dv_ = er_ as CqlInterval<CqlQuantity?>;
                            }
                            else
                            {
                                dv_ = null;
                            }
                        }
                    }
                }
                CqlInterval<CqlDateTime?>? dw_ = QICoreCommon_4_0_000.Instance.toInterval(context, dv_);
                (CqlTupleMetadata, string? EncounterId, CqlInterval<CqlDateTime?>? EDEncounterTiming, string? PerformedStatus, CqlInterval<CqlDateTime?>? PerformedTiming)? dx_ = (CqlTupleMetadata_HBSiHLDibCXHQcPZYMVBgXBIH, do_, dr_, du_, dw_);
                return dx_;
            }

            IEnumerable<(CqlTupleMetadata, string? EncounterId, CqlInterval<CqlDateTime?>? EDEncounterTiming, string? PerformedStatus, CqlInterval<CqlDateTime?>? PerformedTiming)?>? q_ = context.Operators.WhereSelect<Procedure?, (CqlTupleMetadata, string? EncounterId, CqlInterval<CqlDateTime?>? EDEncounterTiming, string? PerformedStatus, CqlInterval<CqlDateTime?>? PerformedTiming)?>(n_, o_, p_);
            IEnumerable<(CqlTupleMetadata, string? EncounterId, CqlInterval<CqlDateTime?>? EDEncounterTiming, string? PerformedStatus, CqlInterval<CqlDateTime?>? PerformedTiming)?>? r_ = context.Operators.Distinct<(CqlTupleMetadata, string? EncounterId, CqlInterval<CqlDateTime?>? EDEncounterTiming, string? PerformedStatus, CqlInterval<CqlDateTime?>? PerformedTiming)?>(q_!);
            bool? s_ = context.Operators.Exists<(CqlTupleMetadata, string? EncounterId, CqlInterval<CqlDateTime?>? EDEncounterTiming, string? PerformedStatus, CqlInterval<CqlDateTime?>? PerformedTiming)?>(r_!);
            bool? t_ = context.Operators.Or(m_, s_);
            return t_;
        }

        IEnumerable<Encounter?>? c_ = context.Operators.Where<Encounter?>(a_, b_);
        return c_;
    }


    [CqlExpressionDefinition("SDE Ethnicity")]
    public (CqlTupleMetadata, IEnumerable<CqlCode?>? codes, string? display)? SDE_Ethnicity(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_SDE_Ethnicity, SDE_Ethnicity_Compute);

    private const long _cacheIndex_SDE_Ethnicity = -1728215249426117575L;

    private (CqlTupleMetadata, IEnumerable<CqlCode?>? codes, string? display)? SDE_Ethnicity_Compute(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode?>? codes, string? display)? a_ = SupplementalDataElements_5_1_000.Instance.SDE_Ethnicity(context);
        return a_;
    }


    [CqlExpressionDefinition("SDE Payer")]
    public IEnumerable<(CqlTupleMetadata, CqlConcept? code, CqlInterval<CqlDateTime?>? period)?>? SDE_Payer(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_SDE_Payer, SDE_Payer_Compute);

    private const long _cacheIndex_SDE_Payer = 5599464314516997004L;

    private IEnumerable<(CqlTupleMetadata, CqlConcept? code, CqlInterval<CqlDateTime?>? period)?>? SDE_Payer_Compute(CqlContext context)
    {
        IEnumerable<(CqlTupleMetadata, CqlConcept? code, CqlInterval<CqlDateTime?>? period)?>? a_ = SupplementalDataElements_5_1_000.Instance.SDE_Payer(context);
        return a_;
    }


    [CqlExpressionDefinition("SDE Race")]
    public (CqlTupleMetadata, IEnumerable<CqlCode?>? codes, string? display)? SDE_Race(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_SDE_Race, SDE_Race_Compute);

    private const long _cacheIndex_SDE_Race = 6826702992571169488L;

    private (CqlTupleMetadata, IEnumerable<CqlCode?>? codes, string? display)? SDE_Race_Compute(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode?>? codes, string? display)? a_ = SupplementalDataElements_5_1_000.Instance.SDE_Race(context);
        return a_;
    }


    [CqlExpressionDefinition("SDE Sex")]
    public CqlCode? SDE_Sex(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_SDE_Sex, SDE_Sex_Compute);

    private const long _cacheIndex_SDE_Sex = 6983970667873048157L;

    private CqlCode? SDE_Sex_Compute(CqlContext context)
    {
        CqlCode? a_ = SupplementalDataElements_5_1_000.Instance.SDE_Sex(context);
        return a_;
    }


    #endregion Functions and Expressions

    #region Singleton Lifetime Members

    private CMSFHIR844HybridHospitalWideMortality_0_5_001() {}

    public static CMSFHIR844HybridHospitalWideMortality_0_5_001 Instance { get; } = new();

    #endregion

    #region ILibrary Implementation

    public string Name => "CMSFHIR844HybridHospitalWideMortality";
    public string Version => "0.5.001";
    public ILibrary[] Dependencies => [CQMCommon_4_1_000.Instance, FHIRHelpers_4_4_000.Instance, QICoreCommon_4_0_000.Instance, SupplementalDataElements_5_1_000.Instance];

    #endregion ILibrary Implementation

    #region CqlTupleMetadata Properties

    private static CqlTupleMetadata CqlTupleMetadata_BTRiFTXPQGKeiLWUSieghMWCU = new(
       [typeof(string), typeof(Code<RequestStatus>), typeof(CqlDateTime)],
       ["EncounterId", "OrderStatus", "OrderTiming"]);

    private static CqlTupleMetadata CqlTupleMetadata_ChVYCdXDGgVcFTCCUefXMbCHX = new(
       [typeof(string), typeof(CqlQuantity), typeof(CqlDateTime)],
       ["EncounterId", "FirstWhiteBloodCellResult", "Timing"]);

    private static CqlTupleMetadata CqlTupleMetadata_DAUcYHQZcDKbIfORJOEZBDgIh = new(
       [typeof(string), typeof(CqlQuantity), typeof(CqlDateTime)],
       ["EncounterId", "FirstPlateletResult", "Timing"]);

    private static CqlTupleMetadata CqlTupleMetadata_DhbJAfCiKIAGYKTjJXYGSKECQ = new(
       [typeof(string), typeof(CqlQuantity), typeof(CqlDateTime)],
       ["EncounterId", "FirstHeartRateResult", "Timing"]);

    private static CqlTupleMetadata CqlTupleMetadata_DIHdhbAJeJTdiAVUAELUHRNdS = new(
       [typeof(string), typeof(CqlQuantity), typeof(CqlDateTime)],
       ["EncounterId", "FirstHematocritResult", "Timing"]);

    private static CqlTupleMetadata CqlTupleMetadata_FdREYEdHOZIcMCNYCRFJYJReA = new(
       [typeof(string), typeof(CqlQuantity), typeof(CqlDateTime)],
       ["EncounterId", "FirstOxygenSatResult", "Timing"]);

    private static CqlTupleMetadata CqlTupleMetadata_FETECNQPQREfGRgPYWhOWgeWA = new(
       [typeof(string), typeof(CqlQuantity), typeof(CqlDateTime)],
       ["EncounterId", "FirstCreatinineResult", "Timing"]);

    private static CqlTupleMetadata CqlTupleMetadata_FjSKXeIESORPNbRGajibMfUaK = new(
       [typeof(string), typeof(IEnumerable<CqlQuantity>), typeof(CqlDateTime)],
       ["EncounterId", "FirstSBPResult", "Timing"]);

    private static CqlTupleMetadata CqlTupleMetadata_GbUHPXXHScejjXWhcHJFQQifQ = new(
       [typeof(string), typeof(CqlQuantity), typeof(CqlDateTime)],
       ["EncounterId", "FirstBicarbonateResult", "Timing"]);

    private static CqlTupleMetadata CqlTupleMetadata_GIbILVAdXLLNYBgcQIEiUiKaK = new(
       [typeof(string), typeof(CqlQuantity), typeof(CqlDateTime)],
       ["EncounterId", "FirstTemperatureResult", "Timing"]);

    private static CqlTupleMetadata CqlTupleMetadata_GKGeLARADLGJcNcZaDhdCREMa = new(
       [typeof(string), typeof(CqlQuantity), typeof(CqlDateTime)],
       ["EncounterId", "FirstSodiumResult", "Timing"]);

    private static CqlTupleMetadata CqlTupleMetadata_HBSiHLDibCXHQcPZYMVBgXBIH = new(
       [typeof(string), typeof(CqlInterval<CqlDateTime>), typeof(string), typeof(CqlInterval<CqlDateTime>)],
       ["EncounterId", "EDEncounterTiming", "PerformedStatus", "PerformedTiming"]);

    #endregion CqlTupleMetadata Properties

}

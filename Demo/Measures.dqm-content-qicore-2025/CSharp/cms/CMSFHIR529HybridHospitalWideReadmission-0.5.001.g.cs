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
[CqlLibrary("CMSFHIR529HybridHospitalWideReadmission", "0.5.001")]
public partial class CMSFHIR529HybridHospitalWideReadmission_0_5_001 : ILibrary, ISingleton<CMSFHIR529HybridHospitalWideReadmission_0_5_001>
{
    #region ValueSets (13)

    [CqlValueSetDefinition("Bicarbonate lab test", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1045.139", valueSetVersion: null)]
    public CqlValueSet Bicarbonate_lab_test(CqlContext _) => _Bicarbonate_lab_test;
    private static readonly CqlValueSet _Bicarbonate_lab_test = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1045.139", null);

    [CqlValueSetDefinition("Creatinine lab test", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.666.5.2363", valueSetVersion: null)]
    public CqlValueSet Creatinine_lab_test(CqlContext _) => _Creatinine_lab_test;
    private static readonly CqlValueSet _Creatinine_lab_test = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.666.5.2363", null);

    [CqlValueSetDefinition("Encounter Inpatient", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.666.5.307", valueSetVersion: null)]
    public CqlValueSet Encounter_Inpatient(CqlContext _) => _Encounter_Inpatient;
    private static readonly CqlValueSet _Encounter_Inpatient = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.666.5.307", null);

    [CqlValueSetDefinition("Glucose lab test", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1045.134", valueSetVersion: null)]
    public CqlValueSet Glucose_lab_test(CqlContext _) => _Glucose_lab_test;
    private static readonly CqlValueSet _Glucose_lab_test = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1045.134", null);

    [CqlValueSetDefinition("Hematocrit lab test", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1045.114", valueSetVersion: null)]
    public CqlValueSet Hematocrit_lab_test(CqlContext _) => _Hematocrit_lab_test;
    private static readonly CqlValueSet _Hematocrit_lab_test = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1045.114", null);

    [CqlValueSetDefinition("Non Invasive Oxygen Therapy by Nasal Cannula or Mask", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1248.209", valueSetVersion: null)]
    public CqlValueSet Non_Invasive_Oxygen_Therapy_by_Nasal_Cannula_or_Mask(CqlContext _) => _Non_Invasive_Oxygen_Therapy_by_Nasal_Cannula_or_Mask;
    private static readonly CqlValueSet _Non_Invasive_Oxygen_Therapy_by_Nasal_Cannula_or_Mask = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1248.209", null);

    [CqlValueSetDefinition("Non Invasive Oxygen Therapy Device Codes", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1170.57", valueSetVersion: null)]
    public CqlValueSet Non_Invasive_Oxygen_Therapy_Device_Codes(CqlContext _) => _Non_Invasive_Oxygen_Therapy_Device_Codes;
    private static readonly CqlValueSet _Non_Invasive_Oxygen_Therapy_Device_Codes = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1170.57", null);

    [CqlValueSetDefinition("Medicare Advantage payer", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1104.12", valueSetVersion: null)]
    public CqlValueSet Medicare_Advantage_payer(CqlContext _) => _Medicare_Advantage_payer;
    private static readonly CqlValueSet _Medicare_Advantage_payer = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1104.12", null);

    [CqlValueSetDefinition("Medicare FFS payer", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1104.10", valueSetVersion: null)]
    public CqlValueSet Medicare_FFS_payer(CqlContext _) => _Medicare_FFS_payer;
    private static readonly CqlValueSet _Medicare_FFS_payer = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1104.10", null);

    [CqlValueSetDefinition("Oxygen Saturation by Pulse Oximetry", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1045.151", valueSetVersion: null)]
    public CqlValueSet Oxygen_Saturation_by_Pulse_Oximetry(CqlContext _) => _Oxygen_Saturation_by_Pulse_Oximetry;
    private static readonly CqlValueSet _Oxygen_Saturation_by_Pulse_Oximetry = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1045.151", null);

    [CqlValueSetDefinition("Potassium lab test", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1045.117", valueSetVersion: null)]
    public CqlValueSet Potassium_lab_test(CqlContext _) => _Potassium_lab_test;
    private static readonly CqlValueSet _Potassium_lab_test = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1045.117", null);

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
    public CqlInterval<CqlDateTime> Measurement_Period(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Measurement_Period, Measurement_Period_Compute);

    private const long _cacheIndex_Measurement_Period = -3907925994018979793L;

    private CqlInterval<CqlDateTime> Measurement_Period_Compute(CqlContext context)
    {
        CqlDateTime a_ = context.Operators.DateTime(2026, 1, 1, 0, 0, 0, 0, 0.0m);
        CqlDateTime b_ = context.Operators.DateTime(2027, 1, 1, 0, 0, 0, 0, 0.0m);
        CqlInterval<CqlDateTime> c_ = context.Operators.Interval(a_, b_, true, false);
        object d_ = context.ResolveParameter("CMSFHIR529HybridHospitalWideReadmission-0.5.001", "Measurement Period", c_);
        return (CqlInterval<CqlDateTime>)d_;
    }


    #endregion Parameters

    #region Functions and Expressions (21)

    [CqlExpressionDefinition("Patient")]
    public Patient Patient(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Patient, Patient_Compute);

    private const long _cacheIndex_Patient = 2363430323374039824L;

    private Patient Patient_Compute(CqlContext context)
    {
        IEnumerable<Patient> a_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-patient"));
        Patient b_ = context.Operators.SingletonFrom<Patient>(a_);
        return b_;
    }


    [CqlExpressionDefinition("Inpatient Encounters")]
    public IEnumerable<Encounter> Inpatient_Encounters(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Inpatient_Encounters, Inpatient_Encounters_Compute);

    private const long _cacheIndex_Inpatient_Encounters = 1973778819883977319L;

    private IEnumerable<Encounter> Inpatient_Encounters_Compute(CqlContext context)
    {
        CqlValueSet a_ = this.Encounter_Inpatient(context);
        IEnumerable<Encounter> b_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));

        bool? c_(Encounter InpatientEncounter) {
            CqlValueSet e_ = this.Medicare_FFS_payer(context);
            IEnumerable<Coverage> f_ = context.Operators.Retrieve<Coverage>(new RetrieveParameters(default, e_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-coverage"));
            CqlValueSet g_ = this.Medicare_Advantage_payer(context);
            IEnumerable<Coverage> h_ = context.Operators.Retrieve<Coverage>(new RetrieveParameters(default, g_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-coverage"));
            IEnumerable<Coverage> i_ = context.Operators.Union<Coverage>(f_, h_);

            bool? j_(Coverage MedicarePayer) {
                CqlInterval<CqlDateTime> l_ = CQMCommon_4_1_000.Instance.hospitalizationWithObservationAndOutpatientSurgeryService(context, InpatientEncounter);
                int? m_ = CQMCommon_4_1_000.Instance.lengthInDays(context, l_);
                bool? n_ = context.Operators.Less(m_, 365);
                bool? o_;
                // CQL 'and' (40:17-41:50): right operand skipped when left is false
                if (n_ is false)
                {
                    o_ = false;
                }
                else
                {
                    Code<Encounter.EncounterStatus> q_ = InpatientEncounter?.StatusElement;
                    Encounter.EncounterStatus? r_ = q_?.Value;
                    Code<Encounter.EncounterStatus> s_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(r_);
                    bool? t_ = context.Operators.Equal(s_, "finished");
                    o_ = n_ & t_;
                }
                bool? p_;
                // CQL 'and' (40:17-42:76): right operand skipped when left is false
                if (o_ is false)
                {
                    p_ = false;
                }
                else
                {
                    Patient u_ = this.Patient(context);
                    Date v_ = u_?.BirthDateElement;
                    string w_ = v_?.Value;
                    CqlDate x_ = context.Operators.ConvertStringToDate(w_);
                    Period y_ = InpatientEncounter?.Period;
                    CqlInterval<CqlDateTime> z_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, y_);
                    CqlDateTime aa_ = context.Operators.Start(z_);
                    CqlDate ab_ = context.Operators.DateFrom(aa_);
                    int? ac_ = context.Operators.CalculateAgeAt(x_, ab_, "year");
                    bool? ad_ = context.Operators.GreaterOrEqual(ac_, 65);
                    p_ = o_ & ad_;
                }
                // CQL 'and' (40:17-43:77): right operand skipped when left is false
                if (p_ is false)
                {
                    return false;
                }
                else
                {
                    Period ae_ = InpatientEncounter?.Period;
                    CqlInterval<CqlDateTime> af_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ae_);
                    CqlDateTime ag_ = context.Operators.End(af_);
                    CqlInterval<CqlDateTime> ah_ = this.Measurement_Period(context);
                    bool? ai_ = context.Operators.In<CqlDateTime>(ag_, ah_, "day");
                    return p_ & ai_;
                }
            }

            bool? k_ = context.Operators.WhereAny<Coverage>(i_, j_);
            return k_;
        }

        IEnumerable<Encounter> d_ = context.Operators.Where<Encounter>(b_, c_);
        return d_;
    }


    [CqlExpressionDefinition("Initial Population")]
    public IEnumerable<Encounter> Initial_Population(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Initial_Population, Initial_Population_Compute);

    private const long _cacheIndex_Initial_Population = 7214520858694362567L;

    private IEnumerable<Encounter> Initial_Population_Compute(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Inpatient_Encounters(context);
        return a_;
    }


    [CqlExpressionDefinition("SDE Encounter With First Body Temperature")]
    public IEnumerable<(CqlTupleMetadata, string EncounterId, CqlQuantity FirstTemperatureResult, CqlDateTime Timing)?> SDE_Encounter_With_First_Body_Temperature(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_SDE_Encounter_With_First_Body_Temperature, SDE_Encounter_With_First_Body_Temperature_Compute);

    private const long _cacheIndex_SDE_Encounter_With_First_Body_Temperature = -8666970491551489594L;

    private IEnumerable<(CqlTupleMetadata, string EncounterId, CqlQuantity FirstTemperatureResult, CqlDateTime Timing)?> SDE_Encounter_With_First_Body_Temperature_Compute(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Inpatient_Encounters(context);

        (CqlTupleMetadata, string EncounterId, CqlQuantity FirstTemperatureResult, CqlDateTime Timing)? b_(Encounter EncounterInpatient) {
            Id d_ = EncounterInpatient?.IdElement;
            string e_ = d_?.Value;
            IEnumerable<Observation> f_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/core/StructureDefinition/us-core-body-temperature"));

            bool? g_(Observation Temperature) {
                DataType w_ = Temperature?.Effective;
                object x_ = FHIRHelpers_4_4_000.Instance.ToValue(context, w_);
                CqlDateTime y_ = QICoreCommon_4_0_000.Instance.earliest(context, x_);
                CqlInterval<CqlDateTime> z_ = CQMCommon_4_1_000.Instance.hospitalizationWithObservationAndOutpatientSurgeryService(context, EncounterInpatient);
                bool? aa_ = context.Operators.In<CqlDateTime>(y_, z_, (string)default);
                bool? ab_;
                // CQL 'and' (48:15-49:71): right operand skipped when left is false
                if (aa_ is false)
                {
                    ab_ = false;
                }
                else
                {
                    Code<ObservationStatus> ac_ = Temperature?.StatusElement;
                    ObservationStatus? ad_ = ac_?.Value;
                    string ae_ = context.Operators.Convert<string>(ad_);
                    string[] af_ = [
                        "final",
                        "amended",
                        "corrected",
                    ];
                    bool? ag_ = context.Operators.In<string>(ae_, (IEnumerable<string>)af_);
                    ab_ = aa_ & ag_;
                }
                // CQL 'and' (48:9-50:43): right operand skipped when left is false
                if (ab_ is false)
                {
                    return false;
                }
                else
                {
                    DataType ah_ = Temperature?.Value;
                    CqlQuantity ai_ = FHIRHelpers_4_4_000.Instance.ToQuantity(context, ah_ as Quantity);
                    return ab_ & (!((bool?)(ai_ is null)));
                }
            }

            IEnumerable<Observation> h_ = context.Operators.Where<Observation>(f_, g_);

            object i_(Observation @this) {
                DataType aj_ = @this?.Effective;
                object ak_ = FHIRHelpers_4_4_000.Instance.ToValue(context, aj_);
                CqlDateTime al_ = QICoreCommon_4_0_000.Instance.earliest(context, ak_);
                return al_;
            }

            IEnumerable<Observation> j_ = context.Operators.SortBy<Observation>(h_, i_, System.ComponentModel.ListSortDirection.Ascending);
            Observation k_ = context.Operators.First<Observation>(j_);
            DataType l_ = k_?.Value;
            CqlQuantity m_ = FHIRHelpers_4_4_000.Instance.ToQuantity(context, l_ as Quantity);

            bool? n_(Observation Temperature) {
                DataType am_ = Temperature?.Effective;
                object an_ = FHIRHelpers_4_4_000.Instance.ToValue(context, am_);
                CqlDateTime ao_ = QICoreCommon_4_0_000.Instance.earliest(context, an_);
                CqlInterval<CqlDateTime> ap_ = CQMCommon_4_1_000.Instance.hospitalizationWithObservationAndOutpatientSurgeryService(context, EncounterInpatient);
                bool? aq_ = context.Operators.In<CqlDateTime>(ao_, ap_, (string)default);
                bool? ar_;
                // CQL 'and' (48:15-49:71): right operand skipped when left is false
                if (aq_ is false)
                {
                    ar_ = false;
                }
                else
                {
                    Code<ObservationStatus> as_ = Temperature?.StatusElement;
                    ObservationStatus? at_ = as_?.Value;
                    string au_ = context.Operators.Convert<string>(at_);
                    string[] av_ = [
                        "final",
                        "amended",
                        "corrected",
                    ];
                    bool? aw_ = context.Operators.In<string>(au_, (IEnumerable<string>)av_);
                    ar_ = aq_ & aw_;
                }
                // CQL 'and' (48:9-50:43): right operand skipped when left is false
                if (ar_ is false)
                {
                    return false;
                }
                else
                {
                    DataType ax_ = Temperature?.Value;
                    CqlQuantity ay_ = FHIRHelpers_4_4_000.Instance.ToQuantity(context, ax_ as Quantity);
                    return ar_ & (!((bool?)(ay_ is null)));
                }
            }

            IEnumerable<Observation> o_ = context.Operators.Where<Observation>(f_, n_);

            object p_(Observation @this) {
                DataType az_ = @this?.Effective;
                object ba_ = FHIRHelpers_4_4_000.Instance.ToValue(context, az_);
                CqlDateTime bb_ = QICoreCommon_4_0_000.Instance.earliest(context, ba_);
                return bb_;
            }

            IEnumerable<Observation> q_ = context.Operators.SortBy<Observation>(o_, p_, System.ComponentModel.ListSortDirection.Ascending);
            Observation r_ = context.Operators.First<Observation>(q_);
            DataType s_ = r_?.Effective;
            object t_ = FHIRHelpers_4_4_000.Instance.ToValue(context, s_);
            CqlDateTime u_ = QICoreCommon_4_0_000.Instance.earliest(context, t_);
            (CqlTupleMetadata, string EncounterId, CqlQuantity FirstTemperatureResult, CqlDateTime Timing)? v_ = (CqlTupleMetadata_GIbILVAdXLLNYBgcQIEiUiKaK, e_, m_ as CqlQuantity, u_);
            return v_;
        }

        IEnumerable<(CqlTupleMetadata, string EncounterId, CqlQuantity FirstTemperatureResult, CqlDateTime Timing)?> c_ = context.Operators.SelectDistinct<Encounter, (CqlTupleMetadata, string EncounterId, CqlQuantity FirstTemperatureResult, CqlDateTime Timing)?>(a_, b_);
        return c_;
    }


    [CqlExpressionDefinition("SDE Encounter With First Heart Rate")]
    public IEnumerable<(CqlTupleMetadata, string EncounterId, CqlQuantity FirstHeartRateResult, CqlDateTime Timing)?> SDE_Encounter_With_First_Heart_Rate(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_SDE_Encounter_With_First_Heart_Rate, SDE_Encounter_With_First_Heart_Rate_Compute);

    private const long _cacheIndex_SDE_Encounter_With_First_Heart_Rate = 1290876252074881306L;

    private IEnumerable<(CqlTupleMetadata, string EncounterId, CqlQuantity FirstHeartRateResult, CqlDateTime Timing)?> SDE_Encounter_With_First_Heart_Rate_Compute(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Inpatient_Encounters(context);

        (CqlTupleMetadata, string EncounterId, CqlQuantity FirstHeartRateResult, CqlDateTime Timing)? b_(Encounter EncounterInpatient) {
            Id d_ = EncounterInpatient?.IdElement;
            string e_ = d_?.Value;
            IEnumerable<Observation> f_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/core/StructureDefinition/us-core-heart-rate"));

            bool? g_(Observation HeartRate) {
                DataType w_ = HeartRate?.Effective;
                object x_ = FHIRHelpers_4_4_000.Instance.ToValue(context, w_);
                CqlDateTime y_ = QICoreCommon_4_0_000.Instance.earliest(context, x_);
                CqlInterval<CqlDateTime> z_ = CQMCommon_4_1_000.Instance.hospitalizationWithObservationAndOutpatientSurgeryService(context, EncounterInpatient);
                bool? aa_ = context.Operators.In<CqlDateTime>(y_, z_, (string)default);
                bool? ab_;
                // CQL 'and' (62:15-63:69): right operand skipped when left is false
                if (aa_ is false)
                {
                    ab_ = false;
                }
                else
                {
                    Code<ObservationStatus> ac_ = HeartRate?.StatusElement;
                    ObservationStatus? ad_ = ac_?.Value;
                    string ae_ = context.Operators.Convert<string>(ad_);
                    string[] af_ = [
                        "final",
                        "amended",
                        "corrected",
                    ];
                    bool? ag_ = context.Operators.In<string>(ae_, (IEnumerable<string>)af_);
                    ab_ = aa_ & ag_;
                }
                // CQL 'and' (62:9-64:41): right operand skipped when left is false
                if (ab_ is false)
                {
                    return false;
                }
                else
                {
                    DataType ah_ = HeartRate?.Value;
                    CqlQuantity ai_ = FHIRHelpers_4_4_000.Instance.ToQuantity(context, ah_ as Quantity);
                    return ab_ & (!((bool?)(ai_ is null)));
                }
            }

            IEnumerable<Observation> h_ = context.Operators.Where<Observation>(f_, g_);

            object i_(Observation @this) {
                DataType aj_ = @this?.Effective;
                object ak_ = FHIRHelpers_4_4_000.Instance.ToValue(context, aj_);
                CqlDateTime al_ = QICoreCommon_4_0_000.Instance.earliest(context, ak_);
                return al_;
            }

            IEnumerable<Observation> j_ = context.Operators.SortBy<Observation>(h_, i_, System.ComponentModel.ListSortDirection.Ascending);
            Observation k_ = context.Operators.First<Observation>(j_);
            DataType l_ = k_?.Value;
            CqlQuantity m_ = FHIRHelpers_4_4_000.Instance.ToQuantity(context, l_ as Quantity);

            bool? n_(Observation HeartRate) {
                DataType am_ = HeartRate?.Effective;
                object an_ = FHIRHelpers_4_4_000.Instance.ToValue(context, am_);
                CqlDateTime ao_ = QICoreCommon_4_0_000.Instance.earliest(context, an_);
                CqlInterval<CqlDateTime> ap_ = CQMCommon_4_1_000.Instance.hospitalizationWithObservationAndOutpatientSurgeryService(context, EncounterInpatient);
                bool? aq_ = context.Operators.In<CqlDateTime>(ao_, ap_, (string)default);
                bool? ar_;
                // CQL 'and' (62:15-63:69): right operand skipped when left is false
                if (aq_ is false)
                {
                    ar_ = false;
                }
                else
                {
                    Code<ObservationStatus> as_ = HeartRate?.StatusElement;
                    ObservationStatus? at_ = as_?.Value;
                    string au_ = context.Operators.Convert<string>(at_);
                    string[] av_ = [
                        "final",
                        "amended",
                        "corrected",
                    ];
                    bool? aw_ = context.Operators.In<string>(au_, (IEnumerable<string>)av_);
                    ar_ = aq_ & aw_;
                }
                // CQL 'and' (62:9-64:41): right operand skipped when left is false
                if (ar_ is false)
                {
                    return false;
                }
                else
                {
                    DataType ax_ = HeartRate?.Value;
                    CqlQuantity ay_ = FHIRHelpers_4_4_000.Instance.ToQuantity(context, ax_ as Quantity);
                    return ar_ & (!((bool?)(ay_ is null)));
                }
            }

            IEnumerable<Observation> o_ = context.Operators.Where<Observation>(f_, n_);

            object p_(Observation @this) {
                DataType az_ = @this?.Effective;
                object ba_ = FHIRHelpers_4_4_000.Instance.ToValue(context, az_);
                CqlDateTime bb_ = QICoreCommon_4_0_000.Instance.earliest(context, ba_);
                return bb_;
            }

            IEnumerable<Observation> q_ = context.Operators.SortBy<Observation>(o_, p_, System.ComponentModel.ListSortDirection.Ascending);
            Observation r_ = context.Operators.First<Observation>(q_);
            DataType s_ = r_?.Effective;
            object t_ = FHIRHelpers_4_4_000.Instance.ToValue(context, s_);
            CqlDateTime u_ = QICoreCommon_4_0_000.Instance.earliest(context, t_);
            (CqlTupleMetadata, string EncounterId, CqlQuantity FirstHeartRateResult, CqlDateTime Timing)? v_ = (CqlTupleMetadata_DhbJAfCiKIAGYKTjJXYGSKECQ, e_, m_ as CqlQuantity, u_);
            return v_;
        }

        IEnumerable<(CqlTupleMetadata, string EncounterId, CqlQuantity FirstHeartRateResult, CqlDateTime Timing)?> c_ = context.Operators.SelectDistinct<Encounter, (CqlTupleMetadata, string EncounterId, CqlQuantity FirstHeartRateResult, CqlDateTime Timing)?>(a_, b_);
        return c_;
    }


    [CqlExpressionDefinition("SDE Encounter With First Oxygen Saturation")]
    public IEnumerable<(CqlTupleMetadata, string EncounterId, CqlQuantity FirstOxygenSatResult, CqlDateTime Timing)?> SDE_Encounter_With_First_Oxygen_Saturation(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_SDE_Encounter_With_First_Oxygen_Saturation, SDE_Encounter_With_First_Oxygen_Saturation_Compute);

    private const long _cacheIndex_SDE_Encounter_With_First_Oxygen_Saturation = -7704303822154817864L;

    private IEnumerable<(CqlTupleMetadata, string EncounterId, CqlQuantity FirstOxygenSatResult, CqlDateTime Timing)?> SDE_Encounter_With_First_Oxygen_Saturation_Compute(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Inpatient_Encounters(context);

        (CqlTupleMetadata, string EncounterId, CqlQuantity FirstOxygenSatResult, CqlDateTime Timing)? b_(Encounter EncounterInpatient) {
            Id d_ = EncounterInpatient?.IdElement;
            string e_ = d_?.Value;
            CqlValueSet f_ = this.Oxygen_Saturation_by_Pulse_Oximetry(context);
            IEnumerable<Observation> g_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, f_, default, "http://hl7.org/fhir/us/core/StructureDefinition/us-core-pulse-oximetry"));

            bool? h_(Observation O2Saturation) {
                DataType x_ = O2Saturation?.Effective;
                object y_ = FHIRHelpers_4_4_000.Instance.ToValue(context, x_);
                CqlDateTime z_ = QICoreCommon_4_0_000.Instance.earliest(context, y_);
                CqlInterval<CqlDateTime> aa_ = CQMCommon_4_1_000.Instance.hospitalizationWithObservationAndOutpatientSurgeryService(context, EncounterInpatient);
                bool? ab_ = context.Operators.In<CqlDateTime>(z_, aa_, (string)default);
                bool? ac_;
                // CQL 'and' (76:15-77:72): right operand skipped when left is false
                if (ab_ is false)
                {
                    ac_ = false;
                }
                else
                {
                    Code<ObservationStatus> ad_ = O2Saturation?.StatusElement;
                    ObservationStatus? ae_ = ad_?.Value;
                    string af_ = context.Operators.Convert<string>(ae_);
                    string[] ag_ = [
                        "final",
                        "amended",
                        "corrected",
                    ];
                    bool? ah_ = context.Operators.In<string>(af_, (IEnumerable<string>)ag_);
                    ac_ = ab_ & ah_;
                }
                // CQL 'and' (76:9-78:44): right operand skipped when left is false
                if (ac_ is false)
                {
                    return false;
                }
                else
                {
                    DataType ai_ = O2Saturation?.Value;
                    CqlQuantity aj_ = FHIRHelpers_4_4_000.Instance.ToQuantity(context, ai_ as Quantity);
                    return ac_ & (!((bool?)(aj_ is null)));
                }
            }

            IEnumerable<Observation> i_ = context.Operators.Where<Observation>(g_, h_);

            object j_(Observation @this) {
                DataType ak_ = @this?.Effective;
                object al_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ak_);
                CqlDateTime am_ = QICoreCommon_4_0_000.Instance.earliest(context, al_);
                return am_;
            }

            IEnumerable<Observation> k_ = context.Operators.SortBy<Observation>(i_, j_, System.ComponentModel.ListSortDirection.Ascending);
            Observation l_ = context.Operators.First<Observation>(k_);
            DataType m_ = l_?.Value;
            CqlQuantity n_ = FHIRHelpers_4_4_000.Instance.ToQuantity(context, m_ as Quantity);

            bool? o_(Observation O2Saturation) {
                DataType an_ = O2Saturation?.Effective;
                object ao_ = FHIRHelpers_4_4_000.Instance.ToValue(context, an_);
                CqlDateTime ap_ = QICoreCommon_4_0_000.Instance.earliest(context, ao_);
                CqlInterval<CqlDateTime> aq_ = CQMCommon_4_1_000.Instance.hospitalizationWithObservationAndOutpatientSurgeryService(context, EncounterInpatient);
                bool? ar_ = context.Operators.In<CqlDateTime>(ap_, aq_, (string)default);
                bool? as_;
                // CQL 'and' (76:15-77:72): right operand skipped when left is false
                if (ar_ is false)
                {
                    as_ = false;
                }
                else
                {
                    Code<ObservationStatus> at_ = O2Saturation?.StatusElement;
                    ObservationStatus? au_ = at_?.Value;
                    string av_ = context.Operators.Convert<string>(au_);
                    string[] aw_ = [
                        "final",
                        "amended",
                        "corrected",
                    ];
                    bool? ax_ = context.Operators.In<string>(av_, (IEnumerable<string>)aw_);
                    as_ = ar_ & ax_;
                }
                // CQL 'and' (76:9-78:44): right operand skipped when left is false
                if (as_ is false)
                {
                    return false;
                }
                else
                {
                    DataType ay_ = O2Saturation?.Value;
                    CqlQuantity az_ = FHIRHelpers_4_4_000.Instance.ToQuantity(context, ay_ as Quantity);
                    return as_ & (!((bool?)(az_ is null)));
                }
            }

            IEnumerable<Observation> p_ = context.Operators.Where<Observation>(g_, o_);

            object q_(Observation @this) {
                DataType ba_ = @this?.Effective;
                object bb_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ba_);
                CqlDateTime bc_ = QICoreCommon_4_0_000.Instance.earliest(context, bb_);
                return bc_;
            }

            IEnumerable<Observation> r_ = context.Operators.SortBy<Observation>(p_, q_, System.ComponentModel.ListSortDirection.Ascending);
            Observation s_ = context.Operators.First<Observation>(r_);
            DataType t_ = s_?.Effective;
            object u_ = FHIRHelpers_4_4_000.Instance.ToValue(context, t_);
            CqlDateTime v_ = QICoreCommon_4_0_000.Instance.earliest(context, u_);
            (CqlTupleMetadata, string EncounterId, CqlQuantity FirstOxygenSatResult, CqlDateTime Timing)? w_ = (CqlTupleMetadata_FdREYEdHOZIcMCNYCRFJYJReA, e_, n_ as CqlQuantity, v_);
            return w_;
        }

        IEnumerable<(CqlTupleMetadata, string EncounterId, CqlQuantity FirstOxygenSatResult, CqlDateTime Timing)?> c_ = context.Operators.SelectDistinct<Encounter, (CqlTupleMetadata, string EncounterId, CqlQuantity FirstOxygenSatResult, CqlDateTime Timing)?>(a_, b_);
        return c_;
    }


    [CqlExpressionDefinition("SDE Encounter With First Respiratory Rate")]
    public IEnumerable<(CqlTupleMetadata, string EncounterId, CqlQuantity FirstRespRateResult, CqlDateTime Timing)?> SDE_Encounter_With_First_Respiratory_Rate(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_SDE_Encounter_With_First_Respiratory_Rate, SDE_Encounter_With_First_Respiratory_Rate_Compute);

    private const long _cacheIndex_SDE_Encounter_With_First_Respiratory_Rate = -1971867522856708175L;

    private IEnumerable<(CqlTupleMetadata, string EncounterId, CqlQuantity FirstRespRateResult, CqlDateTime Timing)?> SDE_Encounter_With_First_Respiratory_Rate_Compute(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Inpatient_Encounters(context);

        (CqlTupleMetadata, string EncounterId, CqlQuantity FirstRespRateResult, CqlDateTime Timing)? b_(Encounter EncounterInpatient) {
            Id d_ = EncounterInpatient?.IdElement;
            string e_ = d_?.Value;
            IEnumerable<Observation> f_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/core/StructureDefinition/us-core-respiratory-rate"));

            bool? g_(Observation Respirations) {
                DataType w_ = Respirations?.Effective;
                object x_ = FHIRHelpers_4_4_000.Instance.ToValue(context, w_);
                CqlDateTime y_ = QICoreCommon_4_0_000.Instance.earliest(context, x_);
                CqlInterval<CqlDateTime> z_ = CQMCommon_4_1_000.Instance.hospitalizationWithObservationAndOutpatientSurgeryService(context, EncounterInpatient);
                bool? aa_ = context.Operators.In<CqlDateTime>(y_, z_, (string)default);
                bool? ab_;
                // CQL 'and' (90:15-91:72): right operand skipped when left is false
                if (aa_ is false)
                {
                    ab_ = false;
                }
                else
                {
                    Code<ObservationStatus> ac_ = Respirations?.StatusElement;
                    ObservationStatus? ad_ = ac_?.Value;
                    string ae_ = context.Operators.Convert<string>(ad_);
                    string[] af_ = [
                        "final",
                        "amended",
                        "corrected",
                    ];
                    bool? ag_ = context.Operators.In<string>(ae_, (IEnumerable<string>)af_);
                    ab_ = aa_ & ag_;
                }
                // CQL 'and' (90:9-92:44): right operand skipped when left is false
                if (ab_ is false)
                {
                    return false;
                }
                else
                {
                    DataType ah_ = Respirations?.Value;
                    CqlQuantity ai_ = FHIRHelpers_4_4_000.Instance.ToQuantity(context, ah_ as Quantity);
                    return ab_ & (!((bool?)(ai_ is null)));
                }
            }

            IEnumerable<Observation> h_ = context.Operators.Where<Observation>(f_, g_);

            object i_(Observation @this) {
                DataType aj_ = @this?.Effective;
                object ak_ = FHIRHelpers_4_4_000.Instance.ToValue(context, aj_);
                CqlDateTime al_ = QICoreCommon_4_0_000.Instance.earliest(context, ak_);
                return al_;
            }

            IEnumerable<Observation> j_ = context.Operators.SortBy<Observation>(h_, i_, System.ComponentModel.ListSortDirection.Ascending);
            Observation k_ = context.Operators.First<Observation>(j_);
            DataType l_ = k_?.Value;
            CqlQuantity m_ = FHIRHelpers_4_4_000.Instance.ToQuantity(context, l_ as Quantity);

            bool? n_(Observation Respirations) {
                DataType am_ = Respirations?.Effective;
                object an_ = FHIRHelpers_4_4_000.Instance.ToValue(context, am_);
                CqlDateTime ao_ = QICoreCommon_4_0_000.Instance.earliest(context, an_);
                CqlInterval<CqlDateTime> ap_ = CQMCommon_4_1_000.Instance.hospitalizationWithObservationAndOutpatientSurgeryService(context, EncounterInpatient);
                bool? aq_ = context.Operators.In<CqlDateTime>(ao_, ap_, (string)default);
                bool? ar_;
                // CQL 'and' (90:15-91:72): right operand skipped when left is false
                if (aq_ is false)
                {
                    ar_ = false;
                }
                else
                {
                    Code<ObservationStatus> as_ = Respirations?.StatusElement;
                    ObservationStatus? at_ = as_?.Value;
                    string au_ = context.Operators.Convert<string>(at_);
                    string[] av_ = [
                        "final",
                        "amended",
                        "corrected",
                    ];
                    bool? aw_ = context.Operators.In<string>(au_, (IEnumerable<string>)av_);
                    ar_ = aq_ & aw_;
                }
                // CQL 'and' (90:9-92:44): right operand skipped when left is false
                if (ar_ is false)
                {
                    return false;
                }
                else
                {
                    DataType ax_ = Respirations?.Value;
                    CqlQuantity ay_ = FHIRHelpers_4_4_000.Instance.ToQuantity(context, ax_ as Quantity);
                    return ar_ & (!((bool?)(ay_ is null)));
                }
            }

            IEnumerable<Observation> o_ = context.Operators.Where<Observation>(f_, n_);

            object p_(Observation @this) {
                DataType az_ = @this?.Effective;
                object ba_ = FHIRHelpers_4_4_000.Instance.ToValue(context, az_);
                CqlDateTime bb_ = QICoreCommon_4_0_000.Instance.earliest(context, ba_);
                return bb_;
            }

            IEnumerable<Observation> q_ = context.Operators.SortBy<Observation>(o_, p_, System.ComponentModel.ListSortDirection.Ascending);
            Observation r_ = context.Operators.First<Observation>(q_);
            DataType s_ = r_?.Effective;
            object t_ = FHIRHelpers_4_4_000.Instance.ToValue(context, s_);
            CqlDateTime u_ = QICoreCommon_4_0_000.Instance.earliest(context, t_);
            (CqlTupleMetadata, string EncounterId, CqlQuantity FirstRespRateResult, CqlDateTime Timing)? v_ = (CqlTupleMetadata_CYbMQaXdPgTVSLXJSHHNTbhVM, e_, m_ as CqlQuantity, u_);
            return v_;
        }

        IEnumerable<(CqlTupleMetadata, string EncounterId, CqlQuantity FirstRespRateResult, CqlDateTime Timing)?> c_ = context.Operators.SelectDistinct<Encounter, (CqlTupleMetadata, string EncounterId, CqlQuantity FirstRespRateResult, CqlDateTime Timing)?>(a_, b_);
        return c_;
    }


    [CqlExpressionDefinition("SDE Encounter With First Systolic Blood Pressure")]
    public IEnumerable<(CqlTupleMetadata, string EncounterId, IEnumerable<CqlQuantity> FirstSBPResult, CqlDateTime Timing)?> SDE_Encounter_With_First_Systolic_Blood_Pressure(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_SDE_Encounter_With_First_Systolic_Blood_Pressure, SDE_Encounter_With_First_Systolic_Blood_Pressure_Compute);

    private const long _cacheIndex_SDE_Encounter_With_First_Systolic_Blood_Pressure = 3660447906796988770L;

    private IEnumerable<(CqlTupleMetadata, string EncounterId, IEnumerable<CqlQuantity> FirstSBPResult, CqlDateTime Timing)?> SDE_Encounter_With_First_Systolic_Blood_Pressure_Compute(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Inpatient_Encounters(context);

        (CqlTupleMetadata, string EncounterId, IEnumerable<CqlQuantity> FirstSBPResult, CqlDateTime Timing)? b_(Encounter EncounterInpatient) {
            Id d_ = EncounterInpatient?.IdElement;
            string e_ = d_?.Value;
            IEnumerable<Observation> f_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/core/StructureDefinition/us-core-blood-pressure"));

            bool? g_(Observation BP) {
                DataType z_ = BP?.Effective;
                object aa_ = FHIRHelpers_4_4_000.Instance.ToValue(context, z_);
                CqlDateTime ab_ = QICoreCommon_4_0_000.Instance.earliest(context, aa_);
                CqlInterval<CqlDateTime> ac_ = CQMCommon_4_1_000.Instance.hospitalizationWithObservationAndOutpatientSurgeryService(context, EncounterInpatient);
                bool? ad_ = context.Operators.In<CqlDateTime>(ab_, ac_, (string)default);
                bool? ae_;
                // CQL 'and' (104:15-105:62): right operand skipped when left is false
                if (ad_ is false)
                {
                    ae_ = false;
                }
                else
                {
                    Code<ObservationStatus> af_ = BP?.StatusElement;
                    ObservationStatus? ag_ = af_?.Value;
                    string ah_ = context.Operators.Convert<string>(ag_);
                    string[] ai_ = [
                        "final",
                        "amended",
                        "corrected",
                    ];
                    bool? aj_ = context.Operators.In<string>(ah_, (IEnumerable<string>)ai_);
                    ae_ = ad_ & aj_;
                }
                // CQL 'and' (104:9-106:44): right operand skipped when left is false
                if (ae_ is false)
                {
                    return false;
                }
                else
                {
                    List<Observation.ComponentComponent> ak_ = BP?.Component;

                    bool? al_(Observation.ComponentComponent @this) {
                        DataType ao_ = @this?.Value;
                        object ap_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ao_);
                        return !((bool?)(ap_ is null));
                    }


                    object am_(Observation.ComponentComponent @this) {
                        DataType aq_ = @this?.Value;
                        object ar_ = FHIRHelpers_4_4_000.Instance.ToValue(context, aq_);
                        return ar_;
                    }

                    IEnumerable<object> an_ = context.Operators.WhereSelect<Observation.ComponentComponent, object>((IEnumerable<Observation.ComponentComponent>)ak_, al_, am_);
                    return ae_ & (!((bool?)(an_ is null)));
                }
            }

            IEnumerable<Observation> h_ = context.Operators.Where<Observation>(f_, g_);

            object i_(Observation @this) {
                DataType as_ = @this?.Effective;
                object at_ = FHIRHelpers_4_4_000.Instance.ToValue(context, as_);
                CqlDateTime au_ = QICoreCommon_4_0_000.Instance.earliest(context, at_);
                return au_;
            }

            IEnumerable<Observation> j_ = context.Operators.SortBy<Observation>(h_, i_, System.ComponentModel.ListSortDirection.Ascending);
            Observation k_ = context.Operators.First<Observation>(j_);
            List<Observation.ComponentComponent> l_ = k_?.Component;

            bool? m_(Observation.ComponentComponent C) {
                CodeableConcept av_ = C?.Code;
                CqlConcept aw_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, av_);
                CqlCode ax_ = this.Systolic_blood_pressure(context);
                CqlConcept ay_ = context.Operators.ConvertCodeToConcept(ax_);
                bool? az_ = context.Operators.Equivalent(aw_, ay_);
                return az_;
            }


            CqlQuantity n_(Observation.ComponentComponent C) {
                DataType ba_ = C?.Value;
                object bb_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ba_);
                return bb_ as CqlQuantity;
            }

            IEnumerable<CqlQuantity> o_ = context.Operators.WhereSelect<Observation.ComponentComponent, CqlQuantity>((IEnumerable<Observation.ComponentComponent>)l_, m_, n_);
            IEnumerable<CqlQuantity> p_ = context.Operators.Distinct<CqlQuantity>(o_);

            bool? q_(Observation BP) {
                DataType bc_ = BP?.Effective;
                object bd_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bc_);
                CqlDateTime be_ = QICoreCommon_4_0_000.Instance.earliest(context, bd_);
                CqlInterval<CqlDateTime> bf_ = CQMCommon_4_1_000.Instance.hospitalizationWithObservationAndOutpatientSurgeryService(context, EncounterInpatient);
                bool? bg_ = context.Operators.In<CqlDateTime>(be_, bf_, (string)default);
                bool? bh_;
                // CQL 'and' (104:15-105:62): right operand skipped when left is false
                if (bg_ is false)
                {
                    bh_ = false;
                }
                else
                {
                    Code<ObservationStatus> bi_ = BP?.StatusElement;
                    ObservationStatus? bj_ = bi_?.Value;
                    string bk_ = context.Operators.Convert<string>(bj_);
                    string[] bl_ = [
                        "final",
                        "amended",
                        "corrected",
                    ];
                    bool? bm_ = context.Operators.In<string>(bk_, (IEnumerable<string>)bl_);
                    bh_ = bg_ & bm_;
                }
                // CQL 'and' (104:9-106:44): right operand skipped when left is false
                if (bh_ is false)
                {
                    return false;
                }
                else
                {
                    List<Observation.ComponentComponent> bn_ = BP?.Component;

                    bool? bo_(Observation.ComponentComponent @this) {
                        DataType br_ = @this?.Value;
                        object bs_ = FHIRHelpers_4_4_000.Instance.ToValue(context, br_);
                        return !((bool?)(bs_ is null));
                    }


                    object bp_(Observation.ComponentComponent @this) {
                        DataType bt_ = @this?.Value;
                        object bu_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bt_);
                        return bu_;
                    }

                    IEnumerable<object> bq_ = context.Operators.WhereSelect<Observation.ComponentComponent, object>((IEnumerable<Observation.ComponentComponent>)bn_, bo_, bp_);
                    return bh_ & (!((bool?)(bq_ is null)));
                }
            }

            IEnumerable<Observation> r_ = context.Operators.Where<Observation>(f_, q_);

            object s_(Observation @this) {
                DataType bv_ = @this?.Effective;
                object bw_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bv_);
                CqlDateTime bx_ = QICoreCommon_4_0_000.Instance.earliest(context, bw_);
                return bx_;
            }

            IEnumerable<Observation> t_ = context.Operators.SortBy<Observation>(r_, s_, System.ComponentModel.ListSortDirection.Ascending);
            Observation u_ = context.Operators.First<Observation>(t_);
            DataType v_ = u_?.Effective;
            object w_ = FHIRHelpers_4_4_000.Instance.ToValue(context, v_);
            CqlDateTime x_ = QICoreCommon_4_0_000.Instance.earliest(context, w_);
            (CqlTupleMetadata, string EncounterId, IEnumerable<CqlQuantity> FirstSBPResult, CqlDateTime Timing)? y_ = (CqlTupleMetadata_FjSKXeIESORPNbRGajibMfUaK, e_, p_, x_);
            return y_;
        }

        IEnumerable<(CqlTupleMetadata, string EncounterId, IEnumerable<CqlQuantity> FirstSBPResult, CqlDateTime Timing)?> c_ = context.Operators.SelectDistinct<Encounter, (CqlTupleMetadata, string EncounterId, IEnumerable<CqlQuantity> FirstSBPResult, CqlDateTime Timing)?>(a_, b_);
        return c_;
    }


    [CqlExpressionDefinition("SDE Encounter With First Bicarbonate Lab Test")]
    public IEnumerable<(CqlTupleMetadata, string EncounterId, CqlQuantity FirstResult, CqlDateTime Timing)?> SDE_Encounter_With_First_Bicarbonate_Lab_Test(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_SDE_Encounter_With_First_Bicarbonate_Lab_Test, SDE_Encounter_With_First_Bicarbonate_Lab_Test_Compute);

    private const long _cacheIndex_SDE_Encounter_With_First_Bicarbonate_Lab_Test = -4393915463316232653L;

    private IEnumerable<(CqlTupleMetadata, string EncounterId, CqlQuantity FirstResult, CqlDateTime Timing)?> SDE_Encounter_With_First_Bicarbonate_Lab_Test_Compute(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Inpatient_Encounters(context);

        (CqlTupleMetadata, string EncounterId, CqlQuantity FirstResult, CqlDateTime Timing)? b_(Encounter EncounterInpatient) {
            Id d_ = EncounterInpatient?.IdElement;
            string e_ = d_?.Value;
            CqlValueSet f_ = this.Bicarbonate_lab_test(context);
            IEnumerable<Observation> g_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, f_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation-lab"));

            bool? h_(Observation bicarbonatelab) {
                object x_;
                DataType ac_ = bicarbonatelab?.Effective;
                object ad_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ac_);
                bool ae_ = ad_ is CqlDateTime;
                if (ae_)
                {
                    DataType af_ = bicarbonatelab?.Effective;
                    object ag_ = FHIRHelpers_4_4_000.Instance.ToValue(context, af_);
                    x_ = ag_ as CqlDateTime;
                }
                else
                {
                    DataType ah_ = bicarbonatelab?.Effective;
                    object ai_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ah_);
                    bool aj_ = ai_ is CqlDateTime;
                    if (aj_)
                    {
                        DataType ak_ = bicarbonatelab?.Effective;
                        object al_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ak_);
                        x_ = al_ as CqlDateTime;
                    }
                    else
                    {
                        DataType am_ = bicarbonatelab?.Effective;
                        object an_ = FHIRHelpers_4_4_000.Instance.ToValue(context, am_);
                        bool ao_ = an_ is CqlInterval<CqlDateTime>;
                        if (ao_)
                        {
                            DataType ap_ = bicarbonatelab?.Effective;
                            object aq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ap_);
                            x_ = aq_ as CqlInterval<CqlDateTime>;
                        }
                        else
                        {
                            x_ = null;
                        }
                    }
                }
                CqlDateTime y_ = QICoreCommon_4_0_000.Instance.earliest(context, x_);
                CqlInterval<CqlDateTime> z_ = CQMCommon_4_1_000.Instance.hospitalizationWithObservationAndOutpatientSurgeryService(context, EncounterInpatient);
                bool? aa_ = context.Operators.In<CqlDateTime>(y_, z_, (string)default);
                bool? ab_;
                // CQL 'and' (120:15-121:74): right operand skipped when left is false
                if (aa_ is false)
                {
                    ab_ = false;
                }
                else
                {
                    Code<ObservationStatus> ar_ = bicarbonatelab?.StatusElement;
                    ObservationStatus? as_ = ar_?.Value;
                    string at_ = context.Operators.Convert<string>(as_);
                    string[] au_ = [
                        "final",
                        "amended",
                        "corrected",
                    ];
                    bool? av_ = context.Operators.In<string>(at_, (IEnumerable<string>)au_);
                    ab_ = aa_ & av_;
                }
                // CQL 'and' (120:9-122:46): right operand skipped when left is false
                if (ab_ is false)
                {
                    return false;
                }
                else
                {
                    DataType aw_ = bicarbonatelab?.Value;
                    object ax_ = FHIRHelpers_4_4_000.Instance.ToValue(context, aw_);
                    return ab_ & (!((bool?)(ax_ is null)));
                }
            }

            IEnumerable<Observation> i_ = context.Operators.Where<Observation>(g_, h_);

            object j_(Observation @this) {
                Instant ay_ = @this?.IssuedElement;
                DateTimeOffset? az_ = ay_?.Value;
                CqlDateTime ba_ = context.Operators.Convert<CqlDateTime>(az_);
                CqlDateTime bb_ = QICoreCommon_4_0_000.Instance.earliest(context, ba_);
                return bb_;
            }

            IEnumerable<Observation> k_ = context.Operators.SortBy<Observation>(i_, j_, System.ComponentModel.ListSortDirection.Ascending);
            Observation l_ = context.Operators.First<Observation>(k_);
            DataType m_ = l_?.Value;
            object n_ = FHIRHelpers_4_4_000.Instance.ToValue(context, m_);

            bool? o_(Observation bicarbonatelab) {
                object bc_;
                DataType bh_ = bicarbonatelab?.Effective;
                object bi_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bh_);
                bool bj_ = bi_ is CqlDateTime;
                if (bj_)
                {
                    DataType bk_ = bicarbonatelab?.Effective;
                    object bl_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bk_);
                    bc_ = bl_ as CqlDateTime;
                }
                else
                {
                    DataType bm_ = bicarbonatelab?.Effective;
                    object bn_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bm_);
                    bool bo_ = bn_ is CqlDateTime;
                    if (bo_)
                    {
                        DataType bp_ = bicarbonatelab?.Effective;
                        object bq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bp_);
                        bc_ = bq_ as CqlDateTime;
                    }
                    else
                    {
                        DataType br_ = bicarbonatelab?.Effective;
                        object bs_ = FHIRHelpers_4_4_000.Instance.ToValue(context, br_);
                        bool bt_ = bs_ is CqlInterval<CqlDateTime>;
                        if (bt_)
                        {
                            DataType bu_ = bicarbonatelab?.Effective;
                            object bv_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bu_);
                            bc_ = bv_ as CqlInterval<CqlDateTime>;
                        }
                        else
                        {
                            bc_ = null;
                        }
                    }
                }
                CqlDateTime bd_ = QICoreCommon_4_0_000.Instance.earliest(context, bc_);
                CqlInterval<CqlDateTime> be_ = CQMCommon_4_1_000.Instance.hospitalizationWithObservationAndOutpatientSurgeryService(context, EncounterInpatient);
                bool? bf_ = context.Operators.In<CqlDateTime>(bd_, be_, (string)default);
                bool? bg_;
                // CQL 'and' (120:15-121:74): right operand skipped when left is false
                if (bf_ is false)
                {
                    bg_ = false;
                }
                else
                {
                    Code<ObservationStatus> bw_ = bicarbonatelab?.StatusElement;
                    ObservationStatus? bx_ = bw_?.Value;
                    string by_ = context.Operators.Convert<string>(bx_);
                    string[] bz_ = [
                        "final",
                        "amended",
                        "corrected",
                    ];
                    bool? ca_ = context.Operators.In<string>(by_, (IEnumerable<string>)bz_);
                    bg_ = bf_ & ca_;
                }
                // CQL 'and' (120:9-122:46): right operand skipped when left is false
                if (bg_ is false)
                {
                    return false;
                }
                else
                {
                    DataType cb_ = bicarbonatelab?.Value;
                    object cc_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cb_);
                    return bg_ & (!((bool?)(cc_ is null)));
                }
            }

            IEnumerable<Observation> p_ = context.Operators.Where<Observation>(g_, o_);

            object q_(Observation @this) {
                Instant cd_ = @this?.IssuedElement;
                DateTimeOffset? ce_ = cd_?.Value;
                CqlDateTime cf_ = context.Operators.Convert<CqlDateTime>(ce_);
                CqlDateTime cg_ = QICoreCommon_4_0_000.Instance.earliest(context, cf_);
                return cg_;
            }

            IEnumerable<Observation> r_ = context.Operators.SortBy<Observation>(p_, q_, System.ComponentModel.ListSortDirection.Ascending);
            Observation s_ = context.Operators.First<Observation>(r_);
            Instant t_ = s_?.IssuedElement;
            DateTimeOffset? u_ = t_?.Value;
            CqlDateTime v_ = context.Operators.Convert<CqlDateTime>(u_);
            (CqlTupleMetadata, string EncounterId, CqlQuantity FirstResult, CqlDateTime Timing)? w_ = (CqlTupleMetadata_HDVhZFAYAdGHPZJWcDFSNFGPd, e_, n_ as CqlQuantity, v_);
            return w_;
        }

        IEnumerable<(CqlTupleMetadata, string EncounterId, CqlQuantity FirstResult, CqlDateTime Timing)?> c_ = context.Operators.SelectDistinct<Encounter, (CqlTupleMetadata, string EncounterId, CqlQuantity FirstResult, CqlDateTime Timing)?>(a_, b_);
        return c_;
    }


    [CqlExpressionDefinition("SDE Encounter With First Creatinine Lab Test")]
    public IEnumerable<(CqlTupleMetadata, string EncounterId, CqlQuantity FirstResult, CqlDateTime Timing)?> SDE_Encounter_With_First_Creatinine_Lab_Test(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_SDE_Encounter_With_First_Creatinine_Lab_Test, SDE_Encounter_With_First_Creatinine_Lab_Test_Compute);

    private const long _cacheIndex_SDE_Encounter_With_First_Creatinine_Lab_Test = 5999590137683422991L;

    private IEnumerable<(CqlTupleMetadata, string EncounterId, CqlQuantity FirstResult, CqlDateTime Timing)?> SDE_Encounter_With_First_Creatinine_Lab_Test_Compute(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Inpatient_Encounters(context);

        (CqlTupleMetadata, string EncounterId, CqlQuantity FirstResult, CqlDateTime Timing)? b_(Encounter EncounterInpatient) {
            Id d_ = EncounterInpatient?.IdElement;
            string e_ = d_?.Value;
            CqlValueSet f_ = this.Creatinine_lab_test(context);
            IEnumerable<Observation> g_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, f_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation-lab"));

            bool? h_(Observation CreatinineLab) {
                object x_;
                DataType ac_ = CreatinineLab?.Effective;
                object ad_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ac_);
                bool ae_ = ad_ is CqlDateTime;
                if (ae_)
                {
                    DataType af_ = CreatinineLab?.Effective;
                    object ag_ = FHIRHelpers_4_4_000.Instance.ToValue(context, af_);
                    x_ = ag_ as CqlDateTime;
                }
                else
                {
                    DataType ah_ = CreatinineLab?.Effective;
                    object ai_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ah_);
                    bool aj_ = ai_ is CqlDateTime;
                    if (aj_)
                    {
                        DataType ak_ = CreatinineLab?.Effective;
                        object al_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ak_);
                        x_ = al_ as CqlDateTime;
                    }
                    else
                    {
                        DataType am_ = CreatinineLab?.Effective;
                        object an_ = FHIRHelpers_4_4_000.Instance.ToValue(context, am_);
                        bool ao_ = an_ is CqlInterval<CqlDateTime>;
                        if (ao_)
                        {
                            DataType ap_ = CreatinineLab?.Effective;
                            object aq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ap_);
                            x_ = aq_ as CqlInterval<CqlDateTime>;
                        }
                        else
                        {
                            x_ = null;
                        }
                    }
                }
                CqlDateTime y_ = QICoreCommon_4_0_000.Instance.earliest(context, x_);
                CqlInterval<CqlDateTime> z_ = CQMCommon_4_1_000.Instance.hospitalizationWithObservationAndOutpatientSurgeryService(context, EncounterInpatient);
                bool? aa_ = context.Operators.In<CqlDateTime>(y_, z_, (string)default);
                bool? ab_;
                // CQL 'and' (134:15-135:73): right operand skipped when left is false
                if (aa_ is false)
                {
                    ab_ = false;
                }
                else
                {
                    Code<ObservationStatus> ar_ = CreatinineLab?.StatusElement;
                    ObservationStatus? as_ = ar_?.Value;
                    string at_ = context.Operators.Convert<string>(as_);
                    string[] au_ = [
                        "final",
                        "amended",
                        "corrected",
                    ];
                    bool? av_ = context.Operators.In<string>(at_, (IEnumerable<string>)au_);
                    ab_ = aa_ & av_;
                }
                // CQL 'and' (134:9-136:45): right operand skipped when left is false
                if (ab_ is false)
                {
                    return false;
                }
                else
                {
                    DataType aw_ = CreatinineLab?.Value;
                    object ax_ = FHIRHelpers_4_4_000.Instance.ToValue(context, aw_);
                    return ab_ & (!((bool?)(ax_ is null)));
                }
            }

            IEnumerable<Observation> i_ = context.Operators.Where<Observation>(g_, h_);

            object j_(Observation @this) {
                Instant ay_ = @this?.IssuedElement;
                DateTimeOffset? az_ = ay_?.Value;
                CqlDateTime ba_ = context.Operators.Convert<CqlDateTime>(az_);
                CqlDateTime bb_ = QICoreCommon_4_0_000.Instance.earliest(context, ba_);
                return bb_;
            }

            IEnumerable<Observation> k_ = context.Operators.SortBy<Observation>(i_, j_, System.ComponentModel.ListSortDirection.Ascending);
            Observation l_ = context.Operators.First<Observation>(k_);
            DataType m_ = l_?.Value;
            object n_ = FHIRHelpers_4_4_000.Instance.ToValue(context, m_);

            bool? o_(Observation CreatinineLab) {
                object bc_;
                DataType bh_ = CreatinineLab?.Effective;
                object bi_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bh_);
                bool bj_ = bi_ is CqlDateTime;
                if (bj_)
                {
                    DataType bk_ = CreatinineLab?.Effective;
                    object bl_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bk_);
                    bc_ = bl_ as CqlDateTime;
                }
                else
                {
                    DataType bm_ = CreatinineLab?.Effective;
                    object bn_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bm_);
                    bool bo_ = bn_ is CqlDateTime;
                    if (bo_)
                    {
                        DataType bp_ = CreatinineLab?.Effective;
                        object bq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bp_);
                        bc_ = bq_ as CqlDateTime;
                    }
                    else
                    {
                        DataType br_ = CreatinineLab?.Effective;
                        object bs_ = FHIRHelpers_4_4_000.Instance.ToValue(context, br_);
                        bool bt_ = bs_ is CqlInterval<CqlDateTime>;
                        if (bt_)
                        {
                            DataType bu_ = CreatinineLab?.Effective;
                            object bv_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bu_);
                            bc_ = bv_ as CqlInterval<CqlDateTime>;
                        }
                        else
                        {
                            bc_ = null;
                        }
                    }
                }
                CqlDateTime bd_ = QICoreCommon_4_0_000.Instance.earliest(context, bc_);
                CqlInterval<CqlDateTime> be_ = CQMCommon_4_1_000.Instance.hospitalizationWithObservationAndOutpatientSurgeryService(context, EncounterInpatient);
                bool? bf_ = context.Operators.In<CqlDateTime>(bd_, be_, (string)default);
                bool? bg_;
                // CQL 'and' (134:15-135:73): right operand skipped when left is false
                if (bf_ is false)
                {
                    bg_ = false;
                }
                else
                {
                    Code<ObservationStatus> bw_ = CreatinineLab?.StatusElement;
                    ObservationStatus? bx_ = bw_?.Value;
                    string by_ = context.Operators.Convert<string>(bx_);
                    string[] bz_ = [
                        "final",
                        "amended",
                        "corrected",
                    ];
                    bool? ca_ = context.Operators.In<string>(by_, (IEnumerable<string>)bz_);
                    bg_ = bf_ & ca_;
                }
                // CQL 'and' (134:9-136:45): right operand skipped when left is false
                if (bg_ is false)
                {
                    return false;
                }
                else
                {
                    DataType cb_ = CreatinineLab?.Value;
                    object cc_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cb_);
                    return bg_ & (!((bool?)(cc_ is null)));
                }
            }

            IEnumerable<Observation> p_ = context.Operators.Where<Observation>(g_, o_);

            object q_(Observation @this) {
                Instant cd_ = @this?.IssuedElement;
                DateTimeOffset? ce_ = cd_?.Value;
                CqlDateTime cf_ = context.Operators.Convert<CqlDateTime>(ce_);
                CqlDateTime cg_ = QICoreCommon_4_0_000.Instance.earliest(context, cf_);
                return cg_;
            }

            IEnumerable<Observation> r_ = context.Operators.SortBy<Observation>(p_, q_, System.ComponentModel.ListSortDirection.Ascending);
            Observation s_ = context.Operators.First<Observation>(r_);
            Instant t_ = s_?.IssuedElement;
            DateTimeOffset? u_ = t_?.Value;
            CqlDateTime v_ = context.Operators.Convert<CqlDateTime>(u_);
            (CqlTupleMetadata, string EncounterId, CqlQuantity FirstResult, CqlDateTime Timing)? w_ = (CqlTupleMetadata_HDVhZFAYAdGHPZJWcDFSNFGPd, e_, n_ as CqlQuantity, v_);
            return w_;
        }

        IEnumerable<(CqlTupleMetadata, string EncounterId, CqlQuantity FirstResult, CqlDateTime Timing)?> c_ = context.Operators.SelectDistinct<Encounter, (CqlTupleMetadata, string EncounterId, CqlQuantity FirstResult, CqlDateTime Timing)?>(a_, b_);
        return c_;
    }


    [CqlExpressionDefinition("SDE Encounter With First Glucose Lab Test")]
    public IEnumerable<(CqlTupleMetadata, string EncounterId, CqlQuantity FirstResult, CqlDateTime Timing)?> SDE_Encounter_With_First_Glucose_Lab_Test(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_SDE_Encounter_With_First_Glucose_Lab_Test, SDE_Encounter_With_First_Glucose_Lab_Test_Compute);

    private const long _cacheIndex_SDE_Encounter_With_First_Glucose_Lab_Test = 1194493558829699982L;

    private IEnumerable<(CqlTupleMetadata, string EncounterId, CqlQuantity FirstResult, CqlDateTime Timing)?> SDE_Encounter_With_First_Glucose_Lab_Test_Compute(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Inpatient_Encounters(context);

        (CqlTupleMetadata, string EncounterId, CqlQuantity FirstResult, CqlDateTime Timing)? b_(Encounter EncounterInpatient) {
            Id d_ = EncounterInpatient?.IdElement;
            string e_ = d_?.Value;
            CqlValueSet f_ = this.Glucose_lab_test(context);
            IEnumerable<Observation> g_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, f_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation-lab"));

            bool? h_(Observation GlucoseLab) {
                object x_;
                DataType ac_ = GlucoseLab?.Effective;
                object ad_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ac_);
                bool ae_ = ad_ is CqlDateTime;
                if (ae_)
                {
                    DataType af_ = GlucoseLab?.Effective;
                    object ag_ = FHIRHelpers_4_4_000.Instance.ToValue(context, af_);
                    x_ = ag_ as CqlDateTime;
                }
                else
                {
                    DataType ah_ = GlucoseLab?.Effective;
                    object ai_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ah_);
                    bool aj_ = ai_ is CqlDateTime;
                    if (aj_)
                    {
                        DataType ak_ = GlucoseLab?.Effective;
                        object al_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ak_);
                        x_ = al_ as CqlDateTime;
                    }
                    else
                    {
                        DataType am_ = GlucoseLab?.Effective;
                        object an_ = FHIRHelpers_4_4_000.Instance.ToValue(context, am_);
                        bool ao_ = an_ is CqlInterval<CqlDateTime>;
                        if (ao_)
                        {
                            DataType ap_ = GlucoseLab?.Effective;
                            object aq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ap_);
                            x_ = aq_ as CqlInterval<CqlDateTime>;
                        }
                        else
                        {
                            x_ = null;
                        }
                    }
                }
                CqlDateTime y_ = QICoreCommon_4_0_000.Instance.earliest(context, x_);
                CqlInterval<CqlDateTime> z_ = CQMCommon_4_1_000.Instance.hospitalizationWithObservationAndOutpatientSurgeryService(context, EncounterInpatient);
                bool? aa_ = context.Operators.In<CqlDateTime>(y_, z_, (string)default);
                bool? ab_;
                // CQL 'and' (148:15-149:70): right operand skipped when left is false
                if (aa_ is false)
                {
                    ab_ = false;
                }
                else
                {
                    Code<ObservationStatus> ar_ = GlucoseLab?.StatusElement;
                    ObservationStatus? as_ = ar_?.Value;
                    string at_ = context.Operators.Convert<string>(as_);
                    string[] au_ = [
                        "final",
                        "amended",
                        "corrected",
                    ];
                    bool? av_ = context.Operators.In<string>(at_, (IEnumerable<string>)au_);
                    ab_ = aa_ & av_;
                }
                // CQL 'and' (148:9-150:42): right operand skipped when left is false
                if (ab_ is false)
                {
                    return false;
                }
                else
                {
                    DataType aw_ = GlucoseLab?.Value;
                    object ax_ = FHIRHelpers_4_4_000.Instance.ToValue(context, aw_);
                    return ab_ & (!((bool?)(ax_ is null)));
                }
            }

            IEnumerable<Observation> i_ = context.Operators.Where<Observation>(g_, h_);

            object j_(Observation @this) {
                Instant ay_ = @this?.IssuedElement;
                DateTimeOffset? az_ = ay_?.Value;
                CqlDateTime ba_ = context.Operators.Convert<CqlDateTime>(az_);
                CqlDateTime bb_ = QICoreCommon_4_0_000.Instance.earliest(context, ba_);
                return bb_;
            }

            IEnumerable<Observation> k_ = context.Operators.SortBy<Observation>(i_, j_, System.ComponentModel.ListSortDirection.Ascending);
            Observation l_ = context.Operators.First<Observation>(k_);
            DataType m_ = l_?.Value;
            object n_ = FHIRHelpers_4_4_000.Instance.ToValue(context, m_);

            bool? o_(Observation GlucoseLab) {
                object bc_;
                DataType bh_ = GlucoseLab?.Effective;
                object bi_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bh_);
                bool bj_ = bi_ is CqlDateTime;
                if (bj_)
                {
                    DataType bk_ = GlucoseLab?.Effective;
                    object bl_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bk_);
                    bc_ = bl_ as CqlDateTime;
                }
                else
                {
                    DataType bm_ = GlucoseLab?.Effective;
                    object bn_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bm_);
                    bool bo_ = bn_ is CqlDateTime;
                    if (bo_)
                    {
                        DataType bp_ = GlucoseLab?.Effective;
                        object bq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bp_);
                        bc_ = bq_ as CqlDateTime;
                    }
                    else
                    {
                        DataType br_ = GlucoseLab?.Effective;
                        object bs_ = FHIRHelpers_4_4_000.Instance.ToValue(context, br_);
                        bool bt_ = bs_ is CqlInterval<CqlDateTime>;
                        if (bt_)
                        {
                            DataType bu_ = GlucoseLab?.Effective;
                            object bv_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bu_);
                            bc_ = bv_ as CqlInterval<CqlDateTime>;
                        }
                        else
                        {
                            bc_ = null;
                        }
                    }
                }
                CqlDateTime bd_ = QICoreCommon_4_0_000.Instance.earliest(context, bc_);
                CqlInterval<CqlDateTime> be_ = CQMCommon_4_1_000.Instance.hospitalizationWithObservationAndOutpatientSurgeryService(context, EncounterInpatient);
                bool? bf_ = context.Operators.In<CqlDateTime>(bd_, be_, (string)default);
                bool? bg_;
                // CQL 'and' (148:15-149:70): right operand skipped when left is false
                if (bf_ is false)
                {
                    bg_ = false;
                }
                else
                {
                    Code<ObservationStatus> bw_ = GlucoseLab?.StatusElement;
                    ObservationStatus? bx_ = bw_?.Value;
                    string by_ = context.Operators.Convert<string>(bx_);
                    string[] bz_ = [
                        "final",
                        "amended",
                        "corrected",
                    ];
                    bool? ca_ = context.Operators.In<string>(by_, (IEnumerable<string>)bz_);
                    bg_ = bf_ & ca_;
                }
                // CQL 'and' (148:9-150:42): right operand skipped when left is false
                if (bg_ is false)
                {
                    return false;
                }
                else
                {
                    DataType cb_ = GlucoseLab?.Value;
                    object cc_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cb_);
                    return bg_ & (!((bool?)(cc_ is null)));
                }
            }

            IEnumerable<Observation> p_ = context.Operators.Where<Observation>(g_, o_);

            object q_(Observation @this) {
                Instant cd_ = @this?.IssuedElement;
                DateTimeOffset? ce_ = cd_?.Value;
                CqlDateTime cf_ = context.Operators.Convert<CqlDateTime>(ce_);
                CqlDateTime cg_ = QICoreCommon_4_0_000.Instance.earliest(context, cf_);
                return cg_;
            }

            IEnumerable<Observation> r_ = context.Operators.SortBy<Observation>(p_, q_, System.ComponentModel.ListSortDirection.Ascending);
            Observation s_ = context.Operators.First<Observation>(r_);
            Instant t_ = s_?.IssuedElement;
            DateTimeOffset? u_ = t_?.Value;
            CqlDateTime v_ = context.Operators.Convert<CqlDateTime>(u_);
            (CqlTupleMetadata, string EncounterId, CqlQuantity FirstResult, CqlDateTime Timing)? w_ = (CqlTupleMetadata_HDVhZFAYAdGHPZJWcDFSNFGPd, e_, n_ as CqlQuantity, v_);
            return w_;
        }

        IEnumerable<(CqlTupleMetadata, string EncounterId, CqlQuantity FirstResult, CqlDateTime Timing)?> c_ = context.Operators.SelectDistinct<Encounter, (CqlTupleMetadata, string EncounterId, CqlQuantity FirstResult, CqlDateTime Timing)?>(a_, b_);
        return c_;
    }


    [CqlExpressionDefinition("SDE Encounter With First Hematocrit Lab Test")]
    public IEnumerable<(CqlTupleMetadata, string EncounterId, CqlQuantity FirstResult, CqlDateTime Timing)?> SDE_Encounter_With_First_Hematocrit_Lab_Test(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_SDE_Encounter_With_First_Hematocrit_Lab_Test, SDE_Encounter_With_First_Hematocrit_Lab_Test_Compute);

    private const long _cacheIndex_SDE_Encounter_With_First_Hematocrit_Lab_Test = 6689886378393453582L;

    private IEnumerable<(CqlTupleMetadata, string EncounterId, CqlQuantity FirstResult, CqlDateTime Timing)?> SDE_Encounter_With_First_Hematocrit_Lab_Test_Compute(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Inpatient_Encounters(context);

        (CqlTupleMetadata, string EncounterId, CqlQuantity FirstResult, CqlDateTime Timing)? b_(Encounter EncounterInpatient) {
            Id d_ = EncounterInpatient?.IdElement;
            string e_ = d_?.Value;
            CqlValueSet f_ = this.Hematocrit_lab_test(context);
            IEnumerable<Observation> g_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, f_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation-lab"));

            bool? h_(Observation HematocritLab) {
                object x_;
                DataType ac_ = HematocritLab?.Effective;
                object ad_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ac_);
                bool ae_ = ad_ is CqlDateTime;
                if (ae_)
                {
                    DataType af_ = HematocritLab?.Effective;
                    object ag_ = FHIRHelpers_4_4_000.Instance.ToValue(context, af_);
                    x_ = ag_ as CqlDateTime;
                }
                else
                {
                    DataType ah_ = HematocritLab?.Effective;
                    object ai_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ah_);
                    bool aj_ = ai_ is CqlDateTime;
                    if (aj_)
                    {
                        DataType ak_ = HematocritLab?.Effective;
                        object al_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ak_);
                        x_ = al_ as CqlDateTime;
                    }
                    else
                    {
                        DataType am_ = HematocritLab?.Effective;
                        object an_ = FHIRHelpers_4_4_000.Instance.ToValue(context, am_);
                        bool ao_ = an_ is CqlInterval<CqlDateTime>;
                        if (ao_)
                        {
                            DataType ap_ = HematocritLab?.Effective;
                            object aq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ap_);
                            x_ = aq_ as CqlInterval<CqlDateTime>;
                        }
                        else
                        {
                            x_ = null;
                        }
                    }
                }
                CqlDateTime y_ = QICoreCommon_4_0_000.Instance.earliest(context, x_);
                CqlInterval<CqlDateTime> z_ = CQMCommon_4_1_000.Instance.hospitalizationWithObservationAndOutpatientSurgeryService(context, EncounterInpatient);
                bool? aa_ = context.Operators.In<CqlDateTime>(y_, z_, (string)default);
                bool? ab_;
                // CQL 'and' (162:15-163:73): right operand skipped when left is false
                if (aa_ is false)
                {
                    ab_ = false;
                }
                else
                {
                    Code<ObservationStatus> ar_ = HematocritLab?.StatusElement;
                    ObservationStatus? as_ = ar_?.Value;
                    string at_ = context.Operators.Convert<string>(as_);
                    string[] au_ = [
                        "final",
                        "amended",
                        "corrected",
                    ];
                    bool? av_ = context.Operators.In<string>(at_, (IEnumerable<string>)au_);
                    ab_ = aa_ & av_;
                }
                // CQL 'and' (162:9-164:45): right operand skipped when left is false
                if (ab_ is false)
                {
                    return false;
                }
                else
                {
                    DataType aw_ = HematocritLab?.Value;
                    object ax_ = FHIRHelpers_4_4_000.Instance.ToValue(context, aw_);
                    return ab_ & (!((bool?)(ax_ is null)));
                }
            }

            IEnumerable<Observation> i_ = context.Operators.Where<Observation>(g_, h_);

            object j_(Observation @this) {
                Instant ay_ = @this?.IssuedElement;
                DateTimeOffset? az_ = ay_?.Value;
                CqlDateTime ba_ = context.Operators.Convert<CqlDateTime>(az_);
                CqlDateTime bb_ = QICoreCommon_4_0_000.Instance.earliest(context, ba_);
                return bb_;
            }

            IEnumerable<Observation> k_ = context.Operators.SortBy<Observation>(i_, j_, System.ComponentModel.ListSortDirection.Ascending);
            Observation l_ = context.Operators.First<Observation>(k_);
            DataType m_ = l_?.Value;
            object n_ = FHIRHelpers_4_4_000.Instance.ToValue(context, m_);

            bool? o_(Observation HematocritLab) {
                object bc_;
                DataType bh_ = HematocritLab?.Effective;
                object bi_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bh_);
                bool bj_ = bi_ is CqlDateTime;
                if (bj_)
                {
                    DataType bk_ = HematocritLab?.Effective;
                    object bl_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bk_);
                    bc_ = bl_ as CqlDateTime;
                }
                else
                {
                    DataType bm_ = HematocritLab?.Effective;
                    object bn_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bm_);
                    bool bo_ = bn_ is CqlDateTime;
                    if (bo_)
                    {
                        DataType bp_ = HematocritLab?.Effective;
                        object bq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bp_);
                        bc_ = bq_ as CqlDateTime;
                    }
                    else
                    {
                        DataType br_ = HematocritLab?.Effective;
                        object bs_ = FHIRHelpers_4_4_000.Instance.ToValue(context, br_);
                        bool bt_ = bs_ is CqlInterval<CqlDateTime>;
                        if (bt_)
                        {
                            DataType bu_ = HematocritLab?.Effective;
                            object bv_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bu_);
                            bc_ = bv_ as CqlInterval<CqlDateTime>;
                        }
                        else
                        {
                            bc_ = null;
                        }
                    }
                }
                CqlDateTime bd_ = QICoreCommon_4_0_000.Instance.earliest(context, bc_);
                CqlInterval<CqlDateTime> be_ = CQMCommon_4_1_000.Instance.hospitalizationWithObservationAndOutpatientSurgeryService(context, EncounterInpatient);
                bool? bf_ = context.Operators.In<CqlDateTime>(bd_, be_, (string)default);
                bool? bg_;
                // CQL 'and' (162:15-163:73): right operand skipped when left is false
                if (bf_ is false)
                {
                    bg_ = false;
                }
                else
                {
                    Code<ObservationStatus> bw_ = HematocritLab?.StatusElement;
                    ObservationStatus? bx_ = bw_?.Value;
                    string by_ = context.Operators.Convert<string>(bx_);
                    string[] bz_ = [
                        "final",
                        "amended",
                        "corrected",
                    ];
                    bool? ca_ = context.Operators.In<string>(by_, (IEnumerable<string>)bz_);
                    bg_ = bf_ & ca_;
                }
                // CQL 'and' (162:9-164:45): right operand skipped when left is false
                if (bg_ is false)
                {
                    return false;
                }
                else
                {
                    DataType cb_ = HematocritLab?.Value;
                    object cc_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cb_);
                    return bg_ & (!((bool?)(cc_ is null)));
                }
            }

            IEnumerable<Observation> p_ = context.Operators.Where<Observation>(g_, o_);

            object q_(Observation @this) {
                Instant cd_ = @this?.IssuedElement;
                DateTimeOffset? ce_ = cd_?.Value;
                CqlDateTime cf_ = context.Operators.Convert<CqlDateTime>(ce_);
                CqlDateTime cg_ = QICoreCommon_4_0_000.Instance.earliest(context, cf_);
                return cg_;
            }

            IEnumerable<Observation> r_ = context.Operators.SortBy<Observation>(p_, q_, System.ComponentModel.ListSortDirection.Ascending);
            Observation s_ = context.Operators.First<Observation>(r_);
            Instant t_ = s_?.IssuedElement;
            DateTimeOffset? u_ = t_?.Value;
            CqlDateTime v_ = context.Operators.Convert<CqlDateTime>(u_);
            (CqlTupleMetadata, string EncounterId, CqlQuantity FirstResult, CqlDateTime Timing)? w_ = (CqlTupleMetadata_HDVhZFAYAdGHPZJWcDFSNFGPd, e_, n_ as CqlQuantity, v_);
            return w_;
        }

        IEnumerable<(CqlTupleMetadata, string EncounterId, CqlQuantity FirstResult, CqlDateTime Timing)?> c_ = context.Operators.SelectDistinct<Encounter, (CqlTupleMetadata, string EncounterId, CqlQuantity FirstResult, CqlDateTime Timing)?>(a_, b_);
        return c_;
    }


    [CqlExpressionDefinition("SDE Encounter With First Potassium Lab Test")]
    public IEnumerable<(CqlTupleMetadata, string EncounterId, CqlQuantity FirstResult, CqlDateTime Timing)?> SDE_Encounter_With_First_Potassium_Lab_Test(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_SDE_Encounter_With_First_Potassium_Lab_Test, SDE_Encounter_With_First_Potassium_Lab_Test_Compute);

    private const long _cacheIndex_SDE_Encounter_With_First_Potassium_Lab_Test = 345924722915584638L;

    private IEnumerable<(CqlTupleMetadata, string EncounterId, CqlQuantity FirstResult, CqlDateTime Timing)?> SDE_Encounter_With_First_Potassium_Lab_Test_Compute(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Inpatient_Encounters(context);

        (CqlTupleMetadata, string EncounterId, CqlQuantity FirstResult, CqlDateTime Timing)? b_(Encounter EncounterInpatient) {
            Id d_ = EncounterInpatient?.IdElement;
            string e_ = d_?.Value;
            CqlValueSet f_ = this.Potassium_lab_test(context);
            IEnumerable<Observation> g_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, f_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation-lab"));

            bool? h_(Observation PotassiumLab) {
                object x_;
                DataType ac_ = PotassiumLab?.Effective;
                object ad_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ac_);
                bool ae_ = ad_ is CqlDateTime;
                if (ae_)
                {
                    DataType af_ = PotassiumLab?.Effective;
                    object ag_ = FHIRHelpers_4_4_000.Instance.ToValue(context, af_);
                    x_ = ag_ as CqlDateTime;
                }
                else
                {
                    DataType ah_ = PotassiumLab?.Effective;
                    object ai_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ah_);
                    bool aj_ = ai_ is CqlDateTime;
                    if (aj_)
                    {
                        DataType ak_ = PotassiumLab?.Effective;
                        object al_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ak_);
                        x_ = al_ as CqlDateTime;
                    }
                    else
                    {
                        DataType am_ = PotassiumLab?.Effective;
                        object an_ = FHIRHelpers_4_4_000.Instance.ToValue(context, am_);
                        bool ao_ = an_ is CqlInterval<CqlDateTime>;
                        if (ao_)
                        {
                            DataType ap_ = PotassiumLab?.Effective;
                            object aq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ap_);
                            x_ = aq_ as CqlInterval<CqlDateTime>;
                        }
                        else
                        {
                            x_ = null;
                        }
                    }
                }
                CqlDateTime y_ = QICoreCommon_4_0_000.Instance.earliest(context, x_);
                CqlInterval<CqlDateTime> z_ = CQMCommon_4_1_000.Instance.hospitalizationWithObservationAndOutpatientSurgeryService(context, EncounterInpatient);
                bool? aa_ = context.Operators.In<CqlDateTime>(y_, z_, (string)default);
                bool? ab_;
                // CQL 'and' (176:15-177:72): right operand skipped when left is false
                if (aa_ is false)
                {
                    ab_ = false;
                }
                else
                {
                    Code<ObservationStatus> ar_ = PotassiumLab?.StatusElement;
                    ObservationStatus? as_ = ar_?.Value;
                    string at_ = context.Operators.Convert<string>(as_);
                    string[] au_ = [
                        "final",
                        "amended",
                        "corrected",
                    ];
                    bool? av_ = context.Operators.In<string>(at_, (IEnumerable<string>)au_);
                    ab_ = aa_ & av_;
                }
                // CQL 'and' (176:9-178:44): right operand skipped when left is false
                if (ab_ is false)
                {
                    return false;
                }
                else
                {
                    DataType aw_ = PotassiumLab?.Value;
                    object ax_ = FHIRHelpers_4_4_000.Instance.ToValue(context, aw_);
                    return ab_ & (!((bool?)(ax_ is null)));
                }
            }

            IEnumerable<Observation> i_ = context.Operators.Where<Observation>(g_, h_);

            object j_(Observation @this) {
                Instant ay_ = @this?.IssuedElement;
                DateTimeOffset? az_ = ay_?.Value;
                CqlDateTime ba_ = context.Operators.Convert<CqlDateTime>(az_);
                CqlDateTime bb_ = QICoreCommon_4_0_000.Instance.earliest(context, ba_);
                return bb_;
            }

            IEnumerable<Observation> k_ = context.Operators.SortBy<Observation>(i_, j_, System.ComponentModel.ListSortDirection.Ascending);
            Observation l_ = context.Operators.First<Observation>(k_);
            DataType m_ = l_?.Value;
            object n_ = FHIRHelpers_4_4_000.Instance.ToValue(context, m_);

            bool? o_(Observation PotassiumLab) {
                object bc_;
                DataType bh_ = PotassiumLab?.Effective;
                object bi_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bh_);
                bool bj_ = bi_ is CqlDateTime;
                if (bj_)
                {
                    DataType bk_ = PotassiumLab?.Effective;
                    object bl_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bk_);
                    bc_ = bl_ as CqlDateTime;
                }
                else
                {
                    DataType bm_ = PotassiumLab?.Effective;
                    object bn_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bm_);
                    bool bo_ = bn_ is CqlDateTime;
                    if (bo_)
                    {
                        DataType bp_ = PotassiumLab?.Effective;
                        object bq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bp_);
                        bc_ = bq_ as CqlDateTime;
                    }
                    else
                    {
                        DataType br_ = PotassiumLab?.Effective;
                        object bs_ = FHIRHelpers_4_4_000.Instance.ToValue(context, br_);
                        bool bt_ = bs_ is CqlInterval<CqlDateTime>;
                        if (bt_)
                        {
                            DataType bu_ = PotassiumLab?.Effective;
                            object bv_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bu_);
                            bc_ = bv_ as CqlInterval<CqlDateTime>;
                        }
                        else
                        {
                            bc_ = null;
                        }
                    }
                }
                CqlDateTime bd_ = QICoreCommon_4_0_000.Instance.earliest(context, bc_);
                CqlInterval<CqlDateTime> be_ = CQMCommon_4_1_000.Instance.hospitalizationWithObservationAndOutpatientSurgeryService(context, EncounterInpatient);
                bool? bf_ = context.Operators.In<CqlDateTime>(bd_, be_, (string)default);
                bool? bg_;
                // CQL 'and' (176:15-177:72): right operand skipped when left is false
                if (bf_ is false)
                {
                    bg_ = false;
                }
                else
                {
                    Code<ObservationStatus> bw_ = PotassiumLab?.StatusElement;
                    ObservationStatus? bx_ = bw_?.Value;
                    string by_ = context.Operators.Convert<string>(bx_);
                    string[] bz_ = [
                        "final",
                        "amended",
                        "corrected",
                    ];
                    bool? ca_ = context.Operators.In<string>(by_, (IEnumerable<string>)bz_);
                    bg_ = bf_ & ca_;
                }
                // CQL 'and' (176:9-178:44): right operand skipped when left is false
                if (bg_ is false)
                {
                    return false;
                }
                else
                {
                    DataType cb_ = PotassiumLab?.Value;
                    object cc_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cb_);
                    return bg_ & (!((bool?)(cc_ is null)));
                }
            }

            IEnumerable<Observation> p_ = context.Operators.Where<Observation>(g_, o_);

            object q_(Observation @this) {
                Instant cd_ = @this?.IssuedElement;
                DateTimeOffset? ce_ = cd_?.Value;
                CqlDateTime cf_ = context.Operators.Convert<CqlDateTime>(ce_);
                CqlDateTime cg_ = QICoreCommon_4_0_000.Instance.earliest(context, cf_);
                return cg_;
            }

            IEnumerable<Observation> r_ = context.Operators.SortBy<Observation>(p_, q_, System.ComponentModel.ListSortDirection.Ascending);
            Observation s_ = context.Operators.First<Observation>(r_);
            Instant t_ = s_?.IssuedElement;
            DateTimeOffset? u_ = t_?.Value;
            CqlDateTime v_ = context.Operators.Convert<CqlDateTime>(u_);
            (CqlTupleMetadata, string EncounterId, CqlQuantity FirstResult, CqlDateTime Timing)? w_ = (CqlTupleMetadata_HDVhZFAYAdGHPZJWcDFSNFGPd, e_, n_ as CqlQuantity, v_);
            return w_;
        }

        IEnumerable<(CqlTupleMetadata, string EncounterId, CqlQuantity FirstResult, CqlDateTime Timing)?> c_ = context.Operators.SelectDistinct<Encounter, (CqlTupleMetadata, string EncounterId, CqlQuantity FirstResult, CqlDateTime Timing)?>(a_, b_);
        return c_;
    }


    [CqlExpressionDefinition("SDE Encounter With First Sodium Lab Test")]
    public IEnumerable<(CqlTupleMetadata, string EncounterId, CqlQuantity FirstResult, CqlDateTime Timing)?> SDE_Encounter_With_First_Sodium_Lab_Test(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_SDE_Encounter_With_First_Sodium_Lab_Test, SDE_Encounter_With_First_Sodium_Lab_Test_Compute);

    private const long _cacheIndex_SDE_Encounter_With_First_Sodium_Lab_Test = 306946264291175126L;

    private IEnumerable<(CqlTupleMetadata, string EncounterId, CqlQuantity FirstResult, CqlDateTime Timing)?> SDE_Encounter_With_First_Sodium_Lab_Test_Compute(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Inpatient_Encounters(context);

        (CqlTupleMetadata, string EncounterId, CqlQuantity FirstResult, CqlDateTime Timing)? b_(Encounter EncounterInpatient) {
            Id d_ = EncounterInpatient?.IdElement;
            string e_ = d_?.Value;
            CqlValueSet f_ = this.Sodium_lab_test(context);
            IEnumerable<Observation> g_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, f_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation-lab"));

            bool? h_(Observation SodiumLab) {
                object x_;
                DataType ac_ = SodiumLab?.Effective;
                object ad_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ac_);
                bool ae_ = ad_ is CqlDateTime;
                if (ae_)
                {
                    DataType af_ = SodiumLab?.Effective;
                    object ag_ = FHIRHelpers_4_4_000.Instance.ToValue(context, af_);
                    x_ = ag_ as CqlDateTime;
                }
                else
                {
                    DataType ah_ = SodiumLab?.Effective;
                    object ai_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ah_);
                    bool aj_ = ai_ is CqlDateTime;
                    if (aj_)
                    {
                        DataType ak_ = SodiumLab?.Effective;
                        object al_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ak_);
                        x_ = al_ as CqlDateTime;
                    }
                    else
                    {
                        DataType am_ = SodiumLab?.Effective;
                        object an_ = FHIRHelpers_4_4_000.Instance.ToValue(context, am_);
                        bool ao_ = an_ is CqlInterval<CqlDateTime>;
                        if (ao_)
                        {
                            DataType ap_ = SodiumLab?.Effective;
                            object aq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ap_);
                            x_ = aq_ as CqlInterval<CqlDateTime>;
                        }
                        else
                        {
                            x_ = null;
                        }
                    }
                }
                CqlDateTime y_ = QICoreCommon_4_0_000.Instance.earliest(context, x_);
                CqlInterval<CqlDateTime> z_ = CQMCommon_4_1_000.Instance.hospitalizationWithObservationAndOutpatientSurgeryService(context, EncounterInpatient);
                bool? aa_ = context.Operators.In<CqlDateTime>(y_, z_, (string)default);
                bool? ab_;
                // CQL 'and' (190:15-191:69): right operand skipped when left is false
                if (aa_ is false)
                {
                    ab_ = false;
                }
                else
                {
                    Code<ObservationStatus> ar_ = SodiumLab?.StatusElement;
                    ObservationStatus? as_ = ar_?.Value;
                    string at_ = context.Operators.Convert<string>(as_);
                    string[] au_ = [
                        "final",
                        "amended",
                        "corrected",
                    ];
                    bool? av_ = context.Operators.In<string>(at_, (IEnumerable<string>)au_);
                    ab_ = aa_ & av_;
                }
                // CQL 'and' (190:9-192:41): right operand skipped when left is false
                if (ab_ is false)
                {
                    return false;
                }
                else
                {
                    DataType aw_ = SodiumLab?.Value;
                    object ax_ = FHIRHelpers_4_4_000.Instance.ToValue(context, aw_);
                    return ab_ & (!((bool?)(ax_ is null)));
                }
            }

            IEnumerable<Observation> i_ = context.Operators.Where<Observation>(g_, h_);

            object j_(Observation @this) {
                Instant ay_ = @this?.IssuedElement;
                DateTimeOffset? az_ = ay_?.Value;
                CqlDateTime ba_ = context.Operators.Convert<CqlDateTime>(az_);
                CqlDateTime bb_ = QICoreCommon_4_0_000.Instance.earliest(context, ba_);
                return bb_;
            }

            IEnumerable<Observation> k_ = context.Operators.SortBy<Observation>(i_, j_, System.ComponentModel.ListSortDirection.Ascending);
            Observation l_ = context.Operators.First<Observation>(k_);
            DataType m_ = l_?.Value;
            object n_ = FHIRHelpers_4_4_000.Instance.ToValue(context, m_);

            bool? o_(Observation SodiumLab) {
                object bc_;
                DataType bh_ = SodiumLab?.Effective;
                object bi_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bh_);
                bool bj_ = bi_ is CqlDateTime;
                if (bj_)
                {
                    DataType bk_ = SodiumLab?.Effective;
                    object bl_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bk_);
                    bc_ = bl_ as CqlDateTime;
                }
                else
                {
                    DataType bm_ = SodiumLab?.Effective;
                    object bn_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bm_);
                    bool bo_ = bn_ is CqlDateTime;
                    if (bo_)
                    {
                        DataType bp_ = SodiumLab?.Effective;
                        object bq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bp_);
                        bc_ = bq_ as CqlDateTime;
                    }
                    else
                    {
                        DataType br_ = SodiumLab?.Effective;
                        object bs_ = FHIRHelpers_4_4_000.Instance.ToValue(context, br_);
                        bool bt_ = bs_ is CqlInterval<CqlDateTime>;
                        if (bt_)
                        {
                            DataType bu_ = SodiumLab?.Effective;
                            object bv_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bu_);
                            bc_ = bv_ as CqlInterval<CqlDateTime>;
                        }
                        else
                        {
                            bc_ = null;
                        }
                    }
                }
                CqlDateTime bd_ = QICoreCommon_4_0_000.Instance.earliest(context, bc_);
                CqlInterval<CqlDateTime> be_ = CQMCommon_4_1_000.Instance.hospitalizationWithObservationAndOutpatientSurgeryService(context, EncounterInpatient);
                bool? bf_ = context.Operators.In<CqlDateTime>(bd_, be_, (string)default);
                bool? bg_;
                // CQL 'and' (190:15-191:69): right operand skipped when left is false
                if (bf_ is false)
                {
                    bg_ = false;
                }
                else
                {
                    Code<ObservationStatus> bw_ = SodiumLab?.StatusElement;
                    ObservationStatus? bx_ = bw_?.Value;
                    string by_ = context.Operators.Convert<string>(bx_);
                    string[] bz_ = [
                        "final",
                        "amended",
                        "corrected",
                    ];
                    bool? ca_ = context.Operators.In<string>(by_, (IEnumerable<string>)bz_);
                    bg_ = bf_ & ca_;
                }
                // CQL 'and' (190:9-192:41): right operand skipped when left is false
                if (bg_ is false)
                {
                    return false;
                }
                else
                {
                    DataType cb_ = SodiumLab?.Value;
                    object cc_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cb_);
                    return bg_ & (!((bool?)(cc_ is null)));
                }
            }

            IEnumerable<Observation> p_ = context.Operators.Where<Observation>(g_, o_);

            object q_(Observation @this) {
                Instant cd_ = @this?.IssuedElement;
                DateTimeOffset? ce_ = cd_?.Value;
                CqlDateTime cf_ = context.Operators.Convert<CqlDateTime>(ce_);
                CqlDateTime cg_ = QICoreCommon_4_0_000.Instance.earliest(context, cf_);
                return cg_;
            }

            IEnumerable<Observation> r_ = context.Operators.SortBy<Observation>(p_, q_, System.ComponentModel.ListSortDirection.Ascending);
            Observation s_ = context.Operators.First<Observation>(r_);
            Instant t_ = s_?.IssuedElement;
            DateTimeOffset? u_ = t_?.Value;
            CqlDateTime v_ = context.Operators.Convert<CqlDateTime>(u_);
            (CqlTupleMetadata, string EncounterId, CqlQuantity FirstResult, CqlDateTime Timing)? w_ = (CqlTupleMetadata_HDVhZFAYAdGHPZJWcDFSNFGPd, e_, n_ as CqlQuantity, v_);
            return w_;
        }

        IEnumerable<(CqlTupleMetadata, string EncounterId, CqlQuantity FirstResult, CqlDateTime Timing)?> c_ = context.Operators.SelectDistinct<Encounter, (CqlTupleMetadata, string EncounterId, CqlQuantity FirstResult, CqlDateTime Timing)?>(a_, b_);
        return c_;
    }


    [CqlExpressionDefinition("SDE Encounter With First White Blood Cells Lab Test")]
    public IEnumerable<(CqlTupleMetadata, string EncounterId, CqlQuantity FirstResult, CqlDateTime Timing)?> SDE_Encounter_With_First_White_Blood_Cells_Lab_Test(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_SDE_Encounter_With_First_White_Blood_Cells_Lab_Test, SDE_Encounter_With_First_White_Blood_Cells_Lab_Test_Compute);

    private const long _cacheIndex_SDE_Encounter_With_First_White_Blood_Cells_Lab_Test = -7218658410531705995L;

    private IEnumerable<(CqlTupleMetadata, string EncounterId, CqlQuantity FirstResult, CqlDateTime Timing)?> SDE_Encounter_With_First_White_Blood_Cells_Lab_Test_Compute(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Inpatient_Encounters(context);

        (CqlTupleMetadata, string EncounterId, CqlQuantity FirstResult, CqlDateTime Timing)? b_(Encounter EncounterInpatient) {
            Id d_ = EncounterInpatient?.IdElement;
            string e_ = d_?.Value;
            CqlValueSet f_ = this.White_blood_cells_count_lab_test(context);
            IEnumerable<Observation> g_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, f_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation-lab"));

            bool? h_(Observation WhiteBloodCellLab) {
                object x_;
                DataType ac_ = WhiteBloodCellLab?.Effective;
                object ad_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ac_);
                bool ae_ = ad_ is CqlDateTime;
                if (ae_)
                {
                    DataType af_ = WhiteBloodCellLab?.Effective;
                    object ag_ = FHIRHelpers_4_4_000.Instance.ToValue(context, af_);
                    x_ = ag_ as CqlDateTime;
                }
                else
                {
                    DataType ah_ = WhiteBloodCellLab?.Effective;
                    object ai_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ah_);
                    bool aj_ = ai_ is CqlDateTime;
                    if (aj_)
                    {
                        DataType ak_ = WhiteBloodCellLab?.Effective;
                        object al_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ak_);
                        x_ = al_ as CqlDateTime;
                    }
                    else
                    {
                        DataType am_ = WhiteBloodCellLab?.Effective;
                        object an_ = FHIRHelpers_4_4_000.Instance.ToValue(context, am_);
                        bool ao_ = an_ is CqlInterval<CqlDateTime>;
                        if (ao_)
                        {
                            DataType ap_ = WhiteBloodCellLab?.Effective;
                            object aq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ap_);
                            x_ = aq_ as CqlInterval<CqlDateTime>;
                        }
                        else
                        {
                            x_ = null;
                        }
                    }
                }
                CqlDateTime y_ = QICoreCommon_4_0_000.Instance.earliest(context, x_);
                CqlInterval<CqlDateTime> z_ = CQMCommon_4_1_000.Instance.hospitalizationWithObservationAndOutpatientSurgeryService(context, EncounterInpatient);
                bool? aa_ = context.Operators.In<CqlDateTime>(y_, z_, (string)default);
                bool? ab_;
                // CQL 'and' (204:15-205:77): right operand skipped when left is false
                if (aa_ is false)
                {
                    ab_ = false;
                }
                else
                {
                    Code<ObservationStatus> ar_ = WhiteBloodCellLab?.StatusElement;
                    ObservationStatus? as_ = ar_?.Value;
                    string at_ = context.Operators.Convert<string>(as_);
                    string[] au_ = [
                        "final",
                        "amended",
                        "corrected",
                    ];
                    bool? av_ = context.Operators.In<string>(at_, (IEnumerable<string>)au_);
                    ab_ = aa_ & av_;
                }
                // CQL 'and' (204:9-206:49): right operand skipped when left is false
                if (ab_ is false)
                {
                    return false;
                }
                else
                {
                    DataType aw_ = WhiteBloodCellLab?.Value;
                    object ax_ = FHIRHelpers_4_4_000.Instance.ToValue(context, aw_);
                    return ab_ & (!((bool?)(ax_ is null)));
                }
            }

            IEnumerable<Observation> i_ = context.Operators.Where<Observation>(g_, h_);

            object j_(Observation @this) {
                Instant ay_ = @this?.IssuedElement;
                DateTimeOffset? az_ = ay_?.Value;
                CqlDateTime ba_ = context.Operators.Convert<CqlDateTime>(az_);
                CqlDateTime bb_ = QICoreCommon_4_0_000.Instance.earliest(context, ba_);
                return bb_;
            }

            IEnumerable<Observation> k_ = context.Operators.SortBy<Observation>(i_, j_, System.ComponentModel.ListSortDirection.Ascending);
            Observation l_ = context.Operators.First<Observation>(k_);
            DataType m_ = l_?.Value;
            object n_ = FHIRHelpers_4_4_000.Instance.ToValue(context, m_);

            bool? o_(Observation WhiteBloodCellLab) {
                object bc_;
                DataType bh_ = WhiteBloodCellLab?.Effective;
                object bi_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bh_);
                bool bj_ = bi_ is CqlDateTime;
                if (bj_)
                {
                    DataType bk_ = WhiteBloodCellLab?.Effective;
                    object bl_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bk_);
                    bc_ = bl_ as CqlDateTime;
                }
                else
                {
                    DataType bm_ = WhiteBloodCellLab?.Effective;
                    object bn_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bm_);
                    bool bo_ = bn_ is CqlDateTime;
                    if (bo_)
                    {
                        DataType bp_ = WhiteBloodCellLab?.Effective;
                        object bq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bp_);
                        bc_ = bq_ as CqlDateTime;
                    }
                    else
                    {
                        DataType br_ = WhiteBloodCellLab?.Effective;
                        object bs_ = FHIRHelpers_4_4_000.Instance.ToValue(context, br_);
                        bool bt_ = bs_ is CqlInterval<CqlDateTime>;
                        if (bt_)
                        {
                            DataType bu_ = WhiteBloodCellLab?.Effective;
                            object bv_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bu_);
                            bc_ = bv_ as CqlInterval<CqlDateTime>;
                        }
                        else
                        {
                            bc_ = null;
                        }
                    }
                }
                CqlDateTime bd_ = QICoreCommon_4_0_000.Instance.earliest(context, bc_);
                CqlInterval<CqlDateTime> be_ = CQMCommon_4_1_000.Instance.hospitalizationWithObservationAndOutpatientSurgeryService(context, EncounterInpatient);
                bool? bf_ = context.Operators.In<CqlDateTime>(bd_, be_, (string)default);
                bool? bg_;
                // CQL 'and' (204:15-205:77): right operand skipped when left is false
                if (bf_ is false)
                {
                    bg_ = false;
                }
                else
                {
                    Code<ObservationStatus> bw_ = WhiteBloodCellLab?.StatusElement;
                    ObservationStatus? bx_ = bw_?.Value;
                    string by_ = context.Operators.Convert<string>(bx_);
                    string[] bz_ = [
                        "final",
                        "amended",
                        "corrected",
                    ];
                    bool? ca_ = context.Operators.In<string>(by_, (IEnumerable<string>)bz_);
                    bg_ = bf_ & ca_;
                }
                // CQL 'and' (204:9-206:49): right operand skipped when left is false
                if (bg_ is false)
                {
                    return false;
                }
                else
                {
                    DataType cb_ = WhiteBloodCellLab?.Value;
                    object cc_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cb_);
                    return bg_ & (!((bool?)(cc_ is null)));
                }
            }

            IEnumerable<Observation> p_ = context.Operators.Where<Observation>(g_, o_);

            object q_(Observation @this) {
                Instant cd_ = @this?.IssuedElement;
                DateTimeOffset? ce_ = cd_?.Value;
                CqlDateTime cf_ = context.Operators.Convert<CqlDateTime>(ce_);
                CqlDateTime cg_ = QICoreCommon_4_0_000.Instance.earliest(context, cf_);
                return cg_;
            }

            IEnumerable<Observation> r_ = context.Operators.SortBy<Observation>(p_, q_, System.ComponentModel.ListSortDirection.Ascending);
            Observation s_ = context.Operators.First<Observation>(r_);
            Instant t_ = s_?.IssuedElement;
            DateTimeOffset? u_ = t_?.Value;
            CqlDateTime v_ = context.Operators.Convert<CqlDateTime>(u_);
            (CqlTupleMetadata, string EncounterId, CqlQuantity FirstResult, CqlDateTime Timing)? w_ = (CqlTupleMetadata_HDVhZFAYAdGHPZJWcDFSNFGPd, e_, n_ as CqlQuantity, v_);
            return w_;
        }

        IEnumerable<(CqlTupleMetadata, string EncounterId, CqlQuantity FirstResult, CqlDateTime Timing)?> c_ = context.Operators.SelectDistinct<Encounter, (CqlTupleMetadata, string EncounterId, CqlQuantity FirstResult, CqlDateTime Timing)?>(a_, b_);
        return c_;
    }


    [CqlExpressionDefinition("SDE Encounter With First Weight Recorded")]
    public IEnumerable<(CqlTupleMetadata, string EncounterId, CqlQuantity FirstResult, CqlDateTime Timing)?> SDE_Encounter_With_First_Weight_Recorded(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_SDE_Encounter_With_First_Weight_Recorded, SDE_Encounter_With_First_Weight_Recorded_Compute);

    private const long _cacheIndex_SDE_Encounter_With_First_Weight_Recorded = -7805011766788080740L;

    private IEnumerable<(CqlTupleMetadata, string EncounterId, CqlQuantity FirstResult, CqlDateTime Timing)?> SDE_Encounter_With_First_Weight_Recorded_Compute(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Inpatient_Encounters(context);

        (CqlTupleMetadata, string EncounterId, CqlQuantity FirstResult, CqlDateTime Timing)? b_(Encounter EncounterInpatient) {
            Id d_ = EncounterInpatient?.IdElement;
            string e_ = d_?.Value;
            IEnumerable<Observation> f_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/core/StructureDefinition/us-core-body-weight"));

            bool? g_(Observation WeightExam) {
                DataType w_ = WeightExam?.Effective;
                object x_ = FHIRHelpers_4_4_000.Instance.ToValue(context, w_);
                CqlDateTime y_ = QICoreCommon_4_0_000.Instance.earliest(context, x_);
                CqlInterval<CqlDateTime> z_ = CQMCommon_4_1_000.Instance.hospitalizationWithObservationAndOutpatientSurgeryService(context, EncounterInpatient);
                bool? aa_ = context.Operators.In<CqlDateTime>(y_, z_, (string)default);
                bool? ab_;
                // CQL 'and' (218:15-219:70): right operand skipped when left is false
                if (aa_ is false)
                {
                    ab_ = false;
                }
                else
                {
                    Code<ObservationStatus> ac_ = WeightExam?.StatusElement;
                    ObservationStatus? ad_ = ac_?.Value;
                    string ae_ = context.Operators.Convert<string>(ad_);
                    string[] af_ = [
                        "final",
                        "amended",
                        "corrected",
                    ];
                    bool? ag_ = context.Operators.In<string>(ae_, (IEnumerable<string>)af_);
                    ab_ = aa_ & ag_;
                }
                // CQL 'and' (218:9-220:42): right operand skipped when left is false
                if (ab_ is false)
                {
                    return false;
                }
                else
                {
                    DataType ah_ = WeightExam?.Value;
                    CqlQuantity ai_ = FHIRHelpers_4_4_000.Instance.ToQuantity(context, ah_ as Quantity);
                    return ab_ & (!((bool?)(ai_ is null)));
                }
            }

            IEnumerable<Observation> h_ = context.Operators.Where<Observation>(f_, g_);

            object i_(Observation @this) {
                DataType aj_ = @this?.Effective;
                object ak_ = FHIRHelpers_4_4_000.Instance.ToValue(context, aj_);
                CqlDateTime al_ = QICoreCommon_4_0_000.Instance.earliest(context, ak_);
                return al_;
            }

            IEnumerable<Observation> j_ = context.Operators.SortBy<Observation>(h_, i_, System.ComponentModel.ListSortDirection.Ascending);
            Observation k_ = context.Operators.First<Observation>(j_);
            DataType l_ = k_?.Value;
            CqlQuantity m_ = FHIRHelpers_4_4_000.Instance.ToQuantity(context, l_ as Quantity);

            bool? n_(Observation WeightExam) {
                DataType am_ = WeightExam?.Effective;
                object an_ = FHIRHelpers_4_4_000.Instance.ToValue(context, am_);
                CqlDateTime ao_ = QICoreCommon_4_0_000.Instance.earliest(context, an_);
                CqlInterval<CqlDateTime> ap_ = CQMCommon_4_1_000.Instance.hospitalizationWithObservationAndOutpatientSurgeryService(context, EncounterInpatient);
                bool? aq_ = context.Operators.In<CqlDateTime>(ao_, ap_, (string)default);
                bool? ar_;
                // CQL 'and' (218:15-219:70): right operand skipped when left is false
                if (aq_ is false)
                {
                    ar_ = false;
                }
                else
                {
                    Code<ObservationStatus> as_ = WeightExam?.StatusElement;
                    ObservationStatus? at_ = as_?.Value;
                    string au_ = context.Operators.Convert<string>(at_);
                    string[] av_ = [
                        "final",
                        "amended",
                        "corrected",
                    ];
                    bool? aw_ = context.Operators.In<string>(au_, (IEnumerable<string>)av_);
                    ar_ = aq_ & aw_;
                }
                // CQL 'and' (218:9-220:42): right operand skipped when left is false
                if (ar_ is false)
                {
                    return false;
                }
                else
                {
                    DataType ax_ = WeightExam?.Value;
                    CqlQuantity ay_ = FHIRHelpers_4_4_000.Instance.ToQuantity(context, ax_ as Quantity);
                    return ar_ & (!((bool?)(ay_ is null)));
                }
            }

            IEnumerable<Observation> o_ = context.Operators.Where<Observation>(f_, n_);

            object p_(Observation @this) {
                DataType az_ = @this?.Effective;
                object ba_ = FHIRHelpers_4_4_000.Instance.ToValue(context, az_);
                CqlDateTime bb_ = QICoreCommon_4_0_000.Instance.earliest(context, ba_);
                return bb_;
            }

            IEnumerable<Observation> q_ = context.Operators.SortBy<Observation>(o_, p_, System.ComponentModel.ListSortDirection.Ascending);
            Observation r_ = context.Operators.First<Observation>(q_);
            DataType s_ = r_?.Effective;
            object t_ = FHIRHelpers_4_4_000.Instance.ToValue(context, s_);
            CqlDateTime u_ = QICoreCommon_4_0_000.Instance.earliest(context, t_);
            (CqlTupleMetadata, string EncounterId, CqlQuantity FirstResult, CqlDateTime Timing)? v_ = (CqlTupleMetadata_HDVhZFAYAdGHPZJWcDFSNFGPd, e_, m_ as CqlQuantity, u_);
            return v_;
        }

        IEnumerable<(CqlTupleMetadata, string EncounterId, CqlQuantity FirstResult, CqlDateTime Timing)?> c_ = context.Operators.SelectDistinct<Encounter, (CqlTupleMetadata, string EncounterId, CqlQuantity FirstResult, CqlDateTime Timing)?>(a_, b_);
        return c_;
    }


    [CqlExpressionDefinition("SDE Encounter With Oxygen 60 Minutes Or Less Prior To ED Admission Or During ED")]
    public IEnumerable<Encounter> SDE_Encounter_With_Oxygen_60_Minutes_Or_Less_Prior_To_ED_Admission_Or_During_ED(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_SDE_Encounter_With_Oxygen_60_Minutes_Or_Less_Prior_To_ED_Admission_Or_During_ED, SDE_Encounter_With_Oxygen_60_Minutes_Or_Less_Prior_To_ED_Admission_Or_During_ED_Compute);

    private const long _cacheIndex_SDE_Encounter_With_Oxygen_60_Minutes_Or_Less_Prior_To_ED_Admission_Or_During_ED = 6260288556939837424L;

    private IEnumerable<Encounter> SDE_Encounter_With_Oxygen_60_Minutes_Or_Less_Prior_To_ED_Admission_Or_During_ED_Compute(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Initial_Population(context);

        bool? b_(Encounter EncounterInpatient) {
            CqlValueSet d_ = this.Non_Invasive_Oxygen_Therapy_by_Nasal_Cannula_or_Mask(context);
            IEnumerable<ServiceRequest> e_ = context.Operators.Retrieve<ServiceRequest>(new RetrieveParameters(default, d_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-servicerequest"));
            CqlValueSet f_ = this.Non_Invasive_Oxygen_Therapy_Device_Codes(context);
            IEnumerable<ServiceRequest> g_ = context.Operators.Retrieve<ServiceRequest>(new RetrieveParameters(default, f_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-servicerequest"));
            IEnumerable<ServiceRequest> h_ = context.Operators.Union<ServiceRequest>(e_, g_);

            bool? i_(ServiceRequest OxygenTherapyOrder) {
                FhirDateTime n_ = OxygenTherapyOrder?.AuthoredOnElement;
                CqlDateTime o_ = context.Operators.Convert<CqlDateTime>(n_);
                Encounter p_ = CQMCommon_4_1_000.Instance.edVisit(context, EncounterInpatient);
                Period q_ = p_?.Period;
                CqlInterval<CqlDateTime> r_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, q_);
                bool? s_ = context.Operators.In<CqlDateTime>(o_, r_, (string)default);
                bool? t_;
                // CQL 'or' (233:15-235:9): right operand skipped when left is true
                if (s_ is true)
                {
                    t_ = true;
                }
                else
                {
                    CqlDateTime v_ = context.Operators.Start(r_);
                    CqlQuantity w_ = context.Operators.Quantity(60m, "minutes");
                    CqlDateTime x_ = context.Operators.Subtract(v_, w_);
                    CqlInterval<CqlDateTime> y_ = context.Operators.Interval(x_, v_, true, true);
                    bool? z_ = context.Operators.In<CqlDateTime>(o_, y_, (string)default);
                    bool? aa_;
                    // CQL 'and' (234:16-234:123): right operand skipped when left is false
                    if (z_ is false)
                    {
                        aa_ = false;
                    }
                    else
                    {
                        aa_ = z_ & (!((bool?)(v_ is null)));
                    }
                    t_ = s_ | aa_;
                }
                bool? u_;
                // CQL 'and' (233:15-236:68): right operand skipped when left is false
                if (t_ is false)
                {
                    u_ = false;
                }
                else
                {
                    Code<RequestStatus> ab_ = OxygenTherapyOrder?.StatusElement;
                    RequestStatus? ac_ = ab_?.Value;
                    Code<RequestStatus> ad_ = context.Operators.Convert<Code<RequestStatus>>(ac_);
                    string ae_ = context.Operators.Convert<string>(ad_);
                    string[] af_ = [
                        "active",
                        "completed",
                    ];
                    bool? ag_ = context.Operators.In<string>(ae_, (IEnumerable<string>)af_);
                    u_ = t_ & ag_;
                }
                // CQL 'and' (233:9-237:49): right operand skipped when left is false
                if (u_ is false)
                {
                    return false;
                }
                else
                {
                    Code<RequestIntent> ah_ = OxygenTherapyOrder?.IntentElement;
                    RequestIntent? ai_ = ah_?.Value;
                    Code<RequestIntent> aj_ = context.Operators.Convert<Code<RequestIntent>>(ai_);
                    bool? ak_ = context.Operators.Equal(aj_, "order");
                    return u_ & ak_;
                }
            }


            (CqlTupleMetadata, string EncounterId, Code<RequestStatus> OrderStatus, CqlDateTime OrderTiming)? j_(ServiceRequest OxygenTherapyOrder) {
                Id al_ = EncounterInpatient?.IdElement;
                string am_ = al_?.Value;
                Code<RequestStatus> an_ = OxygenTherapyOrder?.StatusElement;
                RequestStatus? ao_ = an_?.Value;
                Code<RequestStatus> ap_ = context.Operators.Convert<Code<RequestStatus>>(ao_);
                FhirDateTime aq_ = OxygenTherapyOrder?.AuthoredOnElement;
                CqlDateTime ar_ = context.Operators.Convert<CqlDateTime>(aq_);
                (CqlTupleMetadata, string EncounterId, Code<RequestStatus> OrderStatus, CqlDateTime OrderTiming)? as_ = (CqlTupleMetadata_BTRiFTXPQGKeiLWUSieghMWCU, am_, ap_, ar_);
                return as_;
            }

            IEnumerable<(CqlTupleMetadata, string EncounterId, Code<RequestStatus> OrderStatus, CqlDateTime OrderTiming)?> k_ = context.Operators.WhereSelect<ServiceRequest, (CqlTupleMetadata, string EncounterId, Code<RequestStatus> OrderStatus, CqlDateTime OrderTiming)?>(h_, i_, j_);
            IEnumerable<(CqlTupleMetadata, string EncounterId, Code<RequestStatus> OrderStatus, CqlDateTime OrderTiming)?> l_ = context.Operators.Distinct<(CqlTupleMetadata, string EncounterId, Code<RequestStatus> OrderStatus, CqlDateTime OrderTiming)?>(k_);
            bool? m_ = context.Operators.Exists<(CqlTupleMetadata, string EncounterId, Code<RequestStatus> OrderStatus, CqlDateTime OrderTiming)?>(l_);
            // CQL 'or' (231:5-255:7): right operand skipped when left is true
            if (m_ is true)
            {
                return true;
            }
            else
            {
                IEnumerable<Procedure> at_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, d_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));

                bool? au_(Procedure OxygenAdminInterv) {
                    object az_;
                    DataType bh_ = OxygenAdminInterv?.Performed;
                    object bi_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bh_);
                    bool bj_ = bi_ is CqlDateTime;
                    if (bj_)
                    {
                        DataType bk_ = OxygenAdminInterv?.Performed;
                        object bl_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bk_);
                        az_ = bl_ as CqlDateTime;
                    }
                    else
                    {
                        DataType bm_ = OxygenAdminInterv?.Performed;
                        object bn_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bm_);
                        bool bo_ = bn_ is CqlQuantity;
                        if (bo_)
                        {
                            DataType bp_ = OxygenAdminInterv?.Performed;
                            object bq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bp_);
                            az_ = bq_ as CqlQuantity;
                        }
                        else
                        {
                            DataType br_ = OxygenAdminInterv?.Performed;
                            object bs_ = FHIRHelpers_4_4_000.Instance.ToValue(context, br_);
                            bool bt_ = bs_ is CqlInterval<CqlDateTime>;
                            if (bt_)
                            {
                                DataType bu_ = OxygenAdminInterv?.Performed;
                                object bv_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bu_);
                                az_ = bv_ as CqlInterval<CqlDateTime>;
                            }
                            else
                            {
                                DataType bw_ = OxygenAdminInterv?.Performed;
                                object bx_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bw_);
                                bool by_ = bx_ is CqlInterval<CqlQuantity>;
                                if (by_)
                                {
                                    DataType bz_ = OxygenAdminInterv?.Performed;
                                    object ca_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bz_);
                                    az_ = ca_ as CqlInterval<CqlQuantity>;
                                }
                                else
                                {
                                    az_ = null;
                                }
                            }
                        }
                    }
                    CqlInterval<CqlDateTime> ba_ = QICoreCommon_4_0_000.Instance.toInterval(context, az_);
                    CqlDateTime bb_ = context.Operators.Start(ba_);
                    Encounter bc_ = CQMCommon_4_1_000.Instance.edVisit(context, EncounterInpatient);
                    Period bd_ = bc_?.Period;
                    CqlInterval<CqlDateTime> be_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, bd_);
                    bool? bf_ = context.Operators.In<CqlDateTime>(bb_, be_, (string)default);
                    bool? bg_;
                    // CQL 'or' (245:17-247:11): right operand skipped when left is true
                    if (bf_ is true)
                    {
                        bg_ = true;
                    }
                    else
                    {
                        object cb_;
                        DataType ck_ = OxygenAdminInterv?.Performed;
                        object cl_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ck_);
                        bool cm_ = cl_ is CqlDateTime;
                        if (cm_)
                        {
                            DataType cn_ = OxygenAdminInterv?.Performed;
                            object co_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cn_);
                            cb_ = co_ as CqlDateTime;
                        }
                        else
                        {
                            DataType cp_ = OxygenAdminInterv?.Performed;
                            object cq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cp_);
                            bool cr_ = cq_ is CqlQuantity;
                            if (cr_)
                            {
                                DataType cs_ = OxygenAdminInterv?.Performed;
                                object ct_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cs_);
                                cb_ = ct_ as CqlQuantity;
                            }
                            else
                            {
                                DataType cu_ = OxygenAdminInterv?.Performed;
                                object cv_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cu_);
                                bool cw_ = cv_ is CqlInterval<CqlDateTime>;
                                if (cw_)
                                {
                                    DataType cx_ = OxygenAdminInterv?.Performed;
                                    object cy_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cx_);
                                    cb_ = cy_ as CqlInterval<CqlDateTime>;
                                }
                                else
                                {
                                    DataType cz_ = OxygenAdminInterv?.Performed;
                                    object da_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cz_);
                                    bool db_ = da_ is CqlInterval<CqlQuantity>;
                                    if (db_)
                                    {
                                        DataType dc_ = OxygenAdminInterv?.Performed;
                                        object dd_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dc_);
                                        cb_ = dd_ as CqlInterval<CqlQuantity>;
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
                        CqlDateTime ce_ = context.Operators.Start(be_);
                        CqlQuantity cf_ = context.Operators.Quantity(60m, "minutes");
                        CqlDateTime cg_ = context.Operators.Subtract(ce_, cf_);
                        CqlInterval<CqlDateTime> ch_ = context.Operators.Interval(cg_, ce_, true, true);
                        bool? ci_ = context.Operators.In<CqlDateTime>(cd_, ch_, (string)default);
                        bool? cj_;
                        // CQL 'and' (246:18-246:138): right operand skipped when left is false
                        if (ci_ is false)
                        {
                            cj_ = false;
                        }
                        else
                        {
                            cj_ = ci_ & (!((bool?)(ce_ is null)));
                        }
                        bg_ = bf_ | cj_;
                    }
                    // CQL 'and' (245:11-248:54): right operand skipped when left is false
                    if (bg_ is false)
                    {
                        return false;
                    }
                    else
                    {
                        Code<EventStatus> de_ = OxygenAdminInterv?.StatusElement;
                        EventStatus? df_ = de_?.Value;
                        string dg_ = context.Operators.Convert<string>(df_);
                        bool? dh_ = context.Operators.Equal(dg_, "completed");
                        return bg_ & dh_;
                    }
                }


                (CqlTupleMetadata, string EncounterId, CqlInterval<CqlDateTime> EDEncounterTiming, string PerformedStatus, CqlInterval<CqlDateTime> PerformedTiming)? av_(Procedure OxygenAdminInterv) {
                    Id di_ = EncounterInpatient?.IdElement;
                    string dj_ = di_?.Value;
                    Encounter dk_ = CQMCommon_4_1_000.Instance.edVisit(context, EncounterInpatient);
                    Period dl_ = dk_?.Period;
                    CqlInterval<CqlDateTime> dm_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, dl_);
                    Code<EventStatus> dn_ = OxygenAdminInterv?.StatusElement;
                    EventStatus? do_ = dn_?.Value;
                    string dp_ = context.Operators.Convert<string>(do_);
                    object dq_;
                    DataType dt_ = OxygenAdminInterv?.Performed;
                    object du_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dt_);
                    bool dv_ = du_ is CqlDateTime;
                    if (dv_)
                    {
                        DataType dw_ = OxygenAdminInterv?.Performed;
                        object dx_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dw_);
                        dq_ = dx_ as CqlDateTime;
                    }
                    else
                    {
                        DataType dy_ = OxygenAdminInterv?.Performed;
                        object dz_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dy_);
                        bool ea_ = dz_ is CqlQuantity;
                        if (ea_)
                        {
                            DataType eb_ = OxygenAdminInterv?.Performed;
                            object ec_ = FHIRHelpers_4_4_000.Instance.ToValue(context, eb_);
                            dq_ = ec_ as CqlQuantity;
                        }
                        else
                        {
                            DataType ed_ = OxygenAdminInterv?.Performed;
                            object ee_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ed_);
                            bool ef_ = ee_ is CqlInterval<CqlDateTime>;
                            if (ef_)
                            {
                                DataType eg_ = OxygenAdminInterv?.Performed;
                                object eh_ = FHIRHelpers_4_4_000.Instance.ToValue(context, eg_);
                                dq_ = eh_ as CqlInterval<CqlDateTime>;
                            }
                            else
                            {
                                DataType ei_ = OxygenAdminInterv?.Performed;
                                object ej_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ei_);
                                bool ek_ = ej_ is CqlInterval<CqlQuantity>;
                                if (ek_)
                                {
                                    DataType el_ = OxygenAdminInterv?.Performed;
                                    object em_ = FHIRHelpers_4_4_000.Instance.ToValue(context, el_);
                                    dq_ = em_ as CqlInterval<CqlQuantity>;
                                }
                                else
                                {
                                    dq_ = null;
                                }
                            }
                        }
                    }
                    CqlInterval<CqlDateTime> dr_ = QICoreCommon_4_0_000.Instance.toInterval(context, dq_);
                    (CqlTupleMetadata, string EncounterId, CqlInterval<CqlDateTime> EDEncounterTiming, string PerformedStatus, CqlInterval<CqlDateTime> PerformedTiming)? ds_ = (CqlTupleMetadata_HBSiHLDibCXHQcPZYMVBgXBIH, dj_, dm_, dp_, dr_);
                    return ds_;
                }

                IEnumerable<(CqlTupleMetadata, string EncounterId, CqlInterval<CqlDateTime> EDEncounterTiming, string PerformedStatus, CqlInterval<CqlDateTime> PerformedTiming)?> aw_ = context.Operators.WhereSelect<Procedure, (CqlTupleMetadata, string EncounterId, CqlInterval<CqlDateTime> EDEncounterTiming, string PerformedStatus, CqlInterval<CqlDateTime> PerformedTiming)?>(at_, au_, av_);
                IEnumerable<(CqlTupleMetadata, string EncounterId, CqlInterval<CqlDateTime> EDEncounterTiming, string PerformedStatus, CqlInterval<CqlDateTime> PerformedTiming)?> ax_ = context.Operators.Distinct<(CqlTupleMetadata, string EncounterId, CqlInterval<CqlDateTime> EDEncounterTiming, string PerformedStatus, CqlInterval<CqlDateTime> PerformedTiming)?>(aw_);
                bool? ay_ = context.Operators.Exists<(CqlTupleMetadata, string EncounterId, CqlInterval<CqlDateTime> EDEncounterTiming, string PerformedStatus, CqlInterval<CqlDateTime> PerformedTiming)?>(ax_);
                return m_ | ay_;
            }
        }

        IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);
        return c_;
    }


    [CqlExpressionDefinition("SDE Ethnicity")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Ethnicity(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_SDE_Ethnicity, SDE_Ethnicity_Compute);

    private const long _cacheIndex_SDE_Ethnicity = -2927595819383839539L;

    private (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Ethnicity_Compute(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? a_ = SupplementalDataElements_5_1_000.Instance.SDE_Ethnicity(context);
        return a_;
    }


    [CqlExpressionDefinition("SDE Payer")]
    public IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> SDE_Payer(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_SDE_Payer, SDE_Payer_Compute);

    private const long _cacheIndex_SDE_Payer = 5718293540977132843L;

    private IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> SDE_Payer_Compute(CqlContext context)
    {
        IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> a_ = SupplementalDataElements_5_1_000.Instance.SDE_Payer(context);
        return a_;
    }


    [CqlExpressionDefinition("SDE Race")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Race(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_SDE_Race, SDE_Race_Compute);

    private const long _cacheIndex_SDE_Race = -6422847655377928380L;

    private (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Race_Compute(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? a_ = SupplementalDataElements_5_1_000.Instance.SDE_Race(context);
        return a_;
    }


    [CqlExpressionDefinition("SDE Sex")]
    public CqlCode SDE_Sex(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_SDE_Sex, SDE_Sex_Compute);

    private const long _cacheIndex_SDE_Sex = -6432282191117057583L;

    private CqlCode SDE_Sex_Compute(CqlContext context)
    {
        CqlCode a_ = SupplementalDataElements_5_1_000.Instance.SDE_Sex(context);
        return a_;
    }


    #endregion Functions and Expressions

    #region Singleton Lifetime Members

    private CMSFHIR529HybridHospitalWideReadmission_0_5_001() {}

    public static CMSFHIR529HybridHospitalWideReadmission_0_5_001 Instance { get; } = new();

    #endregion

    #region ILibrary Implementation

    public string Name => "CMSFHIR529HybridHospitalWideReadmission";
    public string Version => "0.5.001";
    public ILibrary[] Dependencies => [CQMCommon_4_1_000.Instance, FHIRHelpers_4_4_000.Instance, QICoreCommon_4_0_000.Instance, SupplementalDataElements_5_1_000.Instance];

    #endregion ILibrary Implementation

    #region CqlTupleMetadata Properties

    private static CqlTupleMetadata CqlTupleMetadata_BTRiFTXPQGKeiLWUSieghMWCU = new(
       [typeof(string), typeof(Code<RequestStatus>), typeof(CqlDateTime)],
       ["EncounterId", "OrderStatus", "OrderTiming"]);

    private static CqlTupleMetadata CqlTupleMetadata_CYbMQaXdPgTVSLXJSHHNTbhVM = new(
       [typeof(string), typeof(CqlQuantity), typeof(CqlDateTime)],
       ["EncounterId", "FirstRespRateResult", "Timing"]);

    private static CqlTupleMetadata CqlTupleMetadata_DhbJAfCiKIAGYKTjJXYGSKECQ = new(
       [typeof(string), typeof(CqlQuantity), typeof(CqlDateTime)],
       ["EncounterId", "FirstHeartRateResult", "Timing"]);

    private static CqlTupleMetadata CqlTupleMetadata_FdREYEdHOZIcMCNYCRFJYJReA = new(
       [typeof(string), typeof(CqlQuantity), typeof(CqlDateTime)],
       ["EncounterId", "FirstOxygenSatResult", "Timing"]);

    private static CqlTupleMetadata CqlTupleMetadata_FjSKXeIESORPNbRGajibMfUaK = new(
       [typeof(string), typeof(IEnumerable<CqlQuantity>), typeof(CqlDateTime)],
       ["EncounterId", "FirstSBPResult", "Timing"]);

    private static CqlTupleMetadata CqlTupleMetadata_GIbILVAdXLLNYBgcQIEiUiKaK = new(
       [typeof(string), typeof(CqlQuantity), typeof(CqlDateTime)],
       ["EncounterId", "FirstTemperatureResult", "Timing"]);

    private static CqlTupleMetadata CqlTupleMetadata_HBSiHLDibCXHQcPZYMVBgXBIH = new(
       [typeof(string), typeof(CqlInterval<CqlDateTime>), typeof(string), typeof(CqlInterval<CqlDateTime>)],
       ["EncounterId", "EDEncounterTiming", "PerformedStatus", "PerformedTiming"]);

    private static CqlTupleMetadata CqlTupleMetadata_HDVhZFAYAdGHPZJWcDFSNFGPd = new(
       [typeof(string), typeof(CqlQuantity), typeof(CqlDateTime)],
       ["EncounterId", "FirstResult", "Timing"]);

    #endregion CqlTupleMetadata Properties

}

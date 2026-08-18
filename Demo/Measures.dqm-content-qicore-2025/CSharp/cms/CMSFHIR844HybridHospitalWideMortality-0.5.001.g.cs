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

[System.CodeDom.Compiler.GeneratedCode(".NET Code Generation", "5.3.8.0")]
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
    public CqlInterval<CqlDateTime> Measurement_Period(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Measurement_Period, Measurement_Period_Compute);

    private const long _cacheIndex_Measurement_Period = 8194214586127820629L;

    private CqlInterval<CqlDateTime> Measurement_Period_Compute(CqlContext context)
    {
        CqlDateTime a_ = context.Operators.DateTime(2026, 1, 1, 0, 0, 0, 0, 0.0m);
        CqlDateTime b_ = context.Operators.DateTime(2027, 1, 1, 0, 0, 0, 0, 0.0m);
        CqlInterval<CqlDateTime> c_ = context.Operators.Interval(a_, b_, true, false);
        object d_ = context.ResolveParameter("CMSFHIR844HybridHospitalWideMortality-0.5.001", "Measurement Period", c_);
        return (CqlInterval<CqlDateTime>)d_;
    }


    #endregion Parameters

    #region Functions and Expressions (18)

    [CqlExpressionDefinition("Patient")]
    public Patient Patient(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Patient, Patient_Compute);

    private const long _cacheIndex_Patient = -7320496347043068873L;

    private Patient Patient_Compute(CqlContext context)
    {
        IEnumerable<Patient> a_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-patient"));
        Patient b_ = context.Operators.SingletonFrom<Patient>(a_);
        return b_;
    }


    [CqlExpressionDefinition("Inpatient Encounters")]
    public IEnumerable<Encounter> Inpatient_Encounters(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Inpatient_Encounters, Inpatient_Encounters_Compute);

    private const long _cacheIndex_Inpatient_Encounters = -8287851696712078710L;

    private IEnumerable<Encounter> Inpatient_Encounters_Compute(CqlContext context)
    {
        CqlValueSet a_ = this.Encounter_Inpatient(context);
        IEnumerable<Encounter> b_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));

        bool? c_(Encounter EncounterInpatient) {
            CqlValueSet e_ = this.Medicare_FFS_payer(context);
            IEnumerable<Coverage> f_ = context.Operators.Retrieve<Coverage>(new RetrieveParameters(default, e_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-coverage"));
            CqlValueSet g_ = this.Medicare_Advantage_payer(context);
            IEnumerable<Coverage> h_ = context.Operators.Retrieve<Coverage>(new RetrieveParameters(default, g_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-coverage"));
            IEnumerable<Coverage> i_ = context.Operators.Union<Coverage>(f_, h_);

            bool? j_(Coverage MedicarePayer) {
                CqlInterval<CqlDateTime> l_ = CQMCommon_4_1_000.Instance.hospitalizationWithObservationAndOutpatientSurgeryService(context, EncounterInpatient);
                int? m_ = CQMCommon_4_1_000.Instance.lengthInDays(context, l_);
                CqlBoolean n_ = context.Operators.Less(m_, 365);
                Code<Encounter.EncounterStatus> o_ = EncounterInpatient?.StatusElement;
                Encounter.EncounterStatus? p_ = o_?.Value;
                Code<Encounter.EncounterStatus> q_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(p_);
                CqlBoolean r_ = context.Operators.Equal(q_, "finished");
                CqlBoolean s_ = r_;
                Patient t_ = this.Patient(context);
                Date u_ = t_?.BirthDateElement;
                string v_ = u_?.Value;
                CqlDate w_ = context.Operators.ConvertStringToDate(v_);
                Period x_ = EncounterInpatient?.Period;
                CqlInterval<CqlDateTime> y_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, x_);
                CqlDateTime z_ = context.Operators.Start(y_);
                CqlDate aa_ = context.Operators.DateFrom(z_);
                int? ab_ = context.Operators.CalculateAgeAt(w_, aa_, "year");
                CqlInterval<int?> ac_ = context.Operators.Interval(65, 94, true, true);
                CqlBoolean ad_ = context.Operators.In<int?>(ab_, ac_, (string)default);
                CqlBoolean ae_ = ad_;
                CqlDateTime af_ = context.Operators.End(y_);
                CqlInterval<CqlDateTime> ag_ = this.Measurement_Period(context);
                CqlBoolean ah_ = context.Operators.In<CqlDateTime>(af_, ag_, "day");
                CqlBoolean ai_ = ah_;
                return n_
                    /* CQL 'and' (40:17-41:50) */ && s_
                    /* CQL 'and' (40:17-42:90) */ && ae_
                    /* CQL 'and' (40:17-43:77) */ && ai_;
            }

            CqlBoolean k_ = context.Operators.WhereAny<Coverage>(i_, j_);
            return k_;
        }

        IEnumerable<Encounter> d_ = context.Operators.Where<Encounter>(b_, c_);
        return d_;
    }


    [CqlExpressionDefinition("Initial Population")]
    public IEnumerable<Encounter> Initial_Population(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Initial_Population, Initial_Population_Compute);

    private const long _cacheIndex_Initial_Population = -3847774137403444691L;

    private IEnumerable<Encounter> Initial_Population_Compute(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Inpatient_Encounters(context);
        return a_;
    }


    [CqlExpressionDefinition("SDE Encounter With First Body Temperature")]
    public IEnumerable<(CqlTupleMetadata, string EncounterId, CqlQuantity FirstTemperatureResult, CqlDateTime Timing)?> SDE_Encounter_With_First_Body_Temperature(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_SDE_Encounter_With_First_Body_Temperature, SDE_Encounter_With_First_Body_Temperature_Compute);

    private const long _cacheIndex_SDE_Encounter_With_First_Body_Temperature = -7526006116561995512L;

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
                CqlBoolean aa_ = context.Operators.In<CqlDateTime>(y_, z_, (string)default);
                Code<ObservationStatus> ab_ = Temperature?.StatusElement;
                ObservationStatus? ac_ = ab_?.Value;
                string ad_ = context.Operators.Convert<string>(ac_);
                string[] ae_ = [
                    "final",
                    "amended",
                    "corrected",
                ];
                CqlBoolean af_ = context.Operators.In<string>(ad_, (IEnumerable<string>)ae_);
                CqlBoolean ag_ = af_;
                DataType ah_ = Temperature?.Value;
                CqlQuantity ai_ = FHIRHelpers_4_4_000.Instance.ToQuantity(context, ah_ as Quantity);
                CqlBoolean aj_ = (CqlBoolean)(ai_ is not null);
                return aa_
                    /* CQL 'and' (48:15-49:71) */ && ag_
                    /* CQL 'and' (48:9-50:43) */ && aj_;
            }

            IEnumerable<Observation> h_ = context.Operators.Where<Observation>(f_, g_);

            object i_(Observation @this) {
                DataType ak_ = @this?.Effective;
                object al_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ak_);
                CqlDateTime am_ = QICoreCommon_4_0_000.Instance.earliest(context, al_);
                return am_;
            }

            IEnumerable<Observation> j_ = context.Operators.SortBy<Observation>(h_, i_, System.ComponentModel.ListSortDirection.Ascending);
            Observation k_ = context.Operators.First<Observation>(j_);
            DataType l_ = k_?.Value;
            CqlQuantity m_ = FHIRHelpers_4_4_000.Instance.ToQuantity(context, l_ as Quantity);

            bool? n_(Observation Temperature) {
                DataType an_ = Temperature?.Effective;
                object ao_ = FHIRHelpers_4_4_000.Instance.ToValue(context, an_);
                CqlDateTime ap_ = QICoreCommon_4_0_000.Instance.earliest(context, ao_);
                CqlInterval<CqlDateTime> aq_ = CQMCommon_4_1_000.Instance.hospitalizationWithObservationAndOutpatientSurgeryService(context, EncounterInpatient);
                CqlBoolean ar_ = context.Operators.In<CqlDateTime>(ap_, aq_, (string)default);
                Code<ObservationStatus> as_ = Temperature?.StatusElement;
                ObservationStatus? at_ = as_?.Value;
                string au_ = context.Operators.Convert<string>(at_);
                string[] av_ = [
                    "final",
                    "amended",
                    "corrected",
                ];
                CqlBoolean aw_ = context.Operators.In<string>(au_, (IEnumerable<string>)av_);
                CqlBoolean ax_ = aw_;
                DataType ay_ = Temperature?.Value;
                CqlQuantity az_ = FHIRHelpers_4_4_000.Instance.ToQuantity(context, ay_ as Quantity);
                CqlBoolean ba_ = (CqlBoolean)(az_ is not null);
                return ar_
                    /* CQL 'and' (48:15-49:71) */ && ax_
                    /* CQL 'and' (48:9-50:43) */ && ba_;
            }

            IEnumerable<Observation> o_ = context.Operators.Where<Observation>(f_, n_);

            object p_(Observation @this) {
                DataType bb_ = @this?.Effective;
                object bc_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bb_);
                CqlDateTime bd_ = QICoreCommon_4_0_000.Instance.earliest(context, bc_);
                return bd_;
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

    private const long _cacheIndex_SDE_Encounter_With_First_Heart_Rate = 139345589104903829L;

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
                CqlBoolean aa_ = context.Operators.In<CqlDateTime>(y_, z_, (string)default);
                Code<ObservationStatus> ab_ = HeartRate?.StatusElement;
                ObservationStatus? ac_ = ab_?.Value;
                string ad_ = context.Operators.Convert<string>(ac_);
                string[] ae_ = [
                    "final",
                    "amended",
                    "corrected",
                ];
                CqlBoolean af_ = context.Operators.In<string>(ad_, (IEnumerable<string>)ae_);
                CqlBoolean ag_ = af_;
                DataType ah_ = HeartRate?.Value;
                CqlQuantity ai_ = FHIRHelpers_4_4_000.Instance.ToQuantity(context, ah_ as Quantity);
                CqlBoolean aj_ = (CqlBoolean)(ai_ is not null);
                return aa_
                    /* CQL 'and' (62:15-63:69) */ && ag_
                    /* CQL 'and' (62:9-64:41) */ && aj_;
            }

            IEnumerable<Observation> h_ = context.Operators.Where<Observation>(f_, g_);

            object i_(Observation @this) {
                DataType ak_ = @this?.Effective;
                object al_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ak_);
                CqlDateTime am_ = QICoreCommon_4_0_000.Instance.earliest(context, al_);
                return am_;
            }

            IEnumerable<Observation> j_ = context.Operators.SortBy<Observation>(h_, i_, System.ComponentModel.ListSortDirection.Ascending);
            Observation k_ = context.Operators.First<Observation>(j_);
            DataType l_ = k_?.Value;
            CqlQuantity m_ = FHIRHelpers_4_4_000.Instance.ToQuantity(context, l_ as Quantity);

            bool? n_(Observation HeartRate) {
                DataType an_ = HeartRate?.Effective;
                object ao_ = FHIRHelpers_4_4_000.Instance.ToValue(context, an_);
                CqlDateTime ap_ = QICoreCommon_4_0_000.Instance.earliest(context, ao_);
                CqlInterval<CqlDateTime> aq_ = CQMCommon_4_1_000.Instance.hospitalizationWithObservationAndOutpatientSurgeryService(context, EncounterInpatient);
                CqlBoolean ar_ = context.Operators.In<CqlDateTime>(ap_, aq_, (string)default);
                Code<ObservationStatus> as_ = HeartRate?.StatusElement;
                ObservationStatus? at_ = as_?.Value;
                string au_ = context.Operators.Convert<string>(at_);
                string[] av_ = [
                    "final",
                    "amended",
                    "corrected",
                ];
                CqlBoolean aw_ = context.Operators.In<string>(au_, (IEnumerable<string>)av_);
                CqlBoolean ax_ = aw_;
                DataType ay_ = HeartRate?.Value;
                CqlQuantity az_ = FHIRHelpers_4_4_000.Instance.ToQuantity(context, ay_ as Quantity);
                CqlBoolean ba_ = (CqlBoolean)(az_ is not null);
                return ar_
                    /* CQL 'and' (62:15-63:69) */ && ax_
                    /* CQL 'and' (62:9-64:41) */ && ba_;
            }

            IEnumerable<Observation> o_ = context.Operators.Where<Observation>(f_, n_);

            object p_(Observation @this) {
                DataType bb_ = @this?.Effective;
                object bc_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bb_);
                CqlDateTime bd_ = QICoreCommon_4_0_000.Instance.earliest(context, bc_);
                return bd_;
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

    private const long _cacheIndex_SDE_Encounter_With_First_Oxygen_Saturation = -8371025803682788439L;

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
                CqlBoolean ab_ = context.Operators.In<CqlDateTime>(z_, aa_, (string)default);
                Code<ObservationStatus> ac_ = O2Saturation?.StatusElement;
                ObservationStatus? ad_ = ac_?.Value;
                string ae_ = context.Operators.Convert<string>(ad_);
                string[] af_ = [
                    "final",
                    "amended",
                    "corrected",
                ];
                CqlBoolean ag_ = context.Operators.In<string>(ae_, (IEnumerable<string>)af_);
                CqlBoolean ah_ = ag_;
                DataType ai_ = O2Saturation?.Value;
                CqlQuantity aj_ = FHIRHelpers_4_4_000.Instance.ToQuantity(context, ai_ as Quantity);
                CqlBoolean ak_ = (CqlBoolean)(aj_ is not null);
                return ab_
                    /* CQL 'and' (76:15-77:72) */ && ah_
                    /* CQL 'and' (76:9-78:44) */ && ak_;
            }

            IEnumerable<Observation> i_ = context.Operators.Where<Observation>(g_, h_);

            object j_(Observation @this) {
                DataType al_ = @this?.Effective;
                object am_ = FHIRHelpers_4_4_000.Instance.ToValue(context, al_);
                CqlDateTime an_ = QICoreCommon_4_0_000.Instance.earliest(context, am_);
                return an_;
            }

            IEnumerable<Observation> k_ = context.Operators.SortBy<Observation>(i_, j_, System.ComponentModel.ListSortDirection.Ascending);
            Observation l_ = context.Operators.First<Observation>(k_);
            DataType m_ = l_?.Value;
            CqlQuantity n_ = FHIRHelpers_4_4_000.Instance.ToQuantity(context, m_ as Quantity);

            bool? o_(Observation O2Saturation) {
                DataType ao_ = O2Saturation?.Effective;
                object ap_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ao_);
                CqlDateTime aq_ = QICoreCommon_4_0_000.Instance.earliest(context, ap_);
                CqlInterval<CqlDateTime> ar_ = CQMCommon_4_1_000.Instance.hospitalizationWithObservationAndOutpatientSurgeryService(context, EncounterInpatient);
                CqlBoolean as_ = context.Operators.In<CqlDateTime>(aq_, ar_, (string)default);
                Code<ObservationStatus> at_ = O2Saturation?.StatusElement;
                ObservationStatus? au_ = at_?.Value;
                string av_ = context.Operators.Convert<string>(au_);
                string[] aw_ = [
                    "final",
                    "amended",
                    "corrected",
                ];
                CqlBoolean ax_ = context.Operators.In<string>(av_, (IEnumerable<string>)aw_);
                CqlBoolean ay_ = ax_;
                DataType az_ = O2Saturation?.Value;
                CqlQuantity ba_ = FHIRHelpers_4_4_000.Instance.ToQuantity(context, az_ as Quantity);
                CqlBoolean bb_ = (CqlBoolean)(ba_ is not null);
                return as_
                    /* CQL 'and' (76:15-77:72) */ && ay_
                    /* CQL 'and' (76:9-78:44) */ && bb_;
            }

            IEnumerable<Observation> p_ = context.Operators.Where<Observation>(g_, o_);

            object q_(Observation @this) {
                DataType bc_ = @this?.Effective;
                object bd_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bc_);
                CqlDateTime be_ = QICoreCommon_4_0_000.Instance.earliest(context, bd_);
                return be_;
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


    [CqlExpressionDefinition("SDE Encounter With First Systolic Blood Pressure")]
    public IEnumerable<(CqlTupleMetadata, string EncounterId, IEnumerable<CqlQuantity> FirstSBPResult, CqlDateTime Timing)?> SDE_Encounter_With_First_Systolic_Blood_Pressure(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_SDE_Encounter_With_First_Systolic_Blood_Pressure, SDE_Encounter_With_First_Systolic_Blood_Pressure_Compute);

    private const long _cacheIndex_SDE_Encounter_With_First_Systolic_Blood_Pressure = -3207799827161922512L;

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
                CqlBoolean ad_ = context.Operators.In<CqlDateTime>(ab_, ac_, (string)default);
                Code<ObservationStatus> ae_ = BP?.StatusElement;
                ObservationStatus? af_ = ae_?.Value;
                string ag_ = context.Operators.Convert<string>(af_);
                string[] ah_ = [
                    "final",
                    "amended",
                    "corrected",
                ];
                CqlBoolean ai_ = context.Operators.In<string>(ag_, (IEnumerable<string>)ah_);
                CqlBoolean aj_ = ai_;
                List<Observation.ComponentComponent> ak_ = BP?.Component;

                bool? al_(Observation.ComponentComponent @this) {
                    DataType ap_ = @this?.Value;
                    object aq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ap_);
                    return aq_ is not null;
                }


                object am_(Observation.ComponentComponent @this) {
                    DataType ar_ = @this?.Value;
                    object as_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ar_);
                    return as_;
                }

                IEnumerable<object> an_ = context.Operators.WhereSelect<Observation.ComponentComponent, object>((IEnumerable<Observation.ComponentComponent>)ak_, al_, am_);
                CqlBoolean ao_ = (CqlBoolean)(an_ is not null);
                return ad_
                    /* CQL 'and' (90:15-91:62) */ && aj_
                    /* CQL 'and' (90:9-92:44) */ && ao_;
            }

            IEnumerable<Observation> h_ = context.Operators.Where<Observation>(f_, g_);

            object i_(Observation @this) {
                DataType at_ = @this?.Effective;
                object au_ = FHIRHelpers_4_4_000.Instance.ToValue(context, at_);
                CqlDateTime av_ = QICoreCommon_4_0_000.Instance.earliest(context, au_);
                return av_;
            }

            IEnumerable<Observation> j_ = context.Operators.SortBy<Observation>(h_, i_, System.ComponentModel.ListSortDirection.Ascending);
            Observation k_ = context.Operators.First<Observation>(j_);
            List<Observation.ComponentComponent> l_ = k_?.Component;

            bool? m_(Observation.ComponentComponent C) {
                CodeableConcept aw_ = C?.Code;
                CqlConcept ax_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, aw_);
                CqlCode ay_ = this.Systolic_blood_pressure(context);
                CqlConcept az_ = context.Operators.ConvertCodeToConcept(ay_);
                CqlBoolean ba_ = context.Operators.Equivalent(ax_, az_);
                return ba_;
            }


            CqlQuantity n_(Observation.ComponentComponent C) {
                DataType bb_ = C?.Value;
                object bc_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bb_);
                return bc_ as CqlQuantity;
            }

            IEnumerable<CqlQuantity> o_ = context.Operators.WhereSelect<Observation.ComponentComponent, CqlQuantity>((IEnumerable<Observation.ComponentComponent>)l_, m_, n_);
            IEnumerable<CqlQuantity> p_ = context.Operators.Distinct<CqlQuantity>(o_);

            bool? q_(Observation BP) {
                DataType bd_ = BP?.Effective;
                object be_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bd_);
                CqlDateTime bf_ = QICoreCommon_4_0_000.Instance.earliest(context, be_);
                CqlInterval<CqlDateTime> bg_ = CQMCommon_4_1_000.Instance.hospitalizationWithObservationAndOutpatientSurgeryService(context, EncounterInpatient);
                CqlBoolean bh_ = context.Operators.In<CqlDateTime>(bf_, bg_, (string)default);
                Code<ObservationStatus> bi_ = BP?.StatusElement;
                ObservationStatus? bj_ = bi_?.Value;
                string bk_ = context.Operators.Convert<string>(bj_);
                string[] bl_ = [
                    "final",
                    "amended",
                    "corrected",
                ];
                CqlBoolean bm_ = context.Operators.In<string>(bk_, (IEnumerable<string>)bl_);
                CqlBoolean bn_ = bm_;
                List<Observation.ComponentComponent> bo_ = BP?.Component;

                bool? bp_(Observation.ComponentComponent @this) {
                    DataType bt_ = @this?.Value;
                    object bu_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bt_);
                    return bu_ is not null;
                }


                object bq_(Observation.ComponentComponent @this) {
                    DataType bv_ = @this?.Value;
                    object bw_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bv_);
                    return bw_;
                }

                IEnumerable<object> br_ = context.Operators.WhereSelect<Observation.ComponentComponent, object>((IEnumerable<Observation.ComponentComponent>)bo_, bp_, bq_);
                CqlBoolean bs_ = (CqlBoolean)(br_ is not null);
                return bh_
                    /* CQL 'and' (90:15-91:62) */ && bn_
                    /* CQL 'and' (90:9-92:44) */ && bs_;
            }

            IEnumerable<Observation> r_ = context.Operators.Where<Observation>(f_, q_);

            object s_(Observation @this) {
                DataType bx_ = @this?.Effective;
                object by_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bx_);
                CqlDateTime bz_ = QICoreCommon_4_0_000.Instance.earliest(context, by_);
                return bz_;
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
    public IEnumerable<(CqlTupleMetadata, string EncounterId, CqlQuantity FirstBicarbonateResult, CqlDateTime Timing)?> SDE_Encounter_With_First_Bicarbonate_Lab_Test(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_SDE_Encounter_With_First_Bicarbonate_Lab_Test, SDE_Encounter_With_First_Bicarbonate_Lab_Test_Compute);

    private const long _cacheIndex_SDE_Encounter_With_First_Bicarbonate_Lab_Test = -5916718293760283523L;

    private IEnumerable<(CqlTupleMetadata, string EncounterId, CqlQuantity FirstBicarbonateResult, CqlDateTime Timing)?> SDE_Encounter_With_First_Bicarbonate_Lab_Test_Compute(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Inpatient_Encounters(context);

        (CqlTupleMetadata, string EncounterId, CqlQuantity FirstBicarbonateResult, CqlDateTime Timing)? b_(Encounter EncounterInpatient) {
            Id d_ = EncounterInpatient?.IdElement;
            string e_ = d_?.Value;
            CqlValueSet f_ = this.Bicarbonate_lab_test(context);
            IEnumerable<Observation> g_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, f_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation-lab"));

            bool? h_(Observation BicarbonateLab) {
                object x_;
                DataType ak_ = BicarbonateLab?.Effective;
                object al_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ak_);
                bool am_ = al_ is CqlDateTime;
                if (am_)
                {
                    x_ = al_ as CqlDateTime;
                }
                else
                {
                    if (am_)
                    {
                        x_ = al_ as CqlDateTime;
                    }
                    else
                    {
                        bool an_ = al_ is CqlInterval<CqlDateTime>;
                        if (an_)
                        {
                            x_ = al_ as CqlInterval<CqlDateTime>;
                        }
                        else
                        {
                            x_ = null;
                        }
                    }
                }
                CqlDateTime y_ = QICoreCommon_4_0_000.Instance.earliest(context, x_);
                CqlInterval<CqlDateTime> z_ = CQMCommon_4_1_000.Instance.hospitalizationWithObservationAndOutpatientSurgeryService(context, EncounterInpatient);
                CqlBoolean aa_ = context.Operators.In<CqlDateTime>(y_, z_, (string)default);
                Code<ObservationStatus> ab_ = BicarbonateLab?.StatusElement;
                ObservationStatus? ac_ = ab_?.Value;
                string ad_ = context.Operators.Convert<string>(ac_);
                string[] ae_ = [
                    "final",
                    "amended",
                    "corrected",
                ];
                CqlBoolean af_ = context.Operators.In<string>(ad_, (IEnumerable<string>)ae_);
                CqlBoolean ag_ = af_;
                DataType ah_ = BicarbonateLab?.Value;
                object ai_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ah_);
                CqlBoolean aj_ = (CqlBoolean)(ai_ is not null);
                return aa_
                    /* CQL 'and' (106:15-107:74) */ && ag_
                    /* CQL 'and' (106:9-108:46) */ && aj_;
            }

            IEnumerable<Observation> i_ = context.Operators.Where<Observation>(g_, h_);

            object j_(Observation @this) {
                Instant ao_ = @this?.IssuedElement;
                DateTimeOffset? ap_ = ao_?.Value;
                CqlDateTime aq_ = context.Operators.Convert<CqlDateTime>(ap_);
                CqlDateTime ar_ = QICoreCommon_4_0_000.Instance.earliest(context, aq_);
                return ar_;
            }

            IEnumerable<Observation> k_ = context.Operators.SortBy<Observation>(i_, j_, System.ComponentModel.ListSortDirection.Ascending);
            Observation l_ = context.Operators.First<Observation>(k_);
            DataType m_ = l_?.Value;
            object n_ = FHIRHelpers_4_4_000.Instance.ToValue(context, m_);

            bool? o_(Observation BicarbonateLab) {
                object as_;
                DataType bf_ = BicarbonateLab?.Effective;
                object bg_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bf_);
                bool bh_ = bg_ is CqlDateTime;
                if (bh_)
                {
                    as_ = bg_ as CqlDateTime;
                }
                else
                {
                    if (bh_)
                    {
                        as_ = bg_ as CqlDateTime;
                    }
                    else
                    {
                        bool bi_ = bg_ is CqlInterval<CqlDateTime>;
                        if (bi_)
                        {
                            as_ = bg_ as CqlInterval<CqlDateTime>;
                        }
                        else
                        {
                            as_ = null;
                        }
                    }
                }
                CqlDateTime at_ = QICoreCommon_4_0_000.Instance.earliest(context, as_);
                CqlInterval<CqlDateTime> au_ = CQMCommon_4_1_000.Instance.hospitalizationWithObservationAndOutpatientSurgeryService(context, EncounterInpatient);
                CqlBoolean av_ = context.Operators.In<CqlDateTime>(at_, au_, (string)default);
                Code<ObservationStatus> aw_ = BicarbonateLab?.StatusElement;
                ObservationStatus? ax_ = aw_?.Value;
                string ay_ = context.Operators.Convert<string>(ax_);
                string[] az_ = [
                    "final",
                    "amended",
                    "corrected",
                ];
                CqlBoolean ba_ = context.Operators.In<string>(ay_, (IEnumerable<string>)az_);
                CqlBoolean bb_ = ba_;
                DataType bc_ = BicarbonateLab?.Value;
                object bd_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bc_);
                CqlBoolean be_ = (CqlBoolean)(bd_ is not null);
                return av_
                    /* CQL 'and' (106:15-107:74) */ && bb_
                    /* CQL 'and' (106:9-108:46) */ && be_;
            }

            IEnumerable<Observation> p_ = context.Operators.Where<Observation>(g_, o_);

            object q_(Observation @this) {
                Instant bj_ = @this?.IssuedElement;
                DateTimeOffset? bk_ = bj_?.Value;
                CqlDateTime bl_ = context.Operators.Convert<CqlDateTime>(bk_);
                CqlDateTime bm_ = QICoreCommon_4_0_000.Instance.earliest(context, bl_);
                return bm_;
            }

            IEnumerable<Observation> r_ = context.Operators.SortBy<Observation>(p_, q_, System.ComponentModel.ListSortDirection.Ascending);
            Observation s_ = context.Operators.First<Observation>(r_);
            Instant t_ = s_?.IssuedElement;
            DateTimeOffset? u_ = t_?.Value;
            CqlDateTime v_ = context.Operators.Convert<CqlDateTime>(u_);
            (CqlTupleMetadata, string EncounterId, CqlQuantity FirstBicarbonateResult, CqlDateTime Timing)? w_ = (CqlTupleMetadata_GbUHPXXHScejjXWhcHJFQQifQ, e_, n_ as CqlQuantity, v_);
            return w_;
        }

        IEnumerable<(CqlTupleMetadata, string EncounterId, CqlQuantity FirstBicarbonateResult, CqlDateTime Timing)?> c_ = context.Operators.SelectDistinct<Encounter, (CqlTupleMetadata, string EncounterId, CqlQuantity FirstBicarbonateResult, CqlDateTime Timing)?>(a_, b_);
        return c_;
    }


    [CqlExpressionDefinition("SDE Encounter With First Creatinine Lab Test")]
    public IEnumerable<(CqlTupleMetadata, string EncounterId, CqlQuantity FirstCreatinineResult, CqlDateTime Timing)?> SDE_Encounter_With_First_Creatinine_Lab_Test(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_SDE_Encounter_With_First_Creatinine_Lab_Test, SDE_Encounter_With_First_Creatinine_Lab_Test_Compute);

    private const long _cacheIndex_SDE_Encounter_With_First_Creatinine_Lab_Test = -5779842121506852161L;

    private IEnumerable<(CqlTupleMetadata, string EncounterId, CqlQuantity FirstCreatinineResult, CqlDateTime Timing)?> SDE_Encounter_With_First_Creatinine_Lab_Test_Compute(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Inpatient_Encounters(context);

        (CqlTupleMetadata, string EncounterId, CqlQuantity FirstCreatinineResult, CqlDateTime Timing)? b_(Encounter EncounterInpatient) {
            Id d_ = EncounterInpatient?.IdElement;
            string e_ = d_?.Value;
            CqlValueSet f_ = this.Creatinine_lab_test(context);
            IEnumerable<Observation> g_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, f_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation-lab"));

            bool? h_(Observation CreatinineLab) {
                object x_;
                DataType ak_ = CreatinineLab?.Effective;
                object al_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ak_);
                bool am_ = al_ is CqlDateTime;
                if (am_)
                {
                    x_ = al_ as CqlDateTime;
                }
                else
                {
                    if (am_)
                    {
                        x_ = al_ as CqlDateTime;
                    }
                    else
                    {
                        bool an_ = al_ is CqlInterval<CqlDateTime>;
                        if (an_)
                        {
                            x_ = al_ as CqlInterval<CqlDateTime>;
                        }
                        else
                        {
                            x_ = null;
                        }
                    }
                }
                CqlDateTime y_ = QICoreCommon_4_0_000.Instance.earliest(context, x_);
                CqlInterval<CqlDateTime> z_ = CQMCommon_4_1_000.Instance.hospitalizationWithObservationAndOutpatientSurgeryService(context, EncounterInpatient);
                CqlBoolean aa_ = context.Operators.In<CqlDateTime>(y_, z_, (string)default);
                Code<ObservationStatus> ab_ = CreatinineLab?.StatusElement;
                ObservationStatus? ac_ = ab_?.Value;
                string ad_ = context.Operators.Convert<string>(ac_);
                string[] ae_ = [
                    "final",
                    "amended",
                    "corrected",
                ];
                CqlBoolean af_ = context.Operators.In<string>(ad_, (IEnumerable<string>)ae_);
                CqlBoolean ag_ = af_;
                DataType ah_ = CreatinineLab?.Value;
                object ai_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ah_);
                CqlBoolean aj_ = (CqlBoolean)(ai_ is not null);
                return aa_
                    /* CQL 'and' (120:15-121:73) */ && ag_
                    /* CQL 'and' (120:9-122:45) */ && aj_;
            }

            IEnumerable<Observation> i_ = context.Operators.Where<Observation>(g_, h_);

            object j_(Observation @this) {
                Instant ao_ = @this?.IssuedElement;
                DateTimeOffset? ap_ = ao_?.Value;
                CqlDateTime aq_ = context.Operators.Convert<CqlDateTime>(ap_);
                CqlDateTime ar_ = QICoreCommon_4_0_000.Instance.earliest(context, aq_);
                return ar_;
            }

            IEnumerable<Observation> k_ = context.Operators.SortBy<Observation>(i_, j_, System.ComponentModel.ListSortDirection.Ascending);
            Observation l_ = context.Operators.First<Observation>(k_);
            DataType m_ = l_?.Value;
            object n_ = FHIRHelpers_4_4_000.Instance.ToValue(context, m_);

            bool? o_(Observation CreatinineLab) {
                object as_;
                DataType bf_ = CreatinineLab?.Effective;
                object bg_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bf_);
                bool bh_ = bg_ is CqlDateTime;
                if (bh_)
                {
                    as_ = bg_ as CqlDateTime;
                }
                else
                {
                    if (bh_)
                    {
                        as_ = bg_ as CqlDateTime;
                    }
                    else
                    {
                        bool bi_ = bg_ is CqlInterval<CqlDateTime>;
                        if (bi_)
                        {
                            as_ = bg_ as CqlInterval<CqlDateTime>;
                        }
                        else
                        {
                            as_ = null;
                        }
                    }
                }
                CqlDateTime at_ = QICoreCommon_4_0_000.Instance.earliest(context, as_);
                CqlInterval<CqlDateTime> au_ = CQMCommon_4_1_000.Instance.hospitalizationWithObservationAndOutpatientSurgeryService(context, EncounterInpatient);
                CqlBoolean av_ = context.Operators.In<CqlDateTime>(at_, au_, (string)default);
                Code<ObservationStatus> aw_ = CreatinineLab?.StatusElement;
                ObservationStatus? ax_ = aw_?.Value;
                string ay_ = context.Operators.Convert<string>(ax_);
                string[] az_ = [
                    "final",
                    "amended",
                    "corrected",
                ];
                CqlBoolean ba_ = context.Operators.In<string>(ay_, (IEnumerable<string>)az_);
                CqlBoolean bb_ = ba_;
                DataType bc_ = CreatinineLab?.Value;
                object bd_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bc_);
                CqlBoolean be_ = (CqlBoolean)(bd_ is not null);
                return av_
                    /* CQL 'and' (120:15-121:73) */ && bb_
                    /* CQL 'and' (120:9-122:45) */ && be_;
            }

            IEnumerable<Observation> p_ = context.Operators.Where<Observation>(g_, o_);

            object q_(Observation @this) {
                Instant bj_ = @this?.IssuedElement;
                DateTimeOffset? bk_ = bj_?.Value;
                CqlDateTime bl_ = context.Operators.Convert<CqlDateTime>(bk_);
                CqlDateTime bm_ = QICoreCommon_4_0_000.Instance.earliest(context, bl_);
                return bm_;
            }

            IEnumerable<Observation> r_ = context.Operators.SortBy<Observation>(p_, q_, System.ComponentModel.ListSortDirection.Ascending);
            Observation s_ = context.Operators.First<Observation>(r_);
            Instant t_ = s_?.IssuedElement;
            DateTimeOffset? u_ = t_?.Value;
            CqlDateTime v_ = context.Operators.Convert<CqlDateTime>(u_);
            (CqlTupleMetadata, string EncounterId, CqlQuantity FirstCreatinineResult, CqlDateTime Timing)? w_ = (CqlTupleMetadata_FETECNQPQREfGRgPYWhOWgeWA, e_, n_ as CqlQuantity, v_);
            return w_;
        }

        IEnumerable<(CqlTupleMetadata, string EncounterId, CqlQuantity FirstCreatinineResult, CqlDateTime Timing)?> c_ = context.Operators.SelectDistinct<Encounter, (CqlTupleMetadata, string EncounterId, CqlQuantity FirstCreatinineResult, CqlDateTime Timing)?>(a_, b_);
        return c_;
    }


    [CqlExpressionDefinition("SDE Encounter With First Hematocrit Lab Test")]
    public IEnumerable<(CqlTupleMetadata, string EncounterId, CqlQuantity FirstHematocritResult, CqlDateTime Timing)?> SDE_Encounter_With_First_Hematocrit_Lab_Test(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_SDE_Encounter_With_First_Hematocrit_Lab_Test, SDE_Encounter_With_First_Hematocrit_Lab_Test_Compute);

    private const long _cacheIndex_SDE_Encounter_With_First_Hematocrit_Lab_Test = -6738782626327138842L;

    private IEnumerable<(CqlTupleMetadata, string EncounterId, CqlQuantity FirstHematocritResult, CqlDateTime Timing)?> SDE_Encounter_With_First_Hematocrit_Lab_Test_Compute(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Inpatient_Encounters(context);

        (CqlTupleMetadata, string EncounterId, CqlQuantity FirstHematocritResult, CqlDateTime Timing)? b_(Encounter EncounterInpatient) {
            Id d_ = EncounterInpatient?.IdElement;
            string e_ = d_?.Value;
            CqlValueSet f_ = this.Hematocrit_lab_test(context);
            IEnumerable<Observation> g_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, f_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation-lab"));

            bool? h_(Observation HematocritLab) {
                object x_;
                DataType ak_ = HematocritLab?.Effective;
                object al_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ak_);
                bool am_ = al_ is CqlDateTime;
                if (am_)
                {
                    x_ = al_ as CqlDateTime;
                }
                else
                {
                    if (am_)
                    {
                        x_ = al_ as CqlDateTime;
                    }
                    else
                    {
                        bool an_ = al_ is CqlInterval<CqlDateTime>;
                        if (an_)
                        {
                            x_ = al_ as CqlInterval<CqlDateTime>;
                        }
                        else
                        {
                            x_ = null;
                        }
                    }
                }
                CqlDateTime y_ = QICoreCommon_4_0_000.Instance.earliest(context, x_);
                CqlInterval<CqlDateTime> z_ = CQMCommon_4_1_000.Instance.hospitalizationWithObservationAndOutpatientSurgeryService(context, EncounterInpatient);
                CqlBoolean aa_ = context.Operators.In<CqlDateTime>(y_, z_, (string)default);
                Code<ObservationStatus> ab_ = HematocritLab?.StatusElement;
                ObservationStatus? ac_ = ab_?.Value;
                string ad_ = context.Operators.Convert<string>(ac_);
                string[] ae_ = [
                    "final",
                    "amended",
                    "corrected",
                ];
                CqlBoolean af_ = context.Operators.In<string>(ad_, (IEnumerable<string>)ae_);
                CqlBoolean ag_ = af_;
                DataType ah_ = HematocritLab?.Value;
                object ai_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ah_);
                CqlBoolean aj_ = (CqlBoolean)(ai_ is not null);
                return aa_
                    /* CQL 'and' (134:15-135:73) */ && ag_
                    /* CQL 'and' (134:9-136:45) */ && aj_;
            }

            IEnumerable<Observation> i_ = context.Operators.Where<Observation>(g_, h_);

            object j_(Observation @this) {
                Instant ao_ = @this?.IssuedElement;
                DateTimeOffset? ap_ = ao_?.Value;
                CqlDateTime aq_ = context.Operators.Convert<CqlDateTime>(ap_);
                CqlDateTime ar_ = QICoreCommon_4_0_000.Instance.earliest(context, aq_);
                return ar_;
            }

            IEnumerable<Observation> k_ = context.Operators.SortBy<Observation>(i_, j_, System.ComponentModel.ListSortDirection.Ascending);
            Observation l_ = context.Operators.First<Observation>(k_);
            DataType m_ = l_?.Value;
            object n_ = FHIRHelpers_4_4_000.Instance.ToValue(context, m_);

            bool? o_(Observation HematocritLab) {
                object as_;
                DataType bf_ = HematocritLab?.Effective;
                object bg_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bf_);
                bool bh_ = bg_ is CqlDateTime;
                if (bh_)
                {
                    as_ = bg_ as CqlDateTime;
                }
                else
                {
                    if (bh_)
                    {
                        as_ = bg_ as CqlDateTime;
                    }
                    else
                    {
                        bool bi_ = bg_ is CqlInterval<CqlDateTime>;
                        if (bi_)
                        {
                            as_ = bg_ as CqlInterval<CqlDateTime>;
                        }
                        else
                        {
                            as_ = null;
                        }
                    }
                }
                CqlDateTime at_ = QICoreCommon_4_0_000.Instance.earliest(context, as_);
                CqlInterval<CqlDateTime> au_ = CQMCommon_4_1_000.Instance.hospitalizationWithObservationAndOutpatientSurgeryService(context, EncounterInpatient);
                CqlBoolean av_ = context.Operators.In<CqlDateTime>(at_, au_, (string)default);
                Code<ObservationStatus> aw_ = HematocritLab?.StatusElement;
                ObservationStatus? ax_ = aw_?.Value;
                string ay_ = context.Operators.Convert<string>(ax_);
                string[] az_ = [
                    "final",
                    "amended",
                    "corrected",
                ];
                CqlBoolean ba_ = context.Operators.In<string>(ay_, (IEnumerable<string>)az_);
                CqlBoolean bb_ = ba_;
                DataType bc_ = HematocritLab?.Value;
                object bd_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bc_);
                CqlBoolean be_ = (CqlBoolean)(bd_ is not null);
                return av_
                    /* CQL 'and' (134:15-135:73) */ && bb_
                    /* CQL 'and' (134:9-136:45) */ && be_;
            }

            IEnumerable<Observation> p_ = context.Operators.Where<Observation>(g_, o_);

            object q_(Observation @this) {
                Instant bj_ = @this?.IssuedElement;
                DateTimeOffset? bk_ = bj_?.Value;
                CqlDateTime bl_ = context.Operators.Convert<CqlDateTime>(bk_);
                CqlDateTime bm_ = QICoreCommon_4_0_000.Instance.earliest(context, bl_);
                return bm_;
            }

            IEnumerable<Observation> r_ = context.Operators.SortBy<Observation>(p_, q_, System.ComponentModel.ListSortDirection.Ascending);
            Observation s_ = context.Operators.First<Observation>(r_);
            Instant t_ = s_?.IssuedElement;
            DateTimeOffset? u_ = t_?.Value;
            CqlDateTime v_ = context.Operators.Convert<CqlDateTime>(u_);
            (CqlTupleMetadata, string EncounterId, CqlQuantity FirstHematocritResult, CqlDateTime Timing)? w_ = (CqlTupleMetadata_DIHdhbAJeJTdiAVUAELUHRNdS, e_, n_ as CqlQuantity, v_);
            return w_;
        }

        IEnumerable<(CqlTupleMetadata, string EncounterId, CqlQuantity FirstHematocritResult, CqlDateTime Timing)?> c_ = context.Operators.SelectDistinct<Encounter, (CqlTupleMetadata, string EncounterId, CqlQuantity FirstHematocritResult, CqlDateTime Timing)?>(a_, b_);
        return c_;
    }


    [CqlExpressionDefinition("SDE Encounter With First Platelet Lab Test")]
    public IEnumerable<(CqlTupleMetadata, string EncounterId, CqlQuantity FirstPlateletResult, CqlDateTime Timing)?> SDE_Encounter_With_First_Platelet_Lab_Test(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_SDE_Encounter_With_First_Platelet_Lab_Test, SDE_Encounter_With_First_Platelet_Lab_Test_Compute);

    private const long _cacheIndex_SDE_Encounter_With_First_Platelet_Lab_Test = -354840183162715779L;

    private IEnumerable<(CqlTupleMetadata, string EncounterId, CqlQuantity FirstPlateletResult, CqlDateTime Timing)?> SDE_Encounter_With_First_Platelet_Lab_Test_Compute(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Inpatient_Encounters(context);

        (CqlTupleMetadata, string EncounterId, CqlQuantity FirstPlateletResult, CqlDateTime Timing)? b_(Encounter EncounterInpatient) {
            Id d_ = EncounterInpatient?.IdElement;
            string e_ = d_?.Value;
            CqlValueSet f_ = this.Platelet_count_lab_test(context);
            IEnumerable<Observation> g_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, f_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation-lab"));

            bool? h_(Observation PlateletLab) {
                object x_;
                DataType ak_ = PlateletLab?.Effective;
                object al_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ak_);
                bool am_ = al_ is CqlDateTime;
                if (am_)
                {
                    x_ = al_ as CqlDateTime;
                }
                else
                {
                    if (am_)
                    {
                        x_ = al_ as CqlDateTime;
                    }
                    else
                    {
                        bool an_ = al_ is CqlInterval<CqlDateTime>;
                        if (an_)
                        {
                            x_ = al_ as CqlInterval<CqlDateTime>;
                        }
                        else
                        {
                            x_ = null;
                        }
                    }
                }
                CqlDateTime y_ = QICoreCommon_4_0_000.Instance.earliest(context, x_);
                CqlInterval<CqlDateTime> z_ = CQMCommon_4_1_000.Instance.hospitalizationWithObservationAndOutpatientSurgeryService(context, EncounterInpatient);
                CqlBoolean aa_ = context.Operators.In<CqlDateTime>(y_, z_, (string)default);
                Code<ObservationStatus> ab_ = PlateletLab?.StatusElement;
                ObservationStatus? ac_ = ab_?.Value;
                string ad_ = context.Operators.Convert<string>(ac_);
                string[] ae_ = [
                    "final",
                    "amended",
                    "corrected",
                ];
                CqlBoolean af_ = context.Operators.In<string>(ad_, (IEnumerable<string>)ae_);
                CqlBoolean ag_ = af_;
                DataType ah_ = PlateletLab?.Value;
                object ai_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ah_);
                CqlBoolean aj_ = (CqlBoolean)(ai_ is not null);
                return aa_
                    /* CQL 'and' (148:15-149:71) */ && ag_
                    /* CQL 'and' (148:9-150:43) */ && aj_;
            }

            IEnumerable<Observation> i_ = context.Operators.Where<Observation>(g_, h_);

            object j_(Observation @this) {
                Instant ao_ = @this?.IssuedElement;
                DateTimeOffset? ap_ = ao_?.Value;
                CqlDateTime aq_ = context.Operators.Convert<CqlDateTime>(ap_);
                CqlDateTime ar_ = QICoreCommon_4_0_000.Instance.earliest(context, aq_);
                return ar_;
            }

            IEnumerable<Observation> k_ = context.Operators.SortBy<Observation>(i_, j_, System.ComponentModel.ListSortDirection.Ascending);
            Observation l_ = context.Operators.First<Observation>(k_);
            DataType m_ = l_?.Value;
            object n_ = FHIRHelpers_4_4_000.Instance.ToValue(context, m_);

            bool? o_(Observation PlateletLab) {
                object as_;
                DataType bf_ = PlateletLab?.Effective;
                object bg_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bf_);
                bool bh_ = bg_ is CqlDateTime;
                if (bh_)
                {
                    as_ = bg_ as CqlDateTime;
                }
                else
                {
                    if (bh_)
                    {
                        as_ = bg_ as CqlDateTime;
                    }
                    else
                    {
                        bool bi_ = bg_ is CqlInterval<CqlDateTime>;
                        if (bi_)
                        {
                            as_ = bg_ as CqlInterval<CqlDateTime>;
                        }
                        else
                        {
                            as_ = null;
                        }
                    }
                }
                CqlDateTime at_ = QICoreCommon_4_0_000.Instance.earliest(context, as_);
                CqlInterval<CqlDateTime> au_ = CQMCommon_4_1_000.Instance.hospitalizationWithObservationAndOutpatientSurgeryService(context, EncounterInpatient);
                CqlBoolean av_ = context.Operators.In<CqlDateTime>(at_, au_, (string)default);
                Code<ObservationStatus> aw_ = PlateletLab?.StatusElement;
                ObservationStatus? ax_ = aw_?.Value;
                string ay_ = context.Operators.Convert<string>(ax_);
                string[] az_ = [
                    "final",
                    "amended",
                    "corrected",
                ];
                CqlBoolean ba_ = context.Operators.In<string>(ay_, (IEnumerable<string>)az_);
                CqlBoolean bb_ = ba_;
                DataType bc_ = PlateletLab?.Value;
                object bd_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bc_);
                CqlBoolean be_ = (CqlBoolean)(bd_ is not null);
                return av_
                    /* CQL 'and' (148:15-149:71) */ && bb_
                    /* CQL 'and' (148:9-150:43) */ && be_;
            }

            IEnumerable<Observation> p_ = context.Operators.Where<Observation>(g_, o_);

            object q_(Observation @this) {
                Instant bj_ = @this?.IssuedElement;
                DateTimeOffset? bk_ = bj_?.Value;
                CqlDateTime bl_ = context.Operators.Convert<CqlDateTime>(bk_);
                CqlDateTime bm_ = QICoreCommon_4_0_000.Instance.earliest(context, bl_);
                return bm_;
            }

            IEnumerable<Observation> r_ = context.Operators.SortBy<Observation>(p_, q_, System.ComponentModel.ListSortDirection.Ascending);
            Observation s_ = context.Operators.First<Observation>(r_);
            Instant t_ = s_?.IssuedElement;
            DateTimeOffset? u_ = t_?.Value;
            CqlDateTime v_ = context.Operators.Convert<CqlDateTime>(u_);
            (CqlTupleMetadata, string EncounterId, CqlQuantity FirstPlateletResult, CqlDateTime Timing)? w_ = (CqlTupleMetadata_DAUcYHQZcDKbIfORJOEZBDgIh, e_, n_ as CqlQuantity, v_);
            return w_;
        }

        IEnumerable<(CqlTupleMetadata, string EncounterId, CqlQuantity FirstPlateletResult, CqlDateTime Timing)?> c_ = context.Operators.SelectDistinct<Encounter, (CqlTupleMetadata, string EncounterId, CqlQuantity FirstPlateletResult, CqlDateTime Timing)?>(a_, b_);
        return c_;
    }


    [CqlExpressionDefinition("SDE Encounter With First Sodium Lab Test")]
    public IEnumerable<(CqlTupleMetadata, string EncounterId, CqlQuantity FirstSodiumResult, CqlDateTime Timing)?> SDE_Encounter_With_First_Sodium_Lab_Test(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_SDE_Encounter_With_First_Sodium_Lab_Test, SDE_Encounter_With_First_Sodium_Lab_Test_Compute);

    private const long _cacheIndex_SDE_Encounter_With_First_Sodium_Lab_Test = 1704795996816869661L;

    private IEnumerable<(CqlTupleMetadata, string EncounterId, CqlQuantity FirstSodiumResult, CqlDateTime Timing)?> SDE_Encounter_With_First_Sodium_Lab_Test_Compute(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Inpatient_Encounters(context);

        (CqlTupleMetadata, string EncounterId, CqlQuantity FirstSodiumResult, CqlDateTime Timing)? b_(Encounter EncounterInpatient) {
            Id d_ = EncounterInpatient?.IdElement;
            string e_ = d_?.Value;
            CqlValueSet f_ = this.Sodium_lab_test(context);
            IEnumerable<Observation> g_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, f_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation-lab"));

            bool? h_(Observation SodiumLab) {
                object x_;
                DataType ak_ = SodiumLab?.Effective;
                object al_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ak_);
                bool am_ = al_ is CqlDateTime;
                if (am_)
                {
                    x_ = al_ as CqlDateTime;
                }
                else
                {
                    if (am_)
                    {
                        x_ = al_ as CqlDateTime;
                    }
                    else
                    {
                        bool an_ = al_ is CqlInterval<CqlDateTime>;
                        if (an_)
                        {
                            x_ = al_ as CqlInterval<CqlDateTime>;
                        }
                        else
                        {
                            x_ = null;
                        }
                    }
                }
                CqlDateTime y_ = QICoreCommon_4_0_000.Instance.earliest(context, x_);
                CqlInterval<CqlDateTime> z_ = CQMCommon_4_1_000.Instance.hospitalizationWithObservationAndOutpatientSurgeryService(context, EncounterInpatient);
                CqlBoolean aa_ = context.Operators.In<CqlDateTime>(y_, z_, (string)default);
                Code<ObservationStatus> ab_ = SodiumLab?.StatusElement;
                ObservationStatus? ac_ = ab_?.Value;
                string ad_ = context.Operators.Convert<string>(ac_);
                string[] ae_ = [
                    "final",
                    "amended",
                    "corrected",
                ];
                CqlBoolean af_ = context.Operators.In<string>(ad_, (IEnumerable<string>)ae_);
                CqlBoolean ag_ = af_;
                DataType ah_ = SodiumLab?.Value;
                object ai_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ah_);
                CqlBoolean aj_ = (CqlBoolean)(ai_ is not null);
                return aa_
                    /* CQL 'and' (162:15-163:69) */ && ag_
                    /* CQL 'and' (162:9-164:41) */ && aj_;
            }

            IEnumerable<Observation> i_ = context.Operators.Where<Observation>(g_, h_);

            object j_(Observation @this) {
                Instant ao_ = @this?.IssuedElement;
                DateTimeOffset? ap_ = ao_?.Value;
                CqlDateTime aq_ = context.Operators.Convert<CqlDateTime>(ap_);
                CqlDateTime ar_ = QICoreCommon_4_0_000.Instance.earliest(context, aq_);
                return ar_;
            }

            IEnumerable<Observation> k_ = context.Operators.SortBy<Observation>(i_, j_, System.ComponentModel.ListSortDirection.Ascending);
            Observation l_ = context.Operators.First<Observation>(k_);
            DataType m_ = l_?.Value;
            object n_ = FHIRHelpers_4_4_000.Instance.ToValue(context, m_);

            bool? o_(Observation SodiumLab) {
                object as_;
                DataType bf_ = SodiumLab?.Effective;
                object bg_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bf_);
                bool bh_ = bg_ is CqlDateTime;
                if (bh_)
                {
                    as_ = bg_ as CqlDateTime;
                }
                else
                {
                    if (bh_)
                    {
                        as_ = bg_ as CqlDateTime;
                    }
                    else
                    {
                        bool bi_ = bg_ is CqlInterval<CqlDateTime>;
                        if (bi_)
                        {
                            as_ = bg_ as CqlInterval<CqlDateTime>;
                        }
                        else
                        {
                            as_ = null;
                        }
                    }
                }
                CqlDateTime at_ = QICoreCommon_4_0_000.Instance.earliest(context, as_);
                CqlInterval<CqlDateTime> au_ = CQMCommon_4_1_000.Instance.hospitalizationWithObservationAndOutpatientSurgeryService(context, EncounterInpatient);
                CqlBoolean av_ = context.Operators.In<CqlDateTime>(at_, au_, (string)default);
                Code<ObservationStatus> aw_ = SodiumLab?.StatusElement;
                ObservationStatus? ax_ = aw_?.Value;
                string ay_ = context.Operators.Convert<string>(ax_);
                string[] az_ = [
                    "final",
                    "amended",
                    "corrected",
                ];
                CqlBoolean ba_ = context.Operators.In<string>(ay_, (IEnumerable<string>)az_);
                CqlBoolean bb_ = ba_;
                DataType bc_ = SodiumLab?.Value;
                object bd_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bc_);
                CqlBoolean be_ = (CqlBoolean)(bd_ is not null);
                return av_
                    /* CQL 'and' (162:15-163:69) */ && bb_
                    /* CQL 'and' (162:9-164:41) */ && be_;
            }

            IEnumerable<Observation> p_ = context.Operators.Where<Observation>(g_, o_);

            object q_(Observation @this) {
                Instant bj_ = @this?.IssuedElement;
                DateTimeOffset? bk_ = bj_?.Value;
                CqlDateTime bl_ = context.Operators.Convert<CqlDateTime>(bk_);
                CqlDateTime bm_ = QICoreCommon_4_0_000.Instance.earliest(context, bl_);
                return bm_;
            }

            IEnumerable<Observation> r_ = context.Operators.SortBy<Observation>(p_, q_, System.ComponentModel.ListSortDirection.Ascending);
            Observation s_ = context.Operators.First<Observation>(r_);
            Instant t_ = s_?.IssuedElement;
            DateTimeOffset? u_ = t_?.Value;
            CqlDateTime v_ = context.Operators.Convert<CqlDateTime>(u_);
            (CqlTupleMetadata, string EncounterId, CqlQuantity FirstSodiumResult, CqlDateTime Timing)? w_ = (CqlTupleMetadata_GKGeLARADLGJcNcZaDhdCREMa, e_, n_ as CqlQuantity, v_);
            return w_;
        }

        IEnumerable<(CqlTupleMetadata, string EncounterId, CqlQuantity FirstSodiumResult, CqlDateTime Timing)?> c_ = context.Operators.SelectDistinct<Encounter, (CqlTupleMetadata, string EncounterId, CqlQuantity FirstSodiumResult, CqlDateTime Timing)?>(a_, b_);
        return c_;
    }


    [CqlExpressionDefinition("SDE Encounter With First White Blood Cells Lab Test")]
    public IEnumerable<(CqlTupleMetadata, string EncounterId, CqlQuantity FirstWhiteBloodCellResult, CqlDateTime Timing)?> SDE_Encounter_With_First_White_Blood_Cells_Lab_Test(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_SDE_Encounter_With_First_White_Blood_Cells_Lab_Test, SDE_Encounter_With_First_White_Blood_Cells_Lab_Test_Compute);

    private const long _cacheIndex_SDE_Encounter_With_First_White_Blood_Cells_Lab_Test = -5465861473556378136L;

    private IEnumerable<(CqlTupleMetadata, string EncounterId, CqlQuantity FirstWhiteBloodCellResult, CqlDateTime Timing)?> SDE_Encounter_With_First_White_Blood_Cells_Lab_Test_Compute(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Inpatient_Encounters(context);

        (CqlTupleMetadata, string EncounterId, CqlQuantity FirstWhiteBloodCellResult, CqlDateTime Timing)? b_(Encounter EncounterInpatient) {
            Id d_ = EncounterInpatient?.IdElement;
            string e_ = d_?.Value;
            CqlValueSet f_ = this.White_blood_cells_count_lab_test(context);
            IEnumerable<Observation> g_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, f_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation-lab"));

            bool? h_(Observation WhiteBloodCellLab) {
                object x_;
                DataType ak_ = WhiteBloodCellLab?.Effective;
                object al_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ak_);
                bool am_ = al_ is CqlDateTime;
                if (am_)
                {
                    x_ = al_ as CqlDateTime;
                }
                else
                {
                    if (am_)
                    {
                        x_ = al_ as CqlDateTime;
                    }
                    else
                    {
                        bool an_ = al_ is CqlInterval<CqlDateTime>;
                        if (an_)
                        {
                            x_ = al_ as CqlInterval<CqlDateTime>;
                        }
                        else
                        {
                            x_ = null;
                        }
                    }
                }
                CqlDateTime y_ = QICoreCommon_4_0_000.Instance.earliest(context, x_);
                CqlInterval<CqlDateTime> z_ = CQMCommon_4_1_000.Instance.hospitalizationWithObservationAndOutpatientSurgeryService(context, EncounterInpatient);
                CqlBoolean aa_ = context.Operators.In<CqlDateTime>(y_, z_, (string)default);
                Code<ObservationStatus> ab_ = WhiteBloodCellLab?.StatusElement;
                ObservationStatus? ac_ = ab_?.Value;
                string ad_ = context.Operators.Convert<string>(ac_);
                string[] ae_ = [
                    "final",
                    "amended",
                    "corrected",
                ];
                CqlBoolean af_ = context.Operators.In<string>(ad_, (IEnumerable<string>)ae_);
                CqlBoolean ag_ = af_;
                DataType ah_ = WhiteBloodCellLab?.Value;
                object ai_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ah_);
                CqlBoolean aj_ = (CqlBoolean)(ai_ is not null);
                return aa_
                    /* CQL 'and' (176:15-177:77) */ && ag_
                    /* CQL 'and' (176:9-178:49) */ && aj_;
            }

            IEnumerable<Observation> i_ = context.Operators.Where<Observation>(g_, h_);

            object j_(Observation @this) {
                Instant ao_ = @this?.IssuedElement;
                DateTimeOffset? ap_ = ao_?.Value;
                CqlDateTime aq_ = context.Operators.Convert<CqlDateTime>(ap_);
                CqlDateTime ar_ = QICoreCommon_4_0_000.Instance.earliest(context, aq_);
                return ar_;
            }

            IEnumerable<Observation> k_ = context.Operators.SortBy<Observation>(i_, j_, System.ComponentModel.ListSortDirection.Ascending);
            Observation l_ = context.Operators.First<Observation>(k_);
            DataType m_ = l_?.Value;
            object n_ = FHIRHelpers_4_4_000.Instance.ToValue(context, m_);

            bool? o_(Observation WhiteBloodCellLab) {
                object as_;
                DataType bf_ = WhiteBloodCellLab?.Effective;
                object bg_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bf_);
                bool bh_ = bg_ is CqlDateTime;
                if (bh_)
                {
                    as_ = bg_ as CqlDateTime;
                }
                else
                {
                    if (bh_)
                    {
                        as_ = bg_ as CqlDateTime;
                    }
                    else
                    {
                        bool bi_ = bg_ is CqlInterval<CqlDateTime>;
                        if (bi_)
                        {
                            as_ = bg_ as CqlInterval<CqlDateTime>;
                        }
                        else
                        {
                            as_ = null;
                        }
                    }
                }
                CqlDateTime at_ = QICoreCommon_4_0_000.Instance.earliest(context, as_);
                CqlInterval<CqlDateTime> au_ = CQMCommon_4_1_000.Instance.hospitalizationWithObservationAndOutpatientSurgeryService(context, EncounterInpatient);
                CqlBoolean av_ = context.Operators.In<CqlDateTime>(at_, au_, (string)default);
                Code<ObservationStatus> aw_ = WhiteBloodCellLab?.StatusElement;
                ObservationStatus? ax_ = aw_?.Value;
                string ay_ = context.Operators.Convert<string>(ax_);
                string[] az_ = [
                    "final",
                    "amended",
                    "corrected",
                ];
                CqlBoolean ba_ = context.Operators.In<string>(ay_, (IEnumerable<string>)az_);
                CqlBoolean bb_ = ba_;
                DataType bc_ = WhiteBloodCellLab?.Value;
                object bd_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bc_);
                CqlBoolean be_ = (CqlBoolean)(bd_ is not null);
                return av_
                    /* CQL 'and' (176:15-177:77) */ && bb_
                    /* CQL 'and' (176:9-178:49) */ && be_;
            }

            IEnumerable<Observation> p_ = context.Operators.Where<Observation>(g_, o_);

            object q_(Observation @this) {
                Instant bj_ = @this?.IssuedElement;
                DateTimeOffset? bk_ = bj_?.Value;
                CqlDateTime bl_ = context.Operators.Convert<CqlDateTime>(bk_);
                CqlDateTime bm_ = QICoreCommon_4_0_000.Instance.earliest(context, bl_);
                return bm_;
            }

            IEnumerable<Observation> r_ = context.Operators.SortBy<Observation>(p_, q_, System.ComponentModel.ListSortDirection.Ascending);
            Observation s_ = context.Operators.First<Observation>(r_);
            Instant t_ = s_?.IssuedElement;
            DateTimeOffset? u_ = t_?.Value;
            CqlDateTime v_ = context.Operators.Convert<CqlDateTime>(u_);
            (CqlTupleMetadata, string EncounterId, CqlQuantity FirstWhiteBloodCellResult, CqlDateTime Timing)? w_ = (CqlTupleMetadata_ChVYCdXDGgVcFTCCUefXMbCHX, e_, n_ as CqlQuantity, v_);
            return w_;
        }

        IEnumerable<(CqlTupleMetadata, string EncounterId, CqlQuantity FirstWhiteBloodCellResult, CqlDateTime Timing)?> c_ = context.Operators.SelectDistinct<Encounter, (CqlTupleMetadata, string EncounterId, CqlQuantity FirstWhiteBloodCellResult, CqlDateTime Timing)?>(a_, b_);
        return c_;
    }


    [CqlExpressionDefinition("SDE Encounter With Oxygen 60 Minutes Or Less Prior To ED Admission Or During ED")]
    public IEnumerable<Encounter> SDE_Encounter_With_Oxygen_60_Minutes_Or_Less_Prior_To_ED_Admission_Or_During_ED(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_SDE_Encounter_With_Oxygen_60_Minutes_Or_Less_Prior_To_ED_Admission_Or_During_ED, SDE_Encounter_With_Oxygen_60_Minutes_Or_Less_Prior_To_ED_Admission_Or_During_ED_Compute);

    private const long _cacheIndex_SDE_Encounter_With_Oxygen_60_Minutes_Or_Less_Prior_To_ED_Admission_Or_During_ED = 3300392010812223033L;

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
                FhirDateTime u_ = OxygenTherapyOrder?.AuthoredOnElement;
                CqlDateTime v_ = context.Operators.Convert<CqlDateTime>(u_);
                Encounter w_ = CQMCommon_4_1_000.Instance.edVisit(context, EncounterInpatient);
                Period x_ = w_?.Period;
                CqlInterval<CqlDateTime> y_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, x_);
                CqlBoolean z_ = context.Operators.In<CqlDateTime>(v_, y_, (string)default);
                CqlDateTime aa_ = context.Operators.Start(y_);
                CqlQuantity ab_ = context.Operators.Quantity(60m, "minutes");
                CqlDateTime ac_ = context.Operators.Subtract(aa_, ab_);
                CqlInterval<CqlDateTime> ad_ = context.Operators.Interval(ac_, aa_, true, true);
                CqlBoolean ae_ = context.Operators.In<CqlDateTime>(v_, ad_, (string)default);
                CqlBoolean af_ = (CqlBoolean)(aa_ is not null);
                CqlBoolean ag_ = ae_
                    /* CQL 'and' (192:16-192:123) */ && af_;
                Code<RequestStatus> ah_ = OxygenTherapyOrder?.StatusElement;
                RequestStatus? ai_ = ah_?.Value;
                Code<RequestStatus> aj_ = context.Operators.Convert<Code<RequestStatus>>(ai_);
                string ak_ = context.Operators.Convert<string>(aj_);
                string[] al_ = [
                    "active",
                    "completed",
                ];
                CqlBoolean am_ = context.Operators.In<string>(ak_, (IEnumerable<string>)al_);
                CqlBoolean an_ = am_;
                Code<RequestIntent> ao_ = OxygenTherapyOrder?.IntentElement;
                RequestIntent? ap_ = ao_?.Value;
                Code<RequestIntent> aq_ = context.Operators.Convert<Code<RequestIntent>>(ap_);
                CqlBoolean ar_ = context.Operators.Equal(aq_, "order");
                CqlBoolean as_ = ar_;
                return (z_
                    /* CQL 'or' (191:15-193:9) */ || ag_)
                    /* CQL 'and' (191:15-194:68) */ && an_
                    /* CQL 'and' (191:9-195:49) */ && as_;
            }


            (CqlTupleMetadata, string EncounterId, Code<RequestStatus> OrderStatus, CqlDateTime OrderTiming)? j_(ServiceRequest OxygenTherapyOrder) {
                Id at_ = EncounterInpatient?.IdElement;
                string au_ = at_?.Value;
                Code<RequestStatus> av_ = OxygenTherapyOrder?.StatusElement;
                RequestStatus? aw_ = av_?.Value;
                Code<RequestStatus> ax_ = context.Operators.Convert<Code<RequestStatus>>(aw_);
                FhirDateTime ay_ = OxygenTherapyOrder?.AuthoredOnElement;
                CqlDateTime az_ = context.Operators.Convert<CqlDateTime>(ay_);
                (CqlTupleMetadata, string EncounterId, Code<RequestStatus> OrderStatus, CqlDateTime OrderTiming)? ba_ = (CqlTupleMetadata_BTRiFTXPQGKeiLWUSieghMWCU, au_, ax_, az_);
                return ba_;
            }

            IEnumerable<(CqlTupleMetadata, string EncounterId, Code<RequestStatus> OrderStatus, CqlDateTime OrderTiming)?> k_ = context.Operators.WhereSelect<ServiceRequest, (CqlTupleMetadata, string EncounterId, Code<RequestStatus> OrderStatus, CqlDateTime OrderTiming)?>(h_, i_, j_);
            IEnumerable<(CqlTupleMetadata, string EncounterId, Code<RequestStatus> OrderStatus, CqlDateTime OrderTiming)?> l_ = context.Operators.Distinct<(CqlTupleMetadata, string EncounterId, Code<RequestStatus> OrderStatus, CqlDateTime OrderTiming)?>(k_);
            CqlBoolean m_ = context.Operators.Exists<(CqlTupleMetadata, string EncounterId, Code<RequestStatus> OrderStatus, CqlDateTime OrderTiming)?>(l_);
            IEnumerable<Procedure> n_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, d_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));

            bool? o_(Procedure OxygenAdminInterv) {
                object bb_;
                DataType bx_ = OxygenAdminInterv?.Performed;
                object by_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bx_);
                bool bz_ = by_ is CqlDateTime;
                if (bz_)
                {
                    bb_ = by_ as CqlDateTime;
                }
                else
                {
                    bool ca_ = by_ is CqlQuantity;
                    if (ca_)
                    {
                        bb_ = by_ as CqlQuantity;
                    }
                    else
                    {
                        bool cb_ = by_ is CqlInterval<CqlDateTime>;
                        if (cb_)
                        {
                            bb_ = by_ as CqlInterval<CqlDateTime>;
                        }
                        else
                        {
                            bool cc_ = by_ is CqlInterval<CqlQuantity>;
                            if (cc_)
                            {
                                bb_ = by_ as CqlInterval<CqlQuantity>;
                            }
                            else
                            {
                                bb_ = null;
                            }
                        }
                    }
                }
                CqlInterval<CqlDateTime> bc_ = QICoreCommon_4_0_000.Instance.toInterval(context, bb_);
                CqlDateTime bd_ = context.Operators.Start(bc_);
                Encounter be_ = CQMCommon_4_1_000.Instance.edVisit(context, EncounterInpatient);
                Period bf_ = be_?.Period;
                CqlInterval<CqlDateTime> bg_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, bf_);
                CqlBoolean bh_ = context.Operators.In<CqlDateTime>(bd_, bg_, (string)default);
                object bi_;
                DataType cd_ = OxygenAdminInterv?.Performed;
                object ce_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cd_);
                bool cf_ = ce_ is CqlDateTime;
                if (cf_)
                {
                    bi_ = ce_ as CqlDateTime;
                }
                else
                {
                    bool cg_ = ce_ is CqlQuantity;
                    if (cg_)
                    {
                        bi_ = ce_ as CqlQuantity;
                    }
                    else
                    {
                        bool ch_ = ce_ is CqlInterval<CqlDateTime>;
                        if (ch_)
                        {
                            bi_ = ce_ as CqlInterval<CqlDateTime>;
                        }
                        else
                        {
                            bool ci_ = ce_ is CqlInterval<CqlQuantity>;
                            if (ci_)
                            {
                                bi_ = ce_ as CqlInterval<CqlQuantity>;
                            }
                            else
                            {
                                bi_ = null;
                            }
                        }
                    }
                }
                CqlInterval<CqlDateTime> bj_ = QICoreCommon_4_0_000.Instance.toInterval(context, bi_);
                CqlDateTime bk_ = context.Operators.End(bj_);
                CqlDateTime bl_ = context.Operators.Start(bg_);
                CqlQuantity bm_ = context.Operators.Quantity(60m, "minutes");
                CqlDateTime bn_ = context.Operators.Subtract(bl_, bm_);
                CqlInterval<CqlDateTime> bo_ = context.Operators.Interval(bn_, bl_, true, true);
                CqlBoolean bp_ = context.Operators.In<CqlDateTime>(bk_, bo_, (string)default);
                CqlBoolean bq_ = (CqlBoolean)(bl_ is not null);
                CqlBoolean br_ = bp_
                    /* CQL 'and' (204:18-204:138) */ && bq_;
                Code<EventStatus> bs_ = OxygenAdminInterv?.StatusElement;
                EventStatus? bt_ = bs_?.Value;
                string bu_ = context.Operators.Convert<string>(bt_);
                CqlBoolean bv_ = context.Operators.Equal(bu_, "completed");
                CqlBoolean bw_ = bv_;
                return (bh_
                    /* CQL 'or' (203:17-205:11) */ || br_)
                    /* CQL 'and' (203:11-206:54) */ && bw_;
            }


            (CqlTupleMetadata, string EncounterId, CqlInterval<CqlDateTime> EDEncounterTiming, string PerformedStatus, CqlInterval<CqlDateTime> PerformedTiming)? p_(Procedure OxygenAdminInterv) {
                Id cj_ = EncounterInpatient?.IdElement;
                string ck_ = cj_?.Value;
                Encounter cl_ = CQMCommon_4_1_000.Instance.edVisit(context, EncounterInpatient);
                Period cm_ = cl_?.Period;
                CqlInterval<CqlDateTime> cn_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, cm_);
                Code<EventStatus> co_ = OxygenAdminInterv?.StatusElement;
                EventStatus? cp_ = co_?.Value;
                string cq_ = context.Operators.Convert<string>(cp_);
                object cr_;
                DataType cu_ = OxygenAdminInterv?.Performed;
                object cv_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cu_);
                bool cw_ = cv_ is CqlDateTime;
                if (cw_)
                {
                    cr_ = cv_ as CqlDateTime;
                }
                else
                {
                    bool cx_ = cv_ is CqlQuantity;
                    if (cx_)
                    {
                        cr_ = cv_ as CqlQuantity;
                    }
                    else
                    {
                        bool cy_ = cv_ is CqlInterval<CqlDateTime>;
                        if (cy_)
                        {
                            cr_ = cv_ as CqlInterval<CqlDateTime>;
                        }
                        else
                        {
                            bool cz_ = cv_ is CqlInterval<CqlQuantity>;
                            if (cz_)
                            {
                                cr_ = cv_ as CqlInterval<CqlQuantity>;
                            }
                            else
                            {
                                cr_ = null;
                            }
                        }
                    }
                }
                CqlInterval<CqlDateTime> cs_ = QICoreCommon_4_0_000.Instance.toInterval(context, cr_);
                (CqlTupleMetadata, string EncounterId, CqlInterval<CqlDateTime> EDEncounterTiming, string PerformedStatus, CqlInterval<CqlDateTime> PerformedTiming)? ct_ = (CqlTupleMetadata_HBSiHLDibCXHQcPZYMVBgXBIH, ck_, cn_, cq_, cs_);
                return ct_;
            }

            IEnumerable<(CqlTupleMetadata, string EncounterId, CqlInterval<CqlDateTime> EDEncounterTiming, string PerformedStatus, CqlInterval<CqlDateTime> PerformedTiming)?> q_ = context.Operators.WhereSelect<Procedure, (CqlTupleMetadata, string EncounterId, CqlInterval<CqlDateTime> EDEncounterTiming, string PerformedStatus, CqlInterval<CqlDateTime> PerformedTiming)?>(n_, o_, p_);
            IEnumerable<(CqlTupleMetadata, string EncounterId, CqlInterval<CqlDateTime> EDEncounterTiming, string PerformedStatus, CqlInterval<CqlDateTime> PerformedTiming)?> r_ = context.Operators.Distinct<(CqlTupleMetadata, string EncounterId, CqlInterval<CqlDateTime> EDEncounterTiming, string PerformedStatus, CqlInterval<CqlDateTime> PerformedTiming)?>(q_);
            CqlBoolean s_ = context.Operators.Exists<(CqlTupleMetadata, string EncounterId, CqlInterval<CqlDateTime> EDEncounterTiming, string PerformedStatus, CqlInterval<CqlDateTime> PerformedTiming)?>(r_);
            CqlBoolean t_ = s_;
            return m_
                /* CQL 'or' (189:5-213:7) */ || t_;
        }

        IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);
        return c_;
    }


    [CqlExpressionDefinition("SDE Ethnicity")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Ethnicity(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_SDE_Ethnicity, SDE_Ethnicity_Compute);

    private const long _cacheIndex_SDE_Ethnicity = -1728215249426117575L;

    private (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Ethnicity_Compute(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? a_ = SupplementalDataElements_5_1_000.Instance.SDE_Ethnicity(context);
        return a_;
    }


    [CqlExpressionDefinition("SDE Payer")]
    public IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> SDE_Payer(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_SDE_Payer, SDE_Payer_Compute);

    private const long _cacheIndex_SDE_Payer = 5599464314516997004L;

    private IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> SDE_Payer_Compute(CqlContext context)
    {
        IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> a_ = SupplementalDataElements_5_1_000.Instance.SDE_Payer(context);
        return a_;
    }


    [CqlExpressionDefinition("SDE Race")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Race(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_SDE_Race, SDE_Race_Compute);

    private const long _cacheIndex_SDE_Race = 6826702992571169488L;

    private (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Race_Compute(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? a_ = SupplementalDataElements_5_1_000.Instance.SDE_Race(context);
        return a_;
    }


    [CqlExpressionDefinition("SDE Sex")]
    public CqlCode SDE_Sex(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_SDE_Sex, SDE_Sex_Compute);

    private const long _cacheIndex_SDE_Sex = 6983970667873048157L;

    private CqlCode SDE_Sex_Compute(CqlContext context)
    {
        CqlCode a_ = SupplementalDataElements_5_1_000.Instance.SDE_Sex(context);
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

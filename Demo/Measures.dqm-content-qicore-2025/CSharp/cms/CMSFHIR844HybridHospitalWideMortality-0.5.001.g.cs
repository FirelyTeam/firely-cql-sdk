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
                CqlInterval<CqlDateTime> m_ = CQMCommon_4_1_000.Instance.hospitalizationWithObservationAndOutpatientSurgeryService(context, EncounterInpatient);
                int? n_ = CQMCommon_4_1_000.Instance.lengthInDays(context, m_);
                bool? o_ = context.Operators.Less(n_, 365);
                Code<Encounter.EncounterStatus> p_ = EncounterInpatient?.StatusElement;
                Encounter.EncounterStatus? q_ = p_?.Value;
                Code<Encounter.EncounterStatus> r_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(q_);
                bool? s_ = context.Operators.Equal(r_, "finished");
                bool? t_ = context.Operators.And(o_, s_);
                Patient u_ = this.Patient(context);
                Date v_ = u_?.BirthDateElement;
                string w_ = v_?.Value;
                CqlDate x_ = context.Operators.ConvertStringToDate(w_);
                Period y_ = EncounterInpatient?.Period;
                CqlInterval<CqlDateTime> z_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, y_);
                CqlDateTime aa_ = context.Operators.Start(z_);
                CqlDate ab_ = context.Operators.DateFrom(aa_);
                int? ac_ = context.Operators.CalculateAgeAt(x_, ab_, "year");
                CqlInterval<int?> ad_ = context.Operators.Interval(65, 94, true, true);
                bool? ae_ = context.Operators.In<int?>(ac_, ad_, (string)default);
                bool? af_ = context.Operators.And(t_, ae_);
                CqlDateTime ag_ = context.Operators.End(z_);
                CqlInterval<CqlDateTime> ah_ = this.Measurement_Period(context);
                bool? ai_ = context.Operators.In<CqlDateTime>(ag_, ah_, "day");
                bool? aj_ = context.Operators.And(af_, ai_);
                return aj_;
            }

            IEnumerable<Coverage> k_ = context.Operators.Where<Coverage>(i_, j_);
            bool? l_ = context.Operators.Exists<Coverage>(k_);
            return l_;
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
            Id e_ = EncounterInpatient?.IdElement;
            string f_ = e_?.Value;
            IEnumerable<Observation> g_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/core/StructureDefinition/us-core-body-temperature"));

            bool? h_(Observation Temperature) {
                DataType x_ = Temperature?.Effective;
                object y_ = FHIRHelpers_4_4_000.Instance.ToValue(context, x_);
                CqlDateTime z_ = QICoreCommon_4_0_000.Instance.earliest(context, y_);
                CqlInterval<CqlDateTime> aa_ = CQMCommon_4_1_000.Instance.hospitalizationWithObservationAndOutpatientSurgeryService(context, EncounterInpatient);
                bool? ab_ = context.Operators.In<CqlDateTime>(z_, aa_, (string)default);
                Code<ObservationStatus> ac_ = Temperature?.StatusElement;
                ObservationStatus? ad_ = ac_?.Value;
                string ae_ = context.Operators.Convert<string>(ad_);
                string[] af_ = [
                    "final",
                    "amended",
                    "corrected",
                ];
                bool? ag_ = context.Operators.In<string>(ae_, (IEnumerable<string>)af_);
                bool? ah_ = context.Operators.And(ab_, ag_);
                DataType ai_ = Temperature?.Value;
                CqlQuantity aj_ = FHIRHelpers_4_4_000.Instance.ToQuantity(context, ai_ as Quantity);
                bool? ak_ = context.Operators.Not((bool?)(aj_ is null));
                bool? al_ = context.Operators.And(ah_, ak_);
                return al_;
            }

            IEnumerable<Observation> i_ = context.Operators.Where<Observation>(g_, h_);

            object j_(Observation @this) {
                DataType am_ = @this?.Effective;
                object an_ = FHIRHelpers_4_4_000.Instance.ToValue(context, am_);
                CqlDateTime ao_ = QICoreCommon_4_0_000.Instance.earliest(context, an_);
                return ao_;
            }

            IEnumerable<Observation> k_ = context.Operators.SortBy<Observation>(i_, j_, System.ComponentModel.ListSortDirection.Ascending);
            Observation l_ = context.Operators.First<Observation>(k_);
            DataType m_ = l_?.Value;
            CqlQuantity n_ = FHIRHelpers_4_4_000.Instance.ToQuantity(context, m_ as Quantity);

            bool? o_(Observation Temperature) {
                DataType ap_ = Temperature?.Effective;
                object aq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ap_);
                CqlDateTime ar_ = QICoreCommon_4_0_000.Instance.earliest(context, aq_);
                CqlInterval<CqlDateTime> as_ = CQMCommon_4_1_000.Instance.hospitalizationWithObservationAndOutpatientSurgeryService(context, EncounterInpatient);
                bool? at_ = context.Operators.In<CqlDateTime>(ar_, as_, (string)default);
                Code<ObservationStatus> au_ = Temperature?.StatusElement;
                ObservationStatus? av_ = au_?.Value;
                string aw_ = context.Operators.Convert<string>(av_);
                string[] ax_ = [
                    "final",
                    "amended",
                    "corrected",
                ];
                bool? ay_ = context.Operators.In<string>(aw_, (IEnumerable<string>)ax_);
                bool? az_ = context.Operators.And(at_, ay_);
                DataType ba_ = Temperature?.Value;
                CqlQuantity bb_ = FHIRHelpers_4_4_000.Instance.ToQuantity(context, ba_ as Quantity);
                bool? bc_ = context.Operators.Not((bool?)(bb_ is null));
                bool? bd_ = context.Operators.And(az_, bc_);
                return bd_;
            }

            IEnumerable<Observation> p_ = context.Operators.Where<Observation>(g_, o_);

            object q_(Observation @this) {
                DataType be_ = @this?.Effective;
                object bf_ = FHIRHelpers_4_4_000.Instance.ToValue(context, be_);
                CqlDateTime bg_ = QICoreCommon_4_0_000.Instance.earliest(context, bf_);
                return bg_;
            }

            IEnumerable<Observation> r_ = context.Operators.SortBy<Observation>(p_, q_, System.ComponentModel.ListSortDirection.Ascending);
            Observation s_ = context.Operators.First<Observation>(r_);
            DataType t_ = s_?.Effective;
            object u_ = FHIRHelpers_4_4_000.Instance.ToValue(context, t_);
            CqlDateTime v_ = QICoreCommon_4_0_000.Instance.earliest(context, u_);
            (CqlTupleMetadata, string EncounterId, CqlQuantity FirstTemperatureResult, CqlDateTime Timing)? w_ = (CqlTupleMetadata_GIbILVAdXLLNYBgcQIEiUiKaK, f_, n_ as CqlQuantity, v_);
            return w_;
        }

        IEnumerable<(CqlTupleMetadata, string EncounterId, CqlQuantity FirstTemperatureResult, CqlDateTime Timing)?> c_ = context.Operators.Select<Encounter, (CqlTupleMetadata, string EncounterId, CqlQuantity FirstTemperatureResult, CqlDateTime Timing)?>(a_, b_);
        IEnumerable<(CqlTupleMetadata, string EncounterId, CqlQuantity FirstTemperatureResult, CqlDateTime Timing)?> d_ = context.Operators.Distinct<(CqlTupleMetadata, string EncounterId, CqlQuantity FirstTemperatureResult, CqlDateTime Timing)?>(c_);
        return d_;
    }


    [CqlExpressionDefinition("SDE Encounter With First Heart Rate")]
    public IEnumerable<(CqlTupleMetadata, string EncounterId, CqlQuantity FirstHeartRateResult, CqlDateTime Timing)?> SDE_Encounter_With_First_Heart_Rate(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_SDE_Encounter_With_First_Heart_Rate, SDE_Encounter_With_First_Heart_Rate_Compute);

    private const long _cacheIndex_SDE_Encounter_With_First_Heart_Rate = 139345589104903829L;

    private IEnumerable<(CqlTupleMetadata, string EncounterId, CqlQuantity FirstHeartRateResult, CqlDateTime Timing)?> SDE_Encounter_With_First_Heart_Rate_Compute(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Inpatient_Encounters(context);

        (CqlTupleMetadata, string EncounterId, CqlQuantity FirstHeartRateResult, CqlDateTime Timing)? b_(Encounter EncounterInpatient) {
            Id e_ = EncounterInpatient?.IdElement;
            string f_ = e_?.Value;
            IEnumerable<Observation> g_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/core/StructureDefinition/us-core-heart-rate"));

            bool? h_(Observation HeartRate) {
                DataType x_ = HeartRate?.Effective;
                object y_ = FHIRHelpers_4_4_000.Instance.ToValue(context, x_);
                CqlDateTime z_ = QICoreCommon_4_0_000.Instance.earliest(context, y_);
                CqlInterval<CqlDateTime> aa_ = CQMCommon_4_1_000.Instance.hospitalizationWithObservationAndOutpatientSurgeryService(context, EncounterInpatient);
                bool? ab_ = context.Operators.In<CqlDateTime>(z_, aa_, (string)default);
                Code<ObservationStatus> ac_ = HeartRate?.StatusElement;
                ObservationStatus? ad_ = ac_?.Value;
                string ae_ = context.Operators.Convert<string>(ad_);
                string[] af_ = [
                    "final",
                    "amended",
                    "corrected",
                ];
                bool? ag_ = context.Operators.In<string>(ae_, (IEnumerable<string>)af_);
                bool? ah_ = context.Operators.And(ab_, ag_);
                DataType ai_ = HeartRate?.Value;
                CqlQuantity aj_ = FHIRHelpers_4_4_000.Instance.ToQuantity(context, ai_ as Quantity);
                bool? ak_ = context.Operators.Not((bool?)(aj_ is null));
                bool? al_ = context.Operators.And(ah_, ak_);
                return al_;
            }

            IEnumerable<Observation> i_ = context.Operators.Where<Observation>(g_, h_);

            object j_(Observation @this) {
                DataType am_ = @this?.Effective;
                object an_ = FHIRHelpers_4_4_000.Instance.ToValue(context, am_);
                CqlDateTime ao_ = QICoreCommon_4_0_000.Instance.earliest(context, an_);
                return ao_;
            }

            IEnumerable<Observation> k_ = context.Operators.SortBy<Observation>(i_, j_, System.ComponentModel.ListSortDirection.Ascending);
            Observation l_ = context.Operators.First<Observation>(k_);
            DataType m_ = l_?.Value;
            CqlQuantity n_ = FHIRHelpers_4_4_000.Instance.ToQuantity(context, m_ as Quantity);

            bool? o_(Observation HeartRate) {
                DataType ap_ = HeartRate?.Effective;
                object aq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ap_);
                CqlDateTime ar_ = QICoreCommon_4_0_000.Instance.earliest(context, aq_);
                CqlInterval<CqlDateTime> as_ = CQMCommon_4_1_000.Instance.hospitalizationWithObservationAndOutpatientSurgeryService(context, EncounterInpatient);
                bool? at_ = context.Operators.In<CqlDateTime>(ar_, as_, (string)default);
                Code<ObservationStatus> au_ = HeartRate?.StatusElement;
                ObservationStatus? av_ = au_?.Value;
                string aw_ = context.Operators.Convert<string>(av_);
                string[] ax_ = [
                    "final",
                    "amended",
                    "corrected",
                ];
                bool? ay_ = context.Operators.In<string>(aw_, (IEnumerable<string>)ax_);
                bool? az_ = context.Operators.And(at_, ay_);
                DataType ba_ = HeartRate?.Value;
                CqlQuantity bb_ = FHIRHelpers_4_4_000.Instance.ToQuantity(context, ba_ as Quantity);
                bool? bc_ = context.Operators.Not((bool?)(bb_ is null));
                bool? bd_ = context.Operators.And(az_, bc_);
                return bd_;
            }

            IEnumerable<Observation> p_ = context.Operators.Where<Observation>(g_, o_);

            object q_(Observation @this) {
                DataType be_ = @this?.Effective;
                object bf_ = FHIRHelpers_4_4_000.Instance.ToValue(context, be_);
                CqlDateTime bg_ = QICoreCommon_4_0_000.Instance.earliest(context, bf_);
                return bg_;
            }

            IEnumerable<Observation> r_ = context.Operators.SortBy<Observation>(p_, q_, System.ComponentModel.ListSortDirection.Ascending);
            Observation s_ = context.Operators.First<Observation>(r_);
            DataType t_ = s_?.Effective;
            object u_ = FHIRHelpers_4_4_000.Instance.ToValue(context, t_);
            CqlDateTime v_ = QICoreCommon_4_0_000.Instance.earliest(context, u_);
            (CqlTupleMetadata, string EncounterId, CqlQuantity FirstHeartRateResult, CqlDateTime Timing)? w_ = (CqlTupleMetadata_DhbJAfCiKIAGYKTjJXYGSKECQ, f_, n_ as CqlQuantity, v_);
            return w_;
        }

        IEnumerable<(CqlTupleMetadata, string EncounterId, CqlQuantity FirstHeartRateResult, CqlDateTime Timing)?> c_ = context.Operators.Select<Encounter, (CqlTupleMetadata, string EncounterId, CqlQuantity FirstHeartRateResult, CqlDateTime Timing)?>(a_, b_);
        IEnumerable<(CqlTupleMetadata, string EncounterId, CqlQuantity FirstHeartRateResult, CqlDateTime Timing)?> d_ = context.Operators.Distinct<(CqlTupleMetadata, string EncounterId, CqlQuantity FirstHeartRateResult, CqlDateTime Timing)?>(c_);
        return d_;
    }


    [CqlExpressionDefinition("SDE Encounter With First Oxygen Saturation")]
    public IEnumerable<(CqlTupleMetadata, string EncounterId, CqlQuantity FirstOxygenSatResult, CqlDateTime Timing)?> SDE_Encounter_With_First_Oxygen_Saturation(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_SDE_Encounter_With_First_Oxygen_Saturation, SDE_Encounter_With_First_Oxygen_Saturation_Compute);

    private const long _cacheIndex_SDE_Encounter_With_First_Oxygen_Saturation = -8371025803682788439L;

    private IEnumerable<(CqlTupleMetadata, string EncounterId, CqlQuantity FirstOxygenSatResult, CqlDateTime Timing)?> SDE_Encounter_With_First_Oxygen_Saturation_Compute(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Inpatient_Encounters(context);

        (CqlTupleMetadata, string EncounterId, CqlQuantity FirstOxygenSatResult, CqlDateTime Timing)? b_(Encounter EncounterInpatient) {
            Id e_ = EncounterInpatient?.IdElement;
            string f_ = e_?.Value;
            CqlValueSet g_ = this.Oxygen_Saturation_by_Pulse_Oximetry(context);
            IEnumerable<Observation> h_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, g_, default, "http://hl7.org/fhir/us/core/StructureDefinition/us-core-pulse-oximetry"));

            bool? i_(Observation O2Saturation) {
                DataType y_ = O2Saturation?.Effective;
                object z_ = FHIRHelpers_4_4_000.Instance.ToValue(context, y_);
                CqlDateTime aa_ = QICoreCommon_4_0_000.Instance.earliest(context, z_);
                CqlInterval<CqlDateTime> ab_ = CQMCommon_4_1_000.Instance.hospitalizationWithObservationAndOutpatientSurgeryService(context, EncounterInpatient);
                bool? ac_ = context.Operators.In<CqlDateTime>(aa_, ab_, (string)default);
                Code<ObservationStatus> ad_ = O2Saturation?.StatusElement;
                ObservationStatus? ae_ = ad_?.Value;
                string af_ = context.Operators.Convert<string>(ae_);
                string[] ag_ = [
                    "final",
                    "amended",
                    "corrected",
                ];
                bool? ah_ = context.Operators.In<string>(af_, (IEnumerable<string>)ag_);
                bool? ai_ = context.Operators.And(ac_, ah_);
                DataType aj_ = O2Saturation?.Value;
                CqlQuantity ak_ = FHIRHelpers_4_4_000.Instance.ToQuantity(context, aj_ as Quantity);
                bool? al_ = context.Operators.Not((bool?)(ak_ is null));
                bool? am_ = context.Operators.And(ai_, al_);
                return am_;
            }

            IEnumerable<Observation> j_ = context.Operators.Where<Observation>(h_, i_);

            object k_(Observation @this) {
                DataType an_ = @this?.Effective;
                object ao_ = FHIRHelpers_4_4_000.Instance.ToValue(context, an_);
                CqlDateTime ap_ = QICoreCommon_4_0_000.Instance.earliest(context, ao_);
                return ap_;
            }

            IEnumerable<Observation> l_ = context.Operators.SortBy<Observation>(j_, k_, System.ComponentModel.ListSortDirection.Ascending);
            Observation m_ = context.Operators.First<Observation>(l_);
            DataType n_ = m_?.Value;
            CqlQuantity o_ = FHIRHelpers_4_4_000.Instance.ToQuantity(context, n_ as Quantity);

            bool? p_(Observation O2Saturation) {
                DataType aq_ = O2Saturation?.Effective;
                object ar_ = FHIRHelpers_4_4_000.Instance.ToValue(context, aq_);
                CqlDateTime as_ = QICoreCommon_4_0_000.Instance.earliest(context, ar_);
                CqlInterval<CqlDateTime> at_ = CQMCommon_4_1_000.Instance.hospitalizationWithObservationAndOutpatientSurgeryService(context, EncounterInpatient);
                bool? au_ = context.Operators.In<CqlDateTime>(as_, at_, (string)default);
                Code<ObservationStatus> av_ = O2Saturation?.StatusElement;
                ObservationStatus? aw_ = av_?.Value;
                string ax_ = context.Operators.Convert<string>(aw_);
                string[] ay_ = [
                    "final",
                    "amended",
                    "corrected",
                ];
                bool? az_ = context.Operators.In<string>(ax_, (IEnumerable<string>)ay_);
                bool? ba_ = context.Operators.And(au_, az_);
                DataType bb_ = O2Saturation?.Value;
                CqlQuantity bc_ = FHIRHelpers_4_4_000.Instance.ToQuantity(context, bb_ as Quantity);
                bool? bd_ = context.Operators.Not((bool?)(bc_ is null));
                bool? be_ = context.Operators.And(ba_, bd_);
                return be_;
            }

            IEnumerable<Observation> q_ = context.Operators.Where<Observation>(h_, p_);

            object r_(Observation @this) {
                DataType bf_ = @this?.Effective;
                object bg_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bf_);
                CqlDateTime bh_ = QICoreCommon_4_0_000.Instance.earliest(context, bg_);
                return bh_;
            }

            IEnumerable<Observation> s_ = context.Operators.SortBy<Observation>(q_, r_, System.ComponentModel.ListSortDirection.Ascending);
            Observation t_ = context.Operators.First<Observation>(s_);
            DataType u_ = t_?.Effective;
            object v_ = FHIRHelpers_4_4_000.Instance.ToValue(context, u_);
            CqlDateTime w_ = QICoreCommon_4_0_000.Instance.earliest(context, v_);
            (CqlTupleMetadata, string EncounterId, CqlQuantity FirstOxygenSatResult, CqlDateTime Timing)? x_ = (CqlTupleMetadata_FdREYEdHOZIcMCNYCRFJYJReA, f_, o_ as CqlQuantity, w_);
            return x_;
        }

        IEnumerable<(CqlTupleMetadata, string EncounterId, CqlQuantity FirstOxygenSatResult, CqlDateTime Timing)?> c_ = context.Operators.Select<Encounter, (CqlTupleMetadata, string EncounterId, CqlQuantity FirstOxygenSatResult, CqlDateTime Timing)?>(a_, b_);
        IEnumerable<(CqlTupleMetadata, string EncounterId, CqlQuantity FirstOxygenSatResult, CqlDateTime Timing)?> d_ = context.Operators.Distinct<(CqlTupleMetadata, string EncounterId, CqlQuantity FirstOxygenSatResult, CqlDateTime Timing)?>(c_);
        return d_;
    }


    [CqlExpressionDefinition("SDE Encounter With First Systolic Blood Pressure")]
    public IEnumerable<(CqlTupleMetadata, string EncounterId, IEnumerable<CqlQuantity> FirstSBPResult, CqlDateTime Timing)?> SDE_Encounter_With_First_Systolic_Blood_Pressure(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_SDE_Encounter_With_First_Systolic_Blood_Pressure, SDE_Encounter_With_First_Systolic_Blood_Pressure_Compute);

    private const long _cacheIndex_SDE_Encounter_With_First_Systolic_Blood_Pressure = -3207799827161922512L;

    private IEnumerable<(CqlTupleMetadata, string EncounterId, IEnumerable<CqlQuantity> FirstSBPResult, CqlDateTime Timing)?> SDE_Encounter_With_First_Systolic_Blood_Pressure_Compute(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Inpatient_Encounters(context);

        (CqlTupleMetadata, string EncounterId, IEnumerable<CqlQuantity> FirstSBPResult, CqlDateTime Timing)? b_(Encounter EncounterInpatient) {
            Id e_ = EncounterInpatient?.IdElement;
            string f_ = e_?.Value;
            IEnumerable<Observation> g_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/core/StructureDefinition/us-core-blood-pressure"));

            bool? h_(Observation BP) {
                DataType ab_ = BP?.Effective;
                object ac_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ab_);
                CqlDateTime ad_ = QICoreCommon_4_0_000.Instance.earliest(context, ac_);
                CqlInterval<CqlDateTime> ae_ = CQMCommon_4_1_000.Instance.hospitalizationWithObservationAndOutpatientSurgeryService(context, EncounterInpatient);
                bool? af_ = context.Operators.In<CqlDateTime>(ad_, ae_, (string)default);
                Code<ObservationStatus> ag_ = BP?.StatusElement;
                ObservationStatus? ah_ = ag_?.Value;
                string ai_ = context.Operators.Convert<string>(ah_);
                string[] aj_ = [
                    "final",
                    "amended",
                    "corrected",
                ];
                bool? ak_ = context.Operators.In<string>(ai_, (IEnumerable<string>)aj_);
                bool? al_ = context.Operators.And(af_, ak_);
                List<Observation.ComponentComponent> am_ = BP?.Component;

                bool? an_(Observation.ComponentComponent @this) {
                    DataType at_ = @this?.Value;
                    object au_ = FHIRHelpers_4_4_000.Instance.ToValue(context, at_);
                    bool? av_ = context.Operators.Not((bool?)(au_ is null));
                    return av_;
                }

                IEnumerable<Observation.ComponentComponent> ao_ = context.Operators.Where<Observation.ComponentComponent>((IEnumerable<Observation.ComponentComponent>)am_, an_);

                object ap_(Observation.ComponentComponent @this) {
                    DataType aw_ = @this?.Value;
                    object ax_ = FHIRHelpers_4_4_000.Instance.ToValue(context, aw_);
                    return ax_;
                }

                IEnumerable<object> aq_ = context.Operators.Select<Observation.ComponentComponent, object>(ao_, ap_);
                bool? ar_ = context.Operators.Not((bool?)(aq_ is null));
                bool? as_ = context.Operators.And(al_, ar_);
                return as_;
            }

            IEnumerable<Observation> i_ = context.Operators.Where<Observation>(g_, h_);

            object j_(Observation @this) {
                DataType ay_ = @this?.Effective;
                object az_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ay_);
                CqlDateTime ba_ = QICoreCommon_4_0_000.Instance.earliest(context, az_);
                return ba_;
            }

            IEnumerable<Observation> k_ = context.Operators.SortBy<Observation>(i_, j_, System.ComponentModel.ListSortDirection.Ascending);
            Observation l_ = context.Operators.First<Observation>(k_);
            List<Observation.ComponentComponent> m_ = l_?.Component;

            bool? n_(Observation.ComponentComponent C) {
                CodeableConcept bb_ = C?.Code;
                CqlConcept bc_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, bb_);
                CqlCode bd_ = this.Systolic_blood_pressure(context);
                CqlConcept be_ = context.Operators.ConvertCodeToConcept(bd_);
                bool? bf_ = context.Operators.Equivalent(bc_, be_);
                return bf_;
            }

            IEnumerable<Observation.ComponentComponent> o_ = context.Operators.Where<Observation.ComponentComponent>((IEnumerable<Observation.ComponentComponent>)m_, n_);

            CqlQuantity p_(Observation.ComponentComponent C) {
                DataType bg_ = C?.Value;
                object bh_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bg_);
                return bh_ as CqlQuantity;
            }

            IEnumerable<CqlQuantity> q_ = context.Operators.Select<Observation.ComponentComponent, CqlQuantity>(o_, p_);
            IEnumerable<CqlQuantity> r_ = context.Operators.Distinct<CqlQuantity>(q_);

            bool? s_(Observation BP) {
                DataType bi_ = BP?.Effective;
                object bj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bi_);
                CqlDateTime bk_ = QICoreCommon_4_0_000.Instance.earliest(context, bj_);
                CqlInterval<CqlDateTime> bl_ = CQMCommon_4_1_000.Instance.hospitalizationWithObservationAndOutpatientSurgeryService(context, EncounterInpatient);
                bool? bm_ = context.Operators.In<CqlDateTime>(bk_, bl_, (string)default);
                Code<ObservationStatus> bn_ = BP?.StatusElement;
                ObservationStatus? bo_ = bn_?.Value;
                string bp_ = context.Operators.Convert<string>(bo_);
                string[] bq_ = [
                    "final",
                    "amended",
                    "corrected",
                ];
                bool? br_ = context.Operators.In<string>(bp_, (IEnumerable<string>)bq_);
                bool? bs_ = context.Operators.And(bm_, br_);
                List<Observation.ComponentComponent> bt_ = BP?.Component;

                bool? bu_(Observation.ComponentComponent @this) {
                    DataType ca_ = @this?.Value;
                    object cb_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ca_);
                    bool? cc_ = context.Operators.Not((bool?)(cb_ is null));
                    return cc_;
                }

                IEnumerable<Observation.ComponentComponent> bv_ = context.Operators.Where<Observation.ComponentComponent>((IEnumerable<Observation.ComponentComponent>)bt_, bu_);

                object bw_(Observation.ComponentComponent @this) {
                    DataType cd_ = @this?.Value;
                    object ce_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cd_);
                    return ce_;
                }

                IEnumerable<object> bx_ = context.Operators.Select<Observation.ComponentComponent, object>(bv_, bw_);
                bool? by_ = context.Operators.Not((bool?)(bx_ is null));
                bool? bz_ = context.Operators.And(bs_, by_);
                return bz_;
            }

            IEnumerable<Observation> t_ = context.Operators.Where<Observation>(g_, s_);

            object u_(Observation @this) {
                DataType cf_ = @this?.Effective;
                object cg_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cf_);
                CqlDateTime ch_ = QICoreCommon_4_0_000.Instance.earliest(context, cg_);
                return ch_;
            }

            IEnumerable<Observation> v_ = context.Operators.SortBy<Observation>(t_, u_, System.ComponentModel.ListSortDirection.Ascending);
            Observation w_ = context.Operators.First<Observation>(v_);
            DataType x_ = w_?.Effective;
            object y_ = FHIRHelpers_4_4_000.Instance.ToValue(context, x_);
            CqlDateTime z_ = QICoreCommon_4_0_000.Instance.earliest(context, y_);
            (CqlTupleMetadata, string EncounterId, IEnumerable<CqlQuantity> FirstSBPResult, CqlDateTime Timing)? aa_ = (CqlTupleMetadata_FjSKXeIESORPNbRGajibMfUaK, f_, r_, z_);
            return aa_;
        }

        IEnumerable<(CqlTupleMetadata, string EncounterId, IEnumerable<CqlQuantity> FirstSBPResult, CqlDateTime Timing)?> c_ = context.Operators.Select<Encounter, (CqlTupleMetadata, string EncounterId, IEnumerable<CqlQuantity> FirstSBPResult, CqlDateTime Timing)?>(a_, b_);
        IEnumerable<(CqlTupleMetadata, string EncounterId, IEnumerable<CqlQuantity> FirstSBPResult, CqlDateTime Timing)?> d_ = context.Operators.Distinct<(CqlTupleMetadata, string EncounterId, IEnumerable<CqlQuantity> FirstSBPResult, CqlDateTime Timing)?>(c_);
        return d_;
    }


    [CqlExpressionDefinition("SDE Encounter With First Bicarbonate Lab Test")]
    public IEnumerable<(CqlTupleMetadata, string EncounterId, CqlQuantity FirstBicarbonateResult, CqlDateTime Timing)?> SDE_Encounter_With_First_Bicarbonate_Lab_Test(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_SDE_Encounter_With_First_Bicarbonate_Lab_Test, SDE_Encounter_With_First_Bicarbonate_Lab_Test_Compute);

    private const long _cacheIndex_SDE_Encounter_With_First_Bicarbonate_Lab_Test = -5916718293760283523L;

    private IEnumerable<(CqlTupleMetadata, string EncounterId, CqlQuantity FirstBicarbonateResult, CqlDateTime Timing)?> SDE_Encounter_With_First_Bicarbonate_Lab_Test_Compute(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Inpatient_Encounters(context);

        (CqlTupleMetadata, string EncounterId, CqlQuantity FirstBicarbonateResult, CqlDateTime Timing)? b_(Encounter EncounterInpatient) {
            Id e_ = EncounterInpatient?.IdElement;
            string f_ = e_?.Value;
            CqlValueSet g_ = this.Bicarbonate_lab_test(context);
            IEnumerable<Observation> h_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, g_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation-lab"));

            bool? i_(Observation BicarbonateLab) {

                object y_() {

                    bool am_() {
                        DataType ap_ = BicarbonateLab?.Effective;
                        object aq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ap_);
                        bool ar_ = aq_ is CqlDateTime;
                        return ar_;
                    }


                    bool an_() {
                        DataType as_ = BicarbonateLab?.Effective;
                        object at_ = FHIRHelpers_4_4_000.Instance.ToValue(context, as_);
                        bool au_ = at_ is CqlDateTime;
                        return au_;
                    }


                    bool ao_() {
                        DataType av_ = BicarbonateLab?.Effective;
                        object aw_ = FHIRHelpers_4_4_000.Instance.ToValue(context, av_);
                        bool ax_ = aw_ is CqlInterval<CqlDateTime>;
                        return ax_;
                    }

                    if (am_())
                    {
                        DataType ay_ = BicarbonateLab?.Effective;
                        object az_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ay_);
                        return az_ as CqlDateTime;
                    }
                    else if (an_())
                    {
                        DataType ba_ = BicarbonateLab?.Effective;
                        object bb_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ba_);
                        return bb_ as CqlDateTime;
                    }
                    else if (ao_())
                    {
                        DataType bc_ = BicarbonateLab?.Effective;
                        object bd_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bc_);
                        return bd_ as CqlInterval<CqlDateTime>;
                    }
                    else
                    {
                        return null;
                    }
                }

                CqlDateTime z_ = QICoreCommon_4_0_000.Instance.earliest(context, y_());
                CqlInterval<CqlDateTime> aa_ = CQMCommon_4_1_000.Instance.hospitalizationWithObservationAndOutpatientSurgeryService(context, EncounterInpatient);
                bool? ab_ = context.Operators.In<CqlDateTime>(z_, aa_, (string)default);
                Code<ObservationStatus> ac_ = BicarbonateLab?.StatusElement;
                ObservationStatus? ad_ = ac_?.Value;
                string ae_ = context.Operators.Convert<string>(ad_);
                string[] af_ = [
                    "final",
                    "amended",
                    "corrected",
                ];
                bool? ag_ = context.Operators.In<string>(ae_, (IEnumerable<string>)af_);
                bool? ah_ = context.Operators.And(ab_, ag_);
                DataType ai_ = BicarbonateLab?.Value;
                object aj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ai_);
                bool? ak_ = context.Operators.Not((bool?)(aj_ is null));
                bool? al_ = context.Operators.And(ah_, ak_);
                return al_;
            }

            IEnumerable<Observation> j_ = context.Operators.Where<Observation>(h_, i_);

            object k_(Observation @this) {
                Instant be_ = @this?.IssuedElement;
                DateTimeOffset? bf_ = be_?.Value;
                CqlDateTime bg_ = context.Operators.Convert<CqlDateTime>(bf_);
                CqlDateTime bh_ = QICoreCommon_4_0_000.Instance.earliest(context, bg_);
                return bh_;
            }

            IEnumerable<Observation> l_ = context.Operators.SortBy<Observation>(j_, k_, System.ComponentModel.ListSortDirection.Ascending);
            Observation m_ = context.Operators.First<Observation>(l_);
            DataType n_ = m_?.Value;
            object o_ = FHIRHelpers_4_4_000.Instance.ToValue(context, n_);

            bool? p_(Observation BicarbonateLab) {

                object bi_() {

                    bool bw_() {
                        DataType bz_ = BicarbonateLab?.Effective;
                        object ca_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bz_);
                        bool cb_ = ca_ is CqlDateTime;
                        return cb_;
                    }


                    bool bx_() {
                        DataType cc_ = BicarbonateLab?.Effective;
                        object cd_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cc_);
                        bool ce_ = cd_ is CqlDateTime;
                        return ce_;
                    }


                    bool by_() {
                        DataType cf_ = BicarbonateLab?.Effective;
                        object cg_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cf_);
                        bool ch_ = cg_ is CqlInterval<CqlDateTime>;
                        return ch_;
                    }

                    if (bw_())
                    {
                        DataType ci_ = BicarbonateLab?.Effective;
                        object cj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ci_);
                        return cj_ as CqlDateTime;
                    }
                    else if (bx_())
                    {
                        DataType ck_ = BicarbonateLab?.Effective;
                        object cl_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ck_);
                        return cl_ as CqlDateTime;
                    }
                    else if (by_())
                    {
                        DataType cm_ = BicarbonateLab?.Effective;
                        object cn_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cm_);
                        return cn_ as CqlInterval<CqlDateTime>;
                    }
                    else
                    {
                        return null;
                    }
                }

                CqlDateTime bj_ = QICoreCommon_4_0_000.Instance.earliest(context, bi_());
                CqlInterval<CqlDateTime> bk_ = CQMCommon_4_1_000.Instance.hospitalizationWithObservationAndOutpatientSurgeryService(context, EncounterInpatient);
                bool? bl_ = context.Operators.In<CqlDateTime>(bj_, bk_, (string)default);
                Code<ObservationStatus> bm_ = BicarbonateLab?.StatusElement;
                ObservationStatus? bn_ = bm_?.Value;
                string bo_ = context.Operators.Convert<string>(bn_);
                string[] bp_ = [
                    "final",
                    "amended",
                    "corrected",
                ];
                bool? bq_ = context.Operators.In<string>(bo_, (IEnumerable<string>)bp_);
                bool? br_ = context.Operators.And(bl_, bq_);
                DataType bs_ = BicarbonateLab?.Value;
                object bt_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bs_);
                bool? bu_ = context.Operators.Not((bool?)(bt_ is null));
                bool? bv_ = context.Operators.And(br_, bu_);
                return bv_;
            }

            IEnumerable<Observation> q_ = context.Operators.Where<Observation>(h_, p_);

            object r_(Observation @this) {
                Instant co_ = @this?.IssuedElement;
                DateTimeOffset? cp_ = co_?.Value;
                CqlDateTime cq_ = context.Operators.Convert<CqlDateTime>(cp_);
                CqlDateTime cr_ = QICoreCommon_4_0_000.Instance.earliest(context, cq_);
                return cr_;
            }

            IEnumerable<Observation> s_ = context.Operators.SortBy<Observation>(q_, r_, System.ComponentModel.ListSortDirection.Ascending);
            Observation t_ = context.Operators.First<Observation>(s_);
            Instant u_ = t_?.IssuedElement;
            DateTimeOffset? v_ = u_?.Value;
            CqlDateTime w_ = context.Operators.Convert<CqlDateTime>(v_);
            (CqlTupleMetadata, string EncounterId, CqlQuantity FirstBicarbonateResult, CqlDateTime Timing)? x_ = (CqlTupleMetadata_GbUHPXXHScejjXWhcHJFQQifQ, f_, o_ as CqlQuantity, w_);
            return x_;
        }

        IEnumerable<(CqlTupleMetadata, string EncounterId, CqlQuantity FirstBicarbonateResult, CqlDateTime Timing)?> c_ = context.Operators.Select<Encounter, (CqlTupleMetadata, string EncounterId, CqlQuantity FirstBicarbonateResult, CqlDateTime Timing)?>(a_, b_);
        IEnumerable<(CqlTupleMetadata, string EncounterId, CqlQuantity FirstBicarbonateResult, CqlDateTime Timing)?> d_ = context.Operators.Distinct<(CqlTupleMetadata, string EncounterId, CqlQuantity FirstBicarbonateResult, CqlDateTime Timing)?>(c_);
        return d_;
    }


    [CqlExpressionDefinition("SDE Encounter With First Creatinine Lab Test")]
    public IEnumerable<(CqlTupleMetadata, string EncounterId, CqlQuantity FirstCreatinineResult, CqlDateTime Timing)?> SDE_Encounter_With_First_Creatinine_Lab_Test(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_SDE_Encounter_With_First_Creatinine_Lab_Test, SDE_Encounter_With_First_Creatinine_Lab_Test_Compute);

    private const long _cacheIndex_SDE_Encounter_With_First_Creatinine_Lab_Test = -5779842121506852161L;

    private IEnumerable<(CqlTupleMetadata, string EncounterId, CqlQuantity FirstCreatinineResult, CqlDateTime Timing)?> SDE_Encounter_With_First_Creatinine_Lab_Test_Compute(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Inpatient_Encounters(context);

        (CqlTupleMetadata, string EncounterId, CqlQuantity FirstCreatinineResult, CqlDateTime Timing)? b_(Encounter EncounterInpatient) {
            Id e_ = EncounterInpatient?.IdElement;
            string f_ = e_?.Value;
            CqlValueSet g_ = this.Creatinine_lab_test(context);
            IEnumerable<Observation> h_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, g_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation-lab"));

            bool? i_(Observation CreatinineLab) {

                object y_() {

                    bool am_() {
                        DataType ap_ = CreatinineLab?.Effective;
                        object aq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ap_);
                        bool ar_ = aq_ is CqlDateTime;
                        return ar_;
                    }


                    bool an_() {
                        DataType as_ = CreatinineLab?.Effective;
                        object at_ = FHIRHelpers_4_4_000.Instance.ToValue(context, as_);
                        bool au_ = at_ is CqlDateTime;
                        return au_;
                    }


                    bool ao_() {
                        DataType av_ = CreatinineLab?.Effective;
                        object aw_ = FHIRHelpers_4_4_000.Instance.ToValue(context, av_);
                        bool ax_ = aw_ is CqlInterval<CqlDateTime>;
                        return ax_;
                    }

                    if (am_())
                    {
                        DataType ay_ = CreatinineLab?.Effective;
                        object az_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ay_);
                        return az_ as CqlDateTime;
                    }
                    else if (an_())
                    {
                        DataType ba_ = CreatinineLab?.Effective;
                        object bb_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ba_);
                        return bb_ as CqlDateTime;
                    }
                    else if (ao_())
                    {
                        DataType bc_ = CreatinineLab?.Effective;
                        object bd_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bc_);
                        return bd_ as CqlInterval<CqlDateTime>;
                    }
                    else
                    {
                        return null;
                    }
                }

                CqlDateTime z_ = QICoreCommon_4_0_000.Instance.earliest(context, y_());
                CqlInterval<CqlDateTime> aa_ = CQMCommon_4_1_000.Instance.hospitalizationWithObservationAndOutpatientSurgeryService(context, EncounterInpatient);
                bool? ab_ = context.Operators.In<CqlDateTime>(z_, aa_, (string)default);
                Code<ObservationStatus> ac_ = CreatinineLab?.StatusElement;
                ObservationStatus? ad_ = ac_?.Value;
                string ae_ = context.Operators.Convert<string>(ad_);
                string[] af_ = [
                    "final",
                    "amended",
                    "corrected",
                ];
                bool? ag_ = context.Operators.In<string>(ae_, (IEnumerable<string>)af_);
                bool? ah_ = context.Operators.And(ab_, ag_);
                DataType ai_ = CreatinineLab?.Value;
                object aj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ai_);
                bool? ak_ = context.Operators.Not((bool?)(aj_ is null));
                bool? al_ = context.Operators.And(ah_, ak_);
                return al_;
            }

            IEnumerable<Observation> j_ = context.Operators.Where<Observation>(h_, i_);

            object k_(Observation @this) {
                Instant be_ = @this?.IssuedElement;
                DateTimeOffset? bf_ = be_?.Value;
                CqlDateTime bg_ = context.Operators.Convert<CqlDateTime>(bf_);
                CqlDateTime bh_ = QICoreCommon_4_0_000.Instance.earliest(context, bg_);
                return bh_;
            }

            IEnumerable<Observation> l_ = context.Operators.SortBy<Observation>(j_, k_, System.ComponentModel.ListSortDirection.Ascending);
            Observation m_ = context.Operators.First<Observation>(l_);
            DataType n_ = m_?.Value;
            object o_ = FHIRHelpers_4_4_000.Instance.ToValue(context, n_);

            bool? p_(Observation CreatinineLab) {

                object bi_() {

                    bool bw_() {
                        DataType bz_ = CreatinineLab?.Effective;
                        object ca_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bz_);
                        bool cb_ = ca_ is CqlDateTime;
                        return cb_;
                    }


                    bool bx_() {
                        DataType cc_ = CreatinineLab?.Effective;
                        object cd_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cc_);
                        bool ce_ = cd_ is CqlDateTime;
                        return ce_;
                    }


                    bool by_() {
                        DataType cf_ = CreatinineLab?.Effective;
                        object cg_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cf_);
                        bool ch_ = cg_ is CqlInterval<CqlDateTime>;
                        return ch_;
                    }

                    if (bw_())
                    {
                        DataType ci_ = CreatinineLab?.Effective;
                        object cj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ci_);
                        return cj_ as CqlDateTime;
                    }
                    else if (bx_())
                    {
                        DataType ck_ = CreatinineLab?.Effective;
                        object cl_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ck_);
                        return cl_ as CqlDateTime;
                    }
                    else if (by_())
                    {
                        DataType cm_ = CreatinineLab?.Effective;
                        object cn_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cm_);
                        return cn_ as CqlInterval<CqlDateTime>;
                    }
                    else
                    {
                        return null;
                    }
                }

                CqlDateTime bj_ = QICoreCommon_4_0_000.Instance.earliest(context, bi_());
                CqlInterval<CqlDateTime> bk_ = CQMCommon_4_1_000.Instance.hospitalizationWithObservationAndOutpatientSurgeryService(context, EncounterInpatient);
                bool? bl_ = context.Operators.In<CqlDateTime>(bj_, bk_, (string)default);
                Code<ObservationStatus> bm_ = CreatinineLab?.StatusElement;
                ObservationStatus? bn_ = bm_?.Value;
                string bo_ = context.Operators.Convert<string>(bn_);
                string[] bp_ = [
                    "final",
                    "amended",
                    "corrected",
                ];
                bool? bq_ = context.Operators.In<string>(bo_, (IEnumerable<string>)bp_);
                bool? br_ = context.Operators.And(bl_, bq_);
                DataType bs_ = CreatinineLab?.Value;
                object bt_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bs_);
                bool? bu_ = context.Operators.Not((bool?)(bt_ is null));
                bool? bv_ = context.Operators.And(br_, bu_);
                return bv_;
            }

            IEnumerable<Observation> q_ = context.Operators.Where<Observation>(h_, p_);

            object r_(Observation @this) {
                Instant co_ = @this?.IssuedElement;
                DateTimeOffset? cp_ = co_?.Value;
                CqlDateTime cq_ = context.Operators.Convert<CqlDateTime>(cp_);
                CqlDateTime cr_ = QICoreCommon_4_0_000.Instance.earliest(context, cq_);
                return cr_;
            }

            IEnumerable<Observation> s_ = context.Operators.SortBy<Observation>(q_, r_, System.ComponentModel.ListSortDirection.Ascending);
            Observation t_ = context.Operators.First<Observation>(s_);
            Instant u_ = t_?.IssuedElement;
            DateTimeOffset? v_ = u_?.Value;
            CqlDateTime w_ = context.Operators.Convert<CqlDateTime>(v_);
            (CqlTupleMetadata, string EncounterId, CqlQuantity FirstCreatinineResult, CqlDateTime Timing)? x_ = (CqlTupleMetadata_FETECNQPQREfGRgPYWhOWgeWA, f_, o_ as CqlQuantity, w_);
            return x_;
        }

        IEnumerable<(CqlTupleMetadata, string EncounterId, CqlQuantity FirstCreatinineResult, CqlDateTime Timing)?> c_ = context.Operators.Select<Encounter, (CqlTupleMetadata, string EncounterId, CqlQuantity FirstCreatinineResult, CqlDateTime Timing)?>(a_, b_);
        IEnumerable<(CqlTupleMetadata, string EncounterId, CqlQuantity FirstCreatinineResult, CqlDateTime Timing)?> d_ = context.Operators.Distinct<(CqlTupleMetadata, string EncounterId, CqlQuantity FirstCreatinineResult, CqlDateTime Timing)?>(c_);
        return d_;
    }


    [CqlExpressionDefinition("SDE Encounter With First Hematocrit Lab Test")]
    public IEnumerable<(CqlTupleMetadata, string EncounterId, CqlQuantity FirstHematocritResult, CqlDateTime Timing)?> SDE_Encounter_With_First_Hematocrit_Lab_Test(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_SDE_Encounter_With_First_Hematocrit_Lab_Test, SDE_Encounter_With_First_Hematocrit_Lab_Test_Compute);

    private const long _cacheIndex_SDE_Encounter_With_First_Hematocrit_Lab_Test = -6738782626327138842L;

    private IEnumerable<(CqlTupleMetadata, string EncounterId, CqlQuantity FirstHematocritResult, CqlDateTime Timing)?> SDE_Encounter_With_First_Hematocrit_Lab_Test_Compute(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Inpatient_Encounters(context);

        (CqlTupleMetadata, string EncounterId, CqlQuantity FirstHematocritResult, CqlDateTime Timing)? b_(Encounter EncounterInpatient) {
            Id e_ = EncounterInpatient?.IdElement;
            string f_ = e_?.Value;
            CqlValueSet g_ = this.Hematocrit_lab_test(context);
            IEnumerable<Observation> h_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, g_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation-lab"));

            bool? i_(Observation HematocritLab) {

                object y_() {

                    bool am_() {
                        DataType ap_ = HematocritLab?.Effective;
                        object aq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ap_);
                        bool ar_ = aq_ is CqlDateTime;
                        return ar_;
                    }


                    bool an_() {
                        DataType as_ = HematocritLab?.Effective;
                        object at_ = FHIRHelpers_4_4_000.Instance.ToValue(context, as_);
                        bool au_ = at_ is CqlDateTime;
                        return au_;
                    }


                    bool ao_() {
                        DataType av_ = HematocritLab?.Effective;
                        object aw_ = FHIRHelpers_4_4_000.Instance.ToValue(context, av_);
                        bool ax_ = aw_ is CqlInterval<CqlDateTime>;
                        return ax_;
                    }

                    if (am_())
                    {
                        DataType ay_ = HematocritLab?.Effective;
                        object az_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ay_);
                        return az_ as CqlDateTime;
                    }
                    else if (an_())
                    {
                        DataType ba_ = HematocritLab?.Effective;
                        object bb_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ba_);
                        return bb_ as CqlDateTime;
                    }
                    else if (ao_())
                    {
                        DataType bc_ = HematocritLab?.Effective;
                        object bd_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bc_);
                        return bd_ as CqlInterval<CqlDateTime>;
                    }
                    else
                    {
                        return null;
                    }
                }

                CqlDateTime z_ = QICoreCommon_4_0_000.Instance.earliest(context, y_());
                CqlInterval<CqlDateTime> aa_ = CQMCommon_4_1_000.Instance.hospitalizationWithObservationAndOutpatientSurgeryService(context, EncounterInpatient);
                bool? ab_ = context.Operators.In<CqlDateTime>(z_, aa_, (string)default);
                Code<ObservationStatus> ac_ = HematocritLab?.StatusElement;
                ObservationStatus? ad_ = ac_?.Value;
                string ae_ = context.Operators.Convert<string>(ad_);
                string[] af_ = [
                    "final",
                    "amended",
                    "corrected",
                ];
                bool? ag_ = context.Operators.In<string>(ae_, (IEnumerable<string>)af_);
                bool? ah_ = context.Operators.And(ab_, ag_);
                DataType ai_ = HematocritLab?.Value;
                object aj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ai_);
                bool? ak_ = context.Operators.Not((bool?)(aj_ is null));
                bool? al_ = context.Operators.And(ah_, ak_);
                return al_;
            }

            IEnumerable<Observation> j_ = context.Operators.Where<Observation>(h_, i_);

            object k_(Observation @this) {
                Instant be_ = @this?.IssuedElement;
                DateTimeOffset? bf_ = be_?.Value;
                CqlDateTime bg_ = context.Operators.Convert<CqlDateTime>(bf_);
                CqlDateTime bh_ = QICoreCommon_4_0_000.Instance.earliest(context, bg_);
                return bh_;
            }

            IEnumerable<Observation> l_ = context.Operators.SortBy<Observation>(j_, k_, System.ComponentModel.ListSortDirection.Ascending);
            Observation m_ = context.Operators.First<Observation>(l_);
            DataType n_ = m_?.Value;
            object o_ = FHIRHelpers_4_4_000.Instance.ToValue(context, n_);

            bool? p_(Observation HematocritLab) {

                object bi_() {

                    bool bw_() {
                        DataType bz_ = HematocritLab?.Effective;
                        object ca_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bz_);
                        bool cb_ = ca_ is CqlDateTime;
                        return cb_;
                    }


                    bool bx_() {
                        DataType cc_ = HematocritLab?.Effective;
                        object cd_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cc_);
                        bool ce_ = cd_ is CqlDateTime;
                        return ce_;
                    }


                    bool by_() {
                        DataType cf_ = HematocritLab?.Effective;
                        object cg_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cf_);
                        bool ch_ = cg_ is CqlInterval<CqlDateTime>;
                        return ch_;
                    }

                    if (bw_())
                    {
                        DataType ci_ = HematocritLab?.Effective;
                        object cj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ci_);
                        return cj_ as CqlDateTime;
                    }
                    else if (bx_())
                    {
                        DataType ck_ = HematocritLab?.Effective;
                        object cl_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ck_);
                        return cl_ as CqlDateTime;
                    }
                    else if (by_())
                    {
                        DataType cm_ = HematocritLab?.Effective;
                        object cn_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cm_);
                        return cn_ as CqlInterval<CqlDateTime>;
                    }
                    else
                    {
                        return null;
                    }
                }

                CqlDateTime bj_ = QICoreCommon_4_0_000.Instance.earliest(context, bi_());
                CqlInterval<CqlDateTime> bk_ = CQMCommon_4_1_000.Instance.hospitalizationWithObservationAndOutpatientSurgeryService(context, EncounterInpatient);
                bool? bl_ = context.Operators.In<CqlDateTime>(bj_, bk_, (string)default);
                Code<ObservationStatus> bm_ = HematocritLab?.StatusElement;
                ObservationStatus? bn_ = bm_?.Value;
                string bo_ = context.Operators.Convert<string>(bn_);
                string[] bp_ = [
                    "final",
                    "amended",
                    "corrected",
                ];
                bool? bq_ = context.Operators.In<string>(bo_, (IEnumerable<string>)bp_);
                bool? br_ = context.Operators.And(bl_, bq_);
                DataType bs_ = HematocritLab?.Value;
                object bt_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bs_);
                bool? bu_ = context.Operators.Not((bool?)(bt_ is null));
                bool? bv_ = context.Operators.And(br_, bu_);
                return bv_;
            }

            IEnumerable<Observation> q_ = context.Operators.Where<Observation>(h_, p_);

            object r_(Observation @this) {
                Instant co_ = @this?.IssuedElement;
                DateTimeOffset? cp_ = co_?.Value;
                CqlDateTime cq_ = context.Operators.Convert<CqlDateTime>(cp_);
                CqlDateTime cr_ = QICoreCommon_4_0_000.Instance.earliest(context, cq_);
                return cr_;
            }

            IEnumerable<Observation> s_ = context.Operators.SortBy<Observation>(q_, r_, System.ComponentModel.ListSortDirection.Ascending);
            Observation t_ = context.Operators.First<Observation>(s_);
            Instant u_ = t_?.IssuedElement;
            DateTimeOffset? v_ = u_?.Value;
            CqlDateTime w_ = context.Operators.Convert<CqlDateTime>(v_);
            (CqlTupleMetadata, string EncounterId, CqlQuantity FirstHematocritResult, CqlDateTime Timing)? x_ = (CqlTupleMetadata_DIHdhbAJeJTdiAVUAELUHRNdS, f_, o_ as CqlQuantity, w_);
            return x_;
        }

        IEnumerable<(CqlTupleMetadata, string EncounterId, CqlQuantity FirstHematocritResult, CqlDateTime Timing)?> c_ = context.Operators.Select<Encounter, (CqlTupleMetadata, string EncounterId, CqlQuantity FirstHematocritResult, CqlDateTime Timing)?>(a_, b_);
        IEnumerable<(CqlTupleMetadata, string EncounterId, CqlQuantity FirstHematocritResult, CqlDateTime Timing)?> d_ = context.Operators.Distinct<(CqlTupleMetadata, string EncounterId, CqlQuantity FirstHematocritResult, CqlDateTime Timing)?>(c_);
        return d_;
    }


    [CqlExpressionDefinition("SDE Encounter With First Platelet Lab Test")]
    public IEnumerable<(CqlTupleMetadata, string EncounterId, CqlQuantity FirstPlateletResult, CqlDateTime Timing)?> SDE_Encounter_With_First_Platelet_Lab_Test(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_SDE_Encounter_With_First_Platelet_Lab_Test, SDE_Encounter_With_First_Platelet_Lab_Test_Compute);

    private const long _cacheIndex_SDE_Encounter_With_First_Platelet_Lab_Test = -354840183162715779L;

    private IEnumerable<(CqlTupleMetadata, string EncounterId, CqlQuantity FirstPlateletResult, CqlDateTime Timing)?> SDE_Encounter_With_First_Platelet_Lab_Test_Compute(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Inpatient_Encounters(context);

        (CqlTupleMetadata, string EncounterId, CqlQuantity FirstPlateletResult, CqlDateTime Timing)? b_(Encounter EncounterInpatient) {
            Id e_ = EncounterInpatient?.IdElement;
            string f_ = e_?.Value;
            CqlValueSet g_ = this.Platelet_count_lab_test(context);
            IEnumerable<Observation> h_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, g_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation-lab"));

            bool? i_(Observation PlateletLab) {

                object y_() {

                    bool am_() {
                        DataType ap_ = PlateletLab?.Effective;
                        object aq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ap_);
                        bool ar_ = aq_ is CqlDateTime;
                        return ar_;
                    }


                    bool an_() {
                        DataType as_ = PlateletLab?.Effective;
                        object at_ = FHIRHelpers_4_4_000.Instance.ToValue(context, as_);
                        bool au_ = at_ is CqlDateTime;
                        return au_;
                    }


                    bool ao_() {
                        DataType av_ = PlateletLab?.Effective;
                        object aw_ = FHIRHelpers_4_4_000.Instance.ToValue(context, av_);
                        bool ax_ = aw_ is CqlInterval<CqlDateTime>;
                        return ax_;
                    }

                    if (am_())
                    {
                        DataType ay_ = PlateletLab?.Effective;
                        object az_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ay_);
                        return az_ as CqlDateTime;
                    }
                    else if (an_())
                    {
                        DataType ba_ = PlateletLab?.Effective;
                        object bb_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ba_);
                        return bb_ as CqlDateTime;
                    }
                    else if (ao_())
                    {
                        DataType bc_ = PlateletLab?.Effective;
                        object bd_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bc_);
                        return bd_ as CqlInterval<CqlDateTime>;
                    }
                    else
                    {
                        return null;
                    }
                }

                CqlDateTime z_ = QICoreCommon_4_0_000.Instance.earliest(context, y_());
                CqlInterval<CqlDateTime> aa_ = CQMCommon_4_1_000.Instance.hospitalizationWithObservationAndOutpatientSurgeryService(context, EncounterInpatient);
                bool? ab_ = context.Operators.In<CqlDateTime>(z_, aa_, (string)default);
                Code<ObservationStatus> ac_ = PlateletLab?.StatusElement;
                ObservationStatus? ad_ = ac_?.Value;
                string ae_ = context.Operators.Convert<string>(ad_);
                string[] af_ = [
                    "final",
                    "amended",
                    "corrected",
                ];
                bool? ag_ = context.Operators.In<string>(ae_, (IEnumerable<string>)af_);
                bool? ah_ = context.Operators.And(ab_, ag_);
                DataType ai_ = PlateletLab?.Value;
                object aj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ai_);
                bool? ak_ = context.Operators.Not((bool?)(aj_ is null));
                bool? al_ = context.Operators.And(ah_, ak_);
                return al_;
            }

            IEnumerable<Observation> j_ = context.Operators.Where<Observation>(h_, i_);

            object k_(Observation @this) {
                Instant be_ = @this?.IssuedElement;
                DateTimeOffset? bf_ = be_?.Value;
                CqlDateTime bg_ = context.Operators.Convert<CqlDateTime>(bf_);
                CqlDateTime bh_ = QICoreCommon_4_0_000.Instance.earliest(context, bg_);
                return bh_;
            }

            IEnumerable<Observation> l_ = context.Operators.SortBy<Observation>(j_, k_, System.ComponentModel.ListSortDirection.Ascending);
            Observation m_ = context.Operators.First<Observation>(l_);
            DataType n_ = m_?.Value;
            object o_ = FHIRHelpers_4_4_000.Instance.ToValue(context, n_);

            bool? p_(Observation PlateletLab) {

                object bi_() {

                    bool bw_() {
                        DataType bz_ = PlateletLab?.Effective;
                        object ca_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bz_);
                        bool cb_ = ca_ is CqlDateTime;
                        return cb_;
                    }


                    bool bx_() {
                        DataType cc_ = PlateletLab?.Effective;
                        object cd_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cc_);
                        bool ce_ = cd_ is CqlDateTime;
                        return ce_;
                    }


                    bool by_() {
                        DataType cf_ = PlateletLab?.Effective;
                        object cg_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cf_);
                        bool ch_ = cg_ is CqlInterval<CqlDateTime>;
                        return ch_;
                    }

                    if (bw_())
                    {
                        DataType ci_ = PlateletLab?.Effective;
                        object cj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ci_);
                        return cj_ as CqlDateTime;
                    }
                    else if (bx_())
                    {
                        DataType ck_ = PlateletLab?.Effective;
                        object cl_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ck_);
                        return cl_ as CqlDateTime;
                    }
                    else if (by_())
                    {
                        DataType cm_ = PlateletLab?.Effective;
                        object cn_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cm_);
                        return cn_ as CqlInterval<CqlDateTime>;
                    }
                    else
                    {
                        return null;
                    }
                }

                CqlDateTime bj_ = QICoreCommon_4_0_000.Instance.earliest(context, bi_());
                CqlInterval<CqlDateTime> bk_ = CQMCommon_4_1_000.Instance.hospitalizationWithObservationAndOutpatientSurgeryService(context, EncounterInpatient);
                bool? bl_ = context.Operators.In<CqlDateTime>(bj_, bk_, (string)default);
                Code<ObservationStatus> bm_ = PlateletLab?.StatusElement;
                ObservationStatus? bn_ = bm_?.Value;
                string bo_ = context.Operators.Convert<string>(bn_);
                string[] bp_ = [
                    "final",
                    "amended",
                    "corrected",
                ];
                bool? bq_ = context.Operators.In<string>(bo_, (IEnumerable<string>)bp_);
                bool? br_ = context.Operators.And(bl_, bq_);
                DataType bs_ = PlateletLab?.Value;
                object bt_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bs_);
                bool? bu_ = context.Operators.Not((bool?)(bt_ is null));
                bool? bv_ = context.Operators.And(br_, bu_);
                return bv_;
            }

            IEnumerable<Observation> q_ = context.Operators.Where<Observation>(h_, p_);

            object r_(Observation @this) {
                Instant co_ = @this?.IssuedElement;
                DateTimeOffset? cp_ = co_?.Value;
                CqlDateTime cq_ = context.Operators.Convert<CqlDateTime>(cp_);
                CqlDateTime cr_ = QICoreCommon_4_0_000.Instance.earliest(context, cq_);
                return cr_;
            }

            IEnumerable<Observation> s_ = context.Operators.SortBy<Observation>(q_, r_, System.ComponentModel.ListSortDirection.Ascending);
            Observation t_ = context.Operators.First<Observation>(s_);
            Instant u_ = t_?.IssuedElement;
            DateTimeOffset? v_ = u_?.Value;
            CqlDateTime w_ = context.Operators.Convert<CqlDateTime>(v_);
            (CqlTupleMetadata, string EncounterId, CqlQuantity FirstPlateletResult, CqlDateTime Timing)? x_ = (CqlTupleMetadata_DAUcYHQZcDKbIfORJOEZBDgIh, f_, o_ as CqlQuantity, w_);
            return x_;
        }

        IEnumerable<(CqlTupleMetadata, string EncounterId, CqlQuantity FirstPlateletResult, CqlDateTime Timing)?> c_ = context.Operators.Select<Encounter, (CqlTupleMetadata, string EncounterId, CqlQuantity FirstPlateletResult, CqlDateTime Timing)?>(a_, b_);
        IEnumerable<(CqlTupleMetadata, string EncounterId, CqlQuantity FirstPlateletResult, CqlDateTime Timing)?> d_ = context.Operators.Distinct<(CqlTupleMetadata, string EncounterId, CqlQuantity FirstPlateletResult, CqlDateTime Timing)?>(c_);
        return d_;
    }


    [CqlExpressionDefinition("SDE Encounter With First Sodium Lab Test")]
    public IEnumerable<(CqlTupleMetadata, string EncounterId, CqlQuantity FirstSodiumResult, CqlDateTime Timing)?> SDE_Encounter_With_First_Sodium_Lab_Test(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_SDE_Encounter_With_First_Sodium_Lab_Test, SDE_Encounter_With_First_Sodium_Lab_Test_Compute);

    private const long _cacheIndex_SDE_Encounter_With_First_Sodium_Lab_Test = 1704795996816869661L;

    private IEnumerable<(CqlTupleMetadata, string EncounterId, CqlQuantity FirstSodiumResult, CqlDateTime Timing)?> SDE_Encounter_With_First_Sodium_Lab_Test_Compute(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Inpatient_Encounters(context);

        (CqlTupleMetadata, string EncounterId, CqlQuantity FirstSodiumResult, CqlDateTime Timing)? b_(Encounter EncounterInpatient) {
            Id e_ = EncounterInpatient?.IdElement;
            string f_ = e_?.Value;
            CqlValueSet g_ = this.Sodium_lab_test(context);
            IEnumerable<Observation> h_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, g_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation-lab"));

            bool? i_(Observation SodiumLab) {

                object y_() {

                    bool am_() {
                        DataType ap_ = SodiumLab?.Effective;
                        object aq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ap_);
                        bool ar_ = aq_ is CqlDateTime;
                        return ar_;
                    }


                    bool an_() {
                        DataType as_ = SodiumLab?.Effective;
                        object at_ = FHIRHelpers_4_4_000.Instance.ToValue(context, as_);
                        bool au_ = at_ is CqlDateTime;
                        return au_;
                    }


                    bool ao_() {
                        DataType av_ = SodiumLab?.Effective;
                        object aw_ = FHIRHelpers_4_4_000.Instance.ToValue(context, av_);
                        bool ax_ = aw_ is CqlInterval<CqlDateTime>;
                        return ax_;
                    }

                    if (am_())
                    {
                        DataType ay_ = SodiumLab?.Effective;
                        object az_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ay_);
                        return az_ as CqlDateTime;
                    }
                    else if (an_())
                    {
                        DataType ba_ = SodiumLab?.Effective;
                        object bb_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ba_);
                        return bb_ as CqlDateTime;
                    }
                    else if (ao_())
                    {
                        DataType bc_ = SodiumLab?.Effective;
                        object bd_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bc_);
                        return bd_ as CqlInterval<CqlDateTime>;
                    }
                    else
                    {
                        return null;
                    }
                }

                CqlDateTime z_ = QICoreCommon_4_0_000.Instance.earliest(context, y_());
                CqlInterval<CqlDateTime> aa_ = CQMCommon_4_1_000.Instance.hospitalizationWithObservationAndOutpatientSurgeryService(context, EncounterInpatient);
                bool? ab_ = context.Operators.In<CqlDateTime>(z_, aa_, (string)default);
                Code<ObservationStatus> ac_ = SodiumLab?.StatusElement;
                ObservationStatus? ad_ = ac_?.Value;
                string ae_ = context.Operators.Convert<string>(ad_);
                string[] af_ = [
                    "final",
                    "amended",
                    "corrected",
                ];
                bool? ag_ = context.Operators.In<string>(ae_, (IEnumerable<string>)af_);
                bool? ah_ = context.Operators.And(ab_, ag_);
                DataType ai_ = SodiumLab?.Value;
                object aj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ai_);
                bool? ak_ = context.Operators.Not((bool?)(aj_ is null));
                bool? al_ = context.Operators.And(ah_, ak_);
                return al_;
            }

            IEnumerable<Observation> j_ = context.Operators.Where<Observation>(h_, i_);

            object k_(Observation @this) {
                Instant be_ = @this?.IssuedElement;
                DateTimeOffset? bf_ = be_?.Value;
                CqlDateTime bg_ = context.Operators.Convert<CqlDateTime>(bf_);
                CqlDateTime bh_ = QICoreCommon_4_0_000.Instance.earliest(context, bg_);
                return bh_;
            }

            IEnumerable<Observation> l_ = context.Operators.SortBy<Observation>(j_, k_, System.ComponentModel.ListSortDirection.Ascending);
            Observation m_ = context.Operators.First<Observation>(l_);
            DataType n_ = m_?.Value;
            object o_ = FHIRHelpers_4_4_000.Instance.ToValue(context, n_);

            bool? p_(Observation SodiumLab) {

                object bi_() {

                    bool bw_() {
                        DataType bz_ = SodiumLab?.Effective;
                        object ca_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bz_);
                        bool cb_ = ca_ is CqlDateTime;
                        return cb_;
                    }


                    bool bx_() {
                        DataType cc_ = SodiumLab?.Effective;
                        object cd_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cc_);
                        bool ce_ = cd_ is CqlDateTime;
                        return ce_;
                    }


                    bool by_() {
                        DataType cf_ = SodiumLab?.Effective;
                        object cg_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cf_);
                        bool ch_ = cg_ is CqlInterval<CqlDateTime>;
                        return ch_;
                    }

                    if (bw_())
                    {
                        DataType ci_ = SodiumLab?.Effective;
                        object cj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ci_);
                        return cj_ as CqlDateTime;
                    }
                    else if (bx_())
                    {
                        DataType ck_ = SodiumLab?.Effective;
                        object cl_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ck_);
                        return cl_ as CqlDateTime;
                    }
                    else if (by_())
                    {
                        DataType cm_ = SodiumLab?.Effective;
                        object cn_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cm_);
                        return cn_ as CqlInterval<CqlDateTime>;
                    }
                    else
                    {
                        return null;
                    }
                }

                CqlDateTime bj_ = QICoreCommon_4_0_000.Instance.earliest(context, bi_());
                CqlInterval<CqlDateTime> bk_ = CQMCommon_4_1_000.Instance.hospitalizationWithObservationAndOutpatientSurgeryService(context, EncounterInpatient);
                bool? bl_ = context.Operators.In<CqlDateTime>(bj_, bk_, (string)default);
                Code<ObservationStatus> bm_ = SodiumLab?.StatusElement;
                ObservationStatus? bn_ = bm_?.Value;
                string bo_ = context.Operators.Convert<string>(bn_);
                string[] bp_ = [
                    "final",
                    "amended",
                    "corrected",
                ];
                bool? bq_ = context.Operators.In<string>(bo_, (IEnumerable<string>)bp_);
                bool? br_ = context.Operators.And(bl_, bq_);
                DataType bs_ = SodiumLab?.Value;
                object bt_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bs_);
                bool? bu_ = context.Operators.Not((bool?)(bt_ is null));
                bool? bv_ = context.Operators.And(br_, bu_);
                return bv_;
            }

            IEnumerable<Observation> q_ = context.Operators.Where<Observation>(h_, p_);

            object r_(Observation @this) {
                Instant co_ = @this?.IssuedElement;
                DateTimeOffset? cp_ = co_?.Value;
                CqlDateTime cq_ = context.Operators.Convert<CqlDateTime>(cp_);
                CqlDateTime cr_ = QICoreCommon_4_0_000.Instance.earliest(context, cq_);
                return cr_;
            }

            IEnumerable<Observation> s_ = context.Operators.SortBy<Observation>(q_, r_, System.ComponentModel.ListSortDirection.Ascending);
            Observation t_ = context.Operators.First<Observation>(s_);
            Instant u_ = t_?.IssuedElement;
            DateTimeOffset? v_ = u_?.Value;
            CqlDateTime w_ = context.Operators.Convert<CqlDateTime>(v_);
            (CqlTupleMetadata, string EncounterId, CqlQuantity FirstSodiumResult, CqlDateTime Timing)? x_ = (CqlTupleMetadata_GKGeLARADLGJcNcZaDhdCREMa, f_, o_ as CqlQuantity, w_);
            return x_;
        }

        IEnumerable<(CqlTupleMetadata, string EncounterId, CqlQuantity FirstSodiumResult, CqlDateTime Timing)?> c_ = context.Operators.Select<Encounter, (CqlTupleMetadata, string EncounterId, CqlQuantity FirstSodiumResult, CqlDateTime Timing)?>(a_, b_);
        IEnumerable<(CqlTupleMetadata, string EncounterId, CqlQuantity FirstSodiumResult, CqlDateTime Timing)?> d_ = context.Operators.Distinct<(CqlTupleMetadata, string EncounterId, CqlQuantity FirstSodiumResult, CqlDateTime Timing)?>(c_);
        return d_;
    }


    [CqlExpressionDefinition("SDE Encounter With First White Blood Cells Lab Test")]
    public IEnumerable<(CqlTupleMetadata, string EncounterId, CqlQuantity FirstWhiteBloodCellResult, CqlDateTime Timing)?> SDE_Encounter_With_First_White_Blood_Cells_Lab_Test(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_SDE_Encounter_With_First_White_Blood_Cells_Lab_Test, SDE_Encounter_With_First_White_Blood_Cells_Lab_Test_Compute);

    private const long _cacheIndex_SDE_Encounter_With_First_White_Blood_Cells_Lab_Test = -5465861473556378136L;

    private IEnumerable<(CqlTupleMetadata, string EncounterId, CqlQuantity FirstWhiteBloodCellResult, CqlDateTime Timing)?> SDE_Encounter_With_First_White_Blood_Cells_Lab_Test_Compute(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Inpatient_Encounters(context);

        (CqlTupleMetadata, string EncounterId, CqlQuantity FirstWhiteBloodCellResult, CqlDateTime Timing)? b_(Encounter EncounterInpatient) {
            Id e_ = EncounterInpatient?.IdElement;
            string f_ = e_?.Value;
            CqlValueSet g_ = this.White_blood_cells_count_lab_test(context);
            IEnumerable<Observation> h_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, g_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation-lab"));

            bool? i_(Observation WhiteBloodCellLab) {

                object y_() {

                    bool am_() {
                        DataType ap_ = WhiteBloodCellLab?.Effective;
                        object aq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ap_);
                        bool ar_ = aq_ is CqlDateTime;
                        return ar_;
                    }


                    bool an_() {
                        DataType as_ = WhiteBloodCellLab?.Effective;
                        object at_ = FHIRHelpers_4_4_000.Instance.ToValue(context, as_);
                        bool au_ = at_ is CqlDateTime;
                        return au_;
                    }


                    bool ao_() {
                        DataType av_ = WhiteBloodCellLab?.Effective;
                        object aw_ = FHIRHelpers_4_4_000.Instance.ToValue(context, av_);
                        bool ax_ = aw_ is CqlInterval<CqlDateTime>;
                        return ax_;
                    }

                    if (am_())
                    {
                        DataType ay_ = WhiteBloodCellLab?.Effective;
                        object az_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ay_);
                        return az_ as CqlDateTime;
                    }
                    else if (an_())
                    {
                        DataType ba_ = WhiteBloodCellLab?.Effective;
                        object bb_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ba_);
                        return bb_ as CqlDateTime;
                    }
                    else if (ao_())
                    {
                        DataType bc_ = WhiteBloodCellLab?.Effective;
                        object bd_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bc_);
                        return bd_ as CqlInterval<CqlDateTime>;
                    }
                    else
                    {
                        return null;
                    }
                }

                CqlDateTime z_ = QICoreCommon_4_0_000.Instance.earliest(context, y_());
                CqlInterval<CqlDateTime> aa_ = CQMCommon_4_1_000.Instance.hospitalizationWithObservationAndOutpatientSurgeryService(context, EncounterInpatient);
                bool? ab_ = context.Operators.In<CqlDateTime>(z_, aa_, (string)default);
                Code<ObservationStatus> ac_ = WhiteBloodCellLab?.StatusElement;
                ObservationStatus? ad_ = ac_?.Value;
                string ae_ = context.Operators.Convert<string>(ad_);
                string[] af_ = [
                    "final",
                    "amended",
                    "corrected",
                ];
                bool? ag_ = context.Operators.In<string>(ae_, (IEnumerable<string>)af_);
                bool? ah_ = context.Operators.And(ab_, ag_);
                DataType ai_ = WhiteBloodCellLab?.Value;
                object aj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ai_);
                bool? ak_ = context.Operators.Not((bool?)(aj_ is null));
                bool? al_ = context.Operators.And(ah_, ak_);
                return al_;
            }

            IEnumerable<Observation> j_ = context.Operators.Where<Observation>(h_, i_);

            object k_(Observation @this) {
                Instant be_ = @this?.IssuedElement;
                DateTimeOffset? bf_ = be_?.Value;
                CqlDateTime bg_ = context.Operators.Convert<CqlDateTime>(bf_);
                CqlDateTime bh_ = QICoreCommon_4_0_000.Instance.earliest(context, bg_);
                return bh_;
            }

            IEnumerable<Observation> l_ = context.Operators.SortBy<Observation>(j_, k_, System.ComponentModel.ListSortDirection.Ascending);
            Observation m_ = context.Operators.First<Observation>(l_);
            DataType n_ = m_?.Value;
            object o_ = FHIRHelpers_4_4_000.Instance.ToValue(context, n_);

            bool? p_(Observation WhiteBloodCellLab) {

                object bi_() {

                    bool bw_() {
                        DataType bz_ = WhiteBloodCellLab?.Effective;
                        object ca_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bz_);
                        bool cb_ = ca_ is CqlDateTime;
                        return cb_;
                    }


                    bool bx_() {
                        DataType cc_ = WhiteBloodCellLab?.Effective;
                        object cd_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cc_);
                        bool ce_ = cd_ is CqlDateTime;
                        return ce_;
                    }


                    bool by_() {
                        DataType cf_ = WhiteBloodCellLab?.Effective;
                        object cg_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cf_);
                        bool ch_ = cg_ is CqlInterval<CqlDateTime>;
                        return ch_;
                    }

                    if (bw_())
                    {
                        DataType ci_ = WhiteBloodCellLab?.Effective;
                        object cj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ci_);
                        return cj_ as CqlDateTime;
                    }
                    else if (bx_())
                    {
                        DataType ck_ = WhiteBloodCellLab?.Effective;
                        object cl_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ck_);
                        return cl_ as CqlDateTime;
                    }
                    else if (by_())
                    {
                        DataType cm_ = WhiteBloodCellLab?.Effective;
                        object cn_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cm_);
                        return cn_ as CqlInterval<CqlDateTime>;
                    }
                    else
                    {
                        return null;
                    }
                }

                CqlDateTime bj_ = QICoreCommon_4_0_000.Instance.earliest(context, bi_());
                CqlInterval<CqlDateTime> bk_ = CQMCommon_4_1_000.Instance.hospitalizationWithObservationAndOutpatientSurgeryService(context, EncounterInpatient);
                bool? bl_ = context.Operators.In<CqlDateTime>(bj_, bk_, (string)default);
                Code<ObservationStatus> bm_ = WhiteBloodCellLab?.StatusElement;
                ObservationStatus? bn_ = bm_?.Value;
                string bo_ = context.Operators.Convert<string>(bn_);
                string[] bp_ = [
                    "final",
                    "amended",
                    "corrected",
                ];
                bool? bq_ = context.Operators.In<string>(bo_, (IEnumerable<string>)bp_);
                bool? br_ = context.Operators.And(bl_, bq_);
                DataType bs_ = WhiteBloodCellLab?.Value;
                object bt_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bs_);
                bool? bu_ = context.Operators.Not((bool?)(bt_ is null));
                bool? bv_ = context.Operators.And(br_, bu_);
                return bv_;
            }

            IEnumerable<Observation> q_ = context.Operators.Where<Observation>(h_, p_);

            object r_(Observation @this) {
                Instant co_ = @this?.IssuedElement;
                DateTimeOffset? cp_ = co_?.Value;
                CqlDateTime cq_ = context.Operators.Convert<CqlDateTime>(cp_);
                CqlDateTime cr_ = QICoreCommon_4_0_000.Instance.earliest(context, cq_);
                return cr_;
            }

            IEnumerable<Observation> s_ = context.Operators.SortBy<Observation>(q_, r_, System.ComponentModel.ListSortDirection.Ascending);
            Observation t_ = context.Operators.First<Observation>(s_);
            Instant u_ = t_?.IssuedElement;
            DateTimeOffset? v_ = u_?.Value;
            CqlDateTime w_ = context.Operators.Convert<CqlDateTime>(v_);
            (CqlTupleMetadata, string EncounterId, CqlQuantity FirstWhiteBloodCellResult, CqlDateTime Timing)? x_ = (CqlTupleMetadata_ChVYCdXDGgVcFTCCUefXMbCHX, f_, o_ as CqlQuantity, w_);
            return x_;
        }

        IEnumerable<(CqlTupleMetadata, string EncounterId, CqlQuantity FirstWhiteBloodCellResult, CqlDateTime Timing)?> c_ = context.Operators.Select<Encounter, (CqlTupleMetadata, string EncounterId, CqlQuantity FirstWhiteBloodCellResult, CqlDateTime Timing)?>(a_, b_);
        IEnumerable<(CqlTupleMetadata, string EncounterId, CqlQuantity FirstWhiteBloodCellResult, CqlDateTime Timing)?> d_ = context.Operators.Distinct<(CqlTupleMetadata, string EncounterId, CqlQuantity FirstWhiteBloodCellResult, CqlDateTime Timing)?>(c_);
        return d_;
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
                FhirDateTime w_ = OxygenTherapyOrder?.AuthoredOnElement;
                CqlDateTime x_ = context.Operators.Convert<CqlDateTime>(w_);
                Encounter y_ = CQMCommon_4_1_000.Instance.edVisit(context, EncounterInpatient);
                Period z_ = y_?.Period;
                CqlInterval<CqlDateTime> aa_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, z_);
                bool? ab_ = context.Operators.In<CqlDateTime>(x_, aa_, (string)default);
                CqlDateTime ac_ = context.Operators.Start(aa_);
                CqlQuantity ad_ = context.Operators.Quantity(60m, "minutes");
                CqlDateTime ae_ = context.Operators.Subtract(ac_, ad_);
                CqlInterval<CqlDateTime> af_ = context.Operators.Interval(ae_, ac_, true, true);
                bool? ag_ = context.Operators.In<CqlDateTime>(x_, af_, (string)default);
                bool? ah_ = context.Operators.Not((bool?)(ac_ is null));
                bool? ai_ = context.Operators.And(ag_, ah_);
                bool? aj_ = context.Operators.Or(ab_, ai_);
                Code<RequestStatus> ak_ = OxygenTherapyOrder?.StatusElement;
                RequestStatus? al_ = ak_?.Value;
                Code<RequestStatus> am_ = context.Operators.Convert<Code<RequestStatus>>(al_);
                string an_ = context.Operators.Convert<string>(am_);
                string[] ao_ = [
                    "active",
                    "completed",
                ];
                bool? ap_ = context.Operators.In<string>(an_, (IEnumerable<string>)ao_);
                bool? aq_ = context.Operators.And(aj_, ap_);
                Code<RequestIntent> ar_ = OxygenTherapyOrder?.IntentElement;
                RequestIntent? as_ = ar_?.Value;
                Code<RequestIntent> at_ = context.Operators.Convert<Code<RequestIntent>>(as_);
                bool? au_ = context.Operators.Equal(at_, "order");
                bool? av_ = context.Operators.And(aq_, au_);
                return av_;
            }

            IEnumerable<ServiceRequest> j_ = context.Operators.Where<ServiceRequest>(h_, i_);

            (CqlTupleMetadata, string EncounterId, Code<RequestStatus> OrderStatus, CqlDateTime OrderTiming)? k_(ServiceRequest OxygenTherapyOrder) {
                Id aw_ = EncounterInpatient?.IdElement;
                string ax_ = aw_?.Value;
                Code<RequestStatus> ay_ = OxygenTherapyOrder?.StatusElement;
                RequestStatus? az_ = ay_?.Value;
                Code<RequestStatus> ba_ = context.Operators.Convert<Code<RequestStatus>>(az_);
                FhirDateTime bb_ = OxygenTherapyOrder?.AuthoredOnElement;
                CqlDateTime bc_ = context.Operators.Convert<CqlDateTime>(bb_);
                (CqlTupleMetadata, string EncounterId, Code<RequestStatus> OrderStatus, CqlDateTime OrderTiming)? bd_ = (CqlTupleMetadata_BTRiFTXPQGKeiLWUSieghMWCU, ax_, ba_, bc_);
                return bd_;
            }

            IEnumerable<(CqlTupleMetadata, string EncounterId, Code<RequestStatus> OrderStatus, CqlDateTime OrderTiming)?> l_ = context.Operators.Select<ServiceRequest, (CqlTupleMetadata, string EncounterId, Code<RequestStatus> OrderStatus, CqlDateTime OrderTiming)?>(j_, k_);
            IEnumerable<(CqlTupleMetadata, string EncounterId, Code<RequestStatus> OrderStatus, CqlDateTime OrderTiming)?> m_ = context.Operators.Distinct<(CqlTupleMetadata, string EncounterId, Code<RequestStatus> OrderStatus, CqlDateTime OrderTiming)?>(l_);
            bool? n_ = context.Operators.Exists<(CqlTupleMetadata, string EncounterId, Code<RequestStatus> OrderStatus, CqlDateTime OrderTiming)?>(m_);
            IEnumerable<Procedure> o_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, d_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));

            bool? p_(Procedure OxygenAdminInterv) {

                object be_() {

                    bool cb_() {
                        DataType cf_ = OxygenAdminInterv?.Performed;
                        object cg_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cf_);
                        bool ch_ = cg_ is CqlDateTime;
                        return ch_;
                    }


                    bool cc_() {
                        DataType ci_ = OxygenAdminInterv?.Performed;
                        object cj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ci_);
                        bool ck_ = cj_ is CqlQuantity;
                        return ck_;
                    }


                    bool cd_() {
                        DataType cl_ = OxygenAdminInterv?.Performed;
                        object cm_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cl_);
                        bool cn_ = cm_ is CqlInterval<CqlDateTime>;
                        return cn_;
                    }


                    bool ce_() {
                        DataType co_ = OxygenAdminInterv?.Performed;
                        object cp_ = FHIRHelpers_4_4_000.Instance.ToValue(context, co_);
                        bool cq_ = cp_ is CqlInterval<CqlQuantity>;
                        return cq_;
                    }

                    if (cb_())
                    {
                        DataType cr_ = OxygenAdminInterv?.Performed;
                        object cs_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cr_);
                        return cs_ as CqlDateTime;
                    }
                    else if (cc_())
                    {
                        DataType ct_ = OxygenAdminInterv?.Performed;
                        object cu_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ct_);
                        return cu_ as CqlQuantity;
                    }
                    else if (cd_())
                    {
                        DataType cv_ = OxygenAdminInterv?.Performed;
                        object cw_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cv_);
                        return cw_ as CqlInterval<CqlDateTime>;
                    }
                    else if (ce_())
                    {
                        DataType cx_ = OxygenAdminInterv?.Performed;
                        object cy_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cx_);
                        return cy_ as CqlInterval<CqlQuantity>;
                    }
                    else
                    {
                        return null;
                    }
                }

                CqlInterval<CqlDateTime> bf_ = QICoreCommon_4_0_000.Instance.toInterval(context, be_());
                CqlDateTime bg_ = context.Operators.Start(bf_);
                Encounter bh_ = CQMCommon_4_1_000.Instance.edVisit(context, EncounterInpatient);
                Period bi_ = bh_?.Period;
                CqlInterval<CqlDateTime> bj_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, bi_);
                bool? bk_ = context.Operators.In<CqlDateTime>(bg_, bj_, (string)default);

                object bl_() {

                    bool cz_() {
                        DataType dd_ = OxygenAdminInterv?.Performed;
                        object de_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dd_);
                        bool df_ = de_ is CqlDateTime;
                        return df_;
                    }


                    bool da_() {
                        DataType dg_ = OxygenAdminInterv?.Performed;
                        object dh_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dg_);
                        bool di_ = dh_ is CqlQuantity;
                        return di_;
                    }


                    bool db_() {
                        DataType dj_ = OxygenAdminInterv?.Performed;
                        object dk_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dj_);
                        bool dl_ = dk_ is CqlInterval<CqlDateTime>;
                        return dl_;
                    }


                    bool dc_() {
                        DataType dm_ = OxygenAdminInterv?.Performed;
                        object dn_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dm_);
                        bool do_ = dn_ is CqlInterval<CqlQuantity>;
                        return do_;
                    }

                    if (cz_())
                    {
                        DataType dp_ = OxygenAdminInterv?.Performed;
                        object dq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dp_);
                        return dq_ as CqlDateTime;
                    }
                    else if (da_())
                    {
                        DataType dr_ = OxygenAdminInterv?.Performed;
                        object ds_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dr_);
                        return ds_ as CqlQuantity;
                    }
                    else if (db_())
                    {
                        DataType dt_ = OxygenAdminInterv?.Performed;
                        object du_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dt_);
                        return du_ as CqlInterval<CqlDateTime>;
                    }
                    else if (dc_())
                    {
                        DataType dv_ = OxygenAdminInterv?.Performed;
                        object dw_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dv_);
                        return dw_ as CqlInterval<CqlQuantity>;
                    }
                    else
                    {
                        return null;
                    }
                }

                CqlInterval<CqlDateTime> bm_ = QICoreCommon_4_0_000.Instance.toInterval(context, bl_());
                CqlDateTime bn_ = context.Operators.End(bm_);
                CqlDateTime bo_ = context.Operators.Start(bj_);
                CqlQuantity bp_ = context.Operators.Quantity(60m, "minutes");
                CqlDateTime bq_ = context.Operators.Subtract(bo_, bp_);
                CqlInterval<CqlDateTime> br_ = context.Operators.Interval(bq_, bo_, true, true);
                bool? bs_ = context.Operators.In<CqlDateTime>(bn_, br_, (string)default);
                bool? bt_ = context.Operators.Not((bool?)(bo_ is null));
                bool? bu_ = context.Operators.And(bs_, bt_);
                bool? bv_ = context.Operators.Or(bk_, bu_);
                Code<EventStatus> bw_ = OxygenAdminInterv?.StatusElement;
                EventStatus? bx_ = bw_?.Value;
                string by_ = context.Operators.Convert<string>(bx_);
                bool? bz_ = context.Operators.Equal(by_, "completed");
                bool? ca_ = context.Operators.And(bv_, bz_);
                return ca_;
            }

            IEnumerable<Procedure> q_ = context.Operators.Where<Procedure>(o_, p_);

            (CqlTupleMetadata, string EncounterId, CqlInterval<CqlDateTime> EDEncounterTiming, string PerformedStatus, CqlInterval<CqlDateTime> PerformedTiming)? r_(Procedure OxygenAdminInterv) {
                Id dx_ = EncounterInpatient?.IdElement;
                string dy_ = dx_?.Value;
                Encounter dz_ = CQMCommon_4_1_000.Instance.edVisit(context, EncounterInpatient);
                Period ea_ = dz_?.Period;
                CqlInterval<CqlDateTime> eb_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ea_);
                Code<EventStatus> ec_ = OxygenAdminInterv?.StatusElement;
                EventStatus? ed_ = ec_?.Value;
                string ee_ = context.Operators.Convert<string>(ed_);

                object ef_() {

                    bool ei_() {
                        DataType em_ = OxygenAdminInterv?.Performed;
                        object en_ = FHIRHelpers_4_4_000.Instance.ToValue(context, em_);
                        bool eo_ = en_ is CqlDateTime;
                        return eo_;
                    }


                    bool ej_() {
                        DataType ep_ = OxygenAdminInterv?.Performed;
                        object eq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ep_);
                        bool er_ = eq_ is CqlQuantity;
                        return er_;
                    }


                    bool ek_() {
                        DataType es_ = OxygenAdminInterv?.Performed;
                        object et_ = FHIRHelpers_4_4_000.Instance.ToValue(context, es_);
                        bool eu_ = et_ is CqlInterval<CqlDateTime>;
                        return eu_;
                    }


                    bool el_() {
                        DataType ev_ = OxygenAdminInterv?.Performed;
                        object ew_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ev_);
                        bool ex_ = ew_ is CqlInterval<CqlQuantity>;
                        return ex_;
                    }

                    if (ei_())
                    {
                        DataType ey_ = OxygenAdminInterv?.Performed;
                        object ez_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ey_);
                        return ez_ as CqlDateTime;
                    }
                    else if (ej_())
                    {
                        DataType fa_ = OxygenAdminInterv?.Performed;
                        object fb_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fa_);
                        return fb_ as CqlQuantity;
                    }
                    else if (ek_())
                    {
                        DataType fc_ = OxygenAdminInterv?.Performed;
                        object fd_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fc_);
                        return fd_ as CqlInterval<CqlDateTime>;
                    }
                    else if (el_())
                    {
                        DataType fe_ = OxygenAdminInterv?.Performed;
                        object ff_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fe_);
                        return ff_ as CqlInterval<CqlQuantity>;
                    }
                    else
                    {
                        return null;
                    }
                }

                CqlInterval<CqlDateTime> eg_ = QICoreCommon_4_0_000.Instance.toInterval(context, ef_());
                (CqlTupleMetadata, string EncounterId, CqlInterval<CqlDateTime> EDEncounterTiming, string PerformedStatus, CqlInterval<CqlDateTime> PerformedTiming)? eh_ = (CqlTupleMetadata_HBSiHLDibCXHQcPZYMVBgXBIH, dy_, eb_, ee_, eg_);
                return eh_;
            }

            IEnumerable<(CqlTupleMetadata, string EncounterId, CqlInterval<CqlDateTime> EDEncounterTiming, string PerformedStatus, CqlInterval<CqlDateTime> PerformedTiming)?> s_ = context.Operators.Select<Procedure, (CqlTupleMetadata, string EncounterId, CqlInterval<CqlDateTime> EDEncounterTiming, string PerformedStatus, CqlInterval<CqlDateTime> PerformedTiming)?>(q_, r_);
            IEnumerable<(CqlTupleMetadata, string EncounterId, CqlInterval<CqlDateTime> EDEncounterTiming, string PerformedStatus, CqlInterval<CqlDateTime> PerformedTiming)?> t_ = context.Operators.Distinct<(CqlTupleMetadata, string EncounterId, CqlInterval<CqlDateTime> EDEncounterTiming, string PerformedStatus, CqlInterval<CqlDateTime> PerformedTiming)?>(s_);
            bool? u_ = context.Operators.Exists<(CqlTupleMetadata, string EncounterId, CqlInterval<CqlDateTime> EDEncounterTiming, string PerformedStatus, CqlInterval<CqlDateTime> PerformedTiming)?>(t_);
            bool? v_ = context.Operators.Or(n_, u_);
            return v_;
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

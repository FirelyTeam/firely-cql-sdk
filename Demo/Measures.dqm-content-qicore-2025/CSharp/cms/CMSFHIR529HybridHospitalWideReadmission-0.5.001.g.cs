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

[System.CodeDom.Compiler.GeneratedCode(".NET Code Generation", "5.3.4.0")]
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
                CqlBoolean n_ = context.Operators.Less(m_, 365);

                CqlBoolean o_() {
                    Code<Encounter.EncounterStatus> r_ = InpatientEncounter?.StatusElement;
                    Encounter.EncounterStatus? s_ = r_?.Value;
                    Code<Encounter.EncounterStatus> t_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(s_);
                    CqlBoolean u_ = context.Operators.Equal(t_, "finished");
                    return u_;
                }


                CqlBoolean p_() {
                    Patient v_ = this.Patient(context);
                    Date w_ = v_?.BirthDateElement;
                    string x_ = w_?.Value;
                    CqlDate y_ = context.Operators.ConvertStringToDate(x_);
                    Period z_ = InpatientEncounter?.Period;
                    CqlInterval<CqlDateTime> aa_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, z_);
                    CqlDateTime ab_ = context.Operators.Start(aa_);
                    CqlDate ac_ = context.Operators.DateFrom(ab_);
                    int? ad_ = context.Operators.CalculateAgeAt(y_, ac_, "year");
                    CqlBoolean ae_ = context.Operators.GreaterOrEqual(ad_, 65);
                    return ae_;
                }


                CqlBoolean q_() {
                    Period af_ = InpatientEncounter?.Period;
                    CqlInterval<CqlDateTime> ag_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, af_);
                    CqlDateTime ah_ = context.Operators.End(ag_);
                    CqlInterval<CqlDateTime> ai_ = this.Measurement_Period(context);
                    CqlBoolean aj_ = context.Operators.In<CqlDateTime>(ah_, ai_, "day");
                    return aj_;
                }

                return /* CQL 'and' (40:17-43:77) */ (/* CQL 'and' (40:17-42:76) */ (/* CQL 'and' (40:17-41:50) */ (n_
                    && o_())
                    && p_())
                    && q_());
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
                CqlBoolean aa_ = context.Operators.In<CqlDateTime>(y_, z_, (string)default);

                CqlBoolean ab_() {
                    Code<ObservationStatus> ad_ = Temperature?.StatusElement;
                    ObservationStatus? ae_ = ad_?.Value;
                    string af_ = context.Operators.Convert<string>(ae_);
                    string[] ag_ = [
                        "final",
                        "amended",
                        "corrected",
                    ];
                    CqlBoolean ah_ = context.Operators.In<string>(af_, (IEnumerable<string>)ag_);
                    return ah_;
                }


                CqlBoolean ac_() {
                    DataType ai_ = Temperature?.Value;
                    CqlQuantity aj_ = FHIRHelpers_4_4_000.Instance.ToQuantity(context, ai_ as Quantity);
                    return !((bool?)(aj_ is null));
                }

                return /* CQL 'and' (48:9-50:43) */ (/* CQL 'and' (48:15-49:71) */ (aa_
                    && ab_())
                    && ac_());
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

                CqlBoolean as_() {
                    Code<ObservationStatus> au_ = Temperature?.StatusElement;
                    ObservationStatus? av_ = au_?.Value;
                    string aw_ = context.Operators.Convert<string>(av_);
                    string[] ax_ = [
                        "final",
                        "amended",
                        "corrected",
                    ];
                    CqlBoolean ay_ = context.Operators.In<string>(aw_, (IEnumerable<string>)ax_);
                    return ay_;
                }


                CqlBoolean at_() {
                    DataType az_ = Temperature?.Value;
                    CqlQuantity ba_ = FHIRHelpers_4_4_000.Instance.ToQuantity(context, az_ as Quantity);
                    return !((bool?)(ba_ is null));
                }

                return /* CQL 'and' (48:9-50:43) */ (/* CQL 'and' (48:15-49:71) */ (ar_
                    && as_())
                    && at_());
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
                CqlBoolean aa_ = context.Operators.In<CqlDateTime>(y_, z_, (string)default);

                CqlBoolean ab_() {
                    Code<ObservationStatus> ad_ = HeartRate?.StatusElement;
                    ObservationStatus? ae_ = ad_?.Value;
                    string af_ = context.Operators.Convert<string>(ae_);
                    string[] ag_ = [
                        "final",
                        "amended",
                        "corrected",
                    ];
                    CqlBoolean ah_ = context.Operators.In<string>(af_, (IEnumerable<string>)ag_);
                    return ah_;
                }


                CqlBoolean ac_() {
                    DataType ai_ = HeartRate?.Value;
                    CqlQuantity aj_ = FHIRHelpers_4_4_000.Instance.ToQuantity(context, ai_ as Quantity);
                    return !((bool?)(aj_ is null));
                }

                return /* CQL 'and' (62:9-64:41) */ (/* CQL 'and' (62:15-63:69) */ (aa_
                    && ab_())
                    && ac_());
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

                CqlBoolean as_() {
                    Code<ObservationStatus> au_ = HeartRate?.StatusElement;
                    ObservationStatus? av_ = au_?.Value;
                    string aw_ = context.Operators.Convert<string>(av_);
                    string[] ax_ = [
                        "final",
                        "amended",
                        "corrected",
                    ];
                    CqlBoolean ay_ = context.Operators.In<string>(aw_, (IEnumerable<string>)ax_);
                    return ay_;
                }


                CqlBoolean at_() {
                    DataType az_ = HeartRate?.Value;
                    CqlQuantity ba_ = FHIRHelpers_4_4_000.Instance.ToQuantity(context, az_ as Quantity);
                    return !((bool?)(ba_ is null));
                }

                return /* CQL 'and' (62:9-64:41) */ (/* CQL 'and' (62:15-63:69) */ (ar_
                    && as_())
                    && at_());
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
                CqlBoolean ab_ = context.Operators.In<CqlDateTime>(z_, aa_, (string)default);

                CqlBoolean ac_() {
                    Code<ObservationStatus> ae_ = O2Saturation?.StatusElement;
                    ObservationStatus? af_ = ae_?.Value;
                    string ag_ = context.Operators.Convert<string>(af_);
                    string[] ah_ = [
                        "final",
                        "amended",
                        "corrected",
                    ];
                    CqlBoolean ai_ = context.Operators.In<string>(ag_, (IEnumerable<string>)ah_);
                    return ai_;
                }


                CqlBoolean ad_() {
                    DataType aj_ = O2Saturation?.Value;
                    CqlQuantity ak_ = FHIRHelpers_4_4_000.Instance.ToQuantity(context, aj_ as Quantity);
                    return !((bool?)(ak_ is null));
                }

                return /* CQL 'and' (76:9-78:44) */ (/* CQL 'and' (76:15-77:72) */ (ab_
                    && ac_())
                    && ad_());
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

                CqlBoolean at_() {
                    Code<ObservationStatus> av_ = O2Saturation?.StatusElement;
                    ObservationStatus? aw_ = av_?.Value;
                    string ax_ = context.Operators.Convert<string>(aw_);
                    string[] ay_ = [
                        "final",
                        "amended",
                        "corrected",
                    ];
                    CqlBoolean az_ = context.Operators.In<string>(ax_, (IEnumerable<string>)ay_);
                    return az_;
                }


                CqlBoolean au_() {
                    DataType ba_ = O2Saturation?.Value;
                    CqlQuantity bb_ = FHIRHelpers_4_4_000.Instance.ToQuantity(context, ba_ as Quantity);
                    return !((bool?)(bb_ is null));
                }

                return /* CQL 'and' (76:9-78:44) */ (/* CQL 'and' (76:15-77:72) */ (as_
                    && at_())
                    && au_());
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
                CqlBoolean aa_ = context.Operators.In<CqlDateTime>(y_, z_, (string)default);

                CqlBoolean ab_() {
                    Code<ObservationStatus> ad_ = Respirations?.StatusElement;
                    ObservationStatus? ae_ = ad_?.Value;
                    string af_ = context.Operators.Convert<string>(ae_);
                    string[] ag_ = [
                        "final",
                        "amended",
                        "corrected",
                    ];
                    CqlBoolean ah_ = context.Operators.In<string>(af_, (IEnumerable<string>)ag_);
                    return ah_;
                }


                CqlBoolean ac_() {
                    DataType ai_ = Respirations?.Value;
                    CqlQuantity aj_ = FHIRHelpers_4_4_000.Instance.ToQuantity(context, ai_ as Quantity);
                    return !((bool?)(aj_ is null));
                }

                return /* CQL 'and' (90:9-92:44) */ (/* CQL 'and' (90:15-91:72) */ (aa_
                    && ab_())
                    && ac_());
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

            bool? n_(Observation Respirations) {
                DataType an_ = Respirations?.Effective;
                object ao_ = FHIRHelpers_4_4_000.Instance.ToValue(context, an_);
                CqlDateTime ap_ = QICoreCommon_4_0_000.Instance.earliest(context, ao_);
                CqlInterval<CqlDateTime> aq_ = CQMCommon_4_1_000.Instance.hospitalizationWithObservationAndOutpatientSurgeryService(context, EncounterInpatient);
                CqlBoolean ar_ = context.Operators.In<CqlDateTime>(ap_, aq_, (string)default);

                CqlBoolean as_() {
                    Code<ObservationStatus> au_ = Respirations?.StatusElement;
                    ObservationStatus? av_ = au_?.Value;
                    string aw_ = context.Operators.Convert<string>(av_);
                    string[] ax_ = [
                        "final",
                        "amended",
                        "corrected",
                    ];
                    CqlBoolean ay_ = context.Operators.In<string>(aw_, (IEnumerable<string>)ax_);
                    return ay_;
                }


                CqlBoolean at_() {
                    DataType az_ = Respirations?.Value;
                    CqlQuantity ba_ = FHIRHelpers_4_4_000.Instance.ToQuantity(context, az_ as Quantity);
                    return !((bool?)(ba_ is null));
                }

                return /* CQL 'and' (90:9-92:44) */ (/* CQL 'and' (90:15-91:72) */ (ar_
                    && as_())
                    && at_());
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
                CqlBoolean ad_ = context.Operators.In<CqlDateTime>(ab_, ac_, (string)default);

                CqlBoolean ae_() {
                    Code<ObservationStatus> ag_ = BP?.StatusElement;
                    ObservationStatus? ah_ = ag_?.Value;
                    string ai_ = context.Operators.Convert<string>(ah_);
                    string[] aj_ = [
                        "final",
                        "amended",
                        "corrected",
                    ];
                    CqlBoolean ak_ = context.Operators.In<string>(ai_, (IEnumerable<string>)aj_);
                    return ak_;
                }


                CqlBoolean af_() {
                    List<Observation.ComponentComponent> al_ = BP?.Component;

                    bool? am_(Observation.ComponentComponent @this) {
                        DataType ap_ = @this?.Value;
                        object aq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ap_);
                        return !((bool?)(aq_ is null));
                    }


                    object an_(Observation.ComponentComponent @this) {
                        DataType ar_ = @this?.Value;
                        object as_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ar_);
                        return as_;
                    }

                    IEnumerable<object> ao_ = context.Operators.WhereSelect<Observation.ComponentComponent, object>((IEnumerable<Observation.ComponentComponent>)al_, am_, an_);
                    return !((bool?)(ao_ is null));
                }

                return /* CQL 'and' (104:9-106:44) */ (/* CQL 'and' (104:15-105:62) */ (ad_
                    && ae_())
                    && af_());
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

                CqlBoolean bi_() {
                    Code<ObservationStatus> bk_ = BP?.StatusElement;
                    ObservationStatus? bl_ = bk_?.Value;
                    string bm_ = context.Operators.Convert<string>(bl_);
                    string[] bn_ = [
                        "final",
                        "amended",
                        "corrected",
                    ];
                    CqlBoolean bo_ = context.Operators.In<string>(bm_, (IEnumerable<string>)bn_);
                    return bo_;
                }


                CqlBoolean bj_() {
                    List<Observation.ComponentComponent> bp_ = BP?.Component;

                    bool? bq_(Observation.ComponentComponent @this) {
                        DataType bt_ = @this?.Value;
                        object bu_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bt_);
                        return !((bool?)(bu_ is null));
                    }


                    object br_(Observation.ComponentComponent @this) {
                        DataType bv_ = @this?.Value;
                        object bw_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bv_);
                        return bw_;
                    }

                    IEnumerable<object> bs_ = context.Operators.WhereSelect<Observation.ComponentComponent, object>((IEnumerable<Observation.ComponentComponent>)bp_, bq_, br_);
                    return !((bool?)(bs_ is null));
                }

                return /* CQL 'and' (104:9-106:44) */ (/* CQL 'and' (104:15-105:62) */ (bh_
                    && bi_())
                    && bj_());
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
                DataType ad_ = bicarbonatelab?.Effective;
                object ae_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ad_);
                bool af_ = ae_ is CqlDateTime;
                if (af_)
                {
                    x_ = ae_ as CqlDateTime;
                }
                else
                {
                    if (af_)
                    {
                        x_ = ae_ as CqlDateTime;
                    }
                    else
                    {
                        bool ag_ = ae_ is CqlInterval<CqlDateTime>;
                        if (ag_)
                        {
                            x_ = ae_ as CqlInterval<CqlDateTime>;
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

                CqlBoolean ab_() {
                    Code<ObservationStatus> ah_ = bicarbonatelab?.StatusElement;
                    ObservationStatus? ai_ = ah_?.Value;
                    string aj_ = context.Operators.Convert<string>(ai_);
                    string[] ak_ = [
                        "final",
                        "amended",
                        "corrected",
                    ];
                    CqlBoolean al_ = context.Operators.In<string>(aj_, (IEnumerable<string>)ak_);
                    return al_;
                }


                CqlBoolean ac_() {
                    DataType am_ = bicarbonatelab?.Value;
                    object an_ = FHIRHelpers_4_4_000.Instance.ToValue(context, am_);
                    return !((bool?)(an_ is null));
                }

                return /* CQL 'and' (120:9-122:46) */ (/* CQL 'and' (120:15-121:74) */ (aa_
                    && ab_())
                    && ac_());
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

            bool? o_(Observation bicarbonatelab) {
                object as_;
                DataType ay_ = bicarbonatelab?.Effective;
                object az_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ay_);
                bool ba_ = az_ is CqlDateTime;
                if (ba_)
                {
                    as_ = az_ as CqlDateTime;
                }
                else
                {
                    if (ba_)
                    {
                        as_ = az_ as CqlDateTime;
                    }
                    else
                    {
                        bool bb_ = az_ is CqlInterval<CqlDateTime>;
                        if (bb_)
                        {
                            as_ = az_ as CqlInterval<CqlDateTime>;
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

                CqlBoolean aw_() {
                    Code<ObservationStatus> bc_ = bicarbonatelab?.StatusElement;
                    ObservationStatus? bd_ = bc_?.Value;
                    string be_ = context.Operators.Convert<string>(bd_);
                    string[] bf_ = [
                        "final",
                        "amended",
                        "corrected",
                    ];
                    CqlBoolean bg_ = context.Operators.In<string>(be_, (IEnumerable<string>)bf_);
                    return bg_;
                }


                CqlBoolean ax_() {
                    DataType bh_ = bicarbonatelab?.Value;
                    object bi_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bh_);
                    return !((bool?)(bi_ is null));
                }

                return /* CQL 'and' (120:9-122:46) */ (/* CQL 'and' (120:15-121:74) */ (av_
                    && aw_())
                    && ax_());
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
                DataType ad_ = CreatinineLab?.Effective;
                object ae_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ad_);
                bool af_ = ae_ is CqlDateTime;
                if (af_)
                {
                    x_ = ae_ as CqlDateTime;
                }
                else
                {
                    if (af_)
                    {
                        x_ = ae_ as CqlDateTime;
                    }
                    else
                    {
                        bool ag_ = ae_ is CqlInterval<CqlDateTime>;
                        if (ag_)
                        {
                            x_ = ae_ as CqlInterval<CqlDateTime>;
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

                CqlBoolean ab_() {
                    Code<ObservationStatus> ah_ = CreatinineLab?.StatusElement;
                    ObservationStatus? ai_ = ah_?.Value;
                    string aj_ = context.Operators.Convert<string>(ai_);
                    string[] ak_ = [
                        "final",
                        "amended",
                        "corrected",
                    ];
                    CqlBoolean al_ = context.Operators.In<string>(aj_, (IEnumerable<string>)ak_);
                    return al_;
                }


                CqlBoolean ac_() {
                    DataType am_ = CreatinineLab?.Value;
                    object an_ = FHIRHelpers_4_4_000.Instance.ToValue(context, am_);
                    return !((bool?)(an_ is null));
                }

                return /* CQL 'and' (134:9-136:45) */ (/* CQL 'and' (134:15-135:73) */ (aa_
                    && ab_())
                    && ac_());
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
                DataType ay_ = CreatinineLab?.Effective;
                object az_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ay_);
                bool ba_ = az_ is CqlDateTime;
                if (ba_)
                {
                    as_ = az_ as CqlDateTime;
                }
                else
                {
                    if (ba_)
                    {
                        as_ = az_ as CqlDateTime;
                    }
                    else
                    {
                        bool bb_ = az_ is CqlInterval<CqlDateTime>;
                        if (bb_)
                        {
                            as_ = az_ as CqlInterval<CqlDateTime>;
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

                CqlBoolean aw_() {
                    Code<ObservationStatus> bc_ = CreatinineLab?.StatusElement;
                    ObservationStatus? bd_ = bc_?.Value;
                    string be_ = context.Operators.Convert<string>(bd_);
                    string[] bf_ = [
                        "final",
                        "amended",
                        "corrected",
                    ];
                    CqlBoolean bg_ = context.Operators.In<string>(be_, (IEnumerable<string>)bf_);
                    return bg_;
                }


                CqlBoolean ax_() {
                    DataType bh_ = CreatinineLab?.Value;
                    object bi_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bh_);
                    return !((bool?)(bi_ is null));
                }

                return /* CQL 'and' (134:9-136:45) */ (/* CQL 'and' (134:15-135:73) */ (av_
                    && aw_())
                    && ax_());
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
                DataType ad_ = GlucoseLab?.Effective;
                object ae_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ad_);
                bool af_ = ae_ is CqlDateTime;
                if (af_)
                {
                    x_ = ae_ as CqlDateTime;
                }
                else
                {
                    if (af_)
                    {
                        x_ = ae_ as CqlDateTime;
                    }
                    else
                    {
                        bool ag_ = ae_ is CqlInterval<CqlDateTime>;
                        if (ag_)
                        {
                            x_ = ae_ as CqlInterval<CqlDateTime>;
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

                CqlBoolean ab_() {
                    Code<ObservationStatus> ah_ = GlucoseLab?.StatusElement;
                    ObservationStatus? ai_ = ah_?.Value;
                    string aj_ = context.Operators.Convert<string>(ai_);
                    string[] ak_ = [
                        "final",
                        "amended",
                        "corrected",
                    ];
                    CqlBoolean al_ = context.Operators.In<string>(aj_, (IEnumerable<string>)ak_);
                    return al_;
                }


                CqlBoolean ac_() {
                    DataType am_ = GlucoseLab?.Value;
                    object an_ = FHIRHelpers_4_4_000.Instance.ToValue(context, am_);
                    return !((bool?)(an_ is null));
                }

                return /* CQL 'and' (148:9-150:42) */ (/* CQL 'and' (148:15-149:70) */ (aa_
                    && ab_())
                    && ac_());
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

            bool? o_(Observation GlucoseLab) {
                object as_;
                DataType ay_ = GlucoseLab?.Effective;
                object az_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ay_);
                bool ba_ = az_ is CqlDateTime;
                if (ba_)
                {
                    as_ = az_ as CqlDateTime;
                }
                else
                {
                    if (ba_)
                    {
                        as_ = az_ as CqlDateTime;
                    }
                    else
                    {
                        bool bb_ = az_ is CqlInterval<CqlDateTime>;
                        if (bb_)
                        {
                            as_ = az_ as CqlInterval<CqlDateTime>;
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

                CqlBoolean aw_() {
                    Code<ObservationStatus> bc_ = GlucoseLab?.StatusElement;
                    ObservationStatus? bd_ = bc_?.Value;
                    string be_ = context.Operators.Convert<string>(bd_);
                    string[] bf_ = [
                        "final",
                        "amended",
                        "corrected",
                    ];
                    CqlBoolean bg_ = context.Operators.In<string>(be_, (IEnumerable<string>)bf_);
                    return bg_;
                }


                CqlBoolean ax_() {
                    DataType bh_ = GlucoseLab?.Value;
                    object bi_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bh_);
                    return !((bool?)(bi_ is null));
                }

                return /* CQL 'and' (148:9-150:42) */ (/* CQL 'and' (148:15-149:70) */ (av_
                    && aw_())
                    && ax_());
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
                DataType ad_ = HematocritLab?.Effective;
                object ae_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ad_);
                bool af_ = ae_ is CqlDateTime;
                if (af_)
                {
                    x_ = ae_ as CqlDateTime;
                }
                else
                {
                    if (af_)
                    {
                        x_ = ae_ as CqlDateTime;
                    }
                    else
                    {
                        bool ag_ = ae_ is CqlInterval<CqlDateTime>;
                        if (ag_)
                        {
                            x_ = ae_ as CqlInterval<CqlDateTime>;
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

                CqlBoolean ab_() {
                    Code<ObservationStatus> ah_ = HematocritLab?.StatusElement;
                    ObservationStatus? ai_ = ah_?.Value;
                    string aj_ = context.Operators.Convert<string>(ai_);
                    string[] ak_ = [
                        "final",
                        "amended",
                        "corrected",
                    ];
                    CqlBoolean al_ = context.Operators.In<string>(aj_, (IEnumerable<string>)ak_);
                    return al_;
                }


                CqlBoolean ac_() {
                    DataType am_ = HematocritLab?.Value;
                    object an_ = FHIRHelpers_4_4_000.Instance.ToValue(context, am_);
                    return !((bool?)(an_ is null));
                }

                return /* CQL 'and' (162:9-164:45) */ (/* CQL 'and' (162:15-163:73) */ (aa_
                    && ab_())
                    && ac_());
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
                DataType ay_ = HematocritLab?.Effective;
                object az_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ay_);
                bool ba_ = az_ is CqlDateTime;
                if (ba_)
                {
                    as_ = az_ as CqlDateTime;
                }
                else
                {
                    if (ba_)
                    {
                        as_ = az_ as CqlDateTime;
                    }
                    else
                    {
                        bool bb_ = az_ is CqlInterval<CqlDateTime>;
                        if (bb_)
                        {
                            as_ = az_ as CqlInterval<CqlDateTime>;
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

                CqlBoolean aw_() {
                    Code<ObservationStatus> bc_ = HematocritLab?.StatusElement;
                    ObservationStatus? bd_ = bc_?.Value;
                    string be_ = context.Operators.Convert<string>(bd_);
                    string[] bf_ = [
                        "final",
                        "amended",
                        "corrected",
                    ];
                    CqlBoolean bg_ = context.Operators.In<string>(be_, (IEnumerable<string>)bf_);
                    return bg_;
                }


                CqlBoolean ax_() {
                    DataType bh_ = HematocritLab?.Value;
                    object bi_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bh_);
                    return !((bool?)(bi_ is null));
                }

                return /* CQL 'and' (162:9-164:45) */ (/* CQL 'and' (162:15-163:73) */ (av_
                    && aw_())
                    && ax_());
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
                DataType ad_ = PotassiumLab?.Effective;
                object ae_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ad_);
                bool af_ = ae_ is CqlDateTime;
                if (af_)
                {
                    x_ = ae_ as CqlDateTime;
                }
                else
                {
                    if (af_)
                    {
                        x_ = ae_ as CqlDateTime;
                    }
                    else
                    {
                        bool ag_ = ae_ is CqlInterval<CqlDateTime>;
                        if (ag_)
                        {
                            x_ = ae_ as CqlInterval<CqlDateTime>;
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

                CqlBoolean ab_() {
                    Code<ObservationStatus> ah_ = PotassiumLab?.StatusElement;
                    ObservationStatus? ai_ = ah_?.Value;
                    string aj_ = context.Operators.Convert<string>(ai_);
                    string[] ak_ = [
                        "final",
                        "amended",
                        "corrected",
                    ];
                    CqlBoolean al_ = context.Operators.In<string>(aj_, (IEnumerable<string>)ak_);
                    return al_;
                }


                CqlBoolean ac_() {
                    DataType am_ = PotassiumLab?.Value;
                    object an_ = FHIRHelpers_4_4_000.Instance.ToValue(context, am_);
                    return !((bool?)(an_ is null));
                }

                return /* CQL 'and' (176:9-178:44) */ (/* CQL 'and' (176:15-177:72) */ (aa_
                    && ab_())
                    && ac_());
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

            bool? o_(Observation PotassiumLab) {
                object as_;
                DataType ay_ = PotassiumLab?.Effective;
                object az_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ay_);
                bool ba_ = az_ is CqlDateTime;
                if (ba_)
                {
                    as_ = az_ as CqlDateTime;
                }
                else
                {
                    if (ba_)
                    {
                        as_ = az_ as CqlDateTime;
                    }
                    else
                    {
                        bool bb_ = az_ is CqlInterval<CqlDateTime>;
                        if (bb_)
                        {
                            as_ = az_ as CqlInterval<CqlDateTime>;
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

                CqlBoolean aw_() {
                    Code<ObservationStatus> bc_ = PotassiumLab?.StatusElement;
                    ObservationStatus? bd_ = bc_?.Value;
                    string be_ = context.Operators.Convert<string>(bd_);
                    string[] bf_ = [
                        "final",
                        "amended",
                        "corrected",
                    ];
                    CqlBoolean bg_ = context.Operators.In<string>(be_, (IEnumerable<string>)bf_);
                    return bg_;
                }


                CqlBoolean ax_() {
                    DataType bh_ = PotassiumLab?.Value;
                    object bi_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bh_);
                    return !((bool?)(bi_ is null));
                }

                return /* CQL 'and' (176:9-178:44) */ (/* CQL 'and' (176:15-177:72) */ (av_
                    && aw_())
                    && ax_());
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
                DataType ad_ = SodiumLab?.Effective;
                object ae_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ad_);
                bool af_ = ae_ is CqlDateTime;
                if (af_)
                {
                    x_ = ae_ as CqlDateTime;
                }
                else
                {
                    if (af_)
                    {
                        x_ = ae_ as CqlDateTime;
                    }
                    else
                    {
                        bool ag_ = ae_ is CqlInterval<CqlDateTime>;
                        if (ag_)
                        {
                            x_ = ae_ as CqlInterval<CqlDateTime>;
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

                CqlBoolean ab_() {
                    Code<ObservationStatus> ah_ = SodiumLab?.StatusElement;
                    ObservationStatus? ai_ = ah_?.Value;
                    string aj_ = context.Operators.Convert<string>(ai_);
                    string[] ak_ = [
                        "final",
                        "amended",
                        "corrected",
                    ];
                    CqlBoolean al_ = context.Operators.In<string>(aj_, (IEnumerable<string>)ak_);
                    return al_;
                }


                CqlBoolean ac_() {
                    DataType am_ = SodiumLab?.Value;
                    object an_ = FHIRHelpers_4_4_000.Instance.ToValue(context, am_);
                    return !((bool?)(an_ is null));
                }

                return /* CQL 'and' (190:9-192:41) */ (/* CQL 'and' (190:15-191:69) */ (aa_
                    && ab_())
                    && ac_());
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
                DataType ay_ = SodiumLab?.Effective;
                object az_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ay_);
                bool ba_ = az_ is CqlDateTime;
                if (ba_)
                {
                    as_ = az_ as CqlDateTime;
                }
                else
                {
                    if (ba_)
                    {
                        as_ = az_ as CqlDateTime;
                    }
                    else
                    {
                        bool bb_ = az_ is CqlInterval<CqlDateTime>;
                        if (bb_)
                        {
                            as_ = az_ as CqlInterval<CqlDateTime>;
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

                CqlBoolean aw_() {
                    Code<ObservationStatus> bc_ = SodiumLab?.StatusElement;
                    ObservationStatus? bd_ = bc_?.Value;
                    string be_ = context.Operators.Convert<string>(bd_);
                    string[] bf_ = [
                        "final",
                        "amended",
                        "corrected",
                    ];
                    CqlBoolean bg_ = context.Operators.In<string>(be_, (IEnumerable<string>)bf_);
                    return bg_;
                }


                CqlBoolean ax_() {
                    DataType bh_ = SodiumLab?.Value;
                    object bi_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bh_);
                    return !((bool?)(bi_ is null));
                }

                return /* CQL 'and' (190:9-192:41) */ (/* CQL 'and' (190:15-191:69) */ (av_
                    && aw_())
                    && ax_());
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
                DataType ad_ = WhiteBloodCellLab?.Effective;
                object ae_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ad_);
                bool af_ = ae_ is CqlDateTime;
                if (af_)
                {
                    x_ = ae_ as CqlDateTime;
                }
                else
                {
                    if (af_)
                    {
                        x_ = ae_ as CqlDateTime;
                    }
                    else
                    {
                        bool ag_ = ae_ is CqlInterval<CqlDateTime>;
                        if (ag_)
                        {
                            x_ = ae_ as CqlInterval<CqlDateTime>;
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

                CqlBoolean ab_() {
                    Code<ObservationStatus> ah_ = WhiteBloodCellLab?.StatusElement;
                    ObservationStatus? ai_ = ah_?.Value;
                    string aj_ = context.Operators.Convert<string>(ai_);
                    string[] ak_ = [
                        "final",
                        "amended",
                        "corrected",
                    ];
                    CqlBoolean al_ = context.Operators.In<string>(aj_, (IEnumerable<string>)ak_);
                    return al_;
                }


                CqlBoolean ac_() {
                    DataType am_ = WhiteBloodCellLab?.Value;
                    object an_ = FHIRHelpers_4_4_000.Instance.ToValue(context, am_);
                    return !((bool?)(an_ is null));
                }

                return /* CQL 'and' (204:9-206:49) */ (/* CQL 'and' (204:15-205:77) */ (aa_
                    && ab_())
                    && ac_());
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
                DataType ay_ = WhiteBloodCellLab?.Effective;
                object az_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ay_);
                bool ba_ = az_ is CqlDateTime;
                if (ba_)
                {
                    as_ = az_ as CqlDateTime;
                }
                else
                {
                    if (ba_)
                    {
                        as_ = az_ as CqlDateTime;
                    }
                    else
                    {
                        bool bb_ = az_ is CqlInterval<CqlDateTime>;
                        if (bb_)
                        {
                            as_ = az_ as CqlInterval<CqlDateTime>;
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

                CqlBoolean aw_() {
                    Code<ObservationStatus> bc_ = WhiteBloodCellLab?.StatusElement;
                    ObservationStatus? bd_ = bc_?.Value;
                    string be_ = context.Operators.Convert<string>(bd_);
                    string[] bf_ = [
                        "final",
                        "amended",
                        "corrected",
                    ];
                    CqlBoolean bg_ = context.Operators.In<string>(be_, (IEnumerable<string>)bf_);
                    return bg_;
                }


                CqlBoolean ax_() {
                    DataType bh_ = WhiteBloodCellLab?.Value;
                    object bi_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bh_);
                    return !((bool?)(bi_ is null));
                }

                return /* CQL 'and' (204:9-206:49) */ (/* CQL 'and' (204:15-205:77) */ (av_
                    && aw_())
                    && ax_());
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
                CqlBoolean aa_ = context.Operators.In<CqlDateTime>(y_, z_, (string)default);

                CqlBoolean ab_() {
                    Code<ObservationStatus> ad_ = WeightExam?.StatusElement;
                    ObservationStatus? ae_ = ad_?.Value;
                    string af_ = context.Operators.Convert<string>(ae_);
                    string[] ag_ = [
                        "final",
                        "amended",
                        "corrected",
                    ];
                    CqlBoolean ah_ = context.Operators.In<string>(af_, (IEnumerable<string>)ag_);
                    return ah_;
                }


                CqlBoolean ac_() {
                    DataType ai_ = WeightExam?.Value;
                    CqlQuantity aj_ = FHIRHelpers_4_4_000.Instance.ToQuantity(context, ai_ as Quantity);
                    return !((bool?)(aj_ is null));
                }

                return /* CQL 'and' (218:9-220:42) */ (/* CQL 'and' (218:15-219:70) */ (aa_
                    && ab_())
                    && ac_());
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

            bool? n_(Observation WeightExam) {
                DataType an_ = WeightExam?.Effective;
                object ao_ = FHIRHelpers_4_4_000.Instance.ToValue(context, an_);
                CqlDateTime ap_ = QICoreCommon_4_0_000.Instance.earliest(context, ao_);
                CqlInterval<CqlDateTime> aq_ = CQMCommon_4_1_000.Instance.hospitalizationWithObservationAndOutpatientSurgeryService(context, EncounterInpatient);
                CqlBoolean ar_ = context.Operators.In<CqlDateTime>(ap_, aq_, (string)default);

                CqlBoolean as_() {
                    Code<ObservationStatus> au_ = WeightExam?.StatusElement;
                    ObservationStatus? av_ = au_?.Value;
                    string aw_ = context.Operators.Convert<string>(av_);
                    string[] ax_ = [
                        "final",
                        "amended",
                        "corrected",
                    ];
                    CqlBoolean ay_ = context.Operators.In<string>(aw_, (IEnumerable<string>)ax_);
                    return ay_;
                }


                CqlBoolean at_() {
                    DataType az_ = WeightExam?.Value;
                    CqlQuantity ba_ = FHIRHelpers_4_4_000.Instance.ToQuantity(context, az_ as Quantity);
                    return !((bool?)(ba_ is null));
                }

                return /* CQL 'and' (218:9-220:42) */ (/* CQL 'and' (218:15-219:70) */ (ar_
                    && as_())
                    && at_());
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
                FhirDateTime o_ = OxygenTherapyOrder?.AuthoredOnElement;
                CqlDateTime p_ = context.Operators.Convert<CqlDateTime>(o_);
                Encounter q_ = CQMCommon_4_1_000.Instance.edVisit(context, EncounterInpatient);
                Period r_ = q_?.Period;
                CqlInterval<CqlDateTime> s_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, r_);
                CqlBoolean t_ = context.Operators.In<CqlDateTime>(p_, s_, (string)default);

                CqlBoolean u_() {
                    FhirDateTime x_ = OxygenTherapyOrder?.AuthoredOnElement;
                    CqlDateTime y_ = context.Operators.Convert<CqlDateTime>(x_);
                    Encounter z_ = CQMCommon_4_1_000.Instance.edVisit(context, EncounterInpatient);
                    Period aa_ = z_?.Period;
                    CqlInterval<CqlDateTime> ab_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, aa_);
                    CqlDateTime ac_ = context.Operators.Start(ab_);
                    CqlQuantity ad_ = context.Operators.Quantity(60m, "minutes");
                    CqlDateTime ae_ = context.Operators.Subtract(ac_, ad_);
                    CqlInterval<CqlDateTime> af_ = context.Operators.Interval(ae_, ac_, true, true);
                    CqlBoolean ag_ = context.Operators.In<CqlDateTime>(y_, af_, (string)default);

                    CqlBoolean ah_() {
                        Encounter ai_ = CQMCommon_4_1_000.Instance.edVisit(context, EncounterInpatient);
                        Period aj_ = ai_?.Period;
                        CqlInterval<CqlDateTime> ak_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, aj_);
                        CqlDateTime al_ = context.Operators.Start(ak_);
                        return !((bool?)(al_ is null));
                    }

                    return /* CQL 'and' (234:16-234:123) */ (ag_
                        && ah_());
                }


                CqlBoolean v_() {
                    Code<RequestStatus> am_ = OxygenTherapyOrder?.StatusElement;
                    RequestStatus? an_ = am_?.Value;
                    Code<RequestStatus> ao_ = context.Operators.Convert<Code<RequestStatus>>(an_);
                    string ap_ = context.Operators.Convert<string>(ao_);
                    string[] aq_ = [
                        "active",
                        "completed",
                    ];
                    CqlBoolean ar_ = context.Operators.In<string>(ap_, (IEnumerable<string>)aq_);
                    return ar_;
                }


                CqlBoolean w_() {
                    Code<RequestIntent> as_ = OxygenTherapyOrder?.IntentElement;
                    RequestIntent? at_ = as_?.Value;
                    Code<RequestIntent> au_ = context.Operators.Convert<Code<RequestIntent>>(at_);
                    CqlBoolean av_ = context.Operators.Equal(au_, "order");
                    return av_;
                }

                return /* CQL 'and' (233:9-237:49) */ (/* CQL 'and' (233:15-236:68) */ (/* CQL 'or' (233:15-235:9) */ (t_
                    || u_())
                    && v_())
                    && w_());
            }


            (CqlTupleMetadata, string EncounterId, Code<RequestStatus> OrderStatus, CqlDateTime OrderTiming)? j_(ServiceRequest OxygenTherapyOrder) {
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

            IEnumerable<(CqlTupleMetadata, string EncounterId, Code<RequestStatus> OrderStatus, CqlDateTime OrderTiming)?> k_ = context.Operators.WhereSelect<ServiceRequest, (CqlTupleMetadata, string EncounterId, Code<RequestStatus> OrderStatus, CqlDateTime OrderTiming)?>(h_, i_, j_);
            IEnumerable<(CqlTupleMetadata, string EncounterId, Code<RequestStatus> OrderStatus, CqlDateTime OrderTiming)?> l_ = context.Operators.Distinct<(CqlTupleMetadata, string EncounterId, Code<RequestStatus> OrderStatus, CqlDateTime OrderTiming)?>(k_);
            CqlBoolean m_ = context.Operators.Exists<(CqlTupleMetadata, string EncounterId, Code<RequestStatus> OrderStatus, CqlDateTime OrderTiming)?>(l_);

            CqlBoolean n_() {
                CqlValueSet be_ = this.Non_Invasive_Oxygen_Therapy_by_Nasal_Cannula_or_Mask(context);
                IEnumerable<Procedure> bf_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, be_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));

                bool? bg_(Procedure OxygenAdminInterv) {
                    object bl_;
                    DataType bu_ = OxygenAdminInterv?.Performed;
                    object bv_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bu_);
                    bool bw_ = bv_ is CqlDateTime;
                    if (bw_)
                    {
                        bl_ = bv_ as CqlDateTime;
                    }
                    else
                    {
                        bool bx_ = bv_ is CqlQuantity;
                        if (bx_)
                        {
                            bl_ = bv_ as CqlQuantity;
                        }
                        else
                        {
                            bool by_ = bv_ is CqlInterval<CqlDateTime>;
                            if (by_)
                            {
                                bl_ = bv_ as CqlInterval<CqlDateTime>;
                            }
                            else
                            {
                                bool bz_ = bv_ is CqlInterval<CqlQuantity>;
                                if (bz_)
                                {
                                    bl_ = bv_ as CqlInterval<CqlQuantity>;
                                }
                                else
                                {
                                    bl_ = null;
                                }
                            }
                        }
                    }
                    CqlInterval<CqlDateTime> bm_ = QICoreCommon_4_0_000.Instance.toInterval(context, bl_);
                    CqlDateTime bn_ = context.Operators.Start(bm_);
                    Encounter bo_ = CQMCommon_4_1_000.Instance.edVisit(context, EncounterInpatient);
                    Period bp_ = bo_?.Period;
                    CqlInterval<CqlDateTime> bq_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, bp_);
                    CqlBoolean br_ = context.Operators.In<CqlDateTime>(bn_, bq_, (string)default);

                    CqlBoolean bs_() {
                        object ca_;
                        DataType cm_ = OxygenAdminInterv?.Performed;
                        object cn_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cm_);
                        bool co_ = cn_ is CqlDateTime;
                        if (co_)
                        {
                            ca_ = cn_ as CqlDateTime;
                        }
                        else
                        {
                            bool cp_ = cn_ is CqlQuantity;
                            if (cp_)
                            {
                                ca_ = cn_ as CqlQuantity;
                            }
                            else
                            {
                                bool cq_ = cn_ is CqlInterval<CqlDateTime>;
                                if (cq_)
                                {
                                    ca_ = cn_ as CqlInterval<CqlDateTime>;
                                }
                                else
                                {
                                    bool cr_ = cn_ is CqlInterval<CqlQuantity>;
                                    if (cr_)
                                    {
                                        ca_ = cn_ as CqlInterval<CqlQuantity>;
                                    }
                                    else
                                    {
                                        ca_ = null;
                                    }
                                }
                            }
                        }
                        CqlInterval<CqlDateTime> cb_ = QICoreCommon_4_0_000.Instance.toInterval(context, ca_);
                        CqlDateTime cc_ = context.Operators.End(cb_);
                        Encounter cd_ = CQMCommon_4_1_000.Instance.edVisit(context, EncounterInpatient);
                        Period ce_ = cd_?.Period;
                        CqlInterval<CqlDateTime> cf_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ce_);
                        CqlDateTime cg_ = context.Operators.Start(cf_);
                        CqlQuantity ch_ = context.Operators.Quantity(60m, "minutes");
                        CqlDateTime ci_ = context.Operators.Subtract(cg_, ch_);
                        CqlInterval<CqlDateTime> cj_ = context.Operators.Interval(ci_, cg_, true, true);
                        CqlBoolean ck_ = context.Operators.In<CqlDateTime>(cc_, cj_, (string)default);

                        CqlBoolean cl_() {
                            Encounter cs_ = CQMCommon_4_1_000.Instance.edVisit(context, EncounterInpatient);
                            Period ct_ = cs_?.Period;
                            CqlInterval<CqlDateTime> cu_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ct_);
                            CqlDateTime cv_ = context.Operators.Start(cu_);
                            return !((bool?)(cv_ is null));
                        }

                        return /* CQL 'and' (246:18-246:138) */ (ck_
                            && cl_());
                    }


                    CqlBoolean bt_() {
                        Code<EventStatus> cw_ = OxygenAdminInterv?.StatusElement;
                        EventStatus? cx_ = cw_?.Value;
                        string cy_ = context.Operators.Convert<string>(cx_);
                        CqlBoolean cz_ = context.Operators.Equal(cy_, "completed");
                        return cz_;
                    }

                    return /* CQL 'and' (245:11-248:54) */ (/* CQL 'or' (245:17-247:11) */ (br_
                        || bs_())
                        && bt_());
                }


                (CqlTupleMetadata, string EncounterId, CqlInterval<CqlDateTime> EDEncounterTiming, string PerformedStatus, CqlInterval<CqlDateTime> PerformedTiming)? bh_(Procedure OxygenAdminInterv) {
                    Id da_ = EncounterInpatient?.IdElement;
                    string db_ = da_?.Value;
                    Encounter dc_ = CQMCommon_4_1_000.Instance.edVisit(context, EncounterInpatient);
                    Period dd_ = dc_?.Period;
                    CqlInterval<CqlDateTime> de_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, dd_);
                    Code<EventStatus> df_ = OxygenAdminInterv?.StatusElement;
                    EventStatus? dg_ = df_?.Value;
                    string dh_ = context.Operators.Convert<string>(dg_);
                    object di_;
                    DataType dl_ = OxygenAdminInterv?.Performed;
                    object dm_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dl_);
                    bool dn_ = dm_ is CqlDateTime;
                    if (dn_)
                    {
                        di_ = dm_ as CqlDateTime;
                    }
                    else
                    {
                        bool do_ = dm_ is CqlQuantity;
                        if (do_)
                        {
                            di_ = dm_ as CqlQuantity;
                        }
                        else
                        {
                            bool dp_ = dm_ is CqlInterval<CqlDateTime>;
                            if (dp_)
                            {
                                di_ = dm_ as CqlInterval<CqlDateTime>;
                            }
                            else
                            {
                                bool dq_ = dm_ is CqlInterval<CqlQuantity>;
                                if (dq_)
                                {
                                    di_ = dm_ as CqlInterval<CqlQuantity>;
                                }
                                else
                                {
                                    di_ = null;
                                }
                            }
                        }
                    }
                    CqlInterval<CqlDateTime> dj_ = QICoreCommon_4_0_000.Instance.toInterval(context, di_);
                    (CqlTupleMetadata, string EncounterId, CqlInterval<CqlDateTime> EDEncounterTiming, string PerformedStatus, CqlInterval<CqlDateTime> PerformedTiming)? dk_ = (CqlTupleMetadata_HBSiHLDibCXHQcPZYMVBgXBIH, db_, de_, dh_, dj_);
                    return dk_;
                }

                IEnumerable<(CqlTupleMetadata, string EncounterId, CqlInterval<CqlDateTime> EDEncounterTiming, string PerformedStatus, CqlInterval<CqlDateTime> PerformedTiming)?> bi_ = context.Operators.WhereSelect<Procedure, (CqlTupleMetadata, string EncounterId, CqlInterval<CqlDateTime> EDEncounterTiming, string PerformedStatus, CqlInterval<CqlDateTime> PerformedTiming)?>(bf_, bg_, bh_);
                IEnumerable<(CqlTupleMetadata, string EncounterId, CqlInterval<CqlDateTime> EDEncounterTiming, string PerformedStatus, CqlInterval<CqlDateTime> PerformedTiming)?> bj_ = context.Operators.Distinct<(CqlTupleMetadata, string EncounterId, CqlInterval<CqlDateTime> EDEncounterTiming, string PerformedStatus, CqlInterval<CqlDateTime> PerformedTiming)?>(bi_);
                CqlBoolean bk_ = context.Operators.Exists<(CqlTupleMetadata, string EncounterId, CqlInterval<CqlDateTime> EDEncounterTiming, string PerformedStatus, CqlInterval<CqlDateTime> PerformedTiming)?>(bj_);
                return bk_;
            }

            return /* CQL 'or' (231:5-255:7) */ (m_
                || n_());
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

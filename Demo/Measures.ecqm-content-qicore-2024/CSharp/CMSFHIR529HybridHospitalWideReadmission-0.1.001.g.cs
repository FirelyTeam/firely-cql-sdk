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

[System.CodeDom.Compiler.GeneratedCode(".NET Code Generation", "3.1.0.0")]
[CqlLibrary("CMSFHIR529HybridHospitalWideReadmission", "0.1.001")]
public partial class CMSFHIR529HybridHospitalWideReadmission_0_1_001 : ILibrary, ISingleton<CMSFHIR529HybridHospitalWideReadmission_0_1_001>
{
    private CMSFHIR529HybridHospitalWideReadmission_0_1_001() {}

    public static CMSFHIR529HybridHospitalWideReadmission_0_1_001 Instance { get; } = new();

    #region ILibrary Implementation

    public string Name => "CMSFHIR529HybridHospitalWideReadmission";
    public string Version => "0.1.001";
    public ILibrary[] Dependencies => [CQMCommon_2_2_000.Instance, FHIRHelpers_4_4_000.Instance, SupplementalDataElements_3_5_000.Instance, QICoreCommon_2_1_000.Instance];

    #endregion ILibrary Implementation

    #region ValueSets

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

    #region Codes

    [CqlCodeDefinition("Oxygen saturation in Arterial blood", codeId: "2708-6", codeSystem: "http://loinc.org")]
    public CqlCode Oxygen_saturation_in_Arterial_blood(CqlContext _) => _Oxygen_saturation_in_Arterial_blood;
    private static readonly CqlCode _Oxygen_saturation_in_Arterial_blood = new CqlCode("2708-6", "http://loinc.org");

    [CqlCodeDefinition("Oxygen saturation in Arterial blood by Pulse oximetry", codeId: "59408-5", codeSystem: "http://loinc.org")]
    public CqlCode Oxygen_saturation_in_Arterial_blood_by_Pulse_oximetry(CqlContext _) => _Oxygen_saturation_in_Arterial_blood_by_Pulse_oximetry;
    private static readonly CqlCode _Oxygen_saturation_in_Arterial_blood_by_Pulse_oximetry = new CqlCode("59408-5", "http://loinc.org");

    [CqlCodeDefinition("Systolic blood pressure", codeId: "8480-6", codeSystem: "http://loinc.org")]
    public CqlCode Systolic_blood_pressure(CqlContext _) => _Systolic_blood_pressure;
    private static readonly CqlCode _Systolic_blood_pressure = new CqlCode("8480-6", "http://loinc.org");

    #endregion Codes

    #region CodeSystems

    [CqlCodeSystemDefinition("LOINC", codeSystemId: "http://loinc.org", codeSystemVersion: null)]
    public CqlCodeSystem LOINC(CqlContext _) => _LOINC;
    private static readonly CqlCodeSystem _LOINC =
      new CqlCodeSystem("http://loinc.org", null, [
          _Oxygen_saturation_in_Arterial_blood,
          _Oxygen_saturation_in_Arterial_blood_by_Pulse_oximetry,
          _Systolic_blood_pressure]);

    [CqlCodeSystemDefinition("ActCode", codeSystemId: "http://terminology.hl7.org/CodeSystem/v3-ActCode", codeSystemVersion: null)]
    public CqlCodeSystem ActCode(CqlContext _) => _ActCode;
    private static readonly CqlCodeSystem _ActCode =
      new CqlCodeSystem("http://terminology.hl7.org/CodeSystem/v3-ActCode", null, []);

    [CqlCodeSystemDefinition("Source of Payment Typology", codeSystemId: "https://nahdo.org/sopt", codeSystemVersion: null)]
    public CqlCodeSystem Source_of_Payment_Typology(CqlContext _) => _Source_of_Payment_Typology;
    private static readonly CqlCodeSystem _Source_of_Payment_Typology =
      new CqlCodeSystem("https://nahdo.org/sopt", null, []);

    #endregion CodeSystems

    #region Parameters

    [CqlParameterDefinition("Measurement Period")]
    public CqlInterval<CqlDateTime> Measurement_Period(CqlContext context)
    {
        CqlDateTime a_ = context.Operators.DateTime(2026, 1, 1, 0, 0, 0, 0, 0.0m);
        CqlDateTime b_ = context.Operators.DateTime(2026, 12, 31, 23, 59, 59, 999, 0.0m);
        CqlInterval<CqlDateTime> c_ = context.Operators.Interval(a_, b_, true, true);
        object d_ = context.ResolveParameter("CMSFHIR529HybridHospitalWideReadmission-0.1.001", "Measurement Period", c_);

        return (CqlInterval<CqlDateTime>)d_;
    }


    #endregion Parameters

    #region Functions and Expressions

    [CqlExpressionDefinition("Patient")]
    public Patient Patient(CqlContext context)
    {
        IEnumerable<Patient> a_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-patient"));
        Patient b_ = context.Operators.SingletonFrom<Patient>(a_);

        return b_;
    }


    [CqlExpressionDefinition("Inpatient Encounters")]
    public IEnumerable<Encounter> Inpatient_Encounters(CqlContext context)
    {
        CqlValueSet a_ = this.Encounter_Inpatient(context);
        IEnumerable<Encounter> b_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> c_(Encounter InpatientEncounter)
        {
            CqlValueSet e_ = this.Medicare_FFS_payer(context);
            IEnumerable<Coverage> f_ = context.Operators.Retrieve<Coverage>(new RetrieveParameters(default, e_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-coverage"));
            CqlValueSet g_ = this.Medicare_Advantage_payer(context);
            IEnumerable<Coverage> h_ = context.Operators.Retrieve<Coverage>(new RetrieveParameters(default, g_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-coverage"));
            IEnumerable<Coverage> i_ = context.Operators.Union<Coverage>(f_, h_);
            bool? j_(Coverage MedicarePayer)
            {
                CqlInterval<CqlDateTime> n_ = CQMCommon_2_2_000.Instance.hospitalizationWithObservationAndOutpatientSurgeryService(context, InpatientEncounter);
                int? o_ = CQMCommon_2_2_000.Instance.lengthInDays(context, n_);
                bool? p_ = context.Operators.Less(o_, 365);
                Code<Encounter.EncounterStatus> q_ = InpatientEncounter?.StatusElement;
                Encounter.EncounterStatus? r_ = q_?.Value;
                Code<Encounter.EncounterStatus> s_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(r_);
                bool? t_ = context.Operators.Equal(s_, "finished");
                bool? u_ = context.Operators.And(p_, t_);
                Patient v_ = this.Patient(context);
                Date w_ = v_?.BirthDateElement;
                string x_ = w_?.Value;
                CqlDate y_ = context.Operators.ConvertStringToDate(x_);
                Period z_ = InpatientEncounter?.Period;
                CqlInterval<CqlDateTime> aa_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, z_);
                CqlDateTime ab_ = context.Operators.Start(aa_);
                CqlDate ac_ = context.Operators.DateFrom(ab_);
                int? ad_ = context.Operators.CalculateAgeAt(y_, ac_, "year");
                bool? ae_ = context.Operators.GreaterOrEqual(ad_, 65);
                bool? af_ = context.Operators.And(u_, ae_);
                CqlInterval<CqlDateTime> ah_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, z_);
                CqlDateTime ai_ = context.Operators.End(ah_);
                CqlInterval<CqlDateTime> aj_ = this.Measurement_Period(context);
                bool? ak_ = context.Operators.In<CqlDateTime>(ai_, aj_, "day");
                bool? al_ = context.Operators.And(af_, ak_);

                return al_;
            };
            IEnumerable<Coverage> k_ = context.Operators.Where<Coverage>(i_, j_);
            Encounter l_(Coverage MedicarePayer) =>
                InpatientEncounter;
            IEnumerable<Encounter> m_ = context.Operators.Select<Coverage, Encounter>(k_, l_);

            return m_;
        };
        IEnumerable<Encounter> d_ = context.Operators.SelectMany<Encounter, Encounter>(b_, c_);

        return d_;
    }


    [CqlExpressionDefinition("Initial Population")]
    public IEnumerable<Encounter> Initial_Population(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Inpatient_Encounters(context);

        return a_;
    }


    [CqlExpressionDefinition("Encounter with First Body Temperature")]
    public IEnumerable<(CqlTupleMetadata, string EncounterId, CqlQuantity FirstTemperatureResult, CqlDateTime Timing)?> Encounter_with_First_Body_Temperature(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Inpatient_Encounters(context);
        (CqlTupleMetadata, string EncounterId, CqlQuantity FirstTemperatureResult, CqlDateTime Timing)? b_(Encounter EncounterInpatient)
        {
            Id e_ = EncounterInpatient?.IdElement;
            string f_ = e_?.Value;
            IEnumerable<Observation> g_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/StructureDefinition/bodytemp"));
            bool? h_(Observation temperature)
            {
                DataType y_ = temperature?.Effective;
                object z_ = FHIRHelpers_4_4_000.Instance.ToValue(context, y_);
                CqlDateTime aa_ = QICoreCommon_2_1_000.Instance.earliest(context, z_);
                CqlInterval<CqlDateTime> ab_ = CQMCommon_2_2_000.Instance.hospitalizationWithObservationAndOutpatientSurgeryService(context, EncounterInpatient);
                bool? ac_ = context.Operators.In<CqlDateTime>(aa_, ab_, default);
                Code<ObservationStatus> ad_ = temperature?.StatusElement;
                ObservationStatus? ae_ = ad_?.Value;
                string af_ = context.Operators.Convert<string>(ae_);
                string[] ag_ = [
                    "final",
                    "amended",
                    "corrected",
                ];
                bool? ah_ = context.Operators.In<string>(af_, (IEnumerable<string>)ag_);
                bool? ai_ = context.Operators.And(ac_, ah_);
                DataType aj_ = temperature?.Value;
                CqlQuantity ak_ = FHIRHelpers_4_4_000.Instance.ToQuantity(context, aj_ as Quantity);
                bool? al_ = context.Operators.Not((bool?)(ak_ is null));
                bool? am_ = context.Operators.And(ai_, al_);

                return am_;
            };
            IEnumerable<Observation> i_ = context.Operators.Where<Observation>(g_, h_);
            object j_(Observation @this)
            {
                DataType an_ = @this?.Effective;
                object ao_ = FHIRHelpers_4_4_000.Instance.ToValue(context, an_);
                CqlDateTime ap_ = QICoreCommon_2_1_000.Instance.earliest(context, ao_);

                return ap_;
            };
            IEnumerable<Observation> k_ = context.Operators.SortBy<Observation>(i_, j_, System.ComponentModel.ListSortDirection.Ascending);
            Observation l_ = context.Operators.First<Observation>(k_);
            DataType m_ = l_?.Value;
            CqlQuantity n_ = FHIRHelpers_4_4_000.Instance.ToQuantity(context, m_ as Quantity);
            bool? p_(Observation temperature)
            {
                DataType aq_ = temperature?.Effective;
                object ar_ = FHIRHelpers_4_4_000.Instance.ToValue(context, aq_);
                CqlDateTime as_ = QICoreCommon_2_1_000.Instance.earliest(context, ar_);
                CqlInterval<CqlDateTime> at_ = CQMCommon_2_2_000.Instance.hospitalizationWithObservationAndOutpatientSurgeryService(context, EncounterInpatient);
                bool? au_ = context.Operators.In<CqlDateTime>(as_, at_, default);
                Code<ObservationStatus> av_ = temperature?.StatusElement;
                ObservationStatus? aw_ = av_?.Value;
                string ax_ = context.Operators.Convert<string>(aw_);
                string[] ay_ = [
                    "final",
                    "amended",
                    "corrected",
                ];
                bool? az_ = context.Operators.In<string>(ax_, (IEnumerable<string>)ay_);
                bool? ba_ = context.Operators.And(au_, az_);
                DataType bb_ = temperature?.Value;
                CqlQuantity bc_ = FHIRHelpers_4_4_000.Instance.ToQuantity(context, bb_ as Quantity);
                bool? bd_ = context.Operators.Not((bool?)(bc_ is null));
                bool? be_ = context.Operators.And(ba_, bd_);

                return be_;
            };
            IEnumerable<Observation> q_ = context.Operators.Where<Observation>(g_, p_);
            object r_(Observation @this)
            {
                DataType bf_ = @this?.Effective;
                object bg_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bf_);
                CqlDateTime bh_ = QICoreCommon_2_1_000.Instance.earliest(context, bg_);

                return bh_;
            };
            IEnumerable<Observation> s_ = context.Operators.SortBy<Observation>(q_, r_, System.ComponentModel.ListSortDirection.Ascending);
            Observation t_ = context.Operators.First<Observation>(s_);
            DataType u_ = t_?.Effective;
            object v_ = FHIRHelpers_4_4_000.Instance.ToValue(context, u_);
            CqlDateTime w_ = QICoreCommon_2_1_000.Instance.earliest(context, v_);
            (CqlTupleMetadata, string EncounterId, CqlQuantity FirstTemperatureResult, CqlDateTime Timing)? x_ = (CqlTupleMetadata_GIbILVAdXLLNYBgcQIEiUiKaK, f_, n_ as CqlQuantity, w_);

            return x_;
        };
        IEnumerable<(CqlTupleMetadata, string EncounterId, CqlQuantity FirstTemperatureResult, CqlDateTime Timing)?> c_ = context.Operators.Select<Encounter, (CqlTupleMetadata, string EncounterId, CqlQuantity FirstTemperatureResult, CqlDateTime Timing)?>(a_, b_);
        IEnumerable<(CqlTupleMetadata, string EncounterId, CqlQuantity FirstTemperatureResult, CqlDateTime Timing)?> d_ = context.Operators.Distinct<(CqlTupleMetadata, string EncounterId, CqlQuantity FirstTemperatureResult, CqlDateTime Timing)?>(c_);

        return d_;
    }


    [CqlExpressionDefinition("Encounter with First Heart Rate")]
    public IEnumerable<(CqlTupleMetadata, string EncounterId, CqlQuantity FirstHeartRateResult, CqlDateTime Timing)?> Encounter_with_First_Heart_Rate(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Inpatient_Encounters(context);
        (CqlTupleMetadata, string EncounterId, CqlQuantity FirstHeartRateResult, CqlDateTime Timing)? b_(Encounter EncounterInpatient)
        {
            Id e_ = EncounterInpatient?.IdElement;
            string f_ = e_?.Value;
            IEnumerable<Observation> g_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/StructureDefinition/heartrate"));
            bool? h_(Observation HeartRate)
            {
                DataType y_ = HeartRate?.Effective;
                object z_ = FHIRHelpers_4_4_000.Instance.ToValue(context, y_);
                CqlDateTime aa_ = QICoreCommon_2_1_000.Instance.earliest(context, z_);
                CqlInterval<CqlDateTime> ab_ = CQMCommon_2_2_000.Instance.hospitalizationWithObservationAndOutpatientSurgeryService(context, EncounterInpatient);
                bool? ac_ = context.Operators.In<CqlDateTime>(aa_, ab_, default);
                Code<ObservationStatus> ad_ = HeartRate?.StatusElement;
                ObservationStatus? ae_ = ad_?.Value;
                string af_ = context.Operators.Convert<string>(ae_);
                string[] ag_ = [
                    "final",
                    "amended",
                    "corrected",
                ];
                bool? ah_ = context.Operators.In<string>(af_, (IEnumerable<string>)ag_);
                bool? ai_ = context.Operators.And(ac_, ah_);
                DataType aj_ = HeartRate?.Value;
                CqlQuantity ak_ = FHIRHelpers_4_4_000.Instance.ToQuantity(context, aj_ as Quantity);
                bool? al_ = context.Operators.Not((bool?)(ak_ is null));
                bool? am_ = context.Operators.And(ai_, al_);

                return am_;
            };
            IEnumerable<Observation> i_ = context.Operators.Where<Observation>(g_, h_);
            object j_(Observation @this)
            {
                DataType an_ = @this?.Effective;
                object ao_ = FHIRHelpers_4_4_000.Instance.ToValue(context, an_);
                CqlDateTime ap_ = QICoreCommon_2_1_000.Instance.earliest(context, ao_);

                return ap_;
            };
            IEnumerable<Observation> k_ = context.Operators.SortBy<Observation>(i_, j_, System.ComponentModel.ListSortDirection.Ascending);
            Observation l_ = context.Operators.First<Observation>(k_);
            DataType m_ = l_?.Value;
            CqlQuantity n_ = FHIRHelpers_4_4_000.Instance.ToQuantity(context, m_ as Quantity);
            bool? p_(Observation HeartRate)
            {
                DataType aq_ = HeartRate?.Effective;
                object ar_ = FHIRHelpers_4_4_000.Instance.ToValue(context, aq_);
                CqlDateTime as_ = QICoreCommon_2_1_000.Instance.earliest(context, ar_);
                CqlInterval<CqlDateTime> at_ = CQMCommon_2_2_000.Instance.hospitalizationWithObservationAndOutpatientSurgeryService(context, EncounterInpatient);
                bool? au_ = context.Operators.In<CqlDateTime>(as_, at_, default);
                Code<ObservationStatus> av_ = HeartRate?.StatusElement;
                ObservationStatus? aw_ = av_?.Value;
                string ax_ = context.Operators.Convert<string>(aw_);
                string[] ay_ = [
                    "final",
                    "amended",
                    "corrected",
                ];
                bool? az_ = context.Operators.In<string>(ax_, (IEnumerable<string>)ay_);
                bool? ba_ = context.Operators.And(au_, az_);
                DataType bb_ = HeartRate?.Value;
                CqlQuantity bc_ = FHIRHelpers_4_4_000.Instance.ToQuantity(context, bb_ as Quantity);
                bool? bd_ = context.Operators.Not((bool?)(bc_ is null));
                bool? be_ = context.Operators.And(ba_, bd_);

                return be_;
            };
            IEnumerable<Observation> q_ = context.Operators.Where<Observation>(g_, p_);
            object r_(Observation @this)
            {
                DataType bf_ = @this?.Effective;
                object bg_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bf_);
                CqlDateTime bh_ = QICoreCommon_2_1_000.Instance.earliest(context, bg_);

                return bh_;
            };
            IEnumerable<Observation> s_ = context.Operators.SortBy<Observation>(q_, r_, System.ComponentModel.ListSortDirection.Ascending);
            Observation t_ = context.Operators.First<Observation>(s_);
            DataType u_ = t_?.Effective;
            object v_ = FHIRHelpers_4_4_000.Instance.ToValue(context, u_);
            CqlDateTime w_ = QICoreCommon_2_1_000.Instance.earliest(context, v_);
            (CqlTupleMetadata, string EncounterId, CqlQuantity FirstHeartRateResult, CqlDateTime Timing)? x_ = (CqlTupleMetadata_DhbJAfCiKIAGYKTjJXYGSKECQ, f_, n_ as CqlQuantity, w_);

            return x_;
        };
        IEnumerable<(CqlTupleMetadata, string EncounterId, CqlQuantity FirstHeartRateResult, CqlDateTime Timing)?> c_ = context.Operators.Select<Encounter, (CqlTupleMetadata, string EncounterId, CqlQuantity FirstHeartRateResult, CqlDateTime Timing)?>(a_, b_);
        IEnumerable<(CqlTupleMetadata, string EncounterId, CqlQuantity FirstHeartRateResult, CqlDateTime Timing)?> d_ = context.Operators.Distinct<(CqlTupleMetadata, string EncounterId, CqlQuantity FirstHeartRateResult, CqlDateTime Timing)?>(c_);

        return d_;
    }


    [CqlExpressionDefinition("Encounter with First Oxygen Saturation")]
    public IEnumerable<(CqlTupleMetadata, string EncounterId, CqlQuantity FirstOxygenSatResult, CqlDateTime Timing)?> Encounter_with_First_Oxygen_Saturation(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Inpatient_Encounters(context);
        (CqlTupleMetadata, string EncounterId, CqlQuantity FirstOxygenSatResult, CqlDateTime Timing)? b_(Encounter EncounterInpatient)
        {
            Id e_ = EncounterInpatient?.IdElement;
            string f_ = e_?.Value;
            CqlValueSet g_ = this.Oxygen_Saturation_by_Pulse_Oximetry(context);
            IEnumerable<Observation> h_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, g_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
            bool? i_(Observation O2Saturation)
            {
                object s_()
                {
                    bool ah_()
                    {
                        DataType ak_ = O2Saturation?.Effective;
                        object al_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ak_);
                        bool am_ = al_ is CqlDateTime;

                        return am_;
                    };
                    bool ai_()
                    {
                        DataType an_ = O2Saturation?.Effective;
                        object ao_ = FHIRHelpers_4_4_000.Instance.ToValue(context, an_);
                        bool ap_ = ao_ is CqlInterval<CqlDateTime>;

                        return ap_;
                    };
                    bool aj_()
                    {
                        DataType aq_ = O2Saturation?.Effective;
                        object ar_ = FHIRHelpers_4_4_000.Instance.ToValue(context, aq_);
                        bool as_ = ar_ is CqlDateTime;

                        return as_;
                    };
                    if (ah_())
                    {
                        DataType at_ = O2Saturation?.Effective;
                        object au_ = FHIRHelpers_4_4_000.Instance.ToValue(context, at_);

                        return (au_ as CqlDateTime) as object;
                    }
                    else if (ai_())
                    {
                        DataType av_ = O2Saturation?.Effective;
                        object aw_ = FHIRHelpers_4_4_000.Instance.ToValue(context, av_);

                        return (aw_ as CqlInterval<CqlDateTime>) as object;
                    }
                    else if (aj_())
                    {
                        DataType ax_ = O2Saturation?.Effective;
                        object ay_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ax_);

                        return (ay_ as CqlDateTime) as object;
                    }
                    else
                    {
                        return null;
                    }
                };
                CqlDateTime t_ = QICoreCommon_2_1_000.Instance.earliest(context, s_());
                CqlInterval<CqlDateTime> u_ = CQMCommon_2_2_000.Instance.hospitalizationWithObservationAndOutpatientSurgeryService(context, EncounterInpatient);
                bool? v_ = context.Operators.In<CqlDateTime>(t_, u_, default);
                Code<ObservationStatus> w_ = O2Saturation?.StatusElement;
                ObservationStatus? x_ = w_?.Value;
                Code<ObservationStatus> y_ = context.Operators.Convert<Code<ObservationStatus>>(x_);
                string z_ = context.Operators.Convert<string>(y_);
                string[] aa_ = [
                    "final",
                    "amended",
                    "corrected",
                ];
                bool? ab_ = context.Operators.In<string>(z_, (IEnumerable<string>)aa_);
                bool? ac_ = context.Operators.And(v_, ab_);
                DataType ad_ = O2Saturation?.Value;
                object ae_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ad_);
                bool? af_ = context.Operators.Not((bool?)(ae_ is null));
                bool? ag_ = context.Operators.And(ac_, af_);

                return ag_;
            };
            IEnumerable<Observation> j_ = context.Operators.Where<Observation>(h_, i_);
            object k_(Observation @this)
            {
                object az_()
                {
                    bool bb_()
                    {
                        DataType be_ = @this?.Effective;
                        object bf_ = FHIRHelpers_4_4_000.Instance.ToValue(context, be_);
                        bool bg_ = bf_ is CqlDateTime;

                        return bg_;
                    };
                    bool bc_()
                    {
                        DataType bh_ = @this?.Effective;
                        object bi_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bh_);
                        bool bj_ = bi_ is CqlInterval<CqlDateTime>;

                        return bj_;
                    };
                    bool bd_()
                    {
                        DataType bk_ = @this?.Effective;
                        object bl_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bk_);
                        bool bm_ = bl_ is CqlDateTime;

                        return bm_;
                    };
                    if (bb_())
                    {
                        DataType bn_ = @this?.Effective;
                        object bo_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bn_);

                        return (bo_ as CqlDateTime) as object;
                    }
                    else if (bc_())
                    {
                        DataType bp_ = @this?.Effective;
                        object bq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bp_);

                        return (bq_ as CqlInterval<CqlDateTime>) as object;
                    }
                    else if (bd_())
                    {
                        DataType br_ = @this?.Effective;
                        object bs_ = FHIRHelpers_4_4_000.Instance.ToValue(context, br_);

                        return (bs_ as CqlDateTime) as object;
                    }
                    else
                    {
                        return null;
                    }
                };
                CqlDateTime ba_ = QICoreCommon_2_1_000.Instance.earliest(context, az_());

                return ba_;
            };
            IEnumerable<Observation> l_ = context.Operators.SortBy<Observation>(j_, k_, System.ComponentModel.ListSortDirection.Ascending);
            Observation m_ = context.Operators.First<Observation>(l_);
            DataType n_ = m_?.Value;
            object o_ = FHIRHelpers_4_4_000.Instance.ToValue(context, n_);
            object p_()
            {
                bool bt_()
                {
                    CqlValueSet bw_ = this.Oxygen_Saturation_by_Pulse_Oximetry(context);
                    IEnumerable<Observation> bx_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, bw_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
                    bool? by_(Observation O2Saturation)
                    {
                        object cg_()
                        {
                            bool cv_()
                            {
                                DataType cy_ = O2Saturation?.Effective;
                                object cz_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cy_);
                                bool da_ = cz_ is CqlDateTime;

                                return da_;
                            };
                            bool cw_()
                            {
                                DataType db_ = O2Saturation?.Effective;
                                object dc_ = FHIRHelpers_4_4_000.Instance.ToValue(context, db_);
                                bool dd_ = dc_ is CqlInterval<CqlDateTime>;

                                return dd_;
                            };
                            bool cx_()
                            {
                                DataType de_ = O2Saturation?.Effective;
                                object df_ = FHIRHelpers_4_4_000.Instance.ToValue(context, de_);
                                bool dg_ = df_ is CqlDateTime;

                                return dg_;
                            };
                            if (cv_())
                            {
                                DataType dh_ = O2Saturation?.Effective;
                                object di_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dh_);

                                return (di_ as CqlDateTime) as object;
                            }
                            else if (cw_())
                            {
                                DataType dj_ = O2Saturation?.Effective;
                                object dk_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dj_);

                                return (dk_ as CqlInterval<CqlDateTime>) as object;
                            }
                            else if (cx_())
                            {
                                DataType dl_ = O2Saturation?.Effective;
                                object dm_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dl_);

                                return (dm_ as CqlDateTime) as object;
                            }
                            else
                            {
                                return null;
                            }
                        };
                        CqlDateTime ch_ = QICoreCommon_2_1_000.Instance.earliest(context, cg_());
                        CqlInterval<CqlDateTime> ci_ = CQMCommon_2_2_000.Instance.hospitalizationWithObservationAndOutpatientSurgeryService(context, EncounterInpatient);
                        bool? cj_ = context.Operators.In<CqlDateTime>(ch_, ci_, default);
                        Code<ObservationStatus> ck_ = O2Saturation?.StatusElement;
                        ObservationStatus? cl_ = ck_?.Value;
                        Code<ObservationStatus> cm_ = context.Operators.Convert<Code<ObservationStatus>>(cl_);
                        string cn_ = context.Operators.Convert<string>(cm_);
                        string[] co_ = [
                            "final",
                            "amended",
                            "corrected",
                        ];
                        bool? cp_ = context.Operators.In<string>(cn_, (IEnumerable<string>)co_);
                        bool? cq_ = context.Operators.And(cj_, cp_);
                        DataType cr_ = O2Saturation?.Value;
                        object cs_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cr_);
                        bool? ct_ = context.Operators.Not((bool?)(cs_ is null));
                        bool? cu_ = context.Operators.And(cq_, ct_);

                        return cu_;
                    };
                    IEnumerable<Observation> bz_ = context.Operators.Where<Observation>(bx_, by_);
                    object ca_(Observation @this)
                    {
                        object dn_()
                        {
                            bool dp_()
                            {
                                DataType ds_ = @this?.Effective;
                                object dt_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ds_);
                                bool du_ = dt_ is CqlDateTime;

                                return du_;
                            };
                            bool dq_()
                            {
                                DataType dv_ = @this?.Effective;
                                object dw_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dv_);
                                bool dx_ = dw_ is CqlInterval<CqlDateTime>;

                                return dx_;
                            };
                            bool dr_()
                            {
                                DataType dy_ = @this?.Effective;
                                object dz_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dy_);
                                bool ea_ = dz_ is CqlDateTime;

                                return ea_;
                            };
                            if (dp_())
                            {
                                DataType eb_ = @this?.Effective;
                                object ec_ = FHIRHelpers_4_4_000.Instance.ToValue(context, eb_);

                                return (ec_ as CqlDateTime) as object;
                            }
                            else if (dq_())
                            {
                                DataType ed_ = @this?.Effective;
                                object ee_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ed_);

                                return (ee_ as CqlInterval<CqlDateTime>) as object;
                            }
                            else if (dr_())
                            {
                                DataType ef_ = @this?.Effective;
                                object eg_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ef_);

                                return (eg_ as CqlDateTime) as object;
                            }
                            else
                            {
                                return null;
                            }
                        };
                        CqlDateTime do_ = QICoreCommon_2_1_000.Instance.earliest(context, dn_());

                        return do_;
                    };
                    IEnumerable<Observation> cb_ = context.Operators.SortBy<Observation>(bz_, ca_, System.ComponentModel.ListSortDirection.Ascending);
                    Observation cc_ = context.Operators.First<Observation>(cb_);
                    DataType cd_ = cc_?.Effective;
                    object ce_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cd_);
                    bool cf_ = ce_ is CqlDateTime;

                    return cf_;
                };
                bool bu_()
                {
                    CqlValueSet eh_ = this.Oxygen_Saturation_by_Pulse_Oximetry(context);
                    IEnumerable<Observation> ei_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, eh_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
                    bool? ej_(Observation O2Saturation)
                    {
                        object er_()
                        {
                            bool fg_()
                            {
                                DataType fj_ = O2Saturation?.Effective;
                                object fk_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fj_);
                                bool fl_ = fk_ is CqlDateTime;

                                return fl_;
                            };
                            bool fh_()
                            {
                                DataType fm_ = O2Saturation?.Effective;
                                object fn_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fm_);
                                bool fo_ = fn_ is CqlInterval<CqlDateTime>;

                                return fo_;
                            };
                            bool fi_()
                            {
                                DataType fp_ = O2Saturation?.Effective;
                                object fq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fp_);
                                bool fr_ = fq_ is CqlDateTime;

                                return fr_;
                            };
                            if (fg_())
                            {
                                DataType fs_ = O2Saturation?.Effective;
                                object ft_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fs_);

                                return (ft_ as CqlDateTime) as object;
                            }
                            else if (fh_())
                            {
                                DataType fu_ = O2Saturation?.Effective;
                                object fv_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fu_);

                                return (fv_ as CqlInterval<CqlDateTime>) as object;
                            }
                            else if (fi_())
                            {
                                DataType fw_ = O2Saturation?.Effective;
                                object fx_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fw_);

                                return (fx_ as CqlDateTime) as object;
                            }
                            else
                            {
                                return null;
                            }
                        };
                        CqlDateTime es_ = QICoreCommon_2_1_000.Instance.earliest(context, er_());
                        CqlInterval<CqlDateTime> et_ = CQMCommon_2_2_000.Instance.hospitalizationWithObservationAndOutpatientSurgeryService(context, EncounterInpatient);
                        bool? eu_ = context.Operators.In<CqlDateTime>(es_, et_, default);
                        Code<ObservationStatus> ev_ = O2Saturation?.StatusElement;
                        ObservationStatus? ew_ = ev_?.Value;
                        Code<ObservationStatus> ex_ = context.Operators.Convert<Code<ObservationStatus>>(ew_);
                        string ey_ = context.Operators.Convert<string>(ex_);
                        string[] ez_ = [
                            "final",
                            "amended",
                            "corrected",
                        ];
                        bool? fa_ = context.Operators.In<string>(ey_, (IEnumerable<string>)ez_);
                        bool? fb_ = context.Operators.And(eu_, fa_);
                        DataType fc_ = O2Saturation?.Value;
                        object fd_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fc_);
                        bool? fe_ = context.Operators.Not((bool?)(fd_ is null));
                        bool? ff_ = context.Operators.And(fb_, fe_);

                        return ff_;
                    };
                    IEnumerable<Observation> ek_ = context.Operators.Where<Observation>(ei_, ej_);
                    object el_(Observation @this)
                    {
                        object fy_()
                        {
                            bool ga_()
                            {
                                DataType gd_ = @this?.Effective;
                                object ge_ = FHIRHelpers_4_4_000.Instance.ToValue(context, gd_);
                                bool gf_ = ge_ is CqlDateTime;

                                return gf_;
                            };
                            bool gb_()
                            {
                                DataType gg_ = @this?.Effective;
                                object gh_ = FHIRHelpers_4_4_000.Instance.ToValue(context, gg_);
                                bool gi_ = gh_ is CqlInterval<CqlDateTime>;

                                return gi_;
                            };
                            bool gc_()
                            {
                                DataType gj_ = @this?.Effective;
                                object gk_ = FHIRHelpers_4_4_000.Instance.ToValue(context, gj_);
                                bool gl_ = gk_ is CqlDateTime;

                                return gl_;
                            };
                            if (ga_())
                            {
                                DataType gm_ = @this?.Effective;
                                object gn_ = FHIRHelpers_4_4_000.Instance.ToValue(context, gm_);

                                return (gn_ as CqlDateTime) as object;
                            }
                            else if (gb_())
                            {
                                DataType go_ = @this?.Effective;
                                object gp_ = FHIRHelpers_4_4_000.Instance.ToValue(context, go_);

                                return (gp_ as CqlInterval<CqlDateTime>) as object;
                            }
                            else if (gc_())
                            {
                                DataType gq_ = @this?.Effective;
                                object gr_ = FHIRHelpers_4_4_000.Instance.ToValue(context, gq_);

                                return (gr_ as CqlDateTime) as object;
                            }
                            else
                            {
                                return null;
                            }
                        };
                        CqlDateTime fz_ = QICoreCommon_2_1_000.Instance.earliest(context, fy_());

                        return fz_;
                    };
                    IEnumerable<Observation> em_ = context.Operators.SortBy<Observation>(ek_, el_, System.ComponentModel.ListSortDirection.Ascending);
                    Observation en_ = context.Operators.First<Observation>(em_);
                    DataType eo_ = en_?.Effective;
                    object ep_ = FHIRHelpers_4_4_000.Instance.ToValue(context, eo_);
                    bool eq_ = ep_ is CqlInterval<CqlDateTime>;

                    return eq_;
                };
                bool bv_()
                {
                    CqlValueSet gs_ = this.Oxygen_Saturation_by_Pulse_Oximetry(context);
                    IEnumerable<Observation> gt_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, gs_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
                    bool? gu_(Observation O2Saturation)
                    {
                        object hc_()
                        {
                            bool hr_()
                            {
                                DataType hu_ = O2Saturation?.Effective;
                                object hv_ = FHIRHelpers_4_4_000.Instance.ToValue(context, hu_);
                                bool hw_ = hv_ is CqlDateTime;

                                return hw_;
                            };
                            bool hs_()
                            {
                                DataType hx_ = O2Saturation?.Effective;
                                object hy_ = FHIRHelpers_4_4_000.Instance.ToValue(context, hx_);
                                bool hz_ = hy_ is CqlInterval<CqlDateTime>;

                                return hz_;
                            };
                            bool ht_()
                            {
                                DataType ia_ = O2Saturation?.Effective;
                                object ib_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ia_);
                                bool ic_ = ib_ is CqlDateTime;

                                return ic_;
                            };
                            if (hr_())
                            {
                                DataType id_ = O2Saturation?.Effective;
                                object ie_ = FHIRHelpers_4_4_000.Instance.ToValue(context, id_);

                                return (ie_ as CqlDateTime) as object;
                            }
                            else if (hs_())
                            {
                                DataType if_ = O2Saturation?.Effective;
                                object ig_ = FHIRHelpers_4_4_000.Instance.ToValue(context, if_);

                                return (ig_ as CqlInterval<CqlDateTime>) as object;
                            }
                            else if (ht_())
                            {
                                DataType ih_ = O2Saturation?.Effective;
                                object ii_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ih_);

                                return (ii_ as CqlDateTime) as object;
                            }
                            else
                            {
                                return null;
                            }
                        };
                        CqlDateTime hd_ = QICoreCommon_2_1_000.Instance.earliest(context, hc_());
                        CqlInterval<CqlDateTime> he_ = CQMCommon_2_2_000.Instance.hospitalizationWithObservationAndOutpatientSurgeryService(context, EncounterInpatient);
                        bool? hf_ = context.Operators.In<CqlDateTime>(hd_, he_, default);
                        Code<ObservationStatus> hg_ = O2Saturation?.StatusElement;
                        ObservationStatus? hh_ = hg_?.Value;
                        Code<ObservationStatus> hi_ = context.Operators.Convert<Code<ObservationStatus>>(hh_);
                        string hj_ = context.Operators.Convert<string>(hi_);
                        string[] hk_ = [
                            "final",
                            "amended",
                            "corrected",
                        ];
                        bool? hl_ = context.Operators.In<string>(hj_, (IEnumerable<string>)hk_);
                        bool? hm_ = context.Operators.And(hf_, hl_);
                        DataType hn_ = O2Saturation?.Value;
                        object ho_ = FHIRHelpers_4_4_000.Instance.ToValue(context, hn_);
                        bool? hp_ = context.Operators.Not((bool?)(ho_ is null));
                        bool? hq_ = context.Operators.And(hm_, hp_);

                        return hq_;
                    };
                    IEnumerable<Observation> gv_ = context.Operators.Where<Observation>(gt_, gu_);
                    object gw_(Observation @this)
                    {
                        object ij_()
                        {
                            bool il_()
                            {
                                DataType io_ = @this?.Effective;
                                object ip_ = FHIRHelpers_4_4_000.Instance.ToValue(context, io_);
                                bool iq_ = ip_ is CqlDateTime;

                                return iq_;
                            };
                            bool im_()
                            {
                                DataType ir_ = @this?.Effective;
                                object is_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ir_);
                                bool it_ = is_ is CqlInterval<CqlDateTime>;

                                return it_;
                            };
                            bool in_()
                            {
                                DataType iu_ = @this?.Effective;
                                object iv_ = FHIRHelpers_4_4_000.Instance.ToValue(context, iu_);
                                bool iw_ = iv_ is CqlDateTime;

                                return iw_;
                            };
                            if (il_())
                            {
                                DataType ix_ = @this?.Effective;
                                object iy_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ix_);

                                return (iy_ as CqlDateTime) as object;
                            }
                            else if (im_())
                            {
                                DataType iz_ = @this?.Effective;
                                object ja_ = FHIRHelpers_4_4_000.Instance.ToValue(context, iz_);

                                return (ja_ as CqlInterval<CqlDateTime>) as object;
                            }
                            else if (in_())
                            {
                                DataType jb_ = @this?.Effective;
                                object jc_ = FHIRHelpers_4_4_000.Instance.ToValue(context, jb_);

                                return (jc_ as CqlDateTime) as object;
                            }
                            else
                            {
                                return null;
                            }
                        };
                        CqlDateTime ik_ = QICoreCommon_2_1_000.Instance.earliest(context, ij_());

                        return ik_;
                    };
                    IEnumerable<Observation> gx_ = context.Operators.SortBy<Observation>(gv_, gw_, System.ComponentModel.ListSortDirection.Ascending);
                    Observation gy_ = context.Operators.First<Observation>(gx_);
                    DataType gz_ = gy_?.Effective;
                    object ha_ = FHIRHelpers_4_4_000.Instance.ToValue(context, gz_);
                    bool hb_ = ha_ is CqlDateTime;

                    return hb_;
                };
                if (bt_())
                {
                    CqlValueSet jd_ = this.Oxygen_Saturation_by_Pulse_Oximetry(context);
                    IEnumerable<Observation> je_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, jd_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
                    bool? jf_(Observation O2Saturation)
                    {
                        object jm_()
                        {
                            bool kb_()
                            {
                                DataType ke_ = O2Saturation?.Effective;
                                object kf_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ke_);
                                bool kg_ = kf_ is CqlDateTime;

                                return kg_;
                            };
                            bool kc_()
                            {
                                DataType kh_ = O2Saturation?.Effective;
                                object ki_ = FHIRHelpers_4_4_000.Instance.ToValue(context, kh_);
                                bool kj_ = ki_ is CqlInterval<CqlDateTime>;

                                return kj_;
                            };
                            bool kd_()
                            {
                                DataType kk_ = O2Saturation?.Effective;
                                object kl_ = FHIRHelpers_4_4_000.Instance.ToValue(context, kk_);
                                bool km_ = kl_ is CqlDateTime;

                                return km_;
                            };
                            if (kb_())
                            {
                                DataType kn_ = O2Saturation?.Effective;
                                object ko_ = FHIRHelpers_4_4_000.Instance.ToValue(context, kn_);

                                return (ko_ as CqlDateTime) as object;
                            }
                            else if (kc_())
                            {
                                DataType kp_ = O2Saturation?.Effective;
                                object kq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, kp_);

                                return (kq_ as CqlInterval<CqlDateTime>) as object;
                            }
                            else if (kd_())
                            {
                                DataType kr_ = O2Saturation?.Effective;
                                object ks_ = FHIRHelpers_4_4_000.Instance.ToValue(context, kr_);

                                return (ks_ as CqlDateTime) as object;
                            }
                            else
                            {
                                return null;
                            }
                        };
                        CqlDateTime jn_ = QICoreCommon_2_1_000.Instance.earliest(context, jm_());
                        CqlInterval<CqlDateTime> jo_ = CQMCommon_2_2_000.Instance.hospitalizationWithObservationAndOutpatientSurgeryService(context, EncounterInpatient);
                        bool? jp_ = context.Operators.In<CqlDateTime>(jn_, jo_, default);
                        Code<ObservationStatus> jq_ = O2Saturation?.StatusElement;
                        ObservationStatus? jr_ = jq_?.Value;
                        Code<ObservationStatus> js_ = context.Operators.Convert<Code<ObservationStatus>>(jr_);
                        string jt_ = context.Operators.Convert<string>(js_);
                        string[] ju_ = [
                            "final",
                            "amended",
                            "corrected",
                        ];
                        bool? jv_ = context.Operators.In<string>(jt_, (IEnumerable<string>)ju_);
                        bool? jw_ = context.Operators.And(jp_, jv_);
                        DataType jx_ = O2Saturation?.Value;
                        object jy_ = FHIRHelpers_4_4_000.Instance.ToValue(context, jx_);
                        bool? jz_ = context.Operators.Not((bool?)(jy_ is null));
                        bool? ka_ = context.Operators.And(jw_, jz_);

                        return ka_;
                    };
                    IEnumerable<Observation> jg_ = context.Operators.Where<Observation>(je_, jf_);
                    object jh_(Observation @this)
                    {
                        object kt_()
                        {
                            bool kv_()
                            {
                                DataType ky_ = @this?.Effective;
                                object kz_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ky_);
                                bool la_ = kz_ is CqlDateTime;

                                return la_;
                            };
                            bool kw_()
                            {
                                DataType lb_ = @this?.Effective;
                                object lc_ = FHIRHelpers_4_4_000.Instance.ToValue(context, lb_);
                                bool ld_ = lc_ is CqlInterval<CqlDateTime>;

                                return ld_;
                            };
                            bool kx_()
                            {
                                DataType le_ = @this?.Effective;
                                object lf_ = FHIRHelpers_4_4_000.Instance.ToValue(context, le_);
                                bool lg_ = lf_ is CqlDateTime;

                                return lg_;
                            };
                            if (kv_())
                            {
                                DataType lh_ = @this?.Effective;
                                object li_ = FHIRHelpers_4_4_000.Instance.ToValue(context, lh_);

                                return (li_ as CqlDateTime) as object;
                            }
                            else if (kw_())
                            {
                                DataType lj_ = @this?.Effective;
                                object lk_ = FHIRHelpers_4_4_000.Instance.ToValue(context, lj_);

                                return (lk_ as CqlInterval<CqlDateTime>) as object;
                            }
                            else if (kx_())
                            {
                                DataType ll_ = @this?.Effective;
                                object lm_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ll_);

                                return (lm_ as CqlDateTime) as object;
                            }
                            else
                            {
                                return null;
                            }
                        };
                        CqlDateTime ku_ = QICoreCommon_2_1_000.Instance.earliest(context, kt_());

                        return ku_;
                    };
                    IEnumerable<Observation> ji_ = context.Operators.SortBy<Observation>(jg_, jh_, System.ComponentModel.ListSortDirection.Ascending);
                    Observation jj_ = context.Operators.First<Observation>(ji_);
                    DataType jk_ = jj_?.Effective;
                    object jl_ = FHIRHelpers_4_4_000.Instance.ToValue(context, jk_);

                    return (jl_ as CqlDateTime) as object;
                }
                else if (bu_())
                {
                    CqlValueSet ln_ = this.Oxygen_Saturation_by_Pulse_Oximetry(context);
                    IEnumerable<Observation> lo_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, ln_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
                    bool? lp_(Observation O2Saturation)
                    {
                        object lw_()
                        {
                            bool ml_()
                            {
                                DataType mo_ = O2Saturation?.Effective;
                                object mp_ = FHIRHelpers_4_4_000.Instance.ToValue(context, mo_);
                                bool mq_ = mp_ is CqlDateTime;

                                return mq_;
                            };
                            bool mm_()
                            {
                                DataType mr_ = O2Saturation?.Effective;
                                object ms_ = FHIRHelpers_4_4_000.Instance.ToValue(context, mr_);
                                bool mt_ = ms_ is CqlInterval<CqlDateTime>;

                                return mt_;
                            };
                            bool mn_()
                            {
                                DataType mu_ = O2Saturation?.Effective;
                                object mv_ = FHIRHelpers_4_4_000.Instance.ToValue(context, mu_);
                                bool mw_ = mv_ is CqlDateTime;

                                return mw_;
                            };
                            if (ml_())
                            {
                                DataType mx_ = O2Saturation?.Effective;
                                object my_ = FHIRHelpers_4_4_000.Instance.ToValue(context, mx_);

                                return (my_ as CqlDateTime) as object;
                            }
                            else if (mm_())
                            {
                                DataType mz_ = O2Saturation?.Effective;
                                object na_ = FHIRHelpers_4_4_000.Instance.ToValue(context, mz_);

                                return (na_ as CqlInterval<CqlDateTime>) as object;
                            }
                            else if (mn_())
                            {
                                DataType nb_ = O2Saturation?.Effective;
                                object nc_ = FHIRHelpers_4_4_000.Instance.ToValue(context, nb_);

                                return (nc_ as CqlDateTime) as object;
                            }
                            else
                            {
                                return null;
                            }
                        };
                        CqlDateTime lx_ = QICoreCommon_2_1_000.Instance.earliest(context, lw_());
                        CqlInterval<CqlDateTime> ly_ = CQMCommon_2_2_000.Instance.hospitalizationWithObservationAndOutpatientSurgeryService(context, EncounterInpatient);
                        bool? lz_ = context.Operators.In<CqlDateTime>(lx_, ly_, default);
                        Code<ObservationStatus> ma_ = O2Saturation?.StatusElement;
                        ObservationStatus? mb_ = ma_?.Value;
                        Code<ObservationStatus> mc_ = context.Operators.Convert<Code<ObservationStatus>>(mb_);
                        string md_ = context.Operators.Convert<string>(mc_);
                        string[] me_ = [
                            "final",
                            "amended",
                            "corrected",
                        ];
                        bool? mf_ = context.Operators.In<string>(md_, (IEnumerable<string>)me_);
                        bool? mg_ = context.Operators.And(lz_, mf_);
                        DataType mh_ = O2Saturation?.Value;
                        object mi_ = FHIRHelpers_4_4_000.Instance.ToValue(context, mh_);
                        bool? mj_ = context.Operators.Not((bool?)(mi_ is null));
                        bool? mk_ = context.Operators.And(mg_, mj_);

                        return mk_;
                    };
                    IEnumerable<Observation> lq_ = context.Operators.Where<Observation>(lo_, lp_);
                    object lr_(Observation @this)
                    {
                        object nd_()
                        {
                            bool nf_()
                            {
                                DataType ni_ = @this?.Effective;
                                object nj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ni_);
                                bool nk_ = nj_ is CqlDateTime;

                                return nk_;
                            };
                            bool ng_()
                            {
                                DataType nl_ = @this?.Effective;
                                object nm_ = FHIRHelpers_4_4_000.Instance.ToValue(context, nl_);
                                bool nn_ = nm_ is CqlInterval<CqlDateTime>;

                                return nn_;
                            };
                            bool nh_()
                            {
                                DataType no_ = @this?.Effective;
                                object np_ = FHIRHelpers_4_4_000.Instance.ToValue(context, no_);
                                bool nq_ = np_ is CqlDateTime;

                                return nq_;
                            };
                            if (nf_())
                            {
                                DataType nr_ = @this?.Effective;
                                object ns_ = FHIRHelpers_4_4_000.Instance.ToValue(context, nr_);

                                return (ns_ as CqlDateTime) as object;
                            }
                            else if (ng_())
                            {
                                DataType nt_ = @this?.Effective;
                                object nu_ = FHIRHelpers_4_4_000.Instance.ToValue(context, nt_);

                                return (nu_ as CqlInterval<CqlDateTime>) as object;
                            }
                            else if (nh_())
                            {
                                DataType nv_ = @this?.Effective;
                                object nw_ = FHIRHelpers_4_4_000.Instance.ToValue(context, nv_);

                                return (nw_ as CqlDateTime) as object;
                            }
                            else
                            {
                                return null;
                            }
                        };
                        CqlDateTime ne_ = QICoreCommon_2_1_000.Instance.earliest(context, nd_());

                        return ne_;
                    };
                    IEnumerable<Observation> ls_ = context.Operators.SortBy<Observation>(lq_, lr_, System.ComponentModel.ListSortDirection.Ascending);
                    Observation lt_ = context.Operators.First<Observation>(ls_);
                    DataType lu_ = lt_?.Effective;
                    object lv_ = FHIRHelpers_4_4_000.Instance.ToValue(context, lu_);

                    return (lv_ as CqlInterval<CqlDateTime>) as object;
                }
                else if (bv_())
                {
                    CqlValueSet nx_ = this.Oxygen_Saturation_by_Pulse_Oximetry(context);
                    IEnumerable<Observation> ny_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, nx_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
                    bool? nz_(Observation O2Saturation)
                    {
                        object og_()
                        {
                            bool ov_()
                            {
                                DataType oy_ = O2Saturation?.Effective;
                                object oz_ = FHIRHelpers_4_4_000.Instance.ToValue(context, oy_);
                                bool pa_ = oz_ is CqlDateTime;

                                return pa_;
                            };
                            bool ow_()
                            {
                                DataType pb_ = O2Saturation?.Effective;
                                object pc_ = FHIRHelpers_4_4_000.Instance.ToValue(context, pb_);
                                bool pd_ = pc_ is CqlInterval<CqlDateTime>;

                                return pd_;
                            };
                            bool ox_()
                            {
                                DataType pe_ = O2Saturation?.Effective;
                                object pf_ = FHIRHelpers_4_4_000.Instance.ToValue(context, pe_);
                                bool pg_ = pf_ is CqlDateTime;

                                return pg_;
                            };
                            if (ov_())
                            {
                                DataType ph_ = O2Saturation?.Effective;
                                object pi_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ph_);

                                return (pi_ as CqlDateTime) as object;
                            }
                            else if (ow_())
                            {
                                DataType pj_ = O2Saturation?.Effective;
                                object pk_ = FHIRHelpers_4_4_000.Instance.ToValue(context, pj_);

                                return (pk_ as CqlInterval<CqlDateTime>) as object;
                            }
                            else if (ox_())
                            {
                                DataType pl_ = O2Saturation?.Effective;
                                object pm_ = FHIRHelpers_4_4_000.Instance.ToValue(context, pl_);

                                return (pm_ as CqlDateTime) as object;
                            }
                            else
                            {
                                return null;
                            }
                        };
                        CqlDateTime oh_ = QICoreCommon_2_1_000.Instance.earliest(context, og_());
                        CqlInterval<CqlDateTime> oi_ = CQMCommon_2_2_000.Instance.hospitalizationWithObservationAndOutpatientSurgeryService(context, EncounterInpatient);
                        bool? oj_ = context.Operators.In<CqlDateTime>(oh_, oi_, default);
                        Code<ObservationStatus> ok_ = O2Saturation?.StatusElement;
                        ObservationStatus? ol_ = ok_?.Value;
                        Code<ObservationStatus> om_ = context.Operators.Convert<Code<ObservationStatus>>(ol_);
                        string on_ = context.Operators.Convert<string>(om_);
                        string[] oo_ = [
                            "final",
                            "amended",
                            "corrected",
                        ];
                        bool? op_ = context.Operators.In<string>(on_, (IEnumerable<string>)oo_);
                        bool? oq_ = context.Operators.And(oj_, op_);
                        DataType or_ = O2Saturation?.Value;
                        object os_ = FHIRHelpers_4_4_000.Instance.ToValue(context, or_);
                        bool? ot_ = context.Operators.Not((bool?)(os_ is null));
                        bool? ou_ = context.Operators.And(oq_, ot_);

                        return ou_;
                    };
                    IEnumerable<Observation> oa_ = context.Operators.Where<Observation>(ny_, nz_);
                    object ob_(Observation @this)
                    {
                        object pn_()
                        {
                            bool pp_()
                            {
                                DataType ps_ = @this?.Effective;
                                object pt_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ps_);
                                bool pu_ = pt_ is CqlDateTime;

                                return pu_;
                            };
                            bool pq_()
                            {
                                DataType pv_ = @this?.Effective;
                                object pw_ = FHIRHelpers_4_4_000.Instance.ToValue(context, pv_);
                                bool px_ = pw_ is CqlInterval<CqlDateTime>;

                                return px_;
                            };
                            bool pr_()
                            {
                                DataType py_ = @this?.Effective;
                                object pz_ = FHIRHelpers_4_4_000.Instance.ToValue(context, py_);
                                bool qa_ = pz_ is CqlDateTime;

                                return qa_;
                            };
                            if (pp_())
                            {
                                DataType qb_ = @this?.Effective;
                                object qc_ = FHIRHelpers_4_4_000.Instance.ToValue(context, qb_);

                                return (qc_ as CqlDateTime) as object;
                            }
                            else if (pq_())
                            {
                                DataType qd_ = @this?.Effective;
                                object qe_ = FHIRHelpers_4_4_000.Instance.ToValue(context, qd_);

                                return (qe_ as CqlInterval<CqlDateTime>) as object;
                            }
                            else if (pr_())
                            {
                                DataType qf_ = @this?.Effective;
                                object qg_ = FHIRHelpers_4_4_000.Instance.ToValue(context, qf_);

                                return (qg_ as CqlDateTime) as object;
                            }
                            else
                            {
                                return null;
                            }
                        };
                        CqlDateTime po_ = QICoreCommon_2_1_000.Instance.earliest(context, pn_());

                        return po_;
                    };
                    IEnumerable<Observation> oc_ = context.Operators.SortBy<Observation>(oa_, ob_, System.ComponentModel.ListSortDirection.Ascending);
                    Observation od_ = context.Operators.First<Observation>(oc_);
                    DataType oe_ = od_?.Effective;
                    object of_ = FHIRHelpers_4_4_000.Instance.ToValue(context, oe_);

                    return (of_ as CqlDateTime) as object;
                }
                else
                {
                    return null;
                }
            };
            CqlDateTime q_ = QICoreCommon_2_1_000.Instance.earliest(context, p_());
            (CqlTupleMetadata, string EncounterId, CqlQuantity FirstOxygenSatResult, CqlDateTime Timing)? r_ = (CqlTupleMetadata_FdREYEdHOZIcMCNYCRFJYJReA, f_, o_ as CqlQuantity, q_);

            return r_;
        };
        IEnumerable<(CqlTupleMetadata, string EncounterId, CqlQuantity FirstOxygenSatResult, CqlDateTime Timing)?> c_ = context.Operators.Select<Encounter, (CqlTupleMetadata, string EncounterId, CqlQuantity FirstOxygenSatResult, CqlDateTime Timing)?>(a_, b_);
        IEnumerable<(CqlTupleMetadata, string EncounterId, CqlQuantity FirstOxygenSatResult, CqlDateTime Timing)?> d_ = context.Operators.Distinct<(CqlTupleMetadata, string EncounterId, CqlQuantity FirstOxygenSatResult, CqlDateTime Timing)?>(c_);

        return d_;
    }


    [CqlExpressionDefinition("Encounter with First Respiratory Rate")]
    public IEnumerable<(CqlTupleMetadata, string EncounterId, CqlQuantity FirstRespRateResult, CqlDateTime Timing)?> Encounter_with_First_Respiratory_Rate(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Inpatient_Encounters(context);
        (CqlTupleMetadata, string EncounterId, CqlQuantity FirstRespRateResult, CqlDateTime Timing)? b_(Encounter EncounterInpatient)
        {
            Id e_ = EncounterInpatient?.IdElement;
            string f_ = e_?.Value;
            IEnumerable<Observation> g_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/StructureDefinition/resprate"));
            bool? h_(Observation RespRate)
            {
                DataType y_ = RespRate?.Effective;
                object z_ = FHIRHelpers_4_4_000.Instance.ToValue(context, y_);
                CqlDateTime aa_ = QICoreCommon_2_1_000.Instance.earliest(context, z_);
                CqlInterval<CqlDateTime> ab_ = CQMCommon_2_2_000.Instance.hospitalizationWithObservationAndOutpatientSurgeryService(context, EncounterInpatient);
                bool? ac_ = context.Operators.In<CqlDateTime>(aa_, ab_, default);
                Code<ObservationStatus> ad_ = RespRate?.StatusElement;
                ObservationStatus? ae_ = ad_?.Value;
                string af_ = context.Operators.Convert<string>(ae_);
                string[] ag_ = [
                    "final",
                    "amended",
                    "corrected",
                ];
                bool? ah_ = context.Operators.In<string>(af_, (IEnumerable<string>)ag_);
                bool? ai_ = context.Operators.And(ac_, ah_);
                DataType aj_ = RespRate?.Value;
                CqlQuantity ak_ = FHIRHelpers_4_4_000.Instance.ToQuantity(context, aj_ as Quantity);
                bool? al_ = context.Operators.Not((bool?)(ak_ is null));
                bool? am_ = context.Operators.And(ai_, al_);

                return am_;
            };
            IEnumerable<Observation> i_ = context.Operators.Where<Observation>(g_, h_);
            object j_(Observation @this)
            {
                DataType an_ = @this?.Effective;
                object ao_ = FHIRHelpers_4_4_000.Instance.ToValue(context, an_);
                CqlDateTime ap_ = QICoreCommon_2_1_000.Instance.earliest(context, ao_);

                return ap_;
            };
            IEnumerable<Observation> k_ = context.Operators.SortBy<Observation>(i_, j_, System.ComponentModel.ListSortDirection.Ascending);
            Observation l_ = context.Operators.First<Observation>(k_);
            DataType m_ = l_?.Value;
            CqlQuantity n_ = FHIRHelpers_4_4_000.Instance.ToQuantity(context, m_ as Quantity);
            bool? p_(Observation RespRate)
            {
                DataType aq_ = RespRate?.Effective;
                object ar_ = FHIRHelpers_4_4_000.Instance.ToValue(context, aq_);
                CqlDateTime as_ = QICoreCommon_2_1_000.Instance.earliest(context, ar_);
                CqlInterval<CqlDateTime> at_ = CQMCommon_2_2_000.Instance.hospitalizationWithObservationAndOutpatientSurgeryService(context, EncounterInpatient);
                bool? au_ = context.Operators.In<CqlDateTime>(as_, at_, default);
                Code<ObservationStatus> av_ = RespRate?.StatusElement;
                ObservationStatus? aw_ = av_?.Value;
                string ax_ = context.Operators.Convert<string>(aw_);
                string[] ay_ = [
                    "final",
                    "amended",
                    "corrected",
                ];
                bool? az_ = context.Operators.In<string>(ax_, (IEnumerable<string>)ay_);
                bool? ba_ = context.Operators.And(au_, az_);
                DataType bb_ = RespRate?.Value;
                CqlQuantity bc_ = FHIRHelpers_4_4_000.Instance.ToQuantity(context, bb_ as Quantity);
                bool? bd_ = context.Operators.Not((bool?)(bc_ is null));
                bool? be_ = context.Operators.And(ba_, bd_);

                return be_;
            };
            IEnumerable<Observation> q_ = context.Operators.Where<Observation>(g_, p_);
            object r_(Observation @this)
            {
                DataType bf_ = @this?.Effective;
                object bg_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bf_);
                CqlDateTime bh_ = QICoreCommon_2_1_000.Instance.earliest(context, bg_);

                return bh_;
            };
            IEnumerable<Observation> s_ = context.Operators.SortBy<Observation>(q_, r_, System.ComponentModel.ListSortDirection.Ascending);
            Observation t_ = context.Operators.First<Observation>(s_);
            DataType u_ = t_?.Effective;
            object v_ = FHIRHelpers_4_4_000.Instance.ToValue(context, u_);
            CqlDateTime w_ = QICoreCommon_2_1_000.Instance.earliest(context, v_);
            (CqlTupleMetadata, string EncounterId, CqlQuantity FirstRespRateResult, CqlDateTime Timing)? x_ = (CqlTupleMetadata_CYbMQaXdPgTVSLXJSHHNTbhVM, f_, n_ as CqlQuantity, w_);

            return x_;
        };
        IEnumerable<(CqlTupleMetadata, string EncounterId, CqlQuantity FirstRespRateResult, CqlDateTime Timing)?> c_ = context.Operators.Select<Encounter, (CqlTupleMetadata, string EncounterId, CqlQuantity FirstRespRateResult, CqlDateTime Timing)?>(a_, b_);
        IEnumerable<(CqlTupleMetadata, string EncounterId, CqlQuantity FirstRespRateResult, CqlDateTime Timing)?> d_ = context.Operators.Distinct<(CqlTupleMetadata, string EncounterId, CqlQuantity FirstRespRateResult, CqlDateTime Timing)?>(c_);

        return d_;
    }


    [CqlExpressionDefinition("Blood Pressure Reading")]
    public IEnumerable<Observation> Blood_Pressure_Reading(CqlContext context)
    {
        IEnumerable<Observation> a_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/StructureDefinition/bp"));
        bool? b_(Observation BloodPressure)
        {
            Code<ObservationStatus> d_ = BloodPressure?.StatusElement;
            ObservationStatus? e_ = d_?.Value;
            string f_ = context.Operators.Convert<string>(e_);
            string[] g_ = [
                "final",
                "amended",
                "corrected",
            ];
            bool? h_ = context.Operators.In<string>(f_, (IEnumerable<string>)g_);

            return h_;
        };
        IEnumerable<Observation> c_ = context.Operators.Where<Observation>(a_, b_);

        return c_;
    }


    [CqlExpressionDefinition("Encounter with First Systolic Blood Pressure")]
    public IEnumerable<string> Encounter_with_First_Systolic_Blood_Pressure(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Inpatient_Encounters(context);
        string b_(Encounter EncounterInpatient)
        {
            Id e_ = EncounterInpatient?.IdElement;
            string f_ = e_?.Value;

            return f_;
        };
        IEnumerable<string> c_ = context.Operators.Select<Encounter, string>(a_, b_);
        IEnumerable<string> d_ = context.Operators.Distinct<string>(c_);

        return d_;
    }


    [CqlExpressionDefinition("Encounter with First Bicarbonate Lab Test")]
    public IEnumerable<(CqlTupleMetadata, string EncounterId, CqlQuantity FirstResult, CqlDateTime Timing)?> Encounter_with_First_Bicarbonate_Lab_Test(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Inpatient_Encounters(context);
        (CqlTupleMetadata, string EncounterId, CqlQuantity FirstResult, CqlDateTime Timing)? b_(Encounter EncounterInpatient)
        {
            Id e_ = EncounterInpatient?.IdElement;
            string f_ = e_?.Value;
            CqlValueSet g_ = this.Bicarbonate_lab_test(context);
            IEnumerable<Observation> h_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, g_, default, "http://hl7.org/fhir/us/core/StructureDefinition/us-core-observation-lab"));
            bool? i_(Observation bicarbonatelab)
            {
                DataType aa_ = bicarbonatelab?.Effective;
                object ab_ = FHIRHelpers_4_4_000.Instance.ToValue(context, aa_);
                CqlDateTime ac_ = QICoreCommon_2_1_000.Instance.earliest(context, ab_);
                CqlInterval<CqlDateTime> ad_ = CQMCommon_2_2_000.Instance.hospitalizationWithObservationAndOutpatientSurgeryService(context, EncounterInpatient);
                bool? ae_ = context.Operators.In<CqlDateTime>(ac_, ad_, default);
                Code<ObservationStatus> af_ = bicarbonatelab?.StatusElement;
                ObservationStatus? ag_ = af_?.Value;
                string ah_ = context.Operators.Convert<string>(ag_);
                string[] ai_ = [
                    "final",
                    "amended",
                    "corrected",
                ];
                bool? aj_ = context.Operators.In<string>(ah_, (IEnumerable<string>)ai_);
                bool? ak_ = context.Operators.And(ae_, aj_);
                DataType al_ = bicarbonatelab?.Value;
                object am_ = FHIRHelpers_4_4_000.Instance.ToValue(context, al_);
                bool? an_ = context.Operators.Not((bool?)(am_ is null));
                bool? ao_ = context.Operators.And(ak_, an_);

                return ao_;
            };
            IEnumerable<Observation> j_ = context.Operators.Where<Observation>(h_, i_);
            object k_(Observation @this)
            {
                Instant ap_ = @this?.IssuedElement;
                DateTimeOffset? aq_ = ap_?.Value;
                CqlDateTime ar_ = context.Operators.Convert<CqlDateTime>(aq_);
                CqlDateTime as_ = QICoreCommon_2_1_000.Instance.earliest(context, ar_ as object);

                return as_;
            };
            IEnumerable<Observation> l_ = context.Operators.SortBy<Observation>(j_, k_, System.ComponentModel.ListSortDirection.Ascending);
            Observation m_ = context.Operators.First<Observation>(l_);
            DataType n_ = m_?.Value;
            object o_ = FHIRHelpers_4_4_000.Instance.ToValue(context, n_);
            IEnumerable<Observation> q_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, g_, default, "http://hl7.org/fhir/us/core/StructureDefinition/us-core-observation-lab"));
            bool? r_(Observation bicarbonatelab)
            {
                DataType at_ = bicarbonatelab?.Effective;
                object au_ = FHIRHelpers_4_4_000.Instance.ToValue(context, at_);
                CqlDateTime av_ = QICoreCommon_2_1_000.Instance.earliest(context, au_);
                CqlInterval<CqlDateTime> aw_ = CQMCommon_2_2_000.Instance.hospitalizationWithObservationAndOutpatientSurgeryService(context, EncounterInpatient);
                bool? ax_ = context.Operators.In<CqlDateTime>(av_, aw_, default);
                Code<ObservationStatus> ay_ = bicarbonatelab?.StatusElement;
                ObservationStatus? az_ = ay_?.Value;
                string ba_ = context.Operators.Convert<string>(az_);
                string[] bb_ = [
                    "final",
                    "amended",
                    "corrected",
                ];
                bool? bc_ = context.Operators.In<string>(ba_, (IEnumerable<string>)bb_);
                bool? bd_ = context.Operators.And(ax_, bc_);
                DataType be_ = bicarbonatelab?.Value;
                object bf_ = FHIRHelpers_4_4_000.Instance.ToValue(context, be_);
                bool? bg_ = context.Operators.Not((bool?)(bf_ is null));
                bool? bh_ = context.Operators.And(bd_, bg_);

                return bh_;
            };
            IEnumerable<Observation> s_ = context.Operators.Where<Observation>(q_, r_);
            object t_(Observation @this)
            {
                Instant bi_ = @this?.IssuedElement;
                DateTimeOffset? bj_ = bi_?.Value;
                CqlDateTime bk_ = context.Operators.Convert<CqlDateTime>(bj_);
                CqlDateTime bl_ = QICoreCommon_2_1_000.Instance.earliest(context, bk_ as object);

                return bl_;
            };
            IEnumerable<Observation> u_ = context.Operators.SortBy<Observation>(s_, t_, System.ComponentModel.ListSortDirection.Ascending);
            Observation v_ = context.Operators.First<Observation>(u_);
            Instant w_ = v_?.IssuedElement;
            DateTimeOffset? x_ = w_?.Value;
            CqlDateTime y_ = context.Operators.Convert<CqlDateTime>(x_);
            (CqlTupleMetadata, string EncounterId, CqlQuantity FirstResult, CqlDateTime Timing)? z_ = (CqlTupleMetadata_HDVhZFAYAdGHPZJWcDFSNFGPd, f_, o_ as CqlQuantity, y_);

            return z_;
        };
        IEnumerable<(CqlTupleMetadata, string EncounterId, CqlQuantity FirstResult, CqlDateTime Timing)?> c_ = context.Operators.Select<Encounter, (CqlTupleMetadata, string EncounterId, CqlQuantity FirstResult, CqlDateTime Timing)?>(a_, b_);
        IEnumerable<(CqlTupleMetadata, string EncounterId, CqlQuantity FirstResult, CqlDateTime Timing)?> d_ = context.Operators.Distinct<(CqlTupleMetadata, string EncounterId, CqlQuantity FirstResult, CqlDateTime Timing)?>(c_);

        return d_;
    }


    [CqlExpressionDefinition("Encounter with First Creatinine Lab Test")]
    public IEnumerable<(CqlTupleMetadata, string EncounterId, CqlQuantity FirstResult, CqlDateTime Timing)?> Encounter_with_First_Creatinine_Lab_Test(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Inpatient_Encounters(context);
        (CqlTupleMetadata, string EncounterId, CqlQuantity FirstResult, CqlDateTime Timing)? b_(Encounter EncounterInpatient)
        {
            Id e_ = EncounterInpatient?.IdElement;
            string f_ = e_?.Value;
            CqlValueSet g_ = this.Creatinine_lab_test(context);
            IEnumerable<Observation> h_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, g_, default, "http://hl7.org/fhir/us/core/StructureDefinition/us-core-observation-lab"));
            bool? i_(Observation CreatinineLab)
            {
                DataType aa_ = CreatinineLab?.Effective;
                object ab_ = FHIRHelpers_4_4_000.Instance.ToValue(context, aa_);
                CqlDateTime ac_ = QICoreCommon_2_1_000.Instance.earliest(context, ab_);
                CqlInterval<CqlDateTime> ad_ = CQMCommon_2_2_000.Instance.hospitalizationWithObservationAndOutpatientSurgeryService(context, EncounterInpatient);
                bool? ae_ = context.Operators.In<CqlDateTime>(ac_, ad_, default);
                Code<ObservationStatus> af_ = CreatinineLab?.StatusElement;
                ObservationStatus? ag_ = af_?.Value;
                string ah_ = context.Operators.Convert<string>(ag_);
                string[] ai_ = [
                    "final",
                    "amended",
                    "corrected",
                ];
                bool? aj_ = context.Operators.In<string>(ah_, (IEnumerable<string>)ai_);
                bool? ak_ = context.Operators.And(ae_, aj_);
                DataType al_ = CreatinineLab?.Value;
                object am_ = FHIRHelpers_4_4_000.Instance.ToValue(context, al_);
                bool? an_ = context.Operators.Not((bool?)(am_ is null));
                bool? ao_ = context.Operators.And(ak_, an_);

                return ao_;
            };
            IEnumerable<Observation> j_ = context.Operators.Where<Observation>(h_, i_);
            object k_(Observation @this)
            {
                Instant ap_ = @this?.IssuedElement;
                DateTimeOffset? aq_ = ap_?.Value;
                CqlDateTime ar_ = context.Operators.Convert<CqlDateTime>(aq_);
                CqlDateTime as_ = QICoreCommon_2_1_000.Instance.earliest(context, ar_ as object);

                return as_;
            };
            IEnumerable<Observation> l_ = context.Operators.SortBy<Observation>(j_, k_, System.ComponentModel.ListSortDirection.Ascending);
            Observation m_ = context.Operators.First<Observation>(l_);
            DataType n_ = m_?.Value;
            object o_ = FHIRHelpers_4_4_000.Instance.ToValue(context, n_);
            IEnumerable<Observation> q_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, g_, default, "http://hl7.org/fhir/us/core/StructureDefinition/us-core-observation-lab"));
            bool? r_(Observation CreatinineLab)
            {
                DataType at_ = CreatinineLab?.Effective;
                object au_ = FHIRHelpers_4_4_000.Instance.ToValue(context, at_);
                CqlDateTime av_ = QICoreCommon_2_1_000.Instance.earliest(context, au_);
                CqlInterval<CqlDateTime> aw_ = CQMCommon_2_2_000.Instance.hospitalizationWithObservationAndOutpatientSurgeryService(context, EncounterInpatient);
                bool? ax_ = context.Operators.In<CqlDateTime>(av_, aw_, default);
                Code<ObservationStatus> ay_ = CreatinineLab?.StatusElement;
                ObservationStatus? az_ = ay_?.Value;
                string ba_ = context.Operators.Convert<string>(az_);
                string[] bb_ = [
                    "final",
                    "amended",
                    "corrected",
                ];
                bool? bc_ = context.Operators.In<string>(ba_, (IEnumerable<string>)bb_);
                bool? bd_ = context.Operators.And(ax_, bc_);
                DataType be_ = CreatinineLab?.Value;
                object bf_ = FHIRHelpers_4_4_000.Instance.ToValue(context, be_);
                bool? bg_ = context.Operators.Not((bool?)(bf_ is null));
                bool? bh_ = context.Operators.And(bd_, bg_);

                return bh_;
            };
            IEnumerable<Observation> s_ = context.Operators.Where<Observation>(q_, r_);
            object t_(Observation @this)
            {
                Instant bi_ = @this?.IssuedElement;
                DateTimeOffset? bj_ = bi_?.Value;
                CqlDateTime bk_ = context.Operators.Convert<CqlDateTime>(bj_);
                CqlDateTime bl_ = QICoreCommon_2_1_000.Instance.earliest(context, bk_ as object);

                return bl_;
            };
            IEnumerable<Observation> u_ = context.Operators.SortBy<Observation>(s_, t_, System.ComponentModel.ListSortDirection.Ascending);
            Observation v_ = context.Operators.First<Observation>(u_);
            Instant w_ = v_?.IssuedElement;
            DateTimeOffset? x_ = w_?.Value;
            CqlDateTime y_ = context.Operators.Convert<CqlDateTime>(x_);
            (CqlTupleMetadata, string EncounterId, CqlQuantity FirstResult, CqlDateTime Timing)? z_ = (CqlTupleMetadata_HDVhZFAYAdGHPZJWcDFSNFGPd, f_, o_ as CqlQuantity, y_);

            return z_;
        };
        IEnumerable<(CqlTupleMetadata, string EncounterId, CqlQuantity FirstResult, CqlDateTime Timing)?> c_ = context.Operators.Select<Encounter, (CqlTupleMetadata, string EncounterId, CqlQuantity FirstResult, CqlDateTime Timing)?>(a_, b_);
        IEnumerable<(CqlTupleMetadata, string EncounterId, CqlQuantity FirstResult, CqlDateTime Timing)?> d_ = context.Operators.Distinct<(CqlTupleMetadata, string EncounterId, CqlQuantity FirstResult, CqlDateTime Timing)?>(c_);

        return d_;
    }


    [CqlExpressionDefinition("Encounter with First Glucose Lab Test")]
    public IEnumerable<(CqlTupleMetadata, string EncounterId, CqlQuantity FirstResult, CqlDateTime Timing)?> Encounter_with_First_Glucose_Lab_Test(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Inpatient_Encounters(context);
        (CqlTupleMetadata, string EncounterId, CqlQuantity FirstResult, CqlDateTime Timing)? b_(Encounter EncounterInpatient)
        {
            Id e_ = EncounterInpatient?.IdElement;
            string f_ = e_?.Value;
            CqlValueSet g_ = this.Glucose_lab_test(context);
            IEnumerable<Observation> h_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, g_, default, "http://hl7.org/fhir/us/core/StructureDefinition/us-core-observation-lab"));
            bool? i_(Observation GlucoseLab)
            {
                DataType aa_ = GlucoseLab?.Effective;
                object ab_ = FHIRHelpers_4_4_000.Instance.ToValue(context, aa_);
                CqlDateTime ac_ = QICoreCommon_2_1_000.Instance.earliest(context, ab_);
                CqlInterval<CqlDateTime> ad_ = CQMCommon_2_2_000.Instance.hospitalizationWithObservationAndOutpatientSurgeryService(context, EncounterInpatient);
                bool? ae_ = context.Operators.In<CqlDateTime>(ac_, ad_, default);
                Code<ObservationStatus> af_ = GlucoseLab?.StatusElement;
                ObservationStatus? ag_ = af_?.Value;
                string ah_ = context.Operators.Convert<string>(ag_);
                string[] ai_ = [
                    "final",
                    "amended",
                    "corrected",
                ];
                bool? aj_ = context.Operators.In<string>(ah_, (IEnumerable<string>)ai_);
                bool? ak_ = context.Operators.And(ae_, aj_);
                DataType al_ = GlucoseLab?.Value;
                object am_ = FHIRHelpers_4_4_000.Instance.ToValue(context, al_);
                bool? an_ = context.Operators.Not((bool?)(am_ is null));
                bool? ao_ = context.Operators.And(ak_, an_);

                return ao_;
            };
            IEnumerable<Observation> j_ = context.Operators.Where<Observation>(h_, i_);
            object k_(Observation @this)
            {
                Instant ap_ = @this?.IssuedElement;
                DateTimeOffset? aq_ = ap_?.Value;
                CqlDateTime ar_ = context.Operators.Convert<CqlDateTime>(aq_);
                CqlDateTime as_ = QICoreCommon_2_1_000.Instance.earliest(context, ar_ as object);

                return as_;
            };
            IEnumerable<Observation> l_ = context.Operators.SortBy<Observation>(j_, k_, System.ComponentModel.ListSortDirection.Ascending);
            Observation m_ = context.Operators.First<Observation>(l_);
            DataType n_ = m_?.Value;
            object o_ = FHIRHelpers_4_4_000.Instance.ToValue(context, n_);
            IEnumerable<Observation> q_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, g_, default, "http://hl7.org/fhir/us/core/StructureDefinition/us-core-observation-lab"));
            bool? r_(Observation GlucoseLab)
            {
                DataType at_ = GlucoseLab?.Effective;
                object au_ = FHIRHelpers_4_4_000.Instance.ToValue(context, at_);
                CqlDateTime av_ = QICoreCommon_2_1_000.Instance.earliest(context, au_);
                CqlInterval<CqlDateTime> aw_ = CQMCommon_2_2_000.Instance.hospitalizationWithObservationAndOutpatientSurgeryService(context, EncounterInpatient);
                bool? ax_ = context.Operators.In<CqlDateTime>(av_, aw_, default);
                Code<ObservationStatus> ay_ = GlucoseLab?.StatusElement;
                ObservationStatus? az_ = ay_?.Value;
                string ba_ = context.Operators.Convert<string>(az_);
                string[] bb_ = [
                    "final",
                    "amended",
                    "corrected",
                ];
                bool? bc_ = context.Operators.In<string>(ba_, (IEnumerable<string>)bb_);
                bool? bd_ = context.Operators.And(ax_, bc_);
                DataType be_ = GlucoseLab?.Value;
                object bf_ = FHIRHelpers_4_4_000.Instance.ToValue(context, be_);
                bool? bg_ = context.Operators.Not((bool?)(bf_ is null));
                bool? bh_ = context.Operators.And(bd_, bg_);

                return bh_;
            };
            IEnumerable<Observation> s_ = context.Operators.Where<Observation>(q_, r_);
            object t_(Observation @this)
            {
                Instant bi_ = @this?.IssuedElement;
                DateTimeOffset? bj_ = bi_?.Value;
                CqlDateTime bk_ = context.Operators.Convert<CqlDateTime>(bj_);
                CqlDateTime bl_ = QICoreCommon_2_1_000.Instance.earliest(context, bk_ as object);

                return bl_;
            };
            IEnumerable<Observation> u_ = context.Operators.SortBy<Observation>(s_, t_, System.ComponentModel.ListSortDirection.Ascending);
            Observation v_ = context.Operators.First<Observation>(u_);
            Instant w_ = v_?.IssuedElement;
            DateTimeOffset? x_ = w_?.Value;
            CqlDateTime y_ = context.Operators.Convert<CqlDateTime>(x_);
            (CqlTupleMetadata, string EncounterId, CqlQuantity FirstResult, CqlDateTime Timing)? z_ = (CqlTupleMetadata_HDVhZFAYAdGHPZJWcDFSNFGPd, f_, o_ as CqlQuantity, y_);

            return z_;
        };
        IEnumerable<(CqlTupleMetadata, string EncounterId, CqlQuantity FirstResult, CqlDateTime Timing)?> c_ = context.Operators.Select<Encounter, (CqlTupleMetadata, string EncounterId, CqlQuantity FirstResult, CqlDateTime Timing)?>(a_, b_);
        IEnumerable<(CqlTupleMetadata, string EncounterId, CqlQuantity FirstResult, CqlDateTime Timing)?> d_ = context.Operators.Distinct<(CqlTupleMetadata, string EncounterId, CqlQuantity FirstResult, CqlDateTime Timing)?>(c_);

        return d_;
    }


    [CqlExpressionDefinition("Encounter with First Hematocrit Lab Test")]
    public IEnumerable<(CqlTupleMetadata, string EncounterId, CqlQuantity FirstResult, CqlDateTime Timing)?> Encounter_with_First_Hematocrit_Lab_Test(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Inpatient_Encounters(context);
        (CqlTupleMetadata, string EncounterId, CqlQuantity FirstResult, CqlDateTime Timing)? b_(Encounter EncounterInpatient)
        {
            Id e_ = EncounterInpatient?.IdElement;
            string f_ = e_?.Value;
            CqlValueSet g_ = this.Hematocrit_lab_test(context);
            IEnumerable<Observation> h_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, g_, default, "http://hl7.org/fhir/us/core/StructureDefinition/us-core-observation-lab"));
            bool? i_(Observation HematocritLab)
            {
                DataType aa_ = HematocritLab?.Effective;
                object ab_ = FHIRHelpers_4_4_000.Instance.ToValue(context, aa_);
                CqlDateTime ac_ = QICoreCommon_2_1_000.Instance.earliest(context, ab_);
                CqlInterval<CqlDateTime> ad_ = CQMCommon_2_2_000.Instance.hospitalizationWithObservationAndOutpatientSurgeryService(context, EncounterInpatient);
                bool? ae_ = context.Operators.In<CqlDateTime>(ac_, ad_, default);
                Code<ObservationStatus> af_ = HematocritLab?.StatusElement;
                ObservationStatus? ag_ = af_?.Value;
                string ah_ = context.Operators.Convert<string>(ag_);
                string[] ai_ = [
                    "final",
                    "amended",
                    "corrected",
                ];
                bool? aj_ = context.Operators.In<string>(ah_, (IEnumerable<string>)ai_);
                bool? ak_ = context.Operators.And(ae_, aj_);
                DataType al_ = HematocritLab?.Value;
                object am_ = FHIRHelpers_4_4_000.Instance.ToValue(context, al_);
                bool? an_ = context.Operators.Not((bool?)(am_ is null));
                bool? ao_ = context.Operators.And(ak_, an_);

                return ao_;
            };
            IEnumerable<Observation> j_ = context.Operators.Where<Observation>(h_, i_);
            object k_(Observation @this)
            {
                Instant ap_ = @this?.IssuedElement;
                DateTimeOffset? aq_ = ap_?.Value;
                CqlDateTime ar_ = context.Operators.Convert<CqlDateTime>(aq_);
                CqlDateTime as_ = QICoreCommon_2_1_000.Instance.earliest(context, ar_ as object);

                return as_;
            };
            IEnumerable<Observation> l_ = context.Operators.SortBy<Observation>(j_, k_, System.ComponentModel.ListSortDirection.Ascending);
            Observation m_ = context.Operators.First<Observation>(l_);
            DataType n_ = m_?.Value;
            object o_ = FHIRHelpers_4_4_000.Instance.ToValue(context, n_);
            IEnumerable<Observation> q_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, g_, default, "http://hl7.org/fhir/us/core/StructureDefinition/us-core-observation-lab"));
            bool? r_(Observation HematocritLab)
            {
                DataType at_ = HematocritLab?.Effective;
                object au_ = FHIRHelpers_4_4_000.Instance.ToValue(context, at_);
                CqlDateTime av_ = QICoreCommon_2_1_000.Instance.earliest(context, au_);
                CqlInterval<CqlDateTime> aw_ = CQMCommon_2_2_000.Instance.hospitalizationWithObservationAndOutpatientSurgeryService(context, EncounterInpatient);
                bool? ax_ = context.Operators.In<CqlDateTime>(av_, aw_, default);
                Code<ObservationStatus> ay_ = HematocritLab?.StatusElement;
                ObservationStatus? az_ = ay_?.Value;
                string ba_ = context.Operators.Convert<string>(az_);
                string[] bb_ = [
                    "final",
                    "amended",
                    "corrected",
                ];
                bool? bc_ = context.Operators.In<string>(ba_, (IEnumerable<string>)bb_);
                bool? bd_ = context.Operators.And(ax_, bc_);
                DataType be_ = HematocritLab?.Value;
                object bf_ = FHIRHelpers_4_4_000.Instance.ToValue(context, be_);
                bool? bg_ = context.Operators.Not((bool?)(bf_ is null));
                bool? bh_ = context.Operators.And(bd_, bg_);

                return bh_;
            };
            IEnumerable<Observation> s_ = context.Operators.Where<Observation>(q_, r_);
            object t_(Observation @this)
            {
                Instant bi_ = @this?.IssuedElement;
                DateTimeOffset? bj_ = bi_?.Value;
                CqlDateTime bk_ = context.Operators.Convert<CqlDateTime>(bj_);
                CqlDateTime bl_ = QICoreCommon_2_1_000.Instance.earliest(context, bk_ as object);

                return bl_;
            };
            IEnumerable<Observation> u_ = context.Operators.SortBy<Observation>(s_, t_, System.ComponentModel.ListSortDirection.Ascending);
            Observation v_ = context.Operators.First<Observation>(u_);
            Instant w_ = v_?.IssuedElement;
            DateTimeOffset? x_ = w_?.Value;
            CqlDateTime y_ = context.Operators.Convert<CqlDateTime>(x_);
            (CqlTupleMetadata, string EncounterId, CqlQuantity FirstResult, CqlDateTime Timing)? z_ = (CqlTupleMetadata_HDVhZFAYAdGHPZJWcDFSNFGPd, f_, o_ as CqlQuantity, y_);

            return z_;
        };
        IEnumerable<(CqlTupleMetadata, string EncounterId, CqlQuantity FirstResult, CqlDateTime Timing)?> c_ = context.Operators.Select<Encounter, (CqlTupleMetadata, string EncounterId, CqlQuantity FirstResult, CqlDateTime Timing)?>(a_, b_);
        IEnumerable<(CqlTupleMetadata, string EncounterId, CqlQuantity FirstResult, CqlDateTime Timing)?> d_ = context.Operators.Distinct<(CqlTupleMetadata, string EncounterId, CqlQuantity FirstResult, CqlDateTime Timing)?>(c_);

        return d_;
    }


    [CqlExpressionDefinition("Encounter with First Potassium Lab Test")]
    public IEnumerable<(CqlTupleMetadata, string EncounterId, CqlQuantity FirstResult, CqlDateTime Timing)?> Encounter_with_First_Potassium_Lab_Test(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Inpatient_Encounters(context);
        (CqlTupleMetadata, string EncounterId, CqlQuantity FirstResult, CqlDateTime Timing)? b_(Encounter EncounterInpatient)
        {
            Id e_ = EncounterInpatient?.IdElement;
            string f_ = e_?.Value;
            CqlValueSet g_ = this.Potassium_lab_test(context);
            IEnumerable<Observation> h_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, g_, default, "http://hl7.org/fhir/us/core/StructureDefinition/us-core-observation-lab"));
            bool? i_(Observation PotassiumLab)
            {
                DataType aa_ = PotassiumLab?.Effective;
                object ab_ = FHIRHelpers_4_4_000.Instance.ToValue(context, aa_);
                CqlDateTime ac_ = QICoreCommon_2_1_000.Instance.earliest(context, ab_);
                CqlInterval<CqlDateTime> ad_ = CQMCommon_2_2_000.Instance.hospitalizationWithObservationAndOutpatientSurgeryService(context, EncounterInpatient);
                bool? ae_ = context.Operators.In<CqlDateTime>(ac_, ad_, default);
                Code<ObservationStatus> af_ = PotassiumLab?.StatusElement;
                ObservationStatus? ag_ = af_?.Value;
                string ah_ = context.Operators.Convert<string>(ag_);
                string[] ai_ = [
                    "final",
                    "amended",
                    "corrected",
                ];
                bool? aj_ = context.Operators.In<string>(ah_, (IEnumerable<string>)ai_);
                bool? ak_ = context.Operators.And(ae_, aj_);
                DataType al_ = PotassiumLab?.Value;
                object am_ = FHIRHelpers_4_4_000.Instance.ToValue(context, al_);
                bool? an_ = context.Operators.Not((bool?)(am_ is null));
                bool? ao_ = context.Operators.And(ak_, an_);

                return ao_;
            };
            IEnumerable<Observation> j_ = context.Operators.Where<Observation>(h_, i_);
            object k_(Observation @this)
            {
                Instant ap_ = @this?.IssuedElement;
                DateTimeOffset? aq_ = ap_?.Value;
                CqlDateTime ar_ = context.Operators.Convert<CqlDateTime>(aq_);
                CqlDateTime as_ = QICoreCommon_2_1_000.Instance.earliest(context, ar_ as object);

                return as_;
            };
            IEnumerable<Observation> l_ = context.Operators.SortBy<Observation>(j_, k_, System.ComponentModel.ListSortDirection.Ascending);
            Observation m_ = context.Operators.First<Observation>(l_);
            DataType n_ = m_?.Value;
            object o_ = FHIRHelpers_4_4_000.Instance.ToValue(context, n_);
            IEnumerable<Observation> q_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, g_, default, "http://hl7.org/fhir/us/core/StructureDefinition/us-core-observation-lab"));
            bool? r_(Observation PotassiumLab)
            {
                DataType at_ = PotassiumLab?.Effective;
                object au_ = FHIRHelpers_4_4_000.Instance.ToValue(context, at_);
                CqlDateTime av_ = QICoreCommon_2_1_000.Instance.earliest(context, au_);
                CqlInterval<CqlDateTime> aw_ = CQMCommon_2_2_000.Instance.hospitalizationWithObservationAndOutpatientSurgeryService(context, EncounterInpatient);
                bool? ax_ = context.Operators.In<CqlDateTime>(av_, aw_, default);
                Code<ObservationStatus> ay_ = PotassiumLab?.StatusElement;
                ObservationStatus? az_ = ay_?.Value;
                string ba_ = context.Operators.Convert<string>(az_);
                string[] bb_ = [
                    "final",
                    "amended",
                    "corrected",
                ];
                bool? bc_ = context.Operators.In<string>(ba_, (IEnumerable<string>)bb_);
                bool? bd_ = context.Operators.And(ax_, bc_);
                DataType be_ = PotassiumLab?.Value;
                object bf_ = FHIRHelpers_4_4_000.Instance.ToValue(context, be_);
                bool? bg_ = context.Operators.Not((bool?)(bf_ is null));
                bool? bh_ = context.Operators.And(bd_, bg_);

                return bh_;
            };
            IEnumerable<Observation> s_ = context.Operators.Where<Observation>(q_, r_);
            object t_(Observation @this)
            {
                Instant bi_ = @this?.IssuedElement;
                DateTimeOffset? bj_ = bi_?.Value;
                CqlDateTime bk_ = context.Operators.Convert<CqlDateTime>(bj_);
                CqlDateTime bl_ = QICoreCommon_2_1_000.Instance.earliest(context, bk_ as object);

                return bl_;
            };
            IEnumerable<Observation> u_ = context.Operators.SortBy<Observation>(s_, t_, System.ComponentModel.ListSortDirection.Ascending);
            Observation v_ = context.Operators.First<Observation>(u_);
            Instant w_ = v_?.IssuedElement;
            DateTimeOffset? x_ = w_?.Value;
            CqlDateTime y_ = context.Operators.Convert<CqlDateTime>(x_);
            (CqlTupleMetadata, string EncounterId, CqlQuantity FirstResult, CqlDateTime Timing)? z_ = (CqlTupleMetadata_HDVhZFAYAdGHPZJWcDFSNFGPd, f_, o_ as CqlQuantity, y_);

            return z_;
        };
        IEnumerable<(CqlTupleMetadata, string EncounterId, CqlQuantity FirstResult, CqlDateTime Timing)?> c_ = context.Operators.Select<Encounter, (CqlTupleMetadata, string EncounterId, CqlQuantity FirstResult, CqlDateTime Timing)?>(a_, b_);
        IEnumerable<(CqlTupleMetadata, string EncounterId, CqlQuantity FirstResult, CqlDateTime Timing)?> d_ = context.Operators.Distinct<(CqlTupleMetadata, string EncounterId, CqlQuantity FirstResult, CqlDateTime Timing)?>(c_);

        return d_;
    }


    [CqlExpressionDefinition("Encounter with First Sodium Lab Test")]
    public IEnumerable<(CqlTupleMetadata, string EncounterId, CqlQuantity FirstResult, CqlDateTime Timing)?> Encounter_with_First_Sodium_Lab_Test(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Inpatient_Encounters(context);
        (CqlTupleMetadata, string EncounterId, CqlQuantity FirstResult, CqlDateTime Timing)? b_(Encounter EncounterInpatient)
        {
            Id e_ = EncounterInpatient?.IdElement;
            string f_ = e_?.Value;
            CqlValueSet g_ = this.Sodium_lab_test(context);
            IEnumerable<Observation> h_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, g_, default, "http://hl7.org/fhir/us/core/StructureDefinition/us-core-observation-lab"));
            bool? i_(Observation SodiumLab)
            {
                DataType aa_ = SodiumLab?.Effective;
                object ab_ = FHIRHelpers_4_4_000.Instance.ToValue(context, aa_);
                CqlDateTime ac_ = QICoreCommon_2_1_000.Instance.earliest(context, ab_);
                CqlInterval<CqlDateTime> ad_ = CQMCommon_2_2_000.Instance.hospitalizationWithObservationAndOutpatientSurgeryService(context, EncounterInpatient);
                bool? ae_ = context.Operators.In<CqlDateTime>(ac_, ad_, default);
                Code<ObservationStatus> af_ = SodiumLab?.StatusElement;
                ObservationStatus? ag_ = af_?.Value;
                string ah_ = context.Operators.Convert<string>(ag_);
                string[] ai_ = [
                    "final",
                    "amended",
                    "corrected",
                ];
                bool? aj_ = context.Operators.In<string>(ah_, (IEnumerable<string>)ai_);
                bool? ak_ = context.Operators.And(ae_, aj_);
                DataType al_ = SodiumLab?.Value;
                object am_ = FHIRHelpers_4_4_000.Instance.ToValue(context, al_);
                bool? an_ = context.Operators.Not((bool?)(am_ is null));
                bool? ao_ = context.Operators.And(ak_, an_);

                return ao_;
            };
            IEnumerable<Observation> j_ = context.Operators.Where<Observation>(h_, i_);
            object k_(Observation @this)
            {
                Instant ap_ = @this?.IssuedElement;
                DateTimeOffset? aq_ = ap_?.Value;
                CqlDateTime ar_ = context.Operators.Convert<CqlDateTime>(aq_);
                CqlDateTime as_ = QICoreCommon_2_1_000.Instance.earliest(context, ar_ as object);

                return as_;
            };
            IEnumerable<Observation> l_ = context.Operators.SortBy<Observation>(j_, k_, System.ComponentModel.ListSortDirection.Ascending);
            Observation m_ = context.Operators.First<Observation>(l_);
            DataType n_ = m_?.Value;
            object o_ = FHIRHelpers_4_4_000.Instance.ToValue(context, n_);
            IEnumerable<Observation> q_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, g_, default, "http://hl7.org/fhir/us/core/StructureDefinition/us-core-observation-lab"));
            bool? r_(Observation SodiumLab)
            {
                DataType at_ = SodiumLab?.Effective;
                object au_ = FHIRHelpers_4_4_000.Instance.ToValue(context, at_);
                CqlDateTime av_ = QICoreCommon_2_1_000.Instance.earliest(context, au_);
                CqlInterval<CqlDateTime> aw_ = CQMCommon_2_2_000.Instance.hospitalizationWithObservationAndOutpatientSurgeryService(context, EncounterInpatient);
                bool? ax_ = context.Operators.In<CqlDateTime>(av_, aw_, default);
                Code<ObservationStatus> ay_ = SodiumLab?.StatusElement;
                ObservationStatus? az_ = ay_?.Value;
                string ba_ = context.Operators.Convert<string>(az_);
                string[] bb_ = [
                    "final",
                    "amended",
                    "corrected",
                ];
                bool? bc_ = context.Operators.In<string>(ba_, (IEnumerable<string>)bb_);
                bool? bd_ = context.Operators.And(ax_, bc_);
                DataType be_ = SodiumLab?.Value;
                object bf_ = FHIRHelpers_4_4_000.Instance.ToValue(context, be_);
                bool? bg_ = context.Operators.Not((bool?)(bf_ is null));
                bool? bh_ = context.Operators.And(bd_, bg_);

                return bh_;
            };
            IEnumerable<Observation> s_ = context.Operators.Where<Observation>(q_, r_);
            object t_(Observation @this)
            {
                Instant bi_ = @this?.IssuedElement;
                DateTimeOffset? bj_ = bi_?.Value;
                CqlDateTime bk_ = context.Operators.Convert<CqlDateTime>(bj_);
                CqlDateTime bl_ = QICoreCommon_2_1_000.Instance.earliest(context, bk_ as object);

                return bl_;
            };
            IEnumerable<Observation> u_ = context.Operators.SortBy<Observation>(s_, t_, System.ComponentModel.ListSortDirection.Ascending);
            Observation v_ = context.Operators.First<Observation>(u_);
            Instant w_ = v_?.IssuedElement;
            DateTimeOffset? x_ = w_?.Value;
            CqlDateTime y_ = context.Operators.Convert<CqlDateTime>(x_);
            (CqlTupleMetadata, string EncounterId, CqlQuantity FirstResult, CqlDateTime Timing)? z_ = (CqlTupleMetadata_HDVhZFAYAdGHPZJWcDFSNFGPd, f_, o_ as CqlQuantity, y_);

            return z_;
        };
        IEnumerable<(CqlTupleMetadata, string EncounterId, CqlQuantity FirstResult, CqlDateTime Timing)?> c_ = context.Operators.Select<Encounter, (CqlTupleMetadata, string EncounterId, CqlQuantity FirstResult, CqlDateTime Timing)?>(a_, b_);
        IEnumerable<(CqlTupleMetadata, string EncounterId, CqlQuantity FirstResult, CqlDateTime Timing)?> d_ = context.Operators.Distinct<(CqlTupleMetadata, string EncounterId, CqlQuantity FirstResult, CqlDateTime Timing)?>(c_);

        return d_;
    }


    [CqlExpressionDefinition("Encounter with First White Blood Cells Lab Test")]
    public IEnumerable<(CqlTupleMetadata, string EncounterId, CqlQuantity FirstResult, CqlDateTime Timing)?> Encounter_with_First_White_Blood_Cells_Lab_Test(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Inpatient_Encounters(context);
        (CqlTupleMetadata, string EncounterId, CqlQuantity FirstResult, CqlDateTime Timing)? b_(Encounter EncounterInpatient)
        {
            Id e_ = EncounterInpatient?.IdElement;
            string f_ = e_?.Value;
            CqlValueSet g_ = this.White_blood_cells_count_lab_test(context);
            IEnumerable<Observation> h_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, g_, default, "http://hl7.org/fhir/us/core/StructureDefinition/us-core-observation-lab"));
            bool? i_(Observation WhiteBloodCellLab)
            {
                DataType aa_ = WhiteBloodCellLab?.Effective;
                object ab_ = FHIRHelpers_4_4_000.Instance.ToValue(context, aa_);
                CqlDateTime ac_ = QICoreCommon_2_1_000.Instance.earliest(context, ab_);
                CqlInterval<CqlDateTime> ad_ = CQMCommon_2_2_000.Instance.hospitalizationWithObservationAndOutpatientSurgeryService(context, EncounterInpatient);
                bool? ae_ = context.Operators.In<CqlDateTime>(ac_, ad_, default);
                Code<ObservationStatus> af_ = WhiteBloodCellLab?.StatusElement;
                ObservationStatus? ag_ = af_?.Value;
                string ah_ = context.Operators.Convert<string>(ag_);
                string[] ai_ = [
                    "final",
                    "amended",
                    "corrected",
                ];
                bool? aj_ = context.Operators.In<string>(ah_, (IEnumerable<string>)ai_);
                bool? ak_ = context.Operators.And(ae_, aj_);
                DataType al_ = WhiteBloodCellLab?.Value;
                object am_ = FHIRHelpers_4_4_000.Instance.ToValue(context, al_);
                bool? an_ = context.Operators.Not((bool?)(am_ is null));
                bool? ao_ = context.Operators.And(ak_, an_);

                return ao_;
            };
            IEnumerable<Observation> j_ = context.Operators.Where<Observation>(h_, i_);
            object k_(Observation @this)
            {
                Instant ap_ = @this?.IssuedElement;
                DateTimeOffset? aq_ = ap_?.Value;
                CqlDateTime ar_ = context.Operators.Convert<CqlDateTime>(aq_);
                CqlDateTime as_ = QICoreCommon_2_1_000.Instance.earliest(context, ar_ as object);

                return as_;
            };
            IEnumerable<Observation> l_ = context.Operators.SortBy<Observation>(j_, k_, System.ComponentModel.ListSortDirection.Ascending);
            Observation m_ = context.Operators.First<Observation>(l_);
            DataType n_ = m_?.Value;
            object o_ = FHIRHelpers_4_4_000.Instance.ToValue(context, n_);
            IEnumerable<Observation> q_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, g_, default, "http://hl7.org/fhir/us/core/StructureDefinition/us-core-observation-lab"));
            bool? r_(Observation WhiteBloodCellLab)
            {
                DataType at_ = WhiteBloodCellLab?.Effective;
                object au_ = FHIRHelpers_4_4_000.Instance.ToValue(context, at_);
                CqlDateTime av_ = QICoreCommon_2_1_000.Instance.earliest(context, au_);
                CqlInterval<CqlDateTime> aw_ = CQMCommon_2_2_000.Instance.hospitalizationWithObservationAndOutpatientSurgeryService(context, EncounterInpatient);
                bool? ax_ = context.Operators.In<CqlDateTime>(av_, aw_, default);
                Code<ObservationStatus> ay_ = WhiteBloodCellLab?.StatusElement;
                ObservationStatus? az_ = ay_?.Value;
                string ba_ = context.Operators.Convert<string>(az_);
                string[] bb_ = [
                    "final",
                    "amended",
                    "corrected",
                ];
                bool? bc_ = context.Operators.In<string>(ba_, (IEnumerable<string>)bb_);
                bool? bd_ = context.Operators.And(ax_, bc_);
                DataType be_ = WhiteBloodCellLab?.Value;
                object bf_ = FHIRHelpers_4_4_000.Instance.ToValue(context, be_);
                bool? bg_ = context.Operators.Not((bool?)(bf_ is null));
                bool? bh_ = context.Operators.And(bd_, bg_);

                return bh_;
            };
            IEnumerable<Observation> s_ = context.Operators.Where<Observation>(q_, r_);
            object t_(Observation @this)
            {
                Instant bi_ = @this?.IssuedElement;
                DateTimeOffset? bj_ = bi_?.Value;
                CqlDateTime bk_ = context.Operators.Convert<CqlDateTime>(bj_);
                CqlDateTime bl_ = QICoreCommon_2_1_000.Instance.earliest(context, bk_ as object);

                return bl_;
            };
            IEnumerable<Observation> u_ = context.Operators.SortBy<Observation>(s_, t_, System.ComponentModel.ListSortDirection.Ascending);
            Observation v_ = context.Operators.First<Observation>(u_);
            Instant w_ = v_?.IssuedElement;
            DateTimeOffset? x_ = w_?.Value;
            CqlDateTime y_ = context.Operators.Convert<CqlDateTime>(x_);
            (CqlTupleMetadata, string EncounterId, CqlQuantity FirstResult, CqlDateTime Timing)? z_ = (CqlTupleMetadata_HDVhZFAYAdGHPZJWcDFSNFGPd, f_, o_ as CqlQuantity, y_);

            return z_;
        };
        IEnumerable<(CqlTupleMetadata, string EncounterId, CqlQuantity FirstResult, CqlDateTime Timing)?> c_ = context.Operators.Select<Encounter, (CqlTupleMetadata, string EncounterId, CqlQuantity FirstResult, CqlDateTime Timing)?>(a_, b_);
        IEnumerable<(CqlTupleMetadata, string EncounterId, CqlQuantity FirstResult, CqlDateTime Timing)?> d_ = context.Operators.Distinct<(CqlTupleMetadata, string EncounterId, CqlQuantity FirstResult, CqlDateTime Timing)?>(c_);

        return d_;
    }


    [CqlExpressionDefinition("Encounter with First Weight Recorded")]
    public IEnumerable<(CqlTupleMetadata, string EncounterId, CqlQuantity FirstResult, CqlDateTime Timing)?> Encounter_with_First_Weight_Recorded(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Inpatient_Encounters(context);
        (CqlTupleMetadata, string EncounterId, CqlQuantity FirstResult, CqlDateTime Timing)? b_(Encounter EncounterInpatient)
        {
            Id e_ = EncounterInpatient?.IdElement;
            string f_ = e_?.Value;
            IEnumerable<Observation> g_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/StructureDefinition/bodyweight"));
            bool? h_(Observation WeightExam)
            {
                DataType y_ = WeightExam?.Effective;
                object z_ = FHIRHelpers_4_4_000.Instance.ToValue(context, y_);
                CqlDateTime aa_ = QICoreCommon_2_1_000.Instance.earliest(context, z_);
                CqlInterval<CqlDateTime> ab_ = CQMCommon_2_2_000.Instance.hospitalizationWithObservationAndOutpatientSurgeryService(context, EncounterInpatient);
                bool? ac_ = context.Operators.In<CqlDateTime>(aa_, ab_, default);
                Code<ObservationStatus> ad_ = WeightExam?.StatusElement;
                ObservationStatus? ae_ = ad_?.Value;
                string af_ = context.Operators.Convert<string>(ae_);
                string[] ag_ = [
                    "final",
                    "amended",
                    "corrected",
                ];
                bool? ah_ = context.Operators.In<string>(af_, (IEnumerable<string>)ag_);
                bool? ai_ = context.Operators.And(ac_, ah_);
                DataType aj_ = WeightExam?.Value;
                CqlQuantity ak_ = FHIRHelpers_4_4_000.Instance.ToQuantity(context, aj_ as Quantity);
                bool? al_ = context.Operators.Not((bool?)(ak_ is null));
                bool? am_ = context.Operators.And(ai_, al_);

                return am_;
            };
            IEnumerable<Observation> i_ = context.Operators.Where<Observation>(g_, h_);
            object j_(Observation @this)
            {
                DataType an_ = @this?.Effective;
                object ao_ = FHIRHelpers_4_4_000.Instance.ToValue(context, an_);
                CqlDateTime ap_ = QICoreCommon_2_1_000.Instance.earliest(context, ao_);

                return ap_;
            };
            IEnumerable<Observation> k_ = context.Operators.SortBy<Observation>(i_, j_, System.ComponentModel.ListSortDirection.Ascending);
            Observation l_ = context.Operators.First<Observation>(k_);
            DataType m_ = l_?.Value;
            CqlQuantity n_ = FHIRHelpers_4_4_000.Instance.ToQuantity(context, m_ as Quantity);
            bool? p_(Observation WeightExam)
            {
                DataType aq_ = WeightExam?.Effective;
                object ar_ = FHIRHelpers_4_4_000.Instance.ToValue(context, aq_);
                CqlDateTime as_ = QICoreCommon_2_1_000.Instance.earliest(context, ar_);
                CqlInterval<CqlDateTime> at_ = CQMCommon_2_2_000.Instance.hospitalizationWithObservationAndOutpatientSurgeryService(context, EncounterInpatient);
                bool? au_ = context.Operators.In<CqlDateTime>(as_, at_, default);
                Code<ObservationStatus> av_ = WeightExam?.StatusElement;
                ObservationStatus? aw_ = av_?.Value;
                string ax_ = context.Operators.Convert<string>(aw_);
                string[] ay_ = [
                    "final",
                    "amended",
                    "corrected",
                ];
                bool? az_ = context.Operators.In<string>(ax_, (IEnumerable<string>)ay_);
                bool? ba_ = context.Operators.And(au_, az_);
                DataType bb_ = WeightExam?.Value;
                CqlQuantity bc_ = FHIRHelpers_4_4_000.Instance.ToQuantity(context, bb_ as Quantity);
                bool? bd_ = context.Operators.Not((bool?)(bc_ is null));
                bool? be_ = context.Operators.And(ba_, bd_);

                return be_;
            };
            IEnumerable<Observation> q_ = context.Operators.Where<Observation>(g_, p_);
            object r_(Observation @this)
            {
                DataType bf_ = @this?.Effective;
                object bg_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bf_);
                CqlDateTime bh_ = QICoreCommon_2_1_000.Instance.earliest(context, bg_);

                return bh_;
            };
            IEnumerable<Observation> s_ = context.Operators.SortBy<Observation>(q_, r_, System.ComponentModel.ListSortDirection.Ascending);
            Observation t_ = context.Operators.First<Observation>(s_);
            DataType u_ = t_?.Effective;
            object v_ = FHIRHelpers_4_4_000.Instance.ToValue(context, u_);
            CqlDateTime w_ = QICoreCommon_2_1_000.Instance.earliest(context, v_);
            (CqlTupleMetadata, string EncounterId, CqlQuantity FirstResult, CqlDateTime Timing)? x_ = (CqlTupleMetadata_HDVhZFAYAdGHPZJWcDFSNFGPd, f_, n_ as CqlQuantity, w_);

            return x_;
        };
        IEnumerable<(CqlTupleMetadata, string EncounterId, CqlQuantity FirstResult, CqlDateTime Timing)?> c_ = context.Operators.Select<Encounter, (CqlTupleMetadata, string EncounterId, CqlQuantity FirstResult, CqlDateTime Timing)?>(a_, b_);
        IEnumerable<(CqlTupleMetadata, string EncounterId, CqlQuantity FirstResult, CqlDateTime Timing)?> d_ = context.Operators.Distinct<(CqlTupleMetadata, string EncounterId, CqlQuantity FirstResult, CqlDateTime Timing)?>(c_);

        return d_;
    }


    [CqlExpressionDefinition("SDE Ethnicity")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Ethnicity(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? a_ = SupplementalDataElements_3_5_000.Instance.SDE_Ethnicity(context);

        return a_;
    }


    [CqlExpressionDefinition("SDE Payer")]
    public IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> SDE_Payer(CqlContext context)
    {
        IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> a_ = SupplementalDataElements_3_5_000.Instance.SDE_Payer(context);

        return a_;
    }


    [CqlExpressionDefinition("SDE Race")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Race(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? a_ = SupplementalDataElements_3_5_000.Instance.SDE_Race(context);

        return a_;
    }


    [CqlExpressionDefinition("SDE Sex")]
    public CqlCode SDE_Sex(CqlContext context)
    {
        CqlCode a_ = SupplementalDataElements_3_5_000.Instance.SDE_Sex(context);

        return a_;
    }


    #endregion Functions and Expressions

    #region CqlTupleMetadata Properties

    private static CqlTupleMetadata CqlTupleMetadata_CYbMQaXdPgTVSLXJSHHNTbhVM = new(
      [typeof(string), typeof(CqlQuantity), typeof(CqlDateTime)],
      ["EncounterId", "FirstRespRateResult", "Timing"]);

    private static CqlTupleMetadata CqlTupleMetadata_DhbJAfCiKIAGYKTjJXYGSKECQ = new(
      [typeof(string), typeof(CqlQuantity), typeof(CqlDateTime)],
      ["EncounterId", "FirstHeartRateResult", "Timing"]);

    private static CqlTupleMetadata CqlTupleMetadata_FdREYEdHOZIcMCNYCRFJYJReA = new(
      [typeof(string), typeof(CqlQuantity), typeof(CqlDateTime)],
      ["EncounterId", "FirstOxygenSatResult", "Timing"]);

    private static CqlTupleMetadata CqlTupleMetadata_GIbILVAdXLLNYBgcQIEiUiKaK = new(
      [typeof(string), typeof(CqlQuantity), typeof(CqlDateTime)],
      ["EncounterId", "FirstTemperatureResult", "Timing"]);

    private static CqlTupleMetadata CqlTupleMetadata_HDVhZFAYAdGHPZJWcDFSNFGPd = new(
      [typeof(string), typeof(CqlQuantity), typeof(CqlDateTime)],
      ["EncounterId", "FirstResult", "Timing"]);

    #endregion CqlTupleMetadata Properties

}

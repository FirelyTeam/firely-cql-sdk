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
[CqlLibrary("CMSFHIR844HybridHospitalWideMortality", "0.5.001")]
public partial class CMSFHIR844HybridHospitalWideMortality_0_5_001 : ILibrary, ISingleton<CMSFHIR844HybridHospitalWideMortality_0_5_001>
{
    private CMSFHIR844HybridHospitalWideMortality_0_5_001() {}

    public static CMSFHIR844HybridHospitalWideMortality_0_5_001 Instance { get; } = new();

    #region ILibrary Implementation

    public string Name => "CMSFHIR844HybridHospitalWideMortality";
    public string Version => "0.5.001";
    public ILibrary[] Dependencies => [CQMCommon_4_1_000.Instance, FHIRHelpers_4_4_000.Instance, QICoreCommon_4_0_000.Instance, SupplementalDataElements_5_1_000.Instance];

    #endregion ILibrary Implementation

    #region ValueSets

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

    #region Codes

    [CqlCodeDefinition("Systolic blood pressure", codeId: "8480-6", codeSystem: "http://loinc.org")]
    public CqlCode Systolic_blood_pressure(CqlContext _) => _Systolic_blood_pressure;
    private static readonly CqlCode _Systolic_blood_pressure = new CqlCode("8480-6", "http://loinc.org");

    #endregion Codes

    #region CodeSystems

    [CqlCodeSystemDefinition("LOINC", codeSystemId: "http://loinc.org", codeSystemVersion: null)]
    public CqlCodeSystem LOINC(CqlContext _) => _LOINC;
    private static readonly CqlCodeSystem _LOINC =
      new CqlCodeSystem("http://loinc.org", null, [
          _Systolic_blood_pressure]);

    #endregion CodeSystems

    #region Parameters

    [CqlParameterDefinition("Measurement Period")]
    public CqlInterval<CqlDateTime> Measurement_Period(CqlContext context)
    {
        object a_ = context.ResolveParameter("CMSFHIR844HybridHospitalWideMortality-0.5.001", "Measurement Period", null);

        return (CqlInterval<CqlDateTime>)a_;
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
        IEnumerable<Encounter> c_(Encounter EncounterInpatient)
        {
            CqlValueSet e_ = this.Medicare_FFS_payer(context);
            IEnumerable<Coverage> f_ = context.Operators.Retrieve<Coverage>(new RetrieveParameters(default, e_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-coverage"));
            CqlValueSet g_ = this.Medicare_Advantage_payer(context);
            IEnumerable<Coverage> h_ = context.Operators.Retrieve<Coverage>(new RetrieveParameters(default, g_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-coverage"));
            IEnumerable<Coverage> i_ = context.Operators.Union<Coverage>(f_, h_);
            bool? j_(Coverage MedicarePayer)
            {
                CqlInterval<CqlDateTime> n_ = CQMCommon_4_1_000.Instance.hospitalizationWithObservationAndOutpatientSurgeryService(context, EncounterInpatient);
                int? o_ = CQMCommon_4_1_000.Instance.lengthInDays(context, n_);
                bool? p_ = context.Operators.Less(o_, 365);
                Code<Encounter.EncounterStatus> q_ = EncounterInpatient?.StatusElement;
                Encounter.EncounterStatus? r_ = q_?.Value;
                Code<Encounter.EncounterStatus> s_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(r_);
                bool? t_ = context.Operators.Equal(s_, "finished");
                bool? u_ = context.Operators.And(p_, t_);
                Patient v_ = this.Patient(context);
                Date w_ = v_?.BirthDateElement;
                string x_ = w_?.Value;
                CqlDate y_ = context.Operators.ConvertStringToDate(x_);
                Period z_ = EncounterInpatient?.Period;
                CqlInterval<CqlDateTime> aa_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, z_);
                CqlDateTime ab_ = context.Operators.Start(aa_);
                CqlDate ac_ = context.Operators.DateFrom(ab_);
                int? ad_ = context.Operators.CalculateAgeAt(y_, ac_, "year");
                CqlInterval<int?> ae_ = context.Operators.Interval(65, 94, true, true);
                bool? af_ = context.Operators.In<int?>(ad_, ae_, default);
                bool? ag_ = context.Operators.And(u_, af_);
                CqlInterval<CqlDateTime> ai_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, z_);
                CqlDateTime aj_ = context.Operators.End(ai_);
                CqlInterval<CqlDateTime> ak_ = this.Measurement_Period(context);
                bool? al_ = context.Operators.In<CqlDateTime>(aj_, ak_, "day");
                bool? am_ = context.Operators.And(ag_, al_);

                return am_;
            };
            IEnumerable<Coverage> k_ = context.Operators.Where<Coverage>(i_, j_);
            Encounter l_(Coverage MedicarePayer) =>
                EncounterInpatient;
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


    [CqlExpressionDefinition("SDE Encounter With First Body Temperature")]
    public IEnumerable<(CqlTupleMetadata, string EncounterId, CqlQuantity FirstTemperatureResult, CqlDateTime Timing)?> SDE_Encounter_With_First_Body_Temperature(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Inpatient_Encounters(context);
        (CqlTupleMetadata, string EncounterId, CqlQuantity FirstTemperatureResult, CqlDateTime Timing)? b_(Encounter EncounterInpatient)
        {
            Id e_ = EncounterInpatient?.IdElement;
            string f_ = e_?.Value;
            IEnumerable<Observation> g_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/core/StructureDefinition/us-core-body-temperature"));
            bool? h_(Observation Temperature)
            {
                DataType y_ = Temperature?.Effective;
                object z_ = FHIRHelpers_4_4_000.Instance.ToValue(context, y_);
                CqlDateTime aa_ = QICoreCommon_4_0_000.Instance.earliest(context, z_);
                CqlInterval<CqlDateTime> ab_ = CQMCommon_4_1_000.Instance.hospitalizationWithObservationAndOutpatientSurgeryService(context, EncounterInpatient);
                bool? ac_ = context.Operators.In<CqlDateTime>(aa_, ab_, default);
                Code<ObservationStatus> ad_ = Temperature?.StatusElement;
                ObservationStatus? ae_ = ad_?.Value;
                string af_ = context.Operators.Convert<string>(ae_);
                string[] ag_ = [
                    "final",
                    "amended",
                    "corrected",
                ];
                bool? ah_ = context.Operators.In<string>(af_, (IEnumerable<string>)ag_);
                bool? ai_ = context.Operators.And(ac_, ah_);
                DataType aj_ = Temperature?.Value;
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
                CqlDateTime ap_ = QICoreCommon_4_0_000.Instance.earliest(context, ao_);

                return ap_;
            };
            IEnumerable<Observation> k_ = context.Operators.SortBy<Observation>(i_, j_, System.ComponentModel.ListSortDirection.Ascending);
            Observation l_ = context.Operators.First<Observation>(k_);
            DataType m_ = l_?.Value;
            CqlQuantity n_ = FHIRHelpers_4_4_000.Instance.ToQuantity(context, m_ as Quantity);
            bool? p_(Observation Temperature)
            {
                DataType aq_ = Temperature?.Effective;
                object ar_ = FHIRHelpers_4_4_000.Instance.ToValue(context, aq_);
                CqlDateTime as_ = QICoreCommon_4_0_000.Instance.earliest(context, ar_);
                CqlInterval<CqlDateTime> at_ = CQMCommon_4_1_000.Instance.hospitalizationWithObservationAndOutpatientSurgeryService(context, EncounterInpatient);
                bool? au_ = context.Operators.In<CqlDateTime>(as_, at_, default);
                Code<ObservationStatus> av_ = Temperature?.StatusElement;
                ObservationStatus? aw_ = av_?.Value;
                string ax_ = context.Operators.Convert<string>(aw_);
                string[] ay_ = [
                    "final",
                    "amended",
                    "corrected",
                ];
                bool? az_ = context.Operators.In<string>(ax_, (IEnumerable<string>)ay_);
                bool? ba_ = context.Operators.And(au_, az_);
                DataType bb_ = Temperature?.Value;
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
                CqlDateTime bh_ = QICoreCommon_4_0_000.Instance.earliest(context, bg_);

                return bh_;
            };
            IEnumerable<Observation> s_ = context.Operators.SortBy<Observation>(q_, r_, System.ComponentModel.ListSortDirection.Ascending);
            Observation t_ = context.Operators.First<Observation>(s_);
            DataType u_ = t_?.Effective;
            object v_ = FHIRHelpers_4_4_000.Instance.ToValue(context, u_);
            CqlDateTime w_ = QICoreCommon_4_0_000.Instance.earliest(context, v_);
            (CqlTupleMetadata, string EncounterId, CqlQuantity FirstTemperatureResult, CqlDateTime Timing)? x_ = (CqlTupleMetadata_GIbILVAdXLLNYBgcQIEiUiKaK, f_, n_ as CqlQuantity, w_);

            return x_;
        };
        IEnumerable<(CqlTupleMetadata, string EncounterId, CqlQuantity FirstTemperatureResult, CqlDateTime Timing)?> c_ = context.Operators.Select<Encounter, (CqlTupleMetadata, string EncounterId, CqlQuantity FirstTemperatureResult, CqlDateTime Timing)?>(a_, b_);
        IEnumerable<(CqlTupleMetadata, string EncounterId, CqlQuantity FirstTemperatureResult, CqlDateTime Timing)?> d_ = context.Operators.Distinct<(CqlTupleMetadata, string EncounterId, CqlQuantity FirstTemperatureResult, CqlDateTime Timing)?>(c_);

        return d_;
    }


    [CqlExpressionDefinition("SDE Encounter With First Heart Rate")]
    public IEnumerable<(CqlTupleMetadata, string EncounterId, CqlQuantity FirstHeartRateResult, CqlDateTime Timing)?> SDE_Encounter_With_First_Heart_Rate(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Inpatient_Encounters(context);
        (CqlTupleMetadata, string EncounterId, CqlQuantity FirstHeartRateResult, CqlDateTime Timing)? b_(Encounter EncounterInpatient)
        {
            Id e_ = EncounterInpatient?.IdElement;
            string f_ = e_?.Value;
            IEnumerable<Observation> g_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/core/StructureDefinition/us-core-heart-rate"));
            bool? h_(Observation HeartRate)
            {
                DataType y_ = HeartRate?.Effective;
                object z_ = FHIRHelpers_4_4_000.Instance.ToValue(context, y_);
                CqlDateTime aa_ = QICoreCommon_4_0_000.Instance.earliest(context, z_);
                CqlInterval<CqlDateTime> ab_ = CQMCommon_4_1_000.Instance.hospitalizationWithObservationAndOutpatientSurgeryService(context, EncounterInpatient);
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
                CqlDateTime ap_ = QICoreCommon_4_0_000.Instance.earliest(context, ao_);

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
                CqlDateTime as_ = QICoreCommon_4_0_000.Instance.earliest(context, ar_);
                CqlInterval<CqlDateTime> at_ = CQMCommon_4_1_000.Instance.hospitalizationWithObservationAndOutpatientSurgeryService(context, EncounterInpatient);
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
                CqlDateTime bh_ = QICoreCommon_4_0_000.Instance.earliest(context, bg_);

                return bh_;
            };
            IEnumerable<Observation> s_ = context.Operators.SortBy<Observation>(q_, r_, System.ComponentModel.ListSortDirection.Ascending);
            Observation t_ = context.Operators.First<Observation>(s_);
            DataType u_ = t_?.Effective;
            object v_ = FHIRHelpers_4_4_000.Instance.ToValue(context, u_);
            CqlDateTime w_ = QICoreCommon_4_0_000.Instance.earliest(context, v_);
            (CqlTupleMetadata, string EncounterId, CqlQuantity FirstHeartRateResult, CqlDateTime Timing)? x_ = (CqlTupleMetadata_DhbJAfCiKIAGYKTjJXYGSKECQ, f_, n_ as CqlQuantity, w_);

            return x_;
        };
        IEnumerable<(CqlTupleMetadata, string EncounterId, CqlQuantity FirstHeartRateResult, CqlDateTime Timing)?> c_ = context.Operators.Select<Encounter, (CqlTupleMetadata, string EncounterId, CqlQuantity FirstHeartRateResult, CqlDateTime Timing)?>(a_, b_);
        IEnumerable<(CqlTupleMetadata, string EncounterId, CqlQuantity FirstHeartRateResult, CqlDateTime Timing)?> d_ = context.Operators.Distinct<(CqlTupleMetadata, string EncounterId, CqlQuantity FirstHeartRateResult, CqlDateTime Timing)?>(c_);

        return d_;
    }


    [CqlExpressionDefinition("SDE Encounter With First Oxygen Saturation")]
    public IEnumerable<(CqlTupleMetadata, string EncounterId, CqlQuantity FirstOxygenSatResult, CqlDateTime Timing)?> SDE_Encounter_With_First_Oxygen_Saturation(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Inpatient_Encounters(context);
        (CqlTupleMetadata, string EncounterId, CqlQuantity FirstOxygenSatResult, CqlDateTime Timing)? b_(Encounter EncounterInpatient)
        {
            Id e_ = EncounterInpatient?.IdElement;
            string f_ = e_?.Value;
            CqlValueSet g_ = this.Oxygen_Saturation_by_Pulse_Oximetry(context);
            IEnumerable<Observation> h_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, g_, default, "http://hl7.org/fhir/us/core/StructureDefinition/us-core-pulse-oximetry"));
            bool? i_(Observation O2Saturation)
            {
                DataType aa_ = O2Saturation?.Effective;
                object ab_ = FHIRHelpers_4_4_000.Instance.ToValue(context, aa_);
                CqlDateTime ac_ = QICoreCommon_4_0_000.Instance.earliest(context, ab_);
                CqlInterval<CqlDateTime> ad_ = CQMCommon_4_1_000.Instance.hospitalizationWithObservationAndOutpatientSurgeryService(context, EncounterInpatient);
                bool? ae_ = context.Operators.In<CqlDateTime>(ac_, ad_, default);
                Code<ObservationStatus> af_ = O2Saturation?.StatusElement;
                ObservationStatus? ag_ = af_?.Value;
                string ah_ = context.Operators.Convert<string>(ag_);
                string[] ai_ = [
                    "final",
                    "amended",
                    "corrected",
                ];
                bool? aj_ = context.Operators.In<string>(ah_, (IEnumerable<string>)ai_);
                bool? ak_ = context.Operators.And(ae_, aj_);
                DataType al_ = O2Saturation?.Value;
                CqlQuantity am_ = FHIRHelpers_4_4_000.Instance.ToQuantity(context, al_ as Quantity);
                bool? an_ = context.Operators.Not((bool?)(am_ is null));
                bool? ao_ = context.Operators.And(ak_, an_);

                return ao_;
            };
            IEnumerable<Observation> j_ = context.Operators.Where<Observation>(h_, i_);
            object k_(Observation @this)
            {
                DataType ap_ = @this?.Effective;
                object aq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ap_);
                CqlDateTime ar_ = QICoreCommon_4_0_000.Instance.earliest(context, aq_);

                return ar_;
            };
            IEnumerable<Observation> l_ = context.Operators.SortBy<Observation>(j_, k_, System.ComponentModel.ListSortDirection.Ascending);
            Observation m_ = context.Operators.First<Observation>(l_);
            DataType n_ = m_?.Value;
            CqlQuantity o_ = FHIRHelpers_4_4_000.Instance.ToQuantity(context, n_ as Quantity);
            IEnumerable<Observation> q_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, g_, default, "http://hl7.org/fhir/us/core/StructureDefinition/us-core-pulse-oximetry"));
            bool? r_(Observation O2Saturation)
            {
                DataType as_ = O2Saturation?.Effective;
                object at_ = FHIRHelpers_4_4_000.Instance.ToValue(context, as_);
                CqlDateTime au_ = QICoreCommon_4_0_000.Instance.earliest(context, at_);
                CqlInterval<CqlDateTime> av_ = CQMCommon_4_1_000.Instance.hospitalizationWithObservationAndOutpatientSurgeryService(context, EncounterInpatient);
                bool? aw_ = context.Operators.In<CqlDateTime>(au_, av_, default);
                Code<ObservationStatus> ax_ = O2Saturation?.StatusElement;
                ObservationStatus? ay_ = ax_?.Value;
                string az_ = context.Operators.Convert<string>(ay_);
                string[] ba_ = [
                    "final",
                    "amended",
                    "corrected",
                ];
                bool? bb_ = context.Operators.In<string>(az_, (IEnumerable<string>)ba_);
                bool? bc_ = context.Operators.And(aw_, bb_);
                DataType bd_ = O2Saturation?.Value;
                CqlQuantity be_ = FHIRHelpers_4_4_000.Instance.ToQuantity(context, bd_ as Quantity);
                bool? bf_ = context.Operators.Not((bool?)(be_ is null));
                bool? bg_ = context.Operators.And(bc_, bf_);

                return bg_;
            };
            IEnumerable<Observation> s_ = context.Operators.Where<Observation>(q_, r_);
            object t_(Observation @this)
            {
                DataType bh_ = @this?.Effective;
                object bi_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bh_);
                CqlDateTime bj_ = QICoreCommon_4_0_000.Instance.earliest(context, bi_);

                return bj_;
            };
            IEnumerable<Observation> u_ = context.Operators.SortBy<Observation>(s_, t_, System.ComponentModel.ListSortDirection.Ascending);
            Observation v_ = context.Operators.First<Observation>(u_);
            DataType w_ = v_?.Effective;
            object x_ = FHIRHelpers_4_4_000.Instance.ToValue(context, w_);
            CqlDateTime y_ = QICoreCommon_4_0_000.Instance.earliest(context, x_);
            (CqlTupleMetadata, string EncounterId, CqlQuantity FirstOxygenSatResult, CqlDateTime Timing)? z_ = (CqlTupleMetadata_FdREYEdHOZIcMCNYCRFJYJReA, f_, o_ as CqlQuantity, y_);

            return z_;
        };
        IEnumerable<(CqlTupleMetadata, string EncounterId, CqlQuantity FirstOxygenSatResult, CqlDateTime Timing)?> c_ = context.Operators.Select<Encounter, (CqlTupleMetadata, string EncounterId, CqlQuantity FirstOxygenSatResult, CqlDateTime Timing)?>(a_, b_);
        IEnumerable<(CqlTupleMetadata, string EncounterId, CqlQuantity FirstOxygenSatResult, CqlDateTime Timing)?> d_ = context.Operators.Distinct<(CqlTupleMetadata, string EncounterId, CqlQuantity FirstOxygenSatResult, CqlDateTime Timing)?>(c_);

        return d_;
    }


    [CqlExpressionDefinition("SDE Encounter With First Systolic Blood Pressure")]
    public IEnumerable<(CqlTupleMetadata, string EncounterId, IEnumerable<CqlQuantity> FirstSBPResult, CqlDateTime Timing)?> SDE_Encounter_With_First_Systolic_Blood_Pressure(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Inpatient_Encounters(context);
        (CqlTupleMetadata, string EncounterId, IEnumerable<CqlQuantity> FirstSBPResult, CqlDateTime Timing)? b_(Encounter EncounterInpatient)
        {
            Id e_ = EncounterInpatient?.IdElement;
            string f_ = e_?.Value;
            IEnumerable<Observation> g_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/core/StructureDefinition/us-core-blood-pressure"));
            bool? h_(Observation BP)
            {
                DataType ac_ = BP?.Effective;
                object ad_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ac_);
                CqlDateTime ae_ = QICoreCommon_4_0_000.Instance.earliest(context, ad_);
                CqlInterval<CqlDateTime> af_ = CQMCommon_4_1_000.Instance.hospitalizationWithObservationAndOutpatientSurgeryService(context, EncounterInpatient);
                bool? ag_ = context.Operators.In<CqlDateTime>(ae_, af_, default);
                Code<ObservationStatus> ah_ = BP?.StatusElement;
                ObservationStatus? ai_ = ah_?.Value;
                string aj_ = context.Operators.Convert<string>(ai_);
                string[] ak_ = [
                    "final",
                    "amended",
                    "corrected",
                ];
                bool? al_ = context.Operators.In<string>(aj_, (IEnumerable<string>)ak_);
                bool? am_ = context.Operators.And(ag_, al_);
                List<Observation.ComponentComponent> an_ = BP?.Component;
                bool? ao_(Observation.ComponentComponent @this)
                {
                    DataType au_ = @this?.Value;
                    object av_ = FHIRHelpers_4_4_000.Instance.ToValue(context, au_);
                    bool? aw_ = context.Operators.Not((bool?)(av_ is null));

                    return aw_;
                };
                IEnumerable<Observation.ComponentComponent> ap_ = context.Operators.Where<Observation.ComponentComponent>((IEnumerable<Observation.ComponentComponent>)an_, ao_);
                object aq_(Observation.ComponentComponent @this)
                {
                    DataType ax_ = @this?.Value;
                    object ay_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ax_);

                    return ay_;
                };
                IEnumerable<object> ar_ = context.Operators.Select<Observation.ComponentComponent, object>(ap_, aq_);
                bool? as_ = context.Operators.Not((bool?)(ar_ is null));
                bool? at_ = context.Operators.And(am_, as_);

                return at_;
            };
            IEnumerable<Observation> i_ = context.Operators.Where<Observation>(g_, h_);
            object j_(Observation @this)
            {
                DataType az_ = @this?.Effective;
                object ba_ = FHIRHelpers_4_4_000.Instance.ToValue(context, az_);
                CqlDateTime bb_ = QICoreCommon_4_0_000.Instance.earliest(context, ba_);

                return bb_;
            };
            IEnumerable<Observation> k_ = context.Operators.SortBy<Observation>(i_, j_, System.ComponentModel.ListSortDirection.Ascending);
            Observation l_ = context.Operators.First<Observation>(k_);
            List<Observation.ComponentComponent> m_ = l_?.Component;
            bool? n_(Observation.ComponentComponent C)
            {
                CodeableConcept bc_ = C?.Code;
                CqlConcept bd_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, bc_);
                CqlCode be_ = this.Systolic_blood_pressure(context);
                CqlConcept bf_ = context.Operators.ConvertCodeToConcept(be_);
                bool? bg_ = context.Operators.Equivalent(bd_, bf_);

                return bg_;
            };
            IEnumerable<Observation.ComponentComponent> o_ = context.Operators.Where<Observation.ComponentComponent>((IEnumerable<Observation.ComponentComponent>)m_, n_);
            CqlQuantity p_(Observation.ComponentComponent C)
            {
                DataType bh_ = C?.Value;
                object bi_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bh_);

                return bi_ as CqlQuantity;
            };
            IEnumerable<CqlQuantity> q_ = context.Operators.Select<Observation.ComponentComponent, CqlQuantity>(o_, p_);
            IEnumerable<CqlQuantity> r_ = context.Operators.Distinct<CqlQuantity>(q_);
            bool? t_(Observation BP)
            {
                DataType bj_ = BP?.Effective;
                object bk_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bj_);
                CqlDateTime bl_ = QICoreCommon_4_0_000.Instance.earliest(context, bk_);
                CqlInterval<CqlDateTime> bm_ = CQMCommon_4_1_000.Instance.hospitalizationWithObservationAndOutpatientSurgeryService(context, EncounterInpatient);
                bool? bn_ = context.Operators.In<CqlDateTime>(bl_, bm_, default);
                Code<ObservationStatus> bo_ = BP?.StatusElement;
                ObservationStatus? bp_ = bo_?.Value;
                string bq_ = context.Operators.Convert<string>(bp_);
                string[] br_ = [
                    "final",
                    "amended",
                    "corrected",
                ];
                bool? bs_ = context.Operators.In<string>(bq_, (IEnumerable<string>)br_);
                bool? bt_ = context.Operators.And(bn_, bs_);
                List<Observation.ComponentComponent> bu_ = BP?.Component;
                bool? bv_(Observation.ComponentComponent @this)
                {
                    DataType cb_ = @this?.Value;
                    object cc_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cb_);
                    bool? cd_ = context.Operators.Not((bool?)(cc_ is null));

                    return cd_;
                };
                IEnumerable<Observation.ComponentComponent> bw_ = context.Operators.Where<Observation.ComponentComponent>((IEnumerable<Observation.ComponentComponent>)bu_, bv_);
                object bx_(Observation.ComponentComponent @this)
                {
                    DataType ce_ = @this?.Value;
                    object cf_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ce_);

                    return cf_;
                };
                IEnumerable<object> by_ = context.Operators.Select<Observation.ComponentComponent, object>(bw_, bx_);
                bool? bz_ = context.Operators.Not((bool?)(by_ is null));
                bool? ca_ = context.Operators.And(bt_, bz_);

                return ca_;
            };
            IEnumerable<Observation> u_ = context.Operators.Where<Observation>(g_, t_);
            object v_(Observation @this)
            {
                DataType cg_ = @this?.Effective;
                object ch_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cg_);
                CqlDateTime ci_ = QICoreCommon_4_0_000.Instance.earliest(context, ch_);

                return ci_;
            };
            IEnumerable<Observation> w_ = context.Operators.SortBy<Observation>(u_, v_, System.ComponentModel.ListSortDirection.Ascending);
            Observation x_ = context.Operators.First<Observation>(w_);
            DataType y_ = x_?.Effective;
            object z_ = FHIRHelpers_4_4_000.Instance.ToValue(context, y_);
            CqlDateTime aa_ = QICoreCommon_4_0_000.Instance.earliest(context, z_);
            (CqlTupleMetadata, string EncounterId, IEnumerable<CqlQuantity> FirstSBPResult, CqlDateTime Timing)? ab_ = (CqlTupleMetadata_FjSKXeIESORPNbRGajibMfUaK, f_, r_, aa_);

            return ab_;
        };
        IEnumerable<(CqlTupleMetadata, string EncounterId, IEnumerable<CqlQuantity> FirstSBPResult, CqlDateTime Timing)?> c_ = context.Operators.Select<Encounter, (CqlTupleMetadata, string EncounterId, IEnumerable<CqlQuantity> FirstSBPResult, CqlDateTime Timing)?>(a_, b_);
        IEnumerable<(CqlTupleMetadata, string EncounterId, IEnumerable<CqlQuantity> FirstSBPResult, CqlDateTime Timing)?> d_ = context.Operators.Distinct<(CqlTupleMetadata, string EncounterId, IEnumerable<CqlQuantity> FirstSBPResult, CqlDateTime Timing)?>(c_);

        return d_;
    }


    [CqlExpressionDefinition("SDE Encounter With First Bicarbonate Lab Test")]
    public IEnumerable<(CqlTupleMetadata, string EncounterId, CqlQuantity FirstBicarbonateResult, CqlDateTime Timing)?> SDE_Encounter_With_First_Bicarbonate_Lab_Test(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Inpatient_Encounters(context);
        (CqlTupleMetadata, string EncounterId, CqlQuantity FirstBicarbonateResult, CqlDateTime Timing)? b_(Encounter EncounterInpatient)
        {
            Id e_ = EncounterInpatient?.IdElement;
            string f_ = e_?.Value;
            CqlValueSet g_ = this.Bicarbonate_lab_test(context);
            IEnumerable<Observation> h_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, g_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation-lab"));
            bool? i_(Observation BicarbonateLab)
            {
                object aa_()
                {
                    bool ao_()
                    {
                        DataType ar_ = BicarbonateLab?.Effective;
                        object as_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ar_);
                        bool at_ = as_ is CqlDateTime;

                        return at_;
                    };
                    bool ap_()
                    {
                        DataType au_ = BicarbonateLab?.Effective;
                        object av_ = FHIRHelpers_4_4_000.Instance.ToValue(context, au_);
                        bool aw_ = av_ is CqlInterval<CqlDateTime>;

                        return aw_;
                    };
                    bool aq_()
                    {
                        DataType ax_ = BicarbonateLab?.Effective;
                        object ay_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ax_);
                        bool az_ = ay_ is CqlDateTime;

                        return az_;
                    };
                    if (ao_())
                    {
                        DataType ba_ = BicarbonateLab?.Effective;
                        object bb_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ba_);

                        return (bb_ as CqlDateTime) as object;
                    }
                    else if (ap_())
                    {
                        DataType bc_ = BicarbonateLab?.Effective;
                        object bd_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bc_);

                        return (bd_ as CqlInterval<CqlDateTime>) as object;
                    }
                    else if (aq_())
                    {
                        DataType be_ = BicarbonateLab?.Effective;
                        object bf_ = FHIRHelpers_4_4_000.Instance.ToValue(context, be_);

                        return (bf_ as CqlDateTime) as object;
                    }
                    else
                    {
                        return null;
                    }
                };
                CqlDateTime ab_ = QICoreCommon_4_0_000.Instance.earliest(context, aa_());
                CqlInterval<CqlDateTime> ac_ = CQMCommon_4_1_000.Instance.hospitalizationWithObservationAndOutpatientSurgeryService(context, EncounterInpatient);
                bool? ad_ = context.Operators.In<CqlDateTime>(ab_, ac_, default);
                Code<ObservationStatus> ae_ = BicarbonateLab?.StatusElement;
                ObservationStatus? af_ = ae_?.Value;
                string ag_ = context.Operators.Convert<string>(af_);
                string[] ah_ = [
                    "final",
                    "amended",
                    "corrected",
                ];
                bool? ai_ = context.Operators.In<string>(ag_, (IEnumerable<string>)ah_);
                bool? aj_ = context.Operators.And(ad_, ai_);
                DataType ak_ = BicarbonateLab?.Value;
                object al_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ak_);
                bool? am_ = context.Operators.Not((bool?)(al_ is null));
                bool? an_ = context.Operators.And(aj_, am_);

                return an_;
            };
            IEnumerable<Observation> j_ = context.Operators.Where<Observation>(h_, i_);
            object k_(Observation @this)
            {
                Instant bg_ = @this?.IssuedElement;
                DateTimeOffset? bh_ = bg_?.Value;
                CqlDateTime bi_ = context.Operators.Convert<CqlDateTime>(bh_);
                CqlDateTime bj_ = QICoreCommon_4_0_000.Instance.earliest(context, bi_ as object);

                return bj_;
            };
            IEnumerable<Observation> l_ = context.Operators.SortBy<Observation>(j_, k_, System.ComponentModel.ListSortDirection.Ascending);
            Observation m_ = context.Operators.First<Observation>(l_);
            DataType n_ = m_?.Value;
            object o_ = FHIRHelpers_4_4_000.Instance.ToValue(context, n_);
            IEnumerable<Observation> q_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, g_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation-lab"));
            bool? r_(Observation BicarbonateLab)
            {
                object bk_()
                {
                    bool by_()
                    {
                        DataType cb_ = BicarbonateLab?.Effective;
                        object cc_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cb_);
                        bool cd_ = cc_ is CqlDateTime;

                        return cd_;
                    };
                    bool bz_()
                    {
                        DataType ce_ = BicarbonateLab?.Effective;
                        object cf_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ce_);
                        bool cg_ = cf_ is CqlInterval<CqlDateTime>;

                        return cg_;
                    };
                    bool ca_()
                    {
                        DataType ch_ = BicarbonateLab?.Effective;
                        object ci_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ch_);
                        bool cj_ = ci_ is CqlDateTime;

                        return cj_;
                    };
                    if (by_())
                    {
                        DataType ck_ = BicarbonateLab?.Effective;
                        object cl_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ck_);

                        return (cl_ as CqlDateTime) as object;
                    }
                    else if (bz_())
                    {
                        DataType cm_ = BicarbonateLab?.Effective;
                        object cn_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cm_);

                        return (cn_ as CqlInterval<CqlDateTime>) as object;
                    }
                    else if (ca_())
                    {
                        DataType co_ = BicarbonateLab?.Effective;
                        object cp_ = FHIRHelpers_4_4_000.Instance.ToValue(context, co_);

                        return (cp_ as CqlDateTime) as object;
                    }
                    else
                    {
                        return null;
                    }
                };
                CqlDateTime bl_ = QICoreCommon_4_0_000.Instance.earliest(context, bk_());
                CqlInterval<CqlDateTime> bm_ = CQMCommon_4_1_000.Instance.hospitalizationWithObservationAndOutpatientSurgeryService(context, EncounterInpatient);
                bool? bn_ = context.Operators.In<CqlDateTime>(bl_, bm_, default);
                Code<ObservationStatus> bo_ = BicarbonateLab?.StatusElement;
                ObservationStatus? bp_ = bo_?.Value;
                string bq_ = context.Operators.Convert<string>(bp_);
                string[] br_ = [
                    "final",
                    "amended",
                    "corrected",
                ];
                bool? bs_ = context.Operators.In<string>(bq_, (IEnumerable<string>)br_);
                bool? bt_ = context.Operators.And(bn_, bs_);
                DataType bu_ = BicarbonateLab?.Value;
                object bv_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bu_);
                bool? bw_ = context.Operators.Not((bool?)(bv_ is null));
                bool? bx_ = context.Operators.And(bt_, bw_);

                return bx_;
            };
            IEnumerable<Observation> s_ = context.Operators.Where<Observation>(q_, r_);
            object t_(Observation @this)
            {
                Instant cq_ = @this?.IssuedElement;
                DateTimeOffset? cr_ = cq_?.Value;
                CqlDateTime cs_ = context.Operators.Convert<CqlDateTime>(cr_);
                CqlDateTime ct_ = QICoreCommon_4_0_000.Instance.earliest(context, cs_ as object);

                return ct_;
            };
            IEnumerable<Observation> u_ = context.Operators.SortBy<Observation>(s_, t_, System.ComponentModel.ListSortDirection.Ascending);
            Observation v_ = context.Operators.First<Observation>(u_);
            Instant w_ = v_?.IssuedElement;
            DateTimeOffset? x_ = w_?.Value;
            CqlDateTime y_ = context.Operators.Convert<CqlDateTime>(x_);
            (CqlTupleMetadata, string EncounterId, CqlQuantity FirstBicarbonateResult, CqlDateTime Timing)? z_ = (CqlTupleMetadata_GbUHPXXHScejjXWhcHJFQQifQ, f_, o_ as CqlQuantity, y_);

            return z_;
        };
        IEnumerable<(CqlTupleMetadata, string EncounterId, CqlQuantity FirstBicarbonateResult, CqlDateTime Timing)?> c_ = context.Operators.Select<Encounter, (CqlTupleMetadata, string EncounterId, CqlQuantity FirstBicarbonateResult, CqlDateTime Timing)?>(a_, b_);
        IEnumerable<(CqlTupleMetadata, string EncounterId, CqlQuantity FirstBicarbonateResult, CqlDateTime Timing)?> d_ = context.Operators.Distinct<(CqlTupleMetadata, string EncounterId, CqlQuantity FirstBicarbonateResult, CqlDateTime Timing)?>(c_);

        return d_;
    }


    [CqlExpressionDefinition("SDE Encounter With First Creatinine Lab Test")]
    public IEnumerable<(CqlTupleMetadata, string EncounterId, CqlQuantity FirstCreatinineResult, CqlDateTime Timing)?> SDE_Encounter_With_First_Creatinine_Lab_Test(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Inpatient_Encounters(context);
        (CqlTupleMetadata, string EncounterId, CqlQuantity FirstCreatinineResult, CqlDateTime Timing)? b_(Encounter EncounterInpatient)
        {
            Id e_ = EncounterInpatient?.IdElement;
            string f_ = e_?.Value;
            CqlValueSet g_ = this.Creatinine_lab_test(context);
            IEnumerable<Observation> h_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, g_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation-lab"));
            bool? i_(Observation CreatinineLab)
            {
                object aa_()
                {
                    bool ao_()
                    {
                        DataType ar_ = CreatinineLab?.Effective;
                        object as_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ar_);
                        bool at_ = as_ is CqlDateTime;

                        return at_;
                    };
                    bool ap_()
                    {
                        DataType au_ = CreatinineLab?.Effective;
                        object av_ = FHIRHelpers_4_4_000.Instance.ToValue(context, au_);
                        bool aw_ = av_ is CqlInterval<CqlDateTime>;

                        return aw_;
                    };
                    bool aq_()
                    {
                        DataType ax_ = CreatinineLab?.Effective;
                        object ay_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ax_);
                        bool az_ = ay_ is CqlDateTime;

                        return az_;
                    };
                    if (ao_())
                    {
                        DataType ba_ = CreatinineLab?.Effective;
                        object bb_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ba_);

                        return (bb_ as CqlDateTime) as object;
                    }
                    else if (ap_())
                    {
                        DataType bc_ = CreatinineLab?.Effective;
                        object bd_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bc_);

                        return (bd_ as CqlInterval<CqlDateTime>) as object;
                    }
                    else if (aq_())
                    {
                        DataType be_ = CreatinineLab?.Effective;
                        object bf_ = FHIRHelpers_4_4_000.Instance.ToValue(context, be_);

                        return (bf_ as CqlDateTime) as object;
                    }
                    else
                    {
                        return null;
                    }
                };
                CqlDateTime ab_ = QICoreCommon_4_0_000.Instance.earliest(context, aa_());
                CqlInterval<CqlDateTime> ac_ = CQMCommon_4_1_000.Instance.hospitalizationWithObservationAndOutpatientSurgeryService(context, EncounterInpatient);
                bool? ad_ = context.Operators.In<CqlDateTime>(ab_, ac_, default);
                Code<ObservationStatus> ae_ = CreatinineLab?.StatusElement;
                ObservationStatus? af_ = ae_?.Value;
                string ag_ = context.Operators.Convert<string>(af_);
                string[] ah_ = [
                    "final",
                    "amended",
                    "corrected",
                ];
                bool? ai_ = context.Operators.In<string>(ag_, (IEnumerable<string>)ah_);
                bool? aj_ = context.Operators.And(ad_, ai_);
                DataType ak_ = CreatinineLab?.Value;
                object al_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ak_);
                bool? am_ = context.Operators.Not((bool?)(al_ is null));
                bool? an_ = context.Operators.And(aj_, am_);

                return an_;
            };
            IEnumerable<Observation> j_ = context.Operators.Where<Observation>(h_, i_);
            object k_(Observation @this)
            {
                Instant bg_ = @this?.IssuedElement;
                DateTimeOffset? bh_ = bg_?.Value;
                CqlDateTime bi_ = context.Operators.Convert<CqlDateTime>(bh_);
                CqlDateTime bj_ = QICoreCommon_4_0_000.Instance.earliest(context, bi_ as object);

                return bj_;
            };
            IEnumerable<Observation> l_ = context.Operators.SortBy<Observation>(j_, k_, System.ComponentModel.ListSortDirection.Ascending);
            Observation m_ = context.Operators.First<Observation>(l_);
            DataType n_ = m_?.Value;
            object o_ = FHIRHelpers_4_4_000.Instance.ToValue(context, n_);
            IEnumerable<Observation> q_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, g_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation-lab"));
            bool? r_(Observation CreatinineLab)
            {
                object bk_()
                {
                    bool by_()
                    {
                        DataType cb_ = CreatinineLab?.Effective;
                        object cc_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cb_);
                        bool cd_ = cc_ is CqlDateTime;

                        return cd_;
                    };
                    bool bz_()
                    {
                        DataType ce_ = CreatinineLab?.Effective;
                        object cf_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ce_);
                        bool cg_ = cf_ is CqlInterval<CqlDateTime>;

                        return cg_;
                    };
                    bool ca_()
                    {
                        DataType ch_ = CreatinineLab?.Effective;
                        object ci_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ch_);
                        bool cj_ = ci_ is CqlDateTime;

                        return cj_;
                    };
                    if (by_())
                    {
                        DataType ck_ = CreatinineLab?.Effective;
                        object cl_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ck_);

                        return (cl_ as CqlDateTime) as object;
                    }
                    else if (bz_())
                    {
                        DataType cm_ = CreatinineLab?.Effective;
                        object cn_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cm_);

                        return (cn_ as CqlInterval<CqlDateTime>) as object;
                    }
                    else if (ca_())
                    {
                        DataType co_ = CreatinineLab?.Effective;
                        object cp_ = FHIRHelpers_4_4_000.Instance.ToValue(context, co_);

                        return (cp_ as CqlDateTime) as object;
                    }
                    else
                    {
                        return null;
                    }
                };
                CqlDateTime bl_ = QICoreCommon_4_0_000.Instance.earliest(context, bk_());
                CqlInterval<CqlDateTime> bm_ = CQMCommon_4_1_000.Instance.hospitalizationWithObservationAndOutpatientSurgeryService(context, EncounterInpatient);
                bool? bn_ = context.Operators.In<CqlDateTime>(bl_, bm_, default);
                Code<ObservationStatus> bo_ = CreatinineLab?.StatusElement;
                ObservationStatus? bp_ = bo_?.Value;
                string bq_ = context.Operators.Convert<string>(bp_);
                string[] br_ = [
                    "final",
                    "amended",
                    "corrected",
                ];
                bool? bs_ = context.Operators.In<string>(bq_, (IEnumerable<string>)br_);
                bool? bt_ = context.Operators.And(bn_, bs_);
                DataType bu_ = CreatinineLab?.Value;
                object bv_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bu_);
                bool? bw_ = context.Operators.Not((bool?)(bv_ is null));
                bool? bx_ = context.Operators.And(bt_, bw_);

                return bx_;
            };
            IEnumerable<Observation> s_ = context.Operators.Where<Observation>(q_, r_);
            object t_(Observation @this)
            {
                Instant cq_ = @this?.IssuedElement;
                DateTimeOffset? cr_ = cq_?.Value;
                CqlDateTime cs_ = context.Operators.Convert<CqlDateTime>(cr_);
                CqlDateTime ct_ = QICoreCommon_4_0_000.Instance.earliest(context, cs_ as object);

                return ct_;
            };
            IEnumerable<Observation> u_ = context.Operators.SortBy<Observation>(s_, t_, System.ComponentModel.ListSortDirection.Ascending);
            Observation v_ = context.Operators.First<Observation>(u_);
            Instant w_ = v_?.IssuedElement;
            DateTimeOffset? x_ = w_?.Value;
            CqlDateTime y_ = context.Operators.Convert<CqlDateTime>(x_);
            (CqlTupleMetadata, string EncounterId, CqlQuantity FirstCreatinineResult, CqlDateTime Timing)? z_ = (CqlTupleMetadata_FETECNQPQREfGRgPYWhOWgeWA, f_, o_ as CqlQuantity, y_);

            return z_;
        };
        IEnumerable<(CqlTupleMetadata, string EncounterId, CqlQuantity FirstCreatinineResult, CqlDateTime Timing)?> c_ = context.Operators.Select<Encounter, (CqlTupleMetadata, string EncounterId, CqlQuantity FirstCreatinineResult, CqlDateTime Timing)?>(a_, b_);
        IEnumerable<(CqlTupleMetadata, string EncounterId, CqlQuantity FirstCreatinineResult, CqlDateTime Timing)?> d_ = context.Operators.Distinct<(CqlTupleMetadata, string EncounterId, CqlQuantity FirstCreatinineResult, CqlDateTime Timing)?>(c_);

        return d_;
    }


    [CqlExpressionDefinition("SDE Encounter With First Hematocrit Lab Test")]
    public IEnumerable<(CqlTupleMetadata, string EncounterId, CqlQuantity FirstHematocritResult, CqlDateTime Timing)?> SDE_Encounter_With_First_Hematocrit_Lab_Test(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Inpatient_Encounters(context);
        (CqlTupleMetadata, string EncounterId, CqlQuantity FirstHematocritResult, CqlDateTime Timing)? b_(Encounter EncounterInpatient)
        {
            Id e_ = EncounterInpatient?.IdElement;
            string f_ = e_?.Value;
            CqlValueSet g_ = this.Hematocrit_lab_test(context);
            IEnumerable<Observation> h_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, g_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation-lab"));
            bool? i_(Observation HematocritLab)
            {
                object aa_()
                {
                    bool ao_()
                    {
                        DataType ar_ = HematocritLab?.Effective;
                        object as_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ar_);
                        bool at_ = as_ is CqlDateTime;

                        return at_;
                    };
                    bool ap_()
                    {
                        DataType au_ = HematocritLab?.Effective;
                        object av_ = FHIRHelpers_4_4_000.Instance.ToValue(context, au_);
                        bool aw_ = av_ is CqlInterval<CqlDateTime>;

                        return aw_;
                    };
                    bool aq_()
                    {
                        DataType ax_ = HematocritLab?.Effective;
                        object ay_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ax_);
                        bool az_ = ay_ is CqlDateTime;

                        return az_;
                    };
                    if (ao_())
                    {
                        DataType ba_ = HematocritLab?.Effective;
                        object bb_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ba_);

                        return (bb_ as CqlDateTime) as object;
                    }
                    else if (ap_())
                    {
                        DataType bc_ = HematocritLab?.Effective;
                        object bd_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bc_);

                        return (bd_ as CqlInterval<CqlDateTime>) as object;
                    }
                    else if (aq_())
                    {
                        DataType be_ = HematocritLab?.Effective;
                        object bf_ = FHIRHelpers_4_4_000.Instance.ToValue(context, be_);

                        return (bf_ as CqlDateTime) as object;
                    }
                    else
                    {
                        return null;
                    }
                };
                CqlDateTime ab_ = QICoreCommon_4_0_000.Instance.earliest(context, aa_());
                CqlInterval<CqlDateTime> ac_ = CQMCommon_4_1_000.Instance.hospitalizationWithObservationAndOutpatientSurgeryService(context, EncounterInpatient);
                bool? ad_ = context.Operators.In<CqlDateTime>(ab_, ac_, default);
                Code<ObservationStatus> ae_ = HematocritLab?.StatusElement;
                ObservationStatus? af_ = ae_?.Value;
                string ag_ = context.Operators.Convert<string>(af_);
                string[] ah_ = [
                    "final",
                    "amended",
                    "corrected",
                ];
                bool? ai_ = context.Operators.In<string>(ag_, (IEnumerable<string>)ah_);
                bool? aj_ = context.Operators.And(ad_, ai_);
                DataType ak_ = HematocritLab?.Value;
                object al_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ak_);
                bool? am_ = context.Operators.Not((bool?)(al_ is null));
                bool? an_ = context.Operators.And(aj_, am_);

                return an_;
            };
            IEnumerable<Observation> j_ = context.Operators.Where<Observation>(h_, i_);
            object k_(Observation @this)
            {
                Instant bg_ = @this?.IssuedElement;
                DateTimeOffset? bh_ = bg_?.Value;
                CqlDateTime bi_ = context.Operators.Convert<CqlDateTime>(bh_);
                CqlDateTime bj_ = QICoreCommon_4_0_000.Instance.earliest(context, bi_ as object);

                return bj_;
            };
            IEnumerable<Observation> l_ = context.Operators.SortBy<Observation>(j_, k_, System.ComponentModel.ListSortDirection.Ascending);
            Observation m_ = context.Operators.First<Observation>(l_);
            DataType n_ = m_?.Value;
            object o_ = FHIRHelpers_4_4_000.Instance.ToValue(context, n_);
            IEnumerable<Observation> q_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, g_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation-lab"));
            bool? r_(Observation HematocritLab)
            {
                object bk_()
                {
                    bool by_()
                    {
                        DataType cb_ = HematocritLab?.Effective;
                        object cc_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cb_);
                        bool cd_ = cc_ is CqlDateTime;

                        return cd_;
                    };
                    bool bz_()
                    {
                        DataType ce_ = HematocritLab?.Effective;
                        object cf_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ce_);
                        bool cg_ = cf_ is CqlInterval<CqlDateTime>;

                        return cg_;
                    };
                    bool ca_()
                    {
                        DataType ch_ = HematocritLab?.Effective;
                        object ci_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ch_);
                        bool cj_ = ci_ is CqlDateTime;

                        return cj_;
                    };
                    if (by_())
                    {
                        DataType ck_ = HematocritLab?.Effective;
                        object cl_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ck_);

                        return (cl_ as CqlDateTime) as object;
                    }
                    else if (bz_())
                    {
                        DataType cm_ = HematocritLab?.Effective;
                        object cn_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cm_);

                        return (cn_ as CqlInterval<CqlDateTime>) as object;
                    }
                    else if (ca_())
                    {
                        DataType co_ = HematocritLab?.Effective;
                        object cp_ = FHIRHelpers_4_4_000.Instance.ToValue(context, co_);

                        return (cp_ as CqlDateTime) as object;
                    }
                    else
                    {
                        return null;
                    }
                };
                CqlDateTime bl_ = QICoreCommon_4_0_000.Instance.earliest(context, bk_());
                CqlInterval<CqlDateTime> bm_ = CQMCommon_4_1_000.Instance.hospitalizationWithObservationAndOutpatientSurgeryService(context, EncounterInpatient);
                bool? bn_ = context.Operators.In<CqlDateTime>(bl_, bm_, default);
                Code<ObservationStatus> bo_ = HematocritLab?.StatusElement;
                ObservationStatus? bp_ = bo_?.Value;
                string bq_ = context.Operators.Convert<string>(bp_);
                string[] br_ = [
                    "final",
                    "amended",
                    "corrected",
                ];
                bool? bs_ = context.Operators.In<string>(bq_, (IEnumerable<string>)br_);
                bool? bt_ = context.Operators.And(bn_, bs_);
                DataType bu_ = HematocritLab?.Value;
                object bv_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bu_);
                bool? bw_ = context.Operators.Not((bool?)(bv_ is null));
                bool? bx_ = context.Operators.And(bt_, bw_);

                return bx_;
            };
            IEnumerable<Observation> s_ = context.Operators.Where<Observation>(q_, r_);
            object t_(Observation @this)
            {
                Instant cq_ = @this?.IssuedElement;
                DateTimeOffset? cr_ = cq_?.Value;
                CqlDateTime cs_ = context.Operators.Convert<CqlDateTime>(cr_);
                CqlDateTime ct_ = QICoreCommon_4_0_000.Instance.earliest(context, cs_ as object);

                return ct_;
            };
            IEnumerable<Observation> u_ = context.Operators.SortBy<Observation>(s_, t_, System.ComponentModel.ListSortDirection.Ascending);
            Observation v_ = context.Operators.First<Observation>(u_);
            Instant w_ = v_?.IssuedElement;
            DateTimeOffset? x_ = w_?.Value;
            CqlDateTime y_ = context.Operators.Convert<CqlDateTime>(x_);
            (CqlTupleMetadata, string EncounterId, CqlQuantity FirstHematocritResult, CqlDateTime Timing)? z_ = (CqlTupleMetadata_DIHdhbAJeJTdiAVUAELUHRNdS, f_, o_ as CqlQuantity, y_);

            return z_;
        };
        IEnumerable<(CqlTupleMetadata, string EncounterId, CqlQuantity FirstHematocritResult, CqlDateTime Timing)?> c_ = context.Operators.Select<Encounter, (CqlTupleMetadata, string EncounterId, CqlQuantity FirstHematocritResult, CqlDateTime Timing)?>(a_, b_);
        IEnumerable<(CqlTupleMetadata, string EncounterId, CqlQuantity FirstHematocritResult, CqlDateTime Timing)?> d_ = context.Operators.Distinct<(CqlTupleMetadata, string EncounterId, CqlQuantity FirstHematocritResult, CqlDateTime Timing)?>(c_);

        return d_;
    }


    [CqlExpressionDefinition("SDE Encounter With First Platelet Lab Test")]
    public IEnumerable<(CqlTupleMetadata, string EncounterId, CqlQuantity FirstPlateletResult, CqlDateTime Timing)?> SDE_Encounter_With_First_Platelet_Lab_Test(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Inpatient_Encounters(context);
        (CqlTupleMetadata, string EncounterId, CqlQuantity FirstPlateletResult, CqlDateTime Timing)? b_(Encounter EncounterInpatient)
        {
            Id e_ = EncounterInpatient?.IdElement;
            string f_ = e_?.Value;
            CqlValueSet g_ = this.Platelet_count_lab_test(context);
            IEnumerable<Observation> h_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, g_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation-lab"));
            bool? i_(Observation PlateletLab)
            {
                object aa_()
                {
                    bool ao_()
                    {
                        DataType ar_ = PlateletLab?.Effective;
                        object as_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ar_);
                        bool at_ = as_ is CqlDateTime;

                        return at_;
                    };
                    bool ap_()
                    {
                        DataType au_ = PlateletLab?.Effective;
                        object av_ = FHIRHelpers_4_4_000.Instance.ToValue(context, au_);
                        bool aw_ = av_ is CqlInterval<CqlDateTime>;

                        return aw_;
                    };
                    bool aq_()
                    {
                        DataType ax_ = PlateletLab?.Effective;
                        object ay_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ax_);
                        bool az_ = ay_ is CqlDateTime;

                        return az_;
                    };
                    if (ao_())
                    {
                        DataType ba_ = PlateletLab?.Effective;
                        object bb_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ba_);

                        return (bb_ as CqlDateTime) as object;
                    }
                    else if (ap_())
                    {
                        DataType bc_ = PlateletLab?.Effective;
                        object bd_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bc_);

                        return (bd_ as CqlInterval<CqlDateTime>) as object;
                    }
                    else if (aq_())
                    {
                        DataType be_ = PlateletLab?.Effective;
                        object bf_ = FHIRHelpers_4_4_000.Instance.ToValue(context, be_);

                        return (bf_ as CqlDateTime) as object;
                    }
                    else
                    {
                        return null;
                    }
                };
                CqlDateTime ab_ = QICoreCommon_4_0_000.Instance.earliest(context, aa_());
                CqlInterval<CqlDateTime> ac_ = CQMCommon_4_1_000.Instance.hospitalizationWithObservationAndOutpatientSurgeryService(context, EncounterInpatient);
                bool? ad_ = context.Operators.In<CqlDateTime>(ab_, ac_, default);
                Code<ObservationStatus> ae_ = PlateletLab?.StatusElement;
                ObservationStatus? af_ = ae_?.Value;
                string ag_ = context.Operators.Convert<string>(af_);
                string[] ah_ = [
                    "final",
                    "amended",
                    "corrected",
                ];
                bool? ai_ = context.Operators.In<string>(ag_, (IEnumerable<string>)ah_);
                bool? aj_ = context.Operators.And(ad_, ai_);
                DataType ak_ = PlateletLab?.Value;
                object al_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ak_);
                bool? am_ = context.Operators.Not((bool?)(al_ is null));
                bool? an_ = context.Operators.And(aj_, am_);

                return an_;
            };
            IEnumerable<Observation> j_ = context.Operators.Where<Observation>(h_, i_);
            object k_(Observation @this)
            {
                Instant bg_ = @this?.IssuedElement;
                DateTimeOffset? bh_ = bg_?.Value;
                CqlDateTime bi_ = context.Operators.Convert<CqlDateTime>(bh_);
                CqlDateTime bj_ = QICoreCommon_4_0_000.Instance.earliest(context, bi_ as object);

                return bj_;
            };
            IEnumerable<Observation> l_ = context.Operators.SortBy<Observation>(j_, k_, System.ComponentModel.ListSortDirection.Ascending);
            Observation m_ = context.Operators.First<Observation>(l_);
            DataType n_ = m_?.Value;
            object o_ = FHIRHelpers_4_4_000.Instance.ToValue(context, n_);
            IEnumerable<Observation> q_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, g_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation-lab"));
            bool? r_(Observation PlateletLab)
            {
                object bk_()
                {
                    bool by_()
                    {
                        DataType cb_ = PlateletLab?.Effective;
                        object cc_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cb_);
                        bool cd_ = cc_ is CqlDateTime;

                        return cd_;
                    };
                    bool bz_()
                    {
                        DataType ce_ = PlateletLab?.Effective;
                        object cf_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ce_);
                        bool cg_ = cf_ is CqlInterval<CqlDateTime>;

                        return cg_;
                    };
                    bool ca_()
                    {
                        DataType ch_ = PlateletLab?.Effective;
                        object ci_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ch_);
                        bool cj_ = ci_ is CqlDateTime;

                        return cj_;
                    };
                    if (by_())
                    {
                        DataType ck_ = PlateletLab?.Effective;
                        object cl_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ck_);

                        return (cl_ as CqlDateTime) as object;
                    }
                    else if (bz_())
                    {
                        DataType cm_ = PlateletLab?.Effective;
                        object cn_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cm_);

                        return (cn_ as CqlInterval<CqlDateTime>) as object;
                    }
                    else if (ca_())
                    {
                        DataType co_ = PlateletLab?.Effective;
                        object cp_ = FHIRHelpers_4_4_000.Instance.ToValue(context, co_);

                        return (cp_ as CqlDateTime) as object;
                    }
                    else
                    {
                        return null;
                    }
                };
                CqlDateTime bl_ = QICoreCommon_4_0_000.Instance.earliest(context, bk_());
                CqlInterval<CqlDateTime> bm_ = CQMCommon_4_1_000.Instance.hospitalizationWithObservationAndOutpatientSurgeryService(context, EncounterInpatient);
                bool? bn_ = context.Operators.In<CqlDateTime>(bl_, bm_, default);
                Code<ObservationStatus> bo_ = PlateletLab?.StatusElement;
                ObservationStatus? bp_ = bo_?.Value;
                string bq_ = context.Operators.Convert<string>(bp_);
                string[] br_ = [
                    "final",
                    "amended",
                    "corrected",
                ];
                bool? bs_ = context.Operators.In<string>(bq_, (IEnumerable<string>)br_);
                bool? bt_ = context.Operators.And(bn_, bs_);
                DataType bu_ = PlateletLab?.Value;
                object bv_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bu_);
                bool? bw_ = context.Operators.Not((bool?)(bv_ is null));
                bool? bx_ = context.Operators.And(bt_, bw_);

                return bx_;
            };
            IEnumerable<Observation> s_ = context.Operators.Where<Observation>(q_, r_);
            object t_(Observation @this)
            {
                Instant cq_ = @this?.IssuedElement;
                DateTimeOffset? cr_ = cq_?.Value;
                CqlDateTime cs_ = context.Operators.Convert<CqlDateTime>(cr_);
                CqlDateTime ct_ = QICoreCommon_4_0_000.Instance.earliest(context, cs_ as object);

                return ct_;
            };
            IEnumerable<Observation> u_ = context.Operators.SortBy<Observation>(s_, t_, System.ComponentModel.ListSortDirection.Ascending);
            Observation v_ = context.Operators.First<Observation>(u_);
            Instant w_ = v_?.IssuedElement;
            DateTimeOffset? x_ = w_?.Value;
            CqlDateTime y_ = context.Operators.Convert<CqlDateTime>(x_);
            (CqlTupleMetadata, string EncounterId, CqlQuantity FirstPlateletResult, CqlDateTime Timing)? z_ = (CqlTupleMetadata_DAUcYHQZcDKbIfORJOEZBDgIh, f_, o_ as CqlQuantity, y_);

            return z_;
        };
        IEnumerable<(CqlTupleMetadata, string EncounterId, CqlQuantity FirstPlateletResult, CqlDateTime Timing)?> c_ = context.Operators.Select<Encounter, (CqlTupleMetadata, string EncounterId, CqlQuantity FirstPlateletResult, CqlDateTime Timing)?>(a_, b_);
        IEnumerable<(CqlTupleMetadata, string EncounterId, CqlQuantity FirstPlateletResult, CqlDateTime Timing)?> d_ = context.Operators.Distinct<(CqlTupleMetadata, string EncounterId, CqlQuantity FirstPlateletResult, CqlDateTime Timing)?>(c_);

        return d_;
    }


    [CqlExpressionDefinition("SDE Encounter With First Sodium Lab Test")]
    public IEnumerable<(CqlTupleMetadata, string EncounterId, CqlQuantity FirstSodiumResult, CqlDateTime Timing)?> SDE_Encounter_With_First_Sodium_Lab_Test(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Inpatient_Encounters(context);
        (CqlTupleMetadata, string EncounterId, CqlQuantity FirstSodiumResult, CqlDateTime Timing)? b_(Encounter EncounterInpatient)
        {
            Id e_ = EncounterInpatient?.IdElement;
            string f_ = e_?.Value;
            CqlValueSet g_ = this.Sodium_lab_test(context);
            IEnumerable<Observation> h_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, g_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation-lab"));
            bool? i_(Observation SodiumLab)
            {
                object aa_()
                {
                    bool ao_()
                    {
                        DataType ar_ = SodiumLab?.Effective;
                        object as_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ar_);
                        bool at_ = as_ is CqlDateTime;

                        return at_;
                    };
                    bool ap_()
                    {
                        DataType au_ = SodiumLab?.Effective;
                        object av_ = FHIRHelpers_4_4_000.Instance.ToValue(context, au_);
                        bool aw_ = av_ is CqlInterval<CqlDateTime>;

                        return aw_;
                    };
                    bool aq_()
                    {
                        DataType ax_ = SodiumLab?.Effective;
                        object ay_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ax_);
                        bool az_ = ay_ is CqlDateTime;

                        return az_;
                    };
                    if (ao_())
                    {
                        DataType ba_ = SodiumLab?.Effective;
                        object bb_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ba_);

                        return (bb_ as CqlDateTime) as object;
                    }
                    else if (ap_())
                    {
                        DataType bc_ = SodiumLab?.Effective;
                        object bd_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bc_);

                        return (bd_ as CqlInterval<CqlDateTime>) as object;
                    }
                    else if (aq_())
                    {
                        DataType be_ = SodiumLab?.Effective;
                        object bf_ = FHIRHelpers_4_4_000.Instance.ToValue(context, be_);

                        return (bf_ as CqlDateTime) as object;
                    }
                    else
                    {
                        return null;
                    }
                };
                CqlDateTime ab_ = QICoreCommon_4_0_000.Instance.earliest(context, aa_());
                CqlInterval<CqlDateTime> ac_ = CQMCommon_4_1_000.Instance.hospitalizationWithObservationAndOutpatientSurgeryService(context, EncounterInpatient);
                bool? ad_ = context.Operators.In<CqlDateTime>(ab_, ac_, default);
                Code<ObservationStatus> ae_ = SodiumLab?.StatusElement;
                ObservationStatus? af_ = ae_?.Value;
                string ag_ = context.Operators.Convert<string>(af_);
                string[] ah_ = [
                    "final",
                    "amended",
                    "corrected",
                ];
                bool? ai_ = context.Operators.In<string>(ag_, (IEnumerable<string>)ah_);
                bool? aj_ = context.Operators.And(ad_, ai_);
                DataType ak_ = SodiumLab?.Value;
                object al_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ak_);
                bool? am_ = context.Operators.Not((bool?)(al_ is null));
                bool? an_ = context.Operators.And(aj_, am_);

                return an_;
            };
            IEnumerable<Observation> j_ = context.Operators.Where<Observation>(h_, i_);
            object k_(Observation @this)
            {
                Instant bg_ = @this?.IssuedElement;
                DateTimeOffset? bh_ = bg_?.Value;
                CqlDateTime bi_ = context.Operators.Convert<CqlDateTime>(bh_);
                CqlDateTime bj_ = QICoreCommon_4_0_000.Instance.earliest(context, bi_ as object);

                return bj_;
            };
            IEnumerable<Observation> l_ = context.Operators.SortBy<Observation>(j_, k_, System.ComponentModel.ListSortDirection.Ascending);
            Observation m_ = context.Operators.First<Observation>(l_);
            DataType n_ = m_?.Value;
            object o_ = FHIRHelpers_4_4_000.Instance.ToValue(context, n_);
            IEnumerable<Observation> q_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, g_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation-lab"));
            bool? r_(Observation SodiumLab)
            {
                object bk_()
                {
                    bool by_()
                    {
                        DataType cb_ = SodiumLab?.Effective;
                        object cc_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cb_);
                        bool cd_ = cc_ is CqlDateTime;

                        return cd_;
                    };
                    bool bz_()
                    {
                        DataType ce_ = SodiumLab?.Effective;
                        object cf_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ce_);
                        bool cg_ = cf_ is CqlInterval<CqlDateTime>;

                        return cg_;
                    };
                    bool ca_()
                    {
                        DataType ch_ = SodiumLab?.Effective;
                        object ci_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ch_);
                        bool cj_ = ci_ is CqlDateTime;

                        return cj_;
                    };
                    if (by_())
                    {
                        DataType ck_ = SodiumLab?.Effective;
                        object cl_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ck_);

                        return (cl_ as CqlDateTime) as object;
                    }
                    else if (bz_())
                    {
                        DataType cm_ = SodiumLab?.Effective;
                        object cn_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cm_);

                        return (cn_ as CqlInterval<CqlDateTime>) as object;
                    }
                    else if (ca_())
                    {
                        DataType co_ = SodiumLab?.Effective;
                        object cp_ = FHIRHelpers_4_4_000.Instance.ToValue(context, co_);

                        return (cp_ as CqlDateTime) as object;
                    }
                    else
                    {
                        return null;
                    }
                };
                CqlDateTime bl_ = QICoreCommon_4_0_000.Instance.earliest(context, bk_());
                CqlInterval<CqlDateTime> bm_ = CQMCommon_4_1_000.Instance.hospitalizationWithObservationAndOutpatientSurgeryService(context, EncounterInpatient);
                bool? bn_ = context.Operators.In<CqlDateTime>(bl_, bm_, default);
                Code<ObservationStatus> bo_ = SodiumLab?.StatusElement;
                ObservationStatus? bp_ = bo_?.Value;
                string bq_ = context.Operators.Convert<string>(bp_);
                string[] br_ = [
                    "final",
                    "amended",
                    "corrected",
                ];
                bool? bs_ = context.Operators.In<string>(bq_, (IEnumerable<string>)br_);
                bool? bt_ = context.Operators.And(bn_, bs_);
                DataType bu_ = SodiumLab?.Value;
                object bv_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bu_);
                bool? bw_ = context.Operators.Not((bool?)(bv_ is null));
                bool? bx_ = context.Operators.And(bt_, bw_);

                return bx_;
            };
            IEnumerable<Observation> s_ = context.Operators.Where<Observation>(q_, r_);
            object t_(Observation @this)
            {
                Instant cq_ = @this?.IssuedElement;
                DateTimeOffset? cr_ = cq_?.Value;
                CqlDateTime cs_ = context.Operators.Convert<CqlDateTime>(cr_);
                CqlDateTime ct_ = QICoreCommon_4_0_000.Instance.earliest(context, cs_ as object);

                return ct_;
            };
            IEnumerable<Observation> u_ = context.Operators.SortBy<Observation>(s_, t_, System.ComponentModel.ListSortDirection.Ascending);
            Observation v_ = context.Operators.First<Observation>(u_);
            Instant w_ = v_?.IssuedElement;
            DateTimeOffset? x_ = w_?.Value;
            CqlDateTime y_ = context.Operators.Convert<CqlDateTime>(x_);
            (CqlTupleMetadata, string EncounterId, CqlQuantity FirstSodiumResult, CqlDateTime Timing)? z_ = (CqlTupleMetadata_GKGeLARADLGJcNcZaDhdCREMa, f_, o_ as CqlQuantity, y_);

            return z_;
        };
        IEnumerable<(CqlTupleMetadata, string EncounterId, CqlQuantity FirstSodiumResult, CqlDateTime Timing)?> c_ = context.Operators.Select<Encounter, (CqlTupleMetadata, string EncounterId, CqlQuantity FirstSodiumResult, CqlDateTime Timing)?>(a_, b_);
        IEnumerable<(CqlTupleMetadata, string EncounterId, CqlQuantity FirstSodiumResult, CqlDateTime Timing)?> d_ = context.Operators.Distinct<(CqlTupleMetadata, string EncounterId, CqlQuantity FirstSodiumResult, CqlDateTime Timing)?>(c_);

        return d_;
    }


    [CqlExpressionDefinition("SDE Encounter With First White Blood Cells Lab Test")]
    public IEnumerable<(CqlTupleMetadata, string EncounterId, CqlQuantity FirstWhiteBloodCellResult, CqlDateTime Timing)?> SDE_Encounter_With_First_White_Blood_Cells_Lab_Test(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Inpatient_Encounters(context);
        (CqlTupleMetadata, string EncounterId, CqlQuantity FirstWhiteBloodCellResult, CqlDateTime Timing)? b_(Encounter EncounterInpatient)
        {
            Id e_ = EncounterInpatient?.IdElement;
            string f_ = e_?.Value;
            CqlValueSet g_ = this.White_blood_cells_count_lab_test(context);
            IEnumerable<Observation> h_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, g_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation-lab"));
            bool? i_(Observation WhiteBloodCellLab)
            {
                object aa_()
                {
                    bool ao_()
                    {
                        DataType ar_ = WhiteBloodCellLab?.Effective;
                        object as_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ar_);
                        bool at_ = as_ is CqlDateTime;

                        return at_;
                    };
                    bool ap_()
                    {
                        DataType au_ = WhiteBloodCellLab?.Effective;
                        object av_ = FHIRHelpers_4_4_000.Instance.ToValue(context, au_);
                        bool aw_ = av_ is CqlInterval<CqlDateTime>;

                        return aw_;
                    };
                    bool aq_()
                    {
                        DataType ax_ = WhiteBloodCellLab?.Effective;
                        object ay_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ax_);
                        bool az_ = ay_ is CqlDateTime;

                        return az_;
                    };
                    if (ao_())
                    {
                        DataType ba_ = WhiteBloodCellLab?.Effective;
                        object bb_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ba_);

                        return (bb_ as CqlDateTime) as object;
                    }
                    else if (ap_())
                    {
                        DataType bc_ = WhiteBloodCellLab?.Effective;
                        object bd_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bc_);

                        return (bd_ as CqlInterval<CqlDateTime>) as object;
                    }
                    else if (aq_())
                    {
                        DataType be_ = WhiteBloodCellLab?.Effective;
                        object bf_ = FHIRHelpers_4_4_000.Instance.ToValue(context, be_);

                        return (bf_ as CqlDateTime) as object;
                    }
                    else
                    {
                        return null;
                    }
                };
                CqlDateTime ab_ = QICoreCommon_4_0_000.Instance.earliest(context, aa_());
                CqlInterval<CqlDateTime> ac_ = CQMCommon_4_1_000.Instance.hospitalizationWithObservationAndOutpatientSurgeryService(context, EncounterInpatient);
                bool? ad_ = context.Operators.In<CqlDateTime>(ab_, ac_, default);
                Code<ObservationStatus> ae_ = WhiteBloodCellLab?.StatusElement;
                ObservationStatus? af_ = ae_?.Value;
                string ag_ = context.Operators.Convert<string>(af_);
                string[] ah_ = [
                    "final",
                    "amended",
                    "corrected",
                ];
                bool? ai_ = context.Operators.In<string>(ag_, (IEnumerable<string>)ah_);
                bool? aj_ = context.Operators.And(ad_, ai_);
                DataType ak_ = WhiteBloodCellLab?.Value;
                object al_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ak_);
                bool? am_ = context.Operators.Not((bool?)(al_ is null));
                bool? an_ = context.Operators.And(aj_, am_);

                return an_;
            };
            IEnumerable<Observation> j_ = context.Operators.Where<Observation>(h_, i_);
            object k_(Observation @this)
            {
                Instant bg_ = @this?.IssuedElement;
                DateTimeOffset? bh_ = bg_?.Value;
                CqlDateTime bi_ = context.Operators.Convert<CqlDateTime>(bh_);
                CqlDateTime bj_ = QICoreCommon_4_0_000.Instance.earliest(context, bi_ as object);

                return bj_;
            };
            IEnumerable<Observation> l_ = context.Operators.SortBy<Observation>(j_, k_, System.ComponentModel.ListSortDirection.Ascending);
            Observation m_ = context.Operators.First<Observation>(l_);
            DataType n_ = m_?.Value;
            object o_ = FHIRHelpers_4_4_000.Instance.ToValue(context, n_);
            IEnumerable<Observation> q_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, g_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation-lab"));
            bool? r_(Observation WhiteBloodCellLab)
            {
                object bk_()
                {
                    bool by_()
                    {
                        DataType cb_ = WhiteBloodCellLab?.Effective;
                        object cc_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cb_);
                        bool cd_ = cc_ is CqlDateTime;

                        return cd_;
                    };
                    bool bz_()
                    {
                        DataType ce_ = WhiteBloodCellLab?.Effective;
                        object cf_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ce_);
                        bool cg_ = cf_ is CqlInterval<CqlDateTime>;

                        return cg_;
                    };
                    bool ca_()
                    {
                        DataType ch_ = WhiteBloodCellLab?.Effective;
                        object ci_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ch_);
                        bool cj_ = ci_ is CqlDateTime;

                        return cj_;
                    };
                    if (by_())
                    {
                        DataType ck_ = WhiteBloodCellLab?.Effective;
                        object cl_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ck_);

                        return (cl_ as CqlDateTime) as object;
                    }
                    else if (bz_())
                    {
                        DataType cm_ = WhiteBloodCellLab?.Effective;
                        object cn_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cm_);

                        return (cn_ as CqlInterval<CqlDateTime>) as object;
                    }
                    else if (ca_())
                    {
                        DataType co_ = WhiteBloodCellLab?.Effective;
                        object cp_ = FHIRHelpers_4_4_000.Instance.ToValue(context, co_);

                        return (cp_ as CqlDateTime) as object;
                    }
                    else
                    {
                        return null;
                    }
                };
                CqlDateTime bl_ = QICoreCommon_4_0_000.Instance.earliest(context, bk_());
                CqlInterval<CqlDateTime> bm_ = CQMCommon_4_1_000.Instance.hospitalizationWithObservationAndOutpatientSurgeryService(context, EncounterInpatient);
                bool? bn_ = context.Operators.In<CqlDateTime>(bl_, bm_, default);
                Code<ObservationStatus> bo_ = WhiteBloodCellLab?.StatusElement;
                ObservationStatus? bp_ = bo_?.Value;
                string bq_ = context.Operators.Convert<string>(bp_);
                string[] br_ = [
                    "final",
                    "amended",
                    "corrected",
                ];
                bool? bs_ = context.Operators.In<string>(bq_, (IEnumerable<string>)br_);
                bool? bt_ = context.Operators.And(bn_, bs_);
                DataType bu_ = WhiteBloodCellLab?.Value;
                object bv_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bu_);
                bool? bw_ = context.Operators.Not((bool?)(bv_ is null));
                bool? bx_ = context.Operators.And(bt_, bw_);

                return bx_;
            };
            IEnumerable<Observation> s_ = context.Operators.Where<Observation>(q_, r_);
            object t_(Observation @this)
            {
                Instant cq_ = @this?.IssuedElement;
                DateTimeOffset? cr_ = cq_?.Value;
                CqlDateTime cs_ = context.Operators.Convert<CqlDateTime>(cr_);
                CqlDateTime ct_ = QICoreCommon_4_0_000.Instance.earliest(context, cs_ as object);

                return ct_;
            };
            IEnumerable<Observation> u_ = context.Operators.SortBy<Observation>(s_, t_, System.ComponentModel.ListSortDirection.Ascending);
            Observation v_ = context.Operators.First<Observation>(u_);
            Instant w_ = v_?.IssuedElement;
            DateTimeOffset? x_ = w_?.Value;
            CqlDateTime y_ = context.Operators.Convert<CqlDateTime>(x_);
            (CqlTupleMetadata, string EncounterId, CqlQuantity FirstWhiteBloodCellResult, CqlDateTime Timing)? z_ = (CqlTupleMetadata_ChVYCdXDGgVcFTCCUefXMbCHX, f_, o_ as CqlQuantity, y_);

            return z_;
        };
        IEnumerable<(CqlTupleMetadata, string EncounterId, CqlQuantity FirstWhiteBloodCellResult, CqlDateTime Timing)?> c_ = context.Operators.Select<Encounter, (CqlTupleMetadata, string EncounterId, CqlQuantity FirstWhiteBloodCellResult, CqlDateTime Timing)?>(a_, b_);
        IEnumerable<(CqlTupleMetadata, string EncounterId, CqlQuantity FirstWhiteBloodCellResult, CqlDateTime Timing)?> d_ = context.Operators.Distinct<(CqlTupleMetadata, string EncounterId, CqlQuantity FirstWhiteBloodCellResult, CqlDateTime Timing)?>(c_);

        return d_;
    }


    [CqlExpressionDefinition("SDE Encounter With Oxygen 60 Minutes Or Less Prior To ED Admission Or During ED")]
    public IEnumerable<Encounter> SDE_Encounter_With_Oxygen_60_Minutes_Or_Less_Prior_To_ED_Admission_Or_During_ED(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Initial_Population(context);
        bool? b_(Encounter EncounterInpatient)
        {
            CqlValueSet d_ = this.Non_Invasive_Oxygen_Therapy_by_Nasal_Cannula_or_Mask(context);
            IEnumerable<ServiceRequest> e_ = context.Operators.Retrieve<ServiceRequest>(new RetrieveParameters(default, d_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-servicerequest"));
            CqlValueSet f_ = this.Non_Invasive_Oxygen_Therapy_Device_Codes(context);
            IEnumerable<ServiceRequest> g_ = context.Operators.Retrieve<ServiceRequest>(new RetrieveParameters(default, f_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-servicerequest"));
            IEnumerable<ServiceRequest> h_ = context.Operators.Union<ServiceRequest>(e_, g_);
            bool? i_(ServiceRequest OxygenTherapyOrder)
            {
                FhirDateTime x_ = OxygenTherapyOrder?.AuthoredOnElement;
                CqlDateTime y_ = context.Operators.Convert<CqlDateTime>(x_);
                Encounter z_ = CQMCommon_4_1_000.Instance.edVisit(context, EncounterInpatient);
                Period aa_ = z_?.Period;
                CqlInterval<CqlDateTime> ab_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, aa_);
                bool? ac_ = context.Operators.In<CqlDateTime>(y_, ab_, default);
                CqlDateTime ae_ = context.Operators.Convert<CqlDateTime>(x_);
                Period ag_ = z_?.Period;
                CqlInterval<CqlDateTime> ah_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ag_);
                CqlDateTime ai_ = context.Operators.Start(ah_);
                CqlQuantity aj_ = context.Operators.Quantity(60m, "minutes");
                CqlDateTime ak_ = context.Operators.Subtract(ai_, aj_);
                Period am_ = z_?.Period;
                CqlInterval<CqlDateTime> an_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, am_);
                CqlDateTime ao_ = context.Operators.Start(an_);
                CqlInterval<CqlDateTime> ap_ = context.Operators.Interval(ak_, ao_, true, true);
                bool? aq_ = context.Operators.In<CqlDateTime>(ae_, ap_, default);
                Period as_ = z_?.Period;
                CqlInterval<CqlDateTime> at_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, as_);
                CqlDateTime au_ = context.Operators.Start(at_);
                bool? av_ = context.Operators.Not((bool?)(au_ is null));
                bool? aw_ = context.Operators.And(aq_, av_);
                bool? ax_ = context.Operators.Or(ac_, aw_);
                Code<RequestStatus> ay_ = OxygenTherapyOrder?.StatusElement;
                RequestStatus? az_ = ay_?.Value;
                Code<RequestStatus> ba_ = context.Operators.Convert<Code<RequestStatus>>(az_);
                string bb_ = context.Operators.Convert<string>(ba_);
                string[] bc_ = [
                    "active",
                    "completed",
                ];
                bool? bd_ = context.Operators.In<string>(bb_, (IEnumerable<string>)bc_);
                bool? be_ = context.Operators.And(ax_, bd_);
                Code<RequestIntent> bf_ = OxygenTherapyOrder?.IntentElement;
                RequestIntent? bg_ = bf_?.Value;
                Code<RequestIntent> bh_ = context.Operators.Convert<Code<RequestIntent>>(bg_);
                bool? bi_ = context.Operators.Equal(bh_, "order");
                bool? bj_ = context.Operators.And(be_, bi_);

                return bj_;
            };
            IEnumerable<ServiceRequest> j_ = context.Operators.Where<ServiceRequest>(h_, i_);
            (CqlTupleMetadata, string EncounterId, Code<RequestStatus> OrderStatus, CqlDateTime OrderTiming)? k_(ServiceRequest OxygenTherapyOrder)
            {
                Id bk_ = EncounterInpatient?.IdElement;
                string bl_ = bk_?.Value;
                Code<RequestStatus> bm_ = OxygenTherapyOrder?.StatusElement;
                RequestStatus? bn_ = bm_?.Value;
                Code<RequestStatus> bo_ = context.Operators.Convert<Code<RequestStatus>>(bn_);
                FhirDateTime bp_ = OxygenTherapyOrder?.AuthoredOnElement;
                CqlDateTime bq_ = context.Operators.Convert<CqlDateTime>(bp_);
                (CqlTupleMetadata, string EncounterId, Code<RequestStatus> OrderStatus, CqlDateTime OrderTiming)? br_ = (CqlTupleMetadata_BTRiFTXPQGKeiLWUSieghMWCU, bl_, bo_, bq_);

                return br_;
            };
            IEnumerable<(CqlTupleMetadata, string EncounterId, Code<RequestStatus> OrderStatus, CqlDateTime OrderTiming)?> l_ = context.Operators.Select<ServiceRequest, (CqlTupleMetadata, string EncounterId, Code<RequestStatus> OrderStatus, CqlDateTime OrderTiming)?>(j_, k_);
            IEnumerable<(CqlTupleMetadata, string EncounterId, Code<RequestStatus> OrderStatus, CqlDateTime OrderTiming)?> m_ = context.Operators.Distinct<(CqlTupleMetadata, string EncounterId, Code<RequestStatus> OrderStatus, CqlDateTime OrderTiming)?>(l_);
            bool? n_ = context.Operators.Exists<(CqlTupleMetadata, string EncounterId, Code<RequestStatus> OrderStatus, CqlDateTime OrderTiming)?>(m_);
            IEnumerable<Procedure> p_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, d_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
            bool? q_(Procedure OxygenAdminInterv)
            {
                object bs_()
                {
                    bool da_()
                    {
                        DataType de_ = OxygenAdminInterv?.Performed;
                        object df_ = FHIRHelpers_4_4_000.Instance.ToValue(context, de_);
                        bool dg_ = df_ is CqlDateTime;

                        return dg_;
                    };
                    bool db_()
                    {
                        DataType dh_ = OxygenAdminInterv?.Performed;
                        object di_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dh_);
                        bool dj_ = di_ is CqlInterval<CqlDateTime>;

                        return dj_;
                    };
                    bool dc_()
                    {
                        DataType dk_ = OxygenAdminInterv?.Performed;
                        object dl_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dk_);
                        bool dm_ = dl_ is CqlQuantity;

                        return dm_;
                    };
                    bool dd_()
                    {
                        DataType dn_ = OxygenAdminInterv?.Performed;
                        object do_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dn_);
                        bool dp_ = do_ is CqlInterval<CqlQuantity>;

                        return dp_;
                    };
                    if (da_())
                    {
                        DataType dq_ = OxygenAdminInterv?.Performed;
                        object dr_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dq_);

                        return (dr_ as CqlDateTime) as object;
                    }
                    else if (db_())
                    {
                        DataType ds_ = OxygenAdminInterv?.Performed;
                        object dt_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ds_);

                        return (dt_ as CqlInterval<CqlDateTime>) as object;
                    }
                    else if (dc_())
                    {
                        DataType du_ = OxygenAdminInterv?.Performed;
                        object dv_ = FHIRHelpers_4_4_000.Instance.ToValue(context, du_);

                        return (dv_ as CqlQuantity) as object;
                    }
                    else if (dd_())
                    {
                        DataType dw_ = OxygenAdminInterv?.Performed;
                        object dx_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dw_);

                        return (dx_ as CqlInterval<CqlQuantity>) as object;
                    }
                    else
                    {
                        return null;
                    }
                };
                CqlInterval<CqlDateTime> bt_ = QICoreCommon_4_0_000.Instance.toInterval(context, bs_());
                CqlDateTime bu_ = context.Operators.Start(bt_);
                Encounter bv_ = CQMCommon_4_1_000.Instance.edVisit(context, EncounterInpatient);
                Period bw_ = bv_?.Period;
                CqlInterval<CqlDateTime> bx_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, bw_);
                bool? by_ = context.Operators.In<CqlDateTime>(bu_, bx_, default);
                object bz_()
                {
                    bool dy_()
                    {
                        DataType ec_ = OxygenAdminInterv?.Performed;
                        object ed_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ec_);
                        bool ee_ = ed_ is CqlDateTime;

                        return ee_;
                    };
                    bool dz_()
                    {
                        DataType ef_ = OxygenAdminInterv?.Performed;
                        object eg_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ef_);
                        bool eh_ = eg_ is CqlInterval<CqlDateTime>;

                        return eh_;
                    };
                    bool ea_()
                    {
                        DataType ei_ = OxygenAdminInterv?.Performed;
                        object ej_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ei_);
                        bool ek_ = ej_ is CqlQuantity;

                        return ek_;
                    };
                    bool eb_()
                    {
                        DataType el_ = OxygenAdminInterv?.Performed;
                        object em_ = FHIRHelpers_4_4_000.Instance.ToValue(context, el_);
                        bool en_ = em_ is CqlInterval<CqlQuantity>;

                        return en_;
                    };
                    if (dy_())
                    {
                        DataType eo_ = OxygenAdminInterv?.Performed;
                        object ep_ = FHIRHelpers_4_4_000.Instance.ToValue(context, eo_);

                        return (ep_ as CqlDateTime) as object;
                    }
                    else if (dz_())
                    {
                        DataType eq_ = OxygenAdminInterv?.Performed;
                        object er_ = FHIRHelpers_4_4_000.Instance.ToValue(context, eq_);

                        return (er_ as CqlInterval<CqlDateTime>) as object;
                    }
                    else if (ea_())
                    {
                        DataType es_ = OxygenAdminInterv?.Performed;
                        object et_ = FHIRHelpers_4_4_000.Instance.ToValue(context, es_);

                        return (et_ as CqlQuantity) as object;
                    }
                    else if (eb_())
                    {
                        DataType eu_ = OxygenAdminInterv?.Performed;
                        object ev_ = FHIRHelpers_4_4_000.Instance.ToValue(context, eu_);

                        return (ev_ as CqlInterval<CqlQuantity>) as object;
                    }
                    else
                    {
                        return null;
                    }
                };
                CqlInterval<CqlDateTime> ca_ = QICoreCommon_4_0_000.Instance.toInterval(context, bz_());
                CqlDateTime cb_ = context.Operators.End(ca_);
                Period cd_ = bv_?.Period;
                CqlInterval<CqlDateTime> ce_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, cd_);
                CqlDateTime cf_ = context.Operators.Start(ce_);
                CqlQuantity cg_ = context.Operators.Quantity(60m, "minutes");
                CqlDateTime ch_ = context.Operators.Subtract(cf_, cg_);
                Period cj_ = bv_?.Period;
                CqlInterval<CqlDateTime> ck_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, cj_);
                CqlDateTime cl_ = context.Operators.Start(ck_);
                CqlInterval<CqlDateTime> cm_ = context.Operators.Interval(ch_, cl_, true, true);
                bool? cn_ = context.Operators.In<CqlDateTime>(cb_, cm_, default);
                Period cp_ = bv_?.Period;
                CqlInterval<CqlDateTime> cq_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, cp_);
                CqlDateTime cr_ = context.Operators.Start(cq_);
                bool? cs_ = context.Operators.Not((bool?)(cr_ is null));
                bool? ct_ = context.Operators.And(cn_, cs_);
                bool? cu_ = context.Operators.Or(by_, ct_);
                Code<EventStatus> cv_ = OxygenAdminInterv?.StatusElement;
                EventStatus? cw_ = cv_?.Value;
                string cx_ = context.Operators.Convert<string>(cw_);
                bool? cy_ = context.Operators.Equal(cx_, "completed");
                bool? cz_ = context.Operators.And(cu_, cy_);

                return cz_;
            };
            IEnumerable<Procedure> r_ = context.Operators.Where<Procedure>(p_, q_);
            (CqlTupleMetadata, string EncounterId, CqlInterval<CqlDateTime> EDEncounterTiming, string PerformedStatus, CqlInterval<CqlDateTime> PerformedTiming)? s_(Procedure OxygenAdminInterv)
            {
                Id ew_ = EncounterInpatient?.IdElement;
                string ex_ = ew_?.Value;
                Encounter ey_ = CQMCommon_4_1_000.Instance.edVisit(context, EncounterInpatient);
                Period ez_ = ey_?.Period;
                CqlInterval<CqlDateTime> fa_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ez_);
                Code<EventStatus> fb_ = OxygenAdminInterv?.StatusElement;
                EventStatus? fc_ = fb_?.Value;
                string fd_ = context.Operators.Convert<string>(fc_);
                object fe_()
                {
                    bool fh_()
                    {
                        DataType fl_ = OxygenAdminInterv?.Performed;
                        object fm_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fl_);
                        bool fn_ = fm_ is CqlDateTime;

                        return fn_;
                    };
                    bool fi_()
                    {
                        DataType fo_ = OxygenAdminInterv?.Performed;
                        object fp_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fo_);
                        bool fq_ = fp_ is CqlInterval<CqlDateTime>;

                        return fq_;
                    };
                    bool fj_()
                    {
                        DataType fr_ = OxygenAdminInterv?.Performed;
                        object fs_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fr_);
                        bool ft_ = fs_ is CqlQuantity;

                        return ft_;
                    };
                    bool fk_()
                    {
                        DataType fu_ = OxygenAdminInterv?.Performed;
                        object fv_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fu_);
                        bool fw_ = fv_ is CqlInterval<CqlQuantity>;

                        return fw_;
                    };
                    if (fh_())
                    {
                        DataType fx_ = OxygenAdminInterv?.Performed;
                        object fy_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fx_);

                        return (fy_ as CqlDateTime) as object;
                    }
                    else if (fi_())
                    {
                        DataType fz_ = OxygenAdminInterv?.Performed;
                        object ga_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fz_);

                        return (ga_ as CqlInterval<CqlDateTime>) as object;
                    }
                    else if (fj_())
                    {
                        DataType gb_ = OxygenAdminInterv?.Performed;
                        object gc_ = FHIRHelpers_4_4_000.Instance.ToValue(context, gb_);

                        return (gc_ as CqlQuantity) as object;
                    }
                    else if (fk_())
                    {
                        DataType gd_ = OxygenAdminInterv?.Performed;
                        object ge_ = FHIRHelpers_4_4_000.Instance.ToValue(context, gd_);

                        return (ge_ as CqlInterval<CqlQuantity>) as object;
                    }
                    else
                    {
                        return null;
                    }
                };
                CqlInterval<CqlDateTime> ff_ = QICoreCommon_4_0_000.Instance.toInterval(context, fe_());
                (CqlTupleMetadata, string EncounterId, CqlInterval<CqlDateTime> EDEncounterTiming, string PerformedStatus, CqlInterval<CqlDateTime> PerformedTiming)? fg_ = (CqlTupleMetadata_HBSiHLDibCXHQcPZYMVBgXBIH, ex_, fa_, fd_, ff_);

                return fg_;
            };
            IEnumerable<(CqlTupleMetadata, string EncounterId, CqlInterval<CqlDateTime> EDEncounterTiming, string PerformedStatus, CqlInterval<CqlDateTime> PerformedTiming)?> t_ = context.Operators.Select<Procedure, (CqlTupleMetadata, string EncounterId, CqlInterval<CqlDateTime> EDEncounterTiming, string PerformedStatus, CqlInterval<CqlDateTime> PerformedTiming)?>(r_, s_);
            IEnumerable<(CqlTupleMetadata, string EncounterId, CqlInterval<CqlDateTime> EDEncounterTiming, string PerformedStatus, CqlInterval<CqlDateTime> PerformedTiming)?> u_ = context.Operators.Distinct<(CqlTupleMetadata, string EncounterId, CqlInterval<CqlDateTime> EDEncounterTiming, string PerformedStatus, CqlInterval<CqlDateTime> PerformedTiming)?>(t_);
            bool? v_ = context.Operators.Exists<(CqlTupleMetadata, string EncounterId, CqlInterval<CqlDateTime> EDEncounterTiming, string PerformedStatus, CqlInterval<CqlDateTime> PerformedTiming)?>(u_);
            bool? w_ = context.Operators.Or(n_, v_);

            return w_;
        };
        IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);

        return c_;
    }


    [CqlExpressionDefinition("SDE Ethnicity")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Ethnicity(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? a_ = SupplementalDataElements_5_1_000.Instance.SDE_Ethnicity(context);

        return a_;
    }


    [CqlExpressionDefinition("SDE Payer")]
    public IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> SDE_Payer(CqlContext context)
    {
        IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> a_ = SupplementalDataElements_5_1_000.Instance.SDE_Payer(context);

        return a_;
    }


    [CqlExpressionDefinition("SDE Race")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Race(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? a_ = SupplementalDataElements_5_1_000.Instance.SDE_Race(context);

        return a_;
    }


    [CqlExpressionDefinition("SDE Sex")]
    public CqlCode SDE_Sex(CqlContext context)
    {
        CqlCode a_ = SupplementalDataElements_5_1_000.Instance.SDE_Sex(context);

        return a_;
    }


    #endregion Functions and Expressions

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

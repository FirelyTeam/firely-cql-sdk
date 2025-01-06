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

[System.CodeDom.Compiler.GeneratedCode(".NET Code Generation", "2.0.9.0")]
[CqlLibrary("HybridHospitalWideMortalityFHIR", "0.0.001")]
public partial class HybridHospitalWideMortalityFHIR_0_0_001 : ILibrary, ISingleton<HybridHospitalWideMortalityFHIR_0_0_001>
{
    private HybridHospitalWideMortalityFHIR_0_0_001() {}

    public static HybridHospitalWideMortalityFHIR_0_0_001 Instance { get; } = new();

    #region Library Members
    string ILibrary.Name => "HybridHospitalWideMortalityFHIR";
    string ILibrary.Version => "0.0.001";
    IReadOnlyList<ILibrary> ILibrary.Dependencies => [CQMCommon_2_2_000.Instance, FHIRHelpers_4_4_000.Instance, SupplementalDataElements_3_5_000.Instance, QICoreCommon_2_1_000.Instance];
    #endregion Library Members

    [CqlDeclaration("Bicarbonate lab test")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1045.139")]
    public CqlValueSet Bicarbonate_lab_test(CqlContext context) =>
        new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1045.139", default);



    [CqlDeclaration("Creatinine lab test")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.666.5.2363")]
    public CqlValueSet Creatinine_lab_test(CqlContext context) =>
        new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.666.5.2363", default);



    [CqlDeclaration("Encounter Inpatient")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.666.5.307")]
    public CqlValueSet Encounter_Inpatient(CqlContext context) =>
        new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.666.5.307", default);



    [CqlDeclaration("Hematocrit lab test")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1045.114")]
    public CqlValueSet Hematocrit_lab_test(CqlContext context) =>
        new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1045.114", default);



    [CqlDeclaration("Medicare Advantage payer")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1104.12")]
    public CqlValueSet Medicare_Advantage_payer(CqlContext context) =>
        new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1104.12", default);



    [CqlDeclaration("Medicare FFS payer")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1104.10")]
    public CqlValueSet Medicare_FFS_payer(CqlContext context) =>
        new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1104.10", default);



    [CqlDeclaration("Oxygen Saturation by Pulse Oximetry")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1045.151")]
    public CqlValueSet Oxygen_Saturation_by_Pulse_Oximetry(CqlContext context) =>
        new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1045.151", default);



    [CqlDeclaration("Platelet count lab test")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1045.127")]
    public CqlValueSet Platelet_count_lab_test(CqlContext context) =>
        new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1045.127", default);



    [CqlDeclaration("Sodium lab test")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1045.119")]
    public CqlValueSet Sodium_lab_test(CqlContext context) =>
        new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1045.119", default);



    [CqlDeclaration("White blood cells count lab test")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1045.129")]
    public CqlValueSet White_blood_cells_count_lab_test(CqlContext context) =>
        new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1045.129", default);



    [CqlDeclaration("Oxygen saturation in Arterial blood")]
    public CqlCode Oxygen_saturation_in_Arterial_blood(CqlContext context) =>
        new CqlCode("2708-6", "http://loinc.org", default, default);



    [CqlDeclaration("Oxygen saturation in Arterial blood by Pulse oximetry")]
    public CqlCode Oxygen_saturation_in_Arterial_blood_by_Pulse_oximetry(CqlContext context) =>
        new CqlCode("59408-5", "http://loinc.org", default, default);



    [CqlDeclaration("Systolic blood pressure")]
    public CqlCode Systolic_blood_pressure(CqlContext context) =>
        new CqlCode("8480-6", "http://loinc.org", default, default);



    [CqlDeclaration("LOINC")]
    public CqlCode[] LOINC(CqlContext context)
    {
        CqlCode[] a_ = [
            new CqlCode("2708-6", "http://loinc.org", default, default),
            new CqlCode("59408-5", "http://loinc.org", default, default),
            new CqlCode("8480-6", "http://loinc.org", default, default),
        ];

        return a_;
    }



    [CqlDeclaration("ActCode")]
    public CqlCode[] ActCode(CqlContext context)
    {
        CqlCode[] a_ = []
;

        return a_;
    }



    [CqlDeclaration("Source of Payment Typology")]
    public CqlCode[] Source_of_Payment_Typology(CqlContext context)
    {
        CqlCode[] a_ = []
;

        return a_;
    }



    [CqlDeclaration("Measurement Period")]
    public CqlInterval<CqlDateTime> Measurement_Period(CqlContext context)
    {
        CqlDateTime a_ = context.Operators.DateTime(2025, 1, 1, 0, 0, 0, 0, 0.0m);
        CqlDateTime b_ = context.Operators.DateTime(2025, 12, 31, 23, 59, 59, 999, 0.0m);
        CqlInterval<CqlDateTime> c_ = context.Operators.Interval(a_, b_, true, true);
        object d_ = context.ResolveParameter("HybridHospitalWideMortalityFHIR-0.0.001", "Measurement Period", c_);

        return (CqlInterval<CqlDateTime>)d_;
    }



    [CqlDeclaration("Patient")]
    public Patient Patient(CqlContext context)
    {
        IEnumerable<Patient> a_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-patient"));
        Patient b_ = context.Operators.SingletonFrom<Patient>(a_);

        return b_;
    }



    [CqlDeclaration("Inpatient Encounters")]
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
                InpatientEncounter;
            IEnumerable<Encounter> m_ = context.Operators.Select<Coverage, Encounter>(k_, l_);

            return m_;
        };
        IEnumerable<Encounter> d_ = context.Operators.SelectMany<Encounter, Encounter>(b_, c_);

        return d_;
    }



    [CqlDeclaration("Initial Population")]
    public IEnumerable<Encounter> Initial_Population(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Inpatient_Encounters(context);

        return a_;
    }



    [CqlDeclaration("Encounter with First Body Temperature")]
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
                Period ab_ = EncounterInpatient?.Period;
                CqlInterval<CqlDateTime> ac_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ab_);
                CqlDateTime ad_ = context.Operators.Start(ac_);
                CqlQuantity ae_ = context.Operators.Quantity(1440m, "minutes");
                CqlDateTime af_ = context.Operators.Subtract(ad_, ae_);
                CqlInterval<CqlDateTime> ah_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ab_);
                CqlDateTime ai_ = context.Operators.Start(ah_);
                CqlQuantity aj_ = context.Operators.Quantity(120m, "minutes");
                CqlDateTime ak_ = context.Operators.Add(ai_, aj_);
                CqlInterval<CqlDateTime> al_ = context.Operators.Interval(af_, ak_, true, true);
                bool? am_ = context.Operators.In<CqlDateTime>(aa_, al_, default);
                Code<ObservationStatus> an_ = temperature?.StatusElement;
                ObservationStatus? ao_ = an_?.Value;
                string ap_ = context.Operators.Convert<string>(ao_);
                string[] aq_ = [
                    "final",
                    "amended",
                    "corrected",
                ];
                bool? ar_ = context.Operators.In<string>(ap_, aq_ as IEnumerable<string>);
                bool? as_ = context.Operators.And(am_, ar_);
                DataType at_ = temperature?.Value;
                CqlQuantity au_ = FHIRHelpers_4_4_000.Instance.ToQuantity(context, at_ as Quantity);
                bool? av_ = context.Operators.Not((bool?)(au_ is null));
                bool? aw_ = context.Operators.And(as_, av_);

                return aw_;
            };
            IEnumerable<Observation> i_ = context.Operators.Where<Observation>(g_, h_);
            object j_(Observation @this)
            {
                DataType ax_ = @this?.Effective;
                object ay_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ax_);
                CqlDateTime az_ = QICoreCommon_2_1_000.Instance.earliest(context, ay_);

                return az_;
            };
            IEnumerable<Observation> k_ = context.Operators.SortBy<Observation>(i_, j_, System.ComponentModel.ListSortDirection.Ascending);
            Observation l_ = context.Operators.First<Observation>(k_);
            DataType m_ = l_?.Value;
            CqlQuantity n_ = FHIRHelpers_4_4_000.Instance.ToQuantity(context, m_ as Quantity);
            bool? p_(Observation temperature)
            {
                DataType ba_ = temperature?.Effective;
                object bb_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ba_);
                CqlDateTime bc_ = QICoreCommon_2_1_000.Instance.earliest(context, bb_);
                Period bd_ = EncounterInpatient?.Period;
                CqlInterval<CqlDateTime> be_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, bd_);
                CqlDateTime bf_ = context.Operators.Start(be_);
                CqlQuantity bg_ = context.Operators.Quantity(1440m, "minutes");
                CqlDateTime bh_ = context.Operators.Subtract(bf_, bg_);
                CqlInterval<CqlDateTime> bj_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, bd_);
                CqlDateTime bk_ = context.Operators.Start(bj_);
                CqlQuantity bl_ = context.Operators.Quantity(120m, "minutes");
                CqlDateTime bm_ = context.Operators.Add(bk_, bl_);
                CqlInterval<CqlDateTime> bn_ = context.Operators.Interval(bh_, bm_, true, true);
                bool? bo_ = context.Operators.In<CqlDateTime>(bc_, bn_, default);
                Code<ObservationStatus> bp_ = temperature?.StatusElement;
                ObservationStatus? bq_ = bp_?.Value;
                string br_ = context.Operators.Convert<string>(bq_);
                string[] bs_ = [
                    "final",
                    "amended",
                    "corrected",
                ];
                bool? bt_ = context.Operators.In<string>(br_, bs_ as IEnumerable<string>);
                bool? bu_ = context.Operators.And(bo_, bt_);
                DataType bv_ = temperature?.Value;
                CqlQuantity bw_ = FHIRHelpers_4_4_000.Instance.ToQuantity(context, bv_ as Quantity);
                bool? bx_ = context.Operators.Not((bool?)(bw_ is null));
                bool? by_ = context.Operators.And(bu_, bx_);

                return by_;
            };
            IEnumerable<Observation> q_ = context.Operators.Where<Observation>(g_, p_);
            object r_(Observation @this)
            {
                DataType bz_ = @this?.Effective;
                object ca_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bz_);
                CqlDateTime cb_ = QICoreCommon_2_1_000.Instance.earliest(context, ca_);

                return cb_;
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



    [CqlDeclaration("Encounter with First Heart Rate")]
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
                Period ab_ = EncounterInpatient?.Period;
                CqlInterval<CqlDateTime> ac_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ab_);
                CqlDateTime ad_ = context.Operators.Start(ac_);
                CqlQuantity ae_ = context.Operators.Quantity(1440m, "minutes");
                CqlDateTime af_ = context.Operators.Subtract(ad_, ae_);
                CqlInterval<CqlDateTime> ah_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ab_);
                CqlDateTime ai_ = context.Operators.Start(ah_);
                CqlQuantity aj_ = context.Operators.Quantity(120m, "minutes");
                CqlDateTime ak_ = context.Operators.Add(ai_, aj_);
                CqlInterval<CqlDateTime> al_ = context.Operators.Interval(af_, ak_, true, true);
                bool? am_ = context.Operators.In<CqlDateTime>(aa_, al_, default);
                Code<ObservationStatus> an_ = HeartRate?.StatusElement;
                ObservationStatus? ao_ = an_?.Value;
                string ap_ = context.Operators.Convert<string>(ao_);
                string[] aq_ = [
                    "final",
                    "amended",
                    "corrected",
                ];
                bool? ar_ = context.Operators.In<string>(ap_, aq_ as IEnumerable<string>);
                bool? as_ = context.Operators.And(am_, ar_);
                DataType at_ = HeartRate?.Value;
                CqlQuantity au_ = FHIRHelpers_4_4_000.Instance.ToQuantity(context, at_ as Quantity);
                bool? av_ = context.Operators.Not((bool?)(au_ is null));
                bool? aw_ = context.Operators.And(as_, av_);

                return aw_;
            };
            IEnumerable<Observation> i_ = context.Operators.Where<Observation>(g_, h_);
            object j_(Observation @this)
            {
                DataType ax_ = @this?.Effective;
                object ay_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ax_);
                CqlDateTime az_ = QICoreCommon_2_1_000.Instance.earliest(context, ay_);

                return az_;
            };
            IEnumerable<Observation> k_ = context.Operators.SortBy<Observation>(i_, j_, System.ComponentModel.ListSortDirection.Ascending);
            Observation l_ = context.Operators.First<Observation>(k_);
            DataType m_ = l_?.Value;
            CqlQuantity n_ = FHIRHelpers_4_4_000.Instance.ToQuantity(context, m_ as Quantity);
            bool? p_(Observation HeartRate)
            {
                DataType ba_ = HeartRate?.Effective;
                object bb_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ba_);
                CqlDateTime bc_ = QICoreCommon_2_1_000.Instance.earliest(context, bb_);
                Period bd_ = EncounterInpatient?.Period;
                CqlInterval<CqlDateTime> be_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, bd_);
                CqlDateTime bf_ = context.Operators.Start(be_);
                CqlQuantity bg_ = context.Operators.Quantity(1440m, "minutes");
                CqlDateTime bh_ = context.Operators.Subtract(bf_, bg_);
                CqlInterval<CqlDateTime> bj_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, bd_);
                CqlDateTime bk_ = context.Operators.Start(bj_);
                CqlQuantity bl_ = context.Operators.Quantity(120m, "minutes");
                CqlDateTime bm_ = context.Operators.Add(bk_, bl_);
                CqlInterval<CqlDateTime> bn_ = context.Operators.Interval(bh_, bm_, true, true);
                bool? bo_ = context.Operators.In<CqlDateTime>(bc_, bn_, default);
                Code<ObservationStatus> bp_ = HeartRate?.StatusElement;
                ObservationStatus? bq_ = bp_?.Value;
                string br_ = context.Operators.Convert<string>(bq_);
                string[] bs_ = [
                    "final",
                    "amended",
                    "corrected",
                ];
                bool? bt_ = context.Operators.In<string>(br_, bs_ as IEnumerable<string>);
                bool? bu_ = context.Operators.And(bo_, bt_);
                DataType bv_ = HeartRate?.Value;
                CqlQuantity bw_ = FHIRHelpers_4_4_000.Instance.ToQuantity(context, bv_ as Quantity);
                bool? bx_ = context.Operators.Not((bool?)(bw_ is null));
                bool? by_ = context.Operators.And(bu_, bx_);

                return by_;
            };
            IEnumerable<Observation> q_ = context.Operators.Where<Observation>(g_, p_);
            object r_(Observation @this)
            {
                DataType bz_ = @this?.Effective;
                object ca_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bz_);
                CqlDateTime cb_ = QICoreCommon_2_1_000.Instance.earliest(context, ca_);

                return cb_;
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



    [CqlDeclaration("Encounter with First Oxygen Saturation")]
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
                    bool ar_()
                    {
                        DataType au_ = O2Saturation?.Effective;
                        object av_ = FHIRHelpers_4_4_000.Instance.ToValue(context, au_);
                        bool aw_ = av_ is CqlDateTime;

                        return aw_;
                    };
                    bool as_()
                    {
                        DataType ax_ = O2Saturation?.Effective;
                        object ay_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ax_);
                        bool az_ = ay_ is CqlInterval<CqlDateTime>;

                        return az_;
                    };
                    bool at_()
                    {
                        DataType ba_ = O2Saturation?.Effective;
                        object bb_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ba_);
                        bool bc_ = bb_ is CqlDateTime;

                        return bc_;
                    };
                    if (ar_())
                    {
                        DataType bd_ = O2Saturation?.Effective;
                        object be_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bd_);

                        return (be_ as CqlDateTime) as object;
                    }
                    else if (as_())
                    {
                        DataType bf_ = O2Saturation?.Effective;
                        object bg_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bf_);

                        return (bg_ as CqlInterval<CqlDateTime>) as object;
                    }
                    else if (at_())
                    {
                        DataType bh_ = O2Saturation?.Effective;
                        object bi_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bh_);

                        return (bi_ as CqlDateTime) as object;
                    }
                    else
                    {
                        return null;
                    }
                };
                CqlDateTime t_ = QICoreCommon_2_1_000.Instance.earliest(context, s_());
                Period u_ = EncounterInpatient?.Period;
                CqlInterval<CqlDateTime> v_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, u_);
                CqlDateTime w_ = context.Operators.Start(v_);
                CqlQuantity x_ = context.Operators.Quantity(1440m, "minutes");
                CqlDateTime y_ = context.Operators.Subtract(w_, x_);
                CqlInterval<CqlDateTime> aa_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, u_);
                CqlDateTime ab_ = context.Operators.Start(aa_);
                CqlQuantity ac_ = context.Operators.Quantity(120m, "minutes");
                CqlDateTime ad_ = context.Operators.Add(ab_, ac_);
                CqlInterval<CqlDateTime> ae_ = context.Operators.Interval(y_, ad_, true, true);
                bool? af_ = context.Operators.In<CqlDateTime>(t_, ae_, default);
                Code<ObservationStatus> ag_ = O2Saturation?.StatusElement;
                ObservationStatus? ah_ = ag_?.Value;
                Code<ObservationStatus> ai_ = context.Operators.Convert<Code<ObservationStatus>>(ah_);
                string aj_ = context.Operators.Convert<string>(ai_);
                string[] ak_ = [
                    "final",
                    "amended",
                    "corrected",
                ];
                bool? al_ = context.Operators.In<string>(aj_, ak_ as IEnumerable<string>);
                bool? am_ = context.Operators.And(af_, al_);
                DataType an_ = O2Saturation?.Value;
                object ao_ = FHIRHelpers_4_4_000.Instance.ToValue(context, an_);
                bool? ap_ = context.Operators.Not((bool?)(ao_ is null));
                bool? aq_ = context.Operators.And(am_, ap_);

                return aq_;
            };
            IEnumerable<Observation> j_ = context.Operators.Where<Observation>(h_, i_);
            object k_(Observation @this)
            {
                object bj_()
                {
                    bool bl_()
                    {
                        DataType bo_ = @this?.Effective;
                        object bp_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bo_);
                        bool bq_ = bp_ is CqlDateTime;

                        return bq_;
                    };
                    bool bm_()
                    {
                        DataType br_ = @this?.Effective;
                        object bs_ = FHIRHelpers_4_4_000.Instance.ToValue(context, br_);
                        bool bt_ = bs_ is CqlInterval<CqlDateTime>;

                        return bt_;
                    };
                    bool bn_()
                    {
                        DataType bu_ = @this?.Effective;
                        object bv_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bu_);
                        bool bw_ = bv_ is CqlDateTime;

                        return bw_;
                    };
                    if (bl_())
                    {
                        DataType bx_ = @this?.Effective;
                        object by_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bx_);

                        return (by_ as CqlDateTime) as object;
                    }
                    else if (bm_())
                    {
                        DataType bz_ = @this?.Effective;
                        object ca_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bz_);

                        return (ca_ as CqlInterval<CqlDateTime>) as object;
                    }
                    else if (bn_())
                    {
                        DataType cb_ = @this?.Effective;
                        object cc_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cb_);

                        return (cc_ as CqlDateTime) as object;
                    }
                    else
                    {
                        return null;
                    }
                };
                CqlDateTime bk_ = QICoreCommon_2_1_000.Instance.earliest(context, bj_());

                return bk_;
            };
            IEnumerable<Observation> l_ = context.Operators.SortBy<Observation>(j_, k_, System.ComponentModel.ListSortDirection.Ascending);
            Observation m_ = context.Operators.First<Observation>(l_);
            DataType n_ = m_?.Value;
            object o_ = FHIRHelpers_4_4_000.Instance.ToValue(context, n_);
            object p_()
            {
                bool cd_()
                {
                    CqlValueSet cg_ = this.Oxygen_Saturation_by_Pulse_Oximetry(context);
                    IEnumerable<Observation> ch_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, cg_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
                    bool? ci_(Observation O2Saturation)
                    {
                        object cq_()
                        {
                            bool dp_()
                            {
                                DataType ds_ = O2Saturation?.Effective;
                                object dt_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ds_);
                                bool du_ = dt_ is CqlDateTime;

                                return du_;
                            };
                            bool dq_()
                            {
                                DataType dv_ = O2Saturation?.Effective;
                                object dw_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dv_);
                                bool dx_ = dw_ is CqlInterval<CqlDateTime>;

                                return dx_;
                            };
                            bool dr_()
                            {
                                DataType dy_ = O2Saturation?.Effective;
                                object dz_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dy_);
                                bool ea_ = dz_ is CqlDateTime;

                                return ea_;
                            };
                            if (dp_())
                            {
                                DataType eb_ = O2Saturation?.Effective;
                                object ec_ = FHIRHelpers_4_4_000.Instance.ToValue(context, eb_);

                                return (ec_ as CqlDateTime) as object;
                            }
                            else if (dq_())
                            {
                                DataType ed_ = O2Saturation?.Effective;
                                object ee_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ed_);

                                return (ee_ as CqlInterval<CqlDateTime>) as object;
                            }
                            else if (dr_())
                            {
                                DataType ef_ = O2Saturation?.Effective;
                                object eg_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ef_);

                                return (eg_ as CqlDateTime) as object;
                            }
                            else
                            {
                                return null;
                            }
                        };
                        CqlDateTime cr_ = QICoreCommon_2_1_000.Instance.earliest(context, cq_());
                        Period cs_ = EncounterInpatient?.Period;
                        CqlInterval<CqlDateTime> ct_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, cs_);
                        CqlDateTime cu_ = context.Operators.Start(ct_);
                        CqlQuantity cv_ = context.Operators.Quantity(1440m, "minutes");
                        CqlDateTime cw_ = context.Operators.Subtract(cu_, cv_);
                        CqlInterval<CqlDateTime> cy_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, cs_);
                        CqlDateTime cz_ = context.Operators.Start(cy_);
                        CqlQuantity da_ = context.Operators.Quantity(120m, "minutes");
                        CqlDateTime db_ = context.Operators.Add(cz_, da_);
                        CqlInterval<CqlDateTime> dc_ = context.Operators.Interval(cw_, db_, true, true);
                        bool? dd_ = context.Operators.In<CqlDateTime>(cr_, dc_, default);
                        Code<ObservationStatus> de_ = O2Saturation?.StatusElement;
                        ObservationStatus? df_ = de_?.Value;
                        Code<ObservationStatus> dg_ = context.Operators.Convert<Code<ObservationStatus>>(df_);
                        string dh_ = context.Operators.Convert<string>(dg_);
                        string[] di_ = [
                            "final",
                            "amended",
                            "corrected",
                        ];
                        bool? dj_ = context.Operators.In<string>(dh_, di_ as IEnumerable<string>);
                        bool? dk_ = context.Operators.And(dd_, dj_);
                        DataType dl_ = O2Saturation?.Value;
                        object dm_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dl_);
                        bool? dn_ = context.Operators.Not((bool?)(dm_ is null));
                        bool? do_ = context.Operators.And(dk_, dn_);

                        return do_;
                    };
                    IEnumerable<Observation> cj_ = context.Operators.Where<Observation>(ch_, ci_);
                    object ck_(Observation @this)
                    {
                        object eh_()
                        {
                            bool ej_()
                            {
                                DataType em_ = @this?.Effective;
                                object en_ = FHIRHelpers_4_4_000.Instance.ToValue(context, em_);
                                bool eo_ = en_ is CqlDateTime;

                                return eo_;
                            };
                            bool ek_()
                            {
                                DataType ep_ = @this?.Effective;
                                object eq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ep_);
                                bool er_ = eq_ is CqlInterval<CqlDateTime>;

                                return er_;
                            };
                            bool el_()
                            {
                                DataType es_ = @this?.Effective;
                                object et_ = FHIRHelpers_4_4_000.Instance.ToValue(context, es_);
                                bool eu_ = et_ is CqlDateTime;

                                return eu_;
                            };
                            if (ej_())
                            {
                                DataType ev_ = @this?.Effective;
                                object ew_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ev_);

                                return (ew_ as CqlDateTime) as object;
                            }
                            else if (ek_())
                            {
                                DataType ex_ = @this?.Effective;
                                object ey_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ex_);

                                return (ey_ as CqlInterval<CqlDateTime>) as object;
                            }
                            else if (el_())
                            {
                                DataType ez_ = @this?.Effective;
                                object fa_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ez_);

                                return (fa_ as CqlDateTime) as object;
                            }
                            else
                            {
                                return null;
                            }
                        };
                        CqlDateTime ei_ = QICoreCommon_2_1_000.Instance.earliest(context, eh_());

                        return ei_;
                    };
                    IEnumerable<Observation> cl_ = context.Operators.SortBy<Observation>(cj_, ck_, System.ComponentModel.ListSortDirection.Ascending);
                    Observation cm_ = context.Operators.First<Observation>(cl_);
                    DataType cn_ = cm_?.Effective;
                    object co_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cn_);
                    bool cp_ = co_ is CqlDateTime;

                    return cp_;
                };
                bool ce_()
                {
                    CqlValueSet fb_ = this.Oxygen_Saturation_by_Pulse_Oximetry(context);
                    IEnumerable<Observation> fc_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, fb_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
                    bool? fd_(Observation O2Saturation)
                    {
                        object fl_()
                        {
                            bool gk_()
                            {
                                DataType gn_ = O2Saturation?.Effective;
                                object go_ = FHIRHelpers_4_4_000.Instance.ToValue(context, gn_);
                                bool gp_ = go_ is CqlDateTime;

                                return gp_;
                            };
                            bool gl_()
                            {
                                DataType gq_ = O2Saturation?.Effective;
                                object gr_ = FHIRHelpers_4_4_000.Instance.ToValue(context, gq_);
                                bool gs_ = gr_ is CqlInterval<CqlDateTime>;

                                return gs_;
                            };
                            bool gm_()
                            {
                                DataType gt_ = O2Saturation?.Effective;
                                object gu_ = FHIRHelpers_4_4_000.Instance.ToValue(context, gt_);
                                bool gv_ = gu_ is CqlDateTime;

                                return gv_;
                            };
                            if (gk_())
                            {
                                DataType gw_ = O2Saturation?.Effective;
                                object gx_ = FHIRHelpers_4_4_000.Instance.ToValue(context, gw_);

                                return (gx_ as CqlDateTime) as object;
                            }
                            else if (gl_())
                            {
                                DataType gy_ = O2Saturation?.Effective;
                                object gz_ = FHIRHelpers_4_4_000.Instance.ToValue(context, gy_);

                                return (gz_ as CqlInterval<CqlDateTime>) as object;
                            }
                            else if (gm_())
                            {
                                DataType ha_ = O2Saturation?.Effective;
                                object hb_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ha_);

                                return (hb_ as CqlDateTime) as object;
                            }
                            else
                            {
                                return null;
                            }
                        };
                        CqlDateTime fm_ = QICoreCommon_2_1_000.Instance.earliest(context, fl_());
                        Period fn_ = EncounterInpatient?.Period;
                        CqlInterval<CqlDateTime> fo_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, fn_);
                        CqlDateTime fp_ = context.Operators.Start(fo_);
                        CqlQuantity fq_ = context.Operators.Quantity(1440m, "minutes");
                        CqlDateTime fr_ = context.Operators.Subtract(fp_, fq_);
                        CqlInterval<CqlDateTime> ft_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, fn_);
                        CqlDateTime fu_ = context.Operators.Start(ft_);
                        CqlQuantity fv_ = context.Operators.Quantity(120m, "minutes");
                        CqlDateTime fw_ = context.Operators.Add(fu_, fv_);
                        CqlInterval<CqlDateTime> fx_ = context.Operators.Interval(fr_, fw_, true, true);
                        bool? fy_ = context.Operators.In<CqlDateTime>(fm_, fx_, default);
                        Code<ObservationStatus> fz_ = O2Saturation?.StatusElement;
                        ObservationStatus? ga_ = fz_?.Value;
                        Code<ObservationStatus> gb_ = context.Operators.Convert<Code<ObservationStatus>>(ga_);
                        string gc_ = context.Operators.Convert<string>(gb_);
                        string[] gd_ = [
                            "final",
                            "amended",
                            "corrected",
                        ];
                        bool? ge_ = context.Operators.In<string>(gc_, gd_ as IEnumerable<string>);
                        bool? gf_ = context.Operators.And(fy_, ge_);
                        DataType gg_ = O2Saturation?.Value;
                        object gh_ = FHIRHelpers_4_4_000.Instance.ToValue(context, gg_);
                        bool? gi_ = context.Operators.Not((bool?)(gh_ is null));
                        bool? gj_ = context.Operators.And(gf_, gi_);

                        return gj_;
                    };
                    IEnumerable<Observation> fe_ = context.Operators.Where<Observation>(fc_, fd_);
                    object ff_(Observation @this)
                    {
                        object hc_()
                        {
                            bool he_()
                            {
                                DataType hh_ = @this?.Effective;
                                object hi_ = FHIRHelpers_4_4_000.Instance.ToValue(context, hh_);
                                bool hj_ = hi_ is CqlDateTime;

                                return hj_;
                            };
                            bool hf_()
                            {
                                DataType hk_ = @this?.Effective;
                                object hl_ = FHIRHelpers_4_4_000.Instance.ToValue(context, hk_);
                                bool hm_ = hl_ is CqlInterval<CqlDateTime>;

                                return hm_;
                            };
                            bool hg_()
                            {
                                DataType hn_ = @this?.Effective;
                                object ho_ = FHIRHelpers_4_4_000.Instance.ToValue(context, hn_);
                                bool hp_ = ho_ is CqlDateTime;

                                return hp_;
                            };
                            if (he_())
                            {
                                DataType hq_ = @this?.Effective;
                                object hr_ = FHIRHelpers_4_4_000.Instance.ToValue(context, hq_);

                                return (hr_ as CqlDateTime) as object;
                            }
                            else if (hf_())
                            {
                                DataType hs_ = @this?.Effective;
                                object ht_ = FHIRHelpers_4_4_000.Instance.ToValue(context, hs_);

                                return (ht_ as CqlInterval<CqlDateTime>) as object;
                            }
                            else if (hg_())
                            {
                                DataType hu_ = @this?.Effective;
                                object hv_ = FHIRHelpers_4_4_000.Instance.ToValue(context, hu_);

                                return (hv_ as CqlDateTime) as object;
                            }
                            else
                            {
                                return null;
                            }
                        };
                        CqlDateTime hd_ = QICoreCommon_2_1_000.Instance.earliest(context, hc_());

                        return hd_;
                    };
                    IEnumerable<Observation> fg_ = context.Operators.SortBy<Observation>(fe_, ff_, System.ComponentModel.ListSortDirection.Ascending);
                    Observation fh_ = context.Operators.First<Observation>(fg_);
                    DataType fi_ = fh_?.Effective;
                    object fj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fi_);
                    bool fk_ = fj_ is CqlInterval<CqlDateTime>;

                    return fk_;
                };
                bool cf_()
                {
                    CqlValueSet hw_ = this.Oxygen_Saturation_by_Pulse_Oximetry(context);
                    IEnumerable<Observation> hx_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, hw_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
                    bool? hy_(Observation O2Saturation)
                    {
                        object ig_()
                        {
                            bool jf_()
                            {
                                DataType ji_ = O2Saturation?.Effective;
                                object jj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ji_);
                                bool jk_ = jj_ is CqlDateTime;

                                return jk_;
                            };
                            bool jg_()
                            {
                                DataType jl_ = O2Saturation?.Effective;
                                object jm_ = FHIRHelpers_4_4_000.Instance.ToValue(context, jl_);
                                bool jn_ = jm_ is CqlInterval<CqlDateTime>;

                                return jn_;
                            };
                            bool jh_()
                            {
                                DataType jo_ = O2Saturation?.Effective;
                                object jp_ = FHIRHelpers_4_4_000.Instance.ToValue(context, jo_);
                                bool jq_ = jp_ is CqlDateTime;

                                return jq_;
                            };
                            if (jf_())
                            {
                                DataType jr_ = O2Saturation?.Effective;
                                object js_ = FHIRHelpers_4_4_000.Instance.ToValue(context, jr_);

                                return (js_ as CqlDateTime) as object;
                            }
                            else if (jg_())
                            {
                                DataType jt_ = O2Saturation?.Effective;
                                object ju_ = FHIRHelpers_4_4_000.Instance.ToValue(context, jt_);

                                return (ju_ as CqlInterval<CqlDateTime>) as object;
                            }
                            else if (jh_())
                            {
                                DataType jv_ = O2Saturation?.Effective;
                                object jw_ = FHIRHelpers_4_4_000.Instance.ToValue(context, jv_);

                                return (jw_ as CqlDateTime) as object;
                            }
                            else
                            {
                                return null;
                            }
                        };
                        CqlDateTime ih_ = QICoreCommon_2_1_000.Instance.earliest(context, ig_());
                        Period ii_ = EncounterInpatient?.Period;
                        CqlInterval<CqlDateTime> ij_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ii_);
                        CqlDateTime ik_ = context.Operators.Start(ij_);
                        CqlQuantity il_ = context.Operators.Quantity(1440m, "minutes");
                        CqlDateTime im_ = context.Operators.Subtract(ik_, il_);
                        CqlInterval<CqlDateTime> io_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ii_);
                        CqlDateTime ip_ = context.Operators.Start(io_);
                        CqlQuantity iq_ = context.Operators.Quantity(120m, "minutes");
                        CqlDateTime ir_ = context.Operators.Add(ip_, iq_);
                        CqlInterval<CqlDateTime> is_ = context.Operators.Interval(im_, ir_, true, true);
                        bool? it_ = context.Operators.In<CqlDateTime>(ih_, is_, default);
                        Code<ObservationStatus> iu_ = O2Saturation?.StatusElement;
                        ObservationStatus? iv_ = iu_?.Value;
                        Code<ObservationStatus> iw_ = context.Operators.Convert<Code<ObservationStatus>>(iv_);
                        string ix_ = context.Operators.Convert<string>(iw_);
                        string[] iy_ = [
                            "final",
                            "amended",
                            "corrected",
                        ];
                        bool? iz_ = context.Operators.In<string>(ix_, iy_ as IEnumerable<string>);
                        bool? ja_ = context.Operators.And(it_, iz_);
                        DataType jb_ = O2Saturation?.Value;
                        object jc_ = FHIRHelpers_4_4_000.Instance.ToValue(context, jb_);
                        bool? jd_ = context.Operators.Not((bool?)(jc_ is null));
                        bool? je_ = context.Operators.And(ja_, jd_);

                        return je_;
                    };
                    IEnumerable<Observation> hz_ = context.Operators.Where<Observation>(hx_, hy_);
                    object ia_(Observation @this)
                    {
                        object jx_()
                        {
                            bool jz_()
                            {
                                DataType kc_ = @this?.Effective;
                                object kd_ = FHIRHelpers_4_4_000.Instance.ToValue(context, kc_);
                                bool ke_ = kd_ is CqlDateTime;

                                return ke_;
                            };
                            bool ka_()
                            {
                                DataType kf_ = @this?.Effective;
                                object kg_ = FHIRHelpers_4_4_000.Instance.ToValue(context, kf_);
                                bool kh_ = kg_ is CqlInterval<CqlDateTime>;

                                return kh_;
                            };
                            bool kb_()
                            {
                                DataType ki_ = @this?.Effective;
                                object kj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ki_);
                                bool kk_ = kj_ is CqlDateTime;

                                return kk_;
                            };
                            if (jz_())
                            {
                                DataType kl_ = @this?.Effective;
                                object km_ = FHIRHelpers_4_4_000.Instance.ToValue(context, kl_);

                                return (km_ as CqlDateTime) as object;
                            }
                            else if (ka_())
                            {
                                DataType kn_ = @this?.Effective;
                                object ko_ = FHIRHelpers_4_4_000.Instance.ToValue(context, kn_);

                                return (ko_ as CqlInterval<CqlDateTime>) as object;
                            }
                            else if (kb_())
                            {
                                DataType kp_ = @this?.Effective;
                                object kq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, kp_);

                                return (kq_ as CqlDateTime) as object;
                            }
                            else
                            {
                                return null;
                            }
                        };
                        CqlDateTime jy_ = QICoreCommon_2_1_000.Instance.earliest(context, jx_());

                        return jy_;
                    };
                    IEnumerable<Observation> ib_ = context.Operators.SortBy<Observation>(hz_, ia_, System.ComponentModel.ListSortDirection.Ascending);
                    Observation ic_ = context.Operators.First<Observation>(ib_);
                    DataType id_ = ic_?.Effective;
                    object ie_ = FHIRHelpers_4_4_000.Instance.ToValue(context, id_);
                    bool if_ = ie_ is CqlDateTime;

                    return if_;
                };
                if (cd_())
                {
                    CqlValueSet kr_ = this.Oxygen_Saturation_by_Pulse_Oximetry(context);
                    IEnumerable<Observation> ks_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, kr_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
                    bool? kt_(Observation O2Saturation)
                    {
                        object la_()
                        {
                            bool lz_()
                            {
                                DataType mc_ = O2Saturation?.Effective;
                                object md_ = FHIRHelpers_4_4_000.Instance.ToValue(context, mc_);
                                bool me_ = md_ is CqlDateTime;

                                return me_;
                            };
                            bool ma_()
                            {
                                DataType mf_ = O2Saturation?.Effective;
                                object mg_ = FHIRHelpers_4_4_000.Instance.ToValue(context, mf_);
                                bool mh_ = mg_ is CqlInterval<CqlDateTime>;

                                return mh_;
                            };
                            bool mb_()
                            {
                                DataType mi_ = O2Saturation?.Effective;
                                object mj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, mi_);
                                bool mk_ = mj_ is CqlDateTime;

                                return mk_;
                            };
                            if (lz_())
                            {
                                DataType ml_ = O2Saturation?.Effective;
                                object mm_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ml_);

                                return (mm_ as CqlDateTime) as object;
                            }
                            else if (ma_())
                            {
                                DataType mn_ = O2Saturation?.Effective;
                                object mo_ = FHIRHelpers_4_4_000.Instance.ToValue(context, mn_);

                                return (mo_ as CqlInterval<CqlDateTime>) as object;
                            }
                            else if (mb_())
                            {
                                DataType mp_ = O2Saturation?.Effective;
                                object mq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, mp_);

                                return (mq_ as CqlDateTime) as object;
                            }
                            else
                            {
                                return null;
                            }
                        };
                        CqlDateTime lb_ = QICoreCommon_2_1_000.Instance.earliest(context, la_());
                        Period lc_ = EncounterInpatient?.Period;
                        CqlInterval<CqlDateTime> ld_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, lc_);
                        CqlDateTime le_ = context.Operators.Start(ld_);
                        CqlQuantity lf_ = context.Operators.Quantity(1440m, "minutes");
                        CqlDateTime lg_ = context.Operators.Subtract(le_, lf_);
                        CqlInterval<CqlDateTime> li_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, lc_);
                        CqlDateTime lj_ = context.Operators.Start(li_);
                        CqlQuantity lk_ = context.Operators.Quantity(120m, "minutes");
                        CqlDateTime ll_ = context.Operators.Add(lj_, lk_);
                        CqlInterval<CqlDateTime> lm_ = context.Operators.Interval(lg_, ll_, true, true);
                        bool? ln_ = context.Operators.In<CqlDateTime>(lb_, lm_, default);
                        Code<ObservationStatus> lo_ = O2Saturation?.StatusElement;
                        ObservationStatus? lp_ = lo_?.Value;
                        Code<ObservationStatus> lq_ = context.Operators.Convert<Code<ObservationStatus>>(lp_);
                        string lr_ = context.Operators.Convert<string>(lq_);
                        string[] ls_ = [
                            "final",
                            "amended",
                            "corrected",
                        ];
                        bool? lt_ = context.Operators.In<string>(lr_, ls_ as IEnumerable<string>);
                        bool? lu_ = context.Operators.And(ln_, lt_);
                        DataType lv_ = O2Saturation?.Value;
                        object lw_ = FHIRHelpers_4_4_000.Instance.ToValue(context, lv_);
                        bool? lx_ = context.Operators.Not((bool?)(lw_ is null));
                        bool? ly_ = context.Operators.And(lu_, lx_);

                        return ly_;
                    };
                    IEnumerable<Observation> ku_ = context.Operators.Where<Observation>(ks_, kt_);
                    object kv_(Observation @this)
                    {
                        object mr_()
                        {
                            bool mt_()
                            {
                                DataType mw_ = @this?.Effective;
                                object mx_ = FHIRHelpers_4_4_000.Instance.ToValue(context, mw_);
                                bool my_ = mx_ is CqlDateTime;

                                return my_;
                            };
                            bool mu_()
                            {
                                DataType mz_ = @this?.Effective;
                                object na_ = FHIRHelpers_4_4_000.Instance.ToValue(context, mz_);
                                bool nb_ = na_ is CqlInterval<CqlDateTime>;

                                return nb_;
                            };
                            bool mv_()
                            {
                                DataType nc_ = @this?.Effective;
                                object nd_ = FHIRHelpers_4_4_000.Instance.ToValue(context, nc_);
                                bool ne_ = nd_ is CqlDateTime;

                                return ne_;
                            };
                            if (mt_())
                            {
                                DataType nf_ = @this?.Effective;
                                object ng_ = FHIRHelpers_4_4_000.Instance.ToValue(context, nf_);

                                return (ng_ as CqlDateTime) as object;
                            }
                            else if (mu_())
                            {
                                DataType nh_ = @this?.Effective;
                                object ni_ = FHIRHelpers_4_4_000.Instance.ToValue(context, nh_);

                                return (ni_ as CqlInterval<CqlDateTime>) as object;
                            }
                            else if (mv_())
                            {
                                DataType nj_ = @this?.Effective;
                                object nk_ = FHIRHelpers_4_4_000.Instance.ToValue(context, nj_);

                                return (nk_ as CqlDateTime) as object;
                            }
                            else
                            {
                                return null;
                            }
                        };
                        CqlDateTime ms_ = QICoreCommon_2_1_000.Instance.earliest(context, mr_());

                        return ms_;
                    };
                    IEnumerable<Observation> kw_ = context.Operators.SortBy<Observation>(ku_, kv_, System.ComponentModel.ListSortDirection.Ascending);
                    Observation kx_ = context.Operators.First<Observation>(kw_);
                    DataType ky_ = kx_?.Effective;
                    object kz_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ky_);

                    return (kz_ as CqlDateTime) as object;
                }
                else if (ce_())
                {
                    CqlValueSet nl_ = this.Oxygen_Saturation_by_Pulse_Oximetry(context);
                    IEnumerable<Observation> nm_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, nl_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
                    bool? nn_(Observation O2Saturation)
                    {
                        object nu_()
                        {
                            bool ot_()
                            {
                                DataType ow_ = O2Saturation?.Effective;
                                object ox_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ow_);
                                bool oy_ = ox_ is CqlDateTime;

                                return oy_;
                            };
                            bool ou_()
                            {
                                DataType oz_ = O2Saturation?.Effective;
                                object pa_ = FHIRHelpers_4_4_000.Instance.ToValue(context, oz_);
                                bool pb_ = pa_ is CqlInterval<CqlDateTime>;

                                return pb_;
                            };
                            bool ov_()
                            {
                                DataType pc_ = O2Saturation?.Effective;
                                object pd_ = FHIRHelpers_4_4_000.Instance.ToValue(context, pc_);
                                bool pe_ = pd_ is CqlDateTime;

                                return pe_;
                            };
                            if (ot_())
                            {
                                DataType pf_ = O2Saturation?.Effective;
                                object pg_ = FHIRHelpers_4_4_000.Instance.ToValue(context, pf_);

                                return (pg_ as CqlDateTime) as object;
                            }
                            else if (ou_())
                            {
                                DataType ph_ = O2Saturation?.Effective;
                                object pi_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ph_);

                                return (pi_ as CqlInterval<CqlDateTime>) as object;
                            }
                            else if (ov_())
                            {
                                DataType pj_ = O2Saturation?.Effective;
                                object pk_ = FHIRHelpers_4_4_000.Instance.ToValue(context, pj_);

                                return (pk_ as CqlDateTime) as object;
                            }
                            else
                            {
                                return null;
                            }
                        };
                        CqlDateTime nv_ = QICoreCommon_2_1_000.Instance.earliest(context, nu_());
                        Period nw_ = EncounterInpatient?.Period;
                        CqlInterval<CqlDateTime> nx_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, nw_);
                        CqlDateTime ny_ = context.Operators.Start(nx_);
                        CqlQuantity nz_ = context.Operators.Quantity(1440m, "minutes");
                        CqlDateTime oa_ = context.Operators.Subtract(ny_, nz_);
                        CqlInterval<CqlDateTime> oc_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, nw_);
                        CqlDateTime od_ = context.Operators.Start(oc_);
                        CqlQuantity oe_ = context.Operators.Quantity(120m, "minutes");
                        CqlDateTime of_ = context.Operators.Add(od_, oe_);
                        CqlInterval<CqlDateTime> og_ = context.Operators.Interval(oa_, of_, true, true);
                        bool? oh_ = context.Operators.In<CqlDateTime>(nv_, og_, default);
                        Code<ObservationStatus> oi_ = O2Saturation?.StatusElement;
                        ObservationStatus? oj_ = oi_?.Value;
                        Code<ObservationStatus> ok_ = context.Operators.Convert<Code<ObservationStatus>>(oj_);
                        string ol_ = context.Operators.Convert<string>(ok_);
                        string[] om_ = [
                            "final",
                            "amended",
                            "corrected",
                        ];
                        bool? on_ = context.Operators.In<string>(ol_, om_ as IEnumerable<string>);
                        bool? oo_ = context.Operators.And(oh_, on_);
                        DataType op_ = O2Saturation?.Value;
                        object oq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, op_);
                        bool? or_ = context.Operators.Not((bool?)(oq_ is null));
                        bool? os_ = context.Operators.And(oo_, or_);

                        return os_;
                    };
                    IEnumerable<Observation> no_ = context.Operators.Where<Observation>(nm_, nn_);
                    object np_(Observation @this)
                    {
                        object pl_()
                        {
                            bool pn_()
                            {
                                DataType pq_ = @this?.Effective;
                                object pr_ = FHIRHelpers_4_4_000.Instance.ToValue(context, pq_);
                                bool ps_ = pr_ is CqlDateTime;

                                return ps_;
                            };
                            bool po_()
                            {
                                DataType pt_ = @this?.Effective;
                                object pu_ = FHIRHelpers_4_4_000.Instance.ToValue(context, pt_);
                                bool pv_ = pu_ is CqlInterval<CqlDateTime>;

                                return pv_;
                            };
                            bool pp_()
                            {
                                DataType pw_ = @this?.Effective;
                                object px_ = FHIRHelpers_4_4_000.Instance.ToValue(context, pw_);
                                bool py_ = px_ is CqlDateTime;

                                return py_;
                            };
                            if (pn_())
                            {
                                DataType pz_ = @this?.Effective;
                                object qa_ = FHIRHelpers_4_4_000.Instance.ToValue(context, pz_);

                                return (qa_ as CqlDateTime) as object;
                            }
                            else if (po_())
                            {
                                DataType qb_ = @this?.Effective;
                                object qc_ = FHIRHelpers_4_4_000.Instance.ToValue(context, qb_);

                                return (qc_ as CqlInterval<CqlDateTime>) as object;
                            }
                            else if (pp_())
                            {
                                DataType qd_ = @this?.Effective;
                                object qe_ = FHIRHelpers_4_4_000.Instance.ToValue(context, qd_);

                                return (qe_ as CqlDateTime) as object;
                            }
                            else
                            {
                                return null;
                            }
                        };
                        CqlDateTime pm_ = QICoreCommon_2_1_000.Instance.earliest(context, pl_());

                        return pm_;
                    };
                    IEnumerable<Observation> nq_ = context.Operators.SortBy<Observation>(no_, np_, System.ComponentModel.ListSortDirection.Ascending);
                    Observation nr_ = context.Operators.First<Observation>(nq_);
                    DataType ns_ = nr_?.Effective;
                    object nt_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ns_);

                    return (nt_ as CqlInterval<CqlDateTime>) as object;
                }
                else if (cf_())
                {
                    CqlValueSet qf_ = this.Oxygen_Saturation_by_Pulse_Oximetry(context);
                    IEnumerable<Observation> qg_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, qf_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
                    bool? qh_(Observation O2Saturation)
                    {
                        object qo_()
                        {
                            bool rn_()
                            {
                                DataType rq_ = O2Saturation?.Effective;
                                object rr_ = FHIRHelpers_4_4_000.Instance.ToValue(context, rq_);
                                bool rs_ = rr_ is CqlDateTime;

                                return rs_;
                            };
                            bool ro_()
                            {
                                DataType rt_ = O2Saturation?.Effective;
                                object ru_ = FHIRHelpers_4_4_000.Instance.ToValue(context, rt_);
                                bool rv_ = ru_ is CqlInterval<CqlDateTime>;

                                return rv_;
                            };
                            bool rp_()
                            {
                                DataType rw_ = O2Saturation?.Effective;
                                object rx_ = FHIRHelpers_4_4_000.Instance.ToValue(context, rw_);
                                bool ry_ = rx_ is CqlDateTime;

                                return ry_;
                            };
                            if (rn_())
                            {
                                DataType rz_ = O2Saturation?.Effective;
                                object sa_ = FHIRHelpers_4_4_000.Instance.ToValue(context, rz_);

                                return (sa_ as CqlDateTime) as object;
                            }
                            else if (ro_())
                            {
                                DataType sb_ = O2Saturation?.Effective;
                                object sc_ = FHIRHelpers_4_4_000.Instance.ToValue(context, sb_);

                                return (sc_ as CqlInterval<CqlDateTime>) as object;
                            }
                            else if (rp_())
                            {
                                DataType sd_ = O2Saturation?.Effective;
                                object se_ = FHIRHelpers_4_4_000.Instance.ToValue(context, sd_);

                                return (se_ as CqlDateTime) as object;
                            }
                            else
                            {
                                return null;
                            }
                        };
                        CqlDateTime qp_ = QICoreCommon_2_1_000.Instance.earliest(context, qo_());
                        Period qq_ = EncounterInpatient?.Period;
                        CqlInterval<CqlDateTime> qr_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, qq_);
                        CqlDateTime qs_ = context.Operators.Start(qr_);
                        CqlQuantity qt_ = context.Operators.Quantity(1440m, "minutes");
                        CqlDateTime qu_ = context.Operators.Subtract(qs_, qt_);
                        CqlInterval<CqlDateTime> qw_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, qq_);
                        CqlDateTime qx_ = context.Operators.Start(qw_);
                        CqlQuantity qy_ = context.Operators.Quantity(120m, "minutes");
                        CqlDateTime qz_ = context.Operators.Add(qx_, qy_);
                        CqlInterval<CqlDateTime> ra_ = context.Operators.Interval(qu_, qz_, true, true);
                        bool? rb_ = context.Operators.In<CqlDateTime>(qp_, ra_, default);
                        Code<ObservationStatus> rc_ = O2Saturation?.StatusElement;
                        ObservationStatus? rd_ = rc_?.Value;
                        Code<ObservationStatus> re_ = context.Operators.Convert<Code<ObservationStatus>>(rd_);
                        string rf_ = context.Operators.Convert<string>(re_);
                        string[] rg_ = [
                            "final",
                            "amended",
                            "corrected",
                        ];
                        bool? rh_ = context.Operators.In<string>(rf_, rg_ as IEnumerable<string>);
                        bool? ri_ = context.Operators.And(rb_, rh_);
                        DataType rj_ = O2Saturation?.Value;
                        object rk_ = FHIRHelpers_4_4_000.Instance.ToValue(context, rj_);
                        bool? rl_ = context.Operators.Not((bool?)(rk_ is null));
                        bool? rm_ = context.Operators.And(ri_, rl_);

                        return rm_;
                    };
                    IEnumerable<Observation> qi_ = context.Operators.Where<Observation>(qg_, qh_);
                    object qj_(Observation @this)
                    {
                        object sf_()
                        {
                            bool sh_()
                            {
                                DataType sk_ = @this?.Effective;
                                object sl_ = FHIRHelpers_4_4_000.Instance.ToValue(context, sk_);
                                bool sm_ = sl_ is CqlDateTime;

                                return sm_;
                            };
                            bool si_()
                            {
                                DataType sn_ = @this?.Effective;
                                object so_ = FHIRHelpers_4_4_000.Instance.ToValue(context, sn_);
                                bool sp_ = so_ is CqlInterval<CqlDateTime>;

                                return sp_;
                            };
                            bool sj_()
                            {
                                DataType sq_ = @this?.Effective;
                                object sr_ = FHIRHelpers_4_4_000.Instance.ToValue(context, sq_);
                                bool ss_ = sr_ is CqlDateTime;

                                return ss_;
                            };
                            if (sh_())
                            {
                                DataType st_ = @this?.Effective;
                                object su_ = FHIRHelpers_4_4_000.Instance.ToValue(context, st_);

                                return (su_ as CqlDateTime) as object;
                            }
                            else if (si_())
                            {
                                DataType sv_ = @this?.Effective;
                                object sw_ = FHIRHelpers_4_4_000.Instance.ToValue(context, sv_);

                                return (sw_ as CqlInterval<CqlDateTime>) as object;
                            }
                            else if (sj_())
                            {
                                DataType sx_ = @this?.Effective;
                                object sy_ = FHIRHelpers_4_4_000.Instance.ToValue(context, sx_);

                                return (sy_ as CqlDateTime) as object;
                            }
                            else
                            {
                                return null;
                            }
                        };
                        CqlDateTime sg_ = QICoreCommon_2_1_000.Instance.earliest(context, sf_());

                        return sg_;
                    };
                    IEnumerable<Observation> qk_ = context.Operators.SortBy<Observation>(qi_, qj_, System.ComponentModel.ListSortDirection.Ascending);
                    Observation ql_ = context.Operators.First<Observation>(qk_);
                    DataType qm_ = ql_?.Effective;
                    object qn_ = FHIRHelpers_4_4_000.Instance.ToValue(context, qm_);

                    return (qn_ as CqlDateTime) as object;
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



    [CqlDeclaration("Encounter with First Bicarbonate Lab Test")]
    public IEnumerable<(CqlTupleMetadata, string EncounterId, CqlQuantity FirstBicarbonateResult, CqlDateTime Timing)?> Encounter_with_First_Bicarbonate_Lab_Test(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Inpatient_Encounters(context);
        (CqlTupleMetadata, string EncounterId, CqlQuantity FirstBicarbonateResult, CqlDateTime Timing)? b_(Encounter EncounterInpatient)
        {
            Id e_ = EncounterInpatient?.IdElement;
            string f_ = e_?.Value;
            CqlValueSet g_ = this.Bicarbonate_lab_test(context);
            IEnumerable<Observation> h_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, g_, default, "http://hl7.org/fhir/us/core/StructureDefinition/us-core-observation-lab"));
            bool? i_(Observation BicarbonateLab)
            {
                Instant aa_ = BicarbonateLab?.IssuedElement;
                DateTimeOffset? ab_ = aa_?.Value;
                CqlDateTime ac_ = context.Operators.Convert<CqlDateTime>(ab_);
                CqlDateTime ad_ = QICoreCommon_2_1_000.Instance.earliest(context, ac_ as object);
                Period ae_ = EncounterInpatient?.Period;
                CqlInterval<CqlDateTime> af_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ae_);
                CqlDateTime ag_ = context.Operators.Start(af_);
                CqlQuantity ah_ = context.Operators.Quantity(1440m, "minutes");
                CqlDateTime ai_ = context.Operators.Subtract(ag_, ah_);
                CqlInterval<CqlDateTime> ak_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ae_);
                CqlDateTime al_ = context.Operators.Start(ak_);
                CqlDateTime an_ = context.Operators.Add(al_, ah_);
                CqlInterval<CqlDateTime> ao_ = context.Operators.Interval(ai_, an_, true, true);
                bool? ap_ = context.Operators.In<CqlDateTime>(ad_, ao_, default);
                Code<ObservationStatus> aq_ = BicarbonateLab?.StatusElement;
                ObservationStatus? ar_ = aq_?.Value;
                string as_ = context.Operators.Convert<string>(ar_);
                string[] at_ = [
                    "final",
                    "amended",
                    "corrected",
                ];
                bool? au_ = context.Operators.In<string>(as_, at_ as IEnumerable<string>);
                bool? av_ = context.Operators.And(ap_, au_);
                DataType aw_ = BicarbonateLab?.Value;
                object ax_ = FHIRHelpers_4_4_000.Instance.ToValue(context, aw_);
                bool? ay_ = context.Operators.Not((bool?)(ax_ is null));
                bool? az_ = context.Operators.And(av_, ay_);

                return az_;
            };
            IEnumerable<Observation> j_ = context.Operators.Where<Observation>(h_, i_);
            object k_(Observation @this)
            {
                Instant ba_ = @this?.IssuedElement;
                DateTimeOffset? bb_ = ba_?.Value;
                CqlDateTime bc_ = context.Operators.Convert<CqlDateTime>(bb_);
                CqlDateTime bd_ = QICoreCommon_2_1_000.Instance.earliest(context, bc_ as object);

                return bd_;
            };
            IEnumerable<Observation> l_ = context.Operators.SortBy<Observation>(j_, k_, System.ComponentModel.ListSortDirection.Ascending);
            Observation m_ = context.Operators.First<Observation>(l_);
            DataType n_ = m_?.Value;
            object o_ = FHIRHelpers_4_4_000.Instance.ToValue(context, n_);
            IEnumerable<Observation> q_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, g_, default, "http://hl7.org/fhir/us/core/StructureDefinition/us-core-observation-lab"));
            bool? r_(Observation BicarbonateLab)
            {
                Instant be_ = BicarbonateLab?.IssuedElement;
                DateTimeOffset? bf_ = be_?.Value;
                CqlDateTime bg_ = context.Operators.Convert<CqlDateTime>(bf_);
                CqlDateTime bh_ = QICoreCommon_2_1_000.Instance.earliest(context, bg_ as object);
                Period bi_ = EncounterInpatient?.Period;
                CqlInterval<CqlDateTime> bj_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, bi_);
                CqlDateTime bk_ = context.Operators.Start(bj_);
                CqlQuantity bl_ = context.Operators.Quantity(1440m, "minutes");
                CqlDateTime bm_ = context.Operators.Subtract(bk_, bl_);
                CqlInterval<CqlDateTime> bo_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, bi_);
                CqlDateTime bp_ = context.Operators.Start(bo_);
                CqlDateTime br_ = context.Operators.Add(bp_, bl_);
                CqlInterval<CqlDateTime> bs_ = context.Operators.Interval(bm_, br_, true, true);
                bool? bt_ = context.Operators.In<CqlDateTime>(bh_, bs_, default);
                Code<ObservationStatus> bu_ = BicarbonateLab?.StatusElement;
                ObservationStatus? bv_ = bu_?.Value;
                string bw_ = context.Operators.Convert<string>(bv_);
                string[] bx_ = [
                    "final",
                    "amended",
                    "corrected",
                ];
                bool? by_ = context.Operators.In<string>(bw_, bx_ as IEnumerable<string>);
                bool? bz_ = context.Operators.And(bt_, by_);
                DataType ca_ = BicarbonateLab?.Value;
                object cb_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ca_);
                bool? cc_ = context.Operators.Not((bool?)(cb_ is null));
                bool? cd_ = context.Operators.And(bz_, cc_);

                return cd_;
            };
            IEnumerable<Observation> s_ = context.Operators.Where<Observation>(q_, r_);
            object t_(Observation @this)
            {
                Instant ce_ = @this?.IssuedElement;
                DateTimeOffset? cf_ = ce_?.Value;
                CqlDateTime cg_ = context.Operators.Convert<CqlDateTime>(cf_);
                CqlDateTime ch_ = QICoreCommon_2_1_000.Instance.earliest(context, cg_ as object);

                return ch_;
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



    [CqlDeclaration("Encounter with First Creatinine Lab Test")]
    public IEnumerable<(CqlTupleMetadata, string EncounterId, CqlQuantity FirstCreatinineResult, CqlDateTime Timing)?> Encounter_with_First_Creatinine_Lab_Test(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Inpatient_Encounters(context);
        (CqlTupleMetadata, string EncounterId, CqlQuantity FirstCreatinineResult, CqlDateTime Timing)? b_(Encounter EncounterInpatient)
        {
            Id e_ = EncounterInpatient?.IdElement;
            string f_ = e_?.Value;
            CqlValueSet g_ = this.Creatinine_lab_test(context);
            IEnumerable<Observation> h_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, g_, default, "http://hl7.org/fhir/us/core/StructureDefinition/us-core-observation-lab"));
            bool? i_(Observation CreatinineLab)
            {
                Instant aa_ = CreatinineLab?.IssuedElement;
                DateTimeOffset? ab_ = aa_?.Value;
                CqlDateTime ac_ = context.Operators.Convert<CqlDateTime>(ab_);
                CqlDateTime ad_ = QICoreCommon_2_1_000.Instance.earliest(context, ac_ as object);
                Period ae_ = EncounterInpatient?.Period;
                CqlInterval<CqlDateTime> af_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ae_);
                CqlDateTime ag_ = context.Operators.Start(af_);
                CqlQuantity ah_ = context.Operators.Quantity(1440m, "minutes");
                CqlDateTime ai_ = context.Operators.Subtract(ag_, ah_);
                CqlInterval<CqlDateTime> ak_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ae_);
                CqlDateTime al_ = context.Operators.Start(ak_);
                CqlDateTime an_ = context.Operators.Add(al_, ah_);
                CqlInterval<CqlDateTime> ao_ = context.Operators.Interval(ai_, an_, true, true);
                bool? ap_ = context.Operators.In<CqlDateTime>(ad_, ao_, default);
                Code<ObservationStatus> aq_ = CreatinineLab?.StatusElement;
                ObservationStatus? ar_ = aq_?.Value;
                string as_ = context.Operators.Convert<string>(ar_);
                string[] at_ = [
                    "final",
                    "amended",
                    "corrected",
                ];
                bool? au_ = context.Operators.In<string>(as_, at_ as IEnumerable<string>);
                bool? av_ = context.Operators.And(ap_, au_);
                DataType aw_ = CreatinineLab?.Value;
                object ax_ = FHIRHelpers_4_4_000.Instance.ToValue(context, aw_);
                bool? ay_ = context.Operators.Not((bool?)(ax_ is null));
                bool? az_ = context.Operators.And(av_, ay_);

                return az_;
            };
            IEnumerable<Observation> j_ = context.Operators.Where<Observation>(h_, i_);
            object k_(Observation @this)
            {
                Instant ba_ = @this?.IssuedElement;
                DateTimeOffset? bb_ = ba_?.Value;
                CqlDateTime bc_ = context.Operators.Convert<CqlDateTime>(bb_);
                CqlDateTime bd_ = QICoreCommon_2_1_000.Instance.earliest(context, bc_ as object);

                return bd_;
            };
            IEnumerable<Observation> l_ = context.Operators.SortBy<Observation>(j_, k_, System.ComponentModel.ListSortDirection.Ascending);
            Observation m_ = context.Operators.First<Observation>(l_);
            DataType n_ = m_?.Value;
            object o_ = FHIRHelpers_4_4_000.Instance.ToValue(context, n_);
            IEnumerable<Observation> q_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, g_, default, "http://hl7.org/fhir/us/core/StructureDefinition/us-core-observation-lab"));
            bool? r_(Observation CreatinineLab)
            {
                Instant be_ = CreatinineLab?.IssuedElement;
                DateTimeOffset? bf_ = be_?.Value;
                CqlDateTime bg_ = context.Operators.Convert<CqlDateTime>(bf_);
                CqlDateTime bh_ = QICoreCommon_2_1_000.Instance.earliest(context, bg_ as object);
                Period bi_ = EncounterInpatient?.Period;
                CqlInterval<CqlDateTime> bj_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, bi_);
                CqlDateTime bk_ = context.Operators.Start(bj_);
                CqlQuantity bl_ = context.Operators.Quantity(1440m, "minutes");
                CqlDateTime bm_ = context.Operators.Subtract(bk_, bl_);
                CqlInterval<CqlDateTime> bo_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, bi_);
                CqlDateTime bp_ = context.Operators.Start(bo_);
                CqlDateTime br_ = context.Operators.Add(bp_, bl_);
                CqlInterval<CqlDateTime> bs_ = context.Operators.Interval(bm_, br_, true, true);
                bool? bt_ = context.Operators.In<CqlDateTime>(bh_, bs_, default);
                Code<ObservationStatus> bu_ = CreatinineLab?.StatusElement;
                ObservationStatus? bv_ = bu_?.Value;
                string bw_ = context.Operators.Convert<string>(bv_);
                string[] bx_ = [
                    "final",
                    "amended",
                    "corrected",
                ];
                bool? by_ = context.Operators.In<string>(bw_, bx_ as IEnumerable<string>);
                bool? bz_ = context.Operators.And(bt_, by_);
                DataType ca_ = CreatinineLab?.Value;
                object cb_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ca_);
                bool? cc_ = context.Operators.Not((bool?)(cb_ is null));
                bool? cd_ = context.Operators.And(bz_, cc_);

                return cd_;
            };
            IEnumerable<Observation> s_ = context.Operators.Where<Observation>(q_, r_);
            object t_(Observation @this)
            {
                Instant ce_ = @this?.IssuedElement;
                DateTimeOffset? cf_ = ce_?.Value;
                CqlDateTime cg_ = context.Operators.Convert<CqlDateTime>(cf_);
                CqlDateTime ch_ = QICoreCommon_2_1_000.Instance.earliest(context, cg_ as object);

                return ch_;
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



    [CqlDeclaration("Encounter with First Hematocrit Lab Test")]
    public IEnumerable<(CqlTupleMetadata, string EncounterId, CqlQuantity FirstHematocritResult, CqlDateTime Timing)?> Encounter_with_First_Hematocrit_Lab_Test(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Inpatient_Encounters(context);
        (CqlTupleMetadata, string EncounterId, CqlQuantity FirstHematocritResult, CqlDateTime Timing)? b_(Encounter EncounterInpatient)
        {
            Id e_ = EncounterInpatient?.IdElement;
            string f_ = e_?.Value;
            CqlValueSet g_ = this.Hematocrit_lab_test(context);
            IEnumerable<Observation> h_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, g_, default, "http://hl7.org/fhir/us/core/StructureDefinition/us-core-observation-lab"));
            bool? i_(Observation HematocritLab)
            {
                Instant aa_ = HematocritLab?.IssuedElement;
                DateTimeOffset? ab_ = aa_?.Value;
                CqlDateTime ac_ = context.Operators.Convert<CqlDateTime>(ab_);
                CqlDateTime ad_ = QICoreCommon_2_1_000.Instance.earliest(context, ac_ as object);
                Period ae_ = EncounterInpatient?.Period;
                CqlInterval<CqlDateTime> af_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ae_);
                CqlDateTime ag_ = context.Operators.Start(af_);
                CqlQuantity ah_ = context.Operators.Quantity(1440m, "minutes");
                CqlDateTime ai_ = context.Operators.Subtract(ag_, ah_);
                CqlInterval<CqlDateTime> ak_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ae_);
                CqlDateTime al_ = context.Operators.Start(ak_);
                CqlDateTime an_ = context.Operators.Add(al_, ah_);
                CqlInterval<CqlDateTime> ao_ = context.Operators.Interval(ai_, an_, true, true);
                bool? ap_ = context.Operators.In<CqlDateTime>(ad_, ao_, default);
                Code<ObservationStatus> aq_ = HematocritLab?.StatusElement;
                ObservationStatus? ar_ = aq_?.Value;
                string as_ = context.Operators.Convert<string>(ar_);
                string[] at_ = [
                    "final",
                    "amended",
                    "corrected",
                ];
                bool? au_ = context.Operators.In<string>(as_, at_ as IEnumerable<string>);
                bool? av_ = context.Operators.And(ap_, au_);
                DataType aw_ = HematocritLab?.Value;
                object ax_ = FHIRHelpers_4_4_000.Instance.ToValue(context, aw_);
                bool? ay_ = context.Operators.Not((bool?)(ax_ is null));
                bool? az_ = context.Operators.And(av_, ay_);

                return az_;
            };
            IEnumerable<Observation> j_ = context.Operators.Where<Observation>(h_, i_);
            object k_(Observation @this)
            {
                Instant ba_ = @this?.IssuedElement;
                DateTimeOffset? bb_ = ba_?.Value;
                CqlDateTime bc_ = context.Operators.Convert<CqlDateTime>(bb_);
                CqlDateTime bd_ = QICoreCommon_2_1_000.Instance.earliest(context, bc_ as object);

                return bd_;
            };
            IEnumerable<Observation> l_ = context.Operators.SortBy<Observation>(j_, k_, System.ComponentModel.ListSortDirection.Ascending);
            Observation m_ = context.Operators.First<Observation>(l_);
            DataType n_ = m_?.Value;
            object o_ = FHIRHelpers_4_4_000.Instance.ToValue(context, n_);
            IEnumerable<Observation> q_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, g_, default, "http://hl7.org/fhir/us/core/StructureDefinition/us-core-observation-lab"));
            bool? r_(Observation HematocritLab)
            {
                Instant be_ = HematocritLab?.IssuedElement;
                DateTimeOffset? bf_ = be_?.Value;
                CqlDateTime bg_ = context.Operators.Convert<CqlDateTime>(bf_);
                CqlDateTime bh_ = QICoreCommon_2_1_000.Instance.earliest(context, bg_ as object);
                Period bi_ = EncounterInpatient?.Period;
                CqlInterval<CqlDateTime> bj_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, bi_);
                CqlDateTime bk_ = context.Operators.Start(bj_);
                CqlQuantity bl_ = context.Operators.Quantity(1440m, "minutes");
                CqlDateTime bm_ = context.Operators.Subtract(bk_, bl_);
                CqlInterval<CqlDateTime> bo_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, bi_);
                CqlDateTime bp_ = context.Operators.Start(bo_);
                CqlDateTime br_ = context.Operators.Add(bp_, bl_);
                CqlInterval<CqlDateTime> bs_ = context.Operators.Interval(bm_, br_, true, true);
                bool? bt_ = context.Operators.In<CqlDateTime>(bh_, bs_, default);
                Code<ObservationStatus> bu_ = HematocritLab?.StatusElement;
                ObservationStatus? bv_ = bu_?.Value;
                string bw_ = context.Operators.Convert<string>(bv_);
                string[] bx_ = [
                    "final",
                    "amended",
                    "corrected",
                ];
                bool? by_ = context.Operators.In<string>(bw_, bx_ as IEnumerable<string>);
                bool? bz_ = context.Operators.And(bt_, by_);
                DataType ca_ = HematocritLab?.Value;
                object cb_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ca_);
                bool? cc_ = context.Operators.Not((bool?)(cb_ is null));
                bool? cd_ = context.Operators.And(bz_, cc_);

                return cd_;
            };
            IEnumerable<Observation> s_ = context.Operators.Where<Observation>(q_, r_);
            object t_(Observation @this)
            {
                Instant ce_ = @this?.IssuedElement;
                DateTimeOffset? cf_ = ce_?.Value;
                CqlDateTime cg_ = context.Operators.Convert<CqlDateTime>(cf_);
                CqlDateTime ch_ = QICoreCommon_2_1_000.Instance.earliest(context, cg_ as object);

                return ch_;
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



    [CqlDeclaration("Encounter with First Platelet Lab Test")]
    public IEnumerable<(CqlTupleMetadata, string EncounterId, CqlQuantity FirstPlateletResult, CqlDateTime Timing)?> Encounter_with_First_Platelet_Lab_Test(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Inpatient_Encounters(context);
        (CqlTupleMetadata, string EncounterId, CqlQuantity FirstPlateletResult, CqlDateTime Timing)? b_(Encounter EncounterInpatient)
        {
            Id e_ = EncounterInpatient?.IdElement;
            string f_ = e_?.Value;
            CqlValueSet g_ = this.Platelet_count_lab_test(context);
            IEnumerable<Observation> h_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, g_, default, "http://hl7.org/fhir/us/core/StructureDefinition/us-core-observation-lab"));
            bool? i_(Observation PlateletLab)
            {
                Instant aa_ = PlateletLab?.IssuedElement;
                DateTimeOffset? ab_ = aa_?.Value;
                CqlDateTime ac_ = context.Operators.Convert<CqlDateTime>(ab_);
                CqlDateTime ad_ = QICoreCommon_2_1_000.Instance.earliest(context, ac_ as object);
                Period ae_ = EncounterInpatient?.Period;
                CqlInterval<CqlDateTime> af_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ae_);
                CqlDateTime ag_ = context.Operators.Start(af_);
                CqlQuantity ah_ = context.Operators.Quantity(1440m, "minutes");
                CqlDateTime ai_ = context.Operators.Subtract(ag_, ah_);
                CqlInterval<CqlDateTime> ak_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ae_);
                CqlDateTime al_ = context.Operators.Start(ak_);
                CqlDateTime an_ = context.Operators.Add(al_, ah_);
                CqlInterval<CqlDateTime> ao_ = context.Operators.Interval(ai_, an_, true, true);
                bool? ap_ = context.Operators.In<CqlDateTime>(ad_, ao_, default);
                Code<ObservationStatus> aq_ = PlateletLab?.StatusElement;
                ObservationStatus? ar_ = aq_?.Value;
                string as_ = context.Operators.Convert<string>(ar_);
                string[] at_ = [
                    "final",
                    "amended",
                    "corrected",
                ];
                bool? au_ = context.Operators.In<string>(as_, at_ as IEnumerable<string>);
                bool? av_ = context.Operators.And(ap_, au_);
                DataType aw_ = PlateletLab?.Value;
                object ax_ = FHIRHelpers_4_4_000.Instance.ToValue(context, aw_);
                bool? ay_ = context.Operators.Not((bool?)(ax_ is null));
                bool? az_ = context.Operators.And(av_, ay_);

                return az_;
            };
            IEnumerable<Observation> j_ = context.Operators.Where<Observation>(h_, i_);
            object k_(Observation @this)
            {
                Instant ba_ = @this?.IssuedElement;
                DateTimeOffset? bb_ = ba_?.Value;
                CqlDateTime bc_ = context.Operators.Convert<CqlDateTime>(bb_);
                CqlDateTime bd_ = QICoreCommon_2_1_000.Instance.earliest(context, bc_ as object);

                return bd_;
            };
            IEnumerable<Observation> l_ = context.Operators.SortBy<Observation>(j_, k_, System.ComponentModel.ListSortDirection.Ascending);
            Observation m_ = context.Operators.First<Observation>(l_);
            DataType n_ = m_?.Value;
            object o_ = FHIRHelpers_4_4_000.Instance.ToValue(context, n_);
            IEnumerable<Observation> q_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, g_, default, "http://hl7.org/fhir/us/core/StructureDefinition/us-core-observation-lab"));
            bool? r_(Observation PlateletLab)
            {
                Instant be_ = PlateletLab?.IssuedElement;
                DateTimeOffset? bf_ = be_?.Value;
                CqlDateTime bg_ = context.Operators.Convert<CqlDateTime>(bf_);
                CqlDateTime bh_ = QICoreCommon_2_1_000.Instance.earliest(context, bg_ as object);
                Period bi_ = EncounterInpatient?.Period;
                CqlInterval<CqlDateTime> bj_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, bi_);
                CqlDateTime bk_ = context.Operators.Start(bj_);
                CqlQuantity bl_ = context.Operators.Quantity(1440m, "minutes");
                CqlDateTime bm_ = context.Operators.Subtract(bk_, bl_);
                CqlInterval<CqlDateTime> bo_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, bi_);
                CqlDateTime bp_ = context.Operators.Start(bo_);
                CqlDateTime br_ = context.Operators.Add(bp_, bl_);
                CqlInterval<CqlDateTime> bs_ = context.Operators.Interval(bm_, br_, true, true);
                bool? bt_ = context.Operators.In<CqlDateTime>(bh_, bs_, default);
                Code<ObservationStatus> bu_ = PlateletLab?.StatusElement;
                ObservationStatus? bv_ = bu_?.Value;
                string bw_ = context.Operators.Convert<string>(bv_);
                string[] bx_ = [
                    "final",
                    "amended",
                    "corrected",
                ];
                bool? by_ = context.Operators.In<string>(bw_, bx_ as IEnumerable<string>);
                bool? bz_ = context.Operators.And(bt_, by_);
                DataType ca_ = PlateletLab?.Value;
                object cb_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ca_);
                bool? cc_ = context.Operators.Not((bool?)(cb_ is null));
                bool? cd_ = context.Operators.And(bz_, cc_);

                return cd_;
            };
            IEnumerable<Observation> s_ = context.Operators.Where<Observation>(q_, r_);
            object t_(Observation @this)
            {
                Instant ce_ = @this?.IssuedElement;
                DateTimeOffset? cf_ = ce_?.Value;
                CqlDateTime cg_ = context.Operators.Convert<CqlDateTime>(cf_);
                CqlDateTime ch_ = QICoreCommon_2_1_000.Instance.earliest(context, cg_ as object);

                return ch_;
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



    [CqlDeclaration("Encounter with First Sodium Lab Test")]
    public IEnumerable<(CqlTupleMetadata, string EncounterId, CqlQuantity FirstSodiumResult, CqlDateTime Timing)?> Encounter_with_First_Sodium_Lab_Test(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Inpatient_Encounters(context);
        (CqlTupleMetadata, string EncounterId, CqlQuantity FirstSodiumResult, CqlDateTime Timing)? b_(Encounter EncounterInpatient)
        {
            Id e_ = EncounterInpatient?.IdElement;
            string f_ = e_?.Value;
            CqlValueSet g_ = this.Sodium_lab_test(context);
            IEnumerable<Observation> h_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, g_, default, "http://hl7.org/fhir/us/core/StructureDefinition/us-core-observation-lab"));
            bool? i_(Observation SodiumLab)
            {
                Instant aa_ = SodiumLab?.IssuedElement;
                DateTimeOffset? ab_ = aa_?.Value;
                CqlDateTime ac_ = context.Operators.Convert<CqlDateTime>(ab_);
                CqlDateTime ad_ = QICoreCommon_2_1_000.Instance.earliest(context, ac_ as object);
                Period ae_ = EncounterInpatient?.Period;
                CqlInterval<CqlDateTime> af_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ae_);
                CqlDateTime ag_ = context.Operators.Start(af_);
                CqlQuantity ah_ = context.Operators.Quantity(1440m, "minutes");
                CqlDateTime ai_ = context.Operators.Subtract(ag_, ah_);
                CqlInterval<CqlDateTime> ak_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ae_);
                CqlDateTime al_ = context.Operators.Start(ak_);
                CqlDateTime an_ = context.Operators.Add(al_, ah_);
                CqlInterval<CqlDateTime> ao_ = context.Operators.Interval(ai_, an_, true, true);
                bool? ap_ = context.Operators.In<CqlDateTime>(ad_, ao_, default);
                Code<ObservationStatus> aq_ = SodiumLab?.StatusElement;
                ObservationStatus? ar_ = aq_?.Value;
                string as_ = context.Operators.Convert<string>(ar_);
                string[] at_ = [
                    "final",
                    "amended",
                    "corrected",
                ];
                bool? au_ = context.Operators.In<string>(as_, at_ as IEnumerable<string>);
                bool? av_ = context.Operators.And(ap_, au_);
                DataType aw_ = SodiumLab?.Value;
                object ax_ = FHIRHelpers_4_4_000.Instance.ToValue(context, aw_);
                bool? ay_ = context.Operators.Not((bool?)(ax_ is null));
                bool? az_ = context.Operators.And(av_, ay_);

                return az_;
            };
            IEnumerable<Observation> j_ = context.Operators.Where<Observation>(h_, i_);
            object k_(Observation @this)
            {
                Instant ba_ = @this?.IssuedElement;
                DateTimeOffset? bb_ = ba_?.Value;
                CqlDateTime bc_ = context.Operators.Convert<CqlDateTime>(bb_);
                CqlDateTime bd_ = QICoreCommon_2_1_000.Instance.earliest(context, bc_ as object);

                return bd_;
            };
            IEnumerable<Observation> l_ = context.Operators.SortBy<Observation>(j_, k_, System.ComponentModel.ListSortDirection.Ascending);
            Observation m_ = context.Operators.First<Observation>(l_);
            DataType n_ = m_?.Value;
            object o_ = FHIRHelpers_4_4_000.Instance.ToValue(context, n_);
            IEnumerable<Observation> q_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, g_, default, "http://hl7.org/fhir/us/core/StructureDefinition/us-core-observation-lab"));
            bool? r_(Observation SodiumLab)
            {
                Instant be_ = SodiumLab?.IssuedElement;
                DateTimeOffset? bf_ = be_?.Value;
                CqlDateTime bg_ = context.Operators.Convert<CqlDateTime>(bf_);
                CqlDateTime bh_ = QICoreCommon_2_1_000.Instance.earliest(context, bg_ as object);
                Period bi_ = EncounterInpatient?.Period;
                CqlInterval<CqlDateTime> bj_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, bi_);
                CqlDateTime bk_ = context.Operators.Start(bj_);
                CqlQuantity bl_ = context.Operators.Quantity(1440m, "minutes");
                CqlDateTime bm_ = context.Operators.Subtract(bk_, bl_);
                CqlInterval<CqlDateTime> bo_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, bi_);
                CqlDateTime bp_ = context.Operators.Start(bo_);
                CqlDateTime br_ = context.Operators.Add(bp_, bl_);
                CqlInterval<CqlDateTime> bs_ = context.Operators.Interval(bm_, br_, true, true);
                bool? bt_ = context.Operators.In<CqlDateTime>(bh_, bs_, default);
                Code<ObservationStatus> bu_ = SodiumLab?.StatusElement;
                ObservationStatus? bv_ = bu_?.Value;
                string bw_ = context.Operators.Convert<string>(bv_);
                string[] bx_ = [
                    "final",
                    "amended",
                    "corrected",
                ];
                bool? by_ = context.Operators.In<string>(bw_, bx_ as IEnumerable<string>);
                bool? bz_ = context.Operators.And(bt_, by_);
                DataType ca_ = SodiumLab?.Value;
                object cb_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ca_);
                bool? cc_ = context.Operators.Not((bool?)(cb_ is null));
                bool? cd_ = context.Operators.And(bz_, cc_);

                return cd_;
            };
            IEnumerable<Observation> s_ = context.Operators.Where<Observation>(q_, r_);
            object t_(Observation @this)
            {
                Instant ce_ = @this?.IssuedElement;
                DateTimeOffset? cf_ = ce_?.Value;
                CqlDateTime cg_ = context.Operators.Convert<CqlDateTime>(cf_);
                CqlDateTime ch_ = QICoreCommon_2_1_000.Instance.earliest(context, cg_ as object);

                return ch_;
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



    [CqlDeclaration("Qualifying Blood Pressure Reading")]
    public IEnumerable<Observation> Qualifying_Blood_Pressure_Reading(CqlContext context)
    {
        IEnumerable<Observation> a_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/StructureDefinition/bp"));
        bool? b_(Observation BPReading)
        {
            DataType d_ = BPReading?.Effective;
            object e_ = FHIRHelpers_4_4_000.Instance.ToValue(context, d_);
            CqlDateTime f_ = QICoreCommon_2_1_000.Instance.earliest(context, e_);
            CqlInterval<CqlDateTime> g_ = this.Measurement_Period(context);
            bool? h_ = context.Operators.In<CqlDateTime>(f_, g_, "day");
            Code<ObservationStatus> i_ = BPReading?.StatusElement;
            ObservationStatus? j_ = i_?.Value;
            string k_ = context.Operators.Convert<string>(j_);
            string[] l_ = [
                "final",
                "amended",
                "corrected",
            ];
            bool? m_ = context.Operators.In<string>(k_, l_ as IEnumerable<string>);
            bool? n_ = context.Operators.And(h_, m_);

            return n_;
        };
        IEnumerable<Observation> c_ = context.Operators.Where<Observation>(a_, b_);

        return c_;
    }



    [CqlDeclaration("Test2")]
    public CqlQuantity Test2(CqlContext context)
    {
        IEnumerable<Observation> a_ = this.Qualifying_Blood_Pressure_Reading(context);
        IEnumerable<Observation> b_(Observation SBPReading)
        {
            IEnumerable<Encounter> i_ = this.Inpatient_Encounters(context);
            bool? j_(Encounter EncounterInpatient)
            {
                DataType n_ = SBPReading?.Effective;
                object o_ = FHIRHelpers_4_4_000.Instance.ToValue(context, n_);
                CqlDateTime p_ = QICoreCommon_2_1_000.Instance.earliest(context, o_);
                Period q_ = EncounterInpatient?.Period;
                CqlInterval<CqlDateTime> r_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, q_);
                CqlDateTime s_ = context.Operators.Start(r_);
                CqlQuantity t_ = context.Operators.Quantity(1440m, "minutes");
                CqlDateTime u_ = context.Operators.Subtract(s_, t_);
                CqlInterval<CqlDateTime> w_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, q_);
                CqlDateTime x_ = context.Operators.Start(w_);
                CqlQuantity y_ = context.Operators.Quantity(120m, "minutes");
                CqlDateTime z_ = context.Operators.Add(x_, y_);
                CqlInterval<CqlDateTime> aa_ = context.Operators.Interval(u_, z_, true, true);
                bool? ab_ = context.Operators.In<CqlDateTime>(p_, aa_, default);

                return ab_;
            };
            IEnumerable<Encounter> k_ = context.Operators.Where<Encounter>(i_, j_);
            Observation l_(Encounter EncounterInpatient) =>
                SBPReading;
            IEnumerable<Observation> m_ = context.Operators.Select<Encounter, Observation>(k_, l_);

            return m_;
        };
        IEnumerable<Observation> c_ = context.Operators.SelectMany<Observation, Observation>(a_, b_);
        CqlQuantity d_(Observation SBPReading)
        {
            List<Observation.ComponentComponent> ac_ = SBPReading?.Component;
            bool? ad_(Observation.ComponentComponent SBPComponent)
            {
                CodeableConcept aj_ = SBPComponent?.Code;
                CqlConcept ak_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, aj_);
                CqlCode al_ = this.Systolic_blood_pressure(context);
                CqlConcept am_ = context.Operators.ConvertCodeToConcept(al_);
                bool? an_ = context.Operators.Equivalent(ak_, am_);

                return an_;
            };
            IEnumerable<Observation.ComponentComponent> ae_ = context.Operators.Where<Observation.ComponentComponent>((IEnumerable<Observation.ComponentComponent>)ac_, ad_);
            CqlQuantity af_(Observation.ComponentComponent SBPComponent)
            {
                DataType ao_ = SBPComponent?.Value;
                object ap_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ao_);

                return ap_ as CqlQuantity;
            };
            IEnumerable<CqlQuantity> ag_ = context.Operators.Select<Observation.ComponentComponent, CqlQuantity>(ae_, af_);
            IEnumerable<CqlQuantity> ah_ = context.Operators.Distinct<CqlQuantity>(ag_);
            CqlQuantity ai_ = context.Operators.SingletonFrom<CqlQuantity>(ah_);

            return ai_;
        };
        IEnumerable<CqlQuantity> e_ = context.Operators.Select<Observation, CqlQuantity>(c_, d_);
        IEnumerable<CqlQuantity> f_ = context.Operators.Distinct<CqlQuantity>(e_);
        IEnumerable<CqlQuantity> g_ = context.Operators.ListSort<CqlQuantity>(f_, System.ComponentModel.ListSortDirection.Ascending);
        CqlQuantity h_ = context.Operators.First<CqlQuantity>(g_);

        return h_;
    }



    [CqlDeclaration("Encounter with First White Blood Cells Lab Test")]
    public IEnumerable<(CqlTupleMetadata, string EncounterId, CqlQuantity FirstWhiteBloodCellResult, CqlDateTime Timing)?> Encounter_with_First_White_Blood_Cells_Lab_Test(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Inpatient_Encounters(context);
        (CqlTupleMetadata, string EncounterId, CqlQuantity FirstWhiteBloodCellResult, CqlDateTime Timing)? b_(Encounter EncounterInpatient)
        {
            Id e_ = EncounterInpatient?.IdElement;
            string f_ = e_?.Value;
            CqlValueSet g_ = this.White_blood_cells_count_lab_test(context);
            IEnumerable<Observation> h_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, g_, default, "http://hl7.org/fhir/us/core/StructureDefinition/us-core-observation-lab"));
            bool? i_(Observation WhiteBloodCellLab)
            {
                Instant aa_ = WhiteBloodCellLab?.IssuedElement;
                DateTimeOffset? ab_ = aa_?.Value;
                CqlDateTime ac_ = context.Operators.Convert<CqlDateTime>(ab_);
                CqlDateTime ad_ = QICoreCommon_2_1_000.Instance.earliest(context, ac_ as object);
                Period ae_ = EncounterInpatient?.Period;
                CqlInterval<CqlDateTime> af_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ae_);
                CqlDateTime ag_ = context.Operators.Start(af_);
                CqlQuantity ah_ = context.Operators.Quantity(1440m, "minutes");
                CqlDateTime ai_ = context.Operators.Subtract(ag_, ah_);
                CqlInterval<CqlDateTime> ak_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ae_);
                CqlDateTime al_ = context.Operators.Start(ak_);
                CqlDateTime an_ = context.Operators.Add(al_, ah_);
                CqlInterval<CqlDateTime> ao_ = context.Operators.Interval(ai_, an_, true, true);
                bool? ap_ = context.Operators.In<CqlDateTime>(ad_, ao_, default);
                Code<ObservationStatus> aq_ = WhiteBloodCellLab?.StatusElement;
                ObservationStatus? ar_ = aq_?.Value;
                string as_ = context.Operators.Convert<string>(ar_);
                string[] at_ = [
                    "final",
                    "amended",
                    "corrected",
                ];
                bool? au_ = context.Operators.In<string>(as_, at_ as IEnumerable<string>);
                bool? av_ = context.Operators.And(ap_, au_);
                DataType aw_ = WhiteBloodCellLab?.Value;
                object ax_ = FHIRHelpers_4_4_000.Instance.ToValue(context, aw_);
                bool? ay_ = context.Operators.Not((bool?)(ax_ is null));
                bool? az_ = context.Operators.And(av_, ay_);

                return az_;
            };
            IEnumerable<Observation> j_ = context.Operators.Where<Observation>(h_, i_);
            object k_(Observation @this)
            {
                Instant ba_ = @this?.IssuedElement;
                DateTimeOffset? bb_ = ba_?.Value;
                CqlDateTime bc_ = context.Operators.Convert<CqlDateTime>(bb_);
                CqlDateTime bd_ = QICoreCommon_2_1_000.Instance.earliest(context, bc_ as object);

                return bd_;
            };
            IEnumerable<Observation> l_ = context.Operators.SortBy<Observation>(j_, k_, System.ComponentModel.ListSortDirection.Ascending);
            Observation m_ = context.Operators.First<Observation>(l_);
            DataType n_ = m_?.Value;
            object o_ = FHIRHelpers_4_4_000.Instance.ToValue(context, n_);
            IEnumerable<Observation> q_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, g_, default, "http://hl7.org/fhir/us/core/StructureDefinition/us-core-observation-lab"));
            bool? r_(Observation WhiteBloodCellLab)
            {
                Instant be_ = WhiteBloodCellLab?.IssuedElement;
                DateTimeOffset? bf_ = be_?.Value;
                CqlDateTime bg_ = context.Operators.Convert<CqlDateTime>(bf_);
                CqlDateTime bh_ = QICoreCommon_2_1_000.Instance.earliest(context, bg_ as object);
                Period bi_ = EncounterInpatient?.Period;
                CqlInterval<CqlDateTime> bj_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, bi_);
                CqlDateTime bk_ = context.Operators.Start(bj_);
                CqlQuantity bl_ = context.Operators.Quantity(1440m, "minutes");
                CqlDateTime bm_ = context.Operators.Subtract(bk_, bl_);
                CqlInterval<CqlDateTime> bo_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, bi_);
                CqlDateTime bp_ = context.Operators.Start(bo_);
                CqlDateTime br_ = context.Operators.Add(bp_, bl_);
                CqlInterval<CqlDateTime> bs_ = context.Operators.Interval(bm_, br_, true, true);
                bool? bt_ = context.Operators.In<CqlDateTime>(bh_, bs_, default);
                Code<ObservationStatus> bu_ = WhiteBloodCellLab?.StatusElement;
                ObservationStatus? bv_ = bu_?.Value;
                string bw_ = context.Operators.Convert<string>(bv_);
                string[] bx_ = [
                    "final",
                    "amended",
                    "corrected",
                ];
                bool? by_ = context.Operators.In<string>(bw_, bx_ as IEnumerable<string>);
                bool? bz_ = context.Operators.And(bt_, by_);
                DataType ca_ = WhiteBloodCellLab?.Value;
                object cb_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ca_);
                bool? cc_ = context.Operators.Not((bool?)(cb_ is null));
                bool? cd_ = context.Operators.And(bz_, cc_);

                return cd_;
            };
            IEnumerable<Observation> s_ = context.Operators.Where<Observation>(q_, r_);
            object t_(Observation @this)
            {
                Instant ce_ = @this?.IssuedElement;
                DateTimeOffset? cf_ = ce_?.Value;
                CqlDateTime cg_ = context.Operators.Convert<CqlDateTime>(cf_);
                CqlDateTime ch_ = QICoreCommon_2_1_000.Instance.earliest(context, cg_ as object);

                return ch_;
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



    [CqlDeclaration("SDE Ethnicity")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Ethnicity(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? a_ = SupplementalDataElements_3_5_000.Instance.SDE_Ethnicity(context);

        return a_;
    }



    [CqlDeclaration("SDE Payer")]
    public IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> SDE_Payer(CqlContext context)
    {
        IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> a_ = SupplementalDataElements_3_5_000.Instance.SDE_Payer(context);

        return a_;
    }



    [CqlDeclaration("SDE Race")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Race(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? a_ = SupplementalDataElements_3_5_000.Instance.SDE_Race(context);

        return a_;
    }



    [CqlDeclaration("SDE Sex")]
    public CqlCode SDE_Sex(CqlContext context)
    {
        CqlCode a_ = SupplementalDataElements_3_5_000.Instance.SDE_Sex(context);

        return a_;
    }


    private static CqlTupleMetadata CqlTupleMetadata_ddJhZGNHefSCOAJJFEIEcXie = new(
        [typeof(int?), typeof(CqlInterval<CqlDateTime>)],
        ["dayIndex", "dayPeriod"]);

    private static CqlTupleMetadata CqlTupleMetadata_HPcCiDPXQfZTXIORThMLfTQDR = new(
        [typeof(IEnumerable<CqlCode>), typeof(string)],
        ["codes", "display"]);

    private static CqlTupleMetadata CqlTupleMetadata_GPRWMPNAYaJRiGDFSTLJOPeIJ = new(
        [typeof(CqlConcept), typeof(CqlInterval<CqlDateTime>)],
        ["code", "period"]);

    private static CqlTupleMetadata CqlTupleMetadata_BZDEAYEYEiNadHNdHhSIPXaDL = new(
        [typeof(CqlDate)],
        ["AntidepressantDate"]);

    private static CqlTupleMetadata CqlTupleMetadata_BHcMAQBSeFPCjbDEhaVDLJXQU = new(
        [typeof(Encounter), typeof(Condition)],
        ["VisitWithAntibiotic", "AcutePharyngitisTonsillitis"]);

    private static CqlTupleMetadata CqlTupleMetadata_FeNRUFDKGVUFAMiQLLieSFHIV = new(
        [typeof(Observation), typeof(Encounter)],
        ["GroupAStreptococcusTest", "EncounterWithPharyngitis"]);

    private static CqlTupleMetadata CqlTupleMetadata_FiGMIRiNMNcaAVFKbMahDKTce = new(
        [typeof(Encounter), typeof(Condition)],
        ["QualifyingEncounters", "URI"]);

    private static CqlTupleMetadata CqlTupleMetadata_DjNbNOhJZXGJDNQeiTBabEOBB = new(
        [typeof(string), typeof(int?)],
        ["EncounterID", "CalculatedCGA"]);

    private static CqlTupleMetadata CqlTupleMetadata_EMDhFLcFhWVERAVVNfLAZYXJi = new(
        [typeof(CqlDate), typeof(CqlDate), typeof(CqlDate), typeof(CqlDate)],
        ["DTaPVaccination1", "DTaPVaccination2", "DTaPVaccination3", "DTaPVaccination4"]);

    private static CqlTupleMetadata CqlTupleMetadata_CNGHaZROXaJTHPICcbIaJbRXV = new(
        [typeof(CqlDate), typeof(CqlDate), typeof(CqlDate)],
        ["PolioVaccination1", "PolioVaccination2", "PolioVaccination3"]);

    private static CqlTupleMetadata CqlTupleMetadata_EZTgahAUWGgSdGaDCgQNNIPGW = new(
        [typeof(CqlDate), typeof(CqlDate), typeof(CqlDate)],
        ["HepatitisBVaccination1", "HepatitisBVaccination2", "HepatitisBVaccination3"]);

    private static CqlTupleMetadata CqlTupleMetadata_HDfaMbZGBWDPFETGQNFbceEeg = new(
        [typeof(CqlDate), typeof(CqlDate), typeof(CqlDate)],
        ["HepatitisBVaccination1", "HepatitisBVaccination2", "NewBornVaccine3"]);

    private static CqlTupleMetadata CqlTupleMetadata_DdPDeOJhPYESfHGCOcBNOiPPP = new(
        [typeof(CqlDate), typeof(CqlDate), typeof(CqlDate), typeof(CqlDate)],
        ["PneumococcalVaccination1", "PneumococcalVaccination2", "PneumococcalVaccination3", "PneumococcalVaccination4"]);

    private static CqlTupleMetadata CqlTupleMetadata_BZhFLeRDagbPQMNheVJcUNfNQ = new(
        [typeof(CqlDate), typeof(CqlDate)],
        ["FluVaccination1", "FluVaccination2"]);

    private static CqlTupleMetadata CqlTupleMetadata_EDdTRBfWHaSNbiiXJfIVJUXdb = new(
        [typeof(string), typeof(CqlDateTime)],
        ["ID", "AuthorDate"]);

    private static CqlTupleMetadata CqlTupleMetadata_FOBYUiHifSfYFYhEEQajgLbgF = new(
        [typeof(CqlQuantity), typeof(Observation)],
        ["QualifyingGlycemicStatusValue", "QualifyingGlycemicStatus"]);

    private static CqlTupleMetadata CqlTupleMetadata_CVELXTjiMTaGQEjMfJXBdUHjW = new(
        [typeof(CqlDate)],
        ["startDate"]);

    private static CqlTupleMetadata CqlTupleMetadata_EhMLLfWeOaeVhYfBZeiQfaefD = new(
        [typeof(CqlInterval<CqlDate>), typeof(CqlDate)],
        ["period", "periodStart"]);

    private static CqlTupleMetadata CqlTupleMetadata_GVNUVHGXYWXVGgfjdTEahUfhP = new(
        [typeof(Observation), typeof(Observation), typeof(Observation), typeof(Observation), typeof(Observation)],
        ["HOOSLifeQuality", "HOOSSport", "HOOSActivityScore", "HOOSSymptoms", "HOOSPain"]);

    private static CqlTupleMetadata CqlTupleMetadata_DDTAOdcFieSJbGgRLLZPYbGQb = new(
        [typeof(Observation), typeof(Observation)],
        ["PROMIS10MentalScore", "PROMIS10PhysicalScore"]);

    private static CqlTupleMetadata CqlTupleMetadata_GAdRFKRaHUUGJcVHWQWRUjhRH = new(
        [typeof(Observation), typeof(Observation)],
        ["VR12MentalAssessment", "VR12PhysicalAssessment"]);

    private static CqlTupleMetadata CqlTupleMetadata_DbNMMZBTISSRTNdiShceSFVih = new(
        [typeof(Encounter), typeof(Encounter)],
        ["OfficeVisit1", "OfficeVisit2"]);

    private static CqlTupleMetadata CqlTupleMetadata_BGYjYGLNPKWAZTBCVAdLDDTMj = new(
        [typeof(Encounter), typeof(CqlDate), typeof(CqlDate)],
        ["ValidEncounters", "InitialPROMIS10Date", "FollowupPROMIS10Date"]);

    private static CqlTupleMetadata CqlTupleMetadata_DBUJFOVGBcbhIQPWARNQHKUaX = new(
        [typeof(Observation), typeof(Observation), typeof(Observation), typeof(Observation), typeof(Observation), typeof(Observation), typeof(Observation)],
        ["Promis29Sleep", "Promis29SocialRoles", "Promis29Physical", "Promis29Pain", "Promis29Fatigue", "Promis29Depression", "Promis29Anxiety"]);

    private static CqlTupleMetadata CqlTupleMetadata_DSZKEYVbCINNIeAQiZdVaEJhG = new(
        [typeof(Encounter), typeof(CqlDate), typeof(CqlDate)],
        ["ValidEncounters", "InitialPROMIS29Date", "FollowupPROMIS29Date"]);

    private static CqlTupleMetadata CqlTupleMetadata_FQKGdEYLiDFGMNAUAMETIHUQT = new(
        [typeof(Encounter), typeof(CqlDate), typeof(CqlDate)],
        ["ValidEncounters", "InitialVR12ObliqueDate", "FollowupVR12ObliqueDate"]);

    private static CqlTupleMetadata CqlTupleMetadata_HSSAQEFQAOXLjUcOKGgicELWB = new(
        [typeof(Encounter), typeof(CqlDate), typeof(CqlDate)],
        ["ValidEncounters", "InitialVR12OrthogonalDate", "FollowupVR12OrthogonalDate"]);

    private static CqlTupleMetadata CqlTupleMetadata_DUcFTCLcQEWDGGQdFCWTHFaUK = new(
        [typeof(Observation), typeof(Observation)],
        ["VR36MentalAssessment", "VR36PhysicalAssessment"]);

    private static CqlTupleMetadata CqlTupleMetadata_HQfcMfhQUSTNYMWSgJHiFeahQ = new(
        [typeof(Encounter), typeof(CqlDate), typeof(CqlDate)],
        ["ValidEncounters", "InitialVR36ObliqueDate", "FollowupVR36ObliqueDate"]);

    private static CqlTupleMetadata CqlTupleMetadata_BFZHWdOOROjSjFSECHcQiaZZZ = new(
        [typeof(Encounter), typeof(CqlDate), typeof(CqlDate)],
        ["ValidEncounters", "InitialVR36OrthogonalDate", "FollowupVR36OrthogonalDate"]);

    private static CqlTupleMetadata CqlTupleMetadata_EBLWeAeedHPAfOJXKPZJKSCUf = new(
        [typeof(Observation), typeof(Observation)],
        ["MLHFQPhysical", "MLHFQEmotional"]);

    private static CqlTupleMetadata CqlTupleMetadata_CcaWSNDiVeaLebVKKWWWiBcEU = new(
        [typeof(Encounter), typeof(CqlDate), typeof(CqlDate)],
        ["ValidEncounters", "InitialMLHFQDate", "FollowupMLHFQDate"]);

    private static CqlTupleMetadata CqlTupleMetadata_DFKXORghhYafccUSbQaMfNTDj = new(
        [typeof(Observation), typeof(Observation)],
        ["KCCQ12Item", "KCCQ12Summary"]);

    private static CqlTupleMetadata CqlTupleMetadata_EQQLFFBVIbLIQLiZDNfeYdMU = new(
        [typeof(Encounter), typeof(CqlDate), typeof(CqlDate)],
        ["ValidEncounters", "InitialKCCQ12Date", "FollowupKCCQ12Date"]);

    private static CqlTupleMetadata CqlTupleMetadata_BbPMcXSJeOeGdRcaZWGYPhGBL = new(
        [typeof(Observation), typeof(Observation), typeof(Observation), typeof(Observation), typeof(Observation), typeof(Observation)],
        ["KCCQLifeQuality", "KCCQSymptomStability", "KCCQSelfEfficacy", "KCCQSymptoms", "KCCQPhysicalLimits", "KCCQSocialLimits"]);

    private static CqlTupleMetadata CqlTupleMetadata_HEFWLcHhCNCOQegEOfjWTXiGN = new(
        [typeof(Encounter), typeof(CqlDate), typeof(CqlDate)],
        ["ValidEncounters", "InitialKCCQAssessmentDate", "FollowupKCCQAssessmentDate"]);

    private static CqlTupleMetadata CqlTupleMetadata_DggZKjEbQUfLADMDMBeASLDR = new(
        [typeof(Encounter), typeof(CqlDate), typeof(CqlDate)],
        ["ValidEncounters", "InitialKCCQTotalScore", "FollowupKCCQTotalScore"]);

    private static CqlTupleMetadata CqlTupleMetadata_GVQcZJVjNdGAcjPedLaYDjEME = new(
        [typeof(Encounter), typeof(Procedure)],
        ["QualifyingEncounter", "HospitalDietitianReferral"]);

    private static CqlTupleMetadata CqlTupleMetadata_XadcRffdjUdMDMjcTIdSXKKS = new(
        [typeof(Encounter), typeof(Observation)],
        ["QualifyingEncounter", "MalnutritionRiskScreening"]);

    private static CqlTupleMetadata CqlTupleMetadata_GFjZJIRJbJMHZiLMbCVCEiHgh = new(
        [typeof(Encounter), typeof(Observation)],
        ["QualifyingEncounter", "NutritionAssessment"]);

    private static CqlTupleMetadata CqlTupleMetadata_CTGXhDDGNAgcaKfhTDIBGVLYU = new(
        [typeof(Encounter), typeof(Condition)],
        ["QualifyingEncounter", "MalnutritionDiagnosis"]);

    private static CqlTupleMetadata CqlTupleMetadata_TVETjQTNGSKUhAIhIbeKTXMI = new(
        [typeof(Encounter), typeof(Procedure)],
        ["QualifyingEncounter", "NutritionCarePlan"]);

    private static CqlTupleMetadata CqlTupleMetadata_FUFPMQdRaTBgLhghDWfUUBaNF = new(
        [typeof(Observation), typeof(Encounter)],
        ["HeartRate", "ModerateOrSevereLVSDHFOutpatientEncounter"]);

    private static CqlTupleMetadata CqlTupleMetadata_CCJaUjRHWSXeUTcFAfVeVeNaD = new(
        [typeof(string), typeof(IEnumerable<ResourceReference>), typeof(IEnumerable<int?>), typeof(IEnumerable<Encounter.DiagnosisComponent>)],
        ["encounterId", "condition", "rank", "POA"]);

    private static CqlTupleMetadata CqlTupleMetadata_CajFQjTXAXITWGJPNIjCafPiF = new(
        [typeof(Encounter), typeof(CqlConcept)],
        ["encounter", "condition"]);

    private static CqlTupleMetadata CqlTupleMetadata_GPLfQTPONQabPZigKbYFERDVQ = new(
        [typeof(Encounter), typeof(CqlInterval<CqlDateTime>)],
        ["encounter", "hospitalizationPeriod"]);

    private static CqlTupleMetadata CqlTupleMetadata_BRDBXSUhdQiXBCfMGdSacWIG = new(
        [typeof((CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod)?), typeof(MedicationAdministration)],
        ["Hospitalization", "HypoglycemicMed"]);

    private static CqlTupleMetadata CqlTupleMetadata_SMNhCfXhAdRgSFYJNGOMBShE = new(
        [typeof(int?), typeof(CqlInterval<CqlDateTime>)],
        ["dayNumber", "dayPeriod"]);

    private static CqlTupleMetadata CqlTupleMetadata_HRTAKZQhNDEfbiSbFGHLQTdcR = new(
        [typeof(Encounter), typeof(CqlInterval<CqlDateTime>), typeof(CqlInterval<CqlDateTime>), typeof(IEnumerable<(CqlTupleMetadata, int? dayNumber, CqlInterval<CqlDateTime> dayPeriod)?>)],
        ["encounter", "hospitalizationPeriod", "relevantPeriod", "relevantDays"]);

    private static CqlTupleMetadata CqlTupleMetadata_BbhMZNJZUhELHSIeBfBEVUQGO = new(
        [typeof(int?), typeof(CqlInterval<CqlDateTime>), typeof(bool?), typeof(bool?), typeof(bool?)],
        ["dayNumber", "dayPeriod", "hasSevereResult", "hasElevatedResult", "hasNoGlucoseTest"]);

    private static CqlTupleMetadata CqlTupleMetadata_FhADCCAGbeXAiadgccRECiPBd = new(
        [typeof(Encounter), typeof(CqlInterval<CqlDateTime>), typeof(IEnumerable<(CqlTupleMetadata, int? dayNumber, CqlInterval<CqlDateTime> dayPeriod, bool? hasSevereResult, bool? hasElevatedResult, bool? hasNoGlucoseTest)?>)],
        ["encounter", "relevantPeriod", "relevantDays"]);

    private static CqlTupleMetadata CqlTupleMetadata_FNeERNKXWKJeEjWXREHDLePdY = new(
        [typeof(int?), typeof(CqlInterval<CqlDateTime>), typeof(bool?)],
        ["dayIndex", "dayPeriod", "hasHyperglycemicEvent"]);

    private static CqlTupleMetadata CqlTupleMetadata_GJFejXJaZWjRVYgMbQUZgIPjK = new(
        [typeof(Encounter), typeof(CqlInterval<CqlDateTime>), typeof(IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)?>)],
        ["encounter", "relevantPeriod", "eligibleEventDays"]);

    private static CqlTupleMetadata CqlTupleMetadata_CLZgggJGDQVFHPIfbiSZOiXTH = new(
        [typeof(Encounter), typeof(Observation)],
        ["InpatientHospitalization", "GlucoseTest"]);

    private static CqlTupleMetadata CqlTupleMetadata_BBNOZJWbNFIIMKUYJNdXQYNTL = new(
        [typeof(Encounter), typeof(Observation), typeof(Observation)],
        ["InpatientHospitalization", "GlucoseResult1000", "EarlierGlucoseTest"]);

    private static CqlTupleMetadata CqlTupleMetadata_DBJShWTZiKWMABGVHCaJVcMhY = new(
        [typeof(MedicationAdministration), typeof(MedicationAdministration), typeof(Encounter)],
        ["OpioidAntagonistGiven", "OpioidGiven", "EncounterWithQualifyingAge"]);

    private static CqlTupleMetadata CqlTupleMetadata_FSGEiXEbHOWUcRPJgTjPZFYcO = new(
        [typeof(Encounter), typeof(MedicationAdministration), typeof(Observation)],
        ["QualifyingEncounter", "HypoglycemicMedication", "GlucoseTest"]);

    private static CqlTupleMetadata CqlTupleMetadata_BfZBOfPTWgQBddbhgdIFdbKHU = new(
        [typeof(Encounter), typeof(Observation), typeof(Observation)],
        ["QualifyingEncounter", "LowGlucoseTest", "FollowupGlucoseTest"]);

    private static CqlTupleMetadata CqlTupleMetadata_GNOWceaaAJjTLNBBKCiSMeeVD = new(
        [typeof(Encounter), typeof(Observation)],
        ["QualifyingEncounter", "HypoglycemicEvent"]);

    private static CqlTupleMetadata CqlTupleMetadata_GIbILVAdXLLNYBgcQIEiUiKaK = new(
        [typeof(string), typeof(CqlQuantity), typeof(CqlDateTime)],
        ["EncounterId", "FirstTemperatureResult", "Timing"]);

    private static CqlTupleMetadata CqlTupleMetadata_DhbJAfCiKIAGYKTjJXYGSKECQ = new(
        [typeof(string), typeof(CqlQuantity), typeof(CqlDateTime)],
        ["EncounterId", "FirstHeartRateResult", "Timing"]);

    private static CqlTupleMetadata CqlTupleMetadata_FdREYEdHOZIcMCNYCRFJYJReA = new(
        [typeof(string), typeof(CqlQuantity), typeof(CqlDateTime)],
        ["EncounterId", "FirstOxygenSatResult", "Timing"]);

    private static CqlTupleMetadata CqlTupleMetadata_GbUHPXXHScejjXWhcHJFQQifQ = new(
        [typeof(string), typeof(CqlQuantity), typeof(CqlDateTime)],
        ["EncounterId", "FirstBicarbonateResult", "Timing"]);

    private static CqlTupleMetadata CqlTupleMetadata_FETECNQPQREfGRgPYWhOWgeWA = new(
        [typeof(string), typeof(CqlQuantity), typeof(CqlDateTime)],
        ["EncounterId", "FirstCreatinineResult", "Timing"]);

    private static CqlTupleMetadata CqlTupleMetadata_DIHdhbAJeJTdiAVUAELUHRNdS = new(
        [typeof(string), typeof(CqlQuantity), typeof(CqlDateTime)],
        ["EncounterId", "FirstHematocritResult", "Timing"]);

    private static CqlTupleMetadata CqlTupleMetadata_DAUcYHQZcDKbIfORJOEZBDgIh = new(
        [typeof(string), typeof(CqlQuantity), typeof(CqlDateTime)],
        ["EncounterId", "FirstPlateletResult", "Timing"]);

    private static CqlTupleMetadata CqlTupleMetadata_GKGeLARADLGJcNcZaDhdCREMa = new(
        [typeof(string), typeof(CqlQuantity), typeof(CqlDateTime)],
        ["EncounterId", "FirstSodiumResult", "Timing"]);

    private static CqlTupleMetadata CqlTupleMetadata_ChVYCdXDGgVcFTCCUefXMbCHX = new(
        [typeof(string), typeof(CqlQuantity), typeof(CqlDateTime)],
        ["EncounterId", "FirstWhiteBloodCellResult", "Timing"]);

}

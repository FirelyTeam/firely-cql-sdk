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

[System.CodeDom.Compiler.GeneratedCode(".NET Code Generation", "2.0.8.0")]
[CqlLibrary("HospitalHarmSevereHypoglycemiaFHIR", "0.0.012")]
public partial class HospitalHarmSevereHypoglycemiaFHIR_0_0_012 : ILibrary, ISingleton<HospitalHarmSevereHypoglycemiaFHIR_0_0_012>
{
    private HospitalHarmSevereHypoglycemiaFHIR_0_0_012() {}

    public static HospitalHarmSevereHypoglycemiaFHIR_0_0_012 Instance { get; } = new();

    #region Library Members
    string ILibrary.Name => "HospitalHarmSevereHypoglycemiaFHIR";
    string ILibrary.Version => "0.0.012";
    IReadOnlyList<ILibrary> ILibrary.Dependencies => [FHIRHelpers_4_0_001.Instance, SupplementalDataElementsFHIR4_2_0_000.Instance, MATGlobalCommonFunctionsFHIR4_6_1_000.Instance];
    #endregion Library Members

    [CqlDeclaration("birth date")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.560.100.4")]
    public CqlValueSet birth_date(CqlContext context) =>
        new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.560.100.4", default);



    [CqlDeclaration("Emergency Department Visit")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.292")]
    public CqlValueSet Emergency_Department_Visit(CqlContext context) =>
        new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.292", default);



    [CqlDeclaration("Encounter Inpatient")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.666.5.307")]
    public CqlValueSet Encounter_Inpatient(CqlContext context) =>
        new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.666.5.307", default);



    [CqlDeclaration("Glucose lab test")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1045.134")]
    public CqlValueSet Glucose_lab_test(CqlContext context) =>
        new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1045.134", default);



    [CqlDeclaration("Hypoglycemics")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1179.3")]
    public CqlValueSet Hypoglycemics(CqlContext context) =>
        new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1179.3", default);



    [CqlDeclaration("Hypoglycemics Severe Hypoglycemia")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1196.393")]
    public CqlValueSet Hypoglycemics_Severe_Hypoglycemia(CqlContext context) =>
        new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1196.393", default);



    [CqlDeclaration("Observation Services")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1111.143")]
    public CqlValueSet Observation_Services(CqlContext context) =>
        new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1111.143", default);



    [CqlDeclaration("Birth date")]
    public CqlCode Birth_date(CqlContext context) =>
        new CqlCode("21112-8", "http://loinc.org", default, default);



    [CqlDeclaration("LOINC")]
    public CqlCode[] LOINC(CqlContext context)
    {
        CqlCode[] a_ = [
            new CqlCode("21112-8", "http://loinc.org", default, default),
        ];

        return a_;
    }



    [CqlDeclaration("Measurement Period")]
    public CqlInterval<CqlDateTime> Measurement_Period(CqlContext context)
    {
        CqlDateTime a_ = context.Operators.DateTime(2019, 1, 1, 0, 0, 0, 0, default);
        CqlDateTime b_ = context.Operators.DateTime(2020, 1, 1, 0, 0, 0, 0, default);
        CqlInterval<CqlDateTime> c_ = context.Operators.Interval(a_, b_, true, false);
        object d_ = context.ResolveParameter("HospitalHarmSevereHypoglycemiaFHIR-0.0.012", "Measurement Period", c_);

        return (CqlInterval<CqlDateTime>)d_;
    }



    [CqlDeclaration("Patient")]
    public Patient Patient(CqlContext context)
    {
        IEnumerable<Patient> a_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/StructureDefinition/Patient"));
        Patient b_ = context.Operators.SingletonFrom<Patient>(a_);

        return b_;
    }



    [CqlDeclaration("SDE Payer")]
    public IEnumerable<(CqlTupleMetadata, CodeableConcept code, Period period)?> SDE_Payer(CqlContext context)
    {
        IEnumerable<(CqlTupleMetadata, CodeableConcept code, Period period)?> a_ = SupplementalDataElementsFHIR4_2_0_000.Instance.SDE_Payer(context);

        return a_;
    }



    [CqlDeclaration("SDE Race")]
    public IEnumerable<Coding> SDE_Race(CqlContext context)
    {
        IEnumerable<Coding> a_ = SupplementalDataElementsFHIR4_2_0_000.Instance.SDE_Race(context);

        return a_;
    }



    [CqlDeclaration("SDE Sex")]
    public CqlCode SDE_Sex(CqlContext context)
    {
        CqlCode a_ = SupplementalDataElementsFHIR4_2_0_000.Instance.SDE_Sex(context);

        return a_;
    }



    [CqlDeclaration("Inpatient Encounter During Measurement Period")]
    public IEnumerable<Encounter> Inpatient_Encounter_During_Measurement_Period(CqlContext context)
    {
        CqlValueSet a_ = this.Encounter_Inpatient(context);
        IEnumerable<Encounter> b_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/StructureDefinition/Encounter"));
        bool? c_(Encounter EncounterInpatient)
        {
            Code<Encounter.EncounterStatus> e_ = EncounterInpatient?.StatusElement;
            string f_ = FHIRHelpers_4_0_001.Instance.ToString(context, e_);
            bool? g_ = context.Operators.Equal(f_, "finished");
            Period h_ = EncounterInpatient?.Period;
            CqlInterval<CqlDateTime> i_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, h_);
            CqlDateTime j_ = context.Operators.End(i_);
            CqlInterval<CqlDateTime> k_ = this.Measurement_Period(context);
            bool? l_ = context.Operators.In<CqlDateTime>(j_, k_, default);
            bool? m_ = context.Operators.And(g_, l_);

            return m_;
        };
        IEnumerable<Encounter> d_ = context.Operators.Where<Encounter>(b_, c_);

        return d_;
    }



    [CqlDeclaration("Qualifying Encounter")]
    public IEnumerable<Encounter> Qualifying_Encounter(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Inpatient_Encounter_During_Measurement_Period(context);
        bool? b_(Encounter InpatientEncounter)
        {
            Patient d_ = this.Patient(context);
            Date e_ = d_?.BirthDateElement;
            string f_ = e_?.Value;
            CqlDateTime g_ = context.Operators.ConvertStringToDateTime(f_);
            CqlInterval<CqlDateTime> h_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.HospitalizationWithObservation(context, InpatientEncounter);
            CqlDateTime i_ = context.Operators.Start(h_);
            int? j_ = context.Operators.CalculateAgeAt(g_, i_, "year");
            bool? k_ = context.Operators.GreaterOrEqual(j_, 18);

            return k_;
        };
        IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);

        return c_;
    }



    [CqlDeclaration("Hypoglycemic Medication Administration")]
    public IEnumerable<MedicationAdministration> Hypoglycemic_Medication_Administration(CqlContext context)
    {
        CqlValueSet a_ = this.Hypoglycemics_Severe_Hypoglycemia(context);
        IEnumerable<MedicationAdministration> b_ = context.Operators.Retrieve<MedicationAdministration>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/StructureDefinition/MedicationAdministration"));
        IEnumerable<MedicationAdministration> d_ = context.Operators.Retrieve<MedicationAdministration>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/StructureDefinition/MedicationAdministration"));
        IEnumerable<MedicationAdministration> e_ = context.Operators.Union<MedicationAdministration>(b_, d_);
        bool? f_(MedicationAdministration HypoMedication)
        {
            Code<MedicationAdministration.MedicationAdministrationStatusCodes> h_ = HypoMedication?.StatusElement;
            string i_ = FHIRHelpers_4_0_001.Instance.ToString(context, h_);
            bool? j_ = context.Operators.Equal(i_, "completed");
            string l_ = FHIRHelpers_4_0_001.Instance.ToString(context, h_);
            bool? m_ = context.Operators.Equal(l_, "not-done");
            bool? n_ = context.Operators.Not(m_);
            bool? o_ = context.Operators.And(j_, n_);

            return o_;
        };
        IEnumerable<MedicationAdministration> g_ = context.Operators.Where<MedicationAdministration>(e_, f_);

        return g_;
    }



    [CqlDeclaration("Qualifying Encounter with Hypoglycemic Medication Administration")]
    public IEnumerable<Encounter> Qualifying_Encounter_with_Hypoglycemic_Medication_Administration(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Qualifying_Encounter(context);
        IEnumerable<Encounter> b_(Encounter QualifyingEncounter)
        {
            IEnumerable<MedicationAdministration> d_ = this.Hypoglycemic_Medication_Administration(context);
            bool? e_(MedicationAdministration HypoglycemicMedication)
            {
                DataType i_ = HypoglycemicMedication?.Effective;
                CqlInterval<CqlDateTime> j_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, i_);
                CqlDateTime k_ = context.Operators.Start(j_);
                CqlInterval<CqlDateTime> l_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.HospitalizationWithObservation(context, QualifyingEncounter);
                bool? m_ = context.Operators.In<CqlDateTime>(k_, l_, default);

                return m_;
            };
            IEnumerable<MedicationAdministration> f_ = context.Operators.Where<MedicationAdministration>(d_, e_);
            Encounter g_(MedicationAdministration HypoglycemicMedication) =>
                QualifyingEncounter;
            IEnumerable<Encounter> h_ = context.Operators.Select<MedicationAdministration, Encounter>(f_, g_);

            return h_;
        };
        IEnumerable<Encounter> c_ = context.Operators.SelectMany<Encounter, Encounter>(a_, b_);

        return c_;
    }



    [CqlDeclaration("Initial Population")]
    public IEnumerable<Encounter> Initial_Population(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Qualifying_Encounter_with_Hypoglycemic_Medication_Administration(context);

        return a_;
    }



    [CqlDeclaration("Denominator")]
    public IEnumerable<Encounter> Denominator(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Initial_Population(context);

        return a_;
    }



    [CqlDeclaration("Severe Hypoglycemic Harm Event")]
    public IEnumerable<Encounter> Severe_Hypoglycemic_Harm_Event(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Denominator(context);
        bool? b_(Encounter QualifyingEncounter)
        {
            CqlValueSet d_ = this.Glucose_lab_test(context);
            IEnumerable<Observation> e_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, d_, default, "http://hl7.org/fhir/StructureDefinition/Observation"));
            IEnumerable<Observation> f_(Observation BloodGlucoseLab)
            {
                IEnumerable<MedicationAdministration> r_ = this.Hypoglycemic_Medication_Administration(context);
                bool? s_(MedicationAdministration HypoglycemicMeds)
                {
                    DataType w_ = HypoglycemicMeds?.Effective;
                    CqlInterval<CqlDateTime> x_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, w_);
                    CqlDateTime y_ = context.Operators.Start(x_);
                    DataType z_ = BloodGlucoseLab?.Effective;
                    CqlInterval<CqlDateTime> aa_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, z_);
                    CqlDateTime ab_ = context.Operators.Start(aa_);
                    CqlQuantity ac_ = context.Operators.Quantity(24m, "hours");
                    CqlDateTime ad_ = context.Operators.Subtract(ab_, ac_);
                    CqlInterval<CqlDateTime> af_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, z_);
                    CqlDateTime ag_ = context.Operators.Start(af_);
                    CqlInterval<CqlDateTime> ah_ = context.Operators.Interval(ad_, ag_, true, true);
                    bool? ai_ = context.Operators.In<CqlDateTime>(y_, ah_, default);
                    CqlInterval<CqlDateTime> ak_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, z_);
                    CqlDateTime al_ = context.Operators.Start(ak_);
                    bool? am_ = context.Operators.Not((bool?)(al_ is null));
                    bool? an_ = context.Operators.And(ai_, am_);
                    Code<ObservationStatus> ao_ = BloodGlucoseLab?.StatusElement;
                    string ap_ = FHIRHelpers_4_0_001.Instance.ToString(context, ao_);
                    bool? aq_ = context.Operators.Equal(ap_, "final");
                    bool? ar_ = context.Operators.And(an_, aq_);
                    string at_ = FHIRHelpers_4_0_001.Instance.ToString(context, ao_);
                    bool? au_ = context.Operators.Equal(at_, "cancelled");
                    bool? av_ = context.Operators.Not(au_);
                    bool? aw_ = context.Operators.And(ar_, av_);
                    CqlInterval<CqlDateTime> ay_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, w_);
                    CqlDateTime az_ = context.Operators.Start(ay_);
                    CqlInterval<CqlDateTime> ba_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.HospitalizationWithObservation(context, QualifyingEncounter);
                    bool? bb_ = context.Operators.In<CqlDateTime>(az_, ba_, default);
                    bool? bc_ = context.Operators.And(aw_, bb_);

                    return bc_;
                };
                IEnumerable<MedicationAdministration> t_ = context.Operators.Where<MedicationAdministration>(r_, s_);
                Observation u_(MedicationAdministration HypoglycemicMeds) =>
                    BloodGlucoseLab;
                IEnumerable<Observation> v_ = context.Operators.Select<MedicationAdministration, Observation>(t_, u_);

                return v_;
            };
            IEnumerable<Observation> g_ = context.Operators.SelectMany<Observation, Observation>(e_, f_);
            IEnumerable<Observation> i_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, d_, default, "http://hl7.org/fhir/StructureDefinition/Observation"));
            IEnumerable<Observation> j_(Observation BloodGlucoseLab)
            {
                IEnumerable<MedicationAdministration> bd_ = this.Hypoglycemic_Medication_Administration(context);
                bool? be_(MedicationAdministration HypoglycemicMeds)
                {
                    DataType bi_ = HypoglycemicMeds?.Effective;
                    CqlInterval<CqlDateTime> bj_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, bi_);
                    CqlDateTime bk_ = context.Operators.Start(bj_);
                    DataType bl_ = BloodGlucoseLab?.Effective;
                    CqlInterval<CqlDateTime> bm_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, bl_);
                    CqlDateTime bn_ = context.Operators.Start(bm_);
                    CqlQuantity bo_ = context.Operators.Quantity(24m, "hours");
                    CqlDateTime bp_ = context.Operators.Subtract(bn_, bo_);
                    CqlInterval<CqlDateTime> br_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, bl_);
                    CqlDateTime bs_ = context.Operators.Start(br_);
                    CqlInterval<CqlDateTime> bt_ = context.Operators.Interval(bp_, bs_, true, true);
                    bool? bu_ = context.Operators.In<CqlDateTime>(bk_, bt_, default);
                    CqlInterval<CqlDateTime> bw_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, bl_);
                    CqlDateTime bx_ = context.Operators.Start(bw_);
                    bool? by_ = context.Operators.Not((bool?)(bx_ is null));
                    bool? bz_ = context.Operators.And(bu_, by_);
                    Code<ObservationStatus> ca_ = BloodGlucoseLab?.StatusElement;
                    string cb_ = FHIRHelpers_4_0_001.Instance.ToString(context, ca_);
                    bool? cc_ = context.Operators.Equal(cb_, "final");
                    bool? cd_ = context.Operators.And(bz_, cc_);
                    string cf_ = FHIRHelpers_4_0_001.Instance.ToString(context, ca_);
                    bool? cg_ = context.Operators.Equal(cf_, "cancelled");
                    bool? ch_ = context.Operators.Not(cg_);
                    bool? ci_ = context.Operators.And(cd_, ch_);
                    CqlInterval<CqlDateTime> ck_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, bi_);
                    CqlDateTime cl_ = context.Operators.Start(ck_);
                    CqlInterval<CqlDateTime> cm_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.HospitalizationWithObservation(context, QualifyingEncounter);
                    bool? cn_ = context.Operators.In<CqlDateTime>(cl_, cm_, default);
                    bool? co_ = context.Operators.And(ci_, cn_);

                    return co_;
                };
                IEnumerable<MedicationAdministration> bf_ = context.Operators.Where<MedicationAdministration>(bd_, be_);
                Observation bg_(MedicationAdministration HypoglycemicMeds) =>
                    BloodGlucoseLab;
                IEnumerable<Observation> bh_ = context.Operators.Select<MedicationAdministration, Observation>(bf_, bg_);

                return bh_;
            };
            IEnumerable<Observation> k_ = context.Operators.SelectMany<Observation, Observation>(i_, j_);
            IEnumerable<Observation> l_(Observation BloodGlucoseLab)
            {
                CqlValueSet cp_ = this.Glucose_lab_test(context);
                IEnumerable<Observation> cq_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, cp_, default, "http://hl7.org/fhir/StructureDefinition/Observation"));
                bool? cr_(Observation FollowupBloodGlucoseLab)
                {
                    DataType cv_ = FollowupBloodGlucoseLab?.Effective;
                    CqlInterval<CqlDateTime> cw_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, cv_);
                    CqlDateTime cx_ = context.Operators.Start(cw_);
                    CqlInterval<CqlDateTime> cy_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.HospitalizationWithObservation(context, QualifyingEncounter);
                    bool? cz_ = context.Operators.In<CqlDateTime>(cx_, cy_, default);
                    CqlInterval<CqlDateTime> db_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, cv_);
                    CqlDateTime dc_ = context.Operators.Start(db_);
                    DataType dd_ = BloodGlucoseLab?.Effective;
                    CqlInterval<CqlDateTime> de_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, dd_);
                    CqlDateTime df_ = context.Operators.Start(de_);
                    CqlInterval<CqlDateTime> dh_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, dd_);
                    CqlDateTime di_ = context.Operators.Start(dh_);
                    CqlQuantity dj_ = context.Operators.Quantity(5m, "minutes");
                    CqlDateTime dk_ = context.Operators.Add(di_, dj_);
                    CqlInterval<CqlDateTime> dl_ = context.Operators.Interval(df_, dk_, false, true);
                    bool? dm_ = context.Operators.In<CqlDateTime>(dc_, dl_, default);
                    CqlInterval<CqlDateTime> do_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, dd_);
                    CqlDateTime dp_ = context.Operators.Start(do_);
                    bool? dq_ = context.Operators.Not((bool?)(dp_ is null));
                    bool? dr_ = context.Operators.And(dm_, dq_);
                    bool? ds_ = context.Operators.And(cz_, dr_);
                    Code<ObservationStatus> dt_ = FollowupBloodGlucoseLab?.StatusElement;
                    string du_ = FHIRHelpers_4_0_001.Instance.ToString(context, dt_);
                    bool? dv_ = context.Operators.Equal(du_, "final");
                    bool? dw_ = context.Operators.And(ds_, dv_);
                    string dy_ = FHIRHelpers_4_0_001.Instance.ToString(context, dt_);
                    bool? dz_ = context.Operators.Equal(dy_, "cancelled");
                    bool? ea_ = context.Operators.Not(dz_);
                    bool? eb_ = context.Operators.And(dw_, ea_);
                    DataType ec_ = FollowupBloodGlucoseLab?.Value;
                    CqlQuantity ed_ = FHIRHelpers_4_0_001.Instance.ToQuantity(context, ec_ as Quantity);
                    CqlQuantity ee_ = context.Operators.Quantity(80m, "mg/dL");
                    bool? ef_ = context.Operators.Greater(ed_, ee_);
                    bool? eg_ = context.Operators.And(eb_, ef_);

                    return eg_;
                };
                IEnumerable<Observation> cs_ = context.Operators.Where<Observation>(cq_, cr_);
                Observation ct_(Observation FollowupBloodGlucoseLab) =>
                    BloodGlucoseLab;
                IEnumerable<Observation> cu_ = context.Operators.Select<Observation, Observation>(cs_, ct_);

                return cu_;
            };
            IEnumerable<Observation> m_ = context.Operators.SelectMany<Observation, Observation>(k_, l_);
            IEnumerable<Observation> n_ = context.Operators.Except<Observation>(g_, m_);
            bool? o_(Observation BloodGlucoseLab)
            {
                DataType eh_ = BloodGlucoseLab?.Effective;
                CqlInterval<CqlDateTime> ei_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, eh_);
                CqlDateTime ej_ = context.Operators.Start(ei_);
                CqlInterval<CqlDateTime> ek_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.HospitalizationWithObservation(context, QualifyingEncounter);
                bool? el_ = context.Operators.In<CqlDateTime>(ej_, ek_, default);
                DataType em_ = BloodGlucoseLab?.Value;
                CqlQuantity en_ = FHIRHelpers_4_0_001.Instance.ToQuantity(context, em_ as Quantity);
                CqlQuantity eo_ = context.Operators.Quantity(40m, "mg/dL");
                bool? ep_ = context.Operators.Less(en_, eo_);
                bool? eq_ = context.Operators.And(el_, ep_);

                return eq_;
            };
            IEnumerable<Observation> p_ = context.Operators.Where<Observation>(n_, o_);
            bool? q_ = context.Operators.Exists<Observation>(p_);

            return q_;
        };
        IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);

        return c_;
    }



    [CqlDeclaration("Numerator")]
    public IEnumerable<Encounter> Numerator(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Severe_Hypoglycemic_Harm_Event(context);

        return a_;
    }



    [CqlDeclaration("SDE Ethnicity")]
    public IEnumerable<Coding> SDE_Ethnicity(CqlContext context)
    {
        IEnumerable<Coding> a_ = SupplementalDataElementsFHIR4_2_0_000.Instance.SDE_Ethnicity(context);

        return a_;
    }


    private static CqlTupleMetadata CqlTupleMetadata_EaLaedgLDgRRYaLbKIIcBTOiA = new(
        [typeof(Encounter), typeof(Encounter)],
        ["OutpatientEncounter1", "OutpatientEncounter2"]);

    private static CqlTupleMetadata CqlTupleMetadata_CgaDVOXeQBMgMPCPZOThIIdDb = new(
        [typeof(CqlInterval<CqlDateTime>), typeof(CqlInterval<CqlDateTime>)],
        ["LTCPeriod1", "LTCPeriod2"]);

    private static CqlTupleMetadata CqlTupleMetadata_GIMHfXDcFiAjSJBDGYeUeZLhW = new(
        [typeof(CqlInterval<CqlDate>), typeof(CqlDate)],
        ["interval", "startOfInterval"]);

    private static CqlTupleMetadata CqlTupleMetadata_EQHOUSiiWahbJPOUjJGEhIAOV = new(
        [typeof(CqlInterval<CqlDateTime>), typeof(CqlDateTime)],
        ["interval", "startOfInterval"]);

    private static CqlTupleMetadata CqlTupleMetadata_EVRLVXPcBiDTIWfCCfKEWDfKI = new(
        [typeof(IEnumerable<CqlInterval<CqlDate>>)],
        ["sortedCoverings"]);

    private static CqlTupleMetadata CqlTupleMetadata_FKcLSALRMRfDigEFaJgDOPFRK = new(
        [typeof(IEnumerable<CqlInterval<CqlDate>>), typeof(IEnumerable<CqlInterval<CqlDate>>)],
        ["frontgaps", "endgap"]);

    private static CqlTupleMetadata CqlTupleMetadata_EdgSWaTaCbLYLJceGdIcWOLHd = new(
        [typeof(IEnumerable<CqlInterval<CqlDateTime>>)],
        ["sortedCoverings"]);

    private static CqlTupleMetadata CqlTupleMetadata_BBLSSiNBQBGUDJaVjMDZMSAXg = new(
        [typeof(IEnumerable<CqlInterval<CqlDateTime>>), typeof(IEnumerable<CqlInterval<CqlDateTime>>)],
        ["frontgaps", "endgap"]);

    private static CqlTupleMetadata CqlTupleMetadata_HEjPGjPEhLgQPGjROeWMgiGfC = new(
        [typeof(CqlInterval<CqlDate>), typeof(int?)],
        ["interval", "days"]);

    private static CqlTupleMetadata CqlTupleMetadata_HRbPDRZiOGGBceePOZWjVbXdP = new(
        [typeof(IEnumerable<CqlInterval<CqlDate>>), typeof(int?), typeof(int?), typeof(CqlInterval<CqlDate>), typeof(int?)],
        ["Intervals", "Interval_Count", "Total_Days_In_Intervals", "Longest_Interval", "Total_Days_In_Longest_Interval"]);

    private static CqlTupleMetadata CqlTupleMetadata_DUiZjXRKgCPYVZQJbFVDKNMOi = new(
        [typeof(IEnumerable<CqlInterval<CqlDate>>)],
        ["Covering_Intervals"]);

    private static CqlTupleMetadata CqlTupleMetadata_GQPbYTYABjXFVLRKjXgcDJFSj = new(
        [typeof(IEnumerable<CqlInterval<CqlDate>>)],
        ["Gap_Intervals"]);

    private static CqlTupleMetadata CqlTupleMetadata_FcQREFSfPJSKYAhSEWVJcZVED = new(
        [typeof(int?), typeof(int?), typeof(int?), typeof(int?), typeof(int?), typeof(int?), typeof(int?), typeof(int?), typeof(int?), typeof(int?), typeof(int?), typeof(int?), typeof(int?), typeof(int?)],
        ["StartYear", "StartMonth", "StartDay", "StartHour", "StartMinute", "StartSecond", "StartMillisecond", "EndYear", "EndMonth", "EndDay", "EndHour", "EndMinute", "EndSecond", "EndMillisecond"]);

    private static CqlTupleMetadata CqlTupleMetadata_CGHEUIgjaCjJVKEADTSZEbdCL = new(
        [typeof(CqlInterval<CqlDateTime>), typeof(int?)],
        ["interval", "days"]);

    private static CqlTupleMetadata CqlTupleMetadata_HDihbLieYfQbgeSbOWZBAMUIQ = new(
        [typeof(IEnumerable<CqlInterval<CqlDateTime>>), typeof(int?), typeof(int?), typeof(CqlInterval<CqlDateTime>), typeof(int?)],
        ["Intervals", "Interval_Count", "Total_Days_In_Intervals", "Longest_Interval", "Total_Days_In_Longest_Interval"]);

    private static CqlTupleMetadata CqlTupleMetadata_GZMPWdGOJiTNjfWAcbZMePdXV = new(
        [typeof(IEnumerable<CqlInterval<CqlDateTime>>)],
        ["Covering_Intervals"]);

    private static CqlTupleMetadata CqlTupleMetadata_CKbERRbOPGNBBERUOghhaOYSE = new(
        [typeof(IEnumerable<CqlInterval<CqlDateTime>>)],
        ["Gap_Intervals"]);

    private static CqlTupleMetadata CqlTupleMetadata_CfANiScMYDdVZFgRERKJQEVca = new(
        [typeof(IEnumerable<CqlDate>)],
        ["SortedDates"]);

    private static CqlTupleMetadata CqlTupleMetadata_BDeBMdFeZaVSehBSFYjTFdYYD = new(
        [typeof(IEnumerable<CqlDate>), typeof(int?)],
        ["SortedList", "AnchorIndex"]);

    private static CqlTupleMetadata CqlTupleMetadata_EbRdcKZaDRhaFPaOQUGVhPhBc = new(
        [typeof(CqlDate), typeof(IEnumerable<CqlDate>), typeof(int?)],
        ["NextDate", "NewList", "IndexofNewDate"]);

    private static CqlTupleMetadata CqlTupleMetadata_BaNHUZXcQBUKLNgEDWdDHjYV = new(
        [typeof(CqlInterval<CqlDate>), typeof(CqlInterval<CqlDate>)],
        ["Coverage1", "Coverage2"]);

    private static CqlTupleMetadata CqlTupleMetadata_DPLIOBaSciHAAETJOMSIjWgbP = new(
        [typeof(IEnumerable<CqlInterval<CqlDate>>), typeof(IEnumerable<CqlInterval<CqlDate>>), typeof(IEnumerable<CqlInterval<CqlDate>>), typeof(IEnumerable<CqlInterval<CqlDate>>)],
        ["IntervalInfo", "Collapsed", "Adjacent", "CollapsedFinal"]);

    private static CqlTupleMetadata CqlTupleMetadata_GIgcTXSQJbIXPiNgNbAIdOBXi = new(
        [typeof(IEnumerable<Claim>), typeof(IEnumerable<string>), typeof(IEnumerable<string>)],
        ["MedicalClaim", "ProceduresAsStrings", "POSAsString"]);

    private static CqlTupleMetadata CqlTupleMetadata_HSdidNdfHCNCFSUTgBiYLcgXP = new(
        [typeof(Claim), typeof(IEnumerable<Claim.ItemComponent>)],
        ["Claim", "LineItems"]);

    private static CqlTupleMetadata CqlTupleMetadata_GDUUTAIXZafehWFjcGfNKBcTd = new(
        [typeof(Claim), typeof(IEnumerable<CqlInterval<CqlDateTime>>)],
        ["Claim", "ServicePeriod"]);

    private static CqlTupleMetadata CqlTupleMetadata_GKQGAFOMQbCPRXAANKASUIHMf = new(
        [typeof(IEnumerable<Claim>), typeof(IEnumerable<string>)],
        ["MedicalClaim", "DiagnosesAsStrings"]);

    private static CqlTupleMetadata CqlTupleMetadata_GDVcejYEWXWNHUIODacaMaBhV = new(
        [typeof(IEnumerable<Claim>)],
        ["DiagnosisItems"]);

    private static CqlTupleMetadata CqlTupleMetadata_CWDDWHRXGADEbdaKXCdKbgEfg = new(
        [typeof(IEnumerable<Claim>), typeof(IEnumerable<CqlInterval<CqlDateTime>>)],
        ["Claim", "ServicePeriod"]);

    private static CqlTupleMetadata CqlTupleMetadata_CZJDcULSYFOUeGSUcDccghjMK = new(
        [typeof(IEnumerable<Claim>), typeof(IEnumerable<string>)],
        ["PharmacyClaim", "MedicationsAsStrings"]);

    private static CqlTupleMetadata CqlTupleMetadata_HDUYFgZGRCJCdTeEcMSVCMQNN = new(
        [typeof(CqlInterval<CqlDateTime>)],
        ["DaysSupplyInterval"]);

    private static CqlTupleMetadata CqlTupleMetadata_fQfNOLePNSNdOZROKRAfMQPE = new(
        [typeof(IEnumerable<(CqlTupleMetadata, CqlInterval<CqlDateTime> DaysSupplyInterval)?>)],
        ["CoveredDays"]);

    private static CqlTupleMetadata CqlTupleMetadata_FCdHTREUGBEaiYVQNNGRPZFjf = new(
        [typeof(Claim), typeof(IEnumerable<Claim.ItemComponent>), typeof(IEnumerable<CqlInterval<CqlDateTime>>), typeof(IEnumerable<CqlInterval<CqlDateTime>>)],
        ["Claim", "LineItem", "ServicePeriod", "CoveredDays"]);

    private static CqlTupleMetadata CqlTupleMetadata_GQFgMiKhOZgECFTScigSABdXb = new(
        [typeof(IEnumerable<Claim>), typeof(IEnumerable<string>), typeof(IEnumerable<string>)],
        ["MedicalClaim", "DiagnosesAsStrings", "ProceduresAsStrings"]);

    private static CqlTupleMetadata CqlTupleMetadata_CXESjjTOQIGKICAEMDgcfPdJG = new(
        [typeof(Claim)],
        ["ProcedureItems"]);

    private static CqlTupleMetadata CqlTupleMetadata_FYaKYiIDIQCIRBfhZCGRDYQLX = new(
        [typeof(Claim), typeof(Claim)],
        ["Claim", "ProcedureItems"]);

    private static CqlTupleMetadata CqlTupleMetadata_iYTJVNYRMBhJCKDIUSKFMUHe = new(
        [typeof(IEnumerable<Claim.ItemComponent>), typeof(Claim)],
        ["Procedure", "LineItems"]);

    private static CqlTupleMetadata CqlTupleMetadata_DBEDLLOihLKGPWLHVWXRKfGdL = new(
        [typeof(IEnumerable<Claim>)],
        ["LineItems"]);

    private static CqlTupleMetadata CqlTupleMetadata_ESGibVhJBKTGTjRhHBeNDHASE = new(
        [typeof(IEnumerable<ClaimResponse>), typeof(IEnumerable<Claim>)],
        ["MedicalClaimResponse", "MedicalClaim"]);

    private static CqlTupleMetadata CqlTupleMetadata_DbDPVOODdCjASWRZfBTBPUJKR = new(
        [typeof(IEnumerable<ClaimResponse>)],
        ["PaidResponse"]);

    private static CqlTupleMetadata CqlTupleMetadata_FfbRdLZNBbFHejZXDegUDAhjO = new(
        [typeof(ClaimResponse), typeof(string), typeof(IEnumerable<ClaimResponse.ItemComponent>)],
        ["Response", "ResponseID", "LineItems"]);

    private static CqlTupleMetadata CqlTupleMetadata_GUCaFdHVHVNcfKfMNEFbbNGUi = new(
        [typeof(Claim), typeof(Id), typeof(IEnumerable<Claim.ItemComponent>)],
        ["ClaimofInterest", "ClaimID", "LineItems"]);

    private static CqlTupleMetadata CqlTupleMetadata_DiTbeIhUdTbFXAOeUfBeANOcV = new(
        [typeof(IEnumerable<(CqlTupleMetadata, ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)?>), typeof(IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?>)],
        ["PaidMedicalClaimResponse", "MedicalClaim"]);

    private static CqlTupleMetadata CqlTupleMetadata_HANAFPgdEHHITIiaCbHRMCNfZ = new(
        [typeof((CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?), typeof(IEnumerable<Claim.ItemComponent>)],
        ["PaidClaim", "ClaimItem"]);

    private static CqlTupleMetadata CqlTupleMetadata_GUibhjYMgjAQISFDJORUOccJC = new(
        [typeof(IEnumerable<(CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?>)],
        ["AggregateClaim"]);

    private static CqlTupleMetadata CqlTupleMetadata_FCOUVKRRWVHcKiBDUdGgLciKR = new(
        [typeof(IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?>), typeof(IEnumerable<CqlInterval<CqlDateTime>>)],
        ["originalClaim", "ServicePeriod"]);

    private static CqlTupleMetadata CqlTupleMetadata_EgMIjgYNSTYejjeaeeSfTCGLV = new(
        [typeof(IEnumerable<ClaimResponse>), typeof(IEnumerable<Claim>)],
        ["PharmacyClaimResponse", "PharmacyClaim"]);

    private static CqlTupleMetadata CqlTupleMetadata_EhcebFbUeFgabTLNPALjRJQCF = new(
        [typeof(IEnumerable<(CqlTupleMetadata, ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)?>), typeof(IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)?>)],
        ["PaidPharmacyClaimResponse", "MedicalClaim"]);

    private static CqlTupleMetadata CqlTupleMetadata_BiVTcKEZOfgFCDEReGAXJRAUK = new(
        [typeof((CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)?), typeof(IEnumerable<Claim.ItemComponent>)],
        ["PaidClaim", "ClaimItem"]);

    private static CqlTupleMetadata CqlTupleMetadata_EMbbXAAHNDcXYSgLIhAhQCWON = new(
        [typeof(IEnumerable<(CqlTupleMetadata, (CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?>)],
        ["AggregateClaim"]);

    private static CqlTupleMetadata CqlTupleMetadata_DXGMEVDRBZgHMANCfXfEUYMNW = new(
        [typeof(IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)?>), typeof(IEnumerable<CqlInterval<CqlDateTime>>), typeof(IEnumerable<CqlInterval<CqlDate>>)],
        ["originalClaim", "ServicePeriod", "CoveredDays"]);

    private static CqlTupleMetadata CqlTupleMetadata_CZThYJbgajVLdhIZdgZiXBFQK = new(
        [typeof(IEnumerable<ClaimResponse>), typeof(IEnumerable<Claim>)],
        ["ClaimResponse", "OriginalClaim"]);

    private static CqlTupleMetadata CqlTupleMetadata_GFUjSKcYaHagAZIhSUhffHjHP = new(
        [typeof(IEnumerable<Claim>), typeof(IEnumerable<Claim>)],
        ["InpatientStayLineItems", "NonacuteInpatientLineItems"]);

    private static CqlTupleMetadata CqlTupleMetadata_DBGUUNgWTQDYFIeOfMhQJAYTB = new(
        [typeof(IEnumerable<Claim>), typeof(IEnumerable<Claim>), typeof(IEnumerable<Claim>)],
        ["InpatientDischarge", "NonacuteInpatientDischarge", "AcuteInpatientDischarge"]);

    private static CqlTupleMetadata CqlTupleMetadata_BWiFKXdFieUciRMVTUCdIFCVO = new(
        [typeof(Claim), typeof(IEnumerable<ResourceReference>), typeof(IEnumerable<string>)],
        ["SingleCareTeam", "CareTeamsProvider", "CareTeamsProviderID"]);

    private static CqlTupleMetadata CqlTupleMetadata_HFNJUcNhcbGBLBgHAJMMSPfQH = new(
        [typeof(IEnumerable<(CqlTupleMetadata, Claim SingleCareTeam, IEnumerable<ResourceReference> CareTeamsProvider, IEnumerable<string> CareTeamsProviderID)?>)],
        ["CareTeams"]);

    private static CqlTupleMetadata CqlTupleMetadata_FPVdJEEOUKFVhQPTfKhShUNO = new(
        [typeof(IEnumerable<Practitioner>)],
        ["Practitioners"]);

    private static CqlTupleMetadata CqlTupleMetadata_EheHUARRFfQdCcHKeSEhfYZMj = new(
        [typeof(IEnumerable<FhirString>), typeof(IEnumerable<Identifier>)],
        ["AllIdentifiers", "NullIdentifiers"]);

    private static CqlTupleMetadata CqlTupleMetadata_EZUSISLPSZWTXahaQjXaSAJBE = new(
        [typeof(IEnumerable<(CqlTupleMetadata, IEnumerable<FhirString> AllIdentifiers, IEnumerable<Identifier> NullIdentifiers)?>)],
        ["IdentifierTuple"]);

    private static CqlTupleMetadata CqlTupleMetadata_FBUdWLSDMgYFFiVXYhKEiUNQS = new(
        [typeof(int?)],
        ["IdentifierCount"]);

    private static CqlTupleMetadata CqlTupleMetadata_gFQSaDQdhfIVgTfEbUhWdbBB = new(
        [typeof(IEnumerable<Claim.ItemComponent>), typeof(IEnumerable<ResourceReference>), typeof(IEnumerable<string>)],
        ["SingleItem", "ItemLocation", "ItemLocationID"]);

    private static CqlTupleMetadata CqlTupleMetadata_ESTVjUCCVhLEXJGPZBeEcQDHX = new(
        [typeof(IEnumerable<(CqlTupleMetadata, IEnumerable<Claim.ItemComponent> SingleItem, IEnumerable<ResourceReference> ItemLocation, IEnumerable<string> ItemLocationID)?>)],
        ["ItemsLocationReferences"]);

    private static CqlTupleMetadata CqlTupleMetadata_GWYcfjEGjPEdPbTNdfROfTUAf = new(
        [typeof(IEnumerable<Location>)],
        ["CorrespondingLocations"]);

    private static CqlTupleMetadata CqlTupleMetadata_CMSeRgTJgKISKSQUcNZWKegGV = new(
        [typeof(CqlDate), typeof(CqlDate)],
        ["OutpatientVisit1", "OutpatientVisit2"]);

    private static CqlTupleMetadata CqlTupleMetadata_CaKghTfWMNOTHSWhifjFZOVYO = new(
        [typeof(CodeableConcept), typeof(Period)],
        ["code", "period"]);

    private static CqlTupleMetadata CqlTupleMetadata_iQFMKTdMMJMRBOfEdfhTYDJV = new(
        [typeof(CqlDateTime), typeof(IEnumerable<FhirString>), typeof(IEnumerable<string>), typeof(Code<ObservationStatus>)],
        ["occultDate", "occultResult", "occultCategoryCode", "occultStatus"]);

    private static CqlTupleMetadata CqlTupleMetadata_GPLfQTPONQabPZigKbYFERDVQ = new(
        [typeof(Encounter), typeof(CqlInterval<CqlDateTime>)],
        ["encounter", "hospitalizationPeriod"]);

    private static CqlTupleMetadata CqlTupleMetadata_CLXCRdeeSPOVHRdOZOXQZeIEB = new(
        [typeof((CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod)?), typeof(MedicationAdministration)],
        ["EncounterWithHospitalization", "HypoglycemicMedication"]);

    private static CqlTupleMetadata CqlTupleMetadata_ddJhZGNHefSCOAJJFEIEcXie = new(
        [typeof(int?), typeof(CqlInterval<CqlDateTime>)],
        ["dayIndex", "dayPeriod"]);

    private static CqlTupleMetadata CqlTupleMetadata_GPAhHPfDKIJRYDEIWbaMLZGHU = new(
        [typeof(Encounter), typeof(CqlInterval<CqlDateTime>), typeof(CqlInterval<CqlDateTime>), typeof(IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod)?>)],
        ["encounter", "hospitalizationPeriod", "relevantPeriod", "relevantDays"]);

    private static CqlTupleMetadata CqlTupleMetadata_DRKKGhBGYfEMJaNePAIEJiGe = new(
        [typeof(int?), typeof(CqlInterval<CqlDateTime>), typeof(bool?), typeof(bool?), typeof(bool?)],
        ["dayIndex", "dayPeriod", "hasSevereResult", "hasElevatedResult", "hasNoResult"]);

    private static CqlTupleMetadata CqlTupleMetadata_BEJFJZgXEOCibEHSLPSMaRGGM = new(
        [typeof(Encounter), typeof(CqlInterval<CqlDateTime>), typeof(IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasSevereResult, bool? hasElevatedResult, bool? hasNoResult)?>)],
        ["encounter", "relevantPeriod", "relevantDays"]);

    private static CqlTupleMetadata CqlTupleMetadata_FNeERNKXWKJeEjWXREHDLePdY = new(
        [typeof(int?), typeof(CqlInterval<CqlDateTime>), typeof(bool?)],
        ["dayIndex", "dayPeriod", "hasHyperglycemicEvent"]);

    private static CqlTupleMetadata CqlTupleMetadata_GJFejXJaZWjRVYgMbQUZgIPjK = new(
        [typeof(Encounter), typeof(CqlInterval<CqlDateTime>), typeof(IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)?>)],
        ["encounter", "relevantPeriod", "eligibleEventDays"]);

}

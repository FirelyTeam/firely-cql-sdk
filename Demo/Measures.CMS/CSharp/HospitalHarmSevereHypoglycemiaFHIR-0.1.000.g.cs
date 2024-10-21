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

[System.CodeDom.Compiler.GeneratedCode(".NET Code Generation", "2.0.6.0")]
[CqlLibrary("HospitalHarmSevereHypoglycemiaFHIR", "0.1.000")]
public partial class HospitalHarmSevereHypoglycemiaFHIR_0_1_000 : ILibrary, ISingleton<HospitalHarmSevereHypoglycemiaFHIR_0_1_000>
{
    private HospitalHarmSevereHypoglycemiaFHIR_0_1_000() {}

    public static HospitalHarmSevereHypoglycemiaFHIR_0_1_000 Instance { get; } = new();

    #region Library Members
    public string Name => "HospitalHarmSevereHypoglycemiaFHIR";
    public string Version => "0.1.000";
    public ILibrary[] Dependencies => [SupplementalDataElements_3_4_000.Instance, CQMCommon_2_0_000.Instance, QICoreCommon_2_0_000.Instance, FHIRHelpers_4_3_000.Instance];
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


    [CqlDeclaration("Glucose Lab Test Mass Per Volume")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1248.34")]
    public CqlValueSet Glucose_Lab_Test_Mass_Per_Volume(CqlContext context) => 
        new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1248.34", default);


    [CqlDeclaration("Hypoglycemics Severe Hypoglycemia")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1196.393")]
    public CqlValueSet Hypoglycemics_Severe_Hypoglycemia(CqlContext context) => 
        new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1196.393", default);


    [CqlDeclaration("Observation Services")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1111.143")]
    public CqlValueSet Observation_Services(CqlContext context) => 
        new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1111.143", default);


    [CqlDeclaration("Measurement Period")]
    public CqlInterval<CqlDateTime> Measurement_Period(CqlContext context)
    {
        CqlDateTime a_ = context.Operators.DateTime(2025, 1, 1, 0, 0, 0, 0, default);
        CqlDateTime b_ = context.Operators.DateTime(2026, 1, 1, 0, 0, 0, 0, default);
        CqlInterval<CqlDateTime> c_ = context.Operators.Interval(a_, b_, true, false);
        object d_ = context.ResolveParameter("HospitalHarmSevereHypoglycemiaFHIR-0.1.000", "Measurement Period", c_);

        return (CqlInterval<CqlDateTime>)d_;
    }


    [CqlDeclaration("Patient")]
    public Patient Patient(CqlContext context)
    {
        IEnumerable<Patient> a_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-patient"));
        Patient b_ = context.Operators.SingletonFrom<Patient>(a_);

        return b_;
    }


    [CqlDeclaration("Qualifying Encounter")]
    public IEnumerable<Encounter> Qualifying_Encounter(CqlContext context)
    {
        CqlValueSet a_ = this.Encounter_Inpatient(context);
        IEnumerable<Encounter> b_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        bool? c_(Encounter InpatientEncounter)
        {
            Patient e_ = this.Patient(context);
            Date f_ = e_?.BirthDateElement;
            string g_ = f_?.Value;
            CqlDate h_ = context.Operators.ConvertStringToDate(g_);
            Period i_ = InpatientEncounter?.Period;
            CqlInterval<CqlDateTime> j_ = FHIRHelpers_4_3_000.Instance.ToInterval(context, i_);
            CqlDateTime k_ = context.Operators.Start(j_);
            CqlDate l_ = context.Operators.DateFrom(k_);
            int? m_ = context.Operators.CalculateAgeAt(h_, l_, "year");
            bool? n_ = context.Operators.GreaterOrEqual(m_, 18);
            CqlInterval<CqlDateTime> p_ = FHIRHelpers_4_3_000.Instance.ToInterval(context, i_);
            CqlDateTime q_ = context.Operators.End(p_);
            CqlInterval<CqlDateTime> r_ = this.Measurement_Period(context);
            bool? s_ = context.Operators.In<CqlDateTime>(q_, r_, "day");
            bool? t_ = context.Operators.And(n_, s_);
            Code<Encounter.EncounterStatus> u_ = InpatientEncounter?.StatusElement;
            Encounter.EncounterStatus? v_ = u_?.Value;
            Code<Encounter.EncounterStatus> w_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(v_);
            bool? x_ = context.Operators.Equal(w_, "finished");
            bool? y_ = context.Operators.And(t_, x_);

            return y_;
        };
        IEnumerable<Encounter> d_ = context.Operators.Where<Encounter>(b_, c_);

        return d_;
    }


    [CqlDeclaration("Hypoglycemic Medication Administration")]
    public IEnumerable<MedicationAdministration> Hypoglycemic_Medication_Administration(CqlContext context)
    {
        CqlValueSet a_ = this.Hypoglycemics_Severe_Hypoglycemia(context);
        IEnumerable<MedicationAdministration> b_ = context.Operators.Retrieve<MedicationAdministration>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationadministration"));
        IEnumerable<MedicationAdministration> d_ = context.Operators.Retrieve<MedicationAdministration>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationadministration"));
        IEnumerable<MedicationAdministration> e_ = context.Operators.Union<MedicationAdministration>(b_, d_);
        bool? f_(MedicationAdministration HypoMedication)
        {
            Code<MedicationAdministration.MedicationAdministrationStatusCodes> h_ = HypoMedication?.StatusElement;
            MedicationAdministration.MedicationAdministrationStatusCodes? i_ = h_?.Value;
            Code<MedicationAdministration.MedicationAdministrationStatusCodes> j_ = context.Operators.Convert<Code<MedicationAdministration.MedicationAdministrationStatusCodes>>(i_);
            bool? k_ = context.Operators.Equal(j_, "completed");
            MedicationAdministration.MedicationAdministrationStatusCodes? m_ = h_?.Value;
            Code<MedicationAdministration.MedicationAdministrationStatusCodes> n_ = context.Operators.Convert<Code<MedicationAdministration.MedicationAdministrationStatusCodes>>(m_);
            bool? o_ = context.Operators.Equal(n_, "not-done");
            bool? p_ = context.Operators.Not(o_);
            bool? q_ = context.Operators.And(k_, p_);

            return q_;
        };
        IEnumerable<MedicationAdministration> g_ = context.Operators.Where<MedicationAdministration>(e_, f_);

        return g_;
    }


    [CqlDeclaration("Encounter with Hypoglycemic Medication Administration")]
    public IEnumerable<Encounter> Encounter_with_Hypoglycemic_Medication_Administration(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Qualifying_Encounter(context);
        IEnumerable<Encounter> b_(Encounter InpatientHospitalization)
        {
            IEnumerable<MedicationAdministration> d_ = this.Hypoglycemic_Medication_Administration(context);
            bool? e_(MedicationAdministration HypoglycemicMedication)
            {
                DataType i_ = HypoglycemicMedication?.Effective;
                object j_ = FHIRHelpers_4_3_000.Instance.ToValue(context, i_);
                CqlInterval<CqlDateTime> k_ = QICoreCommon_2_0_000.Instance.ToInterval(context, j_);
                CqlDateTime l_ = context.Operators.Start(k_);
                CqlInterval<CqlDateTime> m_ = CQMCommon_2_0_000.Instance.HospitalizationWithObservation(context, InpatientHospitalization);
                bool? n_ = context.Operators.In<CqlDateTime>(l_, m_, default);

                return n_;
            };
            IEnumerable<MedicationAdministration> f_ = context.Operators.Where<MedicationAdministration>(d_, e_);
            Encounter g_(MedicationAdministration HypoglycemicMedication) => 
                InpatientHospitalization;
            IEnumerable<Encounter> h_ = context.Operators.Select<MedicationAdministration, Encounter>(f_, g_);

            return h_;
        };
        IEnumerable<Encounter> c_ = context.Operators.SelectMany<Encounter, Encounter>(a_, b_);

        return c_;
    }


    [CqlDeclaration("Initial Population")]
    public IEnumerable<Encounter> Initial_Population(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Encounter_with_Hypoglycemic_Medication_Administration(context);

        return a_;
    }


    [CqlDeclaration("Denominator")]
    public IEnumerable<Encounter> Denominator(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Initial_Population(context);

        return a_;
    }


    [CqlDeclaration("Glucose Test with Result Less Than 40")]
    public IEnumerable<Observation> Glucose_Test_with_Result_Less_Than_40(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Denominator(context);
        IEnumerable<MedicationAdministration> b_ = this.Hypoglycemic_Medication_Administration(context);
        CqlValueSet c_ = this.Glucose_Lab_Test_Mass_Per_Volume(context);
        IEnumerable<Observation> d_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, c_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
        IEnumerable<ValueTuple<Encounter, MedicationAdministration, Observation>> e_ = context.Operators.CrossJoin<Encounter, MedicationAdministration, Observation>(a_, b_, d_);
        (CqlTupleMetadata, Encounter QualifyingEncounter, MedicationAdministration HypoglycemicMedication, Observation GlucoseTest)? f_(ValueTuple<Encounter, MedicationAdministration, Observation> _valueTuple)
        {
            (CqlTupleMetadata, Encounter QualifyingEncounter, MedicationAdministration HypoglycemicMedication, Observation GlucoseTest)? l_ = (CqlTupleMetadata_BTYMMDGaChdRaGRhOfgXBXGHO, _valueTuple.Item1, _valueTuple.Item2, _valueTuple.Item3);

            return l_;
        };
        IEnumerable<(CqlTupleMetadata, Encounter QualifyingEncounter, MedicationAdministration HypoglycemicMedication, Observation GlucoseTest)?> g_ = context.Operators.Select<ValueTuple<Encounter, MedicationAdministration, Observation>, (CqlTupleMetadata, Encounter QualifyingEncounter, MedicationAdministration HypoglycemicMedication, Observation GlucoseTest)?>(e_, f_);
        bool? h_((CqlTupleMetadata, Encounter QualifyingEncounter, MedicationAdministration HypoglycemicMedication, Observation GlucoseTest)? tuple_btymmdgachdragrhofgxbxgho)
        {
            object m_()
            {
                bool at_()
                {
                    DataType aw_ = tuple_btymmdgachdragrhofgxbxgho?.GlucoseTest?.Effective;
                    object ax_ = FHIRHelpers_4_3_000.Instance.ToValue(context, aw_);
                    bool ay_ = ax_ is CqlDateTime;

                    return ay_;
                };
                bool au_()
                {
                    DataType az_ = tuple_btymmdgachdragrhofgxbxgho?.GlucoseTest?.Effective;
                    object ba_ = FHIRHelpers_4_3_000.Instance.ToValue(context, az_);
                    bool bb_ = ba_ is CqlInterval<CqlDateTime>;

                    return bb_;
                };
                bool av_()
                {
                    DataType bc_ = tuple_btymmdgachdragrhofgxbxgho?.GlucoseTest?.Effective;
                    object bd_ = FHIRHelpers_4_3_000.Instance.ToValue(context, bc_);
                    bool be_ = bd_ is CqlDateTime;

                    return be_;
                };
                if (at_())
                {
                    DataType bf_ = tuple_btymmdgachdragrhofgxbxgho?.GlucoseTest?.Effective;
                    object bg_ = FHIRHelpers_4_3_000.Instance.ToValue(context, bf_);

                    return (bg_ as CqlDateTime) as object;
                }
                else if (au_())
                {
                    DataType bh_ = tuple_btymmdgachdragrhofgxbxgho?.GlucoseTest?.Effective;
                    object bi_ = FHIRHelpers_4_3_000.Instance.ToValue(context, bh_);

                    return (bi_ as CqlInterval<CqlDateTime>) as object;
                }
                else if (av_())
                {
                    DataType bj_ = tuple_btymmdgachdragrhofgxbxgho?.GlucoseTest?.Effective;
                    object bk_ = FHIRHelpers_4_3_000.Instance.ToValue(context, bj_);

                    return (bk_ as CqlDateTime) as object;
                }
                else
                {
                    return null;
                }
            };
            CqlDateTime n_ = QICoreCommon_2_0_000.Instance.Earliest(context, m_());
            CqlInterval<CqlDateTime> o_ = CQMCommon_2_0_000.Instance.HospitalizationWithObservation(context, tuple_btymmdgachdragrhofgxbxgho?.QualifyingEncounter);
            bool? p_ = context.Operators.In<CqlDateTime>(n_, o_, default);
            Code<ObservationStatus> q_ = tuple_btymmdgachdragrhofgxbxgho?.GlucoseTest?.StatusElement;
            ObservationStatus? r_ = q_?.Value;
            Code<ObservationStatus> s_ = context.Operators.Convert<Code<ObservationStatus>>(r_);
            string t_ = context.Operators.Convert<string>(s_);
            string[] u_ = [
                "final",
                "amended",
                "corrected",
            ];
            bool? v_ = context.Operators.In<string>(t_, u_ as IEnumerable<string>);
            bool? w_ = context.Operators.And(p_, v_);
            DataType x_ = tuple_btymmdgachdragrhofgxbxgho?.GlucoseTest?.Value;
            object y_ = FHIRHelpers_4_3_000.Instance.ToValue(context, x_);
            CqlQuantity z_ = context.Operators.Quantity(40m, "mg/dL");
            bool? aa_ = context.Operators.Less(y_ as CqlQuantity, z_);
            bool? ab_ = context.Operators.And(w_, aa_);
            DataType ac_ = tuple_btymmdgachdragrhofgxbxgho?.HypoglycemicMedication?.Effective;
            object ad_ = FHIRHelpers_4_3_000.Instance.ToValue(context, ac_);
            CqlInterval<CqlDateTime> ae_ = QICoreCommon_2_0_000.Instance.ToInterval(context, ad_);
            CqlDateTime af_ = context.Operators.Start(ae_);
            object ag_()
            {
                bool bl_()
                {
                    DataType bo_ = tuple_btymmdgachdragrhofgxbxgho?.GlucoseTest?.Effective;
                    object bp_ = FHIRHelpers_4_3_000.Instance.ToValue(context, bo_);
                    bool bq_ = bp_ is CqlDateTime;

                    return bq_;
                };
                bool bm_()
                {
                    DataType br_ = tuple_btymmdgachdragrhofgxbxgho?.GlucoseTest?.Effective;
                    object bs_ = FHIRHelpers_4_3_000.Instance.ToValue(context, br_);
                    bool bt_ = bs_ is CqlInterval<CqlDateTime>;

                    return bt_;
                };
                bool bn_()
                {
                    DataType bu_ = tuple_btymmdgachdragrhofgxbxgho?.GlucoseTest?.Effective;
                    object bv_ = FHIRHelpers_4_3_000.Instance.ToValue(context, bu_);
                    bool bw_ = bv_ is CqlDateTime;

                    return bw_;
                };
                if (bl_())
                {
                    DataType bx_ = tuple_btymmdgachdragrhofgxbxgho?.GlucoseTest?.Effective;
                    object by_ = FHIRHelpers_4_3_000.Instance.ToValue(context, bx_);

                    return (by_ as CqlDateTime) as object;
                }
                else if (bm_())
                {
                    DataType bz_ = tuple_btymmdgachdragrhofgxbxgho?.GlucoseTest?.Effective;
                    object ca_ = FHIRHelpers_4_3_000.Instance.ToValue(context, bz_);

                    return (ca_ as CqlInterval<CqlDateTime>) as object;
                }
                else if (bn_())
                {
                    DataType cb_ = tuple_btymmdgachdragrhofgxbxgho?.GlucoseTest?.Effective;
                    object cc_ = FHIRHelpers_4_3_000.Instance.ToValue(context, cb_);

                    return (cc_ as CqlDateTime) as object;
                }
                else
                {
                    return null;
                }
            };
            CqlDateTime ah_ = QICoreCommon_2_0_000.Instance.Earliest(context, ag_());
            CqlQuantity ai_ = context.Operators.Quantity(24m, "hours");
            CqlDateTime aj_ = context.Operators.Subtract(ah_, ai_);
            object ak_()
            {
                bool cd_()
                {
                    DataType cg_ = tuple_btymmdgachdragrhofgxbxgho?.GlucoseTest?.Effective;
                    object ch_ = FHIRHelpers_4_3_000.Instance.ToValue(context, cg_);
                    bool ci_ = ch_ is CqlDateTime;

                    return ci_;
                };
                bool ce_()
                {
                    DataType cj_ = tuple_btymmdgachdragrhofgxbxgho?.GlucoseTest?.Effective;
                    object ck_ = FHIRHelpers_4_3_000.Instance.ToValue(context, cj_);
                    bool cl_ = ck_ is CqlInterval<CqlDateTime>;

                    return cl_;
                };
                bool cf_()
                {
                    DataType cm_ = tuple_btymmdgachdragrhofgxbxgho?.GlucoseTest?.Effective;
                    object cn_ = FHIRHelpers_4_3_000.Instance.ToValue(context, cm_);
                    bool co_ = cn_ is CqlDateTime;

                    return co_;
                };
                if (cd_())
                {
                    DataType cp_ = tuple_btymmdgachdragrhofgxbxgho?.GlucoseTest?.Effective;
                    object cq_ = FHIRHelpers_4_3_000.Instance.ToValue(context, cp_);

                    return (cq_ as CqlDateTime) as object;
                }
                else if (ce_())
                {
                    DataType cr_ = tuple_btymmdgachdragrhofgxbxgho?.GlucoseTest?.Effective;
                    object cs_ = FHIRHelpers_4_3_000.Instance.ToValue(context, cr_);

                    return (cs_ as CqlInterval<CqlDateTime>) as object;
                }
                else if (cf_())
                {
                    DataType ct_ = tuple_btymmdgachdragrhofgxbxgho?.GlucoseTest?.Effective;
                    object cu_ = FHIRHelpers_4_3_000.Instance.ToValue(context, ct_);

                    return (cu_ as CqlDateTime) as object;
                }
                else
                {
                    return null;
                }
            };
            CqlDateTime al_ = QICoreCommon_2_0_000.Instance.Earliest(context, ak_());
            CqlInterval<CqlDateTime> am_ = context.Operators.Interval(aj_, al_, true, true);
            bool? an_ = context.Operators.In<CqlDateTime>(af_, am_, default);
            object ao_()
            {
                bool cv_()
                {
                    DataType cy_ = tuple_btymmdgachdragrhofgxbxgho?.GlucoseTest?.Effective;
                    object cz_ = FHIRHelpers_4_3_000.Instance.ToValue(context, cy_);
                    bool da_ = cz_ is CqlDateTime;

                    return da_;
                };
                bool cw_()
                {
                    DataType db_ = tuple_btymmdgachdragrhofgxbxgho?.GlucoseTest?.Effective;
                    object dc_ = FHIRHelpers_4_3_000.Instance.ToValue(context, db_);
                    bool dd_ = dc_ is CqlInterval<CqlDateTime>;

                    return dd_;
                };
                bool cx_()
                {
                    DataType de_ = tuple_btymmdgachdragrhofgxbxgho?.GlucoseTest?.Effective;
                    object df_ = FHIRHelpers_4_3_000.Instance.ToValue(context, de_);
                    bool dg_ = df_ is CqlDateTime;

                    return dg_;
                };
                if (cv_())
                {
                    DataType dh_ = tuple_btymmdgachdragrhofgxbxgho?.GlucoseTest?.Effective;
                    object di_ = FHIRHelpers_4_3_000.Instance.ToValue(context, dh_);

                    return (di_ as CqlDateTime) as object;
                }
                else if (cw_())
                {
                    DataType dj_ = tuple_btymmdgachdragrhofgxbxgho?.GlucoseTest?.Effective;
                    object dk_ = FHIRHelpers_4_3_000.Instance.ToValue(context, dj_);

                    return (dk_ as CqlInterval<CqlDateTime>) as object;
                }
                else if (cx_())
                {
                    DataType dl_ = tuple_btymmdgachdragrhofgxbxgho?.GlucoseTest?.Effective;
                    object dm_ = FHIRHelpers_4_3_000.Instance.ToValue(context, dl_);

                    return (dm_ as CqlDateTime) as object;
                }
                else
                {
                    return null;
                }
            };
            CqlDateTime ap_ = QICoreCommon_2_0_000.Instance.Earliest(context, ao_());
            bool? aq_ = context.Operators.Not((bool?)(ap_ is null));
            bool? ar_ = context.Operators.And(an_, aq_);
            bool? as_ = context.Operators.And(ab_, ar_);

            return as_;
        };
        IEnumerable<(CqlTupleMetadata, Encounter QualifyingEncounter, MedicationAdministration HypoglycemicMedication, Observation GlucoseTest)?> i_ = context.Operators.Where<(CqlTupleMetadata, Encounter QualifyingEncounter, MedicationAdministration HypoglycemicMedication, Observation GlucoseTest)?>(g_, h_);
        Observation j_((CqlTupleMetadata, Encounter QualifyingEncounter, MedicationAdministration HypoglycemicMedication, Observation GlucoseTest)? tuple_btymmdgachdragrhofgxbxgho) => 
            tuple_btymmdgachdragrhofgxbxgho?.GlucoseTest;
        IEnumerable<Observation> k_ = context.Operators.Select<(CqlTupleMetadata, Encounter QualifyingEncounter, MedicationAdministration HypoglycemicMedication, Observation GlucoseTest)?, Observation>(i_, j_);

        return k_;
    }


    [CqlDeclaration("Low Glucose Test Followed By Glucose Test Result Greater Than 80")]
    public IEnumerable<Observation> Low_Glucose_Test_Followed_By_Glucose_Test_Result_Greater_Than_80(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Denominator(context);
        IEnumerable<Observation> b_ = this.Glucose_Test_with_Result_Less_Than_40(context);
        CqlValueSet c_ = this.Glucose_Lab_Test_Mass_Per_Volume(context);
        IEnumerable<Observation> d_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, c_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
        IEnumerable<ValueTuple<Encounter, Observation, Observation>> e_ = context.Operators.CrossJoin<Encounter, Observation, Observation>(a_, b_, d_);
        (CqlTupleMetadata, Encounter QualifyingEncounter, Observation LowGlucoseTest, Observation FollowupGlucoseTest)? f_(ValueTuple<Encounter, Observation, Observation> _valueTuple)
        {
            (CqlTupleMetadata, Encounter QualifyingEncounter, Observation LowGlucoseTest, Observation FollowupGlucoseTest)? l_ = (CqlTupleMetadata_CLLJQcGdEjTDiIeWKZYJPWaPd, _valueTuple.Item1, _valueTuple.Item2, _valueTuple.Item3);

            return l_;
        };
        IEnumerable<(CqlTupleMetadata, Encounter QualifyingEncounter, Observation LowGlucoseTest, Observation FollowupGlucoseTest)?> g_ = context.Operators.Select<ValueTuple<Encounter, Observation, Observation>, (CqlTupleMetadata, Encounter QualifyingEncounter, Observation LowGlucoseTest, Observation FollowupGlucoseTest)?>(e_, f_);
        bool? h_((CqlTupleMetadata, Encounter QualifyingEncounter, Observation LowGlucoseTest, Observation FollowupGlucoseTest)? tuple_clljqcgdejtdiiewkzyjpwapd)
        {
            object m_()
            {
                bool bd_()
                {
                    DataType bg_ = tuple_clljqcgdejtdiiewkzyjpwapd?.FollowupGlucoseTest?.Effective;
                    object bh_ = FHIRHelpers_4_3_000.Instance.ToValue(context, bg_);
                    bool bi_ = bh_ is CqlDateTime;

                    return bi_;
                };
                bool be_()
                {
                    DataType bj_ = tuple_clljqcgdejtdiiewkzyjpwapd?.FollowupGlucoseTest?.Effective;
                    object bk_ = FHIRHelpers_4_3_000.Instance.ToValue(context, bj_);
                    bool bl_ = bk_ is CqlInterval<CqlDateTime>;

                    return bl_;
                };
                bool bf_()
                {
                    DataType bm_ = tuple_clljqcgdejtdiiewkzyjpwapd?.FollowupGlucoseTest?.Effective;
                    object bn_ = FHIRHelpers_4_3_000.Instance.ToValue(context, bm_);
                    bool bo_ = bn_ is CqlDateTime;

                    return bo_;
                };
                if (bd_())
                {
                    DataType bp_ = tuple_clljqcgdejtdiiewkzyjpwapd?.FollowupGlucoseTest?.Effective;
                    object bq_ = FHIRHelpers_4_3_000.Instance.ToValue(context, bp_);

                    return (bq_ as CqlDateTime) as object;
                }
                else if (be_())
                {
                    DataType br_ = tuple_clljqcgdejtdiiewkzyjpwapd?.FollowupGlucoseTest?.Effective;
                    object bs_ = FHIRHelpers_4_3_000.Instance.ToValue(context, br_);

                    return (bs_ as CqlInterval<CqlDateTime>) as object;
                }
                else if (bf_())
                {
                    DataType bt_ = tuple_clljqcgdejtdiiewkzyjpwapd?.FollowupGlucoseTest?.Effective;
                    object bu_ = FHIRHelpers_4_3_000.Instance.ToValue(context, bt_);

                    return (bu_ as CqlDateTime) as object;
                }
                else
                {
                    return null;
                }
            };
            CqlDateTime n_ = QICoreCommon_2_0_000.Instance.Earliest(context, m_());
            object o_()
            {
                bool bv_()
                {
                    DataType by_ = tuple_clljqcgdejtdiiewkzyjpwapd?.LowGlucoseTest?.Effective;
                    object bz_ = FHIRHelpers_4_3_000.Instance.ToValue(context, by_);
                    bool ca_ = bz_ is CqlDateTime;

                    return ca_;
                };
                bool bw_()
                {
                    DataType cb_ = tuple_clljqcgdejtdiiewkzyjpwapd?.LowGlucoseTest?.Effective;
                    object cc_ = FHIRHelpers_4_3_000.Instance.ToValue(context, cb_);
                    bool cd_ = cc_ is CqlInterval<CqlDateTime>;

                    return cd_;
                };
                bool bx_()
                {
                    DataType ce_ = tuple_clljqcgdejtdiiewkzyjpwapd?.LowGlucoseTest?.Effective;
                    object cf_ = FHIRHelpers_4_3_000.Instance.ToValue(context, ce_);
                    bool cg_ = cf_ is CqlDateTime;

                    return cg_;
                };
                if (bv_())
                {
                    DataType ch_ = tuple_clljqcgdejtdiiewkzyjpwapd?.LowGlucoseTest?.Effective;
                    object ci_ = FHIRHelpers_4_3_000.Instance.ToValue(context, ch_);

                    return (ci_ as CqlDateTime) as object;
                }
                else if (bw_())
                {
                    DataType cj_ = tuple_clljqcgdejtdiiewkzyjpwapd?.LowGlucoseTest?.Effective;
                    object ck_ = FHIRHelpers_4_3_000.Instance.ToValue(context, cj_);

                    return (ck_ as CqlInterval<CqlDateTime>) as object;
                }
                else if (bx_())
                {
                    DataType cl_ = tuple_clljqcgdejtdiiewkzyjpwapd?.LowGlucoseTest?.Effective;
                    object cm_ = FHIRHelpers_4_3_000.Instance.ToValue(context, cl_);

                    return (cm_ as CqlDateTime) as object;
                }
                else
                {
                    return null;
                }
            };
            CqlDateTime p_ = QICoreCommon_2_0_000.Instance.Earliest(context, o_());
            object q_()
            {
                bool cn_()
                {
                    DataType cq_ = tuple_clljqcgdejtdiiewkzyjpwapd?.LowGlucoseTest?.Effective;
                    object cr_ = FHIRHelpers_4_3_000.Instance.ToValue(context, cq_);
                    bool cs_ = cr_ is CqlDateTime;

                    return cs_;
                };
                bool co_()
                {
                    DataType ct_ = tuple_clljqcgdejtdiiewkzyjpwapd?.LowGlucoseTest?.Effective;
                    object cu_ = FHIRHelpers_4_3_000.Instance.ToValue(context, ct_);
                    bool cv_ = cu_ is CqlInterval<CqlDateTime>;

                    return cv_;
                };
                bool cp_()
                {
                    DataType cw_ = tuple_clljqcgdejtdiiewkzyjpwapd?.LowGlucoseTest?.Effective;
                    object cx_ = FHIRHelpers_4_3_000.Instance.ToValue(context, cw_);
                    bool cy_ = cx_ is CqlDateTime;

                    return cy_;
                };
                if (cn_())
                {
                    DataType cz_ = tuple_clljqcgdejtdiiewkzyjpwapd?.LowGlucoseTest?.Effective;
                    object da_ = FHIRHelpers_4_3_000.Instance.ToValue(context, cz_);

                    return (da_ as CqlDateTime) as object;
                }
                else if (co_())
                {
                    DataType db_ = tuple_clljqcgdejtdiiewkzyjpwapd?.LowGlucoseTest?.Effective;
                    object dc_ = FHIRHelpers_4_3_000.Instance.ToValue(context, db_);

                    return (dc_ as CqlInterval<CqlDateTime>) as object;
                }
                else if (cp_())
                {
                    DataType dd_ = tuple_clljqcgdejtdiiewkzyjpwapd?.LowGlucoseTest?.Effective;
                    object de_ = FHIRHelpers_4_3_000.Instance.ToValue(context, dd_);

                    return (de_ as CqlDateTime) as object;
                }
                else
                {
                    return null;
                }
            };
            CqlDateTime r_ = QICoreCommon_2_0_000.Instance.Earliest(context, q_());
            CqlQuantity s_ = context.Operators.Quantity(5m, "minutes");
            CqlDateTime t_ = context.Operators.Add(r_, s_);
            CqlInterval<CqlDateTime> u_ = context.Operators.Interval(p_, t_, false, true);
            bool? v_ = context.Operators.In<CqlDateTime>(n_, u_, default);
            object w_()
            {
                bool df_()
                {
                    DataType di_ = tuple_clljqcgdejtdiiewkzyjpwapd?.LowGlucoseTest?.Effective;
                    object dj_ = FHIRHelpers_4_3_000.Instance.ToValue(context, di_);
                    bool dk_ = dj_ is CqlDateTime;

                    return dk_;
                };
                bool dg_()
                {
                    DataType dl_ = tuple_clljqcgdejtdiiewkzyjpwapd?.LowGlucoseTest?.Effective;
                    object dm_ = FHIRHelpers_4_3_000.Instance.ToValue(context, dl_);
                    bool dn_ = dm_ is CqlInterval<CqlDateTime>;

                    return dn_;
                };
                bool dh_()
                {
                    DataType do_ = tuple_clljqcgdejtdiiewkzyjpwapd?.LowGlucoseTest?.Effective;
                    object dp_ = FHIRHelpers_4_3_000.Instance.ToValue(context, do_);
                    bool dq_ = dp_ is CqlDateTime;

                    return dq_;
                };
                if (df_())
                {
                    DataType dr_ = tuple_clljqcgdejtdiiewkzyjpwapd?.LowGlucoseTest?.Effective;
                    object ds_ = FHIRHelpers_4_3_000.Instance.ToValue(context, dr_);

                    return (ds_ as CqlDateTime) as object;
                }
                else if (dg_())
                {
                    DataType dt_ = tuple_clljqcgdejtdiiewkzyjpwapd?.LowGlucoseTest?.Effective;
                    object du_ = FHIRHelpers_4_3_000.Instance.ToValue(context, dt_);

                    return (du_ as CqlInterval<CqlDateTime>) as object;
                }
                else if (dh_())
                {
                    DataType dv_ = tuple_clljqcgdejtdiiewkzyjpwapd?.LowGlucoseTest?.Effective;
                    object dw_ = FHIRHelpers_4_3_000.Instance.ToValue(context, dv_);

                    return (dw_ as CqlDateTime) as object;
                }
                else
                {
                    return null;
                }
            };
            CqlDateTime x_ = QICoreCommon_2_0_000.Instance.Earliest(context, w_());
            bool? y_ = context.Operators.Not((bool?)(x_ is null));
            bool? z_ = context.Operators.And(v_, y_);
            object aa_()
            {
                bool dx_()
                {
                    DataType ea_ = tuple_clljqcgdejtdiiewkzyjpwapd?.LowGlucoseTest?.Effective;
                    object eb_ = FHIRHelpers_4_3_000.Instance.ToValue(context, ea_);
                    bool ec_ = eb_ is CqlDateTime;

                    return ec_;
                };
                bool dy_()
                {
                    DataType ed_ = tuple_clljqcgdejtdiiewkzyjpwapd?.LowGlucoseTest?.Effective;
                    object ee_ = FHIRHelpers_4_3_000.Instance.ToValue(context, ed_);
                    bool ef_ = ee_ is CqlInterval<CqlDateTime>;

                    return ef_;
                };
                bool dz_()
                {
                    DataType eg_ = tuple_clljqcgdejtdiiewkzyjpwapd?.LowGlucoseTest?.Effective;
                    object eh_ = FHIRHelpers_4_3_000.Instance.ToValue(context, eg_);
                    bool ei_ = eh_ is CqlDateTime;

                    return ei_;
                };
                if (dx_())
                {
                    DataType ej_ = tuple_clljqcgdejtdiiewkzyjpwapd?.LowGlucoseTest?.Effective;
                    object ek_ = FHIRHelpers_4_3_000.Instance.ToValue(context, ej_);

                    return (ek_ as CqlDateTime) as object;
                }
                else if (dy_())
                {
                    DataType el_ = tuple_clljqcgdejtdiiewkzyjpwapd?.LowGlucoseTest?.Effective;
                    object em_ = FHIRHelpers_4_3_000.Instance.ToValue(context, el_);

                    return (em_ as CqlInterval<CqlDateTime>) as object;
                }
                else if (dz_())
                {
                    DataType en_ = tuple_clljqcgdejtdiiewkzyjpwapd?.LowGlucoseTest?.Effective;
                    object eo_ = FHIRHelpers_4_3_000.Instance.ToValue(context, en_);

                    return (eo_ as CqlDateTime) as object;
                }
                else
                {
                    return null;
                }
            };
            CqlDateTime ab_ = QICoreCommon_2_0_000.Instance.Earliest(context, aa_());
            CqlInterval<CqlDateTime> ac_ = CQMCommon_2_0_000.Instance.HospitalizationWithObservation(context, tuple_clljqcgdejtdiiewkzyjpwapd?.QualifyingEncounter);
            bool? ad_ = context.Operators.In<CqlDateTime>(ab_, ac_, default);
            bool? ae_ = context.Operators.And(z_, ad_);
            object af_()
            {
                bool ep_()
                {
                    DataType es_ = tuple_clljqcgdejtdiiewkzyjpwapd?.FollowupGlucoseTest?.Effective;
                    object et_ = FHIRHelpers_4_3_000.Instance.ToValue(context, es_);
                    bool eu_ = et_ is CqlDateTime;

                    return eu_;
                };
                bool eq_()
                {
                    DataType ev_ = tuple_clljqcgdejtdiiewkzyjpwapd?.FollowupGlucoseTest?.Effective;
                    object ew_ = FHIRHelpers_4_3_000.Instance.ToValue(context, ev_);
                    bool ex_ = ew_ is CqlInterval<CqlDateTime>;

                    return ex_;
                };
                bool er_()
                {
                    DataType ey_ = tuple_clljqcgdejtdiiewkzyjpwapd?.FollowupGlucoseTest?.Effective;
                    object ez_ = FHIRHelpers_4_3_000.Instance.ToValue(context, ey_);
                    bool fa_ = ez_ is CqlDateTime;

                    return fa_;
                };
                if (ep_())
                {
                    DataType fb_ = tuple_clljqcgdejtdiiewkzyjpwapd?.FollowupGlucoseTest?.Effective;
                    object fc_ = FHIRHelpers_4_3_000.Instance.ToValue(context, fb_);

                    return (fc_ as CqlDateTime) as object;
                }
                else if (eq_())
                {
                    DataType fd_ = tuple_clljqcgdejtdiiewkzyjpwapd?.FollowupGlucoseTest?.Effective;
                    object fe_ = FHIRHelpers_4_3_000.Instance.ToValue(context, fd_);

                    return (fe_ as CqlInterval<CqlDateTime>) as object;
                }
                else if (er_())
                {
                    DataType ff_ = tuple_clljqcgdejtdiiewkzyjpwapd?.FollowupGlucoseTest?.Effective;
                    object fg_ = FHIRHelpers_4_3_000.Instance.ToValue(context, ff_);

                    return (fg_ as CqlDateTime) as object;
                }
                else
                {
                    return null;
                }
            };
            CqlDateTime ag_ = QICoreCommon_2_0_000.Instance.Earliest(context, af_());
            bool? ai_ = context.Operators.In<CqlDateTime>(ag_, ac_, default);
            bool? aj_ = context.Operators.And(ae_, ai_);
            Id ak_ = tuple_clljqcgdejtdiiewkzyjpwapd?.FollowupGlucoseTest?.IdElement;
            string al_ = ak_?.Value;
            Id am_ = tuple_clljqcgdejtdiiewkzyjpwapd?.LowGlucoseTest?.IdElement;
            string an_ = am_?.Value;
            bool? ao_ = context.Operators.Equivalent(al_, an_);
            bool? ap_ = context.Operators.Not(ao_);
            bool? aq_ = context.Operators.And(aj_, ap_);
            Code<ObservationStatus> ar_ = tuple_clljqcgdejtdiiewkzyjpwapd?.FollowupGlucoseTest?.StatusElement;
            ObservationStatus? as_ = ar_?.Value;
            Code<ObservationStatus> at_ = context.Operators.Convert<Code<ObservationStatus>>(as_);
            string au_ = context.Operators.Convert<string>(at_);
            string[] av_ = [
                "final",
                "amended",
                "corrected",
            ];
            bool? aw_ = context.Operators.In<string>(au_, av_ as IEnumerable<string>);
            bool? ax_ = context.Operators.And(aq_, aw_);
            DataType ay_ = tuple_clljqcgdejtdiiewkzyjpwapd?.FollowupGlucoseTest?.Value;
            object az_ = FHIRHelpers_4_3_000.Instance.ToValue(context, ay_);
            CqlQuantity ba_ = context.Operators.Quantity(80m, "mg/dL");
            bool? bb_ = context.Operators.Greater(az_ as CqlQuantity, ba_);
            bool? bc_ = context.Operators.And(ax_, bb_);

            return bc_;
        };
        IEnumerable<(CqlTupleMetadata, Encounter QualifyingEncounter, Observation LowGlucoseTest, Observation FollowupGlucoseTest)?> i_ = context.Operators.Where<(CqlTupleMetadata, Encounter QualifyingEncounter, Observation LowGlucoseTest, Observation FollowupGlucoseTest)?>(g_, h_);
        Observation j_((CqlTupleMetadata, Encounter QualifyingEncounter, Observation LowGlucoseTest, Observation FollowupGlucoseTest)? tuple_clljqcgdejtdiiewkzyjpwapd) => 
            tuple_clljqcgdejtdiiewkzyjpwapd?.LowGlucoseTest;
        IEnumerable<Observation> k_ = context.Operators.Select<(CqlTupleMetadata, Encounter QualifyingEncounter, Observation LowGlucoseTest, Observation FollowupGlucoseTest)?, Observation>(i_, j_);

        return k_;
    }


    [CqlDeclaration("Severe Hypoglycemic Harm Event")]
    public IEnumerable<Observation> Severe_Hypoglycemic_Harm_Event(CqlContext context)
    {
        IEnumerable<Observation> a_ = this.Glucose_Test_with_Result_Less_Than_40(context);
        bool? b_(Observation LowGlucoseTest)
        {
            Id d_ = LowGlucoseTest?.IdElement;
            string e_ = d_?.Value;
            IEnumerable<Observation> f_ = this.Low_Glucose_Test_Followed_By_Glucose_Test_Result_Greater_Than_80(context);
            bool? g_(Observation @this)
            {
                string m_ = (@this is Resource
    ? (@this as Resource).IdElement
    : default)?.Value;
                bool? n_ = context.Operators.Not((bool?)(m_ is null));

                return n_;
            };
            IEnumerable<Observation> h_ = context.Operators.Where<Observation>(f_, g_);
            string i_(Observation @this)
            {
                string o_ = (@this is Resource
    ? (@this as Resource).IdElement
    : default)?.Value;

                return o_;
            };
            IEnumerable<string> j_ = context.Operators.Select<Observation, string>(h_, i_);
            bool? k_ = context.Operators.In<string>(e_, j_);
            bool? l_ = context.Operators.Not(k_);

            return l_;
        };
        IEnumerable<Observation> c_ = context.Operators.Where<Observation>(a_, b_);

        return c_;
    }


    [CqlDeclaration("Encounter with Severe Hypoglycemic Harm Event")]
    public IEnumerable<Encounter> Encounter_with_Severe_Hypoglycemic_Harm_Event(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Denominator(context);
        IEnumerable<Observation> b_ = this.Severe_Hypoglycemic_Harm_Event(context);
        IEnumerable<ValueTuple<Encounter, Observation>> c_ = context.Operators.CrossJoin<Encounter, Observation>(a_, b_);
        (CqlTupleMetadata, Encounter QualifyingEncounter, Observation HypoglycemicEvent)? d_(ValueTuple<Encounter, Observation> _valueTuple)
        {
            (CqlTupleMetadata, Encounter QualifyingEncounter, Observation HypoglycemicEvent)? j_ = (CqlTupleMetadata_HFNEMPjQLiOPFNRMYPNYDhFfR, _valueTuple.Item1, _valueTuple.Item2);

            return j_;
        };
        IEnumerable<(CqlTupleMetadata, Encounter QualifyingEncounter, Observation HypoglycemicEvent)?> e_ = context.Operators.Select<ValueTuple<Encounter, Observation>, (CqlTupleMetadata, Encounter QualifyingEncounter, Observation HypoglycemicEvent)?>(c_, d_);
        bool? f_((CqlTupleMetadata, Encounter QualifyingEncounter, Observation HypoglycemicEvent)? tuple_hfnempjqliopfnrmypnydhffr)
        {
            object k_()
            {
                bool o_()
                {
                    DataType r_ = tuple_hfnempjqliopfnrmypnydhffr?.HypoglycemicEvent?.Effective;
                    object s_ = FHIRHelpers_4_3_000.Instance.ToValue(context, r_);
                    bool t_ = s_ is CqlDateTime;

                    return t_;
                };
                bool p_()
                {
                    DataType u_ = tuple_hfnempjqliopfnrmypnydhffr?.HypoglycemicEvent?.Effective;
                    object v_ = FHIRHelpers_4_3_000.Instance.ToValue(context, u_);
                    bool w_ = v_ is CqlInterval<CqlDateTime>;

                    return w_;
                };
                bool q_()
                {
                    DataType x_ = tuple_hfnempjqliopfnrmypnydhffr?.HypoglycemicEvent?.Effective;
                    object y_ = FHIRHelpers_4_3_000.Instance.ToValue(context, x_);
                    bool z_ = y_ is CqlDateTime;

                    return z_;
                };
                if (o_())
                {
                    DataType aa_ = tuple_hfnempjqliopfnrmypnydhffr?.HypoglycemicEvent?.Effective;
                    object ab_ = FHIRHelpers_4_3_000.Instance.ToValue(context, aa_);

                    return (ab_ as CqlDateTime) as object;
                }
                else if (p_())
                {
                    DataType ac_ = tuple_hfnempjqliopfnrmypnydhffr?.HypoglycemicEvent?.Effective;
                    object ad_ = FHIRHelpers_4_3_000.Instance.ToValue(context, ac_);

                    return (ad_ as CqlInterval<CqlDateTime>) as object;
                }
                else if (q_())
                {
                    DataType ae_ = tuple_hfnempjqliopfnrmypnydhffr?.HypoglycemicEvent?.Effective;
                    object af_ = FHIRHelpers_4_3_000.Instance.ToValue(context, ae_);

                    return (af_ as CqlDateTime) as object;
                }
                else
                {
                    return null;
                }
            };
            CqlDateTime l_ = QICoreCommon_2_0_000.Instance.Earliest(context, k_());
            CqlInterval<CqlDateTime> m_ = CQMCommon_2_0_000.Instance.HospitalizationWithObservation(context, tuple_hfnempjqliopfnrmypnydhffr?.QualifyingEncounter);
            bool? n_ = context.Operators.In<CqlDateTime>(l_, m_, default);

            return n_;
        };
        IEnumerable<(CqlTupleMetadata, Encounter QualifyingEncounter, Observation HypoglycemicEvent)?> g_ = context.Operators.Where<(CqlTupleMetadata, Encounter QualifyingEncounter, Observation HypoglycemicEvent)?>(e_, f_);
        Encounter h_((CqlTupleMetadata, Encounter QualifyingEncounter, Observation HypoglycemicEvent)? tuple_hfnempjqliopfnrmypnydhffr) => 
            tuple_hfnempjqliopfnrmypnydhffr?.QualifyingEncounter;
        IEnumerable<Encounter> i_ = context.Operators.Select<(CqlTupleMetadata, Encounter QualifyingEncounter, Observation HypoglycemicEvent)?, Encounter>(g_, h_);

        return i_;
    }


    [CqlDeclaration("Numerator")]
    public IEnumerable<Encounter> Numerator(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Encounter_with_Severe_Hypoglycemic_Harm_Event(context);

        return a_;
    }


    [CqlDeclaration("SDE Ethnicity")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Ethnicity(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? a_ = SupplementalDataElements_3_4_000.Instance.SDE_Ethnicity(context);

        return a_;
    }


    [CqlDeclaration("SDE Payer")]
    public IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> SDE_Payer(CqlContext context)
    {
        IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> a_ = SupplementalDataElements_3_4_000.Instance.SDE_Payer(context);

        return a_;
    }


    [CqlDeclaration("SDE Race")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Race(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? a_ = SupplementalDataElements_3_4_000.Instance.SDE_Race(context);

        return a_;
    }


    [CqlDeclaration("SDE Sex")]
    public CqlCode SDE_Sex(CqlContext context)
    {
        CqlCode a_ = SupplementalDataElements_3_4_000.Instance.SDE_Sex(context);

        return a_;
    }

    private static CqlTupleMetadata CqlTupleMetadata_BTYMMDGaChdRaGRhOfgXBXGHO = new(
        [typeof(Encounter), typeof(MedicationAdministration), typeof(Observation)],
        ["QualifyingEncounter", "HypoglycemicMedication", "GlucoseTest"]);

    private static CqlTupleMetadata CqlTupleMetadata_CLLJQcGdEjTDiIeWKZYJPWaPd = new(
        [typeof(Encounter), typeof(Observation), typeof(Observation)],
        ["QualifyingEncounter", "LowGlucoseTest", "FollowupGlucoseTest"]);

    private static CqlTupleMetadata CqlTupleMetadata_HFNEMPjQLiOPFNRMYPNYDhFfR = new(
        [typeof(Encounter), typeof(Observation)],
        ["QualifyingEncounter", "HypoglycemicEvent"]);

}

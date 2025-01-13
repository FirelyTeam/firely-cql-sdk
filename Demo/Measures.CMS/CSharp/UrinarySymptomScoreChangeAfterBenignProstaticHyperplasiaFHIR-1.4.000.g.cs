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
[CqlLibrary("UrinarySymptomScoreChangeAfterBenignProstaticHyperplasiaFHIR", "1.4.000")]
public partial class UrinarySymptomScoreChangeAfterBenignProstaticHyperplasiaFHIR_1_4_000 : ILibrary, ISingleton<UrinarySymptomScoreChangeAfterBenignProstaticHyperplasiaFHIR_1_4_000>
{
    private UrinarySymptomScoreChangeAfterBenignProstaticHyperplasiaFHIR_1_4_000() {}

    public static UrinarySymptomScoreChangeAfterBenignProstaticHyperplasiaFHIR_1_4_000 Instance { get; } = new();

    #region ILibrary Implementation

    string ILibrary.Name => "UrinarySymptomScoreChangeAfterBenignProstaticHyperplasiaFHIR";
    string ILibrary.Version => "1.4.000";
    IReadOnlyList<ILibrary> ILibrary.Dependencies => [FHIRHelpers_4_4_000.Instance, SupplementalDataElements_3_5_000.Instance, QICoreCommon_2_1_000.Instance];

    #endregion ILibrary Implementation

    #region Definition Methods

    [CqlDeclaration("Hospital Services for Urology")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1151.59")]
    public CqlValueSet Hospital_Services_for_Urology(CqlContext context) =>
        new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1151.59", default);


    [CqlDeclaration("Morbid Obesity")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1164.67")]
    public CqlValueSet Morbid_Obesity(CqlContext context) =>
        new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1164.67", default);


    [CqlDeclaration("Office Visit")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1001")]
    public CqlValueSet Office_Visit(CqlContext context) =>
        new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1001", default);


    [CqlDeclaration("Urinary retention")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1164.52")]
    public CqlValueSet Urinary_retention(CqlContext context) =>
        new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1164.52", default);


    [CqlDeclaration("American Urological Association Symptom Index [AUASI]")]
    public CqlCode American_Urological_Association_Symptom_Index__AUASI_(CqlContext context) =>
        new CqlCode("80883-2", "http://loinc.org", default, default);


    [CqlDeclaration("Benign prostatic hyperplasia with lower urinary tract symptoms")]
    public CqlCode Benign_prostatic_hyperplasia_with_lower_urinary_tract_symptoms(CqlContext context) =>
        new CqlCode("N40.1", "http://hl7.org/fhir/sid/icd-10-cm", default, default);


    [CqlDeclaration("If you were to spend the rest of your life with your urinary condition just the way it is now, how would you feel about that [IPSS]")]
    public CqlCode If_you_were_to_spend_the_rest_of_your_life_with_your_urinary_condition_just_the_way_it_is_now__how_would_you_feel_about_that__IPSS_(CqlContext context) =>
        new CqlCode("81090-3", "http://loinc.org", default, default);


    [CqlDeclaration("International Prostate Symptom Score [IPSS]")]
    public CqlCode International_Prostate_Symptom_Score__IPSS_(CqlContext context) =>
        new CqlCode("80976-4", "http://loinc.org", default, default);


    [CqlDeclaration("virtual")]
    public CqlCode @virtual(CqlContext context) =>
        new CqlCode("VR", "http://terminology.hl7.org/CodeSystem/v3-ActCode", default, default);


    [CqlDeclaration("LOINC")]
    public CqlCode[] LOINC(CqlContext context)
    {
        CqlCode[] a_ = [
            new CqlCode("80883-2", "http://loinc.org", default, default),
            new CqlCode("81090-3", "http://loinc.org", default, default),
            new CqlCode("80976-4", "http://loinc.org", default, default),
        ];

        return a_;
    }


    [CqlDeclaration("ICD10CM")]
    public CqlCode[] ICD10CM(CqlContext context)
    {
        CqlCode[] a_ = [
            new CqlCode("N40.1", "http://hl7.org/fhir/sid/icd-10-cm", default, default),
        ];

        return a_;
    }


    [CqlDeclaration("ObservationCategoryCodes")]
    public CqlCode[] ObservationCategoryCodes(CqlContext context)
    {
        CqlCode[] a_ = []
;

        return a_;
    }


    [CqlDeclaration("ActCode")]
    public CqlCode[] ActCode(CqlContext context)
    {
        CqlCode[] a_ = [
            new CqlCode("VR", "http://terminology.hl7.org/CodeSystem/v3-ActCode", default, default),
        ];

        return a_;
    }


    [CqlDeclaration("Measurement Period")]
    public CqlInterval<CqlDateTime> Measurement_Period(CqlContext context)
    {
        CqlDateTime a_ = context.Operators.DateTime(2025, 1, 1, 0, 0, 0, 0, 0.0m);
        CqlDateTime b_ = context.Operators.DateTime(2025, 12, 31, 23, 59, 59, 999, 0.0m);
        CqlInterval<CqlDateTime> c_ = context.Operators.Interval(a_, b_, true, true);
        object d_ = context.ResolveParameter("UrinarySymptomScoreChangeAfterBenignProstaticHyperplasiaFHIR-1.4.000", "Measurement Period", c_);

        return (CqlInterval<CqlDateTime>)d_;
    }


    [CqlDeclaration("Patient")]
    public Patient Patient(CqlContext context)
    {
        IEnumerable<Patient> a_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-patient"));
        Patient b_ = context.Operators.SingletonFrom<Patient>(a_);

        return b_;
    }


    [CqlDeclaration("Patient is Male")]
    public bool? Patient_is_Male(CqlContext context)
    {
        Patient a_ = this.Patient(context);
        Code<AdministrativeGender> b_ = a_?.GenderElement;
        AdministrativeGender? c_ = b_?.Value;
        string d_ = context.Operators.Convert<string>(c_);
        bool? e_ = context.Operators.Equal(d_, "male");

        return e_;
    }


    [CqlDeclaration("Has Qualifying Encounter")]
    public bool? Has_Qualifying_Encounter(CqlContext context)
    {
        CqlValueSet a_ = this.Office_Visit(context);
        IEnumerable<Encounter> b_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        bool? c_(Encounter ValidEncounter)
        {
            CqlInterval<CqlDateTime> f_ = this.Measurement_Period(context);
            Period g_ = ValidEncounter?.Period;
            CqlInterval<CqlDateTime> h_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, g_);
            bool? i_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(f_, h_, "day");
            Coding j_ = ValidEncounter?.Class;
            CqlCode k_ = FHIRHelpers_4_4_000.Instance.ToCode(context, j_);
            CqlCode l_ = this.@virtual(context);
            bool? m_ = context.Operators.Equivalent(k_, l_);
            bool? n_ = context.Operators.Not(m_);
            bool? o_ = context.Operators.And(i_, n_);
            Code<Encounter.EncounterStatus> p_ = ValidEncounter?.StatusElement;
            Encounter.EncounterStatus? q_ = p_?.Value;
            Code<Encounter.EncounterStatus> r_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(q_);
            bool? s_ = context.Operators.Equal(r_, "finished");
            bool? t_ = context.Operators.And(o_, s_);

            return t_;
        };
        IEnumerable<Encounter> d_ = context.Operators.Where<Encounter>(b_, c_);
        bool? e_ = context.Operators.Exists<Encounter>(d_);

        return e_;
    }


    public bool? isConfirmedActiveDiagnosis(CqlContext context, Condition condition)
    {
        bool? a_ = QICoreCommon_2_1_000.Instance.isActive(context, condition);
        CodeableConcept b_ = condition?.VerificationStatus;
        CqlConcept c_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, b_);
        CqlCode d_ = QICoreCommon_2_1_000.Instance.confirmed(context);
        CqlConcept e_ = context.Operators.ConvertCodeToConcept(d_);
        bool? f_ = context.Operators.Equivalent(c_, e_);
        bool? g_ = context.Operators.And(a_, f_);

        return g_;
    }


    [CqlDeclaration("Initial BPH Diagnosis Starts Within 6 Months Before the Measurement Period")]
    public Condition Initial_BPH_Diagnosis_Starts_Within_6_Months_Before_the_Measurement_Period(CqlContext context)
    {
        CqlCode a_ = this.Benign_prostatic_hyperplasia_with_lower_urinary_tract_symptoms(context);
        IEnumerable<CqlCode> b_ = context.Operators.ToList<CqlCode>(a_);
        IEnumerable<Condition> c_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, default, b_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        bool? d_(Condition NewBPHDiagnosis)
        {
            CqlInterval<CqlDateTime> i_ = QICoreCommon_2_1_000.Instance.prevalenceInterval(context, NewBPHDiagnosis);
            CqlDateTime j_ = context.Operators.Start(i_);
            CqlInterval<CqlDateTime> k_ = this.Measurement_Period(context);
            CqlDateTime l_ = context.Operators.Start(k_);
            CqlQuantity m_ = context.Operators.Quantity(6m, "months");
            CqlDateTime n_ = context.Operators.Subtract(l_, m_);
            CqlDateTime p_ = context.Operators.Start(k_);
            CqlInterval<CqlDateTime> q_ = context.Operators.Interval(n_, p_, true, true);
            bool? r_ = context.Operators.In<CqlDateTime>(j_, q_, default);
            bool? s_ = this.isConfirmedActiveDiagnosis(context, NewBPHDiagnosis);
            bool? t_ = context.Operators.And(r_, s_);

            return t_;
        };
        IEnumerable<Condition> e_ = context.Operators.Where<Condition>(c_, d_);
        object f_(Condition @this)
        {
            DataType u_ = @this?.Onset;
            object v_ = FHIRHelpers_4_4_000.Instance.ToValue(context, u_);
            CqlInterval<CqlDateTime> w_ = QICoreCommon_2_1_000.Instance.toInterval(context, v_);
            CqlDateTime x_ = context.Operators.Start(w_);

            return x_;
        };
        IEnumerable<Condition> g_ = context.Operators.SortBy<Condition>(e_, f_, System.ComponentModel.ListSortDirection.Ascending);
        Condition h_ = context.Operators.First<Condition>(g_);

        return h_;
    }


    [CqlDeclaration("Has Qualifying BPH Diagnosis")]
    public bool? Has_Qualifying_BPH_Diagnosis(CqlContext context)
    {
        Condition a_ = this.Initial_BPH_Diagnosis_Starts_Within_6_Months_Before_the_Measurement_Period(context);
        bool? b_ = context.Operators.Not((bool?)(a_ is null));

        return b_;
    }


    [CqlDeclaration("Documented IPSS Assessment Result")]
    public IEnumerable<(CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)?> Documented_IPSS_Assessment_Result(CqlContext context)
    {
        CqlCode a_ = this.International_Prostate_Symptom_Score__IPSS_(context);
        IEnumerable<CqlCode> b_ = context.Operators.ToList<CqlCode>(a_);
        IEnumerable<Observation> c_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, b_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
        bool? d_(Observation IPSSAssessment)
        {
            Code<ObservationStatus> i_ = IPSSAssessment?.StatusElement;
            ObservationStatus? j_ = i_?.Value;
            Code<ObservationStatus> k_ = context.Operators.Convert<Code<ObservationStatus>>(j_);
            string l_ = context.Operators.Convert<string>(k_);
            string[] m_ = [
                "final",
                "amended",
                "corrected",
            ];
            bool? n_ = context.Operators.In<string>(l_, m_ as IEnumerable<string>);
            DataType o_ = IPSSAssessment?.Value;
            object p_ = FHIRHelpers_4_4_000.Instance.ToValue(context, o_);
            bool? q_ = context.Operators.Not((bool?)(p_ is null));
            bool? r_ = context.Operators.And(n_, q_);

            return r_;
        };
        IEnumerable<Observation> e_ = context.Operators.Where<Observation>(c_, d_);
        (CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)? f_(Observation IPSSAssessment)
        {
            object s_()
            {
                bool x_()
                {
                    DataType aa_ = IPSSAssessment?.Effective;
                    object ab_ = FHIRHelpers_4_4_000.Instance.ToValue(context, aa_);
                    bool ac_ = ab_ is CqlDateTime;

                    return ac_;
                };
                bool y_()
                {
                    DataType ad_ = IPSSAssessment?.Effective;
                    object ae_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ad_);
                    bool af_ = ae_ is CqlInterval<CqlDateTime>;

                    return af_;
                };
                bool z_()
                {
                    DataType ag_ = IPSSAssessment?.Effective;
                    object ah_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ag_);
                    bool ai_ = ah_ is CqlDateTime;

                    return ai_;
                };
                if (x_())
                {
                    DataType aj_ = IPSSAssessment?.Effective;
                    object ak_ = FHIRHelpers_4_4_000.Instance.ToValue(context, aj_);

                    return (ak_ as CqlDateTime) as object;
                }
                else if (y_())
                {
                    DataType al_ = IPSSAssessment?.Effective;
                    object am_ = FHIRHelpers_4_4_000.Instance.ToValue(context, al_);

                    return (am_ as CqlInterval<CqlDateTime>) as object;
                }
                else if (z_())
                {
                    DataType an_ = IPSSAssessment?.Effective;
                    object ao_ = FHIRHelpers_4_4_000.Instance.ToValue(context, an_);

                    return (ao_ as CqlDateTime) as object;
                }
                else
                {
                    return null;
                }
            };
            CqlDateTime t_ = QICoreCommon_2_1_000.Instance.earliest(context, s_());
            DataType u_ = IPSSAssessment?.Value;
            object v_ = FHIRHelpers_4_4_000.Instance.ToValue(context, u_);
            (CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)? w_ = (CqlTupleMetadata_GNNDVIQPcTANSdLebhBKYIdga, t_, v_ as int?);

            return w_;
        };
        IEnumerable<(CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)?> g_ = context.Operators.Select<Observation, (CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)?>(e_, f_);
        IEnumerable<(CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)?> h_ = context.Operators.Distinct<(CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)?>(g_);

        return h_;
    }


    [CqlDeclaration("AUA Symptom Index and Quality of Life Assessment Result")]
    public IEnumerable<(CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)?> AUA_Symptom_Index_and_Quality_of_Life_Assessment_Result(CqlContext context)
    {
        CqlCode a_ = this.American_Urological_Association_Symptom_Index__AUASI_(context);
        IEnumerable<CqlCode> b_ = context.Operators.ToList<CqlCode>(a_);
        IEnumerable<Observation> c_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, b_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
        bool? d_(Observation AUASIAssessment)
        {
            Code<ObservationStatus> i_ = AUASIAssessment?.StatusElement;
            ObservationStatus? j_ = i_?.Value;
            Code<ObservationStatus> k_ = context.Operators.Convert<Code<ObservationStatus>>(j_);
            string l_ = context.Operators.Convert<string>(k_);
            string[] m_ = [
                "final",
                "amended",
                "corrected",
            ];
            bool? n_ = context.Operators.In<string>(l_, m_ as IEnumerable<string>);
            DataType o_ = AUASIAssessment?.Value;
            object p_ = FHIRHelpers_4_4_000.Instance.ToValue(context, o_);
            bool? q_ = context.Operators.Not((bool?)(p_ is null));
            bool? r_ = context.Operators.And(n_, q_);

            return r_;
        };
        IEnumerable<Observation> e_ = context.Operators.Where<Observation>(c_, d_);
        (CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)? f_(Observation AUASIAssessment)
        {
            object s_()
            {
                bool ai_()
                {
                    DataType al_ = AUASIAssessment?.Effective;
                    object am_ = FHIRHelpers_4_4_000.Instance.ToValue(context, al_);
                    bool an_ = am_ is CqlDateTime;

                    return an_;
                };
                bool aj_()
                {
                    DataType ao_ = AUASIAssessment?.Effective;
                    object ap_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ao_);
                    bool aq_ = ap_ is CqlInterval<CqlDateTime>;

                    return aq_;
                };
                bool ak_()
                {
                    DataType ar_ = AUASIAssessment?.Effective;
                    object as_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ar_);
                    bool at_ = as_ is CqlDateTime;

                    return at_;
                };
                if (ai_())
                {
                    DataType au_ = AUASIAssessment?.Effective;
                    object av_ = FHIRHelpers_4_4_000.Instance.ToValue(context, au_);

                    return (av_ as CqlDateTime) as object;
                }
                else if (aj_())
                {
                    DataType aw_ = AUASIAssessment?.Effective;
                    object ax_ = FHIRHelpers_4_4_000.Instance.ToValue(context, aw_);

                    return (ax_ as CqlInterval<CqlDateTime>) as object;
                }
                else if (ak_())
                {
                    DataType ay_ = AUASIAssessment?.Effective;
                    object az_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ay_);

                    return (az_ as CqlDateTime) as object;
                }
                else
                {
                    return null;
                }
            };
            CqlDateTime t_ = QICoreCommon_2_1_000.Instance.earliest(context, s_());
            DataType u_ = AUASIAssessment?.Value;
            object v_ = FHIRHelpers_4_4_000.Instance.ToValue(context, u_);
            CqlCode w_ = this.If_you_were_to_spend_the_rest_of_your_life_with_your_urinary_condition_just_the_way_it_is_now__how_would_you_feel_about_that__IPSS_(context);
            IEnumerable<CqlCode> x_ = context.Operators.ToList<CqlCode>(w_);
            IEnumerable<Observation> y_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, x_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
            bool? z_(Observation QOLAssessment)
            {
                object ba_()
                {
                    bool bq_()
                    {
                        DataType bt_ = QOLAssessment?.Effective;
                        object bu_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bt_);
                        bool bv_ = bu_ is CqlDateTime;

                        return bv_;
                    };
                    bool br_()
                    {
                        DataType bw_ = QOLAssessment?.Effective;
                        object bx_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bw_);
                        bool by_ = bx_ is CqlInterval<CqlDateTime>;

                        return by_;
                    };
                    bool bs_()
                    {
                        DataType bz_ = QOLAssessment?.Effective;
                        object ca_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bz_);
                        bool cb_ = ca_ is CqlDateTime;

                        return cb_;
                    };
                    if (bq_())
                    {
                        DataType cc_ = QOLAssessment?.Effective;
                        object cd_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cc_);

                        return (cd_ as CqlDateTime) as object;
                    }
                    else if (br_())
                    {
                        DataType ce_ = QOLAssessment?.Effective;
                        object cf_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ce_);

                        return (cf_ as CqlInterval<CqlDateTime>) as object;
                    }
                    else if (bs_())
                    {
                        DataType cg_ = QOLAssessment?.Effective;
                        object ch_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cg_);

                        return (ch_ as CqlDateTime) as object;
                    }
                    else
                    {
                        return null;
                    }
                };
                CqlDateTime bb_ = QICoreCommon_2_1_000.Instance.earliest(context, ba_());
                object bc_()
                {
                    bool ci_()
                    {
                        DataType cl_ = AUASIAssessment?.Effective;
                        object cm_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cl_);
                        bool cn_ = cm_ is CqlDateTime;

                        return cn_;
                    };
                    bool cj_()
                    {
                        DataType co_ = AUASIAssessment?.Effective;
                        object cp_ = FHIRHelpers_4_4_000.Instance.ToValue(context, co_);
                        bool cq_ = cp_ is CqlInterval<CqlDateTime>;

                        return cq_;
                    };
                    bool ck_()
                    {
                        DataType cr_ = AUASIAssessment?.Effective;
                        object cs_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cr_);
                        bool ct_ = cs_ is CqlDateTime;

                        return ct_;
                    };
                    if (ci_())
                    {
                        DataType cu_ = AUASIAssessment?.Effective;
                        object cv_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cu_);

                        return (cv_ as CqlDateTime) as object;
                    }
                    else if (cj_())
                    {
                        DataType cw_ = AUASIAssessment?.Effective;
                        object cx_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cw_);

                        return (cx_ as CqlInterval<CqlDateTime>) as object;
                    }
                    else if (ck_())
                    {
                        DataType cy_ = AUASIAssessment?.Effective;
                        object cz_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cy_);

                        return (cz_ as CqlDateTime) as object;
                    }
                    else
                    {
                        return null;
                    }
                };
                CqlDateTime bd_ = QICoreCommon_2_1_000.Instance.earliest(context, bc_());
                bool? be_ = context.Operators.SameAs(bb_, bd_, "day");
                Code<ObservationStatus> bf_ = QOLAssessment?.StatusElement;
                ObservationStatus? bg_ = bf_?.Value;
                Code<ObservationStatus> bh_ = context.Operators.Convert<Code<ObservationStatus>>(bg_);
                string bi_ = context.Operators.Convert<string>(bh_);
                string[] bj_ = [
                    "final",
                    "amended",
                    "corrected",
                ];
                bool? bk_ = context.Operators.In<string>(bi_, bj_ as IEnumerable<string>);
                bool? bl_ = context.Operators.And(be_, bk_);
                DataType bm_ = QOLAssessment?.Value;
                object bn_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bm_);
                bool? bo_ = context.Operators.Not((bool?)(bn_ is null));
                bool? bp_ = context.Operators.And(bl_, bo_);

                return bp_;
            };
            IEnumerable<Observation> aa_ = context.Operators.Where<Observation>(y_, z_);
            object ab_(Observation @this)
            {
                object da_()
                {
                    bool dc_()
                    {
                        DataType df_ = @this?.Effective;
                        object dg_ = FHIRHelpers_4_4_000.Instance.ToValue(context, df_);
                        bool dh_ = dg_ is CqlDateTime;

                        return dh_;
                    };
                    bool dd_()
                    {
                        DataType di_ = @this?.Effective;
                        object dj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, di_);
                        bool dk_ = dj_ is CqlInterval<CqlDateTime>;

                        return dk_;
                    };
                    bool de_()
                    {
                        DataType dl_ = @this?.Effective;
                        object dm_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dl_);
                        bool dn_ = dm_ is CqlDateTime;

                        return dn_;
                    };
                    if (dc_())
                    {
                        DataType do_ = @this?.Effective;
                        object dp_ = FHIRHelpers_4_4_000.Instance.ToValue(context, do_);

                        return (dp_ as CqlDateTime) as object;
                    }
                    else if (dd_())
                    {
                        DataType dq_ = @this?.Effective;
                        object dr_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dq_);

                        return (dr_ as CqlInterval<CqlDateTime>) as object;
                    }
                    else if (de_())
                    {
                        DataType ds_ = @this?.Effective;
                        object dt_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ds_);

                        return (dt_ as CqlDateTime) as object;
                    }
                    else
                    {
                        return null;
                    }
                };
                CqlDateTime db_ = QICoreCommon_2_1_000.Instance.earliest(context, da_());

                return db_;
            };
            IEnumerable<Observation> ac_ = context.Operators.SortBy<Observation>(aa_, ab_, System.ComponentModel.ListSortDirection.Ascending);
            Observation ad_ = context.Operators.Last<Observation>(ac_);
            DataType ae_ = ad_?.Value;
            object af_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ae_);
            int? ag_ = context.Operators.Add(v_ as int?, af_ as int?);
            (CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)? ah_ = (CqlTupleMetadata_GNNDVIQPcTANSdLebhBKYIdga, t_, ag_);

            return ah_;
        };
        IEnumerable<(CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)?> g_ = context.Operators.Select<Observation, (CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)?>(e_, f_);
        IEnumerable<(CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)?> h_ = context.Operators.Distinct<(CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)?>(g_);

        return h_;
    }


    [CqlDeclaration("Urinary Symptom Score Assessment")]
    public IEnumerable<(CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)?> Urinary_Symptom_Score_Assessment(CqlContext context)
    {
        IEnumerable<(CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)?> a_ = this.Documented_IPSS_Assessment_Result(context);
        IEnumerable<(CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)?> b_ = this.AUA_Symptom_Index_and_Quality_of_Life_Assessment_Result(context);
        IEnumerable<(CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)?> c_ = context.Operators.Union<(CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)?>(a_, b_);

        return c_;
    }


    [CqlDeclaration("Urinary Symptom Score Within 1 Month after Initial BPH Diagnosis")]
    public (CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)? Urinary_Symptom_Score_Within_1_Month_after_Initial_BPH_Diagnosis(CqlContext context)
    {
        IEnumerable<(CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)?> a_ = this.Urinary_Symptom_Score_Assessment(context);
        IEnumerable<(CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)?> b_((CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)? USSAssessment)
        {
            Condition g_ = this.Initial_BPH_Diagnosis_Starts_Within_6_Months_Before_the_Measurement_Period(context);
            Condition[] h_ = [
                g_,
            ];
            bool? i_(Condition InitialBPHDiagnosis)
            {
                CqlDateTime m_ = USSAssessment?.effectiveDatetime;
                CqlInterval<CqlDateTime> n_ = QICoreCommon_2_1_000.Instance.prevalenceInterval(context, InitialBPHDiagnosis);
                CqlDateTime o_ = context.Operators.Start(n_);
                CqlDateTime q_ = context.Operators.Start(n_);
                CqlQuantity r_ = context.Operators.Quantity(1m, "month");
                CqlDateTime s_ = context.Operators.Add(q_, r_);
                CqlInterval<CqlDateTime> t_ = context.Operators.Interval(o_, s_, true, true);
                bool? u_ = context.Operators.In<CqlDateTime>(m_, t_, "day");
                CqlDateTime w_ = context.Operators.Start(n_);
                bool? x_ = context.Operators.Not((bool?)(w_ is null));
                bool? y_ = context.Operators.And(u_, x_);

                return y_;
            };
            IEnumerable<Condition> j_ = context.Operators.Where<Condition>((IEnumerable<Condition>)h_, i_);
            (CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)? k_(Condition InitialBPHDiagnosis) =>
                USSAssessment;
            IEnumerable<(CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)?> l_ = context.Operators.Select<Condition, (CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)?>(j_, k_);

            return l_;
        };
        IEnumerable<(CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)?> c_ = context.Operators.SelectMany<(CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)?, (CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)?>(a_, b_);
        object d_((CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)? @this)
        {
            CqlDateTime z_ = @this?.effectiveDatetime;

            return z_;
        };
        IEnumerable<(CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)?> e_ = context.Operators.SortBy<(CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)?>(c_, d_, System.ComponentModel.ListSortDirection.Ascending);
        (CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)? f_ = context.Operators.First<(CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)?>(e_);

        return f_;
    }


    [CqlDeclaration("Urinary Symptom Score 6 to 12 Months After Initial BPH Diagnosis")]
    public (CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)? Urinary_Symptom_Score_6_to_12_Months_After_Initial_BPH_Diagnosis(CqlContext context)
    {
        IEnumerable<(CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)?> a_ = this.Urinary_Symptom_Score_Assessment(context);
        IEnumerable<(CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)?> b_((CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)? USSAssessment)
        {
            Condition g_ = this.Initial_BPH_Diagnosis_Starts_Within_6_Months_Before_the_Measurement_Period(context);
            Condition[] h_ = [
                g_,
            ];
            bool? i_(Condition InitialBPHDiagnosis)
            {
                CqlInterval<CqlDateTime> m_ = QICoreCommon_2_1_000.Instance.prevalenceInterval(context, InitialBPHDiagnosis);
                CqlDateTime n_ = context.Operators.Start(m_);
                CqlDateTime o_ = USSAssessment?.effectiveDatetime;
                int? p_ = context.Operators.DurationBetween(n_, o_, "month");
                CqlInterval<int?> q_ = context.Operators.Interval(6, 12, true, true);
                bool? r_ = context.Operators.In<int?>(p_, q_, default);

                return r_;
            };
            IEnumerable<Condition> j_ = context.Operators.Where<Condition>((IEnumerable<Condition>)h_, i_);
            (CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)? k_(Condition InitialBPHDiagnosis) =>
                USSAssessment;
            IEnumerable<(CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)?> l_ = context.Operators.Select<Condition, (CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)?>(j_, k_);

            return l_;
        };
        IEnumerable<(CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)?> c_ = context.Operators.SelectMany<(CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)?, (CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)?>(a_, b_);
        object d_((CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)? @this)
        {
            CqlDateTime s_ = @this?.effectiveDatetime;

            return s_;
        };
        IEnumerable<(CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)?> e_ = context.Operators.SortBy<(CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)?>(c_, d_, System.ComponentModel.ListSortDirection.Ascending);
        (CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)? f_ = context.Operators.Last<(CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)?>(e_);

        return f_;
    }


    [CqlDeclaration("Initial Population")]
    public bool? Initial_Population(CqlContext context)
    {
        bool? a_ = this.Patient_is_Male(context);
        bool? b_ = this.Has_Qualifying_Encounter(context);
        bool? c_ = context.Operators.And(a_, b_);
        bool? d_ = this.Has_Qualifying_BPH_Diagnosis(context);
        bool? e_ = context.Operators.And(c_, d_);
        (CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)? f_ = this.Urinary_Symptom_Score_Within_1_Month_after_Initial_BPH_Diagnosis(context);
        bool? g_ = context.Operators.Not((bool?)(f_ is null));
        bool? h_ = context.Operators.And(e_, g_);
        (CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)? i_ = this.Urinary_Symptom_Score_6_to_12_Months_After_Initial_BPH_Diagnosis(context);
        bool? j_ = context.Operators.Not((bool?)(i_ is null));
        bool? k_ = context.Operators.And(h_, j_);

        return k_;
    }


    [CqlDeclaration("Denominator")]
    public bool? Denominator(CqlContext context)
    {
        bool? a_ = this.Initial_Population(context);

        return a_;
    }


    [CqlDeclaration("Urinary Retention Diagnosis Starts Within 1 Year After Initial BPH Diagnosis")]
    public IEnumerable<Condition> Urinary_Retention_Diagnosis_Starts_Within_1_Year_After_Initial_BPH_Diagnosis(CqlContext context)
    {
        CqlValueSet a_ = this.Urinary_retention(context);
        IEnumerable<Condition> b_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        IEnumerable<Condition> c_(Condition UrinaryRetention)
        {
            Condition g_ = this.Initial_BPH_Diagnosis_Starts_Within_6_Months_Before_the_Measurement_Period(context);
            Condition[] h_ = [
                g_,
            ];
            bool? i_(Condition InitialBPHDiagnosis)
            {
                CqlInterval<CqlDateTime> m_ = QICoreCommon_2_1_000.Instance.prevalenceInterval(context, UrinaryRetention);
                CqlDateTime n_ = context.Operators.Start(m_);
                CqlInterval<CqlDateTime> o_ = QICoreCommon_2_1_000.Instance.prevalenceInterval(context, InitialBPHDiagnosis);
                CqlDateTime p_ = context.Operators.Start(o_);
                CqlDateTime r_ = context.Operators.Start(o_);
                CqlQuantity s_ = context.Operators.Quantity(1m, "year");
                CqlDateTime t_ = context.Operators.Add(r_, s_);
                CqlInterval<CqlDateTime> u_ = context.Operators.Interval(p_, t_, true, true);
                bool? v_ = context.Operators.In<CqlDateTime>(n_, u_, "day");
                CqlDateTime x_ = context.Operators.Start(o_);
                bool? y_ = context.Operators.Not((bool?)(x_ is null));
                bool? z_ = context.Operators.And(v_, y_);

                return z_;
            };
            IEnumerable<Condition> j_ = context.Operators.Where<Condition>((IEnumerable<Condition>)h_, i_);
            Condition k_(Condition InitialBPHDiagnosis) =>
                UrinaryRetention;
            IEnumerable<Condition> l_ = context.Operators.Select<Condition, Condition>(j_, k_);

            return l_;
        };
        IEnumerable<Condition> d_ = context.Operators.SelectMany<Condition, Condition>(b_, c_);
        bool? e_(Condition UrinaryRetention)
        {
            bool? aa_ = this.isConfirmedActiveDiagnosis(context, UrinaryRetention);

            return aa_;
        };
        IEnumerable<Condition> f_ = context.Operators.Where<Condition>(d_, e_);

        return f_;
    }


    [CqlDeclaration("Has Initial BPH Diagnosis Starts During or Within 30 Days After End of Hospitalization")]
    public Condition Has_Initial_BPH_Diagnosis_Starts_During_or_Within_30_Days_After_End_of_Hospitalization(CqlContext context)
    {
        Condition a_ = this.Initial_BPH_Diagnosis_Starts_Within_6_Months_Before_the_Measurement_Period(context);
        Condition[] b_ = [
            a_,
        ];
        IEnumerable<Condition> c_(Condition InitialBPHDiagnosis)
        {
            CqlValueSet f_ = this.Hospital_Services_for_Urology(context);
            IEnumerable<Encounter> g_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, f_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
            bool? h_(Encounter InHospitalServices)
            {
                CqlInterval<CqlDateTime> l_ = QICoreCommon_2_1_000.Instance.prevalenceInterval(context, InitialBPHDiagnosis);
                CqlDateTime m_ = context.Operators.Start(l_);
                Period n_ = InHospitalServices?.Period;
                CqlInterval<CqlDateTime> o_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, n_);
                CqlDateTime p_ = context.Operators.Start(o_);
                CqlInterval<CqlDateTime> r_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, n_);
                CqlDateTime s_ = context.Operators.End(r_);
                CqlQuantity t_ = context.Operators.Quantity(31m, "days");
                CqlDateTime u_ = context.Operators.Add(s_, t_);
                CqlInterval<CqlDateTime> v_ = context.Operators.Interval(p_, u_, true, true);
                bool? w_ = context.Operators.In<CqlDateTime>(m_, v_, default);
                Code<Encounter.EncounterStatus> x_ = InHospitalServices?.StatusElement;
                Encounter.EncounterStatus? y_ = x_?.Value;
                Code<Encounter.EncounterStatus> z_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(y_);
                bool? aa_ = context.Operators.Equal(z_, "finished");
                bool? ab_ = context.Operators.And(w_, aa_);

                return ab_;
            };
            IEnumerable<Encounter> i_ = context.Operators.Where<Encounter>(g_, h_);
            Condition j_(Encounter InHospitalServices) =>
                InitialBPHDiagnosis;
            IEnumerable<Condition> k_ = context.Operators.Select<Encounter, Condition>(i_, j_);

            return k_;
        };
        IEnumerable<Condition> d_ = context.Operators.SelectMany<Condition, Condition>((IEnumerable<Condition>)b_, c_);
        Condition e_ = context.Operators.SingletonFrom<Condition>(d_);

        return e_;
    }


    [CqlDeclaration("Morbid Obesity Diagnosis On or Before Follow Up USS Assessment")]
    public IEnumerable<Condition> Morbid_Obesity_Diagnosis_On_or_Before_Follow_Up_USS_Assessment(CqlContext context)
    {
        CqlValueSet a_ = this.Morbid_Obesity(context);
        IEnumerable<Condition> b_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        IEnumerable<Condition> c_(Condition MorbidObesity)
        {
            (CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)? g_ = this.Urinary_Symptom_Score_6_to_12_Months_After_Initial_BPH_Diagnosis(context);
            (CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)?[] h_ = [
                g_,
            ];
            bool? i_((CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)? FollowUpUSSAssessment)
            {
                CqlInterval<CqlDateTime> m_ = QICoreCommon_2_1_000.Instance.prevalenceInterval(context, MorbidObesity);
                CqlInterval<CqlDateTime> n_ = this.Measurement_Period(context);
                bool? o_ = context.Operators.Overlaps(m_, n_, default);
                CqlDateTime q_ = context.Operators.Start(m_);
                CqlDateTime r_ = FollowUpUSSAssessment?.effectiveDatetime;
                bool? s_ = context.Operators.SameOrBefore(q_, r_, default);
                bool? t_ = context.Operators.And(o_, s_);

                return t_;
            };
            IEnumerable<(CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)?> j_ = context.Operators.Where<(CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)?>((IEnumerable<(CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)?>)h_, i_);
            Condition k_((CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)? FollowUpUSSAssessment) =>
                MorbidObesity;
            IEnumerable<Condition> l_ = context.Operators.Select<(CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)?, Condition>(j_, k_);

            return l_;
        };
        IEnumerable<Condition> d_ = context.Operators.SelectMany<Condition, Condition>(b_, c_);
        bool? e_(Condition MorbidObesity)
        {
            bool? u_ = this.isConfirmedActiveDiagnosis(context, MorbidObesity);

            return u_;
        };
        IEnumerable<Condition> f_ = context.Operators.Where<Condition>(d_, e_);

        return f_;
    }


    [CqlDeclaration("BMI Exam Result Greater Than or Equal To 40 During Measurement Period and On or Before Follow Up USS Assessment")]
    [CqlTag("code", "Body mass index (BMI) [Ratio] - 39156-5")]
    [CqlTag("profile", "http://hl7.org/fhir/StructureDefinition/bmi")]
    public bool? BMI_Exam_Result_Greater_Than_or_Equal_To_40_During_Measurement_Period_and_On_or_Before_Follow_Up_USS_Assessment(CqlContext context)
    {
        IEnumerable<Observation> a_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/StructureDefinition/bmi"));
        IEnumerable<Observation> b_(Observation BMIExam)
        {
            (CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)? h_ = this.Urinary_Symptom_Score_6_to_12_Months_After_Initial_BPH_Diagnosis(context);
            (CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)?[] i_ = [
                h_,
            ];
            bool? j_((CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)? FollowUpUSSAssessment)
            {
                DataType n_ = BMIExam?.Value;
                CqlQuantity o_ = FHIRHelpers_4_4_000.Instance.ToQuantity(context, n_ as Quantity);
                CqlQuantity p_ = context.Operators.Quantity(40m, "kg/m2");
                bool? q_ = context.Operators.GreaterOrEqual(o_, p_);
                Code<ObservationStatus> r_ = BMIExam?.StatusElement;
                ObservationStatus? s_ = r_?.Value;
                string t_ = context.Operators.Convert<string>(s_);
                string[] u_ = [
                    "final",
                    "amended",
                    "corrected",
                ];
                bool? v_ = context.Operators.In<string>(t_, u_ as IEnumerable<string>);
                bool? w_ = context.Operators.And(q_, v_);
                DataType x_ = BMIExam?.Effective;
                object y_ = FHIRHelpers_4_4_000.Instance.ToValue(context, x_);
                CqlDateTime z_ = QICoreCommon_2_1_000.Instance.earliest(context, y_);
                CqlInterval<CqlDateTime> aa_ = this.Measurement_Period(context);
                bool? ab_ = context.Operators.In<CqlDateTime>(z_, aa_, "day");
                bool? ac_ = context.Operators.And(w_, ab_);
                object ae_ = FHIRHelpers_4_4_000.Instance.ToValue(context, x_);
                CqlDateTime af_ = QICoreCommon_2_1_000.Instance.earliest(context, ae_);
                CqlDateTime ag_ = FollowUpUSSAssessment?.effectiveDatetime;
                bool? ah_ = context.Operators.SameOrBefore(af_, ag_, default);
                bool? ai_ = context.Operators.And(ac_, ah_);

                return ai_;
            };
            IEnumerable<(CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)?> k_ = context.Operators.Where<(CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)?>((IEnumerable<(CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)?>)i_, j_);
            Observation l_((CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)? FollowUpUSSAssessment) =>
                BMIExam;
            IEnumerable<Observation> m_ = context.Operators.Select<(CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)?, Observation>(k_, l_);

            return m_;
        };
        IEnumerable<Observation> c_ = context.Operators.SelectMany<Observation, Observation>(a_, b_);
        CqlDateTime d_(Observation BMIExam)
        {
            DataType aj_ = BMIExam?.Effective;
            object ak_ = FHIRHelpers_4_4_000.Instance.ToValue(context, aj_);
            CqlDateTime al_ = QICoreCommon_2_1_000.Instance.earliest(context, ak_);

            return al_;
        };
        IEnumerable<CqlDateTime> e_ = context.Operators.Select<Observation, CqlDateTime>(c_, d_);
        IEnumerable<CqlDateTime> f_ = context.Operators.Distinct<CqlDateTime>(e_);
        bool? g_ = context.Operators.Exists<CqlDateTime>(f_);

        return g_;
    }


    [CqlDeclaration("Morbid Obesity Diagnosis or BMI Exam Result Greater Than or Equal to 40 Starts On or Before Follow Up USS Assessment")]
    public bool? Morbid_Obesity_Diagnosis_or_BMI_Exam_Result_Greater_Than_or_Equal_to_40_Starts_On_or_Before_Follow_Up_USS_Assessment(CqlContext context)
    {
        IEnumerable<Condition> a_ = this.Morbid_Obesity_Diagnosis_On_or_Before_Follow_Up_USS_Assessment(context);
        bool? b_ = context.Operators.Exists<Condition>(a_);
        bool? c_ = this.BMI_Exam_Result_Greater_Than_or_Equal_To_40_During_Measurement_Period_and_On_or_Before_Follow_Up_USS_Assessment(context);
        bool? d_ = context.Operators.Or(b_, c_);

        return d_;
    }


    [CqlDeclaration("Denominator Exclusions")]
    public bool? Denominator_Exclusions(CqlContext context)
    {
        IEnumerable<Condition> a_ = this.Urinary_Retention_Diagnosis_Starts_Within_1_Year_After_Initial_BPH_Diagnosis(context);
        bool? b_ = context.Operators.Exists<Condition>(a_);
        Condition c_ = this.Has_Initial_BPH_Diagnosis_Starts_During_or_Within_30_Days_After_End_of_Hospitalization(context);
        bool? d_ = context.Operators.Not((bool?)(c_ is null));
        bool? e_ = context.Operators.Or(b_, d_);
        bool? f_ = this.Morbid_Obesity_Diagnosis_or_BMI_Exam_Result_Greater_Than_or_Equal_to_40_Starts_On_or_Before_Follow_Up_USS_Assessment(context);
        bool? g_ = context.Operators.Or(e_, f_);

        return g_;
    }


    [CqlDeclaration("Urinary Symptom Score Change")]
    public int? Urinary_Symptom_Score_Change(CqlContext context)
    {
        (CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)? a_ = this.Urinary_Symptom_Score_Within_1_Month_after_Initial_BPH_Diagnosis(context);
        (CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)?[] b_ = [
            a_,
        ];
        (CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)? c_ = this.Urinary_Symptom_Score_6_to_12_Months_After_Initial_BPH_Diagnosis(context);
        (CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)?[] d_ = [
            c_,
        ];
        IEnumerable<ValueTuple<(CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)?, (CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)?>> e_ = context.Operators.CrossJoin<(CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)?, (CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)?>((IEnumerable<(CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)?>)b_, (IEnumerable<(CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)?>)d_);
        (CqlTupleMetadata, (CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)? FirstUSSAssessment, (CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)? FollowUpUSSAssessment)? f_(ValueTuple<(CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)?, (CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)?> _valueTuple)
        {
            (CqlTupleMetadata, (CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)? FirstUSSAssessment, (CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)? FollowUpUSSAssessment)? l_ = (CqlTupleMetadata_FBHNjYWJgMKheadEZUgcdQGXN, _valueTuple.Item1, _valueTuple.Item2);

            return l_;
        };
        IEnumerable<(CqlTupleMetadata, (CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)? FirstUSSAssessment, (CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)? FollowUpUSSAssessment)?> g_ = context.Operators.Select<ValueTuple<(CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)?, (CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)?>, (CqlTupleMetadata, (CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)? FirstUSSAssessment, (CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)? FollowUpUSSAssessment)?>(e_, f_);
        int? h_((CqlTupleMetadata, (CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)? FirstUSSAssessment, (CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)? FollowUpUSSAssessment)? tuple_fbhnjywjgmkheadezugcdqgxn)
        {
            int? m_ = tuple_fbhnjywjgmkheadezugcdqgxn?.FirstUSSAssessment?.valueInteger;
            int? n_ = tuple_fbhnjywjgmkheadezugcdqgxn?.FollowUpUSSAssessment?.valueInteger;
            int? o_ = context.Operators.Subtract(m_, n_);

            return o_;
        };
        IEnumerable<int?> i_ = context.Operators.Select<(CqlTupleMetadata, (CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)? FirstUSSAssessment, (CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)? FollowUpUSSAssessment)?, int?>(g_, h_);
        IEnumerable<int?> j_ = context.Operators.Distinct<int?>(i_);
        int? k_ = context.Operators.SingletonFrom<int?>(j_);

        return k_;
    }


    [CqlDeclaration("Urinary Symptom Score Improvement Greater Than or Equal To 3")]
    public bool? Urinary_Symptom_Score_Improvement_Greater_Than_or_Equal_To_3(CqlContext context)
    {
        int? a_ = this.Urinary_Symptom_Score_Change(context);
        int?[] b_ = [
            a_,
        ];
        bool? c_(int? USSImprovement)
        {
            bool? g_ = context.Operators.GreaterOrEqual(USSImprovement, 3);

            return g_;
        };
        IEnumerable<int?> d_ = context.Operators.Where<int?>((IEnumerable<int?>)b_, c_);
        int? e_ = context.Operators.SingletonFrom<int?>(d_);
        bool? f_ = context.Operators.Not((bool?)(e_ is null));

        return f_;
    }


    [CqlDeclaration("Numerator")]
    public bool? Numerator(CqlContext context)
    {
        bool? a_ = this.Urinary_Symptom_Score_Improvement_Greater_Than_or_Equal_To_3(context);

        return a_;
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


    #endregion Definition Methods

    #region CqlTupleMetadata Properties

    private static CqlTupleMetadata CqlTupleMetadata_FBHNjYWJgMKheadEZUgcdQGXN = new(
        [typeof((CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)?), typeof((CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)?)],
        ["FirstUSSAssessment", "FollowUpUSSAssessment"]);

    private static CqlTupleMetadata CqlTupleMetadata_GNNDVIQPcTANSdLebhBKYIdga = new(
        [typeof(CqlDateTime), typeof(int?)],
        ["effectiveDatetime", "valueInteger"]);

    #endregion CqlTupleMetadata Properties

}

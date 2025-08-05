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

[System.CodeDom.Compiler.GeneratedCode(".NET Code Generation", "3.0.0.0")]
[CqlLibrary("OncologyPainIntensityQuantifiedFHIR", "0.1.000")]
public partial class OncologyPainIntensityQuantifiedFHIR_0_1_000 : ILibrary, ISingleton<OncologyPainIntensityQuantifiedFHIR_0_1_000>
{
    private OncologyPainIntensityQuantifiedFHIR_0_1_000() {}

    public static OncologyPainIntensityQuantifiedFHIR_0_1_000 Instance { get; } = new();

    #region ILibrary Implementation

    public string Name => "OncologyPainIntensityQuantifiedFHIR";
    public string Version => "0.1.000";
    public ILibrary[] Dependencies => [FHIRHelpers_4_4_000.Instance, CQMCommon_2_2_000.Instance, QICoreCommon_2_1_000.Instance, SupplementalDataElements_3_5_000.Instance];

    #endregion ILibrary Implementation

    #region ValueSets

    [CqlValueSetDefinition("Cancer", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1010", valueSetVersion: null)]
    public CqlValueSet Cancer(CqlContext _) => _Cancer;
    private static readonly CqlValueSet _Cancer = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1010", null);

    [CqlValueSetDefinition("Chemotherapy Administration", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1027", valueSetVersion: null)]
    public CqlValueSet Chemotherapy_Administration(CqlContext _) => _Chemotherapy_Administration;
    private static readonly CqlValueSet _Chemotherapy_Administration = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1027", null);

    [CqlValueSetDefinition("Office Visit", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1001", valueSetVersion: null)]
    public CqlValueSet Office_Visit(CqlContext _) => _Office_Visit;
    private static readonly CqlValueSet _Office_Visit = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1001", null);

    [CqlValueSetDefinition("Radiation Treatment Management", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1026", valueSetVersion: null)]
    public CqlValueSet Radiation_Treatment_Management(CqlContext _) => _Radiation_Treatment_Management;
    private static readonly CqlValueSet _Radiation_Treatment_Management = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1026", null);

    [CqlValueSetDefinition("Standardized Pain Assessment Tool", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1028", valueSetVersion: null)]
    public CqlValueSet Standardized_Pain_Assessment_Tool(CqlContext _) => _Standardized_Pain_Assessment_Tool;
    private static readonly CqlValueSet _Standardized_Pain_Assessment_Tool = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1028", null);

    #endregion ValueSets

    #region Codes

    [CqlCodeDefinition("Radiation treatment management, 5 treatments", codeId: "77427", codeSystem: "http://www.ama-assn.org/go/cpt")]
    public CqlCode Radiation_treatment_management__5_treatments(CqlContext _) => _Radiation_treatment_management__5_treatments;
    private static readonly CqlCode _Radiation_treatment_management__5_treatments = new CqlCode("77427", "http://www.ama-assn.org/go/cpt");

    #endregion Codes

    #region CodeSystems

    [CqlCodeSystemDefinition("CPT", codeSystemId: "http://www.ama-assn.org/go/cpt", codeSystemVersion: null)]
    public CqlCodeSystem CPT(CqlContext _) => _CPT;
    private static readonly CqlCodeSystem _CPT =
      new CqlCodeSystem("http://www.ama-assn.org/go/cpt", null, [
          _Radiation_treatment_management__5_treatments]);

    #endregion CodeSystems

    #region Parameters

    [CqlParameterDefinition("Measurement Period")]
    public CqlInterval<CqlDateTime> Measurement_Period(CqlContext context)
    {
        CqlDateTime a_ = context.Operators.DateTime(2025, 1, 1, 0, 0, 0, 0, 0.0m);
        CqlDateTime b_ = context.Operators.DateTime(2025, 12, 31, 23, 59, 59, 999, 0.0m);
        CqlInterval<CqlDateTime> c_ = context.Operators.Interval(a_, b_, true, true);
        object d_ = context.ResolveParameter("OncologyPainIntensityQuantifiedFHIR-0.1.000", "Measurement Period", c_);

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


    [CqlExpressionDefinition("Chemotherapy Within 31 Days Prior and During Measurement Period")]
    public IEnumerable<Procedure> Chemotherapy_Within_31_Days_Prior_and_During_Measurement_Period(CqlContext context)
    {
        CqlValueSet a_ = this.Chemotherapy_Administration(context);
        IEnumerable<Procedure> b_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
        bool? c_(Procedure ChemoAdministration)
        {
            CqlInterval<CqlDateTime> e_ = this.Measurement_Period(context);
            CqlDateTime f_ = context.Operators.Start(e_);
            CqlQuantity g_ = context.Operators.Quantity(31m, "days");
            CqlDateTime h_ = context.Operators.Subtract(f_, g_);
            CqlDateTime j_ = context.Operators.End(e_);
            CqlInterval<CqlDateTime> k_ = context.Operators.Interval(h_, j_, true, true);
            DataType l_ = ChemoAdministration?.Performed;
            object m_ = FHIRHelpers_4_4_000.Instance.ToValue(context, l_);
            CqlInterval<CqlDateTime> n_ = QICoreCommon_2_1_000.Instance.toInterval(context, m_);
            bool? o_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(k_, n_, default);
            Code<EventStatus> p_ = ChemoAdministration?.StatusElement;
            EventStatus? q_ = p_?.Value;
            string r_ = context.Operators.Convert<string>(q_);
            bool? s_ = context.Operators.Equal(r_, "completed");
            bool? t_ = context.Operators.And(o_, s_);

            return t_;
        };
        IEnumerable<Procedure> d_ = context.Operators.Where<Procedure>(b_, c_);

        return d_;
    }


    [CqlExpressionDefinition("Face to Face or Telehealth Encounter with Ongoing Chemotherapy")]
    public IEnumerable<Encounter> Face_to_Face_or_Telehealth_Encounter_with_Ongoing_Chemotherapy(CqlContext context)
    {
        CqlValueSet a_ = this.Office_Visit(context);
        IEnumerable<Encounter> b_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Procedure> c_ = this.Chemotherapy_Within_31_Days_Prior_and_During_Measurement_Period(context);
        CqlValueSet e_ = this.Cancer(context);
        IEnumerable<Condition> f_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, e_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        IEnumerable<ValueTuple<Encounter, Procedure, Procedure, Condition>> g_ = context.Operators.CrossJoin<Encounter, Procedure, Procedure, Condition>(b_, c_, c_, f_);
        (CqlTupleMetadata, Encounter FaceToFaceOrTelehealthEncounter, Procedure ChemoBeforeEncounter, Procedure ChemoAfterEncounter, Condition Cancer)? h_(ValueTuple<Encounter, Procedure, Procedure, Condition> _valueTuple)
        {
            (CqlTupleMetadata, Encounter FaceToFaceOrTelehealthEncounter, Procedure ChemoBeforeEncounter, Procedure ChemoAfterEncounter, Condition Cancer)? o_ = (CqlTupleMetadata_GEQGUKVdHYQAZdGbSEBAPcHZR, _valueTuple.Item1, _valueTuple.Item2, _valueTuple.Item3, _valueTuple.Item4);

            return o_;
        };
        IEnumerable<(CqlTupleMetadata, Encounter FaceToFaceOrTelehealthEncounter, Procedure ChemoBeforeEncounter, Procedure ChemoAfterEncounter, Condition Cancer)?> i_ = context.Operators.Select<ValueTuple<Encounter, Procedure, Procedure, Condition>, (CqlTupleMetadata, Encounter FaceToFaceOrTelehealthEncounter, Procedure ChemoBeforeEncounter, Procedure ChemoAfterEncounter, Condition Cancer)?>(g_, h_);
        bool? j_((CqlTupleMetadata, Encounter FaceToFaceOrTelehealthEncounter, Procedure ChemoBeforeEncounter, Procedure ChemoAfterEncounter, Condition Cancer)? tuple_cibligzrihjljqmithporoase)
        {
            bool? p_ = QICoreCommon_2_1_000.Instance.isActive(context, tuple_cibligzrihjljqmithporoase?.Cancer);
            CqlInterval<CqlDateTime> q_ = QICoreCommon_2_1_000.Instance.prevalenceInterval(context, tuple_cibligzrihjljqmithporoase?.Cancer);
            Period r_ = tuple_cibligzrihjljqmithporoase?.FaceToFaceOrTelehealthEncounter?.Period;
            CqlInterval<CqlDateTime> s_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, r_);
            bool? t_ = context.Operators.Overlaps(q_, s_, default);
            bool? u_ = context.Operators.And(p_, t_);
            DataType v_ = tuple_cibligzrihjljqmithporoase?.ChemoBeforeEncounter?.Performed;
            object w_ = FHIRHelpers_4_4_000.Instance.ToValue(context, v_);
            CqlInterval<CqlDateTime> x_ = QICoreCommon_2_1_000.Instance.toInterval(context, w_);
            CqlDateTime y_ = context.Operators.Start(x_);
            CqlInterval<CqlDateTime> aa_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, r_);
            CqlDateTime ab_ = context.Operators.End(aa_);
            CqlQuantity ac_ = context.Operators.Quantity(30m, "days");
            CqlDateTime ad_ = context.Operators.Subtract(ab_, ac_);
            CqlInterval<CqlDateTime> af_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, r_);
            CqlDateTime ag_ = context.Operators.End(af_);
            CqlInterval<CqlDateTime> ah_ = context.Operators.Interval(ad_, ag_, true, true);
            bool? ai_ = context.Operators.In<CqlDateTime>(y_, ah_, "day");
            CqlInterval<CqlDateTime> ak_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, r_);
            CqlDateTime al_ = context.Operators.End(ak_);
            bool? am_ = context.Operators.Not((bool?)(al_ is null));
            bool? an_ = context.Operators.And(ai_, am_);
            bool? ao_ = context.Operators.And(u_, an_);
            DataType ap_ = tuple_cibligzrihjljqmithporoase?.ChemoAfterEncounter?.Performed;
            object aq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ap_);
            CqlInterval<CqlDateTime> ar_ = QICoreCommon_2_1_000.Instance.toInterval(context, aq_);
            CqlDateTime as_ = context.Operators.Start(ar_);
            CqlInterval<CqlDateTime> au_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, r_);
            CqlDateTime av_ = context.Operators.End(au_);
            CqlInterval<CqlDateTime> ax_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, r_);
            CqlDateTime ay_ = context.Operators.End(ax_);
            CqlDateTime ba_ = context.Operators.Add(ay_, ac_);
            CqlInterval<CqlDateTime> bb_ = context.Operators.Interval(av_, ba_, true, true);
            bool? bc_ = context.Operators.In<CqlDateTime>(as_, bb_, "day");
            CqlInterval<CqlDateTime> be_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, r_);
            CqlDateTime bf_ = context.Operators.End(be_);
            bool? bg_ = context.Operators.Not((bool?)(bf_ is null));
            bool? bh_ = context.Operators.And(bc_, bg_);
            bool? bi_ = context.Operators.And(ao_, bh_);
            object bk_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ap_);
            CqlInterval<CqlDateTime> bl_ = QICoreCommon_2_1_000.Instance.toInterval(context, bk_);
            object bn_ = FHIRHelpers_4_4_000.Instance.ToValue(context, v_);
            CqlInterval<CqlDateTime> bo_ = QICoreCommon_2_1_000.Instance.toInterval(context, bn_);
            bool? bp_ = context.Operators.SameAs<CqlDateTime>(bl_, bo_, "day");
            bool? bq_ = context.Operators.Not(bp_);
            bool? br_ = context.Operators.And(bi_, bq_);
            CqlInterval<CqlDateTime> bs_ = this.Measurement_Period(context);
            CqlInterval<CqlDateTime> bu_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, r_);
            bool? bv_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(bs_, bu_, default);
            bool? bw_ = context.Operators.And(br_, bv_);
            Code<Encounter.EncounterStatus> bx_ = tuple_cibligzrihjljqmithporoase?.FaceToFaceOrTelehealthEncounter?.StatusElement;
            Encounter.EncounterStatus? by_ = bx_?.Value;
            Code<Encounter.EncounterStatus> bz_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(by_);
            bool? ca_ = context.Operators.Equal(bz_, "finished");
            bool? cb_ = context.Operators.And(bw_, ca_);

            return cb_;
        };
        IEnumerable<(CqlTupleMetadata, Encounter FaceToFaceOrTelehealthEncounter, Procedure ChemoBeforeEncounter, Procedure ChemoAfterEncounter, Condition Cancer)?> k_ = context.Operators.Where<(CqlTupleMetadata, Encounter FaceToFaceOrTelehealthEncounter, Procedure ChemoBeforeEncounter, Procedure ChemoAfterEncounter, Condition Cancer)?>(i_, j_);
        Encounter l_((CqlTupleMetadata, Encounter FaceToFaceOrTelehealthEncounter, Procedure ChemoBeforeEncounter, Procedure ChemoAfterEncounter, Condition Cancer)? tuple_cibligzrihjljqmithporoase) =>
            tuple_cibligzrihjljqmithporoase?.FaceToFaceOrTelehealthEncounter;
        IEnumerable<Encounter> m_ = context.Operators.Select<(CqlTupleMetadata, Encounter FaceToFaceOrTelehealthEncounter, Procedure ChemoBeforeEncounter, Procedure ChemoAfterEncounter, Condition Cancer)?, Encounter>(k_, l_);
        IEnumerable<Encounter> n_ = context.Operators.Distinct<Encounter>(m_);

        return n_;
    }


    [CqlExpressionDefinition("Initial Population 1")]
    public IEnumerable<Encounter> Initial_Population_1(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Face_to_Face_or_Telehealth_Encounter_with_Ongoing_Chemotherapy(context);

        return a_;
    }


    [CqlExpressionDefinition("Denominator 1")]
    public IEnumerable<Encounter> Denominator_1(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Initial_Population_1(context);

        return a_;
    }


    [CqlExpressionDefinition("Radiation Treatment Management During Measurement Period with Cancer Diagnosis")]
    public IEnumerable<Encounter> Radiation_Treatment_Management_During_Measurement_Period_with_Cancer_Diagnosis(CqlContext context)
    {
        CqlValueSet a_ = this.Radiation_Treatment_Management(context);
        IEnumerable<Encounter> b_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> c_(Encounter RadiationTreatmentManagement)
        {
            CqlValueSet g_ = this.Cancer(context);
            IEnumerable<Condition> h_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, g_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
            bool? i_(Condition Cancer)
            {
                bool? m_ = QICoreCommon_2_1_000.Instance.isActive(context, Cancer);
                CqlInterval<CqlDateTime> n_ = QICoreCommon_2_1_000.Instance.prevalenceInterval(context, Cancer);
                Period o_ = RadiationTreatmentManagement?.Period;
                CqlInterval<CqlDateTime> p_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, o_);
                bool? q_ = context.Operators.Overlaps(n_, p_, default);
                bool? r_ = context.Operators.And(m_, q_);

                return r_;
            };
            IEnumerable<Condition> j_ = context.Operators.Where<Condition>(h_, i_);
            Encounter k_(Condition Cancer) =>
                RadiationTreatmentManagement;
            IEnumerable<Encounter> l_ = context.Operators.Select<Condition, Encounter>(j_, k_);

            return l_;
        };
        IEnumerable<Encounter> d_ = context.Operators.SelectMany<Encounter, Encounter>(b_, c_);
        bool? e_(Encounter RadiationTreatmentManagement)
        {
            CqlInterval<CqlDateTime> s_ = this.Measurement_Period(context);
            Period t_ = RadiationTreatmentManagement?.Period;
            CqlInterval<CqlDateTime> u_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, t_);
            bool? v_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(s_, u_, default);
            Code<Encounter.EncounterStatus> w_ = RadiationTreatmentManagement?.StatusElement;
            Encounter.EncounterStatus? x_ = w_?.Value;
            Code<Encounter.EncounterStatus> y_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(x_);
            bool? z_ = context.Operators.Equal(y_, "finished");
            bool? aa_ = context.Operators.And(v_, z_);

            return aa_;
        };
        IEnumerable<Encounter> f_ = context.Operators.Where<Encounter>(d_, e_);

        return f_;
    }


    [CqlExpressionDefinition("Initial Population 2")]
    public IEnumerable<Encounter> Initial_Population_2(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Radiation_Treatment_Management_During_Measurement_Period_with_Cancer_Diagnosis(context);

        return a_;
    }


    [CqlExpressionDefinition("Denominator 2")]
    public IEnumerable<Encounter> Denominator_2(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Initial_Population_2(context);

        return a_;
    }


    [CqlExpressionDefinition("Standard Pain Assessment with Result")]
    public IEnumerable<Observation> Standard_Pain_Assessment_with_Result(CqlContext context)
    {
        CqlValueSet a_ = this.Standardized_Pain_Assessment_Tool(context);
        IEnumerable<Observation> b_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
        bool? c_(Observation AssessedPain)
        {
            DataType e_ = AssessedPain?.Value;
            object f_ = FHIRHelpers_4_4_000.Instance.ToValue(context, e_);
            bool? g_ = context.Operators.Not((bool?)(f_ is null));
            Code<ObservationStatus> h_ = AssessedPain?.StatusElement;
            ObservationStatus? i_ = h_?.Value;
            Code<ObservationStatus> j_ = context.Operators.Convert<Code<ObservationStatus>>(i_);
            bool? k_ = context.Operators.Equal(j_, "final");
            bool? l_ = context.Operators.And(g_, k_);

            return l_;
        };
        IEnumerable<Observation> d_ = context.Operators.Where<Observation>(b_, c_);

        return d_;
    }


    [CqlExpressionDefinition("Numerator 1")]
    public IEnumerable<Encounter> Numerator_1(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Face_to_Face_or_Telehealth_Encounter_with_Ongoing_Chemotherapy(context);
        IEnumerable<Encounter> b_(Encounter FaceToFaceOrTelehealthEncounterWithChemo)
        {
            IEnumerable<Observation> d_ = this.Standard_Pain_Assessment_with_Result(context);
            bool? e_(Observation PainAssessed)
            {
                Period i_ = FaceToFaceOrTelehealthEncounterWithChemo?.Period;
                CqlInterval<CqlDateTime> j_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, i_);
                DataType k_ = PainAssessed?.Effective;
                object l_ = FHIRHelpers_4_4_000.Instance.ToValue(context, k_);
                CqlInterval<CqlDateTime> m_ = QICoreCommon_2_1_000.Instance.toInterval(context, l_);
                bool? n_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(j_, m_, default);

                return n_;
            };
            IEnumerable<Observation> f_ = context.Operators.Where<Observation>(d_, e_);
            Encounter g_(Observation PainAssessed) =>
                FaceToFaceOrTelehealthEncounterWithChemo;
            IEnumerable<Encounter> h_ = context.Operators.Select<Observation, Encounter>(f_, g_);

            return h_;
        };
        IEnumerable<Encounter> c_ = context.Operators.SelectMany<Encounter, Encounter>(a_, b_);

        return c_;
    }


    [CqlExpressionDefinition("Numerator 2")]
    public IEnumerable<Encounter> Numerator_2(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Radiation_Treatment_Management_During_Measurement_Period_with_Cancer_Diagnosis(context);
        IEnumerable<Encounter> b_(Encounter RadiationManagementEncounter)
        {
            IEnumerable<Observation> d_ = this.Standard_Pain_Assessment_with_Result(context);
            bool? e_(Observation PainAssessed)
            {
                bool? i_()
                {
                    bool j_()
                    {
                        List<CodeableConcept> k_ = RadiationManagementEncounter?.Type;
                        CqlConcept l_(CodeableConcept @this)
                        {
                            CqlConcept q_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);

                            return q_;
                        };
                        IEnumerable<CqlConcept> m_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)k_, l_);
                        bool? n_(CqlConcept RadiationManagement)
                        {
                            CqlCode r_ = this.Radiation_treatment_management__5_treatments(context);
                            CqlConcept s_ = context.Operators.ConvertCodeToConcept(r_);
                            bool? t_ = context.Operators.Equivalent(RadiationManagement, s_);

                            return t_;
                        };
                        IEnumerable<CqlConcept> o_ = context.Operators.Where<CqlConcept>(m_, n_);
                        bool? p_ = context.Operators.Exists<CqlConcept>(o_);

                        return p_ ?? false;
                    };
                    if (j_())
                    {
                        DataType u_ = PainAssessed?.Effective;
                        object v_ = FHIRHelpers_4_4_000.Instance.ToValue(context, u_);
                        CqlInterval<CqlDateTime> w_ = QICoreCommon_2_1_000.Instance.toInterval(context, v_);
                        CqlDateTime x_ = context.Operators.End(w_);
                        Period y_ = RadiationManagementEncounter?.Period;
                        CqlInterval<CqlDateTime> z_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, y_);
                        CqlDateTime aa_ = context.Operators.Start(z_);
                        CqlQuantity ab_ = context.Operators.Quantity(6m, "days");
                        CqlDateTime ac_ = context.Operators.Subtract(aa_, ab_);
                        CqlInterval<CqlDateTime> ae_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, y_);
                        CqlDateTime af_ = context.Operators.Start(ae_);
                        CqlInterval<CqlDateTime> ag_ = context.Operators.Interval(ac_, af_, true, true);
                        bool? ah_ = context.Operators.In<CqlDateTime>(x_, ag_, "day");
                        CqlInterval<CqlDateTime> aj_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, y_);
                        CqlDateTime ak_ = context.Operators.Start(aj_);
                        bool? al_ = context.Operators.Not((bool?)(ak_ is null));
                        bool? am_ = context.Operators.And(ah_, al_);

                        return am_;
                    }
                    else
                    {
                        Period an_ = RadiationManagementEncounter?.Period;
                        CqlInterval<CqlDateTime> ao_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, an_);
                        DataType ap_ = PainAssessed?.Effective;
                        object aq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ap_);
                        CqlInterval<CqlDateTime> ar_ = QICoreCommon_2_1_000.Instance.toInterval(context, aq_);
                        bool? as_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(ao_, ar_, "day");

                        return as_;
                    }
                };

                return i_();
            };
            IEnumerable<Observation> f_ = context.Operators.Where<Observation>(d_, e_);
            Encounter g_(Observation PainAssessed) =>
                RadiationManagementEncounter;
            IEnumerable<Encounter> h_ = context.Operators.Select<Observation, Encounter>(f_, g_);

            return h_;
        };
        IEnumerable<Encounter> c_ = context.Operators.SelectMany<Encounter, Encounter>(a_, b_);

        return c_;
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

    private static CqlTupleMetadata CqlTupleMetadata_GEQGUKVdHYQAZdGbSEBAPcHZR = new(
      [typeof(Encounter), typeof(Procedure), typeof(Procedure), typeof(Condition)],
      ["FaceToFaceOrTelehealthEncounter", "ChemoBeforeEncounter", "ChemoAfterEncounter", "Cancer"]);

    #endregion CqlTupleMetadata Properties

}

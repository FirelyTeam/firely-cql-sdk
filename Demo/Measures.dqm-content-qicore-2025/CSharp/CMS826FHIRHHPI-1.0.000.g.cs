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
using Hl7.Cql.Runtime.Internal;
using Hl7.Fhir.Model;
using Range = Hl7.Fhir.Model.Range;
using Task = Hl7.Fhir.Model.Task;

[System.CodeDom.Compiler.GeneratedCode(".NET Code Generation", "6.0.0.0")]
[CqlLibrary("CMS826FHIRHHPI", "1.0.000")]
public partial class CMS826FHIRHHPI_1_0_000 : ILibrary, ILibraryInternals, ISingleton<CMS826FHIRHHPI_1_0_000>
{
    #region ValueSets (7)

    [CqlValueSetDefinition("Encounter Inpatient", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.666.5.307", valueSetVersion: null)]
    public CqlValueSet Encounter_Inpatient(CqlContext _) => _Encounter_Inpatient;
    private static readonly CqlValueSet _Encounter_Inpatient = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.666.5.307", null);

    [CqlValueSetDefinition("Not Present On Admission or Documentation Insufficient to Determine", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1147.198", valueSetVersion: null)]
    public CqlValueSet Not_Present_On_Admission_or_Documentation_Insufficient_to_Determine(CqlContext _) => _Not_Present_On_Admission_or_Documentation_Insufficient_to_Determine;
    private static readonly CqlValueSet _Not_Present_On_Admission_or_Documentation_Insufficient_to_Determine = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1147.198", null);

    [CqlValueSetDefinition("Present on Admission or Clinically Undetermined", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1147.197", valueSetVersion: null)]
    public CqlValueSet Present_on_Admission_or_Clinically_Undetermined(CqlContext _) => _Present_on_Admission_or_Clinically_Undetermined;
    private static readonly CqlValueSet _Present_on_Admission_or_Clinically_Undetermined = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1147.197", null);

    [CqlValueSetDefinition("Pressure Injury Deep Tissue", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1147.112", valueSetVersion: null)]
    public CqlValueSet Pressure_Injury_Deep_Tissue(CqlContext _) => _Pressure_Injury_Deep_Tissue;
    private static readonly CqlValueSet _Pressure_Injury_Deep_Tissue = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1147.112", null);

    [CqlValueSetDefinition("Pressure Injury Deep Tissue Diagnoses", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1147.194", valueSetVersion: null)]
    public CqlValueSet Pressure_Injury_Deep_Tissue_Diagnoses(CqlContext _) => _Pressure_Injury_Deep_Tissue_Diagnoses;
    private static readonly CqlValueSet _Pressure_Injury_Deep_Tissue_Diagnoses = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1147.194", null);

    [CqlValueSetDefinition("Pressure Injury Stage 2, 3, 4 or Unstageable", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1147.113", valueSetVersion: null)]
    public CqlValueSet Pressure_Injury_Stage_2__3__4_or_Unstageable(CqlContext _) => _Pressure_Injury_Stage_2__3__4_or_Unstageable;
    private static readonly CqlValueSet _Pressure_Injury_Stage_2__3__4_or_Unstageable = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1147.113", null);

    [CqlValueSetDefinition("Pressure Injury Stage 2, 3, 4, or Unstageable Diagnoses", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1147.196", valueSetVersion: null)]
    public CqlValueSet Pressure_Injury_Stage_2__3__4__or_Unstageable_Diagnoses(CqlContext _) => _Pressure_Injury_Stage_2__3__4__or_Unstageable_Diagnoses;
    private static readonly CqlValueSet _Pressure_Injury_Stage_2__3__4__or_Unstageable_Diagnoses = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1147.196", null);

    #endregion ValueSets

    #region Codes (1)

    [CqlCodeDefinition("Physical findings of Skin", codeId: "8709-8", codeSystem: "http://loinc.org")]
    public CqlCode Physical_findings_of_Skin(CqlContext _) => _Physical_findings_of_Skin;
    private static readonly CqlCode _Physical_findings_of_Skin = new CqlCode("8709-8", "http://loinc.org");

    #endregion Codes

    #region CodeSystems (1)

    [CqlCodeSystemDefinition("LOINC", codeSystemId: "http://loinc.org", codeSystemVersion: null)]
    public CqlCodeSystem LOINC(CqlContext _) => _LOINC;
    private static readonly CqlCodeSystem _LOINC =
      new CqlCodeSystem("http://loinc.org", null, [
          _Physical_findings_of_Skin]);

    #endregion CodeSystems

    #region Parameters (1)

    [CqlParameterDefinition("Measurement Period")]
    public CqlInterval<CqlDateTime> Measurement_Period(CqlContext context) =>
        ((ICqlContextInternals)context).GetOrCompute<CqlInterval<CqlDateTime>>(
            _cacheIndex_Measurement_Period,
            Measurement_Period_Compute);

    private CqlInterval<CqlDateTime> Measurement_Period_Compute(CqlContext context)
    {
        CqlDateTime a_ = context.Operators.DateTime(2026, 1, 1, 0, 0, 0, 0, 0.0m);
        CqlDateTime b_ = context.Operators.DateTime(2027, 1, 1, 0, 0, 0, 0, 0.0m);
        CqlInterval<CqlDateTime> c_ = context.Operators.Interval(a_, b_, true, false);
        object d_ = context.ResolveParameter("CMS826FHIRHHPI-1.0.000", "Measurement Period", c_);
        return (CqlInterval<CqlDateTime>)d_;
    }


    #endregion Parameters

    #region Functions and Expressions (26)

    [CqlExpressionDefinition("Patient")]
    public Patient Patient(CqlContext context) =>
        ((ICqlContextInternals)context).GetOrCompute<Patient>(
            _cacheIndex_Patient,
            Patient_Compute);

    private Patient Patient_Compute(CqlContext context)
    {
        IEnumerable<Patient> a_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-patient"));
        Patient b_ = context.Operators.SingletonFrom<Patient>(a_);
        return b_;
    }


    [CqlExpressionDefinition("SDE Ethnicity")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Ethnicity(CqlContext context) =>
        ((ICqlContextInternals)context).GetOrCompute<(CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)?>(
            _cacheIndex_SDE_Ethnicity,
            SDE_Ethnicity_Compute);

    private (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Ethnicity_Compute(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? a_ = SupplementalDataElements_5_1_000.Instance.SDE_Ethnicity(context);
        return a_;
    }


    [CqlExpressionDefinition("SDE Payer")]
    public IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> SDE_Payer(CqlContext context) =>
        ((ICqlContextInternals)context).GetOrCompute<IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?>>(
            _cacheIndex_SDE_Payer,
            SDE_Payer_Compute);

    private IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> SDE_Payer_Compute(CqlContext context)
    {
        IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> a_ = SupplementalDataElements_5_1_000.Instance.SDE_Payer(context);
        return a_;
    }


    [CqlExpressionDefinition("SDE Race")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Race(CqlContext context) =>
        ((ICqlContextInternals)context).GetOrCompute<(CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)?>(
            _cacheIndex_SDE_Race,
            SDE_Race_Compute);

    private (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Race_Compute(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? a_ = SupplementalDataElements_5_1_000.Instance.SDE_Race(context);
        return a_;
    }


    [CqlExpressionDefinition("SDE Sex")]
    public CqlCode SDE_Sex(CqlContext context) =>
        ((ICqlContextInternals)context).GetOrCompute<CqlCode>(
            _cacheIndex_SDE_Sex,
            SDE_Sex_Compute);

    private CqlCode SDE_Sex_Compute(CqlContext context)
    {
        CqlCode a_ = SupplementalDataElements_5_1_000.Instance.SDE_Sex(context);
        return a_;
    }


    [CqlExpressionDefinition("Encounter With Age 18 And Older")]
    public IEnumerable<Encounter> Encounter_With_Age_18_And_Older(CqlContext context) =>
        ((ICqlContextInternals)context).GetOrCompute<IEnumerable<Encounter>>(
            _cacheIndex_Encounter_With_Age_18_And_Older,
            Encounter_With_Age_18_And_Older_Compute);

    private IEnumerable<Encounter> Encounter_With_Age_18_And_Older_Compute(CqlContext context)
    {
        CqlValueSet a_ = this.Encounter_Inpatient(context);
        IEnumerable<Encounter> b_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));

        bool? c_(Encounter InpatientEncounter) {
            Patient e_ = this.Patient(context);
            Date f_ = e_?.BirthDateElement;
            string g_ = f_?.Value;
            CqlDate h_ = context.Operators.ConvertStringToDate(g_);
            Period i_ = InpatientEncounter?.Period;
            CqlInterval<CqlDateTime> j_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, i_);
            CqlDateTime k_ = context.Operators.Start(j_);
            CqlDate l_ = context.Operators.DateFrom(k_);
            int? m_ = context.Operators.CalculateAgeAt(h_, l_, "year");
            bool? n_ = context.Operators.GreaterOrEqual(m_, 18);
            CqlInterval<CqlDateTime> p_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, i_);
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
        }

        IEnumerable<Encounter> d_ = context.Operators.Where<Encounter>(b_, c_);
        return d_;
    }


    [CqlExpressionDefinition("Initial Population")]
    public IEnumerable<Encounter> Initial_Population(CqlContext context) =>
        ((ICqlContextInternals)context).GetOrCompute<IEnumerable<Encounter>>(
            _cacheIndex_Initial_Population,
            Initial_Population_Compute);

    private IEnumerable<Encounter> Initial_Population_Compute(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Encounter_With_Age_18_And_Older(context);
        return a_;
    }


    [CqlExpressionDefinition("Denominator")]
    public IEnumerable<Encounter> Denominator(CqlContext context) =>
        ((ICqlContextInternals)context).GetOrCompute<IEnumerable<Encounter>>(
            _cacheIndex_Denominator,
            Denominator_Compute);

    private IEnumerable<Encounter> Denominator_Compute(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Initial_Population(context);
        return a_;
    }


    [CqlExpressionDefinition("Encounter With Deep Tissue Pressure Injury POA By Indicator")]
    public IEnumerable<Encounter> Encounter_With_Deep_Tissue_Pressure_Injury_POA_By_Indicator(CqlContext context) =>
        ((ICqlContextInternals)context).GetOrCompute<IEnumerable<Encounter>>(
            _cacheIndex_Encounter_With_Deep_Tissue_Pressure_Injury_POA_By_Indicator,
            Encounter_With_Deep_Tissue_Pressure_Injury_POA_By_Indicator_Compute);

    private IEnumerable<Encounter> Encounter_With_Deep_Tissue_Pressure_Injury_POA_By_Indicator_Compute(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Encounter_With_Age_18_And_Older(context);

        bool? b_(Encounter InpatientHospitalization) {
            CqlValueSet d_ = this.Pressure_Injury_Deep_Tissue_Diagnoses(context);
            CqlValueSet e_ = this.Present_on_Admission_or_Clinically_Undetermined(context);
            bool? f_ = CQMCommon_4_1_000.Instance.isDiagnosisPresentOnAdmission(context, InpatientHospitalization, d_, e_);
            return f_;
        }

        IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);
        return c_;
    }


    [CqlFunctionDefinition("isIn")]
    public bool? isIn(CqlContext context, object observation, CqlValueSet vset)
    {
        object a_ = context.Operators.LateBoundProperty<object>(observation, "status");
        string b_ = context.Operators.LateBoundProperty<string>(a_, "value");
        string[] c_ = [
            "final",
            "amended",
            "corrected",
        ];
        bool? d_ = context.Operators.In<string>(b_, (IEnumerable<string>)c_);
        CqlInterval<CqlDateTime> e_ = this.Measurement_Period(context);
        object f_ = context.Operators.LateBoundProperty<object>(observation, "effective");
        object g_ = FHIRHelpers_4_4_000.Instance.ToValue(context, f_);
        CqlInterval<CqlDateTime> h_ = QICoreCommon_4_0_000.Instance.toInterval(context, g_);
        bool? i_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(e_, h_, default);
        bool? j_ = context.Operators.And(d_, i_);

        bool? k_() {
            if (observation is Observation)
            {
                DataType m_ = (observation as Observation)?.Value;
                object n_ = FHIRHelpers_4_4_000.Instance.ToValue(context, m_);
                bool? o_ = context.Operators.ConceptInValueSet(n_ as CqlConcept, vset);
                return o_;
            }
            else if (observation is Observation)
            {
                DataType p_ = (observation as Observation)?.Value;
                object q_ = FHIRHelpers_4_4_000.Instance.ToValue(context, p_);
                bool? r_ = context.Operators.ConceptInValueSet(q_ as CqlConcept, vset);
                return r_;
            }
            else
            {
                return default;
            };
        }

        bool? l_ = context.Operators.And(j_, k_());
        return l_;
    }


    [CqlExpressionDefinition("Clinical Skin Exams With Pressure Injury")]
    public IEnumerable<Observation> Clinical_Skin_Exams_With_Pressure_Injury(CqlContext context) =>
        ((ICqlContextInternals)context).GetOrCompute<IEnumerable<Observation>>(
            _cacheIndex_Clinical_Skin_Exams_With_Pressure_Injury,
            Clinical_Skin_Exams_With_Pressure_Injury_Compute);

    private IEnumerable<Observation> Clinical_Skin_Exams_With_Pressure_Injury_Compute(CqlContext context)
    {
        CqlCode a_ = this.Physical_findings_of_Skin(context);
        IEnumerable<CqlCode> b_ = context.Operators.ToList<CqlCode>(a_);
        IEnumerable<Observation> c_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, b_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation-clinical-result"));

        bool? d_(Observation ClinicalSkinExam) {
            CqlValueSet f_ = this.Pressure_Injury_Stage_2__3__4_or_Unstageable(context);
            bool? g_ = this.isIn(context, ClinicalSkinExam as object, f_);
            return g_;
        }

        IEnumerable<Observation> e_ = context.Operators.Where<Observation>(c_, d_);
        return e_;
    }


    [CqlExpressionDefinition("Simple Skin Exams With Pressure Injury")]
    public IEnumerable<Observation> Simple_Skin_Exams_With_Pressure_Injury(CqlContext context) =>
        ((ICqlContextInternals)context).GetOrCompute<IEnumerable<Observation>>(
            _cacheIndex_Simple_Skin_Exams_With_Pressure_Injury,
            Simple_Skin_Exams_With_Pressure_Injury_Compute);

    private IEnumerable<Observation> Simple_Skin_Exams_With_Pressure_Injury_Compute(CqlContext context)
    {
        CqlCode a_ = this.Physical_findings_of_Skin(context);
        IEnumerable<CqlCode> b_ = context.Operators.ToList<CqlCode>(a_);
        IEnumerable<Observation> c_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, b_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-simple-observation"));

        bool? d_(Observation ObsSkinExam) {
            CqlValueSet f_ = this.Pressure_Injury_Stage_2__3__4_or_Unstageable(context);
            bool? g_ = this.isIn(context, ObsSkinExam as object, f_);
            return g_;
        }

        IEnumerable<Observation> e_ = context.Operators.Where<Observation>(c_, d_);
        return e_;
    }


    [CqlExpressionDefinition("Skin Exams With Pressure Injury")]
    public IEnumerable<object> Skin_Exams_With_Pressure_Injury(CqlContext context) =>
        ((ICqlContextInternals)context).GetOrCompute<IEnumerable<object>>(
            _cacheIndex_Skin_Exams_With_Pressure_Injury,
            Skin_Exams_With_Pressure_Injury_Compute);

    private IEnumerable<object> Skin_Exams_With_Pressure_Injury_Compute(CqlContext context)
    {
        IEnumerable<Observation> a_ = this.Clinical_Skin_Exams_With_Pressure_Injury(context);
        IEnumerable<Observation> b_ = this.Simple_Skin_Exams_With_Pressure_Injury(context);
        IEnumerable<object> c_ = context.Operators.Union<object>(a_ as IEnumerable<object>, b_ as IEnumerable<object>);
        return c_;
    }


    [CqlExpressionDefinition("Encounter With Deep Tissue Pressure Injury POA By Skin Exam Within First 72 Hours")]
    public IEnumerable<Encounter> Encounter_With_Deep_Tissue_Pressure_Injury_POA_By_Skin_Exam_Within_First_72_Hours(CqlContext context) =>
        ((ICqlContextInternals)context).GetOrCompute<IEnumerable<Encounter>>(
            _cacheIndex_Encounter_With_Deep_Tissue_Pressure_Injury_POA_By_Skin_Exam_Within_First_72_Hours,
            Encounter_With_Deep_Tissue_Pressure_Injury_POA_By_Skin_Exam_Within_First_72_Hours_Compute);

    private IEnumerable<Encounter> Encounter_With_Deep_Tissue_Pressure_Injury_POA_By_Skin_Exam_Within_First_72_Hours_Compute(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Encounter_With_Age_18_And_Older(context);

        IEnumerable<Encounter> b_(Encounter InpatientHospitalization) {
            IEnumerable<object> d_ = this.Skin_Exams_With_Pressure_Injury(context);

            bool? e_(object SkinExam) {
                object i_ = context.Operators.LateBoundProperty<object>(SkinExam, "effective");
                object j_ = FHIRHelpers_4_4_000.Instance.ToValue(context, i_);
                CqlInterval<CqlDateTime> k_ = QICoreCommon_4_0_000.Instance.toInterval(context, j_);
                CqlDateTime l_ = context.Operators.Start(k_);
                CqlInterval<CqlDateTime> m_ = CQMCommon_4_1_000.Instance.hospitalizationWithObservation(context, InpatientHospitalization);
                CqlDateTime n_ = context.Operators.Start(m_);
                CqlDateTime p_ = context.Operators.Start(m_);
                CqlQuantity q_ = context.Operators.Quantity(72m, "hours");
                CqlDateTime r_ = context.Operators.Add(p_, q_);
                CqlInterval<CqlDateTime> s_ = context.Operators.Interval(n_, r_, true, true);
                bool? t_ = context.Operators.In<CqlDateTime>(l_, s_, default);
                return t_;
            }

            IEnumerable<object> f_ = context.Operators.Where<object>(d_, e_);
            Encounter g_(object SkinExam) => InpatientHospitalization;
            IEnumerable<Encounter> h_ = context.Operators.Select<object, Encounter>(f_, g_);
            return h_;
        }

        IEnumerable<Encounter> c_ = context.Operators.SelectMany<Encounter, Encounter>(a_, b_);
        return c_;
    }


    [CqlExpressionDefinition("Encounter With Deep Tissue Pressure Injury POA By Indicator Or Skin Exam Within First 72 Hours")]
    public IEnumerable<Encounter> Encounter_With_Deep_Tissue_Pressure_Injury_POA_By_Indicator_Or_Skin_Exam_Within_First_72_Hours(CqlContext context) =>
        ((ICqlContextInternals)context).GetOrCompute<IEnumerable<Encounter>>(
            _cacheIndex_Encounter_With_Deep_Tissue_Pressure_Injury_POA_By_Indicator_Or_Skin_Exam_Within_First_72_Hours,
            Encounter_With_Deep_Tissue_Pressure_Injury_POA_By_Indicator_Or_Skin_Exam_Within_First_72_Hours_Compute);

    private IEnumerable<Encounter> Encounter_With_Deep_Tissue_Pressure_Injury_POA_By_Indicator_Or_Skin_Exam_Within_First_72_Hours_Compute(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Encounter_With_Deep_Tissue_Pressure_Injury_POA_By_Indicator(context);
        IEnumerable<Encounter> b_ = this.Encounter_With_Deep_Tissue_Pressure_Injury_POA_By_Skin_Exam_Within_First_72_Hours(context);
        IEnumerable<Encounter> c_ = context.Operators.Union<Encounter>(a_, b_);
        return c_;
    }


    [CqlExpressionDefinition("Encounter With Stage 2, 3, 4, Or Unstageable Pressure Injury Present On Admission By POA Indicator")]
    public IEnumerable<Encounter> Encounter_With_Stage_2__3__4__Or_Unstageable_Pressure_Injury_Present_On_Admission_By_POA_Indicator(CqlContext context) =>
        ((ICqlContextInternals)context).GetOrCompute<IEnumerable<Encounter>>(
            _cacheIndex_Encounter_With_Stage_2__3__4__Or_Unstageable_Pressure_Injury_Present_On_Admission_By_POA_Indicator,
            Encounter_With_Stage_2__3__4__Or_Unstageable_Pressure_Injury_Present_On_Admission_By_POA_Indicator_Compute);

    private IEnumerable<Encounter> Encounter_With_Stage_2__3__4__Or_Unstageable_Pressure_Injury_Present_On_Admission_By_POA_Indicator_Compute(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Encounter_With_Age_18_And_Older(context);

        bool? b_(Encounter InpatientHospitalization) {
            CqlValueSet d_ = this.Pressure_Injury_Stage_2__3__4__or_Unstageable_Diagnoses(context);
            CqlValueSet e_ = this.Present_on_Admission_or_Clinically_Undetermined(context);
            bool? f_ = CQMCommon_4_1_000.Instance.isDiagnosisPresentOnAdmission(context, InpatientHospitalization, d_, e_);
            return f_;
        }

        IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);
        return c_;
    }


    [CqlExpressionDefinition("Encounter With Stage 2, 3, 4 Or Unstageable Pressure Injury POA By Skin Exam Within 24 Hours")]
    public IEnumerable<Encounter> Encounter_With_Stage_2__3__4_Or_Unstageable_Pressure_Injury_POA_By_Skin_Exam_Within_24_Hours(CqlContext context) =>
        ((ICqlContextInternals)context).GetOrCompute<IEnumerable<Encounter>>(
            _cacheIndex_Encounter_With_Stage_2__3__4_Or_Unstageable_Pressure_Injury_POA_By_Skin_Exam_Within_24_Hours,
            Encounter_With_Stage_2__3__4_Or_Unstageable_Pressure_Injury_POA_By_Skin_Exam_Within_24_Hours_Compute);

    private IEnumerable<Encounter> Encounter_With_Stage_2__3__4_Or_Unstageable_Pressure_Injury_POA_By_Skin_Exam_Within_24_Hours_Compute(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Encounter_With_Age_18_And_Older(context);

        IEnumerable<Encounter> b_(Encounter InpatientHospitalization) {
            IEnumerable<object> d_ = this.Skin_Exams_With_Pressure_Injury(context);

            bool? e_(object SkinExam) {
                object i_ = context.Operators.LateBoundProperty<object>(SkinExam, "effective");
                object j_ = FHIRHelpers_4_4_000.Instance.ToValue(context, i_);
                CqlInterval<CqlDateTime> k_ = QICoreCommon_4_0_000.Instance.toInterval(context, j_);
                CqlDateTime l_ = context.Operators.Start(k_);
                CqlInterval<CqlDateTime> m_ = CQMCommon_4_1_000.Instance.hospitalizationWithObservation(context, InpatientHospitalization);
                CqlDateTime n_ = context.Operators.Start(m_);
                CqlDateTime p_ = context.Operators.Start(m_);
                CqlQuantity q_ = context.Operators.Quantity(24m, "hours");
                CqlDateTime r_ = context.Operators.Add(p_, q_);
                CqlInterval<CqlDateTime> s_ = context.Operators.Interval(n_, r_, true, true);
                bool? t_ = context.Operators.In<CqlDateTime>(l_, s_, default);
                return t_;
            }

            IEnumerable<object> f_ = context.Operators.Where<object>(d_, e_);
            Encounter g_(object SkinExam) => InpatientHospitalization;
            IEnumerable<Encounter> h_ = context.Operators.Select<object, Encounter>(f_, g_);
            return h_;
        }

        IEnumerable<Encounter> c_ = context.Operators.SelectMany<Encounter, Encounter>(a_, b_);
        return c_;
    }


    [CqlExpressionDefinition("Encounter With Stage 2, 3, 4 Or Unstageable Pressure Injury POA")]
    public IEnumerable<Encounter> Encounter_With_Stage_2__3__4_Or_Unstageable_Pressure_Injury_POA(CqlContext context) =>
        ((ICqlContextInternals)context).GetOrCompute<IEnumerable<Encounter>>(
            _cacheIndex_Encounter_With_Stage_2__3__4_Or_Unstageable_Pressure_Injury_POA,
            Encounter_With_Stage_2__3__4_Or_Unstageable_Pressure_Injury_POA_Compute);

    private IEnumerable<Encounter> Encounter_With_Stage_2__3__4_Or_Unstageable_Pressure_Injury_POA_Compute(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Encounter_With_Stage_2__3__4__Or_Unstageable_Pressure_Injury_Present_On_Admission_By_POA_Indicator(context);
        IEnumerable<Encounter> b_ = this.Encounter_With_Stage_2__3__4_Or_Unstageable_Pressure_Injury_POA_By_Skin_Exam_Within_24_Hours(context);
        IEnumerable<Encounter> c_ = context.Operators.Union<Encounter>(a_, b_);
        return c_;
    }


    [CqlExpressionDefinition("Denominator Exclusions")]
    public IEnumerable<Encounter> Denominator_Exclusions(CqlContext context) =>
        ((ICqlContextInternals)context).GetOrCompute<IEnumerable<Encounter>>(
            _cacheIndex_Denominator_Exclusions,
            Denominator_Exclusions_Compute);

    private IEnumerable<Encounter> Denominator_Exclusions_Compute(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Encounter_With_Deep_Tissue_Pressure_Injury_POA_By_Indicator_Or_Skin_Exam_Within_First_72_Hours(context);
        IEnumerable<Encounter> b_ = this.Encounter_With_Stage_2__3__4_Or_Unstageable_Pressure_Injury_POA(context);
        IEnumerable<Encounter> c_ = context.Operators.Union<Encounter>(a_, b_);
        return c_;
    }


    [CqlExpressionDefinition("Encounter With New Deep Tissue Pressure Injury Not POA By Indicator")]
    public IEnumerable<Encounter> Encounter_With_New_Deep_Tissue_Pressure_Injury_Not_POA_By_Indicator(CqlContext context) =>
        ((ICqlContextInternals)context).GetOrCompute<IEnumerable<Encounter>>(
            _cacheIndex_Encounter_With_New_Deep_Tissue_Pressure_Injury_Not_POA_By_Indicator,
            Encounter_With_New_Deep_Tissue_Pressure_Injury_Not_POA_By_Indicator_Compute);

    private IEnumerable<Encounter> Encounter_With_New_Deep_Tissue_Pressure_Injury_Not_POA_By_Indicator_Compute(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Encounter_With_Age_18_And_Older(context);

        bool? b_(Encounter InpatientHospitalization) {
            CqlValueSet d_ = this.Pressure_Injury_Deep_Tissue_Diagnoses(context);
            CqlValueSet e_ = this.Not_Present_On_Admission_or_Documentation_Insufficient_to_Determine(context);
            bool? f_ = CQMCommon_4_1_000.Instance.isDiagnosisPresentOnAdmission(context, InpatientHospitalization, d_, e_);
            return f_;
        }

        IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);
        return c_;
    }


    [CqlExpressionDefinition("Encounter With New Deep Tissue Pressure Injury By Skin Exam After First 72 Hours")]
    public IEnumerable<Encounter> Encounter_With_New_Deep_Tissue_Pressure_Injury_By_Skin_Exam_After_First_72_Hours(CqlContext context) =>
        ((ICqlContextInternals)context).GetOrCompute<IEnumerable<Encounter>>(
            _cacheIndex_Encounter_With_New_Deep_Tissue_Pressure_Injury_By_Skin_Exam_After_First_72_Hours,
            Encounter_With_New_Deep_Tissue_Pressure_Injury_By_Skin_Exam_After_First_72_Hours_Compute);

    private IEnumerable<Encounter> Encounter_With_New_Deep_Tissue_Pressure_Injury_By_Skin_Exam_After_First_72_Hours_Compute(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Encounter_With_Age_18_And_Older(context);

        IEnumerable<Encounter> b_(Encounter InpatientHospitalization) {
            IEnumerable<object> d_ = this.Skin_Exams_With_Pressure_Injury(context);

            bool? e_(object SkinExam) {
                object i_ = context.Operators.LateBoundProperty<object>(SkinExam, "effective");
                object j_ = FHIRHelpers_4_4_000.Instance.ToValue(context, i_);
                CqlInterval<CqlDateTime> k_ = QICoreCommon_4_0_000.Instance.toInterval(context, j_);
                CqlDateTime l_ = context.Operators.Start(k_);
                CqlInterval<CqlDateTime> m_ = CQMCommon_4_1_000.Instance.hospitalizationWithObservation(context, InpatientHospitalization);
                CqlDateTime n_ = context.Operators.Start(m_);
                CqlQuantity o_ = context.Operators.Quantity(72m, "hours");
                CqlDateTime p_ = context.Operators.Add(n_, o_);
                CqlDateTime r_ = context.Operators.End(m_);
                CqlInterval<CqlDateTime> s_ = context.Operators.Interval(p_, r_, true, true);
                bool? t_ = context.Operators.In<CqlDateTime>(l_, s_, default);
                return t_;
            }

            IEnumerable<object> f_ = context.Operators.Where<object>(d_, e_);
            Encounter g_(object SkinExam) => InpatientHospitalization;
            IEnumerable<Encounter> h_ = context.Operators.Select<object, Encounter>(f_, g_);
            return h_;
        }

        IEnumerable<Encounter> c_ = context.Operators.SelectMany<Encounter, Encounter>(a_, b_);
        return c_;
    }


    [CqlExpressionDefinition("Encounter With New Deep Tissue Pressure Injury")]
    public IEnumerable<Encounter> Encounter_With_New_Deep_Tissue_Pressure_Injury(CqlContext context) =>
        ((ICqlContextInternals)context).GetOrCompute<IEnumerable<Encounter>>(
            _cacheIndex_Encounter_With_New_Deep_Tissue_Pressure_Injury,
            Encounter_With_New_Deep_Tissue_Pressure_Injury_Compute);

    private IEnumerable<Encounter> Encounter_With_New_Deep_Tissue_Pressure_Injury_Compute(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Encounter_With_New_Deep_Tissue_Pressure_Injury_Not_POA_By_Indicator(context);
        IEnumerable<Encounter> b_ = this.Encounter_With_New_Deep_Tissue_Pressure_Injury_By_Skin_Exam_After_First_72_Hours(context);
        IEnumerable<Encounter> c_ = context.Operators.Union<Encounter>(a_, b_);
        return c_;
    }


    [CqlExpressionDefinition("Encounter With New Stage 2, 3, 4 Or Unstageable Pressure Injury Not POA By Indicator")]
    public IEnumerable<Encounter> Encounter_With_New_Stage_2__3__4_Or_Unstageable_Pressure_Injury_Not_POA_By_Indicator(CqlContext context) =>
        ((ICqlContextInternals)context).GetOrCompute<IEnumerable<Encounter>>(
            _cacheIndex_Encounter_With_New_Stage_2__3__4_Or_Unstageable_Pressure_Injury_Not_POA_By_Indicator,
            Encounter_With_New_Stage_2__3__4_Or_Unstageable_Pressure_Injury_Not_POA_By_Indicator_Compute);

    private IEnumerable<Encounter> Encounter_With_New_Stage_2__3__4_Or_Unstageable_Pressure_Injury_Not_POA_By_Indicator_Compute(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Encounter_With_Age_18_And_Older(context);

        bool? b_(Encounter InpatientHospitalization) {
            CqlValueSet d_ = this.Pressure_Injury_Stage_2__3__4__or_Unstageable_Diagnoses(context);
            CqlValueSet e_ = this.Not_Present_On_Admission_or_Documentation_Insufficient_to_Determine(context);
            bool? f_ = CQMCommon_4_1_000.Instance.isDiagnosisPresentOnAdmission(context, InpatientHospitalization, d_, e_);
            return f_;
        }

        IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);
        return c_;
    }


    [CqlExpressionDefinition("Encounter With New Stage 2, 3, 4 Or Unstageable Pressure Injury By Skin Exam After First 24 Hours")]
    public IEnumerable<Encounter> Encounter_With_New_Stage_2__3__4_Or_Unstageable_Pressure_Injury_By_Skin_Exam_After_First_24_Hours(CqlContext context) =>
        ((ICqlContextInternals)context).GetOrCompute<IEnumerable<Encounter>>(
            _cacheIndex_Encounter_With_New_Stage_2__3__4_Or_Unstageable_Pressure_Injury_By_Skin_Exam_After_First_24_Hours,
            Encounter_With_New_Stage_2__3__4_Or_Unstageable_Pressure_Injury_By_Skin_Exam_After_First_24_Hours_Compute);

    private IEnumerable<Encounter> Encounter_With_New_Stage_2__3__4_Or_Unstageable_Pressure_Injury_By_Skin_Exam_After_First_24_Hours_Compute(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Encounter_With_Age_18_And_Older(context);

        IEnumerable<Encounter> b_(Encounter InpatientHospitalization) {
            IEnumerable<object> d_ = this.Skin_Exams_With_Pressure_Injury(context);

            bool? e_(object SkinExam) {
                object i_ = context.Operators.LateBoundProperty<object>(SkinExam, "effective");
                object j_ = FHIRHelpers_4_4_000.Instance.ToValue(context, i_);
                CqlInterval<CqlDateTime> k_ = QICoreCommon_4_0_000.Instance.toInterval(context, j_);
                CqlDateTime l_ = context.Operators.Start(k_);
                CqlInterval<CqlDateTime> m_ = CQMCommon_4_1_000.Instance.hospitalizationWithObservation(context, InpatientHospitalization);
                CqlDateTime n_ = context.Operators.Start(m_);
                CqlQuantity o_ = context.Operators.Quantity(24m, "hours");
                CqlDateTime p_ = context.Operators.Add(n_, o_);
                CqlDateTime r_ = context.Operators.End(m_);
                CqlInterval<CqlDateTime> s_ = context.Operators.Interval(p_, r_, true, true);
                bool? t_ = context.Operators.In<CqlDateTime>(l_, s_, default);
                return t_;
            }

            IEnumerable<object> f_ = context.Operators.Where<object>(d_, e_);
            Encounter g_(object SkinExam) => InpatientHospitalization;
            IEnumerable<Encounter> h_ = context.Operators.Select<object, Encounter>(f_, g_);
            return h_;
        }

        IEnumerable<Encounter> c_ = context.Operators.SelectMany<Encounter, Encounter>(a_, b_);
        return c_;
    }


    [CqlExpressionDefinition("Encounter With New Stage 2, 3, 4 Or Unstageable Pressure Injury")]
    public IEnumerable<Encounter> Encounter_With_New_Stage_2__3__4_Or_Unstageable_Pressure_Injury(CqlContext context) =>
        ((ICqlContextInternals)context).GetOrCompute<IEnumerable<Encounter>>(
            _cacheIndex_Encounter_With_New_Stage_2__3__4_Or_Unstageable_Pressure_Injury,
            Encounter_With_New_Stage_2__3__4_Or_Unstageable_Pressure_Injury_Compute);

    private IEnumerable<Encounter> Encounter_With_New_Stage_2__3__4_Or_Unstageable_Pressure_Injury_Compute(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Encounter_With_New_Stage_2__3__4_Or_Unstageable_Pressure_Injury_Not_POA_By_Indicator(context);
        IEnumerable<Encounter> b_ = this.Encounter_With_New_Stage_2__3__4_Or_Unstageable_Pressure_Injury_By_Skin_Exam_After_First_24_Hours(context);
        IEnumerable<Encounter> c_ = context.Operators.Union<Encounter>(a_, b_);
        return c_;
    }


    [CqlExpressionDefinition("Numerator")]
    public IEnumerable<Encounter> Numerator(CqlContext context) =>
        ((ICqlContextInternals)context).GetOrCompute<IEnumerable<Encounter>>(
            _cacheIndex_Numerator,
            Numerator_Compute);

    private IEnumerable<Encounter> Numerator_Compute(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Encounter_With_New_Deep_Tissue_Pressure_Injury(context);
        IEnumerable<Encounter> b_ = this.Encounter_With_New_Stage_2__3__4_Or_Unstageable_Pressure_Injury(context);
        IEnumerable<Encounter> c_ = context.Operators.Union<Encounter>(a_, b_);
        return c_;
    }


    #endregion Functions and Expressions

    #region Cache Index Fields (26)

    private int _cacheIndex_Measurement_Period = -1;
    private int _cacheIndex_Patient = -1;
    private int _cacheIndex_SDE_Ethnicity = -1;
    private int _cacheIndex_SDE_Payer = -1;
    private int _cacheIndex_SDE_Race = -1;
    private int _cacheIndex_SDE_Sex = -1;
    private int _cacheIndex_Encounter_With_Age_18_And_Older = -1;
    private int _cacheIndex_Initial_Population = -1;
    private int _cacheIndex_Denominator = -1;
    private int _cacheIndex_Encounter_With_Deep_Tissue_Pressure_Injury_POA_By_Indicator = -1;
    private int _cacheIndex_Clinical_Skin_Exams_With_Pressure_Injury = -1;
    private int _cacheIndex_Simple_Skin_Exams_With_Pressure_Injury = -1;
    private int _cacheIndex_Skin_Exams_With_Pressure_Injury = -1;
    private int _cacheIndex_Encounter_With_Deep_Tissue_Pressure_Injury_POA_By_Skin_Exam_Within_First_72_Hours = -1;
    private int _cacheIndex_Encounter_With_Deep_Tissue_Pressure_Injury_POA_By_Indicator_Or_Skin_Exam_Within_First_72_Hours = -1;
    private int _cacheIndex_Encounter_With_Stage_2__3__4__Or_Unstageable_Pressure_Injury_Present_On_Admission_By_POA_Indicator = -1;
    private int _cacheIndex_Encounter_With_Stage_2__3__4_Or_Unstageable_Pressure_Injury_POA_By_Skin_Exam_Within_24_Hours = -1;
    private int _cacheIndex_Encounter_With_Stage_2__3__4_Or_Unstageable_Pressure_Injury_POA = -1;
    private int _cacheIndex_Denominator_Exclusions = -1;
    private int _cacheIndex_Encounter_With_New_Deep_Tissue_Pressure_Injury_Not_POA_By_Indicator = -1;
    private int _cacheIndex_Encounter_With_New_Deep_Tissue_Pressure_Injury_By_Skin_Exam_After_First_72_Hours = -1;
    private int _cacheIndex_Encounter_With_New_Deep_Tissue_Pressure_Injury = -1;
    private int _cacheIndex_Encounter_With_New_Stage_2__3__4_Or_Unstageable_Pressure_Injury_Not_POA_By_Indicator = -1;
    private int _cacheIndex_Encounter_With_New_Stage_2__3__4_Or_Unstageable_Pressure_Injury_By_Skin_Exam_After_First_24_Hours = -1;
    private int _cacheIndex_Encounter_With_New_Stage_2__3__4_Or_Unstageable_Pressure_Injury = -1;
    private int _cacheIndex_Numerator = -1;

    #endregion Cache Index Fields

    #region ILibraryInternals Implementation

    bool ILibraryInternals.CacheIndicesInitialized { get; set; }

    int ILibraryInternals.InitializeCacheIndices(CacheIndexInitializer initializer)
    {
        // Skip if already processed
        if (!initializer.MarkAsProcessed(this))
            return 0;

        var count = 0;

        // Process dependencies first (depth-first traversal)
        if (Dependencies is { Length: > 0 })
        {
            foreach (var dependency in Dependencies)
            {
                if (dependency is ILibraryInternals internals)
                {
                    count += internals.InitializeCacheIndices(initializer);
                }
            }
        }

        // Initialize cache indices for this library
        if (_cacheIndex_Measurement_Period != -1)
            throw new InvalidOperationException($"Cache index field '_cacheIndex_Measurement_Period' in library '{{Name}}' version '{{Version}}' is already initialized to {{_cacheIndex_Measurement_Period}}. Cache indices can only be initialized once.");
        _cacheIndex_Measurement_Period = initializer.GetNextIndex();
        count++;

        if (_cacheIndex_Patient != -1)
            throw new InvalidOperationException($"Cache index field '_cacheIndex_Patient' in library '{{Name}}' version '{{Version}}' is already initialized to {{_cacheIndex_Patient}}. Cache indices can only be initialized once.");
        _cacheIndex_Patient = initializer.GetNextIndex();
        count++;

        if (_cacheIndex_SDE_Ethnicity != -1)
            throw new InvalidOperationException($"Cache index field '_cacheIndex_SDE_Ethnicity' in library '{{Name}}' version '{{Version}}' is already initialized to {{_cacheIndex_SDE_Ethnicity}}. Cache indices can only be initialized once.");
        _cacheIndex_SDE_Ethnicity = initializer.GetNextIndex();
        count++;

        if (_cacheIndex_SDE_Payer != -1)
            throw new InvalidOperationException($"Cache index field '_cacheIndex_SDE_Payer' in library '{{Name}}' version '{{Version}}' is already initialized to {{_cacheIndex_SDE_Payer}}. Cache indices can only be initialized once.");
        _cacheIndex_SDE_Payer = initializer.GetNextIndex();
        count++;

        if (_cacheIndex_SDE_Race != -1)
            throw new InvalidOperationException($"Cache index field '_cacheIndex_SDE_Race' in library '{{Name}}' version '{{Version}}' is already initialized to {{_cacheIndex_SDE_Race}}. Cache indices can only be initialized once.");
        _cacheIndex_SDE_Race = initializer.GetNextIndex();
        count++;

        if (_cacheIndex_SDE_Sex != -1)
            throw new InvalidOperationException($"Cache index field '_cacheIndex_SDE_Sex' in library '{{Name}}' version '{{Version}}' is already initialized to {{_cacheIndex_SDE_Sex}}. Cache indices can only be initialized once.");
        _cacheIndex_SDE_Sex = initializer.GetNextIndex();
        count++;

        if (_cacheIndex_Encounter_With_Age_18_And_Older != -1)
            throw new InvalidOperationException($"Cache index field '_cacheIndex_Encounter_With_Age_18_And_Older' in library '{{Name}}' version '{{Version}}' is already initialized to {{_cacheIndex_Encounter_With_Age_18_And_Older}}. Cache indices can only be initialized once.");
        _cacheIndex_Encounter_With_Age_18_And_Older = initializer.GetNextIndex();
        count++;

        if (_cacheIndex_Initial_Population != -1)
            throw new InvalidOperationException($"Cache index field '_cacheIndex_Initial_Population' in library '{{Name}}' version '{{Version}}' is already initialized to {{_cacheIndex_Initial_Population}}. Cache indices can only be initialized once.");
        _cacheIndex_Initial_Population = initializer.GetNextIndex();
        count++;

        if (_cacheIndex_Denominator != -1)
            throw new InvalidOperationException($"Cache index field '_cacheIndex_Denominator' in library '{{Name}}' version '{{Version}}' is already initialized to {{_cacheIndex_Denominator}}. Cache indices can only be initialized once.");
        _cacheIndex_Denominator = initializer.GetNextIndex();
        count++;

        if (_cacheIndex_Encounter_With_Deep_Tissue_Pressure_Injury_POA_By_Indicator != -1)
            throw new InvalidOperationException($"Cache index field '_cacheIndex_Encounter_With_Deep_Tissue_Pressure_Injury_POA_By_Indicator' in library '{{Name}}' version '{{Version}}' is already initialized to {{_cacheIndex_Encounter_With_Deep_Tissue_Pressure_Injury_POA_By_Indicator}}. Cache indices can only be initialized once.");
        _cacheIndex_Encounter_With_Deep_Tissue_Pressure_Injury_POA_By_Indicator = initializer.GetNextIndex();
        count++;

        if (_cacheIndex_Clinical_Skin_Exams_With_Pressure_Injury != -1)
            throw new InvalidOperationException($"Cache index field '_cacheIndex_Clinical_Skin_Exams_With_Pressure_Injury' in library '{{Name}}' version '{{Version}}' is already initialized to {{_cacheIndex_Clinical_Skin_Exams_With_Pressure_Injury}}. Cache indices can only be initialized once.");
        _cacheIndex_Clinical_Skin_Exams_With_Pressure_Injury = initializer.GetNextIndex();
        count++;

        if (_cacheIndex_Simple_Skin_Exams_With_Pressure_Injury != -1)
            throw new InvalidOperationException($"Cache index field '_cacheIndex_Simple_Skin_Exams_With_Pressure_Injury' in library '{{Name}}' version '{{Version}}' is already initialized to {{_cacheIndex_Simple_Skin_Exams_With_Pressure_Injury}}. Cache indices can only be initialized once.");
        _cacheIndex_Simple_Skin_Exams_With_Pressure_Injury = initializer.GetNextIndex();
        count++;

        if (_cacheIndex_Skin_Exams_With_Pressure_Injury != -1)
            throw new InvalidOperationException($"Cache index field '_cacheIndex_Skin_Exams_With_Pressure_Injury' in library '{{Name}}' version '{{Version}}' is already initialized to {{_cacheIndex_Skin_Exams_With_Pressure_Injury}}. Cache indices can only be initialized once.");
        _cacheIndex_Skin_Exams_With_Pressure_Injury = initializer.GetNextIndex();
        count++;

        if (_cacheIndex_Encounter_With_Deep_Tissue_Pressure_Injury_POA_By_Skin_Exam_Within_First_72_Hours != -1)
            throw new InvalidOperationException($"Cache index field '_cacheIndex_Encounter_With_Deep_Tissue_Pressure_Injury_POA_By_Skin_Exam_Within_First_72_Hours' in library '{{Name}}' version '{{Version}}' is already initialized to {{_cacheIndex_Encounter_With_Deep_Tissue_Pressure_Injury_POA_By_Skin_Exam_Within_First_72_Hours}}. Cache indices can only be initialized once.");
        _cacheIndex_Encounter_With_Deep_Tissue_Pressure_Injury_POA_By_Skin_Exam_Within_First_72_Hours = initializer.GetNextIndex();
        count++;

        if (_cacheIndex_Encounter_With_Deep_Tissue_Pressure_Injury_POA_By_Indicator_Or_Skin_Exam_Within_First_72_Hours != -1)
            throw new InvalidOperationException($"Cache index field '_cacheIndex_Encounter_With_Deep_Tissue_Pressure_Injury_POA_By_Indicator_Or_Skin_Exam_Within_First_72_Hours' in library '{{Name}}' version '{{Version}}' is already initialized to {{_cacheIndex_Encounter_With_Deep_Tissue_Pressure_Injury_POA_By_Indicator_Or_Skin_Exam_Within_First_72_Hours}}. Cache indices can only be initialized once.");
        _cacheIndex_Encounter_With_Deep_Tissue_Pressure_Injury_POA_By_Indicator_Or_Skin_Exam_Within_First_72_Hours = initializer.GetNextIndex();
        count++;

        if (_cacheIndex_Encounter_With_Stage_2__3__4__Or_Unstageable_Pressure_Injury_Present_On_Admission_By_POA_Indicator != -1)
            throw new InvalidOperationException($"Cache index field '_cacheIndex_Encounter_With_Stage_2__3__4__Or_Unstageable_Pressure_Injury_Present_On_Admission_By_POA_Indicator' in library '{{Name}}' version '{{Version}}' is already initialized to {{_cacheIndex_Encounter_With_Stage_2__3__4__Or_Unstageable_Pressure_Injury_Present_On_Admission_By_POA_Indicator}}. Cache indices can only be initialized once.");
        _cacheIndex_Encounter_With_Stage_2__3__4__Or_Unstageable_Pressure_Injury_Present_On_Admission_By_POA_Indicator = initializer.GetNextIndex();
        count++;

        if (_cacheIndex_Encounter_With_Stage_2__3__4_Or_Unstageable_Pressure_Injury_POA_By_Skin_Exam_Within_24_Hours != -1)
            throw new InvalidOperationException($"Cache index field '_cacheIndex_Encounter_With_Stage_2__3__4_Or_Unstageable_Pressure_Injury_POA_By_Skin_Exam_Within_24_Hours' in library '{{Name}}' version '{{Version}}' is already initialized to {{_cacheIndex_Encounter_With_Stage_2__3__4_Or_Unstageable_Pressure_Injury_POA_By_Skin_Exam_Within_24_Hours}}. Cache indices can only be initialized once.");
        _cacheIndex_Encounter_With_Stage_2__3__4_Or_Unstageable_Pressure_Injury_POA_By_Skin_Exam_Within_24_Hours = initializer.GetNextIndex();
        count++;

        if (_cacheIndex_Encounter_With_Stage_2__3__4_Or_Unstageable_Pressure_Injury_POA != -1)
            throw new InvalidOperationException($"Cache index field '_cacheIndex_Encounter_With_Stage_2__3__4_Or_Unstageable_Pressure_Injury_POA' in library '{{Name}}' version '{{Version}}' is already initialized to {{_cacheIndex_Encounter_With_Stage_2__3__4_Or_Unstageable_Pressure_Injury_POA}}. Cache indices can only be initialized once.");
        _cacheIndex_Encounter_With_Stage_2__3__4_Or_Unstageable_Pressure_Injury_POA = initializer.GetNextIndex();
        count++;

        if (_cacheIndex_Denominator_Exclusions != -1)
            throw new InvalidOperationException($"Cache index field '_cacheIndex_Denominator_Exclusions' in library '{{Name}}' version '{{Version}}' is already initialized to {{_cacheIndex_Denominator_Exclusions}}. Cache indices can only be initialized once.");
        _cacheIndex_Denominator_Exclusions = initializer.GetNextIndex();
        count++;

        if (_cacheIndex_Encounter_With_New_Deep_Tissue_Pressure_Injury_Not_POA_By_Indicator != -1)
            throw new InvalidOperationException($"Cache index field '_cacheIndex_Encounter_With_New_Deep_Tissue_Pressure_Injury_Not_POA_By_Indicator' in library '{{Name}}' version '{{Version}}' is already initialized to {{_cacheIndex_Encounter_With_New_Deep_Tissue_Pressure_Injury_Not_POA_By_Indicator}}. Cache indices can only be initialized once.");
        _cacheIndex_Encounter_With_New_Deep_Tissue_Pressure_Injury_Not_POA_By_Indicator = initializer.GetNextIndex();
        count++;

        if (_cacheIndex_Encounter_With_New_Deep_Tissue_Pressure_Injury_By_Skin_Exam_After_First_72_Hours != -1)
            throw new InvalidOperationException($"Cache index field '_cacheIndex_Encounter_With_New_Deep_Tissue_Pressure_Injury_By_Skin_Exam_After_First_72_Hours' in library '{{Name}}' version '{{Version}}' is already initialized to {{_cacheIndex_Encounter_With_New_Deep_Tissue_Pressure_Injury_By_Skin_Exam_After_First_72_Hours}}. Cache indices can only be initialized once.");
        _cacheIndex_Encounter_With_New_Deep_Tissue_Pressure_Injury_By_Skin_Exam_After_First_72_Hours = initializer.GetNextIndex();
        count++;

        if (_cacheIndex_Encounter_With_New_Deep_Tissue_Pressure_Injury != -1)
            throw new InvalidOperationException($"Cache index field '_cacheIndex_Encounter_With_New_Deep_Tissue_Pressure_Injury' in library '{{Name}}' version '{{Version}}' is already initialized to {{_cacheIndex_Encounter_With_New_Deep_Tissue_Pressure_Injury}}. Cache indices can only be initialized once.");
        _cacheIndex_Encounter_With_New_Deep_Tissue_Pressure_Injury = initializer.GetNextIndex();
        count++;

        if (_cacheIndex_Encounter_With_New_Stage_2__3__4_Or_Unstageable_Pressure_Injury_Not_POA_By_Indicator != -1)
            throw new InvalidOperationException($"Cache index field '_cacheIndex_Encounter_With_New_Stage_2__3__4_Or_Unstageable_Pressure_Injury_Not_POA_By_Indicator' in library '{{Name}}' version '{{Version}}' is already initialized to {{_cacheIndex_Encounter_With_New_Stage_2__3__4_Or_Unstageable_Pressure_Injury_Not_POA_By_Indicator}}. Cache indices can only be initialized once.");
        _cacheIndex_Encounter_With_New_Stage_2__3__4_Or_Unstageable_Pressure_Injury_Not_POA_By_Indicator = initializer.GetNextIndex();
        count++;

        if (_cacheIndex_Encounter_With_New_Stage_2__3__4_Or_Unstageable_Pressure_Injury_By_Skin_Exam_After_First_24_Hours != -1)
            throw new InvalidOperationException($"Cache index field '_cacheIndex_Encounter_With_New_Stage_2__3__4_Or_Unstageable_Pressure_Injury_By_Skin_Exam_After_First_24_Hours' in library '{{Name}}' version '{{Version}}' is already initialized to {{_cacheIndex_Encounter_With_New_Stage_2__3__4_Or_Unstageable_Pressure_Injury_By_Skin_Exam_After_First_24_Hours}}. Cache indices can only be initialized once.");
        _cacheIndex_Encounter_With_New_Stage_2__3__4_Or_Unstageable_Pressure_Injury_By_Skin_Exam_After_First_24_Hours = initializer.GetNextIndex();
        count++;

        if (_cacheIndex_Encounter_With_New_Stage_2__3__4_Or_Unstageable_Pressure_Injury != -1)
            throw new InvalidOperationException($"Cache index field '_cacheIndex_Encounter_With_New_Stage_2__3__4_Or_Unstageable_Pressure_Injury' in library '{{Name}}' version '{{Version}}' is already initialized to {{_cacheIndex_Encounter_With_New_Stage_2__3__4_Or_Unstageable_Pressure_Injury}}. Cache indices can only be initialized once.");
        _cacheIndex_Encounter_With_New_Stage_2__3__4_Or_Unstageable_Pressure_Injury = initializer.GetNextIndex();
        count++;

        if (_cacheIndex_Numerator != -1)
            throw new InvalidOperationException($"Cache index field '_cacheIndex_Numerator' in library '{{Name}}' version '{{Version}}' is already initialized to {{_cacheIndex_Numerator}}. Cache indices can only be initialized once.");
        _cacheIndex_Numerator = initializer.GetNextIndex();
        count++;

        return count;
    }

    #endregion ILibraryInternals Implementation

    #region Singleton Lifetime Members

    private CMS826FHIRHHPI_1_0_000() {}

    public static CMS826FHIRHHPI_1_0_000 Instance { get; } = new();

    #endregion

    #region ILibrary Implementation

    public string Name => "CMS826FHIRHHPI";
    public string Version => "1.0.000";
    public ILibrary[] Dependencies => [FHIRHelpers_4_4_000.Instance, SupplementalDataElements_5_1_000.Instance, CQMCommon_4_1_000.Instance, QICoreCommon_4_0_000.Instance];

    #endregion ILibrary Implementation

}

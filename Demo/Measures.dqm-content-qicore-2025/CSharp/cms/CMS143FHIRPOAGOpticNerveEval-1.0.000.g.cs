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

[System.CodeDom.Compiler.GeneratedCode(".NET Code Generation", "5.3.8.0")]
[CqlLibrary("CMS143FHIRPOAGOpticNerveEval", "1.0.000")]
public partial class CMS143FHIRPOAGOpticNerveEval_1_0_000 : ILibrary, ISingleton<CMS143FHIRPOAGOpticNerveEval_1_0_000>
{
    #region ValueSets (9)

    [CqlValueSetDefinition("Care Services in Long-Term Residential Facility", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1014", valueSetVersion: null)]
    public CqlValueSet Care_Services_in_Long_Term_Residential_Facility(CqlContext _) => _Care_Services_in_Long_Term_Residential_Facility;
    private static readonly CqlValueSet _Care_Services_in_Long_Term_Residential_Facility = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1014", null);

    [CqlValueSetDefinition("Cup to Disc Ratio", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1333", valueSetVersion: null)]
    public CqlValueSet Cup_to_Disc_Ratio(CqlContext _) => _Cup_to_Disc_Ratio;
    private static readonly CqlValueSet _Cup_to_Disc_Ratio = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1333", null);

    [CqlValueSetDefinition("Medical Reason", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1007", valueSetVersion: null)]
    public CqlValueSet Medical_Reason(CqlContext _) => _Medical_Reason;
    private static readonly CqlValueSet _Medical_Reason = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1007", null);

    [CqlValueSetDefinition("Nursing Facility Visit", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1012", valueSetVersion: null)]
    public CqlValueSet Nursing_Facility_Visit(CqlContext _) => _Nursing_Facility_Visit;
    private static readonly CqlValueSet _Nursing_Facility_Visit = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1012", null);

    [CqlValueSetDefinition("Office Visit", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1001", valueSetVersion: null)]
    public CqlValueSet Office_Visit(CqlContext _) => _Office_Visit;
    private static readonly CqlValueSet _Office_Visit = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1001", null);

    [CqlValueSetDefinition("Ophthalmological Services", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1285", valueSetVersion: null)]
    public CqlValueSet Ophthalmological_Services(CqlContext _) => _Ophthalmological_Services;
    private static readonly CqlValueSet _Ophthalmological_Services = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1285", null);

    [CqlValueSetDefinition("Optic Disc Exam for Structural Abnormalities", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1334", valueSetVersion: null)]
    public CqlValueSet Optic_Disc_Exam_for_Structural_Abnormalities(CqlContext _) => _Optic_Disc_Exam_for_Structural_Abnormalities;
    private static readonly CqlValueSet _Optic_Disc_Exam_for_Structural_Abnormalities = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1334", null);

    [CqlValueSetDefinition("Outpatient Consultation", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1008", valueSetVersion: null)]
    public CqlValueSet Outpatient_Consultation(CqlContext _) => _Outpatient_Consultation;
    private static readonly CqlValueSet _Outpatient_Consultation = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1008", null);

    [CqlValueSetDefinition("Primary Open-Angle Glaucoma", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.326", valueSetVersion: null)]
    public CqlValueSet Primary_Open_Angle_Glaucoma(CqlContext _) => _Primary_Open_Angle_Glaucoma;
    private static readonly CqlValueSet _Primary_Open_Angle_Glaucoma = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.326", null);

    #endregion ValueSets

    #region Codes (1)

    [CqlCodeDefinition("virtual", codeId: "VR", codeSystem: "http://terminology.hl7.org/CodeSystem/v3-ActCode")]
    public CqlCode @virtual(CqlContext _) => _virtual;
    private static readonly CqlCode _virtual = new CqlCode("VR", "http://terminology.hl7.org/CodeSystem/v3-ActCode");

    #endregion Codes

    #region CodeSystems (1)

    [CqlCodeSystemDefinition("ActCode", codeSystemId: "http://terminology.hl7.org/CodeSystem/v3-ActCode", codeSystemVersion: null)]
    public CqlCodeSystem ActCode(CqlContext _) => _ActCode;
    private static readonly CqlCodeSystem _ActCode =
      new CqlCodeSystem("http://terminology.hl7.org/CodeSystem/v3-ActCode", null, [
          _virtual]);

    #endregion CodeSystems

    #region Parameters (1)

    [CqlParameterDefinition("Measurement Period")]
    public CqlInterval<CqlDateTime> Measurement_Period(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Measurement_Period, Measurement_Period_Compute);

    private const long _cacheIndex_Measurement_Period = 3156078639663484527L;

    private CqlInterval<CqlDateTime> Measurement_Period_Compute(CqlContext context)
    {
        CqlDateTime a_ = context.Operators.DateTime(2026, 1, 1, 0, 0, 0, 0, 0.0m);
        CqlDateTime b_ = context.Operators.DateTime(2027, 1, 1, 0, 0, 0, 0, 0.0m);
        CqlInterval<CqlDateTime> c_ = context.Operators.Interval(a_, b_, true, false);
        object d_ = context.ResolveParameter("CMS143FHIRPOAGOpticNerveEval-1.0.000", "Measurement Period", c_);
        return (CqlInterval<CqlDateTime>)d_;
    }


    #endregion Parameters

    #region Functions and Expressions (16)

    [CqlExpressionDefinition("Patient")]
    public Patient Patient(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Patient, Patient_Compute);

    private const long _cacheIndex_Patient = -2745371545005072040L;

    private Patient Patient_Compute(CqlContext context)
    {
        IEnumerable<Patient> a_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-patient"));
        Patient b_ = context.Operators.SingletonFrom<Patient>(a_);
        return b_;
    }


    [CqlExpressionDefinition("SDE Ethnicity")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Ethnicity(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_SDE_Ethnicity, SDE_Ethnicity_Compute);

    private const long _cacheIndex_SDE_Ethnicity = -3609001054687520351L;

    private (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Ethnicity_Compute(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? a_ = SupplementalDataElements_5_1_000.Instance.SDE_Ethnicity(context);
        return a_;
    }


    [CqlExpressionDefinition("SDE Payer")]
    public IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> SDE_Payer(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_SDE_Payer, SDE_Payer_Compute);

    private const long _cacheIndex_SDE_Payer = -5396362845870841428L;

    private IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> SDE_Payer_Compute(CqlContext context)
    {
        IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> a_ = SupplementalDataElements_5_1_000.Instance.SDE_Payer(context);
        return a_;
    }


    [CqlExpressionDefinition("SDE Race")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Race(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_SDE_Race, SDE_Race_Compute);

    private const long _cacheIndex_SDE_Race = 3352052490417106842L;

    private (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Race_Compute(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? a_ = SupplementalDataElements_5_1_000.Instance.SDE_Race(context);
        return a_;
    }


    [CqlExpressionDefinition("SDE Sex")]
    public CqlCode SDE_Sex(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_SDE_Sex, SDE_Sex_Compute);

    private const long _cacheIndex_SDE_Sex = -1648616902433127686L;

    private CqlCode SDE_Sex_Compute(CqlContext context)
    {
        CqlCode a_ = SupplementalDataElements_5_1_000.Instance.SDE_Sex(context);
        return a_;
    }


    [CqlExpressionDefinition("Qualifying Encounter During Measurement Period")]
    public IEnumerable<Encounter> Qualifying_Encounter_During_Measurement_Period(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Qualifying_Encounter_During_Measurement_Period, Qualifying_Encounter_During_Measurement_Period_Compute);

    private const long _cacheIndex_Qualifying_Encounter_During_Measurement_Period = -6830064780870226235L;

    private IEnumerable<Encounter> Qualifying_Encounter_During_Measurement_Period_Compute(CqlContext context)
    {
        CqlValueSet a_ = this.Office_Visit(context);
        IEnumerable<Encounter> b_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        CqlValueSet c_ = this.Ophthalmological_Services(context);
        IEnumerable<Encounter> d_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, c_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> e_ = context.Operators.Union<Encounter>(b_, d_);
        CqlValueSet f_ = this.Outpatient_Consultation(context);
        IEnumerable<Encounter> g_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, f_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        CqlValueSet h_ = this.Nursing_Facility_Visit(context);
        IEnumerable<Encounter> i_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, h_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> j_ = context.Operators.Union<Encounter>(g_, i_);
        IEnumerable<Encounter> k_ = context.Operators.Union<Encounter>(e_, j_);
        CqlValueSet l_ = this.Care_Services_in_Long_Term_Residential_Facility(context);
        IEnumerable<Encounter> m_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, l_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> n_ = context.Operators.Union<Encounter>(k_, m_);

        bool? o_(Encounter QualifyingEncounter) {
            CqlInterval<CqlDateTime> q_ = this.Measurement_Period(context);
            Period r_ = QualifyingEncounter?.Period;
            CqlInterval<CqlDateTime> s_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, r_);
            CqlBoolean t_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(q_, s_, "day");
            Code<Encounter.EncounterStatus> u_ = QualifyingEncounter?.StatusElement;
            Encounter.EncounterStatus? v_ = u_?.Value;
            Code<Encounter.EncounterStatus> w_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(v_);
            CqlBoolean x_ = context.Operators.Equal(w_, "finished");
            CqlBoolean y_ = x_;
            Coding z_ = QualifyingEncounter?.Class;
            CqlCode aa_ = FHIRHelpers_4_4_000.Instance.ToCode(context, z_);
            CqlCode ab_ = this.@virtual(context);
            CqlBoolean ac_ = context.Operators.Equivalent(aa_, ab_);
            CqlBoolean ad_ = (CqlBoolean)!ac_;
            return t_
                /* CQL 'and' (53:11-54:49) */ && y_
                /* CQL 'and' (53:5-55:48) */ && ad_;
        }

        IEnumerable<Encounter> p_ = context.Operators.Where<Encounter>(n_, o_);
        return p_;
    }


    [CqlFunctionDefinition("isVerified")]
    public bool? isVerified(CqlContext context, Condition condition)
    {
        CodeableConcept a_ = condition?.VerificationStatus;
        CqlConcept b_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, a_);
        CqlCode c_ = QICoreCommon_4_0_000.Instance.confirmed(context);
        CqlConcept d_ = context.Operators.ConvertCodeToConcept(c_);
        CqlBoolean e_ = context.Operators.Equivalent(b_, d_);
        CqlCode f_ = QICoreCommon_4_0_000.Instance.unconfirmed(context);
        CqlConcept g_ = context.Operators.ConvertCodeToConcept(f_);
        CqlBoolean h_ = context.Operators.Equivalent(b_, g_);
        CqlBoolean i_ = h_;
        CqlCode j_ = QICoreCommon_4_0_000.Instance.provisional(context);
        CqlConcept k_ = context.Operators.ConvertCodeToConcept(j_);
        CqlBoolean l_ = context.Operators.Equivalent(b_, k_);
        CqlBoolean m_ = l_;
        CqlCode n_ = QICoreCommon_4_0_000.Instance.differential(context);
        CqlConcept o_ = context.Operators.ConvertCodeToConcept(n_);
        CqlBoolean p_ = context.Operators.Equivalent(b_, o_);
        CqlBoolean q_ = p_;
        CqlBoolean r_ = e_
            /* CQL 'or' (99:54-100:66) */ || i_
            /* CQL 'or' (99:54-101:66) */ || m_
            /* CQL 'or' (99:52-103:3) */ || q_;
        return (CqlBoolean)(b_ is null)
            /* CQL 'implies' (99:3-103:3) */ || r_;
    }


    [CqlExpressionDefinition("Primary Open Angle Glaucoma Encounter")]
    public IEnumerable<Encounter> Primary_Open_Angle_Glaucoma_Encounter(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Primary_Open_Angle_Glaucoma_Encounter, Primary_Open_Angle_Glaucoma_Encounter_Compute);

    private const long _cacheIndex_Primary_Open_Angle_Glaucoma_Encounter = 6161833203670885452L;

    private IEnumerable<Encounter> Primary_Open_Angle_Glaucoma_Encounter_Compute(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Qualifying_Encounter_During_Measurement_Period(context);

        bool? b_(Encounter ValidQualifyingEncounter) {
            CqlValueSet d_ = this.Primary_Open_Angle_Glaucoma(context);
            IEnumerable<Condition> e_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, d_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-problems-health-concerns"));
            IEnumerable<Condition> f_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, d_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-encounter-diagnosis"));
            IEnumerable<Condition> g_ = context.Operators.Union<Condition>(e_ as IEnumerable<Condition>, f_ as IEnumerable<Condition>);

            bool? h_(Condition PrimaryOpenAngleGlaucoma) {
                CqlInterval<CqlDateTime> j_ = QICoreCommon_4_0_000.Instance.prevalenceInterval(context, PrimaryOpenAngleGlaucoma);
                Period k_ = ValidQualifyingEncounter?.Period;
                CqlInterval<CqlDateTime> l_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, k_);
                CqlBoolean m_ = context.Operators.Overlaps(j_, l_, "day");
                return m_
                    /* CQL 'and' (65:17-66:51) */ && this.isVerified(context, PrimaryOpenAngleGlaucoma);
            }

            CqlBoolean i_ = context.Operators.WhereAny<Condition>(g_, h_);
            return i_;
        }

        IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);
        return c_;
    }


    [CqlExpressionDefinition("Initial Population")]
    public bool? Initial_Population(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Initial_Population, Initial_Population_Compute);

    private const long _cacheIndex_Initial_Population = -2588812695149039481L;

    private bool? Initial_Population_Compute(CqlContext context)
    {
        Patient a_ = this.Patient(context);
        Date b_ = a_?.BirthDateElement;
        string c_ = b_?.Value;
        CqlDate d_ = context.Operators.ConvertStringToDate(c_);
        CqlInterval<CqlDateTime> e_ = this.Measurement_Period(context);
        CqlDateTime f_ = context.Operators.Start(e_);
        CqlDate g_ = context.Operators.DateFrom(f_);
        int? h_ = context.Operators.CalculateAgeAt(d_, g_, "year");
        CqlBoolean i_ = context.Operators.GreaterOrEqual(h_, 18);
        IEnumerable<Encounter> j_ = this.Primary_Open_Angle_Glaucoma_Encounter(context);
        CqlBoolean k_ = context.Operators.Exists<Encounter>(j_);
        CqlBoolean l_ = k_;
        return i_
            /* CQL 'and' (58:3-59:54) */ && l_;
    }


    [CqlExpressionDefinition("Denominator")]
    public bool? Denominator(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Denominator, Denominator_Compute);

    private const long _cacheIndex_Denominator = -3030596775686952599L;

    private bool? Denominator_Compute(CqlContext context)
    {
        CqlBoolean a_ = this.Initial_Population(context);
        return a_;
    }


    [CqlExpressionDefinition("Medical Reason for Not Performing Cup to Disc Ratio")]
    public IEnumerable<Observation> Medical_Reason_for_Not_Performing_Cup_to_Disc_Ratio(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Medical_Reason_for_Not_Performing_Cup_to_Disc_Ratio, Medical_Reason_for_Not_Performing_Cup_to_Disc_Ratio_Compute);

    private const long _cacheIndex_Medical_Reason_for_Not_Performing_Cup_to_Disc_Ratio = -6092949193270100781L;

    private IEnumerable<Observation> Medical_Reason_for_Not_Performing_Cup_to_Disc_Ratio_Compute(CqlContext context)
    {
        CqlValueSet a_ = this.Cup_to_Disc_Ratio(context);
        IEnumerable<Observation> b_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observationcancelled"));
        IEnumerable<Observation> c_ = context.Operators.Union<Observation>(b_, b_);

        bool? d_(Observation CupToDiscExamNotPerformed) {
            IEnumerable<Encounter> h_ = this.Primary_Open_Angle_Glaucoma_Encounter(context);

            bool? i_(Encounter EncounterWithPOAG) {
                Instant k_ = CupToDiscExamNotPerformed?.IssuedElement;
                DateTimeOffset? l_ = k_?.Value;
                CqlDateTime m_ = context.Operators.Convert<CqlDateTime>(l_);
                Period n_ = EncounterWithPOAG?.Period;
                CqlInterval<CqlDateTime> o_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, n_);
                CqlBoolean p_ = context.Operators.In<CqlDateTime>(m_, o_, "day");
                return p_;
            }

            CqlBoolean j_ = context.Operators.WhereAny<Encounter>(h_, i_);
            return j_;
        }

        IEnumerable<Observation> e_ = context.Operators.Where<Observation>(c_, d_);

        bool? f_(Observation CupToDiscExamNotPerformed) {

            bool? q_(Extension @this) {
                FhirUri x_ = @this?.UrlElement;
                string y_ = FHIRHelpers_4_4_000.Instance.ToString(context, x_);
                CqlBoolean z_ = context.Operators.Equal(y_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-notDoneReason");
                return z_;
            }


            object r_(Extension @this) {
                DataType aa_ = @this?.Value;
                return aa_;
            }

            IEnumerable<object> s_ = context.Operators.WhereSelect<Extension, object>((IEnumerable<Extension>)(CupToDiscExamNotPerformed is DomainResource
                ? (CupToDiscExamNotPerformed as DomainResource).Extension
                : default), q_, r_);
            object t_ = context.Operators.SingletonFrom<object>(s_);
            CqlConcept u_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, t_ as CodeableConcept);
            CqlValueSet v_ = this.Medical_Reason(context);
            CqlBoolean w_ = context.Operators.ConceptInValueSet(u_, v_);
            return w_;
        }

        IEnumerable<Observation> g_ = context.Operators.Where<Observation>(e_, f_);
        return g_;
    }


    [CqlExpressionDefinition("Medical Reason for Not Performing Optic Disc Exam")]
    public IEnumerable<Observation> Medical_Reason_for_Not_Performing_Optic_Disc_Exam(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Medical_Reason_for_Not_Performing_Optic_Disc_Exam, Medical_Reason_for_Not_Performing_Optic_Disc_Exam_Compute);

    private const long _cacheIndex_Medical_Reason_for_Not_Performing_Optic_Disc_Exam = 1941253965723847273L;

    private IEnumerable<Observation> Medical_Reason_for_Not_Performing_Optic_Disc_Exam_Compute(CqlContext context)
    {
        CqlValueSet a_ = this.Optic_Disc_Exam_for_Structural_Abnormalities(context);
        IEnumerable<Observation> b_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observationcancelled"));
        IEnumerable<Observation> c_ = context.Operators.Union<Observation>(b_, b_);

        bool? d_(Observation OpticDiscExamNotPerformed) {
            IEnumerable<Encounter> h_ = this.Primary_Open_Angle_Glaucoma_Encounter(context);

            bool? i_(Encounter EncounterWithPOAG) {
                Instant k_ = OpticDiscExamNotPerformed?.IssuedElement;
                DateTimeOffset? l_ = k_?.Value;
                CqlDateTime m_ = context.Operators.Convert<CqlDateTime>(l_);
                Period n_ = EncounterWithPOAG?.Period;
                CqlInterval<CqlDateTime> o_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, n_);
                CqlBoolean p_ = context.Operators.In<CqlDateTime>(m_, o_, "day");
                return p_;
            }

            CqlBoolean j_ = context.Operators.WhereAny<Encounter>(h_, i_);
            return j_;
        }

        IEnumerable<Observation> e_ = context.Operators.Where<Observation>(c_, d_);

        bool? f_(Observation OpticDiscExamNotPerformed) {

            bool? q_(Extension @this) {
                FhirUri x_ = @this?.UrlElement;
                string y_ = FHIRHelpers_4_4_000.Instance.ToString(context, x_);
                CqlBoolean z_ = context.Operators.Equal(y_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-notDoneReason");
                return z_;
            }


            object r_(Extension @this) {
                DataType aa_ = @this?.Value;
                return aa_;
            }

            IEnumerable<object> s_ = context.Operators.WhereSelect<Extension, object>((IEnumerable<Extension>)(OpticDiscExamNotPerformed is DomainResource
                ? (OpticDiscExamNotPerformed as DomainResource).Extension
                : default), q_, r_);
            object t_ = context.Operators.SingletonFrom<object>(s_);
            CqlConcept u_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, t_ as CodeableConcept);
            CqlValueSet v_ = this.Medical_Reason(context);
            CqlBoolean w_ = context.Operators.ConceptInValueSet(u_, v_);
            return w_;
        }

        IEnumerable<Observation> g_ = context.Operators.Where<Observation>(e_, f_);
        return g_;
    }


    [CqlExpressionDefinition("Denominator Exceptions")]
    public bool? Denominator_Exceptions(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Denominator_Exceptions, Denominator_Exceptions_Compute);

    private const long _cacheIndex_Denominator_Exceptions = -8432168175917161390L;

    private bool? Denominator_Exceptions_Compute(CqlContext context)
    {
        IEnumerable<Observation> a_ = this.Medical_Reason_for_Not_Performing_Cup_to_Disc_Ratio(context);
        CqlBoolean b_ = context.Operators.Exists<Observation>(a_);
        IEnumerable<Observation> c_ = this.Medical_Reason_for_Not_Performing_Optic_Disc_Exam(context);
        CqlBoolean d_ = context.Operators.Exists<Observation>(c_);
        CqlBoolean e_ = d_;
        return b_
            /* CQL 'or' (44:3-45:65) */ || e_;
    }


    [CqlExpressionDefinition("Cup to Disc Ratio Performed with Result")]
    public IEnumerable<Observation> Cup_to_Disc_Ratio_Performed_with_Result(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Cup_to_Disc_Ratio_Performed_with_Result, Cup_to_Disc_Ratio_Performed_with_Result_Compute);

    private const long _cacheIndex_Cup_to_Disc_Ratio_Performed_with_Result = -1717978684055323427L;

    private IEnumerable<Observation> Cup_to_Disc_Ratio_Performed_with_Result_Compute(CqlContext context)
    {
        CqlValueSet a_ = this.Cup_to_Disc_Ratio(context);
        IEnumerable<Observation> b_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation-clinical-result"));

        bool? c_(Observation CupToDiscExamPerformed) {
            IEnumerable<Encounter> g_ = this.Primary_Open_Angle_Glaucoma_Encounter(context);

            bool? h_(Encounter EncounterWithPOAG) {
                Period j_ = EncounterWithPOAG?.Period;
                CqlInterval<CqlDateTime> k_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, j_);
                DataType l_ = CupToDiscExamPerformed?.Effective;
                object m_ = FHIRHelpers_4_4_000.Instance.ToValue(context, l_);
                CqlInterval<CqlDateTime> n_ = QICoreCommon_4_0_000.Instance.toInterval(context, m_);
                CqlBoolean o_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(k_, n_, "day");
                return o_;
            }

            CqlBoolean i_ = context.Operators.WhereAny<Encounter>(g_, h_);
            return i_;
        }

        IEnumerable<Observation> d_ = context.Operators.Where<Observation>(b_, c_);

        bool? e_(Observation CupToDiscExamPerformed) {
            DataType p_ = CupToDiscExamPerformed?.Value;
            object q_ = FHIRHelpers_4_4_000.Instance.ToValue(context, p_);
            Code<ObservationStatus> r_ = CupToDiscExamPerformed?.StatusElement;
            ObservationStatus? s_ = r_?.Value;
            string t_ = context.Operators.Convert<string>(s_);
            string[] u_ = [
                "final",
                "amended",
                "corrected",
            ];
            CqlBoolean v_ = context.Operators.In<string>(t_, (IEnumerable<string>)u_);
            CqlBoolean w_ = v_;
            return (CqlBoolean)(q_ is not null)
                /* CQL 'and' (72:5-73:78) */ && w_;
        }

        IEnumerable<Observation> f_ = context.Operators.Where<Observation>(d_, e_);
        return f_;
    }


    [CqlExpressionDefinition("Optic Disc Exam Performed with Result")]
    public IEnumerable<Observation> Optic_Disc_Exam_Performed_with_Result(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Optic_Disc_Exam_Performed_with_Result, Optic_Disc_Exam_Performed_with_Result_Compute);

    private const long _cacheIndex_Optic_Disc_Exam_Performed_with_Result = 4437523420981119735L;

    private IEnumerable<Observation> Optic_Disc_Exam_Performed_with_Result_Compute(CqlContext context)
    {
        CqlValueSet a_ = this.Optic_Disc_Exam_for_Structural_Abnormalities(context);
        IEnumerable<Observation> b_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation-clinical-result"));

        bool? c_(Observation OpticDiscExamPerformed) {
            IEnumerable<Encounter> g_ = this.Primary_Open_Angle_Glaucoma_Encounter(context);

            bool? h_(Encounter EncounterWithPOAG) {
                Period j_ = EncounterWithPOAG?.Period;
                CqlInterval<CqlDateTime> k_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, j_);
                DataType l_ = OpticDiscExamPerformed?.Effective;
                object m_ = FHIRHelpers_4_4_000.Instance.ToValue(context, l_);
                CqlInterval<CqlDateTime> n_ = QICoreCommon_4_0_000.Instance.toInterval(context, m_);
                CqlBoolean o_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(k_, n_, "day");
                return o_;
            }

            CqlBoolean i_ = context.Operators.WhereAny<Encounter>(g_, h_);
            return i_;
        }

        IEnumerable<Observation> d_ = context.Operators.Where<Observation>(b_, c_);

        bool? e_(Observation OpticDiscExamPerformed) {
            DataType p_ = OpticDiscExamPerformed?.Value;
            object q_ = FHIRHelpers_4_4_000.Instance.ToValue(context, p_);
            Code<ObservationStatus> r_ = OpticDiscExamPerformed?.StatusElement;
            ObservationStatus? s_ = r_?.Value;
            string t_ = context.Operators.Convert<string>(s_);
            string[] u_ = [
                "final",
                "amended",
                "corrected",
            ];
            CqlBoolean v_ = context.Operators.In<string>(t_, (IEnumerable<string>)u_);
            CqlBoolean w_ = v_;
            return (CqlBoolean)(q_ is not null)
                /* CQL 'and' (79:5-80:78) */ && w_;
        }

        IEnumerable<Observation> f_ = context.Operators.Where<Observation>(d_, e_);
        return f_;
    }


    [CqlExpressionDefinition("Numerator")]
    public bool? Numerator(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Numerator, Numerator_Compute);

    private const long _cacheIndex_Numerator = -2441993537604612007L;

    private bool? Numerator_Compute(CqlContext context)
    {
        IEnumerable<Observation> a_ = this.Cup_to_Disc_Ratio_Performed_with_Result(context);
        CqlBoolean b_ = context.Operators.Exists<Observation>(a_);
        IEnumerable<Observation> c_ = this.Optic_Disc_Exam_Performed_with_Result(context);
        CqlBoolean d_ = context.Operators.Exists<Observation>(c_);
        CqlBoolean e_ = d_;
        return b_
            /* CQL 'and' (83:3-84:54) */ && e_;
    }


    #endregion Functions and Expressions

    #region Singleton Lifetime Members

    private CMS143FHIRPOAGOpticNerveEval_1_0_000() {}

    public static CMS143FHIRPOAGOpticNerveEval_1_0_000 Instance { get; } = new();

    #endregion

    #region ILibrary Implementation

    public string Name => "CMS143FHIRPOAGOpticNerveEval";
    public string Version => "1.0.000";
    public ILibrary[] Dependencies => [FHIRHelpers_4_4_000.Instance, SupplementalDataElements_5_1_000.Instance, QICoreCommon_4_0_000.Instance];

    #endregion ILibrary Implementation

}

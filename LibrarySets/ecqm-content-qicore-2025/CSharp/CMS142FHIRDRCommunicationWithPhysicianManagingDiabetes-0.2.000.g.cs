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
[CqlLibrary("CMS142FHIRDRCommunicationWithPhysicianManagingDiabetes", "0.2.000")]
public partial class CMS142FHIRDRCommunicationWithPhysicianManagingDiabetes_0_2_000 : ILibrary, ISingleton<CMS142FHIRDRCommunicationWithPhysicianManagingDiabetes_0_2_000>
{
    private CMS142FHIRDRCommunicationWithPhysicianManagingDiabetes_0_2_000() {}

    public static CMS142FHIRDRCommunicationWithPhysicianManagingDiabetes_0_2_000 Instance { get; } = new();

    #region ILibrary Implementation

    public string Name => "CMS142FHIRDRCommunicationWithPhysicianManagingDiabetes";
    public string Version => "0.2.000";
    public ILibrary[] Dependencies => [FHIRHelpers_4_4_000.Instance, SupplementalDataElements_5_1_000.Instance, QICoreCommon_4_0_000.Instance];

    #endregion ILibrary Implementation

    #region ValueSets

    [CqlValueSetDefinition("Care Services in Long-Term Residential Facility", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1014", valueSetVersion: null)]
    public CqlValueSet Care_Services_in_Long_Term_Residential_Facility(CqlContext _) => _Care_Services_in_Long_Term_Residential_Facility;
    private static readonly CqlValueSet _Care_Services_in_Long_Term_Residential_Facility = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1014", null);

    [CqlValueSetDefinition("Diabetic Retinopathy", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.327", valueSetVersion: null)]
    public CqlValueSet Diabetic_Retinopathy(CqlContext _) => _Diabetic_Retinopathy;
    private static readonly CqlValueSet _Diabetic_Retinopathy = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.327", null);

    [CqlValueSetDefinition("Level of Severity of Retinopathy Findings", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1283", valueSetVersion: null)]
    public CqlValueSet Level_of_Severity_of_Retinopathy_Findings(CqlContext _) => _Level_of_Severity_of_Retinopathy_Findings;
    private static readonly CqlValueSet _Level_of_Severity_of_Retinopathy_Findings = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1283", null);

    [CqlValueSetDefinition("Macular Edema Findings Present", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1320", valueSetVersion: null)]
    public CqlValueSet Macular_Edema_Findings_Present(CqlContext _) => _Macular_Edema_Findings_Present;
    private static readonly CqlValueSet _Macular_Edema_Findings_Present = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1320", null);

    [CqlValueSetDefinition("Macular Exam", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1251", valueSetVersion: null)]
    public CqlValueSet Macular_Exam(CqlContext _) => _Macular_Exam;
    private static readonly CqlValueSet _Macular_Exam = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1251", null);

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

    [CqlValueSetDefinition("Outpatient Consultation", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1008", valueSetVersion: null)]
    public CqlValueSet Outpatient_Consultation(CqlContext _) => _Outpatient_Consultation;
    private static readonly CqlValueSet _Outpatient_Consultation = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1008", null);

    [CqlValueSetDefinition("Patient Reason", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1008", valueSetVersion: null)]
    public CqlValueSet Patient_Reason(CqlContext _) => _Patient_Reason;
    private static readonly CqlValueSet _Patient_Reason = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1008", null);

    [CqlValueSetDefinition("Macular edema absent (situation)", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.2.1391", valueSetVersion: null)]
    public CqlValueSet Macular_edema_absent__situation_(CqlContext _) => _Macular_edema_absent__situation_;
    private static readonly CqlValueSet _Macular_edema_absent__situation_ = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.2.1391", null);

    #endregion ValueSets

    #region Codes

    [CqlCodeDefinition("Healthcare professional (occupation)", codeId: "223366009", codeSystem: "http://snomed.info/sct")]
    public CqlCode Healthcare_professional__occupation_(CqlContext _) => _Healthcare_professional__occupation_;
    private static readonly CqlCode _Healthcare_professional__occupation_ = new CqlCode("223366009", "http://snomed.info/sct");

    [CqlCodeDefinition("Medical practitioner (occupation)", codeId: "158965000", codeSystem: "http://snomed.info/sct")]
    public CqlCode Medical_practitioner__occupation_(CqlContext _) => _Medical_practitioner__occupation_;
    private static readonly CqlCode _Medical_practitioner__occupation_ = new CqlCode("158965000", "http://snomed.info/sct");

    [CqlCodeDefinition("Ophthalmologist (occupation)", codeId: "422234006", codeSystem: "http://snomed.info/sct")]
    public CqlCode Ophthalmologist__occupation_(CqlContext _) => _Ophthalmologist__occupation_;
    private static readonly CqlCode _Ophthalmologist__occupation_ = new CqlCode("422234006", "http://snomed.info/sct");

    [CqlCodeDefinition("Optometrist (occupation)", codeId: "28229004", codeSystem: "http://snomed.info/sct")]
    public CqlCode Optometrist__occupation_(CqlContext _) => _Optometrist__occupation_;
    private static readonly CqlCode _Optometrist__occupation_ = new CqlCode("28229004", "http://snomed.info/sct");

    [CqlCodeDefinition("Physician (occupation)", codeId: "309343006", codeSystem: "http://snomed.info/sct")]
    public CqlCode Physician__occupation_(CqlContext _) => _Physician__occupation_;
    private static readonly CqlCode _Physician__occupation_ = new CqlCode("309343006", "http://snomed.info/sct");

    [CqlCodeDefinition("virtual", codeId: "VR", codeSystem: "http://terminology.hl7.org/CodeSystem/v3-ActCode")]
    public CqlCode @virtual(CqlContext _) => _virtual;
    private static readonly CqlCode _virtual = new CqlCode("VR", "http://terminology.hl7.org/CodeSystem/v3-ActCode");

    [CqlCodeDefinition("AMB", codeId: "AMB", codeSystem: "http://terminology.hl7.org/CodeSystem/v3-ActCode")]
    public CqlCode AMB(CqlContext _) => _AMB;
    private static readonly CqlCode _AMB = new CqlCode("AMB", "http://terminology.hl7.org/CodeSystem/v3-ActCode");

    #endregion Codes

    #region CodeSystems

    [CqlCodeSystemDefinition("SNOMEDCT", codeSystemId: "http://snomed.info/sct", codeSystemVersion: null)]
    public CqlCodeSystem SNOMEDCT(CqlContext _) => _SNOMEDCT;
    private static readonly CqlCodeSystem _SNOMEDCT =
      new CqlCodeSystem("http://snomed.info/sct", null, [
          _Healthcare_professional__occupation_,
          _Medical_practitioner__occupation_,
          _Ophthalmologist__occupation_,
          _Optometrist__occupation_,
          _Physician__occupation_]);

    [CqlCodeSystemDefinition("ActCode", codeSystemId: "http://terminology.hl7.org/CodeSystem/v3-ActCode", codeSystemVersion: null)]
    public CqlCodeSystem ActCode(CqlContext _) => _ActCode;
    private static readonly CqlCodeSystem _ActCode =
      new CqlCodeSystem("http://terminology.hl7.org/CodeSystem/v3-ActCode", null, [
          _virtual,
          _AMB]);

    #endregion CodeSystems

    #region Parameters

    [CqlParameterDefinition("Measurement Period")]
    public CqlInterval<CqlDateTime> Measurement_Period(CqlContext context)
    {
        object a_ = context.ResolveParameter("CMS142FHIRDRCommunicationWithPhysicianManagingDiabetes-0.2.000", "Measurement Period", null);

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


    [CqlExpressionDefinition("Qualifying Encounter During Day of Measurement Period")]
    public IEnumerable<Encounter> Qualifying_Encounter_During_Day_of_Measurement_Period(CqlContext context)
    {
        CqlValueSet a_ = this.Office_Visit(context);
        IEnumerable<Encounter> b_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        CqlValueSet c_ = this.Ophthalmological_Services(context);
        IEnumerable<Encounter> d_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, c_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> e_ = context.Operators.Union<Encounter>(b_, d_);
        CqlValueSet f_ = this.Outpatient_Consultation(context);
        IEnumerable<Encounter> g_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, f_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        CqlValueSet h_ = this.Care_Services_in_Long_Term_Residential_Facility(context);
        IEnumerable<Encounter> i_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, h_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> j_ = context.Operators.Union<Encounter>(g_, i_);
        IEnumerable<Encounter> k_ = context.Operators.Union<Encounter>(e_, j_);
        CqlValueSet l_ = this.Nursing_Facility_Visit(context);
        IEnumerable<Encounter> m_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, l_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> n_ = context.Operators.Union<Encounter>(k_, m_);
        bool? o_(Encounter QualifyingEncounter)
        {
            CqlInterval<CqlDateTime> q_ = this.Measurement_Period(context);
            Period r_ = QualifyingEncounter?.Period;
            CqlInterval<CqlDateTime> s_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, r_);
            bool? t_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(q_, s_, "day");
            Code<Encounter.EncounterStatus> u_ = QualifyingEncounter?.StatusElement;
            Encounter.EncounterStatus? v_ = u_?.Value;
            Code<Encounter.EncounterStatus> w_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(v_);
            bool? x_ = context.Operators.Equal(w_, "finished");
            bool? y_ = context.Operators.And(t_, x_);
            Coding z_ = QualifyingEncounter?.Class;
            CqlCode aa_ = FHIRHelpers_4_4_000.Instance.ToCode(context, z_);
            CqlCode ab_ = this.@virtual(context);
            bool? ac_ = context.Operators.Equivalent(aa_, ab_);
            bool? ad_ = context.Operators.Not(ac_);
            bool? ae_ = context.Operators.And(y_, ad_);

            return ae_;
        };
        IEnumerable<Encounter> p_ = context.Operators.Where<Encounter>(n_, o_);

        return p_;
    }


    [CqlExpressionDefinition("Diabetic Retinopathy Encounter")]
    public IEnumerable<Encounter> Diabetic_Retinopathy_Encounter(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Qualifying_Encounter_During_Day_of_Measurement_Period(context);
        IEnumerable<Encounter> b_(Encounter ValidQualifyingEncounter)
        {
            CqlValueSet d_ = this.Diabetic_Retinopathy(context);
            IEnumerable<Condition> e_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, d_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-problems-health-concerns"));
            IEnumerable<Condition> g_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, d_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-encounter-diagnosis"));
            IEnumerable<object> h_ = context.Operators.Union<object>(e_ as IEnumerable<object>, g_ as IEnumerable<object>);
            bool? i_(object DiabeticRetinopathy)
            {
                CqlInterval<CqlDateTime> m_ = QICoreCommon_4_0_000.Instance.prevalenceInterval(context, DiabeticRetinopathy);
                Period n_ = ValidQualifyingEncounter?.Period;
                CqlInterval<CqlDateTime> o_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, n_);
                bool? p_ = context.Operators.Overlaps(m_, o_, "day");
                bool? q_ = QICoreCommon_4_0_000.Instance.isActive(context, DiabeticRetinopathy);
                bool? r_ = context.Operators.And(p_, q_);
                object s_ = context.Operators.LateBoundProperty<object>(DiabeticRetinopathy, "verificationStatus");
                CqlConcept t_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, s_ as CodeableConcept);
                CqlCode u_ = QICoreCommon_4_0_000.Instance.unconfirmed(context);
                CqlConcept v_ = context.Operators.ConvertCodeToConcept(u_);
                bool? w_ = context.Operators.Equivalent(t_, v_);
                CqlConcept y_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, s_ as CodeableConcept);
                CqlCode z_ = QICoreCommon_4_0_000.Instance.refuted(context);
                CqlConcept aa_ = context.Operators.ConvertCodeToConcept(z_);
                bool? ab_ = context.Operators.Equivalent(y_, aa_);
                bool? ac_ = context.Operators.Or(w_, ab_);
                CqlConcept ae_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, s_ as CodeableConcept);
                CqlCode af_ = QICoreCommon_4_0_000.Instance.entered_in_error(context);
                CqlConcept ag_ = context.Operators.ConvertCodeToConcept(af_);
                bool? ah_ = context.Operators.Equivalent(ae_, ag_);
                bool? ai_ = context.Operators.Or(ac_, ah_);
                bool? aj_ = context.Operators.Not(ai_);
                bool? ak_ = context.Operators.And(r_, aj_);

                return ak_;
            };
            IEnumerable<object> j_ = context.Operators.Where<object>(h_, i_);
            Encounter k_(object DiabeticRetinopathy) =>
                ValidQualifyingEncounter;
            IEnumerable<Encounter> l_ = context.Operators.Select<object, Encounter>(j_, k_);

            return l_;
        };
        IEnumerable<Encounter> c_ = context.Operators.SelectMany<Encounter, Encounter>(a_, b_);

        return c_;
    }


    [CqlExpressionDefinition("Initial Population")]
    public bool? Initial_Population(CqlContext context)
    {
        Patient a_ = this.Patient(context);
        Date b_ = a_?.BirthDateElement;
        string c_ = b_?.Value;
        CqlDate d_ = context.Operators.ConvertStringToDate(c_);
        CqlInterval<CqlDateTime> e_ = this.Measurement_Period(context);
        CqlDateTime f_ = context.Operators.Start(e_);
        CqlDate g_ = context.Operators.DateFrom(f_);
        int? h_ = context.Operators.CalculateAgeAt(d_, g_, "year");
        bool? i_ = context.Operators.GreaterOrEqual(h_, 18);
        IEnumerable<Encounter> j_ = this.Diabetic_Retinopathy_Encounter(context);
        bool? k_ = context.Operators.Exists<Encounter>(j_);
        bool? l_ = context.Operators.And(i_, k_);

        return l_;
    }


    [CqlExpressionDefinition("Macular Exam Performed")]
    public IEnumerable<Observation> Macular_Exam_Performed(CqlContext context)
    {
        CqlValueSet a_ = this.Macular_Exam(context);
        IEnumerable<Observation> b_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation-clinical-result"));
        IEnumerable<Observation> c_(Observation MacularExam)
        {
            IEnumerable<Encounter> g_ = this.Diabetic_Retinopathy_Encounter(context);
            bool? h_(Encounter EncounterDiabeticRetinopathy)
            {
                Period l_ = EncounterDiabeticRetinopathy?.Period;
                CqlInterval<CqlDateTime> m_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, l_);
                DataType n_ = MacularExam?.Effective;
                object o_ = FHIRHelpers_4_4_000.Instance.ToValue(context, n_);
                CqlInterval<CqlDateTime> p_ = QICoreCommon_4_0_000.Instance.toInterval(context, o_);
                bool? q_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(m_, p_, default);

                return q_;
            };
            IEnumerable<Encounter> i_ = context.Operators.Where<Encounter>(g_, h_);
            Observation j_(Encounter EncounterDiabeticRetinopathy) =>
                MacularExam;
            IEnumerable<Observation> k_ = context.Operators.Select<Encounter, Observation>(i_, j_);

            return k_;
        };
        IEnumerable<Observation> d_ = context.Operators.SelectMany<Observation, Observation>(b_, c_);
        bool? e_(Observation MacularExam)
        {
            DataType r_ = MacularExam?.Value;
            object s_ = FHIRHelpers_4_4_000.Instance.ToValue(context, r_);
            bool? t_ = context.Operators.Not((bool?)(s_ is null));
            Code<ObservationStatus> u_ = MacularExam?.StatusElement;
            ObservationStatus? v_ = u_?.Value;
            string w_ = context.Operators.Convert<string>(v_);
            string[] x_ = [
                "final",
                "amended",
                "corrected",
                "preliminary",
            ];
            bool? y_ = context.Operators.In<string>(w_, x_ as IEnumerable<string>);
            bool? z_ = context.Operators.And(t_, y_);

            return z_;
        };
        IEnumerable<Observation> f_ = context.Operators.Where<Observation>(d_, e_);

        return f_;
    }


    [CqlExpressionDefinition("Denominator")]
    public bool? Denominator(CqlContext context)
    {
        bool? a_ = this.Initial_Population(context);
        IEnumerable<Observation> b_ = this.Macular_Exam_Performed(context);
        bool? c_ = context.Operators.Exists<Observation>(b_);
        bool? d_ = context.Operators.And(a_, c_);

        return d_;
    }


    [CqlExpressionDefinition("Level of Severity of Retinopathy Findings Communicated")]
    public IEnumerable<Communication> Level_of_Severity_of_Retinopathy_Findings_Communicated(CqlContext context)
    {
        CqlValueSet a_ = this.Level_of_Severity_of_Retinopathy_Findings(context);
        IEnumerable<Communication> b_ = context.Operators.Retrieve<Communication>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-communication"));
        IEnumerable<Communication> c_(Communication LevelOfSeverityCommunicated)
        {
            IEnumerable<Encounter> g_ = this.Diabetic_Retinopathy_Encounter(context);
            bool? h_(Encounter EncounterDiabeticRetinopathy)
            {
                FhirDateTime l_ = LevelOfSeverityCommunicated?.SentElement;
                CqlDateTime m_ = context.Operators.Convert<CqlDateTime>(l_);
                Period n_ = EncounterDiabeticRetinopathy?.Period;
                CqlInterval<CqlDateTime> o_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, n_);
                CqlDateTime p_ = context.Operators.Start(o_);
                bool? q_ = context.Operators.After(m_, p_, default);
                CqlDateTime s_ = context.Operators.Convert<CqlDateTime>(l_);
                CqlInterval<CqlDateTime> t_ = this.Measurement_Period(context);
                bool? u_ = context.Operators.In<CqlDateTime>(s_, t_, "day");
                bool? v_ = context.Operators.And(q_, u_);

                return v_;
            };
            IEnumerable<Encounter> i_ = context.Operators.Where<Encounter>(g_, h_);
            Communication j_(Encounter EncounterDiabeticRetinopathy) =>
                LevelOfSeverityCommunicated;
            IEnumerable<Communication> k_ = context.Operators.Select<Encounter, Communication>(i_, j_);

            return k_;
        };
        IEnumerable<Communication> d_ = context.Operators.SelectMany<Communication, Communication>(b_, c_);
        bool? e_(Communication LevelOfSeverityCommunicated)
        {
            Code<EventStatus> w_ = LevelOfSeverityCommunicated?.StatusElement;
            EventStatus? x_ = w_?.Value;
            string y_ = context.Operators.Convert<string>(x_);
            bool? z_ = context.Operators.Equal(y_, "completed");

            return z_;
        };
        IEnumerable<Communication> f_ = context.Operators.Where<Communication>(d_, e_);

        return f_;
    }


    [CqlExpressionDefinition("Macular Edema Absence Communicated")]
    public IEnumerable<Communication> Macular_Edema_Absence_Communicated(CqlContext context)
    {
        CqlValueSet a_ = this.Macular_edema_absent__situation_(context);
        IEnumerable<Communication> b_ = context.Operators.Retrieve<Communication>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-communication"));
        IEnumerable<Communication> c_(Communication MacularEdemaAbsentCommunicated)
        {
            IEnumerable<Encounter> g_ = this.Diabetic_Retinopathy_Encounter(context);
            bool? h_(Encounter EncounterDiabeticRetinopathy)
            {
                FhirDateTime l_ = MacularEdemaAbsentCommunicated?.SentElement;
                CqlDateTime m_ = context.Operators.Convert<CqlDateTime>(l_);
                Period n_ = EncounterDiabeticRetinopathy?.Period;
                CqlInterval<CqlDateTime> o_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, n_);
                CqlDateTime p_ = context.Operators.Start(o_);
                bool? q_ = context.Operators.After(m_, p_, default);
                CqlDateTime s_ = context.Operators.Convert<CqlDateTime>(l_);
                CqlInterval<CqlDateTime> t_ = this.Measurement_Period(context);
                bool? u_ = context.Operators.In<CqlDateTime>(s_, t_, "day");
                bool? v_ = context.Operators.And(q_, u_);

                return v_;
            };
            IEnumerable<Encounter> i_ = context.Operators.Where<Encounter>(g_, h_);
            Communication j_(Encounter EncounterDiabeticRetinopathy) =>
                MacularEdemaAbsentCommunicated;
            IEnumerable<Communication> k_ = context.Operators.Select<Encounter, Communication>(i_, j_);

            return k_;
        };
        IEnumerable<Communication> d_ = context.Operators.SelectMany<Communication, Communication>(b_, c_);
        bool? e_(Communication MacularEdemaAbsentCommunicated)
        {
            Code<EventStatus> w_ = MacularEdemaAbsentCommunicated?.StatusElement;
            EventStatus? x_ = w_?.Value;
            string y_ = context.Operators.Convert<string>(x_);
            bool? z_ = context.Operators.Equal(y_, "completed");

            return z_;
        };
        IEnumerable<Communication> f_ = context.Operators.Where<Communication>(d_, e_);

        return f_;
    }


    [CqlExpressionDefinition("Macular Edema Presence Communicated")]
    public IEnumerable<Communication> Macular_Edema_Presence_Communicated(CqlContext context)
    {
        CqlValueSet a_ = this.Macular_Edema_Findings_Present(context);
        IEnumerable<Communication> b_ = context.Operators.Retrieve<Communication>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-communication"));
        IEnumerable<Communication> c_(Communication MacularEdemaPresentCommunicated)
        {
            IEnumerable<Encounter> g_ = this.Diabetic_Retinopathy_Encounter(context);
            bool? h_(Encounter EncounterDiabeticRetinopathy)
            {
                FhirDateTime l_ = MacularEdemaPresentCommunicated?.SentElement;
                CqlDateTime m_ = context.Operators.Convert<CqlDateTime>(l_);
                Period n_ = EncounterDiabeticRetinopathy?.Period;
                CqlInterval<CqlDateTime> o_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, n_);
                CqlDateTime p_ = context.Operators.Start(o_);
                bool? q_ = context.Operators.After(m_, p_, default);
                CqlDateTime s_ = context.Operators.Convert<CqlDateTime>(l_);
                CqlInterval<CqlDateTime> t_ = this.Measurement_Period(context);
                bool? u_ = context.Operators.In<CqlDateTime>(s_, t_, "day");
                bool? v_ = context.Operators.And(q_, u_);

                return v_;
            };
            IEnumerable<Encounter> i_ = context.Operators.Where<Encounter>(g_, h_);
            Communication j_(Encounter EncounterDiabeticRetinopathy) =>
                MacularEdemaPresentCommunicated;
            IEnumerable<Communication> k_ = context.Operators.Select<Encounter, Communication>(i_, j_);

            return k_;
        };
        IEnumerable<Communication> d_ = context.Operators.SelectMany<Communication, Communication>(b_, c_);
        bool? e_(Communication MacularEdemaPresentCommunicated)
        {
            Code<EventStatus> w_ = MacularEdemaPresentCommunicated?.StatusElement;
            EventStatus? x_ = w_?.Value;
            string y_ = context.Operators.Convert<string>(x_);
            bool? z_ = context.Operators.Equal(y_, "completed");

            return z_;
        };
        IEnumerable<Communication> f_ = context.Operators.Where<Communication>(d_, e_);

        return f_;
    }


    [CqlExpressionDefinition("Numerator")]
    public bool? Numerator(CqlContext context)
    {
        IEnumerable<Communication> a_ = this.Level_of_Severity_of_Retinopathy_Findings_Communicated(context);
        bool? b_ = context.Operators.Exists<Communication>(a_);
        IEnumerable<Communication> c_ = this.Macular_Edema_Absence_Communicated(context);
        bool? d_ = context.Operators.Exists<Communication>(c_);
        IEnumerable<Communication> e_ = this.Macular_Edema_Presence_Communicated(context);
        bool? f_ = context.Operators.Exists<Communication>(e_);
        bool? g_ = context.Operators.Or(d_, f_);
        bool? h_ = context.Operators.And(b_, g_);

        return h_;
    }


    [CqlExpressionDefinition("Medical or Patient Reason for Not Communicating Level of Severity of Retinopathy")]
    public IEnumerable<Communication> Medical_or_Patient_Reason_for_Not_Communicating_Level_of_Severity_of_Retinopathy(CqlContext context)
    {
        CqlValueSet a_ = this.Level_of_Severity_of_Retinopathy_Findings(context);
        IEnumerable<Communication> b_ = context.Operators.Retrieve<Communication>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-communicationnotdone"));
        IEnumerable<Communication> c_(Communication LevelOfSeverityNotCommunicated)
        {
            IEnumerable<Encounter> g_ = this.Diabetic_Retinopathy_Encounter(context);
            bool? h_(Encounter EncounterDiabeticRetinopathy)
            {
                FhirDateTime l_ = LevelOfSeverityNotCommunicated?.SentElement;
                CqlDateTime m_ = context.Operators.Convert<CqlDateTime>(l_);
                Period n_ = EncounterDiabeticRetinopathy?.Period;
                CqlInterval<CqlDateTime> o_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, n_);
                bool? p_ = context.Operators.In<CqlDateTime>(m_, o_, default);

                return p_;
            };
            IEnumerable<Encounter> i_ = context.Operators.Where<Encounter>(g_, h_);
            Communication j_(Encounter EncounterDiabeticRetinopathy) =>
                LevelOfSeverityNotCommunicated;
            IEnumerable<Communication> k_ = context.Operators.Select<Encounter, Communication>(i_, j_);

            return k_;
        };
        IEnumerable<Communication> d_ = context.Operators.SelectMany<Communication, Communication>(b_, c_);
        bool? e_(Communication LevelOfSeverityNotCommunicated)
        {
            CodeableConcept q_ = LevelOfSeverityNotCommunicated?.StatusReason;
            CqlConcept r_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, q_);
            CqlValueSet s_ = this.Medical_Reason(context);
            bool? t_ = context.Operators.ConceptInValueSet(r_, s_);
            CqlConcept v_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, q_);
            CqlValueSet w_ = this.Patient_Reason(context);
            bool? x_ = context.Operators.ConceptInValueSet(v_, w_);
            bool? y_ = context.Operators.Or(t_, x_);

            return y_;
        };
        IEnumerable<Communication> f_ = context.Operators.Where<Communication>(d_, e_);

        return f_;
    }


    [CqlExpressionDefinition("Medical or Patient Reason for Not Communicating Absence of Macular Edema")]
    public IEnumerable<Communication> Medical_or_Patient_Reason_for_Not_Communicating_Absence_of_Macular_Edema(CqlContext context)
    {
        CqlValueSet a_ = this.Macular_edema_absent__situation_(context);
        IEnumerable<Communication> b_ = context.Operators.Retrieve<Communication>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-communicationnotdone"));
        IEnumerable<Communication> c_(Communication MacularEdemaAbsentNotCommunicated)
        {
            IEnumerable<Encounter> g_ = this.Diabetic_Retinopathy_Encounter(context);
            bool? h_(Encounter EncounterDiabeticRetinopathy)
            {
                FhirDateTime l_ = MacularEdemaAbsentNotCommunicated?.SentElement;
                CqlDateTime m_ = context.Operators.Convert<CqlDateTime>(l_);
                Period n_ = EncounterDiabeticRetinopathy?.Period;
                CqlInterval<CqlDateTime> o_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, n_);
                bool? p_ = context.Operators.In<CqlDateTime>(m_, o_, default);

                return p_;
            };
            IEnumerable<Encounter> i_ = context.Operators.Where<Encounter>(g_, h_);
            Communication j_(Encounter EncounterDiabeticRetinopathy) =>
                MacularEdemaAbsentNotCommunicated;
            IEnumerable<Communication> k_ = context.Operators.Select<Encounter, Communication>(i_, j_);

            return k_;
        };
        IEnumerable<Communication> d_ = context.Operators.SelectMany<Communication, Communication>(b_, c_);
        bool? e_(Communication MacularEdemaAbsentNotCommunicated)
        {
            CodeableConcept q_ = MacularEdemaAbsentNotCommunicated?.StatusReason;
            CqlConcept r_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, q_);
            CqlValueSet s_ = this.Medical_Reason(context);
            bool? t_ = context.Operators.ConceptInValueSet(r_, s_);
            CqlConcept v_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, q_);
            CqlValueSet w_ = this.Patient_Reason(context);
            bool? x_ = context.Operators.ConceptInValueSet(v_, w_);
            bool? y_ = context.Operators.Or(t_, x_);

            return y_;
        };
        IEnumerable<Communication> f_ = context.Operators.Where<Communication>(d_, e_);

        return f_;
    }


    [CqlExpressionDefinition("Medical or Patient Reason for Not Communicating Presence of Macular Edema")]
    public IEnumerable<Communication> Medical_or_Patient_Reason_for_Not_Communicating_Presence_of_Macular_Edema(CqlContext context)
    {
        CqlValueSet a_ = this.Macular_Edema_Findings_Present(context);
        IEnumerable<Communication> b_ = context.Operators.Retrieve<Communication>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-communicationnotdone"));
        IEnumerable<Communication> c_(Communication MacularEdemaPresentNotCommunicated)
        {
            IEnumerable<Encounter> g_ = this.Diabetic_Retinopathy_Encounter(context);
            bool? h_(Encounter EncounterDiabeticRetinopathy)
            {
                FhirDateTime l_ = MacularEdemaPresentNotCommunicated?.SentElement;
                CqlDateTime m_ = context.Operators.Convert<CqlDateTime>(l_);
                Period n_ = EncounterDiabeticRetinopathy?.Period;
                CqlInterval<CqlDateTime> o_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, n_);
                bool? p_ = context.Operators.In<CqlDateTime>(m_, o_, default);

                return p_;
            };
            IEnumerable<Encounter> i_ = context.Operators.Where<Encounter>(g_, h_);
            Communication j_(Encounter EncounterDiabeticRetinopathy) =>
                MacularEdemaPresentNotCommunicated;
            IEnumerable<Communication> k_ = context.Operators.Select<Encounter, Communication>(i_, j_);

            return k_;
        };
        IEnumerable<Communication> d_ = context.Operators.SelectMany<Communication, Communication>(b_, c_);
        bool? e_(Communication MacularEdemaPresentNotCommunicated)
        {
            CodeableConcept q_ = MacularEdemaPresentNotCommunicated?.StatusReason;
            CqlConcept r_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, q_);
            CqlValueSet s_ = this.Medical_Reason(context);
            bool? t_ = context.Operators.ConceptInValueSet(r_, s_);
            CqlConcept v_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, q_);
            CqlValueSet w_ = this.Patient_Reason(context);
            bool? x_ = context.Operators.ConceptInValueSet(v_, w_);
            bool? y_ = context.Operators.Or(t_, x_);

            return y_;
        };
        IEnumerable<Communication> f_ = context.Operators.Where<Communication>(d_, e_);

        return f_;
    }


    [CqlExpressionDefinition("Denominator Exceptions")]
    public bool? Denominator_Exceptions(CqlContext context)
    {
        IEnumerable<Communication> a_ = this.Medical_or_Patient_Reason_for_Not_Communicating_Level_of_Severity_of_Retinopathy(context);
        bool? b_ = context.Operators.Exists<Communication>(a_);
        IEnumerable<Communication> c_ = this.Medical_or_Patient_Reason_for_Not_Communicating_Absence_of_Macular_Edema(context);
        bool? d_ = context.Operators.Exists<Communication>(c_);
        bool? e_ = context.Operators.Or(b_, d_);
        IEnumerable<Communication> f_ = this.Medical_or_Patient_Reason_for_Not_Communicating_Presence_of_Macular_Edema(context);
        bool? g_ = context.Operators.Exists<Communication>(f_);
        bool? h_ = context.Operators.Or(e_, g_);

        return h_;
    }


    [CqlExpressionDefinition("Results of Dilated Macular or Fundus Exam Communicated")]
    public bool? Results_of_Dilated_Macular_or_Fundus_Exam_Communicated(CqlContext context)
    {
        IEnumerable<Communication> a_ = this.Level_of_Severity_of_Retinopathy_Findings_Communicated(context);
        bool? b_ = context.Operators.Exists<Communication>(a_);
        IEnumerable<Communication> c_ = this.Macular_Edema_Absence_Communicated(context);
        bool? d_ = context.Operators.Exists<Communication>(c_);
        IEnumerable<Communication> e_ = this.Macular_Edema_Presence_Communicated(context);
        bool? f_ = context.Operators.Exists<Communication>(e_);
        bool? g_ = context.Operators.Or(d_, f_);
        bool? h_ = context.Operators.And(b_, g_);

        return h_;
    }


    #endregion Functions and Expressions

}

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
[CqlLibrary("DRCommunicationWithPhysicianManagingDiabetesFHIR", "0.0.004")]
public partial class DRCommunicationWithPhysicianManagingDiabetesFHIR_0_0_004 : ILibrary, ISingleton<DRCommunicationWithPhysicianManagingDiabetesFHIR_0_0_004>
{
    private DRCommunicationWithPhysicianManagingDiabetesFHIR_0_0_004() {}

    public static DRCommunicationWithPhysicianManagingDiabetesFHIR_0_0_004 Instance { get; } = new();

    #region ILibrary Implementation

    public string Name => "DRCommunicationWithPhysicianManagingDiabetesFHIR";
    public string Version => "0.0.004";
    public ILibrary[] Dependencies => [FHIRHelpers_4_0_001.Instance, SupplementalDataElementsFHIR4_2_0_000.Instance, MATGlobalCommonFunctionsFHIR4_6_1_000.Instance];

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

    #endregion ValueSets

    #region Codes

    [CqlCodeDefinition("Birth date", codeId: "21112-8", codeSystem: "http://loinc.org")]
    public CqlCode Birth_date(CqlContext _) => _Birth_date;
    private static readonly CqlCode _Birth_date = new CqlCode("21112-8", "http://loinc.org");

    [CqlCodeDefinition("Healthcare professional (occupation)", codeId: "223366009", codeSystem: "http://snomed.info/sct")]
    public CqlCode Healthcare_professional__occupation_(CqlContext _) => _Healthcare_professional__occupation_;
    private static readonly CqlCode _Healthcare_professional__occupation_ = new CqlCode("223366009", "http://snomed.info/sct");

    [CqlCodeDefinition("Macular edema absent (situation)", codeId: "428341000124108", codeSystem: "http://snomed.info/sct")]
    public CqlCode Macular_edema_absent__situation_(CqlContext _) => _Macular_edema_absent__situation_;
    private static readonly CqlCode _Macular_edema_absent__situation_ = new CqlCode("428341000124108", "http://snomed.info/sct");

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

    #endregion Codes

    #region CodeSystems

    [CqlCodeSystemDefinition("LOINC", codeSystemId: "http://loinc.org", codeSystemVersion: null)]
    public CqlCodeSystem LOINC(CqlContext _) => _LOINC;
    private static readonly CqlCodeSystem _LOINC =
      new CqlCodeSystem("http://loinc.org", null, [
          _Birth_date]);

    [CqlCodeSystemDefinition("SNOMEDCT", codeSystemId: "http://snomed.info/sct", codeSystemVersion: null)]
    public CqlCodeSystem SNOMEDCT(CqlContext _) => _SNOMEDCT;
    private static readonly CqlCodeSystem _SNOMEDCT =
      new CqlCodeSystem("http://snomed.info/sct", null, [
          _Healthcare_professional__occupation_,
          _Macular_edema_absent__situation_,
          _Medical_practitioner__occupation_,
          _Ophthalmologist__occupation_,
          _Optometrist__occupation_,
          _Physician__occupation_]);

    #endregion CodeSystems

    #region Parameters

    [CqlParameterDefinition("Measurement Period")]
    public CqlInterval<CqlDateTime> Measurement_Period(CqlContext context)
    {
        object a_ = context.ResolveParameter("DRCommunicationWithPhysicianManagingDiabetesFHIR-0.0.004", "Measurement Period", null);

        return (CqlInterval<CqlDateTime>)a_;
    }


    #endregion Parameters

    #region Functions and Expressions

    [CqlExpressionDefinition("Patient")]
    public Patient Patient(CqlContext context)
    {
        IEnumerable<Patient> a_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/StructureDefinition/Patient"));
        Patient b_ = context.Operators.SingletonFrom<Patient>(a_);

        return b_;
    }


    [CqlExpressionDefinition("SDE Ethnicity")]
    public IEnumerable<Coding> SDE_Ethnicity(CqlContext context)
    {
        IEnumerable<Coding> a_ = SupplementalDataElementsFHIR4_2_0_000.Instance.SDE_Ethnicity(context);

        return a_;
    }


    [CqlExpressionDefinition("SDE Payer")]
    public IEnumerable<(CqlTupleMetadata, CodeableConcept code, Period period)?> SDE_Payer(CqlContext context)
    {
        IEnumerable<(CqlTupleMetadata, CodeableConcept code, Period period)?> a_ = SupplementalDataElementsFHIR4_2_0_000.Instance.SDE_Payer(context);

        return a_;
    }


    [CqlExpressionDefinition("SDE Race")]
    public IEnumerable<Coding> SDE_Race(CqlContext context)
    {
        IEnumerable<Coding> a_ = SupplementalDataElementsFHIR4_2_0_000.Instance.SDE_Race(context);

        return a_;
    }


    [CqlExpressionDefinition("SDE Sex")]
    public CqlCode SDE_Sex(CqlContext context)
    {
        CqlCode a_ = SupplementalDataElementsFHIR4_2_0_000.Instance.SDE_Sex(context);

        return a_;
    }


    [CqlExpressionDefinition("Qualifying Encounter During Measurement Period")]
    public IEnumerable<Encounter> Qualifying_Encounter_During_Measurement_Period(CqlContext context)
    {
        CqlValueSet a_ = this.Office_Visit(context);
        IEnumerable<Encounter> b_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/StructureDefinition/Encounter"));
        CqlValueSet c_ = this.Ophthalmological_Services(context);
        IEnumerable<Encounter> d_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, c_, default, "http://hl7.org/fhir/StructureDefinition/Encounter"));
        IEnumerable<Encounter> e_ = context.Operators.Union<Encounter>(b_, d_);
        CqlValueSet f_ = this.Outpatient_Consultation(context);
        IEnumerable<Encounter> g_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, f_, default, "http://hl7.org/fhir/StructureDefinition/Encounter"));
        CqlValueSet h_ = this.Care_Services_in_Long_Term_Residential_Facility(context);
        IEnumerable<Encounter> i_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, h_, default, "http://hl7.org/fhir/StructureDefinition/Encounter"));
        IEnumerable<Encounter> j_ = context.Operators.Union<Encounter>(g_, i_);
        IEnumerable<Encounter> k_ = context.Operators.Union<Encounter>(e_, j_);
        CqlValueSet l_ = this.Nursing_Facility_Visit(context);
        IEnumerable<Encounter> m_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, l_, default, "http://hl7.org/fhir/StructureDefinition/Encounter"));
        IEnumerable<Encounter> n_ = context.Operators.Union<Encounter>(k_, m_);
        bool? o_(Encounter QualifyingEncounter)
        {
            CqlInterval<CqlDateTime> q_ = this.Measurement_Period(context);
            Period r_ = QualifyingEncounter?.Period;
            CqlInterval<CqlDateTime> s_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, r_);
            bool? t_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(q_, s_, default);
            Code<Encounter.EncounterStatus> u_ = QualifyingEncounter?.StatusElement;
            string v_ = FHIRHelpers_4_0_001.Instance.ToString(context, u_);
            bool? w_ = context.Operators.Equal(v_, "finished");
            bool? x_ = context.Operators.And(t_, w_);

            return x_;
        };
        IEnumerable<Encounter> p_ = context.Operators.Where<Encounter>(n_, o_);

        return p_;
    }


    [CqlExpressionDefinition("Diabetic Retinopathy Encounter")]
    public IEnumerable<Encounter> Diabetic_Retinopathy_Encounter(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Qualifying_Encounter_During_Measurement_Period(context);
        IEnumerable<Encounter> b_(Encounter ValidQualifyingEncounter)
        {
            CqlValueSet d_ = this.Diabetic_Retinopathy(context);
            IEnumerable<Condition> e_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, d_, default, "http://hl7.org/fhir/StructureDefinition/Condition"));
            bool? f_(Condition DiabeticRetinopathy)
            {
                CodeableConcept j_ = DiabeticRetinopathy?.ClinicalStatus;
                CqlConcept k_ = FHIRHelpers_4_0_001.Instance.ToConcept(context, j_);
                CqlCode l_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.active(context);
                CqlConcept m_ = context.Operators.ConvertCodeToConcept(l_);
                bool? n_ = context.Operators.Equivalent(k_, m_);
                CqlInterval<CqlDateTime> o_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Prevalence_Period(context, DiabeticRetinopathy);
                Period p_ = ValidQualifyingEncounter?.Period;
                CqlInterval<CqlDateTime> q_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, p_);
                bool? r_ = context.Operators.Overlaps(o_, q_, default);
                bool? s_ = context.Operators.And(n_, r_);

                return s_;
            };
            IEnumerable<Condition> g_ = context.Operators.Where<Condition>(e_, f_);
            Encounter h_(Condition DiabeticRetinopathy) =>
                ValidQualifyingEncounter;
            IEnumerable<Encounter> i_ = context.Operators.Select<Condition, Encounter>(g_, h_);

            return i_;
        };
        IEnumerable<Encounter> c_ = context.Operators.SelectMany<Encounter, Encounter>(a_, b_);

        return c_;
    }


    [CqlFunctionDefinition("GetModifierExtension")]
    public Extension GetModifierExtension(CqlContext context, DomainResource domainResource, string url)
    {
        IEnumerable<Extension> a_ = this.GetModifierExtensions(context, domainResource, url);
        Extension b_ = context.Operators.SingletonFrom<Extension>(a_);

        return b_;
    }


    [CqlFunctionDefinition("GetModifierExtensions")]
    public IEnumerable<Extension> GetModifierExtensions(CqlContext context, DomainResource domainResource, string url)
    {
        List<Extension> a_ = domainResource?.ModifierExtension;
        bool? b_(Extension E)
        {
            FhirUri g_ = E?.UrlElement;
            string h_ = FHIRHelpers_4_0_001.Instance.ToString(context, g_);
            string i_ = context.Operators.Concatenate("http://hl7.org/fhir/us/qicore/StructureDefinition/", url);
            bool? j_ = context.Operators.Equal(h_, i_);

            return j_;
        };
        IEnumerable<Extension> c_ = context.Operators.Where<Extension>((IEnumerable<Extension>)a_, b_);
        Extension d_(Extension E) =>
            E;
        IEnumerable<Extension> e_ = context.Operators.Select<Extension, Extension>(c_, d_);
        IEnumerable<Extension> f_ = context.Operators.Distinct<Extension>(e_);

        return f_;
    }


    [CqlExpressionDefinition("Medical or Patient Reason for Not Communicating Level of Severity of Retinopathy")]
    public IEnumerable<Communication> Medical_or_Patient_Reason_for_Not_Communicating_Level_of_Severity_of_Retinopathy(CqlContext context)
    {
        PropertyInfo a_ = typeof(Communication).GetProperty("ReasonCode");
        CqlValueSet b_ = this.Level_of_Severity_of_Retinopathy_Findings(context);
        IEnumerable<Communication> c_ = context.Operators.Retrieve<Communication>(new RetrieveParameters(a_, b_, default, "http://hl7.org/fhir/StructureDefinition/Communication"));
        IEnumerable<Communication> d_(Communication LevelOfSeverityNotCommunicated)
        {
            IEnumerable<Encounter> h_ = this.Diabetic_Retinopathy_Encounter(context);
            bool? i_(Encounter EncounterDiabeticRetinopathy)
            {
                CqlDateTime m_()
                {
                    bool q_()
                    {
                        Extension s_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.GetExtension(context, LevelOfSeverityNotCommunicated, "qicore-recorded");
                        DataType t_ = s_?.Value;
                        bool u_ = t_ is FhirDateTime;

                        return u_;
                    };
                    bool r_()
                    {
                        Extension v_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.GetExtension(context, LevelOfSeverityNotCommunicated, "qicore-recorded");
                        DataType w_ = v_?.Value;
                        bool x_ = w_ is Instant;

                        return x_;
                    };
                    if (q_())
                    {
                        Extension y_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.GetExtension(context, LevelOfSeverityNotCommunicated, "qicore-recorded");
                        DataType z_ = y_?.Value;
                        CqlDateTime aa_ = FHIRHelpers_4_0_001.Instance.ToDateTime(context, z_ as FhirDateTime);

                        return aa_;
                    }
                    else if (r_())
                    {
                        Extension ab_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.GetExtension(context, LevelOfSeverityNotCommunicated, "qicore-recorded");
                        DataType ac_ = ab_?.Value;
                        CqlDateTime ad_ = FHIRHelpers_4_0_001.Instance.ToDateTime(context, ac_ as Instant);

                        return ad_;
                    }
                    else
                    {
                        return default;
                    }
                };
                Period n_ = EncounterDiabeticRetinopathy?.Period;
                CqlInterval<CqlDateTime> o_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, n_);
                bool? p_ = context.Operators.In<CqlDateTime>(m_(), o_, default);

                return p_;
            };
            IEnumerable<Encounter> j_ = context.Operators.Where<Encounter>(h_, i_);
            Communication k_(Encounter EncounterDiabeticRetinopathy) =>
                LevelOfSeverityNotCommunicated;
            IEnumerable<Communication> l_ = context.Operators.Select<Encounter, Communication>(j_, k_);

            return l_;
        };
        IEnumerable<Communication> e_ = context.Operators.SelectMany<Communication, Communication>(c_, d_);
        bool? f_(Communication LevelOfSeverityNotCommunicated)
        {
            Code<EventStatus> ae_ = LevelOfSeverityNotCommunicated?.StatusElement;
            string af_ = FHIRHelpers_4_0_001.Instance.ToString(context, ae_);
            bool? ag_ = context.Operators.Equal(af_, "not-done");
            Extension ah_ = this.GetModifierExtension(context, LevelOfSeverityNotCommunicated, "qicore-notDone");
            DataType ai_ = ah_?.Value;
            bool? aj_ = FHIRHelpers_4_0_001.Instance.ToBoolean(context, ai_ as FhirBoolean);
            bool? ak_ = context.Operators.IsTrue(aj_);
            bool? al_ = context.Operators.And(ag_, ak_);
            CodeableConcept am_ = LevelOfSeverityNotCommunicated?.StatusReason;
            CqlConcept an_ = FHIRHelpers_4_0_001.Instance.ToConcept(context, am_);
            CqlValueSet ao_ = this.Medical_Reason(context);
            bool? ap_ = context.Operators.ConceptInValueSet(an_, ao_);
            CqlConcept ar_ = FHIRHelpers_4_0_001.Instance.ToConcept(context, am_);
            CqlValueSet as_ = this.Patient_Reason(context);
            bool? at_ = context.Operators.ConceptInValueSet(ar_, as_);
            bool? au_ = context.Operators.Or(ap_, at_);
            bool? av_ = context.Operators.And(al_, au_);

            return av_;
        };
        IEnumerable<Communication> g_ = context.Operators.Where<Communication>(e_, f_);

        return g_;
    }


    [CqlExpressionDefinition("Medical or Patient Reason for Not Communicating Absence of Macular Edema")]
    public IEnumerable<Communication> Medical_or_Patient_Reason_for_Not_Communicating_Absence_of_Macular_Edema(CqlContext context)
    {
        PropertyInfo a_ = typeof(Communication).GetProperty("ReasonCode");
        CqlCode b_ = this.Macular_edema_absent__situation_(context);
        IEnumerable<CqlCode> c_ = context.Operators.ToList<CqlCode>(b_);
        IEnumerable<Communication> d_ = context.Operators.Retrieve<Communication>(new RetrieveParameters(a_, default, c_, "http://hl7.org/fhir/StructureDefinition/Communication"));
        IEnumerable<Communication> e_(Communication MacularEdemaAbsentNotCommunicated)
        {
            IEnumerable<Encounter> i_ = this.Diabetic_Retinopathy_Encounter(context);
            bool? j_(Encounter EncounterDiabeticRetinopathy)
            {
                CqlDateTime n_()
                {
                    bool r_()
                    {
                        Extension t_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.GetExtension(context, MacularEdemaAbsentNotCommunicated, "qicore-recorded");
                        DataType u_ = t_?.Value;
                        bool v_ = u_ is FhirDateTime;

                        return v_;
                    };
                    bool s_()
                    {
                        Extension w_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.GetExtension(context, MacularEdemaAbsentNotCommunicated, "qicore-recorded");
                        DataType x_ = w_?.Value;
                        bool y_ = x_ is Instant;

                        return y_;
                    };
                    if (r_())
                    {
                        Extension z_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.GetExtension(context, MacularEdemaAbsentNotCommunicated, "qicore-recorded");
                        DataType aa_ = z_?.Value;
                        CqlDateTime ab_ = FHIRHelpers_4_0_001.Instance.ToDateTime(context, aa_ as FhirDateTime);

                        return ab_;
                    }
                    else if (s_())
                    {
                        Extension ac_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.GetExtension(context, MacularEdemaAbsentNotCommunicated, "qicore-recorded");
                        DataType ad_ = ac_?.Value;
                        CqlDateTime ae_ = FHIRHelpers_4_0_001.Instance.ToDateTime(context, ad_ as Instant);

                        return ae_;
                    }
                    else
                    {
                        return default;
                    }
                };
                Period o_ = EncounterDiabeticRetinopathy?.Period;
                CqlInterval<CqlDateTime> p_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, o_);
                bool? q_ = context.Operators.In<CqlDateTime>(n_(), p_, default);

                return q_;
            };
            IEnumerable<Encounter> k_ = context.Operators.Where<Encounter>(i_, j_);
            Communication l_(Encounter EncounterDiabeticRetinopathy) =>
                MacularEdemaAbsentNotCommunicated;
            IEnumerable<Communication> m_ = context.Operators.Select<Encounter, Communication>(k_, l_);

            return m_;
        };
        IEnumerable<Communication> f_ = context.Operators.SelectMany<Communication, Communication>(d_, e_);
        bool? g_(Communication MacularEdemaAbsentNotCommunicated)
        {
            Code<EventStatus> af_ = MacularEdemaAbsentNotCommunicated?.StatusElement;
            string ag_ = FHIRHelpers_4_0_001.Instance.ToString(context, af_);
            bool? ah_ = context.Operators.Equal(ag_, "not-done");
            Extension ai_ = this.GetModifierExtension(context, MacularEdemaAbsentNotCommunicated, "qicore-notDone");
            DataType aj_ = ai_?.Value;
            bool? ak_ = FHIRHelpers_4_0_001.Instance.ToBoolean(context, aj_ as FhirBoolean);
            bool? al_ = context.Operators.IsTrue(ak_);
            bool? am_ = context.Operators.And(ah_, al_);
            CodeableConcept an_ = MacularEdemaAbsentNotCommunicated?.StatusReason;
            CqlConcept ao_ = FHIRHelpers_4_0_001.Instance.ToConcept(context, an_);
            CqlValueSet ap_ = this.Medical_Reason(context);
            bool? aq_ = context.Operators.ConceptInValueSet(ao_, ap_);
            CqlConcept as_ = FHIRHelpers_4_0_001.Instance.ToConcept(context, an_);
            CqlValueSet at_ = this.Patient_Reason(context);
            bool? au_ = context.Operators.ConceptInValueSet(as_, at_);
            bool? av_ = context.Operators.Or(aq_, au_);
            bool? aw_ = context.Operators.And(am_, av_);

            return aw_;
        };
        IEnumerable<Communication> h_ = context.Operators.Where<Communication>(f_, g_);

        return h_;
    }


    [CqlExpressionDefinition("Medical or Patient Reason for Not Communicating Presence of Macular Edema")]
    public IEnumerable<Communication> Medical_or_Patient_Reason_for_Not_Communicating_Presence_of_Macular_Edema(CqlContext context)
    {
        PropertyInfo a_ = typeof(Communication).GetProperty("ReasonCode");
        CqlValueSet b_ = this.Macular_Edema_Findings_Present(context);
        IEnumerable<Communication> c_ = context.Operators.Retrieve<Communication>(new RetrieveParameters(a_, b_, default, "http://hl7.org/fhir/StructureDefinition/Communication"));
        IEnumerable<Communication> d_(Communication MacularEdemaPresentNotCommunicated)
        {
            IEnumerable<Encounter> h_ = this.Diabetic_Retinopathy_Encounter(context);
            bool? i_(Encounter EncounterDiabeticRetinopathy)
            {
                CqlDateTime m_()
                {
                    bool q_()
                    {
                        Extension s_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.GetExtension(context, MacularEdemaPresentNotCommunicated, "qicore-recorded");
                        DataType t_ = s_?.Value;
                        bool u_ = t_ is FhirDateTime;

                        return u_;
                    };
                    bool r_()
                    {
                        Extension v_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.GetExtension(context, MacularEdemaPresentNotCommunicated, "qicore-recorded");
                        DataType w_ = v_?.Value;
                        bool x_ = w_ is Instant;

                        return x_;
                    };
                    if (q_())
                    {
                        Extension y_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.GetExtension(context, MacularEdemaPresentNotCommunicated, "qicore-recorded");
                        DataType z_ = y_?.Value;
                        CqlDateTime aa_ = FHIRHelpers_4_0_001.Instance.ToDateTime(context, z_ as FhirDateTime);

                        return aa_;
                    }
                    else if (r_())
                    {
                        Extension ab_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.GetExtension(context, MacularEdemaPresentNotCommunicated, "qicore-recorded");
                        DataType ac_ = ab_?.Value;
                        CqlDateTime ad_ = FHIRHelpers_4_0_001.Instance.ToDateTime(context, ac_ as Instant);

                        return ad_;
                    }
                    else
                    {
                        return default;
                    }
                };
                Period n_ = EncounterDiabeticRetinopathy?.Period;
                CqlInterval<CqlDateTime> o_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, n_);
                bool? p_ = context.Operators.In<CqlDateTime>(m_(), o_, default);

                return p_;
            };
            IEnumerable<Encounter> j_ = context.Operators.Where<Encounter>(h_, i_);
            Communication k_(Encounter EncounterDiabeticRetinopathy) =>
                MacularEdemaPresentNotCommunicated;
            IEnumerable<Communication> l_ = context.Operators.Select<Encounter, Communication>(j_, k_);

            return l_;
        };
        IEnumerable<Communication> e_ = context.Operators.SelectMany<Communication, Communication>(c_, d_);
        bool? f_(Communication MacularEdemaPresentNotCommunicated)
        {
            Code<EventStatus> ae_ = MacularEdemaPresentNotCommunicated?.StatusElement;
            string af_ = FHIRHelpers_4_0_001.Instance.ToString(context, ae_);
            bool? ag_ = context.Operators.Equal(af_, "not-done");
            Extension ah_ = this.GetModifierExtension(context, MacularEdemaPresentNotCommunicated, "qicore-notDone");
            DataType ai_ = ah_?.Value;
            bool? aj_ = FHIRHelpers_4_0_001.Instance.ToBoolean(context, ai_ as FhirBoolean);
            bool? ak_ = context.Operators.IsTrue(aj_);
            bool? al_ = context.Operators.And(ag_, ak_);
            CodeableConcept am_ = MacularEdemaPresentNotCommunicated?.StatusReason;
            CqlConcept an_ = FHIRHelpers_4_0_001.Instance.ToConcept(context, am_);
            CqlValueSet ao_ = this.Medical_Reason(context);
            bool? ap_ = context.Operators.ConceptInValueSet(an_, ao_);
            CqlConcept ar_ = FHIRHelpers_4_0_001.Instance.ToConcept(context, am_);
            CqlValueSet as_ = this.Patient_Reason(context);
            bool? at_ = context.Operators.ConceptInValueSet(ar_, as_);
            bool? au_ = context.Operators.Or(ap_, at_);
            bool? av_ = context.Operators.And(al_, au_);

            return av_;
        };
        IEnumerable<Communication> g_ = context.Operators.Where<Communication>(e_, f_);

        return g_;
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


    [CqlExpressionDefinition("Initial Population")]
    public bool? Initial_Population(CqlContext context)
    {
        Patient a_ = this.Patient(context);
        Date b_ = a_?.BirthDateElement;
        string c_ = b_?.Value;
        CqlDateTime d_ = context.Operators.ConvertStringToDateTime(c_);
        CqlInterval<CqlDateTime> e_ = this.Measurement_Period(context);
        CqlDateTime f_ = context.Operators.Start(e_);
        int? g_ = context.Operators.CalculateAgeAt(d_, f_, "year");
        bool? h_ = context.Operators.GreaterOrEqual(g_, 18);
        IEnumerable<Encounter> i_ = this.Diabetic_Retinopathy_Encounter(context);
        bool? j_ = context.Operators.Exists<Encounter>(i_);
        bool? k_ = context.Operators.And(h_, j_);

        return k_;
    }


    [CqlExpressionDefinition("Macular Exam Performed")]
    public IEnumerable<Observation> Macular_Exam_Performed(CqlContext context)
    {
        CqlValueSet a_ = this.Macular_Exam(context);
        IEnumerable<Observation> b_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/StructureDefinition/Observation"));
        IEnumerable<Observation> c_(Observation MacularExam)
        {
            IEnumerable<Encounter> g_ = this.Diabetic_Retinopathy_Encounter(context);
            bool? h_(Encounter EncounterDiabeticRetinopathy)
            {
                Period l_ = EncounterDiabeticRetinopathy?.Period;
                CqlInterval<CqlDateTime> m_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, l_);
                DataType n_ = MacularExam?.Effective;
                CqlInterval<CqlDateTime> o_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, n_);
                bool? p_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(m_, o_, default);

                return p_;
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
            Code<ObservationStatus> q_ = MacularExam?.StatusElement;
            string r_ = FHIRHelpers_4_0_001.Instance.ToString(context, q_);
            string[] s_ = [
                "final",
                "amended",
                "corrected",
            ];
            bool? t_ = context.Operators.In<string>(r_, s_ as IEnumerable<string>);
            DataType u_ = MacularExam?.Value;
            bool? v_ = context.Operators.Not((bool?)(u_ is null));
            bool? w_ = context.Operators.And(t_, v_);

            return w_;
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
        PropertyInfo a_ = typeof(Communication).GetProperty("ReasonCode");
        CqlValueSet b_ = this.Level_of_Severity_of_Retinopathy_Findings(context);
        IEnumerable<Communication> c_ = context.Operators.Retrieve<Communication>(new RetrieveParameters(a_, b_, default, "http://hl7.org/fhir/StructureDefinition/Communication"));
        IEnumerable<Communication> d_(Communication LevelOfSeverityCommunicated)
        {
            IEnumerable<Encounter> h_ = this.Diabetic_Retinopathy_Encounter(context);
            bool? i_(Encounter EncounterDiabeticRetinopathy)
            {
                FhirDateTime m_ = LevelOfSeverityCommunicated?.SentElement;
                CqlDateTime n_ = FHIRHelpers_4_0_001.Instance.ToDateTime(context, m_);
                Period o_ = EncounterDiabeticRetinopathy?.Period;
                CqlInterval<CqlDateTime> p_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, o_);
                CqlDateTime q_ = context.Operators.Start(p_);
                bool? r_ = context.Operators.After(n_, q_, default);

                return r_;
            };
            IEnumerable<Encounter> j_ = context.Operators.Where<Encounter>(h_, i_);
            Communication k_(Encounter EncounterDiabeticRetinopathy) =>
                LevelOfSeverityCommunicated;
            IEnumerable<Communication> l_ = context.Operators.Select<Encounter, Communication>(j_, k_);

            return l_;
        };
        IEnumerable<Communication> e_ = context.Operators.SelectMany<Communication, Communication>(c_, d_);
        bool? f_(Communication LevelOfSeverityCommunicated)
        {
            Code<EventStatus> s_ = LevelOfSeverityCommunicated?.StatusElement;
            string t_ = FHIRHelpers_4_0_001.Instance.ToString(context, s_);
            bool? u_ = context.Operators.Equal(t_, "completed");

            return u_;
        };
        IEnumerable<Communication> g_ = context.Operators.Where<Communication>(e_, f_);

        return g_;
    }


    [CqlExpressionDefinition("Macular Edema Absence Communicated")]
    public IEnumerable<Communication> Macular_Edema_Absence_Communicated(CqlContext context)
    {
        PropertyInfo a_ = typeof(Communication).GetProperty("ReasonCode");
        CqlCode b_ = this.Macular_edema_absent__situation_(context);
        IEnumerable<CqlCode> c_ = context.Operators.ToList<CqlCode>(b_);
        IEnumerable<Communication> d_ = context.Operators.Retrieve<Communication>(new RetrieveParameters(a_, default, c_, "http://hl7.org/fhir/StructureDefinition/Communication"));
        IEnumerable<Communication> e_(Communication MacularEdemaAbsentCommunicated)
        {
            IEnumerable<Encounter> i_ = this.Diabetic_Retinopathy_Encounter(context);
            bool? j_(Encounter EncounterDiabeticRetinopathy)
            {
                FhirDateTime n_ = MacularEdemaAbsentCommunicated?.SentElement;
                CqlDateTime o_ = FHIRHelpers_4_0_001.Instance.ToDateTime(context, n_);
                Period p_ = EncounterDiabeticRetinopathy?.Period;
                CqlInterval<CqlDateTime> q_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, p_);
                CqlDateTime r_ = context.Operators.Start(q_);
                bool? s_ = context.Operators.After(o_, r_, default);

                return s_;
            };
            IEnumerable<Encounter> k_ = context.Operators.Where<Encounter>(i_, j_);
            Communication l_(Encounter EncounterDiabeticRetinopathy) =>
                MacularEdemaAbsentCommunicated;
            IEnumerable<Communication> m_ = context.Operators.Select<Encounter, Communication>(k_, l_);

            return m_;
        };
        IEnumerable<Communication> f_ = context.Operators.SelectMany<Communication, Communication>(d_, e_);
        bool? g_(Communication MacularEdemaAbsentCommunicated)
        {
            Code<EventStatus> t_ = MacularEdemaAbsentCommunicated?.StatusElement;
            string u_ = FHIRHelpers_4_0_001.Instance.ToString(context, t_);
            bool? v_ = context.Operators.Equal(u_, "completed");

            return v_;
        };
        IEnumerable<Communication> h_ = context.Operators.Where<Communication>(f_, g_);

        return h_;
    }


    [CqlExpressionDefinition("Macular Edema Presence Communicated")]
    public IEnumerable<Communication> Macular_Edema_Presence_Communicated(CqlContext context)
    {
        PropertyInfo a_ = typeof(Communication).GetProperty("ReasonCode");
        CqlValueSet b_ = this.Macular_Edema_Findings_Present(context);
        IEnumerable<Communication> c_ = context.Operators.Retrieve<Communication>(new RetrieveParameters(a_, b_, default, "http://hl7.org/fhir/StructureDefinition/Communication"));
        IEnumerable<Communication> d_(Communication MacularEdemaPresentCommunicated)
        {
            IEnumerable<Encounter> h_ = this.Diabetic_Retinopathy_Encounter(context);
            bool? i_(Encounter EncounterDiabeticRetinopathy)
            {
                FhirDateTime m_ = MacularEdemaPresentCommunicated?.SentElement;
                CqlDateTime n_ = FHIRHelpers_4_0_001.Instance.ToDateTime(context, m_);
                Period o_ = EncounterDiabeticRetinopathy?.Period;
                CqlInterval<CqlDateTime> p_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, o_);
                CqlDateTime q_ = context.Operators.Start(p_);
                bool? r_ = context.Operators.After(n_, q_, default);

                return r_;
            };
            IEnumerable<Encounter> j_ = context.Operators.Where<Encounter>(h_, i_);
            Communication k_(Encounter EncounterDiabeticRetinopathy) =>
                MacularEdemaPresentCommunicated;
            IEnumerable<Communication> l_ = context.Operators.Select<Encounter, Communication>(j_, k_);

            return l_;
        };
        IEnumerable<Communication> e_ = context.Operators.SelectMany<Communication, Communication>(c_, d_);
        bool? f_(Communication MacularEdemaPresentCommunicated)
        {
            Code<EventStatus> s_ = MacularEdemaPresentCommunicated?.StatusElement;
            string t_ = FHIRHelpers_4_0_001.Instance.ToString(context, s_);
            bool? u_ = context.Operators.Equal(t_, "completed");

            return u_;
        };
        IEnumerable<Communication> g_ = context.Operators.Where<Communication>(e_, f_);

        return g_;
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


    #endregion Functions and Expressions

}
